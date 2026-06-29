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

// Namespace: MS.Internal.Xml.XPath
internal abstract class AstNode // TypeDefIndex: 3668
{
	// Properties
	public abstract AstNode.AstType Type { get; }
	public abstract XPathResultType ReturnType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract AstNode.AstType get_Type();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract XPathResultType get_ReturnType();

	// RVA: 0x1C13090 Offset: 0x1C0F090 VA: 0x1C13090
	protected void .ctor() { }
}

// Namespace: 
public enum Axis.AxisType // TypeDefIndex: 3669
{
	// Fields
	public int value__; // 0x0
	public const Axis.AxisType Ancestor = 0;
	public const Axis.AxisType AncestorOrSelf = 1;
	public const Axis.AxisType Attribute = 2;
	public const Axis.AxisType Child = 3;
	public const Axis.AxisType Descendant = 4;
	public const Axis.AxisType DescendantOrSelf = 5;
	public const Axis.AxisType Following = 6;
	public const Axis.AxisType FollowingSibling = 7;
	public const Axis.AxisType Namespace = 8;
	public const Axis.AxisType Parent = 9;
	public const Axis.AxisType Preceding = 10;
	public const Axis.AxisType PrecedingSibling = 11;
	public const Axis.AxisType Self = 12;
	public const Axis.AxisType None = 13;
}

