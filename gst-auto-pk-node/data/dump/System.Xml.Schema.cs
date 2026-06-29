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

// Namespace: System.Xml.Schema
internal class AxisElement // TypeDefIndex: 3370
{
	// Fields
	internal DoubleLinkAxis curNode; // 0x10
	internal int rootDepth; // 0x18
	internal int curDepth; // 0x1C
	internal bool isMatch; // 0x20

	// Properties
	internal DoubleLinkAxis CurNode { get; }

	// Methods

	// RVA: 0x1CA23F8 Offset: 0x1C9E3F8 VA: 0x1CA23F8
	internal DoubleLinkAxis get_CurNode() { }

	// RVA: 0x1CA2400 Offset: 0x1C9E400 VA: 0x1CA2400
	internal void .ctor(DoubleLinkAxis node, int depth) { }

	// RVA: 0x1CA2440 Offset: 0x1C9E440 VA: 0x1CA2440
	internal void SetDepth(int depth) { }

	// RVA: 0x1CA2448 Offset: 0x1C9E448 VA: 0x1CA2448
	internal void MoveToParent(int depth, ForwardAxis parent) { }

	// RVA: 0x1CA2574 Offset: 0x1C9E574 VA: 0x1CA2574
	internal bool MoveToChild(string name, string URN, int depth, ForwardAxis parent) { }
}

// Namespace: System.Xml.Schema
internal class AxisStack // TypeDefIndex: 3371
{
	// Fields
	private ArrayList _stack; // 0x10
	private ForwardAxis _subtree; // 0x18
	private ActiveAxis _parent; // 0x20

	// Properties
	internal ForwardAxis Subtree { get; }
	internal int Length { get; }

	// Methods

	// RVA: 0x1CA2794 Offset: 0x1C9E794 VA: 0x1CA2794
	internal ForwardAxis get_Subtree() { }

	// RVA: 0x1CA279C Offset: 0x1C9E79C VA: 0x1CA279C
	internal int get_Length() { }

	// RVA: 0x1CA27BC Offset: 0x1C9E7BC VA: 0x1CA27BC
	public void .ctor(ForwardAxis faxis, ActiveAxis parent) { }

	// RVA: 0x1CA2884 Offset: 0x1C9E884 VA: 0x1CA2884
	internal void Push(int depth) { }

	// RVA: 0x1CA2924 Offset: 0x1C9E924 VA: 0x1CA2924
	internal void Pop() { }

	// RVA: 0x1CA2718 Offset: 0x1C9E718 VA: 0x1CA2718
	internal static bool Equal(string thisname, string thisURN, string name, string URN) { }

	// RVA: 0x1CA2964 Offset: 0x1C9E964 VA: 0x1CA2964
	internal void MoveToParent(string name, string URN, int depth) { }

	// RVA: 0x1CA2AA8 Offset: 0x1C9EAA8 VA: 0x1CA2AA8
	internal bool MoveToChild(string name, string URN, int depth) { }

	// RVA: 0x1CA2BE8 Offset: 0x1C9EBE8 VA: 0x1CA2BE8
	internal bool MoveToAttribute(string name, string URN, int depth) { }
}

// Namespace: System.Xml.Schema
internal class ActiveAxis // TypeDefIndex: 3372
{
	// Fields
	private int _currentDepth; // 0x10
	private bool _isActive; // 0x14
	private Asttree _axisTree; // 0x18
	private ArrayList _axisStack; // 0x20

	// Properties
	public int CurrentDepth { get; }

	// Methods

	// RVA: 0x1CA2D54 Offset: 0x1C9ED54 VA: 0x1CA2D54
	public int get_CurrentDepth() { }

	// RVA: 0x1CA2D5C Offset: 0x1C9ED5C VA: 0x1CA2D5C
	internal void Reactivate() { }

	// RVA: 0x1CA2D70 Offset: 0x1C9ED70 VA: 0x1CA2D70
	internal void .ctor(Asttree axisTree) { }

	// RVA: 0x1CA2F30 Offset: 0x1C9EF30 VA: 0x1CA2F30
	public bool MoveToStartElement(string localname, string URN) { }

	// RVA: 0x1CA3070 Offset: 0x1C9F070 VA: 0x1CA3070 Slot: 4
	public virtual bool EndElement(string localname, string URN) { }

	// RVA: 0x1CA3180 Offset: 0x1C9F180 VA: 0x1CA3180
	public bool MoveToAttribute(string localname, string URN) { }
}

// Namespace: System.Xml.Schema
internal class DoubleLinkAxis : Axis // TypeDefIndex: 3373
{
	// Fields
	internal Axis next; // 0x40

	// Properties
	internal Axis Next { get; set; }

	// Methods

	// RVA: 0x1CA328C Offset: 0x1C9F28C VA: 0x1CA328C
	internal Axis get_Next() { }

	// RVA: 0x1CA3294 Offset: 0x1C9F294 VA: 0x1CA3294
	internal void set_Next(Axis value) { }

	// RVA: 0x1CA329C Offset: 0x1C9F29C VA: 0x1CA329C
	internal void .ctor(Axis axis, DoubleLinkAxis inputaxis) { }

	// RVA: 0x1CA332C Offset: 0x1C9F32C VA: 0x1CA332C
	internal static DoubleLinkAxis ConvertTree(Axis axis) { }
}

// Namespace: System.Xml.Schema
internal class ForwardAxis // TypeDefIndex: 3374
{
	// Fields
	private DoubleLinkAxis _topNode; // 0x10
	private DoubleLinkAxis _rootNode; // 0x18
	private bool _isAttribute; // 0x20
	private bool _isDss; // 0x21
	private bool _isSelfAxis; // 0x22

	// Properties
	internal DoubleLinkAxis RootNode { get; }
	internal DoubleLinkAxis TopNode { get; }
	internal bool IsAttribute { get; }
	internal bool IsDss { get; }
	internal bool IsSelfAxis { get; }

	// Methods

	// RVA: 0x1CA33EC Offset: 0x1C9F3EC VA: 0x1CA33EC
	internal DoubleLinkAxis get_RootNode() { }

	// RVA: 0x1CA33F4 Offset: 0x1C9F3F4 VA: 0x1CA33F4
	internal DoubleLinkAxis get_TopNode() { }

	// RVA: 0x1CA33FC Offset: 0x1C9F3FC VA: 0x1CA33FC
	internal bool get_IsAttribute() { }

	// RVA: 0x1CA3404 Offset: 0x1C9F404 VA: 0x1CA3404
	internal bool get_IsDss() { }

	// RVA: 0x1CA340C Offset: 0x1C9F40C VA: 0x1CA340C
	internal bool get_IsSelfAxis() { }

	// RVA: 0x1CA3414 Offset: 0x1C9F414 VA: 0x1CA3414
	public void .ctor(DoubleLinkAxis axis, bool isdesorself) { }
}

// Namespace: System.Xml.Schema
internal class Asttree // TypeDefIndex: 3375
{
	// Fields
	private ArrayList _fAxisArray; // 0x10
	private string _xpathexpr; // 0x18
	private bool _isField; // 0x20
	private XmlNamespaceManager _nsmgr; // 0x28

	// Properties
	internal ArrayList SubtreeArray { get; }

	// Methods

	// RVA: 0x1CA35BC Offset: 0x1C9F5BC VA: 0x1CA35BC
	internal ArrayList get_SubtreeArray() { }

	// RVA: 0x1CA35C4 Offset: 0x1C9F5C4 VA: 0x1CA35C4
	public void .ctor(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x1CA3E10 Offset: 0x1C9FE10 VA: 0x1CA3E10
	private static bool IsNameTest(Axis ast) { }

	// RVA: 0x1CA26E8 Offset: 0x1C9E6E8 VA: 0x1CA26E8
	internal static bool IsAttribute(Axis ast) { }

	// RVA: 0x1CA3E40 Offset: 0x1C9FE40 VA: 0x1CA3E40
	private static bool IsDescendantOrSelf(Axis ast) { }

	// RVA: 0x1CA3580 Offset: 0x1C9F580 VA: 0x1CA3580
	internal static bool IsSelf(Axis ast) { }

	// RVA: 0x1CA362C Offset: 0x1C9F62C VA: 0x1CA362C
	public void CompileXPath(string xPath, bool isField, XmlNamespaceManager nsmgr) { }

	// RVA: 0x1CA3E7C Offset: 0x1C9FE7C VA: 0x1CA3E7C
	private void SetURN(Axis axis, XmlNamespaceManager nsmgr) { }
}

// Namespace: System.Xml.Schema
internal class AutoValidator : BaseValidator // TypeDefIndex: 3376
{
	// Properties
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x1CA3F9C Offset: 0x1C9FF9C VA: 0x1CA3F9C
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1CA4124 Offset: 0x1CA0124 VA: 0x1CA4124 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1CA412C Offset: 0x1CA012C VA: 0x1CA412C Slot: 5
	public override void Validate() { }

	// RVA: 0x1CA4560 Offset: 0x1CA0560 VA: 0x1CA4560 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x1CA4564 Offset: 0x1CA0564 VA: 0x1CA4564 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1CA4214 Offset: 0x1CA0214 VA: 0x1CA4214
	private ValidationType DetectValidationType() { }
}

// Namespace: System.Xml.Schema
internal class BaseProcessor // TypeDefIndex: 3377
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private ValidationEventHandler eventHandler; // 0x20
	private XmlSchemaCompilationSettings compilationSettings; // 0x28
	private int errorCount; // 0x30
	private string NsXml; // 0x38

	// Properties
	protected XmlNameTable NameTable { get; }
	protected SchemaNames SchemaNames { get; }
	protected ValidationEventHandler EventHandler { get; }
	protected XmlSchemaCompilationSettings CompilationSettings { get; }
	protected bool HasErrors { get; }

	// Methods

	// RVA: 0x1CA4604 Offset: 0x1CA0604 VA: 0x1CA4604
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x1CA4688 Offset: 0x1CA0688 VA: 0x1CA4688
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x1CA475C Offset: 0x1CA075C VA: 0x1CA475C
	protected XmlNameTable get_NameTable() { }

	// RVA: 0x1CA4764 Offset: 0x1CA0764 VA: 0x1CA4764
	protected SchemaNames get_SchemaNames() { }

	// RVA: 0x1CA47E8 Offset: 0x1CA07E8 VA: 0x1CA47E8
	protected ValidationEventHandler get_EventHandler() { }

	// RVA: 0x1CA47F0 Offset: 0x1CA07F0 VA: 0x1CA47F0
	protected XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x1CA47F8 Offset: 0x1CA07F8 VA: 0x1CA47F8
	protected bool get_HasErrors() { }

	// RVA: 0x1CA4808 Offset: 0x1CA0808 VA: 0x1CA4808
	protected void AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x1CA4C68 Offset: 0x1CA0C68 VA: 0x1CA4C68
	private bool IsValidAttributeGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x1CA4EC0 Offset: 0x1CA0EC0 VA: 0x1CA4EC0
	private bool IsValidGroupRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x1CA4D94 Offset: 0x1CA0D94 VA: 0x1CA4D94
	private bool IsValidTypeRedefine(XmlSchemaObject existingObject, XmlSchemaObject item, XmlSchemaObjectTable table) { }

	// RVA: 0x1CA5060 Offset: 0x1CA1060 VA: 0x1CA5060
	protected void SendValidationEvent(string code, XmlSchemaObject source) { }

	// RVA: 0x1CA4FD8 Offset: 0x1CA0FD8 VA: 0x1CA4FD8
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source) { }

	// RVA: 0x1CA51A0 Offset: 0x1CA11A0 VA: 0x1CA51A0
	protected void SendValidationEvent(string code, string msg1, string msg2, XmlSchemaObject source) { }

	// RVA: 0x1CA5294 Offset: 0x1CA1294 VA: 0x1CA5294
	protected void SendValidationEvent(string code, string[] args, Exception innerException, XmlSchemaObject source) { }

	// RVA: 0x1CA5350 Offset: 0x1CA1350 VA: 0x1CA5350
	protected void SendValidationEvent(string code, string msg1, string msg2, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1CA545C Offset: 0x1CA145C VA: 0x1CA545C
	protected void SendValidationEvent(string code, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x1CA54E0 Offset: 0x1CA14E0 VA: 0x1CA54E0
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x1CA54E8 Offset: 0x1CA14E8 VA: 0x1CA54E8
	protected void SendValidationEvent(string code, string msg, XmlSchemaObject source, XmlSeverityType severity) { }

	// RVA: 0x1CA50D8 Offset: 0x1CA10D8 VA: 0x1CA50D8
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x1CA5574 Offset: 0x1CA1574 VA: 0x1CA5574
	protected void SendValidationEventNoThrow(XmlSchemaException e, XmlSeverityType severity) { }
}

// Namespace: System.Xml.Schema
internal class BaseValidator // TypeDefIndex: 3378
{
	// Fields
	private XmlSchemaCollection schemaCollection; // 0x10
	private IValidationEventHandling eventHandling; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaNames schemaNames; // 0x28
	private PositionInfo positionInfo; // 0x30
	private XmlResolver xmlResolver; // 0x38
	private Uri baseUri; // 0x40
	protected SchemaInfo schemaInfo; // 0x48
	protected XmlValidatingReaderImpl reader; // 0x50
	protected XmlQualifiedName elementName; // 0x58
	protected ValidationState context; // 0x60
	protected StringBuilder textValue; // 0x68
	protected string textString; // 0x70
	protected bool hasSibling; // 0x78
	protected bool checkDatatype; // 0x79

	// Properties
	public XmlValidatingReaderImpl Reader { get; }
	public XmlSchemaCollection SchemaCollection { get; }
	public XmlNameTable NameTable { get; }
	public SchemaNames SchemaNames { get; }
	public PositionInfo PositionInfo { get; }
	public XmlResolver XmlResolver { get; set; }
	public Uri BaseUri { get; set; }
	public ValidationEventHandler EventHandler { get; }
	public SchemaInfo SchemaInfo { get; }
	public IDtdInfo DtdInfo { set; }
	public virtual bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x1CA561C Offset: 0x1CA161C VA: 0x1CA561C
	public void .ctor(BaseValidator other) { }

	// RVA: 0x1CA402C Offset: 0x1CA002C VA: 0x1CA402C
	public void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1CA56D4 Offset: 0x1CA16D4 VA: 0x1CA56D4
	public XmlValidatingReaderImpl get_Reader() { }

	// RVA: 0x1CA56DC Offset: 0x1CA16DC VA: 0x1CA56DC
	public XmlSchemaCollection get_SchemaCollection() { }

	// RVA: 0x1CA56E4 Offset: 0x1CA16E4 VA: 0x1CA56E4
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1CA456C Offset: 0x1CA056C VA: 0x1CA456C
	public SchemaNames get_SchemaNames() { }

	// RVA: 0x1CA56EC Offset: 0x1CA16EC VA: 0x1CA56EC
	public PositionInfo get_PositionInfo() { }

	// RVA: 0x1CA56F4 Offset: 0x1CA16F4 VA: 0x1CA56F4
	public XmlResolver get_XmlResolver() { }

	// RVA: 0x1CA56FC Offset: 0x1CA16FC VA: 0x1CA56FC
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1CA5704 Offset: 0x1CA1704 VA: 0x1CA5704
	public Uri get_BaseUri() { }

	// RVA: 0x1CA570C Offset: 0x1CA170C VA: 0x1CA570C
	public void set_BaseUri(Uri value) { }

	// RVA: 0x1CA5714 Offset: 0x1CA1714 VA: 0x1CA5714
	public ValidationEventHandler get_EventHandler() { }

	// RVA: 0x1CA57E4 Offset: 0x1CA17E4 VA: 0x1CA57E4
	public SchemaInfo get_SchemaInfo() { }

	// RVA: 0x1CA57EC Offset: 0x1CA17EC VA: 0x1CA57EC
	public void set_DtdInfo(IDtdInfo value) { }

	// RVA: 0x1CA58CC Offset: 0x1CA18CC VA: 0x1CA58CC Slot: 4
	public virtual bool get_PreserveWhitespace() { }

	// RVA: 0x1CA58D4 Offset: 0x1CA18D4 VA: 0x1CA58D4 Slot: 5
	public virtual void Validate() { }

	// RVA: 0x1CA58D8 Offset: 0x1CA18D8 VA: 0x1CA58D8 Slot: 6
	public virtual void CompleteValidation() { }

	// RVA: 0x1CA58DC Offset: 0x1CA18DC VA: 0x1CA58DC Slot: 7
	public virtual object FindId(string name) { }

	// RVA: 0x1CA58E4 Offset: 0x1CA18E4 VA: 0x1CA58E4
	public void ValidateText() { }

	// RVA: 0x1CA5DAC Offset: 0x1CA1DAC VA: 0x1CA5DAC
	public void ValidateWhitespace() { }

	// RVA: 0x1CA5D34 Offset: 0x1CA1D34 VA: 0x1CA5D34
	private void SaveTextValue(string value) { }

	// RVA: 0x1CA5EDC Offset: 0x1CA1EDC VA: 0x1CA5EDC
	protected void SendValidationEvent(string code) { }

	// RVA: 0x1CA5C4C Offset: 0x1CA1C4C VA: 0x1CA5C4C
	protected void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x1CA5B64 Offset: 0x1CA1B64 VA: 0x1CA5B64
	protected void SendValidationEvent(string code, string arg) { }

	// RVA: 0x1CA5EF4 Offset: 0x1CA1EF4 VA: 0x1CA5EF4
	protected void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x1CA5FE0 Offset: 0x1CA1FE0 VA: 0x1CA5FE0
	protected void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x1CA60D4 Offset: 0x1CA20D4 VA: 0x1CA60D4
	protected void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x1CA5EFC Offset: 0x1CA1EFC VA: 0x1CA5EFC
	protected void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x1CA61C8 Offset: 0x1CA21C8 VA: 0x1CA61C8
	protected static void ProcessEntity(SchemaInfo sinfo, string name, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNumber, int linePosition) { }

	// RVA: 0x1CA6388 Offset: 0x1CA2388 VA: 0x1CA6388
	protected static void ProcessEntity(SchemaInfo sinfo, string name, IValidationEventHandling eventHandling, string baseUriStr, int lineNumber, int linePosition) { }

	// RVA: 0x1CA657C Offset: 0x1CA257C VA: 0x1CA657C
	public static BaseValidator CreateInstance(ValidationType valType, XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
internal sealed class BitSet // TypeDefIndex: 3379
{
	// Fields
	private int count; // 0x10
	private uint[] bits; // 0x18

	// Properties
	public int Count { get; }
	public bool Item { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x1CA6708 Offset: 0x1CA2708 VA: 0x1CA6708
	private void .ctor() { }

	// RVA: 0x1CA6710 Offset: 0x1CA2710 VA: 0x1CA6710
	public void .ctor(int count) { }

	// RVA: 0x1CA6790 Offset: 0x1CA2790 VA: 0x1CA6790
	public int get_Count() { }

	// RVA: 0x1CA6798 Offset: 0x1CA2798 VA: 0x1CA6798
	public bool get_Item(int index) { }

	// RVA: 0x1CA67EC Offset: 0x1CA27EC VA: 0x1CA67EC
	public void Clear() { }

	// RVA: 0x1CA6840 Offset: 0x1CA2840 VA: 0x1CA6840
	public void Set(int index) { }

	// RVA: 0x1CA679C Offset: 0x1CA279C VA: 0x1CA679C
	public bool Get(int index) { }

	// RVA: 0x1CA6944 Offset: 0x1CA2944 VA: 0x1CA6944
	public int NextSet(int startFrom) { }

	// RVA: 0x1CA69DC Offset: 0x1CA29DC VA: 0x1CA69DC
	public void And(BitSet other) { }

	// RVA: 0x1CA6AA0 Offset: 0x1CA2AA0 VA: 0x1CA6AA0
	public void Or(BitSet other) { }

	// RVA: 0x1CA6B44 Offset: 0x1CA2B44 VA: 0x1CA6B44 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CA6B7C Offset: 0x1CA2B7C VA: 0x1CA6B7C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1CA6CD8 Offset: 0x1CA2CD8 VA: 0x1CA6CD8
	public BitSet Clone() { }

	// RVA: 0x1CA6DD4 Offset: 0x1CA2DD4 VA: 0x1CA6DD4
	public bool get_IsEmpty() { }

	// RVA: 0x1CA6E34 Offset: 0x1CA2E34 VA: 0x1CA6E34
	public bool Intersects(BitSet other) { }

	// RVA: 0x1CA6788 Offset: 0x1CA2788 VA: 0x1CA6788
	private int Subscript(int bitIndex) { }

	// RVA: 0x1CA689C Offset: 0x1CA289C VA: 0x1CA689C
	private void EnsureLength(int nRequiredLength) { }
}

// Namespace: System.Xml.Schema
internal class ChameleonKey // TypeDefIndex: 3380
{
	// Fields
	internal string targetNS; // 0x10
	internal Uri chameleonLocation; // 0x18
	internal XmlSchema originalSchema; // 0x20
	private int hashCode; // 0x28

	// Methods

	// RVA: 0x1CA6F14 Offset: 0x1CA2F14 VA: 0x1CA6F14
	public void .ctor(string ns, XmlSchema originalSchema) { }

	// RVA: 0x1CA6F9C Offset: 0x1CA2F9C VA: 0x1CA6F9C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CA7020 Offset: 0x1CA3020 VA: 0x1CA7020 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: 
public enum CompiledIdentityConstraint.ConstraintRole // TypeDefIndex: 3381
{
	// Fields
	public int value__; // 0x0
	public const CompiledIdentityConstraint.ConstraintRole Unique = 0;
	public const CompiledIdentityConstraint.ConstraintRole Key = 1;
	public const CompiledIdentityConstraint.ConstraintRole Keyref = 2;
}

// Namespace: System.Xml.Schema
internal class CompiledIdentityConstraint // TypeDefIndex: 3382
{
	// Fields
	internal XmlQualifiedName name; // 0x10
	private CompiledIdentityConstraint.ConstraintRole role; // 0x18
	private Asttree selector; // 0x20
	private Asttree[] fields; // 0x28
	internal XmlQualifiedName refer; // 0x30
	public static readonly CompiledIdentityConstraint Empty; // 0x0

	// Properties
	public CompiledIdentityConstraint.ConstraintRole Role { get; }
	public Asttree Selector { get; }
	public Asttree[] Fields { get; }

	// Methods

	// RVA: 0x1CA70F4 Offset: 0x1CA30F4 VA: 0x1CA70F4
	public CompiledIdentityConstraint.ConstraintRole get_Role() { }

	// RVA: 0x1CA70FC Offset: 0x1CA30FC VA: 0x1CA70FC
	public Asttree get_Selector() { }

	// RVA: 0x1CA7104 Offset: 0x1CA3104 VA: 0x1CA7104
	public Asttree[] get_Fields() { }

	// RVA: 0x1CA710C Offset: 0x1CA310C VA: 0x1CA710C
	private void .ctor() { }

	// RVA: 0x1CA7194 Offset: 0x1CA3194 VA: 0x1CA7194
	public void .ctor(XmlSchemaIdentityConstraint constraint, XmlNamespaceManager nsmgr) { }

	// RVA: 0x1CA7680 Offset: 0x1CA3680 VA: 0x1CA7680
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class ConstraintStruct // TypeDefIndex: 3383
{
	// Fields
	internal CompiledIdentityConstraint constraint; // 0x10
	internal SelectorActiveAxis axisSelector; // 0x18
	internal ArrayList axisFields; // 0x20
	internal Hashtable qualifiedTable; // 0x28
	internal Hashtable keyrefTable; // 0x30
	private int tableDim; // 0x38

	// Properties
	internal int TableDim { get; }

	// Methods

	// RVA: 0x1CA76E4 Offset: 0x1CA36E4 VA: 0x1CA76E4
	internal int get_TableDim() { }

	// RVA: 0x1CA76EC Offset: 0x1CA36EC VA: 0x1CA76EC
	internal void .ctor(CompiledIdentityConstraint constraint) { }
}

// Namespace: System.Xml.Schema
internal class LocatedActiveAxis : ActiveAxis // TypeDefIndex: 3384
{
	// Fields
	private int column; // 0x28
	internal bool isMatched; // 0x2C
	internal KeySequence Ks; // 0x30

	// Properties
	internal int Column { get; }

	// Methods

	// RVA: 0x1CA78B8 Offset: 0x1CA38B8 VA: 0x1CA78B8
	internal int get_Column() { }

	// RVA: 0x1CA78C0 Offset: 0x1CA38C0 VA: 0x1CA78C0
	internal void .ctor(Asttree astfield, KeySequence ks, int column) { }

	// RVA: 0x1CA78FC Offset: 0x1CA38FC VA: 0x1CA78FC
	internal void Reactivate(KeySequence ks) { }
}

// Namespace: System.Xml.Schema
internal class SelectorActiveAxis : ActiveAxis // TypeDefIndex: 3385
{
	// Fields
	private ConstraintStruct cs; // 0x28
	private ArrayList KSs; // 0x30
	private int KSpointer; // 0x38

	// Properties
	public int lastDepth { get; }

	// Methods

	// RVA: 0x1CA7914 Offset: 0x1CA3914 VA: 0x1CA7914
	public int get_lastDepth() { }

	// RVA: 0x1CA782C Offset: 0x1CA382C VA: 0x1CA782C
	public void .ctor(Asttree axisTree, ConstraintStruct cs) { }

	// RVA: 0x1CA79BC Offset: 0x1CA39BC VA: 0x1CA79BC Slot: 4
	public override bool EndElement(string localname, string URN) { }

	// RVA: 0x1CA7A04 Offset: 0x1CA3A04 VA: 0x1CA7A04
	public int PushKS(int errline, int errcol) { }

	// RVA: 0x1CA7E20 Offset: 0x1CA3E20 VA: 0x1CA7E20
	public KeySequence PopKS() { }
}

// Namespace: System.Xml.Schema
internal class KSStruct // TypeDefIndex: 3386
{
	// Fields
	public int depth; // 0x10
	public KeySequence ks; // 0x18
	public LocatedActiveAxis[] fields; // 0x20

	// Methods

	// RVA: 0x1CA7D9C Offset: 0x1CA3D9C VA: 0x1CA7D9C
	public void .ctor(KeySequence ks, int dim) { }
}

// Namespace: 
private class TypedObject.DecimalStruct // TypeDefIndex: 3387
{
	// Fields
	private bool isDecimal; // 0x10
	private Decimal[] dvalue; // 0x18

	// Properties
	public bool IsDecimal { get; set; }
	public Decimal[] Dvalue { get; }

	// Methods

	// RVA: 0x1CA8784 Offset: 0x1CA4784 VA: 0x1CA8784
	public bool get_IsDecimal() { }

	// RVA: 0x1CA878C Offset: 0x1CA478C VA: 0x1CA878C
	public void set_IsDecimal(bool value) { }

	// RVA: 0x1CA8794 Offset: 0x1CA4794 VA: 0x1CA8794
	public Decimal[] get_Dvalue() { }

	// RVA: 0x1CA83A8 Offset: 0x1CA43A8 VA: 0x1CA83A8
	public void .ctor() { }

	// RVA: 0x1CA8338 Offset: 0x1CA4338 VA: 0x1CA8338
	public void .ctor(int dim) { }
}

// Namespace: System.Xml.Schema
internal class TypedObject // TypeDefIndex: 3388
{
	// Fields
	private TypedObject.DecimalStruct dstruct; // 0x10
	private object ovalue; // 0x18
	private string svalue; // 0x20
	private XmlSchemaDatatype xsdtype; // 0x28
	private int dim; // 0x30
	private bool isList; // 0x34

	// Properties
	public int Dim { get; }
	public bool IsList { get; }
	public bool IsDecimal { get; }
	public Decimal[] Dvalue { get; }
	public object Value { get; }
	public XmlSchemaDatatype Type { get; }

	// Methods

	// RVA: 0x1CA7EC0 Offset: 0x1CA3EC0 VA: 0x1CA7EC0
	public int get_Dim() { }

	// RVA: 0x1CA7EC8 Offset: 0x1CA3EC8 VA: 0x1CA7EC8
	public bool get_IsList() { }

	// RVA: 0x1CA7ED0 Offset: 0x1CA3ED0 VA: 0x1CA7ED0
	public bool get_IsDecimal() { }

	// RVA: 0x1CA7EE8 Offset: 0x1CA3EE8 VA: 0x1CA7EE8
	public Decimal[] get_Dvalue() { }

	// RVA: 0x1CA7F00 Offset: 0x1CA3F00 VA: 0x1CA7F00
	public object get_Value() { }

	// RVA: 0x1CA7F08 Offset: 0x1CA3F08 VA: 0x1CA7F08
	public XmlSchemaDatatype get_Type() { }

	// RVA: 0x1CA7F10 Offset: 0x1CA3F10 VA: 0x1CA7F10
	public void .ctor(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	// RVA: 0x1CA8088 Offset: 0x1CA4088 VA: 0x1CA8088 Slot: 3
	public override string ToString() { }

	// RVA: 0x1CA8090 Offset: 0x1CA4090 VA: 0x1CA8090
	public void SetDecimal() { }

	// RVA: 0x1CA840C Offset: 0x1CA440C VA: 0x1CA840C
	private bool ListDValueEquals(TypedObject other) { }

	// RVA: 0x1CA8520 Offset: 0x1CA4520 VA: 0x1CA8520
	public bool Equals(TypedObject other) { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
internal class KeySequence // TypeDefIndex: 3389
{
	// Fields
	private TypedObject[] ks; // 0x10
	private int dim; // 0x18
	private int hashcode; // 0x1C
	private int posline; // 0x20
	private int poscol; // 0x24

	// Properties
	public int PosLine { get; }
	public int PosCol { get; }
	public object Item { get; set; }

	// Methods

	// RVA: 0x1CA7D08 Offset: 0x1CA3D08 VA: 0x1CA7D08
	internal void .ctor(int dim, int line, int col) { }

	// RVA: 0x1CA879C Offset: 0x1CA479C VA: 0x1CA879C
	public int get_PosLine() { }

	// RVA: 0x1CA87A4 Offset: 0x1CA47A4 VA: 0x1CA87A4
	public int get_PosCol() { }

	// RVA: 0x1CA87AC Offset: 0x1CA47AC VA: 0x1CA87AC
	public object get_Item(int index) { }

	// RVA: 0x1CA87DC Offset: 0x1CA47DC VA: 0x1CA87DC
	public void set_Item(int index, object value) { }

	// RVA: 0x1CA88D8 Offset: 0x1CA48D8 VA: 0x1CA88D8
	internal bool IsQualified() { }

	// RVA: 0x1CA8940 Offset: 0x1CA4940 VA: 0x1CA8940 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CA8CA0 Offset: 0x1CA4CA0 VA: 0x1CA8CA0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1CA8D90 Offset: 0x1CA4D90 VA: 0x1CA8D90 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Xml.Schema
internal class UpaException : Exception // TypeDefIndex: 3390
{
	// Fields
	private object particle1; // 0x90
	private object particle2; // 0x98

	// Properties
	public object Particle1 { get; }
	public object Particle2 { get; }

	// Methods

	// RVA: 0x1CA8EBC Offset: 0x1CA4EBC VA: 0x1CA8EBC
	public void .ctor(object particle1, object particle2) { }

	// RVA: 0x1CA8F44 Offset: 0x1CA4F44 VA: 0x1CA8F44
	public object get_Particle1() { }

	// RVA: 0x1CA8F4C Offset: 0x1CA4F4C VA: 0x1CA8F4C
	public object get_Particle2() { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
internal class SymbolsDictionary // TypeDefIndex: 3391
{
	// Fields
	private int last; // 0x10
	private Hashtable names; // 0x18
	private Hashtable wildcards; // 0x20
	private ArrayList particles; // 0x28
	private object particleLast; // 0x30
	private bool isUpaEnforced; // 0x38

	// Properties
	public int Count { get; }
	public bool IsUpaEnforced { get; set; }
	public int Item { get; }

	// Methods

	// RVA: 0x1CA8F54 Offset: 0x1CA4F54 VA: 0x1CA8F54
	public void .ctor() { }

	// RVA: 0x1CA9008 Offset: 0x1CA5008 VA: 0x1CA9008
	public int get_Count() { }

	// RVA: 0x1CA9014 Offset: 0x1CA5014 VA: 0x1CA9014
	public bool get_IsUpaEnforced() { }

	// RVA: 0x1CA901C Offset: 0x1CA501C VA: 0x1CA901C
	public void set_IsUpaEnforced(bool value) { }

	// RVA: 0x1CA9024 Offset: 0x1CA5024 VA: 0x1CA9024
	public int AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x1CA912C Offset: 0x1CA512C VA: 0x1CA912C
	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	// RVA: 0x1CA94A0 Offset: 0x1CA54A0 VA: 0x1CA94A0
	private void AddWildcard(string wildcard, object particle) { }

	// RVA: 0x1CA9614 Offset: 0x1CA5614 VA: 0x1CA9614
	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	// RVA: 0x1CA9D2C Offset: 0x1CA5D2C VA: 0x1CA9D2C
	public int get_Item(XmlQualifiedName name) { }

	// RVA: 0x1CA9DC0 Offset: 0x1CA5DC0 VA: 0x1CA9DC0
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x1CA9DF0 Offset: 0x1CA5DF0 VA: 0x1CA9DF0
	public object GetParticle(int symbol) { }

	// RVA: 0x1CA9E24 Offset: 0x1CA5E24 VA: 0x1CA9E24
	public string NameOf(int symbol) { }
}

// Namespace: System.Xml.Schema
internal struct Position // TypeDefIndex: 3392
{
	// Fields
	public int symbol; // 0x0
	public object particle; // 0x8

	// Methods

	// RVA: 0x1CAA460 Offset: 0x1CA6460 VA: 0x1CAA460
	public void .ctor(int symbol, object particle) { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
internal class Positions // TypeDefIndex: 3393
{
	// Fields
	private ArrayList positions; // 0x10

	// Properties
	public Position Item { get; }
	public int Count { get; }

	// Methods

	// RVA: 0x1CAA470 Offset: 0x1CA6470 VA: 0x1CAA470
	public int Add(int symbol, object particle) { }

	// RVA: 0x1CAA518 Offset: 0x1CA6518 VA: 0x1CAA518
	public Position get_Item(int pos) { }

	// RVA: 0x1CAA5A8 Offset: 0x1CA65A8 VA: 0x1CAA5A8
	public int get_Count() { }

	// RVA: 0x1CAA5C8 Offset: 0x1CA65C8 VA: 0x1CAA5C8
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal abstract class SyntaxTreeNode // TypeDefIndex: 3394
{
	// Properties
	public abstract bool IsNullable { get; }
	public virtual bool IsRangeNode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsNullable();

	// RVA: 0x1CAA634 Offset: 0x1CA6634 VA: 0x1CAA634 Slot: 7
	public virtual bool get_IsRangeNode() { }

	// RVA: 0x1CAA63C Offset: 0x1CA663C VA: 0x1CAA63C
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class LeafNode : SyntaxTreeNode // TypeDefIndex: 3395
{
	// Fields
	private int pos; // 0x10

	// Properties
	public int Pos { get; set; }
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x1CAA644 Offset: 0x1CA6644 VA: 0x1CAA644
	public void .ctor(int pos) { }

	// RVA: 0x1CAA66C Offset: 0x1CA666C VA: 0x1CAA66C
	public int get_Pos() { }

	// RVA: 0x1CAA674 Offset: 0x1CA6674 VA: 0x1CAA674
	public void set_Pos(int value) { }

	// RVA: 0x1CAA67C Offset: 0x1CA667C VA: 0x1CAA67C Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1CAA680 Offset: 0x1CA6680 VA: 0x1CAA680 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1CAA6C0 Offset: 0x1CA66C0 VA: 0x1CAA6C0 Slot: 6
	public override bool get_IsNullable() { }
}

// Namespace: System.Xml.Schema
internal class NamespaceListNode : SyntaxTreeNode // TypeDefIndex: 3396
{
	// Fields
	protected NamespaceList namespaceList; // 0x10
	protected object particle; // 0x18

	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x1CAA6C8 Offset: 0x1CA66C8 VA: 0x1CAA6C8
	public void .ctor(NamespaceList namespaceList, object particle) { }

	// RVA: 0x1CAA70C Offset: 0x1CA670C VA: 0x1CAA70C Slot: 8
	public virtual ICollection GetResolvedSymbols(SymbolsDictionary symbols) { }

	// RVA: 0x1CAA728 Offset: 0x1CA6728 VA: 0x1CAA728 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1CAAB84 Offset: 0x1CA6B84 VA: 0x1CAAB84 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1CAABBC Offset: 0x1CA6BBC VA: 0x1CAABBC Slot: 6
	public override bool get_IsNullable() { }
}

// Namespace: System.Xml.Schema
internal abstract class InteriorNode : SyntaxTreeNode // TypeDefIndex: 3397
{
	// Fields
	private SyntaxTreeNode leftChild; // 0x10
	private SyntaxTreeNode rightChild; // 0x18

	// Properties
	public SyntaxTreeNode LeftChild { get; set; }
	public SyntaxTreeNode RightChild { get; set; }

	// Methods

	// RVA: 0x1CAABF4 Offset: 0x1CA6BF4 VA: 0x1CAABF4
	public SyntaxTreeNode get_LeftChild() { }

	// RVA: 0x1CAABFC Offset: 0x1CA6BFC VA: 0x1CAABFC
	public void set_LeftChild(SyntaxTreeNode value) { }

	// RVA: 0x1CAAC04 Offset: 0x1CA6C04 VA: 0x1CAAC04
	public SyntaxTreeNode get_RightChild() { }

	// RVA: 0x1CAAC0C Offset: 0x1CA6C0C VA: 0x1CAAC0C
	public void set_RightChild(SyntaxTreeNode value) { }

	// RVA: 0x1CAAC14 Offset: 0x1CA6C14 VA: 0x1CAAC14
	protected void ExpandTreeNoRecursive(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1CAADDC Offset: 0x1CA6DDC VA: 0x1CAADDC Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1CAAE40 Offset: 0x1CA6E40 VA: 0x1CAAE40
	protected void .ctor() { }
}

// Namespace: 
private struct SequenceNode.SequenceConstructPosContext // TypeDefIndex: 3398
{
	// Fields
	public SequenceNode this_; // 0x0
	public BitSet firstpos; // 0x8
	public BitSet lastpos; // 0x10
	public BitSet lastposLeft; // 0x18
	public BitSet firstposRight; // 0x20

	// Methods

	// RVA: 0x1CAB234 Offset: 0x1CA7234 VA: 0x1CAB234
	public void .ctor(SequenceNode node, BitSet firstpos, BitSet lastpos) { }
}

// Namespace: System.Xml.Schema
internal sealed class SequenceNode : InteriorNode // TypeDefIndex: 3399
{
	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x1CAAE48 Offset: 0x1CA6E48 VA: 0x1CAAE48 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1CAB298 Offset: 0x1CA7298 VA: 0x1CAB298 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0x1CAB3F4 Offset: 0x1CA73F4 VA: 0x1CAB3F4 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1CAB3F8 Offset: 0x1CA73F8 VA: 0x1CAB3F8
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class ChoiceNode : InteriorNode // TypeDefIndex: 3400
{
	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x1CAB400 Offset: 0x1CA7400 VA: 0x1CAB400
	private static void ConstructChildPos(SyntaxTreeNode child, BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1CAB4D4 Offset: 0x1CA74D4 VA: 0x1CAB4D4 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1CAB5E4 Offset: 0x1CA75E4 VA: 0x1CAB5E4 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0x1CAB674 Offset: 0x1CA7674 VA: 0x1CAB674 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }

	// RVA: 0x1CAAB7C Offset: 0x1CA6B7C VA: 0x1CAAB7C
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class PlusNode : InteriorNode // TypeDefIndex: 3401
{
	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x1CAB678 Offset: 0x1CA7678 VA: 0x1CAB678 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1CAB714 Offset: 0x1CA7714 VA: 0x1CAB714 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0x1CAB730 Offset: 0x1CA7730 VA: 0x1CAB730
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class QmarkNode : InteriorNode // TypeDefIndex: 3402
{
	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x1CAB738 Offset: 0x1CA7738 VA: 0x1CAB738 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1CAB754 Offset: 0x1CA7754 VA: 0x1CAB754 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0x1CAB75C Offset: 0x1CA775C VA: 0x1CAB75C
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class StarNode : InteriorNode // TypeDefIndex: 3403
{
	// Properties
	public override bool IsNullable { get; }

	// Methods

	// RVA: 0x1CAB764 Offset: 0x1CA7764 VA: 0x1CAB764 Slot: 5
	public override void ConstructPos(BitSet firstpos, BitSet lastpos, BitSet[] followpos) { }

	// RVA: 0x1CAB800 Offset: 0x1CA7800 VA: 0x1CAB800 Slot: 6
	public override bool get_IsNullable() { }

	// RVA: 0x1CAB808 Offset: 0x1CA7808 VA: 0x1CAB808
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class LeafRangeNode : LeafNode // TypeDefIndex: 3404
{
	// Fields
	private Decimal min; // 0x18
	private Decimal max; // 0x28
	private BitSet nextIteration; // 0x38

	// Properties
	public Decimal Max { get; }
	public Decimal Min { get; }
	public BitSet NextIteration { get; set; }
	public override bool IsRangeNode { get; }

	// Methods

	// RVA: 0x1CAB810 Offset: 0x1CA7810 VA: 0x1CAB810
	public void .ctor(Decimal min, Decimal max) { }

	// RVA: 0x1CAB858 Offset: 0x1CA7858 VA: 0x1CAB858
	public void .ctor(int pos, Decimal min, Decimal max) { }

	// RVA: 0x1CAB8A8 Offset: 0x1CA78A8 VA: 0x1CAB8A8
	public Decimal get_Max() { }

	// RVA: 0x1CAB8B4 Offset: 0x1CA78B4 VA: 0x1CAB8B4
	public Decimal get_Min() { }

	// RVA: 0x1CAB8C0 Offset: 0x1CA78C0 VA: 0x1CAB8C0
	public BitSet get_NextIteration() { }

	// RVA: 0x1CAB8C8 Offset: 0x1CA78C8 VA: 0x1CAB8C8
	public void set_NextIteration(BitSet value) { }

	// RVA: 0x1CAB8D0 Offset: 0x1CA78D0 VA: 0x1CAB8D0 Slot: 7
	public override bool get_IsRangeNode() { }

	// RVA: 0x1CAB8D8 Offset: 0x1CA78D8 VA: 0x1CAB8D8 Slot: 4
	public override void ExpandTree(InteriorNode parent, SymbolsDictionary symbols, Positions positions) { }
}

// Namespace: System.Xml.Schema
internal class ContentValidator // TypeDefIndex: 3405
{
	// Fields
	private XmlSchemaContentType contentType; // 0x10
	private bool isOpen; // 0x14
	private bool isEmptiable; // 0x15
	public static readonly ContentValidator Empty; // 0x0
	public static readonly ContentValidator TextOnly; // 0x8
	public static readonly ContentValidator Mixed; // 0x10
	public static readonly ContentValidator Any; // 0x18

	// Properties
	public XmlSchemaContentType ContentType { get; }
	public bool PreserveWhitespace { get; }
	public virtual bool IsEmptiable { get; }
	public bool IsOpen { get; set; }

	// Methods

	// RVA: 0x1CAB90C Offset: 0x1CA790C VA: 0x1CAB90C
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x1CAB93C Offset: 0x1CA793C VA: 0x1CAB93C
	protected void .ctor(XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x1CAB97C Offset: 0x1CA797C VA: 0x1CAB97C
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x1CAB984 Offset: 0x1CA7984 VA: 0x1CAB984
	public bool get_PreserveWhitespace() { }

	// RVA: 0x1CAB998 Offset: 0x1CA7998 VA: 0x1CAB998 Slot: 4
	public virtual bool get_IsEmptiable() { }

	// RVA: 0x1CAB9A0 Offset: 0x1CA79A0 VA: 0x1CAB9A0
	public bool get_IsOpen() { }

	// RVA: 0x1CAB9C4 Offset: 0x1CA79C4 VA: 0x1CAB9C4
	public void set_IsOpen(bool value) { }

	// RVA: 0x1CAB9CC Offset: 0x1CA79CC VA: 0x1CAB9CC Slot: 5
	public virtual void InitValidation(ValidationState context) { }

	// RVA: 0x1CAB9D0 Offset: 0x1CA79D0 VA: 0x1CAB9D0 Slot: 6
	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1CAB9FC Offset: 0x1CA79FC VA: 0x1CAB9FC Slot: 7
	public virtual bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1CABA04 Offset: 0x1CA7A04 VA: 0x1CABA04 Slot: 8
	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1CABA0C Offset: 0x1CA7A0C VA: 0x1CABA0C Slot: 9
	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	// RVA: 0x1CABA14 Offset: 0x1CA7A14 VA: 0x1CABA14
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles) { }

	// RVA: 0x1CABA84 Offset: 0x1CA7A84 VA: 0x1CABA84
	public static void AddParticleToExpected(XmlSchemaParticle p, XmlSchemaSet schemaSet, ArrayList particles, bool global) { }

	// RVA: 0x1CABCAC Offset: 0x1CA7CAC VA: 0x1CABCAC
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class ParticleContentValidator : ContentValidator // TypeDefIndex: 3406
{
	// Fields
	private SymbolsDictionary symbols; // 0x18
	private Positions positions; // 0x20
	private Stack stack; // 0x28
	private SyntaxTreeNode contentNode; // 0x30
	private bool isPartial; // 0x38
	private int minMaxNodesCount; // 0x3C
	private bool enableUpaCheck; // 0x40

	// Methods

	// RVA: 0x1CABDC0 Offset: 0x1CA7DC0 VA: 0x1CABDC0
	public void .ctor(XmlSchemaContentType contentType) { }

	// RVA: 0x1CABDC8 Offset: 0x1CA7DC8 VA: 0x1CABDC8
	public void .ctor(XmlSchemaContentType contentType, bool enableUpaCheck) { }

	// RVA: 0x1CABE48 Offset: 0x1CA7E48 VA: 0x1CABE48 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1CABE80 Offset: 0x1CA7E80 VA: 0x1CABE80 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1CABEB8 Offset: 0x1CA7EB8 VA: 0x1CABEB8 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1CABEF0 Offset: 0x1CA7EF0 VA: 0x1CABEF0
	public void Start() { }

	// RVA: 0x1CABFC0 Offset: 0x1CA7FC0 VA: 0x1CABFC0
	public void OpenGroup() { }

	// RVA: 0x1CABFE4 Offset: 0x1CA7FE4 VA: 0x1CABFE4
	public void CloseGroup() { }

	// RVA: 0x1CAC158 Offset: 0x1CA8158 VA: 0x1CAC158
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x1CAC190 Offset: 0x1CA8190 VA: 0x1CAC190
	public void AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x1CAC32C Offset: 0x1CA832C VA: 0x1CAC32C
	public void AddNamespaceList(NamespaceList namespaceList, object particle) { }

	// RVA: 0x1CAC238 Offset: 0x1CA8238 VA: 0x1CAC238
	private void AddLeafNode(SyntaxTreeNode node) { }

	// RVA: 0x1CAC3B8 Offset: 0x1CA83B8 VA: 0x1CAC3B8
	public void AddChoice() { }

	// RVA: 0x1CAC4A4 Offset: 0x1CA84A4 VA: 0x1CAC4A4
	public void AddSequence() { }

	// RVA: 0x1CAC590 Offset: 0x1CA8590 VA: 0x1CAC590
	public void AddStar() { }

	// RVA: 0x1CAC788 Offset: 0x1CA8788 VA: 0x1CAC788
	public void AddPlus() { }

	// RVA: 0x1CAC7E4 Offset: 0x1CA87E4 VA: 0x1CAC7E4
	public void AddQMark() { }

	// RVA: 0x1CAC840 Offset: 0x1CA8840 VA: 0x1CAC840
	public void AddLeafRange(Decimal min, Decimal max) { }

	// RVA: 0x1CAC5EC Offset: 0x1CA85EC VA: 0x1CAC5EC
	private void Closure(InteriorNode node) { }

	// RVA: 0x1CAC938 Offset: 0x1CA8938 VA: 0x1CAC938
	public ContentValidator Finish(bool useDFA) { }

	// RVA: 0x1CACED4 Offset: 0x1CA8ED4 VA: 0x1CACED4
	private BitSet[] CalculateTotalFollowposForRangeNodes(BitSet firstpos, BitSet[] followpos, out BitSet posWithRangeTerminals) { }

	// RVA: 0x1CAD30C Offset: 0x1CA930C VA: 0x1CAD30C
	private void CheckCMUPAWithLeafRangeNodes(BitSet curpos) { }

	// RVA: 0x1CAD19C Offset: 0x1CA919C VA: 0x1CAD19C
	private BitSet GetApplicableMinMaxFollowPos(BitSet curpos, BitSet posWithRangeTerminals, BitSet[] minmaxFollowPos) { }

	// RVA: 0x1CAD488 Offset: 0x1CA9488 VA: 0x1CAD488
	private void CheckUniqueParticleAttribution(BitSet firstpos, BitSet[] followpos) { }

	// RVA: 0x1CADB4C Offset: 0x1CA9B4C VA: 0x1CADB4C
	private void CheckUniqueParticleAttribution(BitSet curpos) { }

	// RVA: 0x1CAD510 Offset: 0x1CA9510 VA: 0x1CAD510
	private int[][] BuildTransitionTable(BitSet firstpos, BitSet[] followpos, int endMarkerPos) { }
}

// Namespace: System.Xml.Schema
internal sealed class DfaContentValidator : ContentValidator // TypeDefIndex: 3407
{
	// Fields
	private int[][] transitionTable; // 0x18
	private SymbolsDictionary symbols; // 0x20

	// Methods

	// RVA: 0x1CADA94 Offset: 0x1CA9A94 VA: 0x1CADA94
	internal void .ctor(int[][] transitionTable, SymbolsDictionary symbols, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x1CADD08 Offset: 0x1CA9D08 VA: 0x1CADD08 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1CADD6C Offset: 0x1CA9D6C VA: 0x1CADD6C Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1CADE7C Offset: 0x1CA9E7C VA: 0x1CADE7C Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1CADE90 Offset: 0x1CA9E90 VA: 0x1CADE90 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1CAE05C Offset: 0x1CAA05C VA: 0x1CAE05C Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

// Namespace: System.Xml.Schema
internal sealed class NfaContentValidator : ContentValidator // TypeDefIndex: 3408
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private SymbolsDictionary symbols; // 0x28
	private Positions positions; // 0x30
	private int endMarkerPos; // 0x38

	// Methods

	// RVA: 0x1CAE1E0 Offset: 0x1CAA1E0 VA: 0x1CAE1E0
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isOpen, bool isEmptiable) { }

	// RVA: 0x1CAE2CC Offset: 0x1CAA2CC VA: 0x1CAE2CC Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1CAE3A0 Offset: 0x1CAA3A0 VA: 0x1CAE3A0 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1CAE548 Offset: 0x1CAA548 VA: 0x1CAE548 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1CAE590 Offset: 0x1CAA590 VA: 0x1CAE590 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1CAE774 Offset: 0x1CAA774 VA: 0x1CAE774 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

// Namespace: System.Xml.Schema
internal struct RangePositionInfo // TypeDefIndex: 3409
{
	// Fields
	public BitSet curpos; // 0x0
	public Decimal[] rangeCounters; // 0x8
}

// Namespace: System.Xml.Schema
internal sealed class RangeContentValidator : ContentValidator // TypeDefIndex: 3410
{
	// Fields
	private BitSet firstpos; // 0x18
	private BitSet[] followpos; // 0x20
	private BitSet positionsWithRangeTerminals; // 0x28
	private SymbolsDictionary symbols; // 0x30
	private Positions positions; // 0x38
	private int minMaxNodesCount; // 0x40
	private int endMarkerPos; // 0x44

	// Methods

	// RVA: 0x1CAE8F0 Offset: 0x1CAA8F0 VA: 0x1CAE8F0
	internal void .ctor(BitSet firstpos, BitSet[] followpos, SymbolsDictionary symbols, Positions positions, int endMarkerPos, XmlSchemaContentType contentType, bool isEmptiable, BitSet positionsWithRangeTerminals, int minmaxNodesCount) { }

	// RVA: 0x1CAE9F0 Offset: 0x1CAA9F0 VA: 0x1CAE9F0 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1CAEBC8 Offset: 0x1CAABC8 VA: 0x1CAEBC8 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1CAF488 Offset: 0x1CAB488 VA: 0x1CAF488 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1CAF49C Offset: 0x1CAB49C VA: 0x1CAF49C Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1CAF708 Offset: 0x1CAB708 VA: 0x1CAF708 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

// Namespace: System.Xml.Schema
internal sealed class AllElementsContentValidator : ContentValidator // TypeDefIndex: 3411
{
	// Fields
	private Hashtable elements; // 0x18
	private object[] particles; // 0x20
	private BitSet isRequired; // 0x28
	private int countRequired; // 0x30

	// Properties
	public override bool IsEmptiable { get; }

	// Methods

	// RVA: 0x1CAF910 Offset: 0x1CAB910 VA: 0x1CAF910
	public void .ctor(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	// RVA: 0x1CAFA38 Offset: 0x1CABA38 VA: 0x1CAFA38
	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	// RVA: 0x1CAFB68 Offset: 0x1CABB68 VA: 0x1CAFB68 Slot: 4
	public override bool get_IsEmptiable() { }

	// RVA: 0x1CAFB88 Offset: 0x1CABB88 VA: 0x1CAFB88 Slot: 5
	public override void InitValidation(ValidationState context) { }

	// RVA: 0x1CAFC24 Offset: 0x1CABC24 VA: 0x1CAFC24 Slot: 6
	public override object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

	// RVA: 0x1CAFD44 Offset: 0x1CABD44 VA: 0x1CAFD44 Slot: 7
	public override bool CompleteValidation(ValidationState context) { }

	// RVA: 0x1CAFD94 Offset: 0x1CABD94 VA: 0x1CAFD94 Slot: 8
	public override ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	// RVA: 0x1CB0160 Offset: 0x1CAC160 VA: 0x1CB0160 Slot: 9
	public override ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }
}

// Namespace: System.Xml.Schema
public enum XmlSchemaDatatypeVariety // TypeDefIndex: 3412
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaDatatypeVariety Atomic = 0;
	public const XmlSchemaDatatypeVariety List = 1;
	public const XmlSchemaDatatypeVariety Union = 2;
}

// Namespace: System.Xml.Schema
internal class XsdSimpleValue // TypeDefIndex: 3413
{
	// Fields
	private XmlSchemaSimpleType xmlType; // 0x10
	private object typedValue; // 0x18

	// Properties
	public XmlSchemaSimpleType XmlType { get; }
	public object TypedValue { get; }

	// Methods

	// RVA: 0x1CB05E4 Offset: 0x1CAC5E4 VA: 0x1CB05E4
	public void .ctor(XmlSchemaSimpleType st, object value) { }

	// RVA: 0x1CB0628 Offset: 0x1CAC628 VA: 0x1CB0628
	public XmlSchemaSimpleType get_XmlType() { }

	// RVA: 0x1CB0630 Offset: 0x1CAC630 VA: 0x1CB0630
	public object get_TypedValue() { }
}

// Namespace: System.Xml.Schema
[Flags]
internal enum RestrictionFlags // TypeDefIndex: 3414
{
	// Fields
	public int value__; // 0x0
	public const RestrictionFlags Length = 1;
	public const RestrictionFlags MinLength = 2;
	public const RestrictionFlags MaxLength = 4;
	public const RestrictionFlags Pattern = 8;
	public const RestrictionFlags Enumeration = 16;
	public const RestrictionFlags WhiteSpace = 32;
	public const RestrictionFlags MaxInclusive = 64;
	public const RestrictionFlags MaxExclusive = 128;
	public const RestrictionFlags MinInclusive = 256;
	public const RestrictionFlags MinExclusive = 512;
	public const RestrictionFlags TotalDigits = 1024;
	public const RestrictionFlags FractionDigits = 2048;
}

// Namespace: System.Xml.Schema
internal enum XmlSchemaWhiteSpace // TypeDefIndex: 3415
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaWhiteSpace Preserve = 0;
	public const XmlSchemaWhiteSpace Replace = 1;
	public const XmlSchemaWhiteSpace Collapse = 2;
}

// Namespace: System.Xml.Schema
internal class RestrictionFacets // TypeDefIndex: 3416
{
	// Fields
	internal int Length; // 0x10
	internal int MinLength; // 0x14
	internal int MaxLength; // 0x18
	internal ArrayList Patterns; // 0x20
	internal ArrayList Enumeration; // 0x28
	internal XmlSchemaWhiteSpace WhiteSpace; // 0x30
	internal object MaxInclusive; // 0x38
	internal object MaxExclusive; // 0x40
	internal object MinInclusive; // 0x48
	internal object MinExclusive; // 0x50
	internal int TotalDigits; // 0x58
	internal int FractionDigits; // 0x5C
	internal RestrictionFlags Flags; // 0x60
	internal RestrictionFlags FixedFlags; // 0x64

	// Methods

	// RVA: 0x1CB0638 Offset: 0x1CAC638 VA: 0x1CB0638
	public void .ctor() { }
}

// Namespace: 
private class DatatypeImplementation.SchemaDatatypeMap : IComparable // TypeDefIndex: 3417
{
	// Fields
	private string name; // 0x10
	private DatatypeImplementation type; // 0x18
	private int parentIndex; // 0x20

	// Properties
	public string Name { get; }
	public int ParentIndex { get; }

	// Methods

	// RVA: 0x1CB53D0 Offset: 0x1CB13D0 VA: 0x1CB53D0
	internal void .ctor(string name, DatatypeImplementation type) { }

	// RVA: 0x1CB5414 Offset: 0x1CB1414 VA: 0x1CB5414
	internal void .ctor(string name, DatatypeImplementation type, int parentIndex) { }

	// RVA: 0x1CB79A8 Offset: 0x1CB39A8 VA: 0x1CB79A8
	public static DatatypeImplementation op_Explicit(DatatypeImplementation.SchemaDatatypeMap sdm) { }

	// RVA: 0x1CB79BC Offset: 0x1CB39BC VA: 0x1CB79BC
	public string get_Name() { }

	// RVA: 0x1CB79C4 Offset: 0x1CB39C4 VA: 0x1CB79C4
	public int get_ParentIndex() { }

	// RVA: 0x1CB79CC Offset: 0x1CB39CC VA: 0x1CB79CC Slot: 4
	public int CompareTo(object obj) { }
}

// Namespace: System.Xml.Schema
internal abstract class DatatypeImplementation : XmlSchemaDatatype // TypeDefIndex: 3418
{
	// Fields
	private XmlSchemaDatatypeVariety variety; // 0x10
	private RestrictionFacets restriction; // 0x18
	private DatatypeImplementation baseType; // 0x20
	private XmlValueConverter valueConverter; // 0x28
	private XmlSchemaType parentSchemaType; // 0x30
	private static Hashtable builtinTypes; // 0x0
	private static XmlSchemaSimpleType[] enumToTypeCode; // 0x8
	private static XmlSchemaSimpleType anySimpleType; // 0x10
	private static XmlSchemaSimpleType anyAtomicType; // 0x18
	private static XmlSchemaSimpleType untypedAtomicType; // 0x20
	private static XmlSchemaSimpleType yearMonthDurationType; // 0x28
	private static XmlSchemaSimpleType dayTimeDurationType; // 0x30
	private static XmlSchemaSimpleType normalizedStringTypeV1Compat; // 0x38
	private static XmlSchemaSimpleType tokenTypeV1Compat; // 0x40
	internal static XmlQualifiedName QnAnySimpleType; // 0x48
	internal static XmlQualifiedName QnAnyType; // 0x50
	internal static FacetsChecker stringFacetsChecker; // 0x58
	internal static FacetsChecker miscFacetsChecker; // 0x60
	internal static FacetsChecker numeric2FacetsChecker; // 0x68
	internal static FacetsChecker binaryFacetsChecker; // 0x70
	internal static FacetsChecker dateTimeFacetsChecker; // 0x78
	internal static FacetsChecker durationFacetsChecker; // 0x80
	internal static FacetsChecker listFacetsChecker; // 0x88
	internal static FacetsChecker qnameFacetsChecker; // 0x90
	internal static FacetsChecker unionFacetsChecker; // 0x98
	private static readonly DatatypeImplementation c_anySimpleType; // 0xA0
	private static readonly DatatypeImplementation c_anyURI; // 0xA8
	private static readonly DatatypeImplementation c_base64Binary; // 0xB0
	private static readonly DatatypeImplementation c_boolean; // 0xB8
	private static readonly DatatypeImplementation c_byte; // 0xC0
	private static readonly DatatypeImplementation c_char; // 0xC8
	private static readonly DatatypeImplementation c_date; // 0xD0
	private static readonly DatatypeImplementation c_dateTime; // 0xD8
	private static readonly DatatypeImplementation c_dateTimeNoTz; // 0xE0
	private static readonly DatatypeImplementation c_dateTimeTz; // 0xE8
	private static readonly DatatypeImplementation c_day; // 0xF0
	private static readonly DatatypeImplementation c_decimal; // 0xF8
	private static readonly DatatypeImplementation c_double; // 0x100
	private static readonly DatatypeImplementation c_doubleXdr; // 0x108
	private static readonly DatatypeImplementation c_duration; // 0x110
	private static readonly DatatypeImplementation c_ENTITY; // 0x118
	private static readonly DatatypeImplementation c_ENTITIES; // 0x120
	private static readonly DatatypeImplementation c_ENUMERATION; // 0x128
	private static readonly DatatypeImplementation c_fixed; // 0x130
	private static readonly DatatypeImplementation c_float; // 0x138
	private static readonly DatatypeImplementation c_floatXdr; // 0x140
	private static readonly DatatypeImplementation c_hexBinary; // 0x148
	private static readonly DatatypeImplementation c_ID; // 0x150
	private static readonly DatatypeImplementation c_IDREF; // 0x158
	private static readonly DatatypeImplementation c_IDREFS; // 0x160
	private static readonly DatatypeImplementation c_int; // 0x168
	private static readonly DatatypeImplementation c_integer; // 0x170
	private static readonly DatatypeImplementation c_language; // 0x178
	private static readonly DatatypeImplementation c_long; // 0x180
	private static readonly DatatypeImplementation c_month; // 0x188
	private static readonly DatatypeImplementation c_monthDay; // 0x190
	private static readonly DatatypeImplementation c_Name; // 0x198
	private static readonly DatatypeImplementation c_NCName; // 0x1A0
	private static readonly DatatypeImplementation c_negativeInteger; // 0x1A8
	private static readonly DatatypeImplementation c_NMTOKEN; // 0x1B0
	private static readonly DatatypeImplementation c_NMTOKENS; // 0x1B8
	private static readonly DatatypeImplementation c_nonNegativeInteger; // 0x1C0
	private static readonly DatatypeImplementation c_nonPositiveInteger; // 0x1C8
	private static readonly DatatypeImplementation c_normalizedString; // 0x1D0
	private static readonly DatatypeImplementation c_NOTATION; // 0x1D8
	private static readonly DatatypeImplementation c_positiveInteger; // 0x1E0
	private static readonly DatatypeImplementation c_QName; // 0x1E8
	private static readonly DatatypeImplementation c_QNameXdr; // 0x1F0
	private static readonly DatatypeImplementation c_short; // 0x1F8
	private static readonly DatatypeImplementation c_string; // 0x200
	private static readonly DatatypeImplementation c_time; // 0x208
	private static readonly DatatypeImplementation c_timeNoTz; // 0x210
	private static readonly DatatypeImplementation c_timeTz; // 0x218
	private static readonly DatatypeImplementation c_token; // 0x220
	private static readonly DatatypeImplementation c_unsignedByte; // 0x228
	private static readonly DatatypeImplementation c_unsignedInt; // 0x230
	private static readonly DatatypeImplementation c_unsignedLong; // 0x238
	private static readonly DatatypeImplementation c_unsignedShort; // 0x240
	private static readonly DatatypeImplementation c_uuid; // 0x248
	private static readonly DatatypeImplementation c_year; // 0x250
	private static readonly DatatypeImplementation c_yearMonth; // 0x258
	internal static readonly DatatypeImplementation c_normalizedStringV1Compat; // 0x260
	internal static readonly DatatypeImplementation c_tokenV1Compat; // 0x268
	private static readonly DatatypeImplementation c_anyAtomicType; // 0x270
	private static readonly DatatypeImplementation c_dayTimeDuration; // 0x278
	private static readonly DatatypeImplementation c_untypedAtomicType; // 0x280
	private static readonly DatatypeImplementation c_yearMonthDuration; // 0x288
	private static readonly DatatypeImplementation[] c_tokenizedTypes; // 0x290
	private static readonly DatatypeImplementation[] c_tokenizedTypesXsd; // 0x298
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XdrTypes; // 0x2A0
	private static readonly DatatypeImplementation.SchemaDatatypeMap[] c_XsdTypes; // 0x2A8

	// Properties
	internal static XmlSchemaSimpleType AnySimpleType { get; }
	internal static XmlSchemaSimpleType UntypedAtomicType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override XmlValueConverter ValueConverter { get; }
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	public override XmlSchemaDatatypeVariety Variety { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFacets Restriction { get; }
	internal override bool HasLexicalFacets { get; }
	internal override bool HasValueFacets { get; }
	protected DatatypeImplementation Base { get; }
	internal abstract Type ListValueType { get; }
	internal abstract RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x1CB0640 Offset: 0x1CAC640 VA: 0x1CB0640
	private static void .cctor() { }

	// RVA: 0x1CB5D50 Offset: 0x1CB1D50 VA: 0x1CB5D50
	internal static XmlSchemaSimpleType get_AnySimpleType() { }

	// RVA: 0x1CB5DA8 Offset: 0x1CB1DA8 VA: 0x1CB5DA8
	internal static XmlSchemaSimpleType get_UntypedAtomicType() { }

	// RVA: 0x1CB5E00 Offset: 0x1CB1E00 VA: 0x1CB5E00
	internal static DatatypeImplementation FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x1CB5E7C Offset: 0x1CB1E7C VA: 0x1CB5E7C
	internal static DatatypeImplementation FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x1CB5EF8 Offset: 0x1CB1EF8 VA: 0x1CB5EF8
	internal static DatatypeImplementation FromXdrName(string name) { }

	// RVA: 0x1CB5FB8 Offset: 0x1CB1FB8 VA: 0x1CB5FB8
	private static DatatypeImplementation FromTypeName(string name) { }

	// RVA: 0x1CB6078 Offset: 0x1CB2078 VA: 0x1CB6078
	internal static XmlSchemaSimpleType StartBuiltinType(XmlQualifiedName qname, XmlSchemaDatatype dataType) { }

	// RVA: 0x1CB615C Offset: 0x1CB215C VA: 0x1CB615C
	internal static void FinishBuiltinType(XmlSchemaSimpleType derivedType, XmlSchemaSimpleType baseType) { }

	// RVA: 0x1CB546C Offset: 0x1CB146C VA: 0x1CB546C
	internal static void CreateBuiltinTypes() { }

	// RVA: 0x1CB63A0 Offset: 0x1CB23A0 VA: 0x1CB63A0
	internal static XmlSchemaSimpleType GetSimpleTypeFromTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x1CB641C Offset: 0x1CB241C VA: 0x1CB641C
	internal static XmlSchemaSimpleType GetSimpleTypeFromXsdType(XmlQualifiedName qname) { }

	// RVA: 0x1CB64DC Offset: 0x1CB24DC VA: 0x1CB64DC
	internal static XmlSchemaSimpleType GetNormalizedStringTypeV1Compat() { }

	// RVA: 0x1CB6674 Offset: 0x1CB2674 VA: 0x1CB6674
	internal static XmlSchemaSimpleType GetTokenTypeV1Compat() { }

	// RVA: 0x1CB680C Offset: 0x1CB280C VA: 0x1CB680C
	internal static XmlSchemaSimpleType[] GetBuiltInTypes() { }

	// RVA: 0x1CB6864 Offset: 0x1CB2864 VA: 0x1CB6864
	internal static XmlTypeCode GetPrimitiveTypeCode(XmlTypeCode typeCode) { }

	// RVA: 0x1CB6994 Offset: 0x1CB2994 VA: 0x1CB6994 Slot: 20
	internal override XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType) { }

	// RVA: 0x1CB6AB0 Offset: 0x1CB2AB0 VA: 0x1CB6AB0 Slot: 21
	internal override XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType) { }

	// RVA: 0x1CB48A8 Offset: 0x1CB08A8 VA: 0x1CB48A8
	internal XmlSchemaDatatype DeriveByList(int minSize, XmlSchemaType schemaType) { }

	// RVA: 0x1CB6BB4 Offset: 0x1CB2BB4 VA: 0x1CB6BB4
	internal static DatatypeImplementation DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x1CB6CE4 Offset: 0x1CB2CE4 VA: 0x1CB6CE4 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x1CB6CE8 Offset: 0x1CB2CE8 VA: 0x1CB6CE8 Slot: 9
	public override bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: 0x1CB6F60 Offset: 0x1CB2F60 VA: 0x1CB6F60 Slot: 23
	internal override bool IsEqual(object o1, object o2) { }

	// RVA: 0x1CB6F84 Offset: 0x1CB2F84 VA: 0x1CB6F84 Slot: 24
	internal override bool IsComparable(XmlSchemaDatatype dtype) { }

	// RVA: 0x1CB7070 Offset: 0x1CB3070 VA: 0x1CB7070 Slot: 25
	internal virtual XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CB7078 Offset: 0x1CB3078 VA: 0x1CB7078 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CB70D0 Offset: 0x1CB30D0 VA: 0x1CB70D0 Slot: 12
	internal override XmlValueConverter get_ValueConverter() { }

	// RVA: 0x1CB7120 Offset: 0x1CB3120 VA: 0x1CB7120 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1CB7128 Offset: 0x1CB3128 VA: 0x1CB7128 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CB7158 Offset: 0x1CB3158 VA: 0x1CB7158 Slot: 7
	public override XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x1CB7160 Offset: 0x1CB3160 VA: 0x1CB7160 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB7168 Offset: 0x1CB3168 VA: 0x1CB7168 Slot: 13
	internal override RestrictionFacets get_Restriction() { }

	// RVA: 0x1CB7170 Offset: 0x1CB3170 VA: 0x1CB7170 Slot: 10
	internal override bool get_HasLexicalFacets() { }

	// RVA: 0x1CB7198 Offset: 0x1CB3198 VA: 0x1CB7198 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1CB71C0 Offset: 0x1CB31C0 VA: 0x1CB71C0
	protected DatatypeImplementation get_Base() { }

	// RVA: -1 Offset: -1 Slot: 26
	internal abstract Type get_ListValueType();

	// RVA: -1 Offset: -1 Slot: 27
	internal abstract RestrictionFlags get_ValidRestrictionFlags();

	// RVA: 0x1CB71C8 Offset: 0x1CB31C8 VA: 0x1CB71C8 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CB71D0 Offset: 0x1CB31D0 VA: 0x1CB71D0 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1CB7400 Offset: 0x1CB3400 VA: 0x1CB7400 Slot: 15
	internal override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue) { }

	// RVA: 0x1CB7544 Offset: 0x1CB3544 VA: 0x1CB7544 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x1CB7394 Offset: 0x1CB3394 VA: 0x1CB7394
	internal string GetTypeName() { }

	// RVA: 0x1CB7944 Offset: 0x1CB3944 VA: 0x1CB7944
	protected int Compare(byte[] value1, byte[] value2) { }

	// RVA: 0x1CB79A0 Offset: 0x1CB39A0 VA: 0x1CB79A0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_List : Datatype_anySimpleType // TypeDefIndex: 3419
{
	// Fields
	private DatatypeImplementation itemType; // 0x38
	private int minListSize; // 0x40

	// Properties
	public override Type ValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override Type ListValueType { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1CB7A08 Offset: 0x1CB3A08 VA: 0x1CB7A08 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CB6B38 Offset: 0x1CB2B38 VA: 0x1CB6B38
	internal void .ctor(DatatypeImplementation type, int minListSize) { }

	// RVA: 0x1CB7CA4 Offset: 0x1CB3CA4 VA: 0x1CB7CA4 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CB7F48 Offset: 0x1CB3F48 VA: 0x1CB7F48 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CB7F58 Offset: 0x1CB3F58 VA: 0x1CB7F58 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1CB7F74 Offset: 0x1CB3F74 VA: 0x1CB7F74 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CB7F94 Offset: 0x1CB3F94 VA: 0x1CB7F94 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CB7FEC Offset: 0x1CB3FEC VA: 0x1CB7FEC Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB8008 Offset: 0x1CB4008 VA: 0x1CB8008 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CB8010 Offset: 0x1CB4010 VA: 0x1CB8010 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue) { }

	// RVA: 0x1CB85F0 Offset: 0x1CB45F0 VA: 0x1CB85F0 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }
}

// Namespace: System.Xml.Schema
internal class Datatype_union : Datatype_anySimpleType // TypeDefIndex: 3420
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XmlSchemaSimpleType[] types; // 0x38

	// Properties
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override FacetsChecker FacetsChecker { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x1CB8A2C Offset: 0x1CB4A2C VA: 0x1CB8A2C Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CB6C74 Offset: 0x1CB2C74 VA: 0x1CB6C74
	internal void .ctor(XmlSchemaSimpleType[] types) { }

	// RVA: 0x1CB8A38 Offset: 0x1CB4A38 VA: 0x1CB8A38 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CB8B3C Offset: 0x1CB4B3C VA: 0x1CB8B3C Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CB8B94 Offset: 0x1CB4B94 VA: 0x1CB8B94 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB8B9C Offset: 0x1CB4B9C VA: 0x1CB8B9C Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CB8BF4 Offset: 0x1CB4BF4 VA: 0x1CB8BF4 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CB8C4C Offset: 0x1CB4C4C VA: 0x1CB8C4C Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CB8C54 Offset: 0x1CB4C54 VA: 0x1CB8C54
	internal XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x1CB6ABC Offset: 0x1CB2ABC VA: 0x1CB6ABC
	internal bool HasAtomicMembers() { }

	// RVA: 0x1CB6ED8 Offset: 0x1CB2ED8 VA: 0x1CB6ED8
	internal bool IsUnionBaseOf(DatatypeImplementation derivedType) { }

	// RVA: 0x1CB8C5C Offset: 0x1CB4C5C VA: 0x1CB8C5C Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB8E60 Offset: 0x1CB4E60 VA: 0x1CB8E60 Slot: 17
	internal override Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB930C Offset: 0x1CB530C VA: 0x1CB930C
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_anySimpleType : DatatypeImplementation // TypeDefIndex: 3421
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override Type ValueType { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override Type ListValueType { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x1CB93C0 Offset: 0x1CB53C0 VA: 0x1CB93C0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CB9418 Offset: 0x1CB5418 VA: 0x1CB9418 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CB9470 Offset: 0x1CB5470 VA: 0x1CB9470 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CB94C8 Offset: 0x1CB54C8 VA: 0x1CB94C8 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB94D0 Offset: 0x1CB54D0 VA: 0x1CB94D0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CB9528 Offset: 0x1CB5528 VA: 0x1CB9528 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1CB9530 Offset: 0x1CB5530 VA: 0x1CB9530 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CB9538 Offset: 0x1CB5538 VA: 0x1CB9538 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CB9540 Offset: 0x1CB5540 VA: 0x1CB9540 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CB959C Offset: 0x1CB559C VA: 0x1CB959C Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB43A0 Offset: 0x1CB03A0 VA: 0x1CB43A0
	public void .ctor() { }

	// RVA: 0x1CB95CC Offset: 0x1CB55CC VA: 0x1CB95CC
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_anyAtomicType : Datatype_anySimpleType // TypeDefIndex: 3422
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CB9680 Offset: 0x1CB5680 VA: 0x1CB9680 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CB96D8 Offset: 0x1CB56D8 VA: 0x1CB96D8 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CB96E0 Offset: 0x1CB56E0 VA: 0x1CB96E0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB52D0 Offset: 0x1CB12D0 VA: 0x1CB52D0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_untypedAtomicType : Datatype_anyAtomicType // TypeDefIndex: 3423
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CB96E8 Offset: 0x1CB56E8 VA: 0x1CB96E8 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CB9740 Offset: 0x1CB5740 VA: 0x1CB9740 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CB9748 Offset: 0x1CB5748 VA: 0x1CB9748 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB5378 Offset: 0x1CB1378 VA: 0x1CB5378
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_string : Datatype_anySimpleType // TypeDefIndex: 3424
{
	// Properties
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1CB9750 Offset: 0x1CB5750 VA: 0x1CB9750 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CB975C Offset: 0x1CB575C VA: 0x1CB975C Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CB9764 Offset: 0x1CB5764 VA: 0x1CB9764 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CB97BC Offset: 0x1CB57BC VA: 0x1CB97BC Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB97C4 Offset: 0x1CB57C4 VA: 0x1CB97C4 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1CB97CC Offset: 0x1CB57CC VA: 0x1CB97CC Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CB97D4 Offset: 0x1CB57D4 VA: 0x1CB97D4 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB4F14 Offset: 0x1CB0F14 VA: 0x1CB4F14
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_boolean : Datatype_anySimpleType // TypeDefIndex: 3425
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1CB98C0 Offset: 0x1CB58C0 VA: 0x1CB98C0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CB98CC Offset: 0x1CB58CC VA: 0x1CB98CC Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CB9924 Offset: 0x1CB5924 VA: 0x1CB9924 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB992C Offset: 0x1CB592C VA: 0x1CB992C Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CB9984 Offset: 0x1CB5984 VA: 0x1CB9984 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CB99DC Offset: 0x1CB59DC VA: 0x1CB99DC Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CB99E4 Offset: 0x1CB59E4 VA: 0x1CB99E4 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CB99EC Offset: 0x1CB59EC VA: 0x1CB99EC Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CB9A70 Offset: 0x1CB5A70 VA: 0x1CB9A70 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB44A0 Offset: 0x1CB04A0 VA: 0x1CB44A0
	public void .ctor() { }

	// RVA: 0x1CB9B84 Offset: 0x1CB5B84 VA: 0x1CB9B84
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_float : Datatype_anySimpleType // TypeDefIndex: 3426
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1CB9C38 Offset: 0x1CB5C38 VA: 0x1CB9C38 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CB9C44 Offset: 0x1CB5C44 VA: 0x1CB9C44 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CB9C9C Offset: 0x1CB5C9C VA: 0x1CB9C9C Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB9CA4 Offset: 0x1CB5CA4 VA: 0x1CB9CA4 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CB9CFC Offset: 0x1CB5CFC VA: 0x1CB9CFC Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CB9D54 Offset: 0x1CB5D54 VA: 0x1CB9D54 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CB9D5C Offset: 0x1CB5D5C VA: 0x1CB9D5C Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CB9D64 Offset: 0x1CB5D64 VA: 0x1CB9D64 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CB9DD4 Offset: 0x1CB5DD4 VA: 0x1CB9DD4 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB4AA0 Offset: 0x1CB0AA0 VA: 0x1CB4AA0
	public void .ctor() { }

	// RVA: 0x1CB9F20 Offset: 0x1CB5F20 VA: 0x1CB9F20
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_double : Datatype_anySimpleType // TypeDefIndex: 3427
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1CB9FD4 Offset: 0x1CB5FD4 VA: 0x1CB9FD4 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CB9FE0 Offset: 0x1CB5FE0 VA: 0x1CB9FE0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBA038 Offset: 0x1CB6038 VA: 0x1CBA038 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBA040 Offset: 0x1CB6040 VA: 0x1CBA040 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBA098 Offset: 0x1CB6098 VA: 0x1CBA098 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBA0F0 Offset: 0x1CB60F0 VA: 0x1CBA0F0 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CBA0F8 Offset: 0x1CB60F8 VA: 0x1CBA0F8 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CBA100 Offset: 0x1CB6100 VA: 0x1CBA100 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CBA170 Offset: 0x1CB6170 VA: 0x1CBA170 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB47A8 Offset: 0x1CB07A8 VA: 0x1CB47A8
	public void .ctor() { }

	// RVA: 0x1CBA2BC Offset: 0x1CB62BC VA: 0x1CBA2BC
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_decimal : Datatype_anySimpleType // TypeDefIndex: 3428
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1CBA370 Offset: 0x1CB6370 VA: 0x1CBA370 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CBA37C Offset: 0x1CB637C VA: 0x1CBA37C Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBA3D4 Offset: 0x1CB63D4 VA: 0x1CBA3D4 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBA3DC Offset: 0x1CB63DC VA: 0x1CBA3DC Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBA434 Offset: 0x1CB6434 VA: 0x1CBA434 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBA48C Offset: 0x1CB648C VA: 0x1CBA48C Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CBA494 Offset: 0x1CB6494 VA: 0x1CBA494 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CBA49C Offset: 0x1CB649C VA: 0x1CBA49C Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CBA590 Offset: 0x1CB6590 VA: 0x1CBA590 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB4754 Offset: 0x1CB0754 VA: 0x1CB4754
	public void .ctor() { }

	// RVA: 0x1CBA718 Offset: 0x1CB6718 VA: 0x1CBA718
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_duration : Datatype_anySimpleType // TypeDefIndex: 3429
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1CBA8F0 Offset: 0x1CB68F0 VA: 0x1CBA8F0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CBA8FC Offset: 0x1CB68FC VA: 0x1CBA8FC Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBA954 Offset: 0x1CB6954 VA: 0x1CBA954 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBA95C Offset: 0x1CB695C VA: 0x1CBA95C Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBA9B4 Offset: 0x1CB69B4 VA: 0x1CBA9B4 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBAA0C Offset: 0x1CB6A0C VA: 0x1CBAA0C Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CBAA14 Offset: 0x1CB6A14 VA: 0x1CBAA14 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CBAA1C Offset: 0x1CB6A1C VA: 0x1CBAA1C Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CBAAC4 Offset: 0x1CB6AC4 VA: 0x1CBAAC4 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB4850 Offset: 0x1CB0850 VA: 0x1CB4850
	public void .ctor() { }

	// RVA: 0x1CBAC94 Offset: 0x1CB6C94 VA: 0x1CBAC94
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonthDuration : Datatype_duration // TypeDefIndex: 3430
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBAD5C Offset: 0x1CB6D5C VA: 0x1CBAD5C Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CBAF30 Offset: 0x1CB6F30 VA: 0x1CBAF30 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB537C Offset: 0x1CB137C VA: 0x1CB537C
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dayTimeDuration : Datatype_duration // TypeDefIndex: 3431
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBAF38 Offset: 0x1CB6F38 VA: 0x1CBAF38 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CBB10C Offset: 0x1CB710C VA: 0x1CBB10C Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB5324 Offset: 0x1CB1324 VA: 0x1CB5324
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeBase : Datatype_anySimpleType // TypeDefIndex: 3432
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private XsdDateTimeFlags dateTimeFlags; // 0x38

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1CBB114 Offset: 0x1CB7114 VA: 0x1CBB114 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CBB120 Offset: 0x1CB7120 VA: 0x1CBB120 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBB178 Offset: 0x1CB7178 VA: 0x1CBB178 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBB180 Offset: 0x1CB7180 VA: 0x1CBB180
	internal void .ctor(XsdDateTimeFlags dateTimeFlags) { }

	// RVA: 0x1CBB1E8 Offset: 0x1CB71E8 VA: 0x1CBB1E8 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBB240 Offset: 0x1CB7240 VA: 0x1CBB240 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBB298 Offset: 0x1CB7298 VA: 0x1CBB298 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CBB2A0 Offset: 0x1CB72A0 VA: 0x1CBB2A0 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CBB2A8 Offset: 0x1CB72A8 VA: 0x1CBB2A8 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CBB3F4 Offset: 0x1CB73F4 VA: 0x1CBB3F4 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CBB760 Offset: 0x1CB7760 VA: 0x1CBB760
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 3433
{
	// Methods

	// RVA: 0x1CB464C Offset: 0x1CB064C VA: 0x1CB464C
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTimeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 3434
{
	// Methods

	// RVA: 0x1CB46A4 Offset: 0x1CB06A4 VA: 0x1CB46A4
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_dateTime : Datatype_dateTimeBase // TypeDefIndex: 3435
{
	// Methods

	// RVA: 0x1CB45F4 Offset: 0x1CB05F4 VA: 0x1CB45F4
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_timeNoTimeZone : Datatype_dateTimeBase // TypeDefIndex: 3436
{
	// Methods

	// RVA: 0x1CB4FC0 Offset: 0x1CB0FC0 VA: 0x1CB4FC0
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_timeTimeZone : Datatype_dateTimeBase // TypeDefIndex: 3437
{
	// Methods

	// RVA: 0x1CB5018 Offset: 0x1CB1018 VA: 0x1CB5018
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_time : Datatype_dateTimeBase // TypeDefIndex: 3438
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBB828 Offset: 0x1CB7828 VA: 0x1CBB828 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB4F68 Offset: 0x1CB0F68 VA: 0x1CB4F68
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_date : Datatype_dateTimeBase // TypeDefIndex: 3439
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBB830 Offset: 0x1CB7830 VA: 0x1CBB830 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB459C Offset: 0x1CB059C VA: 0x1CB459C
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_yearMonth : Datatype_dateTimeBase // TypeDefIndex: 3440
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBB838 Offset: 0x1CB7838 VA: 0x1CBB838 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB5270 Offset: 0x1CB1270 VA: 0x1CB5270
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_year : Datatype_dateTimeBase // TypeDefIndex: 3441
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBB840 Offset: 0x1CB7840 VA: 0x1CBB840 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB5218 Offset: 0x1CB1218 VA: 0x1CB5218
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_monthDay : Datatype_dateTimeBase // TypeDefIndex: 3442
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBB848 Offset: 0x1CB7848 VA: 0x1CBB848 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB4CAC Offset: 0x1CB0CAC VA: 0x1CB4CAC
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_day : Datatype_dateTimeBase // TypeDefIndex: 3443
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBB850 Offset: 0x1CB7850 VA: 0x1CBB850 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB46FC Offset: 0x1CB06FC VA: 0x1CB46FC
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_month : Datatype_dateTimeBase // TypeDefIndex: 3444
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBB858 Offset: 0x1CB7858 VA: 0x1CBB858 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB4C54 Offset: 0x1CB0C54 VA: 0x1CB4C54
	internal void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_hexBinary : Datatype_anySimpleType // TypeDefIndex: 3445
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1CBB860 Offset: 0x1CB7860 VA: 0x1CBB860 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CBB86C Offset: 0x1CB786C VA: 0x1CBB86C Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBB8C4 Offset: 0x1CB78C4 VA: 0x1CBB8C4 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBB8CC Offset: 0x1CB78CC VA: 0x1CBB8CC Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBB924 Offset: 0x1CB7924 VA: 0x1CBB924 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBB97C Offset: 0x1CB797C VA: 0x1CBB97C Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CBB984 Offset: 0x1CB7984 VA: 0x1CBB984 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CBB98C Offset: 0x1CB798C VA: 0x1CBB98C Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CBBA34 Offset: 0x1CB7A34 VA: 0x1CBBA34 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB4B48 Offset: 0x1CB0B48 VA: 0x1CB4B48
	public void .ctor() { }

	// RVA: 0x1CBBC18 Offset: 0x1CB7C18 VA: 0x1CBBC18
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_base64Binary : Datatype_anySimpleType // TypeDefIndex: 3446
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1CBBCE0 Offset: 0x1CB7CE0 VA: 0x1CBBCE0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CBBCEC Offset: 0x1CB7CEC VA: 0x1CBBCEC Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBBD44 Offset: 0x1CB7D44 VA: 0x1CBBD44 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBBD4C Offset: 0x1CB7D4C VA: 0x1CBBD4C Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBBDA4 Offset: 0x1CB7DA4 VA: 0x1CBBDA4 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBBDFC Offset: 0x1CB7DFC VA: 0x1CBBDFC Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CBBE04 Offset: 0x1CB7E04 VA: 0x1CBBE04 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CBBE0C Offset: 0x1CB7E0C VA: 0x1CBBE0C Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CBBEB4 Offset: 0x1CB7EB4 VA: 0x1CBBEB4 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB444C Offset: 0x1CB044C VA: 0x1CB444C
	public void .ctor() { }

	// RVA: 0x1CBC094 Offset: 0x1CB8094 VA: 0x1CBC094
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_anyURI : Datatype_anySimpleType // TypeDefIndex: 3447
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override bool HasValueFacets { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1CBC15C Offset: 0x1CB815C VA: 0x1CBC15C Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CBC168 Offset: 0x1CB8168 VA: 0x1CBC168 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBC1C0 Offset: 0x1CB81C0 VA: 0x1CBC1C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBC1C8 Offset: 0x1CB81C8 VA: 0x1CBC1C8 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBC220 Offset: 0x1CB8220 VA: 0x1CBC220 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1CBC228 Offset: 0x1CB8228 VA: 0x1CBC228 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBC280 Offset: 0x1CB8280 VA: 0x1CBC280 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CBC288 Offset: 0x1CB8288 VA: 0x1CBC288 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CBC290 Offset: 0x1CB8290 VA: 0x1CBC290 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CBC358 Offset: 0x1CB8358 VA: 0x1CBC358 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB43F8 Offset: 0x1CB03F8 VA: 0x1CB43F8
	public void .ctor() { }

	// RVA: 0x1CBC708 Offset: 0x1CB8708 VA: 0x1CBC708
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_QName : Datatype_anySimpleType // TypeDefIndex: 3448
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x1CBC7D0 Offset: 0x1CB87D0 VA: 0x1CBC7D0 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CBC7DC Offset: 0x1CB87DC VA: 0x1CBC7DC Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBC834 Offset: 0x1CB8834 VA: 0x1CBC834 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBC83C Offset: 0x1CB883C VA: 0x1CBC83C Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1CBC844 Offset: 0x1CB8844 VA: 0x1CBC844 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CBC84C Offset: 0x1CB884C VA: 0x1CBC84C Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBC8A4 Offset: 0x1CB88A4 VA: 0x1CBC8A4 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBC8FC Offset: 0x1CB88FC VA: 0x1CBC8FC Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CBC904 Offset: 0x1CB8904 VA: 0x1CBC904 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB4E18 Offset: 0x1CB0E18 VA: 0x1CB4E18
	public void .ctor() { }

	// RVA: 0x1CBCB64 Offset: 0x1CB8B64 VA: 0x1CBCB64
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedString : Datatype_string // TypeDefIndex: 3449
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1CBCC2C Offset: 0x1CB8C2C VA: 0x1CBCC2C Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBCC34 Offset: 0x1CB8C34 VA: 0x1CBCC34 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CBCC3C Offset: 0x1CB8C3C VA: 0x1CBCC3C Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1CB4D6C Offset: 0x1CB0D6C VA: 0x1CB4D6C
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_normalizedStringV1Compat : Datatype_string // TypeDefIndex: 3450
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1CBCC44 Offset: 0x1CB8C44 VA: 0x1CBCC44 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBCC4C Offset: 0x1CB8C4C VA: 0x1CBCC4C Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1CB52C8 Offset: 0x1CB12C8 VA: 0x1CB52C8
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_token : Datatype_normalizedString // TypeDefIndex: 3451
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x1CBCC54 Offset: 0x1CB8C54 VA: 0x1CBCC54 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBCC5C Offset: 0x1CB8C5C VA: 0x1CBCC5C Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CB5070 Offset: 0x1CB1070 VA: 0x1CB5070
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_tokenV1Compat : Datatype_normalizedStringV1Compat // TypeDefIndex: 3452
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBCC64 Offset: 0x1CB8C64 VA: 0x1CBCC64 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB52CC Offset: 0x1CB12CC VA: 0x1CB52CC
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_language : Datatype_token // TypeDefIndex: 3453
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBCC6C Offset: 0x1CB8C6C VA: 0x1CBCC6C Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB4C4C Offset: 0x1CB0C4C VA: 0x1CB4C4C
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_NMTOKEN : Datatype_token // TypeDefIndex: 3454
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x1CBCC74 Offset: 0x1CB8C74 VA: 0x1CBCC74 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBCC7C Offset: 0x1CB8C7C VA: 0x1CBCC7C Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1CB4D60 Offset: 0x1CB0D60 VA: 0x1CB4D60
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_Name : Datatype_token // TypeDefIndex: 3455
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBCC84 Offset: 0x1CB8C84 VA: 0x1CBCC84 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB4D04 Offset: 0x1CB0D04 VA: 0x1CB4D04
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_NCName : Datatype_Name // TypeDefIndex: 3456
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBCC8C Offset: 0x1CB8C8C VA: 0x1CBCC8C Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBCC94 Offset: 0x1CB8C94 VA: 0x1CBCC94 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB4D08 Offset: 0x1CB0D08 VA: 0x1CB4D08
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_ID : Datatype_NCName // TypeDefIndex: 3457
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x1CBCDA4 Offset: 0x1CB8DA4 VA: 0x1CBCDA4 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBCDAC Offset: 0x1CB8DAC VA: 0x1CBCDAC Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1CB4B9C Offset: 0x1CB0B9C VA: 0x1CB4B9C
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_IDREF : Datatype_NCName // TypeDefIndex: 3458
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x1CBCDB4 Offset: 0x1CB8DB4 VA: 0x1CBCDB4 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBCDBC Offset: 0x1CB8DBC VA: 0x1CBCDBC Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1CB4BA0 Offset: 0x1CB0BA0 VA: 0x1CB4BA0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_ENTITY : Datatype_NCName // TypeDefIndex: 3459
{
	// Properties
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x1CBCDC4 Offset: 0x1CB8DC4 VA: 0x1CBCDC4 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBCDCC Offset: 0x1CB8DCC VA: 0x1CBCDCC Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1CB48A4 Offset: 0x1CB08A4 VA: 0x1CB48A4
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_NOTATION : Datatype_anySimpleType // TypeDefIndex: 3460
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override XmlTokenizedType TokenizedType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

	// Methods

	// RVA: 0x1CBCDD4 Offset: 0x1CB8DD4 VA: 0x1CBCDD4 Slot: 25
	internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType) { }

	// RVA: 0x1CBCDE0 Offset: 0x1CB8DE0 VA: 0x1CBCDE0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBCE38 Offset: 0x1CB8E38 VA: 0x1CBCE38 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBCE40 Offset: 0x1CB8E40 VA: 0x1CBCE40 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1CBCE48 Offset: 0x1CB8E48 VA: 0x1CBCE48 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CBCE50 Offset: 0x1CB8E50 VA: 0x1CBCE50 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBCEA8 Offset: 0x1CB8EA8 VA: 0x1CBCEA8 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBCF00 Offset: 0x1CB8F00 VA: 0x1CBCF00 Slot: 19
	internal override XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet() { }

	// RVA: 0x1CBCF08 Offset: 0x1CB8F08 VA: 0x1CBCF08 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CBD168 Offset: 0x1CB9168 VA: 0x1CBD168 Slot: 22
	internal override void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller) { }

	// RVA: 0x1CB4D70 Offset: 0x1CB0D70 VA: 0x1CB4D70
	public void .ctor() { }

	// RVA: 0x1CBD374 Offset: 0x1CB9374 VA: 0x1CBD374
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_integer : Datatype_decimal // TypeDefIndex: 3461
{
	// Properties
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBD43C Offset: 0x1CB943C VA: 0x1CBD43C Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBD444 Offset: 0x1CB9444 VA: 0x1CBD444 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB4BF8 Offset: 0x1CB0BF8 VA: 0x1CB4BF8
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_nonPositiveInteger : Datatype_integer // TypeDefIndex: 3462
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1CBD5A8 Offset: 0x1CB95A8 VA: 0x1CBD5A8 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBD600 Offset: 0x1CB9600 VA: 0x1CBD600 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBD608 Offset: 0x1CB9608 VA: 0x1CBD608 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1CB4D68 Offset: 0x1CB0D68 VA: 0x1CB4D68
	public void .ctor() { }

	// RVA: 0x1CBD610 Offset: 0x1CB9610 VA: 0x1CBD610
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_negativeInteger : Datatype_nonPositiveInteger // TypeDefIndex: 3463
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBD728 Offset: 0x1CB9728 VA: 0x1CBD728 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBD780 Offset: 0x1CB9780 VA: 0x1CBD780 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB4D0C Offset: 0x1CB0D0C VA: 0x1CB4D0C
	public void .ctor() { }

	// RVA: 0x1CBD788 Offset: 0x1CB9788 VA: 0x1CBD788
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_long : Datatype_integer // TypeDefIndex: 3464
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	internal override bool HasValueFacets { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1CBD8A0 Offset: 0x1CB98A0 VA: 0x1CBD8A0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBD8F8 Offset: 0x1CB98F8 VA: 0x1CBD8F8 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1CBD900 Offset: 0x1CB9900 VA: 0x1CBD900 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBD908 Offset: 0x1CB9908 VA: 0x1CBD908 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CBD978 Offset: 0x1CB9978 VA: 0x1CBD978 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBD9D0 Offset: 0x1CB99D0 VA: 0x1CBD9D0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBDA28 Offset: 0x1CB9A28 VA: 0x1CBDA28 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB4C50 Offset: 0x1CB0C50 VA: 0x1CB4C50
	public void .ctor() { }

	// RVA: 0x1CBDB74 Offset: 0x1CB9B74 VA: 0x1CBDB74
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_int : Datatype_long // TypeDefIndex: 3465
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1CBDCD8 Offset: 0x1CB9CD8 VA: 0x1CBDCD8 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBDD30 Offset: 0x1CB9D30 VA: 0x1CBDD30 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBDD38 Offset: 0x1CB9D38 VA: 0x1CBDD38 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CBDDA8 Offset: 0x1CB9DA8 VA: 0x1CBDDA8 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBDE00 Offset: 0x1CB9E00 VA: 0x1CBDE00 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBDE58 Offset: 0x1CB9E58 VA: 0x1CBDE58 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB4BA4 Offset: 0x1CB0BA4 VA: 0x1CB4BA4
	public void .ctor() { }

	// RVA: 0x1CBDFA4 Offset: 0x1CB9FA4 VA: 0x1CBDFA4
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_short : Datatype_int // TypeDefIndex: 3466
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1CBE108 Offset: 0x1CBA108 VA: 0x1CBE108 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBE160 Offset: 0x1CBA160 VA: 0x1CBE160 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBE168 Offset: 0x1CBA168 VA: 0x1CBE168 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CBE1D8 Offset: 0x1CBA1D8 VA: 0x1CBE1D8 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBE230 Offset: 0x1CBA230 VA: 0x1CBE230 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBE288 Offset: 0x1CBA288 VA: 0x1CBE288 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB4EC0 Offset: 0x1CB0EC0 VA: 0x1CB4EC0
	public void .ctor() { }

	// RVA: 0x1CBE3D4 Offset: 0x1CBA3D4 VA: 0x1CBE3D4
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_byte : Datatype_short // TypeDefIndex: 3467
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1CBE538 Offset: 0x1CBA538 VA: 0x1CBE538 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBE590 Offset: 0x1CBA590 VA: 0x1CBE590 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBE598 Offset: 0x1CBA598 VA: 0x1CBE598 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CBE608 Offset: 0x1CBA608 VA: 0x1CBE608 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBE660 Offset: 0x1CBA660 VA: 0x1CBE660 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBE6B8 Offset: 0x1CBA6B8 VA: 0x1CBE6B8 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB44F4 Offset: 0x1CB04F4 VA: 0x1CB44F4
	public void .ctor() { }

	// RVA: 0x1CBE804 Offset: 0x1CBA804 VA: 0x1CBE804
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_nonNegativeInteger : Datatype_integer // TypeDefIndex: 3468
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	internal override bool HasValueFacets { get; }

	// Methods

	// RVA: 0x1CBE968 Offset: 0x1CBA968 VA: 0x1CBE968 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBE9C0 Offset: 0x1CBA9C0 VA: 0x1CBE9C0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBE9C8 Offset: 0x1CBA9C8 VA: 0x1CBE9C8 Slot: 11
	internal override bool get_HasValueFacets() { }

	// RVA: 0x1CB4D64 Offset: 0x1CB0D64 VA: 0x1CB4D64
	public void .ctor() { }

	// RVA: 0x1CBE9D0 Offset: 0x1CBA9D0 VA: 0x1CBE9D0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedLong : Datatype_nonNegativeInteger // TypeDefIndex: 3469
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1CBEAE8 Offset: 0x1CBAAE8 VA: 0x1CBEAE8 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBEB40 Offset: 0x1CBAB40 VA: 0x1CBEB40 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBEB48 Offset: 0x1CBAB48 VA: 0x1CBEB48 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CBEBB8 Offset: 0x1CBABB8 VA: 0x1CBEBB8 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBEC10 Offset: 0x1CBAC10 VA: 0x1CBEC10 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBEC68 Offset: 0x1CBAC68 VA: 0x1CBEC68 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB511C Offset: 0x1CB111C VA: 0x1CB511C
	public void .ctor() { }

	// RVA: 0x1CBEDFC Offset: 0x1CBADFC VA: 0x1CBEDFC
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedInt : Datatype_unsignedLong // TypeDefIndex: 3470
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1CBEF78 Offset: 0x1CBAF78 VA: 0x1CBEF78 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBEFD0 Offset: 0x1CBAFD0 VA: 0x1CBEFD0 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBEFD8 Offset: 0x1CBAFD8 VA: 0x1CBEFD8 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CBF048 Offset: 0x1CBB048 VA: 0x1CBF048 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBF0A0 Offset: 0x1CBB0A0 VA: 0x1CBF0A0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBF0F8 Offset: 0x1CBB0F8 VA: 0x1CBF0F8 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB50C8 Offset: 0x1CB10C8 VA: 0x1CB50C8
	public void .ctor() { }

	// RVA: 0x1CBF244 Offset: 0x1CBB244 VA: 0x1CBF244
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedShort : Datatype_unsignedInt // TypeDefIndex: 3471
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1CBF3C0 Offset: 0x1CBB3C0 VA: 0x1CBF3C0 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBF418 Offset: 0x1CBB418 VA: 0x1CBF418 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBF420 Offset: 0x1CBB420 VA: 0x1CBF420 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CBF490 Offset: 0x1CBB490 VA: 0x1CBF490 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBF4E8 Offset: 0x1CBB4E8 VA: 0x1CBF4E8 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBF540 Offset: 0x1CBB540 VA: 0x1CBF540 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB5170 Offset: 0x1CB1170 VA: 0x1CB5170
	public void .ctor() { }

	// RVA: 0x1CBF68C Offset: 0x1CBB68C VA: 0x1CBF68C
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_unsignedByte : Datatype_unsignedShort // TypeDefIndex: 3472
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x10

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1CBF808 Offset: 0x1CBB808 VA: 0x1CBF808 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBF860 Offset: 0x1CBB860 VA: 0x1CBF860 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CBF868 Offset: 0x1CBB868 VA: 0x1CBF868 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CBF8D8 Offset: 0x1CBB8D8 VA: 0x1CBF8D8 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CBF930 Offset: 0x1CBB930 VA: 0x1CBF930 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CBF988 Offset: 0x1CBB988 VA: 0x1CBF988 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB5074 Offset: 0x1CB1074 VA: 0x1CB5074
	public void .ctor() { }

	// RVA: 0x1CBFAD4 Offset: 0x1CBBAD4 VA: 0x1CBFAD4
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_positiveInteger : Datatype_nonNegativeInteger // TypeDefIndex: 3473
{
	// Fields
	private static readonly FacetsChecker numeric10FacetsChecker; // 0x0

	// Properties
	internal override FacetsChecker FacetsChecker { get; }
	public override XmlTypeCode TypeCode { get; }

	// Methods

	// RVA: 0x1CBFC50 Offset: 0x1CBBC50 VA: 0x1CBFC50 Slot: 18
	internal override FacetsChecker get_FacetsChecker() { }

	// RVA: 0x1CBFCA8 Offset: 0x1CBBCA8 VA: 0x1CBFCA8 Slot: 8
	public override XmlTypeCode get_TypeCode() { }

	// RVA: 0x1CB4DC4 Offset: 0x1CB0DC4 VA: 0x1CB4DC4
	public void .ctor() { }

	// RVA: 0x1CBFCB0 Offset: 0x1CBBCB0 VA: 0x1CBFCB0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_doubleXdr : Datatype_double // TypeDefIndex: 3474
{
	// Methods

	// RVA: 0x1CBFDC8 Offset: 0x1CBBDC8 VA: 0x1CBFDC8 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1CB47FC Offset: 0x1CB07FC VA: 0x1CB47FC
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_floatXdr : Datatype_float // TypeDefIndex: 3475
{
	// Methods

	// RVA: 0x1CBFFA4 Offset: 0x1CBBFA4 VA: 0x1CBFFA4 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1CB4AF4 Offset: 0x1CB0AF4 VA: 0x1CB4AF4
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_QNameXdr : Datatype_anySimpleType // TypeDefIndex: 3476
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override XmlTokenizedType TokenizedType { get; }
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }

	// Methods

	// RVA: 0x1CC0180 Offset: 0x1CBC180 VA: 0x1CC0180 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1CC0188 Offset: 0x1CBC188 VA: 0x1CC0188 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1CC0430 Offset: 0x1CBC430 VA: 0x1CC0430 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CC0488 Offset: 0x1CBC488 VA: 0x1CC0488 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CB4E6C Offset: 0x1CB0E6C VA: 0x1CB4E6C
	public void .ctor() { }

	// RVA: 0x1CC04E0 Offset: 0x1CBC4E0 VA: 0x1CC04E0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_ENUMERATION : Datatype_NMTOKEN // TypeDefIndex: 3477
{
	// Properties
	public override XmlTokenizedType TokenizedType { get; }

	// Methods

	// RVA: 0x1CC05A8 Offset: 0x1CBC5A8 VA: 0x1CC05A8 Slot: 5
	public override XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1CB4A48 Offset: 0x1CB0A48 VA: 0x1CB4A48
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_char : Datatype_anySimpleType // TypeDefIndex: 3478
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1CC05B0 Offset: 0x1CBC5B0 VA: 0x1CC05B0 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CC0608 Offset: 0x1CBC608 VA: 0x1CC0608 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CC0660 Offset: 0x1CBC660 VA: 0x1CC0660 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CC0668 Offset: 0x1CBC668 VA: 0x1CC0668 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CC06EC Offset: 0x1CBC6EC VA: 0x1CC06EC Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1CC08EC Offset: 0x1CBC8EC VA: 0x1CC08EC Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB4548 Offset: 0x1CB0548 VA: 0x1CB4548
	public void .ctor() { }

	// RVA: 0x1CC09A4 Offset: 0x1CBC9A4 VA: 0x1CC09A4
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_fixed : Datatype_decimal // TypeDefIndex: 3479
{
	// Methods

	// RVA: 0x1CC0A58 Offset: 0x1CBCA58 VA: 0x1CC0A58 Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1CC0FFC Offset: 0x1CBCFFC VA: 0x1CC0FFC Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB4A4C Offset: 0x1CB0A4C VA: 0x1CB4A4C
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Datatype_uuid : Datatype_anySimpleType // TypeDefIndex: 3480
{
	// Fields
	private static readonly Type atomicValueType; // 0x0
	private static readonly Type listValueType; // 0x8

	// Properties
	public override Type ValueType { get; }
	internal override Type ListValueType { get; }
	internal override RestrictionFlags ValidRestrictionFlags { get; }

	// Methods

	// RVA: 0x1CC1178 Offset: 0x1CBD178 VA: 0x1CC1178 Slot: 4
	public override Type get_ValueType() { }

	// RVA: 0x1CC11D0 Offset: 0x1CBD1D0 VA: 0x1CC11D0 Slot: 26
	internal override Type get_ListValueType() { }

	// RVA: 0x1CC1228 Offset: 0x1CBD228 VA: 0x1CC1228 Slot: 27
	internal override RestrictionFlags get_ValidRestrictionFlags() { }

	// RVA: 0x1CC1230 Offset: 0x1CBD230 VA: 0x1CC1230 Slot: 14
	internal override int Compare(object value1, object value2) { }

	// RVA: 0x1CC12CC Offset: 0x1CBD2CC VA: 0x1CC12CC Slot: 6
	public override object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr) { }

	// RVA: 0x1CC14D8 Offset: 0x1CBD4D8 VA: 0x1CC14D8 Slot: 16
	internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue) { }

	// RVA: 0x1CB51C4 Offset: 0x1CB11C4 VA: 0x1CB51C4
	public void .ctor() { }

	// RVA: 0x1CC15A4 Offset: 0x1CBD5A4 VA: 0x1CC15A4
	private static void .cctor() { }
}

// Namespace: 
private class DtdValidator.NamespaceManager : XmlNamespaceManager // TypeDefIndex: 3481
{
	// Methods

	// RVA: 0x1CC3BC4 Offset: 0x1CBFBC4 VA: 0x1CC3BC4 Slot: 16
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1CC3BBC Offset: 0x1CBFBBC VA: 0x1CC3BBC
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class DtdValidator : BaseValidator // TypeDefIndex: 3482
{
	// Fields
	private static DtdValidator.NamespaceManager namespaceManager; // 0x0
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private Hashtable IDs; // 0x98
	private IdRefNode idRefListHead; // 0xA0
	private bool processIdentityConstraints; // 0xA8

	// Properties
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x1CC166C Offset: 0x1CBD66C VA: 0x1CC166C
	internal void .ctor(XmlValidatingReaderImpl reader, IValidationEventHandling eventHandling, bool processIdentityConstraints) { }

	// RVA: 0x1CC1714 Offset: 0x1CBD714 VA: 0x1CC1714
	private void Init() { }

	// RVA: 0x1CC19A8 Offset: 0x1CBD9A8 VA: 0x1CC19A8 Slot: 5
	public override void Validate() { }

	// RVA: 0x1CC1CD0 Offset: 0x1CBDCD0 VA: 0x1CC1CD0
	private bool MeetsStandAloneConstraint() { }

	// RVA: 0x1CC1D70 Offset: 0x1CBDD70 VA: 0x1CC1D70
	private void ValidatePIComment() { }

	// RVA: 0x1CC1BC8 Offset: 0x1CBDBC8 VA: 0x1CC1BC8
	private void ValidateElement() { }

	// RVA: 0x1CC2114 Offset: 0x1CBE114 VA: 0x1CC2114
	private void ValidateChildElement() { }

	// RVA: 0x1CC237C Offset: 0x1CBE37C VA: 0x1CC237C
	private void ValidateStartElement() { }

	// RVA: 0x1CC2D30 Offset: 0x1CBED30 VA: 0x1CC2D30
	private void ValidateEndStartElement() { }

	// RVA: 0x1CC225C Offset: 0x1CBE25C VA: 0x1CC225C
	private void ProcessElement() { }

	// RVA: 0x1CC2EEC Offset: 0x1CBEEEC VA: 0x1CC2EEC Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x1CC1F74 Offset: 0x1CBDF74 VA: 0x1CC1F74
	private void ValidateEndElement() { }

	// RVA: 0x1CC3110 Offset: 0x1CBF110 VA: 0x1CC3110 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1CC3148 Offset: 0x1CBF148 VA: 0x1CC3148
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1CC27D8 Offset: 0x1CBE7D8 VA: 0x1CC27D8
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1CC337C Offset: 0x1CBF37C VA: 0x1CC337C
	internal void AddID(string name, object node) { }

	// RVA: 0x1CC3418 Offset: 0x1CBF418 VA: 0x1CC3418 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1CC1E20 Offset: 0x1CBDE20 VA: 0x1CC1E20
	private bool GenEntity(XmlQualifiedName qname) { }

	// RVA: 0x1CC3434 Offset: 0x1CBF434 VA: 0x1CC3434
	private SchemaEntity GetEntity(XmlQualifiedName qname, bool fParameterEntity) { }

	// RVA: 0x1CC2FEC Offset: 0x1CBEFEC VA: 0x1CC2FEC
	private void CheckForwardRefs() { }

	// RVA: 0x1CC1880 Offset: 0x1CBD880 VA: 0x1CC1880
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1CC2F34 Offset: 0x1CBEF34 VA: 0x1CC2F34
	private bool Pop() { }

	// RVA: 0x1CC34D4 Offset: 0x1CBF4D4 VA: 0x1CC34D4
	public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter) { }

	// RVA: 0x1CC37D0 Offset: 0x1CBF7D0 VA: 0x1CC37D0
	public static void CheckDefaultValue(SchemaAttDef attdef, SchemaInfo sinfo, IValidationEventHandling eventHandling, string baseUriStr) { }

	// RVA: 0x1CC3B40 Offset: 0x1CBFB40 VA: 0x1CC3B40
	private static void .cctor() { }
}

// Namespace: 
private struct FacetsChecker.FacetsCompiler.Map // TypeDefIndex: 3483
{
	// Fields
	internal char match; // 0x0
	internal string replacement; // 0x8

	// Methods

	// RVA: 0x1CC7BB4 Offset: 0x1CC3BB4 VA: 0x1CC7BB4
	internal void .ctor(char m, string r) { }
}

// Namespace: 
private struct FacetsChecker.FacetsCompiler // TypeDefIndex: 3484
{
	// Fields
	private DatatypeImplementation datatype; // 0x0
	private RestrictionFacets derivedRestriction; // 0x8
	private RestrictionFlags baseFlags; // 0x10
	private RestrictionFlags baseFixedFlags; // 0x14
	private RestrictionFlags validRestrictionFlags; // 0x18
	private XmlSchemaDatatype nonNegativeInt; // 0x20
	private XmlSchemaDatatype builtInType; // 0x28
	private XmlTypeCode builtInEnum; // 0x30
	private bool firstPattern; // 0x34
	private StringBuilder regStr; // 0x38
	private XmlSchemaPatternFacet pattern_facet; // 0x40
	private static readonly FacetsChecker.FacetsCompiler.Map[] c_map; // 0x0

	// Methods

	// RVA: 0x1CC4330 Offset: 0x1CC0330 VA: 0x1CC4330
	public void .ctor(DatatypeImplementation baseDatatype, RestrictionFacets restriction) { }

	// RVA: 0x1CC457C Offset: 0x1CC057C VA: 0x1CC457C
	internal void CompileLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1CC48D0 Offset: 0x1CC08D0 VA: 0x1CC48D0
	internal void CompileMinLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1CC4BE8 Offset: 0x1CC0BE8 VA: 0x1CC4BE8
	internal void CompileMaxLengthFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1CC4F00 Offset: 0x1CC0F00 VA: 0x1CC4F00
	internal void CompilePatternFacet(XmlSchemaPatternFacet facet) { }

	// RVA: 0x1CC5084 Offset: 0x1CC1084 VA: 0x1CC5084
	internal void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x1CC51DC Offset: 0x1CC11DC VA: 0x1CC51DC
	internal void CompileWhitespaceFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1CC58EC Offset: 0x1CC18EC VA: 0x1CC58EC
	internal void CompileMaxInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1CC5ABC Offset: 0x1CC1ABC VA: 0x1CC5ABC
	internal void CompileMaxExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1CC554C Offset: 0x1CC154C VA: 0x1CC554C
	internal void CompileMinInclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1CC571C Offset: 0x1CC171C VA: 0x1CC571C
	internal void CompileMinExclusiveFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1CC5C8C Offset: 0x1CC1C8C VA: 0x1CC5C8C
	internal void CompileTotalDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1CC5F9C Offset: 0x1CC1F9C VA: 0x1CC5F9C
	internal void CompileFractionDigitsFacet(XmlSchemaFacet facet) { }

	// RVA: 0x1CC6250 Offset: 0x1CC2250 VA: 0x1CC6250
	internal void FinishFacetCompile() { }

	// RVA: 0x1CC6D70 Offset: 0x1CC2D70 VA: 0x1CC6D70
	private void CheckValue(object value, XmlSchemaFacet facet) { }

	// RVA: 0x1CC65C4 Offset: 0x1CC25C4 VA: 0x1CC65C4
	internal void CompileFacetCombinations() { }

	// RVA: 0x1CC7464 Offset: 0x1CC3464 VA: 0x1CC7464
	private void CopyFacetsFromBaseType() { }

	// RVA: 0x1CC6BC4 Offset: 0x1CC2BC4 VA: 0x1CC6BC4
	private object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable) { }

	// RVA: 0x1CC7208 Offset: 0x1CC3208 VA: 0x1CC7208
	private static string Preprocess(string pattern) { }

	// RVA: 0x1CC6AD4 Offset: 0x1CC2AD4 VA: 0x1CC6AD4
	private void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x1CC6B54 Offset: 0x1CC2B54 VA: 0x1CC6B54
	private void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode) { }

	// RVA: 0x1CC6D08 Offset: 0x1CC2D08 VA: 0x1CC6D08
	private void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag) { }

	// RVA: 0x1CC7870 Offset: 0x1CC3870 VA: 0x1CC7870
	private void SetFlag(RestrictionFlags flag) { }

	// RVA: 0x1CC78A8 Offset: 0x1CC38A8 VA: 0x1CC78A8
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal abstract class FacetsChecker // TypeDefIndex: 3485
{
	// Methods

	// RVA: 0x1CC3BCC Offset: 0x1CBFBCC VA: 0x1CC3BCC Slot: 4
	internal virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC3E58 Offset: 0x1CBFE58 VA: 0x1CC3E58 Slot: 5
	internal virtual Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC3E60 Offset: 0x1CBFE60 VA: 0x1CC3E60 Slot: 6
	internal virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC3E68 Offset: 0x1CBFE68 VA: 0x1CC3E68 Slot: 7
	internal virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC3E70 Offset: 0x1CBFE70 VA: 0x1CC3E70 Slot: 8
	internal virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC3E78 Offset: 0x1CBFE78 VA: 0x1CC3E78 Slot: 9
	internal virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC3E80 Offset: 0x1CBFE80 VA: 0x1CC3E80 Slot: 10
	internal virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC3E88 Offset: 0x1CBFE88 VA: 0x1CC3E88 Slot: 11
	internal virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC3E90 Offset: 0x1CBFE90 VA: 0x1CC3E90 Slot: 12
	internal virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC3E98 Offset: 0x1CBFE98 VA: 0x1CC3E98 Slot: 13
	internal virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC3EA0 Offset: 0x1CBFEA0 VA: 0x1CC3EA0 Slot: 14
	internal virtual Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC3EA8 Offset: 0x1CBFEA8 VA: 0x1CC3EA8 Slot: 15
	internal virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC3EB0 Offset: 0x1CBFEB0 VA: 0x1CC3EB0 Slot: 16
	internal virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC3C10 Offset: 0x1CBFC10 VA: 0x1CC3C10
	internal void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC3D08 Offset: 0x1CBFD08 VA: 0x1CC3D08
	internal Exception CheckPatternFacets(RestrictionFacets restriction, string value) { }

	// RVA: 0x1CC3EB8 Offset: 0x1CBFEB8 VA: 0x1CC3EB8 Slot: 17
	internal virtual bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC3EC0 Offset: 0x1CBFEC0 VA: 0x1CC3EC0 Slot: 18
	internal virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable) { }

	// RVA: 0x1CC69A0 Offset: 0x1CC29A0 VA: 0x1CC69A0
	internal static Decimal Power(int x, int y) { }

	// RVA: 0x1CC6ACC Offset: 0x1CC2ACC VA: 0x1CC6ACC
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class Numeric10FacetsChecker : FacetsChecker // TypeDefIndex: 3486
{
	// Fields
	private static readonly char[] signs; // 0x0
	private Decimal maxValue; // 0x10
	private Decimal minValue; // 0x20

	// Methods

	// RVA: 0x1CBA8B0 Offset: 0x1CB68B0 VA: 0x1CBA8B0
	internal void .ctor(Decimal minVal, Decimal maxVal) { }

	// RVA: 0x1CC7BC4 Offset: 0x1CC3BC4 VA: 0x1CC7BC4 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC7C34 Offset: 0x1CC3C34 VA: 0x1CC7C34 Slot: 6
	internal override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC8360 Offset: 0x1CC4360 VA: 0x1CC8360 Slot: 7
	internal override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC83EC Offset: 0x1CC43EC VA: 0x1CC83EC Slot: 8
	internal override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC8478 Offset: 0x1CC4478 VA: 0x1CC8478 Slot: 9
	internal override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC8504 Offset: 0x1CC4504 VA: 0x1CC8504 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC823C Offset: 0x1CC423C VA: 0x1CC823C
	internal bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x1CC0D70 Offset: 0x1CBCD70 VA: 0x1CC0D70
	internal Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction) { }

	// RVA: 0x1CC8588 Offset: 0x1CC4588 VA: 0x1CC8588
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class Numeric2FacetsChecker : FacetsChecker // TypeDefIndex: 3487
{
	// Methods

	// RVA: 0x1CC8628 Offset: 0x1CC4628 VA: 0x1CC8628 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC8688 Offset: 0x1CC4688 VA: 0x1CC8688 Slot: 11
	internal override Exception CheckValueFacets(double value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC89F8 Offset: 0x1CC49F8 VA: 0x1CC89F8 Slot: 12
	internal override Exception CheckValueFacets(float value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC8A08 Offset: 0x1CC4A08 VA: 0x1CC8A08 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC8934 Offset: 0x1CC4934 VA: 0x1CC8934
	private bool MatchEnumeration(double value, ArrayList enumeration, XmlValueConverter valueConverter) { }

	// RVA: 0x1CB4388 Offset: 0x1CB0388 VA: 0x1CB4388
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class DurationFacetsChecker : FacetsChecker // TypeDefIndex: 3488
{
	// Methods

	// RVA: 0x1CC8A80 Offset: 0x1CC4A80 VA: 0x1CC8A80 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC8B88 Offset: 0x1CC4B88 VA: 0x1CC8B88 Slot: 15
	internal override Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC8FF4 Offset: 0x1CC4FF4 VA: 0x1CC8FF4 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC8EDC Offset: 0x1CC4EDC VA: 0x1CC8EDC
	private bool MatchEnumeration(TimeSpan value, ArrayList enumeration) { }

	// RVA: 0x1CB4398 Offset: 0x1CB0398 VA: 0x1CB4398
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class DateTimeFacetsChecker : FacetsChecker // TypeDefIndex: 3489
{
	// Methods

	// RVA: 0x1CC906C Offset: 0x1CC506C VA: 0x1CC906C Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC90D0 Offset: 0x1CC50D0 VA: 0x1CC90D0 Slot: 10
	internal override Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC95F8 Offset: 0x1CC55F8 VA: 0x1CC95F8 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC94B8 Offset: 0x1CC54B8 VA: 0x1CC94B8
	private bool MatchEnumeration(DateTime value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CB4390 Offset: 0x1CB0390 VA: 0x1CB4390
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class StringFacetsChecker : FacetsChecker // TypeDefIndex: 3490
{
	// Fields
	private static Regex languagePattern; // 0x0

	// Properties
	private static Regex LanguagePattern { get; }

	// Methods

	// RVA: 0x1CC9654 Offset: 0x1CC5654 VA: 0x1CC9654
	private static Regex get_LanguagePattern() { }

	// RVA: 0x1CC9704 Offset: 0x1CC5704 VA: 0x1CC9704 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC9764 Offset: 0x1CC5764 VA: 0x1CC9764 Slot: 13
	internal override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CBC4E0 Offset: 0x1CB84E0 VA: 0x1CBC4E0
	internal Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri) { }

	// RVA: 0x1CC9BC8 Offset: 0x1CC5BC8 VA: 0x1CC9BC8 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC99F8 Offset: 0x1CC59F8 VA: 0x1CC99F8
	private bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1CC976C Offset: 0x1CC576C VA: 0x1CC976C
	private Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri) { }

	// RVA: 0x1CB4380 Offset: 0x1CB0380 VA: 0x1CB4380
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class QNameFacetsChecker : FacetsChecker // TypeDefIndex: 3491
{
	// Methods

	// RVA: 0x1B6B3D0 Offset: 0x1B673D0 VA: 0x1B6B3D0 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1B6B4F0 Offset: 0x1B674F0 VA: 0x1B6B4F0 Slot: 16
	internal override Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1B6B7D8 Offset: 0x1B677D8 VA: 0x1B6B7D8 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1B6B6C4 Offset: 0x1B676C4 VA: 0x1B6B6C4
	private bool MatchEnumeration(XmlQualifiedName value, ArrayList enumeration) { }

	// RVA: 0x1B6B8E0 Offset: 0x1B678E0 VA: 0x1B6B8E0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class MiscFacetsChecker : FacetsChecker // TypeDefIndex: 3492
{
	// Methods

	// RVA: 0x1B6B8E8 Offset: 0x1B678E8 VA: 0x1B6B8E8
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class BinaryFacetsChecker : FacetsChecker // TypeDefIndex: 3493
{
	// Methods

	// RVA: 0x1B6B8F0 Offset: 0x1B678F0 VA: 0x1B6B8F0 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1B6B980 Offset: 0x1B67980 VA: 0x1B6B980 Slot: 14
	internal override Exception CheckValueFacets(byte[] value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1B6BC64 Offset: 0x1B67C64 VA: 0x1B6BC64 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1B6BB40 Offset: 0x1B67B40 VA: 0x1B6BB40
	private bool MatchEnumeration(byte[] value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1B6BCE8 Offset: 0x1B67CE8 VA: 0x1B6BCE8
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class ListFacetsChecker : FacetsChecker // TypeDefIndex: 3494
{
	// Methods

	// RVA: 0x1B6BCF0 Offset: 0x1B67CF0 VA: 0x1B6BCF0 Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1B6BF08 Offset: 0x1B67F08 VA: 0x1B6BF08 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1B6BFC4 Offset: 0x1B67FC4 VA: 0x1B6BFC4
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class UnionFacetsChecker : FacetsChecker // TypeDefIndex: 3495
{
	// Methods

	// RVA: 0x1B6BFCC Offset: 0x1B67FCC VA: 0x1B6BFCC Slot: 5
	internal override Exception CheckValueFacets(object value, XmlSchemaDatatype datatype) { }

	// RVA: 0x1B6C0B8 Offset: 0x1B680B8 VA: 0x1B6C0B8 Slot: 17
	internal override bool MatchEnumeration(object value, ArrayList enumeration, XmlSchemaDatatype datatype) { }

	// RVA: 0x1B6C174 Offset: 0x1B68174 VA: 0x1B6C174
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public interface IXmlSchemaInfo // TypeDefIndex: 3496
{
	// Properties
	public abstract XmlSchemaValidity Validity { get; }
	public abstract bool IsDefault { get; }
	public abstract bool IsNil { get; }
	public abstract XmlSchemaSimpleType MemberType { get; }
	public abstract XmlSchemaType SchemaType { get; }
	public abstract XmlSchemaElement SchemaElement { get; }
	public abstract XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlSchemaValidity get_Validity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsDefault();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsNil();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract XmlSchemaSimpleType get_MemberType();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract XmlSchemaType get_SchemaType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XmlSchemaElement get_SchemaElement();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlSchemaAttribute get_SchemaAttribute();
}

// Namespace: 
public enum XmlSchemaInference.InferenceOption // TypeDefIndex: 3497
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaInference.InferenceOption Restricted = 0;
	public const XmlSchemaInference.InferenceOption Relaxed = 1;
}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaInference // TypeDefIndex: 3498
{
	// Fields
	internal static XmlQualifiedName ST_boolean; // 0x0
	internal static XmlQualifiedName ST_byte; // 0x8
	internal static XmlQualifiedName ST_unsignedByte; // 0x10
	internal static XmlQualifiedName ST_short; // 0x18
	internal static XmlQualifiedName ST_unsignedShort; // 0x20
	internal static XmlQualifiedName ST_int; // 0x28
	internal static XmlQualifiedName ST_unsignedInt; // 0x30
	internal static XmlQualifiedName ST_long; // 0x38
	internal static XmlQualifiedName ST_unsignedLong; // 0x40
	internal static XmlQualifiedName ST_integer; // 0x48
	internal static XmlQualifiedName ST_decimal; // 0x50
	internal static XmlQualifiedName ST_float; // 0x58
	internal static XmlQualifiedName ST_double; // 0x60
	internal static XmlQualifiedName ST_duration; // 0x68
	internal static XmlQualifiedName ST_dateTime; // 0x70
	internal static XmlQualifiedName ST_time; // 0x78
	internal static XmlQualifiedName ST_date; // 0x80
	internal static XmlQualifiedName ST_gYearMonth; // 0x88
	internal static XmlQualifiedName ST_string; // 0x90
	internal static XmlQualifiedName ST_anySimpleType; // 0x98
	internal static XmlQualifiedName[] SimpleTypes; // 0xA0
	private XmlSchema rootSchema; // 0x10
	private XmlSchemaSet schemaSet; // 0x18
	private XmlReader xtr; // 0x20
	private NameTable nametable; // 0x28
	private string TargetNamespace; // 0x30
	private XmlNamespaceManager NamespaceManager; // 0x38
	private ArrayList schemaList; // 0x40
	private XmlSchemaInference.InferenceOption occurrence; // 0x48
	private XmlSchemaInference.InferenceOption typeInference; // 0x4C

	// Properties
	public XmlSchemaInference.InferenceOption Occurrence { get; set; }
	public XmlSchemaInference.InferenceOption TypeInference { set; }

	// Methods

	// RVA: 0x1B6C17C Offset: 0x1B6817C VA: 0x1B6C17C
	public void set_Occurrence(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x1B6C184 Offset: 0x1B68184 VA: 0x1B6C184
	public XmlSchemaInference.InferenceOption get_Occurrence() { }

	// RVA: 0x1B6C18C Offset: 0x1B6818C VA: 0x1B6C18C
	public void set_TypeInference(XmlSchemaInference.InferenceOption value) { }

	// RVA: 0x1B6C194 Offset: 0x1B68194 VA: 0x1B6C194
	public void .ctor() { }

	// RVA: 0x1B6C2D0 Offset: 0x1B682D0 VA: 0x1B6C2D0
	public XmlSchemaSet InferSchema(XmlReader instanceDocument) { }

	// RVA: 0x1B6C344 Offset: 0x1B68344 VA: 0x1B6C344
	internal XmlSchemaSet InferSchema1(XmlReader instanceDocument, XmlSchemaSet schemas) { }

	// RVA: 0x1B6E7D4 Offset: 0x1B6A7D4 VA: 0x1B6E7D4
	private XmlSchemaAttribute AddAttribute(string localName, string prefix, string childURI, string attrValue, bool bCreatingNewType, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, XmlSchemaObjectTable compiledAttributes) { }

	// RVA: 0x1B71068 Offset: 0x1B6D068 VA: 0x1B71068
	private XmlSchema CreateXmlSchema(string targetNS) { }

	// RVA: 0x1B6CD58 Offset: 0x1B68D58 VA: 0x1B6CD58
	private XmlSchemaElement AddElement(string localName, string prefix, string childURI, XmlSchema parentSchema, XmlSchemaObjectCollection addLocation, int positionWithinCollection) { }

	// RVA: 0x1B6D364 Offset: 0x1B69364 VA: 0x1B6D364
	internal void InferElement(XmlSchemaElement xse, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1B71D38 Offset: 0x1B6DD38 VA: 0x1B71D38
	private XmlSchemaSimpleContentExtension CheckSimpleContentExtension(XmlSchemaComplexType ct) { }

	// RVA: 0x1B71470 Offset: 0x1B6D470 VA: 0x1B71470
	private XmlSchemaType GetEffectiveSchemaType(XmlSchemaElement elem, bool bCreatingNewType) { }

	// RVA: 0x1B722C4 Offset: 0x1B6E2C4 VA: 0x1B722C4
	internal XmlSchemaElement FindMatchingElement(bool bCreatingNewType, XmlReader xtr, XmlSchemaComplexType ct, ref int lastUsedSeqItem, ref bool bParticleChanged, XmlSchema parentSchema, bool setMaxoccurs) { }

	// RVA: 0x1B715A8 Offset: 0x1B6D5A8 VA: 0x1B715A8
	internal void ProcessAttributes(ref XmlSchemaElement xse, XmlSchemaType effectiveSchemaType, bool bCreatingNewType, XmlSchema parentSchema) { }

	// RVA: 0x1B72228 Offset: 0x1B6E228 VA: 0x1B72228
	private void MoveAttributes(XmlSchemaSimpleContentExtension scExtension, XmlSchemaComplexType ct) { }

	// RVA: 0x1B71E70 Offset: 0x1B6DE70 VA: 0x1B71E70
	private void MoveAttributes(XmlSchemaComplexType ct, XmlSchemaSimpleContentExtension simpleContentExtension, bool bCreatingNewType) { }

	// RVA: 0x1B6F390 Offset: 0x1B6B390 VA: 0x1B6F390
	internal XmlSchemaAttribute FindAttribute(ICollection attributes, string attrName) { }

	// RVA: 0x1B71104 Offset: 0x1B6D104 VA: 0x1B71104
	internal XmlSchemaElement FindGlobalElement(string namespaceURI, string localName, out XmlSchema parentSchema) { }

	// RVA: 0x1B73510 Offset: 0x1B6F510 VA: 0x1B73510
	internal XmlSchemaElement FindElement(XmlSchemaObjectCollection elements, string elementName) { }

	// RVA: 0x1B6EFF4 Offset: 0x1B6AFF4 VA: 0x1B6EFF4
	internal XmlSchemaAttribute FindAttributeRef(ICollection attributes, string attributeName, string nsURI) { }

	// RVA: 0x1B73640 Offset: 0x1B6F640 VA: 0x1B73640
	internal XmlSchemaElement FindElementRef(XmlSchemaObjectCollection elements, string elementName, string nsURI) { }

	// RVA: 0x1B71CA8 Offset: 0x1B6DCA8 VA: 0x1B71CA8
	internal void MakeExistingAttributesOptional(XmlSchemaComplexType ct, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x1B73A78 Offset: 0x1B6FA78 VA: 0x1B73A78
	private void SwitchUseToOptional(XmlSchemaObjectCollection attributes, XmlSchemaObjectCollection attributesInInstance) { }

	// RVA: 0x1B6F6E4 Offset: 0x1B6B6E4 VA: 0x1B6F6E4
	internal XmlQualifiedName RefineSimpleType(string s, ref int iTypeFlags) { }

	// RVA: 0x1B73B9C Offset: 0x1B6FB9C VA: 0x1B73B9C
	internal static int InferSimpleType(string s, ref bool bNeedsRangeCheck) { }

	// RVA: 0x1B75178 Offset: 0x1B71178 VA: 0x1B75178
	internal static int DateTime(string s, bool bDate, bool bTime) { }

	// RVA: 0x1B737A0 Offset: 0x1B6F7A0 VA: 0x1B737A0
	private XmlSchemaElement CreateNewElementforChoice(XmlSchemaElement copyElement) { }

	// RVA: 0x1B70894 Offset: 0x1B6C894 VA: 0x1B70894
	private static int GetSchemaType(XmlQualifiedName qname) { }

	// RVA: 0x1B73348 Offset: 0x1B6F348 VA: 0x1B73348
	internal void SetMinMaxOccurs(XmlSchemaElement el, bool setMaxOccurs) { }

	// RVA: 0x1B7528C Offset: 0x1B7128C VA: 0x1B7528C
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaInferenceException : XmlSchemaException // TypeDefIndex: 3499
{
	// Methods

	// RVA: 0x1B75D70 Offset: 0x1B71D70 VA: 0x1B75D70
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B75D78 Offset: 0x1B71D78 VA: 0x1B75D78 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B75D80 Offset: 0x1B71D80 VA: 0x1B75D80
	public void .ctor() { }

	// RVA: 0x1B739C4 Offset: 0x1B6F9C4 VA: 0x1B739C4
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1B6CD24 Offset: 0x1B68D24 VA: 0x1B6CD24
	internal void .ctor(string res, int lineNumber, int linePosition) { }
}

// Namespace: 
public enum NamespaceList.ListType // TypeDefIndex: 3500
{
	// Fields
	public int value__; // 0x0
	public const NamespaceList.ListType Any = 0;
	public const NamespaceList.ListType Other = 1;
	public const NamespaceList.ListType Set = 2;
}

// Namespace: System.Xml.Schema
internal class NamespaceList // TypeDefIndex: 3501
{
	// Fields
	private NamespaceList.ListType type; // 0x10
	private Hashtable set; // 0x18
	private string targetNamespace; // 0x20

	// Properties
	public NamespaceList.ListType Type { get; }
	public string Excluded { get; }
	public ICollection Enumerate { get; }

	// Methods

	// RVA: 0x1B75D8C Offset: 0x1B71D8C VA: 0x1B75D8C
	public void .ctor() { }

	// RVA: 0x1B75D94 Offset: 0x1B71D94 VA: 0x1B75D94
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x1B7603C Offset: 0x1B7203C VA: 0x1B7603C
	public NamespaceList Clone() { }

	// RVA: 0x1B76180 Offset: 0x1B72180 VA: 0x1B76180
	public NamespaceList.ListType get_Type() { }

	// RVA: 0x1B76188 Offset: 0x1B72188 VA: 0x1B76188
	public string get_Excluded() { }

	// RVA: 0x1B76190 Offset: 0x1B72190 VA: 0x1B76190
	public ICollection get_Enumerate() { }

	// RVA: 0x1B761F4 Offset: 0x1B721F4 VA: 0x1B761F4 Slot: 4
	public virtual bool Allows(string ns) { }

	// RVA: 0x1B76278 Offset: 0x1B72278 VA: 0x1B76278
	public bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x1B76294 Offset: 0x1B72294 VA: 0x1B76294 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B76734 Offset: 0x1B72734 VA: 0x1B76734
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	// RVA: 0x1B76AD4 Offset: 0x1B72AD4 VA: 0x1B76AD4
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x1B77004 Offset: 0x1B73004 VA: 0x1B77004
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	// RVA: 0x1B77144 Offset: 0x1B73144 VA: 0x1B77144
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x1B77678 Offset: 0x1B73678 VA: 0x1B77678
	private void RemoveNamespace(string tns) { }
}

// Namespace: System.Xml.Schema
internal class NamespaceListV1Compat : NamespaceList // TypeDefIndex: 3502
{
	// Methods

	// RVA: 0x1B776D8 Offset: 0x1B736D8 VA: 0x1B776D8
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x1B776DC Offset: 0x1B736DC VA: 0x1B776DC Slot: 4
	public override bool Allows(string ns) { }
}

// Namespace: System.Xml.Schema
internal sealed class Parser // TypeDefIndex: 3503
{
	// Fields
	private SchemaType schemaType; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ValidationEventHandler eventHandler; // 0x28
	private XmlNamespaceManager namespaceManager; // 0x30
	private XmlReader reader; // 0x38
	private PositionInfo positionInfo; // 0x40
	private bool isProcessNamespaces; // 0x48
	private int schemaXmlDepth; // 0x4C
	private int markupDepth; // 0x50
	private SchemaBuilder builder; // 0x58
	private XmlSchema schema; // 0x60
	private SchemaInfo xdrSchema; // 0x68
	private XmlResolver xmlResolver; // 0x70
	private XmlDocument dummyDocument; // 0x78
	private bool processMarkup; // 0x80
	private XmlNode parentNode; // 0x88
	private XmlNamespaceManager annotationNSManager; // 0x90
	private string xmlns; // 0x98
	private XmlCharType xmlCharType; // 0xA0

	// Properties
	public XmlSchema XmlSchema { get; }
	internal XmlResolver XmlResolver { set; }
	public SchemaInfo XdrSchema { get; }

	// Methods

	// RVA: 0x1B77700 Offset: 0x1B73700 VA: 0x1B77700
	public void .ctor(SchemaType schemaType, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x1B777FC Offset: 0x1B737FC VA: 0x1B777FC
	public SchemaType Parse(XmlReader reader, string targetNamespace) { }

	// RVA: 0x1B7784C Offset: 0x1B7384C VA: 0x1B7784C
	public void StartParsing(XmlReader reader, string targetNamespace) { }

	// RVA: 0x1B78318 Offset: 0x1B74318 VA: 0x1B78318
	private bool CheckSchemaRoot(SchemaType rootType, out string code) { }

	// RVA: 0x1B78434 Offset: 0x1B74434 VA: 0x1B78434
	public SchemaType FinishParsing() { }

	// RVA: 0x1B7843C Offset: 0x1B7443C VA: 0x1B7843C
	public XmlSchema get_XmlSchema() { }

	// RVA: 0x1B78444 Offset: 0x1B74444 VA: 0x1B78444
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1B7844C Offset: 0x1B7444C VA: 0x1B7844C
	public SchemaInfo get_XdrSchema() { }

	// RVA: 0x1B77C84 Offset: 0x1B73C84 VA: 0x1B77C84
	public bool ParseReaderNode() { }

	// RVA: 0x1B78454 Offset: 0x1B74454 VA: 0x1B78454
	private void ProcessAppInfoDocMarkup(bool root) { }

	// RVA: 0x1B786D0 Offset: 0x1B746D0 VA: 0x1B786D0
	private XmlElement LoadElementNode(bool root) { }

	// RVA: 0x1B78C14 Offset: 0x1B74C14 VA: 0x1B78C14
	private XmlAttribute CreateXmlNsAttribute(string prefix, string value) { }

	// RVA: 0x1B78AA0 Offset: 0x1B74AA0 VA: 0x1B78AA0
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x1B78D24 Offset: 0x1B74D24 VA: 0x1B78D24
	private XmlEntityReference LoadEntityReferenceInAttribute() { }
}

// Namespace: System.Xml.Schema
internal enum Compositor // TypeDefIndex: 3504
{
	// Fields
	public int value__; // 0x0
	public const Compositor Root = 0;
	public const Compositor Include = 1;
	public const Compositor Import = 2;
	public const Compositor Redefine = 3;
}

// Namespace: System.Xml.Schema
internal class RedefineEntry // TypeDefIndex: 3505
{
	// Fields
	internal XmlSchemaRedefine redefine; // 0x10
	internal XmlSchema schemaToUpdate; // 0x18

	// Methods

	// RVA: 0x1B78F0C Offset: 0x1B74F0C VA: 0x1B78F0C
	public void .ctor(XmlSchemaRedefine external, XmlSchema schema) { }
}

// Namespace: System.Xml.Schema
internal sealed class Preprocessor : BaseProcessor // TypeDefIndex: 3506
{
	// Fields
	private string Xmlns; // 0x40
	private string NsXsi; // 0x48
	private string targetNamespace; // 0x50
	private XmlSchema rootSchema; // 0x58
	private XmlSchema currentSchema; // 0x60
	private XmlSchemaForm elementFormDefault; // 0x68
	private XmlSchemaForm attributeFormDefault; // 0x6C
	private XmlSchemaDerivationMethod blockDefault; // 0x70
	private XmlSchemaDerivationMethod finalDefault; // 0x74
	private Hashtable schemaLocations; // 0x78
	private Hashtable chameleonSchemas; // 0x80
	private Hashtable referenceNamespaces; // 0x88
	private Hashtable processedExternals; // 0x90
	private SortedList lockList; // 0x98
	private XmlReaderSettings readerSettings; // 0xA0
	private XmlSchema rootSchemaForRedefine; // 0xA8
	private ArrayList redefinedList; // 0xB0
	private static XmlSchema builtInSchemaForXmlNS; // 0x0
	private XmlResolver xmlResolver; // 0xB8

	// Properties
	internal XmlResolver XmlResolver { set; }
	internal XmlReaderSettings ReaderSettings { set; }
	internal Hashtable SchemaLocations { set; }
	internal Hashtable ChameleonSchemas { set; }
	internal XmlSchema RootSchema { get; }

	// Methods

	// RVA: 0x1B78F50 Offset: 0x1B74F50 VA: 0x1B78F50
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x1B79050 Offset: 0x1B75050 VA: 0x1B79050
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals) { }

	// RVA: 0x1B7C2B8 Offset: 0x1B782B8 VA: 0x1B7C2B8
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x1B7C98C Offset: 0x1B7898C VA: 0x1B7C98C
	private void CleanupRedefine(XmlSchemaExternal include) { }

	// RVA: 0x1B7CA2C Offset: 0x1B78A2C VA: 0x1B7CA2C
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1B7CA34 Offset: 0x1B78A34 VA: 0x1B7CA34
	internal void set_ReaderSettings(XmlReaderSettings value) { }

	// RVA: 0x1B7CA3C Offset: 0x1B78A3C VA: 0x1B7CA3C
	internal void set_SchemaLocations(Hashtable value) { }

	// RVA: 0x1B7CA44 Offset: 0x1B78A44 VA: 0x1B7CA44
	internal void set_ChameleonSchemas(Hashtable value) { }

	// RVA: 0x1B7CA4C Offset: 0x1B78A4C VA: 0x1B7CA4C
	internal XmlSchema get_RootSchema() { }

	// RVA: 0x1B7A31C Offset: 0x1B7631C VA: 0x1B7A31C
	private void BuildSchemaList(XmlSchema schema) { }

	// RVA: 0x1B79690 Offset: 0x1B75690 VA: 0x1B79690
	private void LoadExternals(XmlSchema schema) { }

	// RVA: 0x1B7C38C Offset: 0x1B7838C VA: 0x1B7C38C
	internal static XmlSchema GetBuildInSchema() { }

	// RVA: 0x1B7CAB8 Offset: 0x1B78AB8 VA: 0x1B7CAB8
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x1B7CCCC Offset: 0x1B78CCC VA: 0x1B7CCCC
	private void ParseUri(string uri, string code, XmlSchemaObject sourceSchemaObject) { }

	// RVA: 0x1B7A488 Offset: 0x1B76488 VA: 0x1B7A488
	private void Preprocess(XmlSchema schema, string targetNamespace, ArrayList imports) { }

	// RVA: 0x1B7D2D8 Offset: 0x1B792D8 VA: 0x1B7D2D8
	private void CopyIncludedComponents(XmlSchema includedSchema, XmlSchema schema) { }

	// RVA: 0x1B7B6F0 Offset: 0x1B776F0 VA: 0x1B7B6F0
	private void PreprocessRedefine(RedefineEntry redefineEntry) { }

	// RVA: 0x1B7FCB0 Offset: 0x1B7BCB0 VA: 0x1B7FCB0
	private void GetIncludedSet(XmlSchema schema, ArrayList includesList) { }

	// RVA: 0x1B7FC1C Offset: 0x1B7BC1C VA: 0x1B7FC1C
	internal static XmlSchema GetParentSchema(XmlSchemaObject currentSchemaObject) { }

	// RVA: 0x1B7D1CC Offset: 0x1B791CC VA: 0x1B7D1CC
	private void SetSchemaDefaults(XmlSchema schema) { }

	// RVA: 0x1B80400 Offset: 0x1B7C400 VA: 0x1B80400
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name, XmlSchemaGroup redefined) { }

	// RVA: 0x1B7FDDC Offset: 0x1B7BDDC VA: 0x1B7FDDC
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x1B7FE7C Offset: 0x1B7BE7C VA: 0x1B7FE7C
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1B802F4 Offset: 0x1B7C2F4 VA: 0x1B802F4
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x1B7FFD4 Offset: 0x1B7BFD4 VA: 0x1B7FFD4
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x1B7E414 Offset: 0x1B7A414 VA: 0x1B7E414
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1B80BE0 Offset: 0x1B7CBE0 VA: 0x1B80BE0
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1B809B0 Offset: 0x1B7C9B0 VA: 0x1B809B0
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x1B7E584 Offset: 0x1B7A584 VA: 0x1B7E584
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1B7F528 Offset: 0x1B7B528 VA: 0x1B7F528
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x1B81668 Offset: 0x1B7D668 VA: 0x1B81668
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x1B81330 Offset: 0x1B7D330 VA: 0x1B81330
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x1B819E0 Offset: 0x1B7D9E0 VA: 0x1B819E0
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x1B7EF40 Offset: 0x1B7AF40 VA: 0x1B7EF40
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x1B7E688 Offset: 0x1B7A688 VA: 0x1B7E688
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x1B7F77C Offset: 0x1B7B77C VA: 0x1B7F77C
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x1B7F94C Offset: 0x1B7B94C VA: 0x1B7F94C
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x1B81D3C Offset: 0x1B7DD3C VA: 0x1B81D3C
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1B80FB8 Offset: 0x1B7CFB8 VA: 0x1B80FB8
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x1B7CECC Offset: 0x1B78ECC VA: 0x1B7CECC
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1B806F0 Offset: 0x1B7C6F0 VA: 0x1B806F0
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1B80D9C Offset: 0x1B7CD9C VA: 0x1B80D9C
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x1B7CA54 Offset: 0x1B78A54 VA: 0x1B7CA54
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x1B7CA94 Offset: 0x1B78A94 VA: 0x1B7CA94
	private object GetSchemaEntity(Uri ruri) { }

	// RVA: 0x1B79550 Offset: 0x1B75550 VA: 0x1B79550
	private XmlSchema GetChameleonSchema(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x1B7CE10 Offset: 0x1B78E10 VA: 0x1B7CE10
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x1B7CE2C Offset: 0x1B78E2C VA: 0x1B7CE2C
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x1B7FBA4 Offset: 0x1B7BBA4 VA: 0x1B7FBA4
	private void PreprocessAnnotation(XmlSchemaAnnotation annotation) { }
}

// Namespace: 
internal enum SchemaAttDef.Reserve // TypeDefIndex: 3507
{
	// Fields
	public int value__; // 0x0
	public const SchemaAttDef.Reserve None = 0;
	public const SchemaAttDef.Reserve XmlSpace = 1;
	public const SchemaAttDef.Reserve XmlLang = 2;
}

// Namespace: System.Xml.Schema
internal sealed class SchemaAttDef : SchemaDeclBase, IDtdDefaultAttributeInfo, IDtdAttributeInfo // TypeDefIndex: 3508
{
	// Fields
	private string defExpanded; // 0x60
	private int lineNum; // 0x68
	private int linePos; // 0x6C
	private int valueLineNum; // 0x70
	private int valueLinePos; // 0x74
	private SchemaAttDef.Reserve reserved; // 0x78
	private bool defaultValueChecked; // 0x7C
	private XmlSchemaAttribute schemaAttribute; // 0x80
	public static readonly SchemaAttDef Empty; // 0x0

	// Properties
	private string System.Xml.IDtdAttributeInfo.Prefix { get; }
	private string System.Xml.IDtdAttributeInfo.LocalName { get; }
	private int System.Xml.IDtdAttributeInfo.LineNumber { get; }
	private int System.Xml.IDtdAttributeInfo.LinePosition { get; }
	private bool System.Xml.IDtdAttributeInfo.IsNonCDataType { get; }
	private bool System.Xml.IDtdAttributeInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdAttributeInfo.IsXmlAttribute { get; }
	private string System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded { get; }
	private object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber { get; }
	private int System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition { get; }
	internal int LinePosition { get; set; }
	internal int LineNumber { get; set; }
	internal int ValueLinePosition { get; set; }
	internal int ValueLineNumber { get; set; }
	internal string DefaultValueExpanded { get; set; }
	internal XmlTokenizedType TokenizedType { get; set; }
	internal SchemaAttDef.Reserve Reserved { get; set; }
	internal bool DefaultValueChecked { get; }
	internal XmlSchemaAttribute SchemaAttribute { get; set; }

	// Methods

	// RVA: 0x1B8262C Offset: 0x1B7E62C VA: 0x1B8262C
	public void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x1B82634 Offset: 0x1B7E634 VA: 0x1B82634
	public void .ctor(XmlQualifiedName name) { }

	// RVA: 0x1B82640 Offset: 0x1B7E640 VA: 0x1B82640
	private void .ctor() { }

	// RVA: 0x1B82648 Offset: 0x1B7E648 VA: 0x1B82648 Slot: 8
	private string System.Xml.IDtdAttributeInfo.get_Prefix() { }

	// RVA: 0x1B82650 Offset: 0x1B7E650 VA: 0x1B82650 Slot: 9
	private string System.Xml.IDtdAttributeInfo.get_LocalName() { }

	// RVA: 0x1B82668 Offset: 0x1B7E668 VA: 0x1B82668 Slot: 10
	private int System.Xml.IDtdAttributeInfo.get_LineNumber() { }

	// RVA: 0x1B82670 Offset: 0x1B7E670 VA: 0x1B82670 Slot: 11
	private int System.Xml.IDtdAttributeInfo.get_LinePosition() { }

	// RVA: 0x1B82678 Offset: 0x1B7E678 VA: 0x1B82678 Slot: 12
	private bool System.Xml.IDtdAttributeInfo.get_IsNonCDataType() { }

	// RVA: 0x1B826C0 Offset: 0x1B7E6C0 VA: 0x1B826C0 Slot: 13
	private bool System.Xml.IDtdAttributeInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x1B826C8 Offset: 0x1B7E6C8 VA: 0x1B826C8 Slot: 14
	private bool System.Xml.IDtdAttributeInfo.get_IsXmlAttribute() { }

	// RVA: 0x1B826D8 Offset: 0x1B7E6D8 VA: 0x1B826D8 Slot: 4
	private string System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueExpanded() { }

	// RVA: 0x1B82720 Offset: 0x1B7E720 VA: 0x1B82720 Slot: 5
	private object System.Xml.IDtdDefaultAttributeInfo.get_DefaultValueTyped() { }

	// RVA: 0x1B82728 Offset: 0x1B7E728 VA: 0x1B82728 Slot: 6
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLineNumber() { }

	// RVA: 0x1B82730 Offset: 0x1B7E730 VA: 0x1B82730 Slot: 7
	private int System.Xml.IDtdDefaultAttributeInfo.get_ValueLinePosition() { }

	// RVA: 0x1B82738 Offset: 0x1B7E738 VA: 0x1B82738
	internal int get_LinePosition() { }

	// RVA: 0x1B82740 Offset: 0x1B7E740 VA: 0x1B82740
	internal void set_LinePosition(int value) { }

	// RVA: 0x1B82748 Offset: 0x1B7E748 VA: 0x1B82748
	internal int get_LineNumber() { }

	// RVA: 0x1B82750 Offset: 0x1B7E750 VA: 0x1B82750
	internal void set_LineNumber(int value) { }

	// RVA: 0x1B82758 Offset: 0x1B7E758 VA: 0x1B82758
	internal int get_ValueLinePosition() { }

	// RVA: 0x1B82760 Offset: 0x1B7E760 VA: 0x1B82760
	internal void set_ValueLinePosition(int value) { }

	// RVA: 0x1B82768 Offset: 0x1B7E768 VA: 0x1B82768
	internal int get_ValueLineNumber() { }

	// RVA: 0x1B82770 Offset: 0x1B7E770 VA: 0x1B82770
	internal void set_ValueLineNumber(int value) { }

	// RVA: 0x1B826FC Offset: 0x1B7E6FC VA: 0x1B826FC
	internal string get_DefaultValueExpanded() { }

	// RVA: 0x1B82778 Offset: 0x1B7E778 VA: 0x1B82778
	internal void set_DefaultValueExpanded(string value) { }

	// RVA: 0x1B826A4 Offset: 0x1B7E6A4 VA: 0x1B826A4
	internal XmlTokenizedType get_TokenizedType() { }

	// RVA: 0x1B82780 Offset: 0x1B7E780 VA: 0x1B82780
	internal void set_TokenizedType(XmlTokenizedType value) { }

	// RVA: 0x1B827A8 Offset: 0x1B7E7A8 VA: 0x1B827A8
	internal SchemaAttDef.Reserve get_Reserved() { }

	// RVA: 0x1B827B0 Offset: 0x1B7E7B0 VA: 0x1B827B0
	internal void set_Reserved(SchemaAttDef.Reserve value) { }

	// RVA: 0x1B827B8 Offset: 0x1B7E7B8 VA: 0x1B827B8
	internal bool get_DefaultValueChecked() { }

	// RVA: 0x1B827C0 Offset: 0x1B7E7C0 VA: 0x1B827C0
	internal XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x1B827C8 Offset: 0x1B7E7C8 VA: 0x1B827C8
	internal void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x1B827D0 Offset: 0x1B7E7D0 VA: 0x1B827D0
	internal void CheckXmlSpace(IValidationEventHandling validationEventHandling) { }

	// RVA: 0x1B82A3C Offset: 0x1B7EA3C VA: 0x1B82A3C
	internal SchemaAttDef Clone() { }

	// RVA: 0x1B82AA0 Offset: 0x1B7EAA0 VA: 0x1B82AA0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal abstract class SchemaBuilder // TypeDefIndex: 3509
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool ProcessElement(string prefix, string name, string ns);

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void ProcessAttribute(string prefix, string name, string ns, string value);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract bool IsContentParsed();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void ProcessMarkup(XmlNode[] markup);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract void ProcessCData(string value);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void StartChildren();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract void EndChildren();

	// RVA: 0x1B82B08 Offset: 0x1B7EB08 VA: 0x1B82B08
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class SchemaCollectionCompiler : BaseProcessor // TypeDefIndex: 3510
{
	// Fields
	private bool compileContentModel; // 0x40
	private XmlSchemaObjectTable examplars; // 0x48
	private Stack complexTypeStack; // 0x50
	private XmlSchema schema; // 0x58

	// Methods

	// RVA: 0x1B82B10 Offset: 0x1B7EB10 VA: 0x1B82B10
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler) { }

	// RVA: 0x1B82BD8 Offset: 0x1B7EBD8 VA: 0x1B82BD8
	public bool Execute(XmlSchema schema, SchemaInfo schemaInfo, bool compileContentModel) { }

	// RVA: 0x1B82C48 Offset: 0x1B7EC48 VA: 0x1B82C48
	private void Prepare() { }

	// RVA: 0x1B83098 Offset: 0x1B7F098 VA: 0x1B83098
	private void Cleanup() { }

	// RVA: 0x1B87078 Offset: 0x1B83078 VA: 0x1B87078
	internal static void Cleanup(XmlSchema schema) { }

	// RVA: 0x1B83E68 Offset: 0x1B7FE68 VA: 0x1B83E68
	private void Compile() { }

	// RVA: 0x1B85C2C Offset: 0x1B81C2C VA: 0x1B85C2C
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x1B87040 Offset: 0x1B83040 VA: 0x1B87040
	private static void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1B86B20 Offset: 0x1B82B20 VA: 0x1B86B20
	private static void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1B86B64 Offset: 0x1B82B64 VA: 0x1B86B64
	private static void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1B86EA4 Offset: 0x1B82EA4 VA: 0x1B86EA4
	private static void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1B86EBC Offset: 0x1B82EBC VA: 0x1B86EBC
	private static void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x1B8BCDC Offset: 0x1B87CDC VA: 0x1B8BCDC
	private static void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1B86AF4 Offset: 0x1B82AF4 VA: 0x1B86AF4
	private static void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x1B8BDA0 Offset: 0x1B87DA0 VA: 0x1B8BDA0
	private static void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1B87688 Offset: 0x1B83688 VA: 0x1B87688
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroupV1Compat substitutionGroup) { }

	// RVA: 0x1B8BB14 Offset: 0x1B87B14 VA: 0x1B8BB14
	private void CheckSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x1B87B08 Offset: 0x1B83B08 VA: 0x1B87B08
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x1B88FD4 Offset: 0x1B84FD4 VA: 0x1B88FD4
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1B8C2AC Offset: 0x1B882AC VA: 0x1B8C2AC
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1B8C650 Offset: 0x1B88650 VA: 0x1B8C650
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x1B8833C Offset: 0x1B8433C VA: 0x1B8833C
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1B8C768 Offset: 0x1B88768 VA: 0x1B8C768
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x1B8C9DC Offset: 0x1B889DC VA: 0x1B8C9DC
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x1B8CDE4 Offset: 0x1B88DE4 VA: 0x1B8CDE4
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x1B8D1EC Offset: 0x1B891EC VA: 0x1B8D1EC
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x1B8B9E8 Offset: 0x1B879E8 VA: 0x1B8B9E8
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x1B8E8D4 Offset: 0x1B8A8D4 VA: 0x1B8E8D4
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle, bool substitution) { }

	// RVA: 0x1B8BF04 Offset: 0x1B87F04 VA: 0x1B8BF04
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root, bool substitution) { }

	// RVA: 0x1B8FB18 Offset: 0x1B8BB18 VA: 0x1B8FB18
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element, bool substitution) { }

	// RVA: 0x1B8FC6C Offset: 0x1B8BC6C VA: 0x1B8FC6C
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root, bool substitution) { }

	// RVA: 0x1B901D8 Offset: 0x1B8C1D8 VA: 0x1B901D8
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root, bool substitution) { }

	// RVA: 0x1B90674 Offset: 0x1B8C674 VA: 0x1B90674
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root, bool substitution) { }

	// RVA: 0x1B90B58 Offset: 0x1B8CB58 VA: 0x1B90B58
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root, bool substitution) { }

	// RVA: 0x1B8F584 Offset: 0x1B8B584 VA: 0x1B8F584
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1B910A0 Offset: 0x1B8D0A0 VA: 0x1B910A0
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x1B911B4 Offset: 0x1B8D1B4 VA: 0x1B911B4
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x1B91210 Offset: 0x1B8D210 VA: 0x1B91210
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x1B9125C Offset: 0x1B8D25C VA: 0x1B9125C
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x1B9147C Offset: 0x1B8D47C VA: 0x1B9147C
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1B91814 Offset: 0x1B8D814 VA: 0x1B91814
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1B91A88 Offset: 0x1B8DA88 VA: 0x1B91A88
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x1B91D8C Offset: 0x1B8DD8C VA: 0x1B91D8C
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x1B929DC Offset: 0x1B8E9DC VA: 0x1B929DC
	private void CalculateSequenceRange(XmlSchemaSequence sequence, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x1B91FA4 Offset: 0x1B8DFA4 VA: 0x1B91FA4
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1B92800 Offset: 0x1B8E800 VA: 0x1B92800
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x1B928E8 Offset: 0x1B8E8E8 VA: 0x1B928E8
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x1B90FDC Offset: 0x1B8CFDC VA: 0x1B90FDC
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x1B91FE8 Offset: 0x1B8DFE8 VA: 0x1B91FE8
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x1B92DC0 Offset: 0x1B8EDC0 VA: 0x1B92DC0
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1B8EA3C Offset: 0x1B8AA3C VA: 0x1B8EA3C
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x1B87BF0 Offset: 0x1B83BF0 VA: 0x1B87BF0
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1B8D4EC Offset: 0x1B894EC VA: 0x1B8D4EC
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x1B92E74 Offset: 0x1B8EE74 VA: 0x1B92E74
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1B92DE0 Offset: 0x1B8EDE0 VA: 0x1B92DE0
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1B8A678 Offset: 0x1B86678 VA: 0x1B8A678
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x1B8B270 Offset: 0x1B87270 VA: 0x1B8B270
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x1B898D8 Offset: 0x1B858D8 VA: 0x1B898D8
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x1B8EAAC Offset: 0x1B8AAAC VA: 0x1B8EAAC
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x1B92F08 Offset: 0x1B8EF08 VA: 0x1B92F08
	private void BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x1B93444 Offset: 0x1B8F444 VA: 0x1B93444
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x1B8B914 Offset: 0x1B87914 VA: 0x1B8B914
	private void CompileCompexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x1B8C160 Offset: 0x1B88160 VA: 0x1B8C160
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x1B8F4D0 Offset: 0x1B8B4D0 VA: 0x1B8F4D0
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x1B8F36C Offset: 0x1B8B36C VA: 0x1B8F36C
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }
}

// Namespace: 
private enum SchemaCollectionPreprocessor.Compositor // TypeDefIndex: 3511
{
	// Fields
	public int value__; // 0x0
	public const SchemaCollectionPreprocessor.Compositor Root = 0;
	public const SchemaCollectionPreprocessor.Compositor Include = 1;
	public const SchemaCollectionPreprocessor.Compositor Import = 2;
}

// Namespace: System.Xml.Schema
internal sealed class SchemaCollectionPreprocessor : BaseProcessor // TypeDefIndex: 3512
{
	// Fields
	private XmlSchema schema; // 0x40
	private string targetNamespace; // 0x48
	private bool buildinIncluded; // 0x50
	private XmlSchemaForm elementFormDefault; // 0x54
	private XmlSchemaForm attributeFormDefault; // 0x58
	private XmlSchemaDerivationMethod blockDefault; // 0x5C
	private XmlSchemaDerivationMethod finalDefault; // 0x60
	private Hashtable schemaLocations; // 0x68
	private Hashtable referenceNamespaces; // 0x70
	private string Xmlns; // 0x78
	private XmlResolver xmlResolver; // 0x80

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0x1B936A0 Offset: 0x1B8F6A0 VA: 0x1B936A0
	public void .ctor(XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventHandler) { }

	// RVA: 0x1B936A8 Offset: 0x1B8F6A8 VA: 0x1B936A8
	public bool Execute(XmlSchema schema, string targetNamespace, bool loadExternals, XmlSchemaCollection xsc) { }

	// RVA: 0x1B938F4 Offset: 0x1B8F8F4 VA: 0x1B938F4
	private void Cleanup(XmlSchema schema) { }

	// RVA: 0x1B96A38 Offset: 0x1B92A38 VA: 0x1B96A38
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1B93B0C Offset: 0x1B8FB0C VA: 0x1B93B0C
	private void LoadExternals(XmlSchema schema, XmlSchemaCollection xsc) { }

	// RVA: 0x1B96C00 Offset: 0x1B92C00 VA: 0x1B96C00
	private void BuildRefNamespaces(XmlSchema schema) { }

	// RVA: 0x1B9471C Offset: 0x1B9071C VA: 0x1B9471C
	private void Preprocess(XmlSchema schema, string targetNamespace, SchemaCollectionPreprocessor.Compositor compositor) { }

	// RVA: 0x1B96F0C Offset: 0x1B92F0C VA: 0x1B96F0C
	private void PreprocessRedefine(XmlSchemaRedefine redefine) { }

	// RVA: 0x1B99DCC Offset: 0x1B95DCC VA: 0x1B99DCC
	private int CountGroupSelfReference(XmlSchemaObjectCollection items, XmlQualifiedName name) { }

	// RVA: 0x1B997A0 Offset: 0x1B957A0 VA: 0x1B997A0
	private void CheckRefinedGroup(XmlSchemaGroup group) { }

	// RVA: 0x1B99838 Offset: 0x1B95838 VA: 0x1B99838
	private void CheckRefinedAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1B99CC0 Offset: 0x1B95CC0 VA: 0x1B99CC0
	private void CheckRefinedSimpleType(XmlSchemaSimpleType stype) { }

	// RVA: 0x1B999A0 Offset: 0x1B959A0 VA: 0x1B999A0
	private void CheckRefinedComplexType(XmlSchemaComplexType ctype) { }

	// RVA: 0x1B97FC0 Offset: 0x1B93FC0 VA: 0x1B97FC0
	private void PreprocessAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1B9A5AC Offset: 0x1B965AC VA: 0x1B9A5AC
	private void PreprocessLocalAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1B9A36C Offset: 0x1B9636C VA: 0x1B9A36C
	private void PreprocessAttributeContent(XmlSchemaAttribute attribute) { }

	// RVA: 0x1B98130 Offset: 0x1B94130 VA: 0x1B98130
	private void PreprocessAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1B990D4 Offset: 0x1B950D4 VA: 0x1B990D4
	private void PreprocessElement(XmlSchemaElement element) { }

	// RVA: 0x1B9AF68 Offset: 0x1B96F68 VA: 0x1B9AF68
	private void PreprocessLocalElement(XmlSchemaElement element) { }

	// RVA: 0x1B9AC10 Offset: 0x1B96C10 VA: 0x1B9AC10
	private void PreprocessElementContent(XmlSchemaElement element) { }

	// RVA: 0x1B9B2DC Offset: 0x1B972DC VA: 0x1B9B2DC
	private void PreprocessIdentityConstraint(XmlSchemaIdentityConstraint constraint) { }

	// RVA: 0x1B98ADC Offset: 0x1B94ADC VA: 0x1B98ADC
	private void PreprocessSimpleType(XmlSchemaSimpleType simpleType, bool local) { }

	// RVA: 0x1B98230 Offset: 0x1B94230 VA: 0x1B98230
	private void PreprocessComplexType(XmlSchemaComplexType complexType, bool local) { }

	// RVA: 0x1B99328 Offset: 0x1B95328 VA: 0x1B99328
	private void PreprocessGroup(XmlSchemaGroup group) { }

	// RVA: 0x1B994F4 Offset: 0x1B954F4 VA: 0x1B994F4
	private void PreprocessNotation(XmlSchemaNotation notation) { }

	// RVA: 0x1B9B634 Offset: 0x1B97634 VA: 0x1B9B634
	private void PreprocessParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1B9A8EC Offset: 0x1B968EC VA: 0x1B9A8EC
	private void PreprocessAttributes(XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaObject parent) { }

	// RVA: 0x1B944C0 Offset: 0x1B904C0 VA: 0x1B944C0
	private void ValidateIdAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1B9A0AC Offset: 0x1B960AC VA: 0x1B9A0AC
	private void ValidateNameAttribute(XmlSchemaObject xso) { }

	// RVA: 0x1B9A764 Offset: 0x1B96764 VA: 0x1B9A764
	private void ValidateQNameAttribute(XmlSchemaObject xso, string attributeName, XmlQualifiedName value) { }

	// RVA: 0x1B96E04 Offset: 0x1B92E04 VA: 0x1B96E04
	private void SetParent(XmlSchemaObject child, XmlSchemaObject parent) { }

	// RVA: 0x1B96E20 Offset: 0x1B92E20 VA: 0x1B96E20
	private void PreprocessAnnotation(XmlSchemaObject schemaObject) { }

	// RVA: 0x1B96A40 Offset: 0x1B92A40 VA: 0x1B96A40
	private Uri ResolveSchemaLocationUri(XmlSchema enclosingSchema, string location) { }

	// RVA: 0x1B96AEC Offset: 0x1B92AEC VA: 0x1B96AEC
	private Stream GetSchemaEntity(Uri ruri) { }
}

// Namespace: 
internal enum SchemaDeclBase.Use // TypeDefIndex: 3513
{
	// Fields
	public int value__; // 0x0
	public const SchemaDeclBase.Use Default = 0;
	public const SchemaDeclBase.Use Required = 1;
	public const SchemaDeclBase.Use Implied = 2;
	public const SchemaDeclBase.Use Fixed = 3;
	public const SchemaDeclBase.Use RequiredFixed = 4;
}

// Namespace: System.Xml.Schema
internal abstract class SchemaDeclBase // TypeDefIndex: 3514
{
	// Fields
	protected XmlQualifiedName name; // 0x10
	protected string prefix; // 0x18
	protected bool isDeclaredInExternal; // 0x20
	protected SchemaDeclBase.Use presence; // 0x24
	protected XmlSchemaType schemaType; // 0x28
	protected XmlSchemaDatatype datatype; // 0x30
	protected string defaultValueRaw; // 0x38
	protected object defaultValueTyped; // 0x40
	protected long maxLength; // 0x48
	protected long minLength; // 0x50
	protected List<string> values; // 0x58

	// Properties
	internal XmlQualifiedName Name { get; set; }
	internal string Prefix { get; set; }
	internal bool IsDeclaredInExternal { get; set; }
	internal SchemaDeclBase.Use Presence { get; set; }
	internal long MaxLength { get; set; }
	internal long MinLength { get; set; }
	internal XmlSchemaType SchemaType { get; set; }
	internal XmlSchemaDatatype Datatype { get; set; }
	internal List<string> Values { get; set; }
	internal string DefaultValueRaw { get; set; }
	internal object DefaultValueTyped { get; set; }

	// Methods

	// RVA: 0x1B9BF4C Offset: 0x1B97F4C VA: 0x1B9BF4C
	protected void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x1B9BFFC Offset: 0x1B97FFC VA: 0x1B9BFFC
	protected void .ctor() { }

	// RVA: 0x1B9C06C Offset: 0x1B9806C VA: 0x1B9C06C
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x1B9C074 Offset: 0x1B98074 VA: 0x1B9C074
	internal void set_Name(XmlQualifiedName value) { }

	// RVA: 0x1B9C07C Offset: 0x1B9807C VA: 0x1B9C07C
	internal string get_Prefix() { }

	// RVA: 0x1B9C0A0 Offset: 0x1B980A0 VA: 0x1B9C0A0
	internal void set_Prefix(string value) { }

	// RVA: 0x1B9C0A8 Offset: 0x1B980A8 VA: 0x1B9C0A8
	internal bool get_IsDeclaredInExternal() { }

	// RVA: 0x1B9C0B0 Offset: 0x1B980B0 VA: 0x1B9C0B0
	internal void set_IsDeclaredInExternal(bool value) { }

	// RVA: 0x1B9C0B8 Offset: 0x1B980B8 VA: 0x1B9C0B8
	internal SchemaDeclBase.Use get_Presence() { }

	// RVA: 0x1B9C0C0 Offset: 0x1B980C0 VA: 0x1B9C0C0
	internal void set_Presence(SchemaDeclBase.Use value) { }

	// RVA: 0x1B9C0C8 Offset: 0x1B980C8 VA: 0x1B9C0C8
	internal long get_MaxLength() { }

	// RVA: 0x1B9C0D0 Offset: 0x1B980D0 VA: 0x1B9C0D0
	internal void set_MaxLength(long value) { }

	// RVA: 0x1B9C0D8 Offset: 0x1B980D8 VA: 0x1B9C0D8
	internal long get_MinLength() { }

	// RVA: 0x1B9C0E0 Offset: 0x1B980E0 VA: 0x1B9C0E0
	internal void set_MinLength(long value) { }

	// RVA: 0x1B9C0E8 Offset: 0x1B980E8 VA: 0x1B9C0E8
	internal XmlSchemaType get_SchemaType() { }

	// RVA: 0x1B9C0F0 Offset: 0x1B980F0 VA: 0x1B9C0F0
	internal void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x1B9C0F8 Offset: 0x1B980F8 VA: 0x1B9C0F8
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x1B9C100 Offset: 0x1B98100 VA: 0x1B9C100
	internal void set_Datatype(XmlSchemaDatatype value) { }

	// RVA: 0x1B9C108 Offset: 0x1B98108 VA: 0x1B9C108
	internal void AddValue(string value) { }

	// RVA: 0x1B9C208 Offset: 0x1B98208 VA: 0x1B9C208
	internal List<string> get_Values() { }

	// RVA: 0x1B9C210 Offset: 0x1B98210 VA: 0x1B9C210
	internal void set_Values(List<string> value) { }

	// RVA: 0x1B9C218 Offset: 0x1B98218 VA: 0x1B9C218
	internal string get_DefaultValueRaw() { }

	// RVA: 0x1B9C23C Offset: 0x1B9823C VA: 0x1B9C23C
	internal void set_DefaultValueRaw(string value) { }

	// RVA: 0x1B9C244 Offset: 0x1B98244 VA: 0x1B9C244
	internal object get_DefaultValueTyped() { }

	// RVA: 0x1B9C24C Offset: 0x1B9824C VA: 0x1B9C24C
	internal void set_DefaultValueTyped(object value) { }

	// RVA: 0x1B9C254 Offset: 0x1B98254 VA: 0x1B9C254
	internal bool CheckEnumeration(object pVal) { }

	// RVA: 0x1B9C30C Offset: 0x1B9830C VA: 0x1B9C30C
	internal bool CheckValue(object pVal) { }
}

// Namespace: System.Xml.Schema
internal sealed class SchemaElementDecl : SchemaDeclBase, IDtdAttributeListInfo // TypeDefIndex: 3515
{
	// Fields
	private Dictionary<XmlQualifiedName, SchemaAttDef> attdefs; // 0x60
	private List<IDtdDefaultAttributeInfo> defaultAttdefs; // 0x68
	private bool isIdDeclared; // 0x70
	private bool hasNonCDataAttribute; // 0x71
	private bool isAbstract; // 0x72
	private bool isNillable; // 0x73
	private bool hasRequiredAttribute; // 0x74
	private bool isNotationDeclared; // 0x75
	private Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes; // 0x78
	private ContentValidator contentValidator; // 0x80
	private XmlSchemaAnyAttribute anyAttribute; // 0x88
	private XmlSchemaDerivationMethod block; // 0x90
	private CompiledIdentityConstraint[] constraints; // 0x98
	private XmlSchemaElement schemaElement; // 0xA0
	internal static readonly SchemaElementDecl Empty; // 0x0

	// Properties
	private bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes { get; }
	internal bool IsIdDeclared { get; set; }
	internal bool HasNonCDataAttribute { get; set; }
	internal bool IsAbstract { get; set; }
	internal bool IsNillable { get; set; }
	internal XmlSchemaDerivationMethod Block { get; set; }
	internal bool IsNotationDeclared { get; set; }
	internal bool HasDefaultAttribute { get; }
	internal bool HasRequiredAttribute { get; }
	internal ContentValidator ContentValidator { get; set; }
	internal XmlSchemaAnyAttribute AnyAttribute { get; set; }
	internal CompiledIdentityConstraint[] Constraints { get; set; }
	internal XmlSchemaElement SchemaElement { get; set; }
	internal IList<IDtdDefaultAttributeInfo> DefaultAttDefs { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs { get; }
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes { get; }

	// Methods

	// RVA: 0x1B9C354 Offset: 0x1B98354 VA: 0x1B9C354
	internal void .ctor() { }

	// RVA: 0x1B9C42C Offset: 0x1B9842C VA: 0x1B9C42C
	internal void .ctor(XmlSchemaDatatype dtype) { }

	// RVA: 0x1B9C55C Offset: 0x1B9855C VA: 0x1B9C55C
	internal void .ctor(XmlQualifiedName name, string prefix) { }

	// RVA: 0x1B9C64C Offset: 0x1B9864C VA: 0x1B9C64C
	internal static SchemaElementDecl CreateAnyTypeElementDecl() { }

	// RVA: 0x1B9C718 Offset: 0x1B98718 VA: 0x1B9C718 Slot: 4
	private bool System.Xml.IDtdAttributeListInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x1B9C720 Offset: 0x1B98720 VA: 0x1B9C720 Slot: 5
	private IDtdAttributeInfo System.Xml.IDtdAttributeListInfo.LookupAttribute(string prefix, string localName) { }

	// RVA: 0x1B9C7D4 Offset: 0x1B987D4 VA: 0x1B9C7D4 Slot: 6
	private IEnumerable<IDtdDefaultAttributeInfo> System.Xml.IDtdAttributeListInfo.LookupDefaultAttributes() { }

	// RVA: 0x1B9C7DC Offset: 0x1B987DC VA: 0x1B9C7DC
	internal bool get_IsIdDeclared() { }

	// RVA: 0x1B9C7E4 Offset: 0x1B987E4 VA: 0x1B9C7E4
	internal void set_IsIdDeclared(bool value) { }

	// RVA: 0x1B9C7EC Offset: 0x1B987EC VA: 0x1B9C7EC
	internal bool get_HasNonCDataAttribute() { }

	// RVA: 0x1B9C7F4 Offset: 0x1B987F4 VA: 0x1B9C7F4
	internal void set_HasNonCDataAttribute(bool value) { }

	// RVA: 0x1B9C7FC Offset: 0x1B987FC VA: 0x1B9C7FC
	internal SchemaElementDecl Clone() { }

	// RVA: 0x1B9C860 Offset: 0x1B98860 VA: 0x1B9C860
	internal bool get_IsAbstract() { }

	// RVA: 0x1B9C868 Offset: 0x1B98868 VA: 0x1B9C868
	internal void set_IsAbstract(bool value) { }

	// RVA: 0x1B9C870 Offset: 0x1B98870 VA: 0x1B9C870
	internal bool get_IsNillable() { }

	// RVA: 0x1B9C878 Offset: 0x1B98878 VA: 0x1B9C878
	internal void set_IsNillable(bool value) { }

	// RVA: 0x1B9C880 Offset: 0x1B98880 VA: 0x1B9C880
	internal XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x1B9C888 Offset: 0x1B98888 VA: 0x1B9C888
	internal void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1B9C890 Offset: 0x1B98890 VA: 0x1B9C890
	internal bool get_IsNotationDeclared() { }

	// RVA: 0x1B9C898 Offset: 0x1B98898 VA: 0x1B9C898
	internal void set_IsNotationDeclared(bool value) { }

	// RVA: 0x1B9C8A0 Offset: 0x1B988A0 VA: 0x1B9C8A0
	internal bool get_HasDefaultAttribute() { }

	// RVA: 0x1B9C8B0 Offset: 0x1B988B0 VA: 0x1B9C8B0
	internal bool get_HasRequiredAttribute() { }

	// RVA: 0x1B9C8B8 Offset: 0x1B988B8 VA: 0x1B9C8B8
	internal ContentValidator get_ContentValidator() { }

	// RVA: 0x1B9C8C0 Offset: 0x1B988C0 VA: 0x1B9C8C0
	internal void set_ContentValidator(ContentValidator value) { }

	// RVA: 0x1B9C8C8 Offset: 0x1B988C8 VA: 0x1B9C8C8
	internal XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1B9C8D0 Offset: 0x1B988D0 VA: 0x1B9C8D0
	internal void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1B9C8D8 Offset: 0x1B988D8 VA: 0x1B9C8D8
	internal CompiledIdentityConstraint[] get_Constraints() { }

	// RVA: 0x1B9C8E0 Offset: 0x1B988E0 VA: 0x1B9C8E0
	internal void set_Constraints(CompiledIdentityConstraint[] value) { }

	// RVA: 0x1B9C8E8 Offset: 0x1B988E8 VA: 0x1B9C8E8
	internal XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x1B9C8F0 Offset: 0x1B988F0 VA: 0x1B9C8F0
	internal void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x1B9C8F8 Offset: 0x1B988F8 VA: 0x1B9C8F8
	internal void AddAttDef(SchemaAttDef attdef) { }

	// RVA: 0x1B9CA70 Offset: 0x1B98A70 VA: 0x1B9CA70
	internal SchemaAttDef GetAttDef(XmlQualifiedName qname) { }

	// RVA: 0x1B9CAE8 Offset: 0x1B98AE8 VA: 0x1B9CAE8
	internal IList<IDtdDefaultAttributeInfo> get_DefaultAttDefs() { }

	// RVA: 0x1B9CAF0 Offset: 0x1B98AF0 VA: 0x1B9CAF0
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttDefs() { }

	// RVA: 0x1B9CAF8 Offset: 0x1B98AF8 VA: 0x1B9CAF8
	internal Dictionary<XmlQualifiedName, XmlQualifiedName> get_ProhibitedAttributes() { }

	// RVA: 0x1B9CB00 Offset: 0x1B98B00 VA: 0x1B9CB00
	internal void CheckAttributes(Hashtable presence, bool standalone) { }

	// RVA: 0x1B9CD88 Offset: 0x1B98D88 VA: 0x1B9CD88
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class SchemaEntity : IDtdEntityInfo // TypeDefIndex: 3516
{
	// Fields
	private XmlQualifiedName qname; // 0x10
	private string url; // 0x18
	private string pubid; // 0x20
	private string text; // 0x28
	private XmlQualifiedName ndata; // 0x30
	private int lineNumber; // 0x38
	private int linePosition; // 0x3C
	private bool isParameter; // 0x40
	private bool isExternal; // 0x41
	private bool parsingInProgress; // 0x42
	private bool isDeclaredInExternal; // 0x43
	private string baseURI; // 0x48
	private string declaredURI; // 0x50

	// Properties
	private string System.Xml.IDtdEntityInfo.Name { get; }
	private bool System.Xml.IDtdEntityInfo.IsExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsUnparsedEntity { get; }
	private bool System.Xml.IDtdEntityInfo.IsParameterEntity { get; }
	private string System.Xml.IDtdEntityInfo.BaseUriString { get; }
	private string System.Xml.IDtdEntityInfo.DeclaredUriString { get; }
	private string System.Xml.IDtdEntityInfo.SystemId { get; }
	private string System.Xml.IDtdEntityInfo.PublicId { get; }
	private string System.Xml.IDtdEntityInfo.Text { get; }
	private int System.Xml.IDtdEntityInfo.LineNumber { get; }
	private int System.Xml.IDtdEntityInfo.LinePosition { get; }
	internal XmlQualifiedName Name { get; }
	internal string Url { get; set; }
	internal string Pubid { get; set; }
	internal bool IsExternal { get; set; }
	internal bool DeclaredInExternal { get; set; }
	internal XmlQualifiedName NData { get; set; }
	internal string Text { get; set; }
	internal int Line { get; set; }
	internal int Pos { get; set; }
	internal string BaseURI { get; set; }
	internal bool ParsingInProgress { get; set; }
	internal string DeclaredURI { get; set; }

	// Methods

	// RVA: 0x1B9CDEC Offset: 0x1B98DEC VA: 0x1B9CDEC
	internal void .ctor(XmlQualifiedName qname, bool isParameter) { }

	// RVA: 0x1B9CE88 Offset: 0x1B98E88 VA: 0x1B9CE88 Slot: 4
	private string System.Xml.IDtdEntityInfo.get_Name() { }

	// RVA: 0x1B9CEA0 Offset: 0x1B98EA0 VA: 0x1B9CEA0 Slot: 5
	private bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	// RVA: 0x1B9CEA8 Offset: 0x1B98EA8 VA: 0x1B9CEA8 Slot: 6
	private bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	// RVA: 0x1B9CEB0 Offset: 0x1B98EB0 VA: 0x1B9CEB0 Slot: 7
	private bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	// RVA: 0x1B9CED8 Offset: 0x1B98ED8 VA: 0x1B9CED8 Slot: 8
	private bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	// RVA: 0x1B9CEE0 Offset: 0x1B98EE0 VA: 0x1B9CEE0 Slot: 9
	private string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	// RVA: 0x1B9CF28 Offset: 0x1B98F28 VA: 0x1B9CF28 Slot: 10
	private string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	// RVA: 0x1B9CF70 Offset: 0x1B98F70 VA: 0x1B9CF70 Slot: 11
	private string System.Xml.IDtdEntityInfo.get_SystemId() { }

	// RVA: 0x1B9CF78 Offset: 0x1B98F78 VA: 0x1B9CF78 Slot: 12
	private string System.Xml.IDtdEntityInfo.get_PublicId() { }

	// RVA: 0x1B9CF80 Offset: 0x1B98F80 VA: 0x1B9CF80 Slot: 13
	private string System.Xml.IDtdEntityInfo.get_Text() { }

	// RVA: 0x1B9CF88 Offset: 0x1B98F88 VA: 0x1B9CF88 Slot: 14
	private int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	// RVA: 0x1B9CF90 Offset: 0x1B98F90 VA: 0x1B9CF90 Slot: 15
	private int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	// RVA: 0x1B9CF98 Offset: 0x1B98F98 VA: 0x1B9CF98
	internal static bool IsPredefinedEntity(string n) { }

	// RVA: 0x1B9D094 Offset: 0x1B99094 VA: 0x1B9D094
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x1B9D09C Offset: 0x1B9909C VA: 0x1B9D09C
	internal string get_Url() { }

	// RVA: 0x1B9D0A4 Offset: 0x1B990A4 VA: 0x1B9D0A4
	internal void set_Url(string value) { }

	// RVA: 0x1B9D0C8 Offset: 0x1B990C8 VA: 0x1B9D0C8
	internal string get_Pubid() { }

	// RVA: 0x1B9D0D0 Offset: 0x1B990D0 VA: 0x1B9D0D0
	internal void set_Pubid(string value) { }

	// RVA: 0x1B9D0D8 Offset: 0x1B990D8 VA: 0x1B9D0D8
	internal bool get_IsExternal() { }

	// RVA: 0x1B9D0E0 Offset: 0x1B990E0 VA: 0x1B9D0E0
	internal void set_IsExternal(bool value) { }

	// RVA: 0x1B9D0E8 Offset: 0x1B990E8 VA: 0x1B9D0E8
	internal bool get_DeclaredInExternal() { }

	// RVA: 0x1B9D0F0 Offset: 0x1B990F0 VA: 0x1B9D0F0
	internal void set_DeclaredInExternal(bool value) { }

	// RVA: 0x1B9D0F8 Offset: 0x1B990F8 VA: 0x1B9D0F8
	internal XmlQualifiedName get_NData() { }

	// RVA: 0x1B9D100 Offset: 0x1B99100 VA: 0x1B9D100
	internal void set_NData(XmlQualifiedName value) { }

	// RVA: 0x1B9D108 Offset: 0x1B99108 VA: 0x1B9D108
	internal string get_Text() { }

	// RVA: 0x1B9D110 Offset: 0x1B99110 VA: 0x1B9D110
	internal void set_Text(string value) { }

	// RVA: 0x1B9D130 Offset: 0x1B99130 VA: 0x1B9D130
	internal int get_Line() { }

	// RVA: 0x1B9D138 Offset: 0x1B99138 VA: 0x1B9D138
	internal void set_Line(int value) { }

	// RVA: 0x1B9D140 Offset: 0x1B99140 VA: 0x1B9D140
	internal int get_Pos() { }

	// RVA: 0x1B9D148 Offset: 0x1B99148 VA: 0x1B9D148
	internal void set_Pos(int value) { }

	// RVA: 0x1B9CF04 Offset: 0x1B98F04 VA: 0x1B9CF04
	internal string get_BaseURI() { }

	// RVA: 0x1B9D150 Offset: 0x1B99150 VA: 0x1B9D150
	internal void set_BaseURI(string value) { }

	// RVA: 0x1B9D158 Offset: 0x1B99158 VA: 0x1B9D158
	internal bool get_ParsingInProgress() { }

	// RVA: 0x1B9D160 Offset: 0x1B99160 VA: 0x1B9D160
	internal void set_ParsingInProgress(bool value) { }

	// RVA: 0x1B9CF4C Offset: 0x1B98F4C VA: 0x1B9CF4C
	internal string get_DeclaredURI() { }

	// RVA: 0x1B9D168 Offset: 0x1B99168 VA: 0x1B9D168
	internal void set_DeclaredURI(string value) { }
}

// Namespace: System.Xml.Schema
internal enum AttributeMatchState // TypeDefIndex: 3517
{
	// Fields
	public int value__; // 0x0
	public const AttributeMatchState AttributeFound = 0;
	public const AttributeMatchState AnyIdAttributeFound = 1;
	public const AttributeMatchState UndeclaredElementAndAttribute = 2;
	public const AttributeMatchState UndeclaredAttribute = 3;
	public const AttributeMatchState AnyAttributeLax = 4;
	public const AttributeMatchState AnyAttributeSkip = 5;
	public const AttributeMatchState ProhibitedAnyAttribute = 6;
	public const AttributeMatchState ProhibitedAttribute = 7;
	public const AttributeMatchState AttributeNameMismatch = 8;
	public const AttributeMatchState ValidateAttributeInvalidCall = 9;
}

// Namespace: System.Xml.Schema
internal class SchemaInfo : IDtdInfo // TypeDefIndex: 3518
{
	// Fields
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls; // 0x10
	private Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls; // 0x18
	private Dictionary<XmlQualifiedName, SchemaEntity> generalEntities; // 0x20
	private Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities; // 0x28
	private XmlQualifiedName docTypeName; // 0x30
	private string internalDtdSubset; // 0x38
	private bool hasNonCDataAttributes; // 0x40
	private bool hasDefaultAttributes; // 0x41
	private Dictionary<string, bool> targetNamespaces; // 0x48
	private Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls; // 0x50
	private int errorCount; // 0x58
	private SchemaType schemaType; // 0x5C
	private Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType; // 0x60
	private Dictionary<string, SchemaNotation> notations; // 0x68

	// Properties
	public XmlQualifiedName DocTypeName { get; set; }
	internal string InternalDtdSubset { set; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities { get; }
	internal Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities { get; }
	internal SchemaType SchemaType { get; set; }
	internal Dictionary<string, bool> TargetNamespaces { get; }
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDeclsByType { get; }
	internal Dictionary<XmlQualifiedName, SchemaAttDef> AttributeDecls { get; }
	internal Dictionary<string, SchemaNotation> Notations { get; }
	internal int ErrorCount { get; set; }
	private bool System.Xml.IDtdInfo.HasDefaultAttributes { get; }
	private bool System.Xml.IDtdInfo.HasNonCDataAttributes { get; }
	private XmlQualifiedName System.Xml.IDtdInfo.Name { get; }
	private string System.Xml.IDtdInfo.InternalDtdSubset { get; }

	// Methods

	// RVA: 0x1B9D170 Offset: 0x1B99170 VA: 0x1B9D170
	internal void .ctor() { }

	// RVA: 0x1B9D34C Offset: 0x1B9934C VA: 0x1B9D34C
	public XmlQualifiedName get_DocTypeName() { }

	// RVA: 0x1B9D354 Offset: 0x1B99354 VA: 0x1B9D354
	public void set_DocTypeName(XmlQualifiedName value) { }

	// RVA: 0x1B9D35C Offset: 0x1B9935C VA: 0x1B9D35C
	internal void set_InternalDtdSubset(string value) { }

	// RVA: 0x1B9D364 Offset: 0x1B99364 VA: 0x1B9D364
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDecls() { }

	// RVA: 0x1B9D36C Offset: 0x1B9936C VA: 0x1B9D36C
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_UndeclaredElementDecls() { }

	// RVA: 0x1B9D374 Offset: 0x1B99374 VA: 0x1B9D374
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_GeneralEntities() { }

	// RVA: 0x1B9D3F8 Offset: 0x1B993F8 VA: 0x1B9D3F8
	internal Dictionary<XmlQualifiedName, SchemaEntity> get_ParameterEntities() { }

	// RVA: 0x1B9D47C Offset: 0x1B9947C VA: 0x1B9D47C
	internal SchemaType get_SchemaType() { }

	// RVA: 0x1B9D484 Offset: 0x1B99484 VA: 0x1B9D484
	internal void set_SchemaType(SchemaType value) { }

	// RVA: 0x1B9D48C Offset: 0x1B9948C VA: 0x1B9D48C
	internal Dictionary<string, bool> get_TargetNamespaces() { }

	// RVA: 0x1B9D494 Offset: 0x1B99494 VA: 0x1B9D494
	internal Dictionary<XmlQualifiedName, SchemaElementDecl> get_ElementDeclsByType() { }

	// RVA: 0x1B9D49C Offset: 0x1B9949C VA: 0x1B9D49C
	internal Dictionary<XmlQualifiedName, SchemaAttDef> get_AttributeDecls() { }

	// RVA: 0x1B9D4A4 Offset: 0x1B994A4 VA: 0x1B9D4A4
	internal Dictionary<string, SchemaNotation> get_Notations() { }

	// RVA: 0x1B9D528 Offset: 0x1B99528 VA: 0x1B9D528
	internal int get_ErrorCount() { }

	// RVA: 0x1B9D530 Offset: 0x1B99530 VA: 0x1B9D530
	internal void set_ErrorCount(int value) { }

	// RVA: 0x1B9D538 Offset: 0x1B99538 VA: 0x1B9D538
	internal SchemaElementDecl GetElementDecl(XmlQualifiedName qname) { }

	// RVA: 0x1B9D5B0 Offset: 0x1B995B0 VA: 0x1B9D5B0
	internal SchemaElementDecl GetTypeDecl(XmlQualifiedName qname) { }

	// RVA: 0x1B9D628 Offset: 0x1B99628 VA: 0x1B9D628
	internal XmlSchemaElement GetElement(XmlQualifiedName qname) { }

	// RVA: 0x1B9D640 Offset: 0x1B99640 VA: 0x1B9D640
	internal bool HasSchema(string ns) { }

	// RVA: 0x1B9D698 Offset: 0x1B99698 VA: 0x1B9D698
	internal bool Contains(string ns) { }

	// RVA: 0x1B9D6F0 Offset: 0x1B996F0 VA: 0x1B9D6F0
	internal SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname) { }

	// RVA: 0x1B9D83C Offset: 0x1B9983C VA: 0x1B9D83C
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState) { }

	// RVA: 0x1B9DA58 Offset: 0x1B99A58 VA: 0x1B9DA58
	internal SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip) { }

	// RVA: 0x1B9DB50 Offset: 0x1B99B50 VA: 0x1B9DB50
	internal void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler) { }

	// RVA: 0x1B9E3E0 Offset: 0x1B9A3E0 VA: 0x1B9E3E0
	internal void Finish() { }

	// RVA: 0x1B9E590 Offset: 0x1B9A590 VA: 0x1B9E590 Slot: 6
	private bool System.Xml.IDtdInfo.get_HasDefaultAttributes() { }

	// RVA: 0x1B9E598 Offset: 0x1B9A598 VA: 0x1B9E598 Slot: 7
	private bool System.Xml.IDtdInfo.get_HasNonCDataAttributes() { }

	// RVA: 0x1B9E5A0 Offset: 0x1B9A5A0 VA: 0x1B9E5A0 Slot: 8
	private IDtdAttributeListInfo System.Xml.IDtdInfo.LookupAttributeList(string prefix, string localName) { }

	// RVA: 0x1B9E668 Offset: 0x1B9A668 VA: 0x1B9E668 Slot: 9
	private IDtdEntityInfo System.Xml.IDtdInfo.LookupEntity(string name) { }

	// RVA: 0x1B9E71C Offset: 0x1B9A71C VA: 0x1B9E71C Slot: 4
	private XmlQualifiedName System.Xml.IDtdInfo.get_Name() { }

	// RVA: 0x1B9E724 Offset: 0x1B9A724 VA: 0x1B9E724 Slot: 5
	private string System.Xml.IDtdInfo.get_InternalDtdSubset() { }
}

// Namespace: 
public enum SchemaNames.Token // TypeDefIndex: 3519
{
	// Fields
	public int value__; // 0x0
	public const SchemaNames.Token Empty = 0;
	public const SchemaNames.Token SchemaName = 1;
	public const SchemaNames.Token SchemaType = 2;
	public const SchemaNames.Token SchemaMaxOccurs = 3;
	public const SchemaNames.Token SchemaMinOccurs = 4;
	public const SchemaNames.Token SchemaInfinite = 5;
	public const SchemaNames.Token SchemaModel = 6;
	public const SchemaNames.Token SchemaOpen = 7;
	public const SchemaNames.Token SchemaClosed = 8;
	public const SchemaNames.Token SchemaContent = 9;
	public const SchemaNames.Token SchemaMixed = 10;
	public const SchemaNames.Token SchemaEmpty = 11;
	public const SchemaNames.Token SchemaElementOnly = 12;
	public const SchemaNames.Token SchemaTextOnly = 13;
	public const SchemaNames.Token SchemaOrder = 14;
	public const SchemaNames.Token SchemaSeq = 15;
	public const SchemaNames.Token SchemaOne = 16;
	public const SchemaNames.Token SchemaMany = 17;
	public const SchemaNames.Token SchemaRequired = 18;
	public const SchemaNames.Token SchemaYes = 19;
	public const SchemaNames.Token SchemaNo = 20;
	public const SchemaNames.Token SchemaString = 21;
	public const SchemaNames.Token SchemaId = 22;
	public const SchemaNames.Token SchemaIdref = 23;
	public const SchemaNames.Token SchemaIdrefs = 24;
	public const SchemaNames.Token SchemaEntity = 25;
	public const SchemaNames.Token SchemaEntities = 26;
	public const SchemaNames.Token SchemaNmtoken = 27;
	public const SchemaNames.Token SchemaNmtokens = 28;
	public const SchemaNames.Token SchemaEnumeration = 29;
	public const SchemaNames.Token SchemaDefault = 30;
	public const SchemaNames.Token XdrRoot = 31;
	public const SchemaNames.Token XdrElementType = 32;
	public const SchemaNames.Token XdrElement = 33;
	public const SchemaNames.Token XdrGroup = 34;
	public const SchemaNames.Token XdrAttributeType = 35;
	public const SchemaNames.Token XdrAttribute = 36;
	public const SchemaNames.Token XdrDatatype = 37;
	public const SchemaNames.Token XdrDescription = 38;
	public const SchemaNames.Token XdrExtends = 39;
	public const SchemaNames.Token SchemaXdrRootAlias = 40;
	public const SchemaNames.Token SchemaDtType = 41;
	public const SchemaNames.Token SchemaDtValues = 42;
	public const SchemaNames.Token SchemaDtMaxLength = 43;
	public const SchemaNames.Token SchemaDtMinLength = 44;
	public const SchemaNames.Token SchemaDtMax = 45;
	public const SchemaNames.Token SchemaDtMin = 46;
	public const SchemaNames.Token SchemaDtMinExclusive = 47;
	public const SchemaNames.Token SchemaDtMaxExclusive = 48;
	public const SchemaNames.Token SchemaTargetNamespace = 49;
	public const SchemaNames.Token SchemaVersion = 50;
	public const SchemaNames.Token SchemaFinalDefault = 51;
	public const SchemaNames.Token SchemaBlockDefault = 52;
	public const SchemaNames.Token SchemaFixed = 53;
	public const SchemaNames.Token SchemaAbstract = 54;
	public const SchemaNames.Token SchemaBlock = 55;
	public const SchemaNames.Token SchemaSubstitutionGroup = 56;
	public const SchemaNames.Token SchemaFinal = 57;
	public const SchemaNames.Token SchemaNillable = 58;
	public const SchemaNames.Token SchemaRef = 59;
	public const SchemaNames.Token SchemaBase = 60;
	public const SchemaNames.Token SchemaDerivedBy = 61;
	public const SchemaNames.Token SchemaNamespace = 62;
	public const SchemaNames.Token SchemaProcessContents = 63;
	public const SchemaNames.Token SchemaRefer = 64;
	public const SchemaNames.Token SchemaPublic = 65;
	public const SchemaNames.Token SchemaSystem = 66;
	public const SchemaNames.Token SchemaSchemaLocation = 67;
	public const SchemaNames.Token SchemaValue = 68;
	public const SchemaNames.Token SchemaSource = 69;
	public const SchemaNames.Token SchemaAttributeFormDefault = 70;
	public const SchemaNames.Token SchemaElementFormDefault = 71;
	public const SchemaNames.Token SchemaUse = 72;
	public const SchemaNames.Token SchemaForm = 73;
	public const SchemaNames.Token XsdSchema = 74;
	public const SchemaNames.Token XsdAnnotation = 75;
	public const SchemaNames.Token XsdInclude = 76;
	public const SchemaNames.Token XsdImport = 77;
	public const SchemaNames.Token XsdElement = 78;
	public const SchemaNames.Token XsdAttribute = 79;
	public const SchemaNames.Token xsdAttributeGroup = 80;
	public const SchemaNames.Token XsdAnyAttribute = 81;
	public const SchemaNames.Token XsdGroup = 82;
	public const SchemaNames.Token XsdAll = 83;
	public const SchemaNames.Token XsdChoice = 84;
	public const SchemaNames.Token XsdSequence = 85;
	public const SchemaNames.Token XsdAny = 86;
	public const SchemaNames.Token XsdNotation = 87;
	public const SchemaNames.Token XsdSimpleType = 88;
	public const SchemaNames.Token XsdComplexType = 89;
	public const SchemaNames.Token XsdUnique = 90;
	public const SchemaNames.Token XsdKey = 91;
	public const SchemaNames.Token XsdKeyref = 92;
	public const SchemaNames.Token XsdSelector = 93;
	public const SchemaNames.Token XsdField = 94;
	public const SchemaNames.Token XsdMinExclusive = 95;
	public const SchemaNames.Token XsdMinInclusive = 96;
	public const SchemaNames.Token XsdMaxExclusive = 97;
	public const SchemaNames.Token XsdMaxInclusive = 98;
	public const SchemaNames.Token XsdTotalDigits = 99;
	public const SchemaNames.Token XsdFractionDigits = 100;
	public const SchemaNames.Token XsdLength = 101;
	public const SchemaNames.Token XsdMinLength = 102;
	public const SchemaNames.Token XsdMaxLength = 103;
	public const SchemaNames.Token XsdEnumeration = 104;
	public const SchemaNames.Token XsdPattern = 105;
	public const SchemaNames.Token XsdDocumentation = 106;
	public const SchemaNames.Token XsdAppInfo = 107;
	public const SchemaNames.Token XsdComplexContent = 108;
	public const SchemaNames.Token XsdComplexContentExtension = 109;
	public const SchemaNames.Token XsdComplexContentRestriction = 110;
	public const SchemaNames.Token XsdSimpleContent = 111;
	public const SchemaNames.Token XsdSimpleContentExtension = 112;
	public const SchemaNames.Token XsdSimpleContentRestriction = 113;
	public const SchemaNames.Token XsdSimpleTypeList = 114;
	public const SchemaNames.Token XsdSimpleTypeRestriction = 115;
	public const SchemaNames.Token XsdSimpleTypeUnion = 116;
	public const SchemaNames.Token XsdWhitespace = 117;
	public const SchemaNames.Token XsdRedefine = 118;
	public const SchemaNames.Token SchemaItemType = 119;
	public const SchemaNames.Token SchemaMemberTypes = 120;
	public const SchemaNames.Token SchemaXPath = 121;
	public const SchemaNames.Token XmlLang = 122;
}

// Namespace: System.Xml.Schema
internal sealed class SchemaNames // TypeDefIndex: 3520
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	public string NsDataType; // 0x18
	public string NsDataTypeAlias; // 0x20
	public string NsDataTypeOld; // 0x28
	public string NsXml; // 0x30
	public string NsXmlNs; // 0x38
	public string NsXdr; // 0x40
	public string NsXdrAlias; // 0x48
	public string NsXs; // 0x50
	public string NsXsi; // 0x58
	public string XsiType; // 0x60
	public string XsiNil; // 0x68
	public string XsiSchemaLocation; // 0x70
	public string XsiNoNamespaceSchemaLocation; // 0x78
	public string XsdSchema; // 0x80
	public string XdrSchema; // 0x88
	public XmlQualifiedName QnPCData; // 0x90
	public XmlQualifiedName QnXml; // 0x98
	public XmlQualifiedName QnXmlNs; // 0xA0
	public XmlQualifiedName QnDtDt; // 0xA8
	public XmlQualifiedName QnXmlLang; // 0xB0
	public XmlQualifiedName QnName; // 0xB8
	public XmlQualifiedName QnType; // 0xC0
	public XmlQualifiedName QnMaxOccurs; // 0xC8
	public XmlQualifiedName QnMinOccurs; // 0xD0
	public XmlQualifiedName QnInfinite; // 0xD8
	public XmlQualifiedName QnModel; // 0xE0
	public XmlQualifiedName QnOpen; // 0xE8
	public XmlQualifiedName QnClosed; // 0xF0
	public XmlQualifiedName QnContent; // 0xF8
	public XmlQualifiedName QnMixed; // 0x100
	public XmlQualifiedName QnEmpty; // 0x108
	public XmlQualifiedName QnEltOnly; // 0x110
	public XmlQualifiedName QnTextOnly; // 0x118
	public XmlQualifiedName QnOrder; // 0x120
	public XmlQualifiedName QnSeq; // 0x128
	public XmlQualifiedName QnOne; // 0x130
	public XmlQualifiedName QnMany; // 0x138
	public XmlQualifiedName QnRequired; // 0x140
	public XmlQualifiedName QnYes; // 0x148
	public XmlQualifiedName QnNo; // 0x150
	public XmlQualifiedName QnString; // 0x158
	public XmlQualifiedName QnID; // 0x160
	public XmlQualifiedName QnIDRef; // 0x168
	public XmlQualifiedName QnIDRefs; // 0x170
	public XmlQualifiedName QnEntity; // 0x178
	public XmlQualifiedName QnEntities; // 0x180
	public XmlQualifiedName QnNmToken; // 0x188
	public XmlQualifiedName QnNmTokens; // 0x190
	public XmlQualifiedName QnEnumeration; // 0x198
	public XmlQualifiedName QnDefault; // 0x1A0
	public XmlQualifiedName QnXdrSchema; // 0x1A8
	public XmlQualifiedName QnXdrElementType; // 0x1B0
	public XmlQualifiedName QnXdrElement; // 0x1B8
	public XmlQualifiedName QnXdrGroup; // 0x1C0
	public XmlQualifiedName QnXdrAttributeType; // 0x1C8
	public XmlQualifiedName QnXdrAttribute; // 0x1D0
	public XmlQualifiedName QnXdrDataType; // 0x1D8
	public XmlQualifiedName QnXdrDescription; // 0x1E0
	public XmlQualifiedName QnXdrExtends; // 0x1E8
	public XmlQualifiedName QnXdrAliasSchema; // 0x1F0
	public XmlQualifiedName QnDtType; // 0x1F8
	public XmlQualifiedName QnDtValues; // 0x200
	public XmlQualifiedName QnDtMaxLength; // 0x208
	public XmlQualifiedName QnDtMinLength; // 0x210
	public XmlQualifiedName QnDtMax; // 0x218
	public XmlQualifiedName QnDtMin; // 0x220
	public XmlQualifiedName QnDtMinExclusive; // 0x228
	public XmlQualifiedName QnDtMaxExclusive; // 0x230
	public XmlQualifiedName QnTargetNamespace; // 0x238
	public XmlQualifiedName QnVersion; // 0x240
	public XmlQualifiedName QnFinalDefault; // 0x248
	public XmlQualifiedName QnBlockDefault; // 0x250
	public XmlQualifiedName QnFixed; // 0x258
	public XmlQualifiedName QnAbstract; // 0x260
	public XmlQualifiedName QnBlock; // 0x268
	public XmlQualifiedName QnSubstitutionGroup; // 0x270
	public XmlQualifiedName QnFinal; // 0x278
	public XmlQualifiedName QnNillable; // 0x280
	public XmlQualifiedName QnRef; // 0x288
	public XmlQualifiedName QnBase; // 0x290
	public XmlQualifiedName QnDerivedBy; // 0x298
	public XmlQualifiedName QnNamespace; // 0x2A0
	public XmlQualifiedName QnProcessContents; // 0x2A8
	public XmlQualifiedName QnRefer; // 0x2B0
	public XmlQualifiedName QnPublic; // 0x2B8
	public XmlQualifiedName QnSystem; // 0x2C0
	public XmlQualifiedName QnSchemaLocation; // 0x2C8
	public XmlQualifiedName QnValue; // 0x2D0
	public XmlQualifiedName QnUse; // 0x2D8
	public XmlQualifiedName QnForm; // 0x2E0
	public XmlQualifiedName QnElementFormDefault; // 0x2E8
	public XmlQualifiedName QnAttributeFormDefault; // 0x2F0
	public XmlQualifiedName QnItemType; // 0x2F8
	public XmlQualifiedName QnMemberTypes; // 0x300
	public XmlQualifiedName QnXPath; // 0x308
	public XmlQualifiedName QnXsdSchema; // 0x310
	public XmlQualifiedName QnXsdAnnotation; // 0x318
	public XmlQualifiedName QnXsdInclude; // 0x320
	public XmlQualifiedName QnXsdImport; // 0x328
	public XmlQualifiedName QnXsdElement; // 0x330
	public XmlQualifiedName QnXsdAttribute; // 0x338
	public XmlQualifiedName QnXsdAttributeGroup; // 0x340
	public XmlQualifiedName QnXsdAnyAttribute; // 0x348
	public XmlQualifiedName QnXsdGroup; // 0x350
	public XmlQualifiedName QnXsdAll; // 0x358
	public XmlQualifiedName QnXsdChoice; // 0x360
	public XmlQualifiedName QnXsdSequence; // 0x368
	public XmlQualifiedName QnXsdAny; // 0x370
	public XmlQualifiedName QnXsdNotation; // 0x378
	public XmlQualifiedName QnXsdSimpleType; // 0x380
	public XmlQualifiedName QnXsdComplexType; // 0x388
	public XmlQualifiedName QnXsdUnique; // 0x390
	public XmlQualifiedName QnXsdKey; // 0x398
	public XmlQualifiedName QnXsdKeyRef; // 0x3A0
	public XmlQualifiedName QnXsdSelector; // 0x3A8
	public XmlQualifiedName QnXsdField; // 0x3B0
	public XmlQualifiedName QnXsdMinExclusive; // 0x3B8
	public XmlQualifiedName QnXsdMinInclusive; // 0x3C0
	public XmlQualifiedName QnXsdMaxInclusive; // 0x3C8
	public XmlQualifiedName QnXsdMaxExclusive; // 0x3D0
	public XmlQualifiedName QnXsdTotalDigits; // 0x3D8
	public XmlQualifiedName QnXsdFractionDigits; // 0x3E0
	public XmlQualifiedName QnXsdLength; // 0x3E8
	public XmlQualifiedName QnXsdMinLength; // 0x3F0
	public XmlQualifiedName QnXsdMaxLength; // 0x3F8
	public XmlQualifiedName QnXsdEnumeration; // 0x400
	public XmlQualifiedName QnXsdPattern; // 0x408
	public XmlQualifiedName QnXsdDocumentation; // 0x410
	public XmlQualifiedName QnXsdAppinfo; // 0x418
	public XmlQualifiedName QnSource; // 0x420
	public XmlQualifiedName QnXsdComplexContent; // 0x428
	public XmlQualifiedName QnXsdSimpleContent; // 0x430
	public XmlQualifiedName QnXsdRestriction; // 0x438
	public XmlQualifiedName QnXsdExtension; // 0x440
	public XmlQualifiedName QnXsdUnion; // 0x448
	public XmlQualifiedName QnXsdList; // 0x450
	public XmlQualifiedName QnXsdWhiteSpace; // 0x458
	public XmlQualifiedName QnXsdRedefine; // 0x460
	public XmlQualifiedName QnXsdAnyType; // 0x468
	internal XmlQualifiedName[] TokenToQName; // 0x470

	// Methods

	// RVA: 0x1B9E72C Offset: 0x1B9A72C VA: 0x1B9E72C
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x1BA16F4 Offset: 0x1B9D6F4 VA: 0x1BA16F4
	public void CreateTokenToQNameTable() { }

	// RVA: 0x1BA3620 Offset: 0x1B9F620 VA: 0x1BA3620
	public SchemaType SchemaTypeFromRoot(string localName, string ns) { }

	// RVA: 0x1BA3680 Offset: 0x1B9F680 VA: 0x1BA3680
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x1BA36D0 Offset: 0x1B9F6D0 VA: 0x1BA36D0
	public bool IsXDRRoot(string localName, string ns) { }
}

// Namespace: System.Xml.Schema
internal class SchemaNamespaceManager : XmlNamespaceManager // TypeDefIndex: 3521
{
	// Fields
	private XmlSchemaObject node; // 0x50

	// Methods

	// RVA: 0x1BA3720 Offset: 0x1B9F720 VA: 0x1BA3720
	public void .ctor(XmlSchemaObject node) { }

	// RVA: 0x1BA3750 Offset: 0x1B9F750 VA: 0x1BA3750 Slot: 16
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1BA3874 Offset: 0x1B9F874 VA: 0x1BA3874 Slot: 17
	public override string LookupPrefix(string ns) { }
}

// Namespace: System.Xml.Schema
internal sealed class SchemaNotation // TypeDefIndex: 3522
{
	// Fields
	private XmlQualifiedName name; // 0x10
	private string systemLiteral; // 0x18
	private string pubid; // 0x20

	// Properties
	internal XmlQualifiedName Name { get; }
	internal string SystemLiteral { get; set; }
	internal string Pubid { get; set; }

	// Methods

	// RVA: 0x1BA3C54 Offset: 0x1B9FC54 VA: 0x1BA3C54
	internal void .ctor(XmlQualifiedName name) { }

	// RVA: 0x1BA3C84 Offset: 0x1B9FC84 VA: 0x1BA3C84
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x1BA3C8C Offset: 0x1B9FC8C VA: 0x1BA3C8C
	internal string get_SystemLiteral() { }

	// RVA: 0x1BA3C94 Offset: 0x1B9FC94 VA: 0x1BA3C94
	internal void set_SystemLiteral(string value) { }

	// RVA: 0x1BA3C9C Offset: 0x1B9FC9C VA: 0x1BA3C9C
	internal string get_Pubid() { }

	// RVA: 0x1BA3CA4 Offset: 0x1B9FCA4 VA: 0x1BA3CA4
	internal void set_Pubid(string value) { }
}

// Namespace: System.Xml.Schema
internal sealed class Compiler : BaseProcessor // TypeDefIndex: 3523
{
	// Fields
	private string restrictionErrorMsg; // 0x40
	private XmlSchemaObjectTable attributes; // 0x48
	private XmlSchemaObjectTable attributeGroups; // 0x50
	private XmlSchemaObjectTable elements; // 0x58
	private XmlSchemaObjectTable schemaTypes; // 0x60
	private XmlSchemaObjectTable groups; // 0x68
	private XmlSchemaObjectTable notations; // 0x70
	private XmlSchemaObjectTable examplars; // 0x78
	private XmlSchemaObjectTable identityConstraints; // 0x80
	private Stack complexTypeStack; // 0x88
	private Hashtable schemasToCompile; // 0x90
	private Hashtable importedSchemas; // 0x98
	private XmlSchema schemaForSchema; // 0xA0

	// Methods

	// RVA: 0x1BA3CAC Offset: 0x1B9FCAC VA: 0x1BA3CAC
	public void .ctor(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchema schemaForSchema, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x1BA3EF0 Offset: 0x1B9FEF0 VA: 0x1BA3EF0
	public bool Execute(XmlSchemaSet schemaSet, SchemaInfo schemaCompiledInfo) { }

	// RVA: 0x1BA6CF4 Offset: 0x1BA2CF4 VA: 0x1BA6CF4
	internal void Prepare(XmlSchema schema, bool cleanup) { }

	// RVA: 0x1BA8908 Offset: 0x1BA4908 VA: 0x1BA8908
	private void UpdateSForSSimpleTypes() { }

	// RVA: 0x1BA5D14 Offset: 0x1BA1D14 VA: 0x1BA5D14
	private void Output(SchemaInfo schemaInfo) { }

	// RVA: 0x1BA8A50 Offset: 0x1BA4A50 VA: 0x1BA8A50
	internal void ImportAllCompiledSchemas(XmlSchemaSet schemaSet) { }

	// RVA: 0x1BA3F8C Offset: 0x1B9FF8C VA: 0x1BA3F8C
	internal bool Compile() { }

	// RVA: 0x1BA8334 Offset: 0x1BA4334 VA: 0x1BA8334
	private void CleanupAttribute(XmlSchemaAttribute attribute) { }

	// RVA: 0x1BA83AC Offset: 0x1BA43AC VA: 0x1BA83AC
	private void CleanupAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1BA840C Offset: 0x1BA440C VA: 0x1BA840C
	private void CleanupComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1BA8854 Offset: 0x1BA4854 VA: 0x1BA8854
	private void CleanupSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1BA81A0 Offset: 0x1BA41A0 VA: 0x1BA81A0
	private void CleanupElement(XmlSchemaElement element) { }

	// RVA: 0x1BAD950 Offset: 0x1BA9950 VA: 0x1BAD950
	private void CleanupAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1BA8364 Offset: 0x1BA4364 VA: 0x1BA8364
	private void CleanupGroup(XmlSchemaGroup group) { }

	// RVA: 0x1BADA28 Offset: 0x1BA9A28 VA: 0x1BADA28
	private void CleanupParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1BACA14 Offset: 0x1BA8A14 VA: 0x1BACA14
	private void ProcessSubstitutionGroups() { }

	// RVA: 0x1BADBCC Offset: 0x1BA9BCC VA: 0x1BADBCC
	private void CompileSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup) { }

	// RVA: 0x1BAD7FC Offset: 0x1BA97FC VA: 0x1BAD7FC
	private void RecursivelyCheckRedefinedGroups(XmlSchemaGroup redefinedGroup, XmlSchemaGroup baseGroup) { }

	// RVA: 0x1BAD8D8 Offset: 0x1BA98D8 VA: 0x1BAD8D8
	private void RecursivelyCheckRedefinedAttributeGroups(XmlSchemaAttributeGroup attributeGroup, XmlSchemaAttributeGroup baseAttributeGroup) { }

	// RVA: 0x1BA8B58 Offset: 0x1BA4B58 VA: 0x1BA8B58
	private void CompileGroup(XmlSchemaGroup group) { }

	// RVA: 0x1BAA06C Offset: 0x1BA606C VA: 0x1BAA06C
	private void CompileSimpleType(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1BAEFAC Offset: 0x1BAAFAC VA: 0x1BAEFAC
	private XmlSchemaSimpleType[] CompileBaseMemberTypes(XmlSchemaSimpleType simpleType) { }

	// RVA: 0x1BAF350 Offset: 0x1BAB350 VA: 0x1BAF350
	private void CheckUnionType(XmlSchemaSimpleType unionMember, ArrayList memberTypeDefinitions, XmlSchemaSimpleType parentType) { }

	// RVA: 0x1BA9528 Offset: 0x1BA5528 VA: 0x1BA9528
	private void CompileComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1BAF468 Offset: 0x1BAB468 VA: 0x1BAF468
	private void CompileSimpleContentExtension(XmlSchemaComplexType complexType, XmlSchemaSimpleContentExtension simpleExtension) { }

	// RVA: 0x1BAF6DC Offset: 0x1BAB6DC VA: 0x1BAF6DC
	private void CompileSimpleContentRestriction(XmlSchemaComplexType complexType, XmlSchemaSimpleContentRestriction simpleRestriction) { }

	// RVA: 0x1BAFAE4 Offset: 0x1BABAE4 VA: 0x1BAFAE4
	private void CompileComplexContentExtension(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentExtension complexExtension) { }

	// RVA: 0x1BAFE9C Offset: 0x1BABE9C VA: 0x1BAFE9C
	private void CompileComplexContentRestriction(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaComplexContentRestriction complexRestriction) { }

	// RVA: 0x1BAD220 Offset: 0x1BA9220 VA: 0x1BAD220
	private void CheckParticleDerivation(XmlSchemaComplexType complexType) { }

	// RVA: 0x1BAE4EC Offset: 0x1BAA4EC VA: 0x1BAE4EC
	private void CheckParticleDerivation(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1BB15F4 Offset: 0x1BAD5F4 VA: 0x1BB15F4
	private XmlSchemaParticle CompileContentTypeParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1BAE138 Offset: 0x1BAA138 VA: 0x1BAE138
	private XmlSchemaParticle CannonicalizeParticle(XmlSchemaParticle particle, bool root) { }

	// RVA: 0x1BB402C Offset: 0x1BB002C VA: 0x1BB402C
	private XmlSchemaParticle CannonicalizeElement(XmlSchemaElement element) { }

	// RVA: 0x1BB2EF8 Offset: 0x1BAEEF8 VA: 0x1BB2EF8
	private XmlSchemaParticle CannonicalizeGroupRef(XmlSchemaGroupRef groupRef, bool root) { }

	// RVA: 0x1BB3430 Offset: 0x1BAF430 VA: 0x1BB3430
	private XmlSchemaParticle CannonicalizeAll(XmlSchemaAll all, bool root) { }

	// RVA: 0x1BB36B4 Offset: 0x1BAF6B4 VA: 0x1BB36B4
	private XmlSchemaParticle CannonicalizeChoice(XmlSchemaChoice choice, bool root) { }

	// RVA: 0x1BB3B90 Offset: 0x1BAFB90 VA: 0x1BB3B90
	private XmlSchemaParticle CannonicalizeSequence(XmlSchemaSequence sequence, bool root) { }

	// RVA: 0x1BB22C0 Offset: 0x1BAE2C0 VA: 0x1BB22C0
	private XmlSchemaParticle CannonicalizePointlessRoot(XmlSchemaParticle particle) { }

	// RVA: 0x1BB2504 Offset: 0x1BAE504 VA: 0x1BB2504
	private bool IsValidRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1BB436C Offset: 0x1BB036C VA: 0x1BB436C
	private bool IsElementFromElement(XmlSchemaElement derivedElement, XmlSchemaElement baseElement) { }

	// RVA: 0x1BB458C Offset: 0x1BB058C VA: 0x1BB458C
	private bool IsElementFromAny(XmlSchemaElement derivedElement, XmlSchemaAny baseAny) { }

	// RVA: 0x1BB4740 Offset: 0x1BB0740 VA: 0x1BB4740
	private bool IsAnyFromAny(XmlSchemaAny derivedAny, XmlSchemaAny baseAny) { }

	// RVA: 0x1BB4840 Offset: 0x1BB0840 VA: 0x1BB4840
	private bool IsGroupBaseFromAny(XmlSchemaGroupBase derivedGroupBase, XmlSchemaAny baseAny) { }

	// RVA: 0x1BB4C88 Offset: 0x1BB0C88 VA: 0x1BB4C88
	private bool IsElementFromGroupBase(XmlSchemaElement derivedElement, XmlSchemaGroupBase baseGroupBase) { }

	// RVA: 0x1BB5B40 Offset: 0x1BB1B40 VA: 0x1BB5B40
	private bool IsChoiceFromChoiceSubstGroup(XmlSchemaChoice derivedChoice, XmlSchemaChoice baseChoice) { }

	// RVA: 0x1BB554C Offset: 0x1BB154C VA: 0x1BB554C
	private bool IsGroupBaseFromGroupBase(XmlSchemaGroupBase derivedGroupBase, XmlSchemaGroupBase baseGroupBase, bool skipEmptableOnly) { }

	// RVA: 0x1BB583C Offset: 0x1BB183C VA: 0x1BB583C
	private bool IsSequenceFromAll(XmlSchemaSequence derivedSequence, XmlSchemaAll baseAll) { }

	// RVA: 0x1BB5CCC Offset: 0x1BB1CCC VA: 0x1BB5CCC
	private bool IsSequenceFromChoice(XmlSchemaSequence derivedSequence, XmlSchemaChoice baseChoice) { }

	// RVA: 0x1BB6028 Offset: 0x1BB2028 VA: 0x1BB6028
	private bool IsValidOccurrenceRangeRestriction(XmlSchemaParticle derivedParticle, XmlSchemaParticle baseParticle) { }

	// RVA: 0x1BB69B4 Offset: 0x1BB29B4 VA: 0x1BB69B4
	private bool IsValidOccurrenceRangeRestriction(Decimal minOccurs, Decimal maxOccurs, Decimal baseMinOccurs, Decimal baseMaxOccurs) { }

	// RVA: 0x1BB6A9C Offset: 0x1BB2A9C VA: 0x1BB6A9C
	private int GetMappingParticle(XmlSchemaParticle particle, XmlSchemaObjectCollection collection) { }

	// RVA: 0x1BB42A8 Offset: 0x1BB02A8 VA: 0x1BB42A8
	private bool IsParticleEmptiable(XmlSchemaParticle particle) { }

	// RVA: 0x1BB61C4 Offset: 0x1BB21C4 VA: 0x1BB61C4
	private void CalculateEffectiveTotalRange(XmlSchemaParticle particle, out Decimal minOccurs, out Decimal maxOccurs) { }

	// RVA: 0x1BB6B90 Offset: 0x1BB2B90 VA: 0x1BB6B90
	private void PushComplexType(XmlSchemaComplexType complexType) { }

	// RVA: 0x1BB1754 Offset: 0x1BAD754 VA: 0x1BB1754
	private XmlSchemaContentType GetSchemaContentType(XmlSchemaComplexType complexType, XmlSchemaComplexContent complexContent, XmlSchemaParticle particle) { }

	// RVA: 0x1BA8C3C Offset: 0x1BA4C3C VA: 0x1BA8C3C
	private void CompileAttributeGroup(XmlSchemaAttributeGroup attributeGroup) { }

	// RVA: 0x1BB0190 Offset: 0x1BAC190 VA: 0x1BB0190
	private void CompileLocalAttributes(XmlSchemaComplexType baseType, XmlSchemaComplexType derivedType, XmlSchemaObjectCollection attributes, XmlSchemaAnyAttribute anyAttribute, XmlSchemaDerivationMethod derivedBy) { }

	// RVA: 0x1BAE5D4 Offset: 0x1BAA5D4 VA: 0x1BAE5D4
	private void CheckAtrributeGroupRestriction(XmlSchemaAttributeGroup baseAttributeGroup, XmlSchemaAttributeGroup derivedAttributeGroup) { }

	// RVA: 0x1BB6CD8 Offset: 0x1BB2CD8 VA: 0x1BB6CD8
	private bool IsProcessContentsRestricted(XmlSchemaComplexType baseType, XmlSchemaAnyAttribute derivedAttributeWildcard, XmlSchemaAnyAttribute baseAttributeWildcard) { }

	// RVA: 0x1BB6C44 Offset: 0x1BB2C44 VA: 0x1BB6C44
	private XmlSchemaAnyAttribute CompileAnyAttributeUnion(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1BB6BB0 Offset: 0x1BB2BB0 VA: 0x1BB6BB0
	private XmlSchemaAnyAttribute CompileAnyAttributeIntersection(XmlSchemaAnyAttribute a, XmlSchemaAnyAttribute b) { }

	// RVA: 0x1BAB874 Offset: 0x1BA7874 VA: 0x1BAB874
	private void CompileAttribute(XmlSchemaAttribute xa) { }

	// RVA: 0x1BB6DB4 Offset: 0x1BB2DB4 VA: 0x1BB6DB4
	private void SetDefaultFixed(XmlSchemaAttribute xa, SchemaAttDef decl) { }

	// RVA: 0x1BAC228 Offset: 0x1BA8228 VA: 0x1BAC228
	private void CompileIdentityConstraint(XmlSchemaIdentityConstraint xi) { }

	// RVA: 0x1BAA9A8 Offset: 0x1BA69A8 VA: 0x1BAA9A8
	private void CompileElement(XmlSchemaElement xe) { }

	// RVA: 0x1BB17C4 Offset: 0x1BAD7C4 VA: 0x1BB17C4
	private ContentValidator CompileComplexContent(XmlSchemaComplexType complexType) { }

	// RVA: 0x1BB6F7C Offset: 0x1BB2F7C VA: 0x1BB6F7C
	private bool BuildParticleContentModel(ParticleContentValidator contentValidator, XmlSchemaParticle particle) { }

	// RVA: 0x1BB749C Offset: 0x1BB349C VA: 0x1BB749C
	private void CompileParticleElements(XmlSchemaComplexType complexType, XmlSchemaParticle particle) { }

	// RVA: 0x1BAE364 Offset: 0x1BAA364 VA: 0x1BAE364
	private void CompileParticleElements(XmlSchemaParticle particle) { }

	// RVA: 0x1BAC8C8 Offset: 0x1BA88C8 VA: 0x1BAC8C8
	private void CompileComplexTypeElements(XmlSchemaComplexType complexType) { }

	// RVA: 0x1BAEED4 Offset: 0x1BAAED4 VA: 0x1BAEED4
	private XmlSchemaSimpleType GetSimpleType(XmlQualifiedName name) { }

	// RVA: 0x1BB2218 Offset: 0x1BAE218 VA: 0x1BB2218
	private XmlSchemaComplexType GetComplexType(XmlQualifiedName name) { }

	// RVA: 0x1BB20C0 Offset: 0x1BAE0C0 VA: 0x1BB20C0
	private XmlSchemaType GetAnySchemaType(XmlQualifiedName name) { }

	// RVA: 0x1BB4234 Offset: 0x1BB0234 VA: 0x1BB4234
	private void CopyPosition(XmlSchemaAnnotated to, XmlSchemaAnnotated from, bool copyParent) { }

	// RVA: 0x1BB606C Offset: 0x1BB206C VA: 0x1BB606C
	private bool IsFixedEqual(SchemaDeclBase baseDecl, SchemaDeclBase derivedDecl) { }
}

// Namespace: System.Xml.Schema
internal enum SchemaType // TypeDefIndex: 3524
{
	// Fields
	public int value__; // 0x0
	public const SchemaType None = 0;
	public const SchemaType DTD = 1;
	public const SchemaType XDR = 2;
	public const SchemaType XSD = 3;
}

// Namespace: System.Xml.Schema
public class ValidationEventArgs : EventArgs // TypeDefIndex: 3525
{
	// Fields
	private XmlSchemaException ex; // 0x10
	private XmlSeverityType severity; // 0x18

	// Properties
	public XmlSeverityType Severity { get; }
	public XmlSchemaException Exception { get; }

	// Methods

	// RVA: 0x1BB76F8 Offset: 0x1BB36F8 VA: 0x1BB76F8
	internal void .ctor(XmlSchemaException ex) { }

	// RVA: 0x1BB7774 Offset: 0x1BB3774 VA: 0x1BB7774
	internal void .ctor(XmlSchemaException ex, XmlSeverityType severity) { }

	// RVA: 0x1BB77F4 Offset: 0x1BB37F4 VA: 0x1BB77F4
	public XmlSeverityType get_Severity() { }

	// RVA: 0x1BB77FC Offset: 0x1BB37FC VA: 0x1BB77FC
	public XmlSchemaException get_Exception() { }
}

// Namespace: System.Xml.Schema
public sealed class ValidationEventHandler : MulticastDelegate // TypeDefIndex: 3526
{
	// Methods

	// RVA: 0x1BB7804 Offset: 0x1BB3804 VA: 0x1BB7804
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BB7910 Offset: 0x1BB3910 VA: 0x1BB7910 Slot: 12
	public virtual void Invoke(object sender, ValidationEventArgs e) { }
}

// Namespace: System.Xml.Schema
internal struct StateUnion // TypeDefIndex: 3527
{
	// Fields
	public int State; // 0x0
	public int AllElementsRequired; // 0x0
	public int CurPosIndex; // 0x0
	public int NumberOfRunningPos; // 0x0
}

// Namespace: System.Xml.Schema
internal sealed class ValidationState // TypeDefIndex: 3528
{
	// Fields
	public bool IsNill; // 0x10
	public bool IsDefault; // 0x11
	public bool NeedValidateChildren; // 0x12
	public bool CheckRequiredAttribute; // 0x13
	public bool ValidationSkipped; // 0x14
	public XmlSchemaContentProcessing ProcessContents; // 0x18
	public XmlSchemaValidity Validity; // 0x1C
	public SchemaElementDecl ElementDecl; // 0x20
	public SchemaElementDecl ElementDeclBeforeXsi; // 0x28
	public string LocalName; // 0x30
	public string Namespace; // 0x38
	public ConstraintStruct[] Constr; // 0x40
	public StateUnion CurrentState; // 0x48
	public bool HasMatched; // 0x4C
	public BitSet[] CurPos; // 0x50
	public BitSet AllElementsSet; // 0x58
	public List<RangePositionInfo> RunningPositions; // 0x60
	public bool TooComplex; // 0x68

	// Methods

	// RVA: 0x1BB7924 Offset: 0x1BB3924 VA: 0x1BB7924
	public void .ctor() { }
}

// Namespace: 
private sealed class XdrBuilder.DeclBaseInfo // TypeDefIndex: 3529
{
	// Fields
	internal XmlQualifiedName _Name; // 0x10
	internal string _Prefix; // 0x18
	internal XmlQualifiedName _TypeName; // 0x20
	internal string _TypePrefix; // 0x28
	internal object _Default; // 0x30
	internal object _Revises; // 0x38
	internal uint _MaxOccurs; // 0x40
	internal uint _MinOccurs; // 0x44
	internal bool _Checking; // 0x48
	internal SchemaElementDecl _ElementDecl; // 0x50
	internal SchemaAttDef _Attdef; // 0x58
	internal XdrBuilder.DeclBaseInfo _Next; // 0x60

	// Methods

	// RVA: 0x1BBC25C Offset: 0x1BB825C VA: 0x1BBC25C
	internal void .ctor() { }

	// RVA: 0x1BBC728 Offset: 0x1BB8728 VA: 0x1BBC728
	internal void Reset() { }
}

// Namespace: 
private sealed class XdrBuilder.GroupContent // TypeDefIndex: 3530
{
	// Fields
	internal uint _MinVal; // 0x10
	internal uint _MaxVal; // 0x14
	internal bool _HasMaxAttr; // 0x18
	internal bool _HasMinAttr; // 0x19
	internal int _Order; // 0x1C

	// Methods

	// RVA: 0x1BBF200 Offset: 0x1BBB200 VA: 0x1BBF200
	internal static void Copy(XdrBuilder.GroupContent from, XdrBuilder.GroupContent to) { }

	// RVA: 0x1BB9034 Offset: 0x1BB5034 VA: 0x1BB9034
	internal static XdrBuilder.GroupContent Copy(XdrBuilder.GroupContent other) { }

	// RVA: 0x1BB7C44 Offset: 0x1BB3C44 VA: 0x1BB7C44
	public void .ctor() { }
}

// Namespace: 
private sealed class XdrBuilder.ElementContent // TypeDefIndex: 3531
{
	// Fields
	internal SchemaElementDecl _ElementDecl; // 0x10
	internal int _ContentAttr; // 0x18
	internal int _OrderAttr; // 0x1C
	internal bool _MasterGroupRequired; // 0x20
	internal bool _ExistTerminal; // 0x21
	internal bool _AllowDataType; // 0x22
	internal bool _HasDataType; // 0x23
	internal bool _HasType; // 0x24
	internal bool _EnumerationRequired; // 0x25
	internal uint _MinVal; // 0x28
	internal uint _MaxVal; // 0x2C
	internal uint _MaxLength; // 0x30
	internal uint _MinLength; // 0x34
	internal Hashtable _AttDefList; // 0x38

	// Methods

	// RVA: 0x1BB7C34 Offset: 0x1BB3C34 VA: 0x1BB7C34
	public void .ctor() { }
}

// Namespace: 
private sealed class XdrBuilder.AttributeContent // TypeDefIndex: 3532
{
	// Fields
	internal SchemaAttDef _AttDef; // 0x10
	internal XmlQualifiedName _Name; // 0x18
	internal string _Prefix; // 0x20
	internal bool _Required; // 0x28
	internal uint _MinVal; // 0x2C
	internal uint _MaxVal; // 0x30
	internal uint _MaxLength; // 0x34
	internal uint _MinLength; // 0x38
	internal bool _EnumerationRequired; // 0x3C
	internal bool _HasDataType; // 0x3D
	internal bool _Global; // 0x3E
	internal object _Default; // 0x40

	// Methods

	// RVA: 0x1BB7C3C Offset: 0x1BB3C3C VA: 0x1BB7C3C
	public void .ctor() { }
}

// Namespace: 
private sealed class XdrBuilder.XdrBuildFunction : MulticastDelegate // TypeDefIndex: 3533
{
	// Methods

	// RVA: 0x1BBEDC8 Offset: 0x1BBADC8 VA: 0x1BBEDC8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BBF228 Offset: 0x1BBB228 VA: 0x1BBF228 Slot: 12
	public virtual void Invoke(XdrBuilder builder, object obj, string prefix) { }
}

// Namespace: 
private sealed class XdrBuilder.XdrInitFunction : MulticastDelegate // TypeDefIndex: 3534
{
	// Methods

	// RVA: 0x1BBEFEC Offset: 0x1BBAFEC VA: 0x1BBEFEC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BBF23C Offset: 0x1BBB23C VA: 0x1BBF23C Slot: 12
	public virtual void Invoke(XdrBuilder builder, object obj) { }
}

// Namespace: 
private sealed class XdrBuilder.XdrBeginChildFunction : MulticastDelegate // TypeDefIndex: 3535
{
	// Methods

	// RVA: 0x1BBF0A0 Offset: 0x1BBB0A0 VA: 0x1BBF0A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BBF250 Offset: 0x1BBB250 VA: 0x1BBF250 Slot: 12
	public virtual void Invoke(XdrBuilder builder) { }
}

// Namespace: 
private sealed class XdrBuilder.XdrEndChildFunction : MulticastDelegate // TypeDefIndex: 3536
{
	// Methods

	// RVA: 0x1BBF150 Offset: 0x1BBB150 VA: 0x1BBF150
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BBF264 Offset: 0x1BBB264 VA: 0x1BBF264 Slot: 12
	public virtual void Invoke(XdrBuilder builder) { }
}

// Namespace: 
private sealed class XdrBuilder.XdrAttributeEntry // TypeDefIndex: 3537
{
	// Fields
	internal SchemaNames.Token _Attribute; // 0x10
	internal int _SchemaFlags; // 0x14
	internal XmlSchemaDatatype _Datatype; // 0x18
	internal XdrBuilder.XdrBuildFunction _BuildFunc; // 0x20

	// Methods

	// RVA: 0x1BBEE7C Offset: 0x1BBAE7C VA: 0x1BBEE7C
	internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, XdrBuilder.XdrBuildFunction build) { }

	// RVA: 0x1BBEEDC Offset: 0x1BBAEDC VA: 0x1BBEEDC
	internal void .ctor(SchemaNames.Token a, XmlTokenizedType ttype, int schemaFlags, XdrBuilder.XdrBuildFunction build) { }
}

// Namespace: 
private sealed class XdrBuilder.XdrEntry // TypeDefIndex: 3538
{
	// Fields
	internal SchemaNames.Token _Name; // 0x10
	internal int[] _NextStates; // 0x18
	internal XdrBuilder.XdrAttributeEntry[] _Attributes; // 0x20
	internal XdrBuilder.XdrInitFunction _InitFunc; // 0x28
	internal XdrBuilder.XdrBeginChildFunction _BeginChildFunc; // 0x30
	internal XdrBuilder.XdrEndChildFunction _EndChildFunc; // 0x38
	internal bool _AllowText; // 0x40

	// Methods

	// RVA: 0x1BBEF40 Offset: 0x1BBAF40 VA: 0x1BBEF40
	internal void .ctor(SchemaNames.Token n, int[] states, XdrBuilder.XdrAttributeEntry[] attributes, XdrBuilder.XdrInitFunction init, XdrBuilder.XdrBeginChildFunction begin, XdrBuilder.XdrEndChildFunction end, bool fText) { }
}

// Namespace: System.Xml.Schema
internal sealed class XdrBuilder : SchemaBuilder // TypeDefIndex: 3539
{
	// Fields
	private static readonly int[] S_XDR_Root_Element; // 0x0
	private static readonly int[] S_XDR_Root_SubElements; // 0x8
	private static readonly int[] S_XDR_ElementType_SubElements; // 0x10
	private static readonly int[] S_XDR_AttributeType_SubElements; // 0x18
	private static readonly int[] S_XDR_Group_SubElements; // 0x20
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Root_Attributes; // 0x28
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementType_Attributes; // 0x30
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeType_Attributes; // 0x38
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Element_Attributes; // 0x40
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Attribute_Attributes; // 0x48
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_Group_Attributes; // 0x50
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_ElementDataType_Attributes; // 0x58
	private static readonly XdrBuilder.XdrAttributeEntry[] S_XDR_AttributeDataType_Attributes; // 0x60
	private static readonly XdrBuilder.XdrEntry[] S_SchemaEntries; // 0x68
	private SchemaInfo _SchemaInfo; // 0x10
	private string _TargetNamespace; // 0x18
	private XmlReader _reader; // 0x20
	private PositionInfo positionInfo; // 0x28
	private ParticleContentValidator _contentValidator; // 0x30
	private XdrBuilder.XdrEntry _CurState; // 0x38
	private XdrBuilder.XdrEntry _NextState; // 0x40
	private HWStack _StateHistory; // 0x48
	private HWStack _GroupStack; // 0x50
	private string _XdrName; // 0x58
	private string _XdrPrefix; // 0x60
	private XdrBuilder.ElementContent _ElementDef; // 0x68
	private XdrBuilder.GroupContent _GroupDef; // 0x70
	private XdrBuilder.AttributeContent _AttributeDef; // 0x78
	private XdrBuilder.DeclBaseInfo _UndefinedAttributeTypes; // 0x80
	private XdrBuilder.DeclBaseInfo _BaseDecl; // 0x88
	private XmlNameTable _NameTable; // 0x90
	private SchemaNames _SchemaNames; // 0x98
	private XmlNamespaceManager _CurNsMgr; // 0xA0
	private string _Text; // 0xA8
	private ValidationEventHandler validationEventHandler; // 0xB0
	private Hashtable _UndeclaredElements; // 0xB8
	private XmlResolver xmlResolver; // 0xC0

	// Properties
	internal XmlResolver XmlResolver { set; }

	// Methods

	// RVA: 0x1BB7988 Offset: 0x1BB3988 VA: 0x1BB7988
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, SchemaInfo sinfo, string targetNamspace, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x1BB7C4C Offset: 0x1BB3C4C VA: 0x1BB7C4C Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x1BB82C8 Offset: 0x1BB42C8 VA: 0x1BB82C8 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x1BB8D04 Offset: 0x1BB4D04 VA: 0x1BB8D04
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1BB8728 Offset: 0x1BB4728 VA: 0x1BB8728
	private bool LoadSchema(string uri) { }

	// RVA: 0x1BB8670 Offset: 0x1BB4670 VA: 0x1BB8670
	internal static bool IsXdrSchema(string uri) { }

	// RVA: 0x1BB8E0C Offset: 0x1BB4E0C VA: 0x1BB8E0C Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0x1BB8E14 Offset: 0x1BB4E14 VA: 0x1BB8E14 Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x1BB8E6C Offset: 0x1BB4E6C VA: 0x1BB8E6C Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0x1BB8EE8 Offset: 0x1BB4EE8 VA: 0x1BB8EE8 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0x1BB8F18 Offset: 0x1BB4F18 VA: 0x1BB8F18 Slot: 10
	internal override void EndChildren() { }

	// RVA: 0x1BB80D8 Offset: 0x1BB40D8 VA: 0x1BB80D8
	private void Push() { }

	// RVA: 0x1BB8F54 Offset: 0x1BB4F54 VA: 0x1BB8F54
	private void Pop() { }

	// RVA: 0x1BB8FE4 Offset: 0x1BB4FE4 VA: 0x1BB8FE4
	private void PushGroupInfo() { }

	// RVA: 0x1BB9098 Offset: 0x1BB5098 VA: 0x1BB9098
	private void PopGroupInfo() { }

	// RVA: 0x1BB9128 Offset: 0x1BB5128 VA: 0x1BB9128
	private static void XDR_InitRoot(XdrBuilder builder, object obj) { }

	// RVA: 0x1BB9188 Offset: 0x1BB5188 VA: 0x1BB9188
	private static void XDR_BuildRoot_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BB9200 Offset: 0x1BB5200 VA: 0x1BB9200
	private static void XDR_BuildRoot_ID(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BB9204 Offset: 0x1BB5204 VA: 0x1BB9204
	private static void XDR_BeginRoot(XdrBuilder builder) { }

	// RVA: 0x1BB92E0 Offset: 0x1BB52E0 VA: 0x1BB92E0
	private static void XDR_EndRoot(XdrBuilder builder) { }

	// RVA: 0x1BB9850 Offset: 0x1BB5850 VA: 0x1BB9850
	private static void XDR_InitElementType(XdrBuilder builder, object obj) { }

	// RVA: 0x1BB997C Offset: 0x1BB597C VA: 0x1BB997C
	private static void XDR_BuildElementType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BB9B48 Offset: 0x1BB5B48 VA: 0x1BB9B48
	private static void XDR_BuildElementType_Content(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BB9D6C Offset: 0x1BB5D6C VA: 0x1BB9D6C
	private static void XDR_BuildElementType_Model(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BB9EE4 Offset: 0x1BB5EE4 VA: 0x1BB9EE4
	private static void XDR_BuildElementType_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBA0B4 Offset: 0x1BB60B4 VA: 0x1BBA0B4
	private static void XDR_BuildElementType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBA234 Offset: 0x1BB6234 VA: 0x1BBA234
	private static void XDR_BuildElementType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBA318 Offset: 0x1BB6318 VA: 0x1BBA318
	private static void XDR_BuildElementType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBA4C0 Offset: 0x1BB64C0 VA: 0x1BBA4C0
	private static void XDR_BuildElementType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBA668 Offset: 0x1BB6668 VA: 0x1BBA668
	private static void XDR_BeginElementType(XdrBuilder builder) { }

	// RVA: 0x1BBA988 Offset: 0x1BB6988 VA: 0x1BBA988
	private static void XDR_EndElementType(XdrBuilder builder) { }

	// RVA: 0x1BBADF8 Offset: 0x1BB6DF8 VA: 0x1BBADF8
	private static void XDR_InitAttributeType(XdrBuilder builder, object obj) { }

	// RVA: 0x1BBAF04 Offset: 0x1BB6F04 VA: 0x1BBAF04
	private static void XDR_BuildAttributeType_Name(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBB15C Offset: 0x1BB715C VA: 0x1BBB15C
	private static void XDR_BuildAttributeType_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBB2E4 Offset: 0x1BB72E4 VA: 0x1BBB2E4
	private static void XDR_BuildAttributeType_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBB304 Offset: 0x1BB7304 VA: 0x1BBB304
	private static void XDR_BuildAttributeType_DtType(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBB500 Offset: 0x1BB7500 VA: 0x1BBB500
	private static void XDR_BuildAttributeType_DtValues(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBB5E4 Offset: 0x1BB75E4 VA: 0x1BBB5E4
	private static void XDR_BuildAttributeType_DtMaxLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBB654 Offset: 0x1BB7654 VA: 0x1BBB654
	private static void XDR_BuildAttributeType_DtMinLength(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBB6C4 Offset: 0x1BB76C4 VA: 0x1BBB6C4
	private static void XDR_BeginAttributeType(XdrBuilder builder) { }

	// RVA: 0x1BBB750 Offset: 0x1BB7750 VA: 0x1BBB750
	private static void XDR_EndAttributeType(XdrBuilder builder) { }

	// RVA: 0x1BBBB0C Offset: 0x1BB7B0C VA: 0x1BBBB0C
	private static void XDR_InitElement(XdrBuilder builder, object obj) { }

	// RVA: 0x1BBBBAC Offset: 0x1BB7BAC VA: 0x1BBBBAC
	private static void XDR_BuildElement_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBBDEC Offset: 0x1BB7DEC VA: 0x1BBBDEC
	private static void XDR_BuildElement_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBBF50 Offset: 0x1BB7F50 VA: 0x1BBBF50
	private static void XDR_BuildElement_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBC0EC Offset: 0x1BB80EC VA: 0x1BBC0EC
	private static void XDR_EndElement(XdrBuilder builder) { }

	// RVA: 0x1BBC1D4 Offset: 0x1BB81D4 VA: 0x1BBC1D4
	private static void XDR_InitAttribute(XdrBuilder builder, object obj) { }

	// RVA: 0x1BBC278 Offset: 0x1BB8278 VA: 0x1BBC278
	private static void XDR_BuildAttribute_Type(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBC354 Offset: 0x1BB8354 VA: 0x1BBC354
	private static void XDR_BuildAttribute_Required(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBC3D8 Offset: 0x1BB83D8 VA: 0x1BBC3D8
	private static void XDR_BuildAttribute_Default(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBC3F8 Offset: 0x1BB83F8 VA: 0x1BBC3F8
	private static void XDR_BeginAttribute(XdrBuilder builder) { }

	// RVA: 0x1BBC70C Offset: 0x1BB870C VA: 0x1BBC70C
	private static void XDR_EndAttribute(XdrBuilder builder) { }

	// RVA: 0x1BBC820 Offset: 0x1BB8820 VA: 0x1BBC820
	private static void XDR_InitGroup(XdrBuilder builder, object obj) { }

	// RVA: 0x1BBC8EC Offset: 0x1BB88EC VA: 0x1BBC8EC
	private static void XDR_BuildGroup_Order(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBC9EC Offset: 0x1BB89EC VA: 0x1BBC9EC
	private static void XDR_BuildGroup_MinOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBCA70 Offset: 0x1BB8A70 VA: 0x1BBCA70
	private static void XDR_BuildGroup_MaxOccurs(XdrBuilder builder, object obj, string prefix) { }

	// RVA: 0x1BBCAF4 Offset: 0x1BB8AF4 VA: 0x1BBCAF4
	private static void XDR_EndGroup(XdrBuilder builder) { }

	// RVA: 0x1BBCC4C Offset: 0x1BB8C4C VA: 0x1BBCC4C
	private static void XDR_InitElementDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x1BBCD10 Offset: 0x1BB8D10 VA: 0x1BBCD10
	private static void XDR_EndElementDtType(XdrBuilder builder) { }

	// RVA: 0x1BBCDF4 Offset: 0x1BB8DF4 VA: 0x1BBCDF4
	private static void XDR_InitAttributeDtType(XdrBuilder builder, object obj) { }

	// RVA: 0x1BBCE74 Offset: 0x1BB8E74 VA: 0x1BBCE74
	private static void XDR_EndAttributeDtType(XdrBuilder builder) { }

	// RVA: 0x1BB7F38 Offset: 0x1BB3F38 VA: 0x1BB7F38
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x1BB8124 Offset: 0x1BB4124 VA: 0x1BB8124
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x1BB8BCC Offset: 0x1BB4BCC VA: 0x1BB8BCC
	private bool IsSkipableAttribute(XmlQualifiedName qname) { }

	// RVA: 0x1BB9F90 Offset: 0x1BB5F90 VA: 0x1BB9F90
	private int GetOrder(XmlQualifiedName qname) { }

	// RVA: 0x1BBBD30 Offset: 0x1BB7D30 VA: 0x1BBBD30
	private void AddOrder() { }

	// RVA: 0x1BBB1D4 Offset: 0x1BB71D4 VA: 0x1BBB1D4
	private static bool IsYes(object obj, XdrBuilder builder) { }

	// RVA: 0x1BBBE60 Offset: 0x1BB7E60 VA: 0x1BBBE60
	private static uint ParseMinOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x1BBBFC4 Offset: 0x1BB7FC4 VA: 0x1BBBFC4
	private static uint ParseMaxOccurs(object obj, XdrBuilder builder) { }

	// RVA: 0x1BBC1A4 Offset: 0x1BB81A4 VA: 0x1BBC1A4
	private static void HandleMinMax(ParticleContentValidator pContent, uint cMin, uint cMax) { }

	// RVA: 0x1BBA388 Offset: 0x1BB6388 VA: 0x1BBA388
	private static void ParseDtMaxLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x1BBA530 Offset: 0x1BB6530 VA: 0x1BBA530
	private static void ParseDtMinLength(ref uint cVal, object obj, XdrBuilder builder) { }

	// RVA: 0x1BBAD64 Offset: 0x1BB6D64 VA: 0x1BBAD64
	private static void CompareMinMaxLength(uint cMin, uint cMax, XdrBuilder builder) { }

	// RVA: 0x1BBCF68 Offset: 0x1BB8F68 VA: 0x1BBCF68
	private static bool ParseInteger(string str, ref uint n) { }

	// RVA: 0x1BB9788 Offset: 0x1BB5788 VA: 0x1BB9788
	private void XDR_CheckAttributeDefault(XdrBuilder.DeclBaseInfo decl, SchemaAttDef pAttdef) { }

	// RVA: 0x1BBBAC0 Offset: 0x1BB7AC0 VA: 0x1BBBAC0
	private void SetAttributePresence(SchemaAttDef pAttdef, bool fRequired) { }

	// RVA: 0x1BB9BE4 Offset: 0x1BB5BE4 VA: 0x1BB9BE4
	private int GetContent(XmlQualifiedName qname) { }

	// RVA: 0x1BB9E0C Offset: 0x1BB5E0C VA: 0x1BB9E0C
	private bool GetModel(XmlQualifiedName qname) { }

	// RVA: 0x1BBB3BC Offset: 0x1BB73BC VA: 0x1BBB3BC
	private XmlSchemaDatatype CheckDatatype(string str) { }

	// RVA: 0x1BBB9D0 Offset: 0x1BB79D0 VA: 0x1BBB9D0
	private void CheckDefaultAttValue(SchemaAttDef attDef) { }

	// RVA: 0x1BB8664 Offset: 0x1BB4664 VA: 0x1BB8664
	private bool IsGlobal(int flags) { }

	// RVA: 0x1BB8D0C Offset: 0x1BB4D0C VA: 0x1BB8D0C
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x1BBA1C4 Offset: 0x1BB61C4 VA: 0x1BBA1C4
	private void SendValidationEvent(string code) { }

	// RVA: 0x1BB81E4 Offset: 0x1BB41E4 VA: 0x1BB81E4
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x1BBD42C Offset: 0x1BB942C VA: 0x1BBD42C
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x1BBD5C0 Offset: 0x1BB95C0 VA: 0x1BBD5C0
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal sealed class XdrValidator : BaseValidator // TypeDefIndex: 3540
{
	// Fields
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlQualifiedName name; // 0x90
	private XmlNamespaceManager nsManager; // 0x98
	private bool isProcessContents; // 0xA0
	private Hashtable IDs; // 0xA8
	private IdRefNode idRefListHead; // 0xB0
	private Parser inlineSchemaParser; // 0xB8

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }

	// Methods

	// RVA: 0x1BBF278 Offset: 0x1BBB278 VA: 0x1BBF278
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x1BBF4F4 Offset: 0x1BBB4F4 VA: 0x1BBF4F4
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1BBF300 Offset: 0x1BBB300 VA: 0x1BBF300
	private void Init() { }

	// RVA: 0x1BBF6B8 Offset: 0x1BBB6B8 VA: 0x1BBF6B8 Slot: 5
	public override void Validate() { }

	// RVA: 0x1BBF994 Offset: 0x1BBB994 VA: 0x1BBF994
	private void ValidateElement() { }

	// RVA: 0x1BBFCF0 Offset: 0x1BBBCF0 VA: 0x1BBFCF0
	private void ValidateChildElement() { }

	// RVA: 0x1BBF770 Offset: 0x1BBB770 VA: 0x1BBF770
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x1BBF780 Offset: 0x1BBB780 VA: 0x1BBF780
	private void ProcessInlineSchema() { }

	// RVA: 0x1BBFE38 Offset: 0x1BBBE38 VA: 0x1BBFE38
	private void ProcessElement() { }

	// RVA: 0x1BBFB34 Offset: 0x1BBBB34 VA: 0x1BBFB34
	private void ValidateEndElement() { }

	// RVA: 0x1BBFEF4 Offset: 0x1BBBEF4 VA: 0x1BBFEF4
	private SchemaElementDecl ThoroughGetElementDecl() { }

	// RVA: 0x1BC0204 Offset: 0x1BBC204 VA: 0x1BC0204
	private void ValidateStartElement() { }

	// RVA: 0x1BC05FC Offset: 0x1BBC5FC VA: 0x1BC05FC
	private void ValidateEndStartElement() { }

	// RVA: 0x1BC1248 Offset: 0x1BBD248 VA: 0x1BC1248
	private void LoadSchemaFromLocation(string uri) { }

	// RVA: 0x1BC0FF0 Offset: 0x1BBCFF0 VA: 0x1BC0FF0
	private void LoadSchema(string uri) { }

	// RVA: 0x1BC1854 Offset: 0x1BBD854 VA: 0x1BC1854
	private bool get_HasSchema() { }

	// RVA: 0x1BC1874 Offset: 0x1BBD874 VA: 0x1BC1874 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1BC18AC Offset: 0x1BBD8AC VA: 0x1BC18AC
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1BC1B6C Offset: 0x1BBDB6C VA: 0x1BC1B6C Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x1BC0964 Offset: 0x1BBC964 VA: 0x1BC0964
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1BBCFA0 Offset: 0x1BB8FA0 VA: 0x1BBCFA0
	public static void CheckDefaultValue(string value, SchemaAttDef attdef, SchemaInfo sinfo, XmlNamespaceManager nsManager, XmlNameTable NameTable, object sender, ValidationEventHandler eventhandler, string baseUri, int lineNo, int linePos) { }

	// RVA: 0x1BC1AD0 Offset: 0x1BBDAD0 VA: 0x1BC1AD0
	internal void AddID(string name, object node) { }

	// RVA: 0x1BC1DF0 Offset: 0x1BBDDF0 VA: 0x1BC1DF0 Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1BBF594 Offset: 0x1BBB594 VA: 0x1BBF594
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1BC0F38 Offset: 0x1BBCF38 VA: 0x1BC0F38
	private void Pop() { }

	// RVA: 0x1BC1C20 Offset: 0x1BBDC20 VA: 0x1BC1C20
	private void CheckForwardRefs() { }

	// RVA: 0x1BC1180 Offset: 0x1BBD180 VA: 0x1BC1180
	private XmlQualifiedName QualifiedName(string name, string ns) { }
}

// Namespace: 
private struct XmlAtomicValue.Union // TypeDefIndex: 3541
{
	// Fields
	public bool boolVal; // 0x0
	public double dblVal; // 0x0
	public long i64Val; // 0x0
	public int i32Val; // 0x0
	public DateTime dtVal; // 0x0
}

// Namespace: 
private class XmlAtomicValue.NamespacePrefixForQName : IXmlNamespaceResolver // TypeDefIndex: 3542
{
	// Fields
	public string prefix; // 0x10
	public string ns; // 0x18

	// Methods

	// RVA: 0x1BC2444 Offset: 0x1BBE444 VA: 0x1BC2444
	public void .ctor(string prefix, string ns) { }

	// RVA: 0x1BC30E0 Offset: 0x1BBF0E0 VA: 0x1BC30E0 Slot: 5
	public string LookupNamespace(string prefix) { }

	// RVA: 0x1BC3114 Offset: 0x1BBF114 VA: 0x1BC3114 Slot: 6
	public string LookupPrefix(string namespaceName) { }

	// RVA: 0x1BC3140 Offset: 0x1BBF140 VA: 0x1BC3140 Slot: 4
	public IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }
}

// Namespace: System.Xml.Schema
public sealed class XmlAtomicValue : XPathItem, ICloneable // TypeDefIndex: 3543
{
	// Fields
	private XmlSchemaType xmlType; // 0x10
	private object objVal; // 0x18
	private TypeCode clrType; // 0x20
	private XmlAtomicValue.Union unionVal; // 0x28
	private XmlAtomicValue.NamespacePrefixForQName nsPrefix; // 0x30

	// Properties
	public override XmlSchemaType XmlType { get; }
	public override Type ValueType { get; }
	public override object TypedValue { get; }
	public override bool ValueAsBoolean { get; }
	public override DateTime ValueAsDateTime { get; }
	public override double ValueAsDouble { get; }
	public override int ValueAsInt { get; }
	public override long ValueAsLong { get; }
	public override string Value { get; }

	// Methods

	// RVA: 0x1BC1E0C Offset: 0x1BBDE0C VA: 0x1BC1E0C
	internal void .ctor(XmlSchemaType xmlType, bool value) { }

	// RVA: 0x1BC1EA0 Offset: 0x1BBDEA0 VA: 0x1BC1EA0
	internal void .ctor(XmlSchemaType xmlType, DateTime value) { }

	// RVA: 0x1BC1F30 Offset: 0x1BBDF30 VA: 0x1BC1F30
	internal void .ctor(XmlSchemaType xmlType, double value) { }

	// RVA: 0x1BC1FC8 Offset: 0x1BBDFC8 VA: 0x1BC1FC8
	internal void .ctor(XmlSchemaType xmlType, int value) { }

	// RVA: 0x1BC2058 Offset: 0x1BBE058 VA: 0x1BC2058
	internal void .ctor(XmlSchemaType xmlType, long value) { }

	// RVA: 0x1BC20E8 Offset: 0x1BBE0E8 VA: 0x1BC20E8
	internal void .ctor(XmlSchemaType xmlType, string value) { }

	// RVA: 0x1BC219C Offset: 0x1BBE19C VA: 0x1BC219C
	internal void .ctor(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BC2488 Offset: 0x1BBE488 VA: 0x1BC2488
	internal void .ctor(XmlSchemaType xmlType, object value) { }

	// RVA: 0x1BC253C Offset: 0x1BBE53C VA: 0x1BC253C
	internal void .ctor(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BC2768 Offset: 0x1BBE768 VA: 0x1BC2768 Slot: 15
	private object System.ICloneable.Clone() { }

	// RVA: 0x1BC276C Offset: 0x1BBE76C VA: 0x1BC276C Slot: 4
	public override XmlSchemaType get_XmlType() { }

	// RVA: 0x1BC2774 Offset: 0x1BBE774 VA: 0x1BC2774 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x1BC279C Offset: 0x1BBE79C VA: 0x1BC279C Slot: 6
	public override object get_TypedValue() { }

	// RVA: 0x1BC2964 Offset: 0x1BBE964 VA: 0x1BC2964 Slot: 8
	public override bool get_ValueAsBoolean() { }

	// RVA: 0x1BC2A34 Offset: 0x1BBEA34 VA: 0x1BC2A34 Slot: 9
	public override DateTime get_ValueAsDateTime() { }

	// RVA: 0x1BC2B18 Offset: 0x1BBEB18 VA: 0x1BC2B18 Slot: 10
	public override double get_ValueAsDouble() { }

	// RVA: 0x1BC2BF8 Offset: 0x1BBEBF8 VA: 0x1BC2BF8 Slot: 11
	public override int get_ValueAsInt() { }

	// RVA: 0x1BC2CD0 Offset: 0x1BBECD0 VA: 0x1BC2CD0 Slot: 12
	public override long get_ValueAsLong() { }

	// RVA: 0x1BC2DB4 Offset: 0x1BBEDB4 VA: 0x1BC2DB4 Slot: 14
	public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BC2FDC Offset: 0x1BBEFDC VA: 0x1BC2FDC Slot: 5
	public override string get_Value() { }

	// RVA: 0x1BC30D4 Offset: 0x1BBF0D4 VA: 0x1BC30D4 Slot: 3
	public override string ToString() { }

	// RVA: 0x1BC2384 Offset: 0x1BBE384 VA: 0x1BC2384
	private string GetPrefixFromQName(string value) { }
}

// Namespace: System.Xml.Schema
[XmlRoot("schema", Namespace = "http://www.w3.org/2001/XMLSchema")]
public class XmlSchema : XmlSchemaObject // TypeDefIndex: 3544
{
	// Fields
	private XmlSchemaForm attributeFormDefault; // 0x34
	private XmlSchemaForm elementFormDefault; // 0x38
	private XmlSchemaDerivationMethod blockDefault; // 0x3C
	private XmlSchemaDerivationMethod finalDefault; // 0x40
	private string targetNs; // 0x48
	private string version; // 0x50
	private XmlSchemaObjectCollection includes; // 0x58
	private XmlSchemaObjectCollection items; // 0x60
	private string id; // 0x68
	private XmlAttribute[] moreAttributes; // 0x70
	private bool isCompiled; // 0x78
	private bool isCompiledBySet; // 0x79
	private bool isPreprocessed; // 0x7A
	private bool isRedefined; // 0x7B
	private int errorCount; // 0x7C
	private XmlSchemaObjectTable attributes; // 0x80
	private XmlSchemaObjectTable attributeGroups; // 0x88
	private XmlSchemaObjectTable elements; // 0x90
	private XmlSchemaObjectTable types; // 0x98
	private XmlSchemaObjectTable groups; // 0xA0
	private XmlSchemaObjectTable notations; // 0xA8
	private XmlSchemaObjectTable identityConstraints; // 0xB0
	private static int globalIdCounter; // 0x0
	private ArrayList importedSchemas; // 0xB8
	private ArrayList importedNamespaces; // 0xC0
	private int schemaId; // 0xC8
	private Uri baseUri; // 0xD0
	private bool isChameleon; // 0xD8
	private Hashtable ids; // 0xE0
	private XmlDocument document; // 0xE8

	// Properties
	[Xml("attributeFormDefault")]
	[DefaultValue(0)]
	public XmlSchemaForm AttributeFormDefault { get; set; }
	[DefaultValue(256)]
	[Xml("blockDefault")]
	public XmlSchemaDerivationMethod BlockDefault { get; set; }
	[Xml("finalDefault")]
	[DefaultValue(256)]
	public XmlSchemaDerivationMethod FinalDefault { get; set; }
	[Xml("elementFormDefault")]
	[DefaultValue(0)]
	public XmlSchemaForm ElementFormDefault { get; set; }
	[Xml("targetNamespace", DataType = "anyURI")]
	public string TargetNamespace { get; set; }
	[Xml("version", DataType = "token")]
	public string Version { get; set; }
	[XmlElement("import", typeof(XmlSchemaImport))]
	[XmlElement("include", typeof(XmlSchemaInclude))]
	[XmlElement("redefine", typeof(XmlSchemaRedefine))]
	public XmlSchemaObjectCollection Includes { get; }
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("notation", typeof(XmlSchemaNotation))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnore]
	internal bool IsCompiledBySet { get; set; }
	[XmlIgnore]
	internal bool IsPreprocessed { get; set; }
	[XmlIgnore]
	internal bool IsRedefined { get; set; }
	[XmlIgnore]
	public XmlSchemaObjectTable Attributes { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable Elements { get; }
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlIgnore]
	public XmlSchemaObjectTable Groups { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable Notations { get; }
	[XmlIgnore]
	internal XmlSchemaObjectTable IdentityConstraints { get; }
	[XmlIgnore]
	internal Uri BaseUri { get; set; }
	[XmlIgnore]
	internal int SchemaId { get; }
	[XmlIgnore]
	internal bool IsChameleon { get; set; }
	[XmlIgnore]
	internal Hashtable Ids { get; }
	[XmlIgnore]
	internal XmlDocument Document { get; }
	[XmlIgnore]
	internal int ErrorCount { get; set; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }
	internal ArrayList ImportedSchemas { get; }
	internal ArrayList ImportedNamespaces { get; }

	// Methods

	// RVA: 0x1BC31E4 Offset: 0x1BBF1E4 VA: 0x1BC31E4
	public void .ctor() { }

	// RVA: 0x1BC33C0 Offset: 0x1BBF3C0 VA: 0x1BC33C0
	public static XmlSchema Read(XmlReader reader, ValidationEventHandler validationEventHandler) { }

	// RVA: 0x1BC3574 Offset: 0x1BBF574 VA: 0x1BC3574
	internal bool CompileSchema(XmlSchemaCollection xsc, XmlResolver resolver, SchemaInfo schemaInfo, string ns, ValidationEventHandler validationEventHandler, XmlNameTable nameTable, bool CompileContentModel) { }

	// RVA: 0x1BC3768 Offset: 0x1BBF768 VA: 0x1BC3768
	internal void CompileSchemaInSet(XmlNameTable nameTable, ValidationEventHandler eventHandler, XmlSchemaCompilationSettings compilationSettings) { }

	// RVA: 0x1BC3818 Offset: 0x1BBF818 VA: 0x1BC3818
	public XmlSchemaForm get_AttributeFormDefault() { }

	// RVA: 0x1BC3820 Offset: 0x1BBF820 VA: 0x1BC3820
	public void set_AttributeFormDefault(XmlSchemaForm value) { }

	// RVA: 0x1BC3828 Offset: 0x1BBF828 VA: 0x1BC3828
	public XmlSchemaDerivationMethod get_BlockDefault() { }

	// RVA: 0x1BC3830 Offset: 0x1BBF830 VA: 0x1BC3830
	public void set_BlockDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1BC3838 Offset: 0x1BBF838 VA: 0x1BC3838
	public XmlSchemaDerivationMethod get_FinalDefault() { }

	// RVA: 0x1BC3840 Offset: 0x1BBF840 VA: 0x1BC3840
	public void set_FinalDefault(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1BC3848 Offset: 0x1BBF848 VA: 0x1BC3848
	public XmlSchemaForm get_ElementFormDefault() { }

	// RVA: 0x1BC3850 Offset: 0x1BBF850 VA: 0x1BC3850
	public void set_ElementFormDefault(XmlSchemaForm value) { }

	// RVA: 0x1BC3858 Offset: 0x1BBF858 VA: 0x1BC3858
	public string get_TargetNamespace() { }

	// RVA: 0x1BC3860 Offset: 0x1BBF860 VA: 0x1BC3860
	public void set_TargetNamespace(string value) { }

	// RVA: 0x1BC3868 Offset: 0x1BBF868 VA: 0x1BC3868
	public string get_Version() { }

	// RVA: 0x1BC3870 Offset: 0x1BBF870 VA: 0x1BC3870
	public void set_Version(string value) { }

	// RVA: 0x1BC3878 Offset: 0x1BBF878 VA: 0x1BC3878
	public XmlSchemaObjectCollection get_Includes() { }

	// RVA: 0x1BC3880 Offset: 0x1BBF880 VA: 0x1BC3880
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1BC3888 Offset: 0x1BBF888 VA: 0x1BC3888
	internal bool get_IsCompiledBySet() { }

	// RVA: 0x1BC3890 Offset: 0x1BBF890 VA: 0x1BC3890
	internal void set_IsCompiledBySet(bool value) { }

	// RVA: 0x1BC3898 Offset: 0x1BBF898 VA: 0x1BC3898
	internal bool get_IsPreprocessed() { }

	// RVA: 0x1BC38A0 Offset: 0x1BBF8A0 VA: 0x1BC38A0
	internal void set_IsPreprocessed(bool value) { }

	// RVA: 0x1BC38A8 Offset: 0x1BBF8A8 VA: 0x1BC38A8
	internal bool get_IsRedefined() { }

	// RVA: 0x1BC38B0 Offset: 0x1BBF8B0 VA: 0x1BC38B0
	internal void set_IsRedefined(bool value) { }

	// RVA: 0x1BC38B8 Offset: 0x1BBF8B8 VA: 0x1BC38B8
	public XmlSchemaObjectTable get_Attributes() { }

	// RVA: 0x1BC3928 Offset: 0x1BBF928 VA: 0x1BC3928
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x1BC3998 Offset: 0x1BBF998 VA: 0x1BC3998
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x1BC3A08 Offset: 0x1BBFA08 VA: 0x1BC3A08
	public XmlSchemaObjectTable get_Elements() { }

	// RVA: 0x1BC3A78 Offset: 0x1BBFA78 VA: 0x1BC3A78
	public string get_Id() { }

	// RVA: 0x1BC3A80 Offset: 0x1BBFA80 VA: 0x1BC3A80
	public void set_Id(string value) { }

	// RVA: 0x1BC3A88 Offset: 0x1BBFA88 VA: 0x1BC3A88
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x1BC3A90 Offset: 0x1BBFA90 VA: 0x1BC3A90
	public XmlSchemaObjectTable get_Notations() { }

	// RVA: 0x1BC3A98 Offset: 0x1BBFA98 VA: 0x1BC3A98
	internal XmlSchemaObjectTable get_IdentityConstraints() { }

	// RVA: 0x1BC3AA0 Offset: 0x1BBFAA0 VA: 0x1BC3AA0
	internal Uri get_BaseUri() { }

	// RVA: 0x1BC3AA8 Offset: 0x1BBFAA8 VA: 0x1BC3AA8
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x1BC3AB0 Offset: 0x1BBFAB0 VA: 0x1BC3AB0
	internal int get_SchemaId() { }

	// RVA: 0x1BC3B20 Offset: 0x1BBFB20 VA: 0x1BC3B20
	internal bool get_IsChameleon() { }

	// RVA: 0x1BC3B28 Offset: 0x1BBFB28 VA: 0x1BC3B28
	internal void set_IsChameleon(bool value) { }

	// RVA: 0x1BC3B30 Offset: 0x1BBFB30 VA: 0x1BC3B30
	internal Hashtable get_Ids() { }

	// RVA: 0x1BC3B38 Offset: 0x1BBFB38 VA: 0x1BC3B38
	internal XmlDocument get_Document() { }

	// RVA: 0x1BC3BA8 Offset: 0x1BBFBA8 VA: 0x1BC3BA8
	internal int get_ErrorCount() { }

	// RVA: 0x1BC3BB0 Offset: 0x1BBFBB0 VA: 0x1BC3BB0
	internal void set_ErrorCount(int value) { }

	// RVA: 0x1BC3BB8 Offset: 0x1BBFBB8 VA: 0x1BC3BB8
	internal XmlSchema Clone() { }

	// RVA: 0x1BC3D00 Offset: 0x1BBFD00 VA: 0x1BC3D00
	internal XmlSchema DeepClone() { }

	// RVA: 0x1BC4C00 Offset: 0x1BC0C00 VA: 0x1BC4C00 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x1BC4C08 Offset: 0x1BC0C08 VA: 0x1BC4C08 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x1BC4C10 Offset: 0x1BC0C10 VA: 0x1BC4C10
	internal void SetIsCompiled(bool isCompiled) { }

	// RVA: 0x1BC4C18 Offset: 0x1BC0C18 VA: 0x1BC4C18 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1BC4C20 Offset: 0x1BC0C20 VA: 0x1BC4C20 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x1BC4C34 Offset: 0x1BC0C34 VA: 0x1BC4C34
	internal ArrayList get_ImportedSchemas() { }

	// RVA: 0x1BC4CA4 Offset: 0x1BC0CA4 VA: 0x1BC4CA4
	internal ArrayList get_ImportedNamespaces() { }

	// RVA: 0x1BC4D14 Offset: 0x1BC0D14 VA: 0x1BC4D14
	internal void GetExternalSchemasList(IList extList, XmlSchema schema) { }

	// RVA: 0x1BC4ED4 Offset: 0x1BC0ED4 VA: 0x1BC4ED4
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAll : XmlSchemaGroupBase // TypeDefIndex: 3545
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElement("element", typeof(XmlSchemaElement))]
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x1BC4F20 Offset: 0x1BC0F20 VA: 0x1BC4F20 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1BC4F28 Offset: 0x1BC0F28 VA: 0x1BC4F28 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x1BC4F68 Offset: 0x1BC0F68 VA: 0x1BC4F68 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x1BC4F70 Offset: 0x1BC0F70 VA: 0x1BC4F70
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAnnotated : XmlSchemaObject // TypeDefIndex: 3546
{
	// Fields
	private string id; // 0x38
	private XmlSchemaAnnotation annotation; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	public XmlSchemaAnnotation Annotation { get; set; }
	[XmlAny]
	public XmlAttribute[] UnhandledAttributes { get; set; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x1BC5030 Offset: 0x1BC1030 VA: 0x1BC5030
	public string get_Id() { }

	// RVA: 0x1BC5038 Offset: 0x1BC1038 VA: 0x1BC5038
	public void set_Id(string value) { }

	// RVA: 0x1BC5040 Offset: 0x1BC1040 VA: 0x1BC5040
	public XmlSchemaAnnotation get_Annotation() { }

	// RVA: 0x1BC5048 Offset: 0x1BC1048 VA: 0x1BC5048
	public void set_Annotation(XmlSchemaAnnotation value) { }

	// RVA: 0x1BC5050 Offset: 0x1BC1050 VA: 0x1BC5050
	public XmlAttribute[] get_UnhandledAttributes() { }

	// RVA: 0x1BC5058 Offset: 0x1BC1058 VA: 0x1BC5058
	public void set_UnhandledAttributes(XmlAttribute[] value) { }

	// RVA: 0x1BC5060 Offset: 0x1BC1060 VA: 0x1BC5060 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x1BC5068 Offset: 0x1BC1068 VA: 0x1BC5068 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x1BC5070 Offset: 0x1BC1070 VA: 0x1BC5070 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1BC5078 Offset: 0x1BC1078 VA: 0x1BC5078 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x1BC5080 Offset: 0x1BC1080 VA: 0x1BC5080
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAnnotation : XmlSchemaObject // TypeDefIndex: 3547
{
	// Fields
	private string id; // 0x38
	private XmlSchemaObjectCollection items; // 0x40
	private XmlAttribute[] moreAttributes; // 0x48

	// Properties
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlElement("documentation", typeof(XmlSchemaDocumentation))]
	[XmlElement("appinfo", typeof(XmlSchemaAppInfo))]
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }

	// Methods

	// RVA: 0x1BC5088 Offset: 0x1BC1088 VA: 0x1BC5088
	public string get_Id() { }

	// RVA: 0x1BC5090 Offset: 0x1BC1090 VA: 0x1BC5090
	public void set_Id(string value) { }

	// RVA: 0x1BC5098 Offset: 0x1BC1098 VA: 0x1BC5098
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1BC50A0 Offset: 0x1BC10A0 VA: 0x1BC50A0 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x1BC50A8 Offset: 0x1BC10A8 VA: 0x1BC50A8 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x1BC50B0 Offset: 0x1BC10B0 VA: 0x1BC50B0 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1BC50B8 Offset: 0x1BC10B8 VA: 0x1BC50B8
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAny : XmlSchemaParticle // TypeDefIndex: 3548
{
	// Fields
	private string ns; // 0x78
	private XmlSchemaContentProcessing processContents; // 0x80
	private NamespaceList namespaceList; // 0x88

	// Properties
	[Xml("namespace")]
	public string Namespace { get; set; }
	[Xml("processContents")]
	[DefaultValue(0)]
	public XmlSchemaContentProcessing ProcessContents { set; }
	[XmlIgnore]
	internal NamespaceList NamespaceList { get; }
	[XmlIgnore]
	internal string ResolvedNamespace { get; }
	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }
	internal override string NameString { get; }

	// Methods

	// RVA: 0x1BC5124 Offset: 0x1BC1124 VA: 0x1BC5124
	public string get_Namespace() { }

	// RVA: 0x1BC512C Offset: 0x1BC112C VA: 0x1BC512C
	public void set_Namespace(string value) { }

	// RVA: 0x1BC5134 Offset: 0x1BC1134 VA: 0x1BC5134
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x1BC513C Offset: 0x1BC113C VA: 0x1BC513C
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x1BC5144 Offset: 0x1BC1144 VA: 0x1BC5144
	internal string get_ResolvedNamespace() { }

	// RVA: 0x1BC519C Offset: 0x1BC119C VA: 0x1BC519C
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x1BC51B0 Offset: 0x1BC11B0 VA: 0x1BC51B0 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x1BC5668 Offset: 0x1BC1668 VA: 0x1BC5668
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x1BC56F0 Offset: 0x1BC16F0 VA: 0x1BC56F0
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x1BC5798 Offset: 0x1BC1798 VA: 0x1BC5798
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x1BC57C0 Offset: 0x1BC17C0 VA: 0x1BC57C0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAnyAttribute : XmlSchemaAnnotated // TypeDefIndex: 3549
{
	// Fields
	private string ns; // 0x50
	private XmlSchemaContentProcessing processContents; // 0x58
	private NamespaceList namespaceList; // 0x60

	// Properties
	[Xml("namespace")]
	public string Namespace { set; }
	[DefaultValue(0)]
	[Xml("processContents")]
	public XmlSchemaContentProcessing ProcessContents { get; set; }
	[XmlIgnore]
	internal NamespaceList NamespaceList { get; }
	[XmlIgnore]
	internal XmlSchemaContentProcessing ProcessContentsCorrect { get; }

	// Methods

	// RVA: 0x1BC5818 Offset: 0x1BC1818 VA: 0x1BC5818
	public void set_Namespace(string value) { }

	// RVA: 0x1BC5820 Offset: 0x1BC1820 VA: 0x1BC5820
	public XmlSchemaContentProcessing get_ProcessContents() { }

	// RVA: 0x1BC5828 Offset: 0x1BC1828 VA: 0x1BC5828
	public void set_ProcessContents(XmlSchemaContentProcessing value) { }

	// RVA: 0x1BC5830 Offset: 0x1BC1830 VA: 0x1BC5830
	internal NamespaceList get_NamespaceList() { }

	// RVA: 0x1BC5838 Offset: 0x1BC1838 VA: 0x1BC5838
	internal XmlSchemaContentProcessing get_ProcessContentsCorrect() { }

	// RVA: 0x1BC584C Offset: 0x1BC184C VA: 0x1BC584C
	internal void BuildNamespaceList(string targetNamespace) { }

	// RVA: 0x1BC58D4 Offset: 0x1BC18D4 VA: 0x1BC58D4
	internal void BuildNamespaceListV1Compat(string targetNamespace) { }

	// RVA: 0x1BC597C Offset: 0x1BC197C VA: 0x1BC597C
	internal bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x1BC59A4 Offset: 0x1BC19A4 VA: 0x1BC59A4
	internal static bool IsSubset(XmlSchemaAnyAttribute sub, XmlSchemaAnyAttribute super) { }

	// RVA: 0x1BC59C8 Offset: 0x1BC19C8 VA: 0x1BC59C8
	internal static XmlSchemaAnyAttribute Intersection(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x1BC5A94 Offset: 0x1BC1A94 VA: 0x1BC5A94
	internal static XmlSchemaAnyAttribute Union(XmlSchemaAnyAttribute o1, XmlSchemaAnyAttribute o2, bool v1Compat) { }

	// RVA: 0x1BC5A8C Offset: 0x1BC1A8C VA: 0x1BC5A8C
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAppInfo : XmlSchemaObject // TypeDefIndex: 3550
{
	// Fields
	private string source; // 0x38
	private XmlNode[] markup; // 0x40

	// Properties
	[Xml("source", DataType = "anyURI")]
	public string Source { set; }
	[XmlText]
	[XmlAnyElement]
	public XmlNode[] Markup { get; set; }

	// Methods

	// RVA: 0x1BC5B58 Offset: 0x1BC1B58 VA: 0x1BC5B58
	public void set_Source(string value) { }

	// RVA: 0x1BC5B60 Offset: 0x1BC1B60 VA: 0x1BC5B60
	public XmlNode[] get_Markup() { }

	// RVA: 0x1BC5B68 Offset: 0x1BC1B68 VA: 0x1BC5B68
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x1BC5B70 Offset: 0x1BC1B70 VA: 0x1BC5B70
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAttribute : XmlSchemaAnnotated // TypeDefIndex: 3551
{
	// Fields
	private string defaultValue; // 0x50
	private string fixedValue; // 0x58
	private string name; // 0x60
	private XmlSchemaForm form; // 0x68
	private XmlSchemaUse use; // 0x6C
	private XmlQualifiedName refName; // 0x70
	private XmlQualifiedName typeName; // 0x78
	private XmlQualifiedName qualifiedName; // 0x80
	private XmlSchemaSimpleType type; // 0x88
	private XmlSchemaSimpleType attributeType; // 0x90
	private SchemaAttDef attDef; // 0x98

	// Properties
	[Xml("default")]
	[DefaultValue(null)]
	public string DefaultValue { get; set; }
	[DefaultValue(null)]
	[Xml("fixed")]
	public string FixedValue { get; set; }
	[DefaultValue(0)]
	[Xml("form")]
	public XmlSchemaForm Form { get; set; }
	[Xml("name")]
	public string Name { get; set; }
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }
	[Xml("type")]
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElement("simpleType")]
	public XmlSchemaSimpleType SchemaType { get; set; }
	[DefaultValue(0)]
	[Xml("use")]
	public XmlSchemaUse Use { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	public XmlSchemaSimpleType AttributeSchemaType { get; }
	[XmlIgnore]
	internal XmlSchemaDatatype Datatype { get; }
	internal SchemaAttDef AttDef { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x1BC5B78 Offset: 0x1BC1B78 VA: 0x1BC5B78
	public string get_DefaultValue() { }

	// RVA: 0x1BC5B80 Offset: 0x1BC1B80 VA: 0x1BC5B80
	public void set_DefaultValue(string value) { }

	// RVA: 0x1BC5B88 Offset: 0x1BC1B88 VA: 0x1BC5B88
	public string get_FixedValue() { }

	// RVA: 0x1BC5B90 Offset: 0x1BC1B90 VA: 0x1BC5B90
	public void set_FixedValue(string value) { }

	// RVA: 0x1BC5B98 Offset: 0x1BC1B98 VA: 0x1BC5B98
	public XmlSchemaForm get_Form() { }

	// RVA: 0x1BC5BA0 Offset: 0x1BC1BA0 VA: 0x1BC5BA0
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x1BC5BA8 Offset: 0x1BC1BA8 VA: 0x1BC5BA8
	public string get_Name() { }

	// RVA: 0x1BC5BB0 Offset: 0x1BC1BB0 VA: 0x1BC5BB0
	public void set_Name(string value) { }

	// RVA: 0x1BC5BB8 Offset: 0x1BC1BB8 VA: 0x1BC5BB8
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1BC5BC0 Offset: 0x1BC1BC0 VA: 0x1BC5BC0
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x1BC5C60 Offset: 0x1BC1C60 VA: 0x1BC5C60
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x1BC5C68 Offset: 0x1BC1C68 VA: 0x1BC5C68
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x1BC5D08 Offset: 0x1BC1D08 VA: 0x1BC5D08
	public XmlSchemaSimpleType get_SchemaType() { }

	// RVA: 0x1BC5D10 Offset: 0x1BC1D10 VA: 0x1BC5D10
	public void set_SchemaType(XmlSchemaSimpleType value) { }

	// RVA: 0x1BC5D18 Offset: 0x1BC1D18 VA: 0x1BC5D18
	public XmlSchemaUse get_Use() { }

	// RVA: 0x1BC5D20 Offset: 0x1BC1D20 VA: 0x1BC5D20
	public void set_Use(XmlSchemaUse value) { }

	// RVA: 0x1BC5D28 Offset: 0x1BC1D28 VA: 0x1BC5D28
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1BC5D30 Offset: 0x1BC1D30 VA: 0x1BC5D30
	public XmlSchemaSimpleType get_AttributeSchemaType() { }

	// RVA: 0x1BC5D38 Offset: 0x1BC1D38 VA: 0x1BC5D38
	internal XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x1BC5D50 Offset: 0x1BC1D50 VA: 0x1BC5D50
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1BC5D58 Offset: 0x1BC1D58 VA: 0x1BC5D58
	internal void SetAttributeType(XmlSchemaSimpleType value) { }

	// RVA: 0x1BC5D60 Offset: 0x1BC1D60 VA: 0x1BC5D60
	internal SchemaAttDef get_AttDef() { }

	// RVA: 0x1BC5D68 Offset: 0x1BC1D68 VA: 0x1BC5D68
	internal void set_AttDef(SchemaAttDef value) { }

	// RVA: 0x1BC5D70 Offset: 0x1BC1D70 VA: 0x1BC5D70 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x1BC5D78 Offset: 0x1BC1D78 VA: 0x1BC5D78 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1BC5D80 Offset: 0x1BC1D80 VA: 0x1BC5D80 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1BC5E84 Offset: 0x1BC1E84 VA: 0x1BC5E84
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAttributeGroup : XmlSchemaAnnotated // TypeDefIndex: 3552
{
	// Fields
	private string name; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaAttributeGroup redefined; // 0x70
	private XmlSchemaObjectTable attributeUses; // 0x78
	private XmlSchemaAnyAttribute attributeWildcard; // 0x80
	private int selfReferenceCount; // 0x88

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	internal XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnore]
	internal XmlSchemaAnyAttribute AttributeWildcard { get; set; }
	[XmlIgnore]
	public XmlSchemaAttributeGroup RedefinedAttributeGroup { get; }
	[XmlIgnore]
	internal XmlSchemaAttributeGroup Redefined { get; set; }
	[XmlIgnore]
	internal int SelfReferenceCount { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x1BC5F24 Offset: 0x1BC1F24 VA: 0x1BC5F24
	public string get_Name() { }

	// RVA: 0x1BC5F2C Offset: 0x1BC1F2C VA: 0x1BC5F2C
	public void set_Name(string value) { }

	// RVA: 0x1BC5F34 Offset: 0x1BC1F34 VA: 0x1BC5F34
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x1BC5F3C Offset: 0x1BC1F3C VA: 0x1BC5F3C
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1BC5F44 Offset: 0x1BC1F44 VA: 0x1BC5F44
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1BC5F4C Offset: 0x1BC1F4C VA: 0x1BC5F4C
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1BC5F54 Offset: 0x1BC1F54 VA: 0x1BC5F54
	internal XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x1BC5FC4 Offset: 0x1BC1FC4 VA: 0x1BC5FC4
	internal XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x1BC5FCC Offset: 0x1BC1FCC VA: 0x1BC5FCC
	internal void set_AttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1BC5FD4 Offset: 0x1BC1FD4 VA: 0x1BC5FD4
	public XmlSchemaAttributeGroup get_RedefinedAttributeGroup() { }

	// RVA: 0x1BC5FDC Offset: 0x1BC1FDC VA: 0x1BC5FDC
	internal XmlSchemaAttributeGroup get_Redefined() { }

	// RVA: 0x1BC5FE4 Offset: 0x1BC1FE4 VA: 0x1BC5FE4
	internal void set_Redefined(XmlSchemaAttributeGroup value) { }

	// RVA: 0x1BC5FEC Offset: 0x1BC1FEC VA: 0x1BC5FEC
	internal int get_SelfReferenceCount() { }

	// RVA: 0x1BC5FF4 Offset: 0x1BC1FF4 VA: 0x1BC5FF4
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x1BC5FFC Offset: 0x1BC1FFC VA: 0x1BC5FFC Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x1BC6004 Offset: 0x1BC2004 VA: 0x1BC6004 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1BC600C Offset: 0x1BC200C VA: 0x1BC600C
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1BC6014 Offset: 0x1BC2014 VA: 0x1BC6014 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1BC64C8 Offset: 0x1BC24C8 VA: 0x1BC64C8
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated // TypeDefIndex: 3553
{
	// Fields
	private XmlQualifiedName refName; // 0x50

	// Properties
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }

	// Methods

	// RVA: 0x1BC6578 Offset: 0x1BC2578 VA: 0x1BC6578
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1BC6580 Offset: 0x1BC2580 VA: 0x1BC6580
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x1BC6620 Offset: 0x1BC2620 VA: 0x1BC6620
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaChoice : XmlSchemaGroupBase // TypeDefIndex: 3554
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("element", typeof(XmlSchemaElement))]
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x1BC6690 Offset: 0x1BC2690 VA: 0x1BC6690 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1BC6698 Offset: 0x1BC2698 VA: 0x1BC6698 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x1BC66A0 Offset: 0x1BC26A0 VA: 0x1BC66A0 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x1BC66A8 Offset: 0x1BC26A8 VA: 0x1BC66A8
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
[Obsolete("Use System.Xml.Schema.XmlSchemaSet for schema compilation and validation. https://go.microsoft.com/fwlink/?linkid=14202")]
public sealed class XmlSchemaCollection : ICollection, IEnumerable // TypeDefIndex: 3555
{
	// Fields
	private Hashtable collection; // 0x10
	private XmlNameTable nameTable; // 0x18
	private SchemaNames schemaNames; // 0x20
	private ReaderWriterLock wLock; // 0x28
	private int timeout; // 0x30
	private bool isThreadSafe; // 0x34
	private ValidationEventHandler validationEventHandler; // 0x38
	private XmlResolver xmlResolver; // 0x40

	// Properties
	public int Count { get; }
	public XmlNameTable NameTable { get; }
	internal XmlResolver XmlResolver { set; }
	public XmlSchema Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	internal ValidationEventHandler EventHandler { get; set; }

	// Methods

	// RVA: 0x1BC6710 Offset: 0x1BC2710 VA: 0x1BC6710
	public void .ctor(XmlNameTable nametable) { }

	// RVA: 0x1BC6854 Offset: 0x1BC2854 VA: 0x1BC6854
	public int get_Count() { }

	// RVA: 0x1BC6874 Offset: 0x1BC2874 VA: 0x1BC6874
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1BC687C Offset: 0x1BC287C VA: 0x1BC687C
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1BC6884 Offset: 0x1BC2884 VA: 0x1BC6884
	public XmlSchema get_Item(string ns) { }

	// RVA: 0x1BC691C Offset: 0x1BC291C VA: 0x1BC691C Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1BC69C4 Offset: 0x1BC29C4 VA: 0x1BC69C4
	public XmlSchemaCollectionEnumerator GetEnumerator() { }

	// RVA: 0x1BC6A20 Offset: 0x1BC2A20 VA: 0x1BC6A20 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1BC6CAC Offset: 0x1BC2CAC VA: 0x1BC6CAC Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1BC6CB4 Offset: 0x1BC2CB4 VA: 0x1BC6CB4 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1BC6CB8 Offset: 0x1BC2CB8 VA: 0x1BC6CB8 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1BC17BC Offset: 0x1BBD7BC VA: 0x1BC17BC
	internal SchemaInfo GetSchemaInfo(string ns) { }

	// RVA: 0x1BC6CD8 Offset: 0x1BC2CD8 VA: 0x1BC6CD8
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x1BBFEEC Offset: 0x1BBBEEC VA: 0x1BBFEEC
	internal XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile) { }

	// RVA: 0x1BC6D7C Offset: 0x1BC2D7C VA: 0x1BC6D7C
	private XmlSchema Add(string ns, SchemaInfo schemaInfo, XmlSchema schema, bool compile, XmlResolver resolver) { }

	// RVA: 0x1BC6EE8 Offset: 0x1BC2EE8 VA: 0x1BC6EE8
	private void Add(string ns, XmlSchemaCollectionNode node) { }

	// RVA: 0x1BC7028 Offset: 0x1BC3028 VA: 0x1BC7028
	internal ValidationEventHandler get_EventHandler() { }

	// RVA: 0x1BC7030 Offset: 0x1BC3030 VA: 0x1BC7030
	internal void set_EventHandler(ValidationEventHandler value) { }
}

// Namespace: System.Xml.Schema
internal sealed class XmlSchemaCollectionNode // TypeDefIndex: 3556
{
	// Fields
	private string namespaceUri; // 0x10
	private SchemaInfo schemaInfo; // 0x18
	private XmlSchema schema; // 0x20

	// Properties
	internal string NamespaceURI { set; }
	internal SchemaInfo SchemaInfo { get; set; }
	internal XmlSchema Schema { get; set; }

	// Methods

	// RVA: 0x1BC7038 Offset: 0x1BC3038 VA: 0x1BC7038
	internal void set_NamespaceURI(string value) { }

	// RVA: 0x1BC7040 Offset: 0x1BC3040 VA: 0x1BC7040
	internal SchemaInfo get_SchemaInfo() { }

	// RVA: 0x1BC7048 Offset: 0x1BC3048 VA: 0x1BC7048
	internal void set_SchemaInfo(SchemaInfo value) { }

	// RVA: 0x1BC7050 Offset: 0x1BC3050 VA: 0x1BC7050
	internal XmlSchema get_Schema() { }

	// RVA: 0x1BC7058 Offset: 0x1BC3058 VA: 0x1BC7058
	internal void set_Schema(XmlSchema value) { }

	// RVA: 0x1BC6EE0 Offset: 0x1BC2EE0 VA: 0x1BC6EE0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCollectionEnumerator : IEnumerator // TypeDefIndex: 3557
{
	// Fields
	private IDictionaryEnumerator enumerator; // 0x10

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public XmlSchema Current { get; }
	internal XmlSchemaCollectionNode CurrentNode { get; }

	// Methods

	// RVA: 0x1BC6978 Offset: 0x1BC2978 VA: 0x1BC6978
	internal void .ctor(Hashtable collection) { }

	// RVA: 0x1BC7060 Offset: 0x1BC3060 VA: 0x1BC7060 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1BC7104 Offset: 0x1BC3104 VA: 0x1BC7104 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1BC6C0C Offset: 0x1BC2C0C VA: 0x1BC6C0C
	public bool MoveNext() { }

	// RVA: 0x1BC71A4 Offset: 0x1BC31A4 VA: 0x1BC71A4 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1BC6B34 Offset: 0x1BC2B34 VA: 0x1BC6B34
	public XmlSchema get_Current() { }

	// RVA: 0x1BC71A8 Offset: 0x1BC31A8 VA: 0x1BC71A8
	internal XmlSchemaCollectionNode get_CurrentNode() { }
}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaCompilationSettings // TypeDefIndex: 3558
{
	// Fields
	private bool enableUpaCheck; // 0x10

	// Properties
	public bool EnableUpaCheck { get; }

	// Methods

	// RVA: 0x1BC727C Offset: 0x1BC327C VA: 0x1BC727C
	public void .ctor() { }

	// RVA: 0x1BC729C Offset: 0x1BC329C VA: 0x1BC729C
	public bool get_EnableUpaCheck() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexContent : XmlSchemaContentModel // TypeDefIndex: 3559
{
	// Fields
	private XmlSchemaContent content; // 0x50
	private bool isMixed; // 0x58
	private bool hasMixedAttribute; // 0x59

	// Properties
	[Xml("mixed")]
	public bool IsMixed { get; set; }
	[XmlElement("restriction", typeof(XmlSchemaComplexContentRestriction))]
	[XmlElement("extension", typeof(XmlSchemaComplexContentExtension))]
	public override XmlSchemaContent Content { get; set; }
	[XmlIgnore]
	internal bool HasMixedAttribute { get; }

	// Methods

	// RVA: 0x1BC72A4 Offset: 0x1BC32A4 VA: 0x1BC72A4
	public bool get_IsMixed() { }

	// RVA: 0x1BC72AC Offset: 0x1BC32AC VA: 0x1BC72AC
	public void set_IsMixed(bool value) { }

	// RVA: 0x1BC72BC Offset: 0x1BC32BC VA: 0x1BC72BC Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x1BC72C4 Offset: 0x1BC32C4 VA: 0x1BC72C4 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x1BC72CC Offset: 0x1BC32CC VA: 0x1BC72CC
	internal bool get_HasMixedAttribute() { }

	// RVA: 0x1BC72D4 Offset: 0x1BC32D4 VA: 0x1BC72D4
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexContentExtension : XmlSchemaContent // TypeDefIndex: 3560
{
	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	public XmlSchemaParticle Particle { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x1BC72E4 Offset: 0x1BC32E4 VA: 0x1BC72E4
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1BC72EC Offset: 0x1BC32EC VA: 0x1BC72EC
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x1BC738C Offset: 0x1BC338C VA: 0x1BC738C
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x1BC7394 Offset: 0x1BC3394 VA: 0x1BC7394
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x1BC739C Offset: 0x1BC339C VA: 0x1BC739C
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x1BC73A4 Offset: 0x1BC33A4 VA: 0x1BC73A4
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1BC73AC Offset: 0x1BC33AC VA: 0x1BC73AC
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1BC73B4 Offset: 0x1BC33B4 VA: 0x1BC73B4
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1BC73BC Offset: 0x1BC33BC VA: 0x1BC73BC
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexContentRestriction : XmlSchemaContent // TypeDefIndex: 3561
{
	// Fields
	private XmlSchemaParticle particle; // 0x50
	private XmlSchemaObjectCollection attributes; // 0x58
	private XmlSchemaAnyAttribute anyAttribute; // 0x60
	private XmlQualifiedName baseTypeName; // 0x68

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaParticle Particle { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x1BC7474 Offset: 0x1BC3474 VA: 0x1BC7474
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1BC747C Offset: 0x1BC347C VA: 0x1BC747C
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x1BC751C Offset: 0x1BC351C VA: 0x1BC751C
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x1BC7524 Offset: 0x1BC3524 VA: 0x1BC7524
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x1BC752C Offset: 0x1BC352C VA: 0x1BC752C
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x1BC7534 Offset: 0x1BC3534 VA: 0x1BC7534
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1BC753C Offset: 0x1BC353C VA: 0x1BC753C
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1BC7544 Offset: 0x1BC3544 VA: 0x1BC7544
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1BC754C Offset: 0x1BC354C VA: 0x1BC754C
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaComplexType : XmlSchemaType // TypeDefIndex: 3562
{
	// Fields
	private XmlSchemaDerivationMethod block; // 0x94
	private XmlSchemaContentModel contentModel; // 0x98
	private XmlSchemaParticle particle; // 0xA0
	private XmlSchemaObjectCollection attributes; // 0xA8
	private XmlSchemaAnyAttribute anyAttribute; // 0xB0
	private XmlSchemaParticle contentTypeParticle; // 0xB8
	private XmlSchemaDerivationMethod blockResolved; // 0xC0
	private XmlSchemaObjectTable localElements; // 0xC8
	private XmlSchemaObjectTable attributeUses; // 0xD0
	private XmlSchemaAnyAttribute attributeWildcard; // 0xD8
	private static XmlSchemaComplexType anyTypeLax; // 0x0
	private static XmlSchemaComplexType anyTypeSkip; // 0x8
	private static XmlSchemaComplexType untypedAnyType; // 0x10
	private byte pvFlags; // 0xE0

	// Properties
	[XmlIgnore]
	internal static XmlSchemaComplexType AnyType { get; }
	[XmlIgnore]
	internal static XmlSchemaComplexType UntypedAnyType { get; }
	internal static ContentValidator AnyTypeContentValidator { get; }
	[Xml("abstract")]
	[DefaultValue(False)]
	public bool IsAbstract { get; set; }
	[Xml("block")]
	[DefaultValue(256)]
	public XmlSchemaDerivationMethod Block { get; set; }
	[Xml("mixed")]
	[DefaultValue(False)]
	public override bool IsMixed { get; set; }
	[XmlElement("simpleContent", typeof(XmlSchemaSimpleContent))]
	[XmlElement("complexContent", typeof(XmlSchemaComplexContent))]
	public XmlSchemaContentModel ContentModel { get; set; }
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	public XmlSchemaParticle Particle { get; set; }
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }
	[XmlIgnore]
	public XmlSchemaContentType ContentType { get; }
	[XmlIgnore]
	public XmlSchemaParticle ContentTypeParticle { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeUses { get; }
	[XmlIgnore]
	public XmlSchemaAnyAttribute AttributeWildcard { get; }
	[XmlIgnore]
	internal XmlSchemaObjectTable LocalElements { get; }
	internal bool HasWildCard { set; }

	// Methods

	// RVA: 0x1BC75FC Offset: 0x1BC35FC VA: 0x1BC75FC
	private static void .cctor() { }

	// RVA: 0x1BC7820 Offset: 0x1BC3820 VA: 0x1BC7820
	private static XmlSchemaComplexType CreateAnyType(XmlSchemaContentProcessing processContents) { }

	// RVA: 0x1BC7B74 Offset: 0x1BC3B74 VA: 0x1BC7B74
	public void .ctor() { }

	// RVA: 0x1BC7C5C Offset: 0x1BC3C5C VA: 0x1BC7C5C
	internal static XmlSchemaComplexType get_AnyType() { }

	// RVA: 0x1BC7CB4 Offset: 0x1BC3CB4 VA: 0x1BC7CB4
	internal static XmlSchemaComplexType get_UntypedAnyType() { }

	// RVA: 0x1BC7BEC Offset: 0x1BC3BEC VA: 0x1BC7BEC
	internal static ContentValidator get_AnyTypeContentValidator() { }

	// RVA: 0x1BC7D0C Offset: 0x1BC3D0C VA: 0x1BC7D0C
	public bool get_IsAbstract() { }

	// RVA: 0x1BC7D18 Offset: 0x1BC3D18 VA: 0x1BC7D18
	public void set_IsAbstract(bool value) { }

	// RVA: 0x1BC7D38 Offset: 0x1BC3D38 VA: 0x1BC7D38
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x1BC7D40 Offset: 0x1BC3D40 VA: 0x1BC7D40
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1BC7D48 Offset: 0x1BC3D48 VA: 0x1BC7D48 Slot: 14
	public override bool get_IsMixed() { }

	// RVA: 0x1BC7D54 Offset: 0x1BC3D54 VA: 0x1BC7D54 Slot: 15
	public override void set_IsMixed(bool value) { }

	// RVA: 0x1BC7D74 Offset: 0x1BC3D74 VA: 0x1BC7D74
	public XmlSchemaContentModel get_ContentModel() { }

	// RVA: 0x1BC7D7C Offset: 0x1BC3D7C VA: 0x1BC7D7C
	public void set_ContentModel(XmlSchemaContentModel value) { }

	// RVA: 0x1BC7D84 Offset: 0x1BC3D84 VA: 0x1BC7D84
	public XmlSchemaParticle get_Particle() { }

	// RVA: 0x1BC7D8C Offset: 0x1BC3D8C VA: 0x1BC7D8C
	public void set_Particle(XmlSchemaParticle value) { }

	// RVA: 0x1BC7D94 Offset: 0x1BC3D94 VA: 0x1BC7D94
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x1BC7E04 Offset: 0x1BC3E04 VA: 0x1BC7E04
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1BC7E0C Offset: 0x1BC3E0C VA: 0x1BC7E0C
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1BC7E14 Offset: 0x1BC3E14 VA: 0x1BC7E14
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x1BC7E1C Offset: 0x1BC3E1C VA: 0x1BC7E1C
	public XmlSchemaParticle get_ContentTypeParticle() { }

	// RVA: 0x1BC7E24 Offset: 0x1BC3E24 VA: 0x1BC7E24
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x1BC7E2C Offset: 0x1BC3E2C VA: 0x1BC7E2C
	public XmlSchemaObjectTable get_AttributeUses() { }

	// RVA: 0x1BC7E9C Offset: 0x1BC3E9C VA: 0x1BC7E9C
	public XmlSchemaAnyAttribute get_AttributeWildcard() { }

	// RVA: 0x1BC7EA4 Offset: 0x1BC3EA4 VA: 0x1BC7EA4
	internal XmlSchemaObjectTable get_LocalElements() { }

	// RVA: 0x1BC7F14 Offset: 0x1BC3F14 VA: 0x1BC7F14
	internal void SetContentTypeParticle(XmlSchemaParticle value) { }

	// RVA: 0x1BC7F1C Offset: 0x1BC3F1C VA: 0x1BC7F1C
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1BC7F24 Offset: 0x1BC3F24 VA: 0x1BC7F24
	internal void SetAttributeWildcard(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1BC7F2C Offset: 0x1BC3F2C VA: 0x1BC7F2C
	internal void set_HasWildCard(bool value) { }

	// RVA: 0x1BC7F40 Offset: 0x1BC3F40 VA: 0x1BC7F40
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1BC7F48 Offset: 0x1BC3F48 VA: 0x1BC7F48
	internal bool ContainsIdAttribute(bool findAll) { }

	// RVA: 0x1BC82A8 Offset: 0x1BC42A8 VA: 0x1BC82A8 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1BC4030 Offset: 0x1BC0030 VA: 0x1BC4030
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1BC87D0 Offset: 0x1BC47D0 VA: 0x1BC87D0
	private void ClearCompiledState() { }

	// RVA: 0x1BC6288 Offset: 0x1BC2288 VA: 0x1BC6288
	internal static XmlSchemaObjectCollection CloneAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1BC88F0 Offset: 0x1BC48F0 VA: 0x1BC88F0
	private static XmlSchemaObjectCollection CloneGroupBaseParticles(XmlSchemaObjectCollection groupBaseParticles, XmlSchema parentSchema) { }

	// RVA: 0x1BC852C Offset: 0x1BC452C VA: 0x1BC852C
	internal static XmlSchemaParticle CloneParticle(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x1BC8AD0 Offset: 0x1BC4AD0 VA: 0x1BC8AD0
	private static XmlSchemaForm GetResolvedElementForm(XmlSchema parentSchema, XmlSchemaElement element) { }

	// RVA: 0x1BC82B0 Offset: 0x1BC42B0 VA: 0x1BC82B0
	internal static bool HasParticleRef(XmlSchemaParticle particle, XmlSchema parentSchema) { }

	// RVA: 0x1BC6120 Offset: 0x1BC2120 VA: 0x1BC6120
	internal static bool HasAttributeQNameRef(XmlSchemaObjectCollection attributes) { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaContent : XmlSchemaAnnotated // TypeDefIndex: 3563
{
	// Methods

	// RVA: 0x1BC746C Offset: 0x1BC346C VA: 0x1BC746C
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaContentModel : XmlSchemaAnnotated // TypeDefIndex: 3564
{
	// Properties
	[XmlIgnore]
	public abstract XmlSchemaContent Content { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 14
	public abstract XmlSchemaContent get_Content();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void set_Content(XmlSchemaContent value);

	// RVA: 0x1BC72DC Offset: 0x1BC32DC VA: 0x1BC72DC
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public enum XmlSchemaContentProcessing // TypeDefIndex: 3565
{
	// Fields
	public int value__; // 0x0
	[XmlIgnore]
	public const XmlSchemaContentProcessing None = 0;
	[XmlEnum("skip")]
	public const XmlSchemaContentProcessing Skip = 1;
	[XmlEnum("lax")]
	public const XmlSchemaContentProcessing Lax = 2;
	[XmlEnum("strict")]
	public const XmlSchemaContentProcessing Strict = 3;
}

// Namespace: System.Xml.Schema
public enum XmlSchemaContentType // TypeDefIndex: 3566
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaContentType TextOnly = 0;
	public const XmlSchemaContentType Empty = 1;
	public const XmlSchemaContentType ElementOnly = 2;
	public const XmlSchemaContentType Mixed = 3;
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaDatatype // TypeDefIndex: 3567
{
	// Properties
	public abstract Type ValueType { get; }
	public abstract XmlTokenizedType TokenizedType { get; }
	public virtual XmlSchemaDatatypeVariety Variety { get; }
	public virtual XmlTypeCode TypeCode { get; }
	internal abstract bool HasLexicalFacets { get; }
	internal abstract bool HasValueFacets { get; }
	internal abstract XmlValueConverter ValueConverter { get; }
	internal abstract RestrictionFacets Restriction { get; }
	internal abstract FacetsChecker FacetsChecker { get; }
	internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }
	internal string TypeCodeString { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XmlTokenizedType get_TokenizedType();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

	// RVA: 0x1BC8AF4 Offset: 0x1BC4AF4 VA: 0x1BC8AF4 Slot: 7
	public virtual XmlSchemaDatatypeVariety get_Variety() { }

	// RVA: 0x1BC8AFC Offset: 0x1BC4AFC VA: 0x1BC8AFC Slot: 8
	public virtual XmlTypeCode get_TypeCode() { }

	// RVA: 0x1BC8B04 Offset: 0x1BC4B04 VA: 0x1BC8B04 Slot: 9
	public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype) { }

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool get_HasLexicalFacets();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool get_HasValueFacets();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract XmlValueConverter get_ValueConverter();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract RestrictionFacets get_Restriction();

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract int Compare(object value1, object value2);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue);

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue);

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract FacetsChecker get_FacetsChecker();

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract XmlSchemaWhiteSpace get_BuiltInWhitespaceFacet();

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType);

	// RVA: -1 Offset: -1 Slot: 21
	internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType);

	// RVA: -1 Offset: -1 Slot: 22
	internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller);

	// RVA: -1 Offset: -1 Slot: 23
	internal abstract bool IsEqual(object o1, object o2);

	// RVA: -1 Offset: -1 Slot: 24
	internal abstract bool IsComparable(XmlSchemaDatatype dtype);

	// RVA: 0x1BC8B0C Offset: 0x1BC4B0C VA: 0x1BC8B0C
	internal string get_TypeCodeString() { }

	// RVA: 0x1BC8C28 Offset: 0x1BC4C28 VA: 0x1BC8C28
	internal string TypeCodeToString(XmlTypeCode typeCode) { }

	// RVA: 0x1BC90D4 Offset: 0x1BC50D4 VA: 0x1BC90D4
	internal static string ConcatenatedToString(object value) { }

	// RVA: 0x1BBB978 Offset: 0x1BB7978 VA: 0x1BBB978
	internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token) { }

	// RVA: 0x1BC9774 Offset: 0x1BC5774 VA: 0x1BC9774
	internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token) { }

	// RVA: 0x1BBA1DC Offset: 0x1BB61DC VA: 0x1BBA1DC
	internal static XmlSchemaDatatype FromXdrName(string name) { }

	// RVA: 0x1BC97CC Offset: 0x1BC57CC VA: 0x1BC97CC
	internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType) { }

	// RVA: 0x1BB7D7C Offset: 0x1BB3D7C VA: 0x1BB7D7C
	internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames) { }

	// RVA: 0x1BC9834 Offset: 0x1BC5834 VA: 0x1BC9834
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
[Flags]
public enum XmlSchemaDerivationMethod // TypeDefIndex: 3568
{
	// Fields
	public int value__; // 0x0
	[XmlEnum("")]
	public const XmlSchemaDerivationMethod Empty = 0;
	[XmlEnum("substitution")]
	public const XmlSchemaDerivationMethod Substitution = 1;
	[XmlEnum("extension")]
	public const XmlSchemaDerivationMethod Extension = 2;
	[XmlEnum("restriction")]
	public const XmlSchemaDerivationMethod Restriction = 4;
	[XmlEnum("list")]
	public const XmlSchemaDerivationMethod List = 8;
	[XmlEnum("union")]
	public const XmlSchemaDerivationMethod Union = 16;
	[XmlEnum("#all")]
	public const XmlSchemaDerivationMethod All = 255;
	[XmlIgnore]
	public const XmlSchemaDerivationMethod None = 256;
}

// Namespace: System.Xml.Schema
public class XmlSchemaDocumentation : XmlSchemaObject // TypeDefIndex: 3569
{
	// Fields
	private string source; // 0x38
	private string language; // 0x40
	private XmlNode[] markup; // 0x48
	private static XmlSchemaSimpleType languageType; // 0x0

	// Properties
	[Xml("source", DataType = "anyURI")]
	public string Source { set; }
	[Xml("xml:lang")]
	public string Language { set; }
	[XmlAnyElement]
	[XmlText]
	public XmlNode[] Markup { set; }

	// Methods

	// RVA: 0x1BC983C Offset: 0x1BC583C VA: 0x1BC983C
	public void set_Source(string value) { }

	// RVA: 0x1BC9844 Offset: 0x1BC5844 VA: 0x1BC9844
	public void set_Language(string value) { }

	// RVA: 0x1BC9918 Offset: 0x1BC5918 VA: 0x1BC9918
	public void set_Markup(XmlNode[] value) { }

	// RVA: 0x1BC9920 Offset: 0x1BC5920 VA: 0x1BC9920
	public void .ctor() { }

	// RVA: 0x1BC9928 Offset: 0x1BC5928 VA: 0x1BC9928
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaElement : XmlSchemaParticle // TypeDefIndex: 3570
{
	// Fields
	private bool isAbstract; // 0x74
	private bool hasAbstractAttribute; // 0x75
	private bool isNillable; // 0x76
	private bool hasNillableAttribute; // 0x77
	private bool isLocalTypeDerivationChecked; // 0x78
	private XmlSchemaDerivationMethod block; // 0x7C
	private XmlSchemaDerivationMethod final; // 0x80
	private XmlSchemaForm form; // 0x84
	private string defaultValue; // 0x88
	private string fixedValue; // 0x90
	private string name; // 0x98
	private XmlQualifiedName refName; // 0xA0
	private XmlQualifiedName substitutionGroup; // 0xA8
	private XmlQualifiedName typeName; // 0xB0
	private XmlSchemaType type; // 0xB8
	private XmlQualifiedName qualifiedName; // 0xC0
	private XmlSchemaType elementType; // 0xC8
	private XmlSchemaDerivationMethod blockResolved; // 0xD0
	private XmlSchemaDerivationMethod finalResolved; // 0xD4
	private XmlSchemaObjectCollection constraints; // 0xD8
	private SchemaElementDecl elementDecl; // 0xE0

	// Properties
	[DefaultValue(False)]
	[Xml("abstract")]
	public bool IsAbstract { get; set; }
	[DefaultValue(256)]
	[Xml("block")]
	public XmlSchemaDerivationMethod Block { get; set; }
	[Xml("default")]
	[DefaultValue(null)]
	public string DefaultValue { get; set; }
	[DefaultValue(256)]
	[Xml("final")]
	public XmlSchemaDerivationMethod Final { get; set; }
	[DefaultValue(null)]
	[Xml("fixed")]
	public string FixedValue { get; set; }
	[DefaultValue(0)]
	[Xml("form")]
	public XmlSchemaForm Form { get; set; }
	[Xml("name")]
	[DefaultValue("")]
	public string Name { get; set; }
	[Xml("nillable")]
	[DefaultValue(False)]
	public bool IsNillable { get; set; }
	[XmlIgnore]
	internal bool HasNillableAttribute { get; }
	[XmlIgnore]
	internal bool HasAbstractAttribute { get; }
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }
	[Xml("substitutionGroup")]
	public XmlQualifiedName SubstitutionGroup { get; set; }
	[Xml("type")]
	public XmlQualifiedName SchemaTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	public XmlSchemaType SchemaType { get; set; }
	[XmlElement("key", typeof(XmlSchemaKey))]
	[XmlElement("keyref", typeof(XmlSchemaKeyref))]
	[XmlElement("unique", typeof(XmlSchemaUnique))]
	public XmlSchemaObjectCollection Constraints { get; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	public XmlSchemaType ElementSchemaType { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod BlockResolved { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved { get; }
	internal bool HasConstraints { get; }
	internal bool IsLocalTypeDerivationChecked { get; set; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }
	[XmlIgnore]
	internal override string NameString { get; }

	// Methods

	// RVA: 0x1BC9A0C Offset: 0x1BC5A0C VA: 0x1BC9A0C
	public bool get_IsAbstract() { }

	// RVA: 0x1BC9A14 Offset: 0x1BC5A14 VA: 0x1BC9A14
	public void set_IsAbstract(bool value) { }

	// RVA: 0x1BC9A24 Offset: 0x1BC5A24 VA: 0x1BC9A24
	public XmlSchemaDerivationMethod get_Block() { }

	// RVA: 0x1BC9A2C Offset: 0x1BC5A2C VA: 0x1BC9A2C
	public void set_Block(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1BC9A34 Offset: 0x1BC5A34 VA: 0x1BC9A34
	public string get_DefaultValue() { }

	// RVA: 0x1BC9A3C Offset: 0x1BC5A3C VA: 0x1BC9A3C
	public void set_DefaultValue(string value) { }

	// RVA: 0x1BC9A44 Offset: 0x1BC5A44 VA: 0x1BC9A44
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x1BC9A4C Offset: 0x1BC5A4C VA: 0x1BC9A4C
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1BC9A54 Offset: 0x1BC5A54 VA: 0x1BC9A54
	public string get_FixedValue() { }

	// RVA: 0x1BC9A5C Offset: 0x1BC5A5C VA: 0x1BC9A5C
	public void set_FixedValue(string value) { }

	// RVA: 0x1BC9A64 Offset: 0x1BC5A64 VA: 0x1BC9A64
	public XmlSchemaForm get_Form() { }

	// RVA: 0x1BC9A6C Offset: 0x1BC5A6C VA: 0x1BC9A6C
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x1BC9A74 Offset: 0x1BC5A74 VA: 0x1BC9A74
	public string get_Name() { }

	// RVA: 0x1BC9A7C Offset: 0x1BC5A7C VA: 0x1BC9A7C
	public void set_Name(string value) { }

	// RVA: 0x1BC9A84 Offset: 0x1BC5A84 VA: 0x1BC9A84
	public bool get_IsNillable() { }

	// RVA: 0x1BC9A8C Offset: 0x1BC5A8C VA: 0x1BC9A8C
	public void set_IsNillable(bool value) { }

	// RVA: 0x1BC9A9C Offset: 0x1BC5A9C VA: 0x1BC9A9C
	internal bool get_HasNillableAttribute() { }

	// RVA: 0x1BC9AA4 Offset: 0x1BC5AA4 VA: 0x1BC9AA4
	internal bool get_HasAbstractAttribute() { }

	// RVA: 0x1BC9AAC Offset: 0x1BC5AAC VA: 0x1BC9AAC
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1BC9AB4 Offset: 0x1BC5AB4 VA: 0x1BC9AB4
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x1BC9B54 Offset: 0x1BC5B54 VA: 0x1BC9B54
	public XmlQualifiedName get_SubstitutionGroup() { }

	// RVA: 0x1BC9B5C Offset: 0x1BC5B5C VA: 0x1BC9B5C
	public void set_SubstitutionGroup(XmlQualifiedName value) { }

	// RVA: 0x1BC9BFC Offset: 0x1BC5BFC VA: 0x1BC9BFC
	public XmlQualifiedName get_SchemaTypeName() { }

	// RVA: 0x1BC9C04 Offset: 0x1BC5C04 VA: 0x1BC9C04
	public void set_SchemaTypeName(XmlQualifiedName value) { }

	// RVA: 0x1BC9CA4 Offset: 0x1BC5CA4 VA: 0x1BC9CA4
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x1BC9CAC Offset: 0x1BC5CAC VA: 0x1BC9CAC
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x1BC9CB4 Offset: 0x1BC5CB4 VA: 0x1BC9CB4
	public XmlSchemaObjectCollection get_Constraints() { }

	// RVA: 0x1BC9D24 Offset: 0x1BC5D24 VA: 0x1BC9D24
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1BC9D2C Offset: 0x1BC5D2C VA: 0x1BC9D2C
	public XmlSchemaType get_ElementSchemaType() { }

	// RVA: 0x1BC9D34 Offset: 0x1BC5D34 VA: 0x1BC9D34
	public XmlSchemaDerivationMethod get_BlockResolved() { }

	// RVA: 0x1BC9D3C Offset: 0x1BC5D3C VA: 0x1BC9D3C
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x1BC9D44 Offset: 0x1BC5D44 VA: 0x1BC9D44
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1BC9D4C Offset: 0x1BC5D4C VA: 0x1BC9D4C
	internal void SetElementType(XmlSchemaType value) { }

	// RVA: 0x1BC9D54 Offset: 0x1BC5D54 VA: 0x1BC9D54
	internal void SetBlockResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1BC9D5C Offset: 0x1BC5D5C VA: 0x1BC9D5C
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1BC9D64 Offset: 0x1BC5D64 VA: 0x1BC9D64
	internal bool get_HasConstraints() { }

	// RVA: 0x1BC9D88 Offset: 0x1BC5D88 VA: 0x1BC9D88
	internal bool get_IsLocalTypeDerivationChecked() { }

	// RVA: 0x1BC9D90 Offset: 0x1BC5D90 VA: 0x1BC9D90
	internal void set_IsLocalTypeDerivationChecked(bool value) { }

	// RVA: 0x1BC9D98 Offset: 0x1BC5D98 VA: 0x1BC9D98
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x1BC9DA0 Offset: 0x1BC5DA0 VA: 0x1BC9DA0
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x1BC9DA8 Offset: 0x1BC5DA8 VA: 0x1BC9DA8 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x1BC9DB0 Offset: 0x1BC5DB0 VA: 0x1BC9DB0 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1BC9DB8 Offset: 0x1BC5DB8 VA: 0x1BC9DB8 Slot: 15
	internal override string get_NameString() { }

	// RVA: 0x1BC9DD4 Offset: 0x1BC5DD4 VA: 0x1BC9DD4 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1BC4744 Offset: 0x1BC0744 VA: 0x1BC4744
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1BC9DDC Offset: 0x1BC5DDC VA: 0x1BC9DDC
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaException : SystemException // TypeDefIndex: 3571
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private string sourceUri; // 0xA0
	private int lineNumber; // 0xA8
	private int linePosition; // 0xAC
	private XmlSchemaObject sourceSchemaObject; // 0xB0
	private string message; // 0xB8

	// Properties
	internal string GetRes { get; }
	internal string[] Args { get; }
	public string SourceUri { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public XmlSchemaObject SourceSchemaObject { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x1BC9EC0 Offset: 0x1BC5EC0 VA: 0x1BC9EC0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BCA334 Offset: 0x1BC6334 VA: 0x1BCA334 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BCA4A4 Offset: 0x1BC64A4 VA: 0x1BCA4A4
	public void .ctor() { }

	// RVA: 0x1BCA4B8 Offset: 0x1BC64B8 VA: 0x1BCA4B8
	public void .ctor(string message) { }

	// RVA: 0x1BCA5C8 Offset: 0x1BC65C8 VA: 0x1BCA5C8
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1BCA4C8 Offset: 0x1BC64C8 VA: 0x1BCA4C8
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x1BCA68C Offset: 0x1BC668C VA: 0x1BCA68C
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x1BC1D40 Offset: 0x1BBDD40 VA: 0x1BC1D40
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1BBD4F4 Offset: 0x1BB94F4 VA: 0x1BBD4F4
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1BCA6B8 Offset: 0x1BC66B8 VA: 0x1BCA6B8
	internal void .ctor(string res, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1BBD400 Offset: 0x1BB9400 VA: 0x1BBD400
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1BCA6E8 Offset: 0x1BC66E8 VA: 0x1BCA6E8
	internal void .ctor(string res, XmlSchemaObject source) { }

	// RVA: 0x1BCA724 Offset: 0x1BC6724 VA: 0x1BCA724
	internal void .ctor(string res, string arg, XmlSchemaObject source) { }

	// RVA: 0x1BCA6F4 Offset: 0x1BC66F4 VA: 0x1BCA6F4
	internal void .ctor(string res, string[] args, XmlSchemaObject source) { }

	// RVA: 0x1BCA5D4 Offset: 0x1BC65D4 VA: 0x1BCA5D4
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition, XmlSchemaObject source) { }

	// RVA: 0x1BCA270 Offset: 0x1BC6270 VA: 0x1BCA270
	internal static string CreateMessage(string res, string[] args) { }

	// RVA: 0x1BCA7C4 Offset: 0x1BC67C4 VA: 0x1BCA7C4
	internal string get_GetRes() { }

	// RVA: 0x1BCA7CC Offset: 0x1BC67CC VA: 0x1BCA7CC
	internal string[] get_Args() { }

	// RVA: 0x1BCA7D4 Offset: 0x1BC67D4 VA: 0x1BCA7D4
	public string get_SourceUri() { }

	// RVA: 0x1BCA7DC Offset: 0x1BC67DC VA: 0x1BCA7DC
	public int get_LineNumber() { }

	// RVA: 0x1BCA7E4 Offset: 0x1BC67E4 VA: 0x1BCA7E4
	public int get_LinePosition() { }

	// RVA: 0x1BCA7EC Offset: 0x1BC67EC VA: 0x1BCA7EC
	public XmlSchemaObject get_SourceSchemaObject() { }

	// RVA: 0x1BC1218 Offset: 0x1BBD218 VA: 0x1BC1218
	internal void SetSource(string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1BCA7F4 Offset: 0x1BC67F4 VA: 0x1BCA7F4
	internal void SetSchemaObject(XmlSchemaObject source) { }

	// RVA: 0x1BCA7FC Offset: 0x1BC67FC VA: 0x1BCA7FC
	internal void SetSource(XmlSchemaObject source) { }

	// RVA: 0x1BCA840 Offset: 0x1BC6840 VA: 0x1BCA840 Slot: 5
	public override string get_Message() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaExternal : XmlSchemaObject // TypeDefIndex: 3572
{
	// Fields
	private string location; // 0x38
	private Uri baseUri; // 0x40
	private XmlSchema schema; // 0x48
	private string id; // 0x50
	private XmlAttribute[] moreAttributes; // 0x58
	private Compositor compositor; // 0x60

	// Properties
	[Xml("schemaLocation", DataType = "anyURI")]
	public string SchemaLocation { get; set; }
	[XmlIgnore]
	public XmlSchema Schema { get; set; }
	[Xml("id", DataType = "ID")]
	public string Id { get; set; }
	[XmlIgnore]
	internal Uri BaseUri { get; set; }
	[XmlIgnore]
	internal override string IdAttribute { get; set; }
	internal Compositor Compositor { get; set; }

	// Methods

	// RVA: 0x1BCA858 Offset: 0x1BC6858 VA: 0x1BCA858
	public string get_SchemaLocation() { }

	// RVA: 0x1BCA860 Offset: 0x1BC6860 VA: 0x1BCA860
	public void set_SchemaLocation(string value) { }

	// RVA: 0x1BCA868 Offset: 0x1BC6868 VA: 0x1BCA868
	public XmlSchema get_Schema() { }

	// RVA: 0x1BCA870 Offset: 0x1BC6870 VA: 0x1BCA870
	public void set_Schema(XmlSchema value) { }

	// RVA: 0x1BCA878 Offset: 0x1BC6878 VA: 0x1BCA878
	public string get_Id() { }

	// RVA: 0x1BCA880 Offset: 0x1BC6880 VA: 0x1BCA880
	public void set_Id(string value) { }

	// RVA: 0x1BCA888 Offset: 0x1BC6888 VA: 0x1BCA888
	internal Uri get_BaseUri() { }

	// RVA: 0x1BCA890 Offset: 0x1BC6890 VA: 0x1BCA890
	internal void set_BaseUri(Uri value) { }

	// RVA: 0x1BCA898 Offset: 0x1BC6898 VA: 0x1BCA898 Slot: 7
	internal override string get_IdAttribute() { }

	// RVA: 0x1BCA8A0 Offset: 0x1BC68A0 VA: 0x1BCA8A0 Slot: 8
	internal override void set_IdAttribute(string value) { }

	// RVA: 0x1BCA8A8 Offset: 0x1BC68A8 VA: 0x1BCA8A8 Slot: 9
	internal override void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1BCA8B0 Offset: 0x1BC68B0 VA: 0x1BCA8B0
	internal Compositor get_Compositor() { }

	// RVA: 0x1BCA8B8 Offset: 0x1BC68B8 VA: 0x1BCA8B8
	internal void set_Compositor(Compositor value) { }

	// RVA: 0x1BCA8C0 Offset: 0x1BC68C0 VA: 0x1BCA8C0
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal enum FacetType // TypeDefIndex: 3573
{
	// Fields
	public int value__; // 0x0
	public const FacetType None = 0;
	public const FacetType Length = 1;
	public const FacetType MinLength = 2;
	public const FacetType MaxLength = 3;
	public const FacetType Pattern = 4;
	public const FacetType Whitespace = 5;
	public const FacetType Enumeration = 6;
	public const FacetType MinExclusive = 7;
	public const FacetType MinInclusive = 8;
	public const FacetType MaxExclusive = 9;
	public const FacetType MaxInclusive = 10;
	public const FacetType TotalDigits = 11;
	public const FacetType FractionDigits = 12;
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaFacet : XmlSchemaAnnotated // TypeDefIndex: 3574
{
	// Fields
	private string value; // 0x50
	private bool isFixed; // 0x58
	private FacetType facetType; // 0x5C

	// Properties
	[Xml("value")]
	public string Value { get; set; }
	[Xml("fixed")]
	[DefaultValue(False)]
	public virtual bool IsFixed { get; set; }
	internal FacetType FacetType { get; set; }

	// Methods

	// RVA: 0x1BCA8C8 Offset: 0x1BC68C8 VA: 0x1BCA8C8
	public string get_Value() { }

	// RVA: 0x1BCA8D0 Offset: 0x1BC68D0 VA: 0x1BCA8D0
	public void set_Value(string value) { }

	// RVA: 0x1BCA8D8 Offset: 0x1BC68D8 VA: 0x1BCA8D8 Slot: 14
	public virtual bool get_IsFixed() { }

	// RVA: 0x1BCA8E0 Offset: 0x1BC68E0 VA: 0x1BCA8E0 Slot: 15
	public virtual void set_IsFixed(bool value) { }

	// RVA: 0x1BCA994 Offset: 0x1BC6994 VA: 0x1BCA994
	internal FacetType get_FacetType() { }

	// RVA: 0x1BCA99C Offset: 0x1BC699C VA: 0x1BCA99C
	internal void set_FacetType(FacetType value) { }

	// RVA: 0x1BCA9A4 Offset: 0x1BC69A4 VA: 0x1BCA9A4
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaNumericFacet : XmlSchemaFacet // TypeDefIndex: 3575
{
	// Methods

	// RVA: 0x1BCA9AC Offset: 0x1BC69AC VA: 0x1BCA9AC
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 3576
{
	// Methods

	// RVA: 0x1BCA9B4 Offset: 0x1BC69B4 VA: 0x1BCA9B4
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMinLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 3577
{
	// Methods

	// RVA: 0x1BCA9D4 Offset: 0x1BC69D4 VA: 0x1BCA9D4
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxLengthFacet : XmlSchemaNumericFacet // TypeDefIndex: 3578
{
	// Methods

	// RVA: 0x1BCA9F4 Offset: 0x1BC69F4 VA: 0x1BCA9F4
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaPatternFacet : XmlSchemaFacet // TypeDefIndex: 3579
{
	// Methods

	// RVA: 0x1BCAA14 Offset: 0x1BC6A14 VA: 0x1BCAA14
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaEnumerationFacet : XmlSchemaFacet // TypeDefIndex: 3580
{
	// Methods

	// RVA: 0x1BCAA34 Offset: 0x1BC6A34 VA: 0x1BCAA34
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMinExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 3581
{
	// Methods

	// RVA: 0x1BCAA54 Offset: 0x1BC6A54 VA: 0x1BCAA54
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMinInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 3582
{
	// Methods

	// RVA: 0x1BCAA74 Offset: 0x1BC6A74 VA: 0x1BCAA74
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxExclusiveFacet : XmlSchemaFacet // TypeDefIndex: 3583
{
	// Methods

	// RVA: 0x1BCAA94 Offset: 0x1BC6A94 VA: 0x1BCAA94
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaMaxInclusiveFacet : XmlSchemaFacet // TypeDefIndex: 3584
{
	// Methods

	// RVA: 0x1BCAAB4 Offset: 0x1BC6AB4 VA: 0x1BCAAB4
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaTotalDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 3585
{
	// Methods

	// RVA: 0x1BCAAD4 Offset: 0x1BC6AD4 VA: 0x1BCAAD4
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaFractionDigitsFacet : XmlSchemaNumericFacet // TypeDefIndex: 3586
{
	// Methods

	// RVA: 0x1BCAAF4 Offset: 0x1BC6AF4 VA: 0x1BCAAF4
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaWhiteSpaceFacet : XmlSchemaFacet // TypeDefIndex: 3587
{
	// Methods

	// RVA: 0x1BCAB14 Offset: 0x1BC6B14 VA: 0x1BCAB14
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public enum XmlSchemaForm // TypeDefIndex: 3588
{
	// Fields
	public int value__; // 0x0
	[XmlIgnore]
	public const XmlSchemaForm None = 0;
	[XmlEnum("qualified")]
	public const XmlSchemaForm Qualified = 1;
	[XmlEnum("unqualified")]
	public const XmlSchemaForm Unqualified = 2;
}

// Namespace: System.Xml.Schema
public class XmlSchemaGroup : XmlSchemaAnnotated // TypeDefIndex: 3589
{
	// Fields
	private string name; // 0x50
	private XmlSchemaGroupBase particle; // 0x58
	private XmlSchemaParticle canonicalParticle; // 0x60
	private XmlQualifiedName qname; // 0x68
	private XmlSchemaGroup redefined; // 0x70
	private int selfReferenceCount; // 0x78

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("all", typeof(XmlSchemaAll))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public XmlSchemaGroupBase Particle { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	internal XmlSchemaParticle CanonicalParticle { get; set; }
	[XmlIgnore]
	internal XmlSchemaGroup Redefined { get; set; }
	[XmlIgnore]
	internal int SelfReferenceCount { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x1BCAB34 Offset: 0x1BC6B34 VA: 0x1BCAB34
	public string get_Name() { }

	// RVA: 0x1BCAB3C Offset: 0x1BC6B3C VA: 0x1BCAB3C
	public void set_Name(string value) { }

	// RVA: 0x1BCAB44 Offset: 0x1BC6B44 VA: 0x1BCAB44
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x1BCAB4C Offset: 0x1BC6B4C VA: 0x1BCAB4C
	public void set_Particle(XmlSchemaGroupBase value) { }

	// RVA: 0x1BCAB54 Offset: 0x1BC6B54 VA: 0x1BCAB54
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1BCAB5C Offset: 0x1BC6B5C VA: 0x1BCAB5C
	internal XmlSchemaParticle get_CanonicalParticle() { }

	// RVA: 0x1BCAB64 Offset: 0x1BC6B64 VA: 0x1BCAB64
	internal void set_CanonicalParticle(XmlSchemaParticle value) { }

	// RVA: 0x1BCAB6C Offset: 0x1BC6B6C VA: 0x1BCAB6C
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x1BCAB74 Offset: 0x1BC6B74 VA: 0x1BCAB74
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x1BCAB7C Offset: 0x1BC6B7C VA: 0x1BCAB7C
	internal int get_SelfReferenceCount() { }

	// RVA: 0x1BCAB84 Offset: 0x1BC6B84 VA: 0x1BCAB84
	internal void set_SelfReferenceCount(int value) { }

	// RVA: 0x1BCAB8C Offset: 0x1BC6B8C VA: 0x1BCAB8C Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x1BCAB94 Offset: 0x1BC6B94 VA: 0x1BCAB94 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1BCAB9C Offset: 0x1BC6B9C VA: 0x1BCAB9C
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1BCABA4 Offset: 0x1BC6BA4 VA: 0x1BCABA4 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1BC4978 Offset: 0x1BC0978 VA: 0x1BC4978
	internal XmlSchemaObject Clone(XmlSchema parentSchema) { }

	// RVA: 0x1BCABAC Offset: 0x1BC6BAC VA: 0x1BCABAC
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaGroupBase : XmlSchemaParticle // TypeDefIndex: 3590
{
	// Properties
	[XmlIgnore]
	public abstract XmlSchemaObjectCollection Items { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 16
	public abstract XmlSchemaObjectCollection get_Items();

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract void SetItems(XmlSchemaObjectCollection newItems);

	// RVA: 0x1BC4FD8 Offset: 0x1BC0FD8 VA: 0x1BC4FD8
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaGroupRef : XmlSchemaParticle // TypeDefIndex: 3591
{
	// Fields
	private XmlQualifiedName refName; // 0x78
	private XmlSchemaGroupBase particle; // 0x80
	private XmlSchemaGroup refined; // 0x88

	// Properties
	[Xml("ref")]
	public XmlQualifiedName RefName { get; set; }
	[XmlIgnore]
	public XmlSchemaGroupBase Particle { get; }
	[XmlIgnore]
	internal XmlSchemaGroup Redefined { get; set; }

	// Methods

	// RVA: 0x1BCAC1C Offset: 0x1BC6C1C VA: 0x1BCAC1C
	public XmlQualifiedName get_RefName() { }

	// RVA: 0x1BC8A30 Offset: 0x1BC4A30 VA: 0x1BC8A30
	public void set_RefName(XmlQualifiedName value) { }

	// RVA: 0x1BCAC24 Offset: 0x1BC6C24 VA: 0x1BCAC24
	public XmlSchemaGroupBase get_Particle() { }

	// RVA: 0x1BCAC2C Offset: 0x1BC6C2C VA: 0x1BCAC2C
	internal void SetParticle(XmlSchemaGroupBase value) { }

	// RVA: 0x1BCAC34 Offset: 0x1BC6C34 VA: 0x1BCAC34
	internal XmlSchemaGroup get_Redefined() { }

	// RVA: 0x1BCAC3C Offset: 0x1BC6C3C VA: 0x1BCAC3C
	internal void set_Redefined(XmlSchemaGroup value) { }

	// RVA: 0x1BCAC44 Offset: 0x1BC6C44 VA: 0x1BCAC44
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaIdentityConstraint : XmlSchemaAnnotated // TypeDefIndex: 3592
{
	// Fields
	private string name; // 0x50
	private XmlSchemaXPath selector; // 0x58
	private XmlSchemaObjectCollection fields; // 0x60
	private XmlQualifiedName qualifiedName; // 0x68
	private CompiledIdentityConstraint compiledConstraint; // 0x70

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[XmlElement("selector", typeof(XmlSchemaXPath))]
	public XmlSchemaXPath Selector { get; set; }
	[XmlElement("field", typeof(XmlSchemaXPath))]
	public XmlSchemaObjectCollection Fields { get; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	internal CompiledIdentityConstraint CompiledConstraint { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x1BCACD8 Offset: 0x1BC6CD8 VA: 0x1BCACD8
	public string get_Name() { }

	// RVA: 0x1BCACE0 Offset: 0x1BC6CE0 VA: 0x1BCACE0
	public void set_Name(string value) { }

	// RVA: 0x1BCACE8 Offset: 0x1BC6CE8 VA: 0x1BCACE8
	public XmlSchemaXPath get_Selector() { }

	// RVA: 0x1BCACF0 Offset: 0x1BC6CF0 VA: 0x1BCACF0
	public void set_Selector(XmlSchemaXPath value) { }

	// RVA: 0x1BCACF8 Offset: 0x1BC6CF8 VA: 0x1BCACF8
	public XmlSchemaObjectCollection get_Fields() { }

	// RVA: 0x1BCAD00 Offset: 0x1BC6D00 VA: 0x1BCAD00
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1BCAD08 Offset: 0x1BC6D08 VA: 0x1BCAD08
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1BCAD10 Offset: 0x1BC6D10 VA: 0x1BCAD10
	internal CompiledIdentityConstraint get_CompiledConstraint() { }

	// RVA: 0x1BCAD18 Offset: 0x1BC6D18 VA: 0x1BCAD18
	internal void set_CompiledConstraint(CompiledIdentityConstraint value) { }

	// RVA: 0x1BCAD20 Offset: 0x1BC6D20 VA: 0x1BCAD20 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x1BCAD28 Offset: 0x1BC6D28 VA: 0x1BCAD28 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1BCAD30 Offset: 0x1BC6D30 VA: 0x1BCAD30
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaXPath : XmlSchemaAnnotated // TypeDefIndex: 3593
{
	// Fields
	private string xpath; // 0x50

	// Properties
	[Xml("xpath")]
	[DefaultValue("")]
	public string XPath { get; set; }

	// Methods

	// RVA: 0x1BCADE0 Offset: 0x1BC6DE0 VA: 0x1BCADE0
	public string get_XPath() { }

	// RVA: 0x1BCADE8 Offset: 0x1BC6DE8 VA: 0x1BCADE8
	public void set_XPath(string value) { }

	// RVA: 0x1BCADF0 Offset: 0x1BC6DF0 VA: 0x1BCADF0
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaUnique : XmlSchemaIdentityConstraint // TypeDefIndex: 3594
{
	// Methods

	// RVA: 0x1BCADF8 Offset: 0x1BC6DF8 VA: 0x1BCADF8
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaKey : XmlSchemaIdentityConstraint // TypeDefIndex: 3595
{
	// Methods

	// RVA: 0x1BCADFC Offset: 0x1BC6DFC VA: 0x1BCADFC
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaKeyref : XmlSchemaIdentityConstraint // TypeDefIndex: 3596
{
	// Fields
	private XmlQualifiedName refer; // 0x78

	// Properties
	[Xml("refer")]
	public XmlQualifiedName Refer { get; set; }

	// Methods

	// RVA: 0x1BCAE00 Offset: 0x1BC6E00 VA: 0x1BCAE00
	public XmlQualifiedName get_Refer() { }

	// RVA: 0x1BCAE08 Offset: 0x1BC6E08 VA: 0x1BCAE08
	public void set_Refer(XmlQualifiedName value) { }

	// RVA: 0x1BCAEA8 Offset: 0x1BC6EA8 VA: 0x1BCAEA8
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaImport : XmlSchemaExternal // TypeDefIndex: 3597
{
	// Fields
	private string ns; // 0x68
	private XmlSchemaAnnotation annotation; // 0x70

	// Properties
	[Xml("namespace", DataType = "anyURI")]
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x1BCAF14 Offset: 0x1BC6F14 VA: 0x1BCAF14
	public void .ctor() { }

	// RVA: 0x1BCAF34 Offset: 0x1BC6F34 VA: 0x1BCAF34
	public string get_Namespace() { }

	// RVA: 0x1BCAF3C Offset: 0x1BC6F3C VA: 0x1BCAF3C
	public void set_Namespace(string value) { }

	// RVA: 0x1BCAF44 Offset: 0x1BC6F44 VA: 0x1BCAF44 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaInclude : XmlSchemaExternal // TypeDefIndex: 3598
{
	// Fields
	private XmlSchemaAnnotation annotation; // 0x68

	// Methods

	// RVA: 0x1BCAF4C Offset: 0x1BC6F4C VA: 0x1BCAF4C
	public void .ctor() { }

	// RVA: 0x1BCAF6C Offset: 0x1BC6F6C VA: 0x1BCAF6C Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaInfo : IXmlSchemaInfo // TypeDefIndex: 3599
{
	// Fields
	private bool isDefault; // 0x10
	private bool isNil; // 0x11
	private XmlSchemaElement schemaElement; // 0x18
	private XmlSchemaAttribute schemaAttribute; // 0x20
	private XmlSchemaType schemaType; // 0x28
	private XmlSchemaSimpleType memberType; // 0x30
	private XmlSchemaValidity validity; // 0x38
	private XmlSchemaContentType contentType; // 0x3C

	// Properties
	public XmlSchemaValidity Validity { get; set; }
	public bool IsDefault { get; set; }
	public bool IsNil { get; set; }
	public XmlSchemaSimpleType MemberType { get; set; }
	public XmlSchemaType SchemaType { get; set; }
	public XmlSchemaElement SchemaElement { get; set; }
	public XmlSchemaAttribute SchemaAttribute { get; set; }
	public XmlSchemaContentType ContentType { get; }
	internal XmlSchemaType XmlType { get; }
	internal bool HasDefaultValue { get; }
	internal bool IsUnionType { get; }

	// Methods

	// RVA: 0x1BCAF74 Offset: 0x1BC6F74 VA: 0x1BCAF74
	public void .ctor() { }

	// RVA: 0x1BCAFEC Offset: 0x1BC6FEC VA: 0x1BCAFEC
	internal void .ctor(XmlSchemaValidity validity) { }

	// RVA: 0x1BCB01C Offset: 0x1BC701C VA: 0x1BCB01C Slot: 4
	public XmlSchemaValidity get_Validity() { }

	// RVA: 0x1BCB024 Offset: 0x1BC7024 VA: 0x1BCB024
	public void set_Validity(XmlSchemaValidity value) { }

	// RVA: 0x1BCB02C Offset: 0x1BC702C VA: 0x1BCB02C Slot: 5
	public bool get_IsDefault() { }

	// RVA: 0x1BCB034 Offset: 0x1BC7034 VA: 0x1BCB034
	public void set_IsDefault(bool value) { }

	// RVA: 0x1BCB03C Offset: 0x1BC703C VA: 0x1BCB03C Slot: 6
	public bool get_IsNil() { }

	// RVA: 0x1BCB044 Offset: 0x1BC7044 VA: 0x1BCB044
	public void set_IsNil(bool value) { }

	// RVA: 0x1BCB04C Offset: 0x1BC704C VA: 0x1BCB04C Slot: 7
	public XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x1BCB054 Offset: 0x1BC7054 VA: 0x1BCB054
	public void set_MemberType(XmlSchemaSimpleType value) { }

	// RVA: 0x1BCB05C Offset: 0x1BC705C VA: 0x1BCB05C Slot: 8
	public XmlSchemaType get_SchemaType() { }

	// RVA: 0x1BCB064 Offset: 0x1BC7064 VA: 0x1BCB064
	public void set_SchemaType(XmlSchemaType value) { }

	// RVA: 0x1BCB0A4 Offset: 0x1BC70A4 VA: 0x1BCB0A4 Slot: 9
	public XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x1BCB0AC Offset: 0x1BC70AC VA: 0x1BCB0AC
	public void set_SchemaElement(XmlSchemaElement value) { }

	// RVA: 0x1BCB0EC Offset: 0x1BC70EC VA: 0x1BCB0EC Slot: 10
	public XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x1BCB0F4 Offset: 0x1BC70F4 VA: 0x1BCB0F4
	public void set_SchemaAttribute(XmlSchemaAttribute value) { }

	// RVA: 0x1BCB134 Offset: 0x1BC7134 VA: 0x1BCB134
	public XmlSchemaContentType get_ContentType() { }

	// RVA: 0x1BCB13C Offset: 0x1BC713C VA: 0x1BCB13C
	internal XmlSchemaType get_XmlType() { }

	// RVA: 0x1BCB158 Offset: 0x1BC7158 VA: 0x1BCB158
	internal bool get_HasDefaultValue() { }

	// RVA: 0x1BCB188 Offset: 0x1BC7188 VA: 0x1BCB188
	internal bool get_IsUnionType() { }

	// RVA: 0x1BCAF90 Offset: 0x1BC6F90 VA: 0x1BCAF90
	internal void Clear() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaNotation : XmlSchemaAnnotated // TypeDefIndex: 3600
{
	// Fields
	private string name; // 0x50
	private string publicId; // 0x58
	private string systemId; // 0x60
	private XmlQualifiedName qname; // 0x68

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[Xml("public")]
	public string Public { get; set; }
	[Xml("system")]
	public string System { get; set; }
	[XmlIgnore]
	internal XmlQualifiedName QualifiedName { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x1BCB1C0 Offset: 0x1BC71C0 VA: 0x1BCB1C0
	public string get_Name() { }

	// RVA: 0x1BCB1C8 Offset: 0x1BC71C8 VA: 0x1BCB1C8
	public void set_Name(string value) { }

	// RVA: 0x1BCB1D0 Offset: 0x1BC71D0 VA: 0x1BCB1D0
	public string get_Public() { }

	// RVA: 0x1BCB1D8 Offset: 0x1BC71D8 VA: 0x1BCB1D8
	public void set_Public(string value) { }

	// RVA: 0x1BCB1E0 Offset: 0x1BC71E0 VA: 0x1BCB1E0
	public string get_System() { }

	// RVA: 0x1BCB1E8 Offset: 0x1BC71E8 VA: 0x1BCB1E8
	public void set_System(string value) { }

	// RVA: 0x1BCB1F0 Offset: 0x1BC71F0 VA: 0x1BCB1F0
	internal XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1BCB1F8 Offset: 0x1BC71F8 VA: 0x1BCB1F8
	internal void set_QualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1BCB200 Offset: 0x1BC7200 VA: 0x1BCB200 Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x1BCB208 Offset: 0x1BC7208 VA: 0x1BCB208 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1BCB210 Offset: 0x1BC7210 VA: 0x1BCB210
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaObject // TypeDefIndex: 3601
{
	// Fields
	private int lineNum; // 0x10
	private int linePos; // 0x14
	private string sourceUri; // 0x18
	private XmlSerializerNamespaces namespaces; // 0x20
	private XmlSchemaObject parent; // 0x28
	private bool isProcessing; // 0x30

	// Properties
	[XmlIgnore]
	public int LineNumber { get; set; }
	[XmlIgnore]
	public int LinePosition { get; set; }
	[XmlIgnore]
	public string SourceUri { get; set; }
	[XmlIgnore]
	public XmlSchemaObject Parent { get; set; }
	[XmlNamespaceDeclarations]
	public XmlSerializerNamespaces Namespaces { get; set; }
	[XmlIgnore]
	internal virtual string IdAttribute { get; set; }
	[XmlIgnore]
	internal virtual string NameAttribute { get; set; }
	[XmlIgnore]
	internal bool IsProcessing { get; set; }

	// Methods

	// RVA: 0x1BCB280 Offset: 0x1BC7280 VA: 0x1BCB280
	public int get_LineNumber() { }

	// RVA: 0x1BCB288 Offset: 0x1BC7288 VA: 0x1BCB288
	public void set_LineNumber(int value) { }

	// RVA: 0x1BCB290 Offset: 0x1BC7290 VA: 0x1BCB290
	public int get_LinePosition() { }

	// RVA: 0x1BCB298 Offset: 0x1BC7298 VA: 0x1BCB298
	public void set_LinePosition(int value) { }

	// RVA: 0x1BCB2A0 Offset: 0x1BC72A0 VA: 0x1BCB2A0
	public string get_SourceUri() { }

	// RVA: 0x1BCB2A8 Offset: 0x1BC72A8 VA: 0x1BCB2A8
	public void set_SourceUri(string value) { }

	// RVA: 0x1BCB2B0 Offset: 0x1BC72B0 VA: 0x1BCB2B0
	public XmlSchemaObject get_Parent() { }

	// RVA: 0x1BCB2B8 Offset: 0x1BC72B8 VA: 0x1BCB2B8
	public void set_Parent(XmlSchemaObject value) { }

	// RVA: 0x1BC3C90 Offset: 0x1BBFC90 VA: 0x1BC3C90
	public XmlSerializerNamespaces get_Namespaces() { }

	// RVA: 0x1BCB2C0 Offset: 0x1BC72C0 VA: 0x1BCB2C0
	public void set_Namespaces(XmlSerializerNamespaces value) { }

	// RVA: 0x1BCB2C8 Offset: 0x1BC72C8 VA: 0x1BCB2C8 Slot: 4
	internal virtual void OnAdd(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x1BCB2CC Offset: 0x1BC72CC VA: 0x1BCB2CC Slot: 5
	internal virtual void OnRemove(XmlSchemaObjectCollection container, object item) { }

	// RVA: 0x1BCB2D0 Offset: 0x1BC72D0 VA: 0x1BCB2D0 Slot: 6
	internal virtual void OnClear(XmlSchemaObjectCollection container) { }

	// RVA: 0x1BCB2D4 Offset: 0x1BC72D4 VA: 0x1BCB2D4 Slot: 7
	internal virtual string get_IdAttribute() { }

	// RVA: 0x1BCB2DC Offset: 0x1BC72DC VA: 0x1BCB2DC Slot: 8
	internal virtual void set_IdAttribute(string value) { }

	// RVA: 0x1BCB2E0 Offset: 0x1BC72E0 VA: 0x1BCB2E0 Slot: 9
	internal virtual void SetUnhandledAttributes(XmlAttribute[] moreAttributes) { }

	// RVA: 0x1BCB2E4 Offset: 0x1BC72E4 VA: 0x1BCB2E4 Slot: 10
	internal virtual void AddAnnotation(XmlSchemaAnnotation annotation) { }

	// RVA: 0x1BCB2E8 Offset: 0x1BC72E8 VA: 0x1BCB2E8 Slot: 11
	internal virtual string get_NameAttribute() { }

	// RVA: 0x1BCB2F0 Offset: 0x1BC72F0 VA: 0x1BCB2F0 Slot: 12
	internal virtual void set_NameAttribute(string value) { }

	// RVA: 0x1BCB2F4 Offset: 0x1BC72F4 VA: 0x1BCB2F4
	internal bool get_IsProcessing() { }

	// RVA: 0x1BCB2FC Offset: 0x1BC72FC VA: 0x1BCB2FC
	internal void set_IsProcessing(bool value) { }

	// RVA: 0x1BCB304 Offset: 0x1BC7304 VA: 0x1BCB304 Slot: 13
	internal virtual XmlSchemaObject Clone() { }

	// RVA: 0x1BC33B8 Offset: 0x1BBF3B8 VA: 0x1BC33B8
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
public class XmlSchemaObjectCollection : CollectionBase // TypeDefIndex: 3602
{
	// Fields
	private XmlSchemaObject parent; // 0x18

	// Properties
	public virtual XmlSchemaObject Item { get; set; }

	// Methods

	// RVA: 0x1BC33B0 Offset: 0x1BBF3B0 VA: 0x1BC33B0
	public void .ctor() { }

	// RVA: 0x1BCB384 Offset: 0x1BC7384 VA: 0x1BCB384 Slot: 29
	public virtual XmlSchemaObject get_Item(int index) { }

	// RVA: 0x1BCB484 Offset: 0x1BC7484 VA: 0x1BCB484 Slot: 30
	public virtual void set_Item(int index, XmlSchemaObject value) { }

	// RVA: 0x1BCB54C Offset: 0x1BC754C VA: 0x1BCB54C
	public XmlSchemaObjectEnumerator GetEnumerator() { }

	// RVA: 0x1BC4B48 Offset: 0x1BC0B48 VA: 0x1BC4B48
	public int Add(XmlSchemaObject item) { }

	// RVA: 0x1BCB5CC Offset: 0x1BC75CC VA: 0x1BCB5CC
	public void Insert(int index, XmlSchemaObject item) { }

	// RVA: 0x1BCB694 Offset: 0x1BC7694 VA: 0x1BCB694
	public void Remove(XmlSchemaObject item) { }

	// RVA: 0x1BCB74C Offset: 0x1BC774C VA: 0x1BCB74C Slot: 21
	protected override void OnInsert(int index, object item) { }

	// RVA: 0x1BCB768 Offset: 0x1BC7768 VA: 0x1BCB768 Slot: 20
	protected override void OnSet(int index, object oldValue, object newValue) { }

	// RVA: 0x1BCB7C4 Offset: 0x1BC77C4 VA: 0x1BCB7C4 Slot: 22
	protected override void OnClear() { }

	// RVA: 0x1BCB7E0 Offset: 0x1BC77E0 VA: 0x1BCB7E0 Slot: 23
	protected override void OnRemove(int index, object item) { }

	// RVA: 0x1BC8870 Offset: 0x1BC4870 VA: 0x1BC8870
	internal XmlSchemaObjectCollection Clone() { }

	// RVA: 0x1BCB7FC Offset: 0x1BC77FC VA: 0x1BCB7FC
	private void Add(XmlSchemaObjectCollection collToAdd) { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaObjectEnumerator : IEnumerator // TypeDefIndex: 3603
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public XmlSchemaObject Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1BCB824 Offset: 0x1BC7824 VA: 0x1BCB824
	internal void .ctor(IEnumerator enumerator) { }

	// RVA: 0x1BCB854 Offset: 0x1BC7854 VA: 0x1BCB854
	public bool MoveNext() { }

	// RVA: 0x1BCB8F4 Offset: 0x1BC78F4 VA: 0x1BCB8F4
	public XmlSchemaObject get_Current() { }

	// RVA: 0x1BCB9E4 Offset: 0x1BC79E4 VA: 0x1BCB9E4 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1BCBA88 Offset: 0x1BC7A88 VA: 0x1BCBA88 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1BCBB28 Offset: 0x1BC7B28 VA: 0x1BCBB28 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
internal enum XmlSchemaObjectTable.EnumeratorType // TypeDefIndex: 3604
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaObjectTable.EnumeratorType Keys = 0;
	public const XmlSchemaObjectTable.EnumeratorType Values = 1;
	public const XmlSchemaObjectTable.EnumeratorType DictionaryEntry = 2;
}

// Namespace: 
internal struct XmlSchemaObjectTable.XmlSchemaObjectEntry // TypeDefIndex: 3605
{
	// Fields
	internal XmlQualifiedName qname; // 0x0
	internal XmlSchemaObject xso; // 0x8

	// Methods

	// RVA: 0x1BCBDB8 Offset: 0x1BC7DB8 VA: 0x1BCBDB8
	public void .ctor(XmlQualifiedName name, XmlSchemaObject value) { }
}

// Namespace: 
internal class XmlSchemaObjectTable.ValuesCollection : ICollection, IEnumerable // TypeDefIndex: 3606
{
	// Fields
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private int size; // 0x18

	// Properties
	public int Count { get; }
	public object SyncRoot { get; }
	public bool IsSynchronized { get; }

	// Methods

	// RVA: 0x1BCC3D4 Offset: 0x1BC83D4 VA: 0x1BCC3D4
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size) { }

	// RVA: 0x1BCC50C Offset: 0x1BC850C VA: 0x1BCC50C Slot: 5
	public int get_Count() { }

	// RVA: 0x1BCC514 Offset: 0x1BC8514 VA: 0x1BCC514 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1BCC5B8 Offset: 0x1BC85B8 VA: 0x1BCC5B8 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x1BCC65C Offset: 0x1BC865C VA: 0x1BCC65C Slot: 4
	public void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1BCC778 Offset: 0x1BC8778 VA: 0x1BCC778 Slot: 8
	public IEnumerator GetEnumerator() { }
}

// Namespace: 
internal class XmlSchemaObjectTable.XSOEnumerator : IEnumerator // TypeDefIndex: 3607
{
	// Fields
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x10
	private XmlSchemaObjectTable.EnumeratorType enumType; // 0x18
	protected int currentIndex; // 0x1C
	protected int size; // 0x20
	protected XmlQualifiedName currentKey; // 0x28
	protected XmlSchemaObject currentValue; // 0x30

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1BCC800 Offset: 0x1BC8800 VA: 0x1BCC800
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

	// RVA: 0x1BCC850 Offset: 0x1BC8850 VA: 0x1BCC850 Slot: 5
	public object get_Current() { }

	// RVA: 0x1BCCA00 Offset: 0x1BC8A00 VA: 0x1BCCA00 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1BCCAD0 Offset: 0x1BC8AD0 VA: 0x1BCCAD0 Slot: 6
	public void Reset() { }
}

// Namespace: 
internal class XmlSchemaObjectTable.XSODictionaryEnumerator : XmlSchemaObjectTable.XSOEnumerator, IDictionaryEnumerator, IEnumerator // TypeDefIndex: 3608
{
	// Properties
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1BCC4BC Offset: 0x1BC84BC VA: 0x1BCC4BC
	internal void .ctor(List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries, int size, XmlSchemaObjectTable.EnumeratorType enumType) { }

	// RVA: 0x1BCCB00 Offset: 0x1BC8B00 VA: 0x1BCCB00 Slot: 9
	public DictionaryEntry get_Entry() { }

	// RVA: 0x1BCCC44 Offset: 0x1BC8C44 VA: 0x1BCCC44 Slot: 7
	public object get_Key() { }

	// RVA: 0x1BCCD6C Offset: 0x1BC8D6C VA: 0x1BCCD6C Slot: 8
	public object get_Value() { }
}

// Namespace: System.Xml.Schema
[DefaultMember("Item")]
public class XmlSchemaObjectTable // TypeDefIndex: 3609
{
	// Fields
	private Dictionary<XmlQualifiedName, XmlSchemaObject> table; // 0x10
	private List<XmlSchemaObjectTable.XmlSchemaObjectEntry> entries; // 0x18

	// Properties
	public int Count { get; }
	public XmlSchemaObject Item { get; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x1BCBBCC Offset: 0x1BC7BCC VA: 0x1BCBBCC
	internal void .ctor() { }

	// RVA: 0x1BCBCA8 Offset: 0x1BC7CA8 VA: 0x1BCBCA8
	internal void Add(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1BCBDE8 Offset: 0x1BC7DE8 VA: 0x1BCBDE8
	internal void Insert(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1BCBFA4 Offset: 0x1BC7FA4 VA: 0x1BCBFA4
	internal void Replace(XmlQualifiedName name, XmlSchemaObject value) { }

	// RVA: 0x1BCC0B0 Offset: 0x1BC80B0 VA: 0x1BCC0B0
	internal void Clear() { }

	// RVA: 0x1BCC144 Offset: 0x1BC8144 VA: 0x1BCC144
	internal void Remove(XmlQualifiedName name) { }

	// RVA: 0x1BCBF08 Offset: 0x1BC7F08 VA: 0x1BCBF08
	private int FindIndexByValue(XmlSchemaObject xso) { }

	// RVA: 0x1BCC214 Offset: 0x1BC8214 VA: 0x1BCC214
	public int get_Count() { }

	// RVA: 0x1BCC264 Offset: 0x1BC8264 VA: 0x1BCC264
	public bool Contains(XmlQualifiedName name) { }

	// RVA: 0x1BCC2BC Offset: 0x1BC82BC VA: 0x1BCC2BC
	public XmlSchemaObject get_Item(XmlQualifiedName name) { }

	// RVA: 0x1BCC334 Offset: 0x1BC8334 VA: 0x1BCC334
	public ICollection get_Values() { }

	// RVA: 0x1BCC410 Offset: 0x1BC8410 VA: 0x1BCC410
	public IDictionaryEnumerator GetEnumerator() { }
}

// Namespace: 
[Flags]
private enum XmlSchemaParticle.Occurs // TypeDefIndex: 3610
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaParticle.Occurs None = 0;
	public const XmlSchemaParticle.Occurs Min = 1;
	public const XmlSchemaParticle.Occurs Max = 2;
}

// Namespace: 
private class XmlSchemaParticle.EmptyParticle : XmlSchemaParticle // TypeDefIndex: 3611
{
	// Properties
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x1BCD990 Offset: 0x1BC9990 VA: 0x1BCD990 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x1BCD93C Offset: 0x1BC993C VA: 0x1BCD93C
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaParticle : XmlSchemaAnnotated // TypeDefIndex: 3612
{
	// Fields
	private Decimal minOccurs; // 0x50
	private Decimal maxOccurs; // 0x60
	private XmlSchemaParticle.Occurs flags; // 0x70
	internal static readonly XmlSchemaParticle Empty; // 0x0

	// Properties
	[Xml("minOccurs")]
	public string MinOccursString { get; set; }
	[Xml("maxOccurs")]
	public string MaxOccursString { get; set; }
	[XmlIgnore]
	public Decimal MinOccurs { get; set; }
	[XmlIgnore]
	public Decimal MaxOccurs { get; set; }
	internal virtual bool IsEmpty { get; }
	internal virtual string NameString { get; }

	// Methods

	// RVA: 0x1BCCE94 Offset: 0x1BC8E94 VA: 0x1BCCE94
	public string get_MinOccursString() { }

	// RVA: 0x1BCCF0C Offset: 0x1BC8F0C VA: 0x1BCCF0C
	public void set_MinOccursString(string value) { }

	// RVA: 0x1BCD060 Offset: 0x1BC9060 VA: 0x1BCD060
	public string get_MaxOccursString() { }

	// RVA: 0x1BCD184 Offset: 0x1BC9184 VA: 0x1BCD184
	public void set_MaxOccursString(string value) { }

	// RVA: 0x1BCD3B0 Offset: 0x1BC93B0 VA: 0x1BCD3B0
	public Decimal get_MinOccurs() { }

	// RVA: 0x1BCD3BC Offset: 0x1BC93BC VA: 0x1BCD3BC
	public void set_MinOccurs(Decimal value) { }

	// RVA: 0x1BCD4E8 Offset: 0x1BC94E8 VA: 0x1BCD4E8
	public Decimal get_MaxOccurs() { }

	// RVA: 0x1BCD4F4 Offset: 0x1BC94F4 VA: 0x1BCD4F4
	public void set_MaxOccurs(Decimal value) { }

	// RVA: 0x1BCD658 Offset: 0x1BC9658 VA: 0x1BCD658 Slot: 14
	internal virtual bool get_IsEmpty() { }

	// RVA: 0x1BCD6C4 Offset: 0x1BC96C4 VA: 0x1BCD6C4 Slot: 15
	internal virtual string get_NameString() { }

	// RVA: 0x1BCD6DC Offset: 0x1BC96DC VA: 0x1BCD6DC
	internal XmlQualifiedName GetQualifiedName() { }

	// RVA: 0x1BCD850 Offset: 0x1BC9850 VA: 0x1BCD850
	protected void .ctor() { }

	// RVA: 0x1BCD8C4 Offset: 0x1BC98C4 VA: 0x1BCD8C4
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaRedefine : XmlSchemaExternal // TypeDefIndex: 3613
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x68
	private XmlSchemaObjectTable attributeGroups; // 0x70
	private XmlSchemaObjectTable types; // 0x78
	private XmlSchemaObjectTable groups; // 0x80

	// Properties
	[XmlElement("annotation", typeof(XmlSchemaAnnotation))]
	[XmlElement("complexType", typeof(XmlSchemaComplexType))]
	[XmlElement("group", typeof(XmlSchemaGroup))]
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroup))]
	public XmlSchemaObjectCollection Items { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable AttributeGroups { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable SchemaTypes { get; }
	[XmlIgnore]
	public XmlSchemaObjectTable Groups { get; }

	// Methods

	// RVA: 0x1BCD998 Offset: 0x1BC9998 VA: 0x1BCD998
	public void .ctor() { }

	// RVA: 0x1BCDA8C Offset: 0x1BC9A8C VA: 0x1BCDA8C
	public XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1BCDA94 Offset: 0x1BC9A94 VA: 0x1BCDA94
	public XmlSchemaObjectTable get_AttributeGroups() { }

	// RVA: 0x1BCDA9C Offset: 0x1BC9A9C VA: 0x1BCDA9C
	public XmlSchemaObjectTable get_SchemaTypes() { }

	// RVA: 0x1BCDAA4 Offset: 0x1BC9AA4 VA: 0x1BCDAA4
	public XmlSchemaObjectTable get_Groups() { }

	// RVA: 0x1BCDAAC Offset: 0x1BC9AAC VA: 0x1BCDAAC Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSequence : XmlSchemaGroupBase // TypeDefIndex: 3614
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x1BCDAC4 Offset: 0x1BC9AC4 VA: 0x1BCDAC4 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x1BCDACC Offset: 0x1BC9ACC VA: 0x1BCDACC Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x1BCDB08 Offset: 0x1BC9B08 VA: 0x1BCDB08 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x1BCDB10 Offset: 0x1BC9B10 VA: 0x1BCDB10
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSet // TypeDefIndex: 3615
{
	// Fields
	private XmlNameTable nameTable; // 0x10
	private SchemaNames schemaNames; // 0x18
	private SortedList schemas; // 0x20
	private ValidationEventHandler internalEventHandler; // 0x28
	private ValidationEventHandler eventHandler; // 0x30
	private bool isCompiled; // 0x38
	private Hashtable schemaLocations; // 0x40
	private Hashtable chameleonSchemas; // 0x48
	private Hashtable targetNamespaces; // 0x50
	private bool compileAll; // 0x58
	private SchemaInfo cachedCompiledInfo; // 0x60
	private XmlReaderSettings readerSettings; // 0x68
	private XmlSchema schemaForSchema; // 0x70
	private XmlSchemaCompilationSettings compilationSettings; // 0x78
	internal XmlSchemaObjectTable elements; // 0x80
	internal XmlSchemaObjectTable attributes; // 0x88
	internal XmlSchemaObjectTable schemaTypes; // 0x90
	internal XmlSchemaObjectTable substitutionGroups; // 0x98
	private XmlSchemaObjectTable typeExtensions; // 0xA0
	private object internalSyncObject; // 0xA8

	// Properties
	internal object InternalSyncObject { get; }
	public bool IsCompiled { get; }
	public XmlResolver XmlResolver { set; }
	public XmlSchemaCompilationSettings CompilationSettings { get; set; }
	public int Count { get; }
	public XmlSchemaObjectTable GlobalElements { get; }
	public XmlSchemaObjectTable GlobalAttributes { get; }
	public XmlSchemaObjectTable GlobalTypes { get; }
	internal XmlSchemaObjectTable SubstitutionGroups { get; }
	internal Hashtable SchemaLocations { get; }
	internal XmlSchemaObjectTable TypeExtensions { get; }
	internal SchemaInfo CompiledInfo { get; }
	internal XmlReaderSettings ReaderSettings { get; }
	internal SortedList SortedSchemas { get; }

	// Methods

	// RVA: 0x1BCDB7C Offset: 0x1BC9B7C VA: 0x1BCDB7C
	internal object get_InternalSyncObject() { }

	// RVA: 0x1BCDBEC Offset: 0x1BC9BEC VA: 0x1BCDBEC
	public void .ctor() { }

	// RVA: 0x1BCDC48 Offset: 0x1BC9C48 VA: 0x1BCDC48
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x1BCDF40 Offset: 0x1BC9F40 VA: 0x1BCDF40
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1BCE050 Offset: 0x1BCA050 VA: 0x1BCE050
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1BCE108 Offset: 0x1BCA108 VA: 0x1BCE108
	public bool get_IsCompiled() { }

	// RVA: 0x1BCE110 Offset: 0x1BCA110 VA: 0x1BCE110
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1BCE128 Offset: 0x1BCA128 VA: 0x1BCE128
	public XmlSchemaCompilationSettings get_CompilationSettings() { }

	// RVA: 0x1BCE130 Offset: 0x1BCA130 VA: 0x1BCE130
	public void set_CompilationSettings(XmlSchemaCompilationSettings value) { }

	// RVA: 0x1BCE138 Offset: 0x1BCA138 VA: 0x1BCE138
	public int get_Count() { }

	// RVA: 0x1BCE158 Offset: 0x1BCA158 VA: 0x1BCE158
	public XmlSchemaObjectTable get_GlobalElements() { }

	// RVA: 0x1BCE1C4 Offset: 0x1BCA1C4 VA: 0x1BCE1C4
	public XmlSchemaObjectTable get_GlobalAttributes() { }

	// RVA: 0x1BCE230 Offset: 0x1BCA230 VA: 0x1BCE230
	public XmlSchemaObjectTable get_GlobalTypes() { }

	// RVA: 0x1BCE29C Offset: 0x1BCA29C VA: 0x1BCE29C
	internal XmlSchemaObjectTable get_SubstitutionGroups() { }

	// RVA: 0x1BCE308 Offset: 0x1BCA308 VA: 0x1BCE308
	internal Hashtable get_SchemaLocations() { }

	// RVA: 0x1BCE310 Offset: 0x1BCA310 VA: 0x1BCE310
	internal XmlSchemaObjectTable get_TypeExtensions() { }

	// RVA: 0x1BCE37C Offset: 0x1BCA37C VA: 0x1BCE37C
	public void Add(XmlSchemaSet schemas) { }

	// RVA: 0x1BD07F4 Offset: 0x1BCC7F4 VA: 0x1BD07F4
	public XmlSchema Add(XmlSchema schema) { }

	// RVA: 0x1BD097C Offset: 0x1BCC97C VA: 0x1BD097C
	public bool RemoveRecursive(XmlSchema schemaToRemove) { }

	// RVA: 0x1BD1780 Offset: 0x1BCD780 VA: 0x1BD1780
	public bool Contains(string targetNamespace) { }

	// RVA: 0x1BD17C8 Offset: 0x1BCD7C8 VA: 0x1BD17C8
	public void Compile() { }

	// RVA: 0x1BD1CE0 Offset: 0x1BCDCE0 VA: 0x1BD1CE0
	public XmlSchema Reprocess(XmlSchema schema) { }

	// RVA: 0x1BD36B0 Offset: 0x1BCF6B0 VA: 0x1BD36B0
	public void CopyTo(XmlSchema[] schemas, int index) { }

	// RVA: 0x1BD3814 Offset: 0x1BCF814 VA: 0x1BD3814
	public ICollection Schemas() { }

	// RVA: 0x1BD3420 Offset: 0x1BCF420 VA: 0x1BD3420
	public ICollection Schemas(string targetNamespace) { }

	// RVA: 0x1BD079C Offset: 0x1BCC79C VA: 0x1BD079C
	private XmlSchema Add(string targetNamespace, XmlSchema schema) { }

	// RVA: 0x1BD3BC8 Offset: 0x1BCFBC8 VA: 0x1BD3BC8
	internal void Add(string targetNamespace, XmlReader reader, Hashtable validatedNamespaces) { }

	// RVA: 0x1BD0548 Offset: 0x1BCC548 VA: 0x1BD0548
	internal XmlSchema FindSchemaByNSAndUrl(Uri schemaUri, string ns, DictionaryEntry[] locationsTable) { }

	// RVA: 0x1BD3834 Offset: 0x1BCF834 VA: 0x1BD3834
	private void AddSchemaToSet(XmlSchema schema) { }

	// RVA: 0x1BD4374 Offset: 0x1BD0374 VA: 0x1BD4374
	private void ProcessNewSubstitutionGroups(XmlSchemaObjectTable substitutionGroupsTable, bool resolve) { }

	// RVA: 0x1BD4814 Offset: 0x1BD0814 VA: 0x1BD4814
	private void ResolveSubstitutionGroup(XmlSchemaSubstitutionGroup substitutionGroup, XmlSchemaObjectTable substTable) { }

	// RVA: 0x1BD1424 Offset: 0x1BCD424 VA: 0x1BD1424
	internal XmlSchema Remove(XmlSchema schema, bool forceCompile) { }

	// RVA: 0x1BD1C84 Offset: 0x1BCDC84 VA: 0x1BD1C84
	private void ClearTables() { }

	// RVA: 0x1BD3584 Offset: 0x1BCF584 VA: 0x1BD3584
	internal bool PreprocessSchema(ref XmlSchema schema, string targetNamespace) { }

	// RVA: 0x1BD41FC Offset: 0x1BD01FC VA: 0x1BD41FC
	internal XmlSchema ParseSchema(string targetNamespace, XmlReader reader) { }

	// RVA: 0x1BCEC80 Offset: 0x1BCAC80 VA: 0x1BCEC80
	internal void CopyFromCompiledSet(XmlSchemaSet otherSet) { }

	// RVA: 0x1BD508C Offset: 0x1BD108C VA: 0x1BD508C
	internal SchemaInfo get_CompiledInfo() { }

	// RVA: 0x1BD5094 Offset: 0x1BD1094 VA: 0x1BD5094
	internal XmlReaderSettings get_ReaderSettings() { }

	// RVA: 0x1BD509C Offset: 0x1BD109C VA: 0x1BD509C
	internal XmlResolver GetResolver() { }

	// RVA: 0x1BD50B4 Offset: 0x1BD10B4 VA: 0x1BD50B4
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x1BD4EC4 Offset: 0x1BD0EC4 VA: 0x1BD4EC4
	internal SchemaNames GetSchemaNames(XmlNameTable nt) { }

	// RVA: 0x1BD3F54 Offset: 0x1BCFF54 VA: 0x1BD3F54
	internal bool IsSchemaLoaded(Uri schemaUri, string targetNamespace, out XmlSchema schema) { }

	// RVA: 0x1BD50BC Offset: 0x1BD10BC VA: 0x1BD50BC
	internal bool GetSchemaByUri(Uri schemaUri, out XmlSchema schema) { }

	// RVA: 0x1BD1354 Offset: 0x1BCD354 VA: 0x1BD1354
	internal string GetTargetNamespace(XmlSchema schema) { }

	// RVA: 0x1BD5220 Offset: 0x1BD1220 VA: 0x1BD5220
	internal SortedList get_SortedSchemas() { }

	// RVA: 0x1BD2E40 Offset: 0x1BCEE40 VA: 0x1BD2E40
	private void RemoveSchemaFromCaches(XmlSchema schema) { }

	// RVA: 0x1BD2458 Offset: 0x1BCE458 VA: 0x1BD2458
	private void RemoveSchemaFromGlobalTables(XmlSchema schema) { }

	// RVA: 0x1BD4BF0 Offset: 0x1BD0BF0 VA: 0x1BD4BF0
	private bool AddToTable(XmlSchemaObjectTable table, XmlQualifiedName qname, XmlSchemaObject item) { }

	// RVA: 0x1BD4F68 Offset: 0x1BD0F68 VA: 0x1BD4F68
	private void VerifyTables() { }

	// RVA: 0x1BD5228 Offset: 0x1BD1228 VA: 0x1BD5228
	private void InternalValidationCallback(object sender, ValidationEventArgs e) { }

	// RVA: 0x1BD1384 Offset: 0x1BCD384 VA: 0x1BD1384
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContent : XmlSchemaContentModel // TypeDefIndex: 3616
{
	// Fields
	private XmlSchemaContent content; // 0x50

	// Properties
	[XmlElement("extension", typeof(XmlSchemaSimpleContentExtension))]
	[XmlElement("restriction", typeof(XmlSchemaSimpleContentRestriction))]
	public override XmlSchemaContent Content { get; set; }

	// Methods

	// RVA: 0x1BD526C Offset: 0x1BD126C VA: 0x1BD526C Slot: 14
	public override XmlSchemaContent get_Content() { }

	// RVA: 0x1BD5274 Offset: 0x1BD1274 VA: 0x1BD5274 Slot: 15
	public override void set_Content(XmlSchemaContent value) { }

	// RVA: 0x1BD527C Offset: 0x1BD127C VA: 0x1BD527C
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContentExtension : XmlSchemaContent // TypeDefIndex: 3617
{
	// Fields
	private XmlSchemaObjectCollection attributes; // 0x50
	private XmlSchemaAnyAttribute anyAttribute; // 0x58
	private XmlQualifiedName baseTypeName; // 0x60

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x1BD5284 Offset: 0x1BD1284 VA: 0x1BD5284
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1BD528C Offset: 0x1BD128C VA: 0x1BD528C
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x1BD532C Offset: 0x1BD132C VA: 0x1BD532C
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x1BD5334 Offset: 0x1BD1334 VA: 0x1BD5334
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1BD533C Offset: 0x1BD133C VA: 0x1BD533C
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1BD5344 Offset: 0x1BD1344 VA: 0x1BD5344
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1BD534C Offset: 0x1BD134C VA: 0x1BD534C
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleContentRestriction : XmlSchemaContent // TypeDefIndex: 3618
{
	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60
	private XmlSchemaObjectCollection attributes; // 0x68
	private XmlSchemaAnyAttribute anyAttribute; // 0x70

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
	[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
	[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
	[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
	[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
	[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
	[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
	[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
	[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
	[XmlElement("length", typeof(XmlSchemaLengthFacet))]
	[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
	[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
	public XmlSchemaObjectCollection Facets { get; }
	[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
	[XmlElement("attribute", typeof(XmlSchemaAttribute))]
	public XmlSchemaObjectCollection Attributes { get; }
	[XmlElement("anyAttribute")]
	public XmlSchemaAnyAttribute AnyAttribute { get; set; }

	// Methods

	// RVA: 0x1BD53FC Offset: 0x1BD13FC VA: 0x1BD53FC
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1BD5404 Offset: 0x1BD1404 VA: 0x1BD5404
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x1BD54A4 Offset: 0x1BD14A4 VA: 0x1BD54A4
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x1BD54AC Offset: 0x1BD14AC VA: 0x1BD54AC
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x1BD54B4 Offset: 0x1BD14B4 VA: 0x1BD54B4
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x1BD54BC Offset: 0x1BD14BC VA: 0x1BD54BC
	public XmlSchemaObjectCollection get_Attributes() { }

	// RVA: 0x1BD54C4 Offset: 0x1BD14C4 VA: 0x1BD54C4
	public XmlSchemaAnyAttribute get_AnyAttribute() { }

	// RVA: 0x1BD54CC Offset: 0x1BD14CC VA: 0x1BD54CC
	public void set_AnyAttribute(XmlSchemaAnyAttribute value) { }

	// RVA: 0x1BD54D4 Offset: 0x1BD14D4 VA: 0x1BD54D4
	internal void SetAttributes(XmlSchemaObjectCollection newAttributes) { }

	// RVA: 0x1BD54DC Offset: 0x1BD14DC VA: 0x1BD54DC
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleType : XmlSchemaType // TypeDefIndex: 3619
{
	// Fields
	private XmlSchemaSimpleTypeContent content; // 0x98

	// Properties
	[XmlElement("restriction", typeof(XmlSchemaSimpleTypeRestriction))]
	[XmlElement("list", typeof(XmlSchemaSimpleTypeList))]
	[XmlElement("union", typeof(XmlSchemaSimpleTypeUnion))]
	public XmlSchemaSimpleTypeContent Content { get; set; }

	// Methods

	// RVA: 0x1BD55A8 Offset: 0x1BD15A8 VA: 0x1BD55A8
	public void .ctor() { }

	// RVA: 0x1BD562C Offset: 0x1BD162C VA: 0x1BD562C
	public XmlSchemaSimpleTypeContent get_Content() { }

	// RVA: 0x1BD5634 Offset: 0x1BD1634 VA: 0x1BD5634
	public void set_Content(XmlSchemaSimpleTypeContent value) { }

	// RVA: 0x1BD563C Offset: 0x1BD163C VA: 0x1BD563C Slot: 13
	internal override XmlSchemaObject Clone() { }
}

// Namespace: System.Xml.Schema
public abstract class XmlSchemaSimpleTypeContent : XmlSchemaAnnotated // TypeDefIndex: 3620
{
	// Methods

	// RVA: 0x1BD5748 Offset: 0x1BD1748 VA: 0x1BD5748
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent // TypeDefIndex: 3621
{
	// Fields
	private XmlQualifiedName itemTypeName; // 0x50
	private XmlSchemaSimpleType itemType; // 0x58
	private XmlSchemaSimpleType baseItemType; // 0x60

	// Properties
	[Xml("itemType")]
	public XmlQualifiedName ItemTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType ItemType { get; set; }
	[XmlIgnore]
	public XmlSchemaSimpleType BaseItemType { get; set; }

	// Methods

	// RVA: 0x1BD5750 Offset: 0x1BD1750 VA: 0x1BD5750
	public XmlQualifiedName get_ItemTypeName() { }

	// RVA: 0x1BD5758 Offset: 0x1BD1758 VA: 0x1BD5758
	public void set_ItemTypeName(XmlQualifiedName value) { }

	// RVA: 0x1BD57F8 Offset: 0x1BD17F8 VA: 0x1BD57F8
	public XmlSchemaSimpleType get_ItemType() { }

	// RVA: 0x1BD5800 Offset: 0x1BD1800 VA: 0x1BD5800
	public void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x1BD5808 Offset: 0x1BD1808 VA: 0x1BD5808
	public XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0x1BD5810 Offset: 0x1BD1810 VA: 0x1BD5810
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x1BD5818 Offset: 0x1BD1818 VA: 0x1BD5818 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1BD58D8 Offset: 0x1BD18D8 VA: 0x1BD58D8
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeRestriction : XmlSchemaSimpleTypeContent // TypeDefIndex: 3622
{
	// Fields
	private XmlQualifiedName baseTypeName; // 0x50
	private XmlSchemaSimpleType baseType; // 0x58
	private XmlSchemaObjectCollection facets; // 0x60

	// Properties
	[Xml("base")]
	public XmlQualifiedName BaseTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType BaseType { get; set; }
	[XmlElement("totalDigits", typeof(XmlSchemaTotalDigitsFacet))]
	[XmlElement("length", typeof(XmlSchemaLengthFacet))]
	[XmlElement("maxInclusive", typeof(XmlSchemaMaxInclusiveFacet))]
	[XmlElement("minLength", typeof(XmlSchemaMinLengthFacet))]
	[XmlElement("maxExclusive", typeof(XmlSchemaMaxExclusiveFacet))]
	[XmlElement("minExclusive", typeof(XmlSchemaMinExclusiveFacet))]
	[XmlElement("enumeration", typeof(XmlSchemaEnumerationFacet))]
	[XmlElement("pattern", typeof(XmlSchemaPatternFacet))]
	[XmlElement("whiteSpace", typeof(XmlSchemaWhiteSpaceFacet))]
	[XmlElement("fractionDigits", typeof(XmlSchemaFractionDigitsFacet))]
	[XmlElement("minInclusive", typeof(XmlSchemaMinInclusiveFacet))]
	[XmlElement("maxLength", typeof(XmlSchemaMaxLengthFacet))]
	public XmlSchemaObjectCollection Facets { get; }

	// Methods

	// RVA: 0x1BD5948 Offset: 0x1BD1948 VA: 0x1BD5948
	public XmlQualifiedName get_BaseTypeName() { }

	// RVA: 0x1BD5950 Offset: 0x1BD1950 VA: 0x1BD5950
	public void set_BaseTypeName(XmlQualifiedName value) { }

	// RVA: 0x1BD59F0 Offset: 0x1BD19F0 VA: 0x1BD59F0
	public XmlSchemaSimpleType get_BaseType() { }

	// RVA: 0x1BD59F8 Offset: 0x1BD19F8 VA: 0x1BD59F8
	public void set_BaseType(XmlSchemaSimpleType value) { }

	// RVA: 0x1BD5A00 Offset: 0x1BD1A00 VA: 0x1BD5A00
	public XmlSchemaObjectCollection get_Facets() { }

	// RVA: 0x1BD5A08 Offset: 0x1BD1A08 VA: 0x1BD5A08 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1BD5AC8 Offset: 0x1BD1AC8 VA: 0x1BD5AC8
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaSimpleTypeUnion : XmlSchemaSimpleTypeContent // TypeDefIndex: 3623
{
	// Fields
	private XmlSchemaObjectCollection baseTypes; // 0x50
	private XmlQualifiedName[] memberTypes; // 0x58
	private XmlSchemaSimpleType[] baseMemberTypes; // 0x60

	// Properties
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaObjectCollection BaseTypes { get; }
	[Xml("memberTypes")]
	public XmlQualifiedName[] MemberTypes { get; set; }
	[XmlIgnore]
	public XmlSchemaSimpleType[] BaseMemberTypes { get; }

	// Methods

	// RVA: 0x1BD5B70 Offset: 0x1BD1B70 VA: 0x1BD5B70
	public XmlSchemaObjectCollection get_BaseTypes() { }

	// RVA: 0x1BD5B78 Offset: 0x1BD1B78 VA: 0x1BD5B78
	public XmlQualifiedName[] get_MemberTypes() { }

	// RVA: 0x1BD5B80 Offset: 0x1BD1B80 VA: 0x1BD5B80
	public void set_MemberTypes(XmlQualifiedName[] value) { }

	// RVA: 0x1BD5B88 Offset: 0x1BD1B88 VA: 0x1BD5B88
	public XmlSchemaSimpleType[] get_BaseMemberTypes() { }

	// RVA: 0x1BD5B90 Offset: 0x1BD1B90 VA: 0x1BD5B90
	internal void SetBaseMemberTypes(XmlSchemaSimpleType[] baseMemberTypes) { }

	// RVA: 0x1BD5B98 Offset: 0x1BD1B98 VA: 0x1BD5B98 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x1BD5D28 Offset: 0x1BD1D28 VA: 0x1BD5D28
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroup : XmlSchemaObject // TypeDefIndex: 3624
{
	// Fields
	private ArrayList membersList; // 0x38
	private XmlQualifiedName examplar; // 0x40

	// Properties
	[XmlIgnore]
	internal ArrayList Members { get; }
	[XmlIgnore]
	internal XmlQualifiedName Examplar { get; set; }

	// Methods

	// RVA: 0x1BD5D94 Offset: 0x1BD1D94 VA: 0x1BD5D94
	internal ArrayList get_Members() { }

	// RVA: 0x1BD5D9C Offset: 0x1BD1D9C VA: 0x1BD5D9C
	internal XmlQualifiedName get_Examplar() { }

	// RVA: 0x1BD5DA4 Offset: 0x1BD1DA4 VA: 0x1BD5DA4
	internal void set_Examplar(XmlQualifiedName value) { }

	// RVA: 0x1BD5DAC Offset: 0x1BD1DAC VA: 0x1BD5DAC
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlSchemaSubstitutionGroupV1Compat : XmlSchemaSubstitutionGroup // TypeDefIndex: 3625
{
	// Fields
	private XmlSchemaChoice choice; // 0x48

	// Properties
	[XmlIgnore]
	internal XmlSchemaChoice Choice { get; }

	// Methods

	// RVA: 0x1BD5E5C Offset: 0x1BD1E5C VA: 0x1BD5E5C
	internal XmlSchemaChoice get_Choice() { }

	// RVA: 0x1BD5E64 Offset: 0x1BD1E64 VA: 0x1BD5E64
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public class XmlSchemaType : XmlSchemaAnnotated // TypeDefIndex: 3626
{
	// Fields
	private string name; // 0x50
	private XmlSchemaDerivationMethod final; // 0x58
	private XmlSchemaDerivationMethod derivedBy; // 0x5C
	private XmlSchemaType baseSchemaType; // 0x60
	private XmlSchemaDatatype datatype; // 0x68
	private XmlSchemaDerivationMethod finalResolved; // 0x70
	private SchemaElementDecl elementDecl; // 0x78
	private XmlQualifiedName qname; // 0x80
	private XmlSchemaType redefined; // 0x88
	private XmlSchemaContentType contentType; // 0x90

	// Properties
	[Xml("name")]
	public string Name { get; set; }
	[Xml("final")]
	[DefaultValue(256)]
	public XmlSchemaDerivationMethod Final { get; set; }
	[XmlIgnore]
	public XmlQualifiedName QualifiedName { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod FinalResolved { get; }
	[XmlIgnore]
	public XmlSchemaType BaseXmlSchemaType { get; }
	[XmlIgnore]
	public XmlSchemaDerivationMethod DerivedBy { get; }
	[XmlIgnore]
	public XmlSchemaDatatype Datatype { get; }
	[XmlIgnore]
	public virtual bool IsMixed { get; set; }
	[XmlIgnore]
	public XmlTypeCode TypeCode { get; }
	[XmlIgnore]
	internal XmlValueConverter ValueConverter { get; }
	internal XmlSchemaContentType SchemaContentType { get; }
	internal SchemaElementDecl ElementDecl { get; set; }
	[XmlIgnore]
	internal XmlSchemaType Redefined { get; set; }
	[XmlIgnore]
	internal override string NameAttribute { get; set; }

	// Methods

	// RVA: 0x1BD5ECC Offset: 0x1BD1ECC VA: 0x1BD5ECC
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x1BD5FA4 Offset: 0x1BD1FA4 VA: 0x1BD5FA4
	public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode) { }

	// RVA: 0x1BD5FFC Offset: 0x1BD1FFC VA: 0x1BD5FFC
	public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName) { }

	// RVA: 0x1BD6244 Offset: 0x1BD2244 VA: 0x1BD6244
	public string get_Name() { }

	// RVA: 0x1BD624C Offset: 0x1BD224C VA: 0x1BD624C
	public void set_Name(string value) { }

	// RVA: 0x1BD6254 Offset: 0x1BD2254 VA: 0x1BD6254
	public XmlSchemaDerivationMethod get_Final() { }

	// RVA: 0x1BD625C Offset: 0x1BD225C VA: 0x1BD625C
	public void set_Final(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1BD5074 Offset: 0x1BD1074 VA: 0x1BD5074
	public XmlQualifiedName get_QualifiedName() { }

	// RVA: 0x1BD6264 Offset: 0x1BD2264 VA: 0x1BD6264
	public XmlSchemaDerivationMethod get_FinalResolved() { }

	// RVA: 0x1BD626C Offset: 0x1BD226C VA: 0x1BD626C
	public XmlSchemaType get_BaseXmlSchemaType() { }

	// RVA: 0x1BD6274 Offset: 0x1BD2274 VA: 0x1BD6274
	public XmlSchemaDerivationMethod get_DerivedBy() { }

	// RVA: 0x1BD627C Offset: 0x1BD227C VA: 0x1BD627C
	public XmlSchemaDatatype get_Datatype() { }

	// RVA: 0x1BD6284 Offset: 0x1BD2284 VA: 0x1BD6284 Slot: 14
	public virtual bool get_IsMixed() { }

	// RVA: 0x1BD628C Offset: 0x1BD228C VA: 0x1BD628C Slot: 15
	public virtual void set_IsMixed(bool value) { }

	// RVA: 0x1BD6290 Offset: 0x1BD2290 VA: 0x1BD6290
	public XmlTypeCode get_TypeCode() { }

	// RVA: 0x1BD6344 Offset: 0x1BD2344 VA: 0x1BD6344
	internal XmlValueConverter get_ValueConverter() { }

	// RVA: 0x1BD63BC Offset: 0x1BD23BC VA: 0x1BD63BC
	internal XmlSchemaContentType get_SchemaContentType() { }

	// RVA: 0x1BD63C4 Offset: 0x1BD23C4 VA: 0x1BD63C4
	internal void SetQualifiedName(XmlQualifiedName value) { }

	// RVA: 0x1BD63F0 Offset: 0x1BD23F0 VA: 0x1BD63F0
	internal void SetFinalResolved(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1BD63F8 Offset: 0x1BD23F8 VA: 0x1BD63F8
	internal void SetBaseSchemaType(XmlSchemaType value) { }

	// RVA: 0x1BD6400 Offset: 0x1BD2400 VA: 0x1BD6400
	internal void SetDerivedBy(XmlSchemaDerivationMethod value) { }

	// RVA: 0x1BD6408 Offset: 0x1BD2408 VA: 0x1BD6408
	internal void SetDatatype(XmlSchemaDatatype value) { }

	// RVA: 0x1BD6410 Offset: 0x1BD2410 VA: 0x1BD6410
	internal SchemaElementDecl get_ElementDecl() { }

	// RVA: 0x1BD6428 Offset: 0x1BD2428 VA: 0x1BD6428
	internal void set_ElementDecl(SchemaElementDecl value) { }

	// RVA: 0x1BD6454 Offset: 0x1BD2454 VA: 0x1BD6454
	internal XmlSchemaType get_Redefined() { }

	// RVA: 0x1BD645C Offset: 0x1BD245C VA: 0x1BD645C
	internal void set_Redefined(XmlSchemaType value) { }

	// RVA: 0x1BD6464 Offset: 0x1BD2464 VA: 0x1BD6464
	internal void SetContentType(XmlSchemaContentType value) { }

	// RVA: 0x1BD646C Offset: 0x1BD246C VA: 0x1BD646C
	public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x1BD6628 Offset: 0x1BD2628 VA: 0x1BD6628
	internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except) { }

	// RVA: 0x1BD66FC Offset: 0x1BD26FC VA: 0x1BD66FC Slot: 11
	internal override string get_NameAttribute() { }

	// RVA: 0x1BD6704 Offset: 0x1BD2704 VA: 0x1BD6704 Slot: 12
	internal override void set_NameAttribute(string value) { }

	// RVA: 0x1BD55AC Offset: 0x1BD15AC VA: 0x1BD55AC
	public void .ctor() { }
}

// Namespace: System.Xml.Schema
public enum XmlSchemaUse // TypeDefIndex: 3627
{
	// Fields
	public int value__; // 0x0
	[XmlIgnore]
	public const XmlSchemaUse None = 0;
	[XmlEnum("optional")]
	public const XmlSchemaUse Optional = 1;
	[XmlEnum("prohibited")]
	public const XmlSchemaUse Prohibited = 2;
	[XmlEnum("required")]
	public const XmlSchemaUse Required = 3;
}

// Namespace: System.Xml.Schema
[Serializable]
public class XmlSchemaValidationException : XmlSchemaException // TypeDefIndex: 3628
{
	// Methods

	// RVA: 0x1BD670C Offset: 0x1BD270C VA: 0x1BD670C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BD6714 Offset: 0x1BD2714 VA: 0x1BD6714 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1BD671C Offset: 0x1BD271C VA: 0x1BD671C
	public void .ctor() { }

	// RVA: 0x1BD6728 Offset: 0x1BD2728 VA: 0x1BD6728
	internal void .ctor(string res, string arg, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1BD67F8 Offset: 0x1BD27F8 VA: 0x1BD67F8
	internal void .ctor(string res, string[] args, string sourceUri, int lineNumber, int linePosition) { }

	// RVA: 0x1BD6828 Offset: 0x1BD2828 VA: 0x1BD6828
	internal void .ctor(string res, string[] args, Exception innerException, string sourceUri, int lineNumber, int linePosition) { }
}

// Namespace: System.Xml.Schema
public sealed class XmlValueGetter : MulticastDelegate // TypeDefIndex: 3629
{
	// Methods

	// RVA: 0x1BD6848 Offset: 0x1BD2848 VA: 0x1BD6848
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1BD68E4 Offset: 0x1BD28E4 VA: 0x1BD68E4 Slot: 12
	public virtual object Invoke() { }
}

// Namespace: System.Xml.Schema
[Flags]
public enum XmlSchemaValidationFlags // TypeDefIndex: 3630
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaValidationFlags None = 0;
	public const XmlSchemaValidationFlags ProcessInlineSchema = 1;
	public const XmlSchemaValidationFlags ProcessSchemaLocation = 2;
	public const XmlSchemaValidationFlags ReportValidationWarnings = 4;
	public const XmlSchemaValidationFlags ProcessIdentityConstraints = 8;
	public const XmlSchemaValidationFlags AllowXmlAttributes = 16;
}

// Namespace: System.Xml.Schema
internal enum ValidatorState // TypeDefIndex: 3631
{
	// Fields
	public int value__; // 0x0
	public const ValidatorState None = 0;
	public const ValidatorState Start = 1;
	public const ValidatorState TopLevelAttribute = 2;
	public const ValidatorState TopLevelTextOrWS = 3;
	public const ValidatorState Element = 4;
	public const ValidatorState Attribute = 5;
	public const ValidatorState EndOfAttributes = 6;
	public const ValidatorState Text = 7;
	public const ValidatorState Whitespace = 8;
	public const ValidatorState EndElement = 9;
	public const ValidatorState SkipToEndElement = 10;
	public const ValidatorState Finish = 11;
}

// Namespace: System.Xml.Schema
internal class IdRefNode // TypeDefIndex: 3632
{
	// Fields
	internal string Id; // 0x10
	internal int LineNo; // 0x18
	internal int LinePos; // 0x1C
	internal IdRefNode Next; // 0x20

	// Methods

	// RVA: 0x1BD68F8 Offset: 0x1BD28F8 VA: 0x1BD68F8
	internal void .ctor(IdRefNode next, string id, int lineNo, int linePos) { }
}

// Namespace: System.Xml.Schema
public sealed class XmlSchemaValidator // TypeDefIndex: 3633
{
	// Fields
	private XmlSchemaSet schemaSet; // 0x10
	private XmlSchemaValidationFlags validationFlags; // 0x18
	private int startIDConstraint; // 0x1C
	private bool isRoot; // 0x20
	private bool rootHasSchema; // 0x21
	private bool attrValid; // 0x22
	private bool checkEntity; // 0x23
	private SchemaInfo compiledSchemaInfo; // 0x28
	private IDtdInfo dtdSchemaInfo; // 0x30
	private Hashtable validatedNamespaces; // 0x38
	private HWStack validationStack; // 0x40
	private ValidationState context; // 0x48
	private ValidatorState currentState; // 0x50
	private Hashtable attPresence; // 0x58
	private SchemaAttDef wildID; // 0x60
	private Hashtable IDs; // 0x68
	private IdRefNode idRefListHead; // 0x70
	private XmlQualifiedName contextQName; // 0x78
	private string NsXs; // 0x80
	private string NsXsi; // 0x88
	private string NsXmlNs; // 0x90
	private string NsXml; // 0x98
	private XmlSchemaObject partialValidationType; // 0xA0
	private StringBuilder textValue; // 0xA8
	private ValidationEventHandler eventHandler; // 0xB0
	private object validationEventSender; // 0xB8
	private XmlNameTable nameTable; // 0xC0
	private IXmlLineInfo positionInfo; // 0xC8
	private IXmlLineInfo dummyPositionInfo; // 0xD0
	private XmlResolver xmlResolver; // 0xD8
	private Uri sourceUri; // 0xE0
	private string sourceUriString; // 0xE8
	private IXmlNamespaceResolver nsResolver; // 0xF0
	private XmlSchemaContentProcessing processContents; // 0xF8
	private string xsiTypeString; // 0x100
	private string xsiNilString; // 0x108
	private string xsiSchemaLocationString; // 0x110
	private string xsiNoNamespaceSchemaLocationString; // 0x118
	private static readonly XmlSchemaDatatype dtQName; // 0x0
	private static readonly XmlSchemaDatatype dtCDATA; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private static XmlSchemaParticle[] EmptyParticleArray; // 0x18
	private static XmlSchemaAttribute[] EmptyAttributeArray; // 0x20
	private XmlCharType xmlCharType; // 0x120
	internal static bool[,] ValidStates; // 0x28
	private static string[] MethodNames; // 0x30

	// Properties
	public XmlResolver XmlResolver { set; }
	public IXmlLineInfo LineInfoProvider { set; }
	public Uri SourceUri { set; }
	public object ValidationEventSender { set; }
	internal XmlSchemaSet SchemaSet { get; }
	internal XmlSchemaValidationFlags ValidationFlags { get; }
	internal XmlSchemaContentType CurrentContentType { get; }
	private bool StrictlyAssessed { get; }
	private bool HasSchema { get; }
	private bool HasIdentityConstraints { get; }
	internal bool ProcessIdentityConstraints { get; }
	internal bool ReportValidationWarnings { get; }
	internal bool ProcessSchemaHints { get; }

	// Methods

	// RVA: 0x1BD6950 Offset: 0x1BD2950 VA: 0x1BD6950
	public void .ctor(XmlNameTable nameTable, XmlSchemaSet schemas, IXmlNamespaceResolver namespaceResolver, XmlSchemaValidationFlags validationFlags) { }

	// RVA: 0x1BD6B7C Offset: 0x1BD2B7C VA: 0x1BD6B7C
	private void Init() { }

	// RVA: 0x1BD708C Offset: 0x1BD308C VA: 0x1BD708C
	private void Reset() { }

	// RVA: 0x1BD7208 Offset: 0x1BD3208 VA: 0x1BD7208
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1BD7210 Offset: 0x1BD3210 VA: 0x1BD7210
	public void set_LineInfoProvider(IXmlLineInfo value) { }

	// RVA: 0x1BD7220 Offset: 0x1BD3220 VA: 0x1BD7220
	public void set_SourceUri(Uri value) { }

	// RVA: 0x1BD726C Offset: 0x1BD326C VA: 0x1BD726C
	public void set_ValidationEventSender(object value) { }

	// RVA: 0x1BD7274 Offset: 0x1BD3274 VA: 0x1BD7274
	public void add_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1BD7304 Offset: 0x1BD3304 VA: 0x1BD7304
	public void remove_ValidationEventHandler(ValidationEventHandler value) { }

	// RVA: 0x1BD7394 Offset: 0x1BD3394 VA: 0x1BD7394
	public void AddSchema(XmlSchema schema) { }

	// RVA: 0x1BD7AD0 Offset: 0x1BD3AD0 VA: 0x1BD7AD0
	public void Initialize() { }

	// RVA: 0x1BD7BFC Offset: 0x1BD3BFC VA: 0x1BD7BFC
	public void Initialize(XmlSchemaObject partialValidationType) { }

	// RVA: 0x1BD7E90 Offset: 0x1BD3E90 VA: 0x1BD7E90
	public void ValidateElement(string localName, string namespaceUri, XmlSchemaInfo schemaInfo, string xsiType, string xsiNil, string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x1BD9750 Offset: 0x1BD5750 VA: 0x1BD9750
	public object ValidateAttribute(string localName, string namespaceUri, XmlValueGetter attributeValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1BD97AC Offset: 0x1BD57AC VA: 0x1BD97AC
	private object ValidateAttribute(string lName, string ns, XmlValueGetter attributeValueGetter, string attributeStringValue, XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1BDAB54 Offset: 0x1BD6B54 VA: 0x1BDAB54
	public void ValidateEndOfAttributes(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1BDAE04 Offset: 0x1BD6E04 VA: 0x1BDAE04
	public void ValidateText(XmlValueGetter elementValue) { }

	// RVA: 0x1BDAE60 Offset: 0x1BD6E60 VA: 0x1BDAE60
	private void ValidateText(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x1BDB784 Offset: 0x1BD7784 VA: 0x1BDB784
	public void ValidateWhitespace(XmlValueGetter elementValue) { }

	// RVA: 0x1BDB7E0 Offset: 0x1BD77E0 VA: 0x1BDB7E0
	private void ValidateWhitespace(string elementStringValue, XmlValueGetter elementValueGetter) { }

	// RVA: 0x1BDB9A0 Offset: 0x1BD79A0 VA: 0x1BDB9A0
	public object ValidateEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1BDBE88 Offset: 0x1BD7E88 VA: 0x1BDBE88
	public void SkipToEndElement(XmlSchemaInfo schemaInfo) { }

	// RVA: 0x1BDC1D4 Offset: 0x1BD81D4 VA: 0x1BDC1D4
	public void EndValidation() { }

	// RVA: 0x1BDC3C8 Offset: 0x1BD83C8 VA: 0x1BDC3C8
	internal void GetUnspecifiedDefaultAttributes(ArrayList defaultAttributes, bool createNodeData) { }

	// RVA: 0x1BDCD50 Offset: 0x1BD8D50 VA: 0x1BDCD50
	internal XmlSchemaSet get_SchemaSet() { }

	// RVA: 0x1BDCD58 Offset: 0x1BD8D58 VA: 0x1BDCD58
	internal XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x1BDCD60 Offset: 0x1BD8D60 VA: 0x1BDCD60
	internal XmlSchemaContentType get_CurrentContentType() { }

	// RVA: 0x1BDCD94 Offset: 0x1BD8D94 VA: 0x1BDCD94
	internal void SetDtdSchemaInfo(IDtdInfo dtdSchemaInfo) { }

	// RVA: 0x1BDCDB8 Offset: 0x1BD8DB8 VA: 0x1BDCDB8
	private bool get_StrictlyAssessed() { }

	// RVA: 0x1BDCDF8 Offset: 0x1BD8DF8 VA: 0x1BDCDF8
	private bool get_HasSchema() { }

	// RVA: 0x1BDCE40 Offset: 0x1BD8E40 VA: 0x1BDCE40
	internal string GetConcatenatedValue() { }

	// RVA: 0x1BDB9A8 Offset: 0x1BD79A8 VA: 0x1BDB9A8
	private object InternalValidateEndElement(XmlSchemaInfo schemaInfo, object typedValue) { }

	// RVA: 0x1BD8AB8 Offset: 0x1BD4AB8 VA: 0x1BD8AB8
	private void ProcessSchemaLocations(string xsiSchemaLocation, string xsiNoNamespaceSchemaLocation) { }

	// RVA: 0x1BD8430 Offset: 0x1BD4430 VA: 0x1BD8430
	private object ValidateElementContext(XmlQualifiedName elementName, out bool invalidElementInContext) { }

	// RVA: 0x1BDE944 Offset: 0x1BDA944 VA: 0x1BDE944
	private XmlSchemaElement GetSubstitutionGroupHead(XmlQualifiedName member) { }

	// RVA: 0x1BDCE5C Offset: 0x1BD8E5C VA: 0x1BDCE5C
	private object ValidateAtomicValue(string stringValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0x1BDD0E0 Offset: 0x1BD90E0 VA: 0x1BDD0E0
	private object ValidateAtomicValue(object parsedValue, out XmlSchemaSimpleType memberType) { }

	// RVA: 0x1BDF650 Offset: 0x1BDB650 VA: 0x1BDF650
	private string GetTypeName(SchemaDeclBase decl) { }

	// RVA: 0x1BDB208 Offset: 0x1BD7208 VA: 0x1BDB208
	private void SaveTextValue(object value) { }

	// RVA: 0x1BD6F3C Offset: 0x1BD2F3C VA: 0x1BD6F3C
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1BDC090 Offset: 0x1BD8090 VA: 0x1BDC090
	private void Pop() { }

	// RVA: 0x1BD885C Offset: 0x1BD485C VA: 0x1BD885C
	private SchemaElementDecl FastGetElementDecl(XmlQualifiedName elementName, object particle) { }

	// RVA: 0x1BD8DF8 Offset: 0x1BD4DF8 VA: 0x1BD8DF8
	private SchemaElementDecl CheckXsiTypeAndNil(SchemaElementDecl elementDecl, string xsiType, string xsiNil, ref bool declFound) { }

	// RVA: 0x1BD93D8 Offset: 0x1BD53D8 VA: 0x1BD93D8
	private void ThrowDeclNotFoundWarningOrError(bool declFound) { }

	// RVA: 0x1BD9518 Offset: 0x1BD5518 VA: 0x1BD9518
	private void CheckElementProperties() { }

	// RVA: 0x1BD95CC Offset: 0x1BD55CC VA: 0x1BD95CC
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x1BDA27C Offset: 0x1BD627C VA: 0x1BDA27C
	private SchemaAttDef CheckIsXmlAttribute(XmlQualifiedName attQName) { }

	// RVA: 0x1BDFE8C Offset: 0x1BDBE8C VA: 0x1BDFE8C
	private void AddXmlNamespaceSchema() { }

	// RVA: 0x1BDD3F0 Offset: 0x1BD93F0 VA: 0x1BDD3F0
	internal object CheckMixedValueConstraint(string elementValue) { }

	// RVA: 0x1BDE474 Offset: 0x1BDA474 VA: 0x1BDE474
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x1BD7134 Offset: 0x1BD3134 VA: 0x1BD7134
	internal void RecompileSchemaSet() { }

	// RVA: 0x1BE00E8 Offset: 0x1BDC0E8 VA: 0x1BE00E8
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name, bool attrValue) { }

	// RVA: 0x1BDA4D8 Offset: 0x1BD64D8 VA: 0x1BDA4D8
	private object CheckAttributeValue(object value, SchemaAttDef attdef) { }

	// RVA: 0x1BDF434 Offset: 0x1BDB434 VA: 0x1BDF434
	private object CheckElementValue(string stringValue) { }

	// RVA: 0x1BDA714 Offset: 0x1BD6714 VA: 0x1BDA714
	private void CheckTokenizedTypes(XmlSchemaDatatype dtype, object typedValue, bool attrValue) { }

	// RVA: 0x1BE03B4 Offset: 0x1BDC3B4 VA: 0x1BE03B4
	private object FindId(string name) { }

	// RVA: 0x1BDC2C0 Offset: 0x1BD82C0 VA: 0x1BDC2C0
	private void CheckForwardRefs() { }

	// RVA: 0x1BDA894 Offset: 0x1BD6894 VA: 0x1BDA894
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x1BDF6D0 Offset: 0x1BDB6D0 VA: 0x1BDF6D0
	internal bool get_ProcessIdentityConstraints() { }

	// RVA: 0x1BE0660 Offset: 0x1BDC660 VA: 0x1BE0660
	internal bool get_ReportValidationWarnings() { }

	// RVA: 0x1BD71F8 Offset: 0x1BD31F8 VA: 0x1BD71F8
	internal bool get_ProcessSchemaHints() { }

	// RVA: 0x1BD81F0 Offset: 0x1BD41F0 VA: 0x1BD81F0
	private void CheckStateTransition(ValidatorState toState, string methodName) { }

	// RVA: 0x1BD83E4 Offset: 0x1BD43E4 VA: 0x1BD83E4
	private void ClearPSVI() { }

	// RVA: 0x1BDAC1C Offset: 0x1BD6C1C VA: 0x1BDAC1C
	private void CheckRequiredAttributes(SchemaElementDecl currentElementDecl) { }

	// RVA: 0x1BD9628 Offset: 0x1BD5628 VA: 0x1BD9628
	private XmlSchemaElement GetSchemaElement() { }

	// RVA: 0x1BDC9C8 Offset: 0x1BD89C8 VA: 0x1BDC9C8
	internal string GetDefaultAttributePrefix(string attributeNS) { }

	// RVA: 0x1BDF6DC Offset: 0x1BDB6DC VA: 0x1BDF6DC
	private void AddIdentityConstraints() { }

	// RVA: 0x1BDFADC Offset: 0x1BDBADC VA: 0x1BDFADC
	private void ElementIdentityConstraints() { }

	// RVA: 0x1BDA8B4 Offset: 0x1BD68B4 VA: 0x1BDA8B4
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, XmlSchemaDatatype datatype) { }

	// RVA: 0x1BDD8F8 Offset: 0x1BD98F8 VA: 0x1BDD8F8
	private void EndElementIdentityConstraints(object typedValue, string stringValue, XmlSchemaDatatype datatype) { }

	// RVA: 0x1BDED78 Offset: 0x1BDAD78 VA: 0x1BDED78
	internal static void ElementValidationError(XmlQualifiedName name, ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x1BDD4CC Offset: 0x1BD94CC VA: 0x1BDD4CC
	internal static void CompleteValidationError(ValidationState context, ValidationEventHandler eventHandler, object sender, string sourceUri, int lineNo, int linePos, XmlSchemaSet schemaSet) { }

	// RVA: 0x1BDB398 Offset: 0x1BD7398 VA: 0x1BDB398
	internal static string PrintExpectedElements(ArrayList expected, bool getParticles) { }

	// RVA: 0x1BE0BE0 Offset: 0x1BDCBE0 VA: 0x1BE0BE0
	private static string PrintNames(ArrayList expected) { }

	// RVA: 0x1BE0728 Offset: 0x1BDC728 VA: 0x1BE0728
	private static void PrintNamesWithNS(ArrayList expected, StringBuilder builder) { }

	// RVA: 0x1BE0D5C Offset: 0x1BDCD5C VA: 0x1BE0D5C
	private static void EnumerateAny(StringBuilder builder, string namespaces) { }

	// RVA: 0x1BDB194 Offset: 0x1BD7194 VA: 0x1BDB194
	internal static string QNameString(string localName, string ns) { }

	// RVA: 0x1BDEB18 Offset: 0x1BDAB18 VA: 0x1BDEB18
	internal static string BuildElementName(XmlQualifiedName qname) { }

	// RVA: 0x1BDB248 Offset: 0x1BD7248 VA: 0x1BDB248
	internal static string BuildElementName(string localName, string ns) { }

	// RVA: 0x1BE03D0 Offset: 0x1BDC3D0 VA: 0x1BE03D0
	private void ProcessEntity(string name) { }

	// RVA: 0x1BDF6B8 Offset: 0x1BDB6B8 VA: 0x1BDF6B8
	private void SendValidationEvent(string code) { }

	// RVA: 0x1BDA344 Offset: 0x1BD6344 VA: 0x1BDA344
	private void SendValidationEvent(string code, string[] args) { }

	// RVA: 0x1BDA0FC Offset: 0x1BD60FC VA: 0x1BDA0FC
	private void SendValidationEvent(string code, string arg) { }

	// RVA: 0x1BDEB7C Offset: 0x1BDAB7C VA: 0x1BDEB7C
	private void SendValidationEvent(string code, string arg1, string arg2) { }

	// RVA: 0x1BDFF14 Offset: 0x1BDBF14 VA: 0x1BDFF14
	private void SendValidationEvent(string code, string[] args, Exception innerException, XmlSeverityType severity) { }

	// RVA: 0x1BD7938 Offset: 0x1BD3938 VA: 0x1BD7938
	private void SendValidationEvent(string code, string[] args, Exception innerException) { }

	// RVA: 0x1BE066C Offset: 0x1BDC66C VA: 0x1BE066C
	private void SendValidationEvent(XmlSchemaValidationException e) { }

	// RVA: 0x1BDE898 Offset: 0x1BDA898 VA: 0x1BDE898
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x1BD778C Offset: 0x1BD378C VA: 0x1BD778C
	private void SendValidationEvent(string code, string msg, XmlSeverityType severity) { }

	// RVA: 0x1BE0544 Offset: 0x1BDC544 VA: 0x1BE0544
	private void SendValidationEvent(XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x1BE0674 Offset: 0x1BDC674 VA: 0x1BE0674
	internal static void SendValidationEvent(ValidationEventHandler eventHandler, object sender, XmlSchemaValidationException e, XmlSeverityType severity) { }

	// RVA: 0x1BE0F9C Offset: 0x1BDCF9C VA: 0x1BE0F9C
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
public enum XmlSchemaValidity // TypeDefIndex: 3634
{
	// Fields
	public int value__; // 0x0
	public const XmlSchemaValidity NotKnown = 0;
	public const XmlSchemaValidity Valid = 1;
	public const XmlSchemaValidity Invalid = 2;
}

// Namespace: System.Xml.Schema
public enum XmlSeverityType // TypeDefIndex: 3635
{
	// Fields
	public int value__; // 0x0
	public const XmlSeverityType Error = 0;
	public const XmlSeverityType Warning = 1;
}

// Namespace: System.Xml.Schema
public enum XmlTypeCode // TypeDefIndex: 3636
{
	// Fields
	public int value__; // 0x0
	public const XmlTypeCode None = 0;
	public const XmlTypeCode Item = 1;
	public const XmlTypeCode Node = 2;
	public const XmlTypeCode Document = 3;
	public const XmlTypeCode Element = 4;
	public const XmlTypeCode Attribute = 5;
	public const XmlTypeCode Namespace = 6;
	public const XmlTypeCode ProcessingInstruction = 7;
	public const XmlTypeCode Comment = 8;
	public const XmlTypeCode Text = 9;
	public const XmlTypeCode AnyAtomicType = 10;
	public const XmlTypeCode UntypedAtomic = 11;
	public const XmlTypeCode String = 12;
	public const XmlTypeCode Boolean = 13;
	public const XmlTypeCode Decimal = 14;
	public const XmlTypeCode Float = 15;
	public const XmlTypeCode Double = 16;
	public const XmlTypeCode Duration = 17;
	public const XmlTypeCode DateTime = 18;
	public const XmlTypeCode Time = 19;
	public const XmlTypeCode Date = 20;
	public const XmlTypeCode GYearMonth = 21;
	public const XmlTypeCode GYear = 22;
	public const XmlTypeCode GMonthDay = 23;
	public const XmlTypeCode GDay = 24;
	public const XmlTypeCode GMonth = 25;
	public const XmlTypeCode HexBinary = 26;
	public const XmlTypeCode Base64Binary = 27;
	public const XmlTypeCode AnyUri = 28;
	public const XmlTypeCode QName = 29;
	public const XmlTypeCode Notation = 30;
	public const XmlTypeCode NormalizedString = 31;
	public const XmlTypeCode Token = 32;
	public const XmlTypeCode Language = 33;
	public const XmlTypeCode NmToken = 34;
	public const XmlTypeCode Name = 35;
	public const XmlTypeCode NCName = 36;
	public const XmlTypeCode Id = 37;
	public const XmlTypeCode Idref = 38;
	public const XmlTypeCode Entity = 39;
	public const XmlTypeCode Integer = 40;
	public const XmlTypeCode NonPositiveInteger = 41;
	public const XmlTypeCode NegativeInteger = 42;
	public const XmlTypeCode Long = 43;
	public const XmlTypeCode Int = 44;
	public const XmlTypeCode Short = 45;
	public const XmlTypeCode Byte = 46;
	public const XmlTypeCode NonNegativeInteger = 47;
	public const XmlTypeCode UnsignedLong = 48;
	public const XmlTypeCode UnsignedInt = 49;
	public const XmlTypeCode UnsignedShort = 50;
	public const XmlTypeCode UnsignedByte = 51;
	public const XmlTypeCode PositiveInteger = 52;
	public const XmlTypeCode YearMonthDuration = 53;
	public const XmlTypeCode DayTimeDuration = 54;
}

// Namespace: System.Xml.Schema
internal abstract class XmlValueConverter // TypeDefIndex: 3637
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool ToBoolean(long value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool ToBoolean(int value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool ToBoolean(double value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ToBoolean(DateTime value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool ToBoolean(string value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool ToBoolean(object value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int ToInt32(bool value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int ToInt32(long value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int ToInt32(double value);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int ToInt32(DateTime value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int ToInt32(string value);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int ToInt32(object value);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract long ToInt64(bool value);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract long ToInt64(int value);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract long ToInt64(double value);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract long ToInt64(DateTime value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract long ToInt64(string value);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract long ToInt64(object value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract Decimal ToDecimal(string value);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract Decimal ToDecimal(object value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract double ToDouble(bool value);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract double ToDouble(int value);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract double ToDouble(long value);

	// RVA: -1 Offset: -1 Slot: 27
	public abstract double ToDouble(DateTime value);

	// RVA: -1 Offset: -1 Slot: 28
	public abstract double ToDouble(string value);

	// RVA: -1 Offset: -1 Slot: 29
	public abstract double ToDouble(object value);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract float ToSingle(double value);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract float ToSingle(string value);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract float ToSingle(object value);

	// RVA: -1 Offset: -1 Slot: 33
	public abstract DateTime ToDateTime(bool value);

	// RVA: -1 Offset: -1 Slot: 34
	public abstract DateTime ToDateTime(int value);

	// RVA: -1 Offset: -1 Slot: 35
	public abstract DateTime ToDateTime(long value);

	// RVA: -1 Offset: -1 Slot: 36
	public abstract DateTime ToDateTime(double value);

	// RVA: -1 Offset: -1 Slot: 37
	public abstract DateTime ToDateTime(DateTimeOffset value);

	// RVA: -1 Offset: -1 Slot: 38
	public abstract DateTime ToDateTime(string value);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract DateTime ToDateTime(object value);

	// RVA: -1 Offset: -1 Slot: 40
	public abstract DateTimeOffset ToDateTimeOffset(DateTime value);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract DateTimeOffset ToDateTimeOffset(string value);

	// RVA: -1 Offset: -1 Slot: 42
	public abstract DateTimeOffset ToDateTimeOffset(object value);

	// RVA: -1 Offset: -1 Slot: 43
	public abstract string ToString(bool value);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract string ToString(int value);

	// RVA: -1 Offset: -1 Slot: 45
	public abstract string ToString(long value);

	// RVA: -1 Offset: -1 Slot: 46
	public abstract string ToString(Decimal value);

	// RVA: -1 Offset: -1 Slot: 47
	public abstract string ToString(float value);

	// RVA: -1 Offset: -1 Slot: 48
	public abstract string ToString(double value);

	// RVA: -1 Offset: -1 Slot: 49
	public abstract string ToString(DateTime value);

	// RVA: -1 Offset: -1 Slot: 50
	public abstract string ToString(DateTimeOffset value);

	// RVA: -1 Offset: -1 Slot: 51
	public abstract string ToString(object value);

	// RVA: -1 Offset: -1 Slot: 52
	public abstract string ToString(object value, IXmlNamespaceResolver nsResolver);

	// RVA: -1 Offset: -1 Slot: 53
	public abstract object ChangeType(bool value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 54
	public abstract object ChangeType(int value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 55
	public abstract object ChangeType(long value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 56
	public abstract object ChangeType(Decimal value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 57
	public abstract object ChangeType(double value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 58
	public abstract object ChangeType(DateTime value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 59
	public abstract object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver);

	// RVA: -1 Offset: -1 Slot: 60
	public abstract object ChangeType(object value, Type destinationType);

	// RVA: -1 Offset: -1 Slot: 61
	public abstract object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver);

	// RVA: 0x1BE13FC Offset: 0x1BDD3FC VA: 0x1BE13FC
	protected void .ctor() { }
}

// Namespace: System.Xml.Schema
internal abstract class XmlBaseConverter : XmlValueConverter // TypeDefIndex: 3638
{
	// Fields
	private XmlSchemaType schemaType; // 0x10
	private XmlTypeCode typeCode; // 0x18
	private Type clrTypeDefault; // 0x20
	protected static readonly Type ICollectionType; // 0x0
	protected static readonly Type IEnumerableType; // 0x8
	protected static readonly Type IListType; // 0x10
	protected static readonly Type ObjectArrayType; // 0x18
	protected static readonly Type StringArrayType; // 0x20
	protected static readonly Type XmlAtomicValueArrayType; // 0x28
	protected static readonly Type DecimalType; // 0x30
	protected static readonly Type Int32Type; // 0x38
	protected static readonly Type Int64Type; // 0x40
	protected static readonly Type StringType; // 0x48
	protected static readonly Type XmlAtomicValueType; // 0x50
	protected static readonly Type ObjectType; // 0x58
	protected static readonly Type ByteType; // 0x60
	protected static readonly Type Int16Type; // 0x68
	protected static readonly Type SByteType; // 0x70
	protected static readonly Type UInt16Type; // 0x78
	protected static readonly Type UInt32Type; // 0x80
	protected static readonly Type UInt64Type; // 0x88
	protected static readonly Type XPathItemType; // 0x90
	protected static readonly Type DoubleType; // 0x98
	protected static readonly Type SingleType; // 0xA0
	protected static readonly Type DateTimeType; // 0xA8
	protected static readonly Type DateTimeOffsetType; // 0xB0
	protected static readonly Type BooleanType; // 0xB8
	protected static readonly Type ByteArrayType; // 0xC0
	protected static readonly Type XmlQualifiedNameType; // 0xC8
	protected static readonly Type UriType; // 0xD0
	protected static readonly Type TimeSpanType; // 0xD8
	protected static readonly Type XPathNavigatorType; // 0xE0

	// Properties
	protected XmlSchemaType SchemaType { get; }
	protected XmlTypeCode TypeCode { get; }
	protected string XmlTypeName { get; }
	protected Type DefaultClrType { get; }

	// Methods

	// RVA: 0x1BE1404 Offset: 0x1BDD404 VA: 0x1BE1404
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1BE1504 Offset: 0x1BDD504 VA: 0x1BE1504
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x1BE15E8 Offset: 0x1BDD5E8 VA: 0x1BE15E8
	protected void .ctor(XmlBaseConverter converterAtomic) { }

	// RVA: 0x1BE1658 Offset: 0x1BDD658 VA: 0x1BE1658
	protected void .ctor(XmlBaseConverter converterAtomic, Type clrTypeDefault) { }

	// RVA: 0x1BE16AC Offset: 0x1BDD6AC VA: 0x1BE16AC Slot: 7
	public override bool ToBoolean(DateTime value) { }

	// RVA: 0x1BE1798 Offset: 0x1BDD798 VA: 0x1BE1798 Slot: 6
	public override bool ToBoolean(double value) { }

	// RVA: 0x1BE1878 Offset: 0x1BDD878 VA: 0x1BE1878 Slot: 5
	public override bool ToBoolean(int value) { }

	// RVA: 0x1BE1948 Offset: 0x1BDD948 VA: 0x1BE1948 Slot: 4
	public override bool ToBoolean(long value) { }

	// RVA: 0x1BE1A18 Offset: 0x1BDDA18 VA: 0x1BE1A18 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x1BE1AD0 Offset: 0x1BDDAD0 VA: 0x1BE1AD0 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1BE1B88 Offset: 0x1BDDB88 VA: 0x1BE1B88 Slot: 33
	public override DateTime ToDateTime(bool value) { }

	// RVA: 0x1BE1C70 Offset: 0x1BDDC70 VA: 0x1BE1C70 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x1BE1D74 Offset: 0x1BDDD74 VA: 0x1BE1D74 Slot: 36
	public override DateTime ToDateTime(double value) { }

	// RVA: 0x1BE1E58 Offset: 0x1BDDE58 VA: 0x1BE1E58 Slot: 34
	public override DateTime ToDateTime(int value) { }

	// RVA: 0x1BE1F3C Offset: 0x1BDDF3C VA: 0x1BE1F3C Slot: 35
	public override DateTime ToDateTime(long value) { }

	// RVA: 0x1BE2020 Offset: 0x1BDE020 VA: 0x1BE2020 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1BE20E4 Offset: 0x1BDE0E4 VA: 0x1BE20E4 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1BE21A8 Offset: 0x1BDE1A8 VA: 0x1BE21A8 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x1BE22A4 Offset: 0x1BDE2A4 VA: 0x1BE22A4 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1BE236C Offset: 0x1BDE36C VA: 0x1BE236C Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1BE2434 Offset: 0x1BDE434 VA: 0x1BE2434 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1BE24FC Offset: 0x1BDE4FC VA: 0x1BE24FC Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1BE25C4 Offset: 0x1BDE5C4 VA: 0x1BE25C4 Slot: 24
	public override double ToDouble(bool value) { }

	// RVA: 0x1BE2698 Offset: 0x1BDE698 VA: 0x1BE2698 Slot: 27
	public override double ToDouble(DateTime value) { }

	// RVA: 0x1BE2784 Offset: 0x1BDE784 VA: 0x1BE2784 Slot: 25
	public override double ToDouble(int value) { }

	// RVA: 0x1BE2854 Offset: 0x1BDE854 VA: 0x1BE2854 Slot: 26
	public override double ToDouble(long value) { }

	// RVA: 0x1BE2924 Offset: 0x1BDE924 VA: 0x1BE2924 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1BE29DC Offset: 0x1BDE9DC VA: 0x1BE29DC Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1BE2A94 Offset: 0x1BDEA94 VA: 0x1BE2A94 Slot: 10
	public override int ToInt32(bool value) { }

	// RVA: 0x1BE2B68 Offset: 0x1BDEB68 VA: 0x1BE2B68 Slot: 13
	public override int ToInt32(DateTime value) { }

	// RVA: 0x1BE2C54 Offset: 0x1BDEC54 VA: 0x1BE2C54 Slot: 12
	public override int ToInt32(double value) { }

	// RVA: 0x1BE2D34 Offset: 0x1BDED34 VA: 0x1BE2D34 Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x1BE2E04 Offset: 0x1BDEE04 VA: 0x1BE2E04 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1BE2EBC Offset: 0x1BDEEBC VA: 0x1BE2EBC Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1BE2F74 Offset: 0x1BDEF74 VA: 0x1BE2F74 Slot: 16
	public override long ToInt64(bool value) { }

	// RVA: 0x1BE3048 Offset: 0x1BDF048 VA: 0x1BE3048 Slot: 19
	public override long ToInt64(DateTime value) { }

	// RVA: 0x1BE3134 Offset: 0x1BDF134 VA: 0x1BE3134 Slot: 18
	public override long ToInt64(double value) { }

	// RVA: 0x1BE3214 Offset: 0x1BDF214 VA: 0x1BE3214 Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x1BE32E4 Offset: 0x1BDF2E4 VA: 0x1BE32E4 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x1BE339C Offset: 0x1BDF39C VA: 0x1BE339C Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1BE3454 Offset: 0x1BDF454 VA: 0x1BE3454 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x1BE3534 Offset: 0x1BDF534 VA: 0x1BE3534 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1BE35EC Offset: 0x1BDF5EC VA: 0x1BE35EC Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1BE36A4 Offset: 0x1BDF6A4 VA: 0x1BE36A4 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x1BE3764 Offset: 0x1BDF764 VA: 0x1BE3764 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x1BE383C Offset: 0x1BDF83C VA: 0x1BE383C Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1BE3920 Offset: 0x1BDF920 VA: 0x1BE3920 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x1BE3A34 Offset: 0x1BDFA34 VA: 0x1BE3A34 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x1BE3B00 Offset: 0x1BDFB00 VA: 0x1BE3B00 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1BE3BBC Offset: 0x1BDFBBC VA: 0x1BE3BBC Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x1BE3C78 Offset: 0x1BDFC78 VA: 0x1BE3C78 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x1BE3D44 Offset: 0x1BDFD44 VA: 0x1BE3D44 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BE3DEC Offset: 0x1BDFDEC VA: 0x1BE3DEC Slot: 51
	public override string ToString(object value) { }

	// RVA: 0x1BE3E00 Offset: 0x1BDFE00 VA: 0x1BE3E00 Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1BE3E54 Offset: 0x1BDFE54 VA: 0x1BE3E54 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1BE3EDC Offset: 0x1BDFEDC VA: 0x1BE3EDC Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1BE3F90 Offset: 0x1BDFF90 VA: 0x1BE3F90 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1BE3FE4 Offset: 0x1BDFFE4 VA: 0x1BE3FE4 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1BE4038 Offset: 0x1BE0038 VA: 0x1BE4038 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1BE408C Offset: 0x1BE008C VA: 0x1BE408C Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BE409C Offset: 0x1BE009C VA: 0x1BE409C Slot: 60
	public override object ChangeType(object value, Type destinationType) { }

	// RVA: 0x1BE40B0 Offset: 0x1BE00B0 VA: 0x1BE40B0
	protected XmlSchemaType get_SchemaType() { }

	// RVA: 0x1BE40B8 Offset: 0x1BE00B8 VA: 0x1BE40B8
	protected XmlTypeCode get_TypeCode() { }

	// RVA: 0x1BE40C0 Offset: 0x1BE00C0 VA: 0x1BE40C0
	protected string get_XmlTypeName() { }

	// RVA: 0x1BE42D0 Offset: 0x1BE02D0 VA: 0x1BE42D0
	protected Type get_DefaultClrType() { }

	// RVA: 0x1BE42D8 Offset: 0x1BE02D8 VA: 0x1BE42D8
	protected static bool IsDerivedFrom(Type derivedType, Type baseType) { }

	// RVA: 0x1BE4374 Offset: 0x1BE0374 VA: 0x1BE4374
	protected Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }

	// RVA: 0x1BE41B4 Offset: 0x1BE01B4 VA: 0x1BE41B4
	protected static string QNameToString(XmlQualifiedName name) { }

	// RVA: 0x1BE4600 Offset: 0x1BE0600 VA: 0x1BE4600 Slot: 62
	protected virtual object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BE4654 Offset: 0x1BE0654 VA: 0x1BE4654
	protected static byte[] StringToBase64Binary(string value) { }

	// RVA: 0x1BE46E4 Offset: 0x1BE06E4 VA: 0x1BE46E4
	protected static DateTime StringToDate(string value) { }

	// RVA: 0x1BE4760 Offset: 0x1BE0760 VA: 0x1BE4760
	protected static DateTime StringToDateTime(string value) { }

	// RVA: 0x1BE47DC Offset: 0x1BE07DC VA: 0x1BE47DC
	protected static TimeSpan StringToDayTimeDuration(string value) { }

	// RVA: 0x1BE483C Offset: 0x1BE083C VA: 0x1BE483C
	protected static TimeSpan StringToDuration(string value) { }

	// RVA: 0x1BE489C Offset: 0x1BE089C VA: 0x1BE489C
	protected static DateTime StringToGDay(string value) { }

	// RVA: 0x1BE4918 Offset: 0x1BE0918 VA: 0x1BE4918
	protected static DateTime StringToGMonth(string value) { }

	// RVA: 0x1BE4994 Offset: 0x1BE0994 VA: 0x1BE4994
	protected static DateTime StringToGMonthDay(string value) { }

	// RVA: 0x1BE4A10 Offset: 0x1BE0A10 VA: 0x1BE4A10
	protected static DateTime StringToGYear(string value) { }

	// RVA: 0x1BE4A8C Offset: 0x1BE0A8C VA: 0x1BE4A8C
	protected static DateTime StringToGYearMonth(string value) { }

	// RVA: 0x1BE4B08 Offset: 0x1BE0B08 VA: 0x1BE4B08
	protected static DateTimeOffset StringToDateOffset(string value) { }

	// RVA: 0x1BE4B84 Offset: 0x1BE0B84 VA: 0x1BE4B84
	protected static DateTimeOffset StringToDateTimeOffset(string value) { }

	// RVA: 0x1BE4C00 Offset: 0x1BE0C00 VA: 0x1BE4C00
	protected static DateTimeOffset StringToGDayOffset(string value) { }

	// RVA: 0x1BE4C7C Offset: 0x1BE0C7C VA: 0x1BE4C7C
	protected static DateTimeOffset StringToGMonthOffset(string value) { }

	// RVA: 0x1BE4CF8 Offset: 0x1BE0CF8 VA: 0x1BE4CF8
	protected static DateTimeOffset StringToGMonthDayOffset(string value) { }

	// RVA: 0x1BE4D74 Offset: 0x1BE0D74 VA: 0x1BE4D74
	protected static DateTimeOffset StringToGYearOffset(string value) { }

	// RVA: 0x1BE4DF0 Offset: 0x1BE0DF0 VA: 0x1BE4DF0
	protected static DateTimeOffset StringToGYearMonthOffset(string value) { }

	// RVA: 0x1BE4E6C Offset: 0x1BE0E6C VA: 0x1BE4E6C
	protected static byte[] StringToHexBinary(string value) { }

	// RVA: 0x1BE4FA0 Offset: 0x1BE0FA0 VA: 0x1BE4FA0
	protected static XmlQualifiedName StringToQName(string value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BE5264 Offset: 0x1BE1264 VA: 0x1BE5264
	protected static DateTime StringToTime(string value) { }

	// RVA: 0x1BE52E0 Offset: 0x1BE12E0 VA: 0x1BE52E0
	protected static DateTimeOffset StringToTimeOffset(string value) { }

	// RVA: 0x1BE535C Offset: 0x1BE135C VA: 0x1BE535C
	protected static TimeSpan StringToYearMonthDuration(string value) { }

	// RVA: 0x1BE53BC Offset: 0x1BE13BC VA: 0x1BE53BC
	protected static string AnyUriToString(Uri value) { }

	// RVA: 0x1BE53D0 Offset: 0x1BE13D0 VA: 0x1BE53D0
	protected static string Base64BinaryToString(byte[] value) { }

	// RVA: 0x1BE5428 Offset: 0x1BE1428 VA: 0x1BE5428
	protected static string DateToString(DateTime value) { }

	// RVA: 0x1BE54B0 Offset: 0x1BE14B0 VA: 0x1BE54B0
	protected static string DateTimeToString(DateTime value) { }

	// RVA: 0x1BE5538 Offset: 0x1BE1538 VA: 0x1BE5538
	protected static string DayTimeDurationToString(TimeSpan value) { }

	// RVA: 0x1BE5598 Offset: 0x1BE1598 VA: 0x1BE5598
	protected static string DurationToString(TimeSpan value) { }

	// RVA: 0x1BE55F8 Offset: 0x1BE15F8 VA: 0x1BE55F8
	protected static string GDayToString(DateTime value) { }

	// RVA: 0x1BE5680 Offset: 0x1BE1680 VA: 0x1BE5680
	protected static string GMonthToString(DateTime value) { }

	// RVA: 0x1BE5708 Offset: 0x1BE1708 VA: 0x1BE5708
	protected static string GMonthDayToString(DateTime value) { }

	// RVA: 0x1BE5790 Offset: 0x1BE1790 VA: 0x1BE5790
	protected static string GYearToString(DateTime value) { }

	// RVA: 0x1BE5818 Offset: 0x1BE1818 VA: 0x1BE5818
	protected static string GYearMonthToString(DateTime value) { }

	// RVA: 0x1BE58A0 Offset: 0x1BE18A0 VA: 0x1BE58A0
	protected static string DateOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1BE5938 Offset: 0x1BE1938 VA: 0x1BE5938
	protected static string DateTimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1BE59D0 Offset: 0x1BE19D0 VA: 0x1BE59D0
	protected static string GDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1BE5A68 Offset: 0x1BE1A68 VA: 0x1BE5A68
	protected static string GMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1BE5B00 Offset: 0x1BE1B00 VA: 0x1BE5B00
	protected static string GMonthDayOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1BE5B98 Offset: 0x1BE1B98 VA: 0x1BE5B98
	protected static string GYearOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1BE5C30 Offset: 0x1BE1C30 VA: 0x1BE5C30
	protected static string GYearMonthOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1BE5CC8 Offset: 0x1BE1CC8 VA: 0x1BE5CC8
	protected static string QNameToString(XmlQualifiedName qname, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BE5ED4 Offset: 0x1BE1ED4 VA: 0x1BE5ED4
	protected static string TimeToString(DateTime value) { }

	// RVA: 0x1BE5F5C Offset: 0x1BE1F5C VA: 0x1BE5F5C
	protected static string TimeOffsetToString(DateTimeOffset value) { }

	// RVA: 0x1BE5FF4 Offset: 0x1BE1FF4 VA: 0x1BE5FF4
	protected static string YearMonthDurationToString(TimeSpan value) { }

	// RVA: 0x1BE6054 Offset: 0x1BE2054 VA: 0x1BE6054
	internal static DateTime DateTimeOffsetToDateTime(DateTimeOffset value) { }

	// RVA: 0x1BE60B8 Offset: 0x1BE20B8 VA: 0x1BE60B8
	internal static int DecimalToInt32(Decimal value) { }

	// RVA: 0x1BE629C Offset: 0x1BE229C VA: 0x1BE629C
	protected static long DecimalToInt64(Decimal value) { }

	// RVA: 0x1BE6480 Offset: 0x1BE2480 VA: 0x1BE6480
	protected static ulong DecimalToUInt64(Decimal value) { }

	// RVA: 0x1BE6658 Offset: 0x1BE2658 VA: 0x1BE6658
	protected static byte Int32ToByte(int value) { }

	// RVA: 0x1BE6734 Offset: 0x1BE2734 VA: 0x1BE6734
	protected static short Int32ToInt16(int value) { }

	// RVA: 0x1BE6810 Offset: 0x1BE2810 VA: 0x1BE6810
	protected static sbyte Int32ToSByte(int value) { }

	// RVA: 0x1BE68EC Offset: 0x1BE28EC VA: 0x1BE68EC
	protected static ushort Int32ToUInt16(int value) { }

	// RVA: 0x1BE69C8 Offset: 0x1BE29C8 VA: 0x1BE69C8
	protected static int Int64ToInt32(long value) { }

	// RVA: 0x1BE6AA4 Offset: 0x1BE2AA4 VA: 0x1BE6AA4
	protected static uint Int64ToUInt32(long value) { }

	// RVA: 0x1BE6B80 Offset: 0x1BE2B80 VA: 0x1BE6B80
	protected static DateTime UntypedAtomicToDateTime(string value) { }

	// RVA: 0x1BE6BFC Offset: 0x1BE2BFC VA: 0x1BE6BFC
	protected static DateTimeOffset UntypedAtomicToDateTimeOffset(string value) { }

	// RVA: 0x1BE6C78 Offset: 0x1BE2C78 VA: 0x1BE6C78
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlNumeric10Converter : XmlBaseConverter // TypeDefIndex: 3639
{
	// Methods

	// RVA: 0x1BE7278 Offset: 0x1BE3278 VA: 0x1BE7278
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1BE72E0 Offset: 0x1BE32E0 VA: 0x1BE72E0
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1BE7338 Offset: 0x1BE3338 VA: 0x1BE7338 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1BE7408 Offset: 0x1BE3408 VA: 0x1BE7408 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1BE7B8C Offset: 0x1BE3B8C VA: 0x1BE7B8C Slot: 11
	public override int ToInt32(long value) { }

	// RVA: 0x1BE7BE4 Offset: 0x1BE3BE4 VA: 0x1BE7BE4 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1BE7CF0 Offset: 0x1BE3CF0 VA: 0x1BE7CF0 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1BE809C Offset: 0x1BE409C VA: 0x1BE809C Slot: 17
	public override long ToInt64(int value) { }

	// RVA: 0x1BE80A4 Offset: 0x1BE40A4 VA: 0x1BE80A4 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x1BE81B0 Offset: 0x1BE41B0 VA: 0x1BE81B0 Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1BE853C Offset: 0x1BE453C VA: 0x1BE853C Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x1BE85F8 Offset: 0x1BE45F8 VA: 0x1BE85F8 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1BE8650 Offset: 0x1BE4650 VA: 0x1BE8650 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x1BE86A8 Offset: 0x1BE46A8 VA: 0x1BE86A8 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BE8A5C Offset: 0x1BE4A5C VA: 0x1BE8A5C Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1BE9284 Offset: 0x1BE5284 VA: 0x1BE9284 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1BE9688 Offset: 0x1BE5688 VA: 0x1BE9688 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1BE9AA0 Offset: 0x1BE5AA0 VA: 0x1BE9AA0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BE9EBC Offset: 0x1BE5EBC VA: 0x1BE9EBC Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BE77C4 Offset: 0x1BE37C4 VA: 0x1BE77C4
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BE8E9C Offset: 0x1BE4E9C VA: 0x1BE8E9C
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlNumeric2Converter : XmlBaseConverter // TypeDefIndex: 3640
{
	// Methods

	// RVA: 0x1BEACD0 Offset: 0x1BE6CD0 VA: 0x1BEACD0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1BEAD38 Offset: 0x1BE6D38 VA: 0x1BEAD38
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1BEAD90 Offset: 0x1BE6D90 VA: 0x1BEAD90 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1BEAE68 Offset: 0x1BE6E68 VA: 0x1BEAE68 Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1BEB160 Offset: 0x1BE7160 VA: 0x1BEB160 Slot: 30
	public override float ToSingle(double value) { }

	// RVA: 0x1BEB168 Offset: 0x1BE7168 VA: 0x1BEB168 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1BEB240 Offset: 0x1BE7240 VA: 0x1BEB240 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1BEB548 Offset: 0x1BE7548 VA: 0x1BEB548 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x1BEB5FC Offset: 0x1BE75FC VA: 0x1BEB5FC Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x1BEB68C Offset: 0x1BE768C VA: 0x1BEB68C Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BEB988 Offset: 0x1BE7988 VA: 0x1BEB988 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1BEBCAC Offset: 0x1BE7CAC VA: 0x1BEBCAC Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BEC00C Offset: 0x1BE800C VA: 0x1BEC00C Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlDateTimeConverter : XmlBaseConverter // TypeDefIndex: 3641
{
	// Methods

	// RVA: 0x1BEC6B0 Offset: 0x1BE86B0 VA: 0x1BEC6B0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1BEC718 Offset: 0x1BE8718 VA: 0x1BEC718
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1BEC770 Offset: 0x1BE8770 VA: 0x1BEC770 Slot: 37
	public override DateTime ToDateTime(DateTimeOffset value) { }

	// RVA: 0x1BEC7D8 Offset: 0x1BE87D8 VA: 0x1BEC7D8 Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1BEC990 Offset: 0x1BE8990 VA: 0x1BEC990 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1BECCD4 Offset: 0x1BE8CD4 VA: 0x1BECCD4 Slot: 40
	public override DateTimeOffset ToDateTimeOffset(DateTime value) { }

	// RVA: 0x1BECCFC Offset: 0x1BE8CFC VA: 0x1BECCFC Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1BECEB4 Offset: 0x1BE8EB4 VA: 0x1BECEB4 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1BED200 Offset: 0x1BE9200 VA: 0x1BED200 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x1BED390 Offset: 0x1BE9390 VA: 0x1BED390 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1BED544 Offset: 0x1BE9544 VA: 0x1BED544 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BED868 Offset: 0x1BE9868 VA: 0x1BED868 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1BEDBE4 Offset: 0x1BE9BE4 VA: 0x1BEDBE4 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BEDF68 Offset: 0x1BE9F68 VA: 0x1BEDF68 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlBooleanConverter : XmlBaseConverter // TypeDefIndex: 3642
{
	// Methods

	// RVA: 0x1BEE670 Offset: 0x1BEA670 VA: 0x1BEE670
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1BEE6D8 Offset: 0x1BEA6D8 VA: 0x1BEE6D8
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1BEE730 Offset: 0x1BEA730 VA: 0x1BEE730 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x1BEE7D4 Offset: 0x1BEA7D4 VA: 0x1BEE7D4 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1BEEA7C Offset: 0x1BEAA7C VA: 0x1BEEA7C Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x1BEEAD4 Offset: 0x1BEAAD4 VA: 0x1BEEAD4 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BEED5C Offset: 0x1BEAD5C VA: 0x1BEED5C Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1BEF054 Offset: 0x1BEB054 VA: 0x1BEF054 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BEF368 Offset: 0x1BEB368 VA: 0x1BEF368 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlMiscConverter : XmlBaseConverter // TypeDefIndex: 3643
{
	// Methods

	// RVA: 0x1BEF8B8 Offset: 0x1BEB8B8 VA: 0x1BEF8B8
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1BEF920 Offset: 0x1BEB920 VA: 0x1BEF920
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1BEF978 Offset: 0x1BEB978 VA: 0x1BEF978 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BEFFC4 Offset: 0x1BEBFC4 VA: 0x1BEFFC4 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BF0614 Offset: 0x1BEC614 VA: 0x1BF0614 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BEFE94 Offset: 0x1BEBE94 VA: 0x1BEFE94
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BF04BC Offset: 0x1BEC4BC VA: 0x1BF04BC
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlStringConverter : XmlBaseConverter // TypeDefIndex: 3644
{
	// Methods

	// RVA: 0x1BF12E0 Offset: 0x1BED2E0 VA: 0x1BF12E0
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1BF1348 Offset: 0x1BED348 VA: 0x1BF1348
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1BF13A0 Offset: 0x1BED3A0 VA: 0x1BF13A0 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BF1584 Offset: 0x1BED584 VA: 0x1BF1584 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BF17F8 Offset: 0x1BED7F8 VA: 0x1BF17F8 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: System.Xml.Schema
internal class XmlUntypedConverter : XmlListConverter // TypeDefIndex: 3645
{
	// Fields
	private bool allowListToList; // 0x30
	public static readonly XmlValueConverter Untyped; // 0x0
	public static readonly XmlValueConverter UntypedList; // 0x8

	// Methods

	// RVA: 0x1BF1BFC Offset: 0x1BEDBFC VA: 0x1BF1BFC
	protected void .ctor() { }

	// RVA: 0x1BF1CF4 Offset: 0x1BEDCF4 VA: 0x1BF1CF4
	protected void .ctor(XmlUntypedConverter atomicConverter, bool allowListToList) { }

	// RVA: 0x1BF1E14 Offset: 0x1BEDE14 VA: 0x1BF1E14 Slot: 8
	public override bool ToBoolean(string value) { }

	// RVA: 0x1BF1EB8 Offset: 0x1BEDEB8 VA: 0x1BF1EB8 Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1BF218C Offset: 0x1BEE18C VA: 0x1BF218C Slot: 38
	public override DateTime ToDateTime(string value) { }

	// RVA: 0x1BF2230 Offset: 0x1BEE230 VA: 0x1BF2230 Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1BF23D0 Offset: 0x1BEE3D0 VA: 0x1BF23D0 Slot: 41
	public override DateTimeOffset ToDateTimeOffset(string value) { }

	// RVA: 0x1BF2474 Offset: 0x1BEE474 VA: 0x1BF2474 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1BF2610 Offset: 0x1BEE610 VA: 0x1BF2610 Slot: 22
	public override Decimal ToDecimal(string value) { }

	// RVA: 0x1BF26B4 Offset: 0x1BEE6B4 VA: 0x1BF26B4 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1BF2868 Offset: 0x1BEE868 VA: 0x1BF2868 Slot: 28
	public override double ToDouble(string value) { }

	// RVA: 0x1BF290C Offset: 0x1BEE90C VA: 0x1BF290C Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1BF2AB0 Offset: 0x1BEEAB0 VA: 0x1BF2AB0 Slot: 14
	public override int ToInt32(string value) { }

	// RVA: 0x1BF2B54 Offset: 0x1BEEB54 VA: 0x1BF2B54 Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1BF2CF8 Offset: 0x1BEECF8 VA: 0x1BF2CF8 Slot: 20
	public override long ToInt64(string value) { }

	// RVA: 0x1BF2D9C Offset: 0x1BEED9C VA: 0x1BF2D9C Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1BF2F40 Offset: 0x1BEEF40 VA: 0x1BF2F40 Slot: 31
	public override float ToSingle(string value) { }

	// RVA: 0x1BF2FE4 Offset: 0x1BEEFE4 VA: 0x1BF2FE4 Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1BF3188 Offset: 0x1BEF188 VA: 0x1BF3188 Slot: 43
	public override string ToString(bool value) { }

	// RVA: 0x1BF31E0 Offset: 0x1BEF1E0 VA: 0x1BF31E0 Slot: 49
	public override string ToString(DateTime value) { }

	// RVA: 0x1BF3238 Offset: 0x1BEF238 VA: 0x1BF3238 Slot: 50
	public override string ToString(DateTimeOffset value) { }

	// RVA: 0x1BF32A0 Offset: 0x1BEF2A0 VA: 0x1BF32A0 Slot: 46
	public override string ToString(Decimal value) { }

	// RVA: 0x1BF3308 Offset: 0x1BEF308 VA: 0x1BF3308 Slot: 48
	public override string ToString(double value) { }

	// RVA: 0x1BF3368 Offset: 0x1BEF368 VA: 0x1BF3368 Slot: 44
	public override string ToString(int value) { }

	// RVA: 0x1BF33C0 Offset: 0x1BEF3C0 VA: 0x1BF33C0 Slot: 45
	public override string ToString(long value) { }

	// RVA: 0x1BF3418 Offset: 0x1BEF418 VA: 0x1BF3418 Slot: 47
	public override string ToString(float value) { }

	// RVA: 0x1BF3478 Offset: 0x1BEF478 VA: 0x1BF3478 Slot: 52
	public override string ToString(object value, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BF403C Offset: 0x1BF003C VA: 0x1BF403C Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1BF4380 Offset: 0x1BF0380 VA: 0x1BF4380 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1BF453C Offset: 0x1BF053C VA: 0x1BF453C Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1BF476C Offset: 0x1BF076C VA: 0x1BF476C Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1BF4928 Offset: 0x1BF0928 VA: 0x1BF4928 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1BF4AE4 Offset: 0x1BF0AE4 VA: 0x1BF4AE4 Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1BF4CA0 Offset: 0x1BF0CA0 VA: 0x1BF4CA0 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BF58D0 Offset: 0x1BF18D0 VA: 0x1BF58D0 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BF205C Offset: 0x1BEE05C VA: 0x1BF205C
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BF41FC Offset: 0x1BF01FC VA: 0x1BF41FC
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BF6E04 Offset: 0x1BF2E04 VA: 0x1BF6E04 Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BF70E8 Offset: 0x1BF30E8 VA: 0x1BF70E8
	private bool SupportsType(Type clrType) { }

	// RVA: 0x1BF83CC Offset: 0x1BF43CC VA: 0x1BF83CC
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlAnyConverter : XmlBaseConverter // TypeDefIndex: 3646
{
	// Fields
	public static readonly XmlValueConverter Item; // 0x0
	public static readonly XmlValueConverter AnyAtomic; // 0x8

	// Methods

	// RVA: 0x1BF8484 Offset: 0x1BF4484 VA: 0x1BF8484
	protected void .ctor(XmlTypeCode typeCode) { }

	// RVA: 0x1BF84EC Offset: 0x1BF44EC VA: 0x1BF84EC Slot: 9
	public override bool ToBoolean(object value) { }

	// RVA: 0x1BF87BC Offset: 0x1BF47BC VA: 0x1BF87BC Slot: 39
	public override DateTime ToDateTime(object value) { }

	// RVA: 0x1BF8964 Offset: 0x1BF4964 VA: 0x1BF8964 Slot: 42
	public override DateTimeOffset ToDateTimeOffset(object value) { }

	// RVA: 0x1BF8B20 Offset: 0x1BF4B20 VA: 0x1BF8B20 Slot: 23
	public override Decimal ToDecimal(object value) { }

	// RVA: 0x1BF8CDC Offset: 0x1BF4CDC VA: 0x1BF8CDC Slot: 29
	public override double ToDouble(object value) { }

	// RVA: 0x1BF8E7C Offset: 0x1BF4E7C VA: 0x1BF8E7C Slot: 15
	public override int ToInt32(object value) { }

	// RVA: 0x1BF901C Offset: 0x1BF501C VA: 0x1BF901C Slot: 21
	public override long ToInt64(object value) { }

	// RVA: 0x1BF91BC Offset: 0x1BF51BC VA: 0x1BF91BC Slot: 32
	public override float ToSingle(object value) { }

	// RVA: 0x1BF936C Offset: 0x1BF536C VA: 0x1BF936C Slot: 53
	public override object ChangeType(bool value, Type destinationType) { }

	// RVA: 0x1BF9694 Offset: 0x1BF5694 VA: 0x1BF9694 Slot: 58
	public override object ChangeType(DateTime value, Type destinationType) { }

	// RVA: 0x1BF9874 Offset: 0x1BF5874 VA: 0x1BF9874 Slot: 56
	public override object ChangeType(Decimal value, Type destinationType) { }

	// RVA: 0x1BF9AB4 Offset: 0x1BF5AB4 VA: 0x1BF9AB4 Slot: 57
	public override object ChangeType(double value, Type destinationType) { }

	// RVA: 0x1BF9C80 Offset: 0x1BF5C80 VA: 0x1BF9C80 Slot: 54
	public override object ChangeType(int value, Type destinationType) { }

	// RVA: 0x1BF9E4C Offset: 0x1BF5E4C VA: 0x1BF9E4C Slot: 55
	public override object ChangeType(long value, Type destinationType) { }

	// RVA: 0x1BFA018 Offset: 0x1BF6018 VA: 0x1BFA018 Slot: 59
	public override object ChangeType(string value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BFA204 Offset: 0x1BF6204 VA: 0x1BFA204 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BF868C Offset: 0x1BF468C VA: 0x1BF868C
	private object ChangeTypeWildcardDestination(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BF953C Offset: 0x1BF553C VA: 0x1BF953C
	private object ChangeTypeWildcardSource(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BFB658 Offset: 0x1BF7658 VA: 0x1BFB658
	private XPathNavigator ToNavigator(XPathNavigator nav) { }

	// RVA: 0x1BFB6D8 Offset: 0x1BF76D8 VA: 0x1BFB6D8
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlAnyListConverter : XmlListConverter // TypeDefIndex: 3647
{
	// Fields
	public static readonly XmlValueConverter ItemList; // 0x0
	public static readonly XmlValueConverter AnyAtomicList; // 0x8

	// Methods

	// RVA: 0x1BFB768 Offset: 0x1BF7768 VA: 0x1BFB768
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x1BFB7E4 Offset: 0x1BF77E4 VA: 0x1BFB7E4 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BFBA38 Offset: 0x1BF7A38 VA: 0x1BFBA38
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal class XmlListConverter : XmlBaseConverter // TypeDefIndex: 3648
{
	// Fields
	protected XmlValueConverter atomicConverter; // 0x28

	// Methods

	// RVA: 0x1BFB76C Offset: 0x1BF776C VA: 0x1BFB76C
	protected void .ctor(XmlBaseConverter atomicConverter) { }

	// RVA: 0x1BF1D94 Offset: 0x1BEDD94 VA: 0x1BF1D94
	protected void .ctor(XmlBaseConverter atomicConverter, Type clrTypeDefault) { }

	// RVA: 0x1BF1C8C Offset: 0x1BEDC8C VA: 0x1BF1C8C
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1BFBB98 Offset: 0x1BF7B98 VA: 0x1BFBB98
	public static XmlValueConverter Create(XmlValueConverter atomicConverter) { }

	// RVA: 0x1BFBD44 Offset: 0x1BF7D44 VA: 0x1BFBD44 Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BF760C Offset: 0x1BF360C VA: 0x1BF760C Slot: 62
	protected override object ChangeListType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BFBE24 Offset: 0x1BF7E24 VA: 0x1BFBE24
	private bool IsListType(Type type) { }

	// RVA: -1 Offset: -1
	private T[] ToArray<T>(object list, IXmlNamespaceResolver nsResolver) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103DDA4 Offset: 0x1039DA4 VA: 0x103DDA4
	|-XmlListConverter.ToArray<bool>
	|
	|-RVA: 0x103E46C Offset: 0x103A46C VA: 0x103E46C
	|-XmlListConverter.ToArray<byte>
	|
	|-RVA: 0x103EB2C Offset: 0x103AB2C VA: 0x103EB2C
	|-XmlListConverter.ToArray<DateTime>
	|
	|-RVA: 0x103F1EC Offset: 0x103B1EC VA: 0x103F1EC
	|-XmlListConverter.ToArray<DateTimeOffset>
	|
	|-RVA: 0x103F8AC Offset: 0x103B8AC VA: 0x103F8AC
	|-XmlListConverter.ToArray<Decimal>
	|
	|-RVA: 0x103FF6C Offset: 0x103BF6C VA: 0x103FF6C
	|-XmlListConverter.ToArray<double>
	|
	|-RVA: 0x104062C Offset: 0x103C62C VA: 0x104062C
	|-XmlListConverter.ToArray<short>
	|
	|-RVA: 0x1040CEC Offset: 0x103CCEC VA: 0x1040CEC
	|-XmlListConverter.ToArray<int>
	|
	|-RVA: 0x10413AC Offset: 0x103D3AC VA: 0x10413AC
	|-XmlListConverter.ToArray<long>
	|
	|-RVA: 0x1041A6C Offset: 0x103DA6C VA: 0x1041A6C
	|-XmlListConverter.ToArray<object>
	|
	|-RVA: 0x1042148 Offset: 0x103E148 VA: 0x1042148
	|-XmlListConverter.ToArray<sbyte>
	|
	|-RVA: 0x1042808 Offset: 0x103E808 VA: 0x1042808
	|-XmlListConverter.ToArray<float>
	|
	|-RVA: 0x1042EC8 Offset: 0x103EEC8 VA: 0x1042EC8
	|-XmlListConverter.ToArray<TimeSpan>
	|
	|-RVA: 0x1043588 Offset: 0x103F588 VA: 0x1043588
	|-XmlListConverter.ToArray<ushort>
	|
	|-RVA: 0x1043C48 Offset: 0x103FC48 VA: 0x1043C48
	|-XmlListConverter.ToArray<uint>
	|
	|-RVA: 0x1044308 Offset: 0x1040308 VA: 0x1044308
	|-XmlListConverter.ToArray<ulong>
	|
	|-RVA: 0x10449C8 Offset: 0x10409C8 VA: 0x10449C8
	|-XmlListConverter.ToArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1BFC660 Offset: 0x1BF8660 VA: 0x1BFC660
	private IList ToList(object list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BFC5B8 Offset: 0x1BF85B8 VA: 0x1BFC5B8
	private List<string> StringAsList(string value) { }

	// RVA: 0x1BFC23C Offset: 0x1BF823C VA: 0x1BFC23C
	private string ListAsString(IEnumerable list, IXmlNamespaceResolver nsResolver) { }

	// RVA: 0x1BFBFA8 Offset: 0x1BF7FA8 VA: 0x1BFBFA8
	private Exception CreateInvalidClrMappingException(Type sourceType, Type destinationType) { }
}

// Namespace: System.Xml.Schema
internal class XmlUnionConverter : XmlBaseConverter // TypeDefIndex: 3649
{
	// Fields
	private XmlValueConverter[] converters; // 0x28
	private bool hasAtomicMember; // 0x30
	private bool hasListMember; // 0x31

	// Methods

	// RVA: 0x1BFCC84 Offset: 0x1BF8C84 VA: 0x1BFCC84
	protected void .ctor(XmlSchemaType schemaType) { }

	// RVA: 0x1BFCEE4 Offset: 0x1BF8EE4 VA: 0x1BFCEE4
	public static XmlValueConverter Create(XmlSchemaType schemaType) { }

	// RVA: 0x1BFCF3C Offset: 0x1BF8F3C VA: 0x1BFCF3C Slot: 61
	public override object ChangeType(object value, Type destinationType, IXmlNamespaceResolver nsResolver) { }
}

// Namespace: 
private enum XsdBuilder.State // TypeDefIndex: 3650
{
	// Fields
	public int value__; // 0x0
	public const XsdBuilder.State Root = 0;
	public const XsdBuilder.State Schema = 1;
	public const XsdBuilder.State Annotation = 2;
	public const XsdBuilder.State Include = 3;
	public const XsdBuilder.State Import = 4;
	public const XsdBuilder.State Element = 5;
	public const XsdBuilder.State Attribute = 6;
	public const XsdBuilder.State AttributeGroup = 7;
	public const XsdBuilder.State AttributeGroupRef = 8;
	public const XsdBuilder.State AnyAttribute = 9;
	public const XsdBuilder.State Group = 10;
	public const XsdBuilder.State GroupRef = 11;
	public const XsdBuilder.State All = 12;
	public const XsdBuilder.State Choice = 13;
	public const XsdBuilder.State Sequence = 14;
	public const XsdBuilder.State Any = 15;
	public const XsdBuilder.State Notation = 16;
	public const XsdBuilder.State SimpleType = 17;
	public const XsdBuilder.State ComplexType = 18;
	public const XsdBuilder.State ComplexContent = 19;
	public const XsdBuilder.State ComplexContentRestriction = 20;
	public const XsdBuilder.State ComplexContentExtension = 21;
	public const XsdBuilder.State SimpleContent = 22;
	public const XsdBuilder.State SimpleContentExtension = 23;
	public const XsdBuilder.State SimpleContentRestriction = 24;
	public const XsdBuilder.State SimpleTypeUnion = 25;
	public const XsdBuilder.State SimpleTypeList = 26;
	public const XsdBuilder.State SimpleTypeRestriction = 27;
	public const XsdBuilder.State Unique = 28;
	public const XsdBuilder.State Key = 29;
	public const XsdBuilder.State KeyRef = 30;
	public const XsdBuilder.State Selector = 31;
	public const XsdBuilder.State Field = 32;
	public const XsdBuilder.State MinExclusive = 33;
	public const XsdBuilder.State MinInclusive = 34;
	public const XsdBuilder.State MaxExclusive = 35;
	public const XsdBuilder.State MaxInclusive = 36;
	public const XsdBuilder.State TotalDigits = 37;
	public const XsdBuilder.State FractionDigits = 38;
	public const XsdBuilder.State Length = 39;
	public const XsdBuilder.State MinLength = 40;
	public const XsdBuilder.State MaxLength = 41;
	public const XsdBuilder.State Enumeration = 42;
	public const XsdBuilder.State Pattern = 43;
	public const XsdBuilder.State WhiteSpace = 44;
	public const XsdBuilder.State AppInfo = 45;
	public const XsdBuilder.State Documentation = 46;
	public const XsdBuilder.State Redefine = 47;
}

// Namespace: 
private sealed class XsdBuilder.XsdBuildFunction : MulticastDelegate // TypeDefIndex: 3651
{
	// Methods

	// RVA: 0x1C08DE8 Offset: 0x1C04DE8 VA: 0x1C08DE8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C08E9C Offset: 0x1C04E9C VA: 0x1C08E9C Slot: 12
	public virtual void Invoke(XsdBuilder builder, string value) { }
}

// Namespace: 
private sealed class XsdBuilder.XsdInitFunction : MulticastDelegate // TypeDefIndex: 3652
{
	// Methods

	// RVA: 0x1C08EB0 Offset: 0x1C04EB0 VA: 0x1C08EB0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C08F64 Offset: 0x1C04F64 VA: 0x1C08F64 Slot: 12
	public virtual void Invoke(XsdBuilder builder, string value) { }
}

// Namespace: 
private sealed class XsdBuilder.XsdEndChildFunction : MulticastDelegate // TypeDefIndex: 3653
{
	// Methods

	// RVA: 0x1C08F78 Offset: 0x1C04F78 VA: 0x1C08F78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C09028 Offset: 0x1C05028 VA: 0x1C09028 Slot: 12
	public virtual void Invoke(XsdBuilder builder) { }
}

// Namespace: 
private sealed class XsdBuilder.XsdAttributeEntry // TypeDefIndex: 3654
{
	// Fields
	public SchemaNames.Token Attribute; // 0x10
	public XsdBuilder.XsdBuildFunction BuildFunc; // 0x18

	// Methods

	// RVA: 0x1C0903C Offset: 0x1C0503C VA: 0x1C0903C
	public void .ctor(SchemaNames.Token a, XsdBuilder.XsdBuildFunction build) { }
}

// Namespace: 
private sealed class XsdBuilder.XsdEntry // TypeDefIndex: 3655
{
	// Fields
	public SchemaNames.Token Name; // 0x10
	public XsdBuilder.State CurrentState; // 0x14
	public XsdBuilder.State[] NextStates; // 0x18
	public XsdBuilder.XsdAttributeEntry[] Attributes; // 0x20
	public XsdBuilder.XsdInitFunction InitFunc; // 0x28
	public XsdBuilder.XsdEndChildFunction EndChildFunc; // 0x30
	public bool ParseContent; // 0x38

	// Methods

	// RVA: 0x1C09074 Offset: 0x1C05074 VA: 0x1C09074
	public void .ctor(SchemaNames.Token n, XsdBuilder.State state, XsdBuilder.State[] nextStates, XsdBuilder.XsdAttributeEntry[] attributes, XsdBuilder.XsdInitFunction init, XsdBuilder.XsdEndChildFunction end, bool parseContent) { }
}

// Namespace: 
private class XsdBuilder.BuilderNamespaceManager : XmlNamespaceManager // TypeDefIndex: 3656
{
	// Fields
	private XmlNamespaceManager nsMgr; // 0x50
	private XmlReader reader; // 0x58

	// Methods

	// RVA: 0x1C09110 Offset: 0x1C05110 VA: 0x1C09110
	public void .ctor(XmlNamespaceManager nsMgr, XmlReader reader) { }

	// RVA: 0x1C09154 Offset: 0x1C05154 VA: 0x1C09154 Slot: 16
	public override string LookupNamespace(string prefix) { }
}

// Namespace: System.Xml.Schema
internal sealed class XsdBuilder : SchemaBuilder // TypeDefIndex: 3657
{
	// Fields
	private static readonly XsdBuilder.State[] SchemaElement; // 0x0
	private static readonly XsdBuilder.State[] SchemaSubelements; // 0x8
	private static readonly XsdBuilder.State[] AttributeSubelements; // 0x10
	private static readonly XsdBuilder.State[] ElementSubelements; // 0x18
	private static readonly XsdBuilder.State[] ComplexTypeSubelements; // 0x20
	private static readonly XsdBuilder.State[] SimpleContentSubelements; // 0x28
	private static readonly XsdBuilder.State[] SimpleContentExtensionSubelements; // 0x30
	private static readonly XsdBuilder.State[] SimpleContentRestrictionSubelements; // 0x38
	private static readonly XsdBuilder.State[] ComplexContentSubelements; // 0x40
	private static readonly XsdBuilder.State[] ComplexContentExtensionSubelements; // 0x48
	private static readonly XsdBuilder.State[] ComplexContentRestrictionSubelements; // 0x50
	private static readonly XsdBuilder.State[] SimpleTypeSubelements; // 0x58
	private static readonly XsdBuilder.State[] SimpleTypeRestrictionSubelements; // 0x60
	private static readonly XsdBuilder.State[] SimpleTypeListSubelements; // 0x68
	private static readonly XsdBuilder.State[] SimpleTypeUnionSubelements; // 0x70
	private static readonly XsdBuilder.State[] RedefineSubelements; // 0x78
	private static readonly XsdBuilder.State[] AttributeGroupSubelements; // 0x80
	private static readonly XsdBuilder.State[] GroupSubelements; // 0x88
	private static readonly XsdBuilder.State[] AllSubelements; // 0x90
	private static readonly XsdBuilder.State[] ChoiceSequenceSubelements; // 0x98
	private static readonly XsdBuilder.State[] IdentityConstraintSubelements; // 0xA0
	private static readonly XsdBuilder.State[] AnnotationSubelements; // 0xA8
	private static readonly XsdBuilder.State[] AnnotatedSubelements; // 0xB0
	private static readonly XsdBuilder.XsdAttributeEntry[] SchemaAttributes; // 0xB8
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeAttributes; // 0xC0
	private static readonly XsdBuilder.XsdAttributeEntry[] ElementAttributes; // 0xC8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexTypeAttributes; // 0xD0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentAttributes; // 0xD8
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentExtensionAttributes; // 0xE0
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleContentRestrictionAttributes; // 0xE8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentAttributes; // 0xF0
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentExtensionAttributes; // 0xF8
	private static readonly XsdBuilder.XsdAttributeEntry[] ComplexContentRestrictionAttributes; // 0x100
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeAttributes; // 0x108
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeRestrictionAttributes; // 0x110
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeUnionAttributes; // 0x118
	private static readonly XsdBuilder.XsdAttributeEntry[] SimpleTypeListAttributes; // 0x120
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupAttributes; // 0x128
	private static readonly XsdBuilder.XsdAttributeEntry[] AttributeGroupRefAttributes; // 0x130
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupAttributes; // 0x138
	private static readonly XsdBuilder.XsdAttributeEntry[] GroupRefAttributes; // 0x140
	private static readonly XsdBuilder.XsdAttributeEntry[] ParticleAttributes; // 0x148
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributes; // 0x150
	private static readonly XsdBuilder.XsdAttributeEntry[] IdentityConstraintAttributes; // 0x158
	private static readonly XsdBuilder.XsdAttributeEntry[] SelectorAttributes; // 0x160
	private static readonly XsdBuilder.XsdAttributeEntry[] FieldAttributes; // 0x168
	private static readonly XsdBuilder.XsdAttributeEntry[] NotationAttributes; // 0x170
	private static readonly XsdBuilder.XsdAttributeEntry[] IncludeAttributes; // 0x178
	private static readonly XsdBuilder.XsdAttributeEntry[] ImportAttributes; // 0x180
	private static readonly XsdBuilder.XsdAttributeEntry[] FacetAttributes; // 0x188
	private static readonly XsdBuilder.XsdAttributeEntry[] AnyAttributeAttributes; // 0x190
	private static readonly XsdBuilder.XsdAttributeEntry[] DocumentationAttributes; // 0x198
	private static readonly XsdBuilder.XsdAttributeEntry[] AppinfoAttributes; // 0x1A0
	private static readonly XsdBuilder.XsdAttributeEntry[] RedefineAttributes; // 0x1A8
	private static readonly XsdBuilder.XsdAttributeEntry[] AnnotationAttributes; // 0x1B0
	private static readonly XsdBuilder.XsdEntry[] SchemaEntries; // 0x1B8
	private static readonly int[] DerivationMethodValues; // 0x1C0
	private static readonly string[] DerivationMethodStrings; // 0x1C8
	private static readonly string[] FormStringValues; // 0x1D0
	private static readonly string[] UseStringValues; // 0x1D8
	private static readonly string[] ProcessContentsStringValues; // 0x1E0
	private XmlReader reader; // 0x10
	private PositionInfo positionInfo; // 0x18
	private XsdBuilder.XsdEntry currentEntry; // 0x20
	private XsdBuilder.XsdEntry nextEntry; // 0x28
	private bool hasChild; // 0x30
	private HWStack stateHistory; // 0x38
	private Stack containerStack; // 0x40
	private XmlNameTable nameTable; // 0x48
	private SchemaNames schemaNames; // 0x50
	private XmlNamespaceManager namespaceManager; // 0x58
	private bool canIncludeImport; // 0x60
	private XmlSchema schema; // 0x68
	private XmlSchemaObject xso; // 0x70
	private XmlSchemaElement element; // 0x78
	private XmlSchemaAny anyElement; // 0x80
	private XmlSchemaAttribute attribute; // 0x88
	private XmlSchemaAnyAttribute anyAttribute; // 0x90
	private XmlSchemaComplexType complexType; // 0x98
	private XmlSchemaSimpleType simpleType; // 0xA0
	private XmlSchemaComplexContent complexContent; // 0xA8
	private XmlSchemaComplexContentExtension complexContentExtension; // 0xB0
	private XmlSchemaComplexContentRestriction complexContentRestriction; // 0xB8
	private XmlSchemaSimpleContent simpleContent; // 0xC0
	private XmlSchemaSimpleContentExtension simpleContentExtension; // 0xC8
	private XmlSchemaSimpleContentRestriction simpleContentRestriction; // 0xD0
	private XmlSchemaSimpleTypeUnion simpleTypeUnion; // 0xD8
	private XmlSchemaSimpleTypeList simpleTypeList; // 0xE0
	private XmlSchemaSimpleTypeRestriction simpleTypeRestriction; // 0xE8
	private XmlSchemaGroup group; // 0xF0
	private XmlSchemaGroupRef groupRef; // 0xF8
	private XmlSchemaAll all; // 0x100
	private XmlSchemaChoice choice; // 0x108
	private XmlSchemaSequence sequence; // 0x110
	private XmlSchemaParticle particle; // 0x118
	private XmlSchemaAttributeGroup attributeGroup; // 0x120
	private XmlSchemaAttributeGroupRef attributeGroupRef; // 0x128
	private XmlSchemaNotation notation; // 0x130
	private XmlSchemaIdentityConstraint identityConstraint; // 0x138
	private XmlSchemaXPath xpath; // 0x140
	private XmlSchemaInclude include; // 0x148
	private XmlSchemaImport import; // 0x150
	private XmlSchemaAnnotation annotation; // 0x158
	private XmlSchemaAppInfo appInfo; // 0x160
	private XmlSchemaDocumentation documentation; // 0x168
	private XmlSchemaFacet facet; // 0x170
	private XmlNode[] markup; // 0x178
	private XmlSchemaRedefine redefine; // 0x180
	private ValidationEventHandler validationEventHandler; // 0x188
	private ArrayList unhandledAttributes; // 0x190
	private Hashtable namespaces; // 0x198

	// Properties
	private SchemaNames.Token CurrentElement { get; }
	private SchemaNames.Token ParentElement { get; }
	private XmlSchemaObject ParentContainer { get; }

	// Methods

	// RVA: 0x1BFD330 Offset: 0x1BF9330 VA: 0x1BFD330
	internal void .ctor(XmlReader reader, XmlNamespaceManager curmgr, XmlSchema schema, XmlNameTable nameTable, SchemaNames schemaNames, ValidationEventHandler eventhandler) { }

	// RVA: 0x1BFD58C Offset: 0x1BF958C VA: 0x1BFD58C Slot: 4
	internal override bool ProcessElement(string prefix, string name, string ns) { }

	// RVA: 0x1BFDA88 Offset: 0x1BF9A88 VA: 0x1BFDA88 Slot: 5
	internal override void ProcessAttribute(string prefix, string name, string ns, string value) { }

	// RVA: 0x1BFDFE4 Offset: 0x1BF9FE4 VA: 0x1BFDFE4 Slot: 6
	internal override bool IsContentParsed() { }

	// RVA: 0x1BFDFFC Offset: 0x1BF9FFC VA: 0x1BFDFFC Slot: 7
	internal override void ProcessMarkup(XmlNode[] markup) { }

	// RVA: 0x1BFE00C Offset: 0x1BFA00C VA: 0x1BFE00C Slot: 8
	internal override void ProcessCData(string value) { }

	// RVA: 0x1BFE064 Offset: 0x1BFA064 VA: 0x1BFE064 Slot: 9
	internal override void StartChildren() { }

	// RVA: 0x1BFE1EC Offset: 0x1BFA1EC VA: 0x1BFE1EC Slot: 10
	internal override void EndChildren() { }

	// RVA: 0x1BFD814 Offset: 0x1BF9814 VA: 0x1BFD814
	private void Push() { }

	// RVA: 0x1BFE228 Offset: 0x1BFA228 VA: 0x1BFE228
	private void Pop() { }

	// RVA: 0x1BFF1B4 Offset: 0x1BFB1B4 VA: 0x1BFF1B4
	private SchemaNames.Token get_CurrentElement() { }

	// RVA: 0x1BFF1CC Offset: 0x1BFB1CC VA: 0x1BFF1CC
	private SchemaNames.Token get_ParentElement() { }

	// RVA: 0x1BFF244 Offset: 0x1BFB244 VA: 0x1BFF244
	private XmlSchemaObject get_ParentContainer() { }

	// RVA: 0x1BFE300 Offset: 0x1BFA300 VA: 0x1BFE300
	private XmlSchemaObject GetContainer(XsdBuilder.State state) { }

	// RVA: 0x1BFE438 Offset: 0x1BFA438 VA: 0x1BFE438
	private void SetContainer(XsdBuilder.State state, object container) { }

	// RVA: 0x1BFF2D4 Offset: 0x1BFB2D4 VA: 0x1BFF2D4
	private static void BuildAnnotated_Id(XsdBuilder builder, string value) { }

	// RVA: 0x1BFF2F8 Offset: 0x1BFB2F8 VA: 0x1BFF2F8
	private static void BuildSchema_AttributeFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x1BFF47C Offset: 0x1BFB47C VA: 0x1BFF47C
	private static void BuildSchema_ElementFormDefault(XsdBuilder builder, string value) { }

	// RVA: 0x1BFF51C Offset: 0x1BFB51C VA: 0x1BFF51C
	private static void BuildSchema_TargetNamespace(XsdBuilder builder, string value) { }

	// RVA: 0x1BFF53C Offset: 0x1BFB53C VA: 0x1BFF53C
	private static void BuildSchema_Version(XsdBuilder builder, string value) { }

	// RVA: 0x1BFF55C Offset: 0x1BFB55C VA: 0x1BFF55C
	private static void BuildSchema_FinalDefault(XsdBuilder builder, string value) { }

	// RVA: 0x1BFF814 Offset: 0x1BFB814 VA: 0x1BFF814
	private static void BuildSchema_BlockDefault(XsdBuilder builder, string value) { }

	// RVA: 0x1BFF87C Offset: 0x1BFB87C VA: 0x1BFF87C
	private static void InitSchema(XsdBuilder builder, string value) { }

	// RVA: 0x1BFF89C Offset: 0x1BFB89C VA: 0x1BFF89C
	private static void InitInclude(XsdBuilder builder, string value) { }

	// RVA: 0x1BFF960 Offset: 0x1BFB960 VA: 0x1BFF960
	private static void BuildInclude_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x1BFF980 Offset: 0x1BFB980 VA: 0x1BFF980
	private static void InitImport(XsdBuilder builder, string value) { }

	// RVA: 0x1BFFA44 Offset: 0x1BFBA44 VA: 0x1BFFA44
	private static void BuildImport_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x1BFFA64 Offset: 0x1BFBA64 VA: 0x1BFFA64
	private static void BuildImport_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x1BFFA84 Offset: 0x1BFBA84 VA: 0x1BFFA84
	private static void InitRedefine(XsdBuilder builder, string value) { }

	// RVA: 0x1BFFB48 Offset: 0x1BFBB48 VA: 0x1BFFB48
	private static void BuildRedefine_SchemaLocation(XsdBuilder builder, string value) { }

	// RVA: 0x1BFFB68 Offset: 0x1BFBB68 VA: 0x1BFFB68
	private static void EndRedefine(XsdBuilder builder) { }

	// RVA: 0x1BFFB80 Offset: 0x1BFBB80 VA: 0x1BFFB80
	private static void InitAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x1BFFE74 Offset: 0x1BFBE74 VA: 0x1BFFE74
	private static void BuildAttribute_Default(XsdBuilder builder, string value) { }

	// RVA: 0x1BFFE94 Offset: 0x1BFBE94 VA: 0x1BFFE94
	private static void BuildAttribute_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x1BFFEB4 Offset: 0x1BFBEB4 VA: 0x1BFFEB4
	private static void BuildAttribute_Form(XsdBuilder builder, string value) { }

	// RVA: 0x1BFFF54 Offset: 0x1BFBF54 VA: 0x1BFFF54
	private static void BuildAttribute_Use(XsdBuilder builder, string value) { }

	// RVA: 0x1BFFFF4 Offset: 0x1BFBFF4 VA: 0x1BFFFF4
	private static void BuildAttribute_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1C001E8 Offset: 0x1BFC1E8 VA: 0x1C001E8
	private static void BuildAttribute_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C00208 Offset: 0x1BFC208 VA: 0x1C00208
	private static void BuildAttribute_Type(XsdBuilder builder, string value) { }

	// RVA: 0x1C00278 Offset: 0x1BFC278 VA: 0x1C00278
	private static void InitElement(XsdBuilder builder, string value) { }

	// RVA: 0x1C00388 Offset: 0x1BFC388 VA: 0x1C00388
	private static void BuildElement_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x1C00504 Offset: 0x1BFC504 VA: 0x1C00504
	private static void BuildElement_Block(XsdBuilder builder, string value) { }

	// RVA: 0x1C0056C Offset: 0x1BFC56C VA: 0x1C0056C
	private static void BuildElement_Default(XsdBuilder builder, string value) { }

	// RVA: 0x1C0058C Offset: 0x1BFC58C VA: 0x1C0058C
	private static void BuildElement_Form(XsdBuilder builder, string value) { }

	// RVA: 0x1C0062C Offset: 0x1BFC62C VA: 0x1C0062C
	private static void BuildElement_SubstitutionGroup(XsdBuilder builder, string value) { }

	// RVA: 0x1C0069C Offset: 0x1BFC69C VA: 0x1C0069C
	private static void BuildElement_Final(XsdBuilder builder, string value) { }

	// RVA: 0x1C00704 Offset: 0x1BFC704 VA: 0x1C00704
	private static void BuildElement_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x1C00724 Offset: 0x1BFC724 VA: 0x1C00724
	private static void BuildElement_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1C007FC Offset: 0x1BFC7FC VA: 0x1C007FC
	private static void BuildElement_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1C008D4 Offset: 0x1BFC8D4 VA: 0x1C008D4
	private static void BuildElement_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C008F4 Offset: 0x1BFC8F4 VA: 0x1C008F4
	private static void BuildElement_Nillable(XsdBuilder builder, string value) { }

	// RVA: 0x1C00964 Offset: 0x1BFC964 VA: 0x1C00964
	private static void BuildElement_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1C009D4 Offset: 0x1BFC9D4 VA: 0x1C009D4
	private static void BuildElement_Type(XsdBuilder builder, string value) { }

	// RVA: 0x1C00A44 Offset: 0x1BFCA44 VA: 0x1C00A44
	private static void InitSimpleType(XsdBuilder builder, string value) { }

	// RVA: 0x1C00D78 Offset: 0x1BFCD78 VA: 0x1C00D78
	private static void BuildSimpleType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C00D98 Offset: 0x1BFCD98 VA: 0x1C00D98
	private static void BuildSimpleType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x1C00E00 Offset: 0x1BFCE00 VA: 0x1C00E00
	private static void InitSimpleTypeUnion(XsdBuilder builder, string value) { }

	// RVA: 0x1C00EC4 Offset: 0x1BFCEC4 VA: 0x1C00EC4
	private static void BuildSimpleTypeUnion_MemberTypes(XsdBuilder builder, string value) { }

	// RVA: 0x1C010B4 Offset: 0x1BFD0B4 VA: 0x1C010B4
	private static void InitSimpleTypeList(XsdBuilder builder, string value) { }

	// RVA: 0x1C01178 Offset: 0x1BFD178 VA: 0x1C01178
	private static void BuildSimpleTypeList_ItemType(XsdBuilder builder, string value) { }

	// RVA: 0x1C011E8 Offset: 0x1BFD1E8 VA: 0x1C011E8
	private static void InitSimpleTypeRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x1C012AC Offset: 0x1BFD2AC VA: 0x1C012AC
	private static void BuildSimpleTypeRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1C0131C Offset: 0x1BFD31C VA: 0x1C0131C
	private static void InitComplexType(XsdBuilder builder, string value) { }

	// RVA: 0x1C014A0 Offset: 0x1BFD4A0 VA: 0x1C014A0
	private static void BuildComplexType_Abstract(XsdBuilder builder, string value) { }

	// RVA: 0x1C01510 Offset: 0x1BFD510 VA: 0x1C01510
	private static void BuildComplexType_Block(XsdBuilder builder, string value) { }

	// RVA: 0x1C01578 Offset: 0x1BFD578 VA: 0x1C01578
	private static void BuildComplexType_Final(XsdBuilder builder, string value) { }

	// RVA: 0x1C015E0 Offset: 0x1BFD5E0 VA: 0x1C015E0
	private static void BuildComplexType_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x1C01658 Offset: 0x1BFD658 VA: 0x1C01658
	private static void BuildComplexType_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C01678 Offset: 0x1BFD678 VA: 0x1C01678
	private static void InitComplexContent(XsdBuilder builder, string value) { }

	// RVA: 0x1C01780 Offset: 0x1BFD780 VA: 0x1C01780
	private static void BuildComplexContent_Mixed(XsdBuilder builder, string value) { }

	// RVA: 0x1C017F0 Offset: 0x1BFD7F0 VA: 0x1C017F0
	private static void InitComplexContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x1C018DC Offset: 0x1BFD8DC VA: 0x1C018DC
	private static void BuildComplexContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1C0194C Offset: 0x1BFD94C VA: 0x1C0194C
	private static void InitComplexContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x1C019E4 Offset: 0x1BFD9E4 VA: 0x1C019E4
	private static void BuildComplexContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1C01A54 Offset: 0x1BFDA54 VA: 0x1C01A54
	private static void InitSimpleContent(XsdBuilder builder, string value) { }

	// RVA: 0x1C01B5C Offset: 0x1BFDB5C VA: 0x1C01B5C
	private static void InitSimpleContentExtension(XsdBuilder builder, string value) { }

	// RVA: 0x1C01C48 Offset: 0x1BFDC48 VA: 0x1C01C48
	private static void BuildSimpleContentExtension_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1C01CB8 Offset: 0x1BFDCB8 VA: 0x1C01CB8
	private static void InitSimpleContentRestriction(XsdBuilder builder, string value) { }

	// RVA: 0x1C01DA4 Offset: 0x1BFDDA4 VA: 0x1C01DA4
	private static void BuildSimpleContentRestriction_Base(XsdBuilder builder, string value) { }

	// RVA: 0x1C01E14 Offset: 0x1BFDE14 VA: 0x1C01E14
	private static void InitAttributeGroup(XsdBuilder builder, string value) { }

	// RVA: 0x1C01EE4 Offset: 0x1BFDEE4 VA: 0x1C01EE4
	private static void BuildAttributeGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C01F04 Offset: 0x1BFDF04 VA: 0x1C01F04
	private static void InitAttributeGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x1C01F88 Offset: 0x1BFDF88 VA: 0x1C01F88
	private static void BuildAttributeGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1C01FF8 Offset: 0x1BFDFF8 VA: 0x1C01FF8
	private static void InitAnyAttribute(XsdBuilder builder, string value) { }

	// RVA: 0x1C0229C Offset: 0x1BFE29C VA: 0x1C0229C
	private static void BuildAnyAttribute_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x1C022BC Offset: 0x1BFE2BC VA: 0x1C022BC
	private static void BuildAnyAttribute_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x1C0235C Offset: 0x1BFE35C VA: 0x1C0235C
	private static void InitGroup(XsdBuilder builder, string value) { }

	// RVA: 0x1C02430 Offset: 0x1BFE430 VA: 0x1C02430
	private static void BuildGroup_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C02450 Offset: 0x1BFE450 VA: 0x1C02450
	private static void InitGroupRef(XsdBuilder builder, string value) { }

	// RVA: 0x1C027D0 Offset: 0x1BFE7D0 VA: 0x1C027D0
	private static void BuildParticle_MaxOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1C027E8 Offset: 0x1BFE7E8 VA: 0x1C027E8
	private static void BuildParticle_MinOccurs(XsdBuilder builder, string value) { }

	// RVA: 0x1C02800 Offset: 0x1BFE800 VA: 0x1C02800
	private static void BuildGroupRef_Ref(XsdBuilder builder, string value) { }

	// RVA: 0x1C02870 Offset: 0x1BFE870 VA: 0x1C02870
	private static void InitAll(XsdBuilder builder, string value) { }

	// RVA: 0x1C02904 Offset: 0x1BFE904 VA: 0x1C02904
	private static void InitChoice(XsdBuilder builder, string value) { }

	// RVA: 0x1C02998 Offset: 0x1BFE998 VA: 0x1C02998
	private static void InitSequence(XsdBuilder builder, string value) { }

	// RVA: 0x1C02A2C Offset: 0x1BFEA2C VA: 0x1C02A2C
	private static void InitAny(XsdBuilder builder, string value) { }

	// RVA: 0x1C02AC4 Offset: 0x1BFEAC4 VA: 0x1C02AC4
	private static void BuildAny_Namespace(XsdBuilder builder, string value) { }

	// RVA: 0x1C02AE4 Offset: 0x1BFEAE4 VA: 0x1C02AE4
	private static void BuildAny_ProcessContents(XsdBuilder builder, string value) { }

	// RVA: 0x1C02B84 Offset: 0x1BFEB84 VA: 0x1C02B84
	private static void InitNotation(XsdBuilder builder, string value) { }

	// RVA: 0x1C02C20 Offset: 0x1BFEC20 VA: 0x1C02C20
	private static void BuildNotation_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C02C40 Offset: 0x1BFEC40 VA: 0x1C02C40
	private static void BuildNotation_Public(XsdBuilder builder, string value) { }

	// RVA: 0x1C02C60 Offset: 0x1BFEC60 VA: 0x1C02C60
	private static void BuildNotation_System(XsdBuilder builder, string value) { }

	// RVA: 0x1C02C80 Offset: 0x1BFEC80 VA: 0x1C02C80
	private static void InitFacet(XsdBuilder builder, string value) { }

	// RVA: 0x1C02FE8 Offset: 0x1BFEFE8 VA: 0x1C02FE8
	private static void BuildFacet_Fixed(XsdBuilder builder, string value) { }

	// RVA: 0x1C03060 Offset: 0x1BFF060 VA: 0x1C03060
	private static void BuildFacet_Value(XsdBuilder builder, string value) { }

	// RVA: 0x1C03080 Offset: 0x1BFF080 VA: 0x1C03080
	private static void InitIdentityConstraint(XsdBuilder builder, string value) { }

	// RVA: 0x1C031D4 Offset: 0x1BFF1D4 VA: 0x1C031D4
	private static void BuildIdentityConstraint_Name(XsdBuilder builder, string value) { }

	// RVA: 0x1C031F4 Offset: 0x1BFF1F4 VA: 0x1C031F4
	private static void BuildIdentityConstraint_Refer(XsdBuilder builder, string value) { }

	// RVA: 0x1C03314 Offset: 0x1BFF314 VA: 0x1C03314
	private static void InitSelector(XsdBuilder builder, string value) { }

	// RVA: 0x1C033DC Offset: 0x1BFF3DC VA: 0x1C033DC
	private static void BuildSelector_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x1C033FC Offset: 0x1BFF3FC VA: 0x1C033FC
	private static void InitField(XsdBuilder builder, string value) { }

	// RVA: 0x1C034C8 Offset: 0x1BFF4C8 VA: 0x1C034C8
	private static void BuildField_XPath(XsdBuilder builder, string value) { }

	// RVA: 0x1C034E8 Offset: 0x1BFF4E8 VA: 0x1C034E8
	private static void InitAnnotation(XsdBuilder builder, string value) { }

	// RVA: 0x1C035C8 Offset: 0x1BFF5C8 VA: 0x1C035C8
	private static void InitAppinfo(XsdBuilder builder, string value) { }

	// RVA: 0x1C03690 Offset: 0x1BFF690 VA: 0x1C03690
	private static void BuildAppinfo_Source(XsdBuilder builder, string value) { }

	// RVA: 0x1C03704 Offset: 0x1BFF704 VA: 0x1C03704
	private static void EndAppinfo(XsdBuilder builder) { }

	// RVA: 0x1C0372C Offset: 0x1BFF72C VA: 0x1C0372C
	private static void InitDocumentation(XsdBuilder builder, string value) { }

	// RVA: 0x1C037F4 Offset: 0x1BFF7F4 VA: 0x1C037F4
	private static void BuildDocumentation_Source(XsdBuilder builder, string value) { }

	// RVA: 0x1C03864 Offset: 0x1BFF864 VA: 0x1C03864
	private static void BuildDocumentation_XmlLang(XsdBuilder builder, string value) { }

	// RVA: 0x1C039A4 Offset: 0x1BFF9A4 VA: 0x1C039A4
	private static void EndDocumentation(XsdBuilder builder) { }

	// RVA: 0x1BFFC40 Offset: 0x1BFBC40 VA: 0x1BFFC40
	private void AddAttribute(XmlSchemaObject value) { }

	// RVA: 0x1C024E8 Offset: 0x1BFE4E8 VA: 0x1C024E8
	private void AddParticle(XmlSchemaParticle particle) { }

	// RVA: 0x1BFD6B4 Offset: 0x1BF96B4 VA: 0x1BFD6B4
	private bool GetNextState(XmlQualifiedName qname) { }

	// RVA: 0x1BFD97C Offset: 0x1BF997C VA: 0x1BFD97C
	private bool IsSkipableElement(XmlQualifiedName qname) { }

	// RVA: 0x1C00814 Offset: 0x1BFC814 VA: 0x1C00814
	private void SetMinOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x1C0073C Offset: 0x1BFC73C VA: 0x1C0073C
	private void SetMaxOccurs(XmlSchemaParticle particle, string value) { }

	// RVA: 0x1C003F8 Offset: 0x1BFC3F8 VA: 0x1C003F8
	private bool ParseBoolean(string value, string attributeName) { }

	// RVA: 0x1BFF398 Offset: 0x1BFB398 VA: 0x1BFF398
	private int ParseEnum(string value, string attributeName, string[] values) { }

	// RVA: 0x1C00064 Offset: 0x1BFC064 VA: 0x1C00064
	private XmlQualifiedName ParseQName(string value, string attributeName) { }

	// RVA: 0x1BFF5C4 Offset: 0x1BFB5C4 VA: 0x1BFF5C4
	private int ParseBlockFinalEnum(string value, string attributeName) { }

	// RVA: 0x1C03700 Offset: 0x1BFF700 VA: 0x1C03700
	private static string ParseUriReference(string s) { }

	// RVA: 0x1C039CC Offset: 0x1BFF9CC VA: 0x1C039CC
	private void SendValidationEvent(string code, string arg0, string arg1, string arg2) { }

	// RVA: 0x1BFD9A0 Offset: 0x1BF99A0 VA: 0x1BFD9A0
	private void SendValidationEvent(string code, string msg) { }

	// RVA: 0x1BFDEF0 Offset: 0x1BF9EF0 VA: 0x1BFDEF0
	private void SendValidationEvent(string code, string[] args, XmlSeverityType severity) { }

	// RVA: 0x1C03B40 Offset: 0x1BFFB40 VA: 0x1C03B40
	private void SendValidationEvent(XmlSchemaException e, XmlSeverityType severity) { }

	// RVA: 0x1C010AC Offset: 0x1BFD0AC VA: 0x1C010AC
	private void SendValidationEvent(XmlSchemaException e) { }

	// RVA: 0x1BFD8BC Offset: 0x1BF98BC VA: 0x1BFD8BC
	private void RecordPosition() { }

	// RVA: 0x1C03C1C Offset: 0x1BFFC1C VA: 0x1C03C1C
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
[Flags]
internal enum XsdDateTimeFlags // TypeDefIndex: 3658
{
	// Fields
	public int value__; // 0x0
	public const XsdDateTimeFlags DateTime = 1;
	public const XsdDateTimeFlags Time = 2;
	public const XsdDateTimeFlags Date = 4;
	public const XsdDateTimeFlags GYearMonth = 8;
	public const XsdDateTimeFlags GYear = 16;
	public const XsdDateTimeFlags GMonthDay = 32;
	public const XsdDateTimeFlags GDay = 64;
	public const XsdDateTimeFlags GMonth = 128;
	public const XsdDateTimeFlags XdrDateTimeNoTz = 256;
	public const XsdDateTimeFlags XdrDateTime = 512;
	public const XsdDateTimeFlags XdrTimeNoTz = 1024;
	public const XsdDateTimeFlags AllXsd = 255;
}

// Namespace: 
private enum XsdDateTime.DateTimeTypeCode // TypeDefIndex: 3659
{
	// Fields
	public int value__; // 0x0
	public const XsdDateTime.DateTimeTypeCode DateTime = 0;
	public const XsdDateTime.DateTimeTypeCode Time = 1;
	public const XsdDateTime.DateTimeTypeCode Date = 2;
	public const XsdDateTime.DateTimeTypeCode GYearMonth = 3;
	public const XsdDateTime.DateTimeTypeCode GYear = 4;
	public const XsdDateTime.DateTimeTypeCode GMonthDay = 5;
	public const XsdDateTime.DateTimeTypeCode GDay = 6;
	public const XsdDateTime.DateTimeTypeCode GMonth = 7;
	public const XsdDateTime.DateTimeTypeCode XdrDateTime = 8;
}

// Namespace: 
private enum XsdDateTime.XsdDateTimeKind // TypeDefIndex: 3660
{
	// Fields
	public int value__; // 0x0
	public const XsdDateTime.XsdDateTimeKind Unspecified = 0;
	public const XsdDateTime.XsdDateTimeKind Zulu = 1;
	public const XsdDateTime.XsdDateTimeKind LocalWestOfZulu = 2;
	public const XsdDateTime.XsdDateTimeKind LocalEastOfZulu = 3;
}

// Namespace: 
private struct XsdDateTime.Parser // TypeDefIndex: 3661
{
	// Fields
	public XsdDateTime.DateTimeTypeCode typeCode; // 0x0
	public int year; // 0x4
	public int month; // 0x8
	public int day; // 0xC
	public int hour; // 0x10
	public int minute; // 0x14
	public int second; // 0x18
	public int fraction; // 0x1C
	public XsdDateTime.XsdDateTimeKind kind; // 0x20
	public int zoneHour; // 0x24
	public int zoneMinute; // 0x28
	private string text; // 0x30
	private int length; // 0x38
	private static int[] Power10; // 0x0

	// Methods

	// RVA: 0x1C09344 Offset: 0x1C05344 VA: 0x1C09344
	public bool Parse(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x1C0BE34 Offset: 0x1C07E34 VA: 0x1C0BE34
	private bool ParseDate(int start) { }

	// RVA: 0x1C0C07C Offset: 0x1C0807C VA: 0x1C0C07C
	private bool ParseTimeAndZoneAndWhitespace(int start) { }

	// RVA: 0x1C0C36C Offset: 0x1C0836C VA: 0x1C0C36C
	private bool ParseTimeAndWhitespace(int start) { }

	// RVA: 0x1C0C5CC Offset: 0x1C085CC VA: 0x1C0C5CC
	private bool ParseTime(ref int start) { }

	// RVA: 0x1C0C118 Offset: 0x1C08118 VA: 0x1C0C118
	private bool ParseZoneAndWhitespace(int start) { }

	// RVA: 0x1C0C3F8 Offset: 0x1C083F8 VA: 0x1C0C3F8
	private bool Parse4Dig(int start, ref int num) { }

	// RVA: 0x1C0C524 Offset: 0x1C08524 VA: 0x1C0C524
	private bool Parse2Dig(int start, ref int num) { }

	// RVA: 0x1C0C038 Offset: 0x1C08038 VA: 0x1C0C038
	private bool ParseChar(int start, char ch) { }

	// RVA: 0x1C0BE28 Offset: 0x1C07E28 VA: 0x1C0BE28
	private static bool Test(XsdDateTimeFlags left, XsdDateTimeFlags right) { }

	// RVA: 0x1C0C928 Offset: 0x1C08928 VA: 0x1C0C928
	private static void .cctor() { }
}

// Namespace: System.Xml.Schema
internal struct XsdDateTime // TypeDefIndex: 3662
{
	// Fields
	private DateTime dt; // 0x0
	private uint extra; // 0x8
	private static readonly int Lzyyyy; // 0x0
	private static readonly int Lzyyyy_; // 0x4
	private static readonly int Lzyyyy_MM; // 0x8
	private static readonly int Lzyyyy_MM_; // 0xC
	private static readonly int Lzyyyy_MM_dd; // 0x10
	private static readonly int Lzyyyy_MM_ddT; // 0x14
	private static readonly int LzHH; // 0x18
	private static readonly int LzHH_; // 0x1C
	private static readonly int LzHH_mm; // 0x20
	private static readonly int LzHH_mm_; // 0x24
	private static readonly int LzHH_mm_ss; // 0x28
	private static readonly int Lz_; // 0x2C
	private static readonly int Lz_zz; // 0x30
	private static readonly int Lz_zz_; // 0x34
	private static readonly int Lz_zz_zz; // 0x38
	private static readonly int Lz__; // 0x3C
	private static readonly int Lz__mm; // 0x40
	private static readonly int Lz__mm_; // 0x44
	private static readonly int Lz__mm__; // 0x48
	private static readonly int Lz__mm_dd; // 0x4C
	private static readonly int Lz___; // 0x50
	private static readonly int Lz___dd; // 0x54
	private static readonly XmlTypeCode[] typeCodes; // 0x58

	// Properties
	private XsdDateTime.DateTimeTypeCode InternalTypeCode { get; }
	private XsdDateTime.XsdDateTimeKind InternalKind { get; }
	public int Year { get; }
	public int Month { get; }
	public int Day { get; }
	public int Hour { get; }
	public int Minute { get; }
	public int Second { get; }
	public int Fraction { get; }
	public int ZoneHour { get; }
	public int ZoneMinute { get; }

	// Methods

	// RVA: 0x1C091B4 Offset: 0x1C051B4 VA: 0x1C091B4
	public void .ctor(string text, XsdDateTimeFlags kinds) { }

	// RVA: 0x1C09F2C Offset: 0x1C05F2C VA: 0x1C09F2C
	private void .ctor(XsdDateTime.Parser parser) { }

	// RVA: 0x1C09E70 Offset: 0x1C05E70 VA: 0x1C09E70
	private void InitiateXsdDateTime(XsdDateTime.Parser parser) { }

	// RVA: 0x1C09FB0 Offset: 0x1C05FB0 VA: 0x1C09FB0
	internal static bool TryParse(string text, XsdDateTimeFlags kinds, out XsdDateTime result) { }

	// RVA: 0x1C0A070 Offset: 0x1C06070 VA: 0x1C0A070
	public void .ctor(DateTime dateTime, XsdDateTimeFlags kinds) { }

	// RVA: 0x1C0A244 Offset: 0x1C06244 VA: 0x1C0A244
	public void .ctor(DateTimeOffset dateTimeOffset) { }

	// RVA: 0x1C0A2B4 Offset: 0x1C062B4 VA: 0x1C0A2B4
	public void .ctor(DateTimeOffset dateTimeOffset, XsdDateTimeFlags kinds) { }

	// RVA: 0x1C0A448 Offset: 0x1C06448 VA: 0x1C0A448
	private XsdDateTime.DateTimeTypeCode get_InternalTypeCode() { }

	// RVA: 0x1C0A450 Offset: 0x1C06450 VA: 0x1C0A450
	private XsdDateTime.XsdDateTimeKind get_InternalKind() { }

	// RVA: 0x1C0A458 Offset: 0x1C06458 VA: 0x1C0A458
	public int get_Year() { }

	// RVA: 0x1C0A4B0 Offset: 0x1C064B0 VA: 0x1C0A4B0
	public int get_Month() { }

	// RVA: 0x1C0A508 Offset: 0x1C06508 VA: 0x1C0A508
	public int get_Day() { }

	// RVA: 0x1C0A560 Offset: 0x1C06560 VA: 0x1C0A560
	public int get_Hour() { }

	// RVA: 0x1C0A5B8 Offset: 0x1C065B8 VA: 0x1C0A5B8
	public int get_Minute() { }

	// RVA: 0x1C0A610 Offset: 0x1C06610 VA: 0x1C0A610
	public int get_Second() { }

	// RVA: 0x1C0A668 Offset: 0x1C06668 VA: 0x1C0A668
	public int get_Fraction() { }

	// RVA: 0x1C0A780 Offset: 0x1C06780 VA: 0x1C0A780
	public int get_ZoneHour() { }

	// RVA: 0x1C0A788 Offset: 0x1C06788 VA: 0x1C0A788
	public int get_ZoneMinute() { }

	// RVA: 0x1C0A790 Offset: 0x1C06790 VA: 0x1C0A790
	public static DateTime op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1C0ACAC Offset: 0x1C06CAC VA: 0x1C0ACAC
	public static DateTimeOffset op_Implicit(XsdDateTime xdt) { }

	// RVA: 0x1C0AFFC Offset: 0x1C06FFC VA: 0x1C0AFFC Slot: 3
	public override string ToString() { }

	// RVA: 0x1C0B46C Offset: 0x1C0746C VA: 0x1C0B46C
	private void PrintDate(StringBuilder sb) { }

	// RVA: 0x1C0B5B0 Offset: 0x1C075B0 VA: 0x1C0B5B0
	private void PrintTime(StringBuilder sb) { }

	// RVA: 0x1C0B8D0 Offset: 0x1C078D0 VA: 0x1C0B8D0
	private void PrintZone(StringBuilder sb) { }

	// RVA: 0x1C0B800 Offset: 0x1C07800 VA: 0x1C0B800
	private void IntToCharArray(char[] text, int start, int value, int digits) { }

	// RVA: 0x1C0B868 Offset: 0x1C07868 VA: 0x1C0B868
	private void ShortToCharArray(char[] text, int start, int value) { }

	// RVA: 0x1C0BA74 Offset: 0x1C07A74 VA: 0x1C0BA74
	private static void .cctor() { }
}

// Namespace: 
private enum XsdDuration.Parts // TypeDefIndex: 3663
{
	// Fields
	public int value__; // 0x0
	public const XsdDuration.Parts HasNone = 0;
	public const XsdDuration.Parts HasYears = 1;
	public const XsdDuration.Parts HasMonths = 2;
	public const XsdDuration.Parts HasDays = 4;
	public const XsdDuration.Parts HasHours = 8;
	public const XsdDuration.Parts HasMinutes = 16;
	public const XsdDuration.Parts HasSeconds = 32;
}

// Namespace: 
public enum XsdDuration.DurationType // TypeDefIndex: 3664
{
	// Fields
	public int value__; // 0x0
	public const XsdDuration.DurationType Duration = 0;
	public const XsdDuration.DurationType YearMonthDuration = 1;
	public const XsdDuration.DurationType DayTimeDuration = 2;
}

// Namespace: System.Xml.Schema
internal struct XsdDuration // TypeDefIndex: 3665
{
	// Fields
	private int years; // 0x0
	private int months; // 0x4
	private int days; // 0x8
	private int hours; // 0xC
	private int minutes; // 0x10
	private int seconds; // 0x14
	private uint nanoseconds; // 0x18

	// Properties
	public bool IsNegative { get; }
	public int Years { get; }
	public int Months { get; }
	public int Days { get; }
	public int Hours { get; }
	public int Minutes { get; }
	public int Seconds { get; }
	public int Nanoseconds { get; }

	// Methods

	// RVA: 0x1C0C9C8 Offset: 0x1C089C8 VA: 0x1C0C9C8
	public void .ctor(bool isNegative, int years, int months, int days, int hours, int minutes, int seconds, int nanoseconds) { }

	// RVA: 0x1C0CB24 Offset: 0x1C08B24 VA: 0x1C0CB24
	public void .ctor(TimeSpan timeSpan) { }

	// RVA: 0x1C0CB2C Offset: 0x1C08B2C VA: 0x1C0CB2C
	public void .ctor(TimeSpan timeSpan, XsdDuration.DurationType durationType) { }

	// RVA: 0x1C0CCF8 Offset: 0x1C08CF8 VA: 0x1C0CCF8
	public void .ctor(string s) { }

	// RVA: 0x1C0CD00 Offset: 0x1C08D00 VA: 0x1C0CD00
	public void .ctor(string s, XsdDuration.DurationType durationType) { }

	// RVA: 0x1C0D4FC Offset: 0x1C094FC VA: 0x1C0D4FC
	public bool get_IsNegative() { }

	// RVA: 0x1C0D508 Offset: 0x1C09508 VA: 0x1C0D508
	public int get_Years() { }

	// RVA: 0x1C0D510 Offset: 0x1C09510 VA: 0x1C0D510
	public int get_Months() { }

	// RVA: 0x1C0D518 Offset: 0x1C09518 VA: 0x1C0D518
	public int get_Days() { }

	// RVA: 0x1C0D520 Offset: 0x1C09520 VA: 0x1C0D520
	public int get_Hours() { }

	// RVA: 0x1C0D528 Offset: 0x1C09528 VA: 0x1C0D528
	public int get_Minutes() { }

	// RVA: 0x1C0D530 Offset: 0x1C09530 VA: 0x1C0D530
	public int get_Seconds() { }

	// RVA: 0x1C0D4F0 Offset: 0x1C094F0 VA: 0x1C0D4F0
	public int get_Nanoseconds() { }

	// RVA: 0x1C0D538 Offset: 0x1C09538 VA: 0x1C0D538
	public TimeSpan ToTimeSpan() { }

	// RVA: 0x1C0D540 Offset: 0x1C09540 VA: 0x1C0D540
	public TimeSpan ToTimeSpan(XsdDuration.DurationType durationType) { }

	// RVA: 0x1C0DA30 Offset: 0x1C09A30 VA: 0x1C0DA30
	internal Exception TryToTimeSpan(out TimeSpan result) { }

	// RVA: 0x1C0D588 Offset: 0x1C09588 VA: 0x1C0D588
	internal Exception TryToTimeSpan(XsdDuration.DurationType durationType, out TimeSpan result) { }

	// RVA: 0x1C0DA3C Offset: 0x1C09A3C VA: 0x1C0DA3C Slot: 3
	public override string ToString() { }

	// RVA: 0x1C0DA44 Offset: 0x1C09A44 VA: 0x1C0DA44
	internal string ToString(XsdDuration.DurationType durationType) { }

	// RVA: 0x1C0DE64 Offset: 0x1C09E64 VA: 0x1C0DE64
	internal static Exception TryParse(string s, out XsdDuration result) { }

	// RVA: 0x1C0CD74 Offset: 0x1C08D74 VA: 0x1C0CD74
	internal static Exception TryParse(string s, XsdDuration.DurationType durationType, out XsdDuration result) { }

	// RVA: 0x1C0DE70 Offset: 0x1C09E70 VA: 0x1C0DE70
	private static string TryParseDigits(string s, ref int offset, bool eatDigits, out int result, out int numDigits) { }
}

// Namespace: System.Xml.Schema
internal sealed class XsdValidator : BaseValidator // TypeDefIndex: 3666
{
	// Fields
	private int startIDConstraint; // 0x7C
	private HWStack validationStack; // 0x80
	private Hashtable attPresence; // 0x88
	private XmlNamespaceManager nsManager; // 0x90
	private bool bManageNamespaces; // 0x98
	private Hashtable IDs; // 0xA0
	private IdRefNode idRefListHead; // 0xA8
	private Parser inlineSchemaParser; // 0xB0
	private XmlSchemaContentProcessing processContents; // 0xB8
	private static readonly XmlSchemaDatatype dtCDATA; // 0x0
	private static readonly XmlSchemaDatatype dtQName; // 0x8
	private static readonly XmlSchemaDatatype dtStringArray; // 0x10
	private string NsXmlNs; // 0xC0
	private string NsXs; // 0xC8
	private string NsXsi; // 0xD0
	private string XsiType; // 0xD8
	private string XsiNil; // 0xE0
	private string XsiSchemaLocation; // 0xE8
	private string XsiNoNamespaceSchemaLocation; // 0xF0
	private string XsdSchema; // 0xF8

	// Properties
	private bool IsInlineSchemaStarted { get; }
	private bool HasSchema { get; }
	public override bool PreserveWhitespace { get; }
	private bool HasIdentityConstraints { get; }

	// Methods

	// RVA: 0x1C0E028 Offset: 0x1C0A028 VA: 0x1C0E028
	internal void .ctor(BaseValidator validator) { }

	// RVA: 0x1C0E434 Offset: 0x1C0A434 VA: 0x1C0E434
	internal void .ctor(XmlValidatingReaderImpl reader, XmlSchemaCollection schemaCollection, IValidationEventHandling eventHandling) { }

	// RVA: 0x1C0E04C Offset: 0x1C0A04C VA: 0x1C0E04C
	private void Init() { }

	// RVA: 0x1C0E590 Offset: 0x1C0A590 VA: 0x1C0E590 Slot: 5
	public override void Validate() { }

	// RVA: 0x1C0EC24 Offset: 0x1C0AC24 VA: 0x1C0EC24 Slot: 6
	public override void CompleteValidation() { }

	// RVA: 0x1C0E648 Offset: 0x1C0A648 VA: 0x1C0E648
	private bool get_IsInlineSchemaStarted() { }

	// RVA: 0x1C0E658 Offset: 0x1C0A658 VA: 0x1C0E658
	private void ProcessInlineSchema() { }

	// RVA: 0x1C0E8D8 Offset: 0x1C0A8D8 VA: 0x1C0E8D8
	private void ValidateElement() { }

	// RVA: 0x1C0ED4C Offset: 0x1C0AD4C VA: 0x1C0ED4C
	private object ValidateChildElement() { }

	// RVA: 0x1C0EF88 Offset: 0x1C0AF88 VA: 0x1C0EF88
	private void ProcessElement(object particle) { }

	// RVA: 0x1C0F294 Offset: 0x1C0B294 VA: 0x1C0F294
	private void ProcessXsiAttributes(out XmlQualifiedName xsiType, out string xsiNil) { }

	// RVA: 0x1C0EA44 Offset: 0x1C0AA44 VA: 0x1C0EA44
	private void ValidateEndElement() { }

	// RVA: 0x1C0F1B8 Offset: 0x1C0B1B8 VA: 0x1C0F1B8
	private SchemaElementDecl FastGetElementDecl(object particle) { }

	// RVA: 0x1C0FA64 Offset: 0x1C0BA64 VA: 0x1C0FA64
	private SchemaElementDecl ThoroughGetElementDecl(SchemaElementDecl elementDecl, XmlQualifiedName xsiType, string xsiNil) { }

	// RVA: 0x1C0FEB8 Offset: 0x1C0BEB8 VA: 0x1C0FEB8
	private void ValidateStartElement() { }

	// RVA: 0x1C105A0 Offset: 0x1C0C5A0 VA: 0x1C105A0
	private void ValidateEndStartElement() { }

	// RVA: 0x1C12024 Offset: 0x1C0E024 VA: 0x1C12024
	private void LoadSchemaFromLocation(string uri, string url) { }

	// RVA: 0x1C10980 Offset: 0x1C0C980 VA: 0x1C10980
	private void LoadSchema(string uri, string url) { }

	// RVA: 0x1C0FE4C Offset: 0x1C0BE4C VA: 0x1C0FE4C
	private bool get_HasSchema() { }

	// RVA: 0x1C12564 Offset: 0x1C0E564 VA: 0x1C12564 Slot: 4
	public override bool get_PreserveWhitespace() { }

	// RVA: 0x1C1259C Offset: 0x1C0E59C VA: 0x1C1259C
	private void ProcessTokenizedType(XmlTokenizedType ttype, string name) { }

	// RVA: 0x1C10B40 Offset: 0x1C0CB40 VA: 0x1C10B40
	private void CheckValue(string value, SchemaAttDef attdef) { }

	// RVA: 0x1C127C0 Offset: 0x1C0E7C0 VA: 0x1C127C0
	internal void AddID(string name, object node) { }

	// RVA: 0x1C1285C Offset: 0x1C0E85C VA: 0x1C1285C Slot: 7
	public override object FindId(string name) { }

	// RVA: 0x1C0EF38 Offset: 0x1C0AF38 VA: 0x1C0EF38
	public bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x1C0E458 Offset: 0x1C0A458 VA: 0x1C0E458
	private void Push(XmlQualifiedName elementName) { }

	// RVA: 0x1C11BF4 Offset: 0x1C0DBF4 VA: 0x1C11BF4
	private void Pop() { }

	// RVA: 0x1C0EC28 Offset: 0x1C0AC28 VA: 0x1C0EC28
	private void CheckForwardRefs() { }

	// RVA: 0x1C0FE6C Offset: 0x1C0BE6C VA: 0x1C0FE6C
	private void ValidateStartElementIdentityConstraints() { }

	// RVA: 0x1C10F8C Offset: 0x1C0CF8C VA: 0x1C10F8C
	private bool get_HasIdentityConstraints() { }

	// RVA: 0x1C12878 Offset: 0x1C0E878 VA: 0x1C12878
	private void AddIdentityConstraints() { }

	// RVA: 0x1C12C84 Offset: 0x1C0EC84 VA: 0x1C12C84
	private void ElementIdentityConstraints() { }

	// RVA: 0x1C11D4C Offset: 0x1C0DD4C VA: 0x1C11D4C
	private void AttributeIdentityConstraints(string name, string ns, object obj, string sobj, SchemaAttDef attdef) { }

	// RVA: 0x1C11CD4 Offset: 0x1C0DCD4 VA: 0x1C11CD4
	private object UnWrapUnion(object typedValue) { }

	// RVA: 0x1C10F9C Offset: 0x1C0CF9C VA: 0x1C10F9C
	private void EndElementIdentityConstraints() { }

	// RVA: 0x1C12FCC Offset: 0x1C0EFCC VA: 0x1C12FCC
	private static void .cctor() { }
}

// Namespace: 
public enum AstNode.AstType // TypeDefIndex: 3667
{
	// Fields
	public int value__; // 0x0
	public const AstNode.AstType Axis = 0;
	public const AstNode.AstType Operator = 1;
	public const AstNode.AstType Filter = 2;
	public const AstNode.AstType ConstantOperand = 3;
	public const AstNode.AstType Function = 4;
	public const AstNode.AstType Group = 5;
	public const AstNode.AstType Root = 6;
	public const AstNode.AstType Variable = 7;
	public const AstNode.AstType Error = 8;
}
