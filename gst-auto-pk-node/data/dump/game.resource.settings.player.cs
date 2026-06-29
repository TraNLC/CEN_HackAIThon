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

// Namespace: game.resource.settings.player
public static class Basevalue // TypeDefIndex: 2233
{
	// Methods

	// RVA: 0xFB2A0C Offset: 0xFAEA0C VA: 0xFB2A0C
	public static bool Initialize(Action<string> logfunc) { }
}

// Namespace: 
public enum LevelAdd.HeaderIndexer // TypeDefIndex: 2234
{
	// Fields
	public int value__; // 0x0
	public const LevelAdd.HeaderIndexer seriesName = 0;
	public const LevelAdd.HeaderIndexer seriesValue = 1;
	public const LevelAdd.HeaderIndexer staminaBase = 2;
	public const LevelAdd.HeaderIndexer lifePer100Level = 3;
	public const LevelAdd.HeaderIndexer staminaPer100Level = 4;
	public const LevelAdd.HeaderIndexer manaPer100Level = 5;
	public const LevelAdd.HeaderIndexer evadePer100Level = 6;
	public const LevelAdd.HeaderIndexer accuracyPer100Level = 7;
	public const LevelAdd.HeaderIndexer fireresPer100Level = 8;
	public const LevelAdd.HeaderIndexer coldresPer100Level = 9;
	public const LevelAdd.HeaderIndexer poisonresPer100Level = 10;
	public const LevelAdd.HeaderIndexer lightingresPer100Level = 11;
	public const LevelAdd.HeaderIndexer physicresPer100Level = 12;
	public const LevelAdd.HeaderIndexer lifePer100Vitality = 13;
	public const LevelAdd.HeaderIndexer staminaPer100Vitality = 14;
	public const LevelAdd.HeaderIndexer manaPer100Energy = 15;
	public const LevelAdd.HeaderIndexer damagePer100Strengility = 16;
	public const LevelAdd.HeaderIndexer damagePer100Energy = 17;
	public const LevelAdd.HeaderIndexer damagePer100Agility = 18;
	public const LevelAdd.HeaderIndexer evadePer100Agility = 19;
	public const LevelAdd.HeaderIndexer accuracyPer100Agility = 20;
	public const LevelAdd.HeaderIndexer _COUNT = 21;
}

// Namespace: 
public class LevelAdd.Info // TypeDefIndex: 2235
{
	// Fields
	[Nullable(1)]
	public string seriesName; // 0x10
	public int seriesValue; // 0x18
	public int staminaBase; // 0x1C
	public float lifePerLevel; // 0x20
	public float staminaPerLevel; // 0x24
	public float manaPerLevel; // 0x28
	public float evadePerLevel; // 0x2C
	public float accuracyPerLevel; // 0x30
	public float fireresPerLevel; // 0x34
	public float coldresPerLevel; // 0x38
	public float poisonresPerLevel; // 0x3C
	public float lightingresPerLevel; // 0x40
	public float physicresPerLevel; // 0x44
	public float lifePerVitality; // 0x48
	public float staminaPerVitality; // 0x4C
	public float manaPerEnergy; // 0x50
	public float damagePerStrengility; // 0x54
	public float damagePerEnergy; // 0x58
	public float damagePerAgility; // 0x5C
	public float evadePerAgility; // 0x60
	public float accuracyPerAgility; // 0x64

	// Methods

	// RVA: 0xFB3338 Offset: 0xFAF338 VA: 0xFB3338
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LevelAdd.<>c // TypeDefIndex: 2236
{
	// Fields
	public static readonly LevelAdd.<>c <>9; // 0x0
	[Nullable(new[] { 0, 1 })]
	public static Action<string> <>9__4_0; // 0x8

	// Methods

	// RVA: 0xFB3374 Offset: 0xFAF374 VA: 0xFB3374
	private static void .cctor() { }

	// RVA: 0xFB33DC Offset: 0xFAF3DC VA: 0xFB33DC
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0xFB33E4 Offset: 0xFAF3E4 VA: 0xFB33E4
	internal void <Get>b__4_0(string _) { }
}

// Namespace: game.resource.settings.player
public static class LevelAdd // TypeDefIndex: 2237
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	private static Dictionary<int, LevelAdd.Info> seriesMapping; // 0x0

	// Methods

	// RVA: 0xFB2C90 Offset: 0xFAEC90 VA: 0xFB2C90
	public static void Release() { }

