"""
extract_proto.py — Extract protobuf definitions from Il2CppDumper dump.cs
Generates .proto files and Python encoder/decoder for all game messages.
"""
import re
from pathlib import Path
from collections import OrderedDict

DUMP = Path(r"e:\tool\sample-test\vltk1-re\Il2CppDumper-net7-win-v6.7.46\dump.cs")
OUT_DIR = Path(r"e:\tool\sample-test\vltk1-re\proto")
OUT_DIR.mkdir(exist_ok=True)

print(f"Reading dump.cs ({DUMP.stat().st_size / 1024 / 1024:.1f} MB)...")
lines = DUMP.read_text(encoding='utf-8').splitlines()
print(f"Total lines: {len(lines)}")

# ==================== PARSE PROTOBUF MESSAGES ====================

# Type mapping from C# to proto3
TYPE_MAP = {
    'int': 'int32',
    'uint': 'uint32',
    'long': 'int64',
    'ulong': 'uint64',
    'float': 'float',
    'double': 'double',
    'bool': 'bool',
    'string': 'string',
    'byte[]': 'bytes',
    'ByteString': 'bytes',
    'int[]': 'repeated int32',
    'uint[]': 'repeated uint32',
    'long[]': 'repeated int64',
    'float[]': 'repeated float',
    'string[]': 'repeated string',
}

messages = OrderedDict()
current_ns = ""
current_class = None
current_fields = []
in_fields = False

# Also collect enums
enums = OrderedDict()
current_enum = None
current_enum_values = []

print("Parsing protobuf messages...")

i = 0
while i < len(lines):
    line = lines[i].strip()
    
    # Track namespace
    if line.startswith('// Namespace:'):
        current_ns = line.replace('// Namespace:', '').strip()
    
    # Find protobuf message classes (IMessage implementation)
    if 'IMessage<' in line and 'IBufferMessage' in line and 'sealed class' in line:
        # Extract class name
        m = re.search(r'class\s+(\w+)\s*:', line)
        if m:
            current_class = m.group(1)
            current_fields = []
            in_fields = False
    
    # Find fields section
    if current_class and line == '// Fields':
        in_fields = True
        i += 1
        continue
    
    # End of fields
    if current_class and (line == '// Properties' or line == '// Methods'):
        in_fields = False
    
    # Parse field definitions
    if current_class and in_fields and line and not line.startswith('//'):
        # Skip internal/static fields
        if 'static' in line or '_parser' in line or '_unknownFields' in line:
            i += 1
            continue
        if '_hasBits' in line or 'FieldCodec' in line or 'MapField' in line:
            i += 1
            continue
            
        # Match field pattern: [access] type name; // offset
        # e.g.: private int id_; // 0x10
        # e.g.: private string name_; // 0x14
        # e.g.: private readonly RepeatedField<ItemData> items_; // 0x18
        
        fm = re.match(
            r'(?:private|public|internal)\s+'
            r'(?:readonly\s+)?'
            r'(?:RepeatedField<(\w+)>\s+(\w+)_|(\w+(?:\[\])?)\s+(\w+)_)'
            r'\s*;\s*//\s*(0x[0-9a-fA-F]+)',
            line
        )
        if fm:
            if fm.group(1):  # RepeatedField<T>
                field_type = f'repeated {fm.group(1)}'
                field_name = fm.group(2)
            else:
                field_type = fm.group(3)
                field_name = fm.group(4)
            
            # Map C# type to proto type
            if field_type in TYPE_MAP:
                field_type = TYPE_MAP[field_type]
            elif field_type.startswith('repeated '):
                inner = field_type.replace('repeated ', '')
                if inner in TYPE_MAP:
                    field_type = f'repeated {TYPE_MAP[inner]}'
            
            current_fields.append((field_type, field_name))
    
    # End of class
    if current_class and line == '}' and not in_fields:
        # Check if we found any fields
        if current_fields:
            messages[current_class] = {
                'namespace': current_ns,
                'fields': current_fields[:]
            }
        current_class = None
        current_fields = []
    
    # Parse enums in GameServer.Network.Protocol
    if current_ns == 'GameServer.Network.Protocol' or current_ns == '':
        em = re.match(r'public enum (\w+)', line)
        if em:
            current_enum = em.group(1)
            current_enum_values = []
        
        if current_enum:
            evm = re.match(r'\tpublic const \w+\.?\w* (\w+) = (\d+);', line)
            if not evm:
                evm = re.match(r'\tpublic const \w+ (\w+) = (\d+);', line)
            if evm and evm.group(1) != 'value__':
                current_enum_values.append((evm.group(1), int(evm.group(2))))
            
            if line == '}' and current_enum:
                if current_enum_values and current_enum in ('Id', 'MSCode'):
                    enums[current_enum] = current_enum_values[:]
                current_enum = None
                current_enum_values = []
    
    i += 1

