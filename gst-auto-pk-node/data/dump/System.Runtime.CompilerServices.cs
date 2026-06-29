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

// Namespace: System.Runtime.CompilerServices
[Usage(5148, Inherited = False, AllowMultiple = False)]
public sealed class AsyncMethodBuilderAttribute : Attribute // TypeDefIndex: 1093
{
	// Fields
	[CompilerGenerated]
	private readonly Type <BuilderType>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17D1E50 Offset: 0x17CDE50 VA: 0x17D1E50
	public void .ctor(Type builderType) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(64, Inherited = False, AllowMultiple = False)]
[Serializable]
public sealed class AsyncStateMachineAttribute : StateMachineAttribute // TypeDefIndex: 1094
{
	// Methods

	// RVA: 0x17D1E80 Offset: 0x17CDE80 VA: 0x17D1E80
	public void .ctor(Type stateMachineType) { }
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncValueTaskMethodBuilder // TypeDefIndex: 1095
{
	// Fields
	private AsyncTaskMethodBuilder _methodBuilder; // 0x0
	private bool _haveResult; // 0x18
	private bool _useBuilder; // 0x19
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncValueTaskMethodBuilder<TResult> // TypeDefIndex: 1096
{
	// Fields
	private AsyncTaskMethodBuilder<TResult> _methodBuilder; // 0x0
	private TResult _result; // 0x0
	private bool _haveResult; // 0x0
	private bool _useBuilder; // 0x0

	// Properties
	public ValueTask<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncValueTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D67A8 Offset: 0x14D27A8 VA: 0x14D67A8
	|-AsyncValueTaskMethodBuilder<int>.Create
	|
	|-RVA: 0x14D6A60 Offset: 0x14D2A60 VA: 0x14D6A60
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1004B38 Offset: 0x1000B38 VA: 0x1004B38
	|-AsyncValueTaskMethodBuilder<int>.Start<Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0x1004C98 Offset: 0x1000C98 VA: 0x1004C98
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.Start<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D67B4 Offset: 0x14D27B4 VA: 0x14D67B4
	|-AsyncValueTaskMethodBuilder<int>.SetStateMachine
	|
	|-RVA: 0x14D6AA0 Offset: 0x14D2AA0 VA: 0x14D6AA0
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D6834 Offset: 0x14D2834 VA: 0x14D6834
	|-AsyncValueTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x14D6B9C Offset: 0x14D2B9C VA: 0x14D6B9C
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D68D0 Offset: 0x14D28D0 VA: 0x14D68D0
	|-AsyncValueTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x14D6E84 Offset: 0x14D2E84 VA: 0x14D6E84
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetException
	*/

	// RVA: -1 Offset: -1
	public ValueTask<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D6954 Offset: 0x14D2954 VA: 0x14D6954
	|-AsyncValueTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0x14D6F80 Offset: 0x14D2F80 VA: 0x14D6F80
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1004AA8 Offset: 0x1000AA8 VA: 0x1004AA8
	|-AsyncValueTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0x1004BA8 Offset: 0x1000BA8 VA: 0x1004BA8
	|-AsyncValueTaskMethodBuilder<__Il2CppFullySharedGenericType>.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Runtime.CompilerServices
[Usage(2048, Inherited = False)]
public sealed class CallerMemberNameAttribute : Attribute // TypeDefIndex: 1097
{
	// Methods

	// RVA: 0x17D1EE0 Offset: 0x17CDEE0 VA: 0x17D1EE0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(32767, Inherited = True)]
[Serializable]
public sealed class CompilerGeneratedAttribute : Attribute // TypeDefIndex: 1098
{
	// Methods

	// RVA: 0x17D1EE8 Offset: 0x17CDEE8 VA: 0x17D1EE8
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(2304, Inherited = False)]
[Serializable]
public abstract class CustomConstantAttribute : Attribute // TypeDefIndex: 1099
{
	// Properties
	public abstract object Value { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract object get_Value();

	// RVA: 0x17D1EF0 Offset: 0x17CDEF0 VA: 0x17D1EF0
	protected void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(2304, Inherited = False)]
[Serializable]
public sealed class DateTimeConstantAttribute : CustomConstantAttribute // TypeDefIndex: 1100
{
	// Fields
	private DateTime _date; // 0x10

	// Properties
	public override object Value { get; }

	// Methods

	// RVA: 0x17D1EF8 Offset: 0x17CDEF8 VA: 0x17D1EF8 Slot: 7
	public override object get_Value() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(2304, Inherited = False)]
[Serializable]
public sealed class DecimalConstantAttribute : Attribute // TypeDefIndex: 1101
{
	// Fields
	private Decimal _dec; // 0x10

	// Properties
	public Decimal Value { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x17D1F54 Offset: 0x17CDF54 VA: 0x17D1F54
	public void .ctor(byte scale, byte sign, uint hi, uint mid, uint low) { }

	// RVA: 0x17D1FF0 Offset: 0x17CDFF0 VA: 0x17D1FF0
	public Decimal get_Value() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(69)]
public sealed class ExtensionAttribute : Attribute // TypeDefIndex: 1102
{
	// Methods

	// RVA: 0x17D1FFC Offset: 0x17CDFFC VA: 0x17D1FFC
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(256, Inherited = False)]
public sealed class FixedBufferAttribute : Attribute // TypeDefIndex: 1103
{
	// Fields
	[CompilerGenerated]
	private readonly Type <ElementType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <Length>k__BackingField; // 0x18

	// Properties
	public Type ElementType { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x17D2004 Offset: 0x17CE004 VA: 0x17D2004
	public void .ctor(Type elementType, int length) { }

	[CompilerGenerated]
	// RVA: 0x17D2040 Offset: 0x17CE040 VA: 0x17D2040
	public Type get_ElementType() { }

	[CompilerGenerated]
	// RVA: 0x17D2048 Offset: 0x17CE048 VA: 0x17D2048
	public int get_Length() { }
}

// Namespace: 
private sealed class FormattableStringFactory.ConcreteFormattableString : FormattableString // TypeDefIndex: 1104
{
	// Fields
	private readonly string _format; // 0x10
	private readonly object[] _arguments; // 0x18

	// Properties
	public override string Format { get; }
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x17D2120 Offset: 0x17CE120 VA: 0x17D2120
	internal void .ctor(string format, object[] arguments) { }

	// RVA: 0x17D2164 Offset: 0x17CE164 VA: 0x17D2164 Slot: 5
	public override string get_Format() { }

	// RVA: 0x17D216C Offset: 0x17CE16C VA: 0x17D216C Slot: 6
	public override object[] GetArguments() { }

	// RVA: 0x17D2174 Offset: 0x17CE174 VA: 0x17D2174 Slot: 7
	public override int get_ArgumentCount() { }

	// RVA: 0x17D218C Offset: 0x17CE18C VA: 0x17D218C Slot: 8
	public override object GetArgument(int index) { }

	// RVA: 0x17D21BC Offset: 0x17CE1BC VA: 0x17D21BC Slot: 9
	public override string ToString(IFormatProvider formatProvider) { }
}

// Namespace: System.Runtime.CompilerServices
public static class FormattableStringFactory // TypeDefIndex: 1105
{
	// Methods

	// RVA: 0x17D2050 Offset: 0x17CE050 VA: 0x17D2050
	public static FormattableString Create(string format, object[] arguments) { }
}

// Namespace: System.Runtime.CompilerServices
public interface IAsyncStateMachine // TypeDefIndex: 1106
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void MoveNext();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetStateMachine(IAsyncStateMachine stateMachine);
}

// Namespace: System.Runtime.CompilerServices
public interface ICriticalNotifyCompletion // TypeDefIndex: 1107
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void UnsafeOnCompleted(Action continuation);
}

// Namespace: System.Runtime.CompilerServices
[DefaultMember("Item")]
public interface ITuple // TypeDefIndex: 1108
{
	// Properties
	public abstract int Length { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Length();
}

// Namespace: System.Runtime.CompilerServices
[Usage(364, Inherited = False)]
internal sealed class IntrinsicAttribute : Attribute // TypeDefIndex: 1109
{
	// Methods

	// RVA: 0x17D21D0 Offset: 0x17CE1D0 VA: 0x17D21D0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(8)]
public sealed class IsByRefLikeAttribute : Attribute // TypeDefIndex: 1110
{
	// Methods

	// RVA: 0x17D21D8 Offset: 0x17CE1D8 VA: 0x17D21D8
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(32767, Inherited = False)]
public sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 1111
{
	// Methods

	// RVA: 0x17D21E0 Offset: 0x17CE1E0 VA: 0x17D21E0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
public static class IsVolatile // TypeDefIndex: 1112
{}

// Namespace: System.Runtime.CompilerServices
[Usage(64, Inherited = False, AllowMultiple = False)]
[Serializable]
public sealed class IteratorStateMachineAttribute : StateMachineAttribute // TypeDefIndex: 1113
{
	// Methods

	// RVA: 0x17D21E8 Offset: 0x17CE1E8 VA: 0x17D21E8
	public void .ctor(Type stateMachineType) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1, Inherited = False, AllowMultiple = False)]
[Serializable]
public sealed class RuntimeCompatibilityAttribute : Attribute // TypeDefIndex: 1114
{
	// Fields
	[CompilerGenerated]
	private bool <WrapNonExceptionThrows>k__BackingField; // 0x10

	// Properties
	public bool WrapNonExceptionThrows { set; }

	// Methods

	// RVA: 0x17D2218 Offset: 0x17CE218 VA: 0x17D2218
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x17D2220 Offset: 0x17CE220 VA: 0x17D2220
	public void set_WrapNonExceptionThrows(bool value) { }
}

// Namespace: System.Runtime.CompilerServices
public static class RuntimeFeature // TypeDefIndex: 1115
{
	// Properties
	public static bool IsDynamicCodeSupported { get; }

	// Methods

	// RVA: 0x17D2228 Offset: 0x17CE228 VA: 0x17D2228
	public static bool get_IsDynamicCodeSupported() { }
}

// Namespace: System.Runtime.CompilerServices
[Serializable]
public sealed class RuntimeWrappedException : Exception // TypeDefIndex: 1116
{
	// Fields
	private object _wrappedException; // 0x90

	// Properties
	public object WrappedException { get; }

	// Methods

	// RVA: 0x17D2230 Offset: 0x17CE230 VA: 0x17D2230
	public void .ctor(object thrownObject) { }

	// RVA: 0x17D22C8 Offset: 0x17CE2C8 VA: 0x17D22C8
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17D23B0 Offset: 0x17CE3B0 VA: 0x17D23B0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17D2464 Offset: 0x17CE464 VA: 0x17D2464
	public object get_WrappedException() { }

	// RVA: 0x17D246C Offset: 0x17CE46C VA: 0x17D246C
	internal void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(64, Inherited = False, AllowMultiple = False)]
[Serializable]
public class StateMachineAttribute : Attribute // TypeDefIndex: 1117
{
	// Fields
	[CompilerGenerated]
	private readonly Type <StateMachineType>k__BackingField; // 0x10

	// Properties
	public Type StateMachineType { get; }

	// Methods

	// RVA: 0x17D1EB0 Offset: 0x17CDEB0 VA: 0x17D1EB0
	public void .ctor(Type stateMachineType) { }

	[CompilerGenerated]
	// RVA: 0x17D24A4 Offset: 0x17CE4A4 VA: 0x17D24A4
	public Type get_StateMachineType() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1, Inherited = False)]
[Serializable]
public sealed class StringFreezingAttribute : Attribute // TypeDefIndex: 1118
{
	// Methods

	// RVA: 0x17D24AC Offset: 0x17CE4AC VA: 0x17D24AC
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CLSCompliant(False)]
[Usage(11148)]
public sealed class TupleElementNamesAttribute : Attribute // TypeDefIndex: 1119
{
	// Fields
	private readonly string[] _transformNames; // 0x10

	// Methods

	// RVA: 0x17D24B4 Offset: 0x17CE4B4 VA: 0x17D24B4
	public void .ctor(string[] transformNames) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(5148, Inherited = False, AllowMultiple = False)]
public sealed class TypeForwardedFromAttribute : Attribute // TypeDefIndex: 1120
{
	// Fields
	[CompilerGenerated]
	private readonly string <AssemblyFullName>k__BackingField; // 0x10

	// Properties
	public string AssemblyFullName { get; }

	// Methods

	// RVA: 0x17D2530 Offset: 0x17CE530 VA: 0x17D2530
	public void .ctor(string assemblyFullName) { }

	[CompilerGenerated]
	// RVA: 0x17D25B8 Offset: 0x17CE5B8 VA: 0x17D25B8
	public string get_AssemblyFullName() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(8)]
[Serializable]
public sealed class UnsafeValueTypeAttribute : Attribute // TypeDefIndex: 1121
{
	// Methods

	// RVA: 0x17D25C0 Offset: 0x17CE5C0 VA: 0x17D25C0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ValueTaskAwaiter.<>c // TypeDefIndex: 1122
{
	// Fields
	public static readonly ValueTaskAwaiter.<>c <>9; // 0x0

	// Methods

	// RVA: 0x17D2ABC Offset: 0x17CEABC VA: 0x17D2ABC
	private static void .cctor() { }

	// RVA: 0x17D2B24 Offset: 0x17CEB24 VA: 0x17D2B24
	public void .ctor() { }

	// RVA: 0x17D2B2C Offset: 0x17CEB2C VA: 0x17D2B2C
	internal void <.cctor>b__9_0(object state) { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ValueTaskAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 1123
{
	// Fields
	internal static readonly Action<object> s_invokeActionDelegate; // 0x0
	private readonly ValueTask _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x17D25C8 Offset: 0x17CE5C8 VA: 0x17D25C8
	internal void .ctor(ValueTask value) { }

	// RVA: 0x17D25D8 Offset: 0x17CE5D8 VA: 0x17D25D8
	public bool get_IsCompleted() { }

	[StackTraceHidden]
	// RVA: 0x17D2718 Offset: 0x17CE718 VA: 0x17D2718
	public void GetResult() { }

	// RVA: 0x17D2850 Offset: 0x17CE850 VA: 0x17D2850 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	// RVA: 0x17D29EC Offset: 0x17CE9EC VA: 0x17D29EC
	private static void .cctor() { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion // TypeDefIndex: 1124
{
	// Fields
	private readonly ValueTask<TResult> _value; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ValueTask<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ADBF4 Offset: 0x14A9BF4 VA: 0x14ADBF4
	|-ValueTaskAwaiter<int>..ctor
	|
	|-RVA: 0x14ADEA8 Offset: 0x14A9EA8 VA: 0x14ADEA8
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ADC04 Offset: 0x14A9C04 VA: 0x14ADC04
	|-ValueTaskAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0x14ADF94 Offset: 0x14A9F94 VA: 0x14ADF94
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	[StackTraceHidden]
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ADC3C Offset: 0x14A9C3C VA: 0x14ADC3C
	|-ValueTaskAwaiter<int>.GetResult
	|
	|-RVA: 0x14AE040 Offset: 0x14AA040 VA: 0x14AE040
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14ADC74 Offset: 0x14A9C74 VA: 0x14ADC74
	|-ValueTaskAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0x14AE198 Offset: 0x14AA198 VA: 0x14AE198
	|-ValueTaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class TaskAwaiter.<>c__DisplayClass11_0 // TypeDefIndex: 1125
{
	// Fields
	public Task task; // 0x10
	public Action continuation; // 0x18

	// Methods

	// RVA: 0x17D3048 Offset: 0x17CF048 VA: 0x17D3048
	public void .ctor() { }

	// RVA: 0x17D3050 Offset: 0x17CF050 VA: 0x17D3050
	internal void <OutputWaitEtwEvents>b__0() { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct TaskAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 1126
{
	// Fields
	internal readonly Task m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x17D2BA0 Offset: 0x17CEBA0 VA: 0x17D2BA0
	internal void .ctor(Task task) { }

	// RVA: 0x17D2BA8 Offset: 0x17CEBA8 VA: 0x17D2BA8
	public bool get_IsCompleted() { }

	// RVA: 0x17D29DC Offset: 0x17CE9DC VA: 0x17D29DC Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	[StackTraceHidden]
	// RVA: 0x17D2C70 Offset: 0x17CEC70 VA: 0x17D2C70
	public void GetResult() { }

	[StackTraceHidden]
	// RVA: 0x17D2C78 Offset: 0x17CEC78 VA: 0x17D2C78
	internal static void ValidateEnd(Task task) { }

	[StackTraceHidden]
	// RVA: 0x17D2CC4 Offset: 0x17CECC4 VA: 0x17D2CC4
	private static void HandleNonSuccessAndDebuggerNotification(Task task) { }

	[StackTraceHidden]
	// RVA: 0x17D2D24 Offset: 0x17CED24 VA: 0x17D2D24
	private static void ThrowForNonSuccess(Task task) { }

	// RVA: 0x17D2BC0 Offset: 0x17CEBC0 VA: 0x17D2BC0
	internal static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext) { }

	// RVA: 0x17D2E50 Offset: 0x17CEE50 VA: 0x17D2E50
	private static Action OutputWaitEtwEvents(Task task, Action continuation) { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct TaskAwaiter<TResult> : ICriticalNotifyCompletion // TypeDefIndex: 1127
{
	// Fields
	private readonly Task<TResult> m_task; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146D4C8 Offset: 0x14694C8 VA: 0x146D4C8
	|-TaskAwaiter<Nullable<int>>..ctor
	|
	|-RVA: 0x146D548 Offset: 0x1469548 VA: 0x146D548
	|-TaskAwaiter<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x146D5C8 Offset: 0x14695C8 VA: 0x146D5C8
	|-TaskAwaiter<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x146D658 Offset: 0x1469658 VA: 0x146D658
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x146D6E0 Offset: 0x14696E0 VA: 0x146D6E0
	|-TaskAwaiter<bool>..ctor
	|
	|-RVA: 0x146D760 Offset: 0x1469760 VA: 0x146D760
	|-TaskAwaiter<int>..ctor
	|
	|-RVA: 0x146D7E0 Offset: 0x14697E0 VA: 0x146D7E0
	|-TaskAwaiter<object>..ctor
	|
	|-RVA: 0x146D860 Offset: 0x1469860 VA: 0x146D860
	|-TaskAwaiter<VoidTaskResult>..ctor
	|
	|-RVA: 0x146D8E0 Offset: 0x14698E0 VA: 0x146D8E0
	|-TaskAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146D4D0 Offset: 0x14694D0 VA: 0x146D4D0
	|-TaskAwaiter<Nullable<int>>.get_IsCompleted
	|
	|-RVA: 0x146D550 Offset: 0x1469550 VA: 0x146D550
	|-TaskAwaiter<ValueTuple<bool, object>>.get_IsCompleted
	|
	|-RVA: 0x146D5D0 Offset: 0x14695D0 VA: 0x146D5D0
	|-TaskAwaiter<ValueTuple<object, object, int>>.get_IsCompleted
	|
	|-RVA: 0x146D660 Offset: 0x1469660 VA: 0x146D660
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.get_IsCompleted
	|
	|-RVA: 0x146D6E8 Offset: 0x14696E8 VA: 0x146D6E8
	|-TaskAwaiter<bool>.get_IsCompleted
	|
	|-RVA: 0x146D768 Offset: 0x1469768 VA: 0x146D768
	|-TaskAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0x146D7E8 Offset: 0x14697E8 VA: 0x146D7E8
	|-TaskAwaiter<object>.get_IsCompleted
	|
	|-RVA: 0x146D868 Offset: 0x1469868 VA: 0x146D868
	|-TaskAwaiter<VoidTaskResult>.get_IsCompleted
	|
	|-RVA: 0x146D8E8 Offset: 0x14698E8 VA: 0x146D8E8
	|-TaskAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146D4E8 Offset: 0x14694E8 VA: 0x146D4E8
	|-TaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|
	|-RVA: 0x146D568 Offset: 0x1469568 VA: 0x146D568
	|-TaskAwaiter<ValueTuple<bool, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x146D5E8 Offset: 0x14695E8 VA: 0x146D5E8
	|-TaskAwaiter<ValueTuple<object, object, int>>.UnsafeOnCompleted
	|
	|-RVA: 0x146D678 Offset: 0x1469678 VA: 0x146D678
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x146D700 Offset: 0x1469700 VA: 0x146D700
	|-TaskAwaiter<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x146D780 Offset: 0x1469780 VA: 0x146D780
	|-TaskAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0x146D800 Offset: 0x1469800 VA: 0x146D800
	|-TaskAwaiter<object>.UnsafeOnCompleted
	|
	|-RVA: 0x146D880 Offset: 0x1469880 VA: 0x146D880
	|-TaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	|
	|-RVA: 0x146D900 Offset: 0x1469900 VA: 0x146D900
	|-TaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/

	[StackTraceHidden]
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146D4FC Offset: 0x14694FC VA: 0x146D4FC
	|-TaskAwaiter<Nullable<int>>.GetResult
	|
	|-RVA: 0x146D57C Offset: 0x146957C VA: 0x146D57C
	|-TaskAwaiter<ValueTuple<bool, object>>.GetResult
	|
	|-RVA: 0x146D5FC Offset: 0x14695FC VA: 0x146D5FC
	|-TaskAwaiter<ValueTuple<object, object, int>>.GetResult
	|
	|-RVA: 0x146D68C Offset: 0x146968C VA: 0x146D68C
	|-TaskAwaiter<ValueTuple<object, bool, bool, object, object>>.GetResult
	|
	|-RVA: 0x146D714 Offset: 0x1469714 VA: 0x146D714
	|-TaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x146D794 Offset: 0x1469794 VA: 0x146D794
	|-TaskAwaiter<int>.GetResult
	|
	|-RVA: 0x146D814 Offset: 0x1469814 VA: 0x146D814
	|-TaskAwaiter<object>.GetResult
	|
	|-RVA: 0x146D894 Offset: 0x1469894 VA: 0x146D894
	|-TaskAwaiter<VoidTaskResult>.GetResult
	|
	|-RVA: 0x146D914 Offset: 0x1469914 VA: 0x146D914
	|-TaskAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/
}

// Namespace: 
[IsReadOnly]
public struct ConfiguredTaskAwaitable.ConfiguredTaskAwaiter : ICriticalNotifyCompletion // TypeDefIndex: 1128
{
	// Fields
	internal readonly Task m_task; // 0x0
	internal readonly bool m_continueOnCapturedContext; // 0x8

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x17D320C Offset: 0x17CF20C VA: 0x17D320C
	internal void .ctor(Task task, bool continueOnCapturedContext) { }

	// RVA: 0x17D3240 Offset: 0x17CF240 VA: 0x17D3240
	public bool get_IsCompleted() { }

	// RVA: 0x17D3258 Offset: 0x17CF258 VA: 0x17D3258 Slot: 5
	public void OnCompleted(Action continuation) { }

	// RVA: 0x17D326C Offset: 0x17CF26C VA: 0x17D326C Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }

	[StackTraceHidden]
	// RVA: 0x17D3280 Offset: 0x17CF280 VA: 0x17D3280
	public void GetResult() { }
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ConfiguredTaskAwaitable // TypeDefIndex: 1129
{
	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: 0x17D31C4 Offset: 0x17CF1C4 VA: 0x17D31C4
	internal void .ctor(Task task, bool continueOnCapturedContext) { }

	// RVA: 0x17D3234 Offset: 0x17CF234 VA: 0x17D3234
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter GetAwaiter() { }
}

// Namespace: 
[IsReadOnly]
public struct ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> : ICriticalNotifyCompletion // TypeDefIndex: 1130
{
	// Fields
	private readonly Task<TResult> m_task; // 0x0
	private readonly bool m_continueOnCapturedContext; // 0x0

	// Properties
	public bool IsCompleted { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1576458 Offset: 0x1572458 VA: 0x1576458
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>..ctor
	|
	|-RVA: 0x15764FC Offset: 0x15724FC VA: 0x15764FC
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x15765A0 Offset: 0x15725A0 VA: 0x15765A0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x1576654 Offset: 0x1572654 VA: 0x1576654
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x1576700 Offset: 0x1572700 VA: 0x1576700
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>..ctor
	|
	|-RVA: 0x15767A4 Offset: 0x15727A4 VA: 0x15767A4
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>..ctor
	|
	|-RVA: 0x1576848 Offset: 0x1572848 VA: 0x1576848
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>..ctor
	|
	|-RVA: 0x15768EC Offset: 0x15728EC VA: 0x15768EC
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>..ctor
	|
	|-RVA: 0x1576990 Offset: 0x1572990 VA: 0x1576990
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1576480 Offset: 0x1572480 VA: 0x1576480
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.get_IsCompleted
	|
	|-RVA: 0x1576524 Offset: 0x1572524 VA: 0x1576524
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.get_IsCompleted
	|
	|-RVA: 0x15765C8 Offset: 0x15725C8 VA: 0x15765C8
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.get_IsCompleted
	|
	|-RVA: 0x157667C Offset: 0x157267C VA: 0x157667C
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.get_IsCompleted
	|
	|-RVA: 0x1576728 Offset: 0x1572728 VA: 0x1576728
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.get_IsCompleted
	|
	|-RVA: 0x15767CC Offset: 0x15727CC VA: 0x15767CC
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.get_IsCompleted
	|
	|-RVA: 0x1576870 Offset: 0x1572870 VA: 0x1576870
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.get_IsCompleted
	|
	|-RVA: 0x1576914 Offset: 0x1572914 VA: 0x1576914
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.get_IsCompleted
	|
	|-RVA: 0x15769B8 Offset: 0x15729B8 VA: 0x15769B8
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void UnsafeOnCompleted(Action continuation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1576498 Offset: 0x1572498 VA: 0x1576498
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.UnsafeOnCompleted
	|
	|-RVA: 0x157653C Offset: 0x157253C VA: 0x157653C
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x15765E0 Offset: 0x15725E0 VA: 0x15765E0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.UnsafeOnCompleted
	|
	|-RVA: 0x1576694 Offset: 0x1572694 VA: 0x1576694
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.UnsafeOnCompleted
	|
	|-RVA: 0x1576740 Offset: 0x1572740 VA: 0x1576740
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.UnsafeOnCompleted
	|
	|-RVA: 0x15767E4 Offset: 0x15727E4 VA: 0x15767E4
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.UnsafeOnCompleted
	|
	|-RVA: 0x1576888 Offset: 0x1572888 VA: 0x1576888
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.UnsafeOnCompleted
	|
	|-RVA: 0x157692C Offset: 0x157292C VA: 0x157692C
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.UnsafeOnCompleted
	|
	|-RVA: 0x15769D0 Offset: 0x15729D0 VA: 0x15769D0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>.UnsafeOnCompleted
	*/

	[StackTraceHidden]
	// RVA: -1 Offset: -1
	public TResult GetResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15764B0 Offset: 0x15724B0 VA: 0x15764B0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>.GetResult
	|
	|-RVA: 0x1576554 Offset: 0x1572554 VA: 0x1576554
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<bool, object>>.GetResult
	|
	|-RVA: 0x15765F8 Offset: 0x15725F8 VA: 0x15765F8
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>.GetResult
	|
	|-RVA: 0x15766AC Offset: 0x15726AC VA: 0x15766AC
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>.GetResult
	|
	|-RVA: 0x1576758 Offset: 0x1572758 VA: 0x1576758
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>.GetResult
	|
	|-RVA: 0x15767FC Offset: 0x15727FC VA: 0x15767FC
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>.GetResult
	|
	|-RVA: 0x15768A0 Offset: 0x15728A0 VA: 0x15768A0
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>.GetResult
	|
	|-RVA: 0x1576944 Offset: 0x1572944 VA: 0x1576944
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<VoidTaskResult>.GetResult
	|
	|-RVA: 0x15769E8 Offset: 0x15729E8 VA: 0x15769E8
	|-ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<__Il2CppFullySharedGenericType>.GetResult
	*/
}

// Namespace: System.Runtime.CompilerServices
[IsReadOnly]
public struct ConfiguredTaskAwaitable<TResult> // TypeDefIndex: 1131
{
	// Fields
	private readonly ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> m_configuredTaskAwaiter; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Task<TResult> task, bool continueOnCapturedContext) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1576044 Offset: 0x1572044 VA: 0x1576044
	|-ConfiguredTaskAwaitable<Nullable<int>>..ctor
	|
	|-RVA: 0x15760B8 Offset: 0x15720B8 VA: 0x15760B8
	|-ConfiguredTaskAwaitable<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x157612C Offset: 0x157212C VA: 0x157612C
	|-ConfiguredTaskAwaitable<ValueTuple<object, object, int>>..ctor
	|
	|-RVA: 0x15761A0 Offset: 0x15721A0 VA: 0x15761A0
	|-ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>..ctor
	|
	|-RVA: 0x1576214 Offset: 0x1572214 VA: 0x1576214
	|-ConfiguredTaskAwaitable<bool>..ctor
	|
	|-RVA: 0x1576288 Offset: 0x1572288 VA: 0x1576288
	|-ConfiguredTaskAwaitable<int>..ctor
	|
	|-RVA: 0x15762FC Offset: 0x15722FC VA: 0x15762FC
	|-ConfiguredTaskAwaitable<object>..ctor
	|
	|-RVA: 0x1576370 Offset: 0x1572370 VA: 0x1576370
	|-ConfiguredTaskAwaitable<VoidTaskResult>..ctor
	|
	|-RVA: 0x15763E4 Offset: 0x15723E4 VA: 0x15763E4
	|-ConfiguredTaskAwaitable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<TResult> GetAwaiter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15760AC Offset: 0x15720AC VA: 0x15760AC
	|-ConfiguredTaskAwaitable<Nullable<int>>.GetAwaiter
	|
	|-RVA: 0x1576120 Offset: 0x1572120 VA: 0x1576120
	|-ConfiguredTaskAwaitable<ValueTuple<bool, object>>.GetAwaiter
	|
	|-RVA: 0x1576194 Offset: 0x1572194 VA: 0x1576194
	|-ConfiguredTaskAwaitable<ValueTuple<object, object, int>>.GetAwaiter
	|
	|-RVA: 0x1576208 Offset: 0x1572208 VA: 0x1576208
	|-ConfiguredTaskAwaitable<ValueTuple<object, bool, bool, object, object>>.GetAwaiter
	|
	|-RVA: 0x157627C Offset: 0x157227C VA: 0x157627C
	|-ConfiguredTaskAwaitable<bool>.GetAwaiter
	|
	|-RVA: 0x15762F0 Offset: 0x15722F0 VA: 0x15762F0
	|-ConfiguredTaskAwaitable<int>.GetAwaiter
	|
	|-RVA: 0x1576364 Offset: 0x1572364 VA: 0x1576364
	|-ConfiguredTaskAwaitable<object>.GetAwaiter
	|
	|-RVA: 0x15763D8 Offset: 0x15723D8 VA: 0x15763D8
	|-ConfiguredTaskAwaitable<VoidTaskResult>.GetAwaiter
	|
	|-RVA: 0x157644C Offset: 0x157244C VA: 0x157644C
	|-ConfiguredTaskAwaitable<__Il2CppFullySharedGenericType>.GetAwaiter
	*/
}

// Namespace: System.Runtime.CompilerServices
[Usage(5148, Inherited = False, AllowMultiple = False)]
internal class ReflectionBlockedAttribute : Attribute // TypeDefIndex: 1132
{
	// Methods

	// RVA: 0x17D3288 Offset: 0x17CF288 VA: 0x17D3288
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncVoidMethodBuilder // TypeDefIndex: 1133
{
	// Fields
	private SynchronizationContext m_synchronizationContext; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x8
	private Task m_task; // 0x18

	// Properties
	internal Task Task { get; }

	// Methods

	// RVA: 0x17D3290 Offset: 0x17CF290 VA: 0x17D3290
	public static AsyncVoidMethodBuilder Create() { }

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EC1CC Offset: 0x10E81CC VA: 0x10EC1CC
	|-AsyncVoidMethodBuilder.Start<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x10EC408 Offset: 0x10E8408 VA: 0x10EC408
	|-AsyncVoidMethodBuilder.Start<FtpWebRequest.<CreateConnectionAsync>d__86>
	|
	|-RVA: 0x10EC4FC Offset: 0x10E84FC VA: 0x10EC4FC
	|-AsyncVoidMethodBuilder.Start<WebOperation.<Run>d__58>
	*/

	// RVA: 0x17D32F8 Offset: 0x17CF2F8 VA: 0x17D32F8
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EB6F0 Offset: 0x10E76F0 VA: 0x10EB6F0
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebOperation.<Run>d__58>
	|
	|-RVA: 0x10EB960 Offset: 0x10E7960 VA: 0x10EB960
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0x10EBCEC Offset: 0x10E7CEC VA: 0x10EBCEC
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, FtpWebRequest.<CreateConnectionAsync>d__86>
	|
	|-RVA: 0x10EBF5C Offset: 0x10E7F5C VA: 0x10EBF5C
	|-AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebOperation.<Run>d__58>
	*/

	// RVA: 0x17D33BC Offset: 0x17CF3BC VA: 0x17D33BC
	public void SetResult() { }

	// RVA: 0x17D352C Offset: 0x17CF52C VA: 0x17D352C
	public void SetException(Exception exception) { }

	// RVA: 0x17D3488 Offset: 0x17CF488 VA: 0x17D3488
	private void NotifySynchronizationContextOfCompletion() { }

	// RVA: 0x17D3418 Offset: 0x17CF418 VA: 0x17D3418
	internal Task get_Task() { }
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncTaskMethodBuilder // TypeDefIndex: 1134
{
	// Fields
	private static readonly Task<VoidTaskResult> s_cachedCompleted; // 0x0
	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder; // 0x0

	// Properties
	public Task Task { get; }

	// Methods

	// RVA: 0x17D3910 Offset: 0x17CF910 VA: 0x17D3910
	public static AsyncTaskMethodBuilder Create() { }

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EA0B0 Offset: 0x10E60B0 VA: 0x10EA0B0
	|-AsyncTaskMethodBuilder.Start<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x10EA2EC Offset: 0x10E62EC VA: 0x10EA2EC
	|-AsyncTaskMethodBuilder.Start<AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x10EA3E0 Offset: 0x10E63E0 VA: 0x10EA3E0
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncCore>d__49>
	|
	|-RVA: 0x10EA4D4 Offset: 0x10E64D4 VA: 0x10EA4D4
	|-AsyncTaskMethodBuilder.Start<CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x10EA5C8 Offset: 0x10E65C8 VA: 0x10EA5C8
	|-AsyncTaskMethodBuilder.Start<DeflateManagedStream.<WriteAsyncCore>d__47>
	|
	|-RVA: 0x10EA6BC Offset: 0x10E66BC VA: 0x10EA6BC
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x10EA7B0 Offset: 0x10E67B0 VA: 0x10EA7B0
	|-AsyncTaskMethodBuilder.Start<MobileAuthenticatedStream.<ProcessAuthentication>d__48>
	|
	|-RVA: 0x10EA8A4 Offset: 0x10E68A4 VA: 0x10EA8A4
	|-AsyncTaskMethodBuilder.Start<MonoChunkStream.<FinishReading>d__8>
	|
	|-RVA: 0x10EA998 Offset: 0x10E6998 VA: 0x10EA998
	|-AsyncTaskMethodBuilder.Start<ServicePointScheduler.<RunScheduler>d__32>
	|
	|-RVA: 0x10EAA8C Offset: 0x10E6A8C VA: 0x10EAA8C
	|-AsyncTaskMethodBuilder.Start<Stream.<FinishWriteAsync>d__57>
	|
	|-RVA: 0x10EAB80 Offset: 0x10E6B80 VA: 0x10EAB80
	|-AsyncTaskMethodBuilder.Start<WebConnection.<Connect>d__16>
	|
	|-RVA: 0x10EAC74 Offset: 0x10E6C74 VA: 0x10EAC74
	|-AsyncTaskMethodBuilder.Start<WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x10EAD68 Offset: 0x10E6D68 VA: 0x10EAD68
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<FinishWriting>d__31>
	|
	|-RVA: 0x10EAE5C Offset: 0x10E6E5C VA: 0x10EAE5C
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x10EAF50 Offset: 0x10E6F50 VA: 0x10EAF50
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<ProcessWrite>d__34>
	|
	|-RVA: 0x10EB044 Offset: 0x10E7044 VA: 0x10EB044
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<SetHeadersAsync>d__37>
	|
	|-RVA: 0x10EB138 Offset: 0x10E7138 VA: 0x10EB138
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x10EB22C Offset: 0x10E722C VA: 0x10EB22C
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x10EB320 Offset: 0x10E7320 VA: 0x10EB320
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteChunkTrailer_inner>d__39>
	|
	|-RVA: 0x10EB414 Offset: 0x10E7414 VA: 0x10EB414
	|-AsyncTaskMethodBuilder.Start<WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x10EB508 Offset: 0x10E7508 VA: 0x10EB508
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<InitReadAsync>d__52>
	|
	|-RVA: 0x10EB5FC Offset: 0x10E75FC VA: 0x10EB5FC
	|-AsyncTaskMethodBuilder.Start<WebResponseStream.<ReadAllAsync>d__48>
	*/

	// RVA: 0x17D391C Offset: 0x17CF91C VA: 0x17D391C
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E9224 Offset: 0x10E5224 VA: 0x10E9224
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x10E92A0 Offset: 0x10E52A0 VA: 0x10E92A0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>, WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x10E931C Offset: 0x10E531C VA: 0x10E931C
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MonoChunkStream.<FinishReading>d__8>
	|
	|-RVA: 0x10E9398 Offset: 0x10E5398 VA: 0x10E9398
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<InitReadAsync>d__52>
	|
	|-RVA: 0x10E9414 Offset: 0x10E5414 VA: 0x10E9414
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__48>
	|
	|-RVA: 0x10E9490 Offset: 0x10E5490 VA: 0x10E9490
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<RunScheduler>d__32>
	|
	|-RVA: 0x10E950C Offset: 0x10E550C VA: 0x10E950C
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x10E9588 Offset: 0x10E5588 VA: 0x10E9588
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAllAsync>d__48>
	|
	|-RVA: 0x10E9604 Offset: 0x10E5604 VA: 0x10E9604
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ForceAsyncAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x10E9680 Offset: 0x10E5680 VA: 0x10E9680
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x10E96FC Offset: 0x10E56FC VA: 0x10E96FC
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x10E9778 Offset: 0x10E5778 VA: 0x10E9778
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x10E97F4 Offset: 0x10E57F4 VA: 0x10E97F4
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x10E9870 Offset: 0x10E5870 VA: 0x10E9870
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, CryptoStream.<WriteAsyncCore>d__49>
	|
	|-RVA: 0x10E98EC Offset: 0x10E58EC VA: 0x10E98EC
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0x10E996C Offset: 0x10E596C VA: 0x10E996C
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x10E99E8 Offset: 0x10E59E8 VA: 0x10E99E8
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, DeflateManagedStream.<WriteAsyncCore>d__47>
	|
	|-RVA: 0x10E9A64 Offset: 0x10E5A64 VA: 0x10E9A64
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x10E9AE0 Offset: 0x10E5AE0 VA: 0x10E9AE0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoChunkStream.<FinishReading>d__8>
	|
	|-RVA: 0x10E9B5C Offset: 0x10E5B5C VA: 0x10E9B5C
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<FinishWriteAsync>d__57>
	|
	|-RVA: 0x10E9BD8 Offset: 0x10E5BD8 VA: 0x10E9BD8
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<Connect>d__16>
	|
	|-RVA: 0x10E9C54 Offset: 0x10E5C54 VA: 0x10E9C54
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x10E9CD0 Offset: 0x10E5CD0 VA: 0x10E9CD0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<FinishWriting>d__31>
	|
	|-RVA: 0x10E9D4C Offset: 0x10E5D4C VA: 0x10E9D4C
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x10E9DC8 Offset: 0x10E5DC8 VA: 0x10E9DC8
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<ProcessWrite>d__34>
	|
	|-RVA: 0x10E9E44 Offset: 0x10E5E44 VA: 0x10E9E44
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<SetHeadersAsync>d__37>
	|
	|-RVA: 0x10E9EC0 Offset: 0x10E5EC0 VA: 0x10E9EC0
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x10E9F3C Offset: 0x10E5F3C VA: 0x10E9F3C
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x10E9FB8 Offset: 0x10E5FB8 VA: 0x10E9FB8
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer_inner>d__39>
	|
	|-RVA: 0x10EA034 Offset: 0x10E6034 VA: 0x10EA034
	|-AsyncTaskMethodBuilder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	*/

	// RVA: 0x17D3998 Offset: 0x17CF998 VA: 0x17D3998
	public Task get_Task() { }

	// RVA: 0x17D3A04 Offset: 0x17CFA04 VA: 0x17D3A04
	public void SetResult() { }

	// RVA: 0x17D3AA8 Offset: 0x17CFAA8 VA: 0x17D3AA8
	public void SetException(Exception exception) { }

	// RVA: 0x17D3B24 Offset: 0x17CFB24 VA: 0x17D3B24
	private static void .cctor() { }
}

// Namespace: System.Runtime.CompilerServices
public struct AsyncTaskMethodBuilder<TResult> // TypeDefIndex: 1135
{
	// Fields
	internal static readonly Task<TResult> s_defaultResultTask; // 0x0
	private AsyncMethodBuilderCore m_coreState; // 0x0
	private Task<TResult> m_task; // 0x0

	// Properties
	public Task<TResult> Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static AsyncTaskMethodBuilder<TResult> Create() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13CEE14 Offset: 0x13CAE14 VA: 0x13CEE14
	|-AsyncTaskMethodBuilder<Nullable<int>>.Create
	|
	|-RVA: 0x13CF490 Offset: 0x13CB490 VA: 0x13CF490
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.Create
	|
	|-RVA: 0x13D0448 Offset: 0x13CC448 VA: 0x13D0448
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.Create
	|
	|-RVA: 0x14D0804 Offset: 0x14CC804 VA: 0x14D0804
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.Create
	|
	|-RVA: 0x14D1824 Offset: 0x14CD824 VA: 0x14D1824
	|-AsyncTaskMethodBuilder<bool>.Create
	|
	|-RVA: 0x14D27F4 Offset: 0x14CE7F4 VA: 0x14D27F4
	|-AsyncTaskMethodBuilder<int>.Create
	|
	|-RVA: 0x14D37B8 Offset: 0x14CF7B8 VA: 0x14D37B8
	|-AsyncTaskMethodBuilder<object>.Create
	|
	|-RVA: 0x14D3E34 Offset: 0x14CFE34 VA: 0x14D3E34
	|-AsyncTaskMethodBuilder<VoidTaskResult>.Create
	|
	|-RVA: 0x14D4E00 Offset: 0x14D0E00 VA: 0x14D4E00
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.Create
	*/

	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public void Start<TStateMachine>(ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF904C Offset: 0xFF504C VA: 0xFF904C
	|-AsyncTaskMethodBuilder<Nullable<int>>.Start<AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0xFF9390 Offset: 0xFF5390 VA: 0xFF9390
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.Start<WebCompletionSource.<WaitForCompletion>d__15<ValueTuple<bool, object>>>
	|
	|-RVA: 0xFF96CC Offset: 0xFF56CC VA: 0xFF96CC
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.Start<WebConnectionTunnel.<ReadHeaders>d__43>
	|
	|-RVA: 0xFF9C50 Offset: 0xFF5C50 VA: 0xFF9C50
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.Start<HttpWebRequest.<GetResponseFromData>d__244>
	|
	|-RVA: 0xFFA8AC Offset: 0xFF68AC VA: 0xFFA8AC
	|-AsyncTaskMethodBuilder<bool>.Start<SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>
	|
	|-RVA: 0xFFA9A0 Offset: 0xFF69A0 VA: 0xFFA9A0
	|-AsyncTaskMethodBuilder<bool>.Start<ServicePointScheduler.<WaitAsync>d__46>
	|
	|-RVA: 0xFFAA94 Offset: 0xFF6A94 VA: 0xFFAA94
	|-AsyncTaskMethodBuilder<bool>.Start<WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0xFFCDC0 Offset: 0xFF8DC0 VA: 0xFFCDC0
	|-AsyncTaskMethodBuilder<int>.Start<HttpWebRequest.<RunWithTimeoutWorker>d__241<int>>
	|
	|-RVA: 0xFFCEB4 Offset: 0xFF8EB4 VA: 0xFFCEB4
	|-AsyncTaskMethodBuilder<int>.Start<BufferedReadStream.<ProcessReadAsync>d__2>
	|
	|-RVA: 0xFFCFA8 Offset: 0xFF8FA8 VA: 0xFFCFA8
	|-AsyncTaskMethodBuilder<int>.Start<CryptoStream.<ReadAsyncCore>d__42>
	|
	|-RVA: 0xFFD09C Offset: 0xFF909C VA: 0xFFD09C
	|-AsyncTaskMethodBuilder<int>.Start<CryptoStream.<ReadAsyncInternal>d__37>
	|
	|-RVA: 0xFFD190 Offset: 0xFF9190 VA: 0xFFD190
	|-AsyncTaskMethodBuilder<int>.Start<DeflateManagedStream.<ReadAsyncCore>d__40>
	|
	|-RVA: 0xFFD284 Offset: 0xFF9284 VA: 0xFFD284
	|-AsyncTaskMethodBuilder<int>.Start<FixedSizeReadStream.<ProcessReadAsync>d__5>
	|
	|-RVA: 0xFFD378 Offset: 0xFF9378 VA: 0xFFD378
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0xFFD46C Offset: 0xFF946C VA: 0xFFD46C
	|-AsyncTaskMethodBuilder<int>.Start<MobileAuthenticatedStream.<StartOperation>d__57>
	|
	|-RVA: 0xFFD560 Offset: 0xFF9560 VA: 0xFFD560
	|-AsyncTaskMethodBuilder<int>.Start<MonoChunkStream.<ProcessReadAsync>d__7>
	|
	|-RVA: 0xFFD654 Offset: 0xFF9654 VA: 0xFFD654
	|-AsyncTaskMethodBuilder<int>.Start<Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0xFFD748 Offset: 0xFF9748 VA: 0xFFD748
	|-AsyncTaskMethodBuilder<int>.Start<WebReadStream.<ReadAsync>d__28>
	|
	|-RVA: 0xFFD83C Offset: 0xFF983C VA: 0xFFD83C
	|-AsyncTaskMethodBuilder<int>.Start<WebResponseStream.<ReadAsync>d__40>
	|
	|-RVA: 0xFFF928 Offset: 0xFFB928 VA: 0xFFF928
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<RunWithTimeoutWorker>d__241<object>>
	|
	|-RVA: 0xFFFA1C Offset: 0xFFBA1C VA: 0xFFFA1C
	|-AsyncTaskMethodBuilder<object>.Start<WebCompletionSource.<WaitForCompletion>d__15<object>>
	|
	|-RVA: 0xFFFB10 Offset: 0xFFBB10 VA: 0xFFFB10
	|-AsyncTaskMethodBuilder<object>.Start<AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-RVA: 0xFFFC04 Offset: 0xFFBC04 VA: 0xFFFC04
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<<GetRewriteHandler>b__271_0>d>
	|
	|-RVA: 0xFFFCF8 Offset: 0xFFBCF8 VA: 0xFFFCF8
	|-AsyncTaskMethodBuilder<object>.Start<HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0xFFFDEC Offset: 0xFFBDEC VA: 0xFFFDEC
	|-AsyncTaskMethodBuilder<object>.Start<MonoTlsStream.<CreateStream>d__18>
	|
	|-RVA: 0xFFFEE0 Offset: 0xFFBEE0 VA: 0xFFFEE0
	|-AsyncTaskMethodBuilder<object>.Start<WebConnection.<InitConnection>d__19>
	|
	|-RVA: 0xFFFFD4 Offset: 0xFFBFD4 VA: 0xFFFFD4
	|-AsyncTaskMethodBuilder<object>.Start<WebResponseStream.<ReadAllAsyncInner>d__47>
	|
	|-RVA: 0x10000C8 Offset: 0xFFC0C8 VA: 0x10000C8
	|-AsyncTaskMethodBuilder<object>.Start<XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0x10001BC Offset: 0xFFC1BC VA: 0x10001BC
	|-AsyncTaskMethodBuilder<object>.Start<XmlUrlResolver.<GetEntityAsync>d__15>
	|
	|-RVA: 0x100486C Offset: 0x100086C VA: 0x100486C
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.Start<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13CEE20 Offset: 0x13CAE20 VA: 0x13CEE20
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetStateMachine
	|
	|-RVA: 0x13CF49C Offset: 0x13CB49C VA: 0x13CF49C
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetStateMachine
	|
	|-RVA: 0x13D0454 Offset: 0x13CC454 VA: 0x13D0454
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetStateMachine
	|
	|-RVA: 0x14D0810 Offset: 0x14CC810 VA: 0x14D0810
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetStateMachine
	|
	|-RVA: 0x14D1830 Offset: 0x14CD830 VA: 0x14D1830
	|-AsyncTaskMethodBuilder<bool>.SetStateMachine
	|
	|-RVA: 0x14D2800 Offset: 0x14CE800 VA: 0x14D2800
	|-AsyncTaskMethodBuilder<int>.SetStateMachine
	|
	|-RVA: 0x14D37C4 Offset: 0x14CF7C4 VA: 0x14D37C4
	|-AsyncTaskMethodBuilder<object>.SetStateMachine
	|
	|-RVA: 0x14D3E40 Offset: 0x14CFE40 VA: 0x14D3E40
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetStateMachine
	|
	|-RVA: 0x14D4E0C Offset: 0x14D0E0C VA: 0x14D4E0C
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetStateMachine
	*/

	// RVA: -1 Offset: -1
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFF8E04 Offset: 0xFF4E04 VA: 0xFF8E04
	|-AsyncTaskMethodBuilder<Nullable<int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, AsyncProtocolRequest.<InnerRead>d__25>
	|
	|-RVA: 0xFF9140 Offset: 0xFF5140 VA: 0xFF9140
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebCompletionSource.<WaitForCompletion>d__15<ValueTuple<bool, object>>>
	|
	|-RVA: 0xFF9484 Offset: 0xFF5484 VA: 0xFF9484
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebConnectionTunnel.<ReadHeaders>d__43>
	|
	|-RVA: 0xFF97C0 Offset: 0xFF57C0 VA: 0xFF97C0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpWebRequest.<GetResponseFromData>d__244>
	|
	|-RVA: 0xFF9A08 Offset: 0xFF5A08 VA: 0xFF9A08
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<GetResponseFromData>d__244>
	|
	|-RVA: 0xFF9D44 Offset: 0xFF5D44 VA: 0xFF9D44
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>
	|
	|-RVA: 0xFF9F8C Offset: 0xFF5F8C VA: 0xFF9F8C
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, SemaphoreSlim.<WaitUntilCountOrTimeoutAsync>d__32>
	|
	|-RVA: 0xFFA1D4 Offset: 0xFF61D4 VA: 0xFFA1D4
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<WaitAsync>d__46>
	|
	|-RVA: 0xFFA41C Offset: 0xFF641C VA: 0xFFA41C
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0xFFA664 Offset: 0xFF6664 VA: 0xFFA664
	|-AsyncTaskMethodBuilder<bool>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<CreateStream>d__18>
	|
	|-RVA: 0xFFAB88 Offset: 0xFF6B88 VA: 0xFFAB88
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, HttpWebRequest.<RunWithTimeoutWorker>d__241<int>>
	|
	|-RVA: 0xFFADD0 Offset: 0xFF6DD0 VA: 0xFFADD0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, BufferedReadStream.<ProcessReadAsync>d__2>
	|
	|-RVA: 0xFFB018 Offset: 0xFF7018 VA: 0xFFB018
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, DeflateManagedStream.<ReadAsyncCore>d__40>
	|
	|-RVA: 0xFFB260 Offset: 0xFF7260 VA: 0xFFB260
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, FixedSizeReadStream.<ProcessReadAsync>d__5>
	|
	|-RVA: 0xFFB4A8 Offset: 0xFF74A8 VA: 0xFFB4A8
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MobileAuthenticatedStream.<InnerRead>d__66>
	|
	|-RVA: 0xFFB6F0 Offset: 0xFF76F0 VA: 0xFFB6F0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MonoChunkStream.<ProcessReadAsync>d__7>
	|
	|-RVA: 0xFFB938 Offset: 0xFF7938 VA: 0xFFB938
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, Stream.<<ReadAsync>g__FinishReadAsync|44_0>d>
	|
	|-RVA: 0xFFBB80 Offset: 0xFF7B80 VA: 0xFFBB80
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebReadStream.<ReadAsync>d__28>
	|
	|-RVA: 0xFFBDC8 Offset: 0xFF7DC8 VA: 0xFFBDC8
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<ReadAsync>d__40>
	|
	|-RVA: 0xFFC010 Offset: 0xFF8010 VA: 0xFFC010
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<StartOperation>d__57>
	|
	|-RVA: 0xFFC258 Offset: 0xFF8258 VA: 0xFFC258
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAsync>d__40>
	|
	|-RVA: 0xFFC4A0 Offset: 0xFF84A0 VA: 0xFFC4A0
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<TaskAwaiter<int>, CryptoStream.<ReadAsyncInternal>d__37>
	|
	|-RVA: 0xFFC6E8 Offset: 0xFF86E8 VA: 0xFFC6E8
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ValueTaskAwaiter<int>, CryptoStream.<ReadAsyncCore>d__42>
	|
	|-RVA: 0xFFC930 Offset: 0xFF8930 VA: 0xFFC930
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ForceAsyncAwaiter, CryptoStream.<ReadAsyncInternal>d__37>
	|
	|-RVA: 0xFFCB78 Offset: 0xFF8B78 VA: 0xFFCB78
	|-AsyncTaskMethodBuilder<int>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebReadStream.<ReadAsync>d__28>
	|
	|-RVA: 0xFFD930 Offset: 0xFF9930 VA: 0xFFD930
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, bool, bool, object, object>>, HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0xFFDB78 Offset: 0xFF9B78 VA: 0xFFDB78
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, HttpWebRequest.<RunWithTimeoutWorker>d__241<object>>
	|
	|-RVA: 0xFFDDC0 Offset: 0xFF9DC0 VA: 0xFFDDC0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool>, WebConnection.<InitConnection>d__19>
	|
	|-RVA: 0xFFE008 Offset: 0xFFA008 VA: 0xFFE008
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<ReadAllAsyncInner>d__47>
	|
	|-RVA: 0xFFE250 Offset: 0xFFA250 VA: 0xFFE250
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebCompletionSource.<WaitForCompletion>d__15<object>>
	|
	|-RVA: 0xFFE4A0 Offset: 0xFFA4A0 VA: 0xFFE4A0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0xFFE6E8 Offset: 0xFFA6E8 VA: 0xFFE6E8
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlDownloadManager.<GetNonFileStreamAsync>d__5>
	|
	|-RVA: 0xFFE930 Offset: 0xFFA930 VA: 0xFFE930
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, XmlUrlResolver.<GetEntityAsync>d__15>
	|
	|-RVA: 0xFFEB78 Offset: 0xFFAB78 VA: 0xFFEB78
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<TaskAwaiter<object>, HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0xFFEDC0 Offset: 0xFFADC0 VA: 0xFFEDC0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<StartOperation>d__23>
	|
	|-RVA: 0xFFF008 Offset: 0xFFB008 VA: 0xFFF008
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<<GetRewriteHandler>b__271_0>d>
	|
	|-RVA: 0xFFF250 Offset: 0xFFB250 VA: 0xFFF250
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, HttpWebRequest.<MyGetResponseAsync>d__243>
	|
	|-RVA: 0xFFF498 Offset: 0xFFB498 VA: 0xFFF498
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoTlsStream.<CreateStream>d__18>
	|
	|-RVA: 0xFFF6E0 Offset: 0xFFB6E0 VA: 0xFFF6E0
	|-AsyncTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<InitConnection>d__19>
	|
	|-RVA: 0x10002B0 Offset: 0xFFC2B0 VA: 0x10002B0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>>, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x10004F8 Offset: 0xFFC4F8 VA: 0x10004F8
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<object, object, int>>, WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x1000740 Offset: 0xFFC740 VA: 0x1000740
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, MonoChunkStream.<FinishReading>d__8>
	|
	|-RVA: 0x1000988 Offset: 0xFFC988 VA: 0x1000988
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int>, WebResponseStream.<InitReadAsync>d__52>
	|
	|-RVA: 0x1000BD0 Offset: 0xFFCBD0 VA: 0x1000BD0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, MobileAuthenticatedStream.<ProcessAuthentication>d__48>
	|
	|-RVA: 0x1000E18 Offset: 0xFFCE18 VA: 0x1000E18
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, ServicePointScheduler.<RunScheduler>d__32>
	|
	|-RVA: 0x1001060 Offset: 0xFFD060 VA: 0x1001060
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x10012A8 Offset: 0xFFD2A8 VA: 0x10012A8
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>, WebResponseStream.<ReadAllAsync>d__48>
	|
	|-RVA: 0x10014F0 Offset: 0xFFD4F0 VA: 0x10014F0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ForceAsyncAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x1001738 Offset: 0xFFD738 VA: 0x1001738
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, CryptoStream.<WriteAsyncInternal>d__46>
	|
	|-RVA: 0x1001980 Offset: 0xFFD980 VA: 0x1001980
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x1001BC8 Offset: 0xFFDBC8 VA: 0x1001BC8
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x1001E10 Offset: 0xFFDE10 VA: 0x1001E10
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<TaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x1002058 Offset: 0xFFE058 VA: 0x1002058
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ValueTaskAwaiter, CryptoStream.<WriteAsyncCore>d__49>
	|
	|-RVA: 0x10022CC Offset: 0xFFE2CC VA: 0x10022CC
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, AsyncProtocolRequest.<ProcessOperation>d__24>
	|
	|-RVA: 0x1002514 Offset: 0xFFE514 VA: 0x1002514
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, DeflateManagedStream.<WriteAsyncCore>d__47>
	|
	|-RVA: 0x100275C Offset: 0xFFE75C VA: 0x100275C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MobileAuthenticatedStream.<InnerWrite>d__67>
	|
	|-RVA: 0x10029A4 Offset: 0xFFE9A4 VA: 0x10029A4
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, MonoChunkStream.<FinishReading>d__8>
	|
	|-RVA: 0x1002BEC Offset: 0xFFEBEC VA: 0x1002BEC
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, Stream.<FinishWriteAsync>d__57>
	|
	|-RVA: 0x1002E34 Offset: 0xFFEE34 VA: 0x1002E34
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnection.<Connect>d__16>
	|
	|-RVA: 0x100307C Offset: 0xFFF07C VA: 0x100307C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebConnectionTunnel.<Initialize>d__42>
	|
	|-RVA: 0x10032C4 Offset: 0xFFF2C4 VA: 0x10032C4
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<FinishWriting>d__31>
	|
	|-RVA: 0x100350C Offset: 0xFFF50C VA: 0x100350C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<Initialize>d__36>
	|
	|-RVA: 0x1003754 Offset: 0xFFF754 VA: 0x1003754
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<ProcessWrite>d__34>
	|
	|-RVA: 0x100399C Offset: 0xFFF99C VA: 0x100399C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<SetHeadersAsync>d__37>
	|
	|-RVA: 0x1003BE4 Offset: 0xFFFBE4 VA: 0x1003BE4
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteAsyncInner>d__33>
	|
	|-RVA: 0x1003E2C Offset: 0xFFFE2C VA: 0x1003E2C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer>d__40>
	|
	|-RVA: 0x1004074 Offset: 0x1000074 VA: 0x1004074
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteChunkTrailer_inner>d__39>
	|
	|-RVA: 0x10042BC Offset: 0x10002BC VA: 0x10042BC
	|-AsyncTaskMethodBuilder<VoidTaskResult>.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, WebRequestStream.<WriteRequestAsync>d__38>
	|
	|-RVA: 0x1004504 Offset: 0x1000504 VA: 0x1004504
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.AwaitUnsafeOnCompleted<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Task<TResult> get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13CEE28 Offset: 0x13CAE28 VA: 0x13CEE28
	|-AsyncTaskMethodBuilder<Nullable<int>>.get_Task
	|
	|-RVA: 0x13CF4A4 Offset: 0x13CB4A4 VA: 0x13CF4A4
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.get_Task
	|
	|-RVA: 0x13D045C Offset: 0x13CC45C VA: 0x13D045C
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.get_Task
	|
	|-RVA: 0x14D0818 Offset: 0x14CC818 VA: 0x14D0818
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.get_Task
	|
	|-RVA: 0x14D1838 Offset: 0x14CD838 VA: 0x14D1838
	|-AsyncTaskMethodBuilder<bool>.get_Task
	|
	|-RVA: 0x14D2808 Offset: 0x14CE808 VA: 0x14D2808
	|-AsyncTaskMethodBuilder<int>.get_Task
	|
	|-RVA: 0x14D37CC Offset: 0x14CF7CC VA: 0x14D37CC
	|-AsyncTaskMethodBuilder<object>.get_Task
	|
	|-RVA: 0x14D3E48 Offset: 0x14CFE48 VA: 0x14D3E48
	|-AsyncTaskMethodBuilder<VoidTaskResult>.get_Task
	|
	|-RVA: 0x14D4E14 Offset: 0x14D0E14 VA: 0x14D4E14
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	public void SetResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13CEEC0 Offset: 0x13CAEC0 VA: 0x13CEEC0
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0x13CF53C Offset: 0x13CB53C VA: 0x13CF53C
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetResult
	|
	|-RVA: 0x13D04F4 Offset: 0x13CC4F4 VA: 0x13D04F4
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetResult
	|
	|-RVA: 0x14D08B0 Offset: 0x14CC8B0 VA: 0x14D08B0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetResult
	|
	|-RVA: 0x14D18D0 Offset: 0x14CD8D0 VA: 0x14D18D0
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x14D28A0 Offset: 0x14CE8A0 VA: 0x14D28A0
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x14D3864 Offset: 0x14CF864 VA: 0x14D3864
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0x14D3EE0 Offset: 0x14CFEE0 VA: 0x14D3EE0
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	|
	|-RVA: 0x14D4ED8 Offset: 0x14D0ED8 VA: 0x14D4ED8
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	internal void SetResult(Task<TResult> completedTask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13CF07C Offset: 0x13CB07C VA: 0x13CF07C
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetResult
	|
	|-RVA: 0x13CF704 Offset: 0x13CB704 VA: 0x13CF704
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetResult
	|
	|-RVA: 0x13D06E4 Offset: 0x13CC6E4 VA: 0x13D06E4
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetResult
	|
	|-RVA: 0x14D0A88 Offset: 0x14CCA88 VA: 0x14D0A88
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetResult
	|
	|-RVA: 0x14D1A8C Offset: 0x14CDA8C VA: 0x14D1A8C
	|-AsyncTaskMethodBuilder<bool>.SetResult
	|
	|-RVA: 0x14D2A5C Offset: 0x14CEA5C VA: 0x14D2A5C
	|-AsyncTaskMethodBuilder<int>.SetResult
	|
	|-RVA: 0x14D3A20 Offset: 0x14CFA20 VA: 0x14D3A20
	|-AsyncTaskMethodBuilder<object>.SetResult
	|
	|-RVA: 0x14D409C Offset: 0x14D009C VA: 0x14D409C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetResult
	|
	|-RVA: 0x14D529C Offset: 0x14D129C VA: 0x14D529C
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetResult
	*/

	// RVA: -1 Offset: -1
	public void SetException(Exception exception) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13CF10C Offset: 0x13CB10C VA: 0x13CF10C
	|-AsyncTaskMethodBuilder<Nullable<int>>.SetException
	|
	|-RVA: 0x13CF798 Offset: 0x13CB798 VA: 0x13CF798
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.SetException
	|
	|-RVA: 0x13D078C Offset: 0x13CC78C VA: 0x13D078C
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.SetException
	|
	|-RVA: 0x14D0B30 Offset: 0x14CCB30 VA: 0x14D0B30
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.SetException
	|
	|-RVA: 0x14D1B1C Offset: 0x14CDB1C VA: 0x14D1B1C
	|-AsyncTaskMethodBuilder<bool>.SetException
	|
	|-RVA: 0x14D2AEC Offset: 0x14CEAEC VA: 0x14D2AEC
	|-AsyncTaskMethodBuilder<int>.SetException
	|
	|-RVA: 0x14D3AB0 Offset: 0x14CFAB0 VA: 0x14D3AB0
	|-AsyncTaskMethodBuilder<object>.SetException
	|
	|-RVA: 0x14D412C Offset: 0x14D012C VA: 0x14D412C
	|-AsyncTaskMethodBuilder<VoidTaskResult>.SetException
	|
	|-RVA: 0x14D5458 Offset: 0x14D1458 VA: 0x14D5458
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.SetException
	*/

	// RVA: -1 Offset: -1
	internal static Task<TResult> GetTaskForResult(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13CF29C Offset: 0x13CB29C VA: 0x13CF29C
	|-AsyncTaskMethodBuilder<Nullable<int>>.GetTaskForResult
	|
	|-RVA: 0x13CF928 Offset: 0x13CB928 VA: 0x13CF928
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>.GetTaskForResult
	|
	|-RVA: 0x13D091C Offset: 0x13CC91C VA: 0x13D091C
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>.GetTaskForResult
	|
	|-RVA: 0x14D0CC0 Offset: 0x14CCCC0 VA: 0x14D0CC0
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>.GetTaskForResult
	|
	|-RVA: 0x14D1CAC Offset: 0x14CDCAC VA: 0x14D1CAC
	|-AsyncTaskMethodBuilder<bool>.GetTaskForResult
	|
	|-RVA: 0x14D2C7C Offset: 0x14CEC7C VA: 0x14D2C7C
	|-AsyncTaskMethodBuilder<int>.GetTaskForResult
	|
	|-RVA: 0x14D3C40 Offset: 0x14CFC40 VA: 0x14D3C40
	|-AsyncTaskMethodBuilder<object>.GetTaskForResult
	|
	|-RVA: 0x14D42BC Offset: 0x14D02BC VA: 0x14D42BC
	|-AsyncTaskMethodBuilder<VoidTaskResult>.GetTaskForResult
	|
	|-RVA: 0x14D561C Offset: 0x14D161C VA: 0x14D561C
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>.GetTaskForResult
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13CF3A8 Offset: 0x13CB3A8 VA: 0x13CF3A8
	|-AsyncTaskMethodBuilder<Nullable<int>>..cctor
	|
	|-RVA: 0x13D035C Offset: 0x13CC35C VA: 0x13D035C
	|-AsyncTaskMethodBuilder<ValueTuple<bool, object>>..cctor
	|
	|-RVA: 0x13D13F4 Offset: 0x13CD3F4 VA: 0x13D13F4
	|-AsyncTaskMethodBuilder<ValueTuple<object, object, int>>..cctor
	|
	|-RVA: 0x14D1728 Offset: 0x14CD728 VA: 0x14D1728
	|-AsyncTaskMethodBuilder<ValueTuple<object, bool, bool, object, object>>..cctor
	|
	|-RVA: 0x14D270C Offset: 0x14CE70C VA: 0x14D270C
	|-AsyncTaskMethodBuilder<bool>..cctor
	|
	|-RVA: 0x14D36D0 Offset: 0x14CF6D0 VA: 0x14D36D0
	|-AsyncTaskMethodBuilder<int>..cctor
	|
	|-RVA: 0x14D3D4C Offset: 0x14CFD4C VA: 0x14D3D4C
	|-AsyncTaskMethodBuilder<object>..cctor
	|
	|-RVA: 0x14D4D18 Offset: 0x14D0D18 VA: 0x14D4D18
	|-AsyncTaskMethodBuilder<VoidTaskResult>..cctor
	|
	|-RVA: 0x14D65C8 Offset: 0x14D25C8 VA: 0x14D65C8
	|-AsyncTaskMethodBuilder<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Runtime.CompilerServices
internal static class AsyncTaskCache // TypeDefIndex: 1136
{
	// Fields
	internal static readonly Task<bool> TrueTask; // 0x0
	internal static readonly Task<bool> FalseTask; // 0x8
	internal static readonly Task<int>[] Int32Tasks; // 0x10

	// Methods

	// RVA: 0x17D3BA4 Offset: 0x17CFBA4 VA: 0x17D3BA4
	private static Task<int>[] CreateInt32Tasks() { }

	// RVA: -1 Offset: -1
	internal static Task<TResult> CreateCacheableTask<TResult>(TResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E8D68 Offset: 0x10E4D68 VA: 0x10E8D68
	|-AsyncTaskCache.CreateCacheableTask<Nullable<int>>
	|
	|-RVA: 0x10E8DD4 Offset: 0x10E4DD4 VA: 0x10E8DD4
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<bool, object>>
	|
	|-RVA: 0x10E8E48 Offset: 0x10E4E48 VA: 0x10E8E48
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<object, object, int>>
	|
	|-RVA: 0x10E8ED8 Offset: 0x10E4ED8 VA: 0x10E8ED8
	|-AsyncTaskCache.CreateCacheableTask<ValueTuple<object, bool, bool, object, object>>
	|
	|-RVA: 0x10E8F58 Offset: 0x10E4F58 VA: 0x10E8F58
	|-AsyncTaskCache.CreateCacheableTask<bool>
	|
	|-RVA: 0x10E8FC4 Offset: 0x10E4FC4 VA: 0x10E8FC4
	|-AsyncTaskCache.CreateCacheableTask<int>
	|
	|-RVA: 0x10E9030 Offset: 0x10E5030 VA: 0x10E9030
	|-AsyncTaskCache.CreateCacheableTask<object>
	|
	|-RVA: 0x10E909C Offset: 0x10E509C VA: 0x10E909C
	|-AsyncTaskCache.CreateCacheableTask<VoidTaskResult>
	|
	|-RVA: 0x10E9108 Offset: 0x10E5108 VA: 0x10E9108
	|-AsyncTaskCache.CreateCacheableTask<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17D3CC4 Offset: 0x17CFCC4 VA: 0x17D3CC4
	private static void .cctor() { }
}

// Namespace: 
internal sealed class AsyncMethodBuilderCore.MoveNextRunner // TypeDefIndex: 1137
{
	// Fields
	private readonly ExecutionContext m_context; // 0x10
	internal IAsyncStateMachine m_stateMachine; // 0x18
	private static ContextCallback s_invokeMoveNext; // 0x0

	// Methods

	// RVA: 0x17D3F4C Offset: 0x17CFF4C VA: 0x17D3F4C
	internal void .ctor(ExecutionContext context, IAsyncStateMachine stateMachine) { }

	// RVA: 0x17D43E0 Offset: 0x17D03E0 VA: 0x17D43E0
	internal void Run() { }

	// RVA: 0x17D45F0 Offset: 0x17D05F0 VA: 0x17D45F0
	private static void InvokeMoveNext(object stateMachine) { }
}

// Namespace: 
private class AsyncMethodBuilderCore.ContinuationWrapper // TypeDefIndex: 1138
{
	// Fields
	internal readonly Action m_continuation; // 0x10
	private readonly Action m_invokeAction; // 0x18
	internal readonly Task m_innerTask; // 0x20

	// Methods

	// RVA: 0x17D42EC Offset: 0x17D02EC VA: 0x17D42EC
	internal void .ctor(Action continuation, Action invokeAction, Task innerTask) { }

	// RVA: 0x17D46D0 Offset: 0x17D06D0 VA: 0x17D46D0
	internal void Invoke() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AsyncMethodBuilderCore.<>c__DisplayClass5_0 // TypeDefIndex: 1139
{
	// Fields
	public Task innerTask; // 0x10
	public Action continuation; // 0x18

	// Methods

	// RVA: 0x17D407C Offset: 0x17D007C VA: 0x17D407C
	public void .ctor() { }

	// RVA: 0x17D46F0 Offset: 0x17D06F0 VA: 0x17D46F0
	internal void <OutputAsyncCausalityEvents>b__0() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AsyncMethodBuilderCore.<>c // TypeDefIndex: 1140
{
	// Fields
	public static readonly AsyncMethodBuilderCore.<>c <>9; // 0x0
	public static SendOrPostCallback <>9__7_0; // 0x8
	public static WaitCallback <>9__7_1; // 0x10

	// Methods

	// RVA: 0x17D474C Offset: 0x17D074C VA: 0x17D474C
	private static void .cctor() { }

	// RVA: 0x17D47B4 Offset: 0x17D07B4 VA: 0x17D47B4
	public void .ctor() { }

	// RVA: 0x17D47BC Offset: 0x17D07BC VA: 0x17D47BC
	internal void <ThrowAsync>b__7_0(object state) { }

	// RVA: 0x17D4814 Offset: 0x17D0814 VA: 0x17D4814
	internal void <ThrowAsync>b__7_1(object state) { }
}

// Namespace: System.Runtime.CompilerServices
internal struct AsyncMethodBuilderCore // TypeDefIndex: 1141
{
	// Fields
	internal IAsyncStateMachine m_stateMachine; // 0x0
	internal Action m_defaultContextAction; // 0x8

	// Methods

	// RVA: 0x17D3300 Offset: 0x17CF300 VA: 0x17D3300
	public void SetStateMachine(IAsyncStateMachine stateMachine) { }

	// RVA: 0x17D3D78 Offset: 0x17CFD78 VA: 0x17D3D78
	internal Action GetCompletionAction(Task taskForTracing, ref AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize) { }

	// RVA: 0x17D3F90 Offset: 0x17CFF90 VA: 0x17D3F90
	private Action OutputAsyncCausalityEvents(Task innerTask, Action continuation) { }

	// RVA: 0x17D4140 Offset: 0x17D0140 VA: 0x17D4140
	internal void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, Task builtTask) { }

	// RVA: 0x17D3654 Offset: 0x17CF654 VA: 0x17D3654
	internal static void ThrowAsync(Exception exception, SynchronizationContext targetContext) { }

	// RVA: 0x17D4084 Offset: 0x17D0084 VA: 0x17D4084
	internal static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask) { }

	// RVA: 0x17D435C Offset: 0x17D035C VA: 0x17D435C
	internal static Task TryGetContinuationTask(Action action) { }
}

// Namespace: System.Runtime.CompilerServices
[Serializable]
public enum LoadHint // TypeDefIndex: 1142
{
	// Fields
	public int value__; // 0x0
	public const LoadHint Default = 0;
	public const LoadHint Always = 1;
	public const LoadHint Sometimes = 2;
}

// Namespace: System.Runtime.CompilerServices
[Usage(1)]
[Serializable]
public sealed class DefaultDependencyAttribute : Attribute // TypeDefIndex: 1143
{
	// Fields
	private LoadHint loadHint; // 0x10

	// Methods

	// RVA: 0x17D486C Offset: 0x17D086C VA: 0x17D486C
	public void .ctor(LoadHint loadHintArgument) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1, AllowMultiple = True)]
[Serializable]
public sealed class DependencyAttribute : Attribute // TypeDefIndex: 1144
{
	// Fields
	private string dependentAssembly; // 0x10
	private LoadHint loadHint; // 0x18

	// Methods

	// RVA: 0x17D4894 Offset: 0x17D0894 VA: 0x17D4894
	public void .ctor(string dependentAssemblyArgument, LoadHint loadHintArgument) { }
}

// Namespace: System.Runtime.CompilerServices
[ComVisible(True)]
[Flags]
[Serializable]
public enum CompilationRelaxations // TypeDefIndex: 1145
{
	// Fields
	public int value__; // 0x0
	public const CompilationRelaxations NoStringInterning = 8;
}

// Namespace: System.Runtime.CompilerServices
[ComVisible(True)]
[Usage(71)]
[Serializable]
public class CompilationRelaxationsAttribute : Attribute // TypeDefIndex: 1146
{
	// Fields
	private int m_relaxations; // 0x10

	// Properties
	public int CompilationRelaxations { get; }

	// Methods

	// RVA: 0x17D48D0 Offset: 0x17D08D0 VA: 0x17D48D0
	public void .ctor(int relaxations) { }

	// RVA: 0x17D48F8 Offset: 0x17D08F8 VA: 0x17D48F8
	public void .ctor(CompilationRelaxations relaxations) { }

	// RVA: 0x17D4920 Offset: 0x17D0920 VA: 0x17D4920
	public int get_CompilationRelaxations() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1, AllowMultiple = True, Inherited = False)]
public sealed class InternalsVisibleToAttribute : Attribute // TypeDefIndex: 1147
{
	// Fields
	private string _assemblyName; // 0x10
	private bool _allInternalsVisible; // 0x18

	// Properties
	public bool AllInternalsVisible { set; }

	// Methods

	// RVA: 0x17D4928 Offset: 0x17D0928 VA: 0x17D4928
	public void .ctor(string assemblyName) { }

	// RVA: 0x17D4960 Offset: 0x17D0960 VA: 0x17D4960
	public void set_AllInternalsVisible(bool value) { }
}

// Namespace: System.Runtime.CompilerServices
[FriendAccessAllowed]
[Usage(2044, AllowMultiple = False, Inherited = False)]
internal sealed class FriendAccessAllowedAttribute : Attribute // TypeDefIndex: 1148
{
	// Methods

	// RVA: 0x17D4968 Offset: 0x17D0968 VA: 0x17D4968
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(1036, AllowMultiple = True, Inherited = False)]
internal sealed class TypeDependencyAttribute : Attribute // TypeDefIndex: 1149
{
	// Fields
	private string typeName; // 0x10

	// Methods

	// RVA: 0x17D4970 Offset: 0x17D0970 VA: 0x17D4970
	public void .ctor(string typeName) { }
}

// Namespace: System.Runtime.CompilerServices
internal static class JitHelpers // TypeDefIndex: 1150
{
	// Methods

	// RVA: -1 Offset: -1
	internal static T UnsafeCast<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111AAC8 Offset: 0x1116AC8 VA: 0x111AAC8
	|-JitHelpers.UnsafeCast<object>
	*/

	// RVA: -1 Offset: -1
	internal static int UnsafeEnumCast<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111AB00 Offset: 0x1116B00 VA: 0x111AB00
	|-JitHelpers.UnsafeEnumCast<Int32Enum>
	|
	|-RVA: 0x111AB38 Offset: 0x1116B38 VA: 0x111AB38
	|-JitHelpers.UnsafeEnumCast<UInt32Enum>
	|
	|-RVA: 0x111AB70 Offset: 0x1116B70 VA: 0x111AB70
	|-JitHelpers.UnsafeEnumCast<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	internal static long UnsafeEnumCastLong<T>(T val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111AC20 Offset: 0x1116C20 VA: 0x111AC20
	|-JitHelpers.UnsafeEnumCastLong<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: System.Runtime.CompilerServices
internal struct Ephemeron // TypeDefIndex: 1151
{
	// Fields
	internal object key; // 0x0
	internal object value; // 0x8
}

// Namespace: 
public sealed class ConditionalWeakTable.CreateValueCallback<TKey, TValue> : MulticastDelegate // TypeDefIndex: 1152
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1578564 Offset: 0x1574564 VA: 0x1578564
	|-ConditionalWeakTable.CreateValueCallback<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TValue Invoke(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157866C Offset: 0x157466C VA: 0x157866C
	|-ConditionalWeakTable.CreateValueCallback<object, object>.Invoke
	*/
}

// Namespace: 
private sealed class ConditionalWeakTable.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator // TypeDefIndex: 1153
{
	// Fields
	private ConditionalWeakTable<TKey, TValue> _table; // 0x0
	private int _currentIndex; // 0x0
	private KeyValuePair<TKey, TValue> _current; // 0x0

	// Properties
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ConditionalWeakTable<TKey, TValue> table) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12058F8 Offset: 0x12018F8 VA: 0x12058F8
	|-ConditionalWeakTable.Enumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1205938 Offset: 0x1201938 VA: 0x1205938
	|-ConditionalWeakTable.Enumerator<object, object>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12059C8 Offset: 0x12019C8 VA: 0x12059C8
	|-ConditionalWeakTable.Enumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1205A40 Offset: 0x1201A40 VA: 0x1205A40
	|-ConditionalWeakTable.Enumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1205CAC Offset: 0x1201CAC VA: 0x1205CAC
	|-ConditionalWeakTable.Enumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1205CD0 Offset: 0x1201CD0 VA: 0x1205CD0
	|-ConditionalWeakTable.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1205D20 Offset: 0x1201D20 VA: 0x1205D20
	|-ConditionalWeakTable.Enumerator<object, object>.Reset
	*/
}

// Namespace: System.Runtime.CompilerServices
public sealed class ConditionalWeakTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 1154
{
	// Fields
	private Ephemeron[] data; // 0x0
	private object _lock; // 0x0
	private int size; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1574DF4 Offset: 0x1570DF4 VA: 0x1574DF4
	|-ConditionalWeakTable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1574ECC Offset: 0x1570ECC VA: 0x1574ECC
	|-ConditionalWeakTable<object, object>.Finalize
	*/

	// RVA: -1 Offset: -1
	private void RehashWithoutResize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1574EE0 Offset: 0x1570EE0 VA: 0x1574EE0
	|-ConditionalWeakTable<object, object>.RehashWithoutResize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15750EC Offset: 0x15710EC VA: 0x15750EC
	|-ConditionalWeakTable<object, object>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void Rehash() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157514C Offset: 0x157114C VA: 0x157514C
	|-ConditionalWeakTable<object, object>.Rehash
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1575408 Offset: 0x1571408 VA: 0x1575408
	|-ConditionalWeakTable<object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1575744 Offset: 0x1571744 VA: 0x1575744
	|-ConditionalWeakTable<object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15759A4 Offset: 0x15719A4 VA: 0x15759A4
	|-ConditionalWeakTable<object, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue GetValue(TKey key, ConditionalWeakTable.CreateValueCallback<TKey, TValue> createValueCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1575C10 Offset: 0x1571C10 VA: 0x1575C10
	|-ConditionalWeakTable<object, object>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1575DC8 Offset: 0x1571DC8 VA: 0x1575DC8
	|-ConditionalWeakTable<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1575FB8 Offset: 0x1571FB8 VA: 0x1575FB8
	|-ConditionalWeakTable<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: System.Runtime.CompilerServices
public static class RuntimeHelpers // TypeDefIndex: 1155
{
	// Properties
	public static int OffsetToStringData { get; }

	// Methods

	// RVA: 0x17D49EC Offset: 0x17D09EC VA: 0x17D49EC
	private static void InitializeArray(Array array, IntPtr fldHandle) { }

	// RVA: 0x17D49F0 Offset: 0x17D09F0 VA: 0x17D49F0
	public static void InitializeArray(Array array, RuntimeFieldHandle fldHandle) { }

	// RVA: 0x17D0B80 Offset: 0x17CCB80 VA: 0x17D0B80
	public static int get_OffsetToStringData() { }

	// RVA: 0x17D4A34 Offset: 0x17D0A34 VA: 0x17D4A34
	public static int GetHashCode(object o) { }

	// RVA: 0x17D4A3C Offset: 0x17D0A3C VA: 0x17D4A3C
	public static object GetObjectValue(object obj) { }

	// RVA: 0x17D4A40 Offset: 0x17D0A40 VA: 0x17D4A40
	private static bool SufficientExecutionStack() { }

	// RVA: 0x17D4A44 Offset: 0x17D0A44 VA: 0x17D4A44
	public static bool TryEnsureSufficientExecutionStack() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x17D4A48 Offset: 0x17D0A48 VA: 0x17D4A48
	public static void PrepareConstrainedRegions() { }

	// RVA: -1 Offset: -1
	public static bool IsReferenceOrContainsReferences<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1142A2C Offset: 0x113EA2C VA: 0x1142A2C
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ArraySegment<byte>>
	|
	|-RVA: 0x1142B20 Offset: 0x113EB20 VA: 0x1142B20
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<double, object>>
	|
	|-RVA: 0x1142C14 Offset: 0x113EC14 VA: 0x1142C14
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<int, object>>
	|
	|-RVA: 0x1142D08 Offset: 0x113ED08 VA: 0x1142D08
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, double>>
	|
	|-RVA: 0x1142DFC Offset: 0x113EDFC VA: 0x1142DFC
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, int>>
	|
	|-RVA: 0x1142EF0 Offset: 0x113EEF0 VA: 0x1142EF0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, long>>
	|
	|-RVA: 0x1142FE4 Offset: 0x113EFE4 VA: 0x1142FE4
	|-RuntimeHelpers.IsReferenceOrContainsReferences<KeyValuePair<object, object>>
	|
	|-RVA: 0x11430D8 Offset: 0x113F0D8 VA: 0x11430D8
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ObjectIntPair<object>>
	|
	|-RVA: 0x11431CC Offset: 0x113F1CC VA: 0x11431CC
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<int, int>>
	|
	|-RVA: 0x11432C0 Offset: 0x113F2C0 VA: 0x11432C0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<int, object>>
	|
	|-RVA: 0x11433B4 Offset: 0x113F3B4 VA: 0x11433B4
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<object, double>>
	|
	|-RVA: 0x11434A8 Offset: 0x113F4A8 VA: 0x11434A8
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<object, int>>
	|
	|-RVA: 0x114359C Offset: 0x113F59C VA: 0x114359C
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<object, object>>
	|
	|-RVA: 0x1143690 Offset: 0x113F690 VA: 0x1143690
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<object, float>>
	|
	|-RVA: 0x1143784 Offset: 0x113F784 VA: 0x1143784
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<uint, uint>>
	|
	|-RVA: 0x1143878 Offset: 0x113F878 VA: 0x1143878
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ValueTuple<object, object, object, int>>
	|
	|-RVA: 0x114396C Offset: 0x113F96C VA: 0x114396C
	|-RuntimeHelpers.IsReferenceOrContainsReferences<bool>
	|
	|-RVA: 0x1143A60 Offset: 0x113FA60 VA: 0x1143A60
	|-RuntimeHelpers.IsReferenceOrContainsReferences<byte>
	|
	|-RVA: 0x1143B54 Offset: 0x113FB54 VA: 0x1143B54
	|-RuntimeHelpers.IsReferenceOrContainsReferences<char>
	|
	|-RVA: 0x1143C48 Offset: 0x113FC48 VA: 0x1143C48
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Color32>
	|
	|-RVA: 0x1143D3C Offset: 0x113FD3C VA: 0x1143D3C
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DateTime>
	|
	|-RVA: 0x1143E30 Offset: 0x113FE30 VA: 0x1143E30
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DateTimeOffset>
	|
	|-RVA: 0x1143F24 Offset: 0x113FF24 VA: 0x1143F24
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Decimal>
	|
	|-RVA: 0x1144018 Offset: 0x1140018 VA: 0x1144018
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DictionaryEntry>
	|
	|-RVA: 0x114410C Offset: 0x114010C VA: 0x114410C
	|-RuntimeHelpers.IsReferenceOrContainsReferences<double>
	|
	|-RVA: 0x1144200 Offset: 0x1140200 VA: 0x1144200
	|-RuntimeHelpers.IsReferenceOrContainsReferences<FileList>
	|
	|-RVA: 0x11442F4 Offset: 0x11402F4 VA: 0x11442F4
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GlyphMarshallingStruct>
	|
	|-RVA: 0x11443E8 Offset: 0x11403E8 VA: 0x11443E8
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x11444DC Offset: 0x11404DC VA: 0x11444DC
	|-RuntimeHelpers.IsReferenceOrContainsReferences<GlyphRect>
	|
	|-RVA: 0x11445D0 Offset: 0x11405D0 VA: 0x11445D0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Guid>
	|
	|-RVA: 0x11446C4 Offset: 0x11406C4 VA: 0x11446C4
	|-RuntimeHelpers.IsReferenceOrContainsReferences<short>
	|
	|-RVA: 0x11447B8 Offset: 0x11407B8 VA: 0x11447B8
	|-RuntimeHelpers.IsReferenceOrContainsReferences<int>
	|
	|-RVA: 0x11448AC Offset: 0x11408AC VA: 0x11448AC
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Int32Enum>
	|
	|-RVA: 0x11449A0 Offset: 0x11409A0 VA: 0x11449A0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<long>
	|
	|-RVA: 0x1144A94 Offset: 0x1140A94 VA: 0x1144A94
	|-RuntimeHelpers.IsReferenceOrContainsReferences<IntPtr>
	|
	|-RVA: 0x1144B88 Offset: 0x1140B88 VA: 0x1144B88
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InterpretedFrameInfo>
	|
	|-RVA: 0x1144C7C Offset: 0x1140C7C VA: 0x1144C7C
	|-RuntimeHelpers.IsReferenceOrContainsReferences<JsonPosition>
	|
	|-RVA: 0x1144D70 Offset: 0x1140D70 VA: 0x1144D70
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Keyframe>
	|
	|-RVA: 0x1144E64 Offset: 0x1140E64 VA: 0x1144E64
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LigatureSubstitutionRecord>
	|
	|-RVA: 0x1144F58 Offset: 0x1140F58 VA: 0x1144F58
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LigatureSubstitutionRecord>
	|
	|-RVA: 0x114504C Offset: 0x114104C VA: 0x114504C
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x1145140 Offset: 0x1141140 VA: 0x1145140
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x1145234 Offset: 0x1141234 VA: 0x1145234
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x1145328 Offset: 0x1141328 VA: 0x1145328
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x114541C Offset: 0x114141C VA: 0x114541C
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MultipleSubstitutionRecord>
	|
	|-RVA: 0x1145510 Offset: 0x1141510 VA: 0x1145510
	|-RuntimeHelpers.IsReferenceOrContainsReferences<MultipleSubstitutionRecord>
	|
	|-RVA: 0x1145604 Offset: 0x1141604 VA: 0x1145604
	|-RuntimeHelpers.IsReferenceOrContainsReferences<object>
	|
	|-RVA: 0x11456F8 Offset: 0x11416F8 VA: 0x11456F8
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RangePositionInfo>
	|
	|-RVA: 0x11457EC Offset: 0x11417EC VA: 0x11457EC
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RaycastHit2D>
	|
	|-RVA: 0x11458E0 Offset: 0x11418E0 VA: 0x11458E0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RaycastResult>
	|
	|-RVA: 0x11459D4 Offset: 0x11419D4 VA: 0x11459D4
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RenderInstancedDataLayout>
	|
	|-RVA: 0x1145AC8 Offset: 0x1141AC8 VA: 0x1145AC8
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ResourceLocator>
	|
	|-RVA: 0x1145BBC Offset: 0x1141BBC VA: 0x1145BBC
	|-RuntimeHelpers.IsReferenceOrContainsReferences<sbyte>
	|
	|-RVA: 0x1145CB0 Offset: 0x1141CB0 VA: 0x1145CB0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<float>
	|
	|-RVA: 0x1145DA4 Offset: 0x1141DA4 VA: 0x1145DA4
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TimeSpan>
	|
	|-RVA: 0x1145E98 Offset: 0x1141E98 VA: 0x1145E98
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UICharInfo>
	|
	|-RVA: 0x1145F8C Offset: 0x1141F8C VA: 0x1145F8C
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UILineInfo>
	|
	|-RVA: 0x1146080 Offset: 0x1142080 VA: 0x1146080
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UIVertex>
	|
	|-RVA: 0x1146174 Offset: 0x1142174 VA: 0x1146174
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ushort>
	|
	|-RVA: 0x1146268 Offset: 0x1142268 VA: 0x1146268
	|-RuntimeHelpers.IsReferenceOrContainsReferences<uint>
	|
	|-RVA: 0x114635C Offset: 0x114235C VA: 0x114635C
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UInt32Enum>
	|
	|-RVA: 0x1146450 Offset: 0x1142450 VA: 0x1146450
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ulong>
	|
	|-RVA: 0x1146544 Offset: 0x1142544 VA: 0x1146544
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector2>
	|
	|-RVA: 0x1146638 Offset: 0x1142638 VA: 0x1146638
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector3>
	|
	|-RVA: 0x114672C Offset: 0x114272C VA: 0x114672C
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Vector4>
	|
	|-RVA: 0x1146820 Offset: 0x1142820 VA: 0x1146820
	|-RuntimeHelpers.IsReferenceOrContainsReferences<X509ChainStatus>
	|
	|-RVA: 0x1146914 Offset: 0x1142914 VA: 0x1146914
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XPathNodeRef>
	|
	|-RVA: 0x1146A08 Offset: 0x1142A08 VA: 0x1146A08
	|-RuntimeHelpers.IsReferenceOrContainsReferences<ZipGenericExtraField>
	|
	|-RVA: 0x1146AFC Offset: 0x1142AFC VA: 0x1146AFC
	|-RuntimeHelpers.IsReferenceOrContainsReferences<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x1146BF0 Offset: 0x1142BF0 VA: 0x1146BF0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<jvalue>
	|
	|-RVA: 0x1146CE4 Offset: 0x1142CE4 VA: 0x1146CE4
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Awaitable.AwaitableAndFrameIndex>
	|
	|-RVA: 0x1146DD8 Offset: 0x1142DD8 VA: 0x1146DD8
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x1146ECC Offset: 0x1142ECC VA: 0x1146ECC
	|-RuntimeHelpers.IsReferenceOrContainsReferences<DescriptorPool.EnumValueByNameDescriptorKey>
	|
	|-RVA: 0x1146FC0 Offset: 0x1142FC0 VA: 0x1146FC0
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Element.Obstacle>
	|
	|-RVA: 0x11470B4 Offset: 0x11430B4 VA: 0x11470B4
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Element.Texture>
	|
	|-RVA: 0x11471A8 Offset: 0x11431A8 VA: 0x11471A8
	|-RuntimeHelpers.IsReferenceOrContainsReferences<LuaEnv.GCAction>
	|
	|-RVA: 0x114729C Offset: 0x114329C VA: 0x114729C
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Regex.CachedCodeEntryKey>
	|
	|-RVA: 0x1147390 Offset: 0x1143390 VA: 0x1147390
	|-RuntimeHelpers.IsReferenceOrContainsReferences<RegexCharClass.SingleRange>
	|
	|-RVA: 0x1147484 Offset: 0x1143484 VA: 0x1147484
	|-RuntimeHelpers.IsReferenceOrContainsReferences<SequenceNode.SequenceConstructPosContext>
	|
	|-RVA: 0x1147578 Offset: 0x1143578 VA: 0x1147578
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TMP_DynamicFontAssetUtilities.FontReference>
	|
	|-RVA: 0x114766C Offset: 0x114366C VA: 0x114766C
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TMP_ResourceManager.FontAssetRef>
	|
	|-RVA: 0x1147760 Offset: 0x1143760 VA: 0x1147760
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextResourceManager.FontAssetRef>
	|
	|-RVA: 0x1147854 Offset: 0x1143854 VA: 0x1147854
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TextSettings.FontReferenceMap>
	|
	|-RVA: 0x1147948 Offset: 0x1143948 VA: 0x1147948
	|-RuntimeHelpers.IsReferenceOrContainsReferences<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x1147A3C Offset: 0x1143A3C VA: 0x1147A3C
	|-RuntimeHelpers.IsReferenceOrContainsReferences<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x1147B30 Offset: 0x1143B30 VA: 0x1147B30
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Utils.MethodKey>
	|
	|-RVA: 0x1147C24 Offset: 0x1143C24 VA: 0x1147C24
	|-RuntimeHelpers.IsReferenceOrContainsReferences<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x1147D18 Offset: 0x1143D18 VA: 0x1147D18
	|-RuntimeHelpers.IsReferenceOrContainsReferences<BindingRestrictions.TestBuilder.AndNode>
	|
	|-RVA: 0x1147E0C Offset: 0x1143E0C VA: 0x1147E0C
	|-RuntimeHelpers.IsReferenceOrContainsReferences<InstructionList.DebugView.InstructionView>
	|
	|-RVA: 0x1147F00 Offset: 0x1143F00 VA: 0x1147F00
	|-RuntimeHelpers.IsReferenceOrContainsReferences<Position.Sequential.Node>
	*/
}

// Namespace: System.Runtime.CompilerServices
internal static class Unsafe // TypeDefIndex: 1156
{
	// Methods

	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103C18C Offset: 0x103818C VA: 0x103C18C
	|-Unsafe.Add<ArraySegment<byte>>
	|
	|-RVA: 0x103C194 Offset: 0x1038194 VA: 0x103C194
	|-Unsafe.Add<KeyValuePair<double, object>>
	|
	|-RVA: 0x103C19C Offset: 0x103819C VA: 0x103C19C
	|-Unsafe.Add<KeyValuePair<int, object>>
	|
	|-RVA: 0x103C1A4 Offset: 0x10381A4 VA: 0x103C1A4
	|-Unsafe.Add<KeyValuePair<object, double>>
	|
	|-RVA: 0x103C1AC Offset: 0x10381AC VA: 0x103C1AC
	|-Unsafe.Add<KeyValuePair<object, int>>
	|
	|-RVA: 0x103C1B4 Offset: 0x10381B4 VA: 0x103C1B4
	|-Unsafe.Add<KeyValuePair<object, long>>
	|
	|-RVA: 0x103C1BC Offset: 0x10381BC VA: 0x103C1BC
	|-Unsafe.Add<KeyValuePair<object, object>>
	|
	|-RVA: 0x103C1C4 Offset: 0x10381C4 VA: 0x103C1C4
	|-Unsafe.Add<ValueTuple<int, int>>
	|
	|-RVA: 0x103C1CC Offset: 0x10381CC VA: 0x103C1CC
	|-Unsafe.Add<ValueTuple<object, double>>
	|
	|-RVA: 0x103C1D4 Offset: 0x10381D4 VA: 0x103C1D4
	|-Unsafe.Add<ValueTuple<object, int>>
	|
	|-RVA: 0x103C1DC Offset: 0x10381DC VA: 0x103C1DC
	|-Unsafe.Add<ValueTuple<object, float>>
	|
	|-RVA: 0x103C1E4 Offset: 0x10381E4 VA: 0x103C1E4
	|-Unsafe.Add<ValueTuple<object, object, object, int>>
	|
	|-RVA: 0x103C1F0 Offset: 0x10381F0 VA: 0x103C1F0
	|-Unsafe.Add<bool>
	|
	|-RVA: 0x103C1F8 Offset: 0x10381F8 VA: 0x103C1F8
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x103C210 Offset: 0x1038210 VA: 0x103C210
	|-Unsafe.Add<char>
	|
	|-RVA: 0x103C228 Offset: 0x1038228 VA: 0x103C228
	|-Unsafe.Add<Color32>
	|
	|-RVA: 0x103C230 Offset: 0x1038230 VA: 0x103C230
	|-Unsafe.Add<DateTime>
	|
	|-RVA: 0x103C238 Offset: 0x1038238 VA: 0x103C238
	|-Unsafe.Add<DateTimeOffset>
	|
	|-RVA: 0x103C240 Offset: 0x1038240 VA: 0x103C240
	|-Unsafe.Add<Decimal>
	|
	|-RVA: 0x103C248 Offset: 0x1038248 VA: 0x103C248
	|-Unsafe.Add<DictionaryEntry>
	|
	|-RVA: 0x103C250 Offset: 0x1038250 VA: 0x103C250
	|-Unsafe.Add<double>
	|
	|-RVA: 0x103C258 Offset: 0x1038258 VA: 0x103C258
	|-Unsafe.Add<FileList>
	|
	|-RVA: 0x103C260 Offset: 0x1038260 VA: 0x103C260
	|-Unsafe.Add<GlyphMarshallingStruct>
	|
	|-RVA: 0x103C26C Offset: 0x103826C VA: 0x103C26C
	|-Unsafe.Add<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x103C278 Offset: 0x1038278 VA: 0x103C278
	|-Unsafe.Add<GlyphRect>
	|
	|-RVA: 0x103C280 Offset: 0x1038280 VA: 0x103C280
	|-Unsafe.Add<short>
	|
	|-RVA: 0x103C288 Offset: 0x1038288 VA: 0x103C288
	|-Unsafe.Add<int>
	|
	|-RVA: 0x103C290 Offset: 0x1038290 VA: 0x103C290
	|-Unsafe.Add<Int32Enum>
	|
	|-RVA: 0x103C298 Offset: 0x1038298 VA: 0x103C298
	|-Unsafe.Add<long>
	|
	|-RVA: 0x103C2A0 Offset: 0x10382A0 VA: 0x103C2A0
	|-Unsafe.Add<IntPtr>
	|
	|-RVA: 0x103C2B0 Offset: 0x10382B0 VA: 0x103C2B0
	|-Unsafe.Add<InterpretedFrameInfo>
	|
	|-RVA: 0x103C2B8 Offset: 0x10382B8 VA: 0x103C2B8
	|-Unsafe.Add<JsonPosition>
	|
	|-RVA: 0x103C2C4 Offset: 0x10382C4 VA: 0x103C2C4
	|-Unsafe.Add<Keyframe>
	|
	|-RVA: 0x103C2D0 Offset: 0x10382D0 VA: 0x103C2D0
	|-Unsafe.Add<LigatureSubstitutionRecord>
	|
	|-RVA: 0x103C2D8 Offset: 0x10382D8 VA: 0x103C2D8
	|-Unsafe.Add<LigatureSubstitutionRecord>
	|
	|-RVA: 0x103C2E0 Offset: 0x10382E0 VA: 0x103C2E0
	|-Unsafe.Add<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x103C2EC Offset: 0x10382EC VA: 0x103C2EC
	|-Unsafe.Add<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x103C2F8 Offset: 0x10382F8 VA: 0x103C2F8
	|-Unsafe.Add<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x103C304 Offset: 0x1038304 VA: 0x103C304
	|-Unsafe.Add<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x103C310 Offset: 0x1038310 VA: 0x103C310
	|-Unsafe.Add<MultipleSubstitutionRecord>
	|
	|-RVA: 0x103C318 Offset: 0x1038318 VA: 0x103C318
	|-Unsafe.Add<MultipleSubstitutionRecord>
	|
	|-RVA: 0x103C320 Offset: 0x1038320 VA: 0x103C320
	|-Unsafe.Add<object>
	|
	|-RVA: 0x103C328 Offset: 0x1038328 VA: 0x103C328
	|-Unsafe.Add<RangePositionInfo>
	|
	|-RVA: 0x103C330 Offset: 0x1038330 VA: 0x103C330
	|-Unsafe.Add<RaycastHit2D>
	|
	|-RVA: 0x103C33C Offset: 0x103833C VA: 0x103C33C
	|-Unsafe.Add<RaycastResult>
	|
	|-RVA: 0x103C348 Offset: 0x1038348 VA: 0x103C348
	|-Unsafe.Add<sbyte>
	|
	|-RVA: 0x103C350 Offset: 0x1038350 VA: 0x103C350
	|-Unsafe.Add<float>
	|
	|-RVA: 0x103C358 Offset: 0x1038358 VA: 0x103C358
	|-Unsafe.Add<TimeSpan>
	|
	|-RVA: 0x103C360 Offset: 0x1038360 VA: 0x103C360
	|-Unsafe.Add<UICharInfo>
	|
	|-RVA: 0x103C36C Offset: 0x103836C VA: 0x103C36C
	|-Unsafe.Add<UILineInfo>
	|
	|-RVA: 0x103C374 Offset: 0x1038374 VA: 0x103C374
	|-Unsafe.Add<UIVertex>
	|
	|-RVA: 0x103C380 Offset: 0x1038380 VA: 0x103C380
	|-Unsafe.Add<ushort>
	|
	|-RVA: 0x103C388 Offset: 0x1038388 VA: 0x103C388
	|-Unsafe.Add<uint>
	|
	|-RVA: 0x103C390 Offset: 0x1038390 VA: 0x103C390
	|-Unsafe.Add<UInt32Enum>
	|
	|-RVA: 0x103C398 Offset: 0x1038398 VA: 0x103C398
	|-Unsafe.Add<ulong>
	|
	|-RVA: 0x103C3A0 Offset: 0x10383A0 VA: 0x103C3A0
	|-Unsafe.Add<Vector2>
	|
	|-RVA: 0x103C3A8 Offset: 0x10383A8 VA: 0x103C3A8
	|-Unsafe.Add<Vector3>
	|
	|-RVA: 0x103C3B4 Offset: 0x10383B4 VA: 0x103C3B4
	|-Unsafe.Add<Vector4>
	|
	|-RVA: 0x103C3BC Offset: 0x10383BC VA: 0x103C3BC
	|-Unsafe.Add<X509ChainStatus>
	|
	|-RVA: 0x103C3C4 Offset: 0x10383C4 VA: 0x103C3C4
	|-Unsafe.Add<ZipGenericExtraField>
	|
	|-RVA: 0x103C3CC Offset: 0x10383CC VA: 0x103C3CC
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x103C4A0 Offset: 0x10384A0 VA: 0x103C4A0
	|-Unsafe.Add<jvalue>
	|
	|-RVA: 0x103C4A8 Offset: 0x10384A8 VA: 0x103C4A8
	|-Unsafe.Add<Awaitable.AwaitableAndFrameIndex>
	|
	|-RVA: 0x103C4B0 Offset: 0x10384B0 VA: 0x103C4B0
	|-Unsafe.Add<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x103C4B8 Offset: 0x10384B8 VA: 0x103C4B8
	|-Unsafe.Add<Element.Obstacle>
	|
	|-RVA: 0x103C4C0 Offset: 0x10384C0 VA: 0x103C4C0
	|-Unsafe.Add<Element.Texture>
	|
	|-RVA: 0x103C4CC Offset: 0x10384CC VA: 0x103C4CC
	|-Unsafe.Add<RegexCharClass.SingleRange>
	|
	|-RVA: 0x103C4D4 Offset: 0x10384D4 VA: 0x103C4D4
	|-Unsafe.Add<TextSettings.FontReferenceMap>
	|
	|-RVA: 0x103C4DC Offset: 0x10384DC VA: 0x103C4DC
	|-Unsafe.Add<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x103C4E8 Offset: 0x10384E8 VA: 0x103C4E8
	|-Unsafe.Add<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x103C4F4 Offset: 0x10384F4 VA: 0x103C4F4
	|-Unsafe.Add<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x103C4FC Offset: 0x10384FC VA: 0x103C4FC
	|-Unsafe.Add<InstructionList.DebugView.InstructionView>
	|
	|-RVA: 0x103C508 Offset: 0x1038508 VA: 0x103C508
	|-Unsafe.Add<Position.Sequential.Node>
	*/

	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, IntPtr elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103C200 Offset: 0x1038200 VA: 0x103C200
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x103C218 Offset: 0x1038218 VA: 0x103C218
	|-Unsafe.Add<char>
	|
	|-RVA: 0x103C2A8 Offset: 0x10382A8 VA: 0x103C2A8
	|-Unsafe.Add<IntPtr>
	|
	|-RVA: 0x103C414 Offset: 0x1038414 VA: 0x103C414
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void* Add<T>(void* source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103C208 Offset: 0x1038208 VA: 0x103C208
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x103C220 Offset: 0x1038220 VA: 0x103C220
	|-Unsafe.Add<char>
	|
	|-RVA: 0x103C458 Offset: 0x1038458 VA: 0x103C458
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103C510 Offset: 0x1038510 VA: 0x103C510
	|-Unsafe.AddByteOffset<ValueTuple<object, int>>
	|
	|-RVA: 0x103C538 Offset: 0x1038538 VA: 0x103C538
	|-Unsafe.AddByteOffset<ValueTuple<object, float>>
	|
	|-RVA: 0x103C560 Offset: 0x1038560 VA: 0x103C560
	|-Unsafe.AddByteOffset<bool>
	|
	|-RVA: 0x103C588 Offset: 0x1038588 VA: 0x103C588
	|-Unsafe.AddByteOffset<byte>
	|
	|-RVA: 0x103C5B0 Offset: 0x10385B0 VA: 0x103C5B0
	|-Unsafe.AddByteOffset<char>
	|
	|-RVA: 0x103C5D8 Offset: 0x10385D8 VA: 0x103C5D8
	|-Unsafe.AddByteOffset<Color32>
	|
	|-RVA: 0x103C600 Offset: 0x1038600 VA: 0x103C600
	|-Unsafe.AddByteOffset<GlyphMarshallingStruct>
	|
	|-RVA: 0x103C628 Offset: 0x1038628 VA: 0x103C628
	|-Unsafe.AddByteOffset<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x103C650 Offset: 0x1038650 VA: 0x103C650
	|-Unsafe.AddByteOffset<GlyphRect>
	|
	|-RVA: 0x103C678 Offset: 0x1038678 VA: 0x103C678
	|-Unsafe.AddByteOffset<int>
	|
	|-RVA: 0x103C6A0 Offset: 0x10386A0 VA: 0x103C6A0
	|-Unsafe.AddByteOffset<IntPtr>
	|
	|-RVA: 0x103C6C8 Offset: 0x10386C8 VA: 0x103C6C8
	|-Unsafe.AddByteOffset<Keyframe>
	|
	|-RVA: 0x103C6F0 Offset: 0x10386F0 VA: 0x103C6F0
	|-Unsafe.AddByteOffset<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x103C718 Offset: 0x1038718 VA: 0x103C718
	|-Unsafe.AddByteOffset<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x103C740 Offset: 0x1038740 VA: 0x103C740
	|-Unsafe.AddByteOffset<RaycastHit2D>
	|
	|-RVA: 0x103C768 Offset: 0x1038768 VA: 0x103C768
	|-Unsafe.AddByteOffset<ushort>
	|
	|-RVA: 0x103C790 Offset: 0x1038790 VA: 0x103C790
	|-Unsafe.AddByteOffset<uint>
	|
	|-RVA: 0x103C7B8 Offset: 0x10387B8 VA: 0x103C7B8
	|-Unsafe.AddByteOffset<Vector3>
	|
	|-RVA: 0x103C7E0 Offset: 0x10387E0 VA: 0x103C7E0
	|-Unsafe.AddByteOffset<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x103C838 Offset: 0x1038838 VA: 0x103C838
	|-Unsafe.AddByteOffset<jvalue>
	*/

	// RVA: -1 Offset: -1
	public static bool AreSame<T>(ref T left, ref T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103C860 Offset: 0x1038860 VA: 0x103C860
	|-Unsafe.AreSame<ValueTuple<object, int>>
	|
	|-RVA: 0x103C86C Offset: 0x103886C VA: 0x103C86C
	|-Unsafe.AreSame<ValueTuple<object, float>>
	|
	|-RVA: 0x103C878 Offset: 0x1038878 VA: 0x103C878
	|-Unsafe.AreSame<bool>
	|
	|-RVA: 0x103C884 Offset: 0x1038884 VA: 0x103C884
	|-Unsafe.AreSame<byte>
	|
	|-RVA: 0x103C890 Offset: 0x1038890 VA: 0x103C890
	|-Unsafe.AreSame<char>
	|
	|-RVA: 0x103C89C Offset: 0x103889C VA: 0x103C89C
	|-Unsafe.AreSame<Color32>
	|
	|-RVA: 0x103C8A8 Offset: 0x10388A8 VA: 0x103C8A8
	|-Unsafe.AreSame<GlyphMarshallingStruct>
	|
	|-RVA: 0x103C8B4 Offset: 0x10388B4 VA: 0x103C8B4
	|-Unsafe.AreSame<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x103C8C0 Offset: 0x10388C0 VA: 0x103C8C0
	|-Unsafe.AreSame<GlyphRect>
	|
	|-RVA: 0x103C8CC Offset: 0x10388CC VA: 0x103C8CC
	|-Unsafe.AreSame<int>
	|
	|-RVA: 0x103C8D8 Offset: 0x10388D8 VA: 0x103C8D8
	|-Unsafe.AreSame<IntPtr>
	|
	|-RVA: 0x103C8E4 Offset: 0x10388E4 VA: 0x103C8E4
	|-Unsafe.AreSame<Keyframe>
	|
	|-RVA: 0x103C8F0 Offset: 0x10388F0 VA: 0x103C8F0
	|-Unsafe.AreSame<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x103C8FC Offset: 0x10388FC VA: 0x103C8FC
	|-Unsafe.AreSame<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x103C908 Offset: 0x1038908 VA: 0x103C908
	|-Unsafe.AreSame<RaycastHit2D>
	|
	|-RVA: 0x103C914 Offset: 0x1038914 VA: 0x103C914
	|-Unsafe.AreSame<ushort>
	|
	|-RVA: 0x103C920 Offset: 0x1038920 VA: 0x103C920
	|-Unsafe.AreSame<uint>
	|
	|-RVA: 0x103C92C Offset: 0x103892C VA: 0x103C92C
	|-Unsafe.AreSame<Vector3>
	|
	|-RVA: 0x103C938 Offset: 0x1038938 VA: 0x103C938
	|-Unsafe.AreSame<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x103C944 Offset: 0x1038944 VA: 0x103C944
	|-Unsafe.AreSame<jvalue>
	*/

	// RVA: -1 Offset: -1
	public static T As<T>(object o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103C950 Offset: 0x1038950 VA: 0x103C950
	|-Unsafe.As<object>
	*/

	// RVA: -1 Offset: -1
	public static ref TTo As<TFrom, TTo>(ref TFrom source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103C954 Offset: 0x1038954 VA: 0x103C954
	|-Unsafe.As<Memory<byte>, ReadOnlyMemory<byte>>
	|
	|-RVA: 0x103C958 Offset: 0x1038958 VA: 0x103C958
	|-Unsafe.As<Memory<char>, ReadOnlyMemory<char>>
	|
	|-RVA: 0x103C95C Offset: 0x103895C VA: 0x103C95C
	|-Unsafe.As<ReadOnlyMemory<byte>, Memory<byte>>
	|
	|-RVA: 0x103C960 Offset: 0x1038960 VA: 0x103C960
	|-Unsafe.As<ReadOnlySequence<byte>, ReadOnlySequence<char>>
	|
	|-RVA: 0x103C964 Offset: 0x1038964 VA: 0x103C964
	|-Unsafe.As<ReadOnlySequence<char>, ReadOnlySequence<char>>
	|
	|-RVA: 0x103C968 Offset: 0x1038968 VA: 0x103C968
	|-Unsafe.As<ValueTuple<object, int>, byte>
	|
	|-RVA: 0x103C96C Offset: 0x103896C VA: 0x103C96C
	|-Unsafe.As<ValueTuple<object, int>, char>
	|
	|-RVA: 0x103C970 Offset: 0x1038970 VA: 0x103C970
	|-Unsafe.As<ValueTuple<object, int>, IntPtr>
	|
	|-RVA: 0x103C974 Offset: 0x1038974 VA: 0x103C974
	|-Unsafe.As<ValueTuple<object, float>, byte>
	|
	|-RVA: 0x103C978 Offset: 0x1038978 VA: 0x103C978
	|-Unsafe.As<ValueTuple<object, float>, char>
	|
	|-RVA: 0x103C97C Offset: 0x103897C VA: 0x103C97C
	|-Unsafe.As<ValueTuple<object, float>, IntPtr>
	|
	|-RVA: 0x103C980 Offset: 0x1038980 VA: 0x103C980
	|-Unsafe.As<bool, byte>
	|
	|-RVA: 0x103C984 Offset: 0x1038984 VA: 0x103C984
	|-Unsafe.As<bool, char>
	|
	|-RVA: 0x103C988 Offset: 0x1038988 VA: 0x103C988
	|-Unsafe.As<bool, IntPtr>
	|
	|-RVA: 0x103C98C Offset: 0x103898C VA: 0x103C98C
	|-Unsafe.As<bool, Volatile.VolatileBoolean>
	|
	|-RVA: 0x103C990 Offset: 0x1038990 VA: 0x103C990
	|-Unsafe.As<byte, ArraySegment<byte>>
	|
	|-RVA: 0x103C994 Offset: 0x1038994 VA: 0x103C994
	|-Unsafe.As<byte, KeyValuePair<double, object>>
	|
	|-RVA: 0x103C998 Offset: 0x1038998 VA: 0x103C998
	|-Unsafe.As<byte, KeyValuePair<int, object>>
	|
	|-RVA: 0x103C99C Offset: 0x103899C VA: 0x103C99C
	|-Unsafe.As<byte, KeyValuePair<object, double>>
	|
	|-RVA: 0x103C9A0 Offset: 0x10389A0 VA: 0x103C9A0
	|-Unsafe.As<byte, KeyValuePair<object, int>>
	|
	|-RVA: 0x103C9A4 Offset: 0x10389A4 VA: 0x103C9A4
	|-Unsafe.As<byte, KeyValuePair<object, long>>
	|
	|-RVA: 0x103C9A8 Offset: 0x10389A8 VA: 0x103C9A8
	|-Unsafe.As<byte, KeyValuePair<object, object>>
	|
	|-RVA: 0x103C9AC Offset: 0x10389AC VA: 0x103C9AC
	|-Unsafe.As<byte, ValueTuple<int, int>>
	|
	|-RVA: 0x103C9B0 Offset: 0x10389B0 VA: 0x103C9B0
	|-Unsafe.As<byte, ValueTuple<object, double>>
	|
	|-RVA: 0x103C9B4 Offset: 0x10389B4 VA: 0x103C9B4
	|-Unsafe.As<byte, ValueTuple<object, int>>
	|
	|-RVA: 0x103C9B8 Offset: 0x10389B8 VA: 0x103C9B8
	|-Unsafe.As<byte, ValueTuple<object, float>>
	|
	|-RVA: 0x103C9BC Offset: 0x10389BC VA: 0x103C9BC
	|-Unsafe.As<byte, ValueTuple<object, object, object, int>>
	|
	|-RVA: 0x103C9C0 Offset: 0x10389C0 VA: 0x103C9C0
	|-Unsafe.As<byte, bool>
	|
	|-RVA: 0x103C9C4 Offset: 0x10389C4 VA: 0x103C9C4
	|-Unsafe.As<byte, byte>
	|
	|-RVA: 0x103C9C8 Offset: 0x10389C8 VA: 0x103C9C8
	|-Unsafe.As<byte, char>
	|
	|-RVA: 0x103C9CC Offset: 0x10389CC VA: 0x103C9CC
	|-Unsafe.As<byte, Color32>
	|
	|-RVA: 0x103C9D0 Offset: 0x10389D0 VA: 0x103C9D0
	|-Unsafe.As<byte, DateTime>
	|
	|-RVA: 0x103C9D4 Offset: 0x10389D4 VA: 0x103C9D4
	|-Unsafe.As<byte, DateTimeOffset>
	|
	|-RVA: 0x103C9D8 Offset: 0x10389D8 VA: 0x103C9D8
	|-Unsafe.As<byte, Decimal>
	|
	|-RVA: 0x103C9DC Offset: 0x10389DC VA: 0x103C9DC
	|-Unsafe.As<byte, DictionaryEntry>
	|
	|-RVA: 0x103C9E0 Offset: 0x10389E0 VA: 0x103C9E0
	|-Unsafe.As<byte, double>
	|
	|-RVA: 0x103C9E4 Offset: 0x10389E4 VA: 0x103C9E4
	|-Unsafe.As<byte, FileList>
	|
	|-RVA: 0x103C9E8 Offset: 0x10389E8 VA: 0x103C9E8
	|-Unsafe.As<byte, GlyphMarshallingStruct>
	|
	|-RVA: 0x103C9EC Offset: 0x10389EC VA: 0x103C9EC
	|-Unsafe.As<byte, GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x103C9F0 Offset: 0x10389F0 VA: 0x103C9F0
	|-Unsafe.As<byte, GlyphRect>
	|
	|-RVA: 0x103C9F4 Offset: 0x10389F4 VA: 0x103C9F4
	|-Unsafe.As<byte, short>
	|
	|-RVA: 0x103C9F8 Offset: 0x10389F8 VA: 0x103C9F8
	|-Unsafe.As<byte, int>
	|
	|-RVA: 0x103C9FC Offset: 0x10389FC VA: 0x103C9FC
	|-Unsafe.As<byte, Int32Enum>
	|
	|-RVA: 0x103CA00 Offset: 0x1038A00 VA: 0x103CA00
	|-Unsafe.As<byte, long>
	|
	|-RVA: 0x103CA04 Offset: 0x1038A04 VA: 0x103CA04
	|-Unsafe.As<byte, IntPtr>
	|
	|-RVA: 0x103CA08 Offset: 0x1038A08 VA: 0x103CA08
	|-Unsafe.As<byte, InterpretedFrameInfo>
	|
	|-RVA: 0x103CA0C Offset: 0x1038A0C VA: 0x103CA0C
	|-Unsafe.As<byte, JsonPosition>
	|
	|-RVA: 0x103CA10 Offset: 0x1038A10 VA: 0x103CA10
	|-Unsafe.As<byte, Keyframe>
	|
	|-RVA: 0x103CA14 Offset: 0x1038A14 VA: 0x103CA14
	|-Unsafe.As<byte, LigatureSubstitutionRecord>
	|
	|-RVA: 0x103CA18 Offset: 0x1038A18 VA: 0x103CA18
	|-Unsafe.As<byte, LigatureSubstitutionRecord>
	|
	|-RVA: 0x103CA1C Offset: 0x1038A1C VA: 0x103CA1C
	|-Unsafe.As<byte, MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x103CA20 Offset: 0x1038A20 VA: 0x103CA20
	|-Unsafe.As<byte, MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x103CA24 Offset: 0x1038A24 VA: 0x103CA24
	|-Unsafe.As<byte, MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x103CA28 Offset: 0x1038A28 VA: 0x103CA28
	|-Unsafe.As<byte, MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x103CA2C Offset: 0x1038A2C VA: 0x103CA2C
	|-Unsafe.As<byte, MultipleSubstitutionRecord>
	|
	|-RVA: 0x103CA30 Offset: 0x1038A30 VA: 0x103CA30
	|-Unsafe.As<byte, MultipleSubstitutionRecord>
	|
	|-RVA: 0x103CA34 Offset: 0x1038A34 VA: 0x103CA34
	|-Unsafe.As<byte, object>
	|
	|-RVA: 0x103CA38 Offset: 0x1038A38 VA: 0x103CA38
	|-Unsafe.As<byte, RangePositionInfo>
	|
	|-RVA: 0x103CA3C Offset: 0x1038A3C VA: 0x103CA3C
	|-Unsafe.As<byte, RaycastHit2D>
	|
	|-RVA: 0x103CA40 Offset: 0x1038A40 VA: 0x103CA40
	|-Unsafe.As<byte, RaycastResult>
	|
	|-RVA: 0x103CA44 Offset: 0x1038A44 VA: 0x103CA44
	|-Unsafe.As<byte, sbyte>
	|
	|-RVA: 0x103CA48 Offset: 0x1038A48 VA: 0x103CA48
	|-Unsafe.As<byte, float>
	|
	|-RVA: 0x103CA4C Offset: 0x1038A4C VA: 0x103CA4C
	|-Unsafe.As<byte, TimeSpan>
	|
	|-RVA: 0x103CA50 Offset: 0x1038A50 VA: 0x103CA50
	|-Unsafe.As<byte, UICharInfo>
	|
	|-RVA: 0x103CA54 Offset: 0x1038A54 VA: 0x103CA54
	|-Unsafe.As<byte, UILineInfo>
	|
	|-RVA: 0x103CA58 Offset: 0x1038A58 VA: 0x103CA58
	|-Unsafe.As<byte, UIVertex>
	|
	|-RVA: 0x103CA5C Offset: 0x1038A5C VA: 0x103CA5C
	|-Unsafe.As<byte, ushort>
	|
	|-RVA: 0x103CA60 Offset: 0x1038A60 VA: 0x103CA60
	|-Unsafe.As<byte, uint>
	|
	|-RVA: 0x103CA64 Offset: 0x1038A64 VA: 0x103CA64
	|-Unsafe.As<byte, UInt32Enum>
	|
	|-RVA: 0x103CA68 Offset: 0x1038A68 VA: 0x103CA68
	|-Unsafe.As<byte, ulong>
	|
	|-RVA: 0x103CA6C Offset: 0x1038A6C VA: 0x103CA6C
	|-Unsafe.As<byte, Vector2>
	|
	|-RVA: 0x103CA70 Offset: 0x1038A70 VA: 0x103CA70
	|-Unsafe.As<byte, Vector3>
	|
	|-RVA: 0x103CA74 Offset: 0x1038A74 VA: 0x103CA74
	|-Unsafe.As<byte, Vector4>
	|
	|-RVA: 0x103CA78 Offset: 0x1038A78 VA: 0x103CA78
	|-Unsafe.As<byte, X509ChainStatus>
	|
	|-RVA: 0x103CA7C Offset: 0x1038A7C VA: 0x103CA7C
	|-Unsafe.As<byte, ZipGenericExtraField>
	|
	|-RVA: 0x103CA80 Offset: 0x1038A80 VA: 0x103CA80
	|-Unsafe.As<byte, jvalue>
	|
	|-RVA: 0x103CA84 Offset: 0x1038A84 VA: 0x103CA84
	|-Unsafe.As<byte, Awaitable.AwaitableAndFrameIndex>
	|
	|-RVA: 0x103CA88 Offset: 0x1038A88 VA: 0x103CA88
	|-Unsafe.As<byte, BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x103CA8C Offset: 0x1038A8C VA: 0x103CA8C
	|-Unsafe.As<byte, Element.Obstacle>
	|
	|-RVA: 0x103CA90 Offset: 0x1038A90 VA: 0x103CA90
	|-Unsafe.As<byte, Element.Texture>
	|
	|-RVA: 0x103CA94 Offset: 0x1038A94 VA: 0x103CA94
	|-Unsafe.As<byte, RegexCharClass.SingleRange>
	|
	|-RVA: 0x103CA98 Offset: 0x1038A98 VA: 0x103CA98
	|-Unsafe.As<byte, TextSettings.FontReferenceMap>
	|
	|-RVA: 0x103CA9C Offset: 0x1038A9C VA: 0x103CA9C
	|-Unsafe.As<byte, TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x103CAA0 Offset: 0x1038AA0 VA: 0x103CAA0
	|-Unsafe.As<byte, UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x103CAA4 Offset: 0x1038AA4 VA: 0x103CAA4
	|-Unsafe.As<byte, XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x103CAA8 Offset: 0x1038AA8 VA: 0x103CAA8
	|-Unsafe.As<byte, InstructionList.DebugView.InstructionView>
	|
	|-RVA: 0x103CAAC Offset: 0x1038AAC VA: 0x103CAAC
	|-Unsafe.As<byte, Position.Sequential.Node>
	|
	|-RVA: 0x103CAB0 Offset: 0x1038AB0 VA: 0x103CAB0
	|-Unsafe.As<char, byte>
	|
	|-RVA: 0x103CAB4 Offset: 0x1038AB4 VA: 0x103CAB4
	|-Unsafe.As<char, char>
	|
	|-RVA: 0x103CAB8 Offset: 0x1038AB8 VA: 0x103CAB8
	|-Unsafe.As<char, IntPtr>
	|
	|-RVA: 0x103CABC Offset: 0x1038ABC VA: 0x103CABC
	|-Unsafe.As<Color32, byte>
	|
	|-RVA: 0x103CAC0 Offset: 0x1038AC0 VA: 0x103CAC0
	|-Unsafe.As<Color32, char>
	|
	|-RVA: 0x103CAC4 Offset: 0x1038AC4 VA: 0x103CAC4
	|-Unsafe.As<Color32, IntPtr>
	|
	|-RVA: 0x103CAC8 Offset: 0x1038AC8 VA: 0x103CAC8
	|-Unsafe.As<Decimal, Decimal.DecCalc>
	|
	|-RVA: 0x103CACC Offset: 0x1038ACC VA: 0x103CACC
	|-Unsafe.As<GlyphMarshallingStruct, byte>
	|
	|-RVA: 0x103CAD0 Offset: 0x1038AD0 VA: 0x103CAD0
	|-Unsafe.As<GlyphMarshallingStruct, char>
	|
	|-RVA: 0x103CAD4 Offset: 0x1038AD4 VA: 0x103CAD4
	|-Unsafe.As<GlyphMarshallingStruct, IntPtr>
	|
	|-RVA: 0x103CAD8 Offset: 0x1038AD8 VA: 0x103CAD8
	|-Unsafe.As<GlyphPairAdjustmentRecord, byte>
	|
	|-RVA: 0x103CADC Offset: 0x1038ADC VA: 0x103CADC
	|-Unsafe.As<GlyphPairAdjustmentRecord, char>
	|
	|-RVA: 0x103CAE0 Offset: 0x1038AE0 VA: 0x103CAE0
	|-Unsafe.As<GlyphPairAdjustmentRecord, IntPtr>
	|
	|-RVA: 0x103CAE4 Offset: 0x1038AE4 VA: 0x103CAE4
	|-Unsafe.As<GlyphRect, byte>
	|
	|-RVA: 0x103CAE8 Offset: 0x1038AE8 VA: 0x103CAE8
	|-Unsafe.As<GlyphRect, char>
	|
	|-RVA: 0x103CAEC Offset: 0x1038AEC VA: 0x103CAEC
	|-Unsafe.As<GlyphRect, IntPtr>
	|
	|-RVA: 0x103CAF0 Offset: 0x1038AF0 VA: 0x103CAF0
	|-Unsafe.As<int, byte>
	|
	|-RVA: 0x103CAF4 Offset: 0x1038AF4 VA: 0x103CAF4
	|-Unsafe.As<int, char>
	|
	|-RVA: 0x103CAF8 Offset: 0x1038AF8 VA: 0x103CAF8
	|-Unsafe.As<int, IntPtr>
	|
	|-RVA: 0x103CAFC Offset: 0x1038AFC VA: 0x103CAFC
	|-Unsafe.As<int, uint>
	|
	|-RVA: 0x103CB00 Offset: 0x1038B00 VA: 0x103CB00
	|-Unsafe.As<int, Volatile.VolatileInt32>
	|
	|-RVA: 0x103CB04 Offset: 0x1038B04 VA: 0x103CB04
	|-Unsafe.As<long, ulong>
	|
	|-RVA: 0x103CB08 Offset: 0x1038B08 VA: 0x103CB08
	|-Unsafe.As<IntPtr, byte>
	|
	|-RVA: 0x103CB0C Offset: 0x1038B0C VA: 0x103CB0C
	|-Unsafe.As<IntPtr, char>
	|
	|-RVA: 0x103CB10 Offset: 0x1038B10 VA: 0x103CB10
	|-Unsafe.As<IntPtr, IntPtr>
	|
	|-RVA: 0x103CB14 Offset: 0x1038B14 VA: 0x103CB14
	|-Unsafe.As<IntPtr, object>
	|
	|-RVA: 0x103CB18 Offset: 0x1038B18 VA: 0x103CB18
	|-Unsafe.As<Keyframe, byte>
	|
	|-RVA: 0x103CB1C Offset: 0x1038B1C VA: 0x103CB1C
	|-Unsafe.As<Keyframe, char>
	|
	|-RVA: 0x103CB20 Offset: 0x1038B20 VA: 0x103CB20
	|-Unsafe.As<Keyframe, IntPtr>
	|
	|-RVA: 0x103CB24 Offset: 0x1038B24 VA: 0x103CB24
	|-Unsafe.As<MarkToBaseAdjustmentRecord, byte>
	|
	|-RVA: 0x103CB28 Offset: 0x1038B28 VA: 0x103CB28
	|-Unsafe.As<MarkToBaseAdjustmentRecord, char>
	|
	|-RVA: 0x103CB2C Offset: 0x1038B2C VA: 0x103CB2C
	|-Unsafe.As<MarkToBaseAdjustmentRecord, IntPtr>
	|
	|-RVA: 0x103CB30 Offset: 0x1038B30 VA: 0x103CB30
	|-Unsafe.As<MarkToMarkAdjustmentRecord, byte>
	|
	|-RVA: 0x103CB34 Offset: 0x1038B34 VA: 0x103CB34
	|-Unsafe.As<MarkToMarkAdjustmentRecord, char>
	|
	|-RVA: 0x103CB38 Offset: 0x1038B38 VA: 0x103CB38
	|-Unsafe.As<MarkToMarkAdjustmentRecord, IntPtr>
	|
	|-RVA: 0x103CB3C Offset: 0x1038B3C VA: 0x103CB3C
	|-Unsafe.As<object, object>
	|
	|-RVA: 0x103CB40 Offset: 0x1038B40 VA: 0x103CB40
	|-Unsafe.As<object, Volatile.VolatileObject>
	|
	|-RVA: 0x103CB44 Offset: 0x1038B44 VA: 0x103CB44
	|-Unsafe.As<RaycastHit2D, byte>
	|
	|-RVA: 0x103CB48 Offset: 0x1038B48 VA: 0x103CB48
	|-Unsafe.As<RaycastHit2D, char>
	|
	|-RVA: 0x103CB4C Offset: 0x1038B4C VA: 0x103CB4C
	|-Unsafe.As<RaycastHit2D, IntPtr>
	|
	|-RVA: 0x103CB50 Offset: 0x1038B50 VA: 0x103CB50
	|-Unsafe.As<ushort, byte>
	|
	|-RVA: 0x103CB54 Offset: 0x1038B54 VA: 0x103CB54
	|-Unsafe.As<ushort, char>
	|
	|-RVA: 0x103CB58 Offset: 0x1038B58 VA: 0x103CB58
	|-Unsafe.As<ushort, IntPtr>
	|
	|-RVA: 0x103CB5C Offset: 0x1038B5C VA: 0x103CB5C
	|-Unsafe.As<uint, byte>
	|
	|-RVA: 0x103CB60 Offset: 0x1038B60 VA: 0x103CB60
	|-Unsafe.As<uint, char>
	|
	|-RVA: 0x103CB64 Offset: 0x1038B64 VA: 0x103CB64
	|-Unsafe.As<uint, IntPtr>
	|
	|-RVA: 0x103CB68 Offset: 0x1038B68 VA: 0x103CB68
	|-Unsafe.As<Vector3, byte>
	|
	|-RVA: 0x103CB6C Offset: 0x1038B6C VA: 0x103CB6C
	|-Unsafe.As<Vector3, char>
	|
	|-RVA: 0x103CB70 Offset: 0x1038B70 VA: 0x103CB70
	|-Unsafe.As<Vector3, IntPtr>
	|
	|-RVA: 0x103CB74 Offset: 0x1038B74 VA: 0x103CB74
	|-Unsafe.As<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	|
	|-RVA: 0x103CB78 Offset: 0x1038B78 VA: 0x103CB78
	|-Unsafe.As<jvalue, byte>
	|
	|-RVA: 0x103CB7C Offset: 0x1038B7C VA: 0x103CB7C
	|-Unsafe.As<jvalue, char>
	|
	|-RVA: 0x103CB80 Offset: 0x1038B80 VA: 0x103CB80
	|-Unsafe.As<jvalue, IntPtr>
	*/

	// RVA: -1 Offset: -1
	public static void* AsPointer<T>(ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103CB84 Offset: 0x1038B84 VA: 0x103CB84
	|-Unsafe.AsPointer<byte>
	|
	|-RVA: 0x103CB88 Offset: 0x1038B88 VA: 0x103CB88
	|-Unsafe.AsPointer<char>
	|
	|-RVA: 0x103CB8C Offset: 0x1038B8C VA: 0x103CB8C
	|-Unsafe.AsPointer<object>
	|
	|-RVA: 0x103CB90 Offset: 0x1038B90 VA: 0x103CB90
	|-Unsafe.AsPointer<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x103CB94 Offset: 0x1038B94 VA: 0x103CB94
	|-Unsafe.AsPointer<Number.NumberBuffer.DigitsAndNullTerminator>
	*/

	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103CB98 Offset: 0x1038B98 VA: 0x103CB98
	|-Unsafe.AsRef<ValueTuple<object, int>>
	|
	|-RVA: 0x103CB9C Offset: 0x1038B9C VA: 0x103CB9C
	|-Unsafe.AsRef<ValueTuple<object, float>>
	|
	|-RVA: 0x103CBA0 Offset: 0x1038BA0 VA: 0x103CBA0
	|-Unsafe.AsRef<bool>
	|
	|-RVA: 0x103CBA8 Offset: 0x1038BA8 VA: 0x103CBA8
	|-Unsafe.AsRef<byte>
	|
	|-RVA: 0x103CBAC Offset: 0x1038BAC VA: 0x103CBAC
	|-Unsafe.AsRef<char>
	|
	|-RVA: 0x103CBB0 Offset: 0x1038BB0 VA: 0x103CBB0
	|-Unsafe.AsRef<Color32>
	|
	|-RVA: 0x103CBB4 Offset: 0x1038BB4 VA: 0x103CBB4
	|-Unsafe.AsRef<GlyphMarshallingStruct>
	|
	|-RVA: 0x103CBB8 Offset: 0x1038BB8 VA: 0x103CBB8
	|-Unsafe.AsRef<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x103CBBC Offset: 0x1038BBC VA: 0x103CBBC
	|-Unsafe.AsRef<GlyphRect>
	|
	|-RVA: 0x103CBC0 Offset: 0x1038BC0 VA: 0x103CBC0
	|-Unsafe.AsRef<int>
	|
	|-RVA: 0x103CBC4 Offset: 0x1038BC4 VA: 0x103CBC4
	|-Unsafe.AsRef<IntPtr>
	|
	|-RVA: 0x103CBC8 Offset: 0x1038BC8 VA: 0x103CBC8
	|-Unsafe.AsRef<Keyframe>
	|
	|-RVA: 0x103CBCC Offset: 0x1038BCC VA: 0x103CBCC
	|-Unsafe.AsRef<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x103CBD0 Offset: 0x1038BD0 VA: 0x103CBD0
	|-Unsafe.AsRef<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x103CBD4 Offset: 0x1038BD4 VA: 0x103CBD4
	|-Unsafe.AsRef<RaycastHit2D>
	|
	|-RVA: 0x103CBD8 Offset: 0x1038BD8 VA: 0x103CBD8
	|-Unsafe.AsRef<ushort>
	|
	|-RVA: 0x103CBDC Offset: 0x1038BDC VA: 0x103CBDC
	|-Unsafe.AsRef<uint>
	|
	|-RVA: 0x103CBE0 Offset: 0x1038BE0 VA: 0x103CBE0
	|-Unsafe.AsRef<Vector3>
	|
	|-RVA: 0x103CBE8 Offset: 0x1038BE8 VA: 0x103CBE8
	|-Unsafe.AsRef<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x103CBEC Offset: 0x1038BEC VA: 0x103CBEC
	|-Unsafe.AsRef<jvalue>
	*/

	// RVA: -1 Offset: -1
	public static ref T AsRef<T>(in T source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103CBA4 Offset: 0x1038BA4 VA: 0x103CBA4
	|-Unsafe.AsRef<byte>
	|
	|-RVA: 0x103CBE4 Offset: 0x1038BE4 VA: 0x103CBE4
	|-Unsafe.AsRef<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17D4A4C Offset: 0x17D0A4C VA: 0x17D4A4C
	public static void InitBlockUnaligned(ref byte startAddress, byte value, uint byteCount) { }

	// RVA: -1 Offset: -1
	public static T Read<T>(void* source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103CF20 Offset: 0x1038F20 VA: 0x103CF20
	|-Unsafe.Read<Vector<ushort>>
	|
	|-RVA: 0x103CF2C Offset: 0x1038F2C VA: 0x103CF2C
	|-Unsafe.Read<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T ReadUnaligned<T>(ref byte source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103CF70 Offset: 0x1038F70 VA: 0x103CF70
	|-Unsafe.ReadUnaligned<Vector<ushort>>
	|
	|-RVA: 0x103CF7C Offset: 0x1038F7C VA: 0x103CF7C
	|-Unsafe.ReadUnaligned<short>
	|
	|-RVA: 0x103CF84 Offset: 0x1038F84 VA: 0x103CF84
	|-Unsafe.ReadUnaligned<int>
	|
	|-RVA: 0x103CF8C Offset: 0x1038F8C VA: 0x103CF8C
	|-Unsafe.ReadUnaligned<ushort>
	|
	|-RVA: 0x103CF94 Offset: 0x1038F94 VA: 0x103CF94
	|-Unsafe.ReadUnaligned<uint>
	|
	|-RVA: 0x103CF9C Offset: 0x1038F9C VA: 0x103CF9C
	|-Unsafe.ReadUnaligned<ulong>
	|
	|-RVA: 0x103CFA4 Offset: 0x1038FA4 VA: 0x103CFA4
	|-Unsafe.ReadUnaligned<UIntPtr>
	|
	|-RVA: 0x103CFAC Offset: 0x1038FAC VA: 0x103CFAC
	|-Unsafe.ReadUnaligned<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int SizeOf<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103CFF0 Offset: 0x1038FF0 VA: 0x103CFF0
	|-Unsafe.SizeOf<ValueTuple<object, int>>
	|
	|-RVA: 0x103CFF8 Offset: 0x1038FF8 VA: 0x103CFF8
	|-Unsafe.SizeOf<ValueTuple<object, float>>
	|
	|-RVA: 0x103D000 Offset: 0x1039000 VA: 0x103D000
	|-Unsafe.SizeOf<Vector<ushort>>
	|
	|-RVA: 0x103D008 Offset: 0x1039008 VA: 0x103D008
	|-Unsafe.SizeOf<bool>
	|
	|-RVA: 0x103D010 Offset: 0x1039010 VA: 0x103D010
	|-Unsafe.SizeOf<byte>
	|
	|-RVA: 0x103D018 Offset: 0x1039018 VA: 0x103D018
	|-Unsafe.SizeOf<char>
	|
	|-RVA: 0x103D020 Offset: 0x1039020 VA: 0x103D020
	|-Unsafe.SizeOf<Color32>
	|
	|-RVA: 0x103D028 Offset: 0x1039028 VA: 0x103D028
	|-Unsafe.SizeOf<GlyphMarshallingStruct>
	|
	|-RVA: 0x103D030 Offset: 0x1039030 VA: 0x103D030
	|-Unsafe.SizeOf<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x103D038 Offset: 0x1039038 VA: 0x103D038
	|-Unsafe.SizeOf<GlyphRect>
	|
	|-RVA: 0x103D040 Offset: 0x1039040 VA: 0x103D040
	|-Unsafe.SizeOf<int>
	|
	|-RVA: 0x103D048 Offset: 0x1039048 VA: 0x103D048
	|-Unsafe.SizeOf<IntPtr>
	|
	|-RVA: 0x103D050 Offset: 0x1039050 VA: 0x103D050
	|-Unsafe.SizeOf<Keyframe>
	|
	|-RVA: 0x103D058 Offset: 0x1039058 VA: 0x103D058
	|-Unsafe.SizeOf<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x103D060 Offset: 0x1039060 VA: 0x103D060
	|-Unsafe.SizeOf<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x103D068 Offset: 0x1039068 VA: 0x103D068
	|-Unsafe.SizeOf<RaycastHit2D>
	|
	|-RVA: 0x103D070 Offset: 0x1039070 VA: 0x103D070
	|-Unsafe.SizeOf<ushort>
	|
	|-RVA: 0x103D078 Offset: 0x1039078 VA: 0x103D078
	|-Unsafe.SizeOf<uint>
	|
	|-RVA: 0x103D080 Offset: 0x1039080 VA: 0x103D080
	|-Unsafe.SizeOf<ulong>
	|
	|-RVA: 0x103D088 Offset: 0x1039088 VA: 0x103D088
	|-Unsafe.SizeOf<Vector3>
	|
	|-RVA: 0x103D090 Offset: 0x1039090 VA: 0x103D090
	|-Unsafe.SizeOf<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x103D0B8 Offset: 0x10390B8 VA: 0x103D0B8
	|-Unsafe.SizeOf<jvalue>
	*/

	// RVA: -1 Offset: -1
	public static void WriteUnaligned<T>(ref byte destination, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103D0C0 Offset: 0x10390C0 VA: 0x103D0C0
	|-Unsafe.WriteUnaligned<uint>
	|
	|-RVA: 0x103D0C8 Offset: 0x10390C8 VA: 0x103D0C8
	|-Unsafe.WriteUnaligned<ulong>
	|
	|-RVA: 0x103D0D0 Offset: 0x10390D0 VA: 0x103D0D0
	|-Unsafe.WriteUnaligned<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool IsAddressLessThan<T>(ref T left, ref T right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103CBF0 Offset: 0x1038BF0 VA: 0x103CBF0
	|-Unsafe.IsAddressLessThan<ArraySegment<byte>>
	|
	|-RVA: 0x103CBFC Offset: 0x1038BFC VA: 0x103CBFC
	|-Unsafe.IsAddressLessThan<KeyValuePair<double, object>>
	|
	|-RVA: 0x103CC08 Offset: 0x1038C08 VA: 0x103CC08
	|-Unsafe.IsAddressLessThan<KeyValuePair<int, object>>
	|
	|-RVA: 0x103CC14 Offset: 0x1038C14 VA: 0x103CC14
	|-Unsafe.IsAddressLessThan<KeyValuePair<object, double>>
	|
	|-RVA: 0x103CC20 Offset: 0x1038C20 VA: 0x103CC20
	|-Unsafe.IsAddressLessThan<KeyValuePair<object, int>>
	|
	|-RVA: 0x103CC2C Offset: 0x1038C2C VA: 0x103CC2C
	|-Unsafe.IsAddressLessThan<KeyValuePair<object, long>>
	|
	|-RVA: 0x103CC38 Offset: 0x1038C38 VA: 0x103CC38
	|-Unsafe.IsAddressLessThan<KeyValuePair<object, object>>
	|
	|-RVA: 0x103CC44 Offset: 0x1038C44 VA: 0x103CC44
	|-Unsafe.IsAddressLessThan<ValueTuple<int, int>>
	|
	|-RVA: 0x103CC50 Offset: 0x1038C50 VA: 0x103CC50
	|-Unsafe.IsAddressLessThan<ValueTuple<object, double>>
	|
	|-RVA: 0x103CC5C Offset: 0x1038C5C VA: 0x103CC5C
	|-Unsafe.IsAddressLessThan<ValueTuple<object, object, object, int>>
	|
	|-RVA: 0x103CC68 Offset: 0x1038C68 VA: 0x103CC68
	|-Unsafe.IsAddressLessThan<bool>
	|
	|-RVA: 0x103CC74 Offset: 0x1038C74 VA: 0x103CC74
	|-Unsafe.IsAddressLessThan<byte>
	|
	|-RVA: 0x103CC80 Offset: 0x1038C80 VA: 0x103CC80
	|-Unsafe.IsAddressLessThan<char>
	|
	|-RVA: 0x103CC8C Offset: 0x1038C8C VA: 0x103CC8C
	|-Unsafe.IsAddressLessThan<Color32>
	|
	|-RVA: 0x103CC98 Offset: 0x1038C98 VA: 0x103CC98
	|-Unsafe.IsAddressLessThan<DateTime>
	|
	|-RVA: 0x103CCA4 Offset: 0x1038CA4 VA: 0x103CCA4
	|-Unsafe.IsAddressLessThan<DateTimeOffset>
	|
	|-RVA: 0x103CCB0 Offset: 0x1038CB0 VA: 0x103CCB0
	|-Unsafe.IsAddressLessThan<Decimal>
	|
	|-RVA: 0x103CCBC Offset: 0x1038CBC VA: 0x103CCBC
	|-Unsafe.IsAddressLessThan<DictionaryEntry>
	|
	|-RVA: 0x103CCC8 Offset: 0x1038CC8 VA: 0x103CCC8
	|-Unsafe.IsAddressLessThan<double>
	|
	|-RVA: 0x103CCD4 Offset: 0x1038CD4 VA: 0x103CCD4
	|-Unsafe.IsAddressLessThan<FileList>
	|
	|-RVA: 0x103CCE0 Offset: 0x1038CE0 VA: 0x103CCE0
	|-Unsafe.IsAddressLessThan<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x103CCEC Offset: 0x1038CEC VA: 0x103CCEC
	|-Unsafe.IsAddressLessThan<GlyphRect>
	|
	|-RVA: 0x103CCF8 Offset: 0x1038CF8 VA: 0x103CCF8
	|-Unsafe.IsAddressLessThan<short>
	|
	|-RVA: 0x103CD04 Offset: 0x1038D04 VA: 0x103CD04
	|-Unsafe.IsAddressLessThan<int>
	|
	|-RVA: 0x103CD10 Offset: 0x1038D10 VA: 0x103CD10
	|-Unsafe.IsAddressLessThan<Int32Enum>
	|
	|-RVA: 0x103CD1C Offset: 0x1038D1C VA: 0x103CD1C
	|-Unsafe.IsAddressLessThan<long>
	|
	|-RVA: 0x103CD28 Offset: 0x1038D28 VA: 0x103CD28
	|-Unsafe.IsAddressLessThan<IntPtr>
	|
	|-RVA: 0x103CD34 Offset: 0x1038D34 VA: 0x103CD34
	|-Unsafe.IsAddressLessThan<InterpretedFrameInfo>
	|
	|-RVA: 0x103CD40 Offset: 0x1038D40 VA: 0x103CD40
	|-Unsafe.IsAddressLessThan<JsonPosition>
	|
	|-RVA: 0x103CD4C Offset: 0x1038D4C VA: 0x103CD4C
	|-Unsafe.IsAddressLessThan<LigatureSubstitutionRecord>
	|
	|-RVA: 0x103CD58 Offset: 0x1038D58 VA: 0x103CD58
	|-Unsafe.IsAddressLessThan<LigatureSubstitutionRecord>
	|
	|-RVA: 0x103CD64 Offset: 0x1038D64 VA: 0x103CD64
	|-Unsafe.IsAddressLessThan<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x103CD70 Offset: 0x1038D70 VA: 0x103CD70
	|-Unsafe.IsAddressLessThan<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x103CD7C Offset: 0x1038D7C VA: 0x103CD7C
	|-Unsafe.IsAddressLessThan<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x103CD88 Offset: 0x1038D88 VA: 0x103CD88
	|-Unsafe.IsAddressLessThan<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x103CD94 Offset: 0x1038D94 VA: 0x103CD94
	|-Unsafe.IsAddressLessThan<MultipleSubstitutionRecord>
	|
	|-RVA: 0x103CDA0 Offset: 0x1038DA0 VA: 0x103CDA0
	|-Unsafe.IsAddressLessThan<MultipleSubstitutionRecord>
	|
	|-RVA: 0x103CDAC Offset: 0x1038DAC VA: 0x103CDAC
	|-Unsafe.IsAddressLessThan<object>
	|
	|-RVA: 0x103CDB8 Offset: 0x1038DB8 VA: 0x103CDB8
	|-Unsafe.IsAddressLessThan<RangePositionInfo>
	|
	|-RVA: 0x103CDC4 Offset: 0x1038DC4 VA: 0x103CDC4
	|-Unsafe.IsAddressLessThan<RaycastHit2D>
	|
	|-RVA: 0x103CDD0 Offset: 0x1038DD0 VA: 0x103CDD0
	|-Unsafe.IsAddressLessThan<RaycastResult>
	|
	|-RVA: 0x103CDDC Offset: 0x1038DDC VA: 0x103CDDC
	|-Unsafe.IsAddressLessThan<sbyte>
	|
	|-RVA: 0x103CDE8 Offset: 0x1038DE8 VA: 0x103CDE8
	|-Unsafe.IsAddressLessThan<float>
	|
	|-RVA: 0x103CDF4 Offset: 0x1038DF4 VA: 0x103CDF4
	|-Unsafe.IsAddressLessThan<TimeSpan>
	|
	|-RVA: 0x103CE00 Offset: 0x1038E00 VA: 0x103CE00
	|-Unsafe.IsAddressLessThan<UICharInfo>
	|
	|-RVA: 0x103CE0C Offset: 0x1038E0C VA: 0x103CE0C
	|-Unsafe.IsAddressLessThan<UILineInfo>
	|
	|-RVA: 0x103CE18 Offset: 0x1038E18 VA: 0x103CE18
	|-Unsafe.IsAddressLessThan<UIVertex>
	|
	|-RVA: 0x103CE24 Offset: 0x1038E24 VA: 0x103CE24
	|-Unsafe.IsAddressLessThan<ushort>
	|
	|-RVA: 0x103CE30 Offset: 0x1038E30 VA: 0x103CE30
	|-Unsafe.IsAddressLessThan<uint>
	|
	|-RVA: 0x103CE3C Offset: 0x1038E3C VA: 0x103CE3C
	|-Unsafe.IsAddressLessThan<UInt32Enum>
	|
	|-RVA: 0x103CE48 Offset: 0x1038E48 VA: 0x103CE48
	|-Unsafe.IsAddressLessThan<ulong>
	|
	|-RVA: 0x103CE54 Offset: 0x1038E54 VA: 0x103CE54
	|-Unsafe.IsAddressLessThan<Vector2>
	|
	|-RVA: 0x103CE60 Offset: 0x1038E60 VA: 0x103CE60
	|-Unsafe.IsAddressLessThan<Vector3>
	|
	|-RVA: 0x103CE6C Offset: 0x1038E6C VA: 0x103CE6C
	|-Unsafe.IsAddressLessThan<Vector4>
	|
	|-RVA: 0x103CE78 Offset: 0x1038E78 VA: 0x103CE78
	|-Unsafe.IsAddressLessThan<X509ChainStatus>
	|
	|-RVA: 0x103CE84 Offset: 0x1038E84 VA: 0x103CE84
	|-Unsafe.IsAddressLessThan<ZipGenericExtraField>
	|
	|-RVA: 0x103CE90 Offset: 0x1038E90 VA: 0x103CE90
	|-Unsafe.IsAddressLessThan<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x103CE9C Offset: 0x1038E9C VA: 0x103CE9C
	|-Unsafe.IsAddressLessThan<Awaitable.AwaitableAndFrameIndex>
	|
	|-RVA: 0x103CEA8 Offset: 0x1038EA8 VA: 0x103CEA8
	|-Unsafe.IsAddressLessThan<BeforeRenderHelper.OrderBlock>
	|
	|-RVA: 0x103CEB4 Offset: 0x1038EB4 VA: 0x103CEB4
	|-Unsafe.IsAddressLessThan<Element.Obstacle>
	|
	|-RVA: 0x103CEC0 Offset: 0x1038EC0 VA: 0x103CEC0
	|-Unsafe.IsAddressLessThan<Element.Texture>
	|
	|-RVA: 0x103CECC Offset: 0x1038ECC VA: 0x103CECC
	|-Unsafe.IsAddressLessThan<RegexCharClass.SingleRange>
	|
	|-RVA: 0x103CED8 Offset: 0x1038ED8 VA: 0x103CED8
	|-Unsafe.IsAddressLessThan<TextSettings.FontReferenceMap>
	|
	|-RVA: 0x103CEE4 Offset: 0x1038EE4 VA: 0x103CEE4
	|-Unsafe.IsAddressLessThan<TexturePacker_JsonArray.Frame>
	|
	|-RVA: 0x103CEF0 Offset: 0x1038EF0 VA: 0x103CEF0
	|-Unsafe.IsAddressLessThan<UnitySynchronizationContext.WorkRequest>
	|
	|-RVA: 0x103CEFC Offset: 0x1038EFC VA: 0x103CEFC
	|-Unsafe.IsAddressLessThan<XmlSchemaObjectTable.XmlSchemaObjectEntry>
	|
	|-RVA: 0x103CF08 Offset: 0x1038F08 VA: 0x103CF08
	|-Unsafe.IsAddressLessThan<InstructionList.DebugView.InstructionView>
	|
	|-RVA: 0x103CF14 Offset: 0x1038F14 VA: 0x103CF14
	|-Unsafe.IsAddressLessThan<Position.Sequential.Node>
	*/

	// RVA: -1 Offset: -1
	internal static ref T AddByteOffset<T>(ref T source, ulong byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103C518 Offset: 0x1038518 VA: 0x103C518
	|-Unsafe.AddByteOffset<ValueTuple<object, int>>
	|
	|-RVA: 0x103C540 Offset: 0x1038540 VA: 0x103C540
	|-Unsafe.AddByteOffset<ValueTuple<object, float>>
	|
	|-RVA: 0x103C568 Offset: 0x1038568 VA: 0x103C568
	|-Unsafe.AddByteOffset<bool>
	|
	|-RVA: 0x103C590 Offset: 0x1038590 VA: 0x103C590
	|-Unsafe.AddByteOffset<byte>
	|
	|-RVA: 0x103C5B8 Offset: 0x10385B8 VA: 0x103C5B8
	|-Unsafe.AddByteOffset<char>
	|
	|-RVA: 0x103C5E0 Offset: 0x10385E0 VA: 0x103C5E0
	|-Unsafe.AddByteOffset<Color32>
	|
	|-RVA: 0x103C608 Offset: 0x1038608 VA: 0x103C608
	|-Unsafe.AddByteOffset<GlyphMarshallingStruct>
	|
	|-RVA: 0x103C630 Offset: 0x1038630 VA: 0x103C630
	|-Unsafe.AddByteOffset<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x103C658 Offset: 0x1038658 VA: 0x103C658
	|-Unsafe.AddByteOffset<GlyphRect>
	|
	|-RVA: 0x103C680 Offset: 0x1038680 VA: 0x103C680
	|-Unsafe.AddByteOffset<int>
	|
	|-RVA: 0x103C6A8 Offset: 0x10386A8 VA: 0x103C6A8
	|-Unsafe.AddByteOffset<IntPtr>
	|
	|-RVA: 0x103C6D0 Offset: 0x10386D0 VA: 0x103C6D0
	|-Unsafe.AddByteOffset<Keyframe>
	|
	|-RVA: 0x103C6F8 Offset: 0x10386F8 VA: 0x103C6F8
	|-Unsafe.AddByteOffset<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x103C720 Offset: 0x1038720 VA: 0x103C720
	|-Unsafe.AddByteOffset<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x103C748 Offset: 0x1038748 VA: 0x103C748
	|-Unsafe.AddByteOffset<RaycastHit2D>
	|
	|-RVA: 0x103C770 Offset: 0x1038770 VA: 0x103C770
	|-Unsafe.AddByteOffset<ushort>
	|
	|-RVA: 0x103C798 Offset: 0x1038798 VA: 0x103C798
	|-Unsafe.AddByteOffset<uint>
	|
	|-RVA: 0x103C7C0 Offset: 0x10387C0 VA: 0x103C7C0
	|-Unsafe.AddByteOffset<Vector3>
	|
	|-RVA: 0x103C7E8 Offset: 0x10387E8 VA: 0x103C7E8
	|-Unsafe.AddByteOffset<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x103C840 Offset: 0x1038840 VA: 0x103C840
	|-Unsafe.AddByteOffset<jvalue>
	*/
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 1693
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0xE36204 Offset: 0xE32204 VA: 0xE36204
	public void .ctor(byte ) { }

	// RVA: 0xE3628C Offset: 0xE3228C VA: 0xE3628C
	public void .ctor(byte[] ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(5196, AllowMultiple = False, Inherited = False)]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 1694
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0xE362BC Offset: 0xE322BC VA: 0xE362BC
	public void .ctor(byte ) { }
}

// Namespace: 
public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler // TypeDefIndex: 1695
{
	// Fields
	[SerializeField]
	private float handleRange; // 0x20
	[SerializeField]
	private float deadZone; // 0x24
	[SerializeField]
	private AxisOptions axisOptions; // 0x28
	[SerializeField]
	private bool snapX; // 0x2C
	[SerializeField]
	private bool snapY; // 0x2D
	[SerializeField]
	public RectTransform background; // 0x30
	[SerializeField]
	public RectTransform handle; // 0x38
	private RectTransform baseRect; // 0x40
	private Canvas canvas; // 0x48
	private Camera cam; // 0x50
	private Vector2 input; // 0x58

	// Properties
	public float Horizontal { get; }
	public float Vertical { get; }
	public Vector2 Direction { get; }
	public float HandleRange { get; set; }
	public float DeadZone { get; set; }
	public AxisOptions AxisOptions { get; set; }
	public bool SnapX { get; set; }
	public bool SnapY { get; set; }

	// Methods

	// RVA: 0xE362E4 Offset: 0xE322E4 VA: 0xE362E4
	public float get_Horizontal() { }

	// RVA: 0xE364CC Offset: 0xE324CC VA: 0xE364CC
	public float get_Vertical() { }

	// RVA: 0xE364E4 Offset: 0xE324E4 VA: 0xE364E4
	public Vector2 get_Direction() { }

	// RVA: 0xE36540 Offset: 0xE32540 VA: 0xE36540
	public float get_HandleRange() { }

	// RVA: 0xE36548 Offset: 0xE32548 VA: 0xE36548
	public void set_HandleRange(float value) { }

	// RVA: 0xE36554 Offset: 0xE32554 VA: 0xE36554
	public float get_DeadZone() { }

	// RVA: 0xE3655C Offset: 0xE3255C VA: 0xE3655C
	public void set_DeadZone(float value) { }

	// RVA: 0xE36568 Offset: 0xE32568 VA: 0xE36568
	public RectTransform getHandle() { }

	// RVA: 0xE36570 Offset: 0xE32570 VA: 0xE36570
	public AxisOptions get_AxisOptions() { }

	// RVA: 0xE36574 Offset: 0xE32574 VA: 0xE36574
	public void set_AxisOptions(AxisOptions value) { }

	// RVA: 0xE3657C Offset: 0xE3257C VA: 0xE3657C
	public bool get_SnapX() { }

	// RVA: 0xE36584 Offset: 0xE32584 VA: 0xE36584
	public void set_SnapX(bool value) { }

	// RVA: 0xE3658C Offset: 0xE3258C VA: 0xE3658C
	public bool get_SnapY() { }

	// RVA: 0xE36594 Offset: 0xE32594 VA: 0xE36594
	public void set_SnapY(bool value) { }

	// RVA: 0xE3659C Offset: 0xE3259C VA: 0xE3659C Slot: 7
	protected virtual void Start() { }

	// RVA: 0xE36768 Offset: 0xE32768 VA: 0xE36768 Slot: 8
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xE3676C Offset: 0xE3276C VA: 0xE3676C Slot: 5
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xE36A44 Offset: 0xE32A44 VA: 0xE36A44 Slot: 9
	protected virtual void HandleInput(float magnitude, Vector2 normalised, Vector2 radius, Camera cam) { }

	// RVA: 0xE36A20 Offset: 0xE32A20 VA: 0xE36A20
	private void FormatInput() { }

	// RVA: 0xE362FC Offset: 0xE322FC VA: 0xE362FC
	private float SnapFloat(float value, AxisOptions snapAxis) { }

	// RVA: 0xE36AB0 Offset: 0xE32AB0 VA: 0xE36AB0 Slot: 10
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xE36B18 Offset: 0xE32B18 VA: 0xE36B18
	protected Vector2 ScreenPointToAnchoredPosition(Vector2 screenPosition) { }

	// RVA: 0xE36CB0 Offset: 0xE32CB0 VA: 0xE36CB0
	public void .ctor() { }
}

// Namespace: 
public enum AxisOptions // TypeDefIndex: 1696
{
	// Fields
	public int value__; // 0x0
	public const AxisOptions Both = 0;
	public const AxisOptions Horizontal = 1;
	public const AxisOptions Vertical = 2;
}

// Namespace: 
public class DynamicJoystick : Joystick // TypeDefIndex: 1697
{
	// Fields
	[SerializeField]
	private float moveThreshold; // 0x60

	// Properties
	public float MoveThreshold { get; set; }

	// Methods

	// RVA: 0xE36D10 Offset: 0xE32D10 VA: 0xE36D10
	public float get_MoveThreshold() { }

	// RVA: 0xE36D18 Offset: 0xE32D18 VA: 0xE36D18
	public void set_MoveThreshold(float value) { }

	// RVA: 0xE36D24 Offset: 0xE32D24 VA: 0xE36D24 Slot: 7
	protected override void Start() { }

	// RVA: 0xE36D64 Offset: 0xE32D64 VA: 0xE36D64 Slot: 8
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xE36DD0 Offset: 0xE32DD0 VA: 0xE36DD0 Slot: 10
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xE36E08 Offset: 0xE32E08 VA: 0xE36E08 Slot: 9
	protected override void HandleInput(float magnitude, Vector2 normalised, Vector2 radius, Camera cam) { }

	// RVA: 0xE36EA0 Offset: 0xE32EA0 VA: 0xE36EA0
	public void .ctor() { }
}

// Namespace: 
public class FixedJoystick : Joystick // TypeDefIndex: 1698
{
	// Methods

	// RVA: 0xE36EAC Offset: 0xE32EAC VA: 0xE36EAC
	public void .ctor() { }
}

// Namespace: 
public class FloatingJoystick : Joystick // TypeDefIndex: 1699
{
	// Methods

	// RVA: 0xE36EB0 Offset: 0xE32EB0 VA: 0xE36EB0 Slot: 7
	protected override void Start() { }

	// RVA: 0xE36EE4 Offset: 0xE32EE4 VA: 0xE36EE4 Slot: 8
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xE36F50 Offset: 0xE32F50 VA: 0xE36F50 Slot: 10
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xE36F88 Offset: 0xE32F88 VA: 0xE36F88
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class VariableJoystick.<>c // TypeDefIndex: 1700
{
	// Fields
	public static readonly VariableJoystick.<>c <>9; // 0x0
	public static Func<RaycastResult, GameObject> <>9__17_1; // 0x8

	// Methods

	// RVA: 0xE37B40 Offset: 0xE33B40 VA: 0xE37B40
	private static void .cctor() { }

	// RVA: 0xE37BA8 Offset: 0xE33BA8 VA: 0xE37BA8
	public void .ctor() { }

	// RVA: 0xE37BB0 Offset: 0xE33BB0 VA: 0xE37BB0
	internal GameObject <OnPointerDown>b__17_1(RaycastResult result) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class VariableJoystick.<>c__DisplayClass21_0 // TypeDefIndex: 1701
{
	// Fields
	public string name; // 0x10
	public VariableJoystick <>4__this; // 0x18

	// Methods

	// RVA: 0xE37908 Offset: 0xE33908 VA: 0xE37908
	public void .ctor() { }

	// RVA: 0xE37BB8 Offset: 0xE33BB8 VA: 0xE37BB8
	internal void <SetMovingMode>b__0() { }
}

// Namespace: 
public class VariableJoystick : Joystick // TypeDefIndex: 1702
{
	// Fields
	[SerializeField]
	private float moveThreshold; // 0x60
	[SerializeField]
	private JoystickType joystickType; // 0x64
	private Vector2 fixedPosition; // 0x68
	private Vector2 pcModePosition; // 0x70
	private Vector2 mobileModePosition; // 0x78
	private Image compBackgroundImage; // 0x80
	private Image compHandleImage; // 0x88
	private bool hasStarted; // 0x90
	private bool isPcMovingStyle; // 0x91
	private readonly Queue<Action> onStarted; // 0x98
	private readonly Dictionary<int, bool> pointerMoving; // 0xA0
	private readonly Queue<Action> onPointerUpAction; // 0xA8

	// Properties
	public float MoveThreshold { get; set; }

	// Methods

	// RVA: 0xE36F8C Offset: 0xE32F8C VA: 0xE36F8C
	public float get_MoveThreshold() { }

	// RVA: 0xE36F94 Offset: 0xE32F94 VA: 0xE36F94
	public void set_MoveThreshold(float value) { }

	// RVA: 0xE36FA0 Offset: 0xE32FA0 VA: 0xE36FA0
	public void SetMode(JoystickType joystickType) { }

	// RVA: 0xE36FE8 Offset: 0xE32FE8 VA: 0xE36FE8 Slot: 7
	protected override void Start() { }

	// RVA: 0xE37128 Offset: 0xE33128 VA: 0xE37128 Slot: 8
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xE375CC Offset: 0xE335CC VA: 0xE375CC Slot: 10
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xE376DC Offset: 0xE336DC VA: 0xE376DC Slot: 9
	protected override void HandleInput(float magnitude, Vector2 normalised, Vector2 radius, Camera cam) { }

	// RVA: 0xE374E4 Offset: 0xE334E4 VA: 0xE374E4
	public void OnPointerDownNoRaycast(PointerEventData eventData) { }

	// RVA: 0xE377F0 Offset: 0xE337F0 VA: 0xE377F0
	public void SetMovingMode(string name) { }

	// RVA: 0xE37910 Offset: 0xE33910 VA: 0xE37910
	public void AddPointerUpAction(Action action) { }

	// RVA: 0xE37968 Offset: 0xE33968 VA: 0xE37968
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE37AC0 Offset: 0xE33AC0 VA: 0xE37AC0
	private bool <OnPointerDown>b__17_0(RaycastResult result) { }
}

// Namespace: 
public enum JoystickType // TypeDefIndex: 1703
{
	// Fields
	public int value__; // 0x0
	public const JoystickType Fixed = 0;
	public const JoystickType Floating = 1;
	public const JoystickType Dynamic = 2;
}

// Namespace: 
[CompilerGenerated]
private sealed class Download.<>c__DisplayClass29_0 // TypeDefIndex: 1704
{
	// Fields
	public Action button1Action; // 0x10
	public Action button2Action; // 0x18

	// Methods

	// RVA: 0xE38A9C Offset: 0xE34A9C VA: 0xE38A9C
	public void .ctor() { }

	// RVA: 0xE39EEC Offset: 0xE35EEC VA: 0xE39EEC
	internal void <OpenNotify>b__0() { }

	// RVA: 0xE39F08 Offset: 0xE35F08 VA: 0xE39F08
	internal void <OpenNotify>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Download.<>c__DisplayClass31_0 // TypeDefIndex: 1705
{
	// Fields
	public Download <>4__this; // 0x10
	public string rootPath; // 0x18
	public Action onFinish; // 0x20
	public Action <>9__1; // 0x28
	public Action <>9__2; // 0x30
	public Action <>9__3; // 0x38

	// Methods

	// RVA: 0xE38E04 Offset: 0xE34E04 VA: 0xE38E04
	public void .ctor() { }

	// RVA: 0xE39F24 Offset: 0xE35F24 VA: 0xE39F24
	internal void <CheckFirstRunMostApp>b__0() { }

	// RVA: 0xE3A294 Offset: 0xE36294 VA: 0xE3A294
	internal void <CheckFirstRunMostApp>b__1() { }

	// RVA: 0xE3A2D4 Offset: 0xE362D4 VA: 0xE3A2D4
	internal void <CheckFirstRunMostApp>b__2() { }

	// RVA: 0xE3A314 Offset: 0xE36314 VA: 0xE3A314
	internal void <CheckFirstRunMostApp>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Download.<>c__DisplayClass34_0 // TypeDefIndex: 1706
{
	// Fields
	public Download <>4__this; // 0x10
	public bool randomHosting; // 0x18

	// Methods

	// RVA: 0xE39454 Offset: 0xE35454 VA: 0xE39454
	public void .ctor() { }

	// RVA: 0xE3A354 Offset: 0xE36354 VA: 0xE3A354
	internal void <StartUpdate>b__0() { }
}

// Namespace: 
public class Download : BaseMonoBehaviour // TypeDefIndex: 1707
{
	// Fields
	[SerializeField]
	private RectTransform canvasRect; // 0x20
	[SerializeField]
	private GameObject watermarkLayerGo; // 0x28
	[SerializeField]
	private RectTransform backgroundRect; // 0x30
	[SerializeField]
	private Image backgroundImage; // 0x38
	[SerializeField]
	private GameObject groupDownloadProgressGo; // 0x40
	[SerializeField]
	private Slider curentProgress; // 0x48
	[SerializeField]
	private Slider totalProgress; // 0x50
	[SerializeField]
	private Text infoText; // 0x58
	[SerializeField]
	private GameObject goLowConnectDetected; // 0x60
	[SerializeField]
	private GameObject goLowConnectFuncs; // 0x68
	[SerializeField]
	private Button compRedownloadButton; // 0x70
	[SerializeField]
	private Button comEntergameButton; // 0x78
	[SerializeField]
	private GameObject notifyFramed; // 0x80
	[SerializeField]
	private Text notifyContentText; // 0x88
	[SerializeField]
	private Button notifyButton1Button; // 0x90
	[SerializeField]
	private Text notifyButton1Text; // 0x98
	[SerializeField]
	private Button notifyButton2Button; // 0xA0
	[SerializeField]
	private Text notifyButton2Text; // 0xA8
	private DataController dataController; // 0xB0
	private Sprite backgroundSprite; // 0xB8
	private bool hascallStartFunc; // 0xC0
	private bool isPaused; // 0xC1
	private long lastLowConnectDetect; // 0xC8
	private bool isLocalResourceMapped; // 0xD0
	private readonly Queue<Action> performing; // 0xD8

	// Methods

	// RVA: 0xE37D7C Offset: 0xE33D7C VA: 0xE37D7C
	private void Awake() { }

	// RVA: 0xE3800C Offset: 0xE3400C VA: 0xE3800C
	private void Start() { }

	// RVA: 0xE38310 Offset: 0xE34310 VA: 0xE38310
	private void Update() { }

	// RVA: 0xE389EC Offset: 0xE349EC VA: 0xE389EC
	private void OnDestroy() { }

	// RVA: 0xE38778 Offset: 0xE34778 VA: 0xE38778
	private void OpenNotify(string content, string button1Label, Action button1Action, string button2Label, Action button2Action) { }

	// RVA: 0xE38AA4 Offset: 0xE34AA4 VA: 0xE38AA4
	private void OpenErrorCode(string errorcode) { }

	// RVA: 0xE38BEC Offset: 0xE34BEC VA: 0xE38BEC
	private void CheckFirstRunMostApp(Action onFinish) { }

	// RVA: 0xE38E0C Offset: 0xE34E0C VA: 0xE38E0C
	private void CheckFirstRunAndroidApp(string dataPath, string sourceZipPath) { }

	// RVA: 0xE390B4 Offset: 0xE350B4 VA: 0xE390B4
	private void CheckUpdate() { }

	// RVA: 0xE39268 Offset: 0xE35268 VA: 0xE39268
	private void StartUpdate(bool randomHosting) { }

	// RVA: 0xE386C8 Offset: 0xE346C8 VA: 0xE386C8
	private void StartGame() { }

	// RVA: 0xE3945C Offset: 0xE3545C VA: 0xE3945C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE394E4 Offset: 0xE354E4 VA: 0xE394E4
	private void <Start>b__26_0() { }

	[CompilerGenerated]
	// RVA: 0xE395EC Offset: 0xE355EC VA: 0xE395EC
	private void <Start>b__26_3() { }

	[CompilerGenerated]
	// RVA: 0xE39608 Offset: 0xE35608 VA: 0xE39608
	private void <Start>b__26_1() { }

	[CompilerGenerated]
	// RVA: 0xE39710 Offset: 0xE35710 VA: 0xE39710
	private void <Start>b__26_4() { }

	[CompilerGenerated]
	// RVA: 0xE39728 Offset: 0xE35728 VA: 0xE39728
	private void <Start>b__26_2() { }

	[CompilerGenerated]
	// RVA: 0xE39808 Offset: 0xE35808 VA: 0xE39808
	private void <Start>b__26_5() { }

	[CompilerGenerated]
	// RVA: 0xE39888 Offset: 0xE35888 VA: 0xE39888
	private void <Start>b__26_6() { }

	[CompilerGenerated]
	// RVA: 0xE3988C Offset: 0xE3588C VA: 0xE3988C
	private void <Update>b__27_0() { }

	[CompilerGenerated]
	// RVA: 0xE39890 Offset: 0xE35890 VA: 0xE39890
	private void <Update>b__27_1() { }

	[CompilerGenerated]
	// RVA: 0xE39968 Offset: 0xE35968 VA: 0xE39968
	private void <Update>b__27_2() { }

	[CompilerGenerated]
	// RVA: 0xE39984 Offset: 0xE35984 VA: 0xE39984
	private void <OpenErrorCode>b__30_0() { }

	[CompilerGenerated]
	// RVA: 0xE39988 Offset: 0xE35988 VA: 0xE39988
	private void <OpenErrorCode>b__30_1() { }

	[CompilerGenerated]
	// RVA: 0xE39A30 Offset: 0xE35A30 VA: 0xE39A30
	private void <OpenErrorCode>b__30_2() { }

	[CompilerGenerated]
	// RVA: 0xE39A4C Offset: 0xE35A4C VA: 0xE39A4C
	private void <CheckUpdate>b__33_0() { }

	[CompilerGenerated]
	// RVA: 0xE39A50 Offset: 0xE35A50 VA: 0xE39A50
	private void <CheckUpdate>b__33_1() { }

	[CompilerGenerated]
	// RVA: 0xE39A58 Offset: 0xE35A58 VA: 0xE39A58
	private void <StartGame>b__35_0() { }

	[CompilerGenerated]
	// RVA: 0xE39BC4 Offset: 0xE35BC4 VA: 0xE39BC4
	private void <StartGame>b__35_1() { }
}

// Namespace: 
public class LoadUIAsset : MonoBehaviour // TypeDefIndex: 1708
{
	// Methods

	// RVA: 0xE3A494 Offset: 0xE36494 VA: 0xE3A494
	private void Start() { }

	// RVA: 0xE3A498 Offset: 0xE36498 VA: 0xE3A498
	private void LoadAssetBundle() { }

	// RVA: 0xE3A614 Offset: 0xE36614 VA: 0xE3A614
	public void .ctor() { }
}

// Namespace: 
public class RegionServerList.RegionTemplate // TypeDefIndex: 1709
{
	// Fields
	public GameObject goCurrent; // 0x10
	public Button comButton; // 0x18
	public TextMeshProUGUI comTextmesh; // 0x20
	public Image comImage; // 0x28

	// Methods

	// RVA: 0xE3B8E0 Offset: 0xE378E0 VA: 0xE3B8E0
	public void .ctor(GameObject go) { }

	// RVA: 0xE3B02C Offset: 0xE3702C VA: 0xE3B02C
	public void SetSelected(bool selected) { }

	// RVA: 0xE3BBA4 Offset: 0xE37BA4 VA: 0xE3BBA4
	public RegionServerList.RegionTemplate Clone() { }
}

// Namespace: 
public class RegionServerList.ServerTemplate // TypeDefIndex: 1710
{
	// Fields
	public GameObject goCurrent; // 0x10
	public Button comButton; // 0x18
	public Image comImage; // 0x20
	public TextMeshProUGUI comRegionTestmesh; // 0x28
	public TextMeshProUGUI comServerTestmesh; // 0x30

	// Methods

	// RVA: 0xE3BA1C Offset: 0xE37A1C VA: 0xE3BA1C
	public void .ctor(GameObject go) { }

	// RVA: 0xE3BC70 Offset: 0xE37C70 VA: 0xE3BC70
	public RegionServerList.ServerTemplate Clone() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RegionServerList.<>c__DisplayClass22_0 // TypeDefIndex: 1711
{
	// Fields
	public RegionServerList <>4__this; // 0x10
	public RegionServerList.RegionTemplate region; // 0x18
	public string regionData; // 0x20

	// Methods

	// RVA: 0xE3B8D8 Offset: 0xE378D8 VA: 0xE3B8D8
	public void .ctor() { }

	// RVA: 0xE3BF58 Offset: 0xE37F58 VA: 0xE3BF58
	internal void <AddRegion>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RegionServerList.<>c__DisplayClass22_1 // TypeDefIndex: 1712
{
	// Fields
	public string entry; // 0x10
	public RegionServerList.<>c__DisplayClass22_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xE3BC68 Offset: 0xE37C68 VA: 0xE3BC68
	public void .ctor() { }

	// RVA: 0xE3BFD0 Offset: 0xE37FD0 VA: 0xE3BFD0
	internal void <AddRegion>b__1() { }
}

// Namespace: 
public class RegionServerList : MonoBehaviour // TypeDefIndex: 1713
{
	// Fields
	[SerializeField]
	private Image framedImage; // 0x20
	[SerializeField]
	private GameObject UIObject; // 0x28
	[SerializeField]
	private Button confirmButton; // 0x30
	[SerializeField]
	private Button closeButton; // 0x38
	[SerializeField]
	private GameObject RegionContentList; // 0x40
	[SerializeField]
	private GameObject RegionFieldTemplete; // 0x48
	[SerializeField]
	private GameObject ServerContentList; // 0x50
	[SerializeField]
	private GameObject ServerFieldTemplete; // 0x58
	[SerializeField]
	private TextMeshProUGUI textmeshDescFull; // 0x60
	[SerializeField]
	private TextMeshProUGUI textmeshDescStandard; // 0x68
	[SerializeField]
	private TextMeshProUGUI textmeshDescMaintenance; // 0x70
	private GameObject backgo; // 0x78
	private Action onNewServerCallback; // 0x80
	public Action<string, string> onSelect; // 0x88
	private readonly Dictionary<RegionServerList.RegionTemplate, List<RegionServerList.ServerTemplate>> regionMapping; // 0x90

	// Methods

	// RVA: 0xE3A61C Offset: 0xE3661C VA: 0xE3A61C
	private void Start() { }

	// RVA: 0xE3A7A8 Offset: 0xE367A8 VA: 0xE3A7A8
	public void Clear() { }

	// RVA: 0xE3AAD8 Offset: 0xE36AD8 VA: 0xE3AAD8
	public void SaveLastServerSelected(string regiondata, string serverdata) { }

	// RVA: 0xE3AB98 Offset: 0xE36B98 VA: 0xE3AB98
	public bool LoadLastServerSelected() { }

	// RVA: 0xE3AC4C Offset: 0xE36C4C VA: 0xE3AC4C
	public void SelectRegion(RegionServerList.RegionTemplate region) { }

	// RVA: 0xE3B0FC Offset: 0xE370FC VA: 0xE3B0FC
	public void AddRegion(string regionData, List<string> serverList, bool autoSelectServer) { }

	// RVA: 0xE3BD34 Offset: 0xE37D34 VA: 0xE3BD34
	public void Open(GameObject backgo, Action onNewServerAction) { }

	// RVA: 0xE3BE00 Offset: 0xE37E00 VA: 0xE3BE00
	public void Close() { }

	// RVA: 0xE3BEA0 Offset: 0xE37EA0 VA: 0xE3BEA0
	private void CloseOnSelected() { }

	// RVA: 0xE3BED0 Offset: 0xE37ED0 VA: 0xE3BED0
	public void .ctor() { }
}

// Namespace: 
public class UIBackground : MonoBehaviour // TypeDefIndex: 1714
{
	// Fields
	private Sprite loginBackgroundSprite; // 0x20

	// Methods

	// RVA: 0xE3C034 Offset: 0xE38034 VA: 0xE3C034
	private void Awake() { }

	// RVA: 0xE3C264 Offset: 0xE38264 VA: 0xE3C264
	private void OnDestroy() { }

	// RVA: 0xE3C318 Offset: 0xE38318 VA: 0xE3C318
	public void .ctor() { }
}

// Namespace: 
public class RendererCharater // TypeDefIndex: 1715
{
	// Fields
	public readonly SPR.FrameInfo frameInfo; // 0x10
	public readonly Sprite sprite; // 0x18

	// Methods

	// RVA: 0xE3C320 Offset: 0xE38320 VA: 0xE3C320
	public void .ctor(SPR.FrameInfo newFrameInfo, Sprite newSprite) { }
}

// Namespace: 
public class CharaterScript : MonoBehaviour // TypeDefIndex: 1716
{
	// Fields
	[SerializeField]
	private UIManager createCharacterScript; // 0x20
	[SerializeField]
	private RectTransform rectTransform; // 0x28
	[SerializeField]
	private Image spriteRenderer; // 0x30
	[SerializeField]
	private Button buttonComp; // 0x38
	private int gender; // 0x40
	private string animateSpritePath; // 0x48
	private SPR.FrameCount frameLength; // 0x50
	private int series; // 0x58
	private int framePerSeconds; // 0x5C
	private bool isChangeStandBy; // 0x60
	private float currentDelta; // 0x64
	private ushort currentIndex; // 0x68
	private readonly Dictionary<string, RendererCharater> rendererCharaters; // 0x70

	// Methods

	// RVA: 0xE3C364 Offset: 0xE38364 VA: 0xE3C364
	private void Start() { }

	// RVA: 0xE3C428 Offset: 0xE38428 VA: 0xE3C428
	public void Update() { }

	// RVA: 0xE3C788 Offset: 0xE38788 VA: 0xE3C788
	private void OnDestroy() { }

	// RVA: 0xE3C928 Offset: 0xE38928 VA: 0xE3C928
	public RectTransform GetRectTransform() { }

	// RVA: 0xE3C930 Offset: 0xE38930 VA: 0xE3C930
	public void SetActive(bool isActive) { }

	// RVA: 0xE3C984 Offset: 0xE38984 VA: 0xE3C984
	public void SetGender(int gender) { }

	// RVA: 0xE3C98C Offset: 0xE3898C VA: 0xE3C98C
	private void ShowCharacter(bool showFirstActiveAnimate) { }

	// RVA: 0xE3C6E8 Offset: 0xE386E8 VA: 0xE3C6E8
	private void ChangeToStandByActive() { }

	// RVA: 0xE3CA44 Offset: 0xE38A44 VA: 0xE3CA44
	public void SetSeries(int series) { }

	// RVA: 0xE3CA4C Offset: 0xE38A4C VA: 0xE3CA4C
	public void Showoff(bool isActive) { }

	// RVA: 0xE3CA7C Offset: 0xE38A7C VA: 0xE3CA7C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE3CB4C Offset: 0xE38B4C VA: 0xE3CB4C
	private void <Start>b__13_0() { }
}

// Namespace: 
public class ClassUI : MonoBehaviour // TypeDefIndex: 1717
{
	// Fields
	[SerializeReference]
	private GameObject Anim; // 0x20

	// Methods

	// RVA: 0xE3CFCC Offset: 0xE38FCC VA: 0xE3CFCC
	private void Start() { }

	// RVA: 0xE3CFD0 Offset: 0xE38FD0 VA: 0xE3CFD0
	public void ShowAnim() { }

	// RVA: 0xE3CFEC Offset: 0xE38FEC VA: 0xE3CFEC
	public void HideAnim() { }

	// RVA: 0xE3D008 Offset: 0xE39008 VA: 0xE3D008
	private void Update() { }

	// RVA: 0xE3D00C Offset: 0xE3900C VA: 0xE3D00C
	public void .ctor() { }
}

// Namespace: 
public class FullScreen : MonoBehaviour // TypeDefIndex: 1718
{
	// Methods

	// RVA: 0xE3D014 Offset: 0xE39014 VA: 0xE3D014
	private void Awake() { }

	// RVA: 0xE3D018 Offset: 0xE39018 VA: 0xE3D018
	private void Update() { }

	// RVA: 0xE3D14C Offset: 0xE3914C VA: 0xE3D14C
	public void .ctor() { }
}

// Namespace: 
public class LoadCharacterUIAsset : MonoBehaviour // TypeDefIndex: 1719
{
	// Methods

	// RVA: 0xE3D154 Offset: 0xE39154 VA: 0xE3D154
	private void Start() { }

	// RVA: 0xE3D158 Offset: 0xE39158 VA: 0xE3D158
	private void LoadAssetBundle() { }

	// RVA: 0xE3D2D4 Offset: 0xE392D4 VA: 0xE3D2D4
	public void .ctor() { }
}

// Namespace: 
private class UIManager.SeriesTemplate // TypeDefIndex: 1720
{
	// Fields
	public GameObject go; // 0x10
	public Image framed; // 0x18
	public Image activeImage; // 0x20
	public Image unactiveImage; // 0x28
	public Button button; // 0x30

	// Methods

	// RVA: 0xE3D99C Offset: 0xE3999C VA: 0xE3D99C
	public static UIManager.SeriesTemplate Parse(GameObject go) { }

	// RVA: 0xE3F470 Offset: 0xE3B470 VA: 0xE3F470
	public void .ctor() { }
}

// Namespace: 
public class UIManager.OpenConnection // TypeDefIndex: 1721
{
	// Fields
	public string serverName; // 0x10
	public Action<int> action; // 0x18
	public Action onStart; // 0x20
	public Action onStop; // 0x28
	public int totalTryTimes; // 0x30
	public int totalSecondsInSession; // 0x34
	public int currentTryTimes; // 0x38
	public float currentSessionLeftTimne; // 0x3C

	// Methods

	// RVA: 0xE3F3F8 Offset: 0xE3B3F8 VA: 0xE3F3F8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UIManager.<>c__DisplayClass48_0 // TypeDefIndex: 1722
{
	// Fields
	public UIManager <>4__this; // 0x10
	public string charaterName; // 0x18
	public string userName; // 0x20
	public string userpassword; // 0x28
	public Action <>9__6; // 0x30
	public Action<NetCoreManager, NetCoreManager.MessageData> <>9__5; // 0x38
	public Action<NetCoreManager, NetCoreManager.MessageData> <>9__4; // 0x40
	public Action<NetCoreManager, NetCoreManager.MessageData> <>9__3; // 0x48

	// Methods

	// RVA: 0xE3F364 Offset: 0xE3B364 VA: 0xE3F364
	public void .ctor() { }

	// RVA: 0xE3F478 Offset: 0xE3B478 VA: 0xE3F478
	internal void <CreateCharacter>b__0(int _actionCalledTimes) { }

	// RVA: 0xE3F5D0 Offset: 0xE3B5D0 VA: 0xE3F5D0
	internal void <CreateCharacter>b__3(NetCoreManager net, NetCoreManager.MessageData message) { }

	// RVA: 0xE3F95C Offset: 0xE3B95C VA: 0xE3F95C
	internal void <CreateCharacter>b__4(NetCoreManager net, NetCoreManager.MessageData message2) { }

	// RVA: 0xE3FC50 Offset: 0xE3BC50 VA: 0xE3FC50
	internal void <CreateCharacter>b__5(NetCoreManager net, NetCoreManager.MessageData message3) { }

	// RVA: 0xE3FF9C Offset: 0xE3BF9C VA: 0xE3FF9C
	internal void <CreateCharacter>b__6() { }

	// RVA: 0xE40000 Offset: 0xE3C000 VA: 0xE40000
	internal void <CreateCharacter>b__1() { }

	// RVA: 0xE40014 Offset: 0xE3C014 VA: 0xE40014
	internal void <CreateCharacter>b__2() { }
}

// Namespace: 
public class UIManager : BaseMonoBehaviour // TypeDefIndex: 1723
{
	// Fields
	[SerializeField]
	private CharaterScript manClassCharacterScript; // 0x20
	[SerializeField]
	private CharaterScript girlClassCharacterScript; // 0x28
	[SerializeField]
	private Image backgroundImage; // 0x30
	[SerializeField]
	private RectTransform seriesFramedRect; // 0x38
	[SerializeField]
	private GameObject seriesMetalButtonGo; // 0x40
	[SerializeField]
	private GameObject seriesWoodButtonGo; // 0x48
	[SerializeField]
	private GameObject seriesWateButtonGo; // 0x50
	[SerializeField]
	private GameObject seriesFireButtonGo; // 0x58
	[SerializeField]
	private GameObject seriesEarthButtonGo; // 0x60
	[SerializeField]
	private Image createFramedImage; // 0x68
	[SerializeField]
	private RectTransform createFramedRect; // 0x70
	[SerializeField]
	private TextMeshProUGUI createDescriptionTmp; // 0x78
	[SerializeField]
	private TextMeshProUGUI createNamePlaceholderTmp; // 0x80
	[SerializeField]
	private TMP_InputField createNameInputTmp; // 0x88
	[SerializeField]
	private Button createConfirmButton; // 0x90
	[SerializeField]
	private Button createCancelButton; // 0x98
	[SerializeField]
	private GameObject connectingLayer; // 0xA0
	[SerializeField]
	private TextMeshProUGUI connectingText; // 0xA8
	[SerializeField]
	private Button connectingCloseButton; // 0xB0
	[SerializeField]
	private Image entergameLayerBackgroundImage; // 0xB8
	[SerializeField]
	private Image entergameLayerMessageFramedImage; // 0xC0
	[SerializeField]
	private TextMeshProUGUI entergameLayerMessageTmp; // 0xC8
	private bool releasePackageIniRequested; // 0xD0
	private Sprite createCharacterBackgroundSprite; // 0xD8
	private Sprite entergameBackgroundSprite; // 0xE0
	private UIManager.OpenConnection openConnection; // 0xE8
	private int currentSeries; // 0xF0
	private int currentSex; // 0xF4
	private bool loginQueueWaiting; // 0xF8
	private string loginQueueMessage; // 0x100
	private float loginQueueTime; // 0x108
	private Action connectingCloseButtonAction; // 0x110

	// Methods

	// RVA: 0xE3D2DC Offset: 0xE392DC VA: 0xE3D2DC
	private void Start() { }

	// RVA: 0xE3E398 Offset: 0xE3A398 VA: 0xE3E398
	private void Update() { }

	// RVA: 0xE3E94C Offset: 0xE3A94C VA: 0xE3E94C
	public void OnDestroy() { }

	// RVA: 0xE3DC18 Offset: 0xE39C18 VA: 0xE3DC18
	private void SelectSeries(int series) { }

	// RVA: 0xE3CBC4 Offset: 0xE38BC4 VA: 0xE3CBC4
	public void ChangeActiveCharacter(int gender) { }

	// RVA: 0xE3E24C Offset: 0xE3A24C VA: 0xE3E24C
	public void OpenBackgroundCreateCharacter() { }

	// RVA: 0xE3EABC Offset: 0xE3AABC VA: 0xE3EABC
	public void BackToLogin() { }

	// RVA: 0xE3EB74 Offset: 0xE3AB74 VA: 0xE3EB74
	private void HideAllComponent() { }

	// RVA: 0xE3EBE4 Offset: 0xE3ABE4 VA: 0xE3EBE4
	private void ShowAllComponent() { }

	// RVA: 0xE3EC54 Offset: 0xE3AC54 VA: 0xE3EC54
	private void SetLoginQueueMessage(bool active, string message, Action onclose) { }

	// RVA: 0xE3E888 Offset: 0xE3A888 VA: 0xE3E888
	private void SetConnectingMessage(string message, Action onclose) { }

	// RVA: 0xE3ECCC Offset: 0xE3ACCC VA: 0xE3ECCC
	public void StartConnection(int totalTryTimes, int totalSecondsInSession, Action<int> action, Action onstart, Action onstop) { }

	// RVA: 0xE3E814 Offset: 0xE3A814 VA: 0xE3E814
	public void StopConnection() { }

	// RVA: 0xE3EDF4 Offset: 0xE3ADF4 VA: 0xE3EDF4
	public void OpenBackgroundEntergame() { }

	// RVA: 0xE3EF3C Offset: 0xE3AF3C VA: 0xE3EF3C
	public void CreateCharacter() { }

	// RVA: 0xE3F36C Offset: 0xE3B36C VA: 0xE3F36C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE3F42C Offset: 0xE3B42C VA: 0xE3F42C
	private void <Start>b__33_0() { }

	[CompilerGenerated]
	// RVA: 0xE3F434 Offset: 0xE3B434 VA: 0xE3F434
	private void <Start>b__33_1() { }

	[CompilerGenerated]
	// RVA: 0xE3F43C Offset: 0xE3B43C VA: 0xE3F43C
	private void <Start>b__33_2() { }

	[CompilerGenerated]
	// RVA: 0xE3F444 Offset: 0xE3B444 VA: 0xE3F444
	private void <Start>b__33_3() { }

	[CompilerGenerated]
	// RVA: 0xE3F44C Offset: 0xE3B44C VA: 0xE3F44C
	private void <Start>b__33_4() { }

	[CompilerGenerated]
	// RVA: 0xE3F454 Offset: 0xE3B454 VA: 0xE3F454
	private void <Start>b__33_5() { }
}

// Namespace: 
public class BaseObject : MonoBehaviour // TypeDefIndex: 1724
{
	// Fields
	public NpcRes.Special npcontroller; // 0x20
	public bool isMainPlayer; // 0x28

	// Methods

	// RVA: 0xE40028 Offset: 0xE3C028 VA: 0xE40028
	public void SyncCharacterFields(ReadOnlySpan<byte> data) { }

	// RVA: 0xE42768 Offset: 0xE3E768 VA: 0xE42768
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE42770 Offset: 0xE3E770 VA: 0xE42770
	private void <SyncCharacterFields>b__2_0() { }

	[CompilerGenerated]
	// RVA: 0xE42794 Offset: 0xE3E794 VA: 0xE42794
	private void <SyncCharacterFields>b__2_1() { }

	[CompilerGenerated]
	// RVA: 0xE427B8 Offset: 0xE3E7B8 VA: 0xE427B8
	private void <SyncCharacterFields>b__2_2() { }

	[CompilerGenerated]
	// RVA: 0xE427DC Offset: 0xE3E7DC VA: 0xE427DC
	private void <SyncCharacterFields>b__2_3() { }

	[CompilerGenerated]
	// RVA: 0xE42800 Offset: 0xE3E800 VA: 0xE42800
	private void <SyncCharacterFields>b__2_4() { }

	[CompilerGenerated]
	// RVA: 0xE42824 Offset: 0xE3E824 VA: 0xE42824
	private void <SyncCharacterFields>b__2_5() { }

	[CompilerGenerated]
	// RVA: 0xE42848 Offset: 0xE3E848 VA: 0xE42848
	private void <SyncCharacterFields>b__2_6() { }

	[CompilerGenerated]
	// RVA: 0xE4286C Offset: 0xE3E86C VA: 0xE4286C
	private void <SyncCharacterFields>b__2_7() { }

	[CompilerGenerated]
	// RVA: 0xE42890 Offset: 0xE3E890 VA: 0xE42890
	private void <SyncCharacterFields>b__2_8() { }

	[CompilerGenerated]
	// RVA: 0xE428B4 Offset: 0xE3E8B4 VA: 0xE428B4
	private void <SyncCharacterFields>b__2_9() { }

	[CompilerGenerated]
	// RVA: 0xE428D8 Offset: 0xE3E8D8 VA: 0xE428D8
	private void <SyncCharacterFields>b__2_10() { }

	[CompilerGenerated]
	// RVA: 0xE428FC Offset: 0xE3E8FC VA: 0xE428FC
	private void <SyncCharacterFields>b__2_11() { }

	[CompilerGenerated]
	// RVA: 0xE42920 Offset: 0xE3E920 VA: 0xE42920
	private void <SyncCharacterFields>b__2_12() { }

	[CompilerGenerated]
	// RVA: 0xE42944 Offset: 0xE3E944 VA: 0xE42944
	private void <SyncCharacterFields>b__2_13() { }
}

// Namespace: 
public class PlayerMain.PartyData // TypeDefIndex: 1725
{
	// Fields
	public readonly ConcurrentDictionary<string, PartyJoin> members; // 0x10
	public readonly ConcurrentDictionary<string, PartyRequest> partyRequests; // 0x18
	public readonly ConcurrentDictionary<int, PartyInvite> partyInvites; // 0x20
	public PartyCaptain partyCaptain; // 0x28

	// Methods

	// RVA: 0xE4DDD8 Offset: 0xE49DD8 VA: 0xE4DDD8
	public void .ctor() { }
}

// Namespace: 
private class PlayerMain.PickupClickField // TypeDefIndex: 1726
{
	// Fields
	public int distance; // 0x10
	public Object gameobject; // 0x18
	public string nid; // 0x20

	// Methods

	// RVA: 0xE4DF08 Offset: 0xE49F08 VA: 0xE4DF08
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerMain.<>c // TypeDefIndex: 1727
{
	// Fields
	public static readonly PlayerMain.<>c <>9; // 0x0
	public static Action <>9__59_0; // 0x8
	public static Action <>9__60_0; // 0x10
	public static Action <>9__63_0; // 0x18
	public static Action <>9__64_0; // 0x20
	public static Action <>9__65_0; // 0x28
	public static Action <>9__68_0; // 0x30
	public static Action <>9__95_0; // 0x38
	public static Action<Vector2> <>9__105_0; // 0x40
	public static Action <>9__105_1; // 0x48
	public static Action<Vector2> <>9__106_0; // 0x50
	public static Comparison<PlayerMain.PickupClickField> <>9__136_0; // 0x58
	public static Comparison<KeyValuePair<MapDialogNpc, int>> <>9__141_1; // 0x60

	// Methods

	// RVA: 0xE4DF10 Offset: 0xE49F10 VA: 0xE4DF10
	private static void .cctor() { }

	// RVA: 0xE4DF78 Offset: 0xE49F78 VA: 0xE4DF78
	public void .ctor() { }

	// RVA: 0xE4DF80 Offset: 0xE49F80 VA: 0xE4DF80
	internal void <PlayMusicUseItem>b__59_0() { }

	// RVA: 0xE4DFE4 Offset: 0xE49FE4 VA: 0xE4DFE4
	internal void <CloseStorageBox>b__60_0() { }

	// RVA: 0xE4E0A4 Offset: 0xE4A0A4 VA: 0xE4E0A4
	internal void <CloseBagarate>b__63_0() { }

	// RVA: 0xE4E140 Offset: 0xE4A140 VA: 0xE4E140
	internal void <OpenBagarate>b__64_0() { }

	// RVA: 0xE4E1DC Offset: 0xE4A1DC VA: 0xE4E1DC
	internal void <CloseNpcShop>b__65_0() { }

	// RVA: 0xE4E2B0 Offset: 0xE4A2B0 VA: 0xE4E2B0
	internal void <CloseNpcDialog>b__68_0() { }

	// RVA: 0xE4E394 Offset: 0xE4A394 VA: 0xE4E394
	internal void <EnterPlayerStart>b__95_0() { }

	// RVA: 0xE4E430 Offset: 0xE4A430 VA: 0xE4E430
	internal void <SelfForceMoveStop>b__105_0(Vector2 _pos) { }

	// RVA: 0xE4E4A4 Offset: 0xE4A4A4 VA: 0xE4E4A4
	internal void <SelfForceMoveStop>b__105_1() { }

	// RVA: 0xE4E588 Offset: 0xE4A588 VA: 0xE4E588
	internal void <SelfForceMoveTarget>b__106_0(Vector2 _pos) { }

	// RVA: 0xE4E5FC Offset: 0xE4A5FC VA: 0xE4E5FC
	internal int <FindAndPickNearestObject>b__136_0(PlayerMain.PickupClickField a, PlayerMain.PickupClickField b) { }

	// RVA: 0xE4E624 Offset: 0xE4A624 VA: 0xE4E624
	internal int <GotoNpc>b__141_1(KeyValuePair<MapDialogNpc, int> a, KeyValuePair<MapDialogNpc, int> b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerMain.<>c__DisplayClass111_0 // TypeDefIndex: 1728
{
	// Fields
	public PlayerMain <>4__this; // 0x10
	public NpcRes.Special cidController; // 0x18

	// Methods

	// RVA: 0xE4E67C Offset: 0xE4A67C VA: 0xE4E67C
	public void .ctor() { }

	// RVA: 0xE4E684 Offset: 0xE4A684 VA: 0xE4E684
	internal void <PartyCheck>b__0() { }

	// RVA: 0xE4E70C Offset: 0xE4A70C VA: 0xE4E70C
	internal void <PartyCheck>b__1() { }

	// RVA: 0xE4E794 Offset: 0xE4A794 VA: 0xE4E794
	internal void <PartyCheck>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerMain.<>c__DisplayClass112_0 // TypeDefIndex: 1729
{
	// Fields
	public KeyValuePair<string, NpcRes.Special> entry; // 0x10
	public PlayerMain <>4__this; // 0x20

	// Methods

	// RVA: 0xE4E81C Offset: 0xE4A81C VA: 0xE4E81C
	public void .ctor() { }

	// RVA: 0xE4E824 Offset: 0xE4A824 VA: 0xE4E824
	internal void <PartyChange>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerMain.<>c__DisplayClass132_0 // TypeDefIndex: 1730
{
	// Fields
	public Object gameObject; // 0x10

	// Methods

	// RVA: 0xE4E8B8 Offset: 0xE4A8B8 VA: 0xE4E8B8
	public void .ctor() { }

	// RVA: 0xE4E8C0 Offset: 0xE4A8C0 VA: 0xE4E8C0
	internal void <PickupObject>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerMain.<>c__DisplayClass133_0 // TypeDefIndex: 1731
{
	// Fields
	public PlayerMain <>4__this; // 0x10
	public Object itemObject; // 0x18

	// Methods

	// RVA: 0xE4EA58 Offset: 0xE4AA58 VA: 0xE4EA58
	public void .ctor() { }

	// RVA: 0xE4EA60 Offset: 0xE4AA60 VA: 0xE4EA60
	internal void <GotoAndPickTargetObject>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerMain.<>c__DisplayClass140_0 // TypeDefIndex: 1732
{
	// Fields
	public PlayerMain <>4__this; // 0x10
	public string npcID; // 0x18

	// Methods

	// RVA: 0xE4EA80 Offset: 0xE4AA80 VA: 0xE4EA80
	public void .ctor() { }

	// RVA: 0xE4EA88 Offset: 0xE4AA88 VA: 0xE4EA88
	internal void <GotoNpc>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerMain.<>c__DisplayClass141_0 // TypeDefIndex: 1733
{
	// Fields
	public int waitingCount; // 0x10
	public PlayerMain <>4__this; // 0x18
	public GotoNpc message; // 0x20

	// Methods

	// RVA: 0xE4EB24 Offset: 0xE4AB24 VA: 0xE4EB24
	public void .ctor() { }

	// RVA: 0xE4EB2C Offset: 0xE4AB2C VA: 0xE4EB2C
	internal void <GotoNpc>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerMain.<>c__DisplayClass172_0 // TypeDefIndex: 1734
{
	// Fields
	public Item item; // 0x10

	// Methods

	// RVA: 0xE4EBB8 Offset: 0xE4ABB8 VA: 0xE4EBB8
	public void .ctor() { }

	// RVA: 0xE4EBC0 Offset: 0xE4ABC0 VA: 0xE4EBC0
	internal void <MoveItemFromStorageToBagarate>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerMain.<>c__DisplayClass62_0 // TypeDefIndex: 1735
{
	// Fields
	public string message; // 0x10

	// Methods

	// RVA: 0xE4ECA0 Offset: 0xE4ACA0 VA: 0xE4ECA0
	public void .ctor() { }

	// RVA: 0xE4ECA8 Offset: 0xE4ACA8 VA: 0xE4ECA8
	internal void <Talk>b__0() { }
}

// Namespace: 
public class PlayerMain : BaseObject // TypeDefIndex: 1736
{
	// Fields
	public static PlayerMain instance; // 0x0
	public static int screenVisibilityRadiusHorizontal; // 0x8
	public static int screenVisibilityRadiusVertical; // 0xC
	public readonly ConcurrentDictionary<int, Item> items; // 0x30
	public readonly ConcurrentDictionary<int, Skill> skills; // 0x38
	public readonly ConcurrentDictionary<int, Skill> skillgames; // 0x40
	public World world; // 0x48
	private MainUnity autoplay; // 0x50
	private PlayerMainSkillRadius skillRadiusHandle; // 0x58
	public PlayerMainSkillDirection skillDirectionHandle; // 0x60
	public PlayerMainSkillPositionArea skillPositionAreaHandle; // 0x68
	public PlayerMainMapBackground mapBackgroundHandle; // 0x70
	private readonly Dictionary<int, double> nextCastSkillTime; // 0x78
	private double nextCastAnimateTime; // 0x80
	public readonly PlayerMain.PartyData partyData; // 0x88
	private readonly ConcurrentQueue<Action> performEachFrameQueue; // 0x90
	private readonly ConcurrentQueue<Action> performInMainThreadQueue; // 0x98
	public readonly Target target; // 0xA0
	public readonly Dictionary<string, TradeInviteToCli> invitingTrades; // 0xA8
	private int killTargetBySkillId; // 0xB0
	private int killTargetBySkillRadius; // 0xB4
	private long killTargetNextStartTime; // 0xB8
	private long killTargetNextActiveTime; // 0xC0
	private long jumpNextNormalStaminaFrames; // 0xC8
	private int jumpCurrentStaminaRatio; // 0xD0
	private bool isButtonSkillPressing; // 0xD4
	private MapDialogNpcListResponse mapDialogNpcList; // 0xD8
	private int mapDialogNpcListRequestingMapId; // 0xE0
	public int mapIdOnlineCurrently; // 0xE4
	public NpcTransferMessage npcDialogMessage; // 0xE8
	public ShopTypeOne npcShopTypeOne; // 0xF0
	public HotkeyItemDatabase hotkeyItem; // 0xF8
	public string runFollowTargetCid; // 0x100
	private long runFollowTargetNextFrame; // 0x108
	private Action<int> autoplayRegisteredOnThrowItem; // 0x110
	public StorageExtendCell storageExtendCell; // 0x118
	private static readonly Dictionary<int, string> LimitItemPotionParticularMapping; // 0x10
	private static readonly string[] weaponEquipLimited; // 0x18
	private long pickupClickNextToFindNpcFrames; // 0x120
	[CompilerGenerated]
	private List<PathFinding.Node> <findingPathVector>k__BackingField; // 0x128
	private PathFinding.Node findingPathTarget; // 0x130
	private bool findingPathIsNewTargeted; // 0x138
	private long findingPathLastSendMessageFrame; // 0x140
	private Action<int> findingPathOnVector; // 0x148
	private Action findingPathOnFinish; // 0x150
	private bool findingPathIsRunning; // 0x158
	private bool findingPathUpdate; // 0x159

	// Properties
	public List<PathFinding.Node> findingPathVector { get; set; }

	// Methods

	// RVA: 0xE42968 Offset: 0xE3E968 VA: 0xE42968
	public void Release() { }

	// RVA: 0xE42A6C Offset: 0xE3EA6C VA: 0xE42A6C
	public void Initialize() { }

	// RVA: 0xE42B4C Offset: 0xE3EB4C VA: 0xE42B4C
	private void Update() { }

	// RVA: 0xE4349C Offset: 0xE3F49C VA: 0xE4349C
	private void OnDestroy() { }

	// RVA: 0xE434D0 Offset: 0xE3F4D0 VA: 0xE434D0
	public void LoadResourceRegion(int region) { }

	// RVA: 0xE435A4 Offset: 0xE3F5A4 VA: 0xE435A4
	public void AutoplayRegisterOnThrowItem(Action<int> action) { }

	// RVA: 0xE435B4 Offset: 0xE3F5B4 VA: 0xE435B4
	public void RegisterOnThrowItem(Item item) { }

	// RVA: 0xE43610 Offset: 0xE3F610 VA: 0xE43610
	public bool IsOutScreenVisibility(int targetMapX, int targetMapY) { }

	// RVA: 0xE4378C Offset: 0xE3F78C VA: 0xE4378C
	public bool IsInScreenVisibility(int targetMapX, int targetMapY) { }

	// RVA: 0xE43908 Offset: 0xE3F908 VA: 0xE43908
	public bool EquipmentExistingDurabilityDown(int reducedCount) { }

	// RVA: 0xE4396C Offset: 0xE3F96C VA: 0xE4396C
	public bool EquipmentHasDurabilityDown(int durabilityTriggered) { }

	// RVA: 0xE439D0 Offset: 0xE3F9D0 VA: 0xE439D0
	public bool AnyGoldItemMappingExisting(Dictionary<int, bool> goldindexShared) { }

	// RVA: 0xE43CA4 Offset: 0xE3FCA4 VA: 0xE43CA4
	public string GetGoldItemSetDescription(Item item) { }

	// RVA: 0xE43FE4 Offset: 0xE3FFE4 VA: 0xE43FE4
	public bool IsRangeWeaponEquipped() { }

	// RVA: 0xE44040 Offset: 0xE40040 VA: 0xE44040
	public Item GetItemBagarateGdp(int g, int d, int p) { }

	// RVA: 0xE442F8 Offset: 0xE402F8 VA: 0xE442F8
	public int GetSkillAttackRadius(int skillid) { }

	// RVA: 0xE4438C Offset: 0xE4038C VA: 0xE4438C
	public int GetSkillLevel(int skillid) { }

	// RVA: 0xE44420 Offset: 0xE40420 VA: 0xE44420
	public bool IsExistingMinistateItemMagic(int particular) { }

	// RVA: 0xE44484 Offset: 0xE40484 VA: 0xE44484
	public ConcurrentDictionary<int, Item> GetAllGameItems() { }

	// RVA: 0xE4448C Offset: 0xE4048C VA: 0xE4448C
	public int GetAllItemCount() { }

	// RVA: 0xE444DC Offset: 0xE404DC VA: 0xE444DC
	public int GetItemIndexInBagarate(int g, int d, int p) { }

	// RVA: 0xE44794 Offset: 0xE40794 VA: 0xE44794
	public bool IsExistingItemInBagarate(int g, int d, int p) { }

	// RVA: 0xE44A4C Offset: 0xE40A4C VA: 0xE44A4C
	public void PlayMusicUseItem() { }

	// RVA: 0xE44B8C Offset: 0xE40B8C VA: 0xE44B8C
	public void CloseStorageBox() { }

	// RVA: 0xE44CCC Offset: 0xE40CCC VA: 0xE44CCC
	public void OpenStorageBox() { }

	// RVA: 0xE45040 Offset: 0xE41040 VA: 0xE45040
	public void Talk(string message) { }

	// RVA: 0xE45104 Offset: 0xE41104 VA: 0xE45104
	public void CloseBagarate() { }

	// RVA: 0xE45230 Offset: 0xE41230 VA: 0xE45230
	public void OpenBagarate() { }

	// RVA: 0xE4535C Offset: 0xE4135C VA: 0xE4535C
	public void CloseNpcShop() { }

	// RVA: 0xE454A0 Offset: 0xE414A0 VA: 0xE454A0
	public void SetNpcShopTypeOne(ShopTypeOne message) { }

	// RVA: 0xE45560 Offset: 0xE41560 VA: 0xE45560
	public string FindDialogNpcIdByName(string name, int radiusFlat) { }

	// RVA: 0xE458F4 Offset: 0xE418F4 VA: 0xE458F4
	public void CloseNpcDialog() { }

	// RVA: 0xE459FC Offset: 0xE419FC VA: 0xE459FC
	public void SetNpcTransferMessage(NpcTransferMessage message) { }

	// RVA: 0xE45B2C Offset: 0xE41B2C VA: 0xE45B2C
	public int GetCountPotionOwned() { }

	// RVA: 0xE45E2C Offset: 0xE41E2C VA: 0xE45E2C
	public int GetItemBagarateGdpCount(int g, int d, int p) { }

	// RVA: 0xE460E4 Offset: 0xE420E4 VA: 0xE460E4
	public void SetMapDialogNpcList(MapDialogNpcListResponse message) { }

	// RVA: 0xE4617C Offset: 0xE4217C VA: 0xE4617C
	public MapDialogNpcListResponse GetCurrentMapDialogNpcList() { }

	// RVA: 0xE46220 Offset: 0xE42220 VA: 0xE46220
	public bool IsHorseEquipped() { }

	// RVA: 0xE4628C Offset: 0xE4228C VA: 0xE4628C
	public void Townportal() { }

	// RVA: 0xE46314 Offset: 0xE42314 VA: 0xE46314
	public bool IsExistingPlayerEnemyAround(int radius) { }

	// RVA: 0xE4660C Offset: 0xE4260C VA: 0xE4660C
	public int GetStorageItemCount() { }

	// RVA: 0xE46884 Offset: 0xE42884 VA: 0xE46884
	public int GetStorageEmptyCount() { }

	// RVA: 0xE468B0 Offset: 0xE428B0 VA: 0xE468B0
	public long GetStorageMoney() { }

	// RVA: 0xE468D4 Offset: 0xE428D4 VA: 0xE468D4
	public int GetBagarateItemCount() { }

	// RVA: 0xE46B4C Offset: 0xE42B4C VA: 0xE46B4C
	public int GetBagarateEmptyCellCount() { }

	// RVA: 0xE46B78 Offset: 0xE42B78 VA: 0xE46B78
	public long GetBagarateMoney() { }

	// RVA: 0xE46B9C Offset: 0xE42B9C VA: 0xE46B9C
	public bool IsExistingHealthItemInBagarate() { }

	// RVA: 0xE46E60 Offset: 0xE42E60 VA: 0xE46E60
	public bool IsExistingManaItemInBagarate() { }

	// RVA: 0xE47108 Offset: 0xE43108 VA: 0xE47108
	public void SetActiveAuraSkill(int skillId) { }

	// RVA: 0xE4720C Offset: 0xE4320C VA: 0xE4720C
	public bool IsButtonSkillPressing() { }

	// RVA: 0xE47214 Offset: 0xE43214 VA: 0xE47214
	public void SetButtonSkillPressing(bool isButtonSkillPressing) { }

	// RVA: 0xE4721C Offset: 0xE4321C VA: 0xE4721C
	public void SendGSMessage(Id id) { }

	// RVA: 0xE44FD4 Offset: 0xE40FD4 VA: 0xE44FD4
	public void SendGSMessage(Id id, IMessage message) { }

	// RVA: 0xE47278 Offset: 0xE43278 VA: 0xE47278
	public ConcurrentDictionary<string, NpcRes.Special> GetNearPlayers() { }

	// RVA: 0xE458A0 Offset: 0xE418A0 VA: 0xE458A0
	public ConcurrentDictionary<string, NpcRes.Normal> GetNearNpcs() { }

	// RVA: 0xE44F80 Offset: 0xE40F80 VA: 0xE44F80
	public ConcurrentDictionary<string, Object> GetNearObjects() { }

	// RVA: 0xE472CC Offset: 0xE432CC VA: 0xE472CC
	public void PrivateFightTarget(PrivateFightTarget message) { }

	// RVA: 0xE47550 Offset: 0xE43550 VA: 0xE47550
	public void EnterPlayerStart(EnterPlayerStart message) { }

	// RVA: 0xE47A80 Offset: 0xE43A80 VA: 0xE47A80
	public void EnterMap(EnterMap message) { }

	// RVA: 0xE47B9C Offset: 0xE43B9C VA: 0xE47B9C
	public void BounceSelfPoint(BounceSelfPoint message) { }

	// RVA: 0xE47C70 Offset: 0xE43C70 VA: 0xE47C70
	public void TradeStart(TradeStart message) { }

	// RVA: 0xE47CF4 Offset: 0xE43CF4 VA: 0xE47CF4
	public void TradeInviteToCli(TradeInviteToCli message) { }

	// RVA: 0xE47D8C Offset: 0xE43D8C VA: 0xE47D8C
	public MainUnity GetAutoplay() { }

	// RVA: 0xE47E04 Offset: 0xE43E04 VA: 0xE47E04
	public MainUnity ReferAutoplay() { }

	// RVA: 0xE47E0C Offset: 0xE43E0C VA: 0xE47E0C
	public void ApplyAutoplayProfile(ApplyAutoplayProfile message) { }

	// RVA: 0xE47FB8 Offset: 0xE43FB8 VA: 0xE47FB8
	public void AutoplayDenyMovingFollow() { }

	// RVA: 0xE48078 Offset: 0xE44078 VA: 0xE48078
	public void AutoplayConfigDown(AutoplayConfigDown message) { }

	// RVA: 0xE48224 Offset: 0xE44224 VA: 0xE48224
	public void SelfForceMoveStop(ReadOnlySpan<byte> data) { }

	// RVA: 0xE484B8 Offset: 0xE444B8 VA: 0xE484B8
	public void SelfForceMoveTarget(ReadOnlySpan<byte> data) { }

	// RVA: 0xE4867C Offset: 0xE4467C VA: 0xE4867C
	public void SetUpMainPlayer(NpcRes.Special controller, World world) { }

	// RVA: 0xE44B34 Offset: 0xE40B34 VA: 0xE44B34
	public void PerformEachFrame(Action action) { }

	// RVA: 0xE48748 Offset: 0xE44748 VA: 0xE48748
	public void PerformInMainThread(Action action) { }

	// RVA: 0xE487A0 Offset: 0xE447A0 VA: 0xE487A0
	public bool IsParty(int teamId) { }

	// RVA: 0xE42598 Offset: 0xE3E598 VA: 0xE42598
	public void PartyCheck(string cid, int pastTeamId, int presentTeamId) { }

	// RVA: 0xE421F8 Offset: 0xE3E1F8 VA: 0xE421F8
	public void PartyChange(int pastTeamId, int presentTeamId) { }

	// RVA: 0xE487D4 Offset: 0xE447D4 VA: 0xE487D4
	public void CharacterResponse(Character character) { }

	// RVA: 0xE491B8 Offset: 0xE451B8 VA: 0xE491B8
	public void CallTargetNpc(string npcid) { }

	// RVA: 0xE49274 Offset: 0xE45274 VA: 0xE49274
	public void PlayerSit() { }

	// RVA: 0xE493F4 Offset: 0xE453F4 VA: 0xE493F4
	public void PlayerSwitchHorse() { }

	// RVA: 0xE4941C Offset: 0xE4541C VA: 0xE4941C
	private void SyncSwitchHorse(bool isUseHose) { }

	// RVA: 0xE494F0 Offset: 0xE454F0 VA: 0xE494F0
	public void SetEndOfCastAnimate(int animateInterval) { }

	// RVA: 0xE49564 Offset: 0xE45564 VA: 0xE49564
	public bool IsEndOfCastAnimate(int delayFrameAppend = 0) { }

	// RVA: 0xE495EC Offset: 0xE455EC VA: 0xE495EC
	public int CalcJumpCurrentStamina(int originStamina) { }

	// RVA: 0xE4969C Offset: 0xE4569C VA: 0xE4969C
	public bool DoSkill(int id) { }

	// RVA: 0xE4A484 Offset: 0xE46484 VA: 0xE4A484
	public void SetKillTargetBySkill(int skillid) { }

	// RVA: 0xE4A5CC Offset: 0xE465CC VA: 0xE4A5CC
	private void KillTargetBySkillResetWeaponType() { }

	// RVA: 0xE42E78 Offset: 0xE3EE78 VA: 0xE42E78
	private void KillTargetBySkillUpdate() { }

	// RVA: 0xE42C64 Offset: 0xE3EC64 VA: 0xE42C64
	private void RunFollowTargetUpdate() { }

	// RVA: 0xE4A350 Offset: 0xE46350 VA: 0xE4A350
	private void SendDoSkillTargetPosition(int skillid, int positionX, int positionY, int isPhysic) { }

	// RVA: 0xE4A21C Offset: 0xE4621C VA: 0xE4A21C
	private void SendDoSkillTargetNpc(int skillid, string nid, int isPhysic) { }

	// RVA: 0xE4A0E8 Offset: 0xE460E8 VA: 0xE4A0E8
	private void SendDoSkillTargetPlayer(int skillid, string cid, int isPhysic) { }

	// RVA: 0xE4A82C Offset: 0xE4682C VA: 0xE4A82C
	public void RemoveSkill(int skillid) { }

	// RVA: 0xE4A950 Offset: 0xE46950 VA: 0xE4A950
	public void SyncSkill(Skill skillapp) { }

	// RVA: 0xE4AAF0 Offset: 0xE46AF0 VA: 0xE4AAF0
	public void PickupObject(Object gameObject) { }

	// RVA: 0xE4ABB4 Offset: 0xE46BB4 VA: 0xE4ABB4
	public void GotoAndPickTargetObject(Object itemObject) { }

	// RVA: 0xE4ACF4 Offset: 0xE46CF4 VA: 0xE4ACF4
	public void FindAndPickNearestObject() { }

	// RVA: 0xE4B6C4 Offset: 0xE476C4 VA: 0xE4B6C4
	public void TeleportSynchronous(int top, int left) { }

	// RVA: 0xE42A48 Offset: 0xE3EA48 VA: 0xE42A48
	public void ClearRun() { }

	// RVA: 0xE4B928 Offset: 0xE47928 VA: 0xE4B928
	public void ProtocolGotoPosition(GotoPosition message) { }

	// RVA: 0xE4B9B8 Offset: 0xE479B8 VA: 0xE4B9B8
	public void GotoNpc(Position npcPosition, string npcID) { }

	// RVA: 0xE4BAAC Offset: 0xE47AAC VA: 0xE4BAAC
	public void GotoNpc(GotoNpc message, int waitingCount = 0) { }

	[CompilerGenerated]
	// RVA: 0xE4C2AC Offset: 0xE482AC VA: 0xE4C2AC
	public List<PathFinding.Node> get_findingPathVector() { }

	[CompilerGenerated]
	// RVA: 0xE4C2B4 Offset: 0xE482B4 VA: 0xE4C2B4
	private void set_findingPathVector(List<PathFinding.Node> value) { }

	// RVA: 0xE4A620 Offset: 0xE46620 VA: 0xE4A620
	public void GotoFindingPath(int targetX, int targetY, int approach3d, Action onFinish, Action onFailured, Action onFoundedPatch) { }

	// RVA: 0xE4C2C4 Offset: 0xE482C4 VA: 0xE4C2C4
	public void GotoFindingPathOnVector(Action<int> findingPathOnVector) { }

	// RVA: 0xE4B76C Offset: 0xE4776C VA: 0xE4B76C
	public void GotoFindingPathStop() { }

	// RVA: 0xE43094 Offset: 0xE3F094 VA: 0xE43094
	private void GotoFindingPathUpdate() { }

	// RVA: 0xE4C2D4 Offset: 0xE482D4 VA: 0xE4C2D4
	public void ItemViewportOpenCompare(Item item, Dictionary<ItemDetailPc.Button, Action> buttonCallback) { }

	// RVA: 0xE4C3E0 Offset: 0xE483E0 VA: 0xE4C3E0
	public void SetUpMapBackground(PlayerMainMapBackground handle) { }

	// RVA: 0xE4C41C Offset: 0xE4841C VA: 0xE4C41C
	public void SetUpSkillDirection(PlayerMainSkillDirection handle) { }

	// RVA: 0xE4C458 Offset: 0xE48458 VA: 0xE4C458
	public void SetUpSkillPositionArea(PlayerMainSkillPositionArea handle) { }

	// RVA: 0xE4C494 Offset: 0xE48494 VA: 0xE4C494
	public void SetUpSkillRadius(PlayerMainSkillRadius skillRadiusGameobject) { }

	// RVA: 0xE4C4D0 Offset: 0xE484D0 VA: 0xE4C4D0
	public void SkillDirectionDraw(int directionIndex64, int showDirImage) { }

	// RVA: 0xE4C590 Offset: 0xE48590 VA: 0xE4C590
	public void SkillPositionAreaDraw(float distanceCurrently, float distanceMaximum, int directionIndex64, int showDirImage) { }

	// RVA: 0xE4C66C Offset: 0xE4866C VA: 0xE4C66C
	public void SkillDirectionClear() { }

	// RVA: 0xE4C684 Offset: 0xE48684 VA: 0xE4C684
	public void SkillPositionAreaClear() { }

	// RVA: 0xE4C69C Offset: 0xE4869C VA: 0xE4C69C
	public void SkillRadiusDraw(int skillid) { }

	// RVA: 0xE4C76C Offset: 0xE4876C VA: 0xE4C76C
	public void SyncItemDurability(int itemindex, int durability) { }

	// RVA: 0xE4C7EC Offset: 0xE487EC VA: 0xE4C7EC
	public void SyncStorageLockState(StorageLockState message) { }

	// RVA: 0xE4C878 Offset: 0xE48878 VA: 0xE4C878
	public void SyncStorageExtendCell(StorageExtendCell message) { }

	// RVA: 0xE4C918 Offset: 0xE48918 VA: 0xE4C918
	public void SyncItem(Item itemData) { }

	// RVA: 0xE4CCC8 Offset: 0xE48CC8 VA: 0xE4CCC8
	public void RemoveItem(RemoveItemRespone removeItem) { }

	// RVA: 0xE4CD94 Offset: 0xE48D94 VA: 0xE4CD94
	public void MoveItemFromStorageToBagarate(Item item) { }

	// RVA: 0xE4CEFC Offset: 0xE48EFC VA: 0xE4CEFC
	public void RequestUseItemFromBag(Item item) { }

	// RVA: 0xE4D000 Offset: 0xE49000 VA: 0xE4D000
	public void BuyItem(string shopKey, int itemindex, int quantity) { }

	// RVA: 0xE4D12C Offset: 0xE4912C VA: 0xE4D12C
	public void .ctor() { }

	// RVA: 0xE4D414 Offset: 0xE49414 VA: 0xE4D414
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xE4DA68 Offset: 0xE49A68 VA: 0xE4DA68
	private void <EnterMap>b__96_0() { }

	[CompilerGenerated]
	// RVA: 0xE4DA90 Offset: 0xE49A90 VA: 0xE4DA90
	private void <KillTargetBySkillUpdate>b__125_0() { }

	[CompilerGenerated]
	// RVA: 0xE4DB04 Offset: 0xE49B04 VA: 0xE4DB04
	private void <TeleportSynchronous>b__137_0() { }

	[CompilerGenerated]
	// RVA: 0xE4DB3C Offset: 0xE49B3C VA: 0xE4DB3C
	private void <GotoFindingPathStop>b__155_0() { }

	[CompilerGenerated]
	// RVA: 0xE4DC28 Offset: 0xE49C28 VA: 0xE4DC28
	private void <GotoFindingPathUpdate>b__156_0() { }

	[CompilerGenerated]
	// RVA: 0xE4DC58 Offset: 0xE49C58 VA: 0xE4DC58
	private void <GotoFindingPathUpdate>b__156_1(Vector2 _pos) { }
}

// Namespace: 
public class PlayerOther : BaseObject, IPointerDownHandler, IEventSystemHandler // TypeDefIndex: 1737
{
	// Fields
	private GameObject selectGameObject; // 0x30
	private SpriteRenderer selectImage; // 0x38
	private static long lastPointerDownTime; // 0x0
	private static Position lastPointerDownMainPosition; // 0x8

	// Methods

	// RVA: 0xE4ED24 Offset: 0xE4AD24 VA: 0xE4ED24
	public void SetSelectGameObject(GameObject go) { }

	// RVA: 0xE4EDB0 Offset: 0xE4ADB0 VA: 0xE4EDB0
	public void SetUpPlayerDetail() { }

	// RVA: 0xE4F5DC Offset: 0xE4B5DC VA: 0xE4F5DC
	public void ChangeSelect(bool selected, Target.Color color) { }

	// RVA: 0xE4F6DC Offset: 0xE4B6DC VA: 0xE4F6DC Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xE4F8B4 Offset: 0xE4B8B4 VA: 0xE4F8B4
	private void OnMouseUp() { }

	// RVA: 0xE4FA8C Offset: 0xE4BA8C VA: 0xE4FA8C
	public void .ctor() { }

	// RVA: 0xE4FA94 Offset: 0xE4BA94 VA: 0xE4FA94
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xE4FB1C Offset: 0xE4BB1C VA: 0xE4FB1C
	private void <SetUpPlayerDetail>b__3_0() { }

	[CompilerGenerated]
	// RVA: 0xE4FB70 Offset: 0xE4BB70 VA: 0xE4FB70
	private void <SetUpPlayerDetail>b__3_1() { }

	[CompilerGenerated]
	// RVA: 0xE4FB98 Offset: 0xE4BB98 VA: 0xE4FB98
	private void <SetUpPlayerDetail>b__3_2() { }

	[CompilerGenerated]
	// RVA: 0xE4FBC0 Offset: 0xE4BBC0 VA: 0xE4FBC0
	private void <SetUpPlayerDetail>b__3_3() { }

	[CompilerGenerated]
	// RVA: 0xE4FBE8 Offset: 0xE4BBE8 VA: 0xE4FBE8
	private void <SetUpPlayerDetail>b__3_4() { }

	[CompilerGenerated]
	// RVA: 0xE4FC10 Offset: 0xE4BC10 VA: 0xE4FC10
	private void <SetUpPlayerDetail>b__3_5() { }

	[CompilerGenerated]
	// RVA: 0xE4FC38 Offset: 0xE4BC38 VA: 0xE4FC38
	private void <SetUpPlayerDetail>b__3_6() { }

	[CompilerGenerated]
	// RVA: 0xE4FC60 Offset: 0xE4BC60 VA: 0xE4FC60
	private void <SetUpPlayerDetail>b__3_7() { }

	[CompilerGenerated]
	// RVA: 0xE4FC88 Offset: 0xE4BC88 VA: 0xE4FC88
	private void <SetUpPlayerDetail>b__3_8() { }

	[CompilerGenerated]
	// RVA: 0xE4FCB0 Offset: 0xE4BCB0 VA: 0xE4FCB0
	private void <SetUpPlayerDetail>b__3_9() { }

	[CompilerGenerated]
	// RVA: 0xE4FCD8 Offset: 0xE4BCD8 VA: 0xE4FCD8
	private void <SetUpPlayerDetail>b__3_10() { }

	[CompilerGenerated]
	// RVA: 0xE4FCFC Offset: 0xE4BCFC VA: 0xE4FCFC
	private void <SetUpPlayerDetail>b__3_11() { }
}

// Namespace: 
public class NpcController : MonoBehaviour, IPointerDownHandler, IEventSystemHandler // TypeDefIndex: 1738
{
	// Fields
	public NpcRes.Normal npcController; // 0x20
	public string cid; // 0x28
	public string npcName; // 0x30
	public GameObject selectGameObject; // 0x38
	private SpriteRenderer selectImage; // 0x40
	private static long lastPointerDownTime; // 0x0
	private static Position lastPointerDownMainPosition; // 0x8

	// Methods

	// RVA: 0xE4FD24 Offset: 0xE4BD24 VA: 0xE4FD24
	public void SetupSelectObject(GameObject selectObject) { }

	// RVA: 0xE4FDB0 Offset: 0xE4BDB0 VA: 0xE4FDB0
	public void ChangeSelect(bool selected, Target.Color color) { }

	// RVA: 0xE4FEB0 Offset: 0xE4BEB0 VA: 0xE4FEB0
	public static void NpcPicked(Controller npcController) { }

	// RVA: 0xE4FFF8 Offset: 0xE4BFF8 VA: 0xE4FFF8 Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xE500F8 Offset: 0xE4C0F8 VA: 0xE500F8
	private void OnMouseUp() { }

	// RVA: 0xE50308 Offset: 0xE4C308 VA: 0xE50308
	public void .ctor() { }

	// RVA: 0xE5035C Offset: 0xE4C35C VA: 0xE5035C
	private static void .cctor() { }
}

// Namespace: 
public class ObjectSelect : MonoBehaviour, IPointerDownHandler, IEventSystemHandler // TypeDefIndex: 1739
{
	// Fields
	public Object mapObject; // 0x20
	private static long lastPointerDownTime; // 0x0
	private static Position lastPointerDownMainPosition; // 0x8

	// Methods

	// RVA: 0xE503E4 Offset: 0xE4C3E4 VA: 0xE503E4 Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xE504E4 Offset: 0xE4C4E4 VA: 0xE504E4
	private void OnMouseUp() { }

	// RVA: 0xE506AC Offset: 0xE4C6AC VA: 0xE506AC
	public void .ctor() { }

	// RVA: 0xE506B4 Offset: 0xE4C6B4 VA: 0xE506B4
	private static void .cctor() { }
}

// Namespace: 
public class Chat.ChannelLogField // TypeDefIndex: 1740
{
	// Fields
	public ChatMessage message; // 0x10
	public Item appitem; // 0x18

	// Methods

	// RVA: 0xE52950 Offset: 0xE4E950 VA: 0xE52950
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Chat.<>c // TypeDefIndex: 1741
{
	// Fields
	public static readonly Chat.<>c <>9; // 0x0
	public static Func<Queue<Chat.ChannelLogField>, string, string, bool> <>9__49_0; // 0x8

	// Methods

	// RVA: 0xE533C8 Offset: 0xE4F3C8 VA: 0xE533C8
	private static void .cctor() { }

	// RVA: 0xE53430 Offset: 0xE4F430 VA: 0xE53430
	public void .ctor() { }

	// RVA: 0xE53438 Offset: 0xE4F438 VA: 0xE53438
	internal bool <RemovePlayerLogs>b__49_0(Queue<Chat.ChannelLogField> _storage, string cid, string name) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Chat.<>c__DisplayClass45_0 // TypeDefIndex: 1742
{
	// Fields
	public ChatItemView data; // 0x10
	public Item item; // 0x18

	// Methods

	// RVA: 0xE51C8C Offset: 0xE4DC8C VA: 0xE51C8C
	public void .ctor() { }

	// RVA: 0xE53618 Offset: 0xE4F618 VA: 0xE53618
	internal void <ChatItemViewExisting>b__0() { }

	// RVA: 0xE53684 Offset: 0xE4F684 VA: 0xE53684
	internal void <ChatItemViewExisting>b__1() { }

	// RVA: 0xE53790 Offset: 0xE4F790 VA: 0xE53790
	internal void <ChatItemViewExisting>b__2() { }

	// RVA: 0xE53890 Offset: 0xE4F890 VA: 0xE53890
	internal void <ChatItemViewExisting>b__3() { }
}

// Namespace: 
public class Chat : MonoBehaviour // TypeDefIndex: 1743
{
	// Fields
	public const int MaximumLogSummaryCount = 100;
	public const int MaximumLogStorageCount = 50;
	[SerializeField]
	private RectTransform rectTransform; // 0x20
	[SerializeField]
	private GameObject ContentMessage; // 0x28
	[SerializeField]
	private GameObject childPrefab; // 0x30
	[SerializeField]
	private GameObject ScrollView; // 0x38
	[SerializeField]
	public GameObject phcGo; // 0x40
	[SerializeField]
	public TextMeshProUGUI phcLabelAll; // 0x48
	[SerializeField]
	public Button phcButtonAll; // 0x50
	[SerializeField]
	public TextMeshProUGUI phcLabelPrivate; // 0x58
	[SerializeField]
	public Button phcButtonPrivate; // 0x60
	[SerializeField]
	public TextMeshProUGUI phcLabelTong; // 0x68
	[SerializeField]
	public Button phcButtonTong; // 0x70
	[SerializeField]
	public TextMeshProUGUI phcLabelTeam; // 0x78
	[SerializeField]
	public Button phcButtonTeam; // 0x80
	[SerializeField]
	public TextMeshProUGUI phcLabelOther; // 0x88
	[SerializeField]
	public Button phcButtonOther; // 0x90
	[SerializeField]
	public TextMeshProUGUI phcLabelScroll; // 0x98
	[SerializeField]
	public Button phcButtonScroll; // 0xA0
	[SerializeField]
	public TextMeshProUGUI phcLabelSize; // 0xA8
	[SerializeField]
	public Button phcButtonSize; // 0xB0
	[SerializeField]
	public Image phcSizingTopImage; // 0xB8
	[SerializeField]
	public ManuaMovingSupporting phcSizingTopResize; // 0xC0
	[SerializeField]
	public Image phcSizingBottomImage; // 0xC8
	[SerializeField]
	public ManuaMovingSupporting phcSizingBottomResize; // 0xD0
	private bool hasStarted; // 0xD8
	private readonly Queue<Chat.ChannelLogField> chatmessageOnStarted; // 0xE0
	private RectTransform contentMessageCompRectransform; // 0xE8
	private int channelCurrently; // 0xF0
	private bool isUseSoundEffect; // 0xF4
	private bool isIgnoreExistingMessage; // 0xF5
	private bool isVisible; // 0xF6
	private static readonly Queue<Chat.ChannelLogField> _channelLogsPrivate; // 0x0
	private readonly Dictionary<int, Queue<Chat.ChannelLogField>> channelLogs; // 0xF8

	// Methods

	// RVA: 0xE5073C Offset: 0xE4C73C VA: 0xE5073C
	private void Start() { }

	// RVA: 0xE50E54 Offset: 0xE4CE54 VA: 0xE50E54
	public void PhcSetDefault() { }

	// RVA: 0xE50FE4 Offset: 0xE4CFE4 VA: 0xE50FE4
	private void PhcSwitchSizingMode() { }

	// RVA: 0xE50F00 Offset: 0xE4CF00 VA: 0xE50F00
	private void PhcSwitchHistoryScrollMode() { }

	// RVA: 0xE5116C Offset: 0xE4D16C VA: 0xE5116C
	public void RebuildLayoutOnFirstForcus() { }

	// RVA: 0xE5110C Offset: 0xE4D10C VA: 0xE5110C
	public void SetHistoryMode(bool isScrollMode) { }

	// RVA: 0xE50EA4 Offset: 0xE4CEA4 VA: 0xE50EA4
	public bool IsHistoryScrollMode() { }

	// RVA: 0xE50E38 Offset: 0xE4CE38 VA: 0xE50E38
	public void SetActivePcHistoryChannel(bool enabled) { }

	// RVA: 0xE512F0 Offset: 0xE4D2F0 VA: 0xE512F0
	public void SetHistoryTab(int channel) { }

	// RVA: 0xE518F0 Offset: 0xE4D8F0 VA: 0xE518F0
	public void ChatItemViewNotfound(ChatItemViewFalse message) { }

	// RVA: 0xE519B8 Offset: 0xE4D9B8 VA: 0xE519B8
	public void ChatItemViewExisting(ChatItemView data) { }

	// RVA: 0xE5172C Offset: 0xE4D72C VA: 0xE5172C
	public void RemoveOldChat(int maximumFields) { }

	// RVA: 0xE51C94 Offset: 0xE4DC94 VA: 0xE51C94
	public void RemoveChannelLogs(ChatRemoveLogChannel message) { }

	// RVA: 0xE51F6C Offset: 0xE4DF6C VA: 0xE51F6C
	public void RemoveAllChannelLogs() { }

	// RVA: 0xE51FD4 Offset: 0xE4DFD4 VA: 0xE51FD4
	public void RemovePlayerLogs(ChatRemoveLogPlayerC message) { }

	// RVA: 0xE5229C Offset: 0xE4E29C VA: 0xE5229C
	public void SetEnableSoundEffect(bool enabled) { }

	// RVA: 0xE522A4 Offset: 0xE4E2A4 VA: 0xE522A4
	public void SetEnableIgnoreExistingMessage(bool enabled) { }

	// RVA: 0xE522AC Offset: 0xE4E2AC VA: 0xE522AC
	public void SetVisible(bool visibled) { }

	// RVA: 0xE52308 Offset: 0xE4E308 VA: 0xE52308
	public void AddNewMessage(ChatMessage chat, Item appitem) { }

	// RVA: 0xE52958 Offset: 0xE4E958 VA: 0xE52958
	private void ShowMessageBubble(ChatMessage data) { }

	// RVA: 0xE52A5C Offset: 0xE4EA5C VA: 0xE52A5C
	public void .ctor() { }

	// RVA: 0xE52C50 Offset: 0xE4EC50 VA: 0xE52C50
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xE52CE8 Offset: 0xE4ECE8 VA: 0xE52CE8
	private void <Start>b__35_0() { }

	[CompilerGenerated]
	// RVA: 0xE52D5C Offset: 0xE4ED5C VA: 0xE52D5C
	private void <Start>b__35_1() { }

	[CompilerGenerated]
	// RVA: 0xE52DD0 Offset: 0xE4EDD0 VA: 0xE52DD0
	private void <Start>b__35_2() { }

	[CompilerGenerated]
	// RVA: 0xE52E44 Offset: 0xE4EE44 VA: 0xE52E44
	private void <Start>b__35_3() { }

	[CompilerGenerated]
	// RVA: 0xE52EB8 Offset: 0xE4EEB8 VA: 0xE52EB8
	private void <Start>b__35_4() { }

	[CompilerGenerated]
	// RVA: 0xE52F2C Offset: 0xE4EF2C VA: 0xE52F2C
	private void <Start>b__35_5() { }

	[CompilerGenerated]
	// RVA: 0xE52F9C Offset: 0xE4EF9C VA: 0xE52F9C
	private void <Start>b__35_6() { }

	[CompilerGenerated]
	// RVA: 0xE5300C Offset: 0xE4F00C VA: 0xE5300C
	private void <Start>b__35_7(Vector2 differencePosition) { }

	[CompilerGenerated]
	// RVA: 0xE530B4 Offset: 0xE4F0B4 VA: 0xE530B4
	private void <Start>b__35_8(Vector2 differencePosition) { }

	[CompilerGenerated]
	// RVA: 0xE5315C Offset: 0xE4F15C VA: 0xE5315C
	private void <Start>b__35_9() { }

	[CompilerGenerated]
	// RVA: 0xE53218 Offset: 0xE4F218 VA: 0xE53218
	private void <Start>b__35_11() { }

	[CompilerGenerated]
	// RVA: 0xE532A4 Offset: 0xE4F2A4 VA: 0xE532A4
	private void <Start>b__35_10() { }

	[CompilerGenerated]
	// RVA: 0xE53360 Offset: 0xE4F360 VA: 0xE53360
	private void <Start>b__35_12() { }

	[CompilerGenerated]
	// RVA: 0xE5336C Offset: 0xE4F36C VA: 0xE5336C
	private void <RebuildLayoutOnFirstForcus>b__39_0() { }
}

// Namespace: 
public class ChatButton : MonoBehaviour // TypeDefIndex: 1744
{
	// Fields
	private int NpcId; // 0x20

	// Methods

	// RVA: 0xE53B44 Offset: 0xE4FB44 VA: 0xE53B44
	private void Start() { }

	// RVA: 0xE53B48 Offset: 0xE4FB48 VA: 0xE53B48
	private void OnMouseUp() { }

	// RVA: 0xE53B4C Offset: 0xE4FB4C VA: 0xE53B4C
	public void CallNpc() { }

	// RVA: 0xE53B50 Offset: 0xE4FB50 VA: 0xE53B50
	public void SetNpcId(int id) { }

	// RVA: 0xE53B58 Offset: 0xE4FB58 VA: 0xE53B58
	public void RemoveNpcID() { }

	// RVA: 0xE53B64 Offset: 0xE4FB64 VA: 0xE53B64
	public void .ctor() { }
}

// Namespace: 
public class ChatCategory : MonoBehaviour // TypeDefIndex: 1745
{
	// Fields
	[SerializeField]
	private GameObject categoryName; // 0x20
	[SerializeField]
	private GameObject categoryButton; // 0x28
	[SerializeField]
	private GameObject categoryIcon; // 0x30
	private int channel; // 0x38
	private Sprite spriteType; // 0x40
	[CompilerGenerated]
	private Action<int, Sprite> OnButtonClick; // 0x48

	// Methods

	[CompilerGenerated]
	// RVA: 0xE53B6C Offset: 0xE4FB6C VA: 0xE53B6C
	public void add_OnButtonClick(Action<int, Sprite> value) { }

	[CompilerGenerated]
	// RVA: 0xE53C1C Offset: 0xE4FC1C VA: 0xE53C1C
	public void remove_OnButtonClick(Action<int, Sprite> value) { }

	// RVA: 0xE53CCC Offset: 0xE4FCCC VA: 0xE53CCC
	private void Start() { }

	// RVA: 0xE53DE8 Offset: 0xE4FDE8 VA: 0xE53DE8
	public void HandleSelect(int chatTypeSelect) { }

	// RVA: 0xE53EE0 Offset: 0xE4FEE0 VA: 0xE53EE0
	public void InitCategory(int channel, string name, Sprite icon) { }

	// RVA: 0xE54020 Offset: 0xE50020 VA: 0xE54020
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE54028 Offset: 0xE50028 VA: 0xE54028
	private void <Start>b__8_0() { }

	[CompilerGenerated]
	// RVA: 0xE54050 Offset: 0xE50050 VA: 0xE54050
	private void <Start>b__8_1() { }
}

// Namespace: 
private class ChatInput.ChatLogsHistory // TypeDefIndex: 1746
{
	// Fields
	public GameObject go; // 0x10
	public Button button; // 0x18
	public TextMeshProUGUI text; // 0x20
	public string inputBelow; // 0x28
	public string inputAbove; // 0x30
	public Chat.ItemData itemdata; // 0x38

	// Methods

	// RVA: 0xE554B0 Offset: 0xE514B0 VA: 0xE554B0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ChatInput.<>c__DisplayClass49_0 // TypeDefIndex: 1747
{
	// Fields
	public ChatInput.ChatLogsHistory history; // 0x10
	public ChatInput <>4__this; // 0x18

	// Methods

	// RVA: 0xE55ED4 Offset: 0xE51ED4 VA: 0xE55ED4
	public void .ctor() { }

	// RVA: 0xE57E3C Offset: 0xE53E3C VA: 0xE57E3C
	internal void <TakeHistoryLogs>b__0() { }
}

// Namespace: 
public class ChatInput : BaseMonoBehaviour // TypeDefIndex: 1748
{
	// Fields
	[SerializeField]
	private GameObject PannelMenu; // 0x20
	[SerializeField]
	private GameObject InputParent; // 0x28
	[SerializeField]
	private GameObject InputBelow; // 0x30
	[SerializeField]
	private GameObject InputAbove; // 0x38
	[SerializeField]
	private GameObject ChatSend; // 0x40
	[SerializeField]
	private GameObject pannelHome; // 0x48
	[SerializeField]
	private GameObject ColorPrefab; // 0x50
	[SerializeField]
	private GameObject ColorPanel; // 0x58
	[SerializeField]
	private GameObject ColorList; // 0x60
	[SerializeField]
	private GameObject CategoryPrefab; // 0x68
	[SerializeField]
	private GameObject CategoryList; // 0x70
	[SerializeField]
	private GameObject CategorySelect; // 0x78
	[SerializeField]
	private GameObject CategorySelectIcon; // 0x80
	[SerializeField]
	private GameObject CategoryPanel; // 0x88
	[SerializeField]
	private GameObject HistoryPanel; // 0x90
	[SerializeField]
	private GameObject HistoryList; // 0x98
	[SerializeField]
	private GameObject EmojisPrefab; // 0xA0
	[SerializeField]
	private GameObject EmojisButton; // 0xA8
	[SerializeField]
	private GameObject EmojisPannel; // 0xB0
	[SerializeField]
	private GameObject EmojisList; // 0xB8
	[SerializeField]
	private GameObject chatlogsGo; // 0xC0
	[SerializeField]
	private TextMeshProUGUI chatlogsTitleText; // 0xC8
	[SerializeField]
	private GameObject chatlogsIsEmptyGo; // 0xD0
	[SerializeField]
	private TextMeshProUGUI chatlogsIsEmptyText; // 0xD8
	[SerializeField]
	private GameObject chatlogsHistory1Go; // 0xE0
	[SerializeField]
	private Button chatlogsHistory1Button; // 0xE8
	[SerializeField]
	private TextMeshProUGUI chatlogsHistory1Text; // 0xF0
	[SerializeField]
	private GameObject chatlogsHistory2Go; // 0xF8
	[SerializeField]
	private Button chatlogsHistory2Button; // 0x100
	[SerializeField]
	private TextMeshProUGUI chatlogsHistory2Text; // 0x108
	[SerializeField]
	private GameObject chatlogsHistory3Go; // 0x110
	[SerializeField]
	private Button chatlogsHistory3Button; // 0x118
	[SerializeField]
	private TextMeshProUGUI chatlogsHistory3Text; // 0x120
	[SerializeField]
	private GameObject chatlogsHistory4Go; // 0x128
	[SerializeField]
	private Button chatlogsHistory4Button; // 0x130
	[SerializeField]
	private TextMeshProUGUI chatlogsHistory4Text; // 0x138
	[SerializeField]
	private GameObject chatlogsHistory5Go; // 0x140
	[SerializeField]
	private Button chatlogsHistory5Button; // 0x148
	[SerializeField]
	private TextMeshProUGUI chatlogsHistory5Text; // 0x150
	private int channelCurrently; // 0x158
	private TMP_InputField inputBelowField; // 0x160
	private TMP_InputField inputAboveField; // 0x168
	private Dictionary<int, Sprite> channelSprite; // 0x170
	private bool uiIsDisappear; // 0x178
	private List<ChatInput.ChatLogsHistory> historyList; // 0x180
	private int historyIndex; // 0x188

	// Methods

	// RVA: 0xE54078 Offset: 0xE50078 VA: 0xE54078
	private void Awake() { }

	// RVA: 0xE55558 Offset: 0xE51558 VA: 0xE55558
	private void Start() { }

	// RVA: 0xE55AC8 Offset: 0xE51AC8 VA: 0xE55AC8
	private void TakeHistoryLogs() { }

	// RVA: 0xE55EDC Offset: 0xE51EDC VA: 0xE55EDC
	private void RemoveInputChangedEvent() { }

	// RVA: 0xE55A24 Offset: 0xE51A24 VA: 0xE55A24
	private void AddInputChangedEvent() { }

	// RVA: 0xE55F00 Offset: 0xE51F00 VA: 0xE55F00
	public void SetUIEnabled(bool enabled) { }

	// RVA: 0xE561C4 Offset: 0xE521C4 VA: 0xE561C4
	public bool IsAppearing() { }

	// RVA: 0xE561D4 Offset: 0xE521D4 VA: 0xE561D4
	private void CreateHistory(int channel, string name, Sprite icon, VerticalLayoutGroup verticalLayout) { }

	// RVA: 0xE563F4 Offset: 0xE523F4 VA: 0xE563F4
	private void HandleItemHistoryClick(int channel, Sprite spriteType) { }

	// RVA: 0xE54B98 Offset: 0xE50B98 VA: 0xE54B98
	private void InitHistory() { }

	// RVA: 0xE544B0 Offset: 0xE504B0 VA: 0xE544B0
	private void InitCategory() { }

	// RVA: 0xE56508 Offset: 0xE52508 VA: 0xE56508
	private void CreateCategory(int channel, string name, Sprite icon, VerticalLayoutGroup verticalLayout) { }

	// RVA: 0xE56778 Offset: 0xE52778 VA: 0xE56778
	private void HandleItemCategoryClick(int channel, Sprite spriteType) { }

	// RVA: 0xE56AA8 Offset: 0xE52AA8 VA: 0xE56AA8
	public void SetChannel(int channel) { }

	// RVA: 0xE55128 Offset: 0xE51128 VA: 0xE55128
	private void InitEmojis() { }

	// RVA: 0xE56D08 Offset: 0xE52D08 VA: 0xE56D08
	private void HandleItemEmojiClick(string emoji) { }

	// RVA: 0xE56E34 Offset: 0xE52E34 VA: 0xE56E34
	public void InputClick(bool focusInputField) { }

	// RVA: 0xE56E74 Offset: 0xE52E74 VA: 0xE56E74
	public void InputOpen(bool enabled, bool focusInputField) { }

	// RVA: 0xE56EE0 Offset: 0xE52EE0 VA: 0xE56EE0
	public void InputAppend(Item item, string autoreplay) { }

	// RVA: 0xE5701C Offset: 0xE5301C VA: 0xE5701C
	public void InputPrivate(string receiveName, string receiveCid) { }

	// RVA: 0xE57130 Offset: 0xE53130 VA: 0xE57130
	public string[] GetSendData() { }

	// RVA: 0xE571A8 Offset: 0xE531A8 VA: 0xE571A8
	private void SendMessage() { }

	// RVA: 0xE573E0 Offset: 0xE533E0 VA: 0xE573E0
	private bool IsBil4i3nCommand(string text) { }

	// RVA: 0xE57AF0 Offset: 0xE53AF0 VA: 0xE57AF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE57B80 Offset: 0xE53B80 VA: 0xE57B80
	private void <Start>b__48_0() { }

	[CompilerGenerated]
	// RVA: 0xE57B98 Offset: 0xE53B98 VA: 0xE57B98
	private void <Start>b__48_1() { }

	[CompilerGenerated]
	// RVA: 0xE57CDC Offset: 0xE53CDC VA: 0xE57CDC
	private void <Start>b__48_2() { }

	[CompilerGenerated]
	// RVA: 0xE57DA8 Offset: 0xE53DA8 VA: 0xE57DA8
	private void <AddInputChangedEvent>b__51_0(string value) { }
}

// Namespace: 
public class ChatMessageOutside : MonoBehaviour, IPointerClickHandler, IEventSystemHandler // TypeDefIndex: 1749
{
	// Fields
	[SerializeField]
	private TextMeshProUGUI contentTmp; // 0x20
	private ChatMessage message; // 0x28
	private Item appitem; // 0x30

	// Methods

	// RVA: 0xE51808 Offset: 0xE4D808 VA: 0xE51808
	public void SetFieldData(ChatMessage message, Item appitem) { }

	// RVA: 0xE57F60 Offset: 0xE53F60 VA: 0xE57F60 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0xE5861C Offset: 0xE5461C VA: 0xE5861C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE58624 Offset: 0xE54624 VA: 0xE58624
	private void <OnPointerClick>b__4_0() { }

	[CompilerGenerated]
	// RVA: 0xE58690 Offset: 0xE54690 VA: 0xE58690
	private void <OnPointerClick>b__4_1() { }
}

// Namespace: 
public class ChatMessageScrollView : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler // TypeDefIndex: 1750
{
	// Fields
	[SerializeField]
	private ScrollRect scrollRect; // 0x20
	private VariableJoystick joystick; // 0x28
	private int joystickOnMoving; // 0x30
	private bool allowScrollMovement; // 0x34

	// Methods

	// RVA: 0xE58718 Offset: 0xE54718 VA: 0xE58718
	private void Awake() { }

	// RVA: 0xE58738 Offset: 0xE54738 VA: 0xE58738
	public bool IsScrolling() { }

	// RVA: 0xE58740 Offset: 0xE54740 VA: 0xE58740
	private VariableJoystick Joystick() { }

	// RVA: 0xE512BC Offset: 0xE4D2BC VA: 0xE512BC
	public void AllowScrollMovement(bool enabled) { }

	// RVA: 0xE587EC Offset: 0xE547EC VA: 0xE587EC
	public void ScrollVerticalNormalizedPosition(float value) { }

	// RVA: 0xE58804 Offset: 0xE54804 VA: 0xE58804 Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xE58B90 Offset: 0xE54B90 VA: 0xE58B90 Slot: 5
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xE58BD0 Offset: 0xE54BD0 VA: 0xE58BD0 Slot: 6
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xE58C14 Offset: 0xE54C14 VA: 0xE58C14
	public void .ctor() { }
}

// Namespace: 
public class EmojisItem : MonoBehaviour // TypeDefIndex: 1751
{
	// Fields
	[CompilerGenerated]
	private Action<string> OnButtonClick; // 0x20
	private string emoji; // 0x28

	// Methods

	[CompilerGenerated]
	// RVA: 0xE56C58 Offset: 0xE52C58 VA: 0xE56C58
	public void add_OnButtonClick(Action<string> value) { }

	[CompilerGenerated]
	// RVA: 0xE58C24 Offset: 0xE54C24 VA: 0xE58C24
	public void remove_OnButtonClick(Action<string> value) { }

	// RVA: 0xE58CD4 Offset: 0xE54CD4 VA: 0xE58CD4
	private void Start() { }

	// RVA: 0xE56B44 Offset: 0xE52B44 VA: 0xE56B44
	public void SetPattern(string newEmoji) { }

	// RVA: 0xE58D8C Offset: 0xE54D8C VA: 0xE58D8C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE58DE4 Offset: 0xE54DE4 VA: 0xE58DE4
	private void <Start>b__4_0() { }
}

// Namespace: 
public class PlayerDie : MonoBehaviour // TypeDefIndex: 1752
{
	// Fields
	[SerializeField]
	private Image framedImage; // 0x20
	[SerializeField]
	private TextMeshProUGUI tmpContent; // 0x28
	[SerializeField]
	private Button button; // 0x30

	// Methods

	// RVA: 0xE58E04 Offset: 0xE54E04 VA: 0xE58E04
	private void Start() { }

	// RVA: 0xE58EEC Offset: 0xE54EEC VA: 0xE58EEC
	public void Open() { }

	// RVA: 0xE58F70 Offset: 0xE54F70 VA: 0xE58F70
	public void Close() { }

	// RVA: 0xE58FFC Offset: 0xE54FFC VA: 0xE58FFC
	public void .ctor() { }
}

// Namespace: 
public class MainCanvas : MonoBehaviour // TypeDefIndex: 1753
{
	// Fields
	[SerializeField]
	public World world; // 0x20
	[SerializeField]
	public GameObject mainUserInterface; // 0x28
	[SerializeField]
	public RectTransform mainUserInterfaceRect; // 0x30
	[SerializeField]
	public GameObject mainSafeArea; // 0x38
	[SerializeField]
	public RectTransform mainSafeAreaRect; // 0x40
	public TopRightButtons toprightButtons; // 0x48
	private GameObject VariableJoystickUI; // 0x50
	public QuestTeamChat questTeamChat; // 0x58
	public MinistateFramed ministate; // 0x60
	public RightHotkey rightHotkey; // 0x68
	public TopHealth topHealth; // 0x70
	public PlayerSelfProperties playerSelfProperties; // 0x78
	public PlayerSelfPropertiesText playerSelfPropertiesText; // 0x80
	public PlayerSelfBagarate playerSelfBagarate; // 0x88
	public PlayerSelfStorage playerSelfStorage; // 0x90
	public PlayerSelfStorageExtension playerSelfStorageExtension; // 0x98
	public PlayerSelfEquipmentSeriers playerSelfEquipmentSeries; // 0xA0
	public PlayerSelfSalesman playerSelfSalesman; // 0xA8
	public PlayerSelfSalesmanPricing playerSelfSalesmanPricing; // 0xB0
	public PlayerSelfSkill playerSelfSkill; // 0xB8
	public PlayerSelfPropPoint playerSelfPropPoint; // 0xC0
	public PlayerSelfChoision playerSelfChoision; // 0xC8
	public PlayerSelfSkillDirection playerSelfSkillDirection; // 0xD0
	public FriendlyList friendlyList; // 0xD8
	public static MainCanvas instance; // 0x0
	private VariableJoystick variableJoystickHandle; // 0xE0
	private readonly Queue<Action> onStarted; // 0xE8

	// Methods

	// RVA: 0xE59004 Offset: 0xE55004 VA: 0xE59004
	public void Initialize() { }

	// RVA: 0xE5908C Offset: 0xE5508C VA: 0xE5908C
	private void LoadUIFormAsset() { }

	// RVA: 0xE59DC0 Offset: 0xE55DC0 VA: 0xE59DC0
	public void PerformOnStarted(Action action) { }

	// RVA: 0xE4F7DC Offset: 0xE4B7DC VA: 0xE4F7DC
	public VariableJoystick GetJoystick() { }

	// RVA: 0xE59E18 Offset: 0xE55E18 VA: 0xE59E18
	public void CloseOtherSelfUi() { }

	// RVA: 0xE5A0E4 Offset: 0xE560E4 VA: 0xE5A0E4
	public void ShowoffBagarate() { }

	// RVA: 0xE5A1BC Offset: 0xE561BC VA: 0xE5A1BC
	public void FightMode(int fightMode) { }

	// RVA: 0xE5A250 Offset: 0xE56250 VA: 0xE5A250
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ActionSp.<>c // TypeDefIndex: 1754
{
	// Fields
	public static readonly ActionSp.<>c <>9; // 0x0
	public static UnityAction <>9__16_1; // 0x8
	public static UnityAction <>9__16_2; // 0x10
	public static UnityAction <>9__16_3; // 0x18
	public static UnityAction <>9__16_4; // 0x20
	public static UnityAction <>9__16_5; // 0x28

	// Methods

	// RVA: 0xE5AAAC Offset: 0xE56AAC VA: 0xE5AAAC
	private static void .cctor() { }

	// RVA: 0xE5AB14 Offset: 0xE56B14 VA: 0xE5AB14
	public void .ctor() { }

	// RVA: 0xE5AB1C Offset: 0xE56B1C VA: 0xE5AB1C
	internal void <Start>b__16_1() { }

	// RVA: 0xE5ABBC Offset: 0xE56BBC VA: 0xE5ABBC
	internal void <Start>b__16_2() { }

	// RVA: 0xE5AC50 Offset: 0xE56C50 VA: 0xE5AC50
	internal void <Start>b__16_3() { }

	// RVA: 0xE5ACF0 Offset: 0xE56CF0 VA: 0xE5ACF0
	internal void <Start>b__16_4() { }

	// RVA: 0xE5AD90 Offset: 0xE56D90 VA: 0xE5AD90
	internal void <Start>b__16_5() { }
}

// Namespace: 
public class ActionSp : MonoBehaviour // TypeDefIndex: 1755
{
	// Fields
	private static Vector2 pingFpsPositionOrigin; // 0x0
	private static Vector2 pingFpsPositionWithMinistateOnTop; // 0x8
	[SerializeField]
	private GameObject ButtonSwitchHorse; // 0x20
	[SerializeField]
	public GameObject ButtonRun; // 0x28
	[SerializeField]
	public GameObject BtnMoveToTower; // 0x30
	[SerializeField]
	public GameObject BtnMeditate; // 0x38
	[SerializeField]
	private RectTransform pingFpsRect; // 0x40
	[SerializeField]
	private TextMeshProUGUI pingTextmesh; // 0x48
	[SerializeField]
	private TextMeshProUGUI fpsTextmesh; // 0x50
	[SerializeField]
	public Button FriendlyListButton; // 0x58
	[SerializeField]
	public Button icon18Button; // 0x60
	[SerializeField]
	public GameObject icon18FramedGo; // 0x68
	[SerializeField]
	private Image icon18FramedImage; // 0x70
	[SerializeField]
	private TextMeshProUGUI icon18ContentText; // 0x78
	private int icon18FramedLiveSecondsRemaining; // 0x80
	private int icon18FramedHiddenSecondsRemaining; // 0x84

	// Methods

	// RVA: 0xE5A2D8 Offset: 0xE562D8 VA: 0xE5A2D8
	private void Start() { }

	// RVA: 0xE5A810 Offset: 0xE56810 VA: 0xE5A810
	private void Update() { }

	// RVA: 0xE560E8 Offset: 0xE520E8 VA: 0xE560E8
	public void SetGroupVisible(bool enable) { }

	// RVA: 0xE5A96C Offset: 0xE5696C VA: 0xE5A96C
	public void .ctor() { }

	// RVA: 0xE5A974 Offset: 0xE56974 VA: 0xE5A974
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xE5A9D8 Offset: 0xE569D8 VA: 0xE5A9D8
	private void <Start>b__16_0() { }
}

// Namespace: 
public class AutoRadius : MonoBehaviour // TypeDefIndex: 1756
{
	// Fields
	[SerializeField]
	private LineRenderer lineRenderer; // 0x20
	private static readonly Color circleColor; // 0x0

	// Methods

	// RVA: 0xE5AE88 Offset: 0xE56E88 VA: 0xE5AE88
	private void Start() { }

	// RVA: 0xE5AF10 Offset: 0xE56F10 VA: 0xE5AF10
	public void DrawCircle(float radius, float lineWidth) { }

	// RVA: 0xE5B0D8 Offset: 0xE570D8 VA: 0xE5B0D8
	public void .ctor() { }

	// RVA: 0xE5B0E0 Offset: 0xE570E0 VA: 0xE5B0E0
	private static void .cctor() { }
}

// Namespace: 
public class AutoScrollText : MonoBehaviour // TypeDefIndex: 1757
{
	// Fields
	public float scrollSpeed; // 0x20
	public float deltaTimePerCharacter; // 0x24
	public float deltaTimeMinimum; // 0x28
	private float endPositionX; // 0x2C
	private float remaningTime; // 0x30

	// Methods

	// RVA: 0xE5B130 Offset: 0xE57130 VA: 0xE5B130
	public void SetUpText(string text) { }

	// RVA: 0xE5B308 Offset: 0xE57308 VA: 0xE5B308
	private void Update() { }

	// RVA: 0xE5B544 Offset: 0xE57544 VA: 0xE5B544
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PopUpCanvas.<>c // TypeDefIndex: 1758
{
	// Fields
	public static readonly PopUpCanvas.<>c <>9; // 0x0
	public static Comparison<OrderLayer.Data> <>9__43_0; // 0x8
	public static PlayerSelfSettings.VariationsChangeCallback <>9__64_5; // 0x10
	public static PlayerSelfSettings.VibrateVolumeChangeCallback <>9__64_6; // 0x18
	public static PlayerSelfSettings.RenderChangeCallback <>9__64_7; // 0x20
	public static PlayerSelfSettings.RenderChangeNumberCallback <>9__64_8; // 0x28

	// Methods

	// RVA: 0xE5E958 Offset: 0xE5A958 VA: 0xE5E958
	private static void .cctor() { }

	// RVA: 0xE5E9C0 Offset: 0xE5A9C0 VA: 0xE5E9C0
	public void .ctor() { }

	// RVA: 0xE5E9C8 Offset: 0xE5A9C8 VA: 0xE5E9C8
	internal int <OrderAllLayer>b__43_0(OrderLayer.Data a, OrderLayer.Data b) { }

	// RVA: 0xE5E9EC Offset: 0xE5A9EC VA: 0xE5E9EC
	internal void <SetupCallback>b__64_5(string type, bool value) { }

	// RVA: 0xE5EB70 Offset: 0xE5AB70 VA: 0xE5EB70
	internal void <SetupCallback>b__64_6(string type, bool value) { }

	// RVA: 0xE5EC9C Offset: 0xE5AC9C VA: 0xE5EC9C
	internal void <SetupCallback>b__64_7(string type, bool value) { }

	// RVA: 0xE5EDA4 Offset: 0xE5ADA4 VA: 0xE5EDA4
	internal void <SetupCallback>b__64_8(int value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PopUpCanvas.<>c__DisplayClass46_0 // TypeDefIndex: 1759
{
	// Fields
	public AskClientForString askClientForString; // 0x10

	// Methods

	// RVA: 0xE5DD0C Offset: 0xE59D0C VA: 0xE5DD0C
	public void .ctor() { }

	// RVA: 0xE5EE0C Offset: 0xE5AE0C VA: 0xE5EE0C
	internal void <OpenInputAnswer>b__0(string _value) { }
}

// Namespace: 
public class PopUpCanvas : MonoBehaviour // TypeDefIndex: 1760
{
	// Fields
	[SerializeField]
	public World world; // 0x20
	[SerializeField]
	public GameObject mainUserInterface; // 0x28
	[SerializeField]
	public GameObject mainSafeArea; // 0x30
	public MiniMap miniMap; // 0x38
	public ChatInput OpenChat; // 0x40
	public DisconnectMessage disconnectMessage; // 0x48
	private GameObject PlayerDieMessage; // 0x50
	public LocalNews localNews; // 0x58
	public ActionSp bottomLeftGroup; // 0x60
	private UiContextDescription contextDescription; // 0x68
	private EnvelopListing envelopListing; // 0x70
	public ActivitiesListPc activitiesListPc; // 0x78
	public DenyMoving denyMoving; // 0x80
	public PlayerOtherEquipment playerOtherEquipment; // 0x88
	public PlayerTalk playerTalk; // 0x90
	public HomeSkillDirectionTargetList homeSkillDirectionTargetList; // 0x98
	public HomeTouchTargetList homeTouchTargetList; // 0xA0
	public PlayerOtherStall playerOtherStall; // 0xA8
	public MiniMapZoomPC miniMapZoomPC; // 0xB0
	public ItemDetailPc itemDetailPc; // 0xB8
	public NpcMoneyShop npcMoneyShop; // 0xC0
	public NpcKnbShop npcKnbShop; // 0xC8
	public WorldRankPc worldRankPc; // 0xD0
	public GiveItem giveItem; // 0xD8
	public StandardInputPc standardInputPc; // 0xE0
	public StandardConfirmPc standardConfirmPc; // 0xE8
	public UnMergeItemPc unMergeItemPc; // 0xF0
	public ShareItemAutoreplyPC shareItemAutoreplyPC; // 0xF8
	public HotkeyAssignment hotkeyAssignment; // 0x100
	public PartyInvitePc partyInvitePc; // 0x108
	public NotificationPc notificationPc; // 0x110
	public PlayerTradePc playerTradePc; // 0x118
	public TongPc bangHoiPc; // 0x120
	public NpcDialogPc npcDialogPc; // 0x128
	public NpcDialog10Pc npcDialog10Pc; // 0x130
	public NpcDialogInfiPc npcDialogInfiPc; // 0x138
	public PlayerSelfSettings playerSelfSettings; // 0x140
	public NpcPointShop npcPointShop; // 0x148
	public ManualLayout manualLayout; // 0x150
	public UnityAutoplay autoplay; // 0x158
	public AwardSelection awardSelection; // 0x160
	public static PopUpCanvas instance; // 0x0

	// Methods

	// RVA: 0xE5B560 Offset: 0xE57560 VA: 0xE5B560
	public void Initialize() { }

	// RVA: 0xE5D2DC Offset: 0xE592DC VA: 0xE5D2DC
	public void OrderAllLayer() { }

	// RVA: 0xE5DBE4 Offset: 0xE59BE4 VA: 0xE5DBE4
	public void SetPingFpsPositionOrigin() { }

	// RVA: 0xE5DBE8 Offset: 0xE59BE8 VA: 0xE5DBE8
	public void SetPingFpsPositionWithMinistateOnTop() { }

	// RVA: 0xE5DBEC Offset: 0xE59BEC VA: 0xE5DBEC
	public void OpenInputAnswer(AskClientForString askClientForString) { }

	// RVA: 0xE5DD14 Offset: 0xE59D14 VA: 0xE5DD14
	public void OpenRank() { }

	// RVA: 0xE5DDAC Offset: 0xE59DAC VA: 0xE5DDAC
	public void OpenPointSetting() { }

	// RVA: 0xE5DE44 Offset: 0xE59E44 VA: 0xE5DE44
	public void OpenContextDescription(ContextDescription contextDescription) { }

	// RVA: 0xE5DEDC Offset: 0xE59EDC VA: 0xE5DEDC
	public void EnvelopAdd(EnvelopersAdd add) { }

	// RVA: 0xE5DF74 Offset: 0xE59F74 VA: 0xE5DF74
	public void EnvelopOpenned(EnvelopersOpenned message) { }

	// RVA: 0xE5E00C Offset: 0xE5A00C VA: 0xE5E00C
	public void ActivitiesListOpen(ActivitiesListData data) { }

	// RVA: 0xE5E024 Offset: 0xE5A024 VA: 0xE5E024
	public void OpenPlayerDieMessage() { }

	// RVA: 0xE4ED0C Offset: 0xE4AD0C VA: 0xE4ED0C
	public void PlayerTalk(string message) { }

	// RVA: 0xE5E0C4 Offset: 0xE5A0C4 VA: 0xE5E0C4
	public void OpenTrade(TradeStart message) { }

	// RVA: 0xE5E1F0 Offset: 0xE5A1F0 VA: 0xE5E1F0
	public void ChatInputClick(bool focusInputField) { }

	// RVA: 0xE53818 Offset: 0xE4F818 VA: 0xE53818
	public void ChatInputOpen(bool enabled, bool focusInputField) { }

	// RVA: 0xE5E274 Offset: 0xE5A274 VA: 0xE5E274
	public void ChatInputAppend(Item item, string autoreplay, bool focusInputField) { }

	// RVA: 0xE53834 Offset: 0xE4F834 VA: 0xE53834
	public void ChatInputPrivate(string receiveName, string receiveCid, bool inputForcus) { }

	// RVA: 0xE5E2B0 Offset: 0xE5A2B0 VA: 0xE5E2B0
	public string[] ChatGetCurrentSendData() { }

	// RVA: 0xE5E2C4 Offset: 0xE5A2C4 VA: 0xE5E2C4
	public void ChatForcusTarget(string cid, string name, bool inputFocus) { }

	// RVA: 0xE5E2D4 Offset: 0xE5A2D4 VA: 0xE5E2D4
	public void OpenHotKeySelect(Item item) { }

	// RVA: 0xE5E338 Offset: 0xE5A338 VA: 0xE5E338
	public void OpenUnMergerItem(Item item) { }

	// RVA: 0xE5CE28 Offset: 0xE58E28 VA: 0xE5CE28
	private void SetupCallback() { }

	// RVA: 0xE5E350 Offset: 0xE5A350 VA: 0xE5E350
	public void SetVibrateEnable(string key, bool value) { }

	// RVA: 0xE5E36C Offset: 0xE5A36C VA: 0xE5E36C
	public void SetLimitNpcRenderType(string key, bool value) { }

	// RVA: 0xE5E388 Offset: 0xE5A388 VA: 0xE5E388
	public void SetVibrateLevel(Vibration.Level level) { }

	// RVA: 0xE5E444 Offset: 0xE5A444 VA: 0xE5E444
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE5E44C Offset: 0xE5A44C VA: 0xE5E44C
	private void <SetupCallback>b__64_0(float value) { }

	[CompilerGenerated]
	// RVA: 0xE5E464 Offset: 0xE5A464 VA: 0xE5E464
	private void <SetupCallback>b__64_1(int value) { }

	[CompilerGenerated]
	// RVA: 0xE5E47C Offset: 0xE5A47C VA: 0xE5E47C
	private void <SetupCallback>b__64_2(string typename) { }

	[CompilerGenerated]
	// RVA: 0xE5E494 Offset: 0xE5A494 VA: 0xE5E494
	private void <SetupCallback>b__64_3(string type, bool value) { }

	[CompilerGenerated]
	// RVA: 0xE5E768 Offset: 0xE5A768 VA: 0xE5E768
	private void <SetupCallback>b__64_4(string type, bool value) { }
}

// Namespace: 
internal enum PartyType // TypeDefIndex: 1761
{
	// Fields
	public int value__; // 0x0
	public const PartyType Free = 0;
	public const PartyType Private = 1;
}

// Namespace: 
public class CreateParty : MonoBehaviour // TypeDefIndex: 1762
{
	// Fields
	[SerializeField]
	private GameObject BtnCancel; // 0x20
	[SerializeField]
	private GameObject BtnAccept; // 0x28
	[SerializeField]
	private GameObject FreeParty; // 0x30
	[SerializeField]
	private GameObject PrivateParty; // 0x38
	[SerializeField]
	private TextMeshProUGUI tmproCreateFieldFree; // 0x40
	[SerializeField]
	private TextMeshProUGUI tmproCreateFieldPrivate; // 0x48
	[SerializeField]
	private TextMeshProUGUI tmproCreateButtonCancel; // 0x50
	[SerializeField]
	private TextMeshProUGUI tmproCreateButtonAgree; // 0x58
	[SerializeField]
	private Image image1; // 0x60
	[SerializeField]
	private Image image2; // 0x68
	[SerializeField]
	private Image image3; // 0x70
	[SerializeField]
	private Image image4; // 0x78
	[SerializeField]
	private Image image5; // 0x80
	[SerializeField]
	private Image image6; // 0x88
	private PartyType partyType; // 0x90

	// Methods

	// RVA: 0xE5EEC8 Offset: 0xE5AEC8 VA: 0xE5EEC8
	private void Start() { }

	// RVA: 0xE5F390 Offset: 0xE5B390 VA: 0xE5F390
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE5F398 Offset: 0xE5B398 VA: 0xE5F398
	private void <Start>b__15_0() { }

	[CompilerGenerated]
	// RVA: 0xE5F41C Offset: 0xE5B41C VA: 0xE5F41C
	private void <Start>b__15_1() { }

	[CompilerGenerated]
	// RVA: 0xE5F50C Offset: 0xE5B50C VA: 0xE5F50C
	private void <Start>b__15_2(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xE5F57C Offset: 0xE5B57C VA: 0xE5F57C
	private void <Start>b__15_3(bool isOn) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Party.<>c // TypeDefIndex: 1763
{
	// Fields
	public static readonly Party.<>c <>9; // 0x0
	public static UnityAction <>9__20_0; // 0x8
	public static UnityAction <>9__20_2; // 0x10

	// Methods

	// RVA: 0xE61E34 Offset: 0xE5DE34 VA: 0xE61E34
	private static void .cctor() { }

	// RVA: 0xE61E9C Offset: 0xE5DE9C VA: 0xE61E9C
	public void .ctor() { }

	// RVA: 0xE61EA4 Offset: 0xE5DEA4 VA: 0xE61EA4
	internal void <Start>b__20_0() { }

	// RVA: 0xE61F3C Offset: 0xE5DF3C VA: 0xE61F3C
	internal void <Start>b__20_2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Party.<>c__DisplayClass33_0 // TypeDefIndex: 1764
{
	// Fields
	public KeyValuePair<string, PartyJoin> memberEntry; // 0x10
	public Party <>4__this; // 0x20

	// Methods

	// RVA: 0xE61684 Offset: 0xE5D684 VA: 0xE61684
	public void .ctor() { }

	// RVA: 0xE61FD4 Offset: 0xE5DFD4 VA: 0xE61FD4
	internal void <RenderMemberList>b__0() { }
}

// Namespace: 
public class Party : MonoBehaviour // TypeDefIndex: 1765
{
	// Fields
	[SerializeField]
	private GameObject ActionList; // 0x20
	[SerializeField]
	private GameObject ListMember; // 0x28
	[SerializeField]
	private GameObject PanelMember; // 0x30
	[SerializeField]
	private GameObject PlayerParty; // 0x38
	[SerializeField]
	private Button addMemberButton; // 0x40
	[SerializeField]
	private TextMeshProUGUI addMemberTmpro; // 0x48
	[SerializeField]
	private GameObject CreatePlayerParty; // 0x50
	[SerializeField]
	private GameObject FindPartyNears; // 0x58
	[SerializeField]
	private GameObject CreateParty; // 0x60
	[SerializeField]
	private GameObject BtnInfor; // 0x68
	[SerializeField]
	private GameObject BtnClose; // 0x70
	[SerializeField]
	private GameObject BtnLeave; // 0x78
	[SerializeField]
	private GameObject BtnKick; // 0x80
	[SerializeField]
	private GameObject BtnChange; // 0x88
	[SerializeField]
	private GameObject PannelAciton; // 0x90
	[SerializeField]
	private GameObject ListAciton; // 0x98
	[SerializeField]
	private TextMeshProUGUI tmproCreateButton; // 0xA0
	[SerializeField]
	private TextMeshProUGUI tmproNearButton; // 0xA8
	private string CidSelect; // 0xB0
	private readonly Dictionary<string, PlayerParty> memberMapping; // 0xB8

	// Methods

	// RVA: 0xE5F5F0 Offset: 0xE5B5F0 VA: 0xE5F5F0
	private void Start() { }

	// RVA: 0xE5FC28 Offset: 0xE5BC28 VA: 0xE5FC28
	private void ShowListAction(Transform transform) { }

	// RVA: 0xE5FED0 Offset: 0xE5BED0 VA: 0xE5FED0
	private void ShowInfor(string cidSelect) { }

	// RVA: 0xE60010 Offset: 0xE5C010 VA: 0xE60010
	private void LeaveParty(string cidSelect) { }

	// RVA: 0xE60180 Offset: 0xE5C180 VA: 0xE60180
	private void KickParty(string cidSelect) { }

	// RVA: 0xE6033C Offset: 0xE5C33C VA: 0xE6033C
	private void ChangeParty(string cidSelect) { }

	// RVA: 0xE5FFA4 Offset: 0xE5BFA4 VA: 0xE5FFA4
	private void ClosePartyAction() { }

	// RVA: 0xE606A0 Offset: 0xE5C6A0 VA: 0xE606A0
	public void Clear() { }

	// RVA: 0xE60984 Offset: 0xE5C984 VA: 0xE60984
	private void PartyOut(PartyOut message) { }

	// RVA: 0xE61314 Offset: 0xE5D314 VA: 0xE61314
	private void PartyCaption(PartyCaptain message) { }

	// RVA: 0xE614D8 Offset: 0xE5D4D8 VA: 0xE614D8
	private void PartyJoin(PartyJoin message) { }

	// RVA: 0xE5FBE0 Offset: 0xE5BBE0 VA: 0xE5FBE0
	private void UIParty(bool isPartyOn) { }

	// RVA: 0xE607DC Offset: 0xE5C7DC VA: 0xE607DC
	private void DestroyAllMemberFields() { }

	// RVA: 0xE60CC0 Offset: 0xE5CCC0 VA: 0xE60CC0
	private void RenderMemberList() { }

	// RVA: 0xE604F8 Offset: 0xE5C4F8 VA: 0xE604F8
	private void UISelectPlayer() { }

	// RVA: 0xE61944 Offset: 0xE5D944 VA: 0xE61944
	private void PartySync(string cid, int HpPercent) { }

	// RVA: 0xE61AA4 Offset: 0xE5DAA4 VA: 0xE61AA4
	public void ProtocolPartySync(PartySync message) { }

	// RVA: 0xE61AC0 Offset: 0xE5DAC0 VA: 0xE61AC0
	public void ProtocolPartyCaptain(PartyCaptain message) { }

	// RVA: 0xE61AC4 Offset: 0xE5DAC4 VA: 0xE61AC4
	public void ProtocolPartyJoin(PartyJoin message) { }

	// RVA: 0xE61AC8 Offset: 0xE5DAC8 VA: 0xE61AC8
	public void ProtocolPartyOut(PartyOut message) { }

	// RVA: 0xE61ACC Offset: 0xE5DACC VA: 0xE61ACC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE61B78 Offset: 0xE5DB78 VA: 0xE61B78
	private void <Start>b__20_1() { }

	[CompilerGenerated]
	// RVA: 0xE61BF4 Offset: 0xE5DBF4 VA: 0xE61BF4
	private void <Start>b__20_3() { }

	[CompilerGenerated]
	// RVA: 0xE61C68 Offset: 0xE5DC68 VA: 0xE61C68
	private void <Start>b__20_4() { }

	[CompilerGenerated]
	// RVA: 0xE61CDC Offset: 0xE5DCDC VA: 0xE61CDC
	private void <Start>b__20_5() { }

	[CompilerGenerated]
	// RVA: 0xE61D50 Offset: 0xE5DD50 VA: 0xE61D50
	private void <Start>b__20_6() { }

	[CompilerGenerated]
	// RVA: 0xE61DC4 Offset: 0xE5DDC4 VA: 0xE61DC4
	private void <Start>b__20_7() { }
}

// Namespace: 
public class PlayerParty : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler // TypeDefIndex: 1766
{
	// Fields
	[SerializeField]
	private GameObject playerName; // 0x20
	[SerializeField]
	private GameObject playerLevel; // 0x28
	[SerializeField]
	private GameObject playerMempai; // 0x30
	[SerializeField]
	public Slider SliderLife; // 0x38
	[SerializeField]
	public GameObject PartyLead; // 0x40
	public Button button; // 0x48
	public Action onClick; // 0x50
	[SerializeField]
	private TextMeshProUGUI tmproPlayerLevel; // 0x58
	[SerializeField]
	private TextMeshProUGUI tmproPlayerName; // 0x60
	private VariableJoystick joystick; // 0x68
	private int joystickOnMoving; // 0x70
	private PartyJoin PartyPlayer; // 0x78

	// Methods

	// RVA: 0xE6209C Offset: 0xE5E09C VA: 0xE6209C
	private void Start() { }

	// RVA: 0xE6212C Offset: 0xE5E12C VA: 0xE6212C
	private VariableJoystick Joystick() { }

	// RVA: 0xE61854 Offset: 0xE5D854 VA: 0xE61854
	public string GetPartyPlayerCID() { }

	// RVA: 0xE61838 Offset: 0xE5D838 VA: 0xE61838
	public void SetLead(bool isShowLead) { }

	// RVA: 0xE618A8 Offset: 0xE5D8A8 VA: 0xE618A8
	public void ShowSelect(bool isShow) { }

	// RVA: 0xE621D8 Offset: 0xE5E1D8 VA: 0xE621D8
	private void SetMemPai(int sect) { }

	// RVA: 0xE62278 Offset: 0xE5E278 VA: 0xE62278
	public void SyncLife(int CurLife, int MaxLife) { }

	// RVA: 0xE61A80 Offset: 0xE5DA80 VA: 0xE61A80
	public void SyncLifePercent(int HPPercent) { }

	// RVA: 0xE622C4 Offset: 0xE5E2C4 VA: 0xE622C4
	public float CalculatePercentage(int current, int Max) { }

	// RVA: 0xE6168C Offset: 0xE5D68C VA: 0xE6168C
	public void ShowInforMemberParty(PartyJoin player) { }

	// RVA: 0xE622E8 Offset: 0xE5E2E8 VA: 0xE622E8 Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xE6266C Offset: 0xE5E66C VA: 0xE6266C Slot: 5
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xE626AC Offset: 0xE5E6AC VA: 0xE626AC Slot: 6
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xE626F0 Offset: 0xE5E6F0 VA: 0xE626F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE62700 Offset: 0xE5E700 VA: 0xE62700
	private void <Start>b__12_0() { }
}

// Namespace: 
public class Quest.ItemData // TypeDefIndex: 1767
{
	// Fields
	public GameObject goCurrent; // 0x10
	public QuestItem handle; // 0x18

	// Methods

	// RVA: 0xF33B6C Offset: 0xF2FB6C VA: 0xF33B6C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Quest.<>c // TypeDefIndex: 1768
{
	// Fields
	public static readonly Quest.<>c <>9; // 0x0
	public static Comparison<KeyValuePair<string, long>> <>9__17_0; // 0x8

	// Methods

	// RVA: 0xF33B74 Offset: 0xF2FB74 VA: 0xF33B74
	private static void .cctor() { }

	// RVA: 0xF33BDC Offset: 0xF2FBDC VA: 0xF33BDC
	public void .ctor() { }

	// RVA: 0xF33BE4 Offset: 0xF2FBE4 VA: 0xF33BE4
	internal int <CalcNextTime>b__17_0(KeyValuePair<string, long> a, KeyValuePair<string, long> b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Quest.<>c__DisplayClass24_0 // TypeDefIndex: 1769
{
	// Fields
	public Quest <>4__this; // 0x10
	public QuestComplete questComplete; // 0x18

	// Methods

	// RVA: 0xF33C3C Offset: 0xF2FC3C VA: 0xF33C3C
	public void .ctor() { }

	// RVA: 0xF33C44 Offset: 0xF2FC44 VA: 0xF33C44
	internal void <QuestComplete>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Quest.<>c__DisplayClass25_0 // TypeDefIndex: 1770
{
	// Fields
	public Quest <>4__this; // 0x10
	public QuestInfo questInfo; // 0x18

	// Methods

	// RVA: 0xF33CD8 Offset: 0xF2FCD8 VA: 0xF33CD8
	public void .ctor() { }

	// RVA: 0xF33CE0 Offset: 0xF2FCE0 VA: 0xF33CE0
	internal void <QuestInfo>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Quest.<>c__DisplayClass26_0 // TypeDefIndex: 1771
{
	// Fields
	public QuestLock data; // 0x10
	public Quest <>4__this; // 0x18

	// Methods

	// RVA: 0xF33D78 Offset: 0xF2FD78 VA: 0xF33D78
	public void .ctor() { }

	// RVA: 0xF33D80 Offset: 0xF2FD80 VA: 0xF33D80
	internal void <QuestLock>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Quest.<>c__DisplayClass27_0 // TypeDefIndex: 1772
{
	// Fields
	public QuestLimit quest; // 0x10
	public Quest <>4__this; // 0x18

	// Methods

	// RVA: 0xF341B8 Offset: 0xF301B8 VA: 0xF341B8
	public void .ctor() { }

	// RVA: 0xF341C0 Offset: 0xF301C0 VA: 0xF341C0
	internal void <QuestLimit>b__0() { }
}

// Namespace: 
public class Quest : MonoBehaviour // TypeDefIndex: 1773
{
	// Fields
	[SerializeField]
	private RectTransform rectTransformComp; // 0x20
	[SerializeField]
	private GameObject ListQuest; // 0x28
	[SerializeField]
	private GameObject QuestItem; // 0x30
	[SerializeField]
	private ChatMessageScrollView scrollview; // 0x38
	[SerializeField]
	private Image viewportImage; // 0x40
	public Dictionary<string, Quest.ItemData> mappingGo; // 0x48
	private Dictionary<string, long> keyTimeout; // 0x50
	private long currentTime; // 0x58
	private long nextTime; // 0x60
	private string nextKey; // 0x68
	private string keyLocking; // 0x70
	private bool isStarted; // 0x78
	private Queue<Action> onStartQueue; // 0x80

	// Methods

	// RVA: 0xE6271C Offset: 0xE5E71C VA: 0xE6271C
	private void Start() { }

	// RVA: 0xE627C8 Offset: 0xE5E7C8 VA: 0xE627C8
	private void Update() { }

	// RVA: 0xE62B28 Offset: 0xE5EB28 VA: 0xE62B28
	private void Perform(Action action) { }

	// RVA: 0xE62960 Offset: 0xE5E960 VA: 0xE62960
	private void CalcNextTime() { }

	// RVA: 0xE62BA4 Offset: 0xE5EBA4 VA: 0xE62BA4
	private void SyncQuestData(string key, string title, string content) { }

	// RVA: 0xE62C50 Offset: 0xE5EC50 VA: 0xE62C50
	private void UpdateQuestData(string key, string title, string content, Quest.ItemData data) { }

	// RVA: 0xE62C90 Offset: 0xE5EC90 VA: 0xE62C90
	private void AddQuestData(string key, string title, string content) { }

	// RVA: 0xE6287C Offset: 0xE5E87C VA: 0xE6287C
	private void RemoveQuest(string key) { }

	// RVA: 0xE62E70 Offset: 0xE5EE70 VA: 0xE62E70
	public void Clear() { }

	// RVA: 0xE62E68 Offset: 0xE5EE68 VA: 0xE62E68
	public void QuestUnlock() { }

	// RVA: 0xE6322C Offset: 0xE5F22C VA: 0xE6322C
	public void QuestComplete(QuestComplete questComplete) { }

	// RVA: 0xE63300 Offset: 0xE5F300 VA: 0xE63300
	public void QuestInfo(QuestInfo questInfo) { }

	// RVA: 0xE63158 Offset: 0xE5F158 VA: 0xE63158
	public void QuestLock(QuestLock data) { }

	// RVA: 0xE633D4 Offset: 0xE5F3D4 VA: 0xE633D4
	public void QuestLimit(QuestLimit quest) { }

	// RVA: 0xE634A8 Offset: 0xE5F4A8 VA: 0xE634A8
	public void .ctor() { }
}

// Namespace: 
public class QuestItem : MonoBehaviour, IPointerClickHandler, IEventSystemHandler // TypeDefIndex: 1774
{
	// Fields
	[SerializeField]
	private GameObject questTitle; // 0x20
	[SerializeField]
	private GameObject questContent; // 0x28
	[SerializeField]
	private Image image; // 0x30
	[SerializeField]
	private Button button; // 0x38
	private string questKey; // 0x40
	private TextMeshProUGUI titleTextMeshPro; // 0x48
	private TextMeshProUGUI contentTextMeshPro; // 0x50
	private bool sendclick; // 0x58

	// Methods

	// RVA: 0xF342B8 Offset: 0xF302B8 VA: 0xF342B8
	private void Start() { }

	// RVA: 0xF34174 Offset: 0xF30174 VA: 0xF34174
	public void SetButtonInteractable(bool interactable) { }

	// RVA: 0xF34348 Offset: 0xF30348 VA: 0xF34348
	public void SetButtonSendClick(bool sendclick) { }

	// RVA: 0xF34350 Offset: 0xF30350 VA: 0xF34350
	public void SetData(string key, string title, string content) { }

	// RVA: 0xF34590 Offset: 0xF30590 VA: 0xF34590 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0xF347B0 Offset: 0xF307B0 VA: 0xF347B0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF347C0 Offset: 0xF307C0 VA: 0xF347C0
	private void <Start>b__8_0() { }
}

// Namespace: 
public enum NotificationType // TypeDefIndex: 1775
{
	// Fields
	public int value__; // 0x0
	public const NotificationType Trade = 0;
	public const NotificationType InviteParty = 1;
	public const NotificationType RequestParty = 2;
	public const NotificationType RequestTong = 3;
}

// Namespace: 
public sealed class ToggleCallback : MulticastDelegate // TypeDefIndex: 1776
{
	// Methods

	// RVA: 0xF348BC Offset: 0xF308BC VA: 0xF348BC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xF3495C Offset: 0xF3095C VA: 0xF3495C Slot: 12
	public virtual void Invoke(bool isOn) { }

	// RVA: 0xF34970 Offset: 0xF30970 VA: 0xF34970 Slot: 13
	public virtual IAsyncResult BeginInvoke(bool isOn, AsyncCallback callback, object object) { }

	// RVA: 0xF349CC Offset: 0xF309CC VA: 0xF349CC Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public class ToggleController : MonoBehaviour // TypeDefIndex: 1777
{
	// Fields
	public bool isOn; // 0x20
	public Color onColorBg; // 0x24
	public Color offColorBg; // 0x34
	public Image toggleBgImage; // 0x48
	public RectTransform toggle; // 0x50
	public GameObject handle; // 0x58
	private RectTransform handleTransform; // 0x60
	private float handleSize; // 0x68
	private float onPosX; // 0x6C
	private float offPosX; // 0x70
	public float handleOffset; // 0x74
	public GameObject onIcon; // 0x78
	public GameObject offIcon; // 0x80
	[CompilerGenerated]
	private ToggleCallback toggleCallback; // 0x88
	public float speed; // 0x90
	private static float t; // 0x0
	private bool switching; // 0x94

	// Methods

	[CompilerGenerated]
	// RVA: 0xF349D8 Offset: 0xF309D8 VA: 0xF349D8
	public void add_toggleCallback(ToggleCallback value) { }

	[CompilerGenerated]
	// RVA: 0xF34A74 Offset: 0xF30A74 VA: 0xF34A74
	public void remove_toggleCallback(ToggleCallback value) { }

	// RVA: 0xF34B10 Offset: 0xF30B10 VA: 0xF34B10
	private void Awake() { }

	// RVA: 0xF34BCC Offset: 0xF30BCC VA: 0xF34BCC
	private void Start() { }

	[Obsolete]
	// RVA: 0xF34CD4 Offset: 0xF30CD4 VA: 0xF34CD4
	private void Update() { }

	// RVA: 0xF34E34 Offset: 0xF30E34 VA: 0xF34E34
	public void DoYourStaff() { }

	// RVA: 0xF34E58 Offset: 0xF30E58 VA: 0xF34E58
	public void Switching() { }

	[Obsolete]
	// RVA: 0xF34CE8 Offset: 0xF30CE8 VA: 0xF34CE8
	public void Toggle(bool toggleStatus) { }

	// RVA: 0xF35058 Offset: 0xF31058 VA: 0xF35058
	private Vector3 SmoothMove(GameObject toggleHandle, float startPosX, float endPosX) { }

	// RVA: 0xF34E64 Offset: 0xF30E64 VA: 0xF34E64
	private Color SmoothColor(Color startCol, Color endCol) { }

	// RVA: 0xF34F60 Offset: 0xF30F60 VA: 0xF34F60
	private CanvasGroup Transparency(GameObject alphaObj, float startAlpha, float endAlpha) { }

	// RVA: 0xF35114 Offset: 0xF31114 VA: 0xF35114
	private void StopSwitching() { }

	// RVA: 0xF35190 Offset: 0xF31190 VA: 0xF35190
	public void .ctor() { }
}

// Namespace: 
public static class MusicManagerGame.SoundEffect // TypeDefIndex: 1778
{
	// Fields
	public const string addExp = "sound.effect.add.exp";
	public const string click = "sound.effect.click";
	public const string countdown = "sound.effect.count.down";
	public const string dropItem = "sound.effect.drop.item";
	public const string dropMoney = "sound.effect.drop.money";
	public const string dropWeapon = "sound.effect.drop.weapon";
	public const string footStep = "sound.effect.foot.step";
	public const string girlDeath = "sound.effect.girl.death";
	public const string girlFightMagic = "sound.effect.girl.fight.magic";
	public const string girlFightPhysic = "sound.effect.girl.fight.physic";
	public const string girlHurt = "sound.effect.girl.hurt";
	public const string horseDeath = "sound.effect.horse.death";
	public const string levelup = "sound.effect.level.up";
	public const string manDeath = "sound.effect.man.death";
	public const string manFightMagic = "sound.effect.man.fight.magic";
	public const string manFightPhysic = "sound.effect.man.fight.physic";
	public const string manHurt = "sound.effect.man.hurt";
	public const string openMap = "sound.effect.open.map";
	public const string openPopup = "sound.effect.open.popup";
	public const string pickMoney = "sound.effect.pick.money";
	public const string playerOnline = "sound.effect.player.online";
	public const string ridingHorse = "sound.effect.riding.horse";
	public const string systemChat = "sound.effect.system.chat";
	public const string usePotion = "sound.effect.use.potion";
}

// Namespace: 
public static class MusicManagerGame.CreatePlayer // TypeDefIndex: 1779
{
	// Fields
	public const string earthGirl = "create.player.earth.girl";
	public const string fireGirl = "create.player.fire.girl";
	public const string fireMan = "create.player.fire.man";
	public const string metalMan = "create.player.metal.man";
	public const string waterGirl = "create.player.water.girl";
	public const string woodGirl = "create.player.wood.girl";
	public const string woodMan = "create.player.wood.man";
}

// Namespace: 
public class MusicManagerGame : MonoBehaviour // TypeDefIndex: 1780
{
	// Fields
	public static MusicManagerGame instance; // 0x0
	private static readonly Dictionary<string, AudioClip> cached; // 0x8
	private AudioMixerGroup runMixer; // 0x20
	private AudioSource audioSourceBackground; // 0x28
	private AudioSource audioSourceRun; // 0x30
	private AudioSource audioSourceUI; // 0x38
	private AudioSource audioSourceDistance; // 0x40
	private AudioSource audioSourceMissile; // 0x48
	private static AudioClip runningAudioClip; // 0x10
	private static AudioClip horseAudioClip; // 0x18
	private static long currentPlayerActionSecondsTime; // 0x20
	private static long currentPlayerActionPlayingCount; // 0x28
	private static long nextTimeDropCoin; // 0x30
	private static long nextTimeDropItem; // 0x38
	private static long nextTimeNotification; // 0x40

	// Methods

	// RVA: 0xF35198 Offset: 0xF31198 VA: 0xF35198
	public static void Initialize() { }

	// RVA: 0xF353E8 Offset: 0xF313E8 VA: 0xF353E8
	public void PlayEffect(string name, float delay) { }

	// RVA: 0xF3551C Offset: 0xF3151C VA: 0xF3551C
	public void PlayEffect(string name) { }

	// RVA: 0xF35628 Offset: 0xF31628 VA: 0xF35628
	public void PlayMucsicBackgroundMap(int mapID) { }

	// RVA: 0xF357A8 Offset: 0xF317A8 VA: 0xF357A8
	public void PlayMusicBackgroundRandom() { }

	// RVA: 0xF35950 Offset: 0xF31950 VA: 0xF35950
	public void SetMusicBackgroundVolume(float value) { }

	// RVA: 0xF359E8 Offset: 0xF319E8 VA: 0xF359E8
	public void StopMusicBackground() { }

	// RVA: 0xF35A00 Offset: 0xF31A00 VA: 0xF35A00
	public void StartFootStep(bool isHorse, float speed) { }

	// RVA: 0xF35B7C Offset: 0xF31B7C VA: 0xF35B7C
	public void StartRunning(float speed, bool isManSex) { }

	// RVA: 0xF35EFC Offset: 0xF31EFC VA: 0xF35EFC
	public void StartRiding(float speed) { }

	// RVA: 0xF36274 Offset: 0xF32274 VA: 0xF36274
	public void StartRun(bool isHorse, float speed, bool isManSex) { }

	// RVA: 0xF36284 Offset: 0xF32284 VA: 0xF36284
	public void StopMove() { }

	// RVA: 0xF36308 Offset: 0xF32308 VA: 0xF36308
	public void PlayMissileEffect(string filename, int distance) { }

	// RVA: 0xF364DC Offset: 0xF324DC VA: 0xF364DC
	public void DoPlayerAction(AudioClip audioClip, int distance) { }

	// RVA: 0xF36654 Offset: 0xF32654 VA: 0xF36654
	public void DoSkill(bool isMale, bool isPhysic, int distance3D) { }

	// RVA: 0xF3684C Offset: 0xF3284C VA: 0xF3684C
	public void Hurt(bool isMan, int distance3D) { }

	// RVA: 0xF36A04 Offset: 0xF32A04 VA: 0xF36A04
	public void Die(bool isMale, bool isriding, int distance3D) { }

	// RVA: 0xF36BE4 Offset: 0xF32BE4 VA: 0xF36BE4
	public void OpenBox() { }

	// RVA: 0xF36CF4 Offset: 0xF32CF4 VA: 0xF36CF4
	public void OpenMap() { }

	// RVA: 0xF36E04 Offset: 0xF32E04 VA: 0xF36E04
	public void ScrollOpen() { }

	// RVA: 0xF36E08 Offset: 0xF32E08 VA: 0xF36E08
	public void Close() { }

	// RVA: 0xF346A0 Offset: 0xF306A0 VA: 0xF346A0
	public void Click() { }

	// RVA: 0xF36E0C Offset: 0xF32E0C VA: 0xF36E0C
	public void UseItem() { }

	// RVA: 0xF36E54 Offset: 0xF32E54 VA: 0xF36E54
	public void OpenEquipment() { }

	// RVA: 0xF36F64 Offset: 0xF32F64 VA: 0xF36F64
	public void LevelUp() { }

	// RVA: 0xF37074 Offset: 0xF33074 VA: 0xF37074
	public void PickGold() { }

	// RVA: 0xF37184 Offset: 0xF33184 VA: 0xF37184
	public void Exp() { }

	// RVA: 0xF37294 Offset: 0xF33294 VA: 0xF37294
	public void DropCoin() { }

	// RVA: 0xF37458 Offset: 0xF33458 VA: 0xF37458
	public void DropItem() { }

	// RVA: 0xF3761C Offset: 0xF3361C VA: 0xF3761C
	public void PickItem() { }

	// RVA: 0xF3772C Offset: 0xF3372C VA: 0xF3772C
	public void Notification() { }

	// RVA: 0xF378F0 Offset: 0xF338F0 VA: 0xF378F0
	public void SetAudioVolume(float value) { }

	// RVA: 0xF37A3C Offset: 0xF33A3C VA: 0xF37A3C
	public void .ctor() { }

	// RVA: 0xF37A44 Offset: 0xF33A44 VA: 0xF37A44
	private static void .cctor() { }
}

// Namespace: 
public class ResourceManager.PlatformData // TypeDefIndex: 1781
{
	// Fields
	public string name; // 0x10
	public bool isEncrypt; // 0x18
	public string assestBundleName; // 0x20

	// Methods

	// RVA: 0xF3800C Offset: 0xF3400C VA: 0xF3800C
	public void .ctor() { }
}

// Namespace: 
public class ResourceManager : MonoBehaviour // TypeDefIndex: 1782
{
	// Fields
	private static readonly List<string> MaterialFontName; // 0x0
	private static readonly List<string> MaterialMatName; // 0x8
	private static readonly List<string> MaterialSpriteName; // 0x10
	public static ResourceManager instance; // 0x18
	public static Dictionary<string, TMP_FontAsset> MaterialFont; // 0x20
	public static Dictionary<string, Material> MaterialMat; // 0x28
	public static Dictionary<string, TMP_SpriteAsset> MaterialSprite; // 0x30
	[HideInInspector]
	public AssetBundle audioBundle; // 0x20
	[HideInInspector]
	public AssetBundle resourceBundle; // 0x28
	[HideInInspector]
	private AssetBundle sceneBundle; // 0x30
	[HideInInspector]
	private AssetBundle fontBundle; // 0x38
	public ResourceManager.PlatformData platform; // 0x40
	private static readonly Dictionary<string, bool> unnecessaryTexture2DName; // 0x38

	// Methods

	// RVA: 0xF37B30 Offset: 0xF33B30 VA: 0xF37B30
	public static void Initialize() { }

	// RVA: 0xF37C7C Offset: 0xF33C7C VA: 0xF37C7C
	public Sprite LoadSpriteByName(string name) { }

	// RVA: 0xF37D78 Offset: 0xF33D78 VA: 0xF37D78
	private void OnDestroy() { }

	// RVA: 0xF37E00 Offset: 0xF33E00 VA: 0xF37E00
	public ResourceManager.PlatformData GetPlatform() { }

	// RVA: 0xF38068 Offset: 0xF34068 VA: 0xF38068
	public void InitPlatform() { }

	// RVA: 0xF38088 Offset: 0xF34088 VA: 0xF38088
	public bool InitAudio(out int errorcode) { }

	// RVA: 0xF382A4 Offset: 0xF342A4 VA: 0xF382A4
	public bool InitResource(out int errorcode) { }

	// RVA: 0xF39958 Offset: 0xF35958 VA: 0xF39958
	public bool InitializeFontMaterial(out int errorcode) { }

	// RVA: 0xF3A164 Offset: 0xF36164 VA: 0xF3A164
	public bool InitializeScenes(out int errorcode) { }

	// RVA: 0xF3AD58 Offset: 0xF36D58 VA: 0xF3AD58
	public bool InitializeFontAsset(out int errorcode) { }

	// RVA: 0xF3B850 Offset: 0xF37850 VA: 0xF3B850
	public void DestroyUnnecessaryResource() { }

	// RVA: 0xF3BB7C Offset: 0xF37B7C VA: 0xF3BB7C
	public static void BilnServerDevelPasscode(string inputPassword) { }

	// RVA: 0xF3BCC4 Offset: 0xF37CC4 VA: 0xF3BCC4
	public static void ClearAllSavedFiles() { }

	// RVA: 0xF3C144 Offset: 0xF38144 VA: 0xF3C144
	public static void ClearAutoFiles() { }

	// RVA: 0xF3BF34 Offset: 0xF37F34 VA: 0xF3BF34
	public static void ClearManualLayoutFiles() { }

	// RVA: 0xF3C24C Offset: 0xF3824C VA: 0xF3C24C
	public static void CheckManualLayoutVersion() { }

	// RVA: 0xF3C390 Offset: 0xF38390 VA: 0xF3C390
	public void .ctor() { }

	// RVA: 0xF3C398 Offset: 0xF38398 VA: 0xF3C398
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Game.<>c // TypeDefIndex: 1783
{
	// Fields
	public static readonly Game.<>c <>9; // 0x0
	public static Action <>9__0_0; // 0x8
	public static Action <>9__0_1; // 0x10
	public static Action<string> <>9__0_19; // 0x18
	public static Action <>9__0_2; // 0x20
	public static Action<string> <>9__0_20; // 0x28
	public static Action <>9__0_3; // 0x30
	public static Action <>9__0_4; // 0x38
	public static Action <>9__0_5; // 0x40
	public static Action <>9__0_6; // 0x48
	public static Action<string> <>9__0_21; // 0x50
	public static Action <>9__0_7; // 0x58
	public static Action<string> <>9__0_22; // 0x60
	public static Action <>9__0_8; // 0x68
	public static Action<string> <>9__0_23; // 0x70
	public static Action <>9__0_9; // 0x78
	public static Action<string> <>9__0_24; // 0x80
	public static Action <>9__0_10; // 0x88
	public static Action <>9__0_11; // 0x90
	public static Action <>9__0_12; // 0x98
	public static Action <>9__0_13; // 0xA0
	public static Action <>9__0_14; // 0xA8
	public static Action <>9__0_15; // 0xB0
	public static Action <>9__0_16; // 0xB8
	public static Action <>9__0_17; // 0xC0
	public static Action <>9__0_18; // 0xC8

	// Methods

	// RVA: 0xF3EA48 Offset: 0xF3AA48 VA: 0xF3EA48
	private static void .cctor() { }

	// RVA: 0xF3EAB0 Offset: 0xF3AAB0 VA: 0xF3EAB0
	public void .ctor() { }

	// RVA: 0xF3EAB8 Offset: 0xF3AAB8 VA: 0xF3EAB8
	internal void <GetInitializeActionList>b__0_0() { }

	// RVA: 0xF3EAC0 Offset: 0xF3AAC0 VA: 0xF3EAC0
	internal void <GetInitializeActionList>b__0_1() { }

	// RVA: 0xF3EAC8 Offset: 0xF3AAC8 VA: 0xF3EAC8
	internal void <GetInitializeActionList>b__0_2() { }

	// RVA: 0xF3EB9C Offset: 0xF3AB9C VA: 0xF3EB9C
	internal void <GetInitializeActionList>b__0_19(string line) { }

	// RVA: 0xF3EBA0 Offset: 0xF3ABA0 VA: 0xF3EBA0
	internal void <GetInitializeActionList>b__0_3() { }

	// RVA: 0xF3ECA0 Offset: 0xF3ACA0 VA: 0xF3ECA0
	internal void <GetInitializeActionList>b__0_20(string line) { }

	// RVA: 0xF3ECA4 Offset: 0xF3ACA4 VA: 0xF3ECA4
	internal void <GetInitializeActionList>b__0_4() { }

	// RVA: 0xF3ECAC Offset: 0xF3ACAC VA: 0xF3ECAC
	internal void <GetInitializeActionList>b__0_5() { }

	// RVA: 0xF3ECFC Offset: 0xF3ACFC VA: 0xF3ECFC
	internal void <GetInitializeActionList>b__0_6() { }

	// RVA: 0xF3ED04 Offset: 0xF3AD04 VA: 0xF3ED04
	internal void <GetInitializeActionList>b__0_7() { }

	// RVA: 0xF3EE04 Offset: 0xF3AE04 VA: 0xF3EE04
	internal void <GetInitializeActionList>b__0_21(string line) { }

	// RVA: 0xF3EE08 Offset: 0xF3AE08 VA: 0xF3EE08
	internal void <GetInitializeActionList>b__0_8() { }

	// RVA: 0xF3EF08 Offset: 0xF3AF08 VA: 0xF3EF08
	internal void <GetInitializeActionList>b__0_22(string line) { }

	// RVA: 0xF3EF0C Offset: 0xF3AF0C VA: 0xF3EF0C
	internal void <GetInitializeActionList>b__0_9() { }

	// RVA: 0xF3EFE0 Offset: 0xF3AFE0 VA: 0xF3EFE0
	internal void <GetInitializeActionList>b__0_23(string line) { }

	// RVA: 0xF3EFE4 Offset: 0xF3AFE4 VA: 0xF3EFE4
	internal void <GetInitializeActionList>b__0_10() { }

	// RVA: 0xF3F0E4 Offset: 0xF3B0E4 VA: 0xF3F0E4
	internal void <GetInitializeActionList>b__0_24(string line) { }

	// RVA: 0xF3F0E8 Offset: 0xF3B0E8 VA: 0xF3F0E8
	internal void <GetInitializeActionList>b__0_11() { }

	// RVA: 0xF3F138 Offset: 0xF3B138 VA: 0xF3F138
	internal void <GetInitializeActionList>b__0_12() { }

	// RVA: 0xF3F188 Offset: 0xF3B188 VA: 0xF3F188
	internal void <GetInitializeActionList>b__0_13() { }

	// RVA: 0xF3F1D8 Offset: 0xF3B1D8 VA: 0xF3F1D8
	internal void <GetInitializeActionList>b__0_14() { }

	// RVA: 0xF3F228 Offset: 0xF3B228 VA: 0xF3F228
	internal void <GetInitializeActionList>b__0_15() { }

	// RVA: 0xF3F278 Offset: 0xF3B278 VA: 0xF3F278
	internal void <GetInitializeActionList>b__0_16() { }

	// RVA: 0xF3F2C8 Offset: 0xF3B2C8 VA: 0xF3F2C8
	internal void <GetInitializeActionList>b__0_17() { }

	// RVA: 0xF3F2D0 Offset: 0xF3B2D0 VA: 0xF3F2D0
	internal void <GetInitializeActionList>b__0_18() { }
}

// Namespace: 
internal class Game // TypeDefIndex: 1784
{
	// Methods

	// RVA: 0xF3D598 Offset: 0xF39598 VA: 0xF3D598
	public static List<Action> GetInitializeActionList() { }

	// RVA: 0xF3E6E4 Offset: 0xF3A6E4 VA: 0xF3E6E4
	public static void Initialize() { }

	// RVA: 0xF3E928 Offset: 0xF3A928 VA: 0xF3E928
	public static void Release() { }

	// RVA: 0xF3E9E4 Offset: 0xF3A9E4 VA: 0xF3E9E4
	public static Resource Resource(string _path) { }

	// RVA: 0xF3EA40 Offset: 0xF3AA40 VA: 0xF3EA40
	public void .ctor() { }
}

// Namespace: 
public class GsMessageHandlers : iGsMessageHandler // TypeDefIndex: 1785
{
	// Properties
	public virtual Id IdCode { get; }

	// Methods

	// RVA: 0xF3F320 Offset: 0xF3B320 VA: 0xF3F320 Slot: 6
	public virtual Id get_IdCode() { }

	// RVA: 0xF3F328 Offset: 0xF3B328 VA: 0xF3F328 Slot: 7
	public virtual void Process(NetCoreManager.MessageData message) { }

	// RVA: 0xF3F360 Offset: 0xF3B360 VA: 0xF3F360
	public void .ctor() { }
}

// Namespace: 
public class MsMessageHandlers : iMsMessageHandler // TypeDefIndex: 1786
{
	// Properties
	public virtual MSCode Code { get; }

	// Methods

	// RVA: 0xF3F368 Offset: 0xF3B368 VA: 0xF3F368 Slot: 6
	public virtual MSCode get_Code() { }

	// RVA: 0xF3F370 Offset: 0xF3B370 VA: 0xF3F370 Slot: 7
	public virtual void Process(NetCoreManager.MessageData message) { }

	// RVA: 0xF3F3A8 Offset: 0xF3B3A8 VA: 0xF3F3A8
	public void .ctor() { }
}

// Namespace: 
public interface iGsMessageHandler // TypeDefIndex: 1787
{
	// Properties
	public abstract Id IdCode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Id get_IdCode();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Process(NetCoreManager.MessageData message);
}

// Namespace: 
public interface iMsMessageHandler // TypeDefIndex: 1788
{
	// Properties
	public abstract MSCode Code { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MSCode get_Code();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Process(NetCoreManager.MessageData message);
}

// Namespace: 
[Serializable]
public class Readme.Section // TypeDefIndex: 1789
{
	// Fields
	public string heading; // 0x10
	public string text; // 0x18
	public string linkText; // 0x20
	public string url; // 0x28

	// Methods

	// RVA: 0xF3F3B8 Offset: 0xF3B3B8 VA: 0xF3F3B8
	public void .ctor() { }
}

// Namespace: 
public class Readme : ScriptableObject // TypeDefIndex: 1790
{
	// Fields
	public Texture2D icon; // 0x18
	public string title; // 0x20
	public Readme.Section[] sections; // 0x28
	public bool loadedLayout; // 0x30

	// Methods

	// RVA: 0xF3F3B0 Offset: 0xF3B3B0 VA: 0xF3F3B0
	public void .ctor() { }
}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 1791
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[CompilerGenerated]
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 1792
{
	// Methods

	// RVA: 0xF3F3C0 Offset: 0xF3B3C0 VA: 0xF3F3C0
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0xF3F4B4 Offset: 0xF3B4B4 VA: 0xF3F4B4
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(27524, AllowMultiple = False, Inherited = False)]
[Embedded]
[CompilerGenerated]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 4411
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x1A46D8C Offset: 0x1A42D8C VA: 0x1A46D8C
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[Usage(5196, AllowMultiple = False, Inherited = False)]
[CompilerGenerated]
[Embedded]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 4412
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x1A46E14 Offset: 0x1A42E14 VA: 0x1A46E14
	public void .ctor(byte ) { }
}

// Namespace: 
internal static class SR // TypeDefIndex: 4413
{
	// Methods

	// RVA: 0x1A46E3C Offset: 0x1A42E3C VA: 0x1A46E3C
	internal static string GetString(string name) { }

	// RVA: 0x1A46E40 Offset: 0x1A42E40 VA: 0x1A46E40
	internal static string Format(string resourceFormat, object p1) { }

	// RVA: 0x1A46EB0 Offset: 0x1A42EB0 VA: 0x1A46EB0
	internal static string Format(string resourceFormat, object p1, object p2) { }

	// RVA: 0x1A46F28 Offset: 0x1A42F28 VA: 0x1A46F28
	internal static string Format(string resourceFormat, object p1, object p2, object p3) { }
}

// Namespace: System.Runtime.CompilerServices
[DebuggerStepThrough]
[EditorBrowsable(1)]
public static class RuntimeOps // TypeDefIndex: 5911
{
	// Methods

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: 0x1A0C568 Offset: 0x1A08568 VA: 0x1A0C568
	public static bool ExpandoTryGetValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase, out object value) { }

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: 0x1A0C6B0 Offset: 0x1A086B0 VA: 0x1A0C6B0
	public static object ExpandoTrySetValue(ExpandoObject expando, object indexClass, int index, object value, string name, bool ignoreCase) { }

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: 0x1A0CA74 Offset: 0x1A08A74 VA: 0x1A0CA74
	public static bool ExpandoTryDeleteValue(ExpandoObject expando, object indexClass, int index, string name, bool ignoreCase) { }

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: 0x1A0CE04 Offset: 0x1A08E04 VA: 0x1A0CE04
	public static bool ExpandoCheckVersion(ExpandoObject expando, object version) { }

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: 0x1A0CE44 Offset: 0x1A08E44 VA: 0x1A0CE44
	public static void ExpandoPromoteClass(ExpandoObject expando, object oldClass, object newClass) { }
}

// Namespace: System.Runtime.CompilerServices
public class CallSite // TypeDefIndex: 5912
{
	// Fields
	internal readonly CallSiteBinder _binder; // 0x10
	internal bool _match; // 0x18

	// Properties
	public CallSiteBinder Binder { get; }

	// Methods

	// RVA: 0x1A0CFC0 Offset: 0x1A08FC0 VA: 0x1A0CFC0
	internal void .ctor(CallSiteBinder binder) { }

	// RVA: 0x1A0CFF0 Offset: 0x1A08FF0 VA: 0x1A0CFF0
	public CallSiteBinder get_Binder() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CallSite.<>c<T> // TypeDefIndex: 5913
{
	// Fields
	public static readonly CallSite.<>c<T> <>9; // 0x0
	public static Converter<ParameterInfo, ParameterExpression> <>9__20_0; // 0x0
	public static Converter<ParameterExpression, Expression> <>9__20_1; // 0x0
	public static Converter<ParameterInfo, ParameterExpression> <>9__21_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11508D0 Offset: 0x114C8D0 VA: 0x11508D0
	|-CallSite.<>c<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11509A8 Offset: 0x114C9A8 VA: 0x11509A8
	|-CallSite.<>c<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal ParameterExpression <CreateCustomUpdateDelegate>b__20_0(ParameterInfo p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11509B0 Offset: 0x114C9B0 VA: 0x11509B0
	|-CallSite.<>c<object>.<CreateCustomUpdateDelegate>b__20_0
	*/

	// RVA: -1 Offset: -1
	internal Expression <CreateCustomUpdateDelegate>b__20_1(ParameterExpression p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150A40 Offset: 0x114CA40 VA: 0x1150A40
	|-CallSite.<>c<object>.<CreateCustomUpdateDelegate>b__20_1
	*/

	// RVA: -1 Offset: -1
	internal ParameterExpression <CreateCustomNoMatchDelegate>b__21_0(ParameterInfo p) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150A98 Offset: 0x114CA98 VA: 0x1150A98
	|-CallSite.<>c<object>.<CreateCustomNoMatchDelegate>b__21_0
	*/
}

// Namespace: System.Runtime.CompilerServices
public class CallSite<T> : CallSite // TypeDefIndex: 5914
{
	// Fields
	public T Target; // 0x0
	internal T[] Rules; // 0x0
	private static T s_cachedUpdate; // 0x0
	private static T s_cachedNoMatch; // 0x0

	// Properties
	public T Update { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T get_Update() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DF750 Offset: 0x14DB750 VA: 0x14DF750
	|-CallSite<object>.get_Update
	*/

	// RVA: -1 Offset: -1
	private void .ctor(CallSiteBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DF7A8 Offset: 0x14DB7A8 VA: 0x14DF7A8
	|-CallSite<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DF7EC Offset: 0x14DB7EC VA: 0x14DF7EC
	|-CallSite<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal CallSite<T> CreateMatchMaker() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DF7F8 Offset: 0x14DB7F8 VA: 0x14DF7F8
	|-CallSite<object>.CreateMatchMaker
	*/

	// RVA: -1 Offset: -1
	public static CallSite<T> Create(CallSiteBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DF838 Offset: 0x14DB838 VA: 0x14DF838
	|-CallSite<object>.Create
	*/

	// RVA: -1 Offset: -1
	private T GetUpdateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DF99C Offset: 0x14DB99C VA: 0x14DF99C
	|-CallSite<object>.GetUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	private T GetUpdateDelegate(ref T addr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DF9F0 Offset: 0x14DB9F0 VA: 0x14DF9F0
	|-CallSite<object>.GetUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	internal void AddRule(T newRule) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DFA30 Offset: 0x14DBA30 VA: 0x14DFA30
	|-CallSite<object>.AddRule
	*/

	// RVA: -1 Offset: -1
	internal void MoveRule(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DFB3C Offset: 0x14DBB3C VA: 0x14DFB3C
	|-CallSite<object>.MoveRule
	*/

	// RVA: -1 Offset: -1
	internal T MakeUpdateDelegate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DFC08 Offset: 0x14DBC08 VA: 0x14DFC08
	|-CallSite<object>.MakeUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	private T CreateCustomUpdateDelegate(MethodInfo invoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DFD1C Offset: 0x14DBD1C VA: 0x14DFD1C
	|-CallSite<object>.CreateCustomUpdateDelegate
	*/

	// RVA: -1 Offset: -1
	private T CreateCustomNoMatchDelegate(MethodInfo invoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E1094 Offset: 0x14DD094 VA: 0x14E1094
	|-CallSite<object>.CreateCustomNoMatchDelegate
	*/

	// RVA: -1 Offset: -1
	private static Expression Convert(Expression arg, Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E13C8 Offset: 0x14DD3C8 VA: 0x14E13C8
	|-CallSite<object>.Convert
	*/
}

// Namespace: 
private sealed class CallSiteBinder.LambdaSignature<T> // TypeDefIndex: 5915
{
	// Fields
	private static CallSiteBinder.LambdaSignature<T> s_instance; // 0x0
	internal readonly ReadOnlyCollection<ParameterExpression> Parameters; // 0x0
	internal readonly LabelTarget ReturnLabel; // 0x0

	// Properties
	internal static CallSiteBinder.LambdaSignature<T> Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal static CallSiteBinder.LambdaSignature<T> get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E65D0 Offset: 0x12E25D0 VA: 0x12E65D0
	|-CallSiteBinder.LambdaSignature<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	private void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E6720 Offset: 0x12E2720 VA: 0x12E6720
	|-CallSiteBinder.LambdaSignature<object>..ctor
	*/
}

// Namespace: System.Runtime.CompilerServices
public abstract class CallSiteBinder // TypeDefIndex: 5916
{
	// Fields
	internal Dictionary<Type, object> Cache; // 0x10
	[CompilerGenerated]
	private static readonly LabelTarget <UpdateLabel>k__BackingField; // 0x0

	// Properties
	public static LabelTarget UpdateLabel { get; }

	// Methods

	// RVA: 0x1A0CFF8 Offset: 0x1A08FF8 VA: 0x1A0CFF8
	protected void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1A0D000 Offset: 0x1A09000 VA: 0x1A0D000
	public static LabelTarget get_UpdateLabel() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Expression Bind(object[] args, ReadOnlyCollection<ParameterExpression> parameters, LabelTarget returnLabel);

	// RVA: -1 Offset: -1 Slot: 5
	public virtual T BindDelegate<T>(CallSite<T> site, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF0BC Offset: 0x10EB0BC VA: 0x10EF0BC
	|-CallSiteBinder.BindDelegate<object>
	*/

	// RVA: -1 Offset: -1
	internal T BindCore<T>(CallSite<T> site, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EEF94 Offset: 0x10EAF94 VA: 0x10EEF94
	|-CallSiteBinder.BindCore<object>
	*/

	// RVA: -1 Offset: -1
	protected void CacheTarget<T>(T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF0C4 Offset: 0x10EB0C4 VA: 0x10EF0C4
	|-CallSiteBinder.CacheTarget<object>
	*/

	// RVA: -1 Offset: -1
	private static Expression<T> Stitch<T>(Expression binding, CallSiteBinder.LambdaSignature<T> signature) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF3A0 Offset: 0x10EB3A0 VA: 0x10EF3A0
	|-CallSiteBinder.Stitch<object>
	*/

	// RVA: -1 Offset: -1
	internal RuleCache<T> GetRuleCache<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF118 Offset: 0x10EB118 VA: 0x10EF118
	|-CallSiteBinder.GetRuleCache<object>
	*/

	// RVA: 0x1A0D058 Offset: 0x1A09058 VA: 0x1A0D058
	private static void .cctor() { }
}

// Namespace: System.Runtime.CompilerServices
[EditorBrowsable(1)]
[DebuggerStepThrough]
public static class CallSiteOps // TypeDefIndex: 5917
{
	// Methods

	[Obsolete("do not use this method", True)]
	[EditorBrowsable(1)]
	// RVA: -1 Offset: -1
	public static CallSite<T> CreateMatchmaker<T>(CallSite<T> site) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF750 Offset: 0x10EB750 VA: 0x10EF750
	|-CallSiteOps.CreateMatchmaker<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: 0x1A0D0F0 Offset: 0x1A090F0 VA: 0x1A0D0F0
	public static bool SetNotMatched(CallSite site) { }

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: 0x1A0D10C Offset: 0x1A0910C VA: 0x1A0D10C
	public static bool GetMatch(CallSite site) { }

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: 0x1A0D120 Offset: 0x1A09120 VA: 0x1A0D120
	public static void ClearMatch(CallSite site) { }

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static void AddRule<T>(CallSite<T> site, T rule) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF6B0 Offset: 0x10EB6B0 VA: 0x10EF6B0
	|-CallSiteOps.AddRule<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static void UpdateRules<T>(CallSite<T> this, int matched) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF894 Offset: 0x10EB894 VA: 0x10EF894
	|-CallSiteOps.UpdateRules<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static T[] GetRules<T>(CallSite<T> site) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF810 Offset: 0x10EB810 VA: 0x10EF810
	|-CallSiteOps.GetRules<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static RuleCache<T> GetRuleCache<T>(CallSite<T> site) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF7CC Offset: 0x10EB7CC VA: 0x10EF7CC
	|-CallSiteOps.GetRuleCache<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static void MoveRule<T>(RuleCache<T> cache, T rule, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF824 Offset: 0x10EB824 VA: 0x10EF824
	|-CallSiteOps.MoveRule<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static T[] GetCachedRules<T>(RuleCache<T> cache) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF7A0 Offset: 0x10EB7A0 VA: 0x10EF7A0
	|-CallSiteOps.GetCachedRules<object>
	*/

	[EditorBrowsable(1)]
	[Obsolete("do not use this method", True)]
	// RVA: -1 Offset: -1
	public static T Bind<T>(CallSiteBinder binder, CallSite<T> site, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EF6F8 Offset: 0x10EB6F8 VA: 0x10EF6F8
	|-CallSiteOps.Bind<object>
	*/
}

// Namespace: System.Runtime.CompilerServices
[DefaultMember("Item")]
public interface IRuntimeVariables // TypeDefIndex: 5918
{}

// Namespace: 
[Serializable]
private class ReadOnlyCollectionBuilder.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 5919
{
	// Fields
	private readonly ReadOnlyCollectionBuilder<T> _builder; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private T _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ReadOnlyCollectionBuilder<T> builder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EF794 Offset: 0x11EB794 VA: 0x11EF794
	|-ReadOnlyCollectionBuilder.Enumerator<object>..ctor
	|
	|-RVA: 0x11F6C34 Offset: 0x11F2C34 VA: 0x11F6C34
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EF7DC Offset: 0x11EB7DC VA: 0x11EF7DC
	|-ReadOnlyCollectionBuilder.Enumerator<object>.get_Current
	|
	|-RVA: 0x11F6CFC Offset: 0x11F2CFC VA: 0x11F6CFC
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EF7E4 Offset: 0x11EB7E4 VA: 0x11EF7E4
	|-ReadOnlyCollectionBuilder.Enumerator<object>.Dispose
	|
	|-RVA: 0x11F6D3C Offset: 0x11F2D3C VA: 0x11F6D3C
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EF7E8 Offset: 0x11EB7E8 VA: 0x11EF7E8
	|-ReadOnlyCollectionBuilder.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11F6D40 Offset: 0x11F2D40 VA: 0x11F6D40
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EF82C Offset: 0x11EB82C VA: 0x11EF82C
	|-ReadOnlyCollectionBuilder.Enumerator<object>.MoveNext
	|
	|-RVA: 0x11F6E90 Offset: 0x11F2E90 VA: 0x11F6E90
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EF8C8 Offset: 0x11EB8C8 VA: 0x11EF8C8
	|-ReadOnlyCollectionBuilder.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x11F7100 Offset: 0x11F3100 VA: 0x11F7100
	|-ReadOnlyCollectionBuilder.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: System.Runtime.CompilerServices
[DefaultMember("Item")]
[Serializable]
public sealed class ReadOnlyCollectionBuilder<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection // TypeDefIndex: 5920
{
	// Fields
	private T[] _items; // 0x0
	private int _size; // 0x0
	private int _version; // 0x0

	// Properties
	public int Capacity { set; }
	public int Count { get; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141F794 Offset: 0x141B794 VA: 0x141F794
	|-ReadOnlyCollectionBuilder<object>..ctor
	|
	|-RVA: 0x1420960 Offset: 0x141C960 VA: 0x1420960
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141F820 Offset: 0x141B820 VA: 0x141F820
	|-ReadOnlyCollectionBuilder<object>..ctor
	|
	|-RVA: 0x14209A4 Offset: 0x141C9A4 VA: 0x14209A4
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141F8B8 Offset: 0x141B8B8 VA: 0x141F8B8
	|-ReadOnlyCollectionBuilder<object>.set_Capacity
	|
	|-RVA: 0x1420A3C Offset: 0x141CA3C VA: 0x1420A3C
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FA04 Offset: 0x141BA04 VA: 0x141FA04
	|-ReadOnlyCollectionBuilder<object>.get_Count
	|
	|-RVA: 0x1420B40 Offset: 0x141CB40 VA: 0x1420B40
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FA0C Offset: 0x141BA0C VA: 0x141FA0C
	|-ReadOnlyCollectionBuilder<object>.IndexOf
	|
	|-RVA: 0x1420B48 Offset: 0x141CB48 VA: 0x1420B48
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FA2C Offset: 0x141BA2C VA: 0x141FA2C
	|-ReadOnlyCollectionBuilder<object>.Insert
	|
	|-RVA: 0x1420C20 Offset: 0x141CC20 VA: 0x1420C20
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FB24 Offset: 0x141BB24 VA: 0x141FB24
	|-ReadOnlyCollectionBuilder<object>.RemoveAt
	|
	|-RVA: 0x1420E3C Offset: 0x141CE3C VA: 0x1420E3C
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FBF0 Offset: 0x141BBF0 VA: 0x141FBF0
	|-ReadOnlyCollectionBuilder<object>.get_Item
	|
	|-RVA: 0x142100C Offset: 0x141D00C VA: 0x142100C
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FC74 Offset: 0x141BC74 VA: 0x141FC74
	|-ReadOnlyCollectionBuilder<object>.set_Item
	|
	|-RVA: 0x14210B8 Offset: 0x141D0B8 VA: 0x14210B8
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FD10 Offset: 0x141BD10 VA: 0x141FD10
	|-ReadOnlyCollectionBuilder<object>.Add
	|
	|-RVA: 0x1421270 Offset: 0x141D270 VA: 0x1421270
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FDA4 Offset: 0x141BDA4 VA: 0x141FDA4
	|-ReadOnlyCollectionBuilder<object>.Clear
	|
	|-RVA: 0x1421414 Offset: 0x141D414 VA: 0x1421414
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FDE0 Offset: 0x141BDE0 VA: 0x141FDE0
	|-ReadOnlyCollectionBuilder<object>.Contains
	|
	|-RVA: 0x1421450 Offset: 0x141D450 VA: 0x1421450
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FECC Offset: 0x141BECC VA: 0x141FECC
	|-ReadOnlyCollectionBuilder<object>.CopyTo
	|
	|-RVA: 0x14216BC Offset: 0x141D6BC VA: 0x14216BC
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FEEC Offset: 0x141BEEC VA: 0x141FEEC
	|-ReadOnlyCollectionBuilder<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x14216DC Offset: 0x141D6DC VA: 0x14216DC
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FEF4 Offset: 0x141BEF4 VA: 0x141FEF4
	|-ReadOnlyCollectionBuilder<object>.Remove
	|
	|-RVA: 0x14216E4 Offset: 0x141D6E4 VA: 0x14216E4
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FF60 Offset: 0x141BF60 VA: 0x141FF60
	|-ReadOnlyCollectionBuilder<object>.GetEnumerator
	|
	|-RVA: 0x14217D0 Offset: 0x141D7D0 VA: 0x14217D0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FFC4 Offset: 0x141BFC4 VA: 0x141FFC4
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1421838 Offset: 0x141D838 VA: 0x1421838
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FFD4 Offset: 0x141BFD4 VA: 0x141FFD4
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x142184C Offset: 0x141D84C VA: 0x142184C
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141FFDC Offset: 0x141BFDC VA: 0x141FFDC
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Add
	|
	|-RVA: 0x1421854 Offset: 0x141D854 VA: 0x1421854
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142014C Offset: 0x141C14C VA: 0x142014C
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x1421AA4 Offset: 0x141DAA4 VA: 0x1421AA4
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14201FC Offset: 0x141C1FC VA: 0x14201FC
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x1421BB8 Offset: 0x141DBB8 VA: 0x1421BB8
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14202C0 Offset: 0x141C2C0 VA: 0x14202C0
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Insert
	|
	|-RVA: 0x1421CC4 Offset: 0x141DCC4 VA: 0x1421CC4
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1420430 Offset: 0x141C430 VA: 0x1420430
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x1421F0C Offset: 0x141DF0C VA: 0x1421F0C
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1420438 Offset: 0x141C438 VA: 0x1420438
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.Remove
	|
	|-RVA: 0x1421F14 Offset: 0x141DF14 VA: 0x1421F14
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14204E4 Offset: 0x141C4E4 VA: 0x14204E4
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x1422014 Offset: 0x141E014 VA: 0x1422014
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14204F4 Offset: 0x141C4F4 VA: 0x14204F4
	|-ReadOnlyCollectionBuilder<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0x14220C4 Offset: 0x141E0C4 VA: 0x14220C4
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1420664 Offset: 0x141C664 VA: 0x1420664
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x142230C Offset: 0x141E30C VA: 0x142230C
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1420730 Offset: 0x141C730 VA: 0x1420730
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x14223D8 Offset: 0x141E3D8 VA: 0x14223D8
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1420738 Offset: 0x141C738 VA: 0x1420738
	|-ReadOnlyCollectionBuilder<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x14223E0 Offset: 0x141E3E0 VA: 0x14223E0
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142073C Offset: 0x141C73C VA: 0x142073C
	|-ReadOnlyCollectionBuilder<object>.ToArray
	|
	|-RVA: 0x14223E4 Offset: 0x141E3E4 VA: 0x14223E4
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyCollection<T> ToReadOnlyCollection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14207A4 Offset: 0x141C7A4 VA: 0x14207A4
	|-ReadOnlyCollectionBuilder<object>.ToReadOnlyCollection
	|
	|-RVA: 0x142244C Offset: 0x141E44C VA: 0x142244C
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.ToReadOnlyCollection
	*/

	// RVA: -1 Offset: -1
	private void EnsureCapacity(int min) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14208B4 Offset: 0x141C8B4 VA: 0x14208B4
	|-ReadOnlyCollectionBuilder<object>.EnsureCapacity
	|
	|-RVA: 0x142251C Offset: 0x141E51C VA: 0x142251C
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.EnsureCapacity
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14208FC Offset: 0x141C8FC VA: 0x14208FC
	|-ReadOnlyCollectionBuilder<object>.IsCompatibleObject
	|
	|-RVA: 0x1422568 Offset: 0x141E568 VA: 0x1422568
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1
	private static void ValidateNullValue(object value, string argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142095C Offset: 0x141C95C VA: 0x142095C
	|-ReadOnlyCollectionBuilder<object>.ValidateNullValue
	|
	|-RVA: 0x1422698 Offset: 0x141E698 VA: 0x1422698
	|-ReadOnlyCollectionBuilder<__Il2CppFullySharedGenericType>.ValidateNullValue
	*/
}

// Namespace: System.Runtime.CompilerServices
[EditorBrowsable(1)]
[DebuggerStepThrough]
public class RuleCache<T> // TypeDefIndex: 5921
{
	// Fields
	private T[] _rules; // 0x0
	private readonly object _cacheLock; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14552DC Offset: 0x14512DC VA: 0x14552DC
	|-RuleCache<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T[] GetRules() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14553B8 Offset: 0x14513B8 VA: 0x14553B8
	|-RuleCache<object>.GetRules
	*/

	// RVA: -1 Offset: -1
	internal void MoveRule(T rule, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14553C0 Offset: 0x14513C0 VA: 0x14553C0
	|-RuleCache<object>.MoveRule
	*/

	// RVA: -1 Offset: -1
	internal void AddRule(T newRule) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1455648 Offset: 0x1451648 VA: 0x1455648
	|-RuleCache<object>.AddRule
	*/

	// RVA: -1 Offset: -1
	private static T[] AddOrInsert(T[] rules, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1455734 Offset: 0x1451734 VA: 0x1455734
	|-RuleCache<object>.AddOrInsert
	*/
}

// Namespace: System.Runtime.CompilerServices
internal sealed class TrueReadOnlyCollection<T> : ReadOnlyCollection<T> // TypeDefIndex: 5922
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14888C4 Offset: 0x14848C4 VA: 0x14888C4
	|-TrueReadOnlyCollection<object>..ctor
	|
	|-RVA: 0x14888D4 Offset: 0x14848D4 VA: 0x14888D4
	|-TrueReadOnlyCollection<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Runtime.CompilerServices
public class StrongBox<T> : IStrongBox // TypeDefIndex: 5923
{
	// Fields
	public T Value; // 0x0

	// Properties
	private object System.Runtime.CompilerServices.IStrongBox.Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1465B48 Offset: 0x1461B48 VA: 0x1465B48
	|-StrongBox<int>..ctor
	|
	|-RVA: 0x1465C10 Offset: 0x1461C10 VA: 0x1465C10
	|-StrongBox<object>..ctor
	|
	|-RVA: 0x1465D14 Offset: 0x1461D14 VA: 0x1465D14
	|-StrongBox<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1465B50 Offset: 0x1461B50 VA: 0x1465B50
	|-StrongBox<int>..ctor
	|
	|-RVA: 0x1465C18 Offset: 0x1461C18 VA: 0x1465C18
	|-StrongBox<object>..ctor
	|
	|-RVA: 0x1465D1C Offset: 0x1461D1C VA: 0x1465D1C
	|-StrongBox<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private object System.Runtime.CompilerServices.IStrongBox.get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1465B78 Offset: 0x1461B78 VA: 0x1465B78
	|-StrongBox<int>.System.Runtime.CompilerServices.IStrongBox.get_Value
	|
	|-RVA: 0x1465C48 Offset: 0x1461C48 VA: 0x1465C48
	|-StrongBox<object>.System.Runtime.CompilerServices.IStrongBox.get_Value
	|
	|-RVA: 0x1465DE8 Offset: 0x1461DE8 VA: 0x1465DE8
	|-StrongBox<__Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.IStrongBox.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Runtime.CompilerServices.IStrongBox.set_Value(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1465BA0 Offset: 0x1461BA0 VA: 0x1465BA0
	|-StrongBox<int>.System.Runtime.CompilerServices.IStrongBox.set_Value
	|
	|-RVA: 0x1465C50 Offset: 0x1461C50 VA: 0x1465C50
	|-StrongBox<object>.System.Runtime.CompilerServices.IStrongBox.set_Value
	|
	|-RVA: 0x1465E84 Offset: 0x1461E84 VA: 0x1465E84
	|-StrongBox<__Il2CppFullySharedGenericType>.System.Runtime.CompilerServices.IStrongBox.set_Value
	*/
}

// Namespace: System.Runtime.CompilerServices
public interface IStrongBox // TypeDefIndex: 5924
{
	// Properties
	public abstract object Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Value();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Value(object value);
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 5983
{
	// Methods

	// RVA: 0x1920460 Offset: 0x191C460 VA: 0x1920460
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 5984
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x1920468 Offset: 0x191C468 VA: 0x1920468
	public void .ctor(byte ) { }

	// RVA: 0x19204F0 Offset: 0x191C4F0 VA: 0x19204F0
	public void .ctor(byte[] ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(5196, AllowMultiple = False, Inherited = False)]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 5985
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x1920520 Offset: 0x191C520 VA: 0x1920520
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsReadOnlyAttribute : Attribute // TypeDefIndex: 6288
{
	// Methods

	// RVA: 0x15CD870 Offset: 0x15C9870 VA: 0x15CD870
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsByRefLikeAttribute : Attribute // TypeDefIndex: 6289
{
	// Methods

	// RVA: 0x15CD878 Offset: 0x15C9878 VA: 0x15CD878
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
internal sealed class IsUnmanagedAttribute : Attribute // TypeDefIndex: 6584
{
	// Methods

	// RVA: 0x1E4A0A0 Offset: 0x1E460A0 VA: 0x1E4A0A0
	public void .ctor() { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(27524, AllowMultiple = False, Inherited = False)]
internal sealed class NullableAttribute : Attribute // TypeDefIndex: 7423
{
	// Fields
	public readonly byte[] NullableFlags; // 0x10

	// Methods

	// RVA: 0x1EA35C8 Offset: 0x1E9F5C8 VA: 0x1EA35C8
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
[CompilerGenerated]
[Embedded]
[Usage(5196, AllowMultiple = False, Inherited = False)]
internal sealed class NullableContextAttribute : Attribute // TypeDefIndex: 7424
{
	// Fields
	public readonly byte Flag; // 0x10

	// Methods

	// RVA: 0x1EA3650 Offset: 0x1E9F650 VA: 0x1EA3650
	public void .ctor(byte ) { }
}

// Namespace: System.Runtime.CompilerServices
public static class Unsafe // TypeDefIndex: 8132
{
	// Methods

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static T ReadUnaligned<T>(ref byte source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103C138 Offset: 0x1038138 VA: 0x103C138
	|-Unsafe.ReadUnaligned<double>
	|
	|-RVA: 0x103C140 Offset: 0x1038140 VA: 0x103C140
	|-Unsafe.ReadUnaligned<ulong>
	|
	|-RVA: 0x103C148 Offset: 0x1038148 VA: 0x103C148
	|-Unsafe.ReadUnaligned<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref TTo As<TFrom, TTo>(ref TFrom source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103C130 Offset: 0x1038130 VA: 0x103C130
	|-Unsafe.As<char, byte>
	|
	|-RVA: 0x103C134 Offset: 0x1038134 VA: 0x103C134
	|-Unsafe.As<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T Add<T>(ref T source, int elementOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103C0C8 Offset: 0x10380C8 VA: 0x103C0C8
	|-Unsafe.Add<byte>
	|
	|-RVA: 0x103C0D0 Offset: 0x10380D0 VA: 0x103C0D0
	|-Unsafe.Add<__Il2CppFullySharedGenericType>
	*/

	[NonVersionable]
	// RVA: -1 Offset: -1
	public static ref T AddByteOffset<T>(ref T source, IntPtr byteOffset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103C118 Offset: 0x1038118 VA: 0x103C118
	|-Unsafe.AddByteOffset<byte>
	|
	|-RVA: 0x103C120 Offset: 0x1038120 VA: 0x103C120
	|-Unsafe.AddByteOffset<char>
	|
	|-RVA: 0x103C128 Offset: 0x1038128 VA: 0x103C128
	|-Unsafe.AddByteOffset<__Il2CppFullySharedGenericType>
	*/
}
