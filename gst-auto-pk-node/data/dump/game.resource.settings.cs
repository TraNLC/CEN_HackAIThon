// Image 0: mscorlib.dll - 0
// Image 1: Assembly-CSharp.dll - 1689
// Image 2: System.Xml.dll - 3042
// Image 3: System.dll - 3711
// Image 4: System.Data.dll - 4409
// Image 5: Google.Protocol.dll - 4647
// Image 6: Unity.TextMeshPro.dll - 5135
// Image 7: System.Core.dll - 5332
// Image 8: Newtonsoft.Json.dll - 5981
// Image 9: Google.Protobuf.dll - 6286
// Image 10: UnityEngine.CoreModule.dll - 6582
// Image 11: UnityEngine.UI.dll - 7226
// Image 12: UnityEngine.TextCoreTextEngineModule.dll - 7421
// Image 13: Mono.Security.dll - 7515
// Image 14: UnityEngine.AndroidJNIModule.dll - 7600
// Image 15: System.IO.Compression.dll - 7645
// Image 16: I18N.West.dll - 7705
// Image 17: UnityEngine.IMGUIModule.dll - 7739
// Image 18: System.Drawing.dll - 7776
// Image 19: UnityEngine.TextCoreFontEngineModule.dll - 7787
// Image 20: I18N.dll - 7812
// Image 21: System.Numerics.dll - 7825
// Image 22: System.Xml.Linq.dll - 7838
// Image 23: UnityEngine.PropertiesModule.dll - 7876
// Image 24: UnityEngine.dll - 7934
// Image 25: deml.netcore-networking.dll - 7935
// Image 26: UnityEngine.UnityWebRequestModule.dll - 7949
// Image 27: UnityEngine.UIModule.dll - 7968
// Image 28: UnityEngine.AnimationModule.dll - 7979
// Image 29: UnityEngine.TextRenderingModule.dll - 8011
// Image 30: UnityEngine.Physics2DModule.dll - 8025
// Image 31: UnityEngine.InputLegacyModule.dll - 8035
// Image 32: UnityEngine.AudioModule.dll - 8046
// Image 33: UnityEngine.SharedInternalsModule.dll - 8065
// Image 34: UnityEngine.AssetBundleModule.dll - 8093
// Image 35: UnityEngine.ImageConversionModule.dll - 8099
// Image 36: UnityEngine.AIModule.dll - 8101
// Image 37: UnityEngine.SpriteShapeModule.dll - 8104
// Image 38: System.IO.Compression.FileSystem.dll - 8106
// Image 39: CandyCoded.HapticFeedback.Android.dll - 8110
// Image 40: System.Runtime.Serialization.dll - 8118
// Image 41: CandyCoded.HapticFeedback.dll - 8123
// Image 42: System.Runtime.CompilerServices.Unsafe.dll - 8131
// Image 43: System.Configuration.dll - 8134
// Image 44: __Generated - 8144

// Namespace: game.resource.settings
public class Multicellular // TypeDefIndex: 2209
{
	// Fields
	public static Color ItemGoldBorderLayer1Color; // 0x0
	public static Color ItemGoldBorderLayer2Color; // 0x10
	public static Color ItemGoldBorderLayer3Color; // 0x20
	public static int ItemGoldBorderLayer2Interval; // 0x30
	public static int ItemGoldBorderLayer1Thinkness; // 0x34
	public static int ItemGoldBorderLayer2Thinkness; // 0x38
	public static int ItemGoldBorderLayer3Thinkness; // 0x3C
	public static int ClickPlayerBeaweenDownAndUpLimitTime; // 0x40
	public static int Logo18AllowToHide; // 0x44
	public static int Logo18RoutineSecondsHide; // 0x48
	public static int Logo18RoutineSecondsLive; // 0x4C
	public static int MissileSoundNextActiveSameFileName; // 0x50
	public static int MissileSoundPlayingCurrentlyFiles; // 0x54
	public static int MissileConcurrentDisplayedMaximum; // 0x58
	public static int PlayerActionSoundPlayingCurrentlyFiles; // 0x5C
	public static int SpriteLimitMBCacheNpc; // 0x60
	public static int SpriteLimitMBCacheSkill; // 0x64
	public static int SpriteLimitMBCacheMap; // 0x68
	public static int MapVisibilityLimitMinimum; // 0x6C
	public static int MapVisibilityLimitMaximum; // 0x70
	public static int JumpSpeed; // 0x74
	public static int JumpAnimateLoops; // 0x78
	public static int JumpHeight; // 0x7C
	public static int PlayerTalkFieldLifeTime; // 0x80
	public static int PlayerTalkFieldMaximunCount; // 0x84
	public static int HomeTouchTargetListKeepOnRadius; // 0x88
	public static int HomeTouchTargetListTopCount; // 0x8C
	public static float ItemDetailLayerFastUseWaitMilli; // 0x90
	public static float ShowoffBagarateTimeMilli; // 0x94
	public static int PickupButtonFindNpcDelayFrames18; // 0x98
	public static float DelayTouchSkillFirstAttackDeltaTime; // 0x9C
	public static int DelayTouchSkillFirstAttackRestFrame18; // 0xA0
	public static string SkillSimilarImageSpr; // 0xA8

