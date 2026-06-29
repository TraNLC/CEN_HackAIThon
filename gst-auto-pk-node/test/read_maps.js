const adb = require('../src/adb');
const fs = require('fs');

async function main() {
  // Find game pid
  const pidStr = adb.adbDeviceShell('emulator-5556', 'pidof vn.perfingame.jx1mobile').toString().trim();
  console.log('Game PID:', pidStr);
  
  if (!pidStr) {
    console.error('Game not running!');
    return;
  }
  
  // Read maps
  const maps = adb.adbDeviceShell('emulator-5556', `cat /proc/${pidStr}/maps`).toString();
  const lines = maps.split('\n');
  console.log('Matches for il2cpp:');
  lines.forEach(line => {
    if (line.indexOf('il2cpp') !== -1) {
      console.log(line);
    }
  });
}

main().catch(console.error);
