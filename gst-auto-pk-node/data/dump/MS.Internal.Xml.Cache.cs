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

// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo // TypeDefIndex: 3684
{
	// Fields
	private XPathNode[] _pageCurrent; // 0x10
	private XPathNode[] _pageParent; // 0x18
	private int _idxCurrent; // 0x20
	private int _idxParent; // 0x24

	// Properties
	public override string Value { get; }
	public override XPathNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override XmlNameTable NameTable { get; }
	public override object UnderlyingObject { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x1C17020 Offset: 0x1C13020 VA: 0x1C17020
	public void .ctor(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent) { }

	// RVA: 0x1C170C0 Offset: 0x1C130C0 VA: 0x1C170C0 Slot: 5
	public override string get_Value() { }

	// RVA: 0x1C174CC Offset: 0x1C134CC VA: 0x1C174CC Slot: 23
	public override XPathNavigator Clone() { }

	// RVA: 0x1C17540 Offset: 0x1C13540 VA: 0x1C17540 Slot: 24
	public override XPathNodeType get_NodeType() { }

	// RVA: 0x1C17584 Offset: 0x1C13584 VA: 0x1C17584 Slot: 25
	public override string get_LocalName() { }

	// RVA: 0x1C175D8 Offset: 0x1C135D8 VA: 0x1C175D8 Slot: 26
	public override string get_NamespaceURI() { }

	// RVA: 0x1C1762C Offset: 0x1C1362C VA: 0x1C1762C Slot: 27
	public override string get_Prefix() { }

	// RVA: 0x1C17680 Offset: 0x1C13680 VA: 0x1C17680 Slot: 19
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1C176DC Offset: 0x1C136DC VA: 0x1C176DC Slot: 30
	public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope) { }

	// RVA: 0x1C179FC Offset: 0x1C139FC VA: 0x1C179FC Slot: 31
	public override bool MoveToNextNamespace(XPathNamespaceScope scope) { }

	// RVA: 0x1C17B70 Offset: 0x1C13B70 VA: 0x1C17B70 Slot: 32
	public override bool MoveToParent() { }

	// RVA: 0x1C17C54 Offset: 0x1C13C54 VA: 0x1C17C54 Slot: 33
	public override bool IsSamePosition(XPathNavigator other) { }

	// RVA: 0x1C17CF4 Offset: 0x1C13CF4 VA: 0x1C17CF4 Slot: 28
	public override object get_UnderlyingObject() { }

	// RVA: 0x1C17D04 Offset: 0x1C13D04 VA: 0x1C17D04 Slot: 35
	public bool HasLineInfo() { }

	// RVA: 0x1C17D48 Offset: 0x1C13D48 VA: 0x1C17D48 Slot: 36
	public int get_LineNumber() { }

	// RVA: 0x1C17DF8 Offset: 0x1C13DF8 VA: 0x1C17DF8 Slot: 37
	public int get_LinePosition() { }

	// RVA: 0x1C17EF4 Offset: 0x1C13EF4 VA: 0x1C17EF4
	public int GetPositionHashCode() { }
}

// Namespace: MS.Internal.Xml.Cache
internal struct XPathNode // TypeDefIndex: 3685
{
	// Fields
	private XPathNodeInfoAtom _info; // 0x0
	private ushort _idxSibling; // 0x8
	private ushort _idxParent; // 0xA
	private ushort _idxSimilar; // 0xC
	private ushort _posOffset; // 0xE
	private uint _props; // 0x10
	private string _value; // 0x18

