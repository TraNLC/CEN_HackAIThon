// frida-scripts/rpc/core/Il2CppUtils.js -- Utilities for IL2CPP memory and native exports

function findElfExport(base, targetName) {
    if (!base || base.isNull()) return ptr(0);
    
    // Try built-in resolver globally first
    try {
        var exp = Module.findExportByName(null, targetName);
        if (exp && !exp.isNull()) {
            return exp;
        }
    } catch(e) {
        // Module.findExportByName might be unsupported in this older frida/duktape
    }
    
    // Fallback to manual parsing if completely stripped
    var mod = null;
    var lines = File.readAllText('/proc/self/maps').split('\n');
    for (var i = 0; i < lines.length; i++) {
        var line = lines[i];
        if (line.indexOf('libil2cpp.so') !== -1 && line.indexOf('r--p') !== -1) {
            var parts = line.trim().split(/\s+/);
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
    
    // Read class: 1 = 32-bit, 2 = 64-bit
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
        if (p_type === 2) { // PT_DYNAMIC
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
        
        if (d_tag === 0) break; // DT_NULL
        if (d_tag === 6) symtab = d_val; // DT_SYMTAB
        if (d_tag === 5) strtab = d_val; // DT_STRTAB
        
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
            break; // End of symtab or unreadable memory
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
