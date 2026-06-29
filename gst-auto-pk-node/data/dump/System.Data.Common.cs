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

// Namespace: System.Data.Common
internal sealed class ObjectStorage : DataStorage // TypeDefIndex: 4600
{
	// Fields
	private static readonly object s_defaultValue; // 0x0
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private static readonly object s_tempAssemblyCacheLock; // 0x8
	private static Dictionary<KeyValuePair<Type, XmlRootAttribute>, XmlSerializer> s_tempAssemblyCache; // 0x10
	private static readonly XmlSerializerFactory s_serializerFactory; // 0x18

	// Methods

	// RVA: 0x1AE713C Offset: 0x1AE313C VA: 0x1AE713C
	internal void .ctor(DataColumn column, Type type) { }

	// RVA: 0x1AE7530 Offset: 0x1AE3530 VA: 0x1AE7530 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1AE7560 Offset: 0x1AE3560 VA: 0x1AE7560 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1AE7BB0 Offset: 0x1AE3BB0 VA: 0x1AE7BB0 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x1AE7D88 Offset: 0x1AE3D88 VA: 0x1AE7D88
	private int CompareTo(object valueNo1, object valueNo2) { }

	// RVA: 0x1AE7714 Offset: 0x1AE3714 VA: 0x1AE7714
	private int CompareWithFamilies(object valueNo1, object valueNo2) { }

	// RVA: 0x1AE7FF8 Offset: 0x1AE3FF8 VA: 0x1AE7FF8 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1AE8070 Offset: 0x1AE4070 VA: 0x1AE8070 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x1AE7EF8 Offset: 0x1AE3EF8 VA: 0x1AE7EF8
	private ObjectStorage.Families GetFamily(Type dataType) { }

	// RVA: 0x1AE80AC Offset: 0x1AE40AC VA: 0x1AE80AC Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1AE80E4 Offset: 0x1AE40E4 VA: 0x1AE80E4 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x1AE879C Offset: 0x1AE479C VA: 0x1AE879C Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1AE885C Offset: 0x1AE485C VA: 0x1AE885C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1AE8DAC Offset: 0x1AE4DAC VA: 0x1AE8DAC Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1AEB80C Offset: 0x1AE780C VA: 0x1AEB80C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1AEBD3C Offset: 0x1AE7D3C VA: 0x1AEBD3C Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1AEBEA0 Offset: 0x1AE7EA0 VA: 0x1AEBEA0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1AEBEE8 Offset: 0x1AE7EE8 VA: 0x1AEBEE8 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1AEC100 Offset: 0x1AE8100 VA: 0x1AEC100 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1AEC2E8 Offset: 0x1AE82E8 VA: 0x1AEC2E8
	internal static void VerifyIDynamicMetaObjectProvider(Type type) { }

	// RVA: 0x1AE8D38 Offset: 0x1AE4D38 VA: 0x1AE8D38
	internal static XmlSerializer GetXmlSerializer(Type type) { }

	// RVA: 0x1AEB234 Offset: 0x1AE7234 VA: 0x1AEB234
	internal static XmlSerializer GetXmlSerializer(Type type, XmlRootAttribute attribute) { }

	// RVA: 0x1AEC48C Offset: 0x1AE848C VA: 0x1AEC48C
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal static class ADP // TypeDefIndex: 4601
{
	// Fields
	private static readonly Type s_stackOverflowType; // 0x0
	private static readonly Type s_outOfMemoryType; // 0x8
	private static readonly Type s_threadAbortType; // 0x10
	private static readonly Type s_nullReferenceType; // 0x18
	private static readonly Type s_accessViolationType; // 0x20
	private static readonly Type s_securityType; // 0x28
	internal static readonly string StrEmpty; // 0x30
	internal static readonly string[] AzureSqlServerEndpoints; // 0x38
	internal static readonly IntPtr PtrZero; // 0x40
	internal static readonly int PtrSize; // 0x48

	// Methods

	// RVA: 0x1AEC788 Offset: 0x1AE8788 VA: 0x1AEC788
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x1AEC820 Offset: 0x1AE8820 VA: 0x1AEC820
	internal static void TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x1AEC88C Offset: 0x1AE888C VA: 0x1AEC88C
	internal static void TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x1AEC8F8 Offset: 0x1AE88F8 VA: 0x1AEC8F8
	internal static ArgumentException Argument(string error) { }

	// RVA: 0x1AE4898 Offset: 0x1AE0898 VA: 0x1AE4898
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string parameterName) { }

	// RVA: 0x1AEC988 Offset: 0x1AE8988 VA: 0x1AEC988
	internal static ArgumentOutOfRangeException ArgumentOutOfRange(string message, string parameterName) { }

	// RVA: 0x1AEC3FC Offset: 0x1AE83FC VA: 0x1AEC3FC
	internal static InvalidOperationException InvalidOperation(string error) { }

	// RVA: 0x1AECA20 Offset: 0x1AE8A20 VA: 0x1AECA20
	internal static NotSupportedException NotSupported(string error) { }

	// RVA: 0x1AE5D00 Offset: 0x1AE1D00 VA: 0x1AE5D00
	internal static bool IsCatchableExceptionType(Exception e) { }

	// RVA: 0x1AECAB0 Offset: 0x1AE8AB0 VA: 0x1AECAB0
	internal static bool IsCatchableOrSecurityExceptionType(Exception e) { }

	// RVA: 0x1AECC78 Offset: 0x1AE8C78 VA: 0x1AECC78
	internal static ArgumentOutOfRangeException InvalidEnumerationValue(Type type, int value) { }

	// RVA: 0x1AE69B0 Offset: 0x1AE29B0 VA: 0x1AE69B0
	internal static Exception InvalidSeekOrigin(string parameterName) { }

	// RVA: 0x1AECD84 Offset: 0x1AE8D84 VA: 0x1AECD84
	internal static ArgumentOutOfRangeException InvalidAcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x1AECE20 Offset: 0x1AE8E20 VA: 0x1AECE20
	internal static ArgumentOutOfRangeException InvalidMissingSchemaAction(MissingSchemaAction value) { }

	// RVA: 0x1AECEBC Offset: 0x1AE8EBC VA: 0x1AECEBC
	internal static ArgumentOutOfRangeException InvalidRule(Rule value) { }

	// RVA: 0x1AE3444 Offset: 0x1ADF444 VA: 0x1AE3444
	internal static Exception WrongType(Type got, Type expected) { }

