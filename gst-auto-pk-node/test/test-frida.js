// test/test-frida.js — Test Step 2: Frida Attach + Hello World
// Chạy: node test/test-frida.js

const { FridaSession } = require('../src/frida-session');
const config = require('../config');
const path = require('path');

const DEVICE_ID = null; // Set to null to auto-detect device with game running

async function main() {
  console.log('═══════════════════════════════════════');
  console.log('  STEP 2: Frida Attach Test');
  console.log('═══════════════════════════════════════\n');

  const frida = new FridaSession(DEVICE_ID, config.GAME_PACKAGE);

  // Test 1: Connect
  console.log('▶ Test 1: Frida connect()');
  try {
    await frida.connect();
    console.log('  ✅ PASS: Connected to device\n');
  } catch (err) {
    console.log(`  ❌ FAIL: ${err.message}`);
    console.log('  Tips: Make sure frida-server is running on device:');
    console.log('    adb shell "su -c /data/local/tmp/frida-server -D"');
    process.exit(1);
  }

  // Test 2: Load script
  console.log('▶ Test 2: Load test-hello.js');
  const scriptPath = path.join(config.FRIDA_SCRIPTS_DIR, 'test-hello.js');
  
  // Collect messages
  const messages = [];
  frida.onMessage((payload) => {
    messages.push(payload);
    const prefix = payload.type === 'error' ? '❌' : payload.type === 'warn' ? '⚠️' : '  ';
    console.log(`  ${prefix} [${payload.type}] ${payload.msg || payload.name || JSON.stringify(payload)}`);
  });

  try {
    await frida.loadScript(scriptPath);
    console.log('  ✅ PASS: Script loaded\n');
  } catch (err) {
    console.log(`  ❌ FAIL: ${err.message}`);
    await frida.disconnect();
    process.exit(1);
  }

  // Test 3: Call RPC ping()
  console.log('▶ Test 3: RPC ping()');
  try {
    const result = await frida.callRpc('ping');
    console.log(`  Result: ${JSON.stringify(result)}`);
    console.log('  ✅ PASS: RPC works\n');
  } catch (err) {
    console.log(`  ❌ FAIL: ${err.message}\n`);
  }

  // Test 4: Call RPC getProcessInfo()
  console.log('▶ Test 4: RPC getProcessInfo()');
  try {
    const info = await frida.callRpc('getProcessInfo');
    console.log(`  Process: ${info.name}, Arch: ${info.arch}, PID: ${info.pid}`);
    console.log('  ✅ PASS\n');
  } catch (err) {
    console.log(`  ❌ FAIL: ${err.message}\n`);
  }

  // Đợi message từ script (async, qua send())
  console.log('Waiting 3s for async messages from script...');
  await sleep(3000);

  // Summary
  const logMsgs = messages.filter(m => m.type === 'log');
  const warnMsgs = messages.filter(m => m.type === 'warn');
  const errMsgs = messages.filter(m => m.type === 'error');

  console.log('\n═══════════════════════════════════════');
  console.log(`  STEP 2: ${errMsgs.length === 0 ? '✅ PASS' : '⚠️  PARTIAL'}`);
  console.log(`  Log: ${logMsgs.length}, Warn: ${warnMsgs.length}, Error: ${errMsgs.length}`);
  console.log('═══════════════════════════════════════');

  await frida.disconnect();
}

function sleep(ms) {
  return new Promise(resolve => setTimeout(resolve, ms));
}

main().catch(err => {
  console.error('❌ FATAL:', err.message);
  process.exit(1);
});
