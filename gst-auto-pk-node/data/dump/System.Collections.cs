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

// Namespace: System.Collections
[Serializable]
public sealed class Comparer : IComparer, ISerializable // TypeDefIndex: 1390
{
	// Fields
	private CompareInfo _compareInfo; // 0x10
	public static readonly Comparer Default; // 0x0
	public static readonly Comparer DefaultInvariant; // 0x8

	// Methods

	// RVA: 0x1842648 Offset: 0x183E648 VA: 0x1842648
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x18426D4 Offset: 0x183E6D4 VA: 0x18426D4
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x184284C Offset: 0x183E84C VA: 0x184284C Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18428EC Offset: 0x183E8EC VA: 0x18428EC Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0x1842AE8 Offset: 0x183EAE8 VA: 0x1842AE8
	private static void .cctor() { }
}

// Namespace: System.Collections
[Serializable]
public struct DictionaryEntry // TypeDefIndex: 1391
{
	// Fields
	private object _key; // 0x0
	private object _value; // 0x8

	// Properties
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1842BBC Offset: 0x183EBBC VA: 0x1842BBC
	public void .ctor(object key, object value) { }

	// RVA: 0x1842BEC Offset: 0x183EBEC VA: 0x1842BEC
	public object get_Key() { }

	// RVA: 0x1842BF4 Offset: 0x183EBF4 VA: 0x1842BF4
	public object get_Value() { }
}

// Namespace: System.Collections
internal static class HashHelpers // TypeDefIndex: 1392
{
	// Fields
	public static readonly int[] primes; // 0x0
	private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable; // 0x8

	// Properties
	internal static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable { get; }

	// Methods

	// RVA: 0x1842BFC Offset: 0x183EBFC VA: 0x1842BFC
	public static bool IsPrime(int candidate) { }

	// RVA: 0x1842CA0 Offset: 0x183ECA0 VA: 0x1842CA0
	public static int GetPrime(int min) { }

	// RVA: 0x1842E24 Offset: 0x183EE24 VA: 0x1842E24
	public static int ExpandPrime(int oldSize) { }

	// RVA: 0x1842EA8 Offset: 0x183EEA8 VA: 0x1842EA8
	internal static ConditionalWeakTable<object, SerializationInfo> get_SerializationInfoTable() { }

	// RVA: 0x1842F80 Offset: 0x183EF80 VA: 0x1842F80
	private static void .cctor() { }
}

// Namespace: System.Collections
public interface ICollection : IEnumerable // TypeDefIndex: 1393
{
	// Properties
	public abstract int Count { get; }
	public abstract object SyncRoot { get; }
	public abstract bool IsSynchronized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CopyTo(Array array, int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_SyncRoot();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsSynchronized();
}

// Namespace: System.Collections
public interface IComparer // TypeDefIndex: 1394
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int Compare(object x, object y);
}

