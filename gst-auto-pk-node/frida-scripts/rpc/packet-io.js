// frida-scripts/rpc/packet-io.js — Packet send/receive buffer RPCs

/**
 * Send a raw packet through the game socket.
 * Uses native write() (Houdini-safe) if available, otherwise SSL_write.
 */
rpc.exports.sendPacket = function(opcode, hexBody) {
    // Build packet: [uint32 LE proto_len] [uint16 LE opcode] [hex body]
    var body = hexBody ? hexToBytes(hexBody) : [];
    var protoLen = body.length;
    var buf = Memory.alloc(6 + protoLen);

    // Write header
    buf.writeU32(protoLen);
    buf.add(4).writeU16(opcode);

    // Write body
    if (protoLen > 0) {
        buf.add(6).writeByteArray(body);
    }

    var totalLen = 6 + protoLen;

    // Try SSL_write first (game uses SSL)
    if (_sslWriteFn && _sslObj && !_sslObj.isNull()) {
        try {
            var ret = _sslWriteFn(_sslObj, buf, totalLen);
            return { ok: true, method: 'ssl_write', sent: ret, opcode: opcode };
        } catch (e) {
            // Fall through to native write
        }
    }

    // Fallback: native write()
    if (nativeWrite && gameFd > 0) {
        try {
            var ret = nativeWrite(gameFd, buf, totalLen);
            return { ok: true, method: 'native_write', sent: ret, opcode: opcode };
        } catch (e) {
            return { ok: false, error: 'write failed: ' + e, opcode: opcode };
        }
    }

    return { ok: false, error: 'no send method available (no SSL_obj, no nativeWrite)' };
};

/**
 * Send a raw packet specifically to the game's TCP socket (used for shop/rpc).
 */
rpc.exports.sendTcpPacket = function(opcode, hexBody) {
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
    
    if (tcpFd === -1) return { ok: false, error: 'no tcp socket found' };
    
    var body = hexBody ? hexToBytes(hexBody) : [];
    var protoLen = body.length;
    var buf = Memory.alloc(6 + protoLen);
    buf.writeU32(protoLen);
    buf.add(4).writeU16(opcode);
    if (protoLen > 0) buf.add(6).writeByteArray(body);
    
    if (nativeWrite) {
        try {
            var ret = nativeWrite(tcpFd, buf, 6 + protoLen);
            return { ok: true, method: 'native_write_tcp', sent: ret, opcode: opcode, fd: tcpFd };
        } catch (e) {
            return { ok: false, error: 'tcp write failed: ' + e.message };
        }
    }
    return { ok: false, error: 'nativeWrite not available' };
};

/**
 * Get buffered received packets (oldest first) matching optional opcode filter.
 * Automatically clears returned packets.
 */
rpc.exports.getRecvPackets = function(opcodeFilter, maxCount) {
    var max = maxCount || 50;
    var result = [];
    var remaining = [];

    for (var i = 0; i < recvBuffer.length; i++) {
        var pkt = recvBuffer[i];
        if (opcodeFilter === undefined || opcodeFilter === null || pkt.opcode === opcodeFilter) {
            if (result.length < max) {
                result.push(pkt);
                continue;
            }
        }
        remaining.push(pkt);
    }

    recvBuffer = remaining;
    return { ok: true, count: result.length, packets: result };
};

/**
 * Get buffered sent packets.
 */
rpc.exports.getSentPackets = function(maxCount) {
    var max = maxCount || 20;
    var result = sendBuffer.slice(-max);
    return { ok: true, count: result.length, packets: result };
};

/**
 * Get diagnostic info: socket state, counters, SSL status.
 */
rpc.exports.getDiag = function() {
    return {
        gameFd: gameFd,
        gameFdAutoLocked: gameFdAutoLocked,
        recvTotal: _recvTotal,
        recvAny: _recvAny,
        sendTotal: _sendTotal,
        sslReadOk: _sslReadOk,
        sslWriteOk: _sslWriteOk,
        sslObj: _sslObj ? _sslObj.toString() : null,
        writeSource: writeSource,
        readSource: readSource,
        fdsSeen: _fdsSeen,
        fdsGameOps: _fdsGameOps,
        lastOps: _lastOps.slice(-10),
        lastPosition: _lastPosition,
    };
};

/**
 * Lock gameFd (prevent auto-lock from overriding manual lock).
 */
rpc.exports.lockFd = function(fd) {
    gameFd = fd | 0;
    gameFdAutoLocked = true;
    send({ type: 'fd_locked', fd: gameFd });
    return { ok: true, fd: gameFd };
};

/**
 * Toggle captureAllSends (diagnostic mode — captures all outgoing packets on all fds).
 */
rpc.exports.setCaptureAllSends = function(enable) {
    _captureAllSends = !!enable;
    return { ok: true, captureAllSends: _captureAllSends };
};

// ==================== Helpers ====================

function hexToBytes(hex) {
    var bytes = [];
    for (var i = 0; i < hex.length; i += 2) {
        bytes.push(parseInt(hex.substr(i, 2), 16));
    }
    return bytes;
}
