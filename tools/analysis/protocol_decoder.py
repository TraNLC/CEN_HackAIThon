"""
protocol_decoder.py — Decode VLTK1 captured packets using discovered opcodes
"""
import json
import struct
from pathlib import Path
from collections import Counter, defaultdict

ROOT = Path(__file__).parent.parent
CAPTURE_DIR = ROOT / "captures"

# ==================== OPCODES ====================

# MSCode — Master Server opcodes
MS_OPCODES = {
    0: "Unidentified",
    1: "UnityRegisterRequest",
    2: "UnityRegisterResponse",
    3: "UnityLoginRequest",
    4: "UnityLoginResponse",
    5: "UnityCreateCharacterRequest",
    6: "UnityCreateCharacterResponse",
    7: "UnityEntergameRequest",
    8: "UnityEntergameResponse",
    9: "StringData",
    23: "Passcode",
    61: "UnityRegisterFields",
    71: "UnityLoginQueueStart",
}

# Id — Game Server opcodes
GS_OPCODES = {
    0: "eUnidentified",
    1: "ePlayerLoginRequest",
    2: "ePlayerLoginResponse",
    3: "eEnterWorldSuccess",
    4: "eCharacterDetailResponse",
    5: "eSkillResponse",
    6: "eItemResponse",
    7: "eEnterMap",
    8: "eEnterGameServer",
    9: "eStringData",
    10: "eDelivered",
    11: "eCharacterRequest",
    12: "eCharacterResponse",
    13: "eJumToMap",
    16: "eSyncPlayerItem",
    17: "eSyncPlayerSkill",
    18: "eSyncPlayerData",
    19: "eSyncPlayerFriend",
    20: "eSyncPlayerMove",
    23: "eSyncDamage",
    24: "eAutoEquip",
    27: "eRemoveItem",
    28: "eItemLocationRequest",
    30: "eMapRegionObstacle",
    33: "eNpcDialogue",
    34: "eNpcQuest",
    35: "eNpcSelect",
    36: "eNpcAttack",
    37: "eNpcDebug",
    40: "eCastSkill",
    45: "eMapRegionTrap",
    46: "eMapRegionTrapOpen",
    48: "ePlayerTalk",
    49: "ePlayerUserItem",
    51: "eOpenShop",
    54: "eAddMapObject",
    56: "eObjectPickup",
    57: "eOpenSaveBox",
    58: "eSetRiding",
    62: "eIsSittingDown",
    63: "eAddPropField",
    64: "eAddSkillPoint",
    65: "eAllMagicAttribRequest",
    66: "eAllMagicAttribResponse",
    69: "ePing",
    70: "ePong",
    71: "eMapDialogNpcListRequest",
    72: "eMapDialogNpcListResponse",
    73: "eSetPkState",
    74: "ePartyCaptain",
    75: "ePartyJoin",
    76: "ePartyRequest",
    77: "ePartyOut",
    78: "ePartyNearest",
    79: "ePartyInvite",
    80: "ePartySelfJoin",
    81: "ePartySelfOut",
    82: "ePartySelfNearest",
    83: "ePartySelfInvite",
    84: "ePartySelfCreate",
    85: "ePartySelfKick",
    86: "ePartySelfConfirm",
    87: "ePartySelfUnconfirm",
    88: "ePartySync",
    91: "ePartySelfCaptain",
    92: "ePartySelfAccept",
    93: "ePartySelfUnaccept",
    94: "eAskClientForString",
    95: "eAnswerServerForString",
    96: "eTongSelfOverview",
    97: "eTongSelfMemberList",
    99: "eTongSelfMemberKick",
    100: "eTongSelfMemberFigure",
    101: "eTongSelfMemberTitle",
    102: "eTongSelfOut",
    103: "eTongSelfRequestList",
    105: "eTongSelfRequestAccept",
    106: "eTongSelfRequestReject",
    107: "eTongOverview",
    108: "eTongMemberField",
    110: "eTongRequestField",
    112: "eTongSelfRequestSend",
    113: "eTongRequestNoti",
    114: "eTongSelfTongList",
    115: "eTongTongField",
    116: "eTongSelfNote",
    117: "eSwitchWalking",
    118: "eLocalNews",
    119: "eShopTypeOne",
    120: "eShopTypeTwo",
    122: "eTownportal",
    123: "eQuestFocus",
    124: "eQuestInfo",
    125: "eQuestComplete",
    126: "eGiveBoxOpen",
    127: "eGiveBoxSend",
    128: "eGiveBoxRemove",
    129: "eGiveBoxCancel",
    130: "eGiveBoxConfirm",
    131: "eUnmergeItem",
    132: "eChatSend",
    133: "eChatMessage",
    134: "eChatItemClick",
    135: "eChatItemView",
    136: "eTrainoffCheckRequest",
    137: "eTrainoffCheckResponse",
    138: "eTrainoffStart",
    139: "eKickout",
    140: "eApplyAutoplayProfile",
    141: "eQuestLimit",
    142: "eQuestClick",
    143: "ePasscode",
    144: "eQuestLock",
    145: "eRankPlayerLevelRequest",
    146: "eRankPlayerLevelResponseField",
    147: "eShopSellItem",
    148: "eShopBuyItem",
    149: "eTongSelfFuncs",
    150: "eTradeInviteToGsv",
    151: "eTradeInviteToCli",
    152: "eTradeInviteAccept",
    153: "eTradeStart",
    154: "eTradeProcessSendItemToGsv",
    155: "eTradeProcessSendItemToRemove",
    156: "eTradeProcessSendItemToAdd",
    157: "eTradeProcessRefundItem",
    158: "eTradeProcessRefundItemSource",
    159: "eTradeProcessRefundItemDestinate",
    160: "eTradeProcessSendCashToGsv",
    161: "eTradeProcessSendCashToRemove",
    162: "eTradeProcessSendCashToAdd",
    163: "eTradeFinishCancel",
    164: "eTradeFinishLock",
    165: "eTradeFinishConfirm",
    166: "eContextDescription",
    167: "eContextDesSelect",
    168: "eBounceSelfPoint",
    169: "eOpenPlayerInfoRequest",
    170: "eOpenPlayerInfoResponse",
    171: "eEnterPlayerStart",
    172: "eEnterTongMap",
    173: "eCloseTongUI",
    174: "eEnvelopersAdd",
    175: "eEnvelopersOpen",
    176: "eEnvelopersOpenned",
    177: "eActivitiesListOpen",
    178: "eActivitiesListData",
    179: "ePropertiesFieldRequest",
    180: "eOtherPlayerProperties",
    181: "ePlayStateSpr",
    182: "eHandstrengthLocation",
    183: "eHandstrengthSkillId",
    184: "ePrivateFight",
    185: "ePrivateFightTarget",
    186: "eThrowItemRequest",
    187: "ePlayStateId",
    188: "eSelfRevertMap",
    189: "eSalesmanPricingRequest",
    190: "eSalesmanAddItem",
    191: "eSalesmanRemoveItem",
    192: "eSalesmanTakeItemRequest",
    193: "eSalesmanTakeMoneyRequest",
    194: "eSalesmanOpenStallRequest",
    195: "eSalesmanCloseStallRequest",
    196: "eSalesmanGetStallDataRequest",
    197: "eSalesmanGetStallDataResponse",
    198: "eSalesmanSetTitleRequest",
    199: "eSalesmanSetTitleResponse",
    200: "eSalesmanCloseUi",
    201: "eSalesmanOpenStallResponse",
    202: "eSalesmanCloseStallResponse",
    203: "eSalesmanTakeMoneyResponse",
    204: "ePlayerStallOpenRequest",
    205: "ePlayerStallOpenResponse",
    206: "ePlayerStallBuyItemRequest",
    207: "ePlayerStallBuyItemResponse",
    208: "eSendStorageMoney",
    209: "eItemJoin",
    210: "eTradeTargetDisconnect",
    211: "eManualEquipRequest",
    212: "eShopTypeThree",
    213: "eShopTypeThreeCurrentPoint",
    214: "ePlaySoundEffect",
    215: "eHotkeySkillList",
    216: "eHotkeySkillField",
    217: "eHotkeyRequest",
    218: "eHotkeyRemove2S",
    219: "eHotkeyRemove2C",
    220: "eFriendlyAddRequest",
    221: "eFriendlyAddNotify",
    222: "eFriendlyAddConfirm",
    223: "eFriendlyAddResponse",
    224: "eFriendlyRemoveRequest",
    225: "eFriendlyListingRequest",
    226: "eFriendlyListingResponse",
    227: "eHotkeyItemList",
    228: "eHotkeyItemRemoveAllRequest",
    229: "eHotkeyItemApplied",
    230: "eChatRemoveLogPlayerC",
    231: "eGotoNpc",
    232: "eClientCompleted",
    233: "eSyncItemDurability",
    234: "eAddMinistateKey",
    235: "eRemoveMinistateKey",
    236: "eDisconnected",
    237: "eChatRemoveLogChannel",
    238: "eDoSkillTargetPlayer",
    239: "eDoSkillTargetNpc",
    240: "eDoSkillTargetPosition",
    241: "eChatMessageWithItem",
    242: "eChatItemViewFalse",
    243: "eNextReconnectNoise",
    244: "eRemoveSkill",
    245: "eAwardSelectionAsk",
    246: "eAwardSelectionAnswer",
    247: "eAttention2Player",
    248: "eGotoPosition",
    249: "eOpenBagarate",
    250: "eLiveOptions",
    251: "eLiveMessage",
    252: "eOnlineAsking",
    253: "eOnlineAnswer",
    254: "eStorageLockState",
    255: "eStorageExtendCell",
    256: "eStorageEnterPasscode",
    257: "eStorageEnterLock",
    258: "eRankPlayerMoneyRequest",
    259: "eRankPlayerMoneyResponseField",
    260: "eRankPlayerFactionRequest",
    261: "eRankPlayerFactionResponseField",
    262: "eTargetToPlayerSpecial",
}


