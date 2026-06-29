const { FridaSession } = require('../src/frida-session');
const config = require('../config');

async function run() {
    console.log("Connecting to device...");
    const frida = new FridaSession(null, config.GAME_PACKAGE);
    await frida.connect();
    
    console.log("Scanning character fields for Lists/Dictionaries...");

    const scriptCode = `
        function getIl2CppBase() {
            var mod = Process.findModuleByName('libil2cpp.so');
            if (mod) return mod.base;
            var base = null;
            var lines = File.readAllText('/proc/self/maps').split('\\n');
            for (var i = 0; i < lines.length; i++) {
                var line = lines[i];
                if (line.indexOf('libil2cpp.so') !== -1 && (line.indexOf('r-xp') !== -1 || line.indexOf('r--p') !== -1)) {
                    var parts = line.trim().split(/\\s+/);
                    base = ptr('0x' + parts[0].split('-')[0]);
                    break;
                }
            }
            return base;
        }

        function safeReadPointer(ptr) {
            try {
                if (!ptr || ptr.isNull()) return null;
                var range = Process.findRangeByAddress(ptr);
                if (!range || range.protection.indexOf('r') === -1) return null;
                return ptr.readPointer();
            } catch(e) {
                return null;
            }
        }

        function safeReadU32(ptr) {
            try {
                if (!ptr || ptr.isNull()) return 0;
                var range = Process.findRangeByAddress(ptr);
                if (!range || range.protection.indexOf('r') === -1) return 0;
                return ptr.readU32();
            } catch(e) {
                return 0;
            }
        }

        // readPlayerMainDirect logic
        function readPlayerMainDirect() {
            try {
                var maps = File.readAllText('/proc/self/maps').split('\\n');
                var metaRange = null;
                for (var i = 0; i < maps.length; i++) {
                    if (maps[i].indexOf('global-metadata.dat') !== -1) {
                        var parts = maps[i].split(' ')[0].split('-');
                        metaRange = { base: ptr('0x' + parts[0]), size: parseInt('0x' + parts[1]) - parseInt('0x' + parts[0]) };
                        break;
                    }
                }
                if (!metaRange) return null;
                
                var className = "PlayerMain";
                var strHex = [];
                for (var i = 0; i < className.length; i++) {
                    var hex = className.charCodeAt(i).toString(16);
                    strHex.push(hex.length === 1 ? '0' + hex : hex);
                }
                var pattern = strHex.join(' ');
                var results = Memory.scanSync(metaRange.base, metaRange.size, pattern);
                var nameStrAddr = null;
                for (var rIdx = 0; rIdx < results.length; rIdx++) {
                    var p = safeReadPointer(results[rIdx].address);
                    if (p) {
                        try {
                            if (results[rIdx].address.readUtf8String() === className) {
                                nameStrAddr = results[rIdx].address;
                                break;
                            }
                        } catch(e) {}
                    }
                }
                if (!nameStrAddr) return null;
                
                var rangesR = Process.enumerateRanges({ protection: 'r--', coalesce: true });
                var rangesRW = Process.enumerateRanges({ protection: 'rw-', coalesce: true });
                var allRanges = rangesR.concat(rangesRW);
                
                var hex = nameStrAddr.toString(16);
                while (hex.length < 16) hex = '0' + hex;
                var parts = [];
                for (var j = 14; j >= 0; j -= 2) parts.push(hex.substring(j, j + 2));
                var ptrPattern = parts.join(' ');
                
                for (var k = 0; k < allRanges.length; k++) {
                    var range = allRanges[k];
                    try {
                        var classMatches = Memory.scanSync(range.base, range.size, ptrPattern);
                        for (var mIdx = 0; mIdx < classMatches.length; mIdx++) {
                            var klass = classMatches[mIdx].address.sub(0x10);
                            var checkPtr = safeReadPointer(klass.add(0x10));
                            if (checkPtr && checkPtr.equals(nameStrAddr)) {
                                var staticFields = safeReadPointer(klass.add(0xB8));
                                if (staticFields) {
                                    return safeReadPointer(staticFields);
                                }
                            }
                        }
                    } catch(e) {}
                }
            } catch(e) {}
            return null;
        }

        function testScanBag() {
            try {
                var il2cppBase = getIl2CppBase();
                if (!il2cppBase) {
                    send({ type: 'result', data: { ok: false, error: "No il2cppBase" } });
                    return;
                }
                
                var GetItemName = new NativeFunction(il2cppBase.add(0xFEB4A0), 'pointer', ['pointer', 'int', 'bool', 'pointer']);

                var playerMainInstance = readPlayerMainDirect();
                if (!playerMainInstance) {
                    send({ type: 'result', data: { ok: false, error: "PlayerMain instance not found" } });
                    return;
                }

                var controllerPtr = safeReadPointer(playerMainInstance.add(0x20));
                if (!controllerPtr) {
                    send({ type: 'result', data: { ok: false, error: "Controller pointer not found" } });
                    return;
                }
                
                send({ log: "Found Controller! Scanning controller for bags..." });
                
                var foundBags = [];
                
                // We will scan controllerPtr
                for (var offset = 0x10; offset < 0x500; offset += 8) {
                    var fieldPtr = safeReadPointer(controllerPtr.add(offset));
                    if (!fieldPtr) continue;
                    
                    // Also scan character struct specifically if controller is not enough
                    var charPtr = safeReadPointer(controllerPtr.add(0xa0));
                    if (charPtr) {
                        for (var cOffset = 0x10; cOffset < 0x500; cOffset += 8) {
                            var charField = safeReadPointer(charPtr.add(cOffset));
                            if (!charField) continue;
                            checkField(charField, 'Character+' + cOffset.toString(16));
                        }
                    }
                    
                    checkField(fieldPtr, 'Controller+' + offset.toString(16));
                }

                function checkField(fieldPtr, path) {
                    
                    // Check if it's a List<T>
                    var itemsArray = safeReadPointer(fieldPtr.add(0x10));
                    var size = safeReadU32(fieldPtr.add(0x18));
                    
                    if (itemsArray && size > 0 && size < 500) {
                        var maxLength = safeReadU32(itemsArray.add(0x18));
                        if (maxLength >= size && maxLength < 1000) {
                            // Possible List!
                            var firstItem = safeReadPointer(itemsArray.add(0x20)); // offset 0 in array
                            if (firstItem) {
                                try {
                                    var namePtr = GetItemName(firstItem, 0, 0, ptr(0));
                                    if (namePtr && !namePtr.isNull()) {
                                        var itemName = namePtr.readUtf16String();
                                        if (itemName && itemName.length > 0 && itemName.length < 50) {
                                            foundBags.push({
                                                type: 'List',
                                                offset: offset.toString(16),
                                                size: size,
                                                firstItemName: itemName
                                            });
                                        }
                                    }
                                } catch(e) {}
                            }
                        }
                    }
                    
                    // Check if it's a Dictionary<K,V>
                    var entriesArray = safeReadPointer(fieldPtr.add(0x18));
                    var count = safeReadU32(fieldPtr.add(0x20));
                    
                    if (entriesArray && count > 0 && count < 500) {
                        var dictMaxLength = safeReadU32(entriesArray.add(0x18));
                        if (dictMaxLength >= count && dictMaxLength < 1000) {
                            var firstValue = safeReadPointer(entriesArray.add(0x20).add(0x10)); // value is at offset 0x10 in struct
                            if (firstValue) {
                                try {
                                    var namePtr = GetItemName(firstValue, 0, 0, ptr(0));
                                    if (namePtr && !namePtr.isNull()) {
                                        var itemName = namePtr.readUtf16String();
                                        if (itemName && itemName.length > 0 && itemName.length < 50) {
                                            foundBags.push({
                                                type: 'Dictionary',
                                                offset: offset.toString(16),
                                                size: count,
                                                firstItemName: itemName
                                            });
                                        }
                                    }
                                } catch(e) {}
                            }
                        }
                    }
                }
                
                send({ type: 'result', data: { ok: true, bags: foundBags } });
            } catch(e) {
                send({ type: 'result', data: { ok: false, error: e.message } });
            }
        }
        testScanBag();
    `;
    
    const fs = require('fs');
    fs.writeFileSync('test/test-scan-bag.js', scriptCode);
    
    frida.onMessage(m => {
        if (m.type === 'result') {
            console.log("\\n=== FINAL RESULT ===");
            console.log(JSON.stringify(m.data, null, 2));
            process.exit(0);
        } else if (m.type === 'log') {
            console.log("[Log] " + m.log);
        }
    });

    await frida.loadScript('test/test-scan-bag.js');
}

run().catch(console.error);
