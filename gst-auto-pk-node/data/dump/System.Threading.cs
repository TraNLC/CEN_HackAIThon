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

// Namespace: System.Threading
[Serializable]
public class AbandonedMutexException : SystemException // TypeDefIndex: 456
{
	// Fields
	private int _mutexIndex; // 0x8C
	private Mutex _mutex; // 0x90

	// Methods

	// RVA: 0x18FA448 Offset: 0x18F6448 VA: 0x18FA448
	public void .ctor() { }

	// RVA: 0x18FA4AC Offset: 0x18F64AC VA: 0x18FA4AC
	public void .ctor(int location, WaitHandle handle) { }

	// RVA: 0x18FA5B8 Offset: 0x18F65B8 VA: 0x18FA5B8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18FA52C Offset: 0x18F652C VA: 0x18FA52C
	private void SetupException(int location, WaitHandle handle) { }
}

// Namespace: System.Threading
public sealed class AsyncLocal<T> // TypeDefIndex: 457
{}

// Namespace: System.Threading
internal interface IAsyncLocal // TypeDefIndex: 458
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnValueChanged(object previousValue, object currentValue, bool contextChanged);
}

// Namespace: System.Threading
public sealed class AutoResetEvent : EventWaitHandle // TypeDefIndex: 459
{
	// Methods

	// RVA: 0x18FA5C8 Offset: 0x18F65C8 VA: 0x18FA5C8
	public void .ctor(bool initialState) { }
}

// Namespace: System.Threading
public enum EventResetMode // TypeDefIndex: 460
{
	// Fields
	public int value__; // 0x0
	public const EventResetMode AutoReset = 0;
	public const EventResetMode ManualReset = 1;
}

