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

// Namespace: UnityEngineInternal
[Il2CppEagerStaticClassConstruction]
public struct MathfInternal // TypeDefIndex: 6585
{
	// Fields
	public static float FloatMinNormal; // 0x0
	public static float FloatMinDenormal; // 0x4
	public static bool IsFlushToZeroEnabled; // 0x8

	// Methods

	// RVA: 0x1E4A0A8 Offset: 0x1E460A8 VA: 0x1E4A0A8
	private static void .cctor() { }
}

// Namespace: UnityEngineInternal
public enum TypeInferenceRules // TypeDefIndex: 6586
{
	// Fields
	public int value__; // 0x0
	public const TypeInferenceRules TypeReferencedByFirstArgument = 0;
	public const TypeInferenceRules TypeReferencedBySecondArgument = 1;
	public const TypeInferenceRules ArrayOfTypeReferencedByFirstArgument = 2;
	public const TypeInferenceRules TypeOfFirstArgument = 3;
}

// Namespace: UnityEngineInternal
[Usage(64)]
[Serializable]
public class TypeInferenceRuleAttribute : Attribute // TypeDefIndex: 6587
{
	// Fields
	private readonly string _rule; // 0x10

	// Methods

	// RVA: 0x1E4A140 Offset: 0x1E46140 VA: 0x1E4A140
	public void .ctor(TypeInferenceRules rule) { }

	// RVA: 0x1E4A1D0 Offset: 0x1E461D0 VA: 0x1E4A1D0
	public void .ctor(string rule) { }

	// RVA: 0x1E4A200 Offset: 0x1E46200 VA: 0x1E4A200 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngineInternal
public class GenericStack : Stack // TypeDefIndex: 6588
{
	// Methods

	// RVA: 0x1E4A208 Offset: 0x1E46208 VA: 0x1E4A208
	public void .ctor() { }
}

// Namespace: UnityEngineInternal
internal static class WebRequestUtils // TypeDefIndex: 7950
{
	// Fields
	private static Regex domainRegex; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1F2337C Offset: 0x1F1F37C VA: 0x1F2337C
	internal static string RedirectTo(string baseUri, string redirectUri) { }

	// RVA: 0x1F23468 Offset: 0x1F1F468 VA: 0x1F23468
	internal static string MakeInitialUrl(string targetUrl, string localUrl) { }

	// RVA: 0x1F237D8 Offset: 0x1F1F7D8 VA: 0x1F237D8
	internal static string MakeUriString(Uri targetUri, string targetUrl, bool prependProtocol) { }

	// RVA: 0x1F23BB8 Offset: 0x1F1FBB8 VA: 0x1F23BB8
	private static string URLDecode(string encoded) { }

	// RVA: 0x1F23CC0 Offset: 0x1F1FCC0 VA: 0x1F23CC0
	private static void .cctor() { }
}
