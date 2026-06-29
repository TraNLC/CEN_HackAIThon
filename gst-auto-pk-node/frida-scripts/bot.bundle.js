'use strict';

rpc.exports = {};

// ══ core/globals.js ══
// === Console Shim ===
(function() {
    var originalLog = console.log;
    console.log = function() {
        var args = Array.prototype.slice.call(arguments);
        var msg = args.map(function(arg) {
            if (arg === null) return 'null';
            if (arg === undefined) return 'undefined';
            if (typeof arg === 'object') {
                try { return JSON.stringify(arg); } catch(e) { return String(arg); }
            }
            return String(arg);
        }).join(' ');
        originalLog.apply(console, arguments);
        send({ type: 'log', msg: msg });
    };
})();

// === File Shims ===
(function() {
    var OriginalFile = (typeof File !== 'undefined') ? File : null;
    globalThis.File = function(path, mode) {
        if (OriginalFile) {
            return new OriginalFile(path, mode);
        }
        return {};
    };
    if (OriginalFile) {
        globalThis.File.prototype = OriginalFile.prototype;
    }
    globalThis.File.readAllText = function(path) {
        var libc = Process.findModuleByName('libc.so');
        if (!libc) return '';
        var fn_fopen = libc.findExportByName('fopen');
        var fn_fgets = libc.findExportByName('fgets');
        var fn_fclose = libc.findExportByName('fclose');
        if (!fn_fopen || !fn_fgets || !fn_fclose) {
            return '';
        }
        var fopen = new NativeFunction(fn_fopen, 'pointer', ['pointer', 'pointer']);
        var fgets = new NativeFunction(fn_fgets, 'pointer', ['pointer', 'int', 'pointer']);
        var fclose = new NativeFunction(fn_fclose, 'int', ['pointer']);
        
        var fp = fopen(Memory.allocUtf8String(path), Memory.allocUtf8String('r'));
        if (fp.isNull()) return '';
        
        var lineBuf = Memory.alloc(1024);
        var content = '';
        while (true) {
            var res = fgets(lineBuf, 1024, fp);
            if (res.isNull()) break;
            content += lineBuf.readUtf8String();
        }
        fclose(fp);
        return content;
    };
})();

// === Socket State ===
var gameFd = -1;
var gameFdAutoLocked = false;
var _captureAllSends = false;
var recvBuffer = [];
var sendBuffer = [];
var SERVER_PUSH_OPS = {7:1,8:1,9:1,16:1,17:1,18:1,19:1,20:1,23:1,54:1,63:1,66:1,
                       72:1,118:1,124:1,125:1,126:1,166:1,205:1,245:1};

// === Il2Cpp State ===
var _playerMainInstance = null;
var _lastPosition = { x: 0, y: 0, eid: '', ts: 0 };
var il2cppBase = null;
var _playerMainScanned = false;
var _netCoreManagerScanned = false;
var _popUpCanvasScanned = false;
var _lastPlayerMainScanTime = 0;
var _lastNetCoreScanTime = 0;
var _lastPopUpCanvasScanTime = 0;

// === SSL State ===
var _sslReadOk = false;
var _sslWriteOk = false;
var _sslError = '';
var _sslWriteFn = null;
var _sslObj = null;

// === Diagnostic Counters ===
var _recvTotal = 0;
var _recvAny = 0;
var _fdsSeen = {};
var _fdsGameOps = {};
var _lastOps = [];
var _sendTotal = 0;

// === Native Function Pointers ===
var nativeWrite = null;
var nativeWritePtr = null;
var nativeReadPtr = null;
var writeSource = 'none';
var readSource = 'none';

// === Ripe Kim (Hoàng Kim Chín) State ===
var _ripeKimHooked = false;
var _ripeKimBuf = [];
var _npcAddLog = [];

// === Main-thread Task Queues (hook Update pattern) ===
var _pendingGoto = null;
var _gotoHookOn = false;
var _gotoLastFire = null;

var _pendingSkill = null;
var _skillHookOn = false;
var _skillLastFire = null;

var _pendingPkCid = null;
var _pendingPkSkill = 0;
var _pendingPkPhysic = 0;
var _pendingPkDismount = 0;
var _pkHookOn = false;
var _pkLast = null;

var _pendingDef = null;
var _defHookOn = false;
var _defLast = null;

var _pendingEquip = null;
var _equipHookOn = false;
var _equipLastFire = null;

var _popupQueue = null;
var _popupFound = null;
var _closeHookOn = false;
var _closePopupResult = null;

var _shopOpenLog = [];

var _sortQueue = null;
var _sortHookOn = false;
var _sortResult = null;

var _gotoCapOn = false;
var _gotoLog = [];

var _joyCapOn = false;
var _joyCnt = {};
var _joyConsumerOn = false;
var _joyRet = [];

// ══ core/helpers.js ══
// frida-scripts/core/helpers.js — Utility functions

/**
 * Convert Uint8Array to hex string (uppercase).
 * @param {Uint8Array} arr
 * @param {number} maxBytes - max bytes to convert
 * @returns {string}
 */
function toHex(arr, maxBytes) {
    var n = Math.min(arr.length, maxBytes || arr.length);
    var result = '';
    for (var i = 0; i < n; i++) {
        result += ('0' + arr[i].toString(16)).slice(-2);
    }
    return result;
}

/**
 * Parse packet header from buffer.
 * Packet format: [uint32 LE proto_len] [uint16 LE opcode] [proto body]
 * @param {Uint8Array} data
 * @returns {{ opcode: number, protoLen: number, valid: boolean }}
 */
function parsePacketHeader(data) {
    if (data.length < 6) return { opcode: -1, protoLen: -1, valid: false };
    var protoLen = data[0] | (data[1] << 8) | (data[2] << 16) | (data[3] << 24);
    var opcode = data[4] | (data[5] << 8);
    return { opcode: opcode, protoLen: protoLen, valid: opcode > 0 };
}

/**
 * Build a packet record for send/recv buffer.
 */
function makePacketRecord(data, n) {
    var hex = toHex(data, 8192);
    var hdr = parsePacketHeader(data);
    return {
        opcode: hdr.opcode,
        name: (hdr.opcode >= 0 && GS_OPCODES[hdr.opcode]) ? GS_OPCODES[hdr.opcode] : ('UNK_' + hdr.opcode),
        size: n,
        hex: hex,
        raw: hex
    };
}

/**
 * Emit a send packet from a buffer pointer + length (used by writev/sendmsg hooks).
 */
function emitFromBuf(base, n) {
    try {
        var take = n < 512 ? n : 512;
        var data = new Uint8Array(base.readByteArray(take));
        var hdr = parsePacketHeader(data);
        var name = (hdr.opcode >= 0 && GS_OPCODES[hdr.opcode]) ? GS_OPCODES[hdr.opcode] : ('UNK_' + hdr.opcode);
        var hex = toHex(data, 256);
        sendBuffer.push({ opcode: hdr.opcode, name: name, size: n, hex: hex });
        _sendTotal++;
        if (sendBuffer.length > 100) sendBuffer.shift();
        send({ type: 'send_out', opcode: hdr.opcode, name: name, size: n, hex: hex });
    } catch (e) {}
}

/**
 * Find an Il2Cpp export symbol by name.
 * Tries multiple naming conventions (+ version suffixes like _0, _1).
 */
function il2cppExport(name) {
    // 1. Find module
    var mod = Process.findModuleByName('libil2cpp.so');
    if (!mod) {
        var mods = Process.enumerateModules();
        for (var i = 0; i < mods.length; i++) {
            if ((mods[i].name && mods[i].name.indexOf('libil2cpp.so') !== -1) ||
                (mods[i].path && mods[i].path.indexOf('libil2cpp.so') !== -1)) {
                mod = mods[i];
                break;
            }
        }
    }
    if (!mod) return null;

    // 2. Try exact name (findExportByName)
    var p = mod.findExportByName(name);
    if (p) return p;

    // 3. Try with version suffixes: name_0, name_1, ...
    for (var s = 0; s < 5; s++) {
        p = mod.findExportByName(name + '_' + s);
        if (p) return p;
    }

    // 4. Try DebugSymbol
    try {
        var sym = DebugSymbol.fromName(name);
        if (sym && sym.address && !sym.address.isNull()) return sym.address;
    } catch(e) {}
    try {
        var sym2 = DebugSymbol.fromName('libil2cpp.so!' + name);
        if (sym2 && sym2.address && !sym2.address.isNull()) return sym2.address;
    } catch(e2) {}

    return null;
}

/**
 * Find a MonoBehaviour instance by class name (tries multiple namespaces).
 */
function findLoginInstance(className) {
    function tryClass(img, n) {
        try { return img.class(n); } catch (e) { return null; }
    }
    try {
        var img = Il2Cpp.domain.assembly('Assembly-CSharp').image;
        var names = [className,
            'game.scene.login.' + className,
            'game.network.' + className,
            'game.ui.' + className,
            'game.scene.' + className,
            'game.' + className];
        var k = null;
        for (var i = 0; i < names.length && !k; i++) {
            k = tryClass(img, names[i]);
        }
        if (!k) return null;
        var Res = Il2Cpp.domain.assembly('UnityEngine.CoreModule').image.class('UnityEngine.Resources');
        var arr = Res.method('FindObjectsOfTypeAll', 1).invoke(k.type.object);
        if (arr && arr.length) return arr.get(0);
    } catch (e) {}
    return null;
}

