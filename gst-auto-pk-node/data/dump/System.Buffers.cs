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

// Namespace: System.Buffers
public sealed class SpanAction<T, TArg> : MulticastDelegate // TypeDefIndex: 1522
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1458490 Offset: 0x1454490 VA: 0x1458490
	|-SpanAction<char, ReadOnlySequence<char>>..ctor
	|
	|-RVA: 0x145856C Offset: 0x145456C VA: 0x145856C
	|-SpanAction<char, ValueTuple<object, int, int>>..ctor
	|
	|-RVA: 0x1458620 Offset: 0x1454620 VA: 0x1458620
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, bool>>..ctor
	|
	|-RVA: 0x14586F4 Offset: 0x14546F4 VA: 0x14586F4
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>>..ctor
	|
	|-RVA: 0x14587D0 Offset: 0x14547D0 VA: 0x14587D0
	|-SpanAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(Span<T> span, TArg arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1458530 Offset: 0x1454530 VA: 0x1458530
	|-SpanAction<char, ReadOnlySequence<char>>.Invoke
	|
	|-RVA: 0x145860C Offset: 0x145460C VA: 0x145860C
	|-SpanAction<char, ValueTuple<object, int, int>>.Invoke
	|
	|-RVA: 0x14586C0 Offset: 0x14546C0 VA: 0x14586C0
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, bool>>.Invoke
	|
	|-RVA: 0x1458794 Offset: 0x1454794 VA: 0x1458794
	|-SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>>.Invoke
	|
	|-RVA: 0x1458874 Offset: 0x1454874 VA: 0x1458874
	|-SpanAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System.Buffers
public abstract class ArrayPool<T> // TypeDefIndex: 1523
{
	// Fields
	[CompilerGenerated]
	private static readonly ArrayPool<T> <Shared>k__BackingField; // 0x0

	// Properties
	public static ArrayPool<T> Shared { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static ArrayPool<T> get_Shared() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x117A810 Offset: 0x1176810 VA: 0x117A810
	|-ArrayPool<byte>.get_Shared
	|
	|-RVA: 0x117A974 Offset: 0x1176974 VA: 0x117A974
	|-ArrayPool<char>.get_Shared
	|
	|-RVA: 0x117AAD8 Offset: 0x1176AD8 VA: 0x117AAD8
	|-ArrayPool<int>.get_Shared
	|
	|-RVA: 0x117AC3C Offset: 0x1176C3C VA: 0x117AC3C
	|-ArrayPool<__Il2CppFullySharedGenericType>.get_Shared
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract T[] Rent(int minimumLength);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Return(T[] array, bool clearArray = False);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ArrayPool<__Il2CppFullySharedGenericType>.Return
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x117A88C Offset: 0x117688C VA: 0x117A88C
	|-ArrayPool<byte>..ctor
	|
	|-RVA: 0x117A9F0 Offset: 0x11769F0 VA: 0x117A9F0
	|-ArrayPool<char>..ctor
	|
	|-RVA: 0x117AB54 Offset: 0x1176B54 VA: 0x117AB54
	|-ArrayPool<int>..ctor
	|
	|-RVA: 0x117ACB8 Offset: 0x1176CB8 VA: 0x117ACB8
	|-ArrayPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x117A894 Offset: 0x1176894 VA: 0x117A894
	|-ArrayPool<byte>..cctor
	|
	|-RVA: 0x117A9F8 Offset: 0x11769F8 VA: 0x117A9F8
	|-ArrayPool<char>..cctor
	|
	|-RVA: 0x117AB5C Offset: 0x1176B5C VA: 0x117AB5C
	|-ArrayPool<int>..cctor
	|
	|-RVA: 0x117ACC0 Offset: 0x1176CC0 VA: 0x117ACC0
	|-ArrayPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
internal enum ArrayPoolEventSource.BufferAllocatedReason // TypeDefIndex: 1524
{
	// Fields
	public int value__; // 0x0
	public const ArrayPoolEventSource.BufferAllocatedReason Pooled = 0;
	public const ArrayPoolEventSource.BufferAllocatedReason OverMaximumSize = 1;
	public const ArrayPoolEventSource.BufferAllocatedReason PoolExhausted = 2;
}

// Namespace: System.Buffers
[EventSource(Guid = "0866B2B8-5CEF-5DB9-2612-0C0FFD814A44", Name = "System.Buffers.ArrayPoolEventSource")]
internal sealed class ArrayPoolEventSource : EventSource // TypeDefIndex: 1525
{
	// Fields
	internal static readonly ArrayPoolEventSource Log; // 0x0

	// Methods

	// RVA: 0x1852F9C Offset: 0x184EF9C VA: 0x1852F9C
	private void .ctor() { }

	[Event(1, Level = 5)]
	// RVA: 0x1853054 Offset: 0x184F054 VA: 0x1853054
	internal void BufferRented(int bufferId, int bufferSize, int poolId, int bucketId) { }

	[Event(2, Level = 4)]
	// RVA: 0x1853140 Offset: 0x184F140 VA: 0x1853140
	internal void BufferAllocated(int bufferId, int bufferSize, int poolId, int bucketId, ArrayPoolEventSource.BufferAllocatedReason reason) { }

	[Event(3, Level = 5)]
	// RVA: 0x185324C Offset: 0x184F24C VA: 0x185324C
	internal void BufferReturned(int bufferId, int bufferSize, int poolId) { }

	[Event(4, Level = 4)]
	// RVA: 0x185325C Offset: 0x184F25C VA: 0x185325C
	internal void BufferTrimmed(int bufferId, int bufferSize, int poolId) { }

	[Event(5, Level = 4)]
	// RVA: 0x185326C Offset: 0x184F26C VA: 0x185326C
	internal void BufferTrimPoll(int milliseconds, int pressure) { }

	// RVA: 0x1853278 Offset: 0x184F278 VA: 0x1853278
	private static void .cctor() { }
}

// Namespace: System.Buffers
public interface IPinnable // TypeDefIndex: 1526
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Unpin();
}

// Namespace: System.Buffers
public struct MemoryHandle : IDisposable // TypeDefIndex: 1527
{
	// Fields
	private void* _pointer; // 0x0
	private GCHandle _handle; // 0x8
	private IPinnable _pinnable; // 0x10

	// Properties
	[CLSCompliant(False)]
	public void* Pointer { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x18532DC Offset: 0x184F2DC VA: 0x18532DC
	public void .ctor(void* pointer, GCHandle handle, IPinnable pinnable) { }

	// RVA: 0x18532EC Offset: 0x184F2EC VA: 0x18532EC
	public void* get_Pointer() { }

	// RVA: 0x18532F4 Offset: 0x184F2F4 VA: 0x18532F4 Slot: 4
	public void Dispose() { }
}

// Namespace: System.Buffers
public abstract class MemoryManager<T> // TypeDefIndex: 1528
{
	// Properties
	public virtual Memory<T> Memory { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public virtual Memory<T> get_Memory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A3E18 Offset: 0x139FE18 VA: 0x13A3E18
	|-MemoryManager<byte>.get_Memory
	|
	|-RVA: 0x13A3E80 Offset: 0x139FE80 VA: 0x13A3E80
	|-MemoryManager<char>.get_Memory
	|
	|-RVA: 0x13A3EE8 Offset: 0x139FEE8 VA: 0x13A3EE8
	|-MemoryManager<__Il2CppFullySharedGenericType>.get_Memory
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Span<T> GetSpan();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemoryManager<__Il2CppFullySharedGenericType>.GetSpan
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract MemoryHandle Pin(int elementIndex = 0);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-MemoryManager<__Il2CppFullySharedGenericType>.Pin
	*/

	// RVA: -1 Offset: -1 Slot: 7
	protected internal virtual bool TryGetArray(out ArraySegment<T> segment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A3E74 Offset: 0x139FE74 VA: 0x13A3E74
	|-MemoryManager<byte>.TryGetArray
	|
	|-RVA: 0x13A3EDC Offset: 0x139FEDC VA: 0x13A3EDC
	|-MemoryManager<char>.TryGetArray
	|
	|-RVA: 0x13A3F6C Offset: 0x139FF6C VA: 0x13A3F6C
	|-MemoryManager<__Il2CppFullySharedGenericType>.TryGetArray
	*/
}

// Namespace: 
private enum TlsOverPerCoreLockedStacksArrayPool.MemoryPressure<T> // TypeDefIndex: 1529
{
	// Fields
	public int value__; // 0x0
	public const TlsOverPerCoreLockedStacksArrayPool.MemoryPressure<T> Low = 0;
	public const TlsOverPerCoreLockedStacksArrayPool.MemoryPressure<T> Medium = 1;
	public const TlsOverPerCoreLockedStacksArrayPool.MemoryPressure<T> High = 2;
}

// Namespace: 
private sealed class TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<T> // TypeDefIndex: 1530
{
	// Fields
	private readonly TlsOverPerCoreLockedStacksArrayPool.LockedStack<T>[] _perCoreStacks; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FED84 Offset: 0x13FAD84 VA: 0x13FED84
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<byte>..ctor
	|
	|-RVA: 0x13FF19C Offset: 0x13FB19C VA: 0x13FF19C
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<char>..ctor
	|
	|-RVA: 0x13FF5B4 Offset: 0x13FB5B4 VA: 0x13FF5B4
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<int>..ctor
	|
	|-RVA: 0x13FF9CC Offset: 0x13FB9CC VA: 0x13FF9CC
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void TryPush(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FEEE0 Offset: 0x13FAEE0 VA: 0x13FEEE0
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<byte>.TryPush
	|
	|-RVA: 0x13FF2F8 Offset: 0x13FB2F8 VA: 0x13FF2F8
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<char>.TryPush
	|
	|-RVA: 0x13FF710 Offset: 0x13FB710 VA: 0x13FF710
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<int>.TryPush
	|
	|-RVA: 0x13FFB2C Offset: 0x13FBB2C VA: 0x13FFB2C
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<__Il2CppFullySharedGenericType>.TryPush
	*/

	// RVA: -1 Offset: -1
	public T[] TryPop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FEFB8 Offset: 0x13FAFB8 VA: 0x13FEFB8
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<byte>.TryPop
	|
	|-RVA: 0x13FF3D0 Offset: 0x13FB3D0 VA: 0x13FF3D0
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<char>.TryPop
	|
	|-RVA: 0x13FF7E8 Offset: 0x13FB7E8 VA: 0x13FF7E8
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<int>.TryPop
	|
	|-RVA: 0x13FFC08 Offset: 0x13FBC08 VA: 0x13FFC08
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<__Il2CppFullySharedGenericType>.TryPop
	*/

	// RVA: -1 Offset: -1
	public bool Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool.MemoryPressure<T> pressure, int[] bucketSizes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FF0E0 Offset: 0x13FB0E0 VA: 0x13FF0E0
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<byte>.Trim
	|
	|-RVA: 0x13FF4F8 Offset: 0x13FB4F8 VA: 0x13FF4F8
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<char>.Trim
	|
	|-RVA: 0x13FF910 Offset: 0x13FB910 VA: 0x13FF910
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<int>.Trim
	|
	|-RVA: 0x13FFCE0 Offset: 0x13FBCE0 VA: 0x13FFCE0
	|-TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<__Il2CppFullySharedGenericType>.Trim
	*/
}

// Namespace: 
private sealed class TlsOverPerCoreLockedStacksArrayPool.LockedStack<T> // TypeDefIndex: 1531
{
	// Fields
	private readonly T[][] _arrays; // 0x0
	private int _count; // 0x0
	private uint _firstStackItemMS; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public bool TryPush(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x138FB0C Offset: 0x138BB0C VA: 0x138FB0C
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<byte>.TryPush
	|
	|-RVA: 0x138FF2C Offset: 0x138BF2C VA: 0x138FF2C
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<char>.TryPush
	|
	|-RVA: 0x139034C Offset: 0x138C34C VA: 0x139034C
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<int>.TryPush
	|
	|-RVA: 0x139076C Offset: 0x138C76C VA: 0x139076C
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<__Il2CppFullySharedGenericType>.TryPush
	*/

	// RVA: -1 Offset: -1
	public T[] TryPop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x138FBFC Offset: 0x138BBFC VA: 0x138FBFC
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<byte>.TryPop
	|
	|-RVA: 0x139001C Offset: 0x138C01C VA: 0x139001C
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<char>.TryPop
	|
	|-RVA: 0x139043C Offset: 0x138C43C VA: 0x139043C
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<int>.TryPop
	|
	|-RVA: 0x1390880 Offset: 0x138C880 VA: 0x1390880
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<__Il2CppFullySharedGenericType>.TryPop
	*/

	// RVA: -1 Offset: -1
	public void Trim(uint tickCount, int id, TlsOverPerCoreLockedStacksArrayPool.MemoryPressure<T> pressure, int bucketSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x138FC74 Offset: 0x138BC74 VA: 0x138FC74
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<byte>.Trim
	|
	|-RVA: 0x1390094 Offset: 0x138C094 VA: 0x1390094
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<char>.Trim
	|
	|-RVA: 0x13904B4 Offset: 0x138C4B4 VA: 0x13904B4
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<int>.Trim
	|
	|-RVA: 0x13908F8 Offset: 0x138C8F8 VA: 0x13908F8
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<__Il2CppFullySharedGenericType>.Trim
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x138FED4 Offset: 0x138BED4 VA: 0x138FED4
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<byte>..ctor
	|
	|-RVA: 0x13902F4 Offset: 0x138C2F4 VA: 0x13902F4
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<char>..ctor
	|
	|-RVA: 0x1390714 Offset: 0x138C714 VA: 0x1390714
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<int>..ctor
	|
	|-RVA: 0x1390BA0 Offset: 0x138CBA0 VA: 0x1390BA0
	|-TlsOverPerCoreLockedStacksArrayPool.LockedStack<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Buffers
internal sealed class TlsOverPerCoreLockedStacksArrayPool<T> : ArrayPool<T> // TypeDefIndex: 1532
{
	// Fields
	private readonly int[] _bucketArraySizes; // 0x0
	private readonly TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<T>[] _buckets; // 0x0
	[ThreadStatic]
	private static T[][] t_tlsBuckets; // 0xFFFFFFFF
	private int _callbackCreated; // 0x0
	private static readonly bool s_trimBuffers; // 0x0
	private static readonly ConditionalWeakTable<T[][], object> s_allTlsBuckets; // 0x0

	// Properties
	private int Id { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1482D20 Offset: 0x147ED20 VA: 0x1482D20
	|-TlsOverPerCoreLockedStacksArrayPool<byte>..ctor
	|
	|-RVA: 0x14841F0 Offset: 0x14801F0 VA: 0x14841F0
	|-TlsOverPerCoreLockedStacksArrayPool<char>..ctor
	|
	|-RVA: 0x14856C0 Offset: 0x14816C0 VA: 0x14856C0
	|-TlsOverPerCoreLockedStacksArrayPool<int>..ctor
	|
	|-RVA: 0x1486B90 Offset: 0x1482B90 VA: 0x1486B90
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private TlsOverPerCoreLockedStacksArrayPool.PerCoreLockedStacks<T> CreatePerCoreLockedStacks(int bucketIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1482E34 Offset: 0x147EE34 VA: 0x1482E34
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.CreatePerCoreLockedStacks
	|
	|-RVA: 0x1484304 Offset: 0x1480304 VA: 0x1484304
	|-TlsOverPerCoreLockedStacksArrayPool<char>.CreatePerCoreLockedStacks
	|
	|-RVA: 0x14857D4 Offset: 0x14817D4 VA: 0x14857D4
	|-TlsOverPerCoreLockedStacksArrayPool<int>.CreatePerCoreLockedStacks
	|
	|-RVA: 0x1486CA8 Offset: 0x1482CA8 VA: 0x1486CA8
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.CreatePerCoreLockedStacks
	*/

	// RVA: -1 Offset: -1
	private int get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1482ECC Offset: 0x147EECC VA: 0x1482ECC
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.get_Id
	|
	|-RVA: 0x148439C Offset: 0x148039C VA: 0x148439C
	|-TlsOverPerCoreLockedStacksArrayPool<char>.get_Id
	|
	|-RVA: 0x148586C Offset: 0x148186C VA: 0x148586C
	|-TlsOverPerCoreLockedStacksArrayPool<int>.get_Id
	|
	|-RVA: 0x1486D44 Offset: 0x1482D44 VA: 0x1486D44
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.get_Id
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override T[] Rent(int minimumLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1482EE4 Offset: 0x147EEE4 VA: 0x1482EE4
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Rent
	|
	|-RVA: 0x14843B4 Offset: 0x14803B4 VA: 0x14843B4
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Rent
	|
	|-RVA: 0x1485884 Offset: 0x1481884 VA: 0x1485884
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Rent
	|
	|-RVA: 0x1486D5C Offset: 0x1482D5C VA: 0x1486D5C
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override void Return(T[] array, bool clearArray = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14832A0 Offset: 0x147F2A0 VA: 0x14832A0
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Return
	|
	|-RVA: 0x1484770 Offset: 0x1480770 VA: 0x1484770
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Return
	|
	|-RVA: 0x1485C40 Offset: 0x1481C40 VA: 0x1485C40
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Return
	|
	|-RVA: 0x14870F4 Offset: 0x14830F4 VA: 0x14870F4
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Return
	*/

	// RVA: -1 Offset: -1
	public bool Trim() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1483748 Offset: 0x147F748 VA: 0x1483748
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Trim
	|
	|-RVA: 0x1484C18 Offset: 0x1480C18 VA: 0x1484C18
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Trim
	|
	|-RVA: 0x14860E8 Offset: 0x14820E8 VA: 0x14860E8
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Trim
	|
	|-RVA: 0x1487610 Offset: 0x1483610 VA: 0x1487610
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Trim
	*/

	// RVA: -1 Offset: -1
	private static bool Gen2GcCallbackFunc(object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1483EE8 Offset: 0x147FEE8 VA: 0x1483EE8
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.Gen2GcCallbackFunc
	|
	|-RVA: 0x14853B8 Offset: 0x14813B8 VA: 0x14853B8
	|-TlsOverPerCoreLockedStacksArrayPool<char>.Gen2GcCallbackFunc
	|
	|-RVA: 0x1486888 Offset: 0x1482888 VA: 0x1486888
	|-TlsOverPerCoreLockedStacksArrayPool<int>.Gen2GcCallbackFunc
	|
	|-RVA: 0x1487E58 Offset: 0x1483E58 VA: 0x1487E58
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.Gen2GcCallbackFunc
	*/

	// RVA: -1 Offset: -1
	private static TlsOverPerCoreLockedStacksArrayPool.MemoryPressure<T> GetMemoryPressure() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1483FC4 Offset: 0x147FFC4 VA: 0x1483FC4
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.GetMemoryPressure
	|
	|-RVA: 0x1485494 Offset: 0x1481494 VA: 0x1485494
	|-TlsOverPerCoreLockedStacksArrayPool<char>.GetMemoryPressure
	|
	|-RVA: 0x1486964 Offset: 0x1482964 VA: 0x1486964
	|-TlsOverPerCoreLockedStacksArrayPool<int>.GetMemoryPressure
	|
	|-RVA: 0x1487F68 Offset: 0x1483F68 VA: 0x1487F68
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.GetMemoryPressure
	*/

	// RVA: -1 Offset: -1
	private static bool GetTrimBuffers() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1484078 Offset: 0x1480078 VA: 0x1484078
	|-TlsOverPerCoreLockedStacksArrayPool<byte>.GetTrimBuffers
	|
	|-RVA: 0x1485548 Offset: 0x1481548 VA: 0x1485548
	|-TlsOverPerCoreLockedStacksArrayPool<char>.GetTrimBuffers
	|
	|-RVA: 0x1486A18 Offset: 0x1482A18 VA: 0x1486A18
	|-TlsOverPerCoreLockedStacksArrayPool<int>.GetTrimBuffers
	|
	|-RVA: 0x148801C Offset: 0x148401C VA: 0x148801C
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>.GetTrimBuffers
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1484080 Offset: 0x1480080 VA: 0x1484080
	|-TlsOverPerCoreLockedStacksArrayPool<byte>..cctor
	|
	|-RVA: 0x1485550 Offset: 0x1481550 VA: 0x1485550
	|-TlsOverPerCoreLockedStacksArrayPool<char>..cctor
	|
	|-RVA: 0x1486A20 Offset: 0x1482A20 VA: 0x1486A20
	|-TlsOverPerCoreLockedStacksArrayPool<int>..cctor
	|
	|-RVA: 0x1488024 Offset: 0x1484024 VA: 0x1488024
	|-TlsOverPerCoreLockedStacksArrayPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Buffers
internal static class Utilities // TypeDefIndex: 1533
{
	// Methods

	// RVA: 0x18533C0 Offset: 0x184F3C0 VA: 0x18533C0
	internal static int SelectBucketIndex(int bufferSize) { }

	// RVA: 0x185343C Offset: 0x184F43C VA: 0x185343C
	internal static int GetMaxSizeForBucket(int binIndex) { }
}

// Namespace: System.Buffers
[Extension]
public static class BuffersExtensions // TypeDefIndex: 1534
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static void CopyTo<T>(in ReadOnlySequence<T> source, Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EE990 Offset: 0x10EA990 VA: 0x10EE990
	|-BuffersExtensions.CopyTo<char>
	|
	|-RVA: 0x10EEADC Offset: 0x10EAADC VA: 0x10EEADC
	|-BuffersExtensions.CopyTo<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void CopyToMultiSegment<T>(in ReadOnlySequence<T> sequence, Span<T> destination) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EEC3C Offset: 0x10EAC3C VA: 0x10EEC3C
	|-BuffersExtensions.CopyToMultiSegment<char>
	|
	|-RVA: 0x10EED98 Offset: 0x10EAD98 VA: 0x10EED98
	|-BuffersExtensions.CopyToMultiSegment<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: System.Buffers
public interface IBufferWriter<T> // TypeDefIndex: 1535
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Advance(int count);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IBufferWriter<__Il2CppFullySharedGenericType>.Advance
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Span<T> GetSpan(int sizeHint = 0);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IBufferWriter<__Il2CppFullySharedGenericType>.GetSpan
	*/
}

// Namespace: 
public struct ReadOnlySequence.Enumerator<T> // TypeDefIndex: 1536
{
	// Fields
	private readonly ReadOnlySequence<T> _sequence; // 0x0
	private SequencePosition _next; // 0x0
	private ReadOnlyMemory<T> _currentMemory; // 0x0

	// Properties
	public ReadOnlyMemory<T> Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(in ReadOnlySequence<T> sequence) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EA3D4 Offset: 0x11E63D4 VA: 0x11EA3D4
	|-ReadOnlySequence.Enumerator<byte>..ctor
	|
	|-RVA: 0x11EA930 Offset: 0x11E6930 VA: 0x11EA930
	|-ReadOnlySequence.Enumerator<char>..ctor
	|
	|-RVA: 0x11F71C8 Offset: 0x11F31C8 VA: 0x11F71C8
	|-ReadOnlySequence.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyMemory<T> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EA494 Offset: 0x11E6494 VA: 0x11EA494
	|-ReadOnlySequence.Enumerator<byte>.get_Current
	|
	|-RVA: 0x11EA9F0 Offset: 0x11E69F0 VA: 0x11EA9F0
	|-ReadOnlySequence.Enumerator<char>.get_Current
	|
	|-RVA: 0x11F72AC Offset: 0x11F32AC VA: 0x11F72AC
	|-ReadOnlySequence.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11EA4A0 Offset: 0x11E64A0 VA: 0x11EA4A0
	|-ReadOnlySequence.Enumerator<byte>.MoveNext
	|
	|-RVA: 0x11EA9FC Offset: 0x11E69FC VA: 0x11EA9FC
	|-ReadOnlySequence.Enumerator<char>.MoveNext
	|
	|-RVA: 0x11F72B8 Offset: 0x11F32B8 VA: 0x11F72B8
	|-ReadOnlySequence.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/
}

// Namespace: 
private enum ReadOnlySequence.SequenceType<T> // TypeDefIndex: 1537
{
	// Fields
	public int value__; // 0x0
	public const ReadOnlySequence.SequenceType<T> MultiSegment = 0;
	public const ReadOnlySequence.SequenceType<T> Array = 1;
	public const ReadOnlySequence.SequenceType<T> MemoryManager = 2;
	public const ReadOnlySequence.SequenceType<T> String = 3;
	public const ReadOnlySequence.SequenceType<T> Empty = 4;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ReadOnlySequence.<>c<T> // TypeDefIndex: 1538
{
	// Fields
	public static readonly ReadOnlySequence.<>c<T> <>9; // 0x0
	public static SpanAction<char, ReadOnlySequence<char>> <>9__33_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114FFE0 Offset: 0x114BFE0 VA: 0x114FFE0
	|-ReadOnlySequence.<>c<byte>..cctor
	|
	|-RVA: 0x1150120 Offset: 0x114C120 VA: 0x1150120
	|-ReadOnlySequence.<>c<char>..cctor
	|
	|-RVA: 0x11517CC Offset: 0x114D7CC VA: 0x11517CC
	|-ReadOnlySequence.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11500B8 Offset: 0x114C0B8 VA: 0x11500B8
	|-ReadOnlySequence.<>c<byte>..ctor
	|
	|-RVA: 0x11501F8 Offset: 0x114C1F8 VA: 0x11501F8
	|-ReadOnlySequence.<>c<char>..ctor
	|
	|-RVA: 0x11518D8 Offset: 0x114D8D8 VA: 0x11518D8
	|-ReadOnlySequence.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <ToString>b__33_0(Span<char> span, ReadOnlySequence<char> sequence) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11500C0 Offset: 0x114C0C0 VA: 0x11500C0
	|-ReadOnlySequence.<>c<byte>.<ToString>b__33_0
	|
	|-RVA: 0x1150200 Offset: 0x114C200 VA: 0x1150200
	|-ReadOnlySequence.<>c<char>.<ToString>b__33_0
	|
	|-RVA: 0x11518E0 Offset: 0x114D8E0 VA: 0x11518E0
	|-ReadOnlySequence.<>c<__Il2CppFullySharedGenericType>.<ToString>b__33_0
	*/
}

// Namespace: System.Buffers
[DebuggerTypeProxy(typeof(ReadOnlySequenceDebugView<T>))]
[DebuggerDisplay("{ToString(),raw}")]
[IsReadOnly]
public struct ReadOnlySequence<T> // TypeDefIndex: 1539
{
	// Fields
	private readonly object _startObject; // 0x0
	private readonly object _endObject; // 0x0
	private readonly int _startInteger; // 0x0
	private readonly int _endInteger; // 0x0
	public static readonly ReadOnlySequence<T> Empty; // 0x0

	// Properties
	public long Length { get; }
	public bool IsSingleSegment { get; }
	public ReadOnlyMemory<T> First { get; }
	public SequencePosition Start { get; }

	// Methods

	// RVA: -1 Offset: -1
	public long get_Length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142D2BC Offset: 0x14292BC VA: 0x142D2BC
	|-ReadOnlySequence<byte>.get_Length
	|
	|-RVA: 0x142EC34 Offset: 0x142AC34 VA: 0x142EC34
	|-ReadOnlySequence<char>.get_Length
	|
	|-RVA: 0x14305AC Offset: 0x142C5AC VA: 0x14305AC
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.get_Length
	*/

	// RVA: -1 Offset: -1
	public bool get_IsSingleSegment() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142D338 Offset: 0x1429338 VA: 0x142D338
	|-ReadOnlySequence<byte>.get_IsSingleSegment
	|
	|-RVA: 0x142ECB0 Offset: 0x142ACB0 VA: 0x142ECB0
	|-ReadOnlySequence<char>.get_IsSingleSegment
	|
	|-RVA: 0x1430664 Offset: 0x142C664 VA: 0x1430664
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.get_IsSingleSegment
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyMemory<T> get_First() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142D348 Offset: 0x1429348 VA: 0x142D348
	|-ReadOnlySequence<byte>.get_First
	|
	|-RVA: 0x142ECC0 Offset: 0x142ACC0 VA: 0x142ECC0
	|-ReadOnlySequence<char>.get_First
	|
	|-RVA: 0x1430674 Offset: 0x142C674 VA: 0x1430674
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.get_First
	*/

	// RVA: -1 Offset: -1
	public SequencePosition get_Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142D3C4 Offset: 0x14293C4 VA: 0x142D3C4
	|-ReadOnlySequence<byte>.get_Start
	|
	|-RVA: 0x142ED3C Offset: 0x142AD3C VA: 0x142ED3C
	|-ReadOnlySequence<char>.get_Start
	|
	|-RVA: 0x143072C Offset: 0x142C72C VA: 0x143072C
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.get_Start
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142D3F4 Offset: 0x14293F4 VA: 0x142D3F4
	|-ReadOnlySequence<byte>..ctor
	|
	|-RVA: 0x142ED6C Offset: 0x142AD6C VA: 0x142ED6C
	|-ReadOnlySequence<char>..ctor
	|
	|-RVA: 0x143075C Offset: 0x142C75C VA: 0x143075C
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142D46C Offset: 0x142946C VA: 0x142D46C
	|-ReadOnlySequence<byte>.ToString
	|
	|-RVA: 0x142EDE4 Offset: 0x142ADE4 VA: 0x142EDE4
	|-ReadOnlySequence<char>.ToString
	|
	|-RVA: 0x14307D4 Offset: 0x142C7D4 VA: 0x14307D4
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1
	public ReadOnlySequence.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142D920 Offset: 0x1429920 VA: 0x142D920
	|-ReadOnlySequence<byte>.GetEnumerator
	|
	|-RVA: 0x142F298 Offset: 0x142B298 VA: 0x142F298
	|-ReadOnlySequence<char>.GetEnumerator
	|
	|-RVA: 0x1430D24 Offset: 0x142CD24 VA: 0x1430D24
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public bool TryGet(ref SequencePosition position, out ReadOnlyMemory<T> memory, bool advance = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142D978 Offset: 0x1429978 VA: 0x142D978
	|-ReadOnlySequence<byte>.TryGet
	|
	|-RVA: 0x142F2F0 Offset: 0x142B2F0 VA: 0x142F2F0
	|-ReadOnlySequence<char>.TryGet
	|
	|-RVA: 0x1430D7C Offset: 0x142CD7C VA: 0x1430D7C
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.TryGet
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetBuffer(in SequencePosition position, out ReadOnlyMemory<T> memory, out SequencePosition next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142DA38 Offset: 0x1429A38 VA: 0x142DA38
	|-ReadOnlySequence<byte>.TryGetBuffer
	|
	|-RVA: 0x142F3B0 Offset: 0x142B3B0 VA: 0x142F3B0
	|-ReadOnlySequence<char>.TryGetBuffer
	|
	|-RVA: 0x1430E70 Offset: 0x142CE70 VA: 0x1430E70
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.TryGetBuffer
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyMemory<T> GetFirstBuffer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142E080 Offset: 0x142A080 VA: 0x142E080
	|-ReadOnlySequence<byte>.GetFirstBuffer
	|
	|-RVA: 0x142F9F8 Offset: 0x142B9F8 VA: 0x142F9F8
	|-ReadOnlySequence<char>.GetFirstBuffer
	|
	|-RVA: 0x1431648 Offset: 0x142D648 VA: 0x1431648
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.GetFirstBuffer
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyMemory<T> GetFirstBufferSlow(object startObject, bool isMultiSegment) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142E2E8 Offset: 0x142A2E8 VA: 0x142E2E8
	|-ReadOnlySequence<byte>.GetFirstBufferSlow
	|
	|-RVA: 0x142FC60 Offset: 0x142BC60 VA: 0x142FC60
	|-ReadOnlySequence<char>.GetFirstBufferSlow
	|
	|-RVA: 0x1431914 Offset: 0x142D914 VA: 0x1431914
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.GetFirstBufferSlow
	*/

	// RVA: -1 Offset: -1
	private ReadOnlySequence.SequenceType<T> GetSequenceType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142E6CC Offset: 0x142A6CC VA: 0x142E6CC
	|-ReadOnlySequence<byte>.GetSequenceType
	|
	|-RVA: 0x1430044 Offset: 0x142C044 VA: 0x1430044
	|-ReadOnlySequence<char>.GetSequenceType
	|
	|-RVA: 0x1431D20 Offset: 0x142DD20 VA: 0x1431D20
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.GetSequenceType
	*/

	// RVA: -1 Offset: -1
	private static int GetIndex(in SequencePosition position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142E6E0 Offset: 0x142A6E0 VA: 0x142E6E0
	|-ReadOnlySequence<byte>.GetIndex
	|
	|-RVA: 0x1430058 Offset: 0x142C058 VA: 0x1430058
	|-ReadOnlySequence<char>.GetIndex
	|
	|-RVA: 0x1431D34 Offset: 0x142DD34 VA: 0x1431D34
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.GetIndex
	*/

	// RVA: -1 Offset: -1
	private static int GetIndex(int Integer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142E6EC Offset: 0x142A6EC VA: 0x142E6EC
	|-ReadOnlySequence<byte>.GetIndex
	|
	|-RVA: 0x1430064 Offset: 0x142C064 VA: 0x1430064
	|-ReadOnlySequence<char>.GetIndex
	|
	|-RVA: 0x1431D40 Offset: 0x142DD40 VA: 0x1431D40
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.GetIndex
	*/

	// RVA: -1 Offset: -1
	private long GetLength() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142E6F4 Offset: 0x142A6F4 VA: 0x142E6F4
	|-ReadOnlySequence<byte>.GetLength
	|
	|-RVA: 0x143006C Offset: 0x142C06C VA: 0x143006C
	|-ReadOnlySequence<char>.GetLength
	|
	|-RVA: 0x1431D48 Offset: 0x142DD48 VA: 0x1431D48
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.GetLength
	*/

	// RVA: -1 Offset: -1
	internal bool TryGetString(out string text, out int start, out int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142E918 Offset: 0x142A918 VA: 0x142E918
	|-ReadOnlySequence<byte>.TryGetString
	|
	|-RVA: 0x1430290 Offset: 0x142C290 VA: 0x1430290
	|-ReadOnlySequence<char>.TryGetString
	|
	|-RVA: 0x1432078 Offset: 0x142E078 VA: 0x1432078
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>.TryGetString
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142EB08 Offset: 0x142AB08 VA: 0x142EB08
	|-ReadOnlySequence<byte>..cctor
	|
	|-RVA: 0x1430480 Offset: 0x142C480 VA: 0x1430480
	|-ReadOnlySequence<char>..cctor
	|
	|-RVA: 0x1432328 Offset: 0x142E328 VA: 0x1432328
	|-ReadOnlySequence<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Buffers
internal static class ReadOnlySequence // TypeDefIndex: 1540
{
	// Methods

	// RVA: 0x1853448 Offset: 0x184F448 VA: 0x1853448
	public static int ArrayToSequenceStart(int startIndex) { }

	// RVA: 0x185344C Offset: 0x184F44C VA: 0x185344C
	public static int ArrayToSequenceEnd(int endIndex) { }
}

// Namespace: System.Buffers
internal sealed class ReadOnlySequenceDebugView<T> // TypeDefIndex: 1541
{}

// Namespace: System.Buffers
public abstract class ReadOnlySequenceSegment<T> // TypeDefIndex: 1542
{
	// Fields
	[CompilerGenerated]
	private ReadOnlyMemory<T> <Memory>k__BackingField; // 0x0
	[CompilerGenerated]
	private ReadOnlySequenceSegment<T> <Next>k__BackingField; // 0x0
	[CompilerGenerated]
	private long <RunningIndex>k__BackingField; // 0x0

	// Properties
	public ReadOnlyMemory<T> Memory { get; }
	public ReadOnlySequenceSegment<T> Next { get; }
	public long RunningIndex { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public ReadOnlyMemory<T> get_Memory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142D268 Offset: 0x1429268 VA: 0x142D268
	|-ReadOnlySequenceSegment<byte>.get_Memory
	|
	|-RVA: 0x142D284 Offset: 0x1429284 VA: 0x142D284
	|-ReadOnlySequenceSegment<char>.get_Memory
	|
	|-RVA: 0x142D2A0 Offset: 0x14292A0 VA: 0x142D2A0
	|-ReadOnlySequenceSegment<__Il2CppFullySharedGenericType>.get_Memory
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public ReadOnlySequenceSegment<T> get_Next() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142D274 Offset: 0x1429274 VA: 0x142D274
	|-ReadOnlySequenceSegment<byte>.get_Next
	|
	|-RVA: 0x142D290 Offset: 0x1429290 VA: 0x142D290
	|-ReadOnlySequenceSegment<char>.get_Next
	|
	|-RVA: 0x142D2AC Offset: 0x14292AC VA: 0x142D2AC
	|-ReadOnlySequenceSegment<__Il2CppFullySharedGenericType>.get_Next
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public long get_RunningIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142D27C Offset: 0x142927C VA: 0x142D27C
	|-ReadOnlySequenceSegment<byte>.get_RunningIndex
	|
	|-RVA: 0x142D298 Offset: 0x1429298 VA: 0x142D298
	|-ReadOnlySequenceSegment<char>.get_RunningIndex
	|
	|-RVA: 0x142D2B4 Offset: 0x14292B4 VA: 0x142D2B4
	|-ReadOnlySequenceSegment<__Il2CppFullySharedGenericType>.get_RunningIndex
	*/
}
