// tools/split-dump.js — Split massive dump.cs into per-namespace files
// Run: node tools/split-dump.js
// Input:  GSTAuto_PK_Windows/Il2CppDumper-net6-v6.7.46/dump.cs (13MB, 406K lines)
// Output: data/dump/*.cs + data/dump/_index.json

const fs = require('fs');
const path = require('path');

const INPUT = path.join(__dirname, '..', '..', 'GSTAuto_PK_Windows', 'Il2CppDumper-net6-v6.7.46', 'dump.cs');
const OUTDIR = path.join(__dirname, '..', 'data', 'dump');

// Ensure output dir
fs.mkdirSync(OUTDIR, { recursive: true });

console.log('[split-dump] Reading dump.cs...');
const content = fs.readFileSync(INPUT, 'utf-8');
const lines = content.split('\n');
console.log(`[split-dump] ${lines.length} lines, ${(content.length / 1024 / 1024).toFixed(1)} MB`);

// Parse image headers (first ~46 lines)
const images = [];
for (const line of lines) {
  const match = line.match(/^\/\/ Image (\d+): (.+?) - (\d+)$/);
  if (match) {
    images.push({ id: parseInt(match[1]), name: match[2], startIndex: parseInt(match[3]) });
  }
}

// Split by namespace
let currentNamespace = '_header';
let currentHeader = [];
let currentLines = [];
const namespaceFiles = {}; // namespace -> { lines, image }

for (let i = 0; i < lines.length; i++) {
  const line = lines[i];
  
  // Collect header (first 46 lines = image index)
  if (i < 46) {
    currentHeader.push(line);
    continue;
  }

  // Detect namespace boundary
  const nsMatch = line.match(/^\/\/ Namespace: (.+)$/);
  if (nsMatch) {
    // Flush previous namespace
    if (currentLines.length > 1) {
      const safeName = sanitizeName(currentNamespace);
      if (!namespaceFiles[safeName]) {
        namespaceFiles[safeName] = { lines: currentHeader.slice(), image: detectImage(currentNamespace, images) };
      }
      namespaceFiles[safeName].lines.push(...currentLines);
    }
    currentNamespace = nsMatch[1].trim() || '_global';
    currentLines = [line];
    continue;
  }

  currentLines.push(line);
}

// Flush last namespace
if (currentLines.length > 1) {
  const safeName = sanitizeName(currentNamespace);
  if (!namespaceFiles[safeName]) {
    namespaceFiles[safeName] = { lines: currentHeader.slice(), image: detectImage(currentNamespace, images) };
  }
  namespaceFiles[safeName].lines.push(...currentLines);
}

// Write files
console.log(`[split-dump] Writing ${Object.keys(namespaceFiles).length} namespace files...`);

const index = {
  source: 'dump.cs (Il2CppDumper)',
  images: images,
  namespaces: [],
  totalLines: lines.length,
};

for (const [nsName, data] of Object.entries(namespaceFiles)) {
  const filename = nsName + '.cs';
  const filePath = path.join(OUTDIR, filename);
  const content = data.lines.join('\n');
  fs.writeFileSync(filePath, content, 'utf-8');

  index.namespaces.push({
    name: nsName,
    file: filename,
    lines: data.lines.length,
    sizeKB: Math.round(content.length / 1024),
    image: data.image,
  });
}

// Sort index by image then namespace
index.namespaces.sort((a, b) => {
  if (a.image !== b.image) return (a.image || '').localeCompare(b.image || '');
  return a.name.localeCompare(b.name);
});

// Write index
fs.writeFileSync(path.join(OUTDIR, '_index.json'), JSON.stringify(index, null, 2), 'utf-8');

// Summary
const totalSize = Object.values(namespaceFiles).reduce((sum, d) => sum + d.lines.join('\n').length, 0);
console.log(`\n✅ Done! ${Object.keys(namespaceFiles).length} files → data/dump/`);
console.log(`   Total: ${(totalSize / 1024 / 1024).toFixed(1)} MB`);
console.log(`   Index: data/dump/_index.json`);

// Show Assembly-CSharp namespaces (most important)
const asmSharp = index.namespaces.filter(n => n.image === 'Assembly-CSharp.dll');
console.log(`\n📦 Assembly-CSharp.dll: ${asmSharp.length} namespaces`);
const top10 = asmSharp.sort((a, b) => b.lines - a.lines).slice(0, 10);
for (const ns of top10) {
  console.log(`   ${ns.name.padEnd(30)} ${ns.lines} lines  (${ns.sizeKB} KB)`);
}

// ==================== Helpers ====================

function sanitizeName(name) {
  return name
    .replace(/[<>:"/\\|?*]/g, '_')
    .replace(/\.\./g, '_')
    .replace(/^\./, '_')
    .trim() || '_global';
}

function detectImage(namespace, images) {
  // Most game classes are in Assembly-CSharp
  const gameNs = ['game.', 'Game', 'game_', 'FPS', 'Npc', 'Player', 'Skill', 'Item', 'Map',
    'Shop', 'Quest', 'Dialog', 'UI', 'network', 'Network', 'proto', 'Proto',
    'Controller', 'Datafield', 'Identify', 'Faction', 'Joystick', 'Effect',
    'Sound', 'Music', 'Scene', 'Camera', 'Input', 'Touch', 'Event',
    'Common', 'common', 'Helper', 'Manager', 'Config', 'Setting'];
  
  for (const prefix of gameNs) {
    if (namespace.toLowerCase().startsWith(prefix.toLowerCase())) {
      return 'Assembly-CSharp.dll';
    }
  }

  // Unity engine namespaces
  if (namespace.startsWith('UnityEngine.') || namespace.startsWith('Unity.')) {
    return 'UnityEngine.CoreModule.dll';
  }

  // System namespaces
  if (namespace.startsWith('System.') || namespace === 'System') {
    return 'System.dll';
  }

  // Default to first image (mscorlib)
  return images.length > 0 ? images[0].name : 'unknown';
}
