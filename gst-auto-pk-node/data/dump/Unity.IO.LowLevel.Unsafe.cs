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

// Namespace: Unity.IO.LowLevel.Unsafe
[RequiredByNativeCode]
public enum FileState // TypeDefIndex: 6609
{
	// Fields
	public int value__; // 0x0
	public const FileState Absent = 0;
	public const FileState Exists = 1;
}

// Namespace: Unity.IO.LowLevel.Unsafe
public enum AssetLoadingSubsystem // TypeDefIndex: 6610
{
	// Fields
	public int value__; // 0x0
	public const AssetLoadingSubsystem Other = 0;
	public const AssetLoadingSubsystem Texture = 1;
	public const AssetLoadingSubsystem VirtualTexture = 2;
	public const AssetLoadingSubsystem Mesh = 3;
	public const AssetLoadingSubsystem Audio = 4;
	public const AssetLoadingSubsystem Scripts = 5;
	public const AssetLoadingSubsystem EntitiesScene = 6;
	public const AssetLoadingSubsystem EntitiesStreamBinaryReader = 7;
	public const AssetLoadingSubsystem FileInfo = 8;
	public const AssetLoadingSubsystem ContentLoading = 9;
}

// Namespace: Unity.IO.LowLevel.Unsafe
[RequiredByNativeCode]
public enum Priority // TypeDefIndex: 6611
{
	// Fields
	public int value__; // 0x0
	public const Priority PriorityLow = 0;
	public const Priority PriorityHigh = 1;
}

// Namespace: Unity.IO.LowLevel.Unsafe
[NativeHeader("Runtime/File/AsyncReadManagerMetrics.h")]
public enum ProcessingState // TypeDefIndex: 6612
{
	// Fields
	public int value__; // 0x0
	public const ProcessingState Unknown = 0;
	public const ProcessingState InQueue = 1;
	public const ProcessingState Reading = 2;
	public const ProcessingState Completed = 3;
	public const ProcessingState Failed = 4;
	public const ProcessingState Canceled = 5;
}

// Namespace: Unity.IO.LowLevel.Unsafe
public enum FileReadType // TypeDefIndex: 6613
{
	// Fields
	public int value__; // 0x0
	public const FileReadType Sync = 0;
	public const FileReadType Async = 1;
}

// Namespace: Unity.IO.LowLevel.Unsafe
[NativeConditional("ENABLE_PROFILER")]
[RequiredByNativeCode]
public struct AsyncReadManagerRequestMetric // TypeDefIndex: 6614
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <AssetName>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ulong <OffsetBytes>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ulong <SizeBytes>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ulong <AssetTypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ulong <CurrentBytesRead>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly uint <BatchReadCount>k__BackingField; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly bool <IsBatchRead>k__BackingField; // 0x34
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly ProcessingState <State>k__BackingField; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly FileReadType <ReadType>k__BackingField; // 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Priority <PriorityLevel>k__BackingField; // 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly AssetLoadingSubsystem <Subsystem>k__BackingField; // 0x44
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly double <RequestTimeMicroseconds>k__BackingField; // 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly double <TimeInQueueMicroseconds>k__BackingField; // 0x50
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly double <TotalTimeMicroseconds>k__BackingField; // 0x58
}

// Namespace: Unity.IO.LowLevel.Unsafe
[NativeAsStruct]
[RequiredByNativeCode]
[NativeConditional("ENABLE_PROFILER")]
public class AsyncReadManagerMetricsFilters // TypeDefIndex: 6615
{
	// Fields
	[NativeName("typeIDs")]
	internal ulong[] TypeIDs; // 0x10
	[NativeName("states")]
	internal ProcessingState[] States; // 0x18
	[NativeName("readTypes")]
	internal FileReadType[] ReadTypes; // 0x20
	[NativeName("priorityLevels")]
	internal Priority[] PriorityLevels; // 0x28
	[NativeName("subsystems")]
	internal AssetLoadingSubsystem[] Subsystems; // 0x30
}
