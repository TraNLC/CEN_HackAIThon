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

// Namespace: game.resource.mapping.settings
internal struct Item // TypeDefIndex: 2317
{
	// Fields
	public const string directoryPath = "\\settings\\item\\004\\";
	public const string amulet = "\\settings\\item\\004\\amulet.txt";
	public const string armor = "\\settings\\item\\004\\armor.txt";
	public const string belt = "\\settings\\item\\004\\belt.txt";
	public const string boot = "\\settings\\item\\004\\boot.txt";
	public const string cuff = "\\settings\\item\\004\\cuff.txt";
	public const string helm = "\\settings\\item\\004\\helm.txt";
	public const string horse = "\\settings\\item\\004\\horse.txt";
	public const string meleeweapon = "\\settings\\item\\004\\meleeweapon.txt";
	public const string pendant = "\\settings\\item\\004\\pendant.txt";
	public const string rangeweapon = "\\settings\\item\\004\\rangeweapon.txt";
	public const string ring = "\\settings\\item\\004\\ring.txt";
	public const string armorres = "\\settings\\item\\004\\armorres.txt";
	public const string helmres = "\\settings\\item\\004\\helmres.txt";
	public const string horseres = "\\settings\\item\\004\\horseres.txt";
	public const string meleeres = "\\settings\\item\\004\\meleeres.txt";
	public const string rangeres = "\\settings\\item\\004\\rangeres.txt";
	public const string magicattrib = "\\settings\\item\\004\\magicattrib.txt";
	public const string goldEquip = "\\settings\\item\\004\\goldequip.txt";
	public const string goldEquipRes = "\\settings\\item\\004\\goldequipres.txt";
	public const string magicattrib_ge = "\\settings\\item\\004\\magicattrib_ge.txt";
	public const string magicScript = "\\settings\\item\\004\\magicscript.txt";
	public const string mask = "\\settings\\item\\004\\mask.txt";
}

// Namespace: 
public struct MapList.Section // TypeDefIndex: 2318
{
	// Fields
	public const string list = "List";
}

// Namespace: 
public struct MapList.Key.Suffix // TypeDefIndex: 2319
{
	// Fields
	public const string name = "_name";
}

// Namespace: 
public struct MapList.Key // TypeDefIndex: 2320
{}

// Namespace: 
public struct MapList.WorFile.Section // TypeDefIndex: 2321
{
	// Fields
	public const string main = "MAIN";
}

// Namespace: 
public struct MapList.WorFile.Key.Rect // TypeDefIndex: 2322
{
	// Fields
	public const int left = 0;
	public const int top = 1;
	public const int right = 2;
	public const int bottom = 3;
}

// Namespace: 
public struct MapList.WorFile.Key // TypeDefIndex: 2323
{
	// Fields
	public const string rect = "rect";
}

// Namespace: 
public struct MapList.WorFile // TypeDefIndex: 2324
{
	// Fields
	public const string extension = ".wor";
}

// Namespace: 
public struct MapList.MiniMap // TypeDefIndex: 2325
{
	// Fields
	public const string imageSuffix = "24.jpg";
}

// Namespace: 
public struct MapList.Region // TypeDefIndex: 2326
{
	// Fields
	public const string clientSuffix = "_Region_C.dat";
}

// Namespace: 
public static class MapList.Cached // TypeDefIndex: 2327
{
	// Fields
	public static Ini maplistini; // 0x0
	public static readonly Dictionary<int, MapList.MapInfo> mapinfoMapping; // 0x8

	// Methods

	// RVA: 0xFC854C Offset: 0xFC454C VA: 0xFC854C
	public static void Initialize() { }

	// RVA: 0xFC8628 Offset: 0xFC4628 VA: 0xFC8628
	private static void .cctor() { }
}

// Namespace: game.resource.mapping.settings
internal struct MapList // TypeDefIndex: 2328
{
	// Fields
	public const string resourceFolder = "\\maps\\";
	public const string filePath = "\\settings\\maplist.ini";
}

