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

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class BinaryConverter : JsonConverter // TypeDefIndex: 6225
{
	// Fields
	private const string BinaryTypeName = "System.Data.Linq.Binary";
	private const string BinaryToArrayName = "ToArray";
	[Nullable(2)]
	private static ReflectionObject _reflectionObject; // 0x0

	// Methods

	// RVA: 0x1989D4C Offset: 0x1985D4C VA: 0x1989D4C Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1989DA0 Offset: 0x1985DA0 VA: 0x1989DA0
	private byte[] GetByteArray(object value) { }

	// RVA: 0x1989F8C Offset: 0x1985F8C VA: 0x1989F8C
	private static void EnsureReflectionObject(Type t) { }

	// RVA: 0x198A140 Offset: 0x1986140 VA: 0x198A140 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x198A52C Offset: 0x198652C VA: 0x198A52C
	private byte[] ReadByteArray(JsonReader reader) { }

	// RVA: 0x198A7B8 Offset: 0x19867B8 VA: 0x198A7B8 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x198A8C4 Offset: 0x19868C4 VA: 0x198A8C4
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class BsonObjectIdConverter : JsonConverter // TypeDefIndex: 6226
{
	// Methods

	// RVA: 0x198A8CC Offset: 0x19868CC VA: 0x198A8CC Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x198A9C0 Offset: 0x19869C0 VA: 0x198A9C0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x198AB44 Offset: 0x1986B44 VA: 0x198AB44 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x198ABB8 Offset: 0x1986BB8 VA: 0x198ABB8
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public abstract class CustomCreationConverter<T> : JsonConverter // TypeDefIndex: 6227
{
	// Properties
	public override bool CanWrite { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1578680 Offset: 0x1574680 VA: 0x1578680
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.WriteJson
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15786C8 Offset: 0x15746C8 VA: 0x15786C8
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.ReadJson
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public abstract T Create(Type objectType);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.Create
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override bool CanConvert(Type objectType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15788C4 Offset: 0x15748C4 VA: 0x15788C4
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.CanConvert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override bool get_CanWrite() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1578924 Offset: 0x1574924 VA: 0x1578924
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>.get_CanWrite
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157892C Offset: 0x157492C VA: 0x157892C
	|-CustomCreationConverter<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class DataSetConverter : JsonConverter // TypeDefIndex: 6228
{
	// Methods

	// RVA: 0x198ABC0 Offset: 0x1986BC0 VA: 0x198ABC0 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x198B028 Offset: 0x1987028 VA: 0x198B028 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x198B2E8 Offset: 0x19872E8 VA: 0x198B2E8 Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x198B368 Offset: 0x1987368 VA: 0x198B368
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class DataTableConverter : JsonConverter // TypeDefIndex: 6229
{
	// Methods

	// RVA: 0x198B370 Offset: 0x1987370 VA: 0x198B370 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x198BAC8 Offset: 0x1987AC8 VA: 0x198BAC8 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x198BD94 Offset: 0x1987D94 VA: 0x198BD94
	private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer) { }

	// RVA: 0x198C298 Offset: 0x1988298 VA: 0x198C298
	private static Type GetColumnDataType(JsonReader reader) { }

	// RVA: 0x198C458 Offset: 0x1988458 VA: 0x198C458 Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x198B020 Offset: 0x1987020 VA: 0x198B020
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
public abstract class DateTimeConverterBase : JsonConverter // TypeDefIndex: 6230
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x198C4D8 Offset: 0x19884D8 VA: 0x198C4D8 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x198C634 Offset: 0x1988634 VA: 0x198C634
	protected void .ctor() { }
}

// Namespace: 
[Nullable(0)]
internal class DiscriminatedUnionConverter.Union // TypeDefIndex: 6231
{
	// Fields
	public readonly FSharpFunction TagReader; // 0x10
	public readonly List<DiscriminatedUnionConverter.UnionCase> Cases; // 0x18

	// Methods

	// RVA: 0x198CFFC Offset: 0x1988FFC VA: 0x198CFFC
	public void .ctor(FSharpFunction tagReader, List<DiscriminatedUnionConverter.UnionCase> cases) { }
}

// Namespace: 
[Nullable(0)]
internal class DiscriminatedUnionConverter.UnionCase // TypeDefIndex: 6232
{
	// Fields
	public readonly int Tag; // 0x10
	public readonly string Name; // 0x18
	public readonly PropertyInfo[] Fields; // 0x20
	public readonly FSharpFunction FieldReader; // 0x28
	public readonly FSharpFunction Constructor; // 0x30

	// Methods

	// RVA: 0x198D040 Offset: 0x1989040 VA: 0x198D040
	public void .ctor(int tag, string name, PropertyInfo[] fields, FSharpFunction fieldReader, FSharpFunction constructor) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DiscriminatedUnionConverter.<>c__DisplayClass8_0 // TypeDefIndex: 6233
{
	// Fields
	public int tag; // 0x10

	// Methods

	// RVA: 0x198D57C Offset: 0x198957C VA: 0x198D57C
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x198E01C Offset: 0x198A01C VA: 0x198E01C
	internal bool <WriteJson>b__0(DiscriminatedUnionConverter.UnionCase c) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DiscriminatedUnionConverter.<>c__DisplayClass9_0 // TypeDefIndex: 6234
{
	// Fields
	[Nullable(0)]
	public string caseName; // 0x10
	[Nullable(0)]
	public Func<DiscriminatedUnionConverter.UnionCase, bool> <>9__0; // 0x18

	// Methods

	// RVA: 0x198DBF8 Offset: 0x1989BF8 VA: 0x198DBF8
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x198E03C Offset: 0x198A03C VA: 0x198E03C
	internal bool <ReadJson>b__0(DiscriminatedUnionConverter.UnionCase c) { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class DiscriminatedUnionConverter : JsonConverter // TypeDefIndex: 6235
{
	// Fields
	private const string CasePropertyName = "Case";
	private const string FieldsPropertyName = "Fields";
	private static readonly ThreadSafeStore<Type, DiscriminatedUnionConverter.Union> UnionCache; // 0x0
	private static readonly ThreadSafeStore<Type, Type> UnionTypeLookupCache; // 0x8

	// Methods

	// RVA: 0x198C63C Offset: 0x198863C VA: 0x198C63C
	private static Type CreateUnionTypeLookup(Type t) { }

	// RVA: 0x198C83C Offset: 0x198883C VA: 0x198C83C
	private static DiscriminatedUnionConverter.Union CreateUnion(Type t) { }

	// RVA: 0x198D0C4 Offset: 0x19890C4 VA: 0x198D0C4 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x198D584 Offset: 0x1989584 VA: 0x198D584 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x198DC00 Offset: 0x1989C00 VA: 0x198DC00 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x198DE84 Offset: 0x1989E84 VA: 0x198DE84
	public void .ctor() { }

	// RVA: 0x198DE8C Offset: 0x1989E8C VA: 0x198DE8C
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class EntityKeyMemberConverter : JsonConverter // TypeDefIndex: 6236
{
	// Fields
	private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";
	private const string KeyPropertyName = "Key";
	private const string TypePropertyName = "Type";
	private const string ValuePropertyName = "Value";
	[Nullable(2)]
	private static ReflectionObject _reflectionObject; // 0x0

	// Methods

	// RVA: 0x198E05C Offset: 0x198A05C VA: 0x198E05C Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x198E4D4 Offset: 0x198A4D4 VA: 0x198E4D4
	private static void ReadAndAssertProperty(JsonReader reader, string propertyName) { }

	// RVA: 0x198E5C0 Offset: 0x198A5C0 VA: 0x198E5C0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x198E3B4 Offset: 0x198A3B4 VA: 0x198E3B4
	private static void EnsureReflectionObject(Type objectType) { }

	// RVA: 0x198E874 Offset: 0x198A874 VA: 0x198E874 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x198E8C4 Offset: 0x198A8C4 VA: 0x198E8C4
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class ExpandoObjectConverter : JsonConverter // TypeDefIndex: 6237
{
	// Properties
	public override bool CanWrite { get; }

	// Methods

	// RVA: 0x198E8CC Offset: 0x198A8CC VA: 0x198E8CC Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x198E8D0 Offset: 0x198A8D0 VA: 0x198E8D0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x198E8D4 Offset: 0x198A8D4 VA: 0x198E8D4
	private object ReadValue(JsonReader reader) { }

	// RVA: 0x198EBEC Offset: 0x198ABEC VA: 0x198EBEC
	private object ReadList(JsonReader reader) { }

	// RVA: 0x198EA30 Offset: 0x198AA30 VA: 0x198EA30
	private object ReadObject(JsonReader reader) { }

	// RVA: 0x198ED74 Offset: 0x198AD74 VA: 0x198ED74 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x198EDE8 Offset: 0x198ADE8 VA: 0x198EDE8 Slot: 8
	public override bool get_CanWrite() { }

	// RVA: 0x198EDF0 Offset: 0x198ADF0 VA: 0x198EDF0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class IsoDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 6238
{
	// Fields
	private const string DefaultDateTimeFormat = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.FFFFFFFK";
	private DateTimeStyles _dateTimeStyles; // 0x10
	[Nullable(2)]
	private string _dateTimeFormat; // 0x18
	[Nullable(2)]
	private CultureInfo _culture; // 0x20

	// Properties
	public DateTimeStyles DateTimeStyles { get; set; }
	[Nullable(2)]
	public string DateTimeFormat { get; set; }
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0x198EDF8 Offset: 0x198ADF8 VA: 0x198EDF8
	public DateTimeStyles get_DateTimeStyles() { }

	// RVA: 0x198EE00 Offset: 0x198AE00 VA: 0x198EE00
	public void set_DateTimeStyles(DateTimeStyles value) { }

	[NullableContext(2)]
	// RVA: 0x198EE08 Offset: 0x198AE08 VA: 0x198EE08
	public string get_DateTimeFormat() { }

	[NullableContext(2)]
	// RVA: 0x198EE2C Offset: 0x198AE2C VA: 0x198EE2C
	public void set_DateTimeFormat(string value) { }

	// RVA: 0x198EE6C Offset: 0x198AE6C VA: 0x198EE6C
	public CultureInfo get_Culture() { }

	// RVA: 0x198EED4 Offset: 0x198AED4 VA: 0x198EED4
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x198EEDC Offset: 0x198AEDC VA: 0x198EEDC Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x198F144 Offset: 0x198B144 VA: 0x198F144 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x198F650 Offset: 0x198B650 VA: 0x198F650
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class JavaScriptDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 6239
{
	// Methods

	// RVA: 0x198F660 Offset: 0x198B660 VA: 0x198F660 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x198F844 Offset: 0x198B844 VA: 0x198F844 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x198FB68 Offset: 0x198BB68 VA: 0x198FB68
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class KeyValuePairConverter : JsonConverter // TypeDefIndex: 6240
{
	// Fields
	private const string KeyName = "Key";
	private const string ValueName = "Value";
	private static readonly ThreadSafeStore<Type, ReflectionObject> ReflectionObjectPerType; // 0x0

	// Methods

	// RVA: 0x198FB70 Offset: 0x198BB70 VA: 0x198FB70
	private static ReflectionObject InitializeReflectionObject(Type t) { }

	// RVA: 0x198FDEC Offset: 0x198BDEC VA: 0x198FDEC Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x199004C Offset: 0x198C04C VA: 0x199004C Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1990514 Offset: 0x198C514 VA: 0x1990514 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x1990620 Offset: 0x198C620 VA: 0x1990620
	public void .ctor() { }

	// RVA: 0x1990628 Offset: 0x198C628 VA: 0x1990628
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class RegexConverter : JsonConverter // TypeDefIndex: 6241
{
	// Fields
	private const string PatternName = "Pattern";
	private const string OptionsName = "Options";

	// Methods

	// RVA: 0x1990710 Offset: 0x198C710 VA: 0x1990710 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1990B18 Offset: 0x198CB18 VA: 0x1990B18
	private bool HasFlag(RegexOptions options, RegexOptions flag) { }

	// RVA: 0x1990828 Offset: 0x198C828 VA: 0x1990828
	private void WriteBson(BsonWriter writer, Regex regex) { }

	// RVA: 0x199095C Offset: 0x198C95C VA: 0x199095C
	private void WriteJson(JsonWriter writer, Regex regex, JsonSerializer serializer) { }

	// RVA: 0x1990BD4 Offset: 0x198CBD4 VA: 0x1990BD4 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1990EE0 Offset: 0x198CEE0 VA: 0x1990EE0
	private object ReadRegexString(JsonReader reader) { }

	// RVA: 0x1990C80 Offset: 0x198CC80 VA: 0x1990C80
	private Regex ReadRegexObject(JsonReader reader, JsonSerializer serializer) { }

	// RVA: 0x1991038 Offset: 0x198D038 VA: 0x1991038 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x19910B4 Offset: 0x198D0B4 VA: 0x19910B4
	private bool IsRegex(Type objectType) { }

	// RVA: 0x1991128 Offset: 0x198D128 VA: 0x1991128
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class StringEnumConverter : JsonConverter // TypeDefIndex: 6242
{
	// Fields
	[Nullable(2)]
	[CompilerGenerated]
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <AllowIntegerValues>k__BackingField; // 0x18

	// Properties
	[Obsolete("StringEnumConverter.CamelCaseText is obsolete. Set StringEnumConverter.NamingStrategy with CamelCaseNamingStrategy instead.")]
	public bool CamelCaseText { get; set; }
	[Nullable(2)]
	public NamingStrategy NamingStrategy { get; set; }
	public bool AllowIntegerValues { get; set; }

	// Methods

	// RVA: 0x1991130 Offset: 0x198D130 VA: 0x1991130
	public bool get_CamelCaseText() { }

	// RVA: 0x19911AC Offset: 0x198D1AC VA: 0x19911AC
	public void set_CamelCaseText(bool value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1991290 Offset: 0x198D290 VA: 0x1991290
	public NamingStrategy get_NamingStrategy() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1991298 Offset: 0x198D298 VA: 0x1991298
	public void set_NamingStrategy(NamingStrategy value) { }

	[CompilerGenerated]
	// RVA: 0x19912A0 Offset: 0x198D2A0 VA: 0x19912A0
	public bool get_AllowIntegerValues() { }

	[CompilerGenerated]
	// RVA: 0x19912A8 Offset: 0x198D2A8 VA: 0x19912A8
	public void set_AllowIntegerValues(bool value) { }

	// RVA: 0x19912B0 Offset: 0x198D2B0 VA: 0x19912B0
	public void .ctor() { }

	[Obsolete("StringEnumConverter(bool) is obsolete. Create a converter with StringEnumConverter(NamingStrategy, bool) instead.")]
	// RVA: 0x19912C0 Offset: 0x198D2C0 VA: 0x19912C0
	public void .ctor(bool camelCaseText) { }

	// RVA: 0x1991348 Offset: 0x198D348 VA: 0x1991348
	public void .ctor(NamingStrategy namingStrategy, bool allowIntegerValues = True) { }

	// RVA: 0x199138C Offset: 0x198D38C VA: 0x199138C
	public void .ctor(Type namingStrategyType) { }

	// RVA: 0x199143C Offset: 0x198D43C VA: 0x199143C
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters) { }

	// RVA: 0x19914F8 Offset: 0x198D4F8 VA: 0x19914F8
	public void .ctor(Type namingStrategyType, object[] namingStrategyParameters, bool allowIntegerValues) { }

	// RVA: 0x19915C4 Offset: 0x198D5C4 VA: 0x19915C4 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x19917BC Offset: 0x198D7BC VA: 0x19917BC Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1991C44 Offset: 0x198DC44 VA: 0x1991C44 Slot: 6
	public override bool CanConvert(Type objectType) { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class UnixDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 6243
{
	// Fields
	internal static readonly DateTime UnixEpoch; // 0x0
	[CompilerGenerated]
	private bool <AllowPreEpoch>k__BackingField; // 0x10

	// Properties
	public bool AllowPreEpoch { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1991CBC Offset: 0x198DCBC VA: 0x1991CBC
	public bool get_AllowPreEpoch() { }

	[CompilerGenerated]
	// RVA: 0x1991CC4 Offset: 0x198DCC4 VA: 0x1991CC4
	public void set_AllowPreEpoch(bool value) { }

	// RVA: 0x1991CCC Offset: 0x198DCCC VA: 0x1991CCC
	public void .ctor() { }

	// RVA: 0x1991CE8 Offset: 0x198DCE8 VA: 0x1991CE8
	public void .ctor(bool allowPreEpoch) { }

	// RVA: 0x1991D10 Offset: 0x198DD10 VA: 0x1991D10 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1991F7C Offset: 0x198DF7C VA: 0x1991F7C Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x199234C Offset: 0x198E34C VA: 0x199234C
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class VersionConverter : JsonConverter // TypeDefIndex: 6244
{
	// Methods

	// RVA: 0x19923C8 Offset: 0x198E3C8 VA: 0x19923C8 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x19924B0 Offset: 0x198E4B0 VA: 0x19924B0 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x1992728 Offset: 0x198E728 VA: 0x1992728 Slot: 6
	public override bool CanConvert(Type objectType) { }

	// RVA: 0x199279C Offset: 0x198E79C VA: 0x199279C
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XmlDocumentWrapper : XmlNodeWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 6245
{
	// Fields
	private readonly XmlDocument _document; // 0x28

	// Properties
	[Nullable(2)]
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0x19927A4 Offset: 0x198E7A4 VA: 0x19927A4
	public void .ctor(XmlDocument document) { }

	// RVA: 0x1992814 Offset: 0x198E814 VA: 0x1992814 Slot: 15
	public IXmlNode CreateComment(string data) { }

	// RVA: 0x19928A8 Offset: 0x198E8A8 VA: 0x19928A8 Slot: 16
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0x199293C Offset: 0x198E93C VA: 0x199293C Slot: 17
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0x19929D0 Offset: 0x198E9D0 VA: 0x19929D0 Slot: 18
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0x1992A64 Offset: 0x198EA64 VA: 0x1992A64 Slot: 19
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0x1992AF8 Offset: 0x198EAF8 VA: 0x1992AF8 Slot: 20
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(2)]
	// RVA: 0x1992BD4 Offset: 0x198EBD4 VA: 0x1992BD4 Slot: 21
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1992CB4 Offset: 0x198ECB4 VA: 0x1992CB4 Slot: 22
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x1992D58 Offset: 0x198ED58 VA: 0x1992D58 Slot: 23
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0x1992E14 Offset: 0x198EE14 VA: 0x1992E14 Slot: 24
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0x1992EA0 Offset: 0x198EEA0 VA: 0x1992EA0 Slot: 25
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0x1992F70 Offset: 0x198EF70 VA: 0x1992F70 Slot: 26
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	[NullableContext(2)]
	// RVA: 0x199302C Offset: 0x198F02C VA: 0x199302C Slot: 27
	public IXmlElement get_DocumentElement() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XmlElementWrapper : XmlNodeWrapper, IXmlElement, IXmlNode // TypeDefIndex: 6246
{
	// Fields
	private readonly XmlElement _element; // 0x28

	// Properties
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x1992DD4 Offset: 0x198EDD4 VA: 0x1992DD4
	public void .ctor(XmlElement element) { }

	// RVA: 0x19930BC Offset: 0x198F0BC VA: 0x19930BC Slot: 15
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0x19931A4 Offset: 0x198F1A4 VA: 0x19931A4 Slot: 16
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0x19931C4 Offset: 0x198F1C4 VA: 0x19931C4 Slot: 17
	public bool get_IsEmpty() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XmlDeclarationWrapper : XmlNodeWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 6247
{
	// Fields
	[Nullable(1)]
	private readonly XmlDeclaration _declaration; // 0x28

	// Properties
	public string Version { get; }
	public string Encoding { get; }
	public string Standalone { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1992B94 Offset: 0x198EB94 VA: 0x1992B94
	public void .ctor(XmlDeclaration declaration) { }

	// RVA: 0x19931DC Offset: 0x198F1DC VA: 0x19931DC Slot: 15
	public string get_Version() { }

	// RVA: 0x19931F4 Offset: 0x198F1F4 VA: 0x19931F4 Slot: 16
	public string get_Encoding() { }

	// RVA: 0x199320C Offset: 0x198F20C VA: 0x199320C Slot: 17
	public string get_Standalone() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XmlDocumentTypeWrapper : XmlNodeWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 6248
{
	// Fields
	[Nullable(1)]
	private readonly XmlDocumentType _documentType; // 0x28

	// Properties
	[Nullable(1)]
	public string Name { get; }
	public string System { get; }
	public string Public { get; }
	public string InternalSubset { get; }
	public override string LocalName { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1992C74 Offset: 0x198EC74 VA: 0x1992C74
	public void .ctor(XmlDocumentType documentType) { }

	[NullableContext(1)]
	// RVA: 0x1993224 Offset: 0x198F224 VA: 0x1993224 Slot: 15
	public string get_Name() { }

	// RVA: 0x1993240 Offset: 0x198F240 VA: 0x1993240 Slot: 16
	public string get_System() { }

	// RVA: 0x1993258 Offset: 0x198F258 VA: 0x1993258 Slot: 17
	public string get_Public() { }

	// RVA: 0x1993270 Offset: 0x198F270 VA: 0x1993270 Slot: 18
	public string get_InternalSubset() { }

	// RVA: 0x1993288 Offset: 0x198F288 VA: 0x1993288 Slot: 13
	public override string get_LocalName() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XmlNodeWrapper : IXmlNode // TypeDefIndex: 6249
{
	// Fields
	[Nullable(1)]
	private readonly XmlNode _node; // 0x10
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _childNodes; // 0x18
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _attributes; // 0x20

	// Properties
	public object WrappedNode { get; }
	public XmlNodeType NodeType { get; }
	public virtual string LocalName { get; }
	[Nullable(1)]
	public List<IXmlNode> ChildNodes { get; }
	[Nullable(1)]
	public List<IXmlNode> Attributes { get; }
	private bool HasAttributes { get; }
	public IXmlNode ParentNode { get; }
	public string Value { get; set; }
	public string NamespaceUri { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x19927E4 Offset: 0x198E7E4 VA: 0x19927E4
	public void .ctor(XmlNode node) { }

	// RVA: 0x19932C8 Offset: 0x198F2C8 VA: 0x19932C8 Slot: 12
	public object get_WrappedNode() { }

	// RVA: 0x19932D0 Offset: 0x198F2D0 VA: 0x19932D0 Slot: 4
	public XmlNodeType get_NodeType() { }

	// RVA: 0x19932EC Offset: 0x198F2EC VA: 0x19932EC Slot: 13
	public virtual string get_LocalName() { }

	[NullableContext(1)]
	// RVA: 0x199330C Offset: 0x198F30C VA: 0x199330C Slot: 6
	public List<IXmlNode> get_ChildNodes() { }

	[NullableContext(1)]
	// RVA: 0x1993714 Offset: 0x198F714 VA: 0x1993714
	internal static IXmlNode WrapNode(XmlNode node) { }

	[NullableContext(1)]
	// RVA: 0x19938F8 Offset: 0x198F8F8 VA: 0x19938F8 Slot: 7
	public List<IXmlNode> get_Attributes() { }

	// RVA: 0x1993CF8 Offset: 0x198FCF8 VA: 0x1993CF8
	private bool get_HasAttributes() { }

	// RVA: 0x1993DA8 Offset: 0x198FDA8 VA: 0x1993DA8 Slot: 8
	public IXmlNode get_ParentNode() { }

	// RVA: 0x1993E50 Offset: 0x198FE50 VA: 0x1993E50 Slot: 9
	public string get_Value() { }

	// RVA: 0x1992F54 Offset: 0x198EF54 VA: 0x1992F54 Slot: 14
	public void set_Value(string value) { }

	[NullableContext(1)]
	// RVA: 0x1993E6C Offset: 0x198FE6C VA: 0x1993E6C Slot: 10
	public IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0x1993F2C Offset: 0x198FF2C VA: 0x1993F2C Slot: 11
	public string get_NamespaceUri() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
internal interface IXmlDocument : IXmlNode // TypeDefIndex: 6250
{
	// Properties
	[Nullable(2)]
	public abstract IXmlElement DocumentElement { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IXmlNode CreateComment(string text);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IXmlNode CreateTextNode(string text);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IXmlNode CreateCDataSection(string data);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IXmlNode CreateWhitespace(string text);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IXmlNode CreateSignificantWhitespace(string text);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IXmlNode CreateProcessingInstruction(string target, string data);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract IXmlElement CreateElement(string elementName);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IXmlElement CreateElement(string qualifiedName, string namespaceUri);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract IXmlNode CreateAttribute(string name, string value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 12
	public abstract IXmlElement get_DocumentElement();
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
internal interface IXmlDeclaration : IXmlNode // TypeDefIndex: 6251
{
	// Properties
	public abstract string Version { get; }
	public abstract string Encoding { get; }
	public abstract string Standalone { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Version();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Encoding();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Standalone();
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
internal interface IXmlDocumentType : IXmlNode // TypeDefIndex: 6252
{
	// Properties
	[Nullable(1)]
	public abstract string Name { get; }
	public abstract string System { get; }
	public abstract string Public { get; }
	public abstract string InternalSubset { get; }

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_System();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Public();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_InternalSubset();
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
internal interface IXmlElement : IXmlNode // TypeDefIndex: 6253
{
	// Properties
	public abstract bool IsEmpty { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetAttributeNode(IXmlNode attribute);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetPrefixOfNamespace(string namespaceUri);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsEmpty();
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
internal interface IXmlNode // TypeDefIndex: 6254
{
	// Properties
	public abstract XmlNodeType NodeType { get; }
	public abstract string LocalName { get; }
	[Nullable(1)]
	public abstract List<IXmlNode> ChildNodes { get; }
	[Nullable(1)]
	public abstract List<IXmlNode> Attributes { get; }
	public abstract IXmlNode ParentNode { get; }
	public abstract string Value { get; }
	public abstract string NamespaceUri { get; }
	public abstract object WrappedNode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlNodeType get_NodeType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_LocalName();

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract List<IXmlNode> get_ChildNodes();

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract List<IXmlNode> get_Attributes();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract IXmlNode get_ParentNode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Value();

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract IXmlNode AppendChild(IXmlNode newChild);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_NamespaceUri();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object get_WrappedNode();
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XDeclarationWrapper : XObjectWrapper, IXmlDeclaration, IXmlNode // TypeDefIndex: 6255
{
	// Fields
	[Nullable(1)]
	[CompilerGenerated]
	private readonly XDeclaration <Declaration>k__BackingField; // 0x18

	// Properties
	[Nullable(1)]
	internal XDeclaration Declaration { get; }
	public override XmlNodeType NodeType { get; }
	public string Version { get; }
	public string Encoding { get; }
	public string Standalone { get; }

	// Methods

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x1993F4C Offset: 0x198FF4C VA: 0x1993F4C
	internal XDeclaration get_Declaration() { }

	[NullableContext(1)]
	// RVA: 0x1993F54 Offset: 0x198FF54 VA: 0x1993F54
	public void .ctor(XDeclaration declaration) { }

	// RVA: 0x1993FC4 Offset: 0x198FFC4 VA: 0x1993FC4 Slot: 13
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x1993FCC Offset: 0x198FFCC VA: 0x1993FCC Slot: 21
	public string get_Version() { }

	// RVA: 0x1993FE4 Offset: 0x198FFE4 VA: 0x1993FE4 Slot: 22
	public string get_Encoding() { }

	// RVA: 0x1993FFC Offset: 0x198FFFC VA: 0x1993FFC Slot: 23
	public string get_Standalone() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XDocumentTypeWrapper : XObjectWrapper, IXmlDocumentType, IXmlNode // TypeDefIndex: 6256
{
	// Fields
	[Nullable(1)]
	private readonly XDocumentType _documentType; // 0x18

	// Properties
	[Nullable(1)]
	public string Name { get; }
	public string System { get; }
	public string Public { get; }
	public string InternalSubset { get; }
	public override string LocalName { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1994014 Offset: 0x1990014 VA: 0x1994014
	public void .ctor(XDocumentType documentType) { }

	[NullableContext(1)]
	// RVA: 0x1994054 Offset: 0x1990054 VA: 0x1994054 Slot: 21
	public string get_Name() { }

	// RVA: 0x199406C Offset: 0x199006C VA: 0x199406C Slot: 22
	public string get_System() { }

	// RVA: 0x1994084 Offset: 0x1990084 VA: 0x1994084 Slot: 23
	public string get_Public() { }

	// RVA: 0x199409C Offset: 0x199009C VA: 0x199409C Slot: 24
	public string get_InternalSubset() { }

	// RVA: 0x19940B4 Offset: 0x19900B4 VA: 0x19940B4 Slot: 14
	public override string get_LocalName() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XDocumentWrapper : XContainerWrapper, IXmlDocument, IXmlNode // TypeDefIndex: 6257
{
	// Properties
	private XDocument Document { get; }
	public override List<IXmlNode> ChildNodes { get; }
	protected override bool HasChildNodes { get; }
	[Nullable(2)]
	public IXmlElement DocumentElement { get; }

	// Methods

	// RVA: 0x19940F4 Offset: 0x19900F4 VA: 0x19940F4
	private XDocument get_Document() { }

	// RVA: 0x199416C Offset: 0x199016C VA: 0x199416C
	public void .ctor(XDocument document) { }

	// RVA: 0x19941CC Offset: 0x19901CC VA: 0x19941CC Slot: 15
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x1994718 Offset: 0x1990718 VA: 0x1994718 Slot: 21
	protected override bool get_HasChildNodes() { }

	// RVA: 0x199477C Offset: 0x199077C VA: 0x199477C Slot: 22
	public IXmlNode CreateComment(string text) { }

	// RVA: 0x1994818 Offset: 0x1990818 VA: 0x1994818 Slot: 23
	public IXmlNode CreateTextNode(string text) { }

	// RVA: 0x19948B4 Offset: 0x19908B4 VA: 0x19948B4 Slot: 24
	public IXmlNode CreateCDataSection(string data) { }

	// RVA: 0x1994950 Offset: 0x1990950 VA: 0x1994950 Slot: 25
	public IXmlNode CreateWhitespace(string text) { }

	// RVA: 0x19949EC Offset: 0x19909EC VA: 0x19949EC Slot: 26
	public IXmlNode CreateSignificantWhitespace(string text) { }

	// RVA: 0x1994A88 Offset: 0x1990A88 VA: 0x1994A88 Slot: 27
	public IXmlNode CreateXmlDeclaration(string version, string encoding, string standalone) { }

	[NullableContext(2)]
	// RVA: 0x1994B2C Offset: 0x1990B2C VA: 0x1994B2C Slot: 28
	public IXmlNode CreateXmlDocumentType(string name, string publicId, string systemId, string internalSubset) { }

	// RVA: 0x1994BD8 Offset: 0x1990BD8 VA: 0x1994BD8 Slot: 29
	public IXmlNode CreateProcessingInstruction(string target, string data) { }

	// RVA: 0x1994CAC Offset: 0x1990CAC VA: 0x1994CAC Slot: 30
	public IXmlElement CreateElement(string elementName) { }

	// RVA: 0x1994D8C Offset: 0x1990D8C VA: 0x1994D8C Slot: 31
	public IXmlElement CreateElement(string qualifiedName, string namespaceUri) { }

	// RVA: 0x1994E4C Offset: 0x1990E4C VA: 0x1994E4C Slot: 32
	public IXmlNode CreateAttribute(string name, string value) { }

	// RVA: 0x1994F34 Offset: 0x1990F34 VA: 0x1994F34 Slot: 33
	public IXmlNode CreateAttribute(string qualifiedName, string namespaceUri, string value) { }

	[NullableContext(2)]
	// RVA: 0x1995004 Offset: 0x1991004 VA: 0x1995004 Slot: 34
	public IXmlElement get_DocumentElement() { }

	// RVA: 0x19950AC Offset: 0x19910AC VA: 0x19950AC Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XTextWrapper : XObjectWrapper // TypeDefIndex: 6258
{
	// Properties
	[Nullable(1)]
	private XText Text { get; }
	public override string Value { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x199522C Offset: 0x199122C VA: 0x199522C
	private XText get_Text() { }

	[NullableContext(1)]
	// RVA: 0x19952A4 Offset: 0x19912A4 VA: 0x19952A4
	public void .ctor(XText text) { }

	// RVA: 0x19952D4 Offset: 0x19912D4 VA: 0x19952D4 Slot: 18
	public override string get_Value() { }

	// RVA: 0x19952F0 Offset: 0x19912F0 VA: 0x19952F0 Slot: 17
	public override IXmlNode get_ParentNode() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XCommentWrapper : XObjectWrapper // TypeDefIndex: 6259
{
	// Properties
	[Nullable(1)]
	private XComment Text { get; }
	public override string Value { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x199563C Offset: 0x199163C VA: 0x199563C
	private XComment get_Text() { }

	[NullableContext(1)]
	// RVA: 0x19956B4 Offset: 0x19916B4 VA: 0x19956B4
	public void .ctor(XComment text) { }

	// RVA: 0x19956E4 Offset: 0x19916E4 VA: 0x19956E4 Slot: 18
	public override string get_Value() { }

	// RVA: 0x1995700 Offset: 0x1991700 VA: 0x1995700 Slot: 17
	public override IXmlNode get_ParentNode() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XProcessingInstructionWrapper : XObjectWrapper // TypeDefIndex: 6260
{
	// Properties
	[Nullable(1)]
	private XProcessingInstruction ProcessingInstruction { get; }
	public override string LocalName { get; }
	public override string Value { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x1995744 Offset: 0x1991744 VA: 0x1995744
	private XProcessingInstruction get_ProcessingInstruction() { }

	[NullableContext(1)]
	// RVA: 0x1994C7C Offset: 0x1990C7C VA: 0x1994C7C
	public void .ctor(XProcessingInstruction processingInstruction) { }

	// RVA: 0x19957BC Offset: 0x19917BC VA: 0x19957BC Slot: 14
	public override string get_LocalName() { }

	// RVA: 0x19957D8 Offset: 0x19917D8 VA: 0x19957D8 Slot: 18
	public override string get_Value() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XContainerWrapper : XObjectWrapper // TypeDefIndex: 6261
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _childNodes; // 0x18

	// Properties
	private XContainer Container { get; }
	public override List<IXmlNode> ChildNodes { get; }
	protected virtual bool HasChildNodes { get; }
	[Nullable(2)]
	public override IXmlNode ParentNode { get; }

	// Methods

	// RVA: 0x19957F4 Offset: 0x19917F4 VA: 0x19957F4
	private XContainer get_Container() { }

	// RVA: 0x199419C Offset: 0x199019C VA: 0x199419C
	public void .ctor(XContainer container) { }

	// RVA: 0x1994338 Offset: 0x1990338 VA: 0x1994338 Slot: 15
	public override List<IXmlNode> get_ChildNodes() { }

	// RVA: 0x1994754 Offset: 0x1990754 VA: 0x1994754 Slot: 21
	protected virtual bool get_HasChildNodes() { }

	[NullableContext(2)]
	// RVA: 0x199586C Offset: 0x199186C VA: 0x199586C Slot: 17
	public override IXmlNode get_ParentNode() { }

	// RVA: 0x1995334 Offset: 0x1991334 VA: 0x1995334
	internal static IXmlNode WrapNode(XObject node) { }

	// RVA: 0x1995150 Offset: 0x1991150 VA: 0x1995150 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XObjectWrapper : IXmlNode // TypeDefIndex: 6262
{
	// Fields
	private readonly XObject _xmlObject; // 0x10

	// Properties
	public object WrappedNode { get; }
	public virtual XmlNodeType NodeType { get; }
	public virtual string LocalName { get; }
	[Nullable(1)]
	public virtual List<IXmlNode> ChildNodes { get; }
	[Nullable(1)]
	public virtual List<IXmlNode> Attributes { get; }
	public virtual IXmlNode ParentNode { get; }
	public virtual string Value { get; }
	public virtual string NamespaceUri { get; }

	// Methods

	// RVA: 0x1993F94 Offset: 0x198FF94 VA: 0x1993F94
	public void .ctor(XObject xmlObject) { }

	// RVA: 0x19958B0 Offset: 0x19918B0 VA: 0x19958B0 Slot: 12
	public object get_WrappedNode() { }

	// RVA: 0x19958B8 Offset: 0x19918B8 VA: 0x19958B8 Slot: 13
	public virtual XmlNodeType get_NodeType() { }

	// RVA: 0x19958D0 Offset: 0x19918D0 VA: 0x19958D0 Slot: 14
	public virtual string get_LocalName() { }

	[NullableContext(1)]
	// RVA: 0x19958D8 Offset: 0x19918D8 VA: 0x19958D8 Slot: 15
	public virtual List<IXmlNode> get_ChildNodes() { }

	[NullableContext(1)]
	// RVA: 0x1995930 Offset: 0x1991930 VA: 0x1995930 Slot: 16
	public virtual List<IXmlNode> get_Attributes() { }

	// RVA: 0x1995988 Offset: 0x1991988 VA: 0x1995988 Slot: 17
	public virtual IXmlNode get_ParentNode() { }

	// RVA: 0x1995990 Offset: 0x1991990 VA: 0x1995990 Slot: 18
	public virtual string get_Value() { }

	[NullableContext(1)]
	// RVA: 0x1995998 Offset: 0x1991998 VA: 0x1995998 Slot: 19
	public virtual IXmlNode AppendChild(IXmlNode newChild) { }

	// RVA: 0x19959D0 Offset: 0x19919D0 VA: 0x19959D0 Slot: 20
	public virtual string get_NamespaceUri() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(2)]
[Nullable(0)]
internal class XAttributeWrapper : XObjectWrapper // TypeDefIndex: 6263
{
	// Properties
	[Nullable(1)]
	private XAttribute Attribute { get; }
	public override string Value { get; }
	public override string LocalName { get; }
	public override string NamespaceUri { get; }
	public override IXmlNode ParentNode { get; }

	// Methods

	[NullableContext(1)]
	// RVA: 0x19959D8 Offset: 0x19919D8 VA: 0x19959D8
	private XAttribute get_Attribute() { }

	[NullableContext(1)]
	// RVA: 0x1994F04 Offset: 0x1990F04 VA: 0x1994F04
	public void .ctor(XAttribute attribute) { }

	// RVA: 0x1995A50 Offset: 0x1991A50 VA: 0x1995A50 Slot: 18
	public override string get_Value() { }

	// RVA: 0x1995A6C Offset: 0x1991A6C VA: 0x1995A6C Slot: 14
	public override string get_LocalName() { }

	// RVA: 0x1995A90 Offset: 0x1991A90 VA: 0x1995A90 Slot: 20
	public override string get_NamespaceUri() { }

	// RVA: 0x1995AB4 Offset: 0x1991AB4 VA: 0x1995AB4 Slot: 17
	public override IXmlNode get_ParentNode() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
internal class XElementWrapper : XContainerWrapper, IXmlElement, IXmlNode // TypeDefIndex: 6264
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	private List<IXmlNode> _attributes; // 0x20

	// Properties
	private XElement Element { get; }
	public override List<IXmlNode> Attributes { get; }
	[Nullable(2)]
	public override string Value { get; }
	[Nullable(2)]
	public override string LocalName { get; }
	[Nullable(2)]
	public override string NamespaceUri { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x1995AF8 Offset: 0x1991AF8 VA: 0x1995AF8
	private XElement get_Element() { }

	// RVA: 0x1994D5C Offset: 0x1990D5C VA: 0x1994D5C
	public void .ctor(XElement element) { }

	// RVA: 0x1995B70 Offset: 0x1991B70 VA: 0x1995B70 Slot: 22
	public void SetAttributeNode(IXmlNode attribute) { }

	// RVA: 0x1995C1C Offset: 0x1991C1C VA: 0x1995C1C Slot: 16
	public override List<IXmlNode> get_Attributes() { }

	// RVA: 0x1996160 Offset: 0x1992160 VA: 0x1996160
	private bool HasImplicitNamespaceAttribute(string namespaceUri) { }

	// RVA: 0x1996610 Offset: 0x1992610 VA: 0x1996610 Slot: 19
	public override IXmlNode AppendChild(IXmlNode newChild) { }

	[NullableContext(2)]
	// RVA: 0x1996644 Offset: 0x1992644 VA: 0x1996644 Slot: 18
	public override string get_Value() { }

	[NullableContext(2)]
	// RVA: 0x1996660 Offset: 0x1992660 VA: 0x1996660 Slot: 14
	public override string get_LocalName() { }

	[NullableContext(2)]
	// RVA: 0x1996684 Offset: 0x1992684 VA: 0x1996684 Slot: 20
	public override string get_NamespaceUri() { }

	// RVA: 0x19965D0 Offset: 0x19925D0 VA: 0x19965D0 Slot: 23
	public string GetPrefixOfNamespace(string namespaceUri) { }

	// RVA: 0x19966A8 Offset: 0x19926A8 VA: 0x19966A8 Slot: 24
	public bool get_IsEmpty() { }
}

// Namespace: Newtonsoft.Json.Converters
[NullableContext(1)]
[Nullable(0)]
public class XmlNodeConverter : JsonConverter // TypeDefIndex: 6265
{
	// Fields
	internal static readonly List<IXmlNode> EmptyChildNodes; // 0x0
	private const string TextName = "#text";
	private const string CommentName = "#comment";
	private const string CDataName = "#cdata-section";
	private const string WhitespaceName = "#whitespace";
	private const string SignificantWhitespaceName = "#significant-whitespace";
	private const string DeclarationName = "?xml";
	private const string JsonNamespaceUri = "http://james.newtonking.com/projects/json";
	[Nullable(2)]
	[CompilerGenerated]
	private string <DeserializeRootElementName>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <WriteArrayAttribute>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <OmitRootObject>k__BackingField; // 0x19
	[CompilerGenerated]
	private bool <EncodeSpecialCharacters>k__BackingField; // 0x1A

	// Properties
	[Nullable(2)]
	public string DeserializeRootElementName { get; set; }
	public bool WriteArrayAttribute { get; set; }
	public bool OmitRootObject { get; set; }
	public bool EncodeSpecialCharacters { get; set; }

	// Methods

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x19966C4 Offset: 0x19926C4 VA: 0x19966C4
	public string get_DeserializeRootElementName() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x19966CC Offset: 0x19926CC VA: 0x19966CC
	public void set_DeserializeRootElementName(string value) { }

	[CompilerGenerated]
	// RVA: 0x19966D4 Offset: 0x19926D4 VA: 0x19966D4
	public bool get_WriteArrayAttribute() { }

	[CompilerGenerated]
	// RVA: 0x19966DC Offset: 0x19926DC VA: 0x19966DC
	public void set_WriteArrayAttribute(bool value) { }

	[CompilerGenerated]
	// RVA: 0x19966E4 Offset: 0x19926E4 VA: 0x19966E4
	public bool get_OmitRootObject() { }

	[CompilerGenerated]
	// RVA: 0x19966EC Offset: 0x19926EC VA: 0x19966EC
	public void set_OmitRootObject(bool value) { }

	[CompilerGenerated]
	// RVA: 0x19966F4 Offset: 0x19926F4 VA: 0x19966F4
	public bool get_EncodeSpecialCharacters() { }

	[CompilerGenerated]
	// RVA: 0x19966FC Offset: 0x19926FC VA: 0x19966FC
	public void set_EncodeSpecialCharacters(bool value) { }

	// RVA: 0x1996704 Offset: 0x1992704 VA: 0x1996704 Slot: 4
	public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { }

	// RVA: 0x1996850 Offset: 0x1992850 VA: 0x1996850
	private IXmlNode WrapXml(object value) { }

	// RVA: 0x1996968 Offset: 0x1992968 VA: 0x1996968
	private void PushParentNamespaces(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0x19986A8 Offset: 0x19946A8 VA: 0x19986A8
	private string ResolveFullName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0x1998A34 Offset: 0x1994A34 VA: 0x1998A34
	private string GetPropertyName(IXmlNode node, XmlNamespaceManager manager) { }

	// RVA: 0x1998EB8 Offset: 0x1994EB8 VA: 0x1998EB8
	private bool IsArray(IXmlNode node) { }

	// RVA: 0x1999224 Offset: 0x1995224 VA: 0x1999224
	private void SerializeGroupedNodes(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0x1999BD8 Offset: 0x1995BD8 VA: 0x1999BD8
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, List<IXmlNode> groupedNodes, string elementNames) { }

	// RVA: 0x1999D44 Offset: 0x1995D44 VA: 0x1999D44
	private void WriteGroupedNodes(JsonWriter writer, XmlNamespaceManager manager, bool writePropertyName, IXmlNode node, string elementNames) { }

	// RVA: 0x1996FC0 Offset: 0x1992FC0 VA: 0x1996FC0
	private void SerializeNode(JsonWriter writer, IXmlNode node, XmlNamespaceManager manager, bool writePropertyName) { }

	// RVA: 0x1999E14 Offset: 0x1995E14 VA: 0x1999E14
	private static bool AllSameName(IXmlNode node) { }

	// RVA: 0x199A394 Offset: 0x1996394 VA: 0x199A394 Slot: 5
	public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) { }

	// RVA: 0x199B698 Offset: 0x1997698 VA: 0x199B698
	private void DeserializeValue(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, string propertyName, IXmlNode currentNode) { }

	// RVA: 0x199ABE0 Offset: 0x1996BE0 VA: 0x199ABE0
	private void ReadElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, XmlNamespaceManager manager) { }

	// RVA: 0x199D8D0 Offset: 0x19998D0 VA: 0x199D8D0
	private void CreateElement(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string elementName, XmlNamespaceManager manager, string elementPrefix, Dictionary<string, string> attributeNameValues) { }

	// RVA: 0x199D554 Offset: 0x1999554 VA: 0x199D554
	private static void AddAttribute(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName, string attributeName, XmlNamespaceManager manager, string attributePrefix) { }

	// RVA: 0x199BC44 Offset: 0x1997C44 VA: 0x199BC44
	private static string ConvertTokenToXmlValue(JsonReader reader) { }

	// RVA: 0x199CBBC Offset: 0x1998BBC VA: 0x199CBBC
	private void ReadArrayElements(JsonReader reader, IXmlDocument document, string propertyName, IXmlNode currentNode, XmlNamespaceManager manager) { }

	// RVA: 0x199E0E8 Offset: 0x199A0E8 VA: 0x199E0E8
	private void AddJsonArrayAttribute(IXmlElement element, IXmlDocument document) { }

	// RVA: 0x199CF38 Offset: 0x1998F38 VA: 0x199CF38
	private bool ShouldReadInto(JsonReader reader) { }

	// RVA: 0x199CF78 Offset: 0x1998F78 VA: 0x199CF78
	private Dictionary<string, string> ReadAttributeElements(JsonReader reader, XmlNamespaceManager manager) { }

	// RVA: 0x199C34C Offset: 0x199834C VA: 0x199C34C
	private void CreateInstruction(JsonReader reader, IXmlDocument document, IXmlNode currentNode, string propertyName) { }

	// RVA: 0x199C7E4 Offset: 0x19987E4 VA: 0x199C7E4
	private void CreateDocumentType(JsonReader reader, IXmlDocument document, IXmlNode currentNode) { }

	// RVA: 0x199DEFC Offset: 0x1999EFC VA: 0x199DEFC
	private IXmlElement CreateElement(string elementName, IXmlDocument document, string elementPrefix, XmlNamespaceManager manager) { }

	// RVA: 0x199AF28 Offset: 0x1996F28 VA: 0x199AF28
	private void DeserializeNode(JsonReader reader, IXmlDocument document, XmlNamespaceManager manager, IXmlNode currentNode) { }

	// RVA: 0x199E428 Offset: 0x199A428 VA: 0x199E428
	private bool IsNamespaceAttribute(string attributeName, out string prefix) { }

	// RVA: 0x199A0B4 Offset: 0x19960B4 VA: 0x199A0B4
	private bool ValueAttributes(List<IXmlNode> c) { }

	// RVA: 0x199E508 Offset: 0x199A508 VA: 0x199E508 Slot: 6
	public override bool CanConvert(Type valueType) { }

	// RVA: 0x199E5B0 Offset: 0x199A5B0 VA: 0x199E5B0
	private bool IsXObject(Type valueType) { }

	// RVA: 0x199E630 Offset: 0x199A630 VA: 0x199E630
	private bool IsXmlNode(Type valueType) { }

	// RVA: 0x199E6B0 Offset: 0x199A6B0 VA: 0x199E6B0
	public void .ctor() { }

	// RVA: 0x199E6B8 Offset: 0x199A6B8 VA: 0x199E6B8
	private static void .cctor() { }
}