	// Methods

	// RVA: 0xFAEB84 Offset: 0xFAAB84 VA: 0xFAEB84
	private static Color32 GetColorRGBA32(string data, Color32 defaultly) { }

	// RVA: 0xFAECFC Offset: 0xFAACFC VA: 0xFAECFC
	public static void Initialize() { }

	// RVA: 0xFAF418 Offset: 0xFAB418 VA: 0xFAF418
	public void .ctor() { }

	// RVA: 0xFAF420 Offset: 0xFAB420 VA: 0xFAF420
	private static void .cctor() { }
}

// Namespace: game.resource.settings
public class Musicset // TypeDefIndex: 2210
{
	// Methods

	// RVA: 0xFAF51C Offset: 0xFAB51C VA: 0xFAF51C
	public static void Initialize() { }

	// RVA: 0xFAF780 Offset: 0xFAB780 VA: 0xFAF780
	public static string GetRandomMusicFile() { }

	// RVA: 0xFAF864 Offset: 0xFAB864 VA: 0xFAF864
	public static string GetMapMusicFile(int mapId) { }

	// RVA: 0xFAF8F8 Offset: 0xFAB8F8 VA: 0xFAF8F8
	public void .ctor() { }
}

// Namespace: 
public class OrderLayer.Data // TypeDefIndex: 2211
{
	// Fields
	public int order; // 0x10
	public GameObject go; // 0x18

	// Methods

	// RVA: 0xFAFBE0 Offset: 0xFABBE0 VA: 0xFAFBE0
	public void .ctor() { }
}

// Namespace: game.resource.settings
public static class OrderLayer // TypeDefIndex: 2212
{
	// Fields
	public static readonly Dictionary<string, int> userInterfaceMapping; // 0x0

	// Methods

	// RVA: 0xFAF900 Offset: 0xFAB900 VA: 0xFAF900
	public static void Initialize() { }

	// RVA: 0xFAFB48 Offset: 0xFABB48 VA: 0xFAFB48
	private static void .cctor() { }
}

// Namespace: game.resource.settings
public static class TextSize // TypeDefIndex: 2213
{
	// Fields
	public static int chatinputmessage; // 0x0
	public static int chatemojifuncs; // 0x4
	public static int chatemojiicon; // 0x8
	public static int chathistorycategory; // 0xC
	public static int chatchannelfield; // 0x10
	public static int chatlogssenttitle; // 0x14
	public static int chatlogssentfield; // 0x18
	public static int pingresponsetext; // 0x1C
	public static int fpsresponsetext; // 0x20
	public static int playerpkstatus; // 0x24
	public static int itemhotkeystackcount; // 0x28
	public static int contextdescriptioncontent; // 0x2C
	public static int enveloptitle; // 0x30
	public static int envelopcontent; // 0x34
	public static int envelopclose; // 0x38
	public static int giveitemdescription; // 0x3C
	public static float npcstateminimun; // 0x40
	public static float npcstatemaximum; // 0x44
	public static float npcstatemaximumcriticaldamage; // 0x48
	public static float npcstatemaximumnormaldamage; // 0x4C
	public static int ministatelefttime; // 0x50
	public static int ministatedescription; // 0x54
	public static int partycreatebutton; // 0x58
	public static int partymemberlevel; // 0x5C
	public static int partymembername; // 0x60
	public static int partyinvitemember; // 0x64
	public static int partymemberinfobutton; // 0x68
	public static int playerproperties; // 0x6C
	public static int playerAllMagicAtributes; // 0x70
	public static int playerselfbagaratestack; // 0x74
	public static int playerselfbagaratemoney; // 0x78
	public static int skilldirectiontargetlisttitle; // 0x7C
	public static int skilldirectiontargetlistfieldlevel; // 0x80
	public static int skilldirectiontargetlistfieldname; // 0x84
	public static float spacingPlayerNameGroup; // 0x88
	public static int skilllistpcinfobutton; // 0x8C
	public static int skilllistpcleftpoint; // 0x90
	public static int skilllistpcskillpoint; // 0x94
	public static int skilllistpcinfoname; // 0x98
	public static int skilllistpcinfodescription; // 0x9C
	public static int iteminfopcfuncsbutton; // 0xA0
	public static int itembuypcfuncsbutton; // 0xA4
	public static int itembuypctaxdescription; // 0xA8
	public static int itembuypcname; // 0xAC
	public static int itembuypcprice; // 0xB0
	public static int playerselfsettingsfield; // 0xB4