	// Properties
	public XPathNodeType NodeType { get; }
	public string Prefix { get; }
	public string LocalName { get; }
	public string NamespaceUri { get; }
	public XPathDocument Document { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public int CollapsedLinePosition { get; }
	public XPathNodePageInfo PageInfo { get; }
	public bool IsXmlNamespaceNode { get; }
	public bool HasSibling { get; }
	public bool HasCollapsedText { get; }
	public bool IsText { get; }
	public bool HasNamespaceDecls { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1C17578 Offset: 0x1C13578 VA: 0x1C17578
	public XPathNodeType get_NodeType() { }

	// RVA: 0x1C17668 Offset: 0x1C13668 VA: 0x1C17668
	public string get_Prefix() { }

	// RVA: 0x1C175C0 Offset: 0x1C135C0 VA: 0x1C175C0
	public string get_LocalName() { }

	// RVA: 0x1C17614 Offset: 0x1C13614 VA: 0x1C17614
	public string get_NamespaceUri() { }

	// RVA: 0x1C176C4 Offset: 0x1C136C4 VA: 0x1C176C4
	public XPathDocument get_Document() { }

	// RVA: 0x1C17DD4 Offset: 0x1C13DD4 VA: 0x1C17DD4
	public int get_LineNumber() { }

	// RVA: 0x1C17ED4 Offset: 0x1C13ED4 VA: 0x1C17ED4
	public int get_LinePosition() { }

	// RVA: 0x1C17EAC Offset: 0x1C13EAC VA: 0x1C17EAC
	public int get_CollapsedLinePosition() { }

	// RVA: 0x1C17F00 Offset: 0x1C13F00 VA: 0x1C17F00
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x1C17B3C Offset: 0x1C13B3C VA: 0x1C17B3C
	public int GetParent(out XPathNode[] pageNode) { }

	// RVA: 0x1C179C8 Offset: 0x1C139C8 VA: 0x1C179C8
	public int GetSibling(out XPathNode[] pageNode) { }

	// RVA: 0x1C17940 Offset: 0x1C13940 VA: 0x1C17940
	public bool get_IsXmlNamespaceNode() { }

	// RVA: 0x1C17F18 Offset: 0x1C13F18 VA: 0x1C17F18
	public bool get_HasSibling() { }

	// RVA: 0x1C17F28 Offset: 0x1C13F28 VA: 0x1C17F28
	public bool get_HasCollapsedText() { }

	// RVA: 0x1C17F34 Offset: 0x1C13F34 VA: 0x1C17F34
	public bool get_IsText() { }

	// RVA: 0x1C17F90 Offset: 0x1C13F90 VA: 0x1C17F90
	public bool get_HasNamespaceDecls() { }

	// RVA: 0x1C17F9C Offset: 0x1C13F9C VA: 0x1C17F9C
	public string get_Value() { }
}

// Namespace: MS.Internal.Xml.Cache
internal struct XPathNodeRef // TypeDefIndex: 3686
{
	// Fields
	private XPathNode[] _page; // 0x0
	private int _idx; // 0x8

	// Properties
	public XPathNode[] Page { get; }
	public int Index { get; }

	// Methods

	// RVA: 0x1C17FA4 Offset: 0x1C13FA4 VA: 0x1C17FA4
	public void .ctor(XPathNode[] page, int idx) { }

	// RVA: 0x1C17FCC Offset: 0x1C13FCC VA: 0x1C17FCC
	public XPathNode[] get_Page() { }

	// RVA: 0x1C17FD4 Offset: 0x1C13FD4 VA: 0x1C17FD4
	public int get_Index() { }

	// RVA: 0x1C17FDC Offset: 0x1C13FDC VA: 0x1C17FDC Slot: 2
	public override int GetHashCode() { }
}

// Namespace: MS.Internal.Xml.Cache
internal abstract class XPathNodeHelper // TypeDefIndex: 3687
{
	// Methods

	// RVA: 0x1C177E0 Offset: 0x1C137E0 VA: 0x1C177E0
	public static int GetLocalNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x1C1785C Offset: 0x1C1385C VA: 0x1C1785C
	public static int GetInScopeNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp) { }

	// RVA: 0x1C17BD8 Offset: 0x1C13BD8 VA: 0x1C17BD8
	public static bool GetParent(ref XPathNode[] pageNode, ref int idxNode) { }

	// RVA: 0x1C17FEC Offset: 0x1C13FEC VA: 0x1C17FEC
	public static int GetLocation(XPathNode[] pageNode, int idxNode) { }

	// RVA: 0x1C1735C Offset: 0x1C1335C VA: 0x1C1735C
	public static bool GetTextFollowing(ref XPathNode[] pageCurrent, ref int idxCurrent, XPathNode[] pageEnd, int idxEnd) { }

	// RVA: 0x1C172B0 Offset: 0x1C132B0 VA: 0x1C172B0
	public static bool GetNonDescendant(ref XPathNode[] pageNode, ref int idxNode) { }
}

// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathNodePageInfo // TypeDefIndex: 3688
{
	// Fields
	private int _pageNum; // 0x10
	private int _nodeCount; // 0x14
	private XPathNode[] _pageNext; // 0x18

	// Properties
	public int PageNumber { get; }
	public int NodeCount { get; }
	public XPathNode[] NextPage { get; }

	// Methods

	// RVA: 0x1C18024 Offset: 0x1C14024 VA: 0x1C18024
	public int get_PageNumber() { }

	// RVA: 0x1C1802C Offset: 0x1C1402C VA: 0x1C1802C
	public int get_NodeCount() { }

	// RVA: 0x1C18034 Offset: 0x1C14034 VA: 0x1C18034
	public XPathNode[] get_NextPage() { }
}

// Namespace: MS.Internal.Xml.Cache
internal sealed class XPathNodeInfoAtom // TypeDefIndex: 3689
{
	// Fields
	private string _localName; // 0x10
	private string _namespaceUri; // 0x18
	private string _prefix; // 0x20
	private XPathNode[] _pageParent; // 0x28
	private XPathNode[] _pageSibling; // 0x30
	private XPathDocument _doc; // 0x38
	private int _lineNumBase; // 0x40
	private int _linePosBase; // 0x44
	private XPathNodePageInfo _pageInfo; // 0x48

