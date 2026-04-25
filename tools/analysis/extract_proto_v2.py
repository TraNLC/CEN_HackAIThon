"""
extract_proto_v2.py — Accurate protobuf extraction using FieldNumber constants
"""
import re
from pathlib import Path
from collections import OrderedDict

DUMP = Path(r"e:\tool\sample-test\vltk1-re\Il2CppDumper-net7-win-v6.7.46\dump.cs")
OUT = Path(r"e:\tool\sample-test\vltk1-re\proto\vltk1_protocol.py")

print(f"Reading dump.cs...")
lines = DUMP.read_text(encoding='utf-8').splitlines()
print(f"Lines: {len(lines)}")

# ==================== 1. EXTRACT ENUMS ====================
# Pattern: public const MSCode/Id NAME = VALUE;
ms_opcodes = {}
gs_opcodes = {}

# Find MSCode enum
in_mscode = False
in_gsid = False
for line in lines:
    s = line.strip()
    if 'public enum MSCode' in s:
        in_mscode = True; continue
    if 'public enum Id ' in s and 'TypeDefIndex' in s:
        in_gsid = True; continue
    if in_mscode and s == '}':
        in_mscode = False; continue
    if in_gsid and s == '}':
        in_gsid = False; continue
    
    if in_mscode:
        m = re.search(r'public const MSCode \w+ = (\d+);', s)
        if m:
            # Get name from [OriginalName] on previous line or from const name
            name_m = re.search(r'public const MSCode (\w+)', s)
            if name_m and name_m.group(1) != 'value__':
                ms_opcodes[int(m.group(1))] = name_m.group(1)
    
    if in_gsid:
        m = re.search(r'public const Id (\w+) = (\d+);', s)
        if m and m.group(1) != 'value__':
            # Remove 'E' prefix: EPlayerLoginRequest -> ePlayerLoginRequest
            name = m.group(1)
            if name.startswith('E') and len(name) > 1:
                name = 'e' + name[1:]
            gs_opcodes[int(m.group(2))] = name

print(f"MS opcodes: {len(ms_opcodes)}")
print(f"GS opcodes: {len(gs_opcodes)}")

# ==================== 2. EXTRACT MESSAGES WITH FIELD NUMBERS ====================
# In protobuf C# codegen: public const int XxxFieldNumber = N;
# And field: private TYPE xxx_; // 0xOFFSET

TYPE_MAP = {
    'int': 'int32', 'uint': 'uint32', 'long': 'int64', 'ulong': 'uint64',
    'float': 'float', 'double': 'double', 'bool': 'bool',
    'string': 'string', 'byte[]': 'bytes', 'ByteString': 'bytes',
}

messages = OrderedDict()
i = 0
current_class = None
current_ns = ""
field_numbers = {}  # name -> field_number for current class
field_defs = []     # (type, name) for current class

while i < len(lines):
    s = lines[i].strip()
    
    if s.startswith('// Namespace:'):
        current_ns = s.replace('// Namespace:', '').strip()
    
    # Detect protobuf message class
    if 'IMessage<' in s and 'IBufferMessage' in s and 'sealed class' in s:
        m = re.match(r'.*class\s+(\w+)\s*:', s)
        if m:
            # Save previous
            if current_class and field_defs:
                ordered_fields = []
                for ftype, fname in field_defs:
                    fn = field_numbers.get(fname, field_numbers.get(fname.capitalize(), 0))
                    if fn == 0:
                        # Try CamelCase
                        camel = ''.join(p.capitalize() for p in fname.split('_'))
                        fn = field_numbers.get(camel, len(ordered_fields) + 1)
                    ordered_fields.append((fn, fname, ftype))
                ordered_fields.sort(key=lambda x: x[0])
                messages[current_class] = {'ns': current_ns, 'fields': ordered_fields}
            
            current_class = m.group(1)
            field_numbers = {}
            field_defs = []
    
    # FieldNumber constants: public const int XxxFieldNumber = N;
    if current_class:
        fn_m = re.match(r'\tpublic const int (\w+)FieldNumber = (\d+);', s)
        if fn_m:
            name = fn_m.group(1)
            # Convert PascalCase to snake: e.g., MapX -> mapX, TargetCid -> targetCid
            # Actually keep as-is since fields use camelCase
            name_lower = name[0].lower() + name[1:] if name else name
            field_numbers[name] = int(fn_m.group(2))
            field_numbers[name_lower] = int(fn_m.group(2))
    
    # Field definitions
    if current_class:
        fm = re.match(
            r'\t(?:private|public|internal)\s+'
            r'(?:readonly\s+)?'
            r'(?:RepeatedField<(\w+)>\s+(\w+)_|(\w+(?:\[\])?)\s+(\w+)_)'
            r'\s*;',
            s
        )
        if fm:
            if fm.group(1):  # RepeatedField<T>
                raw_type = fm.group(1)
                fname = fm.group(2)
                ftype = f'repeated {TYPE_MAP.get(raw_type, raw_type)}'
            else:
                raw_type = fm.group(3)
                fname = fm.group(4)
                ftype = TYPE_MAP.get(raw_type, raw_type)
            
            # Skip internal fields
            if fname not in ('parser', 'unknownFields', 'hasBits') and \
               'FieldCodec' not in raw_type and 'MapField' not in s:
                field_defs.append((ftype, fname))
    
    # End of class
    if current_class and s == '}':
        # Check if we're really at class end (no indent)
        if i + 1 < len(lines) and (lines[i+1].strip().startswith('// Namespace') or 
                                     lines[i+1].strip() == ''):
            if field_defs:
                ordered_fields = []
                for ftype, fname in field_defs:
                    fn = field_numbers.get(fname, 0)
                    if fn == 0:
                        camel = fname[0].upper() + fname[1:] if fname else fname
                        fn = field_numbers.get(camel, 0)
                    if fn == 0:
                        fn = len(ordered_fields) + 1
                    ordered_fields.append((fn, fname, ftype))
                ordered_fields.sort(key=lambda x: x[0])
                messages[current_class] = {'ns': current_ns, 'fields': ordered_fields}
            current_class = None
            field_numbers = {}
            field_defs = []
    
    i += 1

