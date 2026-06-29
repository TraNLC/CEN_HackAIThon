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

// Namespace: System.Threading.Tasks
[Serializable]
public class TaskCanceledException : OperationCanceledException // TypeDefIndex: 554
{
	// Fields
	private readonly Task _canceledTask; // 0x98

	// Methods

	// RVA: 0x190B810 Offset: 0x1907810 VA: 0x190B810
	public void .ctor() { }

	// RVA: 0x190B85C Offset: 0x190785C VA: 0x190B85C
	public void .ctor(Task task) { }

	// RVA: 0x190B908 Offset: 0x1907908 VA: 0x190B908
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Threading.Tasks
public class TaskCompletionSource<TResult> // TypeDefIndex: 555
{
	// Fields
	private readonly Task<TResult> _task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146DA50 Offset: 0x1469A50 VA: 0x146DA50
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x146DC98 Offset: 0x1469C98 VA: 0x146DC98
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x146DEDC Offset: 0x1469EDC VA: 0x146DEDC
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x146E120 Offset: 0x146A120 VA: 0x146E120
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146DAB4 Offset: 0x1469AB4 VA: 0x146DAB4
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x146DCFC Offset: 0x1469CFC VA: 0x146DCFC
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x146DF40 Offset: 0x1469F40 VA: 0x146DF40
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x146E188 Offset: 0x146A188 VA: 0x146E188
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146DACC Offset: 0x1469ACC VA: 0x146DACC
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x146DD14 Offset: 0x1469D14 VA: 0x146DD14
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x146DF58 Offset: 0x1469F58 VA: 0x146DF58
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x146E1A8 Offset: 0x146A1A8 VA: 0x146E1A8
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146DAE0 Offset: 0x1469AE0 VA: 0x146DAE0
	|-TaskCompletionSource<bool>..ctor
	|
	|-RVA: 0x146DD28 Offset: 0x1469D28 VA: 0x146DD28
	|-TaskCompletionSource<int>..ctor
	|
	|-RVA: 0x146DF6C Offset: 0x1469F6C VA: 0x146DF6C
	|-TaskCompletionSource<object>..ctor
	|
	|-RVA: 0x146E1C0 Offset: 0x146A1C0 VA: 0x146E1C0
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146DB5C Offset: 0x1469B5C VA: 0x146DB5C
	|-TaskCompletionSource<bool>.get_Task
	|
	|-RVA: 0x146DDA4 Offset: 0x1469DA4 VA: 0x146DDA4
	|-TaskCompletionSource<int>.get_Task
	|
	|-RVA: 0x146DFE8 Offset: 0x1469FE8 VA: 0x146DFE8
	|-TaskCompletionSource<object>.get_Task
	|
	|-RVA: 0x146E240 Offset: 0x146A240 VA: 0x146E240
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	private void SpinUntilCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146DB64 Offset: 0x1469B64 VA: 0x146DB64
	|-TaskCompletionSource<bool>.SpinUntilCompleted
	|
	|-RVA: 0x146DDAC Offset: 0x1469DAC VA: 0x146DDAC
	|-TaskCompletionSource<int>.SpinUntilCompleted
	|
	|-RVA: 0x146DFF0 Offset: 0x1469FF0 VA: 0x146DFF0
	|-TaskCompletionSource<object>.SpinUntilCompleted
	|
	|-RVA: 0x146E248 Offset: 0x146A248 VA: 0x146E248
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.SpinUntilCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146DBE4 Offset: 0x1469BE4 VA: 0x146DBE4
	|-TaskCompletionSource<bool>.TrySetException
	|
	|-RVA: 0x146DE2C Offset: 0x1469E2C VA: 0x146DE2C
	|-TaskCompletionSource<int>.TrySetException
	|
	|-RVA: 0x146E070 Offset: 0x146A070 VA: 0x146E070
	|-TaskCompletionSource<object>.TrySetException
	|
	|-RVA: 0x146E2C8 Offset: 0x146A2C8 VA: 0x146E2C8
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetException
	*/

	// RVA: -1 Offset: -1
	public bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146DC4C Offset: 0x1469C4C VA: 0x146DC4C
	|-TaskCompletionSource<bool>.TrySetResult
	|
	|-RVA: 0x146DE94 Offset: 0x1469E94 VA: 0x146DE94
	|-TaskCompletionSource<int>.TrySetResult
	|
	|-RVA: 0x146E0D8 Offset: 0x146A0D8 VA: 0x146E0D8
	|-TaskCompletionSource<object>.TrySetResult
	|
	|-RVA: 0x146E344 Offset: 0x146A344 VA: 0x146E344
	|-TaskCompletionSource<__Il2CppFullySharedGenericType>.TrySetResult
	*/
}

// Namespace: System.Threading.Tasks
[Serializable]
public class TaskSchedulerException : Exception // TypeDefIndex: 556
{
	// Methods

	// RVA: 0x190B910 Offset: 0x1907910 VA: 0x190B910
	public void .ctor() { }

	// RVA: 0x190B980 Offset: 0x1907980 VA: 0x190B980
	public void .ctor(Exception innerException) { }

	// RVA: 0x190BA00 Offset: 0x1907A00 VA: 0x190BA00
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: 
private sealed class TaskToApm.TaskWrapperAsyncResult : IAsyncResult // TypeDefIndex: 557
{
	// Fields
	internal readonly Task Task; // 0x10
	private readonly object _state; // 0x18
	private readonly bool _completedSynchronously; // 0x20

	// Properties
	private object System.IAsyncResult.AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	private bool System.IAsyncResult.IsCompleted { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }

	// Methods

	// RVA: 0x190BBCC Offset: 0x1907BCC VA: 0x190BBCC
	internal void .ctor(Task task, object state, bool completedSynchronously) { }

	// RVA: 0x190BE84 Offset: 0x1907E84 VA: 0x190BE84 Slot: 6
	private object System.IAsyncResult.get_AsyncState() { }

	// RVA: 0x190BE8C Offset: 0x1907E8C VA: 0x190BE8C Slot: 7
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x190BE94 Offset: 0x1907E94 VA: 0x190BE94 Slot: 4
	private bool System.IAsyncResult.get_IsCompleted() { }

	// RVA: 0x190BEA8 Offset: 0x1907EA8 VA: 0x190BEA8 Slot: 5
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TaskToApm.<>c__DisplayClass3_0 // TypeDefIndex: 558
{
	// Fields
	public AsyncCallback callback; // 0x10
	public IAsyncResult asyncResult; // 0x18

	// Methods

	// RVA: 0x190BE4C Offset: 0x1907E4C VA: 0x190BE4C
	public void .ctor() { }

	// RVA: 0x190BF4C Offset: 0x1907F4C VA: 0x190BF4C
	internal void <InvokeCallbackWhenTaskCompletes>b__0() { }
}

// Namespace: System.Threading.Tasks
internal static class TaskToApm // TypeDefIndex: 559
{
	// Methods

	// RVA: 0x190BA80 Offset: 0x1907A80 VA: 0x190BA80
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	// RVA: 0x190BD34 Offset: 0x1907D34 VA: 0x190BD34
	public static void End(IAsyncResult asyncResult) { }

	// RVA: -1 Offset: -1
	public static TResult End<TResult>(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10382AC Offset: 0x10342AC VA: 0x10382AC
	|-TaskToApm.End<int>
	|
	|-RVA: 0x10383AC Offset: 0x10343AC VA: 0x10383AC
	|-TaskToApm.End<object>
	|
	|-RVA: 0x10384AC Offset: 0x10344AC VA: 0x10384AC
	|-TaskToApm.End<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x190BC24 Offset: 0x1907C24 VA: 0x190BC24
	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ValueTask.ValueTaskSourceAsTask.<>c // TypeDefIndex: 560
{
	// Fields
	public static readonly ValueTask.ValueTaskSourceAsTask.<>c <>9; // 0x0

	// Methods

	// RVA: 0x190CAFC Offset: 0x1908AFC VA: 0x190CAFC
	private static void .cctor() { }

	// RVA: 0x190CB64 Offset: 0x1908B64 VA: 0x190CB64
	public void .ctor() { }

	// RVA: 0x190CB6C Offset: 0x1908B6C VA: 0x190CB6C
	internal void <.cctor>b__4_0(object state) { }
}

// Namespace: 
private sealed class ValueTask.ValueTaskSourceAsTask : Task<VoidTaskResult> // TypeDefIndex: 561
{
	// Fields
	private static readonly Action<object> s_completionAction; // 0x0
	private IValueTaskSource _source; // 0x58
	private readonly short _token; // 0x60

	// Methods

	// RVA: 0x190C5DC Offset: 0x19085DC VA: 0x190C5DC
	public void .ctor(IValueTaskSource source, short token) { }

	// RVA: 0x190CA2C Offset: 0x1908A2C VA: 0x190CA2C
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
[IsReadOnly]
[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder))]
public struct ValueTask : IEquatable<ValueTask> // TypeDefIndex: 562
{
	// Fields
	private static readonly Task s_canceledTask; // 0x0
	internal readonly object _obj; // 0x0
	internal readonly short _token; // 0x8
	internal readonly bool _continueOnCapturedContext; // 0xA