	// Methods

	// RVA: 0xFAFBE8 Offset: 0xFABBE8 VA: 0xFAFBE8
	public static void Initialize() { }

	// RVA: 0xFB07E8 Offset: 0xFAC7E8 VA: 0xFB07E8
	private static void .cctor() { }
}

// Namespace: 
public class MapList.MapInfo.FilePath // TypeDefIndex: 2214
{
	// Fields
	public string wor; // 0x10
	public string miniMapImage; // 0x18
	public string backgroundImage; // 0x20

	// Methods

	// RVA: 0xFB08BC Offset: 0xFAC8BC VA: 0xFB08BC
	public void .ctor() { }
}

// Namespace: 
public class MapList.MapInfo.WorFile.Rectangle // TypeDefIndex: 2215
{
	// Fields
	public int left; // 0x10
	public int top; // 0x14
	public int right; // 0x18
	public int bottom; // 0x1C

	// Methods

	// RVA: 0xFB0994 Offset: 0xFAC994 VA: 0xFB0994
	public void .ctor() { }
}

// Namespace: 
public class MapList.MapInfo.WorFile // TypeDefIndex: 2216
{
	// Fields
	public MapList.MapInfo.WorFile.Rectangle rect; // 0x10

	// Methods

	// RVA: 0xFB0928 Offset: 0xFAC928 VA: 0xFB0928
	public void .ctor() { }
}

// Namespace: 
public class MapList.MapInfo // TypeDefIndex: 2217
{
	// Fields
	public int id; // 0x10
	public string rootPath; // 0x18
	public string name; // 0x20
	public MapList.MapInfo.FilePath filePath; // 0x28
	public MapList.MapInfo.WorFile worFile; // 0x30

	// Methods

	// RVA: 0xFA6D48 Offset: 0xFA2D48 VA: 0xFA6D48
	public void .ctor() { }
}

// Namespace: game.resource.settings
public class MapList // TypeDefIndex: 2218
{
	// Methods

	// RVA: 0xFA7204 Offset: 0xFA3204 VA: 0xFA7204
	public static MapList.MapInfo LoadMapInfo(int mapid) { }

	// RVA: 0xFB08B4 Offset: 0xFAC8B4 VA: 0xFB08B4
	public void .ctor() { }
}

// Namespace: 
public struct NpcRes.Part // TypeDefIndex: 2219
{
	// Fields
	public const string shadow = "Shadow";
	public const string head = "Head";
	public const string hair = "Hair";
	public const string shoulder = "Shoulder";
	public const string body = "Body";
	public const string leftHand = "LeftHand";
	public const string rightHand = "RightHead";
	public const string leftWeapon = "LeftWeapon";
	public const string rightWeapon = "RightWeapon";
	public const string horseFront = "HorseFront";
	public const string horseMiddle = "HorseMiddle";
	public const string horseBack = "HorseBack";
	public const string mantle = "Mantle";
}

// Namespace: 
public struct NpcRes.PartGroup // TypeDefIndex: 2220
{
	// Fields
	public const string head = "Head";
	public const string body = "Body";
	public const string weapon = "RightWeapon";
	public const string horse = "HorseFront";
}

// Namespace: 
public struct NpcRes.Action // TypeDefIndex: 2221
{
	// Fields
	public const string fightStand = "FightStand";
	public const string normalStand1 = "NormalStand1";
	public const string normalStand2 = "NormalStand2";
	public const string fightWalk = "FightWalk";
	public const string normalWalk = "NormalWalk";
	public const string fightRun = "FightRun";
	public const string normalRun = "NormalRun";
	public const string wound = "Wound";
	public const string die = "Die";
	public const string attack1 = "Attack1";
	public const string attack2 = "Attack2";
	public const string magic = "Magic";
	public const string sitDown = "SitDown";
	public const string jump = "JunpFly";
}