// Namespace: 
public enum Missile.HeaderIndexer // TypeDefIndex: 2329
{
	// Fields
	public int value__; // 0x0
	public const Missile.HeaderIndexer MissleId = 0;
	public const Missile.HeaderIndexer MissleName = 1;
	public const Missile.HeaderIndexer MoveKind = 2;
	public const Missile.HeaderIndexer FollowKind = 3;
	public const Missile.HeaderIndexer ColFollowTarget = 4;
	public const Missile.HeaderIndexer MissleHeight = 5;
	public const Missile.HeaderIndexer CollidRange = 6;
	public const Missile.HeaderIndexer IsRangeDmg = 7;
	public const Missile.HeaderIndexer DmgRange = 8;
	public const Missile.HeaderIndexer DmgInterval = 9;
	public const Missile.HeaderIndexer LifeTime = 10;
	public const Missile.HeaderIndexer Speed = 11;
	public const Missile.HeaderIndexer Zspeed = 12;
	public const Missile.HeaderIndexer Zacc = 13;
	public const Missile.HeaderIndexer LoopPlay = 14;
	public const Missile.HeaderIndexer SubLoop = 15;
	public const Missile.HeaderIndexer SubStart = 16;
	public const Missile.HeaderIndexer SubStop = 17;
	public const Missile.HeaderIndexer ResponseSkill = 18;
	public const Missile.HeaderIndexer CanDestroy = 19;
	public const Missile.HeaderIndexer ColVanish = 20;
	public const Missile.HeaderIndexer CanSlow = 21;
	public const Missile.HeaderIndexer CanColFriend = 22;
	public const Missile.HeaderIndexer AutoExplode = 23;
	public const Missile.HeaderIndexer MissRate = 24;
	public const Missile.HeaderIndexer Param1 = 25;
	public const Missile.HeaderIndexer Param2 = 26;
	public const Missile.HeaderIndexer Param3 = 27;
	public const Missile.HeaderIndexer MultiShow = 28;
	public const Missile.HeaderIndexer AnimFile1 = 29;
	public const Missile.HeaderIndexer AnimFileInfo1 = 30;
	public const Missile.HeaderIndexer SndFile1 = 31;
	public const Missile.HeaderIndexer AnimFile2 = 32;
	public const Missile.HeaderIndexer AnimFileInfo2 = 33;
	public const Missile.HeaderIndexer SndFile2 = 34;
	public const Missile.HeaderIndexer AnimFile3 = 35;
	public const Missile.HeaderIndexer AnimFileInfo3 = 36;
	public const Missile.HeaderIndexer SndFile3 = 37;
	public const Missile.HeaderIndexer AnimFile4 = 38;
	public const Missile.HeaderIndexer AnimFileInfo4 = 39;
	public const Missile.HeaderIndexer SndFile4 = 40;
	public const Missile.HeaderIndexer AnimFileB1 = 41;
	public const Missile.HeaderIndexer AnimFileInfoB1 = 42;
	public const Missile.HeaderIndexer SndFileB1 = 43;
	public const Missile.HeaderIndexer AnimFileB2 = 44;
	public const Missile.HeaderIndexer AnimFileInfoB2 = 45;
	public const Missile.HeaderIndexer SndFileB2 = 46;
	public const Missile.HeaderIndexer AnimFileB3 = 47;
	public const Missile.HeaderIndexer AnimFileInfoB3 = 48;
	public const Missile.HeaderIndexer SndFileB3 = 49;
	public const Missile.HeaderIndexer AnimFileB4 = 50;
	public const Missile.HeaderIndexer AnimFileInfoB4 = 51;
	public const Missile.HeaderIndexer SndFileB4 = 52;
	public const Missile.HeaderIndexer RedLum = 53;
	public const Missile.HeaderIndexer GreenLum = 54;
	public const Missile.HeaderIndexer BlueLum = 55;
	public const Missile.HeaderIndexer LightRadius = 56;
}