	// Properties
	internal static Task CompletedTask { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x190BF70 Offset: 0x1907F70 VA: 0x190BF70
	internal static Task get_CompletedTask() { }

	// RVA: 0x190BFF8 Offset: 0x1907FF8 VA: 0x190BFF8
	public void .ctor(Task task) { }

	// RVA: 0x190C03C Offset: 0x190803C VA: 0x190C03C
	public void .ctor(IValueTaskSource source, short token) { }

	// RVA: 0x190C084 Offset: 0x1908084 VA: 0x190C084 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x190C09C Offset: 0x190809C VA: 0x190C09C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x190C154 Offset: 0x1908154 VA: 0x190C154 Slot: 4
	public bool Equals(ValueTask other) { }

	// RVA: 0x190C178 Offset: 0x1908178 VA: 0x190C178
	public Task AsTask() { }

	// RVA: 0x190C244 Offset: 0x1908244 VA: 0x190C244
	private Task GetTaskForValueTaskSource(IValueTaskSource t) { }

	// RVA: 0x190C708 Offset: 0x1908708 VA: 0x190C708
	public bool get_IsCompleted() { }

	[StackTraceHidden]
	// RVA: 0x190C80C Offset: 0x190880C VA: 0x190C80C
	internal void ThrowIfCompletedUnsuccessfully() { }

	// RVA: 0x190C910 Offset: 0x1908910 VA: 0x190C910
	public ValueTaskAwaiter GetAwaiter() { }

	// RVA: 0x190C940 Offset: 0x1908940 VA: 0x190C940
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ValueTask.ValueTaskSourceAsTask.<>c<TResult> // TypeDefIndex: 563
{
	// Fields
	public static readonly ValueTask.ValueTaskSourceAsTask.<>c<TResult> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115034C Offset: 0x114C34C VA: 0x115034C
	|-ValueTask.ValueTaskSourceAsTask.<>c<int>..cctor
	|
	|-RVA: 0x1151C80 Offset: 0x114DC80 VA: 0x1151C80
	|-ValueTask.ValueTaskSourceAsTask.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150424 Offset: 0x114C424 VA: 0x1150424
	|-ValueTask.ValueTaskSourceAsTask.<>c<int>..ctor
	|
	|-RVA: 0x1151D8C Offset: 0x114DD8C VA: 0x1151D8C
	|-ValueTask.ValueTaskSourceAsTask.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.cctor>b__4_0(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115042C Offset: 0x114C42C VA: 0x115042C
	|-ValueTask.ValueTaskSourceAsTask.<>c<int>.<.cctor>b__4_0
	|
	|-RVA: 0x1151D94 Offset: 0x114DD94 VA: 0x1151D94
	|-ValueTask.ValueTaskSourceAsTask.<>c<__Il2CppFullySharedGenericType>.<.cctor>b__4_0
	*/
}

// Namespace: 
private sealed class ValueTask.ValueTaskSourceAsTask<TResult> : Task<TResult> // TypeDefIndex: 564
{
	// Fields
	private static readonly Action<object> s_completionAction; // 0x0
	private IValueTaskSource<TResult> _source; // 0x0
	private readonly short _token; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IValueTaskSource<TResult> source, short token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AE4F8 Offset: 0x14AA4F8 VA: 0x14AE4F8
	|-ValueTask.ValueTaskSourceAsTask<int>..ctor
	|
	|-RVA: 0x14AE77C Offset: 0x14AA77C VA: 0x14AE77C
	|-ValueTask.ValueTaskSourceAsTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AE628 Offset: 0x14AA628 VA: 0x14AE628
	|-ValueTask.ValueTaskSourceAsTask<int>..cctor
	|
	|-RVA: 0x14AE8D8 Offset: 0x14AA8D8 VA: 0x14AE8D8
	|-ValueTask.ValueTaskSourceAsTask<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Threading.Tasks
[IsReadOnly]
[AsyncMethodBuilder(typeof(AsyncValueTaskMethodBuilder<TResult>))]
public struct ValueTask<TResult> : IEquatable<ValueTask<TResult>> // TypeDefIndex: 565
{
	// Fields
	private static Task<TResult> s_canceledTask; // 0x0
	internal readonly object _obj; // 0x0
	internal readonly TResult _result; // 0x0
	internal readonly short _token; // 0x0
	internal readonly bool _continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }
	public TResult Result { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AEA2C Offset: 0x14AAA2C VA: 0x14AEA2C
	|-ValueTask<int>..ctor
	|
	|-RVA: 0x14AF71C Offset: 0x14AB71C VA: 0x14AF71C
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AEA58 Offset: 0x14AAA58 VA: 0x14AEA58
	|-ValueTask<int>..ctor
	|
	|-RVA: 0x14AF8D4 Offset: 0x14AB8D4 VA: 0x14AF8D4
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IValueTaskSource<TResult> source, short token) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AEAA0 Offset: 0x14AAAA0 VA: 0x14AEAA0
	|-ValueTask<int>..ctor
	|
	|-RVA: 0x14AF9F8 Offset: 0x14AB9F8 VA: 0x14AF9F8
	|-ValueTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AEAEC Offset: 0x14AAAEC VA: 0x14AEAEC
	|-ValueTask<int>.GetHashCode
	|
	|-RVA: 0x14AFB20 Offset: 0x14ABB20 VA: 0x14AFB20
	|-ValueTask<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AEB40 Offset: 0x14AAB40 VA: 0x14AEB40
	|-ValueTask<int>.Equals
	|
	|-RVA: 0x14AFDFC Offset: 0x14ABDFC VA: 0x14AFDFC
	|-ValueTask<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ValueTask<TResult> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AEC38 Offset: 0x14AAC38 VA: 0x14AEC38
	|-ValueTask<int>.Equals
	|
	|-RVA: 0x14AFF54 Offset: 0x14ABF54 VA: 0x14AFF54
	|-ValueTask<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> AsTask() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AECC4 Offset: 0x14AACC4 VA: 0x14AECC4
	|-ValueTask<int>.AsTask
	|
	|-RVA: 0x14B0344 Offset: 0x14AC344 VA: 0x14B0344
	|-ValueTask<__Il2CppFullySharedGenericType>.AsTask
	*/

	// RVA: -1 Offset: -1
	private Task<TResult> GetTaskForValueTaskSource(IValueTaskSource<TResult> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AEDD8 Offset: 0x14AADD8 VA: 0x14AEDD8
	|-ValueTask<int>.GetTaskForValueTaskSource
	|
	|-RVA: 0x14B060C Offset: 0x14AC60C VA: 0x14B060C
	|-ValueTask<__Il2CppFullySharedGenericType>.GetTaskForValueTaskSource
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AF288 Offset: 0x14AB288 VA: 0x14AF288
	|-ValueTask<int>.get_IsCompleted
	|
	|-RVA: 0x14B0D54 Offset: 0x14ACD54 VA: 0x14B0D54
	|-ValueTask<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompletedSuccessfully() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AF3B4 Offset: 0x14AB3B4 VA: 0x14AF3B4
	|-ValueTask<int>.get_IsCompletedSuccessfully
	|
	|-RVA: 0x14B0EE4 Offset: 0x14ACEE4 VA: 0x14B0EE4
	|-ValueTask<__Il2CppFullySharedGenericType>.get_IsCompletedSuccessfully
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AF4E0 Offset: 0x14AB4E0 VA: 0x14AF4E0
	|-ValueTask<int>.get_Result
	|
	|-RVA: 0x14B1074 Offset: 0x14AD074 VA: 0x14B1074
	|-ValueTask<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1
	public ValueTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AF620 Offset: 0x14AB620 VA: 0x14AF620
	|-ValueTask<int>.GetAwaiter
	|
	|-RVA: 0x14B1380 Offset: 0x14AD380 VA: 0x14B1380
	|-ValueTask<__Il2CppFullySharedGenericType>.GetAwaiter
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AF66C Offset: 0x14AB66C VA: 0x14AF66C
	|-ValueTask<int>.ToString
	|
	|-RVA: 0x14B14C4 Offset: 0x14AD4C4 VA: 0x14B14C4
	|-ValueTask<__Il2CppFullySharedGenericType>.ToString
	*/
}

// Namespace: System.Threading.Tasks
[Extension]
internal static class TaskAwaiters // TypeDefIndex: 566
{
	// Methods

	[Extension]
	// RVA: 0x190CE90 Offset: 0x1908E90 VA: 0x190CE90
	public static ForceAsyncAwaiter ForceAsync(Task task) { }
}

// Namespace: System.Threading.Tasks
[IsReadOnly]
internal struct ForceAsyncAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 567
{
	// Fields
	private readonly Task _task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x190CEAC Offset: 0x1908EAC VA: 0x190CEAC
	internal void .ctor(Task task) { }

	// RVA: 0x190CEB4 Offset: 0x1908EB4 VA: 0x190CEB4
	public ForceAsyncAwaiter GetAwaiter() { }

	// RVA: 0x190CEBC Offset: 0x1908EBC VA: 0x190CEBC
	public bool get_IsCompleted() { }

	// RVA: 0x190CEC4 Offset: 0x1908EC4 VA: 0x190CEC4
	public void GetResult() { }

	// RVA: 0x190CF04 Offset: 0x1908F04 VA: 0x190CF04 Slot: 4
	public void UnsafeOnCompleted(Action action) { }
}

// Namespace: System.Threading.Tasks
[Extension]
internal static class DebuggerSupport // TypeDefIndex: 568
{
	// Fields
	private static readonly LowLevelDictionary<int, Task> s_activeTasks; // 0x0
	private static readonly object s_activeTasksLock; // 0x8

	// Properties
	public static bool LoggingOn { get; }

	// Methods

	// RVA: 0x190CF58 Offset: 0x1908F58 VA: 0x190CF58
	public static bool get_LoggingOn() { }

	// RVA: 0x190CF60 Offset: 0x1908F60 VA: 0x190CF60
	public static void TraceOperationCreation(CausalityTraceLevel traceLevel, Task task, string operationName, ulong relatedContext) { }

	// RVA: 0x190CF64 Offset: 0x1908F64 VA: 0x190CF64
	public static void TraceOperationCompletion(CausalityTraceLevel traceLevel, Task task, AsyncStatus status) { }

	// RVA: 0x190CF68 Offset: 0x1908F68 VA: 0x190CF68
	public static void TraceOperationRelation(CausalityTraceLevel traceLevel, Task task, CausalityRelation relation) { }

	// RVA: 0x190CF6C Offset: 0x1908F6C VA: 0x190CF6C
	public static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, Task task, CausalitySynchronousWork work) { }

	// RVA: 0x190CF70 Offset: 0x1908F70 VA: 0x190CF70
	public static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }

	// RVA: 0x190CF74 Offset: 0x1908F74 VA: 0x190CF74
	public static void AddToActiveTasks(Task task) { }

	// RVA: 0x190D008 Offset: 0x1909008 VA: 0x190D008
	private static void AddToActiveTasksNonInlined(Task task) { }

	// RVA: 0x190D1F8 Offset: 0x19091F8 VA: 0x190D1F8
	public static void RemoveFromActiveTasks(Task task) { }

	// RVA: 0x190D28C Offset: 0x190928C VA: 0x190D28C
	private static void RemoveFromActiveTasksNonInlined(Task task) { }

	// RVA: 0x190D3EC Offset: 0x19093EC VA: 0x190D3EC
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}, Result = {DebuggerDisplayResultDescription}")]
[DebuggerTypeProxy(typeof(SystemThreadingTasks_FutureDebugView<TResult>))]
public class Task<TResult> : Task // TypeDefIndex: 569
{
	// Fields
	internal TResult m_result; // 0x0
	private static TaskFactory<TResult> s_defaultFactory; // 0x0

	// Properties
	[DebuggerBrowsable(0)]
	public TResult Result { get; }
	internal TResult ResultOnSuccess { get; }
	public static TaskFactory<TResult> Factory { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473530 Offset: 0x146F530 VA: 0x1473530
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x14740E8 Offset: 0x14700E8 VA: 0x14740E8
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1474D1C Offset: 0x1470D1C VA: 0x1474D1C
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x14759BC Offset: 0x14719BC VA: 0x14759BC
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x1476610 Offset: 0x1472610 VA: 0x1476610
	|-Task<bool>..ctor
	|
	|-RVA: 0x14771E0 Offset: 0x14731E0 VA: 0x14771E0
	|-Task<int>..ctor
	|
	|-RVA: 0x1477D98 Offset: 0x1473D98 VA: 0x1477D98
	|-Task<object>..ctor
	|
	|-RVA: 0x147899C Offset: 0x147499C VA: 0x147899C
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x147955C Offset: 0x147555C VA: 0x147955C
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(object state, TaskCreationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473588 Offset: 0x146F588 VA: 0x1473588
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1474140 Offset: 0x1470140 VA: 0x1474140
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1474D74 Offset: 0x1470D74 VA: 0x1474D74
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x1475A14 Offset: 0x1471A14 VA: 0x1475A14
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x1476668 Offset: 0x1472668 VA: 0x1476668
	|-Task<bool>..ctor
	|
	|-RVA: 0x1477238 Offset: 0x1473238 VA: 0x1477238
	|-Task<int>..ctor
	|
	|-RVA: 0x1477DF0 Offset: 0x1473DF0 VA: 0x1477DF0
	|-Task<object>..ctor
	|
	|-RVA: 0x14789F4 Offset: 0x14749F4 VA: 0x14789F4
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x14795B4 Offset: 0x14755B4 VA: 0x14795B4
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14735FC Offset: 0x146F5FC VA: 0x14735FC
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x14741B4 Offset: 0x14701B4 VA: 0x14741B4
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1474DE8 Offset: 0x1470DE8 VA: 0x1474DE8
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x1475A88 Offset: 0x1471A88 VA: 0x1475A88
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x14766DC Offset: 0x14726DC VA: 0x14766DC
	|-Task<bool>..ctor
	|
	|-RVA: 0x14772AC Offset: 0x14732AC VA: 0x14772AC
	|-Task<int>..ctor
	|
	|-RVA: 0x1477E64 Offset: 0x1473E64 VA: 0x1477E64
	|-Task<object>..ctor
	|
	|-RVA: 0x1478A68 Offset: 0x1474A68 VA: 0x1478A68
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x1479628 Offset: 0x1475628 VA: 0x1479628
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473674 Offset: 0x146F674 VA: 0x1473674
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x147423C Offset: 0x147023C VA: 0x147423C
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1474E74 Offset: 0x1470E74 VA: 0x1474E74
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x1475B0C Offset: 0x1471B0C VA: 0x1475B0C
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x1476758 Offset: 0x1472758 VA: 0x1476758
	|-Task<bool>..ctor
	|
	|-RVA: 0x1477324 Offset: 0x1473324 VA: 0x1477324
	|-Task<int>..ctor
	|
	|-RVA: 0x1477EE4 Offset: 0x1473EE4 VA: 0x1477EE4
	|-Task<object>..ctor
	|
	|-RVA: 0x1478AE0 Offset: 0x1474AE0 VA: 0x1478AE0
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x1479744 Offset: 0x1475744 VA: 0x1479744
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473704 Offset: 0x146F704 VA: 0x1473704
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x14742FC Offset: 0x14702FC VA: 0x14742FC
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1474F2C Offset: 0x1470F2C VA: 0x1474F2C
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x1475BBC Offset: 0x1471BBC VA: 0x1475BBC
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x14767EC Offset: 0x14727EC VA: 0x14767EC
	|-Task<bool>..ctor
	|
	|-RVA: 0x14773B4 Offset: 0x14733B4 VA: 0x14773B4
	|-Task<int>..ctor
	|
	|-RVA: 0x1477F90 Offset: 0x1473F90 VA: 0x1477F90
	|-Task<object>..ctor
	|
	|-RVA: 0x1478B70 Offset: 0x1474B70 VA: 0x1478B70
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x1479878 Offset: 0x1475878 VA: 0x1479878
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14737AC Offset: 0x146F7AC VA: 0x14737AC
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x14743A4 Offset: 0x14703A4 VA: 0x14743A4
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1474FD4 Offset: 0x1470FD4 VA: 0x1474FD4
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x1475C64 Offset: 0x1471C64 VA: 0x1475C64
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x1476894 Offset: 0x1472894 VA: 0x1476894
	|-Task<bool>..ctor
	|
	|-RVA: 0x147745C Offset: 0x147345C VA: 0x147745C
	|-Task<int>..ctor
	|
	|-RVA: 0x1478038 Offset: 0x1474038 VA: 0x1478038
	|-Task<object>..ctor
	|
	|-RVA: 0x1478C18 Offset: 0x1474C18 VA: 0x1478C18
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x1479940 Offset: 0x1475940 VA: 0x1479940
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Delegate valueSelector, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147385C Offset: 0x146F85C VA: 0x147385C
	|-Task<Nullable<int>>..ctor
	|
	|-RVA: 0x1474454 Offset: 0x1470454 VA: 0x1474454
	|-Task<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1475084 Offset: 0x1471084 VA: 0x1475084
	|-Task<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x1475D14 Offset: 0x1471D14 VA: 0x1475D14
	|-Task<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x1476944 Offset: 0x1472944 VA: 0x1476944
	|-Task<bool>..ctor
	|
	|-RVA: 0x147750C Offset: 0x147350C VA: 0x147750C
	|-Task<int>..ctor
	|
	|-RVA: 0x14780E8 Offset: 0x14740E8 VA: 0x14780E8
	|-Task<object>..ctor
	|
	|-RVA: 0x1478CC8 Offset: 0x1474CC8 VA: 0x1478CC8
	|-Task<VoidTaskResult>..ctor
	|
	|-RVA: 0x14799F0 Offset: 0x14759F0 VA: 0x14799F0
	|-Task<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147390C Offset: 0x146F90C VA: 0x147390C
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x1474504 Offset: 0x1470504 VA: 0x1474504
	|-Task<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0x1475134 Offset: 0x1471134 VA: 0x1475134
	|-Task<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0x1475DC4 Offset: 0x1471DC4 VA: 0x1475DC4
	|-Task<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0x14769F4 Offset: 0x14729F4 VA: 0x14769F4
	|-Task<bool>.StartNew
	|
	|-RVA: 0x14775BC Offset: 0x14735BC VA: 0x14775BC
	|-Task<int>.StartNew
	|
	|-RVA: 0x1478198 Offset: 0x1474198 VA: 0x1478198
	|-Task<object>.StartNew
	|
	|-RVA: 0x1478D78 Offset: 0x1474D78 VA: 0x1478D78
	|-Task<VoidTaskResult>.StartNew
	|
	|-RVA: 0x1479AA0 Offset: 0x1475AA0 VA: 0x1479AA0
	|-Task<__Il2CppFullySharedGenericType>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> StartNew(Task parent, Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473A38 Offset: 0x146FA38 VA: 0x1473A38
	|-Task<Nullable<int>>.StartNew
	|
	|-RVA: 0x1474630 Offset: 0x1470630 VA: 0x1474630
	|-Task<ValueTuple<bool, object>>.StartNew
	|
	|-RVA: 0x1475260 Offset: 0x1471260 VA: 0x1475260
	|-Task<ValueTuple<object, object, int>>.StartNew
	|
	|-RVA: 0x1475EF0 Offset: 0x1471EF0 VA: 0x1475EF0
	|-Task<ValueTuple<object, bool, bool, object, object>>.StartNew
	|
	|-RVA: 0x1476B20 Offset: 0x1472B20 VA: 0x1476B20
	|-Task<bool>.StartNew
	|
	|-RVA: 0x14776E8 Offset: 0x14736E8 VA: 0x14776E8
	|-Task<int>.StartNew
	|
	|-RVA: 0x14782C4 Offset: 0x14742C4 VA: 0x14782C4
	|-Task<object>.StartNew
	|
	|-RVA: 0x1478EA4 Offset: 0x1474EA4 VA: 0x1478EA4
	|-Task<VoidTaskResult>.StartNew
	|
	|-RVA: 0x1479C0C Offset: 0x1475C0C VA: 0x1479C0C
	|-Task<__Il2CppFullySharedGenericType>.StartNew
	*/

	// RVA: -1 Offset: -1
	internal bool TrySetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473B7C Offset: 0x146FB7C VA: 0x1473B7C
	|-Task<Nullable<int>>.TrySetResult
	|
	|-RVA: 0x1474774 Offset: 0x1470774 VA: 0x1474774
	|-Task<ValueTuple<bool, object>>.TrySetResult
	|
	|-RVA: 0x14753A4 Offset: 0x14713A4 VA: 0x14753A4
	|-Task<ValueTuple<object, object, int>>.TrySetResult
	|
	|-RVA: 0x1476034 Offset: 0x1472034 VA: 0x1476034
	|-Task<ValueTuple<object, bool, bool, object, object>>.TrySetResult
	|
	|-RVA: 0x1476C64 Offset: 0x1472C64 VA: 0x1476C64
	|-Task<bool>.TrySetResult
	|
	|-RVA: 0x147782C Offset: 0x147382C VA: 0x147782C
	|-Task<int>.TrySetResult
	|
	|-RVA: 0x1478408 Offset: 0x1474408 VA: 0x1478408
	|-Task<object>.TrySetResult
	|
	|-RVA: 0x1478FE8 Offset: 0x1474FE8 VA: 0x1478FE8
	|-Task<VoidTaskResult>.TrySetResult
	|
	|-RVA: 0x1479D8C Offset: 0x1475D8C VA: 0x1479D8C
	|-Task<__Il2CppFullySharedGenericType>.TrySetResult
	*/

	// RVA: -1 Offset: -1
	internal void DangerousSetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473C18 Offset: 0x146FC18 VA: 0x1473C18
	|-Task<Nullable<int>>.DangerousSetResult
	|
	|-RVA: 0x1474824 Offset: 0x1470824 VA: 0x1474824
	|-Task<ValueTuple<bool, object>>.DangerousSetResult
	|
	|-RVA: 0x1475458 Offset: 0x1471458 VA: 0x1475458
	|-Task<ValueTuple<object, object, int>>.DangerousSetResult
	|
	|-RVA: 0x14760E0 Offset: 0x14720E0 VA: 0x14760E0
	|-Task<ValueTuple<object, bool, bool, object, object>>.DangerousSetResult
	|
	|-RVA: 0x1476D04 Offset: 0x1472D04 VA: 0x1476D04
	|-Task<bool>.DangerousSetResult
	|
	|-RVA: 0x14778C8 Offset: 0x14738C8 VA: 0x14778C8
	|-Task<int>.DangerousSetResult
	|
	|-RVA: 0x14784B0 Offset: 0x14744B0 VA: 0x14784B0
	|-Task<object>.DangerousSetResult
	|
	|-RVA: 0x1479084 Offset: 0x1475084 VA: 0x1479084
	|-Task<VoidTaskResult>.DangerousSetResult
	|
	|-RVA: 0x1479EDC Offset: 0x1475EDC VA: 0x1479EDC
	|-Task<__Il2CppFullySharedGenericType>.DangerousSetResult
	*/

	// RVA: -1 Offset: -1
	public TResult get_Result() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473C60 Offset: 0x146FC60 VA: 0x1473C60
	|-Task<Nullable<int>>.get_Result
	|
	|-RVA: 0x147487C Offset: 0x147087C VA: 0x147487C
	|-Task<ValueTuple<bool, object>>.get_Result
	|
	|-RVA: 0x14754D0 Offset: 0x14714D0 VA: 0x14754D0
	|-Task<ValueTuple<object, object, int>>.get_Result
	|
	|-RVA: 0x1476148 Offset: 0x1472148 VA: 0x1476148
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_Result
	|
	|-RVA: 0x1476D54 Offset: 0x1472D54 VA: 0x1476D54
	|-Task<bool>.get_Result
	|
	|-RVA: 0x1477910 Offset: 0x1473910 VA: 0x1477910
	|-Task<int>.get_Result
	|
	|-RVA: 0x1478500 Offset: 0x1474500 VA: 0x1478500
	|-Task<object>.get_Result
	|
	|-RVA: 0x14790D0 Offset: 0x14750D0 VA: 0x14790D0
	|-Task<VoidTaskResult>.get_Result
	|
	|-RVA: 0x1479FDC Offset: 0x1475FDC VA: 0x1479FDC
	|-Task<__Il2CppFullySharedGenericType>.get_Result
	*/

	// RVA: -1 Offset: -1
	internal TResult get_ResultOnSuccess() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473CB4 Offset: 0x146FCB4 VA: 0x1473CB4
	|-Task<Nullable<int>>.get_ResultOnSuccess
	|
	|-RVA: 0x14748CC Offset: 0x14708CC VA: 0x14748CC
	|-Task<ValueTuple<bool, object>>.get_ResultOnSuccess
	|
	|-RVA: 0x1475544 Offset: 0x1471544 VA: 0x1475544
	|-Task<ValueTuple<object, object, int>>.get_ResultOnSuccess
	|
	|-RVA: 0x14761B0 Offset: 0x14721B0 VA: 0x14761B0
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_ResultOnSuccess
	|
	|-RVA: 0x1476DA8 Offset: 0x1472DA8 VA: 0x1476DA8
	|-Task<bool>.get_ResultOnSuccess
	|
	|-RVA: 0x1477964 Offset: 0x1473964 VA: 0x1477964
	|-Task<int>.get_ResultOnSuccess
	|
	|-RVA: 0x1478554 Offset: 0x1474554 VA: 0x1478554
	|-Task<object>.get_ResultOnSuccess
	|
	|-RVA: 0x1479124 Offset: 0x1475124 VA: 0x1479124
	|-Task<VoidTaskResult>.get_ResultOnSuccess
	|
	|-RVA: 0x147A138 Offset: 0x1476138 VA: 0x147A138
	|-Task<__Il2CppFullySharedGenericType>.get_ResultOnSuccess
	*/

	// RVA: -1 Offset: -1
	internal TResult GetResultCore(bool waitCompletionNotification) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473CBC Offset: 0x146FCBC VA: 0x1473CBC
	|-Task<Nullable<int>>.GetResultCore
	|
	|-RVA: 0x14748D8 Offset: 0x14708D8 VA: 0x14748D8
	|-Task<ValueTuple<bool, object>>.GetResultCore
	|
	|-RVA: 0x1475558 Offset: 0x1471558 VA: 0x1475558
	|-Task<ValueTuple<object, object, int>>.GetResultCore
	|
	|-RVA: 0x14761BC Offset: 0x14721BC VA: 0x14761BC
	|-Task<ValueTuple<object, bool, bool, object, object>>.GetResultCore
	|
	|-RVA: 0x1476DB0 Offset: 0x1472DB0 VA: 0x1476DB0
	|-Task<bool>.GetResultCore
	|
	|-RVA: 0x147796C Offset: 0x147396C VA: 0x147796C
	|-Task<int>.GetResultCore
	|
	|-RVA: 0x147855C Offset: 0x147455C VA: 0x147855C
	|-Task<object>.GetResultCore
	|
	|-RVA: 0x147912C Offset: 0x147512C VA: 0x147912C
	|-Task<VoidTaskResult>.GetResultCore
	|
	|-RVA: 0x147A174 Offset: 0x1476174 VA: 0x147A174
	|-Task<__Il2CppFullySharedGenericType>.GetResultCore
	*/

	// RVA: -1 Offset: -1
	public static TaskFactory<TResult> get_Factory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473D34 Offset: 0x146FD34 VA: 0x1473D34
	|-Task<Nullable<int>>.get_Factory
	|
	|-RVA: 0x1474950 Offset: 0x1470950 VA: 0x1474950
	|-Task<ValueTuple<bool, object>>.get_Factory
	|
	|-RVA: 0x14755E0 Offset: 0x14715E0 VA: 0x14755E0
	|-Task<ValueTuple<object, object, int>>.get_Factory
	|
	|-RVA: 0x147623C Offset: 0x147223C VA: 0x147623C
	|-Task<ValueTuple<object, bool, bool, object, object>>.get_Factory
	|
	|-RVA: 0x1476E28 Offset: 0x1472E28 VA: 0x1476E28
	|-Task<bool>.get_Factory
	|
	|-RVA: 0x14779E4 Offset: 0x14739E4 VA: 0x14779E4
	|-Task<int>.get_Factory
	|
	|-RVA: 0x14785D4 Offset: 0x14745D4 VA: 0x14785D4
	|-Task<object>.get_Factory
	|
	|-RVA: 0x14791A4 Offset: 0x14751A4 VA: 0x14791A4
	|-Task<VoidTaskResult>.get_Factory
	|
	|-RVA: 0x147A22C Offset: 0x147622C VA: 0x147A22C
	|-Task<__Il2CppFullySharedGenericType>.get_Factory
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473E54 Offset: 0x146FE54 VA: 0x1473E54
	|-Task<Nullable<int>>.InnerInvoke
	|
	|-RVA: 0x1474A70 Offset: 0x1470A70 VA: 0x1474A70
	|-Task<ValueTuple<bool, object>>.InnerInvoke
	|
	|-RVA: 0x1475700 Offset: 0x1471700 VA: 0x1475700
	|-Task<ValueTuple<object, object, int>>.InnerInvoke
	|
	|-RVA: 0x147635C Offset: 0x147235C VA: 0x147635C
	|-Task<ValueTuple<object, bool, bool, object, object>>.InnerInvoke
	|
	|-RVA: 0x1476F48 Offset: 0x1472F48 VA: 0x1476F48
	|-Task<bool>.InnerInvoke
	|
	|-RVA: 0x1477B04 Offset: 0x1473B04 VA: 0x1477B04
	|-Task<int>.InnerInvoke
	|
	|-RVA: 0x14786F4 Offset: 0x14746F4 VA: 0x14786F4
	|-Task<object>.InnerInvoke
	|
	|-RVA: 0x14792C8 Offset: 0x14752C8 VA: 0x14792C8
	|-Task<VoidTaskResult>.InnerInvoke
	|
	|-RVA: 0x147A378 Offset: 0x1476378 VA: 0x147A378
	|-Task<__Il2CppFullySharedGenericType>.InnerInvoke
	*/

	// RVA: -1 Offset: -1
	public TaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473F0C Offset: 0x146FF0C VA: 0x1473F0C
	|-Task<Nullable<int>>.GetAwaiter
	|
	|-RVA: 0x1474B40 Offset: 0x1470B40 VA: 0x1474B40
	|-Task<ValueTuple<bool, object>>.GetAwaiter
	|
	|-RVA: 0x14757E0 Offset: 0x14717E0 VA: 0x14757E0
	|-Task<ValueTuple<object, object, int>>.GetAwaiter
	|
	|-RVA: 0x1476434 Offset: 0x1472434 VA: 0x1476434
	|-Task<ValueTuple<object, bool, bool, object, object>>.GetAwaiter
	|
	|-RVA: 0x1477004 Offset: 0x1473004 VA: 0x1477004
	|-Task<bool>.GetAwaiter
	|
	|-RVA: 0x1477BBC Offset: 0x1473BBC VA: 0x1477BBC
	|-Task<int>.GetAwaiter
	|
	|-RVA: 0x14787C0 Offset: 0x14747C0 VA: 0x14787C0
	|-Task<object>.GetAwaiter
	|
	|-RVA: 0x1479380 Offset: 0x1475380 VA: 0x1479380
	|-Task<VoidTaskResult>.GetAwaiter
	|
	|-RVA: 0x147A4C0 Offset: 0x14764C0 VA: 0x147A4C0
	|-Task<__Il2CppFullySharedGenericType>.GetAwaiter
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473F28 Offset: 0x146FF28 VA: 0x1473F28
	|-Task<Nullable<int>>.ConfigureAwait
	|
	|-RVA: 0x1474B5C Offset: 0x1470B5C VA: 0x1474B5C
	|-Task<ValueTuple<bool, object>>.ConfigureAwait
	|
	|-RVA: 0x14757FC Offset: 0x14717FC VA: 0x14757FC
	|-Task<ValueTuple<object, object, int>>.ConfigureAwait
	|
	|-RVA: 0x1476450 Offset: 0x1472450 VA: 0x1476450
	|-Task<ValueTuple<object, bool, bool, object, object>>.ConfigureAwait
	|
	|-RVA: 0x1477020 Offset: 0x1473020 VA: 0x1477020
	|-Task<bool>.ConfigureAwait
	|
	|-RVA: 0x1477BD8 Offset: 0x1473BD8 VA: 0x1477BD8
	|-Task<int>.ConfigureAwait
	|
	|-RVA: 0x14787DC Offset: 0x14747DC VA: 0x14787DC
	|-Task<object>.ConfigureAwait
	|
	|-RVA: 0x147939C Offset: 0x147539C VA: 0x147939C
	|-Task<VoidTaskResult>.ConfigureAwait
	|
	|-RVA: 0x147A4DC Offset: 0x14764DC VA: 0x147A4DC
	|-Task<__Il2CppFullySharedGenericType>.ConfigureAwait
	*/

	// RVA: -1 Offset: -1
	public Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473F64 Offset: 0x146FF64 VA: 0x1473F64
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x1474B98 Offset: 0x1470B98 VA: 0x1474B98
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0x1475838 Offset: 0x1471838 VA: 0x1475838
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0x147648C Offset: 0x147248C VA: 0x147648C
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0x147705C Offset: 0x147305C VA: 0x147705C
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x1477C14 Offset: 0x1473C14 VA: 0x1477C14
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x1478818 Offset: 0x1474818 VA: 0x1478818
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x14793D8 Offset: 0x14753D8 VA: 0x14793D8
	|-Task<VoidTaskResult>.ContinueWith
	|
	|-RVA: 0x147A518 Offset: 0x1476518 VA: 0x147A518
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	internal Task ContinueWith(Action<Task<TResult>> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473F7C Offset: 0x146FF7C VA: 0x1473F7C
	|-Task<Nullable<int>>.ContinueWith
	|
	|-RVA: 0x1474BB0 Offset: 0x1470BB0 VA: 0x1474BB0
	|-Task<ValueTuple<bool, object>>.ContinueWith
	|
	|-RVA: 0x1475850 Offset: 0x1471850 VA: 0x1475850
	|-Task<ValueTuple<object, object, int>>.ContinueWith
	|
	|-RVA: 0x14764A4 Offset: 0x14724A4 VA: 0x14764A4
	|-Task<ValueTuple<object, bool, bool, object, object>>.ContinueWith
	|
	|-RVA: 0x1477074 Offset: 0x1473074 VA: 0x1477074
	|-Task<bool>.ContinueWith
	|
	|-RVA: 0x1477C2C Offset: 0x1473C2C VA: 0x1477C2C
	|-Task<int>.ContinueWith
	|
	|-RVA: 0x1478830 Offset: 0x1474830 VA: 0x1478830
	|-Task<object>.ContinueWith
	|
	|-RVA: 0x14793F0 Offset: 0x14753F0 VA: 0x14793F0
	|-Task<VoidTaskResult>.ContinueWith
	|
	|-RVA: 0x147A534 Offset: 0x1476534 VA: 0x147A534
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith
	*/

	// RVA: -1 Offset: -1
	public Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1009388 Offset: 0x1005388 VA: 0x1009388
	|-Task<int>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x100957C Offset: 0x100557C VA: 0x100957C
	|-Task<object>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x1009770 Offset: 0x1005770 VA: 0x1009770
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1009414 Offset: 0x1005414 VA: 0x1009414
	|-Task<int>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x1009608 Offset: 0x1005608 VA: 0x1009608
	|-Task<object>.ContinueWith<Nullable<int>>
	|
	|-RVA: 0x1009800 Offset: 0x1005800 VA: 0x1009800
	|-Task<__Il2CppFullySharedGenericType>.ContinueWith<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Threading.Tasks
internal class SystemThreadingTasks_FutureDebugView<TResult> // TypeDefIndex: 570
{}

// Namespace: 
private sealed class TaskFactory.FromAsyncTrimPromise<TResult, TInstance> : Task<TResult> // TypeDefIndex: 571
{
	// Fields
	internal static readonly AsyncCallback s_completeFromAsyncResult; // 0x0
	private TInstance m_thisRef; // 0x0
	private Func<TInstance, IAsyncResult, TResult> m_endMethod; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260B40 Offset: 0x125CB40 VA: 0x1260B40
	|-TaskFactory.FromAsyncTrimPromise<int, object>..ctor
	|
	|-RVA: 0x1261020 Offset: 0x125D020 VA: 0x1261020
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..ctor
	|
	|-RVA: 0x1261504 Offset: 0x125D504 VA: 0x1261504
	|-TaskFactory.FromAsyncTrimPromise<__Il2CppFullySharedGenericType, object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal static void CompleteFromAsyncResult(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260B8C Offset: 0x125CB8C VA: 0x1260B8C
	|-TaskFactory.FromAsyncTrimPromise<int, object>.CompleteFromAsyncResult
	|
	|-RVA: 0x126106C Offset: 0x125D06C VA: 0x126106C
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.CompleteFromAsyncResult
	|
	|-RVA: 0x1261580 Offset: 0x125D580 VA: 0x1261580
	|-TaskFactory.FromAsyncTrimPromise<__Il2CppFullySharedGenericType, object>.CompleteFromAsyncResult
	*/

	// RVA: -1 Offset: -1
	internal void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260DCC Offset: 0x125CDCC VA: 0x1260DCC
	|-TaskFactory.FromAsyncTrimPromise<int, object>.Complete
	|
	|-RVA: 0x12612AC Offset: 0x125D2AC VA: 0x12612AC
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>.Complete
	|
	|-RVA: 0x12618AC Offset: 0x125D8AC VA: 0x12618AC
	|-TaskFactory.FromAsyncTrimPromise<__Il2CppFullySharedGenericType, object>.Complete
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260F38 Offset: 0x125CF38 VA: 0x1260F38
	|-TaskFactory.FromAsyncTrimPromise<int, object>..cctor
	|
	|-RVA: 0x126141C Offset: 0x125D41C VA: 0x126141C
	|-TaskFactory.FromAsyncTrimPromise<VoidTaskResult, object>..cctor
	|
	|-RVA: 0x1261B30 Offset: 0x125DB30 VA: 0x1261B30
	|-TaskFactory.FromAsyncTrimPromise<__Il2CppFullySharedGenericType, object>..cctor
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TaskFactory.<>c__DisplayClass35_0<TResult> // TypeDefIndex: 572
{
	// Fields
	public Func<IAsyncResult, TResult> endFunction; // 0x0
	public Action<IAsyncResult> endAction; // 0x0
	public Task<TResult> promise; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11587B4 Offset: 0x11547B4 VA: 0x11587B4
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<int>>..ctor
	|
	|-RVA: 0x11588A0 Offset: 0x11548A0 VA: 0x11588A0
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x115898C Offset: 0x115498C VA: 0x115898C
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x1158A78 Offset: 0x1154A78 VA: 0x1158A78
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x1158B64 Offset: 0x1154B64 VA: 0x1158B64
	|-TaskFactory.<>c__DisplayClass35_0<bool>..ctor
	|
	|-RVA: 0x1158C50 Offset: 0x1154C50 VA: 0x1158C50
	|-TaskFactory.<>c__DisplayClass35_0<int>..ctor
	|
	|-RVA: 0x1158D3C Offset: 0x1154D3C VA: 0x1158D3C
	|-TaskFactory.<>c__DisplayClass35_0<object>..ctor
	|
	|-RVA: 0x1158E28 Offset: 0x1154E28 VA: 0x1158E28
	|-TaskFactory.<>c__DisplayClass35_0<VoidTaskResult>..ctor
	|
	|-RVA: 0x1158F14 Offset: 0x1154F14 VA: 0x1158F14
	|-TaskFactory.<>c__DisplayClass35_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11587BC Offset: 0x11547BC VA: 0x11587BC
	|-TaskFactory.<>c__DisplayClass35_0<Nullable<int>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x11588A8 Offset: 0x11548A8 VA: 0x11588A8
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<bool, object>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x1158994 Offset: 0x1154994 VA: 0x1158994
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<object, object, int>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x1158A80 Offset: 0x1154A80 VA: 0x1158A80
	|-TaskFactory.<>c__DisplayClass35_0<ValueTuple<object, bool, bool, object, object>>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x1158B6C Offset: 0x1154B6C VA: 0x1158B6C
	|-TaskFactory.<>c__DisplayClass35_0<bool>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x1158C58 Offset: 0x1154C58 VA: 0x1158C58
	|-TaskFactory.<>c__DisplayClass35_0<int>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x1158D44 Offset: 0x1154D44 VA: 0x1158D44
	|-TaskFactory.<>c__DisplayClass35_0<object>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x1158E30 Offset: 0x1154E30 VA: 0x1158E30
	|-TaskFactory.<>c__DisplayClass35_0<VoidTaskResult>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x1158F1C Offset: 0x1154F1C VA: 0x1158F1C
	|-TaskFactory.<>c__DisplayClass35_0<__Il2CppFullySharedGenericType>.<FromAsyncImpl>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TaskFactory.<>c__DisplayClass38_0<TResult, TArg1> // TypeDefIndex: 573
{
	// Fields
	public Func<IAsyncResult, TResult> endFunction; // 0x0
	public Action<IAsyncResult> endAction; // 0x0
	public Task<TResult> promise; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1159004 Offset: 0x1155004 VA: 0x1159004
	|-TaskFactory.<>c__DisplayClass38_0<object, object>..ctor
	|
	|-RVA: 0x11590F0 Offset: 0x11550F0 VA: 0x11590F0
	|-TaskFactory.<>c__DisplayClass38_0<VoidTaskResult, object>..ctor
	|
	|-RVA: 0x11591DC Offset: 0x11551DC VA: 0x11591DC
	|-TaskFactory.<>c__DisplayClass38_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115900C Offset: 0x115500C VA: 0x115900C
	|-TaskFactory.<>c__DisplayClass38_0<object, object>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x11590F8 Offset: 0x11550F8 VA: 0x11590F8
	|-TaskFactory.<>c__DisplayClass38_0<VoidTaskResult, object>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x11591E4 Offset: 0x11551E4 VA: 0x11591E4
	|-TaskFactory.<>c__DisplayClass38_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<FromAsyncImpl>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TaskFactory.<>c__DisplayClass41_0<TResult, TArg1, TArg2> // TypeDefIndex: 574
{
	// Fields
	public Func<IAsyncResult, TResult> endFunction; // 0x0
	public Action<IAsyncResult> endAction; // 0x0
	public Task<TResult> promise; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115A768 Offset: 0x1156768 VA: 0x115A768
	|-TaskFactory.<>c__DisplayClass41_0<VoidTaskResult, object, int>..ctor
	|
	|-RVA: 0x115A854 Offset: 0x1156854 VA: 0x115A854
	|-TaskFactory.<>c__DisplayClass41_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <FromAsyncImpl>b__0(IAsyncResult iar) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115A770 Offset: 0x1156770 VA: 0x115A770
	|-TaskFactory.<>c__DisplayClass41_0<VoidTaskResult, object, int>.<FromAsyncImpl>b__0
	|
	|-RVA: 0x115A85C Offset: 0x115685C VA: 0x115A85C
	|-TaskFactory.<>c__DisplayClass41_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<FromAsyncImpl>b__0
	*/
}

// Namespace: System.Threading.Tasks
public class TaskFactory<TResult> // TypeDefIndex: 575
{
	// Fields
	private CancellationToken m_defaultCancellationToken; // 0x0
	private TaskScheduler m_defaultScheduler; // 0x0
	private TaskCreationOptions m_defaultCreationOptions; // 0x0
	private TaskContinuationOptions m_defaultContinuationOptions; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146E450 Offset: 0x146A450 VA: 0x146E450
	|-TaskFactory<Nullable<int>>..ctor
	|
	|-RVA: 0x146EC50 Offset: 0x146AC50 VA: 0x146EC50
	|-TaskFactory<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x146F454 Offset: 0x146B454 VA: 0x146F454
	|-TaskFactory<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x146FC78 Offset: 0x146BC78 VA: 0x146FC78
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x1470498 Offset: 0x146C498 VA: 0x1470498
	|-TaskFactory<bool>..ctor
	|
	|-RVA: 0x1470C9C Offset: 0x146CC9C VA: 0x1470C9C
	|-TaskFactory<int>..ctor
	|
	|-RVA: 0x147149C Offset: 0x146D49C VA: 0x147149C
	|-TaskFactory<object>..ctor
	|
	|-RVA: 0x1471E08 Offset: 0x146DE08 VA: 0x1471E08
	|-TaskFactory<VoidTaskResult>..ctor
	|
	|-RVA: 0x14725FC Offset: 0x146E5FC VA: 0x14725FC
	|-TaskFactory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146E464 Offset: 0x146A464 VA: 0x146E464
	|-TaskFactory<Nullable<int>>..ctor
	|
	|-RVA: 0x146EC64 Offset: 0x146AC64 VA: 0x146EC64
	|-TaskFactory<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x146F468 Offset: 0x146B468 VA: 0x146F468
	|-TaskFactory<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x146FC8C Offset: 0x146BC8C VA: 0x146FC8C
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x14704AC Offset: 0x146C4AC VA: 0x14704AC
	|-TaskFactory<bool>..ctor
	|
	|-RVA: 0x1470CB0 Offset: 0x146CCB0 VA: 0x1470CB0
	|-TaskFactory<int>..ctor
	|
	|-RVA: 0x14714B0 Offset: 0x146D4B0 VA: 0x14714B0
	|-TaskFactory<object>..ctor
	|
	|-RVA: 0x1471E1C Offset: 0x146DE1C VA: 0x1471E1C
	|-TaskFactory<VoidTaskResult>..ctor
	|
	|-RVA: 0x1472620 Offset: 0x146E620 VA: 0x1472620
	|-TaskFactory<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146E4D8 Offset: 0x146A4D8 VA: 0x146E4D8
	|-TaskFactory<Nullable<int>>.FromAsyncCoreLogic
	|
	|-RVA: 0x146ECD8 Offset: 0x146ACD8 VA: 0x146ECD8
	|-TaskFactory<ValueTuple<bool, object>>.FromAsyncCoreLogic
	|
	|-RVA: 0x146F4DC Offset: 0x146B4DC VA: 0x146F4DC
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsyncCoreLogic
	|
	|-RVA: 0x146FD00 Offset: 0x146BD00 VA: 0x146FD00
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsyncCoreLogic
	|
	|-RVA: 0x1470520 Offset: 0x146C520 VA: 0x1470520
	|-TaskFactory<bool>.FromAsyncCoreLogic
	|
	|-RVA: 0x1470D24 Offset: 0x146CD24 VA: 0x1470D24
	|-TaskFactory<int>.FromAsyncCoreLogic
	|
	|-RVA: 0x1471524 Offset: 0x146D524 VA: 0x1471524
	|-TaskFactory<object>.FromAsyncCoreLogic
	|
	|-RVA: 0x1471E90 Offset: 0x146DE90 VA: 0x1471E90
	|-TaskFactory<VoidTaskResult>.FromAsyncCoreLogic
	|
	|-RVA: 0x1472694 Offset: 0x146E694 VA: 0x1472694
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncCoreLogic
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146E6C8 Offset: 0x146A6C8 VA: 0x146E6C8
	|-TaskFactory<Nullable<int>>.FromAsync
	|
	|-RVA: 0x146EEC8 Offset: 0x146AEC8 VA: 0x146EEC8
	|-TaskFactory<ValueTuple<bool, object>>.FromAsync
	|
	|-RVA: 0x146F6E0 Offset: 0x146B6E0 VA: 0x146F6E0
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsync
	|
	|-RVA: 0x146FF00 Offset: 0x146BF00 VA: 0x146FF00
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsync
	|
	|-RVA: 0x1470714 Offset: 0x146C714 VA: 0x1470714
	|-TaskFactory<bool>.FromAsync
	|
	|-RVA: 0x1470F14 Offset: 0x146CF14 VA: 0x1470F14
	|-TaskFactory<int>.FromAsync
	|
	|-RVA: 0x1471714 Offset: 0x146D714 VA: 0x1471714
	|-TaskFactory<object>.FromAsync
	|
	|-RVA: 0x1472080 Offset: 0x146E080 VA: 0x1472080
	|-TaskFactory<VoidTaskResult>.FromAsync
	|
	|-RVA: 0x14729B8 Offset: 0x146E9B8 VA: 0x14729B8
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsync
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl(Func<AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146E6E8 Offset: 0x146A6E8 VA: 0x146E6E8
	|-TaskFactory<Nullable<int>>.FromAsyncImpl
	|
	|-RVA: 0x146EEE8 Offset: 0x146AEE8 VA: 0x146EEE8
	|-TaskFactory<ValueTuple<bool, object>>.FromAsyncImpl
	|
	|-RVA: 0x146F700 Offset: 0x146B700 VA: 0x146F700
	|-TaskFactory<ValueTuple<object, object, int>>.FromAsyncImpl
	|
	|-RVA: 0x146FF20 Offset: 0x146BF20 VA: 0x146FF20
	|-TaskFactory<ValueTuple<object, bool, bool, object, object>>.FromAsyncImpl
	|
	|-RVA: 0x1470734 Offset: 0x146C734 VA: 0x1470734
	|-TaskFactory<bool>.FromAsyncImpl
	|
	|-RVA: 0x1470F34 Offset: 0x146CF34 VA: 0x1470F34
	|-TaskFactory<int>.FromAsyncImpl
	|
	|-RVA: 0x1471734 Offset: 0x146D734 VA: 0x1471734
	|-TaskFactory<object>.FromAsyncImpl
	|
	|-RVA: 0x14720A0 Offset: 0x146E0A0 VA: 0x14720A0
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl
	|
	|-RVA: 0x14729DC Offset: 0x146E9DC VA: 0x14729DC
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, TArg1 arg1, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1006F80 Offset: 0x1002F80 VA: 0x1006F80
	|-TaskFactory<object>.FromAsync<object>
	|
	|-RVA: 0x1008114 Offset: 0x1004114 VA: 0x1008114
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1006FEC Offset: 0x1002FEC VA: 0x1006FEC
	|-TaskFactory<object>.FromAsyncImpl<object>
	|
	|-RVA: 0x1007514 Offset: 0x1003514 VA: 0x1007514
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl<object>
	|
	|-RVA: 0x1008218 Offset: 0x1004218 VA: 0x1008218
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncImpl<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1007A3C Offset: 0x1003A3C VA: 0x1007A3C
	|-TaskFactory<VoidTaskResult>.FromAsyncImpl<object, int>
	|
	|-RVA: 0x1008988 Offset: 0x1004988 VA: 0x1008988
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncImpl<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1006DE8 Offset: 0x1002DE8 VA: 0x1006DE8
	|-TaskFactory<int>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-RVA: 0x1007F7C Offset: 0x1003F7C VA: 0x1007F7C
	|-TaskFactory<VoidTaskResult>.FromAsyncTrim<object, Stream.ReadWriteParameters>
	|
	|-RVA: 0x1009148 Offset: 0x1005148 VA: 0x1009148
	|-TaskFactory<__Il2CppFullySharedGenericType>.FromAsyncTrim<object, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Threading.Tasks
public enum TaskStatus // TypeDefIndex: 576
{
	// Fields
	public int value__; // 0x0
	public const TaskStatus Created = 0;
	public const TaskStatus WaitingForActivation = 1;
	public const TaskStatus WaitingToRun = 2;
	public const TaskStatus Running = 3;
	public const TaskStatus WaitingForChildrenToComplete = 4;
	public const TaskStatus RanToCompletion = 5;
	public const TaskStatus Canceled = 6;
	public const TaskStatus Faulted = 7;
}

// Namespace: 
internal class Task.ContingentProperties // TypeDefIndex: 577
{
	// Fields
	internal ExecutionContext m_capturedContext; // 0x10
	internal ManualResetEventSlim m_completionEvent; // 0x18
	internal TaskExceptionHolder m_exceptionsHolder; // 0x20
	internal CancellationToken m_cancellationToken; // 0x28
	internal object m_cancellationRegistration; // 0x30
	internal int m_internalCancellationRequested; // 0x38
	internal int m_completionCountdown; // 0x3C
	internal LowLevelListWithIList<Task> m_exceptionalChildren; // 0x40

	// Methods

	// RVA: 0x19104F0 Offset: 0x190C4F0 VA: 0x19104F0
	internal void SetCompleted() { }

	// RVA: 0x1910518 Offset: 0x190C518 VA: 0x1910518
	internal void UnregisterCancellationCallback() { }

	// RVA: 0x190D590 Offset: 0x1909590 VA: 0x190D590
	public void .ctor() { }
}

// Namespace: 
private sealed class Task.SetOnInvokeMres : ManualResetEventSlim, ITaskCompletionAction // TypeDefIndex: 578
{
	// Properties
	public bool InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: 0x1912540 Offset: 0x190E540 VA: 0x1912540
	internal void .ctor() { }

	// RVA: 0x1914C54 Offset: 0x1910C54 VA: 0x1914C54 Slot: 6
	public void Invoke(Task completingTask) { }

	// RVA: 0x1914C5C Offset: 0x1910C5C VA: 0x1914C5C Slot: 7
	public bool get_InvokeMayRunArbitraryCode() { }
}

// Namespace: 
private sealed class Task.DelayPromise : Task<VoidTaskResult> // TypeDefIndex: 579
{
	// Fields
	internal readonly CancellationToken Token; // 0x58
	internal CancellationTokenRegistration Registration; // 0x60
	internal Timer Timer; // 0x78

	// Methods

	// RVA: 0x1913D2C Offset: 0x190FD2C VA: 0x1913D2C
	internal void .ctor(CancellationToken token) { }

	// RVA: 0x1914C64 Offset: 0x1910C64 VA: 0x1914C64
	internal void Complete() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Task.<>c // TypeDefIndex: 580
{
	// Fields
	public static readonly Task.<>c <>9; // 0x0
	public static Action<object> <>9__247_0; // 0x8
	public static TimerCallback <>9__247_1; // 0x10

	// Methods

	// RVA: 0x1914DC0 Offset: 0x1910DC0 VA: 0x1914DC0
	private static void .cctor() { }

	// RVA: 0x1914E28 Offset: 0x1910E28 VA: 0x1914E28
	public void .ctor() { }

	// RVA: 0x1914E30 Offset: 0x1910E30 VA: 0x1914E30
	internal void <Delay>b__247_0(object state) { }

	// RVA: 0x1914E90 Offset: 0x1910E90 VA: 0x1914E90
	internal void <Delay>b__247_1(object state) { }

	// RVA: 0x1914EF0 Offset: 0x1910EF0 VA: 0x1914EF0
	internal Task.ContingentProperties <.cctor>b__271_0() { }

	// RVA: 0x1914F54 Offset: 0x1910F54 VA: 0x1914F54
	internal bool <.cctor>b__271_1(Task t) { }

	// RVA: 0x1914F74 Offset: 0x1910F74 VA: 0x1914F74
	internal bool <.cctor>b__271_2(object tc) { }
}

// Namespace: System.Threading.Tasks
[DebuggerTypeProxy(typeof(SystemThreadingTasks_TaskDebugView))]
[DebuggerDisplay("Id = {Id}, Status = {Status}, Method = {DebuggerDisplayMethodDescription}")]
public class Task : IThreadPoolWorkItem, IAsyncResult, IDisposable // TypeDefIndex: 581
{
	// Fields
	internal static int s_taskIdCounter; // 0x0
	private int m_taskId; // 0x10
	internal Delegate m_action; // 0x18
	internal object m_stateObject; // 0x20
	internal TaskScheduler m_taskScheduler; // 0x28
	internal readonly Task m_parent; // 0x30
	internal int m_stateFlags; // 0x38
	private object m_continuationObject; // 0x40
	private static readonly object s_taskCompletionSentinel; // 0x8
	internal static bool s_asyncDebuggingEnabled; // 0x10
	internal Task.ContingentProperties m_contingentProperties; // 0x48
	private static readonly Action<object> s_taskCancelCallback; // 0x18
	[ThreadStatic]
	internal static Task t_currentTask; // 0x80000000
	[ThreadStatic]
	private static StackGuard t_stackGuard; // 0x80000008
	private static readonly Func<Task.ContingentProperties> s_createContingentProperties; // 0x20
	[CompilerGenerated]
	private static readonly TaskFactory <Factory>k__BackingField; // 0x28
	[CompilerGenerated]
	private static readonly Task <CompletedTask>k__BackingField; // 0x30
	private static readonly Predicate<Task> s_IsExceptionObservedByParentPredicate; // 0x38
	private static ContextCallback s_ecCallback; // 0x40
	private static readonly Predicate<object> s_IsTaskContinuationNullPredicate; // 0x48
	private static readonly Dictionary<int, Task> s_currentActiveTasks; // 0x50
	private static readonly object s_activeTasksLock; // 0x58

	// Properties
	internal TaskCreationOptions Options { get; }
	internal bool IsWaitNotificationEnabledOrNotRanToCompletion { get; }
	internal virtual bool ShouldNotifyDebuggerOfWaitCompletion { get; }
	internal bool IsWaitNotificationEnabled { get; }
	public int Id { get; }
	internal static Task InternalCurrent { get; }
	internal static StackGuard CurrentStackGuard { get; }
	public AggregateException Exception { get; }
	public TaskStatus Status { get; }
	public bool IsCanceled { get; }
	internal bool IsCancellationRequested { get; }
	internal CancellationToken CancellationToken { get; }
	internal bool IsCancellationAcknowledged { get; }
	public bool IsCompleted { get; }
	public bool IsCompletedSuccessfully { get; }
	public TaskCreationOptions CreationOptions { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }
	public object AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	internal TaskScheduler ExecutingTaskScheduler { get; }
	public static TaskFactory Factory { get; }
	public static Task CompletedTask { get; }
	internal ManualResetEventSlim CompletedEvent { get; }
	internal bool ExceptionRecorded { get; }
	public bool IsFaulted { get; }
	internal ExecutionContext CapturedContext { get; set; }
	internal bool IsExceptionObservedByParent { get; }
	internal bool IsDelegateInvoked { get; }

	// Methods

	// RVA: 0x190D4C0 Offset: 0x19094C0 VA: 0x190D4C0
	internal void .ctor(bool canceled, TaskCreationOptions creationOptions, CancellationToken ct) { }

	// RVA: 0x190D5B4 Offset: 0x19095B4 VA: 0x190D5B4
	internal void .ctor() { }

	// RVA: 0x190D5DC Offset: 0x19095DC VA: 0x190D5DC
	internal void .ctor(object state, TaskCreationOptions creationOptions, bool promiseStyle) { }

	// RVA: 0x190D8AC Offset: 0x19098AC VA: 0x190D8AC
	internal void .ctor(Delegate action, object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x190D704 Offset: 0x1909704 VA: 0x190D704
	internal void TaskConstructorCore(Delegate action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler) { }

	// RVA: 0x190DA04 Offset: 0x1909A04 VA: 0x190DA04
	private void AssignCancellationToken(CancellationToken cancellationToken, Task antecedent, TaskContinuation continuation) { }

	// RVA: 0x190E050 Offset: 0x190A050 VA: 0x190E050
	private static void TaskCancelCallback(object o) { }

	// RVA: 0x190CE1C Offset: 0x1908E1C VA: 0x190CE1C
	internal bool TrySetCanceled(CancellationToken tokenToRecord) { }

	// RVA: 0x190C518 Offset: 0x1908518 VA: 0x190C518
	internal bool TrySetCanceled(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x190CE24 Offset: 0x1908E24 VA: 0x190CE24
	internal bool TrySetException(object exceptionObject) { }

	// RVA: 0x190DDF8 Offset: 0x1909DF8 VA: 0x190DDF8
	internal TaskCreationOptions get_Options() { }

	// RVA: 0x190E754 Offset: 0x190A754 VA: 0x190E754
	internal static TaskCreationOptions OptionsMethod(int flags) { }

	// RVA: 0x190E388 Offset: 0x190A388 VA: 0x190E388
	internal bool AtomicStateUpdate(int newBits, int illegalBits) { }

	// RVA: 0x190E75C Offset: 0x190A75C VA: 0x190E75C
	internal bool AtomicStateUpdate(int newBits, int illegalBits, ref int oldFlags) { }

	// RVA: 0x190E834 Offset: 0x190A834 VA: 0x190E834
	internal void SetNotificationForWaitCompletion(bool enabled) { }

	// RVA: 0x190E90C Offset: 0x190A90C VA: 0x190E90C
	internal bool NotifyDebuggerOfWaitCompletionIfNecessary() { }

	// RVA: 0x190E99C Offset: 0x190A99C VA: 0x190E99C
	internal bool get_IsWaitNotificationEnabledOrNotRanToCompletion() { }

	// RVA: 0x190E9C4 Offset: 0x190A9C4 VA: 0x190E9C4 Slot: 11
	internal virtual bool get_ShouldNotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x190E95C Offset: 0x190A95C VA: 0x190E95C
	internal bool get_IsWaitNotificationEnabled() { }

	// RVA: 0x190E974 Offset: 0x190A974 VA: 0x190E974
	private void NotifyDebuggerOfWaitCompletion() { }

	// RVA: 0x190E9DC Offset: 0x190A9DC VA: 0x190E9DC
	internal bool MarkStarted() { }

	// RVA: 0x190D990 Offset: 0x1909990 VA: 0x190D990
	internal void AddNewChild() { }

	// RVA: 0x190E00C Offset: 0x190A00C VA: 0x190E00C
	internal void DisregardChild() { }

	// RVA: 0x190E9E8 Offset: 0x190A9E8 VA: 0x190E9E8
	internal static Task InternalStartNew(Task creatingTask, Delegate action, object state, CancellationToken cancellationToken, TaskScheduler scheduler, TaskCreationOptions options, InternalTaskOptions internalOptions) { }

	// RVA: 0x190D168 Offset: 0x1909168 VA: 0x190D168
	public int get_Id() { }

	// RVA: 0x190ECFC Offset: 0x190ACFC VA: 0x190ECFC
	internal static Task get_InternalCurrent() { }

	// RVA: 0x190ED54 Offset: 0x190AD54 VA: 0x190ED54
	internal static Task InternalCurrentIfAttached(TaskCreationOptions creationOptions) { }

	// RVA: 0x190EDEC Offset: 0x190ADEC VA: 0x190EDEC
	internal static StackGuard get_CurrentStackGuard() { }

	// RVA: 0x190EEB0 Offset: 0x190AEB0 VA: 0x190EEB0
	public AggregateException get_Exception() { }

	// RVA: 0x190F054 Offset: 0x190B054 VA: 0x190F054
	public TaskStatus get_Status() { }

	// RVA: 0x190F0B4 Offset: 0x190B0B4 VA: 0x190F0B4
	public bool get_IsCanceled() { }

	// RVA: 0x190F0D4 Offset: 0x190B0D4 VA: 0x190F0D4
	internal bool get_IsCancellationRequested() { }

	// RVA: 0x190DDB8 Offset: 0x1909DB8 VA: 0x190DDB8
	internal Task.ContingentProperties EnsureContingentPropertiesInitialized(bool needsProtection) { }

	// RVA: 0x190F160 Offset: 0x190B160 VA: 0x190F160
	private Task.ContingentProperties EnsureContingentPropertiesInitializedCore(bool needsProtection) { }

	// RVA: 0x190B8E4 Offset: 0x19078E4 VA: 0x190B8E4
	internal CancellationToken get_CancellationToken() { }

	// RVA: 0x190F240 Offset: 0x190B240 VA: 0x190F240
	internal bool get_IsCancellationAcknowledged() { }

	// RVA: 0x190BB68 Offset: 0x1907B68 VA: 0x190BB68 Slot: 6
	public bool get_IsCompleted() { }

	// RVA: 0x190F258 Offset: 0x190B258 VA: 0x190F258
	private static bool IsCompletedMethod(int flags) { }

	// RVA: 0x190F268 Offset: 0x190B268 VA: 0x190F268
	public bool get_IsCompletedSuccessfully() { }

	// RVA: 0x190D97C Offset: 0x190997C VA: 0x190D97C
	public TaskCreationOptions get_CreationOptions() { }

	// RVA: 0x190F290 Offset: 0x190B290 VA: 0x190F290 Slot: 7
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }

	// RVA: 0x190F40C Offset: 0x190B40C VA: 0x190F40C Slot: 8
	public object get_AsyncState() { }

	// RVA: 0x190F414 Offset: 0x190B414 VA: 0x190F414 Slot: 9
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x190F41C Offset: 0x190B41C VA: 0x190F41C
	internal TaskScheduler get_ExecutingTaskScheduler() { }

	[CompilerGenerated]
	// RVA: 0x190F424 Offset: 0x190B424 VA: 0x190F424
	public static TaskFactory get_Factory() { }

	[CompilerGenerated]
	// RVA: 0x190F47C Offset: 0x190B47C VA: 0x190F47C
	public static Task get_CompletedTask() { }

	// RVA: 0x190F314 Offset: 0x190B314 VA: 0x190F314
	internal ManualResetEventSlim get_CompletedEvent() { }

	// RVA: 0x190F4D4 Offset: 0x190B4D4 VA: 0x190F4D4
	internal bool get_ExceptionRecorded() { }

	// RVA: 0x190EEEC Offset: 0x190AEEC VA: 0x190EEEC
	public bool get_IsFaulted() { }

	// RVA: 0x190F544 Offset: 0x190B544 VA: 0x190F544
	internal ExecutionContext get_CapturedContext() { }

	// RVA: 0x190DD08 Offset: 0x1909D08 VA: 0x190DD08
	internal void set_CapturedContext(ExecutionContext value) { }

	// RVA: 0x190F5B4 Offset: 0x190B5B4 VA: 0x190F5B4 Slot: 10
	public void Dispose() { }

	// RVA: 0x190F620 Offset: 0x190B620 VA: 0x190F620 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x190EAF0 Offset: 0x190AAF0 VA: 0x190EAF0
	internal void ScheduleAndStart(bool needsProtection) { }

	// RVA: 0x190E5A4 Offset: 0x190A5A4 VA: 0x190E5A4
	internal void AddException(object exceptionObject) { }

	// RVA: 0x190F784 Offset: 0x190B784 VA: 0x190F784
	internal void AddException(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x190EF04 Offset: 0x190AF04 VA: 0x190EF04
	private AggregateException GetExceptions(bool includeTaskCanceledExceptions) { }

	// RVA: 0x190FB4C Offset: 0x190BB4C VA: 0x190FB4C
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x190FCF8 Offset: 0x190BCF8 VA: 0x190FCF8
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x190FD28 Offset: 0x190BD28 VA: 0x190FD28
	internal void ThrowIfExceptional(bool includeTaskCanceledExceptions) { }

	// RVA: 0x190FD6C Offset: 0x190BD6C VA: 0x190FD6C
	internal void UpdateExceptionObservedStatus() { }

	// RVA: 0x190FE40 Offset: 0x190BE40 VA: 0x190FE40
	internal bool get_IsExceptionObservedByParent() { }

	// RVA: 0x190FE58 Offset: 0x190BE58 VA: 0x190FE58
	internal bool get_IsDelegateInvoked() { }

	// RVA: 0x190E5AC Offset: 0x190A5AC VA: 0x190E5AC
	internal void Finish(bool bUserDelegateExecuted) { }

	// RVA: 0x190FE70 Offset: 0x190BE70 VA: 0x190FE70
	internal void FinishStageTwo() { }

	// RVA: 0x191064C Offset: 0x190C64C VA: 0x191064C
	internal void FinishStageThree() { }

	// RVA: 0x19106AC Offset: 0x190C6AC VA: 0x19106AC
	internal void ProcessChildCompletion(Task childTask) { }

	// RVA: 0x19100E8 Offset: 0x190C0E8 VA: 0x19100E8
	internal void AddExceptionsFromChildren() { }

	// RVA: 0x1910E58 Offset: 0x190CE58 VA: 0x1910E58
	private void Execute() { }

	// RVA: 0x191100C Offset: 0x190D00C VA: 0x191100C Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1911014 Offset: 0x190D014 VA: 0x1911014
	internal bool ExecuteEntry(bool bPreventDoubleExecution) { }

	// RVA: 0x1911310 Offset: 0x190D310 VA: 0x1911310
	private static void ExecutionContextCallback(object obj) { }

	// RVA: 0x1911388 Offset: 0x190D388 VA: 0x1911388 Slot: 13
	internal virtual void InnerInvoke() { }

	// RVA: 0x1910F04 Offset: 0x190CF04 VA: 0x1910F04
	private void HandleException(Exception unhandledException) { }

	// RVA: 0x190BE30 Offset: 0x1907E30 VA: 0x190BE30
	public TaskAwaiter GetAwaiter() { }

	// RVA: 0x190BE54 Offset: 0x1907E54 VA: 0x190BE54
	public ConfiguredTaskAwaitable ConfigureAwait(bool continueOnCapturedContext) { }

	// RVA: 0x1911468 Offset: 0x190D468 VA: 0x1911468
	internal void SetContinuationForAwait(Action continuationAction, bool continueOnCapturedContext, bool flowExecutionContext) { }

	// RVA: 0x1911864 Offset: 0x190D864 VA: 0x1911864
	public void Wait() { }

	// RVA: 0x1911870 Offset: 0x190D870 VA: 0x1911870
	public bool Wait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1911F68 Offset: 0x190DF68 VA: 0x1911F68
	private bool WrappedTryRunInline() { }

	// RVA: 0x19119C0 Offset: 0x190D9C0 VA: 0x19119C0
	internal bool InternalWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x19122B0 Offset: 0x190E2B0 VA: 0x19122B0
	private bool SpinThenBlockingWait(int millisecondsTimeout, CancellationToken cancellationToken) { }

	// RVA: 0x1912468 Offset: 0x190E468 VA: 0x1912468
	private bool SpinWait(int millisecondsTimeout) { }

	// RVA: 0x190DE54 Offset: 0x1909E54 VA: 0x190DE54
	internal bool InternalCancel(bool bCancelNonExecutingOnly) { }

	// RVA: 0x1912674 Offset: 0x190E674 VA: 0x1912674
	internal void RecordInternalCancellationRequest() { }

	// RVA: 0x19126BC Offset: 0x190E6BC VA: 0x19126BC
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord) { }

	// RVA: 0x190E448 Offset: 0x190A448 VA: 0x190E448
	internal void RecordInternalCancellationRequest(CancellationToken tokenToRecord, object cancellationException) { }

	// RVA: 0x190E484 Offset: 0x190A484 VA: 0x190E484
	internal void CancellationCleanupLogic() { }

	// RVA: 0x191143C Offset: 0x190D43C VA: 0x191143C
	private void SetCancellationAcknowledged() { }

	// RVA: 0x1910864 Offset: 0x190C864 VA: 0x1910864
	internal void FinishContinuations() { }

	// RVA: 0x191293C Offset: 0x190E93C VA: 0x191293C
	private void LogFinishCompletionNotification() { }

	// RVA: 0x1912990 Offset: 0x190E990 VA: 0x1912990
	public Task ContinueWith(Action<Task> continuationAction) { }

	// RVA: 0x1912AA4 Offset: 0x190EAA4 VA: 0x1912AA4
	private Task ContinueWith(Action<Task> continuationAction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	// RVA: 0x1912F30 Offset: 0x190EF30 VA: 0x1912F30
	public Task ContinueWith(Action<Task, object> continuationAction, object state, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x1912F44 Offset: 0x190EF44 VA: 0x1912F44
	private Task ContinueWith(Action<Task, object> continuationAction, object state, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions) { }

	// RVA: 0x1912BF8 Offset: 0x190EBF8 VA: 0x1912BF8
	internal static void CreationOptionsFromContinuationOptions(TaskContinuationOptions continuationOptions, out TaskCreationOptions creationOptions, out InternalTaskOptions internalOptions) { }

	// RVA: 0x1912DD4 Offset: 0x190EDD4 VA: 0x1912DD4
	internal void ContinueWithCore(Task continuationTask, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions options) { }

	// RVA: 0x19131E8 Offset: 0x190F1E8 VA: 0x19131E8
	internal void AddCompletionAction(ITaskCompletionAction action) { }

	// RVA: 0x19125A0 Offset: 0x190E5A0 VA: 0x19125A0
	private void AddCompletionAction(ITaskCompletionAction action, bool addBeforeOthers) { }

	// RVA: 0x19131F0 Offset: 0x190F1F0 VA: 0x19131F0
	private bool AddTaskContinuationComplex(object tc, bool addBeforeOthers) { }

	// RVA: 0x1911770 Offset: 0x190D770 VA: 0x1911770
	private bool AddTaskContinuation(object tc, bool addBeforeOthers) { }

	// RVA: 0x190E140 Offset: 0x190A140 VA: 0x190E140
	internal void RemoveContinuation(object continuationObject) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromResult<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1036D48 Offset: 0x1032D48 VA: 0x1036D48
	|-Task.FromResult<bool>
	|
	|-RVA: 0x1036DA8 Offset: 0x1032DA8 VA: 0x1036DA8
	|-Task.FromResult<int>
	|
	|-RVA: 0x1036E08 Offset: 0x1032E08 VA: 0x1036E08
	|-Task.FromResult<object>
	|
	|-RVA: 0x1036E68 Offset: 0x1032E68 VA: 0x1036E68
	|-Task.FromResult<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x190C570 Offset: 0x1908570 VA: 0x190C570
	public static Task FromException(Exception exception) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> FromException<TResult>(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1036B28 Offset: 0x1032B28 VA: 0x1036B28
	|-Task.FromException<int>
	|
	|-RVA: 0x1036BDC Offset: 0x1032BDC VA: 0x1036BDC
	|-Task.FromException<VoidTaskResult>
	|
	|-RVA: 0x1036C90 Offset: 0x1032C90 VA: 0x1036C90
	|-Task.FromException<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x19134EC Offset: 0x190F4EC VA: 0x19134EC
	internal static Task FromCancellation(CancellationToken cancellationToken) { }

	// RVA: 0x190C9D8 Offset: 0x19089D8 VA: 0x190C9D8
	public static Task FromCanceled(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10364AC Offset: 0x10324AC VA: 0x10364AC
	|-Task.FromCancellation<bool>
	|
	|-RVA: 0x1036594 Offset: 0x1032594 VA: 0x1036594
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x1036734 Offset: 0x1032734 VA: 0x1036734
	|-Task.FromCancellation<object>
	|
	|-RVA: 0x10368D4 Offset: 0x10328D4 VA: 0x10368D4
	|-Task.FromCancellation<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> FromCanceled<TResult>(CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10363E0 Offset: 0x10323E0 VA: 0x10363E0
	|-Task.FromCanceled<int>
	|
	|-RVA: 0x1036444 Offset: 0x1032444 VA: 0x1036444
	|-Task.FromCanceled<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> FromCancellation<TResult>(OperationCanceledException exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103667C Offset: 0x103267C VA: 0x103667C
	|-Task.FromCancellation<int>
	|
	|-RVA: 0x103681C Offset: 0x103281C VA: 0x103681C
	|-Task.FromCancellation<VoidTaskResult>
	|
	|-RVA: 0x1036A6C Offset: 0x1032A6C VA: 0x1036A6C
	|-Task.FromCancellation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x19135CC Offset: 0x190F5CC VA: 0x19135CC
	public static Task Run(Action action) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<TResult> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1036F64 Offset: 0x1032F64 VA: 0x1036F64
	|-Task.Run<int>
	|
	|-RVA: 0x103701C Offset: 0x103301C VA: 0x103701C
	|-Task.Run<object>
	|
	|-RVA: 0x103713C Offset: 0x103313C VA: 0x103713C
	|-Task.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x191369C Offset: 0x190F69C VA: 0x191369C
	public static Task Run(Func<Task> function) { }

	// RVA: 0x19136F4 Offset: 0x190F6F4 VA: 0x19136F4
	public static Task Run(Func<Task> function, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10370D4 Offset: 0x10330D4 VA: 0x10370D4
	|-Task.Run<object>
	|
	|-RVA: 0x10371F8 Offset: 0x10331F8 VA: 0x10371F8
	|-Task.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static Task<TResult> Run<TResult>(Func<Task<TResult>> function, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1037264 Offset: 0x1033264 VA: 0x1037264
	|-Task.Run<object>
	|
	|-RVA: 0x1037484 Offset: 0x1033484 VA: 0x1037484
	|-Task.Run<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x191392C Offset: 0x190F92C VA: 0x191392C
	public static Task Delay(int millisecondsDelay) { }

	// RVA: 0x1913984 Offset: 0x190F984 VA: 0x1913984
	public static Task Delay(int millisecondsDelay, CancellationToken cancellationToken) { }

	// RVA: 0x1913E4C Offset: 0x190FE4C VA: 0x1913E4C
	public static Task<Task> WhenAny(Task[] tasks) { }

	// RVA: 0x1914220 Offset: 0x1910220 VA: 0x1914220
	public static Task<Task> WhenAny(IEnumerable<Task> tasks) { }

	[FriendAccessAllowed]
	// RVA: 0x191464C Offset: 0x191064C VA: 0x191464C
	internal static bool AddToActiveTasks(Task task) { }

	[FriendAccessAllowed]
	// RVA: 0x19147B4 Offset: 0x19107B4 VA: 0x19147B4
	internal static void RemoveFromActiveTasks(int taskId) { }

	// RVA: 0x19148FC Offset: 0x19108FC VA: 0x19148FC Slot: 5
	public void MarkAborted(ThreadAbortException e) { }

	// RVA: 0x1911130 Offset: 0x190D130 VA: 0x1911130
	private void ExecuteWithThreadLocal(ref Task currentTaskSlot) { }

	// RVA: 0x191490C Offset: 0x191090C VA: 0x191490C
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
internal sealed class CompletionActionInvoker : IThreadPoolWorkItem // TypeDefIndex: 582
{
	// Fields
	private readonly ITaskCompletionAction m_action; // 0x10
	private readonly Task m_completingTask; // 0x18

	// Methods

	// RVA: 0x19128F8 Offset: 0x190E8F8 VA: 0x19128F8
	internal void .ctor(ITaskCompletionAction action, Task completingTask) { }

	// RVA: 0x1914F80 Offset: 0x1910F80 VA: 0x1914F80 Slot: 4
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1915028 Offset: 0x1911028 VA: 0x1915028 Slot: 5
	public void MarkAborted(ThreadAbortException e) { }
}

// Namespace: System.Threading.Tasks
internal class SystemThreadingTasks_TaskDebugView // TypeDefIndex: 583
{}

// Namespace: System.Threading.Tasks
[Flags]
public enum TaskCreationOptions // TypeDefIndex: 584
{
	// Fields
	public int value__; // 0x0
	public const TaskCreationOptions None = 0;
	public const TaskCreationOptions PreferFairness = 1;
	public const TaskCreationOptions LongRunning = 2;
	public const TaskCreationOptions AttachedToParent = 4;
	public const TaskCreationOptions DenyChildAttach = 8;
	public const TaskCreationOptions HideScheduler = 16;
	public const TaskCreationOptions RunContinuationsAsynchronously = 64;
}

// Namespace: System.Threading.Tasks
[Flags]
internal enum InternalTaskOptions // TypeDefIndex: 585
{
	// Fields
	public int value__; // 0x0
	public const InternalTaskOptions None = 0;
	public const InternalTaskOptions InternalOptionsMask = 65280;
	public const InternalTaskOptions ContinuationTask = 512;
	public const InternalTaskOptions PromiseTask = 1024;
	public const InternalTaskOptions LazyCancellation = 4096;
	public const InternalTaskOptions QueuedByRuntime = 8192;
	public const InternalTaskOptions DoNotDispose = 16384;
}

// Namespace: System.Threading.Tasks
[Flags]
public enum TaskContinuationOptions // TypeDefIndex: 586
{
	// Fields
	public int value__; // 0x0
	public const TaskContinuationOptions None = 0;
	public const TaskContinuationOptions PreferFairness = 1;
	public const TaskContinuationOptions LongRunning = 2;
	public const TaskContinuationOptions AttachedToParent = 4;
	public const TaskContinuationOptions DenyChildAttach = 8;
	public const TaskContinuationOptions HideScheduler = 16;
	public const TaskContinuationOptions LazyCancellation = 32;
	public const TaskContinuationOptions RunContinuationsAsynchronously = 64;
	public const TaskContinuationOptions NotOnRanToCompletion = 65536;
	public const TaskContinuationOptions NotOnFaulted = 131072;
	public const TaskContinuationOptions NotOnCanceled = 262144;
	public const TaskContinuationOptions OnlyOnRanToCompletion = 393216;
	public const TaskContinuationOptions OnlyOnFaulted = 327680;
	public const TaskContinuationOptions OnlyOnCanceled = 196608;
	public const TaskContinuationOptions ExecuteSynchronously = 524288;
}

// Namespace: System.Threading.Tasks
internal class StackGuard // TypeDefIndex: 587
{
	// Fields
	private int m_inliningDepth; // 0x10

	// Methods

	// RVA: 0x191502C Offset: 0x191102C VA: 0x191502C
	internal bool TryBeginInliningScope() { }

	// RVA: 0x191506C Offset: 0x191106C VA: 0x191506C
	internal void EndInliningScope() { }

	// RVA: 0x190EEA8 Offset: 0x190AEA8 VA: 0x190EEA8
	public void .ctor() { }
}

// Namespace: System.Threading.Tasks
internal struct VoidTaskResult // TypeDefIndex: 588
{}

// Namespace: System.Threading.Tasks
internal interface ITaskCompletionAction // TypeDefIndex: 589
{
	// Properties
	public abstract bool InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Invoke(Task completingTask);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_InvokeMayRunArbitraryCode();
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UnwrapPromise.<>c<TResult> // TypeDefIndex: 590
{
	// Fields
	public static readonly UnwrapPromise.<>c<TResult> <>9; // 0x0
	public static WaitCallback <>9__8_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150FCC Offset: 0x114CFCC VA: 0x1150FCC
	|-UnwrapPromise.<>c<object>..cctor
	|
	|-RVA: 0x1151140 Offset: 0x114D140 VA: 0x1151140
	|-UnwrapPromise.<>c<VoidTaskResult>..cctor
	|
	|-RVA: 0x1151A7C Offset: 0x114DA7C VA: 0x1151A7C
	|-UnwrapPromise.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11510A4 Offset: 0x114D0A4 VA: 0x11510A4
	|-UnwrapPromise.<>c<object>..ctor
	|
	|-RVA: 0x1151218 Offset: 0x114D218 VA: 0x1151218
	|-UnwrapPromise.<>c<VoidTaskResult>..ctor
	|
	|-RVA: 0x1151B88 Offset: 0x114DB88 VA: 0x1151B88
	|-UnwrapPromise.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <InvokeCoreAsync>b__8_0(object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11510AC Offset: 0x114D0AC VA: 0x11510AC
	|-UnwrapPromise.<>c<object>.<InvokeCoreAsync>b__8_0
	|
	|-RVA: 0x1151220 Offset: 0x114D220 VA: 0x1151220
	|-UnwrapPromise.<>c<VoidTaskResult>.<InvokeCoreAsync>b__8_0
	|
	|-RVA: 0x1151B90 Offset: 0x114DB90 VA: 0x1151B90
	|-UnwrapPromise.<>c<__Il2CppFullySharedGenericType>.<InvokeCoreAsync>b__8_0
	*/
}

// Namespace: System.Threading.Tasks
internal sealed class UnwrapPromise<TResult> : Task<TResult>, ITaskCompletionAction // TypeDefIndex: 591
{
	// Fields
	private byte _state; // 0x0
	private readonly bool _lookForOce; // 0x0

	// Properties
	public bool InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task outerTask, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14997E8 Offset: 0x14957E8 VA: 0x14997E8
	|-UnwrapPromise<object>..ctor
	|
	|-RVA: 0x149A1F8 Offset: 0x14961F8 VA: 0x149A1F8
	|-UnwrapPromise<VoidTaskResult>..ctor
	|
	|-RVA: 0x149AC08 Offset: 0x1496C08 VA: 0x149AC08
	|-UnwrapPromise<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void Invoke(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1499990 Offset: 0x1495990 VA: 0x1499990
	|-UnwrapPromise<object>.Invoke
	|
	|-RVA: 0x149A3A0 Offset: 0x14963A0 VA: 0x149A3A0
	|-UnwrapPromise<VoidTaskResult>.Invoke
	|
	|-RVA: 0x149ADE8 Offset: 0x1496DE8 VA: 0x149ADE8
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	private void InvokeCore(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1499AC8 Offset: 0x1495AC8 VA: 0x1499AC8
	|-UnwrapPromise<object>.InvokeCore
	|
	|-RVA: 0x149A4D8 Offset: 0x14964D8 VA: 0x149A4D8
	|-UnwrapPromise<VoidTaskResult>.InvokeCore
	|
	|-RVA: 0x149AF28 Offset: 0x1496F28 VA: 0x149AF28
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.InvokeCore
	*/

	// RVA: -1 Offset: -1
	private void InvokeCoreAsync(Task completingTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1499B20 Offset: 0x1495B20 VA: 0x1499B20
	|-UnwrapPromise<object>.InvokeCoreAsync
	|
	|-RVA: 0x149A530 Offset: 0x1496530 VA: 0x149A530
	|-UnwrapPromise<VoidTaskResult>.InvokeCoreAsync
	|
	|-RVA: 0x149AFD4 Offset: 0x1496FD4 VA: 0x149AFD4
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.InvokeCoreAsync
	*/

	// RVA: -1 Offset: -1
	private void ProcessCompletedOuterTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1499CA4 Offset: 0x1495CA4 VA: 0x1499CA4
	|-UnwrapPromise<object>.ProcessCompletedOuterTask
	|
	|-RVA: 0x149A6B4 Offset: 0x14966B4 VA: 0x149A6B4
	|-UnwrapPromise<VoidTaskResult>.ProcessCompletedOuterTask
	|
	|-RVA: 0x149B174 Offset: 0x1497174 VA: 0x149B174
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.ProcessCompletedOuterTask
	*/

	// RVA: -1 Offset: -1
	private bool TrySetFromTask(Task task, bool lookForOce) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1499E10 Offset: 0x1495E10 VA: 0x1499E10
	|-UnwrapPromise<object>.TrySetFromTask
	|
	|-RVA: 0x149A820 Offset: 0x1496820 VA: 0x149A820
	|-UnwrapPromise<VoidTaskResult>.TrySetFromTask
	|
	|-RVA: 0x149B330 Offset: 0x1497330 VA: 0x149B330
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.TrySetFromTask
	*/

	// RVA: -1 Offset: -1
	private void ProcessInnerTask(Task task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149A164 Offset: 0x1496164 VA: 0x149A164
	|-UnwrapPromise<object>.ProcessInnerTask
	|
	|-RVA: 0x149AB74 Offset: 0x1496B74 VA: 0x149AB74
	|-UnwrapPromise<VoidTaskResult>.ProcessInnerTask
	|
	|-RVA: 0x149B7B8 Offset: 0x14977B8 VA: 0x149B7B8
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.ProcessInnerTask
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool get_InvokeMayRunArbitraryCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149A1F0 Offset: 0x14961F0 VA: 0x149A1F0
	|-UnwrapPromise<object>.get_InvokeMayRunArbitraryCode
	|
	|-RVA: 0x149AC00 Offset: 0x1496C00 VA: 0x149AC00
	|-UnwrapPromise<VoidTaskResult>.get_InvokeMayRunArbitraryCode
	|
	|-RVA: 0x149B858 Offset: 0x1497858 VA: 0x149B858
	|-UnwrapPromise<__Il2CppFullySharedGenericType>.get_InvokeMayRunArbitraryCode
	*/
}

// Namespace: System.Threading.Tasks
internal sealed class ContinuationTaskFromTask : Task // TypeDefIndex: 592
{
	// Fields
	private Task m_antecedent; // 0x50

	// Methods

	// RVA: 0x1912D18 Offset: 0x190ED18 VA: 0x1912D18
	public void .ctor(Task antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }

	// RVA: 0x1915080 Offset: 0x1911080 VA: 0x1915080 Slot: 13
	internal override void InnerInvoke() { }
}

// Namespace: System.Threading.Tasks
internal sealed class ContinuationTaskFromResultTask<TAntecedentResult> : Task // TypeDefIndex: 593
{
	// Fields
	private Task<TAntecedentResult> m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task<TAntecedentResult> antecedent, Delegate action, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157735C Offset: 0x157335C VA: 0x157735C
	|-ContinuationTaskFromResultTask<Nullable<int>>..ctor
	|
	|-RVA: 0x157751C Offset: 0x157351C VA: 0x157751C
	|-ContinuationTaskFromResultTask<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x15776DC Offset: 0x15736DC VA: 0x15776DC
	|-ContinuationTaskFromResultTask<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x157789C Offset: 0x157389C VA: 0x157789C
	|-ContinuationTaskFromResultTask<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x1577A5C Offset: 0x1573A5C VA: 0x1577A5C
	|-ContinuationTaskFromResultTask<bool>..ctor
	|
	|-RVA: 0x1577C1C Offset: 0x1573C1C VA: 0x1577C1C
	|-ContinuationTaskFromResultTask<int>..ctor
	|
	|-RVA: 0x1577DDC Offset: 0x1573DDC VA: 0x1577DDC
	|-ContinuationTaskFromResultTask<object>..ctor
	|
	|-RVA: 0x1577F9C Offset: 0x1573F9C VA: 0x1577F9C
	|-ContinuationTaskFromResultTask<VoidTaskResult>..ctor
	|
	|-RVA: 0x157815C Offset: 0x157415C VA: 0x157815C
	|-ContinuationTaskFromResultTask<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1577420 Offset: 0x1573420 VA: 0x1577420
	|-ContinuationTaskFromResultTask<Nullable<int>>.InnerInvoke
	|
	|-RVA: 0x15775E0 Offset: 0x15735E0 VA: 0x15775E0
	|-ContinuationTaskFromResultTask<ValueTuple<bool, object>>.InnerInvoke
	|
	|-RVA: 0x15777A0 Offset: 0x15737A0 VA: 0x15777A0
	|-ContinuationTaskFromResultTask<ValueTuple<object, object, int>>.InnerInvoke
	|
	|-RVA: 0x1577960 Offset: 0x1573960 VA: 0x1577960
	|-ContinuationTaskFromResultTask<ValueTuple<object, bool, bool, object, object>>.InnerInvoke
	|
	|-RVA: 0x1577B20 Offset: 0x1573B20 VA: 0x1577B20
	|-ContinuationTaskFromResultTask<bool>.InnerInvoke
	|
	|-RVA: 0x1577CE0 Offset: 0x1573CE0 VA: 0x1577CE0
	|-ContinuationTaskFromResultTask<int>.InnerInvoke
	|
	|-RVA: 0x1577EA0 Offset: 0x1573EA0 VA: 0x1577EA0
	|-ContinuationTaskFromResultTask<object>.InnerInvoke
	|
	|-RVA: 0x1578060 Offset: 0x1574060 VA: 0x1578060
	|-ContinuationTaskFromResultTask<VoidTaskResult>.InnerInvoke
	|
	|-RVA: 0x1578220 Offset: 0x1574220 VA: 0x1578220
	|-ContinuationTaskFromResultTask<__Il2CppFullySharedGenericType>.InnerInvoke
	*/
}

// Namespace: System.Threading.Tasks
internal sealed class ContinuationResultTaskFromResultTask<TAntecedentResult, TResult> : Task<TResult> // TypeDefIndex: 594
{
	// Fields
	private Task<TAntecedentResult> m_antecedent; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Task<TAntecedentResult> antecedent, Delegate function, object state, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1576D40 Offset: 0x1572D40 VA: 0x1576D40
	|-ContinuationResultTaskFromResultTask<int, Nullable<int>>..ctor
	|
	|-RVA: 0x1576F00 Offset: 0x1572F00 VA: 0x1576F00
	|-ContinuationResultTaskFromResultTask<object, Nullable<int>>..ctor
	|
	|-RVA: 0x15770C0 Offset: 0x15730C0 VA: 0x15770C0
	|-ContinuationResultTaskFromResultTask<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 13
	internal override void InnerInvoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1576E14 Offset: 0x1572E14 VA: 0x1576E14
	|-ContinuationResultTaskFromResultTask<int, Nullable<int>>.InnerInvoke
	|
	|-RVA: 0x1576FD4 Offset: 0x1572FD4 VA: 0x1576FD4
	|-ContinuationResultTaskFromResultTask<object, Nullable<int>>.InnerInvoke
	|
	|-RVA: 0x15771A4 Offset: 0x15731A4 VA: 0x15771A4
	|-ContinuationResultTaskFromResultTask<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InnerInvoke
	*/
}

// Namespace: System.Threading.Tasks
internal abstract class TaskContinuation // TypeDefIndex: 595
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void Run(Task completedTask, bool bCanInlineContinuationTask);

	// RVA: 0x191515C Offset: 0x191115C VA: 0x191515C
	protected static void InlineIfPossibleOrElseQueue(Task task, bool needsProtection) { }

	// RVA: 0x19152A0 Offset: 0x19112A0 VA: 0x19152A0
	protected void .ctor() { }
}

// Namespace: System.Threading.Tasks
internal class StandardTaskContinuation : TaskContinuation // TypeDefIndex: 596
{
	// Fields
	internal readonly Task m_task; // 0x10
	internal readonly TaskContinuationOptions m_options; // 0x18
	private readonly TaskScheduler m_taskScheduler; // 0x20

	// Methods

	// RVA: 0x19130A4 Offset: 0x190F0A4 VA: 0x19130A4
	internal void .ctor(Task task, TaskContinuationOptions options, TaskScheduler scheduler) { }

	// RVA: 0x19152A8 Offset: 0x19112A8 VA: 0x19152A8 Slot: 4
	internal override void Run(Task completedTask, bool bCanInlineContinuationTask) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SynchronizationContextAwaitTaskContinuation.<>c // TypeDefIndex: 597
{
	// Fields
	public static readonly SynchronizationContextAwaitTaskContinuation.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1915A30 Offset: 0x1911A30 VA: 0x1915A30
	private static void .cctor() { }

	// RVA: 0x1915A98 Offset: 0x1911A98 VA: 0x1915A98
	public void .ctor() { }

	// RVA: 0x1915AA0 Offset: 0x1911AA0 VA: 0x1915AA0
	internal void <.cctor>b__7_0(object state) { }
}

// Namespace: System.Threading.Tasks
internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 598
{
	// Fields
	private static readonly SendOrPostCallback s_postCallback; // 0x0
	private static ContextCallback s_postActionCallback; // 0x8
	private readonly SynchronizationContext m_syncContext; // 0x20

	// Methods

	// RVA: 0x1911664 Offset: 0x190D664 VA: 0x1911664
	internal void .ctor(SynchronizationContext context, Action action, bool flowExecutionContext) { }

	// RVA: 0x19154E8 Offset: 0x19114E8 VA: 0x19154E8 Slot: 4
	internal sealed override void Run(Task ignored, bool canInlineContinuationTask) { }

	// RVA: 0x1915804 Offset: 0x1911804 VA: 0x1915804
	private static void PostAction(object state) { }

	// RVA: 0x1915898 Offset: 0x1911898 VA: 0x1915898
	private static ContextCallback GetPostActionCallback() { }

	// RVA: 0x1915960 Offset: 0x1911960 VA: 0x1915960
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TaskSchedulerAwaitTaskContinuation.<>c // TypeDefIndex: 599
{
	// Fields
	public static readonly TaskSchedulerAwaitTaskContinuation.<>c <>9; // 0x0
	public static Action<object> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x1915EFC Offset: 0x1911EFC VA: 0x1915EFC
	private static void .cctor() { }

	// RVA: 0x1915F64 Offset: 0x1911F64 VA: 0x1915F64
	public void .ctor() { }

	// RVA: 0x1915F6C Offset: 0x1911F6C VA: 0x1915F6C
	internal void <Run>b__2_0(object state) { }
}

// Namespace: System.Threading.Tasks
internal sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation // TypeDefIndex: 600
{
	// Fields
	private readonly TaskScheduler m_scheduler; // 0x20

	// Methods

	// RVA: 0x191173C Offset: 0x190D73C VA: 0x191173C
	internal void .ctor(TaskScheduler scheduler, Action action, bool flowExecutionContext) { }

	// RVA: 0x1915B0C Offset: 0x1911B0C VA: 0x1915B0C Slot: 4
	internal sealed override void Run(Task ignored, bool canInlineContinuationTask) { }
}

// Namespace: System.Threading.Tasks
internal class AwaitTaskContinuation : TaskContinuation, IThreadPoolWorkItem // TypeDefIndex: 601
{
	// Fields
	private readonly ExecutionContext m_capturedContext; // 0x10
	protected readonly Action m_action; // 0x18
	private static ContextCallback s_invokeActionCallback; // 0x0

	// Properties
	internal static bool IsValidLocationForInlining { get; }

	// Methods

	// RVA: 0x1915444 Offset: 0x1911444 VA: 0x1915444
	internal void .ctor(Action action, bool flowExecutionContext) { }

	// RVA: 0x1915E74 Offset: 0x1911E74 VA: 0x1915E74
	protected Task CreateTask(Action<object> action, object state, TaskScheduler scheduler) { }

	// RVA: 0x1915D50 Offset: 0x1911D50 VA: 0x1915D50 Slot: 4
	internal override void Run(Task ignored, bool canInlineContinuationTask) { }

	// RVA: 0x19160B4 Offset: 0x19120B4 VA: 0x19160B4
	internal static bool get_IsValidLocationForInlining() { }

	// RVA: 0x19161DC Offset: 0x19121DC VA: 0x19161DC Slot: 5
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x1916310 Offset: 0x1912310 VA: 0x1916310
	private static void InvokeAction(object state) { }

	// RVA: 0x191637C Offset: 0x191237C VA: 0x191637C
	protected static ContextCallback GetInvokeActionCallback() { }

	// RVA: 0x191565C Offset: 0x191165C VA: 0x191565C
	protected void RunCallback(ContextCallback callback, object state, ref Task currentTask) { }

	// RVA: 0x1912760 Offset: 0x190E760 VA: 0x1912760
	internal static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask) { }

	// RVA: 0x1911804 Offset: 0x190D804 VA: 0x1911804
	internal static void UnsafeScheduleAction(Action action) { }

	// RVA: 0x191605C Offset: 0x191205C VA: 0x191605C
	protected static void ThrowAsyncIfNecessary(Exception exc) { }

	// RVA: 0x191642C Offset: 0x191242C VA: 0x191642C Slot: 6
	public void MarkAborted(ThreadAbortException e) { }
}

// Namespace: System.Threading.Tasks
internal class TaskExceptionHolder // TypeDefIndex: 602
{
	// Fields
	private static readonly bool s_failFastOnUnobservedException; // 0x0
	private readonly Task m_task; // 0x10
	private LowLevelListWithIList<ExceptionDispatchInfo> m_faultExceptions; // 0x18
	private ExceptionDispatchInfo m_cancellationException; // 0x20
	private bool m_isHandled; // 0x28

	// Properties
	internal bool ContainsFaultList { get; }

	// Methods

	// RVA: 0x190F934 Offset: 0x190B934 VA: 0x190F934
	internal void .ctor(Task task) { }

	// RVA: 0x1916430 Offset: 0x1912430 VA: 0x1916430
	private static bool ShouldFailFastOnUnobservedException() { }

	// RVA: 0x1916438 Offset: 0x1912438 VA: 0x1916438 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x190F528 Offset: 0x190B528 VA: 0x190F528
	internal bool get_ContainsFaultList() { }

	// RVA: 0x190F964 Offset: 0x190B964 VA: 0x190F964
	internal void Add(object exceptionObject, bool representsCancellation) { }

	// RVA: 0x19167EC Offset: 0x19127EC VA: 0x19167EC
	private void SetCancellationException(object exceptionObject) { }

	// RVA: 0x19168B0 Offset: 0x19128B0 VA: 0x19168B0
	private void AddFaultException(object exceptionObject) { }

	// RVA: 0x1916D80 Offset: 0x1912D80 VA: 0x1916D80
	private void MarkAsUnhandled() { }

	// RVA: 0x190F708 Offset: 0x190B708 VA: 0x190F708
	internal void MarkAsHandled(bool calledFromFinalizer) { }

	// RVA: 0x190F970 Offset: 0x190B970 VA: 0x190F970
	internal AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException) { }

	// RVA: 0x190FC6C Offset: 0x190BC6C VA: 0x190FC6C
	internal ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos() { }

	// RVA: 0x1916DF0 Offset: 0x1912DF0 VA: 0x1916DF0
	internal ExceptionDispatchInfo GetCancellationExceptionDispatchInfo() { }

	// RVA: 0x1916DF8 Offset: 0x1912DF8 VA: 0x1916DF8
	private static void .cctor() { }
}

// Namespace: 
internal sealed class TaskFactory.CompleteOnInvokePromise : Task<Task>, ITaskCompletionAction // TypeDefIndex: 603
{
	// Fields
	private IList<Task> _tasks; // 0x58

	// Properties
	public bool InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: 0x191717C Offset: 0x191317C VA: 0x191717C
	public void .ctor(IList<Task> tasks) { }

	// RVA: 0x191729C Offset: 0x191329C VA: 0x191729C Slot: 14
	public void Invoke(Task completingTask) { }

	// RVA: 0x19174E8 Offset: 0x19134E8 VA: 0x19174E8 Slot: 15
	public bool get_InvokeMayRunArbitraryCode() { }
}

// Namespace: System.Threading.Tasks
public class TaskFactory // TypeDefIndex: 604
{
	// Fields
	private readonly CancellationToken m_defaultCancellationToken; // 0x10
	private readonly TaskScheduler m_defaultScheduler; // 0x18
	private readonly TaskCreationOptions m_defaultCreationOptions; // 0x20
	private readonly TaskContinuationOptions m_defaultContinuationOptions; // 0x24

	// Methods

	// RVA: 0x1914C40 Offset: 0x1910C40 VA: 0x1914C40
	public void .ctor() { }

	// RVA: 0x1916E40 Offset: 0x1912E40 VA: 0x1916E40
	public void .ctor(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler) { }

	// RVA: 0x1916FA8 Offset: 0x1912FA8 VA: 0x1916FA8
	internal static void CheckCreationOptions(TaskCreationOptions creationOptions) { }

	// RVA: 0x1917004 Offset: 0x1913004 VA: 0x1917004
	public Task StartNew(Action<object> action, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew<TResult>(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1037D00 Offset: 0x1033D00 VA: 0x1037D00
	|-TaskFactory.StartNew<object>
	|
	|-RVA: 0x1037D94 Offset: 0x1033D94 VA: 0x1037D94
	|-TaskFactory.StartNew<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> StartNew<TResult>(Func<object, TResult> function, object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1037E2C Offset: 0x1033E2C VA: 0x1037E2C
	|-TaskFactory.StartNew<bool>
	|
	|-RVA: 0x1037ED0 Offset: 0x1033ED0 VA: 0x1037ED0
	|-TaskFactory.StartNew<object>
	|
	|-RVA: 0x1037F74 Offset: 0x1033F74 VA: 0x1037F74
	|-TaskFactory.StartNew<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10376B4 Offset: 0x10336B4 VA: 0x10376B4
	|-TaskFactory.FromAsync<object>
	|
	|-RVA: 0x103771C Offset: 0x103371C VA: 0x103771C
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1037820 Offset: 0x1033820 VA: 0x1037820
	|-TaskFactory.FromAsync<object>
	|
	|-RVA: 0x103788C Offset: 0x103388C VA: 0x103788C
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103798C Offset: 0x103398C VA: 0x103798C
	|-TaskFactory.FromAsync<object, int>
	|
	|-RVA: 0x10379FC Offset: 0x10339FC VA: 0x10379FC
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task FromAsync<TArg1, TArg2>(Func<TArg1, TArg2, AsyncCallback, object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, TArg2 arg2, object state, TaskCreationOptions creationOptions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1037B44 Offset: 0x1033B44 VA: 0x1037B44
	|-TaskFactory.FromAsync<object, int>
	|
	|-RVA: 0x1037BB8 Offset: 0x1033BB8 VA: 0x1037BB8
	|-TaskFactory.FromAsync<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1917094 Offset: 0x1913094 VA: 0x1917094
	internal static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod) { }

	// RVA: 0x1913FE8 Offset: 0x190FFE8 VA: 0x1913FE8
	internal static Task<Task> CommonCWAnyLogic(IList<Task> tasks) { }

	// RVA: 0x1916EAC Offset: 0x1912EAC VA: 0x1916EAC
	internal static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions) { }
}

// Namespace: 
internal sealed class TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView // TypeDefIndex: 605
{}

// Namespace: System.Threading.Tasks
[DebuggerDisplay("Id={Id}")]
[DebuggerTypeProxy(typeof(TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView))]
public abstract class TaskScheduler // TypeDefIndex: 606
{
	// Fields
	private static readonly TaskScheduler s_defaultTaskScheduler; // 0x0
	internal static int s_taskSchedulerIdCounter; // 0x8
	private int m_taskSchedulerId; // 0x10
	private static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException; // 0x10
	private static readonly Lock _unobservedTaskExceptionLockObject; // 0x18

	// Properties
	internal virtual bool RequiresAtomicStartTransition { get; }
	public static TaskScheduler Default { get; }
	public static TaskScheduler Current { get; }
	internal static TaskScheduler InternalCurrent { get; }
	public int Id { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected internal abstract void QueueTask(Task task);

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued);

	// RVA: 0x1912038 Offset: 0x190E038 VA: 0x1912038
	internal bool TryRunInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x19174F0 Offset: 0x19134F0 VA: 0x19174F0 Slot: 6
	protected internal virtual bool TryDequeue(Task task) { }

	// RVA: 0x19174F8 Offset: 0x19134F8 VA: 0x19174F8 Slot: 7
	internal virtual void NotifyWorkItemProgress() { }

	// RVA: 0x19174FC Offset: 0x19134FC VA: 0x19174FC Slot: 8
	internal virtual bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x1917504 Offset: 0x1913504 VA: 0x1917504
	protected void .ctor() { }

	// RVA: 0x191750C Offset: 0x191350C VA: 0x191750C
	public static TaskScheduler get_Default() { }

	// RVA: 0x1912A04 Offset: 0x190EA04 VA: 0x1912A04
	public static TaskScheduler get_Current() { }

	// RVA: 0x1911698 Offset: 0x190D698 VA: 0x1911698
	internal static TaskScheduler get_InternalCurrent() { }

	// RVA: 0x191221C Offset: 0x190E21C VA: 0x191221C
	public int get_Id() { }

	// RVA: 0x19166A0 Offset: 0x19126A0 VA: 0x19166A0
	internal static void PublishUnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs ueea) { }

	// RVA: 0x1917564 Offset: 0x1913564 VA: 0x1917564
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
public class UnobservedTaskExceptionEventArgs : EventArgs // TypeDefIndex: 607
{
	// Fields
	private AggregateException m_exception; // 0x10
	internal bool m_observed; // 0x18

	// Methods

	// RVA: 0x191662C Offset: 0x191262C VA: 0x191662C
	public void .ctor(AggregateException exception) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ThreadPoolTaskScheduler.<>c // TypeDefIndex: 608
{
	// Fields
	public static readonly ThreadPoolTaskScheduler.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1917A10 Offset: 0x1913A10 VA: 0x1917A10
	private static void .cctor() { }

	// RVA: 0x1917A78 Offset: 0x1913A78 VA: 0x1917A78
	public void .ctor() { }

	// RVA: 0x1917A80 Offset: 0x1913A80 VA: 0x1917A80
	internal void <.cctor>b__10_0(object s) { }
}

// Namespace: System.Threading.Tasks
internal sealed class ThreadPoolTaskScheduler : TaskScheduler // TypeDefIndex: 609
{
	// Fields
	private static readonly ParameterizedThreadStart s_longRunningThreadWork; // 0x0

	// Properties
	internal override bool RequiresAtomicStartTransition { get; }

	// Methods

	// RVA: 0x1917620 Offset: 0x1913620 VA: 0x1917620
	internal void .ctor() { }

	// RVA: 0x1917678 Offset: 0x1913678 VA: 0x1917678 Slot: 4
	protected internal override void QueueTask(Task task) { }

	// RVA: 0x1917844 Offset: 0x1913844 VA: 0x1917844 Slot: 5
	protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued) { }

	// RVA: 0x1917920 Offset: 0x1913920 VA: 0x1917920 Slot: 6
	protected internal override bool TryDequeue(Task task) { }

	// RVA: 0x1917928 Offset: 0x1913928 VA: 0x1917928 Slot: 7
	internal override void NotifyWorkItemProgress() { }

	// RVA: 0x1917938 Offset: 0x1913938 VA: 0x1917938 Slot: 8
	internal override bool get_RequiresAtomicStartTransition() { }

	// RVA: 0x1917940 Offset: 0x1913940 VA: 0x1917940
	private static void .cctor() { }
}

// Namespace: System.Threading.Tasks
[FriendAccessAllowed]
internal enum CausalityTraceLevel // TypeDefIndex: 610
{
	// Fields
	public int value__; // 0x0
	public const CausalityTraceLevel Required = 0;
	public const CausalityTraceLevel Important = 1;
	public const CausalityTraceLevel Verbose = 2;
}

// Namespace: System.Threading.Tasks
[FriendAccessAllowed]
internal enum AsyncCausalityStatus // TypeDefIndex: 611
{
	// Fields
	public int value__; // 0x0
	public const AsyncCausalityStatus Started = 0;
	public const AsyncCausalityStatus Completed = 1;
	public const AsyncCausalityStatus Canceled = 2;
	public const AsyncCausalityStatus Error = 3;
}

// Namespace: System.Threading.Tasks
internal enum CausalityRelation // TypeDefIndex: 612
{
	// Fields
	public int value__; // 0x0
	public const CausalityRelation AssignDelegate = 0;
	public const CausalityRelation Join = 1;
	public const CausalityRelation Choice = 2;
	public const CausalityRelation Cancel = 3;
	public const CausalityRelation Error = 4;
}

// Namespace: System.Threading.Tasks
internal enum CausalitySynchronousWork // TypeDefIndex: 613
{
	// Fields
	public int value__; // 0x0
	public const CausalitySynchronousWork CompletionNotification = 0;
	public const CausalitySynchronousWork ProgressNotification = 1;
	public const CausalitySynchronousWork Execution = 2;
}

// Namespace: System.Threading.Tasks
[FriendAccessAllowed]
internal static class AsyncCausalityTracer // TypeDefIndex: 614
{
	// Properties
	[FriendAccessAllowed]
	internal static bool LoggingOn { get; }

	// Methods

	[FriendAccessAllowed]
	// RVA: 0x1914900 Offset: 0x1910900 VA: 0x1914900
	internal static bool get_LoggingOn() { }

	[FriendAccessAllowed]
	// RVA: 0x1917B04 Offset: 0x1913B04 VA: 0x1917B04
	internal static void TraceOperationCreation(CausalityTraceLevel traceLevel, int taskId, string operationName, ulong relatedContext) { }

	[FriendAccessAllowed]
	// RVA: 0x1917B08 Offset: 0x1913B08 VA: 0x1917B08
	internal static void TraceOperationCompletion(CausalityTraceLevel traceLevel, int taskId, AsyncCausalityStatus status) { }

	// RVA: 0x1917B0C Offset: 0x1913B0C VA: 0x1917B0C
	internal static void TraceSynchronousWorkStart(CausalityTraceLevel traceLevel, int taskId, CausalitySynchronousWork work) { }

	// RVA: 0x1914908 Offset: 0x1910908 VA: 0x1914908
	internal static void TraceSynchronousWorkCompletion(CausalityTraceLevel traceLevel, CausalitySynchronousWork work) { }
}

// Namespace: System.Threading.Tasks
internal static class TaskToApm // TypeDefIndex: 7649
{
	// Methods

	// RVA: 0x1B21E00 Offset: 0x1B1DE00 VA: 0x1B21E00
	public static IAsyncResult Begin(Task task, AsyncCallback callback, object state) { }

	// RVA: 0x1B2204C Offset: 0x1B1E04C VA: 0x1B2204C
	public static void End(IAsyncResult asyncResult) { }

	// RVA: -1 Offset: -1
	public static TResult End<TResult>(IAsyncResult asyncResult) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103801C Offset: 0x103401C VA: 0x103801C
	|-TaskToApm.End<int>
	|
	|-RVA: 0x103811C Offset: 0x103411C VA: 0x103811C
	|-TaskToApm.End<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1B21F44 Offset: 0x1B1DF44 VA: 0x1B21F44
	private static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult) { }
}