// ══ core/opcodes.js ══
// frida-scripts/core/opcodes.js — Game Server Opcode Map (VLTK1)

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
    119: 'eShopTypeOne',         120: 'eShopTypeTwo',
    122: 'eTownportal',
    132: 'eChatSend',            133: 'eChatMessage',
    140: 'eApplyAutoplayProfile',
    166: 'eSyncPlayerInfo',
    172: 'eEnterTongMap',        188: 'eSelfRevertMap',
    205: 'eAddPlayer',
    212: 'eShopResponse',
    229: 'eTongWarEnter',        231: 'eGotoNpc',
    232: 'eNpcHeal',
    238: 'eDoSkillTargetPlayer', 239: 'eDoSkillTargetNpc',
    240: 'eDoSkillTargetPosition',
    245: 'eSyncNpcData',
    248: 'eGotoPosition',
};

// ══ core/il2cpp-init.js ══
// frida-scripts/core/il2cpp-init.js — Il2Cpp base detection + PlayerMain reading
globalThis._mainThreadActions = globalThis._mainThreadActions || [];
globalThis.npcCache = globalThis.npcCache || {};

/**
 * Find libil2cpp.so base address from /proc/self/maps.
 */
function getIl2CppBase() {
    var mod = Process.findModuleByName('libil2cpp.so');
    if (mod) return mod.base;

    var base = null;
    var lines = File.readAllText('/proc/self/maps').split('\n');
    for (var i = 0; i < lines.length; i++) {
        var line = lines[i];
        if (line.indexOf('libil2cpp.so') !== -1 && line.indexOf('r--p') !== -1) {
            var parts = line.trim().split(/\s+/);
            base = ptr('0x' + parts[0].split('-')[0]);
            break;
        }
    }
    return base;
}

/**
 * Read PlayerMain.instance directly via IL2CPP static field.
 * Uses native il2cpp exports (no bridge required).
 */
function readPlayerMainDirect() {
    if (_playerMainInstance) {
        try {
            var mapId = _playerMainInstance.add(0xE4).readU32();
            if (mapId > 0 && mapId < 10000000) {
                return { ok: true, playerMain: _playerMainInstance.toString(), source: 'cached' };
            }
        } catch(e) {
            _playerMainInstance = null;
        }
    }
    
    var now = Date.now();
    _lastPlayerMainScanTime = now;
    
    // Resolve dynamically!
    try {
        var pattern = '50 6c 61 79 65 72 4d 61 69 6e'; // "PlayerMain"
        var nameStrAddr = null;
        
        var maps = File.readAllText('/proc/self/maps').split('\n');
        var metaRange = null;
        for (var i = 0; i < maps.length; i++) {
            var line = maps[i];
            if (line.indexOf('global-metadata.dat') !== -1) {
                var parts = line.split(' ')[0].split('-');
                metaRange = {
                    base: ptr('0x' + parts[0]),
                    size: parseInt('0x' + parts[1]) - parseInt('0x' + parts[0])
                };
                break;
            }
        }
        
        if (!metaRange) return { ok: false, error: 'global-metadata.dat not found' };
        
        var results = Memory.scanSync(metaRange.base, metaRange.size, pattern);
        if (results.length === 0) return { ok: false, error: '"PlayerMain" string not found' };
        nameStrAddr = results[0].address;
        
        var hex = nameStrAddr.toString(16);
        while (hex.length < 16) hex = '0' + hex;
        var parts = [];
        for (var j = 14; j >= 0; j -= 2) parts.push(hex.substring(j, j + 2));
        var ptrPattern = parts.join(' ');
        
        var allRanges = Process.enumerateRanges({ protection: 'rw-', coalesce: true });
        var classPtr = null;
        for (var k = 0; k < allRanges.length; k++) {
            try {
                var matches = Memory.scanSync(allRanges[k].base, allRanges[k].size, ptrPattern);
                if (matches.length > 0) {
                    for (var m = 0; m < matches.length; m++) {
                        var cand = matches[m].address.sub(0x10);
                        var nsPtr = cand.add(0x18).readPointer();
                        var nsName = nsPtr.isNull() ? '' : nsPtr.readUtf8String();
                        var checkNamePtr = cand.add(0x10).readPointer();
                        if (checkNamePtr.toString() === nameStrAddr.toString() && nsName === '') {
                            classPtr = cand;
                            break;
                        }
                    }
                }
            } catch(e) {}
            if (classPtr) break;
        }
        
        if (!classPtr) return { ok: false, error: 'PlayerMain class pointer not found' };
        
        var staticFields = classPtr.add(0xB8).readPointer();
        if (staticFields.isNull()) return { ok: false, error: 'static_fields is null' };
        
        var instance = staticFields.readPointer();
        if (instance.isNull()) return { ok: false, error: 'PlayerMain.instance is null' };
        
        _playerMainInstance = instance;
        return { ok: true, playerMain: _playerMainInstance.toString(), source: 'dynamic_scan' };
    } catch(e) {
        return { ok: false, error: 'dynamic scan error: ' + e.message };
    }
}

(function initIl2Cpp() {
    il2cppBase = getIl2CppBase();
    if (il2cppBase) {
        send({ type: 'il2cpp_ready', lib: 'libil2cpp.so', base: il2cppBase });
        try {
            // Hook Controller.Update at 0xFB6994 for reliable tick
            globalThis._tickCount = 0;
            Interceptor.attach(il2cppBase.add(0xFB6994), {
                onEnter: function(args) {
                    globalThis._tickCount++;
                    if (globalThis._tickCount % 600 === 0) {
                        // send({ type: 'log', message: '[Controller.Update] Firing, tick: ' + globalThis._tickCount });
                    }
                    if (globalThis._mainThreadActions && globalThis._mainThreadActions.length > 0) {
                        var action = globalThis._mainThreadActions.shift();
                        try {
                            action();
                        } catch (e) {
                            console.log("[MainThread] Exception executing action: " + e.message + "\\n" + e.stack);
                        }
                    }
                }
            });

            // libc recv hook removed. Waiting for World.Update to run on main thread.

            // Hook World.Update at 0xF2B3B8
            Interceptor.attach(il2cppBase.add(0xF2B3B8), {
                onEnter: function(args) {
                    try {
                        var worldPtr = args[0];
                        if (worldPtr.isNull()) return;

                        if (globalThis._mainThreadActions && globalThis._mainThreadActions.length > 0) {
                            var action = globalThis._mainThreadActions.shift();
                            try { action(); } catch(e) { console.log("MainThread Action Error: " + e.message); }
                        }

                    // World + 0x40 points to playerMain (PlayerMain)
                        var playerMainPtr = worldPtr.add(0x40).readPointer();
                        
                        // World + 0x50 points to mainPlayer (NpcRes.Special)
                        var mainPlayerPtr = worldPtr.add(0x50).readPointer();

                        if (!playerMainPtr.isNull()) {
                            if (!_playerMainInstance || _playerMainInstance.toString() !== playerMainPtr.toString()) {
                                _playerMainInstance = playerMainPtr;
                                send({ type: 'il2cpp_event', event: 'PlayerMain captured via World.Update', ptr: _playerMainInstance.toString() });
                            }
                        }
                    } catch(e) {
                        // Ignore read errors
                    }
                }
            });
            
            // We will do another script to find the correct offset for Controller.Update or similar.
            send({ type: 'il2cpp_event', event: 'Hooks attached successfully!' });
            
            // Poll nearNpcs safely
            setInterval(function() {
                try {
                    if (!_playerMainInstance || _playerMainInstance.isNull()) return;
                    
                    var nearNpcsPtr = _playerMainInstance.add(0x60).readPointer(); // Just guessing offset for nearNpcs, usually around 0x50-0x80
                    // Let's actually find the real offset from test_dict5.js output:
                    // We need to parse nearNpcs dictionary.
                    // Wait, earlier we ran test_dict5 and we will read the log.
                } catch(e) {}
            }, 2000);

        } catch (e) {
            send({ type: 'il2cpp_error', msg: 'hooks failed: ' + e.message + '\\n' + e.stack });
        }
    } else {
        send({ type: 'il2cpp_ready', msg: 'libil2cpp.so not found in maps' });
    }
})();

// ══ hooks/native-funcs.js ══
// frida-scripts/hooks/native-funcs.js — Find executable write() and read()

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
            // Find read
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

// ══ hooks/anti-detection.js ══
// frida-scripts/hooks/anti-detection.js — Anti-detection: prevent game from crashing when Frida attaches
// Based on FridaBypassKit patterns from reverse-skill toolkit

