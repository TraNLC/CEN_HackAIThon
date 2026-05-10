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
    var sendAddr     = libc.findExportByName('send');
    var sendtoAddr   = libc.findExportByName('sendto');

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
        if (n <= 0) return;
        if (this.fd !== gameFd && gameFd !== -1) return;
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
                            var ey = parseInt(sparts[2]);
                            var ex = parseInt(sparts[3]);
                            if (ex > 0 && ey > 0) {
                                _lastPosition = { x: ex, y: ey, eid: sparts[1], ts: Date.now() };
                                if (gameFd === -1) {
                                    gameFd = this.fd;
                                    send({ type: 'info', msg: 'Auto-locked gameFd: ' + gameFd });
                                }
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
    function onSendEnter(args) {
        this.fd = args[0].toInt32();
        this.buf = args[1];
        this.len = args[2].toInt32();
    }
    
    function onSendLeave(retval) {
        var n = retval.toInt32();
        if (n <= 0) return;
        if (this.fd !== gameFd && gameFd !== -1) return;
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

    if (nativeWritePtr) Interceptor.attach(nativeWritePtr, { onEnter: onSendEnter, onLeave: onSendLeave });
    if (sendAddr)       Interceptor.attach(sendAddr,       { onEnter: onSendEnter, onLeave: onSendLeave });
    if (sendtoAddr)     Interceptor.attach(sendtoAddr,     { onEnter: onSendEnter, onLeave: onSendLeave });

    // ==================== SSL HOOKS (game uses SSL!) ====================
    try {
        var sslReadAddr = null;
        var sslWriteAddr = null;

        // Method 1: enumerateExports
        var sslMod = Process.findModuleByName('libssl.so');
        if (sslMod) {
            var sslExports = sslMod.enumerateExports();
            for (var ei = 0; ei < sslExports.length; ei++) {
                if (sslExports[ei].name === 'SSL_read') sslReadAddr = sslExports[ei].address;
                if (sslExports[ei].name === 'SSL_write') sslWriteAddr = sslExports[ei].address;
            }
        }

        // Method 2: findExportByName fallback
        if (!sslReadAddr) sslReadAddr = Module.findExportByName('libssl.so', 'SSL_read');
        if (!sslWriteAddr) sslWriteAddr = Module.findExportByName('libssl.so', 'SSL_write');

        // Method 3: try null module (search all loaded modules)
        if (!sslReadAddr) sslReadAddr = Module.findExportByName(null, 'SSL_read');
        if (!sslWriteAddr) sslWriteAddr = Module.findExportByName(null, 'SSL_write');

        send({ type: 'info', msg: 'SSL_read: ' + sslReadAddr + ', SSL_write: ' + sslWriteAddr });
        
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
                                        var ey = parseInt(sparts[2]);
                                        var ex = parseInt(sparts[3]);
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

// ==================== CACHE IL2CPP APIs AT INIT TIME ====================
// On Houdini x86, Frida cannot see ARM modules. We manually parse the ELF
// dynamic symbol table from the memory-mapped libil2cpp.so to find exports.
var _il2cpp = {};
(function cacheIl2CppAPIs() {
    if (!il2cppBase) { send({ type: 'il2cpp_apis', found: 0, error: 'no base' }); return; }

    // ---- Approach 1: Try Process.getModuleByAddress ----
    var exportMap = {};
    try {
        var mod = Process.getModuleByAddress(il2cppBase);
        if (mod) {
            var exps = mod.enumerateExports();
            for (var i = 0; i < exps.length; i++) {
                if (exps[i].name.indexOf('il2cpp_') === 0) {
                    exportMap[exps[i].name] = exps[i].address;
                }
            }
        }
    } catch(e) {}

    // ---- Approach 2: Try Module.findExportByName ----
    if (Object.keys(exportMap).length === 0) {
        var testNames = ['il2cpp_domain_get'];
        for (var t = 0; t < testNames.length; t++) {
            try {
                var a = Module.findExportByName('libil2cpp.so', testNames[t]);
                if (a) exportMap[testNames[t]] = a;
            } catch(e) {}
        }
    }

    // ---- Approach 3: Manual ELF parsing ----
    if (Object.keys(exportMap).length === 0) {
        try {
            // Read ELF header (ARM 32-bit)
            var ei_class = il2cppBase.add(4).readU8(); // 1 = 32bit, 2 = 64bit
            var is32 = (ei_class === 1);
            
            // Read program headers to find PT_DYNAMIC
            var e_phoff = is32 ? il2cppBase.add(28).readU32() : il2cppBase.add(32).readU64();
            var e_phentsize = is32 ? il2cppBase.add(42).readU16() : il2cppBase.add(54).readU16();
            var e_phnum = is32 ? il2cppBase.add(44).readU16() : il2cppBase.add(56).readU16();
            
            var dynAddr = null;
            for (var p = 0; p < e_phnum; p++) {
                var phdr = il2cppBase.add(e_phoff).add(p * e_phentsize);
                var p_type = phdr.readU32();
                if (p_type === 2) { // PT_DYNAMIC
                    var p_vaddr = is32 ? phdr.add(8).readU32() : phdr.add(16).readU64();
                    dynAddr = il2cppBase.add(p_vaddr);
                    break;
                }
            }
            
            if (dynAddr) {
                // Parse .dynamic section to find DT_SYMTAB, DT_STRTAB, DT_HASH/DT_GNU_HASH
                var symtab = null, strtab = null, hashtab = null, gnuhash = null;
                var dyn_entsize = is32 ? 8 : 16;
                
                for (var d = 0; d < 256; d++) {
                    var dyn = dynAddr.add(d * dyn_entsize);
                    var d_tag = is32 ? dyn.readU32() : dyn.readU64().toNumber();
                    if (d_tag === 0) break; // DT_NULL
                    var d_val = is32 ? dyn.add(4).readU32() : dyn.add(8).readU64().toNumber();
                    
                    if (d_tag === 6) symtab = il2cppBase.add(d_val);   // DT_SYMTAB
                    if (d_tag === 5) strtab = il2cppBase.add(d_val);   // DT_STRTAB
                    if (d_tag === 4) hashtab = il2cppBase.add(d_val);  // DT_HASH
                    if (d_tag === 0x6ffffef5) gnuhash = il2cppBase.add(d_val); // DT_GNU_HASH
                }
                
                if (symtab && strtab) {
                    // Get symbol count from DT_HASH (nchain = total symbols)
                    var nsyms = 0;
                    if (hashtab) {
                        // ELF hash: [nbucket, nchain, ...]  nchain = total symbols
                        nsyms = hashtab.add(4).readU32();
                    } else {
                        nsyms = 10000; // fallback: scan up to 10k symbols
                    }
                    
                    var sym_entsize = is32 ? 16 : 24;
                    var il2cppCount = 0;
                    
                    for (var s = 0; s < nsyms; s++) {
                        try {
                            var sym = symtab.add(s * sym_entsize);
                            var st_name = sym.readU32();
                            if (st_name === 0) continue;
                            
                            var st_value = is32 ? sym.add(4).readU32() : sym.add(8).readU64().toNumber();
                            if (st_value === 0) continue;
                            
                            var nameStr = strtab.add(st_name).readUtf8String();
                            if (nameStr && nameStr.indexOf('il2cpp_') === 0) {
                                exportMap[nameStr] = il2cppBase.add(st_value);
                                il2cppCount++;
                            }
                        } catch(e) { break; } // hit unmapped memory = end
                    }
                    send({ type: 'info', msg: 'ELF parse: found ' + il2cppCount + ' il2cpp symbols from ' + nsyms + ' total' });
                }
            }
        } catch(e) {
            send({ type: 'info', msg: 'ELF parse error: ' + e });
        }
    }

    // ---- Create NativeFunction wrappers from exportMap ----
    var apis = {
        'domain_get':                ['pointer', []],
        'domain_get_assemblies':     ['pointer', ['pointer', 'pointer']],
        'assembly_get_image':        ['pointer', ['pointer']],
        'image_get_class_count':     ['int', ['pointer']],
        'image_get_class':           ['pointer', ['pointer', 'int']],
        'class_from_name':           ['pointer', ['pointer', 'pointer', 'pointer']],
        'class_get_name':            ['pointer', ['pointer']],
        'class_get_namespace':       ['pointer', ['pointer']],
        'class_get_fields':          ['pointer', ['pointer', 'pointer']],
        'class_get_methods':         ['pointer', ['pointer', 'pointer']],
        'class_get_field_from_name': ['pointer', ['pointer', 'pointer']],
        'class_get_method_from_name':['pointer', ['pointer', 'pointer', 'int']],
        'field_get_name':            ['pointer', ['pointer']],
        'field_get_offset':          ['uint', ['pointer']],
        'field_static_get_value':    ['void', ['pointer', 'pointer']],
        'method_get_name':           ['pointer', ['pointer']],
        'runtime_invoke':            ['pointer', ['pointer', 'pointer', 'pointer', 'pointer']],
        'string_new':                ['pointer', ['pointer']],
        'object_get_class':          ['pointer', ['pointer']],
    };
    var found = 0, missing = 0;
    for (var name in apis) {
        var fullName = 'il2cpp_' + name;
        var addr = exportMap[fullName] || null;
        if (addr) {
            _il2cpp[name] = new NativeFunction(addr, apis[name][0], apis[name][1]);
            found++;
        } else {
            missing++;
        }
    }
    send({ type: 'il2cpp_apis', found: found, missing: missing, exportMapSize: Object.keys(exportMap).length });
})();

var _targetMoveX = 0;
var _targetMoveY = 0;

// Read PlayerMain instance directly from IL2CPP class static using API offsets
function readPlayerMainDirect() {
    if (!il2cppBase) return { ok: false, error: 'il2cpp not found' };
    try {
        if (!_il2cpp['domain_get']) return { ok: false, error: 'il2cpp API not initialized' };

        var il2cpp_domain_get = _il2cpp['domain_get'];
        var il2cpp_domain_get_assemblies = _il2cpp['domain_get_assemblies'];
        var il2cpp_assembly_get_image = _il2cpp['assembly_get_image'];
        var il2cpp_class_from_name = _il2cpp['class_from_name'];
        var il2cpp_class_get_field_from_name = _il2cpp['class_get_field_from_name'];
        var il2cpp_class_get_method_from_name = _il2cpp['class_get_method_from_name'];
        var il2cpp_field_static_get_value = _il2cpp['field_static_get_value'];

        var domain = il2cpp_domain_get();
        if (domain.isNull()) return { ok: false, error: 'domain is null' };
        
        var sizePtr = Memory.alloc(4);
        var assemblies = il2cpp_domain_get_assemblies(domain, sizePtr);
        var count = sizePtr.readU32();
        
        for (var i=0; i<count; i++) {
            var asm = assemblies.add(i * Process.pointerSize).readPointer();
            if (asm.isNull()) continue;
            var img = il2cpp_assembly_get_image(asm);
            if (img.isNull()) continue;
            var klass = il2cpp_class_from_name(img, Memory.allocUtf8String(''), Memory.allocUtf8String('PlayerMain'));
            if (!klass.isNull()) {
                // Hook Update
                var method = il2cpp_class_get_method_from_name(klass, Memory.allocUtf8String('Update'), -1);
                if (!method.isNull()) {
                    var methodPtr = method.readPointer();
                    Interceptor.attach(methodPtr, {
                        onEnter: function(args) {
                            if (_targetMoveX > 0) {
                                try {
                                    var GotoFindingPath = new NativeFunction(il2cppBase.add(0x706A70), 'void', ['pointer', 'int', 'int', 'int', 'pointer', 'pointer']);
                                    GotoFindingPath(args[0], _targetMoveX, _targetMoveY, 20, ptr(0), ptr(0));
                                } catch (e) {}
                                _targetMoveX = 0;
                            }
                        }
                    });
                }
                
                var field = il2cpp_class_get_field_from_name(klass, Memory.allocUtf8String('instance'));
                if (!field.isNull()) {
                    var outPtr = Memory.alloc(Process.pointerSize);
                    il2cpp_field_static_get_value(field, outPtr);
                    var inst = outPtr.readPointer();
                    if (!inst.isNull()) {
                        _playerMainInstance = inst;
                        return { ok: true };
                    }
                }
            }
        }
        return { ok: false, error: 'PlayerMain class not found' };
    } catch(e) {
        return { ok: false, error: e.toString() };
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
            var il2cpp_object_get_class = _il2cpp['object_get_class'];
            var il2cpp_class_get_field_from_name = _il2cpp['class_get_field_from_name'];
            var il2cpp_field_get_offset = _il2cpp['field_get_offset'];

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
            var il2cpp_class_get_fields = _il2cpp['class_get_fields'];
            var il2cpp_field_get_name = _il2cpp['field_get_name'];

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
            var il2cpp_object_get_class = _il2cpp['object_get_class'];
            var il2cpp_class_get_field_from_name = _il2cpp['class_get_field_from_name'];
            var il2cpp_field_get_offset = _il2cpp['field_get_offset'];

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

    gotopath: function(x, y) {
        if (!il2cppBase) return { ok: false, error: 'il2cpp not found' };
        try {
            if (typeof _playerMainInstance === 'undefined' || !_playerMainInstance) {
                var res = readPlayerMainDirect();
                if (!res.ok) return { ok: false, error: 'PlayerMain load failed: ' + res.error };
            }
            
            // Tell the Update hook to execute the move on the game thread!
            _targetMoveX = x;
            _targetMoveY = y;
            
            return { ok: true, x: x, y: y };
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
    },

    // ==================== IL2CPP CLASS SCANNER (uses cached _il2cpp) ====================
    scanclasses: function(keyword) {
        if (!_il2cpp.domain_get) return { ok: false, error: 'il2cpp APIs not cached' };
        try {
            var domain = _il2cpp.domain_get();
            var sizePtr = Memory.alloc(4);
            var assemblies = _il2cpp.domain_get_assemblies(domain, sizePtr);
            var asmCount = sizePtr.readU32();
            var results = [];
            var kw = keyword.toLowerCase();

            for (var a = 0; a < asmCount; a++) {
                var asm = assemblies.add(a * Process.pointerSize).readPointer();
                var img = _il2cpp.assembly_get_image(asm);
                var classCount = _il2cpp.image_get_class_count(img);
                for (var c = 0; c < classCount; c++) {
                    var klass = _il2cpp.image_get_class(img, c);
                    if (klass.isNull()) continue;
                    var name = _il2cpp.class_get_name(klass).readUtf8String();
                    var ns = _il2cpp.class_get_namespace(klass).readUtf8String();
                    if (name.toLowerCase().indexOf(kw) !== -1 || ns.toLowerCase().indexOf(kw) !== -1) {
                        results.push({ name: name, namespace: ns, ptr: klass.toString() });
                    }
                }
            }
            return { ok: true, count: results.length, classes: results };
        } catch(e) {
            return { ok: false, error: e.toString() };
        }
    },

    // ==================== DUMP CLASS (uses cached _il2cpp) ====================
    dumpclass: function(className, namespaceName) {
        if (!_il2cpp.domain_get) return { ok: false, error: 'il2cpp APIs not cached' };
        try {
            var domain = _il2cpp.domain_get();
            var sizePtr = Memory.alloc(4);
            var assemblies = _il2cpp.domain_get_assemblies(domain, sizePtr);
            var asmCount = sizePtr.readU32();
            var klass = null;
            var nsStr = Memory.allocUtf8String(namespaceName || '');
            var nameStr = Memory.allocUtf8String(className);
            for (var a = 0; a < asmCount; a++) {
                var asm = assemblies.add(a * Process.pointerSize).readPointer();
                var img = _il2cpp.assembly_get_image(asm);
                var k = _il2cpp.class_from_name(img, nsStr, nameStr);
                if (!k.isNull()) { klass = k; break; }
            }
            if (!klass) return { ok: false, error: 'Class not found: ' + className };
            var fields = [];
            var iter = Memory.alloc(Process.pointerSize);
            iter.writePointer(ptr(0));
            var field;
            while (!(field = _il2cpp.class_get_fields(klass, iter)).isNull()) {
                fields.push({ name: _il2cpp.field_get_name(field).readUtf8String(), offset: _il2cpp.field_get_offset(field) });
            }
            var methods = [];
            iter.writePointer(ptr(0));
            var method;
            while (!(method = _il2cpp.class_get_methods(klass, iter)).isNull()) {
                methods.push({ name: _il2cpp.method_get_name(method).readUtf8String(), ptr: method.toString() });
            }
            return { ok: true, className: className, fields: fields, methods: methods, classPtr: klass.toString() };
        } catch(e) {
            return { ok: false, error: e.toString() };
        }
    },

    checkexports: function() {
        var result = {};
        for (var name in _il2cpp) {
            result['il2cpp_' + name] = 'OK';
        }
        return result;
    }
};
