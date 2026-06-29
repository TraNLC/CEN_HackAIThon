
        function scanBag() {
            var pmi = typeof _playerMainInstance !== 'undefined' ? _playerMainInstance : null;
            if (!pmi || pmi.isNull()) {
                setTimeout(scanBag, 1000);
                return;
            }
            
            try {
                var controllerPtr = pmi.add(0x20).readPointer();
                var character = controllerPtr.add(0xa0).readPointer();
                
                var GetItemName = new NativeFunction(il2cppBase.add(0xFEB4A0), 'pointer', ['pointer', 'int', 'bool', 'pointer']);

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

                var foundBags = [];
                for (var offset = 0x10; offset < 0x500; offset += 8) {
                    var fieldPtr = safeReadPointer(character.add(offset));
                    if (!fieldPtr) continue;
                    
                    var itemsArray = safeReadPointer(fieldPtr.add(0x10));
                    var size = safeReadU32(fieldPtr.add(0x18));
                    
                    if (itemsArray && size > 0 && size < 500) {
                        var maxLength = safeReadU32(itemsArray.add(0x18));
                        if (maxLength >= size && maxLength < 1000) {
                            var firstItem = safeReadPointer(itemsArray.add(0x20));
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
                    
                    var entriesArray = safeReadPointer(fieldPtr.add(0x18));
                    var count = safeReadU32(fieldPtr.add(0x20));
                    
                    if (entriesArray && count > 0 && count < 500) {
                        var dictMaxLength = safeReadU32(entriesArray.add(0x18));
                        if (dictMaxLength >= count && dictMaxLength < 1000) {
                            var firstValue = safeReadPointer(entriesArray.add(0x20).add(0x10));
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
        
        scanBag();
    