(function antiDetectionHooks() {
    // Only apply if Java is available (some games are pure native/Il2Cpp)
    try {
        if (typeof Java === 'undefined') return;
        
        Java.perform(function() {
            send({ type: 'log', msg: '[anti-detect] Installing anti-detection hooks...' });

            // 1. Debug detection bypass
            try {
                var Debug = Java.use('android.os.Debug');
                Debug.isDebuggerConnected.implementation = function() {
                    return false;
                };
                send({ type: 'log', msg: '[anti-detect] Debug.isDebuggerConnected hooked' });
            } catch(e) {}

            // 2. Prevent process killing (anti-tamper)
            try {
                var Process = Java.use('android.os.Process');
                Process.killProcess.implementation = function(pid) {
                    send({ type: 'log', msg: '[anti-detect] Blocked Process.killProcess(' + pid + ')' });
                    // Don't actually kill
                };
                send({ type: 'log', msg: '[anti-detect] Process.killProcess hooked' });
            } catch(e) {}

            // 3. System.exit() bypass
            try {
                var System = Java.use('java.lang.System');
                System.exit.implementation = function(code) {
                    send({ type: 'log', msg: '[anti-detect] Blocked System.exit(' + code + ')' });
                    // Don't exit
                };
                send({ type: 'log', msg: '[anti-detect] System.exit hooked' });
            } catch(e) {}

            // 4. Runtime.exec() - block shell commands that detect root/frida
            try {
                var Runtime = Java.use('java.lang.Runtime');
                Runtime.exec.overload('[Ljava.lang.String;').implementation = function(cmd) {
                    var cmdStr = cmd.length > 0 ? cmd[0] : '';
                    // Block known detection commands
                    if (cmdStr.indexOf('frida') !== -1 || 
                        cmdStr.indexOf('su') !== -1 ||
                        cmdStr.indexOf('magisk') !== -1 ||
                        cmdStr.indexOf('which') !== -1) {
                        send({ type: 'log', msg: '[anti-detect] Blocked suspicious exec: ' + cmdStr });
                        throw new Error('Command not found');
                    }
                    return this.exec(cmd);
                };
                send({ type: 'log', msg: '[anti-detect] Runtime.exec hooked' });
            } catch(e) {}

            // 5. File existence check bypass (hides frida-server)
            try {
                var File = Java.use('java.io.File');
                File.exists.implementation = function() {
                    var path = this.getAbsolutePath();
                    if (path.indexOf('frida') !== -1 || 
                        path.indexOf('su') !== -1 ||
                        path.indexOf('magisk') !== -1) {
                        send({ type: 'log', msg: '[anti-detect] Hiding file: ' + path });
                        return false;
                    }
                    return this.exists();
                };
                send({ type: 'log', msg: '[anti-detect] File.exists hooked' });
            } catch(e) {}

            send({ type: 'log', msg: '[anti-detect] Anti-detection hooks installed' });
        });
    } catch(e) {
        send({ type: 'log', msg: '[anti-detect] Java not available (pure native game), skipping' });
    }

    // === Native Anti-Debugging Bypass (TracerPid check) ===
    try {
        var appFilesDir = "/data/data/vn.perfingame.jx1mobile/files";
        var fakeStatusPath = appFilesDir + "/status";
        
        // 1. Create a fake status file with TracerPid = 0
        try {
            var f = new File(fakeStatusPath, "w");
            f.write("Name:\tvn.perfingame.jx1mobile\nState:\tR (running)\nTracerPid:\t0\n");
            f.close();
        } catch (err) {
            // Fallback to /data/local/tmp if files dir is not writable yet
            fakeStatusPath = "/data/local/tmp/fake_status";
            var f2 = new File(fakeStatusPath, "w");
            f2.write("Name:\tvn.perfingame.jx1mobile\nState:\tR (running)\nTracerPid:\t0\n");
            f2.close();
        }

        var fakePathPtr = Memory.allocUtf8String(fakeStatusPath);

        // 2. Hook fopen to redirect /proc/self/status
        var libc = Process.findModuleByName("libc.so");
        var fopenPtr = libc ? libc.findExportByName("fopen") : null;
        if (fopenPtr) {
            Interceptor.attach(fopenPtr, {
                onEnter: function(args) {
                    var path = Memory.readUtf8String(args[0]);
                    if (path && (path === "/proc/self/status" || path.indexOf("/status") !== -1 && path.indexOf("/proc/") !== -1)) {
                        args[0] = fakePathPtr; // Redirect to fake status file
                    }
                }
            });
            send({ type: 'log', msg: '[anti-detect] Native fopen (TracerPid redirection) hooked' });
        }

        // 3. Hook open to redirect /proc/self/status
        var openPtr = libc ? libc.findExportByName("open") : null;
        if (openPtr) {
            Interceptor.attach(openPtr, {
                onEnter: function(args) {
                    var path = Memory.readUtf8String(args[0]);
                    if (path && (path === "/proc/self/status" || path.indexOf("/status") !== -1 && path.indexOf("/proc/") !== -1)) {
                        args[0] = fakePathPtr; // Redirect to fake status file
                    }
                }
            });
            send({ type: 'log', msg: '[anti-detect] Native open (TracerPid redirection) hooked' });
        }
    } catch (e) {
        send({ type: 'log', msg: '[anti-detect] Native bypass failed: ' + e.message });
    }
})();

// ══ hooks/connect.js ══
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

// ══ hooks/recv.js ══
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

// ══ hooks/send.js ══
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

// ══ rpc/packet-io.js ══
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

// ══ rpc/core/Il2CppUtils.js ══
// frida-scripts/rpc/core/Il2CppUtils.js -- Utilities for IL2CPP memory and native exports

function findElfExport(base, targetName) {
    if (!base || base.isNull()) return ptr(0);
    
    // Try built-in resolver globally first
    try {
        var exp = Module.findExportByName(null, targetName);
        if (exp && !exp.isNull()) {
            return exp;
        }
    } catch(e) {
        // Module.findExportByName might be unsupported in this older frida/duktape
    }
    
    // Fallback to manual parsing if completely stripped
    var mod = null;
    var lines = File.readAllText('/proc/self/maps').split('\n');
    for (var i = 0; i < lines.length; i++) {
        var line = lines[i];
        if (line.indexOf('libil2cpp.so') !== -1 && line.indexOf('r--p') !== -1) {
            var parts = line.trim().split(/\s+/);
            if (parts[2] === '00000000') {
                base = ptr('0x' + parts[0].split('-')[0]);
                break;
            }
        }
    }
    
    var magic = base.readByteArray(4);
    var u8 = new Uint8Array(magic);
    if (u8[0] !== 0x7f || u8[1] !== 0x45 || u8[2] !== 0x4c || u8[3] !== 0x46) {
        return ptr(0);
    }
    
    // Read class: 1 = 32-bit, 2 = 64-bit
    var elfClass = base.add(4).readU8();
    var is64 = (elfClass === 2);
    
    var e_phoff, e_phentsize, e_phnum;
    if (is64) {
        e_phoff = base.add(32).readU64().toNumber();
        e_phentsize = base.add(54).readU16();
        e_phnum = base.add(56).readU16();
    } else {
        e_phoff = base.add(28).readU32().toNumber();
        e_phentsize = base.add(42).readU16();
        e_phnum = base.add(44).readU16();
    }
    
    var dynAddr = null;
    var dynSize = 0;
    
    for (var i = 0; i < e_phnum; i++) {
        var phdrAddr = base.add(e_phoff + i * e_phentsize);
        var p_type = phdrAddr.readU32();
        if (p_type === 2) { // PT_DYNAMIC
            var p_vaddr, p_memsz;
            if (is64) {
                p_vaddr = phdrAddr.add(16).readU64().toNumber();
                p_memsz = phdrAddr.add(40).readU64().toNumber();
            } else {
                p_vaddr = phdrAddr.add(8).readU32().toNumber();
                p_memsz = phdrAddr.add(20).readU32().toNumber();
            }
            dynAddr = base.add(p_vaddr);
            dynSize = p_memsz;
            break;
        }
    }
    
    if (!dynAddr) return ptr(0);
    
    var symtab = null;
    var strtab = null;
    
    var offset = 0;
    var dynEntrySize = is64 ? 16 : 8;
    while (offset < dynSize) {
        var entryAddr = dynAddr.add(offset);
        var d_tag, d_val;
        if (is64) {
            d_tag = entryAddr.readS64().toNumber();
            d_val = entryAddr.add(8).readPointer();
        } else {
            d_tag = entryAddr.readS32();
            d_val = entryAddr.add(4).readPointer();
        }
        
        if (d_tag === 0) break; // DT_NULL
        if (d_tag === 6) symtab = d_val; // DT_SYMTAB
        if (d_tag === 5) strtab = d_val; // DT_STRTAB
        
        offset += dynEntrySize;
    }
    
    if (!symtab || !strtab) return ptr(0);
    
    if (parseInt(symtab.toString()) < parseInt(base.toString())) {
        symtab = base.add(symtab);
    }
    if (parseInt(strtab.toString()) < parseInt(base.toString())) {
        strtab = base.add(strtab);
    }

    var idx = 0;
    var symEntrySize = is64 ? 24 : 16;
    while (idx < 50000) {
        try {
            var symAddr = symtab.add(idx * symEntrySize);
            var st_name = symAddr.readU32();
            var st_value;
            if (is64) {
                st_value = symAddr.add(8).readU64();
            } else {
                st_value = symAddr.add(4).readU32();
            }
            
            if (st_name === 0 && st_value.toString() === '0' && idx > 0) {
                break;
            }
        } catch(e) {
            break; // End of symtab or unreadable memory
        }
        
        try {
            var nameAddr = strtab.add(st_name);
            var name = nameAddr.readUtf8String();
            if (name === targetName) {
                return base.add(ptr(st_value.toString()));
            }
        } catch(e) {
            break;
        }
        idx++;
    }
    return ptr(0);
}

