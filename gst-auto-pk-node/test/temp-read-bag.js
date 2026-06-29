
        function getIl2CppBase() {
            var mod = Process.findModuleByName('libil2cpp.so');
            if (mod) return mod.base;
            var base = null;
            var lines = File.readAllText('/proc/self/maps').split('\n');
            for (var i = 0; i < lines.length; i++) {
                var line = lines[i];
                if (line.indexOf('libil2cpp.so') !== -1 && line.indexOf('r-xp') !== -1) {
                    var parts = line.trim().split(/\s+/);
                    base = ptr('0x' + parts[0].split('-')[0]);
                    break;
                }
            }
            return base;
        }

        // readPlayerMainDirect logic
        function readPlayerMainDirect() {
            try {
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
                    try {
                        var classMatches = Memory.scanSync(range.base, range.size, ptrPattern);
                        for (var mIdx = 0; mIdx < classMatches.length; mIdx++) {
                            var klass = classMatches[mIdx].address.sub(0x10);
                            try {
                                if (klass.add(0x10).readPointer().equals(nameStrAddr)) {
                                    var staticFields = klass.add(0xB8).readPointer();
                                    if (!staticFields.isNull()) {
                                        return staticFields.readPointer();
                                    }
                                }
                            } catch(e) {}
                        }
                    } catch(e) {}
                }
            } catch(e) {}
            return null;
        }

        function testReadBag() {
            try {
                var playerMainInstance = readPlayerMainDirect();
                if (!playerMainInstance || playerMainInstance.isNull()) {
                    send({ type: 'result', data: { ok: false, error: "PlayerMain instance not found" } });
                    return;
                }
                
                var npcontroller = playerMainInstance.add(0x20).readPointer();
                if (npcontroller.isNull()) {
                    send({ type: 'result', data: { ok: false, error: "npcontroller is null" } });
                    return;
                }
                
                var character = npcontroller.add(0xa0).readPointer();
                if (character.isNull()) {
                    send({ type: 'result', data: { ok: false, error: "character is null" } });
                    return;
                }
                
                var il2cppBase = getIl2CppBase();
                var GetItemName = new NativeFunction(il2cppBase.add(0xFEB4A0), 'pointer', ['pointer', 'int', 'bool', 'pointer']);
                
                var items = [];
                
                // Let's search memory around 'character' to find the bag container
                // Common offsets for bags/inventory in RPGs: arrays or dictionaries
                
                var money = character.add(0x48).readS64().toString();
                var storageMoney = character.add(0x110).readS64().toString();
                
                send({ log: "Money: " + money + ", Storage Money: " + storageMoney });
                
                // character memory dump to find pointers
                var ptrArray = [];
                for(var i=0; i<0x200; i+=8) {
                    try {
                        var p = character.add(i).readPointer();
                        if (!p.isNull() && parseInt(p.toString()) > 0x100000) {
                            ptrArray.push({ offset: i.toString(16), ptr: p });
                        }
                    } catch(e) {}
                }
                
                // Check each pointer to see if it's an array/list of items
                for(var i=0; i<ptrArray.length; i++) {
                    var obj = ptrArray[i].ptr;
                    try {
                        // Check if it's a List<T> or Dictionary<T>
                        var listPtr = obj.add(0x10).readPointer(); // internal array
                        if (listPtr.isNull() || parseInt(listPtr.toString()) <= 0x100000) continue;
                        
                        var count = obj.add(0x18).readU32(); // size
                        
                        if (count > 0 && count < 200) {
                            // Try to read first element safely
                            for(var j=0; j<Math.min(count, 5); j++) {
                                try {
                                    var elemPtr = listPtr.add(0x20 + j*8).readPointer();
                                    if (!elemPtr.isNull() && parseInt(elemPtr.toString()) > 0x100000) {
                                        // Could this be an item? Try to get its name
                                        try {
                                            var namePtr = GetItemName(elemPtr, 0, 0, ptr(0));
                                            if (!namePtr.isNull() && parseInt(namePtr.toString()) > 0x100000) {
                                                var itemName = namePtr.add(0x14).readUtf16String();
                                                items.push({ offset: ptrArray[i].offset, name: itemName, valid: true });
                                            }
                                        } catch(e) {}
                                    }
                                } catch(e) {}
                            }
                        }
                    } catch(e) {}
                }
                
                send({ type: 'result', data: { ok: true, money: money, storageMoney: storageMoney, foundItems: items } });
            } catch(e) {
                send({ type: 'result', data: { ok: false, error: e.message } });
            }
        };
        testReadBag();
    