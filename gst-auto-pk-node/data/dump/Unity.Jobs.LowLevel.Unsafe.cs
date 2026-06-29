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

// Namespace: Unity.Jobs.LowLevel.Unsafe
[Usage(1024)]
public sealed class JobProducerTypeAttribute : Attribute // TypeDefIndex: 6594
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Type <ProducerType>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1E4A2D4 Offset: 0x1E462D4 VA: 0x1E4A2D4
	public void .ctor(Type producerType) { }
}

// Namespace: Unity.Jobs.LowLevel.Unsafe
public struct JobRanges // TypeDefIndex: 6595
{
	// Fields
	internal int BatchSize; // 0x0
	internal int NumJobs; // 0x4
	public int TotalIterationCount; // 0x8
	internal IntPtr StartEndIndex; // 0x10
}

// Namespace: 
internal sealed class JobsUtility.PanicFunction_ : MulticastDelegate // TypeDefIndex: 6596
{
	// Methods

	// RVA: 0x1E4A4AC Offset: 0x1E464AC VA: 0x1E4A4AC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E4A548 Offset: 0x1E46548 VA: 0x1E4A548 Slot: 12
	public virtual void Invoke() { }
}

// Namespace: Unity.Jobs.LowLevel.Unsafe
[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
[NativeHeader("Runtime/Jobs/JobSystem.h")]
public static class JobsUtility // TypeDefIndex: 6597
{
	// Fields
	internal static JobsUtility.PanicFunction_ PanicFunction; // 0x0

	// Properties
	public static bool IsExecutingJob { get; }
	public static int ThreadIndex { get; }
	public static int ThreadIndexCount { get; }

	// Methods

	[FreeFunction(ThrowsException = True, IsThreadSafe = True)]
	// RVA: 0x1E4A304 Offset: 0x1E46304 VA: 0x1E4A304
	private static IntPtr CreateJobReflectionData(Type wrapperJobType, Type userJobType, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	// RVA: 0x1E4A370 Offset: 0x1E46370 VA: 0x1E4A370
	public static IntPtr CreateJobReflectionData(Type type, object managedJobFunction0, object managedJobFunction1, object managedJobFunction2) { }

	[NativeMethod(IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x1E4A3D0 Offset: 0x1E463D0 VA: 0x1E4A3D0
	public static bool get_IsExecutingJob() { }

	[BurstAuthorizedExternalMethod]
	[FreeFunction("GetJobWorkerIndex", IsThreadSafe = True)]
	// RVA: 0x1E4A3F8 Offset: 0x1E463F8 VA: 0x1E4A3F8
	public static int get_ThreadIndex() { }

	[FreeFunction("GetJobWorkerIndexCount", IsThreadSafe = True)]
	[BurstAuthorizedExternalMethod]
	// RVA: 0x1E4A420 Offset: 0x1E46420 VA: 0x1E4A420
	public static int get_ThreadIndexCount() { }

	[RequiredByNativeCode]
	// RVA: 0x1E4A448 Offset: 0x1E46448 VA: 0x1E4A448
	private static void InvokePanicFunction() { }
}