// Namespace: game.resource.mapping.settings
public struct Missile // TypeDefIndex: 2330
{
	// Fields
	public const string filePath = "\\settings\\missles.txt";
}

// Namespace: 
public struct NpcRes.Kind.Header // TypeDefIndex: 2331
{
	// Fields
	public const string characterName = "CharacterName";
	public const string characterType = "CharacterType";
	public const string resFilePath = "ResFilePath";
	public const string partFileName = "PartFileName";
	public const string weaponActionTab1 = "WeaponActionTab1";
	public const string weaponActionTab2 = "WeaponActionTab2";
	public const string actionRenderOrderTab = "ActionRenderOrderTab";
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
public struct NpcRes.Kind.CharacterName // TypeDefIndex: 2332
{
	// Fields
	public const string mainMan = "MainMan";
	public const string mainLady = "MainLady";
}

// Namespace: 
public struct NpcRes.Kind // TypeDefIndex: 2333
{
	// Fields
	public const string filePath = "\\settings\\npcres\\main.kind.txt";
}

// Namespace: 
public struct NpcRes.Properties // TypeDefIndex: 2334
{
	// Fields
	public const string sprPropertiesSuffix = ".frames";
	public const string tabFileExtension = ".txt";
	public const string sprFolderPrefix = "\\spr\\npcres\\";
	public const string sprFileExtension = ".spr";
}

// Namespace: 
public struct NpcRes.WeaponAction // TypeDefIndex: 2335
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
	public const string junpFly = "JunpFly";
}

// Namespace: 
public struct NpcRes.Shadow // TypeDefIndex: 2336
{
	// Fields
	public const string partName = "Shadow";
	public const string filePath = "\\settings\\npcres\\shadow.txt";
}

// Namespace: 
public struct NpcRes.ActionRenderOrderTab.Section // TypeDefIndex: 2337
{
	// Fields
	public const string Default = "DEFAULT";
}

// Namespace: 
public struct NpcRes.ActionRenderOrderTab.Key // TypeDefIndex: 2338
{
	// Fields
	public const string prefix = "Dir";
}

// Namespace: 
public struct NpcRes.ActionRenderOrderTab // TypeDefIndex: 2339
{}

// Namespace: 
public struct NpcRes.SprPropertiesIndexer // TypeDefIndex: 2340
{
	// Fields
	public const int frameCount = 0;
	public const int directionCount = 1;
	public const int intervalRatio = 2;
}

// Namespace: 
public struct NpcRes.NormalNpc.Header // TypeDefIndex: 2341
{
	// Fields
	public const string npcList = "NpcList";
}

// Namespace: 
public struct NpcRes.NormalNpc // TypeDefIndex: 2342
{
	// Fields
	public const string sprActionPath = "\\settings\\npcres\\npc.action.spr.txt";
	public const string sprPropertiesPath = "\\settings\\npcres\\npc.action.frames.txt";
	public const string soundEffectPath = "\\settings\\npcres\\npc.sound.effect.txt";
	public const string shadowSuffix = "b";
}

// Namespace: game.resource.mapping.settings
internal struct NpcRes // TypeDefIndex: 2343
{
	// Fields
	public const string directoryPath = "\\settings\\npcres\\";
}

