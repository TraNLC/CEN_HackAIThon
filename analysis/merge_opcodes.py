"""
merge_opcodes.py — Inject opcodes into the generated protocol file and test
"""
import sys, re
from pathlib import Path

PROTO_PY = Path(r"e:\tool\sample-test\vltk1-re\proto\vltk1_protocol.py")
DUMP = Path(r"e:\tool\sample-test\vltk1-re\Il2CppDumper-net7-win-v6.7.46\dump.cs")

# ===== Extract opcodes from dump.cs =====
print("Extracting opcodes from dump.cs...")
lines = DUMP.read_text(encoding='utf-8').splitlines()

ms_ops = {}
gs_ops = {}
in_ms = in_gs = False

for line in lines:
    s = line.strip()
    if 'public enum MSCode' in s and 'TypeDefIndex' in s:
        in_ms = True; continue
    if re.match(r'public enum Id\b', s) and 'TypeDefIndex' in s:
        in_gs = True; continue
    if (in_ms or in_gs) and s == '}':
        in_ms = in_gs = False; continue
    
    if in_ms:
        m = re.search(r'public const MSCode (\w+) = (\d+);', s)
        if m and m.group(1) != 'value__':
            ms_ops[int(m.group(2))] = m.group(1)
    if in_gs:
        m = re.search(r'public const Id (\w+) = (\d+);', s)
        if m and m.group(1) != 'value__':
            name = m.group(1)
            if name.startswith('E') and len(name) > 1:
                name = 'e' + name[1:]
            gs_ops[int(m.group(2))] = name

print(f"  MS: {len(ms_ops)}, GS: {len(gs_ops)}")

# ===== Inject into protocol file =====
content = PROTO_PY.read_text(encoding='utf-8')

# Build new MS_OPCODES
ms_block = "MS_OPCODES = {\n"
for k, v in sorted(ms_ops.items()):
    ms_block += f'    {k}: "{v}",\n'
ms_block += "}"

# Build new GS_OPCODES
gs_block = "GS_OPCODES = {\n"
for k, v in sorted(gs_ops.items()):
    gs_block += f'    {k}: "{v}",\n'
gs_block += "}"

# Replace empty dicts
content = re.sub(r'MS_OPCODES = \{[^}]*\}', ms_block, content, count=1)
content = re.sub(r'GS_OPCODES = \{[^}]*\}', gs_block, content, count=1)

PROTO_PY.write_text(content, encoding='utf-8')
print(f"Updated {PROTO_PY}")

# ===== Test =====
sys.path.insert(0, str(PROTO_PY.parent))
# Force reimport
if 'vltk1_protocol' in sys.modules:
    del sys.modules['vltk1_protocol']
    
from vltk1_protocol import (
    encode_message_fields as encode, decode_message_fields as decode,
    build_gs_packet as build_packet, parse_gs_packet as parse_packet,
    GS_OPCODES, MS_OPCODES, MESSAGES, GS_OPCODES_REV
)

print(f"\nMS opcodes: {len(MS_OPCODES)}")
print(f"GS opcodes: {len(GS_OPCODES)}")
print(f"Messages:   {len(MESSAGES)}")

# Coverage analysis
matched = 0
for name in GS_OPCODES.values():
    msg = name[1:] if name.startswith('e') else name
    if msg in MESSAGES:
        matched += 1

print(f"\nOpcode → Message coverage: {matched}/{len(GS_OPCODES)} = {matched*100//len(GS_OPCODES)}%")

# Test encode/decode
print("\n--- Encode/Decode Tests ---")
tests = [
    ("GotoPosition", {"mapx": 1234, "mapy": 5678}),
    ("PlayerTalk", {"message": "Hello VLTK!"}),
    ("NpcDialogue", {"npcId": "npc_shop_01"}),
    ("ChatSend", {"channel": 1, "message": "xin chao", "receiver": "player2"}),
    ("PlayerLoginRequest", {"loginCode": "abc", "cid": "char001"}),
    ("CastSkill", {"skillId": 40, "skillLevel": 5, "targetId": "mob_01"}),
    ("DoSkillTargetNpc", {"skillid": 100, "nid": "npc_001"}),
    ("ShopBuyItem", {"shopkey": "shop01", "itemindex": 5, "quantity": 3}),
    ("SetRiding", {"riding": True}),
    ("ObjectPickup", {"objectId": "drop_123"}),
]

ok = 0
for msg, kw in tests:
    try:
        data = encode(msg, **kw)
        decoded = decode(msg, data)
        match = all(str(decoded.get(k)) == str(v) for k, v in kw.items())
        status = "✓" if match else "≈"
        print(f"  {status} {msg}: {kw} -> {decoded}")
        ok += 1
    except Exception as e:
        print(f"  ✗ {msg}: {e}")

print(f"\nEncode/Decode: {ok}/{len(tests)} passed")

# Test packet building
print("\n--- Packet Build Tests ---")
pkt_tests = [
    ("eGotoPosition", {"mapx": 100, "mapy": 200}),
    ("eChatSend", {"channel": 1, "message": "test"}),
    ("eNpcDialogue", {"npcId": "npc1"}),
    ("ePing", {}),
]

for opname, kw in pkt_tests:
    try:
        pkt = build_packet(opname, **kw)
        parsed_op, parsed_fields = parse_packet(pkt)
        print(f"  ✓ {opname}: {pkt.hex()} -> {parsed_op} {parsed_fields}")
    except Exception as e:
        print(f"  ✗ {opname}: {e}")

# Coverage summary
print("\n" + "=" * 60)
print("COVERAGE SUMMARY")
print("=" * 60)
print(f"GS opcodes defined:      {len(GS_OPCODES)}")
print(f"MS opcodes defined:      {len(MS_OPCODES)}")
print(f"Message types defined:   {len(MESSAGES)}")
print(f"Opcode→Message matched:  {matched}/{len(GS_OPCODES)} ({matched*100//len(GS_OPCODES)}%)")

# Bot functions coverage
bot_ops = ['eGotoPosition','eGotoNpc','eNpcDialogue','eNpcSelect','eCastSkill',
           'eDoSkillTargetNpc','eDoSkillTargetPlayer','eDoSkillTargetPosition',
           'eChatSend','eObjectPickup','ePlayerUserItem','eQuestComplete',
           'eQuestClick','eShopBuyItem','eShopSellItem','eSetRiding',
           'eIsSittingDown','eJumToMap','ePing','ePlayerLoginRequest',
           'eItemLocationRequest','ePartySelfCreate','ePartySelfJoin']

bot_ok = 0
for op in bot_ops:
    msg = op[1:] if op.startswith('e') else op
    has_msg = msg in MESSAGES
    has_op = op in GS_OPCODES_REV
    if has_msg and has_op:
        bot_ok += 1
        
print(f"\nBot-critical ops covered: {bot_ok}/{len(bot_ops)} ({bot_ok*100//len(bot_ops)}%)")
