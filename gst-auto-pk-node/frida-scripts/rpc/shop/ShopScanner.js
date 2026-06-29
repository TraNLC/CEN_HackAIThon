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