// Namespace: 
public enum Npcs.HeaderIndexer // TypeDefIndex: 2344
{
	// Fields
	public int value__; // 0x0
	public const Npcs.HeaderIndexer Name = 0;
	public const Npcs.HeaderIndexer Kind = 1;
	public const Npcs.HeaderIndexer Camp = 2;
	public const Npcs.HeaderIndexer Series = 3;
	public const Npcs.HeaderIndexer Treasure = 4;
	public const Npcs.HeaderIndexer HeadImage = 5;
	public const Npcs.HeaderIndexer ClientOnly = 6;
	public const Npcs.HeaderIndexer CorpseIdx = 7;
	public const Npcs.HeaderIndexer RedLum = 8;
	public const Npcs.HeaderIndexer GreenLum = 9;
	public const Npcs.HeaderIndexer BlueLum = 10;
	public const Npcs.HeaderIndexer NpcResType = 11;
	public const Npcs.HeaderIndexer ArmorType = 12;
	public const Npcs.HeaderIndexer HelmType = 13;
	public const Npcs.HeaderIndexer WeaponType = 14;
	public const Npcs.HeaderIndexer HorseType = 15;
	public const Npcs.HeaderIndexer RideHorse = 16;
	public const Npcs.HeaderIndexer StandFrame = 17;
	public const Npcs.HeaderIndexer StandFrame1 = 18;
	public const Npcs.HeaderIndexer DeathFrame = 19;
	public const Npcs.HeaderIndexer WalkFrame = 20;
	public const Npcs.HeaderIndexer RunFrame = 21;
	public const Npcs.HeaderIndexer HurtFrame = 22;
	public const Npcs.HeaderIndexer Skill1 = 23;
	public const Npcs.HeaderIndexer Level1 = 24;
	public const Npcs.HeaderIndexer Skill2 = 25;
	public const Npcs.HeaderIndexer Level2 = 26;
	public const Npcs.HeaderIndexer Skill3 = 27;
	public const Npcs.HeaderIndexer Level3 = 28;
	public const Npcs.HeaderIndexer Skill4 = 29;
	public const Npcs.HeaderIndexer Level4 = 30;
	public const Npcs.HeaderIndexer ActionScript = 31;
	public const Npcs.HeaderIndexer LevelScript = 32;
	public const Npcs.HeaderIndexer ExpParam = 33;
	public const Npcs.HeaderIndexer ExpParam1 = 34;
	public const Npcs.HeaderIndexer ExpParam2 = 35;
	public const Npcs.HeaderIndexer ExpParam3 = 36;
	public const Npcs.HeaderIndexer LifeParam = 37;
	public const Npcs.HeaderIndexer LifeParam1 = 38;
	public const Npcs.HeaderIndexer LifeParam2 = 39;
	public const Npcs.HeaderIndexer LifeParam3 = 40;
	public const Npcs.HeaderIndexer LifeReplenish = 41;
	public const Npcs.HeaderIndexer ARParam = 42;
	public const Npcs.HeaderIndexer ARParam1 = 43;
	public const Npcs.HeaderIndexer ARParam2 = 44;
	public const Npcs.HeaderIndexer ARParam3 = 45;
	public const Npcs.HeaderIndexer DefenseParam = 46;
	public const Npcs.HeaderIndexer DefenseParam1 = 47;
	public const Npcs.HeaderIndexer DefenseParam2 = 48;
	public const Npcs.HeaderIndexer DefenseParam3 = 49;
	public const Npcs.HeaderIndexer MinDamageParam = 50;
	public const Npcs.HeaderIndexer MinDamageParam1 = 51;
	public const Npcs.HeaderIndexer MinDamageParam2 = 52;
	public const Npcs.HeaderIndexer MinDamageParam3 = 53;
	public const Npcs.HeaderIndexer MaxDamageParam = 54;
	public const Npcs.HeaderIndexer MaxDamageParam1 = 55;
	public const Npcs.HeaderIndexer MaxDamageParam2 = 56;
	public const Npcs.HeaderIndexer MaxDamageParam3 = 57;
	public const Npcs.HeaderIndexer WalkSpeed = 58;
	public const Npcs.HeaderIndexer RunSpeed = 59;
	public const Npcs.HeaderIndexer AttackSpeed = 60;
	public const Npcs.HeaderIndexer CastSpeed = 61;
	public const Npcs.HeaderIndexer VisionRadius = 62;
	public const Npcs.HeaderIndexer HitRecover = 63;
	public const Npcs.HeaderIndexer ActiveRadius = 64;
	public const Npcs.HeaderIndexer AIMode = 65;
	public const Npcs.HeaderIndexer AIParam1 = 66;
	public const Npcs.HeaderIndexer AIParam2 = 67;
	public const Npcs.HeaderIndexer AIParam3 = 68;
	public const Npcs.HeaderIndexer AIParam4 = 69;
	public const Npcs.HeaderIndexer AIParam5 = 70;
	public const Npcs.HeaderIndexer AIParam6 = 71;
	public const Npcs.HeaderIndexer AIParam7 = 72;
	public const Npcs.HeaderIndexer AIParam8 = 73;
	public const Npcs.HeaderIndexer AIParam9 = 74;
	public const Npcs.HeaderIndexer FireResist = 75;
	public const Npcs.HeaderIndexer ColdResist = 76;
	public const Npcs.HeaderIndexer LightResist = 77;
	public const Npcs.HeaderIndexer PoisonResist = 78;
	public const Npcs.HeaderIndexer PhysicsResist = 79;
	public const Npcs.HeaderIndexer FireResistMax = 80;
	public const Npcs.HeaderIndexer ColdResistMax = 81;
	public const Npcs.HeaderIndexer LightResistMax = 82;
	public const Npcs.HeaderIndexer PoisonResistMax = 83;
	public const Npcs.HeaderIndexer PhysicsResistMax = 84;
	public const Npcs.HeaderIndexer ReviveFrame = 85;
	public const Npcs.HeaderIndexer Stature = 86;
	public const Npcs.HeaderIndexer DropRateFile = 87;
	public const Npcs.HeaderIndexer AIMaxTime = 88;
	public const Npcs.HeaderIndexer PhysicalDamageBase = 89;
	public const Npcs.HeaderIndexer PhysicalMagicBase = 90;
	public const Npcs.HeaderIndexer PoisonDamageBase = 91;
	public const Npcs.HeaderIndexer PoisonMagicBase = 92;
	public const Npcs.HeaderIndexer ColdDamageBase = 93;
	public const Npcs.HeaderIndexer ColdMagicBase = 94;
	public const Npcs.HeaderIndexer FireDamageBase = 95;
	public const Npcs.HeaderIndexer FireMagicBase = 96;
	public const Npcs.HeaderIndexer LightingDamageBase = 97;
	public const Npcs.HeaderIndexer LightingMagicBase = 98;
	public const Npcs.HeaderIndexer AuraSkillId = 99;
	public const Npcs.HeaderIndexer AuraSkillLevel = 100;
	public const Npcs.HeaderIndexer PasstSkillId = 101;
	public const Npcs.HeaderIndexer PasstSkillLevel = 102;
}

