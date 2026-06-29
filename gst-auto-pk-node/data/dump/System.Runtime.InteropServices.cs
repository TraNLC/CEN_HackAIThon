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

// Namespace: System.Runtime.InteropServices
public enum CharSet // TypeDefIndex: 1041
{
	// Fields
	public int value__; // 0x0
	public const CharSet None = 1;
	public const CharSet Ansi = 2;
	public const CharSet Unicode = 3;
	public const CharSet Auto = 4;
}

// Namespace: System.Runtime.InteropServices
[Serializable]
public class ExternalException : SystemException // TypeDefIndex: 1042
{
	// Methods

	// RVA: 0x17CEE28 Offset: 0x17CAE28 VA: 0x17CEE28
	public void .ctor() { }

	// RVA: 0x17CEE84 Offset: 0x17CAE84 VA: 0x17CEE84
	public void .ctor(string message) { }

	// RVA: 0x17CEEA8 Offset: 0x17CAEA8 VA: 0x17CEEA8
	public void .ctor(string message, int errorCode) { }

	// RVA: 0x17CEED0 Offset: 0x17CAED0 VA: 0x17CEED0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17CEED8 Offset: 0x17CAED8 VA: 0x17CEED8 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.InteropServices
[Serializable]
public class MarshalDirectiveException : SystemException // TypeDefIndex: 1043
{
	// Methods

	// RVA: 0x17CF0C0 Offset: 0x17CB0C0 VA: 0x17CF0C0
	public void .ctor() { }

	// RVA: 0x17CF11C Offset: 0x17CB11C VA: 0x17CF11C
	public void .ctor(string message) { }

	// RVA: 0x17CF140 Offset: 0x17CB140 VA: 0x17CF140
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MemoryMarshal.<ToEnumerable>d__14<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 1044
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	private ReadOnlyMemory<T> memory; // 0x0
	public ReadOnlyMemory<T> <>3__memory; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116F2B8 Offset: 0x116B2B8 VA: 0x116F2B8
	|-MemoryMarshal.<ToEnumerable>d__14<byte>..ctor
	|
	|-RVA: 0x116F4AC Offset: 0x116B4AC VA: 0x116F4AC
	|-MemoryMarshal.<ToEnumerable>d__14<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116F2EC Offset: 0x116B2EC VA: 0x116F2EC
	|-MemoryMarshal.<ToEnumerable>d__14<byte>.System.IDisposable.Dispose
	|
	|-RVA: 0x116F514 Offset: 0x116B514 VA: 0x116F514
	|-MemoryMarshal.<ToEnumerable>d__14<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116F2F0 Offset: 0x116B2F0 VA: 0x116F2F0
	|-MemoryMarshal.<ToEnumerable>d__14<byte>.MoveNext
	|
	|-RVA: 0x116F518 Offset: 0x116B518 VA: 0x116F518
	|-MemoryMarshal.<ToEnumerable>d__14<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 6
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116F39C Offset: 0x116B39C VA: 0x116F39C
	|-MemoryMarshal.<ToEnumerable>d__14<byte>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x116F774 Offset: 0x116B774 VA: 0x116F774
	|-MemoryMarshal.<ToEnumerable>d__14<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116F3A4 Offset: 0x116B3A4 VA: 0x116F3A4
	|-MemoryMarshal.<ToEnumerable>d__14<byte>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x116F7B8 Offset: 0x116B7B8 VA: 0x116F7B8
	|-MemoryMarshal.<ToEnumerable>d__14<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116F3D8 Offset: 0x116B3D8 VA: 0x116F3D8
	|-MemoryMarshal.<ToEnumerable>d__14<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x116F7EC Offset: 0x116B7EC VA: 0x116F7EC
	|-MemoryMarshal.<ToEnumerable>d__14<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116F400 Offset: 0x116B400 VA: 0x116F400
	|-MemoryMarshal.<ToEnumerable>d__14<byte>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	|
	|-RVA: 0x116F890 Offset: 0x116B890 VA: 0x116F890
	|-MemoryMarshal.<ToEnumerable>d__14<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116F49C Offset: 0x116B49C VA: 0x116F49C
	|-MemoryMarshal.<ToEnumerable>d__14<byte>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x116F9A4 Offset: 0x116B9A4 VA: 0x116F9A4
	|-MemoryMarshal.<ToEnumerable>d__14<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: System.Runtime.InteropServices
public static class MemoryMarshal // TypeDefIndex: 1045
{
	// Methods

