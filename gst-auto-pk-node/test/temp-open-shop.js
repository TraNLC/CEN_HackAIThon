
        var libc = Process.findModuleByName('libc.so');
        var nativeWrite = new NativeFunction(libc.findExportByName('write'), 'int', ['int', 'pointer', 'int']);

        var _charManagerClass = null;
        
        function getNearbyShops() {
            var pattern = '43 68 61 72 4d 61 6e 61 67 65 72'; // "CharManager"
            var maps = File.readAllText('/proc/self/maps').split('\n');
            var metaRange = null;
            for (var i = 0; i < maps.length; i++) {
                if (maps[i].indexOf('global-metadata.dat') !== -1) {
                    var parts = maps[i].split(' ')[0].split('-');
                    metaRange = { base: ptr('0x' + parts[0]), size: parseInt('0x' + parts[1]) - parseInt('0x' + parts[0]) };
                    break;
                }
            }
            if (!metaRange) throw new Error('global-metadata.dat not found');
            
            var results = Memory.scanSync(metaRange.base, metaRange.size, pattern);
            var nameStrAddr = null;
            for (var rIdx = 0; rIdx < results.length; rIdx++) {
                if (results[rIdx].address.readUtf8String() === "CharManager") {
                    nameStrAddr = results[rIdx].address;
                    break;
                }
            }
            if (!nameStrAddr) throw new Error('Exact "CharManager" string not found');
            
            var allRanges = Process.enumerateRanges({ protection: 'rw-', coalesce: true });
            var hex = nameStrAddr.toString(16);
            while (hex.length < 16) hex = '0' + hex;
            var parts = [];
            for (var j = 14; j >= 0; j -= 2) parts.push(hex.substring(j, j + 2));
            var ptrPattern = parts.join(' ');
            
            for (var k = 0; k < allRanges.length; k++) {
                try {
                    var matches = Memory.scanSync(allRanges[k].base, allRanges[k].size, ptrPattern);
                    for (var m = 0; m < matches.length; m++) {
                        var cand = matches[m].address.sub(0x10);
                        try {
                            if (cand.add(0x10).readPointer().toString() === nameStrAddr.toString()) {
                                _charManagerClass = cand;
                                break;
                            }
                        } catch(e) {}
                    }
                } catch(e) {}
                if (_charManagerClass) break;
            }
            
            var staticFields = _charManagerClass.add(0xB8).readPointer();
            if (staticFields.isNull()) throw new Error('CharManager static fields is null');
            var charManagerInstance = staticFields.readPointer();
            if (charManagerInstance.isNull()) throw new Error('CharManager.instance is null');
            
            var salesmansDict = charManagerInstance.add(0x58).readPointer();
            var shops = [];
            if (!salesmansDict.isNull()) {
                var entriesArray = salesmansDict.add(0x18).readPointer();
                if (!entriesArray.isNull()) {
                    var count = entriesArray.add(0x18).sub(4).readU32();
                    var maxLength = entriesArray.add(0x18).readU32();
                    var found = 0;
                    for (var idx = 0; idx < maxLength && found < count; idx++) {
                        try {
                            var entryAddr = entriesArray.add(0x20).add(idx * 24);
                            var valuePtr = entryAddr.add(16).readPointer();
                            if (!valuePtr.isNull() && parseInt(valuePtr.toString()) > 0x10000) {
                                var dataPtr = valuePtr.add(0x30).readPointer();
                                if (!dataPtr.isNull() && parseInt(dataPtr.toString()) > 0x10000) {
                                    var cidPtr = dataPtr.add(0x10).readPointer();
                                    if (!cidPtr.isNull() && parseInt(cidPtr.toString()) > 0x10000) {
                                        var cidLen = cidPtr.add(0x10).readInt();
                                        if (cidLen > 0 && cidLen < 100) {
                                            var cid = cidPtr.add(0x14).readUtf16String(cidLen);
                                            shops.push({ cid: cid });
                                            found++;
                                        }
                                    }
                                }
                            }
                        } catch(e) {}
                    }
                }
            }
            return shops;
        }

        function doOpenShop(targetCid) {
            try {
                if (!targetCid) {
                    var shops = getNearbyShops();
                    if (shops.length === 0) {
                        send({ type: 'result', data: { ok: false, error: "No shops found nearby. Try passing CID manually e.g. node test-open-shop.js 10819" } });
                        return;
                    }
                    targetCid = shops[0].cid;
                }
                
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
                if (gameFd === -1) {
                    send({ type: 'result', data: { ok: false, error: "No TCP game socket found" } });
                    return;
                }
                
                var str = "salesman." + targetCid + ".0";
                var strLen = str.length;
                var payloadLen = 2 + strLen;
                
                var buf = Memory.alloc(6 + payloadLen);
                buf.writeU32(payloadLen);
                buf.add(4).writeU16(204);
                buf.add(6).writeU8(0x0A);
                buf.add(7).writeU8(strLen);
                buf.add(8).writeUtf8String(str);
                
                var ret = nativeWrite(gameFd, buf, 6 + payloadLen);
                
                // 4. Trigger the UI popup using remoteNpcDialogue
                var il2cpp = Process.findModuleByName("libil2cpp.so");
                var talkFnAddr = il2cpp.base.add(0xE45040);
                var fn_string_new = il2cpp.findExportByName('il2cpp_string_new');
                
                var get_domain = new NativeFunction(il2cpp.findExportByName("il2cpp_domain_get"), "pointer", []);
                var attach = new NativeFunction(il2cpp.findExportByName("il2cpp_thread_attach"), "pointer", ["pointer"]);
                attach(get_domain());
                
                var talkFn = new NativeFunction(talkFnAddr, 'void', ['pointer', 'pointer', 'pointer']);
                var str_new = new NativeFunction(fn_string_new, 'pointer', ['pointer']);
                
                var worldPtr = charManagerInstance.add(0x20).readPointer();
                var playerMainPtr = worldPtr.add(0x40).readPointer();
                
                var utf8NpcId = Memory.allocUtf8String(targetCid);
                var csNpcId = str_new(utf8NpcId);
                
                talkFn(playerMainPtr, csNpcId, ptr("0"));
                
                send({ type: 'result', data: { ok: true, sentBytes: ret, cid: targetCid, fd: gameFd, payload: str, uiTriggered: true } });
            } catch(e) {
                send({ type: 'result', data: { ok: false, error: e.message } });
            }
        };
        
        doOpenShop('10819');
    