def lookup_opcode(msg_id):
    """Lookup opcode name from GS or MS table."""
    if msg_id in GS_OPCODES:
        return f"GS:{GS_OPCODES[msg_id]}"
    if msg_id in MS_OPCODES:
        return f"MS:{MS_OPCODES[msg_id]}"
    return f"UNKNOWN({msg_id})"


# ==================== PACKET ANALYSIS ====================

def analyze_protocol():
    """Analyze packet structure from captured binary data."""
    
    # Find latest capture files
    jsonl_files = sorted(CAPTURE_DIR.glob("il2cpp_capture_*.jsonl"), key=lambda f: f.stat().st_mtime)
    if not jsonl_files:
        print("No capture files!")
        return
    
    latest = jsonl_files[-1]
    print(f"Analyzing: {latest.name}")
    
    # Load all packets
    packets = []
    with open(latest, 'r', encoding='utf-8') as f:
        for line in f:
            try:
                packets.append(json.loads(line.strip()))
            except Exception:
                pass
    
    # Separate by connection
    sends = [p for p in packets if p.get('type') in ('SEND', 'SENDTO')]
    recvs = [p for p in packets if p.get('type') in ('RECV', 'RECVFROM')]
    
    print(f"\nTotal: {len(sends)} SEND, {len(recvs)} RECV")
    
    # ==================== ANALYZE RECV (Server→Client) ====================
    print("\n" + "="*70)
    print("RECV PROTOCOL ANALYSIS (Server → Client)")
    print("="*70)
    
    # Group recv by fd
    recv_by_fd = defaultdict(list)
    for p in recvs:
        recv_by_fd[p.get('fd')].append(p)
    
    for fd, pkts in sorted(recv_by_fd.items(), key=lambda x: -len(x[1])):
        print(f"\n--- fd={fd} ({len(pkts)} packets) ---")
        
        # Analyze headers
        sizes = Counter(p.get('size') for p in pkts)
        print(f"Size distribution: {dict(sizes.most_common(10))}")
        
        # Try to decode as game protocol
        for i, p in enumerate(pkts[:5]):
            hex_str = p.get('hex', '')
            if not hex_str:
                continue
            raw = bytes.fromhex(hex_str.replace(' ', ''))
            
            print(f"\n  Packet #{i+1} (size={p.get('size')}):")
            print(f"    Raw: {hex_str[:90]}...")
            
            # Protocol: "nysv" header (0x6e797376)
            if raw[:4] == b'nysv':
                print(f"    Header: nysv (keepalive/sync)")
                if len(raw) >= 16:
                    # Bytes 4-7: zeros
                    # Bytes 8-11: changing data (timestamp?)
                    # Bytes 12-13: 0xfe 0x07 = 2046 (little-endian) or 0x07fe
                    # Bytes 14-15: counter
                    ts_val = struct.unpack_from('<I', raw, 8)[0] if len(raw) >= 12 else 0
                    counter = struct.unpack_from('<H', raw, 14)[0] if len(raw) >= 16 else 0
                    print(f"    Timestamp/Seq: 0x{ts_val:08X}")
                    print(f"    Counter: {counter}")
            else:
                # Try to find message ID
                if len(raw) >= 4:
                    # Try different ID formats
                    id_le16 = struct.unpack_from('<H', raw, 0)[0] if len(raw) >= 2 else -1
                    id_le32 = struct.unpack_from('<I', raw, 0)[0] if len(raw) >= 4 else -1
                    id_be16 = struct.unpack_from('>H', raw, 0)[0] if len(raw) >= 2 else -1
                    
                    # Check if any ID maps to known opcode
                    for label, val in [("LE16", id_le16), ("LE32", id_le32), ("BE16", id_be16)]:
                        name = lookup_opcode(val)
                        if not name.startswith("UNKNOWN"):
                            print(f"    MsgID ({label}): {val} = {name}")
    
    # ==================== ANALYZE SEND (Client→Server) ====================
    print("\n" + "="*70)
    print("SEND PROTOCOL ANALYSIS (Client → Server)")
    print("="*70)
    
    send_by_fd = defaultdict(list)
    for p in sends:
        send_by_fd[p.get('fd')].append(p)
    
    for fd, pkts in sorted(send_by_fd.items(), key=lambda x: -len(x[1])):
        print(f"\n--- fd={fd} ({len(pkts)} packets) ---")
        
        sizes = Counter(p.get('size') for p in pkts)
        print(f"Size distribution: {dict(sizes.most_common(10))}")
        
        # Try to decode
        unique_packets = set()
        for i, p in enumerate(pkts[:20]):
            hex_str = p.get('hex', '')
            if not hex_str:
                continue
            
            # Deduplicate
            if hex_str in unique_packets:
                continue
            unique_packets.add(hex_str)
            
            raw = bytes.fromhex(hex_str.replace(' ', ''))
            print(f"\n  Packet (size={p.get('size')}):")
            print(f"    Raw: {hex_str[:90]}...")
            
            if len(raw) >= 4:
                id_le32 = struct.unpack_from('<I', raw, 0)[0]
                id_le16 = struct.unpack_from('<H', raw, 0)[0]
                
                print(f"    First 4 bytes LE32: {id_le32} (0x{id_le32:08X})")
                
                # Check known opcodes
                for offset in [0, 2, 4]:
                    if offset + 2 <= len(raw):
                        val = struct.unpack_from('<H', raw, offset)[0]
                        name = lookup_opcode(val)
                        if not name.startswith("UNKNOWN"):
                            print(f"    Opcode at offset {offset}: {val} = {name}")
    
    # ==================== LOOK FOR LARGER PACKETS ====================
    print("\n" + "="*70)
    print("INTERESTING PACKETS (size > 50 bytes)")
    print("="*70)
    
    large_pkts = [p for p in packets if p.get('size', 0) > 50 
                  and p.get('type') in ('SEND', 'SENDTO', 'RECV', 'RECVFROM')]
    large_pkts.sort(key=lambda x: x.get('size', 0), reverse=True)
    
    print(f"Found {len(large_pkts)} packets > 50 bytes")
    for i, p in enumerate(large_pkts[:30]):
        hex_str = p.get('hex', '')
        raw = bytes.fromhex(hex_str.replace(' ', '')) if hex_str else b''
        
        direction = "→" if p.get('type') in ('SEND', 'SENDTO') else "←"
        print(f"\n  {direction} {p.get('type')} fd={p.get('fd')} size={p.get('size')}")
        print(f"    {hex_str[:120]}...")
        
        # Try to decode
        if len(raw) >= 4:
            first4 = struct.unpack_from('<I', raw, 0)[0]
            if raw[:4] != b'nysv':
                # Not keepalive — try to identify opcode
                for off in range(0, min(8, len(raw)-1), 2):
                    val = struct.unpack_from('<H', raw, off)[0]
                    name = lookup_opcode(val)
                    if not name.startswith("UNKNOWN"):
                        print(f"    ** Opcode at offset {off}: {val} = {name}")
    
    print("\n" + "="*70)
    print("ANALYSIS COMPLETE")
    print("="*70)


if __name__ == '__main__':
    analyze_protocol()
