// test/test-bridge-minimal.js — Minimal bridge test
const frida = require('frida');
const fs = require('fs');
const path = require('path');
const { execSync } = require('child_process');
const ADB = 'C:\\platform-tools\\adb.exe';
const PKG = 'vn.perfingame.jx1mobile';

(async () => {
  // Get PID
  const pid = parseInt(execSync(`"${ADB}" -s emulator-5556 shell "pidof ${PKG}"`, {encoding:'utf-8'}).trim());
  console.log('PID:', pid);

  // Forward
  execSync(`"${ADB}" -s emulator-5556 forward tcp:27042 tcp:27042`);

  // Connect
  const dm = frida.getDeviceManager();
  const dev = await dm.addRemoteDevice('127.0.0.1:27042');
  const session = await dev.attach(pid);
  console.log('Attached');

  // Load vendor bridge only
  const bridgePath = path.join(__dirname, '..', '..', 'GSTAuto_PK_Windows', 'vendor', 'il2cpp-bridge.js');
  const bridgeCode = fs.readFileSync(bridgePath, 'utf-8');
  
  const testCode = `
    send({type:'log', msg:'Bridge script starting...'});
    send({type:'log', msg:'typeof Il2Cpp = ' + typeof Il2Cpp});
    
    if (typeof Il2Cpp !== 'undefined') {
      send({type:'log', msg:'Il2Cpp DEFINED!'});
      try {
        Il2Cpp.perform(function() {
          send({type:'log', msg:'Il2Cpp.perform() CALLBACK FIRED!'});
          try {
            var img = Il2Cpp.domain.assembly('Assembly-CSharp').image;
            send({type:'log', msg:'Assembly-CSharp image: ' + img});
            var pm = img.class('PlayerMain');
            send({type:'log', msg:'PlayerMain class: ' + pm});
            var inst = pm.field('instance').value;
            send({type:'log', msg:'PlayerMain.instance: ' + inst});
          } catch(e) {
            send({type:'error', msg:'Error in perform: ' + e.message});
          }
        });
        send({type:'log', msg:'Il2Cpp.perform() called (waiting for callback)...'});
      } catch(e) {
        send({type:'error', msg:'Il2Cpp.perform() threw: ' + e.message});
      }
    } else {
      send({type:'warn', msg:'Il2Cpp NOT defined'});
    }
    
    rpc.exports = {
      ping: function() { return {ts: Date.now(), il2cpp: typeof Il2Cpp !== 'undefined'}; }
    };
  `;

  const fullScript = bridgeCode + '\n;\n' + testCode;
  console.log('Script size:', (fullScript.length / 1024).toFixed(1), 'KB');

  const script = await session.createScript(fullScript);
  script.message.connect((msg) => {
    if (msg.type === 'send') {
      const p = msg.payload;
      console.log(`  [${p.type}] ${p.msg || JSON.stringify(p)}`);
    } else if (msg.type === 'error') {
      console.log('  [ERROR]', msg.description);
    }
  });
  
  console.log('Loading script...');
  await script.load();
  console.log('Script loaded! Waiting 60s for Il2Cpp.perform callback...\n');

  // Wait up to 60 seconds for the perform callback
  for (let i = 5; i <= 60; i += 5) {
    await new Promise(r => setTimeout(r, 5000));
    try {
      const pong = await script.exports.ping();
      console.log(`  ${i}s: ping OK, il2cpp=${pong.il2cpp}`);
    } catch(e) {
      console.log(`  ${i}s: ping FAILED — ${e.message}`);
      break;
    }
  }

  await script.unload();
  await session.detach();
  console.log('Done');
})();
