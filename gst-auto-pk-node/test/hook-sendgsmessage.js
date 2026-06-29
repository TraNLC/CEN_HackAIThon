const { FridaSession } = require('../src/frida-session');
const config = require('../config');

async function run() {
  const frida = new FridaSession(config.PACKAGE_NAME, 'test/hook-dynamic-sendgsmessage.js');
  await frida.connect();
  
  console.log("==========================================================");
  console.log("Hooking SendGSMessage in Unity C#...");
  console.log("PLEASE GO TO THE GAME AND TAP ON ANY NEARBY PLAYER SHOP!!!");
  console.log("==========================================================");
  
  frida.onMessage((msg) => {
    if (msg.log) {
      console.log(msg.log);
    }
  });

  await frida.loadScript('test/hook-dynamic-sendgsmessage.js');
  
  let totalTime = 0;
  while (totalTime < 60000) {
    await new Promise(r => setTimeout(r, 1000));
    totalTime += 1000;
  }
  
  frida.disconnect();
}

run().catch(console.error);
