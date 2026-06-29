// test/test-adb.js — Test Step 1: ADB Module
// Chạy: node test/test-adb.js

const adb = require('../src/adb');

async function main() {
  console.log('═══════════════════════════════════════');
  console.log('  STEP 1: ADB Connection Test');
  console.log('═══════════════════════════════════════\n');

  // Test 1: List devices
  console.log('▶ Test 1: listDevices()');
  const devices = adb.listDevices();
  console.log(`  Found ${devices.length} device(s):`);
  devices.forEach(d => console.log(`    - ${d.id} (${d.status})`));
  
  if (devices.length === 0) {
    console.log('  ❌ FAIL: No devices found. Check emulator + ADB.');
    process.exit(1);
  }
  console.log('  ✅ PASS\n');

  // Test 2: Auto-detect device with game
  console.log('▶ Test 2: detectDevice()');
  const detected = adb.detectDevice();
  if (detected) {
    console.log(`  Device: ${detected.deviceId}, PID: ${detected.pid}`);
    console.log('  ✅ PASS\n');
  } else {
    console.log('  ⚠️  WARN: No device running game\n');
  }

  // Test 3: detectDevices() — all instances
  console.log('▶ Test 3: detectDevices()');
  const all = adb.detectDevices();
  console.log(`  Found ${all.length} device(s) running game:`);
  all.forEach(d => console.log(`    - ${d.deviceId} (PID ${d.pid})`));
  console.log(`  ${all.length > 0 ? '✅ PASS' : '⚠️  No game instances'}\n`);

  // Test 4: Game foreground check (if device found)
  if (detected) {
    const dev = detected.deviceId;
    console.log(`▶ Test 4: isGameForeground(${dev})`);
    const fg = adb.isGameForeground(dev);
    console.log(`  Game in foreground: ${fg}`);
    console.log(`  ${fg ? '✅ PASS' : '⚠️  WARN'}\n`);
  }

  console.log('═══════════════════════════════════════');
  console.log('  STEP 1 COMPLETE');
  console.log('═══════════════════════════════════════');
}

main().catch(err => {
  console.error('❌ ERROR:', err.message);
  process.exit(1);
});