// ══ rpc/core/PlayerManager.js ══
// frida-scripts/rpc/core/PlayerManager.js -- Player info RPC exports (sect, skills, position)

rpc.exports.getMySect = function() {
    if (typeof Il2Cpp === 'undefined') return { ok: false, error: 'no il2cpp' };
    var res = { ok: true };
    return Il2Cpp.perform(function () {
        try {
            var img = Il2Cpp.domain.assembly("Assembly-CSharp").image;
            var pmClass = img.class("PlayerMain");
            var inst = pmClass.field("instance").value;
            if (!inst || inst.isNull()) return { ok: false, error: 'no PlayerMain.instance' };

            var npc = null;
            try { npc = inst.field("npcontroller").value; } catch (e) {
                try { npc = inst.field("m_npcontroller").value; } catch (e2) {}
            }
            if (!npc || npc.isNull()) return { ok: false, error: 'no controller' };

            var data = null;
            try { data = npc.field("data").value; } catch (e) {
                try { data = npc.field("m_data").value; } catch (e2) {}
            }
            if (!data || data.isNull()) return { ok: false, error: 'no data' };

            // Read basic fields
            try { res.series = data.field('series').value; } catch (e) { res.series = null; }
            try {
                var nv = data.field('name').value;
                if (nv) {
                    if (typeof nv.content !== 'undefined' && nv.content !== null) {
                        res.name = nv.content;
                    } else {
                        var ptr = nv.handle ? nv.handle : new NativePointer(nv);
                        if (!ptr.isNull()) {
                            var len = ptr.add(0x10).readS32();
                            if (len > 0 && len < 100) res.name = ptr.add(0x14).readUtf16String(len);
                        }
                    }
                }
            } catch (e) {}
            try { res.level = data.field('level').value; } catch (e) {}

            // Read faction via Controller
            var ctrl = new Il2Cpp.Object(npc.handle);
            try { res.faction = ctrl.method('GetFaction').invoke(); }
            catch (e1) {
                try {
                    var CtrlCls = img.class('game.resource.settings.npcres.Controller');
                    res.faction = CtrlCls.method('GetFaction').bind(ctrl).invoke();
                } catch (e2) { res.factionErr = '' + e2; }
            }

            // Read identify fields
            try {
                var idn = ctrl.field('identify').value;
                if (idn && !idn.isNull()) {
                    try { res.campValue = idn.field('campValue').value; } catch (e) {}
                    try { res.seriesValue = idn.field('seriesValue').value; } catch (e) {}
                    try { res.hp = idn.field('healthCurrent').value; } catch (e) {}
                    try { res.hpMax = idn.field('healthMax').value; } catch (e) {}

                    var mc = ['manaCurrent', 'mpCurrent', 'powerCurrent', 'internalCurrent'];
                    var mm = ['manaMax', 'mpMax', 'powerMax', 'internalMax'];
                    for (var mi = 0; mi < mc.length; mi++) {
                        try { var mv = idn.field(mc[mi]).value; if (mv !== null && mv !== undefined) { res.mp = mv; res.mpField = mc[mi]; break; } } catch (e) {}
                    }
                    for (var mj = 0; mj < mm.length; mj++) {
                        try { var mx = idn.field(mm[mj]).value; if (mx !== null && mx !== undefined) { res.mpMax = mx; break; } } catch (e) {}
                    }
                }
            } catch (e) { res.idErr = '' + e; }

            // Safe static mapping of Sect names and camps to prevent Access Violations
            var SECT_NAMES = {
                0: "Thieu Lam",
                1: "Thien Vuong",
                2: "Duong Mon",
                3: "Ngu Doc",
                4: "Nga My",
                5: "Thuy Yen",
                6: "Cai Bang",
                7: "Thien Nhan",
                8: "Vo Dang",
                9: "Con Lon",
                10: "Minh Giao",
                11: "Doan Thi"
            };
            res.sect = (res.faction !== undefined && res.faction !== null) ? res.faction : -1;
            res.sectName = SECT_NAMES[res.sect] || "None";
        } catch (e) { return { ok: false, error: '' + e }; }
        return res;
    });
};

rpc.exports.getNearNpcsDetail = function() {
    var res = { ok: true, npcs: [] };
    try {
        if (globalThis.npcCache) {
            for (var cid in globalThis.npcCache) {
                res.npcs.push({ id: cid, name: globalThis.npcCache[cid] });
            }
        }
    } catch (e) {
        res.ok = false;
        res.error = e.message;
    }
    return res;
};

rpc.exports.getMySkills = function() {
    if (typeof Il2Cpp === 'undefined') return { ok: false, error: 'no il2cpp' };
    var pmRes = readPlayerMainDirect();
    if (!pmRes.ok || !_playerMainInstance) return { ok: false, error: 'no PlayerMain' };
    return Il2Cpp.perform(function () {
        var out = [];
        try {
            var pm = new Il2Cpp.Object(_playerMainInstance);
            var m = pm.method("GetSkillId", 1);
            for (var i = 0; i < 25; i++) {
                try {
                    var sid = m.invoke(i);
                    if (sid && sid > 0) out.push({ idx: i, skillId: sid });
                } catch (e) {}
            }
        } catch (e) { return { ok: false, error: '' + e }; }
        return { ok: true, skills: out };
    });
};

rpc.exports.getPlayerInfo = function() {
    var pmRes = readPlayerMainDirect();
    var pos = typeof _lastPosition !== 'undefined' ? _lastPosition : { x: 0, y: 0, eid: 0, ts: Date.now() };
    var res = {
        ok: pmRes.ok,
        playerMain: pmRes.playerMain || null,
        source: pmRes.source || null,
        error: pmRes.error || null,
        position: { x: pos.x, y: pos.y, eid: pos.eid, age: Date.now() - pos.ts },
        recvTotal: typeof _recvTotal !== 'undefined' ? _recvTotal : 0,
        sendTotal: typeof _sendTotal !== 'undefined' ? _sendTotal : 0,
        gameFd: typeof gameFd !== 'undefined' ? gameFd : -1,
    };

    if (pmRes.ok && _playerMainInstance) {
        try {
            res.mapId = _playerMainInstance.add(0xE4).readS32();
            
            var npcontroller = _playerMainInstance.add(0x20).readPointer();
            if (!npcontroller.isNull()) {
                var dataPtr = npcontroller.add(0x30).readPointer();
                if (!dataPtr.isNull() && parseInt(dataPtr.toString()) > 0x10000) {
                    // Read cid
                    var cidPtr = dataPtr.add(0x10).readPointer();
                    if (!cidPtr.isNull() && parseInt(cidPtr.toString()) > 0x10000) {
                        var cidLen = cidPtr.add(0x10).readInt();
                        if (cidLen > 0 && cidLen < 100) {
                            res.cid = cidPtr.add(0x14).readUtf16String(cidLen);
                        }
                    }
                    
                    // Read name
                    var namePtr = dataPtr.add(0x40).readPointer();
                    if (!namePtr.isNull() && parseInt(namePtr.toString()) > 0x10000) {
                        var strLen = namePtr.add(0x10).readU32();
                        if (strLen > 0 && strLen < 100) {
                            res.name = namePtr.add(0x14).readUtf16String(strLen);
                        }
                    }
                    res.level = dataPtr.add(0x54).readU32();
                }
                
                var character = npcontroller.add(0xa0).readPointer();
                if (!character.isNull() && parseInt(character.toString()) > 0x10000) {
                    res.money = character.add(0x48).readS64().toString();
                    res.sect = character.add(0x34).readU32();
                    var SECT_NAMES = {
                        0: "Thiếu Lâm", 1: "Thiên Vương", 2: "Đường Môn", 3: "Ngũ Độc",
                        4: "Nga Mi", 5: "Thúy Yên", 6: "Cái Bang", 7: "Thiên Nhẫn",
                        8: "Võ Đang", 9: "Côn Lôn", 10: "Minh Giáo", 11: "Đoàn Thị"
                    };
                    res.sectName = SECT_NAMES[res.sect] || "Chưa rõ";
                    res.level = character.add(0x58).readU32();
                    res.storageMoney = character.add(0x110).readS64().toString();
                }

                // Read HP/MP using Il2Cpp if available
                if (typeof Il2Cpp !== 'undefined') {
                    Il2Cpp.perform(function() {
                        try {
                            var ctrl = new Il2Cpp.Object(npcontroller);
                            var idn = ctrl.field('identify').value;
                            if (idn && !idn.isNull()) {
                                res.hp = idn.field('healthCurrent').value;
                                res.maxHp = idn.field('healthMax').value;
                                
                                var mc = ['manaCurrent', 'mpCurrent', 'powerCurrent', 'internalCurrent'];
                                var mm = ['manaMax', 'mpMax', 'powerMax', 'internalMax'];
                                for (var mi = 0; mi < mc.length; mi++) {
                                    try { 
                                        var mv = idn.field(mc[mi]).value; 
                                        if (mv !== null && mv !== undefined) { 
                                            res.mp = mv; 
                                            break; 
                                        } 
                                    } catch (e) {}
                                }
                                for (var mj = 0; mj < mm.length; mj++) {
                                    try { 
                                        var mx = idn.field(mm[mj]).value; 
                                        if (mx !== null && mx !== undefined) { 
                                            res.maxMp = mx; 
                                            break; 
                                        } 
                                    } catch (e) {}
                                }
                            }
                        } catch(e) {}
                    });
                }
            }
        } catch (e) {
            res.error = "Error reading fields: " + e.message;
        }
    }
    return res;
};

