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

// Namespace: Internal.Runtime.Augments
internal enum AsyncStatus // TypeDefIndex: 99
{
	// Fields
	public int value__; // 0x0
	public const AsyncStatus Started = 0;
	public const AsyncStatus Completed = 1;
	public const AsyncStatus Canceled = 2;
	public const AsyncStatus Error = 3;
}

// Namespace: Internal.Runtime.Augments
internal abstract class TaskTraceCallbacks // TypeDefIndex: 100
{
	// Properties
	public abstract bool Enabled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_Enabled();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void TaskWaitBegin_Asynchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void TaskWaitBegin_Synchronous(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void TaskWaitEnd(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void TaskScheduled(int OriginatingTaskSchedulerID, int OriginatingTaskID, int TaskID, int CreatingTaskID, int TaskCreationOptions);
}

// Namespace: Internal.Runtime.Augments
internal class RuntimeAugments // TypeDefIndex: 101
{
	// Fields
	private static ReflectionExecutionDomainCallbacks s_reflectionExecutionDomainCallbacks; // 0x0

	// Properties
	internal static ReflectionExecutionDomainCallbacks Callbacks { get; }

	// Methods

	// RVA: 0x17356E4 Offset: 0x17316E4 VA: 0x17356E4
	public static void ReportUnhandledException(Exception exception) { }

	// RVA: 0x1735704 Offset: 0x1731704 VA: 0x1735704
	internal static ReflectionExecutionDomainCallbacks get_Callbacks() { }

	// RVA: 0x173575C Offset: 0x173175C VA: 0x173575C
	private static void .cctor() { }
}

// Namespace: Internal.Runtime.Augments
internal class ReflectionExecutionDomainCallbacks // TypeDefIndex: 102
{
	// Methods

	// RVA: 0x17357E0 Offset: 0x17317E0 VA: 0x17357E0
	internal Exception CreateMissingMetadataException(Type attributeType) { }

	// RVA: 0x17357D8 Offset: 0x17317D8 VA: 0x17357D8
	public void .ctor() { }
}

// Namespace: Internal.Runtime.Augments
internal sealed class RuntimeThread // TypeDefIndex: 103
{
	// Fields
	internal static readonly int OptimalMaxSpinWaitsPerSpinIteration; // 0x0
	private readonly Thread thread; // 0x10

	// Properties
	public bool IsBackground { set; }

	// Methods

	// RVA: 0x1735834 Offset: 0x1731834 VA: 0x1735834
	private void .ctor(Thread t) { }

	// RVA: 0x1735864 Offset: 0x1731864 VA: 0x1735864
	public static RuntimeThread Create(ParameterizedThreadStart start, int maxStackSize) { }

	// RVA: 0x1735908 Offset: 0x1731908 VA: 0x1735908
	public void set_IsBackground(bool value) { }

	// RVA: 0x1735924 Offset: 0x1731924 VA: 0x1735924
	public void Start(object state) { }

	// RVA: 0x173593C Offset: 0x173193C VA: 0x173593C
	public static void Sleep(int millisecondsTimeout) { }

	// RVA: 0x1735944 Offset: 0x1731944 VA: 0x1735944
	public static bool Yield() { }

	// RVA: 0x173594C Offset: 0x173194C VA: 0x173594C
	public static bool SpinWait(int iterations) { }

	// RVA: 0x1735964 Offset: 0x1731964 VA: 0x1735964
	public static int GetCurrentProcessorId() { }

	// RVA: 0x173596C Offset: 0x173196C VA: 0x173596C
	private static void .cctor() { }
}