	[NullableContext(2)]
	// RVA: 0xFB2CE4 Offset: 0xFAECE4 VA: 0xFB2CE4
	public static LevelAdd.Info Get(int series) { }

	[NullableContext(1)]
	// RVA: 0xFB2E90 Offset: 0xFAEE90 VA: 0xFB2E90
	public static bool Initialize(Action<string> logfunc) { }
}

// Namespace: 
public enum LevelExp.HeaderIndexer // TypeDefIndex: 2238
{
	// Fields
	public int value__; // 0x0
	public const LevelExp.HeaderIndexer level = 0;
	public const LevelExp.HeaderIndexer ExpServer0 = 1;
	public const LevelExp.HeaderIndexer ExpServer1 = 2;
}

// Namespace: game.resource.settings.player
public static class LevelExp // TypeDefIndex: 2239
{
	// Fields
	private static Table storage; // 0x0
	private static Dictionary<int, long> cached; // 0x8
	private static int currentServerRegion; // 0x10

	// Methods

	// RVA: 0xFB33E8 Offset: 0xFAF3E8 VA: 0xFB33E8
	public static bool Initialize(Action<string> logfunc) { }

	// RVA: 0xFB3504 Offset: 0xFAF504 VA: 0xFB3504
	public static void SetServerRegion(int region) { }

	// RVA: 0xFB35B0 Offset: 0xFAF5B0 VA: 0xFB35B0
	public static long Get(int level) { }

	// RVA: 0xFB37C8 Offset: 0xFAF7C8 VA: 0xFB37C8
	private static void .cctor() { }
}

// Namespace: 
public class RunInterval.Data // TypeDefIndex: 2240
{
	// Fields
	public int speed; // 0x10
	public float runningManInterval; // 0x14
	public float runningManAudio; // 0x18
	public float runningGirlInterval; // 0x1C
	public float runningGirlAudio; // 0x20
	public float ridingInterval; // 0x24
	public float ridingAudio; // 0x28

	// Methods

	// RVA: 0xFB410C Offset: 0xFB010C VA: 0xFB410C
	public void .ctor() { }
}

// Namespace: 
private enum RunInterval.HeaderIndexer // TypeDefIndex: 2241
{
	// Fields
	public int value__; // 0x0
	public const RunInterval.HeaderIndexer speed = 0;
	public const RunInterval.HeaderIndexer runManInterval = 1;
	public const RunInterval.HeaderIndexer runManAudio = 2;
	public const RunInterval.HeaderIndexer runGirlInterval = 3;
	public const RunInterval.HeaderIndexer runGirlAudio = 4;
	public const RunInterval.HeaderIndexer ridingInterval = 5;
	public const RunInterval.HeaderIndexer ridingAudio = 6;
}

// Namespace: game.resource.settings.player
public static class RunInterval // TypeDefIndex: 2242
{
	// Fields
	private static readonly Dictionary<float, RunInterval.Data> mapping; // 0x0
	private static int speedLowest; // 0x8
	private static int speedHighest; // 0xC
	private static readonly RunInterval.Data Empty; // 0x10

	// Methods

	// RVA: 0xFB3884 Offset: 0xFAF884 VA: 0xFB3884
	public static void SetRunningAudio(int speed, float audioRunning) { }

	// RVA: 0xFB3930 Offset: 0xFAF930 VA: 0xFB3930
	public static void SetRidingAudio(int speed, float audioRiding) { }

	// RVA: 0xFB39D8 Offset: 0xFAF9D8 VA: 0xFB39D8
	public static float GetRunInterval(int speed, bool isRiding, bool isManSex) { }

	// RVA: 0xFB3C14 Offset: 0xFAFC14 VA: 0xFB3C14
	public static float GetRunAudio(float speed, bool isManSex) { }

	// RVA: 0xFB3CA8 Offset: 0xFAFCA8 VA: 0xFB3CA8
	public static float GetRidingAudio(float speed) { }

	// RVA: 0xFB3A90 Offset: 0xFAFA90 VA: 0xFB3A90
	public static RunInterval.Data Get(float speed) { }

	// RVA: 0xFB3D14 Offset: 0xFAFD14 VA: 0xFB3D14
	public static void Initialize() { }

	// RVA: 0xFB4114 Offset: 0xFB0114 VA: 0xFB4114
	private static void .cctor() { }
}

// Namespace: 
public class Controller.AnimateHandler // TypeDefIndex: 2243
{
	// Fields
	public bool isSpecialNpc; // 0x10
	public Animate special; // 0x18
	public Animate normal; // 0x20

