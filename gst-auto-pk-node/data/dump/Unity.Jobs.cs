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

// Namespace: Unity.Jobs
[JobProducerType(typeof(IJobExtensions.JobStruct<T>))]
public interface IJob // TypeDefIndex: 6589
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Execute();
}

// Namespace: 
internal sealed class IJobExtensions.JobStruct.ExecuteJobFunction<T> : MulticastDelegate // TypeDefIndex: 6590
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1251C30 Offset: 0x124DC30 VA: 0x1251C30
	|-IJobExtensions.JobStruct.ExecuteJobFunction<NativeArrayDisposeJob>..ctor
	|
	|-RVA: 0x1251CF8 Offset: 0x124DCF8 VA: 0x1251CF8
	|-IJobExtensions.JobStruct.ExecuteJobFunction<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1251CE4 Offset: 0x124DCE4 VA: 0x1251CE4
	|-IJobExtensions.JobStruct.ExecuteJobFunction<NativeArrayDisposeJob>.Invoke
	|
	|-RVA: 0x1251DAC Offset: 0x124DDAC VA: 0x1251DAC
	|-IJobExtensions.JobStruct.ExecuteJobFunction<__Il2CppFullySharedGenericStructType>.Invoke
	*/
}

// Namespace: 
internal struct IJobExtensions.JobStruct<T> // TypeDefIndex: 6591
{
	// Fields
	internal static readonly BurstLike.SharedStatic<IntPtr> jobReflectionData; // 0x0

	// Methods

	[BurstDiscard]
	// RVA: -1 Offset: -1
	internal static void Initialize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D0620 Offset: 0x12CC620 VA: 0x12D0620
	|-IJobExtensions.JobStruct<NativeArrayDisposeJob>.Initialize
	|
	|-RVA: 0x12D0900 Offset: 0x12CC900 VA: 0x12D0900
	|-IJobExtensions.JobStruct<__Il2CppFullySharedGenericStructType>.Initialize
	*/

	// RVA: -1 Offset: -1
	public static void Execute(ref T data, IntPtr additionalPtr, IntPtr bufferRangePatchData, ref JobRanges ranges, int jobIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D0854 Offset: 0x12CC854 VA: 0x12D0854
	|-IJobExtensions.JobStruct<NativeArrayDisposeJob>.Execute
	|
	|-RVA: 0x12D0B60 Offset: 0x12CCB60 VA: 0x12D0B60
	|-IJobExtensions.JobStruct<__Il2CppFullySharedGenericStructType>.Execute
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D088C Offset: 0x12CC88C VA: 0x12D088C
	|-IJobExtensions.JobStruct<NativeArrayDisposeJob>..cctor
	|
	|-RVA: 0x12D0C70 Offset: 0x12CCC70 VA: 0x12D0C70
	|-IJobExtensions.JobStruct<__Il2CppFullySharedGenericStructType>..cctor
	*/
}

// Namespace: Unity.Jobs
[Extension]
public static class IJobExtensions // TypeDefIndex: 6592
{
	// Methods

	// RVA: -1 Offset: -1
	public static void EarlyJobInit<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1119EDC Offset: 0x1115EDC VA: 0x1119EDC
	|-IJobExtensions.EarlyJobInit<NativeArrayDisposeJob>
	|
	|-RVA: 0x1119F28 Offset: 0x1115F28 VA: 0x1119F28
	|-IJobExtensions.EarlyJobInit<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: Unity.Jobs
[NativeType(Header = "Runtime/Jobs/ScriptBindings/JobsBindings.h")]
public struct JobHandle : IEquatable<JobHandle> // TypeDefIndex: 6593
{
	// Fields
	internal ulong jobGroup; // 0x0
	internal int version; // 0x8

	// Methods

	[NativeMethod("ScheduleBatchedScriptingJobs", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x1E4A210 Offset: 0x1E46210 VA: 0x1E4A210
	public static void ScheduleBatchedJobs() { }

	// RVA: 0x1E4A238 Offset: 0x1E46238 VA: 0x1E4A238 Slot: 4
	public bool Equals(JobHandle other) { }

	// RVA: 0x1E4A248 Offset: 0x1E46248 VA: 0x1E4A248 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E4A2C0 Offset: 0x1E462C0 VA: 0x1E4A2C0
	public static bool op_Equality(JobHandle a, JobHandle b) { }

	// RVA: 0x1E4A2CC Offset: 0x1E462CC VA: 0x1E4A2CC Slot: 2
	public override int GetHashCode() { }
}
