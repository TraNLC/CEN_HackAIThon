// frida-scripts/hooks/recv.js — Hook recv/read/recvfrom + SSL_read (incoming packets)

(function hookRecv() {
    try {
        var libc = Process.findModuleByName('libc.so');
        if (!libc) throw new Error('libc not found');

        var recvAddr = libc.findExportByName('recv');
        var readAddr = libc.findExportByName('read');
        var recvfromAddr = libc.findExportByName('recvfrom');

        /**
         * Shared onEnter: capture fd and buffer pointer.
         */
        function onRecvEnter(args) {
            this.fd  = args[0].toInt32();
            this.buf = args[1];
        }

        /**
         * Shared onLeave: parse incoming packet, push to recvBuffer.
         */
        function onRecvLeave(retval) {
            var n = retval.toInt32();
            if (n <= 0) return;

            // Quick header parse (6 bytes) for diagnostics on ALL fds
            var opcode = -1, plen = -1;
            if (n >= 6) {
                try {
                    var hdr = new Uint8Array(this.buf.readByteArray(6));
                    plen = hdr[0] | (hdr[1] << 8) | (hdr[2] << 16) | (hdr[3] << 24);
                    opcode = hdr[4] | (hdr[5] << 8);
                } catch (e) { return; }
            }

            // Diagnostics (lightweight, all fds)
            globalThis._recvAny = (globalThis._recvAny || 0) + 1;
            if (!globalThis._fdsSeen) globalThis._fdsSeen = {};
            globalThis._fdsSeen[this.fd] = (globalThis._fdsSeen[this.fd] || 0) + 1;
            if (!globalThis._lastOps) globalThis._lastOps = [];
            if (opcode >= 0) {
                globalThis._lastOps.push(this.fd + ':' + opcode);
                if (globalThis._lastOps.length > 24) globalThis._lastOps.shift();
            }
            if (opcode > 0 && globalThis.GS_OPCODES && globalThis.GS_OPCODES[opcode] && plen >= 0 && plen <= n) {
                if (!globalThis._fdsGameOps) globalThis._fdsGameOps = {};
                globalThis._fdsGameOps[this.fd] = (globalThis._fdsGameOps[this.fd] || 0) + 1;
            }

// Only process game socket OR auto-detect mode
        var isGameFd = (this.fd === globalThis.gameFd);
        var autoDetect = (globalThis.gameFd === -1);

        if (!isGameFd && !autoDetect) return;

            var data;
            try { data = new Uint8Array(this.buf.readByteArray(n)); } catch (e) { return; }

            try {
                if (globalThis.makePacketRecord) {
                    var pkt = globalThis.makePacketRecord(data, n);
                    
                    if (opcode > 0 && opcode <= 30000) {
                        if (!globalThis.recvBuffer) globalThis.recvBuffer = [];
                        globalThis.recvBuffer.push(pkt);
                        globalThis._recvTotal = (globalThis._recvTotal || 0) + 1;
                        if (globalThis.recvBuffer.length > 3000) globalThis.recvBuffer.shift();
                    }

                    // AUTO-DETECT: lock gameFd when we see a valid game opcode
                    if (autoDetect && opcode > 0 && globalThis.GS_OPCODES && globalThis.GS_OPCODES[opcode] !== undefined) {
                        globalThis.gameFd = this.fd;
                        send({ type: 'game_fd', fd: globalThis.gameFd, detectedBy: 'recv opcode ' + opcode + ' (' + globalThis.GS_OPCODES[opcode] + ')' });
                    }
                    
                    // Shop data detection
                    if (opcode === 119 || opcode === 120 || opcode === 212) {
                        send({ type: 'shop_data', opcode: opcode, name: pkt.name, hex: pkt.hex });
                    }
                }
            } catch (e) {}

            // Track entity position from opcode 9 (throttled ~0.8s)
            if (opcode === 9 && n > 10 && (Date.now() - (_lastPosition.ts || 0) > 800)) {
                try {
                    var bodyStr = '';
                    for (var bi = 6; bi < n; bi++) {
                        bodyStr += String.fromCharCode(data[bi]);
                    }
                    var sparts = bodyStr.split('|');
                    if (sparts.length >= 4) {
                        var et = parseInt(sparts[0]);
                        if (et === 1 || et === 2) {
                            var ex = parseInt(sparts[2]);
                            var ey = parseInt(sparts[3]);
                            if (ex > 0 && ey > 0) {
                                _lastPosition = { x: ex, y: ey, eid: sparts[1], ts: Date.now() };
                            }
                        }
                    }
                } catch(ee) {}
            }
        }

        // Attach to all recv variants
        if (recvAddr)     Interceptor.attach(recvAddr,     { onEnter: onRecvEnter, onLeave: onRecvLeave });
        if (readAddr)     Interceptor.attach(readAddr,     { onEnter: onRecvEnter, onLeave: onRecvLeave });
        if (recvfromAddr) Interceptor.attach(recvfromAddr, { onEnter: onRecvEnter, onLeave: onRecvLeave });
        // Houdini x86: ARM code calls through native (x86) read()
        if (nativeReadPtr) {
            Interceptor.attach(nativeReadPtr, { onEnter: onRecvEnter, onLeave: onRecvLeave });
        }
    } catch(e) {
        send({ type: 'hook_error', hook: 'recv', error: e.toString() });
    }
})();