	// Methods

	// RVA: 0xFB6098 Offset: 0xFB2098 VA: 0xFB6098
	public Dictionary<string, Structures.PartAnimation> SetDirection(int direction) { }

	// RVA: 0xFB7628 Offset: 0xFB3628 VA: 0xFB7628
	public int GetDirection() { }

	// RVA: 0xFB6210 Offset: 0xFB2210 VA: 0xFB6210
	public Dictionary<string, Structures.PartAnimation> SetAction(string _action) { }

	// RVA: 0xFB6248 Offset: 0xFB2248 VA: 0xFB6248
	public Dictionary<string, Structures.PartAnimation> GetPartAnimation() { }

	// RVA: 0xFB4AA4 Offset: 0xFB0AA4 VA: 0xFB4AA4
	public void .ctor() { }
}

// Namespace: 
private class Controller.Trail // TypeDefIndex: 2244
{
	// Fields
	public float loopCreateTime; // 0x10
	public float elementLifeTime; // 0x14
	public float lifeFrameOn18fps; // 0x18
	public bool randomFrame; // 0x1C
	public float nextCreateTime; // 0x20
	public Color color; // 0x24

	// Methods

	// RVA: 0xFB7AF0 Offset: 0xFB3AF0 VA: 0xFB7AF0
	public void .ctor() { }
}

// Namespace: 
public class Controller.AnimateParams // TypeDefIndex: 2245
{
	// Fields
	public string action; // 0x10
	public int direction; // 0x18
	public readonly Queue<Action> onActionEnd; // 0x20
	public float frameRateOn18Fps; // 0x28
	public float frameCurrently; // 0x2C

	// Methods

	// RVA: 0xFB4AAC Offset: 0xFB0AAC VA: 0xFB4AAC
	public void .ctor(int direction) { }
}

// Namespace: 
public class Controller.StateStatureColor // TypeDefIndex: 2246
{
	// Fields
	public static Color adjustColorNormal; // 0x0
	public static readonly Color adjustColorCold; // 0x10
	public static readonly Color adjustColorPoison; // 0x20

	// Methods

	// RVA: 0xFBB8E8 Offset: 0xFB78E8 VA: 0xFBB8E8
	public void .ctor() { }

	// RVA: 0xFBB8F0 Offset: 0xFB78F0 VA: 0xFBB8F0
	private static void .cctor() { }
}

// Namespace: 
public class Controller.JumpHeight // TypeDefIndex: 2247
{
	// Fields
	private float zacc; // 0x10
	private float heightSpeed; // 0x14
	private float heightCurrent; // 0x18
	private float deltaOn18fps; // 0x1C
	private float targetLast; // 0x20
	private float targetPrevious; // 0x24
	private float targetFactor; // 0x28

	// Methods

	// RVA: 0xFB7FE4 Offset: 0xFB3FE4 VA: 0xFB7FE4
	public void .ctor(float timeOn18fps) { }

	// RVA: 0xFBB960 Offset: 0xFB7960 VA: 0xFBB960
	private float GetNextFrame() { }

	// RVA: 0xFB54E4 Offset: 0xFB14E4 VA: 0xFB54E4
	public float GetHeight(float targetFrameRate) { }
}

// Namespace: 
public class Controller.PerformEachFrameC // TypeDefIndex: 2248
{
	// Fields
	public Queue<Action> queue; // 0x10

	// Methods

	// RVA: 0xFBB820 Offset: 0xFB7820 VA: 0xFBB820
	public void Add(Action action) { }

	// RVA: 0xFB6A30 Offset: 0xFB2A30 VA: 0xFB6A30
	public void Perform() { }

	// RVA: 0xFB4B6C Offset: 0xFB0B6C VA: 0xFB4B6C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Controller.<>c__DisplayClass52_0 // TypeDefIndex: 2249
{
	// Fields
	public Controller <>4__this; // 0x10
	public bool isMainPlayer; // 0x18
	public Action onTimeout; // 0x20

	// Methods

	// RVA: 0xFB71E0 Offset: 0xFB31E0 VA: 0xFB71E0
	public void .ctor() { }

	// RVA: 0xFBB970 Offset: 0xFB7970 VA: 0xFBB970
	internal void <SetStealth>b__0() { }

	// RVA: 0xFBBAC8 Offset: 0xFB7AC8 VA: 0xFBBAC8
	internal void <SetStealth>b__1() { }
}