// Namespace: game.resource.mapping.settings
internal struct Npcs // TypeDefIndex: 2345
{
	// Fields
	public const string fileFullPath = "\\settings\\npcs.txt";
}

// Namespace: 
public enum ObjData.HeaderIndexer // TypeDefIndex: 2346
{
	// Fields
	public int value__; // 0x0
	public const ObjData.HeaderIndexer Name = 0;
	public const ObjData.HeaderIndexer DataID = 1;
	public const ObjData.HeaderIndexer Kind = 2;
	public const ObjData.HeaderIndexer ScriptName = 3;
	public const ObjData.HeaderIndexer ImageName = 4;
	public const ObjData.HeaderIndexer SoundName = 5;
	public const ObjData.HeaderIndexer LifeTime = 6;
	public const ObjData.HeaderIndexer Layer = 7;
	public const ObjData.HeaderIndexer Height = 8;
	public const ObjData.HeaderIndexer SkillKind = 9;
	public const ObjData.HeaderIndexer SkillCamp = 10;
	public const ObjData.HeaderIndexer SkillRange = 11;
	public const ObjData.HeaderIndexer SkillCastTime = 12;
	public const ObjData.HeaderIndexer SkillID = 13;
	public const ObjData.HeaderIndexer SkillLevel = 14;
	public const ObjData.HeaderIndexer LightRadius = 15;
	public const ObjData.HeaderIndexer LightRed = 16;
	public const ObjData.HeaderIndexer LightGreen = 17;
	public const ObjData.HeaderIndexer LightBlue = 18;
	public const ObjData.HeaderIndexer LightAlpha = 19;
	public const ObjData.HeaderIndexer LightReflectType = 20;
	public const ObjData.HeaderIndexer ImageTotalFrame = 21;
	public const ObjData.HeaderIndexer ImageCurFrame = 22;
	public const ObjData.HeaderIndexer ImageTotalDir = 23;
	public const ObjData.HeaderIndexer ImageCurDir = 24;
	public const ObjData.HeaderIndexer ImageInterval = 25;
	public const ObjData.HeaderIndexer ImageCgXpos = 26;
	public const ObjData.HeaderIndexer ImageCgYpos = 27;
	public const ObjData.HeaderIndexer Bar0 = 28;
	public const ObjData.HeaderIndexer Bar1 = 29;
	public const ObjData.HeaderIndexer Bar2 = 30;
	public const ObjData.HeaderIndexer Bar3 = 31;
	public const ObjData.HeaderIndexer Bar4 = 32;
	public const ObjData.HeaderIndexer Bar5 = 33;
	public const ObjData.HeaderIndexer Bar6 = 34;
	public const ObjData.HeaderIndexer Bar7 = 35;
	public const ObjData.HeaderIndexer Bar8 = 36;
	public const ObjData.HeaderIndexer Bar9 = 37;
	public const ObjData.HeaderIndexer Bar10 = 38;
	public const ObjData.HeaderIndexer Bar11 = 39;
	public const ObjData.HeaderIndexer Bar12 = 40;
	public const ObjData.HeaderIndexer Bar13 = 41;
	public const ObjData.HeaderIndexer Bar14 = 42;
	public const ObjData.HeaderIndexer ImageDropName = 43;
	public const ObjData.HeaderIndexer ImageDropTotalFrame = 44;
	public const ObjData.HeaderIndexer ImageDropCurFrame = 45;
	public const ObjData.HeaderIndexer ImageDropTotalDir = 46;
	public const ObjData.HeaderIndexer ImageDropCurDir = 47;
	public const ObjData.HeaderIndexer ImageDropInterval = 48;
	public const ObjData.HeaderIndexer ImageDropCgXpos = 49;
	public const ObjData.HeaderIndexer ImageDropCgYpos = 50;
	public const ObjData.HeaderIndexer IsUnseen = 51;
	public const ObjData.HeaderIndexer ObstacleKind = 52;
	public const ObjData.HeaderIndexer LoopAnimation = 53;
}

