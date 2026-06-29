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

// Namespace: Newtonsoft.Json.Linq
public enum CommentHandling // TypeDefIndex: 6199
{
	// Fields
	public int value__; // 0x0
	public const CommentHandling Ignore = 0;
	public const CommentHandling Load = 1;
}

// Namespace: Newtonsoft.Json.Linq
public enum DuplicatePropertyNameHandling // TypeDefIndex: 6200
{
	// Fields
	public int value__; // 0x0
	public const DuplicatePropertyNameHandling Replace = 0;
	public const DuplicatePropertyNameHandling Ignore = 1;
	public const DuplicatePropertyNameHandling Error = 2;
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
[DefaultMember("Item")]
public class JArray : JContainer, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 6201
{
	// Fields
	private readonly List<JToken> _values; // 0x50

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	public JToken Item { get; set; }
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1974AC4 Offset: 0x1970AC4 VA: 0x1974AC4 Slot: 46
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0x1974ACC Offset: 0x1970ACC VA: 0x1974ACC Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0x1974AD4 Offset: 0x1970AD4 VA: 0x1974AD4
	public void .ctor() { }

	// RVA: 0x1974BB0 Offset: 0x1970BB0 VA: 0x1974BB0
	internal void .ctor(JArray other, JsonCloneSettings settings) { }

	// RVA: 0x1974F84 Offset: 0x1970F84 VA: 0x1974F84
	public void .ctor(object content) { }

	// RVA: 0x1975024 Offset: 0x1971024 VA: 0x1975024 Slot: 11
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0x197508C Offset: 0x197108C VA: 0x197508C
	public static JArray Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x1975528 Offset: 0x1971528 VA: 0x1975528 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x19755F4 Offset: 0x19715F4 VA: 0x19755F4 Slot: 19
	public JToken get_Item(int index) { }

