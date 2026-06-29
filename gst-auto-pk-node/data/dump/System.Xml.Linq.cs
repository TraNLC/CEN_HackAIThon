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

// Namespace: System.Xml.Linq
internal class BaseUriAnnotation // TypeDefIndex: 7840
{
	// Fields
	internal string baseUri; // 0x10

	// Methods

	// RVA: 0x1B4F598 Offset: 0x1B4B598 VA: 0x1B4F598
	public void .ctor(string baseUri) { }
}

// Namespace: System.Xml.Linq
internal class LineInfoAnnotation // TypeDefIndex: 7841
{
	// Fields
	internal int lineNumber; // 0x10
	internal int linePosition; // 0x14

	// Methods

	// RVA: 0x1B4F5C8 Offset: 0x1B4B5C8 VA: 0x1B4F5C8
	public void .ctor(int lineNumber, int linePosition) { }
}

// Namespace: System.Xml.Linq
internal class LineInfoEndElementAnnotation : LineInfoAnnotation // TypeDefIndex: 7842
{
	// Methods

	// RVA: 0x1B4F5F4 Offset: 0x1B4B5F4 VA: 0x1B4F5F4
	public void .ctor(int lineNumber, int linePosition) { }
}

// Namespace: System.Xml.Linq
public class XAttribute : XObject // TypeDefIndex: 7843
{
	// Fields
	internal XAttribute next; // 0x20
	internal XName name; // 0x28
	internal string value; // 0x30

	// Properties
	public bool IsNamespaceDeclaration { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1B4F620 Offset: 0x1B4B620 VA: 0x1B4F620
	public void .ctor(XName name, object value) { }

	// RVA: 0x1B4FCB4 Offset: 0x1B4BCB4 VA: 0x1B4FCB4
	public void .ctor(XAttribute other) { }

	// RVA: 0x1B4FD40 Offset: 0x1B4BD40 VA: 0x1B4FD40
	public bool get_IsNamespaceDeclaration() { }

	// RVA: 0x1B4FDF4 Offset: 0x1B4BDF4 VA: 0x1B4FDF4
	public XName get_Name() { }

	// RVA: 0x1B4FDFC Offset: 0x1B4BDFC VA: 0x1B4FDFC Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1B4FE04 Offset: 0x1B4BE04 VA: 0x1B4FE04
	public string get_Value() { }

	// RVA: 0x1B4FE0C Offset: 0x1B4BE0C VA: 0x1B4FE0C Slot: 3
	public override string ToString() { }

	// RVA: 0x1B50140 Offset: 0x1B4C140 VA: 0x1B50140
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x1B4FA84 Offset: 0x1B4BA84 VA: 0x1B4FA84
	private static void ValidateAttribute(XName name, string value) { }
}

// Namespace: System.Xml.Linq
public class XCData : XText // TypeDefIndex: 7844
{
	// Properties
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x1B50480 Offset: 0x1B4C480 VA: 0x1B50480
	public void .ctor(string value) { }

	// RVA: 0x1B50500 Offset: 0x1B4C500 VA: 0x1B50500
	public void .ctor(XCData other) { }

	// RVA: 0x1B50580 Offset: 0x1B4C580 VA: 0x1B50580 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1B50588 Offset: 0x1B4C588 VA: 0x1B50588 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1B505F4 Offset: 0x1B4C5F4 VA: 0x1B505F4 Slot: 10
	internal override XNode CloneNode() { }
}

// Namespace: System.Xml.Linq
public class XComment : XNode // TypeDefIndex: 7845
{
	// Fields
	internal string value; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1B5064C Offset: 0x1B4C64C VA: 0x1B5064C
	public void .ctor(string value) { }

	// RVA: 0x1B506D0 Offset: 0x1B4C6D0 VA: 0x1B506D0
	public void .ctor(XComment other) { }

	// RVA: 0x1B5074C Offset: 0x1B4C74C VA: 0x1B5074C Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1B50754 Offset: 0x1B4C754 VA: 0x1B50754
	public string get_Value() { }

	// RVA: 0x1B5075C Offset: 0x1B4C75C VA: 0x1B5075C Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1B507C8 Offset: 0x1B4C7C8 VA: 0x1B507C8 Slot: 10
	internal override XNode CloneNode() { }
}

// Namespace: 
private sealed class XContainer.ContentReader // TypeDefIndex: 7846
{
	// Fields
	private readonly NamespaceCache _eCache; // 0x10
	private readonly NamespaceCache _aCache; // 0x20
	private readonly IXmlLineInfo _lineInfo; // 0x30
	private XContainer _currentContainer; // 0x38
	private string _baseUri; // 0x40

	// Methods

	// RVA: 0x1B5200C Offset: 0x1B4E00C VA: 0x1B5200C
	public void .ctor(XContainer rootContainer) { }

	// RVA: 0x1B52760 Offset: 0x1B4E760 VA: 0x1B52760
	public void .ctor(XContainer rootContainer, XmlReader r, LoadOptions o) { }

	// RVA: 0x1B5203C Offset: 0x1B4E03C VA: 0x1B5203C
	public bool ReadContentFrom(XContainer rootContainer, XmlReader r) { }

