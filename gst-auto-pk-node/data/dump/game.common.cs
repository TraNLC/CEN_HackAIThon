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

// Namespace: game.common
public static class Faction // TypeDefIndex: 2509
{
	// Fields
	private static readonly Dictionary<int, Sprite> factionIconCached; // 0x0

	// Methods

	// RVA: 0xFE6E1C Offset: 0xFE2E1C VA: 0xFE6E1C
	public static string GetNameFromSect(int sect) { }

	// RVA: 0xFE6EF0 Offset: 0xFE2EF0 VA: 0xFE6EF0
	public static string GetNameFromFaction(int faction) { }

	// RVA: 0xFE6FC8 Offset: 0xFE2FC8 VA: 0xFE6FC8
	public static string GetNameShortFromFaction(int faction) { }

	// RVA: 0xFE70A0 Offset: 0xFE30A0 VA: 0xFE70A0
	public static int GetCampFromSect(int sect) { }

	// RVA: 0xFE70C0 Offset: 0xFE30C0 VA: 0xFE70C0
	public static Sprite GetIcon(int factionid) { }

	// RVA: 0xFE728C Offset: 0xFE328C VA: 0xFE728C
	private static void .cctor() { }
}

// Namespace: game.common
public static class FightMode // TypeDefIndex: 2510
{
	// Fields
	public const int peace = 0;
	public const int fighting = 1;
}

// Namespace: game.common
public static class PK // TypeDefIndex: 2511
{
	// Fields
	public const int train = 0;
	public const int fight = 1;
	public const int killer = 2;
	public const int banghoi = 3;
}

// Namespace: game.common
public static class Camp // TypeDefIndex: 2512
{
	// Fields
	public const int begin = 0;
	public const int justice = 1;
	public const int evil = 2;
	public const int balance = 3;
	public const int free = 4;
	public const int noneall = 5;
}

// Namespace: game.common
public static class Relation // TypeDefIndex: 2513
{
	// Fields
	public const int none = 1;
	public const int self = 2;
	public const int ally = 4;
	public const int enemy = 8;
	public const int requireBangHoi = 16;
}

// Namespace: game.common
public static class Security // TypeDefIndex: 2514
{
	// Fields
	private static readonly byte slashCharValue; // 0x0
	private static readonly byte slashByteValue; // 0x1

	// Methods

	// RVA: 0xFE7324 Offset: 0xFE3324 VA: 0xFE7324
	public static byte[] ByteDecode(string watermark, string passcode, byte[] data) { }

	// RVA: 0xFE54F0 Offset: 0xFE14F0 VA: 0xFE54F0
	public static string PasscodeEncode(int passcode, string[] data) { }

	// RVA: 0xFE7978 Offset: 0xFE3978 VA: 0xFE7978
	public static int CalculateBufferLengthFromBase64(string base64String) { }

	// RVA: 0xFE37F4 Offset: 0xFDF7F4 VA: 0xFE37F4
	public static string[] PasscodeDecode(int passcode, string dataString) { }

	// RVA: 0xFE7A14 Offset: 0xFE3A14 VA: 0xFE7A14
	private static void .cctor() { }
}

// Namespace: game.common
public static class Series // TypeDefIndex: 2515
{
	// Fields
	public const int unidentified = -1;
	public const int metal = 0;
	public const int wood = 1;
	public const int water = 2;
	public const int fire = 3;
	public const int earth = 4;
}

// Namespace: 
public enum Vibration.Level // TypeDefIndex: 2516
{
	// Fields
	public int value__; // 0x0
	public const Vibration.Level light = 0;
	public const Vibration.Level medium = 1;
	public const Vibration.Level heavy = 2;
}

// Namespace: game.common
public static class Vibration // TypeDefIndex: 2517
{
	// Fields
	private static Action vibrateFunction; // 0x0
	public static bool vibrateOnReceiveDamage; // 0x8
	public static bool vibrateOnCollideSkill; // 0x9
	public static bool vibrateOnCastSkill; // 0xA

	// Methods

	// RVA: 0xFE7AB8 Offset: 0xFE3AB8 VA: 0xFE7AB8
	public static void SetLevel(Vibration.Level level) { }

	// RVA: 0xFE7BDC Offset: 0xFE3BDC VA: 0xFE7BDC
	public static void Vibrated() { }

	// RVA: 0xFE7CDC Offset: 0xFE3CDC VA: 0xFE7CDC
	public static void OnCastSkill() { }

	// RVA: 0xFE7D50 Offset: 0xFE3D50 VA: 0xFE7D50
	public static void OnCollideSkill() { }

	// RVA: 0xFE7DC4 Offset: 0xFE3DC4 VA: 0xFE7DC4
	public static void OnReceiveDamage() { }

	// RVA: 0xFE7E38 Offset: 0xFE3E38 VA: 0xFE7E38
	private static void .cctor() { }
}
