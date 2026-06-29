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

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
public struct BitVector32 // TypeDefIndex: 4086
{
	// Fields
	private uint _data; // 0x0

	// Properties
	public bool Item { get; set; }

	// Methods

	// RVA: 0x1D5A6A0 Offset: 0x1D566A0 VA: 0x1D5A6A0
	public bool get_Item(int bit) { }

	// RVA: 0x1D5A6B0 Offset: 0x1D566B0 VA: 0x1D5A6B0
	public void set_Item(int bit, bool value) { }

	// RVA: 0x1D5A6CC Offset: 0x1D566CC VA: 0x1D5A6CC
	public static int CreateMask() { }

	// RVA: 0x1D5A6D4 Offset: 0x1D566D4 VA: 0x1D5A6D4
	public static int CreateMask(int previous) { }

	// RVA: 0x1D5A740 Offset: 0x1D56740 VA: 0x1D5A740 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1D5A7B8 Offset: 0x1D567B8 VA: 0x1D5A7B8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D5A81C Offset: 0x1D5681C VA: 0x1D5A81C
	public static string ToString(BitVector32 value) { }

	// RVA: 0x1D5A8EC Offset: 0x1D568EC VA: 0x1D5A8EC Slot: 3
	public override string ToString() { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class NameValueCollection : NameObjectCollectionBase // TypeDefIndex: 4087
{
	// Fields
	private string[] _all; // 0x50
	private string[] _allKeys; // 0x58

	// Properties
	public string Item { get; set; }

	// Methods

	// RVA: 0x1D5A8F4 Offset: 0x1D568F4 VA: 0x1D5A8F4
	public void .ctor() { }

	// RVA: 0x1D5A9A8 Offset: 0x1D569A8 VA: 0x1D5A9A8
	public void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1D5AA48 Offset: 0x1D56A48 VA: 0x1D5AA48
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D5AAEC Offset: 0x1D56AEC VA: 0x1D5AAEC
	protected void InvalidateCachedArrays() { }

	// RVA: 0x1D5AB14 Offset: 0x1D56B14 VA: 0x1D5AB14
	private static string GetAsOneString(ArrayList list) { }

	// RVA: 0x1D5ACB0 Offset: 0x1D56CB0 VA: 0x1D5ACB0
	private static string[] GetAsStringArray(ArrayList list) { }

	// RVA: 0x1D5AD50 Offset: 0x1D56D50 VA: 0x1D5AD50 Slot: 15
	public virtual void Add(string name, string value) { }

	// RVA: 0x1D5B054 Offset: 0x1D57054 VA: 0x1D5B054 Slot: 16
	public virtual string Get(string name) { }

	// RVA: 0x1D5B0E0 Offset: 0x1D570E0 VA: 0x1D5B0E0 Slot: 17
	public virtual string[] GetValues(string name) { }

	// RVA: 0x1D5B16C Offset: 0x1D5716C VA: 0x1D5B16C Slot: 18
	public virtual void Set(string name, string value) { }

	// RVA: 0x1D5B320 Offset: 0x1D57320 VA: 0x1D5B320 Slot: 19
	public virtual void Remove(string name) { }

	// RVA: 0x1D5B580 Offset: 0x1D57580 VA: 0x1D5B580
	public string get_Item(string name) { }

	// RVA: 0x1D5B590 Offset: 0x1D57590 VA: 0x1D5B590
	public void set_Item(string name, string value) { }

	// RVA: 0x1D5B5A0 Offset: 0x1D575A0 VA: 0x1D5B5A0 Slot: 20
	public virtual string Get(int index) { }

	// RVA: 0x1D5B6C0 Offset: 0x1D576C0 VA: 0x1D5B6C0 Slot: 21
	public virtual string GetKey(int index) { }

	// RVA: 0x1D5B760 Offset: 0x1D57760 VA: 0x1D5B760
	internal void .ctor(DBNull dummy) { }
}

// Namespace: 
private class OrderedDictionary.OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 4088
{
	// Fields
	private int _objectReturnType; // 0x10
	private IEnumerator _arrayEnumerator; // 0x18

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1D5BE00 Offset: 0x1D57E00 VA: 0x1D5BE00
	internal void .ctor(ArrayList array, int objectReturnType) { }

	// RVA: 0x1D5C494 Offset: 0x1D58494 VA: 0x1D5C494 Slot: 8
	public object get_Current() { }

	// RVA: 0x1D5C658 Offset: 0x1D58658 VA: 0x1D5C658 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x1D5C7EC Offset: 0x1D587EC VA: 0x1D5C7EC Slot: 4
	public object get_Key() { }

	// RVA: 0x1D5C8D0 Offset: 0x1D588D0 VA: 0x1D5C8D0 Slot: 5
	public object get_Value() { }

	// RVA: 0x1D5C9B4 Offset: 0x1D589B4 VA: 0x1D5C9B4 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x1D5CA54 Offset: 0x1D58A54 VA: 0x1D5CA54 Slot: 9
	public void Reset() { }
}

// Namespace: 
private class OrderedDictionary.OrderedDictionaryKeyValueCollection : ICollection, IEnumerable // TypeDefIndex: 4089
{
	// Fields
	private ArrayList _objects; // 0x10
	private bool _isKeys; // 0x18

	// Properties
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x1D5BC88 Offset: 0x1D57C88 VA: 0x1D5BC88
	public void .ctor(ArrayList array, bool isKeys) { }

	// RVA: 0x1D5CAF8 Offset: 0x1D58AF8 VA: 0x1D5CAF8 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1D5CEBC Offset: 0x1D58EBC VA: 0x1D5CEBC Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1D5CEDC Offset: 0x1D58EDC VA: 0x1D5CEDC Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1D5CEE4 Offset: 0x1D58EE4 VA: 0x1D5CEE4 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1D5CF04 Offset: 0x1D58F04 VA: 0x1D5CF04 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class OrderedDictionary : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 4090
{
	// Fields
	private ArrayList _objectsArray; // 0x10
	private Hashtable _objectsTable; // 0x18
	private int _initialCapacity; // 0x20
	private IEqualityComparer _comparer; // 0x28
	private bool _readOnly; // 0x30
	private object _syncRoot; // 0x38
	private SerializationInfo _siInfo; // 0x40

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private ArrayList objectsArray { get; }
	private Hashtable objectsTable { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object Item { get; set; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x1D5B7C0 Offset: 0x1D577C0 VA: 0x1D5B7C0
	public void .ctor() { }

	// RVA: 0x1D4BC30 Offset: 0x1D47C30 VA: 0x1D4BC30
	public void .ctor(int capacity) { }

	// RVA: 0x1D5B7E8 Offset: 0x1D577E8 VA: 0x1D5B7E8
	public void .ctor(int capacity, IEqualityComparer comparer) { }

	// RVA: 0x1D5B820 Offset: 0x1D57820 VA: 0x1D5B820
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D4BE0C Offset: 0x1D47E0C VA: 0x1D4BE0C Slot: 14
	public int get_Count() { }

	// RVA: 0x1D5B8D4 Offset: 0x1D578D4 VA: 0x1D5B8D4 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x1D5B8DC Offset: 0x1D578DC VA: 0x1D5B8DC Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1D5B850 Offset: 0x1D57850 VA: 0x1D5B850
	private ArrayList get_objectsArray() { }

	// RVA: 0x1D5B8E4 Offset: 0x1D578E4 VA: 0x1D5B8E4
	private Hashtable get_objectsTable() { }

	// RVA: 0x1D5B970 Offset: 0x1D57970 VA: 0x1D5B970 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1D5537C Offset: 0x1D5137C VA: 0x1D5537C Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x1D4BC90 Offset: 0x1D47C90 VA: 0x1D4BC90 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x1D4BE30 Offset: 0x1D47E30 VA: 0x1D4BE30 Slot: 6
	public ICollection get_Values() { }

	// RVA: 0x1D5BB64 Offset: 0x1D57B64 VA: 0x1D5BB64 Slot: 8
	public void Add(object key, object value) { }

	// RVA: 0x1D5BCC4 Offset: 0x1D57CC4 VA: 0x1D5BCC4 Slot: 9
	public void Clear() { }

	// RVA: 0x1D4BC64 Offset: 0x1D47C64 VA: 0x1D4BC64 Slot: 7
	public bool Contains(object key) { }

	// RVA: 0x1D5BD58 Offset: 0x1D57D58 VA: 0x1D5BD58 Slot: 13
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1D5B9E4 Offset: 0x1D579E4 VA: 0x1D5B9E4
	private int IndexOfKey(object key) { }

	// RVA: 0x1D553A8 Offset: 0x1D513A8 VA: 0x1D553A8 Slot: 12
	public void Remove(object key) { }

	// RVA: 0x1D5BD94 Offset: 0x1D57D94 VA: 0x1D5BD94 Slot: 20
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x1D5BE58 Offset: 0x1D57E58 VA: 0x1D5BE58 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1D5BEC4 Offset: 0x1D57EC4 VA: 0x1D5BEC4 Slot: 21
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D5C08C Offset: 0x1D5808C VA: 0x1D5C08C Slot: 19
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x1D5C09C Offset: 0x1D5809C VA: 0x1D5C09C Slot: 22
	protected virtual void OnDeserialization(object sender) { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
[Serializable]
public class StringCollection : IList, ICollection, IEnumerable // TypeDefIndex: 4091
{
	// Fields
	private readonly ArrayList data; // 0x10

	// Properties
	public string Item { get; set; }
	public int Count { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x1D5CF74 Offset: 0x1D58F74 VA: 0x1D5CF74
	public string get_Item(int index) { }

	// RVA: 0x1D5CFBC Offset: 0x1D58FBC VA: 0x1D5CFBC
	public void set_Item(int index, string value) { }

	// RVA: 0x1D5CFDC Offset: 0x1D58FDC VA: 0x1D5CFDC Slot: 16
	public int get_Count() { }

	// RVA: 0x1D5CFFC Offset: 0x1D58FFC VA: 0x1D5CFFC Slot: 9
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1D5D004 Offset: 0x1D59004 VA: 0x1D5D004 Slot: 10
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1D5D00C Offset: 0x1D5900C VA: 0x1D5D00C
	public int Add(string value) { }

	// RVA: 0x1D5D02C Offset: 0x1D5902C VA: 0x1D5D02C Slot: 8
	public void Clear() { }

	// RVA: 0x1D5D04C Offset: 0x1D5904C VA: 0x1D5D04C
	public bool Contains(string value) { }

	// RVA: 0x1D5D06C Offset: 0x1D5906C VA: 0x1D5D06C
	public void CopyTo(string[] array, int index) { }

	// RVA: 0x1D5D08C Offset: 0x1D5908C VA: 0x1D5D08C
	public int IndexOf(string value) { }

	// RVA: 0x1D5D0AC Offset: 0x1D590AC VA: 0x1D5D0AC
	public void Insert(int index, string value) { }

	// RVA: 0x1D5D0CC Offset: 0x1D590CC VA: 0x1D5D0CC Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x1D5D0D4 Offset: 0x1D590D4 VA: 0x1D5D0D4
	public void Remove(string value) { }

	// RVA: 0x1D5D0F4 Offset: 0x1D590F4 VA: 0x1D5D0F4 Slot: 14
	public void RemoveAt(int index) { }

	// RVA: 0x1D5D114 Offset: 0x1D59114 VA: 0x1D5D114 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x1D5D134 Offset: 0x1D59134 VA: 0x1D5D134 Slot: 4
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1D5D138 Offset: 0x1D59138 VA: 0x1D5D138 Slot: 5
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1D5D184 Offset: 0x1D59184 VA: 0x1D5D184 Slot: 6
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1D5D1D0 Offset: 0x1D591D0 VA: 0x1D5D1D0 Slot: 7
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1D5D21C Offset: 0x1D5921C VA: 0x1D5D21C Slot: 11
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1D5D268 Offset: 0x1D59268 VA: 0x1D5D268 Slot: 12
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1D5D2B4 Offset: 0x1D592B4 VA: 0x1D5D2B4 Slot: 13
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1D5D300 Offset: 0x1D59300 VA: 0x1D5D300 Slot: 15
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1D5D320 Offset: 0x1D59320 VA: 0x1D5D320 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1D5D340 Offset: 0x1D59340 VA: 0x1D5D340
	public void .ctor() { }
}

// Namespace: System.Collections.Specialized
public enum NotifyCollectionChangedAction // TypeDefIndex: 4092
{
	// Fields
	public int value__; // 0x0
	public const NotifyCollectionChangedAction Add = 0;
	public const NotifyCollectionChangedAction Remove = 1;
	public const NotifyCollectionChangedAction Replace = 2;
	public const NotifyCollectionChangedAction Move = 3;
	public const NotifyCollectionChangedAction Reset = 4;
}

// Namespace: System.Collections.Specialized
public class NotifyCollectionChangedEventArgs : EventArgs // TypeDefIndex: 4093
{
	// Fields
	private NotifyCollectionChangedAction _action; // 0x10
	private IList _newItems; // 0x18
	private IList _oldItems; // 0x20
	private int _newStartingIndex; // 0x28
	private int _oldStartingIndex; // 0x2C

	// Methods

	// RVA: 0x1D5D3AC Offset: 0x1D593AC VA: 0x1D5D3AC
	public void .ctor(NotifyCollectionChangedAction action) { }

	// RVA: 0x1D5D558 Offset: 0x1D59558 VA: 0x1D5D558
	public void .ctor(NotifyCollectionChangedAction action, object changedItem, int index) { }

	// RVA: 0x1D5D748 Offset: 0x1D59748 VA: 0x1D5D748
	public void .ctor(NotifyCollectionChangedAction action, object newItem, object oldItem, int index) { }

	// RVA: 0x1D5D97C Offset: 0x1D5997C VA: 0x1D5D97C
	public void .ctor(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex) { }

	// RVA: 0x1D5D730 Offset: 0x1D59730 VA: 0x1D5D730
	private void InitializeAddOrRemove(NotifyCollectionChangedAction action, IList changedItems, int startingIndex) { }

	// RVA: 0x1D5D4BC Offset: 0x1D594BC VA: 0x1D5D4BC
	private void InitializeAdd(NotifyCollectionChangedAction action, IList newItems, int newStartingIndex) { }

	// RVA: 0x1D5DB2C Offset: 0x1D59B2C VA: 0x1D5DB2C
	private void InitializeRemove(NotifyCollectionChangedAction action, IList oldItems, int oldStartingIndex) { }

	// RVA: 0x1D5D938 Offset: 0x1D59938 VA: 0x1D5D938
	private void InitializeMoveOrReplace(NotifyCollectionChangedAction action, IList newItems, IList oldItems, int startingIndex, int oldStartingIndex) { }
}

// Namespace: System.Collections.Specialized
public sealed class NotifyCollectionChangedEventHandler : MulticastDelegate // TypeDefIndex: 4094
{
	// Methods

	// RVA: 0x1D5DBF8 Offset: 0x1D59BF8 VA: 0x1D5DBF8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D5DD04 Offset: 0x1D59D04 VA: 0x1D5DD04 Slot: 12
	public virtual void Invoke(object sender, NotifyCollectionChangedEventArgs e) { }
}

// Namespace: System.Collections.Specialized
[DefaultMember("Item")]
internal sealed class ReadOnlyList : IList, ICollection, IEnumerable // TypeDefIndex: 4095
{
	// Fields
	private readonly IList _list; // 0x10

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public bool IsFixedSize { get; }
	public bool IsSynchronized { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x1D5DBC8 Offset: 0x1D59BC8 VA: 0x1D5DBC8
	internal void .ctor(IList list) { }

	// RVA: 0x1D5DD18 Offset: 0x1D59D18 VA: 0x1D5DD18 Slot: 16
	public int get_Count() { }

	// RVA: 0x1D5DDBC Offset: 0x1D59DBC VA: 0x1D5DDBC Slot: 9
	public bool get_IsReadOnly() { }

	// RVA: 0x1D5DDC4 Offset: 0x1D59DC4 VA: 0x1D5DDC4 Slot: 10
	public bool get_IsFixedSize() { }

	// RVA: 0x1D5DDCC Offset: 0x1D59DCC VA: 0x1D5DDCC Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x1D5DE70 Offset: 0x1D59E70 VA: 0x1D5DE70 Slot: 4
	public object get_Item(int index) { }

	// RVA: 0x1D5DF18 Offset: 0x1D59F18 VA: 0x1D5DF18 Slot: 5
	public void set_Item(int index, object value) { }

	// RVA: 0x1D5DF64 Offset: 0x1D59F64 VA: 0x1D5DF64 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x1D5E008 Offset: 0x1D5A008 VA: 0x1D5E008 Slot: 6
	public int Add(object value) { }

	// RVA: 0x1D5E054 Offset: 0x1D5A054 VA: 0x1D5E054 Slot: 8
	public void Clear() { }

	// RVA: 0x1D5E0A0 Offset: 0x1D5A0A0 VA: 0x1D5E0A0 Slot: 7
	public bool Contains(object value) { }

	// RVA: 0x1D5E14C Offset: 0x1D5A14C VA: 0x1D5E14C Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1D5E204 Offset: 0x1D5A204 VA: 0x1D5E204 Slot: 19
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1D5E2A4 Offset: 0x1D5A2A4 VA: 0x1D5E2A4 Slot: 11
	public int IndexOf(object value) { }

	// RVA: 0x1D5E350 Offset: 0x1D5A350 VA: 0x1D5E350 Slot: 12
	public void Insert(int index, object value) { }

	// RVA: 0x1D5E39C Offset: 0x1D5A39C VA: 0x1D5E39C Slot: 13
	public void Remove(object value) { }

	// RVA: 0x1D5E3E8 Offset: 0x1D5A3E8 VA: 0x1D5E3E8 Slot: 14
	public void RemoveAt(int index) { }
}

// Namespace: 
internal class NameObjectCollectionBase.NameObjectEntry // TypeDefIndex: 4096
{
	// Fields
	internal string Key; // 0x10
	internal object Value; // 0x18

	// Methods

	// RVA: 0x1D5F630 Offset: 0x1D5B630 VA: 0x1D5F630
	internal void .ctor(string name, object value) { }
}

// Namespace: 
[Serializable]
internal class NameObjectCollectionBase.NameObjectKeysEnumerator : IEnumerator // TypeDefIndex: 4097
{
	// Fields
	private int _pos; // 0x10
	private NameObjectCollectionBase _coll; // 0x18
	private int _version; // 0x20

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1D5F6CC Offset: 0x1D5B6CC VA: 0x1D5F6CC
	internal void .ctor(NameObjectCollectionBase coll) { }

	// RVA: 0x1D5FB78 Offset: 0x1D5BB78 VA: 0x1D5FB78 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1D5FC50 Offset: 0x1D5BC50 VA: 0x1D5FC50 Slot: 6
	public void Reset() { }

	// RVA: 0x1D5FCD8 Offset: 0x1D5BCD8 VA: 0x1D5FCD8 Slot: 5
	public object get_Current() { }
}

// Namespace: System.Collections.Specialized
[Serializable]
public abstract class NameObjectCollectionBase : ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 4098
{
	// Fields
	private bool _readOnly; // 0x10
	private ArrayList _entriesArray; // 0x18
	private IEqualityComparer _keyComparer; // 0x20
	private Hashtable _entriesTable; // 0x28
	private NameObjectCollectionBase.NameObjectEntry _nullKeyEntry; // 0x30
	private SerializationInfo _serializationInfo; // 0x38
	private int _version; // 0x40
	private object _syncRoot; // 0x48
	private static StringComparer defaultComparer; // 0x0

	// Properties
	protected bool IsReadOnly { get; }
	public virtual int Count { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }

	// Methods

	// RVA: 0x1D5A948 Offset: 0x1D56948 VA: 0x1D5A948
	protected void .ctor() { }

	// RVA: 0x1D5E434 Offset: 0x1D5A434 VA: 0x1D5E434
	protected void .ctor(IEqualityComparer equalityComparer) { }

	// RVA: 0x1D5AA1C Offset: 0x1D56A1C VA: 0x1D5AA1C
	protected void .ctor(int capacity, IEqualityComparer equalityComparer) { }

	// RVA: 0x1D5B7B8 Offset: 0x1D577B8 VA: 0x1D5B7B8
	internal void .ctor(DBNull dummy) { }

	// RVA: 0x1D5AABC Offset: 0x1D56ABC VA: 0x1D5AABC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D5E66C Offset: 0x1D5A66C VA: 0x1D5E66C Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D5EDC4 Offset: 0x1D5ADC4 VA: 0x1D5EDC4 Slot: 12
	public virtual void OnDeserialization(object sender) { }

	// RVA: 0x1D5E4C0 Offset: 0x1D5A4C0 VA: 0x1D5E4C0
	private void Reset() { }

	// RVA: 0x1D5E590 Offset: 0x1D5A590 VA: 0x1D5E590
	private void Reset(int capacity) { }

	// RVA: 0x1D5F570 Offset: 0x1D5B570 VA: 0x1D5F570
	private NameObjectCollectionBase.NameObjectEntry FindEntry(string key) { }

	// RVA: 0x1D5F628 Offset: 0x1D5B628 VA: 0x1D5F628
	protected bool get_IsReadOnly() { }

	// RVA: 0x1D5AEEC Offset: 0x1D56EEC VA: 0x1D5AEEC
	protected void BaseAdd(string name, object value) { }

	// RVA: 0x1D5B360 Offset: 0x1D57360 VA: 0x1D5B360
	protected void BaseRemove(string name) { }

	// RVA: 0x1D5AED4 Offset: 0x1D56ED4 VA: 0x1D5AED4
	protected object BaseGet(string name) { }

	// RVA: 0x1D5B270 Offset: 0x1D57270 VA: 0x1D5B270
	protected void BaseSet(string name, object value) { }

	// RVA: 0x1D5B624 Offset: 0x1D57624 VA: 0x1D5B624
	protected object BaseGet(int index) { }

	// RVA: 0x1D5B6C4 Offset: 0x1D576C4 VA: 0x1D5B6C4
	protected string BaseGetKey(int index) { }

	// RVA: 0x1D5F674 Offset: 0x1D5B674 VA: 0x1D5F674 Slot: 13
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1D5F720 Offset: 0x1D5B720 VA: 0x1D5F720 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x1D5F740 Offset: 0x1D5B740 VA: 0x1D5F740 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1D5FA4C Offset: 0x1D5BA4C VA: 0x1D5FA4C Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1D5FAC0 Offset: 0x1D5BAC0 VA: 0x1D5FAC0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1D5FAC8 Offset: 0x1D5BAC8 VA: 0x1D5FAC8
	private static void .cctor() { }
}

// Namespace: System.Collections.Specialized
[Serializable]
internal class CompatibleComparer : IEqualityComparer // TypeDefIndex: 4099
{
	// Fields
	private IComparer _comparer; // 0x10
	private static IComparer defaultComparer; // 0x0
	private IHashCodeProvider _hcp; // 0x18
	private static IHashCodeProvider defaultHashProvider; // 0x8

	// Properties
	public IComparer Comparer { get; }
	public IHashCodeProvider HashCodeProvider { get; }
	public static IComparer DefaultComparer { get; }
	public static IHashCodeProvider DefaultHashCodeProvider { get; }

	// Methods

	// RVA: 0x1D5F52C Offset: 0x1D5B52C VA: 0x1D5F52C
	internal void .ctor(IComparer comparer, IHashCodeProvider hashCodeProvider) { }

	// RVA: 0x1D5FD78 Offset: 0x1D5BD78 VA: 0x1D5FD78 Slot: 4
	public bool Equals(object a, object b) { }

	// RVA: 0x1D5FF78 Offset: 0x1D5BF78 VA: 0x1D5FF78 Slot: 5
	public int GetHashCode(object obj) { }

	// RVA: 0x1D60080 Offset: 0x1D5C080 VA: 0x1D60080
	public IComparer get_Comparer() { }

	// RVA: 0x1D60088 Offset: 0x1D5C088 VA: 0x1D60088
	public IHashCodeProvider get_HashCodeProvider() { }

	// RVA: 0x1D5ECE0 Offset: 0x1D5ACE0 VA: 0x1D5ECE0
	public static IComparer get_DefaultComparer() { }

	// RVA: 0x1D5EC04 Offset: 0x1D5AC04 VA: 0x1D5EC04
	public static IHashCodeProvider get_DefaultHashCodeProvider() { }
}