	// RVA: 0x1B52828 Offset: 0x1B4E828 VA: 0x1B52828
	public bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class XContainer.<Nodes>d__18 : IEnumerable<XNode>, IEnumerable, IEnumerator<XNode>, IDisposable, IEnumerator // TypeDefIndex: 7847
{
	// Fields
	private int <>1__state; // 0x10
	private XNode <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public XContainer <>4__this; // 0x28
	private XNode <n>5__2; // 0x30

	// Properties
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1B517A4 Offset: 0x1B4D7A4 VA: 0x1B517A4
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1B53CB0 Offset: 0x1B4FCB0 VA: 0x1B53CB0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1B53CB4 Offset: 0x1B4FCB4 VA: 0x1B53CB4 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1B53D74 Offset: 0x1B4FD74 VA: 0x1B53D74 Slot: 6
	private XNode System.Collections.Generic.IEnumerator<System.Xml.Linq.XNode>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1B53D7C Offset: 0x1B4FD7C VA: 0x1B53D7C Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1B53DB4 Offset: 0x1B4FDB4 VA: 0x1B53DB4 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1B53DBC Offset: 0x1B4FDBC VA: 0x1B53DBC Slot: 4
	private IEnumerator<XNode> System.Collections.Generic.IEnumerable<System.Xml.Linq.XNode>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1B53E60 Offset: 0x1B4FE60 VA: 0x1B53E60 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Xml.Linq
public abstract class XContainer : XNode // TypeDefIndex: 7848
{
	// Fields
	internal object content; // 0x28

	// Properties
	public XNode LastNode { get; }

	// Methods

	// RVA: 0x1B50820 Offset: 0x1B4C820 VA: 0x1B50820
	internal void .ctor() { }

	// RVA: 0x1B50828 Offset: 0x1B4C828 VA: 0x1B50828
	internal void .ctor(XContainer other) { }

	// RVA: 0x1B50A40 Offset: 0x1B4CA40 VA: 0x1B50A40
	public XNode get_LastNode() { }

	// RVA: 0x1B50B88 Offset: 0x1B4CB88 VA: 0x1B50B88
	public void Add(object content) { }

	[IteratorStateMachine(typeof(XContainer.<Nodes>d__18))]
	// RVA: 0x1B51724 Offset: 0x1B4D724 VA: 0x1B51724
	public IEnumerable<XNode> Nodes() { }

	// RVA: 0x1B517D8 Offset: 0x1B4D7D8 VA: 0x1B517D8 Slot: 11
	internal virtual void AddAttribute(XAttribute a) { }

	// RVA: 0x1B517DC Offset: 0x1B4D7DC VA: 0x1B517DC Slot: 12
	internal virtual void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1B50FD8 Offset: 0x1B4CFD8 VA: 0x1B50FD8
	internal void AddContentSkipNotify(object content) { }

	// RVA: 0x1B51390 Offset: 0x1B4D390 VA: 0x1B51390
	internal void AddNode(XNode n) { }

	// RVA: 0x1B517E0 Offset: 0x1B4D7E0 VA: 0x1B517E0
	internal void AddNodeSkipNotify(XNode n) { }

	// RVA: 0x1B51410 Offset: 0x1B4D410 VA: 0x1B51410
	internal void AddString(string s) { }

	// RVA: 0x1B51860 Offset: 0x1B4D860 VA: 0x1B51860
	internal void AddStringSkipNotify(string s) { }

	// RVA: 0x1B51AB8 Offset: 0x1B4DAB8 VA: 0x1B51AB8
	internal void AppendNode(XNode n) { }

	// RVA: 0x1B50960 Offset: 0x1B4C960 VA: 0x1B50960
	internal void AppendNodeSkipNotify(XNode n) { }

	// RVA: 0x1B51E30 Offset: 0x1B4DE30 VA: 0x1B51E30 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x1B519DC Offset: 0x1B4D9DC VA: 0x1B519DC
	internal void ConvertTextToNode() { }

	// RVA: 0x1B4F700 Offset: 0x1B4B700 VA: 0x1B4F700
	internal static string GetStringValue(object value) { }

	// RVA: 0x1B51F0C Offset: 0x1B4DF0C VA: 0x1B51F0C
	internal void ReadContentFrom(XmlReader r) { }

	// RVA: 0x1B52638 Offset: 0x1B4E638 VA: 0x1B52638
	internal void ReadContentFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x1B5346C Offset: 0x1B4F46C VA: 0x1B5346C
	internal void RemoveNode(XNode n) { }

	// RVA: 0x1B5364C Offset: 0x1B4F64C VA: 0x1B5364C Slot: 13
	internal virtual void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x1B53650 Offset: 0x1B4F650 VA: 0x1B53650 Slot: 14
	internal virtual void ValidateString(string s) { }

	// RVA: 0x1B53654 Offset: 0x1B4F654 VA: 0x1B53654
	internal void WriteContentTo(XmlWriter writer) { }
}

// Namespace: System.Xml.Linq
public class XDeclaration // TypeDefIndex: 7849
{
	// Fields
	private string _version; // 0x10
	private string _encoding; // 0x18
	private string _standalone; // 0x20

	// Properties
	public string Encoding { get; }
	public string Standalone { get; }
	public string Version { get; }

	// Methods

	// RVA: 0x1B53E64 Offset: 0x1B4FE64 VA: 0x1B53E64
	public void .ctor(string version, string encoding, string standalone) { }

	// RVA: 0x1B53EC4 Offset: 0x1B4FEC4 VA: 0x1B53EC4
	public void .ctor(XDeclaration other) { }

	// RVA: 0x1B53F60 Offset: 0x1B4FF60 VA: 0x1B53F60
	public string get_Encoding() { }

	// RVA: 0x1B53F68 Offset: 0x1B4FF68 VA: 0x1B53F68
	public string get_Standalone() { }

	// RVA: 0x1B53F70 Offset: 0x1B4FF70 VA: 0x1B53F70
	public string get_Version() { }

	// RVA: 0x1B53F78 Offset: 0x1B4FF78 VA: 0x1B53F78 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Xml.Linq
public class XDocument : XContainer // TypeDefIndex: 7850
{
	// Fields
	private XDeclaration _declaration; // 0x30

	// Properties
	public XDeclaration Declaration { get; set; }
	public override XmlNodeType NodeType { get; }
	public XElement Root { get; }

	// Methods

	// RVA: 0x1B541E8 Offset: 0x1B501E8 VA: 0x1B541E8
	public void .ctor() { }

	// RVA: 0x1B541F0 Offset: 0x1B501F0 VA: 0x1B541F0
	public void .ctor(XDocument other) { }

	// RVA: 0x1B5427C Offset: 0x1B5027C VA: 0x1B5427C
	public XDeclaration get_Declaration() { }

	// RVA: 0x1B54284 Offset: 0x1B50284 VA: 0x1B54284
	public void set_Declaration(XDeclaration value) { }

	// RVA: 0x1B5428C Offset: 0x1B5028C VA: 0x1B5428C Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1B54294 Offset: 0x1B50294 VA: 0x1B54294
	public XElement get_Root() { }

	// RVA: 0x1B542DC Offset: 0x1B502DC VA: 0x1B542DC Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1B54408 Offset: 0x1B50408 VA: 0x1B54408 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x1B54454 Offset: 0x1B50454 VA: 0x1B54454 Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1B544A0 Offset: 0x1B504A0 VA: 0x1B544A0 Slot: 10
	internal override XNode CloneNode() { }

	// RVA: -1 Offset: -1
	private T GetFirstNode<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103DBD4 Offset: 0x1039BD4 VA: 0x103DBD4
	|-XDocument.GetFirstNode<object>
	*/

	// RVA: 0x1B544F8 Offset: 0x1B504F8 VA: 0x1B544F8
	internal static bool IsWhitespace(string s) { }

	// RVA: 0x1B54584 Offset: 0x1B50584 VA: 0x1B54584 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }

	// RVA: 0x1B54734 Offset: 0x1B50734 VA: 0x1B54734
	private void ValidateDocument(XNode previous, XmlNodeType allowBefore, XmlNodeType allowAfter) { }

	// RVA: 0x1B54854 Offset: 0x1B50854 VA: 0x1B54854 Slot: 14
	internal override void ValidateString(string s) { }
}

// Namespace: System.Xml.Linq
public class XDocumentType : XNode // TypeDefIndex: 7851
{
	// Fields
	private string _name; // 0x28
	private string _publicId; // 0x30
	private string _systemId; // 0x38
	private string _internalSubset; // 0x40

	// Properties
	public string InternalSubset { get; }
	public string Name { get; }
	public override XmlNodeType NodeType { get; }
	public string PublicId { get; }
	public string SystemId { get; }

	// Methods

	// RVA: 0x1B539C0 Offset: 0x1B4F9C0 VA: 0x1B539C0
	public void .ctor(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1B548B4 Offset: 0x1B508B4 VA: 0x1B548B4
	public void .ctor(XDocumentType other) { }

	// RVA: 0x1B54960 Offset: 0x1B50960 VA: 0x1B54960
	public string get_InternalSubset() { }

	// RVA: 0x1B54968 Offset: 0x1B50968 VA: 0x1B54968
	public string get_Name() { }

	// RVA: 0x1B54970 Offset: 0x1B50970 VA: 0x1B54970 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1B54978 Offset: 0x1B50978 VA: 0x1B54978
	public string get_PublicId() { }

	// RVA: 0x1B54980 Offset: 0x1B50980 VA: 0x1B54980
	public string get_SystemId() { }

	// RVA: 0x1B54988 Offset: 0x1B50988 VA: 0x1B54988 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1B549F4 Offset: 0x1B509F4 VA: 0x1B549F4 Slot: 10
	internal override XNode CloneNode() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class XElement.<GetAttributes>d__116 : IEnumerable<XAttribute>, IEnumerable, IEnumerator<XAttribute>, IDisposable, IEnumerator // TypeDefIndex: 7852
{
	// Fields
	private int <>1__state; // 0x10
	private XAttribute <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	public XElement <>4__this; // 0x28
	private XName name; // 0x30
	public XName <>3__name; // 0x38
	private XAttribute <a>5__2; // 0x40

	// Properties
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1B5551C Offset: 0x1B5151C VA: 0x1B5551C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1B55E18 Offset: 0x1B51E18 VA: 0x1B55E18 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1B55E1C Offset: 0x1B51E1C VA: 0x1B55E1C Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1B55EF4 Offset: 0x1B51EF4 VA: 0x1B55EF4 Slot: 6
	private XAttribute System.Collections.Generic.IEnumerator<System.Xml.Linq.XAttribute>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1B55EFC Offset: 0x1B51EFC VA: 0x1B55EFC Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1B55F34 Offset: 0x1B51F34 VA: 0x1B55F34 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1B55F3C Offset: 0x1B51F3C VA: 0x1B55F3C Slot: 4
	private IEnumerator<XAttribute> System.Collections.Generic.IEnumerable<System.Xml.Linq.XAttribute>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1B55FF0 Offset: 0x1B51FF0 VA: 0x1B55FF0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Xml.Linq
[XmlSchemaProvider(null, IsAny = True)]
[XmlTypeConvertor("ConvertForAssignment")]
public class XElement : XContainer, IXmlSerializable // TypeDefIndex: 7853
{
	// Fields
	internal XName name; // 0x30
	internal XAttribute lastAttr; // 0x38

	// Properties
	public bool HasAttributes { get; }
	public bool IsEmpty { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1B5383C Offset: 0x1B4F83C VA: 0x1B5383C
	public void .ctor(XName name) { }

	// RVA: 0x1B54A4C Offset: 0x1B50A4C VA: 0x1B54A4C
	public void .ctor(XElement other) { }

	// RVA: 0x1B5169C Offset: 0x1B4D69C VA: 0x1B5169C
	public void .ctor(XStreamingElement other) { }

	// RVA: 0x1B54AF8 Offset: 0x1B50AF8 VA: 0x1B54AF8
	public bool get_HasAttributes() { }

	// RVA: 0x1B54B08 Offset: 0x1B50B08 VA: 0x1B54B08
	public bool get_IsEmpty() { }

	// RVA: 0x1B54B18 Offset: 0x1B50B18 VA: 0x1B54B18
	public XName get_Name() { }

	// RVA: 0x1B54B20 Offset: 0x1B50B20 VA: 0x1B54B20 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1B54B28 Offset: 0x1B50B28 VA: 0x1B54B28
	public string get_Value() { }

	// RVA: 0x1B54B98 Offset: 0x1B50B98 VA: 0x1B54B98
	public XAttribute Attribute(XName name) { }

	// RVA: 0x1B54BD4 Offset: 0x1B50BD4 VA: 0x1B54BD4
	public IEnumerable<XAttribute> Attributes() { }

	// RVA: 0x1B5026C Offset: 0x1B4C26C VA: 0x1B5026C
	public string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x1B54D78 Offset: 0x1B50D78 VA: 0x1B54D78 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1B54FC0 Offset: 0x1B50FC0 VA: 0x1B54FC0 Slot: 15
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1B54FC8 Offset: 0x1B50FC8 VA: 0x1B54FC8 Slot: 16
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1B551D4 Offset: 0x1B511D4 VA: 0x1B551D4 Slot: 17
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1B551E0 Offset: 0x1B511E0 VA: 0x1B551E0 Slot: 11
	internal override void AddAttribute(XAttribute a) { }

	// RVA: 0x1B553DC Offset: 0x1B513DC VA: 0x1B553DC Slot: 12
	internal override void AddAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1B552C8 Offset: 0x1B512C8 VA: 0x1B552C8
	internal void AppendAttribute(XAttribute a) { }

	// RVA: 0x1B538B8 Offset: 0x1B4F8B8 VA: 0x1B538B8
	internal void AppendAttributeSkipNotify(XAttribute a) { }

	// RVA: 0x1B554C4 Offset: 0x1B514C4 VA: 0x1B554C4 Slot: 10
	internal override XNode CloneNode() { }

	[IteratorStateMachine(typeof(XElement.<GetAttributes>d__116))]
	// RVA: 0x1B54BDC Offset: 0x1B50BDC VA: 0x1B54BDC
	private IEnumerable<XAttribute> GetAttributes(XName name) { }

	// RVA: 0x1B54C84 Offset: 0x1B50C84 VA: 0x1B54C84
	private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope) { }

	// RVA: 0x1B5515C Offset: 0x1B5115C VA: 0x1B5515C
	private void ReadElementFrom(XmlReader r, LoadOptions o) { }

	// RVA: 0x1B55550 Offset: 0x1B51550 VA: 0x1B55550
	private void ReadElementFromImpl(XmlReader r, LoadOptions o) { }

	// RVA: 0x1B53B6C Offset: 0x1B4FB6C VA: 0x1B53B6C
	internal void SetEndElementLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x1B55CE4 Offset: 0x1B51CE4 VA: 0x1B55CE4 Slot: 13
	internal override void ValidateNode(XNode node, XNode previous) { }
}

// Namespace: 
public sealed class XHashtable.ExtractKeyDelegate<TValue> : MulticastDelegate // TypeDefIndex: 7854
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1255FE4 Offset: 0x1251FE4 VA: 0x1255FE4
	|-XHashtable.ExtractKeyDelegate<object>..ctor
	|
	|-RVA: 0x1256100 Offset: 0x1252100 VA: 0x1256100
	|-XHashtable.ExtractKeyDelegate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual string Invoke(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12560EC Offset: 0x12520EC VA: 0x12560EC
	|-XHashtable.ExtractKeyDelegate<object>.Invoke
	|
	|-RVA: 0x125620C Offset: 0x125220C VA: 0x125620C
	|-XHashtable.ExtractKeyDelegate<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private struct XHashtable.XHashtableState.Entry<TValue> // TypeDefIndex: 7855
{
	// Fields
	public TValue Value; // 0x0
	public int HashCode; // 0x0
	public int Next; // 0x0
}

// Namespace: 
private sealed class XHashtable.XHashtableState<TValue> // TypeDefIndex: 7856
{
	// Fields
	private int[] _buckets; // 0x0
	private XHashtable.XHashtableState.Entry<TValue>[] _entries; // 0x0
	private int _numEntries; // 0x0
	private XHashtable.ExtractKeyDelegate<TValue> _extractKey; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1546C8C Offset: 0x1542C8C VA: 0x1546C8C
	|-XHashtable.XHashtableState<object>..ctor
	|
	|-RVA: 0x1547468 Offset: 0x1543468 VA: 0x1547468
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public XHashtable.XHashtableState<TValue> Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1546D50 Offset: 0x1542D50 VA: 0x1546D50
	|-XHashtable.XHashtableState<object>.Resize
	|
	|-RVA: 0x154752C Offset: 0x154352C VA: 0x154752C
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.Resize
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1546F94 Offset: 0x1542F94 VA: 0x1546F94
	|-XHashtable.XHashtableState<object>.TryGetValue
	|
	|-RVA: 0x15479C8 Offset: 0x15439C8 VA: 0x15479C8
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TValue value, out TValue newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1547048 Offset: 0x1543048 VA: 0x1547048
	|-XHashtable.XHashtableState<object>.TryAdd
	|
	|-RVA: 0x1547B84 Offset: 0x1543B84 VA: 0x1547B84
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1
	private bool FindEntry(int hashCode, string key, int index, int count, ref int entryIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x154720C Offset: 0x154320C VA: 0x154720C
	|-XHashtable.XHashtableState<object>.FindEntry
	|
	|-RVA: 0x1547F94 Offset: 0x1543F94 VA: 0x1547F94
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.FindEntry
	*/

	// RVA: -1 Offset: -1
	private static int ComputeHashCode(string key, int index, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15473EC Offset: 0x15433EC VA: 0x15473EC
	|-XHashtable.XHashtableState<object>.ComputeHashCode
	|
	|-RVA: 0x154838C Offset: 0x154438C VA: 0x154838C
	|-XHashtable.XHashtableState<__Il2CppFullySharedGenericType>.ComputeHashCode
	*/
}

// Namespace: System.Xml.Linq
internal sealed class XHashtable<TValue> // TypeDefIndex: 7857
{
	// Fields
	private XHashtable.XHashtableState<TValue> _state; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(XHashtable.ExtractKeyDelegate<TValue> extractKey, int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1548408 Offset: 0x1544408 VA: 0x1548408
	|-XHashtable<object>..ctor
	|
	|-RVA: 0x1548600 Offset: 0x1544600 VA: 0x1548600
	|-XHashtable<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(string key, int index, int count, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1548484 Offset: 0x1544484 VA: 0x1548484
	|-XHashtable<object>.TryGetValue
	|
	|-RVA: 0x1548680 Offset: 0x1544680 VA: 0x1548680
	|-XHashtable<__Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue Add(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15484A4 Offset: 0x15444A4 VA: 0x15484A4
	|-XHashtable<object>.Add
	|
	|-RVA: 0x15486A4 Offset: 0x15446A4 VA: 0x15486A4
	|-XHashtable<__Il2CppFullySharedGenericType>.Add
	*/
}

// Namespace: System.Xml.Linq
internal struct NamespaceCache // TypeDefIndex: 7858
{
	// Fields
	private XNamespace _ns; // 0x0
	private string _namespaceName; // 0x8

	// Methods

	// RVA: 0x1B53794 Offset: 0x1B4F794 VA: 0x1B53794
	public XNamespace Get(string namespaceName) { }
}

// Namespace: System.Xml.Linq
internal struct ElementWriter // TypeDefIndex: 7859
{
	// Fields
	private XmlWriter _writer; // 0x0
	private NamespaceResolver _resolver; // 0x8

	// Methods

	// RVA: 0x1B54E10 Offset: 0x1B50E10 VA: 0x1B54E10
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x1B54E30 Offset: 0x1B50E30 VA: 0x1B54E30
	public void WriteElement(XElement e) { }

	// RVA: 0x1B562BC Offset: 0x1B522BC VA: 0x1B562BC
	private string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }

	// RVA: 0x1B55FF4 Offset: 0x1B51FF4 VA: 0x1B55FF4
	private void PushAncestors(XElement e) { }

	// RVA: 0x1B56588 Offset: 0x1B52588 VA: 0x1B56588
	private void PushElement(XElement e) { }

	// RVA: 0x1B56264 Offset: 0x1B52264 VA: 0x1B56264
	private void WriteEndElement() { }

	// RVA: 0x1B56290 Offset: 0x1B52290 VA: 0x1B56290
	private void WriteFullEndElement() { }

	// RVA: 0x1B56104 Offset: 0x1B52104 VA: 0x1B56104
	private void WriteStartElement(XElement e) { }
}

// Namespace: 
private class NamespaceResolver.NamespaceDeclaration // TypeDefIndex: 7860
{
	// Fields
	public string prefix; // 0x10
	public XNamespace ns; // 0x18
	public int scope; // 0x20
	public NamespaceResolver.NamespaceDeclaration prev; // 0x28

	// Methods

	// RVA: 0x1B567C4 Offset: 0x1B527C4 VA: 0x1B567C4
	public void .ctor() { }
}

// Namespace: System.Xml.Linq
internal struct NamespaceResolver // TypeDefIndex: 7861
{
	// Fields
	private int _scope; // 0x0
	private NamespaceResolver.NamespaceDeclaration _declaration; // 0x8
	private NamespaceResolver.NamespaceDeclaration _rover; // 0x10

	// Methods

	// RVA: 0x1B5663C Offset: 0x1B5263C VA: 0x1B5663C
	public void PushScope() { }

	// RVA: 0x1B56730 Offset: 0x1B52730 VA: 0x1B56730
	public void PopScope() { }

	// RVA: 0x1B5664C Offset: 0x1B5264C VA: 0x1B5664C
	public void Add(string prefix, XNamespace ns) { }

	// RVA: 0x1B564A0 Offset: 0x1B524A0 VA: 0x1B564A0
	public void AddFirst(string prefix, XNamespace ns) { }

	// RVA: 0x1B563AC Offset: 0x1B523AC VA: 0x1B563AC
	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }
}

// Namespace: System.Xml.Linq
public enum XObjectChange // TypeDefIndex: 7862
{
	// Fields
	public int value__; // 0x0
	public const XObjectChange Add = 0;
	public const XObjectChange Remove = 1;
	public const XObjectChange Name = 2;
	public const XObjectChange Value = 3;
}

// Namespace: System.Xml.Linq
[Flags]
public enum LoadOptions // TypeDefIndex: 7863
{
	// Fields
	public int value__; // 0x0
	public const LoadOptions None = 0;
	public const LoadOptions PreserveWhitespace = 1;
	public const LoadOptions SetBaseUri = 2;
	public const LoadOptions SetLineInfo = 4;
}

// Namespace: System.Xml.Linq
[Flags]
public enum SaveOptions // TypeDefIndex: 7864
{
	// Fields
	public int value__; // 0x0
	public const SaveOptions None = 0;
	public const SaveOptions DisableFormatting = 1;
	public const SaveOptions OmitDuplicateNamespaces = 2;
}

// Namespace: System.Xml.Linq
[Serializable]
public sealed class XName : IEquatable<XName>, ISerializable // TypeDefIndex: 7865
{
	// Fields
	private XNamespace _ns; // 0x10
	private string _localName; // 0x18
	private int _hashCode; // 0x20

	// Properties
	public string LocalName { get; }
	public XNamespace Namespace { get; }
	public string NamespaceName { get; }

	// Methods

	// RVA: 0x1B567CC Offset: 0x1B527CC VA: 0x1B567CC
	internal void .ctor(XNamespace ns, string localName) { }

	// RVA: 0x1B5689C Offset: 0x1B5289C VA: 0x1B5689C
	public string get_LocalName() { }

	// RVA: 0x1B568A4 Offset: 0x1B528A4 VA: 0x1B568A4
	public XNamespace get_Namespace() { }

	// RVA: 0x1B4FDDC Offset: 0x1B4BDDC VA: 0x1B4FDDC
	public string get_NamespaceName() { }

	// RVA: 0x1B568AC Offset: 0x1B528AC VA: 0x1B568AC Slot: 3
	public override string ToString() { }

	// RVA: 0x1B5693C Offset: 0x1B5293C VA: 0x1B5693C
	public static XName Get(string expandedName) { }

	// RVA: 0x1B56EE0 Offset: 0x1B52EE0 VA: 0x1B56EE0
	public static XName Get(string localName, string namespaceName) { }

	[CLSCompliant(False)]
	// RVA: 0x1B56F04 Offset: 0x1B52F04 VA: 0x1B56F04
	public static XName op_Implicit(string expandedName) { }

	// RVA: 0x1B56F10 Offset: 0x1B52F10 VA: 0x1B56F10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B56F1C Offset: 0x1B52F1C VA: 0x1B56F1C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B4F6F4 Offset: 0x1B4B6F4 VA: 0x1B4F6F4
	public static bool op_Equality(XName left, XName right) { }

	// RVA: 0x1B56F24 Offset: 0x1B52F24 VA: 0x1B56F24 Slot: 4
	private bool System.IEquatable<System.Xml.Linq.XName>.Equals(XName other) { }

	// RVA: 0x1B56F30 Offset: 0x1B52F30 VA: 0x1B56F30 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B56F68 Offset: 0x1B52F68 VA: 0x1B56F68
	internal void .ctor() { }
}

// Namespace: System.Xml.Linq
public sealed class XNamespace // TypeDefIndex: 7866
{
	// Fields
	private static XHashtable<WeakReference> s_namespaces; // 0x0
	private static WeakReference s_refNone; // 0x8
	private static WeakReference s_refXml; // 0x10
	private static WeakReference s_refXmlns; // 0x18
	private string _namespaceName; // 0x10
	private int _hashCode; // 0x18
	private XHashtable<XName> _names; // 0x20

	// Properties
	public string NamespaceName { get; }
	public static XNamespace None { get; }
	public static XNamespace Xml { get; }
	public static XNamespace Xmlns { get; }

	// Methods

	// RVA: 0x1B56FA0 Offset: 0x1B52FA0 VA: 0x1B56FA0
	internal void .ctor(string namespaceName) { }

	// RVA: 0x1B570B0 Offset: 0x1B530B0 VA: 0x1B570B0
	public string get_NamespaceName() { }

	// RVA: 0x1B537E0 Offset: 0x1B4F7E0 VA: 0x1B537E0
	public XName GetName(string localName) { }

	// RVA: 0x1B570B8 Offset: 0x1B530B8 VA: 0x1B570B8 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B56E84 Offset: 0x1B52E84 VA: 0x1B56E84
	public static XNamespace get_None() { }

	// RVA: 0x1B571A0 Offset: 0x1B531A0 VA: 0x1B571A0
	public static XNamespace get_Xml() { }

	// RVA: 0x1B57200 Offset: 0x1B53200 VA: 0x1B57200
	public static XNamespace get_Xmlns() { }

	// RVA: 0x1B55A30 Offset: 0x1B51A30 VA: 0x1B55A30
	public static XNamespace Get(string namespaceName) { }

	[CLSCompliant(False)]
	// RVA: 0x1B57260 Offset: 0x1B53260 VA: 0x1B57260
	public static XNamespace op_Implicit(string namespaceName) { }

	// RVA: 0x1B5726C Offset: 0x1B5326C VA: 0x1B5726C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B57278 Offset: 0x1B53278 VA: 0x1B57278 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B54C78 Offset: 0x1B50C78 VA: 0x1B54C78
	public static bool op_Equality(XNamespace left, XNamespace right) { }

	// RVA: 0x1B57280 Offset: 0x1B53280 VA: 0x1B57280
	public static bool op_Inequality(XNamespace left, XNamespace right) { }

	// RVA: 0x1B56D7C Offset: 0x1B52D7C VA: 0x1B56D7C
	internal XName GetName(string localName, int index, int count) { }

	// RVA: 0x1B56A84 Offset: 0x1B52A84 VA: 0x1B56A84
	internal static XNamespace Get(string namespaceName, int index, int count) { }

	// RVA: 0x1B5728C Offset: 0x1B5328C VA: 0x1B5728C
	private static string ExtractLocalName(XName n) { }

	// RVA: 0x1B572A0 Offset: 0x1B532A0 VA: 0x1B572A0
	private static string ExtractNamespace(WeakReference r) { }

	// RVA: 0x1B570C0 Offset: 0x1B530C0 VA: 0x1B570C0
	private static XNamespace EnsureNamespace(ref WeakReference refNmsp, string namespaceName) { }
}

// Namespace: System.Xml.Linq
public abstract class XNode : XObject // TypeDefIndex: 7867
{
	// Fields
	internal XNode next; // 0x20

	// Methods

	// RVA: 0x1B506C8 Offset: 0x1B4C6C8 VA: 0x1B506C8
	internal void .ctor() { }

	// RVA: 0x1B57318 Offset: 0x1B53318 VA: 0x1B57318
	public void Remove() { }

	// RVA: 0x1B57374 Offset: 0x1B53374 VA: 0x1B57374 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteTo(XmlWriter writer);

	// RVA: 0x1B5782C Offset: 0x1B5382C VA: 0x1B5782C Slot: 9
	internal virtual void AppendText(StringBuilder sb) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract XNode CloneNode();

	// RVA: 0x1B57464 Offset: 0x1B53464 VA: 0x1B57464
	private string GetXmlString(SaveOptions o) { }
}

// Namespace: System.Xml.Linq
public abstract class XObject : IXmlLineInfo // TypeDefIndex: 7868
{
	// Fields
	internal XContainer parent; // 0x10
	internal object annotations; // 0x18

	// Properties
	public string BaseUri { get; }
	public abstract XmlNodeType NodeType { get; }
	public XElement Parent { get; }
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }
	internal bool HasBaseUri { get; }

	// Methods

	// RVA: 0x1B4F6EC Offset: 0x1B4B6EC VA: 0x1B4F6EC
	internal void .ctor() { }

	// RVA: 0x1B53C30 Offset: 0x1B4FC30 VA: 0x1B53C30
	public string get_BaseUri() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x1B57830 Offset: 0x1B53830 VA: 0x1B57830
	public XElement get_Parent() { }

	// RVA: 0x1B55A8C Offset: 0x1B51A8C VA: 0x1B55A8C
	public void AddAnnotation(object annotation) { }

	// RVA: 0x1B578AC Offset: 0x1B538AC VA: 0x1B578AC
	private object AnnotationForSealedType(Type type) { }

	// RVA: -1 Offset: -1
	public T Annotation<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103DC9C Offset: 0x1039C9C VA: 0x103DC9C
	|-XObject.Annotation<object>
	*/

	// RVA: 0x1B579EC Offset: 0x1B539EC VA: 0x1B579EC Slot: 4
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x1B57A40 Offset: 0x1B53A40 VA: 0x1B57A40 Slot: 5
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x1B57A94 Offset: 0x1B53A94 VA: 0x1B57A94 Slot: 6
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x1B53BDC Offset: 0x1B4FBDC VA: 0x1B53BDC
	internal bool get_HasBaseUri() { }

	// RVA: 0x1B51C78 Offset: 0x1B4DC78 VA: 0x1B51C78
	internal bool NotifyChanged(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x1B51BCC Offset: 0x1B4DBCC VA: 0x1B51BCC
	internal bool NotifyChanging(object sender, XObjectChangeEventArgs e) { }

	// RVA: 0x1B53A84 Offset: 0x1B4FA84 VA: 0x1B53A84
	internal void SetBaseUri(string baseUri) { }

	// RVA: 0x1B53AFC Offset: 0x1B4FAFC VA: 0x1B53AFC
	internal void SetLineInfo(int lineNumber, int linePosition) { }

	// RVA: 0x1B50F68 Offset: 0x1B4CF68 VA: 0x1B50F68
	internal bool SkipNotify() { }

	// RVA: 0x1B57390 Offset: 0x1B53390 VA: 0x1B57390
	internal SaveOptions GetSaveOptionsFromAnnotations() { }
}

// Namespace: System.Xml.Linq
internal class XObjectChangeAnnotation // TypeDefIndex: 7869
{
	// Fields
	internal EventHandler<XObjectChangeEventArgs> changing; // 0x10
	internal EventHandler<XObjectChangeEventArgs> changed; // 0x18
}

// Namespace: System.Xml.Linq
public class XObjectChangeEventArgs : EventArgs // TypeDefIndex: 7870
{
	// Fields
	private XObjectChange _objectChange; // 0x10
	public static readonly XObjectChangeEventArgs Add; // 0x0
	public static readonly XObjectChangeEventArgs Remove; // 0x8
	public static readonly XObjectChangeEventArgs Name; // 0x10
	public static readonly XObjectChangeEventArgs Value; // 0x18

	// Methods

	// RVA: 0x1B57AE8 Offset: 0x1B53AE8 VA: 0x1B57AE8
	public void .ctor(XObjectChange objectChange) { }

	// RVA: 0x1B57B54 Offset: 0x1B53B54 VA: 0x1B57B54
	private static void .cctor() { }
}

// Namespace: System.Xml.Linq
public class XProcessingInstruction : XNode // TypeDefIndex: 7871
{
	// Fields
	internal string target; // 0x28
	internal string data; // 0x30

	// Properties
	public string Data { get; }
	public override XmlNodeType NodeType { get; }
	public string Target { get; }

	// Methods

	// RVA: 0x1B53928 Offset: 0x1B4F928 VA: 0x1B53928
	public void .ctor(string target, string data) { }

	// RVA: 0x1B57D0C Offset: 0x1B53D0C VA: 0x1B57D0C
	public void .ctor(XProcessingInstruction other) { }

	// RVA: 0x1B57D98 Offset: 0x1B53D98 VA: 0x1B57D98
	public string get_Data() { }

	// RVA: 0x1B57DA0 Offset: 0x1B53DA0 VA: 0x1B57DA0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1B57DA8 Offset: 0x1B53DA8 VA: 0x1B57DA8
	public string get_Target() { }

	// RVA: 0x1B57DB0 Offset: 0x1B53DB0 VA: 0x1B57DB0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1B57E1C Offset: 0x1B53E1C VA: 0x1B57E1C Slot: 10
	internal override XNode CloneNode() { }

	// RVA: 0x1B57C34 Offset: 0x1B53C34 VA: 0x1B57C34
	private static void ValidateName(string name) { }
}

// Namespace: System.Xml.Linq
public class XStreamingElement // TypeDefIndex: 7872
{
	// Fields
	internal XName name; // 0x10
	internal object content; // 0x18
}

// Namespace: System.Xml.Linq
public class XText : XNode // TypeDefIndex: 7873
{
	// Fields
	internal string text; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x1B50484 Offset: 0x1B4C484 VA: 0x1B50484
	public void .ctor(string value) { }

	// RVA: 0x1B50504 Offset: 0x1B4C504 VA: 0x1B50504
	public void .ctor(XText other) { }

	// RVA: 0x1B57E74 Offset: 0x1B53E74 VA: 0x1B57E74 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1B57E7C Offset: 0x1B53E7C VA: 0x1B57E7C
	public string get_Value() { }

	// RVA: 0x1B51D24 Offset: 0x1B4DD24 VA: 0x1B51D24
	public void set_Value(string value) { }

	// RVA: 0x1B57E84 Offset: 0x1B53E84 VA: 0x1B57E84 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x1B57F70 Offset: 0x1B53F70 VA: 0x1B57F70 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x1B57F90 Offset: 0x1B53F90 VA: 0x1B57F90 Slot: 10
	internal override XNode CloneNode() { }
}
