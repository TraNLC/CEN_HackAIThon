const frida = require('../frida-scripts/test-runner/frida-runner.js');

async function test() {
  console.log("=======================================");
  console.log("PLEASE CLICK ON A PLAYER SHOP IN THE GAME NOW!");
  console.log("=======================================");
  
  // Enable packet capture for ALL packets
  await frida.callRpc('setCaptureAllSends', true);
  
  // Poll sent packets
  while (true) {
    const sent = await frida.callRpc('getSentPackets');
    if (sent && sent.length > 0) {
      for (const pkt of sent) {
        console.log([OUT] Opcode:  () | Size:  | Hex: );
      }
    }
    await new Promise(r => setTimeout(r, 500));
  }
}

test();
