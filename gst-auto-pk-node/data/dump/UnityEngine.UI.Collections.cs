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

// Namespace: UnityEngine.UI.Collections
[DefaultMember("Item")]
internal class IndexedSet<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 7359
{
	// Fields
	private readonly List<T> m_List; // 0x0
	private Dictionary<T, int> m_Dictionary; // 0x0
	private int m_EnabledObjectCount; // 0x0

	// Properties
	public int Count { get; }
	public int Capacity { get; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CAB4 Offset: 0x1278AB4 VA: 0x127CAB4
	|-IndexedSet<object>.Add
	|
	|-RVA: 0x127D498 Offset: 0x1279498 VA: 0x127D498
	|-IndexedSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Add(T item, bool isActive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CAC8 Offset: 0x1278AC8 VA: 0x127CAC8
	|-IndexedSet<object>.Add
	|
	|-RVA: 0x127D560 Offset: 0x1279560 VA: 0x127D560
	|-IndexedSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public bool AddUnique(T item, bool isActive = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CBB8 Offset: 0x1278BB8 VA: 0x127CBB8
	|-IndexedSet<object>.AddUnique
	|
	|-RVA: 0x127D754 Offset: 0x1279754 VA: 0x127D754
	|-IndexedSet<__Il2CppFullySharedGenericType>.AddUnique
	*/

	// RVA: -1 Offset: -1
	public bool EnableItem(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CC58 Offset: 0x1278C58 VA: 0x127CC58
	|-IndexedSet<object>.EnableItem
	|
	|-RVA: 0x127D904 Offset: 0x1279904 VA: 0x127D904
	|-IndexedSet<__Il2CppFullySharedGenericType>.EnableItem
	*/

	// RVA: -1 Offset: -1
	public bool DisableItem(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CCE0 Offset: 0x1278CE0 VA: 0x127CCE0
	|-IndexedSet<object>.DisableItem
	|
	|-RVA: 0x127DA38 Offset: 0x1279A38 VA: 0x127DA38
	|-IndexedSet<__Il2CppFullySharedGenericType>.DisableItem
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CD70 Offset: 0x1278D70 VA: 0x127CD70
	|-IndexedSet<object>.Remove
	|
	|-RVA: 0x127DB74 Offset: 0x1279B74 VA: 0x127DB74
	|-IndexedSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CDE0 Offset: 0x1278DE0 VA: 0x127CDE0
	|-IndexedSet<object>.GetEnumerator
	|
	|-RVA: 0x127DC90 Offset: 0x1279C90 VA: 0x127DC90
	|-IndexedSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CE14 Offset: 0x1278E14 VA: 0x127CE14
	|-IndexedSet<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x127DCC4 Offset: 0x1279CC4 VA: 0x127DCC4
	|-IndexedSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CE28 Offset: 0x1278E28 VA: 0x127CE28
	|-IndexedSet<object>.Clear
	|
	|-RVA: 0x127DCD8 Offset: 0x1279CD8 VA: 0x127DCD8
	|-IndexedSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CE90 Offset: 0x1278E90 VA: 0x127CE90
	|-IndexedSet<object>.Contains
	|
	|-RVA: 0x127DD34 Offset: 0x1279D34 VA: 0x127DD34
	|-IndexedSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CEB0 Offset: 0x1278EB0 VA: 0x127CEB0
	|-IndexedSet<object>.CopyTo
	|
	|-RVA: 0x127DE14 Offset: 0x1279E14 VA: 0x127DE14
	|-IndexedSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CED0 Offset: 0x1278ED0 VA: 0x127CED0
	|-IndexedSet<object>.get_Count
	|
	|-RVA: 0x127DE38 Offset: 0x1279E38 VA: 0x127DE38
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CED8 Offset: 0x1278ED8 VA: 0x127CED8
	|-IndexedSet<object>.get_Capacity
	|
	|-RVA: 0x127DE40 Offset: 0x1279E40 VA: 0x127DE40
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CEF0 Offset: 0x1278EF0 VA: 0x127CEF0
	|-IndexedSet<object>.get_IsReadOnly
	|
	|-RVA: 0x127DE64 Offset: 0x1279E64 VA: 0x127DE64
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CEF8 Offset: 0x1278EF8 VA: 0x127CEF8
	|-IndexedSet<object>.IndexOf
	|
	|-RVA: 0x127DE6C Offset: 0x1279E6C VA: 0x127DE6C
	|-IndexedSet<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CF38 Offset: 0x1278F38 VA: 0x127CF38
	|-IndexedSet<object>.Insert
	|
	|-RVA: 0x127DF5C Offset: 0x1279F5C VA: 0x127DF5C
	|-IndexedSet<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127CF80 Offset: 0x1278F80 VA: 0x127CF80
	|-IndexedSet<object>.RemoveAt
	|
	|-RVA: 0x127DFA4 Offset: 0x1279FA4 VA: 0x127DFA4
	|-IndexedSet<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	private void Swap(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D088 Offset: 0x1279088 VA: 0x127D088
	|-IndexedSet<object>.Swap
	|
	|-RVA: 0x127E1F8 Offset: 0x127A1F8 VA: 0x127E1F8
	|-IndexedSet<__Il2CppFullySharedGenericType>.Swap
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D19C Offset: 0x127919C VA: 0x127D19C
	|-IndexedSet<object>.get_Item
	|
	|-RVA: 0x127E538 Offset: 0x127A538 VA: 0x127E538
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D200 Offset: 0x1279200 VA: 0x127D200
	|-IndexedSet<object>.set_Item
	|
	|-RVA: 0x127E644 Offset: 0x127A644 VA: 0x127E644
	|-IndexedSet<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void RemoveAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D2A4 Offset: 0x12792A4 VA: 0x127D2A4
	|-IndexedSet<object>.RemoveAll
	|
	|-RVA: 0x127E85C Offset: 0x127A85C VA: 0x127E85C
	|-IndexedSet<__Il2CppFullySharedGenericType>.RemoveAll
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> sortLayoutFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D34C Offset: 0x127934C VA: 0x127D34C
	|-IndexedSet<object>.Sort
	|
	|-RVA: 0x127EA50 Offset: 0x127AA50 VA: 0x127EA50
	|-IndexedSet<__Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127D3E0 Offset: 0x12793E0 VA: 0x127D3E0
	|-IndexedSet<object>..ctor
	|
	|-RVA: 0x127EBD0 Offset: 0x127ABD0 VA: 0x127EBD0
	|-IndexedSet<__Il2CppFullySharedGenericType>..ctor
	*/
}
