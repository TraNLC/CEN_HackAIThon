import struct
import sys

def parse_elf(filepath):
    with open(filepath, 'rb') as f:
        data = f.read()
    
    # Check ELF header
    if data[:4] != b'\x7fELF':
        print("Not an ELF file")
        return
        
    is_32bit = data[4] == 1
    endian = '<' if data[5] == 1 else '>'
    
    if is_32bit:
        header_fmt = endian + '16xHHIIIIIHHHHHH'
        e_type, e_machine, e_version, e_entry, e_phoff, e_shoff, e_flags, e_ehsize, e_phentsize, e_phnum, e_shentsize, e_shnum, e_shstrndx = struct.unpack_from(header_fmt, data)
        sh_fmt = endian + 'IIIIIIIIII'
        sh_size = 40
        sym_fmt = endian + 'IIIBBH'
        sym_size = 16
    else:
        header_fmt = endian + '16xHHIQQQIHHHHHH'
        e_type, e_machine, e_version, e_entry, e_phoff, e_shoff, e_flags, e_ehsize, e_phentsize, e_phnum, e_shentsize, e_shnum, e_shstrndx = struct.unpack_from(header_fmt, data)
        sh_fmt = endian + 'IIQQQQIIQQ'
        sh_size = 64
        sym_fmt = endian + 'IBBHQQ'
        sym_size = 24

    sections = []
    for i in range(e_shnum):
        sh_data = data[e_shoff + i * sh_size : e_shoff + (i+1) * sh_size]
        sh = struct.unpack(sh_fmt, sh_data)
        sections.append(sh)
        
    shstrtab_offset = sections[e_shstrndx][4] if is_32bit else sections[e_shstrndx][5]
    
    dynsym_sec = None
    dynstr_sec = None
    
    for sh in sections:
        sh_name_idx = sh[0]
        name_start = shstrtab_offset + sh_name_idx
        name_end = data.find(b'\0', name_start)
        name = data[name_start:name_end].decode('utf-8')
        
        if name == '.dynsym':
            dynsym_sec = sh
        elif name == '.dynstr':
            dynstr_sec = sh
            
    if not dynsym_sec or not dynstr_sec:
        print("Could not find .dynsym or .dynstr")
        return
        
    dynsym_offset = dynsym_sec[4] if is_32bit else dynsym_sec[5]
    dynsym_size = dynsym_sec[5] if is_32bit else dynsym_sec[6]
    dynstr_offset = dynstr_sec[4] if is_32bit else dynstr_sec[5]
    
    num_symbols = dynsym_size // sym_size
    targets = [
        "il2cpp_domain_get", "il2cpp_domain_get_assemblies", "il2cpp_assembly_get_image",
        "il2cpp_class_from_name", "il2cpp_class_get_field_from_name", "il2cpp_field_static_get_value",
        "il2cpp_object_get_class"
    ]
    
    for i in range(num_symbols):
        sym_data = data[dynsym_offset + i * sym_size : dynsym_offset + (i+1) * sym_size]
        sym = struct.unpack(sym_fmt, sym_data)
        st_name = sym[0]
        st_value = sym[1]
        
        if st_name == 0:
            continue
            
        name_start = dynstr_offset + st_name
        name_end = data.find(b'\0', name_start)
        name = data[name_start:name_end].decode('utf-8')
        
        if name in targets:
            print(f"{name}: 0x{st_value:X}")

parse_elf('data/output/libil2cpp.so')
