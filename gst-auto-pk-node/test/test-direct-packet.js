const frida = require('../frida-scripts/test-runner/frida-runner.js');

async function test() {
  const stallIndex = 103433;
  const str = "salesman." + stallIndex + ".0";
  let hex = "0a" + str.length.toString(16).padStart(2, '0');
  for (let i = 0; i < str.length; i++) {
    hex += str.charCodeAt(i).toString(16).padStart(2, '0');
  }
  
  console.log("Sending packet 204 with payload: " + hex);
  const sendRes = await frida.callRpc('sendPacket', 204, hex);
  console.log("Send packet result:", sendRes);
}

test();