# Filter to only GameServer.Network.Protocol and App messages
game_msgs = {k: v for k, v in messages.items() 
             if v['ns'] in ('GameServer.Network.Protocol', 'App', '')}

print(f"Total messages: {len(messages)}")
print(f"Game messages: {len(game_msgs)}")

# ==================== 3. GENERATE PYTHON FILE ====================
out_lines = [
    '"""',
    'vltk1_protocol.py — VLTK1 Protocol Encoder/Decoder (Auto-generated)',
    'Field numbers extracted from Il2CppDumper FieldNumber constants',
    '"""',
    'import struct',
    '',
    '# ==================== OPCODES ====================',
    '',
    'MS_OPCODES = {',
]
for oid, name in sorted(ms_opcodes.items()):
    out_lines.append(f'    {oid}: "{name}",')
out_lines.append('}')
out_lines.append('MS_OPCODES_REV = {v: k for k, v in MS_OPCODES.items()}')
out_lines.append('')
out_lines.append('GS_OPCODES = {')
for oid, name in sorted(gs_opcodes.items()):
    out_lines.append(f'    {oid}: "{name}",')
out_lines.append('}')
out_lines.append('GS_OPCODES_REV = {v: k for k, v in GS_OPCODES.items()}')
out_lines.append('')
out_lines.append('# ==================== MESSAGES ====================')
out_lines.append('MESSAGES = {')
for mname, minfo in sorted(game_msgs.items()):
    out_lines.append(f'    "{mname}": {{')
    out_lines.append(f'        "ns": "{minfo["ns"]}",')
    out_lines.append(f'        "fields": [')
    for fn, fname, ftype in minfo['fields']:
        out_lines.append(f'            ({fn}, "{fname}", "{ftype}"),')
    out_lines.append(f'        ]')
    out_lines.append(f'    }},')
out_lines.append('}')
out_lines.append('')