	// Properties
	public XPathNodePageInfo PageInfo { get; }
	public string LocalName { get; }
	public string NamespaceUri { get; }
	public string Prefix { get; }
	public XPathNode[] SiblingPage { get; }
	public XPathNode[] ParentPage { get; }
	public XPathDocument Document { get; }
	public int LineNumberBase { get; }
	public int LinePositionBase { get; }

	// Methods

	// RVA: 0x1C1803C Offset: 0x1C1403C VA: 0x1C1803C
	public XPathNodePageInfo get_PageInfo() { }

	// RVA: 0x1C18044 Offset: 0x1C14044 VA: 0x1C18044
	public string get_LocalName() { }

	// RVA: 0x1C1804C Offset: 0x1C1404C VA: 0x1C1804C
	public string get_NamespaceUri() { }

	// RVA: 0x1C18054 Offset: 0x1C14054 VA: 0x1C18054
	public string get_Prefix() { }

	// RVA: 0x1C1805C Offset: 0x1C1405C VA: 0x1C1805C
	public XPathNode[] get_SiblingPage() { }

	// RVA: 0x1C18064 Offset: 0x1C14064 VA: 0x1C18064
	public XPathNode[] get_ParentPage() { }

	// RVA: 0x1C1806C Offset: 0x1C1406C VA: 0x1C1806C
	public XPathDocument get_Document() { }

	// RVA: 0x1C18074 Offset: 0x1C14074 VA: 0x1C18074
	public int get_LineNumberBase() { }

