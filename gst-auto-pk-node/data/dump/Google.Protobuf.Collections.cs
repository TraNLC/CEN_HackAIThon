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

// Namespace: Google.Protobuf.Collections
public static class Lists // TypeDefIndex: 6566
{
	// Methods

	// RVA: -1 Offset: -1
	public static bool Equals<T>(List<T> left, List<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112D880 Offset: 0x1129880 VA: 0x112D880
	|-Lists.Equals<object>
	|
	|-RVA: 0x112D9E0 Offset: 0x11299E0 VA: 0x112D9E0
	|-Lists.Equals<uint>
	|
	|-RVA: 0x112DB40 Offset: 0x1129B40 VA: 0x112DB40
	|-Lists.Equals<ulong>
	|
	|-RVA: 0x112DCA0 Offset: 0x1129CA0 VA: 0x112DCA0
	|-Lists.Equals<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static int GetHashCode<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112DF14 Offset: 0x1129F14 VA: 0x112DF14
	|-Lists.GetHashCode<object>
	|
	|-RVA: 0x112E030 Offset: 0x112A030 VA: 0x112E030
	|-Lists.GetHashCode<uint>
	|
	|-RVA: 0x112E150 Offset: 0x112A150 VA: 0x112E150
	|-Lists.GetHashCode<ulong>
	|
	|-RVA: 0x112E26C Offset: 0x112A26C VA: 0x112E26C
	|-Lists.GetHashCode<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
private sealed class MapField.DictionaryEnumerator<TKey, TValue> : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 6567
{
	// Fields
	private readonly IEnumerator<KeyValuePair<TKey, TValue>> enumerator; // 0x0

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(IEnumerator<KeyValuePair<TKey, TValue>> enumerator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1579B6C Offset: 0x1575B6C VA: 0x1579B6C
	|-MapField.DictionaryEnumerator<int, object>..ctor
	|
	|-RVA: 0x157A848 Offset: 0x1576848 VA: 0x157A848
	|-MapField.DictionaryEnumerator<object, object>..ctor
	|
	|-RVA: 0x157B9B4 Offset: 0x15779B4 VA: 0x157B9B4
	|-MapField.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1579B9C Offset: 0x1575B9C VA: 0x1579B9C
	|-MapField.DictionaryEnumerator<int, object>.MoveNext
	|
	|-RVA: 0x157A878 Offset: 0x1576878 VA: 0x157A878
	|-MapField.DictionaryEnumerator<object, object>.MoveNext
	|
	|-RVA: 0x157B9E4 Offset: 0x15779E4 VA: 0x157B9E4
	|-MapField.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1579C3C Offset: 0x1575C3C VA: 0x1579C3C
	|-MapField.DictionaryEnumerator<int, object>.Reset
	|
	|-RVA: 0x157A918 Offset: 0x1576918 VA: 0x157A918
	|-MapField.DictionaryEnumerator<object, object>.Reset
	|
	|-RVA: 0x157BA84 Offset: 0x1577A84 VA: 0x157BA84
	|-MapField.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public object get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1579CE0 Offset: 0x1575CE0 VA: 0x1579CE0
	|-MapField.DictionaryEnumerator<int, object>.get_Current
	|
	|-RVA: 0x157A9BC Offset: 0x15769BC VA: 0x157A9BC
	|-MapField.DictionaryEnumerator<object, object>.get_Current
	|
	|-RVA: 0x157BB28 Offset: 0x1577B28 VA: 0x157BB28
	|-MapField.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public DictionaryEntry get_Entry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1579D5C Offset: 0x1575D5C VA: 0x1579D5C
	|-MapField.DictionaryEnumerator<int, object>.get_Entry
	|
	|-RVA: 0x157AA38 Offset: 0x1576A38 VA: 0x157AA38
	|-MapField.DictionaryEnumerator<object, object>.get_Entry
	|
	|-RVA: 0x157BBA8 Offset: 0x1577BA8 VA: 0x157BBA8
	|-MapField.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Entry
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1579DC4 Offset: 0x1575DC4 VA: 0x1579DC4
	|-MapField.DictionaryEnumerator<int, object>.get_Key
	|
	|-RVA: 0x157AAA0 Offset: 0x1576AA0 VA: 0x157AAA0
	|-MapField.DictionaryEnumerator<object, object>.get_Key
	|
	|-RVA: 0x157BC18 Offset: 0x1577C18 VA: 0x157BC18
	|-MapField.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public object get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1579E7C Offset: 0x1575E7C VA: 0x1579E7C
	|-MapField.DictionaryEnumerator<int, object>.get_Value
	|
	|-RVA: 0x157AB2C Offset: 0x1576B2C VA: 0x157AB2C
	|-MapField.DictionaryEnumerator<object, object>.get_Value
	|
	|-RVA: 0x157BDBC Offset: 0x1577DBC VA: 0x157BDBC
	|-MapField.DictionaryEnumerator<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Value
	*/
}

// Namespace: 
public sealed class MapField.Codec<TKey, TValue> // TypeDefIndex: 6568
{
	// Fields
	private readonly FieldCodec<TKey> keyCodec; // 0x0
	private readonly FieldCodec<TValue> valueCodec; // 0x0
	private readonly uint mapTag; // 0x0

	// Properties
	internal FieldCodec<TKey> KeyCodec { get; }
	internal FieldCodec<TValue> ValueCodec { get; }
	internal uint MapTag { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FieldCodec<TKey> keyCodec, FieldCodec<TValue> valueCodec, uint mapTag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E221C Offset: 0x14DE21C VA: 0x14E221C
	|-MapField.Codec<int, object>..ctor
	|
	|-RVA: 0x14E228C Offset: 0x14DE28C VA: 0x14E228C
	|-MapField.Codec<object, object>..ctor
	|
	|-RVA: 0x14E22FC Offset: 0x14DE2FC VA: 0x14E22FC
	|-MapField.Codec<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal FieldCodec<TKey> get_KeyCodec() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E2274 Offset: 0x14DE274 VA: 0x14E2274
	|-MapField.Codec<int, object>.get_KeyCodec
	|
	|-RVA: 0x14E22E4 Offset: 0x14DE2E4 VA: 0x14E22E4
	|-MapField.Codec<object, object>.get_KeyCodec
	|
	|-RVA: 0x14E2354 Offset: 0x14DE354 VA: 0x14E2354
	|-MapField.Codec<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_KeyCodec
	*/

	// RVA: -1 Offset: -1
	internal FieldCodec<TValue> get_ValueCodec() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E227C Offset: 0x14DE27C VA: 0x14E227C
	|-MapField.Codec<int, object>.get_ValueCodec
	|
	|-RVA: 0x14E22EC Offset: 0x14DE2EC VA: 0x14E22EC
	|-MapField.Codec<object, object>.get_ValueCodec
	|
	|-RVA: 0x14E235C Offset: 0x14DE35C VA: 0x14E235C
	|-MapField.Codec<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_ValueCodec
	*/

	// RVA: -1 Offset: -1
	internal uint get_MapTag() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E2284 Offset: 0x14DE284 VA: 0x14E2284
	|-MapField.Codec<int, object>.get_MapTag
	|
	|-RVA: 0x14E22F4 Offset: 0x14DE2F4 VA: 0x14E22F4
	|-MapField.Codec<object, object>.get_MapTag
	|
	|-RVA: 0x14E2364 Offset: 0x14DE364 VA: 0x14E2364
	|-MapField.Codec<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_MapTag
	*/
}

// Namespace: 
private class MapField.MapView<TKey, TValue, T> : ICollection<T>, IEnumerable<T>, IEnumerable, ICollection // TypeDefIndex: 6569
{
	// Fields
	private readonly MapField<TKey, TValue> parent; // 0x0
	private readonly Func<KeyValuePair<TKey, TValue>, T> projection; // 0x0
	private readonly Func<T, bool> containsCheck; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(MapField<TKey, TValue> parent, Func<KeyValuePair<TKey, TValue>, T> projection, Func<T, bool> containsCheck) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A2198 Offset: 0x139E198 VA: 0x13A2198
	|-MapField.MapView<int, object, object>..ctor
	|
	|-RVA: 0x13A2A04 Offset: 0x139EA04 VA: 0x13A2A04
	|-MapField.MapView<object, object, object>..ctor
	|
	|-RVA: 0x13A3270 Offset: 0x139F270 VA: 0x13A3270
	|-MapField.MapView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A21F8 Offset: 0x139E1F8 VA: 0x13A21F8
	|-MapField.MapView<int, object, object>.get_Count
	|
	|-RVA: 0x13A2A64 Offset: 0x139EA64 VA: 0x13A2A64
	|-MapField.MapView<object, object, object>.get_Count
	|
	|-RVA: 0x13A32D0 Offset: 0x139F2D0 VA: 0x13A32D0
	|-MapField.MapView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A221C Offset: 0x139E21C VA: 0x13A221C
	|-MapField.MapView<int, object, object>.get_IsReadOnly
	|
	|-RVA: 0x13A2A88 Offset: 0x139EA88 VA: 0x13A2A88
	|-MapField.MapView<object, object, object>.get_IsReadOnly
	|
	|-RVA: 0x13A32F4 Offset: 0x139F2F4 VA: 0x13A32F4
	|-MapField.MapView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public bool get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A2224 Offset: 0x139E224 VA: 0x13A2224
	|-MapField.MapView<int, object, object>.get_IsSynchronized
	|
	|-RVA: 0x13A2A90 Offset: 0x139EA90 VA: 0x13A2A90
	|-MapField.MapView<object, object, object>.get_IsSynchronized
	|
	|-RVA: 0x13A32FC Offset: 0x139F2FC VA: 0x13A32FC
	|-MapField.MapView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public object get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A222C Offset: 0x139E22C VA: 0x13A222C
	|-MapField.MapView<int, object, object>.get_SyncRoot
	|
	|-RVA: 0x13A2A98 Offset: 0x139EA98 VA: 0x13A2A98
	|-MapField.MapView<object, object, object>.get_SyncRoot
	|
	|-RVA: 0x13A3304 Offset: 0x139F304 VA: 0x13A3304
	|-MapField.MapView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A2234 Offset: 0x139E234 VA: 0x13A2234
	|-MapField.MapView<int, object, object>.Add
	|
	|-RVA: 0x13A2AA0 Offset: 0x139EAA0 VA: 0x13A2AA0
	|-MapField.MapView<object, object, object>.Add
	|
	|-RVA: 0x13A330C Offset: 0x139F30C VA: 0x13A330C
	|-MapField.MapView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A2268 Offset: 0x139E268 VA: 0x13A2268
	|-MapField.MapView<int, object, object>.Clear
	|
	|-RVA: 0x13A2AD4 Offset: 0x139EAD4 VA: 0x13A2AD4
	|-MapField.MapView<object, object, object>.Clear
	|
	|-RVA: 0x13A3340 Offset: 0x139F340 VA: 0x13A3340
	|-MapField.MapView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A229C Offset: 0x139E29C VA: 0x13A229C
	|-MapField.MapView<int, object, object>.Contains
	|
	|-RVA: 0x13A2B08 Offset: 0x139EB08 VA: 0x13A2B08
	|-MapField.MapView<object, object, object>.Contains
	|
	|-RVA: 0x13A3374 Offset: 0x139F374 VA: 0x13A3374
	|-MapField.MapView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A22BC Offset: 0x139E2BC VA: 0x13A22BC
	|-MapField.MapView<int, object, object>.CopyTo
	|
	|-RVA: 0x13A2B28 Offset: 0x139EB28 VA: 0x13A2B28
	|-MapField.MapView<object, object, object>.CopyTo
	|
	|-RVA: 0x13A3454 Offset: 0x139F454 VA: 0x13A3454
	|-MapField.MapView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A25E4 Offset: 0x139E5E4 VA: 0x13A25E4
	|-MapField.MapView<int, object, object>.GetEnumerator
	|
	|-RVA: 0x13A2E50 Offset: 0x139EE50 VA: 0x13A2E50
	|-MapField.MapView<object, object, object>.GetEnumerator
	|
	|-RVA: 0x13A38D8 Offset: 0x139F8D8 VA: 0x13A38D8
	|-MapField.MapView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A26A0 Offset: 0x139E6A0 VA: 0x13A26A0
	|-MapField.MapView<int, object, object>.Remove
	|
	|-RVA: 0x13A2F0C Offset: 0x139EF0C VA: 0x13A2F0C
	|-MapField.MapView<object, object, object>.Remove
	|
	|-RVA: 0x13A3998 Offset: 0x139F998 VA: 0x13A3998
	|-MapField.MapView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A26D4 Offset: 0x139E6D4 VA: 0x13A26D4
	|-MapField.MapView<int, object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13A2F40 Offset: 0x139EF40 VA: 0x13A2F40
	|-MapField.MapView<object, object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x13A39CC Offset: 0x139F9CC VA: 0x13A39CC
	|-MapField.MapView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public void CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13A26E4 Offset: 0x139E6E4 VA: 0x13A26E4
	|-MapField.MapView<int, object, object>.CopyTo
	|
	|-RVA: 0x13A2F50 Offset: 0x139EF50 VA: 0x13A2F50
	|-MapField.MapView<object, object, object>.CopyTo
	|
	|-RVA: 0x13A39E0 Offset: 0x139F9E0 VA: 0x13A39E0
	|-MapField.MapView<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/
}

// Namespace: 
private sealed class MapField.MapFieldDebugView<TKey, TValue> // TypeDefIndex: 6570
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MapField.<>c<TKey, TValue> // TypeDefIndex: 6571
{
	// Fields
	public static readonly MapField.<>c<TKey, TValue> <>9; // 0x0
	public static Func<KeyValuePair<TKey, TValue>, TValue> <>9__16_0; // 0x0
	public static Comparison<KeyValuePair<TKey, TValue>> <>9__36_0; // 0x0
	public static Func<KeyValuePair<TKey, TValue>, DictionaryEntry> <>9__46_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1152188 Offset: 0x114E188 VA: 0x1152188
	|-MapField.<>c<int, object>..cctor
	|
	|-RVA: 0x11528C8 Offset: 0x114E8C8 VA: 0x11528C8
	|-MapField.<>c<object, object>..cctor
	|
	|-RVA: 0x11536A4 Offset: 0x114F6A4 VA: 0x11536A4
	|-MapField.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1152260 Offset: 0x114E260 VA: 0x1152260
	|-MapField.<>c<int, object>..ctor
	|
	|-RVA: 0x11529A0 Offset: 0x114E9A0 VA: 0x11529A0
	|-MapField.<>c<object, object>..ctor
	|
	|-RVA: 0x11537B0 Offset: 0x114F7B0 VA: 0x11537B0
	|-MapField.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TValue <get_Values>b__16_0(KeyValuePair<TKey, TValue> pair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1152268 Offset: 0x114E268 VA: 0x1152268
	|-MapField.<>c<int, object>.<get_Values>b__16_0
	|
	|-RVA: 0x11529A8 Offset: 0x114E9A8 VA: 0x11529A8
	|-MapField.<>c<object, object>.<get_Values>b__16_0
	|
	|-RVA: 0x11537B8 Offset: 0x114F7B8 VA: 0x11537B8
	|-MapField.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<get_Values>b__16_0
	*/

	// RVA: -1 Offset: -1
	internal int <GetSortedListCopy>b__36_0(KeyValuePair<TKey, TValue> pair1, KeyValuePair<TKey, TValue> pair2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1152270 Offset: 0x114E270 VA: 0x1152270
	|-MapField.<>c<int, object>.<GetSortedListCopy>b__36_0
	|
	|-RVA: 0x11529B0 Offset: 0x114E9B0 VA: 0x11529B0
	|-MapField.<>c<object, object>.<GetSortedListCopy>b__36_0
	|
	|-RVA: 0x1153858 Offset: 0x114F858 VA: 0x1153858
	|-MapField.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<GetSortedListCopy>b__36_0
	*/

	// RVA: -1 Offset: -1
	internal DictionaryEntry <System.Collections.ICollection.CopyTo>b__46_0(KeyValuePair<TKey, TValue> pair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11523FC Offset: 0x114E3FC VA: 0x11523FC
	|-MapField.<>c<int, object>.<System.Collections.ICollection.CopyTo>b__46_0
	|
	|-RVA: 0x1152B14 Offset: 0x114EB14 VA: 0x1152B14
	|-MapField.<>c<object, object>.<System.Collections.ICollection.CopyTo>b__46_0
	|
	|-RVA: 0x1153C1C Offset: 0x114FC1C VA: 0x1153C1C
	|-MapField.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<System.Collections.ICollection.CopyTo>b__46_0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class MapField.<>c__DisplayClass7_0<TKey, TValue> // TypeDefIndex: 6572
{
	// Fields
	public TValue value; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115BFBC Offset: 0x1157FBC VA: 0x115BFBC
	|-MapField.<>c__DisplayClass7_0<int, object>..ctor
	|
	|-RVA: 0x115C054 Offset: 0x1158054 VA: 0x115C054
	|-MapField.<>c__DisplayClass7_0<object, object>..ctor
	|
	|-RVA: 0x115C0EC Offset: 0x11580EC VA: 0x115C0EC
	|-MapField.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <ContainsValue>b__0(KeyValuePair<TKey, TValue> pair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115BFC4 Offset: 0x1157FC4 VA: 0x115BFC4
	|-MapField.<>c__DisplayClass7_0<int, object>.<ContainsValue>b__0
	|
	|-RVA: 0x115C05C Offset: 0x115805C VA: 0x115C05C
	|-MapField.<>c__DisplayClass7_0<object, object>.<ContainsValue>b__0
	|
	|-RVA: 0x115C0F4 Offset: 0x11580F4 VA: 0x115C0F4
	|-MapField.<>c__DisplayClass7_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<ContainsValue>b__0
	*/
}

// Namespace: Google.Protobuf.Collections
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(MapField.MapFieldDebugView<TKey, TValue>))]
public sealed class MapField<TKey, TValue> : IDeepCloneable<MapField<TKey, TValue>>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IEquatable<MapField<TKey, TValue>>, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 6573
{
	// Fields
	private static readonly EqualityComparer<TValue> ValueEqualityComparer; // 0x0
	private static readonly EqualityComparer<TKey> KeyEqualityComparer; // 0x0
	private readonly Dictionary<TKey, LinkedListNode<KeyValuePair<TKey, TValue>>> map; // 0x0
	private readonly LinkedList<KeyValuePair<TKey, TValue>> list; // 0x0

	// Properties
	public TValue Item { get; set; }
	public ICollection<TValue> Values { get; }
	public int Count { get; }
	public bool IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public MapField<TKey, TValue> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1396FFC Offset: 0x1392FFC VA: 0x1396FFC
	|-MapField<int, object>.Clone
	|
	|-RVA: 0x1399DD8 Offset: 0x1395DD8 VA: 0x1399DD8
	|-MapField<object, object>.Clone
	|
	|-RVA: 0x139CC04 Offset: 0x1398C04 VA: 0x139CC04
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1397340 Offset: 0x1393340 VA: 0x1397340
	|-MapField<int, object>.Add
	|
	|-RVA: 0x139A118 Offset: 0x1396118 VA: 0x139A118
	|-MapField<object, object>.Add
	|
	|-RVA: 0x139D20C Offset: 0x139920C VA: 0x139D20C
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13973E8 Offset: 0x13933E8 VA: 0x13973E8
	|-MapField<int, object>.ContainsKey
	|
	|-RVA: 0x139A1C0 Offset: 0x13961C0 VA: 0x139A1C0
	|-MapField<object, object>.ContainsKey
	|
	|-RVA: 0x139D400 Offset: 0x1399400 VA: 0x139D400
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	private bool ContainsValue(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x139746C Offset: 0x139346C VA: 0x139746C
	|-MapField<int, object>.ContainsValue
	|
	|-RVA: 0x139A244 Offset: 0x1396244 VA: 0x139A244
	|-MapField<object, object>.ContainsValue
	|
	|-RVA: 0x139D598 Offset: 0x1399598 VA: 0x139D598
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsValue
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1397540 Offset: 0x1393540 VA: 0x1397540
	|-MapField<int, object>.Remove
	|
	|-RVA: 0x139A318 Offset: 0x1396318 VA: 0x139A318
	|-MapField<object, object>.Remove
	|
	|-RVA: 0x139D710 Offset: 0x1399710 VA: 0x139D710
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1397620 Offset: 0x1393620 VA: 0x1397620
	|-MapField<int, object>.TryGetValue
	|
	|-RVA: 0x139A3F8 Offset: 0x13963F8 VA: 0x139A3F8
	|-MapField<object, object>.TryGetValue
	|
	|-RVA: 0x139D95C Offset: 0x139995C VA: 0x139D95C
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1397688 Offset: 0x1393688 VA: 0x1397688
	|-MapField<int, object>.get_Item
	|
	|-RVA: 0x139A460 Offset: 0x1396460 VA: 0x139A460
	|-MapField<object, object>.get_Item
	|
	|-RVA: 0x139DB74 Offset: 0x1399B74 VA: 0x139DB74
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1397748 Offset: 0x1393748 VA: 0x1397748
	|-MapField<int, object>.set_Item
	|
	|-RVA: 0x139A520 Offset: 0x1396520 VA: 0x139A520
	|-MapField<object, object>.set_Item
	|
	|-RVA: 0x139DD70 Offset: 0x1399D70 VA: 0x139DD70
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13978A4 Offset: 0x13938A4 VA: 0x13978A4
	|-MapField<int, object>.get_Values
	|
	|-RVA: 0x139A678 Offset: 0x1396678 VA: 0x139A678
	|-MapField<object, object>.get_Values
	|
	|-RVA: 0x139E1BC Offset: 0x139A1BC VA: 0x139E1BC
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1
	public void Add(IDictionary<TKey, TValue> entries) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1397A78 Offset: 0x1393A78 VA: 0x1397A78
	|-MapField<int, object>.Add
	|
	|-RVA: 0x139A84C Offset: 0x139684C VA: 0x139A84C
	|-MapField<object, object>.Add
	|
	|-RVA: 0x139E3A8 Offset: 0x139A3A8 VA: 0x139E3A8
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void MergeFrom(IDictionary<TKey, TValue> entries) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1397D78 Offset: 0x1393D78 VA: 0x1397D78
	|-MapField<int, object>.MergeFrom
	|
	|-RVA: 0x139AB4C Offset: 0x1396B4C VA: 0x139AB4C
	|-MapField<object, object>.MergeFrom
	|
	|-RVA: 0x139E860 Offset: 0x139A860 VA: 0x139E860
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MergeFrom
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1398078 Offset: 0x1394078 VA: 0x1398078
	|-MapField<int, object>.GetEnumerator
	|
	|-RVA: 0x139AE4C Offset: 0x1396E4C VA: 0x139AE4C
	|-MapField<object, object>.GetEnumerator
	|
	|-RVA: 0x139ED18 Offset: 0x139AD18 VA: 0x139ED18
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13980D4 Offset: 0x13940D4 VA: 0x13980D4
	|-MapField<int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x139AEA8 Offset: 0x1396EA8 VA: 0x139AEA8
	|-MapField<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x139EDD4 Offset: 0x139ADD4 VA: 0x139EDD4
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13980E4 Offset: 0x13940E4 VA: 0x13980E4
	|-MapField<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x139AEB8 Offset: 0x1396EB8 VA: 0x139AEB8
	|-MapField<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x139EDE8 Offset: 0x139ADE8 VA: 0x139EDE8
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13980F4 Offset: 0x13940F4 VA: 0x13980F4
	|-MapField<int, object>.Clear
	|
	|-RVA: 0x139AEC8 Offset: 0x1396EC8 VA: 0x139AEC8
	|-MapField<object, object>.Clear
	|
	|-RVA: 0x139EF14 Offset: 0x139AF14 VA: 0x139EF14
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1398140 Offset: 0x1394140 VA: 0x1398140
	|-MapField<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x139AF14 Offset: 0x1396F14 VA: 0x139AF14
	|-MapField<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x139EF68 Offset: 0x139AF68 VA: 0x139EF68
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13981EC Offset: 0x13941EC VA: 0x13981EC
	|-MapField<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x139AFC0 Offset: 0x1396FC0 VA: 0x139AFC0
	|-MapField<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x139F188 Offset: 0x139B188 VA: 0x139F188
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x139820C Offset: 0x139420C VA: 0x139820C
	|-MapField<int, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x139AFE0 Offset: 0x1396FE0 VA: 0x139AFE0
	|-MapField<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x139F1AC Offset: 0x139B1AC VA: 0x139F1AC
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 39
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13982DC Offset: 0x13942DC VA: 0x13982DC
	|-MapField<int, object>.get_Count
	|
	|-RVA: 0x139B104 Offset: 0x1397104 VA: 0x139B104
	|-MapField<object, object>.get_Count
	|
	|-RVA: 0x139F578 Offset: 0x139B578 VA: 0x139F578
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13982F4 Offset: 0x13942F4 VA: 0x13982F4
	|-MapField<int, object>.get_IsReadOnly
	|
	|-RVA: 0x139B11C Offset: 0x139711C VA: 0x139B11C
	|-MapField<object, object>.get_IsReadOnly
	|
	|-RVA: 0x139F59C Offset: 0x139B59C VA: 0x139F59C
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13982FC Offset: 0x13942FC VA: 0x13982FC
	|-MapField<int, object>.Equals
	|
	|-RVA: 0x139B124 Offset: 0x1397124 VA: 0x139B124
	|-MapField<object, object>.Equals
	|
	|-RVA: 0x139F5A4 Offset: 0x139B5A4 VA: 0x139F5A4
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1398368 Offset: 0x1394368 VA: 0x1398368
	|-MapField<int, object>.GetHashCode
	|
	|-RVA: 0x139B190 Offset: 0x1397190 VA: 0x139B190
	|-MapField<object, object>.GetHashCode
	|
	|-RVA: 0x139F628 Offset: 0x139B628 VA: 0x139F628
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 21
	public bool Equals(MapField<TKey, TValue> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x139855C Offset: 0x139455C VA: 0x139855C
	|-MapField<int, object>.Equals
	|
	|-RVA: 0x139B380 Offset: 0x1397380 VA: 0x139B380
	|-MapField<object, object>.Equals
	|
	|-RVA: 0x139FADC Offset: 0x139BADC VA: 0x139FADC
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public void AddEntriesFrom(ref ParseContext ctx, MapField.Codec<TKey, TValue> codec) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1398898 Offset: 0x1394898 VA: 0x1398898
	|-MapField<int, object>.AddEntriesFrom
	|
	|-RVA: 0x139B6BC Offset: 0x13976BC VA: 0x139B6BC
	|-MapField<object, object>.AddEntriesFrom
	|
	|-RVA: 0x13A0050 Offset: 0x139C050 VA: 0x13A0050
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddEntriesFrom
	*/

	// RVA: -1 Offset: -1
	internal IEnumerable<KeyValuePair<TKey, TValue>> GetSortedListCopy(IEnumerable<KeyValuePair<TKey, TValue>> listToSort) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1398988 Offset: 0x1394988 VA: 0x1398988
	|-MapField<int, object>.GetSortedListCopy
	|
	|-RVA: 0x139B7AC Offset: 0x13977AC VA: 0x139B7AC
	|-MapField<object, object>.GetSortedListCopy
	|
	|-RVA: 0x13A02C8 Offset: 0x139C2C8 VA: 0x13A02C8
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetSortedListCopy
	*/

	// RVA: -1 Offset: -1
	public void WriteTo(ref WriteContext ctx, MapField.Codec<TKey, TValue> codec) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1398B3C Offset: 0x1394B3C VA: 0x1398B3C
	|-MapField<int, object>.WriteTo
	|
	|-RVA: 0x139B960 Offset: 0x1397960 VA: 0x139B960
	|-MapField<object, object>.WriteTo
	|
	|-RVA: 0x13A0488 Offset: 0x139C488 VA: 0x13A0488
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.WriteTo
	*/

	// RVA: -1 Offset: -1
	private void WriteTo(ref WriteContext ctx, MapField.Codec<TKey, TValue> codec, IEnumerable<KeyValuePair<TKey, TValue>> listKvp) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1398BB4 Offset: 0x1394BB4 VA: 0x1398BB4
	|-MapField<int, object>.WriteTo
	|
	|-RVA: 0x139B9D8 Offset: 0x13979D8 VA: 0x139B9D8
	|-MapField<object, object>.WriteTo
	|
	|-RVA: 0x13A0510 Offset: 0x139C510 VA: 0x13A0510
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.WriteTo
	*/

	// RVA: -1 Offset: -1
	public int CalculateSize(MapField.Codec<TKey, TValue> codec) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1398F7C Offset: 0x1394F7C VA: 0x1398F7C
	|-MapField<int, object>.CalculateSize
	|
	|-RVA: 0x139BDA0 Offset: 0x1397DA0 VA: 0x139BDA0
	|-MapField<object, object>.CalculateSize
	|
	|-RVA: 0x13A0B48 Offset: 0x139CB48 VA: 0x13A0B48
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CalculateSize
	*/

	// RVA: -1 Offset: -1
	private static int CalculateEntrySize(MapField.Codec<TKey, TValue> codec, KeyValuePair<TKey, TValue> entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1399178 Offset: 0x1395178 VA: 0x1399178
	|-MapField<int, object>.CalculateEntrySize
	|
	|-RVA: 0x139BF9C Offset: 0x1397F9C VA: 0x139BF9C
	|-MapField<object, object>.CalculateEntrySize
	|
	|-RVA: 0x13A0F18 Offset: 0x139CF18 VA: 0x13A0F18
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CalculateEntrySize
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x139926C Offset: 0x139526C VA: 0x139926C
	|-MapField<int, object>.ToString
	|
	|-RVA: 0x139C090 Offset: 0x1398090 VA: 0x139C090
	|-MapField<object, object>.ToString
	|
	|-RVA: 0x13A1304 Offset: 0x139D304 VA: 0x13A1304
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1399354 Offset: 0x1395354 VA: 0x1399354
	|-MapField<int, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x139C178 Offset: 0x1398178 VA: 0x139C178
	|-MapField<object, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x13A13EC Offset: 0x139D3EC VA: 0x13A13EC
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1399430 Offset: 0x1395430 VA: 0x1399430
	|-MapField<int, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x139C258 Offset: 0x1398258 VA: 0x139C258
	|-MapField<object, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x13A1538 Offset: 0x139D538 VA: 0x13A1538
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13994EC Offset: 0x13954EC VA: 0x13994EC
	|-MapField<int, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x139C31C Offset: 0x139831C VA: 0x139C31C
	|-MapField<object, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x13A1674 Offset: 0x139D674 VA: 0x13A1674
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1399560 Offset: 0x1395560 VA: 0x1399560
	|-MapField<int, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x139C390 Offset: 0x1398390 VA: 0x139C390
	|-MapField<object, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x13A16F0 Offset: 0x139D6F0 VA: 0x13A16F0
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1399680 Offset: 0x1395680 VA: 0x1399680
	|-MapField<int, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x139C4AC Offset: 0x13984AC VA: 0x139C4AC
	|-MapField<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x13A1880 Offset: 0x139D880 VA: 0x13A1880
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13998AC Offset: 0x13958AC VA: 0x13998AC
	|-MapField<int, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x139C6D8 Offset: 0x13986D8 VA: 0x139C6D8
	|-MapField<object, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x13A1AB4 Offset: 0x139DAB4 VA: 0x13A1AB4
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1399928 Offset: 0x1395928 VA: 0x1399928
	|-MapField<int, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x139C754 Offset: 0x1398754 VA: 0x139C754
	|-MapField<object, object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x13A1B34 Offset: 0x139DB34 VA: 0x13A1B34
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 33
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1399930 Offset: 0x1395930 VA: 0x1399930
	|-MapField<int, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x139C75C Offset: 0x139875C VA: 0x139C75C
	|-MapField<object, object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x13A1B3C Offset: 0x139DB3C VA: 0x13A1B3C
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1399934 Offset: 0x1395934 VA: 0x1399934
	|-MapField<int, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x139C760 Offset: 0x1398760 VA: 0x139C760
	|-MapField<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x13A1B40 Offset: 0x139DB40 VA: 0x13A1B40
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1399A50 Offset: 0x1395A50 VA: 0x1399A50
	|-MapField<int, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x139C878 Offset: 0x1398878 VA: 0x139C878
	|-MapField<object, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x13A1D2C Offset: 0x139DD2C VA: 0x13A1D2C
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 38
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1399B2C Offset: 0x1395B2C VA: 0x1399B2C
	|-MapField<int, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x139C958 Offset: 0x1398958 VA: 0x139C958
	|-MapField<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x13A1E78 Offset: 0x139DE78 VA: 0x13A1E78
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1399B3C Offset: 0x1395B3C VA: 0x1399B3C
	|-MapField<int, object>..ctor
	|
	|-RVA: 0x139C968 Offset: 0x1398968 VA: 0x139C968
	|-MapField<object, object>..ctor
	|
	|-RVA: 0x13A1E8C Offset: 0x139DE8C VA: 0x13A1E8C
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1399C58 Offset: 0x1395C58 VA: 0x1399C58
	|-MapField<int, object>..cctor
	|
	|-RVA: 0x139CA84 Offset: 0x1398A84 VA: 0x139CA84
	|-MapField<object, object>..cctor
	|
	|-RVA: 0x13A1FB0 Offset: 0x139DFB0 VA: 0x13A1FB0
	|-MapField<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
private class ProtobufEqualityComparers.BitwiseDoubleEqualityComparerImpl : EqualityComparer<double> // TypeDefIndex: 6574
{
	// Methods

	// RVA: 0x1632024 Offset: 0x162E024 VA: 0x1632024 Slot: 8
	public override bool Equals(double x, double y) { }

	// RVA: 0x1632038 Offset: 0x162E038 VA: 0x1632038 Slot: 9
	public override int GetHashCode(double obj) { }

	// RVA: 0x1631F04 Offset: 0x162DF04 VA: 0x1631F04
	public void .ctor() { }
}

// Namespace: 
private class ProtobufEqualityComparers.BitwiseSingleEqualityComparerImpl : EqualityComparer<float> // TypeDefIndex: 6575
{
	// Methods

	// RVA: 0x1632054 Offset: 0x162E054 VA: 0x1632054 Slot: 8
	public override bool Equals(float x, float y) { }

	// RVA: 0x1632070 Offset: 0x162E070 VA: 0x1632070 Slot: 9
	public override int GetHashCode(float obj) { }

	// RVA: 0x1631F4C Offset: 0x162DF4C VA: 0x1631F4C
	public void .ctor() { }
}

// Namespace: 
private class ProtobufEqualityComparers.BitwiseNullableDoubleEqualityComparerImpl : EqualityComparer<Nullable<double>> // TypeDefIndex: 6576
{
	// Methods

	// RVA: 0x1632090 Offset: 0x162E090 VA: 0x1632090 Slot: 8
	public override bool Equals(Nullable<double> x, Nullable<double> y) { }

	// RVA: 0x16321B4 Offset: 0x162E1B4 VA: 0x16321B4 Slot: 9
	public override int GetHashCode(Nullable<double> obj) { }

	// RVA: 0x1631F94 Offset: 0x162DF94 VA: 0x1631F94
	public void .ctor() { }
}

// Namespace: 
private class ProtobufEqualityComparers.BitwiseNullableSingleEqualityComparerImpl : EqualityComparer<Nullable<float>> // TypeDefIndex: 6577
{
	// Methods

	// RVA: 0x16322A4 Offset: 0x162E2A4 VA: 0x16322A4 Slot: 8
	public override bool Equals(Nullable<float> x, Nullable<float> y) { }

	// RVA: 0x16323C8 Offset: 0x162E3C8 VA: 0x16323C8 Slot: 9
	public override int GetHashCode(Nullable<float> obj) { }

	// RVA: 0x1631FDC Offset: 0x162DFDC VA: 0x1631FDC
	public void .ctor() { }
}

// Namespace: Google.Protobuf.Collections
public static class ProtobufEqualityComparers // TypeDefIndex: 6578
{
	// Fields
	[CompilerGenerated]
	private static readonly EqualityComparer<double> <BitwiseDoubleEqualityComparer>k__BackingField; // 0x0
	[CompilerGenerated]
	private static readonly EqualityComparer<float> <BitwiseSingleEqualityComparer>k__BackingField; // 0x8
	[CompilerGenerated]
	private static readonly EqualityComparer<Nullable<double>> <BitwiseNullableDoubleEqualityComparer>k__BackingField; // 0x10
	[CompilerGenerated]
	private static readonly EqualityComparer<Nullable<float>> <BitwiseNullableSingleEqualityComparer>k__BackingField; // 0x18

	// Properties
	public static EqualityComparer<double> BitwiseDoubleEqualityComparer { get; }
	public static EqualityComparer<float> BitwiseSingleEqualityComparer { get; }
	public static EqualityComparer<Nullable<double>> BitwiseNullableDoubleEqualityComparer { get; }
	public static EqualityComparer<Nullable<float>> BitwiseNullableSingleEqualityComparer { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static EqualityComparer<T> GetEqualityComparer<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113CE48 Offset: 0x1138E48 VA: 0x113CE48
	|-ProtobufEqualityComparers.GetEqualityComparer<int>
	|
	|-RVA: 0x113D1D0 Offset: 0x11391D0 VA: 0x113D1D0
	|-ProtobufEqualityComparers.GetEqualityComparer<Int32Enum>
	|
	|-RVA: 0x113D558 Offset: 0x1139558 VA: 0x113D558
	|-ProtobufEqualityComparers.GetEqualityComparer<long>
	|
	|-RVA: 0x113D8E0 Offset: 0x11398E0 VA: 0x113D8E0
	|-ProtobufEqualityComparers.GetEqualityComparer<object>
	|
	|-RVA: 0x113DC68 Offset: 0x1139C68 VA: 0x113DC68
	|-ProtobufEqualityComparers.GetEqualityComparer<__Il2CppFullySharedGenericType>
	*/

	[CompilerGenerated]
	// RVA: 0x1631C74 Offset: 0x162DC74 VA: 0x1631C74
	public static EqualityComparer<double> get_BitwiseDoubleEqualityComparer() { }

	[CompilerGenerated]
	// RVA: 0x1631CCC Offset: 0x162DCCC VA: 0x1631CCC
	public static EqualityComparer<float> get_BitwiseSingleEqualityComparer() { }

	[CompilerGenerated]
	// RVA: 0x1631D24 Offset: 0x162DD24 VA: 0x1631D24
	public static EqualityComparer<Nullable<double>> get_BitwiseNullableDoubleEqualityComparer() { }

	[CompilerGenerated]
	// RVA: 0x1631D7C Offset: 0x162DD7C VA: 0x1631D7C
	public static EqualityComparer<Nullable<float>> get_BitwiseNullableSingleEqualityComparer() { }

	// RVA: 0x1631DD4 Offset: 0x162DDD4 VA: 0x1631DD4
	private static void .cctor() { }
}

// Namespace: 
private sealed class RepeatedField.RepeatedFieldDebugView<T> // TypeDefIndex: 6579
{}

// Namespace: 
[CompilerGenerated]
private sealed class RepeatedField.<GetEnumerator>d__29<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 6580
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	public RepeatedField<T> <>4__this; // 0x0
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
	|-RVA: 0x1165138 Offset: 0x1161138 VA: 0x1165138
	|-RepeatedField.<GetEnumerator>d__29<int>..ctor
	|
	|-RVA: 0x1165254 Offset: 0x1161254 VA: 0x1165254
	|-RepeatedField.<GetEnumerator>d__29<Int32Enum>..ctor
	|
	|-RVA: 0x1165370 Offset: 0x1161370 VA: 0x1165370
	|-RepeatedField.<GetEnumerator>d__29<long>..ctor
	|
	|-RVA: 0x116548C Offset: 0x116148C VA: 0x116548C
	|-RepeatedField.<GetEnumerator>d__29<object>..ctor
	|
	|-RVA: 0x1165594 Offset: 0x1161594 VA: 0x1165594
	|-RepeatedField.<GetEnumerator>d__29<__Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1165160 Offset: 0x1161160 VA: 0x1165160
	|-RepeatedField.<GetEnumerator>d__29<int>.System.IDisposable.Dispose
	|
	|-RVA: 0x116527C Offset: 0x116127C VA: 0x116527C
	|-RepeatedField.<GetEnumerator>d__29<Int32Enum>.System.IDisposable.Dispose
	|
	|-RVA: 0x1165398 Offset: 0x1161398 VA: 0x1165398
	|-RepeatedField.<GetEnumerator>d__29<long>.System.IDisposable.Dispose
	|
	|-RVA: 0x11654B4 Offset: 0x11614B4 VA: 0x11654B4
	|-RepeatedField.<GetEnumerator>d__29<object>.System.IDisposable.Dispose
	|
	|-RVA: 0x11655D4 Offset: 0x11615D4 VA: 0x11655D4
	|-RepeatedField.<GetEnumerator>d__29<__Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1165164 Offset: 0x1161164 VA: 0x1165164
	|-RepeatedField.<GetEnumerator>d__29<int>.MoveNext
	|
	|-RVA: 0x1165280 Offset: 0x1161280 VA: 0x1165280
	|-RepeatedField.<GetEnumerator>d__29<Int32Enum>.MoveNext
	|
	|-RVA: 0x116539C Offset: 0x116139C VA: 0x116539C
	|-RepeatedField.<GetEnumerator>d__29<long>.MoveNext
	|
	|-RVA: 0x11654B8 Offset: 0x11614B8 VA: 0x11654B8
	|-RepeatedField.<GetEnumerator>d__29<object>.MoveNext
	|
	|-RVA: 0x11655D8 Offset: 0x11615D8 VA: 0x11655D8
	|-RepeatedField.<GetEnumerator>d__29<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11651F0 Offset: 0x11611F0 VA: 0x11651F0
	|-RepeatedField.<GetEnumerator>d__29<int>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x116530C Offset: 0x116130C VA: 0x116530C
	|-RepeatedField.<GetEnumerator>d__29<Int32Enum>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x116542C Offset: 0x116142C VA: 0x116542C
	|-RepeatedField.<GetEnumerator>d__29<long>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x1165550 Offset: 0x1161550 VA: 0x1165550
	|-RepeatedField.<GetEnumerator>d__29<object>.System.Collections.Generic.IEnumerator<T>.get_Current
	|
	|-RVA: 0x1165820 Offset: 0x1161820 VA: 0x1165820
	|-RepeatedField.<GetEnumerator>d__29<__Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<T>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11651F8 Offset: 0x11611F8 VA: 0x11651F8
	|-RepeatedField.<GetEnumerator>d__29<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1165314 Offset: 0x1161314 VA: 0x1165314
	|-RepeatedField.<GetEnumerator>d__29<Int32Enum>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1165434 Offset: 0x1161434 VA: 0x1165434
	|-RepeatedField.<GetEnumerator>d__29<long>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1165558 Offset: 0x1161558 VA: 0x1165558
	|-RepeatedField.<GetEnumerator>d__29<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1165864 Offset: 0x1161864 VA: 0x1165864
	|-RepeatedField.<GetEnumerator>d__29<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116522C Offset: 0x116122C VA: 0x116522C
	|-RepeatedField.<GetEnumerator>d__29<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1165348 Offset: 0x1161348 VA: 0x1165348
	|-RepeatedField.<GetEnumerator>d__29<Int32Enum>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1165468 Offset: 0x1161468 VA: 0x1165468
	|-RepeatedField.<GetEnumerator>d__29<long>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x116558C Offset: 0x116158C VA: 0x116558C
	|-RepeatedField.<GetEnumerator>d__29<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1165898 Offset: 0x1161898 VA: 0x1165898
	|-RepeatedField.<GetEnumerator>d__29<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: Google.Protobuf.Collections
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(RepeatedField.RepeatedFieldDebugView<T>))]
public sealed class RepeatedField<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IDeepCloneable<RepeatedField<T>>, IEquatable<RepeatedField<T>>, IReadOnlyList<T>, IReadOnlyCollection<T> // TypeDefIndex: 6581
{
	// Fields
	private static readonly EqualityComparer<T> EqualityComparer; // 0x0
	private static readonly T[] EmptyArray; // 0x0
	private const int MinArraySize = 8;
	private T[] array; // 0x0
	private int count; // 0x0

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 33
	public RepeatedField<T> Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448A68 Offset: 0x1444A68 VA: 0x1448A68
	|-RepeatedField<int>.Clone
	|
	|-RVA: 0x144AC58 Offset: 0x1446C58 VA: 0x144AC58
	|-RepeatedField<Int32Enum>.Clone
	|
	|-RVA: 0x144CE3C Offset: 0x1448E3C VA: 0x144CE3C
	|-RepeatedField<long>.Clone
	|
	|-RVA: 0x144F028 Offset: 0x144B028 VA: 0x144F028
	|-RepeatedField<object>.Clone
	|
	|-RVA: 0x1451490 Offset: 0x144D490 VA: 0x1451490
	|-RepeatedField<__Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1
	public void AddEntriesFrom(ref ParseContext ctx, FieldCodec<T> codec) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448D0C Offset: 0x1444D0C VA: 0x1448D0C
	|-RepeatedField<int>.AddEntriesFrom
	|
	|-RVA: 0x144AEFC Offset: 0x1446EFC VA: 0x144AEFC
	|-RepeatedField<Int32Enum>.AddEntriesFrom
	|
	|-RVA: 0x144D0E0 Offset: 0x14490E0 VA: 0x144D0E0
	|-RepeatedField<long>.AddEntriesFrom
	|
	|-RVA: 0x144F2D4 Offset: 0x144B2D4 VA: 0x144F2D4
	|-RepeatedField<object>.AddEntriesFrom
	|
	|-RVA: 0x145183C Offset: 0x144D83C VA: 0x145183C
	|-RepeatedField<__Il2CppFullySharedGenericType>.AddEntriesFrom
	*/

	// RVA: -1 Offset: -1
	public int CalculateSize(FieldCodec<T> codec) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449058 Offset: 0x1445058 VA: 0x1449058
	|-RepeatedField<int>.CalculateSize
	|
	|-RVA: 0x144B248 Offset: 0x1447248 VA: 0x144B248
	|-RepeatedField<Int32Enum>.CalculateSize
	|
	|-RVA: 0x144D42C Offset: 0x144942C VA: 0x144D42C
	|-RepeatedField<long>.CalculateSize
	|
	|-RVA: 0x144F628 Offset: 0x144B628 VA: 0x144F628
	|-RepeatedField<object>.CalculateSize
	|
	|-RVA: 0x1451D64 Offset: 0x144DD64 VA: 0x1451D64
	|-RepeatedField<__Il2CppFullySharedGenericType>.CalculateSize
	*/

	// RVA: -1 Offset: -1
	private int CalculatePackedDataSize(FieldCodec<T> codec) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14491D0 Offset: 0x14451D0 VA: 0x14491D0
	|-RepeatedField<int>.CalculatePackedDataSize
	|
	|-RVA: 0x144B3C0 Offset: 0x14473C0 VA: 0x144B3C0
	|-RepeatedField<Int32Enum>.CalculatePackedDataSize
	|
	|-RVA: 0x144D5A4 Offset: 0x14495A4 VA: 0x144D5A4
	|-RepeatedField<long>.CalculatePackedDataSize
	|
	|-RVA: 0x144F7A0 Offset: 0x144B7A0 VA: 0x144F7A0
	|-RepeatedField<object>.CalculatePackedDataSize
	|
	|-RVA: 0x1452028 Offset: 0x144E028 VA: 0x1452028
	|-RepeatedField<__Il2CppFullySharedGenericType>.CalculatePackedDataSize
	*/

	// RVA: -1 Offset: -1
	public void WriteTo(ref WriteContext ctx, FieldCodec<T> codec) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449274 Offset: 0x1445274 VA: 0x1449274
	|-RepeatedField<int>.WriteTo
	|
	|-RVA: 0x144B464 Offset: 0x1447464 VA: 0x144B464
	|-RepeatedField<Int32Enum>.WriteTo
	|
	|-RVA: 0x144D648 Offset: 0x1449648 VA: 0x144D648
	|-RepeatedField<long>.WriteTo
	|
	|-RVA: 0x144F844 Offset: 0x144B844 VA: 0x144F844
	|-RepeatedField<object>.WriteTo
	|
	|-RVA: 0x14521D4 Offset: 0x144E1D4 VA: 0x14521D4
	|-RepeatedField<__Il2CppFullySharedGenericType>.WriteTo
	*/

	// RVA: -1 Offset: -1
	private void EnsureSize(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14494D8 Offset: 0x14454D8 VA: 0x14494D8
	|-RepeatedField<int>.EnsureSize
	|
	|-RVA: 0x144B6C8 Offset: 0x14476C8 VA: 0x144B6C8
	|-RepeatedField<Int32Enum>.EnsureSize
	|
	|-RVA: 0x144D8AC Offset: 0x14498AC VA: 0x144D8AC
	|-RepeatedField<long>.EnsureSize
	|
	|-RVA: 0x144FAA8 Offset: 0x144BAA8 VA: 0x144FAA8
	|-RepeatedField<object>.EnsureSize
	|
	|-RVA: 0x14525D8 Offset: 0x144E5D8 VA: 0x14525D8
	|-RepeatedField<__Il2CppFullySharedGenericType>.EnsureSize
	*/

	// RVA: -1 Offset: -1
	private void SetSize(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14495A0 Offset: 0x14455A0 VA: 0x14495A0
	|-RepeatedField<int>.SetSize
	|
	|-RVA: 0x144B790 Offset: 0x1447790 VA: 0x144B790
	|-RepeatedField<Int32Enum>.SetSize
	|
	|-RVA: 0x144D974 Offset: 0x1449974 VA: 0x144D974
	|-RepeatedField<long>.SetSize
	|
	|-RVA: 0x144FB70 Offset: 0x144BB70 VA: 0x144FB70
	|-RepeatedField<object>.SetSize
	|
	|-RVA: 0x14526A4 Offset: 0x144E6A4 VA: 0x14526A4
	|-RepeatedField<__Il2CppFullySharedGenericType>.SetSize
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449638 Offset: 0x1445638 VA: 0x1449638
	|-RepeatedField<int>.Add
	|
	|-RVA: 0x144B828 Offset: 0x1447828 VA: 0x144B828
	|-RepeatedField<Int32Enum>.Add
	|
	|-RVA: 0x144DA0C Offset: 0x1449A0C VA: 0x144DA0C
	|-RepeatedField<long>.Add
	|
	|-RVA: 0x144FC08 Offset: 0x144BC08 VA: 0x144FC08
	|-RepeatedField<object>.Add
	|
	|-RVA: 0x145273C Offset: 0x144E73C VA: 0x145273C
	|-RepeatedField<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 22
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14496EC Offset: 0x14456EC VA: 0x14496EC
	|-RepeatedField<int>.Clear
	|
	|-RVA: 0x144B8DC Offset: 0x14478DC VA: 0x144B8DC
	|-RepeatedField<Int32Enum>.Clear
	|
	|-RVA: 0x144DAC0 Offset: 0x1449AC0 VA: 0x144DAC0
	|-RepeatedField<long>.Clear
	|
	|-RVA: 0x144FCC0 Offset: 0x144BCC0 VA: 0x144FCC0
	|-RepeatedField<object>.Clear
	|
	|-RVA: 0x145295C Offset: 0x144E95C VA: 0x145295C
	|-RepeatedField<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449714 Offset: 0x1445714 VA: 0x1449714
	|-RepeatedField<int>.Contains
	|
	|-RVA: 0x144B904 Offset: 0x1447904 VA: 0x144B904
	|-RepeatedField<Int32Enum>.Contains
	|
	|-RVA: 0x144DAE8 Offset: 0x1449AE8 VA: 0x144DAE8
	|-RepeatedField<long>.Contains
	|
	|-RVA: 0x144FCE8 Offset: 0x144BCE8 VA: 0x144FCE8
	|-RepeatedField<object>.Contains
	|
	|-RVA: 0x1452984 Offset: 0x144E984 VA: 0x1452984
	|-RepeatedField<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449738 Offset: 0x1445738 VA: 0x1449738
	|-RepeatedField<int>.CopyTo
	|
	|-RVA: 0x144B928 Offset: 0x1447928 VA: 0x144B928
	|-RepeatedField<Int32Enum>.CopyTo
	|
	|-RVA: 0x144DB0C Offset: 0x1449B0C VA: 0x144DB0C
	|-RepeatedField<long>.CopyTo
	|
	|-RVA: 0x144FD0C Offset: 0x144BD0C VA: 0x144FD0C
	|-RepeatedField<object>.CopyTo
	|
	|-RVA: 0x1452A4C Offset: 0x144EA4C VA: 0x1452A4C
	|-RepeatedField<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449758 Offset: 0x1445758 VA: 0x1449758
	|-RepeatedField<int>.Remove
	|
	|-RVA: 0x144B948 Offset: 0x1447948 VA: 0x144B948
	|-RepeatedField<Int32Enum>.Remove
	|
	|-RVA: 0x144DB2C Offset: 0x1449B2C VA: 0x144DB2C
	|-RepeatedField<long>.Remove
	|
	|-RVA: 0x144FD2C Offset: 0x144BD2C VA: 0x144FD2C
	|-RepeatedField<object>.Remove
	|
	|-RVA: 0x1452A6C Offset: 0x144EA6C VA: 0x1452A6C
	|-RepeatedField<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14497E8 Offset: 0x14457E8 VA: 0x14497E8
	|-RepeatedField<int>.get_Count
	|
	|-RVA: 0x144B9D8 Offset: 0x14479D8 VA: 0x144B9D8
	|-RepeatedField<Int32Enum>.get_Count
	|
	|-RVA: 0x144DBBC Offset: 0x1449BBC VA: 0x144DBBC
	|-RepeatedField<long>.get_Count
	|
	|-RVA: 0x144FDC4 Offset: 0x144BDC4 VA: 0x144FDC4
	|-RepeatedField<object>.get_Count
	|
	|-RVA: 0x1452C38 Offset: 0x144EC38 VA: 0x1452C38
	|-RepeatedField<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14497F0 Offset: 0x14457F0 VA: 0x14497F0
	|-RepeatedField<int>.get_IsReadOnly
	|
	|-RVA: 0x144B9E0 Offset: 0x14479E0 VA: 0x144B9E0
	|-RepeatedField<Int32Enum>.get_IsReadOnly
	|
	|-RVA: 0x144DBC4 Offset: 0x1449BC4 VA: 0x144DBC4
	|-RepeatedField<long>.get_IsReadOnly
	|
	|-RVA: 0x144FDCC Offset: 0x144BDCC VA: 0x144FDCC
	|-RepeatedField<object>.get_IsReadOnly
	|
	|-RVA: 0x1452C40 Offset: 0x144EC40 VA: 0x1452C40
	|-RepeatedField<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1
	public void AddRange(IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14497F8 Offset: 0x14457F8 VA: 0x14497F8
	|-RepeatedField<int>.AddRange
	|
	|-RVA: 0x144B9E8 Offset: 0x14479E8 VA: 0x144B9E8
	|-RepeatedField<Int32Enum>.AddRange
	|
	|-RVA: 0x144DBCC Offset: 0x1449BCC VA: 0x144DBCC
	|-RepeatedField<long>.AddRange
	|
	|-RVA: 0x144FDD4 Offset: 0x144BDD4 VA: 0x144FDD4
	|-RepeatedField<object>.AddRange
	|
	|-RVA: 0x1452C48 Offset: 0x144EC48 VA: 0x1452C48
	|-RepeatedField<__Il2CppFullySharedGenericType>.AddRange
	*/

	// RVA: -1 Offset: -1
	public void Add(IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449C94 Offset: 0x1445C94 VA: 0x1449C94
	|-RepeatedField<int>.Add
	|
	|-RVA: 0x144BE84 Offset: 0x1447E84 VA: 0x144BE84
	|-RepeatedField<Int32Enum>.Add
	|
	|-RVA: 0x144E068 Offset: 0x144A068 VA: 0x144E068
	|-RepeatedField<long>.Add
	|
	|-RVA: 0x14504F0 Offset: 0x144C4F0 VA: 0x14504F0
	|-RepeatedField<object>.Add
	|
	|-RVA: 0x14534CC Offset: 0x144F4CC VA: 0x14534CC
	|-RepeatedField<__Il2CppFullySharedGenericType>.Add
	*/

	[IteratorStateMachine(typeof(RepeatedField.<GetEnumerator>d__29<T>))]
	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449CA4 Offset: 0x1445CA4 VA: 0x1449CA4
	|-RepeatedField<int>.GetEnumerator
	|
	|-RVA: 0x144BE94 Offset: 0x1447E94 VA: 0x144BE94
	|-RepeatedField<Int32Enum>.GetEnumerator
	|
	|-RVA: 0x144E078 Offset: 0x144A078 VA: 0x144E078
	|-RepeatedField<long>.GetEnumerator
	|
	|-RVA: 0x1450500 Offset: 0x144C500 VA: 0x1450500
	|-RepeatedField<object>.GetEnumerator
	|
	|-RVA: 0x14534E0 Offset: 0x144F4E0 VA: 0x14534E0
	|-RepeatedField<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449D20 Offset: 0x1445D20 VA: 0x1449D20
	|-RepeatedField<int>.Equals
	|
	|-RVA: 0x144BF10 Offset: 0x1447F10 VA: 0x144BF10
	|-RepeatedField<Int32Enum>.Equals
	|
	|-RVA: 0x144E0F4 Offset: 0x144A0F4 VA: 0x144E0F4
	|-RepeatedField<long>.Equals
	|
	|-RVA: 0x145057C Offset: 0x144C57C VA: 0x145057C
	|-RepeatedField<object>.Equals
	|
	|-RVA: 0x1453570 Offset: 0x144F570 VA: 0x1453570
	|-RepeatedField<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449D8C Offset: 0x1445D8C VA: 0x1449D8C
	|-RepeatedField<int>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x144BF7C Offset: 0x1447F7C VA: 0x144BF7C
	|-RepeatedField<Int32Enum>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x144E160 Offset: 0x144A160 VA: 0x144E160
	|-RepeatedField<long>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x14505E8 Offset: 0x144C5E8 VA: 0x14505E8
	|-RepeatedField<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x14535F4 Offset: 0x144F5F4 VA: 0x14535F4
	|-RepeatedField<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449D9C Offset: 0x1445D9C VA: 0x1449D9C
	|-RepeatedField<int>.GetHashCode
	|
	|-RVA: 0x144BF8C Offset: 0x1447F8C VA: 0x144BF8C
	|-RepeatedField<Int32Enum>.GetHashCode
	|
	|-RVA: 0x144E170 Offset: 0x144A170 VA: 0x144E170
	|-RepeatedField<long>.GetHashCode
	|
	|-RVA: 0x14505F8 Offset: 0x144C5F8 VA: 0x14505F8
	|-RepeatedField<object>.GetHashCode
	|
	|-RVA: 0x1453608 Offset: 0x144F608 VA: 0x1453608
	|-RepeatedField<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public bool Equals(RepeatedField<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449E30 Offset: 0x1445E30 VA: 0x1449E30
	|-RepeatedField<int>.Equals
	|
	|-RVA: 0x144C014 Offset: 0x1448014 VA: 0x144C014
	|-RepeatedField<Int32Enum>.Equals
	|
	|-RVA: 0x144E204 Offset: 0x144A204 VA: 0x144E204
	|-RepeatedField<long>.Equals
	|
	|-RVA: 0x145067C Offset: 0x144C67C VA: 0x145067C
	|-RepeatedField<object>.Equals
	|
	|-RVA: 0x145376C Offset: 0x144F76C VA: 0x145376C
	|-RepeatedField<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1449F4C Offset: 0x1445F4C VA: 0x1449F4C
	|-RepeatedField<int>.IndexOf
	|
	|-RVA: 0x144C130 Offset: 0x1448130 VA: 0x144C130
	|-RepeatedField<Int32Enum>.IndexOf
	|
	|-RVA: 0x144E320 Offset: 0x144A320 VA: 0x144E320
	|-RepeatedField<long>.IndexOf
	|
	|-RVA: 0x1450798 Offset: 0x144C798 VA: 0x1450798
	|-RepeatedField<object>.IndexOf
	|
	|-RVA: 0x14539AC Offset: 0x144F9AC VA: 0x14539AC
	|-RepeatedField<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A068 Offset: 0x1446068 VA: 0x144A068
	|-RepeatedField<int>.Insert
	|
	|-RVA: 0x144C24C Offset: 0x144824C VA: 0x144C24C
	|-RepeatedField<Int32Enum>.Insert
	|
	|-RVA: 0x144E43C Offset: 0x144A43C VA: 0x144E43C
	|-RepeatedField<long>.Insert
	|
	|-RVA: 0x14508B4 Offset: 0x144C8B4 VA: 0x14508B4
	|-RepeatedField<object>.Insert
	|
	|-RVA: 0x1453C20 Offset: 0x144FC20 VA: 0x1453C20
	|-RepeatedField<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A190 Offset: 0x1446190 VA: 0x144A190
	|-RepeatedField<int>.RemoveAt
	|
	|-RVA: 0x144C374 Offset: 0x1448374 VA: 0x144C374
	|-RepeatedField<Int32Enum>.RemoveAt
	|
	|-RVA: 0x144E564 Offset: 0x144A564 VA: 0x144E564
	|-RepeatedField<long>.RemoveAt
	|
	|-RVA: 0x14509E4 Offset: 0x144C9E4 VA: 0x14509E4
	|-RepeatedField<object>.RemoveAt
	|
	|-RVA: 0x1453EC8 Offset: 0x144FEC8 VA: 0x1453EC8
	|-RepeatedField<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public override string ToString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A248 Offset: 0x1446248 VA: 0x144A248
	|-RepeatedField<int>.ToString
	|
	|-RVA: 0x144C42C Offset: 0x144842C VA: 0x144C42C
	|-RepeatedField<Int32Enum>.ToString
	|
	|-RVA: 0x144E61C Offset: 0x144A61C VA: 0x144E61C
	|-RepeatedField<long>.ToString
	|
	|-RVA: 0x1450AA0 Offset: 0x144CAA0 VA: 0x1450AA0
	|-RepeatedField<object>.ToString
	|
	|-RVA: 0x1454084 Offset: 0x1450084 VA: 0x1454084
	|-RepeatedField<__Il2CppFullySharedGenericType>.ToString
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A330 Offset: 0x1446330 VA: 0x144A330
	|-RepeatedField<int>.get_Item
	|
	|-RVA: 0x144C514 Offset: 0x1448514 VA: 0x144C514
	|-RepeatedField<Int32Enum>.get_Item
	|
	|-RVA: 0x144E704 Offset: 0x144A704 VA: 0x144E704
	|-RepeatedField<long>.get_Item
	|
	|-RVA: 0x1450B88 Offset: 0x144CB88 VA: 0x1450B88
	|-RepeatedField<object>.get_Item
	|
	|-RVA: 0x145416C Offset: 0x145016C VA: 0x145416C
	|-RepeatedField<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A3B8 Offset: 0x14463B8 VA: 0x144A3B8
	|-RepeatedField<int>.set_Item
	|
	|-RVA: 0x144C59C Offset: 0x144859C VA: 0x144C59C
	|-RepeatedField<Int32Enum>.set_Item
	|
	|-RVA: 0x144E78C Offset: 0x144A78C VA: 0x144E78C
	|-RepeatedField<long>.set_Item
	|
	|-RVA: 0x1450C10 Offset: 0x144CC10 VA: 0x1450C10
	|-RepeatedField<object>.set_Item
	|
	|-RVA: 0x1454218 Offset: 0x1450218 VA: 0x1454218
	|-RepeatedField<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	private bool TryGetArrayAsSpanPinnedUnsafe(FieldCodec<T> codec, out Span<byte> span, out GCHandle handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A494 Offset: 0x1446494 VA: 0x144A494
	|-RepeatedField<int>.TryGetArrayAsSpanPinnedUnsafe
	|
	|-RVA: 0x144C678 Offset: 0x1448678 VA: 0x144C678
	|-RepeatedField<Int32Enum>.TryGetArrayAsSpanPinnedUnsafe
	|
	|-RVA: 0x144E868 Offset: 0x144A868 VA: 0x144E868
	|-RepeatedField<long>.TryGetArrayAsSpanPinnedUnsafe
	|
	|-RVA: 0x1450CF0 Offset: 0x144CCF0 VA: 0x1450CF0
	|-RepeatedField<object>.TryGetArrayAsSpanPinnedUnsafe
	|
	|-RVA: 0x1454488 Offset: 0x1450488 VA: 0x1454488
	|-RepeatedField<__Il2CppFullySharedGenericType>.TryGetArrayAsSpanPinnedUnsafe
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private bool System.Collections.IList.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A5D4 Offset: 0x14465D4 VA: 0x144A5D4
	|-RepeatedField<int>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x144C7B8 Offset: 0x14487B8 VA: 0x144C7B8
	|-RepeatedField<Int32Enum>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x144E9A8 Offset: 0x144A9A8 VA: 0x144E9A8
	|-RepeatedField<long>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x1450E30 Offset: 0x144CE30 VA: 0x1450E30
	|-RepeatedField<object>.System.Collections.IList.get_IsFixedSize
	|
	|-RVA: 0x1454608 Offset: 0x1450608 VA: 0x1454608
	|-RepeatedField<__Il2CppFullySharedGenericType>.System.Collections.IList.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A5DC Offset: 0x14465DC VA: 0x144A5DC
	|-RepeatedField<int>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x144C7C0 Offset: 0x14487C0 VA: 0x144C7C0
	|-RepeatedField<Int32Enum>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x144E9B0 Offset: 0x144A9B0 VA: 0x144E9B0
	|-RepeatedField<long>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1450E38 Offset: 0x144CE38 VA: 0x1450E38
	|-RepeatedField<object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x1454610 Offset: 0x1450610 VA: 0x1454610
	|-RepeatedField<__Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A5FC Offset: 0x14465FC VA: 0x144A5FC
	|-RepeatedField<int>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x144C7E0 Offset: 0x14487E0 VA: 0x144C7E0
	|-RepeatedField<Int32Enum>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x144E9D0 Offset: 0x144A9D0 VA: 0x144E9D0
	|-RepeatedField<long>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x1450E58 Offset: 0x144CE58 VA: 0x1450E58
	|-RepeatedField<object>.System.Collections.ICollection.get_IsSynchronized
	|
	|-RVA: 0x1454630 Offset: 0x1450630 VA: 0x1454630
	|-RepeatedField<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A604 Offset: 0x1446604 VA: 0x144A604
	|-RepeatedField<int>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x144C7E8 Offset: 0x14487E8 VA: 0x144C7E8
	|-RepeatedField<Int32Enum>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x144E9D8 Offset: 0x144A9D8 VA: 0x144E9D8
	|-RepeatedField<long>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1450E60 Offset: 0x144CE60 VA: 0x1450E60
	|-RepeatedField<object>.System.Collections.ICollection.get_SyncRoot
	|
	|-RVA: 0x1454638 Offset: 0x1450638 VA: 0x1454638
	|-RepeatedField<__Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private object System.Collections.IList.get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A608 Offset: 0x1446608 VA: 0x144A608
	|-RepeatedField<int>.System.Collections.IList.get_Item
	|
	|-RVA: 0x144C7EC Offset: 0x14487EC VA: 0x144C7EC
	|-RepeatedField<Int32Enum>.System.Collections.IList.get_Item
	|
	|-RVA: 0x144E9DC Offset: 0x144A9DC VA: 0x144E9DC
	|-RepeatedField<long>.System.Collections.IList.get_Item
	|
	|-RVA: 0x1450E64 Offset: 0x144CE64 VA: 0x1450E64
	|-RepeatedField<object>.System.Collections.IList.get_Item
	|
	|-RVA: 0x145463C Offset: 0x145063C VA: 0x145463C
	|-RepeatedField<__Il2CppFullySharedGenericType>.System.Collections.IList.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 19
	private void System.Collections.IList.set_Item(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A64C Offset: 0x144664C VA: 0x144A64C
	|-RepeatedField<int>.System.Collections.IList.set_Item
	|
	|-RVA: 0x144C830 Offset: 0x1448830 VA: 0x144C830
	|-RepeatedField<Int32Enum>.System.Collections.IList.set_Item
	|
	|-RVA: 0x144EA1C Offset: 0x144AA1C VA: 0x144EA1C
	|-RepeatedField<long>.System.Collections.IList.set_Item
	|
	|-RVA: 0x1450E74 Offset: 0x144CE74 VA: 0x1450E74
	|-RepeatedField<object>.System.Collections.IList.set_Item
	|
	|-RVA: 0x14546EC Offset: 0x14506EC VA: 0x14546EC
	|-RepeatedField<__Il2CppFullySharedGenericType>.System.Collections.IList.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private int System.Collections.IList.Add(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A6DC Offset: 0x14466DC VA: 0x144A6DC
	|-RepeatedField<int>.System.Collections.IList.Add
	|
	|-RVA: 0x144C8C0 Offset: 0x14488C0 VA: 0x144C8C0
	|-RepeatedField<Int32Enum>.System.Collections.IList.Add
	|
	|-RVA: 0x144EAAC Offset: 0x144AAAC VA: 0x144EAAC
	|-RepeatedField<long>.System.Collections.IList.Add
	|
	|-RVA: 0x1450F00 Offset: 0x144CF00 VA: 0x1450F00
	|-RepeatedField<object>.System.Collections.IList.Add
	|
	|-RVA: 0x14547D8 Offset: 0x14507D8 VA: 0x14547D8
	|-RepeatedField<__Il2CppFullySharedGenericType>.System.Collections.IList.Add
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private bool System.Collections.IList.Contains(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A768 Offset: 0x1446768 VA: 0x144A768
	|-RepeatedField<int>.System.Collections.IList.Contains
	|
	|-RVA: 0x144C94C Offset: 0x144894C VA: 0x144C94C
	|-RepeatedField<Int32Enum>.System.Collections.IList.Contains
	|
	|-RVA: 0x144EB38 Offset: 0x144AB38 VA: 0x144EB38
	|-RepeatedField<long>.System.Collections.IList.Contains
	|
	|-RVA: 0x1450F90 Offset: 0x144CF90 VA: 0x1450F90
	|-RepeatedField<object>.System.Collections.IList.Contains
	|
	|-RVA: 0x14548C0 Offset: 0x14508C0 VA: 0x14548C0
	|-RepeatedField<__Il2CppFullySharedGenericType>.System.Collections.IList.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private int System.Collections.IList.IndexOf(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A830 Offset: 0x1446830 VA: 0x144A830
	|-RepeatedField<int>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x144CA14 Offset: 0x1448A14 VA: 0x144CA14
	|-RepeatedField<Int32Enum>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x144EC00 Offset: 0x144AC00 VA: 0x144EC00
	|-RepeatedField<long>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x145105C Offset: 0x144D05C VA: 0x145105C
	|-RepeatedField<object>.System.Collections.IList.IndexOf
	|
	|-RVA: 0x14549FC Offset: 0x14509FC VA: 0x14549FC
	|-RepeatedField<__Il2CppFullySharedGenericType>.System.Collections.IList.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IList.Insert(int index, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A8F0 Offset: 0x14468F0 VA: 0x144A8F0
	|-RepeatedField<int>.System.Collections.IList.Insert
	|
	|-RVA: 0x144CAD4 Offset: 0x1448AD4 VA: 0x144CAD4
	|-RepeatedField<Int32Enum>.System.Collections.IList.Insert
	|
	|-RVA: 0x144ECC0 Offset: 0x144ACC0 VA: 0x144ECC0
	|-RepeatedField<long>.System.Collections.IList.Insert
	|
	|-RVA: 0x1451124 Offset: 0x144D124 VA: 0x1451124
	|-RepeatedField<object>.System.Collections.IList.Insert
	|
	|-RVA: 0x1454B24 Offset: 0x1450B24 VA: 0x1454B24
	|-RepeatedField<__Il2CppFullySharedGenericType>.System.Collections.IList.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 27
	private void System.Collections.IList.Remove(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144A980 Offset: 0x1446980 VA: 0x144A980
	|-RepeatedField<int>.System.Collections.IList.Remove
	|
	|-RVA: 0x144CB64 Offset: 0x1448B64 VA: 0x144CB64
	|-RepeatedField<Int32Enum>.System.Collections.IList.Remove
	|
	|-RVA: 0x144ED50 Offset: 0x144AD50 VA: 0x144ED50
	|-RepeatedField<long>.System.Collections.IList.Remove
	|
	|-RVA: 0x14511B0 Offset: 0x144D1B0 VA: 0x14511B0
	|-RepeatedField<object>.System.Collections.IList.Remove
	|
	|-RVA: 0x1454C10 Offset: 0x1450C10 VA: 0x1454C10
	|-RepeatedField<__Il2CppFullySharedGenericType>.System.Collections.IList.Remove
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AA3C Offset: 0x1446A3C VA: 0x144AA3C
	|-RepeatedField<int>..ctor
	|
	|-RVA: 0x144CC20 Offset: 0x1448C20 VA: 0x144CC20
	|-RepeatedField<Int32Enum>..ctor
	|
	|-RVA: 0x144EE0C Offset: 0x144AE0C VA: 0x144EE0C
	|-RepeatedField<long>..ctor
	|
	|-RVA: 0x1451274 Offset: 0x144D274 VA: 0x1451274
	|-RepeatedField<object>..ctor
	|
	|-RVA: 0x1454D40 Offset: 0x1450D40 VA: 0x1454D40
	|-RepeatedField<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144AAC4 Offset: 0x1446AC4 VA: 0x144AAC4
	|-RepeatedField<int>..cctor
	|
	|-RVA: 0x144CCA8 Offset: 0x1448CA8 VA: 0x144CCA8
	|-RepeatedField<Int32Enum>..cctor
	|
	|-RVA: 0x144EE94 Offset: 0x144AE94 VA: 0x144EE94
	|-RepeatedField<long>..cctor
	|
	|-RVA: 0x14512FC Offset: 0x144D2FC VA: 0x14512FC
	|-RepeatedField<object>..cctor
	|
	|-RVA: 0x1454DC8 Offset: 0x1450DC8 VA: 0x1454DC8
	|-RepeatedField<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
internal class <Module> // TypeDefIndex: 6582
{}
