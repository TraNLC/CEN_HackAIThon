"""
test_protocol.py — Test the generated protocol encoder/decoder
"""
import sys
sys.path.insert(0, r"e:\tool\sample-test\vltk1-re\proto")

from vltk1_protocol import (
    encode_message_fields, decode_message_fields, 
    build_gs_packet, parse_gs_packet,
    list_opcodes, MESSAGES, GS_OPCODES, MS_OPCODES
)

print("=" * 60)
print("VLTK1 Protocol Test")
print("=" * 60)

# Stats
print(f"\nTotal message types: {len(MESSAGES)}")
print(f"GS opcodes: {len(GS_OPCODES)}")
print(f"MS opcodes: {len(MS_OPCODES)}")

# Test 1: Encode/Decode GotoPosition
print("\n--- Test 1: GotoPosition ---")
data = encode_message_fields("GotoPosition", mapx=1234, mapy=5678)
print(f"Encoded: {data.hex()}")
decoded = decode_message_fields("GotoPosition", data)
print(f"Decoded: {decoded}")

# Test 2: Encode/Decode PlayerTalk (Chat)
print("\n--- Test 2: PlayerTalk ---")
data = encode_message_fields("PlayerTalk", message="Xin chao cac ban!")
print(f"Encoded: {data.hex()}")
decoded = decode_message_fields("PlayerTalk", data)
print(f"Decoded: {decoded}")

# Test 3: Build complete GS packet for NpcDialogue
print("\n--- Test 3: NpcDialogue ---")
pkt = build_gs_packet("eNpcDialogue", npcId="npc_123")
print(f"Full packet: {pkt.hex()}")
opcode, fields = parse_gs_packet(pkt)
print(f"Parsed: opcode={opcode}, fields={fields}")

# Test 4: Encode/Decode PlayerLoginRequest
print("\n--- Test 4: PlayerLoginRequest ---")
data = encode_message_fields("PlayerLoginRequest", loginCode="abc123", cid="player001")
print(f"Encoded: {data.hex()}")
decoded = decode_message_fields("PlayerLoginRequest", data)
print(f"Decoded: {decoded}")

# Test 5: PlayerLoginResponse
print("\n--- Test 5: PlayerLoginResponse ---")
data = encode_message_fields("PlayerLoginResponse", 
    isOk=True, msg="Welcome", mapId=100, mapX=500, mapY=300)
print(f"Encoded: {data.hex()}")
decoded = decode_message_fields("PlayerLoginResponse", data)
print(f"Decoded: {decoded}")

# Test 6: CastSkill-like message
print("\n--- Test 6: NpcAttack ---")
data = encode_message_fields("NpcAttack", 
    uuid="monster_001", cid="player_001", sid=40, slv=5, damage=1500)
print(f"Encoded: {data.hex()}")
decoded = decode_message_fields("NpcAttack", data)
print(f"Decoded: {decoded}")

# Test 7: Build GS packet for movement
print("\n--- Test 7: Full movement packet ---")
pkt = build_gs_packet("eGotoPosition", mapx=1500, mapy=2000)
print(f"Packet hex: {pkt.hex()}")
print(f"Packet bytes: {' '.join(f'{b:02x}' for b in pkt)}")
opcode, fields = parse_gs_packet(pkt)
print(f"Parsed: opcode={opcode}, fields={fields}")

# Test 8: Try to parse captured packet
print("\n--- Test 8: Parse captured packet ---")
captured = bytes.fromhex("020000007f0000000c140000000000008071c8ccff07000003000000021000000200000000000000")
opcode, fields = parse_gs_packet(captured)
print(f"Opcode: {opcode}")
print(f"Fields: {fields}")

# List all bot-relevant messages
print("\n" + "=" * 60)
print("BOT-RELEVANT MESSAGES")
print("=" * 60)

bot_targets = [
    'GotoPosition', 'GotoNpc', 'NpcDialogue', 'NpcSelectMessage',
    'PlayerTalk', 'PlayerLoginRequest', 'PlayerLoginResponse',
    'CastSkill', 'NpcAttack', 'ObjectPickup', 'PlayerUseItem',
    'QuestComplete', 'QuestClick', 'QuestInfo', 'QuestFocus',
    'ChatSend', 'ChatMessage', 'PartyRequest', 'PartySelfCreate',
    'ShopBuyItem', 'ShopSellItem', 'SetRiding', 'IsSittingDown',
    'ItemLocationRequest', 'JumToMap', 'TradeInviteToGsv',
    'EnterGameServer', 'DoSkillTargetNpc', 'DoSkillTargetPlayer',
]

for name in sorted(bot_targets):
    if name in MESSAGES:
        fields = ", ".join(f"{t} {n}" for _, n, t in MESSAGES[name]['fields'])
        print(f"  {name}: {fields}")
    else:
        print(f"  {name}: (not found in dump)")

print(f"\n\nCoverage: {sum(1 for n in bot_targets if n in MESSAGES)}/{len(bot_targets)} messages found")
