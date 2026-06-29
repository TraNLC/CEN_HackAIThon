// frida-scripts/hooks/send.js — Hook write/send/sendto/writev/sendmsg + SSL_write (outgoing packets)

/**
 * Shared onLeave handler for send-like functions.
 * Captures outgoing packet, pushes to sendBuffer, notifies host.
 */
function makeSendLeaveHandler() {
    return function(retval) {
        var n = retval.toInt32();
        if (n <= 0) return;

        var autoDetect = (globalThis.gameFd === -1);

        // For non-gameFd (and not auto-detect): only peek op140
        if (this.fd !== globalThis.gameFd && !globalThis._captureAllSends && !autoDetect) {
            try {
                if (n < 6) return;
                var h6 = new Uint8Array(this.buf.readByteArray(6));
                if ((h6[4] | (h6[5] << 8)) !== 140) return;
            } catch (e) { return; }
        }

        try {
            var data = new Uint8Array(this.buf.readByteArray(n));
            if (globalThis.parsePacketHeader) {
                var hdr = globalThis.parsePacketHeader(data);
                if (hdr.opcode <= 0 || hdr.opcode > 30000) return;

                var name = (globalThis.GS_OPCODES && globalThis.GS_OPCODES[hdr.opcode]) || ('UNK_' + hdr.opcode);
                var hex = globalThis.toHex ? globalThis.toHex(data, 256) : '';
                var pkt = { opcode: hdr.opcode, name: name, size: n, hex: hex };
                if (!globalThis.sendBuffer) globalThis.sendBuffer = [];
                globalThis.sendBuffer.push(pkt);
                globalThis._sendTotal = (globalThis._sendTotal || 0) + 1;
                if (globalThis.sendBuffer.length > 500) globalThis.sendBuffer.shift();
                send({ type: 'send_out', opcode: hdr.opcode, name: name, size: n, hex: hex });

                // AUTO-DETECT: lock gameFd from outgoing packets too
                if (autoDetect && globalThis.GS_OPCODES && globalThis.GS_OPCODES[hdr.opcode] !== undefined) {
                    globalThis.gameFd = this.fd;
                    send({ type: 'game_fd', fd: globalThis.gameFd, detectedBy: 'send opcode ' + hdr.opcode + ' (' + globalThis.GS_OPCODES[hdr.opcode] + ')' });
                }
            }
        } catch(e) {}
    };
}

/**
 * Shared onEnter: capture fd, buffer, length.
 */
function onSendEnter(args) {
    this.fd = args[0].toInt32();
    this.buf = args[1];
    this.len = args[2].toInt32();
}

// ==================== Hook native write() ====================
(function hookNativeWrite() {
    if (!globalThis.nativeWritePtr) return;
    Interceptor.attach(globalThis.nativeWritePtr, {
        onEnter: onSendEnter,
        onLeave: makeSendLeaveHandler()
    });
})();

// ==================== Hook libc send/sendto ====================
(function hookLibcSend() {
    try {
        var libc = Process.findModuleByName('libc.so');
        if (!libc) return;

        var sendAddr = libc.findExportByName('send');
        var sendtoAddr = libc.findExportByName('sendto');
        var writevAddr = libc.findExportByName('writev');
        var sendmsgAddr = libc.findExportByName('sendmsg');

        if (sendAddr) {
            Interceptor.attach(sendAddr, {
                onEnter: onSendEnter,
                onLeave: makeSendLeaveHandler()
            });
        }

        if (sendtoAddr) {
            Interceptor.attach(sendtoAddr, {
                onEnter: onSendEnter,
                onLeave: makeSendLeaveHandler()
            });
        }

        // writev: scatter-gather I/O
        if (writevAddr) {
            Interceptor.attach(writevAddr, {
                onEnter: function(args) {
                    this.fd = args[0].toInt32();
                    this.iov = args[1];
                },
                onLeave: function(retval) {
                    var n = retval.toInt32();
                    if (n <= 0 || this.fd !== globalThis.gameFd) return;
                    try { if (globalThis.emitFromBuf) globalThis.emitFromBuf(this.iov.readPointer(), n); } catch (e) {}
                }
            });
        }

        // sendmsg
        if (sendmsgAddr) {
            Interceptor.attach(sendmsgAddr, {
                onEnter: function(args) {
                    this.fd = args[0].toInt32();
                    this.msg = args[1];
                },
                onLeave: function(retval) {
                    var n = retval.toInt32();
                    if (n <= 0 || this.fd !== globalThis.gameFd) return;
                    try {
                        var iov = this.msg.add(0x10).readPointer(); // msghdr.msg_iov
                        if (globalThis.emitFromBuf) globalThis.emitFromBuf(iov.readPointer(), n);
                    } catch (e) {}
                }
            });
        }
    } catch(e) {
        send({ type: 'hook_error', hook: 'send', error: e.toString() });
    }
})();