	// RVA: 0x1975604 Offset: 0x1971604 VA: 0x1975604 Slot: 20
	public void set_Item(int index, JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1975614 Offset: 0x1971614 VA: 0x1975614 Slot: 49
	internal override int IndexOfItem(JToken item) { }

	// RVA: 0x1975678 Offset: 0x1971678 VA: 0x1975678 Slot: 21
	public int IndexOf(JToken item) { }

	// RVA: 0x1975688 Offset: 0x1971688 VA: 0x1975688 Slot: 22
	public void Insert(int index, JToken item) { }

	// RVA: 0x19756A0 Offset: 0x19716A0 VA: 0x19756A0 Slot: 23
	public void RemoveAt(int index) { }

	// RVA: 0x19756B0 Offset: 0x19716B0 VA: 0x19756B0 Slot: 4
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0x1975748 Offset: 0x1971748 VA: 0x1975748 Slot: 26
	public void Add(JToken item) { }

	// RVA: 0x1975758 Offset: 0x1971758 VA: 0x1975758 Slot: 27
	public void Clear() { }

	// RVA: 0x1975768 Offset: 0x1971768 VA: 0x1975768 Slot: 28
	public bool Contains(JToken item) { }

	// RVA: 0x1975778 Offset: 0x1971778 VA: 0x1975778 Slot: 29
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x1975788 Offset: 0x1971788 VA: 0x1975788 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0x1975790 Offset: 0x1971790 VA: 0x1975790 Slot: 30
	public bool Remove(JToken item) { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
[DefaultMember("Item")]
public class JConstructor : JContainer // TypeDefIndex: 6202
{
	// Fields
	[Nullable(2)]
	private string _name; // 0x50
	private readonly List<JToken> _values; // 0x58

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	[Nullable(2)]
	public string Name { get; }
	public override JTokenType Type { get; }

	// Methods

	// RVA: 0x19757A0 Offset: 0x19717A0 VA: 0x19757A0 Slot: 46
	protected override IList<JToken> get_ChildrenTokens() { }

	[NullableContext(2)]
	// RVA: 0x19757A8 Offset: 0x19717A8 VA: 0x19757A8 Slot: 49
	internal override int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x197580C Offset: 0x197180C VA: 0x197580C
	public string get_Name() { }

	// RVA: 0x1975814 Offset: 0x1971814 VA: 0x1975814 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0x197581C Offset: 0x197181C VA: 0x197581C
	internal void .ctor(JConstructor other, JsonCloneSettings settings) { }

	// RVA: 0x19758D0 Offset: 0x19718D0 VA: 0x19758D0
	public void .ctor(string name) { }

	// RVA: 0x1975A04 Offset: 0x1971A04 VA: 0x1975A04 Slot: 11
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0x1975A6C Offset: 0x1971A6C VA: 0x1975A6C Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x1975B4C Offset: 0x1971B4C VA: 0x1975B4C
	public static JConstructor Load(JsonReader reader, JsonLoadSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public abstract class JContainer : JToken, IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable, IBindingList, ICollection, IList // TypeDefIndex: 6203
{
	// Fields
	[Nullable(2)]
	internal ListChangedEventHandler _listChanged; // 0x30
	[Nullable(2)]
	internal NotifyCollectionChangedEventHandler _collectionChanged; // 0x38
	[Nullable(2)]
	private object _syncRoot; // 0x40
	private bool _busy; // 0x48

	// Properties
	protected abstract IList<JToken> ChildrenTokens { get; }
	public override bool HasValues { get; }
	[Nullable(2)]
	public override JToken First { get; }
	[Nullable(2)]
	public override JToken Last { get; }
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Item { get; set; }
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	[Nullable(2)]
	private object System.Collections.IList.Item { get; set; }
	public int Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 46
	protected abstract IList<JToken> get_ChildrenTokens();

	// RVA: 0x1974B58 Offset: 0x1970B58 VA: 0x1974B58
	internal void .ctor() { }

	// RVA: 0x1974C4C Offset: 0x1970C4C VA: 0x1974C4C
	internal void .ctor(JContainer other, JsonCloneSettings settings) { }

	// RVA: 0x1976134 Offset: 0x1972134 VA: 0x1976134
	internal void CheckReentrancy() { }

	// RVA: 0x19761D4 Offset: 0x19721D4 VA: 0x19761D4 Slot: 47
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x197625C Offset: 0x197225C VA: 0x197625C Slot: 48
	protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs e) { }

	// RVA: 0x19762E4 Offset: 0x19722E4 VA: 0x19762E4 Slot: 13
	public override bool get_HasValues() { }

	[NullableContext(2)]
	// RVA: 0x19763A4 Offset: 0x19723A4 VA: 0x19763A4 Slot: 14
	public override JToken get_First() { }

	[NullableContext(2)]
	// RVA: 0x19764E0 Offset: 0x19724E0 VA: 0x19764E0 Slot: 15
	public override JToken get_Last() { }

	// RVA: 0x197661C Offset: 0x197261C VA: 0x197661C Slot: 16
	public override JEnumerable<JToken> Children() { }

	[NullableContext(2)]
	// RVA: 0x1976690 Offset: 0x1972690 VA: 0x1976690
	internal bool IsMultiContent(object content) { }

	// RVA: 0x1976768 Offset: 0x1972768 VA: 0x1976768
	internal JToken EnsureParentToken(JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 49
	internal abstract int IndexOfItem(JToken item);

	[NullableContext(2)]
	// RVA: 0x19768D0 Offset: 0x19728D0 VA: 0x19768D0 Slot: 50
	internal virtual bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0x1976D04 Offset: 0x1972D04 VA: 0x1976D04 Slot: 51
	internal virtual void RemoveItemAt(int index) { }

	[NullableContext(2)]
	// RVA: 0x1977194 Offset: 0x1973194 VA: 0x1977194 Slot: 52
	internal virtual bool RemoveItem(JToken item) { }

	// RVA: 0x19771E8 Offset: 0x19731E8 VA: 0x19771E8 Slot: 53
	internal virtual JToken GetItem(int index) { }

	[NullableContext(2)]
	// RVA: 0x19772A4 Offset: 0x19732A4 VA: 0x19772A4 Slot: 54
	internal virtual void SetItem(int index, JToken item) { }

	// RVA: 0x197786C Offset: 0x197386C VA: 0x197786C Slot: 55
	internal virtual void ClearItems() { }

	// RVA: 0x1977C7C Offset: 0x1973C7C VA: 0x1977C7C Slot: 56
	internal virtual void ReplaceItem(JToken existing, JToken replacement) { }

	[NullableContext(2)]
	// RVA: 0x1977CE0 Offset: 0x1973CE0 VA: 0x1977CE0 Slot: 57
	internal virtual bool ContainsItem(JToken item) { }

	// RVA: 0x1977D04 Offset: 0x1973D04 VA: 0x1977D04 Slot: 58
	internal virtual void CopyItemsTo(Array array, int arrayIndex) { }

	// RVA: 0x19777BC Offset: 0x19737BC VA: 0x19777BC
	internal static bool IsTokenUnchanged(JToken currentValue, JToken newValue) { }

	// RVA: 0x19781B8 Offset: 0x19741B8 VA: 0x19781B8 Slot: 59
	internal virtual void ValidateToken(JToken o, JToken existing) { }

	[NullableContext(2)]
	// RVA: 0x19782D4 Offset: 0x19742D4 VA: 0x19782D4 Slot: 60
	public virtual void Add(object content) { }

	[NullableContext(2)]
	// RVA: 0x19783A4 Offset: 0x19743A4 VA: 0x19783A4
	internal bool TryAdd(object content) { }

	// RVA: 0x1978474 Offset: 0x1974474 VA: 0x1978474
	internal void AddAndSkipParentCheck(JToken token) { }

	[NullableContext(2)]
	// RVA: 0x1975DCC Offset: 0x1971DCC VA: 0x1975DCC
	internal bool TryAddInternal(int index, object content, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0x1978544 Offset: 0x1974544 VA: 0x1978544
	internal static JToken CreateFromContent(object content) { }

	// RVA: 0x1978628 Offset: 0x1974628 VA: 0x1978628
	public void RemoveAll() { }

	// RVA: 0x19753CC Offset: 0x19713CC VA: 0x19753CC
	internal void ReadTokenFrom(JsonReader reader, JsonLoadSettings options) { }

	// RVA: 0x1978638 Offset: 0x1974638 VA: 0x1978638
	internal void ReadContentFrom(JsonReader r, JsonLoadSettings settings) { }

	[NullableContext(2)]
	// RVA: 0x1978B6C Offset: 0x1974B6C VA: 0x1978B6C
	private static JProperty ReadProperty(JsonReader r, JsonLoadSettings settings, IJsonLineInfo lineInfo, JContainer parent) { }

	// RVA: 0x1978FE0 Offset: 0x1974FE0 VA: 0x1978FE0 Slot: 21
	private int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(JToken item) { }

	// RVA: 0x1978FF0 Offset: 0x1974FF0 VA: 0x1978FF0 Slot: 22
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, JToken item) { }

	// RVA: 0x1979008 Offset: 0x1975008 VA: 0x1979008 Slot: 23
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }

	// RVA: 0x1979018 Offset: 0x1975018 VA: 0x1979018 Slot: 19
	private JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.get_Item(int index) { }

	// RVA: 0x1979028 Offset: 0x1975028 VA: 0x1979028 Slot: 20
	private void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.set_Item(int index, JToken value) { }

	// RVA: 0x1979038 Offset: 0x1975038 VA: 0x1979038 Slot: 26
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(JToken item) { }

	// RVA: 0x1979048 Offset: 0x1975048 VA: 0x1979048 Slot: 27
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }

	// RVA: 0x1979058 Offset: 0x1975058 VA: 0x1979058 Slot: 28
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(JToken item) { }

	// RVA: 0x1979068 Offset: 0x1975068 VA: 0x1979068 Slot: 29
	private void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x1979078 Offset: 0x1975078 VA: 0x1979078 Slot: 25
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.get_IsReadOnly() { }

	// RVA: 0x1979080 Offset: 0x1975080 VA: 0x1979080 Slot: 30
	private bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x1979090 Offset: 0x1975090 VA: 0x1979090
	private JToken EnsureValue(object value) { }

	[NullableContext(2)]
	// RVA: 0x197914C Offset: 0x197514C VA: 0x197914C Slot: 33
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1979190 Offset: 0x1975190 VA: 0x1979190 Slot: 35
	private void System.Collections.IList.Clear() { }

	[NullableContext(2)]
	// RVA: 0x19791A0 Offset: 0x19751A0 VA: 0x19791A0 Slot: 34
	private bool System.Collections.IList.Contains(object value) { }

	[NullableContext(2)]
	// RVA: 0x19791D4 Offset: 0x19751D4 VA: 0x19791D4 Slot: 38
	private int System.Collections.IList.IndexOf(object value) { }

	[NullableContext(2)]
	// RVA: 0x1979208 Offset: 0x1975208 VA: 0x1979208 Slot: 39
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1979250 Offset: 0x1975250 VA: 0x1979250 Slot: 37
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1979258 Offset: 0x1975258 VA: 0x1979258 Slot: 36
	private bool System.Collections.IList.get_IsReadOnly() { }

	[NullableContext(2)]
	// RVA: 0x1979260 Offset: 0x1975260 VA: 0x1979260 Slot: 40
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1979294 Offset: 0x1975294 VA: 0x1979294 Slot: 41
	private void System.Collections.IList.RemoveAt(int index) { }

	[NullableContext(2)]
	// RVA: 0x19792A4 Offset: 0x19752A4 VA: 0x19792A4 Slot: 31
	private object System.Collections.IList.get_Item(int index) { }

	[NullableContext(2)]
	// RVA: 0x19792B4 Offset: 0x19752B4 VA: 0x19792B4 Slot: 32
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x19792F4 Offset: 0x19752F4 VA: 0x19792F4 Slot: 42
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1978104 Offset: 0x1974104 VA: 0x1978104 Slot: 43
	public int get_Count() { }

	// RVA: 0x1979304 Offset: 0x1975304 VA: 0x1979304 Slot: 45
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x197930C Offset: 0x197530C VA: 0x197930C Slot: 44
	private object System.Collections.ICollection.get_SyncRoot() { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
[IsReadOnly]
[DefaultMember("Item")]
public struct JEnumerable<T> : IEnumerable<T>, IEnumerable, IEquatable<JEnumerable<T>> // TypeDefIndex: 6204
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	public static readonly JEnumerable<T> Empty; // 0x0
	private readonly IEnumerable<T> _enumerable; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<T> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D0180 Offset: 0x12CC180 VA: 0x12D0180
	|-JEnumerable<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D01E8 Offset: 0x12CC1E8 VA: 0x12D01E8
	|-JEnumerable<object>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D0338 Offset: 0x12CC338 VA: 0x12D0338
	|-JEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool Equals(JEnumerable<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D03B4 Offset: 0x12CC3B4 VA: 0x12D03B4
	|-JEnumerable<object>.Equals
	*/

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D03C0 Offset: 0x12CC3C0 VA: 0x12D03C0
	|-JEnumerable<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D04E8 Offset: 0x12CC4E8 VA: 0x12D04E8
	|-JEnumerable<object>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D0500 Offset: 0x12CC500 VA: 0x12D0500
	|-JEnumerable<object>..cctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class JObject.JObjectDynamicProxy.<>c // TypeDefIndex: 6205
{
	// Fields
	[Nullable(0)]
	public static readonly JObject.JObjectDynamicProxy.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<JProperty, string> <>9__2_0; // 0x8

	// Methods

	// RVA: 0x197B2F8 Offset: 0x19772F8 VA: 0x197B2F8
	private static void .cctor() { }

	// RVA: 0x197B360 Offset: 0x1977360 VA: 0x197B360
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x197B368 Offset: 0x1977368 VA: 0x197B368
	internal string <GetDynamicMemberNames>b__2_0(JProperty p) { }
}

// Namespace: 
[Nullable(new[] { 0, 1 })]
private class JObject.JObjectDynamicProxy : DynamicProxy<JObject> // TypeDefIndex: 6206
{
	// Methods

	// RVA: 0x197B0C4 Offset: 0x19770C4 VA: 0x197B0C4 Slot: 11
	public override bool TryGetMember(JObject instance, GetMemberBinder binder, out object result) { }

	// RVA: 0x197B104 Offset: 0x1977104 VA: 0x197B104 Slot: 15
	public override bool TrySetMember(JObject instance, SetMemberBinder binder, object value) { }

	// RVA: 0x197B1E4 Offset: 0x19771E4 VA: 0x197B1E4 Slot: 4
	public override IEnumerable<string> GetDynamicMemberNames(JObject instance) { }

	// RVA: 0x197B07C Offset: 0x197707C VA: 0x197B07C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JObject.<GetEnumerator>d__64 : IEnumerator<KeyValuePair<string, JToken>>, IEnumerator, IDisposable // TypeDefIndex: 6207
{
	// Fields
	private int <>1__state; // 0x10
	[Nullable(new[] { 0, 1, 2 })]
	private KeyValuePair<string, JToken> <>2__current; // 0x18
	[Nullable(0)]
	public JObject <>4__this; // 0x28
	[Nullable(new[] { 0, 1 })]
	private IEnumerator<JToken> <>7__wrap1; // 0x30

	// Properties
	private KeyValuePair<string, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x197A97C Offset: 0x197697C VA: 0x197A97C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x197B37C Offset: 0x197737C VA: 0x197B37C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x197B398 Offset: 0x1977398 VA: 0x197B398 Slot: 6
	private bool MoveNext() { }

	// RVA: 0x197B674 Offset: 0x1977674 VA: 0x197B674
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x197B724 Offset: 0x1977724 VA: 0x197B724 Slot: 4
	private KeyValuePair<string, JToken> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197B730 Offset: 0x1977730 VA: 0x197B730 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x197B768 Offset: 0x1977768 VA: 0x197B768 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
[DefaultMember("Item")]
public class JObject : JContainer, IDictionary<string, JToken>, ICollection<KeyValuePair<string, JToken>>, IEnumerable<KeyValuePair<string, JToken>>, IEnumerable, ICustomTypeDescriptor // TypeDefIndex: 6208
{
	// Fields
	private readonly JPropertyKeyedCollection _properties; // 0x50
	[Nullable(2)]
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; // 0x58
	[Nullable(2)]
	[CompilerGenerated]
	private PropertyChangingEventHandler PropertyChanging; // 0x60

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public override JTokenType Type { get; }
	[Nullable(2)]
	public JToken Item { get; set; }
	[Nullable(new[] { 1, 2 })]
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get; }

	// Methods

	// RVA: 0x1979380 Offset: 0x1975380 VA: 0x1979380 Slot: 46
	protected override IList<JToken> get_ChildrenTokens() { }

	// RVA: 0x1978A54 Offset: 0x1974A54 VA: 0x1978A54
	public void .ctor() { }

	// RVA: 0x1979418 Offset: 0x1975418 VA: 0x1979418
	internal void .ctor(JObject other, JsonCloneSettings settings) { }

	[NullableContext(2)]
	// RVA: 0x1979494 Offset: 0x1975494 VA: 0x1979494 Slot: 49
	internal override int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x1979558 Offset: 0x1975558 VA: 0x1979558 Slot: 50
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	// RVA: 0x19795C8 Offset: 0x19755C8 VA: 0x19795C8 Slot: 59
	internal override void ValidateToken(JToken o, JToken existing) { }

	// RVA: 0x1979864 Offset: 0x1975864 VA: 0x1979864
	internal void InternalPropertyChanged(JProperty childProperty) { }

	// RVA: 0x19799B0 Offset: 0x19759B0 VA: 0x19799B0
	internal void InternalPropertyChanging(JProperty childProperty) { }

	// RVA: 0x19799D0 Offset: 0x19759D0 VA: 0x19799D0 Slot: 11
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	// RVA: 0x1979A38 Offset: 0x1975A38 VA: 0x1979A38 Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0x1979A40 Offset: 0x1975A40 VA: 0x1979A40
	public IEnumerable<JProperty> Properties() { }

	// RVA: 0x1978D40 Offset: 0x1974D40 VA: 0x1978D40
	public JProperty Property(string name, StringComparison comparison) { }

	// RVA: 0x1979A88 Offset: 0x1975A88 VA: 0x1979A88 Slot: 61
	public JToken get_Item(string propertyName) { }

	// RVA: 0x1979B08 Offset: 0x1975B08 VA: 0x1979B08 Slot: 62
	public void set_Item(string propertyName, JToken value) { }

	// RVA: 0x1979C7C Offset: 0x1975C7C VA: 0x1979C7C
	public static JObject Load(JsonReader reader, JsonLoadSettings settings) { }

	// RVA: 0x1979E40 Offset: 0x1975E40 VA: 0x1979E40 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x1979C00 Offset: 0x1975C00 VA: 0x1979C00 Slot: 65
	public void Add(string propertyName, JToken value) { }

	// RVA: 0x197A02C Offset: 0x197602C VA: 0x197A02C Slot: 64
	public bool ContainsKey(string propertyName) { }

	// RVA: 0x197A144 Offset: 0x1976144 VA: 0x197A144 Slot: 66
	public bool Remove(string propertyName) { }

	// RVA: 0x197A1D8 Offset: 0x19761D8 VA: 0x197A1D8 Slot: 67
	public bool TryGetValue(string propertyName, out JToken value) { }

	// RVA: 0x197A22C Offset: 0x197622C VA: 0x197A22C Slot: 63
	private ICollection<JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.get_Values() { }

	// RVA: 0x197A264 Offset: 0x1976264 VA: 0x197A264 Slot: 70
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(KeyValuePair<string, JToken> item) { }

	// RVA: 0x197A2F8 Offset: 0x19762F8 VA: 0x197A2F8 Slot: 71
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }

	// RVA: 0x197A308 Offset: 0x1976308 VA: 0x197A308 Slot: 72
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(KeyValuePair<string, JToken> item) { }

	// RVA: 0x197A388 Offset: 0x1976388 VA: 0x197A388 Slot: 73
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(KeyValuePair<string, JToken>[] array, int arrayIndex) { }

	// RVA: 0x197A7C8 Offset: 0x19767C8 VA: 0x197A7C8 Slot: 69
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.get_IsReadOnly() { }

	// RVA: 0x197A7D0 Offset: 0x19767D0 VA: 0x197A7D0 Slot: 74
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(KeyValuePair<string, JToken> item) { }

	[IteratorStateMachine(typeof(JObject.<GetEnumerator>d__64))]
	// RVA: 0x197A910 Offset: 0x1976910 VA: 0x197A910 Slot: 75
	public IEnumerator<KeyValuePair<string, JToken>> GetEnumerator() { }

	// RVA: 0x197A9A4 Offset: 0x19769A4 VA: 0x197A9A4 Slot: 81
	protected virtual void OnPropertyChanged(string propertyName) { }

	// RVA: 0x197AA34 Offset: 0x1976A34 VA: 0x197AA34 Slot: 82
	protected virtual void OnPropertyChanging(string propertyName) { }

	// RVA: 0x197AAC4 Offset: 0x1976AC4 VA: 0x197AAC4 Slot: 78
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x197AB60 Offset: 0x1976B60 VA: 0x197AB60 Slot: 79
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x197AEA4 Offset: 0x1976EA4 VA: 0x197AEA4 Slot: 76
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x197AEFC Offset: 0x1976EFC VA: 0x197AEFC Slot: 77
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	[NullableContext(2)]
	// RVA: 0x197AF50 Offset: 0x1976F50 VA: 0x197AF50 Slot: 80
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0x197AFCC Offset: 0x1976FCC VA: 0x197AFCC Slot: 18
	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JProperty.JPropertyList.<GetEnumerator>d__1 : IEnumerator<JToken>, IEnumerator, IDisposable // TypeDefIndex: 6209
{
	// Fields
	private int <>1__state; // 0x10
	private JToken <>2__current; // 0x18
	[Nullable(0)]
	public JProperty.JPropertyList <>4__this; // 0x20

	// Properties
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x197C0D4 Offset: 0x19780D4 VA: 0x197C0D4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x197C29C Offset: 0x197829C VA: 0x197C29C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x197C2A0 Offset: 0x19782A0 VA: 0x197C2A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x197C308 Offset: 0x1978308 VA: 0x197C308 Slot: 4
	private JToken System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x197C310 Offset: 0x1978310 VA: 0x197C310 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x197C348 Offset: 0x1978348 VA: 0x197C348 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[Nullable(0)]
[DefaultMember("Item")]
private class JProperty.JPropertyList : IList<JToken>, ICollection<JToken>, IEnumerable<JToken>, IEnumerable // TypeDefIndex: 6210
{
	// Fields
	[Nullable(2)]
	internal JToken _token; // 0x10

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public JToken Item { get; set; }

	// Methods

	[IteratorStateMachine(typeof(JProperty.JPropertyList.<GetEnumerator>d__1))]
	// RVA: 0x197C068 Offset: 0x1978068 VA: 0x197C068 Slot: 16
	public IEnumerator<JToken> GetEnumerator() { }

	// RVA: 0x197C0FC Offset: 0x19780FC VA: 0x197C0FC Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x197C100 Offset: 0x1978100 VA: 0x197C100 Slot: 11
	public void Add(JToken item) { }

	// RVA: 0x197C108 Offset: 0x1978108 VA: 0x197C108 Slot: 12
	public void Clear() { }

	// RVA: 0x197C114 Offset: 0x1978114 VA: 0x197C114 Slot: 13
	public bool Contains(JToken item) { }

	// RVA: 0x197C124 Offset: 0x1978124 VA: 0x197C124 Slot: 14
	public void CopyTo(JToken[] array, int arrayIndex) { }

	// RVA: 0x197C198 Offset: 0x1978198 VA: 0x197C198 Slot: 15
	public bool Remove(JToken item) { }

	// RVA: 0x197C1D0 Offset: 0x19781D0 VA: 0x197C1D0 Slot: 9
	public int get_Count() { }

	// RVA: 0x197C1E0 Offset: 0x19781E0 VA: 0x197C1E0 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x197BB98 Offset: 0x1977B98 VA: 0x197BB98 Slot: 6
	public int IndexOf(JToken item) { }

	// RVA: 0x197C1E8 Offset: 0x19781E8 VA: 0x197C1E8 Slot: 7
	public void Insert(int index, JToken item) { }

	// RVA: 0x197C1FC Offset: 0x19781FC VA: 0x197C1FC Slot: 8
	public void RemoveAt(int index) { }

	// RVA: 0x197C210 Offset: 0x1978210 VA: 0x197C210 Slot: 4
	public JToken get_Item(int index) { }

	// RVA: 0x197C254 Offset: 0x1978254 VA: 0x197C254 Slot: 5
	public void set_Item(int index, JToken value) { }

	// RVA: 0x197B86C Offset: 0x197786C VA: 0x197B86C
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public class JProperty : JContainer // TypeDefIndex: 6211
{
	// Fields
	private readonly JProperty.JPropertyList _content; // 0x50
	private readonly string _name; // 0x58

	// Properties
	protected override IList<JToken> ChildrenTokens { get; }
	public string Name { get; }
	public JToken Value { get; set; }
	public override JTokenType Type { get; }

	// Methods

	// RVA: 0x197B7C4 Offset: 0x19777C4 VA: 0x197B7C4 Slot: 46
	protected override IList<JToken> get_ChildrenTokens() { }

	[DebuggerStepThrough]
	// RVA: 0x197B7CC Offset: 0x19777CC VA: 0x197B7CC
	public string get_Name() { }

	[DebuggerStepThrough]
	// RVA: 0x1978A3C Offset: 0x1974A3C VA: 0x1978A3C
	public JToken get_Value() { }

	// RVA: 0x1979B80 Offset: 0x1975B80 VA: 0x1979B80
	public void set_Value(JToken value) { }

	// RVA: 0x197B7D4 Offset: 0x19777D4 VA: 0x197B7D4
	internal void .ctor(JProperty other, JsonCloneSettings settings) { }

	// RVA: 0x197B874 Offset: 0x1977874 VA: 0x197B874 Slot: 53
	internal override JToken GetItem(int index) { }

	[NullableContext(2)]
	// RVA: 0x197B8C8 Offset: 0x19778C8 VA: 0x197B8C8 Slot: 54
	internal override void SetItem(int index, JToken item) { }

	[NullableContext(2)]
	// RVA: 0x197BA0C Offset: 0x1977A0C VA: 0x197BA0C Slot: 52
	internal override bool RemoveItem(JToken item) { }

	// RVA: 0x197BABC Offset: 0x1977ABC VA: 0x197BABC Slot: 51
	internal override void RemoveItemAt(int index) { }

	[NullableContext(2)]
	// RVA: 0x197BB6C Offset: 0x1977B6C VA: 0x197BB6C Slot: 49
	internal override int IndexOfItem(JToken item) { }

	[NullableContext(2)]
	// RVA: 0x197BBA8 Offset: 0x1977BA8 VA: 0x197BBA8 Slot: 50
	internal override bool InsertItem(int index, JToken item, bool skipParentCheck, bool copyAnnotations) { }

	[NullableContext(2)]
	// RVA: 0x197BCC4 Offset: 0x1977CC4 VA: 0x197BCC4 Slot: 57
	internal override bool ContainsItem(JToken item) { }

	// RVA: 0x197BCE4 Offset: 0x1977CE4 VA: 0x197BCE4 Slot: 55
	internal override void ClearItems() { }

	// RVA: 0x197BD94 Offset: 0x1977D94 VA: 0x197BD94 Slot: 11
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	[DebuggerStepThrough]
	// RVA: 0x197BDFC Offset: 0x1977DFC VA: 0x197BDFC Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0x1978EC8 Offset: 0x1974EC8 VA: 0x1978EC8
	internal void .ctor(string name) { }

	// RVA: 0x1979F28 Offset: 0x1975F28 VA: 0x1979F28
	public void .ctor(string name, object content) { }

	// RVA: 0x197BE04 Offset: 0x1977E04 VA: 0x197BE04 Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	// RVA: 0x197BE84 Offset: 0x1977E84 VA: 0x197BE84
	public static JProperty Load(JsonReader reader, JsonLoadSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public class JPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 6212
{
	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	protected override int NameHashCode { get; }

	// Methods

	// RVA: 0x197AE98 Offset: 0x1976E98 VA: 0x197AE98
	public void .ctor(string name) { }

	// RVA: 0x197C350 Offset: 0x1978350 VA: 0x197C350 Slot: 17
	public override bool CanResetValue(object component) { }

	[NullableContext(2)]
	// RVA: 0x197C358 Offset: 0x1978358 VA: 0x197C358 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x197C3F4 Offset: 0x19783F4 VA: 0x197C3F4 Slot: 20
	public override void ResetValue(object component) { }

	[NullableContext(2)]
	// RVA: 0x197C3F8 Offset: 0x19783F8 VA: 0x197C3F8 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x197C528 Offset: 0x1978528 VA: 0x197C528 Slot: 22
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x197C530 Offset: 0x1978530 VA: 0x197C530 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x197C590 Offset: 0x1978590 VA: 0x197C590 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x197C598 Offset: 0x1978598 VA: 0x197C598 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x197C5C8 Offset: 0x19785C8 VA: 0x197C5C8 Slot: 8
	protected override int get_NameHashCode() { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(new[] { 0, 1 })]
[DefaultMember("Item")]
internal class JPropertyKeyedCollection : Collection<JToken> // TypeDefIndex: 6213
{
	// Fields
	private static readonly IEqualityComparer<string> Comparer; // 0x0
	[Nullable(new[] { 2, 1, 1 })]
	private Dictionary<string, JToken> _dictionary; // 0x18

	// Methods

	// RVA: 0x1979388 Offset: 0x1975388 VA: 0x1979388
	public void .ctor() { }

	// RVA: 0x197C5D0 Offset: 0x19785D0 VA: 0x197C5D0
	private void AddKey(string key, JToken item) { }

	// RVA: 0x197C6FC Offset: 0x19786FC VA: 0x197C6FC Slot: 35
	protected override void ClearItems() { }

	// RVA: 0x197A098 Offset: 0x1976098 VA: 0x197A098
	public bool Contains(string key) { }

	// RVA: 0x197C640 Offset: 0x1978640 VA: 0x197C640
	private void EnsureDictionary() { }

	// RVA: 0x197C774 Offset: 0x1978774 VA: 0x197C774
	private string GetKeyForItem(JToken item) { }

	// RVA: 0x197C7F4 Offset: 0x19787F4 VA: 0x197C7F4 Slot: 36
	protected override void InsertItem(int index, JToken item) { }

	// RVA: 0x197C86C Offset: 0x197886C VA: 0x197C86C Slot: 37
	protected override void RemoveItem(int index) { }

	// RVA: 0x197C960 Offset: 0x1978960 VA: 0x197C960
	private void RemoveKey(string key) { }

	// RVA: 0x197C9C0 Offset: 0x19789C0 VA: 0x197C9C0 Slot: 38
	protected override void SetItem(int index, JToken item) { }

	// RVA: 0x19797DC Offset: 0x19757DC VA: 0x19797DC
	public bool TryGetValue(string key, out JToken value) { }

	// RVA: 0x19794B4 Offset: 0x19754B4 VA: 0x19794B4
	public int IndexOfReference(JToken t) { }

	// RVA: 0x197CBC8 Offset: 0x1978BC8 VA: 0x197CBC8
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public class JRaw : JValue // TypeDefIndex: 6214
{
	// Methods

	// RVA: 0x197CC78 Offset: 0x1978C78 VA: 0x197CC78
	internal void .ctor(JRaw other, JsonCloneSettings settings) { }

	[NullableContext(2)]
	// RVA: 0x197CD3C Offset: 0x1978D3C VA: 0x197CD3C
	public void .ctor(object rawJson) { }

	// RVA: 0x197CDC4 Offset: 0x1978DC4 VA: 0x197CDC4
	public static JRaw Create(JsonReader reader) { }

	// RVA: 0x197D0A4 Offset: 0x19790A4 VA: 0x197D0A4 Slot: 11
	internal override JToken CloneToken(JsonCloneSettings settings) { }
}

// Namespace: Newtonsoft.Json.Linq
public class JsonCloneSettings // TypeDefIndex: 6215
{
	// Fields
	[Nullable(1)]
	internal static readonly JsonCloneSettings SkipCopyAnnotations; // 0x0
	[CompilerGenerated]
	private bool <CopyAnnotations>k__BackingField; // 0x10

	// Properties
	public bool CopyAnnotations { get; set; }

	// Methods

	// RVA: 0x197D10C Offset: 0x197910C VA: 0x197D10C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x197D12C Offset: 0x197912C VA: 0x197D12C
	public bool get_CopyAnnotations() { }

	[CompilerGenerated]
	// RVA: 0x197D134 Offset: 0x1979134 VA: 0x197D134
	public void set_CopyAnnotations(bool value) { }

	// RVA: 0x197D13C Offset: 0x197913C VA: 0x197D13C
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Linq
public class JsonLoadSettings // TypeDefIndex: 6216
{
	// Fields
	private CommentHandling _commentHandling; // 0x10
	private LineInfoHandling _lineInfoHandling; // 0x14
	private DuplicatePropertyNameHandling _duplicatePropertyNameHandling; // 0x18

	// Properties
	public CommentHandling CommentHandling { get; }
	public LineInfoHandling LineInfoHandling { get; }
	public DuplicatePropertyNameHandling DuplicatePropertyNameHandling { get; }

	// Methods

	// RVA: 0x197D1A8 Offset: 0x19791A8 VA: 0x197D1A8
	public CommentHandling get_CommentHandling() { }

	// RVA: 0x197D1B0 Offset: 0x19791B0 VA: 0x197D1B0
	public LineInfoHandling get_LineInfoHandling() { }

	// RVA: 0x197D1B8 Offset: 0x19791B8 VA: 0x197D1B8
	public DuplicatePropertyNameHandling get_DuplicatePropertyNameHandling() { }
}

// Namespace: 
[NullableContext(0)]
private class JToken.LineInfoAnnotation // TypeDefIndex: 6217
{
	// Fields
	internal readonly int LineNumber; // 0x10
	internal readonly int LinePosition; // 0x14

	// Methods

	// RVA: 0x1983E90 Offset: 0x197FE90 VA: 0x1983E90
	public void .ctor(int lineNumber, int linePosition) { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
[DefaultMember("Item")]
public abstract class JToken : IEnumerable<JToken>, IEnumerable, IJsonLineInfo, ICloneable, IDynamicMetaObjectProvider // TypeDefIndex: 6218
{
	// Fields
	[Nullable(2)]
	private JContainer _parent; // 0x10
	[Nullable(2)]
	private JToken _previous; // 0x18
	[Nullable(2)]
	private JToken _next; // 0x20
	[Nullable(2)]
	private object _annotations; // 0x28
	private static readonly JTokenType[] BooleanTypes; // 0x0
	private static readonly JTokenType[] NumberTypes; // 0x8
	private static readonly JTokenType[] BigIntegerTypes; // 0x10
	private static readonly JTokenType[] StringTypes; // 0x18
	private static readonly JTokenType[] GuidTypes; // 0x20
	private static readonly JTokenType[] TimeSpanTypes; // 0x28
	private static readonly JTokenType[] UriTypes; // 0x30
	private static readonly JTokenType[] CharTypes; // 0x38
	private static readonly JTokenType[] DateTimeTypes; // 0x40
	private static readonly JTokenType[] BytesTypes; // 0x48

	// Properties
	[Nullable(2)]
	public JContainer Parent { get; set; }
	public JToken Root { get; }
	public abstract JTokenType Type { get; }
	public abstract bool HasValues { get; }
	[Nullable(2)]
	public JToken Next { get; set; }
	[Nullable(2)]
	public JToken Previous { get; set; }
	public string Path { get; }
	[Nullable(2)]
	public virtual JToken First { get; }
	[Nullable(2)]
	public virtual JToken Last { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x197D1C0 Offset: 0x19791C0 VA: 0x197D1C0
	public JContainer get_Parent() { }

	[NullableContext(2)]
	// RVA: 0x197D1C8 Offset: 0x19791C8 VA: 0x197D1C8
	internal void set_Parent(JContainer value) { }

	// RVA: 0x19768B8 Offset: 0x19728B8 VA: 0x19768B8
	public JToken get_Root() { }

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract JToken CloneToken(JsonCloneSettings settings);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract JTokenType get_Type();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool get_HasValues();

	[NullableContext(2)]
	// RVA: 0x197D1D0 Offset: 0x19791D0 VA: 0x197D1D0
	public JToken get_Next() { }

	[NullableContext(2)]
	// RVA: 0x197D1D8 Offset: 0x19791D8 VA: 0x197D1D8
	internal void set_Next(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x197D1E0 Offset: 0x19791E0 VA: 0x197D1E0
	public JToken get_Previous() { }

	[NullableContext(2)]
	// RVA: 0x197D1E8 Offset: 0x19791E8 VA: 0x197D1E8
	internal void set_Previous(JToken value) { }

	// RVA: 0x197D1F0 Offset: 0x19791F0 VA: 0x197D1F0
	public string get_Path() { }

	// RVA: 0x1975D30 Offset: 0x1971D30 VA: 0x1975D30
	internal void .ctor() { }

	[NullableContext(2)]
	// RVA: 0x197D544 Offset: 0x1979544 VA: 0x197D544 Slot: 14
	public virtual JToken get_First() { }

	[NullableContext(2)]
	// RVA: 0x197D5D4 Offset: 0x19795D4 VA: 0x197D5D4 Slot: 15
	public virtual JToken get_Last() { }

	// RVA: 0x197D664 Offset: 0x1979664 VA: 0x197D664 Slot: 16
	public virtual JEnumerable<JToken> Children() { }

	// RVA: 0x197A170 Offset: 0x1976170 VA: 0x197A170
	public void Remove() { }

	// RVA: 0x1978F70 Offset: 0x1974F70 VA: 0x1978F70
	public void Replace(JToken value) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void WriteTo(JsonWriter writer, JsonConverter[] converters);

	// RVA: 0x197D6BC Offset: 0x19796BC VA: 0x197D6BC Slot: 3
	public override string ToString() { }

	// RVA: 0x197D75C Offset: 0x197975C VA: 0x197D75C
	public string ToString(Formatting formatting, JsonConverter[] converters) { }

	// RVA: 0x197D974 Offset: 0x1979974 VA: 0x197D974
	private static JValue EnsureValue(JToken value) { }

	// RVA: 0x197DA88 Offset: 0x1979A88 VA: 0x197DA88
	private static string GetType(JToken token) { }

	// RVA: 0x197DB78 Offset: 0x1979B78 VA: 0x197DB78
	private static bool ValidateToken(JToken o, JTokenType[] validTypes, bool nullable) { }

	// RVA: 0x197DC38 Offset: 0x1979C38 VA: 0x197DC38
	public static bool op_Explicit(JToken value) { }

	// RVA: 0x197DE40 Offset: 0x1979E40 VA: 0x197DE40
	public static DateTimeOffset op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x197E080 Offset: 0x197A080 VA: 0x197E080
	public static Nullable<bool> op_Explicit(JToken value) { }

	// RVA: 0x197E2D4 Offset: 0x197A2D4 VA: 0x197E2D4
	public static long op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x197E4B8 Offset: 0x197A4B8 VA: 0x197E4B8
	public static Nullable<DateTime> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x197E6E0 Offset: 0x197A6E0 VA: 0x197E6E0
	public static Nullable<DateTimeOffset> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x197E9A4 Offset: 0x197A9A4 VA: 0x197E9A4
	public static Nullable<Decimal> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x197EBE4 Offset: 0x197ABE4 VA: 0x197EBE4
	public static Nullable<double> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x197EE04 Offset: 0x197AE04 VA: 0x197EE04
	public static Nullable<char> op_Explicit(JToken value) { }

	// RVA: 0x197F028 Offset: 0x197B028 VA: 0x197F028
	public static int op_Explicit(JToken value) { }

	// RVA: 0x197F20C Offset: 0x197B20C VA: 0x197F20C
	public static short op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x197F3F0 Offset: 0x197B3F0 VA: 0x197F3F0
	public static ushort op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x197F5D4 Offset: 0x197B5D4 VA: 0x197F5D4
	public static char op_Explicit(JToken value) { }

	// RVA: 0x197F7B8 Offset: 0x197B7B8 VA: 0x197F7B8
	public static byte op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x197F99C Offset: 0x197B99C VA: 0x197F99C
	public static sbyte op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x197FB80 Offset: 0x197BB80 VA: 0x197FB80
	public static Nullable<int> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x197FDA4 Offset: 0x197BDA4 VA: 0x197FDA4
	public static Nullable<short> op_Explicit(JToken value) { }

	[NullableContext(2)]
	[CLSCompliant(False)]
	// RVA: 0x197FFC8 Offset: 0x197BFC8 VA: 0x197FFC8
	public static Nullable<ushort> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x19801EC Offset: 0x197C1EC VA: 0x19801EC
	public static Nullable<byte> op_Explicit(JToken value) { }

	[NullableContext(2)]
	[CLSCompliant(False)]
	// RVA: 0x1980410 Offset: 0x197C410 VA: 0x1980410
	public static Nullable<sbyte> op_Explicit(JToken value) { }

	// RVA: 0x1980634 Offset: 0x197C634 VA: 0x1980634
	public static DateTime op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x198082C Offset: 0x197C82C VA: 0x198082C
	public static Nullable<long> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1980A50 Offset: 0x197CA50 VA: 0x1980A50
	public static Nullable<float> op_Explicit(JToken value) { }

	// RVA: 0x1980C70 Offset: 0x197CC70 VA: 0x1980C70
	public static Decimal op_Explicit(JToken value) { }

	[NullableContext(2)]
	[CLSCompliant(False)]
	// RVA: 0x1980E54 Offset: 0x197CE54 VA: 0x1980E54
	public static Nullable<uint> op_Explicit(JToken value) { }

	[NullableContext(2)]
	[CLSCompliant(False)]
	// RVA: 0x1981078 Offset: 0x197D078 VA: 0x1981078
	public static Nullable<ulong> op_Explicit(JToken value) { }

	// RVA: 0x198129C Offset: 0x197D29C VA: 0x198129C
	public static double op_Explicit(JToken value) { }

	// RVA: 0x1981480 Offset: 0x197D480 VA: 0x1981480
	public static float op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1981664 Offset: 0x197D664 VA: 0x1981664
	public static string op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x19818EC Offset: 0x197D8EC VA: 0x19818EC
	public static uint op_Explicit(JToken value) { }

	[CLSCompliant(False)]
	// RVA: 0x1981AD0 Offset: 0x197DAD0 VA: 0x1981AD0
	public static ulong op_Explicit(JToken value) { }

	// RVA: 0x1981CB4 Offset: 0x197DCB4 VA: 0x1981CB4
	public static Guid op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1981ED4 Offset: 0x197DED4 VA: 0x1981ED4
	public static Nullable<Guid> op_Explicit(JToken value) { }

	// RVA: 0x1982144 Offset: 0x197E144 VA: 0x1982144
	public static TimeSpan op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1982340 Offset: 0x197E340 VA: 0x1982340
	public static Nullable<TimeSpan> op_Explicit(JToken value) { }

	[NullableContext(2)]
	// RVA: 0x1982578 Offset: 0x197E578 VA: 0x1982578
	public static Uri op_Explicit(JToken value) { }

	// RVA: 0x198276C Offset: 0x197E76C VA: 0x198276C
	private static BigInteger ToBigInteger(JToken value) { }

	// RVA: 0x19828B8 Offset: 0x197E8B8 VA: 0x19828B8
	private static Nullable<BigInteger> ToBigIntegerNullable(JToken value) { }

	// RVA: 0x1982A64 Offset: 0x197EA64 VA: 0x1982A64 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1982AF8 Offset: 0x197EAF8 VA: 0x1982AF8 Slot: 4
	private IEnumerator<JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { }

	// RVA: 0x1982B90 Offset: 0x197EB90 VA: 0x1982B90
	public JsonReader CreateReader() { }

	// RVA: 0x1982C5C Offset: 0x197EC5C VA: 0x1982C5C
	public object ToObject(Type objectType) { }

	[NullableContext(2)]
	// RVA: 0x198388C Offset: 0x197F88C VA: 0x198388C
	public object ToObject(Type objectType, JsonSerializer jsonSerializer) { }

	// RVA: 0x1983AAC Offset: 0x197FAAC VA: 0x1983AAC
	public static JToken ReadFrom(JsonReader reader) { }

	// RVA: 0x1983B04 Offset: 0x197FB04 VA: 0x1983B04
	public static JToken ReadFrom(JsonReader reader, JsonLoadSettings settings) { }

	[NullableContext(2)]
	// RVA: 0x197522C Offset: 0x197122C VA: 0x197522C
	internal void SetLineInfo(IJsonLineInfo lineInfo, JsonLoadSettings settings) { }

	// RVA: 0x1983E20 Offset: 0x197FE20 VA: 0x1983E20
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x1984114 Offset: 0x1980114 VA: 0x1984114 Slot: 6
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x1984168 Offset: 0x1980168 VA: 0x1984168 Slot: 7
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x19841BC Offset: 0x19801BC VA: 0x19841BC Slot: 8
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0x1984210 Offset: 0x1980210 VA: 0x1984210 Slot: 18
	protected virtual DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0x19842D8 Offset: 0x19802D8 VA: 0x19842D8 Slot: 10
	private DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(Expression parameter) { }

	// RVA: 0x19842E8 Offset: 0x19802E8 VA: 0x19842E8 Slot: 9
	private object System.ICloneable.Clone() { }

	// RVA: 0x19842F8 Offset: 0x19802F8 VA: 0x19842F8
	public JToken DeepClone() { }

	// RVA: 0x1983EBC Offset: 0x197FEBC VA: 0x1983EBC
	public void AddAnnotation(object annotation) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111A9C0 Offset: 0x11169C0 VA: 0x111A9C0
	|-JToken.Annotation<object>
	*/

	// RVA: 0x1975D38 Offset: 0x1971D38 VA: 0x1975D38
	internal void CopyAnnotations(JToken target, JToken source) { }

	// RVA: 0x1984308 Offset: 0x1980308 VA: 0x1984308
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(1)]
[Nullable(0)]
public class JTokenReader : JsonReader, IJsonLineInfo // TypeDefIndex: 6219
{
	// Fields
	private readonly JToken _root; // 0x78
	[Nullable(2)]
	private string _initialPath; // 0x80
	[Nullable(2)]
	private JToken _parent; // 0x88
	[Nullable(2)]
	private JToken _current; // 0x90

	// Properties
	[Nullable(2)]
	public JToken CurrentToken { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }
	public override string Path { get; }

	// Methods

	[NullableContext(2)]
	// RVA: 0x1984610 Offset: 0x1980610 VA: 0x1984610
	public JToken get_CurrentToken() { }

	// RVA: 0x1982BE8 Offset: 0x197EBE8 VA: 0x1982BE8
	public void .ctor(JToken token) { }

	// RVA: 0x1984618 Offset: 0x1980618 VA: 0x1984618 Slot: 10
	public override bool Read() { }

	// RVA: 0x1984778 Offset: 0x1980778 VA: 0x1984778
	private bool ReadOver(JToken t) { }

	// RVA: 0x1984E64 Offset: 0x1980E64 VA: 0x1984E64
	private bool ReadToEnd() { }

	// RVA: 0x1984F34 Offset: 0x1980F34 VA: 0x1984F34
	private Nullable<JsonToken> GetEndToken(JContainer c) { }

	// RVA: 0x19846F4 Offset: 0x19806F4 VA: 0x19846F4
	private bool ReadInto(JContainer c) { }

	// RVA: 0x1984E94 Offset: 0x1980E94 VA: 0x1984E94
	private bool SetEnd(JContainer c) { }

	// RVA: 0x1984844 Offset: 0x1980844 VA: 0x1984844
	private void SetToken(JToken token) { }

	[NullableContext(2)]
	// RVA: 0x1985078 Offset: 0x1981078 VA: 0x1985078
	private string SafeToString(object value) { }

	// RVA: 0x1985098 Offset: 0x1981098 VA: 0x1985098 Slot: 21
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x198514C Offset: 0x198114C VA: 0x198514C Slot: 22
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x1985204 Offset: 0x1981204 VA: 0x1985204 Slot: 23
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }

	// RVA: 0x19852BC Offset: 0x19812BC VA: 0x19852BC Slot: 9
	public override string get_Path() { }
}

// Namespace: Newtonsoft.Json.Linq
public enum JTokenType // TypeDefIndex: 6220
{
	// Fields
	public int value__; // 0x0
	public const JTokenType None = 0;
	public const JTokenType Object = 1;
	public const JTokenType Array = 2;
	public const JTokenType Constructor = 3;
	public const JTokenType Property = 4;
	public const JTokenType Comment = 5;
	public const JTokenType Integer = 6;
	public const JTokenType Float = 7;
	public const JTokenType String = 8;
	public const JTokenType Boolean = 9;
	public const JTokenType Null = 10;
	public const JTokenType Undefined = 11;
	public const JTokenType Date = 12;
	public const JTokenType Raw = 13;
	public const JTokenType Bytes = 14;
	public const JTokenType Guid = 15;
	public const JTokenType Uri = 16;
	public const JTokenType TimeSpan = 17;
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(2)]
[Nullable(0)]
public class JTokenWriter : JsonWriter // TypeDefIndex: 6221
{
	// Fields
	private JContainer _token; // 0x60
	private JContainer _parent; // 0x68
	private JValue _value; // 0x70
	private JToken _current; // 0x78

	// Properties
	public JToken Token { get; }

	// Methods

	// RVA: 0x19853AC Offset: 0x19813AC VA: 0x19853AC
	public JToken get_Token() { }

	// RVA: 0x19853C8 Offset: 0x19813C8 VA: 0x19853C8
	public void .ctor() { }

	// RVA: 0x1985420 Offset: 0x1981420 VA: 0x1985420 Slot: 6
	public override void Close() { }

	// RVA: 0x1985428 Offset: 0x1981428 VA: 0x1985428 Slot: 7
	public override void WriteStartObject() { }

	[NullableContext(1)]
	// RVA: 0x198548C Offset: 0x198148C VA: 0x198548C
	private void AddParent(JContainer container) { }

	// RVA: 0x19854EC Offset: 0x19814EC VA: 0x19854EC
	private void RemoveParent() { }

	// RVA: 0x198555C Offset: 0x198155C VA: 0x198555C Slot: 9
	public override void WriteStartArray() { }

	[NullableContext(1)]
	// RVA: 0x19855C0 Offset: 0x19815C0 VA: 0x19855C0 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x1985638 Offset: 0x1981638 VA: 0x1985638 Slot: 17
	protected override void WriteEnd(JsonToken token) { }

	[NullableContext(1)]
	// RVA: 0x198563C Offset: 0x198163C VA: 0x198563C Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0x19856FC Offset: 0x19816FC VA: 0x19856FC
	private void AddRawValue(object value, JTokenType type, JsonToken token) { }

	// RVA: 0x198576C Offset: 0x198176C VA: 0x198576C
	internal void AddJValue(JValue value, JsonToken token) { }

	// RVA: 0x198582C Offset: 0x198182C VA: 0x198582C Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0x19858BC Offset: 0x19818BC VA: 0x19858BC Slot: 21
	public override void WriteNull() { }

	// RVA: 0x19858E0 Offset: 0x19818E0 VA: 0x19858E0 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0x1985904 Offset: 0x1981904 VA: 0x1985904 Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0x1985980 Offset: 0x1981980 VA: 0x1985980 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0x19859B4 Offset: 0x19819B4 VA: 0x19859B4 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0x1985A38 Offset: 0x1981A38 VA: 0x1985A38 Slot: 26
	public override void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1985A88 Offset: 0x1981A88 VA: 0x1985A88 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0x1985AD8 Offset: 0x1981AD8 VA: 0x1985AD8 Slot: 28
	public override void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1985BC4 Offset: 0x1981BC4 VA: 0x1985BC4 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0x1985CA0 Offset: 0x1981CA0 VA: 0x1985CA0 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0x1985D7C Offset: 0x1981D7C VA: 0x1985D7C Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0x1985E68 Offset: 0x1981E68 VA: 0x1985E68 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0x1985F54 Offset: 0x1981F54 VA: 0x1985F54 Slot: 33
	public override void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1985FA4 Offset: 0x1981FA4 VA: 0x1985FA4 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0x1985FF4 Offset: 0x1981FF4 VA: 0x1985FF4 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0x19860DC Offset: 0x19820DC VA: 0x19860DC Slot: 36
	public override void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x198612C Offset: 0x198212C VA: 0x198612C Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0x198617C Offset: 0x198217C VA: 0x198617C Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0x198627C Offset: 0x198227C VA: 0x198627C Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0x19863A0 Offset: 0x19823A0 VA: 0x19863A0 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x198649C Offset: 0x198249C VA: 0x198649C Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0x1986518 Offset: 0x1982518 VA: 0x1986518 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x19865FC Offset: 0x19825FC VA: 0x19865FC Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0x19866F8 Offset: 0x19826F8 VA: 0x19866F8 Slot: 61
	public override void WriteValue(Uri value) { }

	[NullableContext(1)]
	// RVA: 0x19867F4 Offset: 0x19827F4 VA: 0x19867F4 Slot: 16
	internal override void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }
}

// Namespace: 
[NullableContext(1)]
[Nullable(new[] { 0, 1 })]
private class JValue.JValueDynamicProxy : DynamicProxy<JValue> // TypeDefIndex: 6222
{
	// Methods

	// RVA: 0x1989840 Offset: 0x1985840 VA: 0x1989840 Slot: 6
	public override bool TryConvert(JValue instance, ConvertBinder binder, out object result) { }

	// RVA: 0x1989A20 Offset: 0x1985A20 VA: 0x1989A20 Slot: 5
	public override bool TryBinaryOperation(JValue instance, BinaryOperationBinder binder, object arg, out object result) { }

	// RVA: 0x19891C0 Offset: 0x19851C0 VA: 0x19891C0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Linq
[NullableContext(2)]
[Nullable(0)]
public class JValue : JToken, IEquatable<JValue>, IFormattable, IComparable, IComparable<JValue>, IConvertible // TypeDefIndex: 6223
{
	// Fields
	private JTokenType _valueType; // 0x30
	private object _value; // 0x38

	// Properties
	public override bool HasValues { get; }
	public override JTokenType Type { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x197CD44 Offset: 0x1978D44 VA: 0x197CD44
	internal void .ctor(object value, JTokenType type) { }

	[NullableContext(1)]
	// RVA: 0x197CC7C Offset: 0x1978C7C VA: 0x197CC7C
	internal void .ctor(JValue other, JsonCloneSettings settings) { }

	// RVA: 0x1985B50 Offset: 0x1981B50 VA: 0x1985B50
	public void .ctor(long value) { }

	// RVA: 0x1986200 Offset: 0x1982200 VA: 0x1986200
	public void .ctor(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1985C60 Offset: 0x1981C60 VA: 0x1985C60
	public void .ctor(ulong value) { }

	// RVA: 0x1985DF4 Offset: 0x1981DF4 VA: 0x1985DF4
	public void .ctor(double value) { }

	// RVA: 0x1985D3C Offset: 0x1981D3C VA: 0x1985D3C
	public void .ctor(float value) { }

	// RVA: 0x1986334 Offset: 0x1982334 VA: 0x1986334
	public void .ctor(DateTime value) { }

	// RVA: 0x1986424 Offset: 0x1982424 VA: 0x1986424
	public void .ctor(DateTimeOffset value) { }

	// RVA: 0x1985EE0 Offset: 0x1981EE0 VA: 0x1985EE0
	public void .ctor(bool value) { }

	// RVA: 0x1985A30 Offset: 0x1981A30 VA: 0x1985A30
	public void .ctor(string value) { }

	// RVA: 0x1986680 Offset: 0x1982680 VA: 0x1986680
	public void .ctor(Guid value) { }

	// RVA: 0x1986770 Offset: 0x1982770 VA: 0x1986770
	public void .ctor(Uri value) { }

	// RVA: 0x1986590 Offset: 0x1982590 VA: 0x1986590
	public void .ctor(TimeSpan value) { }

	// RVA: 0x19785F8 Offset: 0x19745F8 VA: 0x19785F8
	public void .ctor(object value) { }

	// RVA: 0x1986E20 Offset: 0x1982E20 VA: 0x1986E20 Slot: 13
	public override bool get_HasValues() { }

	[NullableContext(1)]
	// RVA: 0x1986E28 Offset: 0x1982E28 VA: 0x1986E28
	private static int CompareBigInteger(BigInteger i1, object i2) { }

	// RVA: 0x1987110 Offset: 0x1983110 VA: 0x1987110
	internal static int Compare(JTokenType valueType, object objA, object objB) { }

	[NullableContext(1)]
	// RVA: 0x1987BB0 Offset: 0x1983BB0 VA: 0x1987BB0
	private static int CompareFloat(object objA, object objB) { }

	// RVA: 0x1987CAC Offset: 0x1983CAC VA: 0x1987CAC
	private static bool Operation(ExpressionType operation, object objA, object objB, out object result) { }

	[NullableContext(1)]
	// RVA: 0x19884A8 Offset: 0x19844A8 VA: 0x19884A8 Slot: 11
	internal override JToken CloneToken(JsonCloneSettings settings) { }

	[NullableContext(1)]
	// RVA: 0x1978AB8 Offset: 0x1974AB8 VA: 0x1978AB8
	public static JValue CreateComment(string value) { }

	[NullableContext(1)]
	// RVA: 0x1976860 Offset: 0x1972860 VA: 0x1976860
	public static JValue CreateNull() { }

	[NullableContext(1)]
	// RVA: 0x1978B14 Offset: 0x1974B14 VA: 0x1978B14
	public static JValue CreateUndefined() { }

	// RVA: 0x1986AF8 Offset: 0x1982AF8 VA: 0x1986AF8
	private static JTokenType GetValueType(Nullable<JTokenType> current, object value) { }

	// RVA: 0x1988510 Offset: 0x1984510 VA: 0x1988510
	private static JTokenType GetStringValueType(Nullable<JTokenType> current) { }

	// RVA: 0x198858C Offset: 0x198458C VA: 0x198858C Slot: 12
	public override JTokenType get_Type() { }

	// RVA: 0x1988594 Offset: 0x1984594 VA: 0x1988594
	public object get_Value() { }

	[NullableContext(1)]
	// RVA: 0x198859C Offset: 0x198459C VA: 0x198859C Slot: 17
	public override void WriteTo(JsonWriter writer, JsonConverter[] converters) { }

	[NullableContext(1)]
	// RVA: 0x1988EBC Offset: 0x1984EBC VA: 0x1988EBC
	private static bool ValuesEquals(JValue v1, JValue v2) { }

	// RVA: 0x1988F18 Offset: 0x1984F18 VA: 0x1988F18 Slot: 19
	public bool Equals(JValue other) { }

	// RVA: 0x1988F28 Offset: 0x1984F28 VA: 0x1988F28 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1988FB4 Offset: 0x1984FB4 VA: 0x1988FB4 Slot: 2
	public override int GetHashCode() { }

	[NullableContext(1)]
	// RVA: 0x1988FCC Offset: 0x1984FCC VA: 0x1988FCC Slot: 3
	public override string ToString() { }

	[NullableContext(1)]
	// RVA: 0x1988FF8 Offset: 0x1984FF8 VA: 0x1988FF8 Slot: 38
	public string ToString(IFormatProvider formatProvider) { }

	// RVA: 0x1989004 Offset: 0x1985004 VA: 0x1989004 Slot: 20
	public string ToString(string format, IFormatProvider formatProvider) { }

	[NullableContext(1)]
	// RVA: 0x1989110 Offset: 0x1985110 VA: 0x1989110 Slot: 18
	protected override DynamicMetaObject GetMetaObject(Expression parameter) { }

	// RVA: 0x1989208 Offset: 0x1985208 VA: 0x1989208 Slot: 21
	private int System.IComparable.CompareTo(object obj) { }

	// RVA: 0x19892B8 Offset: 0x19852B8 VA: 0x19892B8 Slot: 22
	public int CompareTo(JValue obj) { }

	// RVA: 0x19892E8 Offset: 0x19852E8 VA: 0x19892E8 Slot: 23
	private TypeCode System.IConvertible.GetTypeCode() { }

	// RVA: 0x19893A4 Offset: 0x19853A4 VA: 0x19893A4 Slot: 24
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x19893F8 Offset: 0x19853F8 VA: 0x19893F8 Slot: 25
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x198944C Offset: 0x198544C VA: 0x198944C Slot: 26
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x19894A0 Offset: 0x19854A0 VA: 0x19894A0 Slot: 27
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x19894F4 Offset: 0x19854F4 VA: 0x19894F4 Slot: 28
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1989548 Offset: 0x1985548 VA: 0x1989548 Slot: 29
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x198959C Offset: 0x198559C VA: 0x198959C Slot: 30
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x19895F0 Offset: 0x19855F0 VA: 0x19895F0 Slot: 31
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1989644 Offset: 0x1985644 VA: 0x1989644 Slot: 32
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1989698 Offset: 0x1985698 VA: 0x1989698 Slot: 33
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x19896EC Offset: 0x19856EC VA: 0x19896EC Slot: 34
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1989740 Offset: 0x1985740 VA: 0x1989740 Slot: 35
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1989794 Offset: 0x1985794 VA: 0x1989794 Slot: 36
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x19897E8 Offset: 0x19857E8 VA: 0x19897E8 Slot: 37
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[NullableContext(1)]
	// RVA: 0x198983C Offset: 0x198583C VA: 0x198983C Slot: 39
	private object System.IConvertible.ToType(Type conversionType, IFormatProvider provider) { }
}

// Namespace: Newtonsoft.Json.Linq
public enum LineInfoHandling // TypeDefIndex: 6224
{
	// Fields
	public int value__; // 0x0
	public const LineInfoHandling Ignore = 0;
	public const LineInfoHandling Load = 1;
}
