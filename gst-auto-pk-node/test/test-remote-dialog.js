const frida = require('../frida-scripts/test-runner/frida-runner.js');

async function test() {
  const stallIndex = 103433;
  const cid = "salesman." + stallIndex + ".0";
  console.log("Calling remoteNpcDialogue for:", cid);
  const res = await frida.callRpc('remoteNpcDialogue', cid);
  console.log("Result:", res);
}

test();
