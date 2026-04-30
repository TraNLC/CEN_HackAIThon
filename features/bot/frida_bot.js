/*
frida_bot.js – VLTK1 Bot socket injector (v3 - clean)

Key discovery: On Houdini x86 emulators, libc functions from ARM libraries
are not callable. Use write() from app_process32 (x86, rwx) instead.

Packet format (confirmed via disassembly):
  [uint32 LE proto_len] [uint16 LE opcode] [proto body]
*/

'use strict';

// ==================== GLOBALS ====================
var gameFd = -1;
var recvBuffer = [];
var sendBuffer = [];
var _playerMainInstance = null;
var _lastPosition = { x: 0, y: 0, eid: '', ts: 0 };
var _sslReadOk = false;
var _sslWriteOk = false;
var _sslError = '';
var _sslWriteFn = null;  // NativeFunction for SSL_write
var _sslObj = null;      // SSL* object pointer captured from game's SSL_write calls
var _recvTotal = 0;
var _sendTotal = 0;

// ==================== FIND EXECUTABLE write() AND read() ====================
var nativeWrite = null;
var nativeWritePtr = null;
var nativeReadPtr = null;
var writeSource = 'none';
var readSource = 'none';

(function findExecutableFunctions() {
    var mods = Process.enumerateModules();
    for (var i = 0; i < mods.length; i++) {
        var m = mods[i];
        try {
            // Find write
            if (!nativeWritePtr) {
                var wexp = m.findExportByName('write');
                if (wexp) {
                    var wrange = Process.findRangeByAddress(wexp);
                    if (wrange && wrange.protection.indexOf('x') !== -1) {
                        nativeWritePtr = wexp;
                        nativeWrite = new NativeFunction(wexp, 'int', ['int', 'pointer', 'int']);
                        writeSource = m.name + ' @ ' + wexp + ' (' + wrange.protection + ')';
                    }
                }
            }
            // Find read (same approach as write — needed for Houdini ARM translation)
            if (!nativeReadPtr) {
                var rexp = m.findExportByName('read');
                if (rexp) {
                    var rrange = Process.findRangeByAddress(rexp);
                    if (rrange && rrange.protection.indexOf('x') !== -1) {
                        nativeReadPtr = rexp;
                        readSource = m.name + ' @ ' + rexp + ' (' + rrange.protection + ')';
                    }
                }
            }
        } catch(e) {}
    }
})();

// ==================== HELPERS ====================
function toHex(arr, maxBytes) {
    var n = Math.min(arr.length, maxBytes || arr.length);
    var result = '';
    for (var i = 0; i < n; i++) {
        result += ('0' + arr[i].toString(16)).slice(-2);
    }
    return result;
}

// ==================== OPCODE MAP ====================
var GS_OPCODES = {
    0: 'eUnidentified',
    1: 'ePlayerLoginRequest',    2: 'ePlayerLoginResponse',
    3: 'eEnterWorldSuccess',     4: 'eCharacterDetailResponse',
    5: 'eSkillResponse',         6: 'eItemResponse',
    7: 'eEnterMap',              8: 'eEnterGameServer',
    9: 'eStringData',            10: 'eDelivered',
    13: 'eJumToMap',             20: 'eSyncPlayerMove',
    23: 'eSyncDamage',           33: 'eNpcDialogue',
    34: 'eNpcQuest',             35: 'eNpcSelect',
    40: 'eCastSkill',            48: 'ePlayerTalk',
    49: 'ePlayerUserItem',       54: 'eAddMapObject',
    56: 'eObjectPickup',         58: 'eSetRiding',
    69: 'ePing',                 70: 'ePong',
    71: 'eMapDialogNpcListRequest',
    72: 'eMapDialogNpcListResponse',
    117: 'eSwitchWalking',
    122: 'eTownportal',
    132: 'eChatSend',            133: 'eChatMessage',
    140: 'eApplyAutoplayProfile',
    172: 'eEnterTongMap',        188: 'eSelfRevertMap',
    231: 'eGotoNpc',
    238: 'eDoSkillTargetPlayer', 239: 'eDoSkillTargetNpc',
    240: 'eDoSkillTargetPosition',
    248: 'eGotoPosition',
};