rpc.exports.invalidatePlayerMain = function() {
    _playerMainInstance = null;
    if (typeof _charManagerClass !== 'undefined') _charManagerClass = null;
    if (typeof _netCoreManagerClass !== 'undefined') _netCoreManagerClass = null;
    if (typeof _popUpCanvasClass !== 'undefined') _popUpCanvasClass = null;
    if (typeof _byteClass !== 'undefined') _byteClass = null;
    return { ok: true };
};

// ══ rpc/core/DialogManager.js ══
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

// ══ rpc/shop/ShopScanner.js ══
// frida-scripts/rpc/shop/ShopScanner.js -- Nearby shops and stall interactions

var _charManagerClass = null;
var _lastCharManagerScanTime = 0;

rpc.exports.getNearbyShops = function() {
    try {
        if (!_charManagerClass) {
            var now = Date.now();
            if (now - _lastCharManagerScanTime < 5000) {
                return { ok: false, error: 'CharManager scan throttled (Please log into character first!)' };
            }
            _lastCharManagerScanTime = now;
            var pattern = '43 68 61 72 4d 61 6e 61 67 65 72'; // "CharManager"
            var maps = File.readAllText('/proc/self/maps').split('\n');
            var metaRange = null;
            for (var i = 0; i < maps.length; i++) {
                var line = maps[i];
                if (line.indexOf('global-metadata.dat') !== -1) {
                    var parts = line.split(' ')[0].split('-');
                    metaRange = {
                        base: ptr('0x' + parts[0]),
                        size: parseInt('0x' + parts[1]) - parseInt('0x' + parts[0])
                    };
                    break;
                }
            }
            
            if (!metaRange) return { ok: false, error: 'global-metadata.dat not found' };
            
            var results = Memory.scanSync(metaRange.base, metaRange.size, pattern);
            if (results.length === 0) return { ok: false, error: '"CharManager" string not found' };
            
            var nameStrAddr = null;
            for (var rIdx = 0; rIdx < results.length; rIdx++) {
                if (results[rIdx].address.readUtf8String() === "CharManager") {
                    nameStrAddr = results[rIdx].address;
                    break;
                }
            }
            if (!nameStrAddr) return { ok: false, error: 'Exact "CharManager" string not found' };
            
            var allRanges = Process.enumerateRanges({ protection: 'rw-', coalesce: true });
            var hex = nameStrAddr.toString(16);
            while (hex.length < 16) hex = '0' + hex;
            var parts = [];
            for (var j = 14; j >= 0; j -= 2) parts.push(hex.substring(j, j + 2));
            var ptrPattern = parts.join(' ');
            
            for (var k = 0; k < allRanges.length; k++) {
                try {
                    var matches = Memory.scanSync(allRanges[k].base, allRanges[k].size, ptrPattern);
                    if (matches.length > 0) {
                        for (var m = 0; m < matches.length; m++) {
                            var cand = matches[m].address.sub(0x10);
                            try {
                                var nsPtr = cand.add(0x18).readPointer();
                                var nsName = nsPtr.isNull() ? '' : nsPtr.readUtf8String();
                                var checkNamePtr = cand.add(0x10).readPointer();
                                if (checkNamePtr.toString() === nameStrAddr.toString()) {
                                    _charManagerClass = cand;
                                    break;
                                }
                            } catch(e) {}
                        }
                    }
                } catch(e) {}
                if (_charManagerClass) break;
            }
        }
        
        if (!_charManagerClass) return { ok: false, error: 'CharManager class not found' };
        
        var staticFields = _charManagerClass.add(0xB8).readPointer();
        if (staticFields.isNull()) return { ok: false, error: 'CharManager static_fields is null' };
        
        var charManagerInstance = staticFields.readPointer();
        if (charManagerInstance.isNull()) return { ok: false, error: 'CharManager.instance is null' };
        
        var myX = 0, myY = 0;
        try {
            var worldPtr = charManagerInstance.add(0x20).readPointer();
            if (!worldPtr.isNull() && parseInt(worldPtr.toString()) > 0x10000) {
                var playerMainPtr = worldPtr.add(0x40).readPointer();
                if (!playerMainPtr.isNull() && parseInt(playerMainPtr.toString()) > 0x10000) {
                    var npcontroller = playerMainPtr.add(0x20).readPointer();
                    if (!npcontroller.isNull() && parseInt(npcontroller.toString()) > 0x10000) {
                        var positionPtr = npcontroller.add(0x10).readPointer();
                        if (!positionPtr.isNull() && parseInt(positionPtr.toString()) > 0x10000) {
                            var mapPosPtr = positionPtr.add(0x28).readPointer();
                            if (!mapPosPtr.isNull() && parseInt(mapPosPtr.toString()) > 0x10000) {
                                myX = mapPosPtr.add(0x10).readInt();
                                myY = mapPosPtr.add(0x14).readInt();
                                console.log("[Shop] Player coords from npcontroller: " + myX + ", " + myY);
                            }
                        }
                    }
                }
            }
        } catch(e) {
            console.log("[Shop] Error resolving player coords: " + e.message);
        }
        if (myX === 0 && myY === 0 && typeof _lastPosition !== 'undefined' && _lastPosition) {
            myX = _lastPosition.x || 0;
            myY = _lastPosition.y || 0;
        }
        
        var salesmansDict = charManagerInstance.add(0x58).readPointer();
        var shops = [];
        
        if (!salesmansDict.isNull()) {
            var entriesArray = salesmansDict.add(0x18).readPointer();
            if (!entriesArray.isNull()) {
                var maxLength = entriesArray.add(0x18).readU32();
                for (var idx = 0; idx < maxLength; idx++) {
                    var entryAddr = entriesArray.add(0x20).add(idx * 24);
                    var valuePtr = entryAddr.add(16).readPointer();
                    
                    if (!valuePtr.isNull() && parseInt(valuePtr.toString()) > 0x10000) {
                        var dataPtr = valuePtr.add(0x30).readPointer();
                        if (!dataPtr.isNull() && parseInt(dataPtr.toString()) > 0x10000) {
                            var name = '';
                            var namePtr = dataPtr.add(0x40).readPointer();
                            if (!namePtr.isNull() && parseInt(namePtr.toString()) > 0x10000) {
                                var strLen = namePtr.add(0x10).readU32();
                                if (strLen > 0 && strLen < 100) {
                                    name = namePtr.add(0x14).readUtf16String(strLen);
                                }
                            }
                            
                            var cid = '';
                            var cidPtr = dataPtr.add(0x10).readPointer();
                            if (!cidPtr.isNull() && parseInt(cidPtr.toString()) > 0x10000) {
                                var cidLen = cidPtr.add(0x10).readInt();
                                if (cidLen > 0 && cidLen < 100) {
                                    cid = cidPtr.add(0x14).readUtf16String(cidLen);
                                }
                            }
                            
                            var isSalesman = dataPtr.add(0x69).readU8();
                            var level = dataPtr.add(0x54).readU32();
                            
                            var x = 0, y = 0;
                            try {
                                var positionPtr = valuePtr.add(0x10).readPointer();
                                if (!positionPtr.isNull() && parseInt(positionPtr.toString()) > 0x10000) {
                                    var mapPosPtr = positionPtr.add(0x28).readPointer();
                                    if (!mapPosPtr.isNull() && parseInt(mapPosPtr.toString()) > 0x10000) {
                                        x = mapPosPtr.add(0x10).readInt();
                                        y = mapPosPtr.add(0x14).readInt();
                                    }
                                }
                            } catch(e) {}
                            
                            var dist = 999999;
                            if (x > 0 && y > 0 && myX > 0 && myY > 0) {
                                dist = Math.sqrt((x - myX) * (x - myX) + (y - myY) * (y - myY));
                            }
                            
                            shops.push({
                                name: name,
                                namePtrStr: namePtr.toString(),
                                cid: cid,
                                cidPtrStr: cidPtr.toString(),
                                level: level,
                                isSalesman: isSalesman,
                                x: x,
                                y: y,
                                distance: dist,
                                controllerPtrStr: valuePtr.toString()
                            });
                        }
                    }
                }
            }
        }
        
        shops.sort(function(a, b) { return a.distance - b.distance; });
        return { ok: true, shops: shops };
    } catch (e) {
        return { ok: false, error: e.message };
    }
};