	// RVA: 0x1AECF58 Offset: 0x1AE8F58 VA: 0x1AECF58
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class BigIntegerStorage : DataStorage // TypeDefIndex: 4602
{
	// Fields
	private BigInteger[] _values; // 0x50

	// Methods

	// RVA: 0x1AED2C4 Offset: 0x1AE92C4 VA: 0x1AED2C4
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1AED48C Offset: 0x1AE948C VA: 0x1AED48C Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1AED4BC Offset: 0x1AE94BC VA: 0x1AED4BC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1AED638 Offset: 0x1AE9638 VA: 0x1AED638 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1AED788 Offset: 0x1AE9788 VA: 0x1AED788
	internal static BigInteger ConvertToBigInteger(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1AEDD80 Offset: 0x1AE9D80 VA: 0x1AEDD80
	internal static object ConvertFromBigInteger(BigInteger value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x1AEE384 Offset: 0x1AEA384 VA: 0x1AEE384 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1AEE424 Offset: 0x1AEA424 VA: 0x1AEE424 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1AEE4C4 Offset: 0x1AEA4C4 VA: 0x1AEE4C4 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1AEE5B8 Offset: 0x1AEA5B8 VA: 0x1AEE5B8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1AEE718 Offset: 0x1AEA718 VA: 0x1AEE718 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1AEE86C Offset: 0x1AEA86C VA: 0x1AEE86C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1AEE91C Offset: 0x1AEA91C VA: 0x1AEE91C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1AEEA10 Offset: 0x1AEAA10 VA: 0x1AEEA10 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1AEEA58 Offset: 0x1AEAA58 VA: 0x1AEEA58 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1AEEB68 Offset: 0x1AEAB68 VA: 0x1AEEB68 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class BooleanStorage : DataStorage // TypeDefIndex: 4603
{
	// Fields
	private bool[] _values; // 0x50

	// Methods

	// RVA: 0x1AEEC2C Offset: 0x1AEAC2C VA: 0x1AEEC2C
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1AEECEC Offset: 0x1AEACEC VA: 0x1AEECEC Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1AEF094 Offset: 0x1AEB094 VA: 0x1AEF094 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1AEF120 Offset: 0x1AEB120 VA: 0x1AEF120 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1AEF1F8 Offset: 0x1AEB1F8 VA: 0x1AEF1F8 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1AEF33C Offset: 0x1AEB33C VA: 0x1AEF33C Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1AEF390 Offset: 0x1AEB390 VA: 0x1AEF390 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1AEF3E4 Offset: 0x1AEB3E4 VA: 0x1AEF3E4 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1AEF570 Offset: 0x1AEB570 VA: 0x1AEF570 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1AEF640 Offset: 0x1AEB640 VA: 0x1AEF640 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1AEF6C0 Offset: 0x1AEB6C0 VA: 0x1AEF6C0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1AEF74C Offset: 0x1AEB74C VA: 0x1AEF74C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1AEF794 Offset: 0x1AEB794 VA: 0x1AEF794 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1AEF894 Offset: 0x1AEB894 VA: 0x1AEF894 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class ByteStorage : DataStorage // TypeDefIndex: 4604
{
	// Fields
	private byte[] _values; // 0x50

	// Methods

	// RVA: 0x1AEF958 Offset: 0x1AEB958 VA: 0x1AEF958
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1AEFA18 Offset: 0x1AEBA18 VA: 0x1AEFA18 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1AF01FC Offset: 0x1AEC1FC VA: 0x1AF01FC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1AF026C Offset: 0x1AEC26C VA: 0x1AF026C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1AF0330 Offset: 0x1AEC330 VA: 0x1AF0330 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1AF0474 Offset: 0x1AEC474 VA: 0x1AF0474 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1AF04C8 Offset: 0x1AEC4C8 VA: 0x1AF04C8 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1AF051C Offset: 0x1AEC51C VA: 0x1AF051C Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1AF06A0 Offset: 0x1AEC6A0 VA: 0x1AF06A0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1AF0770 Offset: 0x1AEC770 VA: 0x1AF0770 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1AF07F0 Offset: 0x1AEC7F0 VA: 0x1AF07F0 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1AF087C Offset: 0x1AEC87C VA: 0x1AF087C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1AF08C4 Offset: 0x1AEC8C4 VA: 0x1AF08C4 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1AF09C4 Offset: 0x1AEC9C4 VA: 0x1AF09C4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class CharStorage : DataStorage // TypeDefIndex: 4605
{
	// Fields
	private char[] _values; // 0x50

	// Methods

	// RVA: 0x1AF0A88 Offset: 0x1AECA88 VA: 0x1AF0A88
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1AF0B48 Offset: 0x1AECB48 VA: 0x1AF0B48 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1AF0ED4 Offset: 0x1AECED4 VA: 0x1AF0ED4 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1AF0F5C Offset: 0x1AECF5C VA: 0x1AF0F5C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1AF1034 Offset: 0x1AED034 VA: 0x1AF1034 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1AF1178 Offset: 0x1AED178 VA: 0x1AF1178 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1AF11CC Offset: 0x1AED1CC VA: 0x1AF11CC Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1AF1220 Offset: 0x1AED220 VA: 0x1AF1220 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1AF1400 Offset: 0x1AED400 VA: 0x1AF1400 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1AF14D0 Offset: 0x1AED4D0 VA: 0x1AF14D0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1AF1550 Offset: 0x1AED550 VA: 0x1AF1550 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1AF15DC Offset: 0x1AED5DC VA: 0x1AF15DC Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1AF1624 Offset: 0x1AED624 VA: 0x1AF1624 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1AF1724 Offset: 0x1AED724 VA: 0x1AF1724 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal enum StorageType // TypeDefIndex: 4606
{
	// Fields
	public int value__; // 0x0
	public const StorageType Empty = 0;
	public const StorageType Object = 1;
	public const StorageType DBNull = 2;
	public const StorageType Boolean = 3;
	public const StorageType Char = 4;
	public const StorageType SByte = 5;
	public const StorageType Byte = 6;
	public const StorageType Int16 = 7;
	public const StorageType UInt16 = 8;
	public const StorageType Int32 = 9;
	public const StorageType UInt32 = 10;
	public const StorageType Int64 = 11;
	public const StorageType UInt64 = 12;
	public const StorageType Single = 13;
	public const StorageType Double = 14;
	public const StorageType Decimal = 15;
	public const StorageType DateTime = 16;
	public const StorageType TimeSpan = 17;
	public const StorageType String = 18;
	public const StorageType Guid = 19;
	public const StorageType ByteArray = 20;
	public const StorageType CharArray = 21;
	public const StorageType Type = 22;
	public const StorageType DateTimeOffset = 23;
	public const StorageType BigInteger = 24;
	public const StorageType Uri = 25;
	public const StorageType SqlBinary = 26;
	public const StorageType SqlBoolean = 27;
	public const StorageType SqlByte = 28;
	public const StorageType SqlBytes = 29;
	public const StorageType SqlChars = 30;
	public const StorageType SqlDateTime = 31;
	public const StorageType SqlDecimal = 32;
	public const StorageType SqlDouble = 33;
	public const StorageType SqlGuid = 34;
	public const StorageType SqlInt16 = 35;
	public const StorageType SqlInt32 = 36;
	public const StorageType SqlInt64 = 37;
	public const StorageType SqlMoney = 38;
	public const StorageType SqlSingle = 39;
	public const StorageType SqlString = 40;
}

// Namespace: System.Data.Common
internal abstract class DataStorage // TypeDefIndex: 4607
{
	// Fields
	private static readonly Type[] s_storageClassType; // 0x0
	internal readonly DataColumn _column; // 0x10
	internal readonly DataTable _table; // 0x18
	internal readonly Type _dataType; // 0x20
	internal readonly StorageType _storageTypeCode; // 0x28
	private BitArray _dbNullBits; // 0x30
	private readonly object _defaultValue; // 0x38
	internal readonly object _nullValue; // 0x40
	internal readonly bool _isCloneable; // 0x48
	internal readonly bool _isCustomDefinedType; // 0x49
	internal readonly bool _isStringType; // 0x4A
	internal readonly bool _isValueType; // 0x4B
	private static readonly Func<Type, Tuple<bool, bool, bool, bool>> s_inspectTypeForInterfaces; // 0x8
	private static readonly ConcurrentDictionary<Type, Tuple<bool, bool, bool, bool>> s_typeImplementsInterface; // 0x10

	// Properties
	internal DataSetDateTime DateTimeMode { get; }
	internal IFormatProvider FormatProvider { get; }

	// Methods

	// RVA: 0x1AED3F8 Offset: 0x1AE93F8 VA: 0x1AED3F8
	protected void .ctor(DataColumn column, Type type, object defaultValue, StorageType storageType) { }

	// RVA: 0x1AF17E8 Offset: 0x1AED7E8 VA: 0x1AF17E8
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, StorageType storageType) { }

	// RVA: 0x1AE73E0 Offset: 0x1AE33E0 VA: 0x1AE73E0
	protected void .ctor(DataColumn column, Type type, object defaultValue, object nullValue, bool isICloneable, StorageType storageType) { }

	// RVA: 0x1AF184C Offset: 0x1AED84C VA: 0x1AF184C
	internal DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x1AE7FE0 Offset: 0x1AE3FE0 VA: 0x1AE7FE0
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x1AEF080 Offset: 0x1AEB080 VA: 0x1AEF080 Slot: 4
	public virtual object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x1AF1864 Offset: 0x1AED864 VA: 0x1AF1864
	public object AggregateCount(int[] recordNos) { }

	// RVA: 0x1AED5D4 Offset: 0x1AE95D4 VA: 0x1AED5D4
	protected int CompareBits(int recordNo1, int recordNo2) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int Compare(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int CompareValueTo(int recordNo1, object value);

	// RVA: 0x1AF1910 Offset: 0x1AED910 VA: 0x1AF1910 Slot: 7
	public virtual object ConvertValue(object value) { }

	// RVA: 0x1AEE480 Offset: 0x1AEA480 VA: 0x1AEE480
	protected void CopyBits(int srcRecordNo, int dstRecordNo) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Copy(int recordNo1, int recordNo2);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract object Get(int recordNo);

	// RVA: 0x1AEE580 Offset: 0x1AEA580 VA: 0x1AEE580
	protected object GetBits(int recordNo) { }

	// RVA: 0x1AF1918 Offset: 0x1AED918 VA: 0x1AF1918 Slot: 10
	public virtual int GetStringLength(int record) { }

	// RVA: 0x1AED760 Offset: 0x1AE9760 VA: 0x1AED760
	protected bool HasValue(int recordNo) { }

	// RVA: 0x1AF1920 Offset: 0x1AED920 VA: 0x1AF1920 Slot: 11
	public virtual bool IsNull(int recordNo) { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void Set(int recordNo, object value);

	// RVA: 0x1AEE6FC Offset: 0x1AEA6FC VA: 0x1AEE6FC
	protected void SetNullBit(int recordNo, bool flag) { }

	// RVA: 0x1AEE7E8 Offset: 0x1AEA7E8 VA: 0x1AEE7E8 Slot: 13
	public virtual void SetCapacity(int capacity) { }

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object ConvertXmlToObject(string s);

	// RVA: 0x1AF1938 Offset: 0x1AED938 VA: 0x1AF1938 Slot: 15
	public virtual object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract string ConvertObjectToXml(object value);

	// RVA: 0x1AF1978 Offset: 0x1AED978 VA: 0x1AF1978 Slot: 17
	public virtual void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1AF19B4 Offset: 0x1AED9B4 VA: 0x1AF19B4
	public static DataStorage CreateStorage(DataColumn column, Type dataType, StorageType typeCode) { }

	// RVA: 0x1AE72D4 Offset: 0x1AE32D4 VA: 0x1AE72D4
	internal static StorageType GetStorageType(Type dataType) { }

	// RVA: 0x1AF2858 Offset: 0x1AEE858 VA: 0x1AF2858
	internal static Type GetTypeStorage(StorageType storageType) { }

	// RVA: 0x1AEBCCC Offset: 0x1AE7CCC VA: 0x1AEBCCC
	internal static bool IsTypeCustomType(Type type) { }

	// RVA: 0x1AF17F4 Offset: 0x1AED7F4 VA: 0x1AF17F4
	internal static bool IsTypeCustomType(StorageType typeCode) { }

	// RVA: 0x1AF28D4 Offset: 0x1AEE8D4 VA: 0x1AF28D4
	internal static bool IsSqlType(StorageType storageType) { }

	// RVA: 0x1AF28E0 Offset: 0x1AEE8E0 VA: 0x1AF28E0
	public static bool IsSqlType(Type dataType) { }

	// RVA: 0x1AF1810 Offset: 0x1AED810 VA: 0x1AF1810
	private static bool DetermineIfValueType(StorageType typeCode, Type dataType) { }

	// RVA: 0x1AF29D0 Offset: 0x1AEE9D0 VA: 0x1AF29D0
	internal static void ImplementsInterfaces(StorageType typeCode, Type dataType, out bool sqlType, out bool nullable, out bool xmlSerializable, out bool changeTracking, out bool revertibleChangeTracking) { }

	// RVA: 0x1AF2B24 Offset: 0x1AEEB24 VA: 0x1AF2B24
	private static Tuple<bool, bool, bool, bool> InspectTypeForInterfaces(Type dataType) { }

	// RVA: 0x1AF2CD0 Offset: 0x1AEECD0 VA: 0x1AF2CD0
	internal static bool ImplementsINullableValue(StorageType typeCode, Type dataType) { }

	// RVA: 0x1AF2D98 Offset: 0x1AEED98 VA: 0x1AF2D98
	public static bool IsObjectNull(object value) { }

	// RVA: 0x1AF2E38 Offset: 0x1AEEE38 VA: 0x1AF2E38
	public static bool IsObjectSqlNull(object value) { }

	// RVA: 0x1AF2EEC Offset: 0x1AEEEEC VA: 0x1AF2EEC
	internal object GetEmptyStorageInternal(int recordCount) { }

	// RVA: 0x1AF2EFC Offset: 0x1AEEEFC VA: 0x1AF2EFC
	internal void CopyValueInternal(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1AF2F0C Offset: 0x1AEEF0C VA: 0x1AF2F0C
	internal void SetStorageInternal(object store, BitArray nullbits) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract object GetEmptyStorage(int recordCount);

	// RVA: -1 Offset: -1 Slot: 19
	protected abstract void CopyValue(int record, object store, BitArray nullbits, int storeIndex);

	// RVA: -1 Offset: -1 Slot: 20
	protected abstract void SetStorage(object store, BitArray nullbits);

	// RVA: 0x1AF2F1C Offset: 0x1AEEF1C VA: 0x1AF2F1C
	protected void SetNullStorage(BitArray nullbits) { }

	// RVA: 0x1AE9430 Offset: 0x1AE5430 VA: 0x1AE9430
	internal static Type GetType(string value) { }

	// RVA: 0x1AF2F24 Offset: 0x1AEEF24 VA: 0x1AF2F24
	internal static string GetQualifiedName(Type type) { }

	// RVA: 0x1AF2F94 Offset: 0x1AEEF94 VA: 0x1AF2F94
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class DateTimeOffsetStorage : DataStorage // TypeDefIndex: 4608
{
	// Fields
	private static readonly DateTimeOffset s_defaultValue; // 0x0
	private DateTimeOffset[] _values; // 0x50

	// Methods

	// RVA: 0x1AF2734 Offset: 0x1AEE734 VA: 0x1AF2734
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1AF3DC8 Offset: 0x1AEFDC8 VA: 0x1AF3DC8 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1AF42E8 Offset: 0x1AF02E8 VA: 0x1AF42E8 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1AF4484 Offset: 0x1AF0484 VA: 0x1AF4484 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1AF4600 Offset: 0x1AF0600 VA: 0x1AF4600 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1AF46A4 Offset: 0x1AF06A4 VA: 0x1AF46A4 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1AF46F8 Offset: 0x1AF06F8 VA: 0x1AF46F8 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1AF4800 Offset: 0x1AF0800 VA: 0x1AF4800 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1AF4920 Offset: 0x1AF0920 VA: 0x1AF4920 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1AF49F0 Offset: 0x1AF09F0 VA: 0x1AF49F0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1AF4A7C Offset: 0x1AF0A7C VA: 0x1AF4A7C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1AF4B18 Offset: 0x1AF0B18 VA: 0x1AF4B18 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1AF4B60 Offset: 0x1AF0B60 VA: 0x1AF4B60 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1AF4C64 Offset: 0x1AF0C64 VA: 0x1AF4C64 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1AF4D28 Offset: 0x1AF0D28 VA: 0x1AF4D28
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class DateTimeStorage : DataStorage // TypeDefIndex: 4609
{
	// Fields
	private static readonly DateTime s_defaultValue; // 0x0
	private DateTime[] _values; // 0x50

	// Methods

	// RVA: 0x1AF2618 Offset: 0x1AEE618 VA: 0x1AF2618
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1AF4DA0 Offset: 0x1AF0DA0 VA: 0x1AF4DA0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1AF5290 Offset: 0x1AF1290 VA: 0x1AF5290 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1AF5408 Offset: 0x1AF1408 VA: 0x1AF5408 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1AF5570 Offset: 0x1AF1570 VA: 0x1AF5570 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1AF56C0 Offset: 0x1AF16C0 VA: 0x1AF56C0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1AF5714 Offset: 0x1AF1714 VA: 0x1AF5714 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1AF580C Offset: 0x1AF180C VA: 0x1AF580C Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1AF5B98 Offset: 0x1AF1B98 VA: 0x1AF5B98 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1AF5C68 Offset: 0x1AF1C68 VA: 0x1AF5C68 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1AF5D28 Offset: 0x1AF1D28 VA: 0x1AF5D28 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1AF5E18 Offset: 0x1AF1E18 VA: 0x1AF5E18 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1AF5E60 Offset: 0x1AF1E60 VA: 0x1AF5E60 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1AF5FC0 Offset: 0x1AF1FC0 VA: 0x1AF5FC0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1AF61DC Offset: 0x1AF21DC VA: 0x1AF61DC
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class DecimalStorage : DataStorage // TypeDefIndex: 4610
{
	// Fields
	private static readonly Decimal s_defaultValue; // 0x0
	private Decimal[] _values; // 0x50

	// Methods

	// RVA: 0x1AF24E8 Offset: 0x1AEE4E8 VA: 0x1AF24E8
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1AF6254 Offset: 0x1AF2254 VA: 0x1AF6254 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1AF6EB0 Offset: 0x1AF2EB0 VA: 0x1AF6EB0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1AF7024 Offset: 0x1AF3024 VA: 0x1AF7024 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1AF718C Offset: 0x1AF318C VA: 0x1AF718C Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1AF7334 Offset: 0x1AF3334 VA: 0x1AF7334 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1AF7388 Offset: 0x1AF3388 VA: 0x1AF7388 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1AF7468 Offset: 0x1AF3468 VA: 0x1AF7468 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1AF760C Offset: 0x1AF360C VA: 0x1AF760C Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1AF76DC Offset: 0x1AF36DC VA: 0x1AF76DC Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1AF7790 Offset: 0x1AF3790 VA: 0x1AF7790 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1AF782C Offset: 0x1AF382C VA: 0x1AF782C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1AF7874 Offset: 0x1AF3874 VA: 0x1AF7874 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1AF7978 Offset: 0x1AF3978 VA: 0x1AF7978 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class DoubleStorage : DataStorage // TypeDefIndex: 4611
{
	// Fields
	private double[] _values; // 0x50

	// Methods

	// RVA: 0x1AF2428 Offset: 0x1AEE428 VA: 0x1AF2428
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1AF7A3C Offset: 0x1AF3A3C VA: 0x1AF7A3C Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1AF81A8 Offset: 0x1AF41A8 VA: 0x1AF81A8 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1AF8228 Offset: 0x1AF4228 VA: 0x1AF8228 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1AF82F0 Offset: 0x1AF42F0 VA: 0x1AF82F0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1AF8430 Offset: 0x1AF4430 VA: 0x1AF8430 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1AF8484 Offset: 0x1AF4484 VA: 0x1AF8484 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1AF84DC Offset: 0x1AF44DC VA: 0x1AF84DC Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1AF8660 Offset: 0x1AF4660 VA: 0x1AF8660 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1AF8730 Offset: 0x1AF4730 VA: 0x1AF8730 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1AF87AC Offset: 0x1AF47AC VA: 0x1AF87AC Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1AF883C Offset: 0x1AF483C VA: 0x1AF883C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1AF8884 Offset: 0x1AF4884 VA: 0x1AF8884 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1AF8984 Offset: 0x1AF4984 VA: 0x1AF8984 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class Int16Storage : DataStorage // TypeDefIndex: 4612
{
	// Fields
	private short[] _values; // 0x50

	// Methods

	// RVA: 0x1AF21E8 Offset: 0x1AEE1E8 VA: 0x1AF21E8
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1AF8A48 Offset: 0x1AF4A48 VA: 0x1AF8A48 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1AF9298 Offset: 0x1AF5298 VA: 0x1AF9298 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1AF92F8 Offset: 0x1AF52F8 VA: 0x1AF92F8 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1AF93A8 Offset: 0x1AF53A8 VA: 0x1AF93A8 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1AF94EC Offset: 0x1AF54EC VA: 0x1AF94EC Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1AF9540 Offset: 0x1AF5540 VA: 0x1AF9540 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1AF9594 Offset: 0x1AF5594 VA: 0x1AF9594 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1AF971C Offset: 0x1AF571C VA: 0x1AF971C Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1AF97EC Offset: 0x1AF57EC VA: 0x1AF97EC Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1AF986C Offset: 0x1AF586C VA: 0x1AF986C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1AF98F8 Offset: 0x1AF58F8 VA: 0x1AF98F8 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1AF9940 Offset: 0x1AF5940 VA: 0x1AF9940 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1AF9A3C Offset: 0x1AF5A3C VA: 0x1AF9A3C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class Int32Storage : DataStorage // TypeDefIndex: 4613
{
	// Fields
	private int[] _values; // 0x50

	// Methods

	// RVA: 0x1AF22A8 Offset: 0x1AEE2A8 VA: 0x1AF22A8
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1AF9B00 Offset: 0x1AF5B00 VA: 0x1AF9B00 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1AFA354 Offset: 0x1AF6354 VA: 0x1AFA354 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1AFA3C0 Offset: 0x1AF63C0 VA: 0x1AFA3C0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1AFA470 Offset: 0x1AF6470 VA: 0x1AFA470 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1AFA5B4 Offset: 0x1AF65B4 VA: 0x1AFA5B4 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1AFA608 Offset: 0x1AF6608 VA: 0x1AFA608 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1AFA65C Offset: 0x1AF665C VA: 0x1AFA65C Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1AFA7E4 Offset: 0x1AF67E4 VA: 0x1AFA7E4 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1AFA8B4 Offset: 0x1AF68B4 VA: 0x1AFA8B4 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1AFA934 Offset: 0x1AF6934 VA: 0x1AFA934 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1AFA9C0 Offset: 0x1AF69C0 VA: 0x1AFA9C0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1AFAA08 Offset: 0x1AF6A08 VA: 0x1AFAA08 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1AFAB04 Offset: 0x1AF6B04 VA: 0x1AFAB04 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class Int64Storage : DataStorage // TypeDefIndex: 4614
{
	// Fields
	private long[] _values; // 0x50

	// Methods

	// RVA: 0x1AF2368 Offset: 0x1AEE368 VA: 0x1AF2368
	internal void .ctor(DataColumn column) { }

	// RVA: 0x1AFABC8 Offset: 0x1AF6BC8 VA: 0x1AFABC8 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1AFB404 Offset: 0x1AF7404 VA: 0x1AFB404 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1AFB470 Offset: 0x1AF7470 VA: 0x1AFB470 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1AFB520 Offset: 0x1AF7520 VA: 0x1AFB520 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1AFB664 Offset: 0x1AF7664 VA: 0x1AFB664 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1AFB6B8 Offset: 0x1AF76B8 VA: 0x1AFB6B8 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1AFB70C Offset: 0x1AF770C VA: 0x1AFB70C Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1AFB894 Offset: 0x1AF7894 VA: 0x1AFB894 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1AFB964 Offset: 0x1AF7964 VA: 0x1AFB964 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1AFB9E4 Offset: 0x1AF79E4 VA: 0x1AFB9E4 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1AFBA70 Offset: 0x1AF7A70 VA: 0x1AFBA70 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1AFBAB8 Offset: 0x1AF7AB8 VA: 0x1AFBAB8 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1AFBBB4 Offset: 0x1AF7BB4 VA: 0x1AFBBB4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SByteStorage : DataStorage // TypeDefIndex: 4615
{
	// Fields
	private sbyte[] _values; // 0x50

	// Methods

	// RVA: 0x1AF2128 Offset: 0x1AEE128 VA: 0x1AF2128
	public void .ctor(DataColumn column) { }

	// RVA: 0x1AFBC78 Offset: 0x1AF7C78 VA: 0x1AFBC78 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1AFC47C Offset: 0x1AF847C VA: 0x1AFC47C Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1AFC534 Offset: 0x1AF8534 VA: 0x1AFC534 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1AFC5F8 Offset: 0x1AF85F8 VA: 0x1AFC5F8 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1AFC73C Offset: 0x1AF873C VA: 0x1AFC73C Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1AFC790 Offset: 0x1AF8790 VA: 0x1AFC790 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1AFC818 Offset: 0x1AF8818 VA: 0x1AFC818 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1AFC99C Offset: 0x1AF899C VA: 0x1AFC99C Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1AFCA6C Offset: 0x1AF8A6C VA: 0x1AFCA6C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1AFCAEC Offset: 0x1AF8AEC VA: 0x1AFCAEC Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1AFCB78 Offset: 0x1AF8B78 VA: 0x1AFCB78 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1AFCBC0 Offset: 0x1AF8BC0 VA: 0x1AFCBC0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1AFCCC0 Offset: 0x1AF8CC0 VA: 0x1AFCCC0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal static class SqlConvert // TypeDefIndex: 4616
{
	// Methods

	// RVA: 0x1AFCD84 Offset: 0x1AF8D84 VA: 0x1AFCD84
	public static SqlByte ConvertToSqlByte(object value) { }

	// RVA: 0x1AFCF58 Offset: 0x1AF8F58 VA: 0x1AFCF58
	public static SqlInt16 ConvertToSqlInt16(object value) { }

	// RVA: 0x1AFD1EC Offset: 0x1AF91EC VA: 0x1AFD1EC
	public static SqlInt32 ConvertToSqlInt32(object value) { }

	// RVA: 0x1AFD590 Offset: 0x1AF9590 VA: 0x1AFD590
	public static SqlInt64 ConvertToSqlInt64(object value) { }

	// RVA: 0x1AFDA20 Offset: 0x1AF9A20 VA: 0x1AFDA20
	public static SqlDouble ConvertToSqlDouble(object value) { }

	// RVA: 0x1AFE060 Offset: 0x1AFA060 VA: 0x1AFE060
	public static SqlDecimal ConvertToSqlDecimal(object value) { }

	// RVA: 0x1AFE62C Offset: 0x1AFA62C VA: 0x1AFE62C
	public static SqlSingle ConvertToSqlSingle(object value) { }

	// RVA: 0x1AFEBF4 Offset: 0x1AFABF4 VA: 0x1AFEBF4
	public static SqlMoney ConvertToSqlMoney(object value) { }

	// RVA: 0x1AFF1A8 Offset: 0x1AFB1A8 VA: 0x1AFF1A8
	public static SqlDateTime ConvertToSqlDateTime(object value) { }

	// RVA: 0x1AFF394 Offset: 0x1AFB394 VA: 0x1AFF394
	public static SqlBoolean ConvertToSqlBoolean(object value) { }

	// RVA: 0x1AFF554 Offset: 0x1AFB554 VA: 0x1AFF554
	public static SqlGuid ConvertToSqlGuid(object value) { }

	// RVA: 0x1AFF734 Offset: 0x1AFB734 VA: 0x1AFF734
	public static SqlBinary ConvertToSqlBinary(object value) { }

	// RVA: 0x1AFF908 Offset: 0x1AFB908 VA: 0x1AFF908
	public static SqlString ConvertToSqlString(object value) { }

	// RVA: 0x1AFFAD8 Offset: 0x1AFBAD8 VA: 0x1AFFAD8
	public static SqlChars ConvertToSqlChars(object value) { }

	// RVA: 0x1AFFC24 Offset: 0x1AFBC24 VA: 0x1AFFC24
	public static SqlBytes ConvertToSqlBytes(object value) { }

	// RVA: 0x1AFFD70 Offset: 0x1AFBD70 VA: 0x1AFFD70
	public static DateTimeOffset ConvertStringToDateTimeOffset(string value, IFormatProvider formatProvider) { }

	// RVA: 0x1AFFDD8 Offset: 0x1AFBDD8 VA: 0x1AFFDD8
	public static object ChangeTypeForDefaultValue(object value, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x1AFFF98 Offset: 0x1AFBF98 VA: 0x1AFFF98
	public static object ChangeType2(object value, StorageType stype, Type type, IFormatProvider formatProvider) { }

	// RVA: 0x1AE955C Offset: 0x1AE555C VA: 0x1AE955C
	public static object ChangeTypeForXML(object value, Type type) { }
}

// Namespace: System.Data.Common
internal sealed class SqlBinaryStorage : DataStorage // TypeDefIndex: 4617
{
	// Fields
	private SqlBinary[] _values; // 0x50

	// Methods

	// RVA: 0x1B00F64 Offset: 0x1AFCF64 VA: 0x1B00F64
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B01098 Offset: 0x1AFD098 VA: 0x1B01098 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B012F8 Offset: 0x1AFD2F8 VA: 0x1B012F8 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B01398 Offset: 0x1AFD398 VA: 0x1B01398 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B01454 Offset: 0x1AFD454 VA: 0x1B01454 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B014CC Offset: 0x1AFD4CC VA: 0x1B014CC Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B01510 Offset: 0x1AFD510 VA: 0x1B01510 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B01590 Offset: 0x1AFD590 VA: 0x1B01590 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B0160C Offset: 0x1AFD60C VA: 0x1B0160C Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B0165C Offset: 0x1AFD65C VA: 0x1B0165C Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B0171C Offset: 0x1AFD71C VA: 0x1B0171C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B019BC Offset: 0x1AFD9BC VA: 0x1B019BC Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B01C0C Offset: 0x1AFDC0C VA: 0x1B01C0C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B01C54 Offset: 0x1AFDC54 VA: 0x1B01C54 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B01D5C Offset: 0x1AFDD5C VA: 0x1B01D5C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlByteStorage : DataStorage // TypeDefIndex: 4618
{
	// Fields
	private SqlByte[] _values; // 0x50

	// Methods

	// RVA: 0x1B01DF8 Offset: 0x1AFDDF8 VA: 0x1B01DF8
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B01F24 Offset: 0x1AFDF24 VA: 0x1B01F24 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B02DAC Offset: 0x1AFEDAC VA: 0x1B02DAC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B02E4C Offset: 0x1AFEE4C VA: 0x1B02E4C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B02F08 Offset: 0x1AFEF08 VA: 0x1B02F08 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B02F80 Offset: 0x1AFEF80 VA: 0x1B02F80 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B02FBC Offset: 0x1AFEFBC VA: 0x1B02FBC Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B0303C Offset: 0x1AFF03C VA: 0x1B0303C Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B030B8 Offset: 0x1AFF0B8 VA: 0x1B030B8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B03100 Offset: 0x1AFF100 VA: 0x1B03100 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B031C0 Offset: 0x1AFF1C0 VA: 0x1B031C0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B03460 Offset: 0x1AFF460 VA: 0x1B03460 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B036B0 Offset: 0x1AFF6B0 VA: 0x1B036B0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B036F8 Offset: 0x1AFF6F8 VA: 0x1B036F8 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B037F8 Offset: 0x1AFF7F8 VA: 0x1B037F8 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlBytesStorage : DataStorage // TypeDefIndex: 4619
{
	// Fields
	private SqlBytes[] _values; // 0x50

	// Methods

	// RVA: 0x1B03894 Offset: 0x1AFF894 VA: 0x1B03894
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B03968 Offset: 0x1AFF968 VA: 0x1B03968 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B03B88 Offset: 0x1AFFB88 VA: 0x1B03B88 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B03B90 Offset: 0x1AFFB90 VA: 0x1B03B90 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B03B98 Offset: 0x1AFFB98 VA: 0x1B03B98 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B03BD8 Offset: 0x1AFFBD8 VA: 0x1B03BD8 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B03C08 Offset: 0x1AFFC08 VA: 0x1B03C08 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B03C40 Offset: 0x1AFFC40 VA: 0x1B03C40 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B03D38 Offset: 0x1AFFD38 VA: 0x1B03D38 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B03DF8 Offset: 0x1AFFDF8 VA: 0x1B03DF8 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B040BC Offset: 0x1B000BC VA: 0x1B040BC Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B0430C Offset: 0x1B0030C VA: 0x1B0430C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B04354 Offset: 0x1B00354 VA: 0x1B04354 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B0445C Offset: 0x1B0045C VA: 0x1B0445C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlCharsStorage : DataStorage // TypeDefIndex: 4620
{
	// Fields
	private SqlChars[] _values; // 0x50

	// Methods

	// RVA: 0x1B044F8 Offset: 0x1B004F8 VA: 0x1B044F8
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B045CC Offset: 0x1B005CC VA: 0x1B045CC Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B047EC Offset: 0x1B007EC VA: 0x1B047EC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B047F4 Offset: 0x1B007F4 VA: 0x1B047F4 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B047FC Offset: 0x1B007FC VA: 0x1B047FC Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B0483C Offset: 0x1B0083C VA: 0x1B0483C Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B0486C Offset: 0x1B0086C VA: 0x1B0486C Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B048A4 Offset: 0x1B008A4 VA: 0x1B048A4 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B0499C Offset: 0x1B0099C VA: 0x1B0499C Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B04A5C Offset: 0x1B00A5C VA: 0x1B04A5C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B04D2C Offset: 0x1B00D2C VA: 0x1B04D2C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B04F7C Offset: 0x1B00F7C VA: 0x1B04F7C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B04FC4 Offset: 0x1B00FC4 VA: 0x1B04FC4 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B050CC Offset: 0x1B010CC VA: 0x1B050CC Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlDateTimeStorage : DataStorage // TypeDefIndex: 4621
{
	// Fields
	private SqlDateTime[] _values; // 0x50

	// Methods

	// RVA: 0x1B05168 Offset: 0x1B01168 VA: 0x1B05168
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B052AC Offset: 0x1B012AC VA: 0x1B052AC Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B058D4 Offset: 0x1B018D4 VA: 0x1B058D4 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B05988 Offset: 0x1B01988 VA: 0x1B05988 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B05A4C Offset: 0x1B01A4C VA: 0x1B05A4C Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B05AC8 Offset: 0x1B01AC8 VA: 0x1B05AC8 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B05B18 Offset: 0x1B01B18 VA: 0x1B05B18 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B05BA4 Offset: 0x1B01BA4 VA: 0x1B05BA4 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B05C24 Offset: 0x1B01C24 VA: 0x1B05C24 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B05C74 Offset: 0x1B01C74 VA: 0x1B05C74 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B05D34 Offset: 0x1B01D34 VA: 0x1B05D34 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B05FE4 Offset: 0x1B01FE4 VA: 0x1B05FE4 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B06234 Offset: 0x1B02234 VA: 0x1B06234 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B0627C Offset: 0x1B0227C VA: 0x1B0627C Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B06390 Offset: 0x1B02390 VA: 0x1B06390 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlDecimalStorage : DataStorage // TypeDefIndex: 4622
{
	// Fields
	private SqlDecimal[] _values; // 0x50

	// Methods

	// RVA: 0x1B0642C Offset: 0x1B0242C VA: 0x1B0642C
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B06570 Offset: 0x1B02570 VA: 0x1B06570 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B074BC Offset: 0x1B034BC VA: 0x1B074BC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B07594 Offset: 0x1B03594 VA: 0x1B07594 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B0766C Offset: 0x1B0366C VA: 0x1B0766C Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B076F0 Offset: 0x1B036F0 VA: 0x1B076F0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B07740 Offset: 0x1B03740 VA: 0x1B07740 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B077D4 Offset: 0x1B037D4 VA: 0x1B077D4 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B07854 Offset: 0x1B03854 VA: 0x1B07854 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B078BC Offset: 0x1B038BC VA: 0x1B078BC Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B0797C Offset: 0x1B0397C VA: 0x1B0797C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B07C2C Offset: 0x1B03C2C VA: 0x1B07C2C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B07E7C Offset: 0x1B03E7C VA: 0x1B07E7C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B07EC4 Offset: 0x1B03EC4 VA: 0x1B07EC4 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B07FE8 Offset: 0x1B03FE8 VA: 0x1B07FE8 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlDoubleStorage : DataStorage // TypeDefIndex: 4623
{
	// Fields
	private SqlDouble[] _values; // 0x50

	// Methods

	// RVA: 0x1B08084 Offset: 0x1B04084 VA: 0x1B08084
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B081B8 Offset: 0x1B041B8 VA: 0x1B081B8 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B08F1C Offset: 0x1B04F1C VA: 0x1B08F1C Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B08FC0 Offset: 0x1B04FC0 VA: 0x1B08FC0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B0907C Offset: 0x1B0507C VA: 0x1B0907C Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B090F4 Offset: 0x1B050F4 VA: 0x1B090F4 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B09130 Offset: 0x1B05130 VA: 0x1B09130 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B091B0 Offset: 0x1B051B0 VA: 0x1B091B0 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B0922C Offset: 0x1B0522C VA: 0x1B0922C Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B09274 Offset: 0x1B05274 VA: 0x1B09274 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B09334 Offset: 0x1B05334 VA: 0x1B09334 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B095D4 Offset: 0x1B055D4 VA: 0x1B095D4 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B09824 Offset: 0x1B05824 VA: 0x1B09824 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B0986C Offset: 0x1B0586C VA: 0x1B0986C Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B09974 Offset: 0x1B05974 VA: 0x1B09974 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlGuidStorage : DataStorage // TypeDefIndex: 4624
{
	// Fields
	private SqlGuid[] _values; // 0x50

	// Methods

	// RVA: 0x1B09A10 Offset: 0x1B05A10 VA: 0x1B09A10
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B09B44 Offset: 0x1B05B44 VA: 0x1B09B44 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B09DA4 Offset: 0x1B05DA4 VA: 0x1B09DA4 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B09E44 Offset: 0x1B05E44 VA: 0x1B09E44 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B09F00 Offset: 0x1B05F00 VA: 0x1B09F00 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B09F78 Offset: 0x1B05F78 VA: 0x1B09F78 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B09FBC Offset: 0x1B05FBC VA: 0x1B09FBC Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B0A03C Offset: 0x1B0603C VA: 0x1B0A03C Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B0A0B8 Offset: 0x1B060B8 VA: 0x1B0A0B8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B0A108 Offset: 0x1B06108 VA: 0x1B0A108 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B0A1C8 Offset: 0x1B061C8 VA: 0x1B0A1C8 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B0A468 Offset: 0x1B06468 VA: 0x1B0A468 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B0A6B8 Offset: 0x1B066B8 VA: 0x1B0A6B8 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B0A700 Offset: 0x1B06700 VA: 0x1B0A700 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B0A808 Offset: 0x1B06808 VA: 0x1B0A808 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlInt16Storage : DataStorage // TypeDefIndex: 4625
{
	// Fields
	private SqlInt16[] _values; // 0x50

	// Methods

	// RVA: 0x1B0A8A4 Offset: 0x1B068A4 VA: 0x1B0A8A4
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B0A9D0 Offset: 0x1B069D0 VA: 0x1B0A9D0 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B0B858 Offset: 0x1B07858 VA: 0x1B0B858 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B0B8F8 Offset: 0x1B078F8 VA: 0x1B0B8F8 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B0B9B4 Offset: 0x1B079B4 VA: 0x1B0B9B4 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B0BA2C Offset: 0x1B07A2C VA: 0x1B0BA2C Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B0BA68 Offset: 0x1B07A68 VA: 0x1B0BA68 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B0BAE8 Offset: 0x1B07AE8 VA: 0x1B0BAE8 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B0BB64 Offset: 0x1B07B64 VA: 0x1B0BB64 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B0BBAC Offset: 0x1B07BAC VA: 0x1B0BBAC Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B0BC6C Offset: 0x1B07C6C VA: 0x1B0BC6C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B0BF0C Offset: 0x1B07F0C VA: 0x1B0BF0C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B0C15C Offset: 0x1B0815C VA: 0x1B0C15C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B0C1A4 Offset: 0x1B081A4 VA: 0x1B0C1A4 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B0C2A4 Offset: 0x1B082A4 VA: 0x1B0C2A4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlInt32Storage : DataStorage // TypeDefIndex: 4626
{
	// Fields
	private SqlInt32[] _values; // 0x50

	// Methods

	// RVA: 0x1B0C340 Offset: 0x1B08340 VA: 0x1B0C340
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B0C474 Offset: 0x1B08474 VA: 0x1B0C474 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B0D2CC Offset: 0x1B092CC VA: 0x1B0D2CC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B0D36C Offset: 0x1B0936C VA: 0x1B0D36C Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B0D428 Offset: 0x1B09428 VA: 0x1B0D428 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B0D4A0 Offset: 0x1B094A0 VA: 0x1B0D4A0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B0D4DC Offset: 0x1B094DC VA: 0x1B0D4DC Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B0D55C Offset: 0x1B0955C VA: 0x1B0D55C Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B0D5D8 Offset: 0x1B095D8 VA: 0x1B0D5D8 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B0D620 Offset: 0x1B09620 VA: 0x1B0D620 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B0D6E0 Offset: 0x1B096E0 VA: 0x1B0D6E0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B0D980 Offset: 0x1B09980 VA: 0x1B0D980 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B0DBD0 Offset: 0x1B09BD0 VA: 0x1B0DBD0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B0DC18 Offset: 0x1B09C18 VA: 0x1B0DC18 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B0DD18 Offset: 0x1B09D18 VA: 0x1B0DD18 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlInt64Storage : DataStorage // TypeDefIndex: 4627
{
	// Fields
	private SqlInt64[] _values; // 0x50

	// Methods

	// RVA: 0x1B0DDB4 Offset: 0x1B09DB4 VA: 0x1B0DDB4
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B0DEE8 Offset: 0x1B09EE8 VA: 0x1B0DEE8 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B0EDC0 Offset: 0x1B0ADC0 VA: 0x1B0EDC0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B0EE64 Offset: 0x1B0AE64 VA: 0x1B0EE64 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B0EF20 Offset: 0x1B0AF20 VA: 0x1B0EF20 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B0EF98 Offset: 0x1B0AF98 VA: 0x1B0EF98 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B0EFD4 Offset: 0x1B0AFD4 VA: 0x1B0EFD4 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B0F054 Offset: 0x1B0B054 VA: 0x1B0F054 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B0F0D0 Offset: 0x1B0B0D0 VA: 0x1B0F0D0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B0F118 Offset: 0x1B0B118 VA: 0x1B0F118 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B0F1D8 Offset: 0x1B0B1D8 VA: 0x1B0F1D8 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B0F478 Offset: 0x1B0B478 VA: 0x1B0F478 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B0F6C8 Offset: 0x1B0B6C8 VA: 0x1B0F6C8 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B0F710 Offset: 0x1B0B710 VA: 0x1B0F710 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B0F818 Offset: 0x1B0B818 VA: 0x1B0F818 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlMoneyStorage : DataStorage // TypeDefIndex: 4628
{
	// Fields
	private SqlMoney[] _values; // 0x50

	// Methods

	// RVA: 0x1B0F8B4 Offset: 0x1B0B8B4 VA: 0x1B0F8B4
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B0F9E8 Offset: 0x1B0B9E8 VA: 0x1B0F9E8 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B10910 Offset: 0x1B0C910 VA: 0x1B10910 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B109B4 Offset: 0x1B0C9B4 VA: 0x1B109B4 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B10A70 Offset: 0x1B0CA70 VA: 0x1B10A70 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B10AE8 Offset: 0x1B0CAE8 VA: 0x1B10AE8 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B10B24 Offset: 0x1B0CB24 VA: 0x1B10B24 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B10BA4 Offset: 0x1B0CBA4 VA: 0x1B10BA4 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B10C20 Offset: 0x1B0CC20 VA: 0x1B10C20 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B10C68 Offset: 0x1B0CC68 VA: 0x1B10C68 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B10D28 Offset: 0x1B0CD28 VA: 0x1B10D28 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B10FC8 Offset: 0x1B0CFC8 VA: 0x1B10FC8 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B11218 Offset: 0x1B0D218 VA: 0x1B11218 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B11260 Offset: 0x1B0D260 VA: 0x1B11260 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B11368 Offset: 0x1B0D368 VA: 0x1B11368 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlSingleStorage : DataStorage // TypeDefIndex: 4629
{
	// Fields
	private SqlSingle[] _values; // 0x50

	// Methods

	// RVA: 0x1B11404 Offset: 0x1B0D404 VA: 0x1B11404
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B11538 Offset: 0x1B0D538 VA: 0x1B11538 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B12364 Offset: 0x1B0E364 VA: 0x1B12364 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B12404 Offset: 0x1B0E404 VA: 0x1B12404 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B124C0 Offset: 0x1B0E4C0 VA: 0x1B124C0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B12538 Offset: 0x1B0E538 VA: 0x1B12538 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B12574 Offset: 0x1B0E574 VA: 0x1B12574 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B125F4 Offset: 0x1B0E5F4 VA: 0x1B125F4 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B12670 Offset: 0x1B0E670 VA: 0x1B12670 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B126B8 Offset: 0x1B0E6B8 VA: 0x1B126B8 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B12778 Offset: 0x1B0E778 VA: 0x1B12778 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B12A18 Offset: 0x1B0EA18 VA: 0x1B12A18 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B12C68 Offset: 0x1B0EC68 VA: 0x1B12C68 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B12CB0 Offset: 0x1B0ECB0 VA: 0x1B12CB0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B12DB0 Offset: 0x1B0EDB0 VA: 0x1B12DB0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlStringStorage : DataStorage // TypeDefIndex: 4630
{
	// Fields
	private SqlString[] _values; // 0x50

	// Methods

	// RVA: 0x1B12E4C Offset: 0x1B0EE4C VA: 0x1B12E4C
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B12F8C Offset: 0x1B0EF8C VA: 0x1B12F8C Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x1B133B0 Offset: 0x1B0F3B0 VA: 0x1B133B0 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B1341C Offset: 0x1B0F41C VA: 0x1B1341C
	public int Compare(SqlString valueNo1, SqlString valueNo2) { }

	// RVA: 0x1B13558 Offset: 0x1B0F558 VA: 0x1B13558 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B1361C Offset: 0x1B0F61C VA: 0x1B1361C Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B13698 Offset: 0x1B0F698 VA: 0x1B13698 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B136EC Offset: 0x1B0F6EC VA: 0x1B136EC Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B13774 Offset: 0x1B0F774 VA: 0x1B13774 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x1B13840 Offset: 0x1B0F840 VA: 0x1B13840 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B138C0 Offset: 0x1B0F8C0 VA: 0x1B138C0 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B13928 Offset: 0x1B0F928 VA: 0x1B13928 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B139E8 Offset: 0x1B0F9E8 VA: 0x1B139E8 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B13C90 Offset: 0x1B0FC90 VA: 0x1B13C90 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B13EE0 Offset: 0x1B0FEE0 VA: 0x1B13EE0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B13F28 Offset: 0x1B0FF28 VA: 0x1B13F28 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B14044 Offset: 0x1B10044 VA: 0x1B14044 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SqlBooleanStorage : DataStorage // TypeDefIndex: 4631
{
	// Fields
	private SqlBoolean[] _values; // 0x50

	// Methods

	// RVA: 0x1B140E0 Offset: 0x1B100E0 VA: 0x1B140E0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B1420C Offset: 0x1B1020C VA: 0x1B1420C Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B146C8 Offset: 0x1B106C8 VA: 0x1B146C8 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B14768 Offset: 0x1B10768 VA: 0x1B14768 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B14824 Offset: 0x1B10824 VA: 0x1B14824 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B1489C Offset: 0x1B1089C VA: 0x1B1489C Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B148D8 Offset: 0x1B108D8 VA: 0x1B148D8 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B14958 Offset: 0x1B10958 VA: 0x1B14958 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B149D4 Offset: 0x1B109D4 VA: 0x1B149D4 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B14A1C Offset: 0x1B10A1C VA: 0x1B14A1C Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B14ADC Offset: 0x1B10ADC VA: 0x1B14ADC Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B14D7C Offset: 0x1B10D7C VA: 0x1B14D7C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B14FCC Offset: 0x1B10FCC VA: 0x1B14FCC Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B15014 Offset: 0x1B11014 VA: 0x1B15014 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B15114 Offset: 0x1B11114 VA: 0x1B15114 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class SingleStorage : DataStorage // TypeDefIndex: 4632
{
	// Fields
	private float[] _values; // 0x50

	// Methods

	// RVA: 0x1B151B0 Offset: 0x1B111B0 VA: 0x1B151B0
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B15274 Offset: 0x1B11274 VA: 0x1B15274 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B159F4 Offset: 0x1B119F4 VA: 0x1B159F4 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B15A78 Offset: 0x1B11A78 VA: 0x1B15A78 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B15B40 Offset: 0x1B11B40 VA: 0x1B15B40 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B15C78 Offset: 0x1B11C78 VA: 0x1B15C78 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B15CD0 Offset: 0x1B11CD0 VA: 0x1B15CD0 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B15D2C Offset: 0x1B11D2C VA: 0x1B15D2C Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B15EA8 Offset: 0x1B11EA8 VA: 0x1B15EA8 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B15F7C Offset: 0x1B11F7C VA: 0x1B15F7C Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B15FF8 Offset: 0x1B11FF8 VA: 0x1B15FF8 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B16088 Offset: 0x1B12088 VA: 0x1B16088 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B160D0 Offset: 0x1B120D0 VA: 0x1B160D0 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B161D0 Offset: 0x1B121D0 VA: 0x1B161D0 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SqlUdtStorage.<>c__DisplayClass6_0 // TypeDefIndex: 4633
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x1B165A0 Offset: 0x1B125A0 VA: 0x1B165A0
	public void .ctor() { }

	// RVA: 0x1B17908 Offset: 0x1B13908 VA: 0x1B17908
	internal object <GetStaticNullForUdtType>b__0(Type t) { }
}

// Namespace: System.Data.Common
internal sealed class SqlUdtStorage : DataStorage // TypeDefIndex: 4634
{
	// Fields
	private object[] _values; // 0x50
	private readonly bool _implementsIXmlSerializable; // 0x58
	private readonly bool _implementsIComparable; // 0x59
	private static readonly ConcurrentDictionary<Type, object> s_typeToNull; // 0x0

	// Methods

	// RVA: 0x1B16294 Offset: 0x1B12294 VA: 0x1B16294
	public void .ctor(DataColumn column, Type type) { }

	// RVA: 0x1B16420 Offset: 0x1B12420 VA: 0x1B16420
	private void .ctor(DataColumn column, Type type, object nullValue) { }

	// RVA: 0x1B1630C Offset: 0x1B1230C VA: 0x1B1630C
	internal static object GetStaticNullForUdtType(Type type) { }

	// RVA: 0x1B165A8 Offset: 0x1B125A8 VA: 0x1B165A8 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B166AC Offset: 0x1B126AC VA: 0x1B166AC Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B166DC Offset: 0x1B126DC VA: 0x1B166DC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B16714 Offset: 0x1B12714 VA: 0x1B16714 Slot: 6
	public override int CompareValueTo(int recordNo1, object value) { }

	// RVA: 0x1B169A0 Offset: 0x1B129A0 VA: 0x1B169A0 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B16A28 Offset: 0x1B12A28 VA: 0x1B16A28 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x1B16A58 Offset: 0x1B12A58 VA: 0x1B16A58 Slot: 12
	public override void Set(int recordNo, object value) { }

	// RVA: 0x1B16BC0 Offset: 0x1B12BC0 VA: 0x1B16BC0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B16C94 Offset: 0x1B12C94 VA: 0x1B16C94 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B16F9C Offset: 0x1B12F9C VA: 0x1B16F9C Slot: 15
	public override object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1B1722C Offset: 0x1B1322C VA: 0x1B1722C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B174F4 Offset: 0x1B134F4 VA: 0x1B174F4 Slot: 17
	public override void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1B1764C Offset: 0x1B1364C VA: 0x1B1764C Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B17694 Offset: 0x1B13694 VA: 0x1B17694 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B177D4 Offset: 0x1B137D4 VA: 0x1B177D4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1B17870 Offset: 0x1B13870 VA: 0x1B17870
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class StringStorage : DataStorage // TypeDefIndex: 4635
{
	// Fields
	private string[] _values; // 0x50

	// Methods

	// RVA: 0x1B17A30 Offset: 0x1B13A30 VA: 0x1B17A30
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B17AE0 Offset: 0x1B13AE0 VA: 0x1B17AE0 Slot: 4
	public override object Aggregate(int[] recordNos, AggregateType kind) { }

	// RVA: 0x1B17DAC Offset: 0x1B13DAC VA: 0x1B17DAC Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B17E24 Offset: 0x1B13E24 VA: 0x1B17E24 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B17EB0 Offset: 0x1B13EB0 VA: 0x1B17EB0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B17ED8 Offset: 0x1B13ED8 VA: 0x1B17ED8 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B17F18 Offset: 0x1B13F18 VA: 0x1B17F18 Slot: 9
	public override object Get(int recordNo) { }

	// RVA: 0x1B17F54 Offset: 0x1B13F54 VA: 0x1B17F54 Slot: 10
	public override int GetStringLength(int record) { }

	// RVA: 0x1B17F94 Offset: 0x1B13F94 VA: 0x1B17F94 Slot: 11
	public override bool IsNull(int record) { }

	// RVA: 0x1B17FCC Offset: 0x1B13FCC VA: 0x1B17FCC Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B18044 Offset: 0x1B14044 VA: 0x1B18044 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B18104 Offset: 0x1B14104 VA: 0x1B18104 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B1810C Offset: 0x1B1410C VA: 0x1B1810C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B18138 Offset: 0x1B14138 VA: 0x1B18138 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B18180 Offset: 0x1B14180 VA: 0x1B18180 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B18288 Offset: 0x1B14288 VA: 0x1B18288 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class TimeSpanStorage : DataStorage // TypeDefIndex: 4636
{
	// Fields
	private static readonly TimeSpan s_defaultValue; // 0x0
	private TimeSpan[] _values; // 0x50

	// Methods

	// RVA: 0x1B18324 Offset: 0x1B14324 VA: 0x1B18324
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B18444 Offset: 0x1B14444 VA: 0x1B18444 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B190C4 Offset: 0x1B150C4 VA: 0x1B190C4 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B19240 Offset: 0x1B15240 VA: 0x1B19240 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B193B4 Offset: 0x1B153B4 VA: 0x1B193B4
	private static TimeSpan ConvertToTimeSpan(object value) { }

	// RVA: 0x1B19558 Offset: 0x1B15558 VA: 0x1B19558 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B19604 Offset: 0x1B15604 VA: 0x1B19604 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B1965C Offset: 0x1B1565C VA: 0x1B1965C Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B1975C Offset: 0x1B1575C VA: 0x1B1975C Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B1983C Offset: 0x1B1583C VA: 0x1B1983C Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B19910 Offset: 0x1B15910 VA: 0x1B19910 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B1999C Offset: 0x1B1599C VA: 0x1B1999C Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B19A34 Offset: 0x1B15A34 VA: 0x1B19A34 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B19A7C Offset: 0x1B15A7C VA: 0x1B19A7C Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B19B7C Offset: 0x1B15B7C VA: 0x1B19B7C Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1B19C40 Offset: 0x1B15C40 VA: 0x1B19C40
	private static void .cctor() { }
}

// Namespace: System.Data.Common
internal sealed class UInt16Storage : DataStorage // TypeDefIndex: 4637
{
	// Fields
	private static readonly ushort s_defaultValue; // 0x0
	private ushort[] _values; // 0x50

	// Methods

	// RVA: 0x1B19CB8 Offset: 0x1B15CB8 VA: 0x1B19CB8
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B19D9C Offset: 0x1B15D9C VA: 0x1B19D9C Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B1A608 Offset: 0x1B16608 VA: 0x1B1A608 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B1A6C0 Offset: 0x1B166C0 VA: 0x1B1A6C0 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B1A7D0 Offset: 0x1B167D0 VA: 0x1B1A7D0 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B1A90C Offset: 0x1B1690C VA: 0x1B1A90C Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B1A964 Offset: 0x1B16964 VA: 0x1B1A964 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B1AA28 Offset: 0x1B16A28 VA: 0x1B1AA28 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B1ABC0 Offset: 0x1B16BC0 VA: 0x1B1ABC0 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B1AC94 Offset: 0x1B16C94 VA: 0x1B1AC94 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B1AD14 Offset: 0x1B16D14 VA: 0x1B1AD14 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B1ADA0 Offset: 0x1B16DA0 VA: 0x1B1ADA0 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B1ADE8 Offset: 0x1B16DE8 VA: 0x1B1ADE8 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B1AEE8 Offset: 0x1B16EE8 VA: 0x1B1AEE8 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class UInt32Storage : DataStorage // TypeDefIndex: 4638
{
	// Fields
	private static readonly uint s_defaultValue; // 0x0
	private uint[] _values; // 0x50

	// Methods

	// RVA: 0x1B1AFAC Offset: 0x1B16FAC VA: 0x1B1AFAC
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B1B090 Offset: 0x1B17090 VA: 0x1B1B090 Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B1B900 Offset: 0x1B17900 VA: 0x1B1B900 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B1B9CC Offset: 0x1B179CC VA: 0x1B1B9CC Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B1BADC Offset: 0x1B17ADC VA: 0x1B1BADC Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B1BC18 Offset: 0x1B17C18 VA: 0x1B1BC18 Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B1BC70 Offset: 0x1B17C70 VA: 0x1B1BC70 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B1BD34 Offset: 0x1B17D34 VA: 0x1B1BD34 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B1BECC Offset: 0x1B17ECC VA: 0x1B1BECC Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B1BFA0 Offset: 0x1B17FA0 VA: 0x1B1BFA0 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B1C020 Offset: 0x1B18020 VA: 0x1B1C020 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B1C0AC Offset: 0x1B180AC VA: 0x1B1C0AC Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B1C0F4 Offset: 0x1B180F4 VA: 0x1B1C0F4 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B1C1F4 Offset: 0x1B181F4 VA: 0x1B1C1F4 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: System.Data.Common
internal sealed class UInt64Storage : DataStorage // TypeDefIndex: 4639
{
	// Fields
	private static readonly ulong s_defaultValue; // 0x0
	private ulong[] _values; // 0x50

	// Methods

	// RVA: 0x1B1C2B8 Offset: 0x1B182B8 VA: 0x1B1C2B8
	public void .ctor(DataColumn column) { }

	// RVA: 0x1B1C39C Offset: 0x1B1839C VA: 0x1B1C39C Slot: 4
	public override object Aggregate(int[] records, AggregateType kind) { }

	// RVA: 0x1B1CC18 Offset: 0x1B18C18 VA: 0x1B1CC18 Slot: 5
	public override int Compare(int recordNo1, int recordNo2) { }

	// RVA: 0x1B1CD20 Offset: 0x1B18D20 VA: 0x1B1CD20 Slot: 6
	public override int CompareValueTo(int recordNo, object value) { }

	// RVA: 0x1B1CE30 Offset: 0x1B18E30 VA: 0x1B1CE30 Slot: 7
	public override object ConvertValue(object value) { }

	// RVA: 0x1B1CF6C Offset: 0x1B18F6C VA: 0x1B1CF6C Slot: 8
	public override void Copy(int recordNo1, int recordNo2) { }

	// RVA: 0x1B1CFC4 Offset: 0x1B18FC4 VA: 0x1B1CFC4 Slot: 9
	public override object Get(int record) { }

	// RVA: 0x1B1D088 Offset: 0x1B19088 VA: 0x1B1D088 Slot: 12
	public override void Set(int record, object value) { }

	// RVA: 0x1B1D220 Offset: 0x1B19220 VA: 0x1B1D220 Slot: 13
	public override void SetCapacity(int capacity) { }

	// RVA: 0x1B1D2F4 Offset: 0x1B192F4 VA: 0x1B1D2F4 Slot: 14
	public override object ConvertXmlToObject(string s) { }

	// RVA: 0x1B1D374 Offset: 0x1B19374 VA: 0x1B1D374 Slot: 16
	public override string ConvertObjectToXml(object value) { }

	// RVA: 0x1B1D400 Offset: 0x1B19400 VA: 0x1B1D400 Slot: 18
	protected override object GetEmptyStorage(int recordCount) { }

	// RVA: 0x1B1D448 Offset: 0x1B19448 VA: 0x1B1D448 Slot: 19
	protected override void CopyValue(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1B1D548 Offset: 0x1B19548 VA: 0x1B1D548 Slot: 20
	protected override void SetStorage(object store, BitArray nullbits) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 // TypeDefIndex: 4640
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 // TypeDefIndex: 4641
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 // TypeDefIndex: 4642
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 4643
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 // TypeDefIndex: 4644
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176 // TypeDefIndex: 4645
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4646
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 39A47A6A540EB845B37C85CE8C346359A0DB937D4AAF7A74A6C207205E0BC61E /*Metadata offset 0x3E6308*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 540CD885F06B2760118EA5544E069ACE0C5D184B85D9D104417C14F1E536376D /*Metadata offset 0x3E63A8*/; // 0x98
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA /*Metadata offset 0x3E63D0*/; // 0xBE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 8D4DC488705859D6A837A660BDBA9E88D1BD229BC39DB97734072D04BD513ECD /*Metadata offset 0x3E6408*/; // 0xF2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 BA1E68F004F9EFDE72987E33682A8A5C579C4A609FBECE4F6EDBB844431D9226 /*Metadata offset 0x3E6430*/; // 0x116
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 C44E90B8C219817ECD3C403823D4770C0F744358EBF32A4282B3CE0338D4602E /*Metadata offset 0x3E64D0*/; // 0x1AE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 D44900CF81FC3D53E7F8D2FCB6EF3B50B39ED1A857628FA737F5B4B7E0382939 /*Metadata offset 0x3E6570*/; // 0x246
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=176 E29424929B12EB1FDF4FD2E4911E09644CB58261C6033211F88022DDED785AE6 /*Metadata offset 0x3E6610*/; // 0x2DE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 F327BBE8D18E0318C5295B25F9A8BA9B3AFE1F44C3C244BB3921AFEB578F1591 /*Metadata offset 0x3E66C8*/; // 0x38E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315 /*Metadata offset 0x3E6710*/; // 0x3CE
}

// Namespace: 
internal class <Module> // TypeDefIndex: 4647
{}
