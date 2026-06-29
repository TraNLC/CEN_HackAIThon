
        function getIl2CppBase() {
            var mod = Process.findModuleByName('libil2cpp.so');
            if (mod) return mod.base;
            var base = null;
            var lines = File.readAllText('/proc/self/maps').split('\n');
            for (var i = 0; i < lines.length; i++) {
                var line = lines[i];
                if (line.indexOf('libil2cpp.so') !== -1 && (line.indexOf('r-xp') !== -1 || line.indexOf('r--p') !== -1)) {
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
        
        function getPopUpCanvasInstance() {
            var klass = findClassByName("PopUpCanvas");
            if (!klass) return null;
            var staticFields = safeReadPointer(klass.add(0xB8));
            if (!staticFields) return null;
            return safeReadPointer(staticFields);
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
        
        function testReadBag() {
            try {
                var bagarateClass = findClassByName("Bagarate");
                if (!bagarateClass || bagarateClass.isNull()) {
                    send({ type: 'result', data: { ok: false, error: "Bagarate not found" } });
                    return;
                }
                
                var staticFields = safeReadPointer(bagarateClass.add(0xB8));
                if (!staticFields) {
                    send({ type: 'result', data: { ok: false, error: "Bagarate static fields not found" } });
                    return;
                }
                
                var instance = safeReadPointer(staticFields);
                if (!instance) {
                    send({ type: 'result', data: { ok: false, error: "Bagarate instance not found" } });
                    return;
                }
                
                send({ type: 'result', data: { ok: true, instance: instance.toString() } });
            } catch(e) {
                send({ type: 'result', data: { ok: false, error: e.message } });
            }
        }
        testReadBag();
    