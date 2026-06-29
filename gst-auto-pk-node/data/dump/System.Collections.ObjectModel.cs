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

// Namespace: System.Collections.ObjectModel
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class Collection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 1452
{
	// Fields
	private IList<T> items; // 0x0

	// Properties
	public int Count { get; }
	protected IList<T> Items { get; }
	public T Item { get; set; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E62EC Offset: 0x14E22EC VA: 0x14E62EC
	|-Collection<object>..ctor
	|
	|-RVA: 0x14E82C0 Offset: 0x14E42C0 VA: 0x14E82C0
	|-Collection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6350 Offset: 0x14E2350 VA: 0x14E6350
	|-Collection<object>..ctor
	|
	|-RVA: 0x14E8328 Offset: 0x14E4328 VA: 0x14E8328
	|-Collection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6390 Offset: 0x14E2390 VA: 0x14E6390
	|-Collection<object>.get_Count
	|
	|-RVA: 0x14E8368 Offset: 0x14E4368 VA: 0x14E8368
	|-Collection<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	protected IList<T> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E641C Offset: 0x14E241C VA: 0x14E641C
	|-Collection<object>.get_Items
	|
	|-RVA: 0x14E83F4 Offset: 0x14E43F4 VA: 0x14E83F4
	|-Collection<__Il2CppFullySharedGenericType>.get_Items
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6424 Offset: 0x14E2424 VA: 0x14E6424
	|-Collection<object>.get_Item
	|
	|-RVA: 0x14E83FC Offset: 0x14E43FC VA: 0x14E83FC
	|-Collection<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E64C0 Offset: 0x14E24C0 VA: 0x14E64C0
	|-Collection<object>.set_Item
	|
	|-RVA: 0x14E8530 Offset: 0x14E4530 VA: 0x14E8530
	|-Collection<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E662C Offset: 0x14E262C VA: 0x14E662C
	|-Collection<object>.Add
	|
	|-RVA: 0x14E8748 Offset: 0x14E4748 VA: 0x14E8748
	|-Collection<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6784 Offset: 0x14E2784 VA: 0x14E6784
	|-Collection<object>.Clear
	|
	|-RVA: 0x14E8950 Offset: 0x14E4950 VA: 0x14E8950
	|-Collection<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6844 Offset: 0x14E2844 VA: 0x14E6844
	|-Collection<object>.CopyTo
	|
	|-RVA: 0x14E8A10 Offset: 0x14E4A10 VA: 0x14E8A10
	|-Collection<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E68EC Offset: 0x14E28EC VA: 0x14E68EC
	|-Collection<object>.Contains
	|
	|-RVA: 0x14E8AB8 Offset: 0x14E4AB8 VA: 0x14E8AB8
	|-Collection<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E698C Offset: 0x14E298C VA: 0x14E698C
	|-Collection<object>.GetEnumerator
	|
	|-RVA: 0x14E8C10 Offset: 0x14E4C10 VA: 0x14E8C10
	|-Collection<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6A18 Offset: 0x14E2A18 VA: 0x14E6A18
	|-Collection<object>.IndexOf
	|
	|-RVA: 0x14E8C9C Offset: 0x14E4C9C VA: 0x14E8C9C
	|-Collection<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6AB8 Offset: 0x14E2AB8 VA: 0x14E6AB8
	|-Collection<object>.Insert
	|
	|-RVA: 0x14E8DEC Offset: 0x14E4DEC VA: 0x14E8DEC
	|-Collection<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6C24 Offset: 0x14E2C24 VA: 0x14E6C24
	|-Collection<object>.Remove
	|
	|-RVA: 0x14E9004 Offset: 0x14E5004 VA: 0x14E9004
	|-Collection<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6D94 Offset: 0x14E2D94 VA: 0x14E6D94
	|-Collection<object>.RemoveAt
	|
	|-RVA: 0x14E922C Offset: 0x14E522C VA: 0x14E922C
	|-Collection<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected virtual void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6EF8 Offset: 0x14E2EF8 VA: 0x14E6EF8
	|-Collection<object>.ClearItems
	|
	|-RVA: 0x14E9390 Offset: 0x14E5390 VA: 0x14E9390
	|-Collection<__Il2CppFullySharedGenericType>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected virtual void InsertItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6F88 Offset: 0x14E2F88 VA: 0x14E6F88
	|-Collection<object>.InsertItem
	|
	|-RVA: 0x14E9420 Offset: 0x14E5420 VA: 0x14E9420
	|-Collection<__Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected virtual void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E7030 Offset: 0x14E3030 VA: 0x14E7030
	|-Collection<object>.RemoveItem
	|
	|-RVA: 0x14E9588 Offset: 0x14E5588 VA: 0x14E9588
	|-Collection<__Il2CppFullySharedGenericType>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected virtual void SetItem(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E70D0 Offset: 0x14E30D0 VA: 0x14E70D0
	|-Collection<object>.SetItem
	|
	|-RVA: 0x14E9628 Offset: 0x14E5628 VA: 0x14E9628
	|-Collection<__Il2CppFullySharedGenericType>.SetItem
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E7178 Offset: 0x14E3178 VA: 0x14E7178
	|-Collection<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x14E9790 Offset: 0x14E5790 VA: 0x14E9790
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E7208 Offset: 0x14E3208 VA: 0x14E7208
	|-Collection<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x14E9820 Offset: 0x14E5820 VA: 0x14E9820
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E72A8 Offset: 0x14E32A8 VA: 0x14E72A8
	|-Collection<object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x14E98C0 Offset: 0x14E58C0 VA: 0x14E98C0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E72B0 Offset: 0x14E32B0 VA: 0x14E72B0
	|-Collection<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x14E98C8 Offset: 0x14E58C8 VA: 0x14E98C8
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E736C Offset: 0x14E336C VA: 0x14E736C
	|-Collection<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14E9984 Offset: 0x14E5984 VA: 0x14E9984
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E780C Offset: 0x14E380C VA: 0x14E780C
	|-Collection<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x14E9F78 Offset: 0x14E5F78 VA: 0x14E9F78
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E78A8 Offset: 0x14E38A8 VA: 0x14E78A8
	|-Collection<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0x14EA0B0 Offset: 0x14E60B0 VA: 0x14EA0B0
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E7A08 Offset: 0x14E3A08 VA: 0x14E7A08
	|-Collection<object>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x14EA2A8 Offset: 0x14E62A8 VA: 0x14EA2A8
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E7A98 Offset: 0x14E3A98 VA: 0x14E7A98
	|-Collection<object>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x14EA338 Offset: 0x14E6338 VA: 0x14EA338
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E7BC4 Offset: 0x14E3BC4 VA: 0x14E7BC4
	|-Collection<object>.System.Collections.IList.Add
	|
	|-RVA: 0x14EA464 Offset: 0x14E6464 VA: 0x14EA464
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E7DC4 Offset: 0x14E3DC4 VA: 0x14E7DC4
	|-Collection<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x14EA714 Offset: 0x14E6714 VA: 0x14EA714
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E7E74 Offset: 0x14E3E74 VA: 0x14E7E74
	|-Collection<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x14EA828 Offset: 0x14E6828 VA: 0x14EA828
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E7F24 Offset: 0x14E3F24 VA: 0x14E7F24
	|-Collection<object>.System.Collections.IList.Insert
	|
	|-RVA: 0x14EA934 Offset: 0x14E6934 VA: 0x14EA934
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E811C Offset: 0x14E411C VA: 0x14E811C
	|-Collection<object>.System.Collections.IList.Remove
	|
	|-RVA: 0x14EABDC Offset: 0x14E6BDC VA: 0x14EABDC
	|-Collection<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E8260 Offset: 0x14E4260 VA: 0x14E8260
	|-Collection<object>.IsCompatibleObject
	|
	|-RVA: 0x14EAD84 Offset: 0x14E6D84 VA: 0x14EAD84
	|-Collection<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/
}

// Namespace: System.Collections.ObjectModel
[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(ICollectionDebugView<T>))]
[Serializable]
public class ReadOnlyCollection<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 1453
{
	// Fields
	private IList<T> list; // 0x0
	private object _syncRoot; // 0x0

	// Properties
	public int Count { get; }
	public T Item { get; }
	private bool System.Collections.Generic.ICollection<T>.IsReadOnly { get; }
	private T System.Collections.Generic.IList<T>.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14227B8 Offset: 0x141E7B8 VA: 0x14227B8
	|-ReadOnlyCollection<bool>..ctor
	|
	|-RVA: 0x14235FC Offset: 0x141F5FC VA: 0x14235FC
	|-ReadOnlyCollection<CustomAttributeNamedArgument>..ctor
	|
	|-RVA: 0x1424518 Offset: 0x1420518 VA: 0x1424518
	|-ReadOnlyCollection<CustomAttributeTypedArgument>..ctor
	|
	|-RVA: 0x1425364 Offset: 0x1421364 VA: 0x1425364
	|-ReadOnlyCollection<object>..ctor
	|
	|-RVA: 0x1426154 Offset: 0x1422154 VA: 0x1426154
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14227F8 Offset: 0x141E7F8 VA: 0x14227F8
	|-ReadOnlyCollection<bool>.get_Count
	|
	|-RVA: 0x142363C Offset: 0x141F63C VA: 0x142363C
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Count
	|
	|-RVA: 0x1424558 Offset: 0x1420558 VA: 0x1424558
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Count
	|
	|-RVA: 0x14253A4 Offset: 0x14213A4 VA: 0x14253A4
	|-ReadOnlyCollection<object>.get_Count
	|
	|-RVA: 0x1426194 Offset: 0x1422194 VA: 0x1426194
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422884 Offset: 0x141E884 VA: 0x1422884
	|-ReadOnlyCollection<bool>.get_Item
	|
	|-RVA: 0x14236C8 Offset: 0x141F6C8 VA: 0x14236C8
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.get_Item
	|
	|-RVA: 0x14245E4 Offset: 0x14205E4 VA: 0x14245E4
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.get_Item
	|
	|-RVA: 0x1425430 Offset: 0x1421430 VA: 0x1425430
	|-ReadOnlyCollection<object>.get_Item
	|
	|-RVA: 0x1426220 Offset: 0x1422220 VA: 0x1426220
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422920 Offset: 0x141E920 VA: 0x1422920
	|-ReadOnlyCollection<bool>.Contains
	|
	|-RVA: 0x1423788 Offset: 0x141F788 VA: 0x1423788
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.Contains
	|
	|-RVA: 0x1424680 Offset: 0x1420680 VA: 0x1424680
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.Contains
	|
	|-RVA: 0x14254CC Offset: 0x14214CC VA: 0x14254CC
	|-ReadOnlyCollection<object>.Contains
	|
	|-RVA: 0x1426354 Offset: 0x1422354 VA: 0x1426354
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14229C0 Offset: 0x141E9C0 VA: 0x14229C0
	|-ReadOnlyCollection<bool>.CopyTo
	|
	|-RVA: 0x1423850 Offset: 0x141F850 VA: 0x1423850
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.CopyTo
	|
	|-RVA: 0x1424728 Offset: 0x1420728 VA: 0x1424728
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.CopyTo
	|
	|-RVA: 0x142556C Offset: 0x142156C VA: 0x142556C
	|-ReadOnlyCollection<object>.CopyTo
	|
	|-RVA: 0x14264AC Offset: 0x14224AC VA: 0x14264AC
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422A68 Offset: 0x141EA68 VA: 0x1422A68
	|-ReadOnlyCollection<bool>.GetEnumerator
	|
	|-RVA: 0x14238F8 Offset: 0x141F8F8 VA: 0x14238F8
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.GetEnumerator
	|
	|-RVA: 0x14247D0 Offset: 0x14207D0 VA: 0x14247D0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.GetEnumerator
	|
	|-RVA: 0x1425614 Offset: 0x1421614 VA: 0x1425614
	|-ReadOnlyCollection<object>.GetEnumerator
	|
	|-RVA: 0x1426554 Offset: 0x1422554 VA: 0x1426554
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422AF4 Offset: 0x141EAF4 VA: 0x1422AF4
	|-ReadOnlyCollection<bool>.IndexOf
	|
	|-RVA: 0x1423984 Offset: 0x141F984 VA: 0x1423984
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.IndexOf
	|
	|-RVA: 0x142485C Offset: 0x142085C VA: 0x142485C
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.IndexOf
	|
	|-RVA: 0x14256A0 Offset: 0x14216A0 VA: 0x14256A0
	|-ReadOnlyCollection<object>.IndexOf
	|
	|-RVA: 0x14265E0 Offset: 0x14225E0 VA: 0x14265E0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422B94 Offset: 0x141EB94 VA: 0x1422B94
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x1423A48 Offset: 0x141FA48 VA: 0x1423A48
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x1424904 Offset: 0x1420904 VA: 0x1424904
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x1425740 Offset: 0x1421740 VA: 0x1425740
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	|
	|-RVA: 0x1426730 Offset: 0x1422730 VA: 0x1426730
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IList<T>.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422B9C Offset: 0x141EB9C VA: 0x1422B9C
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x1423A50 Offset: 0x141FA50 VA: 0x1423A50
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x142490C Offset: 0x142090C VA: 0x142490C
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x1425748 Offset: 0x1421748 VA: 0x1425748
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.get_Item
	|
	|-RVA: 0x1426738 Offset: 0x1422738 VA: 0x1426738
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IList<T>.set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422C38 Offset: 0x141EC38 VA: 0x1422C38
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x1423B10 Offset: 0x141FB10 VA: 0x1423B10
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x14249A8 Offset: 0x14209A8 VA: 0x14249A8
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x14257E4 Offset: 0x14217E4 VA: 0x14257E4
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.set_Item
	|
	|-RVA: 0x142686C Offset: 0x142286C VA: 0x142686C
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 11
	private void System.Collections.Generic.ICollection<T>.Add(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422C44 Offset: 0x141EC44 VA: 0x1422C44
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1423B1C Offset: 0x141FB1C VA: 0x1423B1C
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x14249B4 Offset: 0x14209B4 VA: 0x14249B4
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x14257F0 Offset: 0x14217F0 VA: 0x14257F0
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Add
	|
	|-RVA: 0x1426878 Offset: 0x1422878 VA: 0x1426878
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private void System.Collections.Generic.ICollection<T>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422C50 Offset: 0x141EC50 VA: 0x1422C50
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x1423B28 Offset: 0x141FB28 VA: 0x1423B28
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x14249C0 Offset: 0x14209C0 VA: 0x14249C0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x14257FC Offset: 0x14217FC VA: 0x14257FC
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Clear
	|
	|-RVA: 0x1426884 Offset: 0x1422884 VA: 0x1426884
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.IList<T>.Insert(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422C5C Offset: 0x141EC5C VA: 0x1422C5C
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x1423B34 Offset: 0x141FB34 VA: 0x1423B34
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x14249CC Offset: 0x14209CC VA: 0x14249CC
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x1425808 Offset: 0x1421808 VA: 0x1425808
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.Insert
	|
	|-RVA: 0x1426890 Offset: 0x1422890 VA: 0x1426890
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<T>.Remove(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422C68 Offset: 0x141EC68 VA: 0x1422C68
	|-ReadOnlyCollection<bool>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x1423B40 Offset: 0x141FB40 VA: 0x1423B40
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x14249D8 Offset: 0x14209D8 VA: 0x14249D8
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x1425814 Offset: 0x1421814 VA: 0x1425814
	|-ReadOnlyCollection<object>.System.Collections.Generic.ICollection<T>.Remove
	|
	|-RVA: 0x142689C Offset: 0x142289C VA: 0x142689C
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<T>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422C84 Offset: 0x141EC84 VA: 0x1422C84
	|-ReadOnlyCollection<bool>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x1423B5C Offset: 0x141FB5C VA: 0x1423B5C
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x14249F4 Offset: 0x14209F4 VA: 0x14249F4
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x1425830 Offset: 0x1421830 VA: 0x1425830
	|-ReadOnlyCollection<object>.System.Collections.Generic.IList<T>.RemoveAt
	|
	|-RVA: 0x14268B8 Offset: 0x14228B8 VA: 0x14268B8
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.Generic.IList<T>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422C90 Offset: 0x141EC90 VA: 0x1422C90
	|-ReadOnlyCollection<bool>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1423B68 Offset: 0x141FB68 VA: 0x1423B68
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1424A00 Offset: 0x1420A00 VA: 0x1424A00
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x142583C Offset: 0x142183C VA: 0x142583C
	|-ReadOnlyCollection<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x14268C4 Offset: 0x14228C4 VA: 0x14268C4
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422D30 Offset: 0x141ED30 VA: 0x1422D30
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x1423C08 Offset: 0x141FC08 VA: 0x1423C08
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x1424AA0 Offset: 0x1420AA0 VA: 0x1424AA0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x14258DC Offset: 0x14218DC VA: 0x14258DC
	|-ReadOnlyCollection<object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x1426964 Offset: 0x1422964 VA: 0x1426964
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422D38 Offset: 0x141ED38 VA: 0x1422D38
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1423C10 Offset: 0x141FC10 VA: 0x1423C10
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1424AA8 Offset: 0x1420AA8 VA: 0x1424AA8
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x14258E4 Offset: 0x14218E4 VA: 0x14258E4
	|-ReadOnlyCollection<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x142696C Offset: 0x142296C VA: 0x142696C
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1422E44 Offset: 0x141EE44 VA: 0x1422E44
	|-ReadOnlyCollection<bool>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1423D1C Offset: 0x141FD1C VA: 0x1423D1C
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1424BB4 Offset: 0x1420BB4 VA: 0x1424BB4
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14259F0 Offset: 0x14219F0 VA: 0x14259F0
	|-ReadOnlyCollection<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1426A78 Offset: 0x1422A78 VA: 0x1426A78
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1423320 Offset: 0x141F320 VA: 0x1423320
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x1424204 Offset: 0x1420204 VA: 0x1424204
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x142508C Offset: 0x142108C VA: 0x142508C
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x1425E90 Offset: 0x1421E90 VA: 0x1425E90
	|-ReadOnlyCollection<object>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x142706C Offset: 0x142306C VA: 0x142706C
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IList.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1423328 Offset: 0x141F328 VA: 0x1423328
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x142420C Offset: 0x142020C VA: 0x142420C
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x1425094 Offset: 0x1421094 VA: 0x1425094
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x1425E98 Offset: 0x1421E98 VA: 0x1425E98
	|-ReadOnlyCollection<object>.System.Collections.IList.get_IsReadOnly
	|
	|-RVA: 0x1427074 Offset: 0x1423074 VA: 0x1427074
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1423330 Offset: 0x141F330 VA: 0x1423330
	|-ReadOnlyCollection<bool>.System.Collections.IList.get_Item
	|
	|-RVA: 0x1424214 Offset: 0x1420214 VA: 0x1424214
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.get_Item
	|
	|-RVA: 0x142509C Offset: 0x142109C VA: 0x142509C
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.get_Item
	|
	|-RVA: 0x1425EA0 Offset: 0x1421EA0 VA: 0x1425EA0
	|-ReadOnlyCollection<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x142707C Offset: 0x142307C VA: 0x142707C
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14233F8 Offset: 0x141F3F8 VA: 0x14233F8
	|-ReadOnlyCollection<bool>.System.Collections.IList.set_Item
	|
	|-RVA: 0x14242E8 Offset: 0x14202E8 VA: 0x14242E8
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.set_Item
	|
	|-RVA: 0x1425160 Offset: 0x1421160 VA: 0x1425160
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.set_Item
	|
	|-RVA: 0x1425F3C Offset: 0x1421F3C VA: 0x1425F3C
	|-ReadOnlyCollection<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0x14271B4 Offset: 0x14231B4 VA: 0x14271B4
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1423404 Offset: 0x141F404 VA: 0x1423404
	|-ReadOnlyCollection<bool>.System.Collections.IList.Add
	|
	|-RVA: 0x14242F4 Offset: 0x14202F4 VA: 0x14242F4
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Add
	|
	|-RVA: 0x142516C Offset: 0x142116C VA: 0x142516C
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Add
	|
	|-RVA: 0x1425F48 Offset: 0x1421F48 VA: 0x1425F48
	|-ReadOnlyCollection<object>.System.Collections.IList.Add
	|
	|-RVA: 0x14271C0 Offset: 0x14231C0 VA: 0x14271C0
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IList.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1423420 Offset: 0x141F420 VA: 0x1423420
	|-ReadOnlyCollection<bool>.System.Collections.IList.Clear
	|
	|-RVA: 0x1424310 Offset: 0x1420310 VA: 0x1424310
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Clear
	|
	|-RVA: 0x1425188 Offset: 0x1421188 VA: 0x1425188
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Clear
	|
	|-RVA: 0x1425F64 Offset: 0x1421F64 VA: 0x1425F64
	|-ReadOnlyCollection<object>.System.Collections.IList.Clear
	|
	|-RVA: 0x14271DC Offset: 0x14231DC VA: 0x14271DC
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Clear
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142342C Offset: 0x141F42C VA: 0x142342C
	|-ReadOnlyCollection<bool>.IsCompatibleObject
	|
	|-RVA: 0x142431C Offset: 0x142031C VA: 0x142431C
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.IsCompatibleObject
	|
	|-RVA: 0x1425194 Offset: 0x1421194 VA: 0x1425194
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.IsCompatibleObject
	|
	|-RVA: 0x1425F70 Offset: 0x1421F70 VA: 0x1425F70
	|-ReadOnlyCollection<object>.IsCompatibleObject
	|
	|-RVA: 0x14271E8 Offset: 0x14231E8 VA: 0x14271E8
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1423488 Offset: 0x141F488 VA: 0x1423488
	|-ReadOnlyCollection<bool>.System.Collections.IList.Contains
	|
	|-RVA: 0x1424378 Offset: 0x1420378 VA: 0x1424378
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Contains
	|
	|-RVA: 0x14251F0 Offset: 0x14211F0 VA: 0x14251F0
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Contains
	|
	|-RVA: 0x1425FD0 Offset: 0x1421FD0 VA: 0x1425FD0
	|-ReadOnlyCollection<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x1427318 Offset: 0x1423318 VA: 0x1427318
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1423530 Offset: 0x141F530 VA: 0x1423530
	|-ReadOnlyCollection<bool>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x1424438 Offset: 0x1420438 VA: 0x1424438
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x1425298 Offset: 0x1421298 VA: 0x1425298
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x1426080 Offset: 0x1422080 VA: 0x1426080
	|-ReadOnlyCollection<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x142742C Offset: 0x142342C VA: 0x142742C
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14235D8 Offset: 0x141F5D8 VA: 0x14235D8
	|-ReadOnlyCollection<bool>.System.Collections.IList.Insert
	|
	|-RVA: 0x14244F4 Offset: 0x14204F4 VA: 0x14244F4
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Insert
	|
	|-RVA: 0x1425340 Offset: 0x1421340 VA: 0x1425340
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Insert
	|
	|-RVA: 0x1426130 Offset: 0x1422130 VA: 0x1426130
	|-ReadOnlyCollection<object>.System.Collections.IList.Insert
	|
	|-RVA: 0x1427538 Offset: 0x1423538 VA: 0x1427538
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14235E4 Offset: 0x141F5E4 VA: 0x14235E4
	|-ReadOnlyCollection<bool>.System.Collections.IList.Remove
	|
	|-RVA: 0x1424500 Offset: 0x1420500 VA: 0x1424500
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.Remove
	|
	|-RVA: 0x142534C Offset: 0x142134C VA: 0x142534C
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.Remove
	|
	|-RVA: 0x142613C Offset: 0x142213C VA: 0x142613C
	|-ReadOnlyCollection<object>.System.Collections.IList.Remove
	|
	|-RVA: 0x1427544 Offset: 0x1423544 VA: 0x1427544
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14235F0 Offset: 0x141F5F0 VA: 0x14235F0
	|-ReadOnlyCollection<bool>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x142450C Offset: 0x142050C VA: 0x142450C
	|-ReadOnlyCollection<CustomAttributeNamedArgument>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x1425358 Offset: 0x1421358 VA: 0x1425358
	|-ReadOnlyCollection<CustomAttributeTypedArgument>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x1426148 Offset: 0x1422148 VA: 0x1426148
	|-ReadOnlyCollection<object>.System.Collections.IList.RemoveAt
	|
	|-RVA: 0x1427550 Offset: 0x1423550 VA: 0x1427550
	|-ReadOnlyCollection<__Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	*/
}

// Namespace: System.Collections.ObjectModel
[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(CollectionDebugView<T>))]
[Serializable]
public abstract class KeyedCollection<TKey, TItem> : Collection<TItem> // TypeDefIndex: 1454
{
	// Fields
	private readonly IEqualityComparer<TKey> comparer; // 0x0
	private Dictionary<TKey, TItem> dict; // 0x0
	private int keyCount; // 0x0
	private readonly int threshold; // 0x0

	// Properties
	private List<TItem> Items { get; }
	public TItem Item { get; }
	protected IDictionary<TKey, TItem> Dictionary { get; }

	// Methods

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3670 Offset: 0x12DF670 VA: 0x12E3670
	|-KeyedCollection<object, object>..ctor
	|
	|-RVA: 0x12E439C Offset: 0x12E039C VA: 0x12E439C
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3688 Offset: 0x12DF688 VA: 0x12E3688
	|-KeyedCollection<object, object>..ctor
	|
	|-RVA: 0x12E43B8 Offset: 0x12E03B8 VA: 0x12E43B8
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(IEqualityComparer<TKey> comparer, int dictionaryCreationThreshold) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E369C Offset: 0x12DF69C VA: 0x12E369C
	|-KeyedCollection<object, object>..ctor
	|
	|-RVA: 0x12E43D0 Offset: 0x12E03D0 VA: 0x12E43D0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private List<TItem> get_Items() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E37B0 Offset: 0x12DF7B0 VA: 0x12E37B0
	|-KeyedCollection<object, object>.get_Items
	|
	|-RVA: 0x12E44F0 Offset: 0x12E04F0 VA: 0x12E44F0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Items
	*/

	// RVA: -1 Offset: -1
	public TItem get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3824 Offset: 0x12DF824 VA: 0x12E3824
	|-KeyedCollection<object, object>.get_Item
	|
	|-RVA: 0x12E457C Offset: 0x12E057C VA: 0x12E457C
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public bool Contains(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E38CC Offset: 0x12DF8CC VA: 0x12E38CC
	|-KeyedCollection<object, object>.Contains
	|
	|-RVA: 0x12E4780 Offset: 0x12E0780 VA: 0x12E4780
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3B04 Offset: 0x12DFB04 VA: 0x12E3B04
	|-KeyedCollection<object, object>.TryGetValue
	|
	|-RVA: 0x12E4CE0 Offset: 0x12E0CE0 VA: 0x12E4CE0
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	protected IDictionary<TKey, TItem> get_Dictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3D9C Offset: 0x12DFD9C VA: 0x12E3D9C
	|-KeyedCollection<object, object>.get_Dictionary
	|
	|-RVA: 0x12E5374 Offset: 0x12E1374 VA: 0x12E5374
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Dictionary
	*/

	// RVA: -1 Offset: -1 Slot: 35
	protected override void ClearItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3DA4 Offset: 0x12DFDA4 VA: 0x12E3DA4
	|-KeyedCollection<object, object>.ClearItems
	|
	|-RVA: 0x12E537C Offset: 0x12E137C VA: 0x12E537C
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ClearItems
	*/

	// RVA: -1 Offset: -1 Slot: 39
	protected abstract TKey GetKeyForItem(TItem item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKeyForItem
	*/

	// RVA: -1 Offset: -1 Slot: 36
	protected override void InsertItem(int index, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3DF4 Offset: 0x12DFDF4 VA: 0x12E3DF4
	|-KeyedCollection<object, object>.InsertItem
	|
	|-RVA: 0x12E53D4 Offset: 0x12E13D4 VA: 0x12E53D4
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InsertItem
	*/

	// RVA: -1 Offset: -1 Slot: 37
	protected override void RemoveItem(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3E6C Offset: 0x12DFE6C VA: 0x12E3E6C
	|-KeyedCollection<object, object>.RemoveItem
	|
	|-RVA: 0x12E561C Offset: 0x12E161C VA: 0x12E561C
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveItem
	*/

	// RVA: -1 Offset: -1 Slot: 38
	protected override void SetItem(int index, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E3F20 Offset: 0x12DFF20 VA: 0x12E3F20
	|-KeyedCollection<object, object>.SetItem
	|
	|-RVA: 0x12E581C Offset: 0x12E181C VA: 0x12E581C
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetItem
	*/

	// RVA: -1 Offset: -1
	private void AddKey(TKey key, TItem item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E40E0 Offset: 0x12E00E0 VA: 0x12E40E0
	|-KeyedCollection<object, object>.AddKey
	|
	|-RVA: 0x12E5D58 Offset: 0x12E1D58 VA: 0x12E5D58
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddKey
	*/

	// RVA: -1 Offset: -1
	private void CreateDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E41CC Offset: 0x12E01CC VA: 0x12E41CC
	|-KeyedCollection<object, object>.CreateDictionary
	|
	|-RVA: 0x12E6044 Offset: 0x12E2044 VA: 0x12E6044
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateDictionary
	*/

	// RVA: -1 Offset: -1
	private void RemoveKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E4370 Offset: 0x12E0370 VA: 0x12E4370
	|-KeyedCollection<object, object>.RemoveKey
	|
	|-RVA: 0x12E6500 Offset: 0x12E2500 VA: 0x12E6500
	|-KeyedCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.RemoveKey
	*/
}

// Namespace: 
[Serializable]
private struct ReadOnlyDictionary.DictionaryEnumerator<TKey, TValue> : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 1455
{
	// Fields
	private readonly IDictionary<TKey, TValue> _dictionary; // 0x0
	private IEnumerator<KeyValuePair<TKey, TValue>> _enumerator; // 0x0

	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157ABC0 Offset: 0x1576BC0 VA: 0x157ABC0
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>..ctor
	|
	|-RVA: 0x157BF60 Offset: 0x1577F60 VA: 0x157BF60
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DictionaryEntry get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157AC84 Offset: 0x1576C84 VA: 0x157AC84
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.get_Entry
	|
	|-RVA: 0x157C024 Offset: 0x1578024 VA: 0x157C024
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157AE1C Offset: 0x1576E1C VA: 0x157AE1C
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.get_Key
	|
	|-RVA: 0x157C424 Offset: 0x1578424 VA: 0x157C424
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157AEE8 Offset: 0x1576EE8 VA: 0x157AEE8
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.get_Value
	|
	|-RVA: 0x157C670 Offset: 0x1578670 VA: 0x157C670
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157AFB0 Offset: 0x1576FB0 VA: 0x157AFB0
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.get_Current
	|
	|-RVA: 0x157C8BC Offset: 0x15788BC VA: 0x157C8BC
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157B034 Offset: 0x1577034 VA: 0x157B034
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.MoveNext
	|
	|-RVA: 0x157C974 Offset: 0x1578974 VA: 0x157C974
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157B0D4 Offset: 0x15770D4 VA: 0x157B0D4
	|-ReadOnlyDictionary.DictionaryEnumerator<object, object>.Reset
	|
	|-RVA: 0x157CA14 Offset: 0x1578A14 VA: 0x157CA14
	|-ReadOnlyDictionary.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/
}

// Namespace: 
[DebuggerTypeProxy(typeof(CollectionDebugView<T>))]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public sealed class ReadOnlyDictionary.ValueCollection<TKey, TValue> : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue> // TypeDefIndex: 1456
{
	// Fields
	private readonly ICollection<TValue> _collection; // 0x0
	private object _syncRoot; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ICollection<TValue> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A479C Offset: 0x14A079C VA: 0x14A479C
	|-ReadOnlyDictionary.ValueCollection<object, object>..ctor
	|
	|-RVA: 0x14AA594 Offset: 0x14A6594 VA: 0x14AA594
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A4810 Offset: 0x14A0810 VA: 0x14A4810
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Add
	|
	|-RVA: 0x14AA608 Offset: 0x14A6608 VA: 0x14AA608
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A4858 Offset: 0x14A0858 VA: 0x14A4858
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Clear
	|
	|-RVA: 0x14AA650 Offset: 0x14A6650 VA: 0x14AA650
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A48A0 Offset: 0x14A08A0 VA: 0x14A48A0
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Contains
	|
	|-RVA: 0x14AA698 Offset: 0x14A6698 VA: 0x14AA698
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TValue[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A4940 Offset: 0x14A0940 VA: 0x14A4940
	|-ReadOnlyDictionary.ValueCollection<object, object>.CopyTo
	|
	|-RVA: 0x14AA7F0 Offset: 0x14A67F0 VA: 0x14AA7F0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A49E8 Offset: 0x14A09E8 VA: 0x14A49E8
	|-ReadOnlyDictionary.ValueCollection<object, object>.get_Count
	|
	|-RVA: 0x14AA898 Offset: 0x14A6898 VA: 0x14AA898
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A4A74 Offset: 0x14A0A74 VA: 0x14A4A74
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	|
	|-RVA: 0x14AA924 Offset: 0x14A6924 VA: 0x14AA924
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A4A7C Offset: 0x14A0A7C VA: 0x14A4A7C
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.Generic.ICollection<TValue>.Remove
	|
	|-RVA: 0x14AA92C Offset: 0x14A692C VA: 0x14AA92C
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A4AC4 Offset: 0x14A0AC4 VA: 0x14A4AC4
	|-ReadOnlyDictionary.ValueCollection<object, object>.GetEnumerator
	|
	|-RVA: 0x14AA974 Offset: 0x14A6974 VA: 0x14AA974
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A4B50 Offset: 0x14A0B50 VA: 0x14A4B50
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x14AAA00 Offset: 0x14A6A00 VA: 0x14AAA00
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A4BF0 Offset: 0x14A0BF0 VA: 0x14A4BF0
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14AAAA0 Offset: 0x14A6AA0 VA: 0x14AAAA0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A4C04 Offset: 0x14A0C04 VA: 0x14A4C04
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x14AAAB8 Offset: 0x14A6AB8 VA: 0x14AAAB8
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A4C0C Offset: 0x14A0C0C VA: 0x14A4C0C
	|-ReadOnlyDictionary.ValueCollection<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x14AAAC0 Offset: 0x14A6AC0 VA: 0x14AAAC0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A4D18 Offset: 0x14A0D18 VA: 0x14A4D18
	|-ReadOnlyDictionary.ValueCollection<object, object>..ctor
	|
	|-RVA: 0x14AABCC Offset: 0x14A6BCC VA: 0x14AABCC
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: System.Collections.ObjectModel
[DebuggerTypeProxy(typeof(DictionaryDebugView<K, V>))]
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[Serializable]
public class ReadOnlyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 1457
{
	// Fields
	private readonly IDictionary<TKey, TValue> m_dictionary; // 0x0
	private object _syncRoot; // 0x0
	private ReadOnlyDictionary.ValueCollection<TKey, TValue> _values; // 0x0

	// Properties
	public ReadOnlyDictionary.ValueCollection<TKey, TValue> Values { get; }
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.Values { get; }
	public TValue Item { get; }
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.Item { get; set; }
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> dictionary) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142755C Offset: 0x142355C VA: 0x142755C
	|-ReadOnlyDictionary<object, object>..ctor
	|
	|-RVA: 0x1428D44 Offset: 0x1424D44 VA: 0x1428D44
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public ReadOnlyDictionary.ValueCollection<TKey, TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14275D0 Offset: 0x14235D0 VA: 0x14275D0
	|-ReadOnlyDictionary<object, object>.get_Values
	|
	|-RVA: 0x1428DB8 Offset: 0x1424DB8 VA: 0x1428DB8
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14276DC Offset: 0x14236DC VA: 0x14276DC
	|-ReadOnlyDictionary<object, object>.ContainsKey
	|
	|-RVA: 0x1428EC8 Offset: 0x1424EC8 VA: 0x1428EC8
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142777C Offset: 0x142377C VA: 0x142777C
	|-ReadOnlyDictionary<object, object>.TryGetValue
	|
	|-RVA: 0x1429020 Offset: 0x1425020 VA: 0x1429020
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private ICollection<TValue> System.Collections.Generic.IDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427824 Offset: 0x1423824 VA: 0x1427824
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x1429184 Offset: 0x1425184 VA: 0x1429184
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427834 Offset: 0x1423834 VA: 0x1427834
	|-ReadOnlyDictionary<object, object>.get_Item
	|
	|-RVA: 0x1429198 Offset: 0x1425198 VA: 0x1429198
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14278D0 Offset: 0x14238D0 VA: 0x14278D0
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0x1429320 Offset: 0x1425320 VA: 0x1429320
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427918 Offset: 0x1423918 VA: 0x1427918
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0x1429368 Offset: 0x1425368 VA: 0x1429368
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private TValue System.Collections.Generic.IDictionary<TKey,TValue>.get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427960 Offset: 0x1423960 VA: 0x1427960
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	|
	|-RVA: 0x14293B0 Offset: 0x14253B0 VA: 0x14293B0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void System.Collections.Generic.IDictionary<TKey,TValue>.set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14279FC Offset: 0x14239FC VA: 0x14279FC
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.set_Item
	|
	|-RVA: 0x1429538 Offset: 0x1425538 VA: 0x1429538
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427A44 Offset: 0x1423A44 VA: 0x1427A44
	|-ReadOnlyDictionary<object, object>.get_Count
	|
	|-RVA: 0x1429580 Offset: 0x1425580 VA: 0x1429580
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427AD0 Offset: 0x1423AD0 VA: 0x1427AD0
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x142960C Offset: 0x142560C VA: 0x142960C
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427B78 Offset: 0x1423B78 VA: 0x1427B78
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x142972C Offset: 0x142572C VA: 0x142972C
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427C20 Offset: 0x1423C20 VA: 0x1427C20
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|
	|-RVA: 0x14297D4 Offset: 0x14257D4 VA: 0x14297D4
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427C28 Offset: 0x1423C28 VA: 0x1427C28
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x14297DC Offset: 0x14257DC VA: 0x14297DC
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427C70 Offset: 0x1423C70 VA: 0x1427C70
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	|
	|-RVA: 0x1429824 Offset: 0x1425824 VA: 0x1429824
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427CB8 Offset: 0x1423CB8 VA: 0x1427CB8
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x142986C Offset: 0x142586C VA: 0x142986C
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427D00 Offset: 0x1423D00 VA: 0x1427D00
	|-ReadOnlyDictionary<object, object>.GetEnumerator
	|
	|-RVA: 0x14298B4 Offset: 0x14258B4 VA: 0x14298B4
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427D8C Offset: 0x1423D8C VA: 0x1427D8C
	|-ReadOnlyDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1429940 Offset: 0x1425940 VA: 0x1429940
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private static bool IsCompatibleKey(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427E2C Offset: 0x1423E2C VA: 0x1427E2C
	|-ReadOnlyDictionary<object, object>.IsCompatibleKey
	|
	|-RVA: 0x14299E0 Offset: 0x14259E0 VA: 0x14299E0
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsCompatibleKey
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427ECC Offset: 0x1423ECC VA: 0x1427ECC
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x1429A80 Offset: 0x1425A80 VA: 0x1429A80
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.IDictionary.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427F14 Offset: 0x1423F14 VA: 0x1427F14
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.Clear
	|
	|-RVA: 0x1429AC8 Offset: 0x1425AC8 VA: 0x1429AC8
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1427F5C Offset: 0x1423F5C VA: 0x1427F5C
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x1429B10 Offset: 0x1425B10 VA: 0x1429B10
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x142800C Offset: 0x142400C VA: 0x142800C
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x1429C24 Offset: 0x1425C24 VA: 0x1429C24
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428118 Offset: 0x1424118 VA: 0x1428118
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	|
	|-RVA: 0x1429D30 Offset: 0x1425D30 VA: 0x1429D30
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428120 Offset: 0x1424120 VA: 0x1428120
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x1429D38 Offset: 0x1425D38 VA: 0x1429D38
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428168 Offset: 0x1424168 VA: 0x1428168
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x1429D80 Offset: 0x1425D80 VA: 0x1429D80
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428178 Offset: 0x1424178 VA: 0x1428178
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x1429D94 Offset: 0x1425D94 VA: 0x1429D94
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428228 Offset: 0x1424228 VA: 0x1428228
	|-ReadOnlyDictionary<object, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x1429ECC Offset: 0x1425ECC VA: 0x1429ECC
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428270 Offset: 0x1424270 VA: 0x1428270
	|-ReadOnlyDictionary<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1429F14 Offset: 0x1425F14 VA: 0x1429F14
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428C20 Offset: 0x1424C20 VA: 0x1428C20
	|-ReadOnlyDictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x142ACEC Offset: 0x1426CEC VA: 0x142ACEC
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428C28 Offset: 0x1424C28 VA: 0x1428C28
	|-ReadOnlyDictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x142ACF4 Offset: 0x1426CF4 VA: 0x142ACF4
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 36
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1428D34 Offset: 0x1424D34 VA: 0x1428D34
	|-ReadOnlyDictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x142AE00 Offset: 0x1426E00 VA: 0x142AE00
	|-ReadOnlyDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/
}

// Namespace: System.Collections.ObjectModel
internal static class ReadOnlyDictionaryHelpers // TypeDefIndex: 1458
{
	// Methods

	// RVA: -1 Offset: -1
	internal static void CopyToNonGenericICollectionHelper<T>(ICollection<T> collection, Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113DFF4 Offset: 0x1139FF4 VA: 0x113DFF4
	|-ReadOnlyDictionaryHelpers.CopyToNonGenericICollectionHelper<object>
	|
	|-RVA: 0x113E714 Offset: 0x113A714 VA: 0x113E714
	|-ReadOnlyDictionaryHelpers.CopyToNonGenericICollectionHelper<__Il2CppFullySharedGenericType>
	*/
}