// Namespace: MS.Internal.Xml.XPath
internal class Axis : AstNode // TypeDefIndex: 3670
{
	// Fields
	private Axis.AxisType _axisType; // 0x10
	private AstNode _input; // 0x18
	private string _prefix; // 0x20
	private string _name; // 0x28
	private XPathNodeType _nodeType; // 0x30
	protected bool abbrAxis; // 0x34
	private string _urn; // 0x38

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }
	public AstNode Input { get; set; }
	public string Prefix { get; }
	public string Name { get; }
	public XPathNodeType NodeType { get; }
	public Axis.AxisType TypeOfAxis { get; }
	public bool AbbrAxis { get; }
	public string Urn { get; set; }

	// Methods

	// RVA: 0x1C13098 Offset: 0x1C0F098 VA: 0x1C13098
	public void .ctor(Axis.AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype) { }

	// RVA: 0x1C13134 Offset: 0x1C0F134 VA: 0x1C13134
	public void .ctor(Axis.AxisType axisType, AstNode input) { }

	// RVA: 0x1C1316C Offset: 0x1C0F16C VA: 0x1C1316C Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x1C13174 Offset: 0x1C0F174 VA: 0x1C13174 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1C1317C Offset: 0x1C0F17C VA: 0x1C1317C
	public AstNode get_Input() { }

	// RVA: 0x1C13184 Offset: 0x1C0F184 VA: 0x1C13184
	public void set_Input(AstNode value) { }

	// RVA: 0x1C1318C Offset: 0x1C0F18C VA: 0x1C1318C
	public string get_Prefix() { }

	// RVA: 0x1C13194 Offset: 0x1C0F194 VA: 0x1C13194
	public string get_Name() { }

	// RVA: 0x1C1319C Offset: 0x1C0F19C VA: 0x1C1319C
	public XPathNodeType get_NodeType() { }

	// RVA: 0x1C131A4 Offset: 0x1C0F1A4 VA: 0x1C131A4
	public Axis.AxisType get_TypeOfAxis() { }

	// RVA: 0x1C131AC Offset: 0x1C0F1AC VA: 0x1C131AC
	public bool get_AbbrAxis() { }

	// RVA: 0x1C131B4 Offset: 0x1C0F1B4 VA: 0x1C131B4
	public string get_Urn() { }

	// RVA: 0x1C131BC Offset: 0x1C0F1BC VA: 0x1C131BC
	public void set_Urn(string value) { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Filter : AstNode // TypeDefIndex: 3671
{
	// Fields
	private AstNode _input; // 0x10
	private AstNode _condition; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x1C131C4 Offset: 0x1C0F1C4 VA: 0x1C131C4
	public void .ctor(AstNode input, AstNode condition) { }

	// RVA: 0x1C13208 Offset: 0x1C0F208 VA: 0x1C13208 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x1C13210 Offset: 0x1C0F210 VA: 0x1C13210 Slot: 5
	public override XPathResultType get_ReturnType() { }
}

// Namespace: 
public enum Function.FunctionType // TypeDefIndex: 3672
{
	// Fields
	public int value__; // 0x0
	public const Function.FunctionType FuncLast = 0;
	public const Function.FunctionType FuncPosition = 1;
	public const Function.FunctionType FuncCount = 2;
	public const Function.FunctionType FuncID = 3;
	public const Function.FunctionType FuncLocalName = 4;
	public const Function.FunctionType FuncNameSpaceUri = 5;
	public const Function.FunctionType FuncName = 6;
	public const Function.FunctionType FuncString = 7;
	public const Function.FunctionType FuncBoolean = 8;
	public const Function.FunctionType FuncNumber = 9;
	public const Function.FunctionType FuncTrue = 10;
	public const Function.FunctionType FuncFalse = 11;
	public const Function.FunctionType FuncNot = 12;
	public const Function.FunctionType FuncConcat = 13;
	public const Function.FunctionType FuncStartsWith = 14;
	public const Function.FunctionType FuncContains = 15;
	public const Function.FunctionType FuncSubstringBefore = 16;
	public const Function.FunctionType FuncSubstringAfter = 17;
	public const Function.FunctionType FuncSubstring = 18;
	public const Function.FunctionType FuncStringLength = 19;
	public const Function.FunctionType FuncNormalize = 20;
	public const Function.FunctionType FuncTranslate = 21;
	public const Function.FunctionType FuncLang = 22;
	public const Function.FunctionType FuncSum = 23;
	public const Function.FunctionType FuncFloor = 24;
	public const Function.FunctionType FuncCeiling = 25;
	public const Function.FunctionType FuncRound = 26;
	public const Function.FunctionType FuncUserDefined = 27;
}

// Namespace: MS.Internal.Xml.XPath
internal class Function : AstNode // TypeDefIndex: 3673
{
	// Fields
	private Function.FunctionType _functionType; // 0x10
	private List<AstNode> _argumentList; // 0x18
	private string _name; // 0x20
	private string _prefix; // 0x28
	internal static XPathResultType[] ReturnTypes; // 0x0

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x1C13218 Offset: 0x1C0F218 VA: 0x1C13218
	public void .ctor(Function.FunctionType ftype, List<AstNode> argumentList) { }

	// RVA: 0x1C132B8 Offset: 0x1C0F2B8 VA: 0x1C132B8
	public void .ctor(string prefix, string name, List<AstNode> argumentList) { }

	// RVA: 0x1C13380 Offset: 0x1C0F380 VA: 0x1C13380
	public void .ctor(Function.FunctionType ftype, AstNode arg) { }

	// RVA: 0x1C134A4 Offset: 0x1C0F4A4 VA: 0x1C134A4 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x1C134AC Offset: 0x1C0F4AC VA: 0x1C134AC Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1C1352C Offset: 0x1C0F52C VA: 0x1C1352C
	private static void .cctor() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Group : AstNode // TypeDefIndex: 3674
{
	// Fields
	private AstNode _groupNode; // 0x10

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x1C135CC Offset: 0x1C0F5CC VA: 0x1C135CC
	public void .ctor(AstNode groupNode) { }

	// RVA: 0x1C135FC Offset: 0x1C0F5FC VA: 0x1C135FC Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x1C13604 Offset: 0x1C0F604 VA: 0x1C13604 Slot: 5
	public override XPathResultType get_ReturnType() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Operand : AstNode // TypeDefIndex: 3675
{
	// Fields
	private XPathResultType _type; // 0x10
	private object _val; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x1C1360C Offset: 0x1C0F60C VA: 0x1C1360C
	public void .ctor(string val) { }

	// RVA: 0x1C13644 Offset: 0x1C0F644 VA: 0x1C13644
	public void .ctor(double val) { }

	// RVA: 0x1C13694 Offset: 0x1C0F694 VA: 0x1C13694 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x1C1369C Offset: 0x1C0F69C VA: 0x1C1369C Slot: 5
	public override XPathResultType get_ReturnType() { }
}

// Namespace: 
public enum Operator.Op // TypeDefIndex: 3676
{
	// Fields
	public int value__; // 0x0
	public const Operator.Op INVALID = 0;
	public const Operator.Op OR = 1;
	public const Operator.Op AND = 2;
	public const Operator.Op EQ = 3;
	public const Operator.Op NE = 4;
	public const Operator.Op LT = 5;
	public const Operator.Op LE = 6;
	public const Operator.Op GT = 7;
	public const Operator.Op GE = 8;
	public const Operator.Op PLUS = 9;
	public const Operator.Op MINUS = 10;
	public const Operator.Op MUL = 11;
	public const Operator.Op DIV = 12;
	public const Operator.Op MOD = 13;
	public const Operator.Op UNION = 14;
}

// Namespace: MS.Internal.Xml.XPath
internal class Operator : AstNode // TypeDefIndex: 3677
{
	// Fields
	private static Operator.Op[] s_invertOp; // 0x0
	private Operator.Op _opType; // 0x10
	private AstNode _opnd1; // 0x18
	private AstNode _opnd2; // 0x20

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x1C136A4 Offset: 0x1C0F6A4 VA: 0x1C136A4
	public void .ctor(Operator.Op op, AstNode opnd1, AstNode opnd2) { }

	// RVA: 0x1C136F8 Offset: 0x1C0F6F8 VA: 0x1C136F8 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x1C13700 Offset: 0x1C0F700 VA: 0x1C13700 Slot: 5
	public override XPathResultType get_ReturnType() { }

	// RVA: 0x1C13720 Offset: 0x1C0F720 VA: 0x1C13720
	private static void .cctor() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Root : AstNode // TypeDefIndex: 3678
{
	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x1C137C0 Offset: 0x1C0F7C0 VA: 0x1C137C0
	public void .ctor() { }

	// RVA: 0x1C137C8 Offset: 0x1C0F7C8 VA: 0x1C137C8 Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x1C137D0 Offset: 0x1C0F7D0 VA: 0x1C137D0 Slot: 5
	public override XPathResultType get_ReturnType() { }
}

// Namespace: MS.Internal.Xml.XPath
internal class Variable : AstNode // TypeDefIndex: 3679
{
	// Fields
	private string _localname; // 0x10
	private string _prefix; // 0x18

	// Properties
	public override AstNode.AstType Type { get; }
	public override XPathResultType ReturnType { get; }

	// Methods

	// RVA: 0x1C137D8 Offset: 0x1C0F7D8 VA: 0x1C137D8
	public void .ctor(string name, string prefix) { }

	// RVA: 0x1C1381C Offset: 0x1C0F81C VA: 0x1C1381C Slot: 4
	public override AstNode.AstType get_Type() { }

	// RVA: 0x1C13824 Offset: 0x1C0F824 VA: 0x1C13824 Slot: 5
	public override XPathResultType get_ReturnType() { }
}

// Namespace: 
private class XPathParser.ParamInfo // TypeDefIndex: 3680
{
	// Fields
	private Function.FunctionType _ftype; // 0x10
	private int _minargs; // 0x14
	private int _maxargs; // 0x18
	private XPathResultType[] _argTypes; // 0x20

	// Properties
	public Function.FunctionType FType { get; }
	public int Minargs { get; }
	public int Maxargs { get; }
	public XPathResultType[] ArgTypes { get; }

	// Methods

	// RVA: 0x1C16C8C Offset: 0x1C12C8C VA: 0x1C16C8C
	public Function.FunctionType get_FType() { }

	// RVA: 0x1C16C94 Offset: 0x1C12C94 VA: 0x1C16C94
	public int get_Minargs() { }

	// RVA: 0x1C16C9C Offset: 0x1C12C9C VA: 0x1C16C9C
	public int get_Maxargs() { }

	// RVA: 0x1C16CA4 Offset: 0x1C12CA4 VA: 0x1C16CA4
	public XPathResultType[] get_ArgTypes() { }

	// RVA: 0x1C166D4 Offset: 0x1C126D4 VA: 0x1C166D4
	internal void .ctor(Function.FunctionType ftype, int minargs, int maxargs, XPathResultType[] argTypes) { }
}

// Namespace: MS.Internal.Xml.XPath
internal class XPathParser // TypeDefIndex: 3681
{
	// Fields
	private XPathScanner _scanner; // 0x10
	private int _parseDepth; // 0x18
	private static readonly XPathResultType[] s_temparray1; // 0x0
	private static readonly XPathResultType[] s_temparray2; // 0x8
	private static readonly XPathResultType[] s_temparray3; // 0x10
	private static readonly XPathResultType[] s_temparray4; // 0x18
	private static readonly XPathResultType[] s_temparray5; // 0x20
	private static readonly XPathResultType[] s_temparray6; // 0x28
	private static readonly XPathResultType[] s_temparray7; // 0x30
	private static readonly XPathResultType[] s_temparray8; // 0x38
	private static readonly XPathResultType[] s_temparray9; // 0x40
	private static Dictionary<string, XPathParser.ParamInfo> s_functionTable; // 0x48
	private static Dictionary<string, Axis.AxisType> s_AxesTable; // 0x50

	// Methods

	// RVA: 0x1C1382C Offset: 0x1C0F82C VA: 0x1C1382C
	private void .ctor(XPathScanner scanner) { }

	// RVA: 0x1C1385C Offset: 0x1C0F85C VA: 0x1C1385C
	public static AstNode ParseXPathExpression(string xpathExpression) { }

	// RVA: 0x1C13A04 Offset: 0x1C0FA04 VA: 0x1C13A04
	private AstNode ParseExpression(AstNode qyInput) { }

	// RVA: 0x1C13A68 Offset: 0x1C0FA68 VA: 0x1C13A68
	private AstNode ParseOrExpr(AstNode qyInput) { }

	// RVA: 0x1C13B50 Offset: 0x1C0FB50 VA: 0x1C13B50
	private AstNode ParseAndExpr(AstNode qyInput) { }

	// RVA: 0x1C13C98 Offset: 0x1C0FC98 VA: 0x1C13C98
	private AstNode ParseEqualityExpr(AstNode qyInput) { }

	// RVA: 0x1C13D70 Offset: 0x1C0FD70 VA: 0x1C13D70
	private AstNode ParseRelationalExpr(AstNode qyInput) { }

	// RVA: 0x1C13E70 Offset: 0x1C0FE70 VA: 0x1C13E70
	private AstNode ParseAdditiveExpr(AstNode qyInput) { }

	// RVA: 0x1C13F48 Offset: 0x1C0FF48 VA: 0x1C13F48
	private AstNode ParseMultiplicativeExpr(AstNode qyInput) { }

	// RVA: 0x1C14074 Offset: 0x1C10074 VA: 0x1C14074
	private AstNode ParseUnaryExpr(AstNode qyInput) { }

	// RVA: 0x1C14144 Offset: 0x1C10144 VA: 0x1C14144
	private AstNode ParseUnionExpr(AstNode qyInput) { }

	// RVA: 0x1C143DC Offset: 0x1C103DC VA: 0x1C143DC
	private static bool IsNodeType(XPathScanner scaner) { }

	// RVA: 0x1C14244 Offset: 0x1C10244 VA: 0x1C14244
	private AstNode ParsePathExpr(AstNode qyInput) { }

	// RVA: 0x1C14580 Offset: 0x1C10580 VA: 0x1C14580
	private AstNode ParseFilterExpr(AstNode qyInput) { }

	// RVA: 0x1C14AA8 Offset: 0x1C10AA8 VA: 0x1C14AA8
	private AstNode ParsePredicate(AstNode qyInput) { }

	// RVA: 0x1C14724 Offset: 0x1C10724 VA: 0x1C14724
	private AstNode ParseLocationPath(AstNode qyInput) { }

	// RVA: 0x1C14630 Offset: 0x1C10630 VA: 0x1C14630
	private AstNode ParseRelativeLocationPath(AstNode qyInput) { }

	// RVA: 0x1C14B34 Offset: 0x1C10B34 VA: 0x1C14B34
	private static bool IsStep(XPathScanner.LexKind lexKind) { }

	// RVA: 0x1C14B74 Offset: 0x1C10B74 VA: 0x1C14B74
	private AstNode ParseStep(AstNode qyInput) { }

	// RVA: 0x1C14DFC Offset: 0x1C10DFC VA: 0x1C14DFC
	private AstNode ParseNodeTest(AstNode qyInput, Axis.AxisType axisType, XPathNodeType nodeType) { }

	// RVA: 0x1C144D0 Offset: 0x1C104D0 VA: 0x1C144D0
	private static bool IsPrimaryExpr(XPathScanner scanner) { }

	// RVA: 0x1C14888 Offset: 0x1C10888 VA: 0x1C14888
	private AstNode ParsePrimaryExpr(AstNode qyInput) { }

	// RVA: 0x1C15154 Offset: 0x1C11154 VA: 0x1C15154
	private AstNode ParseMethod(AstNode qyInput) { }

	// RVA: 0x1C150F0 Offset: 0x1C110F0 VA: 0x1C150F0
	private void CheckToken(XPathScanner.LexKind t) { }

	// RVA: 0x1C14B14 Offset: 0x1C10B14 VA: 0x1C14B14
	private void PassToken(XPathScanner.LexKind t) { }

	// RVA: 0x1C13C84 Offset: 0x1C0FC84 VA: 0x1C13C84
	private void NextLex() { }

	// RVA: 0x1C13C38 Offset: 0x1C0FC38 VA: 0x1C13C38
	private bool TestOp(string op) { }

	// RVA: 0x1C14380 Offset: 0x1C10380 VA: 0x1C14380
	private void CheckNodeSet(XPathResultType t) { }

	// RVA: 0x1C15AF4 Offset: 0x1C11AF4 VA: 0x1C15AF4
	private static Dictionary<string, XPathParser.ParamInfo> CreateFunctionTable() { }

	// RVA: 0x1C16720 Offset: 0x1C12720 VA: 0x1C16720
	private static Dictionary<string, Axis.AxisType> CreateAxesTable() { }

	// RVA: 0x1C14D14 Offset: 0x1C10D14 VA: 0x1C14D14
	private Axis.AxisType GetAxis() { }

	// RVA: 0x1C169D0 Offset: 0x1C129D0 VA: 0x1C169D0
	private static void .cctor() { }
}

// Namespace: 
public enum XPathScanner.LexKind // TypeDefIndex: 3682
{
	// Fields
	public int value__; // 0x0
	public const XPathScanner.LexKind Comma = 44;
	public const XPathScanner.LexKind Slash = 47;
	public const XPathScanner.LexKind At = 64;
	public const XPathScanner.LexKind Dot = 46;
	public const XPathScanner.LexKind LParens = 40;
	public const XPathScanner.LexKind RParens = 41;
	public const XPathScanner.LexKind LBracket = 91;
	public const XPathScanner.LexKind RBracket = 93;
	public const XPathScanner.LexKind Star = 42;
	public const XPathScanner.LexKind Plus = 43;
	public const XPathScanner.LexKind Minus = 45;
	public const XPathScanner.LexKind Eq = 61;
	public const XPathScanner.LexKind Lt = 60;
	public const XPathScanner.LexKind Gt = 62;
	public const XPathScanner.LexKind Bang = 33;
	public const XPathScanner.LexKind Dollar = 36;
	public const XPathScanner.LexKind Apos = 39;
	public const XPathScanner.LexKind Quote = 34;
	public const XPathScanner.LexKind Union = 124;
	public const XPathScanner.LexKind Ne = 78;
	public const XPathScanner.LexKind Le = 76;
	public const XPathScanner.LexKind Ge = 71;
	public const XPathScanner.LexKind And = 65;
	public const XPathScanner.LexKind Or = 79;
	public const XPathScanner.LexKind DotDot = 68;
	public const XPathScanner.LexKind SlashSlash = 83;
	public const XPathScanner.LexKind Name = 110;
	public const XPathScanner.LexKind String = 115;
	public const XPathScanner.LexKind Number = 100;
	public const XPathScanner.LexKind Axe = 97;
	public const XPathScanner.LexKind Eof = 69;
}

// Namespace: MS.Internal.Xml.XPath
internal sealed class XPathScanner // TypeDefIndex: 3683
{
	// Fields
	private string _xpathExpr; // 0x10
	private int _xpathExprIndex; // 0x18
	private XPathScanner.LexKind _kind; // 0x1C
	private char _currentChar; // 0x20
	private string _name; // 0x28
	private string _prefix; // 0x30
	private string _stringValue; // 0x38
	private double _numberValue; // 0x40
	private bool _canBeFunction; // 0x48
	private XmlCharType _xmlCharType; // 0x50

	// Properties
	public string SourceText { get; }
	private char CurrentChar { get; }
	public XPathScanner.LexKind Kind { get; }
	public string Name { get; }
	public string Prefix { get; }
	public string StringValue { get; }
	public double NumberValue { get; }
	public bool CanBeFunction { get; }

	// Methods

	// RVA: 0x1C13950 Offset: 0x1C0F950 VA: 0x1C13950
	public void .ctor(string xpathExpr) { }

	// RVA: 0x1C16D0C Offset: 0x1C12D0C VA: 0x1C16D0C
	public string get_SourceText() { }

	// RVA: 0x1C16D14 Offset: 0x1C12D14 VA: 0x1C16D14
	private char get_CurrentChar() { }

	// RVA: 0x1C16CAC Offset: 0x1C12CAC VA: 0x1C16CAC
	private bool NextChar() { }

	// RVA: 0x1C16D1C Offset: 0x1C12D1C VA: 0x1C16D1C
	public XPathScanner.LexKind get_Kind() { }

	// RVA: 0x1C16D24 Offset: 0x1C12D24 VA: 0x1C16D24
	public string get_Name() { }

	// RVA: 0x1C16D2C Offset: 0x1C12D2C VA: 0x1C16D2C
	public string get_Prefix() { }

	// RVA: 0x1C16D34 Offset: 0x1C12D34 VA: 0x1C16D34
	public string get_StringValue() { }

	// RVA: 0x1C16D3C Offset: 0x1C12D3C VA: 0x1C16D3C
	public double get_NumberValue() { }

	// RVA: 0x1C16D44 Offset: 0x1C12D44 VA: 0x1C16D44
	public bool get_CanBeFunction() { }

	// RVA: 0x1C16D4C Offset: 0x1C12D4C VA: 0x1C16D4C
	private void SkipSpace() { }

	// RVA: 0x1C156B8 Offset: 0x1C116B8 VA: 0x1C156B8
	public bool NextLex() { }

	// RVA: 0x1C16EDC Offset: 0x1C12EDC VA: 0x1C16EDC
	private double ScanNumber() { }

	// RVA: 0x1C16D7C Offset: 0x1C12D7C VA: 0x1C16D7C
	private double ScanFraction() { }

	// RVA: 0x1C16E2C Offset: 0x1C12E2C VA: 0x1C16E2C
	private string ScanString() { }

	// RVA: 0x1C16FB4 Offset: 0x1C12FB4 VA: 0x1C16FB4
	private string ScanName() { }
}