// Namespace: System.Collections
[DefaultMember("Item")]
public interface IDictionary : ICollection, IEnumerable // TypeDefIndex: 1395
{
	// Properties
	public abstract object Item { get; set; }
	public abstract ICollection Values { get; }
	public abstract bool IsReadOnly { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Item(object key);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(object key, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICollection get_Values();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool Contains(object key);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Add(object key, object value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IDictionaryEnumerator GetEnumerator();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Remove(object key);
}

// Namespace: System.Collections
public interface IDictionaryEnumerator : IEnumerator // TypeDefIndex: 1396
{
	// Properties
	public abstract object Key { get; }
	public abstract object Value { get; }
	public abstract DictionaryEntry Entry { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Key();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Value();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract DictionaryEntry get_Entry();
}

// Namespace: System.Collections
public interface IEnumerable // TypeDefIndex: 1397
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IEnumerator GetEnumerator();
}

// Namespace: System.Collections
public interface IEnumerator // TypeDefIndex: 1398
{
	// Properties
	public abstract object Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool MoveNext();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_Current();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Reset();
}

// Namespace: System.Collections
public interface IEqualityComparer // TypeDefIndex: 1399
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(object x, object y);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetHashCode(object obj);
}

// Namespace: System.Collections
[DefaultMember("Item")]
public interface IList : ICollection, IEnumerable // TypeDefIndex: 1400
{
	// Properties
	public abstract object Item { get; set; }
	public abstract bool IsReadOnly { get; }
	public abstract bool IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Item(int index, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int Add(object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool Contains(object value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsFixedSize();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int IndexOf(object value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Insert(int index, object value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Remove(object value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void RemoveAt(int index);
}

// Namespace: System.Collections
public interface IStructuralComparable // TypeDefIndex: 1401
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int CompareTo(object other, IComparer comparer);
}

// Namespace: System.Collections
public interface IStructuralEquatable // TypeDefIndex: 1402
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Equals(object other, IEqualityComparer comparer);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int GetHashCode(IEqualityComparer comparer);
}

// Namespace: 
private class ListDictionaryInternal.NodeEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 1403
{
	// Fields
	private ListDictionaryInternal list; // 0x10
	private ListDictionaryInternal.DictionaryNode current; // 0x18
	private int version; // 0x20
	private bool start; // 0x24

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1843898 Offset: 0x183F898 VA: 0x1843898
	public void .ctor(ListDictionaryInternal list) { }

	// RVA: 0x1843A58 Offset: 0x183FA58 VA: 0x1843A58 Slot: 8
	public object get_Current() { }

	// RVA: 0x1843ABC Offset: 0x183FABC VA: 0x1843ABC Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x1843B50 Offset: 0x183FB50 VA: 0x1843B50 Slot: 4
	public object get_Key() { }

	// RVA: 0x1843BAC Offset: 0x183FBAC VA: 0x1843BAC Slot: 5
	public object get_Value() { }

	// RVA: 0x1843C08 Offset: 0x183FC08 VA: 0x1843C08 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x1843CCC Offset: 0x183FCCC VA: 0x1843CCC Slot: 9
	public void Reset() { }
}

// Namespace: 
private class ListDictionaryInternal.NodeKeyValueCollection.NodeKeyValueEnumerator : IEnumerator // TypeDefIndex: 1404
{
	// Fields
	private ListDictionaryInternal list; // 0x10
	private ListDictionaryInternal.DictionaryNode current; // 0x18
	private int version; // 0x20
	private bool isKeys; // 0x24
	private bool start; // 0x25

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1843FC0 Offset: 0x183FFC0 VA: 0x1843FC0
	public void .ctor(ListDictionaryInternal list, bool isKeys) { }

	// RVA: 0x184402C Offset: 0x184002C VA: 0x184402C Slot: 5
	public object get_Current() { }

	// RVA: 0x184409C Offset: 0x184009C VA: 0x184409C Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1844160 Offset: 0x1840160 VA: 0x1844160 Slot: 6
	public void Reset() { }
}

// Namespace: 
private class ListDictionaryInternal.NodeKeyValueCollection : ICollection, IEnumerable // TypeDefIndex: 1405
{
	// Fields
	private ListDictionaryInternal list; // 0x10
	private bool isKeys; // 0x18

	// Properties
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x1843358 Offset: 0x183F358 VA: 0x1843358
	public void .ctor(ListDictionaryInternal list, bool isKeys) { }

	// RVA: 0x1843D4C Offset: 0x183FD4C VA: 0x1843D4C Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1843F08 Offset: 0x183FF08 VA: 0x1843F08 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1843F40 Offset: 0x183FF40 VA: 0x1843F40 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1843F48 Offset: 0x183FF48 VA: 0x1843F48 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1843F5C Offset: 0x183FF5C VA: 0x1843F5C Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: 
[Serializable]
private class ListDictionaryInternal.DictionaryNode // TypeDefIndex: 1406
{
	// Fields
	public object key; // 0x10
	public object value; // 0x18
	public ListDictionaryInternal.DictionaryNode next; // 0x20

	// Methods

	// RVA: 0x184325C Offset: 0x183F25C VA: 0x184325C
	public void .ctor() { }
}

// Namespace: System.Collections
[DefaultMember("Item")]
[Serializable]
internal class ListDictionaryInternal : IDictionary, ICollection, IEnumerable // TypeDefIndex: 1407
{
	// Fields
	private ListDictionaryInternal.DictionaryNode head; // 0x10
	private int version; // 0x18
	private int count; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public object Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x1843020 Offset: 0x183F020 VA: 0x1843020
	public void .ctor() { }

	// RVA: 0x1843028 Offset: 0x183F028 VA: 0x1843028 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x18430DC Offset: 0x183F0DC VA: 0x18430DC Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x1843264 Offset: 0x183F264 VA: 0x1843264 Slot: 14
	public int get_Count() { }

	// RVA: 0x184326C Offset: 0x183F26C VA: 0x184326C Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x1843274 Offset: 0x183F274 VA: 0x1843274 Slot: 16
	public bool get_IsSynchronized() { }

	// RVA: 0x184327C Offset: 0x183F27C VA: 0x184327C Slot: 15
	public object get_SyncRoot() { }

	// RVA: 0x18432EC Offset: 0x183F2EC VA: 0x18432EC Slot: 6
	public ICollection get_Values() { }

	// RVA: 0x1843394 Offset: 0x183F394 VA: 0x1843394 Slot: 8
	public void Add(object key, object value) { }

	// RVA: 0x1843558 Offset: 0x183F558 VA: 0x1843558 Slot: 9
	public void Clear() { }

	// RVA: 0x1843588 Offset: 0x183F588 VA: 0x1843588 Slot: 7
	public bool Contains(object key) { }

	// RVA: 0x184363C Offset: 0x183F63C VA: 0x184363C Slot: 13
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1843840 Offset: 0x183F840 VA: 0x1843840 Slot: 11
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x18438F0 Offset: 0x183F8F0 VA: 0x18438F0 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1843948 Offset: 0x183F948 VA: 0x1843948 Slot: 12
	public void Remove(object key) { }
}

// Namespace: System.Collections
[Serializable]
internal sealed class CompatibleComparer : IEqualityComparer // TypeDefIndex: 1408
{
	// Fields
	private readonly IHashCodeProvider _hcp; // 0x10
	private readonly IComparer _comparer; // 0x18

	// Properties
	internal IHashCodeProvider HashCodeProvider { get; }
	internal IComparer Comparer { get; }

	// Methods

	// RVA: 0x18441E0 Offset: 0x18401E0 VA: 0x18441E0
	internal void .ctor(IHashCodeProvider hashCodeProvider, IComparer comparer) { }

	// RVA: 0x1844224 Offset: 0x1840224 VA: 0x1844224
	internal IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x184422C Offset: 0x184022C VA: 0x184422C
	internal IComparer get_Comparer() { }

	// RVA: 0x1844234 Offset: 0x1840234 VA: 0x1844234 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x184424C Offset: 0x184024C VA: 0x184424C
	public int Compare(object a, object b) { }

	// RVA: 0x184440C Offset: 0x184040C VA: 0x184440C Slot: 5
	public int GetHashCode(object obj) { }
}

// Namespace: System.Collections
[Serializable]
public class CaseInsensitiveComparer : IComparer // TypeDefIndex: 1409
{
	// Fields
	private CompareInfo _compareInfo; // 0x10

	// Properties
	public static CaseInsensitiveComparer Default { get; }

	// Methods

	// RVA: 0x1844514 Offset: 0x1840514 VA: 0x1844514
	public void .ctor() { }

	// RVA: 0x1844598 Offset: 0x1840598 VA: 0x1844598
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x1844624 Offset: 0x1840624 VA: 0x1844624
	public static CaseInsensitiveComparer get_Default() { }

	// RVA: 0x18446AC Offset: 0x18406AC VA: 0x18446AC Slot: 4
	public int Compare(object a, object b) { }
}

// Namespace: System.Collections
[Obsolete("Please use StringComparer instead.")]
[Serializable]
public class CaseInsensitiveHashCodeProvider : IHashCodeProvider // TypeDefIndex: 1410
{
	// Fields
	private readonly CompareInfo _compareInfo; // 0x10

	// Properties
	public static CaseInsensitiveHashCodeProvider Default { get; }

	// Methods

	// RVA: 0x184478C Offset: 0x184078C VA: 0x184478C
	public void .ctor() { }

	// RVA: 0x1844810 Offset: 0x1840810 VA: 0x1844810
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x184489C Offset: 0x184089C VA: 0x184489C
	public static CaseInsensitiveHashCodeProvider get_Default() { }

	// RVA: 0x18448EC Offset: 0x18408EC VA: 0x18448EC Slot: 4
	public int GetHashCode(object obj) { }
}

// Namespace: System.Collections
[Serializable]
public abstract class CollectionBase : IList, ICollection, IEnumerable // TypeDefIndex: 1411
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	protected IList List { get; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x184498C Offset: 0x184098C VA: 0x184498C
	protected void .ctor() { }

	// RVA: 0x1844AA0 Offset: 0x1840AA0 VA: 0x1844AA0
	protected ArrayList get_InnerList() { }

	// RVA: 0x1844AA8 Offset: 0x1840AA8 VA: 0x1844AA8
	protected IList get_List() { }

	// RVA: 0x1844AAC Offset: 0x1840AAC VA: 0x1844AAC Slot: 16
	public int get_Count() { }

	// RVA: 0x1844ACC Offset: 0x1840ACC VA: 0x1844ACC Slot: 8
	public void Clear() { }

	// RVA: 0x1844B18 Offset: 0x1840B18 VA: 0x1844B18 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x1844CEC Offset: 0x1840CEC VA: 0x1844CEC Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1844D0C Offset: 0x1840D0C VA: 0x1844D0C Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1844D2C Offset: 0x1840D2C VA: 0x1844D2C Slot: 18
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1844D4C Offset: 0x1840D4C VA: 0x1844D4C Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1844D6C Offset: 0x1840D6C VA: 0x1844D6C Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1844D8C Offset: 0x1840D8C VA: 0x1844D8C Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1844E44 Offset: 0x1840E44 VA: 0x1844E44 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1845028 Offset: 0x1841028 VA: 0x1845028 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1845048 Offset: 0x1841048 VA: 0x1845048 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1845188 Offset: 0x1841188 VA: 0x1845188 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1845320 Offset: 0x1841320 VA: 0x1845320 Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1845340 Offset: 0x1841340 VA: 0x1845340 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x18454F0 Offset: 0x18414F0 VA: 0x18454F0 Slot: 19
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1845510 Offset: 0x1841510 VA: 0x1845510 Slot: 20
	protected virtual void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x1845514 Offset: 0x1841514 VA: 0x1845514 Slot: 21
	protected virtual void OnInsert(int index, object value) { }

	// RVA: 0x1845518 Offset: 0x1841518 VA: 0x1845518 Slot: 22
	protected virtual void OnClear() { }

	// RVA: 0x184551C Offset: 0x184151C VA: 0x184551C Slot: 23
	protected virtual void OnRemove(int index, object value) { }

	// RVA: 0x1845520 Offset: 0x1841520 VA: 0x1845520 Slot: 24
	protected virtual void OnValidate(object value) { }

	// RVA: 0x1845574 Offset: 0x1841574 VA: 0x1845574 Slot: 25
	protected virtual void OnSetComplete(int index, object oldValue, object newValue) { }

	// RVA: 0x1845578 Offset: 0x1841578 VA: 0x1845578 Slot: 26
	protected virtual void OnInsertComplete(int index, object value) { }

	// RVA: 0x184557C Offset: 0x184157C VA: 0x184557C Slot: 27
	protected virtual void OnClearComplete() { }

	// RVA: 0x1845580 Offset: 0x1841580 VA: 0x1845580 Slot: 28
	protected virtual void OnRemoveComplete(int index, object value) { }
}

// Namespace: 
[Serializable]
private class Queue.QueueEnumerator : IEnumerator, ICloneable // TypeDefIndex: 1412
{
	// Fields
	private Queue _q; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object _currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x1845F68 Offset: 0x1841F68 VA: 0x1845F68
	internal void .ctor(Queue q) { }

	// RVA: 0x1846190 Offset: 0x1842190 VA: 0x1846190 Slot: 7
	public object Clone() { }

	// RVA: 0x1846198 Offset: 0x1842198 VA: 0x1846198 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x184627C Offset: 0x184227C VA: 0x184627C Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x184630C Offset: 0x184230C VA: 0x184630C Slot: 10
	public virtual void Reset() { }
}

// Namespace: 
internal class Queue.QueueDebugView // TypeDefIndex: 1413
{}

// Namespace: System.Collections
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(Queue.QueueDebugView))]
[Serializable]
public class Queue : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1414
{
	// Fields
	private object[] _array; // 0x10
	private int _head; // 0x18
	private int _tail; // 0x1C
	private int _size; // 0x20
	private int _growFactor; // 0x24
	private int _version; // 0x28
	private object _syncRoot; // 0x30

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x1845584 Offset: 0x1841584 VA: 0x1845584
	public void .ctor() { }

	// RVA: 0x1845750 Offset: 0x1841750 VA: 0x1845750
	public void .ctor(int capacity) { }

	// RVA: 0x1845590 Offset: 0x1841590 VA: 0x1845590
	public void .ctor(int capacity, float growFactor) { }

	// RVA: 0x1845758 Offset: 0x1841758 VA: 0x1845758
	public void .ctor(ICollection col) { }

	// RVA: 0x18459D0 Offset: 0x18419D0 VA: 0x18459D0 Slot: 10
	public virtual int get_Count() { }

	// RVA: 0x18459D8 Offset: 0x18419D8 VA: 0x18459D8 Slot: 11
	public virtual object Clone() { }

	// RVA: 0x1845AB8 Offset: 0x1841AB8 VA: 0x1845AB8 Slot: 12
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x1845AC0 Offset: 0x1841AC0 VA: 0x1845AC0 Slot: 13
	public virtual object get_SyncRoot() { }

	// RVA: 0x1845B34 Offset: 0x1841B34 VA: 0x1845B34 Slot: 14
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x1845D18 Offset: 0x1841D18 VA: 0x1845D18 Slot: 15
	public virtual void Enqueue(object obj) { }

	// RVA: 0x1845F10 Offset: 0x1841F10 VA: 0x1845F10 Slot: 16
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1845FE0 Offset: 0x1841FE0 VA: 0x1845FE0 Slot: 17
	public virtual object Dequeue() { }

	// RVA: 0x18460C0 Offset: 0x18420C0 VA: 0x18460C0 Slot: 18
	public virtual object Peek() { }

	// RVA: 0x1846150 Offset: 0x1842150 VA: 0x1846150
	internal object GetElement(int i) { }

	// RVA: 0x1845E1C Offset: 0x1841E1C VA: 0x1845E1C
	private void SetCapacity(int capacity) { }
}

// Namespace: System.Collections
[Serializable]
public abstract class ReadOnlyCollectionBase : ICollection, IEnumerable // TypeDefIndex: 1415
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	protected ArrayList InnerList { get; }
	public virtual int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x1846394 Offset: 0x1842394 VA: 0x1846394
	protected ArrayList get_InnerList() { }

	// RVA: 0x1846400 Offset: 0x1842400 VA: 0x1846400 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x1846424 Offset: 0x1842424 VA: 0x1846424 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1846448 Offset: 0x1842448 VA: 0x1846448 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x184646C Offset: 0x184246C VA: 0x184646C Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x18464A8 Offset: 0x18424A8 VA: 0x18464A8 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x18464CC Offset: 0x18424CC VA: 0x18464CC
	protected void .ctor() { }
}

// Namespace: 
[DefaultMember("Item")]
[Serializable]
private class SortedList.SyncSortedList : SortedList // TypeDefIndex: 1416
{
	// Fields
	private SortedList _list; // 0x40
	private object _root; // 0x48

	// Properties
	public override int Count { get; }
	public override object SyncRoot { get; }
	public override bool IsReadOnly { get; }
	public override bool IsSynchronized { get; }
	public override object Item { get; set; }

	// Methods

	// RVA: 0x18479B4 Offset: 0x18439B4 VA: 0x18479B4
	internal void .ctor(SortedList list) { }

	// RVA: 0x1847A18 Offset: 0x1843A18 VA: 0x1847A18 Slot: 21
	public override int get_Count() { }

	// RVA: 0x1847AFC Offset: 0x1843AFC VA: 0x1847AFC Slot: 25
	public override object get_SyncRoot() { }

	// RVA: 0x1847B04 Offset: 0x1843B04 VA: 0x1847B04 Slot: 23
	public override bool get_IsReadOnly() { }

	// RVA: 0x1847B24 Offset: 0x1843B24 VA: 0x1847B24 Slot: 24
	public override bool get_IsSynchronized() { }

	// RVA: 0x1847B2C Offset: 0x1843B2C VA: 0x1847B2C Slot: 36
	public override object get_Item(object key) { }

	// RVA: 0x1847C18 Offset: 0x1843C18 VA: 0x1847C18 Slot: 37
	public override void set_Item(object key, object value) { }

	// RVA: 0x1847D00 Offset: 0x1843D00 VA: 0x1847D00 Slot: 19
	public override void Add(object key, object value) { }

	// RVA: 0x1847DE8 Offset: 0x1843DE8 VA: 0x1847DE8 Slot: 26
	public override void Clear() { }

	// RVA: 0x1847EB8 Offset: 0x1843EB8 VA: 0x1847EB8 Slot: 27
	public override object Clone() { }

	// RVA: 0x1847F9C Offset: 0x1843F9C VA: 0x1847F9C Slot: 28
	public override bool Contains(object key) { }

	// RVA: 0x1848088 Offset: 0x1844088 VA: 0x1848088 Slot: 29
	public override bool ContainsKey(object key) { }

	// RVA: 0x1848174 Offset: 0x1844174 VA: 0x1848174 Slot: 30
	public override bool ContainsValue(object key) { }

	// RVA: 0x1848260 Offset: 0x1844260 VA: 0x1848260 Slot: 31
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x1848348 Offset: 0x1844348 VA: 0x1848348 Slot: 32
	public override object GetByIndex(int index) { }

	// RVA: 0x1848434 Offset: 0x1844434 VA: 0x1848434 Slot: 33
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1848518 Offset: 0x1844518 VA: 0x1848518 Slot: 34
	public override object GetKey(int index) { }

	// RVA: 0x1848604 Offset: 0x1844604 VA: 0x1848604 Slot: 35
	public override IList GetValueList() { }

	// RVA: 0x18486E8 Offset: 0x18446E8 VA: 0x18486E8 Slot: 38
	public override int IndexOfKey(object key) { }

	// RVA: 0x1848838 Offset: 0x1844838 VA: 0x1848838 Slot: 39
	public override int IndexOfValue(object value) { }

	// RVA: 0x1848924 Offset: 0x1844924 VA: 0x1848924 Slot: 40
	public override void RemoveAt(int index) { }

	// RVA: 0x1848A00 Offset: 0x1844A00 VA: 0x1848A00 Slot: 41
	public override void Remove(object key) { }
}

// Namespace: 
[Serializable]
private class SortedList.SortedListEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 1417
{
	// Fields
	private SortedList _sortedList; // 0x10
	private object _key; // 0x18
	private object _value; // 0x20
	private int _index; // 0x28
	private int _startIndex; // 0x2C
	private int _endIndex; // 0x30
	private int _version; // 0x34
	private bool _current; // 0x38
	private int _getObjectRetType; // 0x3C

	// Properties
	public virtual object Key { get; }
	public virtual DictionaryEntry Entry { get; }
	public virtual object Current { get; }
	public virtual object Value { get; }

	// Methods

	// RVA: 0x18472CC Offset: 0x18432CC VA: 0x18472CC
	internal void .ctor(SortedList sortedList, int index, int count, int getObjRetType) { }

	// RVA: 0x1848ADC Offset: 0x1844ADC VA: 0x1848ADC Slot: 10
	public object Clone() { }

	// RVA: 0x1848AE4 Offset: 0x1844AE4 VA: 0x1848AE4 Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x1848B80 Offset: 0x1844B80 VA: 0x1848B80 Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x1848CC0 Offset: 0x1844CC0 VA: 0x1848CC0 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x1848D90 Offset: 0x1844D90 VA: 0x1848D90 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x1848E84 Offset: 0x1844E84 VA: 0x1848E84 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x1848F20 Offset: 0x1844F20 VA: 0x1848F20 Slot: 16
	public virtual void Reset() { }
}

// Namespace: 
[DefaultMember("Item")]
[TypeForwardedFrom("mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
[Serializable]
private class SortedList.ValueList : IList, ICollection, IEnumerable // TypeDefIndex: 1418
{
	// Fields
	private SortedList sortedList; // 0x10

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x18474E8 Offset: 0x18434E8 VA: 0x18474E8
	internal void .ctor(SortedList sortedList) { }

	// RVA: 0x1848FBC Offset: 0x1844FBC VA: 0x1848FBC Slot: 20
	public virtual int get_Count() { }

	// RVA: 0x1848FD4 Offset: 0x1844FD4 VA: 0x1848FD4 Slot: 21
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x1848FDC Offset: 0x1844FDC VA: 0x1848FDC Slot: 22
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x1848FE4 Offset: 0x1844FE4 VA: 0x1848FE4 Slot: 23
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x1849004 Offset: 0x1845004 VA: 0x1849004 Slot: 24
	public virtual object get_SyncRoot() { }

	// RVA: 0x1849024 Offset: 0x1845024 VA: 0x1849024 Slot: 25
	public virtual int Add(object key) { }

	// RVA: 0x1849070 Offset: 0x1845070 VA: 0x1849070 Slot: 26
	public virtual void Clear() { }

	// RVA: 0x18490BC Offset: 0x18450BC VA: 0x18490BC Slot: 27
	public virtual bool Contains(object value) { }

	// RVA: 0x18490DC Offset: 0x18450DC VA: 0x18490DC Slot: 28
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x18491A8 Offset: 0x18451A8 VA: 0x18491A8 Slot: 29
	public virtual void Insert(int index, object value) { }

	// RVA: 0x18491F4 Offset: 0x18451F4 VA: 0x18491F4 Slot: 30
	public virtual object get_Item(int index) { }

	// RVA: 0x1849214 Offset: 0x1845214 VA: 0x1849214 Slot: 31
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x1849260 Offset: 0x1845260 VA: 0x1849260 Slot: 32
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x18492EC Offset: 0x18452EC VA: 0x18492EC Slot: 33
	public virtual int IndexOf(object value) { }

	// RVA: 0x1849364 Offset: 0x1845364 VA: 0x1849364 Slot: 34
	public virtual void Remove(object value) { }

	// RVA: 0x18493B0 Offset: 0x18453B0 VA: 0x18493B0 Slot: 35
	public virtual void RemoveAt(int index) { }
}

// Namespace: 
internal class SortedList.SortedListDebugView // TypeDefIndex: 1419
{}

// Namespace: System.Collections
[DebuggerTypeProxy(typeof(SortedList.SortedListDebugView))]
[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[Serializable]
public class SortedList : IDictionary, ICollection, IEnumerable, ICloneable // TypeDefIndex: 1420
{
	// Fields
	private object[] keys; // 0x10
	private object[] values; // 0x18
	private int _size; // 0x20
	private int version; // 0x24
	private IComparer comparer; // 0x28
	private SortedList.ValueList valueList; // 0x30
	private object _syncRoot; // 0x38

	// Properties
	public virtual int Capacity { set; }
	public virtual int Count { get; }
	public virtual ICollection Values { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x18464D4 Offset: 0x18424D4 VA: 0x18464D4
	public void .ctor() { }

	// RVA: 0x18464F0 Offset: 0x18424F0 VA: 0x18464F0
	private void Init() { }

	// RVA: 0x1846670 Offset: 0x1842670 VA: 0x1846670
	public void .ctor(int initialCapacity) { }

	// RVA: 0x18467C8 Offset: 0x18427C8 VA: 0x18467C8
	public void .ctor(IComparer comparer) { }

	// RVA: 0x1846810 Offset: 0x1842810 VA: 0x1846810 Slot: 19
	public virtual void Add(object key, object value) { }

	// RVA: 0x1846A74 Offset: 0x1842A74 VA: 0x1846A74 Slot: 20
	public virtual void set_Capacity(int value) { }

	// RVA: 0x1846CC8 Offset: 0x1842CC8 VA: 0x1846CC8 Slot: 21
	public virtual int get_Count() { }

	// RVA: 0x1846CD0 Offset: 0x1842CD0 VA: 0x1846CD0 Slot: 22
	public virtual ICollection get_Values() { }

	// RVA: 0x1846CE0 Offset: 0x1842CE0 VA: 0x1846CE0 Slot: 23
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x1846CE8 Offset: 0x1842CE8 VA: 0x1846CE8 Slot: 24
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x1846CF0 Offset: 0x1842CF0 VA: 0x1846CF0 Slot: 25
	public virtual object get_SyncRoot() { }

	// RVA: 0x1846D60 Offset: 0x1842D60 VA: 0x1846D60 Slot: 26
	public virtual void Clear() { }

	// RVA: 0x1846DA4 Offset: 0x1842DA4 VA: 0x1846DA4 Slot: 27
	public virtual object Clone() { }

	// RVA: 0x1846E58 Offset: 0x1842E58 VA: 0x1846E58 Slot: 28
	public virtual bool Contains(object key) { }

	// RVA: 0x1846E7C Offset: 0x1842E7C VA: 0x1846E7C Slot: 29
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x1846EA0 Offset: 0x1842EA0 VA: 0x1846EA0 Slot: 30
	public virtual bool ContainsValue(object value) { }

	// RVA: 0x1846EC4 Offset: 0x1842EC4 VA: 0x1846EC4 Slot: 31
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1847164 Offset: 0x1843164 VA: 0x1847164
	private void EnsureCapacity(int min) { }

	// RVA: 0x18471AC Offset: 0x18431AC VA: 0x18471AC Slot: 32
	public virtual object GetByIndex(int index) { }

	// RVA: 0x1847264 Offset: 0x1843264 VA: 0x1847264 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1847344 Offset: 0x1843344 VA: 0x1847344 Slot: 33
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x18473AC Offset: 0x18433AC VA: 0x18473AC Slot: 34
	public virtual object GetKey(int index) { }

	// RVA: 0x1847464 Offset: 0x1843464 VA: 0x1847464 Slot: 35
	public virtual IList GetValueList() { }

	// RVA: 0x1847518 Offset: 0x1843518 VA: 0x1847518 Slot: 36
	public virtual object get_Item(object key) { }

	// RVA: 0x1847568 Offset: 0x1843568 VA: 0x1847568 Slot: 37
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x1847690 Offset: 0x1843690 VA: 0x1847690 Slot: 38
	public virtual int IndexOfKey(object key) { }

	// RVA: 0x184772C Offset: 0x184372C VA: 0x184772C Slot: 39
	public virtual int IndexOfValue(object value) { }

	// RVA: 0x1846934 Offset: 0x1842934 VA: 0x1846934
	private void Insert(int index, object key, object value) { }

	// RVA: 0x184778C Offset: 0x184378C VA: 0x184778C Slot: 40
	public virtual void RemoveAt(int index) { }

	// RVA: 0x18478D0 Offset: 0x18438D0 VA: 0x18478D0 Slot: 41
	public virtual void Remove(object key) { }

	// RVA: 0x1847910 Offset: 0x1843910 VA: 0x1847910
	public static SortedList Synchronized(SortedList list) { }
}

// Namespace: 
[Serializable]
private class Stack.StackEnumerator : IEnumerator, ICloneable // TypeDefIndex: 1421
{
	// Fields
	private Stack _stack; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object _currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x184998C Offset: 0x184598C VA: 0x184998C
	internal void .ctor(Stack stack) { }

	// RVA: 0x1849C2C Offset: 0x1845C2C VA: 0x1849C2C Slot: 7
	public object Clone() { }

	// RVA: 0x1849C34 Offset: 0x1845C34 VA: 0x1849C34 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x1849D18 Offset: 0x1845D18 VA: 0x1849D18 Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x1849DA4 Offset: 0x1845DA4 VA: 0x1849DA4 Slot: 10
	public virtual void Reset() { }
}

// Namespace: 
internal class Stack.StackDebugView // TypeDefIndex: 1422
{}

// Namespace: System.Collections
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(Stack.StackDebugView))]
[Serializable]
public class Stack : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1423
{
	// Fields
	private object[] _array; // 0x10
	private int _size; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x18493FC Offset: 0x18453FC VA: 0x18493FC
	public void .ctor() { }

	// RVA: 0x1849468 Offset: 0x1845468 VA: 0x1849468
	public void .ctor(int initialCapacity) { }

	// RVA: 0x1849540 Offset: 0x1845540 VA: 0x1849540 Slot: 10
	public virtual int get_Count() { }

	// RVA: 0x1849548 Offset: 0x1845548 VA: 0x1849548 Slot: 11
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x1849550 Offset: 0x1845550 VA: 0x1849550 Slot: 12
	public virtual object get_SyncRoot() { }

	// RVA: 0x18495C0 Offset: 0x18455C0 VA: 0x18495C0 Slot: 13
	public virtual void Clear() { }

	// RVA: 0x18495F0 Offset: 0x18455F0 VA: 0x18495F0 Slot: 14
	public virtual object Clone() { }

	// RVA: 0x184967C Offset: 0x184567C VA: 0x184967C Slot: 15
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x1849934 Offset: 0x1845934 VA: 0x1849934 Slot: 16
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x18499E8 Offset: 0x18459E8 VA: 0x18499E8 Slot: 17
	public virtual object Peek() { }

	// RVA: 0x1849A6C Offset: 0x1845A6C VA: 0x1849A6C Slot: 18
	public virtual object Pop() { }

	// RVA: 0x1849B0C Offset: 0x1845B0C VA: 0x1849B0C Slot: 19
	public virtual void Push(object obj) { }
}

// Namespace: 
[Serializable]
private class BitArray.BitArrayEnumeratorSimple : IEnumerator, ICloneable // TypeDefIndex: 1424
{
	// Fields
	private BitArray bitarray; // 0x10
	private int index; // 0x18
	private int version; // 0x1C
	private bool currentElement; // 0x20

	// Properties
	public virtual object Current { get; }

	// Methods

	// RVA: 0x184AA30 Offset: 0x1846A30 VA: 0x184AA30
	internal void .ctor(BitArray bitarray) { }

	// RVA: 0x184AA80 Offset: 0x1846A80 VA: 0x184AA80 Slot: 7
	public object Clone() { }

	// RVA: 0x184AA88 Offset: 0x1846A88 VA: 0x184AA88 Slot: 8
	public virtual bool MoveNext() { }

	// RVA: 0x184AC2C Offset: 0x1846C2C VA: 0x184AC2C Slot: 9
	public virtual object get_Current() { }

	// RVA: 0x184AD74 Offset: 0x1846D74 VA: 0x184AD74 Slot: 6
	public void Reset() { }
}

// Namespace: System.Collections
[DefaultMember("Item")]
[Serializable]
public sealed class BitArray : ICollection, IEnumerable, ICloneable // TypeDefIndex: 1425
{
	// Fields
	private int[] m_array; // 0x10
	private int m_length; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public bool Item { get; set; }
	public int Length { get; set; }
	public int Count { get; }
	public object SyncRoot { get; }
	public bool IsSynchronized { get; }

	// Methods

	// RVA: 0x1849E24 Offset: 0x1845E24 VA: 0x1849E24
	public void .ctor(int length) { }

	// RVA: 0x1849E2C Offset: 0x1845E2C VA: 0x1849E2C
	public void .ctor(int length, bool defaultValue) { }

	// RVA: 0x1849F98 Offset: 0x1845F98 VA: 0x1849F98
	public void .ctor(BitArray bits) { }

	// RVA: 0x184A088 Offset: 0x1846088 VA: 0x184A088
	public bool get_Item(int index) { }

	// RVA: 0x184A164 Offset: 0x1846164 VA: 0x184A164
	public void set_Item(int index, bool value) { }

	// RVA: 0x184A08C Offset: 0x184608C VA: 0x184A08C
	public bool Get(int index) { }

	// RVA: 0x184A168 Offset: 0x1846168 VA: 0x184A168
	public void Set(int index, bool value) { }

	// RVA: 0x184A284 Offset: 0x1846284 VA: 0x184A284
	public int get_Length() { }

	// RVA: 0x184A28C Offset: 0x184628C VA: 0x184A28C
	public void set_Length(int value) { }

	// RVA: 0x184A420 Offset: 0x1846420 VA: 0x184A420 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x184A900 Offset: 0x1846900 VA: 0x184A900 Slot: 5
	public int get_Count() { }

	// RVA: 0x184A908 Offset: 0x1846908 VA: 0x184A908 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x184A978 Offset: 0x1846978 VA: 0x184A978 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x184A980 Offset: 0x1846980 VA: 0x184A980 Slot: 9
	public object Clone() { }

	// RVA: 0x184A9D8 Offset: 0x18469D8 VA: 0x184A9D8 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1849F7C Offset: 0x1845F7C VA: 0x1849F7C
	private static int GetArrayLength(int n, int div) { }
}

// Namespace: 
[DefaultMember("Item")]
[Serializable]
private class ArrayList.IListWrapper : ArrayList // TypeDefIndex: 1426
{
	// Fields
	private IList _list; // 0x28

	// Properties
	public override int Capacity { set; }
	public override int Count { get; }
	public override bool IsReadOnly { get; }
	public override bool IsFixedSize { get; }
	public override bool IsSynchronized { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }

	// Methods

	// RVA: 0x184B524 Offset: 0x1847524 VA: 0x184B524
	internal void .ctor(IList list) { }

	// RVA: 0x184C560 Offset: 0x1848560 VA: 0x184C560 Slot: 21
	public override void set_Capacity(int value) { }

	// RVA: 0x184C5F0 Offset: 0x18485F0 VA: 0x184C5F0 Slot: 22
	public override int get_Count() { }

	// RVA: 0x184C694 Offset: 0x1848694 VA: 0x184C694 Slot: 24
	public override bool get_IsReadOnly() { }

	// RVA: 0x184C738 Offset: 0x1848738 VA: 0x184C738 Slot: 23
	public override bool get_IsFixedSize() { }

	// RVA: 0x184C7DC Offset: 0x18487DC VA: 0x184C7DC Slot: 25
	public override bool get_IsSynchronized() { }

	// RVA: 0x184C880 Offset: 0x1848880 VA: 0x184C880 Slot: 27
	public override object get_Item(int index) { }

	// RVA: 0x184C928 Offset: 0x1848928 VA: 0x184C928 Slot: 28
	public override void set_Item(int index, object value) { }

	// RVA: 0x184C9F4 Offset: 0x18489F4 VA: 0x184C9F4 Slot: 26
	public override object get_SyncRoot() { }

	// RVA: 0x184CA98 Offset: 0x1848A98 VA: 0x184CA98 Slot: 29
	public override int Add(object obj) { }

	// RVA: 0x184CB54 Offset: 0x1848B54 VA: 0x184CB54 Slot: 30
	public override void AddRange(ICollection c) { }

	// RVA: 0x184CB9C Offset: 0x1848B9C VA: 0x184CB9C Slot: 31
	public override void Clear() { }

	// RVA: 0x184CD00 Offset: 0x1848D00 VA: 0x184CD00 Slot: 32
	public override object Clone() { }

	// RVA: 0x184CD6C Offset: 0x1848D6C VA: 0x184CD6C Slot: 33
	public override bool Contains(object obj) { }

	// RVA: 0x184CE18 Offset: 0x1848E18 VA: 0x184CE18 Slot: 35
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x184CED0 Offset: 0x1848ED0 VA: 0x184CED0 Slot: 36
	public override void CopyTo(int index, Array array, int arrayIndex, int count) { }

	// RVA: 0x184D204 Offset: 0x1849204 VA: 0x184D204 Slot: 37
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x184D2A4 Offset: 0x18492A4 VA: 0x184D2A4 Slot: 38
	public override int IndexOf(object value) { }

	// RVA: 0x184D350 Offset: 0x1849350 VA: 0x184D350 Slot: 39
	public override void Insert(int index, object obj) { }

	// RVA: 0x184D41C Offset: 0x184941C VA: 0x184D41C Slot: 40
	public override void InsertRange(int index, ICollection c) { }

	// RVA: 0x184D7E4 Offset: 0x18497E4 VA: 0x184D7E4 Slot: 41
	public override void Remove(object value) { }

	// RVA: 0x184D824 Offset: 0x1849824 VA: 0x184D824 Slot: 42
	public override void RemoveAt(int index) { }

	// RVA: 0x184D8E0 Offset: 0x18498E0 VA: 0x184D8E0 Slot: 43
	public override void RemoveRange(int index, int count) { }

	// RVA: 0x184DAF8 Offset: 0x1849AF8 VA: 0x184DAF8 Slot: 45
	public override void Sort(int index, int count, IComparer comparer) { }

	// RVA: 0x184DDB0 Offset: 0x1849DB0 VA: 0x184DDB0 Slot: 46
	public override object[] ToArray() { }

	// RVA: 0x184DF24 Offset: 0x1849F24 VA: 0x184DF24 Slot: 47
	public override Array ToArray(Type type) { }
}

// Namespace: 
[DefaultMember("Item")]
[Serializable]
private class ArrayList.ReadOnlyArrayList : ArrayList // TypeDefIndex: 1427
{
	// Fields
	private ArrayList _list; // 0x28

	// Properties
	public override int Count { get; }
	public override bool IsReadOnly { get; }
	public override bool IsFixedSize { get; }
	public override bool IsSynchronized { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }
	public override int Capacity { set; }

	// Methods

	// RVA: 0x184BF94 Offset: 0x1847F94 VA: 0x184BF94
	internal void .ctor(ArrayList l) { }

	// RVA: 0x184E0CC Offset: 0x184A0CC VA: 0x184E0CC Slot: 22
	public override int get_Count() { }

	// RVA: 0x184E0EC Offset: 0x184A0EC VA: 0x184E0EC Slot: 24
	public override bool get_IsReadOnly() { }

	// RVA: 0x184E0F4 Offset: 0x184A0F4 VA: 0x184E0F4 Slot: 23
	public override bool get_IsFixedSize() { }

	// RVA: 0x184E0FC Offset: 0x184A0FC VA: 0x184E0FC Slot: 25
	public override bool get_IsSynchronized() { }

	// RVA: 0x184E11C Offset: 0x184A11C VA: 0x184E11C Slot: 27
	public override object get_Item(int index) { }

	// RVA: 0x184E13C Offset: 0x184A13C VA: 0x184E13C Slot: 28
	public override void set_Item(int index, object value) { }

	// RVA: 0x184E188 Offset: 0x184A188 VA: 0x184E188 Slot: 26
	public override object get_SyncRoot() { }

	// RVA: 0x184E1A8 Offset: 0x184A1A8 VA: 0x184E1A8 Slot: 29
	public override int Add(object obj) { }

	// RVA: 0x184E1F4 Offset: 0x184A1F4 VA: 0x184E1F4 Slot: 30
	public override void AddRange(ICollection c) { }

	// RVA: 0x184E240 Offset: 0x184A240 VA: 0x184E240 Slot: 21
	public override void set_Capacity(int value) { }

	// RVA: 0x184E28C Offset: 0x184A28C VA: 0x184E28C Slot: 31
	public override void Clear() { }

	// RVA: 0x184E2D8 Offset: 0x184A2D8 VA: 0x184E2D8 Slot: 32
	public override object Clone() { }

	// RVA: 0x184E3F0 Offset: 0x184A3F0 VA: 0x184E3F0 Slot: 33
	public override bool Contains(object obj) { }

	// RVA: 0x184E410 Offset: 0x184A410 VA: 0x184E410 Slot: 35
	public override void CopyTo(Array array, int index) { }

	// RVA: 0x184E430 Offset: 0x184A430 VA: 0x184E430 Slot: 36
	public override void CopyTo(int index, Array array, int arrayIndex, int count) { }

	// RVA: 0x184E450 Offset: 0x184A450 VA: 0x184E450 Slot: 37
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x184E470 Offset: 0x184A470 VA: 0x184E470 Slot: 38
	public override int IndexOf(object value) { }

	// RVA: 0x184E490 Offset: 0x184A490 VA: 0x184E490 Slot: 39
	public override void Insert(int index, object obj) { }

	// RVA: 0x184E4DC Offset: 0x184A4DC VA: 0x184E4DC Slot: 40
	public override void InsertRange(int index, ICollection c) { }

	// RVA: 0x184E528 Offset: 0x184A528 VA: 0x184E528 Slot: 41
	public override void Remove(object value) { }

	// RVA: 0x184E574 Offset: 0x184A574 VA: 0x184E574 Slot: 42
	public override void RemoveAt(int index) { }

	// RVA: 0x184E5C0 Offset: 0x184A5C0 VA: 0x184E5C0 Slot: 43
	public override void RemoveRange(int index, int count) { }

	// RVA: 0x184E60C Offset: 0x184A60C VA: 0x184E60C Slot: 45
	public override void Sort(int index, int count, IComparer comparer) { }

	// RVA: 0x184E658 Offset: 0x184A658 VA: 0x184E658 Slot: 46
	public override object[] ToArray() { }

	// RVA: 0x184E678 Offset: 0x184A678 VA: 0x184E678 Slot: 47
	public override Array ToArray(Type type) { }
}

// Namespace: 
[Serializable]
private sealed class ArrayList.ArrayListEnumeratorSimple : IEnumerator, ICloneable // TypeDefIndex: 1428
{
	// Fields
	private ArrayList _list; // 0x10
	private int _index; // 0x18
	private int _version; // 0x1C
	private object _currentElement; // 0x20
	private bool _isArrayList; // 0x28
	private static object s_dummyObject; // 0x0

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x184BA1C Offset: 0x1847A1C VA: 0x184BA1C
	internal void .ctor(ArrayList list) { }

	// RVA: 0x184E698 Offset: 0x184A698 VA: 0x184E698 Slot: 7
	public object Clone() { }

	// RVA: 0x184E6A0 Offset: 0x184A6A0 VA: 0x184E6A0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x184E880 Offset: 0x184A880 VA: 0x184E880 Slot: 5
	public object get_Current() { }

	// RVA: 0x184E94C Offset: 0x184A94C VA: 0x184E94C Slot: 6
	public void Reset() { }

	// RVA: 0x184EA20 Offset: 0x184AA20 VA: 0x184EA20
	private static void .cctor() { }
}

// Namespace: 
internal class ArrayList.ArrayListDebugView // TypeDefIndex: 1429
{}

// Namespace: System.Collections
[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(ArrayList.ArrayListDebugView))]
[Serializable]
public class ArrayList : IList, ICollection, IEnumerable, ICloneable // TypeDefIndex: 1430
{
	// Fields
	private object[] _items; // 0x10
	private int _size; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public virtual int Capacity { set; }
	public virtual int Count { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x18449F4 Offset: 0x18409F4 VA: 0x18449F4
	public void .ctor() { }

	// RVA: 0x184ADEC Offset: 0x1846DEC VA: 0x184ADEC
	public void .ctor(int capacity) { }

	// RVA: 0x184AF4C Offset: 0x1846F4C VA: 0x184AF4C
	public void .ctor(ICollection c) { }

	// RVA: 0x184B120 Offset: 0x1847120 VA: 0x184B120 Slot: 21
	public virtual void set_Capacity(int value) { }

	// RVA: 0x184B24C Offset: 0x184724C VA: 0x184B24C Slot: 22
	public virtual int get_Count() { }

	// RVA: 0x184B254 Offset: 0x1847254 VA: 0x184B254 Slot: 23
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x184B25C Offset: 0x184725C VA: 0x184B25C Slot: 24
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x184B264 Offset: 0x1847264 VA: 0x184B264 Slot: 25
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x184B26C Offset: 0x184726C VA: 0x184B26C Slot: 26
	public virtual object get_SyncRoot() { }

	// RVA: 0x184B2DC Offset: 0x18472DC VA: 0x184B2DC Slot: 27
	public virtual object get_Item(int index) { }

	// RVA: 0x184B380 Offset: 0x1847380 VA: 0x184B380 Slot: 28
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x184B470 Offset: 0x1847470 VA: 0x184B470
	public static ArrayList Adapter(IList list) { }

	// RVA: 0x184B558 Offset: 0x1847558 VA: 0x184B558 Slot: 29
	public virtual int Add(object value) { }

	// RVA: 0x184B65C Offset: 0x184765C VA: 0x184B65C Slot: 30
	public virtual void AddRange(ICollection c) { }

	// RVA: 0x184B674 Offset: 0x1847674 VA: 0x184B674 Slot: 31
	public virtual void Clear() { }

	// RVA: 0x184B6B0 Offset: 0x18476B0 VA: 0x184B6B0 Slot: 32
	public virtual object Clone() { }

	// RVA: 0x184B738 Offset: 0x1847738 VA: 0x184B738 Slot: 33
	public virtual bool Contains(object item) { }

	// RVA: 0x184B804 Offset: 0x1847804 VA: 0x184B804 Slot: 34
	public virtual void CopyTo(Array array) { }

	// RVA: 0x184B818 Offset: 0x1847818 VA: 0x184B818 Slot: 35
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x184B8C4 Offset: 0x18478C4 VA: 0x184B8C4 Slot: 36
	public virtual void CopyTo(int index, Array array, int arrayIndex, int count) { }

	// RVA: 0x184B608 Offset: 0x1847608 VA: 0x184B608
	private void EnsureCapacity(int min) { }

	// RVA: 0x184B9C4 Offset: 0x18479C4 VA: 0x184B9C4 Slot: 37
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x184BB30 Offset: 0x1847B30 VA: 0x184BB30 Slot: 38
	public virtual int IndexOf(object value) { }

	// RVA: 0x184BB48 Offset: 0x1847B48 VA: 0x184BB48 Slot: 39
	public virtual void Insert(int index, object value) { }

	// RVA: 0x184BC84 Offset: 0x1847C84 VA: 0x184BC84 Slot: 40
	public virtual void InsertRange(int index, ICollection c) { }

	// RVA: 0x184BEE4 Offset: 0x1847EE4 VA: 0x184BEE4
	public static ArrayList ReadOnly(ArrayList list) { }

	// RVA: 0x184BFC0 Offset: 0x1847FC0 VA: 0x184BFC0 Slot: 41
	public virtual void Remove(object obj) { }

	// RVA: 0x184C000 Offset: 0x1848000 VA: 0x184C000 Slot: 42
	public virtual void RemoveAt(int index) { }

	// RVA: 0x184C0E8 Offset: 0x18480E8 VA: 0x184C0E8 Slot: 43
	public virtual void RemoveRange(int index, int count) { }

	// RVA: 0x184C268 Offset: 0x1848268 VA: 0x184C268 Slot: 44
	public virtual void Sort(IComparer comparer) { }

	// RVA: 0x184C2B4 Offset: 0x18482B4 VA: 0x184C2B4 Slot: 45
	public virtual void Sort(int index, int count, IComparer comparer) { }

	// RVA: 0x184C3AC Offset: 0x18483AC VA: 0x184C3AC Slot: 46
	public virtual object[] ToArray() { }

	// RVA: 0x184C494 Offset: 0x1848494 VA: 0x184C494 Slot: 47
	public virtual Array ToArray(Type type) { }
}

// Namespace: 
private struct Hashtable.bucket // TypeDefIndex: 1431
{
	// Fields
	public object key; // 0x0
	public object val; // 0x8
	public int hash_coll; // 0x10
}

// Namespace: 
[Serializable]
private class Hashtable.KeyCollection : ICollection, IEnumerable // TypeDefIndex: 1432
{
	// Fields
	private Hashtable _hashtable; // 0x10

	// Properties
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x1850480 Offset: 0x184C480 VA: 0x1850480
	internal void .ctor(Hashtable hashtable) { }

	// RVA: 0x185166C Offset: 0x184D66C VA: 0x185166C Slot: 9
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x18517E8 Offset: 0x184D7E8 VA: 0x18517E8 Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1851848 Offset: 0x184D848 VA: 0x1851848 Slot: 11
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x1851868 Offset: 0x184D868 VA: 0x1851868 Slot: 12
	public virtual object get_SyncRoot() { }

	// RVA: 0x1851888 Offset: 0x184D888 VA: 0x1851888 Slot: 13
	public virtual int get_Count() { }
}

// Namespace: 
[Serializable]
private class Hashtable.ValueCollection : ICollection, IEnumerable // TypeDefIndex: 1433
{
	// Fields
	private Hashtable _hashtable; // 0x10

	// Properties
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x1850534 Offset: 0x184C534 VA: 0x1850534
	internal void .ctor(Hashtable hashtable) { }

	// RVA: 0x18518A0 Offset: 0x184D8A0 VA: 0x18518A0 Slot: 9
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1851A1C Offset: 0x184DA1C VA: 0x1851A1C Slot: 10
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1851A7C Offset: 0x184DA7C VA: 0x1851A7C Slot: 11
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x1851A9C Offset: 0x184DA9C VA: 0x1851A9C Slot: 12
	public virtual object get_SyncRoot() { }

	// RVA: 0x1851ABC Offset: 0x184DABC VA: 0x1851ABC Slot: 13
	public virtual int get_Count() { }
}

// Namespace: 
[DefaultMember("Item")]
[Serializable]
private class Hashtable.SyncHashtable : Hashtable, IEnumerable // TypeDefIndex: 1434
{
	// Fields
	protected Hashtable _table; // 0x50

	// Properties
	public override int Count { get; }
	public override bool IsReadOnly { get; }
	public override bool IsSynchronized { get; }
	public override object Item { get; set; }
	public override object SyncRoot { get; }
	public override ICollection Keys { get; }
	public override ICollection Values { get; }

	// Methods

	// RVA: 0x1850898 Offset: 0x184C898 VA: 0x1850898
	internal void .ctor(Hashtable table) { }

	// RVA: 0x1851AD4 Offset: 0x184DAD4 VA: 0x1851AD4
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1851B10 Offset: 0x184DB10 VA: 0x1851B10 Slot: 39
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1851B48 Offset: 0x184DB48 VA: 0x1851B48 Slot: 38
	public override int get_Count() { }

	// RVA: 0x1851B68 Offset: 0x184DB68 VA: 0x1851B68 Slot: 31
	public override bool get_IsReadOnly() { }

	// RVA: 0x1851B88 Offset: 0x184DB88 VA: 0x1851B88 Slot: 32
	public override bool get_IsSynchronized() { }

	// RVA: 0x1851B90 Offset: 0x184DB90 VA: 0x1851B90 Slot: 27
	public override object get_Item(object key) { }

	// RVA: 0x1851BB0 Offset: 0x184DBB0 VA: 0x1851BB0 Slot: 28
	public override void set_Item(object key, object value) { }

	// RVA: 0x1851CB4 Offset: 0x184DCB4 VA: 0x1851CB4 Slot: 37
	public override object get_SyncRoot() { }

	// RVA: 0x1851CD4 Offset: 0x184DCD4 VA: 0x1851CD4 Slot: 21
	public override void Add(object key, object value) { }

	// RVA: 0x1851DD8 Offset: 0x184DDD8 VA: 0x1851DD8 Slot: 22
	public override void Clear() { }

	// RVA: 0x1851EC4 Offset: 0x184DEC4 VA: 0x1851EC4 Slot: 24
	public override bool Contains(object key) { }

	// RVA: 0x1851EE4 Offset: 0x184DEE4 VA: 0x1851EE4 Slot: 25
	public override bool ContainsKey(object key) { }

	// RVA: 0x1851F70 Offset: 0x184DF70 VA: 0x1851F70 Slot: 26
	public override void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1852074 Offset: 0x184E074 VA: 0x1852074 Slot: 23
	public override object Clone() { }

	// RVA: 0x18521DC Offset: 0x184E1DC VA: 0x18521DC Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x18521FC Offset: 0x184E1FC VA: 0x18521FC Slot: 29
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x185221C Offset: 0x184E21C VA: 0x185221C Slot: 34
	public override ICollection get_Keys() { }

	// RVA: 0x185231C Offset: 0x184E31C VA: 0x185231C Slot: 35
	public override ICollection get_Values() { }

	// RVA: 0x185241C Offset: 0x184E41C VA: 0x185241C Slot: 36
	public override void Remove(object key) { }

	// RVA: 0x1852514 Offset: 0x184E514 VA: 0x1852514 Slot: 40
	public override void OnDeserialization(object sender) { }
}

// Namespace: 
[Serializable]
private class Hashtable.HashtableEnumerator : IDictionaryEnumerator, IEnumerator, ICloneable // TypeDefIndex: 1435
{
	// Fields
	private Hashtable _hashtable; // 0x10
	private int _bucket; // 0x18
	private int _version; // 0x1C
	private bool _current; // 0x20
	private int _getObjectRetType; // 0x24
	private object _currentKey; // 0x28
	private object _currentValue; // 0x30

	// Properties
	public virtual object Key { get; }
	public virtual DictionaryEntry Entry { get; }
	public virtual object Current { get; }
	public virtual object Value { get; }

	// Methods

	// RVA: 0x185015C Offset: 0x184C15C VA: 0x185015C
	internal void .ctor(Hashtable hashtable, int getObjRetType) { }

	// RVA: 0x1852518 Offset: 0x184E518 VA: 0x1852518 Slot: 10
	public object Clone() { }

	// RVA: 0x1852520 Offset: 0x184E520 VA: 0x1852520 Slot: 11
	public virtual object get_Key() { }

	// RVA: 0x185257C Offset: 0x184E57C VA: 0x185257C Slot: 12
	public virtual bool MoveNext() { }

	// RVA: 0x18526B0 Offset: 0x184E6B0 VA: 0x18526B0 Slot: 13
	public virtual DictionaryEntry get_Entry() { }

	// RVA: 0x1852744 Offset: 0x184E744 VA: 0x1852744 Slot: 14
	public virtual object get_Current() { }

	// RVA: 0x1852838 Offset: 0x184E838 VA: 0x1852838 Slot: 15
	public virtual object get_Value() { }

	// RVA: 0x1852894 Offset: 0x184E894 VA: 0x1852894 Slot: 16
	public virtual void Reset() { }
}

// Namespace: 
internal class Hashtable.HashtableDebugView // TypeDefIndex: 1436
{}

// Namespace: System.Collections
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(Hashtable.HashtableDebugView))]
[Serializable]
public class Hashtable : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, ICloneable // TypeDefIndex: 1437
{
	// Fields
	private Hashtable.bucket[] _buckets; // 0x10
	private int _count; // 0x18
	private int _occupancy; // 0x1C
	private int _loadsize; // 0x20
	private float _loadFactor; // 0x24
	private int _version; // 0x28
	private bool _isWriterInProgress; // 0x2C
	private ICollection _keys; // 0x30
	private ICollection _values; // 0x38
	private IEqualityComparer _keycomparer; // 0x40
	private object _syncRoot; // 0x48
	private static ConditionalWeakTable<object, SerializationInfo> s_serializationInfoTable; // 0x0

	// Properties
	private static ConditionalWeakTable<object, SerializationInfo> SerializationInfoTable { get; }
	public virtual object Item { get; set; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsSynchronized { get; }
	public virtual ICollection Keys { get; }
	public virtual ICollection Values { get; }
	public virtual object SyncRoot { get; }
	public virtual int Count { get; }

	// Methods

	// RVA: 0x184EA9C Offset: 0x184AA9C VA: 0x184EA9C
	private static ConditionalWeakTable<object, SerializationInfo> get_SerializationInfoTable() { }

	// RVA: 0x184EAF8 Offset: 0x184AAF8 VA: 0x184EAF8
	internal void .ctor(bool trash) { }

	// RVA: 0x184EB00 Offset: 0x184AB00 VA: 0x184EB00
	public void .ctor() { }

	// RVA: 0x184EDB0 Offset: 0x184ADB0 VA: 0x184EDB0
	public void .ctor(int capacity) { }

	// RVA: 0x184EB0C Offset: 0x184AB0C VA: 0x184EB0C
	public void .ctor(int capacity, float loadFactor) { }

	// RVA: 0x184EDB8 Offset: 0x184ADB8 VA: 0x184EDB8
	public void .ctor(int capacity, float loadFactor, IEqualityComparer equalityComparer) { }

	[Obsolete("Please use Hashtable(IEqualityComparer) instead.")]
	// RVA: 0x184EDE4 Offset: 0x184ADE4 VA: 0x184EDE4
	public void .ctor(IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x184EEA8 Offset: 0x184AEA8 VA: 0x184EEA8
	public void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x184EEDC Offset: 0x184AEDC VA: 0x184EEDC
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	[Obsolete("Please use Hashtable(int, float, IEqualityComparer) instead.")]
	// RVA: 0x184EDF8 Offset: 0x184ADF8 VA: 0x184EDF8
	public void .ctor(int capacity, float loadFactor, IHashCodeProvider hcp, IComparer comparer) { }

	// RVA: 0x184EF0C Offset: 0x184AF0C VA: 0x184EF0C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x184EF74 Offset: 0x184AF74 VA: 0x184EF74
	private uint InitHash(object key, int hashsize, out uint seed, out uint incr) { }

	// RVA: 0x184EFC8 Offset: 0x184AFC8 VA: 0x184EFC8 Slot: 21
	public virtual void Add(object key, object value) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x184F44C Offset: 0x184B44C VA: 0x184F44C Slot: 22
	public virtual void Clear() { }

	// RVA: 0x184F54C Offset: 0x184B54C VA: 0x184F54C Slot: 23
	public virtual object Clone() { }

	// RVA: 0x184F65C Offset: 0x184B65C VA: 0x184F65C Slot: 24
	public virtual bool Contains(object key) { }

	// RVA: 0x184F66C Offset: 0x184B66C VA: 0x184F66C Slot: 25
	public virtual bool ContainsKey(object key) { }

	// RVA: 0x184F7E4 Offset: 0x184B7E4 VA: 0x184F7E4
	private void CopyKeys(Array array, int arrayIndex) { }

	// RVA: 0x184F890 Offset: 0x184B890 VA: 0x184F890
	private void CopyEntries(Array array, int arrayIndex) { }

	// RVA: 0x184F9C4 Offset: 0x184B9C4 VA: 0x184F9C4 Slot: 26
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x184FB64 Offset: 0x184BB64 VA: 0x184FB64
	private void CopyValues(Array array, int arrayIndex) { }

	// RVA: 0x184FC14 Offset: 0x184BC14 VA: 0x184FC14 Slot: 27
	public virtual object get_Item(object key) { }

	// RVA: 0x184FE2C Offset: 0x184BE2C VA: 0x184FE2C Slot: 28
	public virtual void set_Item(object key, object value) { }

	// RVA: 0x184FE34 Offset: 0x184BE34 VA: 0x184FE34
	private void expand() { }

	// RVA: 0x184FFD8 Offset: 0x184BFD8 VA: 0x184FFD8
	private void rehash() { }

	// RVA: 0x184F520 Offset: 0x184B520 VA: 0x184F520
	private void UpdateVersion() { }

	// RVA: 0x184FEA0 Offset: 0x184BEA0 VA: 0x184FEA0
	private void rehash(int newsize) { }

	// RVA: 0x1850100 Offset: 0x184C100 VA: 0x1850100 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x18501C0 Offset: 0x184C1C0 VA: 0x18501C0 Slot: 29
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x185021C Offset: 0x184C21C VA: 0x185021C Slot: 30
	protected virtual int GetHash(object key) { }

	// RVA: 0x18502E4 Offset: 0x184C2E4 VA: 0x18502E4 Slot: 31
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x18502EC Offset: 0x184C2EC VA: 0x18502EC Slot: 32
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x18502F4 Offset: 0x184C2F4 VA: 0x18502F4 Slot: 33
	protected virtual bool KeyEquals(object item, object key) { }

	// RVA: 0x18503FC Offset: 0x184C3FC VA: 0x18503FC Slot: 34
	public virtual ICollection get_Keys() { }

	// RVA: 0x18504B0 Offset: 0x184C4B0 VA: 0x18504B0 Slot: 35
	public virtual ICollection get_Values() { }

	// RVA: 0x184EFD0 Offset: 0x184AFD0 VA: 0x184EFD0
	private void Insert(object key, object nvalue, bool add) { }

	// RVA: 0x184FFF0 Offset: 0x184BFF0 VA: 0x184FFF0
	private void putEntry(Hashtable.bucket[] newBuckets, object key, object nvalue, int hashcode) { }

	[ReliabilityContract(3, 1)]
	// RVA: 0x1850564 Offset: 0x184C564 VA: 0x1850564 Slot: 36
	public virtual void Remove(object key) { }

	// RVA: 0x185076C Offset: 0x184C76C VA: 0x185076C Slot: 37
	public virtual object get_SyncRoot() { }

	// RVA: 0x18507DC Offset: 0x184C7DC VA: 0x18507DC Slot: 38
	public virtual int get_Count() { }

	// RVA: 0x18507E4 Offset: 0x184C7E4 VA: 0x18507E4
	public static Hashtable Synchronized(Hashtable table) { }

	// RVA: 0x18508C8 Offset: 0x184C8C8 VA: 0x18508C8 Slot: 39
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1850E00 Offset: 0x184CE00 VA: 0x1850E00 Slot: 40
	public virtual void OnDeserialization(object sender) { }
}

// Namespace: System.Collections
[Obsolete("Please use IEqualityComparer instead.")]
public interface IHashCodeProvider // TypeDefIndex: 1438
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int GetHashCode(object obj);
}

// Namespace: 
[DebuggerDisplay("Item = {Item}, SequenceNumber = {SequenceNumber}")]
internal struct ConcurrentQueue.Segment.Slot<T> // TypeDefIndex: 1439
{
	// Fields
	public T Item; // 0x0
	public int SequenceNumber; // 0x0
}

// Namespace: 
[DebuggerDisplay("Capacity = {Capacity}")]
internal sealed class ConcurrentQueue.Segment<T> // TypeDefIndex: 1440
{
	// Fields
	internal readonly ConcurrentQueue.Segment.Slot<T>[] _slots; // 0x0
	internal readonly int _slotsMask; // 0x0
	internal PaddedHeadAndTail _headAndTail; // 0x0
	internal bool _preservedForObservation; // 0x0
	internal bool _frozenForEnqueues; // 0x0
	internal ConcurrentQueue.Segment<T> _nextSegment; // 0x0

	// Properties
	internal int Capacity { get; }
	internal int FreezeOffset { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int boundedLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1455988 Offset: 0x1451988 VA: 0x1455988
	|-ConcurrentQueue.Segment<object>..ctor
	|
	|-RVA: 0x1455FB0 Offset: 0x1451FB0 VA: 0x1455FB0
	|-ConcurrentQueue.Segment<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1455A30 Offset: 0x1451A30 VA: 0x1455A30
	|-ConcurrentQueue.Segment<object>.get_Capacity
	|
	|-RVA: 0x1456078 Offset: 0x1452078 VA: 0x1456078
	|-ConcurrentQueue.Segment<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	internal int get_FreezeOffset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1455A48 Offset: 0x1451A48 VA: 0x1455A48
	|-ConcurrentQueue.Segment<object>.get_FreezeOffset
	|
	|-RVA: 0x1456090 Offset: 0x1452090 VA: 0x1456090
	|-ConcurrentQueue.Segment<__Il2CppFullySharedGenericType>.get_FreezeOffset
	*/

	// RVA: -1 Offset: -1
	internal void EnsureFrozenForEnqueues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1455A64 Offset: 0x1451A64 VA: 0x1455A64
	|-ConcurrentQueue.Segment<object>.EnsureFrozenForEnqueues
	|
	|-RVA: 0x14560AC Offset: 0x14520AC VA: 0x14560AC
	|-ConcurrentQueue.Segment<__Il2CppFullySharedGenericType>.EnsureFrozenForEnqueues
	*/

	// RVA: -1 Offset: -1
	public bool TryDequeue(out T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1455B24 Offset: 0x1451B24 VA: 0x1455B24
	|-ConcurrentQueue.Segment<object>.TryDequeue
	|
	|-RVA: 0x1456170 Offset: 0x1452170 VA: 0x1456170
	|-ConcurrentQueue.Segment<__Il2CppFullySharedGenericType>.TryDequeue
	*/

	// RVA: -1 Offset: -1
	public bool TryPeek(out T result, bool resultUsed) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1455CEC Offset: 0x1451CEC VA: 0x1455CEC
	|-ConcurrentQueue.Segment<object>.TryPeek
	|
	|-RVA: 0x14564BC Offset: 0x14524BC VA: 0x14564BC
	|-ConcurrentQueue.Segment<__Il2CppFullySharedGenericType>.TryPeek
	*/

	// RVA: -1 Offset: -1
	public bool TryEnqueue(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1455E64 Offset: 0x1451E64 VA: 0x1455E64
	|-ConcurrentQueue.Segment<object>.TryEnqueue
	|
	|-RVA: 0x1456780 Offset: 0x1452780 VA: 0x1456780
	|-ConcurrentQueue.Segment<__Il2CppFullySharedGenericType>.TryEnqueue
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ConcurrentQueue.<Enumerate>d__28<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 1441
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public ConcurrentQueue.Segment<T> head; // 0x0
	public ConcurrentQueue.Segment<T> tail; // 0x0
	public int tailTail; // 0x0
	public int headHead; // 0x0
	public ConcurrentQueue<T> <>4__this; // 0x0
	private int <headTail>5__2; // 0x0
	private int <i>5__3; // 0x0
	private ConcurrentQueue.Segment<T> <s>5__4; // 0x0
	private int <i>5__5; // 0x0

	// Properties
	private T System.Collections.Generic.IEnumerator<T>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1162458 Offset: 0x115E458 VA: 0x1162458
	|-ConcurrentQueue.<Enumerate>d__28<object>..ctor
	|
	|-RVA: 0x1162834 Offset: 0x115E834 VA: 0x1162834
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1162480 Offset: 0x115E480 VA: 0x1162480
	|-ConcurrentQueue.<Enumerate>d__28<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x1162874 Offset: 0x115E874 VA: 0x1162874
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1162484 Offset: 0x115E484 VA: 0x1162484
	|-ConcurrentQueue.<Enumerate>d__28<object>.MoveNext
	|
	|-RVA: 0x1162878 Offset: 0x115E878 VA: 0x1162878
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11627F0 Offset: 0x115E7F0 VA: 0x11627F0
	|-ConcurrentQueue.<Enumerate>d__28<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x116343C Offset: 0x115F43C VA: 0x116343C
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11627F8 Offset: 0x115E7F8 VA: 0x11627F8
	|-ConcurrentQueue.<Enumerate>d__28<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1163480 Offset: 0x115F480 VA: 0x1163480
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116282C Offset: 0x115E82C VA: 0x116282C
	|-ConcurrentQueue.<Enumerate>d__28<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x11634B4 Offset: 0x115F4B4 VA: 0x11634B4
	|-ConcurrentQueue.<Enumerate>d__28<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: System.Collections
[Extension]
internal static class HashtableExtensions // TypeDefIndex: 4085
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static bool TryGetValue<T>(Hashtable table, object key, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1119410 Offset: 0x1115410 VA: 0x1119410
	|-HashtableExtensions.TryGetValue<int>
	|
	|-RVA: 0x11194E8 Offset: 0x11154E8 VA: 0x11194E8
	|-HashtableExtensions.TryGetValue<__Il2CppFullySharedGenericType>
	*/
}
