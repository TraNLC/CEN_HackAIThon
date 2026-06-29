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

// Namespace: shared.resource.settings.skill
public class Base : Data // TypeDefIndex: 1903
{
	// Methods

	// RVA: 0xF6F840 Offset: 0xF6B840 VA: 0xF6F840
	protected void LoadBase(int skillId) { }

	// RVA: 0xF711A8 Offset: 0xF6D1A8 VA: 0xF711A8
	public void .ctor() { }
}

// Namespace: 
public class Data.Script // TypeDefIndex: 1904
{
	// Fields
	public int missileSpeed; // 0x10
	public int missileLifeTime; // 0x14
	public int stateLifeTime; // 0x18
	public int totalExpToUpLevel; // 0x1C
	public int playerLevelRequired; // 0x20

	// Methods

	// RVA: 0xF71CD0 Offset: 0xF6DCD0 VA: 0xF71CD0
	public void .ctor() { }
}

// Namespace: shared.resource.settings.skill
public class Data // TypeDefIndex: 1905
{
	// Fields
	protected Skill self; // 0x10
	public Data.Script script; // 0x18
	public int SkillLevel; // 0x20
	public int relation; // 0x24
	public string SkillName; // 0x28
	public string Property; // 0x30
	public int SkillId; // 0x38
	public int Attrib; // 0x3C
	public int SkillStyle; // 0x40
	public string SkillIcon; // 0x48
	public string PreCastSpr; // 0x50
	public string ManCastSnd; // 0x58
	public string FMCastSnd; // 0x60
	public int StateSpecialId; // 0x68
	public int StatePriority; // 0x6C
	public int IsAura; // 0x70
	public int LRSkill; // 0x74
	public int NeedShadow; // 0x78
	public int AttackRadius; // 0x7C
	public int MaxShadowNum; // 0x80
	public int MslsGenerate; // 0x84
	public int MslsGenerateData; // 0x88
	public int CharClass; // 0x8C
	public int MisslesForm; // 0x90
	public int ChildSkillId; // 0x94
	public int ChildSkillLevel; // 0x98
	public int ChildSkillNum; // 0x9C
	public int BaseSkill; // 0xA0
	public int CharAnimId; // 0xA4
	public int EventSkillLevel; // 0xA8
	public int IsMelee; // 0xAC
	public int WaitTime; // 0xB0
	public int IsSaveCd; // 0xB4
	public int ClientSend; // 0xB8
	public int SkillCostType; // 0xBC
	public int CostValue; // 0xC0
	public int TimePerCast; // 0xC4
	public int TimePerCastOnHorse; // 0xC8
	public int IsPhysical; // 0xCC
	public int TargetOnly; // 0xD0
	public int TargetEnemy; // 0xD4
	public int TargetAlly; // 0xD8
	public int TargetSelf; // 0xDC
	public int TargetOther; // 0xE0
	public int TargetObj; // 0xE4
	public int TargetNoNpc; // 0xE8
	public int ByMissle; // 0xEC
	public int IsUseAR; // 0xF0
	public int StartEvent; // 0xF4
	public int StartSkillId; // 0xF8
	public int FlyEvent; // 0xFC
	public int FlySkillId; // 0x100
	public int FlyEventTime; // 0x104
	public int CollideEvent; // 0x108
	public int CollidSkillId; // 0x10C
	public int VanishedEvent; // 0x110
	public int VanishedSkillId; // 0x114
	public int ReqLevel; // 0x118
	public int MaxLevel; // 0x11C
	public int EqtLimit; // 0x120
	public int HorseLimit; // 0x124
	public int DoHurt; // 0x128
	public int WeaponSkill; // 0x12C
	public int Param1; // 0x130
	public int Param1Memo; // 0x134
	public int Param2; // 0x138
	public int Param2Memo; // 0x13C
	public int StopWhenMove; // 0x140
	public int HeelAtParent; // 0x144
	public int RelativePosType; // 0x148
	public int PeaceCanUse; // 0x14C
	public int ShowEvent; // 0x150
	public int IsExpSkill; // 0x154
	public int Series; // 0x158
	public int ShowAddition; // 0x15C
	public string LvlSetScript; // 0x160
	public string LvlSetting1; // 0x168
	public string LvlData1; // 0x170
	public string LvlSetting2; // 0x178
	public string LvlData2; // 0x180
	public string LvlSetting3; // 0x188
	public string LvlData3; // 0x190
	public string LvlSetting4; // 0x198
	public string LvlData4; // 0x1A0
	public string LvlSetting5; // 0x1A8
	public string LvlData5; // 0x1B0
	public string LvlSetting6; // 0x1B8
	public string LvlData6; // 0x1C0
	public string LvlSetting7; // 0x1C8
	public string LvlData7; // 0x1D0
	public string LvlSetting8; // 0x1D8
	public string LvlData8; // 0x1E0
	public string LvlSetting9; // 0x1E8
	public string LvlData9; // 0x1F0
	public string LvlSetting10; // 0x1F8
	public string LvlData10; // 0x200
	public string LvlSetting11; // 0x208
	public string LvlData11; // 0x210
	public string LvlSetting12; // 0x218
	public string LvlData12; // 0x220
	public string LvlSetting13; // 0x228
	public string LvlData13; // 0x230
	public string LvlSetting14; // 0x238
	public string LvlData14; // 0x240
	public string LvlSetting15; // 0x248
	public string LvlData15; // 0x250
	public string LvlSetting16; // 0x258
	public string LvlData16; // 0x260
	public string LvlSetting17; // 0x268
	public string LvlData17; // 0x270
	public string LvlSetting18; // 0x278
	public string LvlData18; // 0x280
	public string LvlSetting19; // 0x288
	public string LvlData19; // 0x290
	public string LvlSetting20; // 0x298
	public string LvlData20; // 0x2A0
	public string LevelUpScript; // 0x2A8
	public string SkillDesc; // 0x2B0
	public Dictionary<string, Attrib> damageAttrib; // 0x2B8
	public Dictionary<string, Attrib> otherAttrib; // 0x2C0

