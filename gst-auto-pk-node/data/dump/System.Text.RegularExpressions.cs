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

// Namespace: System.Text.RegularExpressions
public class Capture // TypeDefIndex: 3859
{
	// Fields
	[CompilerGenerated]
	private int <Index>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Length>k__BackingField; // 0x14
	[CompilerGenerated]
	private string <Text>k__BackingField; // 0x18

	// Properties
	public int Index { get; set; }
	public int Length { get; set; }
	internal string Text { get; set; }
	public string Value { get; }

	// Methods

	// RVA: 0x1CF8A24 Offset: 0x1CF4A24 VA: 0x1CF8A24
	internal void .ctor(string text, int index, int length) { }

	[CompilerGenerated]
	// RVA: 0x1CF8A6C Offset: 0x1CF4A6C VA: 0x1CF8A6C
	public int get_Index() { }

	[CompilerGenerated]
	// RVA: 0x1CF8A74 Offset: 0x1CF4A74 VA: 0x1CF8A74
	internal void set_Index(int value) { }

	[CompilerGenerated]
	// RVA: 0x1CF8A7C Offset: 0x1CF4A7C VA: 0x1CF8A7C
	public int get_Length() { }

	[CompilerGenerated]
	// RVA: 0x1CF8A84 Offset: 0x1CF4A84 VA: 0x1CF8A84
	internal void set_Length(int value) { }

	[CompilerGenerated]
	// RVA: 0x1CF8A8C Offset: 0x1CF4A8C VA: 0x1CF8A8C
	internal string get_Text() { }

	[CompilerGenerated]
	// RVA: 0x1CF8A94 Offset: 0x1CF4A94 VA: 0x1CF8A94
	internal void set_Text(string value) { }

	// RVA: 0x1CF8A9C Offset: 0x1CF4A9C VA: 0x1CF8A9C
	public string get_Value() { }

	// RVA: 0x1CF8ABC Offset: 0x1CF4ABC VA: 0x1CF8ABC Slot: 3
	public override string ToString() { }

	// RVA: 0x1CF8AC0 Offset: 0x1CF4AC0 VA: 0x1CF8AC0
	internal ReadOnlySpan<char> GetLeftSubstring() { }

	// RVA: 0x1CF8B48 Offset: 0x1CF4B48 VA: 0x1CF8B48
	internal ReadOnlySpan<char> GetRightSubstring() { }
}

// Namespace: 
[Serializable]
private sealed class CaptureCollection.Enumerator : IEnumerator<Capture>, IDisposable, IEnumerator // TypeDefIndex: 3860
{
	// Fields
	private readonly CaptureCollection _collection; // 0x10
	private int _index; // 0x18

	// Properties
	public Capture Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1CF8D74 Offset: 0x1CF4D74 VA: 0x1CF8D74
	internal void .ctor(CaptureCollection collection) { }

	// RVA: 0x1CF98D4 Offset: 0x1CF58D4 VA: 0x1CF98D4 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x1CF9910 Offset: 0x1CF5910 VA: 0x1CF9910 Slot: 4
	public Capture get_Current() { }

	// RVA: 0x1CF9984 Offset: 0x1CF5984 VA: 0x1CF9984 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1CF9988 Offset: 0x1CF5988 VA: 0x1CF9988 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1CF9994 Offset: 0x1CF5994 VA: 0x1CF9994 Slot: 5
	private void System.IDisposable.Dispose() { }
}