print(f"\nFound {len(messages)} protobuf messages")
print(f"Found {len(enums)} enums")

# ==================== GENERATE PROTO FILE ====================

proto_content = '''syntax = "proto3";

package vltk1;

option java_package = "vn.perfingame.jx1mobile.protocol";

'''

# Add enums
for enum_name, values in enums.items():
    proto_content += f'enum {enum_name} {{\n'
    for vname, vval in values:
        proto_content += f'  {vname} = {vval};\n'
    proto_content += '}\n\n'

# Add messages (sort by namespace for readability)
protocol_msgs = {k: v for k, v in messages.items() 
                 if v['namespace'] == 'GameServer.Network.Protocol'}
other_msgs = {k: v for k, v in messages.items() 
              if v['namespace'] != 'GameServer.Network.Protocol'}

# Protocol messages first
for msg_name, msg_info in sorted(protocol_msgs.items()):
    proto_content += f'// Namespace: {msg_info["namespace"]}\n'
    proto_content += f'message {msg_name} {{\n'
    for idx, (ftype, fname) in enumerate(msg_info['fields'], 1):
        proto_content += f'  {ftype} {fname} = {idx};\n'
    proto_content += '}\n\n'

# Other messages
for msg_name, msg_info in sorted(other_msgs.items()):
    proto_content += f'// Namespace: {msg_info["namespace"]}\n'
    proto_content += f'message {msg_name} {{\n'
    for idx, (ftype, fname) in enumerate(msg_info['fields'], 1):
        proto_content += f'  {ftype} {fname} = {idx};\n'
    proto_content += '}\n\n'

proto_file = OUT_DIR / "vltk1.proto"
proto_file.write_text(proto_content, encoding='utf-8')
print(f"\nWrote {proto_file} ({len(proto_content)} bytes)")

# ==================== GENERATE PYTHON ENCODER/DECODER ====================

# Since protoc might not be available, generate a manual Python encoder/decoder
# using field definitions

py_content = '''"""
vltk1_protocol.py — Auto-generated VLTK1 Protocol Encoder/Decoder
Generated from Il2CppDumper dump.cs

Usage:
    from vltk1_protocol import encode_message, decode_message, GS_OPCODES, MS_OPCODES
"""
import struct

# ==================== OPCODES ====================

MS_OPCODES = {
'''

for enum_name, values in enums.items():
    if enum_name == 'MSCode':
        for vname, vval in values:
            py_content += f'    {vval}: "{vname}",\n'
py_content += '}\n\nMS_OPCODES_REV = {v: k for k, v in MS_OPCODES.items()}\n\n'

py_content += 'GS_OPCODES = {\n'
for enum_name, values in enums.items():
    if enum_name == 'Id':
        for vname, vval in values:
            py_content += f'    {vval}: "{vname}",\n'
py_content += '}\n\nGS_OPCODES_REV = {v: k for k, v in GS_OPCODES.items()}\n\n'

# Generate message definitions as Python dicts
py_content += '''
# ==================== MESSAGE DEFINITIONS ====================
# Each message: { 'fields': [(field_num, name, type)] }

MESSAGES = {
'''

for msg_name, msg_info in sorted(messages.items()):
    py_content += f'    "{msg_name}": {{\n'
    py_content += f'        "namespace": "{msg_info["namespace"]}",\n'
    py_content += f'        "fields": [\n'
    for idx, (ftype, fname) in enumerate(msg_info['fields'], 1):
        py_content += f'            ({idx}, "{fname}", "{ftype}"),\n'
    py_content += f'        ]\n'
    py_content += f'    }},\n'

