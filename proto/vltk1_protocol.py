"""
vltk1_protocol.py — Auto-generated VLTK1 Protocol Encoder/Decoder
Generated from Il2CppDumper dump.cs

Usage:
    from vltk1_protocol import encode_message, decode_message, GS_OPCODES, MS_OPCODES
"""
import struct

# ==================== OPCODES ====================

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

MS_OPCODES_REV = {v: k for k, v in MS_OPCODES.items()}

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
    136: "eTrainoffCheckRequet",
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
    173: "eCloseTongUi",
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

GS_OPCODES_REV = {v: k for k, v in GS_OPCODES.items()}


# ==================== MESSAGE DEFINITIONS ====================
# Each message: { 'fields': [(field_num, name, type)] }

MESSAGES = {
    "ActivitiesListData": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "title", "string"),
            (2, "list", "repeated ActivitiesListField"),
            (3, "currentTimeSeconds", "int64"),
        ]
    },
    "ActivitiesListField": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "timeStart", "int32"),
            (2, "totalSeconds", "int32"),
            (3, "title", "string"),
            (4, "description", "string"),
        ]
    },
    "AddMapObject": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "objectId", "string"),
            (2, "dataId", "int32"),
            (3, "mapId", "int32"),
            (4, "mapX", "int32"),
            (5, "mapY", "int32"),
            (6, "direction", "int32"),
            (7, "name", "string"),
            (8, "nameColor", "int32"),
            (9, "type", "int32"),
            (10, "remainingLifeFrame", "int32"),
            (11, "remainingDropFrame", "int32"),
        ]
    },
    "AddMinistateKey": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "key", "string"),
            (2, "lifetime", "int32"),
            (3, "source", "string"),
            (4, "description", "string"),
            (5, "iconSpritePath", "string"),
            (6, "iconSkillId", "int32"),
            (7, "iconItemMagicParticular", "int32"),
            (8, "isKeepOnDeath", "bool"),
        ]
    },
    "AddPropField": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "power", "int32"),
            (2, "inside", "int32"),
            (3, "outer", "int32"),
            (4, "agility", "int32"),
        ]
    },
    "AddSkillPoint": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "skillId", "int32"),
        ]
    },
    "AllMagicAttribResponse": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "list", "repeated MagicAttrib"),
        ]
    },
    "AnswerServerForString": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "id", "int32"),
            (2, "data", "string"),
        ]
    },
    "Any": {
        "namespace": "Google.Protobuf.WellKnownTypes",
        "fields": [
            (1, "typeUrl", "string"),
            (2, "value", "bytes"),
        ]
    },
    "ApplyAutoplayProfile": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "startAuto", "bool"),
            (2, "profile", "string"),
        ]
    },
    "AskClientForString": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "id", "int32"),
            (2, "title", "string"),
            (3, "desc", "string"),
            (4, "minlen", "int32"),
            (5, "maxlen", "int32"),
            (6, "openNumPad", "bool"),
        ]
    },
    "Attention2Player": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "message", "string"),
            (2, "isMsg2Player", "bool"),
            (3, "isTalk2Player", "bool"),
            (4, "isDialog2Player", "bool"),
        ]
    },
    "AutoEquipRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemId", "int32"),
            (2, "isEquip", "bool"),
        ]
    },
    "AwardSelectionAnswer": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "id", "int32"),
            (2, "selected", "int32"),
        ]
    },
    "AwardSelectionAsk": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "id", "int32"),
            (2, "description", "string"),
            (3, "selectionIcons", "repeated int32"),
        ]
    },
    "BounceSelfPoint": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "data", "string"),
            (2, "style", "int32"),
        ]
    },
    "CastSkill": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "launchType", "int32"),
            (2, "launchId", "string"),
            (3, "targetType", "int32"),
            (4, "targetId", "string"),
            (5, "targetPositionX", "int32"),
            (6, "targetPositionY", "int32"),
            (7, "skillId", "int32"),
            (8, "skillLevel", "int32"),
            (9, "isNoAction", "bool"),
        ]
    },
    "Character": {
        "namespace": "App",
        "fields": [
            (1, "cid", "string"),
            (2, "account", "string"),
            (3, "name", "string"),
            (4, "sex", "int32"),
            (5, "sect", "int32"),
            (6, "revivalOnLogin", "int32"),
            (7, "tongIdentify", "string"),
            (8, "bagarateMoney", "int64"),
            (9, "series", "int32"),
            (10, "teamId", "int32"),
            (11, "level", "int32"),
            (12, "exp", "int64"),
            (13, "power", "int32"),
            (14, "agility", "int32"),
            (15, "outer", "int32"),
            (16, "inside", "int32"),
            (17, "luck", "int32"),
            (18, "maxLife", "int32"),
            (19, "maxStamina", "int32"),
            (20, "maxInner", "int32"),
            (21, "leftProp", "int32"),
            (22, "leftFight", "int32"),
            (23, "fightMode", "int32"),
            (24, "armorRes", "int32"),
            (25, "weaponRes", "int32"),
            (26, "helmRes", "int32"),
            (27, "horseRes", "int32"),
            (28, "camp", "int32"),
            (29, "mapId", "int32"),
            (30, "mapX", "int32"),
            (31, "mapY", "int32"),
            (32, "curLife", "int32"),
            (33, "curInner", "int32"),
            (34, "curStamina", "int32"),
            (35, "worldRank", "int32"),
            (36, "storageCellMaximum", "int32"),
            (37, "bagarateCellMaximum", "int32"),
            (38, "pkStatus", "int32"),
            (39, "pkvalue", "int32"),
            (40, "tongIndex", "int32"),
            (41, "revivalMapId", "int32"),
            (42, "revivalMapX", "int32"),
            (43, "revivalMapY", "int32"),
            (44, "knb", "int32"),
            (45, "campCurrently", "int32"),
            (46, "runSpeed", "int32"),
            (47, "action", "int32"),
            (48, "direction", "int32"),
            (49, "attackSpeed", "int32"),
            (50, "castSpeed", "int32"),
            (51, "stateStature", "int32"),
            (52, "titleCurrently", "string"),
            (53, "storageMoney", "int64"),
            (54, "teamLatestId", "int32"),
            (55, "lastSavedTime", "int32"),
            (56, "expLimitCheck", "int32"),
            (57, "expLimitReceived", "int64"),
        ]
    },
    "CharacterRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
        ]
    },
    "ChatItemClick": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "targetChannel", "int32"),
            (2, "targetCid", "string"),
            (3, "targetName", "string"),
            (4, "targetItemId", "int32"),
            (5, "targetItemName", "string"),
        ]
    },
    "ChatItemView": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "ownedCid", "string"),
            (2, "ownedName", "string"),
            (3, "ownedItem", "Item"),
        ]
    },
    "ChatItemViewFalse": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "ownedCid", "string"),
            (2, "ownedName", "string"),
            (3, "itemName", "string"),
        ]
    },
    "ChatMessage": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "channel", "int32"),
            (2, "senderCid", "string"),
            (3, "senderName", "string"),
            (4, "message", "string"),
            (5, "item", "string"),
            (6, "receiver", "string"),
        ]
    },
    "ChatMessageWithItem": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "message", "ChatMessage"),
            (2, "item", "Item"),
        ]
    },
    "ChatRemoveLogChannel": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "channel", "int32"),
        ]
    },
    "ChatRemoveLogPlayerC": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "channel", "int32"),
            (2, "playerCid", "string"),
            (3, "playerName", "string"),
        ]
    },
    "ChatSend": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "channel", "int32"),
            (2, "message", "string"),
            (3, "item", "string"),
            (4, "receiver", "string"),
            (5, "autoreply", "string"),
            (6, "isautoplay", "bool"),
        ]
    },
    "ContextDesSelect": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "selectIndex", "int32"),
        ]
    },
    "ContextDescription": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "contentPage", "repeated string"),
            (2, "selections", "repeated string"),
            (3, "widthPercent", "int32"),
            (4, "heightPercent", "int32"),
            (5, "backgroundPadding", "int32"),
            (6, "fadeSeconds", "int32"),
            (7, "title", "string"),
            (8, "backgroundAlphaPercent", "int32"),
        ]
    },
    "Delivered": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "token", "string"),
        ]
    },
    "DescriptorProto": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "name", "string"),
            (2, "field", "repeated FieldDescriptorProto"),
            (3, "extension", "repeated FieldDescriptorProto"),
            (4, "nestedType", "repeated DescriptorProto"),
            (5, "enumType", "repeated EnumDescriptorProto"),
            (6, "oneofDecl", "repeated OneofDescriptorProto"),
            (7, "options", "MessageOptions"),
            (8, "reservedName", "repeated string"),
            (9, "visibility", "SymbolVisibility"),
        ]
    },
    "DoSkillTargetNpc": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "skillid", "int32"),
            (2, "nid", "string"),
        ]
    },
    "DoSkillTargetPlayer": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "skillid", "int32"),
            (2, "cid", "string"),
        ]
    },
    "DoSkillTargetPosition": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "skillid", "int32"),
            (2, "positionX", "int32"),
            (3, "positionY", "int32"),
        ]
    },
    "Duration": {
        "namespace": "Google.Protobuf.WellKnownTypes",
        "fields": [
            (1, "seconds", "int64"),
            (2, "nanos", "int32"),
        ]
    },
    "EnterGameServer": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "mapId", "int32"),
            (2, "mapX", "int32"),
            (3, "mapY", "int32"),
            (4, "serverIp", "string"),
            (5, "serverPort", "int32"),
            (6, "token", "string"),
        ]
    },
    "EnterMap": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "mapId", "int32"),
            (2, "mapX", "int32"),
            (3, "mapY", "int32"),
        ]
    },
    "EnterPlayerStart": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "mapId", "int32"),
            (2, "mapX", "int32"),
            (3, "mapY", "int32"),
        ]
    },
    "Enum": {
        "namespace": "Google.Protobuf.WellKnownTypes",
        "fields": [
            (1, "name", "string"),
            (2, "enumvalue", "repeated EnumValue"),
            (3, "options", "repeated Option"),
            (4, "sourceContext", "SourceContext"),
            (5, "syntax", "Syntax"),
            (6, "edition", "string"),
        ]
    },
    "EnumDescriptorProto": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "name", "string"),
            (2, "value", "repeated EnumValueDescriptorProto"),
            (3, "options", "EnumOptions"),
            (4, "reservedName", "repeated string"),
            (5, "visibility", "SymbolVisibility"),
        ]
    },
    "EnumOptions": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "allowAlias", "bool"),
            (2, "deprecated", "bool"),
            (3, "deprecatedLegacyJsonFieldConflicts", "bool"),
            (4, "features", "FeatureSet"),
            (5, "uninterpretedOption", "repeated UninterpretedOption"),
        ]
    },
    "EnumValue": {
        "namespace": "Google.Protobuf.WellKnownTypes",
        "fields": [
            (1, "name", "string"),
            (2, "number", "int32"),
            (3, "options", "repeated Option"),
        ]
    },
    "EnumValueDescriptorProto": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "name", "string"),
            (2, "number", "int32"),
            (3, "options", "EnumValueOptions"),
        ]
    },
    "EnumValueOptions": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "deprecated", "bool"),
            (2, "features", "FeatureSet"),
            (3, "debugRedact", "bool"),
            (4, "uninterpretedOption", "repeated UninterpretedOption"),
        ]
    },
    "EnvelopersAdd": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "id", "int32"),
            (2, "title", "string"),
        ]
    },
    "EnvelopersOpen": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "id", "int32"),
        ]
    },
    "EnvelopersOpenned": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "id", "int32"),
            (2, "description", "string"),
            (3, "itemimage", "repeated string"),
        ]
    },
    "ExtensionRangeOptions": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "uninterpretedOption", "repeated UninterpretedOption"),
            (2, "features", "FeatureSet"),
        ]
    },
    "FeatureSetDefaults": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "minimumEdition", "Edition"),
            (2, "maximumEdition", "Edition"),
        ]
    },
    "Field": {
        "namespace": "Google.Protobuf.WellKnownTypes",
        "fields": [
            (1, "number", "int32"),
            (2, "name", "string"),
            (3, "typeUrl", "string"),
            (4, "oneofIndex", "int32"),
            (5, "packed", "bool"),
            (6, "options", "repeated Option"),
            (7, "jsonName", "string"),
            (8, "defaultValue", "string"),
        ]
    },
    "FieldDescriptorProto": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "name", "string"),
            (2, "number", "int32"),
            (3, "typeName", "string"),
            (4, "extendee", "string"),
            (5, "defaultValue", "string"),
            (6, "oneofIndex", "int32"),
            (7, "jsonName", "string"),
            (8, "options", "FieldOptions"),
            (9, "proto3Optional", "bool"),
        ]
    },
    "FieldMask": {
        "namespace": "Google.Protobuf.WellKnownTypes",
        "fields": [
            (1, "paths", "repeated string"),
        ]
    },
    "FieldOptions": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "packed", "bool"),
            (2, "lazy", "bool"),
            (3, "unverifiedLazy", "bool"),
            (4, "deprecated", "bool"),
            (5, "weak", "bool"),
            (6, "debugRedact", "bool"),
            (7, "features", "FeatureSet"),
            (8, "uninterpretedOption", "repeated UninterpretedOption"),
        ]
    },
    "FileDescriptorProto": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "name", "string"),
            (2, "package", "string"),
            (3, "dependency", "repeated string"),
            (4, "publicDependency", "repeated int32"),
            (5, "weakDependency", "repeated int32"),
            (6, "optionDependency", "repeated string"),
            (7, "messageType", "repeated DescriptorProto"),
            (8, "enumType", "repeated EnumDescriptorProto"),
            (9, "service", "repeated ServiceDescriptorProto"),
            (10, "extension", "repeated FieldDescriptorProto"),
            (11, "options", "FileOptions"),
            (12, "sourceCodeInfo", "SourceCodeInfo"),
            (13, "syntax", "string"),
            (14, "edition", "Edition"),
        ]
    },
    "FileDescriptorSet": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "file", "repeated FileDescriptorProto"),
        ]
    },
    "FileOptions": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "javaPackage", "string"),
            (2, "javaOuterClassname", "string"),
            (3, "javaMultipleFiles", "bool"),
            (4, "javaGenerateEqualsAndHash", "bool"),
            (5, "javaStringCheckUtf8", "bool"),
            (6, "goPackage", "string"),
            (7, "ccGenericServices", "bool"),
            (8, "javaGenericServices", "bool"),
            (9, "pyGenericServices", "bool"),
            (10, "deprecated", "bool"),
            (11, "ccEnableArenas", "bool"),
            (12, "objcClassPrefix", "string"),
            (13, "csharpNamespace", "string"),
            (14, "swiftPrefix", "string"),
            (15, "phpClassPrefix", "string"),
            (16, "phpNamespace", "string"),
            (17, "phpMetadataNamespace", "string"),
            (18, "rubyPackage", "string"),
            (19, "features", "FeatureSet"),
            (20, "uninterpretedOption", "repeated UninterpretedOption"),
        ]
    },
    "FriendlyAddConfirm": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "targetCid", "string"),
            (2, "isAccepted", "bool"),
        ]
    },
    "FriendlyAddNotify": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "requestCid", "string"),
            (2, "name", "string"),
            (3, "level", "int32"),
            (4, "faction", "int32"),
        ]
    },
    "FriendlyAddRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "targetCid", "string"),
        ]
    },
    "FriendlyAddResponse": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "isAccepted", "bool"),
            (2, "cid", "string"),
            (3, "name", "string"),
        ]
    },
    "FriendlyListingField": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
            (2, "name", "string"),
            (3, "isOnline", "bool"),
        ]
    },
    "FriendlyListingRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "listType", "int32"),
        ]
    },
    "FriendlyListingResponse": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "listing", "repeated FriendlyListingField"),
        ]
    },
    "FriendlyRemoveRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
        ]
    },
    "GiveBoxOpen": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "title", "string"),
            (2, "description", "string"),
        ]
    },
    "GiveBoxRemove": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemId", "string"),
        ]
    },
    "GiveBoxSend": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemId", "string"),
        ]
    },
    "GotoNpc": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "npcName", "repeated string"),
            (2, "data", "int32"),
        ]
    },
    "GotoPosition": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "mapx", "int32"),
            (2, "mapy", "int32"),
        ]
    },
    "HandstrengthLocation": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "skillLocation", "int32"),
        ]
    },
    "HandstrengthSkillId": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "skillId", "int32"),
            (2, "withDebug", "bool"),
        ]
    },
    "HotkeyItemApplied": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "index", "int32"),
            (2, "data", "int32"),
        ]
    },
    "HotkeyItemDatabase": {
        "namespace": "App",
        "fields": [
            (1, "cid", "string"),
            (2, "list", "repeated int32"),
        ]
    },
    "HotkeyItemList": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "data", "HotkeyItemDatabase"),
        ]
    },
    "HotkeyRemove2C": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "skillId", "int32"),
        ]
    },
    "HotkeyRemove2S": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "skillId", "int32"),
        ]
    },
    "HotkeyRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "hotkeyId", "int32"),
            (2, "skillId", "int32"),
            (3, "dirFunc", "int32"),
            (4, "control", "int32"),
            (5, "target", "int32"),
            (6, "showDirImage", "int32"),
        ]
    },
    "HotkeySkillField": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "data", "int32"),
        ]
    },
    "HotkeySkillList": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "listing", "repeated int32"),
        ]
    },
    "IsSittingDown": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "value", "bool"),
        ]
    },
    "Item": {
        "namespace": "App",
        "fields": [
            (1, "identify", "int32"),
            (2, "rowIndexAndType", "int32"),
            (3, "detailAndGenre", "int32"),
            (4, "particularAndLevel", "int32"),
            (5, "stackAndSeries", "int32"),
            (6, "durabilityAndLockState", "int32"),
            (7, "createTimestampSeconds", "int64"),
            (8, "sourceCid", "string"),
            (9, "sourceName", "string"),
            (10, "state", "repeated int64"),
            (11, "magic", "repeated int32"),
        ]
    },
    "ItemJoin": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemIndex", "int32"),
        ]
    },
    "ItemLocationRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemIndex", "int32"),
            (2, "itemLocation", "int32"),
        ]
    },
    "JumToMap": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "mapId", "int32"),
        ]
    },
    "ListValue": {
        "namespace": "Google.Protobuf.WellKnownTypes",
        "fields": [
            (1, "values", "repeated Value"),
        ]
    },
    "LiveOptions": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "overGsvMessageSeconds", "int32"),
            (2, "silentReconnectCount", "int32"),
            (3, "reconnectSecondsTimeout", "int32"),
            (4, "isReconnectRandomType", "bool"),
        ]
    },
    "LocalNews": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "news", "string"),
            (2, "times", "int32"),
        ]
    },
    "MSPasscode": {
        "namespace": "App",
        "fields": [
            (1, "passcode", "int32"),
        ]
    },
    "MSUnityCreateCharacterRequest": {
        "namespace": "App",
        "fields": [
            (1, "data", "string"),
            (2, "factionId", "int32"),
            (3, "name", "string"),
            (4, "sex", "int32"),
        ]
    },
    "MSUnityCreateCharacterResponse": {
        "namespace": "App",
        "fields": [
            (1, "isOk", "bool"),
            (2, "message", "string"),
        ]
    },
    "MSUnityEntergameRequest": {
        "namespace": "App",
        "fields": [
            (1, "resourceVersion", "int32"),
            (2, "protocolVersion", "int32"),
        ]
    },
    "MSUnityEntergameResponse": {
        "namespace": "App",
        "fields": [
            (1, "serverIp", "string"),
            (2, "serverPort", "int32"),
            (3, "loginCode", "string"),
            (4, "cid", "string"),
        ]
    },
    "MSUnityLoginQueueStart": {
        "namespace": "App",
        "fields": [
            (1, "orderNumber", "int32"),
        ]
    },
    "MSUnityLoginRequest": {
        "namespace": "App",
        "fields": [
            (1, "account", "string"),
            (2, "password", "string"),
        ]
    },
    "MSUnityLoginResponse": {
        "namespace": "App",
        "fields": [
            (1, "isOk", "bool"),
            (2, "haveCharacter", "bool"),
            (3, "message", "string"),
        ]
    },
    "MSUnityRegisterFields": {
        "namespace": "App",
        "fields": [
            (1, "data", "string"),
        ]
    },
    "MSUnityRegisterRequest": {
        "namespace": "App",
        "fields": [
            (1, "account", "string"),
            (2, "password", "string"),
        ]
    },
    "MSUnityRegisterResponse": {
        "namespace": "App",
        "fields": [
            (1, "isOk", "bool"),
            (2, "account", "string"),
            (3, "message", "string"),
        ]
    },
    "MagicAttrib": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "type", "string"),
            (2, "values", "repeated int32"),
        ]
    },
    "ManualEquipRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemindex", "int32"),
            (2, "place", "int32"),
        ]
    },
    "MapDialogNpc": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "name", "string"),
            (2, "mapX", "int32"),
            (3, "mapY", "int32"),
        ]
    },
    "MapDialogNpcListRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "mapId", "int32"),
        ]
    },
    "MapDialogNpcListResponse": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "mapId", "int32"),
            (2, "list", "repeated MapDialogNpc"),
        ]
    },
    "MapRegionObstacle": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "x", "int32"),
            (2, "y", "int32"),
            (3, "v", "int32"),
            (4, "h", "int32"),
            (5, "data", "repeated string"),
        ]
    },
    "MapRegionTrap": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "nx", "int32"),
            (2, "ny", "int32"),
            (3, "grid", "repeated string"),
        ]
    },
    "MapRegionTrapOpen": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "open", "bool"),
        ]
    },
    "MessageOptions": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "messageSetWireFormat", "bool"),
            (2, "noStandardDescriptorAccessor", "bool"),
            (3, "deprecated", "bool"),
            (4, "mapEntry", "bool"),
            (5, "deprecatedLegacyJsonFieldConflicts", "bool"),
            (6, "features", "FeatureSet"),
            (7, "uninterpretedOption", "repeated UninterpretedOption"),
        ]
    },
    "MethodDescriptorProto": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "name", "string"),
            (2, "inputType", "string"),
            (3, "outputType", "string"),
            (4, "options", "MethodOptions"),
            (5, "clientStreaming", "bool"),
            (6, "serverStreaming", "bool"),
        ]
    },
    "MethodOptions": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "deprecated", "bool"),
            (2, "features", "FeatureSet"),
            (3, "uninterpretedOption", "repeated UninterpretedOption"),
        ]
    },
    "NpcAttack": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "uuid", "string"),
            (2, "cid", "string"),
            (3, "sid", "int32"),
            (4, "slv", "int32"),
            (5, "damage", "int32"),
        ]
    },
    "NpcDebug": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "uuid", "string"),
            (2, "mapX", "int32"),
            (3, "mapY", "int32"),
            (4, "direction", "int32"),
            (5, "name", "string"),
        ]
    },
    "NpcDialogue": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "npcId", "string"),
        ]
    },
    "NpcSelectMessage": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "selectIndex", "int32"),
        ]
    },
    "NpcTransferMessage": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "title", "string"),
            (2, "selections", "repeated string"),
        ]
    },
    "ObjectPickup": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "objectId", "string"),
        ]
    },
    "OneofDescriptorProto": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "name", "string"),
            (2, "options", "OneofOptions"),
        ]
    },
    "OneofOptions": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "features", "FeatureSet"),
            (2, "uninterpretedOption", "repeated UninterpretedOption"),
        ]
    },
    "OpenPlayerInfoRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "targetCid", "string"),
        ]
    },
    "OpenPlayerInfoResponse": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "properties", "OtherPlayerProperties"),
            (2, "items", "repeated Item"),
        ]
    },
    "OpenSaveBox": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "data", "int32"),
        ]
    },
    "Option": {
        "namespace": "Google.Protobuf.WellKnownTypes",
        "fields": [
            (1, "name", "string"),
            (2, "value", "Any"),
        ]
    },
    "OtherPlayerProperties": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "rank", "int32"),
            (2, "name", "string"),
            (3, "cid", "string"),
            (4, "faction", "int32"),
            (5, "isGirl", "bool"),
            (6, "level", "int32"),
            (7, "pk", "int32"),
        ]
    },
    "PartyCaptain": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
            (2, "maxTeamSize", "int32"),
        ]
    },
    "PartyData": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "name", "string"),
            (2, "level", "int32"),
            (3, "faction", "int32"),
            (4, "teamId", "int32"),
            (5, "memCount", "int32"),
            (6, "type", "int32"),
        ]
    },
    "PartyInvite": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "party", "PartyData"),
            (2, "captainCid", "string"),
        ]
    },
    "PartyJoin": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
            (2, "name", "string"),
            (3, "level", "int32"),
            (4, "faction", "int32"),
            (5, "teamId", "int32"),
            (6, "curHP", "int32"),
            (7, "maxHp", "int32"),
        ]
    },
    "PartyNearest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "list", "repeated PartyData"),
        ]
    },
    "PartyOut": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
        ]
    },
    "PartyRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
            (2, "name", "string"),
            (3, "level", "int32"),
            (4, "faction", "int32"),
        ]
    },
    "PartySelfAccept": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "teamId", "int32"),
        ]
    },
    "PartySelfCaptain": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
        ]
    },
    "PartySelfConfirm": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
        ]
    },
    "PartySelfCreate": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "type", "int32"),
        ]
    },
    "PartySelfInvite": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
        ]
    },
    "PartySelfJoin": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "teamId", "int32"),
            (2, "cidMemberOfTeam", "string"),
        ]
    },
    "PartySelfKick": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
        ]
    },
    "PartySelfUnaccept": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "teamId", "int32"),
        ]
    },
    "PartySelfUnconfirm": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
        ]
    },
    "PartySync": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
            (2, "perLife", "int32"),
        ]
    },
    "Passcode": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "code", "int32"),
        ]
    },
    "PlaySoundEffect": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "name", "string"),
        ]
    },
    "PlayStateId": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
            (2, "stateid", "int32"),
            (3, "looptimes", "int32"),
        ]
    },
    "PlayStateSpr": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
            (2, "sprPath", "string"),
            (3, "looptimes", "int32"),
        ]
    },
    "PlayerLoginRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "loginCode", "string"),
            (2, "cid", "string"),
        ]
    },
    "PlayerLoginResponse": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "isOk", "bool"),
            (2, "msg", "string"),
            (3, "mapId", "int32"),
            (4, "mapX", "int32"),
            (5, "mapY", "int32"),
        ]
    },
    "PlayerStallBuyItemRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "stallCid", "string"),
            (2, "stallIndex", "int32"),
            (3, "itemIndex", "int32"),
            (4, "itemMoney", "int32"),
            (5, "itemKnb", "int32"),
        ]
    },
    "PlayerStallBuyItemResponse": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "isOk", "bool"),
            (2, "itemIndex", "int32"),
        ]
    },
    "PlayerStallOpenRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "stallKey", "string"),
        ]
    },
    "PlayerStallOpenResponse": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "playerCid", "string"),
            (2, "stallIndex", "int32"),
        ]
    },
    "PlayerTalk": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "message", "string"),
        ]
    },
    "PlayerUseItem": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemindex", "int32"),
        ]
    },
    "PrivateFight": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "targetCid", "string"),
        ]
    },
    "PrivateFightTarget": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "targetCid", "string"),
            (2, "targetName", "string"),
        ]
    },
    "QuestClick": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "key", "string"),
        ]
    },
    "QuestComplete": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "k", "string"),
        ]
    },
    "QuestInfo": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "k", "string"),
            (2, "t", "string"),
            (3, "c", "string"),
        ]
    },
    "QuestLimit": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "info", "QuestInfo"),
            (2, "displayTime", "int32"),
        ]
    },
    "QuestLock": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "key", "string"),
            (2, "sendclick", "bool"),
            (3, "minimize", "bool"),
        ]
    },
    "RankPlayerFactionRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "factionId", "int32"),
        ]
    },
    "RankPlayerFactionResponseField": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "rank", "int32"),
            (2, "level", "int32"),
            (3, "name", "string"),
            (4, "exp", "int64"),
            (5, "faction", "int32"),
        ]
    },
    "RankPlayerLevelRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "page", "int32"),
        ]
    },
    "RankPlayerLevelResponseField": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "rank", "int32"),
            (2, "name", "string"),
            (3, "level", "int32"),
            (4, "exp", "int64"),
        ]
    },
    "RankPlayerMoneyResponseField": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "rank", "int32"),
            (2, "name", "string"),
            (3, "money", "string"),
        ]
    },
    "RemoveItemRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemIndex", "int32"),
        ]
    },
    "RemoveItemRespone": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemIndex", "int32"),
        ]
    },
    "RemoveMinistateKey": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "key", "string"),
        ]
    },
    "RemoveSkill": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "skillid", "int32"),
        ]
    },
    "SalesmanAddItem": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemIndexInBagarate", "int32"),
            (2, "money", "int32"),
            (3, "knb", "int32"),
            (4, "stallIndex", "int32"),
        ]
    },
    "SalesmanCloseStallRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "stallIndex", "int32"),
        ]
    },
    "SalesmanCloseStallResponse": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "isOk", "bool"),
        ]
    },
    "SalesmanGetStallDataRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "stallIndex", "int32"),
        ]
    },
    "SalesmanGetStallDataResponse": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "title", "string"),
            (2, "availableMoney", "int64"),
            (3, "availableKnb", "int64"),
        ]
    },
    "SalesmanItem": {
        "namespace": "App",
        "fields": [
            (1, "item", "Item"),
            (2, "money", "int32"),
            (3, "knb", "int32"),
        ]
    },
    "SalesmanOpenStallRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "stallIndex", "int32"),
        ]
    },
    "SalesmanOpenStallResponse": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "stallIndex", "int32"),
            (2, "isOk", "bool"),
        ]
    },
    "SalesmanPricingRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemIndexInBagarate", "int32"),
            (2, "money", "int32"),
            (3, "knb", "int32"),
            (4, "stallIndex", "int32"),
        ]
    },
    "SalesmanRemoveItem": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemIndexInBagarate", "int32"),
            (2, "stallIndex", "int32"),
        ]
    },
    "SalesmanSetTitleRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "stallIndex", "int32"),
            (2, "title", "string"),
        ]
    },
    "SalesmanSetTitleResponse": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "stallIndex", "int32"),
            (2, "title", "string"),
        ]
    },
    "SalesmanTakeItemRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemIndexInBagarate", "int32"),
            (2, "stallIndex", "int32"),
        ]
    },
    "SalesmanTakeMoneyRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "stallIndex", "int32"),
        ]
    },
    "SalesmanTakeMoneyResponse": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "isOk", "bool"),
        ]
    },
    "SendStorageMoney": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "moneyToStorage", "int64"),
        ]
    },
    "ServiceDescriptorProto": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "name", "string"),
            (2, "method", "repeated MethodDescriptorProto"),
            (3, "options", "ServiceOptions"),
        ]
    },
    "ServiceOptions": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "features", "FeatureSet"),
            (2, "deprecated", "bool"),
            (3, "uninterpretedOption", "repeated UninterpretedOption"),
        ]
    },
    "SetPkState": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "state", "int32"),
        ]
    },
    "SetRiding": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "riding", "bool"),
        ]
    },
    "ShopBuyItem": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "shopkey", "string"),
            (2, "itemindex", "int32"),
            (3, "quantity", "int32"),
        ]
    },
    "ShopData": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "shopkey", "string"),
            (2, "shopname", "string"),
            (3, "costtype", "int32"),
        ]
    },
    "ShopItem": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cost", "int64"),
            (2, "lockstate", "int32"),
            (3, "lockseconds", "int32"),
            (4, "expireseconds", "int32"),
            (5, "gold", "int32"),
            (6, "genre", "int32"),
            (7, "detail", "int32"),
            (8, "particular", "int32"),
            (9, "level", "int32"),
            (10, "series", "int32"),
        ]
    },
    "ShopSellItem": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemid", "int32"),
        ]
    },
    "ShopTypeOne": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "data", "ShopData"),
        ]
    },
    "ShopTypeThree": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "leftPoint", "int64"),
            (2, "data", "ShopData"),
            (3, "pointName", "string"),
        ]
    },
    "ShopTypeThreeCurrentPoint": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "leftPoint", "int64"),
            (2, "pointName", "string"),
        ]
    },
    "ShopTypeTwo": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "list", "repeated ShopData"),
        ]
    },
    "Skill": {
        "namespace": "App",
        "fields": [
            (1, "id", "int32"),
            (2, "level", "int32"),
            (3, "exp", "int64"),
            (4, "tempEnhancedPoint", "int32"),
        ]
    },
    "SourceContext": {
        "namespace": "Google.Protobuf.WellKnownTypes",
        "fields": [
            (1, "fileName", "string"),
        ]
    },
    "StateMagic": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "parentSkillId", "int32"),
            (2, "skillId", "int32"),
            (3, "skillLevel", "int32"),
            (4, "stateId", "int32"),
            (5, "leftTime", "int32"),
            (6, "magics", "repeated MagicAttrib"),
        ]
    },
    "StorageExtendCell": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "isLocked", "bool"),
            (2, "extend1CellMaximum", "int32"),
            (3, "extend2CellMaximum", "int32"),
            (4, "extend3CellMaximum", "int32"),
            (5, "extend4CellMaximum", "int32"),
        ]
    },
    "StorageLockState": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "isLocked", "bool"),
        ]
    },
    "SyncItemDurability": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemindex", "int32"),
            (2, "durabilityCurrently", "int32"),
        ]
    },
    "TargetToPlayerSpecial": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
        ]
    },
    "ThrowItemRequest": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemindex", "int32"),
        ]
    },
    "Timestamp": {
        "namespace": "Google.Protobuf.WellKnownTypes",
        "fields": [
            (1, "seconds", "int64"),
            (2, "nanos", "int32"),
        ]
    },
    "TongMember": {
        "namespace": "App",
        "fields": [
            (1, "cid", "string"),
            (2, "name", "string"),
            (3, "figure", "int32"),
            (4, "title", "string"),
            (5, "isOnline", "bool"),
            (6, "level", "int32"),
            (7, "sect", "int32"),
        ]
    },
    "TongOverview": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "tongName", "string"),
            (2, "masterName", "string"),
            (3, "memCount", "int32"),
            (4, "memLimit", "int32"),
            (5, "camp", "int32"),
            (6, "note", "string"),
        ]
    },
    "TongRequestField": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
            (2, "name", "string"),
            (3, "faction", "int32"),
            (4, "level", "int32"),
        ]
    },
    "TongSelfMemberFigure": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "targetCid", "string"),
        ]
    },
    "TongSelfMemberKick": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "targetCid", "string"),
        ]
    },
    "TongSelfMemberTitle": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "targetCid", "string"),
        ]
    },
    "TongSelfRequestAccept": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "targetCid", "string"),
        ]
    },
    "TongSelfRequestReject": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "targetCid", "string"),
        ]
    },
    "TongSelfRequestSend": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "targetTongId", "int32"),
        ]
    },
    "TongTongField": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "id", "int32"),
            (2, "name", "string"),
            (3, "level", "int32"),
            (4, "memCount", "int32"),
            (5, "memLimit", "int32"),
            (6, "master", "string"),
            (7, "note", "string"),
            (8, "camp", "int32"),
        ]
    },
    "TradeInviteAccept": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
        ]
    },
    "TradeInviteToCli": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
            (2, "name", "string"),
            (3, "tongname", "string"),
            (4, "level", "int32"),
            (5, "faction", "int32"),
        ]
    },
    "TradeInviteToGsv": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
        ]
    },
    "TradeProcessRefundItem": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemid", "int32"),
        ]
    },
    "TradeProcessRefundItemDestinate": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemid", "int32"),
        ]
    },
    "TradeProcessRefundItemSource": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemid", "int32"),
        ]
    },
    "TradeProcessSendCashToAdd": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cash", "int64"),
        ]
    },
    "TradeProcessSendCashToGsv": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cash", "int64"),
        ]
    },
    "TradeProcessSendCashToRemove": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cash", "int64"),
        ]
    },
    "TradeProcessSendItemToAdd": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "item", "Item"),
        ]
    },
    "TradeProcessSendItemToGsv": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemid", "int32"),
        ]
    },
    "TradeProcessSendItemToRemove": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemid", "int32"),
        ]
    },
    "TradeStart": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "cid", "string"),
            (2, "name", "string"),
            (3, "tongname", "string"),
            (4, "level", "int32"),
            (5, "faction", "int32"),
        ]
    },
    "TrainoffCheckRequet": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "autoplayIsOpen", "bool"),
        ]
    },
    "TrainoffCheckResponse": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "description", "string"),
            (2, "enterAllowed", "bool"),
            (3, "enterLabel", "string"),
            (4, "autoplayAllowed", "bool"),
        ]
    },
    "TrainoffStart": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "autoplayProfile", "string"),
        ]
    },
    "Type": {
        "namespace": "Google.Protobuf.WellKnownTypes",
        "fields": [
            (1, "name", "string"),
            (2, "fields", "repeated Field"),
            (3, "oneofs", "repeated string"),
            (4, "options", "repeated Option"),
            (5, "sourceContext", "SourceContext"),
            (6, "syntax", "Syntax"),
            (7, "edition", "string"),
        ]
    },
    "UninterpretedOption": {
        "namespace": "Google.Protobuf.Reflection",
        "fields": [
            (1, "identifierValue", "string"),
            (2, "positiveIntValue", "uint64"),
            (3, "negativeIntValue", "int64"),
            (4, "doubleValue", "double"),
            (5, "stringValue", "bytes"),
            (6, "aggregateValue", "string"),
        ]
    },
    "UnmergeItem": {
        "namespace": "GameServer.Network.Protocol",
        "fields": [
            (1, "itemIndex", "int32"),
            (2, "count", "int32"),
        ]
    },
    "Value": {
        "namespace": "Google.Protobuf.WellKnownTypes",
        "fields": [
            (1, "kind", "object"),
        ]
    },
}


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
    return result or b"\x00"


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
    print("\n=== MS Opcodes ===")
    for oid, name in sorted(MS_OPCODES.items()):
        print(f"  {oid:3d} = {name}")
    print("\n=== GS Opcodes ===")
    for oid, name in sorted(GS_OPCODES.items()):
        print(f"  {oid:3d} = {name}")