// Namespace: 
public struct NpcRes.SpecialType // TypeDefIndex: 2222
{
	// Fields
	public const string man = "MainMan";
	public const string lady = "MainLady";
}

// Namespace: 
public class NpcRes.Special : Controller // TypeDefIndex: 2223
{
	// Methods

	// RVA: 0xFB09EC Offset: 0xFAC9EC VA: 0xFB09EC
	public void .ctor(int headIndex = 19, int bodyIndex = 19, int weaponIndex = 1, int horseIndex = -1) { }

	// RVA: 0xFB0A44 Offset: 0xFACA44 VA: 0xFB0A44
	public void SetCharacterType(string _characterTypeName) { }

	// RVA: 0xFB0A84 Offset: 0xFACA84 VA: 0xFB0A84
	public void SetHeadItemLine(int _headItemLine) { }

	// RVA: 0xFB0AC4 Offset: 0xFACAC4 VA: 0xFB0AC4
	public void SetHeadRes(int _headResId) { }

	// RVA: 0xFB0B04 Offset: 0xFACB04 VA: 0xFB0B04
	public void SetBodyItemLine(int _bodyItemLine) { }

	// RVA: 0xFB0B44 Offset: 0xFACB44 VA: 0xFB0B44
	public void SetBodyRes(int _bodyResId) { }

	// RVA: 0xFB0B84 Offset: 0xFACB84 VA: 0xFB0B84
	public void SetWeaponItemLine(int _weaponItemLine) { }

	// RVA: 0xFB0BC4 Offset: 0xFACBC4 VA: 0xFB0BC4
	public void SetWeaponRes(int _weaponResId) { }

	// RVA: 0xFB0C04 Offset: 0xFACC04 VA: 0xFB0C04
	public void SetHorseItemLine(int _horseItemLine) { }

	// RVA: 0xFB0C44 Offset: 0xFACC44 VA: 0xFB0C44
	public void SetHorseRes(int _horseResId) { }

	// RVA: 0xFB0C84 Offset: 0xFACC84 VA: 0xFB0C84
	public void SetHeadItemDefault() { }

	// RVA: 0xFB0CC4 Offset: 0xFACCC4 VA: 0xFB0CC4
	public void SetBodyItemDefault() { }

	// RVA: 0xFB0D04 Offset: 0xFACD04 VA: 0xFB0D04
	public void SetWeaponItemDefault() { }

	// RVA: 0xFB0D44 Offset: 0xFACD44 VA: 0xFB0D44
	public void SetHorseItemDefault() { }

	// RVA: 0xFB0D84 Offset: 0xFACD84 VA: 0xFB0D84
	public void BecomeNpc(int _declareLine) { }

	// RVA: 0xFB0E08 Offset: 0xFACE08 VA: 0xFB0E08
	public void RestoreSpecialNpc() { }
}

// Namespace: 
public class NpcRes.Normal : Controller // TypeDefIndex: 2224
{
	// Methods

	// RVA: 0xFB0E50 Offset: 0xFACE50 VA: 0xFB0E50
	public void .ctor() { }

	// RVA: 0xFB0E74 Offset: 0xFACE74 VA: 0xFB0E74
	public void .ctor(int npcDeclareLine) { }

	// RVA: 0xFB0EA8 Offset: 0xFACEA8 VA: 0xFB0EA8
	public void SetNpcDeclareLine(int _declareLine) { }
}

// Namespace: game.resource.settings
public class NpcRes // TypeDefIndex: 2225
{
	// Methods

	// RVA: 0xFB099C Offset: 0xFAC99C VA: 0xFB099C
	public static void Initialize() { }

	// RVA: 0xFB09E4 Offset: 0xFAC9E4 VA: 0xFB09E4
	public void .ctor() { }
}

// Namespace: game.resource.settings
internal class Npcs // TypeDefIndex: 2226
{
	// Methods

	// RVA: 0xFB0EE8 Offset: 0xFACEE8 VA: 0xFB0EE8
	public static void Initialize() { }

	// RVA: 0xFB1154 Offset: 0xFAD154 VA: 0xFB1154
	public static int GetNpcRunSpeed(int _declareLine) { }

	// RVA: 0xFB11F0 Offset: 0xFAD1F0 VA: 0xFB11F0
	public static string GetNpcResType(int _declareLine) { }

	// RVA: 0xFB129C Offset: 0xFAD29C VA: 0xFB129C
	public static int GetNpcStature(int _declareLine) { }

