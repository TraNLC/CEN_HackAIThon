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

// Namespace: Unity.Profiling
[RequiredByNativeCode]
[Usage(76, AllowMultiple = False)]
public sealed class IgnoredByDeepProfilerAttribute : Attribute // TypeDefIndex: 6599
{
	// Methods

	// RVA: 0x1E4A564 Offset: 0x1E46564 VA: 0x1E4A564
	public void .ctor() { }
}

// Namespace: Unity.Profiling
public enum ProfilerCategoryColor // TypeDefIndex: 6600
{
	// Fields
	public ushort value__; // 0x0
	public const ProfilerCategoryColor Render = 0;
	public const ProfilerCategoryColor Scripts = 1;
	public const ProfilerCategoryColor BurstJobs = 2;
	public const ProfilerCategoryColor Other = 3;
	public const ProfilerCategoryColor Physics = 4;
	public const ProfilerCategoryColor Animation = 5;
	public const ProfilerCategoryColor Audio = 6;
	public const ProfilerCategoryColor AudioJob = 7;
	public const ProfilerCategoryColor AudioUpdateJob = 8;
	public const ProfilerCategoryColor Lighting = 9;
	public const ProfilerCategoryColor GC = 10;
	public const ProfilerCategoryColor VSync = 11;
	public const ProfilerCategoryColor Memory = 12;
	public const ProfilerCategoryColor Internal = 13;
	public const ProfilerCategoryColor UI = 14;
	public const ProfilerCategoryColor Build = 15;
	public const ProfilerCategoryColor Input = 16;
}

// Namespace: 
[IgnoredByDeepProfiler]
[UsedByNativeCode]
public struct ProfilerMarker.AutoScope : IDisposable // TypeDefIndex: 6601
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal readonly IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x1E4A76C Offset: 0x1E4676C VA: 0x1E4A76C
	internal void .ctor(IntPtr markerPtr) { }

	// RVA: 0x1E4A7F0 Offset: 0x1E467F0 VA: 0x1E4A7F0 Slot: 4
	public void Dispose() { }
}

// Namespace: Unity.Profiling
[UsedByNativeCode]
[IgnoredByDeepProfiler]
public struct ProfilerMarker // TypeDefIndex: 6602
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal readonly IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x1E4A56C Offset: 0x1E4656C VA: 0x1E4A56C
	public void .ctor(string name) { }

	[Pure]
	// RVA: 0x1E4A724 Offset: 0x1E46724 VA: 0x1E4A724
	public ProfilerMarker.AutoScope Auto() { }
}

// Namespace: Unity.Profiling
[Flags]
public enum ProfilerCounterOptions // TypeDefIndex: 6603
{
	// Fields
	public ushort value__; // 0x0
	public const ProfilerCounterOptions None = 0;
	public const ProfilerCounterOptions FlushOnEndOfFrame = 2;
	public const ProfilerCounterOptions ResetToZeroOnFlush = 4;
}

// Namespace: Unity.Profiling
public struct DebugScreenCapture // TypeDefIndex: 6604
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private NativeArray<byte> <RawImageDataReference>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private TextureFormat <ImageFormat>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <Width>k__BackingField; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <Height>k__BackingField; // 0x18

	// Properties
	public NativeArray<byte> RawImageDataReference { set; }
	public TextureFormat ImageFormat { set; }
	public int Width { set; }
	public int Height { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E4A878 Offset: 0x1E46878 VA: 0x1E4A878
	public void set_RawImageDataReference(NativeArray<byte> value) { }

	[CompilerGenerated]
	// RVA: 0x1E4A880 Offset: 0x1E46880 VA: 0x1E4A880
	public void set_ImageFormat(TextureFormat value) { }

	[CompilerGenerated]
	// RVA: 0x1E4A888 Offset: 0x1E46888 VA: 0x1E4A888
	public void set_Width(int value) { }

	[CompilerGenerated]
	// RVA: 0x1E4A890 Offset: 0x1E46890 VA: 0x1E4A890
	public void set_Height(int value) { }
}
