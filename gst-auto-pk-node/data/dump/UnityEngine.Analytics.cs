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

// Namespace: UnityEngine.Analytics
[Flags]
public enum SendEventOptions // TypeDefIndex: 7113
{
	// Fields
	public int value__; // 0x0
	public const SendEventOptions kAppendNone = 0;
	public const SendEventOptions kAppendBuildGuid = 1;
	public const SendEventOptions kAppendBuildTarget = 2;
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
public class AnalyticsEventBase // TypeDefIndex: 7114
{
	// Fields
	private string eventName; // 0x10
	private int eventVersion; // 0x18
	private string eventPrefix; // 0x20
	private SendEventOptions sendEventOptions; // 0x28

	// Methods

	// RVA: 0x1E80380 Offset: 0x1E7C380 VA: 0x1E80380
	public void .ctor(string eventName, int eventVersion, SendEventOptions sendEventOptions = 0, string eventPrefix = "") { }
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
internal class BatchRenderGroupUsageAnalytic : AnalyticsEventBase // TypeDefIndex: 7115
{
	// Fields
	public int maxBRGInstance; // 0x2C
	public int maxMeshCount; // 0x30
	public int maxMaterialCount; // 0x34
	public int maxDrawCommandBatch; // 0x38

	// Methods

	// RVA: 0x1E803DC Offset: 0x1E7C3DC VA: 0x1E803DC
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x1E8044C Offset: 0x1E7C44C VA: 0x1E8044C
	public static BatchRenderGroupUsageAnalytic CreateBatchRenderGroupUsageAnalytic() { }
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
internal class UaaLApplicationLaunchAnalytic : AnalyticsEventBase // TypeDefIndex: 7116
{
	// Fields
	public int launch_type; // 0x2C
	public int launch_process_type; // 0x30

	// Methods

	// RVA: 0x1E8049C Offset: 0x1E7C49C VA: 0x1E8049C
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x1E8050C Offset: 0x1E7C50C VA: 0x1E8050C
	public static UaaLApplicationLaunchAnalytic CreateUaaLApplicationLaunchAnalytic() { }
}

// Namespace: UnityEngine.Analytics
[RequiredByNativeCode(GenerateProxy = True)]
[ExcludeFromDocs]
[Serializable]
internal class ShaderRuntimeInfoAnalytic : AnalyticsEventBase // TypeDefIndex: 7117
{
	// Fields
	public long VariantsRequested; // 0x30
	public long VariantsRequestedMissing; // 0x38
	public long VariantsRequestedUnsupported; // 0x40
	public long VariantsRequestedCompiled; // 0x48
	public long VariantsRequestedViaWarmup; // 0x50
	public long VariantsUnused; // 0x58
	public int VariantsCompilationTimeTotal; // 0x60
	public int VariantsCompilationTimeMax; // 0x64
	public int VariantsCompilationTimeMedian; // 0x68
	public int VariantsWarmupTimeTotal; // 0x6C
	public int VariantsWarmupTimeMax; // 0x70
	public int VariantsWarmupTimeMedian; // 0x74
	public bool UseProgressiveWarmup; // 0x78
	public int ShaderChunkSizeMin; // 0x7C
	public int ShaderChunkSizeMax; // 0x80
	public int ShaderChunkSizeAvg; // 0x84
	public int ShaderChunkCountMin; // 0x88
	public int ShaderChunkCountMax; // 0x8C
	public int ShaderChunkCountAvg; // 0x90

	// Methods

	// RVA: 0x1E8055C Offset: 0x1E7C55C VA: 0x1E8055C
	private void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x1E805E8 Offset: 0x1E7C5E8 VA: 0x1E805E8
	public static ShaderRuntimeInfoAnalytic CreateShaderRuntimeInfoAnalytic() { }
}
