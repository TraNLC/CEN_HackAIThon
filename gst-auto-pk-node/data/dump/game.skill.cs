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

// Namespace: game.skill
public class Texture : Active // TypeDefIndex: 2110
{
	// Methods

	// RVA: 0xF98148 Offset: 0xF94148 VA: 0xF98148
	public void Initialize(Transform parent) { }

	// RVA: 0xF98160 Offset: 0xF94160 VA: 0xF98160
	public void Release() { }

	// RVA: 0xF98178 Offset: 0xF94178 VA: 0xF98178
	public GameObject GetAppearance() { }

	// RVA: 0xF98190 Offset: 0xF94190 VA: 0xF98190
	public void SetBreathing(bool isBreathing) { }

	// RVA: 0xF981AC Offset: 0xF941AC VA: 0xF981AC
	public void .ctor() { }
}

// Namespace: 
public static class Definition.SKillStyle // TypeDefIndex: 2111
{
	// Fields
	public const int Missles = 0;
	public const int Melee = 1;
	public const int InitiativeNpcState = 2;
	public const int PassivityNpcState = 3;
	public const int CreateNpc = 4;
	public const int BuildPoison = 5;
	public const int AddPoison = 6;
	public const int GetObjDirectly = 7;
	public const int StrideObstacle = 8;
	public const int BodyToObject = 9;
	public const int Mining = 10;
	public const int RepairWeapon = 11;
	public const int Capture = 12;
	public const int Thief = 13;
	public const int _14 = 14;
}

// Namespace: 
public static class Definition.MisslesForm // TypeDefIndex: 2112
{
	// Fields
	public const int Wall = 0;
	public const int Line = 1;
	public const int Spread = 2;
	public const int Circle = 3;
	public const int Random = 4;
	public const int Zone = 5;
	public const int AtTarget = 6;
	public const int AtFirer = 7;
	public const int COUNT = 8;
}

// Namespace: 
public static class Definition.MeleeForm // TypeDefIndex: 2113
{
	// Fields
	public const int AttackWithBlur = 8;
	public const int Jump = 9;
	public const int JumpAndAttack = 10;
	public const int RunAndAttack = 11;
	public const int ManyAttack = 12;
	public const int Move = 13;
}

// Namespace: 
public static class Definition.MisslesGenerateStyle // TypeDefIndex: 2114
{
	// Fields
	public const int NULL = 0;
	public const int SAMETIME = 1;
	public const int ORDER = 2;
	public const int RANDONORDER = 3;
	public const int RANDONSAME = 4;
	public const int CENTEREXTENDLINE = 5;
}

// Namespace: 
public static class Definition.MissleMoveKind // TypeDefIndex: 2115
{
	// Fields
	public const int Stand = 0;
	public const int Line = 1;
	public const int Random = 2;
	public const int Circle = 3;
	public const int Helix = 4;
	public const int Follow = 5;
	public const int Motion = 6;
	public const int Parabola = 7;
	public const int SingleLine = 8;
	public const int RollBack = 100;
	public const int Toss = 101;
}

// Namespace: 
public static class Definition.MissleStatus // TypeDefIndex: 2116
{
	// Fields
	public const int Wait = 0;
	public const int Fly = 1;
	public const int Vanish = 2;
	public const int Collision = 3;
	public const int End = 4;
}

// Namespace: 
public static class Definition.MissleFollowKind // TypeDefIndex: 2117
{
	// Fields
	public const int None = 0;
	public const int NPC = 1;
	public const int Missle = 2;
}

// Namespace: 
public static class Definition.StateMagicType // TypeDefIndex: 2118
{
	// Fields
	public const int HEAD = 0;
	public const int BODY = 1;
	public const int FOOT = 2;
	public const int TYPE_NUM = 3;
}

// Namespace: 
public static class Definition.ClientAction // TypeDefIndex: 2119
{
	// Fields
	public const int unidentified = 0;
	public const int stand = 1;
	public const int stand1 = 2;
	public const int fightwalk = 3;
	public const int walk = 4;
	public const int fightrun = 5;
	public const int run = 6;
	public const int hurt = 7;
	public const int death = 8;
	public const int attack = 9;
	public const int attack1 = 10;
	public const int magic = 11;
	public const int sit = 12;
	public const int jump = 13;
	public const int none = 14;
	public const int count = 15;
}

// Namespace: game.skill
public class Definition // TypeDefIndex: 2120
{
	// Fields
	public const int MaxMissleStatus = 4;
	public const int MaxMissleDir = 64;
	public static readonly Dictionary<string, int> attackStringActionMapping; // 0x0
	public static readonly Dictionary<int, string> attackClientActionMapping; // 0x8

	// Methods

	// RVA: 0xF981B4 Offset: 0xF941B4 VA: 0xF981B4
	public void .ctor() { }

	// RVA: 0xF981BC Offset: 0xF941BC VA: 0xF981BC
	private static void .cctor() { }
}

// Namespace: game.skill
public class Missile : Active // TypeDefIndex: 2121
{
	// Fields
	public static readonly Missile Empty; // 0x0

