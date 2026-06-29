const frida = require('frida');

async function main() {
  const deviceManager = frida.getDeviceManager();
  const device = await deviceManager.addRemoteDevice('127.0.0.1:27042');
  
  const processes = await device.enumerateProcesses();
  const game = processes.find(p => p.name === 'VLTieuNgao' || p.name === 'vn.perfingame.jx1mobile');
  if (!game) {
    console.error('Game not running!');
    process.exit(1);
  }
  
  console.log('Attaching to', game.name, 'PID:', game.pid);
  const session = await device.attach(game.pid);
  const script = await session.createScript(`
    try {
      var p = Module.getGlobalExportByName('il2cpp_domain_get');
      send({ type: 'status', msg: 'il2cpp_domain_get: ' + p });
      var p2 = Module.getGlobalExportByName('il2cpp_thread_attach');
      send({ type: 'status', msg: 'il2cpp_thread_attach: ' + p2 });
    } catch(e) {
      send({ type: 'status', msg: 'Failed to query global export: ' + e.message });
    }
  `);
  
  script.message.connect((message) => {
    if (message.type === 'send') {
      const payload = message.payload;
      if (payload.type === 'status') {
        console.log('[STATUS]', payload.msg);
      } else if (payload.type === 'export') {
        console.log('[EXPORT]', payload.name);
      }
    } else {
      console.error('[FRIDA ERROR]', message);
    }
  });
  
  await script.load();
  await new Promise(resolve => setTimeout(resolve, 3000));
  await session.detach();
}

main().catch(console.error);