	// Methods

	// RVA: 0xF71738 Offset: 0xF6D738 VA: 0xF71738
	public int GetMissleGenerateTime(int nNo) { }

	// RVA: 0xF718E0 Offset: 0xF6D8E0 VA: 0xF718E0
	public bool IsRequiredSpecificSkillToAddPoint() { }

	// RVA: 0xF711AC Offset: 0xF6D1AC VA: 0xF711AC
	public void .ctor() { }
}

// Namespace: shared.resource.settings.skill
public class Getters : Level // TypeDefIndex: 1906
{
	// Fields
	private static readonly string[] weaponEquipLimited; // 0x0

	// Methods

	// RVA: 0xF71CE0 Offset: 0xF6DCE0 VA: 0xF71CE0
	public string GetMagicProperties(bool showAddSkillDamageForEventSkill, bool showRequiredSkill, int requiredSkillLevel = 0) { }

	// RVA: 0xF74248 Offset: 0xF70248 VA: 0xF74248
	public string GetDescription(int showRequiredSkillLevel) { }

	// RVA: 0xF6F6D0 Offset: 0xF6B6D0 VA: 0xF6F6D0
	public void .ctor() { }

	// RVA: 0xF746A8 Offset: 0xF706A8 VA: 0xF746A8
	private static void .cctor() { }
}

// Namespace: shared.resource.settings.skill
public class Initialize // TypeDefIndex: 1907
{
	// Methods

	// RVA: 0xF748F8 Offset: 0xF708F8 VA: 0xF748F8
	public void .ctor() { }

	// RVA: 0xF74BF4 Offset: 0xF70BF4 VA: 0xF74BF4
	private static Dictionary<int, int> SkillIdToRowIndex(Table skillTable) { }

	// RVA: 0xF74CE4 Offset: 0xF70CE4 VA: 0xF74CE4
	private static Dictionary<int, int> MissileIdToRowIndex(Table missileTable) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Level.<>c // TypeDefIndex: 1908
{
	// Fields
	public static readonly Level.<>c <>9; // 0x0
	public static Func<char, byte> <>9__8_0; // 0x8

	// Methods

	// RVA: 0xF76954 Offset: 0xF72954 VA: 0xF76954
	private static void .cctor() { }

	// RVA: 0xF769BC Offset: 0xF729BC VA: 0xF769BC
	public void .ctor() { }

	// RVA: 0xF769C4 Offset: 0xF729C4 VA: 0xF769C4
	internal byte <LoadLevel>b__8_0(char x) { }
}

// Namespace: shared.resource.settings.skill
public class Level : Base // TypeDefIndex: 1909
{
	// Fields
	private const string skillScriptDirectory = "script/skill.client";
	private const string skillScriptMain = "script/skill.client/all.main.lua";
	private const string skillScriptFuncs = "script/skill.client/all.funcs.lua";
	private static byte[] funcsContent; // 0x0
	private static Dictionary<string, byte[]> scriptContent; // 0x8
	private static Script scriptHandler; // 0x10

	// Methods

	// RVA: 0xF74B60 Offset: 0xF70B60 VA: 0xF74B60
	public static void Clear() { }

	[LuaCallCSharp(0)]
	// RVA: 0xF74DD4 Offset: 0xF70DD4 VA: 0xF74DD4
	private static byte[] CustomLoaderFunction(ref string path) { }

	// RVA: 0xF74F4C Offset: 0xF70F4C VA: 0xF74F4C
	public void LoadLevel(int level) { }

	// RVA: 0xF7694C Offset: 0xF7294C VA: 0xF7694C
	public void .ctor() { }
}