// Namespace: System.Text.RegularExpressions
[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Capture>))]
[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
public class CaptureCollection : IList<Capture>, ICollection<Capture>, IEnumerable<Capture>, IEnumerable, IReadOnlyList<Capture>, IReadOnlyCollection<Capture>, IList, ICollection // TypeDefIndex: 3861
{
	// Fields
	private readonly Group _group; // 0x10
	private readonly int _capcount; // 0x18
	private Capture[] _captures; // 0x20

	// Properties
	public bool IsReadOnly { get; }
	public int Count { get; }
	public Capture Item { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Item { get; set; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x1CF8BE0 Offset: 0x1CF4BE0 VA: 0x1CF8BE0
	internal void .ctor(Group group) { }

	// RVA: 0x1CF8C2C Offset: 0x1CF4C2C VA: 0x1CF8C2C Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0x1CF8C34 Offset: 0x1CF4C34 VA: 0x1CF8C34 Slot: 32
	public int get_Count() { }

	// RVA: 0x1CF8C3C Offset: 0x1CF4C3C VA: 0x1CF8C3C Slot: 18
	public Capture get_Item(int i) { }

	// RVA: 0x1CF8D04 Offset: 0x1CF4D04 VA: 0x1CF8D04 Slot: 17
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1CF8DB0 Offset: 0x1CF4DB0 VA: 0x1CF8DB0 Slot: 16
	private IEnumerator<Capture> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Capture>.GetEnumerator() { }

	// RVA: 0x1CF8C40 Offset: 0x1CF4C40 VA: 0x1CF8C40
	private Capture GetCapture(int i) { }

	// RVA: 0x1CF8E20 Offset: 0x1CF4E20 VA: 0x1CF8E20
	internal void ForceInitialized() { }

	// RVA: 0x1CF8FA8 Offset: 0x1CF4FA8 VA: 0x1CF8FA8 Slot: 34
	public bool get_IsSynchronized() { }

	// RVA: 0x1CF8FB0 Offset: 0x1CF4FB0 VA: 0x1CF8FB0 Slot: 33
	public object get_SyncRoot() { }

	// RVA: 0x1CF8FB8 Offset: 0x1CF4FB8 VA: 0x1CF8FB8 Slot: 31
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1CF906C Offset: 0x1CF506C VA: 0x1CF906C Slot: 14
	public void CopyTo(Capture[] array, int arrayIndex) { }

	// RVA: 0x1CF91E8 Offset: 0x1CF51E8 VA: 0x1CF91E8 Slot: 6
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.IndexOf(Capture item) { }

	// RVA: 0x1CF9298 Offset: 0x1CF5298 VA: 0x1CF9298 Slot: 7
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.Insert(int index, Capture item) { }

	// RVA: 0x1CF92E4 Offset: 0x1CF52E4 VA: 0x1CF92E4 Slot: 8
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.RemoveAt(int index) { }

	// RVA: 0x1CF9330 Offset: 0x1CF5330 VA: 0x1CF9330 Slot: 4
	private Capture System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.get_Item(int index) { }

	// RVA: 0x1CF9334 Offset: 0x1CF5334 VA: 0x1CF9334 Slot: 5
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Capture>.set_Item(int index, Capture value) { }

	// RVA: 0x1CF9380 Offset: 0x1CF5380 VA: 0x1CF9380 Slot: 11
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Add(Capture item) { }

	// RVA: 0x1CF93CC Offset: 0x1CF53CC VA: 0x1CF93CC Slot: 12
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Clear() { }

	// RVA: 0x1CF9418 Offset: 0x1CF5418 VA: 0x1CF9418 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Contains(Capture item) { }

	// RVA: 0x1CF94CC Offset: 0x1CF54CC VA: 0x1CF94CC Slot: 15
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Capture>.Remove(Capture item) { }

	// RVA: 0x1CF9518 Offset: 0x1CF5518 VA: 0x1CF9518 Slot: 22
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1CF9564 Offset: 0x1CF5564 VA: 0x1CF9564 Slot: 24
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1CF95B0 Offset: 0x1CF55B0 VA: 0x1CF95B0 Slot: 23
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1CF96A4 Offset: 0x1CF56A4 VA: 0x1CF96A4 Slot: 27
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1CF9798 Offset: 0x1CF5798 VA: 0x1CF9798 Slot: 28
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1CF97E4 Offset: 0x1CF57E4 VA: 0x1CF97E4 Slot: 26
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1CF97EC Offset: 0x1CF57EC VA: 0x1CF97EC Slot: 29
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1CF9838 Offset: 0x1CF5838 VA: 0x1CF9838 Slot: 30
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1CF9884 Offset: 0x1CF5884 VA: 0x1CF9884 Slot: 20
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1CF9888 Offset: 0x1CF5888 VA: 0x1CF9888 Slot: 21
	private void System.Collections.IList.set_Item(int index, object value) { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class CollectionDebuggerProxy<T> // TypeDefIndex: 3862
{}

// Namespace: System.Text.RegularExpressions
[Serializable]
public class Group : Capture // TypeDefIndex: 3863
{
	// Fields
	internal static readonly Group s_emptyGroup; // 0x0
	internal readonly int[] _caps; // 0x20
	internal int _capcount; // 0x28
	internal CaptureCollection _capcoll; // 0x30
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x38

	// Properties
	public bool Success { get; }
	public CaptureCollection Captures { get; }

	// Methods

	// RVA: 0x1CF9998 Offset: 0x1CF5998 VA: 0x1CF9998
	internal void .ctor(string text, int[] caps, int capcount, string name) { }

	// RVA: 0x1CF9A58 Offset: 0x1CF5A58 VA: 0x1CF9A58
	public bool get_Success() { }

	// RVA: 0x1CF9A68 Offset: 0x1CF5A68 VA: 0x1CF9A68
	public CaptureCollection get_Captures() { }

	// RVA: 0x1CF9ADC Offset: 0x1CF5ADC VA: 0x1CF9ADC
	private static void .cctor() { }

	// RVA: 0x1CF9BE4 Offset: 0x1CF5BE4 VA: 0x1CF9BE4
	internal void .ctor() { }
}

// Namespace: 
private sealed class GroupCollection.Enumerator : IEnumerator<Group>, IDisposable, IEnumerator // TypeDefIndex: 3864
{
	// Fields
	private readonly GroupCollection _collection; // 0x10
	private int _index; // 0x18

	// Properties
	public Group Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1CF9FE8 Offset: 0x1CF5FE8 VA: 0x1CF9FE8
	internal void .ctor(GroupCollection collection) { }

	// RVA: 0x1CFAD34 Offset: 0x1CF6D34 VA: 0x1CFAD34 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x1CFAD78 Offset: 0x1CF6D78 VA: 0x1CFAD78 Slot: 4
	public Group get_Current() { }

	// RVA: 0x1CFAE04 Offset: 0x1CF6E04 VA: 0x1CFAE04 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1CFAE08 Offset: 0x1CF6E08 VA: 0x1CFAE08 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1CFAE14 Offset: 0x1CF6E14 VA: 0x1CFAE14 Slot: 5
	private void System.IDisposable.Dispose() { }
}

// Namespace: System.Text.RegularExpressions
[DefaultMember("Item")]
[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Group>))]
[Serializable]
public class GroupCollection : IList<Group>, ICollection<Group>, IEnumerable<Group>, IEnumerable, IReadOnlyList<Group>, IReadOnlyCollection<Group>, IList, ICollection // TypeDefIndex: 3865
{
	// Fields
	private readonly Match _match; // 0x10
	private readonly Hashtable _captureMap; // 0x18
	private Group[] _groups; // 0x20

	// Properties
	public bool IsReadOnly { get; }
	public int Count { get; }
	public Group Item { get; }
	public Group Item { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Item { get; set; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x1CF9C1C Offset: 0x1CF5C1C VA: 0x1CF9C1C
	internal void .ctor(Match match, Hashtable caps) { }

	// RVA: 0x1CF9C60 Offset: 0x1CF5C60 VA: 0x1CF9C60 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0x1CF9C68 Offset: 0x1CF5C68 VA: 0x1CF9C68 Slot: 32
	public int get_Count() { }

	// RVA: 0x1CF9C8C Offset: 0x1CF5C8C VA: 0x1CF9C8C Slot: 18
	public Group get_Item(int groupnum) { }

	// RVA: 0x1CF9D94 Offset: 0x1CF5D94 VA: 0x1CF9D94
	public Group get_Item(string groupname) { }

	// RVA: 0x1CF9F78 Offset: 0x1CF5F78 VA: 0x1CF9F78 Slot: 17
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1CFA024 Offset: 0x1CF6024 VA: 0x1CFA024 Slot: 16
	private IEnumerator<Group> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Group>.GetEnumerator() { }

	// RVA: 0x1CF9C90 Offset: 0x1CF5C90 VA: 0x1CF9C90
	private Group GetGroup(int groupnum) { }

	// RVA: 0x1CFA094 Offset: 0x1CF6094 VA: 0x1CFA094
	private Group GetGroupImpl(int groupnum) { }

	// RVA: 0x1CFA3B0 Offset: 0x1CF63B0 VA: 0x1CFA3B0 Slot: 34
	public bool get_IsSynchronized() { }

	// RVA: 0x1CFA3B8 Offset: 0x1CF63B8 VA: 0x1CFA3B8 Slot: 33
	public object get_SyncRoot() { }

	// RVA: 0x1CFA3C0 Offset: 0x1CF63C0 VA: 0x1CFA3C0 Slot: 31
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1CFA478 Offset: 0x1CF6478 VA: 0x1CFA478 Slot: 14
	public void CopyTo(Group[] array, int arrayIndex) { }

	// RVA: 0x1CFA608 Offset: 0x1CF6608 VA: 0x1CFA608 Slot: 6
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.IndexOf(Group item) { }

	// RVA: 0x1CFA6C0 Offset: 0x1CF66C0 VA: 0x1CFA6C0 Slot: 7
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.Insert(int index, Group item) { }

	// RVA: 0x1CFA70C Offset: 0x1CF670C VA: 0x1CFA70C Slot: 8
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.RemoveAt(int index) { }

	// RVA: 0x1CFA758 Offset: 0x1CF6758 VA: 0x1CFA758 Slot: 4
	private Group System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.get_Item(int index) { }

	// RVA: 0x1CFA75C Offset: 0x1CF675C VA: 0x1CFA75C Slot: 5
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Group>.set_Item(int index, Group value) { }

	// RVA: 0x1CFA7A8 Offset: 0x1CF67A8 VA: 0x1CFA7A8 Slot: 11
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Add(Group item) { }

	// RVA: 0x1CFA7F4 Offset: 0x1CF67F4 VA: 0x1CFA7F4 Slot: 12
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Clear() { }

	// RVA: 0x1CFA840 Offset: 0x1CF6840 VA: 0x1CFA840 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Contains(Group item) { }

	// RVA: 0x1CFA8F4 Offset: 0x1CF68F4 VA: 0x1CFA8F4 Slot: 15
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Group>.Remove(Group item) { }

	// RVA: 0x1CFA940 Offset: 0x1CF6940 VA: 0x1CFA940 Slot: 22
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1CFA98C Offset: 0x1CF698C VA: 0x1CFA98C Slot: 24
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1CFA9D8 Offset: 0x1CF69D8 VA: 0x1CFA9D8 Slot: 23
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1CFAACC Offset: 0x1CF6ACC VA: 0x1CFAACC Slot: 27
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1CFABC0 Offset: 0x1CF6BC0 VA: 0x1CFABC0 Slot: 28
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1CFAC0C Offset: 0x1CF6C0C VA: 0x1CFAC0C Slot: 26
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1CFAC14 Offset: 0x1CF6C14 VA: 0x1CFAC14 Slot: 29
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1CFAC60 Offset: 0x1CF6C60 VA: 0x1CFAC60 Slot: 30
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1CFACAC Offset: 0x1CF6CAC VA: 0x1CFACAC Slot: 20
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1CFACB0 Offset: 0x1CF6CB0 VA: 0x1CFACB0 Slot: 21
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1CFACFC Offset: 0x1CF6CFC VA: 0x1CFACFC
	internal void .ctor() { }
}

// Namespace: System.Text.RegularExpressions
[Serializable]
public class Match : Group // TypeDefIndex: 3866
{
	// Fields
	internal GroupCollection _groupcoll; // 0x40
	internal Regex _regex; // 0x48
	internal int _textbeg; // 0x50
	internal int _textpos; // 0x54
	internal int _textend; // 0x58
	internal int _textstart; // 0x5C
	internal int[][] _matches; // 0x60
	internal int[] _matchcount; // 0x68
	internal bool _balancing; // 0x70
	[CompilerGenerated]
	private static readonly Match <Empty>k__BackingField; // 0x0

	// Properties
	public static Match Empty { get; }
	public virtual GroupCollection Groups { get; }

	// Methods

	// RVA: 0x1CFAE18 Offset: 0x1CF6E18 VA: 0x1CFAE18
	internal void .ctor(Regex regex, int capcount, string text, int begpos, int len, int startpos) { }

	[CompilerGenerated]
	// RVA: 0x1CFAF88 Offset: 0x1CF6F88 VA: 0x1CFAF88
	public static Match get_Empty() { }

	// RVA: 0x1CFAFE0 Offset: 0x1CF6FE0 VA: 0x1CFAFE0 Slot: 4
	internal virtual void Reset(Regex regex, string text, int textbeg, int textend, int textstart) { }

	// RVA: 0x1CFB07C Offset: 0x1CF707C VA: 0x1CFB07C Slot: 5
	public virtual GroupCollection get_Groups() { }

	// RVA: 0x1CFB0F4 Offset: 0x1CF70F4 VA: 0x1CFB0F4
	public Match NextMatch() { }

	// RVA: 0x1CFB3CC Offset: 0x1CF73CC VA: 0x1CFB3CC Slot: 6
	internal virtual ReadOnlySpan<char> GroupToStringImpl(int groupnum) { }

	// RVA: 0x1CFB53C Offset: 0x1CF753C VA: 0x1CFB53C
	internal ReadOnlySpan<char> LastGroupToStringImpl() { }

	// RVA: 0x1CFB560 Offset: 0x1CF7560 VA: 0x1CFB560 Slot: 7
	internal virtual void AddMatch(int cap, int start, int len) { }

	// RVA: 0x1CFB754 Offset: 0x1CF7754 VA: 0x1CFB754 Slot: 8
	internal virtual void BalanceMatch(int cap) { }

	// RVA: 0x1CFB82C Offset: 0x1CF782C VA: 0x1CFB82C Slot: 9
	internal virtual void RemoveMatch(int cap) { }

	// RVA: 0x1CFB864 Offset: 0x1CF7864 VA: 0x1CFB864 Slot: 10
	internal virtual bool IsMatched(int cap) { }

	// RVA: 0x1CFB8F4 Offset: 0x1CF78F4 VA: 0x1CFB8F4 Slot: 11
	internal virtual int MatchIndex(int cap) { }

	// RVA: 0x1CFB980 Offset: 0x1CF7980 VA: 0x1CFB980 Slot: 12
	internal virtual int MatchLength(int cap) { }

	// RVA: 0x1CFBA0C Offset: 0x1CF7A0C VA: 0x1CFBA0C Slot: 13
	internal virtual void Tidy(int textpos) { }

	// RVA: 0x1CFBB68 Offset: 0x1CF7B68 VA: 0x1CFBB68
	private static void .cctor() { }

	// RVA: 0x1CFBBF8 Offset: 0x1CF7BF8 VA: 0x1CFBBF8
	internal void .ctor() { }
}

// Namespace: System.Text.RegularExpressions
internal class MatchSparse : Match // TypeDefIndex: 3867
{
	// Fields
	internal readonly Hashtable _caps; // 0x78

	// Properties
	public override GroupCollection Groups { get; }

	// Methods

	// RVA: 0x1CFBC30 Offset: 0x1CF7C30 VA: 0x1CFBC30
	internal void .ctor(Regex regex, Hashtable caps, int capcount, string text, int begpos, int len, int startpos) { }

	// RVA: 0x1CFBCE8 Offset: 0x1CF7CE8 VA: 0x1CFBCE8 Slot: 5
	public override GroupCollection get_Groups() { }
}

// Namespace: 
[Serializable]
private sealed class MatchCollection.Enumerator : IEnumerator<Match>, IDisposable, IEnumerator // TypeDefIndex: 3868
{
	// Fields
	private readonly MatchCollection _collection; // 0x10
	private int _index; // 0x18

	// Properties
	public Match Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1CFC178 Offset: 0x1CF8178 VA: 0x1CFC178
	internal void .ctor(MatchCollection collection) { }

	// RVA: 0x1CFCA28 Offset: 0x1CF8A28 VA: 0x1CFCA28 Slot: 6
	public bool MoveNext() { }

	// RVA: 0x1CFCA78 Offset: 0x1CF8A78 VA: 0x1CFCA78 Slot: 4
	public Match get_Current() { }

	// RVA: 0x1CFCAE0 Offset: 0x1CF8AE0 VA: 0x1CFCAE0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1CFCAE4 Offset: 0x1CF8AE4 VA: 0x1CFCAE4 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1CFCAF0 Offset: 0x1CF8AF0 VA: 0x1CFCAF0 Slot: 5
	private void System.IDisposable.Dispose() { }
}

// Namespace: System.Text.RegularExpressions
[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Match>))]
[DebuggerDisplay("Count = {Count}")]
[DefaultMember("Item")]
[Serializable]
public class MatchCollection : IList<Match>, ICollection<Match>, IEnumerable<Match>, IEnumerable, IReadOnlyList<Match>, IReadOnlyCollection<Match>, IList, ICollection // TypeDefIndex: 3869
{
	// Fields
	private readonly Regex _regex; // 0x10
	private readonly List<Match> _matches; // 0x18
	private bool _done; // 0x20
	private readonly string _input; // 0x28
	private readonly int _beginning; // 0x30
	private readonly int _length; // 0x34
	private int _startat; // 0x38
	private int _prevlen; // 0x3C

	// Properties
	public bool IsReadOnly { get; }
	public int Count { get; }
	public virtual Match Item { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	private Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Item { get; set; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x1CFBD6C Offset: 0x1CF7D6C VA: 0x1CFBD6C
	internal void .ctor(Regex regex, string input, int beginning, int length, int startat) { }

	// RVA: 0x1CFBEC0 Offset: 0x1CF7EC0 VA: 0x1CFBEC0 Slot: 25
	public bool get_IsReadOnly() { }

	// RVA: 0x1CFBEC8 Offset: 0x1CF7EC8 VA: 0x1CFBEC8 Slot: 32
	public int get_Count() { }

	// RVA: 0x1CFBF38 Offset: 0x1CF7F38 VA: 0x1CFBF38 Slot: 35
	public virtual Match get_Item(int i) { }

	// RVA: 0x1CFC108 Offset: 0x1CF8108 VA: 0x1CFC108 Slot: 17
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1CFC1B4 Offset: 0x1CF81B4 VA: 0x1CFC1B4 Slot: 16
	private IEnumerator<Match> System.Collections.Generic.IEnumerable<System.Text.RegularExpressions.Match>.GetEnumerator() { }

	// RVA: 0x1CFBF98 Offset: 0x1CF7F98 VA: 0x1CFBF98
	private Match GetMatch(int i) { }

	// RVA: 0x1CFBF24 Offset: 0x1CF7F24 VA: 0x1CFBF24
	private void EnsureInitialized() { }

	// RVA: 0x1CFC224 Offset: 0x1CF8224 VA: 0x1CFC224 Slot: 34
	public bool get_IsSynchronized() { }

	// RVA: 0x1CFC22C Offset: 0x1CF822C VA: 0x1CFC22C Slot: 33
	public object get_SyncRoot() { }

	// RVA: 0x1CFC230 Offset: 0x1CF8230 VA: 0x1CFC230 Slot: 31
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1CFC2FC Offset: 0x1CF82FC VA: 0x1CFC2FC Slot: 14
	public void CopyTo(Match[] array, int arrayIndex) { }

	// RVA: 0x1CFC378 Offset: 0x1CF8378 VA: 0x1CFC378 Slot: 6
	private int System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.IndexOf(Match item) { }

	// RVA: 0x1CFC3E4 Offset: 0x1CF83E4 VA: 0x1CFC3E4 Slot: 7
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.Insert(int index, Match item) { }

	// RVA: 0x1CFC430 Offset: 0x1CF8430 VA: 0x1CFC430 Slot: 8
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.RemoveAt(int index) { }

	// RVA: 0x1CFC47C Offset: 0x1CF847C VA: 0x1CFC47C Slot: 4
	private Match System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.get_Item(int index) { }

	// RVA: 0x1CFC48C Offset: 0x1CF848C VA: 0x1CFC48C Slot: 5
	private void System.Collections.Generic.IList<System.Text.RegularExpressions.Match>.set_Item(int index, Match value) { }

	// RVA: 0x1CFC4D8 Offset: 0x1CF84D8 VA: 0x1CFC4D8 Slot: 11
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Add(Match item) { }

	// RVA: 0x1CFC524 Offset: 0x1CF8524 VA: 0x1CFC524 Slot: 12
	private void System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Clear() { }

	// RVA: 0x1CFC570 Offset: 0x1CF8570 VA: 0x1CFC570 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Contains(Match item) { }

	// RVA: 0x1CFC5DC Offset: 0x1CF85DC VA: 0x1CFC5DC Slot: 15
	private bool System.Collections.Generic.ICollection<System.Text.RegularExpressions.Match>.Remove(Match item) { }

	// RVA: 0x1CFC628 Offset: 0x1CF8628 VA: 0x1CFC628 Slot: 22
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1CFC674 Offset: 0x1CF8674 VA: 0x1CFC674 Slot: 24
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1CFC6C0 Offset: 0x1CF86C0 VA: 0x1CFC6C0 Slot: 23
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1CFC7B4 Offset: 0x1CF87B4 VA: 0x1CFC7B4 Slot: 27
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1CFC8A8 Offset: 0x1CF88A8 VA: 0x1CFC8A8 Slot: 28
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1CFC8F4 Offset: 0x1CF88F4 VA: 0x1CFC8F4 Slot: 26
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1CFC8FC Offset: 0x1CF88FC VA: 0x1CFC8FC Slot: 29
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1CFC948 Offset: 0x1CF8948 VA: 0x1CFC948 Slot: 30
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1CFC994 Offset: 0x1CF8994 VA: 0x1CFC994 Slot: 20
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1CFC9A4 Offset: 0x1CF89A4 VA: 0x1CFC9A4 Slot: 21
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1CFC9F0 Offset: 0x1CF89F0 VA: 0x1CFC9F0
	internal void .ctor() { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class ExclusiveReference // TypeDefIndex: 3870
{
	// Fields
	private RegexRunner _ref; // 0x10
	private RegexRunner _obj; // 0x18
	private int _locked; // 0x20

	// Methods

	// RVA: 0x1CFCAF4 Offset: 0x1CF8AF4 VA: 0x1CFCAF4
	public RegexRunner Get() { }

	// RVA: 0x1CFCB50 Offset: 0x1CF8B50 VA: 0x1CFCB50
	public void Release(RegexRunner obj) { }

	// RVA: 0x1CFCC1C Offset: 0x1CF8C1C VA: 0x1CFCC1C
	public void .ctor() { }
}

// Namespace: 
[IsReadOnly]
internal struct Regex.CachedCodeEntryKey : IEquatable<Regex.CachedCodeEntryKey> // TypeDefIndex: 3871
{
	// Fields
	private readonly RegexOptions _options; // 0x0
	private readonly string _cultureKey; // 0x8
	private readonly string _pattern; // 0x10

	// Methods

	// RVA: 0x1CFE814 Offset: 0x1CFA814 VA: 0x1CFE814
	public void .ctor(RegexOptions options, string cultureKey, string pattern) { }

	// RVA: 0x1CFE984 Offset: 0x1CFA984 VA: 0x1CFE984 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1CFEA14 Offset: 0x1CFAA14 VA: 0x1CFEA14 Slot: 4
	public bool Equals(Regex.CachedCodeEntryKey other) { }

	// RVA: 0x1CFCD1C Offset: 0x1CF8D1C VA: 0x1CFCD1C
	public static bool op_Equality(Regex.CachedCodeEntryKey left, Regex.CachedCodeEntryKey right) { }

	// RVA: 0x1CFEA7C Offset: 0x1CFAA7C VA: 0x1CFEA7C Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
internal sealed class Regex.CachedCodeEntry // TypeDefIndex: 3872
{
	// Fields
	public Regex.CachedCodeEntry Next; // 0x10
	public Regex.CachedCodeEntry Previous; // 0x18
	public readonly Regex.CachedCodeEntryKey Key; // 0x20
	public RegexCode Code; // 0x38
	public readonly Hashtable Caps; // 0x40
	public readonly Hashtable Capnames; // 0x48
	public readonly string[] Capslist; // 0x50
	public readonly int Capsize; // 0x58
	public readonly ExclusiveReference Runnerref; // 0x60
	public readonly WeakReference<RegexReplacement> ReplRef; // 0x68

	// Methods

	// RVA: 0x1CFD3FC Offset: 0x1CF93FC VA: 0x1CFD3FC
	public void .ctor(Regex.CachedCodeEntryKey key, Hashtable capnames, string[] capslist, RegexCode code, Hashtable caps, int capsize, ExclusiveReference runner, WeakReference<RegexReplacement> replref) { }
}

// Namespace: System.Text.RegularExpressions
public class Regex : ISerializable // TypeDefIndex: 3873
{
	// Fields
	private static int s_cacheSize; // 0x0
	private static readonly Dictionary<Regex.CachedCodeEntryKey, Regex.CachedCodeEntry> s_cache; // 0x8
	private static int s_cacheCount; // 0x10
	private static Regex.CachedCodeEntry s_cacheFirst; // 0x18
	private static Regex.CachedCodeEntry s_cacheLast; // 0x20
	private static readonly TimeSpan s_maximumMatchTimeout; // 0x28
	internal static readonly TimeSpan s_defaultMatchTimeout; // 0x30
	public static readonly TimeSpan InfiniteMatchTimeout; // 0x38
	protected internal TimeSpan internalMatchTimeout; // 0x10
	protected internal string pattern; // 0x18
	protected internal RegexOptions roptions; // 0x20
	protected internal RegexRunnerFactory factory; // 0x28
	protected internal Hashtable caps; // 0x30
	protected internal Hashtable capnames; // 0x38
	protected internal string[] capslist; // 0x40
	protected internal int capsize; // 0x48
	internal ExclusiveReference _runnerref; // 0x50
	internal WeakReference<RegexReplacement> _replref; // 0x58
	internal RegexCode _code; // 0x60
	internal bool _refsInitialized; // 0x68

	// Properties
	public RegexOptions Options { get; }
	public bool RightToLeft { get; }

	// Methods

	// RVA: 0x1CFCC24 Offset: 0x1CF8C24 VA: 0x1CFCC24
	private Regex.CachedCodeEntry GetCachedCode(Regex.CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x1CFCD4C Offset: 0x1CF8D4C VA: 0x1CFCD4C
	private Regex.CachedCodeEntry GetCachedCodeEntryInternal(Regex.CachedCodeEntryKey key, bool isToAdd) { }

	// RVA: 0x1CFD4D0 Offset: 0x1CF94D0 VA: 0x1CFD4D0
	private void FillCacheDictionary() { }

	// RVA: 0x1CFD5C0 Offset: 0x1CF95C0 VA: 0x1CFD5C0
	private static bool TryGetCacheValue(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry) { }

	// RVA: 0x1CFD6BC Offset: 0x1CF96BC VA: 0x1CFD6BC
	private static bool TryGetCacheValueSmall(Regex.CachedCodeEntryKey key, out Regex.CachedCodeEntry entry) { }

	// RVA: 0x1CFD1F4 Offset: 0x1CF91F4 VA: 0x1CFD1F4
	private static Regex.CachedCodeEntry LookupCachedAndPromote(Regex.CachedCodeEntryKey key) { }

	// RVA: 0x1CFD7B4 Offset: 0x1CF97B4 VA: 0x1CFD7B4
	public static bool IsMatch(string input, string pattern) { }

	// RVA: 0x1CFD828 Offset: 0x1CF9828 VA: 0x1CFD828
	public static bool IsMatch(string input, string pattern, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x1CFDD3C Offset: 0x1CF9D3C VA: 0x1CFDD3C
	public bool IsMatch(string input) { }

	// RVA: 0x1CFDDB0 Offset: 0x1CF9DB0 VA: 0x1CFDDB0
	public bool IsMatch(string input, int startat) { }

	// RVA: 0x1CFDE2C Offset: 0x1CF9E2C VA: 0x1CFDE2C
	public Match Match(string input) { }

	// RVA: 0x1CFDE94 Offset: 0x1CF9E94 VA: 0x1CFDE94
	public Match Match(string input, int startat) { }

	// RVA: 0x1CFDF00 Offset: 0x1CF9F00 VA: 0x1CFDF00
	public MatchCollection Matches(string input, int startat) { }

	// RVA: 0x1CFDFC8 Offset: 0x1CF9FC8 VA: 0x1CFDFC8
	public static string Replace(string input, string pattern, string replacement) { }

	// RVA: 0x1CFE044 Offset: 0x1CFA044 VA: 0x1CFE044
	public static string Replace(string input, string pattern, string replacement, RegexOptions options, TimeSpan matchTimeout) { }

	// RVA: 0x1CFE0D8 Offset: 0x1CFA0D8 VA: 0x1CFE0D8
	public string Replace(string input, string replacement) { }

	// RVA: 0x1CFE144 Offset: 0x1CFA144 VA: 0x1CFE144
	public string Replace(string input, string replacement, int count, int startat) { }

	// RVA: 0x1CFE21C Offset: 0x1CFA21C VA: 0x1CFE21C
	private static void .cctor() { }

	// RVA: 0x1CFE590 Offset: 0x1CFA590 VA: 0x1CFE590
	protected internal static void ValidateMatchTimeout(TimeSpan matchTimeout) { }

	// RVA: 0x1CFE360 Offset: 0x1CFA360 VA: 0x1CFE360
	private static TimeSpan InitDefaultMatchTimeout() { }

	// RVA: 0x1CFE6E8 Offset: 0x1CFA6E8 VA: 0x1CFE6E8
	public void .ctor(string pattern) { }

	// RVA: 0x1CFE760 Offset: 0x1CFA760 VA: 0x1CFE760
	public void .ctor(string pattern, RegexOptions options) { }

	// RVA: 0x1CFE7DC Offset: 0x1CFA7DC VA: 0x1CFE7DC Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo si, StreamingContext context) { }

	// RVA: 0x1CFD8B4 Offset: 0x1CF98B4 VA: 0x1CFD8B4
	private void .ctor(string pattern, RegexOptions options, TimeSpan matchTimeout, bool addToCache) { }

	// RVA: 0x1CFE95C Offset: 0x1CFA95C VA: 0x1CFE95C
	public RegexOptions get_Options() { }

	// RVA: 0x1CFE964 Offset: 0x1CFA964 VA: 0x1CFE964
	public bool get_RightToLeft() { }

	// RVA: 0x1CFE970 Offset: 0x1CFA970 VA: 0x1CFE970 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CFA288 Offset: 0x1CF6288 VA: 0x1CFA288
	public string GroupNameFromNumber(int i) { }

	// RVA: 0x1CF9E24 Offset: 0x1CF5E24 VA: 0x1CF9E24
	public int GroupNumberFromName(string name) { }

	// RVA: 0x1CFE84C Offset: 0x1CFA84C VA: 0x1CFE84C
	protected void InitializeReferences() { }

	// RVA: 0x1CFB124 Offset: 0x1CF7124 VA: 0x1CFB124
	internal Match Run(bool quick, int prevlen, string input, int beginning, int length, int startat) { }

	// RVA: 0x1CFDDA4 Offset: 0x1CF9DA4 VA: 0x1CFDDA4
	protected internal bool UseOptionR() { }

	// RVA: 0x1CFE978 Offset: 0x1CFA978 VA: 0x1CFE978
	internal bool UseOptionInvariant() { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexBoyerMoore // TypeDefIndex: 3874
{
	// Fields
	public readonly int[] Positive; // 0x10
	public readonly int[] NegativeASCII; // 0x18
	public readonly int[][] NegativeUnicode; // 0x20
	public readonly string Pattern; // 0x28
	public readonly int LowASCII; // 0x30
	public readonly int HighASCII; // 0x34
	public readonly bool RightToLeft; // 0x38
	public readonly bool CaseInsensitive; // 0x39
	private readonly CultureInfo _culture; // 0x40

	// Methods

	// RVA: 0x1CFEAD4 Offset: 0x1CFAAD4 VA: 0x1CFEAD4
	public void .ctor(string pattern, bool caseInsensitive, bool rightToLeft, CultureInfo culture) { }

	// RVA: 0x1CFEFEC Offset: 0x1CFAFEC VA: 0x1CFEFEC
	private bool MatchPattern(string text, int index) { }

	// RVA: 0x1CFF10C Offset: 0x1CFB10C VA: 0x1CFF10C
	public bool IsMatch(string text, int index, int beglimit, int endlimit) { }

	// RVA: 0x1CFF178 Offset: 0x1CFB178 VA: 0x1CFF178
	public int Scan(string text, int index, int beglimit, int endlimit) { }
}

// Namespace: 
[IsReadOnly]
private struct RegexCharClass.LowerCaseMapping // TypeDefIndex: 3875
{
	// Fields
	public readonly char ChMin; // 0x0
	public readonly char ChMax; // 0x2
	public readonly int LcOp; // 0x4
	public readonly int Data; // 0x8

	// Methods

	// RVA: 0x1D07A24 Offset: 0x1D03A24 VA: 0x1D07A24
	internal void .ctor(char chMin, char chMax, int lcOp, int data) { }
}

// Namespace: 
private sealed class RegexCharClass.SingleRangeComparer : IComparer<RegexCharClass.SingleRange> // TypeDefIndex: 3876
{
	// Fields
	public static readonly RegexCharClass.SingleRangeComparer Instance; // 0x0

	// Methods

	// RVA: 0x1D07A34 Offset: 0x1D03A34 VA: 0x1D07A34
	private void .ctor() { }

	// RVA: 0x1D07A3C Offset: 0x1D03A3C VA: 0x1D07A3C Slot: 4
	public int Compare(RegexCharClass.SingleRange x, RegexCharClass.SingleRange y) { }

	// RVA: 0x1D07A80 Offset: 0x1D03A80 VA: 0x1D07A80
	private static void .cctor() { }
}

// Namespace: 
[IsReadOnly]
private struct RegexCharClass.SingleRange // TypeDefIndex: 3877
{
	// Fields
	public readonly char First; // 0x0
	public readonly char Last; // 0x2

	// Methods

	// RVA: 0x1D07AE8 Offset: 0x1D03AE8 VA: 0x1D07AE8
	internal void .ctor(char first, char last) { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexCharClass // TypeDefIndex: 3878
{
	// Fields
	private static readonly string s_internalRegexIgnoreCase; // 0x0
	private static readonly string s_space; // 0x8
	private static readonly string s_notSpace; // 0x10
	private static readonly string s_word; // 0x18
	private static readonly string s_notWord; // 0x20
	public static readonly string SpaceClass; // 0x28
	public static readonly string NotSpaceClass; // 0x30
	public static readonly string WordClass; // 0x38
	public static readonly string NotWordClass; // 0x40
	public static readonly string DigitClass; // 0x48
	public static readonly string NotDigitClass; // 0x50
	private static readonly Dictionary<string, string> s_definedCategories; // 0x58
	private static readonly string[][] s_propTable; // 0x60
	private static readonly RegexCharClass.LowerCaseMapping[] s_lcTable; // 0x68
	private List<RegexCharClass.SingleRange> _rangelist; // 0x10
	private StringBuilder _categories; // 0x18
	private bool _canonical; // 0x20
	private bool _negate; // 0x21
	private RegexCharClass _subtractor; // 0x28

	// Properties
	public bool CanMerge { get; }
	public bool Negate { set; }

	// Methods

	// RVA: 0x1CFF474 Offset: 0x1CFB474 VA: 0x1CFF474
	public void .ctor() { }

	// RVA: 0x1CFF540 Offset: 0x1CFB540 VA: 0x1CFF540
	private void .ctor(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0x1CFF5B0 Offset: 0x1CFB5B0 VA: 0x1CFF5B0
	public bool get_CanMerge() { }

	// RVA: 0x1CFF5D0 Offset: 0x1CFB5D0 VA: 0x1CFF5D0
	public void set_Negate(bool value) { }

	// RVA: 0x1CFF5D8 Offset: 0x1CFB5D8 VA: 0x1CFF5D8
	public void AddChar(char c) { }

	// RVA: 0x1CFF6FC Offset: 0x1CFB6FC VA: 0x1CFF6FC
	public void AddCharClass(RegexCharClass cc) { }

	// RVA: 0x1CFF90C Offset: 0x1CFB90C VA: 0x1CFF90C
	private void AddSet(string set) { }

	// RVA: 0x1CFFB30 Offset: 0x1CFBB30 VA: 0x1CFFB30
	public void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0x1CFF5E0 Offset: 0x1CFB5E0 VA: 0x1CFF5E0
	public void AddRange(char first, char last) { }

	// RVA: 0x1CFFB38 Offset: 0x1CFBB38 VA: 0x1CFFB38
	public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	// RVA: 0x1D0002C Offset: 0x1CFC02C VA: 0x1D0002C
	private void AddCategory(string category) { }

	// RVA: 0x1D00044 Offset: 0x1CFC044 VA: 0x1D00044
	public void AddLowercase(CultureInfo culture) { }

	// RVA: 0x1D00180 Offset: 0x1CFC180 VA: 0x1D00180
	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) { }

	// RVA: 0x1D003B0 Offset: 0x1CFC3B0 VA: 0x1D003B0
	public void AddWord(bool ecma, bool negate) { }

	// RVA: 0x1D004AC Offset: 0x1CFC4AC VA: 0x1D004AC
	public void AddSpace(bool ecma, bool negate) { }

	// RVA: 0x1D005A8 Offset: 0x1CFC5A8 VA: 0x1D005A8
	public void AddDigit(bool ecma, bool negate, string pattern) { }

	// RVA: 0x1D0065C Offset: 0x1CFC65C VA: 0x1D0065C
	public static char SingletonChar(string set) { }

	// RVA: 0x1D00674 Offset: 0x1CFC674 VA: 0x1D00674
	public static bool IsMergeable(string charClass) { }

	// RVA: 0x1D00790 Offset: 0x1CFC790 VA: 0x1D00790
	public static bool IsEmpty(string charClass) { }

	// RVA: 0x1D00850 Offset: 0x1CFC850 VA: 0x1D00850
	public static bool IsSingleton(string set) { }

	// RVA: 0x1D0095C Offset: 0x1CFC95C VA: 0x1D0095C
	public static bool IsSingletonInverse(string set) { }

	// RVA: 0x1D00738 Offset: 0x1CFC738 VA: 0x1D00738
	private static bool IsSubtraction(string charClass) { }

	// RVA: 0x1D00710 Offset: 0x1CFC710 VA: 0x1D00710
	private static bool IsNegated(string set) { }

	// RVA: 0x1D00A6C Offset: 0x1CFCA6C VA: 0x1D00A6C
	public static bool IsECMAWordChar(char ch) { }

	// RVA: 0x1D00B40 Offset: 0x1CFCB40 VA: 0x1D00B40
	public static bool IsWordChar(char ch) { }

	// RVA: 0x1D00AD8 Offset: 0x1CFCAD8 VA: 0x1D00AD8
	public static bool CharInClass(char ch, string set) { }

	// RVA: 0x1D00BBC Offset: 0x1CFCBBC VA: 0x1D00BBC
	private static bool CharInClassRecursive(char ch, string set, int start) { }

	// RVA: 0x1D00CDC Offset: 0x1CFCCDC VA: 0x1D00CDC
	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x1D00DEC Offset: 0x1CFCDEC VA: 0x1D00DEC
	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x1D00F70 Offset: 0x1CFCF70 VA: 0x1D00F70
	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) { }

	// RVA: 0x1CFFD48 Offset: 0x1CFBD48 VA: 0x1CFFD48
	private static string NegateCategory(string category) { }

	// RVA: 0x1D01040 Offset: 0x1CFD040 VA: 0x1D01040
	public static RegexCharClass Parse(string charClass) { }

	// RVA: 0x1D01098 Offset: 0x1CFD098 VA: 0x1D01098
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	// RVA: 0x1CFF86C Offset: 0x1CFB86C VA: 0x1CFF86C
	private int RangeCount() { }

	// RVA: 0x1D01300 Offset: 0x1CFD300 VA: 0x1D01300
	public string ToStringClass() { }

	// RVA: 0x1CFF8B4 Offset: 0x1CFB8B4 VA: 0x1CFF8B4
	private RegexCharClass.SingleRange GetRangeAt(int i) { }

	// RVA: 0x1D0149C Offset: 0x1CFD49C VA: 0x1D0149C
	private void Canonicalize() { }

	// RVA: 0x1CFFDD0 Offset: 0x1CFBDD0 VA: 0x1CFFDD0
	private static string SetFromProperty(string capname, bool invert, string pattern) { }

	// RVA: 0x1D016D0 Offset: 0x1CFD6D0 VA: 0x1D016D0
	private static void .cctor() { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexCode // TypeDefIndex: 3879
{
	// Fields
	public readonly int[] Codes; // 0x10
	public readonly string[] Strings; // 0x18
	public readonly int TrackCount; // 0x20
	public readonly Hashtable Caps; // 0x28
	public readonly int CapSize; // 0x30
	public readonly Nullable<RegexPrefix> FCPrefix; // 0x38
	public readonly RegexBoyerMoore BMPrefix; // 0x50
	public readonly int Anchors; // 0x58
	public readonly bool RightToLeft; // 0x5C

	// Methods

	// RVA: 0x1D07AF4 Offset: 0x1D03AF4 VA: 0x1D07AF4
	public void .ctor(int[] codes, List<string> stringlist, int trackcount, Hashtable caps, int capsize, RegexBoyerMoore bmPrefix, Nullable<RegexPrefix> fcPrefix, int anchors, bool rightToLeft) { }

	// RVA: 0x1D07C00 Offset: 0x1D03C00 VA: 0x1D07C00
	public static bool OpcodeBacktracks(int Op) { }
}

// Namespace: System.Text.RegularExpressions
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
internal struct RegexFCD // TypeDefIndex: 3880
{
	// Fields
	private readonly List<RegexFC> _fcStack; // 0x0
	private ValueListBuilder<int> _intStack; // 0x8
	private bool _skipAllChildren; // 0x28
	private bool _skipchild; // 0x29
	private bool _failed; // 0x2A

	// Methods

	// RVA: 0x1D07C18 Offset: 0x1D03C18 VA: 0x1D07C18
	private void .ctor(Span<int> intStack) { }

	// RVA: 0x1D07CEC Offset: 0x1D03CEC VA: 0x1D07CEC
	public static Nullable<RegexPrefix> FirstChars(RegexTree t) { }

	// RVA: 0x1D080B4 Offset: 0x1D040B4 VA: 0x1D080B4
	public static RegexPrefix Prefix(RegexTree tree) { }

	// RVA: 0x1D083DC Offset: 0x1D043DC VA: 0x1D083DC
	public static int Anchors(RegexTree tree) { }

	// RVA: 0x1D0853C Offset: 0x1D0453C VA: 0x1D0853C
	private static int AnchorFromType(int type) { }

	// RVA: 0x1D085DC Offset: 0x1D045DC VA: 0x1D085DC
	private void PushInt(int i) { }

	// RVA: 0x1D08694 Offset: 0x1D04694 VA: 0x1D08694
	private bool IntIsEmpty() { }

	// RVA: 0x1D086D8 Offset: 0x1D046D8 VA: 0x1D086D8
	private int PopInt() { }

	// RVA: 0x1D08734 Offset: 0x1D04734 VA: 0x1D08734
	private void PushFC(RegexFC fc) { }

	// RVA: 0x1D087E0 Offset: 0x1D047E0 VA: 0x1D087E0
	private bool FCIsEmpty() { }

	// RVA: 0x1D08830 Offset: 0x1D04830 VA: 0x1D08830
	private RegexFC PopFC() { }

	// RVA: 0x1D088AC Offset: 0x1D048AC VA: 0x1D088AC
	private RegexFC TopFC() { }

	// RVA: 0x1D0800C Offset: 0x1D0400C VA: 0x1D0800C
	public void Dispose() { }

	// RVA: 0x1D07E74 Offset: 0x1D03E74 VA: 0x1D07E74
	private RegexFC RegexFCFromRegexTree(RegexTree tree) { }

	// RVA: 0x1D08D30 Offset: 0x1D04D30 VA: 0x1D08D30
	private void SkipChild() { }

	// RVA: 0x1D08910 Offset: 0x1D04910 VA: 0x1D08910
	private void CalculateFC(int NodeType, RegexNode node, int CurIndex) { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexFC // TypeDefIndex: 3881
{
	// Fields
	private RegexCharClass _cc; // 0x10
	public bool _nullable; // 0x18
	[CompilerGenerated]
	private bool <CaseInsensitive>k__BackingField; // 0x19

	// Properties
	public bool CaseInsensitive { get; set; }

	// Methods

	// RVA: 0x1D08D3C Offset: 0x1D04D3C VA: 0x1D08D3C
	public void .ctor(bool nullable) { }

	// RVA: 0x1D08E6C Offset: 0x1D04E6C VA: 0x1D08E6C
	public void .ctor(char ch, bool not, bool nullable, bool caseInsensitive) { }

	// RVA: 0x1D08F70 Offset: 0x1D04F70 VA: 0x1D08F70
	public void .ctor(string charClass, bool nullable, bool caseInsensitive) { }

	// RVA: 0x1D08DC0 Offset: 0x1D04DC0 VA: 0x1D08DC0
	public bool AddFC(RegexFC fc, bool concatenate) { }

	[CompilerGenerated]
	// RVA: 0x1D09014 Offset: 0x1D05014 VA: 0x1D09014
	public bool get_CaseInsensitive() { }

	[CompilerGenerated]
	// RVA: 0x1D0901C Offset: 0x1D0501C VA: 0x1D0901C
	private void set_CaseInsensitive(bool value) { }

	// RVA: 0x1D08054 Offset: 0x1D04054 VA: 0x1D08054
	public string GetFirstChars(CultureInfo culture) { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexInterpreter : RegexRunner // TypeDefIndex: 3882
{
	// Fields
	private readonly RegexCode _code; // 0x80
	private readonly CultureInfo _culture; // 0x88
	private int _operator; // 0x90
	private int _codepos; // 0x94
	private bool _rightToLeft; // 0x98
	private bool _caseInsensitive; // 0x99

	// Methods

	// RVA: 0x1D09024 Offset: 0x1D05024 VA: 0x1D09024
	public void .ctor(RegexCode code, CultureInfo culture) { }

	// RVA: 0x1D09070 Offset: 0x1D05070 VA: 0x1D09070 Slot: 6
	protected override void InitTrackCount() { }

	// RVA: 0x1D0908C Offset: 0x1D0508C VA: 0x1D0908C
	private void Advance(int i) { }

	// RVA: 0x1D09110 Offset: 0x1D05110 VA: 0x1D09110
	private void Goto(int newpos) { }

	// RVA: 0x1D091D0 Offset: 0x1D051D0 VA: 0x1D091D0
	private void Textto(int newpos) { }

	// RVA: 0x1D091D8 Offset: 0x1D051D8 VA: 0x1D091D8
	private void Trackto(int newpos) { }

	// RVA: 0x1D091F8 Offset: 0x1D051F8 VA: 0x1D091F8
	private int Textstart() { }

	// RVA: 0x1D09200 Offset: 0x1D05200 VA: 0x1D09200
	private int Textpos() { }

	// RVA: 0x1D09208 Offset: 0x1D05208 VA: 0x1D09208
	private int Trackpos() { }

	// RVA: 0x1D09228 Offset: 0x1D05228 VA: 0x1D09228
	private void TrackPush() { }

	// RVA: 0x1D09268 Offset: 0x1D05268 VA: 0x1D09268
	private void TrackPush(int I1) { }

	// RVA: 0x1D092C4 Offset: 0x1D052C4 VA: 0x1D092C4
	private void TrackPush(int I1, int I2) { }

	// RVA: 0x1D0933C Offset: 0x1D0533C VA: 0x1D0933C
	private void TrackPush(int I1, int I2, int I3) { }

	// RVA: 0x1D093D0 Offset: 0x1D053D0 VA: 0x1D093D0
	private void TrackPush2(int I1) { }

	// RVA: 0x1D09430 Offset: 0x1D05430 VA: 0x1D09430
	private void TrackPush2(int I1, int I2) { }

	// RVA: 0x1D094AC Offset: 0x1D054AC VA: 0x1D094AC
	private void Backtrack() { }

	// RVA: 0x1D090F0 Offset: 0x1D050F0 VA: 0x1D090F0
	private void SetOperator(int op) { }

	// RVA: 0x1D09594 Offset: 0x1D05594 VA: 0x1D09594
	private void TrackPop() { }

	// RVA: 0x1D095A4 Offset: 0x1D055A4 VA: 0x1D095A4
	private void TrackPop(int framesize) { }

	// RVA: 0x1D095B4 Offset: 0x1D055B4 VA: 0x1D095B4
	private int TrackPeek() { }

	// RVA: 0x1D095EC Offset: 0x1D055EC VA: 0x1D095EC
	private int TrackPeek(int i) { }

	// RVA: 0x1D09628 Offset: 0x1D05628 VA: 0x1D09628
	private void StackPush(int I1) { }

	// RVA: 0x1D09664 Offset: 0x1D05664 VA: 0x1D09664
	private void StackPush(int I1, int I2) { }

	// RVA: 0x1D096BC Offset: 0x1D056BC VA: 0x1D096BC
	private void StackPop() { }

	// RVA: 0x1D096CC Offset: 0x1D056CC VA: 0x1D096CC
	private void StackPop(int framesize) { }

	// RVA: 0x1D096DC Offset: 0x1D056DC VA: 0x1D096DC
	private int StackPeek() { }

	// RVA: 0x1D09714 Offset: 0x1D05714 VA: 0x1D09714
	private int StackPeek(int i) { }

	// RVA: 0x1D09750 Offset: 0x1D05750 VA: 0x1D09750
	private int Operator() { }

	// RVA: 0x1D09758 Offset: 0x1D05758 VA: 0x1D09758
	private int Operand(int i) { }

	// RVA: 0x1D0979C Offset: 0x1D0579C VA: 0x1D0979C
	private int Leftchars() { }

	// RVA: 0x1D097AC Offset: 0x1D057AC VA: 0x1D097AC
	private int Rightchars() { }

	// RVA: 0x1D097BC Offset: 0x1D057BC VA: 0x1D097BC
	private int Bump() { }

	// RVA: 0x1D097D0 Offset: 0x1D057D0 VA: 0x1D097D0
	private int Forwardchars() { }

	// RVA: 0x1D097FC Offset: 0x1D057FC VA: 0x1D097FC
	private char Forwardcharnext() { }

	// RVA: 0x1D0988C Offset: 0x1D0588C VA: 0x1D0988C
	private bool Stringmatch(string str) { }

	// RVA: 0x1D099FC Offset: 0x1D059FC VA: 0x1D099FC
	private bool Refmatch(int index, int len) { }

	// RVA: 0x1D09B98 Offset: 0x1D05B98 VA: 0x1D09B98
	private void Backwardnext() { }

	// RVA: 0x1D09BC0 Offset: 0x1D05BC0 VA: 0x1D09BC0
	private char CharAt(int j) { }

	// RVA: 0x1D09BD8 Offset: 0x1D05BD8 VA: 0x1D09BD8 Slot: 5
	protected override bool FindFirstChar() { }

	// RVA: 0x1D09F70 Offset: 0x1D05F70 VA: 0x1D09F70 Slot: 4
	protected override void Go() { }
}

// Namespace: System.Text.RegularExpressions
[Serializable]
public class RegexMatchTimeoutException : TimeoutException, ISerializable // TypeDefIndex: 3883
{
	// Fields
	[CompilerGenerated]
	private readonly string <Input>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly string <Pattern>k__BackingField; // 0x98
	[CompilerGenerated]
	private readonly TimeSpan <MatchTimeout>k__BackingField; // 0xA0

	// Properties
	public string Input { get; }
	public string Pattern { get; }
	public TimeSpan MatchTimeout { get; }

	// Methods

	// RVA: 0x1D0B51C Offset: 0x1D0751C VA: 0x1D0B51C
	public void .ctor(string regexInput, string regexPattern, TimeSpan matchTimeout) { }

	// RVA: 0x1D0B628 Offset: 0x1D07628 VA: 0x1D0B628
	public void .ctor() { }

	// RVA: 0x1D0B6CC Offset: 0x1D076CC VA: 0x1D0B6CC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D0B838 Offset: 0x1D07838 VA: 0x1D0B838 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	// RVA: 0x1D0B934 Offset: 0x1D07934 VA: 0x1D0B934
	public string get_Input() { }

	[CompilerGenerated]
	// RVA: 0x1D0B93C Offset: 0x1D0793C VA: 0x1D0B93C
	public string get_Pattern() { }

	[CompilerGenerated]
	// RVA: 0x1D0B944 Offset: 0x1D07944 VA: 0x1D0B944
	public TimeSpan get_MatchTimeout() { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexNode // TypeDefIndex: 3884
{
	// Fields
	public int NType; // 0x10
	public List<RegexNode> Children; // 0x18
	public string Str; // 0x20
	public char Ch; // 0x28
	public int M; // 0x2C
	public int N; // 0x30
	public readonly RegexOptions Options; // 0x34
	public RegexNode Next; // 0x38

	// Methods

	// RVA: 0x1D0B94C Offset: 0x1D0794C VA: 0x1D0B94C
	public void .ctor(int type, RegexOptions options) { }

	// RVA: 0x1D0B97C Offset: 0x1D0797C VA: 0x1D0B97C
	public void .ctor(int type, RegexOptions options, char ch) { }

	// RVA: 0x1D0B9BC Offset: 0x1D079BC VA: 0x1D0B9BC
	public void .ctor(int type, RegexOptions options, string str) { }

	// RVA: 0x1D0BA04 Offset: 0x1D07A04 VA: 0x1D0BA04
	public void .ctor(int type, RegexOptions options, int m) { }

	// RVA: 0x1D0BA44 Offset: 0x1D07A44 VA: 0x1D0BA44
	public void .ctor(int type, RegexOptions options, int m, int n) { }

	// RVA: 0x1D0BA88 Offset: 0x1D07A88 VA: 0x1D0BA88
	public bool UseOptionR() { }

	// RVA: 0x1D0BA94 Offset: 0x1D07A94 VA: 0x1D0BA94
	public RegexNode ReverseLeft() { }

	// RVA: 0x1D0BB10 Offset: 0x1D07B10 VA: 0x1D0BB10
	private void MakeRep(int type, int min, int max) { }

	// RVA: 0x1D0BB28 Offset: 0x1D07B28 VA: 0x1D0BB28
	private RegexNode Reduce() { }

	// RVA: 0x1D0C63C Offset: 0x1D0863C VA: 0x1D0C63C
	private RegexNode StripEnation(int emptyType) { }

	// RVA: 0x1D0C4C0 Offset: 0x1D084C0 VA: 0x1D0C4C0
	private RegexNode ReduceGroup() { }

	// RVA: 0x1D0C338 Offset: 0x1D08338 VA: 0x1D0C338
	private RegexNode ReduceRep() { }

	// RVA: 0x1D0C4EC Offset: 0x1D084EC VA: 0x1D0C4EC
	private RegexNode ReduceSet() { }

	// RVA: 0x1D0BB88 Offset: 0x1D07B88 VA: 0x1D0BB88
	private RegexNode ReduceAlternation() { }

	// RVA: 0x1D0BF84 Offset: 0x1D07F84 VA: 0x1D0BF84
	private RegexNode ReduceConcatenation() { }

	// RVA: 0x1D0C6F0 Offset: 0x1D086F0 VA: 0x1D0C6F0
	public RegexNode MakeQuantifier(bool lazy, int min, int max) { }

	// RVA: 0x1D0C804 Offset: 0x1D08804 VA: 0x1D0C804
	public void AddChild(RegexNode newChild) { }

	// RVA: 0x1D08384 Offset: 0x1D04384 VA: 0x1D08384
	public RegexNode Child(int i) { }

	// RVA: 0x1D08338 Offset: 0x1D04338 VA: 0x1D08338
	public int ChildCount() { }

	// RVA: 0x1D0C934 Offset: 0x1D08934 VA: 0x1D0C934
	public int Type() { }
}

// Namespace: System.Text.RegularExpressions
[Flags]
public enum RegexOptions // TypeDefIndex: 3885
{
	// Fields
	public int value__; // 0x0
	public const RegexOptions None = 0;
	public const RegexOptions IgnoreCase = 1;
	public const RegexOptions Multiline = 2;
	public const RegexOptions ExplicitCapture = 4;
	public const RegexOptions Compiled = 8;
	public const RegexOptions Singleline = 16;
	public const RegexOptions IgnorePatternWhitespace = 32;
	public const RegexOptions RightToLeft = 64;
	public const RegexOptions ECMAScript = 256;
	public const RegexOptions CultureInvariant = 512;
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexParser // TypeDefIndex: 3886
{
	// Fields
	private RegexNode _stack; // 0x10
	private RegexNode _group; // 0x18
	private RegexNode _alternation; // 0x20
	private RegexNode _concatenation; // 0x28
	private RegexNode _unit; // 0x30
	private string _pattern; // 0x38
	private int _currentPos; // 0x40
	private CultureInfo _culture; // 0x48
	private int _autocap; // 0x50
	private int _capcount; // 0x54
	private int _captop; // 0x58
	private int _capsize; // 0x5C
	private Hashtable _caps; // 0x60
	private Hashtable _capnames; // 0x68
	private int[] _capnumlist; // 0x70
	private List<string> _capnamelist; // 0x78
	private RegexOptions _options; // 0x80
	private List<RegexOptions> _optionsStack; // 0x88
	private bool _ignoreNextParen; // 0x90
	private static readonly byte[] s_category; // 0x0

	// Methods

	// RVA: 0x1D0C93C Offset: 0x1D0893C VA: 0x1D0C93C
	public static RegexTree Parse(string re, RegexOptions op) { }

	// RVA: 0x1D0D86C Offset: 0x1D0986C VA: 0x1D0D86C
	public static RegexReplacement ParseReplacement(string rep, Hashtable caps, int capsize, Hashtable capnames, RegexOptions op) { }

	// RVA: 0x1D0CAD8 Offset: 0x1D08AD8 VA: 0x1D0CAD8
	private void .ctor(CultureInfo culture) { }

	// RVA: 0x1D0CBB4 Offset: 0x1D08BB4 VA: 0x1D0CBB4
	private void SetPattern(string Re) { }

	// RVA: 0x1D0CF34 Offset: 0x1D08F34 VA: 0x1D0CF34
	private void Reset(RegexOptions topopts) { }

	// RVA: 0x1D0CFC8 Offset: 0x1D08FC8 VA: 0x1D0CFC8
	private RegexNode ScanRegex() { }

	// RVA: 0x1D0DA00 Offset: 0x1D09A00 VA: 0x1D0DA00
	private RegexNode ScanReplacement() { }

	// RVA: 0x1D0EA7C Offset: 0x1D0AA7C VA: 0x1D0EA7C
	private RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly) { }

	// RVA: 0x1D0F264 Offset: 0x1D0B264 VA: 0x1D0F264
	private RegexNode ScanGroupOpen() { }

	// RVA: 0x1D0E110 Offset: 0x1D0A110 VA: 0x1D0E110
	private void ScanBlank() { }

	// RVA: 0x1D100A8 Offset: 0x1D0C0A8 VA: 0x1D100A8
	private RegexNode ScanBackslash(bool scanOnly) { }

	// RVA: 0x1D11420 Offset: 0x1D0D420 VA: 0x1D11420
	private RegexNode ScanBasicBackslash(bool scanOnly) { }

	// RVA: 0x1D10888 Offset: 0x1D0C888 VA: 0x1D10888
	private RegexNode ScanDollar() { }

	// RVA: 0x1D11024 Offset: 0x1D0D024 VA: 0x1D11024
	private string ScanCapname() { }

	// RVA: 0x1D119C8 Offset: 0x1D0D9C8 VA: 0x1D119C8
	private char ScanOctal() { }

	// RVA: 0x1D10770 Offset: 0x1D0C770 VA: 0x1D10770
	private int ScanDecimal() { }

	// RVA: 0x1D11A64 Offset: 0x1D0DA64 VA: 0x1D11A64
	private char ScanHex(int c) { }

	// RVA: 0x1D11B98 Offset: 0x1D0DB98 VA: 0x1D11B98
	private static int HexDigit(char ch) { }

	// RVA: 0x1D11BCC Offset: 0x1D0DBCC VA: 0x1D11BCC
	private char ScanControl() { }

	// RVA: 0x1D11C68 Offset: 0x1D0DC68 VA: 0x1D11C68
	private bool IsOnlyTopOption(RegexOptions option) { }

	// RVA: 0x1D11200 Offset: 0x1D0D200 VA: 0x1D11200
	private void ScanOptions() { }

	// RVA: 0x1D10E34 Offset: 0x1D0CE34 VA: 0x1D10E34
	private char ScanCharEscape() { }

	// RVA: 0x1D10CC4 Offset: 0x1D0CCC4 VA: 0x1D10CC4
	private string ParseProperty() { }

	// RVA: 0x1D11390 Offset: 0x1D0D390 VA: 0x1D11390
	private int TypeFromCode(char ch) { }

	// RVA: 0x1D11C8C Offset: 0x1D0DC8C VA: 0x1D11C8C
	private static RegexOptions OptionFromCode(char ch) { }

	// RVA: 0x1D0CBEC Offset: 0x1D08BEC VA: 0x1D0CBEC
	private void CountCaptures() { }

	// RVA: 0x1D11CEC Offset: 0x1D0DCEC VA: 0x1D11CEC
	private void NoteCaptureSlot(int i, int pos) { }

	// RVA: 0x1D11E20 Offset: 0x1D0DE20 VA: 0x1D11E20
	private void NoteCaptureName(string name, int pos) { }

	// RVA: 0x1D0D9C8 Offset: 0x1D099C8 VA: 0x1D0D9C8
	private void NoteCaptures(Hashtable caps, int capsize, Hashtable capnames) { }

	// RVA: 0x1D11FCC Offset: 0x1D0DFCC VA: 0x1D11FCC
	private void AssignNameSlots() { }

	// RVA: 0x1D111A8 Offset: 0x1D0D1A8 VA: 0x1D111A8
	private int CaptureSlotFromName(string capname) { }

	// RVA: 0x1D11120 Offset: 0x1D0D120 VA: 0x1D11120
	private bool IsCaptureSlot(int i) { }

	// RVA: 0x1D1118C Offset: 0x1D0D18C VA: 0x1D1118C
	private bool IsCaptureName(string capname) { }

	// RVA: 0x1D11114 Offset: 0x1D0D114 VA: 0x1D11114
	private bool UseOptionN() { }

	// RVA: 0x1D0EA70 Offset: 0x1D0AA70 VA: 0x1D0EA70
	private bool UseOptionI() { }

	// RVA: 0x1D105C0 Offset: 0x1D0C5C0 VA: 0x1D105C0
	private bool UseOptionM() { }

	// RVA: 0x1D10644 Offset: 0x1D0C644 VA: 0x1D10644
	private bool UseOptionS() { }

	// RVA: 0x1D0E3EC Offset: 0x1D0A3EC VA: 0x1D0E3EC
	private bool UseOptionX() { }

	// RVA: 0x1D10CB8 Offset: 0x1D0CCB8 VA: 0x1D10CB8
	private bool UseOptionE() { }

	// RVA: 0x1D0E67C Offset: 0x1D0A67C VA: 0x1D0E67C
	private static bool IsSpecial(char ch) { }

	// RVA: 0x1D0E448 Offset: 0x1D0A448 VA: 0x1D0E448
	private static bool IsStopperX(char ch) { }

	// RVA: 0x1D0E714 Offset: 0x1D0A714 VA: 0x1D0E714
	private static bool IsQuantifier(char ch) { }

	// RVA: 0x1D0E4E0 Offset: 0x1D0A4E0 VA: 0x1D0E4E0
	private bool IsTrueQuantifier() { }

	// RVA: 0x1D112F8 Offset: 0x1D0D2F8 VA: 0x1D112F8
	private static bool IsSpace(char ch) { }

	// RVA: 0x1D0E7AC Offset: 0x1D0A7AC VA: 0x1D0E7AC
	private void AddConcatenate(int pos, int cch, bool isReplacement) { }

	// RVA: 0x1D0FBC4 Offset: 0x1D0BBC4 VA: 0x1D0FBC4
	private void PushGroup() { }

	// RVA: 0x1D0FED8 Offset: 0x1D0BED8 VA: 0x1D0FED8
	private void PopGroup() { }

	// RVA: 0x1D0FCEC Offset: 0x1D0BCEC VA: 0x1D0FCEC
	private bool EmptyStack() { }

	// RVA: 0x1D0E050 Offset: 0x1D0A050 VA: 0x1D0E050
	private void StartGroup(RegexNode openGroup) { }

	// RVA: 0x1D0FC20 Offset: 0x1D0BC20 VA: 0x1D0FC20
	private void AddAlternate() { }

	// RVA: 0x1D10718 Offset: 0x1D0C718 VA: 0x1D10718
	private void AddConcatenate() { }

	// RVA: 0x1D1083C Offset: 0x1D0C83C VA: 0x1D1083C
	private void AddConcatenate(bool lazy, int min, int max) { }

	// RVA: 0x1D12670 Offset: 0x1D0E670 VA: 0x1D12670
	private RegexNode Unit() { }

	// RVA: 0x1D0E9B8 Offset: 0x1D0A9B8 VA: 0x1D0E9B8
	private void AddUnitOne(char ch) { }

	// RVA: 0x1D10650 Offset: 0x1D0C650 VA: 0x1D10650
	private void AddUnitNotone(char ch) { }

	// RVA: 0x1D0F138 Offset: 0x1D0B138 VA: 0x1D0F138
	private void AddUnitSet(string cc) { }

	// RVA: 0x1D12678 Offset: 0x1D0E678 VA: 0x1D12678
	private void AddUnitNode(RegexNode node) { }

	// RVA: 0x1D105CC Offset: 0x1D0C5CC VA: 0x1D105CC
	private void AddUnitType(int type) { }

	// RVA: 0x1D0FD94 Offset: 0x1D0BD94 VA: 0x1D0FD94
	private void AddGroup() { }

	// RVA: 0x1D0F1C4 Offset: 0x1D0B1C4 VA: 0x1D0F1C4
	private void PushOptions() { }

	// RVA: 0x1D10010 Offset: 0x1D0C010 VA: 0x1D10010
	private void PopOptions() { }

	// RVA: 0x1D11DD0 Offset: 0x1D0DDD0 VA: 0x1D11DD0
	private bool EmptyOptionsStack() { }

	// RVA: 0x1D0FB60 Offset: 0x1D0BB60 VA: 0x1D0FB60
	private void PopKeepOptions() { }

	// RVA: 0x1D0FCFC Offset: 0x1D0BCFC VA: 0x1D0FCFC
	private ArgumentException MakeException(string message) { }

	// RVA: 0x1D12680 Offset: 0x1D0E680 VA: 0x1D12680
	private int Textpos() { }

	// RVA: 0x1D12688 Offset: 0x1D0E688 VA: 0x1D12688
	private void Textto(int pos) { }

	// RVA: 0x1D10748 Offset: 0x1D0C748 VA: 0x1D10748
	private char RightCharMoveRight() { }

	// RVA: 0x1D0E3F8 Offset: 0x1D0A3F8 VA: 0x1D0E3F8
	private void MoveRight() { }

	// RVA: 0x1D11104 Offset: 0x1D0D104 VA: 0x1D11104
	private void MoveRight(int i) { }

	// RVA: 0x1D10708 Offset: 0x1D0C708 VA: 0x1D10708
	private void MoveLeft() { }

	// RVA: 0x1D0E9A0 Offset: 0x1D0A9A0 VA: 0x1D0E9A0
	private char CharAt(int i) { }

	// RVA: 0x1D0E428 Offset: 0x1D0A428 VA: 0x1D0E428
	internal char RightChar() { }

	// RVA: 0x1D110E0 Offset: 0x1D0D0E0 VA: 0x1D110E0
	private char RightChar(int i) { }

	// RVA: 0x1D0E408 Offset: 0x1D0A408 VA: 0x1D0E408
	private int CharsRight() { }

	// RVA: 0x1D12690 Offset: 0x1D0E690 VA: 0x1D12690
	private static void .cctor() { }
}

// Namespace: System.Text.RegularExpressions
[IsReadOnly]
internal struct RegexPrefix // TypeDefIndex: 3887
{
	// Fields
	[CompilerGenerated]
	private readonly bool <CaseInsensitive>k__BackingField; // 0x0
	[CompilerGenerated]
	private static readonly RegexPrefix <Empty>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly string <Prefix>k__BackingField; // 0x8

	// Properties
	internal bool CaseInsensitive { get; }
	internal static RegexPrefix Empty { get; }
	internal string Prefix { get; }

	// Methods

	// RVA: 0x1D0808C Offset: 0x1D0408C VA: 0x1D0808C
	internal void .ctor(string prefix, bool ci) { }

	[CompilerGenerated]
	// RVA: 0x1D12730 Offset: 0x1D0E730 VA: 0x1D12730
	internal bool get_CaseInsensitive() { }

	[CompilerGenerated]
	// RVA: 0x1D12738 Offset: 0x1D0E738 VA: 0x1D12738
	internal static RegexPrefix get_Empty() { }

	[CompilerGenerated]
	// RVA: 0x1D12790 Offset: 0x1D0E790 VA: 0x1D12790
	internal string get_Prefix() { }

	// RVA: 0x1D12798 Offset: 0x1D0E798 VA: 0x1D12798
	private static void .cctor() { }
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexReplacement // TypeDefIndex: 3888
{
	// Fields
	private readonly List<string> _strings; // 0x10
	private readonly List<int> _rules; // 0x18
	[CompilerGenerated]
	private readonly string <Pattern>k__BackingField; // 0x20

	// Properties
	public string Pattern { get; }

	// Methods

	// RVA: 0x1D0DB44 Offset: 0x1D09B44 VA: 0x1D0DB44
	public void .ctor(string rep, RegexNode concat, Hashtable _caps) { }

	// RVA: 0x1D12828 Offset: 0x1D0E828 VA: 0x1D12828
	public static RegexReplacement GetOrCreate(WeakReference<RegexReplacement> replRef, string replacement, Hashtable caps, int capsize, Hashtable capnames, RegexOptions roptions) { }

	[CompilerGenerated]
	// RVA: 0x1D1293C Offset: 0x1D0E93C VA: 0x1D1293C
	public string get_Pattern() { }

	// RVA: 0x1D12944 Offset: 0x1D0E944 VA: 0x1D12944
	private void ReplacementImpl(StringBuilder sb, Match match) { }

	// RVA: 0x1D12AE4 Offset: 0x1D0EAE4 VA: 0x1D12AE4
	private void ReplacementImplRTL(List<string> al, Match match) { }

	// RVA: 0x1D12D14 Offset: 0x1D0ED14 VA: 0x1D12D14
	public string Replace(Regex regex, string input, int count, int startat) { }
}

// Namespace: System.Text.RegularExpressions
public abstract class RegexRunner // TypeDefIndex: 3889
{
	// Fields
	protected internal int runtextbeg; // 0x10
	protected internal int runtextend; // 0x14
	protected internal int runtextstart; // 0x18
	protected internal string runtext; // 0x20
	protected internal int runtextpos; // 0x28
	protected internal int[] runtrack; // 0x30
	protected internal int runtrackpos; // 0x38
	protected internal int[] runstack; // 0x40
	protected internal int runstackpos; // 0x48
	protected internal int[] runcrawl; // 0x50
	protected internal int runcrawlpos; // 0x58
	protected internal int runtrackcount; // 0x5C
	protected internal Match runmatch; // 0x60
	protected internal Regex runregex; // 0x68
	private int _timeout; // 0x70
	private bool _ignoreTimeout; // 0x74
	private int _timeoutOccursAt; // 0x78
	private int _timeoutChecksToSkip; // 0x7C

	// Methods

	// RVA: 0x1D09068 Offset: 0x1D05068 VA: 0x1D09068
	protected internal void .ctor() { }

	// RVA: 0x1D130AC Offset: 0x1D0F0AC VA: 0x1D130AC
	protected internal Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout) { }

	// RVA: 0x1D133FC Offset: 0x1D0F3FC VA: 0x1D133FC
	private void StartTimeoutWatch() { }

	// RVA: 0x1D0B0FC Offset: 0x1D070FC VA: 0x1D0B0FC
	protected void CheckTimeout() { }

	// RVA: 0x1D136B0 Offset: 0x1D0F6B0 VA: 0x1D136B0
	private void DoCheckTimeout() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Go();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract bool FindFirstChar();

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract void InitTrackCount();

	// RVA: 0x1D13434 Offset: 0x1D0F434 VA: 0x1D13434
	private void InitMatch() { }

	// RVA: 0x1D13658 Offset: 0x1D0F658 VA: 0x1D13658
	private Match TidyMatch(bool quick) { }

	// RVA: 0x1D09188 Offset: 0x1D05188 VA: 0x1D09188
	protected void EnsureStorage() { }

	// RVA: 0x1D0B2E4 Offset: 0x1D072E4 VA: 0x1D0B2E4
	protected bool IsBoundary(int index, int startpos, int endpos) { }

	// RVA: 0x1D0B3E4 Offset: 0x1D073E4 VA: 0x1D0B3E4
	protected bool IsECMABoundary(int index, int startpos, int endpos) { }

	// RVA: 0x1D13828 Offset: 0x1D0F828 VA: 0x1D13828
	protected void DoubleTrack() { }

	// RVA: 0x1D1377C Offset: 0x1D0F77C VA: 0x1D1377C
	protected void DoubleStack() { }

	// RVA: 0x1D138D4 Offset: 0x1D0F8D4 VA: 0x1D138D4
	protected void DoubleCrawl() { }

	// RVA: 0x1D13980 Offset: 0x1D0F980 VA: 0x1D13980
	protected void Crawl(int i) { }

	// RVA: 0x1D139DC Offset: 0x1D0F9DC VA: 0x1D139DC
	protected int Popcrawl() { }

	// RVA: 0x1D0B2C4 Offset: 0x1D072C4 VA: 0x1D0B2C4
	protected int Crawlpos() { }

	// RVA: 0x1D0B23C Offset: 0x1D0723C VA: 0x1D0B23C
	protected void Capture(int capnum, int start, int end) { }

	// RVA: 0x1D0B128 Offset: 0x1D07128 VA: 0x1D0B128
	protected void TransferCapture(int capnum, int uncapnum, int start, int end) { }

	// RVA: 0x1D0B294 Offset: 0x1D07294 VA: 0x1D0B294
	protected void Uncapture() { }

	// RVA: 0x1D0B10C Offset: 0x1D0710C VA: 0x1D0B10C
	protected bool IsMatched(int cap) { }

	// RVA: 0x1D0B4E4 Offset: 0x1D074E4 VA: 0x1D0B4E4
	protected int MatchIndex(int cap) { }

	// RVA: 0x1D0B500 Offset: 0x1D07500 VA: 0x1D0B500
	protected int MatchLength(int cap) { }
}

// Namespace: System.Text.RegularExpressions
public abstract class RegexRunnerFactory // TypeDefIndex: 3890
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected internal abstract RegexRunner CreateInstance();
}

// Namespace: System.Text.RegularExpressions
internal sealed class RegexTree // TypeDefIndex: 3891
{
	// Fields
	public readonly RegexNode Root; // 0x10
	public readonly Hashtable Caps; // 0x18
	public readonly int[] CapNumList; // 0x20
	public readonly int CapTop; // 0x28
	public readonly Hashtable CapNames; // 0x30
	public readonly string[] CapsList; // 0x38
	public readonly RegexOptions Options; // 0x40

	// Methods

	// RVA: 0x1D0D7C0 Offset: 0x1D097C0 VA: 0x1D0D7C0
	internal void .ctor(RegexNode root, Hashtable caps, int[] capNumList, int capTop, Hashtable capNames, string[] capsList, RegexOptions options) { }
}

// Namespace: System.Text.RegularExpressions
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
internal struct RegexWriter // TypeDefIndex: 3892
{
	// Fields
	private ValueListBuilder<int> _emitted; // 0x0
	private ValueListBuilder<int> _intStack; // 0x20
	private readonly Dictionary<string, int> _stringHash; // 0x40
	private readonly List<string> _stringTable; // 0x48
	private Hashtable _caps; // 0x50
	private int _trackCount; // 0x58

	// Methods

	// RVA: 0x1D13A18 Offset: 0x1D0FA18 VA: 0x1D13A18
	private void .ctor(Span<int> emittedSpan, Span<int> intStackSpan) { }

	// RVA: 0x1D13B5C Offset: 0x1D0FB5C VA: 0x1D13B5C
	public static RegexCode Write(RegexTree tree) { }

	// RVA: 0x1D140B8 Offset: 0x1D100B8 VA: 0x1D140B8
	public void Dispose() { }

	// RVA: 0x1D13C40 Offset: 0x1D0FC40 VA: 0x1D13C40
	public RegexCode RegexCodeFromRegexTree(RegexTree tree) { }

	// RVA: 0x1D14A6C Offset: 0x1D10A6C VA: 0x1D14A6C
	private void PatchJump(int offset, int jumpDest) { }

	// RVA: 0x1D14AD0 Offset: 0x1D10AD0 VA: 0x1D14AD0
	private void Emit(int op) { }

	// RVA: 0x1D1410C Offset: 0x1D1010C VA: 0x1D1410C
	private void Emit(int op, int opd1) { }

	// RVA: 0x1D14BA0 Offset: 0x1D10BA0 VA: 0x1D14BA0
	private void Emit(int op, int opd1, int opd2) { }

	// RVA: 0x1D14D48 Offset: 0x1D10D48 VA: 0x1D14D48
	private int StringCode(string str) { }

	// RVA: 0x1D14E90 Offset: 0x1D10E90 VA: 0x1D14E90
	private int MapCapnum(int capnum) { }

	// RVA: 0x1D1424C Offset: 0x1D1024C VA: 0x1D1424C
	private void EmitFragment(int nodetype, RegexNode node, int curIndex) { }
}
