
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
        
        function readUtf16StringSafely(ptr, length) {
            if (!ptr || ptr.isNull()) return null;
            try {
                return ptr.readUtf16String(length);
            } catch(e) {
                return null;
            }
        }

        function findClassByName(className) {
            var maps = File.readAllText('/proc/self/maps').split('\n');
            var metaRange = null;
            for (var i = 0; i < maps.length; i++) {
                if (maps[i].indexOf('global-metadata.dat') !== -1) {
                    var parts = maps[i].split(' ')[0].split('-');
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
                            return klass;
                        }
                    }
                } catch(e) {}
            }
            return null;
        }

        function extractItemData(itemPtr) {
            var itemData = { ptr: itemPtr.toString() };
            try {
                // Typical Il2Cpp string reading
                // Offset 0x18 could be name, but we don't know exact offsets for Item class.
                // Let's dump some pointers inside Item
                var itemClass = safeReadPointer(itemPtr);
                if (itemClass) {
                    var classNamePtr = safeReadPointer(itemClass.add(0x10));
                    if (classNamePtr) {
                        try {
                            itemData._className = classNamePtr.readUtf8String();
                        } catch(e) {}
                    }
                }
                
                // Scan fields in item looking for strings or integers
                for (var offset = 0x10; offset < 0x100; offset += Process.pointerSize) {
                    var val = safeReadPointer(itemPtr.add(offset));
                    if (val && !val.isNull()) {
                        // Check if it's a string
                        var len = -1;
                        try {
                            len = val.add(0x10).readS32();
                        } catch(e) {}
                        
                        if (len > 0 && len < 100) {
                            var str = readUtf16StringSafely(val.add(0x14), len);
                            if (str) {
                                itemData["string_0x" + offset.toString(16)] = str;
                            }
                        }
                    } else {
                        // check integer
                        try {
                            var iVal = itemPtr.add(offset).readS32();
                            if (iVal !== 0) {
                                itemData["int_0x" + offset.toString(16)] = iVal;
                            }
                        } catch(e) {}
                    }
                }
            } catch(e) {
                itemData.error = e.toString();
            }
            return itemData;
        }

        function testBagarate() {
            try {
                var playerMainClass = findClassByName("PlayerMain");
                if (!playerMainClass) {
                    send({ type: 'result', data: { ok: false, error: 'PlayerMain class not found' } });
                    return;
                }
                var staticFieldsPtr = safeReadPointer(playerMainClass.add(0xB8));
                var instance = safeReadPointer(staticFieldsPtr); // 0x0
                if (!instance) {
                    send({ type: 'result', data: { ok: false, error: 'PlayerMain.instance is null' } });
                    return;
                }
                
                var il2cppBase = null;
                try {
                    var mod = Process.findModuleByName('libil2cpp.so');
                    if (mod) il2cppBase = mod.base;
                } catch(e) {}
                
                if (!il2cppBase) {
                    var maps = File.readAllText('/proc/self/maps').split('\n');
                    for (var i = 0; i < maps.length; i++) {
                        var line = maps[i];
                        if (line.indexOf('libil2cpp.so') !== -1 && line.indexOf('r--p') !== -1) {
                            var parts = line.trim().split(/\s+/);
                            if (parts[2] === '00000000') {
                                il2cppBase = ptr('0x' + parts[0].split('-')[0]);
                                break;
                            }
                        }
                    }
                }
                
                if (!il2cppBase) {
                    send({ type: 'result', data: { ok: false, error: 'libil2cpp.so not found' } });
                    return;
                }
                
                // RVA: 0x7013A0 -> GetBagarateItemCount
                var GetBagarateItemCount = new NativeFunction(il2cppBase.add(0x7013A0), 'int', ['pointer']);
                var count = GetBagarateItemCount(instance);
                send({ log: "GetBagarateItemCount returned: " + count });
                
                // RVA: 0x70168C -> GetBagarateMoney
                var GetBagarateMoney = new NativeFunction(il2cppBase.add(0x70168C), 'int64', ['pointer']);
                var money = GetBagarateMoney(instance);
                send({ log: "GetBagarateMoney returned: " + money });
                
                // Let's also try GetAllGameItems: 0x6FEA20
                var GetAllGameItems = new NativeFunction(il2cppBase.add(0x6FEA20), 'pointer', ['pointer']);
                var allItemsDict = GetAllGameItems(instance);
                send({ log: "GetAllGameItems returned dictionary: " + allItemsDict });
                
                // ConcurrentDictionary<int, Item> internal structure usually has a m_tables field
                // If we want to iterate it we can try to find the array of nodes.
                
                send({ type: 'result', data: { ok: true, count: count, money: money.toString() } });
            } catch(e) {
                send({ type: 'result', data: { ok: false, error: e.message } });
            }
        }
        testBagarate();
    