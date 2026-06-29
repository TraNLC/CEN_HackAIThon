// frida-scripts/hooks/ssl.js — SSL_read/write hooks (all variants)
// Game uses OpenSSL libssl.so. We hook SSL_read, SSL_read_ex, SSL_write, SSL_write_ex

(function hookSsl() {
    var sslMod = Process.findModuleByName('libssl.so');
    if (!sslMod) { send({ type: 'ssl_hook', error: 'no libssl.so' }); return; }

    var sslExports = sslMod.enumerateExports();
    var byName = {};
    for (var i = 0; i < sslExports.length; i++) {
        byName[sslExports[i].name] = sslExports[i].address;
    }

    // === SSL_read hook ===
    if (byName['SSL_read']) {
        Interceptor.attach(byName['SSL_read'], {
            onEnter: function(args) {
                this.buf = args[1];
                this.len = args[2].toInt32();
            },
            onLeave: function(retval) {
                var n = retval.toInt32();
                if (n <= 0) return;
                _sslReadOk = true;
                processDecrypted(this.buf, n);
            }
        });
    }

    // === SSL_read_ex hook (OpenSSL 1.1.1+) ===
    if (byName['SSL_read_ex']) {
        Interceptor.attach(byName['SSL_read_ex'], {
            onEnter: function(args) {
                this.buf = args[1]; // uint8_t **buf
                this.lenPtr = args[2]; // size_t *readbytes
            },
            onLeave: function(retval) {
                if (retval.toInt32() <= 0) return;
                _sslReadOk = true;
                var n = this.lenPtr.readU64();
                if (n > 0 && n < 65536) {
                    processDecrypted(this.buf.readPointer(), n);
                }
            }
        });
    }

    // === SSL_write hook ===
    if (byName['SSL_write']) {
        // Store SSL_write function pointer for injection
        _sslWriteFn = new NativeFunction(byName['SSL_write'], 'int', ['pointer', 'pointer', 'int']);

        Interceptor.attach(byName['SSL_write'], {
            onEnter: function(args) {
                if (!_sslObj) { _sslObj = args[0]; send({ type: 'ssl', msg: 'SSL obj captured' }); }
                this.buf = args[1];
                this.len = args[2].toInt32();
            },
            onLeave: function(retval) {
                var n = retval.toInt32();
                if (n <= 0) return;
                _sslWriteOk = true;
                processSent(this.buf, n);
            }
        });
    }

    // === SSL_write_ex hook (OpenSSL 1.1.1+) ===
    if (byName['SSL_write_ex']) {
        if (!_sslWriteFn) {
            _sslWriteFn = new NativeFunction(byName['SSL_write_ex'], 'int', ['pointer', 'pointer', 'pointer']);
        }
        Interceptor.attach(byName['SSL_write_ex'], {
            onEnter: function(args) {
                if (!_sslObj) { _sslObj = args[0]; }
                this.buf = args[1]; // const uint8_t *buf
                this.len = args[2].toInt32(); // size_t num
            },
            onLeave: function(retval) {
                if (retval.toInt32() <= 0) return;
                _sslWriteOk = true;
                processSent(this.buf, this.len);
            }
        });
    }

    send({
        type: 'ssl_hook',
        variants: Object.keys(byName).filter(function(k) { return k.indexOf('SSL_') === 0; }),
        readOk: !!byName['SSL_read'] || !!byName['SSL_read_ex'],
        writeOk: !!byName['SSL_write'] || !!byName['SSL_write_ex'],
    });
})();

// === Shared helpers for SSL hooks ===
function processDecrypted(buf, n) {
    try {
        var data = new Uint8Array(buf.readByteArray(n));
        var pkt = makePacketRecord(data, n);
        recvBuffer.push(pkt);
        _recvTotal++;
        if (recvBuffer.length > 3000) recvBuffer.shift();

        // Track position from opcode 9
        if (pkt.opcode === 9 && n > 10) {
            try {
                var bodyStr = '';
                for (var bi = 6; bi < n; bi++) bodyStr += String.fromCharCode(data[bi]);
                var sparts = bodyStr.split('|');
                if (sparts.length >= 4) {
                    var et = parseInt(sparts[0]);
                    if (et === 1 || et === 2) {
                        var ex = parseInt(sparts[2]), ey = parseInt(sparts[3]);
                        if (ex > 0 && ey > 0) {
                            _lastPosition = { x: ex, y: ey, eid: sparts[1], ts: Date.now() };
                        }
                    }
                }
            } catch(ee) {}
        }
    } catch(e) {}
}

function processSent(buf, n) {
    try {
        var data = new Uint8Array(buf.readByteArray(n));
        var hdr = parsePacketHeader(data);
        var name = GS_OPCODES[hdr.opcode] || ('UNK_' + hdr.opcode);
        var hex = toHex(data, 256);
        sendBuffer.push({ opcode: hdr.opcode, name: name, size: n, hex: hex });
        _sendTotal++;
        if (sendBuffer.length > 100) sendBuffer.shift();
        send({ type: 'send_out', opcode: hdr.opcode, name: name, size: n, hex: hex });
    } catch(e) {}
}
