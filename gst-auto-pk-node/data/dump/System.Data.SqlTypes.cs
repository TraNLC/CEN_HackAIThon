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

// Namespace: System.Data.SqlTypes
internal static class SQLResource // TypeDefIndex: 4572
{
	// Properties
	internal static string NullString { get; }
	internal static string ArithOverflowMessage { get; }
	internal static string DivideByZeroMessage { get; }
	internal static string NullValueMessage { get; }
	internal static string TruncationMessage { get; }
	internal static string DateTimeOverflowMessage { get; }
	internal static string ConcatDiffCollationMessage { get; }
	internal static string CompareDiffCollationMessage { get; }
	internal static string ConversionOverflowMessage { get; }
	internal static string TimeZoneSpecifiedMessage { get; }
	internal static string InvalidPrecScaleMessage { get; }
	internal static string FormatMessage { get; }

	// Methods

	// RVA: 0x1ACDB88 Offset: 0x1AC9B88 VA: 0x1ACDB88
	internal static string get_NullString() { }

	// RVA: 0x1ACDBC8 Offset: 0x1AC9BC8 VA: 0x1ACDBC8
	internal static string get_ArithOverflowMessage() { }

	// RVA: 0x1ACDC08 Offset: 0x1AC9C08 VA: 0x1ACDC08
	internal static string get_DivideByZeroMessage() { }

	// RVA: 0x1ACDC48 Offset: 0x1AC9C48 VA: 0x1ACDC48
	internal static string get_NullValueMessage() { }

	// RVA: 0x1ACDC88 Offset: 0x1AC9C88 VA: 0x1ACDC88
	internal static string get_TruncationMessage() { }

	// RVA: 0x1ACDCC8 Offset: 0x1AC9CC8 VA: 0x1ACDCC8
	internal static string get_DateTimeOverflowMessage() { }

	// RVA: 0x1ACDD08 Offset: 0x1AC9D08 VA: 0x1ACDD08
	internal static string get_ConcatDiffCollationMessage() { }

	// RVA: 0x1ACDD48 Offset: 0x1AC9D48 VA: 0x1ACDD48
	internal static string get_CompareDiffCollationMessage() { }

	// RVA: 0x1ACDD88 Offset: 0x1AC9D88 VA: 0x1ACDD88
	internal static string get_ConversionOverflowMessage() { }

	// RVA: 0x1ACDDC8 Offset: 0x1AC9DC8 VA: 0x1ACDDC8
	internal static string get_TimeZoneSpecifiedMessage() { }

	// RVA: 0x1ACDE08 Offset: 0x1AC9E08 VA: 0x1ACDE08
	internal static string get_InvalidPrecScaleMessage() { }

	// RVA: 0x1ACDE48 Offset: 0x1AC9E48 VA: 0x1ACDE48
	internal static string get_FormatMessage() { }

	// RVA: 0x1ACDE88 Offset: 0x1AC9E88 VA: 0x1ACDE88
	internal static string InvalidOpStreamClosed(string method) { }

	// RVA: 0x1ACDED4 Offset: 0x1AC9ED4 VA: 0x1ACDED4
	internal static string InvalidOpStreamNonWritable(string method) { }

	// RVA: 0x1ACDF20 Offset: 0x1AC9F20 VA: 0x1ACDF20
	internal static string InvalidOpStreamNonReadable(string method) { }

	// RVA: 0x1ACDF6C Offset: 0x1AC9F6C VA: 0x1ACDF6C
	internal static string InvalidOpStreamNonSeekable(string method) { }
}

