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

// Namespace: System.Xml.XPath
public class XPathDocument // TypeDefIndex: 3272
{
	// Fields
	private XPathNode[] pageXmlNmsp; // 0x10
	private int idxXmlNmsp; // 0x18
	private XmlNameTable nameTable; // 0x20
	private bool hasLineInfo; // 0x28
	private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp; // 0x30

	// Properties
	internal XmlNameTable NameTable { get; }
	internal bool HasLineInfo { get; }

	// Methods

	// RVA: 0x1C72DCC Offset: 0x1C6EDCC VA: 0x1C72DCC
	internal XmlNameTable get_NameTable() { }

	// RVA: 0x1C72DD4 Offset: 0x1C6EDD4 VA: 0x1C72DD4
	internal bool get_HasLineInfo() { }

	// RVA: 0x1C72DDC Offset: 0x1C6EDDC VA: 0x1C72DDC
	internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp) { }

	// RVA: 0x1C72E04 Offset: 0x1C6EE04 VA: 0x1C72E04
	internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }
}

// Namespace: System.Xml.XPath
[Serializable]
public class XPathException : SystemException // TypeDefIndex: 3273
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private string message; // 0xA0

	// Properties
	public override string Message { get; }

	// Methods

	// RVA: 0x1C72EF0 Offset: 0x1C6EEF0 VA: 0x1C72EF0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C73298 Offset: 0x1C6F298 VA: 0x1C73298 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C73380 Offset: 0x1C6F380 VA: 0x1C73380
	public void .ctor() { }

	// RVA: 0x1C7339C Offset: 0x1C6F39C VA: 0x1C7339C
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1C734B8 Offset: 0x1C6F4B8 VA: 0x1C734B8
	internal static XPathException Create(string res) { }

	// RVA: 0x1C73520 Offset: 0x1C6F520 VA: 0x1C73520
	internal static XPathException Create(string res, string arg) { }

	// RVA: 0x1C735D4 Offset: 0x1C6F5D4 VA: 0x1C735D4
	internal static XPathException Create(string res, string arg, string arg2) { }

	// RVA: 0x1C73518 Offset: 0x1C6F518 VA: 0x1C73518
	private void .ctor(string res, string[] args) { }

	// RVA: 0x1C73444 Offset: 0x1C6F444 VA: 0x1C73444
	private void .ctor(string res, string[] args, Exception inner) { }

	// RVA: 0x1C73168 Offset: 0x1C6F168 VA: 0x1C73168
	private static string CreateMessage(string res, string[] args) { }

	// RVA: 0x1C736AC Offset: 0x1C6F6AC VA: 0x1C736AC Slot: 5
	public override string get_Message() { }
}

// Namespace: System.Xml.XPath
public enum XPathResultType // TypeDefIndex: 3274
{
	// Fields
	public int value__; // 0x0
	public const XPathResultType Number = 0;
	public const XPathResultType String = 1;
	public const XPathResultType Boolean = 2;
	public const XPathResultType NodeSet = 3;
	public const XPathResultType Navigator = 1;
	public const XPathResultType Any = 5;
	public const XPathResultType Error = 6;
}

// Namespace: System.Xml.XPath
public abstract class XPathItem // TypeDefIndex: 3275
{
	// Properties
	public abstract XmlSchemaType XmlType { get; }
	public abstract string Value { get; }
	public abstract object TypedValue { get; }
	public abstract Type ValueType { get; }
	public abstract bool ValueAsBoolean { get; }
	public abstract DateTime ValueAsDateTime { get; }
	public abstract double ValueAsDouble { get; }
	public abstract int ValueAsInt { get; }
	public abstract long ValueAsLong { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract XmlSchemaType get_XmlType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object get_TypedValue();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_ValueAsBoolean();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract DateTime get_ValueAsDateTime();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract double get_ValueAsDouble();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_ValueAsInt();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_ValueAsLong();

	// RVA: 0x1C736C4 Offset: 0x1C6F6C4 VA: 0x1C736C4 Slot: 13
	public virtual object ValueAs(Type returnType) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver);

	// RVA: 0x1C736D8 Offset: 0x1C6F6D8 VA: 0x1C736D8
	protected void .ctor() { }
}

// Namespace: System.Xml.XPath
public enum XPathNamespaceScope // TypeDefIndex: 3276
{
	// Fields
	public int value__; // 0x0
	public const XPathNamespaceScope All = 0;
	public const XPathNamespaceScope ExcludeXml = 1;
	public const XPathNamespaceScope Local = 2;
}