	// RVA: 0xFB0FCC Offset: 0xFACFCC VA: 0xFB0FCC
	private static Dictionary<int, Cache.Settings.Npcs.Settings> DeclareRowIndexMapping(Table _declareTable) { }

	// RVA: 0xFB1338 Offset: 0xFAD338 VA: 0xFB1338
	private static Dictionary<int, string> DeclareRowIndexToNpcName(Table _declareTable) { }

	// RVA: 0xFB1428 Offset: 0xFAD428 VA: 0xFB1428
	private static Dictionary<int, string> DeclareRowIndexToResTypeMapping(Table _declareTable) { }

	// RVA: 0xFB1518 Offset: 0xFAD518 VA: 0xFB1518
	private static Dictionary<int, int> DeclareRowIndexToStatureMapping(Table _declareTable) { }

	// RVA: 0xFB1608 Offset: 0xFAD608 VA: 0xFB1608
	public void .ctor() { }
}

// Namespace: 
public enum State.HeaderIndexer // TypeDefIndex: 2227
{
	// Fields
	public int value__; // 0x0
	public const State.HeaderIndexer id = 0;
	public const State.HeaderIndexer spr = 1;
	public const State.HeaderIndexer place = 2;
	public const State.HeaderIndexer play = 3;
	public const State.HeaderIndexer backstart = 4;
	public const State.HeaderIndexer backend = 5;
	public const State.HeaderIndexer frames = 6;
	public const State.HeaderIndexer dir = 7;
	public const State.HeaderIndexer interval = 8;
	public const State.HeaderIndexer appendX = 9;
	public const State.HeaderIndexer appendY = 10;
	public const State.HeaderIndexer description = 11;
}

// Namespace: 
public enum State.Place // TypeDefIndex: 2228
{
	// Fields
	public int value__; // 0x0
	public const State.Place unidentified = 0;
	public const State.Place head = 1;
	public const State.Place body = 2;
	public const State.Place foot = 3;
}

// Namespace: 
public enum State.PlayMode // TypeDefIndex: 2229
{
	// Fields
	public int value__; // 0x0
	public const State.PlayMode unidentified = 0;
	public const State.PlayMode loop = 1;
}

// Namespace: game.resource.settings
public class State // TypeDefIndex: 2230
{
	// Fields
	public int id; // 0x10
	public string spr; // 0x18
	public State.Place place; // 0x20
	public int backStart; // 0x24
	public int backEnd; // 0x28
	public int totalFrame; // 0x2C
	public int totalDir; // 0x30
	public float interval; // 0x34
	public float appendX; // 0x38
	public float appendY; // 0x3C
	public static readonly State Empty; // 0x0
	public static readonly Dictionary<int, State> storage; // 0x8

	// Methods

	// RVA: 0xFB1610 Offset: 0xFAD610 VA: 0xFB1610
	public bool IsEmpty() { }

	// RVA: 0xFB1620 Offset: 0xFAD620 VA: 0xFB1620
	public static State Get(int index) { }

	// RVA: 0xFB16D8 Offset: 0xFAD6D8 VA: 0xFB16D8
	public static bool Initialize(Action<string> logfunc) { }

	// RVA: 0xFB1A4C Offset: 0xFADA4C VA: 0xFB1A4C
	public void .ctor() { }

	// RVA: 0xFB1A80 Offset: 0xFADA80 VA: 0xFB1A80
	private static void .cctor() { }
}

// Namespace: game.resource.settings
public static class WordFilter // TypeDefIndex: 2231
{
	// Fields
	private static readonly Dictionary<string, bool> mapping; // 0x0

	// Methods

	// RVA: 0xFB1B60 Offset: 0xFADB60 VA: 0xFB1B60
	public static string Replace(string data) { }

	// RVA: 0xFB1F54 Offset: 0xFADF54 VA: 0xFB1F54
	public static bool IsCollided(string data) { }

	// RVA: 0xFB22D8 Offset: 0xFAE2D8 VA: 0xFB22D8
	private static void .cctor() { }
}

// Namespace: 
public static class Basevalue.Common // TypeDefIndex: 2232
{
	// Fields
	public static int RunSpeed; // 0x0
	public static int WalkSpeed; // 0x4
	public static int AttackFrame; // 0x8
	public static int CastFrame; // 0xC

	// Methods

	// RVA: 0xFB2C40 Offset: 0xFAEC40 VA: 0xFB2C40
	private static void .cctor() { }
}
