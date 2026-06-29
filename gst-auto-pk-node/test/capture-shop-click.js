const { FridaSession } = require('../src/frida-session');
const config = require('../config');

async function run() {
  const frida = new FridaSession(config.PACKAGE_NAME, 'frida-scripts/bot.bundle.js');
  await frida.connect();
  
  console.log("==========================================================");
  console.log("PLEASE GO TO THE GAME AND TAP ON ANY NEARBY PLAYER SHOP!!!");
  console.log("WAIT 10 SECONDS AFTER TAPPING.");
  console.log("==========================================================");
  
  await frida.loadScript('frida-scripts/bot.bundle.js');
  await new Promise(r => setTimeout(r, 1000));
  await frida.callRpc('setCaptureAllSends', true);
  
  let totalTime = 0;
  while (totalTime < 60000) {
    const res = await frida.callRpc('getSentPackets', 100);
    if (res && res.ok && res.packets && res.packets.length > 0) {
      for (const pkt of res.packets) {
        console.log(`[OUT] Opcode: ${pkt.opcode} (${pkt.name}) | Size: ${pkt.size} | Hex: ${pkt.hex}`);
      }
    }
    
    await new Promise(r => setTimeout(r, 1000));
    totalTime += 1000;
  }
  
  frida.disconnect();
}

run().catch(console.error);
