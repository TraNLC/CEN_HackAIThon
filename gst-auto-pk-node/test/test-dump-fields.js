const { FridaSession } = require('../src/frida-session');
const config = require('../config');
const fs = require('fs');

async function run() {
    console.log("Connecting to device...");
    const frida = new FridaSession(null, config.GAME_PACKAGE);
    await frida.connect();
    
    console.log("Dumping class fields using IL2CPP native exports...");

    const scriptCode = `
        function getIl2CppBase() {
            var mod = Process.findModuleByName('libil2cpp.so');
            if (mod) return mod.base;
            var lines = File.readAllText('/proc/self/maps').split('\\n');
            for (var i = 0; i < lines.length; i++) {
                if (lines[i].indexOf('libil2cpp.so') !== -1 && lines[i].indexOf('r-xp') !== -1) {
                    return ptr('0x' + lines[i].trim().split(/\\s+/)[0].split('-')[0]);
                }
            }
            return null;
        }

        function findElfExport(base, targetName) {
            if (!base || base.isNull()) return ptr(0);
            try {
                var exp = Module.findExportByName(null, targetName);
                if (exp && !exp.isNull()) {
                    return exp;
                }
            } catch(e) {}
            var lines = File.readAllText('/proc/self/maps').split('\\n');
            for (var i = 0; i < lines.length; i++) {
                var line = lines[i];
                if (line.indexOf('libil2cpp.so') !== -1 && line.indexOf('r--p') !== -1) {
                    var parts = line.trim().split(/\\s+/);
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
                if (p_type === 2) { 
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
                if (d_tag === 0) break;
                if (d_tag === 6) symtab = d_val;
                if (d_tag === 5) strtab = d_val;
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
                    break;
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
        
        // Find PlayerMain class the old fashioned way (via global-metadata strings)
        function findClassByName(className) {
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

        function testDumpFields() {
            try {
                var il2cpp = getIl2CppBase();
                var get_fields_ptr = findElfExport(il2cpp, 'il2cpp_class_get_fields');
                if (get_fields_ptr.isNull()) {
                    send({ type: 'result', data: { ok: false, error: 'il2cpp_class_get_fields not found in exports' } });
                    return;
                }
                var il2cpp_class_get_fields = new NativeFunction(get_fields_ptr, 'pointer', ['pointer', 'pointer']);
                var il2cpp_field_get_name = new NativeFunction(findElfExport(il2cpp, 'il2cpp_field_get_name'), 'pointer', ['pointer']);
                var il2cpp_field_get_offset = new NativeFunction(findElfExport(il2cpp, 'il2cpp_field_get_offset'), 'int', ['pointer']);
                var il2cpp_field_get_type = new NativeFunction(findElfExport(il2cpp, 'il2cpp_field_get_type'), 'pointer', ['pointer']);
                var il2cpp_type_get_name = new NativeFunction(findElfExport(il2cpp, 'il2cpp_type_get_name'), 'pointer', ['pointer']);
                
                function dumpClassFields(klass, name) {
                    var out = "Class: " + name + "\\n";
                    if (!klass || klass.isNull()) {
                        out += "  [NULL CLASS]\\n";
                        return out;
                    }
                    var iter = Memory.alloc(Process.pointerSize);
                    iter.writePointer(ptr(0));
                    var field;
                    while (!(field = il2cpp_class_get_fields(klass, iter)).isNull()) {
                        var fName = il2cpp_field_get_name(field).readUtf8String();
                        var fOff = il2cpp_field_get_offset(field);
                        var fType = il2cpp_field_get_type(field);
                        var tName = "unknown";
                        if (!fType.isNull()) {
                            var tNamePtr = il2cpp_type_get_name(fType);
                            if (!tNamePtr.isNull()) {
                                // sometimes memory isn't fully readable or it uses a custom allocator that causes readUtf8String to fail
                                try {
                                    tName = tNamePtr.readUtf8String();
                                } catch(e) {}
                            }
                        }
                        out += "  [0x" + fOff.toString(16) + "] " + fName + " : " + tName + "\\n";
                    }
                    return out;
                }

                var playerMainClass = findClassByName("PlayerMain");
                if (playerMainClass) {
                    send({ log: dumpClassFields(playerMainClass, "PlayerMain") });
                    
                    var staticFields = safeReadPointer(playerMainClass.add(0xB8));
                    if (staticFields) {
                        var instance = safeReadPointer(staticFields);
                        if (instance) {
                            var npcPtr = safeReadPointer(instance.add(0x20)); // npcontroller
                            if (npcPtr) {
                                var npcClass = safeReadPointer(npcPtr); // first field is class
                                send({ log: dumpClassFields(npcClass, "NpcRes.Special (Controller)") });
                                
                                var charPtr = safeReadPointer(npcPtr.add(0xa0)); // character
                                if (!charPtr) {
                                    // if not 0xa0, try scanning fields for character
                                } else {
                                    var charClass = safeReadPointer(charPtr);
                                    send({ log: dumpClassFields(charClass, "Character") });
                                }
                            }
                        }
                    }
                }
                
                var bagarateClass = findClassByName("Bagarate");
                if (bagarateClass) {
                    send({ log: dumpClassFields(bagarateClass, "Bagarate") });
                } else {
                    send({ log: "Bagarate class not found via name search" });
                }
                
                var inventoryManager = findClassByName("InventoryManager");
                if (inventoryManager) {
                    send({ log: dumpClassFields(inventoryManager, "InventoryManager") });
                }
                var bagManager = findClassByName("BagManager");
                if (bagManager) {
                    send({ log: dumpClassFields(bagManager, "BagManager") });
                }
                var itemManager = findClassByName("ItemManager");
                if (itemManager) {
                    send({ log: dumpClassFields(itemManager, "ItemManager") });
                }

                send({ type: 'result', data: { ok: true } });
            } catch(e) {
                send({ type: 'result', data: { ok: false, error: e.message } });
            }
        }
        testDumpFields();
    `;
    
    fs.writeFileSync('test/temp-dump-fields.js', scriptCode);
    
    frida.onMessage(m => {
        if (m.type === 'result') {
            console.log("\\n=== FINAL RESULT ===");
            console.log(JSON.stringify(m.data, null, 2));
            process.exit(0);
        } else if (m.log) {
            console.log(m.log);
        }
    });

    await frida.loadScript('test/temp-dump-fields.js');
}

run().catch(console.error);
