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

// Namespace: Internal.Cryptography
[Extension]
internal static class Helpers // TypeDefIndex: 104
{
	// Methods

	[Extension]
	// RVA: 0x17359B8 Offset: 0x17319B8 VA: 0x17359B8
	public static byte[] CloneByteArray(byte[] src) { }

	[Extension]
	// RVA: 0x1735A30 Offset: 0x1731A30 VA: 0x1735A30
	public static char[] ToHexArrayUpper(byte[] bytes) { }

	[Extension]
	// RVA: 0x1735B2C Offset: 0x1731B2C VA: 0x1735B2C
	public static string ToHexStringUpper(byte[] bytes) { }

	// RVA: 0x1735B10 Offset: 0x1731B10 VA: 0x1735B10
	private static char NibbleToHex(byte b) { }
}

// Namespace: 
private enum string.TrimType // TypeDefIndex: 105
{
	// Fields
	public int value__; // 0x0
	public const string.TrimType Head = 0;
	public const string.TrimType Tail = 1;
	public const string.TrimType Both = 2;
}

// Namespace: 
private struct string.ProbabilisticMap // TypeDefIndex: 106
{}

// Namespace: Internal.Cryptography
internal static class OidLookup // TypeDefIndex: 3819
{
	// Fields
	private static readonly ConcurrentDictionary<string, string> s_lateBoundOidToFriendlyName; // 0x0
	private static readonly ConcurrentDictionary<string, string> s_lateBoundFriendlyNameToOid; // 0x8
	private static readonly Dictionary<string, string> s_friendlyNameToOid; // 0x10
	private static readonly Dictionary<string, string> s_oidToFriendlyName; // 0x18
	private static readonly Dictionary<string, string> s_compatOids; // 0x20

	// Methods

	// RVA: 0x1A2AB40 Offset: 0x1A26B40 VA: 0x1A2AB40
	public static string ToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x1A2B038 Offset: 0x1A27038 VA: 0x1A2B038
	public static string ToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x1A2AD1C Offset: 0x1A26D1C VA: 0x1A2AD1C
	private static bool ShouldUseCache(OidGroup oidGroup) { }

	// RVA: 0x1A2AD24 Offset: 0x1A26D24 VA: 0x1A2AD24
	private static string NativeOidToFriendlyName(string oid, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x1A2B1E8 Offset: 0x1A271E8 VA: 0x1A2B1E8
	private static string NativeFriendlyNameToOid(string friendlyName, OidGroup oidGroup, bool fallBackToAllGroups) { }

	// RVA: 0x1A2B504 Offset: 0x1A27504 VA: 0x1A2B504
	private static void .cctor() { }
}
