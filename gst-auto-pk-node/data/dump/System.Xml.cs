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

// Namespace: System.Xml
[Extension]
internal static class AsyncHelper // TypeDefIndex: 3048
{
	// Fields
	public static readonly Task DoneTask; // 0x0
	public static readonly Task<bool> DoneTaskTrue; // 0x8
	public static readonly Task<bool> DoneTaskFalse; // 0x10
	public static readonly Task<int> DoneTaskZero; // 0x18

	// Methods

	// RVA: 0x1B3EE8C Offset: 0x1B3AE8C VA: 0x1B3EE8C
	private static void .cctor() { }
}

// Namespace: System.Xml
internal abstract class Base64Encoder // TypeDefIndex: 3049
{
	// Fields
	private byte[] leftOverBytes; // 0x10
	private int leftOverBytesCount; // 0x18
	private char[] charsLine; // 0x20

	// Methods

	// RVA: 0x1B3EFA4 Offset: 0x1B3AFA4 VA: 0x1B3EFA4
	internal void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void WriteChars(char[] chars, int index, int count);

	// RVA: 0x1B3F008 Offset: 0x1B3B008 VA: 0x1B3F008
	internal void Encode(byte[] buffer, int index, int count) { }

	// RVA: 0x1B3F35C Offset: 0x1B3B35C VA: 0x1B3F35C
	internal void Flush() { }
}

// Namespace: System.Xml
internal class XmlRawWriterBase64Encoder : Base64Encoder // TypeDefIndex: 3050
{
	// Fields
	private XmlRawWriter rawWriter; // 0x28

	// Methods

	// RVA: 0x1B3F404 Offset: 0x1B3B404 VA: 0x1B3F404
	internal void .ctor(XmlRawWriter rawWriter) { }

	// RVA: 0x1B3F430 Offset: 0x1B3B430 VA: 0x1B3F430 Slot: 4
	internal override void WriteChars(char[] chars, int index, int count) { }
}

// Namespace: System.Xml
internal class XmlTextWriterBase64Encoder : Base64Encoder // TypeDefIndex: 3051
{
	// Fields
	private XmlTextEncoder xmlTextEncoder; // 0x28

	// Methods

	// RVA: 0x1B3F450 Offset: 0x1B3B450 VA: 0x1B3F450
	internal void .ctor(XmlTextEncoder xmlTextEncoder) { }

	// RVA: 0x1B3F47C Offset: 0x1B3B47C VA: 0x1B3F47C Slot: 4
	internal override void WriteChars(char[] chars, int index, int count) { }
}

// Namespace: System.Xml
internal class BinHexDecoder : IncrementalReadDecoder // TypeDefIndex: 3052
{
	// Fields
	private byte[] buffer; // 0x10
	private int curIndex; // 0x18
	private int endIndex; // 0x1C
	private bool hasHalfByteCached; // 0x20
	private byte cachedHalfByte; // 0x21

	// Properties
	internal override bool IsFull { get; }

	// Methods

	// RVA: 0x1B3F494 Offset: 0x1B3B494 VA: 0x1B3F494 Slot: 4
	internal override bool get_IsFull() { }

	// RVA: 0x1B3F4A4 Offset: 0x1B3B4A4 VA: 0x1B3F4A4 Slot: 5
	internal override int Decode(char[] chars, int startPos, int len) { }

	// RVA: 0x1B3F7BC Offset: 0x1B3B7BC VA: 0x1B3F7BC
	public static byte[] Decode(char[] chars, bool allowOddChars) { }

	// RVA: 0x1B3F5F4 Offset: 0x1B3B5F4 VA: 0x1B3F5F4
	private static void Decode(char* pChars, char* pCharsEndPos, byte* pBytes, byte* pBytesEndPos, ref bool hasHalfByteCached, ref byte cachedHalfByte, out int charsDecoded, out int bytesDecoded) { }
}

// Namespace: System.Xml
internal static class BinHexEncoder // TypeDefIndex: 3053
{
	// Methods

	// RVA: 0x1B3F9A4 Offset: 0x1B3B9A4 VA: 0x1B3F9A4
	internal static void Encode(byte[] buffer, int index, int count, XmlWriter writer) { }

	// RVA: 0x1B3FC78 Offset: 0x1B3BC78 VA: 0x1B3FC78
	internal static string Encode(byte[] inArray, int offsetIn, int count) { }

	// RVA: 0x1B3FB40 Offset: 0x1B3BB40 VA: 0x1B3FB40
	private static int Encode(byte[] inArray, int offsetIn, int count, char[] outArray) { }
}

// Namespace: System.Xml
internal enum BinXmlToken // TypeDefIndex: 3054
{
	// Fields
	public int value__; // 0x0
	public const BinXmlToken Error = 0;
	public const BinXmlToken NotImpl = -2;
	public const BinXmlToken EOF = -1;
	public const BinXmlToken XmlDecl = 254;
	public const BinXmlToken Encoding = 253;
	public const BinXmlToken DocType = 252;
	public const BinXmlToken System = 251;
	public const BinXmlToken Public = 250;
	public const BinXmlToken Subset = 249;
	public const BinXmlToken Element = 248;
	public const BinXmlToken EndElem = 247;
	public const BinXmlToken Attr = 246;
	public const BinXmlToken EndAttrs = 245;
	public const BinXmlToken PI = 244;
	public const BinXmlToken Comment = 243;
	public const BinXmlToken CData = 242;
	public const BinXmlToken EndCData = 241;
	public const BinXmlToken Name = 240;
	public const BinXmlToken QName = 239;
	public const BinXmlToken XmlText = 237;
	public const BinXmlToken Nest = 236;
	public const BinXmlToken EndNest = 235;
	public const BinXmlToken Extn = 234;
	public const BinXmlToken NmFlush = 233;
	public const BinXmlToken SQL_BIT = 6;
	public const BinXmlToken SQL_TINYINT = 7;
	public const BinXmlToken SQL_SMALLINT = 1;
	public const BinXmlToken SQL_INT = 2;
	public const BinXmlToken SQL_BIGINT = 8;
	public const BinXmlToken SQL_REAL = 3;
	public const BinXmlToken SQL_FLOAT = 4;
	public const BinXmlToken SQL_MONEY = 5;
	public const BinXmlToken SQL_SMALLMONEY = 20;
	public const BinXmlToken SQL_DATETIME = 18;
	public const BinXmlToken SQL_SMALLDATETIME = 19;
	public const BinXmlToken SQL_DECIMAL = 10;
	public const BinXmlToken SQL_NUMERIC = 11;
	public const BinXmlToken SQL_UUID = 9;
	public const BinXmlToken SQL_VARBINARY = 15;
	public const BinXmlToken SQL_BINARY = 12;
	public const BinXmlToken SQL_IMAGE = 23;
	public const BinXmlToken SQL_CHAR = 13;
	public const BinXmlToken SQL_VARCHAR = 16;
	public const BinXmlToken SQL_TEXT = 22;
	public const BinXmlToken SQL_NVARCHAR = 17;
	public const BinXmlToken SQL_NCHAR = 14;
	public const BinXmlToken SQL_NTEXT = 24;
	public const BinXmlToken SQL_UDT = 27;
	public const BinXmlToken XSD_KATMAI_DATE = 127;
	public const BinXmlToken XSD_KATMAI_DATETIME = 126;
	public const BinXmlToken XSD_KATMAI_TIME = 125;
	public const BinXmlToken XSD_KATMAI_DATEOFFSET = 124;
	public const BinXmlToken XSD_KATMAI_DATETIMEOFFSET = 123;
	public const BinXmlToken XSD_KATMAI_TIMEOFFSET = 122;
	public const BinXmlToken XSD_BOOLEAN = 134;
	public const BinXmlToken XSD_TIME = 129;
	public const BinXmlToken XSD_DATETIME = 130;
	public const BinXmlToken XSD_DATE = 131;
	public const BinXmlToken XSD_BINHEX = 132;
	public const BinXmlToken XSD_BASE64 = 133;
	public const BinXmlToken XSD_DECIMAL = 135;
	public const BinXmlToken XSD_BYTE = 136;
	public const BinXmlToken XSD_UNSIGNEDSHORT = 137;
	public const BinXmlToken XSD_UNSIGNEDINT = 138;
	public const BinXmlToken XSD_UNSIGNEDLONG = 139;
	public const BinXmlToken XSD_QNAME = 140;
}

// Namespace: System.Xml
internal struct BinXmlSqlDecimal // TypeDefIndex: 3055
{
	// Fields
	internal byte m_bLen; // 0x0
	internal byte m_bPrec; // 0x1
	internal byte m_bScale; // 0x2
	internal byte m_bSign; // 0x3
	internal uint m_data1; // 0x4
	internal uint m_data2; // 0x8
	internal uint m_data3; // 0xC
	internal uint m_data4; // 0x10
	private static readonly byte NUMERIC_MAX_PRECISION; // 0x0
	private static readonly byte MaxPrecision; // 0x1
	private static readonly byte MaxScale; // 0x2
	private static readonly int x_cNumeMax; // 0x4
	private static readonly long x_lInt32Base; // 0x8
	private static readonly ulong x_ulInt32Base; // 0x10
	private static readonly ulong x_ulInt32BaseForMod; // 0x18
	internal static readonly ulong x_llMax; // 0x20
	private static readonly double DUINT_BASE; // 0x28
	private static readonly double DUINT_BASE2; // 0x30
	private static readonly double DUINT_BASE3; // 0x38
	private static readonly uint[] x_rgulShiftBase; // 0x40
	private static readonly byte[] rgCLenFromPrec; // 0x48

	// Properties
	public bool IsPositive { get; }

	// Methods

	// RVA: 0x1B3FDB8 Offset: 0x1B3BDB8 VA: 0x1B3FDB8
	public bool get_IsPositive() { }

	// RVA: 0x1B3FDC8 Offset: 0x1B3BDC8 VA: 0x1B3FDC8
	public void .ctor(byte[] data, int offset, bool trim) { }

	// RVA: 0x1B4005C Offset: 0x1B3C05C VA: 0x1B4005C
	private static uint UIntFromByteArray(byte[] data, int offset) { }

	// RVA: 0x1B40298 Offset: 0x1B3C298 VA: 0x1B40298
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0x1B40368 Offset: 0x1B3C368 VA: 0x1B40368
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0x1B403C0 Offset: 0x1B3C3C0 VA: 0x1B403C0
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x1B403C8 Offset: 0x1B3C3C8 VA: 0x1B403C8
	public Decimal ToDecimal() { }

	// RVA: 0x1B400CC Offset: 0x1B3C0CC VA: 0x1B400CC
	private void TrimTrailingZeros() { }

	// RVA: 0x1B404F0 Offset: 0x1B3C4F0 VA: 0x1B404F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B407B0 Offset: 0x1B3C7B0 VA: 0x1B407B0
	private static void .cctor() { }
}

// Namespace: System.Xml
internal struct BinXmlSqlMoney // TypeDefIndex: 3056
{
	// Fields
	private long data; // 0x0

	// Methods

	// RVA: 0x1B408F4 Offset: 0x1B3C8F4 VA: 0x1B408F4
	public void .ctor(int v) { }

	// RVA: 0x1B40900 Offset: 0x1B3C900 VA: 0x1B40900
	public void .ctor(long v) { }

	// RVA: 0x1B40908 Offset: 0x1B3C908 VA: 0x1B40908
	public Decimal ToDecimal() { }

	// RVA: 0x1B4096C Offset: 0x1B3C96C VA: 0x1B4096C Slot: 3
	public override string ToString() { }
}

// Namespace: System.Xml
internal abstract class BinXmlDateTime // TypeDefIndex: 3057
{
	// Fields
	internal static int[] KatmaiTimeScaleMultiplicator; // 0x0
	private static readonly double SQLTicksPerMillisecond; // 0x8
	public static readonly int SQLTicksPerSecond; // 0x10
	public static readonly int SQLTicksPerMinute; // 0x14
	public static readonly int SQLTicksPerHour; // 0x18
	private static readonly int SQLTicksPerDay; // 0x1C

	// Methods

	// RVA: 0x1B40A5C Offset: 0x1B3CA5C VA: 0x1B40A5C
	private static void Write2Dig(StringBuilder sb, int val) { }

	// RVA: 0x1B40AB8 Offset: 0x1B3CAB8 VA: 0x1B40AB8
	private static void Write4DigNeg(StringBuilder sb, int val) { }

	// RVA: 0x1B40B5C Offset: 0x1B3CB5C VA: 0x1B40B5C
	private static void Write3Dec(StringBuilder sb, int val) { }

	// RVA: 0x1B40C08 Offset: 0x1B3CC08 VA: 0x1B40C08
	private static void WriteDate(StringBuilder sb, int yr, int mnth, int day) { }

	// RVA: 0x1B40CBC Offset: 0x1B3CCBC VA: 0x1B40CBC
	private static void WriteTime(StringBuilder sb, int hr, int min, int sec, int ms) { }

	// RVA: 0x1B40DA8 Offset: 0x1B3CDA8 VA: 0x1B40DA8
	private static void WriteTimeFullPrecision(StringBuilder sb, int hr, int min, int sec, int fraction) { }

	// RVA: 0x1B40F9C Offset: 0x1B3CF9C VA: 0x1B40F9C
	private static void WriteTimeZone(StringBuilder sb, TimeSpan zone) { }

	// RVA: 0x1B4109C Offset: 0x1B3D09C VA: 0x1B4109C
	private static void WriteTimeZone(StringBuilder sb, bool negTimeZone, int hr, int min) { }

	// RVA: 0x1B41170 Offset: 0x1B3D170 VA: 0x1B41170
	private static void BreakDownXsdDateTime(long val, out int yr, out int mnth, out int day, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x1B41338 Offset: 0x1B3D338 VA: 0x1B41338
	private static void BreakDownXsdDate(long val, out int yr, out int mnth, out int day, out bool negTimeZone, out int hr, out int min) { }

	// RVA: 0x1B41494 Offset: 0x1B3D494 VA: 0x1B41494
	private static void BreakDownXsdTime(long val, out int hr, out int min, out int sec, out int ms) { }

	// RVA: 0x1B41594 Offset: 0x1B3D594 VA: 0x1B41594
	public static string XsdDateTimeToString(long val) { }

	// RVA: 0x1B4169C Offset: 0x1B3D69C VA: 0x1B4169C
	public static string XsdDateToString(long val) { }

	// RVA: 0x1B41780 Offset: 0x1B3D780 VA: 0x1B41780
	public static string XsdTimeToString(long val) { }

	// RVA: 0x1B41858 Offset: 0x1B3D858 VA: 0x1B41858
	public static string SqlDateTimeToString(int dateticks, uint timeticks) { }

	// RVA: 0x1B41998 Offset: 0x1B3D998 VA: 0x1B41998
	public static DateTime SqlDateTimeToDateTime(int dateticks, uint timeticks) { }

	// RVA: 0x1B41A8C Offset: 0x1B3DA8C VA: 0x1B41A8C
	public static string SqlSmallDateTimeToString(short dateticks, ushort timeticks) { }

	// RVA: 0x1B41B80 Offset: 0x1B3DB80 VA: 0x1B41B80
	public static DateTime SqlSmallDateTimeToDateTime(short dateticks, ushort timeticks) { }

	// RVA: 0x1B41BF4 Offset: 0x1B3DBF4 VA: 0x1B41BF4
	public static DateTime XsdKatmaiDateToDateTime(byte[] data, int offset) { }

	// RVA: 0x1B41CE8 Offset: 0x1B3DCE8 VA: 0x1B41CE8
	public static DateTime XsdKatmaiDateTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x1B41FA4 Offset: 0x1B3DFA4 VA: 0x1B41FA4
	public static DateTime XsdKatmaiTimeToDateTime(byte[] data, int offset) { }

	// RVA: 0x1B42008 Offset: 0x1B3E008 VA: 0x1B42008
	public static DateTimeOffset XsdKatmaiDateOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x1B4206C Offset: 0x1B3E06C VA: 0x1B4206C
	public static DateTimeOffset XsdKatmaiDateTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x1B42168 Offset: 0x1B3E168 VA: 0x1B42168
	public static DateTimeOffset XsdKatmaiTimeOffsetToDateTimeOffset(byte[] data, int offset) { }

	// RVA: 0x1B421CC Offset: 0x1B3E1CC VA: 0x1B421CC
	public static string XsdKatmaiDateToString(byte[] data, int offset) { }

	// RVA: 0x1B422E8 Offset: 0x1B3E2E8 VA: 0x1B422E8
	public static string XsdKatmaiDateTimeToString(byte[] data, int offset) { }

	// RVA: 0x1B42580 Offset: 0x1B3E580 VA: 0x1B42580
	public static string XsdKatmaiTimeToString(byte[] data, int offset) { }

	// RVA: 0x1B426B0 Offset: 0x1B3E6B0 VA: 0x1B426B0
	public static string XsdKatmaiDateOffsetToString(byte[] data, int offset) { }

	// RVA: 0x1B427EC Offset: 0x1B3E7EC VA: 0x1B427EC
	public static string XsdKatmaiDateTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x1B42AC8 Offset: 0x1B3EAC8 VA: 0x1B42AC8
	public static string XsdKatmaiTimeOffsetToString(byte[] data, int offset) { }

	// RVA: 0x1B41C74 Offset: 0x1B3DC74 VA: 0x1B41C74
	private static long GetKatmaiDateTicks(byte[] data, ref int pos) { }

	// RVA: 0x1B41D7C Offset: 0x1B3DD7C VA: 0x1B41D7C
	private static long GetKatmaiTimeTicks(byte[] data, ref int pos) { }

	// RVA: 0x1B42114 Offset: 0x1B3E114 VA: 0x1B42114
	private static long GetKatmaiTimeZoneTicks(byte[] data, int pos) { }

	// RVA: 0x1B42468 Offset: 0x1B3E468 VA: 0x1B42468
	private static int GetFractions(DateTime dt) { }

	// RVA: 0x1B4298C Offset: 0x1B3E98C VA: 0x1B4298C
	private static int GetFractions(DateTimeOffset dt) { }

	// RVA: 0x1B42C18 Offset: 0x1B3EC18 VA: 0x1B42C18
	private static void .cctor() { }
}

// Namespace: 
private enum XmlSqlBinaryReader.ScanState // TypeDefIndex: 3058
{
	// Fields
	public int value__; // 0x0
	public const XmlSqlBinaryReader.ScanState Doc = 0;
	public const XmlSqlBinaryReader.ScanState XmlText = 1;
	public const XmlSqlBinaryReader.ScanState Attr = 2;
	public const XmlSqlBinaryReader.ScanState AttrVal = 3;
	public const XmlSqlBinaryReader.ScanState AttrValPseudoValue = 4;
	public const XmlSqlBinaryReader.ScanState Init = 5;
	public const XmlSqlBinaryReader.ScanState Error = 6;
	public const XmlSqlBinaryReader.ScanState EOF = 7;
	public const XmlSqlBinaryReader.ScanState Closed = 8;
}

// Namespace: 
internal struct XmlSqlBinaryReader.QName // TypeDefIndex: 3059
{
	// Fields
	public string prefix; // 0x0
	public string localname; // 0x8
	public string namespaceUri; // 0x10

	// Methods

	// RVA: 0x1B48460 Offset: 0x1B44460 VA: 0x1B48460
	public void .ctor(string prefix, string lname, string nsUri) { }

	// RVA: 0x1B4728C Offset: 0x1B4328C VA: 0x1B4728C
	public void Set(string prefix, string lname, string nsUri) { }

	// RVA: 0x1B432E8 Offset: 0x1B3F2E8 VA: 0x1B432E8
	public void Clear() { }

	// RVA: 0x1B47D64 Offset: 0x1B43D64 VA: 0x1B47D64
	public bool MatchNs(string lname, string nsUri) { }

	// RVA: 0x1B47DB4 Offset: 0x1B43DB4 VA: 0x1B47DB4
	public bool MatchPrefix(string prefix, string lname) { }

	// RVA: 0x1B48158 Offset: 0x1B44158 VA: 0x1B48158
	public void CheckPrefixNS(string prefix, string namespaceUri) { }

	// RVA: 0x1B4B928 Offset: 0x1B47928 VA: 0x1B4B928 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B4B970 Offset: 0x1B47970 VA: 0x1B4B970
	public int GetNSHashCode(SecureStringHasher hasher) { }

	// RVA: 0x1B4B9BC Offset: 0x1B479BC VA: 0x1B4B9BC Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1B490C4 Offset: 0x1B450C4 VA: 0x1B490C4 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B4BA5C Offset: 0x1B47A5C VA: 0x1B4BA5C
	public static bool op_Equality(XmlSqlBinaryReader.QName a, XmlSqlBinaryReader.QName b) { }
}

// Namespace: 
private struct XmlSqlBinaryReader.ElemInfo // TypeDefIndex: 3060
{
	// Fields
	public XmlSqlBinaryReader.QName name; // 0x0
	public string xmlLang; // 0x18
	public XmlSpace xmlSpace; // 0x20
	public bool xmlspacePreserve; // 0x24
	public XmlSqlBinaryReader.NamespaceDecl nsdecls; // 0x28

	// Methods

	// RVA: 0x1B4A038 Offset: 0x1B46038 VA: 0x1B4A038
	public void Set(XmlSqlBinaryReader.QName name, bool xmlspacePreserve) { }

	// RVA: 0x1B492B0 Offset: 0x1B452B0 VA: 0x1B492B0
	public XmlSqlBinaryReader.NamespaceDecl Clear() { }
}

// Namespace: 
private struct XmlSqlBinaryReader.AttrInfo // TypeDefIndex: 3061
{
	// Fields
	public XmlSqlBinaryReader.QName name; // 0x0
	public string val; // 0x18
	public int contentPos; // 0x20
	public int hashCode; // 0x24
	public int prevHash; // 0x28

	// Methods

	// RVA: 0x1B484A4 Offset: 0x1B444A4 VA: 0x1B484A4
	public void Set(XmlSqlBinaryReader.QName n, string v) { }

	// RVA: 0x1B489D8 Offset: 0x1B449D8 VA: 0x1B489D8
	public void Set(XmlSqlBinaryReader.QName n, int pos) { }

	// RVA: 0x1B49084 Offset: 0x1B45084 VA: 0x1B49084
	public void GetLocalnameAndNamespaceUri(out string localname, out string namespaceUri) { }

	// RVA: 0x1B49134 Offset: 0x1B45134 VA: 0x1B49134
	public int GetLocalnameAndNamespaceUriAndHash(SecureStringHasher hasher, out string localname, out string namespaceUri) { }

	// RVA: 0x1B490C0 Offset: 0x1B450C0 VA: 0x1B490C0
	public bool MatchNS(string localname, string namespaceUri) { }

	// RVA: 0x1B49184 Offset: 0x1B45184 VA: 0x1B49184
	public bool MatchHashNS(int hash, string localname, string namespaceUri) { }

	// RVA: 0x1B476A0 Offset: 0x1B436A0 VA: 0x1B476A0
	public void AdjustPosition(int adj) { }
}

// Namespace: 
private class XmlSqlBinaryReader.NamespaceDecl // TypeDefIndex: 3062
{
	// Fields
	public string prefix; // 0x10
	public string uri; // 0x18
	public XmlSqlBinaryReader.NamespaceDecl scopeLink; // 0x20
	public XmlSqlBinaryReader.NamespaceDecl prevLink; // 0x28
	public int scope; // 0x30
	public bool implied; // 0x34

	// Methods

	// RVA: 0x1B46CE4 Offset: 0x1B42CE4 VA: 0x1B46CE4
	public void .ctor(string prefix, string nsuri, XmlSqlBinaryReader.NamespaceDecl nextInScope, XmlSqlBinaryReader.NamespaceDecl prevDecl, int scope, bool implied) { }
}

// Namespace: 
private struct XmlSqlBinaryReader.SymbolTables // TypeDefIndex: 3063
{
	// Fields
	public string[] symtable; // 0x0
	public int symCount; // 0x8
	public XmlSqlBinaryReader.QName[] qnametable; // 0x10
	public int qnameCount; // 0x18

	// Methods

	// RVA: 0x1B43214 Offset: 0x1B3F214 VA: 0x1B43214
	public void Init() { }
}

// Namespace: 
private class XmlSqlBinaryReader.NestedBinXml // TypeDefIndex: 3064
{
	// Fields
	public XmlSqlBinaryReader.SymbolTables symbolTables; // 0x10
	public int docState; // 0x30
	public XmlSqlBinaryReader.NestedBinXml next; // 0x38

	// Methods

	// RVA: 0x1B4A084 Offset: 0x1B46084 VA: 0x1B4A084
	public void .ctor(XmlSqlBinaryReader.SymbolTables symbolTables, int docState, XmlSqlBinaryReader.NestedBinXml next) { }
}

// Namespace: System.Xml
internal sealed class XmlSqlBinaryReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 3065
{
	// Fields
	internal static readonly Type TypeOfObject; // 0x0
	internal static readonly Type TypeOfString; // 0x8
	private static Type[] TokenTypeMap; // 0x10
	private static byte[] XsdKatmaiTimeScaleToValueLengthMap; // 0x18
	private static ReadState[] ScanState2ReadState; // 0x20
	private Stream inStrm; // 0x10
	private byte[] data; // 0x18
	private int pos; // 0x20
	private int mark; // 0x24
	private int end; // 0x28
	private long offset; // 0x30
	private bool eof; // 0x38
	private bool sniffed; // 0x39
	private bool isEmpty; // 0x3A
	private int docState; // 0x3C
	private XmlSqlBinaryReader.SymbolTables symbolTables; // 0x40
	private XmlNameTable xnt; // 0x60
	private bool xntFromSettings; // 0x68
	private string xml; // 0x70
	private string xmlns; // 0x78
	private string nsxmlns; // 0x80
	private string baseUri; // 0x88
	private XmlSqlBinaryReader.ScanState state; // 0x90
	private XmlNodeType nodetype; // 0x94
	private BinXmlToken token; // 0x98
	private int attrIndex; // 0x9C
	private XmlSqlBinaryReader.QName qnameOther; // 0xA0
	private XmlSqlBinaryReader.QName qnameElement; // 0xB8
	private XmlNodeType parentNodeType; // 0xD0
	private XmlSqlBinaryReader.ElemInfo[] elementStack; // 0xD8
	private int elemDepth; // 0xE0
	private XmlSqlBinaryReader.AttrInfo[] attributes; // 0xE8
	private int[] attrHashTbl; // 0xF0
	private int attrCount; // 0xF8
	private int posAfterAttrs; // 0xFC
	private bool xmlspacePreserve; // 0x100
	private int tokLen; // 0x104
	private int tokDataPos; // 0x108
	private bool hasTypedValue; // 0x10C
	private Type valueType; // 0x110
	private string stringValue; // 0x118
	private Dictionary<string, XmlSqlBinaryReader.NamespaceDecl> namespaces; // 0x120
	private XmlSqlBinaryReader.NestedBinXml prevNameInfo; // 0x128
	private XmlReader textXmlReader; // 0x130
	private bool closeInput; // 0x138
	private bool checkCharacters; // 0x139
	private bool ignoreWhitespace; // 0x13A
	private bool ignorePIs; // 0x13B
	private bool ignoreComments; // 0x13C
	private DtdProcessing dtdProcessing; // 0x140
	private SecureStringHasher hasher; // 0x148
	private XmlCharType xmlCharType; // 0x150
	private Encoding unicode; // 0x158
	private byte version; // 0x160

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override ReadState ReadState { get; }

	// Methods

	// RVA: 0x1B42CDC Offset: 0x1B3ECDC VA: 0x1B42CDC
	public void .ctor(Stream stream, byte[] data, int len, string baseUri, bool closeInput, XmlReaderSettings settings) { }

	// RVA: 0x1B43F74 Offset: 0x1B3FF74 VA: 0x1B43F74 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1B44090 Offset: 0x1B40090 VA: 0x1B44090 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1B44098 Offset: 0x1B40098 VA: 0x1B44098 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1B440A0 Offset: 0x1B400A0 VA: 0x1B440A0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1B440A8 Offset: 0x1B400A8 VA: 0x1B440A8 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1B440B0 Offset: 0x1B400B0 VA: 0x1B440B0 Slot: 11
	public override string get_Value() { }

	// RVA: 0x1B44E08 Offset: 0x1B40E08 VA: 0x1B44E08 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x1B44EA4 Offset: 0x1B40EA4 VA: 0x1B44EA4 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x1B44EAC Offset: 0x1B40EAC VA: 0x1B44EAC Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1B44ED0 Offset: 0x1B40ED0 VA: 0x1B44ED0 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1B44F50 Offset: 0x1B40F50 VA: 0x1B44F50 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x1B44FE0 Offset: 0x1B40FE0 VA: 0x1B44FE0 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0x1B44FE8 Offset: 0x1B40FE8 VA: 0x1B44FE8 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x1B45034 Offset: 0x1B41034 VA: 0x1B45034 Slot: 23
	public override string GetAttribute(string name, string ns) { }

	// RVA: 0x1B4518C Offset: 0x1B4118C VA: 0x1B4518C Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x1B452D8 Offset: 0x1B412D8 VA: 0x1B452D8 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x1B45368 Offset: 0x1B41368 VA: 0x1B45368 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1B454E0 Offset: 0x1B414E0 VA: 0x1B454E0 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1B45584 Offset: 0x1B41584 VA: 0x1B45584 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1B455F4 Offset: 0x1B415F4 VA: 0x1B455F4 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1B45678 Offset: 0x1B41678 VA: 0x1B45678 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x1B45748 Offset: 0x1B41748 VA: 0x1B45748 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x1B45758 Offset: 0x1B41758 VA: 0x1B45758 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x1B45AB0 Offset: 0x1B41AB0 VA: 0x1B45AB0 Slot: 33
	public override void Close() { }

	// RVA: 0x1B45B4C Offset: 0x1B41B4C VA: 0x1B45B4C Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1B45B54 Offset: 0x1B41B54 VA: 0x1B45B54 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1B45C10 Offset: 0x1B41C10 VA: 0x1B45C10 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1B45C48 Offset: 0x1B41C48 VA: 0x1B45C48 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x1B45CC8 Offset: 0x1B41CC8 VA: 0x1B45CC8 Slot: 31
	public override bool Read() { }

	// RVA: 0x1B46728 Offset: 0x1B42728 VA: 0x1B46728 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1B46AC4 Offset: 0x1B42AC4 VA: 0x1B46AC4 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1B46C68 Offset: 0x1B42C68 VA: 0x1B46C68
	private void VerifyVersion(int requiredVersion, BinXmlToken token) { }

	// RVA: 0x1B4333C Offset: 0x1B3F33C VA: 0x1B4333C
	private void AddInitNamespace(string prefix, string uri) { }

	// RVA: 0x1B46D74 Offset: 0x1B42D74 VA: 0x1B46D74
	private void AddName() { }

	// RVA: 0x1B46F60 Offset: 0x1B42F60 VA: 0x1B46F60
	private void AddQName() { }

	// RVA: 0x1B472D0 Offset: 0x1B432D0 VA: 0x1B472D0
	private void NameFlush() { }

	// RVA: 0x1B47320 Offset: 0x1B43320 VA: 0x1B47320
	private void SkipExtn() { }

	// RVA: 0x1B473F8 Offset: 0x1B433F8 VA: 0x1B473F8
	private int ReadQNameRef() { }

	// RVA: 0x1B47200 Offset: 0x1B43200 VA: 0x1B47200
	private int ReadNameRef() { }

	// RVA: 0x1B47484 Offset: 0x1B43484 VA: 0x1B47484
	private bool FillAllowEOF() { }

	// RVA: 0x1B476B4 Offset: 0x1B436B4 VA: 0x1B476B4
	private void Fill_(int require) { }

	// RVA: 0x1B473DC Offset: 0x1B433DC VA: 0x1B473DC
	private void Fill(int require) { }

	// RVA: 0x1B477A0 Offset: 0x1B437A0 VA: 0x1B477A0
	private byte ReadByte() { }

	// RVA: 0x1B477FC Offset: 0x1B437FC VA: 0x1B477FC
	private ushort ReadUShort() { }

	// RVA: 0x1B473B0 Offset: 0x1B433B0 VA: 0x1B473B0
	private int ParseMB32() { }

	// RVA: 0x1B47870 Offset: 0x1B43870 VA: 0x1B47870
	private int ParseMB32_(byte b) { }

	// RVA: 0x1B47908 Offset: 0x1B43908 VA: 0x1B47908
	private int ParseMB32(int pos) { }

	// RVA: 0x1B479F4 Offset: 0x1B439F4 VA: 0x1B479F4
	private int ParseMB64() { }

	// RVA: 0x1B47A20 Offset: 0x1B43A20 VA: 0x1B47A20
	private BinXmlToken PeekToken() { }

	// RVA: 0x1B47A88 Offset: 0x1B43A88 VA: 0x1B47A88
	private BinXmlToken ReadToken() { }

	// RVA: 0x1B47AF8 Offset: 0x1B43AF8 VA: 0x1B47AF8
	private BinXmlToken NextToken2(BinXmlToken token) { }

	// RVA: 0x1B47B70 Offset: 0x1B43B70 VA: 0x1B47B70
	private BinXmlToken NextToken1() { }

	// RVA: 0x1B47BE8 Offset: 0x1B43BE8 VA: 0x1B47BE8
	private BinXmlToken NextToken() { }

	// RVA: 0x1B47C50 Offset: 0x1B43C50 VA: 0x1B47C50
	private BinXmlToken PeekNextToken() { }

	// RVA: 0x1B458D4 Offset: 0x1B418D4 VA: 0x1B458D4
	private BinXmlToken RescanNextToken() { }

	// RVA: 0x1B46E9C Offset: 0x1B42E9C VA: 0x1B46E9C
	private string ParseText() { }

	// RVA: 0x1B47C78 Offset: 0x1B43C78 VA: 0x1B47C78
	private int ScanText(out int start) { }

	// RVA: 0x1B441DC Offset: 0x1B401DC VA: 0x1B441DC
	private string GetString(int pos, int cch) { }

	// RVA: 0x1B47D34 Offset: 0x1B43D34 VA: 0x1B47D34
	private string GetStringAligned(byte[] data, int offset, int cch) { }

	// RVA: 0x1B44CDC Offset: 0x1B40CDC VA: 0x1B44CDC
	private string GetAttributeText(int i) { }

	// RVA: 0x1B45104 Offset: 0x1B41104 VA: 0x1B45104
	private int LocateAttribute(string name, string ns) { }

	// RVA: 0x1B451F8 Offset: 0x1B411F8 VA: 0x1B451F8
	private int LocateAttribute(string name) { }

	// RVA: 0x1B45400 Offset: 0x1B41400 VA: 0x1B45400
	private void PositionOnAttribute(int i) { }

	// RVA: 0x1B47E04 Offset: 0x1B43E04 VA: 0x1B47E04
	private void GrowElements() { }

	// RVA: 0x1B47E94 Offset: 0x1B43E94 VA: 0x1B47E94
	private void GrowAttributes() { }

	// RVA: 0x1B47F24 Offset: 0x1B43F24 VA: 0x1B47F24
	private void ClearAttributes() { }

	// RVA: 0x1B47F34 Offset: 0x1B43F34 VA: 0x1B47F34
	private void PushNamespace(string prefix, string ns, bool implied) { }

	// RVA: 0x1B4823C Offset: 0x1B4423C VA: 0x1B4823C
	private void PopNamespaces(XmlSqlBinaryReader.NamespaceDecl firstInScopeChain) { }

	// RVA: 0x1B4830C Offset: 0x1B4430C VA: 0x1B4830C
	private void GenerateImpliedXmlnsAttrs() { }

	// RVA: 0x1B45E94 Offset: 0x1B41E94 VA: 0x1B45E94
	private bool ReadInit(bool skipXmlDecl) { }

	// RVA: 0x1B484F0 Offset: 0x1B444F0 VA: 0x1B484F0
	private void ScanAttributes() { }

	// RVA: 0x1B48CC0 Offset: 0x1B44CC0 VA: 0x1B48CC0
	private void SimpleCheckForDuplicateAttributes() { }

	// RVA: 0x1B48E2C Offset: 0x1B44E2C VA: 0x1B48E2C
	private void HashCheckForDuplicateAttributes() { }

	// RVA: 0x1B44450 Offset: 0x1B40450 VA: 0x1B44450
	private string XmlDeclValue() { }

	// RVA: 0x1B44340 Offset: 0x1B40340 VA: 0x1B44340
	private string CDATAValue() { }

	// RVA: 0x1B491A4 Offset: 0x1B451A4 VA: 0x1B491A4
	private void FinishCDATA() { }

	// RVA: 0x1B49248 Offset: 0x1B45248 VA: 0x1B49248
	private void FinishEndElement() { }

	// RVA: 0x1B463A4 Offset: 0x1B423A4 VA: 0x1B463A4
	private bool ReadDoc() { }

	// RVA: 0x1B49E50 Offset: 0x1B45E50 VA: 0x1B49E50
	private void ImplReadData(BinXmlToken tokenType) { }

	// RVA: 0x1B492D0 Offset: 0x1B452D0 VA: 0x1B492D0
	private void ImplReadElement() { }

	// RVA: 0x1B49574 Offset: 0x1B45574 VA: 0x1B49574
	private void ImplReadEndElement() { }

	// RVA: 0x1B49654 Offset: 0x1B45654 VA: 0x1B49654
	private void ImplReadDoctype() { }

	// RVA: 0x1B49938 Offset: 0x1B45938 VA: 0x1B49938
	private void ImplReadPI() { }

	// RVA: 0x1B499A4 Offset: 0x1B459A4 VA: 0x1B499A4
	private void ImplReadComment() { }

	// RVA: 0x1B499D0 Offset: 0x1B459D0 VA: 0x1B499D0
	private void ImplReadCDATA() { }

	// RVA: 0x1B49A04 Offset: 0x1B45A04 VA: 0x1B49A04
	private void ImplReadNest() { }

	// RVA: 0x1B49AA4 Offset: 0x1B45AA4 VA: 0x1B49AA4
	private void ImplReadEndNest() { }

	// RVA: 0x1B49AEC Offset: 0x1B45AEC VA: 0x1B49AEC
	private void ImplReadXmlText() { }

	// RVA: 0x1B4A0DC Offset: 0x1B460DC VA: 0x1B4A0DC
	private void UpdateFromTextReader() { }

	// RVA: 0x1B453E4 Offset: 0x1B413E4 VA: 0x1B453E4
	private bool UpdateFromTextReader(bool needUpdate) { }

	// RVA: 0x1B49FD4 Offset: 0x1B45FD4 VA: 0x1B49FD4
	private void CheckAllowContent() { }

	// RVA: 0x1B43414 Offset: 0x1B3F414 VA: 0x1B43414
	private void GenerateTokenTypeMap() { }

	// RVA: 0x1B459D0 Offset: 0x1B419D0 VA: 0x1B459D0
	private Type GetValueType(BinXmlToken token) { }

	// RVA: 0x1B459C4 Offset: 0x1B419C4 VA: 0x1B459C4
	private void ReScanOverValue(BinXmlToken token) { }

	// RVA: 0x1B48B10 Offset: 0x1B44B10 VA: 0x1B48B10
	private XmlNodeType ScanOverValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x1B4A414 Offset: 0x1B46414 VA: 0x1B4A414
	private XmlNodeType ScanOverAnyValue(BinXmlToken token, bool attr, bool checkChars) { }

	// RVA: 0x1B4A1B4 Offset: 0x1B461B4 VA: 0x1B4A1B4
	private XmlNodeType CheckText(bool attr) { }

	// RVA: 0x1B4A378 Offset: 0x1B46378 VA: 0x1B4A378
	private XmlNodeType CheckTextIsWS() { }

	// RVA: 0x1B4A888 Offset: 0x1B46888 VA: 0x1B4A888
	private void CheckValueTokenBounds() { }

	// RVA: 0x1B4A7A0 Offset: 0x1B467A0 VA: 0x1B4A7A0
	private int GetXsdKatmaiTokenLength(BinXmlToken token) { }

	// RVA: 0x1B4A8E4 Offset: 0x1B468E4 VA: 0x1B4A8E4
	private int XsdKatmaiTimeScaleToValueLength(byte scale) { }

	// RVA: 0x1B4A9B8 Offset: 0x1B469B8 VA: 0x1B4A9B8
	private long ValueAsLong() { }

	// RVA: 0x1B4B2B0 Offset: 0x1B472B0 VA: 0x1B4B2B0
	private ulong ValueAsULong() { }

	// RVA: 0x1B4B054 Offset: 0x1B47054 VA: 0x1B4B054
	private Decimal ValueAsDecimal() { }

	// RVA: 0x1B4AF00 Offset: 0x1B46F00 VA: 0x1B4AF00
	private double ValueAsDouble() { }

	// RVA: 0x1B4B44C Offset: 0x1B4744C VA: 0x1B4B44C
	private string ValueAsDateTimeString() { }

	// RVA: 0x1B44590 Offset: 0x1B40590 VA: 0x1B44590
	private string ValueAsString(BinXmlToken token) { }

	// RVA: 0x1B4ABF0 Offset: 0x1B46BF0 VA: 0x1B4ABF0
	private short GetInt16(int pos) { }

	// RVA: 0x1B4AD78 Offset: 0x1B46D78 VA: 0x1B4AD78
	private ushort GetUInt16(int pos) { }

	// RVA: 0x1B4AC34 Offset: 0x1B46C34 VA: 0x1B4AC34
	private int GetInt32(int pos) { }

	// RVA: 0x1B4ADBC Offset: 0x1B46DBC VA: 0x1B4ADBC
	private uint GetUInt32(int pos) { }

	// RVA: 0x1B4ACA8 Offset: 0x1B46CA8 VA: 0x1B4ACA8
	private long GetInt64(int pos) { }

	// RVA: 0x1B4AE30 Offset: 0x1B46E30 VA: 0x1B4AE30
	private ulong GetUInt64(int pos) { }

	// RVA: 0x1B4B300 Offset: 0x1B47300 VA: 0x1B4B300
	private float GetSingle(int offset) { }

	// RVA: 0x1B4B378 Offset: 0x1B47378 VA: 0x1B4B378
	private double GetDouble(int offset) { }

	// RVA: 0x1B46C9C Offset: 0x1B42C9C VA: 0x1B46C9C
	private Exception ThrowUnexpectedToken(BinXmlToken token) { }

	// RVA: 0x1B4772C Offset: 0x1B4372C VA: 0x1B4772C
	private Exception ThrowXmlException(string res) { }

	// RVA: 0x1B48A24 Offset: 0x1B44A24 VA: 0x1B48A24
	private Exception ThrowXmlException(string res, string arg1, string arg2) { }

	// RVA: 0x1B48C3C Offset: 0x1B44C3C VA: 0x1B48C3C
	private Exception ThrowNotSupported(string res) { }

	// RVA: 0x1B4B7AC Offset: 0x1B477AC VA: 0x1B4B7AC
	private static void .cctor() { }
}

// Namespace: System.Xml
internal class BitStack // TypeDefIndex: 3066
{
	// Fields
	private uint[] bitStack; // 0x10
	private int stackPos; // 0x18
	private uint curr; // 0x1C

	// Methods

	// RVA: 0x1B4BABC Offset: 0x1B47ABC VA: 0x1B4BABC
	public void .ctor() { }

	// RVA: 0x1B4BADC Offset: 0x1B47ADC VA: 0x1B4BADC
	public void PushBit(bool bit) { }

	// RVA: 0x1B4BC1C Offset: 0x1B47C1C VA: 0x1B4BC1C
	public bool PopBit() { }

	// RVA: 0x1B4BC88 Offset: 0x1B47C88 VA: 0x1B4BC88
	public bool PeekBit() { }

	// RVA: 0x1B4BB14 Offset: 0x1B47B14 VA: 0x1B4BB14
	private void PushCurr() { }

	// RVA: 0x1B4BC44 Offset: 0x1B47C44 VA: 0x1B4BC44
	private void PopCurr() { }
}

// Namespace: System.Xml
internal static class Bits // TypeDefIndex: 3067
{
	// Fields
	private static readonly uint MASK_0101010101010101; // 0x0
	private static readonly uint MASK_0011001100110011; // 0x4
	private static readonly uint MASK_0000111100001111; // 0x8
	private static readonly uint MASK_0000000011111111; // 0xC
	private static readonly uint MASK_1111111111111111; // 0x10

	// Methods

	// RVA: 0x1B4BC94 Offset: 0x1B47C94 VA: 0x1B4BC94
	public static int Count(uint num) { }

	// RVA: 0x1B4BD30 Offset: 0x1B47D30 VA: 0x1B4BD30
	public static int LeastPosition(uint num) { }

	// RVA: 0x1B4BD9C Offset: 0x1B47D9C VA: 0x1B4BD9C
	private static void .cctor() { }
}

// Namespace: System.Xml
internal class ByteStack // TypeDefIndex: 3068
{
	// Fields
	private byte[] stack; // 0x10
	private int growthRate; // 0x18
	private int top; // 0x1C
	private int size; // 0x20

	// Methods

	// RVA: 0x1B4BDF4 Offset: 0x1B47DF4 VA: 0x1B4BDF4
	public void .ctor(int growthRate) { }

	// RVA: 0x1B4BE70 Offset: 0x1B47E70 VA: 0x1B4BE70
	public void Push(byte data) { }

	// RVA: 0x1B4BF50 Offset: 0x1B47F50 VA: 0x1B4BF50
	public byte Pop() { }
}

// Namespace: System.Xml
internal class CharEntityEncoderFallback : EncoderFallback // TypeDefIndex: 3069
{
	// Fields
	private CharEntityEncoderFallbackBuffer fallbackBuffer; // 0x10
	private int[] textContentMarks; // 0x18
	private int endMarkPos; // 0x20
	private int curMarkPos; // 0x24
	private int startOffset; // 0x28

	// Properties
	public override int MaxCharCount { get; }
	internal int StartOffset { set; }

	// Methods

	// RVA: 0x1B4BF98 Offset: 0x1B47F98 VA: 0x1B4BF98
	internal void .ctor() { }

	// RVA: 0x1B4BFA0 Offset: 0x1B47FA0 VA: 0x1B4BFA0 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x1B4C06C Offset: 0x1B4806C VA: 0x1B4C06C Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x1B4C074 Offset: 0x1B48074 VA: 0x1B4C074
	internal void set_StartOffset(int value) { }

	// RVA: 0x1B4C07C Offset: 0x1B4807C VA: 0x1B4C07C
	internal void Reset(int[] textContentMarks, int endMarkPos) { }

	// RVA: 0x1B4C0A8 Offset: 0x1B480A8 VA: 0x1B4C0A8
	internal bool CanReplaceAt(int index) { }
}

// Namespace: System.Xml
internal class CharEntityEncoderFallbackBuffer : EncoderFallbackBuffer // TypeDefIndex: 3070
{
	// Fields
	private CharEntityEncoderFallback parent; // 0x30
	private string charEntity; // 0x38
	private int charEntityIndex; // 0x40

	// Properties
	public override int Remaining { get; }

	// Methods

	// RVA: 0x1B4C014 Offset: 0x1B48014 VA: 0x1B4C014
	internal void .ctor(CharEntityEncoderFallback parent) { }

	// RVA: 0x1B4C128 Offset: 0x1B48128 VA: 0x1B4C128 Slot: 4
	public override bool Fallback(char charUnknown, int index) { }

	// RVA: 0x1B4C324 Offset: 0x1B48324 VA: 0x1B4C324 Slot: 5
	public override bool Fallback(char charUnknownHigh, char charUnknownLow, int index) { }

	// RVA: 0x1B4C5B4 Offset: 0x1B485B4 VA: 0x1B4C5B4 Slot: 6
	public override char GetNextChar() { }

	// RVA: 0x1B4C604 Offset: 0x1B48604 VA: 0x1B4C604 Slot: 7
	public override bool MovePrevious() { }

	// RVA: 0x1B4C620 Offset: 0x1B48620 VA: 0x1B4C620 Slot: 8
	public override int get_Remaining() { }

	// RVA: 0x1B4C650 Offset: 0x1B48650 VA: 0x1B4C650 Slot: 9
	public override void Reset() { }

	// RVA: 0x1B4C5A4 Offset: 0x1B485A4 VA: 0x1B4C5A4
	private int SurrogateCharToUtf32(char highSurrogate, char lowSurrogate) { }
}

// Namespace: System.Xml
public enum ConformanceLevel // TypeDefIndex: 3071
{
	// Fields
	public int value__; // 0x0
	public const ConformanceLevel Auto = 0;
	public const ConformanceLevel Fragment = 1;
	public const ConformanceLevel Document = 2;
}

// Namespace: System.Xml
public enum DtdProcessing // TypeDefIndex: 3072
{
	// Fields
	public int value__; // 0x0
	public const DtdProcessing Prohibit = 0;
	public const DtdProcessing Ignore = 1;
	public const DtdProcessing Parse = 2;
}

// Namespace: System.Xml
public enum EntityHandling // TypeDefIndex: 3073
{
	// Fields
	public int value__; // 0x0
	public const EntityHandling ExpandEntities = 1;
	public const EntityHandling ExpandCharEntities = 2;
}

// Namespace: System.Xml
internal class HtmlEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 3074
{
	// Fields
	protected ByteStack elementScope; // 0xC0
	protected ElementProperties currentElementProperties; // 0xC8
	private AttributeProperties currentAttributeProperties; // 0xCC
	private bool endsWithAmpersand; // 0xD0
	private byte[] uriEscapingBuffer; // 0xD8
	private string mediaType; // 0xE0
	private bool doNotEscapeUriAttributes; // 0xE8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x1B4C65C Offset: 0x1B4865C VA: 0x1B4C65C
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1B4C834 Offset: 0x1B48834 VA: 0x1B4C834
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1B4C860 Offset: 0x1B48860 VA: 0x1B4C860 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1B4C864 Offset: 0x1B48864 VA: 0x1B4C864 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1B4C868 Offset: 0x1B48868 VA: 0x1B4C868 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1B4CAB4 Offset: 0x1B48AB4 VA: 0x1B4CAB4 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1B4CBE0 Offset: 0x1B48BE0 VA: 0x1B4CBE0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1B4CD58 Offset: 0x1B48D58 VA: 0x1B4CD58 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1B4CE5C Offset: 0x1B48E5C VA: 0x1B4CE5C Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1B4CF60 Offset: 0x1B48F60 VA: 0x1B4CF60 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1B4D0E4 Offset: 0x1B490E4 VA: 0x1B4D0E4 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1B4D20C Offset: 0x1B4920C VA: 0x1B4D20C Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1B4D340 Offset: 0x1B49340 VA: 0x1B4D340 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1B4D40C Offset: 0x1B4940C VA: 0x1B4D40C Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1B4D464 Offset: 0x1B49464 VA: 0x1B4D464 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1B4D4BC Offset: 0x1B494BC VA: 0x1B4D4BC Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1B4D514 Offset: 0x1B49514 VA: 0x1B4D514 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1B4C688 Offset: 0x1B48688 VA: 0x1B4C688
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1B4CC34 Offset: 0x1B48C34 VA: 0x1B4CC34
	protected void WriteMetaElement() { }

	// RVA: 0x1B4D3F4 Offset: 0x1B493F4 VA: 0x1B4D3F4
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1B4D3B0 Offset: 0x1B493B0 VA: 0x1B4D3B0
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1B4D8FC Offset: 0x1B498FC VA: 0x1B4D8FC
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1B4D5A4 Offset: 0x1B495A4 VA: 0x1B4D5A4
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1B4D178 Offset: 0x1B49178 VA: 0x1B4D178
	private void OutputRestAmps() { }
}

// Namespace: System.Xml
internal class HtmlEncodedRawTextWriterIndent : HtmlEncodedRawTextWriter // TypeDefIndex: 3075
{
	// Fields
	private int indentLevel; // 0xEC
	private int endBlockPos; // 0xF0
	private string indentChars; // 0xF8
	private bool newLineOnAttributes; // 0x100

	// Methods

	// RVA: 0x1B4DB5C Offset: 0x1B49B5C VA: 0x1B4DB5C
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1B4DBD4 Offset: 0x1B49BD4 VA: 0x1B4DBD4
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1B4DC0C Offset: 0x1B49C0C VA: 0x1B4DC0C Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1B4DC28 Offset: 0x1B49C28 VA: 0x1B4DC28 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1B4DE3C Offset: 0x1B49E3C VA: 0x1B4DE3C Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1B4DEAC Offset: 0x1B49EAC VA: 0x1B4DEAC Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1B4DF4C Offset: 0x1B49F4C VA: 0x1B4DF4C Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1B4DFC0 Offset: 0x1B49FC0 VA: 0x1B4DFC0 Slot: 48
	protected override void FlushBuffer() { }

	// RVA: 0x1B4DB94 Offset: 0x1B49B94 VA: 0x1B4DB94
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1B4DDEC Offset: 0x1B49DEC VA: 0x1B4DDEC
	private void WriteIndent() { }
}

// Namespace: System.Xml
internal abstract class HtmlTernaryTree // TypeDefIndex: 3076
{
	// Fields
	internal static byte[] htmlElements; // 0x0
	internal static byte[] htmlAttributes; // 0x8

	// Methods

	// RVA: 0x1B4DFE8 Offset: 0x1B49FE8 VA: 0x1B4DFE8
	private static void .cctor() { }
}

// Namespace: System.Xml
internal class HtmlUtf8RawTextWriter : XmlUtf8RawTextWriter // TypeDefIndex: 3077
{
	// Fields
	protected ByteStack elementScope; // 0x90
	protected ElementProperties currentElementProperties; // 0x98
	private AttributeProperties currentAttributeProperties; // 0x9C
	private bool endsWithAmpersand; // 0xA0
	private byte[] uriEscapingBuffer; // 0xA8
	private string mediaType; // 0xB0
	private bool doNotEscapeUriAttributes; // 0xB8
	protected static TernaryTreeReadOnly elementPropertySearch; // 0x0
	protected static TernaryTreeReadOnly attributePropertySearch; // 0x8

	// Methods

	// RVA: 0x1B4E0CC Offset: 0x1B4A0CC VA: 0x1B4E0CC
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1B4E2A4 Offset: 0x1B4A2A4 VA: 0x1B4E2A4 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1B4E2A8 Offset: 0x1B4A2A8 VA: 0x1B4E2A8 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1B4E2AC Offset: 0x1B4A2AC VA: 0x1B4E2AC Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1B4E4F4 Offset: 0x1B4A4F4 VA: 0x1B4E4F4 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1B4E600 Offset: 0x1B4A600 VA: 0x1B4E600 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1B4E77C Offset: 0x1B4A77C VA: 0x1B4E77C Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1B4E860 Offset: 0x1B4A860 VA: 0x1B4E860 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1B4E944 Offset: 0x1B4A944 VA: 0x1B4E944 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1B4EAB8 Offset: 0x1B4AAB8 VA: 0x1B4EAB8 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1B4EBF4 Offset: 0x1B4ABF4 VA: 0x1B4EBF4 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1B4ED14 Offset: 0x1B4AD14 VA: 0x1B4ED14 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1B4EDC0 Offset: 0x1B4ADC0 VA: 0x1B4EDC0 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1B4EE18 Offset: 0x1B4AE18 VA: 0x1B4EE18 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1B4EE70 Offset: 0x1B4AE70 VA: 0x1B4EE70 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1B4EEC8 Offset: 0x1B4AEC8 VA: 0x1B4EEC8 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1B4E0F8 Offset: 0x1B4A0F8 VA: 0x1B4E0F8
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1B4E658 Offset: 0x1B4A658 VA: 0x1B4E658
	protected void WriteMetaElement() { }

	// RVA: 0x1B4EDA8 Offset: 0x1B4ADA8 VA: 0x1B4EDA8
	protected void WriteHtmlElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1B4ED64 Offset: 0x1B4AD64 VA: 0x1B4ED64
	protected void WriteHtmlAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1B4F24C Offset: 0x1B4B24C VA: 0x1B4F24C
	private void WriteHtmlAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1B4EF0C Offset: 0x1B4AF0C VA: 0x1B4EF0C
	private void WriteUriAttributeText(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1B4EB30 Offset: 0x1B4AB30 VA: 0x1B4EB30
	private void OutputRestAmps() { }
}

// Namespace: System.Xml
internal class HtmlUtf8RawTextWriterIndent : HtmlUtf8RawTextWriter // TypeDefIndex: 3078
{
	// Fields
	private int indentLevel; // 0xBC
	private int endBlockPos; // 0xC0
	private string indentChars; // 0xC8
	private bool newLineOnAttributes; // 0xD0

	// Methods

	// RVA: 0x1C18100 Offset: 0x1C14100 VA: 0x1C18100
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1C1816C Offset: 0x1C1416C VA: 0x1C1816C Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1C1818C Offset: 0x1C1418C VA: 0x1C1818C Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C184B4 Offset: 0x1C144B4 VA: 0x1C184B4 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1C1852C Offset: 0x1C1452C VA: 0x1C1852C Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C185D4 Offset: 0x1C145D4 VA: 0x1C185D4 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1C1864C Offset: 0x1C1464C VA: 0x1C1864C Slot: 48
	protected override void FlushBuffer() { }

	// RVA: 0x1C1812C Offset: 0x1C1412C VA: 0x1C1812C
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1C18464 Offset: 0x1C14464 VA: 0x1C18464
	private void WriteIndent() { }
}

// Namespace: System.Xml
internal interface IDtdInfo // TypeDefIndex: 3079
{
	// Properties
	public abstract XmlQualifiedName Name { get; }
	public abstract string InternalDtdSubset { get; }
	public abstract bool HasDefaultAttributes { get; }
	public abstract bool HasNonCDataAttributes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlQualifiedName get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_InternalDtdSubset();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_HasDefaultAttributes();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_HasNonCDataAttributes();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IDtdAttributeListInfo LookupAttributeList(string prefix, string localName);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IDtdEntityInfo LookupEntity(string name);
}

// Namespace: System.Xml
internal interface IDtdAttributeListInfo // TypeDefIndex: 3080
{
	// Properties
	public abstract bool HasNonCDataAttributes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_HasNonCDataAttributes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDtdAttributeInfo LookupAttribute(string prefix, string localName);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IEnumerable<IDtdDefaultAttributeInfo> LookupDefaultAttributes();
}

// Namespace: System.Xml
internal interface IDtdAttributeInfo // TypeDefIndex: 3081
{
	// Properties
	public abstract string Prefix { get; }
	public abstract string LocalName { get; }
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }
	public abstract bool IsNonCDataType { get; }
	public abstract bool IsDeclaredInExternal { get; }
	public abstract bool IsXmlAttribute { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Prefix();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_LinePosition();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsNonCDataType();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsDeclaredInExternal();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_IsXmlAttribute();
}

// Namespace: System.Xml
internal interface IDtdDefaultAttributeInfo : IDtdAttributeInfo // TypeDefIndex: 3082
{
	// Properties
	public abstract string DefaultValueExpanded { get; }
	public abstract object DefaultValueTyped { get; }
	public abstract int ValueLineNumber { get; }
	public abstract int ValueLinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_DefaultValueExpanded();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object get_DefaultValueTyped();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_ValueLineNumber();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_ValueLinePosition();
}

// Namespace: System.Xml
internal interface IDtdEntityInfo // TypeDefIndex: 3083
{
	// Properties
	public abstract string Name { get; }
	public abstract bool IsExternal { get; }
	public abstract bool IsDeclaredInExternal { get; }
	public abstract bool IsUnparsedEntity { get; }
	public abstract bool IsParameterEntity { get; }
	public abstract string BaseUriString { get; }
	public abstract string DeclaredUriString { get; }
	public abstract string SystemId { get; }
	public abstract string PublicId { get; }
	public abstract string Text { get; }
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsExternal();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsDeclaredInExternal();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsUnparsedEntity();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsParameterEntity();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_BaseUriString();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_DeclaredUriString();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_SystemId();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_PublicId();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_Text();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_LinePosition();
}

// Namespace: System.Xml
internal interface IDtdParser // TypeDefIndex: 3084
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDtdInfo ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDtdInfo ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter);
}

// Namespace: System.Xml
internal interface IDtdParserAdapter // TypeDefIndex: 3085
{
	// Properties
	public abstract XmlNameTable NameTable { get; }
	public abstract IXmlNamespaceResolver NamespaceResolver { get; }
	public abstract Uri BaseUri { get; }
	public abstract char[] ParsingBuffer { get; }
	public abstract int ParsingBufferLength { get; }
	public abstract int CurrentPosition { get; set; }
	public abstract int LineNo { get; }
	public abstract int LineStartPosition { get; }
	public abstract bool IsEof { get; }
	public abstract int EntityStackLength { get; }
	public abstract bool IsEntityEolNormalized { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlNameTable get_NameTable();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IXmlNamespaceResolver get_NamespaceResolver();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Uri get_BaseUri();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract char[] get_ParsingBuffer();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_ParsingBufferLength();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_CurrentPosition();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_CurrentPosition(int value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_LineNo();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_LineStartPosition();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsEof();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int get_EntityStackLength();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract bool get_IsEntityEolNormalized();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int ReadData();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void OnNewLine(int pos);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int ParseNumericCharRef(StringBuilder internalSubsetBuilder);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void ParsePI(StringBuilder sb);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void ParseComment(StringBuilder sb);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool PushEntity(IDtdEntityInfo entity, out int entityId);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool PushExternalSubset(string systemId, string publicId);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void PushInternalDtd(string baseUri, string internalDtd);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void Throw(Exception e);
}

// Namespace: System.Xml
internal interface IDtdParserAdapterWithValidation : IDtdParserAdapter // TypeDefIndex: 3086
{
	// Properties
	public abstract bool DtdValidation { get; }
	public abstract IValidationEventHandling ValidationEventHandling { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_DtdValidation();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IValidationEventHandling get_ValidationEventHandling();
}

// Namespace: System.Xml
internal interface IDtdParserAdapterV1 : IDtdParserAdapterWithValidation, IDtdParserAdapter // TypeDefIndex: 3087
{
	// Properties
	public abstract bool V1CompatibilityMode { get; }
	public abstract bool Normalization { get; }
	public abstract bool Namespaces { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_V1CompatibilityMode();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_Normalization();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_Namespaces();
}

// Namespace: System.Xml
internal sealed class OnRemoveWriter : MulticastDelegate // TypeDefIndex: 3088
{
	// Methods

	// RVA: 0x1C18674 Offset: 0x1C14674 VA: 0x1C18674
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C1877C Offset: 0x1C1477C VA: 0x1C1877C Slot: 12
	public virtual void Invoke(XmlRawWriter writer) { }
}

// Namespace: System.Xml
internal interface IValidationEventHandling // TypeDefIndex: 3089
{
	// Properties
	public abstract object EventHandler { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_EventHandler();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SendEvent(Exception exception, XmlSeverityType severity);
}

// Namespace: System.Xml
internal abstract class IncrementalReadDecoder // TypeDefIndex: 3090
{
	// Properties
	internal abstract bool IsFull { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract bool get_IsFull();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract int Decode(char[] chars, int startPos, int len);

	// RVA: 0x1C18790 Offset: 0x1C14790 VA: 0x1C18790
	protected void .ctor() { }
}

// Namespace: System.Xml
internal class IncrementalReadDummyDecoder : IncrementalReadDecoder // TypeDefIndex: 3091
{
	// Properties
	internal override bool IsFull { get; }

	// Methods

	// RVA: 0x1C18798 Offset: 0x1C14798 VA: 0x1C18798 Slot: 4
	internal override bool get_IsFull() { }

	// RVA: 0x1C187A0 Offset: 0x1C147A0 VA: 0x1C187A0 Slot: 5
	internal override int Decode(char[] chars, int startPos, int len) { }

	// RVA: 0x1C187A8 Offset: 0x1C147A8 VA: 0x1C187A8
	public void .ctor() { }
}

// Namespace: System.Xml
[Flags]
public enum NamespaceHandling // TypeDefIndex: 3092
{
	// Fields
	public int value__; // 0x0
	public const NamespaceHandling Default = 0;
	public const NamespaceHandling OmitDuplicates = 1;
}

// Namespace: System.Xml
public enum NewLineHandling // TypeDefIndex: 3093
{
	// Fields
	public int value__; // 0x0
	public const NewLineHandling Replace = 0;
	public const NewLineHandling Entitize = 1;
	public const NewLineHandling None = 2;
}

// Namespace: System.Xml
internal class QueryOutputWriter : XmlRawWriter // TypeDefIndex: 3094
{
	// Fields
	private XmlRawWriter wrapped; // 0x28
	private bool inCDataSection; // 0x30
	private Dictionary<XmlQualifiedName, int> lookupCDataElems; // 0x38
	private BitStack bitsCData; // 0x40
	private XmlQualifiedName qnameCData; // 0x48
	private bool outputDocType; // 0x50
	private bool checkWellFormedDoc; // 0x51
	private bool hasDocElem; // 0x52
	private bool inAttr; // 0x53
	private string systemId; // 0x58
	private string publicId; // 0x60
	private int depth; // 0x68

	// Properties
	internal override IXmlNamespaceResolver NamespaceResolver { set; }
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1C187B0 Offset: 0x1C147B0 VA: 0x1C187B0
	public void .ctor(XmlRawWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1C18AB0 Offset: 0x1C14AB0 VA: 0x1C18AB0 Slot: 35
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x1C18AF4 Offset: 0x1C14AF4 VA: 0x1C18AF4 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1C18B14 Offset: 0x1C14B14 VA: 0x1C18B14 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1C18B34 Offset: 0x1C14B34 VA: 0x1C18B34 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1C18B64 Offset: 0x1C14B64 VA: 0x1C18B64 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C18D2C Offset: 0x1C14D2C VA: 0x1C18D2C Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C18D8C Offset: 0x1C14D8C VA: 0x1C18D8C Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C18DEC Offset: 0x1C14DEC VA: 0x1C18DEC Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1C18E0C Offset: 0x1C14E0C VA: 0x1C18E0C Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1C18E34 Offset: 0x1C14E34 VA: 0x1C18E34 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1C18E5C Offset: 0x1C14E5C VA: 0x1C18E5C Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1C18E7C Offset: 0x1C14E7C VA: 0x1C18E7C Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1C18E9C Offset: 0x1C14E9C VA: 0x1C18E9C Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1C18EBC Offset: 0x1C14EBC VA: 0x1C18EBC Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1C18EDC Offset: 0x1C14EDC VA: 0x1C18EDC Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1C18EFC Offset: 0x1C14EFC VA: 0x1C18EFC Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1C18F24 Offset: 0x1C14F24 VA: 0x1C18F24 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1C18F4C Offset: 0x1C14F4C VA: 0x1C18F4C Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1C18FF8 Offset: 0x1C14FF8 VA: 0x1C18FF8 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1C19064 Offset: 0x1C15064 VA: 0x1C19064 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1C19114 Offset: 0x1C15114 VA: 0x1C19114 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1C1913C Offset: 0x1C1513C VA: 0x1C1913C Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1C19164 Offset: 0x1C15164 VA: 0x1C19164 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1C1918C Offset: 0x1C1518C VA: 0x1C1918C Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1C1923C Offset: 0x1C1523C VA: 0x1C1923C Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1C192A8 Offset: 0x1C152A8 VA: 0x1C192A8 Slot: 28
	public override void Close() { }

	// RVA: 0x1C1934C Offset: 0x1C1534C VA: 0x1C1934C Slot: 29
	public override void Flush() { }

	// RVA: 0x1C18FB8 Offset: 0x1C14FB8 VA: 0x1C18FB8
	private bool StartCDataSection() { }

	// RVA: 0x1C18D24 Offset: 0x1C14D24 VA: 0x1C18D24
	private void EndCDataSection() { }
}

// Namespace: 
private enum ReadContentAsBinaryHelper.State // TypeDefIndex: 3095
{
	// Fields
	public int value__; // 0x0
	public const ReadContentAsBinaryHelper.State None = 0;
	public const ReadContentAsBinaryHelper.State InReadContent = 1;
	public const ReadContentAsBinaryHelper.State InReadElementContent = 2;
}

// Namespace: System.Xml
internal class ReadContentAsBinaryHelper // TypeDefIndex: 3096
{
	// Fields
	private XmlReader reader; // 0x10
	private ReadContentAsBinaryHelper.State state; // 0x18
	private int valueOffset; // 0x1C
	private bool isEnd; // 0x20

	// Methods

	// RVA: 0x1C1936C Offset: 0x1C1536C VA: 0x1C1936C
	internal void Finish() { }

	// RVA: 0x1C195A8 Offset: 0x1C155A8 VA: 0x1C195A8
	internal void Reset() { }

	// RVA: 0x1C194B4 Offset: 0x1C154B4 VA: 0x1C194B4
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }
}

// Namespace: System.Xml
internal enum ElementProperties // TypeDefIndex: 3097
{
	// Fields
	public uint value__; // 0x0
	public const ElementProperties DEFAULT = 0;
	public const ElementProperties URI_PARENT = 1;
	public const ElementProperties BOOL_PARENT = 2;
	public const ElementProperties NAME_PARENT = 4;
	public const ElementProperties EMPTY = 8;
	public const ElementProperties NO_ENTITIES = 16;
	public const ElementProperties HEAD = 32;
	public const ElementProperties BLOCK_WS = 64;
	public const ElementProperties HAS_NS = 128;
}

// Namespace: System.Xml
internal enum AttributeProperties // TypeDefIndex: 3098
{
	// Fields
	public uint value__; // 0x0
	public const AttributeProperties DEFAULT = 0;
	public const AttributeProperties URI = 1;
	public const AttributeProperties BOOLEAN = 2;
	public const AttributeProperties NAME = 4;
}

// Namespace: System.Xml
internal class TernaryTreeReadOnly // TypeDefIndex: 3099
{
	// Fields
	private byte[] nodeBuffer; // 0x10

	// Methods

	// RVA: 0x1C195B4 Offset: 0x1C155B4 VA: 0x1C195B4
	public void .ctor(byte[] nodeBuffer) { }

	// RVA: 0x1C18330 Offset: 0x1C14330 VA: 0x1C18330
	public byte FindCaseInsensitiveString(string stringToFind) { }
}

// Namespace: System.Xml
public enum ReadState // TypeDefIndex: 3100
{
	// Fields
	public int value__; // 0x0
	public const ReadState Initial = 0;
	public const ReadState Interactive = 1;
	public const ReadState Error = 2;
	public const ReadState EndOfFile = 3;
	public const ReadState Closed = 4;
}

// Namespace: 
private sealed class SecureStringHasher.HashCodeOfStringDelegate : MulticastDelegate // TypeDefIndex: 3101
{
	// Methods

	// RVA: 0x1C19870 Offset: 0x1C15870 VA: 0x1C19870
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C19924 Offset: 0x1C15924 VA: 0x1C19924 Slot: 12
	public virtual int Invoke(string s, int sLen, long additionalEntropy) { }
}

// Namespace: System.Xml
internal class SecureStringHasher : IEqualityComparer<string> // TypeDefIndex: 3102
{
	// Fields
	private static SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private int hashCodeRandomizer; // 0x10

	// Methods

	// RVA: 0x1C195E4 Offset: 0x1C155E4 VA: 0x1C195E4
	public void .ctor() { }

	// RVA: 0x1C19608 Offset: 0x1C15608 VA: 0x1C19608 Slot: 4
	public bool Equals(string x, string y) { }

	// RVA: 0x1C1961C Offset: 0x1C1561C VA: 0x1C1961C Slot: 5
	public int GetHashCode(string key) { }

	// RVA: 0x1C19804 Offset: 0x1C15804 VA: 0x1C19804
	private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy) { }

	// RVA: 0x1C196C8 Offset: 0x1C156C8 VA: 0x1C196C8
	private static SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate() { }
}

// Namespace: System.Xml
internal class TextEncodedRawTextWriter : XmlEncodedRawTextWriter // TypeDefIndex: 3103
{
	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1C19938 Offset: 0x1C15938 VA: 0x1C19938
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1C19A38 Offset: 0x1C15A38 VA: 0x1C19A38
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1C19D4C Offset: 0x1C15D4C VA: 0x1C19D4C Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1C19D50 Offset: 0x1C15D50 VA: 0x1C19D50 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1C19D54 Offset: 0x1C15D54 VA: 0x1C19D54 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1C19D58 Offset: 0x1C15D58 VA: 0x1C19D58 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C19D5C Offset: 0x1C15D5C VA: 0x1C19D5C Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C19D60 Offset: 0x1C15D60 VA: 0x1C19D60 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C19D64 Offset: 0x1C15D64 VA: 0x1C19D64 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1C19D68 Offset: 0x1C15D68 VA: 0x1C19D68 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1C19D74 Offset: 0x1C15D74 VA: 0x1C19D74 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1C19D7C Offset: 0x1C15D7C VA: 0x1C19D7C Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1C19D80 Offset: 0x1C15D80 VA: 0x1C19D80 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1C19D88 Offset: 0x1C15D88 VA: 0x1C19D88 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1C19DF0 Offset: 0x1C15DF0 VA: 0x1C19DF0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1C19DF4 Offset: 0x1C15DF4 VA: 0x1C19DF4 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1C19DF8 Offset: 0x1C15DF8 VA: 0x1C19DF8 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1C19DFC Offset: 0x1C15DFC VA: 0x1C19DFC Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1C19E00 Offset: 0x1C15E00 VA: 0x1C19E00 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1C19E04 Offset: 0x1C15E04 VA: 0x1C19E04 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1C19E14 Offset: 0x1C15E14 VA: 0x1C19E14 Slot: 20
	public override void WriteString(string textBlock) { }

	// RVA: 0x1C19E24 Offset: 0x1C15E24 VA: 0x1C19E24 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1C19EB0 Offset: 0x1C15EB0 VA: 0x1C19EB0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1C19EC0 Offset: 0x1C15EC0 VA: 0x1C19EC0 Slot: 24
	public override void WriteRaw(string data) { }
}

// Namespace: System.Xml
internal class TextUtf8RawTextWriter : XmlUtf8RawTextWriter // TypeDefIndex: 3104
{
	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1C19ED0 Offset: 0x1C15ED0 VA: 0x1C19ED0
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1C19ED8 Offset: 0x1C15ED8 VA: 0x1C19ED8 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1C19EDC Offset: 0x1C15EDC VA: 0x1C19EDC Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1C19EE0 Offset: 0x1C15EE0 VA: 0x1C19EE0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1C19EE4 Offset: 0x1C15EE4 VA: 0x1C19EE4 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C19EE8 Offset: 0x1C15EE8 VA: 0x1C19EE8 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C19EEC Offset: 0x1C15EEC VA: 0x1C19EEC Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C19EF0 Offset: 0x1C15EF0 VA: 0x1C19EF0 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1C19EF4 Offset: 0x1C15EF4 VA: 0x1C19EF4 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1C19F00 Offset: 0x1C15F00 VA: 0x1C19F00 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1C19F08 Offset: 0x1C15F08 VA: 0x1C19F08 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1C19F0C Offset: 0x1C15F0C VA: 0x1C19F0C Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1C19F14 Offset: 0x1C15F14 VA: 0x1C19F14 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1C19F1C Offset: 0x1C15F1C VA: 0x1C19F1C Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1C19F20 Offset: 0x1C15F20 VA: 0x1C19F20 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1C19F24 Offset: 0x1C15F24 VA: 0x1C19F24 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1C19F28 Offset: 0x1C15F28 VA: 0x1C19F28 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1C19F2C Offset: 0x1C15F2C VA: 0x1C19F2C Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1C19F30 Offset: 0x1C15F30 VA: 0x1C19F30 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1C19F44 Offset: 0x1C15F44 VA: 0x1C19F44 Slot: 20
	public override void WriteString(string textBlock) { }

	// RVA: 0x1C19F58 Offset: 0x1C15F58 VA: 0x1C19F58 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1C19F6C Offset: 0x1C15F6C VA: 0x1C19F6C Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1C19F80 Offset: 0x1C15F80 VA: 0x1C19F80 Slot: 24
	public override void WriteRaw(string data) { }
}

// Namespace: System.Xml
internal class ValidatingReaderNodeData // TypeDefIndex: 3105
{
	// Fields
	private string localName; // 0x10
	private string namespaceUri; // 0x18
	private string prefix; // 0x20
	private string nameWPrefix; // 0x28
	private string rawValue; // 0x30
	private string originalStringValue; // 0x38
	private int depth; // 0x40
	private AttributePSVIInfo attributePSVIInfo; // 0x48
	private XmlNodeType nodeType; // 0x50
	private int lineNo; // 0x54
	private int linePos; // 0x58

	// Properties
	public string LocalName { get; set; }
	public string Namespace { get; set; }
	public string Prefix { get; set; }
	public int Depth { get; set; }
	public string RawValue { get; set; }
	public string OriginalStringValue { get; }
	public XmlNodeType NodeType { get; set; }
	public AttributePSVIInfo AttInfo { get; set; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x1C19F94 Offset: 0x1C15F94 VA: 0x1C19F94
	public void .ctor() { }

	// RVA: 0x1C1A060 Offset: 0x1C16060 VA: 0x1C1A060
	public void .ctor(XmlNodeType nodeType) { }

	// RVA: 0x1C1A08C Offset: 0x1C1608C VA: 0x1C1A08C
	public string get_LocalName() { }

	// RVA: 0x1C1A094 Offset: 0x1C16094 VA: 0x1C1A094
	public void set_LocalName(string value) { }

	// RVA: 0x1C1A09C Offset: 0x1C1609C VA: 0x1C1A09C
	public string get_Namespace() { }

	// RVA: 0x1C1A0A4 Offset: 0x1C160A4 VA: 0x1C1A0A4
	public void set_Namespace(string value) { }

	// RVA: 0x1C1A0AC Offset: 0x1C160AC VA: 0x1C1A0AC
	public string get_Prefix() { }

	// RVA: 0x1C1A0B4 Offset: 0x1C160B4 VA: 0x1C1A0B4
	public void set_Prefix(string value) { }

	// RVA: 0x1C1A0BC Offset: 0x1C160BC VA: 0x1C1A0BC
	public string GetAtomizedNameWPrefix(XmlNameTable nameTable) { }

	// RVA: 0x1C1A160 Offset: 0x1C16160 VA: 0x1C1A160
	public int get_Depth() { }

	// RVA: 0x1C1A168 Offset: 0x1C16168 VA: 0x1C1A168
	public void set_Depth(int value) { }

	// RVA: 0x1C1A170 Offset: 0x1C16170 VA: 0x1C1A170
	public string get_RawValue() { }

	// RVA: 0x1C1A178 Offset: 0x1C16178 VA: 0x1C1A178
	public void set_RawValue(string value) { }

	// RVA: 0x1C1A180 Offset: 0x1C16180 VA: 0x1C1A180
	public string get_OriginalStringValue() { }

	// RVA: 0x1C1A188 Offset: 0x1C16188 VA: 0x1C1A188
	public XmlNodeType get_NodeType() { }

	// RVA: 0x1C1A190 Offset: 0x1C16190 VA: 0x1C1A190
	public void set_NodeType(XmlNodeType value) { }

	// RVA: 0x1C1A198 Offset: 0x1C16198 VA: 0x1C1A198
	public AttributePSVIInfo get_AttInfo() { }

	// RVA: 0x1C1A1A0 Offset: 0x1C161A0 VA: 0x1C1A1A0
	public void set_AttInfo(AttributePSVIInfo value) { }

	// RVA: 0x1C1A1A8 Offset: 0x1C161A8 VA: 0x1C1A1A8
	public int get_LineNumber() { }

	// RVA: 0x1C1A1B0 Offset: 0x1C161B0 VA: 0x1C1A1B0
	public int get_LinePosition() { }

	// RVA: 0x1C19FB4 Offset: 0x1C15FB4 VA: 0x1C19FB4
	internal void Clear(XmlNodeType nodeType) { }

	// RVA: 0x1C1A1B8 Offset: 0x1C161B8 VA: 0x1C1A1B8
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x1C1A1C0 Offset: 0x1C161C0 VA: 0x1C1A1C0
	internal void SetLineInfo(IXmlLineInfo lineInfo) { }

	// RVA: 0x1C1A2C8 Offset: 0x1C162C8 VA: 0x1C1A2C8
	internal void SetItemData(string localName, string prefix, string ns, int depth) { }

	// RVA: 0x1C1A33C Offset: 0x1C1633C VA: 0x1C1A33C
	internal void SetItemData(string value) { }

	// RVA: 0x1C1A36C Offset: 0x1C1636C VA: 0x1C1A36C
	internal void SetItemData(string value, string originalStringValue) { }
}

// Namespace: System.Xml
public enum ValidationType // TypeDefIndex: 3106
{
	// Fields
	public int value__; // 0x0
	public const ValidationType None = 0;
	[Obsolete("Validation type should be specified as DTD or Schema.")]
	public const ValidationType Auto = 1;
	public const ValidationType DTD = 2;
	[Obsolete("XDR Validation through XmlValidatingReader is obsoleted")]
	public const ValidationType XDR = 3;
	public const ValidationType Schema = 4;
}

// Namespace: System.Xml
public enum WhitespaceHandling // TypeDefIndex: 3107
{
	// Fields
	public int value__; // 0x0
	public const WhitespaceHandling All = 0;
	public const WhitespaceHandling Significant = 1;
	public const WhitespaceHandling None = 2;
}

// Namespace: System.Xml
[DefaultMember("Item")]
internal class XmlAsyncCheckReader : XmlReader // TypeDefIndex: 3108
{
	// Fields
	private readonly XmlReader coreReader; // 0x10
	private Task lastTask; // 0x18

	// Properties
	internal XmlReader CoreReader { get; }
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }
	public override bool HasAttributes { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x1C1A39C Offset: 0x1C1639C VA: 0x1C1A39C
	internal XmlReader get_CoreReader() { }

	// RVA: 0x1C1A3A4 Offset: 0x1C163A4 VA: 0x1C1A3A4
	public static XmlAsyncCheckReader CreateAsyncCheckWrapper(XmlReader reader) { }

	// RVA: 0x1C1A7C8 Offset: 0x1C167C8 VA: 0x1C1A7C8
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1C1A880 Offset: 0x1C16880 VA: 0x1C1A880
	private void CheckAsync() { }

	// RVA: 0x1C1A8FC Offset: 0x1C168FC VA: 0x1C1A8FC Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1C1AA88 Offset: 0x1C16A88 VA: 0x1C1AA88 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C1AAB0 Offset: 0x1C16AB0 VA: 0x1C1AAB0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1C1AAD8 Offset: 0x1C16AD8 VA: 0x1C1AAD8 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1C1AB00 Offset: 0x1C16B00 VA: 0x1C1AB00 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1C1AB28 Offset: 0x1C16B28 VA: 0x1C1AB28 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1C1AB50 Offset: 0x1C16B50 VA: 0x1C1AB50 Slot: 11
	public override string get_Value() { }

	// RVA: 0x1C1AB78 Offset: 0x1C16B78 VA: 0x1C1AB78 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x1C1ABA0 Offset: 0x1C16BA0 VA: 0x1C1ABA0 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x1C1ABCC Offset: 0x1C16BCC VA: 0x1C1ABCC Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1C1ABF8 Offset: 0x1C16BF8 VA: 0x1C1ABF8 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1C1AC24 Offset: 0x1C16C24 VA: 0x1C1AC24 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x1C1AC50 Offset: 0x1C16C50 VA: 0x1C1AC50 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1C1AC7C Offset: 0x1C16C7C VA: 0x1C1AC7C Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x1C1ACA8 Offset: 0x1C16CA8 VA: 0x1C1ACA8 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1C1ACD4 Offset: 0x1C16CD4 VA: 0x1C1ACD4 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0x1C1AD00 Offset: 0x1C16D00 VA: 0x1C1AD00 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x1C1AD2C Offset: 0x1C16D2C VA: 0x1C1AD2C Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x1C1AD68 Offset: 0x1C16D68 VA: 0x1C1AD68 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x1C1ADAC Offset: 0x1C16DAC VA: 0x1C1ADAC Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x1C1ADE8 Offset: 0x1C16DE8 VA: 0x1C1ADE8 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1C1AE24 Offset: 0x1C16E24 VA: 0x1C1AE24 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1C1AE60 Offset: 0x1C16E60 VA: 0x1C1AE60 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1C1AE8C Offset: 0x1C16E8C VA: 0x1C1AE8C Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1C1AEB8 Offset: 0x1C16EB8 VA: 0x1C1AEB8 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x1C1AEE4 Offset: 0x1C16EE4 VA: 0x1C1AEE4 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x1C1AF10 Offset: 0x1C16F10 VA: 0x1C1AF10 Slot: 31
	public override bool Read() { }

	// RVA: 0x1C1AF3C Offset: 0x1C16F3C VA: 0x1C1AF3C Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x1C1AF68 Offset: 0x1C16F68 VA: 0x1C1AF68 Slot: 33
	public override void Close() { }

	// RVA: 0x1C1AF94 Offset: 0x1C16F94 VA: 0x1C1AF94 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x1C1AFC0 Offset: 0x1C16FC0 VA: 0x1C1AFC0 Slot: 35
	public override void Skip() { }

	// RVA: 0x1C1AFEC Offset: 0x1C16FEC VA: 0x1C1AFEC Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1C1B018 Offset: 0x1C17018 VA: 0x1C1B018 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1C1B054 Offset: 0x1C17054 VA: 0x1C1B054 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1C1B080 Offset: 0x1C17080 VA: 0x1C1B080 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1C1B0AC Offset: 0x1C170AC VA: 0x1C1B0AC Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1C1B0D8 Offset: 0x1C170D8 VA: 0x1C1B0D8 Slot: 41
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0x1C1B12C Offset: 0x1C1712C VA: 0x1C1B12C Slot: 42
	public override string ReadString() { }

	// RVA: 0x1C1B158 Offset: 0x1C17158 VA: 0x1C1B158 Slot: 43
	public override XmlNodeType MoveToContent() { }

	// RVA: 0x1C1B184 Offset: 0x1C17184 VA: 0x1C1B184 Slot: 44
	public override void ReadStartElement() { }

	// RVA: 0x1C1B1B0 Offset: 0x1C171B0 VA: 0x1C1B1B0 Slot: 45
	public override string ReadElementString() { }

	// RVA: 0x1C1B1DC Offset: 0x1C171DC VA: 0x1C1B1DC Slot: 46
	public override void ReadEndElement() { }

	// RVA: 0x1C1B208 Offset: 0x1C17208 VA: 0x1C1B208 Slot: 47
	public override bool IsStartElement(string localname, string ns) { }

	// RVA: 0x1C1B24C Offset: 0x1C1724C VA: 0x1C1B24C Slot: 48
	public override string ReadInnerXml() { }

	// RVA: 0x1C1B278 Offset: 0x1C17278 VA: 0x1C1B278 Slot: 49
	public override bool get_HasAttributes() { }

	// RVA: 0x1C1B2A4 Offset: 0x1C172A4 VA: 0x1C1B2A4 Slot: 50
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1C1B2E8 Offset: 0x1C172E8 VA: 0x1C1B2E8 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1C1B314 Offset: 0x1C17314 VA: 0x1C1B314 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }
}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithNS : XmlAsyncCheckReader, IXmlNamespaceResolver // TypeDefIndex: 3109
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x20

	// Methods

	// RVA: 0x1C1A720 Offset: 0x1C16720 VA: 0x1C1A720
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1C1B340 Offset: 0x1C17340 VA: 0x1C1B340 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1C1B3E8 Offset: 0x1C173E8 VA: 0x1C1B3E8 Slot: 54
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1C1B494 Offset: 0x1C17494 VA: 0x1C1B494 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }
}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfo : XmlAsyncCheckReader, IXmlLineInfo // TypeDefIndex: 3110
{
	// Fields
	private readonly IXmlLineInfo readerAsIXmlLineInfo; // 0x20

	// Properties
	public virtual int LineNumber { get; }
	public virtual int LinePosition { get; }

	// Methods

	// RVA: 0x1C1A678 Offset: 0x1C16678 VA: 0x1C1A678
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1C1B540 Offset: 0x1C17540 VA: 0x1C1B540 Slot: 56
	public virtual bool HasLineInfo() { }

	// RVA: 0x1C1B5E0 Offset: 0x1C175E0 VA: 0x1C1B5E0 Slot: 57
	public virtual int get_LineNumber() { }

	// RVA: 0x1C1B684 Offset: 0x1C17684 VA: 0x1C1B684 Slot: 58
	public virtual int get_LinePosition() { }
}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNS : XmlAsyncCheckReaderWithLineInfo, IXmlNamespaceResolver // TypeDefIndex: 3111
{
	// Fields
	private readonly IXmlNamespaceResolver readerAsIXmlNamespaceResolver; // 0x28

	// Methods

	// RVA: 0x1C1A5D0 Offset: 0x1C165D0 VA: 0x1C1A5D0
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1C1B728 Offset: 0x1C17728 VA: 0x1C1B728 Slot: 59
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1C1B7D0 Offset: 0x1C177D0 VA: 0x1C1B7D0 Slot: 60
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1C1B87C Offset: 0x1C1787C VA: 0x1C1B87C Slot: 61
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }
}

// Namespace: System.Xml
internal class XmlAsyncCheckReaderWithLineInfoNSSchema : XmlAsyncCheckReaderWithLineInfoNS, IXmlSchemaInfo // TypeDefIndex: 3112
{
	// Fields
	private readonly IXmlSchemaInfo readerAsIXmlSchemaInfo; // 0x30

	// Properties
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsDefault { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsNil { get; }
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType { get; }
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType { get; }
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement { get; }
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute { get; }

	// Methods

	// RVA: 0x1C1A528 Offset: 0x1C16528 VA: 0x1C1A528
	public void .ctor(XmlReader reader) { }

	// RVA: 0x1C1B928 Offset: 0x1C17928 VA: 0x1C1B928 Slot: 62
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x1C1B9C8 Offset: 0x1C179C8 VA: 0x1C1B9C8 Slot: 63
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x1C1BA6C Offset: 0x1C17A6C VA: 0x1C1BA6C Slot: 64
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x1C1BB10 Offset: 0x1C17B10 VA: 0x1C1BB10 Slot: 65
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x1C1BBB4 Offset: 0x1C17BB4 VA: 0x1C1BBB4 Slot: 66
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x1C1BC58 Offset: 0x1C17C58 VA: 0x1C1BC58 Slot: 67
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x1C1BCFC Offset: 0x1C17CFC VA: 0x1C1BCFC Slot: 68
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }
}

// Namespace: System.Xml
internal class XmlAsyncCheckWriter : XmlWriter // TypeDefIndex: 3113
{
	// Fields
	private readonly XmlWriter coreWriter; // 0x18
	private Task lastTask; // 0x20

	// Properties
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x1C1BDA0 Offset: 0x1C17DA0 VA: 0x1C1BDA0
	public void .ctor(XmlWriter writer) { }

	// RVA: 0x1C1BE2C Offset: 0x1C17E2C VA: 0x1C1BE2C
	private void CheckAsync() { }

	// RVA: 0x1C1BEA8 Offset: 0x1C17EA8 VA: 0x1C1BEA8 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1C1BED0 Offset: 0x1C17ED0 VA: 0x1C1BED0 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1C1BF08 Offset: 0x1C17F08 VA: 0x1C1BF08 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1C1BF30 Offset: 0x1C17F30 VA: 0x1C1BF30 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1C1BF88 Offset: 0x1C17F88 VA: 0x1C1BF88 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C1BFD8 Offset: 0x1C17FD8 VA: 0x1C1BFD8 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1C1C000 Offset: 0x1C18000 VA: 0x1C1C000 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1C1C028 Offset: 0x1C18028 VA: 0x1C1C028 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1C1C078 Offset: 0x1C18078 VA: 0x1C1C078 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1C1C0A4 Offset: 0x1C180A4 VA: 0x1C1C0A4 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1C1C0E0 Offset: 0x1C180E0 VA: 0x1C1C0E0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1C1C11C Offset: 0x1C1811C VA: 0x1C1C11C Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1C1C160 Offset: 0x1C18160 VA: 0x1C1C160 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1C1C19C Offset: 0x1C1819C VA: 0x1C1C19C Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1C1C1D8 Offset: 0x1C181D8 VA: 0x1C1C1D8 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1C1C214 Offset: 0x1C18214 VA: 0x1C1C214 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1C1C250 Offset: 0x1C18250 VA: 0x1C1C250 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1C1C294 Offset: 0x1C18294 VA: 0x1C1C294 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1C1C2E8 Offset: 0x1C182E8 VA: 0x1C1C2E8 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1C1C33C Offset: 0x1C1833C VA: 0x1C1C33C Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1C1C378 Offset: 0x1C18378 VA: 0x1C1C378 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1C1C3CC Offset: 0x1C183CC VA: 0x1C1C3CC Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1C1C420 Offset: 0x1C18420 VA: 0x1C1C420 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1C1C44C Offset: 0x1C1844C VA: 0x1C1C44C Slot: 28
	public override void Close() { }

	// RVA: 0x1C1C478 Offset: 0x1C18478 VA: 0x1C1C478 Slot: 29
	public override void Flush() { }

	// RVA: 0x1C1C4A4 Offset: 0x1C184A4 VA: 0x1C1C4A4 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1C1C4E0 Offset: 0x1C184E0 VA: 0x1C1C4E0 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x1C1C51C Offset: 0x1C1851C VA: 0x1C1C51C Slot: 32
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x1C1C560 Offset: 0x1C18560 VA: 0x1C1C560 Slot: 33
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x1C1C5A4 Offset: 0x1C185A4 VA: 0x1C1C5A4 Slot: 34
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Xml
internal class XmlAutoDetectWriter : XmlRawWriter // TypeDefIndex: 3114
{
	// Fields
	private XmlRawWriter wrapped; // 0x28
	private OnRemoveWriter onRemove; // 0x30
	private XmlWriterSettings writerSettings; // 0x38
	private XmlEventCache eventCache; // 0x40
	private TextWriter textWriter; // 0x48
	private Stream strm; // 0x50

	// Properties
	internal override IXmlNamespaceResolver NamespaceResolver { set; }
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1C1C5C8 Offset: 0x1C185C8 VA: 0x1C1C5C8
	private void .ctor(XmlWriterSettings writerSettings) { }

	// RVA: 0x1C1C6DC Offset: 0x1C186DC VA: 0x1C1C6DC
	public void .ctor(TextWriter textWriter, XmlWriterSettings writerSettings) { }

	// RVA: 0x1C1C70C Offset: 0x1C1870C VA: 0x1C1C70C
	public void .ctor(Stream strm, XmlWriterSettings writerSettings) { }

	// RVA: 0x1C1C73C Offset: 0x1C1873C VA: 0x1C1C73C Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1C1C7B4 Offset: 0x1C187B4 VA: 0x1C1C7B4 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C1CA88 Offset: 0x1C18A88 VA: 0x1C1CA88 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1C1CAE8 Offset: 0x1C18AE8 VA: 0x1C1CAE8 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1C1CB08 Offset: 0x1C18B08 VA: 0x1C1CB08 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1C1CBB0 Offset: 0x1C18BB0 VA: 0x1C1CBB0 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1C1CBDC Offset: 0x1C18BDC VA: 0x1C1CBDC Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1C1CC08 Offset: 0x1C18C08 VA: 0x1C1CC08 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1C1CC34 Offset: 0x1C18C34 VA: 0x1C1CC34 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1C1CC7C Offset: 0x1C18C7C VA: 0x1C1CC7C Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1C1CCAC Offset: 0x1C18CAC VA: 0x1C1CCAC Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1C1CCDC Offset: 0x1C18CDC VA: 0x1C1CCDC Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1C1CD24 Offset: 0x1C18D24 VA: 0x1C1CD24 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1C1CD70 Offset: 0x1C18D70 VA: 0x1C1CD70 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1C1CDBC Offset: 0x1C18DBC VA: 0x1C1CDBC Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1C1CE10 Offset: 0x1C18E10 VA: 0x1C1CE10 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1C1CE74 Offset: 0x1C18E74 VA: 0x1C1CE74 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1C1CED8 Offset: 0x1C18ED8 VA: 0x1C1CED8 Slot: 28
	public override void Close() { }

	// RVA: 0x1C1CF14 Offset: 0x1C18F14 VA: 0x1C1CF14 Slot: 29
	public override void Flush() { }

	// RVA: 0x1C1CF50 Offset: 0x1C18F50 VA: 0x1C1CF50 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x1C1CF9C Offset: 0x1C18F9C VA: 0x1C1CF9C Slot: 35
	internal override void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x1C1CFEC Offset: 0x1C18FEC VA: 0x1C1CFEC Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1C1D038 Offset: 0x1C19038 VA: 0x1C1D038 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1C1D084 Offset: 0x1C19084 VA: 0x1C1D084 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1C1D0A4 Offset: 0x1C190A4 VA: 0x1C1D0A4 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C1D0C4 Offset: 0x1C190C4 VA: 0x1C1D0C4 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C1D0E4 Offset: 0x1C190E4 VA: 0x1C1D0E4 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1C1D138 Offset: 0x1C19138 VA: 0x1C1D138 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1C1D158 Offset: 0x1C19158 VA: 0x1C1D158 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1C1D1A4 Offset: 0x1C191A4 VA: 0x1C1D1A4 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1C1C834 Offset: 0x1C18834 VA: 0x1C1C834
	private static bool IsHtmlTag(string tagName) { }

	// RVA: 0x1C1C7A4 Offset: 0x1C187A4 VA: 0x1C1C7A4
	private void EnsureWrappedWriter(XmlOutputMethod outMethod) { }

	// RVA: 0x1C1CB50 Offset: 0x1C18B50 VA: 0x1C1CB50
	private bool TextBlockCreatesWriter(string textBlock) { }

	// RVA: 0x1C1C948 Offset: 0x1C18948 VA: 0x1C1C948
	private void CreateWrappedWriter(XmlOutputMethod outMethod) { }
}

// Namespace: System.Xml
internal class XmlEncodedRawTextWriter : XmlRawWriter // TypeDefIndex: 3115
{
	// Fields
	private readonly bool useAsync; // 0x28
	protected byte[] bufBytes; // 0x30
	protected Stream stream; // 0x38
	protected Encoding encoding; // 0x40
	protected XmlCharType xmlCharType; // 0x48
	protected int bufPos; // 0x50
	protected int textPos; // 0x54
	protected int contentPos; // 0x58
	protected int cdataPos; // 0x5C
	protected int attrEndPos; // 0x60
	protected int bufLen; // 0x64
	protected bool writeToNull; // 0x68
	protected bool hadDoubleBracket; // 0x69
	protected bool inAttributeValue; // 0x6A
	protected int bufBytesUsed; // 0x6C
	protected char[] bufChars; // 0x70
	protected Encoder encoder; // 0x78
	protected TextWriter writer; // 0x80
	protected bool trackTextContent; // 0x88
	protected bool inTextContent; // 0x89
	private int lastMarkPos; // 0x8C
	private int[] textContentMarks; // 0x90
	private CharEntityEncoderFallback charEntityFallback; // 0x98
	protected NewLineHandling newLineHandling; // 0xA0
	protected bool closeOutput; // 0xA4
	protected bool omitXmlDeclaration; // 0xA5
	protected string newLineChars; // 0xA8
	protected bool checkCharacters; // 0xB0
	protected XmlStandalone standalone; // 0xB4
	protected XmlOutputMethod outputMethod; // 0xB8
	protected bool autoXmlDeclaration; // 0xBC
	protected bool mergeCDataSections; // 0xBD

	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1C1D8B8 Offset: 0x1C198B8 VA: 0x1C1D8B8
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x1C1993C Offset: 0x1C1593C VA: 0x1C1993C
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1C19A3C Offset: 0x1C15A3C VA: 0x1C19A3C
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1C1DCF0 Offset: 0x1C19CF0 VA: 0x1C1DCF0 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1C1DF0C Offset: 0x1C19F0C VA: 0x1C1DF0C Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1C1DF84 Offset: 0x1C19F84 VA: 0x1C1DF84 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1C1E174 Offset: 0x1C1A174 VA: 0x1C1E174 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C1E23C Offset: 0x1C1A23C VA: 0x1C1E23C Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1C1E280 Offset: 0x1C1A280 VA: 0x1C1E280 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C1E3F0 Offset: 0x1C1A3F0 VA: 0x1C1E3F0 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C1E4F8 Offset: 0x1C1A4F8 VA: 0x1C1E4F8 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1C1E618 Offset: 0x1C1A618 VA: 0x1C1E618 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1C1E680 Offset: 0x1C1A680 VA: 0x1C1E680 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x1C1E6D4 Offset: 0x1C1A6D4 VA: 0x1C1E6D4 Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1C1E6DC Offset: 0x1C1A6DC VA: 0x1C1E6DC Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1C1E800 Offset: 0x1C1A800 VA: 0x1C1E800 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1C1E868 Offset: 0x1C1A868 VA: 0x1C1E868 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1C1ED64 Offset: 0x1C1AD64 VA: 0x1C1ED64 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1C1F188 Offset: 0x1C1B188 VA: 0x1C1F188 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1C1F2B4 Offset: 0x1C1B2B4 VA: 0x1C1F2B4 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1C1F380 Offset: 0x1C1B380 VA: 0x1C1F380 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1C1F544 Offset: 0x1C1B544 VA: 0x1C1F544 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1C1FB3C Offset: 0x1C1BB3C VA: 0x1C1FB3C Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1C1FBA8 Offset: 0x1C1BBA8 VA: 0x1C1FBA8 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1C1FCF0 Offset: 0x1C1BCF0 VA: 0x1C1FCF0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1C19E34 Offset: 0x1C15E34 VA: 0x1C19E34 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1C19D8C Offset: 0x1C15D8C VA: 0x1C19D8C Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1C1FF80 Offset: 0x1C1BF80 VA: 0x1C1FF80 Slot: 28
	public override void Close() { }

	// RVA: 0x1C20098 Offset: 0x1C1C098 VA: 0x1C20098 Slot: 29
	public override void Flush() { }

	// RVA: 0x1C200F0 Offset: 0x1C1C0F0 VA: 0x1C200F0 Slot: 48
	protected virtual void FlushBuffer() { }

	// RVA: 0x1C20314 Offset: 0x1C1C314 VA: 0x1C20314
	private void EncodeChars(int startOffset, int endOffset, bool writeAllToStream) { }

	// RVA: 0x1C1FFFC Offset: 0x1C1BFFC VA: 0x1C1FFFC
	private void FlushEncoder() { }

	// RVA: 0x1C1F5B0 Offset: 0x1C1B5B0 VA: 0x1C1F5B0
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1C1F8AC Offset: 0x1C1B8AC VA: 0x1C1F8AC
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1C1DED0 Offset: 0x1C19ED0 VA: 0x1C1DED0
	protected void RawText(string s) { }

	// RVA: 0x1C20744 Offset: 0x1C1C744 VA: 0x1C20744
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x1C1FD78 Offset: 0x1C1BD78 VA: 0x1C1FD78
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x1C1EE90 Offset: 0x1C1AE90 VA: 0x1C1EE90
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x1C1EA48 Offset: 0x1C1AA48 VA: 0x1C1EA48
	protected void WriteCDataSection(string text) { }

	// RVA: 0x1C20530 Offset: 0x1C1C530 VA: 0x1C20530
	private static char* EncodeSurrogate(char* pSrc, char* pSrcEnd, char* pDst) { }

	// RVA: 0x1C20684 Offset: 0x1C1C684 VA: 0x1C20684
	private char* InvalidXmlChar(int ch, char* pDst, bool entitize) { }

	// RVA: 0x1C209C0 Offset: 0x1C1C9C0 VA: 0x1C209C0
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref char* pDst) { }

	// RVA: 0x1C1DE60 Offset: 0x1C19E60 VA: 0x1C1DE60
	protected void ChangeTextContentMark(bool value) { }

	// RVA: 0x1C20A64 Offset: 0x1C1CA64 VA: 0x1C20A64
	private void GrowTextContentMarks() { }

	// RVA: 0x1C206E8 Offset: 0x1C1C6E8 VA: 0x1C206E8
	protected char* WriteNewLine(char* pDst) { }

	// RVA: 0x1C2046C Offset: 0x1C1C46C VA: 0x1C2046C
	protected static char* LtEntity(char* pDst) { }

	// RVA: 0x1C20484 Offset: 0x1C1C484 VA: 0x1C20484
	protected static char* GtEntity(char* pDst) { }

	// RVA: 0x1C20448 Offset: 0x1C1C448 VA: 0x1C20448
	protected static char* AmpEntity(char* pDst) { }

	// RVA: 0x1C2049C Offset: 0x1C1C49C VA: 0x1C2049C
	protected static char* QuoteEntity(char* pDst) { }

	// RVA: 0x1C204C4 Offset: 0x1C1C4C4 VA: 0x1C204C4
	protected static char* TabEntity(char* pDst) { }

	// RVA: 0x1C2050C Offset: 0x1C1C50C VA: 0x1C2050C
	protected static char* LineFeedEntity(char* pDst) { }

	// RVA: 0x1C204E8 Offset: 0x1C1C4E8 VA: 0x1C204E8
	protected static char* CarriageReturnEntity(char* pDst) { }

	// RVA: 0x1C20900 Offset: 0x1C1C900 VA: 0x1C20900
	private static char* CharEntity(char* pDst, char ch) { }

	// RVA: 0x1C208C8 Offset: 0x1C1C8C8 VA: 0x1C208C8
	protected static char* RawStartCData(char* pDst) { }

	// RVA: 0x1C208AC Offset: 0x1C1C8AC VA: 0x1C208AC
	protected static char* RawEndCData(char* pDst) { }

	// RVA: 0x1C1D9B4 Offset: 0x1C199B4 VA: 0x1C1D9B4
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }
}

// Namespace: System.Xml
internal class XmlEncodedRawTextWriterIndent : XmlEncodedRawTextWriter // TypeDefIndex: 3116
{
	// Fields
	protected int indentLevel; // 0xC0
	protected bool newLineOnAttributes; // 0xC4
	protected string indentChars; // 0xC8
	protected bool mixedContent; // 0xD0
	private BitStack mixedContentStack; // 0xD8
	protected ConformanceLevel conformanceLevel; // 0xE0

	// Methods

	// RVA: 0x1C20AEC Offset: 0x1C1CAEC VA: 0x1C20AEC
	public void .ctor(TextWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1C20C24 Offset: 0x1C1CC24 VA: 0x1C20C24
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1C20C4C Offset: 0x1C1CC4C VA: 0x1C20C4C Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1C20CF4 Offset: 0x1C1CCF4 VA: 0x1C20CF4 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C20D60 Offset: 0x1C1CD60 VA: 0x1C20D60 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1C20DB0 Offset: 0x1C1CDB0 VA: 0x1C20DB0 Slot: 39
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x1C20DB8 Offset: 0x1C1CDB8 VA: 0x1C20DB8 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C20E3C Offset: 0x1C1CE3C VA: 0x1C20E3C Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C20EC0 Offset: 0x1C1CEC0 VA: 0x1C20EC0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1C20EFC Offset: 0x1C1CEFC VA: 0x1C20EFC Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1C20F08 Offset: 0x1C1CF08 VA: 0x1C20F08 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1C20F48 Offset: 0x1C1CF48 VA: 0x1C20F48 Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1C20F90 Offset: 0x1C1CF90 VA: 0x1C20F90 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1C20F9C Offset: 0x1C1CF9C VA: 0x1C20F9C Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1C20FA8 Offset: 0x1C1CFA8 VA: 0x1C20FA8 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1C20FB4 Offset: 0x1C1CFB4 VA: 0x1C20FB4 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1C20FC0 Offset: 0x1C1CFC0 VA: 0x1C20FC0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1C20FCC Offset: 0x1C1CFCC VA: 0x1C20FCC Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1C20FD8 Offset: 0x1C1CFD8 VA: 0x1C20FD8 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1C20FE4 Offset: 0x1C1CFE4 VA: 0x1C20FE4 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1C20FF0 Offset: 0x1C1CFF0 VA: 0x1C20FF0 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1C20B14 Offset: 0x1C1CB14 VA: 0x1C20B14
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1C20CAC Offset: 0x1C1CCAC VA: 0x1C20CAC
	private void WriteIndent() { }
}

// Namespace: 
private enum XmlEventCache.XmlEventType // TypeDefIndex: 3117
{
	// Fields
	public int value__; // 0x0
	public const XmlEventCache.XmlEventType Unknown = 0;
	public const XmlEventCache.XmlEventType DocType = 1;
	public const XmlEventCache.XmlEventType StartElem = 2;
	public const XmlEventCache.XmlEventType StartAttr = 3;
	public const XmlEventCache.XmlEventType EndAttr = 4;
	public const XmlEventCache.XmlEventType CData = 5;
	public const XmlEventCache.XmlEventType Comment = 6;
	public const XmlEventCache.XmlEventType PI = 7;
	public const XmlEventCache.XmlEventType Whitespace = 8;
	public const XmlEventCache.XmlEventType String = 9;
	public const XmlEventCache.XmlEventType Raw = 10;
	public const XmlEventCache.XmlEventType EntRef = 11;
	public const XmlEventCache.XmlEventType CharEnt = 12;
	public const XmlEventCache.XmlEventType SurrCharEnt = 13;
	public const XmlEventCache.XmlEventType Base64 = 14;
	public const XmlEventCache.XmlEventType BinHex = 15;
	public const XmlEventCache.XmlEventType XmlDecl1 = 16;
	public const XmlEventCache.XmlEventType XmlDecl2 = 17;
	public const XmlEventCache.XmlEventType StartContent = 18;
	public const XmlEventCache.XmlEventType EndElem = 19;
	public const XmlEventCache.XmlEventType FullEndElem = 20;
	public const XmlEventCache.XmlEventType Nmsp = 21;
	public const XmlEventCache.XmlEventType EndBase64 = 22;
	public const XmlEventCache.XmlEventType Close = 23;
	public const XmlEventCache.XmlEventType Flush = 24;
	public const XmlEventCache.XmlEventType Dispose = 25;
}

// Namespace: 
private struct XmlEventCache.XmlEvent // TypeDefIndex: 3118
{
	// Fields
	private XmlEventCache.XmlEventType eventType; // 0x0
	private string s1; // 0x8
	private string s2; // 0x10
	private string s3; // 0x18
	private object o; // 0x20

	// Properties
	public XmlEventCache.XmlEventType EventType { get; }
	public string String1 { get; }
	public string String2 { get; }
	public string String3 { get; }
	public object Object { get; }

	// Methods

	// RVA: 0x1C21ABC Offset: 0x1C1DABC VA: 0x1C21ABC
	public void InitEvent(XmlEventCache.XmlEventType eventType) { }

	// RVA: 0x1C219B0 Offset: 0x1C1D9B0 VA: 0x1C219B0
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1) { }

	// RVA: 0x1C219C0 Offset: 0x1C1D9C0 VA: 0x1C219C0
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x1C219F8 Offset: 0x1C1D9F8 VA: 0x1C219F8
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x1C21A44 Offset: 0x1C1DA44 VA: 0x1C21A44
	public void InitEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x1C21AAC Offset: 0x1C1DAAC VA: 0x1C21AAC
	public void InitEvent(XmlEventCache.XmlEventType eventType, object o) { }

	// RVA: 0x1C21AC4 Offset: 0x1C1DAC4 VA: 0x1C21AC4
	public XmlEventCache.XmlEventType get_EventType() { }

	// RVA: 0x1C21ACC Offset: 0x1C1DACC VA: 0x1C21ACC
	public string get_String1() { }

	// RVA: 0x1C21AD4 Offset: 0x1C1DAD4 VA: 0x1C21AD4
	public string get_String2() { }

	// RVA: 0x1C21ADC Offset: 0x1C1DADC VA: 0x1C21ADC
	public string get_String3() { }

	// RVA: 0x1C21AE4 Offset: 0x1C1DAE4 VA: 0x1C21AE4
	public object get_Object() { }
}

// Namespace: System.Xml
internal sealed class XmlEventCache : XmlRawWriter // TypeDefIndex: 3119
{
	// Fields
	private List<XmlEventCache.XmlEvent[]> pages; // 0x28
	private XmlEventCache.XmlEvent[] pageCurr; // 0x30
	private int pageSize; // 0x38
	private bool hasRootNode; // 0x3C
	private StringConcat singleText; // 0x40
	private string baseUri; // 0x78

	// Methods

	// RVA: 0x1C1C6A0 Offset: 0x1C186A0 VA: 0x1C1C6A0
	public void .ctor(string baseUri, bool hasRootNode) { }

	// RVA: 0x1C1D1C4 Offset: 0x1C191C4 VA: 0x1C1D1C4
	public void EndEvents() { }

	// RVA: 0x1C1D1D8 Offset: 0x1C191D8 VA: 0x1C1D1D8
	public void EventsToWriter(XmlWriter writer) { }

	// RVA: 0x1C210F0 Offset: 0x1C1D0F0 VA: 0x1C210F0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1C21184 Offset: 0x1C1D184 VA: 0x1C21184 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C21204 Offset: 0x1C1D204 VA: 0x1C21204 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1C21218 Offset: 0x1C1D218 VA: 0x1C21218 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1C21220 Offset: 0x1C1D220 VA: 0x1C21220 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1C21280 Offset: 0x1C1D280 VA: 0x1C21280 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1C2128C Offset: 0x1C1D28C VA: 0x1C2128C Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1C21310 Offset: 0x1C1D310 VA: 0x1C21310 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1C2131C Offset: 0x1C1D31C VA: 0x1C2131C Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1C21340 Offset: 0x1C1D340 VA: 0x1C21340 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1C21370 Offset: 0x1C1D370 VA: 0x1C21370 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1C213A0 Offset: 0x1C1D3A0 VA: 0x1C213A0 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1C213AC Offset: 0x1C1D3AC VA: 0x1C213AC Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1C213B8 Offset: 0x1C1D3B8 VA: 0x1C213B8 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1C2144C Offset: 0x1C1D44C VA: 0x1C2144C Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1C214D8 Offset: 0x1C1D4D8 VA: 0x1C214D8 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1C215B8 Offset: 0x1C1D5B8 VA: 0x1C215B8 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1C215E4 Offset: 0x1C1D5E4 VA: 0x1C215E4 Slot: 28
	public override void Close() { }

	// RVA: 0x1C215EC Offset: 0x1C1D5EC VA: 0x1C215EC Slot: 29
	public override void Flush() { }

	// RVA: 0x1C215F4 Offset: 0x1C1D5F4 VA: 0x1C215F4 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x1C21604 Offset: 0x1C1D604 VA: 0x1C21604 Slot: 34
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1C216AC Offset: 0x1C1D6AC VA: 0x1C216AC Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1C21718 Offset: 0x1C1D718 VA: 0x1C21718 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1C21724 Offset: 0x1C1D724 VA: 0x1C21724 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1C2172C Offset: 0x1C1D72C VA: 0x1C2172C Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C21740 Offset: 0x1C1D740 VA: 0x1C21740 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C21754 Offset: 0x1C1D754 VA: 0x1C21754 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string ns) { }

	// RVA: 0x1C21764 Offset: 0x1C1D764 VA: 0x1C21764 Slot: 46
	internal override void WriteEndBase64() { }

	// RVA: 0x1C210A8 Offset: 0x1C1D0A8 VA: 0x1C210A8
	private void AddEvent(XmlEventCache.XmlEventType eventType) { }

	// RVA: 0x1C2122C Offset: 0x1C1D22C VA: 0x1C2122C
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1) { }

	// RVA: 0x1C2129C Offset: 0x1C1D29C VA: 0x1C2129C
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2) { }

	// RVA: 0x1C21198 Offset: 0x1C1D198 VA: 0x1C21198
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3) { }

	// RVA: 0x1C21108 Offset: 0x1C1D108 VA: 0x1C21108
	private void AddEvent(XmlEventCache.XmlEventType eventType, string s1, string s2, string s3, object o) { }

	// RVA: 0x1C213F8 Offset: 0x1C1D3F8 VA: 0x1C213F8
	private void AddEvent(XmlEventCache.XmlEventType eventType, object o) { }

	// RVA: 0x1C2176C Offset: 0x1C1D76C VA: 0x1C2176C
	private int NewEvent() { }

	// RVA: 0x1C21504 Offset: 0x1C1D504 VA: 0x1C21504
	private static byte[] ToBytes(byte[] buffer, int index, int count) { }
}

// Namespace: System.Xml
public class XmlParserContext // TypeDefIndex: 3120
{
	// Fields
	private XmlNameTable _nt; // 0x10
	private XmlNamespaceManager _nsMgr; // 0x18
	private string _docTypeName; // 0x20
	private string _pubId; // 0x28
	private string _sysId; // 0x30
	private string _internalSubset; // 0x38
	private string _xmlLang; // 0x40
	private XmlSpace _xmlSpace; // 0x48
	private string _baseURI; // 0x50
	private Encoding _encoding; // 0x58

	// Properties
	public XmlNameTable NameTable { get; }
	public XmlNamespaceManager NamespaceManager { get; }
	public string DocTypeName { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string BaseURI { get; }
	public string InternalSubset { get; }
	public string XmlLang { get; }
	public XmlSpace XmlSpace { get; }
	public Encoding Encoding { get; }
	internal bool HasDtdInfo { get; }

	// Methods

	// RVA: 0x1C21AEC Offset: 0x1C1DAEC VA: 0x1C21AEC
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x1C21B3C Offset: 0x1C1DB3C VA: 0x1C21B3C
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace) { }

	// RVA: 0x1C21B68 Offset: 0x1C1DB68 VA: 0x1C21B68
	public void .ctor(XmlNameTable nt, XmlNamespaceManager nsMgr, string docTypeName, string pubId, string sysId, string internalSubset, string baseURI, string xmlLang, XmlSpace xmlSpace, Encoding enc) { }

	// RVA: 0x1C21E20 Offset: 0x1C1DE20 VA: 0x1C21E20
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1C21E28 Offset: 0x1C1DE28 VA: 0x1C21E28
	public XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1C21E30 Offset: 0x1C1DE30 VA: 0x1C21E30
	public string get_DocTypeName() { }

	// RVA: 0x1C21E38 Offset: 0x1C1DE38 VA: 0x1C21E38
	public string get_PublicId() { }

	// RVA: 0x1C21E40 Offset: 0x1C1DE40 VA: 0x1C21E40
	public string get_SystemId() { }

	// RVA: 0x1C21E48 Offset: 0x1C1DE48 VA: 0x1C21E48
	public string get_BaseURI() { }

	// RVA: 0x1C21E50 Offset: 0x1C1DE50 VA: 0x1C21E50
	public string get_InternalSubset() { }

	// RVA: 0x1C21E58 Offset: 0x1C1DE58 VA: 0x1C21E58
	public string get_XmlLang() { }

	// RVA: 0x1C21E60 Offset: 0x1C1DE60 VA: 0x1C21E60
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x1C21E68 Offset: 0x1C1DE68 VA: 0x1C21E68
	public Encoding get_Encoding() { }

	// RVA: 0x1C21E70 Offset: 0x1C1DE70 VA: 0x1C21E70
	internal bool get_HasDtdInfo() { }
}

// Namespace: System.Xml
internal abstract class XmlRawWriter : XmlWriter // TypeDefIndex: 3121
{
	// Fields
	protected XmlRawWriterBase64Encoder base64Encoder; // 0x18
	protected IXmlNamespaceResolver resolver; // 0x20

	// Properties
	public override WriteState WriteState { get; }
	internal virtual IXmlNamespaceResolver NamespaceResolver { set; }
	internal virtual bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1C21EEC Offset: 0x1C1DEEC VA: 0x1C21EEC Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1C21F44 Offset: 0x1C1DF44 VA: 0x1C21F44 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1C21F9C Offset: 0x1C1DF9C VA: 0x1C21F9C Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1C21FF4 Offset: 0x1C1DFF4 VA: 0x1C21FF4 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1C21FF8 Offset: 0x1C1DFF8 VA: 0x1C21FF8 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1C22050 Offset: 0x1C1E050 VA: 0x1C22050 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1C20FFC Offset: 0x1C1CFFC VA: 0x1C20FFC Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1C220A8 Offset: 0x1C1E0A8 VA: 0x1C220A8 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1C22100 Offset: 0x1C1E100 VA: 0x1C22100 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1C22158 Offset: 0x1C1E158 VA: 0x1C22158 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1C22168 Offset: 0x1C1E168 VA: 0x1C22168 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1C221FC Offset: 0x1C1E1FC VA: 0x1C221FC Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1C222A0 Offset: 0x1C1E2A0 VA: 0x1C222A0 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1C222B0 Offset: 0x1C1E2B0 VA: 0x1C222B0 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1C222E0 Offset: 0x1C1E2E0 VA: 0x1C222E0 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1C22310 Offset: 0x1C1E310 VA: 0x1C22310 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1C22320 Offset: 0x1C1E320 VA: 0x1C22320 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x1C22330 Offset: 0x1C1E330 VA: 0x1C22330 Slot: 32
	public override void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x1C22388 Offset: 0x1C1E388 VA: 0x1C22388 Slot: 33
	public override void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x1C223E0 Offset: 0x1C1E3E0 VA: 0x1C223E0 Slot: 35
	internal virtual void set_NamespaceResolver(IXmlNamespaceResolver value) { }

	// RVA: 0x1C223E8 Offset: 0x1C1E3E8 VA: 0x1C223E8 Slot: 36
	internal virtual void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1C223EC Offset: 0x1C1E3EC VA: 0x1C223EC Slot: 37
	internal virtual void WriteXmlDeclaration(string xmldecl) { }

	// RVA: -1 Offset: -1 Slot: 38
	internal abstract void StartElementContent();

	// RVA: 0x1C223F0 Offset: 0x1C1E3F0 VA: 0x1C223F0 Slot: 39
	internal virtual void OnRootElement(ConformanceLevel conformanceLevel) { }

	// RVA: -1 Offset: -1 Slot: 40
	internal abstract void WriteEndElement(string prefix, string localName, string ns);

	// RVA: 0x1C223F4 Offset: 0x1C1E3F4 VA: 0x1C223F4 Slot: 41
	internal virtual void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 42
	internal abstract void WriteNamespaceDeclaration(string prefix, string ns);

	// RVA: 0x1C22404 Offset: 0x1C1E404 VA: 0x1C22404 Slot: 43
	internal virtual bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1C2240C Offset: 0x1C1E40C VA: 0x1C2240C Slot: 44
	internal virtual void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1C22444 Offset: 0x1C1E444 VA: 0x1C22444 Slot: 45
	internal virtual void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1C2247C Offset: 0x1C1E47C VA: 0x1C2247C Slot: 46
	internal virtual void WriteEndBase64() { }

	// RVA: 0x1C22494 Offset: 0x1C1E494 VA: 0x1C22494 Slot: 47
	internal virtual void Close(WriteState currentState) { }

	// RVA: 0x1C18AA8 Offset: 0x1C14AA8 VA: 0x1C18AA8
	protected void .ctor() { }
}

// Namespace: System.Xml
[DefaultMember("Item")]
[DebuggerDisplay("{debuggerDisplayProxy}")]
[DebuggerDisplay("{debuggerDisplayProxy}")]
public abstract class XmlReader : IDisposable // TypeDefIndex: 3122
{
	// Fields
	private static uint IsTextualNodeBitmap; // 0x0
	private static uint CanReadContentAsBitmap; // 0x4
	private static uint HasValueBitmap; // 0x8

	// Properties
	public virtual XmlReaderSettings Settings { get; }
	public abstract XmlNodeType NodeType { get; }
	public virtual string Name { get; }
	public abstract string LocalName { get; }
	public abstract string NamespaceURI { get; }
	public abstract string Prefix { get; }
	public abstract string Value { get; }
	public abstract int Depth { get; }
	public abstract string BaseURI { get; }
	public abstract bool IsEmptyElement { get; }
	public virtual bool IsDefault { get; }
	public virtual char QuoteChar { get; }
	public virtual XmlSpace XmlSpace { get; }
	public virtual string XmlLang { get; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public virtual Type ValueType { get; }
	public abstract int AttributeCount { get; }
	public abstract bool EOF { get; }
	public abstract ReadState ReadState { get; }
	public abstract XmlNameTable NameTable { get; }
	public virtual bool CanResolveEntity { get; }
	public virtual bool CanReadValueChunk { get; }
	public virtual bool HasAttributes { get; }
	internal virtual XmlNamespaceManager NamespaceManager { get; }
	internal bool IsDefaultInternal { get; }
	internal virtual IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x1C224A4 Offset: 0x1C1E4A4 VA: 0x1C224A4 Slot: 5
	public virtual XmlReaderSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x1C224AC Offset: 0x1C1E4AC VA: 0x1C224AC Slot: 7
	public virtual string get_Name() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_LocalName();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_NamespaceURI();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_Prefix();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract string get_Value();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract int get_Depth();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract string get_BaseURI();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_IsEmptyElement();

	// RVA: 0x1C22590 Offset: 0x1C1E590 VA: 0x1C22590 Slot: 15
	public virtual bool get_IsDefault() { }

	// RVA: 0x1C22598 Offset: 0x1C1E598 VA: 0x1C22598 Slot: 16
	public virtual char get_QuoteChar() { }

	// RVA: 0x1C225A0 Offset: 0x1C1E5A0 VA: 0x1C225A0 Slot: 17
	public virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x1C225A8 Offset: 0x1C1E5A8 VA: 0x1C225A8 Slot: 18
	public virtual string get_XmlLang() { }

	// RVA: 0x1C225C0 Offset: 0x1C1E5C0 VA: 0x1C225C0 Slot: 19
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1C22608 Offset: 0x1C1E608 VA: 0x1C22608 Slot: 20
	public virtual Type get_ValueType() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract int get_AttributeCount();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract string GetAttribute(string name);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract string GetAttribute(string name, string namespaceURI);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract string GetAttribute(int i);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract bool MoveToAttribute(string name);

	// RVA: 0x1C22638 Offset: 0x1C1E638 VA: 0x1C22638 Slot: 26
	public virtual void MoveToAttribute(int i) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract bool MoveToFirstAttribute();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract bool MoveToNextAttribute();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract bool MoveToElement();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool ReadAttributeValue();

	// RVA: -1 Offset: -1 Slot: 31
	public abstract bool Read();

	// RVA: -1 Offset: -1 Slot: 32
	public abstract bool get_EOF();

	// RVA: 0x1C22700 Offset: 0x1C1E700 VA: 0x1C22700 Slot: 33
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 34
	public abstract ReadState get_ReadState();

	// RVA: 0x1C22704 Offset: 0x1C1E704 VA: 0x1C22704 Slot: 35
	public virtual void Skip() { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract XmlNameTable get_NameTable();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract string LookupNamespace(string prefix);

	// RVA: 0x1C2280C Offset: 0x1C1E80C VA: 0x1C2280C Slot: 38
	public virtual bool get_CanResolveEntity() { }

	// RVA: -1 Offset: -1 Slot: 39
	public abstract void ResolveEntity();

	// RVA: 0x1C22814 Offset: 0x1C1E814 VA: 0x1C22814 Slot: 40
	public virtual bool get_CanReadValueChunk() { }

	// RVA: 0x1C2281C Offset: 0x1C1E81C VA: 0x1C2281C Slot: 41
	public virtual int ReadValueChunk(char[] buffer, int index, int count) { }

	[EditorBrowsable(1)]
	// RVA: 0x1C22874 Offset: 0x1C1E874 VA: 0x1C22874 Slot: 42
	public virtual string ReadString() { }

	// RVA: 0x1C22AA0 Offset: 0x1C1EAA0 VA: 0x1C22AA0 Slot: 43
	public virtual XmlNodeType MoveToContent() { }

	// RVA: 0x1C22B20 Offset: 0x1C1EB20 VA: 0x1C22B20 Slot: 44
	public virtual void ReadStartElement() { }

	[EditorBrowsable(1)]
	// RVA: 0x1C22C14 Offset: 0x1C1EC14 VA: 0x1C22C14 Slot: 45
	public virtual string ReadElementString() { }

	// RVA: 0x1C22E64 Offset: 0x1C1EE64 VA: 0x1C22E64 Slot: 46
	public virtual void ReadEndElement() { }

	// RVA: 0x1C22F58 Offset: 0x1C1EF58 VA: 0x1C22F58 Slot: 47
	public virtual bool IsStartElement(string localname, string ns) { }

	// RVA: 0x1C22FDC Offset: 0x1C1EFDC VA: 0x1C22FDC Slot: 48
	public virtual string ReadInnerXml() { }

	// RVA: 0x1C233C0 Offset: 0x1C1F3C0 VA: 0x1C233C0
	private void WriteNode(XmlWriter xtw, bool defattr) { }

	// RVA: 0x1C232E8 Offset: 0x1C1F2E8 VA: 0x1C232E8
	private void WriteAttributeValue(XmlWriter xtw) { }

	// RVA: 0x1C23274 Offset: 0x1C1F274 VA: 0x1C23274
	private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw) { }

	// RVA: 0x1C23848 Offset: 0x1C1F848 VA: 0x1C23848
	private void SetNamespacesFlag(XmlTextWriter xtw) { }

	// RVA: 0x1C23954 Offset: 0x1C1F954 VA: 0x1C23954 Slot: 49
	public virtual bool get_HasAttributes() { }

	// RVA: 0x1C1B2D4 Offset: 0x1C172D4 VA: 0x1C1B2D4 Slot: 4
	public void Dispose() { }

	// RVA: 0x1C23978 Offset: 0x1C1F978 VA: 0x1C23978 Slot: 50
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1C239BC Offset: 0x1C1F9BC VA: 0x1C239BC Slot: 51
	internal virtual XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1C22A3C Offset: 0x1C1EA3C VA: 0x1C22A3C
	internal static bool IsTextualNode(XmlNodeType nodeType) { }

	// RVA: 0x1C239C4 Offset: 0x1C1F9C4 VA: 0x1C239C4
	internal static bool HasValueInternal(XmlNodeType nodeType) { }

	// RVA: 0x1C22738 Offset: 0x1C1E738 VA: 0x1C22738
	private bool SkipSubtree() { }

	// RVA: 0x1C23A28 Offset: 0x1C1FA28 VA: 0x1C23A28
	internal bool get_IsDefaultInternal() { }

	// RVA: 0x1C23B08 Offset: 0x1C1FB08 VA: 0x1C23B08 Slot: 52
	internal virtual IDtdInfo get_DtdInfo() { }

	// RVA: 0x1C23B10 Offset: 0x1C1FB10 VA: 0x1C23B10
	public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x1C23D3C Offset: 0x1C1FD3C VA: 0x1C23D3C
	public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri) { }

	// RVA: 0x1C23EDC Offset: 0x1C1FEDC VA: 0x1C23EDC
	internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext) { }

	// RVA: 0x1C241EC Offset: 0x1C201EC VA: 0x1C241EC
	internal static int CalcBufferSize(Stream input) { }

	// RVA: 0x1C1A878 Offset: 0x1C16878 VA: 0x1C1A878
	protected void .ctor() { }

	// RVA: 0x1C2436C Offset: 0x1C2036C VA: 0x1C2436C
	private static void .cctor() { }
}

// Namespace: System.Xml
public sealed class XmlReaderSettings // TypeDefIndex: 3123
{
	// Fields
	private bool useAsync; // 0x10
	private XmlNameTable nameTable; // 0x18
	private XmlResolver xmlResolver; // 0x20
	private int lineNumberOffset; // 0x28
	private int linePositionOffset; // 0x2C
	private ConformanceLevel conformanceLevel; // 0x30
	private bool checkCharacters; // 0x34
	private long maxCharactersInDocument; // 0x38
	private long maxCharactersFromEntities; // 0x40
	private bool ignoreWhitespace; // 0x48
	private bool ignorePIs; // 0x49
	private bool ignoreComments; // 0x4A
	private DtdProcessing dtdProcessing; // 0x4C
	private ValidationType validationType; // 0x50
	private XmlSchemaValidationFlags validationFlags; // 0x54
	private XmlSchemaSet schemas; // 0x58
	private ValidationEventHandler valEventHandler; // 0x60
	private bool closeInput; // 0x68
	private bool isReadOnly; // 0x69
	[CompilerGenerated]
	private bool <IsXmlResolverSet>k__BackingField; // 0x6A
	private static Nullable<bool> s_enableLegacyXmlSettings; // 0x0

	// Properties
	public bool Async { get; set; }
	public XmlNameTable NameTable { get; set; }
	internal bool IsXmlResolverSet { get; set; }
	public XmlResolver XmlResolver { set; }
	public int LineNumberOffset { get; set; }
	public int LinePositionOffset { get; set; }
	public ConformanceLevel ConformanceLevel { get; set; }
	public bool CheckCharacters { get; set; }
	public long MaxCharactersInDocument { get; set; }
	public long MaxCharactersFromEntities { get; set; }
	public bool IgnoreWhitespace { get; set; }
	public bool IgnoreProcessingInstructions { get; set; }
	public bool IgnoreComments { get; set; }
	public DtdProcessing DtdProcessing { get; set; }
	public bool CloseInput { get; set; }
	public ValidationType ValidationType { get; set; }
	public XmlSchemaValidationFlags ValidationFlags { get; set; }
	public XmlSchemaSet Schemas { get; set; }
	internal bool ReadOnly { set; }

	// Methods

	// RVA: 0x1C1AA08 Offset: 0x1C16A08 VA: 0x1C1AA08
	public void .ctor() { }

	// RVA: 0x1C243D0 Offset: 0x1C203D0 VA: 0x1C243D0
	public bool get_Async() { }

	// RVA: 0x1C1AA28 Offset: 0x1C16A28 VA: 0x1C1AA28
	public void set_Async(bool value) { }

	// RVA: 0x1C24484 Offset: 0x1C20484 VA: 0x1C24484
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1C2448C Offset: 0x1C2048C VA: 0x1C2448C
	public void set_NameTable(XmlNameTable value) { }

	[CompilerGenerated]
	// RVA: 0x1C244F0 Offset: 0x1C204F0 VA: 0x1C244F0
	internal bool get_IsXmlResolverSet() { }

	[CompilerGenerated]
	// RVA: 0x1C244F8 Offset: 0x1C204F8 VA: 0x1C244F8
	internal void set_IsXmlResolverSet(bool value) { }

	// RVA: 0x1C24500 Offset: 0x1C20500 VA: 0x1C24500
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1C24570 Offset: 0x1C20570 VA: 0x1C24570
	internal XmlResolver GetXmlResolver() { }

	// RVA: 0x1C24578 Offset: 0x1C20578 VA: 0x1C24578
	internal XmlResolver GetXmlResolver_CheckConfig() { }

	// RVA: 0x1C245A8 Offset: 0x1C205A8 VA: 0x1C245A8
	public int get_LineNumberOffset() { }

	// RVA: 0x1C245B0 Offset: 0x1C205B0 VA: 0x1C245B0
	public void set_LineNumberOffset(int value) { }

	// RVA: 0x1C2460C Offset: 0x1C2060C VA: 0x1C2460C
	public int get_LinePositionOffset() { }

	// RVA: 0x1C24614 Offset: 0x1C20614 VA: 0x1C24614
	public void set_LinePositionOffset(int value) { }

	// RVA: 0x1C24670 Offset: 0x1C20670 VA: 0x1C24670
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x1C24678 Offset: 0x1C20678 VA: 0x1C24678
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x1C24724 Offset: 0x1C20724 VA: 0x1C24724
	public bool get_CheckCharacters() { }

	// RVA: 0x1C2472C Offset: 0x1C2072C VA: 0x1C2472C
	public void set_CheckCharacters(bool value) { }

	// RVA: 0x1C2478C Offset: 0x1C2078C VA: 0x1C2478C
	public long get_MaxCharactersInDocument() { }

	// RVA: 0x1C24794 Offset: 0x1C20794 VA: 0x1C24794
	public void set_MaxCharactersInDocument(long value) { }

	// RVA: 0x1C2483C Offset: 0x1C2083C VA: 0x1C2483C
	public long get_MaxCharactersFromEntities() { }

	// RVA: 0x1C24844 Offset: 0x1C20844 VA: 0x1C24844
	public void set_MaxCharactersFromEntities(long value) { }

	// RVA: 0x1C248EC Offset: 0x1C208EC VA: 0x1C248EC
	public bool get_IgnoreWhitespace() { }

	// RVA: 0x1C248F4 Offset: 0x1C208F4 VA: 0x1C248F4
	public void set_IgnoreWhitespace(bool value) { }

	// RVA: 0x1C24954 Offset: 0x1C20954 VA: 0x1C24954
	public bool get_IgnoreProcessingInstructions() { }

	// RVA: 0x1C2495C Offset: 0x1C2095C VA: 0x1C2495C
	public void set_IgnoreProcessingInstructions(bool value) { }

	// RVA: 0x1C249BC Offset: 0x1C209BC VA: 0x1C249BC
	public bool get_IgnoreComments() { }

	// RVA: 0x1C249C4 Offset: 0x1C209C4 VA: 0x1C249C4
	public void set_IgnoreComments(bool value) { }

	// RVA: 0x1C24A24 Offset: 0x1C20A24 VA: 0x1C24A24
	public DtdProcessing get_DtdProcessing() { }

	// RVA: 0x1C24A2C Offset: 0x1C20A2C VA: 0x1C24A2C
	public void set_DtdProcessing(DtdProcessing value) { }

	// RVA: 0x1C24AD8 Offset: 0x1C20AD8 VA: 0x1C24AD8
	public bool get_CloseInput() { }

	// RVA: 0x1C24AE0 Offset: 0x1C20AE0 VA: 0x1C24AE0
	public void set_CloseInput(bool value) { }

	// RVA: 0x1C24B40 Offset: 0x1C20B40 VA: 0x1C24B40
	public ValidationType get_ValidationType() { }

	// RVA: 0x1C24B48 Offset: 0x1C20B48 VA: 0x1C24B48
	public void set_ValidationType(ValidationType value) { }

	// RVA: 0x1C24BF4 Offset: 0x1C20BF4 VA: 0x1C24BF4
	public XmlSchemaValidationFlags get_ValidationFlags() { }

	// RVA: 0x1C24BFC Offset: 0x1C20BFC VA: 0x1C24BFC
	public void set_ValidationFlags(XmlSchemaValidationFlags value) { }

	// RVA: 0x1C24CA8 Offset: 0x1C20CA8 VA: 0x1C24CA8
	public XmlSchemaSet get_Schemas() { }

	// RVA: 0x1C24D18 Offset: 0x1C20D18 VA: 0x1C24D18
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x1C1A9A0 Offset: 0x1C169A0 VA: 0x1C1A9A0
	public XmlReaderSettings Clone() { }

	// RVA: 0x1C24D7C Offset: 0x1C20D7C VA: 0x1C24D7C
	internal ValidationEventHandler GetEventHandler() { }

	// RVA: 0x1C23BA0 Offset: 0x1C1FBA0 VA: 0x1C23BA0
	internal XmlReader CreateReader(Stream input, Uri baseUri, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x1C23DC8 Offset: 0x1C1FDC8 VA: 0x1C23DC8
	internal XmlReader CreateReader(TextReader input, string baseUriString, XmlParserContext inputContext) { }

	// RVA: 0x1C24D84 Offset: 0x1C20D84 VA: 0x1C24D84
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x1C243D8 Offset: 0x1C203D8 VA: 0x1C243D8
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x1C243C8 Offset: 0x1C203C8 VA: 0x1C243C8
	private void Initialize() { }

	// RVA: 0x1C24D8C Offset: 0x1C20D8C VA: 0x1C24D8C
	private void Initialize(XmlResolver resolver) { }

	// RVA: 0x1C24F38 Offset: 0x1C20F38 VA: 0x1C24F38
	private static XmlResolver CreateDefaultResolver() { }

	// RVA: 0x1C24270 Offset: 0x1C20270 VA: 0x1C24270
	internal XmlReader AddValidation(XmlReader reader) { }

	// RVA: 0x1C24F8C Offset: 0x1C20F8C VA: 0x1C24F8C
	private XmlValidatingReaderImpl CreateDtdValidatingReader(XmlReader baseReader) { }

	// RVA: 0x1C24E44 Offset: 0x1C20E44 VA: 0x1C24E44
	internal static bool EnableLegacyXmlSettings() { }
}

// Namespace: System.Xml
public enum XmlSpace // TypeDefIndex: 3124
{
	// Fields
	public int value__; // 0x0
	public const XmlSpace None = 0;
	public const XmlSpace Default = 1;
	public const XmlSpace Preserve = 2;
}

// Namespace: System.Xml
internal class XmlTextEncoder // TypeDefIndex: 3125
{
	// Fields
	private TextWriter textWriter; // 0x10
	private bool inAttribute; // 0x18
	private char quoteChar; // 0x1A
	private StringBuilder attrValue; // 0x20
	private bool cacheAttrValue; // 0x28
	private XmlCharType xmlCharType; // 0x30

	// Properties
	internal char QuoteChar { set; }
	internal string AttributeValue { get; }

	// Methods

	// RVA: 0x1C25004 Offset: 0x1C21004 VA: 0x1C25004
	internal void .ctor(TextWriter textWriter) { }

	// RVA: 0x1C25054 Offset: 0x1C21054 VA: 0x1C25054
	internal void set_QuoteChar(char value) { }

	// RVA: 0x1C2505C Offset: 0x1C2105C VA: 0x1C2505C
	internal void StartAttribute(bool cacheAttrValue) { }

	// RVA: 0x1C2510C Offset: 0x1C2110C VA: 0x1C2510C
	internal void EndAttribute() { }

	// RVA: 0x1C25144 Offset: 0x1C21144 VA: 0x1C25144
	internal string get_AttributeValue() { }

	// RVA: 0x1C25180 Offset: 0x1C21180 VA: 0x1C25180
	internal void WriteSurrogateChar(char lowChar, char highChar) { }

	// RVA: 0x1C25234 Offset: 0x1C21234 VA: 0x1C25234
	internal void Write(char[] array, int offset, int count) { }

	// RVA: 0x1C25744 Offset: 0x1C21744 VA: 0x1C25744
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1C258C4 Offset: 0x1C218C4 VA: 0x1C258C4
	internal void Write(string text) { }

	// RVA: 0x1C25DA4 Offset: 0x1C21DA4 VA: 0x1C25DA4
	internal void WriteRawWithSurrogateChecking(string text) { }

	// RVA: 0x1C25F90 Offset: 0x1C21F90 VA: 0x1C25F90
	internal void WriteRaw(char[] array, int offset, int count) { }

	// RVA: 0x1C260BC Offset: 0x1C220BC VA: 0x1C260BC
	internal void WriteCharEntity(char ch) { }

	// RVA: 0x1C26294 Offset: 0x1C22294 VA: 0x1C26294
	internal void WriteEntityRef(string name) { }

	// RVA: 0x1C25CFC Offset: 0x1C21CFC VA: 0x1C25CFC
	private void WriteStringFragment(string str, int offset, int count, char[] helperBuffer) { }

	// RVA: 0x1C25658 Offset: 0x1C21658 VA: 0x1C25658
	private void WriteCharEntityImpl(char ch) { }

	// RVA: 0x1C261FC Offset: 0x1C221FC VA: 0x1C261FC
	private void WriteCharEntityImpl(string strVal) { }

	// RVA: 0x1C256D4 Offset: 0x1C216D4 VA: 0x1C256D4
	private void WriteEntityRefImpl(string name) { }
}

// Namespace: System.Xml
[EditorBrowsable(1)]
public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 3126
{
	// Fields
	private XmlTextReaderImpl impl; // 0x10

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	public bool Namespaces { get; }
	public bool Normalization { get; set; }
	public WhitespaceHandling WhitespaceHandling { set; }
	public EntityHandling EntityHandling { set; }
	public XmlResolver XmlResolver { set; }
	internal XmlTextReaderImpl Impl { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x1C26300 Offset: 0x1C22300 VA: 0x1C26300
	public void .ctor(Stream input) { }

	// RVA: 0x1C263C0 Offset: 0x1C223C0 VA: 0x1C263C0
	public void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x1C26498 Offset: 0x1C22498 VA: 0x1C26498
	public void .ctor(TextReader input) { }

	// RVA: 0x1C26558 Offset: 0x1C22558 VA: 0x1C26558
	public void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x1C26620 Offset: 0x1C22620 VA: 0x1C26620 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C2663C Offset: 0x1C2263C VA: 0x1C2663C Slot: 7
	public override string get_Name() { }

	// RVA: 0x1C26658 Offset: 0x1C22658 VA: 0x1C26658 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1C26674 Offset: 0x1C22674 VA: 0x1C26674 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1C26690 Offset: 0x1C22690 VA: 0x1C26690 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1C266AC Offset: 0x1C226AC VA: 0x1C266AC Slot: 11
	public override string get_Value() { }

	// RVA: 0x1C266C8 Offset: 0x1C226C8 VA: 0x1C266C8 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x1C266E4 Offset: 0x1C226E4 VA: 0x1C266E4 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x1C26704 Offset: 0x1C22704 VA: 0x1C26704 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1C26724 Offset: 0x1C22724 VA: 0x1C26724 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1C26744 Offset: 0x1C22744 VA: 0x1C26744 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x1C26764 Offset: 0x1C22764 VA: 0x1C26764 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1C26784 Offset: 0x1C22784 VA: 0x1C26784 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x1C267A4 Offset: 0x1C227A4 VA: 0x1C267A4 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x1C267C4 Offset: 0x1C227C4 VA: 0x1C267C4 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x1C267E4 Offset: 0x1C227E4 VA: 0x1C267E4 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1C26804 Offset: 0x1C22804 VA: 0x1C26804 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x1C26824 Offset: 0x1C22824 VA: 0x1C26824 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1C26844 Offset: 0x1C22844 VA: 0x1C26844 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1C26864 Offset: 0x1C22864 VA: 0x1C26864 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1C26884 Offset: 0x1C22884 VA: 0x1C26884 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1C268A4 Offset: 0x1C228A4 VA: 0x1C268A4 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x1C268C4 Offset: 0x1C228C4 VA: 0x1C268C4 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x1C268E4 Offset: 0x1C228E4 VA: 0x1C268E4 Slot: 31
	public override bool Read() { }

	// RVA: 0x1C26904 Offset: 0x1C22904 VA: 0x1C26904 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x1C26924 Offset: 0x1C22924 VA: 0x1C26924 Slot: 33
	public override void Close() { }

	// RVA: 0x1C26944 Offset: 0x1C22944 VA: 0x1C26944 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x1C26964 Offset: 0x1C22964 VA: 0x1C26964 Slot: 35
	public override void Skip() { }

	// RVA: 0x1C26984 Offset: 0x1C22984 VA: 0x1C26984 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1C269A4 Offset: 0x1C229A4 VA: 0x1C269A4 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1C269DC Offset: 0x1C229DC VA: 0x1C269DC Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1C269E4 Offset: 0x1C229E4 VA: 0x1C269E4 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1C26A04 Offset: 0x1C22A04 VA: 0x1C26A04 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1C26A0C Offset: 0x1C22A0C VA: 0x1C26A0C Slot: 42
	public override string ReadString() { }

	// RVA: 0x1C26A34 Offset: 0x1C22A34 VA: 0x1C26A34 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0x1C26A3C Offset: 0x1C22A3C VA: 0x1C26A3C Slot: 54
	public int get_LineNumber() { }

	// RVA: 0x1C26A54 Offset: 0x1C22A54 VA: 0x1C26A54 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0x1C26A6C Offset: 0x1C22A6C VA: 0x1C26A6C Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1C26A84 Offset: 0x1C22A84 VA: 0x1C26A84 Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1C26AA4 Offset: 0x1C22AA4 VA: 0x1C26AA4 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1C2393C Offset: 0x1C1F93C VA: 0x1C2393C
	public bool get_Namespaces() { }

	// RVA: 0x1C26ABC Offset: 0x1C22ABC VA: 0x1C26ABC
	public bool get_Normalization() { }

	// RVA: 0x1C26AD4 Offset: 0x1C22AD4 VA: 0x1C26AD4
	public void set_Normalization(bool value) { }

	// RVA: 0x1C26AF0 Offset: 0x1C22AF0 VA: 0x1C26AF0
	public void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x1C26B08 Offset: 0x1C22B08 VA: 0x1C26B08
	public void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x1C26B20 Offset: 0x1C22B20 VA: 0x1C26B20
	public void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1C26B38 Offset: 0x1C22B38 VA: 0x1C26B38
	internal XmlTextReaderImpl get_Impl() { }

	// RVA: 0x1C26B40 Offset: 0x1C22B40 VA: 0x1C26B40 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1C26B60 Offset: 0x1C22B60 VA: 0x1C26B60
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x1C26B7C Offset: 0x1C22B7C VA: 0x1C26B7C Slot: 52
	internal override IDtdInfo get_DtdInfo() { }
}

// Namespace: 
private enum XmlTextReaderImpl.ParsingFunction // TypeDefIndex: 3127
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.ParsingFunction ElementContent = 0;
	public const XmlTextReaderImpl.ParsingFunction NoData = 1;
	public const XmlTextReaderImpl.ParsingFunction OpenUrl = 2;
	public const XmlTextReaderImpl.ParsingFunction SwitchToInteractive = 3;
	public const XmlTextReaderImpl.ParsingFunction SwitchToInteractiveXmlDecl = 4;
	public const XmlTextReaderImpl.ParsingFunction DocumentContent = 5;
	public const XmlTextReaderImpl.ParsingFunction MoveToElementContent = 6;
	public const XmlTextReaderImpl.ParsingFunction PopElementContext = 7;
	public const XmlTextReaderImpl.ParsingFunction PopEmptyElementContext = 8;
	public const XmlTextReaderImpl.ParsingFunction ResetAttributesRootLevel = 9;
	public const XmlTextReaderImpl.ParsingFunction Error = 10;
	public const XmlTextReaderImpl.ParsingFunction Eof = 11;
	public const XmlTextReaderImpl.ParsingFunction ReaderClosed = 12;
	public const XmlTextReaderImpl.ParsingFunction EntityReference = 13;
	public const XmlTextReaderImpl.ParsingFunction InIncrementalRead = 14;
	public const XmlTextReaderImpl.ParsingFunction FragmentAttribute = 15;
	public const XmlTextReaderImpl.ParsingFunction ReportEndEntity = 16;
	public const XmlTextReaderImpl.ParsingFunction AfterResolveEntityInContent = 17;
	public const XmlTextReaderImpl.ParsingFunction AfterResolveEmptyEntityInContent = 18;
	public const XmlTextReaderImpl.ParsingFunction XmlDeclarationFragment = 19;
	public const XmlTextReaderImpl.ParsingFunction GoToEof = 20;
	public const XmlTextReaderImpl.ParsingFunction PartialTextValue = 21;
	public const XmlTextReaderImpl.ParsingFunction InReadAttributeValue = 22;
	public const XmlTextReaderImpl.ParsingFunction InReadValueChunk = 23;
	public const XmlTextReaderImpl.ParsingFunction InReadContentAsBinary = 24;
	public const XmlTextReaderImpl.ParsingFunction InReadElementContentAsBinary = 25;
}

// Namespace: 
private enum XmlTextReaderImpl.ParsingMode // TypeDefIndex: 3128
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.ParsingMode Full = 0;
	public const XmlTextReaderImpl.ParsingMode SkipNode = 1;
	public const XmlTextReaderImpl.ParsingMode SkipContent = 2;
}

// Namespace: 
private enum XmlTextReaderImpl.EntityType // TypeDefIndex: 3129
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.EntityType CharacterDec = 0;
	public const XmlTextReaderImpl.EntityType CharacterHex = 1;
	public const XmlTextReaderImpl.EntityType CharacterNamed = 2;
	public const XmlTextReaderImpl.EntityType Expanded = 3;
	public const XmlTextReaderImpl.EntityType Skipped = 4;
	public const XmlTextReaderImpl.EntityType FakeExpanded = 5;
	public const XmlTextReaderImpl.EntityType Unexpanded = 6;
	public const XmlTextReaderImpl.EntityType ExpandedInAttribute = 7;
}

// Namespace: 
private enum XmlTextReaderImpl.EntityExpandType // TypeDefIndex: 3130
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.EntityExpandType All = 0;
	public const XmlTextReaderImpl.EntityExpandType OnlyGeneral = 1;
	public const XmlTextReaderImpl.EntityExpandType OnlyCharacter = 2;
}

// Namespace: 
private enum XmlTextReaderImpl.IncrementalReadState // TypeDefIndex: 3131
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.IncrementalReadState Text = 0;
	public const XmlTextReaderImpl.IncrementalReadState StartTag = 1;
	public const XmlTextReaderImpl.IncrementalReadState PI = 2;
	public const XmlTextReaderImpl.IncrementalReadState CDATA = 3;
	public const XmlTextReaderImpl.IncrementalReadState Comment = 4;
	public const XmlTextReaderImpl.IncrementalReadState Attributes = 5;
	public const XmlTextReaderImpl.IncrementalReadState AttributeValue = 6;
	public const XmlTextReaderImpl.IncrementalReadState ReadData = 7;
	public const XmlTextReaderImpl.IncrementalReadState EndElement = 8;
	public const XmlTextReaderImpl.IncrementalReadState End = 9;
	public const XmlTextReaderImpl.IncrementalReadState ReadValueChunk_OnCachedValue = 10;
	public const XmlTextReaderImpl.IncrementalReadState ReadValueChunk_OnPartialValue = 11;
	public const XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_OnCachedValue = 12;
	public const XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_OnPartialValue = 13;
	public const XmlTextReaderImpl.IncrementalReadState ReadContentAsBinary_End = 14;
}

// Namespace: 
private class XmlTextReaderImpl.LaterInitParam // TypeDefIndex: 3132
{
	// Fields
	public bool useAsync; // 0x10
	public Stream inputStream; // 0x18
	public byte[] inputBytes; // 0x20
	public int inputByteCount; // 0x28
	public Uri inputbaseUri; // 0x30
	public string inputUriStr; // 0x38
	public XmlResolver inputUriResolver; // 0x40
	public XmlParserContext inputContext; // 0x48
	public TextReader inputTextReader; // 0x50
	public XmlTextReaderImpl.InitInputType initType; // 0x58

	// Methods

	// RVA: 0x1C26B9C Offset: 0x1C22B9C VA: 0x1C26B9C
	public void .ctor() { }
}

// Namespace: 
private enum XmlTextReaderImpl.InitInputType // TypeDefIndex: 3133
{
	// Fields
	public int value__; // 0x0
	public const XmlTextReaderImpl.InitInputType UriString = 0;
	public const XmlTextReaderImpl.InitInputType Stream = 1;
	public const XmlTextReaderImpl.InitInputType TextReader = 2;
	public const XmlTextReaderImpl.InitInputType Invalid = 3;
}

// Namespace: 
private struct XmlTextReaderImpl.ParsingState // TypeDefIndex: 3134
{
	// Fields
	internal char[] chars; // 0x0
	internal int charPos; // 0x8
	internal int charsUsed; // 0xC
	internal Encoding encoding; // 0x10
	internal bool appendMode; // 0x18
	internal Stream stream; // 0x20
	internal Decoder decoder; // 0x28
	internal byte[] bytes; // 0x30
	internal int bytePos; // 0x38
	internal int bytesUsed; // 0x3C
	internal TextReader textReader; // 0x40
	internal int lineNo; // 0x48
	internal int lineStartPos; // 0x4C
	internal string baseUriStr; // 0x50
	internal Uri baseUri; // 0x58
	internal bool isEof; // 0x60
	internal bool isStreamEof; // 0x61
	internal IDtdEntityInfo entity; // 0x68
	internal int entityId; // 0x70
	internal bool eolNormalized; // 0x74
	internal bool entityResolvedManually; // 0x75

	// Properties
	internal int LineNo { get; }
	internal int LinePos { get; }

	// Methods

	// RVA: 0x1C26BAC Offset: 0x1C22BAC VA: 0x1C26BAC
	internal void Clear() { }

	// RVA: 0x1C26C68 Offset: 0x1C22C68 VA: 0x1C26C68
	internal void Close(bool closeInput) { }

	// RVA: 0x1C26CA0 Offset: 0x1C22CA0 VA: 0x1C26CA0
	internal int get_LineNo() { }

	// RVA: 0x1C26CA8 Offset: 0x1C22CA8 VA: 0x1C26CA8
	internal int get_LinePos() { }
}

// Namespace: 
private class XmlTextReaderImpl.XmlContext // TypeDefIndex: 3135
{
	// Fields
	internal XmlSpace xmlSpace; // 0x10
	internal string xmlLang; // 0x18
	internal string defaultNamespace; // 0x20
	internal XmlTextReaderImpl.XmlContext previousContext; // 0x28

	// Methods

	// RVA: 0x1C26CB8 Offset: 0x1C22CB8 VA: 0x1C26CB8
	internal void .ctor() { }

	// RVA: 0x1C26D20 Offset: 0x1C22D20 VA: 0x1C26D20
	internal void .ctor(XmlTextReaderImpl.XmlContext previousContext) { }
}

// Namespace: 
private class XmlTextReaderImpl.NoNamespaceManager : XmlNamespaceManager // TypeDefIndex: 3136
{
	// Properties
	public override string DefaultNamespace { get; }

	// Methods

	// RVA: 0x1C26D80 Offset: 0x1C22D80 VA: 0x1C26D80
	public void .ctor() { }

	// RVA: 0x1C26D88 Offset: 0x1C22D88 VA: 0x1C26D88 Slot: 9
	public override string get_DefaultNamespace() { }

	// RVA: 0x1C26DA0 Offset: 0x1C22DA0 VA: 0x1C26DA0 Slot: 10
	public override void PushScope() { }

	// RVA: 0x1C26DA4 Offset: 0x1C22DA4 VA: 0x1C26DA4 Slot: 11
	public override bool PopScope() { }

	// RVA: 0x1C26DAC Offset: 0x1C22DAC VA: 0x1C26DAC Slot: 12
	public override void AddNamespace(string prefix, string uri) { }

	// RVA: 0x1C26DB0 Offset: 0x1C22DB0 VA: 0x1C26DB0 Slot: 13
	public override void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x1C26DB4 Offset: 0x1C22DB4 VA: 0x1C26DB4 Slot: 14
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x1C26DBC Offset: 0x1C22DBC VA: 0x1C26DBC Slot: 15
	public override IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1C26DC4 Offset: 0x1C22DC4 VA: 0x1C26DC4 Slot: 16
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1C26DDC Offset: 0x1C22DDC VA: 0x1C26DDC Slot: 17
	public override string LookupPrefix(string uri) { }
}

// Namespace: 
internal class XmlTextReaderImpl.DtdParserProxy : IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter // TypeDefIndex: 3137
{
	// Fields
	private XmlTextReaderImpl reader; // 0x10

	// Properties
	private XmlNameTable System.Xml.IDtdParserAdapter.NameTable { get; }
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.NamespaceResolver { get; }
	private Uri System.Xml.IDtdParserAdapter.BaseUri { get; }
	private bool System.Xml.IDtdParserAdapter.IsEof { get; }
	private char[] System.Xml.IDtdParserAdapter.ParsingBuffer { get; }
	private int System.Xml.IDtdParserAdapter.ParsingBufferLength { get; }
	private int System.Xml.IDtdParserAdapter.CurrentPosition { get; set; }
	private int System.Xml.IDtdParserAdapter.EntityStackLength { get; }
	private bool System.Xml.IDtdParserAdapter.IsEntityEolNormalized { get; }
	private int System.Xml.IDtdParserAdapter.LineNo { get; }
	private int System.Xml.IDtdParserAdapter.LineStartPosition { get; }
	private bool System.Xml.IDtdParserAdapterWithValidation.DtdValidation { get; }
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.ValidationEventHandling { get; }
	private bool System.Xml.IDtdParserAdapterV1.Normalization { get; }
	private bool System.Xml.IDtdParserAdapterV1.Namespaces { get; }
	private bool System.Xml.IDtdParserAdapterV1.V1CompatibilityMode { get; }

	// Methods

	// RVA: 0x1C26DE4 Offset: 0x1C22DE4 VA: 0x1C26DE4
	internal void .ctor(XmlTextReaderImpl reader) { }

	// RVA: 0x1C26E14 Offset: 0x1C22E14 VA: 0x1C26E14 Slot: 9
	private XmlNameTable System.Xml.IDtdParserAdapter.get_NameTable() { }

	// RVA: 0x1C26E2C Offset: 0x1C22E2C VA: 0x1C26E2C Slot: 10
	private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.get_NamespaceResolver() { }

	// RVA: 0x1C26E44 Offset: 0x1C22E44 VA: 0x1C26E44 Slot: 11
	private Uri System.Xml.IDtdParserAdapter.get_BaseUri() { }

	// RVA: 0x1C26E5C Offset: 0x1C22E5C VA: 0x1C26E5C Slot: 18
	private bool System.Xml.IDtdParserAdapter.get_IsEof() { }

	// RVA: 0x1C26E74 Offset: 0x1C22E74 VA: 0x1C26E74 Slot: 12
	private char[] System.Xml.IDtdParserAdapter.get_ParsingBuffer() { }

	// RVA: 0x1C26E8C Offset: 0x1C22E8C VA: 0x1C26E8C Slot: 13
	private int System.Xml.IDtdParserAdapter.get_ParsingBufferLength() { }

	// RVA: 0x1C26EA4 Offset: 0x1C22EA4 VA: 0x1C26EA4 Slot: 14
	private int System.Xml.IDtdParserAdapter.get_CurrentPosition() { }

	// RVA: 0x1C26EBC Offset: 0x1C22EBC VA: 0x1C26EBC Slot: 15
	private void System.Xml.IDtdParserAdapter.set_CurrentPosition(int value) { }

	// RVA: 0x1C26ED4 Offset: 0x1C22ED4 VA: 0x1C26ED4 Slot: 19
	private int System.Xml.IDtdParserAdapter.get_EntityStackLength() { }

	// RVA: 0x1C26EEC Offset: 0x1C22EEC VA: 0x1C26EEC Slot: 20
	private bool System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized() { }

	// RVA: 0x1C26F04 Offset: 0x1C22F04 VA: 0x1C26F04 Slot: 22
	private void System.Xml.IDtdParserAdapter.OnNewLine(int pos) { }

	// RVA: 0x1C26F1C Offset: 0x1C22F1C VA: 0x1C26F1C Slot: 16
	private int System.Xml.IDtdParserAdapter.get_LineNo() { }

	// RVA: 0x1C26F34 Offset: 0x1C22F34 VA: 0x1C26F34 Slot: 17
	private int System.Xml.IDtdParserAdapter.get_LineStartPosition() { }

	// RVA: 0x1C26F4C Offset: 0x1C22F4C VA: 0x1C26F4C Slot: 21
	private int System.Xml.IDtdParserAdapter.ReadData() { }

	// RVA: 0x1C26F64 Offset: 0x1C22F64 VA: 0x1C26F64 Slot: 23
	private int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1C26F7C Offset: 0x1C22F7C VA: 0x1C26F7C Slot: 24
	private int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1C26F98 Offset: 0x1C22F98 VA: 0x1C26F98 Slot: 25
	private void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb) { }

	// RVA: 0x1C26FB0 Offset: 0x1C22FB0 VA: 0x1C26FB0 Slot: 26
	private void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb) { }

	// RVA: 0x1C26FC8 Offset: 0x1C22FC8 VA: 0x1C26FC8 Slot: 27
	private bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x1C26FE0 Offset: 0x1C22FE0 VA: 0x1C26FE0 Slot: 28
	private bool System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x1C26FF8 Offset: 0x1C22FF8 VA: 0x1C26FF8 Slot: 29
	private bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x1C27010 Offset: 0x1C23010 VA: 0x1C27010 Slot: 30
	private void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1C27028 Offset: 0x1C23028 VA: 0x1C27028 Slot: 33
	private void System.Xml.IDtdParserAdapter.Throw(Exception e) { }

	// RVA: 0x1C27040 Offset: 0x1C23040 VA: 0x1C27040 Slot: 31
	private void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x1C27058 Offset: 0x1C23058 VA: 0x1C27058 Slot: 32
	private void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x1C27070 Offset: 0x1C23070 VA: 0x1C27070 Slot: 7
	private bool System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation() { }

	// RVA: 0x1C27088 Offset: 0x1C23088 VA: 0x1C27088 Slot: 8
	private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.get_ValidationEventHandling() { }

	// RVA: 0x1C270A0 Offset: 0x1C230A0 VA: 0x1C270A0 Slot: 5
	private bool System.Xml.IDtdParserAdapterV1.get_Normalization() { }

	// RVA: 0x1C270B8 Offset: 0x1C230B8 VA: 0x1C270B8 Slot: 6
	private bool System.Xml.IDtdParserAdapterV1.get_Namespaces() { }

	// RVA: 0x1C270D0 Offset: 0x1C230D0 VA: 0x1C270D0 Slot: 4
	private bool System.Xml.IDtdParserAdapterV1.get_V1CompatibilityMode() { }
}

// Namespace: 
private class XmlTextReaderImpl.NodeData : IComparable // TypeDefIndex: 3138
{
	// Fields
	private static XmlTextReaderImpl.NodeData s_None; // 0x0
	internal XmlNodeType type; // 0x10
	internal string localName; // 0x18
	internal string prefix; // 0x20
	internal string ns; // 0x28
	internal string nameWPrefix; // 0x30
	private string value; // 0x38
	private char[] chars; // 0x40
	private int valueStartPos; // 0x48
	private int valueLength; // 0x4C
	internal LineInfo lineInfo; // 0x50
	internal LineInfo lineInfo2; // 0x58
	internal char quoteChar; // 0x60
	internal int depth; // 0x64
	private bool isEmptyOrDefault; // 0x68
	internal int entityId; // 0x6C
	internal bool xmlContextPushed; // 0x70
	internal XmlTextReaderImpl.NodeData nextAttrValueChunk; // 0x78
	internal object schemaType; // 0x80
	internal object typedValue; // 0x88

	// Properties
	internal static XmlTextReaderImpl.NodeData None { get; }
	internal int LineNo { get; }
	internal int LinePos { get; }
	internal bool IsEmptyElement { get; set; }
	internal bool IsDefaultAttribute { get; set; }
	internal bool ValueBuffered { get; }
	internal string StringValue { get; }

	// Methods

	// RVA: 0x1C270E8 Offset: 0x1C230E8 VA: 0x1C270E8
	internal static XmlTextReaderImpl.NodeData get_None() { }

	// RVA: 0x1C27190 Offset: 0x1C23190 VA: 0x1C27190
	internal void .ctor() { }

	// RVA: 0x1C27234 Offset: 0x1C23234 VA: 0x1C27234
	internal int get_LineNo() { }

	// RVA: 0x1C2723C Offset: 0x1C2323C VA: 0x1C2723C
	internal int get_LinePos() { }

	// RVA: 0x1C27244 Offset: 0x1C23244 VA: 0x1C27244
	internal bool get_IsEmptyElement() { }

	// RVA: 0x1C27268 Offset: 0x1C23268 VA: 0x1C27268
	internal void set_IsEmptyElement(bool value) { }

	// RVA: 0x1C27270 Offset: 0x1C23270 VA: 0x1C27270
	internal bool get_IsDefaultAttribute() { }

	// RVA: 0x1C27294 Offset: 0x1C23294 VA: 0x1C27294
	internal void set_IsDefaultAttribute(bool value) { }

	// RVA: 0x1C2729C Offset: 0x1C2329C VA: 0x1C2729C
	internal bool get_ValueBuffered() { }

	// RVA: 0x1C272AC Offset: 0x1C232AC VA: 0x1C272AC
	internal string get_StringValue() { }

	// RVA: 0x1C272F4 Offset: 0x1C232F4 VA: 0x1C272F4
	internal void TrimSpacesInValue() { }

	// RVA: 0x1C271B8 Offset: 0x1C231B8 VA: 0x1C271B8
	internal void Clear(XmlNodeType type) { }

	// RVA: 0x1C27340 Offset: 0x1C23340 VA: 0x1C27340
	internal void ClearName() { }

	// RVA: 0x1C273B8 Offset: 0x1C233B8 VA: 0x1C273B8
	internal void SetLineInfo(int lineNo, int linePos) { }

	// RVA: 0x1C273C4 Offset: 0x1C233C4 VA: 0x1C273C4
	internal void SetLineInfo2(int lineNo, int linePos) { }

	// RVA: 0x1C273D0 Offset: 0x1C233D0 VA: 0x1C273D0
	internal void SetValueNode(XmlNodeType type, string value) { }

	// RVA: 0x1C2740C Offset: 0x1C2340C VA: 0x1C2740C
	internal void SetValueNode(XmlNodeType type, char[] chars, int startPos, int len) { }

	// RVA: 0x1C27464 Offset: 0x1C23464 VA: 0x1C27464
	internal void SetNamedNode(XmlNodeType type, string localName) { }

	// RVA: 0x1C27480 Offset: 0x1C23480 VA: 0x1C27480
	internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x1C27510 Offset: 0x1C23510 VA: 0x1C27510
	internal void SetValue(string value) { }

	// RVA: 0x1C27520 Offset: 0x1C23520 VA: 0x1C27520
	internal void SetValue(char[] chars, int startPos, int len) { }

	// RVA: 0x1C2756C Offset: 0x1C2356C VA: 0x1C2756C
	internal void OnBufferInvalidated() { }

	// RVA: 0x1C275BC Offset: 0x1C235BC VA: 0x1C275BC
	internal void CopyTo(int valueOffset, StringBuilder sb) { }

	// RVA: 0x1C27638 Offset: 0x1C23638 VA: 0x1C27638
	internal int CopyTo(int valueOffset, char[] buffer, int offset, int length) { }

	// RVA: 0x1C27698 Offset: 0x1C23698 VA: 0x1C27698
	internal string GetNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1C276AC Offset: 0x1C236AC VA: 0x1C276AC
	internal string CreateNameWPrefix(XmlNameTable nt) { }

	// RVA: 0x1C27750 Offset: 0x1C23750 VA: 0x1C27750 Slot: 4
	private int System.IComparable.CompareTo(object obj) { }
}

// Namespace: 
private class XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer : IComparer<object> // TypeDefIndex: 3139
{
	// Fields
	private static IComparer<object> s_instance; // 0x0

	// Properties
	internal static IComparer<object> Instance { get; }

	// Methods

	// RVA: 0x1C2782C Offset: 0x1C2382C VA: 0x1C2782C
	internal static IComparer<object> get_Instance() { }

	// RVA: 0x1C27884 Offset: 0x1C23884 VA: 0x1C27884 Slot: 4
	public int Compare(object x, object y) { }

	// RVA: 0x1C27BC4 Offset: 0x1C23BC4 VA: 0x1C27BC4
	public void .ctor() { }

	// RVA: 0x1C27BCC Offset: 0x1C23BCC VA: 0x1C27BCC
	private static void .cctor() { }
}

// Namespace: 
internal sealed class XmlTextReaderImpl.OnDefaultAttributeUseDelegate : MulticastDelegate // TypeDefIndex: 3140
{
	// Methods

	// RVA: 0x1C27C34 Offset: 0x1C23C34 VA: 0x1C27C34
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C27D40 Offset: 0x1C23D40 VA: 0x1C27D40 Slot: 12
	public virtual void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }
}

// Namespace: System.Xml
internal class XmlTextReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 3141
{
	// Fields
	private readonly bool useAsync; // 0x10
	private XmlTextReaderImpl.LaterInitParam laterInitParam; // 0x18
	private XmlCharType xmlCharType; // 0x20
	private XmlTextReaderImpl.ParsingState ps; // 0x28
	private XmlTextReaderImpl.ParsingFunction parsingFunction; // 0xA0
	private XmlTextReaderImpl.ParsingFunction nextParsingFunction; // 0xA4
	private XmlTextReaderImpl.ParsingFunction nextNextParsingFunction; // 0xA8
	private XmlTextReaderImpl.NodeData[] nodes; // 0xB0
	private XmlTextReaderImpl.NodeData curNode; // 0xB8
	private int index; // 0xC0
	private int curAttrIndex; // 0xC4
	private int attrCount; // 0xC8
	private int attrHashtable; // 0xCC
	private int attrDuplWalkCount; // 0xD0
	private bool attrNeedNamespaceLookup; // 0xD4
	private bool fullAttrCleanup; // 0xD5
	private XmlTextReaderImpl.NodeData[] attrDuplSortingArray; // 0xD8
	private XmlNameTable nameTable; // 0xE0
	private bool nameTableFromSettings; // 0xE8
	private XmlResolver xmlResolver; // 0xF0
	private string url; // 0xF8
	private bool normalize; // 0x100
	private bool supportNamespaces; // 0x101
	private WhitespaceHandling whitespaceHandling; // 0x104
	private DtdProcessing dtdProcessing; // 0x108
	private EntityHandling entityHandling; // 0x10C
	private bool ignorePIs; // 0x110
	private bool ignoreComments; // 0x111
	private bool checkCharacters; // 0x112
	private int lineNumberOffset; // 0x114
	private int linePositionOffset; // 0x118
	private bool closeInput; // 0x11C
	private long maxCharactersInDocument; // 0x120
	private long maxCharactersFromEntities; // 0x128
	private bool v1Compat; // 0x130
	private XmlNamespaceManager namespaceManager; // 0x138
	private string lastPrefix; // 0x140
	private XmlTextReaderImpl.XmlContext xmlContext; // 0x148
	private XmlTextReaderImpl.ParsingState[] parsingStatesStack; // 0x150
	private int parsingStatesStackTop; // 0x158
	private string reportedBaseUri; // 0x160
	private Encoding reportedEncoding; // 0x168
	private IDtdInfo dtdInfo; // 0x170
	private XmlNodeType fragmentType; // 0x178
	private XmlParserContext fragmentParserContext; // 0x180
	private bool fragment; // 0x188
	private IncrementalReadDecoder incReadDecoder; // 0x190
	private XmlTextReaderImpl.IncrementalReadState incReadState; // 0x198
	private LineInfo incReadLineInfo; // 0x19C
	private int incReadDepth; // 0x1A4
	private int incReadLeftStartPos; // 0x1A8
	private int incReadLeftEndPos; // 0x1AC
	private int attributeValueBaseEntityId; // 0x1B0
	private bool emptyEntityInAttributeResolved; // 0x1B4
	private IValidationEventHandling validationEventHandling; // 0x1B8
	private XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse; // 0x1C0
	private bool validatingReaderCompatFlag; // 0x1C8
	private bool addDefaultAttributesAndNormalize; // 0x1C9
	private StringBuilder stringBuilder; // 0x1D0
	private bool rootElementParsed; // 0x1D8
	private bool standalone; // 0x1D9
	private int nextEntityId; // 0x1DC
	private XmlTextReaderImpl.ParsingMode parsingMode; // 0x1E0
	private ReadState readState; // 0x1E4
	private IDtdEntityInfo lastEntity; // 0x1E8
	private bool afterResetState; // 0x1F0
	private int documentStartBytePos; // 0x1F4
	private int readValueOffset; // 0x1F8
	private long charactersInDocument; // 0x200
	private long charactersFromEntities; // 0x208
	private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities; // 0x210
	private bool disableUndeclaredEntityCheck; // 0x218
	private XmlReader outerReader; // 0x220
	private bool xmlResolverIsSet; // 0x228
	private string Xml; // 0x230
	private string XmlNs; // 0x238
	private Task<Tuple<int, int, int, bool>> parseText_dummyTask; // 0x240

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override ReadState ReadState { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override bool CanResolveEntity { get; }
	public override int AttributeCount { get; }
	internal XmlReader OuterReader { set; }
	public override bool CanReadValueChunk { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal bool Namespaces { get; set; }
	internal bool Normalization { get; set; }
	internal WhitespaceHandling WhitespaceHandling { set; }
	internal EntityHandling EntityHandling { set; }
	internal bool IsResolverSet { get; }
	internal XmlResolver XmlResolver { set; }
	internal XmlNameTable DtdParserProxy_NameTable { get; }
	internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver { get; }
	internal bool DtdParserProxy_DtdValidation { get; }
	internal bool DtdParserProxy_Normalization { get; }
	internal bool DtdParserProxy_Namespaces { get; }
	internal bool DtdParserProxy_V1CompatibilityMode { get; }
	internal Uri DtdParserProxy_BaseUri { get; }
	internal bool DtdParserProxy_IsEof { get; }
	internal char[] DtdParserProxy_ParsingBuffer { get; }
	internal int DtdParserProxy_ParsingBufferLength { get; }
	internal int DtdParserProxy_CurrentPosition { get; set; }
	internal int DtdParserProxy_EntityStackLength { get; }
	internal bool DtdParserProxy_IsEntityEolNormalized { get; }
	internal IValidationEventHandling DtdParserProxy_ValidationEventHandling { get; }
	internal int DtdParserProxy_LineNo { get; }
	internal int DtdParserProxy_LineStartPosition { get; }
	private bool IsResolverNull { get; }
	private bool InAttributeValueIterator { get; }
	private bool DtdValidation { get; }
	private bool InEntity { get; }
	internal override IDtdInfo DtdInfo { get; }
	internal IValidationEventHandling ValidationEventHandling { set; }
	internal XmlTextReaderImpl.OnDefaultAttributeUseDelegate OnDefaultAttributeUse { set; }
	internal bool XmlValidatingReaderCompatibilityMode { set; }
	internal XmlNodeType FragmentType { get; }
	internal object InternalSchemaType { set; }
	internal object InternalTypedValue { get; set; }
	internal bool StandAlone { get; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool V1Compat { get; }
	internal bool DisableUndeclaredEntityCheck { set; }

	// Methods

	// RVA: 0x1B580A0 Offset: 0x1B540A0 VA: 0x1B580A0
	internal void .ctor(XmlNameTable nt) { }

	// RVA: 0x1B584C8 Offset: 0x1B544C8 VA: 0x1B584C8
	private void .ctor(XmlResolver resolver, XmlReaderSettings settings, XmlParserContext context) { }

	// RVA: 0x1B58C30 Offset: 0x1B54C30 VA: 0x1B58C30
	internal void .ctor(Stream input) { }

	// RVA: 0x1B58CB4 Offset: 0x1B54CB4 VA: 0x1B58CB4
	internal void .ctor(string url, Stream input, XmlNameTable nt) { }

	// RVA: 0x1B58DF4 Offset: 0x1B54DF4 VA: 0x1B58DF4
	internal void .ctor(TextReader input) { }

	// RVA: 0x1B58F50 Offset: 0x1B54F50 VA: 0x1B58F50
	internal void .ctor(TextReader input, XmlNameTable nt) { }

	// RVA: 0x1B58E78 Offset: 0x1B54E78 VA: 0x1B58E78
	internal void .ctor(string url, TextReader input, XmlNameTable nt) { }

	// RVA: 0x1B58F80 Offset: 0x1B54F80 VA: 0x1B58F80
	internal void .ctor(string xmlFragment, XmlNodeType fragType, XmlParserContext context) { }

	// RVA: 0x1B593FC Offset: 0x1B553FC VA: 0x1B593FC
	internal void .ctor(string xmlFragment, XmlParserContext context) { }

	// RVA: 0x1B59544 Offset: 0x1B55544 VA: 0x1B59544
	private void FinishInitUriString() { }

	// RVA: 0x1B59B90 Offset: 0x1B55B90 VA: 0x1B59B90
	internal void .ctor(Stream stream, byte[] bytes, int byteCount, XmlReaderSettings settings, Uri baseUri, string baseUriStr, XmlParserContext context, bool closeInput) { }

	// RVA: 0x1B59E70 Offset: 0x1B55E70 VA: 0x1B59E70
	private void FinishInitStream() { }

	// RVA: 0x1B59F0C Offset: 0x1B55F0C VA: 0x1B59F0C
	internal void .ctor(TextReader input, XmlReaderSettings settings, string baseUriStr, XmlParserContext context) { }

	// RVA: 0x1B5A038 Offset: 0x1B56038 VA: 0x1B5A038
	private void FinishInitTextReader() { }

	// RVA: 0x1B5A0B8 Offset: 0x1B560B8 VA: 0x1B5A0B8
	internal void .ctor(string xmlFragment, XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x1B5A134 Offset: 0x1B56134 VA: 0x1B5A134 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1B5A2A8 Offset: 0x1B562A8 VA: 0x1B5A2A8 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1B5A2C0 Offset: 0x1B562C0 VA: 0x1B5A2C0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1B5A2E0 Offset: 0x1B562E0 VA: 0x1B5A2E0 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1B5A2F8 Offset: 0x1B562F8 VA: 0x1B5A2F8 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1B5A310 Offset: 0x1B56310 VA: 0x1B5A310 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1B5A328 Offset: 0x1B56328 VA: 0x1B5A328 Slot: 11
	public override string get_Value() { }

	// RVA: 0x1B5A534 Offset: 0x1B56534 VA: 0x1B5A534 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x1B5A54C Offset: 0x1B5654C VA: 0x1B5A54C Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x1B5A554 Offset: 0x1B56554 VA: 0x1B5A554 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1B5A56C Offset: 0x1B5656C VA: 0x1B5A56C Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1B5A584 Offset: 0x1B56584 VA: 0x1B5A584 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x1B5A5B0 Offset: 0x1B565B0 VA: 0x1B5A5B0 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1B5A5C8 Offset: 0x1B565C8 VA: 0x1B5A5C8 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x1B5A5E0 Offset: 0x1B565E0 VA: 0x1B5A5E0 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x1B5A5E8 Offset: 0x1B565E8 VA: 0x1B5A5E8 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x1B5A5F8 Offset: 0x1B565F8 VA: 0x1B5A5F8 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1B5A600 Offset: 0x1B56600 VA: 0x1B5A600 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1B5A608 Offset: 0x1B56608 VA: 0x1B5A608 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x1B5A610 Offset: 0x1B56610 VA: 0x1B5A610 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x1B5A830 Offset: 0x1B56830 VA: 0x1B5A830 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1B5A988 Offset: 0x1B56988 VA: 0x1B5A988 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x1B5AA24 Offset: 0x1B56A24 VA: 0x1B5AA24 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1B5ABAC Offset: 0x1B56BAC VA: 0x1B5ABAC Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1B5AC70 Offset: 0x1B56C70 VA: 0x1B5AC70 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1B5ACF0 Offset: 0x1B56CF0 VA: 0x1B5ACF0 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1B5AD90 Offset: 0x1B56D90 VA: 0x1B5AD90 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x1B5AE20 Offset: 0x1B56E20 VA: 0x1B5AE20
	private void FinishInit() { }

	// RVA: 0x1B5AE58 Offset: 0x1B56E58 VA: 0x1B5AE58 Slot: 31
	public override bool Read() { }

	// RVA: 0x1B5CF68 Offset: 0x1B58F68 VA: 0x1B5CF68 Slot: 33
	public override void Close() { }

	// RVA: 0x1B5D034 Offset: 0x1B59034 VA: 0x1B5D034 Slot: 35
	public override void Skip() { }

	// RVA: 0x1B5D1CC Offset: 0x1B591CC VA: 0x1B5D1CC Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1B5D1FC Offset: 0x1B591FC VA: 0x1B5D1FC Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x1B5D8D8 Offset: 0x1B598D8 VA: 0x1B5D8D8 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1B5DFFC Offset: 0x1B59FFC VA: 0x1B5DFFC
	internal void set_OuterReader(XmlReader value) { }

	// RVA: 0x1B5E00C Offset: 0x1B5A00C VA: 0x1B5E00C
	internal void MoveOffEntityReference() { }

	// RVA: 0x1B5E0BC Offset: 0x1B5A0BC VA: 0x1B5E0BC Slot: 42
	public override string ReadString() { }

	// RVA: 0x1B5E0D8 Offset: 0x1B5A0D8 VA: 0x1B5E0D8 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1B5E0E0 Offset: 0x1B5A0E0 VA: 0x1B5E0E0 Slot: 41
	public override int ReadValueChunk(char[] buffer, int index, int count) { }

	// RVA: 0x1B5EB2C Offset: 0x1B5AB2C VA: 0x1B5EB2C Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0x1B5EB34 Offset: 0x1B5AB34 VA: 0x1B5EB34 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0x1B5EB4C Offset: 0x1B5AB4C VA: 0x1B5EB4C Slot: 55
	public int get_LinePosition() { }

	// RVA: 0x1B5EB64 Offset: 0x1B5AB64 VA: 0x1B5EB64 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1B5EBA4 Offset: 0x1B5ABA4 VA: 0x1B5EBA4 Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1B5EBB4 Offset: 0x1B5ABB4 VA: 0x1B5EBB4 Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1B5EB84 Offset: 0x1B5AB84 VA: 0x1B5EB84
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1B5EBD4 Offset: 0x1B5ABD4 VA: 0x1B5EBD4
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x1B5EBF4 Offset: 0x1B5ABF4 VA: 0x1B5EBF4
	internal bool get_Namespaces() { }

	// RVA: 0x1B5EBFC Offset: 0x1B5ABFC VA: 0x1B5EBFC
	internal void set_Namespaces(bool value) { }

	// RVA: 0x1B5EDF0 Offset: 0x1B5ADF0 VA: 0x1B5EDF0
	internal bool get_Normalization() { }

	// RVA: 0x1B5EDF8 Offset: 0x1B5ADF8 VA: 0x1B5EDF8
	internal void set_Normalization(bool value) { }

	// RVA: 0x1B5EF14 Offset: 0x1B5AF14 VA: 0x1B5EF14
	internal void set_WhitespaceHandling(WhitespaceHandling value) { }

	// RVA: 0x1B5EFDC Offset: 0x1B5AFDC VA: 0x1B5EFDC
	internal void set_EntityHandling(EntityHandling value) { }

	// RVA: 0x1B5F058 Offset: 0x1B5B058 VA: 0x1B5F058
	internal bool get_IsResolverSet() { }

	// RVA: 0x1B5F060 Offset: 0x1B5B060 VA: 0x1B5F060
	internal void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1B5F0E8 Offset: 0x1B5B0E8 VA: 0x1B5F0E8
	internal XmlNameTable get_DtdParserProxy_NameTable() { }

	// RVA: 0x1B5F0F0 Offset: 0x1B5B0F0 VA: 0x1B5F0F0
	internal IXmlNamespaceResolver get_DtdParserProxy_NamespaceResolver() { }

	// RVA: 0x1B5F0F8 Offset: 0x1B5B0F8 VA: 0x1B5F0F8
	internal bool get_DtdParserProxy_DtdValidation() { }

	// RVA: 0x1B5F118 Offset: 0x1B5B118 VA: 0x1B5F118
	internal bool get_DtdParserProxy_Normalization() { }

	// RVA: 0x1B5F120 Offset: 0x1B5B120 VA: 0x1B5F120
	internal bool get_DtdParserProxy_Namespaces() { }

	// RVA: 0x1B5F128 Offset: 0x1B5B128 VA: 0x1B5F128
	internal bool get_DtdParserProxy_V1CompatibilityMode() { }

	// RVA: 0x1B5F130 Offset: 0x1B5B130 VA: 0x1B5F130
	internal Uri get_DtdParserProxy_BaseUri() { }

	// RVA: 0x1B5F1E4 Offset: 0x1B5B1E4 VA: 0x1B5F1E4
	internal bool get_DtdParserProxy_IsEof() { }

	// RVA: 0x1B5F1EC Offset: 0x1B5B1EC VA: 0x1B5F1EC
	internal char[] get_DtdParserProxy_ParsingBuffer() { }

	// RVA: 0x1B5F1F4 Offset: 0x1B5B1F4 VA: 0x1B5F1F4
	internal int get_DtdParserProxy_ParsingBufferLength() { }

	// RVA: 0x1B5F1FC Offset: 0x1B5B1FC VA: 0x1B5F1FC
	internal int get_DtdParserProxy_CurrentPosition() { }

	// RVA: 0x1B5F204 Offset: 0x1B5B204 VA: 0x1B5F204
	internal void set_DtdParserProxy_CurrentPosition(int value) { }

	// RVA: 0x1B5F20C Offset: 0x1B5B20C VA: 0x1B5F20C
	internal int get_DtdParserProxy_EntityStackLength() { }

	// RVA: 0x1B5F218 Offset: 0x1B5B218 VA: 0x1B5F218
	internal bool get_DtdParserProxy_IsEntityEolNormalized() { }

	// RVA: 0x1B5F220 Offset: 0x1B5B220 VA: 0x1B5F220
	internal IValidationEventHandling get_DtdParserProxy_ValidationEventHandling() { }

	// RVA: 0x1B5F228 Offset: 0x1B5B228 VA: 0x1B5F228
	internal void DtdParserProxy_OnNewLine(int pos) { }

	// RVA: 0x1B5F250 Offset: 0x1B5B250 VA: 0x1B5F250
	internal int get_DtdParserProxy_LineNo() { }

	// RVA: 0x1B5F258 Offset: 0x1B5B258 VA: 0x1B5F258
	internal int get_DtdParserProxy_LineStartPosition() { }

	// RVA: 0x1B5F260 Offset: 0x1B5B260 VA: 0x1B5F260
	internal int DtdParserProxy_ReadData() { }

	// RVA: 0x1B5F6AC Offset: 0x1B5B6AC VA: 0x1B5F6AC
	internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1B5F78C Offset: 0x1B5B78C VA: 0x1B5F78C
	internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1B5F7F4 Offset: 0x1B5B7F4 VA: 0x1B5F7F4
	internal void DtdParserProxy_ParsePI(StringBuilder sb) { }

	// RVA: 0x1B5FB9C Offset: 0x1B5BB9C VA: 0x1B5FB9C
	internal void DtdParserProxy_ParseComment(StringBuilder sb) { }

	// RVA: 0x1B5FF4C Offset: 0x1B5BF4C VA: 0x1B5FF4C
	private bool get_IsResolverNull() { }

	// RVA: 0x1B5FF8C Offset: 0x1B5BF8C VA: 0x1B5FF8C
	private XmlResolver GetTempResolver() { }

	// RVA: 0x1B5FFEC Offset: 0x1B5BFEC VA: 0x1B5FFEC
	internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId) { }

	// RVA: 0x1B60798 Offset: 0x1B5C798 VA: 0x1B60798
	internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId) { }

	// RVA: 0x1B60848 Offset: 0x1B5C848 VA: 0x1B60848
	internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId) { }

	// RVA: 0x1B60F64 Offset: 0x1B5CF64 VA: 0x1B60F64
	internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd) { }

	// RVA: 0x1B611CC Offset: 0x1B5D1CC VA: 0x1B611CC
	internal void DtdParserProxy_Throw(Exception e) { }

	// RVA: 0x1B6125C Offset: 0x1B5D25C VA: 0x1B6125C
	internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo) { }

	// RVA: 0x1B61364 Offset: 0x1B5D364 VA: 0x1B61364
	internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo) { }

	// RVA: 0x1B613F0 Offset: 0x1B5D3F0 VA: 0x1B613F0
	private void Throw(int pos, string res, string arg) { }

	// RVA: 0x1B61498 Offset: 0x1B5D498 VA: 0x1B61498
	private void Throw(int pos, string res, string[] args) { }

	// RVA: 0x1B61540 Offset: 0x1B5D540 VA: 0x1B61540
	private void Throw(int pos, string res) { }

	// RVA: 0x1B59E54 Offset: 0x1B55E54 VA: 0x1B59E54
	private void Throw(string res) { }

	// RVA: 0x1B61568 Offset: 0x1B5D568 VA: 0x1B61568
	private void Throw(string res, int lineNo, int linePos) { }

	// RVA: 0x1B61404 Offset: 0x1B5D404 VA: 0x1B61404
	private void Throw(string res, string arg) { }

	// RVA: 0x1B615FC Offset: 0x1B5D5FC VA: 0x1B615FC
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x1B614AC Offset: 0x1B5D4AC VA: 0x1B614AC
	private void Throw(string res, string[] args) { }

	// RVA: 0x1B61680 Offset: 0x1B5D680 VA: 0x1B61680
	private void Throw(string res, string arg, Exception innerException) { }

	// RVA: 0x1B61710 Offset: 0x1B5D710 VA: 0x1B61710
	private void Throw(string res, string[] args, Exception innerException) { }

	// RVA: 0x1B611D4 Offset: 0x1B5D1D4 VA: 0x1B611D4
	private void Throw(Exception e) { }

	// RVA: 0x1B617C4 Offset: 0x1B5D7C4 VA: 0x1B617C4
	private void ReThrow(Exception e, int lineNo, int linePos) { }

	// RVA: 0x1B5CD7C Offset: 0x1B58D7C VA: 0x1B5CD7C
	private void ThrowWithoutLineInfo(string res) { }

	// RVA: 0x1B61864 Offset: 0x1B5D864 VA: 0x1B61864
	private void ThrowWithoutLineInfo(string res, string arg) { }

	// RVA: 0x1B618D4 Offset: 0x1B5D8D4 VA: 0x1B618D4
	private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException) { }

	// RVA: 0x1B61958 Offset: 0x1B5D958 VA: 0x1B61958
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x1B617B0 Offset: 0x1B5D7B0 VA: 0x1B617B0
	private void SetErrorState() { }

	// RVA: 0x1B5FEA8 Offset: 0x1B5BEA8 VA: 0x1B5FEA8
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos) { }

	// RVA: 0x1B619C8 Offset: 0x1B5D9C8 VA: 0x1B619C8
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception) { }

	// RVA: 0x1B5AAE8 Offset: 0x1B56AE8 VA: 0x1B5AAE8
	private bool get_InAttributeValueIterator() { }

	// RVA: 0x1B5AB0C Offset: 0x1B56B0C VA: 0x1B5AB0C
	private void FinishAttributeValueIterator() { }

	// RVA: 0x1B5F108 Offset: 0x1B5B108 VA: 0x1B5F108
	private bool get_DtdValidation() { }

	// RVA: 0x1B58DAC Offset: 0x1B54DAC VA: 0x1B58DAC
	private void InitStreamInput(Stream stream, Encoding encoding) { }

	// RVA: 0x1B58DD8 Offset: 0x1B54DD8 VA: 0x1B58DD8
	private void InitStreamInput(string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x1B61BF8 Offset: 0x1B5DBF8 VA: 0x1B61BF8
	private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding) { }

	// RVA: 0x1B61C58 Offset: 0x1B5DC58 VA: 0x1B61C58
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding) { }

	// RVA: 0x1B5984C Offset: 0x1B5584C VA: 0x1B5984C
	private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, byte[] bytes, int byteCount, Encoding encoding) { }

	// RVA: 0x1B58F74 Offset: 0x1B54F74 VA: 0x1B58F74
	private void InitTextReaderInput(string baseUriStr, TextReader input) { }

	// RVA: 0x1B61FEC Offset: 0x1B5DFEC VA: 0x1B61FEC
	private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input) { }

	// RVA: 0x1B59088 Offset: 0x1B55088 VA: 0x1B59088
	private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str) { }

	// RVA: 0x1B5918C Offset: 0x1B5518C VA: 0x1B5918C
	private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment) { }

	// RVA: 0x1B59B24 Offset: 0x1B55B24 VA: 0x1B59B24
	private void ProcessDtdFromParserContext(XmlParserContext context) { }

	// RVA: 0x1B5BA9C Offset: 0x1B57A9C VA: 0x1B5BA9C
	private void OpenUrl() { }

	// RVA: 0x1B62310 Offset: 0x1B5E310 VA: 0x1B62310
	private void OpenUrlDelegate(object xmlResolver) { }

	// RVA: 0x1B61C68 Offset: 0x1B5DC68 VA: 0x1B61C68
	private Encoding DetectEncoding() { }

	// RVA: 0x1B61E80 Offset: 0x1B5DE80 VA: 0x1B61E80
	private void SetupEncoding(Encoding encoding) { }

	// RVA: 0x1B6243C Offset: 0x1B5E43C VA: 0x1B6243C
	private void SwitchEncoding(Encoding newEncoding) { }

	// RVA: 0x1B625D8 Offset: 0x1B5E5D8 VA: 0x1B625D8
	private Encoding CheckEncoding(string newEncodingName) { }

	// RVA: 0x1B6252C Offset: 0x1B5E52C VA: 0x1B6252C
	private void UnDecodeChars() { }

	// RVA: 0x1B62920 Offset: 0x1B5E920 VA: 0x1B62920
	private void SwitchEncodingToUTF8() { }

	// RVA: 0x1B5F264 Offset: 0x1B5B264 VA: 0x1B5F264
	private int ReadData() { }

	// RVA: 0x1B6298C Offset: 0x1B5E98C VA: 0x1B6298C
	private int GetChars(int maxCharsCount) { }

	// RVA: 0x1B62AC4 Offset: 0x1B5EAC4 VA: 0x1B62AC4
	private void InvalidCharRecovery(ref int bytesCount, out int charsCount) { }

	// RVA: 0x1B5CF70 Offset: 0x1B58F70 VA: 0x1B5CF70
	internal void Close(bool closeInput) { }

	// RVA: 0x1B62CE0 Offset: 0x1B5ECE0 VA: 0x1B62CE0
	private void ShiftBuffer(int sourcePos, int destPos, int count) { }

	// RVA: 0x1B5BC54 Offset: 0x1B57C54 VA: 0x1B5BC54
	private bool ParseXmlDeclaration(bool isTextDecl) { }

	// RVA: 0x1B5B588 Offset: 0x1B57588 VA: 0x1B5B588
	private bool ParseDocumentContent() { }

	// RVA: 0x1B5B264 Offset: 0x1B57264 VA: 0x1B5B264
	private bool ParseElementContent() { }

	// RVA: 0x1B64298 Offset: 0x1B60298 VA: 0x1B64298
	private void ThrowUnclosedElements() { }

	// RVA: 0x1B631D8 Offset: 0x1B5F1D8 VA: 0x1B631D8
	private void ParseElement() { }

	// RVA: 0x1B64A7C Offset: 0x1B60A7C VA: 0x1B64A7C
	private void AddDefaultAttributesAndNormalize() { }

	// RVA: 0x1B63F04 Offset: 0x1B5FF04 VA: 0x1B63F04
	private void ParseEndElement() { }

	// RVA: 0x1B65BE8 Offset: 0x1B61BE8 VA: 0x1B65BE8
	private void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag) { }

	// RVA: 0x1B64444 Offset: 0x1B60444 VA: 0x1B64444
	private void ParseAttributes() { }

	// RVA: 0x1B65460 Offset: 0x1B61460 VA: 0x1B65460
	private void ElementNamespaceLookup() { }

	// RVA: 0x1B65B28 Offset: 0x1B61B28 VA: 0x1B65B28
	private void AttributeNamespaceLookup() { }

	// RVA: 0x1B66CE8 Offset: 0x1B62CE8 VA: 0x1B66CE8
	private void AttributeDuplCheck() { }

	// RVA: 0x1B6695C Offset: 0x1B6295C VA: 0x1B6695C
	private void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1B66A60 Offset: 0x1B62A60 VA: 0x1B66A60
	private void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1B66B18 Offset: 0x1B62B18 VA: 0x1B66B18
	private void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1B65FE8 Offset: 0x1B61FE8 VA: 0x1B65FE8
	private void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1B67394 Offset: 0x1B63394 VA: 0x1B67394
	private void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk) { }

	// RVA: 0x1B63984 Offset: 0x1B5F984 VA: 0x1B63984
	private bool ParseText() { }

	// RVA: 0x1B5E53C Offset: 0x1B5A53C VA: 0x1B5E53C
	private bool ParseText(out int startPos, out int endPos, ref int outOrChars) { }

	// RVA: 0x1B5A370 Offset: 0x1B56370 VA: 0x1B5A370
	private void FinishPartialValue() { }

	// RVA: 0x1B5A444 Offset: 0x1B56444 VA: 0x1B5A444
	private void FinishOtherValueIterator() { }

	// RVA: 0x1B5CDFC Offset: 0x1B58DFC VA: 0x1B5CDFC
	private void SkipPartialTextValue() { }

	// RVA: 0x1B5CE3C Offset: 0x1B58E3C VA: 0x1B5CE3C
	private void FinishReadValueChunk() { }

	// RVA: 0x1B5CE5C Offset: 0x1B58E5C VA: 0x1B5CE5C
	private void FinishReadContentAsBinary() { }

	// RVA: 0x1B5CEAC Offset: 0x1B58EAC VA: 0x1B5CEAC
	private void FinishReadElementContentAsBinary() { }

	// RVA: 0x1B63CF4 Offset: 0x1B5FCF4 VA: 0x1B63CF4
	private bool ParseRootLevelWhitespace() { }

	// RVA: 0x1B5C95C Offset: 0x1B5895C VA: 0x1B5C95C
	private void ParseEntityReference() { }

	// RVA: 0x1B636A8 Offset: 0x1B5F6A8 VA: 0x1B636A8
	private XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos) { }

	// RVA: 0x1B5DB20 Offset: 0x1B59B20 VA: 0x1B5DB20
	private XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos) { }

	// RVA: 0x1B62910 Offset: 0x1B5E910 VA: 0x1B62910
	private bool get_InEntity() { }

	// RVA: 0x1B61A90 Offset: 0x1B5DA90 VA: 0x1B61A90
	private bool HandleEntityEnd(bool checkEntityNesting) { }

	// RVA: 0x1B5C9D0 Offset: 0x1B589D0 VA: 0x1B5C9D0
	private void SetupEndEntityNodeInContent() { }

	// RVA: 0x1B677A0 Offset: 0x1B637A0 VA: 0x1B677A0
	private void SetupEndEntityNodeInAttribute() { }

	// RVA: 0x1B62EB8 Offset: 0x1B5EEB8 VA: 0x1B62EB8
	private bool ParsePI() { }

	// RVA: 0x1B5F838 Offset: 0x1B5B838 VA: 0x1B5F838
	private bool ParsePI(StringBuilder piInDtdStringBuilder) { }

	// RVA: 0x1B67818 Offset: 0x1B63818 VA: 0x1B67818
	private bool ParsePIValue(out int outStartPos, out int outEndPos) { }

	// RVA: 0x1B62EC0 Offset: 0x1B5EEC0 VA: 0x1B62EC0
	private bool ParseComment() { }

	// RVA: 0x1B62F28 Offset: 0x1B5EF28 VA: 0x1B62F28
	private void ParseCData() { }

	// RVA: 0x1B5FD4C Offset: 0x1B5BD4C VA: 0x1B5FD4C
	private void ParseCDataOrComment(XmlNodeType type) { }

	// RVA: 0x1B67B94 Offset: 0x1B63B94 VA: 0x1B67B94
	private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos) { }

	// RVA: 0x1B62F30 Offset: 0x1B5EF30 VA: 0x1B62F30
	private bool ParseDoctypeDecl() { }

	// RVA: 0x1B67FAC Offset: 0x1B63FAC VA: 0x1B67FAC
	private void ParseDtd() { }

	// RVA: 0x1B682C4 Offset: 0x1B642C4 VA: 0x1B682C4
	private void SkipDtd() { }

	// RVA: 0x1B6860C Offset: 0x1B6460C VA: 0x1B6860C
	private void SkipPublicOrSystemIdLiteral() { }

	// RVA: 0x1B686B8 Offset: 0x1B646B8 VA: 0x1B686B8
	private void SkipUntil(char stopChar, bool recognizeLiterals) { }

	// RVA: 0x1B60CF8 Offset: 0x1B5CCF8 VA: 0x1B60CF8
	private int EatWhitespaces(StringBuilder sb) { }

	// RVA: 0x1B675A8 Offset: 0x1B635A8 VA: 0x1B675A8
	private int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x1B5F6CC Offset: 0x1B5B6CC VA: 0x1B5F6CC
	private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x1B68B24 Offset: 0x1B64B24 VA: 0x1B68B24
	private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType) { }

	// RVA: 0x1B5F790 Offset: 0x1B5B790 VA: 0x1B5F790
	private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1B69114 Offset: 0x1B65114 VA: 0x1B69114
	private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder) { }

	// RVA: 0x1B62D0C Offset: 0x1B5ED0C VA: 0x1B62D0C
	private int ParseName() { }

	// RVA: 0x1B64434 Offset: 0x1B60434 VA: 0x1B64434
	private int ParseQName(out int colonPos) { }

	// RVA: 0x1B693EC Offset: 0x1B653EC VA: 0x1B693EC
	private int ParseQName(bool isQName, int startOffset, out int colonPos) { }

	// RVA: 0x1B69654 Offset: 0x1B65654 VA: 0x1B69654
	private bool ReadDataInName(ref int pos) { }

	// RVA: 0x1B673F4 Offset: 0x1B633F4 VA: 0x1B673F4
	private string ParseEntityName() { }

	// RVA: 0x1B5C8D4 Offset: 0x1B588D4 VA: 0x1B5C8D4
	private XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x1B69694 Offset: 0x1B65694 VA: 0x1B69694
	private XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth) { }

	// RVA: 0x1B612E8 Offset: 0x1B5D2E8 VA: 0x1B612E8
	private XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth) { }

	// RVA: 0x1B65E48 Offset: 0x1B61E48 VA: 0x1B65E48
	private XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos) { }

	// RVA: 0x1B697E8 Offset: 0x1B657E8 VA: 0x1B697E8
	private XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix) { }

	// RVA: 0x1B5C918 Offset: 0x1B58918 VA: 0x1B5C918
	private void PopElementContext() { }

	// RVA: 0x1B5F23C Offset: 0x1B5B23C VA: 0x1B5F23C
	private void OnNewLine(int pos) { }

	// RVA: 0x1B5CCDC Offset: 0x1B58CDC VA: 0x1B5CCDC
	private void OnEof() { }

	// RVA: 0x1B67068 Offset: 0x1B63068 VA: 0x1B67068
	private string LookupNamespace(XmlTextReaderImpl.NodeData node) { }

	// RVA: 0x1B67194 Offset: 0x1B63194 VA: 0x1B67194
	private void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr) { }

	// RVA: 0x1B5C8A8 Offset: 0x1B588A8 VA: 0x1B5C8A8
	private void ResetAttributes() { }

	// RVA: 0x1B69940 Offset: 0x1B65940 VA: 0x1B69940
	private void FullAttributeCleanup() { }

	// RVA: 0x1B67114 Offset: 0x1B63114 VA: 0x1B67114
	private void PushXmlContext() { }

	// RVA: 0x1B69908 Offset: 0x1B65908 VA: 0x1B69908
	private void PopXmlContext() { }

	// RVA: 0x1B6775C Offset: 0x1B6375C VA: 0x1B6775C
	private XmlNodeType GetWhitespaceType() { }

	// RVA: 0x1B67554 Offset: 0x1B63554 VA: 0x1B67554
	private XmlNodeType GetTextNodeType(int orChars) { }

	// RVA: 0x1B60990 Offset: 0x1B5C990 VA: 0x1B60990
	private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName) { }

	// RVA: 0x1B699DC Offset: 0x1B659DC VA: 0x1B699DC
	private bool OpenAndPush(Uri uri) { }

	// RVA: 0x1B600F8 Offset: 0x1B5C0F8 VA: 0x1B600F8
	private bool PushExternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1B6047C Offset: 0x1B5C47C VA: 0x1B6047C
	private void PushInternalEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1B607FC Offset: 0x1B5C7FC VA: 0x1B607FC
	private void PopEntity() { }

	// RVA: 0x1B69C00 Offset: 0x1B65C00 VA: 0x1B69C00
	private void RegisterEntity(IDtdEntityInfo entity) { }

	// RVA: 0x1B69E80 Offset: 0x1B65E80 VA: 0x1B69E80
	private void UnregisterEntity() { }

	// RVA: 0x1B60FD4 Offset: 0x1B5CFD4 VA: 0x1B60FD4
	private void PushParsingState() { }

	// RVA: 0x1B62C78 Offset: 0x1B5EC78 VA: 0x1B62C78
	private void PopParsingState() { }

	// RVA: 0x1B69EE4 Offset: 0x1B65EE4 VA: 0x1B69EE4
	private int IncrementalRead() { }

	// RVA: 0x1B5CB30 Offset: 0x1B58B30 VA: 0x1B5CB30
	private void FinishIncrementalRead() { }

	// RVA: 0x1B5CBA8 Offset: 0x1B58BA8 VA: 0x1B5CBA8
	private bool ParseFragmentAttribute() { }

	// RVA: 0x1B5D474 Offset: 0x1B59474 VA: 0x1B5D474
	private bool ParseAttributeValueChunk() { }

	// RVA: 0x1B5CC30 Offset: 0x1B58C30 VA: 0x1B5CC30
	private void ParseXmlDeclarationFragment() { }

	// RVA: 0x1B62F14 Offset: 0x1B5EF14 VA: 0x1B62F14
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x1B62D00 Offset: 0x1B5ED00 VA: 0x1B62D00
	private void ThrowUnexpectedToken(string expectedToken1) { }

	// RVA: 0x1B631C4 Offset: 0x1B5F1C4 VA: 0x1B631C4
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x1B62D2C Offset: 0x1B5ED2C VA: 0x1B62D2C
	private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2) { }

	// RVA: 0x1B631BC Offset: 0x1B5F1BC VA: 0x1B631BC
	private string ParseUnexpectedToken(int pos) { }

	// RVA: 0x1B6A84C Offset: 0x1B6684C VA: 0x1B6A84C
	private string ParseUnexpectedToken() { }

	// RVA: 0x1B65DBC Offset: 0x1B61DBC VA: 0x1B65DBC
	private void ThrowExpectingWhitespace(int pos) { }

	// RVA: 0x1B5A6A4 Offset: 0x1B566A4 VA: 0x1B5A6A4
	private int GetIndexOfAttributeWithoutPrefix(string name) { }

	// RVA: 0x1B5A78C Offset: 0x1B5678C VA: 0x1B5A78C
	private int GetIndexOfAttributeWithPrefix(string name) { }

	// RVA: 0x1B67614 Offset: 0x1B63614 VA: 0x1B67614
	private bool ZeroEndingStream(int pos) { }

	// RVA: 0x1B620E0 Offset: 0x1B5E0E0 VA: 0x1B620E0
	private void ParseDtdFromParserContext() { }

	// RVA: 0x1B67690 Offset: 0x1B63690 VA: 0x1B67690
	private bool MoveToNextContentNode(bool moveIfOnContentNode) { }

	// RVA: 0x1B589E4 Offset: 0x1B549E4 VA: 0x1B589E4
	private void SetupFromParserContext(XmlParserContext context, XmlReaderSettings settings) { }

	// RVA: 0x1B6A914 Offset: 0x1B66914 VA: 0x1B6A914 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x1B6A91C Offset: 0x1B6691C VA: 0x1B6A91C
	internal void SetDtdInfo(IDtdInfo newDtdInfo) { }

	// RVA: 0x1B6AA60 Offset: 0x1B66A60 VA: 0x1B6AA60
	internal void set_ValidationEventHandling(IValidationEventHandling value) { }

	// RVA: 0x1B6AA70 Offset: 0x1B66A70 VA: 0x1B6AA70
	internal void set_OnDefaultAttributeUse(XmlTextReaderImpl.OnDefaultAttributeUseDelegate value) { }

	// RVA: 0x1B6AA80 Offset: 0x1B66A80 VA: 0x1B6AA80
	internal void set_XmlValidatingReaderCompatibilityMode(bool value) { }

	// RVA: 0x1B6AB58 Offset: 0x1B66B58 VA: 0x1B6AB58
	internal XmlNodeType get_FragmentType() { }

	// RVA: 0x1B6AB60 Offset: 0x1B66B60 VA: 0x1B6AB60
	internal void ChangeCurrentNodeType(XmlNodeType newNodeType) { }

	// RVA: 0x1B6AB78 Offset: 0x1B66B78 VA: 0x1B6AB78
	internal XmlResolver GetResolver() { }

	// RVA: 0x1B6ABB8 Offset: 0x1B66BB8 VA: 0x1B6ABB8
	internal void set_InternalSchemaType(object value) { }

	// RVA: 0x1B6ABD0 Offset: 0x1B66BD0 VA: 0x1B6ABD0
	internal object get_InternalTypedValue() { }

	// RVA: 0x1B6ABE8 Offset: 0x1B66BE8 VA: 0x1B6ABE8
	internal void set_InternalTypedValue(object value) { }

	// RVA: 0x1B6AC00 Offset: 0x1B66C00 VA: 0x1B6AC00
	internal bool get_StandAlone() { }

	// RVA: 0x1B6AC08 Offset: 0x1B66C08 VA: 0x1B6AC08 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1B6AC10 Offset: 0x1B66C10 VA: 0x1B6AC10
	internal bool get_V1Compat() { }

	// RVA: 0x1B654B0 Offset: 0x1B614B0 VA: 0x1B654B0
	private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, XmlTextReaderImpl.NodeData[] nameSortedNodeData) { }

	// RVA: 0x1B6AE78 Offset: 0x1B66E78 VA: 0x1B6AE78
	internal bool AddDefaultAttributeNonDtd(SchemaAttDef attrDef) { }

	// RVA: 0x1B6AC18 Offset: 0x1B66C18 VA: 0x1B6AC18
	private XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute) { }

	// RVA: 0x1B6B088 Offset: 0x1B67088 VA: 0x1B6B088
	internal void set_DisableUndeclaredEntityCheck(bool value) { }

	// RVA: 0x1B59D70 Offset: 0x1B55D70 VA: 0x1B59D70
	private bool UriEqual(Uri uri1, string uri1Str, string uri2Str, XmlResolver resolver) { }

	// RVA: 0x1B610E4 Offset: 0x1B5D0E4 VA: 0x1B610E4
	private void RegisterConsumedCharacters(long characters, bool inEntityReference) { }

	// RVA: 0x1B6B090 Offset: 0x1B67090 VA: 0x1B6B090
	internal static string StripSpaces(string value) { }

	// RVA: 0x1B6B2A8 Offset: 0x1B672A8 VA: 0x1B6B2A8
	internal static void StripSpaces(char[] value, int index, ref int len) { }

	// RVA: 0x1B5EB18 Offset: 0x1B5AB18 VA: 0x1B5EB18
	internal static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0x1B62984 Offset: 0x1B5E984 VA: 0x1B62984
	internal static void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count) { }
}

// Namespace: System.Xml
public enum Formatting // TypeDefIndex: 3142
{
	// Fields
	public int value__; // 0x0
	public const Formatting None = 0;
	public const Formatting Indented = 1;
}

// Namespace: 
private enum XmlTextWriter.NamespaceState // TypeDefIndex: 3143
{
	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.NamespaceState Uninitialized = 0;
	public const XmlTextWriter.NamespaceState NotDeclaredButInScope = 1;
	public const XmlTextWriter.NamespaceState DeclaredButNotWrittenOut = 2;
	public const XmlTextWriter.NamespaceState DeclaredAndWrittenOut = 3;
}

// Namespace: 
private struct XmlTextWriter.TagInfo // TypeDefIndex: 3144
{
	// Fields
	internal string name; // 0x0
	internal string prefix; // 0x8
	internal string defaultNs; // 0x10
	internal XmlTextWriter.NamespaceState defaultNsState; // 0x18
	internal XmlSpace xmlSpace; // 0x1C
	internal string xmlLang; // 0x20
	internal int prevNsTop; // 0x28
	internal int prefixCount; // 0x2C
	internal bool mixed; // 0x30

	// Methods

	// RVA: 0x1C27EB0 Offset: 0x1C23EB0 VA: 0x1C27EB0
	internal void Init(int nsTop) { }
}

// Namespace: 
private struct XmlTextWriter.Namespace // TypeDefIndex: 3145
{
	// Fields
	internal string prefix; // 0x0
	internal string ns; // 0x8
	internal bool declared; // 0x10
	internal int prevNsIndex; // 0x14

	// Methods

	// RVA: 0x1C2C698 Offset: 0x1C28698 VA: 0x1C2C698
	internal void Set(string prefix, string ns, bool declared) { }
}

// Namespace: 
private enum XmlTextWriter.SpecialAttr // TypeDefIndex: 3146
{
	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.SpecialAttr None = 0;
	public const XmlTextWriter.SpecialAttr XmlSpace = 1;
	public const XmlTextWriter.SpecialAttr XmlLang = 2;
	public const XmlTextWriter.SpecialAttr XmlNs = 3;
}

// Namespace: 
private enum XmlTextWriter.State // TypeDefIndex: 3147
{
	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.State Start = 0;
	public const XmlTextWriter.State Prolog = 1;
	public const XmlTextWriter.State PostDTD = 2;
	public const XmlTextWriter.State Element = 3;
	public const XmlTextWriter.State Attribute = 4;
	public const XmlTextWriter.State Content = 5;
	public const XmlTextWriter.State AttrOnly = 6;
	public const XmlTextWriter.State Epilog = 7;
	public const XmlTextWriter.State Error = 8;
	public const XmlTextWriter.State Closed = 9;
}

// Namespace: 
private enum XmlTextWriter.Token // TypeDefIndex: 3148
{
	// Fields
	public int value__; // 0x0
	public const XmlTextWriter.Token PI = 0;
	public const XmlTextWriter.Token Doctype = 1;
	public const XmlTextWriter.Token Comment = 2;
	public const XmlTextWriter.Token CData = 3;
	public const XmlTextWriter.Token StartElement = 4;
	public const XmlTextWriter.Token EndElement = 5;
	public const XmlTextWriter.Token LongEndElement = 6;
	public const XmlTextWriter.Token StartAttribute = 7;
	public const XmlTextWriter.Token EndAttribute = 8;
	public const XmlTextWriter.Token Content = 9;
	public const XmlTextWriter.Token Base64 = 10;
	public const XmlTextWriter.Token RawData = 11;
	public const XmlTextWriter.Token Whitespace = 12;
	public const XmlTextWriter.Token Empty = 13;
}

// Namespace: System.Xml
[EditorBrowsable(1)]
public class XmlTextWriter : XmlWriter // TypeDefIndex: 3149
{
	// Fields
	private TextWriter textWriter; // 0x18
	private XmlTextEncoder xmlEncoder; // 0x20
	private Encoding encoding; // 0x28
	private Formatting formatting; // 0x30
	private bool indented; // 0x34
	private int indentation; // 0x38
	private char indentChar; // 0x3C
	private XmlTextWriter.TagInfo[] stack; // 0x40
	private int top; // 0x48
	private XmlTextWriter.State[] stateTable; // 0x50
	private XmlTextWriter.State currentState; // 0x58
	private XmlTextWriter.Token lastToken; // 0x5C
	private XmlTextWriterBase64Encoder base64Encoder; // 0x60
	private char quoteChar; // 0x68
	private char curQuoteChar; // 0x6A
	private bool namespaces; // 0x6C
	private XmlTextWriter.SpecialAttr specialAttr; // 0x70
	private string prefixForXmlNs; // 0x78
	private bool flush; // 0x80
	private XmlTextWriter.Namespace[] nsStack; // 0x88
	private int nsTop; // 0x90
	private Dictionary<string, int> nsHashtable; // 0x98
	private bool useNsHashtable; // 0xA0
	private XmlCharType xmlCharType; // 0xA8
	private static string[] stateName; // 0x0
	private static string[] tokenName; // 0x8
	private static readonly XmlTextWriter.State[] stateTableDefault; // 0x10
	private static readonly XmlTextWriter.State[] stateTableDocument; // 0x18

	// Properties
	public Stream BaseStream { get; }
	public bool Namespaces { set; }
	public Formatting Formatting { set; }
	public char QuoteChar { set; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x1C27D54 Offset: 0x1C23D54 VA: 0x1C27D54
	internal void .ctor() { }

	// RVA: 0x1C27F14 Offset: 0x1C23F14 VA: 0x1C27F14
	public void .ctor(Stream w, Encoding encoding) { }

	// RVA: 0x1C28020 Offset: 0x1C24020 VA: 0x1C28020
	public void .ctor(string filename, Encoding encoding) { }

	// RVA: 0x1C280A0 Offset: 0x1C240A0 VA: 0x1C280A0
	public void .ctor(TextWriter w) { }

	// RVA: 0x1C28160 Offset: 0x1C24160 VA: 0x1C28160
	public Stream get_BaseStream() { }

	// RVA: 0x1C281EC Offset: 0x1C241EC VA: 0x1C281EC
	public void set_Namespaces(bool value) { }

	// RVA: 0x1C28258 Offset: 0x1C24258 VA: 0x1C28258
	public void set_Formatting(Formatting value) { }

	// RVA: 0x1C2826C Offset: 0x1C2426C VA: 0x1C2826C
	public void set_QuoteChar(char value) { }

	// RVA: 0x1C282F8 Offset: 0x1C242F8 VA: 0x1C282F8 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1C28684 Offset: 0x1C24684 VA: 0x1C28684 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1C28698 Offset: 0x1C24698 VA: 0x1C28698 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1C288B0 Offset: 0x1C248B0 VA: 0x1C288B0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1C293BC Offset: 0x1C253BC VA: 0x1C293BC Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C29E70 Offset: 0x1C25E70 VA: 0x1C29E70 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1C2A154 Offset: 0x1C26154 VA: 0x1C2A154 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1C2A15C Offset: 0x1C2615C VA: 0x1C2A15C Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1C2AA70 Offset: 0x1C26A70 VA: 0x1C2AA70 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1C2AB10 Offset: 0x1C26B10 VA: 0x1C2AB10 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1C2ACD4 Offset: 0x1C26CD4 VA: 0x1C2ACD4 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1C2AED4 Offset: 0x1C26ED4 VA: 0x1C2AED4 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1C2B200 Offset: 0x1C27200 VA: 0x1C2B200 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1C2B2CC Offset: 0x1C272CC VA: 0x1C2B2CC Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1C2B38C Offset: 0x1C2738C VA: 0x1C2B38C Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1C2B4D8 Offset: 0x1C274D8 VA: 0x1C2B4D8 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1C2B5A4 Offset: 0x1C275A4 VA: 0x1C2B5A4 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1C2B66C Offset: 0x1C2766C VA: 0x1C2B66C Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1C2B744 Offset: 0x1C27744 VA: 0x1C2B744 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1C2B81C Offset: 0x1C2781C VA: 0x1C2B81C Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1C2B8DC Offset: 0x1C278DC VA: 0x1C2B8DC Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1C2BA34 Offset: 0x1C27A34 VA: 0x1C2BA34 Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1C2BB04 Offset: 0x1C27B04 VA: 0x1C2BB04 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1C2BB28 Offset: 0x1C27B28 VA: 0x1C2BB28 Slot: 28
	public override void Close() { }

	// RVA: 0x1C2BC54 Offset: 0x1C27C54 VA: 0x1C2BC54 Slot: 29
	public override void Flush() { }

	// RVA: 0x1C2BC70 Offset: 0x1C27C70 VA: 0x1C2BC70 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1C28300 Offset: 0x1C24300 VA: 0x1C28300
	private void StartDocument(int standalone) { }

	// RVA: 0x1C28E9C Offset: 0x1C24E9C VA: 0x1C28E9C
	private void AutoComplete(XmlTextWriter.Token token) { }

	// RVA: 0x1C2885C Offset: 0x1C2485C VA: 0x1C2885C
	private void AutoCompleteAll() { }

	// RVA: 0x1C29E78 Offset: 0x1C25E78 VA: 0x1C29E78
	private void InternalWriteEndElement(bool longFormat) { }

	// RVA: 0x1C2BE68 Offset: 0x1C27E68 VA: 0x1C2BE68
	private void WriteEndStartTag(bool empty) { }

	// RVA: 0x1C2BE1C Offset: 0x1C27E1C VA: 0x1C2BE1C
	private void WriteEndAttributeQuote() { }

	// RVA: 0x1C2BD4C Offset: 0x1C27D4C VA: 0x1C2BD4C
	private void Indent(bool beforeEndElement) { }

	// RVA: 0x1C29AAC Offset: 0x1C25AAC VA: 0x1C29AAC
	private void PushNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1C2C4C4 Offset: 0x1C284C4 VA: 0x1C2C4C4
	private void AddNamespace(string prefix, string ns, bool declared) { }

	// RVA: 0x1C2C6DC Offset: 0x1C286DC VA: 0x1C2C6DC
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x1C2C1D0 Offset: 0x1C281D0 VA: 0x1C2C1D0
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x1C2A95C Offset: 0x1C2695C VA: 0x1C2A95C
	private string GeneratePrefix() { }

	// RVA: 0x1C2B104 Offset: 0x1C27104 VA: 0x1C2B104
	private void InternalWriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1C29908 Offset: 0x1C25908 VA: 0x1C29908
	private int LookupNamespace(string prefix) { }

	// RVA: 0x1C2A828 Offset: 0x1C26828 VA: 0x1C2A828
	private int LookupNamespaceInCurrentScope(string prefix) { }

	// RVA: 0x1C299E4 Offset: 0x1C259E4 VA: 0x1C299E4
	private string FindPrefix(string ns) { }

	// RVA: 0x1C28CD4 Offset: 0x1C24CD4 VA: 0x1C28CD4
	private void ValidateName(string name, bool isNCName) { }

	// RVA: 0x1C2C2A8 Offset: 0x1C282A8 VA: 0x1C2C2A8
	private void HandleSpecialAttribute() { }

	// RVA: 0x1C29D10 Offset: 0x1C25D10 VA: 0x1C29D10
	private void VerifyPrefixXml(string prefix, string ns) { }

	// RVA: 0x1C29824 Offset: 0x1C25824 VA: 0x1C29824
	private void PushStack() { }

	// RVA: 0x1C2C1AC Offset: 0x1C281AC VA: 0x1C2C1AC
	private void FlushEncoders() { }

	// RVA: 0x1C2C7C4 Offset: 0x1C287C4 VA: 0x1C2C7C4
	private static void .cctor() { }
}

// Namespace: System.Xml
internal class XmlUtf8RawTextWriter : XmlRawWriter // TypeDefIndex: 3150
{
	// Fields
	private readonly bool useAsync; // 0x28
	protected byte[] bufBytes; // 0x30
	protected Stream stream; // 0x38
	protected Encoding encoding; // 0x40
	protected XmlCharType xmlCharType; // 0x48
	protected int bufPos; // 0x50
	protected int textPos; // 0x54
	protected int contentPos; // 0x58
	protected int cdataPos; // 0x5C
	protected int attrEndPos; // 0x60
	protected int bufLen; // 0x64
	protected bool writeToNull; // 0x68
	protected bool hadDoubleBracket; // 0x69
	protected bool inAttributeValue; // 0x6A
	protected NewLineHandling newLineHandling; // 0x6C
	protected bool closeOutput; // 0x70
	protected bool omitXmlDeclaration; // 0x71
	protected string newLineChars; // 0x78
	protected bool checkCharacters; // 0x80
	protected XmlStandalone standalone; // 0x84
	protected XmlOutputMethod outputMethod; // 0x88
	protected bool autoXmlDeclaration; // 0x8C
	protected bool mergeCDataSections; // 0x8D

	// Properties
	internal override bool SupportsNamespaceDeclarationInChunks { get; }

	// Methods

	// RVA: 0x1C2CDD0 Offset: 0x1C28DD0 VA: 0x1C2CDD0
	protected void .ctor(XmlWriterSettings settings) { }

	// RVA: 0x1C2D208 Offset: 0x1C29208 VA: 0x1C2D208
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1C2D370 Offset: 0x1C29370 VA: 0x1C2D370 Slot: 36
	internal override void WriteXmlDeclaration(XmlStandalone standalone) { }

	// RVA: 0x1C2D500 Offset: 0x1C29500 VA: 0x1C2D500 Slot: 37
	internal override void WriteXmlDeclaration(string xmldecl) { }

	// RVA: 0x1C2D578 Offset: 0x1C29578 VA: 0x1C2D578 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1C2D768 Offset: 0x1C29768 VA: 0x1C2D768 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C2D80C Offset: 0x1C2980C VA: 0x1C2D80C Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1C2D854 Offset: 0x1C29854 VA: 0x1C2D854 Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C2D9AC Offset: 0x1C299AC VA: 0x1C2D9AC Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C2DAA0 Offset: 0x1C29AA0 VA: 0x1C2DAA0 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1C2DBAC Offset: 0x1C29BAC VA: 0x1C2DBAC Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1C2DBF8 Offset: 0x1C29BF8 VA: 0x1C2DBF8 Slot: 42
	internal override void WriteNamespaceDeclaration(string prefix, string namespaceName) { }

	// RVA: 0x1C2DC4C Offset: 0x1C29C4C VA: 0x1C2DC4C Slot: 43
	internal override bool get_SupportsNamespaceDeclarationInChunks() { }

	// RVA: 0x1C2DC54 Offset: 0x1C29C54 VA: 0x1C2DC54 Slot: 44
	internal override void WriteStartNamespaceDeclaration(string prefix) { }

	// RVA: 0x1C2DD48 Offset: 0x1C29D48 VA: 0x1C2DD48 Slot: 45
	internal override void WriteEndNamespaceDeclaration() { }

	// RVA: 0x1C2DD94 Offset: 0x1C29D94 VA: 0x1C2DD94 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1C2E328 Offset: 0x1C2A328 VA: 0x1C2E328 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1C2E79C Offset: 0x1C2A79C VA: 0x1C2E79C Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1C2E8C4 Offset: 0x1C2A8C4 VA: 0x1C2E8C4 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1C2E964 Offset: 0x1C2A964 VA: 0x1C2E964 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1C2EB30 Offset: 0x1C2AB30 VA: 0x1C2EB30 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1C2F134 Offset: 0x1C2B134 VA: 0x1C2F134 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1C2F184 Offset: 0x1C2B184 VA: 0x1C2F184 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1C2F2D4 Offset: 0x1C2B2D4 VA: 0x1C2F2D4 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1C2F314 Offset: 0x1C2B314 VA: 0x1C2F314 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1C2F58C Offset: 0x1C2B58C VA: 0x1C2F58C Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1C2F5D4 Offset: 0x1C2B5D4 VA: 0x1C2F5D4 Slot: 28
	public override void Close() { }

	// RVA: 0x1C2F6C8 Offset: 0x1C2B6C8 VA: 0x1C2F6C8 Slot: 29
	public override void Flush() { }

	// RVA: 0x1C2F704 Offset: 0x1C2B704 VA: 0x1C2F704 Slot: 48
	protected virtual void FlushBuffer() { }

	// RVA: 0x1C2F6C4 Offset: 0x1C2B6C4 VA: 0x1C2F6C4
	private void FlushEncoder() { }

	// RVA: 0x1C2EB80 Offset: 0x1C2AB80 VA: 0x1C2EB80
	protected void WriteAttributeTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1C2EE88 Offset: 0x1C2AE88 VA: 0x1C2EE88
	protected void WriteElementTextBlock(char* pSrc, char* pSrcEnd) { }

	// RVA: 0x1C2D4C4 Offset: 0x1C294C4 VA: 0x1C2D4C4
	protected void RawText(string s) { }

	// RVA: 0x1C2FC18 Offset: 0x1C2BC18 VA: 0x1C2FC18
	protected void RawText(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x1C2F354 Offset: 0x1C2B354 VA: 0x1C2F354
	protected void WriteRawWithCharChecking(char* pSrcBegin, char* pSrcEnd) { }

	// RVA: 0x1C2E480 Offset: 0x1C2A480 VA: 0x1C2E480
	protected void WriteCommentOrPi(string text, int stopChar) { }

	// RVA: 0x1C2DFF0 Offset: 0x1C29FF0 VA: 0x1C2DFF0
	protected void WriteCDataSection(string text) { }

	// RVA: 0x1C2FDD8 Offset: 0x1C2BDD8 VA: 0x1C2FDD8
	private static bool IsSurrogateByte(byte b) { }

	// RVA: 0x1C2F944 Offset: 0x1C2B944 VA: 0x1C2F944
	private static byte* EncodeSurrogate(char* pSrc, char* pSrcEnd, byte* pDst) { }

	// RVA: 0x1C2FAD0 Offset: 0x1C2BAD0 VA: 0x1C2FAD0
	private byte* InvalidXmlChar(int ch, byte* pDst, bool entitize) { }

	// RVA: 0x1C2FEA4 Offset: 0x1C2BEA4 VA: 0x1C2FEA4
	internal void EncodeChar(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x1C2FB80 Offset: 0x1C2BB80 VA: 0x1C2FB80
	internal static byte* EncodeMultibyteUTF8(int ch, byte* pDst) { }

	// RVA: 0x1C2FF7C Offset: 0x1C2BF7C VA: 0x1C2FF7C
	internal static void CharToUTF8(ref char* pSrc, char* pSrcEnd, ref byte* pDst) { }

	// RVA: 0x1C2FBC4 Offset: 0x1C2BBC4 VA: 0x1C2FBC4
	protected byte* WriteNewLine(byte* pDst) { }

	// RVA: 0x1C2F8B4 Offset: 0x1C2B8B4 VA: 0x1C2F8B4
	protected static byte* LtEntity(byte* pDst) { }

	// RVA: 0x1C2F8C4 Offset: 0x1C2B8C4 VA: 0x1C2F8C4
	protected static byte* GtEntity(byte* pDst) { }

	// RVA: 0x1C2F898 Offset: 0x1C2B898 VA: 0x1C2F898
	protected static byte* AmpEntity(byte* pDst) { }

	// RVA: 0x1C2F8D4 Offset: 0x1C2B8D4 VA: 0x1C2F8D4
	protected static byte* QuoteEntity(byte* pDst) { }

	// RVA: 0x1C2F8F0 Offset: 0x1C2B8F0 VA: 0x1C2F8F0
	protected static byte* TabEntity(byte* pDst) { }

	// RVA: 0x1C2F928 Offset: 0x1C2B928 VA: 0x1C2F928
	protected static byte* LineFeedEntity(byte* pDst) { }

	// RVA: 0x1C2F90C Offset: 0x1C2B90C VA: 0x1C2F90C
	protected static byte* CarriageReturnEntity(byte* pDst) { }

	// RVA: 0x1C2FDE8 Offset: 0x1C2BDE8 VA: 0x1C2FDE8
	private static byte* CharEntity(byte* pDst, char ch) { }

	// RVA: 0x1C2FDB4 Offset: 0x1C2BDB4 VA: 0x1C2FDB4
	protected static byte* RawStartCData(byte* pDst) { }

	// RVA: 0x1C2FD9C Offset: 0x1C2BD9C VA: 0x1C2FD9C
	protected static byte* RawEndCData(byte* pDst) { }

	// RVA: 0x1C2CECC Offset: 0x1C28ECC VA: 0x1C2CECC
	protected void ValidateContentChars(string chars, string propertyName, bool allowOnlyWhitespace) { }
}

// Namespace: System.Xml
internal class XmlUtf8RawTextWriterIndent : XmlUtf8RawTextWriter // TypeDefIndex: 3151
{
	// Fields
	protected int indentLevel; // 0x90
	protected bool newLineOnAttributes; // 0x94
	protected string indentChars; // 0x98
	protected bool mixedContent; // 0xA0
	private BitStack mixedContentStack; // 0xA8
	protected ConformanceLevel conformanceLevel; // 0xB0

	// Methods

	// RVA: 0x1C30048 Offset: 0x1C2C048 VA: 0x1C30048
	public void .ctor(Stream stream, XmlWriterSettings settings) { }

	// RVA: 0x1C30180 Offset: 0x1C2C180 VA: 0x1C30180 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1C30228 Offset: 0x1C2C228 VA: 0x1C30228 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C30294 Offset: 0x1C2C294 VA: 0x1C30294 Slot: 38
	internal override void StartElementContent() { }

	// RVA: 0x1C302E4 Offset: 0x1C2C2E4 VA: 0x1C302E4 Slot: 39
	internal override void OnRootElement(ConformanceLevel currentConformanceLevel) { }

	// RVA: 0x1C302EC Offset: 0x1C2C2EC VA: 0x1C302EC Slot: 40
	internal override void WriteEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C30370 Offset: 0x1C2C370 VA: 0x1C30370 Slot: 41
	internal override void WriteFullEndElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C303F4 Offset: 0x1C2C3F4 VA: 0x1C303F4 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1C30430 Offset: 0x1C2C430 VA: 0x1C30430 Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1C3043C Offset: 0x1C2C43C VA: 0x1C3043C Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1C3047C Offset: 0x1C2C47C VA: 0x1C3047C Slot: 16
	public override void WriteProcessingInstruction(string target, string text) { }

	// RVA: 0x1C304C4 Offset: 0x1C2C4C4 VA: 0x1C304C4 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1C304D0 Offset: 0x1C2C4D0 VA: 0x1C304D0 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1C304DC Offset: 0x1C2C4DC VA: 0x1C304DC Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1C304E8 Offset: 0x1C2C4E8 VA: 0x1C304E8 Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1C304F4 Offset: 0x1C2C4F4 VA: 0x1C304F4 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1C30500 Offset: 0x1C2C500 VA: 0x1C30500 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1C3050C Offset: 0x1C2C50C VA: 0x1C3050C Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1C30518 Offset: 0x1C2C518 VA: 0x1C30518 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1C30524 Offset: 0x1C2C524 VA: 0x1C30524 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1C30070 Offset: 0x1C2C070 VA: 0x1C30070
	private void Init(XmlWriterSettings settings) { }

	// RVA: 0x1C301E0 Offset: 0x1C2C1E0 VA: 0x1C301E0
	private void WriteIndent() { }
}

// Namespace: System.Xml
[Obsolete("Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. https://go.microsoft.com/fwlink/?linkid=14202")]
public class XmlValidatingReader : XmlReader // TypeDefIndex: 3152
{
	// Fields
	private XmlValidatingReaderImpl impl; // 0x10

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	public bool Namespaces { get; }

	// Methods

	// RVA: 0x1C30534 Offset: 0x1C2C534 VA: 0x1C30534 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C30550 Offset: 0x1C2C550 VA: 0x1C30550 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1C3056C Offset: 0x1C2C56C VA: 0x1C3056C Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1C30588 Offset: 0x1C2C588 VA: 0x1C30588 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1C305A4 Offset: 0x1C2C5A4 VA: 0x1C305A4 Slot: 11
	public override string get_Value() { }

	// RVA: 0x1C305C0 Offset: 0x1C2C5C0 VA: 0x1C305C0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x1C305DC Offset: 0x1C2C5DC VA: 0x1C305DC Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x1C305FC Offset: 0x1C2C5FC VA: 0x1C305FC Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1C3061C Offset: 0x1C2C61C VA: 0x1C3061C Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x1C3063C Offset: 0x1C2C63C VA: 0x1C3063C Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x1C3065C Offset: 0x1C2C65C VA: 0x1C3065C Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1C3067C Offset: 0x1C2C67C VA: 0x1C3067C Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x1C3069C Offset: 0x1C2C69C VA: 0x1C3069C Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1C306BC Offset: 0x1C2C6BC VA: 0x1C306BC Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1C306DC Offset: 0x1C2C6DC VA: 0x1C306DC Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1C306FC Offset: 0x1C2C6FC VA: 0x1C306FC Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x1C3071C Offset: 0x1C2C71C VA: 0x1C3071C Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x1C3073C Offset: 0x1C2C73C VA: 0x1C3073C Slot: 31
	public override bool Read() { }

	// RVA: 0x1C3075C Offset: 0x1C2C75C VA: 0x1C3075C Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x1C3077C Offset: 0x1C2C77C VA: 0x1C3077C Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x1C3079C Offset: 0x1C2C79C VA: 0x1C3079C Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1C307BC Offset: 0x1C2C7BC VA: 0x1C307BC Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1C307F4 Offset: 0x1C2C7F4 VA: 0x1C307F4 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1C30814 Offset: 0x1C2C814 VA: 0x1C30814
	public bool get_Namespaces() { }
}

// Namespace: 
private enum XmlValidatingReaderImpl.ParsingFunction // TypeDefIndex: 3153
{
	// Fields
	public int value__; // 0x0
	public const XmlValidatingReaderImpl.ParsingFunction Read = 0;
	public const XmlValidatingReaderImpl.ParsingFunction Init = 1;
	public const XmlValidatingReaderImpl.ParsingFunction ParseDtdFromContext = 2;
	public const XmlValidatingReaderImpl.ParsingFunction ResolveEntityInternally = 3;
	public const XmlValidatingReaderImpl.ParsingFunction InReadBinaryContent = 4;
	public const XmlValidatingReaderImpl.ParsingFunction ReaderClosed = 5;
	public const XmlValidatingReaderImpl.ParsingFunction Error = 6;
	public const XmlValidatingReaderImpl.ParsingFunction None = 7;
}

// Namespace: 
internal class XmlValidatingReaderImpl.ValidationEventHandling : IValidationEventHandling // TypeDefIndex: 3154
{
	// Fields
	private XmlValidatingReaderImpl reader; // 0x10
	private ValidationEventHandler eventHandler; // 0x18

	// Properties
	private object System.Xml.IValidationEventHandling.EventHandler { get; }

	// Methods

	// RVA: 0x1C30D50 Offset: 0x1C2CD50 VA: 0x1C30D50
	internal void .ctor(XmlValidatingReaderImpl reader) { }

	// RVA: 0x1C31F38 Offset: 0x1C2DF38 VA: 0x1C31F38 Slot: 4
	private object System.Xml.IValidationEventHandling.get_EventHandler() { }

	// RVA: 0x1C31F40 Offset: 0x1C2DF40 VA: 0x1C31F40 Slot: 5
	private void System.Xml.IValidationEventHandling.SendEvent(Exception exception, XmlSeverityType severity) { }

	// RVA: 0x1C30D80 Offset: 0x1C2CD80 VA: 0x1C30D80
	internal void AddHandler(ValidationEventHandler handler) { }
}

// Namespace: System.Xml
internal sealed class XmlValidatingReaderImpl : XmlReader, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 3155
{
	// Fields
	private XmlReader coreReader; // 0x10
	private XmlTextReaderImpl coreReaderImpl; // 0x18
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x20
	private ValidationType validationType; // 0x28
	private BaseValidator validator; // 0x30
	private XmlSchemaCollection schemaCollection; // 0x38
	private bool processIdentityConstraints; // 0x40
	private XmlValidatingReaderImpl.ParsingFunction parsingFunction; // 0x44
	private XmlValidatingReaderImpl.ValidationEventHandling eventHandling; // 0x48
	private XmlParserContext parserContext; // 0x50
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x58
	private XmlReader outerReader; // 0x60
	private static XmlResolver s_tempResolver; // 0x0

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override ReadState ReadState { get; }
	public override bool EOF { get; }
	public override XmlNameTable NameTable { get; }
	public override int AttributeCount { get; }
	public override bool CanResolveEntity { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	internal ValidationType ValidationType { get; }
	internal XmlSchemaCollection Schemas { get; }
	internal bool Namespaces { get; }
	internal BaseValidator Validator { get; set; }
	internal override XmlNamespaceManager NamespaceManager { get; }
	internal bool StandAlone { get; }
	internal object SchemaTypeObject { set; }
	internal object TypedValueObject { get; set; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x1C30850 Offset: 0x1C2C850 VA: 0x1C30850
	internal void .ctor(XmlReader reader, ValidationEventHandler settingsEventHandler, bool processIdentityConstraints) { }

	// RVA: 0x1C30F90 Offset: 0x1C2CF90 VA: 0x1C30F90 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1C31060 Offset: 0x1C2D060 VA: 0x1C31060 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C3107C Offset: 0x1C2D07C VA: 0x1C3107C Slot: 7
	public override string get_Name() { }

	// RVA: 0x1C31098 Offset: 0x1C2D098 VA: 0x1C31098 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1C310B4 Offset: 0x1C2D0B4 VA: 0x1C310B4 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1C310D0 Offset: 0x1C2D0D0 VA: 0x1C310D0 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1C310EC Offset: 0x1C2D0EC VA: 0x1C310EC Slot: 11
	public override string get_Value() { }

	// RVA: 0x1C31108 Offset: 0x1C2D108 VA: 0x1C31108 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x1C31124 Offset: 0x1C2D124 VA: 0x1C31124 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x1C31144 Offset: 0x1C2D144 VA: 0x1C31144 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1C31164 Offset: 0x1C2D164 VA: 0x1C31164 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1C31184 Offset: 0x1C2D184 VA: 0x1C31184 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x1C311A4 Offset: 0x1C2D1A4 VA: 0x1C311A4 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1C311C4 Offset: 0x1C2D1C4 VA: 0x1C311C4 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x1C311E4 Offset: 0x1C2D1E4 VA: 0x1C311E4 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x1C31218 Offset: 0x1C2D218 VA: 0x1C31218 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x1C31238 Offset: 0x1C2D238 VA: 0x1C31238 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1C31258 Offset: 0x1C2D258 VA: 0x1C31258 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x1C31278 Offset: 0x1C2D278 VA: 0x1C31278 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x1C31298 Offset: 0x1C2D298 VA: 0x1C31298 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1C312B8 Offset: 0x1C2D2B8 VA: 0x1C312B8 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x1C312D8 Offset: 0x1C2D2D8 VA: 0x1C312D8 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1C31310 Offset: 0x1C2D310 VA: 0x1C31310 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1C31340 Offset: 0x1C2D340 VA: 0x1C31340 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1C31378 Offset: 0x1C2D378 VA: 0x1C31378 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1C313B0 Offset: 0x1C2D3B0 VA: 0x1C313B0 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x1C313E8 Offset: 0x1C2D3E8 VA: 0x1C313E8 Slot: 31
	public override bool Read() { }

	// RVA: 0x1C317B8 Offset: 0x1C2D7B8 VA: 0x1C317B8 Slot: 33
	public override void Close() { }

	// RVA: 0x1C317EC Offset: 0x1C2D7EC VA: 0x1C317EC Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1C3180C Offset: 0x1C2D80C VA: 0x1C3180C Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x1C31864 Offset: 0x1C2D864 VA: 0x1C31864 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1C3186C Offset: 0x1C2D86C VA: 0x1C3186C Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1C3189C Offset: 0x1C2D89C VA: 0x1C3189C
	internal void MoveOffEntityReference() { }

	// RVA: 0x1C3194C Offset: 0x1C2D94C VA: 0x1C3194C Slot: 42
	public override string ReadString() { }

	// RVA: 0x1C31968 Offset: 0x1C2D968 VA: 0x1C31968 Slot: 53
	public bool HasLineInfo() { }

	// RVA: 0x1C31970 Offset: 0x1C2D970 VA: 0x1C31970 Slot: 54
	public int get_LineNumber() { }

	// RVA: 0x1C31A58 Offset: 0x1C2DA58 VA: 0x1C31A58 Slot: 55
	public int get_LinePosition() { }

	// RVA: 0x1C31B40 Offset: 0x1C2DB40 VA: 0x1C31B40 Slot: 56
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1C31BEC Offset: 0x1C2DBEC VA: 0x1C31BEC Slot: 57
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1C31BFC Offset: 0x1C2DBFC VA: 0x1C31BFC Slot: 58
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1C31B44 Offset: 0x1C2DB44 VA: 0x1C31B44
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1C31C00 Offset: 0x1C2DC00 VA: 0x1C31C00
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x1C31CAC Offset: 0x1C2DCAC VA: 0x1C31CAC
	internal ValidationType get_ValidationType() { }

	// RVA: 0x1C31CB4 Offset: 0x1C2DCB4 VA: 0x1C31CB4
	internal XmlSchemaCollection get_Schemas() { }

	// RVA: 0x1C30838 Offset: 0x1C2C838 VA: 0x1C30838
	internal bool get_Namespaces() { }

	// RVA: 0x1C315BC Offset: 0x1C2D5BC VA: 0x1C315BC
	private void ParseDtdFromParserContext() { }

	// RVA: 0x1C31CBC Offset: 0x1C2DCBC VA: 0x1C31CBC
	private void ValidateDtd() { }

	// RVA: 0x1C31730 Offset: 0x1C2D730 VA: 0x1C31730
	private void ResolveEntityInternally() { }

	// RVA: 0x1C30E10 Offset: 0x1C2CE10 VA: 0x1C30E10
	private void SetupValidation(ValidationType valType) { }

	// RVA: 0x1C30C6C Offset: 0x1C2CC6C VA: 0x1C30C6C
	private XmlResolver GetResolver() { }

	// RVA: 0x1C314D0 Offset: 0x1C2D4D0 VA: 0x1C314D0
	private void ProcessCoreReaderEvent() { }

	// RVA: 0x1C31D38 Offset: 0x1C2DD38 VA: 0x1C31D38
	internal BaseValidator get_Validator() { }

	// RVA: 0x1C31D40 Offset: 0x1C2DD40 VA: 0x1C31D40
	internal void set_Validator(BaseValidator value) { }

	// RVA: 0x1C31D48 Offset: 0x1C2DD48 VA: 0x1C31D48 Slot: 51
	internal override XmlNamespaceManager get_NamespaceManager() { }

	// RVA: 0x1C31D68 Offset: 0x1C2DD68 VA: 0x1C31D68
	internal bool get_StandAlone() { }

	// RVA: 0x1C31D80 Offset: 0x1C2DD80 VA: 0x1C31D80
	internal void set_SchemaTypeObject(object value) { }

	// RVA: 0x1C31D98 Offset: 0x1C2DD98 VA: 0x1C31D98
	internal object get_TypedValueObject() { }

	// RVA: 0x1C31DB0 Offset: 0x1C2DDB0 VA: 0x1C31DB0
	internal void set_TypedValueObject(object value) { }

	// RVA: 0x1C31DC8 Offset: 0x1C2DDC8 VA: 0x1C31DC8
	internal bool AddDefaultAttribute(SchemaAttDef attdef) { }

	// RVA: 0x1C31DE0 Offset: 0x1C2DDE0 VA: 0x1C31DE0 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }

	// RVA: 0x1C31E00 Offset: 0x1C2DE00 VA: 0x1C31E00
	internal void ValidateDefaultAttributeOnUse(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader) { }
}

// Namespace: 
private enum XmlWellFormedWriter.State // TypeDefIndex: 3156
{
	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.State Start = 0;
	public const XmlWellFormedWriter.State TopLevel = 1;
	public const XmlWellFormedWriter.State Document = 2;
	public const XmlWellFormedWriter.State Element = 3;
	public const XmlWellFormedWriter.State Content = 4;
	public const XmlWellFormedWriter.State B64Content = 5;
	public const XmlWellFormedWriter.State B64Attribute = 6;
	public const XmlWellFormedWriter.State AfterRootEle = 7;
	public const XmlWellFormedWriter.State Attribute = 8;
	public const XmlWellFormedWriter.State SpecialAttr = 9;
	public const XmlWellFormedWriter.State EndDocument = 10;
	public const XmlWellFormedWriter.State RootLevelAttr = 11;
	public const XmlWellFormedWriter.State RootLevelSpecAttr = 12;
	public const XmlWellFormedWriter.State RootLevelB64Attr = 13;
	public const XmlWellFormedWriter.State AfterRootLevelAttr = 14;
	public const XmlWellFormedWriter.State Closed = 15;
	public const XmlWellFormedWriter.State Error = 16;
	public const XmlWellFormedWriter.State StartContent = 101;
	public const XmlWellFormedWriter.State StartContentEle = 102;
	public const XmlWellFormedWriter.State StartContentB64 = 103;
	public const XmlWellFormedWriter.State StartDoc = 104;
	public const XmlWellFormedWriter.State StartDocEle = 106;
	public const XmlWellFormedWriter.State EndAttrSEle = 107;
	public const XmlWellFormedWriter.State EndAttrEEle = 108;
	public const XmlWellFormedWriter.State EndAttrSCont = 109;
	public const XmlWellFormedWriter.State EndAttrSAttr = 111;
	public const XmlWellFormedWriter.State PostB64Cont = 112;
	public const XmlWellFormedWriter.State PostB64Attr = 113;
	public const XmlWellFormedWriter.State PostB64RootAttr = 114;
	public const XmlWellFormedWriter.State StartFragEle = 115;
	public const XmlWellFormedWriter.State StartFragCont = 116;
	public const XmlWellFormedWriter.State StartFragB64 = 117;
	public const XmlWellFormedWriter.State StartRootLevelAttr = 118;
}

// Namespace: 
private enum XmlWellFormedWriter.Token // TypeDefIndex: 3157
{
	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.Token StartDocument = 0;
	public const XmlWellFormedWriter.Token EndDocument = 1;
	public const XmlWellFormedWriter.Token PI = 2;
	public const XmlWellFormedWriter.Token Comment = 3;
	public const XmlWellFormedWriter.Token Dtd = 4;
	public const XmlWellFormedWriter.Token StartElement = 5;
	public const XmlWellFormedWriter.Token EndElement = 6;
	public const XmlWellFormedWriter.Token StartAttribute = 7;
	public const XmlWellFormedWriter.Token EndAttribute = 8;
	public const XmlWellFormedWriter.Token Text = 9;
	public const XmlWellFormedWriter.Token CData = 10;
	public const XmlWellFormedWriter.Token AtomicValue = 11;
	public const XmlWellFormedWriter.Token Base64 = 12;
	public const XmlWellFormedWriter.Token RawData = 13;
	public const XmlWellFormedWriter.Token Whitespace = 14;
}

// Namespace: 
private class XmlWellFormedWriter.NamespaceResolverProxy : IXmlNamespaceResolver // TypeDefIndex: 3158
{
	// Fields
	private XmlWellFormedWriter wfWriter; // 0x10

	// Methods

	// RVA: 0x1C32594 Offset: 0x1C2E594 VA: 0x1C32594
	internal void .ctor(XmlWellFormedWriter wfWriter) { }

	// RVA: 0x1C388B4 Offset: 0x1C348B4 VA: 0x1C388B4 Slot: 4
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1C388EC Offset: 0x1C348EC VA: 0x1C388EC Slot: 5
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1C38900 Offset: 0x1C34900 VA: 0x1C38900 Slot: 6
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }
}

// Namespace: 
private struct XmlWellFormedWriter.ElementScope // TypeDefIndex: 3159
{
	// Fields
	internal int prevNSTop; // 0x0
	internal string prefix; // 0x8
	internal string localName; // 0x10
	internal string namespaceUri; // 0x18
	internal XmlSpace xmlSpace; // 0x20
	internal string xmlLang; // 0x28

	// Methods

	// RVA: 0x1C32604 Offset: 0x1C2E604 VA: 0x1C32604
	internal void Set(string prefix, string localName, string namespaceUri, int prevNSTop) { }

	// RVA: 0x1C33DB8 Offset: 0x1C2FDB8 VA: 0x1C33DB8
	internal void WriteEndElement(XmlRawWriter rawWriter) { }

	// RVA: 0x1C3409C Offset: 0x1C3009C VA: 0x1C3409C
	internal void WriteFullEndElement(XmlRawWriter rawWriter) { }
}

// Namespace: 
private enum XmlWellFormedWriter.NamespaceKind // TypeDefIndex: 3160
{
	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.NamespaceKind Written = 0;
	public const XmlWellFormedWriter.NamespaceKind NeedToWrite = 1;
	public const XmlWellFormedWriter.NamespaceKind Implied = 2;
	public const XmlWellFormedWriter.NamespaceKind Special = 3;
}

// Namespace: 
private struct XmlWellFormedWriter.Namespace // TypeDefIndex: 3161
{
	// Fields
	internal string prefix; // 0x0
	internal string namespaceUri; // 0x8
	internal XmlWellFormedWriter.NamespaceKind kind; // 0x10
	internal int prevNsIndex; // 0x14

	// Methods

	// RVA: 0x1C325C4 Offset: 0x1C2E5C4 VA: 0x1C325C4
	internal void Set(string prefix, string namespaceUri, XmlWellFormedWriter.NamespaceKind kind) { }

	// RVA: 0x1C37CF0 Offset: 0x1C33CF0 VA: 0x1C37CF0
	internal void WriteDecl(XmlWriter writer, XmlRawWriter rawWriter) { }
}

// Namespace: 
private struct XmlWellFormedWriter.AttrName // TypeDefIndex: 3162
{
	// Fields
	internal string prefix; // 0x0
	internal string namespaceUri; // 0x8
	internal string localName; // 0x10
	internal int prev; // 0x18

	// Methods

	// RVA: 0x1C38920 Offset: 0x1C34920 VA: 0x1C38920
	internal void Set(string prefix, string localName, string namespaceUri) { }

	// RVA: 0x1C3896C Offset: 0x1C3496C VA: 0x1C3896C
	internal bool IsDuplicate(string prefix, string localName, string namespaceUri) { }
}

// Namespace: 
private enum XmlWellFormedWriter.SpecialAttribute // TypeDefIndex: 3163
{
	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.SpecialAttribute No = 0;
	public const XmlWellFormedWriter.SpecialAttribute DefaultXmlns = 1;
	public const XmlWellFormedWriter.SpecialAttribute PrefixedXmlns = 2;
	public const XmlWellFormedWriter.SpecialAttribute XmlSpace = 3;
	public const XmlWellFormedWriter.SpecialAttribute XmlLang = 4;
}

// Namespace: 
private enum XmlWellFormedWriter.AttributeValueCache.ItemType // TypeDefIndex: 3164
{
	// Fields
	public int value__; // 0x0
	public const XmlWellFormedWriter.AttributeValueCache.ItemType EntityRef = 0;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType CharEntity = 1;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType SurrogateCharEntity = 2;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType Whitespace = 3;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType String = 4;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType StringChars = 5;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType Raw = 6;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType RawChars = 7;
	public const XmlWellFormedWriter.AttributeValueCache.ItemType ValueString = 8;
}

// Namespace: 
private class XmlWellFormedWriter.AttributeValueCache.Item // TypeDefIndex: 3165
{
	// Fields
	internal XmlWellFormedWriter.AttributeValueCache.ItemType type; // 0x10
	internal object data; // 0x18

	// Methods

	// RVA: 0x1C399F4 Offset: 0x1C359F4 VA: 0x1C399F4
	internal void .ctor() { }

	// RVA: 0x1C399FC Offset: 0x1C359FC VA: 0x1C399FC
	internal void Set(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data) { }
}

// Namespace: 
private class XmlWellFormedWriter.AttributeValueCache.BufferChunk // TypeDefIndex: 3166
{
	// Fields
	internal char[] buffer; // 0x10
	internal int index; // 0x18
	internal int count; // 0x1C

	// Methods

	// RVA: 0x1C3904C Offset: 0x1C3504C VA: 0x1C3904C
	internal void .ctor(char[] buffer, int index, int count) { }
}

// Namespace: 
private class XmlWellFormedWriter.AttributeValueCache // TypeDefIndex: 3167
{
	// Fields
	private StringBuilder stringValue; // 0x10
	private string singleStringValue; // 0x18
	private XmlWellFormedWriter.AttributeValueCache.Item[] items; // 0x20
	private int firstItem; // 0x28
	private int lastItem; // 0x2C

	// Properties
	internal string StringValue { get; }

	// Methods

	// RVA: 0x1C389D8 Offset: 0x1C349D8 VA: 0x1C389D8
	internal string get_StringValue() { }

	// RVA: 0x1C38A04 Offset: 0x1C34A04 VA: 0x1C38A04
	internal void WriteEntityRef(string name) { }

	// RVA: 0x1C38DA0 Offset: 0x1C34DA0 VA: 0x1C38DA0
	internal void WriteCharEntity(char ch) { }

	// RVA: 0x1C38E0C Offset: 0x1C34E0C VA: 0x1C38E0C
	internal void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1C38ED0 Offset: 0x1C34ED0 VA: 0x1C38ED0
	internal void WriteWhitespace(string ws) { }

	// RVA: 0x1C38F20 Offset: 0x1C34F20 VA: 0x1C38F20
	internal void WriteString(string text) { }

	// RVA: 0x1C38F94 Offset: 0x1C34F94 VA: 0x1C38F94
	internal void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1C39094 Offset: 0x1C35094 VA: 0x1C39094
	internal void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1C3914C Offset: 0x1C3514C VA: 0x1C3914C
	internal void WriteRaw(string data) { }

	// RVA: 0x1C3919C Offset: 0x1C3519C VA: 0x1C3919C
	internal void WriteValue(string value) { }

	// RVA: 0x1C391EC Offset: 0x1C351EC VA: 0x1C391EC
	internal void Replay(XmlWriter writer) { }

	// RVA: 0x1C39524 Offset: 0x1C35524 VA: 0x1C39524
	internal void Trim() { }

	// RVA: 0x1C399B8 Offset: 0x1C359B8 VA: 0x1C399B8
	internal void Clear() { }

	// RVA: 0x1C38BA8 Offset: 0x1C34BA8 VA: 0x1C38BA8
	private void StartComplexValue() { }

	// RVA: 0x1C38BF8 Offset: 0x1C34BF8 VA: 0x1C38BF8
	private void AddItem(XmlWellFormedWriter.AttributeValueCache.ItemType type, object data) { }

	// RVA: 0x1C39A10 Offset: 0x1C35A10 VA: 0x1C39A10
	public void .ctor() { }
}

// Namespace: System.Xml
internal class XmlWellFormedWriter : XmlWriter // TypeDefIndex: 3168
{
	// Fields
	private XmlWriter writer; // 0x18
	private XmlRawWriter rawWriter; // 0x20
	private IXmlNamespaceResolver predefinedNamespaces; // 0x28
	private XmlWellFormedWriter.Namespace[] nsStack; // 0x30
	private int nsTop; // 0x38
	private Dictionary<string, int> nsHashtable; // 0x40
	private bool useNsHashtable; // 0x48
	private XmlWellFormedWriter.ElementScope[] elemScopeStack; // 0x50
	private int elemTop; // 0x58
	private XmlWellFormedWriter.AttrName[] attrStack; // 0x60
	private int attrCount; // 0x68
	private Dictionary<string, int> attrHashTable; // 0x70
	private XmlWellFormedWriter.SpecialAttribute specAttr; // 0x78
	private XmlWellFormedWriter.AttributeValueCache attrValueCache; // 0x80
	private string curDeclPrefix; // 0x88
	private XmlWellFormedWriter.State[] stateTable; // 0x90
	private XmlWellFormedWriter.State currentState; // 0x98
	private bool checkCharacters; // 0x9C
	private bool omitDuplNamespaces; // 0x9D
	private bool writeEndDocumentOnClose; // 0x9E
	private ConformanceLevel conformanceLevel; // 0xA0
	private bool dtdWritten; // 0xA4
	private bool xmlDeclFollows; // 0xA5
	private XmlCharType xmlCharType; // 0xA8
	private SecureStringHasher hasher; // 0xB0
	internal static readonly string[] stateName; // 0x0
	internal static readonly string[] tokenName; // 0x8
	private static WriteState[] state2WriteState; // 0x10
	private static readonly XmlWellFormedWriter.State[] StateTableDocument; // 0x18
	private static readonly XmlWellFormedWriter.State[] StateTableAuto; // 0x20

	// Properties
	public override WriteState WriteState { get; }
	internal XmlRawWriter RawWriter { get; }
	private bool SaveAttrValue { get; }
	private bool InBase64 { get; }
	private bool IsClosedOrErrorState { get; }

	// Methods

	// RVA: 0x1C32054 Offset: 0x1C2E054 VA: 0x1C32054
	internal void .ctor(XmlWriter writer, XmlWriterSettings settings) { }

	// RVA: 0x1C32664 Offset: 0x1C2E664 VA: 0x1C32664 Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1C326F8 Offset: 0x1C2E6F8 VA: 0x1C326F8 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1C328B4 Offset: 0x1C2E8B4 VA: 0x1C328B4 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1C328D0 Offset: 0x1C2E8D0 VA: 0x1C328D0 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1C32D04 Offset: 0x1C2ED04 VA: 0x1C32D04 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1C331C0 Offset: 0x1C2F1C0 VA: 0x1C331C0 Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1C33BD8 Offset: 0x1C2FBD8 VA: 0x1C33BD8 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1C33EBC Offset: 0x1C2FEBC VA: 0x1C33EBC Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1C340C8 Offset: 0x1C300C8 VA: 0x1C340C8 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1C34CF8 Offset: 0x1C30CF8 VA: 0x1C34CF8 Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1C35A4C Offset: 0x1C31A4C VA: 0x1C35A4C Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1C35B30 Offset: 0x1C31B30 VA: 0x1C35B30 Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1C35C14 Offset: 0x1C31C14 VA: 0x1C35C14 Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1C35EA4 Offset: 0x1C31EA4 VA: 0x1C35EA4 Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1C36018 Offset: 0x1C32018 VA: 0x1C36018 Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1C36198 Offset: 0x1C32198 VA: 0x1C36198 Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1C3631C Offset: 0x1C3231C VA: 0x1C3631C Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1C364D0 Offset: 0x1C324D0 VA: 0x1C364D0 Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1C365C4 Offset: 0x1C325C4 VA: 0x1C365C4 Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1C36824 Offset: 0x1C32824 VA: 0x1C36824 Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1C36A84 Offset: 0x1C32A84 VA: 0x1C36A84 Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1C36B78 Offset: 0x1C32B78 VA: 0x1C36B78 Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1C36DA8 Offset: 0x1C32DA8 VA: 0x1C36DA8 Slot: 28
	public override void Close() { }

	// RVA: 0x1C36F9C Offset: 0x1C32F9C VA: 0x1C36F9C Slot: 29
	public override void Flush() { }

	// RVA: 0x1C37050 Offset: 0x1C33050 VA: 0x1C37050 Slot: 30
	public override string LookupPrefix(string ns) { }

	// RVA: 0x1C372C8 Offset: 0x1C332C8 VA: 0x1C372C8 Slot: 31
	public override void WriteValue(string value) { }

	// RVA: 0x1C373CC Offset: 0x1C333CC VA: 0x1C373CC Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1C37508 Offset: 0x1C33508 VA: 0x1C37508
	internal XmlRawWriter get_RawWriter() { }

	// RVA: 0x1C36008 Offset: 0x1C32008 VA: 0x1C36008
	private bool get_SaveAttrValue() { }

	// RVA: 0x1C36F80 Offset: 0x1C32F80 VA: 0x1C36F80
	private bool get_InBase64() { }

	// RVA: 0x1C347B8 Offset: 0x1C307B8 VA: 0x1C347B8
	private void SetSpecialAttribute(XmlWellFormedWriter.SpecialAttribute special) { }

	// RVA: 0x1C32700 Offset: 0x1C2E700 VA: 0x1C32700
	private void WriteStartDocumentImpl(XmlStandalone standalone) { }

	// RVA: 0x1C37510 Offset: 0x1C33510 VA: 0x1C37510
	private void StartFragment() { }

	// RVA: 0x1C337D0 Offset: 0x1C2F7D0 VA: 0x1C337D0
	private void PushNamespaceImplicit(string prefix, string ns) { }

	// RVA: 0x1C35594 Offset: 0x1C31594 VA: 0x1C35594
	private bool PushNamespaceExplicit(string prefix, string ns) { }

	// RVA: 0x1C375F8 Offset: 0x1C335F8 VA: 0x1C375F8
	private void AddNamespace(string prefix, string ns, XmlWellFormedWriter.NamespaceKind kind) { }

	// RVA: 0x1C378C0 Offset: 0x1C338C0 VA: 0x1C378C0
	private void AddToNamespaceHashtable(int namespaceIndex) { }

	// RVA: 0x1C3751C Offset: 0x1C3351C VA: 0x1C3751C
	private int LookupNamespaceIndex(string prefix) { }

	// RVA: 0x1C33DE4 Offset: 0x1C2FDE4 VA: 0x1C33DE4
	private void PopNamespaces(int indexFrom, int indexTo) { }

	// RVA: 0x1C377B0 Offset: 0x1C337B0 VA: 0x1C377B0
	private static XmlException DupAttrException(string prefix, string localName) { }

	// RVA: 0x1C32A20 Offset: 0x1C2EA20 VA: 0x1C32A20
	private void AdvanceState(XmlWellFormedWriter.Token token) { }

	// RVA: 0x1C37C24 Offset: 0x1C33C24 VA: 0x1C37C24
	private void StartElementContent() { }

	// RVA: 0x1C379A8 Offset: 0x1C339A8 VA: 0x1C379A8
	private static string GetStateName(XmlWellFormedWriter.State state) { }

	// RVA: 0x1C33698 Offset: 0x1C2F698 VA: 0x1C33698
	internal string LookupNamespace(string prefix) { }

	// RVA: 0x1C3498C Offset: 0x1C3098C VA: 0x1C3498C
	private string LookupLocalNamespace(string prefix) { }

	// RVA: 0x1C34858 Offset: 0x1C30858 VA: 0x1C34858
	private string GeneratePrefix() { }

	// RVA: 0x1C33598 Offset: 0x1C2F598 VA: 0x1C33598
	private void CheckNCName(string ncname) { }

	// RVA: 0x1C37E20 Offset: 0x1C33E20 VA: 0x1C37E20
	private static Exception InvalidCharsException(string name, int badCharIndex) { }

	// RVA: 0x1C37A48 Offset: 0x1C33A48 VA: 0x1C37A48
	private void ThrowInvalidStateTransition(XmlWellFormedWriter.Token token, XmlWellFormedWriter.State currentState) { }

	// RVA: 0x1C374F8 Offset: 0x1C334F8 VA: 0x1C374F8
	private bool get_IsClosedOrErrorState() { }

	// RVA: 0x1C34A50 Offset: 0x1C30A50 VA: 0x1C34A50
	private void AddAttribute(string prefix, string localName, string namespaceName) { }

	// RVA: 0x1C37F64 Offset: 0x1C33F64 VA: 0x1C37F64
	private void AddToAttrHashTable(int attributeIndex) { }

	// RVA: 0x1C380BC Offset: 0x1C340BC VA: 0x1C380BC
	private static void .cctor() { }
}

// Namespace: System.Xml
public enum WriteState // TypeDefIndex: 3169
{
	// Fields
	public int value__; // 0x0
	public const WriteState Start = 0;
	public const WriteState Prolog = 1;
	public const WriteState Element = 2;
	public const WriteState Attribute = 3;
	public const WriteState Content = 4;
	public const WriteState Closed = 5;
	public const WriteState Error = 6;
}

// Namespace: System.Xml
public abstract class XmlWriter : IDisposable // TypeDefIndex: 3170
{
	// Fields
	private char[] writeNodeBuffer; // 0x10

	// Properties
	public abstract WriteState WriteState { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void WriteStartDocument();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void WriteStartDocument(bool standalone);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void WriteEndDocument();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void WriteDocType(string name, string pubid, string sysid, string subset);

	// RVA: 0x1C39A84 Offset: 0x1C35A84 VA: 0x1C39A84
	public void WriteStartElement(string localName, string ns) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void WriteStartElement(string prefix, string localName, string ns);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void WriteEndElement();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void WriteFullEndElement();

	// RVA: 0x1C39A9C Offset: 0x1C35A9C VA: 0x1C39A9C
	public void WriteAttributeString(string localName, string ns, string value) { }

	// RVA: 0x1C39AF8 Offset: 0x1C35AF8 VA: 0x1C39AF8
	public void WriteAttributeString(string localName, string value) { }

	// RVA: 0x1C39B54 Offset: 0x1C35B54 VA: 0x1C39B54
	public void WriteAttributeString(string prefix, string localName, string ns, string value) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void WriteStartAttribute(string prefix, string localName, string ns);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void WriteEndAttribute();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void WriteCData(string text);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void WriteComment(string text);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void WriteProcessingInstruction(string name, string text);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void WriteEntityRef(string name);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void WriteCharEntity(char ch);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void WriteWhitespace(string ws);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void WriteString(string text);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void WriteSurrogateCharEntity(char lowChar, char highChar);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract void WriteChars(char[] buffer, int index, int count);

	// RVA: -1 Offset: -1 Slot: 23
	public abstract void WriteRaw(char[] buffer, int index, int count);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void WriteRaw(string data);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void WriteBase64(byte[] buffer, int index, int count);

	// RVA: 0x1C39BA4 Offset: 0x1C35BA4 VA: 0x1C39BA4 Slot: 26
	public virtual void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract WriteState get_WriteState();

	// RVA: 0x1C39BC0 Offset: 0x1C35BC0 VA: 0x1C39BC0 Slot: 28
	public virtual void Close() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void Flush();

	// RVA: -1 Offset: -1 Slot: 30
	public abstract string LookupPrefix(string ns);

	// RVA: 0x1C39BC4 Offset: 0x1C35BC4 VA: 0x1C39BC4 Slot: 31
	public virtual void WriteValue(string value) { }

	// RVA: 0x1C39BDC Offset: 0x1C35BDC VA: 0x1C39BDC Slot: 32
	public virtual void WriteAttributes(XmlReader reader, bool defattr) { }

	// RVA: 0x1C39E58 Offset: 0x1C35E58 VA: 0x1C39E58 Slot: 33
	public virtual void WriteNode(XmlReader reader, bool defattr) { }

	// RVA: 0x1C3A30C Offset: 0x1C3630C VA: 0x1C3A30C
	public void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x1C3A370 Offset: 0x1C36370 VA: 0x1C3A370 Slot: 4
	public void Dispose() { }

	// RVA: 0x1C3A384 Offset: 0x1C36384 VA: 0x1C3A384 Slot: 34
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1C3A3C8 Offset: 0x1C363C8 VA: 0x1C3A3C8
	public static XmlWriter Create(Stream output, XmlWriterSettings settings) { }

	// RVA: 0x1C3A934 Offset: 0x1C36934 VA: 0x1C3A934
	public static XmlWriter Create(TextWriter output, XmlWriterSettings settings) { }

	// RVA: 0x1C3ACA0 Offset: 0x1C36CA0 VA: 0x1C3ACA0
	protected void .ctor() { }
}

// Namespace: System.Xml
public enum XmlOutputMethod // TypeDefIndex: 3171
{
	// Fields
	public int value__; // 0x0
	public const XmlOutputMethod Xml = 0;
	public const XmlOutputMethod Html = 1;
	public const XmlOutputMethod Text = 2;
	public const XmlOutputMethod AutoDetect = 3;
}

// Namespace: System.Xml
internal enum TriState // TypeDefIndex: 3172
{
	// Fields
	public int value__; // 0x0
	public const TriState Unknown = -1;
	public const TriState False = 0;
	public const TriState True = 1;
}

// Namespace: System.Xml
internal enum XmlStandalone // TypeDefIndex: 3173
{
	// Fields
	public int value__; // 0x0
	public const XmlStandalone Omit = 0;
	public const XmlStandalone Yes = 1;
	public const XmlStandalone No = 2;
}

// Namespace: System.Xml
public sealed class XmlWriterSettings // TypeDefIndex: 3174
{
	// Fields
	private bool useAsync; // 0x10
	private Encoding encoding; // 0x18
	private bool omitXmlDecl; // 0x20
	private NewLineHandling newLineHandling; // 0x24
	private string newLineChars; // 0x28
	private TriState indent; // 0x30
	private string indentChars; // 0x38
	private bool newLineOnAttributes; // 0x40
	private bool closeOutput; // 0x41
	private NamespaceHandling namespaceHandling; // 0x44
	private ConformanceLevel conformanceLevel; // 0x48
	private bool checkCharacters; // 0x4C
	private bool writeEndDocumentOnClose; // 0x4D
	private XmlOutputMethod outputMethod; // 0x50
	private List<XmlQualifiedName> cdataSections; // 0x58
	private bool doNotEscapeUriAttributes; // 0x60
	private bool mergeCDataSections; // 0x61
	private string mediaType; // 0x68
	private string docTypeSystem; // 0x70
	private string docTypePublic; // 0x78
	private XmlStandalone standalone; // 0x80
	private bool autoXmlDecl; // 0x84
	private bool isReadOnly; // 0x85

	// Properties
	public bool Async { get; }
	public Encoding Encoding { get; }
	public bool OmitXmlDeclaration { get; set; }
	public NewLineHandling NewLineHandling { get; }
	public string NewLineChars { get; }
	public bool Indent { get; set; }
	public string IndentChars { get; }
	public bool NewLineOnAttributes { get; }
	public bool CloseOutput { get; }
	public ConformanceLevel ConformanceLevel { get; set; }
	public bool CheckCharacters { get; }
	public NamespaceHandling NamespaceHandling { get; set; }
	public bool WriteEndDocumentOnClose { get; }
	public XmlOutputMethod OutputMethod { get; set; }
	internal List<XmlQualifiedName> CDataSectionElements { get; }
	public bool DoNotEscapeUriAttributes { get; }
	internal bool MergeCDataSections { get; }
	internal string MediaType { get; }
	internal string DocTypeSystem { get; }
	internal string DocTypePublic { get; }
	internal XmlStandalone Standalone { get; }
	internal bool AutoXmlDeclaration { get; }
	internal TriState IndentInternal { get; }
	internal bool IsQuerySpecific { get; }
	internal bool ReadOnly { set; }

	// Methods

	// RVA: 0x1C3A430 Offset: 0x1C36430 VA: 0x1C3A430
	public void .ctor() { }

	// RVA: 0x1C3ADD8 Offset: 0x1C36DD8 VA: 0x1C3ADD8
	public bool get_Async() { }

	// RVA: 0x1C3ADE0 Offset: 0x1C36DE0 VA: 0x1C3ADE0
	public Encoding get_Encoding() { }

	// RVA: 0x1C3ADE8 Offset: 0x1C36DE8 VA: 0x1C3ADE8
	public bool get_OmitXmlDeclaration() { }

	// RVA: 0x1C3ADF0 Offset: 0x1C36DF0 VA: 0x1C3ADF0
	public void set_OmitXmlDeclaration(bool value) { }

	// RVA: 0x1C3AEFC Offset: 0x1C36EFC VA: 0x1C3AEFC
	public NewLineHandling get_NewLineHandling() { }

	// RVA: 0x1C3AF04 Offset: 0x1C36F04 VA: 0x1C3AF04
	public string get_NewLineChars() { }

	// RVA: 0x1C3AF0C Offset: 0x1C36F0C VA: 0x1C3AF0C
	public bool get_Indent() { }

	// RVA: 0x1C3AF1C Offset: 0x1C36F1C VA: 0x1C3AF1C
	public void set_Indent(bool value) { }

	// RVA: 0x1C3AF84 Offset: 0x1C36F84 VA: 0x1C3AF84
	public string get_IndentChars() { }

	// RVA: 0x1C3AF8C Offset: 0x1C36F8C VA: 0x1C3AF8C
	public bool get_NewLineOnAttributes() { }

	// RVA: 0x1C3AF94 Offset: 0x1C36F94 VA: 0x1C3AF94
	public bool get_CloseOutput() { }

	// RVA: 0x1C3AF9C Offset: 0x1C36F9C VA: 0x1C3AF9C
	public ConformanceLevel get_ConformanceLevel() { }

	// RVA: 0x1C3AFA4 Offset: 0x1C36FA4 VA: 0x1C3AFA4
	public void set_ConformanceLevel(ConformanceLevel value) { }

	// RVA: 0x1C3B050 Offset: 0x1C37050 VA: 0x1C3B050
	public bool get_CheckCharacters() { }

	// RVA: 0x1C3B058 Offset: 0x1C37058 VA: 0x1C3B058
	public NamespaceHandling get_NamespaceHandling() { }

	// RVA: 0x1C3B060 Offset: 0x1C37060 VA: 0x1C3B060
	public void set_NamespaceHandling(NamespaceHandling value) { }

	// RVA: 0x1C3B10C Offset: 0x1C3710C VA: 0x1C3B10C
	public bool get_WriteEndDocumentOnClose() { }

	// RVA: 0x1C3B114 Offset: 0x1C37114 VA: 0x1C3B114
	public XmlOutputMethod get_OutputMethod() { }

	// RVA: 0x1C3B11C Offset: 0x1C3711C VA: 0x1C3B11C
	internal void set_OutputMethod(XmlOutputMethod value) { }

	// RVA: 0x1C3B124 Offset: 0x1C37124 VA: 0x1C3B124
	public XmlWriterSettings Clone() { }

	// RVA: 0x1C3B1F8 Offset: 0x1C371F8 VA: 0x1C3B1F8
	internal List<XmlQualifiedName> get_CDataSectionElements() { }

	// RVA: 0x1C3B200 Offset: 0x1C37200 VA: 0x1C3B200
	public bool get_DoNotEscapeUriAttributes() { }

	// RVA: 0x1C3B208 Offset: 0x1C37208 VA: 0x1C3B208
	internal bool get_MergeCDataSections() { }

	// RVA: 0x1C3B210 Offset: 0x1C37210 VA: 0x1C3B210
	internal string get_MediaType() { }

	// RVA: 0x1C3B218 Offset: 0x1C37218 VA: 0x1C3B218
	internal string get_DocTypeSystem() { }

	// RVA: 0x1C3B220 Offset: 0x1C37220 VA: 0x1C3B220
	internal string get_DocTypePublic() { }

	// RVA: 0x1C3B228 Offset: 0x1C37228 VA: 0x1C3B228
	internal XmlStandalone get_Standalone() { }

	// RVA: 0x1C3B230 Offset: 0x1C37230 VA: 0x1C3B230
	internal bool get_AutoXmlDeclaration() { }

	// RVA: 0x1C3B238 Offset: 0x1C37238 VA: 0x1C3B238
	internal TriState get_IndentInternal() { }

	// RVA: 0x1C3B240 Offset: 0x1C37240 VA: 0x1C3B240
	internal bool get_IsQuerySpecific() { }

	// RVA: 0x1C3A4C0 Offset: 0x1C364C0 VA: 0x1C3A4C0
	internal XmlWriter CreateWriter(Stream output) { }

	// RVA: 0x1C3A99C Offset: 0x1C3699C VA: 0x1C3A99C
	internal XmlWriter CreateWriter(TextWriter output) { }

	// RVA: 0x1C3B2B0 Offset: 0x1C372B0 VA: 0x1C3B2B0
	internal void set_ReadOnly(bool value) { }

	// RVA: 0x1C3AE50 Offset: 0x1C36E50 VA: 0x1C3AE50
	private void CheckReadOnly(string propertyName) { }

	// RVA: 0x1C3ACA8 Offset: 0x1C36CA8 VA: 0x1C3ACA8
	private void Initialize() { }
}

// Namespace: 
private enum XsdCachingReader.CachingReaderState // TypeDefIndex: 3175
{
	// Fields
	public int value__; // 0x0
	public const XsdCachingReader.CachingReaderState None = 0;
	public const XsdCachingReader.CachingReaderState Init = 1;
	public const XsdCachingReader.CachingReaderState Record = 2;
	public const XsdCachingReader.CachingReaderState Replay = 3;
	public const XsdCachingReader.CachingReaderState ReaderClosed = 4;
	public const XsdCachingReader.CachingReaderState Error = 5;
}

// Namespace: System.Xml
[DefaultMember("Item")]
internal class XsdCachingReader : XmlReader, IXmlLineInfo // TypeDefIndex: 3176
{
	// Fields
	private XmlReader coreReader; // 0x10
	private XmlNameTable coreReaderNameTable; // 0x18
	private ValidatingReaderNodeData[] contentEvents; // 0x20
	private ValidatingReaderNodeData[] attributeEvents; // 0x28
	private ValidatingReaderNodeData cachedNode; // 0x30
	private XsdCachingReader.CachingReaderState cacheState; // 0x38
	private int contentIndex; // 0x3C
	private int attributeCount; // 0x40
	private bool returnOriginalStringValues; // 0x44
	private CachingEventHandler cacheHandler; // 0x48
	private int currentAttrIndex; // 0x50
	private int currentContentIndex; // 0x54
	private bool readAhead; // 0x58
	private IXmlLineInfo lineInfo; // 0x60
	private ValidatingReaderNodeData textNode; // 0x68

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	private int System.Xml.IXmlLineInfo.LineNumber { get; }
	private int System.Xml.IXmlLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x1C3B2B8 Offset: 0x1C372B8 VA: 0x1C3B2B8
	internal void .ctor(XmlReader reader, IXmlLineInfo lineInfo, CachingEventHandler handlerMethod) { }

	// RVA: 0x1C3B3B0 Offset: 0x1C373B0 VA: 0x1C3B3B0
	private void Init() { }

	// RVA: 0x1C3B82C Offset: 0x1C3782C VA: 0x1C3B82C
	internal void Reset(XmlReader reader) { }

	// RVA: 0x1C3B848 Offset: 0x1C37848 VA: 0x1C3B848 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1C3B864 Offset: 0x1C37864 VA: 0x1C3B864 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C3B87C Offset: 0x1C3787C VA: 0x1C3B87C Slot: 7
	public override string get_Name() { }

	// RVA: 0x1C3B89C Offset: 0x1C3789C VA: 0x1C3B89C Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1C3B8B4 Offset: 0x1C378B4 VA: 0x1C3B8B4 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1C3B8CC Offset: 0x1C378CC VA: 0x1C3B8CC Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1C3B8E4 Offset: 0x1C378E4 VA: 0x1C3B8E4 Slot: 11
	public override string get_Value() { }

	// RVA: 0x1C3B918 Offset: 0x1C37918 VA: 0x1C3B918 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x1C3B930 Offset: 0x1C37930 VA: 0x1C3B930 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x1C3B950 Offset: 0x1C37950 VA: 0x1C3B950 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1C3B958 Offset: 0x1C37958 VA: 0x1C3B958 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1C3B960 Offset: 0x1C37960 VA: 0x1C3B960 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x1C3B980 Offset: 0x1C37980 VA: 0x1C3B980 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1C3B9A0 Offset: 0x1C379A0 VA: 0x1C3B9A0 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x1C3B9C0 Offset: 0x1C379C0 VA: 0x1C3B9C0 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x1C3B9C8 Offset: 0x1C379C8 VA: 0x1C3B9C8 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x1C3BBA4 Offset: 0x1C37BA4 VA: 0x1C3BBA4 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x1C3BC9C Offset: 0x1C37C9C VA: 0x1C3BC9C Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x1C3BD2C Offset: 0x1C37D2C VA: 0x1C3BD2C Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1C3BDC4 Offset: 0x1C37DC4 VA: 0x1C3BDC4 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1C3BE54 Offset: 0x1C37E54 VA: 0x1C3BE54 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1C3BE98 Offset: 0x1C37E98 VA: 0x1C3BE98 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1C3BEF8 Offset: 0x1C37EF8 VA: 0x1C3BEF8 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x1C3BF4C Offset: 0x1C37F4C VA: 0x1C3BF4C Slot: 31
	public override bool Read() { }

	// RVA: 0x1C3C23C Offset: 0x1C3823C VA: 0x1C3C23C
	internal ValidatingReaderNodeData RecordTextNode(string textValue, string originalStringValue, int depth, int lineNo, int linePos) { }

	// RVA: 0x1C3C2B4 Offset: 0x1C382B4 VA: 0x1C3C2B4
	internal void SwitchTextNodeAndEndElement(string textValue, string originalStringValue) { }

	// RVA: 0x1C3C3CC Offset: 0x1C383CC VA: 0x1C3C3CC
	internal void RecordEndElementNode() { }

	// RVA: 0x1C3C4FC Offset: 0x1C384FC VA: 0x1C3C4FC Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x1C3C530 Offset: 0x1C38530 VA: 0x1C3C530 Slot: 33
	public override void Close() { }

	// RVA: 0x1C3C564 Offset: 0x1C38564 VA: 0x1C3C564 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x1C3C584 Offset: 0x1C38584 VA: 0x1C3C584 Slot: 35
	public override void Skip() { }

	// RVA: 0x1C3C698 Offset: 0x1C38698 VA: 0x1C3C698 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1C3C6A0 Offset: 0x1C386A0 VA: 0x1C3C6A0 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1C3C6C0 Offset: 0x1C386C0 VA: 0x1C3C6C0 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1C3C6F8 Offset: 0x1C386F8 VA: 0x1C3C6F8 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x1C3C7F4 Offset: 0x1C387F4 VA: 0x1C3C7F4 Slot: 53
	private bool System.Xml.IXmlLineInfo.HasLineInfo() { }

	// RVA: 0x1C3C7FC Offset: 0x1C387FC VA: 0x1C3C7FC Slot: 54
	private int System.Xml.IXmlLineInfo.get_LineNumber() { }

	// RVA: 0x1C3C814 Offset: 0x1C38814 VA: 0x1C3C814 Slot: 55
	private int System.Xml.IXmlLineInfo.get_LinePosition() { }

	// RVA: 0x1C3C82C Offset: 0x1C3882C VA: 0x1C3C82C
	internal void SetToReplayMode() { }

	// RVA: 0x1C3C84C Offset: 0x1C3884C VA: 0x1C3C84C
	internal XmlReader GetCoreReader() { }

	// RVA: 0x1C3C854 Offset: 0x1C38854 VA: 0x1C3C854
	internal IXmlLineInfo GetLineInfo() { }

	// RVA: 0x1C3C22C Offset: 0x1C3822C VA: 0x1C3C22C
	private void ClearAttributesInfo() { }

	// RVA: 0x1C3C85C Offset: 0x1C3885C VA: 0x1C3C85C
	private ValidatingReaderNodeData AddAttribute(int attIndex) { }

	// RVA: 0x1C3B51C Offset: 0x1C3751C VA: 0x1C3B51C
	private ValidatingReaderNodeData AddContent(XmlNodeType nodeType) { }

	// RVA: 0x1C3B6A8 Offset: 0x1C376A8 VA: 0x1C3B6A8
	private void RecordAttributes() { }

	// RVA: 0x1C3BA54 Offset: 0x1C37A54 VA: 0x1C3BA54
	private int GetAttributeIndexWithoutPrefix(string name) { }

	// RVA: 0x1C3BB04 Offset: 0x1C37B04 VA: 0x1C3BB04
	private int GetAttributeIndexWithPrefix(string name) { }

	// RVA: 0x1C3C754 Offset: 0x1C38754 VA: 0x1C3C754
	private ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }
}

// Namespace: System.Xml
internal sealed class CachingEventHandler : MulticastDelegate // TypeDefIndex: 3177
{
	// Methods

	// RVA: 0x1C3C9D0 Offset: 0x1C389D0 VA: 0x1C3C9D0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C3CAD8 Offset: 0x1C38AD8 VA: 0x1C3CAD8 Slot: 12
	public virtual void Invoke(XsdCachingReader cachingReader) { }
}

// Namespace: System.Xml
internal class AttributePSVIInfo // TypeDefIndex: 3178
{
	// Fields
	internal string localName; // 0x10
	internal string namespaceUri; // 0x18
	internal object typedAttributeValue; // 0x20
	internal XmlSchemaInfo attributeSchemaInfo; // 0x28

	// Methods

	// RVA: 0x1C3CAEC Offset: 0x1C38AEC VA: 0x1C3CAEC
	internal void .ctor() { }

	// RVA: 0x1C3CB58 Offset: 0x1C38B58 VA: 0x1C3CB58
	internal void Reset() { }
}

// Namespace: 
private enum XsdValidatingReader.ValidatingReaderState // TypeDefIndex: 3179
{
	// Fields
	public int value__; // 0x0
	public const XsdValidatingReader.ValidatingReaderState None = 0;
	public const XsdValidatingReader.ValidatingReaderState Init = 1;
	public const XsdValidatingReader.ValidatingReaderState Read = 2;
	public const XsdValidatingReader.ValidatingReaderState OnDefaultAttribute = -1;
	public const XsdValidatingReader.ValidatingReaderState OnReadAttributeValue = -2;
	public const XsdValidatingReader.ValidatingReaderState OnAttribute = 3;
	public const XsdValidatingReader.ValidatingReaderState ClearAttributes = 4;
	public const XsdValidatingReader.ValidatingReaderState ParseInlineSchema = 5;
	public const XsdValidatingReader.ValidatingReaderState ReadAhead = 6;
	public const XsdValidatingReader.ValidatingReaderState OnReadBinaryContent = 7;
	public const XsdValidatingReader.ValidatingReaderState ReaderClosed = 8;
	public const XsdValidatingReader.ValidatingReaderState EOF = 9;
	public const XsdValidatingReader.ValidatingReaderState Error = 10;
}

// Namespace: System.Xml
internal class XsdValidatingReader : XmlReader, IXmlSchemaInfo, IXmlLineInfo, IXmlNamespaceResolver // TypeDefIndex: 3180
{
	// Fields
	private XmlReader coreReader; // 0x10
	private IXmlNamespaceResolver coreReaderNSResolver; // 0x18
	private IXmlNamespaceResolver thisNSResolver; // 0x20
	private XmlSchemaValidator validator; // 0x28
	private XmlResolver xmlResolver; // 0x30
	private ValidationEventHandler validationEvent; // 0x38
	private XsdValidatingReader.ValidatingReaderState validationState; // 0x40
	private XmlValueGetter valueGetter; // 0x48
	private XmlNamespaceManager nsManager; // 0x50
	private bool manageNamespaces; // 0x58
	private bool processInlineSchema; // 0x59
	private bool replayCache; // 0x5A
	private ValidatingReaderNodeData cachedNode; // 0x60
	private AttributePSVIInfo attributePSVI; // 0x68
	private int attributeCount; // 0x70
	private int coreReaderAttributeCount; // 0x74
	private int currentAttrIndex; // 0x78
	private AttributePSVIInfo[] attributePSVINodes; // 0x80
	private ArrayList defaultAttributes; // 0x88
	private Parser inlineSchemaParser; // 0x90
	private object atomicValue; // 0x98
	private XmlSchemaInfo xmlSchemaInfo; // 0xA0
	private string originalAtomicValueString; // 0xA8
	private XmlNameTable coreReaderNameTable; // 0xB0
	private XsdCachingReader cachingReader; // 0xB8
	private ValidatingReaderNodeData textNode; // 0xC0
	private string NsXmlNs; // 0xC8
	private string NsXs; // 0xD0
	private string NsXsi; // 0xD8
	private string XsiType; // 0xE0
	private string XsiNil; // 0xE8
	private string XsdSchema; // 0xF0
	private string XsiSchemaLocation; // 0xF8
	private string XsiNoNamespaceSchemaLocation; // 0x100
	private XmlCharType xmlCharType; // 0x108
	private IXmlLineInfo lineInfo; // 0x110
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x118
	private XsdValidatingReader.ValidatingReaderState savedState; // 0x120
	private static Type TypeOfString; // 0x0

	// Properties
	public override XmlReaderSettings Settings { get; }
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override char QuoteChar { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override Type ValueType { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override XmlNameTable NameTable { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsDefault { get; }
	private bool System.Xml.Schema.IXmlSchemaInfo.IsNil { get; }
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.Validity { get; }
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.MemberType { get; }
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.SchemaType { get; }
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.SchemaElement { get; }
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.SchemaAttribute { get; }
	public int LineNumber { get; }
	public int LinePosition { get; }
	private XmlSchemaInfo AttributeSchemaInfo { get; }

	// Methods

	// RVA: 0x1C3CBC4 Offset: 0x1C38BC4 VA: 0x1C3CBC4
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings, XmlSchemaObject partialValidationType) { }

	// RVA: 0x1C3D37C Offset: 0x1C3937C VA: 0x1C3D37C
	internal void .ctor(XmlReader reader, XmlResolver xmlResolver, XmlReaderSettings readerSettings) { }

	// RVA: 0x1C3CDCC Offset: 0x1C38DCC VA: 0x1C3CDCC
	private void Init() { }

	// RVA: 0x1C3D168 Offset: 0x1C39168 VA: 0x1C3D168
	private void SetupValidator(XmlReaderSettings readerSettings, XmlReader reader, XmlSchemaObject partialValidationType) { }

	// RVA: 0x1C3D384 Offset: 0x1C39384 VA: 0x1C3D384 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1C3D454 Offset: 0x1C39454 VA: 0x1C3D454 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C3D4DC Offset: 0x1C394DC VA: 0x1C3D4DC Slot: 7
	public override string get_Name() { }

	// RVA: 0x1C3D5F4 Offset: 0x1C395F4 VA: 0x1C3D5F4 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1C3D630 Offset: 0x1C39630 VA: 0x1C3D630 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1C3D66C Offset: 0x1C3966C VA: 0x1C3D66C Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1C3D6A8 Offset: 0x1C396A8 VA: 0x1C3D6A8 Slot: 11
	public override string get_Value() { }

	// RVA: 0x1C3D6E4 Offset: 0x1C396E4 VA: 0x1C3D6E4 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x1C3D720 Offset: 0x1C39720 VA: 0x1C3D720 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x1C3D740 Offset: 0x1C39740 VA: 0x1C3D740 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1C3D760 Offset: 0x1C39760 VA: 0x1C3D760 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1C3D794 Offset: 0x1C39794 VA: 0x1C3D794 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x1C3D7B4 Offset: 0x1C397B4 VA: 0x1C3D7B4 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1C3D7D4 Offset: 0x1C397D4 VA: 0x1C3D7D4 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x1C3D7F4 Offset: 0x1C397F4 VA: 0x1C3D7F4 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1C3D7F8 Offset: 0x1C397F8 VA: 0x1C3D7F8 Slot: 20
	public override Type get_ValueType() { }

	// RVA: 0x1C3D8D8 Offset: 0x1C398D8 VA: 0x1C3D8D8 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x1C3D8E0 Offset: 0x1C398E0 VA: 0x1C3D8E0 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x1C3DAC8 Offset: 0x1C39AC8 VA: 0x1C3DAC8 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x1C3DCD8 Offset: 0x1C39CD8 VA: 0x1C3DCD8 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x1C3DDB0 Offset: 0x1C39DB0 VA: 0x1C3DDB0 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1C3E004 Offset: 0x1C3A004 VA: 0x1C3E004 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1C3E1D0 Offset: 0x1C3A1D0 VA: 0x1C3E1D0 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1C3E364 Offset: 0x1C3A364 VA: 0x1C3E364 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1C3E4F8 Offset: 0x1C3A4F8 VA: 0x1C3E4F8 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x1C3E54C Offset: 0x1C3A54C VA: 0x1C3E54C Slot: 31
	public override bool Read() { }

	// RVA: 0x1C3E9A4 Offset: 0x1C3A9A4 VA: 0x1C3E9A4 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x1C3E9C4 Offset: 0x1C3A9C4 VA: 0x1C3E9C4 Slot: 33
	public override void Close() { }

	// RVA: 0x1C3E9F8 Offset: 0x1C3A9F8 VA: 0x1C3E9F8 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x1C3EA2C Offset: 0x1C3AA2C VA: 0x1C3EA2C Slot: 35
	public override void Skip() { }

	// RVA: 0x1C3EB88 Offset: 0x1C3AB88 VA: 0x1C3EB88 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1C3EB90 Offset: 0x1C3AB90 VA: 0x1C3EB90 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1C3EC3C Offset: 0x1C3AC3C VA: 0x1C3EC3C Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1C3EC74 Offset: 0x1C3AC74 VA: 0x1C3EC74 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x1C3EDDC Offset: 0x1C3ADDC VA: 0x1C3EDDC Slot: 54
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsDefault() { }

	// RVA: 0x1C3F104 Offset: 0x1C3B104 VA: 0x1C3F104 Slot: 55
	private bool System.Xml.Schema.IXmlSchemaInfo.get_IsNil() { }

	// RVA: 0x1C3F14C Offset: 0x1C3B14C VA: 0x1C3F14C Slot: 53
	private XmlSchemaValidity System.Xml.Schema.IXmlSchemaInfo.get_Validity() { }

	// RVA: 0x1C3F1DC Offset: 0x1C3B1DC VA: 0x1C3F1DC Slot: 56
	private XmlSchemaSimpleType System.Xml.Schema.IXmlSchemaInfo.get_MemberType() { }

	// RVA: 0x1C3F364 Offset: 0x1C3B364 VA: 0x1C3F364 Slot: 57
	private XmlSchemaType System.Xml.Schema.IXmlSchemaInfo.get_SchemaType() { }

	// RVA: 0x1C3F3C0 Offset: 0x1C3B3C0 VA: 0x1C3F3C0 Slot: 58
	private XmlSchemaElement System.Xml.Schema.IXmlSchemaInfo.get_SchemaElement() { }

	// RVA: 0x1C3F414 Offset: 0x1C3B414 VA: 0x1C3F414 Slot: 59
	private XmlSchemaAttribute System.Xml.Schema.IXmlSchemaInfo.get_SchemaAttribute() { }

	// RVA: 0x1C3F458 Offset: 0x1C3B458 VA: 0x1C3F458 Slot: 60
	public bool HasLineInfo() { }

	// RVA: 0x1C3F460 Offset: 0x1C3B460 VA: 0x1C3F460 Slot: 61
	public int get_LineNumber() { }

	// RVA: 0x1C3F510 Offset: 0x1C3B510 VA: 0x1C3F510 Slot: 62
	public int get_LinePosition() { }

	// RVA: 0x1C3F5C0 Offset: 0x1C3B5C0 VA: 0x1C3F5C0 Slot: 63
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1C3F680 Offset: 0x1C3B680 VA: 0x1C3F680 Slot: 64
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1C3F744 Offset: 0x1C3B744 VA: 0x1C3F744 Slot: 65
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1C3F808 Offset: 0x1C3B808 VA: 0x1C3F808
	private object GetStringValue() { }

	// RVA: 0x1C3D8C0 Offset: 0x1C398C0 VA: 0x1C3D8C0
	private XmlSchemaInfo get_AttributeSchemaInfo() { }

	// RVA: 0x1C3E6D0 Offset: 0x1C3A6D0 VA: 0x1C3E6D0
	private void ProcessReaderEvent() { }

	// RVA: 0x1C3F824 Offset: 0x1C3B824 VA: 0x1C3F824
	private void ProcessElementEvent() { }

	// RVA: 0x1C3FCE4 Offset: 0x1C3BCE4 VA: 0x1C3FCE4
	private void ProcessEndElementEvent() { }

	// RVA: 0x1C3FE98 Offset: 0x1C3BE98 VA: 0x1C3FE98
	private void ValidateAttributes() { }

	// RVA: 0x1C3E960 Offset: 0x1C3A960 VA: 0x1C3E960
	private void ClearAttributesInfo() { }

	// RVA: 0x1C3DE8C Offset: 0x1C39E8C VA: 0x1C3DE8C
	private AttributePSVIInfo GetAttributePSVI(string name) { }

	// RVA: 0x1C40330 Offset: 0x1C3C330 VA: 0x1C40330
	private AttributePSVIInfo GetAttributePSVI(string localName, string ns) { }

	// RVA: 0x1C3D94C Offset: 0x1C3994C VA: 0x1C3D94C
	private ValidatingReaderNodeData GetDefaultAttribute(string name, bool updatePosition) { }

	// RVA: 0x1C3DB98 Offset: 0x1C39B98 VA: 0x1C3DB98
	private ValidatingReaderNodeData GetDefaultAttribute(string attrLocalName, string ns, bool updatePosition) { }

	// RVA: 0x1C401CC Offset: 0x1C3C1CC VA: 0x1C401CC
	private AttributePSVIInfo AddAttributePSVI(int attIndex) { }

	// RVA: 0x1C3FE48 Offset: 0x1C3BE48 VA: 0x1C3FE48
	private bool IsXSDRoot(string localName, string ns) { }

	// RVA: 0x1C3E898 Offset: 0x1C3A898 VA: 0x1C3E898
	private void ProcessInlineSchema() { }

	// RVA: 0x1C403D8 Offset: 0x1C3C3D8 VA: 0x1C403D8
	private void ReadAheadForMemberType() { }

	// RVA: 0x1C3EE64 Offset: 0x1C3AE64 VA: 0x1C3EE64
	private void GetIsDefault() { }

	// RVA: 0x1C3F25C Offset: 0x1C3B25C VA: 0x1C3F25C
	private void GetMemberType() { }

	// RVA: 0x1C400CC Offset: 0x1C3C0CC VA: 0x1C400CC
	private XsdCachingReader GetCachingReader() { }

	// RVA: 0x1C3ED3C Offset: 0x1C3AD3C VA: 0x1C3ED3C
	internal ValidatingReaderNodeData CreateDummyTextNode(string attributeValue, int depth) { }

	// RVA: 0x1C405C8 Offset: 0x1C3C5C8 VA: 0x1C405C8
	internal void CachingCallBack(XsdCachingReader cachingReader) { }

	// RVA: 0x1C4006C Offset: 0x1C3C06C VA: 0x1C4006C
	private string GetOriginalAtomicValueStringOfElement() { }
}

// Namespace: System.Xml
internal class DomNameTable // TypeDefIndex: 3181
{
	// Fields
	private XmlName[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private XmlDocument ownerDocument; // 0x20
	private XmlNameTable nameTable; // 0x28

	// Methods

	// RVA: 0x1C40610 Offset: 0x1C3C610 VA: 0x1C40610
	public void .ctor(XmlDocument document) { }

	// RVA: 0x1C406CC Offset: 0x1C3C6CC VA: 0x1C406CC
	public XmlName GetName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1C40810 Offset: 0x1C3C810 VA: 0x1C40810
	public XmlName AddName(string prefix, string localName, string ns, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1C40A64 Offset: 0x1C3CA64 VA: 0x1C40A64
	private void Grow() { }
}

// Namespace: System.Xml
public class XmlAttribute : XmlNode // TypeDefIndex: 3182
{
	// Fields
	private XmlName name; // 0x18
	private XmlLinkedNode lastChild; // 0x20

	// Properties
	internal int LocalNameHash { get; }
	internal XmlName XmlName { get; set; }
	public override XmlNode ParentNode { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string Value { get; set; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string InnerText { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public virtual bool Specified { get; }
	public virtual XmlElement OwnerElement { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }
	internal override XmlSpace XmlSpace { get; }
	internal override string XmlLang { get; }

	// Methods

	// RVA: 0x1C40BC0 Offset: 0x1C3CBC0 VA: 0x1C40BC0
	internal void .ctor(XmlName name, XmlDocument doc) { }

	// RVA: 0x1C40DB0 Offset: 0x1C3CDB0 VA: 0x1C40DB0
	internal int get_LocalNameHash() { }

	// RVA: 0x1C40DC8 Offset: 0x1C3CDC8 VA: 0x1C40DC8
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x1C40F18 Offset: 0x1C3CF18 VA: 0x1C40F18
	internal XmlName get_XmlName() { }

	// RVA: 0x1C40F20 Offset: 0x1C3CF20 VA: 0x1C40F20
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x1C40F28 Offset: 0x1C3CF28 VA: 0x1C40F28 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C40FF0 Offset: 0x1C3CFF0 VA: 0x1C40FF0 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1C40FF8 Offset: 0x1C3CFF8 VA: 0x1C40FF8 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1C41010 Offset: 0x1C3D010 VA: 0x1C41010 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1C41028 Offset: 0x1C3D028 VA: 0x1C41028 Slot: 33
	public override string get_NamespaceURI() { }

	// RVA: 0x1C41040 Offset: 0x1C3D040 VA: 0x1C41040 Slot: 34
	public override string get_Prefix() { }

	// RVA: 0x1C41058 Offset: 0x1C3D058 VA: 0x1C41058 Slot: 35
	public override void set_Prefix(string value) { }

	// RVA: 0x1C41100 Offset: 0x1C3D100 VA: 0x1C41100 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C41108 Offset: 0x1C3D108 VA: 0x1C41108 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1C41120 Offset: 0x1C3D120 VA: 0x1C41120 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1C41130 Offset: 0x1C3D130 VA: 0x1C41130 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1C41140 Offset: 0x1C3D140 VA: 0x1C41140 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1C41148 Offset: 0x1C3D148 VA: 0x1C41148 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x1C411AC Offset: 0x1C3D1AC VA: 0x1C411AC
	internal bool PrepareOwnerElementInElementIdAttrMap() { }

	// RVA: 0x1C4125C Offset: 0x1C3D25C VA: 0x1C4125C
	internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText) { }

	// RVA: 0x1C41484 Offset: 0x1C3D484 VA: 0x1C41484 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x1C4148C Offset: 0x1C3D48C VA: 0x1C4148C Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x1C416EC Offset: 0x1C3D6EC VA: 0x1C416EC Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1C416F4 Offset: 0x1C3D6F4 VA: 0x1C416F4 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1C416FC Offset: 0x1C3D6FC VA: 0x1C416FC Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1C4170C Offset: 0x1C3D70C VA: 0x1C4170C Slot: 56
	public virtual bool get_Specified() { }

	// RVA: 0x1C41714 Offset: 0x1C3D714 VA: 0x1C41714 Slot: 21
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1C417A4 Offset: 0x1C3D7A4 VA: 0x1C417A4 Slot: 22
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1C41834 Offset: 0x1C3D834 VA: 0x1C41834 Slot: 23
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x1C418AC Offset: 0x1C3D8AC VA: 0x1C418AC Slot: 24
	public override XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x1C41924 Offset: 0x1C3D924 VA: 0x1C41924 Slot: 25
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x1C4199C Offset: 0x1C3D99C VA: 0x1C4199C Slot: 57
	public virtual XmlElement get_OwnerElement() { }

	// RVA: 0x1C41A18 Offset: 0x1C3DA18 VA: 0x1C41A18 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x1C41AB4 Offset: 0x1C3DAB4 VA: 0x1C41AB4 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C41B68 Offset: 0x1C3DB68 VA: 0x1C41B68 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1C41BD0 Offset: 0x1C3DBD0 VA: 0x1C41BD0 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x1C41C38 Offset: 0x1C3DC38 VA: 0x1C41C38 Slot: 47
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x1C41C40 Offset: 0x1C3DC40 VA: 0x1C41C40 Slot: 53
	internal override XmlSpace get_XmlSpace() { }

	// RVA: 0x1C41C94 Offset: 0x1C3DC94 VA: 0x1C41C94 Slot: 54
	internal override string get_XmlLang() { }
}

// Namespace: System.Xml
[DefaultMember("ItemOf")]
public sealed class XmlAttributeCollection : XmlNamedNodeMap, ICollection, IEnumerable // TypeDefIndex: 3183
{
	// Properties
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	public XmlAttribute ItemOf { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }

	// Methods

	// RVA: 0x1C41CFC Offset: 0x1C3DCFC VA: 0x1C41CFC
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x1C41D04 Offset: 0x1C3DD04 VA: 0x1C41D04
	public XmlAttribute get_ItemOf(int i) { }

	// RVA: 0x1C41E48 Offset: 0x1C3DE48 VA: 0x1C41E48
	public XmlAttribute get_ItemOf(string name) { }

	// RVA: 0x1C41F68 Offset: 0x1C3DF68 VA: 0x1C41F68
	public XmlAttribute get_ItemOf(string localName, string namespaceURI) { }

	// RVA: 0x1C420B8 Offset: 0x1C3E0B8 VA: 0x1C420B8
	internal int FindNodeOffsetNS(XmlAttribute node) { }

	// RVA: 0x1C42234 Offset: 0x1C3E234 VA: 0x1C42234 Slot: 6
	public override XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x1C42468 Offset: 0x1C3E468 VA: 0x1C42468
	public XmlAttribute Append(XmlAttribute node) { }

	// RVA: 0x1C42718 Offset: 0x1C3E718 VA: 0x1C42718
	public XmlAttribute Remove(XmlAttribute node) { }

	// RVA: 0x1C4279C Offset: 0x1C3E79C VA: 0x1C4279C
	public XmlAttribute RemoveAt(int i) { }

	// RVA: 0x1C42848 Offset: 0x1C3E848 VA: 0x1C42848
	public void RemoveAll() { }

	// RVA: 0x1C42890 Offset: 0x1C3E890 VA: 0x1C42890 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1C42910 Offset: 0x1C3E910 VA: 0x1C42910 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1C42918 Offset: 0x1C3E918 VA: 0x1C42918 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1C4291C Offset: 0x1C3E91C VA: 0x1C4291C Slot: 14
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1C42924 Offset: 0x1C3E924 VA: 0x1C42924 Slot: 9
	internal override XmlNode AddNode(XmlNode node) { }

	// RVA: 0x1C42B0C Offset: 0x1C3EB0C VA: 0x1C42B0C Slot: 12
	internal override XmlNode InsertNodeAt(int i, XmlNode node) { }

	// RVA: 0x1C42BBC Offset: 0x1C3EBBC VA: 0x1C42BBC Slot: 11
	internal override XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x1C4257C Offset: 0x1C3E57C VA: 0x1C4257C
	internal void Detach(XmlAttribute attr) { }

	// RVA: 0x1C425C4 Offset: 0x1C3E5C4 VA: 0x1C425C4
	internal void InsertParentIntoElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x1C42D5C Offset: 0x1C3ED5C VA: 0x1C42D5C
	internal void RemoveParentFromElementIdAttrMap(XmlAttribute attr) { }

	// RVA: 0x1C42A08 Offset: 0x1C3EA08 VA: 0x1C42A08
	internal int RemoveDuplicateAttribute(XmlAttribute attr) { }

	// RVA: 0x1C412D8 Offset: 0x1C3D2D8 VA: 0x1C412D8
	internal bool PrepareParentInElementIdAttrMap(string attrPrefix, string attrLocalName) { }

	// RVA: 0x1C413C8 Offset: 0x1C3D3C8 VA: 0x1C413C8
	internal void ResetParentInElementIdAttrMap(string oldVal, string newVal) { }

	// RVA: 0x1C423C8 Offset: 0x1C3E3C8 VA: 0x1C423C8
	internal XmlAttribute InternalAppendAttribute(XmlAttribute node) { }
}

// Namespace: System.Xml
public class XmlCDataSection : XmlCharacterData // TypeDefIndex: 3184
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x1C43490 Offset: 0x1C3F490 VA: 0x1C43490
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x1C434D8 Offset: 0x1C3F4D8 VA: 0x1C434D8 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1C43500 Offset: 0x1C3F500 VA: 0x1C43500 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1C43528 Offset: 0x1C3F528 VA: 0x1C43528 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C43530 Offset: 0x1C3F530 VA: 0x1C43530 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1C435B4 Offset: 0x1C3F5B4 VA: 0x1C435B4 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C43610 Offset: 0x1C3F610 VA: 0x1C43610 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C43650 Offset: 0x1C3F650 VA: 0x1C43650 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1C43654 Offset: 0x1C3F654 VA: 0x1C43654 Slot: 55
	internal override bool get_IsText() { }
}

// Namespace: System.Xml
public abstract class XmlCharacterData : XmlLinkedNode // TypeDefIndex: 3185
{
	// Fields
	private string data; // 0x20

	// Properties
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public virtual string Data { get; set; }

	// Methods

	// RVA: 0x1C43494 Offset: 0x1C3F494 VA: 0x1C43494
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x1C43680 Offset: 0x1C3F680 VA: 0x1C43680 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1C43690 Offset: 0x1C3F690 VA: 0x1C43690 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1C436A0 Offset: 0x1C3F6A0 VA: 0x1C436A0 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x1C436AC Offset: 0x1C3F6AC VA: 0x1C436AC Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x1C436B8 Offset: 0x1C3F6B8 VA: 0x1C436B8 Slot: 56
	public virtual string get_Data() { }

	// RVA: 0x1C436DC Offset: 0x1C3F6DC VA: 0x1C436DC Slot: 57
	public virtual void set_Data(string value) { }

	// RVA: 0x1C437A0 Offset: 0x1C3F7A0 VA: 0x1C437A0
	internal bool CheckOnData(string data) { }
}

// Namespace: System.Xml
internal sealed class XmlChildEnumerator : IEnumerator // TypeDefIndex: 3186
{
	// Fields
	internal XmlNode container; // 0x10
	internal XmlNode child; // 0x18
	internal bool isFirst; // 0x20

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	internal XmlNode Current { get; }

	// Methods

	// RVA: 0x1C437DC Offset: 0x1C3F7DC VA: 0x1C437DC
	internal void .ctor(XmlNode container) { }

	// RVA: 0x1C43844 Offset: 0x1C3F844 VA: 0x1C43844 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1C43848 Offset: 0x1C3F848 VA: 0x1C43848
	internal bool MoveNext() { }

	// RVA: 0x1C438D8 Offset: 0x1C3F8D8 VA: 0x1C438D8 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1C43918 Offset: 0x1C3F918 VA: 0x1C43918 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1C4391C Offset: 0x1C3F91C VA: 0x1C4391C
	internal XmlNode get_Current() { }
}

// Namespace: System.Xml
internal class XmlChildNodes : XmlNodeList // TypeDefIndex: 3187
{
	// Fields
	private XmlNode container; // 0x10

	// Properties
	public override int Count { get; }

	// Methods

	// RVA: 0x1C43988 Offset: 0x1C3F988 VA: 0x1C43988
	public void .ctor(XmlNode container) { }

	// RVA: 0x1C439B8 Offset: 0x1C3F9B8 VA: 0x1C439B8 Slot: 6
	public override XmlNode Item(int i) { }

	// RVA: 0x1C43A14 Offset: 0x1C3FA14 VA: 0x1C43A14 Slot: 7
	public override int get_Count() { }

	// RVA: 0x1C43A60 Offset: 0x1C3FA60 VA: 0x1C43A60 Slot: 8
	public override IEnumerator GetEnumerator() { }
}

// Namespace: System.Xml
public class XmlComment : XmlCharacterData // TypeDefIndex: 3188
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x1C43B10 Offset: 0x1C3FB10 VA: 0x1C43B10
	protected internal void .ctor(string comment, XmlDocument doc) { }

	// RVA: 0x1C43B14 Offset: 0x1C3FB14 VA: 0x1C43B14 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1C43B3C Offset: 0x1C3FB3C VA: 0x1C43B3C Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1C43B64 Offset: 0x1C3FB64 VA: 0x1C43B64 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C43B6C Offset: 0x1C3FB6C VA: 0x1C43B6C Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C43BC8 Offset: 0x1C3FBC8 VA: 0x1C43BC8 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C43C08 Offset: 0x1C3FC08 VA: 0x1C43C08 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }
}

// Namespace: System.Xml
public class XmlDeclaration : XmlLinkedNode // TypeDefIndex: 3189
{
	// Fields
	private string version; // 0x20
	private string encoding; // 0x28
	private string standalone; // 0x30

	// Properties
	public string Version { get; set; }
	public string Encoding { get; set; }
	public string Standalone { get; set; }
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x1C43C0C Offset: 0x1C3FC0C VA: 0x1C43C0C
	protected internal void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

	// RVA: 0x1C43F98 Offset: 0x1C3FF98 VA: 0x1C43F98
	public string get_Version() { }

	// RVA: 0x1C43FA0 Offset: 0x1C3FFA0 VA: 0x1C43FA0
	internal void set_Version(string value) { }

	// RVA: 0x1C43FA8 Offset: 0x1C3FFA8 VA: 0x1C43FA8
	public string get_Encoding() { }

	// RVA: 0x1C43E28 Offset: 0x1C3FE28 VA: 0x1C43E28
	public void set_Encoding(string value) { }

	// RVA: 0x1C43FB0 Offset: 0x1C3FFB0 VA: 0x1C43FB0
	public string get_Standalone() { }

	// RVA: 0x1C43E54 Offset: 0x1C3FE54 VA: 0x1C43E54
	public void set_Standalone(string value) { }

	// RVA: 0x1C43FB8 Offset: 0x1C3FFB8 VA: 0x1C43FB8 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1C43FC8 Offset: 0x1C3FFC8 VA: 0x1C43FC8 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1C43FD8 Offset: 0x1C3FFD8 VA: 0x1C43FD8 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x1C4414C Offset: 0x1C4014C VA: 0x1C4414C Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x1C445A4 Offset: 0x1C405A4 VA: 0x1C445A4 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1C445E4 Offset: 0x1C405E4 VA: 0x1C445E4 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1C445F0 Offset: 0x1C405F0 VA: 0x1C445F0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C445F8 Offset: 0x1C405F8 VA: 0x1C445F8 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C44634 Offset: 0x1C40634 VA: 0x1C44634 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C44698 Offset: 0x1C40698 VA: 0x1C44698 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1C43DAC Offset: 0x1C3FDAC VA: 0x1C43DAC
	private bool IsValidXmlVersion(string ver) { }
}

// Namespace: System.Xml
public class XmlDocument : XmlNode // TypeDefIndex: 3190
{
	// Fields
	private XmlImplementation implementation; // 0x18
	private DomNameTable domNameTable; // 0x20
	private XmlLinkedNode lastChild; // 0x28
	private XmlNamedNodeMap entities; // 0x30
	private Hashtable htElementIdMap; // 0x38
	private Hashtable htElementIDAttrDecl; // 0x40
	private SchemaInfo schemaInfo; // 0x48
	private XmlSchemaSet schemas; // 0x50
	private bool reportValidity; // 0x58
	private bool actualLoadingStatus; // 0x59
	private XmlNodeChangedEventHandler onNodeInsertingDelegate; // 0x60
	private XmlNodeChangedEventHandler onNodeInsertedDelegate; // 0x68
	private XmlNodeChangedEventHandler onNodeRemovingDelegate; // 0x70
	private XmlNodeChangedEventHandler onNodeRemovedDelegate; // 0x78
	private XmlNodeChangedEventHandler onNodeChangingDelegate; // 0x80
	private XmlNodeChangedEventHandler onNodeChangedDelegate; // 0x88
	internal bool fEntRefNodesPresent; // 0x90
	internal bool fCDataNodesPresent; // 0x91
	private bool preserveWhitespace; // 0x92
	private bool isLoading; // 0x93
	internal string strDocumentName; // 0x98
	internal string strDocumentFragmentName; // 0xA0
	internal string strCommentName; // 0xA8
	internal string strTextName; // 0xB0
	internal string strCDataSectionName; // 0xB8
	internal string strEntityName; // 0xC0
	internal string strID; // 0xC8
	internal string strXmlns; // 0xD0
	internal string strXml; // 0xD8
	internal string strSpace; // 0xE0
	internal string strLang; // 0xE8
	internal string strEmpty; // 0xF0
	internal string strNonSignificantWhitespaceName; // 0xF8
	internal string strSignificantWhitespaceName; // 0x100
	internal string strReservedXmlns; // 0x108
	internal string strReservedXml; // 0x110
	internal string baseURI; // 0x118
	private XmlResolver resolver; // 0x120
	internal bool bSetResolver; // 0x128
	internal object objLock; // 0x130
	internal static EmptyEnumerator EmptyEnumerator; // 0x0
	internal static IXmlSchemaInfo NotKnownSchemaInfo; // 0x8
	internal static IXmlSchemaInfo ValidSchemaInfo; // 0x10
	internal static IXmlSchemaInfo InvalidSchemaInfo; // 0x18

	// Properties
	internal SchemaInfo DtdSchemaInfo { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public virtual XmlDocumentType DocumentType { get; }
	internal virtual XmlDeclaration Declaration { get; }
	public XmlImplementation Implementation { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public XmlElement DocumentElement { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlDocument OwnerDocument { get; }
	public XmlSchemaSet Schemas { set; }
	internal bool CanReportValidity { get; }
	internal bool HasSetResolver { get; }
	public virtual XmlResolver XmlResolver { set; }
	public XmlNameTable NameTable { get; }
	public override bool IsReadOnly { get; }
	internal XmlNamedNodeMap Entities { get; set; }
	internal bool IsLoading { get; set; }
	internal bool ActualLoadingStatus { get; }
	public override string InnerText { set; }
	public override string InnerXml { set; }
	internal string Version { get; }
	internal string Encoding { get; }
	internal string Standalone { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string BaseURI { get; }

	// Methods

	// RVA: 0x1C4469C Offset: 0x1C4069C VA: 0x1C4469C
	public void .ctor() { }

	// RVA: 0x1C44C00 Offset: 0x1C40C00 VA: 0x1C44C00
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x1C44760 Offset: 0x1C40760 VA: 0x1C44760
	protected internal void .ctor(XmlImplementation imp) { }

	// RVA: 0x1C44CA8 Offset: 0x1C40CA8 VA: 0x1C44CA8
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x1C44CB0 Offset: 0x1C40CB0 VA: 0x1C44CB0
	internal void set_DtdSchemaInfo(SchemaInfo value) { }

	// RVA: 0x1C40CDC Offset: 0x1C3CCDC VA: 0x1C40CDC
	internal static void CheckName(string name) { }

	// RVA: 0x1C44CB8 Offset: 0x1C40CB8 VA: 0x1C44CB8
	internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1C44CCC Offset: 0x1C40CCC VA: 0x1C44CCC
	internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1C40E04 Offset: 0x1C3CE04 VA: 0x1C40E04
	internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1C44CE0 Offset: 0x1C40CE0 VA: 0x1C44CE0
	internal bool AddIdInfo(XmlName eleName, XmlName attrName) { }

	// RVA: 0x1C44DAC Offset: 0x1C40DAC VA: 0x1C44DAC
	private XmlName GetIDInfoByElement_(XmlName eleName) { }

	// RVA: 0x1C43144 Offset: 0x1C3F144 VA: 0x1C43144
	internal XmlName GetIDInfoByElement(XmlName eleName) { }

	// RVA: 0x1C44E74 Offset: 0x1C40E74 VA: 0x1C44E74
	private WeakReference GetElement(ArrayList elementList, XmlElement elem) { }

	// RVA: 0x1C43158 Offset: 0x1C3F158 VA: 0x1C43158
	internal void AddElementWithId(string id, XmlElement elem) { }

	// RVA: 0x1C4334C Offset: 0x1C3F34C VA: 0x1C4334C
	internal void RemoveElementWithId(string id, XmlElement elem) { }

	// RVA: 0x1C4545C Offset: 0x1C4145C VA: 0x1C4545C Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C4555C Offset: 0x1C4155C VA: 0x1C4555C Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C45564 Offset: 0x1C41564 VA: 0x1C45564 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1C4556C Offset: 0x1C4156C VA: 0x1C4556C Slot: 56
	public virtual XmlDocumentType get_DocumentType() { }

	// RVA: 0x1C455F8 Offset: 0x1C415F8 VA: 0x1C455F8 Slot: 57
	internal virtual XmlDeclaration get_Declaration() { }

	// RVA: 0x1C4569C Offset: 0x1C4169C VA: 0x1C4569C
	public XmlImplementation get_Implementation() { }

	// RVA: 0x1C456A4 Offset: 0x1C416A4 VA: 0x1C456A4 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1C456AC Offset: 0x1C416AC VA: 0x1C456AC Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1C456B4 Offset: 0x1C416B4 VA: 0x1C456B4
	public XmlElement get_DocumentElement() { }

	// RVA: 0x1C45740 Offset: 0x1C41740 VA: 0x1C45740 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x1C45748 Offset: 0x1C41748 VA: 0x1C45748 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1C45750 Offset: 0x1C41750 VA: 0x1C45750 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1C45758 Offset: 0x1C41758 VA: 0x1C45758 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1C45760 Offset: 0x1C41760 VA: 0x1C45760
	public void set_Schemas(XmlSchemaSet value) { }

	// RVA: 0x1C45768 Offset: 0x1C41768 VA: 0x1C45768
	internal bool get_CanReportValidity() { }

	// RVA: 0x1C45770 Offset: 0x1C41770 VA: 0x1C45770
	internal bool get_HasSetResolver() { }

	// RVA: 0x1C45778 Offset: 0x1C41778 VA: 0x1C45778
	internal XmlResolver GetResolver() { }

	// RVA: 0x1C45780 Offset: 0x1C41780 VA: 0x1C45780 Slot: 58
	public virtual void set_XmlResolver(XmlResolver value) { }

	// RVA: 0x1C45918 Offset: 0x1C41918 VA: 0x1C45918 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1C45A04 Offset: 0x1C41A04 VA: 0x1C45A04
	private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x1C45AB8 Offset: 0x1C41AB8 VA: 0x1C45AB8
	private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode) { }

	// RVA: 0x1C45B1C Offset: 0x1C41B1C VA: 0x1C45B1C Slot: 28
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1C45C7C Offset: 0x1C41C7C VA: 0x1C45C7C Slot: 29
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1C45D70 Offset: 0x1C41D70 VA: 0x1C45D70
	public XmlAttribute CreateAttribute(string name) { }

	// RVA: 0x1C45DF0 Offset: 0x1C41DF0 VA: 0x1C45DF0
	internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI) { }

	// RVA: 0x1C45E94 Offset: 0x1C41E94 VA: 0x1C45E94 Slot: 59
	public virtual XmlCDataSection CreateCDataSection(string data) { }

	// RVA: 0x1C45F04 Offset: 0x1C41F04 VA: 0x1C45F04 Slot: 60
	public virtual XmlComment CreateComment(string data) { }

	// RVA: 0x1C45F6C Offset: 0x1C41F6C VA: 0x1C45F6C Slot: 61
	public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1C46100 Offset: 0x1C42100 VA: 0x1C46100 Slot: 62
	public virtual XmlDocumentFragment CreateDocumentFragment() { }

	// RVA: 0x1C461DC Offset: 0x1C421DC VA: 0x1C461DC
	public XmlElement CreateElement(string name) { }

	// RVA: 0x1C4625C Offset: 0x1C4225C VA: 0x1C4625C
	internal void AddDefaultAttributes(XmlElement elem) { }

	// RVA: 0x1C464D8 Offset: 0x1C424D8 VA: 0x1C464D8
	private SchemaElementDecl GetSchemaElementDecl(XmlElement elem) { }

	// RVA: 0x1C465E8 Offset: 0x1C425E8 VA: 0x1C465E8
	private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x1C466E4 Offset: 0x1C426E4 VA: 0x1C466E4 Slot: 63
	public virtual XmlEntityReference CreateEntityReference(string name) { }

	// RVA: 0x1C4684C Offset: 0x1C4284C VA: 0x1C4684C Slot: 64
	public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x1C468C0 Offset: 0x1C428C0 VA: 0x1C468C0 Slot: 65
	public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone) { }

	// RVA: 0x1C46940 Offset: 0x1C42940 VA: 0x1C46940 Slot: 66
	public virtual XmlText CreateTextNode(string text) { }

	// RVA: 0x1C469AC Offset: 0x1C429AC VA: 0x1C469AC Slot: 67
	public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text) { }

	// RVA: 0x1C46A18 Offset: 0x1C42A18 VA: 0x1C46A18 Slot: 68
	public virtual XmlWhitespace CreateWhitespace(string text) { }

	// RVA: 0x1C46A84 Offset: 0x1C42A84 VA: 0x1C46A84
	public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI) { }

	// RVA: 0x1C46B04 Offset: 0x1C42B04 VA: 0x1C46B04
	public XmlElement CreateElement(string qualifiedName, string namespaceURI) { }

	// RVA: 0x1C46B84 Offset: 0x1C42B84 VA: 0x1C46B84
	private XmlNode ImportNodeInternal(XmlNode node, bool deep) { }

	// RVA: 0x1C4707C Offset: 0x1C4307C VA: 0x1C4707C
	private void ImportAttributes(XmlNode fromElem, XmlNode toElem) { }

	// RVA: 0x1C454C4 Offset: 0x1C414C4 VA: 0x1C454C4
	private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep) { }

	// RVA: 0x1C406B4 Offset: 0x1C3C6B4 VA: 0x1C406B4
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1C47190 Offset: 0x1C43190 VA: 0x1C47190 Slot: 69
	public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x1C47228 Offset: 0x1C43228 VA: 0x1C47228 Slot: 70
	protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x1C472AC Offset: 0x1C432AC VA: 0x1C472AC Slot: 71
	public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI) { }

	// RVA: 0x1C474B0 Offset: 0x1C434B0 VA: 0x1C474B0 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x1C474B8 Offset: 0x1C434B8 VA: 0x1C474B8
	internal XmlNamedNodeMap get_Entities() { }

	// RVA: 0x1C47530 Offset: 0x1C43530 VA: 0x1C47530
	internal void set_Entities(XmlNamedNodeMap value) { }

	// RVA: 0x1C47538 Offset: 0x1C43538 VA: 0x1C47538
	internal bool get_IsLoading() { }

	// RVA: 0x1C47540 Offset: 0x1C43540 VA: 0x1C47540
	internal void set_IsLoading(bool value) { }

	// RVA: 0x1C47548 Offset: 0x1C43548 VA: 0x1C47548
	internal bool get_ActualLoadingStatus() { }

	// RVA: 0x1C47550 Offset: 0x1C43550 VA: 0x1C47550 Slot: 72
	public virtual XmlNode ReadNode(XmlReader reader) { }

	// RVA: 0x1C4776C Offset: 0x1C4376C VA: 0x1C4776C
	private XmlTextReader SetupReader(XmlTextReader tr) { }

	// RVA: 0x1C477CC Offset: 0x1C437CC VA: 0x1C477CC Slot: 73
	public virtual void Load(XmlReader reader) { }

	// RVA: 0x1C47B3C Offset: 0x1C43B3C VA: 0x1C47B3C Slot: 74
	public virtual void LoadXml(string xml) { }

	// RVA: 0x1C47C84 Offset: 0x1C43C84 VA: 0x1C47C84 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x1C47CDC Offset: 0x1C43CDC VA: 0x1C47CDC Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x1C47CEC Offset: 0x1C43CEC VA: 0x1C47CEC Slot: 75
	public virtual void Save(XmlWriter w) { }

	// RVA: 0x1C47F04 Offset: 0x1C43F04 VA: 0x1C47F04 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C47F14 Offset: 0x1C43F14 VA: 0x1C47F14 Slot: 44
	public override void WriteContentTo(XmlWriter xw) { }

	// RVA: 0x1C481AC Offset: 0x1C441AC VA: 0x1C481AC Slot: 50
	internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x1C41634 Offset: 0x1C3D634 VA: 0x1C41634
	internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent) { }

	// RVA: 0x1C482A4 Offset: 0x1C442A4 VA: 0x1C482A4 Slot: 51
	internal override void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x1C482F8 Offset: 0x1C442F8 VA: 0x1C482F8 Slot: 52
	internal override void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x1C42EB0 Offset: 0x1C3EEB0 VA: 0x1C42EB0
	internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI) { }

	// RVA: 0x1C4834C Offset: 0x1C4434C VA: 0x1C4834C
	internal string get_Version() { }

	// RVA: 0x1C48370 Offset: 0x1C44370 VA: 0x1C48370
	internal string get_Encoding() { }

	// RVA: 0x1C47EE0 Offset: 0x1C43EE0 VA: 0x1C47EE0
	internal string get_Standalone() { }

	// RVA: 0x1C48394 Offset: 0x1C44394 VA: 0x1C48394
	internal XmlEntity GetEntityNode(string name) { }

	// RVA: 0x1C484D0 Offset: 0x1C444D0 VA: 0x1C484D0 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1C4861C Offset: 0x1C4461C VA: 0x1C4861C Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x1C48624 Offset: 0x1C44624 VA: 0x1C48624
	internal void SetBaseURI(string inBaseURI) { }

	// RVA: 0x1C48634 Offset: 0x1C44634 VA: 0x1C48634 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x1C48824 Offset: 0x1C44824 VA: 0x1C48824
	private static void .cctor() { }
}

// Namespace: System.Xml
public class XmlDocumentFragment : XmlNode // TypeDefIndex: 3191
{
	// Fields
	private XmlLinkedNode lastChild; // 0x18

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	public override string InnerXml { set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }

	// Methods

	// RVA: 0x1C46158 Offset: 0x1C42158 VA: 0x1C46158
	protected internal void .ctor(XmlDocument ownerDocument) { }

	// RVA: 0x1C48940 Offset: 0x1C44940 VA: 0x1C48940 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1C48968 Offset: 0x1C44968 VA: 0x1C48968 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1C48990 Offset: 0x1C44990 VA: 0x1C48990 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C48998 Offset: 0x1C44998 VA: 0x1C48998 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1C489A0 Offset: 0x1C449A0 VA: 0x1C489A0 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1C48A18 Offset: 0x1C44A18 VA: 0x1C48A18 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x1C48CC8 Offset: 0x1C44CC8 VA: 0x1C48CC8 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C48D4C Offset: 0x1C44D4C VA: 0x1C48D4C Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x1C48D54 Offset: 0x1C44D54 VA: 0x1C48D54 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1C48D5C Offset: 0x1C44D5C VA: 0x1C48D5C Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1C48D64 Offset: 0x1C44D64 VA: 0x1C48D64 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1C48DD8 Offset: 0x1C44DD8 VA: 0x1C48DD8 Slot: 29
	internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1C48E48 Offset: 0x1C44E48 VA: 0x1C48E48 Slot: 28
	internal override bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1C48EB0 Offset: 0x1C44EB0 VA: 0x1C48EB0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C48EC0 Offset: 0x1C44EC0 VA: 0x1C48EC0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }
}

// Namespace: System.Xml
public class XmlDocumentType : XmlLinkedNode // TypeDefIndex: 3192
{
	// Fields
	private string name; // 0x20
	private string publicId; // 0x28
	private string systemId; // 0x30
	private string internalSubset; // 0x38
	private bool namespaces; // 0x40
	private XmlNamedNodeMap entities; // 0x48
	private XmlNamedNodeMap notations; // 0x50
	private SchemaInfo schemaInfo; // 0x58

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public XmlNamedNodeMap Entities { get; }
	public XmlNamedNodeMap Notations { get; }
	public string PublicId { get; }
	public string SystemId { get; }
	public string InternalSubset { get; }
	internal bool ParseWithNamespaces { get; }
	internal SchemaInfo DtdSchemaInfo { get; set; }

	// Methods

	// RVA: 0x1C45FF4 Offset: 0x1C41FF4 VA: 0x1C45FF4
	protected internal void .ctor(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) { }

	// RVA: 0x1C491C0 Offset: 0x1C451C0 VA: 0x1C491C0 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1C491C8 Offset: 0x1C451C8 VA: 0x1C491C8 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1C491D0 Offset: 0x1C451D0 VA: 0x1C491D0 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C491D8 Offset: 0x1C451D8 VA: 0x1C491D8 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C49214 Offset: 0x1C45214 VA: 0x1C49214 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x1C48458 Offset: 0x1C44458 VA: 0x1C48458
	public XmlNamedNodeMap get_Entities() { }

	// RVA: 0x1C4921C Offset: 0x1C4521C VA: 0x1C4921C
	public XmlNamedNodeMap get_Notations() { }

	// RVA: 0x1C49294 Offset: 0x1C45294 VA: 0x1C49294
	public string get_PublicId() { }

	// RVA: 0x1C4929C Offset: 0x1C4529C VA: 0x1C4929C
	public string get_SystemId() { }

	// RVA: 0x1C492A4 Offset: 0x1C452A4 VA: 0x1C492A4
	public string get_InternalSubset() { }

	// RVA: 0x1C492AC Offset: 0x1C452AC VA: 0x1C492AC
	internal bool get_ParseWithNamespaces() { }

	// RVA: 0x1C492B4 Offset: 0x1C452B4 VA: 0x1C492B4 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C492DC Offset: 0x1C452DC VA: 0x1C492DC Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1C492E0 Offset: 0x1C452E0 VA: 0x1C492E0
	internal SchemaInfo get_DtdSchemaInfo() { }

	// RVA: 0x1C492E8 Offset: 0x1C452E8 VA: 0x1C492E8
	internal void set_DtdSchemaInfo(SchemaInfo value) { }
}

// Namespace: System.Xml
public class XmlElement : XmlLinkedNode // TypeDefIndex: 3193
{
	// Fields
	private XmlName name; // 0x20
	private XmlAttributeCollection attributes; // 0x28
	private XmlLinkedNode lastChild; // 0x30

	// Properties
	internal XmlName XmlName { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; set; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override XmlDocument OwnerDocument { get; }
	internal override bool IsContainer { get; }
	public bool IsEmpty { get; set; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlAttributeCollection Attributes { get; }
	public virtual bool HasAttributes { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override string InnerXml { set; }
	public override string InnerText { get; set; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0x1C4735C Offset: 0x1C4335C VA: 0x1C4735C
	internal void .ctor(XmlName name, bool empty, XmlDocument doc) { }

	// RVA: 0x1C492F0 Offset: 0x1C452F0 VA: 0x1C492F0
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x1C49334 Offset: 0x1C45334 VA: 0x1C49334
	internal XmlName get_XmlName() { }

	// RVA: 0x1C4933C Offset: 0x1C4533C VA: 0x1C4933C
	internal void set_XmlName(XmlName value) { }

	// RVA: 0x1C49344 Offset: 0x1C45344 VA: 0x1C49344 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C498B8 Offset: 0x1C458B8 VA: 0x1C498B8 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1C498D0 Offset: 0x1C458D0 VA: 0x1C498D0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1C498E8 Offset: 0x1C458E8 VA: 0x1C498E8 Slot: 33
	public override string get_NamespaceURI() { }

	// RVA: 0x1C49900 Offset: 0x1C45900 VA: 0x1C49900 Slot: 34
	public override string get_Prefix() { }

	// RVA: 0x1C49918 Offset: 0x1C45918 VA: 0x1C49918 Slot: 35
	public override void set_Prefix(string value) { }

	// RVA: 0x1C499C4 Offset: 0x1C459C4 VA: 0x1C499C4 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C499CC Offset: 0x1C459CC VA: 0x1C499CC Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1C499D4 Offset: 0x1C459D4 VA: 0x1C499D4 Slot: 15
	public override XmlDocument get_OwnerDocument() { }

	// RVA: 0x1C499EC Offset: 0x1C459EC VA: 0x1C499EC Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x1C499F4 Offset: 0x1C459F4 VA: 0x1C499F4 Slot: 26
	internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x1C49840 Offset: 0x1C45840 VA: 0x1C49840
	public bool get_IsEmpty() { }

	// RVA: 0x1C49850 Offset: 0x1C45850 VA: 0x1C49850
	public void set_IsEmpty(bool value) { }

	// RVA: 0x1C49BAC Offset: 0x1C45BAC VA: 0x1C49BAC Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1C49BBC Offset: 0x1C45BBC VA: 0x1C49BBC Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1C49BC4 Offset: 0x1C45BC4 VA: 0x1C49BC4 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1C49BDC Offset: 0x1C45BDC VA: 0x1C49BDC Slot: 14
	public override XmlAttributeCollection get_Attributes() { }

	// RVA: 0x1C49D20 Offset: 0x1C45D20 VA: 0x1C49D20 Slot: 56
	public virtual bool get_HasAttributes() { }

	// RVA: 0x1C49D48 Offset: 0x1C45D48 VA: 0x1C49D48 Slot: 57
	public virtual string GetAttribute(string name) { }

	// RVA: 0x1C49D8C Offset: 0x1C45D8C VA: 0x1C49D8C Slot: 58
	public virtual void SetAttribute(string name, string value) { }

	// RVA: 0x1C49E30 Offset: 0x1C45E30 VA: 0x1C49E30 Slot: 59
	public virtual XmlAttribute GetAttributeNode(string name) { }

	// RVA: 0x1C49E94 Offset: 0x1C45E94 VA: 0x1C49E94 Slot: 60
	public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr) { }

	// RVA: 0x1C49FA4 Offset: 0x1C45FA4 VA: 0x1C49FA4 Slot: 61
	public virtual string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1C49FE8 Offset: 0x1C45FE8 VA: 0x1C49FE8 Slot: 62
	public virtual string SetAttribute(string localName, string namespaceURI, string value) { }

	// RVA: 0x1C4A0C0 Offset: 0x1C460C0 VA: 0x1C4A0C0 Slot: 63
	public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x1C4A12C Offset: 0x1C4612C VA: 0x1C4A12C Slot: 64
	public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI) { }

	// RVA: 0x1C4A1DC Offset: 0x1C461DC VA: 0x1C4A1DC Slot: 65
	public virtual bool HasAttribute(string name) { }

	// RVA: 0x1C4A200 Offset: 0x1C46200 VA: 0x1C4A200 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C4A308 Offset: 0x1C46308 VA: 0x1C4A308
	private static void WriteElementTo(XmlWriter writer, XmlElement e) { }

	// RVA: 0x1C4A4E0 Offset: 0x1C464E0 VA: 0x1C4A4E0
	private void WriteStartElement(XmlWriter w) { }

	// RVA: 0x1C4A5F8 Offset: 0x1C465F8 VA: 0x1C4A5F8 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1C4A660 Offset: 0x1C46660 VA: 0x1C4A660 Slot: 66
	public virtual void RemoveAllAttributes() { }

	// RVA: 0x1C4A698 Offset: 0x1C46698 VA: 0x1C4A698 Slot: 45
	public override void RemoveAll() { }

	// RVA: 0x1C49BA4 Offset: 0x1C45BA4 VA: 0x1C49BA4
	internal void RemoveAllChildren() { }

	// RVA: 0x1C4A6C0 Offset: 0x1C466C0 VA: 0x1C4A6C0 Slot: 41
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1C4A6C8 Offset: 0x1C466C8 VA: 0x1C4A6C8 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x1C4A7BC Offset: 0x1C467BC VA: 0x1C4A7BC Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x1C4A7C4 Offset: 0x1C467C4 VA: 0x1C4A7C4 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x1C4A880 Offset: 0x1C46880 VA: 0x1C4A880 Slot: 13
	public override XmlNode get_NextSibling() { }

	// RVA: 0x1C4A8BC Offset: 0x1C468BC VA: 0x1C4A8BC Slot: 47
	internal override void SetParent(XmlNode node) { }
}

// Namespace: System.Xml
public class XmlEntity : XmlNode // TypeDefIndex: 3194
{
	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string notationName; // 0x28
	private string name; // 0x30
	private string unparsedReplacementStr; // 0x38
	private string baseURI; // 0x40
	private XmlLinkedNode lastChild; // 0x48
	private bool childrenFoliating; // 0x50

	// Properties
	public override bool IsReadOnly { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string InnerText { get; set; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override XmlNodeType NodeType { get; }
	public string SystemId { get; }
	public override string InnerXml { set; }
	public override string BaseURI { get; }

	// Methods

	// RVA: 0x1C4A8C4 Offset: 0x1C468C4 VA: 0x1C4A8C4
	internal void .ctor(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) { }

	// RVA: 0x1C4A98C Offset: 0x1C4698C VA: 0x1C4A98C Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C4A9E4 Offset: 0x1C469E4 VA: 0x1C4A9E4 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x1C4A9EC Offset: 0x1C469EC VA: 0x1C4A9EC Slot: 6
	public override string get_Name() { }

	// RVA: 0x1C4A9F4 Offset: 0x1C469F4 VA: 0x1C4A9F4 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1C4A9FC Offset: 0x1C469FC VA: 0x1C4A9FC Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x1C4AA04 Offset: 0x1C46A04 VA: 0x1C4AA04 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x1C4AA5C Offset: 0x1C46A5C VA: 0x1C4AA5C Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x1C4AA64 Offset: 0x1C46A64 VA: 0x1C4AA64 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1C4AB3C Offset: 0x1C46B3C VA: 0x1C4AB3C Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1C4AB44 Offset: 0x1C46B44 VA: 0x1C4AB44 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1C4AB5C Offset: 0x1C46B5C VA: 0x1C4AB5C Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C4AB64 Offset: 0x1C46B64 VA: 0x1C4AB64
	public string get_SystemId() { }

	// RVA: 0x1C4AB6C Offset: 0x1C46B6C VA: 0x1C4AB6C Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x1C4ABC4 Offset: 0x1C46BC4 VA: 0x1C4ABC4 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C4ABC8 Offset: 0x1C46BC8 VA: 0x1C4ABC8 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1C4ABCC Offset: 0x1C46BCC VA: 0x1C4ABCC Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x1C4ABD4 Offset: 0x1C46BD4 VA: 0x1C4ABD4
	internal void SetBaseURI(string inBaseURI) { }
}

// Namespace: System.Xml
public class XmlEntityReference : XmlLinkedNode // TypeDefIndex: 3195
{
	// Fields
	private string name; // 0x20
	private XmlLinkedNode lastChild; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	internal override bool IsContainer { get; }
	internal override XmlLinkedNode LastNode { get; set; }
	public override string BaseURI { get; }
	internal string ChildBaseURI { get; }

	// Methods

	// RVA: 0x1C4674C Offset: 0x1C4274C VA: 0x1C4674C
	protected internal void .ctor(string name, XmlDocument doc) { }

	// RVA: 0x1C4ABDC Offset: 0x1C46BDC VA: 0x1C4ABDC Slot: 6
	public override string get_Name() { }

	// RVA: 0x1C4ABE4 Offset: 0x1C46BE4 VA: 0x1C4ABE4 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1C4ABEC Offset: 0x1C46BEC VA: 0x1C4ABEC Slot: 7
	public override string get_Value() { }

	// RVA: 0x1C4ABF4 Offset: 0x1C46BF4 VA: 0x1C4ABF4 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1C4AC4C Offset: 0x1C46C4C VA: 0x1C4AC4C Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C4AC54 Offset: 0x1C46C54 VA: 0x1C4AC54 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C4AC8C Offset: 0x1C46C8C VA: 0x1C4AC8C Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x1C4AC94 Offset: 0x1C46C94 VA: 0x1C4AC94 Slot: 18
	internal override bool get_IsContainer() { }

	// RVA: 0x1C4AC9C Offset: 0x1C46C9C VA: 0x1C4AC9C Slot: 47
	internal override void SetParent(XmlNode node) { }

	// RVA: 0x1C4B328 Offset: 0x1C47328 VA: 0x1C4B328 Slot: 48
	internal override void SetParentForLoad(XmlNode node) { }

	// RVA: 0x1C4B338 Offset: 0x1C47338 VA: 0x1C4B338 Slot: 19
	internal override XmlLinkedNode get_LastNode() { }

	// RVA: 0x1C4B340 Offset: 0x1C47340 VA: 0x1C4B340 Slot: 20
	internal override void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1C4B348 Offset: 0x1C47348 VA: 0x1C4B348 Slot: 27
	internal override bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1C4B360 Offset: 0x1C47360 VA: 0x1C4B360 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C4B388 Offset: 0x1C47388 VA: 0x1C4B388 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1C4B620 Offset: 0x1C47620 VA: 0x1C4B620 Slot: 42
	public override string get_BaseURI() { }

	// RVA: 0x1C4B650 Offset: 0x1C47650 VA: 0x1C4B650
	private string ConstructBaseURI(string baseURI, string systemId) { }

	// RVA: 0x1C4B728 Offset: 0x1C47728 VA: 0x1C4B728
	internal string get_ChildBaseURI() { }
}

// Namespace: System.Xml
public enum XmlNodeChangedAction // TypeDefIndex: 3196
{
	// Fields
	public int value__; // 0x0
	public const XmlNodeChangedAction Insert = 0;
	public const XmlNodeChangedAction Remove = 1;
	public const XmlNodeChangedAction Change = 2;
}

// Namespace: System.Xml
public class XmlImplementation // TypeDefIndex: 3197
{
	// Fields
	private XmlNameTable nameTable; // 0x10

	// Properties
	internal XmlNameTable NameTable { get; }

	// Methods

	// RVA: 0x1C446F4 Offset: 0x1C406F4 VA: 0x1C446F4
	public void .ctor() { }

	// RVA: 0x1C44C78 Offset: 0x1C40C78 VA: 0x1C44C78
	public void .ctor(XmlNameTable nt) { }

	// RVA: 0x1C4B7C4 Offset: 0x1C477C4 VA: 0x1C4B7C4 Slot: 4
	public virtual XmlDocument CreateDocument() { }

	// RVA: 0x1C4B81C Offset: 0x1C4781C VA: 0x1C4B81C
	internal XmlNameTable get_NameTable() { }
}

// Namespace: System.Xml
public abstract class XmlLinkedNode : XmlNode // TypeDefIndex: 3198
{
	// Fields
	internal XmlLinkedNode next; // 0x18

	// Properties
	public override XmlNode PreviousSibling { get; }
	public override XmlNode NextSibling { get; }

	// Methods

	// RVA: 0x1C4365C Offset: 0x1C3F65C VA: 0x1C4365C
	internal void .ctor(XmlDocument doc) { }

	// RVA: 0x1C4B824 Offset: 0x1C47824 VA: 0x1C4B824 Slot: 12
	public override XmlNode get_PreviousSibling() { }

	// RVA: 0x1C4B88C Offset: 0x1C4788C VA: 0x1C4B88C Slot: 13
	public override XmlNode get_NextSibling() { }
}

// Namespace: System.Xml
internal class XmlLoader // TypeDefIndex: 3199
{
	// Fields
	private XmlDocument doc; // 0x10
	private XmlReader reader; // 0x18
	private bool preserveWhitespace; // 0x20

	// Methods

	// RVA: 0x1C41AA4 Offset: 0x1C3DAA4 VA: 0x1C41AA4
	public void .ctor() { }

	// RVA: 0x1C478D8 Offset: 0x1C438D8 VA: 0x1C478D8
	internal void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace) { }

	// RVA: 0x1C4B8DC Offset: 0x1C478DC VA: 0x1C4B8DC
	private void LoadDocSequence(XmlDocument parentDoc) { }

	// RVA: 0x1C47628 Offset: 0x1C43628 VA: 0x1C47628
	internal XmlNode ReadCurrentNode(XmlDocument doc, XmlReader reader) { }

	// RVA: 0x1C4B948 Offset: 0x1C47948 VA: 0x1C4B948
	private XmlNode LoadNode(bool skipOverWhitespace) { }

	// RVA: 0x1C4BECC Offset: 0x1C47ECC VA: 0x1C4BECC
	private XmlAttribute LoadAttributeNode() { }

	// RVA: 0x1C4C818 Offset: 0x1C48818 VA: 0x1C4C818
	private XmlAttribute LoadDefaultAttribute() { }

	// RVA: 0x1C4C9C8 Offset: 0x1C489C8 VA: 0x1C4C9C8
	private void LoadAttributeValue(XmlNode parent, bool direct) { }

	// RVA: 0x1C4C1E0 Offset: 0x1C481E0 VA: 0x1C4C1E0
	private XmlEntityReference LoadEntityReferenceNode(bool direct) { }

	// RVA: 0x1C4C3BC Offset: 0x1C483BC VA: 0x1C4C3BC
	private XmlDeclaration LoadDeclarationNode() { }

	// RVA: 0x1C4C55C Offset: 0x1C4855C VA: 0x1C4C55C
	private XmlDocumentType LoadDocumentTypeNode() { }

	// RVA: 0x1C4CCC8 Offset: 0x1C48CC8 VA: 0x1C4CCC8
	private XmlNode LoadNodeDirect() { }

	// RVA: 0x1C4DC58 Offset: 0x1C49C58 VA: 0x1C4DC58
	private XmlAttribute LoadAttributeNodeDirect() { }

	// RVA: 0x1C49158 Offset: 0x1C45158 VA: 0x1C49158
	internal void ParseDocumentType(XmlDocumentType dtNode) { }

	// RVA: 0x1C4DD98 Offset: 0x1C49D98 VA: 0x1C4DD98
	private void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver) { }

	// RVA: 0x1C4D150 Offset: 0x1C49150 VA: 0x1C4D150
	private void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode) { }

	// RVA: 0x1C4E064 Offset: 0x1C4A064 VA: 0x1C4E064
	private XmlParserContext GetContext(XmlNode node) { }

	// RVA: 0x1C48AA4 Offset: 0x1C44AA4 VA: 0x1C48AA4
	internal XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt) { }

	// RVA: 0x1C4A748 Offset: 0x1C46748 VA: 0x1C4A748
	internal void LoadInnerXmlElement(XmlElement node, string innerxmltext) { }

	// RVA: 0x1C41AAC Offset: 0x1C3DAAC VA: 0x1C41AAC
	internal void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext) { }

	// RVA: 0x1C4EB88 Offset: 0x1C4AB88 VA: 0x1C4EB88
	private void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs) { }

	// RVA: 0x1C4EE28 Offset: 0x1C4AE28 VA: 0x1C4EE28
	private string EntitizeName(string name) { }

	// RVA: 0x1C4AAF0 Offset: 0x1C46AF0 VA: 0x1C4AAF0
	internal void ExpandEntity(XmlEntity ent) { }

	// RVA: 0x1C4AD58 Offset: 0x1C46D58 VA: 0x1C4AD58
	internal void ExpandEntityReference(XmlEntityReference eref) { }

	// RVA: 0x1C4E8F8 Offset: 0x1C4A8F8 VA: 0x1C4E8F8
	private XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc) { }

	// RVA: 0x1C44304 Offset: 0x1C40304 VA: 0x1C44304
	internal static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone) { }

	// RVA: 0x1C4C708 Offset: 0x1C48708 VA: 0x1C4C708
	internal static Exception UnexpectedNodeType(XmlNodeType nodetype) { }
}

// Namespace: System.Xml
internal class XmlName : IXmlSchemaInfo // TypeDefIndex: 3200
{
	// Fields
	private string prefix; // 0x10
	private string localName; // 0x18
	private string ns; // 0x20
	private string name; // 0x28
	private int hashCode; // 0x30
	internal XmlDocument ownerDoc; // 0x38
	internal XmlName next; // 0x40

	// Properties
	public string LocalName { get; }
	public string NamespaceURI { get; }
	public string Prefix { get; }
	public int HashCode { get; }
	public XmlDocument OwnerDocument { get; }
	public string Name { get; }
	public virtual XmlSchemaValidity Validity { get; }
	public virtual bool IsDefault { get; }
	public virtual bool IsNil { get; }
	public virtual XmlSchemaSimpleType MemberType { get; }
	public virtual XmlSchemaType SchemaType { get; }
	public virtual XmlSchemaElement SchemaElement { get; }
	public virtual XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x1C4EE9C Offset: 0x1C4AE9C VA: 0x1C4EE9C
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1C4EF88 Offset: 0x1C4AF88 VA: 0x1C4EF88
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0x1C4F420 Offset: 0x1C4B420 VA: 0x1C4F420
	public string get_LocalName() { }

	// RVA: 0x1C4F428 Offset: 0x1C4B428 VA: 0x1C4F428
	public string get_NamespaceURI() { }

	// RVA: 0x1C4F430 Offset: 0x1C4B430 VA: 0x1C4F430
	public string get_Prefix() { }

	// RVA: 0x1C4F438 Offset: 0x1C4B438 VA: 0x1C4F438
	public int get_HashCode() { }

	// RVA: 0x1C4F440 Offset: 0x1C4B440 VA: 0x1C4F440
	public XmlDocument get_OwnerDocument() { }

	// RVA: 0x1C4F448 Offset: 0x1C4B448 VA: 0x1C4F448
	public string get_Name() { }

	// RVA: 0x1C4F618 Offset: 0x1C4B618 VA: 0x1C4F618 Slot: 11
	public virtual XmlSchemaValidity get_Validity() { }

	// RVA: 0x1C4F620 Offset: 0x1C4B620 VA: 0x1C4F620 Slot: 12
	public virtual bool get_IsDefault() { }

	// RVA: 0x1C4F628 Offset: 0x1C4B628 VA: 0x1C4F628 Slot: 13
	public virtual bool get_IsNil() { }

	// RVA: 0x1C4F630 Offset: 0x1C4B630 VA: 0x1C4F630 Slot: 14
	public virtual XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x1C4F638 Offset: 0x1C4B638 VA: 0x1C4F638 Slot: 15
	public virtual XmlSchemaType get_SchemaType() { }

	// RVA: 0x1C4F640 Offset: 0x1C4B640 VA: 0x1C4F640 Slot: 16
	public virtual XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x1C4F648 Offset: 0x1C4B648 VA: 0x1C4F648 Slot: 17
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x1C4F650 Offset: 0x1C4B650 VA: 0x1C4F650 Slot: 18
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1C4F65C Offset: 0x1C4B65C VA: 0x1C4F65C
	public static int GetHashCode(string name) { }
}

// Namespace: System.Xml
internal sealed class XmlNameEx : XmlName // TypeDefIndex: 3201
{
	// Fields
	private byte flags; // 0x48
	private XmlSchemaSimpleType memberType; // 0x50
	private XmlSchemaType schemaType; // 0x58
	private object decl; // 0x60

	// Properties
	public override XmlSchemaValidity Validity { get; }
	public override bool IsDefault { get; }
	public override bool IsNil { get; }
	public override XmlSchemaSimpleType MemberType { get; }
	public override XmlSchemaType SchemaType { get; }
	public override XmlSchemaElement SchemaElement { get; }
	public override XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x1C4F030 Offset: 0x1C4B030 VA: 0x1C4F030
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x1C4F720 Offset: 0x1C4B720 VA: 0x1C4F720 Slot: 11
	public override XmlSchemaValidity get_Validity() { }

	// RVA: 0x1C4F74C Offset: 0x1C4B74C VA: 0x1C4F74C Slot: 12
	public override bool get_IsDefault() { }

	// RVA: 0x1C4F758 Offset: 0x1C4B758 VA: 0x1C4F758 Slot: 13
	public override bool get_IsNil() { }

	// RVA: 0x1C4F764 Offset: 0x1C4B764 VA: 0x1C4F764 Slot: 14
	public override XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x1C4F76C Offset: 0x1C4B76C VA: 0x1C4F76C Slot: 15
	public override XmlSchemaType get_SchemaType() { }

	// RVA: 0x1C4F774 Offset: 0x1C4B774 VA: 0x1C4F774 Slot: 16
	public override XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x1C4F7F0 Offset: 0x1C4B7F0 VA: 0x1C4F7F0 Slot: 17
	public override XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x1C4F6CC Offset: 0x1C4B6CC VA: 0x1C4F6CC
	public void SetValidity(XmlSchemaValidity value) { }

	// RVA: 0x1C4F6E0 Offset: 0x1C4B6E0 VA: 0x1C4F6E0
	public void SetIsDefault(bool value) { }

	// RVA: 0x1C4F700 Offset: 0x1C4B700 VA: 0x1C4F700
	public void SetIsNil(bool value) { }

	// RVA: 0x1C4F86C Offset: 0x1C4B86C VA: 0x1C4F86C Slot: 18
	public override bool Equals(IXmlSchemaInfo schemaInfo) { }
}

// Namespace: 
private class XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator : IEnumerator // TypeDefIndex: 3202
{
	// Fields
	private object loneValue; // 0x10
	private int position; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1C50AF8 Offset: 0x1C4CAF8 VA: 0x1C50AF8
	public void .ctor(object value) { }

	// RVA: 0x1C50B30 Offset: 0x1C4CB30 VA: 0x1C50B30 Slot: 5
	public object get_Current() { }

	// RVA: 0x1C50B78 Offset: 0x1C4CB78 VA: 0x1C50B78 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1C50B94 Offset: 0x1C4CB94 VA: 0x1C50B94 Slot: 6
	public void Reset() { }
}

// Namespace: 
[DefaultMember("Item")]
internal struct XmlNamedNodeMap.SmallXmlNodeList // TypeDefIndex: 3203
{
	// Fields
	private object field; // 0x0

	// Properties
	public int Count { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x1C50068 Offset: 0x1C4C068 VA: 0x1C50068
	public int get_Count() { }

	// RVA: 0x1C4FD58 Offset: 0x1C4BD58 VA: 0x1C4FD58
	public object get_Item(int index) { }

	// RVA: 0x1C50390 Offset: 0x1C4C390 VA: 0x1C50390
	public void Add(object value) { }

	// RVA: 0x1C506C4 Offset: 0x1C4C6C4 VA: 0x1C506C4
	public void RemoveAt(int index) { }

	// RVA: 0x1C50950 Offset: 0x1C4C950 VA: 0x1C50950
	public void Insert(int index, object value) { }

	// RVA: 0x1C500FC Offset: 0x1C4C0FC VA: 0x1C500FC
	public IEnumerator GetEnumerator() { }
}

// Namespace: System.Xml
public class XmlNamedNodeMap : IEnumerable // TypeDefIndex: 3204
{
	// Fields
	internal XmlNode parent; // 0x10
	internal XmlNamedNodeMap.SmallXmlNodeList nodes; // 0x18

	// Properties
	public virtual int Count { get; }

	// Methods

	// RVA: 0x1C4FBB0 Offset: 0x1C4BBB0 VA: 0x1C4FBB0
	internal void .ctor(XmlNode parent) { }

	// RVA: 0x1C4FBE0 Offset: 0x1C4BBE0 VA: 0x1C4FBE0 Slot: 5
	public virtual XmlNode GetNamedItem(string name) { }

	// RVA: 0x1C4FE34 Offset: 0x1C4BE34 VA: 0x1C4FE34 Slot: 6
	public virtual XmlNode SetNamedItem(XmlNode node) { }

	// RVA: 0x1C50060 Offset: 0x1C4C060 VA: 0x1C50060 Slot: 7
	public virtual int get_Count() { }

	// RVA: 0x1C500F4 Offset: 0x1C4C0F4 VA: 0x1C500F4 Slot: 8
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1C4FC78 Offset: 0x1C4BC78 VA: 0x1C4FC78
	internal int FindNodeOffset(string name) { }

	// RVA: 0x1C4FEF0 Offset: 0x1C4BEF0 VA: 0x1C4FEF0
	internal int FindNodeOffset(string localName, string namespaceURI) { }

	// RVA: 0x1C50200 Offset: 0x1C4C200 VA: 0x1C50200 Slot: 9
	internal virtual XmlNode AddNode(XmlNode node) { }

	// RVA: 0x1C504BC Offset: 0x1C4C4BC VA: 0x1C504BC Slot: 10
	internal virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc) { }

	// RVA: 0x1C50564 Offset: 0x1C4C564 VA: 0x1C50564 Slot: 11
	internal virtual XmlNode RemoveNodeAt(int i) { }

	// RVA: 0x1C5000C Offset: 0x1C4C00C VA: 0x1C5000C
	internal XmlNode ReplaceNodeAt(int i, XmlNode node) { }

	// RVA: 0x1C507AC Offset: 0x1C4C7AC VA: 0x1C507AC Slot: 12
	internal virtual XmlNode InsertNodeAt(int i, XmlNode node) { }
}

// Namespace: System.Xml
[DebuggerDisplay("{debuggerDisplayProxy}")]
[DefaultMember("Item")]
public abstract class XmlNode : ICloneable, IEnumerable // TypeDefIndex: 3205
{
	// Fields
	internal XmlNode parentNode; // 0x10

	// Properties
	public abstract string Name { get; }
	public virtual string Value { get; set; }
	public abstract XmlNodeType NodeType { get; }
	public virtual XmlNode ParentNode { get; }
	public virtual XmlNodeList ChildNodes { get; }
	public virtual XmlNode PreviousSibling { get; }
	public virtual XmlNode NextSibling { get; }
	public virtual XmlAttributeCollection Attributes { get; }
	public virtual XmlDocument OwnerDocument { get; }
	public virtual XmlNode FirstChild { get; }
	public virtual XmlNode LastChild { get; }
	internal virtual bool IsContainer { get; }
	internal virtual XmlLinkedNode LastNode { get; set; }
	public virtual bool HasChildNodes { get; }
	public virtual string NamespaceURI { get; }
	public virtual string Prefix { get; set; }
	public abstract string LocalName { get; }
	public virtual bool IsReadOnly { get; }
	public virtual string InnerText { get; set; }
	public virtual string InnerXml { set; }
	public virtual IXmlSchemaInfo SchemaInfo { get; }
	public virtual string BaseURI { get; }
	internal XmlDocument Document { get; }
	internal virtual XmlSpace XmlSpace { get; }
	internal virtual string XmlLang { get; }
	internal virtual bool IsText { get; }

	// Methods

	// RVA: 0x1C50BA0 Offset: 0x1C4CBA0 VA: 0x1C50BA0
	internal void .ctor() { }

	// RVA: 0x1C50BA8 Offset: 0x1C4CBA8 VA: 0x1C50BA8
	internal void .ctor(XmlDocument doc) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_Name();

	// RVA: 0x1C50C2C Offset: 0x1C4CC2C VA: 0x1C50C2C Slot: 7
	public virtual string get_Value() { }

	// RVA: 0x1C50C34 Offset: 0x1C4CC34 VA: 0x1C50C34 Slot: 8
	public virtual void set_Value(string value) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract XmlNodeType get_NodeType();

	// RVA: 0x1C50D00 Offset: 0x1C4CD00 VA: 0x1C50D00 Slot: 10
	public virtual XmlNode get_ParentNode() { }

	// RVA: 0x1C50DE8 Offset: 0x1C4CDE8 VA: 0x1C50DE8 Slot: 11
	public virtual XmlNodeList get_ChildNodes() { }

	// RVA: 0x1C50E44 Offset: 0x1C4CE44 VA: 0x1C50E44 Slot: 12
	public virtual XmlNode get_PreviousSibling() { }

	// RVA: 0x1C50E4C Offset: 0x1C4CE4C VA: 0x1C50E4C Slot: 13
	public virtual XmlNode get_NextSibling() { }

	// RVA: 0x1C50E54 Offset: 0x1C4CE54 VA: 0x1C50E54 Slot: 14
	public virtual XmlAttributeCollection get_Attributes() { }

	// RVA: 0x1C50E5C Offset: 0x1C4CE5C VA: 0x1C50E5C Slot: 15
	public virtual XmlDocument get_OwnerDocument() { }

	// RVA: 0x1C50F14 Offset: 0x1C4CF14 VA: 0x1C50F14 Slot: 16
	public virtual XmlNode get_FirstChild() { }

	// RVA: 0x1C50F38 Offset: 0x1C4CF38 VA: 0x1C50F38 Slot: 17
	public virtual XmlNode get_LastChild() { }

	// RVA: 0x1C50F48 Offset: 0x1C4CF48 VA: 0x1C50F48 Slot: 18
	internal virtual bool get_IsContainer() { }

	// RVA: 0x1C50F50 Offset: 0x1C4CF50 VA: 0x1C50F50 Slot: 19
	internal virtual XmlLinkedNode get_LastNode() { }

	// RVA: 0x1C50F58 Offset: 0x1C4CF58 VA: 0x1C50F58 Slot: 20
	internal virtual void set_LastNode(XmlLinkedNode value) { }

	// RVA: 0x1C50F5C Offset: 0x1C4CF5C VA: 0x1C50F5C
	internal bool AncestorNode(XmlNode node) { }

	// RVA: 0x1C50FC8 Offset: 0x1C4CFC8 VA: 0x1C50FC8 Slot: 21
	public virtual XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1C515D0 Offset: 0x1C4D5D0 VA: 0x1C515D0 Slot: 22
	public virtual XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1C51B58 Offset: 0x1C4DB58 VA: 0x1C51B58 Slot: 23
	public virtual XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x1C51F28 Offset: 0x1C4DF28 VA: 0x1C51F28 Slot: 24
	public virtual XmlNode PrependChild(XmlNode newChild) { }

	// RVA: 0x1C51F70 Offset: 0x1C4DF70 VA: 0x1C51F70 Slot: 25
	public virtual XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x1C52440 Offset: 0x1C4E440 VA: 0x1C52440 Slot: 26
	internal virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc) { }

	// RVA: 0x1C5260C Offset: 0x1C4E60C VA: 0x1C5260C Slot: 27
	internal virtual bool IsValidChildType(XmlNodeType type) { }

	// RVA: 0x1C52614 Offset: 0x1C4E614 VA: 0x1C52614 Slot: 28
	internal virtual bool CanInsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1C5261C Offset: 0x1C4E61C VA: 0x1C5261C Slot: 29
	internal virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1C52624 Offset: 0x1C4E624 VA: 0x1C52624 Slot: 30
	public virtual bool get_HasChildNodes() { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract XmlNode CloneNode(bool deep);

	// RVA: 0x1C52648 Offset: 0x1C4E648 VA: 0x1C52648 Slot: 32
	internal virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep) { }

	// RVA: 0x1C526E4 Offset: 0x1C4E6E4 VA: 0x1C526E4 Slot: 33
	public virtual string get_NamespaceURI() { }

	// RVA: 0x1C526FC Offset: 0x1C4E6FC VA: 0x1C526FC Slot: 34
	public virtual string get_Prefix() { }

	// RVA: 0x1C52714 Offset: 0x1C4E714 VA: 0x1C52714 Slot: 35
	public virtual void set_Prefix(string value) { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract string get_LocalName();

	// RVA: 0x1C52718 Offset: 0x1C4E718 VA: 0x1C52718 Slot: 37
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x1C5273C Offset: 0x1C4E73C VA: 0x1C5273C
	internal static bool HasReadOnlyParent(XmlNode n) { }

	// RVA: 0x1C52818 Offset: 0x1C4E818 VA: 0x1C52818 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1C5282C Offset: 0x1C4E82C VA: 0x1C5282C Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1C52888 Offset: 0x1C4E888 VA: 0x1C52888
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1C528E4 Offset: 0x1C4E8E4 VA: 0x1C528E4
	private void AppendChildText(StringBuilder builder) { }

	// RVA: 0x1C529E8 Offset: 0x1C4E9E8 VA: 0x1C529E8 Slot: 38
	public virtual string get_InnerText() { }

	// RVA: 0x1C52AE4 Offset: 0x1C4EAE4 VA: 0x1C52AE4 Slot: 39
	public virtual void set_InnerText(string value) { }

	// RVA: 0x1C52BB4 Offset: 0x1C4EBB4 VA: 0x1C52BB4 Slot: 40
	public virtual void set_InnerXml(string value) { }

	// RVA: 0x1C52C0C Offset: 0x1C4EC0C VA: 0x1C52C0C Slot: 41
	public virtual IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1C52C64 Offset: 0x1C4EC64 VA: 0x1C52C64 Slot: 42
	public virtual string get_BaseURI() { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract void WriteTo(XmlWriter w);

	// RVA: -1 Offset: -1 Slot: 44
	public abstract void WriteContentTo(XmlWriter w);

	// RVA: 0x1C52D88 Offset: 0x1C4ED88 VA: 0x1C52D88 Slot: 45
	public virtual void RemoveAll() { }

	// RVA: 0x1C52DF0 Offset: 0x1C4EDF0 VA: 0x1C52DF0
	internal XmlDocument get_Document() { }

	// RVA: 0x1C52E9C Offset: 0x1C4EE9C VA: 0x1C52E9C Slot: 46
	public virtual string GetPrefixOfNamespace(string namespaceURI) { }

	// RVA: 0x1C52EC4 Offset: 0x1C4EEC4 VA: 0x1C52EC4
	internal string GetPrefixOfNamespaceStrict(string namespaceURI) { }

	// RVA: 0x1C5321C Offset: 0x1C4F21C VA: 0x1C5321C Slot: 47
	internal virtual void SetParent(XmlNode node) { }

	// RVA: 0x1C53258 Offset: 0x1C4F258 VA: 0x1C53258 Slot: 48
	internal virtual void SetParentForLoad(XmlNode node) { }

	// RVA: 0x1C53260 Offset: 0x1C4F260 VA: 0x1C53260
	internal static void SplitName(string name, out string prefix, out string localName) { }

	// RVA: 0x1C5332C Offset: 0x1C4F32C VA: 0x1C5332C Slot: 49
	internal virtual XmlNode FindChild(XmlNodeType type) { }

	// RVA: 0x1C53390 Offset: 0x1C4F390 VA: 0x1C53390 Slot: 50
	internal virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x1C534B4 Offset: 0x1C4F4B4 VA: 0x1C534B4 Slot: 51
	internal virtual void BeforeEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x1C534F8 Offset: 0x1C4F4F8 VA: 0x1C534F8 Slot: 52
	internal virtual void AfterEvent(XmlNodeChangedEventArgs args) { }

	// RVA: 0x1C5353C Offset: 0x1C4F53C VA: 0x1C5353C Slot: 53
	internal virtual XmlSpace get_XmlSpace() { }

	// RVA: 0x1C536B4 Offset: 0x1C4F6B4 VA: 0x1C536B4 Slot: 54
	internal virtual string get_XmlLang() { }

	// RVA: 0x1C5379C Offset: 0x1C4F79C VA: 0x1C5379C Slot: 55
	internal virtual bool get_IsText() { }

	// RVA: 0x1C5157C Offset: 0x1C4D57C VA: 0x1C5157C
	internal static void NestTextNodes(XmlNode prevNode, XmlNode nextNode) { }

	// RVA: 0x1C5159C Offset: 0x1C4D59C VA: 0x1C5159C
	internal static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode) { }
}

// Namespace: System.Xml
public class XmlNodeChangedEventArgs : EventArgs // TypeDefIndex: 3206
{
	// Fields
	private XmlNodeChangedAction action; // 0x10
	private XmlNode node; // 0x18
	private XmlNode oldParent; // 0x20
	private XmlNode newParent; // 0x28
	private string oldValue; // 0x30
	private string newValue; // 0x38

	// Properties
	public XmlNodeChangedAction Action { get; }

	// Methods

	// RVA: 0x1C537A4 Offset: 0x1C4F7A4 VA: 0x1C537A4
	public void .ctor(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action) { }

	// RVA: 0x1C53880 Offset: 0x1C4F880 VA: 0x1C53880
	public XmlNodeChangedAction get_Action() { }
}

// Namespace: System.Xml
public sealed class XmlNodeChangedEventHandler : MulticastDelegate // TypeDefIndex: 3207
{
	// Methods

	// RVA: 0x1C53888 Offset: 0x1C4F888 VA: 0x1C53888
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C53994 Offset: 0x1C4F994 VA: 0x1C53994 Slot: 12
	public virtual void Invoke(object sender, XmlNodeChangedEventArgs e) { }
}

// Namespace: System.Xml
[DefaultMember("ItemOf")]
public abstract class XmlNodeList : IEnumerable, IDisposable // TypeDefIndex: 3208
{
	// Properties
	public abstract int Count { get; }
	public virtual XmlNode ItemOf { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract XmlNode Item(int index);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_Count();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IEnumerator GetEnumerator();

	// RVA: 0x1C539A8 Offset: 0x1C4F9A8 VA: 0x1C539A8 Slot: 9
	public virtual XmlNode get_ItemOf(int i) { }

	// RVA: 0x1C539B4 Offset: 0x1C4F9B4 VA: 0x1C539B4 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1C539C0 Offset: 0x1C4F9C0 VA: 0x1C539C0 Slot: 10
	protected virtual void PrivateDisposeNodeList() { }

	// RVA: 0x1C539C4 Offset: 0x1C4F9C4 VA: 0x1C539C4
	protected void .ctor() { }
}

// Namespace: 
internal struct XmlNodeReaderNavigator.VirtualAttribute // TypeDefIndex: 3209
{
	// Fields
	internal string name; // 0x0
	internal string value; // 0x8

	// Methods

	// RVA: 0x1C53D5C Offset: 0x1C4FD5C VA: 0x1C53D5C
	internal void .ctor(string name, string value) { }
}

// Namespace: System.Xml
internal class XmlNodeReaderNavigator // TypeDefIndex: 3210
{
	// Fields
	private XmlNode curNode; // 0x10
	private XmlNode elemNode; // 0x18
	private XmlNode logNode; // 0x20
	private int attrIndex; // 0x28
	private int logAttrIndex; // 0x2C
	private XmlNameTable nameTable; // 0x30
	private XmlDocument doc; // 0x38
	private int nAttrInd; // 0x40
	private int nDeclarationAttrCount; // 0x44
	private int nDocTypeAttrCount; // 0x48
	private int nLogLevel; // 0x4C
	private int nLogAttrInd; // 0x50
	private bool bLogOnAttrVal; // 0x54
	private bool bCreatedOnAttribute; // 0x55
	internal XmlNodeReaderNavigator.VirtualAttribute[] decNodeAttributes; // 0x58
	internal XmlNodeReaderNavigator.VirtualAttribute[] docTypeNodeAttributes; // 0x60
	private bool bOnAttrVal; // 0x68

	// Properties
	public XmlNodeType NodeType { get; }
	public string NamespaceURI { get; }
	public string Name { get; }
	public string LocalName { get; }
	internal bool CreatedOnAttribute { get; }
	public string Prefix { get; }
	public string Value { get; }
	public string BaseURI { get; }
	public XmlSpace XmlSpace { get; }
	public string XmlLang { get; }
	public bool IsEmptyElement { get; }
	public bool IsDefault { get; }
	public IXmlSchemaInfo SchemaInfo { get; }
	public XmlNameTable NameTable { get; }
	public int AttributeCount { get; }
	private bool IsOnDeclOrDocType { get; }
	public XmlDocument Document { get; }

	// Methods

	// RVA: 0x1C539CC Offset: 0x1C4F9CC VA: 0x1C539CC
	public void .ctor(XmlNode node) { }

	// RVA: 0x1C53D8C Offset: 0x1C4FD8C VA: 0x1C53D8C
	public XmlNodeType get_NodeType() { }

	// RVA: 0x1C53DD0 Offset: 0x1C4FDD0 VA: 0x1C53DD0
	public string get_NamespaceURI() { }

	// RVA: 0x1C53DF0 Offset: 0x1C4FDF0 VA: 0x1C53DF0
	public string get_Name() { }

	// RVA: 0x1C53ED4 Offset: 0x1C4FED4 VA: 0x1C53ED4
	public string get_LocalName() { }

	// RVA: 0x1C53F50 Offset: 0x1C4FF50 VA: 0x1C53F50
	internal bool get_CreatedOnAttribute() { }

	// RVA: 0x1C53EB4 Offset: 0x1C4FEB4 VA: 0x1C53EB4
	private bool IsLocalNameEmpty(XmlNodeType nt) { }

	// RVA: 0x1C53F58 Offset: 0x1C4FF58 VA: 0x1C53F58
	public string get_Prefix() { }

	// RVA: 0x1C53F78 Offset: 0x1C4FF78 VA: 0x1C53F78
	public string get_Value() { }

	// RVA: 0x1C543AC Offset: 0x1C503AC VA: 0x1C543AC
	public string get_BaseURI() { }

	// RVA: 0x1C543CC Offset: 0x1C503CC VA: 0x1C543CC
	public XmlSpace get_XmlSpace() { }

	// RVA: 0x1C543EC Offset: 0x1C503EC VA: 0x1C543EC
	public string get_XmlLang() { }

	// RVA: 0x1C5440C Offset: 0x1C5040C VA: 0x1C5440C
	public bool get_IsEmptyElement() { }

	// RVA: 0x1C544B8 Offset: 0x1C504B8 VA: 0x1C544B8
	public bool get_IsDefault() { }

	// RVA: 0x1C5456C Offset: 0x1C5056C VA: 0x1C5456C
	public IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1C5458C Offset: 0x1C5058C VA: 0x1C5458C
	public XmlNameTable get_NameTable() { }

	// RVA: 0x1C54594 Offset: 0x1C50594 VA: 0x1C54594
	public int get_AttributeCount() { }

	// RVA: 0x1C547FC Offset: 0x1C507FC VA: 0x1C547FC
	private void CheckIndexCondition(int attributeIndex) { }

	// RVA: 0x1C541EC Offset: 0x1C501EC VA: 0x1C541EC
	private void InitDecAttr() { }

	// RVA: 0x1C54864 Offset: 0x1C50864 VA: 0x1C54864
	public string GetDeclarationAttr(XmlDeclaration decl, string name) { }

	// RVA: 0x1C54944 Offset: 0x1C50944 VA: 0x1C54944
	public string GetDeclarationAttr(int i) { }

	// RVA: 0x1C54998 Offset: 0x1C50998 VA: 0x1C54998
	public int GetDecAttrInd(string name) { }

	// RVA: 0x1C546D0 Offset: 0x1C506D0 VA: 0x1C546D0
	private void InitDocTypeAttr() { }

	// RVA: 0x1C54A30 Offset: 0x1C50A30 VA: 0x1C54A30
	public string GetDocumentTypeAttr(XmlDocumentType docType, string name) { }

	// RVA: 0x1C54ADC Offset: 0x1C50ADC VA: 0x1C54ADC
	public string GetDocumentTypeAttr(int i) { }

	// RVA: 0x1C54B30 Offset: 0x1C50B30 VA: 0x1C54B30
	public int GetDocTypeAttrInd(string name) { }

	// RVA: 0x1C54BC8 Offset: 0x1C50BC8 VA: 0x1C54BC8
	private string GetAttributeFromElement(XmlElement elem, string name) { }

	// RVA: 0x1C54C0C Offset: 0x1C50C0C VA: 0x1C54C0C
	public string GetAttribute(string name) { }

	// RVA: 0x1C54DA8 Offset: 0x1C50DA8 VA: 0x1C54DA8
	private string GetAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x1C54DF0 Offset: 0x1C50DF0 VA: 0x1C54DF0
	public string GetAttribute(string name, string ns) { }

	// RVA: 0x1C54FC0 Offset: 0x1C50FC0 VA: 0x1C54FC0
	public string GetAttribute(int attributeIndex) { }

	// RVA: 0x1C55168 Offset: 0x1C51168 VA: 0x1C55168
	public void LogMove(int level) { }

	// RVA: 0x1C551AC Offset: 0x1C511AC VA: 0x1C551AC
	public void RollBackMove(ref int level) { }

	// RVA: 0x1C551F8 Offset: 0x1C511F8 VA: 0x1C551F8
	private bool get_IsOnDeclOrDocType() { }

	// RVA: 0x1C55228 Offset: 0x1C51228 VA: 0x1C55228
	public void ResetToAttribute(ref int level) { }

	// RVA: 0x1C552DC Offset: 0x1C512DC VA: 0x1C552DC
	public void ResetMove(ref int level, ref XmlNodeType nt) { }

	// RVA: 0x1C554BC Offset: 0x1C514BC VA: 0x1C554BC
	public bool MoveToAttribute(string name) { }

	// RVA: 0x1C5562C Offset: 0x1C5162C VA: 0x1C5562C
	private bool MoveToAttributeFromElement(XmlElement elem, string name, string ns) { }

	// RVA: 0x1C554D4 Offset: 0x1C514D4 VA: 0x1C554D4
	public bool MoveToAttribute(string name, string namespaceURI) { }

	// RVA: 0x1C55708 Offset: 0x1C51708 VA: 0x1C55708
	public void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x1C558C8 Offset: 0x1C518C8 VA: 0x1C558C8
	public bool MoveToNextAttribute(ref int level) { }

	// RVA: 0x1C55AB4 Offset: 0x1C51AB4 VA: 0x1C55AB4
	public bool MoveToParent() { }

	// RVA: 0x1C55B14 Offset: 0x1C51B14 VA: 0x1C55B14
	public bool MoveToFirstChild() { }

	// RVA: 0x1C55B7C Offset: 0x1C51B7C VA: 0x1C55B7C
	private bool MoveToNextSibling(XmlNode node) { }

	// RVA: 0x1C55BE8 Offset: 0x1C51BE8 VA: 0x1C55BE8
	public bool MoveToNext() { }

	// RVA: 0x1C55C28 Offset: 0x1C51C28 VA: 0x1C55C28
	public bool MoveToElement() { }

	// RVA: 0x1C55CB8 Offset: 0x1C51CB8 VA: 0x1C55CB8
	public string LookupNamespace(string prefix) { }

	// RVA: 0x1C55F58 Offset: 0x1C51F58 VA: 0x1C55F58
	internal string DefaultLookupNamespace(string prefix) { }

	// RVA: 0x1C56074 Offset: 0x1C52074 VA: 0x1C56074
	internal string LookupPrefix(string namespaceName) { }

	// RVA: 0x1C5643C Offset: 0x1C5243C VA: 0x1C5643C
	internal IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1C56910 Offset: 0x1C52910 VA: 0x1C56910
	public bool ReadAttributeValue(ref int level, ref bool bResolveEntity, ref XmlNodeType nt) { }

	// RVA: 0x1C56B28 Offset: 0x1C52B28 VA: 0x1C56B28
	public XmlDocument get_Document() { }
}

// Namespace: System.Xml
public class XmlNodeReader : XmlReader, IXmlNamespaceResolver // TypeDefIndex: 3211
{
	// Fields
	private XmlNodeReaderNavigator readerNav; // 0x10
	private XmlNodeType nodeType; // 0x18
	private int curDepth; // 0x1C
	private ReadState readState; // 0x20
	private bool fEOF; // 0x24
	private bool bResolveEntity; // 0x25
	private bool bStartFromDocument; // 0x26
	private bool bInReadBinary; // 0x27
	private ReadContentAsBinaryHelper readBinaryHelper; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override string NamespaceURI { get; }
	public override string Prefix { get; }
	public override string Value { get; }
	public override int Depth { get; }
	public override string BaseURI { get; }
	public override bool CanResolveEntity { get; }
	public override bool IsEmptyElement { get; }
	public override bool IsDefault { get; }
	public override XmlSpace XmlSpace { get; }
	public override string XmlLang { get; }
	public override IXmlSchemaInfo SchemaInfo { get; }
	public override int AttributeCount { get; }
	public override bool EOF { get; }
	public override ReadState ReadState { get; }
	public override bool HasAttributes { get; }
	public override XmlNameTable NameTable { get; }
	internal override IDtdInfo DtdInfo { get; }

	// Methods

	// RVA: 0x1C56B30 Offset: 0x1C52B30 VA: 0x1C56B30
	public void .ctor(XmlNode node) { }

	// RVA: 0x1C56C24 Offset: 0x1C52C24 VA: 0x1C56C24
	internal bool IsInReadingStates() { }

	// RVA: 0x1C56C34 Offset: 0x1C52C34 VA: 0x1C56C34 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C56C50 Offset: 0x1C52C50 VA: 0x1C56C50 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1C56C88 Offset: 0x1C52C88 VA: 0x1C56C88 Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1C56CC0 Offset: 0x1C52CC0 VA: 0x1C56CC0 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1C56D14 Offset: 0x1C52D14 VA: 0x1C56D14 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1C56D68 Offset: 0x1C52D68 VA: 0x1C56D68 Slot: 11
	public override string get_Value() { }

	// RVA: 0x1C56DA0 Offset: 0x1C52DA0 VA: 0x1C56DA0 Slot: 12
	public override int get_Depth() { }

	// RVA: 0x1C56DA8 Offset: 0x1C52DA8 VA: 0x1C56DA8 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x1C56DD4 Offset: 0x1C52DD4 VA: 0x1C56DD4 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1C56DDC Offset: 0x1C52DDC VA: 0x1C56DDC Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1C56E04 Offset: 0x1C52E04 VA: 0x1C56E04 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1C56E2C Offset: 0x1C52E2C VA: 0x1C56E2C Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1C56E70 Offset: 0x1C52E70 VA: 0x1C56E70 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x1C56EC4 Offset: 0x1C52EC4 VA: 0x1C56EC4 Slot: 19
	public override IXmlSchemaInfo get_SchemaInfo() { }

	// RVA: 0x1C56F08 Offset: 0x1C52F08 VA: 0x1C56F08 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x1C56F3C Offset: 0x1C52F3C VA: 0x1C56F3C Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x1C56F64 Offset: 0x1C52F64 VA: 0x1C56F64 Slot: 23
	public override string GetAttribute(string name, string namespaceURI) { }

	// RVA: 0x1C56FA4 Offset: 0x1C52FA4 VA: 0x1C56FA4 Slot: 24
	public override string GetAttribute(int attributeIndex) { }

	// RVA: 0x1C57010 Offset: 0x1C53010 VA: 0x1C57010 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1C57110 Offset: 0x1C53110 VA: 0x1C57110 Slot: 26
	public override void MoveToAttribute(int attributeIndex) { }

	// RVA: 0x1C572D8 Offset: 0x1C532D8 VA: 0x1C572D8 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1C573B8 Offset: 0x1C533B8 VA: 0x1C573B8 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1C574B4 Offset: 0x1C534B4 VA: 0x1C574B4 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x1C575AC Offset: 0x1C535AC VA: 0x1C575AC Slot: 31
	public override bool Read() { }

	// RVA: 0x1C575B4 Offset: 0x1C535B4 VA: 0x1C575B4
	private bool Read(bool fSkipChildren) { }

	// RVA: 0x1C576B8 Offset: 0x1C536B8 VA: 0x1C576B8
	private bool ReadNextNode(bool fSkipChildren) { }

	// RVA: 0x1C57968 Offset: 0x1C53968 VA: 0x1C57968
	private void SetEndOfFile() { }

	// RVA: 0x1C57980 Offset: 0x1C53980 VA: 0x1C57980
	private bool ReadAtZeroLevel(bool fSkipChildren) { }

	// RVA: 0x1C5787C Offset: 0x1C5387C VA: 0x1C5787C
	private bool ReadForward(bool fSkipChildren) { }

	// RVA: 0x1C5785C Offset: 0x1C5385C VA: 0x1C5785C
	private void ReSetReadingMarks() { }

	// RVA: 0x1C579F0 Offset: 0x1C539F0 VA: 0x1C579F0 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x1C57A14 Offset: 0x1C53A14 VA: 0x1C57A14 Slot: 33
	public override void Close() { }

	// RVA: 0x1C57A20 Offset: 0x1C53A20 VA: 0x1C57A20 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x1C57A28 Offset: 0x1C53A28 VA: 0x1C57A28 Slot: 35
	public override void Skip() { }

	// RVA: 0x1C57A30 Offset: 0x1C53A30 VA: 0x1C57A30 Slot: 42
	public override string ReadString() { }

	// RVA: 0x1C57AD4 Offset: 0x1C53AD4 VA: 0x1C57AD4 Slot: 49
	public override bool get_HasAttributes() { }

	// RVA: 0x1C57AF8 Offset: 0x1C53AF8 VA: 0x1C57AF8 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1C57B10 Offset: 0x1C53B10 VA: 0x1C57B10 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1C57B48 Offset: 0x1C53B48 VA: 0x1C57B48 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1C57BC4 Offset: 0x1C53BC4 VA: 0x1C57BC4 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x1C570F0 Offset: 0x1C530F0 VA: 0x1C570F0
	private void FinishReadBinary() { }

	// RVA: 0x1C57C10 Offset: 0x1C53C10 VA: 0x1C57C10 Slot: 53
	private IDictionary<string, string> System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1C57C24 Offset: 0x1C53C24 VA: 0x1C57C24 Slot: 55
	private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName) { }

	// RVA: 0x1C57C38 Offset: 0x1C53C38 VA: 0x1C57C38 Slot: 54
	private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix) { }

	// RVA: 0x1C57C98 Offset: 0x1C53C98 VA: 0x1C57C98 Slot: 52
	internal override IDtdInfo get_DtdInfo() { }
}

// Namespace: System.Xml
public class XmlNotation : XmlNode // TypeDefIndex: 3212
{
	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string name; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public override string InnerXml { set; }

	// Methods

	// RVA: 0x1C57CBC Offset: 0x1C53CBC VA: 0x1C57CBC
	internal void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

	// RVA: 0x1C57D48 Offset: 0x1C53D48 VA: 0x1C57D48 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1C57D50 Offset: 0x1C53D50 VA: 0x1C57D50 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1C57D58 Offset: 0x1C53D58 VA: 0x1C57D58 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C57D60 Offset: 0x1C53D60 VA: 0x1C57D60 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C57DB8 Offset: 0x1C53DB8 VA: 0x1C57DB8 Slot: 37
	public override bool get_IsReadOnly() { }

	// RVA: 0x1C57DC0 Offset: 0x1C53DC0 VA: 0x1C57DC0 Slot: 40
	public override void set_InnerXml(string value) { }

	// RVA: 0x1C57E18 Offset: 0x1C53E18 VA: 0x1C57E18 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C57E1C Offset: 0x1C53E1C VA: 0x1C57E1C Slot: 44
	public override void WriteContentTo(XmlWriter w) { }
}

// Namespace: System.Xml
public class XmlProcessingInstruction : XmlLinkedNode // TypeDefIndex: 3213
{
	// Fields
	private string target; // 0x20
	private string data; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override string Value { get; set; }
	public string Data { set; }
	public override string InnerText { get; set; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x1C57E20 Offset: 0x1C53E20 VA: 0x1C57E20
	protected internal void .ctor(string target, string data, XmlDocument doc) { }

	// RVA: 0x1C57E68 Offset: 0x1C53E68 VA: 0x1C57E68 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1C57E8C Offset: 0x1C53E8C VA: 0x1C57E8C Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1C57E98 Offset: 0x1C53E98 VA: 0x1C57E98 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1C57EA0 Offset: 0x1C53EA0 VA: 0x1C57EA0 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1C57EA4 Offset: 0x1C53EA4 VA: 0x1C57EA4
	public void set_Data(string value) { }

	// RVA: 0x1C57F68 Offset: 0x1C53F68 VA: 0x1C57F68 Slot: 38
	public override string get_InnerText() { }

	// RVA: 0x1C57F70 Offset: 0x1C53F70 VA: 0x1C57F70 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x1C57F74 Offset: 0x1C53F74 VA: 0x1C57F74 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C57F7C Offset: 0x1C53F7C VA: 0x1C57F7C Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C57FB4 Offset: 0x1C53FB4 VA: 0x1C57FB4 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C57FDC Offset: 0x1C53FDC VA: 0x1C57FDC Slot: 44
	public override void WriteContentTo(XmlWriter w) { }
}

// Namespace: System.Xml
public class XmlSignificantWhitespace : XmlCharacterData // TypeDefIndex: 3214
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x1C57FE0 Offset: 0x1C53FE0 VA: 0x1C57FE0
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x1C5807C Offset: 0x1C5407C VA: 0x1C5807C Slot: 6
	public override string get_Name() { }

	// RVA: 0x1C580A4 Offset: 0x1C540A4 VA: 0x1C580A4 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1C580CC Offset: 0x1C540CC VA: 0x1C580CC Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C580D4 Offset: 0x1C540D4 VA: 0x1C580D4 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1C5815C Offset: 0x1C5415C VA: 0x1C5815C Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C581B8 Offset: 0x1C541B8 VA: 0x1C581B8 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1C581C8 Offset: 0x1C541C8 VA: 0x1C581C8 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1C58254 Offset: 0x1C54254 VA: 0x1C58254 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C58294 Offset: 0x1C54294 VA: 0x1C58294 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1C58298 Offset: 0x1C54298 VA: 0x1C58298 Slot: 55
	internal override bool get_IsText() { }
}

// Namespace: System.Xml
public class XmlText : XmlCharacterData // TypeDefIndex: 3215
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x1C582A0 Offset: 0x1C542A0 VA: 0x1C582A0
	internal void .ctor(string strData) { }

	// RVA: 0x1C582AC Offset: 0x1C542AC VA: 0x1C582AC
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x1C582B4 Offset: 0x1C542B4 VA: 0x1C582B4 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1C582DC Offset: 0x1C542DC VA: 0x1C582DC Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1C58304 Offset: 0x1C54304 VA: 0x1C58304 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C5830C Offset: 0x1C5430C VA: 0x1C5830C Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1C58390 Offset: 0x1C54390 VA: 0x1C58390 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C583EC Offset: 0x1C543EC VA: 0x1C583EC Slot: 7
	public override string get_Value() { }

	// RVA: 0x1C583FC Offset: 0x1C543FC VA: 0x1C583FC Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1C584C4 Offset: 0x1C544C4 VA: 0x1C584C4 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C58504 Offset: 0x1C54504 VA: 0x1C58504 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1C58508 Offset: 0x1C54508 VA: 0x1C58508 Slot: 55
	internal override bool get_IsText() { }
}

// Namespace: System.Xml
internal class XmlUnspecifiedAttribute : XmlAttribute // TypeDefIndex: 3216
{
	// Fields
	private bool fSpecified; // 0x28

	// Properties
	public override bool Specified { get; }
	public override string InnerText { set; }

	// Methods

	// RVA: 0x1C58510 Offset: 0x1C54510 VA: 0x1C58510
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x1C58518 Offset: 0x1C54518 VA: 0x1C58518 Slot: 56
	public override bool get_Specified() { }

	// RVA: 0x1C58520 Offset: 0x1C54520 VA: 0x1C58520 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C58650 Offset: 0x1C54650 VA: 0x1C58650 Slot: 39
	public override void set_InnerText(string value) { }

	// RVA: 0x1C58670 Offset: 0x1C54670 VA: 0x1C58670 Slot: 21
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1C58690 Offset: 0x1C54690 VA: 0x1C58690 Slot: 22
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x1C586B0 Offset: 0x1C546B0 VA: 0x1C586B0 Slot: 23
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x1C586D0 Offset: 0x1C546D0 VA: 0x1C586D0 Slot: 25
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x1C586F0 Offset: 0x1C546F0 VA: 0x1C586F0 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C58704 Offset: 0x1C54704 VA: 0x1C58704
	internal void SetSpecified(bool f) { }
}

// Namespace: System.Xml
public class XmlWhitespace : XmlCharacterData // TypeDefIndex: 3217
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override bool IsText { get; }

	// Methods

	// RVA: 0x1C5870C Offset: 0x1C5470C VA: 0x1C5870C
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x1C587A8 Offset: 0x1C547A8 VA: 0x1C587A8 Slot: 6
	public override string get_Name() { }

	// RVA: 0x1C587D0 Offset: 0x1C547D0 VA: 0x1C587D0 Slot: 36
	public override string get_LocalName() { }

	// RVA: 0x1C587F8 Offset: 0x1C547F8 VA: 0x1C587F8 Slot: 9
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1C58800 Offset: 0x1C54800 VA: 0x1C58800 Slot: 10
	public override XmlNode get_ParentNode() { }

	// RVA: 0x1C58888 Offset: 0x1C54888 VA: 0x1C58888 Slot: 7
	public override string get_Value() { }

	// RVA: 0x1C58898 Offset: 0x1C54898 VA: 0x1C58898 Slot: 8
	public override void set_Value(string value) { }

	// RVA: 0x1C58924 Offset: 0x1C54924 VA: 0x1C58924 Slot: 31
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x1C58980 Offset: 0x1C54980 VA: 0x1C58980 Slot: 43
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x1C589C0 Offset: 0x1C549C0 VA: 0x1C589C0 Slot: 44
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x1C589C4 Offset: 0x1C549C4 VA: 0x1C589C4 Slot: 55
	internal override bool get_IsText() { }
}

// Namespace: System.Xml
internal sealed class EmptyEnumerator : IEnumerator // TypeDefIndex: 3218
{
	// Properties
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1C589CC Offset: 0x1C549CC VA: 0x1C589CC Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1C589D4 Offset: 0x1C549D4 VA: 0x1C589D4 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1C589D8 Offset: 0x1C549D8 VA: 0x1C589D8 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1C58A30 Offset: 0x1C54A30 VA: 0x1C58A30
	public void .ctor() { }
}

// Namespace: System.Xml
[DefaultMember("Item")]
internal class HWStack : ICloneable // TypeDefIndex: 3219
{
	// Fields
	private object[] stack; // 0x10
	private int growthRate; // 0x18
	private int used; // 0x1C
	private int size; // 0x20
	private int limit; // 0x24

	// Properties
	internal object Item { get; set; }
	internal int Length { get; }

	// Methods

	// RVA: 0x1C58A38 Offset: 0x1C54A38 VA: 0x1C58A38
	internal void .ctor(int GrowthRate) { }

	// RVA: 0x1C58A40 Offset: 0x1C54A40 VA: 0x1C58A40
	internal void .ctor(int GrowthRate, int limit) { }

	// RVA: 0x1C58AC0 Offset: 0x1C54AC0 VA: 0x1C58AC0
	internal object Push() { }

	// RVA: 0x1C58C00 Offset: 0x1C54C00 VA: 0x1C58C00
	internal object Pop() { }

	// RVA: 0x1C58C48 Offset: 0x1C54C48 VA: 0x1C58C48
	internal object Peek() { }

	// RVA: 0x1C58C8C Offset: 0x1C54C8C VA: 0x1C58C8C
	internal void AddToTop(object o) { }

	// RVA: 0x1C58D08 Offset: 0x1C54D08 VA: 0x1C58D08
	internal object get_Item(int index) { }

	// RVA: 0x1C58D7C Offset: 0x1C54D7C VA: 0x1C58D7C
	internal void set_Item(int index, object value) { }

	// RVA: 0x1C58E28 Offset: 0x1C54E28 VA: 0x1C58E28
	internal int get_Length() { }

	// RVA: 0x1C58E30 Offset: 0x1C54E30 VA: 0x1C58E30
	private void .ctor(object[] stack, int growthRate, int used, int size) { }

	// RVA: 0x1C58E80 Offset: 0x1C54E80 VA: 0x1C58E80 Slot: 4
	public object Clone() { }
}

// Namespace: System.Xml
public interface IXmlLineInfo // TypeDefIndex: 3220
{
	// Properties
	public abstract int LineNumber { get; }
	public abstract int LinePosition { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool HasLineInfo();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_LineNumber();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_LinePosition();
}

// Namespace: System.Xml
internal class PositionInfo : IXmlLineInfo // TypeDefIndex: 3221
{
	// Properties
	public virtual int LineNumber { get; }
	public virtual int LinePosition { get; }

	// Methods

	// RVA: 0x1C58F68 Offset: 0x1C54F68 VA: 0x1C58F68 Slot: 7
	public virtual bool HasLineInfo() { }

	// RVA: 0x1C58F70 Offset: 0x1C54F70 VA: 0x1C58F70 Slot: 8
	public virtual int get_LineNumber() { }

	// RVA: 0x1C58F78 Offset: 0x1C54F78 VA: 0x1C58F78 Slot: 9
	public virtual int get_LinePosition() { }

	// RVA: 0x1C58F80 Offset: 0x1C54F80 VA: 0x1C58F80
	public static PositionInfo GetPositionInfo(object o) { }

	// RVA: 0x1C5906C Offset: 0x1C5506C VA: 0x1C5906C
	public void .ctor() { }
}

// Namespace: System.Xml
internal class ReaderPositionInfo : PositionInfo // TypeDefIndex: 3222
{
	// Fields
	private IXmlLineInfo lineInfo; // 0x10

	// Properties
	public override int LineNumber { get; }
	public override int LinePosition { get; }

	// Methods

	// RVA: 0x1C5903C Offset: 0x1C5503C VA: 0x1C5903C
	public void .ctor(IXmlLineInfo lineInfo) { }

	// RVA: 0x1C59074 Offset: 0x1C55074 VA: 0x1C59074 Slot: 7
	public override bool HasLineInfo() { }

	// RVA: 0x1C59114 Offset: 0x1C55114 VA: 0x1C59114 Slot: 8
	public override int get_LineNumber() { }

	// RVA: 0x1C591B8 Offset: 0x1C551B8 VA: 0x1C591B8 Slot: 9
	public override int get_LinePosition() { }
}

// Namespace: System.Xml
public interface IXmlNamespaceResolver // TypeDefIndex: 3223
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string LookupNamespace(string prefix);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string LookupPrefix(string namespaceName);
}

// Namespace: System.Xml
internal struct LineInfo // TypeDefIndex: 3224
{
	// Fields
	internal int lineNo; // 0x0
	internal int linePos; // 0x4

	// Methods

	// RVA: 0x1C5925C Offset: 0x1C5525C VA: 0x1C5925C
	public void .ctor(int lineNo, int linePos) { }

	// RVA: 0x1C59264 Offset: 0x1C55264 VA: 0x1C59264
	public void Set(int lineNo, int linePos) { }
}

// Namespace: 
private class NameTable.Entry // TypeDefIndex: 3225
{
	// Fields
	internal string str; // 0x10
	internal int hashCode; // 0x18
	internal NameTable.Entry next; // 0x20

	// Methods

	// RVA: 0x1C598B0 Offset: 0x1C558B0 VA: 0x1C598B0
	internal void .ctor(string str, int hashCode, NameTable.Entry next) { }
}

// Namespace: System.Xml
public class NameTable : XmlNameTable // TypeDefIndex: 3226
{
	// Fields
	private NameTable.Entry[] entries; // 0x10
	private int count; // 0x18
	private int mask; // 0x1C
	private int hashCodeRandomizer; // 0x20

	// Methods

	// RVA: 0x1C5926C Offset: 0x1C5526C VA: 0x1C5926C
	public void .ctor() { }

	// RVA: 0x1C592E8 Offset: 0x1C552E8 VA: 0x1C592E8 Slot: 6
	public override string Add(string key) { }

	// RVA: 0x1C59550 Offset: 0x1C55550 VA: 0x1C59550 Slot: 5
	public override string Add(char[] key, int start, int len) { }

	// RVA: 0x1C5976C Offset: 0x1C5576C VA: 0x1C5976C Slot: 4
	public override string Get(string value) { }

	// RVA: 0x1C59440 Offset: 0x1C55440 VA: 0x1C59440
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x1C59904 Offset: 0x1C55904 VA: 0x1C59904
	private void Grow() { }

	// RVA: 0x1C596B0 Offset: 0x1C556B0 VA: 0x1C596B0
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }
}

// Namespace: System.Xml
internal static class Ref // TypeDefIndex: 3227
{
	// Methods

	// RVA: 0x1C53210 Offset: 0x1C4F210 VA: 0x1C53210
	public static bool Equal(string strA, string strB) { }
}

// Namespace: 
private enum DtdParser.Token // TypeDefIndex: 3228
{
	// Fields
	public int value__; // 0x0
	public const DtdParser.Token CDATA = 0;
	public const DtdParser.Token ID = 1;
	public const DtdParser.Token IDREF = 2;
	public const DtdParser.Token IDREFS = 3;
	public const DtdParser.Token ENTITY = 4;
	public const DtdParser.Token ENTITIES = 5;
	public const DtdParser.Token NMTOKEN = 6;
	public const DtdParser.Token NMTOKENS = 7;
	public const DtdParser.Token NOTATION = 8;
	public const DtdParser.Token None = 9;
	public const DtdParser.Token PERef = 10;
	public const DtdParser.Token AttlistDecl = 11;
	public const DtdParser.Token ElementDecl = 12;
	public const DtdParser.Token EntityDecl = 13;
	public const DtdParser.Token NotationDecl = 14;
	public const DtdParser.Token Comment = 15;
	public const DtdParser.Token PI = 16;
	public const DtdParser.Token CondSectionStart = 17;
	public const DtdParser.Token CondSectionEnd = 18;
	public const DtdParser.Token Eof = 19;
	public const DtdParser.Token REQUIRED = 20;
	public const DtdParser.Token IMPLIED = 21;
	public const DtdParser.Token FIXED = 22;
	public const DtdParser.Token QName = 23;
	public const DtdParser.Token Name = 24;
	public const DtdParser.Token Nmtoken = 25;
	public const DtdParser.Token Quote = 26;
	public const DtdParser.Token LeftParen = 27;
	public const DtdParser.Token RightParen = 28;
	public const DtdParser.Token GreaterThan = 29;
	public const DtdParser.Token Or = 30;
	public const DtdParser.Token LeftBracket = 31;
	public const DtdParser.Token RightBracket = 32;
	public const DtdParser.Token PUBLIC = 33;
	public const DtdParser.Token SYSTEM = 34;
	public const DtdParser.Token Literal = 35;
	public const DtdParser.Token DOCTYPE = 36;
	public const DtdParser.Token NData = 37;
	public const DtdParser.Token Percent = 38;
	public const DtdParser.Token Star = 39;
	public const DtdParser.Token QMark = 40;
	public const DtdParser.Token Plus = 41;
	public const DtdParser.Token PCDATA = 42;
	public const DtdParser.Token Comma = 43;
	public const DtdParser.Token ANY = 44;
	public const DtdParser.Token EMPTY = 45;
	public const DtdParser.Token IGNORE = 46;
	public const DtdParser.Token INCLUDE = 47;
}

// Namespace: 
private enum DtdParser.ScanningFunction // TypeDefIndex: 3229
{
	// Fields
	public int value__; // 0x0
	public const DtdParser.ScanningFunction SubsetContent = 0;
	public const DtdParser.ScanningFunction Name = 1;
	public const DtdParser.ScanningFunction QName = 2;
	public const DtdParser.ScanningFunction Nmtoken = 3;
	public const DtdParser.ScanningFunction Doctype1 = 4;
	public const DtdParser.ScanningFunction Doctype2 = 5;
	public const DtdParser.ScanningFunction Element1 = 6;
	public const DtdParser.ScanningFunction Element2 = 7;
	public const DtdParser.ScanningFunction Element3 = 8;
	public const DtdParser.ScanningFunction Element4 = 9;
	public const DtdParser.ScanningFunction Element5 = 10;
	public const DtdParser.ScanningFunction Element6 = 11;
	public const DtdParser.ScanningFunction Element7 = 12;
	public const DtdParser.ScanningFunction Attlist1 = 13;
	public const DtdParser.ScanningFunction Attlist2 = 14;
	public const DtdParser.ScanningFunction Attlist3 = 15;
	public const DtdParser.ScanningFunction Attlist4 = 16;
	public const DtdParser.ScanningFunction Attlist5 = 17;
	public const DtdParser.ScanningFunction Attlist6 = 18;
	public const DtdParser.ScanningFunction Attlist7 = 19;
	public const DtdParser.ScanningFunction Entity1 = 20;
	public const DtdParser.ScanningFunction Entity2 = 21;
	public const DtdParser.ScanningFunction Entity3 = 22;
	public const DtdParser.ScanningFunction Notation1 = 23;
	public const DtdParser.ScanningFunction CondSection1 = 24;
	public const DtdParser.ScanningFunction CondSection2 = 25;
	public const DtdParser.ScanningFunction CondSection3 = 26;
	public const DtdParser.ScanningFunction Literal = 27;
	public const DtdParser.ScanningFunction SystemId = 28;
	public const DtdParser.ScanningFunction PublicId1 = 29;
	public const DtdParser.ScanningFunction PublicId2 = 30;
	public const DtdParser.ScanningFunction ClosingTag = 31;
	public const DtdParser.ScanningFunction ParamEntitySpace = 32;
	public const DtdParser.ScanningFunction None = 33;
}

// Namespace: 
private enum DtdParser.LiteralType // TypeDefIndex: 3230
{
	// Fields
	public int value__; // 0x0
	public const DtdParser.LiteralType AttributeValue = 0;
	public const DtdParser.LiteralType EntityReplText = 1;
	public const DtdParser.LiteralType SystemOrPublicID = 2;
}

// Namespace: 
private class DtdParser.UndeclaredNotation // TypeDefIndex: 3231
{
	// Fields
	internal string name; // 0x10
	internal int lineNo; // 0x18
	internal int linePos; // 0x1C
	internal DtdParser.UndeclaredNotation next; // 0x20

	// Methods

	// RVA: 0x1C63D30 Offset: 0x1C5FD30 VA: 0x1C63D30
	internal void .ctor(string name, int lineNo, int linePos) { }
}

// Namespace: 
private class DtdParser.ParseElementOnlyContent_LocalFrame // TypeDefIndex: 3232
{
	// Fields
	public int startParenEntityId; // 0x10
	public DtdParser.Token parsingSchema; // 0x14

	// Methods

	// RVA: 0x1C63D84 Offset: 0x1C5FD84 VA: 0x1C63D84
	public void .ctor(int startParentEntityIdParam) { }
}

// Namespace: System.Xml
internal class DtdParser : IDtdParser // TypeDefIndex: 3233
{
	// Fields
	private IDtdParserAdapter readerAdapter; // 0x10
	private IDtdParserAdapterWithValidation readerAdapterWithValidation; // 0x18
	private XmlNameTable nameTable; // 0x20
	private SchemaInfo schemaInfo; // 0x28
	private XmlCharType xmlCharType; // 0x30
	private string systemId; // 0x38
	private string publicId; // 0x40
	private bool normalize; // 0x48
	private bool validate; // 0x49
	private bool supportNamespaces; // 0x4A
	private bool v1Compat; // 0x4B
	private char[] chars; // 0x50
	private int charsUsed; // 0x58
	private int curPos; // 0x5C
	private DtdParser.ScanningFunction scanningFunction; // 0x60
	private DtdParser.ScanningFunction nextScaningFunction; // 0x64
	private DtdParser.ScanningFunction savedScanningFunction; // 0x68
	private bool whitespaceSeen; // 0x6C
	private int tokenStartPos; // 0x70
	private int colonPos; // 0x74
	private StringBuilder internalSubsetValueSb; // 0x78
	private int externalEntitiesDepth; // 0x80
	private int currentEntityId; // 0x84
	private bool freeFloatingDtd; // 0x88
	private bool hasFreeFloatingInternalSubset; // 0x89
	private StringBuilder stringBuilder; // 0x90
	private int condSectionDepth; // 0x98
	private LineInfo literalLineInfo; // 0x9C
	private char literalQuoteChar; // 0xA4
	private string documentBaseUri; // 0xA8
	private string externalDtdBaseUri; // 0xB0
	private Dictionary<string, DtdParser.UndeclaredNotation> undeclaredNotations; // 0xB8
	private int[] condSectionEntityIds; // 0xC0

	// Properties
	private bool ParsingInternalSubset { get; }
	private bool IgnoreEntityReferences { get; }
	private bool SaveInternalSubsetValue { get; }
	private bool ParsingTopLevelMarkup { get; }
	private bool SupportNamespaces { get; }
	private bool Normalize { get; }
	private int LineNo { get; }
	private int LinePos { get; }
	private string BaseUriStr { get; }

	// Methods

	// RVA: 0x1C59A60 Offset: 0x1C55A60 VA: 0x1C59A60
	private void .ctor() { }

	// RVA: 0x1C59B1C Offset: 0x1C55B1C VA: 0x1C59B1C
	internal static IDtdParser Create() { }

	// RVA: 0x1C59B6C Offset: 0x1C55B6C VA: 0x1C59B6C
	private void Initialize(IDtdParserAdapter readerAdapter) { }

	// RVA: 0x1C59F8C Offset: 0x1C55F8C VA: 0x1C59F8C
	private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x1C5A400 Offset: 0x1C56400 VA: 0x1C5A400 Slot: 4
	private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset) { }

	// RVA: 0x1C5A658 Offset: 0x1C56658 VA: 0x1C5A658 Slot: 5
	private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter) { }

	// RVA: 0x1C5A67C Offset: 0x1C5667C VA: 0x1C5A67C
	private bool get_ParsingInternalSubset() { }

	// RVA: 0x1C5A68C Offset: 0x1C5668C VA: 0x1C5A68C
	private bool get_IgnoreEntityReferences() { }

	// RVA: 0x1C5A69C Offset: 0x1C5669C VA: 0x1C5A69C
	private bool get_SaveInternalSubsetValue() { }

	// RVA: 0x1C5A75C Offset: 0x1C5675C VA: 0x1C5A75C
	private bool get_ParsingTopLevelMarkup() { }

	// RVA: 0x1C5A78C Offset: 0x1C5678C VA: 0x1C5A78C
	private bool get_SupportNamespaces() { }

	// RVA: 0x1C5A794 Offset: 0x1C56794 VA: 0x1C5A794
	private bool get_Normalize() { }

	// RVA: 0x1C5A430 Offset: 0x1C56430 VA: 0x1C5A430
	private void Parse(bool saveInternalSubset) { }

	// RVA: 0x1C5A7F0 Offset: 0x1C567F0 VA: 0x1C5A7F0
	private void ParseInDocumentDtd(bool saveInternalSubset) { }

	// RVA: 0x1C5A79C Offset: 0x1C5679C VA: 0x1C5A79C
	private void ParseFreeFloatingDtd() { }

	// RVA: 0x1C5BCA4 Offset: 0x1C57CA4 VA: 0x1C5BCA4
	private void ParseInternalSubset() { }

	// RVA: 0x1C5BCA8 Offset: 0x1C57CA8 VA: 0x1C5BCA8
	private void ParseExternalSubset() { }

	// RVA: 0x1C5BE58 Offset: 0x1C57E58 VA: 0x1C5BE58
	private void ParseSubset() { }

	// RVA: 0x1C5C234 Offset: 0x1C58234 VA: 0x1C5C234
	private void ParseAttlistDecl() { }

	// RVA: 0x1C5DC34 Offset: 0x1C59C34 VA: 0x1C5DC34
	private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors) { }

	// RVA: 0x1C5E1C0 Offset: 0x1C5A1C0 VA: 0x1C5E1C0
	private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors) { }

	// RVA: 0x1C5C794 Offset: 0x1C58794 VA: 0x1C5C794
	private void ParseElementDecl() { }

	// RVA: 0x1C5E93C Offset: 0x1C5A93C VA: 0x1C5E93C
	private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x1C5ECA4 Offset: 0x1C5ACA4 VA: 0x1C5ECA4
	private void ParseHowMany(ParticleContentValidator pcv) { }

	// RVA: 0x1C5E6B8 Offset: 0x1C5A6B8 VA: 0x1C5E6B8
	private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId) { }

	// RVA: 0x1C5CB3C Offset: 0x1C58B3C VA: 0x1C5CB3C
	private void ParseEntityDecl() { }

	// RVA: 0x1C5CECC Offset: 0x1C58ECC VA: 0x1C5CECC
	private void ParseNotationDecl() { }

	// RVA: 0x1C5E458 Offset: 0x1C5A458 VA: 0x1C5E458
	private void AddUndeclaredNotation(string notationName) { }

	// RVA: 0x1C5D0D0 Offset: 0x1C590D0 VA: 0x1C5D0D0
	private void ParseComment() { }

	// RVA: 0x1C5D31C Offset: 0x1C5931C VA: 0x1C5D31C
	private void ParsePI() { }

	// RVA: 0x1C5D498 Offset: 0x1C59498 VA: 0x1C5D498
	private void ParseCondSection() { }

	// RVA: 0x1C5B774 Offset: 0x1C57774 VA: 0x1C5B774
	private void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId) { }

	// RVA: 0x1C5AD3C Offset: 0x1C56D3C VA: 0x1C5AD3C
	private DtdParser.Token GetToken(bool needWhiteSpace) { }

	// RVA: 0x1C5F438 Offset: 0x1C5B438 VA: 0x1C5F438
	private DtdParser.Token ScanSubsetContent() { }

	// RVA: 0x1C5F3D0 Offset: 0x1C5B3D0 VA: 0x1C5F3D0
	private DtdParser.Token ScanNameExpected() { }

	// RVA: 0x1C5F3F4 Offset: 0x1C5B3F4 VA: 0x1C5F3F4
	private DtdParser.Token ScanQNameExpected() { }

	// RVA: 0x1C5F418 Offset: 0x1C5B418 VA: 0x1C5F418
	private DtdParser.Token ScanNmtokenExpected() { }

	// RVA: 0x1C5FB7C Offset: 0x1C5BB7C VA: 0x1C5FB7C
	private DtdParser.Token ScanDoctype1() { }

	// RVA: 0x1C5FCE0 Offset: 0x1C5BCE0 VA: 0x1C5FCE0
	private DtdParser.Token ScanDoctype2() { }

	// RVA: 0x1C620F0 Offset: 0x1C5E0F0 VA: 0x1C620F0
	private DtdParser.Token ScanClosingTag() { }

	// RVA: 0x1C5FD98 Offset: 0x1C5BD98 VA: 0x1C5FD98
	private DtdParser.Token ScanElement1() { }

	// RVA: 0x1C5FF8C Offset: 0x1C5BF8C VA: 0x1C5FF8C
	private DtdParser.Token ScanElement2() { }

	// RVA: 0x1C60150 Offset: 0x1C5C150 VA: 0x1C60150
	private DtdParser.Token ScanElement3() { }

	// RVA: 0x1C601D0 Offset: 0x1C5C1D0 VA: 0x1C601D0
	private DtdParser.Token ScanElement4() { }

	// RVA: 0x1C602B0 Offset: 0x1C5C2B0 VA: 0x1C602B0
	private DtdParser.Token ScanElement5() { }

	// RVA: 0x1C603A8 Offset: 0x1C5C3A8 VA: 0x1C603A8
	private DtdParser.Token ScanElement6() { }

	// RVA: 0x1C60478 Offset: 0x1C5C478 VA: 0x1C60478
	private DtdParser.Token ScanElement7() { }

	// RVA: 0x1C604D8 Offset: 0x1C5C4D8 VA: 0x1C604D8
	private DtdParser.Token ScanAttlist1() { }

	// RVA: 0x1C6059C Offset: 0x1C5C59C VA: 0x1C6059C
	private DtdParser.Token ScanAttlist2() { }

	// RVA: 0x1C60C80 Offset: 0x1C5CC80 VA: 0x1C60C80
	private DtdParser.Token ScanAttlist3() { }

	// RVA: 0x1C60D20 Offset: 0x1C5CD20 VA: 0x1C60D20
	private DtdParser.Token ScanAttlist4() { }

	// RVA: 0x1C60DF0 Offset: 0x1C5CDF0 VA: 0x1C60DF0
	private DtdParser.Token ScanAttlist5() { }

	// RVA: 0x1C60EC0 Offset: 0x1C5CEC0 VA: 0x1C60EC0
	private DtdParser.Token ScanAttlist6() { }

	// RVA: 0x1C61280 Offset: 0x1C5D280 VA: 0x1C61280
	private DtdParser.Token ScanAttlist7() { }

	// RVA: 0x1C62728 Offset: 0x1C5E728 VA: 0x1C62728
	private DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType) { }

	// RVA: 0x1C63210 Offset: 0x1C5F210 VA: 0x1C63210
	private XmlQualifiedName ScanEntityName() { }

	// RVA: 0x1C6133C Offset: 0x1C5D33C VA: 0x1C6133C
	private DtdParser.Token ScanNotation1() { }

	// RVA: 0x1C61478 Offset: 0x1C5D478 VA: 0x1C61478
	private DtdParser.Token ScanSystemId() { }

	// RVA: 0x1C61648 Offset: 0x1C5D648 VA: 0x1C61648
	private DtdParser.Token ScanEntity1() { }

	// RVA: 0x1C616BC Offset: 0x1C5D6BC VA: 0x1C616BC
	private DtdParser.Token ScanEntity2() { }

	// RVA: 0x1C6182C Offset: 0x1C5D82C VA: 0x1C6182C
	private DtdParser.Token ScanEntity3() { }

	// RVA: 0x1C6152C Offset: 0x1C5D52C VA: 0x1C6152C
	private DtdParser.Token ScanPublicId1() { }

	// RVA: 0x1C615E0 Offset: 0x1C5D5E0 VA: 0x1C615E0
	private DtdParser.Token ScanPublicId2() { }

	// RVA: 0x1C61930 Offset: 0x1C5D930 VA: 0x1C61930
	private DtdParser.Token ScanCondSection1() { }

	// RVA: 0x1C61BFC Offset: 0x1C5DBFC VA: 0x1C61BFC
	private DtdParser.Token ScanCondSection2() { }

	// RVA: 0x1C61C94 Offset: 0x1C5DC94 VA: 0x1C61C94
	private DtdParser.Token ScanCondSection3() { }

	// RVA: 0x1C623EC Offset: 0x1C5E3EC VA: 0x1C623EC
	private void ScanName() { }

	// RVA: 0x1C623F4 Offset: 0x1C5E3F4 VA: 0x1C623F4
	private void ScanQName() { }

	// RVA: 0x1C63598 Offset: 0x1C5F598 VA: 0x1C63598
	private void ScanQName(bool isQName) { }

	// RVA: 0x1C63820 Offset: 0x1C5F820 VA: 0x1C63820
	private bool ReadDataInName() { }

	// RVA: 0x1C623FC Offset: 0x1C5E3FC VA: 0x1C623FC
	private void ScanNmtoken() { }

	// RVA: 0x1C62560 Offset: 0x1C5E560 VA: 0x1C62560
	private bool EatPublicKeyword() { }

	// RVA: 0x1C62644 Offset: 0x1C5E644 VA: 0x1C62644
	private bool EatSystemKeyword() { }

	// RVA: 0x1C5B604 Offset: 0x1C57604 VA: 0x1C5B604
	private XmlQualifiedName GetNameQualified(bool canHavePrefix) { }

	// RVA: 0x1C5E438 Offset: 0x1C5A438 VA: 0x1C5E438
	private string GetNameString() { }

	// RVA: 0x1C5E5DC Offset: 0x1C5A5DC VA: 0x1C5E5DC
	private string GetNmtokenString() { }

	// RVA: 0x1C5E65C Offset: 0x1C5A65C VA: 0x1C5E65C
	private string GetValue() { }

	// RVA: 0x1C5E5FC Offset: 0x1C5A5FC VA: 0x1C5E5FC
	private string GetValueWithStrippedSpaces() { }

	// RVA: 0x1C62184 Offset: 0x1C5E184 VA: 0x1C62184
	private int ReadData() { }

	// RVA: 0x1C5ABB0 Offset: 0x1C56BB0 VA: 0x1C5ABB0
	private void LoadParsingBuffer() { }

	// RVA: 0x1C5BC9C Offset: 0x1C57C9C VA: 0x1C5BC9C
	private void SaveParsingBuffer() { }

	// RVA: 0x1C5D7C0 Offset: 0x1C597C0 VA: 0x1C5D7C0
	private void SaveParsingBuffer(int internalSubsetValueEndPos) { }

	// RVA: 0x1C5F2CC Offset: 0x1C5B2CC VA: 0x1C5F2CC
	private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x1C63A7C Offset: 0x1C5FA7C VA: 0x1C63A7C
	private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute) { }

	// RVA: 0x1C62248 Offset: 0x1C5E248 VA: 0x1C62248
	private bool HandleEntityEnd(bool inLiteral) { }

	// RVA: 0x1C63370 Offset: 0x1C5F370 VA: 0x1C63370
	private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute) { }

	// RVA: 0x1C5D6EC Offset: 0x1C596EC VA: 0x1C5D6EC
	private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x1C5E378 Offset: 0x1C5A378 VA: 0x1C5E378
	private void SendValidationEvent(XmlSeverityType severity, string code, string arg) { }

	// RVA: 0x1C5AA6C Offset: 0x1C56A6C VA: 0x1C5AA6C
	private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e) { }

	// RVA: 0x1C5E36C Offset: 0x1C5A36C VA: 0x1C5E36C
	private bool IsAttributeValueType(DtdParser.Token token) { }

	// RVA: 0x1C5D914 Offset: 0x1C59914 VA: 0x1C5D914
	private int get_LineNo() { }

	// RVA: 0x1C5D9B8 Offset: 0x1C599B8 VA: 0x1C5D9B8
	private int get_LinePos() { }

	// RVA: 0x1C5A954 Offset: 0x1C56954 VA: 0x1C5A954
	private string get_BaseUriStr() { }

	// RVA: 0x1C5B5A4 Offset: 0x1C575A4 VA: 0x1C5B5A4
	private void OnUnexpectedError() { }

	// RVA: 0x1C5D480 Offset: 0x1C59480 VA: 0x1C5D480
	private void Throw(int curPos, string res) { }

	// RVA: 0x1C5ED14 Offset: 0x1C5AD14 VA: 0x1C5ED14
	private void Throw(int curPos, string res, string arg) { }

	// RVA: 0x1C5F068 Offset: 0x1C5B068 VA: 0x1C5F068
	private void Throw(int curPos, string res, string[] args) { }

	// RVA: 0x1C5DA68 Offset: 0x1C59A68 VA: 0x1C5DA68
	private void Throw(string res, string arg, int lineNo, int linePos) { }

	// RVA: 0x1C5A384 Offset: 0x1C56384 VA: 0x1C5A384
	private void ThrowInvalidChar(int pos, string data, int invCharPos) { }

	// RVA: 0x1C5F24C Offset: 0x1C5B24C VA: 0x1C5F24C
	private void ThrowInvalidChar(char[] data, int length, int invCharPos) { }

	// RVA: 0x1C5D90C Offset: 0x1C5990C VA: 0x1C5D90C
	private void ThrowUnexpectedToken(int pos, string expectedToken) { }

	// RVA: 0x1C5EEF8 Offset: 0x1C5AEF8 VA: 0x1C5EEF8
	private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2) { }

	// RVA: 0x1C5F31C Offset: 0x1C5B31C VA: 0x1C5F31C
	private string ParseUnexpectedToken(int startPos) { }

	// RVA: 0x1C63864 Offset: 0x1C5F864 VA: 0x1C63864
	internal static string StripSpaces(string value) { }
}

// Namespace: System.Xml
public enum XmlTokenizedType // TypeDefIndex: 3234
{
	// Fields
	public int value__; // 0x0
	public const XmlTokenizedType CDATA = 0;
	public const XmlTokenizedType ID = 1;
	public const XmlTokenizedType IDREF = 2;
	public const XmlTokenizedType IDREFS = 3;
	public const XmlTokenizedType ENTITY = 4;
	public const XmlTokenizedType ENTITIES = 5;
	public const XmlTokenizedType NMTOKEN = 6;
	public const XmlTokenizedType NMTOKENS = 7;
	public const XmlTokenizedType NOTATION = 8;
	public const XmlTokenizedType ENUMERATION = 9;
	public const XmlTokenizedType QName = 10;
	public const XmlTokenizedType NCName = 11;
	public const XmlTokenizedType None = 12;
}

// Namespace: System.Xml
internal static class ValidateNames // TypeDefIndex: 3235
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0

	// Methods

	// RVA: 0x1C63DB0 Offset: 0x1C5FDB0 VA: 0x1C63DB0
	internal static int ParseNmtoken(string s, int offset) { }

	// RVA: 0x1C63E78 Offset: 0x1C5FE78 VA: 0x1C63E78
	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	// RVA: 0x1C63F5C Offset: 0x1C5FF5C VA: 0x1C63F5C
	internal static int ParseNameNoNamespaces(string s, int offset) { }

	// RVA: 0x1C640B4 Offset: 0x1C600B4 VA: 0x1C640B4
	internal static bool IsNameNoNamespaces(string s) { }

	// RVA: 0x1C64134 Offset: 0x1C60134 VA: 0x1C64134
	internal static int ParseNCName(string s, int offset) { }

	// RVA: 0x1C64250 Offset: 0x1C60250 VA: 0x1C64250
	internal static int ParseNCName(string s) { }

	// RVA: 0x1C642A8 Offset: 0x1C602A8 VA: 0x1C642A8
	internal static int ParseQName(string s, int offset, out int colonOffset) { }

	// RVA: 0x1C64384 Offset: 0x1C60384 VA: 0x1C64384
	internal static void ParseQNameThrow(string s, out string prefix, out string localName) { }

	// RVA: 0x1C644B8 Offset: 0x1C604B8 VA: 0x1C644B8
	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x1C64814 Offset: 0x1C60814 VA: 0x1C64814
	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x1C649D8 Offset: 0x1C609D8 VA: 0x1C649D8
	internal static void SplitQName(string name, out string prefix, out string lname) { }

	// RVA: 0x1C64DA4 Offset: 0x1C60DA4 VA: 0x1C64DA4
	private static void .cctor() { }
}

// Namespace: System.Xml
internal struct XmlCharType // TypeDefIndex: 3236
{
	// Fields
	private static object s_Lock; // 0x0
	private static byte[] s_CharProperties; // 0x8
	internal byte[] charProperties; // 0x0

	// Properties
	private static object StaticLock { get; }
	public static XmlCharType Instance { get; }

	// Methods

	// RVA: 0x1C64DFC Offset: 0x1C60DFC VA: 0x1C64DFC
	private static object get_StaticLock() { }

	// RVA: 0x1C64E90 Offset: 0x1C60E90 VA: 0x1C64E90
	private static void InitInstance() { }

	// RVA: 0x1C650F8 Offset: 0x1C610F8 VA: 0x1C650F8
	private static void SetProperties(byte[] chProps, string ranges, byte value) { }

	// RVA: 0x1C651BC Offset: 0x1C611BC VA: 0x1C651BC
	private void .ctor(byte[] charProperties) { }

	// RVA: 0x1C646F8 Offset: 0x1C606F8 VA: 0x1C646F8
	public static XmlCharType get_Instance() { }

	// RVA: 0x1C651C4 Offset: 0x1C611C4 VA: 0x1C651C4
	public bool IsWhiteSpace(char ch) { }

	// RVA: 0x1C646C4 Offset: 0x1C606C4 VA: 0x1C646C4
	public bool IsNCNameSingleChar(char ch) { }

	// RVA: 0x1C64770 Offset: 0x1C60770 VA: 0x1C64770
	public bool IsStartNCNameSingleChar(char ch) { }

	// RVA: 0x1C651F8 Offset: 0x1C611F8 VA: 0x1C651F8
	public bool IsNameSingleChar(char ch) { }

	// RVA: 0x1C6521C Offset: 0x1C6121C VA: 0x1C6521C
	public bool IsCharData(char ch) { }

	// RVA: 0x1C65250 Offset: 0x1C61250 VA: 0x1C65250
	public bool IsPubidChar(char ch) { }

	// RVA: 0x1C652CC Offset: 0x1C612CC VA: 0x1C652CC
	internal bool IsTextChar(char ch) { }

	// RVA: 0x1C65300 Offset: 0x1C61300 VA: 0x1C65300
	public bool IsLetter(char ch) { }

	// RVA: 0x1C65334 Offset: 0x1C61334 VA: 0x1C65334
	public bool IsNCNameCharXml4e(char ch) { }

	// RVA: 0x1C65368 Offset: 0x1C61368 VA: 0x1C65368
	public bool IsStartNCNameCharXml4e(char ch) { }

	// RVA: 0x1C6538C Offset: 0x1C6138C VA: 0x1C6538C
	public bool IsNameCharXml4e(char ch) { }

	// RVA: 0x1C653B0 Offset: 0x1C613B0 VA: 0x1C653B0
	public static bool IsDigit(char ch) { }

	// RVA: 0x1C653D8 Offset: 0x1C613D8 VA: 0x1C653D8
	internal static bool IsHighSurrogate(int ch) { }

	// RVA: 0x1C653E8 Offset: 0x1C613E8 VA: 0x1C653E8
	internal static bool IsLowSurrogate(int ch) { }

	// RVA: 0x1C653F8 Offset: 0x1C613F8 VA: 0x1C653F8
	internal static bool IsSurrogate(int ch) { }

	// RVA: 0x1C65408 Offset: 0x1C61408 VA: 0x1C65408
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	// RVA: 0x1C65420 Offset: 0x1C61420 VA: 0x1C65420
	internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar) { }

	// RVA: 0x1C65458 Offset: 0x1C61458 VA: 0x1C65458
	internal bool IsOnlyWhitespace(string str) { }

	// RVA: 0x1C65470 Offset: 0x1C61470 VA: 0x1C65470
	internal int IsOnlyWhitespaceWithPos(string str) { }

	// RVA: 0x1C654F8 Offset: 0x1C614F8 VA: 0x1C654F8
	internal int IsOnlyCharData(string str) { }

	// RVA: 0x1C655D0 Offset: 0x1C615D0 VA: 0x1C655D0
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	// RVA: 0x1C65678 Offset: 0x1C61678 VA: 0x1C65678
	internal int IsPublicId(string str) { }

	// RVA: 0x1C653C4 Offset: 0x1C613C4 VA: 0x1C653C4
	private static bool InRange(int value, int start, int end) { }
}

// Namespace: System.Xml
internal static class XmlComplianceUtil // TypeDefIndex: 3237
{
	// Methods

	// RVA: 0x1C656D8 Offset: 0x1C616D8 VA: 0x1C656D8
	public static string NonCDataNormalize(string value) { }

	// RVA: 0x1C65970 Offset: 0x1C61970 VA: 0x1C65970
	public static string CDataNormalize(string value) { }
}

// Namespace: System.Xml
internal enum ExceptionType // TypeDefIndex: 3238
{
	// Fields
	public int value__; // 0x0
	public const ExceptionType ArgumentException = 0;
	public const ExceptionType XmlException = 1;
}

// Namespace: System.Xml
public enum XmlDateTimeSerializationMode // TypeDefIndex: 3239
{
	// Fields
	public int value__; // 0x0
	public const XmlDateTimeSerializationMode Local = 0;
	public const XmlDateTimeSerializationMode Utc = 1;
	public const XmlDateTimeSerializationMode Unspecified = 2;
	public const XmlDateTimeSerializationMode RoundtripKind = 3;
}

// Namespace: System.Xml
public class XmlConvert // TypeDefIndex: 3240
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0
	internal static char[] crt; // 0x8
	private static readonly int c_EncodedCharLength; // 0x10
	private static Regex c_EncodeCharPattern; // 0x18
	private static Regex c_DecodeCharPattern; // 0x20
	private static string[] s_allDateTimeFormats; // 0x28
	internal static readonly char[] WhitespaceChars; // 0x30

	// Properties
	private static string[] AllDateTimeFormats { get; }

	// Methods

	// RVA: 0x1C65B4C Offset: 0x1C61B4C VA: 0x1C65B4C
	public static string EncodeName(string name) { }

	// RVA: 0x1C6657C Offset: 0x1C6257C VA: 0x1C6657C
	public static string EncodeLocalName(string name) { }

	// RVA: 0x1C665D8 Offset: 0x1C625D8 VA: 0x1C665D8
	public static string DecodeName(string name) { }

	// RVA: 0x1C65BA8 Offset: 0x1C61BA8 VA: 0x1C65BA8
	private static string EncodeName(string name, bool first, bool local) { }

	// RVA: 0x1C66EDC Offset: 0x1C62EDC VA: 0x1C66EDC
	private static int FromHex(char digit) { }

	// RVA: 0x1C66F08 Offset: 0x1C62F08 VA: 0x1C66F08
	internal static byte[] FromBinHexString(string s) { }

	// RVA: 0x1C66F60 Offset: 0x1C62F60 VA: 0x1C66F60
	internal static byte[] FromBinHexString(string s, bool allowOddCount) { }

	// RVA: 0x1C66FCC Offset: 0x1C62FCC VA: 0x1C66FCC
	internal static string ToBinHexString(byte[] inArray) { }

	// RVA: 0x1C6702C Offset: 0x1C6302C VA: 0x1C6702C
	public static string VerifyName(string name) { }

	// RVA: 0x1C67240 Offset: 0x1C63240 VA: 0x1C67240
	internal static Exception TryVerifyName(string name) { }

	// RVA: 0x1C67388 Offset: 0x1C63388 VA: 0x1C67388
	internal static string VerifyQName(string name, ExceptionType exceptionType) { }

	// RVA: 0x1C6758C Offset: 0x1C6358C VA: 0x1C6758C
	public static string VerifyNCName(string name) { }

	// RVA: 0x1C675E4 Offset: 0x1C635E4 VA: 0x1C675E4
	internal static string VerifyNCName(string name, ExceptionType exceptionType) { }

	// RVA: 0x1C67734 Offset: 0x1C63734 VA: 0x1C67734
	internal static Exception TryVerifyNCName(string name) { }

	// RVA: 0x1C677D4 Offset: 0x1C637D4 VA: 0x1C677D4
	public static string VerifyTOKEN(string token) { }

	// RVA: 0x1C67908 Offset: 0x1C63908 VA: 0x1C67908
	internal static Exception TryVerifyTOKEN(string token) { }

	// RVA: 0x1C67A3C Offset: 0x1C63A3C VA: 0x1C67A3C
	internal static Exception TryVerifyNMTOKEN(string name) { }

	// RVA: 0x1C67B64 Offset: 0x1C63B64 VA: 0x1C67B64
	internal static Exception TryVerifyNormalizedString(string str) { }

	// RVA: 0x1C67C2C Offset: 0x1C63C2C VA: 0x1C67C2C
	public static string ToString(bool value) { }

	// RVA: 0x1C67C94 Offset: 0x1C63C94 VA: 0x1C67C94
	public static string ToString(char value) { }

	// RVA: 0x1C67CD0 Offset: 0x1C63CD0 VA: 0x1C67CD0
	public static string ToString(Decimal value) { }

	[CLSCompliant(False)]
	// RVA: 0x1C67D6C Offset: 0x1C63D6C VA: 0x1C67D6C
	public static string ToString(sbyte value) { }

	// RVA: 0x1C67D98 Offset: 0x1C63D98 VA: 0x1C67D98
	public static string ToString(short value) { }

	// RVA: 0x1C67DC4 Offset: 0x1C63DC4 VA: 0x1C67DC4
	public static string ToString(int value) { }

	// RVA: 0x1C67DF0 Offset: 0x1C63DF0 VA: 0x1C67DF0
	public static string ToString(long value) { }

	// RVA: 0x1C67E18 Offset: 0x1C63E18 VA: 0x1C67E18
	public static string ToString(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1C67E44 Offset: 0x1C63E44 VA: 0x1C67E44
	public static string ToString(ushort value) { }

	[CLSCompliant(False)]
	// RVA: 0x1C67E70 Offset: 0x1C63E70 VA: 0x1C67E70
	public static string ToString(uint value) { }

	[CLSCompliant(False)]
	// RVA: 0x1C67E9C Offset: 0x1C63E9C VA: 0x1C67E9C
	public static string ToString(ulong value) { }

	// RVA: 0x1C67EC4 Offset: 0x1C63EC4 VA: 0x1C67EC4
	public static string ToString(float value) { }

	// RVA: 0x1C68034 Offset: 0x1C64034 VA: 0x1C68034
	public static string ToString(double value) { }

	// RVA: 0x1C68130 Offset: 0x1C64130 VA: 0x1C68130
	public static string ToString(TimeSpan value) { }

	// RVA: 0x1C68188 Offset: 0x1C64188 VA: 0x1C68188
	public static string ToString(DateTime value, string format) { }

	// RVA: 0x1C6822C Offset: 0x1C6422C VA: 0x1C6822C
	public static string ToString(DateTime value, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x1C68604 Offset: 0x1C64604 VA: 0x1C68604
	public static string ToString(DateTimeOffset value) { }

	// RVA: 0x1C6868C Offset: 0x1C6468C VA: 0x1C6868C
	public static string ToString(Guid value) { }

	// RVA: 0x1C686B0 Offset: 0x1C646B0 VA: 0x1C686B0
	public static bool ToBoolean(string s) { }

	// RVA: 0x1C688DC Offset: 0x1C648DC VA: 0x1C688DC
	internal static Exception TryToBoolean(string s, out bool result) { }

	// RVA: 0x1C68B10 Offset: 0x1C64B10 VA: 0x1C68B10
	public static char ToChar(string s) { }

	// RVA: 0x1C68BCC Offset: 0x1C64BCC VA: 0x1C68BCC
	internal static Exception TryToChar(string s, out char result) { }

	// RVA: 0x1C68D3C Offset: 0x1C64D3C VA: 0x1C68D3C
	public static Decimal ToDecimal(string s) { }

	// RVA: 0x1C68DAC Offset: 0x1C64DAC VA: 0x1C68DAC
	internal static Exception TryToDecimal(string s, out Decimal result) { }

	// RVA: 0x1C68F48 Offset: 0x1C64F48 VA: 0x1C68F48
	internal static Decimal ToInteger(string s) { }

	// RVA: 0x1C68FB8 Offset: 0x1C64FB8 VA: 0x1C68FB8
	internal static Exception TryToInteger(string s, out Decimal result) { }

	[CLSCompliant(False)]
	// RVA: 0x1C69154 Offset: 0x1C65154 VA: 0x1C69154
	public static sbyte ToSByte(string s) { }

	// RVA: 0x1C6917C Offset: 0x1C6517C VA: 0x1C6917C
	internal static Exception TryToSByte(string s, out sbyte result) { }

	// RVA: 0x1C692E4 Offset: 0x1C652E4 VA: 0x1C692E4
	public static short ToInt16(string s) { }

	// RVA: 0x1C6930C Offset: 0x1C6530C VA: 0x1C6930C
	internal static Exception TryToInt16(string s, out short result) { }

	// RVA: 0x1C69474 Offset: 0x1C65474 VA: 0x1C69474
	public static int ToInt32(string s) { }

	// RVA: 0x1C6949C Offset: 0x1C6549C VA: 0x1C6949C
	internal static Exception TryToInt32(string s, out int result) { }

	// RVA: 0x1C69604 Offset: 0x1C65604 VA: 0x1C69604
	public static long ToInt64(string s) { }

	// RVA: 0x1C6962C Offset: 0x1C6562C VA: 0x1C6962C
	internal static Exception TryToInt64(string s, out long result) { }

	// RVA: 0x1C69794 Offset: 0x1C65794 VA: 0x1C69794
	public static byte ToByte(string s) { }

	// RVA: 0x1C697BC Offset: 0x1C657BC VA: 0x1C697BC
	internal static Exception TryToByte(string s, out byte result) { }

	[CLSCompliant(False)]
	// RVA: 0x1C69924 Offset: 0x1C65924 VA: 0x1C69924
	public static ushort ToUInt16(string s) { }

	// RVA: 0x1C6994C Offset: 0x1C6594C VA: 0x1C6994C
	internal static Exception TryToUInt16(string s, out ushort result) { }

	[CLSCompliant(False)]
	// RVA: 0x1C69AB4 Offset: 0x1C65AB4 VA: 0x1C69AB4
	public static uint ToUInt32(string s) { }

	// RVA: 0x1C69ADC Offset: 0x1C65ADC VA: 0x1C69ADC
	internal static Exception TryToUInt32(string s, out uint result) { }

	[CLSCompliant(False)]
	// RVA: 0x1C69C44 Offset: 0x1C65C44 VA: 0x1C69C44
	public static ulong ToUInt64(string s) { }

	// RVA: 0x1C69C6C Offset: 0x1C65C6C VA: 0x1C69C6C
	internal static Exception TryToUInt64(string s, out ulong result) { }

	// RVA: 0x1C69DD4 Offset: 0x1C65DD4 VA: 0x1C69DD4
	public static float ToSingle(string s) { }

	// RVA: 0x1C69EEC Offset: 0x1C65EEC VA: 0x1C69EEC
	internal static Exception TryToSingle(string s, out float result) { }

	// RVA: 0x1C6A134 Offset: 0x1C66134 VA: 0x1C6A134
	public static double ToDouble(string s) { }

	// RVA: 0x1C6A24C Offset: 0x1C6624C VA: 0x1C6A24C
	internal static Exception TryToDouble(string s, out double result) { }

	// RVA: 0x1C6A494 Offset: 0x1C66494 VA: 0x1C6A494
	internal static double ToXPathDouble(object o) { }

	// RVA: 0x1C6A6B4 Offset: 0x1C666B4 VA: 0x1C6A6B4
	public static TimeSpan ToTimeSpan(string s) { }

	// RVA: 0x1C6A860 Offset: 0x1C66860 VA: 0x1C6A860
	internal static Exception TryToTimeSpan(string s, out TimeSpan result) { }

	// RVA: 0x1C6A90C Offset: 0x1C6690C VA: 0x1C6A90C
	private static string[] get_AllDateTimeFormats() { }

	// RVA: 0x1C6A9A4 Offset: 0x1C669A4 VA: 0x1C6A9A4
	private static void CreateAllDateTimeFormats() { }

	[Obsolete("Use XmlConvert.ToDateTime() that takes in XmlDateTimeSerializationMode")]
	// RVA: 0x1C6AF3C Offset: 0x1C66F3C VA: 0x1C6AF3C
	public static DateTime ToDateTime(string s) { }

	// RVA: 0x1C6AF98 Offset: 0x1C66F98 VA: 0x1C6AF98
	public static DateTime ToDateTime(string s, string[] formats) { }

	// RVA: 0x1C6B03C Offset: 0x1C6703C VA: 0x1C6B03C
	public static DateTime ToDateTime(string s, XmlDateTimeSerializationMode dateTimeOption) { }

	// RVA: 0x1C6B278 Offset: 0x1C67278 VA: 0x1C6B278
	public static DateTimeOffset ToDateTimeOffset(string s) { }

	// RVA: 0x1C6B340 Offset: 0x1C67340 VA: 0x1C6B340
	public static Guid ToGuid(string s) { }

	// RVA: 0x1C6B36C Offset: 0x1C6736C VA: 0x1C6B36C
	internal static Exception TryToGuid(string s, out Guid result) { }

	// RVA: 0x1C68454 Offset: 0x1C64454 VA: 0x1C68454
	private static DateTime SwitchToLocalTime(DateTime value) { }

	// RVA: 0x1C6852C Offset: 0x1C6452C VA: 0x1C6852C
	private static DateTime SwitchToUtcTime(DateTime value) { }

	// RVA: 0x1C6B548 Offset: 0x1C67548 VA: 0x1C6B548
	internal static Uri ToUri(string s) { }

	// RVA: 0x1C6B6F4 Offset: 0x1C676F4 VA: 0x1C6B6F4
	internal static Exception TryToUri(string s, out Uri result) { }

	// RVA: 0x1C6B920 Offset: 0x1C67920 VA: 0x1C6B920
	internal static bool StrEqual(char[] chars, int strPos1, int strLen1, string str2) { }

	// RVA: 0x1C68870 Offset: 0x1C64870 VA: 0x1C68870
	internal static string TrimString(string value) { }

	// RVA: 0x1C6B9F0 Offset: 0x1C679F0 VA: 0x1C6B9F0
	internal static string TrimStringStart(string value) { }

	// RVA: 0x1C6BA5C Offset: 0x1C67A5C VA: 0x1C6BA5C
	internal static string TrimStringEnd(string value) { }

	// RVA: 0x1C6BAC8 Offset: 0x1C67AC8 VA: 0x1C6BAC8
	internal static string[] SplitString(string value) { }

	// RVA: 0x1C67FC0 Offset: 0x1C63FC0 VA: 0x1C67FC0
	internal static bool IsNegativeZero(double value) { }

	// RVA: 0x1C6BB38 Offset: 0x1C67B38 VA: 0x1C6BB38
	private static long DoubleToInt64Bits(double value) { }

	// RVA: 0x1C6BB40 Offset: 0x1C67B40 VA: 0x1C6BB40
	internal static void VerifyCharData(string data, ExceptionType invCharExceptionType, ExceptionType invSurrogateExceptionType) { }

	// RVA: 0x1C6BD30 Offset: 0x1C67D30 VA: 0x1C6BD30
	internal static Exception CreateException(string res, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x1C6C0CC Offset: 0x1C680CC VA: 0x1C6C0CC
	internal static Exception CreateException(string res, string arg, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x1C6C208 Offset: 0x1C68208 VA: 0x1C6C208
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType) { }

	// RVA: 0x1C674B4 Offset: 0x1C634B4 VA: 0x1C674B4
	internal static Exception CreateException(string res, string[] args, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x1C6C290 Offset: 0x1C68290 VA: 0x1C6C290
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi) { }

	// RVA: 0x1C6C2F8 Offset: 0x1C682F8 VA: 0x1C6C2F8
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType) { }

	// RVA: 0x1C6BDF0 Offset: 0x1C67DF0 VA: 0x1C6BDF0
	internal static Exception CreateInvalidSurrogatePairException(char low, char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x1C6C36C Offset: 0x1C6836C VA: 0x1C6C36C
	internal static Exception CreateInvalidHighSurrogateCharException(char hi) { }

	// RVA: 0x1C6C3C4 Offset: 0x1C683C4 VA: 0x1C6C3C4
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType) { }

	// RVA: 0x1C6C430 Offset: 0x1C68430 VA: 0x1C6C430
	internal static Exception CreateInvalidHighSurrogateCharException(char hi, ExceptionType exceptionType, int lineNo, int linePos) { }

	// RVA: 0x1C6BF80 Offset: 0x1C67F80 VA: 0x1C6BF80
	internal static Exception CreateInvalidCharException(string data, int invCharPos, ExceptionType exceptionType) { }

	// RVA: 0x1C6C534 Offset: 0x1C68534 VA: 0x1C6C534
	internal static Exception CreateInvalidCharException(char invChar, char nextChar) { }

	// RVA: 0x1C6C59C Offset: 0x1C6859C VA: 0x1C6C59C
	internal static Exception CreateInvalidCharException(char invChar, char nextChar, ExceptionType exceptionType) { }

	// RVA: 0x1C6717C Offset: 0x1C6317C VA: 0x1C6717C
	internal static Exception CreateInvalidNameCharException(string name, int index, ExceptionType exceptionType) { }

	// RVA: 0x1C6C630 Offset: 0x1C68630 VA: 0x1C6C630
	internal static ArgumentException CreateInvalidNameArgumentException(string name, string argumentName) { }

	// RVA: 0x1C6C6E0 Offset: 0x1C686E0 VA: 0x1C6C6E0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class XmlDownloadManager.<>c__DisplayClass4_0 // TypeDefIndex: 3241
{
	// Fields
	public Uri uri; // 0x10

	// Methods

	// RVA: 0x1C6D270 Offset: 0x1C69270 VA: 0x1C6D270
	public void .ctor() { }

	// RVA: 0x1C6D3FC Offset: 0x1C693FC VA: 0x1C6D3FC
	internal Stream <GetStreamAsync>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private struct XmlDownloadManager.<GetNonFileStreamAsync>d__5 : IAsyncStateMachine // TypeDefIndex: 3242
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public Uri uri; // 0x20
	public ICredentials credentials; // 0x28
	public IWebProxy proxy; // 0x30
	public RequestCachePolicy cachePolicy; // 0x38
	public XmlDownloadManager <>4__this; // 0x40
	private WebRequest <req>5__2; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebResponse> <>u__1; // 0x50

	// Methods

	// RVA: 0x1C6D488 Offset: 0x1C69488 VA: 0x1C6D488 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C6DC90 Offset: 0x1C69C90 VA: 0x1C6DC90 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Xml
internal class XmlDownloadManager // TypeDefIndex: 3243
{
	// Fields
	private Hashtable connections; // 0x10

	// Methods

	// RVA: 0x1C6C7EC Offset: 0x1C687EC VA: 0x1C6C7EC
	internal Stream GetStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x1C6C8EC Offset: 0x1C688EC VA: 0x1C6C8EC
	private Stream GetNonFileStream(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x1C6CF8C Offset: 0x1C68F8C VA: 0x1C6CF8C
	internal void Remove(string host) { }

	// RVA: 0x1C6D100 Offset: 0x1C69100 VA: 0x1C6D100
	internal Task<Stream> GetStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	[AsyncStateMachine(typeof(XmlDownloadManager.<GetNonFileStreamAsync>d__5))]
	// RVA: 0x1C6D278 Offset: 0x1C69278 VA: 0x1C6D278
	private Task<Stream> GetNonFileStreamAsync(Uri uri, ICredentials credentials, IWebProxy proxy, RequestCachePolicy cachePolicy) { }

	// RVA: 0x1C6D3F4 Offset: 0x1C693F4 VA: 0x1C6D3F4
	public void .ctor() { }
}

// Namespace: System.Xml
internal class OpenedHost // TypeDefIndex: 3244
{
	// Fields
	internal int nonCachedConnectionsCount; // 0x10

	// Methods

	// RVA: 0x1C6CD70 Offset: 0x1C68D70 VA: 0x1C6CD70
	public void .ctor() { }
}

// Namespace: System.Xml
internal class XmlRegisteredNonCachedStream : Stream // TypeDefIndex: 3245
{
	// Fields
	protected Stream stream; // 0x28
	private XmlDownloadManager downloadManager; // 0x30
	private string host; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1C6CD78 Offset: 0x1C68D78 VA: 0x1C6CD78
	internal void .ctor(Stream stream, XmlDownloadManager downloadManager, string host) { }

	// RVA: 0x1C6DD0C Offset: 0x1C69D0C VA: 0x1C6DD0C Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1C6DDB0 Offset: 0x1C69DB0 VA: 0x1C6DDB0 Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1C6DEEC Offset: 0x1C69EEC VA: 0x1C6DEEC Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1C6DF0C Offset: 0x1C69F0C VA: 0x1C6DF0C Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1C6DF2C Offset: 0x1C69F2C VA: 0x1C6DF2C Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1C6DF4C Offset: 0x1C69F4C VA: 0x1C6DF4C Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1C6DF6C Offset: 0x1C69F6C VA: 0x1C6DF6C Slot: 21
	public override void Flush() { }

	// RVA: 0x1C6DF8C Offset: 0x1C69F8C VA: 0x1C6DF8C Slot: 32
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1C6DFAC Offset: 0x1C69FAC VA: 0x1C6DFAC Slot: 34
	public override int ReadByte() { }

	// RVA: 0x1C6DFCC Offset: 0x1C69FCC VA: 0x1C6DFCC Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1C6DFEC Offset: 0x1C69FEC VA: 0x1C6DFEC Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1C6E00C Offset: 0x1C6A00C VA: 0x1C6E00C Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1C6E02C Offset: 0x1C6A02C VA: 0x1C6E02C Slot: 37
	public override void WriteByte(byte value) { }

	// RVA: 0x1C6E04C Offset: 0x1C6A04C VA: 0x1C6E04C Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1C6E068 Offset: 0x1C6A068 VA: 0x1C6E068 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1C6E084 Offset: 0x1C6A084 VA: 0x1C6E084 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1C6E0A0 Offset: 0x1C6A0A0 VA: 0x1C6E0A0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1C6E0BC Offset: 0x1C6A0BC VA: 0x1C6E0BC Slot: 12
	public override long get_Position() { }

	// RVA: 0x1C6E0D8 Offset: 0x1C6A0D8 VA: 0x1C6E0D8 Slot: 13
	public override void set_Position(long value) { }
}

// Namespace: System.Xml
internal class XmlCachedStream : MemoryStream // TypeDefIndex: 3246
{
	// Fields
	private Uri uri; // 0x50

	// Methods

	// RVA: 0x1C6CE1C Offset: 0x1C68E1C VA: 0x1C6CE1C
	internal void .ctor(Uri uri, Stream stream) { }
}

// Namespace: System.Xml
internal class UTF16Decoder : Decoder // TypeDefIndex: 3247
{
	// Fields
	private bool bigEndian; // 0x20
	private int lastByte; // 0x24

	// Methods

	// RVA: 0x1C6E0F8 Offset: 0x1C6A0F8 VA: 0x1C6E0F8
	public void .ctor(bool bigEndian) { }

	// RVA: 0x1C6E128 Offset: 0x1C6A128 VA: 0x1C6E128 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x1C6E138 Offset: 0x1C6A138 VA: 0x1C6E138 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x1C6E214 Offset: 0x1C6A214 VA: 0x1C6E214 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1C6E38C Offset: 0x1C6A38C VA: 0x1C6E38C Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }
}

// Namespace: System.Xml
internal class SafeAsciiDecoder : Decoder // TypeDefIndex: 3248
{
	// Methods

	// RVA: 0x1C6E55C Offset: 0x1C6A55C VA: 0x1C6E55C
	public void .ctor() { }

	// RVA: 0x1C6E564 Offset: 0x1C6A564 VA: 0x1C6E564 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x1C6E56C Offset: 0x1C6A56C VA: 0x1C6E56C Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1C6E5DC Offset: 0x1C6A5DC VA: 0x1C6E5DC Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }
}

// Namespace: System.Xml
internal class Ucs4Encoding : Encoding // TypeDefIndex: 3249
{
	// Fields
	internal Ucs4Decoder ucs4Decoder; // 0x38

	// Properties
	public override string WebName { get; }
	public override int CodePage { get; }
	internal static Encoding UCS4_Littleendian { get; }
	internal static Encoding UCS4_Bigendian { get; }
	internal static Encoding UCS4_2143 { get; }
	internal static Encoding UCS4_3412 { get; }

	// Methods

	// RVA: 0x1C6E668 Offset: 0x1C6A668 VA: 0x1C6E668 Slot: 11
	public override string get_WebName() { }

	// RVA: 0x1C6E674 Offset: 0x1C6A674 VA: 0x1C6E674 Slot: 40
	public override Decoder GetDecoder() { }

	// RVA: 0x1C6E67C Offset: 0x1C6A67C VA: 0x1C6E67C Slot: 20
	public override int GetByteCount(char[] chars, int index, int count) { }

	// RVA: 0x1C6E6E0 Offset: 0x1C6A6E0 VA: 0x1C6E6E0 Slot: 26
	public override byte[] GetBytes(string s) { }

	// RVA: 0x1C6E6E8 Offset: 0x1C6A6E8 VA: 0x1C6E6E8 Slot: 25
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex) { }

	// RVA: 0x1C6E6F0 Offset: 0x1C6A6F0 VA: 0x1C6E6F0 Slot: 42
	public override int GetMaxByteCount(int charCount) { }

	// RVA: 0x1C6E6F8 Offset: 0x1C6A6F8 VA: 0x1C6E6F8 Slot: 30
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x1C6E714 Offset: 0x1C6A714 VA: 0x1C6E714 Slot: 34
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1C6E730 Offset: 0x1C6A730 VA: 0x1C6E730 Slot: 43
	public override int GetMaxCharCount(int byteCount) { }

	// RVA: 0x1C6E748 Offset: 0x1C6A748 VA: 0x1C6E748 Slot: 38
	public override int get_CodePage() { }

	// RVA: 0x1C6E750 Offset: 0x1C6A750 VA: 0x1C6E750 Slot: 41
	public override Encoder GetEncoder() { }

	// RVA: 0x1C6E758 Offset: 0x1C6A758 VA: 0x1C6E758
	internal static Encoding get_UCS4_Littleendian() { }

	// RVA: 0x1C6E810 Offset: 0x1C6A810 VA: 0x1C6E810
	internal static Encoding get_UCS4_Bigendian() { }

	// RVA: 0x1C6E8C8 Offset: 0x1C6A8C8 VA: 0x1C6E8C8
	internal static Encoding get_UCS4_2143() { }

	// RVA: 0x1C6E980 Offset: 0x1C6A980 VA: 0x1C6E980
	internal static Encoding get_UCS4_3412() { }

	// RVA: 0x1C6EA38 Offset: 0x1C6AA38 VA: 0x1C6EA38
	public void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Encoding1234 : Ucs4Encoding // TypeDefIndex: 3250
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x1C6E860 Offset: 0x1C6A860 VA: 0x1C6E860
	public void .ctor() { }

	// RVA: 0x1C6EA44 Offset: 0x1C6AA44 VA: 0x1C6EA44 Slot: 9
	public override string get_EncodingName() { }

	// RVA: 0x1C6EA84 Offset: 0x1C6AA84 VA: 0x1C6EA84 Slot: 6
	public override byte[] GetPreamble() { }
}

// Namespace: System.Xml
internal class Ucs4Encoding4321 : Ucs4Encoding // TypeDefIndex: 3251
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x1C6E7A8 Offset: 0x1C6A7A8 VA: 0x1C6E7A8
	public void .ctor() { }

	// RVA: 0x1C6EB00 Offset: 0x1C6AB00 VA: 0x1C6EB00 Slot: 9
	public override string get_EncodingName() { }

	// RVA: 0x1C6EB40 Offset: 0x1C6AB40 VA: 0x1C6EB40 Slot: 6
	public override byte[] GetPreamble() { }
}

// Namespace: System.Xml
internal class Ucs4Encoding2143 : Ucs4Encoding // TypeDefIndex: 3252
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x1C6E918 Offset: 0x1C6A918 VA: 0x1C6E918
	public void .ctor() { }

	// RVA: 0x1C6EBB8 Offset: 0x1C6ABB8 VA: 0x1C6EBB8 Slot: 9
	public override string get_EncodingName() { }

	// RVA: 0x1C6EBF8 Offset: 0x1C6ABF8 VA: 0x1C6EBF8 Slot: 6
	public override byte[] GetPreamble() { }
}

// Namespace: System.Xml
internal class Ucs4Encoding3412 : Ucs4Encoding // TypeDefIndex: 3253
{
	// Properties
	public override string EncodingName { get; }

	// Methods

	// RVA: 0x1C6E9D0 Offset: 0x1C6A9D0 VA: 0x1C6E9D0
	public void .ctor() { }

	// RVA: 0x1C6EC74 Offset: 0x1C6AC74 VA: 0x1C6EC74 Slot: 9
	public override string get_EncodingName() { }

	// RVA: 0x1C6ECB4 Offset: 0x1C6ACB4 VA: 0x1C6ECB4 Slot: 6
	public override byte[] GetPreamble() { }
}

// Namespace: System.Xml
internal abstract class Ucs4Decoder : Decoder // TypeDefIndex: 3254
{
	// Fields
	internal byte[] lastBytes; // 0x20
	internal int lastBytesCount; // 0x28

	// Methods

	// RVA: 0x1C6ED28 Offset: 0x1C6AD28 VA: 0x1C6ED28 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0x1C6ED44 Offset: 0x1C6AD44 VA: 0x1C6ED44 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1C6EEF4 Offset: 0x1C6AEF4 VA: 0x1C6EEF4 Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x1C6F128 Offset: 0x1C6B128 VA: 0x1C6F128
	internal void Ucs4ToUTF16(uint code, char[] chars, int charIndex) { }

	// RVA: 0x1C6F180 Offset: 0x1C6B180 VA: 0x1C6F180
	protected void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Decoder4321 : Ucs4Decoder // TypeDefIndex: 3255
{
	// Methods

	// RVA: 0x1C6F1E4 Offset: 0x1C6B1E4 VA: 0x1C6F1E4 Slot: 14
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1C6EAFC Offset: 0x1C6AAFC VA: 0x1C6EAFC
	public void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Decoder1234 : Ucs4Decoder // TypeDefIndex: 3256
{
	// Methods

	// RVA: 0x1C6F3EC Offset: 0x1C6B3EC VA: 0x1C6F3EC Slot: 14
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1C6EA40 Offset: 0x1C6AA40 VA: 0x1C6EA40
	public void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Decoder2143 : Ucs4Decoder // TypeDefIndex: 3257
{
	// Methods

	// RVA: 0x1C6F5F4 Offset: 0x1C6B5F4 VA: 0x1C6F5F4 Slot: 14
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1C6EBB4 Offset: 0x1C6ABB4 VA: 0x1C6EBB4
	public void .ctor() { }
}

// Namespace: System.Xml
internal class Ucs4Decoder3412 : Ucs4Decoder // TypeDefIndex: 3258
{
	// Methods

	// RVA: 0x1C6F7FC Offset: 0x1C6B7FC VA: 0x1C6F7FC Slot: 14
	internal override int GetFullChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x1C6EC70 Offset: 0x1C6AC70 VA: 0x1C6EC70
	public void .ctor() { }
}

// Namespace: System.Xml
[Serializable]
public class XmlException : SystemException // TypeDefIndex: 3259
{
	// Fields
	private string res; // 0x90
	private string[] args; // 0x98
	private int lineNumber; // 0xA0
	private int linePosition; // 0xA4
	[OptionalField]
	private string sourceUri; // 0xA8
	private string message; // 0xB0

	// Properties
	public int LineNumber { get; }
	public int LinePosition { get; }
	public override string Message { get; }
	internal string ResString { get; }

	// Methods

	// RVA: 0x1C6FA04 Offset: 0x1C6BA04 VA: 0x1C6FA04
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C70074 Offset: 0x1C6C074 VA: 0x1C70074 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1C701E4 Offset: 0x1C6C1E4 VA: 0x1C701E4
	public void .ctor() { }

	// RVA: 0x1C701FC Offset: 0x1C6C1FC VA: 0x1C701FC
	public void .ctor(string message) { }

	// RVA: 0x1C70218 Offset: 0x1C6C218 VA: 0x1C70218
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1C70210 Offset: 0x1C6C210 VA: 0x1C70210
	public void .ctor(string message, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x1C70228 Offset: 0x1C6C228 VA: 0x1C70228
	internal void .ctor(string message, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x1C64800 Offset: 0x1C60800 VA: 0x1C64800
	internal void .ctor(string res, string[] args) { }

	// RVA: 0x1C64624 Offset: 0x1C60624 VA: 0x1C64624
	internal void .ctor(string res, string arg) { }

	// RVA: 0x1C704F0 Offset: 0x1C6C4F0 VA: 0x1C704F0
	internal void .ctor(string res, string arg, string sourceUri) { }

	// RVA: 0x1C7059C Offset: 0x1C6C59C VA: 0x1C7059C
	internal void .ctor(string res, string arg, IXmlLineInfo lineInfo) { }

	// RVA: 0x1C707C4 Offset: 0x1C6C7C4 VA: 0x1C707C4
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo) { }

	// RVA: 0x1C70640 Offset: 0x1C6C640 VA: 0x1C70640
	internal void .ctor(string res, string[] args, IXmlLineInfo lineInfo, string sourceUri) { }

	// RVA: 0x1C6C01C Offset: 0x1C6801C VA: 0x1C6C01C
	internal void .ctor(string res, string arg, int lineNumber, int linePosition) { }

	// RVA: 0x1C707CC Offset: 0x1C6C7CC VA: 0x1C707CC
	internal void .ctor(string res, string arg, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x1C6C27C Offset: 0x1C6827C VA: 0x1C6C27C
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x1C70888 Offset: 0x1C6C888 VA: 0x1C70888
	internal void .ctor(string res, string[] args, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x1C7089C Offset: 0x1C6C89C VA: 0x1C7089C
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition) { }

	// RVA: 0x1C70448 Offset: 0x1C6C448 VA: 0x1C70448
	internal void .ctor(string res, string[] args, Exception innerException, int lineNumber, int linePosition, string sourceUri) { }

	// RVA: 0x1C70364 Offset: 0x1C6C364 VA: 0x1C70364
	private static string FormatUserMessage(string message, int lineNumber, int linePosition) { }

	// RVA: 0x1C6FDF4 Offset: 0x1C6BDF4 VA: 0x1C6FDF4
	private static string CreateMessage(string res, string[] args, int lineNumber, int linePosition) { }

	// RVA: 0x1C647A4 Offset: 0x1C607A4 VA: 0x1C647A4
	internal static string[] BuildCharExceptionArgs(string data, int invCharIndex) { }

	// RVA: 0x1C708A4 Offset: 0x1C6C8A4 VA: 0x1C708A4
	internal static string[] BuildCharExceptionArgs(char[] data, int length, int invCharIndex) { }

	// RVA: 0x1C64B20 Offset: 0x1C60B20 VA: 0x1C64B20
	internal static string[] BuildCharExceptionArgs(char invChar, char nextChar) { }

	// RVA: 0x1C708F8 Offset: 0x1C6C8F8 VA: 0x1C708F8
	public int get_LineNumber() { }

	// RVA: 0x1C70900 Offset: 0x1C6C900 VA: 0x1C70900
	public int get_LinePosition() { }

	// RVA: 0x1C70908 Offset: 0x1C6C908 VA: 0x1C70908 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1C70920 Offset: 0x1C6C920 VA: 0x1C70920
	internal string get_ResString() { }
}

// Namespace: System.Xml
public abstract class XmlNameTable // TypeDefIndex: 3260
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string Get(string array);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string Add(char[] array, int offset, int length);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string Add(string array);

	// RVA: 0x1C70928 Offset: 0x1C6C928 VA: 0x1C70928
	protected void .ctor() { }
}

// Namespace: System.Xml
public enum XmlNamespaceScope // TypeDefIndex: 3261
{
	// Fields
	public int value__; // 0x0
	public const XmlNamespaceScope All = 0;
	public const XmlNamespaceScope ExcludeXml = 1;
	public const XmlNamespaceScope Local = 2;
}

// Namespace: 
private struct XmlNamespaceManager.NamespaceDeclaration // TypeDefIndex: 3262
{
	// Fields
	public string prefix; // 0x0
	public string uri; // 0x8
	public int scopeId; // 0x10
	public int previousNsIndex; // 0x14

	// Methods

	// RVA: 0x1C70B94 Offset: 0x1C6CB94 VA: 0x1C70B94
	public void Set(string prefix, string uri, int scopeId, int previousNsIndex) { }
}

// Namespace: System.Xml
public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable // TypeDefIndex: 3263
{
	// Fields
	private XmlNamespaceManager.NamespaceDeclaration[] nsdecls; // 0x10
	private int lastDecl; // 0x18
	private XmlNameTable nameTable; // 0x20
	private int scopeId; // 0x28
	private Dictionary<string, int> hashTable; // 0x30
	private bool useHashtable; // 0x38
	private string xml; // 0x40
	private string xmlNs; // 0x48

	// Properties
	public virtual XmlNameTable NameTable { get; }
	public virtual string DefaultNamespace { get; }

	// Methods

	// RVA: 0x1C70930 Offset: 0x1C6C930 VA: 0x1C70930
	internal void .ctor() { }

	// RVA: 0x1C70938 Offset: 0x1C6C938 VA: 0x1C70938
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x1C70BDC Offset: 0x1C6CBDC VA: 0x1C70BDC Slot: 8
	public virtual XmlNameTable get_NameTable() { }

	// RVA: 0x1C70BE4 Offset: 0x1C6CBE4 VA: 0x1C70BE4 Slot: 9
	public virtual string get_DefaultNamespace() { }

	// RVA: 0x1C70C24 Offset: 0x1C6CC24 VA: 0x1C70C24 Slot: 10
	public virtual void PushScope() { }

	// RVA: 0x1C70C34 Offset: 0x1C6CC34 VA: 0x1C70C34 Slot: 11
	public virtual bool PopScope() { }

	// RVA: 0x1C70D10 Offset: 0x1C6CD10 VA: 0x1C70D10 Slot: 12
	public virtual void AddNamespace(string prefix, string uri) { }

	// RVA: 0x1C71290 Offset: 0x1C6D290 VA: 0x1C71290 Slot: 13
	public virtual void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x1C713D0 Offset: 0x1C6D3D0 VA: 0x1C713D0 Slot: 14
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1C71548 Offset: 0x1C6D548 VA: 0x1C71548 Slot: 15
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x1C71704 Offset: 0x1C6D704 VA: 0x1C71704 Slot: 16
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x1C710FC Offset: 0x1C6D0FC VA: 0x1C710FC
	private int LookupNamespaceDecl(string prefix) { }

	// RVA: 0x1C71750 Offset: 0x1C6D750 VA: 0x1C71750 Slot: 17
	public virtual string LookupPrefix(string uri) { }
}

// Namespace: System.Xml
public enum XmlNodeType // TypeDefIndex: 3264
{
	// Fields
	public int value__; // 0x0
	public const XmlNodeType None = 0;
	public const XmlNodeType Element = 1;
	public const XmlNodeType Attribute = 2;
	public const XmlNodeType Text = 3;
	public const XmlNodeType CDATA = 4;
	public const XmlNodeType EntityReference = 5;
	public const XmlNodeType Entity = 6;
	public const XmlNodeType ProcessingInstruction = 7;
	public const XmlNodeType Comment = 8;
	public const XmlNodeType Document = 9;
	public const XmlNodeType DocumentType = 10;
	public const XmlNodeType DocumentFragment = 11;
	public const XmlNodeType Notation = 12;
	public const XmlNodeType Whitespace = 13;
	public const XmlNodeType SignificantWhitespace = 14;
	public const XmlNodeType EndElement = 15;
	public const XmlNodeType EndEntity = 16;
	public const XmlNodeType XmlDeclaration = 17;
}

// Namespace: 
private sealed class XmlQualifiedName.HashCodeOfStringDelegate : MulticastDelegate // TypeDefIndex: 3265
{
	// Methods

	// RVA: 0x1C71DEC Offset: 0x1C6DDEC VA: 0x1C71DEC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C722B4 Offset: 0x1C6E2B4 VA: 0x1C722B4 Slot: 12
	public virtual int Invoke(string s, int sLen, long additionalEntropy) { }
}

// Namespace: System.Xml
[Serializable]
public class XmlQualifiedName // TypeDefIndex: 3266
{
	// Fields
	private static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private string name; // 0x10
	private string ns; // 0x18
	private int hash; // 0x20
	public static readonly XmlQualifiedName Empty; // 0x8

	// Properties
	public string Namespace { get; }
	public string Name { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x1C71814 Offset: 0x1C6D814 VA: 0x1C71814
	public void .ctor() { }

	// RVA: 0x1C718AC Offset: 0x1C6D8AC VA: 0x1C718AC
	public void .ctor(string name) { }

	// RVA: 0x1C71830 Offset: 0x1C6D830 VA: 0x1C71830
	public void .ctor(string name, string ns) { }

	// RVA: 0x1C718C4 Offset: 0x1C6D8C4 VA: 0x1C718C4
	public string get_Namespace() { }

	// RVA: 0x1C718CC Offset: 0x1C6D8CC VA: 0x1C718CC
	public string get_Name() { }

	// RVA: 0x1C718D4 Offset: 0x1C6D8D4 VA: 0x1C718D4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C71B10 Offset: 0x1C6DB10 VA: 0x1C71B10
	public bool get_IsEmpty() { }

	// RVA: 0x1C71B4C Offset: 0x1C6DB4C VA: 0x1C71B4C Slot: 3
	public override string ToString() { }

	// RVA: 0x1C71BBC Offset: 0x1C6DBBC VA: 0x1C71BBC Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1C71D0C Offset: 0x1C6DD0C VA: 0x1C71D0C
	public static bool op_Equality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x1C71C9C Offset: 0x1C6DC9C VA: 0x1C71C9C
	public static bool op_Inequality(XmlQualifiedName a, XmlQualifiedName b) { }

	// RVA: 0x1C71D74 Offset: 0x1C6DD74 VA: 0x1C71D74
	public static string ToString(string name, string ns) { }

	// RVA: 0x1C719B0 Offset: 0x1C6D9B0 VA: 0x1C719B0
	private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate() { }

	// RVA: 0x1C71DE4 Offset: 0x1C6DDE4 VA: 0x1C71DE4
	private static bool IsRandomizedHashingDisabled() { }

	// RVA: 0x1C71EA0 Offset: 0x1C6DEA0 VA: 0x1C71EA0
	private static int GetHashCodeOfString(string s, int length, long additionalEntropy) { }

	// RVA: 0x1C71EB8 Offset: 0x1C6DEB8 VA: 0x1C71EB8
	internal void Init(string name, string ns) { }

	// RVA: 0x1C71EF0 Offset: 0x1C6DEF0 VA: 0x1C71EF0
	internal void SetNamespace(string ns) { }

	// RVA: 0x1C71EF8 Offset: 0x1C6DEF8 VA: 0x1C71EF8
	internal void Verify() { }

	// RVA: 0x1C71F88 Offset: 0x1C6DF88 VA: 0x1C71F88
	internal void Atomize(XmlNameTable nameTable) { }

	// RVA: 0x1C71FF4 Offset: 0x1C6DFF4 VA: 0x1C71FF4
	internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix) { }

	// RVA: 0x1C72198 Offset: 0x1C6E198 VA: 0x1C72198
	internal XmlQualifiedName Clone() { }

	// RVA: 0x1C72218 Offset: 0x1C6E218 VA: 0x1C72218
	private static void .cctor() { }
}

// Namespace: System.Xml
public abstract class XmlResolver // TypeDefIndex: 3267
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

	// RVA: 0x1C722C8 Offset: 0x1C6E2C8 VA: 0x1C722C8 Slot: 5
	public virtual Uri ResolveUri(Uri baseUri, string relativeUri) { }

	// RVA: 0x1C72490 Offset: 0x1C6E490 VA: 0x1C72490 Slot: 6
	public virtual bool SupportsType(Uri absoluteUri, Type type) { }

	// RVA: 0x1C725C8 Offset: 0x1C6E5C8 VA: 0x1C725C8 Slot: 7
	public virtual Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x1C72600 Offset: 0x1C6E600 VA: 0x1C72600
	protected void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct XmlUrlResolver.<GetEntityAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 3268
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<object> <>t__builder; // 0x8
	public Type ofObjectToReturn; // 0x20
	public Uri absoluteUri; // 0x28
	public XmlUrlResolver <>4__this; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__1; // 0x38

	// Methods

	// RVA: 0x1C72978 Offset: 0x1C6E978 VA: 0x1C72978 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1C72D48 Offset: 0x1C6ED48 VA: 0x1C72D48 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Xml
public class XmlUrlResolver : XmlResolver // TypeDefIndex: 3269
{
	// Fields
	private static object s_DownloadManager; // 0x0
	private ICredentials _credentials; // 0x10
	private IWebProxy _proxy; // 0x18
	private RequestCachePolicy _cachePolicy; // 0x20

	// Properties
	private static XmlDownloadManager DownloadManager { get; }

	// Methods

	// RVA: 0x1C72608 Offset: 0x1C6E608 VA: 0x1C72608
	private static XmlDownloadManager get_DownloadManager() { }

	// RVA: 0x1C726D4 Offset: 0x1C6E6D4 VA: 0x1C726D4
	public void .ctor() { }

	// RVA: 0x1C726DC Offset: 0x1C6E6DC VA: 0x1C726DC Slot: 4
	public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn) { }

	// RVA: 0x1C7282C Offset: 0x1C6E82C VA: 0x1C7282C Slot: 5
	public override Uri ResolveUri(Uri baseUri, string relativeUri) { }

	[AsyncStateMachine(typeof(XmlUrlResolver.<GetEntityAsync>d__15))]
	// RVA: 0x1C72830 Offset: 0x1C6E830 VA: 0x1C72830 Slot: 7
	public override Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn) { }
}

// Namespace: System.Xml
internal static class BinaryCompatibility // TypeDefIndex: 3270
{
	// Properties
	public static bool TargetsAtLeast_Desktop_V4_5_2 { get; }

	// Methods

	// RVA: 0x1C72DC4 Offset: 0x1C6EDC4 VA: 0x1C72DC4
	public static bool get_TargetsAtLeast_Desktop_V4_5_2() { }
}

// Namespace: System.Xml
internal static class Res // TypeDefIndex: 3271
{
	// Methods

	// RVA: 0x1C67178 Offset: 0x1C63178 VA: 0x1C67178
	public static string GetString(string name) { }

	// RVA: 0x1C64D94 Offset: 0x1C60D94 VA: 0x1C64D94
	public static string GetString(string name, object[] args) { }
}
