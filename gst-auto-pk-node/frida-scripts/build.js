// frida-scripts/build.js — Build bot.bundle.js
// DEFAULT: raw build (NO bridge — game-safe, no crash)
//   node frida-scripts/build.js --bridge  → WITH vendor il2cpp-bridge
//   node frida-scripts/build.js           → raw (safe)

const fs = require('fs');
const path = require('path');
const { execSync } = require('child_process');

const ROOT = __dirname;
const WITH_BRIDGE = process.argv.includes('--bridge');
const VENDOR_BRIDGE = path.join(ROOT, '..', '..', 'GSTAuto_PK_Windows', 'vendor', 'il2cpp-bridge.js');

const MODULES = [
  'core/globals.js', 'core/helpers.js', 'core/opcodes.js', 'core/il2cpp-init.js',
  'hooks/native-funcs.js', 'hooks/anti-detection.js', 'hooks/connect.js', 'hooks/recv.js', 'hooks/send.js',
  'rpc/packet-io.js', 
  'rpc/core/Il2CppUtils.js', 'rpc/core/PlayerManager.js', 'rpc/core/DialogManager.js', 'rpc/shop/ShopScanner.js',
  'rpc/movement.js', 'rpc/combat.js',
  'rpc/ui-control.js', 'rpc/diagnostics.js', 'ready.js',
];

function build() {
  const lines = ["'use strict';", '', 'rpc.exports = {};', ''];

  for (const m of MODULES) {
    const fp = path.join(ROOT, m);
    if (!fs.existsSync(fp)) { console.error(`  MISSING: ${m}`); continue; }
    lines.push(`// ══ ${m} ══`);
    lines.push(fs.readFileSync(fp, 'utf-8').trim());
    lines.push('');
  }

  lines.push('// ══ Bot Ready ══');
  lines.push('send({ type: "bot_ready", exports: Object.keys(rpc.exports), timestamp: Date.now() });');

  const botCode = lines.join('\n');
  const out = path.join(ROOT, 'bot.bundle.js');
  let bridge = 'none';

  if (WITH_BRIDGE && fs.existsSync(VENDOR_BRIDGE)) {
    // Explicit --bridge flag: prepend vendor bridge (same as old Python project)
    console.log('[build] Using vendor il2cpp-bridge.js (--bridge flag)');
    const bridgeCode = fs.readFileSync(VENDOR_BRIDGE, 'utf-8');
    fs.writeFileSync(out, bridgeCode + '\n;\n' + botCode, 'utf-8');
    bridge = 'vendor';
    console.log('[build] ⚠️  Bridge mode: may crash game. Use without --bridge for safe mode.');
  } else if (WITH_BRIDGE) {
    console.log('[build] Vendor bridge not found, falling back to raw (safe)');
    fs.writeFileSync(out, botCode, 'utf-8');
  } else {
    // Default: raw build (NO bridge, NO crash)
    console.log('[build] Raw build (safe mode — no bridge, no crash)');
    fs.writeFileSync(out, botCode, 'utf-8');
  }

  const kb = (fs.statSync(out).size / 1024).toFixed(1);
  console.log(`✅ bot.bundle.js (${kb} KB, ${MODULES.length} modules, bridge: ${bridge})`);
}

build();