var _netCoreManagerClass = null;
var _lastNetCoreScanTime = 0;
function getNetCoreManagerInstance() {
    if (!_netCoreManagerClass) {
        var now = Date.now();
        if (now - _lastNetCoreScanTime < 5000) {
            console.log("[NetCore] Throttled return null");
            return null;
        }
        _lastNetCoreScanTime = now;
        var pattern = '4e 65 74 43 6f 72 65 4d 61 6e 61 67 65 72'; // "NetCoreManager"
        var maps = File.readAllText('/proc/self/maps').split('\n');
        var metaRange = null;
        for (var i = 0; i < maps.length; i++) {
            var line = maps[i];
            if (line.indexOf('global-metadata.dat') !== -1) {
                var parts = line.split(' ')[0].split('-');
                metaRange = { base: ptr('0x' + parts[0]), size: parseInt('0x' + parts[1]) - parseInt('0x' + parts[0]) };
                break;
            }
        }
        if (!metaRange) return null;
        
        var results = Memory.scanSync(metaRange.base, metaRange.size, pattern);
        if (results.length === 0) return null;
        
        var nameStrAddr = null;
        for (var rIdx = 0; rIdx < results.length; rIdx++) {
            if (results[rIdx].address.readUtf8String() === "NetCoreManager") {
                nameStrAddr = results[rIdx].address;
                break;
            }
        }
        if (!nameStrAddr) return null;
        
        var allRanges = Process.enumerateRanges({ protection: 'rw-', coalesce: true });
        var hex = nameStrAddr.toString(16);
        while (hex.length < 16) hex = '0' + hex;
        var parts = [];
        for (var j = 14; j >= 0; j -= 2) parts.push(hex.substring(j, j + 2));
        var ptrPattern = parts.join(' ');
        
        for (var k = 0; k < allRanges.length; k++) {
            try {
                var matches = Memory.scanSync(allRanges[k].base, allRanges[k].size, ptrPattern);
                if (matches.length > 0) {
                    for (var m = 0; m < matches.length; m++) {
                        var cand = matches[m].address.sub(0x10);
                        try {
                            var nsPtr = cand.add(0x18).readPointer();
                            var nsName = nsPtr.isNull() ? '' : nsPtr.readUtf8String();
                            var checkNamePtr = cand.add(0x10).readPointer();
                            if (checkNamePtr.toString() === nameStrAddr.toString()) {
                                _netCoreManagerClass = cand;
                                break;
                            }
                        } catch(e) {}
                    }
                }
            } catch(e) {}
            if (_netCoreManagerClass) break;
        }
    }
    if (!_netCoreManagerClass) return null;
    var staticFields = _netCoreManagerClass.add(0xB8).readPointer();
    if (staticFields.isNull()) return null;
    var instance = staticFields.readPointer();
    if (instance.isNull()) return null;
    return instance;
}

var _popUpCanvasClass = null;
var _lastPopUpCanvasScanTime = 0;
function getPopUpCanvasInstance() {
    if (!_popUpCanvasClass) {
        var now = Date.now();
        if (now - _lastPopUpCanvasScanTime < 5000) return null;
        _lastPopUpCanvasScanTime = now;
        var pattern = '50 6f 70 55 70 43 61 6e 76 61 73'; // "PopUpCanvas"
        var maps = File.readAllText('/proc/self/maps').split('\n');
        var metaRange = null;
        for (var i = 0; i < maps.length; i++) {
            var line = maps[i];
            if (line.indexOf('global-metadata.dat') !== -1) {
                var parts = line.split(' ')[0].split('-');
                metaRange = { base: ptr('0x' + parts[0]), size: parseInt('0x' + parts[1]) - parseInt('0x' + parts[0]) };
                break;
            }
        }
        if (!metaRange) return null;
        var results = Memory.scanSync(metaRange.base, metaRange.size, pattern);
        if (results.length === 0) return null;
        
        var nameStrAddr = null;
        for (var rIdx = 0; rIdx < results.length; rIdx++) {
            if (results[rIdx].address.readUtf8String() === "PopUpCanvas") {
                nameStrAddr = results[rIdx].address;
                break;
            }
        }
        if (!nameStrAddr) return null;
        
        var allRanges = Process.enumerateRanges({ protection: 'rw-', coalesce: true });
        var hex = nameStrAddr.toString(16);
        while (hex.length < 16) hex = '0' + hex;
        var parts = [];
        for (var j = 14; j >= 0; j -= 2) parts.push(hex.substring(j, j + 2));
        var ptrPattern = parts.join(' ');
        
        for (var k = 0; k < allRanges.length; k++) {
            try {
                var matches = Memory.scanSync(allRanges[k].base, allRanges[k].size, ptrPattern);
                if (matches.length > 0) {
                    for (var m = 0; m < matches.length; m++) {
                        var cand = matches[m].address.sub(0x10);
                        try {
                            var nsPtr = cand.add(0x18).readPointer();
                            var nsName = nsPtr.isNull() ? '' : nsPtr.readUtf8String();
                            var checkNamePtr = cand.add(0x10).readPointer();
                            if (checkNamePtr.toString() === nameStrAddr.toString()) {
                                _popUpCanvasClass = cand;
                                break;
                            }
                        } catch(e) {}
                    }
                }
            } catch(e) {}
            if (_popUpCanvasClass) break;
        }
    }
    if (!_popUpCanvasClass) return null;
    var staticFields = _popUpCanvasClass.add(0xB8).readPointer();
    if (staticFields.isNull()) return null;
    return staticFields.readPointer();
}

