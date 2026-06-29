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

// Namespace: Unity.Profiling.Memory
public class MemorySnapshotMetadata // TypeDefIndex: 6607
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <Description>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private byte[] <Data>k__BackingField; // 0x18

	// Properties
	public string Description { get; set; }
	internal byte[] Data { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E4AAC4 Offset: 0x1E46AC4 VA: 0x1E4AAC4
	public string get_Description() { }

	[CompilerGenerated]
	// RVA: 0x1E4AACC Offset: 0x1E46ACC VA: 0x1E4AACC
	public void set_Description(string value) { }

	[CompilerGenerated]
	// RVA: 0x1E4AAD4 Offset: 0x1E46AD4 VA: 0x1E4AAD4
	internal byte[] get_Data() { }

	// RVA: 0x1E4AADC Offset: 0x1E46ADC VA: 0x1E4AADC
	public void .ctor() { }
}

// Namespace: Unity.Profiling.Memory
[NativeHeader("Runtime/Profiler/Runtime/MemorySnapshotManager.h")]
public static class MemoryProfiler // TypeDefIndex: 6608
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<string, bool> m_SnapshotFinished; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<MemorySnapshotMetadata> CreatingMetadata; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E4AAE4 Offset: 0x1E46AE4 VA: 0x1E4AAE4
	private static byte[] PrepareMetadata() { }

	// RVA: 0x1E4ACEC Offset: 0x1E46CEC VA: 0x1E4ACEC
	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	// RVA: 0x1E4AD74 Offset: 0x1E46D74 VA: 0x1E4AD74
	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

	[RequiredByNativeCode]
	// RVA: 0x1E4AE64 Offset: 0x1E46E64 VA: 0x1E4AE64
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCode]
	// RVA: 0x1E4AEF8 Offset: 0x1E46EF8 VA: 0x1E4AEF8
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }
}