// Namespace: System.Data.SqlTypes
public interface INullable // TypeDefIndex: 4573
{
	// Properties
	public abstract bool IsNull { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsNull();
}

// Namespace: System.Data.SqlTypes
[DefaultMember("Item")]
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlBinary : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4574
{
	// Fields
	private byte[] _value; // 0x0
	public static readonly SqlBinary Null; // 0x0

	// Properties
	public bool IsNull { get; }
	public byte[] Value { get; }

	// Methods

	// RVA: 0x1ACDFB8 Offset: 0x1AC9FB8 VA: 0x1ACDFB8
	private void .ctor(bool fNull) { }

	// RVA: 0x1ACDFC4 Offset: 0x1AC9FC4 VA: 0x1ACDFC4
	public void .ctor(byte[] value) { }

	// RVA: 0x1ACE050 Offset: 0x1ACA050 VA: 0x1ACE050 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1ACE060 Offset: 0x1ACA060 VA: 0x1ACE060
	public byte[] get_Value() { }

	// RVA: 0x1ACE134 Offset: 0x1ACA134 VA: 0x1ACE134
	public static SqlBinary op_Implicit(byte[] x) { }

	// RVA: 0x1ACE150 Offset: 0x1ACA150 VA: 0x1ACE150 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ACE268 Offset: 0x1ACA268 VA: 0x1ACE268
	private static EComparison PerformCompareByte(byte[] x, byte[] y) { }

	// RVA: 0x1ACE374 Offset: 0x1ACA374 VA: 0x1ACE374
	public static SqlBoolean op_Equality(SqlBinary x, SqlBinary y) { }

	// RVA: 0x1ACE484 Offset: 0x1ACA484 VA: 0x1ACE484
	public static SqlBoolean op_LessThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x1ACE580 Offset: 0x1ACA580 VA: 0x1ACE580
	public static SqlBoolean op_GreaterThan(SqlBinary x, SqlBinary y) { }

	// RVA: 0x1ACE67C Offset: 0x1ACA67C VA: 0x1ACE67C Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1ACE784 Offset: 0x1ACA784 VA: 0x1ACE784
	public int CompareTo(SqlBinary value) { }

	// RVA: 0x1ACE91C Offset: 0x1ACA91C VA: 0x1ACE91C Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1ACEAA4 Offset: 0x1ACAAA4 VA: 0x1ACEAA4
	internal static int HashByteArray(byte[] rgbValue, int length) { }

	// RVA: 0x1ACEB04 Offset: 0x1ACAB04 VA: 0x1ACEB04 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ACEBCC Offset: 0x1ACABCC VA: 0x1ACEBCC Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1ACEBD4 Offset: 0x1ACABD4 VA: 0x1ACEBD4 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1ACED84 Offset: 0x1ACAD84 VA: 0x1ACED84 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1ACEEB0 Offset: 0x1ACAEB0 VA: 0x1ACEEB0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1ACEF3C Offset: 0x1ACAF3C VA: 0x1ACEF3C
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlBoolean : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4575
{
	// Fields
	private byte m_value; // 0x0
	public static readonly SqlBoolean True; // 0x0
	public static readonly SqlBoolean False; // 0x1
	public static readonly SqlBoolean Null; // 0x2
	public static readonly SqlBoolean Zero; // 0x3
	public static readonly SqlBoolean One; // 0x4

	// Properties
	public bool IsNull { get; }
	public bool Value { get; }
	public bool IsTrue { get; }
	public bool IsFalse { get; }
	public byte ByteValue { get; }

	// Methods

	// RVA: 0x1ACE470 Offset: 0x1ACA470 VA: 0x1ACE470
	public void .ctor(bool value) { }

	// RVA: 0x1ACEFA8 Offset: 0x1ACAFA8 VA: 0x1ACEFA8
	public void .ctor(int value) { }

	// RVA: 0x1ACF014 Offset: 0x1ACB014 VA: 0x1ACF014
	private void .ctor(int value, bool fNull) { }

	// RVA: 0x1ACF030 Offset: 0x1ACB030 VA: 0x1ACF030 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1ACEA50 Offset: 0x1ACAA50 VA: 0x1ACEA50
	public bool get_Value() { }

	// RVA: 0x1ACF040 Offset: 0x1ACB040 VA: 0x1ACF040
	public bool get_IsTrue() { }

	// RVA: 0x1ACF050 Offset: 0x1ACB050 VA: 0x1ACF050
	public bool get_IsFalse() { }

	// RVA: 0x1ACF060 Offset: 0x1ACB060 VA: 0x1ACF060
	public static SqlBoolean op_Implicit(bool x) { }

	// RVA: 0x1ACE8C0 Offset: 0x1ACA8C0 VA: 0x1ACE8C0
	public static bool op_True(SqlBoolean x) { }

	// RVA: 0x1ACF070 Offset: 0x1ACB070 VA: 0x1ACF070
	public static SqlBoolean op_BitwiseAnd(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1ACF130 Offset: 0x1ACB130 VA: 0x1ACF130
	public static SqlBoolean op_BitwiseOr(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1ACF1F0 Offset: 0x1ACB1F0 VA: 0x1ACF1F0
	public byte get_ByteValue() { }

	// RVA: 0x1ACF284 Offset: 0x1ACB284 VA: 0x1ACF284 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ACF360 Offset: 0x1ACB360 VA: 0x1ACF360
	public static SqlBoolean op_Equality(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1ACF410 Offset: 0x1ACB410 VA: 0x1ACF410
	public static SqlBoolean And(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1ACF474 Offset: 0x1ACB474 VA: 0x1ACF474
	public static SqlBoolean Or(SqlBoolean x, SqlBoolean y) { }

	// RVA: 0x1ACF4D8 Offset: 0x1ACB4D8 VA: 0x1ACF4D8 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1ACF5E0 Offset: 0x1ACB5E0 VA: 0x1ACF5E0
	public int CompareTo(SqlBoolean value) { }

	// RVA: 0x1ACF6E0 Offset: 0x1ACB6E0 VA: 0x1ACF6E0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1ACF7EC Offset: 0x1ACB7EC VA: 0x1ACF7EC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ACF8A0 Offset: 0x1ACB8A0 VA: 0x1ACF8A0 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1ACF8A8 Offset: 0x1ACB8A8 VA: 0x1ACF8A8 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1ACF9CC Offset: 0x1ACB9CC VA: 0x1ACF9CC Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1ACFAE4 Offset: 0x1ACBAE4 VA: 0x1ACFAE4
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1ACFB70 Offset: 0x1ACBB70 VA: 0x1ACFB70
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlByte : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4576
{
	// Fields
	private bool m_fNotNull; // 0x0
	private byte m_value; // 0x1
	private static readonly int s_iBitNotByteMax; // 0x0
	public static readonly SqlByte Null; // 0x4
	public static readonly SqlByte Zero; // 0x6
	public static readonly SqlByte MinValue; // 0x8
	public static readonly SqlByte MaxValue; // 0xA

	// Properties
	public bool IsNull { get; }
	public byte Value { get; }

	// Methods

	// RVA: 0x1ACFC18 Offset: 0x1ACBC18 VA: 0x1ACFC18
	private void .ctor(bool fNull) { }

	// RVA: 0x1ACFC20 Offset: 0x1ACBC20 VA: 0x1ACFC20
	public void .ctor(byte value) { }

	// RVA: 0x1ACFC30 Offset: 0x1ACBC30 VA: 0x1ACFC30 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1ACFC40 Offset: 0x1ACBC40 VA: 0x1ACFC40
	public byte get_Value() { }

	// RVA: 0x1ACFC88 Offset: 0x1ACBC88 VA: 0x1ACFC88
	public static SqlByte op_Implicit(byte x) { }

	// RVA: 0x1ACFC94 Offset: 0x1ACBC94 VA: 0x1ACFC94 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ACFD30 Offset: 0x1ACBD30 VA: 0x1ACFD30
	public static SqlByte op_Addition(SqlByte x, SqlByte y) { }

	// RVA: 0x1ACFE48 Offset: 0x1ACBE48 VA: 0x1ACFE48
	public static SqlByte op_Subtraction(SqlByte x, SqlByte y) { }

	// RVA: 0x1ACFF5C Offset: 0x1ACBF5C VA: 0x1ACFF5C
	public static SqlByte op_Multiply(SqlByte x, SqlByte y) { }

	// RVA: 0x1AD0074 Offset: 0x1ACC074 VA: 0x1AD0074
	public static SqlByte op_Division(SqlByte x, SqlByte y) { }

	// RVA: 0x1AD0170 Offset: 0x1ACC170 VA: 0x1AD0170
	public static SqlByte op_Explicit(SqlInt64 x) { }

	// RVA: 0x1AD0314 Offset: 0x1ACC314 VA: 0x1AD0314
	public static SqlBoolean op_Equality(SqlByte x, SqlByte y) { }

	// RVA: 0x1AD03D8 Offset: 0x1ACC3D8 VA: 0x1AD03D8
	public static SqlBoolean op_LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0x1AD049C Offset: 0x1ACC49C VA: 0x1AD049C
	public static SqlBoolean op_GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x1AD0560 Offset: 0x1ACC560 VA: 0x1AD0560
	public static SqlBoolean LessThan(SqlByte x, SqlByte y) { }

	// RVA: 0x1AD05C4 Offset: 0x1ACC5C4 VA: 0x1AD05C4
	public static SqlBoolean GreaterThan(SqlByte x, SqlByte y) { }

	// RVA: 0x1AD0628 Offset: 0x1ACC628 VA: 0x1AD0628
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1AD074C Offset: 0x1ACC74C VA: 0x1AD074C
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1AD0860 Offset: 0x1ACC860 VA: 0x1AD0860 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1AD0968 Offset: 0x1ACC968 VA: 0x1AD0968
	public int CompareTo(SqlByte value) { }

	// RVA: 0x1AD0AA8 Offset: 0x1ACCAA8 VA: 0x1AD0AA8 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1AD0BE0 Offset: 0x1ACCBE0 VA: 0x1AD0BE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AD0C74 Offset: 0x1ACCC74 VA: 0x1AD0C74 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1AD0C7C Offset: 0x1ACCC7C VA: 0x1AD0C7C Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1AD0D9C Offset: 0x1ACCD9C VA: 0x1AD0D9C Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1AD0ECC Offset: 0x1ACCECC VA: 0x1AD0ECC
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1AD0F58 Offset: 0x1ACCF58 VA: 0x1AD0F58
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
internal enum SqlBytesCharsState // TypeDefIndex: 4577
{
	// Fields
	public int value__; // 0x0
	public const SqlBytesCharsState Null = 0;
	public const SqlBytesCharsState Buffer = 1;
	public const SqlBytesCharsState Stream = 3;
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[DefaultMember("Item")]
[Serializable]
public sealed class SqlBytes : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 4578
{
	// Fields
	internal byte[] _rgbBuf; // 0x10
	private long _lCurLen; // 0x18
	internal Stream _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private byte[] _rgbWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public byte[] Buffer { get; }
	public long Length { get; }
	public byte[] Value { get; }
	public static SqlBytes Null { get; }

	// Methods

	// RVA: 0x1AD0FD0 Offset: 0x1ACCFD0 VA: 0x1AD0FD0
	public void .ctor() { }

	// RVA: 0x1AD1030 Offset: 0x1ACD030 VA: 0x1AD1030
	public void .ctor(byte[] buffer) { }

	// RVA: 0x1AD10A8 Offset: 0x1ACD0A8 VA: 0x1AD10A8
	public void .ctor(SqlBinary value) { }

	// RVA: 0x1AD1138 Offset: 0x1ACD138 VA: 0x1AD1138 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1AD1148 Offset: 0x1ACD148 VA: 0x1AD1148
	public byte[] get_Buffer() { }

	// RVA: 0x1AD12F4 Offset: 0x1ACD2F4 VA: 0x1AD12F4
	public long get_Length() { }

	// RVA: 0x1AD1364 Offset: 0x1ACD364 VA: 0x1AD1364
	public byte[] get_Value() { }

	// RVA: 0x1AD1004 Offset: 0x1ACD004 VA: 0x1AD1004
	public void SetNull() { }

	// RVA: 0x1AD1180 Offset: 0x1ACD180 VA: 0x1AD1180
	private void CopyStreamToBuffer() { }

	// RVA: 0x1AD1170 Offset: 0x1ACD170 VA: 0x1AD1170
	internal bool FStream() { }

	// RVA: 0x1AD1548 Offset: 0x1ACD548 VA: 0x1AD1548
	private void SetBuffer(byte[] buffer) { }

	// RVA: 0x1AD15A8 Offset: 0x1ACD5A8 VA: 0x1AD15A8 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1AD15B0 Offset: 0x1ACD5B0 VA: 0x1AD15B0 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x1AD177C Offset: 0x1ACD77C VA: 0x1AD177C Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1AD18B0 Offset: 0x1ACD8B0 VA: 0x1AD18B0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1AD193C Offset: 0x1ACD93C VA: 0x1AD193C Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AD1974 Offset: 0x1ACD974 VA: 0x1AD1974
	public static SqlBytes get_Null() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[DefaultMember("Item")]
[Serializable]
public sealed class SqlChars : INullable, IXmlSerializable, ISerializable // TypeDefIndex: 4579
{
	// Fields
	internal char[] _rgchBuf; // 0x10
	private long _lCurLen; // 0x18
	internal SqlStreamChars _stream; // 0x20
	private SqlBytesCharsState _state; // 0x28
	private char[] _rgchWorkBuf; // 0x30

	// Properties
	public bool IsNull { get; }
	public char[] Buffer { get; }
	public long Length { get; }
	public char[] Value { get; }
	public static SqlChars Null { get; }

	// Methods

	// RVA: 0x1AD19C8 Offset: 0x1ACD9C8 VA: 0x1AD19C8
	public void .ctor() { }

	// RVA: 0x1AD1A28 Offset: 0x1ACDA28 VA: 0x1AD1A28
	public void .ctor(char[] buffer) { }

	// RVA: 0x1AD1AA0 Offset: 0x1ACDAA0 VA: 0x1AD1AA0
	public void .ctor(SqlString value) { }

	// RVA: 0x1AD1B44 Offset: 0x1ACDB44 VA: 0x1AD1B44 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1AD1B54 Offset: 0x1ACDB54 VA: 0x1AD1B54
	public char[] get_Buffer() { }

	// RVA: 0x1AD1CF8 Offset: 0x1ACDCF8 VA: 0x1AD1CF8
	public long get_Length() { }

	// RVA: 0x1AD1D68 Offset: 0x1ACDD68 VA: 0x1AD1D68
	public char[] get_Value() { }

	// RVA: 0x1AD19FC Offset: 0x1ACD9FC VA: 0x1AD19FC
	public void SetNull() { }

	// RVA: 0x1AD1B7C Offset: 0x1ACDB7C VA: 0x1AD1B7C
	internal bool FStream() { }

	// RVA: 0x1AD1B8C Offset: 0x1ACDB8C VA: 0x1AD1B8C
	private void CopyStreamToBuffer() { }

	// RVA: 0x1AD1F44 Offset: 0x1ACDF44 VA: 0x1AD1F44
	private void SetBuffer(char[] buffer) { }

	// RVA: 0x1AD1FA4 Offset: 0x1ACDFA4 VA: 0x1AD1FA4 Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1AD1FAC Offset: 0x1ACDFAC VA: 0x1AD1FAC Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x1AD20C8 Offset: 0x1ACE0C8 VA: 0x1AD20C8 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1AD21C8 Offset: 0x1ACE1C8 VA: 0x1AD21C8
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1AD2254 Offset: 0x1ACE254 VA: 0x1AD2254 Slot: 8
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1AD228C Offset: 0x1ACE28C VA: 0x1AD228C
	public static SqlChars get_Null() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlDateTime : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4580
{
	// Fields
	private bool m_fNotNull; // 0x0
	private int m_day; // 0x4
	private int m_time; // 0x8
	private static readonly double s_SQLTicksPerMillisecond; // 0x0
	public static readonly int SQLTicksPerSecond; // 0x8
	public static readonly int SQLTicksPerMinute; // 0xC
	public static readonly int SQLTicksPerHour; // 0x10
	private static readonly int s_SQLTicksPerDay; // 0x14
	private static readonly long s_ticksPerSecond; // 0x18
	private static readonly DateTime s_SQLBaseDate; // 0x20
	private static readonly long s_SQLBaseDateTicks; // 0x28
	private static readonly int s_minYear; // 0x30
	private static readonly int s_maxYear; // 0x34
	private static readonly int s_minDay; // 0x38
	private static readonly int s_maxDay; // 0x3C
	private static readonly int s_minTime; // 0x40
	private static readonly int s_maxTime; // 0x44
	private static readonly int s_dayBase; // 0x48
	private static readonly int[] s_daysToMonth365; // 0x50
	private static readonly int[] s_daysToMonth366; // 0x58
	private static readonly DateTime s_minDateTime; // 0x60
	private static readonly DateTime s_maxDateTime; // 0x68
	private static readonly TimeSpan s_minTimeSpan; // 0x70
	private static readonly TimeSpan s_maxTimeSpan; // 0x78
	private static readonly string s_ISO8601_DateTimeFormat; // 0x80
	private static readonly string[] s_dateTimeFormats; // 0x88
	public static readonly SqlDateTime MinValue; // 0x90
	public static readonly SqlDateTime MaxValue; // 0x9C
	public static readonly SqlDateTime Null; // 0xA8

	// Properties
	public bool IsNull { get; }
	public DateTime Value { get; }
	public int DayTicks { get; }
	public int TimeTicks { get; }

	// Methods

	// RVA: 0x1AD22E0 Offset: 0x1ACE2E0 VA: 0x1AD22E0
	private void .ctor(bool fNull) { }

	// RVA: 0x1AD22EC Offset: 0x1ACE2EC VA: 0x1AD22EC
	public void .ctor(DateTime value) { }

	// RVA: 0x1AD244C Offset: 0x1ACE44C VA: 0x1AD244C
	public void .ctor(int dayTicks, int timeTicks) { }

	// RVA: 0x1AD2570 Offset: 0x1ACE570 VA: 0x1AD2570 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1AD2580 Offset: 0x1ACE580 VA: 0x1AD2580
	private static TimeSpan ToTimeSpan(SqlDateTime value) { }

	// RVA: 0x1AD2628 Offset: 0x1ACE628 VA: 0x1AD2628
	private static DateTime ToDateTime(SqlDateTime value) { }

	// RVA: 0x1AD26D0 Offset: 0x1ACE6D0 VA: 0x1AD26D0
	private static SqlDateTime FromTimeSpan(TimeSpan value) { }

	// RVA: 0x1AD2358 Offset: 0x1ACE358 VA: 0x1AD2358
	private static SqlDateTime FromDateTime(DateTime value) { }

	// RVA: 0x1AD28D8 Offset: 0x1ACE8D8 VA: 0x1AD28D8
	public DateTime get_Value() { }

	// RVA: 0x1AD2974 Offset: 0x1ACE974 VA: 0x1AD2974
	public int get_DayTicks() { }

	// RVA: 0x1AD29BC Offset: 0x1ACE9BC VA: 0x1AD29BC
	public int get_TimeTicks() { }

	// RVA: 0x1AD2A04 Offset: 0x1ACEA04 VA: 0x1AD2A04
	public static SqlDateTime op_Implicit(DateTime value) { }

	// RVA: 0x1AD2A34 Offset: 0x1ACEA34 VA: 0x1AD2A34 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AD2B28 Offset: 0x1ACEB28 VA: 0x1AD2B28
	public static SqlBoolean op_Equality(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1AD2C00 Offset: 0x1ACEC00 VA: 0x1AD2C00
	public static SqlBoolean op_LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1AD2CEC Offset: 0x1ACECEC VA: 0x1AD2CEC
	public static SqlBoolean op_GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1AD2DD8 Offset: 0x1ACEDD8 VA: 0x1AD2DD8
	public static SqlBoolean LessThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1AD2E54 Offset: 0x1ACEE54 VA: 0x1AD2E54
	public static SqlBoolean GreaterThan(SqlDateTime x, SqlDateTime y) { }

	// RVA: 0x1AD2ED0 Offset: 0x1ACEED0 VA: 0x1AD2ED0 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1AD2FE0 Offset: 0x1ACEFE0 VA: 0x1AD2FE0
	public int CompareTo(SqlDateTime value) { }

	// RVA: 0x1AD3144 Offset: 0x1ACF144 VA: 0x1AD3144 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1AD3290 Offset: 0x1ACF290 VA: 0x1AD3290 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AD334C Offset: 0x1ACF34C VA: 0x1AD334C Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1AD3354 Offset: 0x1ACF354 VA: 0x1AD3354 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1AD3554 Offset: 0x1ACF554 VA: 0x1AD3554 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1AD36B0 Offset: 0x1ACF6B0 VA: 0x1AD36B0
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1AD373C Offset: 0x1ACF73C VA: 0x1AD373C
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlDecimal : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4581
{
	// Fields
	internal byte _bStatus; // 0x0
	internal byte _bLen; // 0x1
	internal byte _bPrec; // 0x2
	internal byte _bScale; // 0x3
	internal uint _data1; // 0x4
	internal uint _data2; // 0x8
	internal uint _data3; // 0xC
	internal uint _data4; // 0x10
	private static readonly byte s_NUMERIC_MAX_PRECISION; // 0x0
	public static readonly byte MaxPrecision; // 0x1
	public static readonly byte MaxScale; // 0x2
	private static readonly byte s_bNullMask; // 0x3
	private static readonly byte s_bIsNull; // 0x4
	private static readonly byte s_bNotNull; // 0x5
	private static readonly byte s_bReverseNullMask; // 0x6
	private static readonly byte s_bSignMask; // 0x7
	private static readonly byte s_bPositive; // 0x8
	private static readonly byte s_bNegative; // 0x9
	private static readonly byte s_bReverseSignMask; // 0xA
	private static readonly uint s_uiZero; // 0xC
	private static readonly int s_cNumeMax; // 0x10
	private static readonly long s_lInt32Base; // 0x18
	private static readonly ulong s_ulInt32Base; // 0x20
	private static readonly ulong s_ulInt32BaseForMod; // 0x28
	internal static readonly ulong s_llMax; // 0x30
	private static readonly uint s_ulBase10; // 0x38
	private static readonly double s_DUINT_BASE; // 0x40
	private static readonly double s_DUINT_BASE2; // 0x48
	private static readonly double s_DUINT_BASE3; // 0x50
	private static readonly double s_DMAX_NUME; // 0x58
	private static readonly uint s_DBL_DIG; // 0x60
	private static readonly byte s_cNumeDivScaleMin; // 0x64
	private static readonly uint[] s_rgulShiftBase; // 0x68
	private static readonly uint[] s_decimalHelpersLo; // 0x70
	private static readonly uint[] s_decimalHelpersMid; // 0x78
	private static readonly uint[] s_decimalHelpersHi; // 0x80
	private static readonly uint[] s_decimalHelpersHiHi; // 0x88
	private static readonly byte[] s_rgCLenFromPrec; // 0x90
	private static readonly uint s_ulT1; // 0x98
	private static readonly uint s_ulT2; // 0x9C
	private static readonly uint s_ulT3; // 0xA0
	private static readonly uint s_ulT4; // 0xA4
	private static readonly uint s_ulT5; // 0xA8
	private static readonly uint s_ulT6; // 0xAC
	private static readonly uint s_ulT7; // 0xB0
	private static readonly uint s_ulT8; // 0xB4
	private static readonly uint s_ulT9; // 0xB8
	private static readonly ulong s_dwlT10; // 0xC0
	private static readonly ulong s_dwlT11; // 0xC8
	private static readonly ulong s_dwlT12; // 0xD0
	private static readonly ulong s_dwlT13; // 0xD8
	private static readonly ulong s_dwlT14; // 0xE0
	private static readonly ulong s_dwlT15; // 0xE8
	private static readonly ulong s_dwlT16; // 0xF0
	private static readonly ulong s_dwlT17; // 0xF8
	private static readonly ulong s_dwlT18; // 0x100
	private static readonly ulong s_dwlT19; // 0x108
	public static readonly SqlDecimal Null; // 0x110
	public static readonly SqlDecimal MinValue; // 0x124
	public static readonly SqlDecimal MaxValue; // 0x138

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }
	public bool IsPositive { get; }
	public byte Scale { get; }
	public int[] Data { get; }

	// Methods

	// RVA: 0x1AD3BE0 Offset: 0x1ACFBE0 VA: 0x1AD3BE0
	private byte CalculatePrecision() { }

	// RVA: 0x1AD3E0C Offset: 0x1ACFE0C VA: 0x1AD3E0C
	private bool VerifyPrecision(byte precision) { }

	// RVA: 0x1AD4028 Offset: 0x1AD0028 VA: 0x1AD4028
	private void .ctor(bool fNull) { }

	// RVA: 0x1AD4090 Offset: 0x1AD0090 VA: 0x1AD4090
	public void .ctor(Decimal value) { }

	// RVA: 0x1AD41F4 Offset: 0x1AD01F4 VA: 0x1AD41F4
	public void .ctor(int value) { }

	// RVA: 0x1AD4430 Offset: 0x1AD0430 VA: 0x1AD4430
	public void .ctor(long value) { }

	// RVA: 0x1AD47A8 Offset: 0x1AD07A8 VA: 0x1AD47A8
	private void .ctor(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive) { }

	// RVA: 0x1AD4A68 Offset: 0x1AD0A68 VA: 0x1AD4A68 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1AD4AD8 Offset: 0x1AD0AD8 VA: 0x1AD4AD8
	public Decimal get_Value() { }

	// RVA: 0x1AD4C8C Offset: 0x1AD0C8C VA: 0x1AD4C8C
	public bool get_IsPositive() { }

	// RVA: 0x1AD4A00 Offset: 0x1AD0A00 VA: 0x1AD4A00
	private void SetPositive() { }

	// RVA: 0x1AD4D4C Offset: 0x1AD0D4C VA: 0x1AD4D4C
	private void SetSignBit(bool fPositive) { }

	// RVA: 0x1AD4DE0 Offset: 0x1AD0DE0 VA: 0x1AD4DE0
	public byte get_Scale() { }

	// RVA: 0x1AD4E74 Offset: 0x1AD0E74 VA: 0x1AD4E74
	public int[] get_Data() { }

	// RVA: 0x1AD4F70 Offset: 0x1AD0F70 VA: 0x1AD4F70 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AD5378 Offset: 0x1AD1378 VA: 0x1AD5378
	public static SqlDecimal Parse(string s) { }

	// RVA: 0x1AD5C48 Offset: 0x1AD1C48 VA: 0x1AD5C48
	public double ToDouble() { }

	// RVA: 0x1AD4B2C Offset: 0x1AD0B2C VA: 0x1AD4B2C
	private Decimal ToDecimal() { }

	// RVA: 0x1AD5D94 Offset: 0x1AD1D94 VA: 0x1AD5D94
	public static SqlDecimal op_Implicit(Decimal x) { }

	// RVA: 0x1AD5DAC Offset: 0x1AD1DAC VA: 0x1AD5DAC
	public static SqlDecimal op_Implicit(long x) { }

	// RVA: 0x1AD5E14 Offset: 0x1AD1E14 VA: 0x1AD5E14
	public static SqlDecimal op_UnaryNegation(SqlDecimal x) { }

	// RVA: 0x1AD5F40 Offset: 0x1AD1F40 VA: 0x1AD5F40
	public static SqlDecimal op_Addition(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1AD6A58 Offset: 0x1AD2A58 VA: 0x1AD6A58
	public static SqlDecimal op_Subtraction(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1AD6B0C Offset: 0x1AD2B0C VA: 0x1AD6B0C
	public static SqlDecimal op_Multiply(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1AD74C4 Offset: 0x1AD34C4 VA: 0x1AD74C4
	public static SqlDecimal op_Division(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1AD8190 Offset: 0x1AD4190 VA: 0x1AD8190
	public static SqlDecimal op_Implicit(SqlByte x) { }

	// RVA: 0x1AD826C Offset: 0x1AD426C VA: 0x1AD826C
	public static SqlDecimal op_Implicit(SqlInt16 x) { }

	// RVA: 0x1AD83A0 Offset: 0x1AD43A0 VA: 0x1AD83A0
	public static SqlDecimal op_Implicit(SqlInt32 x) { }

	// RVA: 0x1AD851C Offset: 0x1AD451C VA: 0x1AD851C
	public static SqlDecimal op_Implicit(SqlInt64 x) { }

	// RVA: 0x1AD8604 Offset: 0x1AD4604 VA: 0x1AD8604
	public static SqlDecimal op_Implicit(SqlMoney x) { }

	// RVA: 0x1AD8114 Offset: 0x1AD4114 VA: 0x1AD8114
	private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur) { }

	// RVA: 0x1AD49E0 Offset: 0x1AD09E0 VA: 0x1AD49E0
	private bool FZero() { }

	// RVA: 0x1AD69F0 Offset: 0x1AD29F0 VA: 0x1AD69F0
	private bool FGt10_38() { }

	// RVA: 0x1AD881C Offset: 0x1AD481C VA: 0x1AD881C
	private bool FGt10_38(uint[] rglData) { }

	// RVA: 0x1AD42C8 Offset: 0x1AD02C8 VA: 0x1AD42C8
	private static byte BGetPrecUI4(uint value) { }

	// RVA: 0x1AD44FC Offset: 0x1AD04FC VA: 0x1AD44FC
	private static byte BGetPrecUI8(ulong dwlVal) { }

	// RVA: 0x1AD5A98 Offset: 0x1AD1A98 VA: 0x1AD5A98
	private void AddULong(uint ulAdd) { }

	// RVA: 0x1AD5890 Offset: 0x1AD1890 VA: 0x1AD5890
	private void MultByULong(uint uiMultiplier) { }

	// RVA: 0x1AD88EC Offset: 0x1AD48EC VA: 0x1AD88EC
	private uint DivByULong(uint iDivisor) { }

	// RVA: 0x1AD6534 Offset: 0x1AD2534 VA: 0x1AD6534
	internal void AdjustScale(int digits, bool fRound) { }

	// RVA: 0x1AD6884 Offset: 0x1AD2884 VA: 0x1AD6884
	private int LAbsCmp(SqlDecimal snumOp) { }

	// RVA: 0x1AD8A94 Offset: 0x1AD4A94 VA: 0x1AD8A94
	private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD) { }

	// RVA: 0x1AD8AF8 Offset: 0x1AD4AF8 VA: 0x1AD8AF8
	private static void MpSet(uint[] rgulD, out int ciulD, uint iulN) { }

	// RVA: 0x1AD8B24 Offset: 0x1AD4B24 VA: 0x1AD8B24
	private static void MpNormalize(uint[] rgulU, ref int ciulU) { }

	// RVA: 0x1AD8B7C Offset: 0x1AD4B7C VA: 0x1AD8B7C
	private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX) { }

	// RVA: 0x1AD52A0 Offset: 0x1AD12A0 VA: 0x1AD52A0
	private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR) { }

	// RVA: 0x1AD8C88 Offset: 0x1AD4C88 VA: 0x1AD8C88
	internal static ulong DWL(uint lo, uint hi) { }

	// RVA: 0x1AD8C7C Offset: 0x1AD4C7C VA: 0x1AD8C7C
	private static uint HI(ulong x) { }

	// RVA: 0x1AD8C84 Offset: 0x1AD4C84 VA: 0x1AD8C84
	private static uint LO(ulong x) { }

	// RVA: 0x1AD78E0 Offset: 0x1AD38E0 VA: 0x1AD78E0
	private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR) { }

	// RVA: 0x1AD8C94 Offset: 0x1AD4C94 VA: 0x1AD8C94
	private EComparison CompareNm(SqlDecimal snumOp) { }

	// RVA: 0x1AD4908 Offset: 0x1AD0908 VA: 0x1AD4908
	private static void CheckValidPrecScale(byte bPrec, byte bScale) { }

	// RVA: 0x1AD8EF8 Offset: 0x1AD4EF8 VA: 0x1AD8EF8
	public static SqlBoolean op_Equality(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1AD8FF0 Offset: 0x1AD4FF0 VA: 0x1AD8FF0
	public static SqlBoolean op_LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1AD90E8 Offset: 0x1AD50E8 VA: 0x1AD90E8
	public static SqlBoolean op_GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1AD91E0 Offset: 0x1AD51E0 VA: 0x1AD91E0
	public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1AD9270 Offset: 0x1AD5270 VA: 0x1AD9270
	public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y) { }

	// RVA: 0x1AD9300 Offset: 0x1AD5300 VA: 0x1AD9300
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1AD9434 Offset: 0x1AD5434 VA: 0x1AD9434
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1AD9664 Offset: 0x1AD5664 VA: 0x1AD9664
	public SqlMoney ToSqlMoney() { }

	// RVA: 0x1AD5370 Offset: 0x1AD1370 VA: 0x1AD5370
	private static char ChFromDigit(uint uiDigit) { }

	// RVA: 0x1AD8894 Offset: 0x1AD4894 VA: 0x1AD8894
	private void StoreFromWorkingArray(uint[] rguiData) { }

	// RVA: 0x1AD5818 Offset: 0x1AD1818 VA: 0x1AD5818
	private void SetToZero() { }

	// RVA: 0x1AD97A8 Offset: 0x1AD57A8 VA: 0x1AD97A8 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1AD98C8 Offset: 0x1AD58C8 VA: 0x1AD98C8
	public int CompareTo(SqlDecimal value) { }

	// RVA: 0x1AD9A58 Offset: 0x1AD5A58 VA: 0x1AD9A58 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1AD9BD4 Offset: 0x1AD5BD4 VA: 0x1AD9BD4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AD9CE4 Offset: 0x1AD5CE4 VA: 0x1AD9CE4 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1AD9CEC Offset: 0x1AD5CEC VA: 0x1AD9CEC Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1AD9E50 Offset: 0x1AD5E50 VA: 0x1AD9E50 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1AD9F68 Offset: 0x1AD5F68 VA: 0x1AD9F68
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1AD9FF4 Offset: 0x1AD5FF4 VA: 0x1AD9FF4
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlDouble : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4582
{
	// Fields
	private bool m_fNotNull; // 0x0
	private double m_value; // 0x8
	public static readonly SqlDouble Null; // 0x0
	public static readonly SqlDouble Zero; // 0x10
	public static readonly SqlDouble MinValue; // 0x20
	public static readonly SqlDouble MaxValue; // 0x30

	// Properties
	public bool IsNull { get; }
	public double Value { get; }

	// Methods

	// RVA: 0x1ADA390 Offset: 0x1AD6390 VA: 0x1ADA390
	private void .ctor(bool fNull) { }

	// RVA: 0x1ADA39C Offset: 0x1AD639C VA: 0x1ADA39C
	public void .ctor(double value) { }

	// RVA: 0x1ADA404 Offset: 0x1AD6404 VA: 0x1ADA404 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1ADA414 Offset: 0x1AD6414 VA: 0x1ADA414
	public double get_Value() { }

	// RVA: 0x1ADA45C Offset: 0x1AD645C VA: 0x1ADA45C
	public static SqlDouble op_Implicit(double x) { }

	// RVA: 0x1ADA480 Offset: 0x1AD6480 VA: 0x1ADA480 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ADA51C Offset: 0x1AD651C VA: 0x1ADA51C
	public static SqlDouble op_UnaryNegation(SqlDouble x) { }

	// RVA: 0x1ADA5C4 Offset: 0x1AD65C4 VA: 0x1ADA5C4
	public static SqlDouble op_Addition(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1ADA6EC Offset: 0x1AD66EC VA: 0x1ADA6EC
	public static SqlDouble op_Subtraction(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1ADA814 Offset: 0x1AD6814 VA: 0x1ADA814
	public static SqlDouble op_Multiply(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1ADA93C Offset: 0x1AD693C VA: 0x1ADA93C
	public static SqlDouble op_Division(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1AD0680 Offset: 0x1ACC680 VA: 0x1AD0680
	public static SqlDouble op_Implicit(SqlByte x) { }

	// RVA: 0x1ADAA98 Offset: 0x1AD6A98 VA: 0x1ADAA98
	public static SqlDouble op_Implicit(SqlInt16 x) { }

	// RVA: 0x1ADAB64 Offset: 0x1AD6B64 VA: 0x1ADAB64
	public static SqlDouble op_Implicit(SqlInt32 x) { }

	// RVA: 0x1ADAC2C Offset: 0x1AD6C2C VA: 0x1ADAC2C
	public static SqlDouble op_Implicit(SqlInt64 x) { }

	// RVA: 0x1ADACF4 Offset: 0x1AD6CF4 VA: 0x1ADACF4
	public static SqlDouble op_Implicit(SqlSingle x) { }

	// RVA: 0x1ADADC4 Offset: 0x1AD6DC4 VA: 0x1ADADC4
	public static SqlDouble op_Implicit(SqlMoney x) { }

	// RVA: 0x1AD9370 Offset: 0x1AD5370 VA: 0x1AD9370
	public static SqlDouble op_Implicit(SqlDecimal x) { }

	// RVA: 0x1ADAF18 Offset: 0x1AD6F18 VA: 0x1ADAF18
	public static SqlBoolean op_Equality(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1ADAFEC Offset: 0x1AD6FEC VA: 0x1ADAFEC
	public static SqlBoolean op_LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1ADB0C0 Offset: 0x1AD70C0 VA: 0x1ADB0C0
	public static SqlBoolean op_GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1ADB194 Offset: 0x1AD7194 VA: 0x1ADB194
	public static SqlBoolean LessThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1ADB210 Offset: 0x1AD7210 VA: 0x1ADB210
	public static SqlBoolean GreaterThan(SqlDouble x, SqlDouble y) { }

	// RVA: 0x1ADB28C Offset: 0x1AD728C VA: 0x1ADB28C
	public SqlSingle ToSqlSingle() { }

	// RVA: 0x1ADB2EC Offset: 0x1AD72EC VA: 0x1ADB2EC Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1ADB3F8 Offset: 0x1AD73F8 VA: 0x1ADB3F8
	public int CompareTo(SqlDouble value) { }

	// RVA: 0x1ADB554 Offset: 0x1AD7554 VA: 0x1ADB554 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1ADB698 Offset: 0x1AD7698 VA: 0x1ADB698 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ADB72C Offset: 0x1AD772C VA: 0x1ADB72C Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1ADB734 Offset: 0x1AD7734 VA: 0x1ADB734 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1ADB854 Offset: 0x1AD7854 VA: 0x1ADB854 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1ADB990 Offset: 0x1AD7990 VA: 0x1ADB990
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1ADBA1C Offset: 0x1AD7A1C VA: 0x1ADBA1C
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlGuid : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4583
{
	// Fields
	private static readonly int s_sizeOfGuid; // 0x0
	private static readonly int[] s_rgiGuidOrder; // 0x8
	private byte[] m_value; // 0x0
	public static readonly SqlGuid Null; // 0x10

	// Properties
	public bool IsNull { get; }
	public Guid Value { get; }

	// Methods

	// RVA: 0x1ADBAAC Offset: 0x1AD7AAC VA: 0x1ADBAAC
	private void .ctor(bool fNull) { }

	// RVA: 0x1ADBAB8 Offset: 0x1AD7AB8 VA: 0x1ADBAB8
	public void .ctor(Guid g) { }

	// RVA: 0x1ADBAF0 Offset: 0x1AD7AF0 VA: 0x1ADBAF0 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1ADBB00 Offset: 0x1AD7B00 VA: 0x1ADBB00
	public Guid get_Value() { }

	// RVA: 0x1ADBBA8 Offset: 0x1AD7BA8 VA: 0x1ADBBA8
	public static SqlGuid op_Implicit(Guid x) { }

	// RVA: 0x1ADBBDC Offset: 0x1AD7BDC VA: 0x1ADBBDC Slot: 3
	public override string ToString() { }

	// RVA: 0x1ADBC88 Offset: 0x1AD7C88 VA: 0x1ADBC88
	private static EComparison Compare(SqlGuid x, SqlGuid y) { }

	// RVA: 0x1ADBD80 Offset: 0x1AD7D80 VA: 0x1ADBD80
	public static SqlBoolean op_Equality(SqlGuid x, SqlGuid y) { }

	// RVA: 0x1ADBE5C Offset: 0x1AD7E5C VA: 0x1ADBE5C
	public static SqlBoolean op_LessThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x1ADBF38 Offset: 0x1AD7F38 VA: 0x1ADBF38
	public static SqlBoolean op_GreaterThan(SqlGuid x, SqlGuid y) { }

	// RVA: 0x1ADC014 Offset: 0x1AD8014 VA: 0x1ADC014 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1ADC11C Offset: 0x1AD811C VA: 0x1ADC11C
	public int CompareTo(SqlGuid value) { }

	// RVA: 0x1ADC258 Offset: 0x1AD8258 VA: 0x1ADC258 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1ADC38C Offset: 0x1AD838C VA: 0x1ADC38C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ADC420 Offset: 0x1AD8420 VA: 0x1ADC420 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1ADC428 Offset: 0x1AD8428 VA: 0x1ADC428 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1ADC568 Offset: 0x1AD8568 VA: 0x1ADC568 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1ADC6B4 Offset: 0x1AD86B4 VA: 0x1ADC6B4
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1ADC740 Offset: 0x1AD8740 VA: 0x1ADC740
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlInt16 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4584
{
	// Fields
	private bool m_fNotNull; // 0x0
	private short m_value; // 0x2
	private static readonly int s_MASKI2; // 0x0
	public static readonly SqlInt16 Null; // 0x4
	public static readonly SqlInt16 Zero; // 0x8
	public static readonly SqlInt16 MinValue; // 0xC
	public static readonly SqlInt16 MaxValue; // 0x10

	// Properties
	public bool IsNull { get; }
	public short Value { get; }

	// Methods

	// RVA: 0x1ADC81C Offset: 0x1AD881C VA: 0x1ADC81C
	private void .ctor(bool fNull) { }

	// RVA: 0x1ADC828 Offset: 0x1AD8828 VA: 0x1ADC828
	public void .ctor(short value) { }

	// RVA: 0x1AD8348 Offset: 0x1AD4348 VA: 0x1AD8348 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1AD8358 Offset: 0x1AD4358 VA: 0x1AD8358
	public short get_Value() { }

	// RVA: 0x1ADC838 Offset: 0x1AD8838 VA: 0x1ADC838
	public static SqlInt16 op_Implicit(short x) { }

	// RVA: 0x1ADC844 Offset: 0x1AD8844 VA: 0x1ADC844 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ADC8E0 Offset: 0x1AD88E0 VA: 0x1ADC8E0
	public static SqlInt16 op_UnaryNegation(SqlInt16 x) { }

	// RVA: 0x1ADC980 Offset: 0x1AD8980 VA: 0x1ADC980
	public static SqlInt16 op_Addition(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1ADCA90 Offset: 0x1AD8A90 VA: 0x1ADCA90
	public static SqlInt16 op_Subtraction(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1ADCBA0 Offset: 0x1AD8BA0 VA: 0x1ADCBA0
	public static SqlInt16 op_Multiply(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1ADCCE8 Offset: 0x1AD8CE8 VA: 0x1ADCCE8
	public static SqlInt16 op_Division(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1ADCE44 Offset: 0x1AD8E44 VA: 0x1ADCE44
	public static SqlInt16 op_Implicit(SqlByte x) { }

	// RVA: 0x1ADCF14 Offset: 0x1AD8F14 VA: 0x1ADCF14
	public static SqlInt16 op_Explicit(SqlInt64 x) { }

	// RVA: 0x1ADD02C Offset: 0x1AD902C VA: 0x1ADD02C
	public static SqlBoolean op_Equality(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1ADD0EC Offset: 0x1AD90EC VA: 0x1ADD0EC
	public static SqlBoolean op_LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1ADD1AC Offset: 0x1AD91AC VA: 0x1ADD1AC
	public static SqlBoolean op_GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1ADD26C Offset: 0x1AD926C VA: 0x1ADD26C
	public static SqlBoolean LessThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1ADD2D0 Offset: 0x1AD92D0 VA: 0x1ADD2D0
	public static SqlBoolean GreaterThan(SqlInt16 x, SqlInt16 y) { }

	// RVA: 0x1ADD334 Offset: 0x1AD9334 VA: 0x1ADD334
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1ADD38C Offset: 0x1AD938C VA: 0x1ADD38C
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1ADD49C Offset: 0x1AD949C VA: 0x1ADD49C Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1ADD5A4 Offset: 0x1AD95A4 VA: 0x1ADD5A4
	public int CompareTo(SqlInt16 value) { }

	// RVA: 0x1ADD6E4 Offset: 0x1AD96E4 VA: 0x1ADD6E4 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1ADD818 Offset: 0x1AD9818 VA: 0x1ADD818 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ADD8AC Offset: 0x1AD98AC VA: 0x1ADD8AC Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1ADD8B4 Offset: 0x1AD98B4 VA: 0x1ADD8B4 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1ADD9D4 Offset: 0x1AD99D4 VA: 0x1ADD9D4 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1ADDB04 Offset: 0x1AD9B04 VA: 0x1ADDB04
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1ADDB90 Offset: 0x1AD9B90 VA: 0x1ADDB90
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlInt32 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4585
{
	// Fields
	private bool m_fNotNull; // 0x0
	private int m_value; // 0x4
	private static readonly long s_iIntMin; // 0x0
	private static readonly long s_lBitNotIntMax; // 0x8
	public static readonly SqlInt32 Null; // 0x10
	public static readonly SqlInt32 Zero; // 0x18
	public static readonly SqlInt32 MinValue; // 0x20
	public static readonly SqlInt32 MaxValue; // 0x28

	// Properties
	public bool IsNull { get; }
	public int Value { get; }

	// Methods

	// RVA: 0x1ADDC0C Offset: 0x1AD9C0C VA: 0x1ADDC0C
	private void .ctor(bool fNull) { }

	// RVA: 0x1ADDC18 Offset: 0x1AD9C18 VA: 0x1ADDC18
	public void .ctor(int value) { }

	// RVA: 0x1AD847C Offset: 0x1AD447C VA: 0x1AD847C Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1AD848C Offset: 0x1AD448C VA: 0x1AD848C
	public int get_Value() { }

	// RVA: 0x1ADDC28 Offset: 0x1AD9C28 VA: 0x1ADDC28
	public static SqlInt32 op_Implicit(int x) { }

	// RVA: 0x1ADDC34 Offset: 0x1AD9C34 VA: 0x1ADDC34 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ADDCD0 Offset: 0x1AD9CD0 VA: 0x1ADDCD0
	public static SqlInt32 op_UnaryNegation(SqlInt32 x) { }

	// RVA: 0x1ADDD6C Offset: 0x1AD9D6C VA: 0x1ADDD6C
	public static SqlInt32 op_Addition(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1ADDEA8 Offset: 0x1AD9EA8 VA: 0x1ADDEA8
	public static SqlInt32 op_Subtraction(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1ADDFD8 Offset: 0x1AD9FD8 VA: 0x1ADDFD8
	public static SqlInt32 op_Multiply(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1ADE120 Offset: 0x1ADA120 VA: 0x1ADE120
	public static SqlInt32 op_Division(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1ADE280 Offset: 0x1ADA280 VA: 0x1ADE280
	public static SqlInt32 op_Implicit(SqlByte x) { }

	// RVA: 0x1ADE350 Offset: 0x1ADA350 VA: 0x1ADE350
	public static SqlInt32 op_Implicit(SqlInt16 x) { }

	// RVA: 0x1ADE424 Offset: 0x1ADA424 VA: 0x1ADE424
	public static SqlInt32 op_Explicit(SqlInt64 x) { }

	// RVA: 0x1ADDE9C Offset: 0x1AD9E9C VA: 0x1ADDE9C
	private static bool SameSignInt(int x, int y) { }

	// RVA: 0x1ADE53C Offset: 0x1ADA53C VA: 0x1ADE53C
	public static SqlBoolean op_Equality(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1ADE600 Offset: 0x1ADA600 VA: 0x1ADE600
	public static SqlBoolean op_LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1ADE6C4 Offset: 0x1ADA6C4 VA: 0x1ADE6C4
	public static SqlBoolean op_GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1ADE788 Offset: 0x1ADA788 VA: 0x1ADE788
	public static SqlBoolean LessThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1ADE7EC Offset: 0x1ADA7EC VA: 0x1ADE7EC
	public static SqlBoolean GreaterThan(SqlInt32 x, SqlInt32 y) { }

	// RVA: 0x1ADE850 Offset: 0x1ADA850 VA: 0x1ADE850
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1ADE8A8 Offset: 0x1ADA8A8 VA: 0x1ADE8A8
	public SqlInt64 ToSqlInt64() { }

	// RVA: 0x1ADE9B8 Offset: 0x1ADA9B8 VA: 0x1ADE9B8 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1ADEAC0 Offset: 0x1ADAAC0 VA: 0x1ADEAC0
	public int CompareTo(SqlInt32 value) { }

	// RVA: 0x1ADEC00 Offset: 0x1ADAC00 VA: 0x1ADEC00 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1ADED34 Offset: 0x1ADAD34 VA: 0x1ADED34 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ADEDC8 Offset: 0x1ADADC8 VA: 0x1ADEDC8 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1ADEDD0 Offset: 0x1ADADD0 VA: 0x1ADEDD0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1ADEEF0 Offset: 0x1ADAEF0 VA: 0x1ADEEF0 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1ADF020 Offset: 0x1ADB020 VA: 0x1ADF020
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1ADF0AC Offset: 0x1ADB0AC VA: 0x1ADF0AC
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlInt64 : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4586
{
	// Fields
	private bool m_fNotNull; // 0x0
	private long m_value; // 0x8
	private static readonly long s_lLowIntMask; // 0x0
	private static readonly long s_lHighIntMask; // 0x8
	public static readonly SqlInt64 Null; // 0x10
	public static readonly SqlInt64 Zero; // 0x20
	public static readonly SqlInt64 MinValue; // 0x30
	public static readonly SqlInt64 MaxValue; // 0x40

	// Properties
	public bool IsNull { get; }
	public long Value { get; }

	// Methods

	// RVA: 0x1ADF128 Offset: 0x1ADB128 VA: 0x1ADF128
	private void .ctor(bool fNull) { }

	// RVA: 0x1ADF134 Offset: 0x1ADB134 VA: 0x1ADF134
	public void .ctor(long value) { }

	// RVA: 0x1AD02BC Offset: 0x1ACC2BC VA: 0x1AD02BC Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1AD02CC Offset: 0x1ACC2CC VA: 0x1AD02CC
	public long get_Value() { }

	// RVA: 0x1ADF144 Offset: 0x1ADB144 VA: 0x1ADF144
	public static SqlInt64 op_Implicit(long x) { }

	// RVA: 0x1ADF150 Offset: 0x1ADB150 VA: 0x1ADF150 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ADF1EC Offset: 0x1ADB1EC VA: 0x1ADF1EC
	public static SqlInt64 op_UnaryNegation(SqlInt64 x) { }

	// RVA: 0x1ADF278 Offset: 0x1ADB278 VA: 0x1ADF278
	public static SqlInt64 op_Addition(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1ADF3BC Offset: 0x1ADB3BC VA: 0x1ADF3BC
	public static SqlInt64 op_Subtraction(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1ADF4F0 Offset: 0x1ADB4F0 VA: 0x1ADF4F0
	public static SqlInt64 op_Multiply(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1ADF658 Offset: 0x1ADB658 VA: 0x1ADF658
	public static SqlInt64 op_Division(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1ADF790 Offset: 0x1ADB790 VA: 0x1ADF790
	public static SqlInt64 op_Modulus(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1AD07A4 Offset: 0x1ACC7A4 VA: 0x1AD07A4
	public static SqlInt64 op_Implicit(SqlByte x) { }

	// RVA: 0x1ADD3E4 Offset: 0x1AD93E4 VA: 0x1ADD3E4
	public static SqlInt64 op_Implicit(SqlInt16 x) { }

	// RVA: 0x1ADE900 Offset: 0x1ADA900 VA: 0x1ADE900
	public static SqlInt64 op_Implicit(SqlInt32 x) { }

	// RVA: 0x1AD94A4 Offset: 0x1AD54A4 VA: 0x1AD94A4
	public static SqlInt64 op_Explicit(SqlDecimal x) { }

	// RVA: 0x1ADF3AC Offset: 0x1ADB3AC VA: 0x1ADF3AC
	private static bool SameSignLong(long x, long y) { }

	// RVA: 0x1ADF8CC Offset: 0x1ADB8CC VA: 0x1ADF8CC
	public static SqlBoolean op_Equality(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1ADF998 Offset: 0x1ADB998 VA: 0x1ADF998
	public static SqlBoolean op_LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1ADFA64 Offset: 0x1ADBA64 VA: 0x1ADFA64
	public static SqlBoolean op_GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1ADFB30 Offset: 0x1ADBB30 VA: 0x1ADFB30
	public static SqlBoolean LessThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1ADFBAC Offset: 0x1ADBBAC VA: 0x1ADFBAC
	public static SqlBoolean GreaterThan(SqlInt64 x, SqlInt64 y) { }

	// RVA: 0x1ADFC28 Offset: 0x1ADBC28 VA: 0x1ADFC28
	public SqlByte ToSqlByte() { }

	// RVA: 0x1ADFC84 Offset: 0x1ADBC84 VA: 0x1ADFC84
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1ADFCE0 Offset: 0x1ADBCE0 VA: 0x1ADFCE0
	public SqlInt16 ToSqlInt16() { }

	// RVA: 0x1ADFD3C Offset: 0x1ADBD3C VA: 0x1ADFD3C
	public SqlInt32 ToSqlInt32() { }

	// RVA: 0x1ADFD98 Offset: 0x1ADBD98 VA: 0x1ADFD98
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x1ADFE20 Offset: 0x1ADBE20 VA: 0x1ADFE20 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1ADFF2C Offset: 0x1ADBF2C VA: 0x1ADFF2C
	public int CompareTo(SqlInt64 value) { }

	// RVA: 0x1AE0088 Offset: 0x1ADC088 VA: 0x1AE0088 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1AE01CC Offset: 0x1ADC1CC VA: 0x1AE01CC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AE0260 Offset: 0x1ADC260 VA: 0x1AE0260 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1AE0268 Offset: 0x1ADC268 VA: 0x1AE0268 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1AE0388 Offset: 0x1ADC388 VA: 0x1AE0388 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1AE04B8 Offset: 0x1ADC4B8 VA: 0x1AE04B8
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1AE0544 Offset: 0x1ADC544 VA: 0x1AE0544
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlMoney : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4587
{
	// Fields
	private bool _fNotNull; // 0x0
	private long _value; // 0x8
	internal static readonly int s_iMoneyScale; // 0x0
	private static readonly long s_lTickBase; // 0x8
	private static readonly double s_dTickBase; // 0x10
	private static readonly long s_minLong; // 0x18
	private static readonly long s_maxLong; // 0x20
	public static readonly SqlMoney Null; // 0x28
	public static readonly SqlMoney Zero; // 0x38
	public static readonly SqlMoney MinValue; // 0x48
	public static readonly SqlMoney MaxValue; // 0x58

	// Properties
	public bool IsNull { get; }
	public Decimal Value { get; }

	// Methods

	// RVA: 0x1AE05DC Offset: 0x1ADC5DC VA: 0x1AE05DC
	private void .ctor(bool fNull) { }

	// RVA: 0x1AE05E8 Offset: 0x1ADC5E8 VA: 0x1AE05E8
	internal void .ctor(long value, int ignored) { }

	// RVA: 0x1AE05F8 Offset: 0x1ADC5F8 VA: 0x1AE05F8
	public void .ctor(int value) { }

	// RVA: 0x1AE0674 Offset: 0x1ADC674 VA: 0x1AE0674
	public void .ctor(long value) { }

	// RVA: 0x1AE076C Offset: 0x1ADC76C VA: 0x1AE076C
	public void .ctor(Decimal value) { }

	// RVA: 0x1AD86F8 Offset: 0x1AD46F8 VA: 0x1AD86F8 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1AE08C8 Offset: 0x1ADC8C8 VA: 0x1AE08C8
	public Decimal get_Value() { }

	// RVA: 0x1AD8708 Offset: 0x1AD4708 VA: 0x1AD8708
	public Decimal ToDecimal() { }

	// RVA: 0x1ADAE88 Offset: 0x1AD6E88 VA: 0x1ADAE88
	public double ToDouble() { }

	// RVA: 0x1AE0958 Offset: 0x1ADC958 VA: 0x1AE0958
	public static SqlMoney op_Implicit(Decimal x) { }

	// RVA: 0x1AE0984 Offset: 0x1ADC984 VA: 0x1AE0984
	public static SqlMoney op_Implicit(long x) { }

	// RVA: 0x1AE09E0 Offset: 0x1ADC9E0 VA: 0x1AE09E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AE0B08 Offset: 0x1ADCB08 VA: 0x1AE0B08
	public static SqlMoney op_UnaryNegation(SqlMoney x) { }

	// RVA: 0x1AE0BF0 Offset: 0x1ADCBF0 VA: 0x1AE0BF0
	public static SqlMoney op_Addition(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1AE0D98 Offset: 0x1ADCD98 VA: 0x1AE0D98
	public static SqlMoney op_Subtraction(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1AE0F40 Offset: 0x1ADCF40 VA: 0x1AE0F40
	public static SqlMoney op_Multiply(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1AE1078 Offset: 0x1ADD078 VA: 0x1AE1078
	public static SqlMoney op_Division(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1AE11B0 Offset: 0x1ADD1B0 VA: 0x1AE11B0
	public static SqlMoney op_Implicit(SqlByte x) { }

	// RVA: 0x1AE127C Offset: 0x1ADD27C VA: 0x1AE127C
	public static SqlMoney op_Implicit(SqlInt16 x) { }

	// RVA: 0x1AE1344 Offset: 0x1ADD344 VA: 0x1AE1344
	public static SqlMoney op_Implicit(SqlInt32 x) { }

	// RVA: 0x1AE140C Offset: 0x1ADD40C VA: 0x1AE140C
	public static SqlMoney op_Implicit(SqlInt64 x) { }

	// RVA: 0x1AD96D4 Offset: 0x1AD56D4 VA: 0x1AD96D4
	public static SqlMoney op_Explicit(SqlDecimal x) { }

	// RVA: 0x1AE14D4 Offset: 0x1ADD4D4 VA: 0x1AE14D4
	public static SqlBoolean op_Equality(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1AE15A0 Offset: 0x1ADD5A0 VA: 0x1AE15A0
	public static SqlBoolean op_LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1AE166C Offset: 0x1ADD66C VA: 0x1AE166C
	public static SqlBoolean op_GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1AE1738 Offset: 0x1ADD738 VA: 0x1AE1738
	public static SqlBoolean LessThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1AE17B4 Offset: 0x1ADD7B4 VA: 0x1AE17B4
	public static SqlBoolean GreaterThan(SqlMoney x, SqlMoney y) { }

	// RVA: 0x1AE1830 Offset: 0x1ADD830 VA: 0x1AE1830
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1AE188C Offset: 0x1ADD88C VA: 0x1AE188C
	public SqlDecimal ToSqlDecimal() { }

	// RVA: 0x1AE1914 Offset: 0x1ADD914 VA: 0x1AE1914 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1AE1A20 Offset: 0x1ADDA20 VA: 0x1AE1A20
	public int CompareTo(SqlMoney value) { }

	// RVA: 0x1AE1B7C Offset: 0x1ADDB7C VA: 0x1AE1B7C Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1AE1CC0 Offset: 0x1ADDCC0 VA: 0x1AE1CC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AE1D30 Offset: 0x1ADDD30 VA: 0x1AE1D30 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1AE1D38 Offset: 0x1ADDD38 VA: 0x1AE1D38 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1AE1EA8 Offset: 0x1ADDEA8 VA: 0x1AE1EA8 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1AE1FF8 Offset: 0x1ADDFF8 VA: 0x1AE1FF8
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1AE2084 Offset: 0x1ADE084 VA: 0x1AE2084
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlSingle : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4588
{
	// Fields
	private bool _fNotNull; // 0x0
	private float _value; // 0x4
	public static readonly SqlSingle Null; // 0x0
	public static readonly SqlSingle Zero; // 0x8
	public static readonly SqlSingle MinValue; // 0x10
	public static readonly SqlSingle MaxValue; // 0x18

	// Properties
	public bool IsNull { get; }
	public float Value { get; }

	// Methods

	// RVA: 0x1AE214C Offset: 0x1ADE14C VA: 0x1AE214C
	private void .ctor(bool fNull) { }

	// RVA: 0x1AE2158 Offset: 0x1ADE158 VA: 0x1AE2158
	public void .ctor(float value) { }

	// RVA: 0x1AE21C4 Offset: 0x1ADE1C4 VA: 0x1AE21C4
	public void .ctor(double value) { }

	// RVA: 0x1AE2228 Offset: 0x1ADE228 VA: 0x1AE2228 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1AE2238 Offset: 0x1ADE238 VA: 0x1AE2238
	public float get_Value() { }

	// RVA: 0x1AE22B4 Offset: 0x1ADE2B4 VA: 0x1AE22B4
	public static SqlSingle op_Implicit(float x) { }

	// RVA: 0x1AE22CC Offset: 0x1ADE2CC VA: 0x1AE22CC Slot: 3
	public override string ToString() { }

	// RVA: 0x1AE2340 Offset: 0x1ADE340 VA: 0x1AE2340
	public static SqlSingle op_UnaryNegation(SqlSingle x) { }

	// RVA: 0x1AE23E0 Offset: 0x1ADE3E0 VA: 0x1AE23E0
	public static SqlSingle op_Addition(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1AE24FC Offset: 0x1ADE4FC VA: 0x1AE24FC
	public static SqlSingle op_Subtraction(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1AE2618 Offset: 0x1ADE618 VA: 0x1AE2618
	public static SqlSingle op_Multiply(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1AE2734 Offset: 0x1ADE734 VA: 0x1AE2734
	public static SqlSingle op_Division(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1AE2888 Offset: 0x1ADE888 VA: 0x1AE2888
	public static SqlSingle op_Implicit(SqlByte x) { }

	// RVA: 0x1AE295C Offset: 0x1ADE95C VA: 0x1AE295C
	public static SqlSingle op_Implicit(SqlInt16 x) { }

	// RVA: 0x1AE2A30 Offset: 0x1ADEA30 VA: 0x1AE2A30
	public static SqlSingle op_Implicit(SqlInt32 x) { }

	// RVA: 0x1AE2B00 Offset: 0x1ADEB00 VA: 0x1AE2B00
	public static SqlSingle op_Implicit(SqlInt64 x) { }

	// RVA: 0x1AE2BD0 Offset: 0x1ADEBD0 VA: 0x1AE2BD0
	public static SqlSingle op_Implicit(SqlMoney x) { }

	// RVA: 0x1AE2C9C Offset: 0x1ADEC9C VA: 0x1AE2C9C
	public static SqlSingle op_Implicit(SqlDecimal x) { }

	// RVA: 0x1AE2D68 Offset: 0x1ADED68 VA: 0x1AE2D68
	public static SqlSingle op_Explicit(SqlDouble x) { }

	// RVA: 0x1AE2E34 Offset: 0x1ADEE34 VA: 0x1AE2E34
	public static SqlBoolean op_Equality(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1AE2F14 Offset: 0x1ADEF14 VA: 0x1AE2F14
	public static SqlBoolean op_LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1AE2FF4 Offset: 0x1ADEFF4 VA: 0x1AE2FF4
	public static SqlBoolean op_GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1AE30D4 Offset: 0x1ADF0D4 VA: 0x1AE30D4
	public static SqlBoolean LessThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1AE3138 Offset: 0x1ADF138 VA: 0x1AE3138
	public static SqlBoolean GreaterThan(SqlSingle x, SqlSingle y) { }

	// RVA: 0x1AE319C Offset: 0x1ADF19C VA: 0x1AE319C
	public SqlDouble ToSqlDouble() { }

	// RVA: 0x1AE31F8 Offset: 0x1ADF1F8 VA: 0x1AE31F8 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1AE32FC Offset: 0x1ADF2FC VA: 0x1AE32FC
	public int CompareTo(SqlSingle value) { }

	// RVA: 0x1AE3508 Offset: 0x1ADF508 VA: 0x1AE3508 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1AE3640 Offset: 0x1ADF640 VA: 0x1AE3640 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AE36D4 Offset: 0x1ADF6D4 VA: 0x1AE36D4 Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1AE36DC Offset: 0x1ADF6DC VA: 0x1AE36DC Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1AE37FC Offset: 0x1ADF7FC VA: 0x1AE37FC Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1AE3938 Offset: 0x1ADF938 VA: 0x1AE3938
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1AE39C4 Offset: 0x1ADF9C4 VA: 0x1AE39C4
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
[Flags]
public enum SqlCompareOptions // TypeDefIndex: 4589
{
	// Fields
	public int value__; // 0x0
	public const SqlCompareOptions None = 0;
	public const SqlCompareOptions IgnoreCase = 1;
	public const SqlCompareOptions IgnoreNonSpace = 2;
	public const SqlCompareOptions IgnoreKanaType = 8;
	public const SqlCompareOptions IgnoreWidth = 16;
	public const SqlCompareOptions BinarySort = 32768;
	public const SqlCompareOptions BinarySort2 = 16384;
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public struct SqlString : INullable, IComparable, IXmlSerializable // TypeDefIndex: 4590
{
	// Fields
	private string m_value; // 0x0
	private CompareInfo m_cmpInfo; // 0x8
	private int m_lcid; // 0x10
	private SqlCompareOptions m_flag; // 0x14
	private bool m_fNotNull; // 0x18
	public static readonly SqlString Null; // 0x0
	internal static readonly UnicodeEncoding s_unicodeEncoding; // 0x20
	public static readonly int IgnoreCase; // 0x28
	public static readonly int IgnoreWidth; // 0x2C
	public static readonly int IgnoreNonSpace; // 0x30
	public static readonly int IgnoreKanaType; // 0x34
	public static readonly int BinarySort; // 0x38
	public static readonly int BinarySort2; // 0x3C
	private static readonly SqlCompareOptions s_iDefaultFlag; // 0x40
	private static readonly CompareOptions s_iValidCompareOptionMask; // 0x44
	internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask; // 0x48
	internal static readonly int s_lcidUSEnglish; // 0x4C
	private static readonly int s_lcidBinary; // 0x50

	// Properties
	public bool IsNull { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1AE3A54 Offset: 0x1ADFA54 VA: 0x1AE3A54
	private void .ctor(bool fNull) { }

	// RVA: 0x1AE3A88 Offset: 0x1ADFA88 VA: 0x1AE3A88
	public void .ctor(string data, int lcid, SqlCompareOptions compareOptions) { }

	// RVA: 0x1AE3BEC Offset: 0x1ADFBEC VA: 0x1AE3BEC
	public void .ctor(string data) { }

	// RVA: 0x1AE3CA8 Offset: 0x1ADFCA8 VA: 0x1AE3CA8
	private void .ctor(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo) { }

	// RVA: 0x1AE3D88 Offset: 0x1ADFD88 VA: 0x1AE3D88 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1AE3D98 Offset: 0x1ADFD98 VA: 0x1AE3D98
	public string get_Value() { }

	// RVA: 0x1AE3E24 Offset: 0x1ADFE24 VA: 0x1AE3E24
	private void SetCompareInfo() { }

	// RVA: 0x1AE3EBC Offset: 0x1ADFEBC VA: 0x1AE3EBC
	public static SqlString op_Implicit(string x) { }

	// RVA: 0x1AE3ED0 Offset: 0x1ADFED0 VA: 0x1AE3ED0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1AE3F3C Offset: 0x1ADFF3C VA: 0x1AE3F3C
	public static SqlString op_Addition(SqlString x, SqlString y) { }

	// RVA: 0x1AE40AC Offset: 0x1AE00AC VA: 0x1AE40AC
	private static int StringCompare(SqlString x, SqlString y) { }

	// RVA: 0x1AE46A4 Offset: 0x1AE06A4 VA: 0x1AE46A4
	private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult) { }

	// RVA: 0x1AE4814 Offset: 0x1AE0814 VA: 0x1AE4814
	public static SqlBoolean op_Equality(SqlString x, SqlString y) { }

	// RVA: 0x1AE3B40 Offset: 0x1ADFB40 VA: 0x1AE3B40
	private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x1AE4600 Offset: 0x1AE0600 VA: 0x1AE4600
	public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions) { }

	// RVA: 0x1AE4928 Offset: 0x1AE0928 VA: 0x1AE4928
	private bool FBinarySort() { }

	// RVA: 0x1AE42C0 Offset: 0x1AE02C0 VA: 0x1AE42C0
	private static int CompareBinary(SqlString x, SqlString y) { }

	// RVA: 0x1AE4488 Offset: 0x1AE0488 VA: 0x1AE4488
	private static int CompareBinary2(SqlString x, SqlString y) { }

	// RVA: 0x1AE4994 Offset: 0x1AE0994 VA: 0x1AE4994 Slot: 5
	public int CompareTo(object value) { }

	// RVA: 0x1AE4AA8 Offset: 0x1AE0AA8 VA: 0x1AE4AA8
	public int CompareTo(SqlString value) { }

	// RVA: 0x1AE4B98 Offset: 0x1AE0B98 VA: 0x1AE4B98 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1AE4D2C Offset: 0x1AE0D2C VA: 0x1AE4D2C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AE4F4C Offset: 0x1AE0F4C VA: 0x1AE4F4C Slot: 6
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1AE4F54 Offset: 0x1AE0F54 VA: 0x1AE4F54 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1AE5054 Offset: 0x1AE1054 VA: 0x1AE5054 Slot: 8
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1AE5150 Offset: 0x1AE1150 VA: 0x1AE5150
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1AE51DC Offset: 0x1AE11DC VA: 0x1AE51DC
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
internal enum EComparison // TypeDefIndex: 4591
{
	// Fields
	public int value__; // 0x0
	public const EComparison LT = 0;
	public const EComparison LE = 1;
	public const EComparison EQ = 2;
	public const EComparison GE = 3;
	public const EComparison GT = 4;
	public const EComparison NE = 5;
}

// Namespace: System.Data.SqlTypes
[Serializable]
public class SqlTypeException : SystemException // TypeDefIndex: 4592
{
	// Methods

	// RVA: 0x1AE52E0 Offset: 0x1AE12E0 VA: 0x1AE52E0
	public void .ctor() { }

	// RVA: 0x1AE4084 Offset: 0x1AE0084 VA: 0x1AE4084
	public void .ctor(string message) { }

	// RVA: 0x1AE5340 Offset: 0x1AE1340 VA: 0x1AE5340
	public void .ctor(string message, Exception e) { }

	// RVA: 0x1AE5364 Offset: 0x1AE1364 VA: 0x1AE5364
	protected void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x1AE53B4 Offset: 0x1AE13B4 VA: 0x1AE53B4
	private static SerializationInfo SqlTypeExceptionSerialization(SerializationInfo si, StreamingContext sc) { }
}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlNullValueException : SqlTypeException // TypeDefIndex: 4593
{
	// Methods

	// RVA: 0x1AE227C Offset: 0x1ADE27C VA: 0x1AE227C
	public void .ctor() { }

	// RVA: 0x1AE54AC Offset: 0x1AE14AC VA: 0x1AE54AC
	public void .ctor(string message) { }

	// RVA: 0x1AE5488 Offset: 0x1AE1488 VA: 0x1AE5488
	public void .ctor(string message, Exception e) { }

	// RVA: 0x1AE54D4 Offset: 0x1AE14D4 VA: 0x1AE54D4
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x1AE5534 Offset: 0x1AE1534 VA: 0x1AE5534
	private static SerializationInfo SqlNullValueExceptionSerialization(SerializationInfo si, StreamingContext sc) { }
}

// Namespace: System.Data.SqlTypes
[Serializable]
public sealed class SqlTruncateException : SqlTypeException // TypeDefIndex: 4594
{
	// Methods

	// RVA: 0x1AE5608 Offset: 0x1AE1608 VA: 0x1AE5608
	public void .ctor() { }

	// RVA: 0x1AE5664 Offset: 0x1AE1664 VA: 0x1AE5664
	public void .ctor(string message) { }

	// RVA: 0x1AE5640 Offset: 0x1AE1640 VA: 0x1AE5640
	public void .ctor(string message, Exception e) { }

	// RVA: 0x1AE568C Offset: 0x1AE168C VA: 0x1AE568C
	private void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x1AE56EC Offset: 0x1AE16EC VA: 0x1AE56EC
	private static SerializationInfo SqlTruncateExceptionSerialization(SerializationInfo si, StreamingContext sc) { }
}

// Namespace: System.Data.SqlTypes
internal abstract class SqlStreamChars // TypeDefIndex: 4595
{
	// Properties
	public abstract long Length { get; }
	public abstract long Position { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract long get_Position();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int Read(char[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract long Seek(long offset, SeekOrigin origin);
}

// Namespace: System.Data.SqlTypes
[XmlSchemaProvider("GetXsdType")]
[Serializable]
public sealed class SqlXml : INullable, IXmlSerializable // TypeDefIndex: 4596
{
	// Fields
	private static readonly Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> s_sqlReaderDelegate; // 0x0
	private static readonly XmlReaderSettings s_defaultXmlReaderSettings; // 0x8
	private static readonly XmlReaderSettings s_defaultXmlReaderSettingsCloseInput; // 0x10
	private static MethodInfo s_createSqlReaderMethodInfo; // 0x18
	private MethodInfo _createSqlReaderMethodInfo; // 0x10
	private bool _fNotNull; // 0x18
	private Stream _stream; // 0x20
	private bool _firstCreateReader; // 0x28

	// Properties
	private static MethodInfo CreateSqlReaderMethodInfo { get; }
	public bool IsNull { get; }

	// Methods

	// RVA: 0x1AE57C0 Offset: 0x1AE17C0 VA: 0x1AE57C0
	public void .ctor() { }

	// RVA: 0x1AE5820 Offset: 0x1AE1820 VA: 0x1AE5820
	public XmlReader CreateReader() { }

	// RVA: 0x1AE5B30 Offset: 0x1AE1B30 VA: 0x1AE5B30
	internal static XmlReader CreateSqlXmlReader(Stream stream, bool closeInput = False, bool throwTargetInvocationExceptions = False) { }

	// RVA: 0x1AE5F00 Offset: 0x1AE1F00 VA: 0x1AE5F00
	private static Func<Stream, XmlReaderSettings, XmlParserContext, XmlReader> CreateSqlReaderDelegate() { }

	// RVA: 0x1AE5A18 Offset: 0x1AE1A18 VA: 0x1AE5A18
	private static MethodInfo get_CreateSqlReaderMethodInfo() { }

	// RVA: 0x1AE5988 Offset: 0x1AE1988 VA: 0x1AE5988 Slot: 4
	public bool get_IsNull() { }

	// RVA: 0x1AE57F4 Offset: 0x1AE17F4 VA: 0x1AE57F4
	private void SetNull() { }

	// RVA: 0x1AE5FEC Offset: 0x1AE1FEC VA: 0x1AE5FEC Slot: 5
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1AE5FF4 Offset: 0x1AE1FF4 VA: 0x1AE5FF4 Slot: 6
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader r) { }

	// RVA: 0x1AE61E0 Offset: 0x1AE21E0 VA: 0x1AE61E0 Slot: 7
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1AE6330 Offset: 0x1AE2330 VA: 0x1AE6330
	public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet) { }

	// RVA: 0x1AE63BC Offset: 0x1AE23BC VA: 0x1AE63BC
	private static void .cctor() { }
}

// Namespace: System.Data.SqlTypes
internal sealed class SqlXmlStreamWrapper : Stream // TypeDefIndex: 4597
{
	// Fields
	private Stream _stream; // 0x28
	private long _lPosition; // 0x30
	private bool _isClosed; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1AE5998 Offset: 0x1AE1998 VA: 0x1AE5998
	internal void .ctor(Stream stream) { }

	// RVA: 0x1AE64B4 Offset: 0x1AE24B4 VA: 0x1AE64B4 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1AE655C Offset: 0x1AE255C VA: 0x1AE655C Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1AE6594 Offset: 0x1AE2594 VA: 0x1AE6594 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1AE65CC Offset: 0x1AE25CC VA: 0x1AE65CC Slot: 11
	public override long get_Length() { }

	// RVA: 0x1AE671C Offset: 0x1AE271C VA: 0x1AE671C Slot: 12
	public override long get_Position() { }

	// RVA: 0x1AE6778 Offset: 0x1AE2778 VA: 0x1AE6778 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1AE684C Offset: 0x1AE284C VA: 0x1AE684C Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1AE6A1C Offset: 0x1AE2A1C VA: 0x1AE6A1C Slot: 32
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1AE6C50 Offset: 0x1AE2C50 VA: 0x1AE6C50 Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1AE6E84 Offset: 0x1AE2E84 VA: 0x1AE6E84 Slot: 34
	public override int ReadByte() { }

	// RVA: 0x1AE6F98 Offset: 0x1AE2F98 VA: 0x1AE6F98 Slot: 37
	public override void WriteByte(byte value) { }

	// RVA: 0x1AE707C Offset: 0x1AE307C VA: 0x1AE707C Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1AE7110 Offset: 0x1AE3110 VA: 0x1AE7110 Slot: 21
	public override void Flush() { }

	// RVA: 0x1AE712C Offset: 0x1AE312C VA: 0x1AE712C Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1AE66A0 Offset: 0x1AE26A0 VA: 0x1AE66A0
	private void ThrowIfStreamCannotSeek(string method) { }

	// RVA: 0x1AE6BD4 Offset: 0x1AE2BD4 VA: 0x1AE6BD4
	private void ThrowIfStreamCannotRead(string method) { }

	// RVA: 0x1AE6E08 Offset: 0x1AE2E08 VA: 0x1AE6E08
	private void ThrowIfStreamCannotWrite(string method) { }

	// RVA: 0x1AE6638 Offset: 0x1AE2638 VA: 0x1AE6638
	private void ThrowIfStreamClosed(string method) { }

	// RVA: 0x1AE64EC Offset: 0x1AE24EC VA: 0x1AE64EC
	private bool IsStreamClosed() { }
}

// Namespace: 
private enum ObjectStorage.Families // TypeDefIndex: 4598
{
	// Fields
	public int value__; // 0x0
	public const ObjectStorage.Families DATETIME = 0;
	public const ObjectStorage.Families NUMBER = 1;
	public const ObjectStorage.Families STRING = 2;
	public const ObjectStorage.Families BOOLEAN = 3;
	public const ObjectStorage.Families ARRAY = 4;
}

// Namespace: 
private class ObjectStorage.TempAssemblyComparer : IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> // TypeDefIndex: 4599
{
	// Fields
	internal static readonly IEqualityComparer<KeyValuePair<Type, XmlRootAttribute>> s_default; // 0x0

	// Methods

	// RVA: 0x1AEC560 Offset: 0x1AE8560 VA: 0x1AEC560
	private void .ctor() { }

	// RVA: 0x1AEC568 Offset: 0x1AE8568 VA: 0x1AEC568 Slot: 4
	public bool Equals(KeyValuePair<Type, XmlRootAttribute> x, KeyValuePair<Type, XmlRootAttribute> y) { }

	// RVA: 0x1AEC698 Offset: 0x1AE8698 VA: 0x1AEC698 Slot: 5
	public int GetHashCode(KeyValuePair<Type, XmlRootAttribute> obj) { }

	// RVA: 0x1AEC720 Offset: 0x1AE8720 VA: 0x1AEC720
	private static void .cctor() { }
}
