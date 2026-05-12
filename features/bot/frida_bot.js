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

function installPlayerMainHooks() {
    if (!il2cppBase) return;
    var hooks = [
        ['PlayerMain.Initialize', 0x6FC9DC],
        ['PlayerMain.Update', 0x6FCB3C],
        ['PlayerMain.ClearRun', 0x6FC9B0],
        ['PlayerMain.IsOutScreenVisibility', 0x6FD91C],
        ['PlayerMain.IsInScreenVisibility', 0x6FDAE8],
        ['PlayerMain.SendGSMessage1', 0x701E58],
        ['PlayerMain.SendGSMessage2', 0x6FF738],
        ['PlayerMain.GetNearPlayers', 0x701EC8],
        ['PlayerMain.GetNearNpcs', 0x700194],
        ['PlayerMain.ProtocolGotoPosition', 0x708288],
        ['PlayerMain.GotoFindingPathUpdate', 0x6FD2BC],
        ['PlayerMain.SetUpMainPlayer', 0x7037A4],
    ];
    for (var i = 0; i < hooks.length; i++) {
        (function(name, rva) {
            try {
                Interceptor.attach(il2cppBase.add(rva), {
                    onEnter: function(args) {
                        if (!_playerMainInstance) {
                            _playerMainInstance = args[0];
                            send({ type: 'il2cpp_event', event: name + ' captured', ptr: _playerMainInstance.toString() });
                        }
                    }
                });
            } catch(e) {
                send({ type: 'il2cpp_error', msg: 'hook ' + name + ' failed: ' + e.toString() });
            }
        })(hooks[i][0], hooks[i][1]);
    }
    try {
        Interceptor.attach(il2cppBase.add(0x706A70), {
            onEnter: function(args) {
                _playerMainInstance = args[0];
                send({ type: 'il2cpp_event', event: 'PlayerMain.GotoFindingPath captured', ptr: _playerMainInstance.toString() });
            }
        });
    } catch(e) {
        send({ type: 'il2cpp_error', msg: 'hook PlayerMain.GotoFindingPath failed: ' + e.toString() });
    }
}

installPlayerMainHooks();

// Read PlayerMain instance directly from IL2CPP class static when exports are visible.
function il2cppExport(name) {
    var mod = Process.findModuleByName('libil2cpp.so');
    if (!mod) {
        var mods = Process.enumerateModules();
        for (var i = 0; i < mods.length; i++) {
            if (
                (mods[i].name && mods[i].name.indexOf('libil2cpp.so') !== -1) ||
                (mods[i].path && mods[i].path.indexOf('libil2cpp.so') !== -1)
            ) {
                mod = mods[i];
                break;
            }
        }
    }
    var p = null;
    if (mod) p = mod.findExportByName(name);
    if (!p) {
        try {
            var s = DebugSymbol.fromName(name);
            if (s && s.address && !s.address.isNull()) p = s.address;
        } catch(e) {}
    }
    if (!p) {
        try {
            var s2 = DebugSymbol.fromName('libil2cpp.so!' + name);
            if (s2 && s2.address && !s2.address.isNull()) p = s2.address;
        } catch(e2) {}
    }
    if (!p) throw new Error('Missing il2cpp export: ' + name);
    return p;
}

