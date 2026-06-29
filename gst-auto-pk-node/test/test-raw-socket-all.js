const { FridaSession } = require('../src/frida-session');
const config = require('../config');

const FRIDA_SCRIPT = `
Interceptor.attach(Module.findExportByName('libc.so', 'recv'), {
    onEnter: function(a) {
        this.fd = a[0].toInt32();
        this.buf = a[1];
    },
    onLeave: function(retval) {
        var n = retval.toInt32();
        if (n > 0) {
            send({type: 'raw', dir: 'recv', fd: this.fd, len: n});
        }
    }
});

Interceptor.attach(Module.findExportByName('libc.so', 'send'), {
    onEnter: function(a) {
        this.fd = a[0].toInt32();
        this.buf = a[1];
        this.n = a[2].toInt32();
    },
    onLeave: function(retval) {
        var n = retval.toInt32();
        if (n > 0) {
            send({type: 'raw', dir: 'send', fd: this.fd, len: n});
        }
    }
});
`;

async function run() {
    const frida = new FridaSession(null, config.GAME_PACKAGE);
    await frida.connect();
    
    console.log('HOOKING LIBC SEND/RECV WITHOUT OPCODES... JUST LOGGING EVERYTHING');
    const s2 = await frida.session.createScript(FRIDA_SCRIPT);
    await s2.load();
    
    frida.onMessage(m => {
        if (m && m.type === 'raw') {
            console.log(`[RAW ${m.dir.toUpperCase()}] FD: ${m.fd} | Len: ${m.len}`);
        }
    });

    setTimeout(() => frida.disconnect(), 60000); // Wait 1 min
}

run();