	// RVA: 0x1C1807C Offset: 0x1C1407C VA: 0x1C1807C
	public int get_LinePositionBase() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 // TypeDefIndex: 3690
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 3691
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 // TypeDefIndex: 3692
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 3693
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 // TypeDefIndex: 3694
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 // TypeDefIndex: 3695
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 3696
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 // TypeDefIndex: 3697
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 // TypeDefIndex: 3698
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 // TypeDefIndex: 3699
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 // TypeDefIndex: 3700
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 // TypeDefIndex: 3701
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 3702
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 // TypeDefIndex: 3703
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 // TypeDefIndex: 3704
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 // TypeDefIndex: 3705
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 // TypeDefIndex: 3706
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=664 // TypeDefIndex: 3707
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 // TypeDefIndex: 3708
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1212 // TypeDefIndex: 3709
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 3710
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 0C682AB2EF0F1E326972C95528BBDE965F5D2DA9232E7A946F6E8A978A2871B5 /*Metadata offset 0x3E3CE8*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 11047585FE102FBB5CADB42446612A578D88C6EF5ED076BB7AC360C4F9E4373D /*Metadata offset 0x3E3D30*/; // 0x44
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 21AFB7EF8B4B88C006C54601484BC15AE5A8DBD2C0DD8C6622109208F8511B82 /*Metadata offset 0x3E3D40*/; // 0x50
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 24F70FC64555D9B7646AD4C0EEB8DF5286779F0E39C15ACA61305BC4A5E40BE6 /*Metadata offset 0x3E4108*/; // 0x410
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=144 28045F5AB2D9A9593F1D95B0FCB77E7F5F5435DD654BAFEF68972344B51C71BD /*Metadata offset 0x3E4138*/; // 0x438
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=112 28057B619BAF672A05E1585ED28F174E67FE946D81BDAA0691F07AB772057B02 /*Metadata offset 0x3E41D0*/; // 0x4C8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1212 2809A17B374DF1926EA539548F5B3750AA8ADB2BD59F5066AD6F9D439A231122 /*Metadata offset 0x3E4248*/; // 0x538
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 2AE470BFECE0EB971895252403237B3B989F74AD83E2B858E9CEA0482E776123 /*Metadata offset 0x3E4708*/; // 0x9F4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 2BA62518D59E3AF30E09E458218C4A05E5DFA2949B8B8F9B5E68CC793DBFA882 /*Metadata offset 0x3E4720*/; // 0xA08
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 2D902EC9D8EA71E1193C1C8315B1553D5154744F651BD366F1E1F437F6594A94 /*Metadata offset 0x3E4750*/; // 0xA30
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 3B3045573362001FA1CDA1F381A331DB2A88DD59FDD9C497404D59995AA377EA /*Metadata offset 0x3E4778*/; // 0xA54
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 3EB9B3AB77D567D5CEBF38C4C91CDF79845F0691D47A516CE6981BF091025179 /*Metadata offset 0x3E4788*/; // 0xA60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 499E4F5C84E20C7347E10100E0EC90C1945EA21C7C80809E4F7F474179B39DF6 /*Metadata offset 0x3E47A8*/; // 0xA78
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 540CD885F06B2760118EA5544E069ACE0C5D184B85D9D104417C14F1E536376D /*Metadata offset 0x3E47C8*/; // 0xA94
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=68 58E18897FE5FF048E82310FB4F57ADB2D53AEE59CB49B1E7094439808A1EF3F6 /*Metadata offset 0x3E47F0*/; // 0xABA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 5B7F03A977BE72EBD5C1702238238AEB01DFFB019B05EFAAC147EF886732EDC7 /*Metadata offset 0x3E4838*/; // 0xAFE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 652CA39E9310E001C2C4AF271610032A5638C58598F727066CCF4E666D424CD4 /*Metadata offset 0x3E4848*/; // 0xB0A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 6536D9B2447DFCF9BA37F9E5A7FAB08CB5552C5AD5B20E019AEC4872283A542A /*Metadata offset 0x3E4870*/; // 0xB2A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=960 77186ED8B389D5640B5AFAC4A22526ABA2422DCBE2986D0032E3B035D175758D /*Metadata offset 0x3E4898*/; // 0xB4E
	internal static readonly long 8A36CBC1D17EC6E1CCFE7D67F79FA9C8B2D7A41B04DD58A76970CEDC8189210D = 361700859878507267; // 0xF10
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 8D4DC488705859D6A837A660BDBA9E88D1BD229BC39DB97734072D04BD513ECD /*Metadata offset 0x3E4C70*/; // 0xF18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 92E9BC30656BF079FC6B0A200B019FF46941857D786F4C391470394CFDC95F0B /*Metadata offset 0x3E4C98*/; // 0xF3C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 9DA6B2C4638D1DC7611B7F458BBFE7FD49FE1B36B67239B00B8A051F4E49558F /*Metadata offset 0x3E4CC0*/; // 0xF5C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 AD6E77E234021D825C77689D82D414CDA3ABAE1ACC346D4BA2D6B1876CFC5FBC /*Metadata offset 0x3E4CE8*/; // 0xF7C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 B21FC5E8DB69C99CDEFB2C460E7C26D2D29A5ADC302365C59766D13688236919 /*Metadata offset 0x3E4D30*/; // 0xFBC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 B6E5AC1B0927F4259775820D36453E7BD957F110874896C133234263D312D88E /*Metadata offset 0x3E4D48*/; // 0xFD0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C332DD23F2CF4DE6107A93045ACACD787E2D9EB18B213298B98F23357F4FEA41 /*Metadata offset 0x3E4D78*/; // 0xFFC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 C3B2BED2599F3C79640DE44BA4EC7AEBB4856DBF74059DF382CF1D3026D272DA /*Metadata offset 0x3E4D90*/; // 0x100C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 D1D9AF18AFC4E3074AF5E4C44B81B73889D033D7AF6DFEB387BBCC76B36FE8B9 /*Metadata offset 0x3E4DA0*/; // 0x1018
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 DA285BBFE8FD0AA22C7CB92A1E911A4206CEDB14132FE3B6EE4DB32A42CAA41D /*Metadata offset 0x3E4F48*/; // 0x11B8
	internal static readonly long DACC0E6568D9B10337A1A693F10D42C3175E80C378154406C6FBFA989F919F51 = 3659217647501344; // 0x11D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 DB047CC748613CCCB120DE7385E37D542A79C3BF8F0E64FE6DAD349B4D26E5D7 /*Metadata offset 0x3E4F78*/; // 0x11D8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=416 DB7DD2341DB9D4574E432AAAFF03FB0A3E8FF2F645A337077EDF0C6FE902E660 /*Metadata offset 0x3E4FB8*/; // 0x1210
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 DBBF94CCF4250B303976041627BB8FC302CE57D55373C469F41F97318412037D /*Metadata offset 0x3E5160*/; // 0x13B0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=664 DD4E9C7C140CABCA5A25F4DA1F6F5BAC5D74E4568F954BF728471E711A35163E /*Metadata offset 0x3E5168*/; // 0x13B6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 EC3DA4AD81BE65581D24158F5E1FCDA45D908C27EC29FDFA744995062C501501 /*Metadata offset 0x3E5408*/; // 0x164E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 EE2DCBE09BA7FF21BF36DD7FC218E094C9B3EF228148D28D21D77A0FE51553C6 /*Metadata offset 0x3E5420*/; // 0x165E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 F1A5C5E949D525C31B086947AF16513F4999646B513457629847081D039048ED /*Metadata offset 0x3E5440*/; // 0x1676
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 FFF813C50ED1BEC943E2CA58860CC34E0A14A5C0E858B97C7670A384005CC064 /*Metadata offset 0x3E5458*/; // 0x1686

	// Methods

	// RVA: 0x1C18084 Offset: 0x1C14084 VA: 0x1C18084
	internal static uint ComputeStringHash(string s) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 3711
{}