	// RVA: -1 Offset: -1
	public static Span<byte> AsBytes<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113453C Offset: 0x113053C VA: 0x113453C
	|-MemoryMarshal.AsBytes<char>
	|
	|-RVA: 0x113476C Offset: 0x113076C VA: 0x113476C
	|-MemoryMarshal.AsBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<byte> AsBytes<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11345A0 Offset: 0x11305A0 VA: 0x11345A0
	|-MemoryMarshal.AsBytes<ushort>
	|
	|-RVA: 0x1134604 Offset: 0x1130604 VA: 0x1134604
	|-MemoryMarshal.AsBytes<uint>
	|
	|-RVA: 0x1134668 Offset: 0x1130668 VA: 0x1134668
	|-MemoryMarshal.AsBytes<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static Memory<T> AsMemory<T>(ReadOnlyMemory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1134870 Offset: 0x1130870 VA: 0x1134870
	|-MemoryMarshal.AsMemory<byte>
	|
	|-RVA: 0x1134874 Offset: 0x1130874 VA: 0x1134874
	|-MemoryMarshal.AsMemory<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1134A80 Offset: 0x1130A80 VA: 0x1134A80
	|-MemoryMarshal.GetReference<byte>
	|
	|-RVA: 0x1134A88 Offset: 0x1130A88 VA: 0x1134A88
	|-MemoryMarshal.GetReference<char>
	|
	|-RVA: 0x1134A98 Offset: 0x1130A98 VA: 0x1134A98
	|-MemoryMarshal.GetReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ref T GetReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1134A7C Offset: 0x1130A7C VA: 0x1134A7C
	|-MemoryMarshal.GetReference<byte>
	|
	|-RVA: 0x1134A84 Offset: 0x1130A84 VA: 0x1134A84
	|-MemoryMarshal.GetReference<char>
	|
	|-RVA: 0x1134A8C Offset: 0x1130A8C VA: 0x1134A8C
	|-MemoryMarshal.GetReference<ushort>
	|
	|-RVA: 0x1134A90 Offset: 0x1130A90 VA: 0x1134A90
	|-MemoryMarshal.GetReference<uint>
	|
	|-RVA: 0x1134A94 Offset: 0x1130A94 VA: 0x1134A94
	|-MemoryMarshal.GetReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static ref T GetNonNullPinnableReference<T>(Span<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1134948 Offset: 0x1130948 VA: 0x1134948
	|-MemoryMarshal.GetNonNullPinnableReference<byte>
	|
	|-RVA: 0x11349B0 Offset: 0x11309B0 VA: 0x11349B0
	|-MemoryMarshal.GetNonNullPinnableReference<char>
	|
	|-RVA: 0x1134A30 Offset: 0x1130A30 VA: 0x1134A30
	|-MemoryMarshal.GetNonNullPinnableReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static ref T GetNonNullPinnableReference<T>(ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1134914 Offset: 0x1130914 VA: 0x1134914
	|-MemoryMarshal.GetNonNullPinnableReference<byte>
	|
	|-RVA: 0x113497C Offset: 0x113097C VA: 0x113497C
	|-MemoryMarshal.GetNonNullPinnableReference<char>
	|
	|-RVA: 0x11349E4 Offset: 0x11309E4 VA: 0x11349E4
	|-MemoryMarshal.GetNonNullPinnableReference<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ReadOnlySpan<T> CreateReadOnlySpan<T>(ref T reference, int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1134878 Offset: 0x1130878 VA: 0x1134878
	|-MemoryMarshal.CreateReadOnlySpan<char>
	|
	|-RVA: 0x11348AC Offset: 0x11308AC VA: 0x11348AC
	|-MemoryMarshal.CreateReadOnlySpan<uint>
	|
	|-RVA: 0x11348E0 Offset: 0x11308E0 VA: 0x11348E0
	|-MemoryMarshal.CreateReadOnlySpan<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryGetArray<T>(ReadOnlyMemory<T> memory, out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1134D64 Offset: 0x1130D64 VA: 0x1134D64
	|-MemoryMarshal.TryGetArray<byte>
	|
	|-RVA: 0x1134FC4 Offset: 0x1130FC4 VA: 0x1134FC4
	|-MemoryMarshal.TryGetArray<__Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(MemoryMarshal.<ToEnumerable>d__14<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> ToEnumerable<T>(ReadOnlyMemory<T> memory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1134C4C Offset: 0x1130C4C VA: 0x1134C4C
	|-MemoryMarshal.ToEnumerable<byte>
	|
	|-RVA: 0x1134CCC Offset: 0x1130CCC VA: 0x1134CCC
	|-MemoryMarshal.ToEnumerable<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Read<T>(ReadOnlySpan<byte> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1134A9C Offset: 0x1130A9C VA: 0x1134A9C
	|-MemoryMarshal.Read<ulong>
	|
	|-RVA: 0x1134AFC Offset: 0x1130AFC VA: 0x1134AFC
	|-MemoryMarshal.Read<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static void Write<T>(Span<byte> destination, ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113520C Offset: 0x113120C VA: 0x113520C
	|-MemoryMarshal.Write<uint>
	|
	|-RVA: 0x113527C Offset: 0x113127C VA: 0x113527C
	|-MemoryMarshal.Write<ulong>
	|
	|-RVA: 0x11352EC Offset: 0x11312EC VA: 0x11352EC
	|-MemoryMarshal.Write<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: System.Runtime.InteropServices
public static class SequenceMarshal // TypeDefIndex: 1046
{
	// Methods

	// RVA: 0x17CF148 Offset: 0x17CB148 VA: 0x17CF148
	internal static bool TryGetString(ReadOnlySequence<char> sequence, out string text, out int start, out int length) { }
}

// Namespace: System.Runtime.InteropServices
public enum GCHandleType // TypeDefIndex: 1047
{
	// Fields
	public int value__; // 0x0
	public const GCHandleType Weak = 0;
	public const GCHandleType WeakTrackResurrection = 1;
	public const GCHandleType Normal = 2;
	public const GCHandleType Pinned = 3;
}

// Namespace: System.Runtime.InteropServices
public abstract class SafeBuffer : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 1048
{
	// Fields
	private static readonly UIntPtr Uninitialized; // 0x0
	private UIntPtr _numBytes; // 0x20

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x17CF1DC Offset: 0x17CB1DC VA: 0x17CF1DC
	public void AcquirePointer(ref byte* pointer) { }

	// RVA: 0x17CF3D8 Offset: 0x17CB3D8 VA: 0x17CF3D8
	public void ReleasePointer() { }

	// RVA: 0x17CF2B0 Offset: 0x17CB2B0 VA: 0x17CF2B0
	private static InvalidOperationException NotInitialized() { }

	// RVA: 0x17CF488 Offset: 0x17CB488 VA: 0x17CF488
	private static void .cctor() { }
}

// Namespace: System.Runtime.InteropServices
[Serializable]
public class COMException : ExternalException // TypeDefIndex: 1049
{
	// Methods

	// RVA: 0x17CF4F4 Offset: 0x17CB4F4 VA: 0x17CF4F4
	public void .ctor() { }

	// RVA: 0x17CF4F8 Offset: 0x17CB4F8 VA: 0x17CF4F8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17CF500 Offset: 0x17CB500 VA: 0x17CF500 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.InteropServices
public sealed class ErrorWrapper // TypeDefIndex: 1050
{
	// Fields
	private int m_ErrorCode; // 0x10
}

// Namespace: System.Runtime.InteropServices
public interface ICustomMarshaler // TypeDefIndex: 1051
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object MarshalNativeToManaged(IntPtr pNativeData);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IntPtr MarshalManagedToNative(object ManagedObj);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void CleanUpNativeData(IntPtr pNativeData);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void CleanUpManagedData(object ManagedObj);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int GetNativeDataSize();
}

// Namespace: System.Runtime.InteropServices
[Usage(4096, AllowMultiple = False, Inherited = False)]
[ComVisible(True)]
public sealed class UnmanagedFunctionPointerAttribute : Attribute // TypeDefIndex: 1052
{
	// Fields
	private CallingConvention m_callingConvention; // 0x10

	// Methods

	// RVA: 0x17CF6E8 Offset: 0x17CB6E8 VA: 0x17CF6E8
	public void .ctor(CallingConvention callingConvention) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum ComInterfaceType // TypeDefIndex: 1053
{
	// Fields
	public int value__; // 0x0
	public const ComInterfaceType InterfaceIsDual = 0;
	public const ComInterfaceType InterfaceIsIUnknown = 1;
	public const ComInterfaceType InterfaceIsIDispatch = 2;
	[ComVisible(False)]
	public const ComInterfaceType InterfaceIsIInspectable = 3;
}

// Namespace: System.Runtime.InteropServices
[Usage(1024, Inherited = False)]
[ComVisible(True)]
public sealed class InterfaceTypeAttribute : Attribute // TypeDefIndex: 1054
{
	// Fields
	internal ComInterfaceType _val; // 0x10

	// Methods

	// RVA: 0x17CF710 Offset: 0x17CB710 VA: 0x17CF710
	public void .ctor(ComInterfaceType interfaceType) { }
}

// Namespace: System.Runtime.InteropServices
[Usage(4, Inherited = False)]
[ComVisible(True)]
public sealed class ComDefaultInterfaceAttribute : Attribute // TypeDefIndex: 1055
{
	// Fields
	internal Type _val; // 0x10

	// Methods

	// RVA: 0x17CF738 Offset: 0x17CB738 VA: 0x17CF738
	public void .ctor(Type defaultInterface) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum ClassInterfaceType // TypeDefIndex: 1056
{
	// Fields
	public int value__; // 0x0
	public const ClassInterfaceType None = 0;
	public const ClassInterfaceType AutoDispatch = 1;
	public const ClassInterfaceType AutoDual = 2;
}

// Namespace: System.Runtime.InteropServices
[Usage(5, Inherited = False)]
[ComVisible(True)]
public sealed class ClassInterfaceAttribute : Attribute // TypeDefIndex: 1057
{
	// Fields
	internal ClassInterfaceType _val; // 0x10

	// Methods

	// RVA: 0x17CF768 Offset: 0x17CB768 VA: 0x17CF768
	public void .ctor(ClassInterfaceType classInterfaceType) { }
}

// Namespace: System.Runtime.InteropServices
[Usage(5597, Inherited = False)]
[ComVisible(True)]
public sealed class ComVisibleAttribute : Attribute // TypeDefIndex: 1058
{
	// Fields
	internal bool _val; // 0x10

	// Methods

	// RVA: 0x17CF790 Offset: 0x17CB790 VA: 0x17CF790
	public void .ctor(bool visibility) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum VarEnum // TypeDefIndex: 1059
{
	// Fields
	public int value__; // 0x0
	public const VarEnum VT_EMPTY = 0;
	public const VarEnum VT_NULL = 1;
	public const VarEnum VT_I2 = 2;
	public const VarEnum VT_I4 = 3;
	public const VarEnum VT_R4 = 4;
	public const VarEnum VT_R8 = 5;
	public const VarEnum VT_CY = 6;
	public const VarEnum VT_DATE = 7;
	public const VarEnum VT_BSTR = 8;
	public const VarEnum VT_DISPATCH = 9;
	public const VarEnum VT_ERROR = 10;
	public const VarEnum VT_BOOL = 11;
	public const VarEnum VT_VARIANT = 12;
	public const VarEnum VT_UNKNOWN = 13;
	public const VarEnum VT_DECIMAL = 14;
	public const VarEnum VT_I1 = 16;
	public const VarEnum VT_UI1 = 17;
	public const VarEnum VT_UI2 = 18;
	public const VarEnum VT_UI4 = 19;
	public const VarEnum VT_I8 = 20;
	public const VarEnum VT_UI8 = 21;
	public const VarEnum VT_INT = 22;
	public const VarEnum VT_UINT = 23;
	public const VarEnum VT_VOID = 24;
	public const VarEnum VT_HRESULT = 25;
	public const VarEnum VT_PTR = 26;
	public const VarEnum VT_SAFEARRAY = 27;
	public const VarEnum VT_CARRAY = 28;
	public const VarEnum VT_USERDEFINED = 29;
	public const VarEnum VT_LPSTR = 30;
	public const VarEnum VT_LPWSTR = 31;
	public const VarEnum VT_RECORD = 36;
	public const VarEnum VT_FILETIME = 64;
	public const VarEnum VT_BLOB = 65;
	public const VarEnum VT_STREAM = 66;
	public const VarEnum VT_STORAGE = 67;
	public const VarEnum VT_STREAMED_OBJECT = 68;
	public const VarEnum VT_STORED_OBJECT = 69;
	public const VarEnum VT_BLOB_OBJECT = 70;
	public const VarEnum VT_CF = 71;
	public const VarEnum VT_CLSID = 72;
	public const VarEnum VT_VECTOR = 4096;
	public const VarEnum VT_ARRAY = 8192;
	public const VarEnum VT_BYREF = 16384;
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum UnmanagedType // TypeDefIndex: 1060
{
	// Fields
	public int value__; // 0x0
	public const UnmanagedType Bool = 2;
	public const UnmanagedType I1 = 3;
	public const UnmanagedType U1 = 4;
	public const UnmanagedType I2 = 5;
	public const UnmanagedType U2 = 6;
	public const UnmanagedType I4 = 7;
	public const UnmanagedType U4 = 8;
	public const UnmanagedType I8 = 9;
	public const UnmanagedType U8 = 10;
	public const UnmanagedType R4 = 11;
	public const UnmanagedType R8 = 12;
	public const UnmanagedType Currency = 15;
	public const UnmanagedType BStr = 19;
	public const UnmanagedType LPStr = 20;
	public const UnmanagedType LPWStr = 21;
	public const UnmanagedType LPTStr = 22;
	public const UnmanagedType ByValTStr = 23;
	public const UnmanagedType IUnknown = 25;
	public const UnmanagedType IDispatch = 26;
	public const UnmanagedType Struct = 27;
	public const UnmanagedType Interface = 28;
	public const UnmanagedType SafeArray = 29;
	public const UnmanagedType ByValArray = 30;
	public const UnmanagedType SysInt = 31;
	public const UnmanagedType SysUInt = 32;
	public const UnmanagedType VBByRefStr = 34;
	public const UnmanagedType AnsiBStr = 35;
	public const UnmanagedType TBStr = 36;
	public const UnmanagedType VariantBool = 37;
	public const UnmanagedType FunctionPtr = 38;
	public const UnmanagedType AsAny = 40;
	public const UnmanagedType LPArray = 42;
	public const UnmanagedType LPStruct = 43;
	public const UnmanagedType CustomMarshaler = 44;
	public const UnmanagedType Error = 45;
	[ComVisible(False)]
	public const UnmanagedType IInspectable = 46;
	[ComVisible(False)]
	public const UnmanagedType HString = 47;
	[ComVisible(False)]
	public const UnmanagedType LPUTF8Str = 48;
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Usage(1028, Inherited = False)]
public sealed class ComImportAttribute : Attribute // TypeDefIndex: 1061
{
	// Methods

	// RVA: 0x17CF7B8 Offset: 0x17CB7B8 VA: 0x17CF7B8
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Usage(5149, Inherited = False)]
public sealed class GuidAttribute : Attribute // TypeDefIndex: 1062
{
	// Fields
	internal string _val; // 0x10

	// Methods

	// RVA: 0x17CF7C0 Offset: 0x17CB7C0 VA: 0x17CF7C0
	public void .ctor(string guid) { }
}

// Namespace: System.Runtime.InteropServices
[Usage(64, Inherited = False)]
[ComVisible(True)]
public sealed class PreserveSigAttribute : Attribute // TypeDefIndex: 1063
{
	// Methods

	// RVA: 0x17CF7F0 Offset: 0x17CB7F0 VA: 0x17CF7F0
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[Usage(2048, Inherited = False)]
[ComVisible(True)]
public sealed class InAttribute : Attribute // TypeDefIndex: 1064
{
	// Methods

	// RVA: 0x17CF7F8 Offset: 0x17CB7F8 VA: 0x17CF7F8
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[Usage(2048, Inherited = False)]
[ComVisible(True)]
public sealed class OutAttribute : Attribute // TypeDefIndex: 1065
{
	// Methods

	// RVA: 0x17CF800 Offset: 0x17CB800 VA: 0x17CF800
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[Usage(2048, Inherited = False)]
[ComVisible(True)]
public sealed class OptionalAttribute : Attribute // TypeDefIndex: 1066
{
	// Methods

	// RVA: 0x17CF808 Offset: 0x17CB808 VA: 0x17CF808
	public void .ctor() { }
}

// Namespace: System.Runtime.InteropServices
[Flags]
public enum DllImportSearchPath // TypeDefIndex: 1067
{
	// Fields
	public int value__; // 0x0
	public const DllImportSearchPath UseDllDirectoryForDependencies = 256;
	public const DllImportSearchPath ApplicationDirectory = 512;
	public const DllImportSearchPath UserDirectories = 1024;
	public const DllImportSearchPath System32 = 2048;
	public const DllImportSearchPath SafeDirectories = 4096;
	public const DllImportSearchPath AssemblyDirectory = 2;
	public const DllImportSearchPath LegacyBehavior = 0;
}

// Namespace: System.Runtime.InteropServices
[Usage(65, AllowMultiple = False)]
[ComVisible(False)]
public sealed class DefaultDllImportSearchPathsAttribute : Attribute // TypeDefIndex: 1068
{
	// Fields
	internal DllImportSearchPath _paths; // 0x10

	// Methods

	// RVA: 0x17CF810 Offset: 0x17CB810 VA: 0x17CF810
	public void .ctor(DllImportSearchPath paths) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Usage(64, Inherited = False)]
public sealed class DllImportAttribute : Attribute // TypeDefIndex: 1069
{
	// Fields
	internal string _val; // 0x10
	public string EntryPoint; // 0x18
	public CharSet CharSet; // 0x20
	public bool SetLastError; // 0x24
	public bool ExactSpelling; // 0x25
	public bool PreserveSig; // 0x26
	public CallingConvention CallingConvention; // 0x28
	public bool BestFitMapping; // 0x2C
	public bool ThrowOnUnmappableChar; // 0x2D

	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0x17CF838 Offset: 0x17CB838 VA: 0x17CF838
	internal static Attribute GetCustomAttribute(RuntimeMethodInfo method) { }

	// RVA: 0x17CFA80 Offset: 0x17CBA80 VA: 0x17CFA80
	internal static bool IsDefined(RuntimeMethodInfo method) { }

	// RVA: 0x17CF9E0 Offset: 0x17CB9E0 VA: 0x17CF9E0
	internal void .ctor(string dllName, string entryPoint, CharSet charSet, bool exactSpelling, bool setLastError, bool preserveSig, CallingConvention callingConvention, bool bestFitMapping, bool throwOnUnmappableChar) { }

	// RVA: 0x17CFAA8 Offset: 0x17CBAA8 VA: 0x17CFAA8
	public void .ctor(string dllName) { }

	// RVA: 0x17CFAD8 Offset: 0x17CBAD8 VA: 0x17CFAD8
	public string get_Value() { }
}

// Namespace: System.Runtime.InteropServices
[Usage(256, Inherited = False)]
[ComVisible(True)]
public sealed class FieldOffsetAttribute : Attribute // TypeDefIndex: 1070
{
	// Fields
	internal int _val; // 0x10

	// Methods

	// RVA: 0x17CFAE0 Offset: 0x17CBAE0 VA: 0x17CFAE0
	public void .ctor(int offset) { }
}

// Namespace: System.Runtime.InteropServices
[Usage(1, Inherited = False)]
[ComVisible(True)]
public sealed class ComCompatibleVersionAttribute : Attribute // TypeDefIndex: 1071
{
	// Fields
	internal int _major; // 0x10
	internal int _minor; // 0x14
	internal int _build; // 0x18
	internal int _revision; // 0x1C

	// Methods

	// RVA: 0x17CFB08 Offset: 0x17CBB08 VA: 0x17CFB08
	public void .ctor(int major, int minor, int build, int revision) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Serializable]
public enum CallingConvention // TypeDefIndex: 1072
{
	// Fields
	public int value__; // 0x0
	public const CallingConvention Winapi = 1;
	public const CallingConvention Cdecl = 2;
	public const CallingConvention StdCall = 3;
	public const CallingConvention ThisCall = 4;
	public const CallingConvention FastCall = 5;
}

// Namespace: System.Runtime.InteropServices
public abstract class SafeHandle : CriticalFinalizerObject, IDisposable // TypeDefIndex: 1073
{
	// Fields
	protected IntPtr handle; // 0x10
	private int _state; // 0x18
	private bool _ownsHandle; // 0x1C
	private bool _fullyInitialized; // 0x1D
	private const int RefCount_Mask = 2147483644;
	private const int RefCount_One = 4;

	// Properties
	public bool IsClosed { get; }
	public abstract bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x17CFB48 Offset: 0x17CBB48 VA: 0x17CFB48
	protected void .ctor(IntPtr invalidHandleValue, bool ownsHandle) { }

	// RVA: 0x17CFBE8 Offset: 0x17CBBE8 VA: 0x17CFBE8 Slot: 1
	protected override void Finalize() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17CFC78 Offset: 0x17CBC78 VA: 0x17CFC78
	protected void SetHandle(IntPtr handle) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17CFC80 Offset: 0x17CBC80 VA: 0x17CFC80
	public IntPtr DangerousGetHandle() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17CFC88 Offset: 0x17CBC88 VA: 0x17CFC88
	public bool get_IsClosed() { }

	[ReliabilityContract(3, 2)]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsInvalid();

	[ReliabilityContract(3, 2)]
	// RVA: 0x17CFC94 Offset: 0x17CBC94 VA: 0x17CFC94
	public void Close() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17CFCA4 Offset: 0x17CBCA4 VA: 0x17CFCA4 Slot: 4
	public void Dispose() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17CFCB4 Offset: 0x17CBCB4 VA: 0x17CFCB4 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	[ReliabilityContract(3, 2)]
	// RVA: -1 Offset: -1 Slot: 7
	protected abstract bool ReleaseHandle();

	[ReliabilityContract(3, 2)]
	// RVA: 0x17CFD84 Offset: 0x17CBD84 VA: 0x17CFD84
	public void SetHandleAsInvalid() { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x17CF31C Offset: 0x17CB31C VA: 0x17CF31C
	public void DangerousAddRef(ref bool success) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17CF480 Offset: 0x17CB480 VA: 0x17CF480
	public void DangerousRelease() { }

	// RVA: 0x17CFCD0 Offset: 0x17CBCD0 VA: 0x17CFCD0
	private void InternalDispose() { }

	// RVA: 0x17CFD70 Offset: 0x17CBD70 VA: 0x17CFD70
	private void InternalFinalize() { }

	// RVA: 0x17CFDFC Offset: 0x17CBDFC VA: 0x17CFDFC
	private void DangerousReleaseInternal(bool dispose) { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
public struct GCHandle // TypeDefIndex: 1074
{
	// Fields
	private IntPtr handle; // 0x0

	// Properties
	public bool IsAllocated { get; }
	public object Target { get; set; }

	// Methods

	// RVA: 0x17CFF34 Offset: 0x17CBF34 VA: 0x17CFF34
	private void .ctor(IntPtr h) { }

	// RVA: 0x17CFF3C Offset: 0x17CBF3C VA: 0x17CFF3C
	private void .ctor(object obj) { }

	// RVA: 0x17CFF60 Offset: 0x17CBF60 VA: 0x17CFF60
	internal void .ctor(object value, GCHandleType type) { }

	// RVA: 0x17CFF90 Offset: 0x17CBF90 VA: 0x17CFF90
	public bool get_IsAllocated() { }

	// RVA: 0x17CFFA0 Offset: 0x17CBFA0 VA: 0x17CFFA0
	internal static object GetRef(IntPtr handle) { }

	// RVA: 0x17CFFB8 Offset: 0x17CBFB8 VA: 0x17CFFB8
	internal static void SetRef(IntPtr handle, object value) { }

	// RVA: 0x17CFFD8 Offset: 0x17CBFD8 VA: 0x17CFFD8
	internal static bool CanDereferenceHandle(IntPtr handle) { }

	// RVA: 0x17CFFE4 Offset: 0x17CBFE4 VA: 0x17CFFE4
	public object get_Target() { }

	// RVA: 0x17D005C Offset: 0x17CC05C VA: 0x17D005C
	public void set_Target(object value) { }

	// RVA: 0x17D00B4 Offset: 0x17CC0B4 VA: 0x17D00B4
	public IntPtr AddrOfPinnedObject() { }

	// RVA: 0x17D0178 Offset: 0x17CC178 VA: 0x17D0178
	public static GCHandle Alloc(object value) { }

	// RVA: 0x17D0184 Offset: 0x17CC184 VA: 0x17D0184
	public static GCHandle Alloc(object value, GCHandleType type) { }

	// RVA: 0x17D0198 Offset: 0x17CC198 VA: 0x17D0198
	public void Free() { }

	// RVA: 0x17D0214 Offset: 0x17CC214 VA: 0x17D0214
	public static IntPtr op_Explicit(GCHandle value) { }

	// RVA: 0x17D0218 Offset: 0x17CC218 VA: 0x17D0218
	public static GCHandle op_Explicit(IntPtr value) { }

	// RVA: 0x17D02B4 Offset: 0x17CC2B4 VA: 0x17D02B4
	private static bool CheckCurrentDomain(IntPtr handle) { }

	// RVA: 0x17D0058 Offset: 0x17CC058 VA: 0x17D0058
	private static object GetTarget(IntPtr handle) { }

	// RVA: 0x17CFF8C Offset: 0x17CBF8C VA: 0x17CFF8C
	private static IntPtr GetTargetHandle(object obj, IntPtr handle, GCHandleType type) { }

	// RVA: 0x17D0210 Offset: 0x17CC210 VA: 0x17D0210
	private static void FreeHandle(IntPtr handle) { }

	// RVA: 0x17D0174 Offset: 0x17CC174 VA: 0x17D0174
	private static IntPtr GetAddrOfPinnedObject(IntPtr handle) { }

	// RVA: 0x17D02B8 Offset: 0x17CC2B8 VA: 0x17D02B8
	public static bool op_Equality(GCHandle a, GCHandle b) { }

	// RVA: 0x17D02C4 Offset: 0x17CC2C4 VA: 0x17D02C4 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x17D033C Offset: 0x17CC33C VA: 0x17D033C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17D0344 Offset: 0x17CC344 VA: 0x17D0344
	public static GCHandle FromIntPtr(IntPtr value) { }

	// RVA: 0x17D0348 Offset: 0x17CC348 VA: 0x17D0348
	public static IntPtr ToIntPtr(GCHandle value) { }
}

// Namespace: 
internal sealed class Marshal.SecureStringAllocator : MulticastDelegate // TypeDefIndex: 1075
{
	// Methods

	// RVA: 0x17D0F40 Offset: 0x17CCF40 VA: 0x17D0F40
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17D1A20 Offset: 0x17CDA20 VA: 0x17D1A20 Slot: 12
	public virtual IntPtr Invoke(int len) { }
}

// Namespace: 
internal class Marshal.MarshalerInstanceKeyComparer : IEqualityComparer<ValueTuple<Type, string>> // TypeDefIndex: 1076
{
	// Methods

	// RVA: 0x17D1A34 Offset: 0x17CDA34 VA: 0x17D1A34 Slot: 4
	public bool Equals(ValueTuple<Type, string> lhs, ValueTuple<Type, string> rhs) { }

	// RVA: 0x17D1AA8 Offset: 0x17CDAA8 VA: 0x17D1AA8 Slot: 5
	public int GetHashCode(ValueTuple<Type, string> key) { }

	// RVA: 0x17D1AFC Offset: 0x17CDAFC VA: 0x17D1AFC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Marshal.<>c // TypeDefIndex: 1077
{
	// Fields
	public static readonly Marshal.<>c <>9; // 0x0
	public static Func<Dictionary<ValueTuple<Type, string>, ICustomMarshaler>> <>9__201_0; // 0x8

	// Methods

	// RVA: 0x17D1B04 Offset: 0x17CDB04 VA: 0x17D1B04
	private static void .cctor() { }

	// RVA: 0x17D1B6C Offset: 0x17CDB6C VA: 0x17D1B6C
	public void .ctor() { }

	// RVA: 0x17D1B74 Offset: 0x17CDB74 VA: 0x17D1B74
	internal Dictionary<ValueTuple<Type, string>, ICustomMarshaler> <GetCustomMarshalerInstance>b__201_0() { }
}

// Namespace: System.Runtime.InteropServices
public static class Marshal // TypeDefIndex: 1078
{
	// Fields
	public static readonly int SystemMaxDBCSCharSize; // 0x0
	public static readonly int SystemDefaultCharSize; // 0x4
	internal static Dictionary<ValueTuple<Type, string>, ICustomMarshaler> MarshalerInstanceCache; // 0x8
	internal static readonly object MarshalerInstanceCacheLock; // 0x10

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x17D034C Offset: 0x17CC34C VA: 0x17D034C
	public static IntPtr AllocHGlobal(IntPtr cb) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x17D0350 Offset: 0x17CC350 VA: 0x17D0350
	public static IntPtr AllocHGlobal(int cb) { }

	// RVA: 0x17D03B8 Offset: 0x17CC3B8 VA: 0x17D03B8
	private static void copy_to_unmanaged_fixed(Array source, int startIndex, IntPtr destination, int length, void* fixed_source_element) { }

	// RVA: 0x17D03BC Offset: 0x17CC3BC VA: 0x17D03BC
	private static bool skip_fixed(Array array, int startIndex) { }

	// RVA: 0x17D03F0 Offset: 0x17CC3F0 VA: 0x17D03F0
	internal static void copy_to_unmanaged(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x17D04D4 Offset: 0x17CC4D4 VA: 0x17D04D4
	public static void Copy(byte[] source, int startIndex, IntPtr destination, int length) { }

	// RVA: 0x17D05C4 Offset: 0x17CC5C4 VA: 0x17D05C4
	internal static void copy_from_unmanaged(IntPtr source, int startIndex, Array destination, int length) { }

	// RVA: 0x17D0644 Offset: 0x17CC644 VA: 0x17D0644
	private static void copy_from_unmanaged_fixed(IntPtr source, int startIndex, Array destination, int length, void* fixed_destination_element) { }

	// RVA: 0x17D0648 Offset: 0x17CC648 VA: 0x17D0648
	public static void Copy(IntPtr source, byte[] destination, int startIndex, int length) { }

	// RVA: 0x17D0738 Offset: 0x17CC738 VA: 0x17D0738
	public static void Copy(IntPtr source, char[] destination, int startIndex, int length) { }

	// RVA: 0x17D0828 Offset: 0x17CC828 VA: 0x17D0828
	public static void FreeBSTR(IntPtr ptr) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17D082C Offset: 0x17CC82C VA: 0x17D082C
	public static void FreeHGlobal(IntPtr hglobal) { }

	// RVA: 0x17D0830 Offset: 0x17CC830 VA: 0x17D0830
	private static void ClearAnsi(IntPtr ptr) { }

	// RVA: 0x17D090C Offset: 0x17CC90C VA: 0x17D090C
	private static void ClearUnicode(IntPtr ptr) { }

	// RVA: 0x17D0A28 Offset: 0x17CCA28 VA: 0x17D0A28
	public static void ZeroFreeGlobalAllocAnsi(IntPtr s) { }

	// RVA: 0x17D0A84 Offset: 0x17CCA84 VA: 0x17D0A84
	public static void ZeroFreeGlobalAllocUnicode(IntPtr s) { }

	// RVA: 0x17D0AE0 Offset: 0x17CCAE0 VA: 0x17D0AE0
	public static int GetHRForException(Exception e) { }

	// RVA: 0x17D0AEC Offset: 0x17CCAEC VA: 0x17D0AEC
	public static bool IsComObject(object o) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x17D0AF4 Offset: 0x17CCAF4 VA: 0x17D0AF4
	public static int GetLastWin32Error() { }

	// RVA: 0x17D0AF8 Offset: 0x17CCAF8 VA: 0x17D0AF8
	public static string PtrToStringAnsi(IntPtr ptr) { }

	// RVA: 0x17D0AFC Offset: 0x17CCAFC VA: 0x17D0AFC
	public static string PtrToStringAnsi(IntPtr ptr, int len) { }

	// RVA: 0x17D0B00 Offset: 0x17CCB00 VA: 0x17D0B00
	public static string PtrToStringUni(IntPtr ptr) { }

	[ComVisible(True)]
	// RVA: 0x17D0B04 Offset: 0x17CCB04 VA: 0x17D0B04
	public static object PtrToStructure(IntPtr ptr, Type structureType) { }

	// RVA: -1 Offset: -1
	public static T PtrToStructure<T>(IntPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1131F14 Offset: 0x112DF14 VA: 0x1131F14
	|-Marshal.PtrToStructure<object>
	|
	|-RVA: 0x1131FF8 Offset: 0x112DFF8 VA: 0x1131FF8
	|-Marshal.PtrToStructure<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17D08F0 Offset: 0x17CC8F0 VA: 0x17D08F0
	public static byte ReadByte(IntPtr ptr, int ofs) { }

	// RVA: 0x17D09E4 Offset: 0x17CC9E4 VA: 0x17D09E4
	public static short ReadInt16(IntPtr ptr, int ofs) { }

	// RVA: 0x17D0B08 Offset: 0x17CCB08 VA: 0x17D0B08
	public static int SizeOf(Type t) { }

	// RVA: 0x17D0B0C Offset: 0x17CCB0C VA: 0x17D0B0C
	private static IntPtr StringToHGlobalAnsi(char* s, int length) { }

	// RVA: 0x17D0B10 Offset: 0x17CCB10 VA: 0x17D0B10
	public static IntPtr StringToHGlobalAnsi(string s) { }

	// RVA: 0x17D0B84 Offset: 0x17CCB84 VA: 0x17D0B84
	internal static IntPtr SecureStringGlobalAllocator(int len) { }

	// RVA: 0x17D0BD8 Offset: 0x17CCBD8 VA: 0x17D0BD8
	internal static IntPtr SecureStringToUnicode(SecureString s, Marshal.SecureStringAllocator allocator) { }

	// RVA: 0x17D0E5C Offset: 0x17CCE5C VA: 0x17D0E5C
	public static IntPtr SecureStringToGlobalAllocUnicode(SecureString s) { }

	[ReliabilityContract(3, 1)]
	[ComVisible(True)]
	// RVA: 0x17D0FE0 Offset: 0x17CCFE0 VA: 0x17D0FE0
	public static void StructureToPtr(object structure, IntPtr ptr, bool fDeleteOld) { }

	// RVA: -1 Offset: -1
	public static void StructureToPtr<T>(T structure, IntPtr ptr, bool fDeleteOld) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1132134 Offset: 0x112E134 VA: 0x1132134
	|-Marshal.StructureToPtr<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x1132234 Offset: 0x112E234 VA: 0x1132234
	|-Marshal.StructureToPtr<Position.Sequential.Node>
	*/

	// RVA: 0x17D0FE4 Offset: 0x17CCFE4 VA: 0x17D0FE4
	public static IntPtr UnsafeAddrOfPinnedArrayElement(Array arr, int index) { }

	// RVA: -1 Offset: -1
	public static IntPtr UnsafeAddrOfPinnedArrayElement<T>(T[] arr, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11322CC Offset: 0x112E2CC VA: 0x11322CC
	|-Marshal.UnsafeAddrOfPinnedArrayElement<byte>
	|
	|-RVA: 0x1132334 Offset: 0x112E334 VA: 0x1132334
	|-Marshal.UnsafeAddrOfPinnedArrayElement<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17D08CC Offset: 0x17CC8CC VA: 0x17D08CC
	public static void WriteByte(IntPtr ptr, int ofs, byte val) { }

	// RVA: 0x17D099C Offset: 0x17CC99C VA: 0x17D099C
	public static void WriteInt16(IntPtr ptr, int ofs, short val) { }

	// RVA: 0x17D0FE8 Offset: 0x17CCFE8 VA: 0x17D0FE8
	private static IntPtr GetFunctionPointerForDelegateInternal(Delegate d) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetFunctionPointerForDelegate<TDelegate>(TDelegate d) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1131C54 Offset: 0x112DC54 VA: 0x1131C54
	|-Marshal.GetFunctionPointerForDelegate<object>
	|
	|-RVA: 0x1131D38 Offset: 0x112DD38 VA: 0x1131D38
	|-Marshal.GetFunctionPointerForDelegate<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17D0FEC Offset: 0x17CCFEC VA: 0x17D0FEC
	internal static ICustomMarshaler GetCustomMarshalerInstance(Type type, string cookie) { }

	// RVA: 0x17D197C Offset: 0x17CD97C VA: 0x17D197C
	private static void .cctor() { }
}

// Namespace: System.Runtime.InteropServices
[Usage(10496, Inherited = False)]
[ComVisible(True)]
public sealed class MarshalAsAttribute : Attribute // TypeDefIndex: 1079
{
	// Fields
	public string MarshalCookie; // 0x10
	[ComVisible(True)]
	public string MarshalType; // 0x18
	[ComVisible(True)]
	public Type MarshalTypeRef; // 0x20
	public Type SafeArrayUserDefinedSubType; // 0x28
	private UnmanagedType utype; // 0x30
	public UnmanagedType ArraySubType; // 0x34
	public VarEnum SafeArraySubType; // 0x38
	public int SizeConst; // 0x3C
	public int IidParameterIndex; // 0x40
	public short SizeParamIndex; // 0x44

	// Properties
	public UnmanagedType Value { get; }

	// Methods

	// RVA: 0x17D1C10 Offset: 0x17CDC10 VA: 0x17D1C10
	public void .ctor(UnmanagedType unmanagedType) { }

	// RVA: 0x17D1C38 Offset: 0x17CDC38 VA: 0x17D1C38
	public UnmanagedType get_Value() { }

	// RVA: 0x17D1C40 Offset: 0x17CDC40 VA: 0x17D1C40
	internal MarshalAsAttribute Copy() { }
}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[Guid("03973551-57A1-3900-A2B5-9083E3FF2943")]
[InterfaceType(1)]
[CLSCompliant(False)]
public interface _Activator // TypeDefIndex: 1080
{}

// Namespace: System.Runtime.InteropServices
[InterfaceType(0)]
[Guid("17156360-2F1A-384A-BC52-FDE93C215C5B")]
[CLSCompliant(False)]
[ComVisible(True)]
public interface _Assembly // TypeDefIndex: 1081
{}

// Namespace: System.Runtime.InteropServices
[Guid("B42B6AAC-317E-34D5-9FA9-093BB4160C50")]
[InterfaceType(1)]
[CLSCompliant(False)]
[ComVisible(True)]
public interface _AssemblyName // TypeDefIndex: 1082
{}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[InterfaceType(1)]
[Guid("D002E9BA-D9E3-3749-B1D3-D565A08B13E7")]
[CLSCompliant(False)]
public interface _Module // TypeDefIndex: 1083
{}

// Namespace: System.Runtime.InteropServices
[ComVisible(True)]
[CLSCompliant(False)]
[Guid("993634C4-E47A-32CC-BE08-85F567DC27D6")]
[InterfaceType(1)]
public interface _ParameterInfo // TypeDefIndex: 1084
{}