// Get shop items by stallIndex. Requires string pointers to bypass il2cpp_string_new native traps.
rpc.exports.getShopItems = function(stallIndex, nameStr, namePtrStr, cidPtrStr, controllerPtrStr) {
    return new Promise(function(resolve, reject) {
        try {
            console.log("[Shop] Bat dau getShopItems voi stallIndex: " + stallIndex);
            console.log("[Shop] namePtrStr: " + namePtrStr + ", cidPtrStr: " + cidPtrStr);
            if (!namePtrStr || !cidPtrStr) {
                console.log("[Shop] Missing string pointers!");
                resolve({ ok: false, error: 'Missing string pointers' });
                return;
            }
            var playerOtherStallClass = findClassByName("PlayerOtherStall");
            console.log("[Shop] playerOtherStallClass: " + playerOtherStallClass);
            var netCoreInstance = getNetCoreManagerInstance();
            if (!netCoreInstance || netCoreInstance.isNull()) {
                resolve({ ok: false, error: 'NetCoreManager instance is null' });
                return;
            }
            
            var popUpCanvasInstance = getPopUpCanvasInstance();
            if (!popUpCanvasInstance || popUpCanvasInstance.isNull()) {
                resolve({ ok: false, error: 'PopUpCanvas instance is null' });
                return;
            }
            
            var playerOtherStall = popUpCanvasInstance.add(0xA8).readPointer();
            if (playerOtherStall.isNull()) {
                resolve({ ok: false, error: 'playerOtherStall is null' });
                return;
            }
            
            var initialStall = playerOtherStall.add(0xA0).readPointer();
            console.log("[Shop] initialStall: " + initialStall);
            
            // ----------------------------------------------------
            // NEW: Send the TCP packet to request the shop data!
            // ----------------------------------------------------
            var cidLen = cidPtrStr ? ptr(cidPtrStr).add(0x10).readInt() : 0;
            if (cidLen > 0 && cidLen < 100) {
                var cid = ptr(cidPtrStr).add(0x14).readUtf16String(cidLen);
                var str = "salesman." + cid + ".0";
                var strLen = str.length;
                var payloadLen = 2 + strLen;
                var hexBody = [];
                hexBody.push(0x0A, strLen);
                for (var i = 0; i < strLen; i++) hexBody.push(str.charCodeAt(i));
                
                var hexStr = hexBody.map(b => (b<16?'0':'') + b.toString(16)).join('');
                if (rpc.exports.sendTcpPacket) {
                    var sendRes = rpc.exports.sendTcpPacket(204, hexStr);
                    console.log("[Shop] Sent TCP request for items: " + JSON.stringify(sendRes));
                }
            }
            // ----------------------------------------------------
            
            var il2cppBase = getIl2CppBase();
            if (!il2cppBase) {
                resolve({ ok: false, error: 'libil2cpp.so base not found' });
                return;
            }
            
            function findClassByName(className) {
                var maps = File.readAllText('/proc/self/maps').split('\n');
                var metaRange = null;
                for (var i = 0; i < maps.length; i++) {
                    var line = maps[i];
                    if (line.indexOf('global-metadata.dat') !== -1) {
                        var parts = line.split(' ')[0].split('-');
                        metaRange = { base: ptr('0x' + parts[0]), size: parseInt('0x' + parts[1]) - parseInt('0x' + parts[0]) };
                        break;
                    }
                }
                if (!metaRange) return null;
                var strHex = [];
                for (var i = 0; i < className.length; i++) {
                    var hex = className.charCodeAt(i).toString(16);
                    strHex.push(hex.length === 1 ? '0' + hex : hex);
                }
                var pattern = strHex.join(' ');
                var results = Memory.scanSync(metaRange.base, metaRange.size, pattern);
                var nameStrAddr = null;
                for (var rIdx = 0; rIdx < results.length; rIdx++) {
                    if (results[rIdx].address.readUtf8String() === className) {
                        nameStrAddr = results[rIdx].address;
                        break;
                    }
                }
                if (!nameStrAddr) return null;
                var allRanges = Process.enumerateRanges({ protection: 'rw-', coalesce: true });
                var hex = nameStrAddr.toString(16);
                while (hex.length < 16) hex = '0' + hex;
                var parts = [];
                for (var j = 14; j >= 0; j -= 2) parts.push(hex.substring(j, j + 2));
                var ptrPattern = parts.join(' ');
                for (var k = 0; k < allRanges.length; k++) {
                    var range = allRanges[k];
                    var classMatches = Memory.scanSync(range.base, range.size, ptrPattern);
                    for (var mIdx = 0; mIdx < classMatches.length; mIdx++) {
                        var klass = classMatches[mIdx].address.sub(0x10);
                        try {
                            if (klass.add(0x10).readPointer().equals(nameStrAddr)) {
                                return klass;
                            }
                        } catch(e) {}
                    }
                }
                return null;
            }

            function findMethodByName(klass, methodName) {
                try {
                    var methodsPtr = klass.add(0x98).readPointer();
                    var methodCount = klass.add(0x118).readU16();
                    console.log("[Dump] methodCount for " + methodName + ": " + methodCount);
                    for (var i = 0; i < methodCount; i++) {
                        var methodInfo = methodsPtr.add(i * Process.pointerSize).readPointer();
                        if (methodInfo.isNull()) continue;
                        var namePtr = methodInfo.add(0x10).readPointer();
                        if (!namePtr.isNull()) {
                            try {
                                var mName = namePtr.readUtf8String();
                                if (methodName === "Update") {
                                    console.log("  [Dump] Method: " + mName);
                                }
                                if (mName === methodName) {
                                    return methodInfo;
                                }
                            } catch(e) {}
                        }
                    }
                } catch(e) {
                    console.log("[Shop Hook] Exception in findMethodByName: " + e.message);
                }
                return null;
            }

            try {
                var il2cpp_string_new_ptr = findElfExport(il2cppBase, 'il2cpp_string_new');
                var il2cpp_domain_get_ptr = findElfExport(il2cppBase, 'il2cpp_domain_get');
                var il2cpp_thread_attach_ptr = findElfExport(il2cppBase, 'il2cpp_thread_attach');

                // Game UI should naturally update since we called remoteNpcDialogue externally.
                console.log("[Shop] Waiting for UI update from remoteNpcDialogue packet response...");
            } catch (err) {
                console.log("[Shop] Exception calling ShowReopen: " + err.message + "\\n" + err.stack);
            }
            console.log("[Shop] Queued shop action on main thread.");
            
            var attempts = 30;
            function checkStall() {
                try {
                    var currentStall = playerOtherStall.add(0xA0).readPointer();
                    console.log("[Shop] Kiem tra attempt " + attempts + " | currentStall: " + currentStall);
                    if (!currentStall.isNull() && currentStall.toString() !== initialStall.toString()) {
                        console.log("[Shop] Phat hien thong tin sap hang moi: " + currentStall);
                        try {
                            var titlePtr = currentStall.add(0x18).readPointer();
                            var title = titlePtr.isNull() ? '' : titlePtr.add(0x14).readUtf16String();
                            
                            var GetItemName = new NativeFunction(il2cppBase.add(0xFEB4A0), 'pointer', ['pointer', 'int', 'bool', 'pointer']);
                            var items = [];
                            var mapField = currentStall.add(0x28).readPointer();
                            if (!mapField.isNull()) {
                                var listPtr = mapField.add(0x18).readPointer();
                                if (!listPtr.isNull()) {
                                    var head = listPtr.add(0x10).readPointer();
                                    var count = listPtr.add(0x18).readU32();
                                    
                                    var curr = head.add(0x18).readPointer();
                                    for (var idx = 0; idx < count; idx++) {
                                        if (curr.isNull() || curr.toString() === head.toString()) break;
                                        
                                        var salesmanItemPtr = curr.add(0x30).readPointer();
                                        if (!salesmanItemPtr.isNull()) {
                                            var itemPtr = salesmanItemPtr.add(0x18).readPointer();
                                            var money = salesmanItemPtr.add(0x20).readU32();
                                            var knb = salesmanItemPtr.add(0x24).readU32();
                                            
                                            if (!itemPtr.isNull()) {
                                                var namePtr = GetItemName(itemPtr, 0, 0, ptr(0));
                                                var itemName = namePtr.isNull() ? 'Vat pham chua ro' : namePtr.add(0x14).readUtf16String();
                                                
                                                var identify = itemPtr.add(0x18).readU32();
                                                var rowIdxAndType = itemPtr.add(0x1C).readU32();
                                                var detailAndGenre = itemPtr.add(0x20).readU32();
                                                var particularAndLevel = itemPtr.add(0x24).readU32();
                                                var stackAndSeries = itemPtr.add(0x28).readU32();
                                                
                                                var magics = [];
                                                var magicPtr = itemPtr.add(0x50).readPointer();
                                                if (!magicPtr.isNull()) {
                                                    var magicArrayPtr = magicPtr.add(0x10).readPointer();
                                                    var magicCount = magicPtr.add(0x18).readU32();
                                                    if (!magicArrayPtr.isNull()) {
                                                        for (var mIdx = 0; mIdx < magicCount; mIdx++) {
                                                            var val = magicArrayPtr.add(0x20 + mIdx * 4).readS32();
                                                            magics.push(val);
                                                        }
                                                    }
                                                }
                                                
                                                items.push({
                                                    name: itemName,
                                                    money: money,
                                                    knb: knb,
                                                    identify: identify,
                                                    rowIndexAndType: rowIdxAndType,
                                                    detailAndGenre: detailAndGenre,
                                                    particularAndLevel: particularAndLevel,
                                                    stackAndSeries: stackAndSeries,
                                                    magics: magics
                                                });
                                            }
                                        }
                                        curr = curr.add(0x18).readPointer();
                                    }
                                }
                            }
                            resolve({ ok: true, title: title, items: items });
                        } catch(err) {
                            resolve({ ok: false, error: 'Read stall data error: ' + err.message + ' | ' + err.stack });
                        }
                    } else if (attempts > 0) {
                        attempts--;
                        setTimeout(checkStall, 50); // check again in 50ms
                    } else {
                        resolve({ ok: false, error: 'Timeout waiting for stall data response from server' });
                    }
                } catch (outerErr) {
                    resolve({ ok: false, error: 'checkStall exception: ' + outerErr.message + ' | ' + outerErr.stack });
                }
            }
            setTimeout(checkStall, 50);
        } catch(e) {
            resolve({ ok: false, error: e.message + ' | ' + e.stack });
        }
    });
};

// ══ rpc/movement.js ══
// frida-scripts/rpc/movement.js — Movement RPC exports (bridge-free)

rpc.exports.gotoFindingPath = function(x, y, approach) {
    var pmRes = readPlayerMainDirect();
    if (!pmRes.ok || !_playerMainInstance) return { ok: false, error: 'PlayerMain not found' };
    if (!il2cppBase) return { ok: false, error: 'il2cppBase not found' };

    try {
        var gotoFindingPathFn = new NativeFunction(il2cppBase.add(0xE4A620), 'void', ['pointer', 'int', 'int', 'int', 'pointer', 'pointer', 'pointer']);
        gotoFindingPathFn(_playerMainInstance, x | 0, y | 0, (approach | 0) || 20, ptr(0), ptr(0), ptr(0));
        return { ok: true, x: x, y: y, method: 'direct_native' };
    } catch (e) {
        return { ok: false, error: 'GotoFindingPath exception: ' + e };
    }
};

rpc.exports.gotoHooked = function(x, y, approach) {
    var pmRes = readPlayerMainDirect();
    if (!pmRes.ok || !_playerMainInstance) return { ok: false, error: 'PlayerMain not found' };
    if (!il2cppBase) return { ok: false, error: 'il2cppBase not found' };

    globalThis._pendingGoto = { x: x | 0, y: y | 0, ap: (approach | 0) || 20 };
    if (globalThis._gotoHookOn) return { ok: true, queued: true };

    try {
        var playerMainUpdate = il2cppBase.add(0xE42B4C);
        var gotoFindingPathFn = new NativeFunction(il2cppBase.add(0xE4A620), 'void', ['pointer', 'int', 'int', 'int', 'pointer', 'pointer', 'pointer']);

        Interceptor.attach(playerMainUpdate, {
            onEnter: function() {
                var g = globalThis._pendingGoto;
                if (!g) return;
                globalThis._pendingGoto = null;
                try {
                    gotoFindingPathFn(_playerMainInstance, g.x, g.y, g.ap, ptr(0), ptr(0), ptr(0));
                    globalThis._gotoLastFire = 'ok ' + g.x + ',' + g.y;
                } catch (e) {
                    globalThis._gotoLastFire = 'err ' + e;
                }
            }
        });
        globalThis._gotoHookOn = true;
        return { ok: true, hooked: true };
    } catch (e) {
        return { ok: false, error: '' + e };
    }
};

rpc.exports.gotoLastFire = function() {
    return { fire: globalThis._gotoLastFire || '(chua ban)' };
};

rpc.exports.findJoysticks = function() {
    return { ok: false, error: 'Joystick query needs bridge (disabled for stability)' };
};

rpc.exports.joystickSet = function(idx, dx, dy) {
    return { ok: false, error: 'Joystick control needs bridge (disabled for stability)' };
};

// ══ rpc/combat.js ══
// frida-scripts/rpc/combat.js — Combat RPC exports (bridge-free)

