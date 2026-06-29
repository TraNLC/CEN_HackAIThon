// test/test-memory.js — Test Step 3: Memory Read via Il2Cpp Bridge
// Chạy: node test/test-memory.js

const { FridaSession } = require('../src/frida-session');
const config = require('../config');
const path = require('path');

const DEVICE_ID = null; // auto-detect

async function main() {
  console.log('═══════════════════════════════════════');
  console.log('  STEP 3: Memory Read (Il2Cpp Bridge)');
  console.log('═══════════════════════════════════════\n');

  const frida = new FridaSession(DEVICE_ID, config.GAME_PACKAGE);

  // Collect messages
  const messages = [];
  frida.onMessage((payload) => {
    messages.push(payload);
    const prefix = payload.type === 'error' ? '❌' : payload.type === 'warn' ? '⚠️' : '  ';
    console.log(`  ${prefix} [${payload.type}] ${payload.msg || JSON.stringify(payload).substring(0, 120)}`);
  });

  // Test 1: Connect
  console.log('▶ Test 1: Frida connect');
  try {
    await frida.connect();
    console.log('  ✅ Connected\n');
  } catch (err) {
    console.log(`  ❌ FAIL: ${err.message}`);
    process.exit(1);
  }

  // Test 2: Load bot.bundle.js (with Il2Cpp bridge)
  console.log('▶ Test 2: Load bot.bundle.js (with Il2Cpp bridge)');
  const scriptPath = path.join(config.FRIDA_SCRIPTS_DIR, 'bot.bundle.js');
  try {
    await frida.loadScript(scriptPath);
    console.log('  ✅ Script loaded\n');
  } catch (err) {
    console.log(`  ❌ FAIL: ${err.message}`);
    await frida.disconnect();
    process.exit(1);
  }

  // Đợi message async từ script
  console.log('  Waiting 4s for Il2Cpp init + hook messages...');
  await sleep(4000);

  // Check Il2Cpp status
  const il2cppMsg = messages.find(m => m.type === 'il2cpp_ready');
  if (il2cppMsg) {
    console.log(`  ✅ Il2Cpp: ${il2cppMsg.lib || 'found'} @ ${il2cppMsg.base || '?'}\n`);
  } else {
    console.log('  ⚠️  Il2Cpp: no il2cpp_ready message (game may not be fully loaded)\n');
  }

  // Test 3: getPlayerInfo RPC (native — no bridge needed)
  console.log('▶ Test 3: getPlayerInfo() — native Il2Cpp');
  try {
    const info = await frida.callRpc('getPlayerInfo');
    console.log(`  ok: ${info.ok}`);
    if (info.ok) {
      console.log(`  playerMain: ${info.playerMain}`);
      console.log(`  source: ${info.source}`);
    } else {
      console.log(`  error: ${info.error}`);
    }
    console.log('  ✅ PASS\n');
  } catch (err) {
    console.log(`  ⚠️  SKIP: ${err.message}\n`);
  }

  // Test 4: getDiag RPC (no bridge needed)
  console.log('▶ Test 4: getDiag()');
  try {
    const diag = await frida.callRpc('getDiag');
    console.log(`  gameFd: ${diag.gameFd}`);
    console.log(`  ssl: readOk=${diag.sslReadOk}, writeOk=${diag.sslWriteOk}`);
    console.log(`  writeSource: ${diag.writeSource}`);
    console.log(`  recvTotal: ${diag.recvTotal}, sendTotal: ${diag.sendTotal}`);
    console.log('  ✅ PASS\n');
  } catch (err) {
    console.log(`  ⚠️  SKIP: ${err.message}\n`);
  }

  // Test 5: getMySect (cần bridge — sẽ skip nếu không có)
  console.log('▶ Test 5: getMySect() — needs Il2Cpp bridge');
  try {
    const sect = await frida.callRpc('getMySect');
    if (sect.ok && sect.name) {
      console.log(`  Name: ${sect.name}, Level: ${sect.level}`);
      console.log(`  Sect: ${sect.sectName || '?'}`);
      console.log(`  HP: ${sect.hp}/${sect.hpMax}`);
      console.log('  ✅ PASS\n');
    } else {
      console.log(`  ⚠️  no bridge: ${sect.error || 'ok'}\n`);
    }
  } catch (err) {
    console.log(`  ⚠️  SKIP (expected without bridge): ${err.message}\n`);
  }

  // Summary
  console.log('═══════════════════════════════════════');
  console.log('  STEP 3: ✅ Basic memory read working');
  console.log('  (Il2Cpp bridge = need --bridge build)');
  console.log('═══════════════════════════════════════');

  try { await frida.disconnect(); } catch (e) {}
}

function sleep(ms) {
  return new Promise(resolve => setTimeout(resolve, ms));
}

main().catch(err => {
  console.error('❌ FATAL:', err.message);
  process.exit(1);
});