// Namespace: System.Threading
public static class LazyInitializer // TypeDefIndex: 461
{
	// Methods

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111D7F4 Offset: 0x11197F4 VA: 0x111D7F4
	|-LazyInitializer.EnsureInitialized<object>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111DAE0 Offset: 0x1119AE0 VA: 0x111DAE0
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111D848 Offset: 0x1119848 VA: 0x111D848
	|-LazyInitializer.EnsureInitialized<object>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111DBD8 Offset: 0x1119BD8 VA: 0x111DBD8
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111D920 Offset: 0x1119920 VA: 0x111D920
	|-LazyInitializer.EnsureInitialized<bool>
	|
	|-RVA: 0x111D9A4 Offset: 0x11199A4 VA: 0x111D9A4
	|-LazyInitializer.EnsureInitialized<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, ref bool initialized, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111DE04 Offset: 0x1119E04 VA: 0x111DE04
	|-LazyInitializer.EnsureInitializedCore<bool>
	|
	|-RVA: 0x111DF60 Offset: 0x1119F60 VA: 0x111DF60
	|-LazyInitializer.EnsureInitializedCore<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T EnsureInitialized<T>(ref T target, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111D8B0 Offset: 0x11198B0 VA: 0x111D8B0
	|-LazyInitializer.EnsureInitialized<object>
	*/

	// RVA: -1 Offset: -1
	private static T EnsureInitializedCore<T>(ref T target, ref object syncLock, Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111DC74 Offset: 0x1119C74 VA: 0x111DC74
	|-LazyInitializer.EnsureInitializedCore<object>
	*/

	// RVA: 0x18FA5DC Offset: 0x18F65DC VA: 0x18FA5DC
	private static object EnsureLockInitialized(ref object syncLock) { }
}

// Namespace: System.Threading
public enum LazyThreadSafetyMode // TypeDefIndex: 462
{
	// Fields
	public int value__; // 0x0
	public const LazyThreadSafetyMode None = 0;
	public const LazyThreadSafetyMode PublicationOnly = 1;
	public const LazyThreadSafetyMode ExecutionAndPublication = 2;
}

// Namespace: System.Threading
[Serializable]
public class LockRecursionException : Exception // TypeDefIndex: 463
{
	// Methods

	// RVA: 0x18FA654 Offset: 0x18F6654 VA: 0x18FA654
	public void .ctor() { }

	// RVA: 0x18FA6AC Offset: 0x18F66AC VA: 0x18FA6AC
	public void .ctor(string message) { }

	// RVA: 0x18FA714 Offset: 0x18F6714 VA: 0x18FA714
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
public sealed class ManualResetEvent : EventWaitHandle // TypeDefIndex: 464
{
	// Methods

	// RVA: 0x18FA794 Offset: 0x18F6794 VA: 0x18FA794
	public void .ctor(bool initialState) { }
}

// Namespace: System.Threading
public sealed class ParameterizedThreadStart : MulticastDelegate // TypeDefIndex: 465
{
	// Methods

	// RVA: 0x18FA7A0 Offset: 0x18F67A0 VA: 0x18FA7A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18FA8A8 Offset: 0x18F68A8 VA: 0x18FA8A8 Slot: 12
	public virtual void Invoke(object obj) { }
}

// Namespace: System.Threading
[Serializable]
public class SemaphoreFullException : SystemException // TypeDefIndex: 466
{
	// Methods

	// RVA: 0x18FA8BC Offset: 0x18F68BC VA: 0x18FA8BC
	public void .ctor() { }

	// RVA: 0x18FA908 Offset: 0x18F6908 VA: 0x18FA908
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
public sealed class SendOrPostCallback : MulticastDelegate // TypeDefIndex: 467
{
	// Methods

	// RVA: 0x18FA910 Offset: 0x18F6910 VA: 0x18FA910
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18FAA18 Offset: 0x18F6A18 VA: 0x18FAA18 Slot: 12
	public virtual void Invoke(object state) { }
}

// Namespace: System.Threading
[Serializable]
public class SynchronizationLockException : SystemException // TypeDefIndex: 468
{
	// Methods

	// RVA: 0x18FAA2C Offset: 0x18F6A2C VA: 0x18FAA2C
	public void .ctor() { }

	// RVA: 0x18FAA88 Offset: 0x18F6A88 VA: 0x18FAA88
	public void .ctor(string message) { }

	// RVA: 0x18FAAAC Offset: 0x18F6AAC VA: 0x18FAAAC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
public sealed class ThreadStart : MulticastDelegate // TypeDefIndex: 469
{
	// Methods

	// RVA: 0x18FAAB4 Offset: 0x18F6AB4 VA: 0x18FAAB4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x18FAB50 Offset: 0x18F6B50 VA: 0x18FAB50 Slot: 12
	public virtual void Invoke() { }
}

// Namespace: System.Threading
[Flags]
public enum ThreadState // TypeDefIndex: 470
{
	// Fields
	public int value__; // 0x0
	public const ThreadState Running = 0;
	public const ThreadState StopRequested = 1;
	public const ThreadState SuspendRequested = 2;
	public const ThreadState Background = 4;
	public const ThreadState Unstarted = 8;
	public const ThreadState Stopped = 16;
	public const ThreadState WaitSleepJoin = 32;
	public const ThreadState Suspended = 64;
	public const ThreadState AbortRequested = 128;
	public const ThreadState Aborted = 256;
}

// Namespace: System.Threading
[Serializable]
public class ThreadStateException : SystemException // TypeDefIndex: 471
{
	// Methods

	// RVA: 0x18FAB64 Offset: 0x18F6B64 VA: 0x18FAB64
	public void .ctor() { }

	// RVA: 0x18FABC0 Offset: 0x18F6BC0 VA: 0x18FABC0
	public void .ctor(string message) { }

	// RVA: 0x18FABE4 Offset: 0x18F6BE4 VA: 0x18FABE4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
public static class Timeout // TypeDefIndex: 472
{
	// Fields
	public static readonly TimeSpan InfiniteTimeSpan; // 0x0

	// Methods

	// RVA: 0x18FABEC Offset: 0x18F6BEC VA: 0x18FABEC
	private static void .cctor() { }
}

// Namespace: System.Threading
[Serializable]
public class WaitHandleCannotBeOpenedException : ApplicationException // TypeDefIndex: 473
{
	// Methods

	// RVA: 0x18FAC5C Offset: 0x18F6C5C VA: 0x18FAC5C
	public void .ctor() { }

	// RVA: 0x18FACB8 Offset: 0x18F6CB8 VA: 0x18FACB8
	public void .ctor(string message) { }

	// RVA: 0x18FACDC Offset: 0x18F6CDC VA: 0x18FACDC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CancellationToken.<>c // TypeDefIndex: 474
{
	// Fields
	public static readonly CancellationToken.<>c <>9; // 0x0

	// Methods

	// RVA: 0x18FB7CC Offset: 0x18F77CC VA: 0x18FB7CC
	private static void .cctor() { }

	// RVA: 0x18FB834 Offset: 0x18F7834 VA: 0x18FB834
	public void .ctor() { }

	// RVA: 0x18FB83C Offset: 0x18F783C VA: 0x18FB83C
	internal void <.cctor>b__26_0(object obj) { }
}

// Namespace: System.Threading
[IsReadOnly]
[DebuggerDisplay("IsCancellationRequested = {IsCancellationRequested}")]
public struct CancellationToken // TypeDefIndex: 475
{
	// Fields
	private readonly CancellationTokenSource _source; // 0x0
	private static readonly Action<object> s_actionToActionObjShunt; // 0x0

	// Properties
	public static CancellationToken None { get; }
	public bool IsCancellationRequested { get; }
	public bool CanBeCanceled { get; }

	// Methods

	// RVA: 0x18FACE4 Offset: 0x18F6CE4 VA: 0x18FACE4
	public static CancellationToken get_None() { }

	// RVA: 0x18FACEC Offset: 0x18F6CEC VA: 0x18FACEC
	public bool get_IsCancellationRequested() { }

	// RVA: 0x18FAD34 Offset: 0x18F6D34 VA: 0x18FAD34
	public bool get_CanBeCanceled() { }

	// RVA: 0x18FAD44 Offset: 0x18F6D44 VA: 0x18FAD44
	internal void .ctor(CancellationTokenSource source) { }

	// RVA: 0x18FAD4C Offset: 0x18F6D4C VA: 0x18FAD4C
	public void .ctor(bool canceled) { }

	// RVA: 0x18FADE8 Offset: 0x18F6DE8 VA: 0x18FADE8
	public CancellationTokenRegistration Register(Action callback) { }

	// RVA: 0x18FB00C Offset: 0x18F700C VA: 0x18FB00C
	internal CancellationTokenRegistration InternalRegisterWithoutEC(Action<object> callback, object state) { }

	// RVA: 0x18FAEE0 Offset: 0x18F6EE0 VA: 0x18FAEE0
	public CancellationTokenRegistration Register(Action<object> callback, object state, bool useSynchronizationContext, bool useExecutionContext) { }

	// RVA: 0x18FB430 Offset: 0x18F7430 VA: 0x18FB430
	public bool Equals(CancellationToken other) { }

	// RVA: 0x18FB440 Offset: 0x18F7440 VA: 0x18FB440 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x18FB4E8 Offset: 0x18F74E8 VA: 0x18FB4E8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18FB55C Offset: 0x18F755C VA: 0x18FB55C
	public static bool op_Equality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x18FB5C0 Offset: 0x18F75C0 VA: 0x18FB5C0
	public static bool op_Inequality(CancellationToken left, CancellationToken right) { }

	// RVA: 0x18FB624 Offset: 0x18F7624 VA: 0x18FB624
	public void ThrowIfCancellationRequested() { }

	// RVA: 0x18FB6A4 Offset: 0x18F76A4 VA: 0x18FB6A4
	private void ThrowOperationCanceledException() { }

	// RVA: 0x18FB6FC Offset: 0x18F76FC VA: 0x18FB6FC
	private static void .cctor() { }
}

// Namespace: System.Threading
[DebuggerDisplay("Set = {IsSet}")]
public class ManualResetEventSlim : IDisposable // TypeDefIndex: 476
{
	// Fields
	private object m_lock; // 0x10
	private ManualResetEvent m_eventObj; // 0x18
	private int m_combinedState; // 0x20
	private static Action<object> s_cancellationTokenCallback; // 0x0

	// Properties
	public WaitHandle WaitHandle { get; }
	public bool IsSet { get; set; }
	public int SpinCount { get; set; }
	private int Waiters { get; set; }

	// Methods

	// RVA: 0x18FB8A8 Offset: 0x18F78A8 VA: 0x18FB8A8
	public WaitHandle get_WaitHandle() { }

	// RVA: 0x18FBAD4 Offset: 0x18F7AD4 VA: 0x18FBAD4
	public bool get_IsSet() { }

	// RVA: 0x18FBB38 Offset: 0x18F7B38 VA: 0x18FBB38
	private void set_IsSet(bool value) { }

	// RVA: 0x18FBC28 Offset: 0x18F7C28 VA: 0x18FBC28
	public int get_SpinCount() { }

	// RVA: 0x18FBC90 Offset: 0x18F7C90 VA: 0x18FBC90
	private void set_SpinCount(int value) { }

	// RVA: 0x18FBCC4 Offset: 0x18F7CC4 VA: 0x18FBCC4
	private int get_Waiters() { }

	// RVA: 0x18FBD20 Offset: 0x18F7D20 VA: 0x18FBD20
	private void set_Waiters(int value) { }

	// RVA: 0x18FBDAC Offset: 0x18F7DAC VA: 0x18FBDAC
	public void .ctor(bool initialState) { }

	// RVA: 0x18FBED8 Offset: 0x18F7ED8 VA: 0x18FBED8
	public void .ctor(bool initialState, int spinCount) { }

	// RVA: 0x18FBE28 Offset: 0x18F7E28 VA: 0x18FBE28
	private void Initialize(bool initialState, int spinCount) { }

	// RVA: 0x18FBFF0 Offset: 0x18F7FF0 VA: 0x18FBFF0
	private void EnsureLockObjectCreated() { }

	// RVA: 0x18FB944 Offset: 0x18F7944 VA: 0x18FB944
	private bool LazyInitializeEvent() { }

	// RVA: 0x18FC0E8 Offset: 0x18F80E8 VA: 0x18FC0E8
	public void Set() { }

	// RVA: 0x18FC0F0 Offset: 0x18F80F0 VA: 0x18FC0F0
	private void Set(bool duringCancellation) { }

	// RVA: 0x18FC300 Offset: 0x18F8300 VA: 0x18FC300
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x18FC950 Offset: 0x18F8950 VA: 0x18FC950 Slot: 4
	public void Dispose() { }

	// RVA: 0x18FC9BC Offset: 0x18F89BC VA: 0x18FC9BC Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18FB8E4 Offset: 0x18F78E4 VA: 0x18FB8E4
	private void ThrowIfDisposed() { }

	// RVA: 0x18FCAC8 Offset: 0x18F8AC8 VA: 0x18FCAC8
	private static void CancellationTokenCallback(object obj) { }

	// RVA: 0x18FBB58 Offset: 0x18F7B58 VA: 0x18FBB58
	private void UpdateStateAtomically(int newBits, int updateBitsMask) { }

	// RVA: 0x18FBC84 Offset: 0x18F7C84 VA: 0x18FBC84
	private static int ExtractStatePortionAndShiftRight(int state, int mask, int rightBitShiftCount) { }

	// RVA: 0x18FBB30 Offset: 0x18F7B30 VA: 0x18FBB30
	private static int ExtractStatePortion(int state, int mask) { }

	// RVA: 0x18FCC4C Offset: 0x18F8C4C VA: 0x18FCC4C
	private static void .cctor() { }
}

// Namespace: System.Threading
public struct NativeOverlapped // TypeDefIndex: 477
{
	// Fields
	public IntPtr InternalLow; // 0x0
	public IntPtr InternalHigh; // 0x8
	public int OffsetLow; // 0x10
	public int OffsetHigh; // 0x14
	public IntPtr EventHandle; // 0x18
}

// Namespace: System.Threading
public struct SpinWait // TypeDefIndex: 478
{
	// Fields
	internal static readonly int SpinCountforSpinBeforeWait; // 0x0
	private int _count; // 0x0

	// Properties
	public int Count { get; }
	public bool NextSpinWillYield { get; }

	// Methods

	// RVA: 0x18FCCEC Offset: 0x18F8CEC VA: 0x18FCCEC
	public int get_Count() { }

	// RVA: 0x18FCCF4 Offset: 0x18F8CF4 VA: 0x18FCCF4
	public bool get_NextSpinWillYield() { }

	// RVA: 0x18FCBF4 Offset: 0x18F8BF4 VA: 0x18FCBF4
	public void SpinOnce() { }

	// RVA: 0x18FC818 Offset: 0x18F8818 VA: 0x18FC818
	public void SpinOnce(int sleep1Threshold) { }

	// RVA: 0x18FCD6C Offset: 0x18F8D6C VA: 0x18FCD6C
	private void SpinOnceCore(int sleep1Threshold) { }

	// RVA: 0x18FCF18 Offset: 0x18F8F18 VA: 0x18FCF18
	private static void .cctor() { }
}

// Namespace: System.Threading
internal static class PlatformHelper // TypeDefIndex: 479
{
	// Fields
	private static int s_processorCount; // 0x0
	private static int s_lastProcessorCountRefreshTicks; // 0x4
	internal static readonly bool IsSingleProcessor; // 0x8

	// Properties
	internal static int ProcessorCount { get; }

	// Methods

	// RVA: 0x18FCF9C Offset: 0x18F8F9C VA: 0x18FCF9C
	internal static int get_ProcessorCount() { }

	// RVA: 0x18FD088 Offset: 0x18F9088 VA: 0x18FD088
	private static void .cctor() { }
}

// Namespace: System.Threading
internal static class TimeoutHelper // TypeDefIndex: 480
{
	// Methods

	// RVA: 0x18FC810 Offset: 0x18F8810 VA: 0x18FC810
	public static uint GetTime() { }

	// RVA: 0x18FC910 Offset: 0x18F8910 VA: 0x18FC910
	public static int UpdateTimeOut(uint startTime, int originalWaitMillisecondsTimeout) { }
}

// Namespace: System.Threading
[IsReadOnly]
public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable // TypeDefIndex: 481
{
	// Fields
	private readonly CancellationCallbackInfo m_callbackInfo; // 0x0
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo; // 0x8

	// Methods

	// RVA: 0x18FD0DC Offset: 0x18F90DC VA: 0x18FD0DC
	internal void .ctor(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	// RVA: 0x18FD114 Offset: 0x18F9114 VA: 0x18FD114
	public bool Unregister() { }

	// RVA: 0x18FD190 Offset: 0x18F9190 VA: 0x18FD190 Slot: 5
	public void Dispose() { }

	// RVA: 0x18FD2E0 Offset: 0x18F92E0 VA: 0x18FD2E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x18FD370 Offset: 0x18F9370 VA: 0x18FD370 Slot: 4
	public bool Equals(CancellationTokenRegistration other) { }

	// RVA: 0x18FD3F0 Offset: 0x18F93F0 VA: 0x18FD3F0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
private sealed class CancellationTokenSource.Linked1CancellationTokenSource : CancellationTokenSource // TypeDefIndex: 482
{
	// Fields
	private readonly CancellationTokenRegistration _reg1; // 0x40

	// Methods

	// RVA: 0x18FE3F8 Offset: 0x18FA3F8 VA: 0x18FE3F8
	internal void .ctor(CancellationToken token1) { }

	// RVA: 0x18FE898 Offset: 0x18FA898 VA: 0x18FE898 Slot: 5
	protected override void Dispose(bool disposing) { }
}

// Namespace: 
private sealed class CancellationTokenSource.Linked2CancellationTokenSource : CancellationTokenSource // TypeDefIndex: 483
{
	// Fields
	private readonly CancellationTokenRegistration _reg1; // 0x40
	private readonly CancellationTokenRegistration _reg2; // 0x58

	// Methods

	// RVA: 0x18FE4FC Offset: 0x18FA4FC VA: 0x18FE4FC
	internal void .ctor(CancellationToken token1, CancellationToken token2) { }

	// RVA: 0x18FE8CC Offset: 0x18FA8CC VA: 0x18FE8CC Slot: 5
	protected override void Dispose(bool disposing) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CancellationTokenSource.LinkedNCancellationTokenSource.<>c // TypeDefIndex: 484
{
	// Fields
	public static readonly CancellationTokenSource.LinkedNCancellationTokenSource.<>c <>9; // 0x0

	// Methods

	// RVA: 0x18FE9D8 Offset: 0x18FA9D8 VA: 0x18FE9D8
	private static void .cctor() { }

	// RVA: 0x18FEA40 Offset: 0x18FAA40 VA: 0x18FEA40
	public void .ctor() { }

	// RVA: 0x18FEA48 Offset: 0x18FAA48 VA: 0x18FEA48
	internal void <.cctor>b__4_0(object s) { }
}

// Namespace: 
private sealed class CancellationTokenSource.LinkedNCancellationTokenSource : CancellationTokenSource // TypeDefIndex: 485
{
	// Fields
	internal static readonly Action<object> s_linkedTokenCancelDelegate; // 0x0

	// Methods

	// RVA: 0x18FE908 Offset: 0x18FA908 VA: 0x18FE908
	private static void .cctor() { }
}

// Namespace: System.Threading
public class CancellationTokenSource : IDisposable // TypeDefIndex: 486
{
	// Fields
	internal static readonly CancellationTokenSource s_canceledSource; // 0x0
	internal static readonly CancellationTokenSource s_neverCanceledSource; // 0x8
	private static readonly int s_nLists; // 0x10
	private ManualResetEvent _kernelEvent; // 0x10
	private SparselyPopulatedArray<CancellationCallbackInfo>[] _registeredCallbacksLists; // 0x18
	private int _state; // 0x20
	private int _threadIDExecutingCallbacks; // 0x24
	private bool _disposed; // 0x28
	private CancellationCallbackInfo _executingCallback; // 0x30
	private Timer _timer; // 0x38
	private static readonly TimerCallback s_timerCallback; // 0x18

	// Properties
	public bool IsCancellationRequested { get; }
	internal bool IsCancellationCompleted { get; }
	internal bool IsDisposed { get; }
	internal int ThreadIDExecutingCallbacks { get; set; }
	public CancellationToken Token { get; }
	internal CancellationCallbackInfo ExecutingCallback { get; }

	// Methods

	// RVA: 0x18FAD18 Offset: 0x18F6D18 VA: 0x18FAD18
	public bool get_IsCancellationRequested() { }

	// RVA: 0x18FD224 Offset: 0x18F9224 VA: 0x18FD224
	internal bool get_IsCancellationCompleted() { }

	// RVA: 0x18FD480 Offset: 0x18F9480 VA: 0x18FD480
	internal bool get_IsDisposed() { }

	// RVA: 0x18FD240 Offset: 0x18F9240 VA: 0x18FD240
	internal int get_ThreadIDExecutingCallbacks() { }

	// RVA: 0x18FD488 Offset: 0x18F9488 VA: 0x18FD488
	internal void set_ThreadIDExecutingCallbacks(int value) { }

	// RVA: 0x18FD4AC Offset: 0x18F94AC VA: 0x18FD4AC
	public CancellationToken get_Token() { }

	// RVA: 0x18FD538 Offset: 0x18F9538 VA: 0x18FD538
	internal CancellationCallbackInfo get_ExecutingCallback() { }

	// RVA: 0x18FD550 Offset: 0x18F9550 VA: 0x18FD550
	public void .ctor() { }

	// RVA: 0x18FD584 Offset: 0x18F9584 VA: 0x18FD584
	public void Cancel() { }

	// RVA: 0x18FD5A0 Offset: 0x18F95A0 VA: 0x18FD5A0
	public void Cancel(bool throwOnFirstException) { }

	// RVA: 0x18FD678 Offset: 0x18F9678 VA: 0x18FD678
	public void CancelAfter(int millisecondsDelay) { }

	// RVA: 0x18FD860 Offset: 0x18F9860 VA: 0x18FD860
	private static void TimerCallbackLogic(object obj) { }

	// RVA: 0x18FD978 Offset: 0x18F9978 VA: 0x18FD978 Slot: 4
	public void Dispose() { }

	// RVA: 0x18FD9E4 Offset: 0x18F99E4 VA: 0x18FD9E4 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x18FD4DC Offset: 0x18F94DC VA: 0x18FD4DC
	internal void ThrowIfDisposed() { }

	// RVA: 0x18FDA80 Offset: 0x18F9A80 VA: 0x18FDA80
	private static void ThrowObjectDisposedException() { }

	// RVA: 0x18FB134 Offset: 0x18F7134 VA: 0x18FB134
	internal CancellationTokenRegistration InternalRegister(Action<object> callback, object stateForCallback, SynchronizationContext targetSyncContext, ExecutionContext executionContext) { }

	// RVA: 0x18FD5C8 Offset: 0x18F95C8 VA: 0x18FD5C8
	private void NotifyCancellation(bool throwOnFirstException) { }

	// RVA: 0x18FDB70 Offset: 0x18F9B70 VA: 0x18FDB70
	private void ExecuteCallbackHandlers(bool throwOnFirstException) { }

	// RVA: 0x18FE168 Offset: 0x18FA168 VA: 0x18FE168
	private void CancellationCallbackCoreWork_OnSyncContext(object obj) { }

	// RVA: 0x18FE0AC Offset: 0x18FA0AC VA: 0x18FE0AC
	private void CancellationCallbackCoreWork(CancellationCallbackCoreWorkArguments args) { }

	// RVA: 0x18FE2E8 Offset: 0x18FA2E8 VA: 0x18FE2E8
	public static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token1, CancellationToken token2) { }

	// RVA: 0x18FE63C Offset: 0x18FA63C VA: 0x18FE63C
	internal static CancellationTokenSource CreateLinkedTokenSource(CancellationToken token) { }

	// RVA: 0x18FD258 Offset: 0x18F9258 VA: 0x18FD258
	internal void WaitForCallbackToComplete(CancellationCallbackInfo callbackInfo) { }

	// RVA: 0x18FE708 Offset: 0x18FA708 VA: 0x18FE708
	private static void .cctor() { }
}

// Namespace: System.Threading
internal struct CancellationCallbackCoreWorkArguments // TypeDefIndex: 487
{
	// Fields
	internal SparselyPopulatedArrayFragment<CancellationCallbackInfo> _currArrayFragment; // 0x0
	internal int _currArrayIndex; // 0x8

	// Methods

	// RVA: 0x18FE084 Offset: 0x18FA084 VA: 0x18FE084
	public void .ctor(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex) { }
}

// Namespace: 
internal sealed class CancellationCallbackInfo.WithSyncContext : CancellationCallbackInfo // TypeDefIndex: 488
{
	// Fields
	internal readonly SynchronizationContext TargetSyncContext; // 0x30

	// Methods

	// RVA: 0x18FDB44 Offset: 0x18F9B44 VA: 0x18FDB44
	internal void .ctor(Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource, SynchronizationContext targetSyncContext) { }
}

// Namespace: System.Threading
internal class CancellationCallbackInfo // TypeDefIndex: 489
{
	// Fields
	internal readonly Action<object> Callback; // 0x10
	internal readonly object StateForCallback; // 0x18
	internal readonly ExecutionContext TargetExecutionContext; // 0x20
	internal readonly CancellationTokenSource CancellationTokenSource; // 0x28
	private static ContextCallback s_executionContextCallback; // 0x0

	// Methods

	// RVA: 0x18FDAD0 Offset: 0x18F9AD0 VA: 0x18FDAD0
	internal void .ctor(Action<object> callback, object stateForCallback, ExecutionContext targetExecutionContext, CancellationTokenSource cancellationTokenSource) { }

	// RVA: 0x18FE1E4 Offset: 0x18FA1E4 VA: 0x18FE1E4
	internal void ExecuteCallback() { }

	// RVA: 0x18FECB4 Offset: 0x18FACB4 VA: 0x18FECB4
	private static void ExecutionContextCallback(object obj) { }
}

// Namespace: System.Threading
internal class SparselyPopulatedArray<T> // TypeDefIndex: 490
{
	// Fields
	private readonly SparselyPopulatedArrayFragment<T> _head; // 0x0
	private SparselyPopulatedArrayFragment<T> _tail; // 0x0

	// Properties
	internal SparselyPopulatedArrayFragment<T> Tail { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int initialSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146397C Offset: 0x145F97C VA: 0x146397C
	|-SparselyPopulatedArray<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Tail() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1463A0C Offset: 0x145FA0C VA: 0x1463A0C
	|-SparselyPopulatedArray<object>.get_Tail
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayAddInfo<T> Add(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1463A24 Offset: 0x145FA24 VA: 0x1463A24
	|-SparselyPopulatedArray<object>.Add
	*/
}

// Namespace: System.Threading
internal struct SparselyPopulatedArrayAddInfo<T> // TypeDefIndex: 491
{
	// Fields
	private SparselyPopulatedArrayFragment<T> _source; // 0x0
	private int _index; // 0x0

	// Properties
	internal SparselyPopulatedArrayFragment<T> Source { get; }
	internal int Index { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(SparselyPopulatedArrayFragment<T> source, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14637E4 Offset: 0x145F7E4 VA: 0x14637E4
	|-SparselyPopulatedArrayAddInfo<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Source() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146380C Offset: 0x145F80C VA: 0x146380C
	|-SparselyPopulatedArrayAddInfo<object>.get_Source
	*/

	// RVA: -1 Offset: -1
	internal int get_Index() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1463814 Offset: 0x145F814 VA: 0x1463814
	|-SparselyPopulatedArrayAddInfo<object>.get_Index
	*/
}

// Namespace: System.Threading
[DefaultMember("Item")]
internal class SparselyPopulatedArrayFragment<T> // TypeDefIndex: 492
{
	// Fields
	internal readonly T[] _elements; // 0x0
	internal int _freeCount; // 0x0
	internal SparselyPopulatedArrayFragment<T> _next; // 0x0
	internal SparselyPopulatedArrayFragment<T> _prev; // 0x0

	// Properties
	internal T Item { get; }
	internal int Length { get; }
	internal SparselyPopulatedArrayFragment<T> Prev { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146381C Offset: 0x145F81C VA: 0x146381C
	|-SparselyPopulatedArrayFragment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int size, SparselyPopulatedArrayFragment<T> prev) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1463830 Offset: 0x145F830 VA: 0x1463830
	|-SparselyPopulatedArrayFragment<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14638B0 Offset: 0x145F8B0 VA: 0x14638B0
	|-SparselyPopulatedArrayFragment<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	internal int get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14638E8 Offset: 0x145F8E8 VA: 0x14638E8
	|-SparselyPopulatedArrayFragment<object>.get_Length
	*/

	// RVA: -1 Offset: -1
	internal SparselyPopulatedArrayFragment<T> get_Prev() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1463900 Offset: 0x145F900 VA: 0x1463900
	|-SparselyPopulatedArrayFragment<object>.get_Prev
	*/

	// RVA: -1 Offset: -1
	internal T SafeAtomicRemove(int index, T expectedElement) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1463918 Offset: 0x145F918 VA: 0x1463918
	|-SparselyPopulatedArrayFragment<object>.SafeAtomicRemove
	*/
}

// Namespace: System.Threading
[ReflectionBlocked]
public struct LockHolder : IDisposable // TypeDefIndex: 493
{
	// Fields
	private Lock _lock; // 0x0

	// Methods

	// RVA: 0x18FED40 Offset: 0x18FAD40 VA: 0x18FED40
	public static LockHolder Hold(Lock l) { }

	// RVA: 0x18FED88 Offset: 0x18FAD88 VA: 0x18FED88 Slot: 4
	public void Dispose() { }
}

// Namespace: System.Threading
public class Lock // TypeDefIndex: 494
{
	// Fields
	private object _lock; // 0x10

	// Methods

	// RVA: 0x18FED80 Offset: 0x18FAD80 VA: 0x18FED80
	public void Acquire() { }

	// RVA: 0x18FEDA0 Offset: 0x18FADA0 VA: 0x18FEDA0
	public void Release() { }

	// RVA: 0x18FEDB0 Offset: 0x18FADB0 VA: 0x18FEDB0
	public void .ctor() { }
}

// Namespace: 
private sealed class SemaphoreSlim.TaskNode : Task<bool>, IThreadPoolWorkItem // TypeDefIndex: 495
{
	// Fields
	internal SemaphoreSlim.TaskNode Prev; // 0x58
	internal SemaphoreSlim.TaskNode Next; // 0x60

	// Methods

	// RVA: 0x18FFBE0 Offset: 0x18FBBE0 VA: 0x18FFBE0
	internal void .ctor() { }

	// RVA: 0x19003C8 Offset: 0x18FC3C8 VA: 0x19003C8 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1900414 Offset: 0x18FC414 VA: 0x1900414 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }
}

// Namespace: 
[CompilerGenerated]
private struct SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32 : IAsyncStateMachine // TypeDefIndex: 496
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public SemaphoreSlim.TaskNode asyncWaiter; // 0x28
	public int millisecondsTimeout; // 0x30
	public SemaphoreSlim <>4__this; // 0x38
	private CancellationTokenSource <cts>5__2; // 0x40
	private object <>7__wrap2; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2; // 0x60

	// Methods

	// RVA: 0x1900418 Offset: 0x18FC418 VA: 0x1900418 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1900CD4 Offset: 0x18FCCD4 VA: 0x1900CD4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Threading
[ComVisible(False)]
[DebuggerDisplay("Current Count = {m_currentCount}")]
public class SemaphoreSlim : IDisposable // TypeDefIndex: 497
{
	// Fields
	private int m_currentCount; // 0x10
	private readonly int m_maxCount; // 0x14
	private int m_waitCount; // 0x18
	private object m_lockObj; // 0x20
	private ManualResetEvent m_waitHandle; // 0x28
	private SemaphoreSlim.TaskNode m_asyncHead; // 0x30
	private SemaphoreSlim.TaskNode m_asyncTail; // 0x38
	private static readonly Task<bool> s_trueTask; // 0x0
	private static readonly Task<bool> s_falseTask; // 0x8
	private static Action<object> s_cancellationTokenCanceledEventHandler; // 0x10

	// Methods

	// RVA: 0x18FEE1C Offset: 0x18FAE1C VA: 0x18FEE1C
	public void .ctor(int initialCount, int maxCount) { }

	// RVA: 0x18FEFB4 Offset: 0x18FAFB4 VA: 0x18FEFB4
	public void Wait() { }

	// RVA: 0x18FEFC0 Offset: 0x18FAFC0 VA: 0x18FEFC0
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x18FF8AC Offset: 0x18FB8AC VA: 0x18FF8AC
	private bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken) { }

	// RVA: 0x18FF9D0 Offset: 0x18FB9D0 VA: 0x18FF9D0
	public Task WaitAsync() { }

	// RVA: 0x18FF578 Offset: 0x18FB578 VA: 0x18FF578
	public Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x18FF9DC Offset: 0x18FB9DC VA: 0x18FF9DC
	private SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter() { }

	// RVA: 0x18FFC28 Offset: 0x18FBC28 VA: 0x18FFC28
	private bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task) { }

	[AsyncStateMachine(typeof(SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32))]
	// RVA: 0x18FFA8C Offset: 0x18FBA8C VA: 0x18FFA8C
	private Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x18FFD10 Offset: 0x18FBD10 VA: 0x18FFD10
	public int Release() { }

	// RVA: 0x18FFD18 Offset: 0x18FBD18 VA: 0x18FFD18
	public int Release(int releaseCount) { }

	// RVA: 0x190005C Offset: 0x18FC05C VA: 0x190005C
	private static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask) { }

	// RVA: 0x1900068 Offset: 0x18FC068 VA: 0x1900068 Slot: 4
	public void Dispose() { }

	// RVA: 0x19000D4 Offset: 0x18FC0D4 VA: 0x19000D4 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x190016C Offset: 0x18FC16C VA: 0x190016C
	private static void CancellationTokenCanceledEventHandler(object obj) { }

	// RVA: 0x18FF504 Offset: 0x18FB504 VA: 0x18FF504
	private void CheckDispose() { }

	// RVA: 0x18FEFAC Offset: 0x18FAFAC VA: 0x18FEFAC
	private static string GetResourceString(string str) { }

	// RVA: 0x1900288 Offset: 0x18FC288 VA: 0x1900288
	private static void .cctor() { }
}

// Namespace: 
internal class SpinLock.SystemThreading_SpinLockDebugView // TypeDefIndex: 498
{}

// Namespace: System.Threading
[DebuggerTypeProxy(typeof(SpinLock.SystemThreading_SpinLockDebugView))]
[ComVisible(False)]
[DebuggerDisplay("IsHeld = {IsHeld}")]
public struct SpinLock // TypeDefIndex: 499
{
	// Fields
	private int m_owner; // 0x0
	private static int MAXIMUM_WAITERS; // 0x0

	// Properties
	public bool IsHeldByCurrentThread { get; }
	public bool IsThreadOwnerTrackingEnabled { get; }

	// Methods

	// RVA: 0x1900D50 Offset: 0x18FCD50 VA: 0x1900D50
	public void .ctor(bool enableThreadOwnerTracking) { }

	// RVA: 0x1900D88 Offset: 0x18FCD88 VA: 0x1900D88
	public void Enter(ref bool lockTaken) { }

	// RVA: 0x1901358 Offset: 0x18FD358 VA: 0x1901358
	public void TryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1900E8C Offset: 0x18FCE8C VA: 0x1900E8C
	private void ContinueTryEnter(int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x1901600 Offset: 0x18FD600 VA: 0x1901600
	private void DecrementWaiters() { }

	// RVA: 0x1901494 Offset: 0x18FD494 VA: 0x1901494
	private void ContinueTryEnterWithThreadTracking(int millisecondsTimeout, uint startTime, ref bool lockTaken) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x19017D0 Offset: 0x18FD7D0 VA: 0x19017D0
	public void Exit() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x190195C Offset: 0x18FD95C VA: 0x190195C
	public void Exit(bool useMemoryBarrier) { }

	// RVA: 0x190184C Offset: 0x18FD84C VA: 0x190184C
	private void ExitSlowPath(bool useMemoryBarrier) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x19019E4 Offset: 0x18FD9E4 VA: 0x19019E4
	public bool get_IsHeldByCurrentThread() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1901478 Offset: 0x18FD478 VA: 0x1901478
	public bool get_IsThreadOwnerTrackingEnabled() { }

	// RVA: 0x1901AB4 Offset: 0x18FDAB4 VA: 0x1901AB4
	private static void .cctor() { }
}

// Namespace: 
private struct ThreadLocal.LinkedSlotVolatile<T> // TypeDefIndex: 500
{
	// Fields
	internal ThreadLocal.LinkedSlot<T> Value; // 0x0
}

// Namespace: 
private sealed class ThreadLocal.LinkedSlot<T> // TypeDefIndex: 501
{
	// Fields
	internal ThreadLocal.LinkedSlot<T> Next; // 0x0
	internal ThreadLocal.LinkedSlot<T> Previous; // 0x0
	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; // 0x0
	internal T Value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F22E8 Offset: 0x12EE2E8 VA: 0x12F22E8
	|-ThreadLocal.LinkedSlot<object>..ctor
	|
	|-RVA: 0x12F231C Offset: 0x12EE31C VA: 0x12F231C
	|-ThreadLocal.LinkedSlot<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class ThreadLocal.IdManager<T> // TypeDefIndex: 502
{
	// Fields
	private int m_nextIdToTry; // 0x0
	private List<bool> m_freeIds; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal int GetId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127BBAC Offset: 0x1277BAC VA: 0x127BBAC
	|-ThreadLocal.IdManager<object>.GetId
	|
	|-RVA: 0x127BF34 Offset: 0x1277F34 VA: 0x127BF34
	|-ThreadLocal.IdManager<__Il2CppFullySharedGenericType>.GetId
	*/

	// RVA: -1 Offset: -1
	internal void ReturnId(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127BD90 Offset: 0x1277D90 VA: 0x127BD90
	|-ThreadLocal.IdManager<object>.ReturnId
	|
	|-RVA: 0x127C118 Offset: 0x1278118 VA: 0x127C118
	|-ThreadLocal.IdManager<__Il2CppFullySharedGenericType>.ReturnId
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127BEAC Offset: 0x1277EAC VA: 0x127BEAC
	|-ThreadLocal.IdManager<object>..ctor
	|
	|-RVA: 0x127C234 Offset: 0x1278234 VA: 0x127C234
	|-ThreadLocal.IdManager<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class ThreadLocal.FinalizationHelper<T> // TypeDefIndex: 503
{
	// Fields
	internal ThreadLocal.LinkedSlotVolatile<T>[] SlotArray; // 0x0
	private bool m_trackAllValues; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ThreadLocal.LinkedSlotVolatile<T>[] slotArray, bool trackAllValues) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12601DC Offset: 0x125C1DC VA: 0x12601DC
	|-ThreadLocal.FinalizationHelper<object>..ctor
	|
	|-RVA: 0x12604AC Offset: 0x125C4AC VA: 0x12604AC
	|-ThreadLocal.FinalizationHelper<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260218 Offset: 0x125C218 VA: 0x1260218
	|-ThreadLocal.FinalizationHelper<object>.Finalize
	|
	|-RVA: 0x12604E8 Offset: 0x125C4E8 VA: 0x12604E8
	|-ThreadLocal.FinalizationHelper<__Il2CppFullySharedGenericType>.Finalize
	*/
}

// Namespace: System.Threading
[DebuggerTypeProxy(typeof(SystemThreading_ThreadLocalDebugView<T>))]
[DebuggerDisplay("IsValueCreated={IsValueCreated}, Value={ValueForDebugDisplay}, Count={ValuesCountForDebugDisplay}")]
public class ThreadLocal<T> : IDisposable // TypeDefIndex: 504
{
	// Fields
	private Func<T> m_valueFactory; // 0x0
	[ThreadStatic]
	private static ThreadLocal.LinkedSlotVolatile<T>[] ts_slotArray; // 0xFFFFFFFF
	[ThreadStatic]
	private static ThreadLocal.FinalizationHelper<T> ts_finalizationHelper; // 0xFFFFFFFF
	private int m_idComplement; // 0x0
	private bool m_initialized; // 0x0
	private static ThreadLocal.IdManager<T> s_idManager; // 0x0
	private ThreadLocal.LinkedSlot<T> m_linkedSlot; // 0x0
	private bool m_trackAllValues; // 0x0

	// Properties
	[DebuggerBrowsable(0)]
	public T Value { get; set; }
	public bool IsValueCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147FC38 Offset: 0x147BC38 VA: 0x147FC38
	|-ThreadLocal<object>..ctor
	|
	|-RVA: 0x1480F20 Offset: 0x147CF20 VA: 0x1480F20
	|-ThreadLocal<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void Initialize(Func<T> valueFactory, bool trackAllValues) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147FD18 Offset: 0x147BD18 VA: 0x147FD18
	|-ThreadLocal<object>.Initialize
	|
	|-RVA: 0x1481008 Offset: 0x147D008 VA: 0x1481008
	|-ThreadLocal<__Il2CppFullySharedGenericType>.Initialize
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147FDCC Offset: 0x147BDCC VA: 0x147FDCC
	|-ThreadLocal<object>.Finalize
	|
	|-RVA: 0x14810C0 Offset: 0x147D0C0 VA: 0x14810C0
	|-ThreadLocal<__Il2CppFullySharedGenericType>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147FE64 Offset: 0x147BE64 VA: 0x147FE64
	|-ThreadLocal<object>.Dispose
	|
	|-RVA: 0x1481158 Offset: 0x147D158 VA: 0x1481158
	|-ThreadLocal<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147FED0 Offset: 0x147BED0 VA: 0x147FED0
	|-ThreadLocal<object>.Dispose
	|
	|-RVA: 0x14811C4 Offset: 0x147D1C4 VA: 0x14811C4
	|-ThreadLocal<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1480160 Offset: 0x147C160 VA: 0x1480160
	|-ThreadLocal<object>.ToString
	|
	|-RVA: 0x14814D4 Offset: 0x147D4D4 VA: 0x14814D4
	|-ThreadLocal<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148018C Offset: 0x147C18C VA: 0x148018C
	|-ThreadLocal<object>.get_Value
	|
	|-RVA: 0x1481624 Offset: 0x147D624 VA: 0x1481624
	|-ThreadLocal<__Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148026C Offset: 0x147C26C VA: 0x148026C
	|-ThreadLocal<object>.set_Value
	|
	|-RVA: 0x14817E0 Offset: 0x147D7E0 VA: 0x14817E0
	|-ThreadLocal<__Il2CppFullySharedGenericType>.set_Value
	*/

	// RVA: -1 Offset: -1
	private T GetValueSlow() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148036C Offset: 0x147C36C VA: 0x148036C
	|-ThreadLocal<object>.GetValueSlow
	|
	|-RVA: 0x14819B0 Offset: 0x147D9B0 VA: 0x14819B0
	|-ThreadLocal<__Il2CppFullySharedGenericType>.GetValueSlow
	*/

	// RVA: -1 Offset: -1
	private void SetValueSlow(T value, ThreadLocal.LinkedSlotVolatile<T>[] slotArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14804A4 Offset: 0x147C4A4 VA: 0x14804A4
	|-ThreadLocal<object>.SetValueSlow
	|
	|-RVA: 0x1481C00 Offset: 0x147DC00 VA: 0x1481C00
	|-ThreadLocal<__Il2CppFullySharedGenericType>.SetValueSlow
	*/

	// RVA: -1 Offset: -1
	private void CreateLinkedSlot(ThreadLocal.LinkedSlotVolatile<T>[] slotArray, int id, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148080C Offset: 0x147C80C VA: 0x148080C
	|-ThreadLocal<object>.CreateLinkedSlot
	|
	|-RVA: 0x14820B4 Offset: 0x147E0B4 VA: 0x14820B4
	|-ThreadLocal<__Il2CppFullySharedGenericType>.CreateLinkedSlot
	*/

	// RVA: -1 Offset: -1
	public bool get_IsValueCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1480AA4 Offset: 0x147CAA4 VA: 0x1480AA4
	|-ThreadLocal<object>.get_IsValueCreated
	|
	|-RVA: 0x14824AC Offset: 0x147E4AC VA: 0x14824AC
	|-ThreadLocal<__Il2CppFullySharedGenericType>.get_IsValueCreated
	*/

	// RVA: -1 Offset: -1
	private void GrowTable(ref ThreadLocal.LinkedSlotVolatile<T>[] table, int minLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1480B8C Offset: 0x147CB8C VA: 0x1480B8C
	|-ThreadLocal<object>.GrowTable
	|
	|-RVA: 0x1482594 Offset: 0x147E594 VA: 0x1482594
	|-ThreadLocal<__Il2CppFullySharedGenericType>.GrowTable
	*/

	// RVA: -1 Offset: -1
	private static int GetNewTableSize(int minSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1480E00 Offset: 0x147CE00 VA: 0x1480E00
	|-ThreadLocal<object>.GetNewTableSize
	|
	|-RVA: 0x148282C Offset: 0x147E82C VA: 0x148282C
	|-ThreadLocal<__Il2CppFullySharedGenericType>.GetNewTableSize
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1480E40 Offset: 0x147CE40 VA: 0x1480E40
	|-ThreadLocal<object>..cctor
	|
	|-RVA: 0x148286C Offset: 0x147E86C VA: 0x148286C
	|-ThreadLocal<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Threading
internal sealed class SystemThreading_ThreadLocalDebugView<T> // TypeDefIndex: 505
{}

// Namespace: System.Threading
[ComVisible(True)]
public class EventWaitHandle : WaitHandle // TypeDefIndex: 506
{
	// Methods

	// RVA: 0x18FA5D4 Offset: 0x18F65D4 VA: 0x18FA5D4
	public void .ctor(bool initialState, EventResetMode mode) { }

	// RVA: 0x1901B00 Offset: 0x18FDB00 VA: 0x1901B00
	public void .ctor(bool initialState, EventResetMode mode, string name) { }

	// RVA: 0x18FF974 Offset: 0x18FB974 VA: 0x18FF974
	public bool Reset() { }

	// RVA: 0x18FC08C Offset: 0x18F808C VA: 0x18FC08C
	public bool Set() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class ContextCallback : MulticastDelegate // TypeDefIndex: 507
{
	// Methods

	// RVA: 0x18FEACC Offset: 0x18FAACC VA: 0x18FEACC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1901DA8 Offset: 0x18FDDA8 VA: 0x1901DA8 Slot: 12
	public virtual void Invoke(object state) { }
}

// Namespace: System.Threading
internal struct ExecutionContextSwitcher // TypeDefIndex: 508
{
	// Fields
	internal ExecutionContext.Reader outerEC; // 0x0
	internal bool outerECBelongsToScope; // 0x8
	internal object hecsw; // 0x10
	internal Thread thread; // 0x18

	// Methods

	[HandleProcessCorruptedStateExceptions]
	[ReliabilityContract(3, 1)]
	// RVA: 0x1901DBC Offset: 0x18FDDBC VA: 0x1901DBC
	internal bool UndoNoThrow() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1901E44 Offset: 0x18FDE44 VA: 0x1901E44
	internal void Undo() { }
}

// Namespace: 
private enum ExecutionContext.Flags // TypeDefIndex: 509
{
	// Fields
	public int value__; // 0x0
	public const ExecutionContext.Flags None = 0;
	public const ExecutionContext.Flags IsNewCapture = 1;
	public const ExecutionContext.Flags IsFlowSuppressed = 2;
	public const ExecutionContext.Flags IsPreAllocatedDefault = 4;
}

// Namespace: 
internal struct ExecutionContext.Reader // TypeDefIndex: 510
{
	// Fields
	private ExecutionContext m_ec; // 0x0

	// Properties
	public bool IsNull { get; }
	public bool IsFlowSuppressed { get; }
	public SynchronizationContext SynchronizationContext { get; }
	public SynchronizationContext SynchronizationContextNoFlow { get; }
	public LogicalCallContext.Reader LogicalCallContext { get; }

	// Methods

	// RVA: 0x190345C Offset: 0x18FF45C VA: 0x190345C
	public void .ctor(ExecutionContext ec) { }

	// RVA: 0x1903464 Offset: 0x18FF464 VA: 0x1903464
	public ExecutionContext DangerousGetRawExecutionContext() { }

	// RVA: 0x190288C Offset: 0x18FE88C VA: 0x190288C
	public bool get_IsNull() { }

	// RVA: 0x190289C Offset: 0x18FE89C VA: 0x190289C
	public bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x190346C Offset: 0x18FF46C VA: 0x190346C
	public bool get_IsFlowSuppressed() { }

	// RVA: 0x1902C00 Offset: 0x18FEC00 VA: 0x1902C00
	public SynchronizationContext get_SynchronizationContext() { }

	// RVA: 0x1902C18 Offset: 0x18FEC18 VA: 0x1902C18
	public SynchronizationContext get_SynchronizationContextNoFlow() { }

	// RVA: 0x190317C Offset: 0x18FF17C VA: 0x190317C
	public LogicalCallContext.Reader get_LogicalCallContext() { }

	// RVA: 0x1902904 Offset: 0x18FE904 VA: 0x1902904
	public bool HasSameLocalValues(ExecutionContext other) { }
}

// Namespace: 
[Flags]
internal enum ExecutionContext.CaptureOptions // TypeDefIndex: 511
{
	// Fields
	public int value__; // 0x0
	public const ExecutionContext.CaptureOptions None = 0;
	public const ExecutionContext.CaptureOptions IgnoreSyncCtx = 1;
	public const ExecutionContext.CaptureOptions OptimizeDefaultCase = 2;
}

// Namespace: System.Threading
[Serializable]
public sealed class ExecutionContext : IDisposable, ISerializable // TypeDefIndex: 512
{
	// Fields
	private SynchronizationContext _syncContext; // 0x10
	private SynchronizationContext _syncContextNoFlow; // 0x18
	private LogicalCallContext _logicalCallContext; // 0x20
	private IllogicalCallContext _illogicalCallContext; // 0x28
	private ExecutionContext.Flags _flags; // 0x30
	private Dictionary<IAsyncLocal, object> _localValues; // 0x38
	private List<IAsyncLocal> _localChangeNotifications; // 0x40
	private static readonly ExecutionContext s_dummyDefaultEC; // 0x0
	internal static readonly ExecutionContext Default; // 0x8

	// Properties
	internal bool isNewCapture { get; set; }
	internal bool isFlowSuppressed { get; set; }
	internal bool IsPreAllocatedDefault { get; }
	internal LogicalCallContext LogicalCallContext { get; set; }
	internal IllogicalCallContext IllogicalCallContext { get; set; }
	internal SynchronizationContext SynchronizationContext { get; set; }
	internal SynchronizationContext SynchronizationContextNoFlow { get; set; }

	// Methods

	// RVA: 0x19023FC Offset: 0x18FE3FC VA: 0x19023FC
	internal bool get_isNewCapture() { }

	// RVA: 0x1902410 Offset: 0x18FE410 VA: 0x1902410
	internal void set_isNewCapture(bool value) { }

	// RVA: 0x1902420 Offset: 0x18FE420 VA: 0x1902420
	internal bool get_isFlowSuppressed() { }

	// RVA: 0x190242C Offset: 0x18FE42C VA: 0x190242C
	internal void set_isFlowSuppressed(bool value) { }

	// RVA: 0x190244C Offset: 0x18FE44C VA: 0x190244C
	internal bool get_IsPreAllocatedDefault() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1902458 Offset: 0x18FE458 VA: 0x1902458
	internal void .ctor() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1902460 Offset: 0x18FE460 VA: 0x1902460
	internal void .ctor(bool isPreAllocatedDefault) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x1901F4C Offset: 0x18FDF4C VA: 0x1901F4C
	internal static void OnAsyncLocalContextChanged(ExecutionContext previous, ExecutionContext current) { }

	// RVA: 0x1902490 Offset: 0x18FE490 VA: 0x1902490
	internal LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x1902500 Offset: 0x18FE500 VA: 0x1902500
	internal void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x1902508 Offset: 0x18FE508 VA: 0x1902508
	internal IllogicalCallContext get_IllogicalCallContext() { }

	// RVA: 0x1902578 Offset: 0x18FE578 VA: 0x1902578
	internal void set_IllogicalCallContext(IllogicalCallContext value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1902580 Offset: 0x18FE580 VA: 0x1902580
	internal SynchronizationContext get_SynchronizationContext() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1902588 Offset: 0x18FE588 VA: 0x1902588
	internal void set_SynchronizationContext(SynchronizationContext value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1902590 Offset: 0x18FE590 VA: 0x1902590
	internal SynchronizationContext get_SynchronizationContextNoFlow() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1902598 Offset: 0x18FE598 VA: 0x1902598
	internal void set_SynchronizationContextNoFlow(SynchronizationContext value) { }

	// RVA: 0x19025A0 Offset: 0x18FE5A0 VA: 0x19025A0 Slot: 4
	public void Dispose() { }

	// RVA: 0x18FEBD4 Offset: 0x18FABD4 VA: 0x18FEBD4
	public static void Run(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[FriendAccessAllowed]
	// RVA: 0x19025A4 Offset: 0x18FE5A4 VA: 0x19025A4
	internal static void Run(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x190281C Offset: 0x18FE81C VA: 0x190281C
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x1902620 Offset: 0x18FE620 VA: 0x1902620
	internal static void RunInternal(ExecutionContext executionContext, ContextCallback callback, object state, bool preserveSyncCtx) { }

	// RVA: 0x1902B7C Offset: 0x18FEB7C VA: 0x1902B7C
	internal static void EstablishCopyOnWriteScope(ref ExecutionContextSwitcher ecsw) { }

	// RVA: 0x190292C Offset: 0x18FE92C VA: 0x190292C
	private static void EstablishCopyOnWriteScope(Thread currentThread, bool knownNullWindowsIdentity, ref ExecutionContextSwitcher ecsw) { }

	[HandleProcessCorruptedStateExceptions]
	// RVA: 0x1902998 Offset: 0x18FE998 VA: 0x1902998
	internal static ExecutionContextSwitcher SetExecutionContext(ExecutionContext executionContext, bool preserveSyncCtx) { }

	// RVA: 0x1902C60 Offset: 0x18FEC60 VA: 0x1902C60
	public ExecutionContext CreateCopy() { }

	// RVA: 0x1902DD8 Offset: 0x18FEDD8 VA: 0x1902DD8
	internal ExecutionContext CreateMutableCopy() { }

	// RVA: 0x1902F18 Offset: 0x18FEF18 VA: 0x1902F18
	public static bool IsFlowSuppressed() { }

	// RVA: 0x18FB0E4 Offset: 0x18F70E4 VA: 0x18FB0E4
	public static ExecutionContext Capture() { }

	[FriendAccessAllowed]
	// RVA: 0x190312C Offset: 0x18FF12C VA: 0x190312C
	internal static ExecutionContext FastCapture() { }

	// RVA: 0x1902F58 Offset: 0x18FEF58 VA: 0x1902F58
	internal static ExecutionContext Capture(ref StackCrawlMark stackMark, ExecutionContext.CaptureOptions options) { }

	// RVA: 0x19031B0 Offset: 0x18FF1B0 VA: 0x19031B0 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19032B0 Offset: 0x18FF2B0 VA: 0x19032B0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19028B4 Offset: 0x18FE8B4 VA: 0x19028B4
	internal bool IsDefaultFTContext(bool ignoreSyncCtx) { }

	// RVA: 0x19033C4 Offset: 0x18FF3C4 VA: 0x19033C4
	private static void .cctor() { }
}

// Namespace: System.Threading
public static class Monitor // TypeDefIndex: 513
{
	// Methods

	// RVA: 0x18FEDA8 Offset: 0x18FADA8 VA: 0x18FEDA8
	public static void Enter(object obj) { }

	// RVA: 0x18FC070 Offset: 0x18F8070 VA: 0x18FC070
	public static void Enter(object obj, ref bool lockTaken) { }

	// RVA: 0x1903488 Offset: 0x18FF488 VA: 0x1903488
	private static void ThrowLockTakenException() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x18FEDAC Offset: 0x18FADAC VA: 0x18FEDAC
	public static void Exit(object obj) { }

	// RVA: 0x1903500 Offset: 0x18FF500 VA: 0x1903500
	public static void TryEnter(object obj, ref bool lockTaken) { }

	// RVA: 0x19035B0 Offset: 0x18FF5B0 VA: 0x19035B0
	public static bool Wait(object obj, int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x18FC948 Offset: 0x18F8948 VA: 0x18FC948
	public static bool Wait(object obj, int millisecondsTimeout) { }

	// RVA: 0x19036BC Offset: 0x18FF6BC VA: 0x19036BC
	public static bool Wait(object obj) { }

	// RVA: 0x1900008 Offset: 0x18FC008 VA: 0x1900008
	public static void Pulse(object obj) { }

	// RVA: 0x18FC2AC Offset: 0x18F82AC VA: 0x18FC2AC
	public static void PulseAll(object obj) { }

	// RVA: 0x1903788 Offset: 0x18FF788 VA: 0x1903788
	private static bool Monitor_test_synchronised(object obj) { }

	// RVA: 0x190378C Offset: 0x18FF78C VA: 0x190378C
	private static void Monitor_pulse(object obj) { }

	// RVA: 0x19036C8 Offset: 0x18FF6C8 VA: 0x19036C8
	private static void ObjPulse(object obj) { }

	// RVA: 0x1903790 Offset: 0x18FF790 VA: 0x1903790
	private static void Monitor_pulse_all(object obj) { }

	// RVA: 0x1903728 Offset: 0x18FF728 VA: 0x1903728
	private static void ObjPulseAll(object obj) { }

	// RVA: 0x1903794 Offset: 0x18FF794 VA: 0x1903794
	private static bool Monitor_wait(object obj, int ms) { }

	// RVA: 0x190360C Offset: 0x18FF60C VA: 0x190360C
	private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj) { }

	// RVA: 0x1903798 Offset: 0x18FF798 VA: 0x1903798
	private static void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken) { }

	// RVA: 0x190351C Offset: 0x18FF51C VA: 0x190351C
	private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken) { }

	// RVA: 0x19034F4 Offset: 0x18FF4F4 VA: 0x19034F4
	private static void ReliableEnter(object obj, ref bool lockTaken) { }
}

// Namespace: System.Threading
[Flags]
internal enum SynchronizationContextProperties // TypeDefIndex: 514
{
	// Fields
	public int value__; // 0x0
	public const SynchronizationContextProperties None = 0;
	public const SynchronizationContextProperties RequireWaitNotification = 1;
}

// Namespace: System.Threading
public class SynchronizationContext // TypeDefIndex: 515
{
	// Fields
	private SynchronizationContextProperties _props; // 0x10

	// Properties
	public static SynchronizationContext Current { get; }
	internal static SynchronizationContext CurrentNoFlow { get; }
	internal static SynchronizationContext CurrentExplicit { get; }

	// Methods

	// RVA: 0x190379C Offset: 0x18FF79C VA: 0x190379C
	public void .ctor() { }

	// RVA: 0x19037A4 Offset: 0x18FF7A4 VA: 0x19037A4
	public bool IsWaitNotificationRequired() { }

	// RVA: 0x19037B0 Offset: 0x18FF7B0 VA: 0x19037B0 Slot: 4
	public virtual void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x19037D4 Offset: 0x18FF7D4 VA: 0x19037D4 Slot: 5
	public virtual void Post(SendOrPostCallback d, object state) { }

	// RVA: 0x1903960 Offset: 0x18FF960 VA: 0x1903960 Slot: 6
	public virtual void OperationStarted() { }

	// RVA: 0x1903964 Offset: 0x18FF964 VA: 0x1903964 Slot: 7
	public virtual void OperationCompleted() { }

	[CLSCompliant(False)]
	[PrePrepareMethod]
	// RVA: 0x1903968 Offset: 0x18FF968 VA: 0x1903968 Slot: 8
	public virtual int Wait(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

	[PrePrepareMethod]
	[ReliabilityContract(3, 1)]
	[CLSCompliant(False)]
	// RVA: 0x19039C8 Offset: 0x18FF9C8 VA: 0x19039C8
	protected static int WaitHelper(IntPtr[] waitHandles, bool waitAll, int millisecondsTimeout) { }

	// RVA: 0x1903A54 Offset: 0x18FFA54 VA: 0x1903A54
	public static void SetSynchronizationContext(SynchronizationContext syncContext) { }

	// RVA: 0x18FB0A8 Offset: 0x18F70A8 VA: 0x18FB0A8
	public static SynchronizationContext get_Current() { }

	[FriendAccessAllowed]
	// RVA: 0x1903B74 Offset: 0x18FFB74 VA: 0x1903B74
	internal static SynchronizationContext get_CurrentNoFlow() { }

	// RVA: 0x1903B28 Offset: 0x18FFB28 VA: 0x1903B28
	private static SynchronizationContext GetThreadLocalContext() { }

	// RVA: 0x1903D10 Offset: 0x18FFD10 VA: 0x1903D10 Slot: 9
	public virtual SynchronizationContext CreateCopy() { }

	// RVA: 0x1903D64 Offset: 0x18FFD64 VA: 0x1903D64
	internal static SynchronizationContext get_CurrentExplicit() { }
}

// Namespace: 
private sealed class OSSpecificSynchronizationContext.InvocationEntryDelegate : MulticastDelegate // TypeDefIndex: 516
{
	// Methods

	// RVA: 0x1904178 Offset: 0x1900178 VA: 0x1904178
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x190431C Offset: 0x190031C VA: 0x190431C Slot: 12
	public virtual void Invoke(IntPtr arg) { }
}

// Namespace: 
private class OSSpecificSynchronizationContext.InvocationContext // TypeDefIndex: 517
{
	// Fields
	private SendOrPostCallback m_Delegate; // 0x10
	private object m_State; // 0x18

	// Methods

	// RVA: 0x1904218 Offset: 0x1900218 VA: 0x1904218
	public void .ctor(SendOrPostCallback d, object state) { }

	// RVA: 0x1904260 Offset: 0x1900260 VA: 0x1904260
	public void Invoke() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class OSSpecificSynchronizationContext.<>c // TypeDefIndex: 518
{
	// Fields
	public static readonly OSSpecificSynchronizationContext.<>c <>9; // 0x0
	public static ConditionalWeakTable.CreateValueCallback<object, OSSpecificSynchronizationContext> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x1904330 Offset: 0x1900330 VA: 0x1904330
	private static void .cctor() { }

	// RVA: 0x1904398 Offset: 0x1900398 VA: 0x1904398
	public void .ctor() { }

	// RVA: 0x19043A0 Offset: 0x19003A0 VA: 0x19043A0
	internal OSSpecificSynchronizationContext <Get>b__3_0(object _osContext) { }
}

// Namespace: System.Threading
internal class OSSpecificSynchronizationContext : SynchronizationContext // TypeDefIndex: 519
{
	// Fields
	private object m_OSSynchronizationContext; // 0x18
	private static readonly ConditionalWeakTable<object, OSSpecificSynchronizationContext> s_ContextCache; // 0x0

	// Methods

	// RVA: 0x1903F4C Offset: 0x18FFF4C VA: 0x1903F4C
	private void .ctor(object osContext) { }

	// RVA: 0x1903BB0 Offset: 0x18FFBB0 VA: 0x1903BB0
	public static OSSpecificSynchronizationContext Get() { }

	// RVA: 0x1903F80 Offset: 0x18FFF80 VA: 0x1903F80 Slot: 9
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x1903FEC Offset: 0x18FFFEC VA: 0x1903FEC Slot: 4
	public override void Send(SendOrPostCallback d, object state) { }

	// RVA: 0x1904024 Offset: 0x1900024 VA: 0x1904024 Slot: 5
	public override void Post(SendOrPostCallback d, object state) { }

	[MonoPInvokeCallback(typeof(OSSpecificSynchronizationContext.InvocationEntryDelegate))]
	// RVA: 0x1903D68 Offset: 0x18FFD68 VA: 0x1903D68
	private static void InvocationEntry(IntPtr arg) { }

	// RVA: 0x1903F7C Offset: 0x18FFF7C VA: 0x1903F7C
	private static object GetOSContext() { }

	// RVA: 0x190425C Offset: 0x190025C VA: 0x190425C
	private static void PostInternal(object osSynchronizationContext, IntPtr callback, IntPtr arg) { }

	// RVA: 0x1904284 Offset: 0x1900284 VA: 0x1904284
	private static void .cctor() { }
}

// Namespace: System.Threading
internal class ThreadHelper // TypeDefIndex: 520
{
	// Fields
	private Delegate _start; // 0x10
	private object _startArg; // 0x18
	private ExecutionContext _executionContext; // 0x20
	internal static ContextCallback _ccb; // 0x0

	// Methods

	// RVA: 0x1904408 Offset: 0x1900408 VA: 0x1904408
	internal void .ctor(Delegate start) { }

	// RVA: 0x1904438 Offset: 0x1900438 VA: 0x1904438
	internal void SetExecutionContextHelper(ExecutionContext ec) { }

	// RVA: 0x1904440 Offset: 0x1900440 VA: 0x1904440
	private static void ThreadStart_Context(object state) { }

	// RVA: 0x190453C Offset: 0x190053C VA: 0x190453C
	internal void ThreadStart(object obj) { }

	// RVA: 0x190464C Offset: 0x190064C VA: 0x190464C
	internal void ThreadStart() { }

	// RVA: 0x1904740 Offset: 0x1900740 VA: 0x1904740
	private static void .cctor() { }
}

// Namespace: System.Threading
public sealed class Thread : CriticalFinalizerObject // TypeDefIndex: 521
{
	// Fields
	private static LocalDataStoreMgr s_LocalDataStoreMgr; // 0x0
	[ThreadStatic]
	private static LocalDataStoreHolder s_LocalDataStore; // 0x80000000
	[ThreadStatic]
	internal static CultureInfo m_CurrentCulture; // 0x80000008
	[ThreadStatic]
	internal static CultureInfo m_CurrentUICulture; // 0x80000010
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentCulture; // 0x8
	private static AsyncLocal<CultureInfo> s_asyncLocalCurrentUICulture; // 0x10
	private InternalThread internal_thread; // 0x10
	private object m_ThreadStartArg; // 0x18
	private object pending_exception; // 0x20
	[ThreadStatic]
	private static Thread current_thread; // 0x80000018
	private MulticastDelegate m_Delegate; // 0x28
	private ExecutionContext m_ExecutionContext; // 0x30
	private bool m_ExecutionContextBelongsToOuterScope; // 0x38
	private IPrincipal principal; // 0x40
	private int principal_version; // 0x48

	// Properties
	internal bool ExecutionContextBelongsToCurrentScope { get; set; }
	public CultureInfo CurrentUICulture { get; }
	public CultureInfo CurrentCulture { get; }
	private InternalThread Internal { get; }
	public static Context CurrentContext { get; }
	public static Thread CurrentThread { get; }
	internal static int CurrentThreadId { get; }
	public bool IsThreadPoolThread { get; }
	internal bool IsThreadPoolThreadInternal { get; }
	public bool IsBackground { set; }
	public string Name { set; }
	public int ManagedThreadId { get; }

	// Methods

	// RVA: 0x19047DC Offset: 0x19007DC VA: 0x19047DC
	public void .ctor(ThreadStart start) { }

	// RVA: 0x190497C Offset: 0x190097C VA: 0x190497C
	public void .ctor(ParameterizedThreadStart start, int maxStackSize) { }

	// RVA: 0x1904A64 Offset: 0x1900A64 VA: 0x1904A64
	public void Start() { }

	// RVA: 0x1904B4C Offset: 0x1900B4C VA: 0x1904B4C
	public void Start(object parameter) { }

	// RVA: 0x1904A80 Offset: 0x1900A80 VA: 0x1904A80
	private void Start(ref StackCrawlMark stackMark) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1901F00 Offset: 0x18FDF00 VA: 0x1901F00
	internal ExecutionContext.Reader GetExecutionContextReader() { }

	// RVA: 0x1902BE4 Offset: 0x18FEBE4 VA: 0x1902BE4
	internal bool get_ExecutionContextBelongsToCurrentScope() { }

	// RVA: 0x1902BF4 Offset: 0x18FEBF4 VA: 0x1902BF4
	internal void set_ExecutionContextBelongsToCurrentScope(bool value) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1903A9C Offset: 0x18FFA9C VA: 0x1903A9C
	internal ExecutionContext GetMutableExecutionContext() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1902C30 Offset: 0x18FEC30 VA: 0x1902C30
	internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1901F1C Offset: 0x18FDF1C VA: 0x1901F1C
	internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope) { }

	// RVA: 0x1904C98 Offset: 0x1900C98 VA: 0x1904C98
	private static void SleepInternal(int millisecondsTimeout) { }

	// RVA: 0x19016CC Offset: 0x18FD6CC VA: 0x19016CC
	public static void Sleep(int millisecondsTimeout) { }

	// RVA: 0x1904C9C Offset: 0x1900C9C VA: 0x1904C9C
	private static bool YieldInternal() { }

	// RVA: 0x1901744 Offset: 0x18FD744 VA: 0x1901744
	public static bool Yield() { }

	// RVA: 0x1904858 Offset: 0x1900858 VA: 0x1904858
	private void SetStartHelper(Delegate start, int maxStackSize) { }

	// RVA: 0x1904D98 Offset: 0x1900D98 VA: 0x1904D98
	public CultureInfo get_CurrentUICulture() { }

	// RVA: 0x1904DC4 Offset: 0x1900DC4 VA: 0x1904DC4
	internal CultureInfo GetCurrentUICultureNoAppX() { }

	// RVA: 0x1904E70 Offset: 0x1900E70 VA: 0x1904E70
	public CultureInfo get_CurrentCulture() { }

	// RVA: 0x1904E9C Offset: 0x1900E9C VA: 0x1904E9C
	private CultureInfo GetCurrentCultureNoAppX() { }

	// RVA: 0x1904F48 Offset: 0x1900F48 VA: 0x1904F48
	public static void MemoryBarrier() { }

	// RVA: 0x1904F4C Offset: 0x1900F4C VA: 0x1904F4C
	private void ConstructInternalThread() { }

	// RVA: 0x1904F50 Offset: 0x1900F50 VA: 0x1904F50
	private InternalThread get_Internal() { }

	// RVA: 0x1904F74 Offset: 0x1900F74 VA: 0x1904F74
	public static Context get_CurrentContext() { }

	// RVA: 0x1904F7C Offset: 0x1900F7C VA: 0x1904F7C
	private static void GetCurrentThread_icall(ref Thread thread) { }

	// RVA: 0x1904F80 Offset: 0x1900F80 VA: 0x1904F80
	private static Thread GetCurrentThread() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1901748 Offset: 0x18FD748 VA: 0x1901748
	public static Thread get_CurrentThread() { }

	// RVA: 0x1904F98 Offset: 0x1900F98 VA: 0x1904F98
	internal static int get_CurrentThreadId() { }

	// RVA: 0x1904FBC Offset: 0x1900FBC VA: 0x1904FBC
	public static int GetDomainID() { }

	// RVA: 0x1904FC0 Offset: 0x1900FC0 VA: 0x1904FC0
	private bool Thread_internal(MulticastDelegate start) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1904FC4 Offset: 0x1900FC4 VA: 0x1904FC4 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1904FCC Offset: 0x1900FCC VA: 0x1904FCC
	public bool get_IsThreadPoolThread() { }

	// RVA: 0x1904FD0 Offset: 0x1900FD0 VA: 0x1904FD0
	internal bool get_IsThreadPoolThreadInternal() { }

	// RVA: 0x1904FFC Offset: 0x1900FFC VA: 0x1904FFC
	public void set_IsBackground(bool value) { }

	// RVA: 0x19050D0 Offset: 0x19010D0 VA: 0x19050D0
	private static void SetName_icall(InternalThread thread, char* name, int nameLength) { }

	// RVA: 0x19050D4 Offset: 0x19010D4 VA: 0x19050D4
	private static void SetName_internal(InternalThread thread, string name) { }

	// RVA: 0x1905110 Offset: 0x1901110 VA: 0x1905110
	public void set_Name(string value) { }

	// RVA: 0x1905144 Offset: 0x1901144 VA: 0x1905144
	private static void Abort_internal(InternalThread thread, object stateInfo) { }

	// RVA: 0x1905148 Offset: 0x1901148 VA: 0x1905148
	public void Abort() { }

	// RVA: 0x1905170 Offset: 0x1901170 VA: 0x1905170
	private static void SpinWait_nop() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x19016A4 Offset: 0x18FD6A4 VA: 0x19016A4
	public static void SpinWait(int iterations) { }

	// RVA: 0x1904C28 Offset: 0x1900C28 VA: 0x1904C28
	private void StartInternal(object principal, ref StackCrawlMark stackMark) { }

	// RVA: 0x19050C8 Offset: 0x19010C8 VA: 0x19050C8
	private static void SetState(InternalThread thread, ThreadState set) { }

	// RVA: 0x19050CC Offset: 0x19010CC VA: 0x19050CC
	private static void ClrState(InternalThread thread, ThreadState clr) { }

	// RVA: 0x1905174 Offset: 0x1901174 VA: 0x1905174
	private static ThreadState GetState(InternalThread thread) { }

	// RVA: 0x1905178 Offset: 0x1901178 VA: 0x1905178
	private static int SystemMaxStackStize() { }

	// RVA: 0x1904CA0 Offset: 0x1900CA0 VA: 0x1904CA0
	private static int GetProcessDefaultStackSize(int maxStackSize) { }

	// RVA: 0x1904D4C Offset: 0x1900D4C VA: 0x1904D4C
	private void SetStart(MulticastDelegate start, int maxStackSize) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x19017A4 Offset: 0x18FD7A4 VA: 0x19017A4
	public int get_ManagedThreadId() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1900E3C Offset: 0x18FCE3C VA: 0x1900E3C
	public static void BeginCriticalRegion() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1901428 Offset: 0x18FD428 VA: 0x1901428
	public static void EndCriticalRegion() { }

	[ComVisible(False)]
	// RVA: 0x190517C Offset: 0x190117C VA: 0x190517C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1905058 Offset: 0x1901058 VA: 0x1905058
	private ThreadState ValidateThreadState() { }
}

// Namespace: System.Threading
[Serializable]
internal enum StackCrawlMark // TypeDefIndex: 522
{
	// Fields
	public int value__; // 0x0
	public const StackCrawlMark LookForMe = 0;
	public const StackCrawlMark LookForMyCaller = 1;
	public const StackCrawlMark LookForMyCallersCaller = 2;
	public const StackCrawlMark LookForThread = 3;
}

// Namespace: System.Threading
[ComVisible(True)]
[Serializable]
public sealed class ThreadAbortException : SystemException // TypeDefIndex: 523
{
	// Methods

	// RVA: 0x1905180 Offset: 0x1901180 VA: 0x1905180
	private void .ctor() { }

	// RVA: 0x19051FC Offset: 0x19011FC VA: 0x19051FC
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
[ComVisible(True)]
[Serializable]
public class ThreadInterruptedException : SystemException // TypeDefIndex: 524
{
	// Methods

	// RVA: 0x1905204 Offset: 0x1901204 VA: 0x1905204
	public void .ctor() { }

	// RVA: 0x1905280 Offset: 0x1901280 VA: 0x1905280
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading
internal interface IThreadPoolWorkItem // TypeDefIndex: 525
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ExecuteWorkItem();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void MarkAborted(ThreadAbortException tae);
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class WaitCallback : MulticastDelegate // TypeDefIndex: 526
{
	// Methods

	// RVA: 0x1903858 Offset: 0x18FF858 VA: 0x1903858
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1905288 Offset: 0x1901288 VA: 0x1905288 Slot: 12
	public virtual void Invoke(object state) { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class WaitOrTimerCallback : MulticastDelegate // TypeDefIndex: 527
{
	// Methods

	// RVA: 0x190529C Offset: 0x190129C VA: 0x190529C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x19053A8 Offset: 0x19013A8 VA: 0x19053A8 Slot: 12
	public virtual void Invoke(object state, bool timedOut) { }
}

// Namespace: System.Threading
internal static class ThreadPoolGlobals // TypeDefIndex: 528
{
	// Fields
	public static int processorCount; // 0x0
	public static bool vmTpInitialized; // 0x4
	public static bool enableWorkerTracking; // 0x5
	public static readonly ThreadPoolWorkQueue workQueue; // 0x8

	// Methods

	// RVA: 0x19053BC Offset: 0x19013BC VA: 0x19053BC
	private static void .cctor() { }
}

// Namespace: 
internal class ThreadPoolWorkQueue.SparseArray<T> // TypeDefIndex: 529
{
	// Fields
	private T[] m_array; // 0x0

	// Properties
	internal T[] Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int initialSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1463394 Offset: 0x145F394 VA: 0x1463394
	|-ThreadPoolWorkQueue.SparseArray<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T[] get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14633F4 Offset: 0x145F3F4 VA: 0x14633F4
	|-ThreadPoolWorkQueue.SparseArray<object>.get_Current
	*/

	// RVA: -1 Offset: -1
	internal int Add(T e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146340C Offset: 0x145F40C VA: 0x146340C
	|-ThreadPoolWorkQueue.SparseArray<object>.Add
	*/

	// RVA: -1 Offset: -1
	internal void Remove(T e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1463664 Offset: 0x145F664 VA: 0x1463664
	|-ThreadPoolWorkQueue.SparseArray<object>.Remove
	*/
}

// Namespace: 
internal class ThreadPoolWorkQueue.WorkStealingQueue // TypeDefIndex: 530
{
	// Fields
	internal IThreadPoolWorkItem[] m_array; // 0x10
	private int m_mask; // 0x18
	private int m_headIndex; // 0x1C
	private int m_tailIndex; // 0x20
	private SpinLock m_foreignLock; // 0x24

	// Methods

	// RVA: 0x19057D4 Offset: 0x19017D4 VA: 0x19057D4
	public void LocalPush(IThreadPoolWorkItem obj) { }

	// RVA: 0x1905E28 Offset: 0x1901E28 VA: 0x1905E28
	public bool LocalFindAndPop(IThreadPoolWorkItem obj) { }

	// RVA: 0x1906340 Offset: 0x1902340 VA: 0x1906340
	public bool LocalPop(out IThreadPoolWorkItem obj) { }

	// RVA: 0x1906818 Offset: 0x1902818 VA: 0x1906818
	public bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal) { }

	// RVA: 0x1906D24 Offset: 0x1902D24 VA: 0x1906D24
	private bool TrySteal(out IThreadPoolWorkItem obj, ref bool missedSteal, int millisecondsTimeout) { }

	// RVA: 0x190700C Offset: 0x190300C VA: 0x190700C
	public void .ctor() { }
}

// Namespace: 
internal class ThreadPoolWorkQueue.QueueSegment // TypeDefIndex: 531
{
	// Fields
	internal readonly IThreadPoolWorkItem[] nodes; // 0x10
	private int indexes; // 0x18
	public ThreadPoolWorkQueue.QueueSegment Next; // 0x20

	// Methods

	// RVA: 0x1907098 Offset: 0x1903098 VA: 0x1907098
	private void GetIndexes(out int upper, out int lower) { }

	// RVA: 0x19070CC Offset: 0x19030CC VA: 0x19070CC
	private bool CompareExchangeIndexes(ref int prevUpper, int newUpper, ref int prevLower, int newLower) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x19054C4 Offset: 0x19014C4 VA: 0x19054C4
	public void .ctor() { }

	// RVA: 0x19067D8 Offset: 0x19027D8 VA: 0x19067D8
	public bool IsUsedUp() { }

	// RVA: 0x1905CF8 Offset: 0x1901CF8 VA: 0x1905CF8
	public bool TryEnqueue(IThreadPoolWorkItem node) { }

	// RVA: 0x1906680 Offset: 0x1902680 VA: 0x1906680
	public bool TryDequeue(out IThreadPoolWorkItem node) { }
}

// Namespace: System.Threading
internal sealed class ThreadPoolWorkQueue // TypeDefIndex: 532
{
	// Fields
	internal ThreadPoolWorkQueue.QueueSegment queueHead; // 0x10
	internal ThreadPoolWorkQueue.QueueSegment queueTail; // 0x18
	internal static ThreadPoolWorkQueue.SparseArray<ThreadPoolWorkQueue.WorkStealingQueue> allThreadQueues; // 0x0
	private int numOutstandingThreadRequests; // 0x20

	// Methods

	// RVA: 0x1905444 Offset: 0x1901444 VA: 0x1905444
	public void .ctor() { }

	// RVA: 0x1905528 Offset: 0x1901528 VA: 0x1905528
	public ThreadPoolWorkQueueThreadLocals EnsureCurrentThreadHasQueue() { }

	// RVA: 0x19055B8 Offset: 0x19015B8 VA: 0x19055B8
	internal void EnsureThreadRequested() { }

	// RVA: 0x1905658 Offset: 0x1901658 VA: 0x1905658
	internal void MarkThreadRequestSatisfied() { }

	// RVA: 0x19056A4 Offset: 0x19016A4 VA: 0x19056A4
	public void Enqueue(IThreadPoolWorkItem callback, bool forceGlobal) { }

	// RVA: 0x1905DB8 Offset: 0x1901DB8 VA: 0x1905DB8
	internal bool LocalFindAndPop(IThreadPoolWorkItem callback) { }

	// RVA: 0x1906178 Offset: 0x1902178 VA: 0x1906178
	public void Dequeue(ThreadPoolWorkQueueThreadLocals tl, out IThreadPoolWorkItem callback, out bool missedSteal) { }

	// RVA: 0x1906820 Offset: 0x1902820 VA: 0x1906820
	internal static bool Dispatch() { }

	// RVA: 0x1906C88 Offset: 0x1902C88 VA: 0x1906C88
	private static void .cctor() { }
}

// Namespace: System.Threading
internal sealed class ThreadPoolWorkQueueThreadLocals // TypeDefIndex: 533
{
	// Fields
	[ThreadStatic]
	public static ThreadPoolWorkQueueThreadLocals threadLocals; // 0x80000000
	public readonly ThreadPoolWorkQueue workQueue; // 0x10
	public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue; // 0x18
	public readonly Random random; // 0x20

	// Methods

	// RVA: 0x19073C8 Offset: 0x19033C8 VA: 0x19073C8
	public void .ctor(ThreadPoolWorkQueue tpq) { }

	// RVA: 0x1907508 Offset: 0x1903508 VA: 0x1907508
	private void CleanUp() { }

	// RVA: 0x19075D8 Offset: 0x19035D8 VA: 0x19075D8 Slot: 1
	protected override void Finalize() { }
}

// Namespace: System.Threading
internal static class _ThreadPoolWaitCallback // TypeDefIndex: 534
{
	// Methods

	// RVA: 0x1907694 Offset: 0x1903694 VA: 0x1907694
	internal static bool PerformWaitCallback() { }
}

// Namespace: System.Threading
internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem // TypeDefIndex: 535
{
	// Fields
	private WaitCallback callback; // 0x10
	private ExecutionContext context; // 0x18
	private object state; // 0x20
	internal static ContextCallback ccb; // 0x0

	// Methods

	// RVA: 0x19076E4 Offset: 0x19036E4 VA: 0x19076E4
	internal void .ctor(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark) { }

	// RVA: 0x19077D0 Offset: 0x19037D0 VA: 0x19077D0 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x19078B4 Offset: 0x19038B4 VA: 0x19078B4 Slot: 5
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x19078B8 Offset: 0x19038B8 VA: 0x19078B8
	private static void WaitCallback_Context(object state) { }

	// RVA: 0x1907930 Offset: 0x1903930 VA: 0x1907930
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ThreadPool.<>c__DisplayClass17_0<TState> // TypeDefIndex: 536
{
	// Fields
	public Action<TState> callBack; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1156A70 Offset: 0x1152A70 VA: 0x1156A70
	|-ThreadPool.<>c__DisplayClass17_0<object>..ctor
	|
	|-RVA: 0x1156AF4 Offset: 0x1152AF4 VA: 0x1156AF4
	|-ThreadPool.<>c__DisplayClass17_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <QueueUserWorkItem>b__0(object x) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1156A78 Offset: 0x1152A78 VA: 0x1156A78
	|-ThreadPool.<>c__DisplayClass17_0<object>.<QueueUserWorkItem>b__0
	|
	|-RVA: 0x1156AFC Offset: 0x1152AFC VA: 0x1156AFC
	|-ThreadPool.<>c__DisplayClass17_0<__Il2CppFullySharedGenericType>.<QueueUserWorkItem>b__0
	*/
}

// Namespace: System.Threading
public static class ThreadPool // TypeDefIndex: 537
{
	// Properties
	internal static bool IsThreadPoolThread { get; }

	// Methods

	// RVA: 0x19079D0 Offset: 0x19039D0 VA: 0x19079D0
	private static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack) { }

	// RVA: 0x1907CDC Offset: 0x1903CDC VA: 0x1907CDC
	public static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x1907C8C Offset: 0x1903C8C VA: 0x1907C8C
	public static bool QueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: 0x1907F28 Offset: 0x1903F28 VA: 0x1907F28
	public static bool QueueUserWorkItem(WaitCallback callBack) { }

	// RVA: 0x1907CB4 Offset: 0x1903CB4 VA: 0x1907CB4
	public static bool UnsafeQueueUserWorkItem(WaitCallback callBack, object state) { }

	// RVA: -1 Offset: -1
	public static bool QueueUserWorkItem<TState>(Action<TState> callBack, TState state, bool preferLocal) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1038DA4 Offset: 0x1034DA4 VA: 0x1038DA4
	|-ThreadPool.QueueUserWorkItem<object>
	|
	|-RVA: 0x1038EDC Offset: 0x1034EDC VA: 0x1038EDC
	|-ThreadPool.QueueUserWorkItem<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1907E0C Offset: 0x1903E0C VA: 0x1907E0C
	private static bool QueueUserWorkItemHelper(WaitCallback callBack, object state, ref StackCrawlMark stackMark, bool compressStack, bool forceGlobal = True) { }

	// RVA: 0x1907FE8 Offset: 0x1903FE8 VA: 0x1907FE8
	internal static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal) { }

	// RVA: 0x1908068 Offset: 0x1904068 VA: 0x1908068
	internal static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem) { }

	// RVA: 0x1908108 Offset: 0x1904108 VA: 0x1908108
	internal static bool RequestWorkerThread() { }

	// RVA: 0x1907F54 Offset: 0x1903F54 VA: 0x1907F54
	private static void EnsureVMInitialized() { }

	// RVA: 0x1908110 Offset: 0x1904110 VA: 0x1908110
	internal static bool NotifyWorkItemComplete() { }

	// RVA: 0x1908114 Offset: 0x1904114 VA: 0x1908114
	internal static void ReportThreadStatus(bool isWorking) { }

	// RVA: 0x1908118 Offset: 0x1904118 VA: 0x1908118
	internal static void NotifyWorkItemProgress() { }

	// RVA: 0x1908128 Offset: 0x1904128 VA: 0x1908128
	internal static void NotifyWorkItemProgressNative() { }

	// RVA: 0x190812C Offset: 0x190412C VA: 0x190812C
	internal static void NotifyWorkItemQueued() { }

	// RVA: 0x190810C Offset: 0x190410C VA: 0x190810C
	private static void InitializeVMTp(ref bool enableWorkerTracking) { }

	// RVA: 0x1908130 Offset: 0x1904130 VA: 0x1908130
	internal static bool get_IsThreadPoolThread() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public abstract class WaitHandle : MarshalByRefObject, IDisposable // TypeDefIndex: 538
{
	// Fields
	public const int WaitTimeout = 258;
	private const int MAX_WAITHANDLES = 64;
	private IntPtr waitHandle; // 0x18
	internal SafeWaitHandle safeWaitHandle; // 0x20
	internal bool hasThreadAffinity; // 0x28
	private const int WAIT_OBJECT_0 = 0;
	private const int WAIT_ABANDONED = 128;
	private const int WAIT_FAILED = 2147483647;
	private const int ERROR_TOO_MANY_POSTS = 298;
	private const int ERROR_NOT_OWNED_BY_CALLER = 299;
	protected static readonly IntPtr InvalidHandle; // 0x0
	internal const int MaxWaitHandles = 64;

	// Properties
	[Obsolete("Use the SafeWaitHandle property instead.")]
	public virtual IntPtr Handle { set; }
	public SafeWaitHandle SafeWaitHandle { get; }

	// Methods

	// RVA: 0x1908150 Offset: 0x1904150 VA: 0x1908150
	protected void .ctor() { }

	// RVA: 0x190816C Offset: 0x190416C VA: 0x190816C
	private void Init() { }

	// RVA: 0x19081E4 Offset: 0x19041E4 VA: 0x19081E4 Slot: 7
	public virtual void set_Handle(IntPtr value) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x19082DC Offset: 0x19042DC VA: 0x19082DC
	public SafeWaitHandle get_SafeWaitHandle() { }

	// RVA: 0x1908394 Offset: 0x1904394 VA: 0x1908394
	internal void SetHandleInternal(SafeWaitHandle handle) { }

	// RVA: 0x19083D4 Offset: 0x19043D4 VA: 0x19083D4 Slot: 8
	public virtual bool WaitOne(int millisecondsTimeout, bool exitContext) { }

	// RVA: 0x19084D4 Offset: 0x19044D4 VA: 0x19084D4 Slot: 9
	public virtual bool WaitOne() { }

	// RVA: 0x19084E8 Offset: 0x19044E8 VA: 0x19084E8 Slot: 10
	public virtual bool WaitOne(int millisecondsTimeout) { }

	// RVA: 0x1908454 Offset: 0x1904454 VA: 0x1908454
	private bool WaitOne(long timeout, bool exitContext) { }

	// RVA: 0x19084F8 Offset: 0x19044F8 VA: 0x19084F8
	internal static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x19087FC Offset: 0x19047FC VA: 0x19087FC
	public static int WaitAny(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1909038 Offset: 0x1905038 VA: 0x1909038
	public static int WaitAny(WaitHandle[] waitHandles, TimeSpan timeout, bool exitContext) { }

	// RVA: 0x19087C4 Offset: 0x19047C4 VA: 0x19087C4
	private static void ThrowAbandonedMutexException() { }

	// RVA: 0x1908FEC Offset: 0x1904FEC VA: 0x1908FEC
	private static void ThrowAbandonedMutexException(int location, WaitHandle handle) { }

	// RVA: 0x1909164 Offset: 0x1905164 VA: 0x1909164 Slot: 11
	public virtual void Close() { }

	// RVA: 0x19091D0 Offset: 0x19051D0 VA: 0x19091D0 Slot: 12
	protected virtual void Dispose(bool explicitDisposing) { }

	// RVA: 0x1909218 Offset: 0x1905218 VA: 0x1909218 Slot: 6
	public void Dispose() { }

	// RVA: 0x19085E4 Offset: 0x19045E4 VA: 0x19085E4
	private static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext) { }

	// RVA: 0x1908AEC Offset: 0x1904AEC VA: 0x1908AEC
	private static int WaitMultiple(WaitHandle[] waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll) { }

	// RVA: 0x1909284 Offset: 0x1905284 VA: 0x1909284
	internal static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms) { }

	// RVA: 0x1909288 Offset: 0x1905288 VA: 0x1909288
	private static void .cctor() { }
}

// Namespace: System.Threading
public static class Interlocked // TypeDefIndex: 539
{
	// Methods

	[ReliabilityContract(3, 2)]
	// RVA: 0x19092DC Offset: 0x19052DC VA: 0x19092DC
	public static int CompareExchange(ref int location1, int value, int comparand) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x19092E0 Offset: 0x19052E0 VA: 0x19092E0
	internal static int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x19092E4 Offset: 0x19052E4 VA: 0x19092E4
	private static void CompareExchange(ref object location1, ref object value, ref object comparand, ref object result) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x19092E8 Offset: 0x19052E8 VA: 0x19092E8
	public static object CompareExchange(ref object location1, object value, object comparand) { }

	// RVA: 0x1909314 Offset: 0x1905314 VA: 0x1909314
	public static float CompareExchange(ref float location1, float value, float comparand) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1909318 Offset: 0x1905318 VA: 0x1909318
	public static int Decrement(ref int location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x190931C Offset: 0x190531C VA: 0x190931C
	public static int Increment(ref int location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1909320 Offset: 0x1905320 VA: 0x1909320
	public static long Increment(ref long location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1909324 Offset: 0x1905324 VA: 0x1909324
	public static int Exchange(ref int location1, int value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1909328 Offset: 0x1905328 VA: 0x1909328
	private static void Exchange(ref object location1, ref object value, ref object result) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x190932C Offset: 0x190532C VA: 0x190932C
	public static object Exchange(ref object location1, object value) { }

	// RVA: 0x1909350 Offset: 0x1905350 VA: 0x1909350
	public static float Exchange(ref float location1, float value) { }

	// RVA: 0x1909354 Offset: 0x1905354 VA: 0x1909354
	public static long CompareExchange(ref long location1, long value, long comparand) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1909358 Offset: 0x1905358 VA: 0x1909358
	public static IntPtr CompareExchange(ref IntPtr location1, IntPtr value, IntPtr comparand) { }

	// RVA: 0x190935C Offset: 0x190535C VA: 0x190935C
	public static double CompareExchange(ref double location1, double value, double comparand) { }

	[Intrinsic]
	[ReliabilityContract(3, 2)]
	[ComVisible(False)]
	// RVA: -1 Offset: -1
	public static T CompareExchange<T>(ref T location1, T value, T comparand) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.CompareExchange<object>
	*/

	// RVA: 0x1909360 Offset: 0x1905360 VA: 0x1909360
	public static long Exchange(ref long location1, long value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1909364 Offset: 0x1905364 VA: 0x1909364
	public static IntPtr Exchange(ref IntPtr location1, IntPtr value) { }

	// RVA: 0x1909368 Offset: 0x1905368 VA: 0x1909368
	public static double Exchange(ref double location1, double value) { }

	[ComVisible(False)]
	[ReliabilityContract(3, 2)]
	[Intrinsic]
	// RVA: -1 Offset: -1
	public static T Exchange<T>(ref T location1, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Interlocked.Exchange<object>
	*/

	// RVA: 0x190936C Offset: 0x190536C VA: 0x190936C
	public static long Read(ref long location) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1909370 Offset: 0x1905370 VA: 0x1909370
	public static int Add(ref int location1, int value) { }

	// RVA: 0x1909374 Offset: 0x1905374 VA: 0x1909374
	public static void MemoryBarrier() { }
}

// Namespace: System.Threading
internal class LockQueue // TypeDefIndex: 540
{
	// Fields
	private ReaderWriterLock rwlock; // 0x10
	private int lockCount; // 0x18

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x190937C Offset: 0x190537C VA: 0x190937C
	public void .ctor(ReaderWriterLock rwlock) { }

	// RVA: 0x19093AC Offset: 0x19053AC VA: 0x19093AC
	public bool Wait(int timeout) { }

	// RVA: 0x1909540 Offset: 0x1905540 VA: 0x1909540
	public bool get_IsEmpty() { }

	// RVA: 0x1909604 Offset: 0x1905604 VA: 0x1909604
	public void Pulse() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class Mutex : WaitHandle // TypeDefIndex: 541
{}

// Namespace: System.Threading
internal static class NativeEventCalls // TypeDefIndex: 542
{
	// Methods

	// RVA: 0x19096BC Offset: 0x19056BC VA: 0x19096BC
	public static IntPtr CreateEvent_internal(bool manual, bool initial, string name, out int errorCode) { }

	// RVA: 0x1909710 Offset: 0x1905710 VA: 0x1909710
	private static IntPtr CreateEvent_icall(bool manual, bool initial, char* name, int name_length, out int errorCode) { }

	// RVA: 0x1909714 Offset: 0x1905714 VA: 0x1909714
	public static bool SetEvent(SafeWaitHandle handle) { }

	// RVA: 0x19097F4 Offset: 0x19057F4 VA: 0x19097F4
	private static bool SetEvent_internal(IntPtr handle) { }

	// RVA: 0x19097F8 Offset: 0x19057F8 VA: 0x19097F8
	public static bool ResetEvent(SafeWaitHandle handle) { }

	// RVA: 0x19098D8 Offset: 0x19058D8 VA: 0x19098D8
	private static bool ResetEvent_internal(IntPtr handle) { }

	// RVA: 0x19098DC Offset: 0x19058DC VA: 0x19098DC
	public static void CloseEvent_internal(IntPtr handle) { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class ReaderWriterLock : CriticalFinalizerObject // TypeDefIndex: 543
{
	// Fields
	private int seq_num; // 0x10
	private int state; // 0x14
	private int readers; // 0x18
	private int writer_lock_owner; // 0x1C
	private LockQueue writer_queue; // 0x20
	private Hashtable reader_locks; // 0x28

	// Methods

	// RVA: 0x19098E0 Offset: 0x19058E0 VA: 0x19098E0
	public void .ctor() { }

	// RVA: 0x19099D4 Offset: 0x19059D4 VA: 0x19099D4 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x19099DC Offset: 0x19059DC VA: 0x19099DC
	public void AcquireWriterLock(int millisecondsTimeout) { }

	// RVA: 0x19099E4 Offset: 0x19059E4 VA: 0x19099E4
	private void AcquireWriterLock(int millisecondsTimeout, int initialLockCount) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1909BC0 Offset: 0x1905BC0 VA: 0x1909BC0
	public void ReleaseWriterLock() { }

	// RVA: 0x1909CE8 Offset: 0x1905CE8 VA: 0x1909CE8
	private void ReleaseWriterLock(int releaseCount) { }

	// RVA: 0x1909B8C Offset: 0x1905B8C VA: 0x1909B8C
	private bool HasWriterLock() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class RegisteredWaitHandle : MarshalByRefObject // TypeDefIndex: 544
{
	// Fields
	private WaitHandle _waitObject; // 0x18
	private WaitOrTimerCallback _callback; // 0x20
	private object _state; // 0x28
	private WaitHandle _finalEvent; // 0x30
	private ManualResetEvent _cancelEvent; // 0x38
	private TimeSpan _timeout; // 0x40
	private int _callsInProcess; // 0x48
	private bool _executeOnlyOnce; // 0x4C
	private bool _unregistered; // 0x4D

	// Methods

	// RVA: 0x1907B98 Offset: 0x1903B98 VA: 0x1907B98
	internal void .ctor(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	// RVA: 0x1909D48 Offset: 0x1905D48 VA: 0x1909D48
	internal void Wait(object state) { }

	// RVA: 0x190A2CC Offset: 0x19062CC VA: 0x190A2CC
	private void DoCallBack(object timedOut) { }
}

// Namespace: System.Threading
internal sealed class InternalThread : CriticalFinalizerObject // TypeDefIndex: 545
{
	// Fields
	private int lock_thread_id; // 0x10
	private IntPtr handle; // 0x18
	private IntPtr native_handle; // 0x20
	private IntPtr name_chars; // 0x28
	private int name_free; // 0x30
	private int name_length; // 0x34
	private ThreadState state; // 0x38
	private object abort_exc; // 0x40
	private int abort_state_handle; // 0x48
	internal long thread_id; // 0x50
	private IntPtr debugger_thread; // 0x58
	private UIntPtr static_data; // 0x60
	private IntPtr runtime_thread_info; // 0x68
	private object current_appcontext; // 0x70
	private object root_domain_thread; // 0x78
	internal byte[] _serialized_principal; // 0x80
	internal int _serialized_principal_version; // 0x88
	private IntPtr appdomain_refs; // 0x90
	private int interruption_requested; // 0x98
	private IntPtr longlived; // 0xA0
	internal bool threadpool_thread; // 0xA8
	private bool thread_interrupt_requested; // 0xA9
	internal int stack_size; // 0xAC
	internal byte apartment_state; // 0xB0
	internal int critical_region_level; // 0xB4
	internal int managed_id; // 0xB8
	private int small_id; // 0xBC
	private IntPtr manage_callback; // 0xC0
	private IntPtr flags; // 0xC8
	private IntPtr thread_pinning_ref; // 0xD0
	private IntPtr abort_protected_block_count; // 0xD8
	private int priority; // 0xE0
	private IntPtr owned_mutex; // 0xE8
	private IntPtr suspended_event; // 0xF0
	private int self_suspended; // 0xF8
	private IntPtr thread_state; // 0x100
	private IntPtr netcore0; // 0x108
	private IntPtr netcore1; // 0x110
	private IntPtr netcore2; // 0x118
	private IntPtr last; // 0x120

	// Methods

	// RVA: 0x190A3A8 Offset: 0x19063A8 VA: 0x190A3A8
	private void Thread_free_internal() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x190A3AC Offset: 0x19063AC VA: 0x190A3AC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x190A430 Offset: 0x1906430 VA: 0x190A430
	public void .ctor() { }
}

// Namespace: 
private struct Timer.TimerComparer : IComparer, IComparer<Timer> // TypeDefIndex: 546
{
	// Methods

	// RVA: 0x190ABD8 Offset: 0x1906BD8 VA: 0x190ABD8 Slot: 4
	private int System.Collections.IComparer.Compare(object x, object y) { }

	// RVA: 0x190AC70 Offset: 0x1906C70 VA: 0x190AC70 Slot: 5
	public int Compare(Timer tx, Timer ty) { }
}

// Namespace: 
private sealed class Timer.Scheduler // TypeDefIndex: 547
{
	// Fields
	private static readonly Timer.Scheduler instance; // 0x0
	private bool needReSort; // 0x10
	private List<Timer> list; // 0x18
	private long current_next_run; // 0x20
	private ManualResetEvent changed; // 0x28

	// Properties
	public static Timer.Scheduler Instance { get; }

	// Methods

	// RVA: 0x190ACE0 Offset: 0x1906CE0 VA: 0x190ACE0
	private void InitScheduler() { }

	// RVA: 0x190ADE8 Offset: 0x1906DE8 VA: 0x190ADE8
	private void WakeupScheduler() { }

	// RVA: 0x190AE00 Offset: 0x1906E00 VA: 0x190AE00
	private void SchedulerThread() { }

	// RVA: 0x190B2B4 Offset: 0x19072B4 VA: 0x190B2B4
	public static Timer.Scheduler get_Instance() { }

	// RVA: 0x190B30C Offset: 0x190730C VA: 0x190B30C
	private void .ctor() { }

	// RVA: 0x190A964 Offset: 0x1906964 VA: 0x190A964
	public void Remove(Timer timer) { }

	// RVA: 0x190AA3C Offset: 0x1906A3C VA: 0x190AA3C
	public void Change(Timer timer, long new_next_run) { }

	// RVA: 0x190B3E4 Offset: 0x19073E4 VA: 0x190B3E4
	private void Add(Timer timer) { }

	// RVA: 0x190B3B4 Offset: 0x19073B4 VA: 0x190B3B4
	private void InternalRemove(Timer timer) { }

	// RVA: 0x190B4DC Offset: 0x19074DC VA: 0x190B4DC
	private static void TimerCB(object o) { }

	// RVA: 0x190B554 Offset: 0x1907554 VA: 0x190B554
	private void FireTimer(Timer timer) { }

	// RVA: 0x190AF34 Offset: 0x1906F34 VA: 0x190AF34
	private int RunSchedulerLoop() { }

	// RVA: 0x190B618 Offset: 0x1907618 VA: 0x190B618
	private static void .cctor() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class Timer : MarshalByRefObject, IDisposable // TypeDefIndex: 548
{
	// Fields
	private TimerCallback callback; // 0x18
	private object state; // 0x20
	private long due_time_ms; // 0x28
	private long period_ms; // 0x30
	private long next_run; // 0x38
	private bool disposed; // 0x40
	private bool is_dead; // 0x41
	private bool is_added; // 0x42

	// Properties
	private static Timer.Scheduler scheduler { get; }

	// Methods

	// RVA: 0x190A440 Offset: 0x1906440 VA: 0x190A440
	private static Timer.Scheduler get_scheduler() { }

	// RVA: 0x190A4C8 Offset: 0x19064C8 VA: 0x190A4C8
	public void .ctor(TimerCallback callback, object state, int dueTime, int period) { }

	// RVA: 0x190A5B8 Offset: 0x19065B8 VA: 0x190A5B8
	public void .ctor(TimerCallback callback, object state, TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x190A514 Offset: 0x1906514 VA: 0x190A514
	private void Init(TimerCallback callback, object state, long dueTime, long period) { }

	// RVA: 0x190A854 Offset: 0x1906854 VA: 0x190A854
	public bool Change(int dueTime, int period) { }

	// RVA: 0x190A874 Offset: 0x1906874 VA: 0x190A874
	public bool Change(TimeSpan dueTime, TimeSpan period) { }

	// RVA: 0x190A92C Offset: 0x190692C VA: 0x190A92C Slot: 6
	public void Dispose() { }

	// RVA: 0x190A68C Offset: 0x190668C VA: 0x190A68C
	private bool Change(long dueTime, long period, bool first) { }

	// RVA: 0x190ABD4 Offset: 0x1906BD4 VA: 0x190ABD4
	internal void KeepRootedWhileScheduled() { }

	// RVA: 0x190AA38 Offset: 0x1906A38 VA: 0x190AA38
	private static long GetTimeMonotonic() { }
}

// Namespace: System.Threading
[ComVisible(True)]
public sealed class TimerCallback : MulticastDelegate // TypeDefIndex: 549
{
	// Methods

	// RVA: 0x190B67C Offset: 0x190767C VA: 0x190B67C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x190B784 Offset: 0x1907784 VA: 0x190B784 Slot: 12
	public virtual void Invoke(object state) { }
}

// Namespace: 
private struct Volatile.VolatileBoolean // TypeDefIndex: 550
{
	// Fields
	public bool Value; // 0x0
}

// Namespace: 
private struct Volatile.VolatileInt32 // TypeDefIndex: 551
{
	// Fields
	public int Value; // 0x0
}

// Namespace: 
private struct Volatile.VolatileObject // TypeDefIndex: 552
{
	// Fields
	public object Value; // 0x0
}

// Namespace: System.Threading
public static class Volatile // TypeDefIndex: 553
{
	// Methods

	[Intrinsic]
	// RVA: 0x190B798 Offset: 0x1907798 VA: 0x190B798
	public static bool Read(ref bool location) { }

	[Intrinsic]
	// RVA: 0x190B7B0 Offset: 0x19077B0 VA: 0x190B7B0
	public static void Write(ref bool location, bool value) { }

	[Intrinsic]
	// RVA: 0x190B7D4 Offset: 0x19077D4 VA: 0x190B7D4
	public static int Read(ref int location) { }

	[Intrinsic]
	// RVA: 0x190B7EC Offset: 0x19077EC VA: 0x190B7EC
	public static void Write(ref int location, int value) { }

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static T Read<T>(ref T location) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103DB90 Offset: 0x1039B90 VA: 0x103DB90
	|-Volatile.Read<object>
	*/

	[Intrinsic]
	// RVA: -1 Offset: -1
	public static void Write<T>(ref T location, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103DBA8 Offset: 0x1039BA8 VA: 0x103DBA8
	|-Volatile.Write<object>
	*/
}

// Namespace: System.Threading
public enum LockRecursionPolicy // TypeDefIndex: 5973
{
	// Fields
	public int value__; // 0x0
	public const LockRecursionPolicy NoRecursion = 0;
	public const LockRecursionPolicy SupportsRecursion = 1;
}

// Namespace: System.Threading
internal class ReaderWriterCount // TypeDefIndex: 5974
{
	// Fields
	public long lockID; // 0x10
	public int readercount; // 0x18
	public int writercount; // 0x1C
	public int upgradecount; // 0x20
	public ReaderWriterCount next; // 0x28

	// Methods

	// RVA: 0x1A18B3C Offset: 0x1A14B3C VA: 0x1A18B3C
	public void .ctor() { }
}

// Namespace: 
private struct ReaderWriterLockSlim.TimeoutTracker // TypeDefIndex: 5975
{
	// Fields
	private int m_total; // 0x0
	private int m_start; // 0x4

	// Properties
	public int RemainingMilliseconds { get; }
	public bool IsExpired { get; }

	// Methods

	// RVA: 0x1A18D9C Offset: 0x1A14D9C VA: 0x1A18D9C
	public void .ctor(int millisecondsTimeout) { }

	// RVA: 0x1A19B9C Offset: 0x1A15B9C VA: 0x1A19B9C
	public int get_RemainingMilliseconds() { }

	// RVA: 0x1A19218 Offset: 0x1A15218 VA: 0x1A19218
	public bool get_IsExpired() { }
}

// Namespace: System.Threading
public class ReaderWriterLockSlim : IDisposable // TypeDefIndex: 5976
{
	// Fields
	private bool fIsReentrant; // 0x10
	private int myLock; // 0x14
	private uint numWriteWaiters; // 0x18
	private uint numReadWaiters; // 0x1C
	private uint numWriteUpgradeWaiters; // 0x20
	private uint numUpgradeWaiters; // 0x24
	private bool fNoWaiters; // 0x28
	private int upgradeLockOwnerId; // 0x2C
	private int writeLockOwnerId; // 0x30
	private EventWaitHandle writeEvent; // 0x38
	private EventWaitHandle readEvent; // 0x40
	private EventWaitHandle upgradeEvent; // 0x48
	private EventWaitHandle waitUpgradeEvent; // 0x50
	private static long s_nextLockID; // 0x0
	private long lockID; // 0x58
	[ThreadStatic]
	private static ReaderWriterCount t_rwc; // 0x80000000
	private bool fUpgradeThreadHoldingRead; // 0x60
	private uint owners; // 0x64
	private bool fDisposed; // 0x68

	// Properties
	public bool IsReadLockHeld { get; }
	public bool IsUpgradeableReadLockHeld { get; }
	public bool IsWriteLockHeld { get; }
	public int RecursiveReadCount { get; }
	public int RecursiveUpgradeCount { get; }
	public int RecursiveWriteCount { get; }
	public int WaitingReadCount { get; }
	public int WaitingUpgradeCount { get; }
	public int WaitingWriteCount { get; }

	// Methods

	// RVA: 0x1A18B44 Offset: 0x1A14B44 VA: 0x1A18B44
	private void InitializeThreadCounts() { }

	// RVA: 0x1A18B50 Offset: 0x1A14B50 VA: 0x1A18B50
	public void .ctor() { }

	// RVA: 0x1A18B58 Offset: 0x1A14B58 VA: 0x1A18B58
	public void .ctor(LockRecursionPolicy recursionPolicy) { }

	// RVA: 0x1A18BDC Offset: 0x1A14BDC VA: 0x1A18BDC
	private static bool IsRWEntryEmpty(ReaderWriterCount rwc) { }

	// RVA: 0x1A18C18 Offset: 0x1A14C18 VA: 0x1A18C18
	private bool IsRwHashEntryChanged(ReaderWriterCount lrwc) { }

	// RVA: 0x1A18C38 Offset: 0x1A14C38 VA: 0x1A18C38
	private ReaderWriterCount GetThreadRWCount(bool dontAllocate) { }

	// RVA: 0x1A18D68 Offset: 0x1A14D68 VA: 0x1A18D68
	public void EnterWriteLock() { }

	// RVA: 0x1A18D70 Offset: 0x1A14D70 VA: 0x1A18D70
	public bool TryEnterWriteLock(int millisecondsTimeout) { }

	// RVA: 0x1A18E20 Offset: 0x1A14E20 VA: 0x1A18E20
	private bool TryEnterWriteLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x1A18E24 Offset: 0x1A14E24 VA: 0x1A18E24
	private bool TryEnterWriteLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x1A194EC Offset: 0x1A154EC VA: 0x1A194EC
	public void EnterUpgradeableReadLock() { }

	// RVA: 0x1A194F4 Offset: 0x1A154F4 VA: 0x1A194F4
	public bool TryEnterUpgradeableReadLock(int millisecondsTimeout) { }

	// RVA: 0x1A19520 Offset: 0x1A15520 VA: 0x1A19520
	private bool TryEnterUpgradeableReadLock(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x1A19524 Offset: 0x1A15524 VA: 0x1A19524
	private bool TryEnterUpgradeableReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout) { }

	// RVA: 0x1A19888 Offset: 0x1A15888 VA: 0x1A19888
	public void ExitWriteLock() { }

	// RVA: 0x1A199F8 Offset: 0x1A159F8 VA: 0x1A199F8
	public void ExitUpgradeableReadLock() { }

	// RVA: 0x1A192C8 Offset: 0x1A152C8 VA: 0x1A192C8
	private void LazyCreateEvent(ref EventWaitHandle waitEvent, bool makeAutoResetEvent) { }

	// RVA: 0x1A193C8 Offset: 0x1A153C8 VA: 0x1A193C8
	private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, ReaderWriterLockSlim.TimeoutTracker timeout, bool isWriteWaiter) { }

	// RVA: 0x1A199CC Offset: 0x1A159CC VA: 0x1A199CC
	private void ExitAndWakeUpAppropriateWaiters() { }

	// RVA: 0x1A19BE4 Offset: 0x1A15BE4 VA: 0x1A19BE4
	private void ExitAndWakeUpAppropriateWaitersPreferringWriters() { }

	// RVA: 0x1A19C68 Offset: 0x1A15C68 VA: 0x1A19C68
	private void ExitAndWakeUpAppropriateReadWaiters() { }

	// RVA: 0x1A191EC Offset: 0x1A151EC VA: 0x1A191EC
	private bool IsWriterAcquired() { }

	// RVA: 0x1A191FC Offset: 0x1A151FC VA: 0x1A191FC
	private void SetWriterAcquired() { }

	// RVA: 0x1A199BC Offset: 0x1A159BC VA: 0x1A199BC
	private void ClearWriterAcquired() { }

	// RVA: 0x1A19B7C Offset: 0x1A15B7C VA: 0x1A19B7C
	private void SetWritersWaiting() { }

	// RVA: 0x1A19CFC Offset: 0x1A15CFC VA: 0x1A19CFC
	private void ClearWritersWaiting() { }

	// RVA: 0x1A19B8C Offset: 0x1A15B8C VA: 0x1A19B8C
	private void SetUpgraderWaiting() { }

	// RVA: 0x1A19D0C Offset: 0x1A15D0C VA: 0x1A19D0C
	private void ClearUpgraderWaiting() { }

	// RVA: 0x1A1920C Offset: 0x1A1520C VA: 0x1A1920C
	private uint GetNumReaders() { }

	// RVA: 0x1A19D1C Offset: 0x1A15D1C VA: 0x1A19D1C
	private void EnterMyLock() { }

	// RVA: 0x1A19D50 Offset: 0x1A15D50 VA: 0x1A19D50
	private void EnterMyLockSpin() { }

	// RVA: 0x1A191D4 Offset: 0x1A151D4 VA: 0x1A191D4
	private void ExitMyLock() { }

	// RVA: 0x1A19230 Offset: 0x1A15230 VA: 0x1A19230
	private static void SpinWait(int SpinCount) { }

	// RVA: 0x1A19E24 Offset: 0x1A15E24 VA: 0x1A19E24 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A19E2C Offset: 0x1A15E2C VA: 0x1A19E2C
	private void Dispose(bool disposing) { }

	// RVA: 0x1A19F9C Offset: 0x1A15F9C VA: 0x1A19F9C
	public bool get_IsReadLockHeld() { }

	// RVA: 0x1A19FB4 Offset: 0x1A15FB4 VA: 0x1A19FB4
	public bool get_IsUpgradeableReadLockHeld() { }

	// RVA: 0x1A19FCC Offset: 0x1A15FCC VA: 0x1A19FCC
	public bool get_IsWriteLockHeld() { }

	// RVA: 0x1A19FE4 Offset: 0x1A15FE4 VA: 0x1A19FE4
	public int get_RecursiveReadCount() { }

	// RVA: 0x1A1A064 Offset: 0x1A16064 VA: 0x1A1A064
	public int get_RecursiveUpgradeCount() { }

	// RVA: 0x1A1A114 Offset: 0x1A16114 VA: 0x1A1A114
	public int get_RecursiveWriteCount() { }

	// RVA: 0x1A1A1C4 Offset: 0x1A161C4 VA: 0x1A1A1C4
	public int get_WaitingReadCount() { }

	// RVA: 0x1A1A1CC Offset: 0x1A161CC VA: 0x1A1A1CC
	public int get_WaitingUpgradeCount() { }

	// RVA: 0x1A1A1D4 Offset: 0x1A161D4 VA: 0x1A1A1D4
	public int get_WaitingWriteCount() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 // TypeDefIndex: 5977
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 5978
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 // TypeDefIndex: 5979
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 5980
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 0270BFF41CB170C33C20788C368CB1B5A66B0FD0B98D638A827B783537583821 /*Metadata offset 0x3E94B0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 09FDC69AA887AC8D36E0C8284C7B1D53E580E4880B72A67FF80D7E38317115D9 /*Metadata offset 0x3E98B8*/; // 0x400
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 0F4764044BF2E91EFEFAF3D4F1E81C10A2B7F0F45305489925CFC01198CF45B5 /*Metadata offset 0x3E9CC0*/; // 0x800
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 15A0E7628178B3FE6546E9B60F35E2B1C4864E020B16376866F38F72C74B45A9 /*Metadata offset 0x3EA0C8*/; // 0xC00
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 4CF8DC711CD3210D673D86981355E2609233025ED22E4DC7A1F9B8E75ADE35F4 /*Metadata offset 0x3EA4D0*/; // 0x1000
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 783FB0A44BE7670EB6EC170CF7F16BB2B6F23F4964B87B60C4EB506C7C6A286D /*Metadata offset 0x3EA8D8*/; // 0x1400
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 914FCE8DC82DA59038745B264F743222527FBAE2E4A28E71C89760B7E3DBBA67 /*Metadata offset 0x3EACE0*/; // 0x1800
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 93631B0726F6FE6629DAA743EE51B49F4477ED07391B68EEEA0672A4A90018AA /*Metadata offset 0x3EAD60*/; // 0x1878
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 C2D8E5EED6CBEBD8625FC18F81486A7733C04F9B0129FFBE974C68B90308B4F2 /*Metadata offset 0x3EAE68*/; // 0x1978
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 C40A9A77EE05E10AF16DA9D1781A2053159EA8570ADA03637BB5FE3D076C9F89 /*Metadata offset 0x3EAF70*/; // 0x1A78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 E8058399671D13082C35B6B3CE7F9E282507EDD458CCFDD3BAD9F35D90016F62 /*Metadata offset 0x3EB378*/; // 0x1E78
}

// Namespace: 
internal class <Module> // TypeDefIndex: 5981
{}
