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
        if (n <= 0) return;
        try {
            var data = new Uint8Array(this.buf.readByteArray(n));
            var opcode = -1;
            if (n >= 6) {
                opcode = data[4] | (data[5] << 8);
            }
            if (opcode === 197 || opcode === 205 || opcode === 119 || opcode === 120 || opcode === 212 || opcode === 196 || opcode === 204 || opcode === 48) {
                send({type: 'raw_recv', opcode: opcode, fd: this.fd, len: n, data: Array.from(data.slice(0, Math.min(32, n)))});
            }
        } catch(e) {}
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
        if (n <= 0) return;
        try {
            var data = new Uint8Array(this.buf.readByteArray(n));
            var opcode = -1;
            if (n >= 6) {
                opcode = data[4] | (data[5] << 8);
            }
            if (opcode === 196 || opcode === 204 || opcode === 48 || opcode === 197 || opcode === 205 || opcode === 119 || opcode === 120 || opcode === 212) {
                send({type: 'raw_send', opcode: opcode, fd: this.fd, len: n, data: Array.from(data.slice(0, Math.min(32, n)))});
            }
        } catch(e) {}
    }
});
`;

async function run() {
    const frida = new FridaSession(null, config.GAME_PACKAGE);
    await frida.connect();
    
    console.log('Hooking raw send/recv using simple script...');
    const s2 = await frida.session.createScript(FRIDA_SCRIPT);
    await s2.load();
    
    frida.onMessage(m => {
        if (m && (m.type === 'raw_recv' || m.type === 'raw_send')) {
            console.log(`[RAW] ${m.type} | op: ${m.opcode} | len: ${m.len} | data: [${m.data.join(', ')}]`);
        }
    });

    setTimeout(() => frida.disconnect(), 60000); // Wait 1 min
}

run();
