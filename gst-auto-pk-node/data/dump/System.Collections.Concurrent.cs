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

// Namespace: System.Collections.Concurrent
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IProducerConsumerCollectionDebugView<T>))]
[Serializable]
public class ConcurrentQueue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T> // TypeDefIndex: 1442
{
	// Fields
	private object _crossSegmentLock; // 0x0
	private ConcurrentQueue.Segment<T> _tail; // 0x0
	private ConcurrentQueue.Segment<T> _head; // 0x0

	// Properties
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public bool IsEmpty { get; }
	public int Count { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1571728 Offset: 0x156D728 VA: 0x1571728
	|-ConcurrentQueue<object>..ctor
	|
	|-RVA: 0x1572F30 Offset: 0x156EF30 VA: 0x1572F30
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1571800 Offset: 0x156D800 VA: 0x1571800
	|-ConcurrentQueue<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x157300C Offset: 0x156F00C VA: 0x157300C
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15718EC Offset: 0x156D8EC VA: 0x15718EC
	|-ConcurrentQueue<object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x1573100 Offset: 0x156F100 VA: 0x1573100
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15718F4 Offset: 0x156D8F4 VA: 0x15718F4
	|-ConcurrentQueue<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1573108 Offset: 0x156F108 VA: 0x1573108
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157193C Offset: 0x156D93C VA: 0x157193C
	|-ConcurrentQueue<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1573150 Offset: 0x156F150 VA: 0x1573150
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15719C8 Offset: 0x156D9C8 VA: 0x15719C8
	|-ConcurrentQueue<object>.get_IsEmpty
	|
	|-RVA: 0x15731DC Offset: 0x156F1DC VA: 0x15731DC
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public T[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15719F4 Offset: 0x156D9F4 VA: 0x15719F4
	|-ConcurrentQueue<object>.ToArray
	|
	|-RVA: 0x1573278 Offset: 0x156F278 VA: 0x1573278
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1571D04 Offset: 0x156DD04 VA: 0x1571D04
	|-ConcurrentQueue<object>.get_Count
	|
	|-RVA: 0x157367C Offset: 0x156F67C VA: 0x157367C
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	private static int GetCount(ConcurrentQueue.Segment<T> s, int head, int tail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1571F74 Offset: 0x156DF74 VA: 0x1571F74
	|-ConcurrentQueue<object>.GetCount
	|
	|-RVA: 0x15738E8 Offset: 0x156F8E8 VA: 0x15738E8
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetCount
	*/

	// RVA: -1 Offset: -1
	private static long GetCount(ConcurrentQueue.Segment<T> head, int headHead, ConcurrentQueue.Segment<T> tail, int tailTail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572000 Offset: 0x156E000 VA: 0x1572000
	|-ConcurrentQueue<object>.GetCount
	|
	|-RVA: 0x15739B4 Offset: 0x156F9B4 VA: 0x15739B4
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetCount
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572140 Offset: 0x156E140 VA: 0x1572140
	|-ConcurrentQueue<object>.CopyTo
	|
	|-RVA: 0x1573B90 Offset: 0x156FB90 VA: 0x1573B90
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15724F4 Offset: 0x156E4F4 VA: 0x15724F4
	|-ConcurrentQueue<object>.GetEnumerator
	|
	|-RVA: 0x1574058 Offset: 0x1570058 VA: 0x1574058
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private void SnapForObservation(out ConcurrentQueue.Segment<T> head, out int headHead, out ConcurrentQueue.Segment<T> tail, out int tailTail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157255C Offset: 0x156E55C VA: 0x157255C
	|-ConcurrentQueue<object>.SnapForObservation
	|
	|-RVA: 0x15740C8 Offset: 0x15700C8 VA: 0x15740C8
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.SnapForObservation
	*/

	// RVA: -1 Offset: -1
	private T GetItemWhenAvailable(ConcurrentQueue.Segment<T> segment, int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15726F0 Offset: 0x156E6F0 VA: 0x15726F0
	|-ConcurrentQueue<object>.GetItemWhenAvailable
	|
	|-RVA: 0x1574260 Offset: 0x1570260 VA: 0x1574260
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.GetItemWhenAvailable
	*/

	[IteratorStateMachine(typeof(ConcurrentQueue.<Enumerate>d__28<T>))]
	// RVA: -1 Offset: -1
	private IEnumerator<T> Enumerate(ConcurrentQueue.Segment<T> head, int headHead, ConcurrentQueue.Segment<T> tail, int tailTail) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15727F8 Offset: 0x156E7F8 VA: 0x15727F8
	|-ConcurrentQueue<object>.Enumerate
	|
	|-RVA: 0x1574414 Offset: 0x1570414 VA: 0x1574414
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.Enumerate
	*/

	// RVA: -1 Offset: -1
	public void Enqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15728BC Offset: 0x156E8BC VA: 0x15728BC
	|-ConcurrentQueue<object>.Enqueue
	|
	|-RVA: 0x1574544 Offset: 0x1570544 VA: 0x1574544
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.Enqueue
	*/

	// RVA: -1 Offset: -1
	private void EnqueueSlow(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572934 Offset: 0x156E934 VA: 0x1572934
	|-ConcurrentQueue<object>.EnqueueSlow
	|
	|-RVA: 0x15746B0 Offset: 0x15706B0 VA: 0x15746B0
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.EnqueueSlow
	*/

	// RVA: -1 Offset: -1
	public bool TryDequeue(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572B5C Offset: 0x156EB5C VA: 0x1572B5C
	|-ConcurrentQueue<object>.TryDequeue
	|
	|-RVA: 0x15749C8 Offset: 0x15709C8 VA: 0x15749C8
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.TryDequeue
	*/

	// RVA: -1 Offset: -1
	private bool TryDequeueSlow(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572BD8 Offset: 0x156EBD8 VA: 0x1572BD8
	|-ConcurrentQueue<object>.TryDequeueSlow
	|
	|-RVA: 0x1574A4C Offset: 0x1570A4C VA: 0x1574A4C
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.TryDequeueSlow
	*/

	// RVA: -1 Offset: -1
	private bool TryPeek(out T result, bool resultUsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572D50 Offset: 0x156ED50 VA: 0x1572D50
	|-ConcurrentQueue<object>.TryPeek
	|
	|-RVA: 0x1574BEC Offset: 0x1570BEC VA: 0x1574BEC
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.TryPeek
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1572DD8 Offset: 0x156EDD8 VA: 0x1572DD8
	|-ConcurrentQueue<object>.Clear
	|
	|-RVA: 0x1574C94 Offset: 0x1570C94 VA: 0x1574C94
	|-ConcurrentQueue<__Il2CppFullySharedGenericType>.Clear
	*/
}

// Namespace: System.Collections.Concurrent
[DebuggerDisplay("Head = {Head}, Tail = {Tail}")]
internal struct PaddedHeadAndTail // TypeDefIndex: 1443
{
	// Fields
	public int Head; // 0x80
	public int Tail; // 0x100
}

// Namespace: System.Collections.Concurrent
[EventSource(Name = "System.Collections.Concurrent.ConcurrentCollectionsEventSource", Guid = "35167F8E-49B2-4b96-AB86-435B59336B5E")]
internal sealed class CDSCollectionETWBCLProvider : EventSource // TypeDefIndex: 1444
{
	// Fields
	public static CDSCollectionETWBCLProvider Log; // 0x0

	// Methods

	// RVA: 0x185294C Offset: 0x184E94C VA: 0x185294C
	private void .ctor() { }

	[Event(3, Level = 3)]
	// RVA: 0x1852950 Offset: 0x184E950 VA: 0x1852950
	public void ConcurrentDictionary_AcquiringAllLocks(int numOfBuckets) { }

	// RVA: 0x1852954 Offset: 0x184E954 VA: 0x1852954
	private static void .cctor() { }
}

// Namespace: 
private sealed class ConcurrentDictionary.Tables<TKey, TValue> // TypeDefIndex: 1445
{
	// Fields
	internal readonly ConcurrentDictionary.Node<TKey, TValue>[] _buckets; // 0x0
	internal readonly object[] _locks; // 0x0
	internal int[] _countPerLock; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ConcurrentDictionary.Node<TKey, TValue>[] buckets, object[] locks, int[] countPerLock) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146D2D4 Offset: 0x14692D4 VA: 0x146D2D4
	|-ConcurrentDictionary.Tables<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x146D338 Offset: 0x1469338 VA: 0x146D338
	|-ConcurrentDictionary.Tables<int, object>..ctor
	|
	|-RVA: 0x146D39C Offset: 0x146939C VA: 0x146D39C
	|-ConcurrentDictionary.Tables<object, bool>..ctor
	|
	|-RVA: 0x146D400 Offset: 0x1469400 VA: 0x146D400
	|-ConcurrentDictionary.Tables<object, object>..ctor
	|
	|-RVA: 0x146D464 Offset: 0x1469464 VA: 0x146D464
	|-ConcurrentDictionary.Tables<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[Serializable]
private sealed class ConcurrentDictionary.Node<TKey, TValue> // TypeDefIndex: 1446
{
	// Fields
	internal readonly TKey _key; // 0x0
	internal TValue _value; // 0x0
	internal ConcurrentDictionary.Node<TKey, TValue> _next; // 0x0
	internal readonly int _hashcode; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(TKey key, TValue value, int hashcode, ConcurrentDictionary.Node<TKey, TValue> next) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D9A00 Offset: 0x13D5A00 VA: 0x13D9A00
	|-ConcurrentDictionary.Node<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x13D9A80 Offset: 0x13D5A80 VA: 0x13D9A80
	|-ConcurrentDictionary.Node<int, object>..ctor
	|
	|-RVA: 0x13D9AE4 Offset: 0x13D5AE4 VA: 0x13D9AE4
	|-ConcurrentDictionary.Node<object, bool>..ctor
	|
	|-RVA: 0x13D9B48 Offset: 0x13D5B48 VA: 0x13D9B48
	|-ConcurrentDictionary.Node<object, object>..ctor
	|
	|-RVA: 0x13D9BB8 Offset: 0x13D5BB8 VA: 0x13D9BB8
	|-ConcurrentDictionary.Node<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[Serializable]
private sealed class ConcurrentDictionary.DictionaryEnumerator<TKey, TValue> : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 1447
{
	// Fields
	private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator; // 0x0

	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ConcurrentDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15791CC Offset: 0x15751CC VA: 0x15791CC
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x15796AC Offset: 0x15756AC VA: 0x15796AC
	|-ConcurrentDictionary.DictionaryEnumerator<int, object>..ctor
	|
	|-RVA: 0x1579F10 Offset: 0x1575F10 VA: 0x1579F10
	|-ConcurrentDictionary.DictionaryEnumerator<object, bool>..ctor
	|
	|-RVA: 0x157A3D0 Offset: 0x15763D0 VA: 0x157A3D0
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>..ctor
	|
	|-RVA: 0x157B178 Offset: 0x1577178 VA: 0x157B178
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DictionaryEntry get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157921C Offset: 0x157521C VA: 0x157921C
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.get_Entry
	|
	|-RVA: 0x15796FC Offset: 0x15756FC VA: 0x15796FC
	|-ConcurrentDictionary.DictionaryEnumerator<int, object>.get_Entry
	|
	|-RVA: 0x1579F60 Offset: 0x1575F60 VA: 0x1579F60
	|-ConcurrentDictionary.DictionaryEnumerator<object, bool>.get_Entry
	|
	|-RVA: 0x157A420 Offset: 0x1576420 VA: 0x157A420
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Entry
	|
	|-RVA: 0x157B1CC Offset: 0x15771CC VA: 0x157B1CC
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1579388 Offset: 0x1575388 VA: 0x1579388
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.get_Key
	|
	|-RVA: 0x1579860 Offset: 0x1575860 VA: 0x1579860
	|-ConcurrentDictionary.DictionaryEnumerator<int, object>.get_Key
	|
	|-RVA: 0x157A0C8 Offset: 0x15760C8 VA: 0x157A0C8
	|-ConcurrentDictionary.DictionaryEnumerator<object, bool>.get_Key
	|
	|-RVA: 0x157A568 Offset: 0x1576568 VA: 0x157A568
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Key
	|
	|-RVA: 0x157B4A8 Offset: 0x15774A8 VA: 0x157B4A8
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157944C Offset: 0x157544C VA: 0x157944C
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.get_Value
	|
	|-RVA: 0x1579918 Offset: 0x1575918 VA: 0x1579918
	|-ConcurrentDictionary.DictionaryEnumerator<int, object>.get_Value
	|
	|-RVA: 0x157A154 Offset: 0x1576154 VA: 0x157A154
	|-ConcurrentDictionary.DictionaryEnumerator<object, bool>.get_Value
	|
	|-RVA: 0x157A5F4 Offset: 0x15765F4 VA: 0x157A5F4
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Value
	|
	|-RVA: 0x157B64C Offset: 0x157764C VA: 0x157B64C
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15794EC Offset: 0x15754EC VA: 0x15794EC
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.get_Current
	|
	|-RVA: 0x15799AC Offset: 0x15759AC VA: 0x15799AC
	|-ConcurrentDictionary.DictionaryEnumerator<int, object>.get_Current
	|
	|-RVA: 0x157A210 Offset: 0x1576210 VA: 0x157A210
	|-ConcurrentDictionary.DictionaryEnumerator<object, bool>.get_Current
	|
	|-RVA: 0x157A688 Offset: 0x1576688 VA: 0x157A688
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.get_Current
	|
	|-RVA: 0x157B7F0 Offset: 0x15777F0 VA: 0x157B7F0
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1579568 Offset: 0x1575568 VA: 0x1579568
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.MoveNext
	|
	|-RVA: 0x1579A28 Offset: 0x1575A28 VA: 0x1579A28
	|-ConcurrentDictionary.DictionaryEnumerator<int, object>.MoveNext
	|
	|-RVA: 0x157A28C Offset: 0x157628C VA: 0x157A28C
	|-ConcurrentDictionary.DictionaryEnumerator<object, bool>.MoveNext
	|
	|-RVA: 0x157A704 Offset: 0x1576704 VA: 0x157A704
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.MoveNext
	|
	|-RVA: 0x157B870 Offset: 0x1577870 VA: 0x157B870
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1579608 Offset: 0x1575608 VA: 0x1579608
	|-ConcurrentDictionary.DictionaryEnumerator<StructMultiKey<object, object>, object>.Reset
	|
	|-RVA: 0x1579AC8 Offset: 0x1575AC8 VA: 0x1579AC8
	|-ConcurrentDictionary.DictionaryEnumerator<int, object>.Reset
	|
	|-RVA: 0x157A32C Offset: 0x157632C VA: 0x157A32C
	|-ConcurrentDictionary.DictionaryEnumerator<object, bool>.Reset
	|
	|-RVA: 0x157A7A4 Offset: 0x15767A4 VA: 0x157A7A4
	|-ConcurrentDictionary.DictionaryEnumerator<object, object>.Reset
	|
	|-RVA: 0x157B910 Offset: 0x1577910 VA: 0x157B910
	|-ConcurrentDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ConcurrentDictionary.<GetEnumerator>d__35<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator // TypeDefIndex: 1448
{
	// Fields
	private int <>1__state; // 0x0
	private KeyValuePair<TKey, TValue> <>2__current; // 0x0
	public ConcurrentDictionary<TKey, TValue> <>4__this; // 0x0
	private ConcurrentDictionary.Node<TKey, TValue>[] <buckets>5__2; // 0x0
	private int <i>5__3; // 0x0
	private ConcurrentDictionary.Node<TKey, TValue> <current>5__4; // 0x0

	// Properties
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116593C Offset: 0x116193C VA: 0x116593C
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x1165B3C Offset: 0x1161B3C VA: 0x1165B3C
	|-ConcurrentDictionary.<GetEnumerator>d__35<int, object>..ctor
	|
	|-RVA: 0x1165D20 Offset: 0x1161D20 VA: 0x1165D20
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, bool>..ctor
	|
	|-RVA: 0x1165F04 Offset: 0x1161F04 VA: 0x1165F04
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>..ctor
	|
	|-RVA: 0x11660E4 Offset: 0x11620E4 VA: 0x11660E4
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1165964 Offset: 0x1161964 VA: 0x1165964
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x1165B64 Offset: 0x1161B64 VA: 0x1165B64
	|-ConcurrentDictionary.<GetEnumerator>d__35<int, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x1165D48 Offset: 0x1161D48 VA: 0x1165D48
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, bool>.System.IDisposable.Dispose
	|
	|-RVA: 0x1165F2C Offset: 0x1161F2C VA: 0x1165F2C
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x1166124 Offset: 0x1162124 VA: 0x1166124
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1165968 Offset: 0x1161968 VA: 0x1165968
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.MoveNext
	|
	|-RVA: 0x1165B68 Offset: 0x1161B68 VA: 0x1165B68
	|-ConcurrentDictionary.<GetEnumerator>d__35<int, object>.MoveNext
	|
	|-RVA: 0x1165D4C Offset: 0x1161D4C VA: 0x1165D4C
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, bool>.MoveNext
	|
	|-RVA: 0x1165F30 Offset: 0x1161F30 VA: 0x1165F30
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.MoveNext
	|
	|-RVA: 0x1166128 Offset: 0x1162128 VA: 0x1166128
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1165ABC Offset: 0x1161ABC VA: 0x1165ABC
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|
	|-RVA: 0x1165CB0 Offset: 0x1161CB0 VA: 0x1165CB0
	|-ConcurrentDictionary.<GetEnumerator>d__35<int, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|
	|-RVA: 0x1165E94 Offset: 0x1161E94 VA: 0x1165E94
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, bool>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|
	|-RVA: 0x1166074 Offset: 0x1162074 VA: 0x1166074
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|
	|-RVA: 0x11665C4 Offset: 0x11625C4 VA: 0x11665C4
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1165AD0 Offset: 0x1161AD0 VA: 0x1165AD0
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1165CBC Offset: 0x1161CBC VA: 0x1165CBC
	|-ConcurrentDictionary.<GetEnumerator>d__35<int, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1165EA0 Offset: 0x1161EA0 VA: 0x1165EA0
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, bool>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1166080 Offset: 0x1162080 VA: 0x1166080
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1166608 Offset: 0x1162608 VA: 0x1166608
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1165B04 Offset: 0x1161B04 VA: 0x1165B04
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1165CF0 Offset: 0x1161CF0 VA: 0x1165CF0
	|-ConcurrentDictionary.<GetEnumerator>d__35<int, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1165ED4 Offset: 0x1161ED4 VA: 0x1165ED4
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, bool>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11660B4 Offset: 0x11620B4 VA: 0x11660B4
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x116663C Offset: 0x116263C VA: 0x116663C
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: System.Collections.Concurrent
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(IDictionaryDebugView<K, V>))]
[DefaultMember("Item")]
[Serializable]
public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 1449
{
	// Fields
	private ConcurrentDictionary.Tables<TKey, TValue> _tables; // 0x0
	private IEqualityComparer<TKey> _comparer; // 0x0
	private readonly bool _growLockArray; // 0x0
	private int _budget; // 0x0
	private KeyValuePair<TKey, TValue>[] _serializationArray; // 0x0
	private int _serializationConcurrencyLevel; // 0x0
	private int _serializationCapacity; // 0x0
	private static readonly bool s_isValueWriteAtomic; // 0x0

	// Properties
	public TValue Item { get; set; }
	public int Count { get; }
	public ICollection<TValue> Values { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private static int DefaultConcurrencyLevel { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static bool IsValueWriteAtomic() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15580E4 Offset: 0x15540E4 VA: 0x15580E4
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.IsValueWriteAtomic
	|
	|-RVA: 0x155C7D8 Offset: 0x15587D8 VA: 0x155C7D8
	|-ConcurrentDictionary<int, object>.IsValueWriteAtomic
	|
	|-RVA: 0x1560DA0 Offset: 0x155CDA0 VA: 0x1560DA0
	|-ConcurrentDictionary<object, bool>.IsValueWriteAtomic
	|
	|-RVA: 0x1565584 Offset: 0x1561584 VA: 0x1565584
	|-ConcurrentDictionary<object, object>.IsValueWriteAtomic
	|
	|-RVA: 0x1569DDC Offset: 0x1565DDC VA: 0x1569DDC
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsValueWriteAtomic
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15581B8 Offset: 0x15541B8 VA: 0x15581B8
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x155C8AC Offset: 0x15588AC VA: 0x155C8AC
	|-ConcurrentDictionary<int, object>..ctor
	|
	|-RVA: 0x1560E74 Offset: 0x155CE74 VA: 0x1560E74
	|-ConcurrentDictionary<object, bool>..ctor
	|
	|-RVA: 0x1565658 Offset: 0x1561658 VA: 0x1565658
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0x1569EB0 Offset: 0x1565EB0 VA: 0x1569EB0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155822C Offset: 0x155422C VA: 0x155822C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x155C920 Offset: 0x1558920 VA: 0x155C920
	|-ConcurrentDictionary<int, object>..ctor
	|
	|-RVA: 0x1560EE8 Offset: 0x155CEE8 VA: 0x1560EE8
	|-ConcurrentDictionary<object, bool>..ctor
	|
	|-RVA: 0x15656CC Offset: 0x15616CC VA: 0x15656CC
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0x1569F38 Offset: 0x1565F38 VA: 0x1569F38
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void InitializeFromCollection(IEnumerable<KeyValuePair<TKey, TValue>> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15582A4 Offset: 0x15542A4 VA: 0x15582A4
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.InitializeFromCollection
	|
	|-RVA: 0x155C998 Offset: 0x1558998 VA: 0x155C998
	|-ConcurrentDictionary<int, object>.InitializeFromCollection
	|
	|-RVA: 0x1560F60 Offset: 0x155CF60 VA: 0x1560F60
	|-ConcurrentDictionary<object, bool>.InitializeFromCollection
	|
	|-RVA: 0x1565744 Offset: 0x1561744 VA: 0x1565744
	|-ConcurrentDictionary<object, object>.InitializeFromCollection
	|
	|-RVA: 0x1569FC4 Offset: 0x1565FC4 VA: 0x1569FC4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InitializeFromCollection
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15586D4 Offset: 0x15546D4 VA: 0x15586D4
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x155CDAC Offset: 0x1558DAC VA: 0x155CDAC
	|-ConcurrentDictionary<int, object>..ctor
	|
	|-RVA: 0x15613B4 Offset: 0x155D3B4 VA: 0x15613B4
	|-ConcurrentDictionary<object, bool>..ctor
	|
	|-RVA: 0x1565B90 Offset: 0x1561B90 VA: 0x1565B90
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0x156A6D4 Offset: 0x15666D4 VA: 0x156A6D4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1558994 Offset: 0x1554994 VA: 0x1558994
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryAdd
	|
	|-RVA: 0x155D06C Offset: 0x155906C VA: 0x155D06C
	|-ConcurrentDictionary<int, object>.TryAdd
	|
	|-RVA: 0x1561674 Offset: 0x155D674 VA: 0x1561674
	|-ConcurrentDictionary<object, bool>.TryAdd
	|
	|-RVA: 0x1565E50 Offset: 0x1561E50 VA: 0x1565E50
	|-ConcurrentDictionary<object, object>.TryAdd
	|
	|-RVA: 0x156A99C Offset: 0x156699C VA: 0x156A99C
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1558A9C Offset: 0x1554A9C VA: 0x1558A9C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ContainsKey
	|
	|-RVA: 0x155D160 Offset: 0x1559160 VA: 0x155D160
	|-ConcurrentDictionary<int, object>.ContainsKey
	|
	|-RVA: 0x15617A4 Offset: 0x155D7A4 VA: 0x15617A4
	|-ConcurrentDictionary<object, bool>.ContainsKey
	|
	|-RVA: 0x1565F80 Offset: 0x1561F80 VA: 0x1565F80
	|-ConcurrentDictionary<object, object>.ContainsKey
	|
	|-RVA: 0x156AC84 Offset: 0x1566C84 VA: 0x156AC84
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool TryRemove(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1558AC0 Offset: 0x1554AC0 VA: 0x1558AC0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryRemove
	|
	|-RVA: 0x155D184 Offset: 0x1559184 VA: 0x155D184
	|-ConcurrentDictionary<int, object>.TryRemove
	|
	|-RVA: 0x1561810 Offset: 0x155D810 VA: 0x1561810
	|-ConcurrentDictionary<object, bool>.TryRemove
	|
	|-RVA: 0x1565FE8 Offset: 0x1561FE8 VA: 0x1565FE8
	|-ConcurrentDictionary<object, object>.TryRemove
	|
	|-RVA: 0x156AE0C Offset: 0x1566E0C VA: 0x156AE0C
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryRemove
	*/

	// RVA: -1 Offset: -1
	private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1558AD8 Offset: 0x1554AD8 VA: 0x1558AD8
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryRemoveInternal
	|
	|-RVA: 0x155D19C Offset: 0x155919C VA: 0x155D19C
	|-ConcurrentDictionary<int, object>.TryRemoveInternal
	|
	|-RVA: 0x1561864 Offset: 0x155D864 VA: 0x1561864
	|-ConcurrentDictionary<object, bool>.TryRemoveInternal
	|
	|-RVA: 0x156603C Offset: 0x156203C VA: 0x156603C
	|-ConcurrentDictionary<object, object>.TryRemoveInternal
	|
	|-RVA: 0x156AFB8 Offset: 0x1566FB8 VA: 0x156AFB8
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryRemoveInternal
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1558F64 Offset: 0x1554F64 VA: 0x1558F64
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryGetValue
	|
	|-RVA: 0x155D634 Offset: 0x1559634 VA: 0x155D634
	|-ConcurrentDictionary<int, object>.TryGetValue
	|
	|-RVA: 0x1561CF4 Offset: 0x155DCF4 VA: 0x1561CF4
	|-ConcurrentDictionary<object, bool>.TryGetValue
	|
	|-RVA: 0x15664D4 Offset: 0x15624D4 VA: 0x15664D4
	|-ConcurrentDictionary<object, object>.TryGetValue
	|
	|-RVA: 0x156B864 Offset: 0x1567864 VA: 0x156B864
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	private bool TryGetValueInternal(TKey key, int hashcode, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155904C Offset: 0x155504C VA: 0x155904C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryGetValueInternal
	|
	|-RVA: 0x155D708 Offset: 0x1559708 VA: 0x155D708
	|-ConcurrentDictionary<int, object>.TryGetValueInternal
	|
	|-RVA: 0x1561E04 Offset: 0x155DE04 VA: 0x1561E04
	|-ConcurrentDictionary<object, bool>.TryGetValueInternal
	|
	|-RVA: 0x15665E4 Offset: 0x15625E4 VA: 0x15665E4
	|-ConcurrentDictionary<object, object>.TryGetValueInternal
	|
	|-RVA: 0x156BACC Offset: 0x1567ACC VA: 0x156BACC
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValueInternal
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15591DC Offset: 0x15551DC VA: 0x15591DC
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.Clear
	|
	|-RVA: 0x155D884 Offset: 0x1559884 VA: 0x155D884
	|-ConcurrentDictionary<int, object>.Clear
	|
	|-RVA: 0x1561F78 Offset: 0x155DF78 VA: 0x1561F78
	|-ConcurrentDictionary<object, bool>.Clear
	|
	|-RVA: 0x1566760 Offset: 0x1562760 VA: 0x1566760
	|-ConcurrentDictionary<object, object>.Clear
	|
	|-RVA: 0x156BE38 Offset: 0x1567E38 VA: 0x156BE38
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1559430 Offset: 0x1555430 VA: 0x1559430
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x155DAD8 Offset: 0x1559AD8 VA: 0x155DAD8
	|-ConcurrentDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15621CC Offset: 0x155E1CC VA: 0x15621CC
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x15669B4 Offset: 0x15629B4 VA: 0x15669B4
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x156C0B0 Offset: 0x15680B0 VA: 0x156C0B0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public KeyValuePair<TKey, TValue>[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15596A0 Offset: 0x15556A0 VA: 0x15596A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ToArray
	|
	|-RVA: 0x155DD48 Offset: 0x1559D48 VA: 0x155DD48
	|-ConcurrentDictionary<int, object>.ToArray
	|
	|-RVA: 0x156243C Offset: 0x155E43C VA: 0x156243C
	|-ConcurrentDictionary<object, bool>.ToArray
	|
	|-RVA: 0x1566C24 Offset: 0x1562C24 VA: 0x1566C24
	|-ConcurrentDictionary<object, object>.ToArray
	|
	|-RVA: 0x156C344 Offset: 0x1568344 VA: 0x156C344
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15598C8 Offset: 0x15558C8 VA: 0x15598C8
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.CopyToPairs
	|
	|-RVA: 0x155DF70 Offset: 0x1559F70 VA: 0x155DF70
	|-ConcurrentDictionary<int, object>.CopyToPairs
	|
	|-RVA: 0x1562664 Offset: 0x155E664 VA: 0x1562664
	|-ConcurrentDictionary<object, bool>.CopyToPairs
	|
	|-RVA: 0x1566E4C Offset: 0x1562E4C VA: 0x1566E4C
	|-ConcurrentDictionary<object, object>.CopyToPairs
	|
	|-RVA: 0x156C544 Offset: 0x1568544 VA: 0x156C544
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyToPairs
	*/

	// RVA: -1 Offset: -1
	private void CopyToEntries(DictionaryEntry[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15599CC Offset: 0x15559CC VA: 0x15599CC
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.CopyToEntries
	|
	|-RVA: 0x155E05C Offset: 0x155A05C VA: 0x155E05C
	|-ConcurrentDictionary<int, object>.CopyToEntries
	|
	|-RVA: 0x156274C Offset: 0x155E74C VA: 0x156274C
	|-ConcurrentDictionary<object, bool>.CopyToEntries
	|
	|-RVA: 0x1566F30 Offset: 0x1562F30 VA: 0x1566F30
	|-ConcurrentDictionary<object, object>.CopyToEntries
	|
	|-RVA: 0x156C874 Offset: 0x1568874 VA: 0x156C874
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyToEntries
	*/

	// RVA: -1 Offset: -1
	private void CopyToObjects(object[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1559AC8 Offset: 0x1555AC8 VA: 0x1559AC8
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.CopyToObjects
	|
	|-RVA: 0x155E158 Offset: 0x155A158 VA: 0x155E158
	|-ConcurrentDictionary<int, object>.CopyToObjects
	|
	|-RVA: 0x1562854 Offset: 0x155E854 VA: 0x1562854
	|-ConcurrentDictionary<object, bool>.CopyToObjects
	|
	|-RVA: 0x1567008 Offset: 0x1563008 VA: 0x1567008
	|-ConcurrentDictionary<object, object>.CopyToObjects
	|
	|-RVA: 0x156CAA8 Offset: 0x1568AA8 VA: 0x156CAA8
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyToObjects
	*/

	[IteratorStateMachine(typeof(ConcurrentDictionary.<GetEnumerator>d__35<TKey, TValue>))]
	// RVA: -1 Offset: -1 Slot: 18
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1559C04 Offset: 0x1555C04 VA: 0x1559C04
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetEnumerator
	|
	|-RVA: 0x155E288 Offset: 0x155A288 VA: 0x155E288
	|-ConcurrentDictionary<int, object>.GetEnumerator
	|
	|-RVA: 0x1562984 Offset: 0x155E984 VA: 0x1562984
	|-ConcurrentDictionary<object, bool>.GetEnumerator
	|
	|-RVA: 0x1567134 Offset: 0x1563134 VA: 0x1567134
	|-ConcurrentDictionary<object, object>.GetEnumerator
	|
	|-RVA: 0x156CDBC Offset: 0x1568DBC VA: 0x156CDBC
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1559C80 Offset: 0x1555C80 VA: 0x1559C80
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryAddInternal
	|
	|-RVA: 0x155E304 Offset: 0x155A304 VA: 0x155E304
	|-ConcurrentDictionary<int, object>.TryAddInternal
	|
	|-RVA: 0x1562A00 Offset: 0x155EA00 VA: 0x1562A00
	|-ConcurrentDictionary<object, bool>.TryAddInternal
	|
	|-RVA: 0x15671B0 Offset: 0x15631B0 VA: 0x15671B0
	|-ConcurrentDictionary<object, object>.TryAddInternal
	|
	|-RVA: 0x156CE4C Offset: 0x1568E4C VA: 0x156CE4C
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryAddInternal
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155A308 Offset: 0x1556308 VA: 0x155A308
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Item
	|
	|-RVA: 0x155E970 Offset: 0x155A970 VA: 0x155E970
	|-ConcurrentDictionary<int, object>.get_Item
	|
	|-RVA: 0x1563060 Offset: 0x155F060 VA: 0x1563060
	|-ConcurrentDictionary<object, bool>.get_Item
	|
	|-RVA: 0x156781C Offset: 0x156381C VA: 0x156781C
	|-ConcurrentDictionary<object, object>.get_Item
	|
	|-RVA: 0x156DAF8 Offset: 0x1569AF8 VA: 0x156DAF8
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155A3B4 Offset: 0x15563B4 VA: 0x155A3B4
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.set_Item
	|
	|-RVA: 0x155EA10 Offset: 0x155AA10 VA: 0x155EA10
	|-ConcurrentDictionary<int, object>.set_Item
	|
	|-RVA: 0x15630D8 Offset: 0x155F0D8 VA: 0x15630D8
	|-ConcurrentDictionary<object, bool>.set_Item
	|
	|-RVA: 0x1567894 Offset: 0x1563894 VA: 0x1567894
	|-ConcurrentDictionary<object, object>.set_Item
	|
	|-RVA: 0x156DCA4 Offset: 0x1569CA4 VA: 0x156DCA4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	private static void ThrowKeyNotFoundException(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155A4B8 Offset: 0x15564B8 VA: 0x155A4B8
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ThrowKeyNotFoundException
	|
	|-RVA: 0x155EB00 Offset: 0x155AB00 VA: 0x155EB00
	|-ConcurrentDictionary<int, object>.ThrowKeyNotFoundException
	|
	|-RVA: 0x1563204 Offset: 0x155F204 VA: 0x1563204
	|-ConcurrentDictionary<object, bool>.ThrowKeyNotFoundException
	|
	|-RVA: 0x15679C0 Offset: 0x15639C0 VA: 0x15679C0
	|-ConcurrentDictionary<object, object>.ThrowKeyNotFoundException
	|
	|-RVA: 0x156DF80 Offset: 0x1569F80 VA: 0x156DF80
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ThrowKeyNotFoundException
	*/

	// RVA: -1 Offset: -1
	private static void ThrowKeyNullException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155A528 Offset: 0x1556528 VA: 0x155A528
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ThrowKeyNullException
	|
	|-RVA: 0x155EB70 Offset: 0x155AB70 VA: 0x155EB70
	|-ConcurrentDictionary<int, object>.ThrowKeyNullException
	|
	|-RVA: 0x1563274 Offset: 0x155F274 VA: 0x1563274
	|-ConcurrentDictionary<object, bool>.ThrowKeyNullException
	|
	|-RVA: 0x1567A30 Offset: 0x1563A30 VA: 0x1567A30
	|-ConcurrentDictionary<object, object>.ThrowKeyNullException
	|
	|-RVA: 0x156DFF0 Offset: 0x1569FF0 VA: 0x156DFF0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ThrowKeyNullException
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155A570 Offset: 0x1556570 VA: 0x155A570
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Count
	|
	|-RVA: 0x155EBB8 Offset: 0x155ABB8 VA: 0x155EBB8
	|-ConcurrentDictionary<int, object>.get_Count
	|
	|-RVA: 0x15632BC Offset: 0x155F2BC VA: 0x15632BC
	|-ConcurrentDictionary<object, bool>.get_Count
	|
	|-RVA: 0x1567A78 Offset: 0x1563A78 VA: 0x1567A78
	|-ConcurrentDictionary<object, object>.get_Count
	|
	|-RVA: 0x156E038 Offset: 0x156A038 VA: 0x156E038
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	private int GetCountInternal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155A63C Offset: 0x155663C VA: 0x155A63C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetCountInternal
	|
	|-RVA: 0x155EC84 Offset: 0x155AC84 VA: 0x155EC84
	|-ConcurrentDictionary<int, object>.GetCountInternal
	|
	|-RVA: 0x1563388 Offset: 0x155F388 VA: 0x1563388
	|-ConcurrentDictionary<object, bool>.GetCountInternal
	|
	|-RVA: 0x1567B44 Offset: 0x1563B44 VA: 0x1567B44
	|-ConcurrentDictionary<object, object>.GetCountInternal
	|
	|-RVA: 0x156E138 Offset: 0x156A138 VA: 0x156E138
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetCountInternal
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155A6D4 Offset: 0x15566D4 VA: 0x155A6D4
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetOrAdd
	|
	|-RVA: 0x155ED1C Offset: 0x155AD1C VA: 0x155ED1C
	|-ConcurrentDictionary<int, object>.GetOrAdd
	|
	|-RVA: 0x1563420 Offset: 0x155F420 VA: 0x1563420
	|-ConcurrentDictionary<object, bool>.GetOrAdd
	|
	|-RVA: 0x1567BDC Offset: 0x1563BDC VA: 0x1567BDC
	|-ConcurrentDictionary<object, object>.GetOrAdd
	|
	|-RVA: 0x156E1D0 Offset: 0x156A1D0 VA: 0x156E1D0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetOrAdd
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155A85C Offset: 0x155685C VA: 0x155A85C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetOrAdd
	|
	|-RVA: 0x155EE8C Offset: 0x155AE8C VA: 0x155EE8C
	|-ConcurrentDictionary<int, object>.GetOrAdd
	|
	|-RVA: 0x15635CC Offset: 0x155F5CC VA: 0x15635CC
	|-ConcurrentDictionary<object, bool>.GetOrAdd
	|
	|-RVA: 0x1567D88 Offset: 0x1563D88 VA: 0x1567D88
	|-ConcurrentDictionary<object, object>.GetOrAdd
	|
	|-RVA: 0x156E5E4 Offset: 0x156A5E4 VA: 0x156E5E4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetOrAdd
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155A98C Offset: 0x155698C VA: 0x155A98C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0x155EFA8 Offset: 0x155AFA8 VA: 0x155EFA8
	|-ConcurrentDictionary<int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0x1563724 Offset: 0x155F724 VA: 0x1563724
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0x1567EE0 Offset: 0x1563EE0 VA: 0x1567EE0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0x156E968 Offset: 0x156A968 VA: 0x156E968
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155A9F4 Offset: 0x15569F4 VA: 0x155A9F4
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0x155F010 Offset: 0x155B010 VA: 0x155F010
	|-ConcurrentDictionary<int, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0x156378C Offset: 0x155F78C VA: 0x156378C
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0x1567F48 Offset: 0x1563F48 VA: 0x1567F48
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0x156EAD0 Offset: 0x156AAD0 VA: 0x156EAD0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155AA2C Offset: 0x1556A2C VA: 0x155AA2C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Values
	|
	|-RVA: 0x155F048 Offset: 0x155B048 VA: 0x155F048
	|-ConcurrentDictionary<int, object>.get_Values
	|
	|-RVA: 0x15637B4 Offset: 0x155F7B4 VA: 0x15637B4
	|-ConcurrentDictionary<object, bool>.get_Values
	|
	|-RVA: 0x1567F6C Offset: 0x1563F6C VA: 0x1567F6C
	|-ConcurrentDictionary<object, object>.get_Values
	|
	|-RVA: 0x156EBD0 Offset: 0x156ABD0 VA: 0x156EBD0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 36
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155AA3C Offset: 0x1556A3C VA: 0x155AA3C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x155F058 Offset: 0x155B058 VA: 0x155F058
	|-ConcurrentDictionary<int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x15637C4 Offset: 0x155F7C4 VA: 0x15637C4
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x1567F7C Offset: 0x1563F7C VA: 0x1567F7C
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x156EBE4 Offset: 0x156ABE4 VA: 0x156EBE4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155AA4C Offset: 0x1556A4C VA: 0x155AA4C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x155F068 Offset: 0x155B068 VA: 0x155F068
	|-ConcurrentDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x15637D4 Offset: 0x155F7D4 VA: 0x15637D4
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x1567F8C Offset: 0x1563F8C VA: 0x1567F8C
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x156EBF8 Offset: 0x156ABF8 VA: 0x156EBF8
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155AB04 Offset: 0x1556B04 VA: 0x155AB04
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x155F110 Offset: 0x155B110 VA: 0x155F110
	|-ConcurrentDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1563880 Offset: 0x155F880 VA: 0x1563880
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x1568034 Offset: 0x1564034 VA: 0x1568034
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x156EDA8 Offset: 0x156ADA8 VA: 0x156EDA8
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155AB7C Offset: 0x1556B7C VA: 0x155AB7C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x155F180 Offset: 0x155B180 VA: 0x155F180
	|-ConcurrentDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x15638F4 Offset: 0x155F8F4 VA: 0x15638F4
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x15680A4 Offset: 0x15640A4 VA: 0x15680A4
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x156EF94 Offset: 0x156AF94 VA: 0x156EF94
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155AB84 Offset: 0x1556B84 VA: 0x155AB84
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x155F188 Offset: 0x155B188 VA: 0x155F188
	|-ConcurrentDictionary<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15638FC Offset: 0x155F8FC VA: 0x15638FC
	|-ConcurrentDictionary<object, bool>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x15680AC Offset: 0x15640AC VA: 0x15680AC
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x156EF9C Offset: 0x156AF9C VA: 0x156EF9C
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155ABB8 Offset: 0x1556BB8 VA: 0x155ABB8
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x155F1B4 Offset: 0x155B1B4 VA: 0x155F1B4
	|-ConcurrentDictionary<int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1563998 Offset: 0x155F998 VA: 0x1563998
	|-ConcurrentDictionary<object, bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1568144 Offset: 0x1564144 VA: 0x1568144
	|-ConcurrentDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x156F1A4 Offset: 0x156B1A4 VA: 0x156F1A4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155ABC8 Offset: 0x1556BC8 VA: 0x155ABC8
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x155F1C4 Offset: 0x155B1C4 VA: 0x155F1C4
	|-ConcurrentDictionary<int, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x15639A8 Offset: 0x155F9A8 VA: 0x15639A8
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1568154 Offset: 0x1564154 VA: 0x1568154
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x156F1B8 Offset: 0x156B1B8 VA: 0x156F1B8
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155AE50 Offset: 0x1556E50 VA: 0x155AE50
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x155F448 Offset: 0x155B448 VA: 0x155F448
	|-ConcurrentDictionary<int, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1563C30 Offset: 0x155FC30 VA: 0x1563C30
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x15683D4 Offset: 0x15643D4 VA: 0x15683D4
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x156F598 Offset: 0x156B598 VA: 0x156F598
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155AF50 Offset: 0x1556F50 VA: 0x155AF50
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x155F548 Offset: 0x155B548 VA: 0x155F548
	|-ConcurrentDictionary<int, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x1563D20 Offset: 0x155FD20 VA: 0x1563D20
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x15684C4 Offset: 0x15644C4 VA: 0x15684C4
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x156F6F8 Offset: 0x156B6F8 VA: 0x156F6F8
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155AFB4 Offset: 0x1556FB4 VA: 0x155AFB4
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x155F5AC Offset: 0x155B5AC VA: 0x155F5AC
	|-ConcurrentDictionary<int, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x1563D84 Offset: 0x155FD84 VA: 0x1563D84
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x1568528 Offset: 0x1564528 VA: 0x1568528
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x156F760 Offset: 0x156B760 VA: 0x156F760
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155AFBC Offset: 0x1556FBC VA: 0x155AFBC
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x155F5B4 Offset: 0x155B5B4 VA: 0x155F5B4
	|-ConcurrentDictionary<int, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1563D8C Offset: 0x155FD8C VA: 0x1563D8C
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1568530 Offset: 0x1564530 VA: 0x1568530
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x156F768 Offset: 0x156B768 VA: 0x156F768
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155B0C0 Offset: 0x15570C0 VA: 0x155B0C0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x155F6B8 Offset: 0x155B6B8 VA: 0x155F6B8
	|-ConcurrentDictionary<int, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x1563E78 Offset: 0x155FE78 VA: 0x1563E78
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x156861C Offset: 0x156461C VA: 0x156861C
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x156F8F0 Offset: 0x156B8F0 VA: 0x156F8F0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155B0D0 Offset: 0x15570D0 VA: 0x155B0D0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x155F6C8 Offset: 0x155B6C8 VA: 0x155F6C8
	|-ConcurrentDictionary<int, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1563E88 Offset: 0x155FE88 VA: 0x1563E88
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x156862C Offset: 0x156462C VA: 0x156862C
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x156F904 Offset: 0x156B904 VA: 0x156F904
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155B1CC Offset: 0x15571CC VA: 0x155B1CC
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x155F7C4 Offset: 0x155B7C4 VA: 0x155F7C4
	|-ConcurrentDictionary<int, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1563F9C Offset: 0x155FF9C VA: 0x1563F9C
	|-ConcurrentDictionary<object, bool>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1568724 Offset: 0x1564724 VA: 0x1568724
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x156FAD8 Offset: 0x156BAD8 VA: 0x156FAD8
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155B39C Offset: 0x155739C VA: 0x155B39C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x155F988 Offset: 0x155B988 VA: 0x155F988
	|-ConcurrentDictionary<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1564168 Offset: 0x1560168 VA: 0x1564168
	|-ConcurrentDictionary<object, bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x15688EC Offset: 0x15648EC VA: 0x15688EC
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x156FD34 Offset: 0x156BD34 VA: 0x156FD34
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155B750 Offset: 0x1557750 VA: 0x155B750
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x155FD3C Offset: 0x155BD3C VA: 0x155FD3C
	|-ConcurrentDictionary<int, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x156451C Offset: 0x156051C VA: 0x156451C
	|-ConcurrentDictionary<object, bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x1568C90 Offset: 0x1564C90 VA: 0x1568C90
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x1570114 Offset: 0x156C114 VA: 0x1570114
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155B758 Offset: 0x1557758 VA: 0x155B758
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x155FD44 Offset: 0x155BD44 VA: 0x155FD44
	|-ConcurrentDictionary<int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1564524 Offset: 0x1560524 VA: 0x1564524
	|-ConcurrentDictionary<object, bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1568C98 Offset: 0x1564C98 VA: 0x1568C98
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x157011C Offset: 0x156C11C VA: 0x157011C
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	private void GrowTable(ConcurrentDictionary.Tables<TKey, TValue> tables) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155B7A0 Offset: 0x15577A0 VA: 0x155B7A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GrowTable
	|
	|-RVA: 0x155FD8C Offset: 0x155BD8C VA: 0x155FD8C
	|-ConcurrentDictionary<int, object>.GrowTable
	|
	|-RVA: 0x156456C Offset: 0x156056C VA: 0x156456C
	|-ConcurrentDictionary<object, bool>.GrowTable
	|
	|-RVA: 0x1568CE0 Offset: 0x1564CE0 VA: 0x1568CE0
	|-ConcurrentDictionary<object, object>.GrowTable
	|
	|-RVA: 0x1570164 Offset: 0x156C164 VA: 0x1570164
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GrowTable
	*/

	// RVA: -1 Offset: -1
	private static int GetBucket(int hashcode, int bucketCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155BF30 Offset: 0x1557F30 VA: 0x155BF30
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetBucket
	|
	|-RVA: 0x15604F8 Offset: 0x155C4F8 VA: 0x15604F8
	|-ConcurrentDictionary<int, object>.GetBucket
	|
	|-RVA: 0x1564CD8 Offset: 0x1560CD8 VA: 0x1564CD8
	|-ConcurrentDictionary<object, bool>.GetBucket
	|
	|-RVA: 0x1569448 Offset: 0x1565448 VA: 0x1569448
	|-ConcurrentDictionary<object, object>.GetBucket
	|
	|-RVA: 0x1570CD4 Offset: 0x156CCD4 VA: 0x1570CD4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetBucket
	*/

	// RVA: -1 Offset: -1
	private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155BF40 Offset: 0x1557F40 VA: 0x155BF40
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetBucketAndLockNo
	|
	|-RVA: 0x1560508 Offset: 0x155C508 VA: 0x1560508
	|-ConcurrentDictionary<int, object>.GetBucketAndLockNo
	|
	|-RVA: 0x1564CE8 Offset: 0x1560CE8 VA: 0x1564CE8
	|-ConcurrentDictionary<object, bool>.GetBucketAndLockNo
	|
	|-RVA: 0x1569458 Offset: 0x1565458 VA: 0x1569458
	|-ConcurrentDictionary<object, object>.GetBucketAndLockNo
	|
	|-RVA: 0x1570CE4 Offset: 0x156CCE4 VA: 0x1570CE4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetBucketAndLockNo
	*/

	// RVA: -1 Offset: -1
	private static int get_DefaultConcurrencyLevel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155BF60 Offset: 0x1557F60 VA: 0x155BF60
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0x1560528 Offset: 0x155C528 VA: 0x1560528
	|-ConcurrentDictionary<int, object>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0x1564D08 Offset: 0x1560D08 VA: 0x1564D08
	|-ConcurrentDictionary<object, bool>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0x1569478 Offset: 0x1565478 VA: 0x1569478
	|-ConcurrentDictionary<object, object>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0x1570D04 Offset: 0x156CD04 VA: 0x1570D04
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_DefaultConcurrencyLevel
	*/

	// RVA: -1 Offset: -1
	private void AcquireAllLocks(ref int locksAcquired) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155BFB0 Offset: 0x1557FB0 VA: 0x155BFB0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.AcquireAllLocks
	|
	|-RVA: 0x1560578 Offset: 0x155C578 VA: 0x1560578
	|-ConcurrentDictionary<int, object>.AcquireAllLocks
	|
	|-RVA: 0x1564D58 Offset: 0x1560D58 VA: 0x1564D58
	|-ConcurrentDictionary<object, bool>.AcquireAllLocks
	|
	|-RVA: 0x15694C8 Offset: 0x15654C8 VA: 0x15694C8
	|-ConcurrentDictionary<object, object>.AcquireAllLocks
	|
	|-RVA: 0x1570D54 Offset: 0x156CD54 VA: 0x1570D54
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AcquireAllLocks
	*/

	// RVA: -1 Offset: -1
	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155C0A8 Offset: 0x15580A8 VA: 0x155C0A8
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.AcquireLocks
	|
	|-RVA: 0x1560670 Offset: 0x155C670 VA: 0x1560670
	|-ConcurrentDictionary<int, object>.AcquireLocks
	|
	|-RVA: 0x1564E50 Offset: 0x1560E50 VA: 0x1564E50
	|-ConcurrentDictionary<object, bool>.AcquireLocks
	|
	|-RVA: 0x15695C0 Offset: 0x15655C0 VA: 0x15695C0
	|-ConcurrentDictionary<object, object>.AcquireLocks
	|
	|-RVA: 0x1570E70 Offset: 0x156CE70 VA: 0x1570E70
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AcquireLocks
	*/

	// RVA: -1 Offset: -1
	private void ReleaseLocks(int fromInclusive, int toExclusive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155C1E0 Offset: 0x15581E0 VA: 0x155C1E0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ReleaseLocks
	|
	|-RVA: 0x15607A8 Offset: 0x155C7A8 VA: 0x15607A8
	|-ConcurrentDictionary<int, object>.ReleaseLocks
	|
	|-RVA: 0x1564F88 Offset: 0x1560F88 VA: 0x1564F88
	|-ConcurrentDictionary<object, bool>.ReleaseLocks
	|
	|-RVA: 0x15696F8 Offset: 0x15656F8 VA: 0x15696F8
	|-ConcurrentDictionary<object, object>.ReleaseLocks
	|
	|-RVA: 0x1570FA8 Offset: 0x156CFA8 VA: 0x1570FA8
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ReleaseLocks
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyCollection<TValue> GetValues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155C254 Offset: 0x1558254 VA: 0x155C254
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetValues
	|
	|-RVA: 0x156081C Offset: 0x155C81C VA: 0x156081C
	|-ConcurrentDictionary<int, object>.GetValues
	|
	|-RVA: 0x1564FFC Offset: 0x1560FFC VA: 0x1564FFC
	|-ConcurrentDictionary<object, bool>.GetValues
	|
	|-RVA: 0x156976C Offset: 0x156576C VA: 0x156976C
	|-ConcurrentDictionary<object, object>.GetValues
	|
	|-RVA: 0x157101C Offset: 0x156D01C VA: 0x157101C
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValues
	*/

	[OnSerializing]
	// RVA: -1 Offset: -1
	private void OnSerializing(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155C4EC Offset: 0x15584EC VA: 0x155C4EC
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.OnSerializing
	|
	|-RVA: 0x1560AB4 Offset: 0x155CAB4 VA: 0x1560AB4
	|-ConcurrentDictionary<int, object>.OnSerializing
	|
	|-RVA: 0x1565298 Offset: 0x1561298 VA: 0x1565298
	|-ConcurrentDictionary<object, bool>.OnSerializing
	|
	|-RVA: 0x1569A04 Offset: 0x1565A04 VA: 0x1569A04
	|-ConcurrentDictionary<object, object>.OnSerializing
	|
	|-RVA: 0x15713F4 Offset: 0x156D3F4 VA: 0x15713F4
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnSerializing
	*/

	[OnSerialized]
	// RVA: -1 Offset: -1
	private void OnSerialized(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155C55C Offset: 0x155855C VA: 0x155C55C
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.OnSerialized
	|
	|-RVA: 0x1560B24 Offset: 0x155CB24 VA: 0x1560B24
	|-ConcurrentDictionary<int, object>.OnSerialized
	|
	|-RVA: 0x1565308 Offset: 0x1561308 VA: 0x1565308
	|-ConcurrentDictionary<object, bool>.OnSerialized
	|
	|-RVA: 0x1569A74 Offset: 0x1565A74 VA: 0x1569A74
	|-ConcurrentDictionary<object, object>.OnSerialized
	|
	|-RVA: 0x1571468 Offset: 0x156D468 VA: 0x1571468
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnSerialized
	*/

	[OnDeserialized]
	// RVA: -1 Offset: -1
	private void OnDeserialized(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155C568 Offset: 0x1558568 VA: 0x155C568
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.OnDeserialized
	|
	|-RVA: 0x1560B30 Offset: 0x155CB30 VA: 0x1560B30
	|-ConcurrentDictionary<int, object>.OnDeserialized
	|
	|-RVA: 0x1565314 Offset: 0x1561314 VA: 0x1565314
	|-ConcurrentDictionary<object, bool>.OnDeserialized
	|
	|-RVA: 0x1569A80 Offset: 0x1565A80 VA: 0x1569A80
	|-ConcurrentDictionary<object, object>.OnDeserialized
	|
	|-RVA: 0x1571474 Offset: 0x156D474 VA: 0x1571474
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnDeserialized
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x155C764 Offset: 0x1558764 VA: 0x155C764
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..cctor
	|
	|-RVA: 0x1560D2C Offset: 0x155CD2C VA: 0x1560D2C
	|-ConcurrentDictionary<int, object>..cctor
	|
	|-RVA: 0x1565510 Offset: 0x1561510 VA: 0x1565510
	|-ConcurrentDictionary<object, bool>..cctor
	|
	|-RVA: 0x1569C7C Offset: 0x1565C7C VA: 0x1569C7C
	|-ConcurrentDictionary<object, object>..cctor
	|
	|-RVA: 0x1571678 Offset: 0x156D678 VA: 0x1571678
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: System.Collections.Concurrent
internal sealed class IDictionaryDebugView<K, V> // TypeDefIndex: 1450
{}

// Namespace: System.Collections.Concurrent
internal sealed class IProducerConsumerCollectionDebugView<T> // TypeDefIndex: 1451
{}
