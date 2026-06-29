
        var libc = Process.findModuleByName('libc.so');
        var nativeWrite = new NativeFunction(libc.findExportByName('write'), 'int', ['int', 'pointer', 'int']);

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
                                return klass;
                            }
                        } catch(e) {}
                    }
                } catch(e) {}
            }
            return null;
        }

        function getPopUpCanvasInstance() {
            var klass = findClassByName("PopUpCanvas");
            if (!klass) return null;
            var staticFields = klass.add(0xB8).readPointer();
            if (staticFields.isNull()) return null;
            return staticFields.readPointer();
        }

        function testReadItems(cid) {
            try {
                // 1. Send Packet
                var gameFd = -1;
                for(var i=0; i<200; i++) {
                    try {
                        var type = Socket.type(i);
                        if (type === 'tcp' || type === 'tcp6') {
                            var peer = Socket.peerAddress(i);
                            if (peer.port !== 80 && peer.port !== 443 && peer.port !== 27042) {
                                gameFd = i;
                                break;
                            }
                        }
                    } catch(e){}
                }
                if (gameFd === -1) return { ok: false, error: "No TCP socket" };
                
                var str = "salesman." + cid + ".0";
                var strLen = str.length;
                var payloadLen = 2 + strLen;
                var buf = Memory.alloc(6 + payloadLen);
                buf.writeU32(payloadLen);
                buf.add(4).writeU16(204);
                buf.add(6).writeU8(0x0A);
                buf.add(7).writeU8(strLen);
                buf.add(8).writeUtf8String(str);
                nativeWrite(gameFd, buf, 6 + payloadLen);
                
                send({ log: "Packet sent! Waiting 1s for server response..." });
                
                // 2. Wait and Read Memory
                setTimeout(function() {
                    try {
                        var popUp = getPopUpCanvasInstance();
                        if (!popUp || popUp.isNull()) {
                            send({ type: 'result', data: { ok: false, error: "PopUpCanvas not found" } });
                            return;
                        }
                        var playerOtherStall = popUp.add(0xA8).readPointer();
                        if (playerOtherStall.isNull()) {
                            send({ type: 'result', data: { ok: false, error: "playerOtherStall is null. UI might need to be open once." } });
                            return;
                        }
                        
                        var currentStall = playerOtherStall.add(0xA0).readPointer();
                        if (currentStall.isNull()) {
                            send({ type: 'result', data: { ok: false, error: "currentStall is null. Data not populated!" } });
                            return;
                        }
                        
                        var titlePtr = currentStall.add(0x18).readPointer();
                        var title = titlePtr.isNull() ? '' : titlePtr.add(0x14).readUtf16String();
                        
                        var il2cppBase = getIl2CppBase();
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
                                        
                                        if (!itemPtr.isNull()) {
                                            var namePtr = GetItemName(itemPtr, 0, 0, ptr(0));
                                            var itemName = namePtr.isNull() ? 'Unknown' : namePtr.add(0x14).readUtf16String();
                                            items.push({ name: itemName, price: money });
                                        }
                                    }
                                    curr = curr.add(0x18).readPointer();
                                }
                            }
                        }
                        
                        send({ type: 'result', data: { ok: true, shopName: title, itemCount: items.length, items: items } });
                    } catch (e) {
                        send({ type: 'result', data: { ok: false, error: "Memory read error: " + e.message } });
                    }
                }, 1000);
            } catch(e) {
                send({ type: 'result', data: { ok: false, error: e.message } });
            }
        };
        testReadItems('10819');
    