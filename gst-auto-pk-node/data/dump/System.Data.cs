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

// Namespace: System.Data
[ToolboxItem(False)]
[DesignTimeVisible(False)]
[DefaultProperty("ColumnName")]
[DefaultMember("Item")]
public class DataColumn : MarshalByValueComponent // TypeDefIndex: 4417
{
	// Fields
	private bool _allowNull; // 0x20
	private string _caption; // 0x28
	private string _columnName; // 0x30
	private Type _dataType; // 0x38
	private StorageType _storageType; // 0x40
	internal object _defaultValue; // 0x48
	private DataSetDateTime _dateTimeMode; // 0x50
	private DataExpression _expression; // 0x58
	private int _maxLength; // 0x60
	private int _ordinal; // 0x64
	private bool _readOnly; // 0x68
	internal Index _sortIndex; // 0x70
	internal DataTable _table; // 0x78
	private bool _unique; // 0x80
	internal MappingType _columnMapping; // 0x84
	internal int _hashCode; // 0x88
	internal int _errors; // 0x8C
	private bool _isSqlType; // 0x90
	private bool _implementsINullable; // 0x91
	private bool _implementsIChangeTracking; // 0x92
	private bool _implementsIRevertibleChangeTracking; // 0x93
	private bool _implementsIXMLSerializable; // 0x94
	private bool _defaultValueIsNull; // 0x95
	internal List<DataColumn> _dependentColumns; // 0x98
	internal PropertyCollection _extendedProperties; // 0xA0
	private DataStorage _storage; // 0xA8
	private AutoIncrementValue _autoInc; // 0xB0
	internal string _columnUri; // 0xB8
	private string _columnPrefix; // 0xC0
	internal string _encodedColumnName; // 0xC8
	internal SimpleType _simpleType; // 0xD0
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0xD8
	[CompilerGenerated]
	private string <XmlDataType>k__BackingField; // 0xE0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0xE8

	// Properties
	[DefaultValue(True)]
	public bool AllowDBNull { get; set; }
	[DefaultValue(False)]
	[RefreshProperties(1)]
	public bool AutoIncrement { get; set; }
	internal object AutoIncrementCurrent { get; set; }
	internal AutoIncrementValue AutoInc { get; }
	[DefaultValue(0)]
	public long AutoIncrementSeed { get; set; }
	[DefaultValue(1)]
	public long AutoIncrementStep { get; set; }
	public string Caption { get; set; }
	[DefaultValue("")]
	[RefreshProperties(1)]
	public string ColumnName { get; set; }
	internal string EncodedColumnName { get; }
	internal IFormatProvider FormatProvider { get; }
	internal CultureInfo Locale { get; }
	internal int ObjectID { get; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	internal bool Computed { get; }
	internal DataExpression DataExpression { get; }
	[DefaultValue(typeof(string))]
	[RefreshProperties(1)]
	[TypeConverter(typeof(ColumnTypeConverter))]
	public Type DataType { get; set; }
	[RefreshProperties(1)]
	[DefaultValue(3)]
	public DataSetDateTime DateTimeMode { get; set; }
	[TypeConverter(typeof(DefaultValueTypeConverter))]
	public object DefaultValue { get; set; }
	internal bool DefaultValueIsNull { get; }
	[RefreshProperties(1)]
	[DefaultValue("")]
	public string Expression { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal bool HasData { get; }
	internal bool ImplementsINullable { get; }
	internal bool ImplementsIChangeTracking { get; }
	internal bool ImplementsIRevertibleChangeTracking { get; }
	internal bool IsValueType { get; }
	internal bool IsSqlType { get; }
	[DefaultValue(-1)]
	public int MaxLength { get; set; }
	public string Namespace { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public int Ordinal { get; }
	[DefaultValue(False)]
	public bool ReadOnly { get; set; }
	[DebuggerBrowsable(0)]
	private Index SortIndex { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public DataTable Table { get; }
	internal object Item { get; set; }
	[DefaultValue(False)]
	[DesignerSerializationVisibility(0)]
	public bool Unique { get; set; }
	internal string XmlDataType { get; set; }
	internal SimpleType SimpleType { get; set; }
	[DefaultValue(1)]
	public virtual MappingType ColumnMapping { get; set; }
	internal bool IsCustomType { get; }
	internal bool ImplementsIXMLSerializable { get; }

	// Methods

	// RVA: 0x1A472E4 Offset: 0x1A432E4 VA: 0x1A472E4
	public void .ctor() { }

	// RVA: 0x1A47640 Offset: 0x1A43640 VA: 0x1A47640
	public void .ctor(string columnName, Type dataType) { }

	// RVA: 0x1A4733C Offset: 0x1A4333C VA: 0x1A4733C
	public void .ctor(string columnName, Type dataType, string expr, MappingType type) { }

	// RVA: 0x1A4775C Offset: 0x1A4375C VA: 0x1A4775C
	private void UpdateColumnType(Type type, StorageType typeCode) { }

	// RVA: 0x1A480D0 Offset: 0x1A440D0 VA: 0x1A480D0
	public bool get_AllowDBNull() { }

	// RVA: 0x1A480D8 Offset: 0x1A440D8 VA: 0x1A480D8
	public void set_AllowDBNull(bool value) { }

	// RVA: 0x1A4865C Offset: 0x1A4465C VA: 0x1A4865C
	public bool get_AutoIncrement() { }

	// RVA: 0x1A4867C Offset: 0x1A4467C VA: 0x1A4867C
	public void set_AutoIncrement(bool value) { }

	// RVA: 0x1A49468 Offset: 0x1A45468 VA: 0x1A49468
	internal object get_AutoIncrementCurrent() { }

	// RVA: 0x1A494B8 Offset: 0x1A454B8 VA: 0x1A494B8
	internal void set_AutoIncrementCurrent(object value) { }

	// RVA: 0x1A49370 Offset: 0x1A45370 VA: 0x1A49370
	internal AutoIncrementValue get_AutoInc() { }

	// RVA: 0x1A494A0 Offset: 0x1A454A0 VA: 0x1A494A0
	public long get_AutoIncrementSeed() { }

	// RVA: 0x1A496B4 Offset: 0x1A456B4 VA: 0x1A496B4
	public void set_AutoIncrementSeed(long value) { }

	// RVA: 0x1A497A4 Offset: 0x1A457A4 VA: 0x1A497A4
	public long get_AutoIncrementStep() { }

	// RVA: 0x1A497C0 Offset: 0x1A457C0 VA: 0x1A497C0
	public void set_AutoIncrementStep(long value) { }

	// RVA: 0x1A498B8 Offset: 0x1A458B8 VA: 0x1A498B8
	public string get_Caption() { }

	// RVA: 0x1A498D4 Offset: 0x1A458D4 VA: 0x1A498D4
	public void set_Caption(string value) { }

	// RVA: 0x1A499B4 Offset: 0x1A459B4 VA: 0x1A499B4
	public string get_ColumnName() { }

	// RVA: 0x1A499BC Offset: 0x1A459BC VA: 0x1A499BC
	public void set_ColumnName(string value) { }

	// RVA: 0x1A49DDC Offset: 0x1A45DDC VA: 0x1A49DDC
	internal string get_EncodedColumnName() { }

	// RVA: 0x1A495BC Offset: 0x1A455BC VA: 0x1A495BC
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x1A49948 Offset: 0x1A45948 VA: 0x1A49948
	internal CultureInfo get_Locale() { }

	// RVA: 0x1A49E5C Offset: 0x1A45E5C VA: 0x1A49E5C
	internal int get_ObjectID() { }

	// RVA: 0x1A49E64 Offset: 0x1A45E64 VA: 0x1A49E64
	public string get_Prefix() { }

	// RVA: 0x1A49E6C Offset: 0x1A45E6C VA: 0x1A49E6C
	public void set_Prefix(string value) { }

	// RVA: 0x1A4A010 Offset: 0x1A46010 VA: 0x1A4A010
	internal string GetColumnValueAsString(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A4A130 Offset: 0x1A46130 VA: 0x1A4A130
	internal bool get_Computed() { }

	// RVA: 0x1A4A140 Offset: 0x1A46140 VA: 0x1A4A140
	internal DataExpression get_DataExpression() { }

	// RVA: 0x1A4A148 Offset: 0x1A46148 VA: 0x1A4A148
	public Type get_DataType() { }

	// RVA: 0x1A48B70 Offset: 0x1A44B70 VA: 0x1A48B70
	public void set_DataType(Type value) { }

	// RVA: 0x1A4A8F0 Offset: 0x1A468F0 VA: 0x1A4A8F0
	public DataSetDateTime get_DateTimeMode() { }

	// RVA: 0x1A4A8F8 Offset: 0x1A468F8 VA: 0x1A4A8F8
	public void set_DateTimeMode(DataSetDateTime value) { }

	// RVA: 0x1A4A360 Offset: 0x1A46360 VA: 0x1A4A360
	public object get_DefaultValue() { }

	// RVA: 0x1A4A494 Offset: 0x1A46494 VA: 0x1A4A494
	public void set_DefaultValue(object value) { }

	// RVA: 0x1A4AC40 Offset: 0x1A46C40 VA: 0x1A4AC40
	internal bool get_DefaultValueIsNull() { }

	// RVA: 0x1A4AC48 Offset: 0x1A46C48 VA: 0x1A4AC48
	public string get_Expression() { }

	// RVA: 0x1A47864 Offset: 0x1A43864 VA: 0x1A47864
	public void set_Expression(string value) { }

	// RVA: 0x1A4B0DC Offset: 0x1A470DC VA: 0x1A4B0DC
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x1A48B14 Offset: 0x1A44B14 VA: 0x1A48B14
	internal bool get_HasData() { }

	// RVA: 0x1A4B14C Offset: 0x1A4714C VA: 0x1A4B14C
	internal bool get_ImplementsINullable() { }

	// RVA: 0x1A4B154 Offset: 0x1A47154 VA: 0x1A4B154
	internal bool get_ImplementsIChangeTracking() { }

	// RVA: 0x1A4B15C Offset: 0x1A4715C VA: 0x1A4B15C
	internal bool get_ImplementsIRevertibleChangeTracking() { }

	// RVA: 0x1A4B164 Offset: 0x1A47164 VA: 0x1A4B164
	internal bool get_IsValueType() { }

	// RVA: 0x1A4B17C Offset: 0x1A4717C VA: 0x1A4B17C
	internal bool get_IsSqlType() { }

	// RVA: 0x1A4B184 Offset: 0x1A47184 VA: 0x1A4B184
	private void SetMaxLengthSimpleType() { }

	// RVA: 0x1A4B22C Offset: 0x1A4722C VA: 0x1A4B22C
	public int get_MaxLength() { }

	// RVA: 0x1A4B234 Offset: 0x1A47234 VA: 0x1A4B234
	public void set_MaxLength(int value) { }

	// RVA: 0x1A4B9E4 Offset: 0x1A479E4 VA: 0x1A4B9E4
	public string get_Namespace() { }

	// RVA: 0x1A4BA28 Offset: 0x1A47A28 VA: 0x1A4BA28
	public void set_Namespace(string value) { }

	// RVA: 0x1A4BBC0 Offset: 0x1A47BC0 VA: 0x1A4BBC0
	public int get_Ordinal() { }

	// RVA: 0x1A4BBC8 Offset: 0x1A47BC8 VA: 0x1A4BBC8
	internal void SetOrdinalInternal(int ordinal) { }

	// RVA: 0x1A4BD10 Offset: 0x1A47D10 VA: 0x1A4BD10
	public bool get_ReadOnly() { }

	// RVA: 0x1A4AD5C Offset: 0x1A46D5C VA: 0x1A4AD5C
	public void set_ReadOnly(bool value) { }

	// RVA: 0x1A4BD58 Offset: 0x1A47D58 VA: 0x1A4BD58
	private Index get_SortIndex() { }

	// RVA: 0x1A4BE3C Offset: 0x1A47E3C VA: 0x1A4BE3C
	public DataTable get_Table() { }

	// RVA: 0x1A4BE44 Offset: 0x1A47E44 VA: 0x1A4BE44
	internal void SetTable(DataTable table) { }

	// RVA: 0x1A4BF18 Offset: 0x1A47F18 VA: 0x1A4BF18
	private DataRow GetDataRow(int index) { }

	// RVA: 0x1A4A0D8 Offset: 0x1A460D8 VA: 0x1A4A0D8
	internal object get_Item(int record) { }

	// RVA: 0x1A4BF3C Offset: 0x1A47F3C VA: 0x1A4BF3C
	internal void set_Item(int record, object value) { }

	// RVA: 0x1A4B050 Offset: 0x1A47050 VA: 0x1A4B050
	internal void InitializeRecord(int record) { }

	// RVA: 0x1A4C194 Offset: 0x1A48194 VA: 0x1A4C194
	internal void SetValue(int record, object value) { }

	// RVA: 0x1A4C29C Offset: 0x1A4829C VA: 0x1A4C29C
	internal void FreeRecord(int record) { }

	// RVA: 0x1A4C2BC Offset: 0x1A482BC VA: 0x1A4C2BC
	public bool get_Unique() { }

	// RVA: 0x1A4C2C4 Offset: 0x1A482C4 VA: 0x1A4C2C4
	public void set_Unique(bool value) { }

	// RVA: 0x1A4C79C Offset: 0x1A4879C VA: 0x1A4C79C
	internal void InternalUnique(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1A4C7A4 Offset: 0x1A487A4 VA: 0x1A4C7A4
	internal string get_XmlDataType() { }

	[CompilerGenerated]
	// RVA: 0x1A4C7AC Offset: 0x1A487AC VA: 0x1A4C7AC
	internal void set_XmlDataType(string value) { }

	// RVA: 0x1A4C7B4 Offset: 0x1A487B4 VA: 0x1A4C7B4
	internal SimpleType get_SimpleType() { }

	// RVA: 0x1A47708 Offset: 0x1A43708 VA: 0x1A47708
	internal void set_SimpleType(SimpleType value) { }

	// RVA: 0x1A4C7BC Offset: 0x1A487BC VA: 0x1A4C7BC Slot: 10
	public virtual MappingType get_ColumnMapping() { }

	// RVA: 0x1A4C7C4 Offset: 0x1A487C4 VA: 0x1A4C7C4 Slot: 11
	public virtual void set_ColumnMapping(MappingType value) { }

	// RVA: 0x1A4CAF8 Offset: 0x1A48AF8 VA: 0x1A4CAF8
	internal void CheckColumnConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x1A4B5F4 Offset: 0x1A475F4 VA: 0x1A4B5F4
	internal bool CheckMaxLength() { }

	// RVA: 0x1A4CBC4 Offset: 0x1A48BC4 VA: 0x1A4CBC4
	internal void CheckMaxLength(DataRow dr) { }

	// RVA: 0x1A48254 Offset: 0x1A44254 VA: 0x1A48254
	protected internal void CheckNotAllowNull() { }

	// RVA: 0x1A4CB4C Offset: 0x1A48B4C VA: 0x1A4CB4C
	internal void CheckNullable(DataRow row) { }

	// RVA: 0x1A4C750 Offset: 0x1A48750 VA: 0x1A4C750
	protected void CheckUnique() { }

	// RVA: 0x1A4CD94 Offset: 0x1A48D94 VA: 0x1A4CD94
	internal int Compare(int record1, int record2) { }

	// RVA: 0x1A4CDB0 Offset: 0x1A48DB0 VA: 0x1A4CDB0
	internal bool CompareValueTo(int record1, object value, bool checkType) { }

	// RVA: 0x1A4CF38 Offset: 0x1A48F38 VA: 0x1A4CF38
	internal int CompareValueTo(int record1, object value) { }

	// RVA: 0x1A4CF54 Offset: 0x1A48F54 VA: 0x1A4CF54
	internal object ConvertValue(object value) { }

	// RVA: 0x1A4CF70 Offset: 0x1A48F70 VA: 0x1A4CF70
	internal void Copy(int srcRecordNo, int dstRecordNo) { }

	// RVA: 0x1A4CF8C Offset: 0x1A48F8C VA: 0x1A4CF8C
	internal DataColumn Clone() { }

	// RVA: 0x1A4D578 Offset: 0x1A49578 VA: 0x1A4D578
	internal object GetAggregateValue(int[] records, AggregateType kind) { }

	// RVA: 0x1A4CC40 Offset: 0x1A48C40 VA: 0x1A4CC40
	private int GetStringLength(int record) { }

	// RVA: 0x1A4D630 Offset: 0x1A49630 VA: 0x1A4D630
	internal void Init(int record) { }

	// RVA: 0x1A4888C Offset: 0x1A4488C VA: 0x1A4888C
	internal static bool IsAutoIncrementType(Type dataType) { }

	// RVA: 0x1A4D6BC Offset: 0x1A496BC VA: 0x1A4D6BC
	internal bool get_IsCustomType() { }

	// RVA: 0x1A4D730 Offset: 0x1A49730 VA: 0x1A4D730
	internal bool IsValueCustomTypeInstance(object value) { }

	// RVA: 0x1A4D7F0 Offset: 0x1A497F0 VA: 0x1A4D7F0
	internal bool get_ImplementsIXMLSerializable() { }

	// RVA: 0x1A4A1D0 Offset: 0x1A461D0 VA: 0x1A4A1D0
	internal bool IsInRelation() { }

	// RVA: 0x1A4D7F8 Offset: 0x1A497F8 VA: 0x1A4D7F8
	internal bool IsMaxLengthViolated() { }

	// RVA: 0x1A4DD24 Offset: 0x1A49D24 VA: 0x1A4DD24
	internal bool IsNotAllowDBNullViolated() { }

	// RVA: 0x1A4DE98 Offset: 0x1A49E98 VA: 0x1A4DE98 Slot: 12
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x1A49D68 Offset: 0x1A45D68 VA: 0x1A49D68
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x1A4DEC0 Offset: 0x1A49EC0 VA: 0x1A4DEC0
	private void InsureStorage() { }

	// RVA: 0x1A4DF5C Offset: 0x1A49F5C VA: 0x1A4DF5C
	internal void SetCapacity(int capacity) { }

	// RVA: 0x1A4DF98 Offset: 0x1A49F98 VA: 0x1A4DF98
	internal void OnSetDataSet() { }

	// RVA: 0x1A4DF9C Offset: 0x1A49F9C VA: 0x1A4DF9C Slot: 3
	public override string ToString() { }

	// RVA: 0x1A4E010 Offset: 0x1A4A010 VA: 0x1A4E010
	internal object ConvertXmlToObject(string s) { }

	// RVA: 0x1A4E04C Offset: 0x1A4A04C VA: 0x1A4E04C
	internal object ConvertXmlToObject(XmlReader xmlReader, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1A4A0F4 Offset: 0x1A460F4 VA: 0x1A4A0F4
	internal string ConvertObjectToXml(object value) { }

	// RVA: 0x1A4E090 Offset: 0x1A4A090 VA: 0x1A4E090
	internal void ConvertObjectToXml(object value, XmlWriter xmlWriter, XmlRootAttribute xmlAttrib) { }

	// RVA: 0x1A4E0E4 Offset: 0x1A4A0E4 VA: 0x1A4E0E4
	internal object GetEmptyColumnStore(int recordCount) { }

	// RVA: 0x1A4E118 Offset: 0x1A4A118 VA: 0x1A4E118
	internal void CopyValueIntoStore(int record, object store, BitArray nullbits, int storeIndex) { }

	// RVA: 0x1A4E130 Offset: 0x1A4A130 VA: 0x1A4E130
	internal void SetStorage(object store, BitArray nullbits) { }

	// RVA: 0x1A4E16C Offset: 0x1A4A16C VA: 0x1A4E16C
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x1A4E288 Offset: 0x1A4A288 VA: 0x1A4E288
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x1A4AF18 Offset: 0x1A46F18 VA: 0x1A4AF18
	internal void HandleDependentColumnList(DataExpression oldExpression, DataExpression newExpression) { }
}

// Namespace: System.Data
internal abstract class AutoIncrementValue // TypeDefIndex: 4418
{
	// Fields
	[CompilerGenerated]
	private bool <Auto>k__BackingField; // 0x10

	// Properties
	internal bool Auto { get; set; }
	internal abstract object Current { get; set; }
	internal abstract long Seed { get; set; }
	internal abstract long Step { get; set; }
	internal abstract Type DataType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A4E320 Offset: 0x1A4A320 VA: 0x1A4E320
	internal bool get_Auto() { }

	[CompilerGenerated]
	// RVA: 0x1A4E328 Offset: 0x1A4A328 VA: 0x1A4E328
	internal void set_Auto(bool value) { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract object get_Current();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void set_Current(object value);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract long get_Seed();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract void set_Seed(long value);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract long get_Step();

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract void set_Step(long value);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract Type get_DataType();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract void SetCurrent(object value, IFormatProvider formatProvider);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract void SetCurrentAndIncrement(object value);

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void MoveAfter();

	// RVA: 0x1A4D468 Offset: 0x1A49468 VA: 0x1A4D468
	internal AutoIncrementValue Clone() { }

	// RVA: 0x1A4E330 Offset: 0x1A4A330 VA: 0x1A4E330
	protected void .ctor() { }
}

// Namespace: System.Data
internal sealed class AutoIncrementInt64 : AutoIncrementValue // TypeDefIndex: 4419
{
	// Fields
	private long _current; // 0x18
	private long _seed; // 0x20
	private long _step; // 0x28

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x1A4E338 Offset: 0x1A4A338 VA: 0x1A4E338 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x1A4E360 Offset: 0x1A4A360 VA: 0x1A4E360 Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x1A4E3B4 Offset: 0x1A4A3B4 VA: 0x1A4E3B4 Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x1A4E3E4 Offset: 0x1A4A3E4 VA: 0x1A4E3E4 Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x1A4E3EC Offset: 0x1A4A3EC VA: 0x1A4E3EC Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x1A4E54C Offset: 0x1A4A54C VA: 0x1A4E54C Slot: 8
	internal override long get_Step() { }

	// RVA: 0x1A4E554 Offset: 0x1A4A554 VA: 0x1A4E554 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x1A4E614 Offset: 0x1A4A614 VA: 0x1A4E614 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x1A4E628 Offset: 0x1A4A628 VA: 0x1A4E628 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1A4E69C Offset: 0x1A4A69C VA: 0x1A4E69C Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x1A4E47C Offset: 0x1A4A47C VA: 0x1A4E47C
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x1A49628 Offset: 0x1A45628 VA: 0x1A49628
	public void .ctor() { }
}

// Namespace: System.Data
internal sealed class AutoIncrementBigInteger : AutoIncrementValue // TypeDefIndex: 4420
{
	// Fields
	private BigInteger _current; // 0x18
	private long _seed; // 0x28
	private BigInteger _step; // 0x30

	// Properties
	internal override object Current { get; set; }
	internal override Type DataType { get; }
	internal override long Seed { get; set; }
	internal override long Step { get; set; }

	// Methods

	// RVA: 0x1A4E7D0 Offset: 0x1A4A7D0 VA: 0x1A4E7D0 Slot: 4
	internal override object get_Current() { }

	// RVA: 0x1A4E82C Offset: 0x1A4A82C VA: 0x1A4E82C Slot: 5
	internal override void set_Current(object value) { }

	// RVA: 0x1A4E8AC Offset: 0x1A4A8AC VA: 0x1A4E8AC Slot: 10
	internal override Type get_DataType() { }

	// RVA: 0x1A4E90C Offset: 0x1A4A90C VA: 0x1A4E90C Slot: 6
	internal override long get_Seed() { }

	// RVA: 0x1A4E914 Offset: 0x1A4A914 VA: 0x1A4E914 Slot: 7
	internal override void set_Seed(long value) { }

	// RVA: 0x1A4EB30 Offset: 0x1A4AB30 VA: 0x1A4EB30 Slot: 8
	internal override long get_Step() { }

	// RVA: 0x1A4EB90 Offset: 0x1A4AB90 VA: 0x1A4EB90 Slot: 9
	internal override void set_Step(long value) { }

	// RVA: 0x1A4ED40 Offset: 0x1A4AD40 VA: 0x1A4ED40 Slot: 13
	internal override void MoveAfter() { }

	// RVA: 0x1A4EDD8 Offset: 0x1A4ADD8 VA: 0x1A4EDD8 Slot: 11
	internal override void SetCurrent(object value, IFormatProvider formatProvider) { }

	// RVA: 0x1A4EE0C Offset: 0x1A4AE0C VA: 0x1A4EE0C Slot: 12
	internal override void SetCurrentAndIncrement(object value) { }

	// RVA: 0x1A4EA08 Offset: 0x1A4AA08 VA: 0x1A4EA08
	private bool BoundaryCheck(BigInteger value) { }

	// RVA: 0x1A49638 Offset: 0x1A45638 VA: 0x1A49638
	public void .ctor() { }
}

// Namespace: System.Data
[Serializable]
public class DataException : SystemException // TypeDefIndex: 4421
{
	// Methods

	// RVA: 0x1A4EEEC Offset: 0x1A4AEEC VA: 0x1A4EEEC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A4EEF4 Offset: 0x1A4AEF4 VA: 0x1A4EEF4
	public void .ctor() { }

	// RVA: 0x1A4EF50 Offset: 0x1A4AF50 VA: 0x1A4EF50
	public void .ctor(string s) { }

	// RVA: 0x1A4EF74 Offset: 0x1A4AF74 VA: 0x1A4EF74
	public void .ctor(string s, Exception innerException) { }
}

// Namespace: System.Data
[Serializable]
public class ConstraintException : DataException // TypeDefIndex: 4422
{
	// Methods

	// RVA: 0x1A4EF7C Offset: 0x1A4AF7C VA: 0x1A4EF7C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A4EF84 Offset: 0x1A4AF84 VA: 0x1A4EF84
	public void .ctor() { }

	// RVA: 0x1A4EFE0 Offset: 0x1A4AFE0 VA: 0x1A4EFE0
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class DeletedRowInaccessibleException : DataException // TypeDefIndex: 4423
{
	// Methods

	// RVA: 0x1A4F004 Offset: 0x1A4B004 VA: 0x1A4F004
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A4F00C Offset: 0x1A4B00C VA: 0x1A4F00C
	public void .ctor() { }

	// RVA: 0x1A4F068 Offset: 0x1A4B068 VA: 0x1A4F068
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class DuplicateNameException : DataException // TypeDefIndex: 4424
{
	// Methods

	// RVA: 0x1A4F08C Offset: 0x1A4B08C VA: 0x1A4F08C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A4F094 Offset: 0x1A4B094 VA: 0x1A4F094
	public void .ctor() { }

	// RVA: 0x1A4F0F0 Offset: 0x1A4B0F0 VA: 0x1A4F0F0
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class InRowChangingEventException : DataException // TypeDefIndex: 4425
{
	// Methods

	// RVA: 0x1A4F114 Offset: 0x1A4B114 VA: 0x1A4F114
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A4F11C Offset: 0x1A4B11C VA: 0x1A4F11C
	public void .ctor() { }

	// RVA: 0x1A4F178 Offset: 0x1A4B178 VA: 0x1A4F178
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class InvalidConstraintException : DataException // TypeDefIndex: 4426
{
	// Methods

	// RVA: 0x1A4F19C Offset: 0x1A4B19C VA: 0x1A4F19C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A4F1A4 Offset: 0x1A4B1A4 VA: 0x1A4F1A4
	public void .ctor() { }

	// RVA: 0x1A4F200 Offset: 0x1A4B200 VA: 0x1A4F200
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class NoNullAllowedException : DataException // TypeDefIndex: 4427
{
	// Methods

	// RVA: 0x1A4F224 Offset: 0x1A4B224 VA: 0x1A4F224
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A4F22C Offset: 0x1A4B22C VA: 0x1A4F22C
	public void .ctor() { }

	// RVA: 0x1A4F288 Offset: 0x1A4B288 VA: 0x1A4F288
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class ReadOnlyException : DataException // TypeDefIndex: 4428
{
	// Methods

	// RVA: 0x1A4F2AC Offset: 0x1A4B2AC VA: 0x1A4F2AC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A4F2B4 Offset: 0x1A4B2B4 VA: 0x1A4F2B4
	public void .ctor() { }

	// RVA: 0x1A4F310 Offset: 0x1A4B310 VA: 0x1A4F310
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class RowNotInTableException : DataException // TypeDefIndex: 4429
{
	// Methods

	// RVA: 0x1A4F334 Offset: 0x1A4B334 VA: 0x1A4F334
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A4F33C Offset: 0x1A4B33C VA: 0x1A4F33C
	public void .ctor() { }

	// RVA: 0x1A4F398 Offset: 0x1A4B398 VA: 0x1A4F398
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class VersionNotFoundException : DataException // TypeDefIndex: 4430
{
	// Methods

	// RVA: 0x1A4F3BC Offset: 0x1A4B3BC VA: 0x1A4F3BC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A4F3C4 Offset: 0x1A4B3C4 VA: 0x1A4F3C4
	public void .ctor() { }

	// RVA: 0x1A4F420 Offset: 0x1A4B420 VA: 0x1A4F420
	public void .ctor(string s) { }
}

// Namespace: System.Data
internal static class ExceptionBuilder // TypeDefIndex: 4431
{
	// Methods

	// RVA: 0x1A4F444 Offset: 0x1A4B444 VA: 0x1A4F444
	private static void TraceException(string trace, Exception e) { }

	// RVA: 0x1A4F4DC Offset: 0x1A4B4DC VA: 0x1A4F4DC
	internal static Exception TraceExceptionAsReturnValue(Exception e) { }

	// RVA: 0x1A4AE48 Offset: 0x1A46E48 VA: 0x1A4AE48
	internal static Exception TraceExceptionForCapture(Exception e) { }

	// RVA: 0x1A4B08C Offset: 0x1A4708C VA: 0x1A4B08C
	internal static Exception TraceExceptionWithoutRethrow(Exception e) { }

	// RVA: 0x1A4F52C Offset: 0x1A4B52C VA: 0x1A4F52C
	internal static Exception _Argument(string error) { }

	// RVA: 0x1A4F588 Offset: 0x1A4B588 VA: 0x1A4F588
	internal static Exception _Argument(string error, Exception innerException) { }

	// RVA: 0x1A4F5F4 Offset: 0x1A4B5F4 VA: 0x1A4F5F4
	private static Exception _ArgumentNull(string paramName, string msg) { }

	// RVA: 0x1A4F660 Offset: 0x1A4B660 VA: 0x1A4F660
	internal static Exception _ArgumentOutOfRange(string paramName, string msg) { }

	// RVA: 0x1A4F6CC Offset: 0x1A4B6CC VA: 0x1A4F6CC
	private static Exception _IndexOutOfRange(string error) { }

	// RVA: 0x1A4F728 Offset: 0x1A4B728 VA: 0x1A4F728
	private static Exception _InvalidOperation(string error) { }

	// RVA: 0x1A4F784 Offset: 0x1A4B784 VA: 0x1A4F784
	private static Exception _InvalidEnumArgumentException(string error) { }

	// RVA: -1 Offset: -1
	private static Exception _InvalidEnumArgumentException<T>(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110C8D4 Offset: 0x11088D4 VA: 0x110C8D4
	|-ExceptionBuilder._InvalidEnumArgumentException<Int32Enum>
	|
	|-RVA: 0x110C9C0 Offset: 0x11089C0 VA: 0x110C9C0
	|-ExceptionBuilder._InvalidEnumArgumentException<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A4F7E0 Offset: 0x1A4B7E0 VA: 0x1A4F7E0
	private static void ThrowDataException(string error, Exception innerException) { }

	// RVA: 0x1A4F830 Offset: 0x1A4B830 VA: 0x1A4F830
	private static Exception _Data(string error) { }

	// RVA: 0x1A4F898 Offset: 0x1A4B898 VA: 0x1A4F898
	private static Exception _Constraint(string error) { }

	// RVA: 0x1A4F900 Offset: 0x1A4B900 VA: 0x1A4F900
	private static Exception _InvalidConstraint(string error) { }

	// RVA: 0x1A4F968 Offset: 0x1A4B968 VA: 0x1A4F968
	private static Exception _DeletedRowInaccessible(string error) { }

	// RVA: 0x1A4F9D0 Offset: 0x1A4B9D0 VA: 0x1A4F9D0
	private static Exception _DuplicateName(string error) { }

	// RVA: 0x1A4FA38 Offset: 0x1A4BA38 VA: 0x1A4FA38
	private static Exception _InRowChangingEvent(string error) { }

	// RVA: 0x1A4FAA0 Offset: 0x1A4BAA0 VA: 0x1A4FAA0
	private static Exception _NoNullAllowed(string error) { }

	// RVA: 0x1A4FB08 Offset: 0x1A4BB08 VA: 0x1A4FB08
	private static Exception _ReadOnly(string error) { }

	// RVA: 0x1A4FB70 Offset: 0x1A4BB70 VA: 0x1A4FB70
	private static Exception _RowNotInTable(string error) { }

	// RVA: 0x1A4FBD8 Offset: 0x1A4BBD8 VA: 0x1A4FBD8
	private static Exception _VersionNotFound(string error) { }

	// RVA: 0x1A4764C Offset: 0x1A4364C VA: 0x1A4764C
	public static Exception ArgumentNull(string paramName) { }

	// RVA: 0x1A4FC40 Offset: 0x1A4BC40 VA: 0x1A4FC40
	public static Exception ArgumentOutOfRange(string paramName) { }

	// RVA: 0x1A4FC94 Offset: 0x1A4BC94 VA: 0x1A4FC94
	public static Exception BadObjectPropertyAccess(string error) { }

	// RVA: 0x1A4FCE0 Offset: 0x1A4BCE0 VA: 0x1A4FCE0
	public static Exception TypeNotAllowed(Type type) { }

	// RVA: 0x1A4FD4C Offset: 0x1A4BD4C VA: 0x1A4FD4C
	public static Exception CaseInsensitiveNameConflict(string name) { }

	// RVA: 0x1A4FD98 Offset: 0x1A4BD98 VA: 0x1A4FD98
	public static Exception NamespaceNameConflict(string name) { }

	// RVA: 0x1A4FDE4 Offset: 0x1A4BDE4 VA: 0x1A4FDE4
	public static Exception InvalidOffsetLength() { }

	// RVA: 0x1A4FE24 Offset: 0x1A4BE24 VA: 0x1A4FE24
	public static Exception ColumnNotInTheTable(string column, string table) { }

	// RVA: 0x1A4FE80 Offset: 0x1A4BE80 VA: 0x1A4FE80
	public static Exception ColumnNotInAnyTable() { }

	// RVA: 0x1A4FEC0 Offset: 0x1A4BEC0 VA: 0x1A4FEC0
	public static Exception ColumnOutOfRange(int index) { }

	// RVA: 0x1A4FF50 Offset: 0x1A4BF50 VA: 0x1A4FF50
	public static Exception ColumnOutOfRange(string column) { }

	// RVA: 0x1A4FF9C Offset: 0x1A4BF9C VA: 0x1A4FF9C
	public static Exception CannotAddColumn1(string column) { }

	// RVA: 0x1A4FFE8 Offset: 0x1A4BFE8 VA: 0x1A4FFE8
	public static Exception CannotAddColumn2(string column) { }

	// RVA: 0x1A4CA6C Offset: 0x1A48A6C VA: 0x1A4CA6C
	public static Exception CannotAddColumn3() { }

	// RVA: 0x1A4CAAC Offset: 0x1A48AAC VA: 0x1A4CAAC
	public static Exception CannotAddColumn4(string column) { }

	// RVA: 0x1A50034 Offset: 0x1A4C034 VA: 0x1A50034
	public static Exception CannotAddDuplicate(string column) { }

	// RVA: 0x1A50080 Offset: 0x1A4C080 VA: 0x1A50080
	public static Exception CannotAddDuplicate2(string table) { }

	// RVA: 0x1A500CC Offset: 0x1A4C0CC VA: 0x1A500CC
	public static Exception CannotAddDuplicate3(string table) { }

	// RVA: 0x1A50118 Offset: 0x1A4C118 VA: 0x1A50118
	public static Exception CannotRemoveColumn() { }

	// RVA: 0x1A50158 Offset: 0x1A4C158 VA: 0x1A50158
	public static Exception CannotRemovePrimaryKey() { }

	// RVA: 0x1A50198 Offset: 0x1A4C198 VA: 0x1A50198
	public static Exception CannotRemoveChildKey(string relation) { }

	// RVA: 0x1A501E4 Offset: 0x1A4C1E4 VA: 0x1A501E4
	public static Exception CannotRemoveConstraint(string constraint, string table) { }

	// RVA: 0x1A50240 Offset: 0x1A4C240 VA: 0x1A50240
	public static Exception CannotRemoveExpression(string column, string expression) { }

	// RVA: 0x1A5029C Offset: 0x1A4C29C VA: 0x1A5029C
	public static Exception AddPrimaryKeyConstraint() { }

	// RVA: 0x1A502DC Offset: 0x1A4C2DC VA: 0x1A502DC
	public static Exception NoConstraintName() { }

	// RVA: 0x1A5031C Offset: 0x1A4C31C VA: 0x1A5031C
	public static Exception ConstraintViolation(string constraint) { }

	// RVA: 0x1A50368 Offset: 0x1A4C368 VA: 0x1A50368
	public static string KeysToString(object[] keys) { }

	// RVA: 0x1A50480 Offset: 0x1A4C480 VA: 0x1A50480
	public static string UniqueConstraintViolationText(DataColumn[] columns, object[] values) { }

	// RVA: 0x1A505F0 Offset: 0x1A4C5F0 VA: 0x1A505F0
	public static Exception ConstraintViolation(DataColumn[] columns, object[] values) { }

	// RVA: 0x1A50600 Offset: 0x1A4C600 VA: 0x1A50600
	public static Exception ConstraintOutOfRange(int index) { }

	// RVA: 0x1A50690 Offset: 0x1A4C690 VA: 0x1A50690
	public static Exception DuplicateConstraint(string constraint) { }

	// RVA: 0x1A506DC Offset: 0x1A4C6DC VA: 0x1A506DC
	public static Exception DuplicateConstraintName(string constraint) { }

	// RVA: 0x1A50728 Offset: 0x1A4C728 VA: 0x1A50728
	public static Exception NeededForForeignKeyConstraint(UniqueConstraint key, ForeignKeyConstraint fk) { }

	// RVA: 0x1A507B0 Offset: 0x1A4C7B0 VA: 0x1A507B0
	public static Exception UniqueConstraintViolation() { }

	// RVA: 0x1A507F0 Offset: 0x1A4C7F0 VA: 0x1A507F0
	public static Exception ConstraintForeignTable() { }

	// RVA: 0x1A50830 Offset: 0x1A4C830 VA: 0x1A50830
	public static Exception ConstraintParentValues() { }

	// RVA: 0x1A50870 Offset: 0x1A4C870 VA: 0x1A50870
	public static Exception ConstraintAddFailed(DataTable table) { }

	// RVA: 0x1A508C4 Offset: 0x1A4C8C4 VA: 0x1A508C4
	public static Exception ConstraintRemoveFailed() { }

	// RVA: 0x1A50904 Offset: 0x1A4C904 VA: 0x1A50904
	public static Exception FailedCascadeDelete(string constraint) { }

	// RVA: 0x1A50950 Offset: 0x1A4C950 VA: 0x1A50950
	public static Exception FailedCascadeUpdate(string constraint) { }

	// RVA: 0x1A5099C Offset: 0x1A4C99C VA: 0x1A5099C
	public static Exception FailedClearParentTable(string table, string constraint, string childTable) { }

	// RVA: 0x1A50A00 Offset: 0x1A4CA00 VA: 0x1A50A00
	public static Exception ForeignKeyViolation(string constraint, object[] keys) { }

	// RVA: 0x1A50A68 Offset: 0x1A4CA68 VA: 0x1A50A68
	public static Exception RemoveParentRow(ForeignKeyConstraint constraint) { }

	// RVA: 0x1A4DCDC Offset: 0x1A49CDC VA: 0x1A4DCDC
	public static string MaxLengthViolationText(string columnName) { }

	// RVA: 0x1A4DE50 Offset: 0x1A49E50 VA: 0x1A4DE50
	public static string NotAllowDBNullViolationText(string columnName) { }

	// RVA: 0x1A50AD0 Offset: 0x1A4CAD0 VA: 0x1A50AD0
	public static Exception CantAddConstraintToMultipleNestedTable(string tableName) { }

	// RVA: 0x1A4880C Offset: 0x1A4480C VA: 0x1A4880C
	public static Exception AutoIncrementAndExpression() { }

	// RVA: 0x1A4884C Offset: 0x1A4484C VA: 0x1A4884C
	public static Exception AutoIncrementAndDefaultValue() { }

	// RVA: 0x1A4E5D4 Offset: 0x1A4A5D4 VA: 0x1A4E5D4
	public static Exception AutoIncrementSeed() { }

	// RVA: 0x1A4A150 Offset: 0x1A46150 VA: 0x1A4A150
	public static Exception CantChangeDataType() { }

	// RVA: 0x1A4A190 Offset: 0x1A46190 VA: 0x1A4A190
	public static Exception NullDataType() { }

	// RVA: 0x1A49D28 Offset: 0x1A45D28 VA: 0x1A49D28
	public static Exception ColumnNameRequired() { }

	// RVA: 0x1A4AB58 Offset: 0x1A46B58 VA: 0x1A4AB58
	public static Exception DefaultValueAndAutoIncrement() { }

	// RVA: 0x1A4A780 Offset: 0x1A46780 VA: 0x1A4A780
	public static Exception DefaultValueDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x1A4AB98 Offset: 0x1A46B98 VA: 0x1A4AB98
	public static Exception DefaultValueColumnDataType(string column, Type defaultType, Type columnType, Exception inner) { }

	// RVA: 0x1A4ACA4 Offset: 0x1A46CA4 VA: 0x1A4ACA4
	public static Exception ExpressionAndUnique() { }

	// RVA: 0x1A4AE98 Offset: 0x1A46E98 VA: 0x1A4AE98
	public static Exception ExpressionAndReadOnly() { }

	// RVA: 0x1A4ACE4 Offset: 0x1A46CE4 VA: 0x1A4ACE4
	public static Exception ExpressionAndConstraint(DataColumn column, Constraint constraint) { }

	// RVA: 0x1A50B1C Offset: 0x1A4CB1C VA: 0x1A50B1C
	public static Exception ExpressionInConstraint(DataColumn column) { }

	// RVA: 0x1A4AED8 Offset: 0x1A46ED8 VA: 0x1A4AED8
	public static Exception ExpressionCircular() { }

	// RVA: 0x1A4CD48 Offset: 0x1A48D48 VA: 0x1A4CD48
	public static Exception NonUniqueValues(string column) { }

	// RVA: 0x1A4CCB0 Offset: 0x1A48CB0 VA: 0x1A4CCB0
	public static Exception NullKeyValues(string column) { }

	// RVA: 0x1A4CCFC Offset: 0x1A48CFC VA: 0x1A4CCFC
	public static Exception NullValues(string column) { }

	// RVA: 0x1A4BD18 Offset: 0x1A47D18 VA: 0x1A4BD18
	public static Exception ReadOnlyAndExpression() { }

	// RVA: 0x1A50B70 Offset: 0x1A4CB70 VA: 0x1A50B70
	public static Exception ReadOnly(string column) { }

	// RVA: 0x1A4C710 Offset: 0x1A48710 VA: 0x1A4C710
	public static Exception UniqueAndExpression() { }

	// RVA: 0x1A4C0BC Offset: 0x1A480BC VA: 0x1A4C0BC
	public static Exception SetFailed(object value, DataColumn column, Type type, Exception innerException) { }

	// RVA: 0x1A50BBC Offset: 0x1A4CBBC VA: 0x1A50BBC
	public static Exception CannotSetToNull(DataColumn column) { }

	// RVA: 0x1A4CC5C Offset: 0x1A48C5C VA: 0x1A4CC5C
	public static Exception LongerThanMaxLength(DataColumn column) { }

	// RVA: 0x1A4B940 Offset: 0x1A47940 VA: 0x1A4B940
	public static Exception CannotSetMaxLength(DataColumn column, int value) { }

	// RVA: 0x1A4B54C Offset: 0x1A4754C VA: 0x1A4B54C
	public static Exception CannotSetMaxLength2(DataColumn column) { }

	// RVA: 0x1A4A894 Offset: 0x1A46894 VA: 0x1A4A894
	public static Exception CannotSetSimpleContentType(string columnName, Type type) { }

	// RVA: 0x1A4CA10 Offset: 0x1A48A10 VA: 0x1A4CA10
	public static Exception CannotSetSimpleContent(string columnName, Type type) { }

	// RVA: 0x1A4BB74 Offset: 0x1A47B74 VA: 0x1A4BB74
	public static Exception CannotChangeNamespace(string columnName) { }

	// RVA: 0x1A4B5A0 Offset: 0x1A475A0 VA: 0x1A4B5A0
	public static Exception HasToBeStringType(DataColumn column) { }

	// RVA: 0x1A48B24 Offset: 0x1A44B24 VA: 0x1A48B24
	public static Exception AutoIncrementCannotSetIfHasData(string typeName) { }

	// RVA: 0x1A50C10 Offset: 0x1A4CC10 VA: 0x1A50C10
	public static Exception INullableUDTwithoutStaticNull(string typeName) { }

	// RVA: 0x1A50C5C Offset: 0x1A4CC5C VA: 0x1A50C5C
	public static Exception IComparableNotImplemented(string typeName) { }

	// RVA: 0x1A50CA8 Offset: 0x1A4CCA8 VA: 0x1A50CA8
	public static Exception UDTImplementsIChangeTrackingButnotIRevertible(string typeName) { }

	// RVA: 0x1A50CF4 Offset: 0x1A4CCF4 VA: 0x1A50CF4
	public static Exception InvalidDataColumnMapping(Type type) { }

	// RVA: 0x1A4AA18 Offset: 0x1A46A18 VA: 0x1A4AA18
	public static Exception CannotSetDateTimeModeForNonDateTimeColumns() { }

	// RVA: 0x1A4AB10 Offset: 0x1A46B10 VA: 0x1A4AB10
	public static Exception InvalidDateTimeMode(DataSetDateTime mode) { }

	// RVA: 0x1A4AA58 Offset: 0x1A46A58 VA: 0x1A4AA58
	public static Exception CantChangeDateTimeMode(DataSetDateTime oldValue, DataSetDateTime newValue) { }

	// RVA: 0x1A476A0 Offset: 0x1A436A0 VA: 0x1A476A0
	public static Exception ColumnTypeNotSupported() { }

	// RVA: 0x1A50D60 Offset: 0x1A4CD60 VA: 0x1A50D60
	public static Exception SetFailed(string name) { }

	// RVA: 0x1A50DAC Offset: 0x1A4CDAC VA: 0x1A50DAC
	public static Exception CanNotUse() { }

	// RVA: 0x1A50DEC Offset: 0x1A4CDEC VA: 0x1A50DEC
	public static Exception SetIListObject() { }

	// RVA: 0x1A50E2C Offset: 0x1A4CE2C VA: 0x1A50E2C
	public static Exception AddNewNotAllowNull() { }

	// RVA: 0x1A50E6C Offset: 0x1A4CE6C VA: 0x1A50E6C
	public static Exception NotOpen() { }

	// RVA: 0x1A50EAC Offset: 0x1A4CEAC VA: 0x1A50EAC
	public static Exception CreateChildView() { }

	// RVA: 0x1A50EEC Offset: 0x1A4CEEC VA: 0x1A50EEC
	public static Exception CanNotDelete() { }

	// RVA: 0x1A50F2C Offset: 0x1A4CF2C VA: 0x1A50F2C
	public static Exception GetElementIndex(int index) { }

	// RVA: 0x1A50FBC Offset: 0x1A4CFBC VA: 0x1A50FBC
	public static Exception AddExternalObject() { }

	// RVA: 0x1A50FFC Offset: 0x1A4CFFC VA: 0x1A50FFC
	public static Exception CanNotClear() { }

	// RVA: 0x1A5103C Offset: 0x1A4D03C VA: 0x1A5103C
	public static Exception InsertExternalObject() { }

	// RVA: 0x1A5107C Offset: 0x1A4D07C VA: 0x1A5107C
	public static Exception RemoveExternalObject() { }

	// RVA: 0x1A510BC Offset: 0x1A4D0BC VA: 0x1A510BC
	public static Exception KeyTableMismatch() { }

	// RVA: 0x1A510FC Offset: 0x1A4D0FC VA: 0x1A510FC
	public static Exception KeyNoColumns() { }

	// RVA: 0x1A5113C Offset: 0x1A4D13C VA: 0x1A5113C
	public static Exception KeyTooManyColumns(int cols) { }

	// RVA: 0x1A511CC Offset: 0x1A4D1CC VA: 0x1A511CC
	public static Exception KeyDuplicateColumns(string columnName) { }

	// RVA: 0x1A51218 Offset: 0x1A4D218 VA: 0x1A51218
	public static Exception RelationDataSetMismatch() { }

	// RVA: 0x1A4A320 Offset: 0x1A46320 VA: 0x1A4A320
	public static Exception ColumnsTypeMismatch() { }

	// RVA: 0x1A51258 Offset: 0x1A4D258 VA: 0x1A51258
	public static Exception KeyLengthMismatch() { }

	// RVA: 0x1A51298 Offset: 0x1A4D298 VA: 0x1A51298
	public static Exception KeyLengthZero() { }

	// RVA: 0x1A512D8 Offset: 0x1A4D2D8 VA: 0x1A512D8
	public static Exception ForeignRelation() { }

	// RVA: 0x1A51318 Offset: 0x1A4D318 VA: 0x1A51318
	public static Exception KeyColumnsIdentical() { }

	// RVA: 0x1A51358 Offset: 0x1A4D358 VA: 0x1A51358
	public static Exception RelationForeignTable(string t1, string t2) { }

	// RVA: 0x1A513B4 Offset: 0x1A4D3B4 VA: 0x1A513B4
	public static Exception GetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x1A51410 Offset: 0x1A4D410 VA: 0x1A51410
	public static Exception SetParentRowTableMismatch(string t1, string t2) { }

	// RVA: 0x1A5146C Offset: 0x1A4D46C VA: 0x1A5146C
	public static Exception RelationForeignRow() { }

	// RVA: 0x1A514AC Offset: 0x1A4D4AC VA: 0x1A514AC
	public static Exception RelationNestedReadOnly() { }

	// RVA: 0x1A514EC Offset: 0x1A4D4EC VA: 0x1A514EC
	public static Exception TableCantBeNestedInTwoTables(string tableName) { }

	// RVA: 0x1A51538 Offset: 0x1A4D538 VA: 0x1A51538
	public static Exception LoopInNestedRelations(string tableName) { }

	// RVA: 0x1A51584 Offset: 0x1A4D584 VA: 0x1A51584
	public static Exception RelationDoesNotExist() { }

	// RVA: 0x1A515C4 Offset: 0x1A4D5C4 VA: 0x1A515C4
	public static Exception ParentOrChildColumnsDoNotHaveDataSet() { }

	// RVA: 0x1A51604 Offset: 0x1A4D604 VA: 0x1A51604
	public static Exception InValidNestedRelation(string childTableName) { }

	// RVA: 0x1A51650 Offset: 0x1A4D650 VA: 0x1A51650
	public static Exception InvalidParentNamespaceinNestedRelation(string childTableName) { }

	// RVA: 0x1A5169C Offset: 0x1A4D69C VA: 0x1A5169C
	public static Exception RowNotInTheDataSet() { }

	// RVA: 0x1A516DC Offset: 0x1A4D6DC VA: 0x1A516DC
	public static Exception RowNotInTheTable() { }

	// RVA: 0x1A5171C Offset: 0x1A4D71C VA: 0x1A5171C
	public static Exception EditInRowChanging() { }

	// RVA: 0x1A5175C Offset: 0x1A4D75C VA: 0x1A5175C
	public static Exception EndEditInRowChanging() { }

	// RVA: 0x1A5179C Offset: 0x1A4D79C VA: 0x1A5179C
	public static Exception BeginEditInRowChanging() { }

	// RVA: 0x1A517DC Offset: 0x1A4D7DC VA: 0x1A517DC
	public static Exception CancelEditInRowChanging() { }

	// RVA: 0x1A5181C Offset: 0x1A4D81C VA: 0x1A5181C
	public static Exception DeleteInRowDeleting() { }

	// RVA: 0x1A5185C Offset: 0x1A4D85C VA: 0x1A5185C
	public static Exception ValueArrayLength() { }

	// RVA: 0x1A5189C Offset: 0x1A4D89C VA: 0x1A5189C
	public static Exception NoCurrentData() { }

	// RVA: 0x1A518DC Offset: 0x1A4D8DC VA: 0x1A518DC
	public static Exception NoOriginalData() { }

	// RVA: 0x1A5191C Offset: 0x1A4D91C VA: 0x1A5191C
	public static Exception NoProposedData() { }

	// RVA: 0x1A5195C Offset: 0x1A4D95C VA: 0x1A5195C
	public static Exception RowRemovedFromTheTable() { }

	// RVA: 0x1A5199C Offset: 0x1A4D99C VA: 0x1A5199C
	public static Exception DeletedRowInaccessible() { }

	// RVA: 0x1A519DC Offset: 0x1A4D9DC VA: 0x1A519DC
	public static Exception RowAlreadyDeleted() { }

	// RVA: 0x1A51A1C Offset: 0x1A4DA1C VA: 0x1A51A1C
	public static Exception RowEmpty() { }

	// RVA: 0x1A51A5C Offset: 0x1A4DA5C VA: 0x1A51A5C
	public static Exception InvalidRowVersion() { }

	// RVA: 0x1A51A9C Offset: 0x1A4DA9C VA: 0x1A51A9C
	public static Exception RowOutOfRange(int index) { }

	// RVA: 0x1A51B2C Offset: 0x1A4DB2C VA: 0x1A51B2C
	public static Exception RowInsertTwice(int index, string tableName) { }

	// RVA: 0x1A51BCC Offset: 0x1A4DBCC VA: 0x1A51BCC
	public static Exception RowInsertMissing(string tableName) { }

	// RVA: 0x1A51C18 Offset: 0x1A4DC18 VA: 0x1A51C18
	public static Exception RowAlreadyRemoved() { }

	// RVA: 0x1A51C58 Offset: 0x1A4DC58 VA: 0x1A51C58
	public static Exception MultipleParents() { }

	// RVA: 0x1A51C98 Offset: 0x1A4DC98 VA: 0x1A51C98
	public static Exception InvalidRowState(DataRowState state) { }

	// RVA: 0x1A51CE0 Offset: 0x1A4DCE0 VA: 0x1A51CE0
	public static Exception InvalidRowBitPattern() { }

	// RVA: 0x1A51D20 Offset: 0x1A4DD20 VA: 0x1A51D20
	internal static Exception SetDataSetNameToEmpty() { }

	// RVA: 0x1A51D60 Offset: 0x1A4DD60 VA: 0x1A51D60
	internal static Exception SetDataSetNameConflicting(string name) { }

	// RVA: 0x1A51DAC Offset: 0x1A4DDAC VA: 0x1A51DAC
	public static Exception DataSetUnsupportedSchema(string ns) { }

	// RVA: 0x1A51DF8 Offset: 0x1A4DDF8 VA: 0x1A51DF8
	public static Exception MergeMissingDefinition(string obj) { }

	// RVA: 0x1A51E44 Offset: 0x1A4DE44 VA: 0x1A51E44
	public static Exception TablesInDifferentSets() { }

	// RVA: 0x1A51E84 Offset: 0x1A4DE84 VA: 0x1A51E84
	public static Exception RelationAlreadyExists() { }

	// RVA: 0x1A51EC4 Offset: 0x1A4DEC4 VA: 0x1A51EC4
	public static Exception RowAlreadyInOtherCollection() { }

	// RVA: 0x1A51F04 Offset: 0x1A4DF04 VA: 0x1A51F04
	public static Exception RowAlreadyInTheCollection() { }

	// RVA: 0x1A51F44 Offset: 0x1A4DF44 VA: 0x1A51F44
	public static Exception RecordStateRange() { }

	// RVA: 0x1A51F84 Offset: 0x1A4DF84 VA: 0x1A51F84
	public static Exception IndexKeyLength(int length, int keyLength) { }

	// RVA: 0x1A52060 Offset: 0x1A4E060 VA: 0x1A52060
	public static Exception RemovePrimaryKey(DataTable table) { }

	// RVA: 0x1A520DC Offset: 0x1A4E0DC VA: 0x1A520DC
	public static Exception RelationAlreadyInOtherDataSet() { }

	// RVA: 0x1A5211C Offset: 0x1A4E11C VA: 0x1A5211C
	public static Exception RelationAlreadyInTheDataSet() { }

	// RVA: 0x1A5215C Offset: 0x1A4E15C VA: 0x1A5215C
	public static Exception RelationNotInTheDataSet(string relation) { }

	// RVA: 0x1A521A8 Offset: 0x1A4E1A8 VA: 0x1A521A8
	public static Exception RelationOutOfRange(object index) { }

	// RVA: 0x1A5222C Offset: 0x1A4E22C VA: 0x1A5222C
	public static Exception DuplicateRelation(string relation) { }

	// RVA: 0x1A52278 Offset: 0x1A4E278 VA: 0x1A52278
	public static Exception RelationTableNull() { }

	// RVA: 0x1A522B8 Offset: 0x1A4E2B8 VA: 0x1A522B8
	public static Exception RelationDataSetNull() { }

	// RVA: 0x1A522F8 Offset: 0x1A4E2F8 VA: 0x1A522F8
	public static Exception RelationTableWasRemoved() { }

	// RVA: 0x1A52338 Offset: 0x1A4E338 VA: 0x1A52338
	public static Exception ParentTableMismatch() { }

	// RVA: 0x1A52378 Offset: 0x1A4E378 VA: 0x1A52378
	public static Exception ChildTableMismatch() { }

	// RVA: 0x1A523B8 Offset: 0x1A4E3B8 VA: 0x1A523B8
	public static Exception EnforceConstraint() { }

	// RVA: 0x1A523F8 Offset: 0x1A4E3F8 VA: 0x1A523F8
	public static Exception CaseLocaleMismatch() { }

	// RVA: 0x1A52438 Offset: 0x1A4E438 VA: 0x1A52438
	public static Exception CannotChangeCaseLocale() { }

	// RVA: 0x1A52440 Offset: 0x1A4E440 VA: 0x1A52440
	public static Exception CannotChangeCaseLocale(Exception innerException) { }

	// RVA: 0x1A52488 Offset: 0x1A4E488 VA: 0x1A52488
	public static Exception InvalidRemotingFormat(SerializationFormat mode) { }

	// RVA: 0x1A524D0 Offset: 0x1A4E4D0 VA: 0x1A524D0
	public static Exception TableForeignPrimaryKey() { }

	// RVA: 0x1A52510 Offset: 0x1A4E510 VA: 0x1A52510
	public static Exception TableCannotAddToSimpleContent() { }

	// RVA: 0x1A52550 Offset: 0x1A4E550 VA: 0x1A52550
	public static Exception NoTableName() { }

	// RVA: 0x1A52590 Offset: 0x1A4E590 VA: 0x1A52590
	public static Exception MultipleTextOnlyColumns() { }

	// RVA: 0x1A525D0 Offset: 0x1A4E5D0 VA: 0x1A525D0
	public static Exception InvalidSortString(string sort) { }

	// RVA: 0x1A5261C Offset: 0x1A4E61C VA: 0x1A5261C
	public static Exception DuplicateTableName(string table) { }

	// RVA: 0x1A52668 Offset: 0x1A4E668 VA: 0x1A52668
	public static Exception DuplicateTableName2(string table, string ns) { }

	// RVA: 0x1A526C4 Offset: 0x1A4E6C4 VA: 0x1A526C4
	public static Exception SelfnestedDatasetConflictingName(string table) { }

	// RVA: 0x1A52710 Offset: 0x1A4E710 VA: 0x1A52710
	public static Exception DatasetConflictingName(string table) { }

	// RVA: 0x1A5275C Offset: 0x1A4E75C VA: 0x1A5275C
	public static Exception TableAlreadyInOtherDataSet() { }

	// RVA: 0x1A5279C Offset: 0x1A4E79C VA: 0x1A5279C
	public static Exception TableAlreadyInTheDataSet() { }

	// RVA: 0x1A527DC Offset: 0x1A4E7DC VA: 0x1A527DC
	public static Exception TableOutOfRange(int index) { }

	// RVA: 0x1A5286C Offset: 0x1A4E86C VA: 0x1A5286C
	public static Exception TableNotInTheDataSet(string table) { }

	// RVA: 0x1A528B8 Offset: 0x1A4E8B8 VA: 0x1A528B8
	public static Exception TableInRelation() { }

	// RVA: 0x1A528F8 Offset: 0x1A4E8F8 VA: 0x1A528F8
	public static Exception TableInConstraint(DataTable table, Constraint constraint) { }

	// RVA: 0x1A52970 Offset: 0x1A4E970 VA: 0x1A52970
	public static Exception CanNotSerializeDataTableHierarchy() { }

	// RVA: 0x1A529B0 Offset: 0x1A4E9B0 VA: 0x1A529B0
	public static Exception CanNotRemoteDataTable() { }

	// RVA: 0x1A529F0 Offset: 0x1A4E9F0 VA: 0x1A529F0
	public static Exception CanNotSetRemotingFormat() { }

	// RVA: 0x1A52A30 Offset: 0x1A4EA30 VA: 0x1A52A30
	public static Exception CanNotSerializeDataTableWithEmptyName() { }

	// RVA: 0x1A52A70 Offset: 0x1A4EA70 VA: 0x1A52A70
	public static Exception TableNotFound(string tableName) { }

	// RVA: 0x1A52ABC Offset: 0x1A4EABC VA: 0x1A52ABC
	public static Exception AggregateException(AggregateType aggregateType, Type type) { }

	// RVA: 0x1A52B74 Offset: 0x1A4EB74 VA: 0x1A52B74
	public static Exception InvalidStorageType(TypeCode typecode) { }

	// RVA: 0x1A52C08 Offset: 0x1A4EC08 VA: 0x1A52C08
	public static Exception RangeArgument(int min, int max) { }

	// RVA: 0x1A52CBC Offset: 0x1A4ECBC VA: 0x1A52CBC
	public static Exception NullRange() { }

	// RVA: 0x1A52CFC Offset: 0x1A4ECFC VA: 0x1A52CFC
	public static Exception NegativeMinimumCapacity() { }

	// RVA: 0x1A52D3C Offset: 0x1A4ED3C VA: 0x1A52D3C
	public static Exception ProblematicChars(char charValue) { }

	// RVA: 0x1A52E18 Offset: 0x1A4EE18 VA: 0x1A52E18
	public static Exception StorageSetFailed() { }

	// RVA: 0x1A52E58 Offset: 0x1A4EE58 VA: 0x1A52E58
	public static Exception SimpleTypeNotSupported() { }

	// RVA: 0x1A52E98 Offset: 0x1A4EE98 VA: 0x1A52E98
	public static Exception MissingAttribute(string attribute) { }

	// RVA: 0x1A52EB8 Offset: 0x1A4EEB8 VA: 0x1A52EB8
	public static Exception MissingAttribute(string element, string attribute) { }

	// RVA: 0x1A52F14 Offset: 0x1A4EF14 VA: 0x1A52F14
	public static Exception InvalidAttributeValue(string name, string value) { }

	// RVA: 0x1A52F70 Offset: 0x1A4EF70 VA: 0x1A52F70
	public static Exception AttributeValues(string name, string value1, string value2) { }

	// RVA: 0x1A52FD4 Offset: 0x1A4EFD4 VA: 0x1A52FD4
	public static Exception ElementTypeNotFound(string name) { }

	// RVA: 0x1A53020 Offset: 0x1A4F020 VA: 0x1A53020
	public static Exception RelationParentNameMissing(string rel) { }

	// RVA: 0x1A5306C Offset: 0x1A4F06C VA: 0x1A5306C
	public static Exception RelationChildNameMissing(string rel) { }

	// RVA: 0x1A530B8 Offset: 0x1A4F0B8 VA: 0x1A530B8
	public static Exception RelationTableKeyMissing(string rel) { }

	// RVA: 0x1A53104 Offset: 0x1A4F104 VA: 0x1A53104
	public static Exception RelationChildKeyMissing(string rel) { }

	// RVA: 0x1A53150 Offset: 0x1A4F150 VA: 0x1A53150
	public static Exception UndefinedDatatype(string name) { }

	// RVA: 0x1A5319C Offset: 0x1A4F19C VA: 0x1A5319C
	public static Exception DatatypeNotDefined() { }

	// RVA: 0x1A531DC Offset: 0x1A4F1DC VA: 0x1A531DC
	public static Exception MismatchKeyLength() { }

	// RVA: 0x1A5321C Offset: 0x1A4F21C VA: 0x1A5321C
	public static Exception InvalidField(string name) { }

	// RVA: 0x1A53268 Offset: 0x1A4F268 VA: 0x1A53268
	public static Exception InvalidSelector(string name) { }

	// RVA: 0x1A532B4 Offset: 0x1A4F2B4 VA: 0x1A532B4
	public static Exception CircularComplexType(string name) { }

	// RVA: 0x1A53300 Offset: 0x1A4F300 VA: 0x1A53300
	public static Exception CannotInstantiateAbstract(string name) { }

	// RVA: 0x1A5334C Offset: 0x1A4F34C VA: 0x1A5334C
	public static Exception InvalidKey(string name) { }

	// RVA: 0x1A53398 Offset: 0x1A4F398 VA: 0x1A53398
	public static Exception DiffgramMissingTable(string name) { }

	// RVA: 0x1A533E4 Offset: 0x1A4F3E4 VA: 0x1A533E4
	public static Exception DiffgramMissingSQL() { }

	// RVA: 0x1A53424 Offset: 0x1A4F424 VA: 0x1A53424
	public static Exception DuplicateConstraintRead(string str) { }

	// RVA: 0x1A53470 Offset: 0x1A4F470 VA: 0x1A53470
	public static Exception ColumnTypeConflict(string name) { }

	// RVA: 0x1A534BC Offset: 0x1A4F4BC VA: 0x1A534BC
	public static Exception CannotConvert(string name, string type) { }

	// RVA: 0x1A53518 Offset: 0x1A4F518 VA: 0x1A53518
	public static Exception MissingRefer(string name) { }

	// RVA: 0x1A49FC4 Offset: 0x1A45FC4 VA: 0x1A49FC4
	public static Exception InvalidPrefix(string name) { }

	// RVA: 0x1A5359C Offset: 0x1A4F59C VA: 0x1A5359C
	public static Exception CanNotDeserializeObjectType() { }

	// RVA: 0x1A535DC Offset: 0x1A4F5DC VA: 0x1A535DC
	public static Exception IsDataSetAttributeMissingInSchema() { }

	// RVA: 0x1A5361C Offset: 0x1A4F61C VA: 0x1A5361C
	public static Exception TooManyIsDataSetAtributeInSchema() { }

	// RVA: 0x1A5365C Offset: 0x1A4F65C VA: 0x1A5365C
	public static Exception NestedCircular(string name) { }

	// RVA: 0x1A536A8 Offset: 0x1A4F6A8 VA: 0x1A536A8
	public static Exception MultipleParentRows(string tableQName) { }

	// RVA: 0x1A536F4 Offset: 0x1A4F6F4 VA: 0x1A536F4
	public static Exception PolymorphismNotSupported(string typeName) { }

	// RVA: 0x1A53740 Offset: 0x1A4F740 VA: 0x1A53740
	public static Exception DataTableInferenceNotSupported() { }

	// RVA: 0x1A53780 Offset: 0x1A4F780 VA: 0x1A53780
	internal static void ThrowMultipleTargetConverter(Exception innerException) { }

	// RVA: 0x1A537E0 Offset: 0x1A4F7E0 VA: 0x1A537E0
	public static Exception DuplicateDeclaration(string name) { }

	// RVA: 0x1A5382C Offset: 0x1A4F82C VA: 0x1A5382C
	public static Exception FoundEntity() { }

	// RVA: 0x1A5386C Offset: 0x1A4F86C VA: 0x1A5386C
	public static Exception MergeFailed(string name) { }

	// RVA: 0x1A53870 Offset: 0x1A4F870 VA: 0x1A53870
	public static Exception ConvertFailed(Type type1, Type type2) { }

	// RVA: 0x1A53900 Offset: 0x1A4F900 VA: 0x1A53900
	internal static Exception InvalidDuplicateNamedSimpleTypeDelaration(string stName, string errorStr) { }

	// RVA: 0x1A5395C Offset: 0x1A4F95C VA: 0x1A5395C
	internal static Exception InternalRBTreeError(RBTreeError internalError) { }

	// RVA: 0x1A539D0 Offset: 0x1A4F9D0 VA: 0x1A539D0
	public static Exception EnumeratorModified() { }
}

// Namespace: System.Data
[DefaultProperty("DataSetName")]
[XmlSchemaProvider("GetDataSetSchema")]
[XmlRoot("DataSet")]
[ToolboxItem("Microsoft.VSDesigner.Data.VS.DataSetToolboxItem, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[Serializable]
public class DataSet : MarshalByValueComponent, IXmlSerializable, ISerializable // TypeDefIndex: 4432
{
	// Fields
	private DataViewManager _defaultViewManager; // 0x20
	private readonly DataTableCollection _tableCollection; // 0x28
	private readonly DataRelationCollection _relationCollection; // 0x30
	internal PropertyCollection _extendedProperties; // 0x38
	private string _dataSetName; // 0x40
	private string _datasetPrefix; // 0x48
	internal string _namespaceURI; // 0x50
	private bool _enforceConstraints; // 0x58
	private bool _caseSensitive; // 0x59
	private CultureInfo _culture; // 0x60
	private bool _cultureUserSet; // 0x68
	internal bool _fInReadXml; // 0x69
	internal bool _fInLoadDiffgram; // 0x6A
	internal bool _fTopLevelTable; // 0x6B
	internal bool _fInitInProgress; // 0x6C
	internal bool _fEnableCascading; // 0x6D
	internal bool _fIsSchemaLoading; // 0x6E
	internal string _mainTableName; // 0x70
	private SerializationFormat _remotingFormat; // 0x78
	private object _defaultViewManagerLock; // 0x80
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x88
	private static XmlSchemaComplexType s_schemaTypeForWSDL; // 0x8
	internal bool _useDataSetSchemaOnly; // 0x8C
	internal bool _udtIsWrapped; // 0x8D
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0x90
	[CompilerGenerated]
	private MergeFailedEventHandler MergeFailed; // 0x98
	[CompilerGenerated]
	private DataRowCreatedEventHandler DataRowCreated; // 0xA0
	[CompilerGenerated]
	private DataSetClearEventhandler ClearFunctionCalled; // 0xA8

	// Properties
	[DefaultValue(0)]
	public SerializationFormat RemotingFormat { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual SchemaSerializationMode SchemaSerializationMode { get; }
	[DefaultValue(False)]
	public bool CaseSensitive { get; set; }
	[DefaultValue(True)]
	public bool EnforceConstraints { get; set; }
	[DefaultValue("")]
	public string DataSetName { get; set; }
	[DefaultValue("")]
	public string Namespace { get; set; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	public CultureInfo Locale { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public override ISite Site { get; }
	[DesignerSerializationVisibility(2)]
	public DataRelationCollection Relations { get; }
	[DesignerSerializationVisibility(2)]
	public DataTableCollection Tables { get; }
	internal string MainTableName { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x1A53A10 Offset: 0x1A4FA10 VA: 0x1A53A10
	public void .ctor() { }

	// RVA: 0x1A53CB4 Offset: 0x1A4FCB4 VA: 0x1A53CB4
	public void .ctor(string dataSetName) { }

	// RVA: 0x1A53E38 Offset: 0x1A4FE38 VA: 0x1A53E38
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0x1A53E40 Offset: 0x1A4FE40 VA: 0x1A53E40
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x1A53EE0 Offset: 0x1A4FEE0 VA: 0x1A53EE0 Slot: 14
	public virtual SchemaSerializationMode get_SchemaSerializationMode() { }

	// RVA: 0x1A53EE8 Offset: 0x1A4FEE8 VA: 0x1A53EE8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A53EF0 Offset: 0x1A4FEF0 VA: 0x1A53EF0
	protected void .ctor(SerializationInfo info, StreamingContext context, bool ConstructSchema) { }

	// RVA: 0x1A54130 Offset: 0x1A50130 VA: 0x1A54130 Slot: 15
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A54738 Offset: 0x1A50738 VA: 0x1A54738 Slot: 16
	protected virtual void InitializeDerivedDataSet() { }

	// RVA: 0x1A54138 Offset: 0x1A50138 VA: 0x1A54138
	private void SerializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0x1A540E8 Offset: 0x1A500E8 VA: 0x1A540E8
	internal void DeserializeDataSet(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0x1A553CC Offset: 0x1A513CC VA: 0x1A553CC
	private void DeserializeDataSetSchema(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat, SchemaSerializationMode schemaSerializationMode) { }

	// RVA: 0x1A55860 Offset: 0x1A51860 VA: 0x1A55860
	private void DeserializeDataSetData(SerializationInfo info, StreamingContext context, SerializationFormat remotingFormat) { }

	// RVA: 0x1A5473C Offset: 0x1A5073C VA: 0x1A5473C
	private void SerializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A55A00 Offset: 0x1A51A00 VA: 0x1A55A00
	private void DeserializeDataSetProperties(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A548AC Offset: 0x1A508AC VA: 0x1A548AC
	private void SerializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A55CD4 Offset: 0x1A51CD4 VA: 0x1A55CD4
	private void DeserializeRelations(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A56DF8 Offset: 0x1A52DF8 VA: 0x1A56DF8
	internal void FailedEnableConstraints() { }

	// RVA: 0x1A56F88 Offset: 0x1A52F88 VA: 0x1A56F88
	public bool get_CaseSensitive() { }

	// RVA: 0x1A56F90 Offset: 0x1A52F90 VA: 0x1A56F90
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x1A5765C Offset: 0x1A5365C VA: 0x1A5765C
	public bool get_EnforceConstraints() { }

	// RVA: 0x1A56E24 Offset: 0x1A52E24 VA: 0x1A56E24
	public void set_EnforceConstraints(bool value) { }

	// RVA: 0x1A57D30 Offset: 0x1A53D30 VA: 0x1A57D30
	internal void RestoreEnforceConstraints(bool value) { }

	// RVA: 0x1A57664 Offset: 0x1A53664 VA: 0x1A57664
	internal void EnableConstraints() { }

	// RVA: 0x1A57D38 Offset: 0x1A53D38 VA: 0x1A57D38
	public string get_DataSetName() { }

	// RVA: 0x1A53CDC Offset: 0x1A4FCDC VA: 0x1A53CDC
	public void set_DataSetName(string value) { }

	// RVA: 0x1A57DB8 Offset: 0x1A53DB8 VA: 0x1A57DB8
	public string get_Namespace() { }

	// RVA: 0x1A57DC0 Offset: 0x1A53DC0 VA: 0x1A57DC0
	public void set_Namespace(string value) { }

	// RVA: 0x1A58258 Offset: 0x1A54258 VA: 0x1A58258
	public string get_Prefix() { }

	// RVA: 0x1A58260 Offset: 0x1A54260 VA: 0x1A58260
	public void set_Prefix(string value) { }

	// RVA: 0x1A56D88 Offset: 0x1A52D88 VA: 0x1A56D88
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x1A58388 Offset: 0x1A54388 VA: 0x1A58388
	public CultureInfo get_Locale() { }

	// RVA: 0x1A58390 Offset: 0x1A54390 VA: 0x1A58390
	public void set_Locale(CultureInfo value) { }

	// RVA: 0x1A58510 Offset: 0x1A54510 VA: 0x1A58510
	internal void SetLocaleValue(CultureInfo value, bool userSet) { }

	// RVA: 0x1A59074 Offset: 0x1A55074 VA: 0x1A59074
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x1A5907C Offset: 0x1A5507C VA: 0x1A5907C Slot: 7
	public override ISite get_Site() { }

	// RVA: 0x1A59084 Offset: 0x1A55084 VA: 0x1A59084
	public DataRelationCollection get_Relations() { }

	// RVA: 0x1A5908C Offset: 0x1A5508C VA: 0x1A5908C
	public DataTableCollection get_Tables() { }

	// RVA: 0x1A59094 Offset: 0x1A55094 VA: 0x1A59094
	public void Clear() { }

	// RVA: 0x1A592A8 Offset: 0x1A552A8 VA: 0x1A592A8 Slot: 17
	public virtual DataSet Clone() { }

	// RVA: 0x1A550B8 Offset: 0x1A510B8 VA: 0x1A550B8
	internal int EstimatedXmlStringSize() { }

	// RVA: 0x1A5A204 Offset: 0x1A56204 VA: 0x1A5A204
	internal string GetRemotingDiffGram(DataTable table) { }

	// RVA: 0x1A54F24 Offset: 0x1A50F24 VA: 0x1A54F24
	internal string GetXmlSchemaForRemoting(DataTable table) { }

	// RVA: 0x1A5A334 Offset: 0x1A56334 VA: 0x1A5A334
	public void ReadXmlSchema(XmlReader reader) { }

	// RVA: 0x1A564E8 Offset: 0x1A524E8 VA: 0x1A564E8
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x1A5A73C Offset: 0x1A5673C VA: 0x1A5A73C
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0x1A5ABFC Offset: 0x1A56BFC VA: 0x1A5ABFC
	private static void MoveToElement(XmlReader reader) { }

	// RVA: 0x1A5A7F0 Offset: 0x1A567F0 VA: 0x1A5A7F0
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0x1A5A494 Offset: 0x1A56494 VA: 0x1A5A494
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x1A5A33C Offset: 0x1A5633C VA: 0x1A5A33C
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0x1A5AC74 Offset: 0x1A56C74 VA: 0x1A5AC74
	private void WriteXmlSchema(XmlWriter writer, SchemaFormat schemaFormat, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0x1A5AE90 Offset: 0x1A56E90 VA: 0x1A5AE90
	public XmlReadMode ReadXml(XmlReader reader) { }

	// RVA: 0x1A5AE98 Offset: 0x1A56E98 VA: 0x1A5AE98
	internal XmlReadMode ReadXml(XmlReader reader, bool denyResolving) { }

	// RVA: 0x1A5A88C Offset: 0x1A5688C VA: 0x1A5A88C
	internal void InferSchema(XmlDocument xdoc, string[] excludedNamespaces, XmlReadMode mode) { }

	// RVA: 0x1A5D190 Offset: 0x1A59190 VA: 0x1A5D190
	private bool IsEmpty() { }

	// RVA: 0x1A5BF8C Offset: 0x1A57F8C VA: 0x1A5BF8C
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0x1A56D80 Offset: 0x1A52D80 VA: 0x1A56D80
	public XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode) { }

	// RVA: 0x1A5D5B4 Offset: 0x1A595B4 VA: 0x1A5D5B4
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0x1A551D8 Offset: 0x1A511D8 VA: 0x1A551D8
	public void WriteXml(XmlWriter writer, XmlWriteMode mode) { }

	// RVA: 0x1A5D450 Offset: 0x1A59450 VA: 0x1A5D450
	public void Merge(DataSet dataSet) { }

	// RVA: 0x1A5E378 Offset: 0x1A5A378 VA: 0x1A5E378
	public void Merge(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x1A5E5B8 Offset: 0x1A5A5B8 VA: 0x1A5E5B8 Slot: 18
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x1A5E5E0 Offset: 0x1A5A5E0 VA: 0x1A5E5E0
	internal void OnMergeFailed(MergeFailedEventArgs mfevent) { }

	// RVA: 0x1A5E638 Offset: 0x1A5A638 VA: 0x1A5E638
	internal void RaiseMergeFailed(DataTable table, string conflict, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x1A5E6DC Offset: 0x1A5A6DC VA: 0x1A5E6DC
	internal void OnDataRowCreated(DataRow row) { }

	// RVA: 0x1A59280 Offset: 0x1A55280 VA: 0x1A59280
	internal void OnClearFunctionCalled(DataTable table) { }

	// RVA: 0x1A5E704 Offset: 0x1A5A704 VA: 0x1A5E704 Slot: 19
	protected internal virtual void OnRemoveTable(DataTable table) { }

	// RVA: 0x1A5E708 Offset: 0x1A5A708 VA: 0x1A5E708
	internal void OnRemovedTable(DataTable table) { }

	// RVA: 0x1A5E72C Offset: 0x1A5A72C VA: 0x1A5E72C Slot: 20
	protected virtual void OnRemoveRelation(DataRelation relation) { }

	// RVA: 0x1A5E730 Offset: 0x1A5A730 VA: 0x1A5E730
	internal void OnRemoveRelationHack(DataRelation relation) { }

	// RVA: 0x1A57D40 Offset: 0x1A53D40 VA: 0x1A57D40
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x1A5E740 Offset: 0x1A5A740 VA: 0x1A5E740
	internal DataTable[] TopLevelTables() { }

	// RVA: 0x1A5E748 Offset: 0x1A5A748 VA: 0x1A5E748
	internal DataTable[] TopLevelTables(bool forSchema) { }

	// RVA: 0x1A5EA3C Offset: 0x1A5AA3C VA: 0x1A5EA3C Slot: 21
	public virtual void Reset() { }

	// RVA: 0x1A57280 Offset: 0x1A53280 VA: 0x1A57280
	internal bool ValidateCaseConstraint() { }

	// RVA: 0x1A58C40 Offset: 0x1A54C40 VA: 0x1A58C40
	internal bool ValidateLocaleConstraint() { }

	// RVA: 0x1A5ECDC Offset: 0x1A5ACDC VA: 0x1A5ECDC Slot: 22
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0x1A5EFC4 Offset: 0x1A5AFC4 VA: 0x1A5EFC4
	public static XmlSchemaComplexType GetDataSetSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0x1A5F250 Offset: 0x1A5B250 VA: 0x1A5F250 Slot: 10
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1A5F418 Offset: 0x1A5B418 VA: 0x1A5F418 Slot: 11
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1A5F668 Offset: 0x1A5B668 VA: 0x1A5F668 Slot: 12
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1A5F69C Offset: 0x1A5B69C VA: 0x1A5F69C
	internal string get_MainTableName() { }

	// RVA: 0x1A5F6A4 Offset: 0x1A5B6A4 VA: 0x1A5F6A4
	internal void set_MainTableName(string value) { }

	// RVA: 0x1A5F6AC Offset: 0x1A5B6AC VA: 0x1A5F6AC
	internal int get_ObjectID() { }
}

// Namespace: 
internal struct DataTable.RowDiffIdUsageSection // TypeDefIndex: 4433
{
	// Fields
	private DataTable _targetTable; // 0x0

	// Methods

	// RVA: 0x1A5F6B4 Offset: 0x1A5B6B4 VA: 0x1A5F6B4
	internal void Prepare(DataTable table) { }
}

// Namespace: 
internal struct DataTable.DSRowDiffIdUsageSection // TypeDefIndex: 4434
{
	// Fields
	private DataSet _targetDS; // 0x0

	// Methods

	// RVA: 0x1A5BF10 Offset: 0x1A57F10 VA: 0x1A5BF10
	internal void Prepare(DataSet ds) { }
}

// Namespace: System.Data
[DesignTimeVisible(False)]
[DefaultProperty("TableName")]
[DefaultEvent("RowChanging")]
[XmlSchemaProvider("GetDataTableSchema")]
[ToolboxItem(False)]
[Serializable]
public class DataTable : MarshalByValueComponent, ISerializable, IXmlSerializable // TypeDefIndex: 4435
{
	// Fields
	private DataSet _dataSet; // 0x20
	private DataView _defaultView; // 0x28
	internal long _nextRowID; // 0x30
	internal readonly DataRowCollection _rowCollection; // 0x38
	internal readonly DataColumnCollection _columnCollection; // 0x40
	private readonly ConstraintCollection _constraintCollection; // 0x48
	private int _elementColumnCount; // 0x50
	internal DataRelationCollection _parentRelationsCollection; // 0x58
	internal DataRelationCollection _childRelationsCollection; // 0x60
	internal readonly RecordManager _recordManager; // 0x68
	internal readonly List<Index> _indexes; // 0x70
	private List<Index> _shadowIndexes; // 0x78
	private int _shadowCount; // 0x80
	internal PropertyCollection _extendedProperties; // 0x88
	private string _tableName; // 0x90
	internal string _tableNamespace; // 0x98
	private string _tablePrefix; // 0xA0
	internal DataExpression _displayExpression; // 0xA8
	internal bool _fNestedInDataset; // 0xB0
	private CultureInfo _culture; // 0xB8
	private bool _cultureUserSet; // 0xC0
	private CompareInfo _compareInfo; // 0xC8
	private CompareOptions _compareFlags; // 0xD0
	private IFormatProvider _formatProvider; // 0xD8
	private StringComparer _hashCodeProvider; // 0xE0
	private bool _caseSensitive; // 0xE8
	private bool _caseSensitiveUserSet; // 0xE9
	internal string _encodedTableName; // 0xF0
	internal DataColumn _xmlText; // 0xF8
	internal DataColumn _colUnique; // 0x100
	internal Decimal _minOccurs; // 0x108
	internal Decimal _maxOccurs; // 0x118
	internal bool _repeatableElement; // 0x128
	private object _typeName; // 0x130
	internal UniqueConstraint _primaryKey; // 0x138
	internal IndexField[] _primaryIndex; // 0x140
	private DataColumn[] _delayedSetPrimaryKey; // 0x148
	private Index _loadIndex; // 0x150
	private Index _loadIndexwithOriginalAdded; // 0x158
	private Index _loadIndexwithCurrentDeleted; // 0x160
	private int _suspendIndexEvents; // 0x168
	private bool _inDataLoad; // 0x16C
	private bool _schemaLoading; // 0x16D
	private bool _enforceConstraints; // 0x16E
	internal bool _suspendEnforceConstraints; // 0x16F
	protected internal bool fInitInProgress; // 0x170
	private bool _inLoad; // 0x171
	internal bool _fInLoadDiffgram; // 0x172
	private byte _isTypedDataTable; // 0x173
	private DataRow[] _emptyDataRowArray; // 0x178
	private PropertyDescriptorCollection _propertyDescriptorCollectionCache; // 0x180
	private DataRelation[] _nestedParentRelations; // 0x188
	internal List<DataColumn> _dependentColumns; // 0x190
	private bool _mergingData; // 0x198
	private DataRowChangeEventHandler _onRowChangedDelegate; // 0x1A0
	private DataRowChangeEventHandler _onRowChangingDelegate; // 0x1A8
	private DataRowChangeEventHandler _onRowDeletingDelegate; // 0x1B0
	private DataRowChangeEventHandler _onRowDeletedDelegate; // 0x1B8
	private DataColumnChangeEventHandler _onColumnChangedDelegate; // 0x1C0
	private DataColumnChangeEventHandler _onColumnChangingDelegate; // 0x1C8
	private DataTableClearEventHandler _onTableClearingDelegate; // 0x1D0
	private DataTableClearEventHandler _onTableClearedDelegate; // 0x1D8
	private DataTableNewRowEventHandler _onTableNewRowDelegate; // 0x1E0
	private PropertyChangedEventHandler _onPropertyChangingDelegate; // 0x1E8
	private readonly DataRowBuilder _rowBuilder; // 0x1F0
	internal readonly List<DataView> _delayedViews; // 0x1F8
	private readonly List<DataViewListener> _dataViewListeners; // 0x200
	internal Hashtable _rowDiffId; // 0x208
	internal readonly ReaderWriterLockSlim _indexesLock; // 0x210
	internal int _ukColumnPositionForInference; // 0x218
	private SerializationFormat _remotingFormat; // 0x21C
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x220

	// Properties
	public bool CaseSensitive { get; set; }
	internal bool AreIndexEventsSuspended { get; }
	private bool IsTypedDataTable { get; }
	internal bool SelfNested { get; }
	[DebuggerBrowsable(0)]
	internal List<Index> LiveIndexes { get; }
	[DefaultValue(0)]
	public SerializationFormat RemotingFormat { get; set; }
	internal int UKColumnPositionForInference { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataRelationCollection ChildRelations { get; }
	[DesignerSerializationVisibility(2)]
	public DataColumnCollection Columns { get; }
	private CompareInfo CompareInfo { get; }
	[DesignerSerializationVisibility(2)]
	public ConstraintCollection Constraints { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public DataSet DataSet { get; }
	internal string DisplayExpressionInternal { get; }
	internal bool EnforceConstraints { get; set; }
	internal bool SuspendEnforceConstraints { get; set; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal IFormatProvider FormatProvider { get; }
	public CultureInfo Locale { get; set; }
	[DefaultValue(50)]
	public int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; }
	internal int ElementColumnCount { get; set; }
	[DesignerSerializationVisibility(0)]
	[Browsable(False)]
	public DataRelationCollection ParentRelations { get; }
	internal bool MergingData { get; set; }
	internal DataRelation[] NestedParentRelations { get; }
	internal bool SchemaLoading { get; }
	internal int NestedParentsCount { get; }
	[TypeConverter(typeof(PrimaryKeyTypeConverter))]
	public DataColumn[] PrimaryKey { get; set; }
	[Browsable(False)]
	public DataRowCollection Rows { get; }
	[DefaultValue("")]
	[RefreshProperties(1)]
	public string TableName { get; set; }
	internal string EncodedTableName { get; }
	public string Namespace { get; set; }
	[DefaultValue("")]
	public string Prefix { get; set; }
	internal DataColumn XmlText { get; set; }
	internal Decimal MaxOccurs { get; set; }
	internal Decimal MinOccurs { get; set; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public override ISite Site { get; }
	internal bool NeedColumnChangeEvents { get; }
	internal XmlQualifiedName TypeName { get; set; }
	internal Hashtable RowDiffId { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x1A2F340 Offset: 0x1A2B340 VA: 0x1A2F340
	public void .ctor() { }

	// RVA: 0x1A2F8A0 Offset: 0x1A2B8A0 VA: 0x1A2F8A0
	public void .ctor(string tableName) { }

	// RVA: 0x1A2F908 Offset: 0x1A2B908 VA: 0x1A2F908
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A2FD88 Offset: 0x1A2BD88 VA: 0x1A2FD88 Slot: 14
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A2FE60 Offset: 0x1A2BE60 VA: 0x1A2FE60
	private void SerializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0x1A2FAA0 Offset: 0x1A2BAA0 VA: 0x1A2FAA0
	internal void DeserializeDataTable(SerializationInfo info, StreamingContext context, bool isSingleTable, SerializationFormat remotingFormat) { }

	// RVA: 0x1A30138 Offset: 0x1A2C138 VA: 0x1A30138
	internal void SerializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0x1A31430 Offset: 0x1A2D430 VA: 0x1A31430
	internal void DeserializeTableSchema(SerializationInfo info, StreamingContext context, bool isSingleTable) { }

	// RVA: 0x1A34154 Offset: 0x1A30154 VA: 0x1A34154
	internal void SerializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0x1A35114 Offset: 0x1A31114 VA: 0x1A35114
	internal void DeserializeConstraints(SerializationInfo info, StreamingContext context, int serIndex, bool allConstraints) { }

	// RVA: 0x1A35D74 Offset: 0x1A31D74 VA: 0x1A35D74
	internal void SerializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x1A35EC4 Offset: 0x1A31EC4 VA: 0x1A35EC4
	internal void DeserializeExpressionColumns(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x1A30DF4 Offset: 0x1A2CDF4 VA: 0x1A30DF4
	internal void SerializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x1A322DC Offset: 0x1A2E2DC VA: 0x1A322DC
	internal void DeserializeTableData(SerializationInfo info, StreamingContext context, int serIndex) { }

	// RVA: 0x1A362C8 Offset: 0x1A322C8 VA: 0x1A362C8
	private DataRowState ConvertToRowState(BitArray bitStates, int bitIndex) { }

	// RVA: 0x1A3601C Offset: 0x1A3201C VA: 0x1A3601C
	internal void GetRowAndColumnErrors(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0x1A36370 Offset: 0x1A32370 VA: 0x1A36370
	private void ConvertToRowError(int rowIndex, Hashtable rowErrors, Hashtable colErrors) { }

	// RVA: 0x1A36620 Offset: 0x1A32620 VA: 0x1A36620
	public bool get_CaseSensitive() { }

	// RVA: 0x1A36628 Offset: 0x1A32628 VA: 0x1A36628
	public void set_CaseSensitive(bool value) { }

	// RVA: 0x1A366C8 Offset: 0x1A326C8 VA: 0x1A366C8
	internal bool get_AreIndexEventsSuspended() { }

	// RVA: 0x1A366D8 Offset: 0x1A326D8 VA: 0x1A366D8
	internal void RestoreIndexEvents(bool forceReset) { }

	// RVA: 0x1A36AA4 Offset: 0x1A32AA4 VA: 0x1A36AA4
	internal void SuspendIndexEvents() { }

	// RVA: 0x1A36B50 Offset: 0x1A32B50 VA: 0x1A36B50
	private bool get_IsTypedDataTable() { }

	// RVA: 0x1A34878 Offset: 0x1A30878 VA: 0x1A34878
	internal bool SetCaseSensitiveValue(bool isCaseSensitive, bool userSet, bool resetIndexes) { }

	// RVA: 0x1A36C04 Offset: 0x1A32C04 VA: 0x1A36C04
	internal bool ShouldSerializeCaseSensitive() { }

	// RVA: 0x1A36C0C Offset: 0x1A32C0C VA: 0x1A36C0C
	internal bool get_SelfNested() { }

	// RVA: 0x1A36F70 Offset: 0x1A32F70 VA: 0x1A36F70
	internal List<Index> get_LiveIndexes() { }

	// RVA: 0x1A3701C Offset: 0x1A3301C VA: 0x1A3701C
	public SerializationFormat get_RemotingFormat() { }

	// RVA: 0x1A37024 Offset: 0x1A33024 VA: 0x1A37024
	public void set_RemotingFormat(SerializationFormat value) { }

	// RVA: 0x1A37084 Offset: 0x1A33084 VA: 0x1A37084
	internal int get_UKColumnPositionForInference() { }

	// RVA: 0x1A3708C Offset: 0x1A3308C VA: 0x1A3708C
	internal void set_UKColumnPositionForInference(int value) { }

	// RVA: 0x1A37094 Offset: 0x1A33094 VA: 0x1A37094
	public DataRelationCollection get_ChildRelations() { }

	// RVA: 0x1A37110 Offset: 0x1A33110 VA: 0x1A37110
	public DataColumnCollection get_Columns() { }

	// RVA: 0x1A37118 Offset: 0x1A33118 VA: 0x1A37118
	private CompareInfo get_CompareInfo() { }

	// RVA: 0x1A37168 Offset: 0x1A33168 VA: 0x1A37168
	public ConstraintCollection get_Constraints() { }

	// RVA: 0x1A37170 Offset: 0x1A33170 VA: 0x1A37170
	private void ResetConstraints() { }

	// RVA: 0x1A37188 Offset: 0x1A33188 VA: 0x1A37188
	public DataSet get_DataSet() { }

	// RVA: 0x1A37190 Offset: 0x1A33190 VA: 0x1A37190
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x1A37254 Offset: 0x1A33254 VA: 0x1A37254
	internal string get_DisplayExpressionInternal() { }

	// RVA: 0x1A3727C Offset: 0x1A3327C VA: 0x1A3727C
	internal bool get_EnforceConstraints() { }

	// RVA: 0x1A372AC Offset: 0x1A332AC VA: 0x1A372AC
	internal void set_EnforceConstraints(bool value) { }

	// RVA: 0x1A37868 Offset: 0x1A33868 VA: 0x1A37868
	internal bool get_SuspendEnforceConstraints() { }

	// RVA: 0x1A37870 Offset: 0x1A33870 VA: 0x1A37870
	internal void set_SuspendEnforceConstraints(bool value) { }

	// RVA: 0x1A372F0 Offset: 0x1A332F0 VA: 0x1A372F0
	internal void EnableConstraints() { }

	// RVA: 0x1A33C18 Offset: 0x1A2FC18 VA: 0x1A33C18
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x1A37878 Offset: 0x1A33878 VA: 0x1A37878
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x1A37918 Offset: 0x1A33918 VA: 0x1A37918
	public CultureInfo get_Locale() { }

	// RVA: 0x1A37920 Offset: 0x1A33920 VA: 0x1A37920
	public void set_Locale(CultureInfo value) { }

	// RVA: 0x1A34B64 Offset: 0x1A30B64 VA: 0x1A34B64
	internal bool SetLocaleValue(CultureInfo culture, bool userSet, bool resetIndexes) { }

	// RVA: 0x1A37DB0 Offset: 0x1A33DB0 VA: 0x1A37DB0
	internal bool ShouldSerializeLocale() { }

	// RVA: 0x1A37DB8 Offset: 0x1A33DB8 VA: 0x1A37DB8
	public int get_MinimumCapacity() { }

	// RVA: 0x1A350EC Offset: 0x1A310EC VA: 0x1A350EC
	public void set_MinimumCapacity(int value) { }

	// RVA: 0x1A37DD0 Offset: 0x1A33DD0 VA: 0x1A37DD0
	internal int get_RecordCapacity() { }

	// RVA: 0x1A37DE8 Offset: 0x1A33DE8 VA: 0x1A37DE8
	internal int get_ElementColumnCount() { }

	// RVA: 0x1A37DF0 Offset: 0x1A33DF0 VA: 0x1A37DF0
	internal void set_ElementColumnCount(int value) { }

	// RVA: 0x1A36EF4 Offset: 0x1A32EF4 VA: 0x1A36EF4
	public DataRelationCollection get_ParentRelations() { }

	// RVA: 0x1A37E30 Offset: 0x1A33E30 VA: 0x1A37E30
	internal bool get_MergingData() { }

	// RVA: 0x1A37E38 Offset: 0x1A33E38 VA: 0x1A37E38
	internal void set_MergingData(bool value) { }

	// RVA: 0x1A37E40 Offset: 0x1A33E40 VA: 0x1A37E40
	internal DataRelation[] get_NestedParentRelations() { }

	// RVA: 0x1A37E48 Offset: 0x1A33E48 VA: 0x1A37E48
	internal bool get_SchemaLoading() { }

	// RVA: 0x1A37E50 Offset: 0x1A33E50 VA: 0x1A37E50
	internal void CacheNestedParent() { }

	// RVA: 0x1A37E70 Offset: 0x1A33E70 VA: 0x1A37E70
	private DataRelation[] FindNestedParentRelations() { }

	// RVA: 0x1A382BC Offset: 0x1A342BC VA: 0x1A382BC
	internal int get_NestedParentsCount() { }

	// RVA: 0x1A38574 Offset: 0x1A34574 VA: 0x1A38574
	public DataColumn[] get_PrimaryKey() { }

	// RVA: 0x1A38630 Offset: 0x1A34630 VA: 0x1A38630
	public void set_PrimaryKey(DataColumn[] value) { }

	// RVA: 0x1A38A9C Offset: 0x1A34A9C VA: 0x1A38A9C
	public DataRowCollection get_Rows() { }

	// RVA: 0x1A38AA4 Offset: 0x1A34AA4 VA: 0x1A38AA4
	public string get_TableName() { }

	// RVA: 0x1A38AAC Offset: 0x1A34AAC VA: 0x1A38AAC
	public void set_TableName(string value) { }

	// RVA: 0x1A39044 Offset: 0x1A35044 VA: 0x1A39044
	internal string get_EncodedTableName() { }

	// RVA: 0x1A390C8 Offset: 0x1A350C8 VA: 0x1A390C8
	private string GetInheritedNamespace(List<DataTable> visitedTables) { }

	// RVA: 0x1A313AC Offset: 0x1A2D3AC VA: 0x1A313AC
	public string get_Namespace() { }

	// RVA: 0x1A338F8 Offset: 0x1A2F8F8 VA: 0x1A338F8
	public void set_Namespace(string value) { }

	// RVA: 0x1A39FE0 Offset: 0x1A35FE0 VA: 0x1A39FE0
	internal bool IsNamespaceInherited() { }

	// RVA: 0x1A39310 Offset: 0x1A35310 VA: 0x1A39310
	internal void CheckCascadingNamespaceConflict(string realNamespace) { }

	// RVA: 0x1A396B0 Offset: 0x1A356B0 VA: 0x1A396B0
	internal void CheckNamespaceValidityForNestedRelations(string realNamespace) { }

	// RVA: 0x1A39FF0 Offset: 0x1A35FF0 VA: 0x1A39FF0
	internal void CheckNamespaceValidityForNestedParentRelations(string ns, DataTable parentTable) { }

	// RVA: 0x1A39A88 Offset: 0x1A35A88 VA: 0x1A39A88
	internal void DoRaiseNamespaceChange() { }

	// RVA: 0x1A3A33C Offset: 0x1A3633C VA: 0x1A3A33C
	public string get_Prefix() { }

	// RVA: 0x1A3A344 Offset: 0x1A36344 VA: 0x1A3A344
	public void set_Prefix(string value) { }

	// RVA: 0x1A3A4A0 Offset: 0x1A364A0 VA: 0x1A3A4A0
	internal DataColumn get_XmlText() { }

	// RVA: 0x1A3A4A8 Offset: 0x1A364A8 VA: 0x1A3A4A8
	internal void set_XmlText(DataColumn value) { }

	// RVA: 0x1A3A568 Offset: 0x1A36568 VA: 0x1A3A568
	internal Decimal get_MaxOccurs() { }

	// RVA: 0x1A3A574 Offset: 0x1A36574 VA: 0x1A3A574
	internal void set_MaxOccurs(Decimal value) { }

	// RVA: 0x1A3A57C Offset: 0x1A3657C VA: 0x1A3A57C
	internal Decimal get_MinOccurs() { }

	// RVA: 0x1A3A588 Offset: 0x1A36588 VA: 0x1A3A588
	internal void set_MinOccurs(Decimal value) { }

	// RVA: 0x1A3A590 Offset: 0x1A36590 VA: 0x1A3A590
	internal void SetKeyValues(DataKey key, object[] keyValues, int record) { }

	// RVA: 0x1A3A624 Offset: 0x1A36624 VA: 0x1A3A624
	internal DataRow FindByIndex(Index ndx, object[] key) { }

	// RVA: 0x1A3A6BC Offset: 0x1A366BC VA: 0x1A3A6BC
	internal DataRow FindMergeTarget(DataRow row, DataKey key, Index ndx) { }

	// RVA: 0x1A3A73C Offset: 0x1A3673C VA: 0x1A3A73C
	private void SetMergeRecords(DataRow row, int newRecord, int oldRecord, DataRowAction action) { }

	// RVA: 0x1A3AAAC Offset: 0x1A36AAC VA: 0x1A3AAAC
	internal DataRow MergeRow(DataRow row, DataRow targetRow, bool preserveChanges, Index idxSearch) { }

	// RVA: 0x1A3B530 Offset: 0x1A37530 VA: 0x1A3B530 Slot: 15
	protected virtual DataTable CreateInstance() { }

	// RVA: 0x1A3B5BC Offset: 0x1A375BC VA: 0x1A3B5BC Slot: 16
	public virtual DataTable Clone() { }

	// RVA: 0x1A3B5C4 Offset: 0x1A375C4 VA: 0x1A3B5C4
	internal DataTable Clone(DataSet cloneDS) { }

	// RVA: 0x1A3B798 Offset: 0x1A37798 VA: 0x1A3B798
	private DataTable IncrementalCloneTo(DataTable sourceTable, DataTable targetTable) { }

	// RVA: 0x1A3BAA4 Offset: 0x1A37AA4 VA: 0x1A3BAA4
	private DataTable CloneHierarchy(DataTable sourceTable, DataSet ds, Hashtable visitedMap) { }

	// RVA: 0x1A32C70 Offset: 0x1A2EC70 VA: 0x1A32C70
	private DataTable CloneTo(DataTable clone, DataSet cloneDS, bool skipExpressionColumns) { }

	// RVA: 0x1A3BEE8 Offset: 0x1A37EE8 VA: 0x1A3BEE8 Slot: 7
	public override ISite get_Site() { }

	// RVA: 0x1A3BEF0 Offset: 0x1A37EF0 VA: 0x1A3BEF0
	internal void AddRow(DataRow row, int proposedID) { }

	// RVA: 0x1A3BF00 Offset: 0x1A37F00 VA: 0x1A3BF00
	internal void InsertRow(DataRow row, int proposedID, int pos) { }

	// RVA: 0x1A3BF0C Offset: 0x1A37F0C VA: 0x1A3BF0C
	internal void InsertRow(DataRow row, long proposedID, int pos, bool fireEvent) { }

	// RVA: 0x1A3CBBC Offset: 0x1A38BBC VA: 0x1A3CBBC
	internal void CheckNotModifying(DataRow row) { }

	// RVA: 0x1A3CBE4 Offset: 0x1A38BE4 VA: 0x1A3CBE4
	public void Clear() { }

	// RVA: 0x1A3CBEC Offset: 0x1A38BEC VA: 0x1A3CBEC
	internal void Clear(bool clearAll) { }

	// RVA: 0x1A3D518 Offset: 0x1A39518 VA: 0x1A3D518
	internal void CascadeAll(DataRow row, DataRowAction action) { }

	// RVA: 0x1A3D5D0 Offset: 0x1A395D0 VA: 0x1A3D5D0
	internal void CommitRow(DataRow row) { }

	// RVA: 0x1A3D788 Offset: 0x1A39788 VA: 0x1A3D788
	internal int Compare(string s1, string s2) { }

	// RVA: 0x1A3D790 Offset: 0x1A39790 VA: 0x1A3D790
	internal int Compare(string s1, string s2, CompareInfo comparer) { }

	// RVA: 0x1A3D8F4 Offset: 0x1A398F4 VA: 0x1A3D8F4
	internal int IndexOf(string s1, string s2) { }

	// RVA: 0x1A3D934 Offset: 0x1A39934 VA: 0x1A3D934
	internal bool IsSuffix(string s1, string s2) { }

	// RVA: 0x1A3D974 Offset: 0x1A39974 VA: 0x1A3D974
	internal void DeleteRow(DataRow row) { }

	// RVA: 0x1A3D9CC Offset: 0x1A399CC VA: 0x1A3D9CC
	internal string FormatSortString(IndexField[] indexDesc) { }

	// RVA: 0x1A3DAF4 Offset: 0x1A39AF4 VA: 0x1A3DAF4
	internal void FreeRecord(ref int record) { }

	// RVA: 0x1A3DB0C Offset: 0x1A39B0C VA: 0x1A3DB0C
	internal Index GetIndex(string sort, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1A3DEBC Offset: 0x1A39EBC VA: 0x1A3DEBC
	internal Index GetIndex(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1A3E088 Offset: 0x1A3A088 VA: 0x1A3E088
	internal List<DataViewListener> GetListeners() { }

	// RVA: 0x1A37CAC Offset: 0x1A33CAC VA: 0x1A37CAC
	internal int GetSpecialHashCode(string name) { }

	// RVA: 0x1A3B0A4 Offset: 0x1A370A4 VA: 0x1A3B0A4
	internal void InsertRow(DataRow row, long proposedID) { }

	// RVA: 0x1A3ED14 Offset: 0x1A3AD14 VA: 0x1A3ED14
	internal int NewRecord() { }

	// RVA: 0x1A3EE00 Offset: 0x1A3AE00 VA: 0x1A3EE00
	internal int NewUninitializedRecord() { }

	// RVA: 0x1A3ED1C Offset: 0x1A3AD1C VA: 0x1A3ED1C
	internal int NewRecord(int sourceRecord) { }

	// RVA: 0x1A36274 Offset: 0x1A32274 VA: 0x1A36274
	internal DataRow NewEmptyRow() { }

	// RVA: 0x1A3EE18 Offset: 0x1A3AE18 VA: 0x1A3EE18
	private DataRow NewUninitializedRow() { }

	// RVA: 0x1A3EED0 Offset: 0x1A3AED0 VA: 0x1A3EED0
	public DataRow NewRow() { }

	// RVA: 0x1A3EF88 Offset: 0x1A3AF88 VA: 0x1A3EF88
	internal DataRow CreateEmptyRow() { }

	// RVA: 0x1A3EF04 Offset: 0x1A3AF04 VA: 0x1A3EF04
	private void NewRowCreated(DataRow row) { }

	// RVA: 0x1A3EE44 Offset: 0x1A3AE44 VA: 0x1A3EE44
	internal DataRow NewRow(int record) { }

	// RVA: 0x1A3F32C Offset: 0x1A3B32C VA: 0x1A3F32C Slot: 17
	protected virtual DataRow NewRowFromBuilder(DataRowBuilder builder) { }

	// RVA: 0x1A3F388 Offset: 0x1A3B388 VA: 0x1A3F388 Slot: 18
	protected virtual Type GetRowType() { }

	// RVA: 0x1A3F3E8 Offset: 0x1A3B3E8 VA: 0x1A3F3E8
	protected internal DataRow[] NewRowArray(int size) { }

	// RVA: 0x1A3F5A0 Offset: 0x1A3B5A0 VA: 0x1A3F5A0
	internal bool get_NeedColumnChangeEvents() { }

	// RVA: 0x1A3F5D4 Offset: 0x1A3B5D4 VA: 0x1A3F5D4 Slot: 19
	protected internal virtual void OnColumnChanging(DataColumnChangeEventArgs e) { }

	// RVA: 0x1A3F6A4 Offset: 0x1A3B6A4 VA: 0x1A3F6A4 Slot: 20
	protected internal virtual void OnColumnChanged(DataColumnChangeEventArgs e) { }

	// RVA: 0x1A3F774 Offset: 0x1A3B774 VA: 0x1A3F774 Slot: 21
	protected virtual void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x1A3F844 Offset: 0x1A3B844 VA: 0x1A3F844
	internal void OnRemoveColumnInternal(DataColumn column) { }

	// RVA: 0x1A3F854 Offset: 0x1A3B854 VA: 0x1A3F854 Slot: 22
	protected virtual void OnRemoveColumn(DataColumn column) { }

	// RVA: 0x1A3D6E4 Offset: 0x1A396E4 VA: 0x1A3D6E4
	private DataRowChangeEventArgs OnRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x1A3D640 Offset: 0x1A39640 VA: 0x1A3D640
	private DataRowChangeEventArgs OnRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x1A3F858 Offset: 0x1A3B858 VA: 0x1A3F858 Slot: 23
	protected virtual void OnRowChanged(DataRowChangeEventArgs e) { }

	// RVA: 0x1A3F928 Offset: 0x1A3B928 VA: 0x1A3F928 Slot: 24
	protected virtual void OnRowChanging(DataRowChangeEventArgs e) { }

	// RVA: 0x1A3F9F8 Offset: 0x1A3B9F8 VA: 0x1A3F9F8 Slot: 25
	protected virtual void OnRowDeleting(DataRowChangeEventArgs e) { }

	// RVA: 0x1A3FAC8 Offset: 0x1A3BAC8 VA: 0x1A3FAC8 Slot: 26
	protected virtual void OnRowDeleted(DataRowChangeEventArgs e) { }

	// RVA: 0x1A3FB98 Offset: 0x1A3BB98 VA: 0x1A3FB98 Slot: 27
	protected virtual void OnTableCleared(DataTableClearEventArgs e) { }

	// RVA: 0x1A3FC68 Offset: 0x1A3BC68 VA: 0x1A3FC68 Slot: 28
	protected virtual void OnTableClearing(DataTableClearEventArgs e) { }

	// RVA: 0x1A3FD38 Offset: 0x1A3BD38 VA: 0x1A3FD38 Slot: 29
	protected virtual void OnTableNewRow(DataTableNewRowEventArgs e) { }

	// RVA: 0x1A3DB40 Offset: 0x1A39B40 VA: 0x1A3DB40
	internal IndexField[] ParseSortString(string sortString) { }

	// RVA: 0x1A38FCC Offset: 0x1A34FCC VA: 0x1A38FCC
	internal void RaisePropertyChanging(string name) { }

	// RVA: 0x1A3FE08 Offset: 0x1A3BE08 VA: 0x1A3FE08
	internal void RecordChanged(int record) { }

	// RVA: 0x1A3FF60 Offset: 0x1A3BF60 VA: 0x1A3FF60
	internal void RecordChanged(int[] oldIndex, int[] newIndex) { }

	// RVA: 0x1A3E224 Offset: 0x1A3A224 VA: 0x1A3E224
	internal void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x1A3E394 Offset: 0x1A3A394 VA: 0x1A3E394
	internal void RecordStateChanged(int record1, DataViewRowState oldState1, DataViewRowState newState1, int record2, DataViewRowState oldState2, DataViewRowState newState2) { }

	// RVA: 0x1A40114 Offset: 0x1A3C114 VA: 0x1A40114
	internal int[] RemoveRecordFromIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A402C4 Offset: 0x1A3C2C4 VA: 0x1A402C4
	internal int[] InsertRecordToIndexes(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A4043C Offset: 0x1A3C43C VA: 0x1A4043C
	internal void SilentlySetValue(DataRow dr, DataColumn dc, DataRowVersion version, object newValue) { }

	// RVA: 0x1A40D08 Offset: 0x1A3CD08 VA: 0x1A40D08
	internal void RemoveRow(DataRow row, bool check) { }

	// RVA: 0x1A40EA8 Offset: 0x1A3CEA8 VA: 0x1A40EA8 Slot: 30
	public virtual void Reset() { }

	// RVA: 0x1A32C68 Offset: 0x1A2EC68 VA: 0x1A32C68
	internal void ResetIndexes() { }

	// RVA: 0x1A41110 Offset: 0x1A3D110 VA: 0x1A41110
	internal void ResetInternalIndexes(DataColumn column) { }

	// RVA: 0x1A412CC Offset: 0x1A3D2CC VA: 0x1A412CC
	internal void RollbackRow(DataRow row) { }

	// RVA: 0x1A3EAF4 Offset: 0x1A3AAF4 VA: 0x1A3EAF4
	private DataRowChangeEventArgs RaiseRowChanged(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x1A41338 Offset: 0x1A3D338 VA: 0x1A41338
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction) { }

	// RVA: 0x1A3E090 Offset: 0x1A3A090 VA: 0x1A3E090
	private DataRowChangeEventArgs RaiseRowChanging(DataRowChangeEventArgs args, DataRow eRow, DataRowAction eAction, bool fireEvent) { }

	// RVA: 0x1A3A7E8 Offset: 0x1A367E8 VA: 0x1A3A7E8
	internal void SetNewRecord(DataRow row, int proposedRecord, DataRowAction action = 2, bool isInMerge = False, bool fireEvent = True, bool suppressEnsurePropertyChanged = False) { }

	// RVA: 0x1A3C2B8 Offset: 0x1A382B8 VA: 0x1A3C2B8
	private void SetNewRecordWorker(DataRow row, int proposedRecord, DataRowAction action, bool isInMerge, bool suppressEnsurePropertyChanged, int position, bool fireEvent, out Exception deferredException) { }

	// RVA: 0x1A3A838 Offset: 0x1A36838 VA: 0x1A3A838
	internal void SetOldRecord(DataRow row, int proposedRecord) { }

	// RVA: 0x1A41538 Offset: 0x1A3D538 VA: 0x1A41538
	private void RestoreShadowIndexes() { }

	// RVA: 0x1A36A54 Offset: 0x1A32A54 VA: 0x1A36A54
	private void SetShadowIndexes() { }

	// RVA: 0x1A41558 Offset: 0x1A3D558 VA: 0x1A41558
	internal void ShadowIndexCopy() { }

	// RVA: 0x1A415EC Offset: 0x1A3D5EC VA: 0x1A415EC Slot: 3
	public override string ToString() { }

	// RVA: 0x1A41318 Offset: 0x1A3D318 VA: 0x1A41318
	internal bool UpdatingCurrent(DataRow row, DataRowAction action) { }

	// RVA: 0x1A41660 Offset: 0x1A3D660 VA: 0x1A41660
	internal DataColumn AddUniqueKey(int position) { }

	// RVA: 0x1A418D4 Offset: 0x1A3D8D4 VA: 0x1A418D4
	internal DataColumn AddUniqueKey() { }

	// RVA: 0x1A418DC Offset: 0x1A3D8DC VA: 0x1A418DC
	internal DataColumn AddForeignKey(DataColumn parentKey) { }

	// RVA: 0x1A41988 Offset: 0x1A3D988 VA: 0x1A41988
	internal void UpdatePropertyDescriptorCollectionCache() { }

	// RVA: 0x1A4199C Offset: 0x1A3D99C VA: 0x1A4199C
	internal PropertyDescriptorCollection GetPropertyDescriptorCollection(Attribute[] attributes) { }

	// RVA: 0x1A33B84 Offset: 0x1A2FB84 VA: 0x1A33B84
	internal XmlQualifiedName get_TypeName() { }

	// RVA: 0x1A41C08 Offset: 0x1A3DC08 VA: 0x1A41C08
	internal void set_TypeName(XmlQualifiedName value) { }

	// RVA: 0x1A41C18 Offset: 0x1A3DC18 VA: 0x1A41C18
	public void Merge(DataTable table) { }

	// RVA: 0x1A41C24 Offset: 0x1A3DC24 VA: 0x1A41C24
	public void Merge(DataTable table, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x1A41E68 Offset: 0x1A3DE68 VA: 0x1A41E68
	public void WriteXml(XmlWriter writer, XmlWriteMode mode, bool writeHierarchy) { }

	// RVA: 0x1A42204 Offset: 0x1A3E204 VA: 0x1A42204
	private bool CheckForClosureOnExpressions(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1A33C88 Offset: 0x1A2FC88 VA: 0x1A33C88
	private bool CheckForClosureOnExpressionTables(List<DataTable> tableList) { }

	// RVA: 0x1A426C4 Offset: 0x1A3E6C4 VA: 0x1A426C4
	public void WriteXmlSchema(XmlWriter writer, bool writeHierarchy) { }

	// RVA: 0x1A429E4 Offset: 0x1A3E9E4 VA: 0x1A429E4
	private void RestoreConstraint(bool originalEnforceConstraint) { }

	// RVA: 0x1A42A38 Offset: 0x1A3EA38 VA: 0x1A42A38
	private bool IsEmptyXml(XmlReader reader) { }

	// RVA: 0x1A42C08 Offset: 0x1A3EC08 VA: 0x1A42C08
	internal XmlReadMode ReadXml(XmlReader reader, XmlReadMode mode, bool denyResolving) { }

	// RVA: 0x1A444D4 Offset: 0x1A404D4 VA: 0x1A444D4
	internal void ReadEndElement(XmlReader reader) { }

	// RVA: 0x1A44570 Offset: 0x1A40570 VA: 0x1A44570
	internal void ReadXDRSchema(XmlReader reader) { }

	// RVA: 0x1A458B4 Offset: 0x1A418B4 VA: 0x1A458B4
	internal bool MoveToElement(XmlReader reader, int depth) { }

	// RVA: 0x1A43B08 Offset: 0x1A3FB08 VA: 0x1A43B08
	private void ReadXmlDiffgram(XmlReader reader) { }

	// RVA: 0x1A45968 Offset: 0x1A41968 VA: 0x1A45968
	internal void ReadXSDSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x1A445E0 Offset: 0x1A405E0 VA: 0x1A445E0
	internal void ReadXmlSchema(XmlReader reader, bool denyResolving) { }

	// RVA: 0x1A42318 Offset: 0x1A3E318 VA: 0x1A42318
	private void CreateTableList(DataTable currentTable, List<DataTable> tableList) { }

	// RVA: 0x1A45AFC Offset: 0x1A41AFC VA: 0x1A45AFC
	private void CreateRelationList(List<DataTable> tableList, List<DataRelation> relationList) { }

	// RVA: 0x1A45FC4 Offset: 0x1A41FC4 VA: 0x1A45FC4
	public static XmlSchemaComplexType GetDataTableSchema(XmlSchemaSet schemaSet) { }

	// RVA: 0x1A46210 Offset: 0x1A42210 VA: 0x1A46210 Slot: 11
	private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { }

	// RVA: 0x1A46220 Offset: 0x1A42220 VA: 0x1A46220 Slot: 31
	protected virtual XmlSchema GetSchema() { }

	// RVA: 0x1A463E8 Offset: 0x1A423E8 VA: 0x1A463E8 Slot: 12
	private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader) { }

	// RVA: 0x1A46594 Offset: 0x1A42594 VA: 0x1A46594 Slot: 13
	private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer) { }

	// RVA: 0x1A465C8 Offset: 0x1A425C8 VA: 0x1A465C8 Slot: 32
	protected virtual void ReadXmlSerializable(XmlReader reader) { }

	// RVA: 0x1A465D4 Offset: 0x1A425D4 VA: 0x1A465D4
	internal Hashtable get_RowDiffId() { }

	// RVA: 0x1A46648 Offset: 0x1A42648 VA: 0x1A46648
	internal int get_ObjectID() { }

	// RVA: 0x1A46650 Offset: 0x1A42650 VA: 0x1A46650
	internal void AddDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x1A46788 Offset: 0x1A42788 VA: 0x1A46788
	internal void RemoveDependentColumn(DataColumn expressionColumn) { }

	// RVA: 0x1A46818 Offset: 0x1A42818 VA: 0x1A46818
	internal void EvaluateExpressions() { }

	// RVA: 0x1A3E588 Offset: 0x1A3A588 VA: 0x1A3E588
	internal void EvaluateExpressions(DataRow row, DataRowAction action, List<DataRow> cachedRows) { }

	// RVA: 0x1A46B5C Offset: 0x1A42B5C VA: 0x1A46B5C
	internal void EvaluateExpressions(DataColumn column) { }

	// RVA: 0x1A3D3C8 Offset: 0x1A393C8 VA: 0x1A3D3C8
	internal void EvaluateDependentExpressions(DataColumn column) { }

	// RVA: 0x1A405AC Offset: 0x1A3C5AC VA: 0x1A405AC
	internal void EvaluateDependentExpressions(List<DataColumn> columns, DataRow row, DataRowVersion version, List<DataRow> cachedRows) { }
}

// Namespace: System.Data
internal sealed class FunctionNode : ExpressionNode // TypeDefIndex: 4436
{
	// Fields
	internal readonly string _name; // 0x18
	internal readonly int _info; // 0x20
	internal int _argumentCount; // 0x24
	internal ExpressionNode[] _arguments; // 0x28
	[Nullable(2)]
	private readonly TypeLimiter _capturedLimiter; // 0x30
	private static readonly Function[] s_funcs; // 0x0

	// Properties
	internal FunctionId Aggregate { get; }
	internal bool IsAggregate { get; }

	// Methods

	// RVA: 0x1A5F6E0 Offset: 0x1A5B6E0 VA: 0x1A5F6E0
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x1A5F838 Offset: 0x1A5B838 VA: 0x1A5F838
	internal void AddArgument(ExpressionNode argument) { }

	// RVA: 0x1A5FA1C Offset: 0x1A5BA1C VA: 0x1A5FA1C Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1A5FEE8 Offset: 0x1A5BEE8 VA: 0x1A5FEE8 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1A5FEFC Offset: 0x1A5BEFC VA: 0x1A5FEFC Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A62054 Offset: 0x1A5E054 VA: 0x1A62054 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x1A62088 Offset: 0x1A5E088 VA: 0x1A62088 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1A62110 Offset: 0x1A5E110 VA: 0x1A62110 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1A6218C Offset: 0x1A5E18C VA: 0x1A6218C Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1A62208 Offset: 0x1A5E208 VA: 0x1A62208 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1A62284 Offset: 0x1A5E284 VA: 0x1A62284 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x1A6230C Offset: 0x1A5E30C VA: 0x1A6230C Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x1A60808 Offset: 0x1A5C808 VA: 0x1A60808
	private Type GetDataType(ExpressionNode node) { }

	// RVA: 0x1A60A80 Offset: 0x1A5CA80 VA: 0x1A60A80
	private object EvalFunction(FunctionId id, object[] argumentValues, DataRow row, DataRowVersion version) { }

	// RVA: 0x1A624D0 Offset: 0x1A5E4D0 VA: 0x1A624D0
	internal FunctionId get_Aggregate() { }

	// RVA: 0x1A6256C Offset: 0x1A5E56C VA: 0x1A6256C
	internal bool get_IsAggregate() { }

	// RVA: 0x1A5FD08 Offset: 0x1A5BD08 VA: 0x1A5FD08
	internal void Check() { }

	// RVA: 0x1A6279C Offset: 0x1A5E79C VA: 0x1A6279C
	private static void .cctor() { }
}

// Namespace: System.Data
internal enum FunctionId // TypeDefIndex: 4437
{
	// Fields
	public int value__; // 0x0
	public const FunctionId none = -1;
	public const FunctionId Ascii = 0;
	public const FunctionId Char = 1;
	public const FunctionId Charindex = 2;
	public const FunctionId Difference = 3;
	public const FunctionId Len = 4;
	public const FunctionId Lower = 5;
	public const FunctionId LTrim = 6;
	public const FunctionId Patindex = 7;
	public const FunctionId Replicate = 8;
	public const FunctionId Reverse = 9;
	public const FunctionId Right = 10;
	public const FunctionId RTrim = 11;
	public const FunctionId Soundex = 12;
	public const FunctionId Space = 13;
	public const FunctionId Str = 14;
	public const FunctionId Stuff = 15;
	public const FunctionId Substring = 16;
	public const FunctionId Upper = 17;
	public const FunctionId IsNull = 18;
	public const FunctionId Iif = 19;
	public const FunctionId Convert = 20;
	public const FunctionId cInt = 21;
	public const FunctionId cBool = 22;
	public const FunctionId cDate = 23;
	public const FunctionId cDbl = 24;
	public const FunctionId cStr = 25;
	public const FunctionId Abs = 26;
	public const FunctionId Acos = 27;
	public const FunctionId In = 28;
	public const FunctionId Trim = 29;
	public const FunctionId Sum = 30;
	public const FunctionId Avg = 31;
	public const FunctionId Min = 32;
	public const FunctionId Max = 33;
	public const FunctionId Count = 34;
	public const FunctionId StDev = 35;
	public const FunctionId Var = 37;
	public const FunctionId DateTimeOffset = 38;
}

// Namespace: System.Data
internal sealed class Function // TypeDefIndex: 4438
{
	// Fields
	internal readonly string _name; // 0x10
	internal readonly FunctionId _id; // 0x18
	internal readonly Type _result; // 0x20
	internal readonly bool _isValidateArguments; // 0x28
	internal readonly bool _isVariantArgumentList; // 0x29
	internal readonly int _argumentCount; // 0x2C
	internal readonly Type[] _parameters; // 0x30
	internal static string[] s_functionName; // 0x0

	// Methods

	// RVA: 0x1A631C0 Offset: 0x1A5F1C0 VA: 0x1A631C0
	internal void .ctor(string name, FunctionId id, Type result, bool IsValidateArguments, bool IsVariantArgumentList, int argumentCount, Type a1, Type a2, Type a3) { }

	// RVA: 0x1A63400 Offset: 0x1A5F400 VA: 0x1A63400
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TypeLimiter.Scope.<>c // TypeDefIndex: 4439
{
	// Fields
	public static readonly TypeLimiter.Scope.<>c <>9; // 0x0
	public static Func<Type, bool> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x1A65094 Offset: 0x1A61094 VA: 0x1A65094
	private static void .cctor() { }

	// RVA: 0x1A650FC Offset: 0x1A610FC VA: 0x1A650FC
	public void .ctor() { }

	// RVA: 0x1A65104 Offset: 0x1A61104 VA: 0x1A65104
	internal bool <.ctor>b__3_0(Type type) { }
}

// Namespace: 
private sealed class TypeLimiter.Scope : IDisposable // TypeDefIndex: 4440
{
	// Fields
	private static readonly HashSet<Type> s_allowedTypes; // 0x0
	private HashSet<Type> m_allowedTypes; // 0x10
	[Nullable(2)]
	private readonly TypeLimiter.Scope m_previousScope; // 0x18

	// Methods

	// RVA: 0x1A641EC Offset: 0x1A601EC VA: 0x1A641EC
	internal void .ctor(TypeLimiter.Scope previousScope, IEnumerable<Type> allowedTypes) { }

	// RVA: 0x1A645D4 Offset: 0x1A605D4 VA: 0x1A645D4 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A63DFC Offset: 0x1A5FDFC VA: 0x1A63DFC
	public bool IsAllowedType(Type type) { }

	// RVA: 0x1A646A8 Offset: 0x1A606A8 VA: 0x1A646A8
	private static bool IsTypeUnconditionallyAllowed(Type type) { }

	// RVA: 0x1A64860 Offset: 0x1A60860 VA: 0x1A64860
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TypeLimiter.<>c // TypeDefIndex: 4441
{
	// Fields
	public static readonly TypeLimiter.<>c <>9; // 0x0
	public static Func<DataColumn, Type> <>9__10_0; // 0x8
	public static Func<DataTable, IEnumerable<Type>> <>9__11_0; // 0x10

	// Methods

	// RVA: 0x1A65138 Offset: 0x1A61138 VA: 0x1A65138
	private static void .cctor() { }

	// RVA: 0x1A651A0 Offset: 0x1A611A0 VA: 0x1A651A0
	public void .ctor() { }

	// RVA: 0x1A651A8 Offset: 0x1A611A8 VA: 0x1A651A8
	internal Type <GetPreviouslyDeclaredDataTypes>b__10_0(DataColumn column) { }

	// RVA: 0x1A651BC Offset: 0x1A611BC VA: 0x1A651BC
	internal IEnumerable<Type> <GetPreviouslyDeclaredDataTypes>b__11_0(DataTable table) { }
}

// Namespace: System.Data
internal sealed class TypeLimiter // TypeDefIndex: 4442
{
	// Fields
	[ThreadStatic]
	[Nullable(2)]
	private static TypeLimiter.Scope s_activeScope; // 0x80000000
	private TypeLimiter.Scope m_instanceScope; // 0x10

	// Properties
	private static bool IsTypeLimitingDisabled { get; }

	// Methods

	// RVA: 0x1A63C40 Offset: 0x1A5FC40 VA: 0x1A63C40
	private void .ctor(TypeLimiter.Scope scope) { }

	// RVA: 0x1A63C70 Offset: 0x1A5FC70 VA: 0x1A63C70
	private static bool get_IsTypeLimitingDisabled() { }

	[NullableContext(2)]
	// RVA: 0x1A63CE8 Offset: 0x1A5FCE8 VA: 0x1A63CE8
	public static TypeLimiter Capture() { }

	[NullableContext(2)]
	// RVA: 0x1A63D64 Offset: 0x1A5FD64 VA: 0x1A63D64
	public static void EnsureTypeIsAllowed(Type type, TypeLimiter capturedLimiter) { }

	// RVA: 0x1A63F88 Offset: 0x1A5FF88 VA: 0x1A63F88
	public static IDisposable EnterRestrictedScope(DataSet dataSet) { }

	// RVA: 0x1A64370 Offset: 0x1A60370 VA: 0x1A64370
	public static IDisposable EnterRestrictedScope(DataTable dataTable) { }

	// RVA: 0x1A64430 Offset: 0x1A60430 VA: 0x1A64430
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataTable dataTable) { }

	// RVA: 0x1A64048 Offset: 0x1A60048 VA: 0x1A64048
	private static IEnumerable<Type> GetPreviouslyDeclaredDataTypes(DataSet dataSet) { }
}

// Namespace: System.Data
public enum AcceptRejectRule // TypeDefIndex: 4443
{
	// Fields
	public int value__; // 0x0
	public const AcceptRejectRule None = 0;
	public const AcceptRejectRule Cascade = 1;
}

// Namespace: System.Data
internal enum AggregateType // TypeDefIndex: 4444
{
	// Fields
	public int value__; // 0x0
	public const AggregateType None = 0;
	public const AggregateType Sum = 4;
	public const AggregateType Mean = 5;
	public const AggregateType Min = 6;
	public const AggregateType Max = 7;
	public const AggregateType First = 8;
	public const AggregateType Count = 9;
	public const AggregateType Var = 10;
	public const AggregateType StDev = 11;
}

// Namespace: System.Data
public class InternalDataCollectionBase : ICollection, IEnumerable // TypeDefIndex: 4445
{
	// Fields
	internal static readonly CollectionChangeEventArgs s_refreshEventArgs; // 0x0

	// Properties
	[Browsable(False)]
	public virtual int Count { get; }
	[Browsable(False)]
	public bool IsSynchronized { get; }
	[Browsable(False)]
	public object SyncRoot { get; }
	protected virtual ArrayList List { get; }

	// Methods

	// RVA: 0x1A651C4 Offset: 0x1A611C4 VA: 0x1A651C4 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x1A651F0 Offset: 0x1A611F0 VA: 0x1A651F0 Slot: 10
	public virtual void CopyTo(Array ar, int index) { }

	// RVA: 0x1A65238 Offset: 0x1A61238 VA: 0x1A65238 Slot: 11
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1A65264 Offset: 0x1A61264 VA: 0x1A65264 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x1A6526C Offset: 0x1A6126C VA: 0x1A6526C
	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	// RVA: 0x1A65318 Offset: 0x1A61318 VA: 0x1A65318 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1A6531C Offset: 0x1A6131C VA: 0x1A6531C Slot: 12
	protected virtual ArrayList get_List() { }

	// RVA: 0x1A65324 Offset: 0x1A61324 VA: 0x1A65324
	public void .ctor() { }

	// RVA: 0x1A6532C Offset: 0x1A6132C VA: 0x1A6532C
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class ColumnTypeConverter : TypeConverter // TypeDefIndex: 4446
{
	// Fields
	private static readonly Type[] s_types; // 0x0
	private TypeConverter.StandardValuesCollection _values; // 0x10

	// Methods

	// RVA: 0x1A653B0 Offset: 0x1A613B0 VA: 0x1A653B0
	public void .ctor() { }

	// RVA: 0x1A653B8 Offset: 0x1A613B8 VA: 0x1A653B8 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1A65468 Offset: 0x1A61468 VA: 0x1A65468 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1A6591C Offset: 0x1A6191C VA: 0x1A6591C Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1A659A8 Offset: 0x1A619A8 VA: 0x1A659A8 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1A65B80 Offset: 0x1A61B80 VA: 0x1A65B80 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1A65CA0 Offset: 0x1A61CA0 VA: 0x1A65CA0 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1A65CA8 Offset: 0x1A61CA8 VA: 0x1A65CA8 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1A65CB0 Offset: 0x1A61CB0 VA: 0x1A65CB0
	private static void .cctor() { }
}

// Namespace: System.Data
[EventSource(Name = "System.Data.DataCommonEventSource")]
internal class DataCommonEventSource : EventSource // TypeDefIndex: 4447
{
	// Fields
	internal static readonly DataCommonEventSource Log; // 0x0
	private static long s_nextScopeId; // 0x8

	// Methods

	[Event(1, Level = 4)]
	// RVA: 0x1A66888 Offset: 0x1A62888 VA: 0x1A66888
	internal void Trace(string message) { }

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0>(string format, T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F5B20 Offset: 0x10F1B20 VA: 0x10F5B20
	|-DataCommonEventSource.Trace<int>
	|
	|-RVA: 0x10F5BE4 Offset: 0x10F1BE4 VA: 0x10F5BE4
	|-DataCommonEventSource.Trace<object>
	|
	|-RVA: 0x10F5C90 Offset: 0x10F1C90 VA: 0x10F5C90
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1>(string format, T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F5DD8 Offset: 0x10F1DD8 VA: 0x10F5DD8
	|-DataCommonEventSource.Trace<int, bool>
	|
	|-RVA: 0x10F5EC0 Offset: 0x10F1EC0 VA: 0x10F5EC0
	|-DataCommonEventSource.Trace<int, int>
	|
	|-RVA: 0x10F5FA4 Offset: 0x10F1FA4 VA: 0x10F5FA4
	|-DataCommonEventSource.Trace<int, Int32Enum>
	|
	|-RVA: 0x10F6088 Offset: 0x10F2088 VA: 0x10F6088
	|-DataCommonEventSource.Trace<int, long>
	|
	|-RVA: 0x10F6178 Offset: 0x10F2178 VA: 0x10F6178
	|-DataCommonEventSource.Trace<int, object>
	|
	|-RVA: 0x10F6244 Offset: 0x10F2244 VA: 0x10F6244
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2>(string format, T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F63E8 Offset: 0x10F23E8 VA: 0x10F63E8
	|-DataCommonEventSource.Trace<int, int, bool>
	|
	|-RVA: 0x10F64F8 Offset: 0x10F24F8 VA: 0x10F64F8
	|-DataCommonEventSource.Trace<int, int, int>
	|
	|-RVA: 0x10F6604 Offset: 0x10F2604 VA: 0x10F6604
	|-DataCommonEventSource.Trace<int, int, Int32Enum>
	|
	|-RVA: 0x10F6710 Offset: 0x10F2710 VA: 0x10F6710
	|-DataCommonEventSource.Trace<int, object, Int32Enum>
	|
	|-RVA: 0x10F6804 Offset: 0x10F2804 VA: 0x10F6804
	|-DataCommonEventSource.Trace<int, object, object>
	|
	|-RVA: 0x10F68E0 Offset: 0x10F28E0 VA: 0x10F68E0
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F6AEC Offset: 0x10F2AEC VA: 0x10F6AEC
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0x10F6D1C Offset: 0x10F2D1C VA: 0x10F6D1C
	|-DataCommonEventSource.Trace<int, object, object, Int32Enum>
	|
	|-RVA: 0x10F6F14 Offset: 0x10F2F14 VA: 0x10F6F14
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F72AC Offset: 0x10F32AC VA: 0x10F72AC
	|-DataCommonEventSource.Trace<int, object, int, int, bool>
	|
	|-RVA: 0x10F7518 Offset: 0x10F3518 VA: 0x10F7518
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal void Trace<T0, T1, T2, T3, T4, T5, T6>(string format, T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F793C Offset: 0x10F393C VA: 0x10F793C
	|-DataCommonEventSource.Trace<int, int, Int32Enum, Int32Enum, int, Int32Enum, Int32Enum>
	|
	|-RVA: 0x10F7C64 Offset: 0x10F3C64 VA: 0x10F7C64
	|-DataCommonEventSource.Trace<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Event(2, Level = 5)]
	// RVA: 0x1A66898 Offset: 0x1A62898 VA: 0x1A66898
	internal long EnterScope(string message) { }

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1>(string format, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F47A0 Offset: 0x10F07A0 VA: 0x10F47A0
	|-DataCommonEventSource.EnterScope<int>
	|
	|-RVA: 0x10F486C Offset: 0x10F086C VA: 0x10F486C
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2>(string format, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F49BC Offset: 0x10F09BC VA: 0x10F49BC
	|-DataCommonEventSource.EnterScope<int, bool>
	|
	|-RVA: 0x10F4AAC Offset: 0x10F0AAC VA: 0x10F4AAC
	|-DataCommonEventSource.EnterScope<int, int>
	|
	|-RVA: 0x10F4B98 Offset: 0x10F0B98 VA: 0x10F4B98
	|-DataCommonEventSource.EnterScope<int, Int32Enum>
	|
	|-RVA: 0x10F4C84 Offset: 0x10F0C84 VA: 0x10F4C84
	|-DataCommonEventSource.EnterScope<int, object>
	|
	|-RVA: 0x10F4D58 Offset: 0x10F0D58 VA: 0x10F4D58
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3>(string format, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F4F04 Offset: 0x10F0F04 VA: 0x10F4F04
	|-DataCommonEventSource.EnterScope<int, int, bool>
	|
	|-RVA: 0x10F501C Offset: 0x10F101C VA: 0x10F501C
	|-DataCommonEventSource.EnterScope<int, int, object>
	|
	|-RVA: 0x10F5118 Offset: 0x10F1118 VA: 0x10F5118
	|-DataCommonEventSource.EnterScope<int, Int32Enum, bool>
	|
	|-RVA: 0x10F5230 Offset: 0x10F1230 VA: 0x10F5230
	|-DataCommonEventSource.EnterScope<int, object, bool>
	|
	|-RVA: 0x10F5330 Offset: 0x10F1330 VA: 0x10F5330
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[NonEvent]
	// RVA: -1 Offset: -1
	internal long EnterScope<T1, T2, T3, T4>(string format, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F5544 Offset: 0x10F1544 VA: 0x10F5544
	|-DataCommonEventSource.EnterScope<int, int, bool, Int32Enum>
	|
	|-RVA: 0x10F5780 Offset: 0x10F1780 VA: 0x10F5780
	|-DataCommonEventSource.EnterScope<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Event(3, Level = 5)]
	// RVA: 0x1A6695C Offset: 0x1A6295C VA: 0x1A6695C
	internal void ExitScope(long scopeId) { }

	// RVA: 0x1A6696C Offset: 0x1A6296C VA: 0x1A6696C
	public void .ctor() { }

	// RVA: 0x1A66974 Offset: 0x1A62974 VA: 0x1A66974
	private static void .cctor() { }
}

// Namespace: System.Data
[TypeConverter(typeof(ConstraintConverter))]
[DefaultProperty("ConstraintName")]
public abstract class Constraint // TypeDefIndex: 4448
{
	// Fields
	private string _schemaName; // 0x10
	private bool _inCollection; // 0x18
	private DataSet _dataSet; // 0x20
	internal string _name; // 0x28
	internal PropertyCollection _extendedProperties; // 0x30

	// Properties
	[DefaultValue("")]
	public virtual string ConstraintName { get; set; }
	internal string SchemaName { get; set; }
	internal virtual bool InCollection { get; set; }
	public abstract DataTable Table { get; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	[CLSCompliant(False)]
	protected virtual DataSet _DataSet { get; }

	// Methods

	// RVA: 0x1A669EC Offset: 0x1A629EC VA: 0x1A669EC Slot: 4
	public virtual string get_ConstraintName() { }

	// RVA: 0x1A669F4 Offset: 0x1A629F4 VA: 0x1A669F4 Slot: 5
	public virtual void set_ConstraintName(string value) { }

	// RVA: 0x1A66E48 Offset: 0x1A62E48 VA: 0x1A66E48
	internal string get_SchemaName() { }

	// RVA: 0x1A66E80 Offset: 0x1A62E80 VA: 0x1A66E80
	internal void set_SchemaName(string value) { }

	// RVA: 0x1A66EC4 Offset: 0x1A62EC4 VA: 0x1A66EC4 Slot: 6
	internal virtual bool get_InCollection() { }

	// RVA: 0x1A66ECC Offset: 0x1A62ECC VA: 0x1A66ECC Slot: 7
	internal virtual void set_InCollection(bool value) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract DataTable get_Table();

	// RVA: 0x1A66F10 Offset: 0x1A62F10 VA: 0x1A66F10
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool ContainsColumn(DataColumn column);

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool CanEnableConstraint();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract Constraint Clone(DataSet destination);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract Constraint Clone(DataSet destination, bool ignoreNSforTableLookup);

	// RVA: 0x1A66F80 Offset: 0x1A62F80 VA: 0x1A66F80
	internal void CheckConstraint() { }

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract void CheckCanAddToCollection(ConstraintCollection constraint);

	// RVA: -1 Offset: -1 Slot: 14
	internal abstract bool CanBeRemovedFromCollection(ConstraintCollection constraint, bool fThrowException);

	// RVA: -1 Offset: -1 Slot: 15
	internal abstract void CheckConstraint(DataRow row, DataRowAction action);

	// RVA: -1 Offset: -1 Slot: 16
	internal abstract void CheckState();

	// RVA: 0x1A66FD4 Offset: 0x1A62FD4 VA: 0x1A66FD4
	protected void CheckStateForProperty() { }

	// RVA: 0x1A67114 Offset: 0x1A63114 VA: 0x1A67114 Slot: 17
	protected virtual DataSet get__DataSet() { }

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract bool IsConstraintViolated();

	// RVA: 0x1A6711C Offset: 0x1A6311C VA: 0x1A6711C Slot: 3
	public override string ToString() { }

	// RVA: 0x1A67128 Offset: 0x1A63128 VA: 0x1A67128
	protected void .ctor() { }
}

// Namespace: System.Data
[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
public sealed class ConstraintCollection : InternalDataCollectionBase // TypeDefIndex: 4449
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private CollectionChangeEventHandler _onCollectionChanged; // 0x28
	private Constraint[] _delayLoadingConstraints; // 0x30
	private bool _fLoadForeignKeyConstraintsOnly; // 0x38

	// Properties
	protected override ArrayList List { get; }
	public Constraint Item { get; }
	internal DataTable Table { get; }
	public Constraint Item { get; }

	// Methods

	// RVA: 0x1A6717C Offset: 0x1A6317C VA: 0x1A6717C
	internal void .ctor(DataTable table) { }

	// RVA: 0x1A67234 Offset: 0x1A63234 VA: 0x1A67234 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x1A6723C Offset: 0x1A6323C VA: 0x1A6723C
	public Constraint get_Item(int index) { }

	// RVA: 0x1A67338 Offset: 0x1A63338 VA: 0x1A67338
	internal DataTable get_Table() { }

	// RVA: 0x1A67340 Offset: 0x1A63340 VA: 0x1A67340
	public Constraint get_Item(string name) { }

	// RVA: 0x1A67588 Offset: 0x1A63588 VA: 0x1A67588
	public void Add(Constraint constraint) { }

	// RVA: 0x1A67590 Offset: 0x1A63590 VA: 0x1A67590
	internal void Add(Constraint constraint, bool addUniqueWhenAddingForeign) { }

	// RVA: 0x1A67F18 Offset: 0x1A63F18 VA: 0x1A67F18
	public Constraint Add(string name, DataColumn[] columns, bool primaryKey) { }

	// RVA: 0x1A67B70 Offset: 0x1A63B70 VA: 0x1A67B70
	private void AddUniqueConstraint(UniqueConstraint constraint) { }

	// RVA: 0x1A67D80 Offset: 0x1A63D80 VA: 0x1A67D80
	private void AddForeignKeyConstraint(ForeignKeyConstraint constraint) { }

	// RVA: 0x1A67AA0 Offset: 0x1A63AA0 VA: 0x1A67AA0
	private bool AutoGenerated(Constraint constraint) { }

	// RVA: 0x1A67EB8 Offset: 0x1A63EB8 VA: 0x1A67EB8
	private void ArrayAdd(Constraint constraint) { }

	// RVA: 0x1A67FC0 Offset: 0x1A63FC0 VA: 0x1A67FC0
	private void ArrayRemove(Constraint constraint) { }

	// RVA: 0x1A67D5C Offset: 0x1A63D5C VA: 0x1A67D5C
	internal string AssignName() { }

	// RVA: 0x1A67DF0 Offset: 0x1A63DF0 VA: 0x1A67DF0
	private void BaseAdd(Constraint constraint) { }

	// RVA: 0x1A680B0 Offset: 0x1A640B0 VA: 0x1A680B0
	private void BaseGroupSwitch(Constraint[] oldArray, int oldLength, Constraint[] newArray, int newLength) { }

	// RVA: 0x1A68260 Offset: 0x1A64260 VA: 0x1A68260
	private void BaseRemove(Constraint constraint) { }

	// RVA: 0x1A6850C Offset: 0x1A6450C VA: 0x1A6850C
	internal bool CanRemove(Constraint constraint, bool fThrowException) { }

	// RVA: 0x1A68538 Offset: 0x1A64538 VA: 0x1A68538
	public void Clear() { }

	// RVA: 0x1A68958 Offset: 0x1A64958 VA: 0x1A68958
	public bool Contains(string name) { }

	// RVA: 0x1A68970 Offset: 0x1A64970 VA: 0x1A68970
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x1A67944 Offset: 0x1A63944 VA: 0x1A67944
	internal Constraint FindConstraint(Constraint constraint) { }

	// RVA: 0x1A67C50 Offset: 0x1A63C50 VA: 0x1A67C50
	internal UniqueConstraint FindKeyConstraint(DataColumn[] columns) { }

	// RVA: 0x1A68AF8 Offset: 0x1A64AF8 VA: 0x1A68AF8
	internal UniqueConstraint FindKeyConstraint(DataColumn column) { }

	// RVA: 0x1A68C04 Offset: 0x1A64C04 VA: 0x1A68C04
	internal ForeignKeyConstraint FindForeignKeyConstraint(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1A68A6C Offset: 0x1A64A6C VA: 0x1A68A6C
	private static bool CompareArrays(DataColumn[] a1, DataColumn[] a2) { }

	// RVA: 0x1A6742C Offset: 0x1A6342C VA: 0x1A6742C
	internal int InternalIndexOf(string constraintName) { }

	// RVA: 0x1A67FF8 Offset: 0x1A63FF8 VA: 0x1A67FF8
	private string MakeName(int index) { }

	// RVA: 0x1A67EF0 Offset: 0x1A63EF0 VA: 0x1A67EF0
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1A66BE0 Offset: 0x1A62BE0 VA: 0x1A66BE0
	internal void RegisterName(string name) { }

	// RVA: 0x1A68D34 Offset: 0x1A64D34 VA: 0x1A68D34
	public void Remove(Constraint constraint) { }

	// RVA: 0x1A66DC8 Offset: 0x1A62DC8 VA: 0x1A66DC8
	internal void UnregisterName(string name) { }
}

// Namespace: System.Data
internal sealed class ConstraintConverter : ExpandableObjectConverter // TypeDefIndex: 4450
{
	// Methods

	// RVA: 0x1A68E90 Offset: 0x1A64E90 VA: 0x1A68E90
	public void .ctor() { }

	// RVA: 0x1A68E98 Offset: 0x1A64E98 VA: 0x1A68E98 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1A68F48 Offset: 0x1A64F48 VA: 0x1A68F48 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }
}

// Namespace: System.Data
internal class ConstraintEnumerator // TypeDefIndex: 4451
{
	// Fields
	private IEnumerator _tables; // 0x10
	private IEnumerator _constraints; // 0x18
	private Constraint _currentObject; // 0x20

	// Properties
	protected Constraint CurrentObject { get; }

	// Methods

	// RVA: 0x1A6999C Offset: 0x1A6599C VA: 0x1A6999C
	public void .ctor(DataSet dataSet) { }

	// RVA: 0x1A69A04 Offset: 0x1A65A04 VA: 0x1A69A04
	public bool GetNext() { }

	// RVA: 0x1A69D2C Offset: 0x1A65D2C VA: 0x1A69D2C
	public Constraint GetConstraint() { }

	// RVA: 0x1A69D34 Offset: 0x1A65D34 VA: 0x1A69D34 Slot: 4
	protected virtual bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0x1A69D3C Offset: 0x1A65D3C VA: 0x1A69D3C
	protected Constraint get_CurrentObject() { }
}

// Namespace: System.Data
internal class ForeignKeyConstraintEnumerator : ConstraintEnumerator // TypeDefIndex: 4452
{
	// Methods

	// RVA: 0x1A69D44 Offset: 0x1A65D44 VA: 0x1A69D44
	public void .ctor(DataSet dataSet) { }

	// RVA: 0x1A69D48 Offset: 0x1A65D48 VA: 0x1A69D48 Slot: 4
	protected override bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0x1A69DC0 Offset: 0x1A65DC0 VA: 0x1A69DC0
	public ForeignKeyConstraint GetForeignKeyConstraint() { }
}

// Namespace: System.Data
internal sealed class ChildForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator // TypeDefIndex: 4453
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0x1A69E38 Offset: 0x1A65E38 VA: 0x1A69E38
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0x1A69E64 Offset: 0x1A65E64 VA: 0x1A69E64 Slot: 4
	protected override bool IsValidCandidate(Constraint constraint) { }
}

// Namespace: System.Data
internal sealed class ParentForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator // TypeDefIndex: 4454
{
	// Fields
	private readonly DataTable _table; // 0x28

	// Methods

	// RVA: 0x1A69EF8 Offset: 0x1A65EF8 VA: 0x1A69EF8
	public void .ctor(DataSet dataSet, DataTable inTable) { }

	// RVA: 0x1A69F24 Offset: 0x1A65F24 VA: 0x1A69F24 Slot: 4
	protected override bool IsValidCandidate(Constraint constraint) { }
}

// Namespace: System.Data
public class DataColumnChangeEventArgs : EventArgs // TypeDefIndex: 4455
{
	// Fields
	private DataColumn _column; // 0x10
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; // 0x18
	[CompilerGenerated]
	private object <ProposedValue>k__BackingField; // 0x20

	// Properties
	public object ProposedValue { get; set; }

	// Methods

	// RVA: 0x1A69FBC Offset: 0x1A65FBC VA: 0x1A69FBC
	internal void .ctor(DataRow row) { }

	// RVA: 0x1A6A030 Offset: 0x1A66030 VA: 0x1A6A030
	public void .ctor(DataRow row, DataColumn column, object value) { }

	[CompilerGenerated]
	// RVA: 0x1A6A0D4 Offset: 0x1A660D4 VA: 0x1A6A0D4
	public object get_ProposedValue() { }

	[CompilerGenerated]
	// RVA: 0x1A6A0DC Offset: 0x1A660DC VA: 0x1A6A0DC
	public void set_ProposedValue(object value) { }

	// RVA: 0x1A6A0E4 Offset: 0x1A660E4 VA: 0x1A6A0E4
	internal void InitializeColumnChangeEvent(DataColumn column, object value) { }
}

// Namespace: System.Data
public sealed class DataColumnChangeEventHandler : MulticastDelegate // TypeDefIndex: 4456
{
	// Methods

	// RVA: 0x1A6A114 Offset: 0x1A66114 VA: 0x1A6A114
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A6A220 Offset: 0x1A66220 VA: 0x1A6A220 Slot: 12
	public virtual void Invoke(object sender, DataColumnChangeEventArgs e) { }
}

// Namespace: System.Data
[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
public sealed class DataColumnCollection : InternalDataCollectionBase // TypeDefIndex: 4457
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataColumn[] _delayedAddRangeColumns; // 0x28
	private readonly Dictionary<string, DataColumn> _columnFromName; // 0x30
	private bool _fInClear; // 0x38
	private DataColumn[] _columnsImplementingIChangeTracking; // 0x40
	private int _nColumnsImplementingIChangeTracking; // 0x48
	private int _nColumnsImplementingIRevertibleChangeTracking; // 0x4C
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanged; // 0x50
	[CompilerGenerated]
	private CollectionChangeEventHandler CollectionChanging; // 0x58
	[CompilerGenerated]
	private CollectionChangeEventHandler ColumnPropertyChanged; // 0x60

	// Properties
	protected override ArrayList List { get; }
	internal DataColumn[] ColumnsImplementingIChangeTracking { get; }
	internal int ColumnsImplementingIChangeTrackingCount { get; }
	internal int ColumnsImplementingIRevertibleChangeTrackingCount { get; }
	public DataColumn Item { get; }
	public DataColumn Item { get; }
	internal DataColumn Item { get; }

	// Methods

	// RVA: 0x1A6A234 Offset: 0x1A66234 VA: 0x1A6A234
	internal void .ctor(DataTable table) { }

	// RVA: 0x1A6A3B0 Offset: 0x1A663B0 VA: 0x1A6A3B0 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x1A6A3B8 Offset: 0x1A663B8 VA: 0x1A6A3B8
	internal DataColumn[] get_ColumnsImplementingIChangeTracking() { }

	// RVA: 0x1A6A3C0 Offset: 0x1A663C0 VA: 0x1A6A3C0
	internal int get_ColumnsImplementingIChangeTrackingCount() { }

	// RVA: 0x1A6A3C8 Offset: 0x1A663C8 VA: 0x1A6A3C8
	internal int get_ColumnsImplementingIRevertibleChangeTrackingCount() { }

	// RVA: 0x1A6A3D0 Offset: 0x1A663D0 VA: 0x1A6A3D0
	public DataColumn get_Item(int index) { }

	// RVA: 0x1A6A500 Offset: 0x1A66500 VA: 0x1A6A500
	public DataColumn get_Item(string name) { }

	// RVA: 0x1A6A794 Offset: 0x1A66794 VA: 0x1A6A794
	internal DataColumn get_Item(string name, string ns) { }

	// RVA: 0x1A6A838 Offset: 0x1A66838 VA: 0x1A6A838
	public void Add(DataColumn column) { }

	// RVA: 0x1A6A844 Offset: 0x1A66844 VA: 0x1A6A844
	internal void AddAt(int index, DataColumn column) { }

	[CompilerGenerated]
	// RVA: 0x1A6AF3C Offset: 0x1A66F3C VA: 0x1A6AF3C
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1A6AFD8 Offset: 0x1A66FD8 VA: 0x1A6AFD8
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1A6B074 Offset: 0x1A67074 VA: 0x1A6B074
	internal void add_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1A6B110 Offset: 0x1A67110 VA: 0x1A6B110
	internal void remove_ColumnPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x1A6AE2C Offset: 0x1A66E2C VA: 0x1A6AE2C
	private void ArrayAdd(DataColumn column) { }

	// RVA: 0x1A6ADEC Offset: 0x1A66DEC VA: 0x1A6ADEC
	private void ArrayAdd(int index, DataColumn column) { }

	// RVA: 0x1A6B1EC Offset: 0x1A671EC VA: 0x1A6B1EC
	private void ArrayRemove(DataColumn column) { }

	// RVA: 0x1A6B438 Offset: 0x1A67438 VA: 0x1A6B438
	internal string AssignName() { }

	// RVA: 0x1A6AAC8 Offset: 0x1A66AC8 VA: 0x1A6AAC8
	private void BaseAdd(DataColumn column) { }

	// RVA: 0x1A6B800 Offset: 0x1A67800 VA: 0x1A6B800
	private void BaseGroupSwitch(DataColumn[] oldArray, int oldLength, DataColumn[] newArray, int newLength) { }

	// RVA: 0x1A6B9DC Offset: 0x1A679DC VA: 0x1A6B9DC
	private void BaseRemove(DataColumn column) { }

	// RVA: 0x1A6BA94 Offset: 0x1A67A94 VA: 0x1A6BA94
	internal bool CanRemove(DataColumn column, bool fThrowException) { }

	// RVA: 0x1A6B1AC Offset: 0x1A671AC VA: 0x1A6B1AC
	private void CheckIChangeTracking(DataColumn column) { }

	// RVA: 0x1A6C2B8 Offset: 0x1A682B8 VA: 0x1A6C2B8
	public void Clear() { }

	// RVA: 0x1A6C5D0 Offset: 0x1A685D0 VA: 0x1A6C5D0
	public bool Contains(string name) { }

	// RVA: 0x1A6C664 Offset: 0x1A68664 VA: 0x1A6C664
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x1A6C700 Offset: 0x1A68700 VA: 0x1A6C700
	public int IndexOf(string columnName) { }

	// RVA: 0x1A6A644 Offset: 0x1A66644 VA: 0x1A6A644
	internal int IndexOfCaseInsensitive(string name) { }

	// RVA: 0x1A6B4CC Offset: 0x1A674CC VA: 0x1A6B4CC
	private string MakeName(int index) { }

	// RVA: 0x1A6AE98 Offset: 0x1A66E98 VA: 0x1A6AE98
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1A6AAA0 Offset: 0x1A66AA0 VA: 0x1A6AAA0
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1A6C800 Offset: 0x1A68800 VA: 0x1A6C800
	internal void OnColumnPropertyChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1A6B584 Offset: 0x1A67584 VA: 0x1A6B584
	internal void RegisterColumnName(string name, DataColumn column) { }

	// RVA: 0x1A6C858 Offset: 0x1A68858 VA: 0x1A6C858
	internal bool CanRegisterName(string name) { }

	// RVA: 0x1A6C8BC Offset: 0x1A688BC VA: 0x1A6C8BC
	public void Remove(DataColumn column) { }

	// RVA: 0x1A6B744 Offset: 0x1A67744 VA: 0x1A6B744
	internal void UnregisterName(string name) { }

	// RVA: 0x1A6C1E0 Offset: 0x1A681E0 VA: 0x1A6C1E0
	private void AddColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }

	// RVA: 0x1A6B31C Offset: 0x1A6731C VA: 0x1A6B31C
	private void RemoveColumnsImplementingIChangeTrackingList(DataColumn dataColumn) { }
}

// Namespace: System.Data
internal sealed class DataColumnPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4458
{
	// Fields
	[CompilerGenerated]
	private readonly DataColumn <Column>k__BackingField; // 0x88

	// Properties
	public override AttributeCollection Attributes { get; }
	internal DataColumn Column { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x1A6C9C8 Offset: 0x1A689C8 VA: 0x1A6C9C8
	internal void .ctor(DataColumn dataColumn) { }

	// RVA: 0x1A6CA08 Offset: 0x1A68A08 VA: 0x1A6CA08 Slot: 6
	public override AttributeCollection get_Attributes() { }

	[CompilerGenerated]
	// RVA: 0x1A6CBC0 Offset: 0x1A68BC0 VA: 0x1A6CBC0
	internal DataColumn get_Column() { }

	// RVA: 0x1A6CBC8 Offset: 0x1A68BC8 VA: 0x1A6CBC8 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x1A6CC28 Offset: 0x1A68C28 VA: 0x1A6CC28 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x1A6CC40 Offset: 0x1A68C40 VA: 0x1A6CC40 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x1A6CC58 Offset: 0x1A68C58 VA: 0x1A6CC58 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1A6CCC8 Offset: 0x1A68CC8 VA: 0x1A6CCC8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A6CCE4 Offset: 0x1A68CE4 VA: 0x1A6CCE4 Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x1A6CE44 Offset: 0x1A68E44 VA: 0x1A6CE44 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x1A6CECC Offset: 0x1A68ECC VA: 0x1A6CECC Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x1A6D01C Offset: 0x1A6901C VA: 0x1A6D01C Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x1A6D0FC Offset: 0x1A690FC VA: 0x1A6D0FC Slot: 22
	public override bool ShouldSerializeValue(object component) { }
}

// Namespace: 
internal struct DataError.ColumnError // TypeDefIndex: 4459
{
	// Fields
	internal DataColumn _column; // 0x0
	internal string _error; // 0x8
}

// Namespace: System.Data
internal sealed class DataError // TypeDefIndex: 4460
{
	// Fields
	private string _rowError; // 0x10
	private int _count; // 0x18
	private DataError.ColumnError[] _errorList; // 0x20

	// Properties
	internal string Text { get; set; }
	internal bool HasErrors { get; }

	// Methods

	// RVA: 0x1A6D104 Offset: 0x1A69104 VA: 0x1A6D104
	internal void .ctor() { }

	// RVA: 0x1A6D138 Offset: 0x1A69138 VA: 0x1A6D138
	internal void .ctor(string rowError) { }

	// RVA: 0x1A6D1C8 Offset: 0x1A691C8 VA: 0x1A6D1C8
	internal string get_Text() { }

	// RVA: 0x1A6D1D0 Offset: 0x1A691D0 VA: 0x1A6D1D0
	internal void set_Text(string value) { }

	// RVA: 0x1A6D1F0 Offset: 0x1A691F0 VA: 0x1A6D1F0
	internal bool get_HasErrors() { }

	// RVA: 0x1A6D220 Offset: 0x1A69220 VA: 0x1A6D220
	internal void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x1A6D548 Offset: 0x1A69548 VA: 0x1A6D548
	internal string GetColumnError(DataColumn column) { }

	// RVA: 0x1A6D350 Offset: 0x1A69350 VA: 0x1A6D350
	internal void Clear(DataColumn column) { }

	// RVA: 0x1A6D5AC Offset: 0x1A695AC VA: 0x1A6D5AC
	internal void Clear() { }

	// RVA: 0x1A6D620 Offset: 0x1A69620 VA: 0x1A6D620
	internal DataColumn[] GetColumnsInError() { }

	// RVA: 0x1A6D1A8 Offset: 0x1A691A8 VA: 0x1A6D1A8
	private void SetText(string errorText) { }

	// RVA: 0x1A6D3FC Offset: 0x1A693FC VA: 0x1A6D3FC
	internal int IndexOf(DataColumn column) { }
}

// Namespace: System.Data
[IsReadOnly]
internal struct DataKey // TypeDefIndex: 4461
{
	// Fields
	private readonly DataColumn[] _columns; // 0x0

	// Properties
	internal DataColumn[] ColumnsReference { get; }
	internal bool HasValue { get; }
	internal DataTable Table { get; }

	// Methods

	// RVA: 0x1A6D71C Offset: 0x1A6971C VA: 0x1A6D71C
	internal void .ctor(DataColumn[] columns, bool copyColumns) { }

	// RVA: 0x1A6D9CC Offset: 0x1A699CC VA: 0x1A6D9CC
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0x1A6D9D4 Offset: 0x1A699D4 VA: 0x1A6D9D4
	internal bool get_HasValue() { }

	// RVA: 0x1A6996C Offset: 0x1A6596C VA: 0x1A6996C
	internal DataTable get_Table() { }

	// RVA: 0x1A6D934 Offset: 0x1A69934 VA: 0x1A6D934
	internal void CheckState() { }

	// RVA: 0x1A6D9E4 Offset: 0x1A699E4 VA: 0x1A6D9E4
	internal bool ColumnsEqual(DataKey key) { }

	// RVA: 0x1A6D9EC Offset: 0x1A699EC VA: 0x1A6D9EC
	internal static bool ColumnsEqual(DataColumn[] column1, DataColumn[] column2) { }

	// RVA: 0x1A6C14C Offset: 0x1A6814C VA: 0x1A6C14C
	internal bool ContainsColumn(DataColumn column) { }

	// RVA: 0x1A6DADC Offset: 0x1A69ADC VA: 0x1A6DADC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A6DB40 Offset: 0x1A69B40 VA: 0x1A6DB40 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1A6DBBC Offset: 0x1A69BBC VA: 0x1A6DBBC
	internal bool Equals(DataKey value) { }

	// RVA: 0x1A6DC74 Offset: 0x1A69C74 VA: 0x1A6DC74
	internal string[] GetColumnNames() { }

	// RVA: 0x1A6DD38 Offset: 0x1A69D38 VA: 0x1A6DD38
	internal IndexField[] GetIndexDesc() { }

	// RVA: 0x1A6DE24 Offset: 0x1A69E24 VA: 0x1A6DE24
	internal object[] GetKeyValues(int record) { }

	// RVA: 0x1A6DF34 Offset: 0x1A69F34 VA: 0x1A6DF34
	internal Index GetSortIndex() { }

	// RVA: 0x1A6DF3C Offset: 0x1A69F3C VA: 0x1A6DF3C
	internal Index GetSortIndex(DataViewRowState recordStates) { }

	// RVA: 0x1A6DF94 Offset: 0x1A69F94 VA: 0x1A6DF94
	internal bool RecordsEqual(int record1, int record2) { }

	// RVA: 0x1A6E018 Offset: 0x1A6A018 VA: 0x1A6E018
	internal DataColumn[] ToArray() { }
}

// Namespace: System.Data
[DefaultProperty("RelationName")]
[TypeConverter(typeof(RelationshipConverter))]
public class DataRelation // TypeDefIndex: 4462
{
	// Fields
	private DataSet _dataSet; // 0x10
	internal PropertyCollection _extendedProperties; // 0x18
	internal string _relationName; // 0x20
	private DataKey _childKey; // 0x28
	private DataKey _parentKey; // 0x30
	private UniqueConstraint _parentKeyConstraint; // 0x38
	private ForeignKeyConstraint _childKeyConstraint; // 0x40
	internal string[] _parentColumnNames; // 0x48
	internal string[] _childColumnNames; // 0x50
	internal string _parentTableName; // 0x58
	internal string _childTableName; // 0x60
	internal string _parentTableNamespace; // 0x68
	internal string _childTableNamespace; // 0x70
	internal bool _nested; // 0x78
	internal bool _createConstraints; // 0x79
	private bool _checkMultipleNested; // 0x7A
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x7C
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanging; // 0x80

	// Properties
	public virtual DataColumn[] ChildColumns { get; }
	internal DataColumn[] ChildColumnsReference { get; }
	internal DataKey ChildKey { get; }
	public virtual DataTable ChildTable { get; }
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual DataSet DataSet { get; }
	internal string[] ParentColumnNames { get; }
	internal string[] ChildColumnNames { get; }
	public virtual DataColumn[] ParentColumns { get; }
	internal DataColumn[] ParentColumnsReference { get; }
	internal DataKey ParentKey { get; }
	public virtual DataTable ParentTable { get; }
	[DefaultValue("")]
	public virtual string RelationName { get; }
	[DefaultValue(False)]
	public virtual bool Nested { get; set; }
	public virtual UniqueConstraint ParentKeyConstraint { get; }
	public virtual ForeignKeyConstraint ChildKeyConstraint { get; }
	[Browsable(False)]
	public PropertyCollection ExtendedProperties { get; }
	internal bool CheckMultipleNested { get; set; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x1A6E10C Offset: 0x1A6A10C VA: 0x1A6E10C
	public void .ctor(string relationName, DataColumn parentColumn, DataColumn childColumn, bool createConstraints) { }

	// RVA: 0x1A6E5F8 Offset: 0x1A6A5F8 VA: 0x1A6E5F8
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1A6E600 Offset: 0x1A6A600 VA: 0x1A6E600
	public void .ctor(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	[Browsable(False)]
	// RVA: 0x1A6E6BC Offset: 0x1A6A6BC VA: 0x1A6E6BC
	public void .ctor(string relationName, string parentTableName, string childTableName, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	[Browsable(False)]
	// RVA: 0x1A6E7D0 Offset: 0x1A6A7D0 VA: 0x1A6E7D0
	public void .ctor(string relationName, string parentTableName, string parentTableNamespace, string childTableName, string childTableNamespace, string[] parentColumnNames, string[] childColumnNames, bool nested) { }

	// RVA: 0x1A6E914 Offset: 0x1A6A914 VA: 0x1A6E914 Slot: 4
	public virtual DataColumn[] get_ChildColumns() { }

	// RVA: 0x1A6EA60 Offset: 0x1A6AA60 VA: 0x1A6EA60
	internal DataColumn[] get_ChildColumnsReference() { }

	// RVA: 0x1A6C1B0 Offset: 0x1A681B0 VA: 0x1A6C1B0
	internal DataKey get_ChildKey() { }

	// RVA: 0x1A6EA78 Offset: 0x1A6AA78 VA: 0x1A6EA78 Slot: 5
	public virtual DataTable get_ChildTable() { }

	// RVA: 0x1A6EA90 Offset: 0x1A6AA90 VA: 0x1A6EA90 Slot: 6
	public virtual DataSet get_DataSet() { }

	// RVA: 0x1A6EAA8 Offset: 0x1A6AAA8 VA: 0x1A6EAA8
	internal string[] get_ParentColumnNames() { }

	// RVA: 0x1A6EAB0 Offset: 0x1A6AAB0 VA: 0x1A6EAB0
	internal string[] get_ChildColumnNames() { }

	// RVA: 0x1A6EAB8 Offset: 0x1A6AAB8 VA: 0x1A6EAB8
	private static bool IsKeyNull(object[] values) { }

	// RVA: 0x1A6EB74 Offset: 0x1A6AB74 VA: 0x1A6EB74
	internal static DataRow[] GetChildRows(DataKey parentKey, DataKey childKey, DataRow parentRow, DataRowVersion version) { }

	// RVA: 0x1A6EC2C Offset: 0x1A6AC2C VA: 0x1A6EC2C
	internal static DataRow[] GetParentRows(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x1A6ECC4 Offset: 0x1A6ACC4 VA: 0x1A6ECC4
	internal static DataRow GetParentRow(DataKey parentKey, DataKey childKey, DataRow childRow, DataRowVersion version) { }

	// RVA: 0x1A6EE9C Offset: 0x1A6AE9C VA: 0x1A6EE9C
	internal void SetDataSet(DataSet dataSet) { }

	// RVA: 0x1A6EEB4 Offset: 0x1A6AEB4 VA: 0x1A6EEB4 Slot: 7
	public virtual DataColumn[] get_ParentColumns() { }

	// RVA: 0x1A6EECC Offset: 0x1A6AECC VA: 0x1A6EECC
	internal DataColumn[] get_ParentColumnsReference() { }

	// RVA: 0x1A6C1C8 Offset: 0x1A681C8 VA: 0x1A6C1C8
	internal DataKey get_ParentKey() { }

	// RVA: 0x1A6EED4 Offset: 0x1A6AED4 VA: 0x1A6EED4 Slot: 8
	public virtual DataTable get_ParentTable() { }

	// RVA: 0x1A6EEEC Offset: 0x1A6AEEC VA: 0x1A6EEEC Slot: 9
	public virtual string get_RelationName() { }

	// RVA: 0x1A6EF04 Offset: 0x1A6AF04 VA: 0x1A6EF04
	internal void CheckNamespaceValidityForNestedRelations(string ns) { }

	// RVA: 0x1A6F260 Offset: 0x1A6B260 VA: 0x1A6F260
	internal void CheckNestedRelations() { }

	// RVA: 0x1A6F678 Offset: 0x1A6B678 VA: 0x1A6F678 Slot: 10
	public virtual bool get_Nested() { }

	// RVA: 0x1A6F690 Offset: 0x1A6B690 VA: 0x1A6F690 Slot: 11
	public virtual void set_Nested(bool value) { }

	// RVA: 0x1A70C30 Offset: 0x1A6CC30 VA: 0x1A70C30 Slot: 12
	public virtual UniqueConstraint get_ParentKeyConstraint() { }

	// RVA: 0x1A70C48 Offset: 0x1A6CC48 VA: 0x1A70C48
	internal void SetParentKeyConstraint(UniqueConstraint value) { }

	// RVA: 0x1A70C50 Offset: 0x1A6CC50 VA: 0x1A70C50 Slot: 13
	public virtual ForeignKeyConstraint get_ChildKeyConstraint() { }

	// RVA: 0x1A70C68 Offset: 0x1A6CC68 VA: 0x1A70C68
	public PropertyCollection get_ExtendedProperties() { }

	// RVA: 0x1A70CD8 Offset: 0x1A6CCD8 VA: 0x1A70CD8
	internal bool get_CheckMultipleNested() { }

	// RVA: 0x1A70CE0 Offset: 0x1A6CCE0 VA: 0x1A70CE0
	internal void set_CheckMultipleNested(bool value) { }

	// RVA: 0x1A70CE8 Offset: 0x1A6CCE8 VA: 0x1A70CE8
	internal void SetChildKeyConstraint(ForeignKeyConstraint value) { }

	// RVA: 0x1A70CF0 Offset: 0x1A6CCF0 VA: 0x1A70CF0
	internal void CheckState() { }

	// RVA: 0x1A6E92C Offset: 0x1A6A92C VA: 0x1A6E92C
	protected void CheckStateForProperty() { }

	// RVA: 0x1A6E318 Offset: 0x1A6A318 VA: 0x1A6E318
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns, bool createConstraints) { }

	// RVA: 0x1A70F10 Offset: 0x1A6CF10 VA: 0x1A70F10
	internal DataRelation Clone(DataSet destination) { }

	// RVA: 0x1A71644 Offset: 0x1A6D644 VA: 0x1A71644
	protected internal void OnPropertyChanging(PropertyChangedEventArgs pcevent) { }

	// RVA: 0x1A70AE8 Offset: 0x1A6CAE8 VA: 0x1A70AE8
	protected internal void RaisePropertyChanging(string name) { }

	// RVA: 0x1A71714 Offset: 0x1A6D714 VA: 0x1A71714 Slot: 3
	public override string ToString() { }

	// RVA: 0x1A7063C Offset: 0x1A6C63C VA: 0x1A7063C
	internal void ValidateMultipleNestedRelations() { }

	// RVA: 0x1A71720 Offset: 0x1A6D720 VA: 0x1A71720
	private bool IsAutoGenerated(DataColumn col) { }

	// RVA: 0x1A718D4 Offset: 0x1A6D8D4 VA: 0x1A718D4
	internal int get_ObjectID() { }
}

// Namespace: 
[DefaultMember("Item")]
internal sealed class DataRelationCollection.DataTableRelationCollection : DataRelationCollection // TypeDefIndex: 4463
{
	// Fields
	private readonly DataTable _table; // 0x38
	private readonly ArrayList _relations; // 0x40
	private readonly bool _fParentCollection; // 0x48
	[CompilerGenerated]
	private CollectionChangeEventHandler RelationPropertyChanged; // 0x50

	// Properties
	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }

	// Methods

	// RVA: 0x1A72DE4 Offset: 0x1A6EDE4 VA: 0x1A72DE4
	internal void .ctor(DataTable table, bool fParentCollection) { }

	// RVA: 0x1A72E9C Offset: 0x1A6EE9C VA: 0x1A72E9C Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x1A72EA4 Offset: 0x1A6EEA4 VA: 0x1A72EA4
	private void EnsureDataSet() { }

	// RVA: 0x1A72EE8 Offset: 0x1A6EEE8 VA: 0x1A72EE8 Slot: 18
	protected override DataSet GetDataSet() { }

	// RVA: 0x1A72F0C Offset: 0x1A6EF0C VA: 0x1A72F0C Slot: 13
	public override DataRelation get_Item(int index) { }

	// RVA: 0x1A7300C Offset: 0x1A6F00C VA: 0x1A7300C Slot: 14
	public override DataRelation get_Item(string name) { }

	[CompilerGenerated]
	// RVA: 0x1A730F8 Offset: 0x1A6F0F8 VA: 0x1A730F8
	internal void add_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1A73194 Offset: 0x1A6F194 VA: 0x1A73194
	internal void remove_RelationPropertyChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x1A73230 Offset: 0x1A6F230 VA: 0x1A73230
	private void AddCache(DataRelation relation) { }

	// RVA: 0x1A73278 Offset: 0x1A6F278 VA: 0x1A73278 Slot: 15
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0x1A73340 Offset: 0x1A6F340 VA: 0x1A73340
	private void RemoveCache(DataRelation relation) { }

	// RVA: 0x1A73414 Offset: 0x1A6F414 VA: 0x1A73414 Slot: 21
	protected override void RemoveCore(DataRelation relation) { }
}

// Namespace: 
[DefaultMember("Item")]
internal sealed class DataRelationCollection.DataSetRelationCollection : DataRelationCollection // TypeDefIndex: 4464
{
	// Fields
	private readonly DataSet _dataSet; // 0x38
	private readonly ArrayList _relations; // 0x40
	private DataRelation[] _delayLoadingRelations; // 0x48

	// Properties
	protected override ArrayList List { get; }
	public override DataRelation Item { get; }
	public override DataRelation Item { get; }

	// Methods

	// RVA: 0x1A734DC Offset: 0x1A6F4DC VA: 0x1A734DC
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x1A73580 Offset: 0x1A6F580 VA: 0x1A73580 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x1A73588 Offset: 0x1A6F588 VA: 0x1A73588 Slot: 16
	public override void Clear() { }

	// RVA: 0x1A735CC Offset: 0x1A6F5CC VA: 0x1A735CC Slot: 18
	protected override DataSet GetDataSet() { }

	// RVA: 0x1A735D4 Offset: 0x1A6F5D4 VA: 0x1A735D4 Slot: 13
	public override DataRelation get_Item(int index) { }

	// RVA: 0x1A736D4 Offset: 0x1A6F6D4 VA: 0x1A736D4 Slot: 14
	public override DataRelation get_Item(string name) { }

	// RVA: 0x1A737C0 Offset: 0x1A6F7C0 VA: 0x1A737C0 Slot: 15
	protected override void AddCore(DataRelation relation) { }

	// RVA: 0x1A73D78 Offset: 0x1A6FD78 VA: 0x1A73D78 Slot: 21
	protected override void RemoveCore(DataRelation relation) { }
}

// Namespace: System.Data
[DefaultEvent("CollectionChanged")]
[DefaultMember("Item")]
[DefaultProperty("Table")]
public abstract class DataRelationCollection : InternalDataCollectionBase // TypeDefIndex: 4465
{
	// Fields
	private DataRelation _inTransition; // 0x10
	private int _defaultNameIndex; // 0x18
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x20
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x28
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x30

	// Properties
	internal int ObjectID { get; }
	public abstract DataRelation Item { get; }
	public abstract DataRelation Item { get; }

	// Methods

	// RVA: 0x1A718DC Offset: 0x1A6D8DC VA: 0x1A718DC
	internal int get_ObjectID() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract DataRelation get_Item(int index);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract DataRelation get_Item(string name);

	// RVA: 0x1A718E4 Offset: 0x1A6D8E4 VA: 0x1A718E4
	public void Add(DataRelation relation) { }

	// RVA: 0x1A71B6C Offset: 0x1A6DB6C VA: 0x1A71B6C Slot: 15
	protected virtual void AddCore(DataRelation relation) { }

	// RVA: 0x1A71DE8 Offset: 0x1A6DDE8 VA: 0x1A71DE8
	public void add_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x1A71EF0 Offset: 0x1A6DEF0 VA: 0x1A71EF0
	public void remove_CollectionChanged(CollectionChangeEventHandler value) { }

	// RVA: 0x1A71FF8 Offset: 0x1A6DFF8 VA: 0x1A71FF8
	internal string AssignName() { }

	// RVA: 0x1A720D4 Offset: 0x1A6E0D4 VA: 0x1A720D4 Slot: 16
	public virtual void Clear() { }

	// RVA: 0x1A7230C Offset: 0x1A6E30C VA: 0x1A7230C Slot: 17
	public virtual bool Contains(string name) { }

	// RVA: 0x1A72324 Offset: 0x1A6E324 VA: 0x1A72324
	internal int InternalIndexOf(string name) { }

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract DataSet GetDataSet();

	// RVA: 0x1A7201C Offset: 0x1A6E01C VA: 0x1A7201C
	private string MakeName(int index) { }

	// RVA: 0x1A7249C Offset: 0x1A6E49C VA: 0x1A7249C Slot: 19
	protected virtual void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1A7256C Offset: 0x1A6E56C VA: 0x1A7256C Slot: 20
	protected virtual void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1A7263C Offset: 0x1A6E63C VA: 0x1A7263C
	internal void RegisterName(string name) { }

	// RVA: 0x1A727F8 Offset: 0x1A6E7F8 VA: 0x1A727F8
	public void Remove(DataRelation relation) { }

	// RVA: 0x1A729E8 Offset: 0x1A6E9E8 VA: 0x1A729E8
	public void RemoveAt(int index) { }

	// RVA: 0x1A72A5C Offset: 0x1A6EA5C VA: 0x1A72A5C Slot: 21
	protected virtual void RemoveCore(DataRelation relation) { }

	// RVA: 0x1A72C24 Offset: 0x1A6EC24 VA: 0x1A72C24
	internal void UnregisterName(string name) { }

	// RVA: 0x1A72D50 Offset: 0x1A6ED50 VA: 0x1A72D50
	protected void .ctor() { }
}

// Namespace: System.Data
internal sealed class DataRelationPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4466
{
	// Fields
	[CompilerGenerated]
	private readonly DataRelation <Relation>k__BackingField; // 0x88

	// Properties
	internal DataRelation Relation { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x1A73FD0 Offset: 0x1A6FFD0 VA: 0x1A73FD0
	internal void .ctor(DataRelation dataRelation) { }

	[CompilerGenerated]
	// RVA: 0x1A74024 Offset: 0x1A70024 VA: 0x1A74024
	internal DataRelation get_Relation() { }

	// RVA: 0x1A7402C Offset: 0x1A7002C VA: 0x1A7402C Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x1A7408C Offset: 0x1A7008C VA: 0x1A7408C Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x1A74094 Offset: 0x1A70094 VA: 0x1A74094 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x1A740F4 Offset: 0x1A700F4 VA: 0x1A740F4 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1A74164 Offset: 0x1A70164 VA: 0x1A74164 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A74180 Offset: 0x1A70180 VA: 0x1A74180 Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x1A74188 Offset: 0x1A70188 VA: 0x1A74188 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x1A7421C Offset: 0x1A7021C VA: 0x1A7421C Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x1A74220 Offset: 0x1A70220 VA: 0x1A74220 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x1A74224 Offset: 0x1A70224 VA: 0x1A74224 Slot: 22
	public override bool ShouldSerializeValue(object component) { }
}

// Namespace: System.Data
[DefaultMember("Item")]
public class DataRow // TypeDefIndex: 4467
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataColumnCollection _columns; // 0x18
	internal int _oldRecord; // 0x20
	internal int _newRecord; // 0x24
	internal int _tempRecord; // 0x28
	internal long _rowID; // 0x30
	internal DataRowAction _action; // 0x38
	internal bool _inChangingEvent; // 0x3C
	internal bool _inDeletingEvent; // 0x3D
	internal bool _inCascade; // 0x3E
	private DataColumn _lastChangedColumn; // 0x40
	private int _countColumnChange; // 0x48
	private DataError _error; // 0x50
	private int _rbTreeNodeId; // 0x58
	private static int s_objectTypeCount; // 0x0
	internal readonly int _objectID; // 0x5C

	// Properties
	internal DataColumn LastChangedColumn { get; set; }
	internal bool HasPropertyChanged { get; }
	internal int RBTreeNodeId { get; set; }
	public string RowError { get; set; }
	internal long rowID { get; set; }
	public DataRowState RowState { get; }
	public DataTable Table { get; }
	public string Item { set; }
	public object Item { get; set; }
	public object Item { get; }
	public object[] ItemArray { set; }
	public bool HasErrors { get; }

	// Methods

	// RVA: 0x1A7422C Offset: 0x1A7022C VA: 0x1A7422C
	protected internal void .ctor(DataRowBuilder builder) { }

	// RVA: 0x1A742E0 Offset: 0x1A702E0 VA: 0x1A742E0
	internal DataColumn get_LastChangedColumn() { }

	// RVA: 0x1A742FC Offset: 0x1A702FC VA: 0x1A742FC
	internal void set_LastChangedColumn(DataColumn value) { }

	// RVA: 0x1A74310 Offset: 0x1A70310 VA: 0x1A74310
	internal bool get_HasPropertyChanged() { }

	// RVA: 0x1A74320 Offset: 0x1A70320 VA: 0x1A74320
	internal int get_RBTreeNodeId() { }

	// RVA: 0x1A74328 Offset: 0x1A70328 VA: 0x1A74328
	internal void set_RBTreeNodeId(int value) { }

	// RVA: 0x1A743D8 Offset: 0x1A703D8 VA: 0x1A743D8
	public string get_RowError() { }

	// RVA: 0x1A74400 Offset: 0x1A70400 VA: 0x1A74400
	public void set_RowError(string value) { }

	// RVA: 0x1A74554 Offset: 0x1A70554 VA: 0x1A74554
	private void RowErrorChanged() { }

	// RVA: 0x1A745A4 Offset: 0x1A705A4 VA: 0x1A745A4
	internal long get_rowID() { }

	// RVA: 0x1A745AC Offset: 0x1A705AC VA: 0x1A745AC
	internal void set_rowID(long value) { }

	// RVA: 0x1A74604 Offset: 0x1A70604 VA: 0x1A74604
	public DataRowState get_RowState() { }

	// RVA: 0x1A74824 Offset: 0x1A70824 VA: 0x1A74824
	public DataTable get_Table() { }

	// RVA: 0x1A70B54 Offset: 0x1A6CB54 VA: 0x1A70B54
	internal void CheckForLoops(DataRelation rel) { }

	// RVA: 0x1A7482C Offset: 0x1A7082C VA: 0x1A7482C
	internal int GetNestedParentCount() { }

	// RVA: 0x1A748F4 Offset: 0x1A708F4 VA: 0x1A748F4
	public void set_Item(string columnName, object value) { }

	// RVA: 0x1A747E8 Offset: 0x1A707E8 VA: 0x1A747E8
	public object get_Item(DataColumn column) { }

	// RVA: 0x1A74988 Offset: 0x1A70988 VA: 0x1A74988
	public void set_Item(DataColumn column, object value) { }

	// RVA: 0x1A75050 Offset: 0x1A71050 VA: 0x1A75050
	public object get_Item(DataColumn column, DataRowVersion version) { }

	// RVA: 0x1A750F4 Offset: 0x1A710F4 VA: 0x1A750F4
	public void set_ItemArray(object[] value) { }

	// RVA: 0x1A75504 Offset: 0x1A71504 VA: 0x1A75504
	public void AcceptChanges() { }

	[EditorBrowsable(2)]
	// RVA: 0x1A75858 Offset: 0x1A71858 VA: 0x1A75858
	public void BeginEdit() { }

	// RVA: 0x1A74DD8 Offset: 0x1A70DD8 VA: 0x1A74DD8
	private bool BeginEditInternal() { }

	[EditorBrowsable(2)]
	// RVA: 0x1A74EEC Offset: 0x1A70EEC VA: 0x1A74EEC
	public void CancelEdit() { }

	// RVA: 0x1A74CEC Offset: 0x1A70CEC VA: 0x1A74CEC
	private void CheckColumn(DataColumn column) { }

	// RVA: 0x1A7585C Offset: 0x1A7185C VA: 0x1A7585C
	internal void CheckInTable() { }

	// RVA: 0x1A75894 Offset: 0x1A71894 VA: 0x1A75894
	public void Delete() { }

	[EditorBrowsable(2)]
	// RVA: 0x1A74F54 Offset: 0x1A70F54 VA: 0x1A74F54
	public void EndEdit() { }

	// RVA: 0x1A758F4 Offset: 0x1A718F4 VA: 0x1A758F4
	public void SetColumnError(int columnIndex, string error) { }

	// RVA: 0x1A75958 Offset: 0x1A71958 VA: 0x1A75958
	public void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x1A75B68 Offset: 0x1A71B68 VA: 0x1A75B68
	public string GetColumnError(DataColumn column) { }

	// RVA: 0x1A75C14 Offset: 0x1A71C14 VA: 0x1A75C14
	public void ClearErrors() { }

	// RVA: 0x1A6C124 Offset: 0x1A68124 VA: 0x1A6C124
	internal void ClearError(DataColumn column) { }

	// RVA: 0x1A75C3C Offset: 0x1A71C3C VA: 0x1A75C3C
	public bool get_HasErrors() { }

	// RVA: 0x1A75C7C Offset: 0x1A71C7C VA: 0x1A75C7C
	public DataColumn[] GetColumnsInError() { }

	// RVA: 0x1A75D28 Offset: 0x1A71D28 VA: 0x1A75D28
	public DataRow[] GetChildRows(DataRelation relation) { }

	// RVA: 0x1A75D30 Offset: 0x1A71D30 VA: 0x1A75D30
	public DataRow[] GetChildRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x1A74920 Offset: 0x1A70920 VA: 0x1A74920
	internal DataColumn GetDataColumn(string columnName) { }

	// RVA: 0x1A70C28 Offset: 0x1A6CC28 VA: 0x1A70C28
	public DataRow GetParentRow(DataRelation relation) { }

	// RVA: 0x1A75E58 Offset: 0x1A71E58 VA: 0x1A75E58
	public DataRow GetParentRow(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x1A75F74 Offset: 0x1A71F74 VA: 0x1A75F74
	internal DataRow GetNestedParentRow(DataRowVersion version) { }

	// RVA: 0x1A76030 Offset: 0x1A72030 VA: 0x1A76030
	public DataRow[] GetParentRows(DataRelation relation) { }

	// RVA: 0x1A76038 Offset: 0x1A72038 VA: 0x1A76038
	public DataRow[] GetParentRows(DataRelation relation, DataRowVersion version) { }

	// RVA: 0x1A76160 Offset: 0x1A72160 VA: 0x1A76160
	internal object[] GetColumnValues(DataColumn[] columns) { }

	// RVA: 0x1A76168 Offset: 0x1A72168 VA: 0x1A76168
	internal object[] GetColumnValues(DataColumn[] columns, DataRowVersion version) { }

	// RVA: 0x1A761B8 Offset: 0x1A721B8 VA: 0x1A761B8
	internal object[] GetKeyValues(DataKey key) { }

	// RVA: 0x1A6EC0C Offset: 0x1A6AC0C VA: 0x1A6EC0C
	internal object[] GetKeyValues(DataKey key, DataRowVersion version) { }

	// RVA: 0x1A761D4 Offset: 0x1A721D4 VA: 0x1A761D4
	internal int GetCurrentRecordNo() { }

	// RVA: 0x1A74D78 Offset: 0x1A70D78 VA: 0x1A74D78
	internal int GetDefaultRecord() { }

	// RVA: 0x1A7620C Offset: 0x1A7220C VA: 0x1A7620C
	internal int GetOriginalRecordNo() { }

	// RVA: 0x1A74EB4 Offset: 0x1A70EB4 VA: 0x1A74EB4
	private int GetProposedRecordNo() { }

	// RVA: 0x1A75094 Offset: 0x1A71094 VA: 0x1A75094
	internal int GetRecordFromVersion(DataRowVersion version) { }

	// RVA: 0x1A76244 Offset: 0x1A72244 VA: 0x1A76244
	internal DataRowVersion GetDefaultRowVersion(DataViewRowState viewState) { }

	// RVA: 0x1A76274 Offset: 0x1A72274 VA: 0x1A76274
	internal DataViewRowState GetRecordState(int record) { }

	// RVA: 0x1A762CC Offset: 0x1A722CC VA: 0x1A762CC
	internal bool HasKeyChanged(DataKey key) { }

	// RVA: 0x1A762D8 Offset: 0x1A722D8 VA: 0x1A762D8
	internal bool HasKeyChanged(DataKey key, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0x1A6EE18 Offset: 0x1A6AE18 VA: 0x1A6EE18
	public bool HasVersion(DataRowVersion version) { }

	// RVA: 0x1A7635C Offset: 0x1A7235C VA: 0x1A7635C
	internal bool HaveValuesChanged(DataColumn[] columns) { }

	// RVA: 0x1A76368 Offset: 0x1A72368 VA: 0x1A76368
	internal bool HaveValuesChanged(DataColumn[] columns, DataRowVersion version1, DataRowVersion version2) { }

	// RVA: 0x1A76410 Offset: 0x1A72410 VA: 0x1A76410
	public void RejectChanges() { }

	// RVA: 0x1A745E0 Offset: 0x1A705E0 VA: 0x1A745E0
	internal void ResetLastChangedColumn() { }

	// RVA: 0x1A769D4 Offset: 0x1A729D4 VA: 0x1A769D4
	internal void SetKeyValues(DataKey key, object[] keyValues) { }

	// RVA: 0x1A76AEC Offset: 0x1A72AEC VA: 0x1A76AEC
	internal void SetNestedParentRow(DataRow parentRow, bool setNonNested) { }

	// RVA: 0x1A76EAC Offset: 0x1A72EAC VA: 0x1A76EAC
	internal void SetParentRowToDBNull() { }

	// RVA: 0x1A77158 Offset: 0x1A73158 VA: 0x1A77158
	internal void SetParentRowToDBNull(DataRelation relation) { }

	// RVA: 0x1A772D0 Offset: 0x1A732D0 VA: 0x1A772D0
	internal int CopyValuesIntoStore(ArrayList storeList, ArrayList nullbitList, int storeIndex) { }
}

// Namespace: System.Data
public sealed class DataRowBuilder // TypeDefIndex: 4468
{
	// Fields
	internal readonly DataTable _table; // 0x10
	internal int _record; // 0x18

	// Methods

	// RVA: 0x1A775BC Offset: 0x1A735BC VA: 0x1A775BC
	internal void .ctor(DataTable table, int record) { }
}

// Namespace: System.Data
[Flags]
public enum DataRowAction // TypeDefIndex: 4469
{
	// Fields
	public int value__; // 0x0
	public const DataRowAction Nothing = 0;
	public const DataRowAction Delete = 1;
	public const DataRowAction Change = 2;
	public const DataRowAction Rollback = 4;
	public const DataRowAction Commit = 8;
	public const DataRowAction Add = 16;
	public const DataRowAction ChangeOriginal = 32;
	public const DataRowAction ChangeCurrentAndOriginal = 64;
}

// Namespace: System.Data
public class DataRowChangeEventArgs : EventArgs // TypeDefIndex: 4470
{
	// Fields
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly DataRowAction <Action>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1A775F8 Offset: 0x1A735F8 VA: 0x1A775F8
	public void .ctor(DataRow row, DataRowAction action) { }
}

// Namespace: System.Data
public sealed class DataRowChangeEventHandler : MulticastDelegate // TypeDefIndex: 4471
{
	// Methods

	// RVA: 0x1A77678 Offset: 0x1A73678 VA: 0x1A77678
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A77784 Offset: 0x1A73784 VA: 0x1A77784 Slot: 12
	public virtual void Invoke(object sender, DataRowChangeEventArgs e) { }
}

// Namespace: 
private sealed class DataRowCollection.DataRowTree : RBTree<DataRow> // TypeDefIndex: 4472
{
	// Methods

	// RVA: 0x1A77840 Offset: 0x1A73840 VA: 0x1A77840
	internal void .ctor() { }

	// RVA: 0x1A77ED8 Offset: 0x1A73ED8 VA: 0x1A77ED8 Slot: 5
	protected override int CompareNode(DataRow record1, DataRow record2) { }

	// RVA: 0x1A77F04 Offset: 0x1A73F04 VA: 0x1A77F04 Slot: 6
	protected override int CompareSateliteTreeNode(DataRow record1, DataRow record2) { }
}

// Namespace: System.Data
[DefaultMember("Item")]
public sealed class DataRowCollection : InternalDataCollectionBase // TypeDefIndex: 4473
{
	// Fields
	private readonly DataTable _table; // 0x10
	private readonly DataRowCollection.DataRowTree _list; // 0x18
	internal int _nullInList; // 0x20

	// Properties
	public override int Count { get; }
	public DataRow Item { get; }

	// Methods

	// RVA: 0x1A77798 Offset: 0x1A73798 VA: 0x1A77798
	internal void .ctor(DataTable table) { }

	// RVA: 0x1A7788C Offset: 0x1A7388C VA: 0x1A7788C Slot: 9
	public override int get_Count() { }

	// RVA: 0x1A6C0CC Offset: 0x1A680CC VA: 0x1A6C0CC
	public DataRow get_Item(int index) { }

	// RVA: 0x1A778DC Offset: 0x1A738DC VA: 0x1A778DC
	public void Add(DataRow row) { }

	// RVA: 0x1A778F8 Offset: 0x1A738F8 VA: 0x1A778F8
	internal void DiffInsertAt(DataRow row, int pos) { }

	// RVA: 0x1A77AFC Offset: 0x1A73AFC VA: 0x1A77AFC
	public int IndexOf(DataRow row) { }

	// RVA: 0x1A77B94 Offset: 0x1A73B94 VA: 0x1A77B94
	internal DataRow AddWithColumnEvents(object[] values) { }

	// RVA: 0x1A77BF4 Offset: 0x1A73BF4 VA: 0x1A77BF4
	internal void ArrayAdd(DataRow row) { }

	// RVA: 0x1A77C5C Offset: 0x1A73C5C VA: 0x1A77C5C
	internal void ArrayInsert(DataRow row, int pos) { }

	// RVA: 0x1A77CD4 Offset: 0x1A73CD4 VA: 0x1A77CD4
	internal void ArrayClear() { }

	// RVA: 0x1A77D24 Offset: 0x1A73D24 VA: 0x1A77D24
	internal void ArrayRemove(DataRow row) { }

	// RVA: 0x1A77DB8 Offset: 0x1A73DB8 VA: 0x1A77DB8 Slot: 10
	public override void CopyTo(Array ar, int index) { }

	// RVA: 0x1A77E20 Offset: 0x1A73E20 VA: 0x1A77E20
	public void CopyTo(DataRow[] array, int index) { }

	// RVA: 0x1A77E88 Offset: 0x1A73E88 VA: 0x1A77E88 Slot: 11
	public override IEnumerator GetEnumerator() { }
}

// Namespace: System.Data
internal sealed class DataRowCreatedEventHandler : MulticastDelegate // TypeDefIndex: 4474
{
	// Methods

	// RVA: 0x1A77F30 Offset: 0x1A73F30 VA: 0x1A77F30
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A7803C Offset: 0x1A7403C VA: 0x1A7803C Slot: 12
	public virtual void Invoke(object sender, DataRow r) { }
}

// Namespace: System.Data
internal sealed class DataSetClearEventhandler : MulticastDelegate // TypeDefIndex: 4475
{
	// Methods

	// RVA: 0x1A78050 Offset: 0x1A74050 VA: 0x1A78050
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A7815C Offset: 0x1A7415C VA: 0x1A7815C Slot: 12
	public virtual void Invoke(object sender, DataTable table) { }
}

// Namespace: System.Data
[Flags]
public enum DataRowState // TypeDefIndex: 4476
{
	// Fields
	public int value__; // 0x0
	public const DataRowState Detached = 1;
	public const DataRowState Unchanged = 2;
	public const DataRowState Added = 4;
	public const DataRowState Deleted = 8;
	public const DataRowState Modified = 16;
}

// Namespace: System.Data
public enum DataRowVersion // TypeDefIndex: 4477
{
	// Fields
	public int value__; // 0x0
	public const DataRowVersion Original = 256;
	public const DataRowVersion Current = 512;
	public const DataRowVersion Proposed = 1024;
	public const DataRowVersion Default = 1536;
}

// Namespace: System.Data
[DefaultMember("Item")]
public class DataRowView : ICustomTypeDescriptor // TypeDefIndex: 4478
{
	// Fields
	private readonly DataView _dataView; // 0x10
	private readonly DataRow _row; // 0x18
	private bool _delayBeginEdit; // 0x20
	private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection; // 0x0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; // 0x28

	// Properties
	public DataView DataView { get; }
	private DataRowVersion RowVersionDefault { get; }
	public DataRow Row { get; }
	public bool IsNew { get; }

	// Methods

	// RVA: 0x1A78170 Offset: 0x1A74170 VA: 0x1A78170
	internal void .ctor(DataView dataView, DataRow row) { }

	// RVA: 0x1A781B4 Offset: 0x1A741B4 VA: 0x1A781B4 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1A781C0 Offset: 0x1A741C0 VA: 0x1A781C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A781DC Offset: 0x1A741DC VA: 0x1A781DC
	public DataView get_DataView() { }

	// RVA: 0x1A781E4 Offset: 0x1A741E4 VA: 0x1A781E4
	private DataRowVersion get_RowVersionDefault() { }

	// RVA: 0x1A7823C Offset: 0x1A7423C VA: 0x1A7823C
	internal int GetRecord() { }

	// RVA: 0x1A78260 Offset: 0x1A74260 VA: 0x1A78260
	internal bool HasRecord() { }

	// RVA: 0x1A6CE10 Offset: 0x1A68E10 VA: 0x1A6CE10
	internal object GetColumnValue(DataColumn column) { }

	// RVA: 0x1A6CF90 Offset: 0x1A68F90 VA: 0x1A6CF90
	internal void SetColumnValue(DataColumn column, object value) { }

	// RVA: 0x1A78284 Offset: 0x1A74284 VA: 0x1A78284
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	// RVA: 0x1A74214 Offset: 0x1A70214 VA: 0x1A74214
	public DataView CreateChildView(DataRelation relation) { }

	// RVA: 0x1A78420 Offset: 0x1A74420 VA: 0x1A78420
	public DataRow get_Row() { }

	// RVA: 0x1A78428 Offset: 0x1A74428 VA: 0x1A78428 Slot: 9
	public void EndEdit() { }

	// RVA: 0x1A78474 Offset: 0x1A74474 VA: 0x1A78474
	public bool get_IsNew() { }

	// RVA: 0x1A78498 Offset: 0x1A74498 VA: 0x1A78498
	internal void RaisePropertyChangedEvent(string propName) { }

	// RVA: 0x1A78528 Offset: 0x1A74528 VA: 0x1A78528 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x1A78580 Offset: 0x1A74580 VA: 0x1A78580 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x1A78588 Offset: 0x1A74588 VA: 0x1A78588 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1A78624 Offset: 0x1A74624 VA: 0x1A78624 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x1A786AC Offset: 0x1A746AC VA: 0x1A786AC Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0x1A786B0 Offset: 0x1A746B0 VA: 0x1A786B0
	private static void .cctor() { }
}

// Namespace: System.Data
public enum SerializationFormat // TypeDefIndex: 4479
{
	// Fields
	public int value__; // 0x0
	public const SerializationFormat Xml = 0;
	public const SerializationFormat Binary = 1;
}

// Namespace: System.Data
public enum DataSetDateTime // TypeDefIndex: 4480
{
	// Fields
	public int value__; // 0x0
	public const DataSetDateTime Local = 1;
	public const DataSetDateTime Unspecified = 2;
	public const DataSetDateTime UnspecifiedLocal = 3;
	public const DataSetDateTime Utc = 4;
}

// Namespace: System.Data
public sealed class DataTableClearEventArgs : EventArgs // TypeDefIndex: 4481
{
	// Fields
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1A78730 Offset: 0x1A74730 VA: 0x1A78730
	public void .ctor(DataTable dataTable) { }
}

// Namespace: System.Data
public sealed class DataTableClearEventHandler : MulticastDelegate // TypeDefIndex: 4482
{
	// Methods

	// RVA: 0x1A787A4 Offset: 0x1A747A4 VA: 0x1A787A4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A788B0 Offset: 0x1A748B0 VA: 0x1A788B0 Slot: 12
	public virtual void Invoke(object sender, DataTableClearEventArgs e) { }
}

// Namespace: System.Data
[DefaultMember("Item")]
[DefaultEvent("CollectionChanged")]
[ListBindable(False)]
public sealed class DataTableCollection : InternalDataCollectionBase // TypeDefIndex: 4483
{
	// Fields
	private readonly DataSet _dataSet; // 0x10
	private readonly ArrayList _list; // 0x18
	private int _defaultNameIndex; // 0x20
	private DataTable[] _delayedAddRangeTables; // 0x28
	private CollectionChangeEventHandler _onCollectionChangedDelegate; // 0x30
	private CollectionChangeEventHandler _onCollectionChangingDelegate; // 0x38
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x40

	// Properties
	protected override ArrayList List { get; }
	internal int ObjectID { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }
	public DataTable Item { get; }

	// Methods

	// RVA: 0x1A788C4 Offset: 0x1A748C4 VA: 0x1A788C4
	internal void .ctor(DataSet dataSet) { }

	// RVA: 0x1A78A30 Offset: 0x1A74A30 VA: 0x1A78A30 Slot: 12
	protected override ArrayList get_List() { }

	// RVA: 0x1A78A38 Offset: 0x1A74A38 VA: 0x1A78A38
	internal int get_ObjectID() { }

	// RVA: 0x1A78A40 Offset: 0x1A74A40 VA: 0x1A78A40
	public DataTable get_Item(int index) { }

	// RVA: 0x1A78B70 Offset: 0x1A74B70 VA: 0x1A78B70
	public DataTable get_Item(string name) { }

	// RVA: 0x1A7153C Offset: 0x1A6D53C VA: 0x1A7153C
	public DataTable get_Item(string name, string tableNamespace) { }

	// RVA: 0x1A78FB8 Offset: 0x1A74FB8 VA: 0x1A78FB8
	internal DataTable GetTable(string name, string ns) { }

	// RVA: 0x1A790D4 Offset: 0x1A750D4 VA: 0x1A790D4
	internal DataTable GetTableSmart(string name, string ns) { }

	// RVA: 0x1A7920C Offset: 0x1A7520C VA: 0x1A7920C
	public void Add(DataTable table) { }

	// RVA: 0x1A7965C Offset: 0x1A7565C VA: 0x1A7965C
	private void ArrayAdd(DataTable table) { }

	// RVA: 0x1A7974C Offset: 0x1A7574C VA: 0x1A7974C
	internal string AssignName() { }

	// RVA: 0x1A79548 Offset: 0x1A75548 VA: 0x1A79548
	private void BaseAdd(DataTable table) { }

	// RVA: 0x1A79AC4 Offset: 0x1A75AC4 VA: 0x1A79AC4
	private void BaseGroupSwitch(DataTable[] oldArray, int oldLength, DataTable[] newArray, int newLength) { }

	// RVA: 0x1A79C38 Offset: 0x1A75C38 VA: 0x1A79C38
	private void BaseRemove(DataTable table) { }

	// RVA: 0x1A79CB0 Offset: 0x1A75CB0 VA: 0x1A79CB0
	internal bool CanRemove(DataTable table, bool fThrowException) { }

	// RVA: 0x1A7A208 Offset: 0x1A76208 VA: 0x1A7A208
	public void Clear() { }

	// RVA: 0x1A7984C Offset: 0x1A7584C VA: 0x1A7984C
	public bool Contains(string name) { }

	// RVA: 0x1A7A4B4 Offset: 0x1A764B4 VA: 0x1A7A4B4
	internal bool Contains(string name, string tableNamespace, bool checkProperty, bool caseSensitive) { }

	// RVA: 0x1A7A628 Offset: 0x1A76628 VA: 0x1A7A628
	internal bool Contains(string name, bool caseSensitive) { }

	// RVA: 0x1A7A750 Offset: 0x1A76750 VA: 0x1A7A750
	public int IndexOf(DataTable table) { }

	// RVA: 0x1A7A834 Offset: 0x1A76834 VA: 0x1A7A834
	public int IndexOf(string tableName) { }

	// RVA: 0x1A7A84C Offset: 0x1A7684C VA: 0x1A7A84C
	internal int IndexOf(string tableName, string tableNamespace, bool chekforNull) { }

	// RVA: 0x1A7A8AC Offset: 0x1A768AC VA: 0x1A7A8AC
	internal void ReplaceFromInference(List<DataTable> tableList) { }

	// RVA: 0x1A78C64 Offset: 0x1A74C64 VA: 0x1A78C64
	internal int InternalIndexOf(string tableName) { }

	// RVA: 0x1A78E2C Offset: 0x1A74E2C VA: 0x1A78E2C
	internal int InternalIndexOf(string tableName, string tableNamespace) { }

	// RVA: 0x1A79794 Offset: 0x1A75794 VA: 0x1A79794
	private string MakeName(int index) { }

	// RVA: 0x1A7967C Offset: 0x1A7567C VA: 0x1A7967C
	private void OnCollectionChanged(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1A79478 Offset: 0x1A75478 VA: 0x1A79478
	private void OnCollectionChanging(CollectionChangeEventArgs ccevent) { }

	// RVA: 0x1A79864 Offset: 0x1A75864 VA: 0x1A79864
	internal void RegisterName(string name, string tbNamespace) { }

	// RVA: 0x1A7A8FC Offset: 0x1A768FC VA: 0x1A7A8FC
	public void Remove(DataTable table) { }

	// RVA: 0x1A7A0FC Offset: 0x1A760FC VA: 0x1A7A0FC
	internal void UnregisterName(string name) { }
}

// Namespace: System.Data
public sealed class DataTableNewRowEventArgs : EventArgs // TypeDefIndex: 4484
{
	// Fields
	[CompilerGenerated]
	private readonly DataRow <Row>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1A7AAC8 Offset: 0x1A76AC8 VA: 0x1A7AAC8
	public void .ctor(DataRow dataRow) { }
}

// Namespace: System.Data
public sealed class DataTableNewRowEventHandler : MulticastDelegate // TypeDefIndex: 4485
{
	// Methods

	// RVA: 0x1A7AB3C Offset: 0x1A76B3C VA: 0x1A7AB3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A7AC48 Offset: 0x1A76C48 VA: 0x1A7AC48 Slot: 12
	public virtual void Invoke(object sender, DataTableNewRowEventArgs e) { }
}

// Namespace: System.Data
internal sealed class DataTableTypeConverter : ReferenceConverter // TypeDefIndex: 4486
{
	// Methods

	// RVA: 0x1A7AC5C Offset: 0x1A76C5C VA: 0x1A7AC5C
	public void .ctor() { }

	// RVA: 0x1A7ACFC Offset: 0x1A76CFC VA: 0x1A7ACFC Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }
}

// Namespace: 
private sealed class DataView.DataRowReferenceComparer : IEqualityComparer<DataRow> // TypeDefIndex: 4487
{
	// Fields
	internal static readonly DataView.DataRowReferenceComparer s_default; // 0x0

	// Methods

	// RVA: 0x1A7DE0C Offset: 0x1A79E0C VA: 0x1A7DE0C
	private void .ctor() { }

	// RVA: 0x1A7DE14 Offset: 0x1A79E14 VA: 0x1A7DE14 Slot: 4
	public bool Equals(DataRow x, DataRow y) { }

	// RVA: 0x1A7DE20 Offset: 0x1A79E20 VA: 0x1A7DE20 Slot: 5
	public int GetHashCode(DataRow obj) { }

	// RVA: 0x1A7DE34 Offset: 0x1A79E34 VA: 0x1A7DE34
	private static void .cctor() { }
}

// Namespace: System.Data
[DefaultMember("Item")]
[DefaultEvent("PositionChanged")]
[DefaultProperty("Table")]
public class DataView : MarshalByValueComponent, IBindingList, IList, ICollection, IEnumerable // TypeDefIndex: 4488
{
	// Fields
	private DataViewManager _dataViewManager; // 0x20
	private DataTable _table; // 0x28
	private bool _locked; // 0x30
	private Index _index; // 0x38
	private Dictionary<string, Index> _findIndexes; // 0x40
	private string _sort; // 0x48
	private Comparison<DataRow> _comparison; // 0x50
	private IFilter _rowFilter; // 0x58
	private DataViewRowState _recordStates; // 0x60
	private bool _shouldOpen; // 0x64
	private bool _open; // 0x65
	private bool _allowNew; // 0x66
	private bool _allowEdit; // 0x67
	private bool _allowDelete; // 0x68
	private bool _applyDefaultSort; // 0x69
	internal DataRow _addNewRow; // 0x70
	private ListChangedEventArgs _addNewMoved; // 0x78
	private ListChangedEventHandler _onListChanged; // 0x80
	internal static ListChangedEventArgs s_resetEventArgs; // 0x0
	private DataViewRowState _delayedRecordStates; // 0x88
	private bool _fEndInitInProgress; // 0x8C
	private Dictionary<DataRow, DataRowView> _rowViewCache; // 0x90
	private readonly Dictionary<DataRow, DataRowView> _rowViewBuffer; // 0x98
	private DataViewListener _dvListener; // 0xA0
	private static int s_objectTypeCount; // 0x8
	private readonly int _objectID; // 0xA8

	// Properties
	[DefaultValue(True)]
	public bool AllowDelete { get; }
	[DefaultValue(True)]
	public bool AllowNew { get; }
	[Browsable(False)]
	public int Count { get; }
	private int CountFromIndex { get; }
	[Browsable(False)]
	public DataViewManager DataViewManager { get; }
	[Browsable(False)]
	protected bool IsOpen { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	[DefaultValue(22)]
	public DataViewRowState RowStateFilter { get; }
	[DefaultValue("")]
	public string Sort { get; }
	internal Comparison<DataRow> SortComparison { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	[DefaultValue(null)]
	[RefreshProperties(1)]
	[TypeConverter(typeof(DataTableTypeConverter))]
	public DataTable Table { get; }
	private object System.Collections.IList.Item { get; set; }
	public DataRowView Item { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	internal int ObjectID { get; }

	// Methods

	// RVA: 0x1A7AD04 Offset: 0x1A76D04 VA: 0x1A7AD04
	internal void .ctor(DataTable table, bool locked) { }

	// RVA: 0x1A7B248 Offset: 0x1A77248 VA: 0x1A7B248
	public bool get_AllowDelete() { }

	// RVA: 0x1A7B250 Offset: 0x1A77250 VA: 0x1A7B250
	public bool get_AllowNew() { }

	// RVA: 0x1A7B258 Offset: 0x1A77258 VA: 0x1A7B258 Slot: 22
	public int get_Count() { }

	// RVA: 0x1A7B2A8 Offset: 0x1A772A8 VA: 0x1A7B2A8
	private int get_CountFromIndex() { }

	// RVA: 0x1A7B2C4 Offset: 0x1A772C4 VA: 0x1A7B2C4
	public DataViewManager get_DataViewManager() { }

	// RVA: 0x1A7B2CC Offset: 0x1A772CC VA: 0x1A7B2CC
	protected bool get_IsOpen() { }

	// RVA: 0x1A7B2D4 Offset: 0x1A772D4 VA: 0x1A7B2D4 Slot: 24
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1A7B2DC Offset: 0x1A772DC VA: 0x1A7B2DC
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x1A7B2E4 Offset: 0x1A772E4 VA: 0x1A7B2E4
	public string get_Sort() { }

	// RVA: 0x1A7B338 Offset: 0x1A77338 VA: 0x1A7B338
	internal Comparison<DataRow> get_SortComparison() { }

	// RVA: 0x1A7B340 Offset: 0x1A77340 VA: 0x1A7B340 Slot: 23
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1A7B344 Offset: 0x1A77344 VA: 0x1A7B344
	public DataTable get_Table() { }

	// RVA: 0x1A7B34C Offset: 0x1A7734C VA: 0x1A7B34C Slot: 10
	private object System.Collections.IList.get_Item(int recordIndex) { }

	// RVA: 0x1A7B384 Offset: 0x1A77384 VA: 0x1A7B384 Slot: 11
	private void System.Collections.IList.set_Item(int recordIndex, object value) { }

	// RVA: 0x1A7B368 Offset: 0x1A77368 VA: 0x1A7B368
	public DataRowView get_Item(int recordIndex) { }

	// RVA: 0x1A7B4A0 Offset: 0x1A774A0 VA: 0x1A7B4A0 Slot: 26
	public virtual DataRowView AddNew() { }

	// RVA: 0x1A7B75C Offset: 0x1A7775C VA: 0x1A7B75C
	private void CheckOpen() { }

	// RVA: 0x1A7B868 Offset: 0x1A77868 VA: 0x1A7B868
	protected void Close() { }

	// RVA: 0x1A7B8BC Offset: 0x1A778BC VA: 0x1A7B8BC Slot: 21
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1A7BA30 Offset: 0x1A77A30 VA: 0x1A7BA30
	private void CopyTo(DataRowView[] array, int index) { }

	// RVA: 0x1A7BBE0 Offset: 0x1A77BE0 VA: 0x1A7BBE0
	public void Delete(int index) { }

	// RVA: 0x1A7BBFC Offset: 0x1A77BFC VA: 0x1A7BBFC
	internal void Delete(DataRow row) { }

	// RVA: 0x1A7BF58 Offset: 0x1A77F58 VA: 0x1A7BF58 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1A7BDA0 Offset: 0x1A77DA0 VA: 0x1A7BDA0
	internal void FinishAddNew(bool success) { }

	// RVA: 0x1A7BF8C Offset: 0x1A77F8C VA: 0x1A7BF8C Slot: 25
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1A7C008 Offset: 0x1A78008 VA: 0x1A7C008 Slot: 15
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1A7C010 Offset: 0x1A78010 VA: 0x1A7C010 Slot: 16
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1A7C018 Offset: 0x1A78018 VA: 0x1A7C018 Slot: 12
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1A7C06C Offset: 0x1A7806C VA: 0x1A7C06C Slot: 14
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1A7C094 Offset: 0x1A78094 VA: 0x1A7C094 Slot: 13
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1A7C120 Offset: 0x1A78120 VA: 0x1A7C120 Slot: 17
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1A7B790 Offset: 0x1A77790 VA: 0x1A7B790
	internal int IndexOf(DataRowView rowview) { }

	// RVA: 0x1A7C1A0 Offset: 0x1A781A0 VA: 0x1A7C1A0
	private int IndexOfDataRowView(DataRowView rowview) { }

	// RVA: 0x1A7C1F8 Offset: 0x1A781F8 VA: 0x1A7C1F8 Slot: 18
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1A7C220 Offset: 0x1A78220 VA: 0x1A7C220 Slot: 19
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1A7C340 Offset: 0x1A78340 VA: 0x1A7C340 Slot: 20
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1A7C35C Offset: 0x1A7835C VA: 0x1A7C35C Slot: 27
	internal virtual IFilter GetFilter() { }

	// RVA: 0x1A7C364 Offset: 0x1A78364 VA: 0x1A7C364
	private int GetRecord(int recordIndex) { }

	// RVA: 0x1A7B3AC Offset: 0x1A773AC VA: 0x1A7B3AC
	internal DataRow GetRow(int index) { }

	// RVA: 0x1A7B9FC Offset: 0x1A779FC VA: 0x1A7B9FC
	private DataRowView GetRowView(int record) { }

	// RVA: 0x1A7B448 Offset: 0x1A77448 VA: 0x1A7B448
	private DataRowView GetRowView(DataRow dr) { }

	// RVA: 0x1A7C3EC Offset: 0x1A783EC VA: 0x1A7C3EC Slot: 28
	protected virtual void IndexListChanged(object sender, ListChangedEventArgs e) { }

	// RVA: 0x1A7C47C Offset: 0x1A7847C VA: 0x1A7C47C
	internal void IndexListChangedInternal(ListChangedEventArgs e) { }

	// RVA: 0x1A7C53C Offset: 0x1A7853C VA: 0x1A7C53C
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x1A7C9F8 Offset: 0x1A789F8 VA: 0x1A7C9F8 Slot: 29
	protected virtual void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x1A7CD3C Offset: 0x1A78D3C VA: 0x1A7CD3C
	protected void Reset() { }

	// RVA: 0x1A7C7BC Offset: 0x1A787BC VA: 0x1A7C7BC
	internal void ResetRowViewCache() { }

	// RVA: 0x1A7CD60 Offset: 0x1A78D60 VA: 0x1A7CD60
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x1A7CFE0 Offset: 0x1A78FE0 VA: 0x1A7CFE0 Slot: 30
	internal virtual void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

	// RVA: 0x1A7CFE8 Offset: 0x1A78FE8 VA: 0x1A7CFE8
	internal void SetIndex2(string newSort, DataViewRowState newRowStates, IFilter newRowFilter, bool fireEvent) { }

	// RVA: 0x1A7B8A0 Offset: 0x1A778A0 VA: 0x1A7B8A0
	protected void UpdateIndex() { }

	// RVA: 0x1A7D544 Offset: 0x1A79544 VA: 0x1A7D544 Slot: 31
	protected virtual void UpdateIndex(bool force) { }

	// RVA: 0x1A7D238 Offset: 0x1A79238 VA: 0x1A7D238
	internal void UpdateIndex(bool force, bool fireEvent) { }

	// RVA: 0x1A7D740 Offset: 0x1A79740 VA: 0x1A7D740
	internal void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1A7D950 Offset: 0x1A79950 VA: 0x1A7D950
	internal void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1A7DB60 Offset: 0x1A79B60 VA: 0x1A7DB60 Slot: 32
	protected virtual void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1A7DD70 Offset: 0x1A79D70 VA: 0x1A7DD70
	internal void ColumnCollectionChangedInternal(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1A7DD80 Offset: 0x1A79D80 VA: 0x1A7DD80
	internal int get_ObjectID() { }

	// RVA: 0x1A7DD88 Offset: 0x1A79D88 VA: 0x1A7DD88
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class DataViewListener // TypeDefIndex: 4489
{
	// Fields
	private readonly WeakReference _dvWeak; // 0x10
	private DataTable _table; // 0x18
	private Index _index; // 0x20
	internal readonly int _objectID; // 0x28

	// Methods

	// RVA: 0x1A7AFDC Offset: 0x1A76FDC VA: 0x1A7AFDC
	internal void .ctor(DataView dv) { }

	// RVA: 0x1A7DE9C Offset: 0x1A79E9C VA: 0x1A7DE9C
	private void ChildRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1A7DF64 Offset: 0x1A79F64 VA: 0x1A7DF64
	private void ParentRelationCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1A7E014 Offset: 0x1A7A014 VA: 0x1A7E014
	private void ColumnCollectionChanged(object sender, CollectionChangeEventArgs e) { }

	// RVA: 0x1A7E0E0 Offset: 0x1A7A0E0 VA: 0x1A7E0E0
	internal void MaintainDataView(ListChangedType changedType, DataRow row, bool trackAddRemove) { }

	// RVA: 0x1A7E1AC Offset: 0x1A7A1AC VA: 0x1A7E1AC
	internal void IndexListChanged(ListChangedEventArgs e) { }

	// RVA: 0x1A7B060 Offset: 0x1A77060 VA: 0x1A7B060
	internal void RegisterMetaDataEvents(DataTable table) { }

	// RVA: 0x1A7B8B4 Offset: 0x1A778B4 VA: 0x1A7B8B4
	internal void UnregisterMetaDataEvents() { }

	// RVA: 0x1A7E490 Offset: 0x1A7A490 VA: 0x1A7E490
	private void UnregisterMetaDataEvents(bool updateListeners) { }

	// RVA: 0x1A7D654 Offset: 0x1A79654 VA: 0x1A7D654
	internal void RegisterListChangedEvent(Index index) { }

	// RVA: 0x1A7D54C Offset: 0x1A7954C VA: 0x1A7D54C
	internal void UnregisterListChangedEvent() { }

	// RVA: 0x1A7DF4C Offset: 0x1A79F4C VA: 0x1A7DF4C
	private void CleanUp(bool updateListeners) { }

	// RVA: 0x1A7E25C Offset: 0x1A7A25C VA: 0x1A7E25C
	private void RegisterListener(DataTable table) { }
}

// Namespace: System.Data
public class DataViewManager : MarshalByValueComponent // TypeDefIndex: 4490
{
	// Fields
	private DataViewSettingCollection _dataViewSettingsCollection; // 0x20
	internal int _nViews; // 0x28
	private static NotSupportedException s_notSupported; // 0x0

	// Properties
	[DesignerSerializationVisibility(2)]
	public DataViewSettingCollection DataViewSettings { get; }

	// Methods

	// RVA: 0x1A7E740 Offset: 0x1A7A740 VA: 0x1A7E740
	public DataViewSettingCollection get_DataViewSettings() { }

	// RVA: 0x1A7E748 Offset: 0x1A7A748 VA: 0x1A7E748
	private static void .cctor() { }
}

// Namespace: System.Data
[Flags]
public enum DataViewRowState // TypeDefIndex: 4491
{
	// Fields
	public int value__; // 0x0
	public const DataViewRowState None = 0;
	public const DataViewRowState Unchanged = 2;
	public const DataViewRowState Added = 4;
	public const DataViewRowState Deleted = 8;
	public const DataViewRowState ModifiedCurrent = 16;
	public const DataViewRowState ModifiedOriginal = 32;
	public const DataViewRowState OriginalRows = 42;
	public const DataViewRowState CurrentRows = 22;
}

// Namespace: System.Data
[TypeConverter(typeof(ExpandableObjectConverter))]
public class DataViewSetting // TypeDefIndex: 4492
{
	// Fields
	private DataViewManager _dataViewManager; // 0x10
	private DataTable _table; // 0x18
	private string _sort; // 0x20
	private string _rowFilter; // 0x28
	private DataViewRowState _rowStateFilter; // 0x30
	private bool _applyDefaultSort; // 0x34

	// Properties
	public bool ApplyDefaultSort { get; }
	public string RowFilter { get; }
	public DataViewRowState RowStateFilter { get; }
	public string Sort { get; }

	// Methods

	// RVA: 0x1A7E7C4 Offset: 0x1A7A7C4 VA: 0x1A7E7C4
	internal void .ctor() { }

	// RVA: 0x1A7E820 Offset: 0x1A7A820 VA: 0x1A7E820
	public bool get_ApplyDefaultSort() { }

	// RVA: 0x1A7E828 Offset: 0x1A7A828 VA: 0x1A7E828
	internal void SetDataViewManager(DataViewManager dataViewManager) { }

	// RVA: 0x1A7E840 Offset: 0x1A7A840 VA: 0x1A7E840
	internal void SetDataTable(DataTable table) { }

	// RVA: 0x1A7E858 Offset: 0x1A7A858 VA: 0x1A7E858
	public string get_RowFilter() { }

	// RVA: 0x1A7E860 Offset: 0x1A7A860 VA: 0x1A7E860
	public DataViewRowState get_RowStateFilter() { }

	// RVA: 0x1A7E868 Offset: 0x1A7A868 VA: 0x1A7E868
	public string get_Sort() { }
}

// Namespace: System.Data
[DefaultMember("Item")]
public class DataViewSettingCollection // TypeDefIndex: 4493
{
	// Fields
	private readonly DataViewManager _dataViewManager; // 0x10
	private readonly Hashtable _list; // 0x18

	// Properties
	public virtual DataViewSetting Item { get; set; }

	// Methods

	// RVA: 0x1A7E870 Offset: 0x1A7A870 VA: 0x1A7E870 Slot: 4
	public virtual DataViewSetting get_Item(DataTable table) { }

	// RVA: 0x1A7E978 Offset: 0x1A7A978 VA: 0x1A7E978 Slot: 5
	public virtual void set_Item(DataTable table, DataViewSetting value) { }

	// RVA: 0x1A7EA28 Offset: 0x1A7AA28 VA: 0x1A7EA28
	internal void Remove(DataTable table) { }
}

// Namespace: System.Data
internal sealed class DefaultValueTypeConverter : StringConverter // TypeDefIndex: 4494
{
	// Methods

	// RVA: 0x1A7EA48 Offset: 0x1A7AA48 VA: 0x1A7EA48
	public void .ctor() { }

	// RVA: 0x1A7EA50 Offset: 0x1A7AA50 VA: 0x1A7EA50 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1A7EBDC Offset: 0x1A7ABDC VA: 0x1A7EBDC Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }
}

// Namespace: System.Data
internal enum Aggregate // TypeDefIndex: 4495
{
	// Fields
	public int value__; // 0x0
	public const Aggregate None = -1;
	public const Aggregate Sum = 30;
	public const Aggregate Avg = 31;
	public const Aggregate Min = 32;
	public const Aggregate Max = 33;
	public const Aggregate Count = 34;
	public const Aggregate StDev = 35;
	public const Aggregate Var = 37;
}

// Namespace: System.Data
internal sealed class AggregateNode : ExpressionNode // TypeDefIndex: 4496
{
	// Fields
	private readonly AggregateType _type; // 0x18
	private readonly Aggregate _aggregate; // 0x1C
	private readonly bool _local; // 0x20
	private readonly string _relationName; // 0x28
	private readonly string _columnName; // 0x30
	private DataTable _childTable; // 0x38
	private DataColumn _column; // 0x40
	private DataRelation _relation; // 0x48

	// Methods

	// RVA: 0x1A7ED48 Offset: 0x1A7AD48 VA: 0x1A7ED48
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName) { }

	// RVA: 0x1A7ED54 Offset: 0x1A7AD54 VA: 0x1A7ED54
	internal void .ctor(DataTable table, FunctionId aggregateType, string columnName, bool local, string relationName) { }

	// RVA: 0x1A7EED4 Offset: 0x1A7AED4 VA: 0x1A7EED4 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1A7F288 Offset: 0x1A7B288 VA: 0x1A7F288
	internal static void Bind(DataRelation relation, List<DataColumn> list) { }

	// RVA: 0x1A7F48C Offset: 0x1A7B48C VA: 0x1A7F48C Slot: 6
	internal override object Eval() { }

	// RVA: 0x1A7F4A0 Offset: 0x1A7B4A0 VA: 0x1A7F4A0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A7F7C4 Offset: 0x1A7B7C4 VA: 0x1A7F7C4 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x1A7F888 Offset: 0x1A7B888 VA: 0x1A7F888 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1A7F890 Offset: 0x1A7B890 VA: 0x1A7F890 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1A7F898 Offset: 0x1A7B898 VA: 0x1A7F898 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1A7F8A0 Offset: 0x1A7B8A0 VA: 0x1A7F8A0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1A7F8B0 Offset: 0x1A7B8B0 VA: 0x1A7F8B0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x1A7F948 Offset: 0x1A7B948 VA: 0x1A7F948 Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: 
private enum BinaryNode.DataTypePrecedence // TypeDefIndex: 4497
{
	// Fields
	public int value__; // 0x0
	public const BinaryNode.DataTypePrecedence SqlDateTime = 25;
	public const BinaryNode.DataTypePrecedence DateTimeOffset = 24;
	public const BinaryNode.DataTypePrecedence DateTime = 23;
	public const BinaryNode.DataTypePrecedence TimeSpan = 20;
	public const BinaryNode.DataTypePrecedence SqlDouble = 19;
	public const BinaryNode.DataTypePrecedence Double = 18;
	public const BinaryNode.DataTypePrecedence SqlSingle = 17;
	public const BinaryNode.DataTypePrecedence Single = 16;
	public const BinaryNode.DataTypePrecedence SqlDecimal = 15;
	public const BinaryNode.DataTypePrecedence Decimal = 14;
	public const BinaryNode.DataTypePrecedence SqlMoney = 13;
	public const BinaryNode.DataTypePrecedence UInt64 = 12;
	public const BinaryNode.DataTypePrecedence SqlInt64 = 11;
	public const BinaryNode.DataTypePrecedence Int64 = 10;
	public const BinaryNode.DataTypePrecedence UInt32 = 9;
	public const BinaryNode.DataTypePrecedence SqlInt32 = 8;
	public const BinaryNode.DataTypePrecedence Int32 = 7;
	public const BinaryNode.DataTypePrecedence UInt16 = 6;
	public const BinaryNode.DataTypePrecedence SqlInt16 = 5;
	public const BinaryNode.DataTypePrecedence Int16 = 4;
	public const BinaryNode.DataTypePrecedence Byte = 3;
	public const BinaryNode.DataTypePrecedence SqlByte = 2;
	public const BinaryNode.DataTypePrecedence SByte = 1;
	public const BinaryNode.DataTypePrecedence Error = 0;
	public const BinaryNode.DataTypePrecedence SqlBoolean = -1;
	public const BinaryNode.DataTypePrecedence Boolean = -2;
	public const BinaryNode.DataTypePrecedence SqlGuid = -3;
	public const BinaryNode.DataTypePrecedence SqlString = -4;
	public const BinaryNode.DataTypePrecedence String = -5;
	public const BinaryNode.DataTypePrecedence SqlXml = -6;
	public const BinaryNode.DataTypePrecedence SqlChars = -7;
	public const BinaryNode.DataTypePrecedence Char = -8;
	public const BinaryNode.DataTypePrecedence SqlBytes = -9;
	public const BinaryNode.DataTypePrecedence SqlBinary = -10;
}

// Namespace: System.Data
internal class BinaryNode : ExpressionNode // TypeDefIndex: 4498
{
	// Fields
	internal int _op; // 0x18
	internal ExpressionNode _left; // 0x20
	internal ExpressionNode _right; // 0x28

	// Methods

	// RVA: 0x1A7F94C Offset: 0x1A7B94C VA: 0x1A7F94C
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x1A7F9B4 Offset: 0x1A7B9B4 VA: 0x1A7F9B4 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1A7FA24 Offset: 0x1A7BA24 VA: 0x1A7FA24 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1A7FA38 Offset: 0x1A7BA38 VA: 0x1A7FA38 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A85200 Offset: 0x1A81200 VA: 0x1A85200 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x1A8521C Offset: 0x1A8121C VA: 0x1A8521C Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1A85264 Offset: 0x1A81264 VA: 0x1A85264 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1A852AC Offset: 0x1A812AC VA: 0x1A852AC Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1A852F4 Offset: 0x1A812F4 VA: 0x1A852F4 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1A8533C Offset: 0x1A8133C VA: 0x1A8533C Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x1A853A0 Offset: 0x1A813A0 VA: 0x1A853A0 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x1A85954 Offset: 0x1A81954 VA: 0x1A85954
	internal void SetTypeMismatchError(int op, Type left, Type right) { }

	// RVA: 0x1A85A50 Offset: 0x1A81A50 VA: 0x1A85A50
	private static object Eval(ExpressionNode expr, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x1A85A88 Offset: 0x1A81A88 VA: 0x1A85A88
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op) { }

	// RVA: 0x1A85A90 Offset: 0x1A81A90 VA: 0x1A85A90
	internal int BinaryCompare(object vLeft, object vRight, StorageType resultType, int op, CompareInfo comparer) { }

	// RVA: 0x1A7FA54 Offset: 0x1A7BA54 VA: 0x1A7FA54
	private object EvalBinaryOp(int op, ExpressionNode left, ExpressionNode right, DataRow row, DataRowVersion version, int[] recordNos) { }

	// RVA: 0x1A87600 Offset: 0x1A83600 VA: 0x1A87600
	private BinaryNode.DataTypePrecedence GetPrecedence(StorageType storageType) { }

	// RVA: 0x1A87624 Offset: 0x1A83624 VA: 0x1A87624
	private static StorageType GetPrecedenceType(BinaryNode.DataTypePrecedence code) { }

	// RVA: 0x1A87648 Offset: 0x1A83648 VA: 0x1A87648
	private bool IsMixed(StorageType left, StorageType right) { }

	// RVA: 0x1A87704 Offset: 0x1A83704 VA: 0x1A87704
	private bool IsMixedSql(StorageType left, StorageType right) { }

	// RVA: 0x1A87148 Offset: 0x1A83148 VA: 0x1A87148
	internal StorageType ResultType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x1A86D60 Offset: 0x1A82D60 VA: 0x1A86D60
	internal StorageType ResultSqlType(StorageType left, StorageType right, bool lc, bool rc, int op) { }

	// RVA: 0x1A878FC Offset: 0x1A838FC VA: 0x1A878FC
	private int SqlResultType(int typeCode) { }
}

// Namespace: System.Data
internal sealed class LikeNode : BinaryNode // TypeDefIndex: 4499
{
	// Fields
	private int _kind; // 0x30
	private string _pattern; // 0x38

	// Methods

	// RVA: 0x1A8794C Offset: 0x1A8394C VA: 0x1A8794C
	internal void .ctor(DataTable table, int op, ExpressionNode left, ExpressionNode right) { }

	// RVA: 0x1A87950 Offset: 0x1A83950 VA: 0x1A87950 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A87E6C Offset: 0x1A83E6C VA: 0x1A87E6C
	internal string AnalyzePattern(string pat) { }
}

// Namespace: System.Data
internal sealed class ConstNode : ExpressionNode // TypeDefIndex: 4500
{
	// Fields
	internal readonly object _val; // 0x18

	// Methods

	// RVA: 0x1A88178 Offset: 0x1A84178 VA: 0x1A88178
	internal void .ctor(DataTable table, ValueType type, object constant) { }

	// RVA: 0x1A8562C Offset: 0x1A8162C VA: 0x1A8562C
	internal void .ctor(DataTable table, ValueType type, object constant, bool fParseQuotes) { }

	// RVA: 0x1A88AD4 Offset: 0x1A84AD4 VA: 0x1A88AD4 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1A88ADC Offset: 0x1A84ADC VA: 0x1A88ADC Slot: 6
	internal override object Eval() { }

	// RVA: 0x1A88AE4 Offset: 0x1A84AE4 VA: 0x1A88AE4 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A88AF0 Offset: 0x1A84AF0 VA: 0x1A88AF0 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x1A88AFC Offset: 0x1A84AFC VA: 0x1A88AFC Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1A88B04 Offset: 0x1A84B04 VA: 0x1A88B04 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1A88B0C Offset: 0x1A84B0C VA: 0x1A88B0C Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1A88B14 Offset: 0x1A84B14 VA: 0x1A88B14 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1A88B1C Offset: 0x1A84B1C VA: 0x1A88B1C Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x1A88690 Offset: 0x1A84690 VA: 0x1A88690
	private object SmallestDecimal(object constant) { }

	// RVA: 0x1A88180 Offset: 0x1A84180 VA: 0x1A88180
	private object SmallestNumeric(object constant) { }
}

// Namespace: System.Data
internal sealed class DataExpression : IFilter // TypeDefIndex: 4501
{
	// Fields
	internal string _originalExpression; // 0x10
	private bool _parsed; // 0x18
	private bool _bound; // 0x19
	private ExpressionNode _expr; // 0x20
	private DataTable _table; // 0x28
	private readonly StorageType _storageType; // 0x30
	private readonly Type _dataType; // 0x38
	private DataColumn[] _dependency; // 0x40

	// Properties
	internal string Expression { get; }
	internal bool HasValue { get; }

	// Methods

	// RVA: 0x1A7CFD8 Offset: 0x1A78FD8 VA: 0x1A7CFD8
	internal void .ctor(DataTable table, string expression) { }

	// RVA: 0x1A88B20 Offset: 0x1A84B20 VA: 0x1A88B20
	internal void .ctor(DataTable table, string expression, Type type) { }

	// RVA: 0x1A89DEC Offset: 0x1A85DEC VA: 0x1A89DEC
	internal string get_Expression() { }

	// RVA: 0x1A89E3C Offset: 0x1A85E3C VA: 0x1A89E3C
	internal bool get_HasValue() { }

	// RVA: 0x1A89CB4 Offset: 0x1A85CB4 VA: 0x1A89CB4
	internal void Bind(DataTable table) { }

	// RVA: 0x1A7F92C Offset: 0x1A7B92C VA: 0x1A7F92C
	internal bool DependsOn(DataColumn column) { }

	// RVA: 0x1A89E4C Offset: 0x1A85E4C VA: 0x1A89E4C
	internal object Evaluate() { }

	// RVA: 0x1A89E58 Offset: 0x1A85E58 VA: 0x1A89E58
	internal object Evaluate(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A8A110 Offset: 0x1A86110 VA: 0x1A8A110 Slot: 4
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A8A280 Offset: 0x1A86280 VA: 0x1A8A280
	internal DataColumn[] GetDependency() { }

	// RVA: 0x1A8A288 Offset: 0x1A86288 VA: 0x1A8A288
	internal bool IsTableAggregate() { }

	// RVA: 0x1A8A2A0 Offset: 0x1A862A0 VA: 0x1A8A2A0
	internal static bool IsUnknown(object value) { }

	// RVA: 0x1A8A2F8 Offset: 0x1A862F8 VA: 0x1A8A2F8
	internal bool HasLocalAggregate() { }

	// RVA: 0x1A8A310 Offset: 0x1A86310 VA: 0x1A8A310
	internal bool HasRemoteAggregate() { }

	// RVA: 0x1A86AE0 Offset: 0x1A82AE0 VA: 0x1A86AE0
	internal static bool ToBoolean(object value) { }
}

// Namespace: System.Data
internal abstract class ExpressionNode // TypeDefIndex: 4502
{
	// Fields
	private DataTable _table; // 0x10

	// Properties
	internal IFormatProvider FormatProvider { get; }
	internal virtual bool IsSqlColumn { get; }
	protected DataTable table { get; }

	// Methods

	// RVA: 0x1A7EE54 Offset: 0x1A7AE54 VA: 0x1A7EE54
	protected void .ctor(DataTable table) { }

	// RVA: 0x1A86A74 Offset: 0x1A82A74 VA: 0x1A86A74
	internal IFormatProvider get_FormatProvider() { }

	// RVA: 0x1A8A328 Offset: 0x1A86328 VA: 0x1A8A328 Slot: 4
	internal virtual bool get_IsSqlColumn() { }

	// RVA: 0x1A8A330 Offset: 0x1A86330 VA: 0x1A8A330
	protected DataTable get_table() { }

	// RVA: 0x1A8A338 Offset: 0x1A86338 VA: 0x1A8A338
	protected void BindTable(DataTable table) { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void Bind(DataTable table, List<DataColumn> list);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract object Eval();

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract object Eval(DataRow row, DataRowVersion version);

	// RVA: -1 Offset: -1 Slot: 8
	internal abstract object Eval(int[] recordNos);

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract bool IsConstant();

	// RVA: -1 Offset: -1 Slot: 10
	internal abstract bool IsTableConstant();

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract bool HasLocalAggregate();

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool HasRemoteAggregate();

	// RVA: -1 Offset: -1 Slot: 13
	internal abstract ExpressionNode Optimize();

	// RVA: 0x1A8A340 Offset: 0x1A86340 VA: 0x1A8A340 Slot: 14
	internal virtual bool DependsOn(DataColumn column) { }

	// RVA: 0x1A87820 Offset: 0x1A83820 VA: 0x1A87820
	internal static bool IsInteger(StorageType type) { }

	// RVA: 0x1A874B4 Offset: 0x1A834B4 VA: 0x1A874B4
	internal static bool IsIntegerSql(StorageType type) { }

	// RVA: 0x1A876C4 Offset: 0x1A836C4 VA: 0x1A876C4
	internal static bool IsSigned(StorageType type) { }

	// RVA: 0x1A87788 Offset: 0x1A83788 VA: 0x1A87788
	internal static bool IsSignedSql(StorageType type) { }

	// RVA: 0x1A876F4 Offset: 0x1A836F4 VA: 0x1A876F4
	internal static bool IsUnsigned(StorageType type) { }

	// RVA: 0x1A877A4 Offset: 0x1A837A4 VA: 0x1A877A4
	internal static bool IsUnsignedSql(StorageType type) { }

	// RVA: 0x1A87810 Offset: 0x1A83810 VA: 0x1A87810
	internal static bool IsNumeric(StorageType type) { }

	// RVA: 0x1A8792C Offset: 0x1A8392C VA: 0x1A8792C
	internal static bool IsNumericSql(StorageType type) { }

	// RVA: 0x1A8A348 Offset: 0x1A86348 VA: 0x1A8A348
	internal static bool IsFloat(StorageType type) { }

	// RVA: 0x1A8A358 Offset: 0x1A86358 VA: 0x1A8A358
	internal static bool IsFloatSql(StorageType type) { }
}

// Namespace: System.Data
internal enum ValueType // TypeDefIndex: 4503
{
	// Fields
	public int value__; // 0x0
	public const ValueType Unknown = -1;
	public const ValueType Null = 0;
	public const ValueType Bool = 1;
	public const ValueType Numeric = 2;
	public const ValueType Str = 3;
	public const ValueType Float = 4;
	public const ValueType Decimal = 5;
	public const ValueType Object = 6;
	public const ValueType Date = 7;
}

// Namespace: System.Data
internal enum Nodes // TypeDefIndex: 4504
{
	// Fields
	public int value__; // 0x0
	public const Nodes Noop = 0;
	public const Nodes Unop = 1;
	public const Nodes UnopSpec = 2;
	public const Nodes Binop = 3;
	public const Nodes BinopSpec = 4;
	public const Nodes Zop = 5;
	public const Nodes Call = 6;
	public const Nodes Const = 7;
	public const Nodes Name = 8;
	public const Nodes Paren = 9;
	public const Nodes Conv = 10;
}

// Namespace: 
[IsReadOnly]
private struct ExpressionParser.ReservedWords // TypeDefIndex: 4505
{
	// Fields
	internal readonly string _word; // 0x0
	internal readonly Tokens _token; // 0x8
	internal readonly int _op; // 0xC

	// Methods

	// RVA: 0x1A8C3F0 Offset: 0x1A883F0 VA: 0x1A8C3F0
	internal void .ctor(string word, Tokens token, int op) { }
}

// Namespace: System.Data
internal sealed class ExpressionParser // TypeDefIndex: 4506
{
	// Fields
	private static readonly ExpressionParser.ReservedWords[] s_reservedwords; // 0x0
	private char _escape; // 0x10
	private char _decimalSeparator; // 0x12
	private char _listSeparator; // 0x14
	private char _exponentL; // 0x16
	private char _exponentU; // 0x18
	internal char[] _text; // 0x20
	internal int _pos; // 0x28
	internal int _start; // 0x2C
	internal Tokens _token; // 0x30
	internal int _op; // 0x34
	internal OperatorInfo[] _ops; // 0x38
	internal int _topOperator; // 0x40
	internal int _topNode; // 0x44
	private readonly DataTable _table; // 0x48
	internal ExpressionNode[] _nodeStack; // 0x50
	internal int _prevOperand; // 0x58
	internal ExpressionNode _expression; // 0x60

	// Methods

	// RVA: 0x1A88D10 Offset: 0x1A84D10 VA: 0x1A88D10
	internal void .ctor(DataTable table) { }

	// RVA: 0x1A88DD4 Offset: 0x1A84DD4 VA: 0x1A88DD4
	internal void LoadExpression(string data) { }

	// RVA: 0x1A8A374 Offset: 0x1A86374 VA: 0x1A8A374
	internal void StartScan() { }

	// RVA: 0x1A88F48 Offset: 0x1A84F48 VA: 0x1A88F48
	internal ExpressionNode Parse() { }

	// RVA: 0x1A8AFF0 Offset: 0x1A86FF0 VA: 0x1A8AFF0
	private ExpressionNode ParseAggregateArgument(FunctionId aggregate) { }

	// RVA: 0x1A8AFB4 Offset: 0x1A86FB4 VA: 0x1A8AFB4
	private ExpressionNode NodePop() { }

	// RVA: 0x1A8AF30 Offset: 0x1A86F30 VA: 0x1A8AF30
	private ExpressionNode NodePeek() { }

	// RVA: 0x1A8AE98 Offset: 0x1A86E98 VA: 0x1A8AE98
	private void NodePush(ExpressionNode node) { }

	// RVA: 0x1A8A898 Offset: 0x1A86898 VA: 0x1A8A898
	private void BuildExpression(int pri) { }

	// RVA: 0x1A8AD54 Offset: 0x1A86D54 VA: 0x1A8AD54
	internal void CheckToken(Tokens token) { }

	// RVA: 0x1A8A448 Offset: 0x1A86448 VA: 0x1A8A448
	internal Tokens Scan() { }

	// RVA: 0x1A8BA80 Offset: 0x1A87A80 VA: 0x1A8BA80
	private void ScanNumeric() { }

	// RVA: 0x1A8BDE8 Offset: 0x1A87DE8 VA: 0x1A8BDE8
	private void ScanName() { }

	// RVA: 0x1A8B970 Offset: 0x1A87970 VA: 0x1A8B970
	private void ScanName(char chEnd, char esc, string charsToEscape) { }

	// RVA: 0x1A8B7FC Offset: 0x1A877FC VA: 0x1A8B7FC
	private void ScanDate() { }

	// RVA: 0x1A8BBB0 Offset: 0x1A87BB0 VA: 0x1A8BBB0
	private void ScanBinaryConstant() { }

	// RVA: 0x1A8BBC8 Offset: 0x1A87BC8 VA: 0x1A8BBC8
	private void ScanReserved() { }

	// RVA: 0x1A8B89C Offset: 0x1A8789C VA: 0x1A8B89C
	private void ScanString(char escape) { }

	// RVA: 0x1A8AB44 Offset: 0x1A86B44 VA: 0x1A8AB44
	internal void ScanToken(Tokens token) { }

	// RVA: 0x1A8B79C Offset: 0x1A8779C VA: 0x1A8B79C
	private void ScanWhite() { }

	// RVA: 0x1A8BF68 Offset: 0x1A87F68 VA: 0x1A8BF68
	private bool IsWhiteSpace(char ch) { }

	// RVA: 0x1A8BDA4 Offset: 0x1A87DA4 VA: 0x1A8BDA4
	private bool IsAlphaNumeric(char ch) { }

	// RVA: 0x1A8BBB4 Offset: 0x1A87BB4 VA: 0x1A8BBB4
	private bool IsDigit(char ch) { }

	// RVA: 0x1A8BEF4 Offset: 0x1A87EF4 VA: 0x1A8BEF4
	private bool IsAlpha(char ch) { }

	// RVA: 0x1A8BF7C Offset: 0x1A87F7C VA: 0x1A8BF7C
	private static void .cctor() { }
}

// Namespace: System.Data
internal enum Tokens // TypeDefIndex: 4507
{
	// Fields
	public int value__; // 0x0
	public const Tokens None = 0;
	public const Tokens Name = 1;
	public const Tokens Numeric = 2;
	public const Tokens Decimal = 3;
	public const Tokens Float = 4;
	public const Tokens BinaryConst = 5;
	public const Tokens StringConst = 6;
	public const Tokens Date = 7;
	public const Tokens ListSeparator = 8;
	public const Tokens LeftParen = 9;
	public const Tokens RightParen = 10;
	public const Tokens ZeroOp = 11;
	public const Tokens UnaryOp = 12;
	public const Tokens BinaryOp = 13;
	public const Tokens Child = 14;
	public const Tokens Parent = 15;
	public const Tokens Dot = 16;
	public const Tokens Unknown = 17;
	public const Tokens EOS = 18;
}

// Namespace: System.Data
internal sealed class OperatorInfo // TypeDefIndex: 4508
{
	// Fields
	internal Nodes _type; // 0x10
	internal int _op; // 0x14
	internal int _priority; // 0x18

	// Methods

	// RVA: 0x1A8A40C Offset: 0x1A8640C VA: 0x1A8A40C
	internal void .ctor(Nodes type, int op, int pri) { }
}

// Namespace: System.Data
[Serializable]
public class InvalidExpressionException : DataException // TypeDefIndex: 4509
{
	// Methods

	// RVA: 0x1A8C41C Offset: 0x1A8841C VA: 0x1A8C41C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A8C424 Offset: 0x1A88424 VA: 0x1A8C424
	public void .ctor() { }

	// RVA: 0x1A8C42C Offset: 0x1A8842C VA: 0x1A8C42C
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class EvaluateException : InvalidExpressionException // TypeDefIndex: 4510
{
	// Methods

	// RVA: 0x1A8C434 Offset: 0x1A88434 VA: 0x1A8C434
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A8C43C Offset: 0x1A8843C VA: 0x1A8C43C
	public void .ctor() { }

	// RVA: 0x1A8C444 Offset: 0x1A88444 VA: 0x1A8C444
	public void .ctor(string s) { }
}

// Namespace: System.Data
[Serializable]
public class SyntaxErrorException : InvalidExpressionException // TypeDefIndex: 4511
{
	// Methods

	// RVA: 0x1A8C44C Offset: 0x1A8844C VA: 0x1A8C44C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A8C454 Offset: 0x1A88454 VA: 0x1A8C454
	public void .ctor() { }

	// RVA: 0x1A8C45C Offset: 0x1A8845C VA: 0x1A8C45C
	public void .ctor(string s) { }
}

// Namespace: System.Data
internal sealed class ExprException // TypeDefIndex: 4512
{
	// Methods

	// RVA: 0x1A8C464 Offset: 0x1A88464 VA: 0x1A8C464
	private static OverflowException _Overflow(string error) { }

	// RVA: 0x1A8C4CC Offset: 0x1A884CC VA: 0x1A8C4CC
	private static InvalidExpressionException _Expr(string error) { }

	// RVA: 0x1A8C534 Offset: 0x1A88534 VA: 0x1A8C534
	private static SyntaxErrorException _Syntax(string error) { }

	// RVA: 0x1A8C59C Offset: 0x1A8859C VA: 0x1A8C59C
	private static EvaluateException _Eval(string error) { }

	// RVA: 0x1A8C604 Offset: 0x1A88604 VA: 0x1A8C604
	private static EvaluateException _Eval(string error, Exception innerException) { }

	// RVA: 0x1A8A1EC Offset: 0x1A861EC VA: 0x1A8A1EC
	public static Exception InvokeArgument() { }

	// RVA: 0x1A8C66C Offset: 0x1A8866C VA: 0x1A8C66C
	public static Exception NYI(string moreinfo) { }

	// RVA: 0x1A8A80C Offset: 0x1A8680C VA: 0x1A8A80C
	public static Exception MissingOperand(OperatorInfo before) { }

	// RVA: 0x1A8AAF4 Offset: 0x1A86AF4 VA: 0x1A8AAF4
	public static Exception MissingOperator(string token) { }

	// RVA: 0x1A8C6BC Offset: 0x1A886BC VA: 0x1A8C6BC
	public static Exception TypeMismatch(string expr) { }

	// RVA: 0x1A8C70C Offset: 0x1A8870C VA: 0x1A8C70C
	public static Exception FunctionArgumentOutOfRange(string arg, string func) { }

	// RVA: 0x1A8B648 Offset: 0x1A87648 VA: 0x1A8B648
	public static Exception ExpressionTooComplex() { }

	// RVA: 0x1A7F238 Offset: 0x1A7B238 VA: 0x1A7F238
	public static Exception UnboundName(string name) { }

	// RVA: 0x1A8BF18 Offset: 0x1A87F18 VA: 0x1A8BF18
	public static Exception InvalidString(string str) { }

	// RVA: 0x1A7EE84 Offset: 0x1A7AE84 VA: 0x1A7EE84
	public static Exception UndefinedFunction(string name) { }

	// RVA: 0x1A8AF74 Offset: 0x1A86F74 VA: 0x1A8AF74
	public static Exception SyntaxError() { }

	// RVA: 0x1A8C774 Offset: 0x1A88774 VA: 0x1A8C774
	public static Exception FunctionArgumentCount(string name) { }

	// RVA: 0x1A8AAB4 Offset: 0x1A86AB4 VA: 0x1A8AAB4
	public static Exception MissingRightParen() { }

	// RVA: 0x1A8B564 Offset: 0x1A87564 VA: 0x1A8B564
	public static Exception UnknownToken(string token, int position) { }

	// RVA: 0x1A8B688 Offset: 0x1A87688 VA: 0x1A8B688
	public static Exception UnknownToken(Tokens tokExpected, Tokens tokCurr, int position) { }

	// RVA: 0x1A8C7C4 Offset: 0x1A887C4 VA: 0x1A8C7C4
	public static Exception DatatypeConvertion(Type type1, Type type2) { }

	// RVA: 0x1A8A084 Offset: 0x1A86084 VA: 0x1A8A084
	public static Exception DatavalueConvertion(object value, Type type, Exception innerException) { }

	// RVA: 0x1A8C850 Offset: 0x1A88850 VA: 0x1A8C850
	public static Exception InvalidName(string name) { }

	// RVA: 0x1A8BEA4 Offset: 0x1A87EA4 VA: 0x1A8BEA4
	public static Exception InvalidDate(string date) { }

	// RVA: 0x1A8C8A0 Offset: 0x1A888A0 VA: 0x1A8C8A0
	public static Exception NonConstantArgument() { }

	// RVA: 0x1A88128 Offset: 0x1A84128 VA: 0x1A88128
	public static Exception InvalidPattern(string pat) { }

	// RVA: 0x1A874D4 Offset: 0x1A834D4 VA: 0x1A874D4
	public static Exception InWithoutParentheses() { }

	// RVA: 0x1A8C8E0 Offset: 0x1A888E0 VA: 0x1A8C8E0
	public static Exception InWithoutList() { }

	// RVA: 0x1A855EC Offset: 0x1A815EC VA: 0x1A855EC
	public static Exception InvalidIsSyntax() { }

	// RVA: 0x1A87594 Offset: 0x1A83594 VA: 0x1A87594
	public static Exception Overflow(Type type) { }

	// RVA: 0x1A8C920 Offset: 0x1A88920 VA: 0x1A8C920
	public static Exception ArgumentType(string function, int arg, Type type) { }

	// RVA: 0x1A8C9E8 Offset: 0x1A889E8 VA: 0x1A8C9E8
	public static Exception ArgumentTypeInteger(string function, int arg) { }

	// RVA: 0x1A85984 Offset: 0x1A81984 VA: 0x1A85984
	public static Exception TypeMismatchInBinop(int op, Type type1, Type type2) { }

	// RVA: 0x1A87830 Offset: 0x1A83830 VA: 0x1A87830
	public static Exception AmbiguousBinop(int op, Type type1, Type type2) { }

	// RVA: 0x1A87514 Offset: 0x1A83514 VA: 0x1A87514
	public static Exception UnsupportedOperator(int op) { }

	// RVA: 0x1A8BE54 Offset: 0x1A87E54 VA: 0x1A8BE54
	public static Exception InvalidNameBracketing(string name) { }

	// RVA: 0x1A8B364 Offset: 0x1A87364 VA: 0x1A8B364
	public static Exception MissingOperandBefore(string op) { }

	// RVA: 0x1A8B2D0 Offset: 0x1A872D0 VA: 0x1A8B2D0
	public static Exception TooManyRightParentheses() { }

	// RVA: 0x1A7F1D8 Offset: 0x1A7B1D8 VA: 0x1A7F1D8
	public static Exception UnresolvedRelation(string name, string expr) { }

	// RVA: 0x1A8CA8C Offset: 0x1A88A8C VA: 0x1A8CA8C
	internal static EvaluateException BindFailure(string relationName) { }

	// RVA: 0x1A8B608 Offset: 0x1A87608 VA: 0x1A8B608
	public static Exception AggregateArgument() { }

	// RVA: 0x1A7F188 Offset: 0x1A7B188 VA: 0x1A7F188
	public static Exception AggregateUnbound(string expr) { }

	// RVA: 0x1A7F784 Offset: 0x1A7B784 VA: 0x1A7F784
	public static Exception EvalNoContext() { }

	// RVA: 0x1A8CADC Offset: 0x1A88ADC VA: 0x1A8CADC
	public static Exception ExpressionUnbound(string expr) { }

	// RVA: 0x1A7F838 Offset: 0x1A7B838 VA: 0x1A7F838
	public static Exception ComputeNotAggregate(string expr) { }

	// RVA: 0x1A8A230 Offset: 0x1A86230 VA: 0x1A8A230
	public static Exception FilterConvertion(string expr) { }

	// RVA: 0x1A8AD94 Offset: 0x1A86D94 VA: 0x1A8AD94
	public static Exception LookupArgument() { }

	// RVA: 0x1A8CB2C Offset: 0x1A88B2C VA: 0x1A8CB2C
	public static Exception InvalidType(string typeName) { }

	// RVA: 0x1A8CB7C Offset: 0x1A88B7C VA: 0x1A8CB7C
	public static Exception InvalidHoursArgument() { }

	// RVA: 0x1A8CBBC Offset: 0x1A88BBC VA: 0x1A8CBBC
	public static Exception InvalidMinutesArgument() { }

	// RVA: 0x1A8CBFC Offset: 0x1A88BFC VA: 0x1A8CBFC
	public static Exception InvalidTimeZoneRange() { }

	// RVA: 0x1A8CC3C Offset: 0x1A88C3C VA: 0x1A8CC3C
	public static Exception MismatchKindandTimeSpan() { }

	// RVA: 0x1A88ED4 Offset: 0x1A84ED4 VA: 0x1A88ED4
	public static Exception UnsupportedDataType(Type type) { }
}

// Namespace: System.Data
internal interface IFilter // TypeDefIndex: 4513
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Invoke(DataRow row, DataRowVersion version);
}

// Namespace: System.Data
internal sealed class LookupNode : ExpressionNode // TypeDefIndex: 4514
{
	// Fields
	private readonly string _relationName; // 0x18
	private readonly string _columnName; // 0x20
	private DataColumn _column; // 0x28
	private DataRelation _relation; // 0x30

	// Methods

	// RVA: 0x1A8ADD4 Offset: 0x1A86DD4 VA: 0x1A8ADD4
	internal void .ctor(DataTable table, string columnName, string relationName) { }

	// RVA: 0x1A8CC7C Offset: 0x1A88C7C VA: 0x1A8CC7C Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1A8CF1C Offset: 0x1A88F1C VA: 0x1A8CF1C Slot: 6
	internal override object Eval() { }

	// RVA: 0x1A8CF40 Offset: 0x1A88F40 VA: 0x1A8CF40 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A8D044 Offset: 0x1A89044 VA: 0x1A8D044 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x1A8D074 Offset: 0x1A89074 VA: 0x1A8D074 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1A8D07C Offset: 0x1A8907C VA: 0x1A8D07C Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1A8D084 Offset: 0x1A89084 VA: 0x1A8D084 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1A8D08C Offset: 0x1A8908C VA: 0x1A8D08C Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1A8D094 Offset: 0x1A89094 VA: 0x1A8D094 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x1A8D0A4 Offset: 0x1A890A4 VA: 0x1A8D0A4 Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: System.Data
internal sealed class NameNode : ExpressionNode // TypeDefIndex: 4515
{
	// Fields
	internal string _name; // 0x18
	internal bool _found; // 0x20
	internal DataColumn _column; // 0x28

	// Properties
	internal override bool IsSqlColumn { get; }

	// Methods

	// RVA: 0x1A8AE34 Offset: 0x1A86E34 VA: 0x1A8AE34
	internal void .ctor(DataTable table, char[] text, int start, int pos) { }

	// RVA: 0x1A8B520 Offset: 0x1A87520 VA: 0x1A8B520
	internal void .ctor(DataTable table, string name) { }

	// RVA: 0x1A8D0A8 Offset: 0x1A890A8 VA: 0x1A8D0A8 Slot: 4
	internal override bool get_IsSqlColumn() { }

	// RVA: 0x1A8D0C0 Offset: 0x1A890C0 VA: 0x1A8D0C0 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1A8D328 Offset: 0x1A89328 VA: 0x1A8D328 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1A8D34C Offset: 0x1A8934C VA: 0x1A8D34C Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A8D3E8 Offset: 0x1A893E8 VA: 0x1A8D3E8 Slot: 8
	internal override object Eval(int[] records) { }

	// RVA: 0x1A8D418 Offset: 0x1A89418 VA: 0x1A8D418 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1A8D420 Offset: 0x1A89420 VA: 0x1A8D420 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1A8D474 Offset: 0x1A89474 VA: 0x1A8D474 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1A8D4C8 Offset: 0x1A894C8 VA: 0x1A8D4C8 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1A8D51C Offset: 0x1A8951C VA: 0x1A8D51C Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x1A8D598 Offset: 0x1A89598 VA: 0x1A8D598 Slot: 13
	internal override ExpressionNode Optimize() { }

	// RVA: 0x1A8AB6C Offset: 0x1A86B6C VA: 0x1A8AB6C
	internal static string ParseName(char[] text, int start, int pos) { }
}

// Namespace: System.Data
internal sealed class Operators // TypeDefIndex: 4516
{
	// Fields
	private static readonly int[] s_priority; // 0x0
	private static readonly string[] s_looks; // 0x8

	// Methods

	// RVA: 0x1A877F4 Offset: 0x1A837F4 VA: 0x1A877F4
	internal static bool IsArithmetical(int op) { }

	// RVA: 0x1A877D4 Offset: 0x1A837D4 VA: 0x1A877D4
	internal static bool IsLogical(int op) { }

	// RVA: 0x1A877C4 Offset: 0x1A837C4 VA: 0x1A877C4
	internal static bool IsRelational(int op) { }

	// RVA: 0x1A8B474 Offset: 0x1A87474 VA: 0x1A8B474
	internal static int Priority(int op) { }

	// RVA: 0x1A8B3B4 Offset: 0x1A873B4 VA: 0x1A8B3B4
	internal static string ToString(int op) { }

	// RVA: 0x1A8D59C Offset: 0x1A8959C VA: 0x1A8D59C
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class UnaryNode : ExpressionNode // TypeDefIndex: 4517
{
	// Fields
	internal readonly int _op; // 0x18
	internal ExpressionNode _right; // 0x20

	// Methods

	// RVA: 0x1A8B310 Offset: 0x1A87310 VA: 0x1A8B310
	internal void .ctor(DataTable table, int op, ExpressionNode right) { }

	// RVA: 0x1A8DE30 Offset: 0x1A89E30 VA: 0x1A8DE30 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1A8DE78 Offset: 0x1A89E78 VA: 0x1A8DE78 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1A8DE8C Offset: 0x1A89E8C VA: 0x1A8DE8C Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A8E664 Offset: 0x1A8A664 VA: 0x1A8E664 Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x1A8DECC Offset: 0x1A89ECC VA: 0x1A8DECC
	private object EvalUnaryOp(int op, object vl) { }

	// RVA: 0x1A8E680 Offset: 0x1A8A680 VA: 0x1A8E680 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1A8E69C Offset: 0x1A8A69C VA: 0x1A8E69C Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1A8E6B8 Offset: 0x1A8A6B8 VA: 0x1A8E6B8 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1A8E6D4 Offset: 0x1A8A6D4 VA: 0x1A8E6D4 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1A8E6F0 Offset: 0x1A8A6F0 VA: 0x1A8E6F0 Slot: 14
	internal override bool DependsOn(DataColumn column) { }

	// RVA: 0x1A8E710 Offset: 0x1A8A710 VA: 0x1A8E710 Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: System.Data
internal sealed class ZeroOpNode : ExpressionNode // TypeDefIndex: 4518
{
	// Fields
	internal readonly int _op; // 0x18

	// Methods

	// RVA: 0x1A8E7D4 Offset: 0x1A8A7D4 VA: 0x1A8E7D4
	internal void .ctor(int op) { }

	// RVA: 0x1A8E800 Offset: 0x1A8A800 VA: 0x1A8E800 Slot: 5
	internal override void Bind(DataTable table, List<DataColumn> list) { }

	// RVA: 0x1A8E804 Offset: 0x1A8A804 VA: 0x1A8E804 Slot: 6
	internal override object Eval() { }

	// RVA: 0x1A8E8B0 Offset: 0x1A8A8B0 VA: 0x1A8E8B0 Slot: 7
	internal override object Eval(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A8E8BC Offset: 0x1A8A8BC VA: 0x1A8E8BC Slot: 8
	internal override object Eval(int[] recordNos) { }

	// RVA: 0x1A8E8C8 Offset: 0x1A8A8C8 VA: 0x1A8E8C8 Slot: 9
	internal override bool IsConstant() { }

	// RVA: 0x1A8E8D0 Offset: 0x1A8A8D0 VA: 0x1A8E8D0 Slot: 10
	internal override bool IsTableConstant() { }

	// RVA: 0x1A8E8D8 Offset: 0x1A8A8D8 VA: 0x1A8E8D8 Slot: 11
	internal override bool HasLocalAggregate() { }

	// RVA: 0x1A8E8E0 Offset: 0x1A8A8E0 VA: 0x1A8E8E0 Slot: 12
	internal override bool HasRemoteAggregate() { }

	// RVA: 0x1A8E8E8 Offset: 0x1A8A8E8 VA: 0x1A8E8E8 Slot: 13
	internal override ExpressionNode Optimize() { }
}

// Namespace: System.Data
[DefaultProperty("ConstraintName")]
public class ForeignKeyConstraint : Constraint // TypeDefIndex: 4519
{
	// Fields
	internal Rule _deleteRule; // 0x38
	internal Rule _updateRule; // 0x3C
	internal AcceptRejectRule _acceptRejectRule; // 0x40
	private DataKey _childKey; // 0x48
	private DataKey _parentKey; // 0x50
	internal string _constraintName; // 0x58
	internal string[] _parentColumnNames; // 0x60
	internal string[] _childColumnNames; // 0x68
	internal string _parentTableName; // 0x70

	// Properties
	internal DataKey ChildKey { get; }
	[ReadOnly(True)]
	public virtual DataColumn[] Columns { get; }
	[ReadOnly(True)]
	public override DataTable Table { get; }
	internal string[] ParentColumnNames { get; }
	internal string[] ChildColumnNames { get; }
	[DefaultValue(0)]
	public virtual AcceptRejectRule AcceptRejectRule { get; set; }
	[DefaultValue(1)]
	public virtual Rule DeleteRule { get; set; }
	[ReadOnly(True)]
	public virtual DataColumn[] RelatedColumns { get; }
	internal DataColumn[] RelatedColumnsReference { get; }
	internal DataKey ParentKey { get; }
	[ReadOnly(True)]
	public virtual DataTable RelatedTable { get; }
	[DefaultValue(1)]
	public virtual Rule UpdateRule { get; set; }

	// Methods

	// RVA: 0x1A8E8EC Offset: 0x1A8A8EC VA: 0x1A8E8EC
	public void .ctor(DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1A8E92C Offset: 0x1A8A92C VA: 0x1A8E92C
	public void .ctor(string constraintName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	[Browsable(False)]
	// RVA: 0x1A8EAF8 Offset: 0x1A8AAF8 VA: 0x1A8EAF8
	public void .ctor(string constraintName, string parentTableName, string[] parentColumnNames, string[] childColumnNames, AcceptRejectRule acceptRejectRule, Rule deleteRule, Rule updateRule) { }

	// RVA: 0x1A8EBA0 Offset: 0x1A8ABA0 VA: 0x1A8EBA0
	internal DataKey get_ChildKey() { }

	// RVA: 0x1A8EBBC Offset: 0x1A8ABBC VA: 0x1A8EBBC Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x1A8EBDC Offset: 0x1A8ABDC VA: 0x1A8EBDC Slot: 8
	public override DataTable get_Table() { }

	// RVA: 0x1A8EBFC Offset: 0x1A8ABFC VA: 0x1A8EBFC
	internal string[] get_ParentColumnNames() { }

	// RVA: 0x1A8EC08 Offset: 0x1A8AC08 VA: 0x1A8EC08
	internal string[] get_ChildColumnNames() { }

	// RVA: 0x1A8EC14 Offset: 0x1A8AC14 VA: 0x1A8EC14 Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x1A8ED3C Offset: 0x1A8AD3C VA: 0x1A8ED3C Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x1A8ED44 Offset: 0x1A8AD44 VA: 0x1A8ED44
	internal bool IsKeyNull(object[] values) { }

	// RVA: 0x1A8EE00 Offset: 0x1A8AE00 VA: 0x1A8EE00 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x1A8F2C4 Offset: 0x1A8B2C4 VA: 0x1A8F2C4 Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x1A8F418 Offset: 0x1A8B418 VA: 0x1A8F418
	internal void CascadeCommit(DataRow row) { }

	// RVA: 0x1A8F574 Offset: 0x1A8B574 VA: 0x1A8F574
	internal void CascadeDelete(DataRow row) { }

	// RVA: 0x1A8FA94 Offset: 0x1A8BA94 VA: 0x1A8FA94
	internal void CascadeRollback(DataRow row) { }

	// RVA: 0x1A8FC7C Offset: 0x1A8BC7C VA: 0x1A8FC7C
	internal void CascadeUpdate(DataRow row) { }

	// RVA: 0x1A90108 Offset: 0x1A8C108 VA: 0x1A90108
	internal void CheckCanClearParentTable(DataTable table) { }

	// RVA: 0x1A901E4 Offset: 0x1A8C1E4 VA: 0x1A901E4
	internal void CheckCanRemoveParentRow(DataRow row) { }

	// RVA: 0x1A902AC Offset: 0x1A8C2AC VA: 0x1A902AC
	internal void CheckCascade(DataRow row, DataRowAction action) { }

	// RVA: 0x1A903D0 Offset: 0x1A8C3D0 VA: 0x1A903D0 Slot: 15
	internal override void CheckConstraint(DataRow childRow, DataRowAction action) { }

	// RVA: 0x1A9069C Offset: 0x1A8C69C VA: 0x1A9069C
	private void NonVirtualCheckState() { }

	// RVA: 0x1A908E0 Offset: 0x1A8C8E0 VA: 0x1A908E0 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x1A908E4 Offset: 0x1A8C8E4 VA: 0x1A908E4 Slot: 20
	public virtual AcceptRejectRule get_AcceptRejectRule() { }

	// RVA: 0x1A90900 Offset: 0x1A8C900 VA: 0x1A90900 Slot: 21
	public virtual void set_AcceptRejectRule(AcceptRejectRule value) { }

	// RVA: 0x1A90950 Offset: 0x1A8C950 VA: 0x1A90950 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0x1A90998 Offset: 0x1A8C998 VA: 0x1A90998 Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x1A909A8 Offset: 0x1A8C9A8 VA: 0x1A909A8 Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x1A910EC Offset: 0x1A8D0EC VA: 0x1A910EC
	internal ForeignKeyConstraint Clone(DataTable destination) { }

	// RVA: 0x1A8E978 Offset: 0x1A8A978 VA: 0x1A8E978
	private void Create(string relationName, DataColumn[] parentColumns, DataColumn[] childColumns) { }

	// RVA: 0x1A916CC Offset: 0x1A8D6CC VA: 0x1A916CC Slot: 22
	public virtual Rule get_DeleteRule() { }

	// RVA: 0x1A916E8 Offset: 0x1A8D6E8 VA: 0x1A916E8 Slot: 23
	public virtual void set_DeleteRule(Rule value) { }

	// RVA: 0x1A91738 Offset: 0x1A8D738 VA: 0x1A91738 Slot: 0
	public override bool Equals(object key) { }

	// RVA: 0x1A91828 Offset: 0x1A8D828 VA: 0x1A91828 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A91830 Offset: 0x1A8D830 VA: 0x1A91830 Slot: 24
	public virtual DataColumn[] get_RelatedColumns() { }

	// RVA: 0x1A910D0 Offset: 0x1A8D0D0 VA: 0x1A910D0
	internal DataColumn[] get_RelatedColumnsReference() { }

	// RVA: 0x1A90290 Offset: 0x1A8C290 VA: 0x1A90290
	internal DataKey get_ParentKey() { }

	// RVA: 0x1A91850 Offset: 0x1A8D850 VA: 0x1A91850
	internal DataRelation FindParentRelation() { }

	// RVA: 0x1A91918 Offset: 0x1A8D918 VA: 0x1A91918 Slot: 25
	public virtual DataTable get_RelatedTable() { }

	// RVA: 0x1A91938 Offset: 0x1A8D938 VA: 0x1A91938 Slot: 26
	public virtual Rule get_UpdateRule() { }

	// RVA: 0x1A91954 Offset: 0x1A8D954 VA: 0x1A91954 Slot: 27
	public virtual void set_UpdateRule(Rule value) { }
}

// Namespace: System.Data
public enum MappingType // TypeDefIndex: 4520
{
	// Fields
	public int value__; // 0x0
	public const MappingType Element = 1;
	public const MappingType Attribute = 2;
	public const MappingType SimpleContent = 3;
	public const MappingType Hidden = 4;
}

// Namespace: System.Data
public class MergeFailedEventArgs : EventArgs // TypeDefIndex: 4521
{
	// Fields
	[CompilerGenerated]
	private readonly DataTable <Table>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Conflict>k__BackingField; // 0x18

	// Properties
	public string Conflict { get; }

	// Methods

	// RVA: 0x1A919A4 Offset: 0x1A8D9A4 VA: 0x1A919A4
	public void .ctor(DataTable table, string conflict) { }

	[CompilerGenerated]
	// RVA: 0x1A91A2C Offset: 0x1A8DA2C VA: 0x1A91A2C
	public string get_Conflict() { }
}

// Namespace: System.Data
public sealed class MergeFailedEventHandler : MulticastDelegate // TypeDefIndex: 4522
{
	// Methods

	// RVA: 0x1A91A34 Offset: 0x1A8DA34 VA: 0x1A91A34
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A91B40 Offset: 0x1A8DB40 VA: 0x1A91B40 Slot: 12
	public virtual void Invoke(object sender, MergeFailedEventArgs e) { }
}

// Namespace: System.Data
internal sealed class Merger // TypeDefIndex: 4523
{
	// Fields
	private DataSet _dataSet; // 0x10
	private DataTable _dataTable; // 0x18
	private bool _preserveChanges; // 0x20
	private MissingSchemaAction _missingSchemaAction; // 0x24
	private bool _isStandAlonetable; // 0x28
	private bool _IgnoreNSforTableLookup; // 0x29

	// Methods

	// RVA: 0x1A91B54 Offset: 0x1A8DB54 VA: 0x1A91B54
	internal void .ctor(DataSet dataSet, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x1A91BA8 Offset: 0x1A8DBA8 VA: 0x1A91BA8
	internal void .ctor(DataTable dataTable, bool preserveChanges, MissingSchemaAction missingSchemaAction) { }

	// RVA: 0x1A91C04 Offset: 0x1A8DC04 VA: 0x1A91C04
	internal void MergeDataSet(DataSet source) { }

	// RVA: 0x1A9374C Offset: 0x1A8F74C VA: 0x1A9374C
	internal void MergeTable(DataTable src) { }

	// RVA: 0x1A9397C Offset: 0x1A8F97C VA: 0x1A9397C
	private void MergeTable(DataTable src, DataTable dst) { }

	// RVA: 0x1A93F74 Offset: 0x1A8FF74 VA: 0x1A93F74
	private DataTable MergeSchema(DataTable table) { }

	// RVA: 0x1A92B88 Offset: 0x1A8EB88 VA: 0x1A92B88
	private void MergeTableData(DataTable src) { }

	// RVA: 0x1A92C3C Offset: 0x1A8EC3C VA: 0x1A92C3C
	private void MergeConstraints(DataSet source) { }

	// RVA: 0x1A94684 Offset: 0x1A90684 VA: 0x1A94684
	private void MergeConstraints(DataTable table) { }

	// RVA: 0x1A92CAC Offset: 0x1A8ECAC VA: 0x1A92CAC
	private void MergeRelation(DataRelation relation) { }

	// RVA: 0x1A934F8 Offset: 0x1A8F4F8 VA: 0x1A934F8
	private void MergeExtendedProperties(PropertyCollection src, PropertyCollection dst) { }

	// RVA: 0x1A93E20 Offset: 0x1A8FE20 VA: 0x1A93E20
	private DataKey GetSrcKey(DataTable src, DataTable dst) { }
}

// Namespace: System.Data
public enum MissingSchemaAction // TypeDefIndex: 4524
{
	// Fields
	public int value__; // 0x0
	public const MissingSchemaAction Add = 1;
	public const MissingSchemaAction Ignore = 2;
	public const MissingSchemaAction Error = 3;
	public const MissingSchemaAction AddWithKey = 4;
}

// Namespace: System.Data
internal sealed class PrimaryKeyTypeConverter : ReferenceConverter // TypeDefIndex: 4525
{
	// Methods

	// RVA: 0x1A94930 Offset: 0x1A90930 VA: 0x1A94930
	public void .ctor() { }

	// RVA: 0x1A949D0 Offset: 0x1A909D0 VA: 0x1A949D0 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1A949D8 Offset: 0x1A909D8 VA: 0x1A949D8 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1A94A64 Offset: 0x1A90A64 VA: 0x1A94A64 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }
}

// Namespace: System.Data
[Serializable]
public class PropertyCollection : Hashtable, ICloneable // TypeDefIndex: 4526
{
	// Methods

	// RVA: 0x1A94C0C Offset: 0x1A90C0C VA: 0x1A94C0C
	public void .ctor() { }

	// RVA: 0x1A94C14 Offset: 0x1A90C14 VA: 0x1A94C14
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A94C1C Offset: 0x1A90C1C VA: 0x1A94C1C Slot: 23
	public override object Clone() { }
}

// Namespace: System.Data
internal struct Range // TypeDefIndex: 4527
{
	// Fields
	private int _min; // 0x0
	private int _max; // 0x4
	private bool _isNotNull; // 0x8

	// Properties
	public int Count { get; }
	public bool IsNull { get; }
	public int Min { get; }

	// Methods

	// RVA: 0x1A94EE8 Offset: 0x1A90EE8 VA: 0x1A94EE8
	public void .ctor(int min, int max) { }

	// RVA: 0x1A8FA30 Offset: 0x1A8BA30 VA: 0x1A8FA30
	public int get_Count() { }

	// RVA: 0x1A8F564 Offset: 0x1A8B564 VA: 0x1A8F564
	public bool get_IsNull() { }

	// RVA: 0x1A8FA50 Offset: 0x1A8BA50 VA: 0x1A8FA50
	public int get_Min() { }

	// RVA: 0x1A94F30 Offset: 0x1A90F30 VA: 0x1A94F30
	internal void CheckNull() { }
}

// Namespace: System.Data
internal enum RBTreeError // TypeDefIndex: 4528
{
	// Fields
	public int value__; // 0x0
	public const RBTreeError InvalidPageSize = 1;
	public const RBTreeError PagePositionInSlotInUse = 3;
	public const RBTreeError NoFreeSlots = 4;
	public const RBTreeError InvalidStateinInsert = 5;
	public const RBTreeError InvalidNextSizeInDelete = 7;
	public const RBTreeError InvalidStateinDelete = 8;
	public const RBTreeError InvalidNodeSizeinDelete = 9;
	public const RBTreeError InvalidStateinEndDelete = 10;
	public const RBTreeError CannotRotateInvalidsuccessorNodeinDelete = 11;
	public const RBTreeError IndexOutOFRangeinGetNodeByIndex = 13;
	public const RBTreeError RBDeleteFixup = 14;
	public const RBTreeError UnsupportedAccessMethod1 = 15;
	public const RBTreeError UnsupportedAccessMethod2 = 16;
	public const RBTreeError UnsupportedAccessMethodInNonNillRootSubtree = 17;
	public const RBTreeError AttachedNodeWithZerorbTreeNodeId = 18;
	public const RBTreeError CompareNodeInDataRowTree = 19;
	public const RBTreeError CompareSateliteTreeNodeInDataRowTree = 20;
	public const RBTreeError NestedSatelliteTreeEnumerator = 21;
}

// Namespace: System.Data
internal enum TreeAccessMethod // TypeDefIndex: 4529
{
	// Fields
	public int value__; // 0x0
	public const TreeAccessMethod KEY_SEARCH_AND_INDEX = 1;
	public const TreeAccessMethod INDEX_ONLY = 2;
}

// Namespace: 
private enum RBTree.NodeColor<K> // TypeDefIndex: 4530
{
	// Fields
	public int value__; // 0x0
	public const RBTree.NodeColor<K> red = 0;
	public const RBTree.NodeColor<K> black = 1;
}

// Namespace: 
private struct RBTree.Node<K> // TypeDefIndex: 4531
{
	// Fields
	internal int _selfId; // 0x0
	internal int _leftId; // 0x0
	internal int _rightId; // 0x0
	internal int _parentId; // 0x0
	internal int _nextId; // 0x0
	internal int _subTreeSize; // 0x0
	internal K _keyOfNode; // 0x0
	internal RBTree.NodeColor<K> _nodeColor; // 0x0
}

// Namespace: 
[IsReadOnly]
private struct RBTree.NodePath<K> // TypeDefIndex: 4532
{
	// Fields
	internal readonly int _nodeID; // 0x0
	internal readonly int _mainTreeNodeID; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int nodeID, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D9D44 Offset: 0x13D5D44 VA: 0x13D9D44
	|-RBTree.NodePath<int>..ctor
	|
	|-RVA: 0x13D9D4C Offset: 0x13D5D4C VA: 0x13D9D4C
	|-RBTree.NodePath<object>..ctor
	|
	|-RVA: 0x13D9D54 Offset: 0x13D5D54 VA: 0x13D9D54
	|-RBTree.NodePath<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private sealed class RBTree.TreePage<K> // TypeDefIndex: 4533
{
	// Fields
	internal readonly RBTree.Node<K>[] _slots; // 0x0
	internal readonly int[] _slotMap; // 0x0
	private int _inUseCount; // 0x0
	private int _pageId; // 0x0
	private int _nextFreeSlotLine; // 0x0

	// Properties
	internal int InUseCount { get; set; }
	internal int PageId { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1488208 Offset: 0x1484208 VA: 0x1488208
	|-RBTree.TreePage<int>..ctor
	|
	|-RVA: 0x148843C Offset: 0x148443C VA: 0x148843C
	|-RBTree.TreePage<object>..ctor
	|
	|-RVA: 0x1488670 Offset: 0x1484670 VA: 0x1488670
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int AllocSlot(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14882D8 Offset: 0x14842D8 VA: 0x14882D8
	|-RBTree.TreePage<int>.AllocSlot
	|
	|-RVA: 0x148850C Offset: 0x148450C VA: 0x148850C
	|-RBTree.TreePage<object>.AllocSlot
	|
	|-RVA: 0x1488740 Offset: 0x1484740 VA: 0x1488740
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.AllocSlot
	*/

	// RVA: -1 Offset: -1
	internal int get_InUseCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148841C Offset: 0x148441C VA: 0x148841C
	|-RBTree.TreePage<int>.get_InUseCount
	|
	|-RVA: 0x1488650 Offset: 0x1484650 VA: 0x1488650
	|-RBTree.TreePage<object>.get_InUseCount
	|
	|-RVA: 0x14888A4 Offset: 0x14848A4 VA: 0x14888A4
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.get_InUseCount
	*/

	// RVA: -1 Offset: -1
	internal void set_InUseCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1488424 Offset: 0x1484424 VA: 0x1488424
	|-RBTree.TreePage<int>.set_InUseCount
	|
	|-RVA: 0x1488658 Offset: 0x1484658 VA: 0x1488658
	|-RBTree.TreePage<object>.set_InUseCount
	|
	|-RVA: 0x14888AC Offset: 0x14848AC VA: 0x14888AC
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.set_InUseCount
	*/

	// RVA: -1 Offset: -1
	internal int get_PageId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x148842C Offset: 0x148442C VA: 0x148842C
	|-RBTree.TreePage<int>.get_PageId
	|
	|-RVA: 0x1488660 Offset: 0x1484660 VA: 0x1488660
	|-RBTree.TreePage<object>.get_PageId
	|
	|-RVA: 0x14888B4 Offset: 0x14848B4 VA: 0x14888B4
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.get_PageId
	*/

	// RVA: -1 Offset: -1
	internal void set_PageId(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1488434 Offset: 0x1484434 VA: 0x1488434
	|-RBTree.TreePage<int>.set_PageId
	|
	|-RVA: 0x1488668 Offset: 0x1484668 VA: 0x1488668
	|-RBTree.TreePage<object>.set_PageId
	|
	|-RVA: 0x14888BC Offset: 0x14848BC VA: 0x14888BC
	|-RBTree.TreePage<__Il2CppFullySharedGenericType>.set_PageId
	*/
}

// Namespace: 
internal struct RBTree.RBTreeEnumerator<K> : IEnumerator<K>, IDisposable, IEnumerator // TypeDefIndex: 4534
{
	// Fields
	private readonly RBTree<K> _tree; // 0x0
	private readonly int _version; // 0x0
	private int _index; // 0x0
	private int _mainTreeNodeId; // 0x0
	private K _current; // 0x0

	// Properties
	public K Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(RBTree<K> tree) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1410CEC Offset: 0x140CCEC VA: 0x1410CEC
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x1410F38 Offset: 0x140CF38 VA: 0x1410F38
	|-RBTree.RBTreeEnumerator<object>..ctor
	|
	|-RVA: 0x141115C Offset: 0x140D15C VA: 0x141115C
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(RBTree<K> tree, int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1410D24 Offset: 0x140CD24 VA: 0x1410D24
	|-RBTree.RBTreeEnumerator<int>..ctor
	|
	|-RVA: 0x1410F74 Offset: 0x140CF74 VA: 0x1410F74
	|-RBTree.RBTreeEnumerator<object>..ctor
	|
	|-RVA: 0x14112B8 Offset: 0x140D2B8 VA: 0x14112B8
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1410DC4 Offset: 0x140CDC4 VA: 0x1410DC4
	|-RBTree.RBTreeEnumerator<int>.Dispose
	|
	|-RVA: 0x1411014 Offset: 0x140D014 VA: 0x1411014
	|-RBTree.RBTreeEnumerator<object>.Dispose
	|
	|-RVA: 0x1411544 Offset: 0x140D544 VA: 0x1411544
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1410DC8 Offset: 0x140CDC8 VA: 0x1410DC8
	|-RBTree.RBTreeEnumerator<int>.MoveNext
	|
	|-RVA: 0x1411018 Offset: 0x140D018 VA: 0x1411018
	|-RBTree.RBTreeEnumerator<object>.MoveNext
	|
	|-RVA: 0x1411548 Offset: 0x140D548 VA: 0x1411548
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public K get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1410E80 Offset: 0x140CE80 VA: 0x1410E80
	|-RBTree.RBTreeEnumerator<int>.get_Current
	|
	|-RVA: 0x14110E0 Offset: 0x140D0E0 VA: 0x14110E0
	|-RBTree.RBTreeEnumerator<object>.get_Current
	|
	|-RVA: 0x14118B8 Offset: 0x140D8B8 VA: 0x14118B8
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1410E88 Offset: 0x140CE88 VA: 0x1410E88
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x14110E8 Offset: 0x140D0E8 VA: 0x14110E8
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1411944 Offset: 0x140D944 VA: 0x1411944
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1410EF0 Offset: 0x140CEF0 VA: 0x1410EF0
	|-RBTree.RBTreeEnumerator<int>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1411114 Offset: 0x140D114 VA: 0x1411114
	|-RBTree.RBTreeEnumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1411A6C Offset: 0x140DA6C VA: 0x1411A6C
	|-RBTree.RBTreeEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}

// Namespace: System.Data
[DefaultMember("Item")]
internal abstract class RBTree<K> : IEnumerable // TypeDefIndex: 4535
{
	// Fields
	private RBTree.TreePage<K>[] _pageTable; // 0x0
	private int[] _pageTableMap; // 0x0
	private int _inUsePageCount; // 0x0
	private int _nextFreePageLine; // 0x0
	public int root; // 0x0
	private int _version; // 0x0
	private int _inUseNodeCount; // 0x0
	private int _inUseSatelliteTreeCount; // 0x0
	private readonly TreeAccessMethod _accessMethod; // 0x0

	// Properties
	public int Count { get; }
	public bool HasDuplicates { get; }
	public K Item { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract int CompareNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<__Il2CppFullySharedGenericType>.CompareNode
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract int CompareSateliteTreeNode(K record1, K record2);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-RBTree<__Il2CppFullySharedGenericType>.CompareSateliteTreeNode
	*/

	// RVA: -1 Offset: -1
	protected void .ctor(TreeAccessMethod accessMethod) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1411C10 Offset: 0x140DC10 VA: 0x1411C10
	|-RBTree<int>..ctor
	|
	|-RVA: 0x1415738 Offset: 0x1411738 VA: 0x1415738
	|-RBTree<object>..ctor
	|
	|-RVA: 0x1418FB4 Offset: 0x1414FB4 VA: 0x1418FB4
	|-RBTree<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void InitTree() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1411C4C Offset: 0x140DC4C VA: 0x1411C4C
	|-RBTree<int>.InitTree
	|
	|-RVA: 0x1415774 Offset: 0x1411774 VA: 0x1415774
	|-RBTree<object>.InitTree
	|
	|-RVA: 0x1418FF4 Offset: 0x1414FF4 VA: 0x1418FF4
	|-RBTree<__Il2CppFullySharedGenericType>.InitTree
	*/

	// RVA: -1 Offset: -1
	private void FreePage(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1411D80 Offset: 0x140DD80 VA: 0x1411D80
	|-RBTree<int>.FreePage
	|
	|-RVA: 0x14158A8 Offset: 0x14118A8 VA: 0x14158A8
	|-RBTree<object>.FreePage
	|
	|-RVA: 0x1419170 Offset: 0x1415170 VA: 0x1419170
	|-RBTree<__Il2CppFullySharedGenericType>.FreePage
	*/

	// RVA: -1 Offset: -1
	private RBTree.TreePage<K> AllocPage(int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1411DE0 Offset: 0x140DDE0 VA: 0x1411DE0
	|-RBTree<int>.AllocPage
	|
	|-RVA: 0x1415908 Offset: 0x1411908 VA: 0x1415908
	|-RBTree<object>.AllocPage
	|
	|-RVA: 0x14191F8 Offset: 0x14151F8 VA: 0x14191F8
	|-RBTree<__Il2CppFullySharedGenericType>.AllocPage
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFull(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1412050 Offset: 0x140E050 VA: 0x1412050
	|-RBTree<int>.MarkPageFull
	|
	|-RVA: 0x1415B78 Offset: 0x1411B78 VA: 0x1415B78
	|-RBTree<object>.MarkPageFull
	|
	|-RVA: 0x14194AC Offset: 0x14154AC VA: 0x14194AC
	|-RBTree<__Il2CppFullySharedGenericType>.MarkPageFull
	*/

	// RVA: -1 Offset: -1
	private void MarkPageFree(RBTree.TreePage<K> page) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14120A8 Offset: 0x140E0A8 VA: 0x14120A8
	|-RBTree<int>.MarkPageFree
	|
	|-RVA: 0x1415BD0 Offset: 0x1411BD0 VA: 0x1415BD0
	|-RBTree<object>.MarkPageFree
	|
	|-RVA: 0x1419540 Offset: 0x1415540 VA: 0x1419540
	|-RBTree<__Il2CppFullySharedGenericType>.MarkPageFree
	*/

	// RVA: -1 Offset: -1
	private static int GetIntValueFromBitMap(uint bitMap) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1412100 Offset: 0x140E100 VA: 0x1412100
	|-RBTree<int>.GetIntValueFromBitMap
	|
	|-RVA: 0x1415C28 Offset: 0x1411C28 VA: 0x1415C28
	|-RBTree<object>.GetIntValueFromBitMap
	|
	|-RVA: 0x14195D4 Offset: 0x14155D4 VA: 0x14195D4
	|-RBTree<__Il2CppFullySharedGenericType>.GetIntValueFromBitMap
	*/

	// RVA: -1 Offset: -1
	private void FreeNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1412164 Offset: 0x140E164 VA: 0x1412164
	|-RBTree<int>.FreeNode
	|
	|-RVA: 0x1415C8C Offset: 0x1411C8C VA: 0x1415C8C
	|-RBTree<object>.FreeNode
	|
	|-RVA: 0x1419638 Offset: 0x1415638 VA: 0x1419638
	|-RBTree<__Il2CppFullySharedGenericType>.FreeNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexOfPageWithFreeSlot(bool allocatedPage) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1412240 Offset: 0x140E240 VA: 0x1412240
	|-RBTree<int>.GetIndexOfPageWithFreeSlot
	|
	|-RVA: 0x1415D70 Offset: 0x1411D70 VA: 0x1415D70
	|-RBTree<object>.GetIndexOfPageWithFreeSlot
	|
	|-RVA: 0x14197C0 Offset: 0x14157C0 VA: 0x14197C0
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexOfPageWithFreeSlot
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1412380 Offset: 0x140E380 VA: 0x1412380
	|-RBTree<int>.get_Count
	|
	|-RVA: 0x1415EB0 Offset: 0x1411EB0 VA: 0x1415EB0
	|-RBTree<object>.get_Count
	|
	|-RVA: 0x141991C Offset: 0x141591C VA: 0x141991C
	|-RBTree<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public bool get_HasDuplicates() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141238C Offset: 0x140E38C VA: 0x141238C
	|-RBTree<int>.get_HasDuplicates
	|
	|-RVA: 0x1415EBC Offset: 0x1411EBC VA: 0x1415EBC
	|-RBTree<object>.get_HasDuplicates
	|
	|-RVA: 0x1419928 Offset: 0x1415928 VA: 0x1419928
	|-RBTree<__Il2CppFullySharedGenericType>.get_HasDuplicates
	*/

	// RVA: -1 Offset: -1
	private int GetNewNode(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141239C Offset: 0x140E39C VA: 0x141239C
	|-RBTree<int>.GetNewNode
	|
	|-RVA: 0x1415ECC Offset: 0x1411ECC VA: 0x1415ECC
	|-RBTree<object>.GetNewNode
	|
	|-RVA: 0x1419938 Offset: 0x1415938 VA: 0x1419938
	|-RBTree<__Il2CppFullySharedGenericType>.GetNewNode
	*/

	// RVA: -1 Offset: -1
	private int Successor(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141250C Offset: 0x140E50C VA: 0x141250C
	|-RBTree<int>.Successor
	|
	|-RVA: 0x1416074 Offset: 0x1412074 VA: 0x1416074
	|-RBTree<object>.Successor
	|
	|-RVA: 0x1419C68 Offset: 0x1415C68 VA: 0x1419C68
	|-RBTree<__Il2CppFullySharedGenericType>.Successor
	*/

	// RVA: -1 Offset: -1
	private bool Successor(ref int nodeId, ref int mainTreeNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14125A0 Offset: 0x140E5A0 VA: 0x14125A0
	|-RBTree<int>.Successor
	|
	|-RVA: 0x1416108 Offset: 0x1412108 VA: 0x1416108
	|-RBTree<object>.Successor
	|
	|-RVA: 0x1419D54 Offset: 0x1415D54 VA: 0x1419D54
	|-RBTree<__Il2CppFullySharedGenericType>.Successor
	*/

	// RVA: -1 Offset: -1
	private int Minimum(int x_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14126A8 Offset: 0x140E6A8 VA: 0x14126A8
	|-RBTree<int>.Minimum
	|
	|-RVA: 0x1416210 Offset: 0x1412210 VA: 0x1416210
	|-RBTree<object>.Minimum
	|
	|-RVA: 0x1419E80 Offset: 0x1415E80 VA: 0x1419E80
	|-RBTree<__Il2CppFullySharedGenericType>.Minimum
	*/

	// RVA: -1 Offset: -1
	private int LeftRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14126EC Offset: 0x140E6EC VA: 0x14126EC
	|-RBTree<int>.LeftRotate
	|
	|-RVA: 0x1416254 Offset: 0x1412254 VA: 0x1416254
	|-RBTree<object>.LeftRotate
	|
	|-RVA: 0x1419EF8 Offset: 0x1415EF8 VA: 0x1419EF8
	|-RBTree<__Il2CppFullySharedGenericType>.LeftRotate
	*/

	// RVA: -1 Offset: -1
	private int RightRotate(int root_id, int x_id, int mainTreeNode) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141295C Offset: 0x140E95C VA: 0x141295C
	|-RBTree<int>.RightRotate
	|
	|-RVA: 0x14164C4 Offset: 0x14124C4 VA: 0x14164C4
	|-RBTree<object>.RightRotate
	|
	|-RVA: 0x141A418 Offset: 0x1416418 VA: 0x141A418
	|-RBTree<__Il2CppFullySharedGenericType>.RightRotate
	*/

	// RVA: -1 Offset: -1
	private int RBInsert(int root_id, int x_id, int mainTreeNodeID, int position, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1412BCC Offset: 0x140EBCC VA: 0x1412BCC
	|-RBTree<int>.RBInsert
	|
	|-RVA: 0x1416734 Offset: 0x1412734 VA: 0x1416734
	|-RBTree<object>.RBInsert
	|
	|-RVA: 0x141A93C Offset: 0x141693C VA: 0x141A93C
	|-RBTree<__Il2CppFullySharedGenericType>.RBInsert
	*/

	// RVA: -1 Offset: -1
	public void UpdateNodeKey(K currentKey, K newKey) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141346C Offset: 0x140F46C VA: 0x141346C
	|-RBTree<int>.UpdateNodeKey
	|
	|-RVA: 0x1416FD4 Offset: 0x1412FD4 VA: 0x1416FD4
	|-RBTree<object>.UpdateNodeKey
	|
	|-RVA: 0x141BA08 Offset: 0x1417A08 VA: 0x141BA08
	|-RBTree<__Il2CppFullySharedGenericType>.UpdateNodeKey
	*/

	// RVA: -1 Offset: -1
	public K DeleteByIndex(int i) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14134D4 Offset: 0x140F4D4 VA: 0x14134D4
	|-RBTree<int>.DeleteByIndex
	|
	|-RVA: 0x141703C Offset: 0x141303C VA: 0x141703C
	|-RBTree<object>.DeleteByIndex
	|
	|-RVA: 0x141BBDC Offset: 0x1417BDC VA: 0x141BBDC
	|-RBTree<__Il2CppFullySharedGenericType>.DeleteByIndex
	*/

	// RVA: -1 Offset: -1
	public int RBDelete(int z_id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1413544 Offset: 0x140F544 VA: 0x1413544
	|-RBTree<int>.RBDelete
	|
	|-RVA: 0x14170AC Offset: 0x14130AC VA: 0x14170AC
	|-RBTree<object>.RBDelete
	|
	|-RVA: 0x141BCDC Offset: 0x1417CDC VA: 0x141BCDC
	|-RBTree<__Il2CppFullySharedGenericType>.RBDelete
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteX(int root_id, int z_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1413560 Offset: 0x140F560 VA: 0x1413560
	|-RBTree<int>.RBDeleteX
	|
	|-RVA: 0x14170C8 Offset: 0x14130C8 VA: 0x14170C8
	|-RBTree<object>.RBDeleteX
	|
	|-RVA: 0x141BD00 Offset: 0x1417D00 VA: 0x141BD00
	|-RBTree<__Il2CppFullySharedGenericType>.RBDeleteX
	*/

	// RVA: -1 Offset: -1
	private int RBDeleteFixup(int root_id, int x_id, int px_id, int mainTreeNodeID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1413C70 Offset: 0x140FC70 VA: 0x1413C70
	|-RBTree<int>.RBDeleteFixup
	|
	|-RVA: 0x14177D8 Offset: 0x14137D8 VA: 0x14177D8
	|-RBTree<object>.RBDeleteFixup
	|
	|-RVA: 0x141CA54 Offset: 0x1418A54 VA: 0x141CA54
	|-RBTree<__Il2CppFullySharedGenericType>.RBDeleteFixup
	*/

	// RVA: -1 Offset: -1
	private int SearchSubTree(int root_id, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141413C Offset: 0x141013C VA: 0x141413C
	|-RBTree<int>.SearchSubTree
	|
	|-RVA: 0x1417CA4 Offset: 0x1413CA4 VA: 0x1417CA4
	|-RBTree<object>.SearchSubTree
	|
	|-RVA: 0x141D2AC Offset: 0x14192AC VA: 0x141D2AC
	|-RBTree<__Il2CppFullySharedGenericType>.SearchSubTree
	*/

	// RVA: -1 Offset: -1
	public K get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141421C Offset: 0x141021C VA: 0x141421C
	|-RBTree<int>.get_Item
	|
	|-RVA: 0x1417D84 Offset: 0x1413D84 VA: 0x1417D84
	|-RBTree<object>.get_Item
	|
	|-RVA: 0x141D4C4 Offset: 0x14194C4 VA: 0x141D4C4
	|-RBTree<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414244 Offset: 0x1410244 VA: 0x1414244
	|-RBTree<int>.GetNodeByKey
	|
	|-RVA: 0x1417DAC Offset: 0x1413DAC VA: 0x1417DAC
	|-RBTree<object>.GetNodeByKey
	|
	|-RVA: 0x141D590 Offset: 0x1419590 VA: 0x141D590
	|-RBTree<__Il2CppFullySharedGenericType>.GetNodeByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByKey(K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414344 Offset: 0x1410344 VA: 0x1414344
	|-RBTree<int>.GetIndexByKey
	|
	|-RVA: 0x1417E8C Offset: 0x1413E8C VA: 0x1417E8C
	|-RBTree<object>.GetIndexByKey
	|
	|-RVA: 0x141D88C Offset: 0x141988C VA: 0x141D88C
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByKey
	*/

	// RVA: -1 Offset: -1
	public int GetIndexByNode(int node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414398 Offset: 0x1410398 VA: 0x1414398
	|-RBTree<int>.GetIndexByNode
	|
	|-RVA: 0x1417EE0 Offset: 0x1413EE0 VA: 0x1417EE0
	|-RBTree<object>.GetIndexByNode
	|
	|-RVA: 0x141D974 Offset: 0x1419974 VA: 0x141D974
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int GetIndexByNodePath(RBTree.NodePath<K> path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141447C Offset: 0x141047C VA: 0x141447C
	|-RBTree<int>.GetIndexByNodePath
	|
	|-RVA: 0x1417FC4 Offset: 0x1413FC4 VA: 0x1417FC4
	|-RBTree<object>.GetIndexByNodePath
	|
	|-RVA: 0x141DB18 Offset: 0x1419B18 VA: 0x141DB18
	|-RBTree<__Il2CppFullySharedGenericType>.GetIndexByNodePath
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414514 Offset: 0x1410514 VA: 0x1414514
	|-RBTree<int>.ComputeIndexByNode
	|
	|-RVA: 0x141805C Offset: 0x141405C VA: 0x141805C
	|-RBTree<object>.ComputeIndexByNode
	|
	|-RVA: 0x141DBA8 Offset: 0x1419BA8 VA: 0x141DBA8
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeIndexByNode
	*/

	// RVA: -1 Offset: -1
	private int ComputeIndexWithSatelliteByNode(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14145A0 Offset: 0x14105A0 VA: 0x14145A0
	|-RBTree<int>.ComputeIndexWithSatelliteByNode
	|
	|-RVA: 0x14180E8 Offset: 0x14140E8 VA: 0x14180E8
	|-RBTree<object>.ComputeIndexWithSatelliteByNode
	|
	|-RVA: 0x141DC98 Offset: 0x1419C98 VA: 0x141DC98
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeIndexWithSatelliteByNode
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodePath<K> GetNodeByIndex(int userIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414660 Offset: 0x1410660 VA: 0x1414660
	|-RBTree<int>.GetNodeByIndex
	|
	|-RVA: 0x14181A8 Offset: 0x14141A8 VA: 0x14181A8
	|-RBTree<object>.GetNodeByIndex
	|
	|-RVA: 0x141DDEC Offset: 0x1419DEC VA: 0x141DDEC
	|-RBTree<__Il2CppFullySharedGenericType>.GetNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int index, out int satelliteRootId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414730 Offset: 0x1410730 VA: 0x1414730
	|-RBTree<int>.ComputeNodeByIndex
	|
	|-RVA: 0x1418278 Offset: 0x1414278 VA: 0x1418278
	|-RBTree<object>.ComputeNodeByIndex
	|
	|-RVA: 0x141DEC4 Offset: 0x1419EC4 VA: 0x141DEC4
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	private int ComputeNodeByIndex(int x_id, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x141487C Offset: 0x141087C VA: 0x141487C
	|-RBTree<int>.ComputeNodeByIndex
	|
	|-RVA: 0x14183C4 Offset: 0x14143C4 VA: 0x14183C4
	|-RBTree<object>.ComputeNodeByIndex
	|
	|-RVA: 0x141E0C0 Offset: 0x141A0C0 VA: 0x141E0C0
	|-RBTree<__Il2CppFullySharedGenericType>.ComputeNodeByIndex
	*/

	// RVA: -1 Offset: -1
	public int Insert(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14148F4 Offset: 0x14108F4 VA: 0x14148F4
	|-RBTree<int>.Insert
	|
	|-RVA: 0x141843C Offset: 0x141443C VA: 0x141843C
	|-RBTree<object>.Insert
	|
	|-RVA: 0x141E174 Offset: 0x141A174 VA: 0x141E174
	|-RBTree<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public int Add(K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414950 Offset: 0x1410950 VA: 0x1414950
	|-RBTree<int>.Add
	|
	|-RVA: 0x1418498 Offset: 0x1414498 VA: 0x1418498
	|-RBTree<object>.Add
	|
	|-RVA: 0x141E268 Offset: 0x141A268 VA: 0x141E268
	|-RBTree<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14149AC Offset: 0x14109AC VA: 0x14149AC
	|-RBTree<int>.GetEnumerator
	|
	|-RVA: 0x14184F4 Offset: 0x14144F4 VA: 0x14184F4
	|-RBTree<object>.GetEnumerator
	|
	|-RVA: 0x141E35C Offset: 0x141A35C VA: 0x141E35C
	|-RBTree<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(int nodeId, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14149FC Offset: 0x14109FC VA: 0x14149FC
	|-RBTree<int>.IndexOf
	|
	|-RVA: 0x1418548 Offset: 0x1414548 VA: 0x1418548
	|-RBTree<object>.IndexOf
	|
	|-RVA: 0x141E408 Offset: 0x141A408 VA: 0x141E408
	|-RBTree<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public int Insert(int position, K item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414AF4 Offset: 0x1410AF4 VA: 0x1414AF4
	|-RBTree<int>.Insert
	|
	|-RVA: 0x1418604 Offset: 0x1414604 VA: 0x1418604
	|-RBTree<object>.Insert
	|
	|-RVA: 0x141E670 Offset: 0x141A670 VA: 0x141E670
	|-RBTree<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1
	public int InsertAt(int position, K item, bool append) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414B08 Offset: 0x1410B08 VA: 0x1414B08
	|-RBTree<int>.InsertAt
	|
	|-RVA: 0x1418618 Offset: 0x1414618 VA: 0x1418618
	|-RBTree<object>.InsertAt
	|
	|-RVA: 0x141E74C Offset: 0x141A74C VA: 0x141E74C
	|-RBTree<__Il2CppFullySharedGenericType>.InsertAt
	*/

	// RVA: -1 Offset: -1
	public void RemoveAt(int position) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414B7C Offset: 0x1410B7C VA: 0x1414B7C
	|-RBTree<int>.RemoveAt
	|
	|-RVA: 0x141868C Offset: 0x141468C VA: 0x141868C
	|-RBTree<object>.RemoveAt
	|
	|-RVA: 0x141E854 Offset: 0x141A854 VA: 0x141E854
	|-RBTree<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414B8C Offset: 0x1410B8C VA: 0x1414B8C
	|-RBTree<int>.Clear
	|
	|-RVA: 0x141869C Offset: 0x141469C VA: 0x141869C
	|-RBTree<object>.Clear
	|
	|-RVA: 0x141E8E0 Offset: 0x141A8E0 VA: 0x141E8E0
	|-RBTree<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414BB8 Offset: 0x1410BB8 VA: 0x1414BB8
	|-RBTree<int>.CopyTo
	|
	|-RVA: 0x14186C8 Offset: 0x14146C8 VA: 0x14186C8
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x141E910 Offset: 0x141A910 VA: 0x141E910
	|-RBTree<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(K[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414CE4 Offset: 0x1410CE4 VA: 0x1414CE4
	|-RBTree<int>.CopyTo
	|
	|-RVA: 0x14187D8 Offset: 0x14147D8 VA: 0x14187D8
	|-RBTree<object>.CopyTo
	|
	|-RVA: 0x141EB0C Offset: 0x141AB0C VA: 0x141EB0C
	|-RBTree<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1
	private void SetRight(int nodeId, int rightNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414E00 Offset: 0x1410E00 VA: 0x1414E00
	|-RBTree<int>.SetRight
	|
	|-RVA: 0x1418904 Offset: 0x1414904 VA: 0x1418904
	|-RBTree<object>.SetRight
	|
	|-RVA: 0x141ED80 Offset: 0x141AD80 VA: 0x141ED80
	|-RBTree<__Il2CppFullySharedGenericType>.SetRight
	*/

	// RVA: -1 Offset: -1
	private void SetLeft(int nodeId, int leftNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414E58 Offset: 0x1410E58 VA: 0x1414E58
	|-RBTree<int>.SetLeft
	|
	|-RVA: 0x1418960 Offset: 0x1414960 VA: 0x1418960
	|-RBTree<object>.SetLeft
	|
	|-RVA: 0x141EDF8 Offset: 0x141ADF8 VA: 0x141EDF8
	|-RBTree<__Il2CppFullySharedGenericType>.SetLeft
	*/

	// RVA: -1 Offset: -1
	private void SetParent(int nodeId, int parentNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414EB0 Offset: 0x1410EB0 VA: 0x1414EB0
	|-RBTree<int>.SetParent
	|
	|-RVA: 0x14189BC Offset: 0x14149BC VA: 0x14189BC
	|-RBTree<object>.SetParent
	|
	|-RVA: 0x141EE70 Offset: 0x141AE70 VA: 0x141EE70
	|-RBTree<__Il2CppFullySharedGenericType>.SetParent
	*/

	// RVA: -1 Offset: -1
	private void SetColor(int nodeId, RBTree.NodeColor<K> color) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414F08 Offset: 0x1410F08 VA: 0x1414F08
	|-RBTree<int>.SetColor
	|
	|-RVA: 0x1418A18 Offset: 0x1414A18 VA: 0x1418A18
	|-RBTree<object>.SetColor
	|
	|-RVA: 0x141EEE8 Offset: 0x141AEE8 VA: 0x141EEE8
	|-RBTree<__Il2CppFullySharedGenericType>.SetColor
	*/

	// RVA: -1 Offset: -1
	private void SetKey(int nodeId, K key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414F60 Offset: 0x1410F60 VA: 0x1414F60
	|-RBTree<int>.SetKey
	|
	|-RVA: 0x1418A74 Offset: 0x1414A74 VA: 0x1418A74
	|-RBTree<object>.SetKey
	|
	|-RVA: 0x141EF60 Offset: 0x141AF60 VA: 0x141EF60
	|-RBTree<__Il2CppFullySharedGenericType>.SetKey
	*/

	// RVA: -1 Offset: -1
	private void SetNext(int nodeId, int nextNodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1414FB8 Offset: 0x1410FB8 VA: 0x1414FB8
	|-RBTree<int>.SetNext
	|
	|-RVA: 0x1418AD4 Offset: 0x1414AD4 VA: 0x1418AD4
	|-RBTree<object>.SetNext
	|
	|-RVA: 0x141F088 Offset: 0x141B088 VA: 0x141F088
	|-RBTree<__Il2CppFullySharedGenericType>.SetNext
	*/

	// RVA: -1 Offset: -1
	private void SetSubTreeSize(int nodeId, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1415010 Offset: 0x1411010 VA: 0x1415010
	|-RBTree<int>.SetSubTreeSize
	|
	|-RVA: 0x1418B30 Offset: 0x1414B30 VA: 0x1418B30
	|-RBTree<object>.SetSubTreeSize
	|
	|-RVA: 0x141F100 Offset: 0x141B100 VA: 0x141F100
	|-RBTree<__Il2CppFullySharedGenericType>.SetSubTreeSize
	*/

	// RVA: -1 Offset: -1
	private void IncreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1415068 Offset: 0x1411068 VA: 0x1415068
	|-RBTree<int>.IncreaseSize
	|
	|-RVA: 0x1418B8C Offset: 0x1414B8C VA: 0x1418B8C
	|-RBTree<object>.IncreaseSize
	|
	|-RVA: 0x141F178 Offset: 0x141B178 VA: 0x141F178
	|-RBTree<__Il2CppFullySharedGenericType>.IncreaseSize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14150C8 Offset: 0x14110C8 VA: 0x14150C8
	|-RBTree<int>.RecomputeSize
	|
	|-RVA: 0x1418BF0 Offset: 0x1414BF0 VA: 0x1418BF0
	|-RBTree<object>.RecomputeSize
	|
	|-RVA: 0x141F200 Offset: 0x141B200 VA: 0x141F200
	|-RBTree<__Il2CppFullySharedGenericType>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void DecreaseSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14151A0 Offset: 0x14111A0 VA: 0x14151A0
	|-RBTree<int>.DecreaseSize
	|
	|-RVA: 0x1418CCC Offset: 0x1414CCC VA: 0x1418CCC
	|-RBTree<object>.DecreaseSize
	|
	|-RVA: 0x141F370 Offset: 0x141B370 VA: 0x141F370
	|-RBTree<__Il2CppFullySharedGenericType>.DecreaseSize
	*/

	// RVA: -1 Offset: -1
	public int Right(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1415200 Offset: 0x1411200 VA: 0x1415200
	|-RBTree<int>.Right
	|
	|-RVA: 0x1418D30 Offset: 0x1414D30 VA: 0x1418D30
	|-RBTree<object>.Right
	|
	|-RVA: 0x141F3F8 Offset: 0x141B3F8 VA: 0x141F3F8
	|-RBTree<__Il2CppFullySharedGenericType>.Right
	*/

	// RVA: -1 Offset: -1
	public int Left(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1415258 Offset: 0x1411258 VA: 0x1415258
	|-RBTree<int>.Left
	|
	|-RVA: 0x1418D8C Offset: 0x1414D8C VA: 0x1418D8C
	|-RBTree<object>.Left
	|
	|-RVA: 0x141F478 Offset: 0x141B478 VA: 0x141F478
	|-RBTree<__Il2CppFullySharedGenericType>.Left
	*/

	// RVA: -1 Offset: -1
	public int Parent(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14152B0 Offset: 0x14112B0 VA: 0x14152B0
	|-RBTree<int>.Parent
	|
	|-RVA: 0x1418DE8 Offset: 0x1414DE8 VA: 0x1418DE8
	|-RBTree<object>.Parent
	|
	|-RVA: 0x141F4F8 Offset: 0x141B4F8 VA: 0x141F4F8
	|-RBTree<__Il2CppFullySharedGenericType>.Parent
	*/

	// RVA: -1 Offset: -1
	private RBTree.NodeColor<K> color(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1415308 Offset: 0x1411308 VA: 0x1415308
	|-RBTree<int>.color
	|
	|-RVA: 0x1418E44 Offset: 0x1414E44 VA: 0x1418E44
	|-RBTree<object>.color
	|
	|-RVA: 0x141F578 Offset: 0x141B578 VA: 0x141F578
	|-RBTree<__Il2CppFullySharedGenericType>.color
	*/

	// RVA: -1 Offset: -1
	public int Next(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1415360 Offset: 0x1411360 VA: 0x1415360
	|-RBTree<int>.Next
	|
	|-RVA: 0x1418EA0 Offset: 0x1414EA0 VA: 0x1418EA0
	|-RBTree<object>.Next
	|
	|-RVA: 0x141F5F8 Offset: 0x141B5F8 VA: 0x141F5F8
	|-RBTree<__Il2CppFullySharedGenericType>.Next
	*/

	// RVA: -1 Offset: -1
	public int SubTreeSize(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14153B8 Offset: 0x14113B8 VA: 0x14153B8
	|-RBTree<int>.SubTreeSize
	|
	|-RVA: 0x1418EFC Offset: 0x1414EFC VA: 0x1418EFC
	|-RBTree<object>.SubTreeSize
	|
	|-RVA: 0x141F678 Offset: 0x141B678 VA: 0x141F678
	|-RBTree<__Il2CppFullySharedGenericType>.SubTreeSize
	*/

	// RVA: -1 Offset: -1
	public K Key(int nodeId) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1415410 Offset: 0x1411410 VA: 0x1415410
	|-RBTree<int>.Key
	|
	|-RVA: 0x1418F58 Offset: 0x1414F58 VA: 0x1418F58
	|-RBTree<object>.Key
	|
	|-RVA: 0x141F6F8 Offset: 0x141B6F8 VA: 0x141F6F8
	|-RBTree<__Il2CppFullySharedGenericType>.Key
	*/
}

// Namespace: System.Data
[DefaultMember("Item")]
internal sealed class RecordManager // TypeDefIndex: 4536
{
	// Fields
	private readonly DataTable _table; // 0x10
	private int _lastFreeRecord; // 0x18
	private int _minimumCapacity; // 0x1C
	private int _recordCapacity; // 0x20
	private readonly List<int> _freeRecordList; // 0x28
	private DataRow[] _rows; // 0x30

	// Properties
	internal int LastFreeRecord { get; }
	internal int MinimumCapacity { get; set; }
	internal int RecordCapacity { get; set; }
	internal DataRow Item { get; set; }

	// Methods

	// RVA: 0x1A94F64 Offset: 0x1A90F64 VA: 0x1A94F64
	internal void .ctor(DataTable table) { }

	// RVA: 0x1A9503C Offset: 0x1A9103C VA: 0x1A9503C
	private void GrowRecordCapacity() { }

	// RVA: 0x1A9522C Offset: 0x1A9122C VA: 0x1A9522C
	internal int get_LastFreeRecord() { }

	// RVA: 0x1A95234 Offset: 0x1A91234 VA: 0x1A95234
	internal int get_MinimumCapacity() { }

	// RVA: 0x1A9523C Offset: 0x1A9123C VA: 0x1A9523C
	internal void set_MinimumCapacity(int value) { }

	// RVA: 0x1A9527C Offset: 0x1A9127C VA: 0x1A9527C
	internal int get_RecordCapacity() { }

	// RVA: 0x1A9519C Offset: 0x1A9119C VA: 0x1A9519C
	internal void set_RecordCapacity(int value) { }

	// RVA: 0x1A95154 Offset: 0x1A91154 VA: 0x1A95154
	internal static int NewCapacity(int capacity) { }

	// RVA: 0x1A95168 Offset: 0x1A91168 VA: 0x1A95168
	private int NormalizedMinimumCapacity(int capacity) { }

	// RVA: 0x1A95284 Offset: 0x1A91284 VA: 0x1A95284
	internal int NewRecordBase() { }

	// RVA: 0x1A95350 Offset: 0x1A91350 VA: 0x1A95350
	internal void FreeRecord(ref int record) { }

	// RVA: 0x1A95508 Offset: 0x1A91508 VA: 0x1A95508
	internal void Clear(bool clearAll) { }

	// RVA: 0x1A9570C Offset: 0x1A9170C VA: 0x1A9570C
	internal DataRow get_Item(int record) { }

	// RVA: 0x1A954A0 Offset: 0x1A914A0 VA: 0x1A954A0
	internal void set_Item(int record, DataRow value) { }

	// RVA: 0x1A9573C Offset: 0x1A9173C VA: 0x1A9573C
	internal int ImportRecord(DataTable src, int record) { }

	// RVA: 0x1A95744 Offset: 0x1A91744 VA: 0x1A95744
	internal int CopyRecord(DataTable src, int record, int copy) { }

	// RVA: 0x1A95A98 Offset: 0x1A91A98 VA: 0x1A95A98
	internal void SetRowCache(DataRow[] newRows) { }
}

// Namespace: System.Data
internal sealed class RelatedView : DataView, IFilter // TypeDefIndex: 4537
{
	// Fields
	private readonly Nullable<DataKey> _parentKey; // 0xB0
	private readonly DataKey _childKey; // 0xC0
	private readonly DataRowView _parentRowView; // 0xC8
	private readonly object[] _filterValues; // 0xD0

	// Methods

	// RVA: 0x1A95AD8 Offset: 0x1A91AD8 VA: 0x1A95AD8
	public void .ctor(DataColumn[] columns, object[] values) { }

	// RVA: 0x1A95C14 Offset: 0x1A91C14 VA: 0x1A95C14
	public void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	// RVA: 0x1A95D50 Offset: 0x1A91D50 VA: 0x1A95D50
	private object[] GetParentValues() { }

	// RVA: 0x1A95DF0 Offset: 0x1A91DF0 VA: 0x1A95DF0 Slot: 33
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x1A95F78 Offset: 0x1A91F78 VA: 0x1A95F78 Slot: 27
	internal override IFilter GetFilter() { }

	// RVA: 0x1A95F7C Offset: 0x1A91F7C VA: 0x1A95F7C Slot: 26
	public override DataRowView AddNew() { }

	// RVA: 0x1A95FDC Offset: 0x1A91FDC VA: 0x1A95FDC Slot: 30
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }
}

// Namespace: System.Data
internal sealed class RelationshipConverter : ExpandableObjectConverter // TypeDefIndex: 4538
{
	// Methods

	// RVA: 0x1A96000 Offset: 0x1A92000 VA: 0x1A96000
	public void .ctor() { }

	// RVA: 0x1A96008 Offset: 0x1A92008 VA: 0x1A96008 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1A960B8 Offset: 0x1A920B8 VA: 0x1A960B8 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }
}

// Namespace: System.Data
public enum Rule // TypeDefIndex: 4539
{
	// Fields
	public int value__; // 0x0
	public const Rule None = 0;
	public const Rule Cascade = 1;
	public const Rule SetNull = 2;
	public const Rule SetDefault = 3;
}

// Namespace: System.Data
public enum SchemaSerializationMode // TypeDefIndex: 4540
{
	// Fields
	public int value__; // 0x0
	public const SchemaSerializationMode IncludeSchema = 1;
	public const SchemaSerializationMode ExcludeSchema = 2;
}

// Namespace: System.Data
[IsReadOnly]
internal struct IndexField // TypeDefIndex: 4541
{
	// Fields
	public readonly DataColumn Column; // 0x0
	public readonly bool IsDescending; // 0x8

	// Methods

	// RVA: 0x1A96C94 Offset: 0x1A92C94 VA: 0x1A96C94
	internal void .ctor(DataColumn column, bool isDescending) { }

	// RVA: 0x1A96CBC Offset: 0x1A92CBC VA: 0x1A96CBC
	public static bool op_Equality(IndexField if1, IndexField if2) { }

	// RVA: 0x1A96CD0 Offset: 0x1A92CD0 VA: 0x1A96CD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1A96D58 Offset: 0x1A92D58 VA: 0x1A96D58 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
private sealed class Index.IndexTree : RBTree<int> // TypeDefIndex: 4542
{
	// Fields
	private readonly Index _index; // 0x40

	// Methods

	// RVA: 0x1A995CC Offset: 0x1A955CC VA: 0x1A995CC
	internal void .ctor(Index index) { }

	// RVA: 0x1A99EA4 Offset: 0x1A95EA4 VA: 0x1A99EA4 Slot: 5
	protected override int CompareNode(int record1, int record2) { }

	// RVA: 0x1A99EB8 Offset: 0x1A95EB8 VA: 0x1A99EB8 Slot: 6
	protected override int CompareSateliteTreeNode(int record1, int record2) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Index.<>c // TypeDefIndex: 4543
{
	// Fields
	public static readonly Index.<>c <>9; // 0x0
	public static Listeners.Func<DataViewListener, DataViewListener, bool> <>9__22_0; // 0x8
	public static Listeners.Action<DataViewListener, DataViewListener, ListChangedEventArgs, bool, bool> <>9__85_0; // 0x10

	// Methods

	// RVA: 0x1A99ECC Offset: 0x1A95ECC VA: 0x1A99ECC
	private static void .cctor() { }

	// RVA: 0x1A99F34 Offset: 0x1A95F34 VA: 0x1A99F34
	public void .ctor() { }

	// RVA: 0x1A99F3C Offset: 0x1A95F3C VA: 0x1A99F3C
	internal bool <.ctor>b__22_0(DataViewListener listener) { }

	// RVA: 0x1A99F48 Offset: 0x1A95F48 VA: 0x1A99F48
	internal void <OnListChanged>b__85_0(DataViewListener listener, ListChangedEventArgs args, bool arg2, bool arg3) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Index.<>c__DisplayClass86_0 // TypeDefIndex: 4544
{
	// Fields
	public ListChangedType changedType; // 0x10

	// Methods

	// RVA: 0x1A9974C Offset: 0x1A9574C VA: 0x1A9974C
	public void .ctor() { }

	// RVA: 0x1A99F64 Offset: 0x1A95F64 VA: 0x1A99F64
	internal void <MaintainDataView>b__0(DataViewListener listener, ListChangedType type, DataRow row, bool track) { }
}

// Namespace: System.Data
internal sealed class Index // TypeDefIndex: 4545
{
	// Fields
	private readonly DataTable _table; // 0x10
	internal readonly IndexField[] _indexFields; // 0x18
	private readonly Comparison<DataRow> _comparison; // 0x20
	private readonly DataViewRowState _recordStates; // 0x28
	private WeakReference _rowFilter; // 0x30
	private Index.IndexTree _records; // 0x38
	private int _recordCount; // 0x40
	private int _refCount; // 0x44
	private Listeners<DataViewListener> _listeners; // 0x48
	private bool _suspendEvents; // 0x50
	private readonly bool _isSharable; // 0x51
	private readonly bool _hasRemoteAggregate; // 0x52
	private static int s_objectTypeCount; // 0x0
	private readonly int _objectID; // 0x54

	// Properties
	internal bool HasRemoteAggregate { get; }
	internal int ObjectID { get; }
	public DataViewRowState RecordStates { get; }
	public IFilter RowFilter { get; }
	public bool HasDuplicates { get; }
	public int RecordCount { get; }
	public int RefCount { get; }
	private bool DoListChanged { get; }
	internal DataTable Table { get; }

	// Methods

	// RVA: 0x1A96DB8 Offset: 0x1A92DB8 VA: 0x1A96DB8
	public void .ctor(DataTable table, IndexField[] indexFields, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1A970E0 Offset: 0x1A930E0 VA: 0x1A970E0
	public void .ctor(DataTable table, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1A97138 Offset: 0x1A93138 VA: 0x1A97138
	private static IndexField[] GetAllFields(DataColumnCollection columns) { }

	// RVA: 0x1A96DC8 Offset: 0x1A92DC8 VA: 0x1A96DC8
	private void .ctor(DataTable table, IndexField[] indexFields, Comparison<DataRow> comparison, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1A975F0 Offset: 0x1A935F0 VA: 0x1A975F0
	public bool Equal(IndexField[] indexDesc, DataViewRowState recordStates, IFilter rowFilter) { }

	// RVA: 0x1A97688 Offset: 0x1A93688 VA: 0x1A97688
	internal bool get_HasRemoteAggregate() { }

	// RVA: 0x1A97690 Offset: 0x1A93690 VA: 0x1A97690
	internal int get_ObjectID() { }

	// RVA: 0x1A97698 Offset: 0x1A93698 VA: 0x1A97698
	public DataViewRowState get_RecordStates() { }

	// RVA: 0x1A976A0 Offset: 0x1A936A0 VA: 0x1A976A0
	public IFilter get_RowFilter() { }

	// RVA: 0x1A97718 Offset: 0x1A93718 VA: 0x1A97718
	public int GetRecord(int recordIndex) { }

	// RVA: 0x1A97770 Offset: 0x1A93770 VA: 0x1A97770
	public bool get_HasDuplicates() { }

	// RVA: 0x1A977C0 Offset: 0x1A937C0 VA: 0x1A977C0
	public int get_RecordCount() { }

	// RVA: 0x1A977C8 Offset: 0x1A937C8 VA: 0x1A977C8
	private bool AcceptRecord(int record) { }

	// RVA: 0x1A977F4 Offset: 0x1A937F4 VA: 0x1A977F4
	private bool AcceptRecord(int record, IFilter filter) { }

	// RVA: 0x1A97988 Offset: 0x1A93988 VA: 0x1A97988
	internal void ListChangedAdd(DataViewListener listener) { }

	// RVA: 0x1A979E0 Offset: 0x1A939E0 VA: 0x1A979E0
	internal void ListChangedRemove(DataViewListener listener) { }

	// RVA: 0x1A97A38 Offset: 0x1A93A38 VA: 0x1A97A38
	public int get_RefCount() { }

	// RVA: 0x1A97A40 Offset: 0x1A93A40 VA: 0x1A97A40
	public void AddRef() { }

	// RVA: 0x1A97C2C Offset: 0x1A93C2C VA: 0x1A97C2C
	public int RemoveRef() { }

	// RVA: 0x1A97DDC Offset: 0x1A93DDC VA: 0x1A97DDC
	private void ApplyChangeAction(int record, int action, int changeRecord) { }

	// RVA: 0x1A98264 Offset: 0x1A94264 VA: 0x1A98264
	public bool CheckUnique() { }

	// RVA: 0x1A9827C Offset: 0x1A9427C VA: 0x1A9827C
	private int CompareRecords(int record1, int record2) { }

	// RVA: 0x1A983DC Offset: 0x1A943DC VA: 0x1A983DC
	private int CompareDataRows(int record1, int record2) { }

	// RVA: 0x1A98448 Offset: 0x1A94448 VA: 0x1A98448
	private int CompareDuplicateRecords(int record1, int record2) { }

	// RVA: 0x1A985A0 Offset: 0x1A945A0 VA: 0x1A985A0
	private int CompareRecordToKey(int record1, object[] vals) { }

	// RVA: 0x1A9866C Offset: 0x1A9466C VA: 0x1A9866C
	public void DeleteRecordFromIndex(int recordIndex) { }

	// RVA: 0x1A98204 Offset: 0x1A94204 VA: 0x1A98204
	private void DeleteRecord(int recordIndex) { }

	// RVA: 0x1A98674 Offset: 0x1A94674 VA: 0x1A98674
	private void DeleteRecord(int recordIndex, bool fireEvent) { }

	// RVA: 0x1A98948 Offset: 0x1A94948 VA: 0x1A98948
	public RBTree.RBTreeEnumerator<int> GetEnumerator(int startIndex) { }

	// RVA: 0x1A9820C Offset: 0x1A9420C VA: 0x1A9820C
	public int GetIndex(int record) { }

	// RVA: 0x1A98078 Offset: 0x1A94078 VA: 0x1A98078
	private int GetIndex(int record, int changeRecord) { }

	// RVA: 0x1A8EFF4 Offset: 0x1A8AFF4 VA: 0x1A8EFF4
	public object[] GetUniqueKeyValues() { }

	// RVA: 0x1A98BE0 Offset: 0x1A94BE0 VA: 0x1A98BE0
	private int FindNodeByKey(object originalKey) { }

	// RVA: 0x1A98DF8 Offset: 0x1A94DF8 VA: 0x1A98DF8
	private int FindNodeByKeys(object[] originalKey) { }

	// RVA: 0x1A99034 Offset: 0x1A95034 VA: 0x1A99034
	private int FindNodeByKeyRecord(int record) { }

	// RVA: 0x1A9912C Offset: 0x1A9512C VA: 0x1A9912C
	private Range GetRangeFromNode(int nodeId) { }

	// RVA: 0x1A99254 Offset: 0x1A95254 VA: 0x1A99254
	public Range FindRecords(object key) { }

	// RVA: 0x1A8F138 Offset: 0x1A8B138 VA: 0x1A8F138
	public Range FindRecords(object[] key) { }

	// RVA: 0x1A99278 Offset: 0x1A95278 VA: 0x1A99278
	internal void FireResetEvent() { }

	// RVA: 0x1A99560 Offset: 0x1A95560 VA: 0x1A99560
	private int GetChangeAction(DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x1A9957C Offset: 0x1A9557C VA: 0x1A9957C
	private static int GetReplaceAction(DataViewRowState oldState) { }

	// RVA: 0x1A8FA68 Offset: 0x1A8BA68 VA: 0x1A8FA68
	public DataRow GetRow(int i) { }

	// RVA: 0x1A9959C Offset: 0x1A9559C VA: 0x1A9959C
	public DataRow[] GetRows(object[] values) { }

	// RVA: 0x1A8F15C Offset: 0x1A8B15C VA: 0x1A8F15C
	public DataRow[] GetRows(Range range) { }

	// RVA: 0x1A97230 Offset: 0x1A93230 VA: 0x1A97230
	private void InitRecords(IFilter filter) { }

	// RVA: 0x1A99634 Offset: 0x1A95634 VA: 0x1A99634
	public int InsertRecordToIndex(int record) { }

	// RVA: 0x1A97E80 Offset: 0x1A93E80 VA: 0x1A97E80
	private int InsertRecord(int record, bool fireEvent) { }

	// RVA: 0x1A99684 Offset: 0x1A95684 VA: 0x1A99684
	public bool IsKeyInIndex(object key) { }

	// RVA: 0x1A8F120 Offset: 0x1A8B120 VA: 0x1A8F120
	public bool IsKeyInIndex(object[] key) { }

	// RVA: 0x1A9969C Offset: 0x1A9569C VA: 0x1A9969C
	public bool IsKeyRecordInIndex(int record) { }

	// RVA: 0x1A99360 Offset: 0x1A95360 VA: 0x1A99360
	private bool get_DoListChanged() { }

	// RVA: 0x1A996B4 Offset: 0x1A956B4 VA: 0x1A996B4
	private void OnListChanged(ListChangedType changedType, int newIndex, int oldIndex) { }

	// RVA: 0x1A988B8 Offset: 0x1A948B8 VA: 0x1A988B8
	private void OnListChanged(ListChangedType changedType, int index) { }

	// RVA: 0x1A993E0 Offset: 0x1A953E0 VA: 0x1A993E0
	private void OnListChanged(ListChangedEventArgs e) { }

	// RVA: 0x1A9879C Offset: 0x1A9479C VA: 0x1A9879C
	private void MaintainDataView(ListChangedType changedType, int record, bool trackAddRemove) { }

	// RVA: 0x1A99754 Offset: 0x1A95754 VA: 0x1A99754
	public void Reset() { }

	// RVA: 0x1A9981C Offset: 0x1A9581C VA: 0x1A9981C
	public void RecordChanged(int record) { }

	// RVA: 0x1A99900 Offset: 0x1A95900 VA: 0x1A99900
	public void RecordChanged(int oldIndex, int newIndex) { }

	// RVA: 0x1A99A2C Offset: 0x1A95A2C VA: 0x1A99A2C
	public void RecordStateChanged(int record, DataViewRowState oldState, DataViewRowState newState) { }

	// RVA: 0x1A99B2C Offset: 0x1A95B2C VA: 0x1A99B2C
	public void RecordStateChanged(int oldRecord, DataViewRowState oldOldState, DataViewRowState oldNewState, int newRecord, DataViewRowState newOldState, DataViewRowState newNewState) { }

	// RVA: 0x1A99E9C Offset: 0x1A95E9C VA: 0x1A99E9C
	internal DataTable get_Table() { }

	// RVA: 0x1A989B0 Offset: 0x1A949B0 VA: 0x1A989B0
	private void GetUniqueKeyValues(List<object[]> list, int curNodeId) { }

	// RVA: -1 Offset: -1
	internal static int IndexOfReference<T>(List<T> list, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1119F78 Offset: 0x1115F78 VA: 0x1119F78
	|-Index.IndexOfReference<object>
	*/
}

// Namespace: 
internal sealed class Listeners.Action<TElem, T1, T2, T3, T4> : MulticastDelegate // TypeDefIndex: 4546
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1178968 Offset: 0x1174968 VA: 0x1178968
	|-Listeners.Action<object, object, Int32Enum, object, bool>..ctor
	|
	|-RVA: 0x1178A88 Offset: 0x1174A88 VA: 0x1178A88
	|-Listeners.Action<object, object, object, bool, bool>..ctor
	|
	|-RVA: 0x1178BA8 Offset: 0x1174BA8 VA: 0x1178BA8
	|-Listeners.Action<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1178A74 Offset: 0x1174A74 VA: 0x1178A74
	|-Listeners.Action<object, object, Int32Enum, object, bool>.Invoke
	|
	|-RVA: 0x1178B94 Offset: 0x1174B94 VA: 0x1178B94
	|-Listeners.Action<object, object, object, bool, bool>.Invoke
	|
	|-RVA: 0x1178CB8 Offset: 0x1174CB8 VA: 0x1178CB8
	|-Listeners.Action<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
internal sealed class Listeners.Func<TElem, T1, TResult> : MulticastDelegate // TypeDefIndex: 4547
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1262D98 Offset: 0x125ED98 VA: 0x1262D98
	|-Listeners.Func<object, object, bool>..ctor
	|
	|-RVA: 0x1262EB4 Offset: 0x125EEB4 VA: 0x1262EB4
	|-Listeners.Func<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TResult Invoke(T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1262EA0 Offset: 0x125EEA0 VA: 0x1262EA0
	|-Listeners.Func<object, object, bool>.Invoke
	|
	|-RVA: 0x1262FC0 Offset: 0x125EFC0 VA: 0x1262FC0
	|-Listeners.Func<object, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System.Data
internal sealed class Listeners<TElem> // TypeDefIndex: 4548
{
	// Fields
	private readonly List<TElem> _listeners; // 0x0
	private readonly Listeners.Func<TElem, TElem, bool> _filter; // 0x0
	private readonly int _objectID; // 0x0
	private int _listenerReaderCount; // 0x0

	// Properties
	internal bool HasListeners { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(int ObjectID, Listeners.Func<TElem, TElem, bool> notifyFilter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x138F8C0 Offset: 0x138B8C0 VA: 0x138F8C0
	|-Listeners<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool get_HasListeners() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x138F94C Offset: 0x138B94C VA: 0x138F94C
	|-Listeners<object>.get_HasListeners
	*/

	// RVA: -1 Offset: -1
	internal void Add(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x138F96C Offset: 0x138B96C VA: 0x138F96C
	|-Listeners<object>.Add
	*/

	// RVA: -1 Offset: -1
	internal int IndexOfReference(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x138F9DC Offset: 0x138B9DC VA: 0x138F9DC
	|-Listeners<object>.IndexOfReference
	*/

	// RVA: -1 Offset: -1
	internal void Remove(TElem listener) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x138F9F0 Offset: 0x138B9F0 VA: 0x138F9F0
	|-Listeners<object>.Remove
	*/

	// RVA: -1 Offset: -1
	internal void Notify<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3, Listeners.Action<TElem, TElem, T1, T2, T3> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1004DF0 Offset: 0x1000DF0 VA: 0x1004DF0
	|-Listeners<object>.Notify<Int32Enum, object, bool>
	|
	|-RVA: 0x1004FE4 Offset: 0x1000FE4 VA: 0x1004FE4
	|-Listeners<object>.Notify<object, bool, bool>
	|
	|-RVA: 0x10051D8 Offset: 0x10011D8 VA: 0x10051D8
	|-Listeners<object>.Notify<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void RemoveNullListeners(int nullIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x138FA9C Offset: 0x138BA9C VA: 0x138FA9C
	|-Listeners<object>.RemoveNullListeners
	*/
}

// Namespace: System.Data
[Serializable]
internal sealed class SimpleType : ISerializable // TypeDefIndex: 4549
{
	// Fields
	private string _baseType; // 0x10
	private SimpleType _baseSimpleType; // 0x18
	private XmlQualifiedName _xmlBaseType; // 0x20
	private string _name; // 0x28
	private int _length; // 0x30
	private int _minLength; // 0x34
	private int _maxLength; // 0x38
	private string _pattern; // 0x40
	private string _ns; // 0x48
	private string _maxExclusive; // 0x50
	private string _maxInclusive; // 0x58
	private string _minExclusive; // 0x60
	private string _minInclusive; // 0x68
	internal string _enumeration; // 0x70

	// Properties
	internal string BaseType { get; }
	internal XmlQualifiedName XmlBaseType { get; }
	internal string Name { get; }
	internal string Namespace { get; }
	internal int Length { get; }
	internal int MaxLength { get; set; }
	internal SimpleType BaseSimpleType { get; }
	public string SimpleTypeQualifiedName { get; }

	// Methods

	// RVA: 0x1A99F8C Offset: 0x1A95F8C VA: 0x1A99F8C
	internal void .ctor(string baseType) { }

	// RVA: 0x1A9A094 Offset: 0x1A96094 VA: 0x1A9A094
	internal void .ctor(XmlSchemaSimpleType node) { }

	// RVA: 0x1A9AB4C Offset: 0x1A96B4C VA: 0x1A9AB4C Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1A9A260 Offset: 0x1A96260 VA: 0x1A9A260
	internal void LoadTypeValues(XmlSchemaSimpleType node) { }

	// RVA: 0x1A9ACA0 Offset: 0x1A96CA0 VA: 0x1A9ACA0
	internal bool IsPlainString() { }

	// RVA: 0x1A9AE4C Offset: 0x1A96E4C VA: 0x1A9AE4C
	internal string get_BaseType() { }

	// RVA: 0x1A9AE54 Offset: 0x1A96E54 VA: 0x1A9AE54
	internal XmlQualifiedName get_XmlBaseType() { }

	// RVA: 0x1A9AE5C Offset: 0x1A96E5C VA: 0x1A9AE5C
	internal string get_Name() { }

	// RVA: 0x1A9AE64 Offset: 0x1A96E64 VA: 0x1A9AE64
	internal string get_Namespace() { }

	// RVA: 0x1A9AE6C Offset: 0x1A96E6C VA: 0x1A9AE6C
	internal int get_Length() { }

	// RVA: 0x1A9AE74 Offset: 0x1A96E74 VA: 0x1A9AE74
	internal int get_MaxLength() { }

	// RVA: 0x1A9AE7C Offset: 0x1A96E7C VA: 0x1A9AE7C
	internal void set_MaxLength(int value) { }

	// RVA: 0x1A9AE84 Offset: 0x1A96E84 VA: 0x1A9AE84
	internal SimpleType get_BaseSimpleType() { }

	// RVA: 0x1A9AE8C Offset: 0x1A96E8C VA: 0x1A9AE8C
	public string get_SimpleTypeQualifiedName() { }

	// RVA: 0x1A9AEFC Offset: 0x1A96EFC VA: 0x1A9AEFC
	internal string QualifiedName(string name) { }

	// RVA: 0x1A9AF78 Offset: 0x1A96F78 VA: 0x1A9AF78
	internal XmlNode ToNode(XmlDocument dc, Hashtable prefixes, bool inRemoting) { }

	// RVA: 0x1A9B3CC Offset: 0x1A973CC VA: 0x1A9B3CC
	internal static SimpleType CreateEnumeratedType(string values) { }

	// RVA: 0x1A9B458 Offset: 0x1A97458 VA: 0x1A9B458
	internal static SimpleType CreateByteArrayType(string encoding) { }

	// RVA: 0x1A9B4C0 Offset: 0x1A974C0 VA: 0x1A9B4C0
	internal static SimpleType CreateLimitedStringType(int length) { }

	// RVA: 0x1A9B540 Offset: 0x1A97540 VA: 0x1A9B540
	internal static SimpleType CreateSimpleType(StorageType typeCode, Type type) { }

	// RVA: 0x1A9B610 Offset: 0x1A97610 VA: 0x1A9B610
	internal string HasConflictingDefinition(SimpleType otherSimpleType) { }

	// RVA: 0x1A9B704 Offset: 0x1A97704 VA: 0x1A9B704
	internal bool CanHaveMaxLength() { }

	// RVA: 0x1A9B768 Offset: 0x1A97768 VA: 0x1A9B768
	internal void ConvertToAnnonymousSimpleType() { }
}

// Namespace: System.Data
[DefaultProperty("ConstraintName")]
public class UniqueConstraint : Constraint // TypeDefIndex: 4550
{
	// Fields
	private DataKey _key; // 0x38
	private Index _constraintIndex; // 0x40
	internal bool _bPrimaryKey; // 0x48
	internal string _constraintName; // 0x50
	internal string[] _columnNames; // 0x58

	// Properties
	internal string[] ColumnNames { get; }
	internal Index ConstraintIndex { get; }
	[ReadOnly(True)]
	public virtual DataColumn[] Columns { get; }
	internal DataColumn[] ColumnsReference { get; }
	public bool IsPrimaryKey { get; }
	internal override bool InCollection { set; }
	internal DataKey Key { get; }
	[ReadOnly(True)]
	public override DataTable Table { get; }

	// Methods

	// RVA: 0x1A9B7E8 Offset: 0x1A977E8 VA: 0x1A9B7E8
	public void .ctor(DataColumn column) { }

	// RVA: 0x1A9B998 Offset: 0x1A97998 VA: 0x1A9B998
	public void .ctor(string name, DataColumn[] columns) { }

	// RVA: 0x1A9B9CC Offset: 0x1A979CC VA: 0x1A9B9CC
	public void .ctor(DataColumn[] columns) { }

	[Browsable(False)]
	// RVA: 0x1A9B9FC Offset: 0x1A979FC VA: 0x1A9B9FC
	public void .ctor(string name, string[] columnNames, bool isPrimaryKey) { }

	// RVA: 0x1A9BA54 Offset: 0x1A97A54 VA: 0x1A9BA54
	public void .ctor(string name, DataColumn[] columns, bool isPrimaryKey) { }

	// RVA: 0x1A9BA98 Offset: 0x1A97A98 VA: 0x1A9BA98
	internal string[] get_ColumnNames() { }

	// RVA: 0x1A9BAA4 Offset: 0x1A97AA4 VA: 0x1A9BAA4
	internal Index get_ConstraintIndex() { }

	// RVA: 0x1A9BAAC Offset: 0x1A97AAC VA: 0x1A9BAAC
	internal void ConstraintIndexClear() { }

	// RVA: 0x1A9BADC Offset: 0x1A97ADC VA: 0x1A9BADC
	internal void ConstraintIndexInitialize() { }

	// RVA: 0x1A9BB34 Offset: 0x1A97B34 VA: 0x1A9BB34 Slot: 16
	internal override void CheckState() { }

	// RVA: 0x1A9BB40 Offset: 0x1A97B40 VA: 0x1A9BB40
	private void NonVirtualCheckState() { }

	// RVA: 0x1A9BB4C Offset: 0x1A97B4C VA: 0x1A9BB4C Slot: 13
	internal override void CheckCanAddToCollection(ConstraintCollection constraints) { }

	// RVA: 0x1A9BB50 Offset: 0x1A97B50 VA: 0x1A9BB50 Slot: 14
	internal override bool CanBeRemovedFromCollection(ConstraintCollection constraints, bool fThrowException) { }

	// RVA: 0x1A9BCBC Offset: 0x1A97CBC VA: 0x1A9BCBC Slot: 10
	internal override bool CanEnableConstraint() { }

	// RVA: 0x1A9BD08 Offset: 0x1A97D08 VA: 0x1A9BD08 Slot: 18
	internal override bool IsConstraintViolated() { }

	// RVA: 0x1A9BF60 Offset: 0x1A97F60 VA: 0x1A9BF60 Slot: 15
	internal override void CheckConstraint(DataRow row, DataRowAction action) { }

	// RVA: 0x1A9C060 Offset: 0x1A98060 VA: 0x1A9C060 Slot: 9
	internal override bool ContainsColumn(DataColumn column) { }

	// RVA: 0x1A9C06C Offset: 0x1A9806C VA: 0x1A9C06C Slot: 11
	internal override Constraint Clone(DataSet destination) { }

	// RVA: 0x1A9C07C Offset: 0x1A9807C VA: 0x1A9C07C Slot: 12
	internal override Constraint Clone(DataSet destination, bool ignorNSforTableLookup) { }

	// RVA: 0x1A9C5B8 Offset: 0x1A985B8 VA: 0x1A9C5B8
	internal UniqueConstraint Clone(DataTable table) { }

	// RVA: 0x1A9CA44 Offset: 0x1A98A44 VA: 0x1A9CA44 Slot: 19
	public virtual DataColumn[] get_Columns() { }

	// RVA: 0x1A9C058 Offset: 0x1A98058 VA: 0x1A9C058
	internal DataColumn[] get_ColumnsReference() { }

	// RVA: 0x1A9CA50 Offset: 0x1A98A50 VA: 0x1A9CA50
	public bool get_IsPrimaryKey() { }

	// RVA: 0x1A9B8A4 Offset: 0x1A978A4 VA: 0x1A9B8A4
	private void Create(string constraintName, DataColumn[] columns) { }

	// RVA: 0x1A9CA94 Offset: 0x1A98A94 VA: 0x1A9CA94 Slot: 0
	public override bool Equals(object key2) { }

	// RVA: 0x1A9CB38 Offset: 0x1A98B38 VA: 0x1A9CB38 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1A9CB40 Offset: 0x1A98B40 VA: 0x1A9CB40 Slot: 7
	internal override void set_InCollection(bool value) { }

	// RVA: 0x1A9CB8C Offset: 0x1A98B8C VA: 0x1A9CB8C
	internal DataKey get_Key() { }

	// RVA: 0x1A9CB94 Offset: 0x1A98B94 VA: 0x1A9CB94 Slot: 8
	public override DataTable get_Table() { }
}

// Namespace: 
private sealed class XDRSchema.NameType : IComparable // TypeDefIndex: 4551
{
	// Fields
	public string name; // 0x10
	public Type type; // 0x18

	// Methods

	// RVA: 0x1AA0614 Offset: 0x1A9C614 VA: 0x1AA0614
	public void .ctor(string n, Type t) { }

	// RVA: 0x1AA0658 Offset: 0x1A9C658 VA: 0x1AA0658 Slot: 4
	public int CompareTo(object obj) { }
}

// Namespace: System.Data
internal sealed class XDRSchema : XMLSchema // TypeDefIndex: 4552
{
	// Fields
	internal string _schemaName; // 0x10
	internal string _schemaUri; // 0x18
	internal XmlElement _schemaRoot; // 0x20
	internal DataSet _ds; // 0x28
	private static readonly char[] s_colonArray; // 0x0
	private static XDRSchema.NameType[] s_mapNameTypeXdr; // 0x8
	private static XDRSchema.NameType s_enumerationNameType; // 0x10

	// Methods

	// RVA: 0x1A9CBC8 Offset: 0x1A98BC8 VA: 0x1A9CBC8
	internal void .ctor(DataSet ds, bool fInline) { }

	// RVA: 0x1A9CC48 Offset: 0x1A98C48 VA: 0x1A9CC48
	internal void LoadSchema(XmlElement schemaRoot, DataSet ds) { }

	// RVA: 0x1A9D0DC Offset: 0x1A990DC VA: 0x1A9D0DC
	internal XmlElement FindTypeNode(XmlElement node) { }

	// RVA: 0x1A9D3F4 Offset: 0x1A993F4 VA: 0x1A9D3F4
	internal bool IsTextOnlyContent(XmlElement node) { }

	// RVA: 0x1A9D5C4 Offset: 0x1A995C4 VA: 0x1A9D5C4
	internal bool IsXDRField(XmlElement node, XmlElement typeNode) { }

	// RVA: 0x1A9CF1C Offset: 0x1A98F1C VA: 0x1A9CF1C
	internal DataTable HandleTable(XmlElement node) { }

	// RVA: 0x1A9DFD0 Offset: 0x1A99FD0 VA: 0x1A9DFD0
	private static XDRSchema.NameType FindNameType(string name) { }

	// RVA: 0x1A9E0A4 Offset: 0x1A9A0A4 VA: 0x1A9E0A4
	private Type ParseDataType(string dt, string dtValues) { }

	// RVA: 0x1A9E1F0 Offset: 0x1A9A1F0 VA: 0x1A9E1F0
	internal string GetInstanceName(XmlElement node) { }

	// RVA: 0x1A9E368 Offset: 0x1A9A368 VA: 0x1A9E368
	internal void HandleColumn(XmlElement node, DataTable table) { }

	// RVA: 0x1A9D724 Offset: 0x1A99724 VA: 0x1A9D724
	internal void GetMinMax(XmlElement elNode, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0x1A9ECEC Offset: 0x1A9ACEC VA: 0x1A9ECEC
	internal void GetMinMax(XmlElement elNode, bool isAttribute, ref int minOccurs, ref int maxOccurs) { }

	// RVA: 0x1A9F4D8 Offset: 0x1A9B4D8 VA: 0x1A9F4D8
	internal void HandleTypeNode(XmlElement typeNode, DataTable table, ArrayList tableChildren) { }

	// RVA: 0x1A9D964 Offset: 0x1A99964 VA: 0x1A9D964
	internal DataTable InstantiateTable(DataSet dataSet, XmlElement node, XmlElement typeNode) { }

	// RVA: 0x1A9D734 Offset: 0x1A99734 VA: 0x1A9D734
	internal DataTable InstantiateSimpleTable(DataSet dataSet, XmlElement node) { }

	// RVA: 0x1A9F6C0 Offset: 0x1A9B6C0 VA: 0x1A9F6C0
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class XMLDiffLoader // TypeDefIndex: 4553
{
	// Fields
	private ArrayList _tables; // 0x10
	private DataSet _dataSet; // 0x18
	private DataTable _dataTable; // 0x20

	// Methods

	// RVA: 0x1AA0694 Offset: 0x1A9C694 VA: 0x1AA0694
	internal void LoadDiffGram(DataSet ds, XmlReader dataTextReader) { }

	// RVA: 0x1AA0ED8 Offset: 0x1A9CED8 VA: 0x1AA0ED8
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1AA1224 Offset: 0x1A9D224 VA: 0x1AA1224
	internal void LoadDiffGram(DataTable dt, XmlReader dataTextReader) { }

	// RVA: 0x1AA0848 Offset: 0x1A9C848 VA: 0x1AA0848
	internal void ProcessDiffs(DataSet ds, XmlReader ssync) { }

	// RVA: 0x1AA1434 Offset: 0x1A9D434 VA: 0x1AA1434
	internal void ProcessDiffs(ArrayList tableList, XmlReader ssync) { }

	// RVA: 0x1AA0B38 Offset: 0x1A9CB38 VA: 0x1AA0B38
	internal void ProcessErrors(DataSet ds, XmlReader ssync) { }

	// RVA: 0x1AA1718 Offset: 0x1A9D718 VA: 0x1AA1718
	internal void ProcessErrors(ArrayList dt, XmlReader ssync) { }

	// RVA: 0x1AA2A2C Offset: 0x1A9EA2C VA: 0x1AA2A2C
	private DataTable GetTable(string tableName, string ns) { }

	// RVA: 0x1AA1C28 Offset: 0x1A9DC28 VA: 0x1AA1C28
	private int ReadOldRowData(DataSet ds, ref DataTable table, ref int pos, XmlReader row) { }

	// RVA: 0x1AA1BC8 Offset: 0x1A9DBC8 VA: 0x1AA1BC8
	internal void SkipWhitespaces(XmlReader reader) { }

	// RVA: 0x1AA2BF8 Offset: 0x1A9EBF8 VA: 0x1AA2BF8
	public void .ctor() { }
}

// Namespace: System.Data
internal class XMLSchema // TypeDefIndex: 4554
{
	// Methods

	// RVA: 0x1AA2C00 Offset: 0x1A9EC00 VA: 0x1AA2C00
	internal static TypeConverter GetConverter(Type type) { }

	// RVA: 0x1A9F0C0 Offset: 0x1A9B0C0 VA: 0x1A9F0C0
	internal static void SetProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0x1A9CEA8 Offset: 0x1A98EA8 VA: 0x1A9CEA8
	internal static bool FEqualIdentity(XmlNode node, string name, string ns) { }

	// RVA: 0x1AA2C58 Offset: 0x1A9EC58 VA: 0x1AA2C58
	internal static bool GetBooleanAttribute(XmlElement element, string attrName, string attrNS, bool defVal) { }

	// RVA: 0x1A9EBC4 Offset: 0x1A9ABC4 VA: 0x1A9EBC4
	internal static string GenUniqueColumnName(string proposedName, DataTable table) { }

	// RVA: 0x1A9CC40 Offset: 0x1A98C40 VA: 0x1A9CC40
	public void .ctor() { }
}

// Namespace: System.Data
internal sealed class ConstraintTable // TypeDefIndex: 4555
{
	// Fields
	public DataTable table; // 0x10
	public XmlSchemaIdentityConstraint constraint; // 0x18

	// Methods

	// RVA: 0x1AA2DA8 Offset: 0x1A9EDA8 VA: 0x1AA2DA8
	public void .ctor(DataTable t, XmlSchemaIdentityConstraint c) { }
}

// Namespace: 
private sealed class XSDSchema.NameType : IComparable // TypeDefIndex: 4556
{
	// Fields
	public readonly string name; // 0x10
	public readonly Type type; // 0x18

	// Methods

	// RVA: 0x1AB26AC Offset: 0x1AAE6AC VA: 0x1AB26AC
	public void .ctor(string n, Type t) { }

	// RVA: 0x1AB26F0 Offset: 0x1AAE6F0 VA: 0x1AB26F0 Slot: 4
	public int CompareTo(object obj) { }
}

// Namespace: System.Data
internal sealed class XSDSchema : XMLSchema // TypeDefIndex: 4557
{
	// Fields
	private XmlSchemaSet _schemaSet; // 0x10
	private XmlSchemaElement _dsElement; // 0x18
	private DataSet _ds; // 0x20
	private string _schemaName; // 0x28
	private ArrayList _columnExpressions; // 0x30
	private Hashtable _constraintNodes; // 0x38
	private ArrayList _refTables; // 0x40
	private ArrayList _complexTypes; // 0x48
	private XmlSchemaObjectCollection _annotations; // 0x50
	private XmlSchemaObjectCollection _elements; // 0x58
	private Hashtable _attributes; // 0x60
	private Hashtable _elementsTable; // 0x68
	private Hashtable _attributeGroups; // 0x70
	private Hashtable _schemaTypes; // 0x78
	private Hashtable _expressions; // 0x80
	private Dictionary<DataTable, List<DataTable>> _tableDictionary; // 0x88
	private Hashtable _udSimpleTypes; // 0x90
	private Hashtable _existingSimpleTypeMap; // 0x98
	private bool _fromInference; // 0xA0
	private static readonly XSDSchema.NameType[] s_mapNameTypeXsd; // 0x0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0x1AA2DEC Offset: 0x1A9EDEC VA: 0x1AA2DEC
	internal bool get_FromInference() { }

	// RVA: 0x1AA2DF4 Offset: 0x1A9EDF4 VA: 0x1AA2DF4
	internal void set_FromInference(bool value) { }

	// RVA: 0x1AA2DFC Offset: 0x1A9EDFC VA: 0x1AA2DFC
	private void CollectElementsAnnotations(XmlSchema schema) { }

	// RVA: 0x1AA2E84 Offset: 0x1A9EE84 VA: 0x1AA2E84
	private void CollectElementsAnnotations(XmlSchema schema, ArrayList schemaList) { }

	// RVA: 0x1A9ADD0 Offset: 0x1A96DD0 VA: 0x1A9ADD0
	internal static string QualifiedName(string name) { }

	// RVA: 0x1AA3790 Offset: 0x1A9F790 VA: 0x1AA3790
	internal static void SetProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x1AA3CB8 Offset: 0x1A9FCB8 VA: 0x1AA3CB8
	private static void SetExtProperties(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x1AA4048 Offset: 0x1AA0048 VA: 0x1AA4048
	private void HandleColumnExpression(object instance, XmlAttribute[] attrs) { }

	// RVA: 0x1A9AB84 Offset: 0x1A96B84 VA: 0x1A9AB84
	internal static string GetMsdataAttribute(XmlSchemaAnnotated node, string ln) { }

	// RVA: 0x1AA424C Offset: 0x1AA024C VA: 0x1AA424C
	private static void SetExtProperties(object instance, XmlAttributeCollection attrs) { }

	// RVA: 0x1AA4490 Offset: 0x1AA0490 VA: 0x1AA4490
	internal void HandleRefTableProperties(ArrayList RefTables, XmlSchemaElement element) { }

	// RVA: 0x1AA464C Offset: 0x1AA064C VA: 0x1AA464C
	internal void HandleRelation(XmlElement node, bool fNested) { }

	// RVA: 0x1AA4EEC Offset: 0x1AA0EEC VA: 0x1AA4EEC
	private bool HasAttributes(XmlSchemaObjectCollection attributes) { }

	// RVA: 0x1AA512C Offset: 0x1AA112C VA: 0x1AA512C
	private bool IsDatasetParticle(XmlSchemaParticle pt) { }

	// RVA: 0x1AA5ADC Offset: 0x1AA1ADC VA: 0x1AA5ADC
	private int DatasetElementCount(XmlSchemaObjectCollection elements) { }

	// RVA: 0x1AA5E44 Offset: 0x1AA1E44 VA: 0x1AA5E44
	private XmlSchemaElement FindDatasetElement(XmlSchemaObjectCollection elements) { }

	// RVA: 0x1AA63F8 Offset: 0x1AA23F8 VA: 0x1AA63F8
	public void LoadSchema(XmlSchemaSet schemaSet, DataTable dt) { }

	// RVA: 0x1AA6414 Offset: 0x1AA2414 VA: 0x1AA6414
	public void LoadSchema(XmlSchemaSet schemaSet, DataSet ds) { }

	// RVA: 0x1AA98FC Offset: 0x1AA58FC VA: 0x1AA98FC
	private void HandleRelations(XmlSchemaAnnotation ann, bool fNested) { }

	// RVA: 0x1AA5650 Offset: 0x1AA1650 VA: 0x1AA5650
	internal XmlSchemaObjectCollection GetParticleItems(XmlSchemaParticle pt) { }

	// RVA: 0x1AA9BE0 Offset: 0x1AA5BE0 VA: 0x1AA9BE0
	internal void HandleParticle(XmlSchemaParticle pt, DataTable table, ArrayList tableChildren, bool isBase) { }

	// RVA: 0x1AAB110 Offset: 0x1AA7110 VA: 0x1AAB110
	internal void HandleAttributes(XmlSchemaObjectCollection attributes, DataTable table, bool isBase) { }

	// RVA: 0x1AABDA4 Offset: 0x1AA7DA4 VA: 0x1AABDA4
	private void HandleAttributeGroup(XmlSchemaAttributeGroup attributeGroup, DataTable table, bool isBase) { }

	// RVA: 0x1AAC128 Offset: 0x1AA8128 VA: 0x1AAC128
	internal void HandleComplexType(XmlSchemaComplexType ct, DataTable table, ArrayList tableChildren, bool isNillable) { }

	// RVA: 0x1AA62D8 Offset: 0x1AA22D8 VA: 0x1AA62D8
	internal XmlSchemaParticle GetParticle(XmlSchemaComplexType ct) { }

	// RVA: 0x1AAD830 Offset: 0x1AA9830 VA: 0x1AAD830
	internal DataColumn FindField(DataTable table, string field) { }

	// RVA: 0x1AAD9AC Offset: 0x1AA99AC VA: 0x1AAD9AC
	internal DataColumn[] BuildKey(XmlSchemaIdentityConstraint keyNode, DataTable table) { }

	// RVA: 0x1AA5CEC Offset: 0x1AA1CEC VA: 0x1AA5CEC
	internal bool GetBooleanAttribute(XmlSchemaAnnotated element, string attrName, bool defVal) { }

	// RVA: 0x1AA82A0 Offset: 0x1AA42A0 VA: 0x1AA82A0
	internal string GetStringAttribute(XmlSchemaAnnotated element, string attrName, string defVal) { }

	// RVA: 0x1AADC54 Offset: 0x1AA9C54 VA: 0x1AADC54
	internal static AcceptRejectRule TranslateAcceptRejectRule(string strRule) { }

	// RVA: 0x1AADCD8 Offset: 0x1AA9CD8 VA: 0x1AADCD8
	internal static Rule TranslateRule(string strRule) { }

	// RVA: 0x1AADDC4 Offset: 0x1AA9DC4 VA: 0x1AADDC4
	internal void HandleKeyref(XmlSchemaKeyref keyref) { }

	// RVA: 0x1AAE654 Offset: 0x1AAA654 VA: 0x1AAE654
	internal void HandleConstraint(XmlSchemaIdentityConstraint keyNode) { }

	// RVA: 0x1AAEA84 Offset: 0x1AAAA84 VA: 0x1AAEA84
	internal DataTable InstantiateSimpleTable(XmlSchemaElement node) { }

	// RVA: 0x1AA4574 Offset: 0x1AA0574 VA: 0x1AA4574
	internal string GetInstanceName(XmlSchemaAnnotated node) { }

	// RVA: 0x1AAF53C Offset: 0x1AAB53C VA: 0x1AAF53C
	internal DataTable InstantiateTable(XmlSchemaElement node, XmlSchemaComplexType typeNode, bool isRef) { }

	// RVA: 0x1AB0A9C Offset: 0x1AACA9C VA: 0x1AB0A9C
	public static Type XsdtoClr(string xsdTypeName) { }

	// RVA: 0x1AB0B78 Offset: 0x1AACB78 VA: 0x1AB0B78
	private static XSDSchema.NameType FindNameType(string name) { }

	// RVA: 0x1AB0C4C Offset: 0x1AACC4C VA: 0x1AB0C4C
	private Type ParseDataType(string dt) { }

	// RVA: 0x1AB0DB0 Offset: 0x1AACDB0 VA: 0x1AB0DB0
	internal static bool IsXsdType(string name) { }

	// RVA: 0x1AA8320 Offset: 0x1AA4320 VA: 0x1AA8320
	internal XmlSchemaAnnotated FindTypeNode(XmlSchemaAnnotated node) { }

	// RVA: 0x1AACE94 Offset: 0x1AA8E94 VA: 0x1AACE94
	internal void HandleSimpleTypeSimpleContentColumn(XmlSchemaSimpleType typeNode, string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0x1AAC714 Offset: 0x1AA8714 VA: 0x1AAC714
	internal void HandleSimpleContentColumn(string strType, DataTable table, bool isBase, XmlAttribute[] attrs, bool isNillable) { }

	// RVA: 0x1AAB3CC Offset: 0x1AA73CC VA: 0x1AAB3CC
	internal void HandleAttributeColumn(XmlSchemaAttribute attrib, DataTable table, bool isBase) { }

	// RVA: 0x1AAA4DC Offset: 0x1AA64DC VA: 0x1AAA4DC
	internal void HandleElementColumn(XmlSchemaElement elem, DataTable table, bool isBase) { }

	// RVA: 0x1AA877C Offset: 0x1AA477C VA: 0x1AA877C
	internal void HandleDataSet(XmlSchemaElement node, bool isNewDataSet) { }

	// RVA: 0x1AB0E20 Offset: 0x1AACE20 VA: 0x1AB0E20
	private void AddTablesToList(List<DataTable> tableList, DataTable dt) { }

	// RVA: 0x1AAF158 Offset: 0x1AAB158 VA: 0x1AAF158
	private string GetPrefix(string ns) { }

	// RVA: 0x1AB1020 Offset: 0x1AAD020 VA: 0x1AB1020
	private string GetNamespaceFromPrefix(string prefix) { }

	// RVA: 0x1AB0918 Offset: 0x1AAC918 VA: 0x1AB0918
	private string GetTableNamespace(XmlSchemaIdentityConstraint key) { }

	// RVA: 0x1AAE53C Offset: 0x1AAA53C VA: 0x1AAE53C
	private string GetTableName(XmlSchemaIdentityConstraint key) { }

	// RVA: 0x1AA5870 Offset: 0x1AA1870 VA: 0x1AA5870
	internal bool IsTable(XmlSchemaElement node) { }

	// RVA: 0x1AA8604 Offset: 0x1AA4604 VA: 0x1AA8604
	internal DataTable HandleTable(XmlSchemaElement node) { }

	// RVA: 0x1AB140C Offset: 0x1AAD40C VA: 0x1AB140C
	public void .ctor() { }

	// RVA: 0x1AB1414 Offset: 0x1AAD414 VA: 0x1AB1414
	private static void .cctor() { }
}

// Namespace: System.Data
internal sealed class XmlIgnoreNamespaceReader : XmlNodeReader // TypeDefIndex: 4558
{
	// Fields
	private List<string> _namespacesToIgnore; // 0x30

	// Methods

	// RVA: 0x1AB272C Offset: 0x1AAE72C VA: 0x1AB272C
	internal void .ctor(XmlDocument xdoc, string[] namespacesToIgnore) { }

	// RVA: 0x1AB27CC Offset: 0x1AAE7CC VA: 0x1AB27CC Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1AB28DC Offset: 0x1AAE8DC VA: 0x1AB28DC Slot: 28
	public override bool MoveToNextAttribute() { }
}

// Namespace: System.Data
internal sealed class XmlDataLoader // TypeDefIndex: 4559
{
	// Fields
	private DataSet _dataSet; // 0x10
	private XmlToDatasetMap _nodeToSchemaMap; // 0x18
	private Hashtable _nodeToRowMap; // 0x20
	private Stack _childRowsStack; // 0x28
	private Hashtable _htableExcludedNS; // 0x30
	private bool _fIsXdr; // 0x38
	internal bool _isDiffgram; // 0x39
	private XmlElement _topMostNode; // 0x40
	private bool _ignoreSchema; // 0x48
	private DataTable _dataTable; // 0x50
	private bool _isTableLevel; // 0x58
	private bool _fromInference; // 0x59
	private XmlReader _dataReader; // 0x60
	private object _XSD_XMLNS_NS; // 0x68
	private object _XDR_SCHEMA; // 0x70
	private object _XDRNS; // 0x78
	private object _SQL_SYNC; // 0x80
	private object _UPDGNS; // 0x88
	private object _XSD_SCHEMA; // 0x90
	private object _XSDNS; // 0x98
	private object _DFFNS; // 0xA0
	private object _MSDNS; // 0xA8
	private object _DIFFID; // 0xB0
	private object _HASCHANGES; // 0xB8
	private object _ROWORDER; // 0xC0

	// Properties
	internal bool FromInference { get; set; }

	// Methods

	// RVA: 0x1AB29E8 Offset: 0x1AAE9E8 VA: 0x1AB29E8
	internal void .ctor(DataSet dataset, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x1AB2A94 Offset: 0x1AAEA94 VA: 0x1AB2A94
	internal void .ctor(DataSet dataset, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x1AB2B98 Offset: 0x1AAEB98 VA: 0x1AB2B98
	internal void .ctor(DataTable datatable, bool IsXdr, bool ignoreSchema) { }

	// RVA: 0x1AB2C5C Offset: 0x1AAEC5C VA: 0x1AB2C5C
	internal void .ctor(DataTable datatable, bool IsXdr, XmlElement topNode, bool ignoreSchema) { }

	// RVA: 0x1AB2D78 Offset: 0x1AAED78 VA: 0x1AB2D78
	internal bool get_FromInference() { }

	// RVA: 0x1AB2D80 Offset: 0x1AAED80 VA: 0x1AB2D80
	internal void set_FromInference(bool value) { }

	// RVA: 0x1AB2D88 Offset: 0x1AAED88 VA: 0x1AB2D88
	private void AttachRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x1AB2F7C Offset: 0x1AAEF7C VA: 0x1AB2F7C
	private int CountNonNSAttributes(XmlNode node) { }

	// RVA: 0x1AB30FC Offset: 0x1AAF0FC VA: 0x1AB30FC
	private string GetValueForTextOnlyColums(XmlNode n) { }

	// RVA: 0x1AB3314 Offset: 0x1AAF314 VA: 0x1AB3314
	private string GetInitialTextFromNodes(ref XmlNode n) { }

	// RVA: 0x1AB3510 Offset: 0x1AAF510 VA: 0x1AB3510
	private DataColumn GetTextOnlyColumn(DataRow row) { }

	// RVA: 0x1AB2EE4 Offset: 0x1AAEEE4 VA: 0x1AB2EE4
	internal DataRow GetRowFromElement(XmlElement e) { }

	// RVA: 0x1AB35D4 Offset: 0x1AAF5D4 VA: 0x1AB35D4
	internal bool FColumnElement(XmlElement e) { }

	// RVA: 0x1AB3070 Offset: 0x1AAF070 VA: 0x1AB3070
	private bool FExcludedNamespace(string ns) { }

	// RVA: 0x1AB36BC Offset: 0x1AAF6BC VA: 0x1AB36BC
	private bool FIgnoreNamespace(XmlNode node) { }

	// RVA: 0x1AB397C Offset: 0x1AAF97C VA: 0x1AB397C
	private bool FIgnoreNamespace(XmlReader node) { }

	// RVA: 0x1AB32C0 Offset: 0x1AAF2C0 VA: 0x1AB32C0
	internal bool IsTextLikeNode(XmlNodeType n) { }

	// RVA: 0x1AB35A4 Offset: 0x1AAF5A4 VA: 0x1AB35A4
	internal bool IsTextOnly(DataColumn c) { }

	// RVA: 0x1AB3A04 Offset: 0x1AAFA04 VA: 0x1AB3A04
	internal void LoadData(XmlDocument xdoc) { }

	// RVA: 0x1AB3E4C Offset: 0x1AAFE4C VA: 0x1AB3E4C
	private void LoadRowData(DataRow row, XmlElement rowElement) { }

	// RVA: 0x1AB4A28 Offset: 0x1AB0A28 VA: 0x1AB4A28
	private void LoadRows(DataRow parentRow, XmlNode parentElement) { }

	// RVA: 0x1AB4D64 Offset: 0x1AB0D64 VA: 0x1AB4D64
	private void SetRowValueFromXmlText(DataRow row, DataColumn col, string xmlText) { }

	// RVA: 0x1AB4DD4 Offset: 0x1AB0DD4 VA: 0x1AB4DD4
	private void InitNameTable() { }

	// RVA: 0x1AB50DC Offset: 0x1AB10DC VA: 0x1AB50DC
	internal void LoadData(XmlReader reader) { }

	// RVA: 0x1AB54BC Offset: 0x1AB14BC VA: 0x1AB54BC
	private void LoadTopMostTable(DataTable table) { }

	// RVA: 0x1AB60E8 Offset: 0x1AB20E8 VA: 0x1AB60E8
	private void LoadTable(DataTable table, bool isNested) { }

	// RVA: 0x1AB6F30 Offset: 0x1AB2F30 VA: 0x1AB6F30
	private void LoadColumn(DataColumn column, object[] foundColumns) { }

	// RVA: 0x1AB5EC8 Offset: 0x1AB1EC8 VA: 0x1AB5EC8
	private bool ProcessXsdSchema() { }
}

// Namespace: System.Data
public enum XmlReadMode // TypeDefIndex: 4560
{
	// Fields
	public int value__; // 0x0
	public const XmlReadMode Auto = 0;
	public const XmlReadMode ReadSchema = 1;
	public const XmlReadMode IgnoreSchema = 2;
	public const XmlReadMode InferSchema = 3;
	public const XmlReadMode DiffGram = 4;
	public const XmlReadMode Fragment = 5;
	public const XmlReadMode InferTypedSchema = 6;
}

// Namespace: 
private sealed class XmlToDatasetMap.XmlNodeIdentety // TypeDefIndex: 4561
{
	// Fields
	public string LocalName; // 0x10
	public string NamespaceURI; // 0x18

	// Methods

	// RVA: 0x1AB9788 Offset: 0x1AB5788 VA: 0x1AB9788
	public void .ctor(string localName, string namespaceURI) { }

	// RVA: 0x1ABA454 Offset: 0x1AB6454 VA: 0x1ABA454 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ABA470 Offset: 0x1AB6470 VA: 0x1ABA470 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: 
[DefaultMember("Item")]
internal sealed class XmlToDatasetMap.XmlNodeIdHashtable : Hashtable // TypeDefIndex: 4562
{
	// Fields
	private XmlToDatasetMap.XmlNodeIdentety _id; // 0x50

	// Properties
	public object Item { get; }
	public object Item { get; }
	public object Item { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x1AB9DA4 Offset: 0x1AB5DA4 VA: 0x1AB9DA4
	public void .ctor(int capacity) { }

	// RVA: 0x1ABA260 Offset: 0x1AB6260 VA: 0x1ABA260
	public object get_Item(XmlNode node) { }

	// RVA: 0x1ABA3CC Offset: 0x1AB63CC VA: 0x1ABA3CC
	public object get_Item(XmlReader dataReader) { }

	// RVA: 0x1ABA34C Offset: 0x1AB634C VA: 0x1ABA34C
	public object get_Item(DataTable table) { }

	// RVA: 0x1ABA2F0 Offset: 0x1AB62F0 VA: 0x1ABA2F0
	public object get_Item(string name) { }
}

// Namespace: 
private sealed class XmlToDatasetMap.TableSchemaInfo // TypeDefIndex: 4563
{
	// Fields
	public DataTable TableSchema; // 0x10
	public XmlToDatasetMap.XmlNodeIdHashtable ColumnsSchemaMap; // 0x18

	// Methods

	// RVA: 0x1AB96E4 Offset: 0x1AB56E4 VA: 0x1AB96E4
	public void .ctor(DataTable tableSchema) { }
}

// Namespace: System.Data
internal sealed class XmlToDatasetMap // TypeDefIndex: 4564
{
	// Fields
	private XmlToDatasetMap.XmlNodeIdHashtable _tableSchemaMap; // 0x10
	private XmlToDatasetMap.TableSchemaInfo _lastTableSchemaInfo; // 0x18

	// Methods

	// RVA: 0x1AB3D30 Offset: 0x1AAFD30 VA: 0x1AB3D30
	public void .ctor(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x1AB5454 Offset: 0x1AB1454 VA: 0x1AB5454
	public void .ctor(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x1AB3CFC Offset: 0x1AAFCFC VA: 0x1AB3CFC
	public void .ctor(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x1AB5488 Offset: 0x1AB1488 VA: 0x1AB5488
	public void .ctor(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x1AB4DAC Offset: 0x1AB0DAC VA: 0x1AB4DAC
	internal static bool IsMappedColumn(DataColumn c) { }

	// RVA: 0x1AB95C4 Offset: 0x1AB55C4 VA: 0x1AB95C4
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(DataTable table, XmlNameTable nameTable) { }

	// RVA: 0x1AB97CC Offset: 0x1AB57CC VA: 0x1AB97CC
	private XmlToDatasetMap.TableSchemaInfo AddTableSchema(XmlNameTable nameTable, DataTable table) { }

	// RVA: 0x1AB9954 Offset: 0x1AB5954 VA: 0x1AB9954
	private bool AddColumnSchema(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x1AB9BE0 Offset: 0x1AB5BE0 VA: 0x1AB9BE0
	private bool AddColumnSchema(XmlNameTable nameTable, DataColumn col, XmlToDatasetMap.XmlNodeIdHashtable columns) { }

	// RVA: 0x1AB784C Offset: 0x1AB384C VA: 0x1AB784C
	private void BuildIdentityMap(DataSet dataSet, XmlNameTable nameTable) { }

	// RVA: 0x1AB7E00 Offset: 0x1AB3E00 VA: 0x1AB7E00
	private void BuildIdentityMap(XmlNameTable nameTable, DataSet dataSet) { }

	// RVA: 0x1AB8868 Offset: 0x1AB4868 VA: 0x1AB8868
	private void BuildIdentityMap(DataTable dataTable, XmlNameTable nameTable) { }

	// RVA: 0x1AB8B9C Offset: 0x1AB4B9C VA: 0x1AB8B9C
	private void BuildIdentityMap(XmlNameTable nameTable, DataTable dataTable) { }

	// RVA: 0x1AB9E38 Offset: 0x1AB5E38 VA: 0x1AB9E38
	private ArrayList GetSelfAndDescendants(DataTable dt) { }

	// RVA: 0x1AB379C Offset: 0x1AAF79C VA: 0x1AB379C
	public object GetColumnSchema(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x1AB6DF4 Offset: 0x1AB2DF4 VA: 0x1AB6DF4
	public object GetColumnSchema(DataTable table, XmlReader dataReader, bool fIgnoreNamespace) { }

	// RVA: 0x1AB3D64 Offset: 0x1AAFD64 VA: 0x1AB3D64
	public object GetSchemaForNode(XmlNode node, bool fIgnoreNamespace) { }

	// RVA: 0x1AB5DF0 Offset: 0x1AB1DF0 VA: 0x1AB5DF0
	public DataTable GetTableForNode(XmlReader node, bool fIgnoreNamespace) { }

	// RVA: 0x1AB9A84 Offset: 0x1AB5A84 VA: 0x1AB9A84
	private void HandleSpecialColumn(DataColumn col, XmlNameTable nameTable, XmlToDatasetMap.XmlNodeIdHashtable columns) { }
}

// Namespace: System.Data
public enum XmlWriteMode // TypeDefIndex: 4565
{
	// Fields
	public int value__; // 0x0
	public const XmlWriteMode WriteSchema = 0;
	public const XmlWriteMode IgnoreSchema = 1;
	public const XmlWriteMode DiffGram = 2;
}

// Namespace: System.Data
internal enum SchemaFormat // TypeDefIndex: 4566
{
	// Fields
	public int value__; // 0x0
	public const SchemaFormat Public = 1;
	public const SchemaFormat Remoting = 2;
	public const SchemaFormat WebService = 3;
	public const SchemaFormat RemotingSkipSchema = 4;
	public const SchemaFormat WebServiceSkipSchema = 5;
}

// Namespace: System.Data
internal sealed class XmlTreeGen // TypeDefIndex: 4567
{
	// Fields
	private ArrayList _constraintNames; // 0x10
	private Hashtable _namespaces; // 0x18
	private Hashtable _autogenerated; // 0x20
	private Hashtable _prefixes; // 0x28
	private DataSet _ds; // 0x30
	private ArrayList _tables; // 0x38
	private ArrayList _relations; // 0x40
	private XmlDocument _dc; // 0x48
	private XmlElement _sRoot; // 0x50
	private int _prefixCount; // 0x58
	private SchemaFormat _schFormat; // 0x5C
	private string _filePath; // 0x60
	private string _fileName; // 0x68
	private string _fileExt; // 0x70
	private XmlElement _dsElement; // 0x78
	private XmlElement _constraintSeparator; // 0x80
	private Converter<Type, string> _targetConverter; // 0x88

	// Methods

	// RVA: 0x1ABA50C Offset: 0x1AB650C VA: 0x1ABA50C
	internal void .ctor(SchemaFormat format) { }

	// RVA: 0x1ABA5B8 Offset: 0x1AB65B8 VA: 0x1ABA5B8
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node) { }

	// RVA: 0x1ABA5C0 Offset: 0x1AB65C0 VA: 0x1ABA5C0
	internal static void AddExtendedProperties(PropertyCollection props, XmlElement node, Type type) { }

	// RVA: 0x1ABAC98 Offset: 0x1AB6C98 VA: 0x1ABAC98
	internal void AddXdoProperties(object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x1ABAE48 Offset: 0x1AB6E48 VA: 0x1ABAE48
	internal void AddXdoProperty(PropertyDescriptor pd, object instance, XmlElement root, XmlDocument xd) { }

	// RVA: 0x1ABB6DC Offset: 0x1AB76DC VA: 0x1ABB6DC
	internal static string XmlDataTypeName(Type type) { }

	// RVA: 0x1ABC49C Offset: 0x1AB849C VA: 0x1ABC49C
	private void GenerateConstraintNames(DataTable table, bool fromTable) { }

	// RVA: 0x1ABC960 Offset: 0x1AB8960 VA: 0x1ABC960
	private void GenerateConstraintNames(ArrayList tables) { }

	// RVA: 0x1ABCA58 Offset: 0x1AB8A58 VA: 0x1ABCA58
	private void GenerateConstraintNames(DataSet ds) { }

	// RVA: 0x1ABCD04 Offset: 0x1AB8D04 VA: 0x1ABCD04
	private static bool _PropsNotEmpty(PropertyCollection props) { }

	// RVA: 0x1ABCD2C Offset: 0x1AB8D2C VA: 0x1ABCD2C
	private bool HaveExtendedProperties(DataSet ds) { }

	// RVA: 0x1ABCEB0 Offset: 0x1AB8EB0 VA: 0x1ABCEB0
	internal void WriteSchemaRoot(XmlDocument xd, XmlElement rootSchema, string targetNamespace) { }

	// RVA: 0x1ABD114 Offset: 0x1AB9114 VA: 0x1ABD114
	internal static void ValidateColumnMapping(Type columnType) { }

	// RVA: 0x1ABD19C Offset: 0x1AB919C VA: 0x1ABD19C
	internal void SetupAutoGenerated(DataSet ds) { }

	// RVA: 0x1ABDE14 Offset: 0x1AB9E14 VA: 0x1ABDE14
	internal void SetupAutoGenerated(ArrayList dt) { }

	// RVA: 0x1ABD444 Offset: 0x1AB9444 VA: 0x1ABD444
	internal void SetupAutoGenerated(DataTable dt) { }

	// RVA: 0x1ABE4E4 Offset: 0x1ABA4E4 VA: 0x1ABE4E4
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1ABE830 Offset: 0x1ABA830 VA: 0x1ABE830
	private void CreateRelations(DataTable dt) { }

	// RVA: 0x1ABEB58 Offset: 0x1ABAB58 VA: 0x1ABEB58
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x1ABEE48 Offset: 0x1ABAE48 VA: 0x1ABEE48
	internal void SchemaTree(XmlDocument xd, XmlWriter xmlWriter, DataSet ds, DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1AC2490 Offset: 0x1ABE490 VA: 0x1AC2490
	internal XmlElement SchemaTree(XmlDocument xd, DataTable dt) { }

	// RVA: 0x1AC17EC Offset: 0x1ABD7EC VA: 0x1AC17EC
	internal XmlElement FillDataSetElement(XmlDocument xd, DataSet ds, DataTable dt) { }

	// RVA: 0x1AC526C Offset: 0x1AC126C VA: 0x1AC526C
	internal void SetPath(XmlWriter xw) { }

	// RVA: 0x1AC54A4 Offset: 0x1AC14A4 VA: 0x1AC54A4
	internal void Save(DataSet ds, XmlWriter xw) { }

	// RVA: 0x1AC54C4 Offset: 0x1AC14C4 VA: 0x1AC54C4
	internal void Save(DataTable dt, XmlWriter xw) { }

	// RVA: 0x1AC54B8 Offset: 0x1AC14B8 VA: 0x1AC54B8
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw) { }

	// RVA: 0x1AC5584 Offset: 0x1AC1584 VA: 0x1AC5584
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy) { }

	// RVA: 0x1AC558C Offset: 0x1AC158C VA: 0x1AC558C
	internal void Save(DataSet ds, DataTable dt, XmlWriter xw, bool writeHierarchy, Converter<Type, string> multipleTargetConverter) { }

	// RVA: 0x1AC1ECC Offset: 0x1ABDECC VA: 0x1AC1ECC
	internal XmlElement HandleRelation(DataRelation rel, XmlDocument dc) { }

	// RVA: 0x1AC56EC Offset: 0x1AC16EC VA: 0x1AC56EC
	private static XmlElement FindSimpleType(XmlElement schema, string name) { }

	// RVA: 0x1AC57E0 Offset: 0x1AC17E0 VA: 0x1AC57E0
	internal XmlElement GetSchema(string NamespaceURI) { }

	// RVA: 0x1AC5A74 Offset: 0x1AC1A74 VA: 0x1AC5A74
	internal void HandleColumnType(DataColumn col, XmlDocument dc, XmlElement root, XmlElement schema) { }

	// RVA: 0x1AC5EC4 Offset: 0x1AC1EC4 VA: 0x1AC5EC4
	internal void AddColumnProperties(DataColumn col, XmlElement root) { }

	// RVA: 0x1AC64B0 Offset: 0x1AC24B0 VA: 0x1AC64B0
	private string FindTargetNamespace(DataTable table) { }

	// RVA: 0x1AC65C0 Offset: 0x1AC25C0 VA: 0x1AC65C0
	internal XmlElement HandleColumn(DataColumn col, XmlDocument dc, XmlElement schema, bool fWriteOrdinal) { }

	// RVA: 0x1AC7220 Offset: 0x1AC3220 VA: 0x1AC7220
	internal static string TranslateAcceptRejectRule(AcceptRejectRule rule) { }

	// RVA: 0x1AC7290 Offset: 0x1AC3290 VA: 0x1AC7290
	internal static string TranslateRule(Rule rule) { }

	// RVA: 0x1AC1E14 Offset: 0x1ABDE14 VA: 0x1AC1E14
	internal void AppendChildWithoutRef(XmlElement node, string Namespace, XmlElement el, string refString) { }

	// RVA: 0x1AC7058 Offset: 0x1AC3058 VA: 0x1AC7058
	internal XmlElement FindTypeNode(XmlElement node, string strType) { }

	// RVA: 0x1AC1E0C Offset: 0x1ABDE0C VA: 0x1AC1E0C
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema) { }

	// RVA: 0x1AC7344 Offset: 0x1AC3344 VA: 0x1AC7344
	private bool HasMixedColumns(DataTable table) { }

	// RVA: 0x1ABDF08 Offset: 0x1AB9F08 VA: 0x1ABDF08
	internal static bool AutoGenerated(DataColumn col) { }

	// RVA: 0x1AC76B4 Offset: 0x1AC36B4 VA: 0x1AC76B4
	internal static bool AutoGenerated(DataRelation rel) { }

	// RVA: 0x1ABE410 Offset: 0x1ABA410 VA: 0x1ABE410
	internal static bool AutoGenerated(UniqueConstraint unique) { }

	// RVA: 0x1ABE404 Offset: 0x1ABA404 VA: 0x1ABE404
	private bool AutoGenerated(ForeignKeyConstraint fk) { }

	// RVA: 0x1AC7798 Offset: 0x1AC3798 VA: 0x1AC7798
	internal static bool AutoGenerated(ForeignKeyConstraint fk, bool checkRelation) { }

	// RVA: 0x1AC78D8 Offset: 0x1AC38D8 VA: 0x1AC78D8
	private bool IsAutoGenerated(object o) { }

	// RVA: 0x1AC295C Offset: 0x1ABE95C VA: 0x1AC295C
	internal XmlElement HandleTable(DataTable table, XmlDocument dc, XmlElement schema, bool genNested) { }

	// RVA: 0x1ABC280 Offset: 0x1AB8280 VA: 0x1ABC280
	private void SetMSDataAttribute(XmlElement root, Type type) { }
}

// Namespace: System.Data
internal sealed class NewDiffgramGen // TypeDefIndex: 4568
{
	// Fields
	internal XmlDocument _doc; // 0x10
	internal DataSet _ds; // 0x18
	internal DataTable _dt; // 0x20
	internal XmlWriter _xmlw; // 0x28
	private bool _fBefore; // 0x30
	private bool _fErrors; // 0x31
	internal Hashtable _rowsOrder; // 0x38
	private ArrayList _tables; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0x1AC7984 Offset: 0x1AC3984 VA: 0x1AC7984
	internal void .ctor(DataSet ds) { }

	// RVA: 0x1AC7D30 Offset: 0x1AC3D30 VA: 0x1AC7D30
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1AC7E54 Offset: 0x1AC3E54 VA: 0x1AC7E54
	private void CreateTableHierarchy(DataTable dt) { }

	// RVA: 0x1AC7ACC Offset: 0x1AC3ACC VA: 0x1AC7ACC
	private void DoAssignments(ArrayList tables) { }

	// RVA: 0x1AC81A0 Offset: 0x1AC41A0 VA: 0x1AC81A0
	private bool EmptyData() { }

	// RVA: 0x1AC8294 Offset: 0x1AC4294 VA: 0x1AC8294
	internal void Save(XmlWriter xmlw) { }

	// RVA: 0x1AC829C Offset: 0x1AC429C VA: 0x1AC829C
	internal void Save(XmlWriter xmlw, DataTable table) { }

	// RVA: 0x1AC86A8 Offset: 0x1AC46A8 VA: 0x1AC86A8
	private void GenerateTable(DataTable table) { }

	// RVA: 0x1AC8724 Offset: 0x1AC4724 VA: 0x1AC8724
	private void GenerateTableErrors(DataTable table) { }

	// RVA: 0x1AC8C8C Offset: 0x1AC4C8C VA: 0x1AC8C8C
	private void GenerateRow(DataRow row) { }

	// RVA: 0x1AC9220 Offset: 0x1AC5220 VA: 0x1AC9220
	private void GenerateColumn(DataRow row, DataColumn col, DataRowVersion version) { }

	// RVA: 0x1AC791C Offset: 0x1AC391C VA: 0x1AC791C
	internal static string QualifiedName(string prefix, string name) { }
}

// Namespace: System.Data
internal sealed class XmlDataTreeWriter // TypeDefIndex: 4569
{
	// Fields
	private XmlWriter _xmlw; // 0x10
	private DataSet _ds; // 0x18
	private DataTable _dt; // 0x20
	private ArrayList _dTables; // 0x28
	private DataTable[] _topLevelTables; // 0x30
	private bool _fFromTable; // 0x38
	private bool _isDiffgram; // 0x39
	private Hashtable _rowsOrder; // 0x40
	private bool _writeHierarchy; // 0x48

	// Methods

	// RVA: 0x1AC9BD4 Offset: 0x1AC5BD4 VA: 0x1AC9BD4
	internal void .ctor(DataSet ds) { }

	// RVA: 0x1AC9F08 Offset: 0x1AC5F08 VA: 0x1AC9F08
	internal void .ctor(DataTable dt, bool writeHierarchy) { }

	// RVA: 0x1ACA3EC Offset: 0x1AC63EC VA: 0x1ACA3EC
	private DataTable[] CreateToplevelTables() { }

	// RVA: 0x1ACA0A0 Offset: 0x1AC60A0 VA: 0x1ACA0A0
	private void CreateTablesHierarchy(DataTable dt) { }

	// RVA: 0x1ACA6DC Offset: 0x1AC66DC VA: 0x1ACA6DC
	internal static bool RowHasErrors(DataRow row) { }

	// RVA: 0x1ACA7A4 Offset: 0x1AC67A4 VA: 0x1ACA7A4
	internal void SaveDiffgramData(XmlWriter xw, Hashtable rowsOrder) { }

	// RVA: 0x1ACC670 Offset: 0x1AC8670 VA: 0x1ACC670
	internal void Save(XmlWriter xw, bool writeSchema) { }

	// RVA: 0x1ACCEF8 Offset: 0x1AC8EF8 VA: 0x1ACCEF8
	private ArrayList GetNestedChildRelations(DataRow row) { }

	// RVA: 0x1ACAEA0 Offset: 0x1AC6EA0 VA: 0x1ACAEA0
	internal void XmlDataRowWriter(DataRow row, string encodedTableName) { }

	// RVA: 0x1ACD20C Offset: 0x1AC920C VA: 0x1ACD20C
	internal static bool PreserveSpace(object value) { }
}

// Namespace: System.Data
internal sealed class DataTextWriter : XmlWriter // TypeDefIndex: 4570
{
	// Fields
	private XmlWriter _xmltextWriter; // 0x18

	// Properties
	internal Stream BaseStream { get; }
	public override WriteState WriteState { get; }

	// Methods

	// RVA: 0x1ACAE38 Offset: 0x1AC6E38 VA: 0x1ACAE38
	internal static XmlWriter CreateWriter(XmlWriter xw) { }

	// RVA: 0x1ACD2A0 Offset: 0x1AC92A0 VA: 0x1ACD2A0
	private void .ctor(XmlWriter w) { }

	// RVA: 0x1ACD2D0 Offset: 0x1AC92D0 VA: 0x1ACD2D0
	internal Stream get_BaseStream() { }

	// RVA: 0x1ACD358 Offset: 0x1AC9358 VA: 0x1ACD358 Slot: 5
	public override void WriteStartDocument() { }

	// RVA: 0x1ACD374 Offset: 0x1AC9374 VA: 0x1ACD374 Slot: 6
	public override void WriteStartDocument(bool standalone) { }

	// RVA: 0x1ACD394 Offset: 0x1AC9394 VA: 0x1ACD394 Slot: 7
	public override void WriteEndDocument() { }

	// RVA: 0x1ACD3B0 Offset: 0x1AC93B0 VA: 0x1ACD3B0 Slot: 8
	public override void WriteDocType(string name, string pubid, string sysid, string subset) { }

	// RVA: 0x1ACD3CC Offset: 0x1AC93CC VA: 0x1ACD3CC Slot: 9
	public override void WriteStartElement(string prefix, string localName, string ns) { }

	// RVA: 0x1ACD3E8 Offset: 0x1AC93E8 VA: 0x1ACD3E8 Slot: 10
	public override void WriteEndElement() { }

	// RVA: 0x1ACD404 Offset: 0x1AC9404 VA: 0x1ACD404 Slot: 11
	public override void WriteFullEndElement() { }

	// RVA: 0x1ACD420 Offset: 0x1AC9420 VA: 0x1ACD420 Slot: 12
	public override void WriteStartAttribute(string prefix, string localName, string ns) { }

	// RVA: 0x1ACD43C Offset: 0x1AC943C VA: 0x1ACD43C Slot: 13
	public override void WriteEndAttribute() { }

	// RVA: 0x1ACD45C Offset: 0x1AC945C VA: 0x1ACD45C Slot: 14
	public override void WriteCData(string text) { }

	// RVA: 0x1ACD47C Offset: 0x1AC947C VA: 0x1ACD47C Slot: 15
	public override void WriteComment(string text) { }

	// RVA: 0x1ACD49C Offset: 0x1AC949C VA: 0x1ACD49C Slot: 16
	public override void WriteProcessingInstruction(string name, string text) { }

	// RVA: 0x1ACD4BC Offset: 0x1AC94BC VA: 0x1ACD4BC Slot: 17
	public override void WriteEntityRef(string name) { }

	// RVA: 0x1ACD4DC Offset: 0x1AC94DC VA: 0x1ACD4DC Slot: 18
	public override void WriteCharEntity(char ch) { }

	// RVA: 0x1ACD4FC Offset: 0x1AC94FC VA: 0x1ACD4FC Slot: 19
	public override void WriteWhitespace(string ws) { }

	// RVA: 0x1ACD51C Offset: 0x1AC951C VA: 0x1ACD51C Slot: 20
	public override void WriteString(string text) { }

	// RVA: 0x1ACD53C Offset: 0x1AC953C VA: 0x1ACD53C Slot: 21
	public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }

	// RVA: 0x1ACD55C Offset: 0x1AC955C VA: 0x1ACD55C Slot: 22
	public override void WriteChars(char[] buffer, int index, int count) { }

	// RVA: 0x1ACD57C Offset: 0x1AC957C VA: 0x1ACD57C Slot: 23
	public override void WriteRaw(char[] buffer, int index, int count) { }

	// RVA: 0x1ACD59C Offset: 0x1AC959C VA: 0x1ACD59C Slot: 24
	public override void WriteRaw(string data) { }

	// RVA: 0x1ACD5BC Offset: 0x1AC95BC VA: 0x1ACD5BC Slot: 25
	public override void WriteBase64(byte[] buffer, int index, int count) { }

	// RVA: 0x1ACD5DC Offset: 0x1AC95DC VA: 0x1ACD5DC Slot: 26
	public override void WriteBinHex(byte[] buffer, int index, int count) { }

	// RVA: 0x1ACD5FC Offset: 0x1AC95FC VA: 0x1ACD5FC Slot: 27
	public override WriteState get_WriteState() { }

	// RVA: 0x1ACD61C Offset: 0x1AC961C VA: 0x1ACD61C Slot: 28
	public override void Close() { }

	// RVA: 0x1ACD63C Offset: 0x1AC963C VA: 0x1ACD63C Slot: 29
	public override void Flush() { }

	// RVA: 0x1ACD65C Offset: 0x1AC965C VA: 0x1ACD65C Slot: 30
	public override string LookupPrefix(string ns) { }
}

// Namespace: System.Data
internal sealed class DataTextReader : XmlReader // TypeDefIndex: 4571
{
	// Fields
	private XmlReader _xmlreader; // 0x10

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
	public override bool CanResolveEntity { get; }
	public override bool CanReadValueChunk { get; }

	// Methods

	// RVA: 0x1ACD67C Offset: 0x1AC967C VA: 0x1ACD67C
	internal static XmlReader CreateReader(XmlReader xr) { }

	// RVA: 0x1ACD6D4 Offset: 0x1AC96D4 VA: 0x1ACD6D4
	private void .ctor(XmlReader input) { }

	// RVA: 0x1ACD748 Offset: 0x1AC9748 VA: 0x1ACD748 Slot: 5
	public override XmlReaderSettings get_Settings() { }

	// RVA: 0x1ACD764 Offset: 0x1AC9764 VA: 0x1ACD764 Slot: 6
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1ACD780 Offset: 0x1AC9780 VA: 0x1ACD780 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1ACD79C Offset: 0x1AC979C VA: 0x1ACD79C Slot: 8
	public override string get_LocalName() { }

	// RVA: 0x1ACD7B8 Offset: 0x1AC97B8 VA: 0x1ACD7B8 Slot: 9
	public override string get_NamespaceURI() { }

	// RVA: 0x1ACD7D4 Offset: 0x1AC97D4 VA: 0x1ACD7D4 Slot: 10
	public override string get_Prefix() { }

	// RVA: 0x1ACD7F0 Offset: 0x1AC97F0 VA: 0x1ACD7F0 Slot: 11
	public override string get_Value() { }

	// RVA: 0x1ACD80C Offset: 0x1AC980C VA: 0x1ACD80C Slot: 12
	public override int get_Depth() { }

	// RVA: 0x1ACD828 Offset: 0x1AC9828 VA: 0x1ACD828 Slot: 13
	public override string get_BaseURI() { }

	// RVA: 0x1ACD848 Offset: 0x1AC9848 VA: 0x1ACD848 Slot: 14
	public override bool get_IsEmptyElement() { }

	// RVA: 0x1ACD868 Offset: 0x1AC9868 VA: 0x1ACD868 Slot: 15
	public override bool get_IsDefault() { }

	// RVA: 0x1ACD888 Offset: 0x1AC9888 VA: 0x1ACD888 Slot: 16
	public override char get_QuoteChar() { }

	// RVA: 0x1ACD8A8 Offset: 0x1AC98A8 VA: 0x1ACD8A8 Slot: 17
	public override XmlSpace get_XmlSpace() { }

	// RVA: 0x1ACD8C8 Offset: 0x1AC98C8 VA: 0x1ACD8C8 Slot: 18
	public override string get_XmlLang() { }

	// RVA: 0x1ACD8E8 Offset: 0x1AC98E8 VA: 0x1ACD8E8 Slot: 21
	public override int get_AttributeCount() { }

	// RVA: 0x1ACD908 Offset: 0x1AC9908 VA: 0x1ACD908 Slot: 22
	public override string GetAttribute(string name) { }

	// RVA: 0x1ACD928 Offset: 0x1AC9928 VA: 0x1ACD928 Slot: 23
	public override string GetAttribute(string localName, string namespaceURI) { }

	// RVA: 0x1ACD948 Offset: 0x1AC9948 VA: 0x1ACD948 Slot: 24
	public override string GetAttribute(int i) { }

	// RVA: 0x1ACD968 Offset: 0x1AC9968 VA: 0x1ACD968 Slot: 25
	public override bool MoveToAttribute(string name) { }

	// RVA: 0x1ACD988 Offset: 0x1AC9988 VA: 0x1ACD988 Slot: 26
	public override void MoveToAttribute(int i) { }

	// RVA: 0x1ACD9A8 Offset: 0x1AC99A8 VA: 0x1ACD9A8 Slot: 27
	public override bool MoveToFirstAttribute() { }

	// RVA: 0x1ACD9C8 Offset: 0x1AC99C8 VA: 0x1ACD9C8 Slot: 28
	public override bool MoveToNextAttribute() { }

	// RVA: 0x1ACD9E8 Offset: 0x1AC99E8 VA: 0x1ACD9E8 Slot: 29
	public override bool MoveToElement() { }

	// RVA: 0x1ACDA08 Offset: 0x1AC9A08 VA: 0x1ACDA08 Slot: 30
	public override bool ReadAttributeValue() { }

	// RVA: 0x1ACDA28 Offset: 0x1AC9A28 VA: 0x1ACDA28 Slot: 31
	public override bool Read() { }

	// RVA: 0x1ACDA48 Offset: 0x1AC9A48 VA: 0x1ACDA48 Slot: 32
	public override bool get_EOF() { }

	// RVA: 0x1ACDA68 Offset: 0x1AC9A68 VA: 0x1ACDA68 Slot: 33
	public override void Close() { }

	// RVA: 0x1ACDA88 Offset: 0x1AC9A88 VA: 0x1ACDA88 Slot: 34
	public override ReadState get_ReadState() { }

	// RVA: 0x1ACDAA8 Offset: 0x1AC9AA8 VA: 0x1ACDAA8 Slot: 35
	public override void Skip() { }

	// RVA: 0x1ACDAC8 Offset: 0x1AC9AC8 VA: 0x1ACDAC8 Slot: 36
	public override XmlNameTable get_NameTable() { }

	// RVA: 0x1ACDAE8 Offset: 0x1AC9AE8 VA: 0x1ACDAE8 Slot: 37
	public override string LookupNamespace(string prefix) { }

	// RVA: 0x1ACDB08 Offset: 0x1AC9B08 VA: 0x1ACDB08 Slot: 38
	public override bool get_CanResolveEntity() { }

	// RVA: 0x1ACDB28 Offset: 0x1AC9B28 VA: 0x1ACDB28 Slot: 39
	public override void ResolveEntity() { }

	// RVA: 0x1ACDB48 Offset: 0x1AC9B48 VA: 0x1ACDB48 Slot: 40
	public override bool get_CanReadValueChunk() { }

	// RVA: 0x1ACDB68 Offset: 0x1AC9B68 VA: 0x1ACDB68 Slot: 42
	public override string ReadString() { }
}
