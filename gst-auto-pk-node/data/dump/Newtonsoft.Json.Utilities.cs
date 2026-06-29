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

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class Base64Encoder // TypeDefIndex: 6042
{
	// Fields
	private readonly char[] _charsLine; // 0x10
	private readonly TextWriter _writer; // 0x18
	[Nullable(2)]
	private byte[] _leftOverBytes; // 0x20
	private int _leftOverBytesCount; // 0x28

	// Methods

	// RVA: 0x19361D8 Offset: 0x19321D8 VA: 0x19361D8
	public void .ctor(TextWriter writer) { }

	// RVA: 0x19362C4 Offset: 0x19322C4 VA: 0x19362C4
	private void ValidateEncode(byte[] buffer, int index, int count) { }

	// RVA: 0x1936388 Offset: 0x1932388 VA: 0x1936388
	public void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x19365E4 Offset: 0x19325E4 VA: 0x19365E4
	private void StoreLeftOverBytes(byte[] buffer, int index, ref int count) { }

	// RVA: 0x1936528 Offset: 0x1932528 VA: 0x1936528
	private bool FulfillFromLeftover(byte[] buffer, int index, ref int count) { }

	// RVA: 0x19366FC Offset: 0x19326FC VA: 0x19366FC
	public void Flush() { }

	// RVA: 0x19365C4 Offset: 0x19325C4 VA: 0x19365C4
	private void WriteChars(char[] chars, int index, int count) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class BidirectionalDictionary<TFirst, TSecond> // TypeDefIndex: 6043
{
	// Fields
	private readonly IDictionary<TFirst, TSecond> _firstToSecond; // 0x0
	private readonly IDictionary<TSecond, TFirst> _secondToFirst; // 0x0
	private readonly string _duplicateFirstErrorMessage; // 0x0
	private readonly string _duplicateSecondErrorMessage; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TFirst> firstEqualityComparer, IEqualityComparer<TSecond> secondEqualityComparer, string duplicateFirstErrorMessage, string duplicateSecondErrorMessage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D72A0 Offset: 0x14D32A0 VA: 0x14D72A0
	|-BidirectionalDictionary<object, object>..ctor
	|
	|-RVA: 0x14D7818 Offset: 0x14D3818 VA: 0x14D7818
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void Set(TFirst first, TSecond second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D7390 Offset: 0x14D3390 VA: 0x14D7390
	|-BidirectionalDictionary<object, object>.Set
	|
	|-RVA: 0x14D7910 Offset: 0x14D3910 VA: 0x14D7910
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Set
	*/

	// RVA: -1 Offset: -1
	public bool TryGetByFirst(TFirst first, out TSecond second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D76C8 Offset: 0x14D36C8 VA: 0x14D76C8
	|-BidirectionalDictionary<object, object>.TryGetByFirst
	|
	|-RVA: 0x14D80C0 Offset: 0x14D40C0 VA: 0x14D80C0
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetByFirst
	*/

	// RVA: -1 Offset: -1
	public bool TryGetBySecond(TSecond second, out TFirst first) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D7770 Offset: 0x14D3770 VA: 0x14D7770
	|-BidirectionalDictionary<object, object>.TryGetBySecond
	|
	|-RVA: 0x14D8224 Offset: 0x14D4224 VA: 0x14D8224
	|-BidirectionalDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetBySecond
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class BoxedPrimitives // TypeDefIndex: 6044
{
	// Fields
	internal static readonly object BooleanTrue; // 0x0
	internal static readonly object BooleanFalse; // 0x8
	internal static readonly object Int32_M1; // 0x10
	internal static readonly object Int32_0; // 0x18
	internal static readonly object Int32_1; // 0x20
	internal static readonly object Int32_2; // 0x28
	internal static readonly object Int32_3; // 0x30
	internal static readonly object Int32_4; // 0x38
	internal static readonly object Int32_5; // 0x40
	internal static readonly object Int32_6; // 0x48
	internal static readonly object Int32_7; // 0x50
	internal static readonly object Int32_8; // 0x58
	internal static readonly object Int64_M1; // 0x60
	internal static readonly object Int64_0; // 0x68
	internal static readonly object Int64_1; // 0x70
	internal static readonly object Int64_2; // 0x78
	internal static readonly object Int64_3; // 0x80
	internal static readonly object Int64_4; // 0x88
	internal static readonly object Int64_5; // 0x90
	internal static readonly object Int64_6; // 0x98
	internal static readonly object Int64_7; // 0xA0
	internal static readonly object Int64_8; // 0xA8
	private static readonly object DecimalZero; // 0xB0
	internal static readonly object DoubleNaN; // 0xB8
	internal static readonly object DoublePositiveInfinity; // 0xC0
	internal static readonly object DoubleNegativeInfinity; // 0xC8
	internal static readonly object DoubleZero; // 0xD0

	// Methods

	// RVA: 0x19367B4 Offset: 0x19327B4 VA: 0x19367B4
	internal static object Get(bool value) { }

	// RVA: 0x193682C Offset: 0x193282C VA: 0x193682C
	internal static object Get(int value) { }

	// RVA: 0x1936A70 Offset: 0x1932A70 VA: 0x1936A70
	internal static object Get(long value) { }

	// RVA: 0x1936C10 Offset: 0x1932C10 VA: 0x1936C10
	internal static object Get(Decimal value) { }

	// RVA: 0x1936CF8 Offset: 0x1932CF8 VA: 0x1936CF8
	internal static object Get(double value) { }

	// RVA: 0x1936E04 Offset: 0x1932E04 VA: 0x1936E04
	private static void .cctor() { }
}

// Namespace: 
[NullableContext(0)]
private static class CollectionUtils.EmptyArrayContainer<T> // TypeDefIndex: 6045
{
	// Fields
	[Nullable(1)]
	public static readonly T[] Empty; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C9130 Offset: 0x11C5130 VA: 0x11C9130
	|-CollectionUtils.EmptyArrayContainer<byte>..cctor
	|
	|-RVA: 0x11C91F0 Offset: 0x11C51F0 VA: 0x11C91F0
	|-CollectionUtils.EmptyArrayContainer<int>..cctor
	|
	|-RVA: 0x11C92B0 Offset: 0x11C52B0 VA: 0x11C92B0
	|-CollectionUtils.EmptyArrayContainer<object>..cctor
	|
	|-RVA: 0x11C9370 Offset: 0x11C5370 VA: 0x11C9370
	|-CollectionUtils.EmptyArrayContainer<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class CollectionUtils // TypeDefIndex: 6046
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool IsNullOrEmpty<T>(ICollection<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F26BC Offset: 0x10EE6BC VA: 0x10F26BC
	|-CollectionUtils.IsNullOrEmpty<object>
	|
	|-RVA: 0x10F2774 Offset: 0x10EE774 VA: 0x10F2774
	|-CollectionUtils.IsNullOrEmpty<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void AddRange<T>(IList<T> initial, IEnumerable<T> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F0E24 Offset: 0x10ECE24 VA: 0x10F0E24
	|-CollectionUtils.AddRange<object>
	|
	|-RVA: 0x10F118C Offset: 0x10ED18C VA: 0x10F118C
	|-CollectionUtils.AddRange<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x193732C Offset: 0x193332C VA: 0x193732C
	public static bool IsDictionaryType(Type type) { }

	// RVA: 0x1937528 Offset: 0x1933528 VA: 0x1937528
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType) { }

	// RVA: 0x1937638 Offset: 0x1933638 VA: 0x1937638
	public static ConstructorInfo ResolveEnumerableCollectionConstructor(Type collectionType, Type collectionItemType, Type constructorArgumentType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOf<T>(IEnumerable<T> collection, Func<T, bool> predicate) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F1DB8 Offset: 0x10EDDB8 VA: 0x10F1DB8
	|-CollectionUtils.IndexOf<object>
	|
	|-RVA: 0x10F20A8 Offset: 0x10EE0A8 VA: 0x10F20A8
	|-CollectionUtils.IndexOf<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static bool Contains<T>(List<T> list, T value, IEqualityComparer comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F1774 Offset: 0x10ED774 VA: 0x10F1774
	|-CollectionUtils.Contains<object>
	|
	|-RVA: 0x10F1894 Offset: 0x10ED894 VA: 0x10F1894
	|-CollectionUtils.Contains<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F24A4 Offset: 0x10EE4A4 VA: 0x10F24A4
	|-CollectionUtils.IndexOfReference<object>
	|
	|-RVA: 0x10F2528 Offset: 0x10EE528 VA: 0x10F2528
	|-CollectionUtils.IndexOfReference<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static void FastReverse<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F1AB8 Offset: 0x10EDAB8 VA: 0x10F1AB8
	|-CollectionUtils.FastReverse<JsonPosition>
	|
	|-RVA: 0x10F1BB8 Offset: 0x10EDBB8 VA: 0x10F1BB8
	|-CollectionUtils.FastReverse<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1937960 Offset: 0x1933960 VA: 0x1937960
	private static IList<int> GetDimensions(IList values, int dimensionsCount) { }

	// RVA: 0x1937C14 Offset: 0x1933C14 VA: 0x1937C14
	private static void CopyFromJaggedToMultidimensionalArray(IList values, Array multidimensionalArray, int[] indices) { }

	// RVA: 0x1937EC8 Offset: 0x1933EC8 VA: 0x1937EC8
	private static object JaggedArrayGetValue(IList values, int[] indices) { }

	// RVA: 0x1938068 Offset: 0x1934068 VA: 0x1938068
	public static Array ToMultidimensionalArray(IList values, Type type, int rank) { }

	// RVA: -1 Offset: -1
	public static T[] ArrayEmpty<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F15E4 Offset: 0x10ED5E4 VA: 0x10F15E4
	|-CollectionUtils.ArrayEmpty<byte>
	|
	|-RVA: 0x10F1648 Offset: 0x10ED648 VA: 0x10F1648
	|-CollectionUtils.ArrayEmpty<int>
	|
	|-RVA: 0x10F16AC Offset: 0x10ED6AC VA: 0x10F16AC
	|-CollectionUtils.ArrayEmpty<object>
	|
	|-RVA: 0x10F1710 Offset: 0x10ED710 VA: 0x10F1710
	|-CollectionUtils.ArrayEmpty<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Newtonsoft.Json.Utilities
internal interface IWrappedCollection : IList, ICollection, IEnumerable // TypeDefIndex: 6047
{
	// Properties
	[Nullable(1)]
	public abstract object UnderlyingCollection { get; }

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_UnderlyingCollection();
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class CollectionWrapper<T> : ICollection<T>, IEnumerable<T>, IEnumerable, IWrappedCollection, IList, ICollection // TypeDefIndex: 6048
{
	// Fields
	[Nullable(2)]
	private readonly IList _list; // 0x0
	[Nullable(new[] { 2, 1 })]
	private readonly ICollection<T> _genericCollection; // 0x0
	[Nullable(2)]
	private object _syncRoot; // 0x0

	// Properties
	public virtual int Count { get; }
	public virtual bool IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	[Nullable(2)]
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object UnderlyingCollection { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 29
	public virtual void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E4688 Offset: 0x14E0688 VA: 0x14E4688
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 30
	public virtual void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E48A0 Offset: 0x14E08A0 VA: 0x14E48A0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public virtual bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E49B8 Offset: 0x14E09B8 VA: 0x14E49B8
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public virtual void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E4BE0 Offset: 0x14E0BE0 VA: 0x14E4BE0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public virtual int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E4D10 Offset: 0x14E0D10 VA: 0x14E4D10
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public virtual bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E4E28 Offset: 0x14E0E28 VA: 0x14E4E28
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public virtual bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E4F40 Offset: 0x14E0F40 VA: 0x14E4F40
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public virtual IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E5230 Offset: 0x14E1230 VA: 0x14E5230
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E52E8 Offset: 0x14E12E8 VA: 0x14E52E8
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 16
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E5390 Offset: 0x14E1390 VA: 0x14E5390
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 17
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E54A0 Offset: 0x14E14A0 VA: 0x14E54A0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 21
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E55B0 Offset: 0x14E15B0 VA: 0x14E55B0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private void System.Collections.IList.RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E5790 Offset: 0x14E1790 VA: 0x14E5790
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.RemoveAt
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E588C Offset: 0x14E188C VA: 0x14E588C
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E5A68 Offset: 0x14E1A68 VA: 0x14E5A68
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 23
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E5B80 Offset: 0x14E1B80 VA: 0x14E5B80
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 14
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E5C7C Offset: 0x14E1C7C VA: 0x14E5C7C
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 15
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E5D74 Offset: 0x14E1D74 VA: 0x14E5D74
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.ICollection.CopyTo(Array array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E5F50 Offset: 0x14E1F50 VA: 0x14E5F50
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E5FD8 Offset: 0x14E1FD8 VA: 0x14E5FD8
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E5FE0 Offset: 0x14E1FE0 VA: 0x14E5FE0
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	private static void VerifyValueType(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6054 Offset: 0x14E2054 VA: 0x14E6054
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.VerifyValueType
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	private static bool IsCompatibleObject(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E6188 Offset: 0x14E2188 VA: 0x14E6188
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.IsCompatibleObject
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public object get_UnderlyingCollection() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E62D4 Offset: 0x14E22D4 VA: 0x14E62D4
	|-CollectionWrapper<__Il2CppFullySharedGenericType>.get_UnderlyingCollection
	*/
}

// Namespace: Newtonsoft.Json.Utilities
internal enum PrimitiveTypeCode // TypeDefIndex: 6049
{
	// Fields
	public int value__; // 0x0
	public const PrimitiveTypeCode Empty = 0;
	public const PrimitiveTypeCode Object = 1;
	public const PrimitiveTypeCode Char = 2;
	public const PrimitiveTypeCode CharNullable = 3;
	public const PrimitiveTypeCode Boolean = 4;
	public const PrimitiveTypeCode BooleanNullable = 5;
	public const PrimitiveTypeCode SByte = 6;
	public const PrimitiveTypeCode SByteNullable = 7;
	public const PrimitiveTypeCode Int16 = 8;
	public const PrimitiveTypeCode Int16Nullable = 9;
	public const PrimitiveTypeCode UInt16 = 10;
	public const PrimitiveTypeCode UInt16Nullable = 11;
	public const PrimitiveTypeCode Int32 = 12;
	public const PrimitiveTypeCode Int32Nullable = 13;
	public const PrimitiveTypeCode Byte = 14;
	public const PrimitiveTypeCode ByteNullable = 15;
	public const PrimitiveTypeCode UInt32 = 16;
	public const PrimitiveTypeCode UInt32Nullable = 17;
	public const PrimitiveTypeCode Int64 = 18;
	public const PrimitiveTypeCode Int64Nullable = 19;
	public const PrimitiveTypeCode UInt64 = 20;
	public const PrimitiveTypeCode UInt64Nullable = 21;
	public const PrimitiveTypeCode Single = 22;
	public const PrimitiveTypeCode SingleNullable = 23;
	public const PrimitiveTypeCode Double = 24;
	public const PrimitiveTypeCode DoubleNullable = 25;
	public const PrimitiveTypeCode DateTime = 26;
	public const PrimitiveTypeCode DateTimeNullable = 27;
	public const PrimitiveTypeCode DateTimeOffset = 28;
	public const PrimitiveTypeCode DateTimeOffsetNullable = 29;
	public const PrimitiveTypeCode Decimal = 30;
	public const PrimitiveTypeCode DecimalNullable = 31;
	public const PrimitiveTypeCode Guid = 32;
	public const PrimitiveTypeCode GuidNullable = 33;
	public const PrimitiveTypeCode TimeSpan = 34;
	public const PrimitiveTypeCode TimeSpanNullable = 35;
	public const PrimitiveTypeCode BigInteger = 36;
	public const PrimitiveTypeCode BigIntegerNullable = 37;
	public const PrimitiveTypeCode Uri = 38;
	public const PrimitiveTypeCode String = 39;
	public const PrimitiveTypeCode Bytes = 40;
	public const PrimitiveTypeCode DBNull = 41;
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class TypeInformation // TypeDefIndex: 6050
{
	// Fields
	[CompilerGenerated]
	private readonly Type <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly PrimitiveTypeCode <TypeCode>k__BackingField; // 0x18

	// Properties
	public Type Type { get; }
	public PrimitiveTypeCode TypeCode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x193824C Offset: 0x193424C VA: 0x193824C
	public Type get_Type() { }

	[CompilerGenerated]
	// RVA: 0x1938254 Offset: 0x1934254 VA: 0x1938254
	public PrimitiveTypeCode get_TypeCode() { }

	// RVA: 0x193825C Offset: 0x193425C VA: 0x193825C
	public void .ctor(Type type, PrimitiveTypeCode typeCode) { }
}

// Namespace: Newtonsoft.Json.Utilities
internal enum ParseResult // TypeDefIndex: 6051
{
	// Fields
	public int value__; // 0x0
	public const ParseResult None = 0;
	public const ParseResult Success = 1;
	public const ParseResult Overflow = 2;
	public const ParseResult Invalid = 3;
}

// Namespace: 
[NullableContext(0)]
internal enum ConvertUtils.ConvertResult // TypeDefIndex: 6052
{
	// Fields
	public int value__; // 0x0
	public const ConvertUtils.ConvertResult Success = 0;
	public const ConvertUtils.ConvertResult CannotConvertNull = 1;
	public const ConvertUtils.ConvertResult NotInstantiableType = 2;
	public const ConvertUtils.ConvertResult NoValidConversion = 3;
}

// Namespace: 
[CompilerGenerated]
private sealed class ConvertUtils.<>c__DisplayClass8_0 // TypeDefIndex: 6053
{
	// Fields
	[Nullable(new[] { 0, 2, 2 })]
	public MethodCall<object, object> call; // 0x10

	// Methods

	// RVA: 0x1938AC0 Offset: 0x1934AC0 VA: 0x1938AC0
	public void .ctor() { }

	[NullableContext(2)]
	// RVA: 0x193C5D4 Offset: 0x19385D4 VA: 0x193C5D4
	internal object <CreateCastConverter>b__0(object o) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class ConvertUtils // TypeDefIndex: 6054
{
	// Fields
	private static readonly Dictionary<Type, PrimitiveTypeCode> TypeCodeMap; // 0x0
	private static readonly TypeInformation[] PrimitiveTypeCodes; // 0x8
	[Nullable(new[] { 1, 0, 1, 1, 2, 2, 2 })]
	private static readonly ThreadSafeStore<StructMultiKey<Type, Type>, Func<object, object>> CastConverters; // 0x10

	// Methods

	// RVA: 0x1938298 Offset: 0x1934298 VA: 0x1938298
	public static PrimitiveTypeCode GetTypeCode(Type t) { }

	// RVA: 0x1938300 Offset: 0x1934300 VA: 0x1938300
	public static PrimitiveTypeCode GetTypeCode(Type t, out bool isEnum) { }

	// RVA: 0x193866C Offset: 0x193466C VA: 0x193866C
	public static TypeInformation GetTypeInformation(IConvertible convertable) { }

	// RVA: 0x1938758 Offset: 0x1934758 VA: 0x1938758
	public static bool IsConvertible(Type t) { }

	// RVA: 0x19387D8 Offset: 0x19347D8 VA: 0x19387D8
	public static TimeSpan ParseTimeSpan(string input) { }

	[NullableContext(2)]
	// RVA: 0x1938868 Offset: 0x1934868 VA: 0x1938868
	private static Func<object, object> CreateCastConverter(StructMultiKey<Type, Type> t) { }

	// RVA: 0x1938AC8 Offset: 0x1934AC8 VA: 0x1938AC8
	internal static BigInteger ToBigInteger(object value) { }

	// RVA: 0x1938E68 Offset: 0x1934E68 VA: 0x1938E68
	public static object FromBigInteger(BigInteger i, Type targetType) { }

	// RVA: 0x19392F0 Offset: 0x19352F0 VA: 0x19392F0
	public static object Convert(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0x193A020 Offset: 0x1936020 VA: 0x193A020
	private static bool TryConvert(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x193954C Offset: 0x193554C VA: 0x193954C
	private static ConvertUtils.ConvertResult TryConvertInternal(object initialValue, CultureInfo culture, Type targetType, out object value) { }

	// RVA: 0x193A4C4 Offset: 0x19364C4 VA: 0x193A4C4
	public static object ConvertOrCast(object initialValue, CultureInfo culture, Type targetType) { }

	// RVA: 0x193A278 Offset: 0x1936278 VA: 0x193A278
	private static object EnsureTypeAssignable(object value, Type initialType, Type targetType) { }

	// RVA: 0x193A1D4 Offset: 0x19361D4 VA: 0x193A1D4
	public static bool VersionTryParse(string input, out Version result) { }

	// RVA: 0x193A148 Offset: 0x1936148 VA: 0x193A148
	public static bool IsInteger(object value) { }

	// RVA: 0x193A630 Offset: 0x1936630 VA: 0x193A630
	public static ParseResult Int32TryParse(char[] chars, int start, int length, out int value) { }

	// RVA: 0x193A7B8 Offset: 0x19367B8 VA: 0x193A7B8
	public static ParseResult Int64TryParse(char[] chars, int start, int length, out long value) { }

	// RVA: 0x193A920 Offset: 0x1936920 VA: 0x193A920
	public static ParseResult DecimalTryParse(char[] chars, int start, int length, out Decimal value) { }

	// RVA: 0x193B2F4 Offset: 0x19372F4 VA: 0x193B2F4
	public static bool TryConvertGuid(string s, out Guid g) { }

	// RVA: 0x193B350 Offset: 0x1937350 VA: 0x193B350
	public static bool TryHexTextToInt(char[] text, int start, int end, out int value) { }

	// RVA: 0x193B420 Offset: 0x1937420 VA: 0x193B420
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
internal enum ParserTimeZone // TypeDefIndex: 6055
{
	// Fields
	public int value__; // 0x0
	public const ParserTimeZone Unspecified = 0;
	public const ParserTimeZone Utc = 1;
	public const ParserTimeZone LocalWestOfUtc = 2;
	public const ParserTimeZone LocalEastOfUtc = 3;
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal struct DateTimeParser // TypeDefIndex: 6056
{
	// Fields
	public int Year; // 0x0
	public int Month; // 0x4
	public int Day; // 0x8
	public int Hour; // 0xC
	public int Minute; // 0x10
	public int Second; // 0x14
	public int Fraction; // 0x18
	public int ZoneHour; // 0x1C
	public int ZoneMinute; // 0x20
	public ParserTimeZone Zone; // 0x24
	private char[] _text; // 0x28
	private int _end; // 0x30
	private static readonly int[] Power10; // 0x0
	private static readonly int Lzyyyy; // 0x8
	private static readonly int Lzyyyy_; // 0xC
	private static readonly int Lzyyyy_MM; // 0x10
	private static readonly int Lzyyyy_MM_; // 0x14
	private static readonly int Lzyyyy_MM_dd; // 0x18
	private static readonly int Lzyyyy_MM_ddT; // 0x1C
	private static readonly int LzHH; // 0x20
	private static readonly int LzHH_; // 0x24
	private static readonly int LzHH_mm; // 0x28
	private static readonly int LzHH_mm_; // 0x2C
	private static readonly int LzHH_mm_ss; // 0x30
	private static readonly int Lz_; // 0x34
	private static readonly int Lz_zz; // 0x38

	// Methods

	// RVA: 0x193C694 Offset: 0x1938694 VA: 0x193C694
	private static void .cctor() { }

	// RVA: 0x193C918 Offset: 0x1938918 VA: 0x193C918
	public bool Parse(char[] text, int startIndex, int length) { }

	// RVA: 0x193CA18 Offset: 0x1938A18 VA: 0x193CA18
	private bool ParseDate(int start) { }

	// RVA: 0x193CC04 Offset: 0x1938C04 VA: 0x193CC04
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x193CE1C Offset: 0x1938E1C VA: 0x193CE1C
	private bool ParseTime(ref int start) { }

	// RVA: 0x193D0E4 Offset: 0x19390E4 VA: 0x193D0E4
	private bool ParseZone(int start) { }

	// RVA: 0x193CCA0 Offset: 0x1938CA0 VA: 0x193CCA0
	private bool Parse4Digit(int start, out int num) { }

	// RVA: 0x193CD84 Offset: 0x1938D84 VA: 0x193CD84
	private bool Parse2Digit(int start, out int num) { }

	// RVA: 0x193CBB8 Offset: 0x1938BB8 VA: 0x193CBB8
	private bool ParseChar(int start, char ch) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class DateTimeUtils // TypeDefIndex: 6057
{
	// Fields
	internal static readonly long InitialJavaScriptDateTicks; // 0x0
	private static readonly int[] DaysToMonth365; // 0x8
	private static readonly int[] DaysToMonth366; // 0x10

	// Methods

	// RVA: 0x193D2E4 Offset: 0x19392E4 VA: 0x193D2E4
	private static void .cctor() { }

	[Extension]
	// RVA: 0x193D3DC Offset: 0x19393DC VA: 0x193D3DC
	public static TimeSpan GetUtcOffset(DateTime d) { }

	// RVA: 0x193D444 Offset: 0x1939444 VA: 0x193D444
	public static XmlDateTimeSerializationMode ToSerializationMode(DateTimeKind kind) { }

	// RVA: 0x193D5BC Offset: 0x19395BC VA: 0x193D5BC
	internal static DateTime EnsureDateTime(DateTime value, DateTimeZoneHandling timeZone) { }

	// RVA: 0x193D70C Offset: 0x193970C VA: 0x193D70C
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0x193D7E8 Offset: 0x19397E8 VA: 0x193D7E8
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x193D8C4 Offset: 0x19398C4 VA: 0x193D8C4
	private static long ToUniversalTicks(DateTime dateTime) { }

	// RVA: 0x193D984 Offset: 0x1939984 VA: 0x193D984
	private static long ToUniversalTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x193DADC Offset: 0x1939ADC VA: 0x193DADC
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, TimeSpan offset) { }

	// RVA: 0x193DBC0 Offset: 0x1939BC0 VA: 0x193DBC0
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime) { }

	// RVA: 0x193DC18 Offset: 0x1939C18 VA: 0x193DC18
	internal static long ConvertDateTimeToJavaScriptTicks(DateTime dateTime, bool convertToUtc) { }

	// RVA: 0x193DB44 Offset: 0x1939B44 VA: 0x193DB44
	private static long UniversalTicksToJavaScriptTicks(long universalTicks) { }

	// RVA: 0x193DCD4 Offset: 0x1939CD4 VA: 0x193DCD4
	internal static DateTime ConvertJavaScriptTicksToDateTime(long javaScriptTicks) { }

	// RVA: 0x193DD5C Offset: 0x1939D5C VA: 0x193DD5C
	internal static bool TryParseDateTimeIso(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x193E29C Offset: 0x193A29C VA: 0x193E29C
	internal static bool TryParseDateTimeOffsetIso(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x193E1A0 Offset: 0x193A1A0 VA: 0x193E1A0
	private static DateTime CreateDateTime(DateTimeParser dateTimeParser) { }

	// RVA: 0x193E518 Offset: 0x193A518 VA: 0x193E518
	internal static bool TryParseDateTime(StringReference s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x193EB64 Offset: 0x193AB64 VA: 0x193EB64
	internal static bool TryParseDateTime(string s, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x193EE58 Offset: 0x193AE58 VA: 0x193EE58
	internal static bool TryParseDateTimeOffset(StringReference s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x193F274 Offset: 0x193B274 VA: 0x193F274
	internal static bool TryParseDateTimeOffset(string s, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x193F53C Offset: 0x193B53C VA: 0x193F53C
	private static bool TryParseMicrosoftDate(StringReference text, out long ticks, out TimeSpan offset, out DateTimeKind kind) { }

	// RVA: 0x193E8F0 Offset: 0x193A8F0 VA: 0x193E8F0
	private static bool TryParseDateTimeMicrosoft(StringReference text, DateTimeZoneHandling dateTimeZoneHandling, out DateTime dt) { }

	// RVA: 0x193EA7C Offset: 0x193AA7C VA: 0x193EA7C
	private static bool TryParseDateTimeExact(string text, DateTimeZoneHandling dateTimeZoneHandling, string dateFormatString, CultureInfo culture, out DateTime dt) { }

	// RVA: 0x193F064 Offset: 0x193B064 VA: 0x193F064
	private static bool TryParseDateTimeOffsetMicrosoft(StringReference text, out DateTimeOffset dt) { }

	// RVA: 0x193F1C8 Offset: 0x193B1C8 VA: 0x193F1C8
	private static bool TryParseDateTimeOffsetExact(string text, string dateFormatString, CultureInfo culture, out DateTimeOffset dt) { }

	// RVA: 0x193F734 Offset: 0x193B734 VA: 0x193F734
	private static bool TryReadOffset(StringReference offsetText, int startIndex, out TimeSpan offset) { }

	// RVA: 0x193F8C4 Offset: 0x193B8C4 VA: 0x193F8C4
	internal static void WriteDateTimeString(TextWriter writer, DateTime value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x193FA34 Offset: 0x193BA34 VA: 0x193FA34
	internal static int WriteDateTimeString(char[] chars, int start, DateTime value, Nullable<TimeSpan> offset, DateTimeKind kind, DateFormatHandling format) { }

	// RVA: 0x193FEF8 Offset: 0x193BEF8 VA: 0x193FEF8
	internal static int WriteDefaultIsoDate(char[] chars, int start, DateTime dt) { }

	// RVA: 0x1940560 Offset: 0x193C560 VA: 0x1940560
	private static void CopyIntToCharArray(char[] chars, int start, int value, int digits) { }

	// RVA: 0x193FD44 Offset: 0x193BD44 VA: 0x193FD44
	internal static int WriteDateTimeOffset(char[] chars, int start, TimeSpan offset, DateFormatHandling format) { }

	// RVA: 0x19405C8 Offset: 0x193C5C8 VA: 0x19405C8
	internal static void WriteDateTimeOffsetString(TextWriter writer, DateTimeOffset value, DateFormatHandling format, string formatString, CultureInfo culture) { }

	// RVA: 0x1940324 Offset: 0x193C324 VA: 0x1940324
	private static void GetDateValues(DateTime td, out int year, out int month, out int day) { }
}

// Namespace: Newtonsoft.Json.Utilities
internal interface IWrappedDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 6058
{
	// Properties
	[Nullable(1)]
	public abstract object UnderlyingDictionary { get; }

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_UnderlyingDictionary();
}

// Namespace: 
[Nullable(0)]
[IsReadOnly]
private struct DictionaryWrapper.DictionaryEnumerator<TKey, TValue, TEnumeratorKey, TEnumeratorValue> : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 6059
{
	// Fields
	[Nullable(new[] { 1, 0, 1, 1 })]
	private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e; // 0x0

	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	[Nullable(2)]
	public object Value { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157CAB8 Offset: 0x1578AB8 VA: 0x157CAB8
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DictionaryEntry get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157CB20 Offset: 0x1578B20 VA: 0x157CB20
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157CBEC Offset: 0x1578BEC VA: 0x157CBEC
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 5
	public object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157CC64 Offset: 0x1578C64 VA: 0x157CC64
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157CCDC Offset: 0x1578CDC VA: 0x157CCDC
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157D114 Offset: 0x1579114 VA: 0x157D114
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157D1B4 Offset: 0x15791B4 VA: 0x157D1B4
	|-DictionaryWrapper.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DictionaryWrapper.<>c<TKey, TValue> // TypeDefIndex: 6060
{
	// Fields
	[Nullable(0)]
	public static readonly DictionaryWrapper.<>c<TKey, TValue> <>9; // 0x0
	[Nullable(0)]
	public static Func<DictionaryEntry, KeyValuePair<TKey, TValue>> <>9__29_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1153170 Offset: 0x114F170 VA: 0x1153170
	|-DictionaryWrapper.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115327C Offset: 0x114F27C VA: 0x115327C
	|-DictionaryWrapper.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal KeyValuePair<TKey, TValue> <GetEnumerator>b__29_0(DictionaryEntry de) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1153284 Offset: 0x114F284 VA: 0x1153284
	|-DictionaryWrapper.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<GetEnumerator>b__29_0
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[DefaultMember("Item")]
internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IWrappedDictionary, IDictionary, ICollection // TypeDefIndex: 6061
{
	// Fields
	[Nullable(2)]
	private readonly IDictionary _dictionary; // 0x0
	[Nullable(new[] { 2, 1, 1 })]
	private readonly IDictionary<TKey, TValue> _genericDictionary; // 0x0
	[Nullable(new[] { 2, 1, 1 })]
	private readonly IReadOnlyDictionary<TKey, TValue> _readOnlyDictionary; // 0x0
	[Nullable(2)]
	private object _syncRoot; // 0x0

	// Properties
	internal IDictionary<TKey, TValue> GenericDictionary { get; }
	public ICollection<TValue> Values { get; }
	public TValue Item { get; set; }
	public int Count { get; }
	public bool IsReadOnly { get; }
	[Nullable(2)]
	private object System.Collections.IDictionary.Item { get; set; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object UnderlyingDictionary { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal IDictionary<TKey, TValue> get_GenericDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157D2C0 Offset: 0x15792C0 VA: 0x157D2C0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_GenericDictionary
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157D2C8 Offset: 0x15792C8 VA: 0x157D2C8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157D5B8 Offset: 0x15795B8 VA: 0x157D5B8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157D8AC Offset: 0x15798AC VA: 0x157D8AC
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157DBF8 Offset: 0x1579BF8 VA: 0x157DBF8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157DFF0 Offset: 0x1579FF0 VA: 0x157DFF0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157E1D8 Offset: 0x157A1D8 VA: 0x157E1D8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157E528 Offset: 0x157A528 VA: 0x157E528
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public void Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157E850 Offset: 0x157A850 VA: 0x157E850
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 26
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157EAC4 Offset: 0x157AAC4 VA: 0x157EAC4
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157EC24 Offset: 0x157AC24 VA: 0x157EC24
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157EEDC Offset: 0x157AEDC VA: 0x157EEDC
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 31
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157F5D4 Offset: 0x157B5D4 VA: 0x157F5D4
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157F758 Offset: 0x157B758 VA: 0x157F758
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public bool Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157F8A0 Offset: 0x157B8A0 VA: 0x157F8A0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 18
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157FCF8 Offset: 0x157BCF8 VA: 0x157FCF8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157FFFC Offset: 0x157BFFC VA: 0x157FFFC
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1580010 Offset: 0x157C010 VA: 0x1580010
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15802FC Offset: 0x157C2FC VA: 0x15802FC
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x158061C Offset: 0x157C61C VA: 0x158061C
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1580908 Offset: 0x157C908 VA: 0x1580908
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1580AE0 Offset: 0x157CAE0 VA: 0x1580AE0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 29
	public void Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1580DB8 Offset: 0x157CDB8 VA: 0x1580DB8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1581030 Offset: 0x157D030 VA: 0x1581030
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15811E0 Offset: 0x157D1E0 VA: 0x15811E0
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15813C4 Offset: 0x157D3C4 VA: 0x15813C4
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1581474 Offset: 0x157D474 VA: 0x1581474
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 20
	public object get_UnderlyingDictionary() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15814E8 Offset: 0x157D4E8 VA: 0x15814E8
	|-DictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_UnderlyingDictionary
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class DynamicProxy<T> // TypeDefIndex: 6062
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public virtual IEnumerable<string> GetDynamicMemberNames(T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8DB8 Offset: 0x11C4DB8 VA: 0x11C8DB8
	|-DynamicProxy<object>.GetDynamicMemberNames
	|
	|-RVA: 0x11C8F74 Offset: 0x11C4F74 VA: 0x11C8F74
	|-DynamicProxy<__Il2CppFullySharedGenericType>.GetDynamicMemberNames
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual bool TryBinaryOperation(T instance, BinaryOperationBinder binder, object arg, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8E4C Offset: 0x11C4E4C VA: 0x11C8E4C
	|-DynamicProxy<object>.TryBinaryOperation
	|
	|-RVA: 0x11C9008 Offset: 0x11C5008 VA: 0x11C9008
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryBinaryOperation
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual bool TryConvert(T instance, ConvertBinder binder, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8E6C Offset: 0x11C4E6C VA: 0x11C8E6C
	|-DynamicProxy<object>.TryConvert
	|
	|-RVA: 0x11C9028 Offset: 0x11C5028 VA: 0x11C9028
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryConvert
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public virtual bool TryCreateInstance(T instance, CreateInstanceBinder binder, object[] args, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8E8C Offset: 0x11C4E8C VA: 0x11C8E8C
	|-DynamicProxy<object>.TryCreateInstance
	|
	|-RVA: 0x11C9048 Offset: 0x11C5048 VA: 0x11C9048
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryCreateInstance
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public virtual bool TryDeleteIndex(T instance, DeleteIndexBinder binder, object[] indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8EAC Offset: 0x11C4EAC VA: 0x11C8EAC
	|-DynamicProxy<object>.TryDeleteIndex
	|
	|-RVA: 0x11C9068 Offset: 0x11C5068 VA: 0x11C9068
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryDeleteIndex
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public virtual bool TryDeleteMember(T instance, DeleteMemberBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8EB4 Offset: 0x11C4EB4 VA: 0x11C8EB4
	|-DynamicProxy<object>.TryDeleteMember
	|
	|-RVA: 0x11C9070 Offset: 0x11C5070 VA: 0x11C9070
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryDeleteMember
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public virtual bool TryGetIndex(T instance, GetIndexBinder binder, object[] indexes, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8EBC Offset: 0x11C4EBC VA: 0x11C8EBC
	|-DynamicProxy<object>.TryGetIndex
	|
	|-RVA: 0x11C9078 Offset: 0x11C5078 VA: 0x11C9078
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryGetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public virtual bool TryGetMember(T instance, GetMemberBinder binder, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8EDC Offset: 0x11C4EDC VA: 0x11C8EDC
	|-DynamicProxy<object>.TryGetMember
	|
	|-RVA: 0x11C9098 Offset: 0x11C5098 VA: 0x11C9098
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryGetMember
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual bool TryInvoke(T instance, InvokeBinder binder, object[] args, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8EFC Offset: 0x11C4EFC VA: 0x11C8EFC
	|-DynamicProxy<object>.TryInvoke
	|
	|-RVA: 0x11C90B8 Offset: 0x11C50B8 VA: 0x11C90B8
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual bool TryInvokeMember(T instance, InvokeMemberBinder binder, object[] args, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8F1C Offset: 0x11C4F1C VA: 0x11C8F1C
	|-DynamicProxy<object>.TryInvokeMember
	|
	|-RVA: 0x11C90D8 Offset: 0x11C50D8 VA: 0x11C90D8
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryInvokeMember
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual bool TrySetIndex(T instance, SetIndexBinder binder, object[] indexes, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8F3C Offset: 0x11C4F3C VA: 0x11C8F3C
	|-DynamicProxy<object>.TrySetIndex
	|
	|-RVA: 0x11C90F8 Offset: 0x11C50F8 VA: 0x11C90F8
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TrySetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public virtual bool TrySetMember(T instance, SetMemberBinder binder, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8F44 Offset: 0x11C4F44 VA: 0x11C8F44
	|-DynamicProxy<object>.TrySetMember
	|
	|-RVA: 0x11C9100 Offset: 0x11C5100 VA: 0x11C9100
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TrySetMember
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public virtual bool TryUnaryOperation(T instance, UnaryOperationBinder binder, out object result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8F4C Offset: 0x11C4F4C VA: 0x11C8F4C
	|-DynamicProxy<object>.TryUnaryOperation
	|
	|-RVA: 0x11C9108 Offset: 0x11C5108 VA: 0x11C9108
	|-DynamicProxy<__Il2CppFullySharedGenericType>.TryUnaryOperation
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C8F6C Offset: 0x11C4F6C VA: 0x11C8F6C
	|-DynamicProxy<object>..ctor
	|
	|-RVA: 0x11C9128 Offset: 0x11C5128 VA: 0x11C9128
	|-DynamicProxy<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[NullableContext(0)]
private sealed class DynamicProxyMetaObject.Fallback<T> : MulticastDelegate // TypeDefIndex: 6063
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1256220 Offset: 0x1252220 VA: 0x1256220
	|-DynamicProxyMetaObject.Fallback<object>..ctor
	|
	|-RVA: 0x125633C Offset: 0x125233C VA: 0x125633C
	|-DynamicProxyMetaObject.Fallback<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 12
	public virtual DynamicMetaObject Invoke(DynamicMetaObject errorSuggestion) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1256328 Offset: 0x1252328 VA: 0x1256328
	|-DynamicProxyMetaObject.Fallback<object>.Invoke
	|
	|-RVA: 0x1256444 Offset: 0x1252444 VA: 0x1256444
	|-DynamicProxyMetaObject.Fallback<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
[Nullable(0)]
private sealed class DynamicProxyMetaObject.GetBinderAdapter<T> : GetMemberBinder // TypeDefIndex: 6064
{
	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(InvokeMemberBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270204 Offset: 0x126C204 VA: 0x1270204
	|-DynamicProxyMetaObject.GetBinderAdapter<object>..ctor
	|
	|-RVA: 0x1270258 Offset: 0x126C258 VA: 0x1270258
	|-DynamicProxyMetaObject.GetBinderAdapter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270224 Offset: 0x126C224 VA: 0x1270224
	|-DynamicProxyMetaObject.GetBinderAdapter<object>.FallbackGetMember
	|
	|-RVA: 0x1270278 Offset: 0x126C278 VA: 0x1270278
	|-DynamicProxyMetaObject.GetBinderAdapter<__Il2CppFullySharedGenericType>.FallbackGetMember
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DynamicProxyMetaObject.<>c<T> // TypeDefIndex: 6065
{
	// Fields
	[Nullable(0)]
	public static readonly DynamicProxyMetaObject.<>c<T> <>9; // 0x0
	[Nullable(0)]
	public static Func<DynamicMetaObject, Expression> <>9__18_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150B28 Offset: 0x114CB28 VA: 0x1150B28
	|-DynamicProxyMetaObject.<>c<object>..cctor
	|
	|-RVA: 0x11512B4 Offset: 0x114D2B4 VA: 0x11512B4
	|-DynamicProxyMetaObject.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150C00 Offset: 0x114CC00 VA: 0x1150C00
	|-DynamicProxyMetaObject.<>c<object>..ctor
	|
	|-RVA: 0x11513C0 Offset: 0x114D3C0 VA: 0x11513C0
	|-DynamicProxyMetaObject.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal Expression <GetArgs>b__18_0(DynamicMetaObject arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150C08 Offset: 0x114CC08 VA: 0x1150C08
	|-DynamicProxyMetaObject.<>c<object>.<GetArgs>b__18_0
	|
	|-RVA: 0x11513C8 Offset: 0x114D3C8 VA: 0x11513C8
	|-DynamicProxyMetaObject.<>c<__Il2CppFullySharedGenericType>.<GetArgs>b__18_0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass10_0<T> // TypeDefIndex: 6066
{
	// Fields
	[Nullable(0)]
	public BinaryOperationBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(0)]
	public DynamicMetaObject arg; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1156628 Offset: 0x1152628 VA: 0x1156628
	|-DynamicProxyMetaObject.<>c__DisplayClass10_0<object>..ctor
	|
	|-RVA: 0x1156658 Offset: 0x1152658 VA: 0x1156658
	|-DynamicProxyMetaObject.<>c__DisplayClass10_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindBinaryOperation>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1156630 Offset: 0x1152630 VA: 0x1156630
	|-DynamicProxyMetaObject.<>c__DisplayClass10_0<object>.<BindBinaryOperation>b__0
	|
	|-RVA: 0x1156660 Offset: 0x1152660 VA: 0x1156660
	|-DynamicProxyMetaObject.<>c__DisplayClass10_0<__Il2CppFullySharedGenericType>.<BindBinaryOperation>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass11_0<T> // TypeDefIndex: 6067
{
	// Fields
	[Nullable(0)]
	public UnaryOperationBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1156688 Offset: 0x1152688 VA: 0x1156688
	|-DynamicProxyMetaObject.<>c__DisplayClass11_0<object>..ctor
	|
	|-RVA: 0x11566B8 Offset: 0x11526B8 VA: 0x11566B8
	|-DynamicProxyMetaObject.<>c__DisplayClass11_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindUnaryOperation>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1156690 Offset: 0x1152690 VA: 0x1156690
	|-DynamicProxyMetaObject.<>c__DisplayClass11_0<object>.<BindUnaryOperation>b__0
	|
	|-RVA: 0x11566C0 Offset: 0x11526C0 VA: 0x11566C0
	|-DynamicProxyMetaObject.<>c__DisplayClass11_0<__Il2CppFullySharedGenericType>.<BindUnaryOperation>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass12_0<T> // TypeDefIndex: 6068
{
	// Fields
	[Nullable(0)]
	public GetIndexBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(new[] { 0, 1 })]
	public DynamicMetaObject[] indexes; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11566E8 Offset: 0x11526E8 VA: 0x11566E8
	|-DynamicProxyMetaObject.<>c__DisplayClass12_0<object>..ctor
	|
	|-RVA: 0x1156718 Offset: 0x1152718 VA: 0x1156718
	|-DynamicProxyMetaObject.<>c__DisplayClass12_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindGetIndex>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11566F0 Offset: 0x11526F0 VA: 0x11566F0
	|-DynamicProxyMetaObject.<>c__DisplayClass12_0<object>.<BindGetIndex>b__0
	|
	|-RVA: 0x1156720 Offset: 0x1152720 VA: 0x1156720
	|-DynamicProxyMetaObject.<>c__DisplayClass12_0<__Il2CppFullySharedGenericType>.<BindGetIndex>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass13_0<T> // TypeDefIndex: 6069
{
	// Fields
	[Nullable(0)]
	public SetIndexBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(new[] { 0, 1 })]
	public DynamicMetaObject[] indexes; // 0x0
	[Nullable(0)]
	public DynamicMetaObject value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1156748 Offset: 0x1152748 VA: 0x1156748
	|-DynamicProxyMetaObject.<>c__DisplayClass13_0<object>..ctor
	|
	|-RVA: 0x115677C Offset: 0x115277C VA: 0x115677C
	|-DynamicProxyMetaObject.<>c__DisplayClass13_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindSetIndex>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1156750 Offset: 0x1152750 VA: 0x1156750
	|-DynamicProxyMetaObject.<>c__DisplayClass13_0<object>.<BindSetIndex>b__0
	|
	|-RVA: 0x1156784 Offset: 0x1152784 VA: 0x1156784
	|-DynamicProxyMetaObject.<>c__DisplayClass13_0<__Il2CppFullySharedGenericType>.<BindSetIndex>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass14_0<T> // TypeDefIndex: 6070
{
	// Fields
	[Nullable(0)]
	public DeleteIndexBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(new[] { 0, 1 })]
	public DynamicMetaObject[] indexes; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11567B0 Offset: 0x11527B0 VA: 0x11567B0
	|-DynamicProxyMetaObject.<>c__DisplayClass14_0<object>..ctor
	|
	|-RVA: 0x11567E0 Offset: 0x11527E0 VA: 0x11567E0
	|-DynamicProxyMetaObject.<>c__DisplayClass14_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindDeleteIndex>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11567B8 Offset: 0x11527B8 VA: 0x11567B8
	|-DynamicProxyMetaObject.<>c__DisplayClass14_0<object>.<BindDeleteIndex>b__0
	|
	|-RVA: 0x11567E8 Offset: 0x11527E8 VA: 0x11567E8
	|-DynamicProxyMetaObject.<>c__DisplayClass14_0<__Il2CppFullySharedGenericType>.<BindDeleteIndex>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass3_0<T> // TypeDefIndex: 6071
{
	// Fields
	[Nullable(0)]
	public GetMemberBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11594AC Offset: 0x11554AC VA: 0x11594AC
	|-DynamicProxyMetaObject.<>c__DisplayClass3_0<object>..ctor
	|
	|-RVA: 0x11594DC Offset: 0x11554DC VA: 0x11594DC
	|-DynamicProxyMetaObject.<>c__DisplayClass3_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindGetMember>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11594B4 Offset: 0x11554B4 VA: 0x11594B4
	|-DynamicProxyMetaObject.<>c__DisplayClass3_0<object>.<BindGetMember>b__0
	|
	|-RVA: 0x11594E4 Offset: 0x11554E4 VA: 0x11594E4
	|-DynamicProxyMetaObject.<>c__DisplayClass3_0<__Il2CppFullySharedGenericType>.<BindGetMember>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass4_0<T> // TypeDefIndex: 6072
{
	// Fields
	[Nullable(0)]
	public SetMemberBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(0)]
	public DynamicMetaObject value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115A944 Offset: 0x1156944 VA: 0x115A944
	|-DynamicProxyMetaObject.<>c__DisplayClass4_0<object>..ctor
	|
	|-RVA: 0x115A974 Offset: 0x1156974 VA: 0x115A974
	|-DynamicProxyMetaObject.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindSetMember>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115A94C Offset: 0x115694C VA: 0x115A94C
	|-DynamicProxyMetaObject.<>c__DisplayClass4_0<object>.<BindSetMember>b__0
	|
	|-RVA: 0x115A97C Offset: 0x115697C VA: 0x115A97C
	|-DynamicProxyMetaObject.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType>.<BindSetMember>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass5_0<T> // TypeDefIndex: 6073
{
	// Fields
	[Nullable(0)]
	public DeleteMemberBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115B6D4 Offset: 0x11576D4 VA: 0x115B6D4
	|-DynamicProxyMetaObject.<>c__DisplayClass5_0<object>..ctor
	|
	|-RVA: 0x115B704 Offset: 0x1157704 VA: 0x115B704
	|-DynamicProxyMetaObject.<>c__DisplayClass5_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindDeleteMember>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115B6DC Offset: 0x11576DC VA: 0x115B6DC
	|-DynamicProxyMetaObject.<>c__DisplayClass5_0<object>.<BindDeleteMember>b__0
	|
	|-RVA: 0x115B70C Offset: 0x115770C VA: 0x115B70C
	|-DynamicProxyMetaObject.<>c__DisplayClass5_0<__Il2CppFullySharedGenericType>.<BindDeleteMember>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass6_0<T> // TypeDefIndex: 6074
{
	// Fields
	[Nullable(0)]
	public ConvertBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115B9E4 Offset: 0x11579E4 VA: 0x115B9E4
	|-DynamicProxyMetaObject.<>c__DisplayClass6_0<object>..ctor
	|
	|-RVA: 0x115BA14 Offset: 0x1157A14 VA: 0x115BA14
	|-DynamicProxyMetaObject.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindConvert>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115B9EC Offset: 0x11579EC VA: 0x115B9EC
	|-DynamicProxyMetaObject.<>c__DisplayClass6_0<object>.<BindConvert>b__0
	|
	|-RVA: 0x115BA1C Offset: 0x1157A1C VA: 0x115BA1C
	|-DynamicProxyMetaObject.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>.<BindConvert>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass7_0<T> // TypeDefIndex: 6075
{
	// Fields
	[Nullable(0)]
	public InvokeMemberBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(new[] { 0, 1 })]
	public DynamicMetaObject[] args; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115BF0C Offset: 0x1157F0C VA: 0x115BF0C
	|-DynamicProxyMetaObject.<>c__DisplayClass7_0<object>..ctor
	|
	|-RVA: 0x115BF64 Offset: 0x1157F64 VA: 0x115BF64
	|-DynamicProxyMetaObject.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindInvokeMember>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115BF14 Offset: 0x1157F14 VA: 0x115BF14
	|-DynamicProxyMetaObject.<>c__DisplayClass7_0<object>.<BindInvokeMember>b__0
	|
	|-RVA: 0x115BF6C Offset: 0x1157F6C VA: 0x115BF6C
	|-DynamicProxyMetaObject.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType>.<BindInvokeMember>b__0
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindInvokeMember>b__1(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115BF3C Offset: 0x1157F3C VA: 0x115BF3C
	|-DynamicProxyMetaObject.<>c__DisplayClass7_0<object>.<BindInvokeMember>b__1
	|
	|-RVA: 0x115BF94 Offset: 0x1157F94 VA: 0x115BF94
	|-DynamicProxyMetaObject.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType>.<BindInvokeMember>b__1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass8_0<T> // TypeDefIndex: 6076
{
	// Fields
	[Nullable(0)]
	public CreateInstanceBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(new[] { 0, 1 })]
	public DynamicMetaObject[] args; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115C62C Offset: 0x115862C VA: 0x115C62C
	|-DynamicProxyMetaObject.<>c__DisplayClass8_0<object>..ctor
	|
	|-RVA: 0x115C65C Offset: 0x115865C VA: 0x115C65C
	|-DynamicProxyMetaObject.<>c__DisplayClass8_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindCreateInstance>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115C634 Offset: 0x1158634 VA: 0x115C634
	|-DynamicProxyMetaObject.<>c__DisplayClass8_0<object>.<BindCreateInstance>b__0
	|
	|-RVA: 0x115C664 Offset: 0x1158664 VA: 0x115C664
	|-DynamicProxyMetaObject.<>c__DisplayClass8_0<__Il2CppFullySharedGenericType>.<BindCreateInstance>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class DynamicProxyMetaObject.<>c__DisplayClass9_0<T> // TypeDefIndex: 6077
{
	// Fields
	[Nullable(0)]
	public InvokeBinder binder; // 0x0
	[Nullable(0)]
	public DynamicProxyMetaObject<T> <>4__this; // 0x0
	[Nullable(new[] { 0, 1 })]
	public DynamicMetaObject[] args; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115CCC8 Offset: 0x1158CC8 VA: 0x115CCC8
	|-DynamicProxyMetaObject.<>c__DisplayClass9_0<object>..ctor
	|
	|-RVA: 0x115CCF8 Offset: 0x1158CF8 VA: 0x115CCF8
	|-DynamicProxyMetaObject.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal DynamicMetaObject <BindInvoke>b__0(DynamicMetaObject e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115CCD0 Offset: 0x1158CD0 VA: 0x115CCD0
	|-DynamicProxyMetaObject.<>c__DisplayClass9_0<object>.<BindInvoke>b__0
	|
	|-RVA: 0x115CD00 Offset: 0x1158D00 VA: 0x115CD00
	|-DynamicProxyMetaObject.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>.<BindInvoke>b__0
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal sealed class DynamicProxyMetaObject<T> : DynamicMetaObject // TypeDefIndex: 6078
{
	// Fields
	private readonly DynamicProxy<T> _proxy; // 0x0

	// Properties
	private static Expression[] NoArgs { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Expression expression, T value, DynamicProxy<T> proxy) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C3088 Offset: 0x11BF088 VA: 0x11C3088
	|-DynamicProxyMetaObject<object>..ctor
	|
	|-RVA: 0x11C5D7C Offset: 0x11C1D7C VA: 0x11C5D7C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private bool IsOverridden(string method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C314C Offset: 0x11BF14C VA: 0x11C314C
	|-DynamicProxyMetaObject<object>.IsOverridden
	|
	|-RVA: 0x11C5EE4 Offset: 0x11C1EE4 VA: 0x11C5EE4
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.IsOverridden
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override DynamicMetaObject BindGetMember(GetMemberBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C3210 Offset: 0x11BF210 VA: 0x11C3210
	|-DynamicProxyMetaObject<object>.BindGetMember
	|
	|-RVA: 0x11C5FA8 Offset: 0x11C1FA8 VA: 0x11C5FA8
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindGetMember
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override DynamicMetaObject BindSetMember(SetMemberBinder binder, DynamicMetaObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C3380 Offset: 0x11BF380 VA: 0x11C3380
	|-DynamicProxyMetaObject<object>.BindSetMember
	|
	|-RVA: 0x11C6138 Offset: 0x11C2138 VA: 0x11C6138
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindSetMember
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override DynamicMetaObject BindDeleteMember(DeleteMemberBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C3584 Offset: 0x11BF584 VA: 0x11C3584
	|-DynamicProxyMetaObject<object>.BindDeleteMember
	|
	|-RVA: 0x11C6350 Offset: 0x11C2350 VA: 0x11C6350
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindDeleteMember
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override DynamicMetaObject BindConvert(ConvertBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C36F0 Offset: 0x11BF6F0 VA: 0x11C36F0
	|-DynamicProxyMetaObject<object>.BindConvert
	|
	|-RVA: 0x11C64DC Offset: 0x11C24DC VA: 0x11C64DC
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindConvert
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public override DynamicMetaObject BindInvokeMember(InvokeMemberBinder binder, DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C3860 Offset: 0x11BF860 VA: 0x11C3860
	|-DynamicProxyMetaObject<object>.BindInvokeMember
	|
	|-RVA: 0x11C666C Offset: 0x11C266C VA: 0x11C666C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindInvokeMember
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override DynamicMetaObject BindCreateInstance(CreateInstanceBinder binder, DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C3AF8 Offset: 0x11BFAF8 VA: 0x11C3AF8
	|-DynamicProxyMetaObject<object>.BindCreateInstance
	|
	|-RVA: 0x11C693C Offset: 0x11C293C VA: 0x11C693C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindCreateInstance
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public override DynamicMetaObject BindInvoke(InvokeBinder binder, DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C3C94 Offset: 0x11BFC94 VA: 0x11C3C94
	|-DynamicProxyMetaObject<object>.BindInvoke
	|
	|-RVA: 0x11C6AEC Offset: 0x11C2AEC VA: 0x11C6AEC
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public override DynamicMetaObject BindBinaryOperation(BinaryOperationBinder binder, DynamicMetaObject arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C3E30 Offset: 0x11BFE30 VA: 0x11C3E30
	|-DynamicProxyMetaObject<object>.BindBinaryOperation
	|
	|-RVA: 0x11C6C9C Offset: 0x11C2C9C VA: 0x11C6C9C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindBinaryOperation
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public override DynamicMetaObject BindUnaryOperation(UnaryOperationBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C4038 Offset: 0x11C0038 VA: 0x11C4038
	|-DynamicProxyMetaObject<object>.BindUnaryOperation
	|
	|-RVA: 0x11C6EB8 Offset: 0x11C2EB8 VA: 0x11C6EB8
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindUnaryOperation
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override DynamicMetaObject BindGetIndex(GetIndexBinder binder, DynamicMetaObject[] indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C41A8 Offset: 0x11C01A8 VA: 0x11C41A8
	|-DynamicProxyMetaObject<object>.BindGetIndex
	|
	|-RVA: 0x11C7048 Offset: 0x11C3048 VA: 0x11C7048
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindGetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override DynamicMetaObject BindSetIndex(SetIndexBinder binder, DynamicMetaObject[] indexes, DynamicMetaObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C4344 Offset: 0x11C0344 VA: 0x11C4344
	|-DynamicProxyMetaObject<object>.BindSetIndex
	|
	|-RVA: 0x11C71F8 Offset: 0x11C31F8 VA: 0x11C71F8
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindSetIndex
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override DynamicMetaObject BindDeleteIndex(DeleteIndexBinder binder, DynamicMetaObject[] indexes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C4508 Offset: 0x11C0508 VA: 0x11C4508
	|-DynamicProxyMetaObject<object>.BindDeleteIndex
	|
	|-RVA: 0x11C73D0 Offset: 0x11C33D0 VA: 0x11C73D0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BindDeleteIndex
	*/

	// RVA: -1 Offset: -1
	private static Expression[] get_NoArgs() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C46A0 Offset: 0x11C06A0 VA: 0x11C46A0
	|-DynamicProxyMetaObject<object>.get_NoArgs
	|
	|-RVA: 0x11C757C Offset: 0x11C357C VA: 0x11C757C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.get_NoArgs
	*/

	// RVA: -1 Offset: -1
	private static IEnumerable<Expression> GetArgs(DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C4734 Offset: 0x11C0734 VA: 0x11C4734
	|-DynamicProxyMetaObject<object>.GetArgs
	|
	|-RVA: 0x11C7610 Offset: 0x11C3610 VA: 0x11C7610
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetArgs
	*/

	// RVA: -1 Offset: -1
	private static Expression[] GetArgArray(DynamicMetaObject[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C492C Offset: 0x11C092C VA: 0x11C492C
	|-DynamicProxyMetaObject<object>.GetArgArray
	|
	|-RVA: 0x11C7808 Offset: 0x11C3808 VA: 0x11C7808
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetArgArray
	*/

	// RVA: -1 Offset: -1
	private static Expression[] GetArgArray(DynamicMetaObject[] args, DynamicMetaObject value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C4A70 Offset: 0x11C0A70 VA: 0x11C4A70
	|-DynamicProxyMetaObject<object>.GetArgArray
	|
	|-RVA: 0x11C7978 Offset: 0x11C3978 VA: 0x11C7978
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetArgArray
	*/

	// RVA: -1 Offset: -1
	private static ConstantExpression Constant(DynamicMetaObjectBinder binder) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C4C68 Offset: 0x11C0C68 VA: 0x11C4C68
	|-DynamicProxyMetaObject<object>.Constant
	|
	|-RVA: 0x11C7B9C Offset: 0x11C3B9C VA: 0x11C7B9C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.Constant
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicProxyMetaObject.Fallback<T> fallback, DynamicProxyMetaObject.Fallback<T> fallbackInvoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C4CF8 Offset: 0x11C0CF8 VA: 0x11C4CF8
	|-DynamicProxyMetaObject<object>.CallMethodWithResult
	|
	|-RVA: 0x11C7C2C Offset: 0x11C3C2C VA: 0x11C7C2C
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.CallMethodWithResult
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject BuildCallMethodWithResult(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicMetaObject fallbackResult, DynamicProxyMetaObject.Fallback<T> fallbackInvoke) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C4D74 Offset: 0x11C0D74 VA: 0x11C4D74
	|-DynamicProxyMetaObject<object>.BuildCallMethodWithResult
	|
	|-RVA: 0x11C7CB4 Offset: 0x11C3CB4 VA: 0x11C7CB4
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.BuildCallMethodWithResult
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodReturnLast(string methodName, DynamicMetaObjectBinder binder, IEnumerable<Expression> args, DynamicProxyMetaObject.Fallback<T> fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C5348 Offset: 0x11C1348 VA: 0x11C5348
	|-DynamicProxyMetaObject<object>.CallMethodReturnLast
	|
	|-RVA: 0x11C82B0 Offset: 0x11C42B0 VA: 0x11C82B0
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.CallMethodReturnLast
	*/

	// RVA: -1 Offset: -1
	private DynamicMetaObject CallMethodNoResult(string methodName, DynamicMetaObjectBinder binder, Expression[] args, DynamicProxyMetaObject.Fallback<T> fallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C5908 Offset: 0x11C1908 VA: 0x11C5908
	|-DynamicProxyMetaObject<object>.CallMethodNoResult
	|
	|-RVA: 0x11C8898 Offset: 0x11C4898 VA: 0x11C8898
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.CallMethodNoResult
	*/

	// RVA: -1 Offset: -1
	private BindingRestrictions GetRestrictions() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C5C2C Offset: 0x11C1C2C VA: 0x11C5C2C
	|-DynamicProxyMetaObject<object>.GetRestrictions
	|
	|-RVA: 0x11C8BE4 Offset: 0x11C4BE4 VA: 0x11C8BE4
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetRestrictions
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public override IEnumerable<string> GetDynamicMemberNames() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C5CF4 Offset: 0x11C1CF4 VA: 0x11C5CF4
	|-DynamicProxyMetaObject<object>.GetDynamicMemberNames
	|
	|-RVA: 0x11C8CAC Offset: 0x11C4CAC VA: 0x11C8CAC
	|-DynamicProxyMetaObject<__Il2CppFullySharedGenericType>.GetDynamicMemberNames
	*/
}

// Namespace: 
[Nullable(0)]
internal static class DynamicUtils.BinderWrapper // TypeDefIndex: 6079
{
	// Fields
	[Nullable(2)]
	private static object _getCSharpArgumentInfoArray; // 0x0
	[Nullable(2)]
	private static object _setCSharpArgumentInfoArray; // 0x8
	[Nullable(2)]
	private static MethodCall<object, object> _getMemberCall; // 0x10
	[Nullable(2)]
	private static MethodCall<object, object> _setMemberCall; // 0x18
	private static bool _init; // 0x20

	// Methods

	// RVA: 0x1940880 Offset: 0x193C880 VA: 0x1940880
	private static void Init() { }

	// RVA: 0x1940A64 Offset: 0x193CA64 VA: 0x1940A64
	private static object CreateSharpArgumentInfoArray(int[] values) { }

	// RVA: 0x1940D24 Offset: 0x193CD24 VA: 0x1940D24
	private static void CreateMemberCalls() { }

	// RVA: 0x194124C Offset: 0x193D24C VA: 0x194124C
	public static CallSiteBinder GetMember(string name, Type context) { }

	// RVA: 0x1941444 Offset: 0x193D444 VA: 0x1941444
	public static CallSiteBinder SetMember(string name, Type context) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class DynamicUtils // TypeDefIndex: 6080
{
	// Methods

	[Extension]
	// RVA: 0x1940798 Offset: 0x193C798 VA: 0x1940798
	public static IEnumerable<string> GetDynamicMemberNames(IDynamicMetaObjectProvider dynamicProvider) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class NoThrowGetBinderMember : GetMemberBinder // TypeDefIndex: 6081
{
	// Fields
	private readonly GetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0x194163C Offset: 0x193D63C VA: 0x194163C
	public void .ctor(GetMemberBinder innerBinder) { }

	// RVA: 0x194167C Offset: 0x193D67C VA: 0x194167C Slot: 9
	public override DynamicMetaObject FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class NoThrowSetBinderMember : SetMemberBinder // TypeDefIndex: 6082
{
	// Fields
	private readonly SetMemberBinder _innerBinder; // 0x28

	// Methods

	// RVA: 0x19417D4 Offset: 0x193D7D4 VA: 0x19417D4
	public void .ctor(SetMemberBinder innerBinder) { }

	// RVA: 0x1941814 Offset: 0x193D814 VA: 0x1941814 Slot: 9
	public override DynamicMetaObject FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class NoThrowExpressionVisitor : ExpressionVisitor // TypeDefIndex: 6083
{
	// Fields
	internal static readonly object ErrorResult; // 0x0

	// Methods

	// RVA: 0x1941968 Offset: 0x193D968 VA: 0x1941968 Slot: 7
	protected override Expression VisitConditional(ConditionalExpression node) { }

	// RVA: 0x19417CC Offset: 0x193D7CC VA: 0x19417CC
	public void .ctor() { }

	// RVA: 0x1941A54 Offset: 0x193DA54 VA: 0x1941A54
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class EnumInfo // TypeDefIndex: 6084
{
	// Fields
	public readonly bool IsFlags; // 0x10
	public readonly ulong[] Values; // 0x18
	public readonly string[] Names; // 0x20
	public readonly string[] ResolvedNames; // 0x28

	// Methods

	// RVA: 0x1941AD0 Offset: 0x193DAD0 VA: 0x1941AD0
	public void .ctor(bool isFlags, ulong[] values, string[] names, string[] resolvedNames) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EnumUtils.<>c // TypeDefIndex: 6085
{
	// Fields
	[Nullable(0)]
	public static readonly EnumUtils.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<EnumMemberAttribute, string> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x1943180 Offset: 0x193F180 VA: 0x1943180
	private static void .cctor() { }

	// RVA: 0x19431E8 Offset: 0x193F1E8 VA: 0x19431E8
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x19431F0 Offset: 0x193F1F0 VA: 0x19431F0
	internal string <InitializeValuesAndNames>b__3_0(EnumMemberAttribute a) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class EnumUtils // TypeDefIndex: 6086
{
	// Fields
	[Nullable(new[] { 1, 0, 1, 2, 1 })]
	private static readonly ThreadSafeStore<StructMultiKey<Type, NamingStrategy>, EnumInfo> ValuesAndNamesPerEnum; // 0x0
	private static CamelCaseNamingStrategy _camelCaseNamingStrategy; // 0x8

	// Methods

	// RVA: 0x1941B38 Offset: 0x193DB38 VA: 0x1941B38
	private static EnumInfo InitializeValuesAndNames(StructMultiKey<Type, NamingStrategy> key) { }

	// RVA: 0x194230C Offset: 0x193E30C VA: 0x194230C
	public static bool TryToString(Type enumType, object value, NamingStrategy namingStrategy, out string name) { }

	// RVA: 0x19424AC Offset: 0x193E4AC VA: 0x19424AC
	private static string InternalFlagsFormat(EnumInfo entry, ulong result) { }

	// RVA: 0x1942650 Offset: 0x193E650 VA: 0x1942650
	public static EnumInfo GetEnumValuesAndNames(Type enumType) { }

	// RVA: 0x194200C Offset: 0x193E00C VA: 0x194200C
	private static ulong ToUInt64(object value) { }

	// RVA: 0x194270C Offset: 0x193E70C VA: 0x194270C
	public static object ParseEnum(Type enumType, NamingStrategy namingStrategy, string value, bool disallowNumber) { }

	// RVA: 0x1942F70 Offset: 0x193EF70 VA: 0x1942F70
	private static Nullable<int> MatchName(string value, string[] enumNames, string[] resolvedNames, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0x1942E80 Offset: 0x193EE80 VA: 0x1942E80
	private static Nullable<int> FindIndexByName(string[] enumNames, string value, int valueIndex, int valueSubstringLength, StringComparison comparison) { }

	// RVA: 0x1943054 Offset: 0x193F054 VA: 0x1943054
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(2)]
[Nullable(0)]
internal class FSharpFunction // TypeDefIndex: 6087
{
	// Fields
	private readonly object _instance; // 0x10
	[Nullable(new[] { 1, 2, 1 })]
	private readonly MethodCall<object, object> _invoker; // 0x18

	// Methods

	// RVA: 0x1943204 Offset: 0x193F204 VA: 0x1943204
	public void .ctor(object instance, MethodCall<object, object> invoker) { }

	[NullableContext(1)]
	// RVA: 0x1943248 Offset: 0x193F248 VA: 0x1943248
	public object Invoke(object[] args) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FSharpUtils.<>c__55<TKey, TValue> // TypeDefIndex: 6088
{
	// Fields
	[Nullable(0)]
	public static readonly FSharpUtils.<>c__55<TKey, TValue> <>9; // 0x0
	[Nullable(0)]
	public static Func<KeyValuePair<TKey, TValue>, Tuple<TKey, TValue>> <>9__55_1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1154878 Offset: 0x1150878 VA: 0x1154878
	|-FSharpUtils.<>c__55<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1154984 Offset: 0x1150984 VA: 0x1154984
	|-FSharpUtils.<>c__55<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal Tuple<TKey, TValue> <BuildMapCreator>b__55_1(KeyValuePair<TKey, TValue> kv) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115498C Offset: 0x115098C VA: 0x115498C
	|-FSharpUtils.<>c__55<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<BuildMapCreator>b__55_1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class FSharpUtils.<>c__DisplayClass52_0 // TypeDefIndex: 6089
{
	// Fields
	[Nullable(new[] { 0, 2, 2 })]
	public MethodCall<object, object> call; // 0x10
	[Nullable(new[] { 0, 2, 1 })]
	public MethodCall<object, object> invoke; // 0x18

	// Methods

	// RVA: 0x1943CA0 Offset: 0x193FCA0 VA: 0x1943CA0
	public void .ctor() { }

	// RVA: 0x1943FD8 Offset: 0x193FFD8 VA: 0x1943FD8
	internal object <CreateFSharpFuncCall>b__0(object target, object[] args) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FSharpUtils.<>c__DisplayClass55_0<TKey, TValue> // TypeDefIndex: 6090
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	public ObjectConstructor<object> ctorDelegate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115B41C Offset: 0x115741C VA: 0x115B41C
	|-FSharpUtils.<>c__DisplayClass55_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <BuildMapCreator>b__0(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115B424 Offset: 0x1157424 VA: 0x115B424
	|-FSharpUtils.<>c__DisplayClass55_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<BuildMapCreator>b__0
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class FSharpUtils // TypeDefIndex: 6091
{
	// Fields
	private static readonly object Lock; // 0x0
	[Nullable(2)]
	private static FSharpUtils _instance; // 0x8
	private MethodInfo _ofSeq; // 0x10
	private Type _mapType; // 0x18
	[CompilerGenerated]
	private Assembly <FSharpCoreAssembly>k__BackingField; // 0x20
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <IsUnion>k__BackingField; // 0x28
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <GetUnionCases>k__BackingField; // 0x30
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <PreComputeUnionTagReader>k__BackingField; // 0x38
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <PreComputeUnionReader>k__BackingField; // 0x40
	[Nullable(new[] { 1, 2, 1 })]
	[CompilerGenerated]
	private MethodCall<object, object> <PreComputeUnionConstructor>k__BackingField; // 0x48
	[CompilerGenerated]
	private Func<object, object> <GetUnionCaseInfoDeclaringType>k__BackingField; // 0x50
	[CompilerGenerated]
	private Func<object, object> <GetUnionCaseInfoName>k__BackingField; // 0x58
	[CompilerGenerated]
	private Func<object, object> <GetUnionCaseInfoTag>k__BackingField; // 0x60
	[Nullable(new[] { 1, 1, 2 })]
	[CompilerGenerated]
	private MethodCall<object, object> <GetUnionCaseInfoFields>k__BackingField; // 0x68

	// Properties
	public static FSharpUtils Instance { get; }
	private Assembly FSharpCoreAssembly { set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> IsUnion { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> GetUnionCases { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> PreComputeUnionTagReader { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> PreComputeUnionReader { get; set; }
	[Nullable(new[] { 1, 2, 1 })]
	public MethodCall<object, object> PreComputeUnionConstructor { get; set; }
	public Func<object, object> GetUnionCaseInfoDeclaringType { get; set; }
	public Func<object, object> GetUnionCaseInfoName { get; set; }
	public Func<object, object> GetUnionCaseInfoTag { get; set; }
	[Nullable(new[] { 1, 1, 2 })]
	public MethodCall<object, object> GetUnionCaseInfoFields { get; set; }

	// Methods

	// RVA: 0x1943274 Offset: 0x193F274 VA: 0x1943274
	private void .ctor(Assembly fsharpCoreAssembly) { }

	// RVA: 0x1943A40 Offset: 0x193FA40 VA: 0x1943A40
	public static FSharpUtils get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x1943A98 Offset: 0x193FA98 VA: 0x1943A98
	private void set_FSharpCoreAssembly(Assembly value) { }

	[CompilerGenerated]
	// RVA: 0x1943AA0 Offset: 0x193FAA0 VA: 0x1943AA0
	public MethodCall<object, object> get_IsUnion() { }

	[CompilerGenerated]
	// RVA: 0x1943AA8 Offset: 0x193FAA8 VA: 0x1943AA8
	private void set_IsUnion(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x1943AB0 Offset: 0x193FAB0 VA: 0x1943AB0
	public MethodCall<object, object> get_GetUnionCases() { }

	[CompilerGenerated]
	// RVA: 0x1943AB8 Offset: 0x193FAB8 VA: 0x1943AB8
	private void set_GetUnionCases(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x1943AC0 Offset: 0x193FAC0 VA: 0x1943AC0
	public MethodCall<object, object> get_PreComputeUnionTagReader() { }

	[CompilerGenerated]
	// RVA: 0x1943AC8 Offset: 0x193FAC8 VA: 0x1943AC8
	private void set_PreComputeUnionTagReader(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x1943AD0 Offset: 0x193FAD0 VA: 0x1943AD0
	public MethodCall<object, object> get_PreComputeUnionReader() { }

	[CompilerGenerated]
	// RVA: 0x1943AD8 Offset: 0x193FAD8 VA: 0x1943AD8
	private void set_PreComputeUnionReader(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x1943AE0 Offset: 0x193FAE0 VA: 0x1943AE0
	public MethodCall<object, object> get_PreComputeUnionConstructor() { }

	[CompilerGenerated]
	// RVA: 0x1943AE8 Offset: 0x193FAE8 VA: 0x1943AE8
	private void set_PreComputeUnionConstructor(MethodCall<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x1943AF0 Offset: 0x193FAF0 VA: 0x1943AF0
	public Func<object, object> get_GetUnionCaseInfoDeclaringType() { }

	[CompilerGenerated]
	// RVA: 0x1943AF8 Offset: 0x193FAF8 VA: 0x1943AF8
	private void set_GetUnionCaseInfoDeclaringType(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x1943B00 Offset: 0x193FB00 VA: 0x1943B00
	public Func<object, object> get_GetUnionCaseInfoName() { }

	[CompilerGenerated]
	// RVA: 0x1943B08 Offset: 0x193FB08 VA: 0x1943B08
	private void set_GetUnionCaseInfoName(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x1943B10 Offset: 0x193FB10 VA: 0x1943B10
	public Func<object, object> get_GetUnionCaseInfoTag() { }

	[CompilerGenerated]
	// RVA: 0x1943B18 Offset: 0x193FB18 VA: 0x1943B18
	private void set_GetUnionCaseInfoTag(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x1943B20 Offset: 0x193FB20 VA: 0x1943B20
	public MethodCall<object, object> get_GetUnionCaseInfoFields() { }

	[CompilerGenerated]
	// RVA: 0x1943B28 Offset: 0x193FB28 VA: 0x1943B28
	private void set_GetUnionCaseInfoFields(MethodCall<object, object> value) { }

	// RVA: 0x1943B30 Offset: 0x193FB30 VA: 0x1943B30
	public static void EnsureInitialized(Assembly fsharpCoreAssembly) { }

	// RVA: 0x19437D0 Offset: 0x193F7D0 VA: 0x19437D0
	private static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags) { }

	// RVA: 0x1943844 Offset: 0x193F844 VA: 0x1943844
	private static MethodCall<object, object> CreateFSharpFuncCall(Type type, string methodName) { }

	// RVA: 0x1943CA8 Offset: 0x193FCA8 VA: 0x1943CA8
	public ObjectConstructor<object> CreateSeq(Type t) { }

	// RVA: 0x1943DB0 Offset: 0x193FDB0 VA: 0x1943DB0
	public ObjectConstructor<object> CreateMap(Type keyType, Type valueType) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1
	public ObjectConstructor<object> BuildMapCreator<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11126A0 Offset: 0x110E6A0 VA: 0x11126A0
	|-FSharpUtils.BuildMapCreator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1943F5C Offset: 0x193FF5C VA: 0x1943F5C
	private static void .cctor() { }
}

// Namespace: 
[Nullable(0)]
internal class ImmutableCollectionsUtils.ImmutableCollectionTypeInfo // TypeDefIndex: 6092
{
	// Fields
	[CompilerGenerated]
	private string <ContractTypeName>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <CreatedTypeName>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <BuilderTypeName>k__BackingField; // 0x20

	// Properties
	public string ContractTypeName { get; set; }
	public string CreatedTypeName { get; set; }
	public string BuilderTypeName { get; set; }

	// Methods

	// RVA: 0x1945318 Offset: 0x1941318 VA: 0x1945318
	public void .ctor(string contractTypeName, string createdTypeName, string builderTypeName) { }

	[CompilerGenerated]
	// RVA: 0x1945378 Offset: 0x1941378 VA: 0x1945378
	public string get_ContractTypeName() { }

	[CompilerGenerated]
	// RVA: 0x1945380 Offset: 0x1941380 VA: 0x1945380
	public void set_ContractTypeName(string value) { }

	[CompilerGenerated]
	// RVA: 0x1945388 Offset: 0x1941388 VA: 0x1945388
	public string get_CreatedTypeName() { }

	[CompilerGenerated]
	// RVA: 0x1945390 Offset: 0x1941390 VA: 0x1945390
	public void set_CreatedTypeName(string value) { }

	[CompilerGenerated]
	// RVA: 0x1945398 Offset: 0x1941398 VA: 0x1945398
	public string get_BuilderTypeName() { }

	[CompilerGenerated]
	// RVA: 0x19453A0 Offset: 0x19413A0 VA: 0x19453A0
	public void set_BuilderTypeName(string value) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ImmutableCollectionsUtils.<>c // TypeDefIndex: 6093
{
	// Fields
	[Nullable(0)]
	public static readonly ImmutableCollectionsUtils.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<MethodInfo, bool> <>9__24_1; // 0x8
	[Nullable(0)]
	public static Func<MethodInfo, bool> <>9__25_1; // 0x10

	// Methods

	// RVA: 0x19453A8 Offset: 0x19413A8 VA: 0x19453A8
	private static void .cctor() { }

	// RVA: 0x1945410 Offset: 0x1941410 VA: 0x1945410
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1945418 Offset: 0x1941418 VA: 0x1945418
	internal bool <TryBuildImmutableForArrayContract>b__24_1(MethodInfo m) { }

	[NullableContext(0)]
	// RVA: 0x19454AC Offset: 0x19414AC VA: 0x19454AC
	internal bool <TryBuildImmutableForDictionaryContract>b__25_1(MethodInfo m) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ImmutableCollectionsUtils.<>c__DisplayClass24_0 // TypeDefIndex: 6094
{
	// Fields
	[Nullable(0)]
	public string name; // 0x10

	// Methods

	// RVA: 0x1944524 Offset: 0x1940524 VA: 0x1944524
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x19455FC Offset: 0x19415FC VA: 0x19455FC
	internal bool <TryBuildImmutableForArrayContract>b__0(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ImmutableCollectionsUtils.<>c__DisplayClass25_0 // TypeDefIndex: 6095
{
	// Fields
	[Nullable(0)]
	public string name; // 0x10

	// Methods

	// RVA: 0x1944A48 Offset: 0x1940A48 VA: 0x1944A48
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x194561C Offset: 0x194161C VA: 0x194561C
	internal bool <TryBuildImmutableForDictionaryContract>b__0(ImmutableCollectionsUtils.ImmutableCollectionTypeInfo d) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class ImmutableCollectionsUtils // TypeDefIndex: 6096
{
	// Fields
	private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> ArrayContractImmutableCollectionDefinitions; // 0x0
	private static readonly IList<ImmutableCollectionsUtils.ImmutableCollectionTypeInfo> DictionaryContractImmutableCollectionDefinitions; // 0x8

	// Methods

	// RVA: 0x1944074 Offset: 0x1940074 VA: 0x1944074
	internal static bool TryBuildImmutableForArrayContract(Type underlyingType, Type collectionItemType, out Type createdType, out ObjectConstructor<object> parameterizedCreator) { }

	// RVA: 0x1944548 Offset: 0x1940548 VA: 0x1944548
	internal static bool TryBuildImmutableForDictionaryContract(Type underlyingType, Type keyItemType, Type valueItemType, out Type createdType, out ObjectConstructor<object> parameterizedCreator) { }

	// RVA: 0x1944A50 Offset: 0x1940A50 VA: 0x1944A50
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(2)]
[Nullable(0)]
internal static class BufferUtils // TypeDefIndex: 6097
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x194563C Offset: 0x194163C VA: 0x194563C
	public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize) { }

	// RVA: 0x1945704 Offset: 0x1941704 VA: 0x1945704
	public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer) { }

	// RVA: 0x19457B4 Offset: 0x19417B4 VA: 0x19457B4
	public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class JavaScriptUtils // TypeDefIndex: 6098
{
	// Fields
	internal static readonly bool[] SingleQuoteCharEscapeFlags; // 0x0
	internal static readonly bool[] DoubleQuoteCharEscapeFlags; // 0x8
	internal static readonly bool[] HtmlCharEscapeFlags; // 0x10

	// Methods

	// RVA: 0x19458F0 Offset: 0x19418F0 VA: 0x19458F0
	private static void .cctor() { }

	// RVA: 0x19464B4 Offset: 0x19424B4 VA: 0x19464B4
	public static bool[] GetCharEscapeFlags(StringEscapeHandling stringEscapeHandling, char quoteChar) { }

	// RVA: 0x1946560 Offset: 0x1942560 VA: 0x1946560
	public static bool ShouldEscapeJavaScriptString(string s, bool[] charEscapeFlags) { }

	[NullableContext(2)]
	// RVA: 0x19465DC Offset: 0x19425DC VA: 0x19465DC
	public static void WriteEscapedJavaScriptString(TextWriter writer, string s, char delimiter, bool appendDelimiters, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling, IArrayPool<char> bufferPool, ref char[] writeBuffer) { }

	// RVA: 0x1946D40 Offset: 0x1942D40 VA: 0x1946D40
	public static string ToEscapedJavaScriptString(string value, char delimiter, bool appendDelimiters, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0x1946BD0 Offset: 0x1942BD0 VA: 0x1946BD0
	private static int FirstCharToEscape(string s, bool[] charEscapeFlags, StringEscapeHandling stringEscapeHandling) { }

	// RVA: 0x1946FDC Offset: 0x1942FDC VA: 0x1946FDC
	public static bool TryGetDateFromConstructorJson(JsonReader reader, out DateTime dateTime, out string errorMessage) { }

	// RVA: 0x1947438 Offset: 0x1943438 VA: 0x1947438
	private static bool TryGetDateConstructorValue(JsonReader reader, out Nullable<long> integer, out string errorMessage) { }
}

// Namespace: Newtonsoft.Json.Utilities
internal static class JsonTokenUtils // TypeDefIndex: 6099
{
	// Methods

	// RVA: 0x19475E8 Offset: 0x19435E8 VA: 0x19475E8
	internal static bool IsEndToken(JsonToken token) { }

	// RVA: 0x19475F8 Offset: 0x19435F8 VA: 0x19475F8
	internal static bool IsStartToken(JsonToken token) { }

	// RVA: 0x1947608 Offset: 0x1943608 VA: 0x1947608
	internal static bool IsPrimitiveToken(JsonToken token) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass3_0 // TypeDefIndex: 6100
{
	// Fields
	[Nullable(0)]
	public ConstructorInfo c; // 0x10
	[Nullable(0)]
	public MethodBase method; // 0x18

	// Methods

	// RVA: 0x1947818 Offset: 0x1943818 VA: 0x1947818
	public void .ctor() { }

	// RVA: 0x1947898 Offset: 0x1943898 VA: 0x1947898
	internal object <CreateParameterizedConstructor>b__0(object[] a) { }

	// RVA: 0x19478B0 Offset: 0x19438B0 VA: 0x19478B0
	internal object <CreateParameterizedConstructor>b__1(object[] a) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<T> // TypeDefIndex: 6101
{
	// Fields
	[Nullable(0)]
	public ConstructorInfo c; // 0x0
	[Nullable(0)]
	public MethodBase method; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115B2EC Offset: 0x11572EC VA: 0x115B2EC
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>..ctor
	|
	|-RVA: 0x115B328 Offset: 0x1157328 VA: 0x115B328
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal object <CreateMethodCall>b__0(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115B2F4 Offset: 0x11572F4 VA: 0x115B2F4
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__0
	|
	|-RVA: 0x115B330 Offset: 0x1157330 VA: 0x115B330
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType>.<CreateMethodCall>b__0
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal object <CreateMethodCall>b__1(T o, object[] a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115B310 Offset: 0x1157310 VA: 0x115B310
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<object>.<CreateMethodCall>b__1
	|
	|-RVA: 0x115B34C Offset: 0x115734C VA: 0x115B34C
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType>.<CreateMethodCall>b__1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<T> // TypeDefIndex: 6102
{
	// Fields
	[Nullable(0)]
	public Type type; // 0x0
	[Nullable(0)]
	public ConstructorInfo constructorInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115B734 Offset: 0x1157734 VA: 0x115B734
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>..ctor
	|
	|-RVA: 0x115B828 Offset: 0x1157828 VA: 0x115B828
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal T <CreateDefaultConstructor>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115B73C Offset: 0x115773C VA: 0x115B73C
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__0
	|
	|-RVA: 0x115B830 Offset: 0x1157830 VA: 0x115B830
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<__Il2CppFullySharedGenericType>.<CreateDefaultConstructor>b__0
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal T <CreateDefaultConstructor>b__1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115B7AC Offset: 0x11577AC VA: 0x115B7AC
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<object>.<CreateDefaultConstructor>b__1
	|
	|-RVA: 0x115B8FC Offset: 0x11578FC VA: 0x115B8FC
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass5_0<__Il2CppFullySharedGenericType>.<CreateDefaultConstructor>b__1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<T> // TypeDefIndex: 6103
{
	// Fields
	[Nullable(0)]
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115BBFC Offset: 0x1157BFC VA: 0x115BBFC
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>..ctor
	|
	|-RVA: 0x115BE38 Offset: 0x1157E38 VA: 0x115BE38
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115BC04 Offset: 0x1157C04 VA: 0x115BC04
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<object>.<CreateGet>b__0
	|
	|-RVA: 0x115BE40 Offset: 0x1157E40 VA: 0x115BE40
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass6_0<__Il2CppFullySharedGenericType>.<CreateGet>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<T> // TypeDefIndex: 6104
{
	// Fields
	[Nullable(0)]
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115C27C Offset: 0x115827C VA: 0x115C27C
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>..ctor
	|
	|-RVA: 0x115C2A4 Offset: 0x11582A4 VA: 0x115C2A4
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal object <CreateGet>b__0(T o) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115C284 Offset: 0x1158284 VA: 0x115C284
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<object>.<CreateGet>b__0
	|
	|-RVA: 0x115C2AC Offset: 0x11582AC VA: 0x115C2AC
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType>.<CreateGet>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<T> // TypeDefIndex: 6105
{
	// Fields
	[Nullable(0)]
	public FieldInfo fieldInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115C68C Offset: 0x115868C VA: 0x115C68C
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>..ctor
	|
	|-RVA: 0x115C6AC Offset: 0x11586AC VA: 0x115C6AC
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115C694 Offset: 0x1158694 VA: 0x115C694
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<object>.<CreateSet>b__0
	|
	|-RVA: 0x115C6B4 Offset: 0x11586B4 VA: 0x115C6B4
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass8_0<__Il2CppFullySharedGenericType>.<CreateSet>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<T> // TypeDefIndex: 6106
{
	// Fields
	[Nullable(0)]
	public PropertyInfo propertyInfo; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115CD28 Offset: 0x1158D28 VA: 0x115CD28
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>..ctor
	|
	|-RVA: 0x115CD54 Offset: 0x1158D54 VA: 0x115CD54
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal void <CreateSet>b__0(T o, object v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115CD30 Offset: 0x1158D30 VA: 0x115CD30
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<object>.<CreateSet>b__0
	|
	|-RVA: 0x115CD5C Offset: 0x1158D5C VA: 0x115CD5C
	|-LateBoundReflectionDelegateFactory.<>c__DisplayClass9_0<__Il2CppFullySharedGenericType>.<CreateSet>b__0
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class LateBoundReflectionDelegateFactory : ReflectionDelegateFactory // TypeDefIndex: 6107
{
	// Fields
	private static readonly LateBoundReflectionDelegateFactory _instance; // 0x0

	// Properties
	internal static ReflectionDelegateFactory Instance { get; }

	// Methods

	// RVA: 0x1947620 Offset: 0x1943620 VA: 0x1947620
	internal static ReflectionDelegateFactory get_Instance() { }

	// RVA: 0x1947678 Offset: 0x1943678 VA: 0x1947678 Slot: 5
	public override ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method) { }

	// RVA: -1 Offset: -1 Slot: 4
	public override MethodCall<T, object> CreateMethodCall<T>(MethodBase method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111CB44 Offset: 0x1118B44 VA: 0x111CB44
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<object>
	|
	|-RVA: 0x111CCEC Offset: 0x1118CEC VA: 0x111CCEC
	|-LateBoundReflectionDelegateFactory.CreateMethodCall<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override Func<T> CreateDefaultConstructor<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111C368 Offset: 0x1118368 VA: 0x111C368
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<object>
	|
	|-RVA: 0x111C588 Offset: 0x1118588 VA: 0x111C588
	|-LateBoundReflectionDelegateFactory.CreateDefaultConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public override Func<T, object> CreateGet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111C894 Offset: 0x1118894 VA: 0x111C894
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	|
	|-RVA: 0x111CA5C Offset: 0x1118A5C VA: 0x111CA5C
	|-LateBoundReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override Func<T, object> CreateGet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111C7B4 Offset: 0x11187B4 VA: 0x111C7B4
	|-LateBoundReflectionDelegateFactory.CreateGet<object>
	|
	|-RVA: 0x111C974 Offset: 0x1118974 VA: 0x111C974
	|-LateBoundReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override Action<T, object> CreateSet<T>(FieldInfo fieldInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111CEA0 Offset: 0x1118EA0 VA: 0x111CEA0
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	|
	|-RVA: 0x111D060 Offset: 0x1119060 VA: 0x111D060
	|-LateBoundReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public override Action<T, object> CreateSet<T>(PropertyInfo propertyInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111CF80 Offset: 0x1118F80 VA: 0x111CF80
	|-LateBoundReflectionDelegateFactory.CreateSet<object>
	|
	|-RVA: 0x111D148 Offset: 0x1119148 VA: 0x111D148
	|-LateBoundReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1947820 Offset: 0x1943820 VA: 0x1947820
	public void .ctor() { }

	// RVA: 0x1947830 Offset: 0x1943830 VA: 0x1947830
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
internal static class MathUtils // TypeDefIndex: 6108
{
	// Methods

	// RVA: 0x19478D0 Offset: 0x19438D0 VA: 0x19478D0
	public static int IntLength(ulong i) { }

	// RVA: 0x1947A94 Offset: 0x1943A94 VA: 0x1947A94
	public static char IntToHex(int n) { }

	// RVA: 0x1947AAC Offset: 0x1943AAC VA: 0x1947AAC
	public static bool ApproxEquals(double d1, double d2) { }
}

// Namespace: Newtonsoft.Json.Utilities
internal sealed class MethodCall<T, TResult> : MulticastDelegate // TypeDefIndex: 6109
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D1A68 Offset: 0x13CDA68 VA: 0x13D1A68
	|-MethodCall<object, object>..ctor
	|
	|-RVA: 0x13D1B88 Offset: 0x13CDB88 VA: 0x13D1B88
	|-MethodCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 12
	public virtual TResult Invoke(T target, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D1B74 Offset: 0x13CDB74 VA: 0x13D1B74
	|-MethodCall<object, object>.Invoke
	|
	|-RVA: 0x13D1C98 Offset: 0x13CDC98 VA: 0x13D1C98
	|-MethodCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal static class MiscellaneousUtils // TypeDefIndex: 6110
{
	// Methods

	[NullableContext(2)]
	// RVA: 0x1947B48 Offset: 0x1943B48 VA: 0x1947B48
	public static bool ValueEquals(object objA, object objB) { }

	// RVA: 0x193D4C4 Offset: 0x19394C4 VA: 0x193D4C4
	public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message) { }

	// RVA: 0x1947E74 Offset: 0x1943E74 VA: 0x1947E74
	public static string ToString(object value) { }

	// RVA: 0x1947F18 Offset: 0x1943F18 VA: 0x1947F18
	public static int ByteArrayCompare(byte[] a1, byte[] a2) { }

	// RVA: 0x1947FCC Offset: 0x1943FCC VA: 0x1947FCC
	public static string GetPrefix(string qualifiedName) { }

	// RVA: 0x19480AC Offset: 0x19440AC VA: 0x19480AC
	public static string GetLocalName(string qualifiedName) { }

	// RVA: 0x1947FF0 Offset: 0x1943FF0 VA: 0x1947FF0
	public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName) { }

	// RVA: 0x19480E4 Offset: 0x19440E4 VA: 0x19480E4
	internal static RegexOptions GetRegexOptions(string optionsText) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal abstract class ReflectionDelegateFactory // TypeDefIndex: 6111
{
	// Methods

	// RVA: -1 Offset: -1
	public Func<T, object> CreateGet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11404A8 Offset: 0x113C4A8 VA: 0x11404A8
	|-ReflectionDelegateFactory.CreateGet<object>
	|
	|-RVA: 0x1140680 Offset: 0x113C680 VA: 0x1140680
	|-ReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Action<T, object> CreateSet<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1140858 Offset: 0x113C858 VA: 0x1140858
	|-ReflectionDelegateFactory.CreateSet<object>
	|
	|-RVA: 0x11409AC Offset: 0x113C9AC VA: 0x11409AC
	|-ReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract MethodCall<T, object> CreateMethodCall<T>(MethodBase method);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateMethodCall<__Il2CppFullySharedGenericType>
	|-ReflectionDelegateFactory.CreateMethodCall<object>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract ObjectConstructor<object> CreateParameterizedConstructor(MethodBase method);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract Func<T> CreateDefaultConstructor<T>(Type type);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateDefaultConstructor<__Il2CppFullySharedGenericType>
	|-ReflectionDelegateFactory.CreateDefaultConstructor<object>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Func<T, object> CreateGet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	|-ReflectionDelegateFactory.CreateGet<object>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Func<T, object> CreateGet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateGet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Action<T, object> CreateSet<T>(FieldInfo fieldInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Action<T, object> CreateSet<T>(PropertyInfo propertyInfo);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ReflectionDelegateFactory.CreateSet<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1947828 Offset: 0x1943828 VA: 0x1947828
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(2)]
[Nullable(0)]
internal class ReflectionMember // TypeDefIndex: 6112
{
	// Fields
	[CompilerGenerated]
	private Type <MemberType>k__BackingField; // 0x10
	[Nullable(new[] { 2, 1, 2 })]
	[CompilerGenerated]
	private Func<object, object> <Getter>k__BackingField; // 0x18
	[Nullable(new[] { 2, 1, 2 })]
	[CompilerGenerated]
	private Action<object, object> <Setter>k__BackingField; // 0x20

	// Properties
	public Type MemberType { get; set; }
	[Nullable(new[] { 2, 1, 2 })]
	public Func<object, object> Getter { get; set; }
	[Nullable(new[] { 2, 1, 2 })]
	public Action<object, object> Setter { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x194818C Offset: 0x194418C VA: 0x194818C
	public Type get_MemberType() { }

	[CompilerGenerated]
	// RVA: 0x1948194 Offset: 0x1944194 VA: 0x1948194
	public void set_MemberType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x194819C Offset: 0x194419C VA: 0x194819C
	public Func<object, object> get_Getter() { }

	[CompilerGenerated]
	// RVA: 0x19481A4 Offset: 0x19441A4 VA: 0x19481A4
	public void set_Getter(Func<object, object> value) { }

	[CompilerGenerated]
	// RVA: 0x19481AC Offset: 0x19441AC VA: 0x19481AC
	public Action<object, object> get_Setter() { }

	[CompilerGenerated]
	// RVA: 0x19481B4 Offset: 0x19441B4 VA: 0x19481B4
	public void set_Setter(Action<object, object> value) { }

	// RVA: 0x19481BC Offset: 0x19441BC VA: 0x19481BC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionObject.<>c__DisplayClass11_0 // TypeDefIndex: 6113
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	public Func<object> ctor; // 0x10

	// Methods

	// RVA: 0x1948E1C Offset: 0x1944E1C VA: 0x1948E1C
	public void .ctor() { }

	// RVA: 0x1949344 Offset: 0x1945344 VA: 0x1949344
	internal object <Create>b__0(object[] args) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionObject.<>c__DisplayClass11_1 // TypeDefIndex: 6114
{
	// Fields
	[Nullable(new[] { 0, 1, 2 })]
	public MethodCall<object, object> call; // 0x10

	// Methods

	// RVA: 0x194910C Offset: 0x194510C VA: 0x194910C
	public void .ctor() { }

	// RVA: 0x1949364 Offset: 0x1945364 VA: 0x1949364
	internal object <Create>b__1(object target) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionObject.<>c__DisplayClass11_2 // TypeDefIndex: 6115
{
	// Fields
	[Nullable(new[] { 0, 1, 2 })]
	public MethodCall<object, object> call; // 0x10

	// Methods

	// RVA: 0x1949114 Offset: 0x1945114 VA: 0x1949114
	public void .ctor() { }

	// RVA: 0x1949424 Offset: 0x1945424 VA: 0x1949424
	internal void <Create>b__2(object target, object arg) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class ReflectionObject // TypeDefIndex: 6116
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private readonly ObjectConstructor<object> <Creator>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly IDictionary<string, ReflectionMember> <Members>k__BackingField; // 0x18

	// Properties
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> Creator { get; }
	public IDictionary<string, ReflectionMember> Members { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19481C4 Offset: 0x19441C4 VA: 0x19481C4
	public ObjectConstructor<object> get_Creator() { }

	[CompilerGenerated]
	// RVA: 0x19481CC Offset: 0x19441CC VA: 0x19481CC
	public IDictionary<string, ReflectionMember> get_Members() { }

	// RVA: 0x19481D4 Offset: 0x19441D4 VA: 0x19481D4
	private void .ctor(ObjectConstructor<object> creator) { }

	// RVA: 0x1948270 Offset: 0x1944270 VA: 0x1948270
	public object GetValue(object target, string member) { }

	// RVA: 0x1948344 Offset: 0x1944344 VA: 0x1948344
	public void SetValue(object target, string member, object value) { }

	// RVA: 0x1948420 Offset: 0x1944420 VA: 0x1948420
	public Type GetType(string member) { }

	// RVA: 0x19484D4 Offset: 0x19444D4 VA: 0x19484D4
	public static ReflectionObject Create(Type t, string[] memberNames) { }

	// RVA: 0x19484E0 Offset: 0x19444E0 VA: 0x19484E0
	public static ReflectionObject Create(Type t, MethodBase creator, string[] memberNames) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ReflectionUtils.<>c // TypeDefIndex: 6117
{
	// Fields
	[Nullable(0)]
	public static readonly ReflectionUtils.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<ConstructorInfo, bool> <>9__11_0; // 0x8
	[Nullable(0)]
	public static Func<MemberInfo, string> <>9__31_0; // 0x10
	[Nullable(0)]
	public static Func<ParameterInfo, Type> <>9__39_0; // 0x18
	[Nullable(0)]
	public static Func<FieldInfo, bool> <>9__41_0; // 0x20

	// Methods

	// RVA: 0x194D308 Offset: 0x1949308 VA: 0x194D308
	private static void .cctor() { }

	// RVA: 0x194D370 Offset: 0x1949370 VA: 0x194D370
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x194D378 Offset: 0x1949378 VA: 0x194D378
	internal bool <GetDefaultConstructor>b__11_0(ConstructorInfo c) { }

	[NullableContext(0)]
	// RVA: 0x194D3E4 Offset: 0x19493E4 VA: 0x194D3E4
	internal string <GetFieldsAndProperties>b__31_0(MemberInfo m) { }

	[NullableContext(0)]
	// RVA: 0x194D404 Offset: 0x1949404 VA: 0x194D404
	internal Type <GetMemberInfoFromType>b__39_0(ParameterInfo p) { }

	[NullableContext(0)]
	// RVA: 0x194D424 Offset: 0x1949424 VA: 0x194D424
	internal bool <GetChildPrivateFields>b__41_0(FieldInfo f) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionUtils.<>c__DisplayClass31_0 // TypeDefIndex: 6118
{
	// Fields
	[Nullable(0)]
	public MemberInfo memberInfo; // 0x10

	// Methods

	// RVA: 0x194C09C Offset: 0x194809C VA: 0x194C09C
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x194D43C Offset: 0x194943C VA: 0x194D43C
	internal bool <GetFieldsAndProperties>b__1(MemberInfo m) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionUtils.<>c__DisplayClass44_0 // TypeDefIndex: 6119
{
	// Fields
	[Nullable(0)]
	public PropertyInfo subTypeProperty; // 0x10

	// Methods

	// RVA: 0x194CFA0 Offset: 0x1948FA0 VA: 0x194CFA0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x194D4B8 Offset: 0x19494B8 VA: 0x194D4B8
	internal bool <GetChildPrivateProperties>b__0(PropertyInfo p) { }

	[NullableContext(0)]
	// RVA: 0x194D50C Offset: 0x194950C VA: 0x194D50C
	internal bool <GetChildPrivateProperties>b__1(PropertyInfo p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionUtils.<>c__DisplayClass44_1 // TypeDefIndex: 6120
{
	// Fields
	[Nullable(0)]
	public Type subTypePropertyDeclaringType; // 0x10
	[Nullable(0)]
	public ReflectionUtils.<>c__DisplayClass44_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x194CFA8 Offset: 0x1948FA8 VA: 0x194CFA8
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x194D5D8 Offset: 0x19495D8 VA: 0x194D5D8
	internal bool <GetChildPrivateProperties>b__2(PropertyInfo p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionUtils.<>c__DisplayClass45_0 // TypeDefIndex: 6121
{
	// Fields
	[Nullable(0)]
	public string method; // 0x10
	[Nullable(0)]
	public Type methodDeclaringType; // 0x18

	// Methods

	// RVA: 0x194D0C4 Offset: 0x19490C4 VA: 0x194D0C4
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x194D6E4 Offset: 0x19496E4 VA: 0x194D6E4
	internal bool <IsMethodOverridden>b__0(MethodInfo info) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class ReflectionUtils // TypeDefIndex: 6122
{
	// Fields
	public static readonly Type[] EmptyTypes; // 0x0

	// Methods

	// RVA: 0x19494E8 Offset: 0x19454E8 VA: 0x19494E8
	private static void .cctor() { }

	[Extension]
	// RVA: 0x194955C Offset: 0x194555C VA: 0x194955C
	public static bool IsVirtual(PropertyInfo propertyInfo) { }

	[Extension]
	// RVA: 0x194963C Offset: 0x194563C VA: 0x194963C
	public static MethodInfo GetBaseDefinition(PropertyInfo propertyInfo) { }

	// RVA: 0x19496FC Offset: 0x19456FC VA: 0x19496FC
	public static bool IsPublic(PropertyInfo property) { }

	[NullableContext(2)]
	// RVA: 0x193A620 Offset: 0x1936620 VA: 0x193A620
	public static Type GetObjectType(object v) { }

	// RVA: 0x194978C Offset: 0x194578C VA: 0x194978C
	public static string GetTypeName(Type t, TypeNameAssemblyFormatHandling assemblyFormat, ISerializationBinder binder) { }

	// RVA: 0x1949864 Offset: 0x1945864 VA: 0x1949864
	private static string GetFullyQualifiedTypeName(Type t, ISerializationBinder binder) { }

	// RVA: 0x194999C Offset: 0x194599C VA: 0x194999C
	private static string RemoveAssemblyDetails(string fullyQualifiedTypeName) { }

	// RVA: 0x1948D30 Offset: 0x1944D30 VA: 0x1948D30
	public static bool HasDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x1949C4C Offset: 0x1945C4C VA: 0x1949C4C
	public static ConstructorInfo GetDefaultConstructor(Type t) { }

	// RVA: 0x1949B18 Offset: 0x1945B18 VA: 0x1949B18
	public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic) { }

	// RVA: 0x193A1DC Offset: 0x19361DC VA: 0x193A1DC
	public static bool IsNullable(Type t) { }

	// RVA: 0x193858C Offset: 0x193458C VA: 0x193858C
	public static bool IsNullableType(Type t) { }

	// RVA: 0x1949CA4 Offset: 0x1945CA4 VA: 0x1949CA4
	public static Type EnsureNotNullableType(Type t) { }

	// RVA: 0x1949D18 Offset: 0x1945D18 VA: 0x1949D18
	public static Type EnsureNotByRefType(Type t) { }

	// RVA: 0x1949D68 Offset: 0x1945D68 VA: 0x1949D68
	public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x19374B4 Offset: 0x19334B4 VA: 0x19374B4
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition) { }

	// RVA: 0x1949DF0 Offset: 0x1945DF0 VA: 0x1949DF0
	public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType) { }

	// RVA: 0x194A078 Offset: 0x1946078 VA: 0x194A078
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition) { }

	// RVA: 0x194A0EC Offset: 0x19460EC VA: 0x194A0EC
	public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x194A254 Offset: 0x1946254 VA: 0x194A254
	private static bool InheritsGenericDefinitionInternal(Type type, Type genericClassDefinition, out Type implementingType) { }

	// RVA: 0x194A36C Offset: 0x194636C VA: 0x194A36C
	public static Type GetCollectionItemType(Type type) { }

	[NullableContext(2)]
	// RVA: 0x194A588 Offset: 0x1946588 VA: 0x194A588
	public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType) { }

	// RVA: 0x194911C Offset: 0x194511C VA: 0x194911C
	public static Type GetMemberUnderlyingType(MemberInfo member) { }

	// RVA: 0x194A7BC Offset: 0x19467BC VA: 0x194A7BC
	public static bool IsByRefLikeType(Type type) { }

	// RVA: 0x194ACE0 Offset: 0x1946CE0 VA: 0x194ACE0
	public static bool IsIndexedProperty(PropertyInfo property) { }

	// RVA: 0x194AD58 Offset: 0x1946D58 VA: 0x194AD58
	public static object GetMemberValue(MemberInfo member, object target) { }

	// RVA: 0x194B064 Offset: 0x1947064 VA: 0x194B064
	public static void SetMemberValue(MemberInfo member, object target, object value) { }

	// RVA: 0x1948E3C Offset: 0x1944E3C VA: 0x1948E3C
	public static bool CanReadMemberValue(MemberInfo member, bool nonPublic) { }

	// RVA: 0x1948F88 Offset: 0x1944F88 VA: 0x1948F88
	public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly) { }

	// RVA: 0x194B274 Offset: 0x1947274 VA: 0x194B274
	public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr) { }

	// RVA: 0x194C0A4 Offset: 0x19480A4 VA: 0x194C0A4
	private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1140F88 Offset: 0x113CF88 VA: 0x1140F88
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1140FF0 Offset: 0x113CFF0 VA: 0x1140FF0
	|-ReflectionUtils.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static T[] GetAttributes<T>(object attributeProvider, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1141078 Offset: 0x113D078 VA: 0x1141078
	|-ReflectionUtils.GetAttributes<object>
	*/

	// RVA: 0x194A8CC Offset: 0x19468CC VA: 0x194A8CC
	public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit) { }

	// RVA: 0x194C270 Offset: 0x1948270 VA: 0x194C270
	public static StructMultiKey<string, string> SplitFullyQualifiedTypeName(string fullyQualifiedTypeName) { }

	// RVA: 0x194C364 Offset: 0x1948364 VA: 0x194C364
	private static Nullable<int> GetAssemblyDelimiterIndex(string fullyQualifiedTypeName) { }

	// RVA: 0x194C5CC Offset: 0x19485CC VA: 0x194C5CC
	public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo) { }

	// RVA: 0x194BC90 Offset: 0x1947C90 VA: 0x194BC90
	public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr) { }

	// RVA: 0x194C838 Offset: 0x1948838 VA: 0x194C838
	private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type type, BindingFlags bindingAttr) { }

	// RVA: 0x194BDA8 Offset: 0x1947DA8 VA: 0x194BDA8
	public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr) { }

	[Extension]
	// RVA: 0x194CA1C Offset: 0x1948A1C VA: 0x194CA1C
	public static BindingFlags RemoveFlag(BindingFlags bindingAttr, BindingFlags flag) { }

	// RVA: 0x194CA2C Offset: 0x1948A2C VA: 0x194CA2C
	private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type type, BindingFlags bindingAttr) { }

	// RVA: 0x194CFB0 Offset: 0x1948FB0 VA: 0x194CFB0
	public static bool IsMethodOverridden(Type currentType, Type methodDeclaringType, string method) { }

	// RVA: 0x194D0CC Offset: 0x19490CC VA: 0x194D0CC
	public static object GetDefaultValue(Type type) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(2)]
[Nullable(0)]
internal struct StringBuffer // TypeDefIndex: 6123
{
	// Fields
	private char[] _buffer; // 0x0
	private int _position; // 0x8

	// Properties
	public int Position { get; set; }
	public bool IsEmpty { get; }
	public char[] InternalBuffer { get; }

	// Methods

	// RVA: 0x194D7D8 Offset: 0x19497D8 VA: 0x194D7D8
	public int get_Position() { }

	// RVA: 0x194D7E0 Offset: 0x19497E0 VA: 0x194D7E0
	public void set_Position(int value) { }

	// RVA: 0x194D7E8 Offset: 0x19497E8 VA: 0x194D7E8
	public bool get_IsEmpty() { }

	// RVA: 0x194D7F8 Offset: 0x19497F8 VA: 0x194D7F8
	public void .ctor(IArrayPool<char> bufferPool, int initalSize) { }

	[NullableContext(1)]
	// RVA: 0x194D828 Offset: 0x1949828 VA: 0x194D828
	private void .ctor(char[] buffer) { }

	// RVA: 0x194D844 Offset: 0x1949844 VA: 0x194D844
	public void Append(IArrayPool<char> bufferPool, char value) { }

	[NullableContext(1)]
	// RVA: 0x194D928 Offset: 0x1949928 VA: 0x194D928
	public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count) { }

	// RVA: 0x194D9A8 Offset: 0x19499A8 VA: 0x194D9A8
	public void Clear(IArrayPool<char> bufferPool) { }

	// RVA: 0x194D8BC Offset: 0x19498BC VA: 0x194D8BC
	private void EnsureSize(IArrayPool<char> bufferPool, int appendLength) { }

	[NullableContext(1)]
	// RVA: 0x194D9E0 Offset: 0x19499E0 VA: 0x194D9E0 Slot: 3
	public override string ToString() { }

	[NullableContext(1)]
	// RVA: 0x194D9FC Offset: 0x19499FC VA: 0x194D9FC
	public string ToString(int start, int length) { }

	// RVA: 0x194DA18 Offset: 0x1949A18 VA: 0x194DA18
	public char[] get_InternalBuffer() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[IsReadOnly]
[DefaultMember("Item")]
internal struct StringReference // TypeDefIndex: 6124
{
	// Fields
	private readonly char[] _chars; // 0x0
	private readonly int _startIndex; // 0x8
	private readonly int _length; // 0xC

	// Properties
	public char Item { get; }
	public char[] Chars { get; }
	public int StartIndex { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x193E73C Offset: 0x193A73C VA: 0x193E73C
	public char get_Item(int i) { }

	// RVA: 0x194DA20 Offset: 0x1949A20 VA: 0x194DA20
	public char[] get_Chars() { }

	// RVA: 0x194DA28 Offset: 0x1949A28 VA: 0x194DA28
	public int get_StartIndex() { }

	// RVA: 0x194DA30 Offset: 0x1949A30 VA: 0x194DA30
	public int get_Length() { }

	// RVA: 0x193EE2C Offset: 0x193AE2C VA: 0x193EE2C
	public void .ctor(char[] chars, int startIndex, int length) { }

	// RVA: 0x193EA64 Offset: 0x193AA64 VA: 0x193EA64 Slot: 3
	public override string ToString() { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class StringReferenceExtensions // TypeDefIndex: 6125
{
	// Methods

	[Extension]
	// RVA: 0x193F6B0 Offset: 0x193B6B0 VA: 0x193F6B0
	public static int IndexOf(StringReference s, char c, int startIndex, int length) { }

	[Extension]
	// RVA: 0x193E76C Offset: 0x193A76C VA: 0x193E76C
	public static bool StartsWith(StringReference s, string text) { }

	[Extension]
	// RVA: 0x193E82C Offset: 0x193A82C VA: 0x193E82C
	public static bool EndsWith(StringReference s, string text) { }
}

// Namespace: 
[NullableContext(0)]
private enum StringUtils.SeparatedCaseState // TypeDefIndex: 6126
{
	// Fields
	public int value__; // 0x0
	public const StringUtils.SeparatedCaseState Start = 0;
	public const StringUtils.SeparatedCaseState Lower = 1;
	public const StringUtils.SeparatedCaseState Upper = 2;
	public const StringUtils.SeparatedCaseState NewWord = 3;
}

// Namespace: 
[CompilerGenerated]
private sealed class StringUtils.<>c__DisplayClass14_0<TSource> // TypeDefIndex: 6127
{
	// Fields
	[Nullable(new[] { 0, 0, 1 })]
	public Func<TSource, string> valueSelector; // 0x0
	[Nullable(0)]
	public string testValue; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1156810 Offset: 0x1152810 VA: 0x1156810
	|-StringUtils.<>c__DisplayClass14_0<object>..ctor
	|
	|-RVA: 0x1156888 Offset: 0x1152888 VA: 0x1156888
	|-StringUtils.<>c__DisplayClass14_0<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal bool <ForgivingCaseSensitiveFind>b__0(TSource s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1156818 Offset: 0x1152818 VA: 0x1156818
	|-StringUtils.<>c__DisplayClass14_0<object>.<ForgivingCaseSensitiveFind>b__0
	|
	|-RVA: 0x1156890 Offset: 0x1152890 VA: 0x1156890
	|-StringUtils.<>c__DisplayClass14_0<__Il2CppFullySharedGenericType>.<ForgivingCaseSensitiveFind>b__0
	*/

	[NullableContext(0)]
	// RVA: -1 Offset: -1
	internal bool <ForgivingCaseSensitiveFind>b__1(TSource s) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1156850 Offset: 0x1152850 VA: 0x1156850
	|-StringUtils.<>c__DisplayClass14_0<object>.<ForgivingCaseSensitiveFind>b__1
	|
	|-RVA: 0x1156980 Offset: 0x1152980 VA: 0x1156980
	|-StringUtils.<>c__DisplayClass14_0<__Il2CppFullySharedGenericType>.<ForgivingCaseSensitiveFind>b__1
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class StringUtils // TypeDefIndex: 6128
{
	// Methods

	[NullableContext(2)]
	// RVA: 0x193EA5C Offset: 0x193AA5C VA: 0x193EA5C
	public static bool IsNullOrEmpty(string value) { }

	[Extension]
	// RVA: 0x1938DB4 Offset: 0x1934DB4 VA: 0x1938DB4
	public static string FormatWith(string format, IFormatProvider provider, object arg0) { }

	[Extension]
	// RVA: 0x1939F2C Offset: 0x1935F2C VA: 0x1939F2C
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1) { }

	[Extension]
	// RVA: 0x194DAA4 Offset: 0x1949AA4 VA: 0x194DAA4
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2) { }

	[NullableContext(2)]
	[Extension]
	// RVA: 0x194DBD0 Offset: 0x1949BD0 VA: 0x194DBD0
	public static string FormatWith(string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3) { }

	[Extension]
	// RVA: 0x194DA38 Offset: 0x1949A38 VA: 0x194DA38
	private static string FormatWith(string format, IFormatProvider provider, object[] args) { }

	// RVA: 0x1946F14 Offset: 0x1942F14 VA: 0x1946F14
	public static StringWriter CreateStringWriter(int capacity) { }

	// RVA: 0x1946C88 Offset: 0x1942C88 VA: 0x1946C88
	public static void ToCharAsUnicode(char c, char[] buffer) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static TSource ForgivingCaseSensitiveFind<TSource>(IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114D970 Offset: 0x1149970 VA: 0x114D970
	|-StringUtils.ForgivingCaseSensitiveFind<object>
	|
	|-RVA: 0x114DB2C Offset: 0x1149B2C VA: 0x114DB2C
	|-StringUtils.ForgivingCaseSensitiveFind<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x194DD3C Offset: 0x1949D3C VA: 0x194DD3C
	public static string ToCamelCase(string s) { }

	// RVA: 0x194DF00 Offset: 0x1949F00 VA: 0x194DF00
	private static char ToLower(char c) { }

	// RVA: 0x194DF84 Offset: 0x1949F84 VA: 0x194DF84
	public static string ToSnakeCase(string s) { }

	// RVA: 0x194E268 Offset: 0x194A268 VA: 0x194E268
	public static string ToKebabCase(string s) { }

	// RVA: 0x194DF8C Offset: 0x1949F8C VA: 0x194DF8C
	private static string ToSeparatedCase(string s, char separator) { }

	// RVA: 0x194E270 Offset: 0x194A270 VA: 0x194E270
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x194E2A4 Offset: 0x194A2A4 VA: 0x194E2A4
	public static bool IsLowSurrogate(char c) { }

	// RVA: 0x19480D0 Offset: 0x19440D0 VA: 0x19480D0
	public static int IndexOf(string s, char c) { }

	[Extension]
	// RVA: 0x194E2D8 Offset: 0x194A2D8 VA: 0x194E2D8
	public static bool StartsWith(string source, char value) { }

	[Extension]
	// RVA: 0x194E31C Offset: 0x194A31C VA: 0x194E31C
	public static bool EndsWith(string source, char value) { }

	[Extension]
	// RVA: 0x194C43C Offset: 0x194843C VA: 0x194C43C
	public static string Trim(string s, int start, int length) { }
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[IsReadOnly]
internal struct StructMultiKey<T1, T2> : IEquatable<StructMultiKey<T1, T2>> // TypeDefIndex: 6129
{
	// Fields
	public readonly T1 Value1; // 0x0
	public readonly T2 Value2; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T1 v1, T2 v2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1465F48 Offset: 0x1461F48 VA: 0x1465F48
	|-StructMultiKey<object, object>..ctor
	|
	|-RVA: 0x1466100 Offset: 0x1462100 VA: 0x1466100
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1465F78 Offset: 0x1461F78 VA: 0x1465F78
	|-StructMultiKey<object, object>.GetHashCode
	|
	|-RVA: 0x14662F0 Offset: 0x14622F0 VA: 0x14662F0
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1465FC8 Offset: 0x1461FC8 VA: 0x1465FC8
	|-StructMultiKey<object, object>.Equals
	|
	|-RVA: 0x14666E8 Offset: 0x14626E8 VA: 0x14666E8
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(StructMultiKey<T1, T2> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14660B8 Offset: 0x14620B8 VA: 0x14660B8
	|-StructMultiKey<object, object>.Equals
	|
	|-RVA: 0x14668C0 Offset: 0x14628C0 VA: 0x14668C0
	|-StructMultiKey<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
internal class ThreadSafeStore<TKey, TValue> // TypeDefIndex: 6130
{
	// Fields
	private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore; // 0x0
	private readonly Func<TKey, TValue> _creator; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<TKey, TValue> creator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1482978 Offset: 0x147E978 VA: 0x1482978
	|-ThreadSafeStore<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x1482A5C Offset: 0x147EA5C VA: 0x1482A5C
	|-ThreadSafeStore<object, object>..ctor
	|
	|-RVA: 0x1482B40 Offset: 0x147EB40 VA: 0x1482B40
	|-ThreadSafeStore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public TValue Get(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1482A34 Offset: 0x147EA34 VA: 0x1482A34
	|-ThreadSafeStore<StructMultiKey<object, object>, object>.Get
	|
	|-RVA: 0x1482B18 Offset: 0x147EB18 VA: 0x1482B18
	|-ThreadSafeStore<object, object>.Get
	|
	|-RVA: 0x1482C00 Offset: 0x147EC00 VA: 0x1482C00
	|-ThreadSafeStore<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Get
	*/
}

// Namespace: Newtonsoft.Json.Utilities
[NullableContext(1)]
[Nullable(0)]
[Extension]
internal static class TypeExtensions // TypeDefIndex: 6131
{
	// Methods

	[Extension]
	// RVA: 0x1948E24 Offset: 0x1944E24 VA: 0x1948E24
	public static MemberTypes MemberType(MemberInfo memberInfo) { }

	[Extension]
	// RVA: 0x194E35C Offset: 0x194A35C VA: 0x194E35C
	public static bool ContainsGenericParameters(Type type) { }

	[Extension]
	// RVA: 0x193A480 Offset: 0x1936480 VA: 0x193A480
	public static bool IsInterface(Type type) { }

	[Extension]
	// RVA: 0x1944508 Offset: 0x1940508 VA: 0x1944508
	public static bool IsGenericType(Type type) { }

	[Extension]
	// RVA: 0x193A494 Offset: 0x1936494 VA: 0x193A494
	public static bool IsGenericTypeDefinition(Type type) { }

	[Extension]
	// RVA: 0x194A350 Offset: 0x1946350 VA: 0x194A350
	public static Type BaseType(Type type) { }

	[Extension]
	// RVA: 0x194452C Offset: 0x194052C VA: 0x194452C
	public static Assembly Assembly(Type type) { }

	[Extension]
	// RVA: 0x1938570 Offset: 0x1934570 VA: 0x1938570
	public static bool IsEnum(Type type) { }

	[Extension]
	// RVA: 0x194A240 Offset: 0x1946240 VA: 0x194A240
	public static bool IsClass(Type type) { }

	[Extension]
	// RVA: 0x194E378 Offset: 0x194A378 VA: 0x194E378
	public static bool IsSealed(Type type) { }

	[Extension]
	// RVA: 0x193A4B0 Offset: 0x19364B0 VA: 0x193A4B0
	public static bool IsAbstract(Type type) { }

	[Extension]
	// RVA: 0x194E38C Offset: 0x194A38C VA: 0x194E38C
	public static bool IsVisible(Type type) { }

	[Extension]
	// RVA: 0x1949B04 Offset: 0x1945B04 VA: 0x1949B04
	public static bool IsValueType(Type type) { }

	[Extension]
	// RVA: 0x194E3A0 Offset: 0x194A3A0 VA: 0x194E3A0
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces, out Type match) { }

	[Extension]
	// RVA: 0x194E504 Offset: 0x194A504 VA: 0x194E504
	public static bool AssignableToTypeName(Type type, string fullTypeName, bool searchInterfaces) { }

	[Extension]
	// RVA: 0x194E51C Offset: 0x194A51C VA: 0x194E51C
	public static bool ImplementInterface(Type type, Type interfaceType) { }
}

// Namespace: Newtonsoft.Json.Utilities
internal static class ValidationUtils // TypeDefIndex: 6132
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x1936278 Offset: 0x1932278 VA: 0x1936278
	public static void ArgumentNotNull(object value, string parameterName) { }
}
