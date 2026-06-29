const { FridaSession } = require('../src/frida-session');
const config = require('../config');

async function run() {
    console.log('Connecting to device...');
    const frida = new FridaSession(null, config.GAME_PACKAGE);
    await frida.connect();
    console.log('Connected successfully!');

    let targetFd = 78; // Mặc định thử FD 78
    if (process.argv[2]) {
        targetFd = parseInt(process.argv[2], 10);
    }
    console.log(`Listening on FD: ${targetFd} (pass fd as argument to change, e.g., node test/capture-raw.js 123)`);

    const scriptCode = `
        var targetFd = ${targetFd};

        function toHex(arr) {
            var n = Math.min(arr.length, 128);
            var result = '';
            for (var i = 0; i < n; i++) {
                result += ('0' + arr[i].toString(16)).slice(-2) + ' ';
            }
            return result.trim();
        }

        var libc = Process.findModuleByName('libc.so');
        var funcs = ['read', 'write', 'recv', 'send', 'recvfrom', 'sendto'];

        funcs.forEach(function(name) {
            var addr = libc.findExportByName(name);
            if (addr) {
                Interceptor.attach(addr, {
                    onEnter: function(args) {
                        this.fd = args[0].toInt32();
                        this.buf = args[1];
                        this.funcName = name;
                    },
                    onLeave: function(retval) {
                        var n = retval.toInt32();
                        if (n <= 0) return;
                        if (this.fd === targetFd || targetFd === -1) {
                            try {
                                var data = new Uint8Array(this.buf.readByteArray(n));
                                
                                // Lọc 104 bytes trên FD 78 (Heartbeat/Sync)
                                if (this.fd === 78 && n === 104) return;
                                
                                // Lọc rác
                                if ((this.fd === 67 || this.fd === 81) && n === 8) return;
                                if (this.fd === 56 && n === 795) return;
                                if ((this.fd === 71 || this.fd === 85) && n === 64) return;
                                
                                send({ 
                                    type: 'data', 
                                    func: this.funcName, 
                                    fd: this.fd, 
                                    len: n, 
                                    hex: toHex(data) 
                                });
                            } catch(e) {}
                        }
                    }
                });
            }
        });
        
        send({ type: 'ready' });
    `;

    frida.onMessage(m => {
        if (m.type === 'ready') {
            console.log('Script loaded! Mở shop trong game ngay bây giờ...');
            console.log('Chờ 15s để lấy packets...');
            setTimeout(() => {
                console.log('Xong. Đóng script.');
                process.exit(0);
            }, 15000);
        } else if (m.type === 'data') {
            console.log(`[${m.func.toUpperCase()}] FD=${m.fd} Len=${m.len} | Hex: ${m.hex}`);
        } else {
            console.log(m);
        }
    });

    const fs = require('fs');
    fs.writeFileSync('./test/temp-script.js', scriptCode);
    await frida.loadScript('./test/temp-script.js');
}

run().catch(console.error);