	// Methods

	// RVA: 0xF9839C Offset: 0xF9439C VA: 0xF9839C
	public void .ctor() { }

	// RVA: 0xF983C8 Offset: 0xF943C8 VA: 0xF983C8
	public void .ctor(Skill skill, Params.Cast castParams) { }

	// RVA: 0xF984DC Offset: 0xF944DC VA: 0xF984DC
	public static List<Missile> EmptyList() { }

	// RVA: 0xF98544 Offset: 0xF94544 VA: 0xF98544
	private static void .cctor() { }
}

// Namespace: game.skill
public static class Damage // TypeDefIndex: 2122
{
	// Methods

	// RVA: 0xF985BC Offset: 0xF945BC VA: 0xF985BC
	public static bool Process(Params.Owner launch, Params.Owner target, Skill skillResource) { }
}

// Namespace: game.skill
public class skillStyleInitiative : skillStyleMissile // TypeDefIndex: 2123
{
	// Methods

	// RVA: 0xF985C4 Offset: 0xF945C4 VA: 0xF985C4
	public List<Missile> CastInitiative(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF98610 Offset: 0xF94610 VA: 0xF98610
	public void .ctor() { }
}

// Namespace: game.skill
public class skillStylePassivity : skillStyleInitiative // TypeDefIndex: 2124
{
	// Methods

	// RVA: 0xF98618 Offset: 0xF94618 VA: 0xF98618
	public List<Missile> CastPassivity(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF98664 Offset: 0xF94664 VA: 0xF98664
	public void .ctor() { }
}

// Namespace: game.skill
[NullableContext(1)]
[Nullable(0)]
public class SkillCast : skillStyleMelee // TypeDefIndex: 2125
{
	// Methods

	// RVA: 0xF98668 Offset: 0xF94668 VA: 0xF98668
	private void OnCast(List<Missile> result, Params.Cast castParams) { }

	// RVA: 0xF98760 Offset: 0xF94760 VA: 0xF98760
	public List<Missile> Cast(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF98AE0 Offset: 0xF94AE0 VA: 0xF98AE0
	public void .ctor() { }
}

// Namespace: 
public class SkillData.Settings // TypeDefIndex: 2126
{
	// Fields
	public Skill skill; // 0x10
	public Missile missile; // 0x18

	// Methods

	// RVA: 0xF98B8C Offset: 0xF94B8C VA: 0xF98B8C
	public void .ctor() { }
}

// Namespace: game.skill
public class SkillData // TypeDefIndex: 2127
{
	// Fields
	protected Skill self; // 0x10
	public SkillData.Settings settings; // 0x18

	// Methods

	// RVA: 0xF98AE8 Offset: 0xF94AE8 VA: 0xF98AE8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class skillStyleMelee.<>c__DisplayClass1_0 // TypeDefIndex: 2128
{
	// Fields
	[Nullable(0)]
	public Params.Cast castParams; // 0x10

	// Methods

	// RVA: 0xF992F0 Offset: 0xF952F0 VA: 0xF992F0
	public void .ctor() { }

	// RVA: 0xF99300 Offset: 0xF95300 VA: 0xF99300
	internal void <MeleeMove>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class skillStyleMelee.<>c__DisplayClass4_0 // TypeDefIndex: 2129
{
	// Fields
	[Nullable(0)]
	public skillStyleMelee <>4__this; // 0x10
	[Nullable(0)]
	public Params.Cast castParams; // 0x18

	// Methods

	// RVA: 0xF992F8 Offset: 0xF952F8 VA: 0xF992F8
	public void .ctor() { }

	// RVA: 0xF9933C Offset: 0xF9533C VA: 0xF9933C
	internal void <MeleeRunAndAttack>b__0() { }
}

// Namespace: game.skill
[NullableContext(1)]
[Nullable(0)]
public class skillStyleMelee : skillStylePassivity // TypeDefIndex: 2130
{
	// Methods

	// RVA: 0xF989D0 Offset: 0xF949D0 VA: 0xF989D0
	public List<Missile> CastMelee(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF990F0 Offset: 0xF950F0 VA: 0xF990F0
	private List<Missile> MeleeMove(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF99058 Offset: 0xF95058 VA: 0xF99058
	private List<Missile> MeleeJump(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF98C38 Offset: 0xF94C38 VA: 0xF98C38
	private List<Missile> MeleeManyAttack(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF98E68 Offset: 0xF94E68 VA: 0xF98E68
	private List<Missile> MeleeRunAndAttack(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF98AE4 Offset: 0xF94AE4 VA: 0xF98AE4
	public void .ctor() { }
}

// Namespace: game.skill
public class skillStyleMissile : Firer // TypeDefIndex: 2131
{
	// Methods

	[NullableContext(1)]
	// RVA: 0xF9885C Offset: 0xF9485C VA: 0xF9885C
	public List<Missile> CastMissile(Params.Cast castParams, Params.Options options) { }

	// RVA: 0xF98614 Offset: 0xF94614 VA: 0xF98614
	public void .ctor() { }
}
