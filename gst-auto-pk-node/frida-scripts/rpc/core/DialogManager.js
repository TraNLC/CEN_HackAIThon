// frida-scripts/rpc/core/DialogManager.js -- NPC dialog interactions

rpc.exports.remoteNpcDialogue = function(npcId) {
    return new Promise(function(resolve) {
        try {
            var strId = npcId.toString();
            var hexBody = "0a" + ("0" + strId.length.toString(16)).slice(-2);
            for (var i = 0; i < strId.length; i++) {
                hexBody += ("0" + strId.charCodeAt(i).toString(16)).slice(-2);
            }
            
            // Wait for packet-io.js rpc to be available globally in the bundle
            // It's exported as rpc.exports.sendPacket, but inside frida script we can just 
            // call it if we wrap it, or since they are all in the same frida script, we can call it.
            // Wait, we can't easily call other rpc.exports from within an rpc.export directly.
            // Let's implement the TCP send directly here, or call the global sendTcpPacket if available.
            // Actually, we can just use sendTcpPacket implementation directly here to be safe!
            
            var tcpFd = -1;
            for(var i=0; i<200; i++) {
                try {
                    var type = Socket.type(i);
                    if (type === 'tcp' || type === 'tcp6') {
                        var peer = Socket.peerAddress(i);
                        if (peer && peer.port !== 80 && peer.port !== 443 && peer.port !== 27042) {
                            tcpFd = i;
                            break;
                        }
                    }
                } catch(e){}
            }
            
            if (tcpFd === -1) return resolve({ ok: false, error: 'no tcp socket found' });
            
            var bodyBytes = [];
            for (var i = 0; i < hexBody.length; i += 2) {
                bodyBytes.push(parseInt(hexBody.substr(i, 2), 16));
            }
            
            var protoLen = bodyBytes.length;
            var buf = Memory.alloc(6 + protoLen);
            buf.writeU32(protoLen);
            buf.add(4).writeU16(33); // opcode 33 = eNpcDialogue
            if (protoLen > 0) buf.add(6).writeByteArray(bodyBytes);
            
            // Assume nativeWrite is globally available from packet-io.js
            if (typeof nativeWrite !== 'undefined') {
                var ret = nativeWrite(tcpFd, buf, 6 + protoLen);
                return resolve({ ok: true, method: 'native_write_tcp', sent: ret, opcode: 33, fd: tcpFd });
            } else {
                return resolve({ ok: false, error: 'nativeWrite not available globally' });
            }
        } catch(e) {
            resolve({ ok: false, error: 'Talk packet failed: ' + e.message });
        }
    });
};