rpc.exports.doSkillHooked = function(skillId) {
    var pmRes = readPlayerMainDirect();
    if (!pmRes.ok || !_playerMainInstance) return { ok: false, error: 'no PlayerMain' };
    if (!il2cppBase) return { ok: false, error: 'no il2cppBase' };

    globalThis._pendingSkill = skillId | 0;
    if (globalThis._skillHookOn) return { ok: true, queued: skillId | 0 };

    try {
        var playerMainUpdate = il2cppBase.add(0xE42B4C);
        var doSkillFn = new NativeFunction(il2cppBase.add(0xE4969C), 'bool', ['pointer', 'int']);

        Interceptor.attach(playerMainUpdate, {
            onEnter: function() {
                var sid = globalThis._pendingSkill;
                if (sid === null || sid === undefined) return;
                globalThis._pendingSkill = null;
                try {
                    var r = doSkillFn(_playerMainInstance, sid);
                    globalThis._skillLastFire = 'ok DoSkill(' + sid + ')=' + r;
                } catch (e) {
                    globalThis._skillLastFire = 'err ' + e;
                }
            }
        });
        globalThis._skillHookOn = true;
        return { ok: true, hooked: true };
    } catch (e) {
        return { ok: false, error: '' + e };
    }
};

rpc.exports.skillLastFire = function() {
    return { fire: globalThis._skillLastFire || '(chua ban)' };
};

rpc.exports.doSkillDefaultHooked = function(skillId) {
    // Basic attack is mapped to DoSkill(skillId) natively
    return rpc.exports.doSkillHooked(skillId || 1);
};

rpc.exports.defLast = function() {
    return { last: globalThis._skillLastFire || '(chua)' };
};

rpc.exports.attackPlayerHooked = function(cid, skillId, isPhysic, dismount) {
    var pmRes = readPlayerMainDirect();
    if (!pmRes.ok || !_playerMainInstance) return { ok: false, error: 'no PlayerMain' };
    if (!il2cppBase) return { ok: false, error: 'no il2cppBase' };

    try {
        // Switch horse if dismount is requested
        if (dismount) {
            var isHorseEquippedFn = new NativeFunction(il2cppBase.add(0xE46220), 'bool', ['pointer']);
            var playerSwitchHorseFn = new NativeFunction(il2cppBase.add(0xE493F4), 'void', ['pointer']);
            if (isHorseEquippedFn(_playerMainInstance)) {
                playerSwitchHorseFn(_playerMainInstance);
            }
        }
        
        // Execute skill targeting active opponent
        return rpc.exports.doSkillHooked(skillId);
    } catch (e) {
        return { ok: false, error: 'Attack player failed: ' + e };
    }
};

rpc.exports.pkLast = function() {
    return { last: globalThis._skillLastFire || '(chua)' };
};

// ══ rpc/ui-control.js ══
// frida-scripts/rpc/ui-control.js — UI control RPCs (bridge-free)

rpc.exports.closeDialogPopups = function() {
    var pmRes = readPlayerMainDirect();
    if (!pmRes.ok || !_playerMainInstance) return { ok: false, error: 'no PlayerMain' };
    if (!il2cppBase) return { ok: false, error: 'no il2cppBase' };

    try {
        var closeNpcDialogFn = new NativeFunction(il2cppBase.add(0xE458F4), 'void', ['pointer']);
        var closeNpcShopFn = new NativeFunction(il2cppBase.add(0xE4535C), 'void', ['pointer']);
        var closeBagarateFn = new NativeFunction(il2cppBase.add(0xE45104), 'void', ['pointer']);
        var closeStorageBoxFn = new NativeFunction(il2cppBase.add(0xE44B8C), 'void', ['pointer']);

        closeNpcDialogFn(_playerMainInstance);
        closeNpcShopFn(_playerMainInstance);
        closeBagarateFn(_playerMainInstance);
        closeStorageBoxFn(_playerMainInstance);

        globalThis._closePopupResult = { closed: { dialog: 1, shop: 1, bag: 1, storage: 1 }, found: {}, ts: Date.now() };
        return { ok: true, closed: true };
    } catch (e) {
        return { ok: false, error: 'Close dialogs native failed: ' + e };
    }
};

rpc.exports.closePopupResult = function() {
    return { res: globalThis._closePopupResult || null, pending: 0 };
};

rpc.exports.sortBagItems = function() {
    return { ok: false, error: 'Sort bag needs bridge (disabled for stability)' };
};

rpc.exports.sortResult = function() { return { res: null }; };

rpc.exports.equipHooked = function(idx) {
    return { ok: false, error: 'Equip item needs bridge (disabled for stability)' };
};

rpc.exports.equipLastFire = function() { return { fire: '(disabled)' }; };

rpc.exports.shopOpenLog = function() { return { log: globalThis._shopOpenLog || [] }; };

// ══ rpc/diagnostics.js ══
// frida-scripts/rpc/diagnostics.js — Diagnostic RPC exports

rpc.exports.enumActiveUi = function() {
    if (typeof Il2Cpp === 'undefined') return { ok: false, error: 'no il2cpp' };
    return Il2Cpp.perform(function () {
        try {
            var img = Il2Cpp.domain.assembly('Assembly-CSharp').image;
            var Res = Il2Cpp.domain.assembly('UnityEngine.CoreModule').image.class('UnityEngine.Resources');
            var findM = Res.method('FindObjectsOfTypeAll', 1);
            var pat = /(dialog|npc|box|pc|select|confirm|award|quest|give|popup|menu|notice|reward|task|rank|hang|xep|view|panel|board|list|window|content|info|datau|activ|tong|standard|trade|input|detail|frame|chain|combo|serial|continuous)/i;
            var active = {};
            var classes = img.classes;
            for (var i = 0; i < classes.length; i++) {
                var k = classes[i]; var nm = k.name || '';
                if (!pat.test(nm)) continue;
                try {
                    var arr = findM.invoke(k.type.object);
                    var total = (arr && arr.length) ? arr.length : 0;
                    if (!total) continue;
                    var act = 0;
                    for (var j = 0; j < total; j++) {
                        try {
                            var o = arr.get(j);
                            var go = o.method('get_gameObject').invoke();
                            if (go.method('get_activeInHierarchy').invoke()) act++;
                        } catch (e) {}
                    }
                    if (act > 0) active[nm] = total + '/' + act;
                } catch (e) {}
            }
            return { ok: true, active: active };
        } catch (e) { return { ok: false, error: '' + e }; }
    });
};

rpc.exports.captureGoto = function() {
    if (typeof Il2Cpp === 'undefined') return { ok: false, error: 'no il2cpp' };
    if (globalThis._gotoCapOn) return { ok: true, already: true };
    globalThis._gotoLog = [];
    return Il2Cpp.perform(function () {
        var img = Il2Cpp.domain.assembly("Assembly-CSharp").image;
        var pm = img.class("PlayerMain");
        var hooked = [];
        function hookM(name, cnt, nargs) {
            try {
                var m = pm.method(name, cnt);
                if (!m || !m.virtualAddress || m.virtualAddress.isNull()) return;
                Interceptor.attach(m.virtualAddress, {
                    onEnter: function (a) {
                        var rec = { m: name + '/' + cnt, ts: Date.now(), args: [] };
                        for (var i = 1; i <= nargs; i++) {
                            try { rec.args.push(a[i].isNull() ? 'NULL' : a[i].toInt32()); }
                            catch (e) { rec.args.push('?'); }
                        }
                        globalThis._gotoLog.push(rec);
                        if (globalThis._gotoLog.length > 30) globalThis._gotoLog.shift();
                    }
                });
                hooked.push(name + '/' + cnt);
            } catch (e) {}
        }
        hookM("GotoFindingPath", 6, 6);
        hookM("GotoFindingPathOnVector", 1, 1);
        hookM("ProtocolGotoPosition", 1, 1);
        hookM("GotoAndPickTargetObject", 1, 1);
        hookM("GotoNpc", 2, 2);
        globalThis._gotoCapOn = true;
        return { ok: true, hooked: hooked };
    });
};

rpc.exports.lastGotoArgs = function() { return { log: globalThis._gotoLog || [] }; };

rpc.exports.listMethods = function(className, filter) {
    if (typeof Il2Cpp === 'undefined') return { ok: false, error: 'no il2cpp' };
    return Il2Cpp.perform(function () {
        try {
            var img = Il2Cpp.domain.assembly("Assembly-CSharp").image;
            var k = img.class(className);
            if (!k) return { ok: false, error: 'no class ' + className };
            var out = [], ms = k.methods, f = (filter || '').toLowerCase();
            for (var i = 0; i < ms.length; i++) {
                var n = ms[i].name;
                if (!f || n.toLowerCase().indexOf(f) !== -1) {
                    var pc = 0; try { pc = ms[i].parameterCount; } catch (e) {}
                    out.push(n + "/" + pc);
                }
            }
            return { ok: true, methods: out };
        } catch (e) { return { ok: false, error: '' + e }; }
    });
};

// ══ ready.js ══
// frida-scripts/ready.js — Ready signal: notify host that all hooks are installed

(function sendReadySignal() {
    send({
        type: 'ready',
        hooks: {
            connect: true,
            recv: true,
            send: true,
            nativeRead: !!nativeReadPtr,
            readSource: readSource,
            nativeWrite: !!nativeWritePtr,
            writeSource: writeSource,
        },
        ssl: {
            readOk: _sslReadOk,
            writeOk: _sslWriteOk,
            writeFn: !!_sslWriteFn,
            sslObj: _sslObj ? _sslObj.toString() : null,
        }
    });
})();

// ══ Bot Ready ══
send({ type: "bot_ready", exports: Object.keys(rpc.exports), timestamp: Date.now() });