function readPlayerMainDirect() {
    if (_playerMainInstance) return { ok: true, playerMain: _playerMainInstance.toString(), source: 'captured' };
    if (!il2cppBase) return { ok: false, error: 'il2cpp not found' };
    try {
        var il2cpp_domain_get = new NativeFunction(il2cppExport('il2cpp_domain_get'), 'pointer', []);
        var il2cpp_thread_attach = new NativeFunction(il2cppExport('il2cpp_thread_attach'), 'pointer', ['pointer']);
        var il2cpp_domain_assembly_open = new NativeFunction(il2cppExport('il2cpp_domain_assembly_open'), 'pointer', ['pointer', 'pointer']);
        var il2cpp_assembly_get_image = new NativeFunction(il2cppExport('il2cpp_assembly_get_image'), 'pointer', ['pointer']);
        var il2cpp_class_from_name = new NativeFunction(il2cppExport('il2cpp_class_from_name'), 'pointer', ['pointer', 'pointer', 'pointer']);
        var il2cpp_class_get_field_from_name = new NativeFunction(il2cppExport('il2cpp_class_get_field_from_name'), 'pointer', ['pointer', 'pointer']);
        var il2cpp_field_static_get_value = new NativeFunction(il2cppExport('il2cpp_field_static_get_value'), 'void', ['pointer', 'pointer']);

        var domain = il2cpp_domain_get();
        if (domain.isNull()) return { ok: false, error: 'domain null' };
        il2cpp_thread_attach(domain);

        var assembly = il2cpp_domain_assembly_open(domain, Memory.allocUtf8String('Assembly-CSharp.dll'));
        if (assembly.isNull()) assembly = il2cpp_domain_assembly_open(domain, Memory.allocUtf8String('Assembly-CSharp'));
        if (assembly.isNull()) return { ok: false, error: 'Assembly-CSharp not found' };

        var image = il2cpp_assembly_get_image(assembly);
        if (image.isNull()) return { ok: false, error: 'Assembly-CSharp image null' };

        var klass = il2cpp_class_from_name(image, Memory.allocUtf8String(''), Memory.allocUtf8String('PlayerMain'));
        if (klass.isNull()) return { ok: false, error: 'PlayerMain class not found' };

        var field = il2cpp_class_get_field_from_name(klass, Memory.allocUtf8String('instance'));
        if (field.isNull()) return { ok: false, error: 'PlayerMain.instance field not found' };

        var out = Memory.alloc(Process.pointerSize);
        out.writePointer(ptr(0));
        il2cpp_field_static_get_value(field, out);
        var instance = out.readPointer();
        if (instance.isNull()) return { ok: false, error: 'PlayerMain.instance is null' };

        _playerMainInstance = instance;
        return { ok: true, playerMain: instance.toString() };
    } catch(e) {
        return { ok: false, error: 'PlayerMain not captured; metadata unavailable: ' + e.toString(), stack: e.stack };
    }
}

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

    getPlayerMain: function() {
        return readPlayerMainDirect();
    },

    scanPlayerMainCandidates: function(expectedMapId) {
        var targetMapId = expectedMapId || 53;
        var candidates = [];
        try {
            var ranges = Process.enumerateRanges({ protection: 'rw-', coalesce: true });
            var readable = Process.enumerateRanges({ protection: 'r--', coalesce: true })
                .concat(Process.enumerateRanges({ protection: 'rw-', coalesce: true }))
                .concat(Process.enumerateRanges({ protection: 'r-x', coalesce: true }))
                .concat(Process.enumerateRanges({ protection: 'rwx', coalesce: true }));
            function inRanges(v) {
                if (v === 0) return false;
                var pv = ptr(v);
                for (var k = 0; k < readable.length; k++) {
                    if (pv.compare(readable[k].base) >= 0 && pv.compare(readable[k].base.add(readable[k].size)) < 0) {
                        return true;
                    }
                }
                return false;
            }
            for (var r = 0; r < ranges.length; r++) {
                var range = ranges[r];
                if (range.size > 16 * 1024 * 1024) continue;
                var start = range.base;
                var end = range.base.add(range.size - 0x100);
                for (var p = start; p.compare(end) < 0; p = p.add(4)) {
                    try {
                        var mapId = p.add(0x98).readS32();
                        if (mapId !== targetMapId) continue;

                        var items32 = p.add(0x1C).readU32();
                        var skills32 = p.add(0x20).readU32();
                        var skillgames32 = p.add(0x24).readU32();
                        var world32 = p.add(0x28).readU32();
                        var target32 = p.add(0x5C).readU32();
                        var near = 0;
                        if (inRanges(items32)) near++;
                        if (inRanges(skills32)) near++;
                        if (inRanges(skillgames32)) near++;
                        if (inRanges(world32)) near++;
                        if (inRanges(target32)) near++;
                        if (near < 3) continue;

                        var findingRunning = p.add(0xE8).readU8();
                        var findingUpdate = p.add(0xE9).readU8();

                        candidates.push({
                            ptr: p.toString(),
                            mapId: mapId,
                            score: near,
                            items: ptr(items32).toString(),
                            skills: ptr(skills32).toString(),
                            skillgames: ptr(skillgames32).toString(),
                            world: ptr(world32).toString(),
                            target: ptr(target32).toString(),
                            findingRunning: findingRunning,
                            findingUpdate: findingUpdate,
                        });
                        if (candidates.length >= 50) return { ok: true, candidates: candidates };
                    } catch(e) {}
                }
            }
            return { ok: true, candidates: candidates };
        } catch(e) {
            return { ok: false, error: e.toString(), candidates: candidates };
        }
    },

    setPlayerMain: function(ptrText) {
        try {
            _playerMainInstance = ptr(ptrText);
            return { ok: true, playerMain: _playerMainInstance.toString() };
        } catch(e) {
            return { ok: false, error: e.toString() };
        }
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
            if (!_playerMainInstance) {
                var res = readPlayerMainDirect();
                if (!res.ok) return { ok: false, error: 'PlayerMain: ' + res.error };
            }
            if (typeof _playerMainInstance !== 'undefined' && _playerMainInstance) {
                GotoFindingPath(_playerMainInstance, x, y, 20, ptr(0), ptr(0));
                return { ok: true, x: x, y: y, playerMain: _playerMainInstance.toString() };
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