# Add encoder/decoder (compact version)
out_lines.append('''
# ==================== PROTOBUF CODEC ====================

def _enc_varint(v):
    r = b""
    if v < 0: v += (1 << 64)
    while v > 0x7f: r += bytes([0x80|(v&0x7f)]); v >>= 7
    return r + bytes([v&0x7f]) if r else b"\\x00"

def _dec_varint(d, p):
    r, s = 0, 0
    while True:
        b = d[p]; r |= (b&0x7f)<<s; p += 1
        if not (b&0x80): break
        s += 7
    return r, p

def encode(msg_name, **kw):
    """Encode protobuf message. Returns bytes."""
    if msg_name not in MESSAGES: raise ValueError(f"Unknown: {msg_name}")
    r = b""
    for fn, fname, ftype in MESSAGES[msg_name]["fields"]:
        if fname not in kw: continue
        v = kw[fname]
        if ftype in ('int32','int64','uint32','uint64'):
            r += _enc_varint((fn<<3)|0) + _enc_varint(v)
        elif ftype == 'bool':
            r += _enc_varint((fn<<3)|0) + _enc_varint(1 if v else 0)
        elif ftype == 'float':
            r += _enc_varint((fn<<3)|5) + struct.pack('<f', v)
        elif ftype == 'double':
            r += _enc_varint((fn<<3)|1) + struct.pack('<d', v)
        elif ftype == 'string':
            b = v.encode('utf-8')
            r += _enc_varint((fn<<3)|2) + _enc_varint(len(b)) + b
        elif ftype == 'bytes':
            b = v if isinstance(v, bytes) else bytes(v)
            r += _enc_varint((fn<<3)|2) + _enc_varint(len(b)) + b
        elif ftype.startswith('repeated '):
            inner = ftype[9:]
            for item in v:
                if inner in ('int32','int64','uint32','uint64'):
                    r += _enc_varint((fn<<3)|0) + _enc_varint(item)
                elif inner == 'string':
                    b = item.encode('utf-8')
                    r += _enc_varint((fn<<3)|2) + _enc_varint(len(b)) + b
                elif inner in MESSAGES:
                    sub = encode(inner, **item) if isinstance(item,dict) else item
                    r += _enc_varint((fn<<3)|2) + _enc_varint(len(sub)) + sub
        else:
            if isinstance(v, dict) and ftype in MESSAGES:
                sub = encode(ftype, **v)
                r += _enc_varint((fn<<3)|2) + _enc_varint(len(sub)) + sub
    return r

def decode(msg_name, data):
    """Decode protobuf message. Returns dict."""
    if msg_name not in MESSAGES: raise ValueError(f"Unknown: {msg_name}")
    fmap = {f[0]: (f[1],f[2]) for f in MESSAGES[msg_name]["fields"]}
    result, pos = {}, 0
    while pos < len(data):
        tag, pos = _dec_varint(data, pos)
        fnum, wt = tag>>3, tag&7
        fname, ftype = fmap.get(fnum, (f"unk_{fnum}", "unknown"))
        if wt == 0:
            val, pos = _dec_varint(data, pos)
            if ftype == 'bool': val = bool(val)
        elif wt == 1:
            val = struct.unpack_from('<d', data, pos)[0]; pos += 8
        elif wt == 2:
            ln, pos = _dec_varint(data, pos)
            val = data[pos:pos+ln]; pos += ln
            if ftype == 'string':
                try: val = val.decode('utf-8')
                except: pass
            elif ftype not in ('bytes','unknown') and not ftype.startswith('repeated'):
                if ftype in MESSAGES:
                    try: val = decode(ftype, val)
                    except: pass
        elif wt == 5:
            val = struct.unpack_from('<f', data, pos)[0]; pos += 4
        else:
            break
        if ftype.startswith('repeated'):
            result.setdefault(fname, []).append(val)
        else:
            result[fname] = val
    return result

def build_packet(opcode_name, **kw):
    """Build: [LE uint16 opcode] + [protobuf payload]"""
    oid = GS_OPCODES_REV.get(opcode_name, -1)
    if oid < 0: raise ValueError(f"Unknown opcode: {opcode_name}")
    # Map opcode to message: eXxx -> Xxx
    msg = opcode_name[1:] if opcode_name.startswith('e') else opcode_name
    payload = encode(msg, **kw) if msg in MESSAGES else b""
    return struct.pack('<H', oid) + payload

def parse_packet(data):
    """Parse: returns (opcode_name, fields_dict)"""
    if len(data) < 2: return "TOO_SHORT", {}
    oid = struct.unpack_from('<H', data, 0)[0]
    name = GS_OPCODES.get(oid, f"UNKNOWN({oid})")
    msg = name[1:] if name.startswith('e') else name
    fields = {}
    if msg in MESSAGES and len(data) > 2:
        try: fields = decode(msg, data[2:])
        except: fields = {"_raw": data[2:].hex()}
    elif len(data) > 2:
        fields = {"_raw": data[2:].hex()}
    return name, fields

def lookup(oid): return GS_OPCODES.get(oid, f"UNK({oid})")
''')

OUT.write_text('\n'.join(out_lines), encoding='utf-8')
print(f"\nWrote: {OUT} ({OUT.stat().st_size} bytes)")

# Summary
print(f"\n{'='*60}")
print(f"MS opcodes: {len(ms_opcodes)}")
print(f"GS opcodes: {len(gs_opcodes)}")
print(f"Game messages: {len(game_msgs)}")

# Check coverage
gs_names = set(gs_opcodes.values())
msg_names = set(game_msgs.keys())
matched = 0
for name in gs_names:
    msg = name[1:] if name.startswith('e') else name
    if msg in msg_names:
        matched += 1

print(f"Opcodes with matching message: {matched}/{len(gs_names)} = {matched*100//len(gs_names)}%")
print(f"\nMissing messages for opcodes:")
for name in sorted(gs_names):
    msg = name[1:] if name.startswith('e') else name
    if msg not in msg_names:
        print(f"  {name} -> {msg} NOT FOUND")