py_content += '''}\n

# ==================== PROTOBUF WIRE FORMAT ====================

def encode_varint(value):
    """Encode an integer as a varint."""
    result = b""
    if value < 0:
        value = value + (1 << 64)  # Convert to unsigned
    while value > 0x7f:
        result += bytes([0x80 | (value & 0x7f)])
        value >>= 7
    result += bytes([value & 0x7f])
    return result or b"\\x00"


def decode_varint(data, pos):
    """Decode a varint from data at position. Returns (value, new_pos)."""
    result = 0
    shift = 0
    while True:
        if pos >= len(data):
            raise ValueError("Truncated varint")
        byte = data[pos]
        result |= (byte & 0x7f) << shift
        pos += 1
        if not (byte & 0x80):
            break
        shift += 7
    return result, pos


def encode_field(field_num, wire_type, value):
    """Encode a single protobuf field."""
    tag = (field_num << 3) | wire_type
    return encode_varint(tag) + value


def encode_string(s):
    """Encode a string as length-delimited bytes."""
    encoded = s.encode('utf-8') if isinstance(s, str) else s
    return encode_varint(len(encoded)) + encoded


def encode_message_fields(msg_name, **kwargs):
    """Encode a protobuf message by name and field values.
    
    Example:
        data = encode_message_fields("PlayerMove", x=100, y=200, z=0)
    """
    if msg_name not in MESSAGES:
        raise ValueError(f"Unknown message: {msg_name}")
    
    result = b""
    msg_def = MESSAGES[msg_name]
    
    for field_num, fname, ftype in msg_def["fields"]:
        if fname not in kwargs:
            continue
        
        value = kwargs[fname]
        
        if ftype in ('int32', 'int64', 'uint32', 'uint64', 'bool'):
            # Varint encoding (wire type 0)
            if ftype == 'bool':
                value = 1 if value else 0
            result += encode_field(field_num, 0, encode_varint(value))
        
        elif ftype in ('float',):
            # 32-bit (wire type 5)
            result += encode_field(field_num, 5, struct.pack('<f', value))
        
        elif ftype in ('double',):
            # 64-bit (wire type 1)
            result += encode_field(field_num, 1, struct.pack('<d', value))
        
        elif ftype in ('string', 'bytes'):
            # Length-delimited (wire type 2)
            if ftype == 'string':
                encoded = value.encode('utf-8')
            else:
                encoded = value if isinstance(value, bytes) else bytes(value)
            result += encode_field(field_num, 2, encode_varint(len(encoded)) + encoded)
        
        elif ftype.startswith('repeated '):
            inner_type = ftype.replace('repeated ', '')
            for item in value:
                if inner_type in ('int32', 'int64', 'uint32', 'uint64'):
                    result += encode_field(field_num, 0, encode_varint(item))
                elif inner_type in ('string',):
                    encoded = item.encode('utf-8')
                    result += encode_field(field_num, 2, encode_varint(len(encoded)) + encoded)
                elif inner_type in ('float',):
                    result += encode_field(field_num, 5, struct.pack('<f', item))
                else:
                    # Sub-message
                    sub_data = encode_message_fields(inner_type, **item)
                    result += encode_field(field_num, 2, encode_varint(len(sub_data)) + sub_data)
        
        else:
            # Assume it's a sub-message type
            if isinstance(value, dict):
                sub_data = encode_message_fields(ftype, **value)
                result += encode_field(field_num, 2, encode_varint(len(sub_data)) + sub_data)
    
    return result


def decode_message_fields(msg_name, data):
    """Decode a protobuf message by name.
    
    Returns dict of field_name -> value
    """
    if msg_name not in MESSAGES:
        raise ValueError(f"Unknown message: {msg_name}")
    
    msg_def = MESSAGES[msg_name]
    field_map = {f[0]: (f[1], f[2]) for f in msg_def["fields"]}
    
    result = {}
    pos = 0
    
    while pos < len(data):
        tag, pos = decode_varint(data, pos)
        field_num = tag >> 3
        wire_type = tag & 0x07
        
        if field_num in field_map:
            fname, ftype = field_map[field_num]
        else:
            fname = f"unknown_{field_num}"
            ftype = "unknown"
        
        if wire_type == 0:  # Varint
            value, pos = decode_varint(data, pos)
            if ftype == 'bool':
                value = bool(value)
            
        elif wire_type == 1:  # 64-bit
            value = struct.unpack_from('<d', data, pos)[0]
            pos += 8
            
        elif wire_type == 2:  # Length-delimited
            length, pos = decode_varint(data, pos)
            value = data[pos:pos + length]
            pos += length
            
            if ftype == 'string':
                try:
                    value = value.decode('utf-8')
                except:
                    pass
            elif ftype not in ('bytes',) and not ftype.startswith('repeated'):
                # Try to decode as sub-message
                try:
                    if ftype in MESSAGES:
                        value = decode_message_fields(ftype, value)
                except:
                    pass
            
        elif wire_type == 5:  # 32-bit
            value = struct.unpack_from('<f', data, pos)[0]
            pos += 4
        else:
            break  # Unknown wire type
        
        # Handle repeated fields
        if ftype.startswith('repeated'):
            if fname not in result:
                result[fname] = []
            result[fname].append(value)
        else:
            result[fname] = value
    
    return result


def lookup_opcode(msg_id, server_type='GS'):
    """Look up opcode name."""
    table = GS_OPCODES if server_type == 'GS' else MS_OPCODES
    return table.get(msg_id, f"UNKNOWN({msg_id})")


def opcode_id(name, server_type='GS'):
    """Get opcode ID from name."""
    table = GS_OPCODES_REV if server_type == 'GS' else MS_OPCODES_REV
    return table.get(name, -1)


# ==================== PACKET FORMAT ====================

def build_gs_packet(opcode_name, **kwargs):
    """Build a complete GS packet: [2 bytes opcode LE] + [protobuf payload]
    
    Example:
        pkt = build_gs_packet("eChatSend", message="hello world")
    """
    oid = opcode_id(opcode_name, 'GS')
    if oid < 0:
        raise ValueError(f"Unknown opcode: {opcode_name}")
    
    # Find matching message class name
    # Convention: opcode eXxxYyy -> message class XxxYyy (remove 'e' prefix)
    msg_class = opcode_name[1:] if opcode_name.startswith('e') else opcode_name
    
    # Try to encode
    if msg_class in MESSAGES:
        payload = encode_message_fields(msg_class, **kwargs)
    else:
        payload = b""
    
    # Packet: LE uint16 opcode + payload
    return struct.pack('<H', oid) + payload


def parse_gs_packet(data):
    """Parse a GS packet: returns (opcode_name, decoded_fields)"""
    if len(data) < 2:
        return "TOO_SHORT", {}
    
    opcode = struct.unpack_from('<H', data, 0)[0]
    opcode_name = lookup_opcode(opcode)
    
    payload = data[2:]
    
    # Try to find and decode the message
    msg_class = opcode_name[1:] if opcode_name.startswith('e') else opcode_name
    
    fields = {}
    if msg_class in MESSAGES and payload:
        try:
            fields = decode_message_fields(msg_class, payload)
        except Exception as e:
            fields = {"_raw": payload.hex(), "_error": str(e)}
    elif payload:
        fields = {"_raw": payload.hex()}
    
    return opcode_name, fields


# ==================== CONVENIENCE FUNCTIONS ====================

def list_messages():
    """List all known message types."""
    for name, info in sorted(MESSAGES.items()):
        ns = info["namespace"]
        fields = ", ".join(f"{t} {n}" for _, n, t in info["fields"])
        print(f"  {name} [{ns}]: {fields}")


def list_opcodes():
    """List all opcodes."""
    print("\\n=== MS Opcodes ===")
    for oid, name in sorted(MS_OPCODES.items()):
        print(f"  {oid:3d} = {name}")
    print("\\n=== GS Opcodes ===")
    for oid, name in sorted(GS_OPCODES.items()):
        print(f"  {oid:3d} = {name}")
'''

py_file = OUT_DIR / "vltk1_protocol.py"
py_file.write_text(py_content, encoding='utf-8')
print(f"Wrote {py_file}")

# ==================== SUMMARY ====================

print(f"\n{'='*60}")
print("EXTRACTION SUMMARY")
print(f"{'='*60}")
print(f"Protocol messages: {len(protocol_msgs)}")
print(f"Other messages:    {len(other_msgs)}")
print(f"Total messages:    {len(messages)}")
print(f"Enums:             {len(enums)}")
print(f"\nFiles generated:")
print(f"  {proto_file}")
print(f"  {py_file}")

# Print protocol messages
print(f"\n--- Protocol Messages ---")
for name, info in sorted(protocol_msgs.items()):
    fields = ", ".join(f"{t} {n}" for t, n in info['fields'])
    print(f"  {name}: {fields}")
