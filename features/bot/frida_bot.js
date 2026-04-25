/*
frida_bot.js — VLTK1 Bot socket injector (v2 - working)

Key discovery: On Houdini x86 emulators, libc functions from ARM libraries
are not callable. Use write() from app_process32 (x86, rwx) instead.

Packet format (confirmed via disassembly):
  [uint32 LE proto_len] [uint16 LE opcode] [proto body]
*/

'use strict';

// ==================== GLOBALS ====================
var gameFd = -1;
var recvBuffer = [];

// ==================== FIND EXECUTABLE write() ====================
// On Houdini, ARM libc exports are mapped non-executable from x86 side.
// We need write() from an x86-native module (app_process32, linker, etc.)
var nativeWrite = null;
var writeSource = 'none';

(function findExecutableWrite() {
    var mods = Process.enumerateModules();
    for (var i = 0; i < mods.length; i++) {
        var m = mods[i];
        try {
            var exp = m.findExportByName('write');
            if (!exp) continue;
            var range = Process.findRangeByAddress(exp);
            if (range && range.protection.indexOf('x') !== -1) {
                nativeWrite = new NativeFunction(exp, 'int', ['int', 'pointer', 'int']);
                writeSource = m.name + ' @ ' + exp + ' (' + range.protection + ')';
                break;
            }
        } catch(e) {}
    }
})();

// ==================== PACKET PARSING ====================
var GS_OPCODES = {
    0: 'eUnidentified', 1: 'ePlayerLoginRequest', 2: 'ePlayerLoginResponse',
    3: 'eEnterWorldSuccess', 4: 'eCharacterDetailResponse', 5: 'eSkillResponse',
    6: 'eItemResponse', 7: 'eEnterMap', 8: 'eEnterGameServer',
    9: 'eStringData', 10: 'eDelivered', 20: 'eSyncPlayerMove',
    23: 'eSyncDamage', 33: 'eNpcDialogue', 34: 'eNpcQuest',
    35: 'eNpcSelect', 40: 'eCastSkill', 48: 'ePlayerTalk',
    49: 'ePlayerUserItem', 56: 'eObjectPickup', 58: 'eSetRiding',
    69: 'ePing', 70: 'ePong', 117: 'eSwitchWalking',
    132: 'eChatSend', 133: 'eChatMessage',
    231: 'eGotoNpc', 238: 'eDoSkillTargetPlayer', 239: 'eDoSkillTargetNpc',
    240: 'eDoSkillTargetPosition', 248: 'eGotoPosition',
};

function toHex(arr, maxBytes) {
    var n = Math.min(arr.length, maxBytes || arr.length);
    var result = '';
    for (var i = 0; i < n; i++) {
        result += ('0' + arr[i].toString(16)).slice(-2);
    }
    return result;
}

// ==================== SOCKET HOOKS ====================
// Use module-scanning approach instead of direct findExportByName
// to handle Houdini properly
try {
    var libc = Process.findModuleByName('libc.so');
    if (!libc) throw new Error('libc not found');

    var connectAddr = libc.findExportByName('connect');
    var recvAddr    = libc.findExportByName('recv');
    var readAddr    = libc.findExportByName('read');

    // Hook connect() to auto-detect game fd
    if (connectAddr) {
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
                        if (port > 1000 && port !== 5555 && port !== 5037 && port !== 27042) {
                            gameFd = this.fd;
                            send({ type: 'game_fd', fd: gameFd, ip: ip, port: port });
                        }
                    }
                } catch(e) {}
            }
        });
    }

    // Recv handler
    function onRecvEnter(args) {
        this.fd  = args[0].toInt32();
        this.buf = args[1];
    }
    function onRecvLeave(retval) {
        var n = retval.toInt32();
        if (n <= 0 || this.fd !== gameFd) return;
        try {
            var data = new Uint8Array(this.buf.readByteArray(n));
            var hex  = toHex(data, 256);
            // Parse: first 4 bytes = proto_len, next 2 = opcode
            var opcode = -1;
            var name = 'raw';
            if (n >= 6) {
                opcode = data[4] | (data[5] << 8);
                name = GS_OPCODES[opcode] || ('UNK_' + opcode);
            }
            recvBuffer.push({ opcode: opcode, name: name, size: n, hex: hex });
            if (recvBuffer.length > 100) recvBuffer.shift();
            send({ type: 'recv', opcode: opcode, name: name, size: n, hex: hex });
        } catch(e) {}
    }

    if (recvAddr) Interceptor.attach(recvAddr, { onEnter: onRecvEnter, onLeave: onRecvLeave });
    if (readAddr) Interceptor.attach(readAddr, { onEnter: onRecvEnter, onLeave: onRecvLeave });

    send({ type: 'ready', hooks: {
        connect: !!connectAddr, recv: !!recvAddr, read: !!readAddr,
        write: !!nativeWrite, writeSource: writeSource
    }});

} catch(e) {
    send({ type: 'error', msg: e.toString() + '\n' + e.stack });
}

// ==================== RPC EXPORTS ====================
rpc.exports = {
    ping: function() {
        return { gameFd: gameFd, recvBufferSize: recvBuffer.length, write: !!nativeWrite };
    },

    getGameFd: function() { return gameFd; },

    setGameFd: function(fd) {
        gameFd = fd;
        return true;
    },

    getRecvPackets: function() {
        var pkts = recvBuffer.slice();
        recvBuffer = [];
        return pkts;
    },

    sendRaw: function(hexData) {
        if (gameFd < 0) return { ok: false, error: 'No game fd' };
        if (!nativeWrite) return { ok: false, error: 'write() not available' };
        var bytes = [];
        for (var i = 0; i < hexData.length; i += 2) {
            bytes.push(parseInt(hexData.substr(i, 2), 16));
        }
        var buf = Memory.alloc(bytes.length);
        for (var i = 0; i < bytes.length; i++) {
            buf.add(i).writeU8(bytes[i]);
        }
        var ret = nativeWrite(gameFd, buf, bytes.length);
        return { ok: ret === bytes.length, sent: ret, len: bytes.length };
    }
};