// ==================== SOCKET HOOKS ====================
try {
    var libc = Process.findModuleByName('libc.so');
    if (!libc) throw new Error('libc not found');

    var connectAddr  = libc.findExportByName('connect');
    var recvAddr     = libc.findExportByName('recv');
    var readAddr     = libc.findExportByName('read');
    var recvfromAddr = libc.findExportByName('recvfrom');

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

    // Recv handler – buffer ALL incoming packets and send to Python
    function onRecvEnter(args) {
        this.fd  = args[0].toInt32();
        this.buf = args[1];
    }
    function onRecvLeave(retval) {
        var n = retval.toInt32();
        if (n <= 0 || this.fd !== gameFd) return;
        try {
            var data = new Uint8Array(this.buf.readByteArray(n));
            var hex  = toHex(data, 512);
            var opcode = -1;
            var name   = 'raw';
            if (n >= 6) {
                opcode = data[4] | (data[5] << 8);
                name = GS_OPCODES[opcode] || ('UNK_' + opcode);
            }
            var pkt = { opcode: opcode, name: name, size: n, hex: hex, raw: hex };
            recvBuffer.push(pkt);
            _recvTotal++;
            if (recvBuffer.length > 200) recvBuffer.shift();
            send({ type: 'recv', opcode: opcode, name: name, size: n, hex: hex, raw: hex });

            // Track entity position from opcode 9 (eStringData / entity sync)
            if (opcode === 9 && n > 10) {
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
        } catch(e) {}
    }

    if (recvAddr)     Interceptor.attach(recvAddr,     { onEnter: onRecvEnter, onLeave: onRecvLeave });
    if (readAddr)     Interceptor.attach(readAddr,     { onEnter: onRecvEnter, onLeave: onRecvLeave });
    // CRITICAL: Game uses recvfrom() not recv()! recvfrom(fd, buf, len, flags, src_addr, addrlen)
    if (recvfromAddr) Interceptor.attach(recvfromAddr, { onEnter: onRecvEnter, onLeave: onRecvLeave });
    // CRITICAL: On Houdini x86, ARM code goes through translation layer.
    // nativeReadPtr is the executable read() from app_process32/Houdini that ARM code actually calls.
    if (nativeReadPtr) {
        Interceptor.attach(nativeReadPtr, { onEnter: onRecvEnter, onLeave: onRecvLeave });
    }

    // ==================== HOOK write() FOR OUTGOING PACKETS ====================
    if (nativeWritePtr) {
        Interceptor.attach(nativeWritePtr, {
            onEnter: function(args) {
                this.fd = args[0].toInt32();
                this.buf = args[1];
                this.len = args[2].toInt32();
            },
            onLeave: function(retval) {
                var n = retval.toInt32();
                if (n <= 0 || this.fd !== gameFd) return;
                try {
                    var data = new Uint8Array(this.buf.readByteArray(n));
                    var hex = toHex(data, 256);
                    var opcode = -1;
                    var name = 'raw';
                    if (n >= 6) {
                        opcode = data[4] | (data[5] << 8);
                        name = GS_OPCODES[opcode] || ('UNK_' + opcode);
                    }
                    var pkt = { opcode: opcode, name: name, size: n, hex: hex };
                    sendBuffer.push(pkt);
                    _sendTotal++;
                    if (sendBuffer.length > 100) sendBuffer.shift();
                    send({ type: 'send_out', opcode: opcode, name: name, size: n, hex: hex });
                } catch(e) {}
            }
        });
    }

    // ==================== SSL HOOKS (game uses SSL!) ====================
    // NOTE: Module.findExportByName('libssl.so', ...) returns null on Houdini x86.
    // We must use enumerateExports() to find the actual addresses.
    try {
        var sslReadAddr = null;
        var sslWriteAddr = null;
        var sslMod = Process.findModuleByName('libssl.so');
        if (sslMod) {
            var sslExports = sslMod.enumerateExports();
            for (var ei = 0; ei < sslExports.length; ei++) {
                if (sslExports[ei].name === 'SSL_read') sslReadAddr = sslExports[ei].address;
                if (sslExports[ei].name === 'SSL_write') sslWriteAddr = sslExports[ei].address;
            }
        }
        
        if (sslReadAddr) {
            Interceptor.attach(sslReadAddr, {
                onEnter: function(args) {
                    this.ssl = args[0];
                    this.buf = args[1];
                    this.len = args[2].toInt32();
                },
                onLeave: function(retval) {
                    var n = retval.toInt32();
                    if (n <= 0) return;
                    _sslReadOk = true;
                    try {
                        var data = new Uint8Array(this.buf.readByteArray(n));
                        var hex = toHex(data, 512);
                        var opcode = -1;
                        var name = 'raw';
                        if (n >= 6) {
                            opcode = data[4] | (data[5] << 8);
                            name = GS_OPCODES[opcode] || ('UNK_' + opcode);
                        }
                        var pkt = { opcode: opcode, name: name, size: n, hex: hex, raw: hex };
                        recvBuffer.push(pkt);
                        _recvTotal++;
                        if (recvBuffer.length > 200) recvBuffer.shift();
                        send({ type: 'recv', opcode: opcode, name: name, size: n, hex: hex, raw: hex });
                        
                        // Track position from opcode 9
                        if (opcode === 9 && n > 10) {
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
                    } catch(e) {}
                }
            });
        }
        
        if (sslWriteAddr) {
            // Store the SSL_write function pointer for sslSend()
            _sslWriteFn = new NativeFunction(sslWriteAddr, 'int', ['pointer', 'pointer', 'int']);
            
            Interceptor.attach(sslWriteAddr, {
                onEnter: function(args) {
                    this.ssl = args[0];
                    this.buf = args[1];
                    this.len = args[2].toInt32();
                    // Capture the SSL object pointer for later use in sslSend()
                    if (!_sslObj) {
                        _sslObj = args[0];
                        send({ type: 'info', msg: 'SSL object captured: ' + _sslObj });
                    }
                },
                onLeave: function(retval) {
                    var n = retval.toInt32();
                    if (n <= 0) return;
                    try {
                        var data = new Uint8Array(this.buf.readByteArray(n));
                        var hex = toHex(data, 256);
                        var opcode = -1;
                        var name = 'raw';
                        if (n >= 6) {
                            opcode = data[4] | (data[5] << 8);
                            name = GS_OPCODES[opcode] || ('UNK_' + opcode);
                        }
                        var pkt = { opcode: opcode, name: name, size: n, hex: hex };
                        sendBuffer.push(pkt);
                        _sendTotal++;
                        if (sendBuffer.length > 100) sendBuffer.shift();
                        _sslWriteOk = true;
                        send({ type: 'send_out', opcode: opcode, name: name, size: n, hex: hex });
                    } catch(e) {}
                }
            });
        }
        
        send({ type: 'ssl_hooks', sslRead: !!sslReadAddr, sslWrite: !!sslWriteAddr });
    } catch(e) {
        _sslError = e.toString();
        send({ type: 'ssl_hooks', error: e.toString() });
    }

    send({ type: 'ready', hooks: {
        connect: !!connectAddr, recv: !!recvAddr, read: !!readAddr,
        recvfrom: !!recvfromAddr,
        nativeRead: !!nativeReadPtr, readSource: readSource,
        write: !!nativeWrite, writeSource: writeSource
    }});

} catch(e) {
    send({ type: 'error', msg: e.toString() + '\n' + e.stack });
}

// ==================== IL2CPP ====================
function getIl2CppBase() {
    var base = null;
    var lines = File.readAllText('/proc/self/maps').split('\n');
    for (var i = 0; i < lines.length; i++) {
        var line = lines[i];
        if (line.indexOf('libil2cpp.so') !== -1 && line.indexOf('r-xp') !== -1) {
            base = ptr('0x' + line.split('-')[0]);
            break;
        }
    }
    if (!base) {
        for (var i = 0; i < lines.length; i++) {
            var line = lines[i];
            if (line.indexOf('libil2cpp.so') !== -1) {
                base = ptr('0x' + line.split('-')[0]);
                break;
            }
        }
    }
    return base;
}

var il2cppBase = getIl2CppBase();
if (il2cppBase) {
    send({ type: 'il2cpp_ready', lib: 'libil2cpp.so', base: il2cppBase });
} else {
    send({ type: 'il2cpp_ready', msg: 'libil2cpp.so not found in maps' });
}

// Read PlayerMain instance directly from IL2CPP class static (Failed on Houdini x86)

// ==================== RPC EXPORTS ====================
rpc.exports = {
    ping: function() {
        return {
            gameFd: gameFd,
            recvBufferSize: recvBuffer.length,
            recvTotal: _recvTotal,
            sendTotal: _sendTotal,
            write: !!nativeWrite,
            sslRead: _sslReadOk,
            sslWrite: _sslWriteOk,
            sslError: _sslError,
            hasPosition: _lastPosition.x > 0
        };
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

    getSendPackets: function() {
        var pkts = sendBuffer.slice();
        sendBuffer = [];
        return pkts;
    },

    // Read last known position from recv hooks (no tcpdump needed!)
    readPosition: function() {
        return _lastPosition;
    },

    // Read position directly from IL2CPP PlayerMain memory (no packets needed!)
    readPositionFromMemory: function() {
        if (!il2cppBase) return { ok: false, error: 'il2cpp not found' };
        try {
            if (!_playerMainInstance) {
                var res = readPlayerMainDirect();
                if (!res.ok) return { ok: false, error: 'PlayerMain: ' + res.error };
            }
            // Read Character data from PlayerMain
            // PlayerMain has a reference to the Character/player data
            // We need to find the mapX, mapY fields
            var il2cpp_object_get_class = new NativeFunction(
                Module.findExportByName('libil2cpp.so', 'il2cpp_object_get_class'),
                'pointer', ['pointer']
            );
            var il2cpp_class_get_field_from_name = new NativeFunction(
                Module.findExportByName('libil2cpp.so', 'il2cpp_class_get_field_from_name'),
                'pointer', ['pointer', 'pointer']
            );
            var il2cpp_field_get_offset = new NativeFunction(
                Module.findExportByName('libil2cpp.so', 'il2cpp_field_get_offset'),
                'uint', ['pointer']
            );

            var klass = il2cpp_object_get_class(_playerMainInstance);

            // Try to read position fields from PlayerMain instance
            // Common field names: mapX, mapY, posX, posY, m_posX, m_posY, currentX, currentY
            var fieldNames = [
                ['mapX', 'mapY'],
                ['m_mapX', 'm_mapY'],
                ['posX', 'posY'],
                ['currentMapX', 'currentMapY'],
                ['m_currentX', 'm_currentY']
            ];

            for (var i = 0; i < fieldNames.length; i++) {
                var fxName = Memory.allocUtf8String(fieldNames[i][0]);
                var fyName = Memory.allocUtf8String(fieldNames[i][1]);
                var fx = il2cpp_class_get_field_from_name(klass, fxName);
                var fy = il2cpp_class_get_field_from_name(klass, fyName);
                if (!fx.isNull() && !fy.isNull()) {
                    var offX = il2cpp_field_get_offset(fx);
                    var offY = il2cpp_field_get_offset(fy);
                    var x = _playerMainInstance.add(offX).readS32();
                    var y = _playerMainInstance.add(offY).readS32();
                    if (x > 0 && y > 0) {
                        _lastPosition = { x: x, y: y, eid: 'memory', ts: Date.now() };
                        return { ok: true, x: x, y: y, source: fieldNames[i][0] + '/' + fieldNames[i][1] };
                    }
                }
            }

            // Dump all int32 fields for debugging
            var il2cpp_class_get_fields = new NativeFunction(
                Module.findExportByName('libil2cpp.so', 'il2cpp_class_get_fields'),
                'pointer', ['pointer', 'pointer']
            );
            var il2cpp_field_get_name = new NativeFunction(
                Module.findExportByName('libil2cpp.so', 'il2cpp_field_get_name'),
                'pointer', ['pointer']
            );

            var fieldDump = [];
            var iter = Memory.alloc(Process.pointerSize);
            iter.writePointer(ptr(0));
            var field;
            while (!(field = il2cpp_class_get_fields(klass, iter)).isNull()) {
                var namePtr = il2cpp_field_get_name(field);
                var name = namePtr.readUtf8String();
                var offset = il2cpp_field_get_offset(field);
                // Read as int32 to check for coordinate-like values
                try {
                    var val = _playerMainInstance.add(offset).readS32();
                    if (val > 10000 && val < 200000) {
                        fieldDump.push(name + '=' + val + ' @' + offset);
                    }
                } catch(e) {}
            }

            return { ok: false, error: 'No position fields found', dump: fieldDump };
        } catch(e) {
            return { ok: false, error: e.toString() };
        }
    },

    // Get debug info about hook status
    getDebugInfo: function() {
        return {
            gameFd: gameFd,
            recvTotal: _recvTotal,
            sendTotal: _sendTotal,
            recvBufferSize: recvBuffer.length,
            sslReadOk: _sslReadOk,
            sslWriteOk: _sslWriteOk,
            sslError: _sslError,
            writeOk: !!nativeWrite,
            writeSource: writeSource,
            lastPosition: _lastPosition,
            il2cppBase: il2cppBase ? il2cppBase.toString() : null,
            playerMain: _playerMainInstance ? _playerMainInstance.toString() : null
        };
    },

    // ==================== IL2CPP MEMORY READ ====================

    // Call PlayerMain::GetNearPlayers() via IL2CPP
    // Returns list of nearby players/stalls
    getNearPlayers: function() {
        if (!il2cppBase) return { ok: false, error: 'il2cpp not found' };
        try {
            if (typeof _playerMainInstance === 'undefined' || _playerMainInstance === null) {
                var res = readPlayerMainDirect();
                if (!res.ok) return { ok: false, error: 'PlayerMain load failed: ' + res.error };
            }
            
            var GetNearPlayers = new NativeFunction(
                il2cppBase.add(0x701EC8), 'pointer', ['pointer']
            );
            var dict = GetNearPlayers(_playerMainInstance);
            if (dict.isNull()) return { ok: true, players: [] };

            // Parse ConcurrentDictionary
            var il2cpp_object_get_class = new NativeFunction(Module.findExportByName('libil2cpp.so', 'il2cpp_object_get_class'), 'pointer', ['pointer']);
            var il2cpp_class_get_field_from_name = new NativeFunction(Module.findExportByName('libil2cpp.so', 'il2cpp_class_get_field_from_name'), 'pointer', ['pointer', 'pointer']);
            var il2cpp_field_get_offset = new NativeFunction(Module.findExportByName('libil2cpp.so', 'il2cpp_field_get_offset'), 'uint', ['pointer']);

            function getOffset(klass, name) {
                var f = il2cpp_class_get_field_from_name(klass, Memory.allocUtf8String(name));
                if (f.isNull()) return -1;
                return il2cpp_field_get_offset(f);
            }

            var dictKlass = il2cpp_object_get_class(dict);
            var tablesOffset = getOffset(dictKlass, 'm_tables');
            if (tablesOffset < 0) return { ok: false, error: 'm_tables not found' };

            var tables = dict.add(tablesOffset).readPointer();
            if (tables.isNull()) return { ok: true, players: [] };

            var tablesKlass = il2cpp_object_get_class(tables);
            var bucketsOffset = getOffset(tablesKlass, 'm_buckets');
            if (bucketsOffset < 0) return { ok: false, error: 'm_buckets not found' };

            var bucketsArr = tables.add(bucketsOffset).readPointer();
            if (bucketsArr.isNull()) return { ok: true, players: [] };

            // Il2CppArray: header(8/16) + bounds(4/8) + max_length(4/8) + data
            // Usually data is at offset 0x10 (32bit) or 0x20 (64bit)
            var pSize = Process.pointerSize;
            var arrLen = bucketsArr.add(pSize * 3).readU32(); // max_length
            var arrData = bucketsArr.add(pSize * 4); 

            var resultList = [];
            for (var i = 0; i < arrLen; i++) {
                var node = arrData.add(i * pSize).readPointer();
                while (!node.isNull()) {
                    var nodeKlass = il2cpp_object_get_class(node);
                    var keyOffset = getOffset(nodeKlass, 'm_key');
                    var valOffset = getOffset(nodeKlass, 'm_value');
                    var nextOffset = getOffset(nodeKlass, 'm_next');
                    
                    var keyPtr = node.add(keyOffset).readPointer();
                    var valPtr = node.add(valOffset).readPointer();
                    
                    // Read string key
                    var keyStr = "";
                    if (!keyPtr.isNull()) {
                        var strLen = keyPtr.add(pSize * 2).readU32();
                        var chars = keyPtr.add(pSize * 2 + 4).readUtf16String(strLen);
                        keyStr = chars;
                    }
                    
                    if (keyStr && !valPtr.isNull()) {
                        resultList.push({ id: keyStr, ptr: valPtr.toString() });
                    }
                    
                    node = node.add(nextOffset).readPointer();
                }
            }

            return { ok: true, players: resultList };
        } catch(e) {
            return { ok: false, error: e.toString() };
        }
    },

    getNearNpcs: function() {
        return { ok: false, error: 'Not fully implemented yet' };
    },

    // Hook GotoFindingPath to capture PlayerMain 'this' pointer (Failed on Houdini x86)
    gotopath: function(x, y) {
        if (!il2cppBase) return { ok: false, error: 'il2cpp not found' };
        try {
            var GotoFindingPath = new NativeFunction(
                il2cppBase.add(0x706A70), 'void', ['pointer', 'int', 'int', 'int', 'pointer', 'pointer']
            );
            if (typeof _playerMainInstance !== 'undefined' && _playerMainInstance) {
                GotoFindingPath(_playerMainInstance, x, y, 20, ptr(0), ptr(0));
                return { ok: true, x: x, y: y };
            }
            return { ok: false, error: 'PlayerMain not captured' };
        } catch(e) {
            return { ok: false, error: e.toString() };
        }
    },

    sendRaw: function(hexData) {
        if (gameFd < 0) return { ok: false, error: 'No game fd' };
        if (!nativeWrite) return { ok: false, error: 'write() not available' };
        var bytes = [];
        for (var i = 0; i < hexData.length; i += 2) {
            bytes.push(parseInt(hexData.substr(i, 2), 16));
        }
        var n = bytes.length;
        if (n === 0) return { ok: false, error: 'Empty data' };
        var buf = Memory.alloc(n);
        for (var i = 0; i < n; i++) {
            buf.add(i).writeU8(bytes[i]);
        }
        var ret = nativeWrite(gameFd, buf, n);
        return { ok: ret === n, sent: ret, len: n };
    },

    // Send data through the game's SSL connection (proper encryption!)
    sslSend: function(hexData) {
        if (!_sslWriteFn) return { ok: false, error: 'SSL_write not hooked yet' };
        if (!_sslObj) return { ok: false, error: 'SSL object not captured yet (wait for game to send a packet first)' };
        var bytes = [];
        for (var i = 0; i < hexData.length; i += 2) {
            bytes.push(parseInt(hexData.substr(i, 2), 16));
        }
        var n = bytes.length;
        if (n === 0) return { ok: false, error: 'Empty data' };
        var buf = Memory.alloc(n);
        for (var i = 0; i < n; i++) {
            buf.add(i).writeU8(bytes[i]);
        }
        var ret = _sslWriteFn(_sslObj, buf, n);
        return { ok: ret === n, sent: ret, len: n };
    },

    // Check SSL hook status
    getSslStatus: function() {
        return {
            sslWriteHooked: !!_sslWriteFn,
            sslObjCaptured: !!_sslObj,
            sslObj: _sslObj ? _sslObj.toString() : null,
            sslReadOk: _sslReadOk,
            sslWriteOk: _sslWriteOk
        };
    }
};