// Namespace: System.Xml.XPath
[DebuggerDisplay("{debuggerDisplayProxy}")]
public abstract class XPathNavigator : XPathItem, ICloneable, IXmlNamespaceResolver // TypeDefIndex: 3277
{
	// Fields
	internal static readonly XPathNavigatorKeyComparer comparer; // 0x0
	internal static readonly char[] NodeTypeLetter; // 0x8
	internal static readonly char[] UniqueIdTbl; // 0x10
	internal static readonly int[] ContentKindMasks; // 0x18

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override object TypedValue { get; }
	public override Type ValueType { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public abstract XmlNameTable NameTable { get; }
	public abstract XPathNodeType NodeType { get; }
	public abstract string LocalName { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public virtual object UnderlyingObject { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }

	// Methods

	// RVA: 0x1C736E0 Offset: 0x1C6F6E0 VA: 0x1C736E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C736EC Offset: 0x1C6F6EC VA: 0x1C736EC Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x1C73874 Offset: 0x1C6F874 VA: 0x1C73874 Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x1C73B48 Offset: 0x1C6FB48 VA: 0x1C73B48 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x1C73D2C Offset: 0x1C6FD2C VA: 0x1C73D2C Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x1C73FE8 Offset: 0x1C6FFE8 VA: 0x1C73FE8 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x1C742AC Offset: 0x1C702AC VA: 0x1C742AC Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x1C74570 Offset: 0x1C70570 VA: 0x1C74570 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x1C74834 Offset: 0x1C70834 VA: 0x1C74834 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x1C74AF8 Offset: 0x1C70AF8 VA: 0x1C74AF8 Slot: 14
	public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1C74DDC Offset: 0x1C70DDC VA: 0x1C74DDC Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract XmlNameTable get_NameTable();

	// RVA: 0x1C74DEC Offset: 0x1C70DEC VA: 0x1C74DEC Slot: 20
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x1C74F84 Offset: 0x1C70F84 VA: 0x1C74F84 Slot: 21
	public virtual string LookupPrefix(string namespaceURI) { }

	// RVA: 0x1C75170 Offset: 0x1C71170 VA: 0x1C75170 Slot: 22
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract XPathNavigator Clone();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract XPathNodeType get_NodeType();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract string get_Prefix();

	// RVA: 0x1C75384 Offset: 0x1C71384 VA: 0x1C75384 Slot: 28
	public virtual object get_UnderlyingObject() { }

	// RVA: 0x1C7538C Offset: 0x1C7138C VA: 0x1C7538C Slot: 29
	public virtual bool MoveToNamespace(string name) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool MoveToParent();

	// RVA: -1 Offset: -1 Slot: 33
	public abstract bool IsSamePosition(XPathNavigator other);

	// RVA: 0x1C7542C Offset: 0x1C7142C VA: 0x1C7542C Slot: 34
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1C75474 Offset: 0x1C71474 VA: 0x1C75474
	internal static bool IsText(XPathNodeType type) { }

	// RVA: 0x1C75484 Offset: 0x1C71484 VA: 0x1C75484
	protected void .ctor() { }

	// RVA: 0x1C7548C Offset: 0x1C7148C VA: 0x1C7548C
	private static void .cctor() { }
}

// Namespace: System.Xml.XPath
internal class XPathNavigatorKeyComparer : IEqualityComparer // TypeDefIndex: 3278
{
	// Methods

	// RVA: 0x1C7561C Offset: 0x1C7161C VA: 0x1C7561C Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object obj1, object obj2) { }

	// RVA: 0x1C756F8 Offset: 0x1C716F8 VA: 0x1C756F8 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x1C75614 Offset: 0x1C71614 VA: 0x1C75614
	public void .ctor() { }
}

// Namespace: System.Xml.XPath
public enum XPathNodeType // TypeDefIndex: 3279
{
	// Fields
	public int value__; // 0x0
	public const XPathNodeType Root = 0;
	public const XPathNodeType Element = 1;
	public const XPathNodeType Attribute = 2;
	public const XPathNodeType Namespace = 3;
	public const XPathNodeType Text = 4;
	public const XPathNodeType SignificantWhitespace = 5;
	public const XPathNodeType Whitespace = 6;
	public const XPathNodeType ProcessingInstruction = 7;
	public const XPathNodeType Comment = 8;
	public const XPathNodeType All = 9;
}
