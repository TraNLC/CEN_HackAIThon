// frida-scripts/test-hello.js — Frida injection script đơn giản (Step 2)
// Kiểm tra: attach được, Il2Cpp.perform chạy, đọc được tên process

'use strict';

// Gửi message về host
send({ type: 'log', msg: '✅ Frida script loaded!' });
send({ type: 'log', msg: 'Process: ' + Process.mainModule.name });
send({ type: 'log', msg: 'Arch: ' + Process.arch });

// Test Il2Cpp (nếu có frida-il2cpp-bridge)
try {
  if (typeof Il2Cpp !== 'undefined') {
    Il2Cpp.perform(function () {
      send({ type: 'log', msg: '✅ Il2Cpp.perform() OK' });

      // Liệt kê assemblies
      try {
        var assemblies = Il2Cpp.domain.assemblies;
        var names = [];
        for (var i = 0; i < assemblies.length; i++) {
          var a = assemblies[i];
          if (a && a.image && a.image.name) {
            names.push(a.image.name);
          }
        }
        send({ type: 'log', msg: 'Assemblies: ' + names.join(', ') });
      } catch (e) {
        send({ type: 'error', msg: 'Assembly list failed: ' + e.message });
      }

      // Thử đọc PlayerMain.instance
      try {
        var img = Il2Cpp.domain.assembly('Assembly-CSharp').image;
        var pmClass = img.class('PlayerMain');
        var instance = pmClass.field('instance').value;
        if (instance && !instance.isNull()) {
          send({ type: 'log', msg: '✅ PlayerMain.instance FOUND' });

          // Đọc tên nhân vật
          try {
            var npc = instance.field('npcontroller').value;
            var data = npc.field('data').value;
            var nameObj = data.field('name').value;
            // Il2Cpp string
            if (typeof nameObj !== 'undefined' && nameObj !== null) {
              send({
                type: 'player_name',
                name: nameObj.content || nameObj.toString(),
              });
            }
          } catch (e2) {
            send({ type: 'warn', msg: 'Read name failed: ' + e2.message });
          }
        } else {
          send({ type: 'warn', msg: '⚠️ PlayerMain.instance is null (not logged in?)' });
        }
      } catch (e) {
        send({ type: 'error', msg: 'PlayerMain lookup failed: ' + e.message });
      }
    });
  } else {
    send({ type: 'warn', msg: '⚠️ Il2Cpp bridge NOT loaded. Need frida-il2cpp-bridge.' });
  }
} catch (e) {
  send({ type: 'error', msg: 'Script error: ' + e.message });
}

// RPC exports
rpc.exports = {
  ping: function () {
    return { status: 'ok', ts: Date.now() };
  },
  getProcessInfo: function () {
    return {
      name: Process.mainModule.name,
      arch: Process.arch,
      pid: Process.id,
    };
  },
};
