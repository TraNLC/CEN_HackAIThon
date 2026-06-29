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