// Namespace: game.resource.mapping.settings
internal struct ObjData // TypeDefIndex: 2347
{
	// Fields
	public const string fileFullPath = "\\settings\\objdata.txt";
}

// Namespace: 
public enum Skill.HeaderIndexer // TypeDefIndex: 2348
{
	// Fields
	public int value__; // 0x0
	public const Skill.HeaderIndexer SkillName = 0;
	public const Skill.HeaderIndexer Property = 1;
	public const Skill.HeaderIndexer SkillId = 2;
	public const Skill.HeaderIndexer Attrib = 3;
	public const Skill.HeaderIndexer SkillStyle = 4;
	public const Skill.HeaderIndexer SkillIcon = 5;
	public const Skill.HeaderIndexer PreCastSpr = 6;
	public const Skill.HeaderIndexer ManCastSnd = 7;
	public const Skill.HeaderIndexer FMCastSnd = 8;
	public const Skill.HeaderIndexer StateSpecialId = 9;
	public const Skill.HeaderIndexer StatePriority = 10;
	public const Skill.HeaderIndexer IsAura = 11;
	public const Skill.HeaderIndexer LRSkill = 12;
	public const Skill.HeaderIndexer NeedShadow = 13;
	public const Skill.HeaderIndexer AttackRadius = 14;
	public const Skill.HeaderIndexer MaxShadowNum = 15;
	public const Skill.HeaderIndexer MslsGenerate = 16;
	public const Skill.HeaderIndexer MslsGenerateData = 17;
	public const Skill.HeaderIndexer CharClass = 18;
	public const Skill.HeaderIndexer MisslesForm = 19;
	public const Skill.HeaderIndexer ChildSkillId = 20;
	public const Skill.HeaderIndexer ChildSkillLevel = 21;
	public const Skill.HeaderIndexer ChildSkillNum = 22;
	public const Skill.HeaderIndexer BaseSkill = 23;
	public const Skill.HeaderIndexer CharAnimId = 24;
	public const Skill.HeaderIndexer EventSkillLevel = 25;
	public const Skill.HeaderIndexer IsMelee = 26;
	public const Skill.HeaderIndexer WaitTime = 27;
	public const Skill.HeaderIndexer IsSaveCd = 28;
	public const Skill.HeaderIndexer ClientSend = 29;
	public const Skill.HeaderIndexer SkillCostType = 30;
	public const Skill.HeaderIndexer CostValue = 31;
	public const Skill.HeaderIndexer TimePerCast = 32;
	public const Skill.HeaderIndexer TimePerCastOnHorse = 33;
	public const Skill.HeaderIndexer IsPhysical = 34;
	public const Skill.HeaderIndexer TargetOnly = 35;
	public const Skill.HeaderIndexer TargetEnemy = 36;
	public const Skill.HeaderIndexer TargetAlly = 37;
	public const Skill.HeaderIndexer TargetSelf = 38;
	public const Skill.HeaderIndexer TargetOther = 39;
	public const Skill.HeaderIndexer TargetObj = 40;
	public const Skill.HeaderIndexer TargetNoNpc = 41;
	public const Skill.HeaderIndexer ByMissle = 42;
	public const Skill.HeaderIndexer IsUseAR = 43;
	public const Skill.HeaderIndexer StartEvent = 44;
	public const Skill.HeaderIndexer StartSkillId = 45;
	public const Skill.HeaderIndexer FlyEvent = 46;
	public const Skill.HeaderIndexer FlySkillId = 47;
	public const Skill.HeaderIndexer FlyEventTime = 48;
	public const Skill.HeaderIndexer CollideEvent = 49;
	public const Skill.HeaderIndexer CollidSkillId = 50;
	public const Skill.HeaderIndexer VanishedEvent = 51;
	public const Skill.HeaderIndexer VanishedSkillId = 52;
	public const Skill.HeaderIndexer ReqLevel = 53;
	public const Skill.HeaderIndexer MaxLevel = 54;
	public const Skill.HeaderIndexer EqtLimit = 55;
	public const Skill.HeaderIndexer HorseLimit = 56;
	public const Skill.HeaderIndexer DoHurt = 57;
	public const Skill.HeaderIndexer WeaponSkill = 58;
	public const Skill.HeaderIndexer Param1 = 59;
	public const Skill.HeaderIndexer Param1Memo = 60;
	public const Skill.HeaderIndexer Param2 = 61;
	public const Skill.HeaderIndexer Param2Memo = 62;
	public const Skill.HeaderIndexer StopWhenMove = 63;
	public const Skill.HeaderIndexer HeelAtParent = 64;
	public const Skill.HeaderIndexer RelativePosType = 65;
	public const Skill.HeaderIndexer PeaceCanUse = 66;
	public const Skill.HeaderIndexer ShowEvent = 67;
	public const Skill.HeaderIndexer IsExpSkill = 68;
	public const Skill.HeaderIndexer Series = 69;
	public const Skill.HeaderIndexer ShowAddition = 70;
	public const Skill.HeaderIndexer LvlSetScript = 71;
	public const Skill.HeaderIndexer LvlSetting1 = 72;
	public const Skill.HeaderIndexer LvlData1 = 73;
	public const Skill.HeaderIndexer LvlSetting2 = 74;
	public const Skill.HeaderIndexer LvlData2 = 75;
	public const Skill.HeaderIndexer LvlSetting3 = 76;
	public const Skill.HeaderIndexer LvlData3 = 77;
	public const Skill.HeaderIndexer LvlSetting4 = 78;
	public const Skill.HeaderIndexer LvlData4 = 79;
	public const Skill.HeaderIndexer LvlSetting5 = 80;
	public const Skill.HeaderIndexer LvlData5 = 81;
	public const Skill.HeaderIndexer LvlSetting6 = 82;
	public const Skill.HeaderIndexer LvlData6 = 83;
	public const Skill.HeaderIndexer LvlSetting7 = 84;
	public const Skill.HeaderIndexer LvlData7 = 85;
	public const Skill.HeaderIndexer LvlSetting8 = 86;
	public const Skill.HeaderIndexer LvlData8 = 87;
	public const Skill.HeaderIndexer LvlSetting9 = 88;
	public const Skill.HeaderIndexer LvlData9 = 89;
	public const Skill.HeaderIndexer LvlSetting10 = 90;
	public const Skill.HeaderIndexer LvlData10 = 91;
	public const Skill.HeaderIndexer LvlSetting11 = 92;
	public const Skill.HeaderIndexer LvlData11 = 93;
	public const Skill.HeaderIndexer LvlSetting12 = 94;
	public const Skill.HeaderIndexer LvlData12 = 95;
	public const Skill.HeaderIndexer LvlSetting13 = 96;
	public const Skill.HeaderIndexer LvlData13 = 97;
	public const Skill.HeaderIndexer LvlSetting14 = 98;
	public const Skill.HeaderIndexer LvlData14 = 99;
	public const Skill.HeaderIndexer LvlSetting15 = 100;
	public const Skill.HeaderIndexer LvlData15 = 101;
	public const Skill.HeaderIndexer LvlSetting16 = 102;
	public const Skill.HeaderIndexer LvlData16 = 103;
	public const Skill.HeaderIndexer LvlSetting17 = 104;
	public const Skill.HeaderIndexer LvlData17 = 105;
	public const Skill.HeaderIndexer LvlSetting18 = 106;
	public const Skill.HeaderIndexer LvlData18 = 107;
	public const Skill.HeaderIndexer LvlSetting19 = 108;
	public const Skill.HeaderIndexer LvlData19 = 109;
	public const Skill.HeaderIndexer LvlSetting20 = 110;
	public const Skill.HeaderIndexer LvlData20 = 111;
	public const Skill.HeaderIndexer LevelUpScript = 112;
	public const Skill.HeaderIndexer SkillDesc = 113;
}

// Namespace: game.resource.mapping.settings
public struct Skill // TypeDefIndex: 2349
{
	// Fields
	public const string filePath = "\\settings\\skills.txt";
}

// Namespace: 
public struct Config.Textures // TypeDefIndex: 2350
{
	// Fields
	public int radiusHorizontalVisibility; // 0x0
	public int radiusVerticalVisibility; // 0x4
	public int drawGroundNode; // 0x8
	public int drawGroundObject; // 0xC
	public int drawBuilding; // 0x10
	public int drawTree; // 0x14
	public int drawObstacleGrid; // 0x18
}

// Namespace: 
public struct Config.Identification // TypeDefIndex: 2351
{
	// Fields
	public bool npcTitle; // 0x0
	public bool npcTong; // 0x1
	public bool npcName; // 0x2
	public bool npcHealth; // 0x3
	public bool npcMapPos; // 0x4
	public bool droppingName; // 0x5
}
