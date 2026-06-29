// frida-scripts/hooks/connect.js — Hook connect() to auto-detect game socket fd

(function hookConnect() {
    try {
        var libc = Process.findModuleByName('libc.so');
        if (!libc) return;

        var connectAddr = libc.findExportByName('connect');
        if (!connectAddr) return;

        Interceptor.attach(connectAddr, {
            onEnter: function(args) {
                this.fd = args[0].toInt32();
                var sockaddr = args[1];
                try {
                    var family = sockaddr.readU16();
                    if (family === 2) { // AF_INET
                        var port = (sockaddr.add(2).readU8() << 8) | sockaddr.add(3).readU8();
                        var ip = sockaddr.add(4).readU8() + '.' + sockaddr.add(5).readU8() +
                                 '.' + sockaddr.add(6).readU8() + '.' + sockaddr.add(7).readU8();
                        // Filter out ADB/Frida ports
                        if (port > 1000 && port !== 5555 && port !== 5037 && port !== 27042) {
                            gameFd = this.fd;
                            send({ type: 'game_fd', fd: gameFd, ip: ip, port: port });
                        }
                    }
                } catch(e) {}
            }
        });
    } catch(e) {
        send({ type: 'hook_error', hook: 'connect', error: e.toString() });
    }
})();
