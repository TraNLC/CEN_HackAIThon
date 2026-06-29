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

// Namespace: Newtonsoft.Json
public enum ConstructorHandling // TypeDefIndex: 5988
{
	// Fields
	public int value__; // 0x0
	public const ConstructorHandling Default = 0;
	public const ConstructorHandling AllowNonPublicDefaultConstructor = 1;
}

// Namespace: Newtonsoft.Json
public enum DateFormatHandling // TypeDefIndex: 5989
{
	// Fields
	public int value__; // 0x0
	public const DateFormatHandling IsoDateFormat = 0;
	public const DateFormatHandling MicrosoftDateFormat = 1;
}

// Namespace: Newtonsoft.Json
public enum DateParseHandling // TypeDefIndex: 5990
{
	// Fields
	public int value__; // 0x0
	public const DateParseHandling None = 0;
	public const DateParseHandling DateTime = 1;
	public const DateParseHandling DateTimeOffset = 2;
}

// Namespace: Newtonsoft.Json
public enum DateTimeZoneHandling // TypeDefIndex: 5991
{
	// Fields
	public int value__; // 0x0
	public const DateTimeZoneHandling Local = 0;
	public const DateTimeZoneHandling Utc = 1;
	public const DateTimeZoneHandling Unspecified = 2;
	public const DateTimeZoneHandling RoundtripKind = 3;
}

// Namespace: 
[Nullable(0)]
private class DefaultJsonNameTable.Entry // TypeDefIndex: 5992
{
	// Fields
	internal readonly string Value; // 0x10
	internal readonly int HashCode; // 0x18
	internal DefaultJsonNameTable.Entry Next; // 0x20

	// Methods

	// RVA: 0x1920B40 Offset: 0x191CB40 VA: 0x1920B40
	internal void .ctor(string value, int hashCode, DefaultJsonNameTable.Entry next) { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public class DefaultJsonNameTable : JsonNameTable // TypeDefIndex: 5993
{
	// Fields
	private static readonly int HashCodeRandomizer; // 0x0
	private int _count; // 0x10
	private DefaultJsonNameTable.Entry[] _entries; // 0x18
	private int _mask; // 0x20

	// Methods

	// RVA: 0x1920578 Offset: 0x191C578 VA: 0x1920578
	private static void .cctor() { }

	// RVA: 0x19205C8 Offset: 0x191C5C8 VA: 0x19205C8
	public void .ctor() { }

	// RVA: 0x1920640 Offset: 0x191C640 VA: 0x1920640 Slot: 4
	public override string Get(char[] key, int start, int length) { }

	// RVA: 0x1920884 Offset: 0x191C884 VA: 0x1920884
	public string Add(string key) { }

	// RVA: 0x1920A2C Offset: 0x191CA2C VA: 0x1920A2C
	private string AddEntry(string str, int hashCode) { }

	// RVA: 0x1920B94 Offset: 0x191CB94 VA: 0x1920B94
	private void Grow() { }

	// RVA: 0x19207C8 Offset: 0x191C7C8 VA: 0x19207C8
	private static bool TextEquals(string str1, char[] str2, int str2Start, int str2Length) { }
}

// Namespace: Newtonsoft.Json
[Flags]
public enum DefaultValueHandling // TypeDefIndex: 5994
{
	// Fields
	public int value__; // 0x0
	public const DefaultValueHandling Include = 0;
	public const DefaultValueHandling Ignore = 1;
	public const DefaultValueHandling Populate = 2;
	public const DefaultValueHandling IgnoreAndPopulate = 3;
}

// Namespace: Newtonsoft.Json
public enum FloatFormatHandling // TypeDefIndex: 5995
{
	// Fields
	public int value__; // 0x0
	public const FloatFormatHandling String = 0;
	public const FloatFormatHandling Symbol = 1;
	public const FloatFormatHandling DefaultValue = 2;
}

// Namespace: Newtonsoft.Json
public enum FloatParseHandling // TypeDefIndex: 5996
{
	// Fields
	public int value__; // 0x0
	public const FloatParseHandling Double = 0;
	public const FloatParseHandling Decimal = 1;
}

// Namespace: Newtonsoft.Json
public enum Formatting // TypeDefIndex: 5997
{
	// Fields
	public int value__; // 0x0
	public const Formatting None = 0;
	public const Formatting Indented = 1;
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
public interface IArrayPool<T> // TypeDefIndex: 5998
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T[] Rent(int minimumLength);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IArrayPool<__Il2CppFullySharedGenericType>.Rent
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Return(T[] array);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IArrayPool<__Il2CppFullySharedGenericType>.Return
	*/
}

// Namespace: Newtonsoft.Json
public interface IJsonLineInfo // TypeDefIndex: 5999
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

// Namespace: Newtonsoft.Json
[Usage(1028, AllowMultiple = False)]
public sealed class JsonArrayAttribute : JsonContainerAttribute // TypeDefIndex: 6000
{}

// Namespace: Newtonsoft.Json
[Usage(32, AllowMultiple = False)]
public sealed class JsonConstructorAttribute : Attribute // TypeDefIndex: 6001
{}

// Namespace: Newtonsoft.Json
[NullableContext(2)]
[Nullable(0)]
[Usage(1028, AllowMultiple = False)]
public abstract class JsonContainerAttribute : Attribute // TypeDefIndex: 6002
{
	// Fields
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; // 0x10
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private object[] <ItemConverterParameters>k__BackingField; // 0x18
	[CompilerGenerated]
	private NamingStrategy <NamingStrategyInstance>k__BackingField; // 0x20
	internal Nullable<bool> _isReference; // 0x28
	internal Nullable<bool> _itemIsReference; // 0x2A
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x2C
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; // 0x34
	private Type _namingStrategyType; // 0x40
	[Nullable(new[] { 2, 1 })]
	private object[] _namingStrategyParameters; // 0x48

	// Properties
	public Type ItemConverterType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] ItemConverterParameters { get; }
	public Type NamingStrategyType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] NamingStrategyParameters { get; }
	internal NamingStrategy NamingStrategyInstance { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1920CF4 Offset: 0x191CCF4 VA: 0x1920CF4
	public Type get_ItemConverterType() { }

	[CompilerGenerated]
	// RVA: 0x1920CFC Offset: 0x191CCFC VA: 0x1920CFC
	public object[] get_ItemConverterParameters() { }

	// RVA: 0x1920D04 Offset: 0x191CD04 VA: 0x1920D04
	public Type get_NamingStrategyType() { }

	// RVA: 0x1920D0C Offset: 0x191CD0C VA: 0x1920D0C
	public object[] get_NamingStrategyParameters() { }

	[CompilerGenerated]
	// RVA: 0x1920D14 Offset: 0x191CD14 VA: 0x1920D14
	internal NamingStrategy get_NamingStrategyInstance() { }

	[CompilerGenerated]
	// RVA: 0x1920D1C Offset: 0x191CD1C VA: 0x1920D1C
	internal void set_NamingStrategyInstance(NamingStrategy value) { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public static class JsonConvert // TypeDefIndex: 6003
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private static Func<JsonSerializerSettings> <DefaultSettings>k__BackingField; // 0x0
	public static readonly string True; // 0x8
	public static readonly string False; // 0x10
	public static readonly string Null; // 0x18
	public static readonly string Undefined; // 0x20
	public static readonly string PositiveInfinity; // 0x28
	public static readonly string NegativeInfinity; // 0x30
	public static readonly string NaN; // 0x38

	// Properties
	[Nullable(new[] { 2, 1 })]
	public static Func<JsonSerializerSettings> DefaultSettings { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1920D24 Offset: 0x191CD24 VA: 0x1920D24
	public static Func<JsonSerializerSettings> get_DefaultSettings() { }

	// RVA: 0x1920D7C Offset: 0x191CD7C VA: 0x1920D7C
	public static string ToString(bool value) { }

	// RVA: 0x1920DF8 Offset: 0x191CDF8 VA: 0x1920DF8
	public static string ToString(char value) { }

	// RVA: 0x1920ED0 Offset: 0x191CED0 VA: 0x1920ED0
	internal static string ToString(float value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0x1921084 Offset: 0x191D084 VA: 0x1921084
	private static string EnsureFloatFormat(double value, string text, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0x192119C Offset: 0x191D19C VA: 0x192119C
	internal static string ToString(double value, FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable) { }

	// RVA: 0x1920FC0 Offset: 0x191CFC0 VA: 0x1920FC0
	private static string EnsureDecimalPlace(double value, string text) { }

	// RVA: 0x1921288 Offset: 0x191D288 VA: 0x1921288
	private static string EnsureDecimalPlace(string text) { }

	// RVA: 0x19212FC Offset: 0x191D2FC VA: 0x19212FC
	public static string ToString(Decimal value) { }

	// RVA: 0x1920E78 Offset: 0x191CE78 VA: 0x1920E78
	public static string ToString(string value) { }

	// RVA: 0x19213F0 Offset: 0x191D3F0 VA: 0x19213F0
	public static string ToString(string value, char delimiter) { }

	// RVA: 0x1921458 Offset: 0x191D458 VA: 0x1921458
	public static string ToString(string value, char delimiter, StringEscapeHandling stringEscapeHandling) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x192153C Offset: 0x191D53C VA: 0x192153C
	public static string SerializeObject(object value, JsonSerializerSettings settings) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x19215A4 Offset: 0x191D5A4 VA: 0x19215A4
	public static string SerializeObject(object value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0x1921654 Offset: 0x191D654 VA: 0x1921654
	private static string SerializeObjectInternal(object value, Type type, JsonSerializer jsonSerializer) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public static T DeserializeObject<T>(string value, JsonSerializerSettings settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111ACD0 Offset: 0x1116CD0 VA: 0x111ACD0
	|-JsonConvert.DeserializeObject<object>
	|
	|-RVA: 0x111ADC4 Offset: 0x1116DC4 VA: 0x111ADC4
	|-JsonConvert.DeserializeObject<__Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	// RVA: 0x1921A74 Offset: 0x191DA74 VA: 0x1921A74
	public static object DeserializeObject(string value, Type type, JsonSerializerSettings settings) { }

	// RVA: 0x1921DD0 Offset: 0x191DDD0 VA: 0x1921DD0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public abstract class JsonConverter // TypeDefIndex: 6004
{
	// Properties
	public virtual bool CanRead { get; }
	public virtual bool CanWrite { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool CanConvert(Type objectType);

	// RVA: 0x1921F38 Offset: 0x191DF38 VA: 0x1921F38 Slot: 7
	public virtual bool get_CanRead() { }

	// RVA: 0x1921F40 Offset: 0x191DF40 VA: 0x1921F40 Slot: 8
	public virtual bool get_CanWrite() { }

	// RVA: 0x1921F48 Offset: 0x191DF48 VA: 0x1921F48
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
[Usage(3484, AllowMultiple = False)]
public sealed class JsonConverterAttribute : Attribute // TypeDefIndex: 6005
{
	// Fields
	private readonly Type _converterType; // 0x10
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private readonly object[] <ConverterParameters>k__BackingField; // 0x18

	// Properties
	public Type ConverterType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] ConverterParameters { get; }

	// Methods

	// RVA: 0x1921F50 Offset: 0x191DF50 VA: 0x1921F50
	public Type get_ConverterType() { }

	[CompilerGenerated]
	// RVA: 0x1921F58 Offset: 0x191DF58 VA: 0x1921F58
	public object[] get_ConverterParameters() { }
}

// Namespace: Newtonsoft.Json
[Nullable(new[] { 0, 1 })]
public class JsonConverterCollection : Collection<JsonConverter> // TypeDefIndex: 6006
{
	// Methods

	// RVA: 0x1921F60 Offset: 0x191DF60 VA: 0x1921F60
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json
[Usage(1028, AllowMultiple = False)]
public sealed class JsonDictionaryAttribute : JsonContainerAttribute // TypeDefIndex: 6007
{}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
[Serializable]
public class JsonException : Exception // TypeDefIndex: 6008
{
	// Methods

	// RVA: 0x1921FA8 Offset: 0x191DFA8 VA: 0x1921FA8
	public void .ctor() { }

	// RVA: 0x1922000 Offset: 0x191E000 VA: 0x1922000
	public void .ctor(string message) { }

	// RVA: 0x1922068 Offset: 0x191E068 VA: 0x1922068
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x19220D8 Offset: 0x191E0D8 VA: 0x19220D8
	public void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: Newtonsoft.Json
[Usage(384, AllowMultiple = False)]
public class JsonExtensionDataAttribute : Attribute // TypeDefIndex: 6009
{
	// Fields
	[CompilerGenerated]
	private bool <WriteData>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <ReadData>k__BackingField; // 0x11

	// Properties
	public bool WriteData { get; }
	public bool ReadData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1922158 Offset: 0x191E158 VA: 0x1922158
	public bool get_WriteData() { }

	[CompilerGenerated]
	// RVA: 0x1922160 Offset: 0x191E160 VA: 0x1922160
	public bool get_ReadData() { }
}

// Namespace: Newtonsoft.Json
[Usage(384, AllowMultiple = False)]
public sealed class JsonIgnoreAttribute : Attribute // TypeDefIndex: 6010
{}

// Namespace: Newtonsoft.Json
public abstract class JsonNameTable // TypeDefIndex: 6011
{
	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract string Get(char[] key, int start, int length);

	// RVA: 0x1920638 Offset: 0x191C638 VA: 0x1920638
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json
[Usage(1036, AllowMultiple = False)]
public sealed class JsonObjectAttribute : JsonContainerAttribute // TypeDefIndex: 6012
{
	// Fields
	private MemberSerialization _memberSerialization; // 0x50
	internal Nullable<MissingMemberHandling> _missingMemberHandling; // 0x54
	internal Nullable<Required> _itemRequired; // 0x5C
	internal Nullable<NullValueHandling> _itemNullValueHandling; // 0x64

	// Properties
	public MemberSerialization MemberSerialization { get; }

	// Methods

	// RVA: 0x1922168 Offset: 0x191E168 VA: 0x1922168
	public MemberSerialization get_MemberSerialization() { }
}

// Namespace: Newtonsoft.Json
internal enum JsonContainerType // TypeDefIndex: 6013
{
	// Fields
	public int value__; // 0x0
	public const JsonContainerType None = 0;
	public const JsonContainerType Object = 1;
	public const JsonContainerType Array = 2;
	public const JsonContainerType Constructor = 3;
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
internal struct JsonPosition // TypeDefIndex: 6014
{
	// Fields
	private static readonly char[] SpecialCharacters; // 0x0
	internal JsonContainerType Type; // 0x0
	internal int Position; // 0x4
	[Nullable(2)]
	internal string PropertyName; // 0x8
	internal bool HasIndex; // 0x10

	// Methods

	// RVA: 0x1922170 Offset: 0x191E170 VA: 0x1922170
	public void .ctor(JsonContainerType type) { }

	// RVA: 0x1922204 Offset: 0x191E204 VA: 0x1922204
	internal int CalculateLength() { }

	[NullableContext(2)]
	// RVA: 0x1922298 Offset: 0x191E298 VA: 0x1922298
	internal void WriteTo(StringBuilder sb, ref StringWriter writer, ref char[] buffer) { }

	// RVA: 0x19221F4 Offset: 0x191E1F4 VA: 0x19221F4
	internal static bool TypeHasIndex(JsonContainerType type) { }

	// RVA: 0x19224B8 Offset: 0x191E4B8 VA: 0x19224B8
	internal static string BuildPath(List<JsonPosition> positions, Nullable<JsonPosition> currentPosition) { }

	// RVA: 0x19227A8 Offset: 0x191E7A8 VA: 0x19227A8
	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	// RVA: 0x1922AC8 Offset: 0x191EAC8 VA: 0x1922AC8
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(2)]
[Nullable(0)]
[Usage(2432, AllowMultiple = False)]
public sealed class JsonPropertyAttribute : Attribute // TypeDefIndex: 6015
{
	// Fields
	internal Nullable<NullValueHandling> _nullValueHandling; // 0x10
	internal Nullable<DefaultValueHandling> _defaultValueHandling; // 0x18
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; // 0x20
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; // 0x28
	internal Nullable<TypeNameHandling> _typeNameHandling; // 0x30
	internal Nullable<bool> _isReference; // 0x38
	internal Nullable<int> _order; // 0x3C
	internal Nullable<Required> _required; // 0x44
	internal Nullable<bool> _itemIsReference; // 0x4C
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; // 0x50
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; // 0x58
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; // 0x60
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private object[] <ItemConverterParameters>k__BackingField; // 0x68
	[CompilerGenerated]
	private Type <NamingStrategyType>k__BackingField; // 0x70
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private object[] <NamingStrategyParameters>k__BackingField; // 0x78
	[CompilerGenerated]
	private string <PropertyName>k__BackingField; // 0x80

	// Properties
	public Type ItemConverterType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] ItemConverterParameters { get; }
	public Type NamingStrategyType { get; }
	[Nullable(new[] { 2, 1 })]
	public object[] NamingStrategyParameters { get; }
	public string PropertyName { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1922B68 Offset: 0x191EB68 VA: 0x1922B68
	public Type get_ItemConverterType() { }

	[CompilerGenerated]
	// RVA: 0x1922B70 Offset: 0x191EB70 VA: 0x1922B70
	public object[] get_ItemConverterParameters() { }

	[CompilerGenerated]
	// RVA: 0x1922B78 Offset: 0x191EB78 VA: 0x1922B78
	public Type get_NamingStrategyType() { }

	[CompilerGenerated]
	// RVA: 0x1922B80 Offset: 0x191EB80 VA: 0x1922B80
	public object[] get_NamingStrategyParameters() { }

	[CompilerGenerated]
	// RVA: 0x1922B88 Offset: 0x191EB88 VA: 0x1922B88
	public string get_PropertyName() { }

	[CompilerGenerated]
	// RVA: 0x1922B90 Offset: 0x191EB90 VA: 0x1922B90
	public void set_PropertyName(string value) { }

	[NullableContext(1)]
	// RVA: 0x1922B98 Offset: 0x191EB98 VA: 0x1922B98
	public void .ctor(string propertyName) { }
}

// Namespace: 
[NullableContext(0)]
protected internal enum JsonReader.State // TypeDefIndex: 6016
{
	// Fields
	public int value__; // 0x0
	public const JsonReader.State Start = 0;
	public const JsonReader.State Complete = 1;
	public const JsonReader.State Property = 2;
	public const JsonReader.State ObjectStart = 3;
	public const JsonReader.State Object = 4;
	public const JsonReader.State ArrayStart = 5;
	public const JsonReader.State Array = 6;
	public const JsonReader.State Closed = 7;
	public const JsonReader.State PostValue = 8;
	public const JsonReader.State ConstructorStart = 9;
	public const JsonReader.State Constructor = 10;
	public const JsonReader.State Error = 11;
	public const JsonReader.State Finished = 12;
}

// Namespace: Newtonsoft.Json
[NullableContext(2)]
[Nullable(0)]
public abstract class JsonReader : IDisposable // TypeDefIndex: 6017
{
	// Fields
	private JsonToken _tokenType; // 0x10
	private object _value; // 0x18
	internal char _quoteChar; // 0x20
	internal JsonReader.State _currentState; // 0x24
	private JsonPosition _currentPosition; // 0x28
	private CultureInfo _culture; // 0x40
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x48
	private Nullable<int> _maxDepth; // 0x4C
	private bool _hasExceededMaxDepth; // 0x54
	internal DateParseHandling _dateParseHandling; // 0x58
	internal FloatParseHandling _floatParseHandling; // 0x5C
	private string _dateFormatString; // 0x60
	private List<JsonPosition> _stack; // 0x68
	[CompilerGenerated]
	private bool <CloseInput>k__BackingField; // 0x70
	[CompilerGenerated]
	private bool <SupportMultipleContent>k__BackingField; // 0x71

	// Properties
	protected JsonReader.State CurrentState { get; }
	public bool CloseInput { get; set; }
	public bool SupportMultipleContent { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public DateParseHandling DateParseHandling { get; set; }
	public FloatParseHandling FloatParseHandling { get; set; }
	public string DateFormatString { get; set; }
	public Nullable<int> MaxDepth { get; set; }
	public virtual JsonToken TokenType { get; }
	public virtual object Value { get; }
	public virtual Type ValueType { get; }
	public virtual int Depth { get; }
	[Nullable(1)]
	public virtual string Path { get; }
	[Nullable(1)]
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0x1922BC8 Offset: 0x191EBC8 VA: 0x1922BC8
	protected JsonReader.State get_CurrentState() { }

	[CompilerGenerated]
	// RVA: 0x1922BD0 Offset: 0x191EBD0 VA: 0x1922BD0
	public bool get_CloseInput() { }

	[CompilerGenerated]
	// RVA: 0x1922BD8 Offset: 0x191EBD8 VA: 0x1922BD8
	public void set_CloseInput(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1922BE0 Offset: 0x191EBE0 VA: 0x1922BE0
	public bool get_SupportMultipleContent() { }

	[CompilerGenerated]
	// RVA: 0x1922BE8 Offset: 0x191EBE8 VA: 0x1922BE8
	public void set_SupportMultipleContent(bool value) { }

	// RVA: 0x1922BF0 Offset: 0x191EBF0 VA: 0x1922BF0
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x1922BF8 Offset: 0x191EBF8 VA: 0x1922BF8
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x1922C54 Offset: 0x191EC54 VA: 0x1922C54
	public DateParseHandling get_DateParseHandling() { }

	// RVA: 0x1922C5C Offset: 0x191EC5C VA: 0x1922C5C
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x1922CB8 Offset: 0x191ECB8 VA: 0x1922CB8
	public FloatParseHandling get_FloatParseHandling() { }

	// RVA: 0x1922CC0 Offset: 0x191ECC0 VA: 0x1922CC0
	public void set_FloatParseHandling(FloatParseHandling value) { }

	// RVA: 0x1922D1C Offset: 0x191ED1C VA: 0x1922D1C
	public string get_DateFormatString() { }

	// RVA: 0x1922D24 Offset: 0x191ED24 VA: 0x1922D24
	public void set_DateFormatString(string value) { }

	// RVA: 0x1922D2C Offset: 0x191ED2C VA: 0x1922D2C
	public Nullable<int> get_MaxDepth() { }

	// RVA: 0x1922D34 Offset: 0x191ED34 VA: 0x1922D34
	public void set_MaxDepth(Nullable<int> value) { }

	// RVA: 0x1922DF0 Offset: 0x191EDF0 VA: 0x1922DF0 Slot: 5
	public virtual JsonToken get_TokenType() { }

	// RVA: 0x1922DF8 Offset: 0x191EDF8 VA: 0x1922DF8 Slot: 6
	public virtual object get_Value() { }

	// RVA: 0x1922E00 Offset: 0x191EE00 VA: 0x1922E00 Slot: 7
	public virtual Type get_ValueType() { }

	// RVA: 0x1922E14 Offset: 0x191EE14 VA: 0x1922E14 Slot: 8
	public virtual int get_Depth() { }

	[NullableContext(1)]
	// RVA: 0x1922E8C Offset: 0x191EE8C VA: 0x1922E8C Slot: 9
	public virtual string get_Path() { }

	[NullableContext(1)]
	// RVA: 0x1922F94 Offset: 0x191EF94 VA: 0x1922F94
	public CultureInfo get_Culture() { }

	[NullableContext(1)]
	// RVA: 0x1922FFC Offset: 0x191EFFC VA: 0x1922FFC
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x1923004 Offset: 0x191F004 VA: 0x1923004
	internal JsonPosition GetPosition(int depth) { }

	// RVA: 0x19230A8 Offset: 0x191F0A8 VA: 0x19230A8
	protected void .ctor() { }

	// RVA: 0x1923138 Offset: 0x191F138 VA: 0x1923138
	private void Push(JsonContainerType value) { }

	// RVA: 0x1923410 Offset: 0x191F410 VA: 0x1923410
	private JsonContainerType Pop() { }

	// RVA: 0x1923534 Offset: 0x191F534 VA: 0x1923534
	private JsonContainerType Peek() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool Read();

	// RVA: 0x192353C Offset: 0x191F53C VA: 0x192353C Slot: 11
	public virtual Nullable<int> ReadAsInt32() { }

	// RVA: 0x1923B50 Offset: 0x191FB50 VA: 0x1923B50
	internal Nullable<int> ReadInt32String(string s) { }

	// RVA: 0x1923D00 Offset: 0x191FD00 VA: 0x1923D00 Slot: 12
	public virtual string ReadAsString() { }

	// RVA: 0x1923F84 Offset: 0x191FF84 VA: 0x1923F84 Slot: 13
	public virtual byte[] ReadAsBytes() { }

	[NullableContext(1)]
	// RVA: 0x1924554 Offset: 0x1920554 VA: 0x1924554
	internal byte[] ReadArrayIntoByteArray() { }

	[NullableContext(1)]
	// RVA: 0x1924670 Offset: 0x1920670 VA: 0x1924670
	private bool ReadArrayElementIntoByteArrayReportDone(List<byte> buffer) { }

	// RVA: 0x1924878 Offset: 0x1920878 VA: 0x1924878 Slot: 14
	public virtual Nullable<double> ReadAsDouble() { }

	// RVA: 0x1924B44 Offset: 0x1920B44 VA: 0x1924B44
	internal Nullable<double> ReadDoubleString(string s) { }

	// RVA: 0x1924CEC Offset: 0x1920CEC VA: 0x1924CEC Slot: 15
	public virtual Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x1925004 Offset: 0x1921004 VA: 0x1925004
	internal Nullable<bool> ReadBooleanString(string s) { }

	// RVA: 0x19251B4 Offset: 0x19211B4 VA: 0x19251B4 Slot: 16
	public virtual Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x1925634 Offset: 0x1921634 VA: 0x1925634
	internal Nullable<Decimal> ReadDecimalString(string s) { }

	// RVA: 0x19258CC Offset: 0x19218CC VA: 0x19258CC Slot: 17
	public virtual Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x1925B50 Offset: 0x1921B50 VA: 0x1925B50
	internal Nullable<DateTime> ReadDateTimeString(string s) { }

	// RVA: 0x1925DE0 Offset: 0x1921DE0 VA: 0x1925DE0 Slot: 18
	public virtual Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x192605C Offset: 0x192205C VA: 0x192605C
	internal Nullable<DateTimeOffset> ReadDateTimeOffsetString(string s) { }

	// RVA: 0x1924510 Offset: 0x1920510 VA: 0x1924510
	internal void ReaderReadAndAssert() { }

	[NullableContext(1)]
	// RVA: 0x19262A4 Offset: 0x19222A4 VA: 0x19262A4
	internal JsonReaderException CreateUnexpectedEndException() { }

	// RVA: 0x1924344 Offset: 0x1920344 VA: 0x1924344
	internal void ReadIntoWrappedTypeObject() { }

	// RVA: 0x19262F0 Offset: 0x19222F0 VA: 0x19262F0
	public void Skip() { }

	// RVA: 0x1924664 Offset: 0x1920664 VA: 0x1924664
	protected void SetToken(JsonToken newToken) { }

	// RVA: 0x1926388 Offset: 0x1922388 VA: 0x1926388
	protected void SetToken(JsonToken newToken, object value) { }

	// RVA: 0x19239AC Offset: 0x191F9AC VA: 0x19239AC
	protected void SetToken(JsonToken newToken, object value, bool updateIndex) { }

	// RVA: 0x192648C Offset: 0x192248C VA: 0x192648C
	internal void SetPostValueState(bool updateIndex) { }

	// RVA: 0x19233F0 Offset: 0x191F3F0 VA: 0x19233F0
	private void UpdateScopeWithFinishedValue() { }

	// RVA: 0x1926390 Offset: 0x1922390 VA: 0x1926390
	private void ValidateEnd(JsonToken endToken) { }

	// RVA: 0x1926594 Offset: 0x1922594 VA: 0x1926594
	protected void SetStateBasedOnCurrent() { }

	// RVA: 0x19264C8 Offset: 0x19224C8 VA: 0x19264C8
	private void SetFinished() { }

	// RVA: 0x19264EC Offset: 0x19224EC VA: 0x19264EC
	private JsonContainerType GetTypeForCloseToken(JsonToken token) { }

	// RVA: 0x1926688 Offset: 0x1922688 VA: 0x1926688 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19266F8 Offset: 0x19226F8 VA: 0x19266F8 Slot: 19
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x192671C Offset: 0x192271C VA: 0x192671C Slot: 20
	public virtual void Close() { }

	// RVA: 0x1926734 Offset: 0x1922734 VA: 0x1926734
	internal void ReadAndAssert() { }

	// RVA: 0x1926790 Offset: 0x1922790 VA: 0x1926790
	internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter) { }

	// RVA: 0x19267DC Offset: 0x19227DC VA: 0x19267DC
	internal bool ReadForType(JsonContract contract, bool hasConverter) { }

	// RVA: 0x1926AE0 Offset: 0x1922AE0 VA: 0x1926AE0
	internal bool ReadAndMoveToContent() { }

	// RVA: 0x1926B10 Offset: 0x1922B10 VA: 0x1926B10
	internal bool MoveToContent() { }

	// RVA: 0x19238D0 Offset: 0x191F8D0 VA: 0x19238D0
	private JsonToken GetContentToken() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
[Serializable]
public class JsonReaderException : JsonException // TypeDefIndex: 6018
{
	// Fields
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; // 0x8C
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; // 0x90
	[Nullable(2)]
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; // 0x98

	// Methods

	// RVA: 0x1926B5C Offset: 0x1922B5C VA: 0x1926B5C
	public void .ctor() { }

	// RVA: 0x1926B60 Offset: 0x1922B60 VA: 0x1926B60
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1926B64 Offset: 0x1922B64 VA: 0x1926B64
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0x1923408 Offset: 0x191F408 VA: 0x1923408
	internal static JsonReaderException Create(JsonReader reader, string message) { }

	// RVA: 0x1923928 Offset: 0x191F928 VA: 0x1923928
	internal static JsonReaderException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0x1926BAC Offset: 0x1922BAC VA: 0x1926BAC
	internal static JsonReaderException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }
}

// Namespace: Newtonsoft.Json
[Usage(384, AllowMultiple = False)]
public sealed class JsonRequiredAttribute : Attribute // TypeDefIndex: 6019
{}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
[Serializable]
public class JsonSerializationException : JsonException // TypeDefIndex: 6020
{
	// Fields
	[CompilerGenerated]
	private readonly int <LineNumber>k__BackingField; // 0x8C
	[CompilerGenerated]
	private readonly int <LinePosition>k__BackingField; // 0x90
	[Nullable(2)]
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; // 0x98

	// Methods

	// RVA: 0x1926DB0 Offset: 0x1922DB0 VA: 0x1926DB0
	public void .ctor() { }

	// RVA: 0x1926DB4 Offset: 0x1922DB4 VA: 0x1926DB4
	public void .ctor(string message) { }

	// RVA: 0x1926DB8 Offset: 0x1922DB8 VA: 0x1926DB8
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1926DBC Offset: 0x1922DBC VA: 0x1926DBC
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1926DC0 Offset: 0x1922DC0 VA: 0x1926DC0
	public void .ctor(string message, string path, int lineNumber, int linePosition, Exception innerException) { }

	// RVA: 0x1926788 Offset: 0x1922788 VA: 0x1926788
	internal static JsonSerializationException Create(JsonReader reader, string message) { }

	// RVA: 0x1926E08 Offset: 0x1922E08 VA: 0x1926E08
	internal static JsonSerializationException Create(JsonReader reader, string message, Exception ex) { }

	// RVA: 0x1926E8C Offset: 0x1922E8C VA: 0x1926E8C
	internal static JsonSerializationException Create(IJsonLineInfo lineInfo, string path, string message, Exception ex) { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public class JsonSerializer // TypeDefIndex: 6021
{
	// Fields
	internal TypeNameHandling _typeNameHandling; // 0x10
	internal TypeNameAssemblyFormatHandling _typeNameAssemblyFormatHandling; // 0x14
	internal PreserveReferencesHandling _preserveReferencesHandling; // 0x18
	internal ReferenceLoopHandling _referenceLoopHandling; // 0x1C
	internal MissingMemberHandling _missingMemberHandling; // 0x20
	internal ObjectCreationHandling _objectCreationHandling; // 0x24
	internal NullValueHandling _nullValueHandling; // 0x28
	internal DefaultValueHandling _defaultValueHandling; // 0x2C
	internal ConstructorHandling _constructorHandling; // 0x30
	internal MetadataPropertyHandling _metadataPropertyHandling; // 0x34
	[Nullable(2)]
	internal JsonConverterCollection _converters; // 0x38
	internal IContractResolver _contractResolver; // 0x40
	[Nullable(2)]
	internal ITraceWriter _traceWriter; // 0x48
	[Nullable(2)]
	internal IEqualityComparer _equalityComparer; // 0x50
	internal ISerializationBinder _serializationBinder; // 0x58
	internal StreamingContext _context; // 0x60
	[Nullable(2)]
	private IReferenceResolver _referenceResolver; // 0x70
	private Nullable<Formatting> _formatting; // 0x78
	private Nullable<DateFormatHandling> _dateFormatHandling; // 0x80
	private Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; // 0x88
	private Nullable<DateParseHandling> _dateParseHandling; // 0x90
	private Nullable<FloatFormatHandling> _floatFormatHandling; // 0x98
	private Nullable<FloatParseHandling> _floatParseHandling; // 0xA0
	private Nullable<StringEscapeHandling> _stringEscapeHandling; // 0xA8
	private CultureInfo _culture; // 0xB0
	private Nullable<int> _maxDepth; // 0xB8
	private bool _maxDepthSet; // 0xC0
	private Nullable<bool> _checkAdditionalContent; // 0xC1
	[Nullable(2)]
	private string _dateFormatString; // 0xC8
	private bool _dateFormatStringSet; // 0xD0
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private EventHandler<ErrorEventArgs> Error; // 0xD8

	// Properties
	[Nullable(2)]
	public virtual IReferenceResolver ReferenceResolver { set; }
	public virtual ISerializationBinder SerializationBinder { set; }
	[Nullable(2)]
	public virtual ITraceWriter TraceWriter { get; set; }
	[Nullable(2)]
	public virtual IEqualityComparer EqualityComparer { set; }
	public virtual TypeNameHandling TypeNameHandling { set; }
	public virtual TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { set; }
	public virtual PreserveReferencesHandling PreserveReferencesHandling { set; }
	public virtual ReferenceLoopHandling ReferenceLoopHandling { set; }
	public virtual MissingMemberHandling MissingMemberHandling { set; }
	public virtual NullValueHandling NullValueHandling { get; set; }
	public virtual DefaultValueHandling DefaultValueHandling { set; }
	public virtual ObjectCreationHandling ObjectCreationHandling { set; }
	public virtual ConstructorHandling ConstructorHandling { set; }
	public virtual MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	public virtual JsonConverterCollection Converters { get; }
	public virtual IContractResolver ContractResolver { get; set; }
	public virtual StreamingContext Context { get; set; }
	public virtual Formatting Formatting { get; }
	public virtual Nullable<int> MaxDepth { get; }
	public virtual bool CheckAdditionalContent { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1927090 Offset: 0x1923090 VA: 0x1927090 Slot: 4
	public virtual void add_Error(EventHandler<ErrorEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1927140 Offset: 0x1923140 VA: 0x1927140 Slot: 5
	public virtual void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	// RVA: 0x19271F0 Offset: 0x19231F0 VA: 0x19271F0 Slot: 6
	public virtual void set_ReferenceResolver(IReferenceResolver value) { }

	// RVA: 0x1927260 Offset: 0x1923260 VA: 0x1927260 Slot: 7
	public virtual void set_SerializationBinder(ISerializationBinder value) { }

	[NullableContext(2)]
	// RVA: 0x19272D0 Offset: 0x19232D0 VA: 0x19272D0 Slot: 8
	public virtual ITraceWriter get_TraceWriter() { }

	[NullableContext(2)]
	// RVA: 0x19272D8 Offset: 0x19232D8 VA: 0x19272D8 Slot: 9
	public virtual void set_TraceWriter(ITraceWriter value) { }

	[NullableContext(2)]
	// RVA: 0x19272E0 Offset: 0x19232E0 VA: 0x19272E0 Slot: 10
	public virtual void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x19272E8 Offset: 0x19232E8 VA: 0x19272E8 Slot: 11
	public virtual void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x1927344 Offset: 0x1923344 VA: 0x1927344 Slot: 12
	public virtual void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0x19273A0 Offset: 0x19233A0 VA: 0x19273A0 Slot: 13
	public virtual void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x19273FC Offset: 0x19233FC VA: 0x19273FC Slot: 14
	public virtual void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x1927458 Offset: 0x1923458 VA: 0x1927458 Slot: 15
	public virtual void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x19274B4 Offset: 0x19234B4 VA: 0x19274B4 Slot: 16
	public virtual NullValueHandling get_NullValueHandling() { }

	// RVA: 0x19274BC Offset: 0x19234BC VA: 0x19274BC Slot: 17
	public virtual void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x1927518 Offset: 0x1923518 VA: 0x1927518 Slot: 18
	public virtual void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x1927574 Offset: 0x1923574 VA: 0x1927574 Slot: 19
	public virtual void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x19275D0 Offset: 0x19235D0 VA: 0x19275D0 Slot: 20
	public virtual void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x192762C Offset: 0x192362C VA: 0x192762C Slot: 21
	public virtual MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x1927634 Offset: 0x1923634 VA: 0x1927634 Slot: 22
	public virtual void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x1927690 Offset: 0x1923690 VA: 0x1927690 Slot: 23
	public virtual JsonConverterCollection get_Converters() { }

	// RVA: 0x19276FC Offset: 0x19236FC VA: 0x19276FC Slot: 24
	public virtual IContractResolver get_ContractResolver() { }

	// RVA: 0x1927704 Offset: 0x1923704 VA: 0x1927704 Slot: 25
	public virtual void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x19277B4 Offset: 0x19237B4 VA: 0x19277B4 Slot: 26
	public virtual StreamingContext get_Context() { }

	// RVA: 0x19277C0 Offset: 0x19237C0 VA: 0x19277C0 Slot: 27
	public virtual void set_Context(StreamingContext value) { }

	// RVA: 0x19277CC Offset: 0x19237CC VA: 0x19277CC Slot: 28
	public virtual Formatting get_Formatting() { }

	// RVA: 0x1927808 Offset: 0x1923808 VA: 0x1927808 Slot: 29
	public virtual Nullable<int> get_MaxDepth() { }

	// RVA: 0x1927810 Offset: 0x1923810 VA: 0x1927810 Slot: 30
	public virtual bool get_CheckAdditionalContent() { }

	// RVA: 0x192784C Offset: 0x192384C VA: 0x192784C Slot: 31
	public virtual void set_CheckAdditionalContent(bool value) { }

	// RVA: 0x1921C80 Offset: 0x191DC80 VA: 0x1921C80
	internal bool IsCheckAdditionalContentSet() { }

	// RVA: 0x19278B4 Offset: 0x19238B4 VA: 0x19278B4
	public void .ctor() { }

	// RVA: 0x1927A00 Offset: 0x1923A00 VA: 0x1927A00
	public static JsonSerializer Create() { }

	// RVA: 0x1927A50 Offset: 0x1923A50 VA: 0x1927A50
	public static JsonSerializer Create(JsonSerializerSettings settings) { }

	// RVA: 0x19281BC Offset: 0x19241BC VA: 0x19281BC
	public static JsonSerializer CreateDefault() { }

	// RVA: 0x1921620 Offset: 0x191D620 VA: 0x1921620
	public static JsonSerializer CreateDefault(JsonSerializerSettings settings) { }

	// RVA: 0x1927A84 Offset: 0x1923A84 VA: 0x1927A84
	private static void ApplySerializerSettings(JsonSerializer serializer, JsonSerializerSettings settings) { }

	[DebuggerStepThrough]
	// RVA: 0x1928548 Offset: 0x1924548 VA: 0x1928548
	public void Populate(JsonReader reader, object target) { }

	// RVA: 0x1928558 Offset: 0x1924558 VA: 0x1928558 Slot: 32
	internal virtual void PopulateInternal(JsonReader reader, object target) { }

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: -1 Offset: -1
	public T Deserialize<T>(JsonReader reader) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111B938 Offset: 0x1117938 VA: 0x111B938
	|-JsonSerializer.Deserialize<Int32Enum>
	|
	|-RVA: 0x111BA00 Offset: 0x1117A00 VA: 0x111BA00
	|-JsonSerializer.Deserialize<long>
	|
	|-RVA: 0x111BAC8 Offset: 0x1117AC8 VA: 0x111BAC8
	|-JsonSerializer.Deserialize<object>
	|
	|-RVA: 0x111BB88 Offset: 0x1117B88 VA: 0x111BB88
	|-JsonSerializer.Deserialize<__Il2CppFullySharedGenericType>
	*/

	[NullableContext(2)]
	[DebuggerStepThrough]
	// RVA: 0x1921DC0 Offset: 0x191DDC0 VA: 0x1921DC0
	public object Deserialize(JsonReader reader, Type objectType) { }

	[NullableContext(2)]
	// RVA: 0x1928E3C Offset: 0x1924E3C VA: 0x1928E3C Slot: 33
	internal virtual object DeserializeInternal(JsonReader reader, Type objectType) { }

	[NullableContext(2)]
	// RVA: 0x19287D0 Offset: 0x19247D0 VA: 0x19287D0
	internal void SetupReader(JsonReader reader, out CultureInfo previousCulture, out Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, out Nullable<DateParseHandling> previousDateParseHandling, out Nullable<FloatParseHandling> previousFloatParseHandling, out Nullable<int> previousMaxDepth, out string previousDateFormatString) { }

	[NullableContext(2)]
	// RVA: 0x1928C2C Offset: 0x1924C2C VA: 0x1928C2C
	private void ResetReader(JsonReader reader, CultureInfo previousCulture, Nullable<DateTimeZoneHandling> previousDateTimeZoneHandling, Nullable<DateParseHandling> previousDateParseHandling, Nullable<FloatParseHandling> previousFloatParseHandling, Nullable<int> previousMaxDepth, string previousDateFormatString) { }

	[NullableContext(2)]
	// RVA: 0x1921A64 Offset: 0x191DA64 VA: 0x1921A64
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x19290BC Offset: 0x19250BC VA: 0x19290BC
	public void Serialize(JsonWriter jsonWriter, object value) { }

	// RVA: 0x1928BA4 Offset: 0x1924BA4 VA: 0x1928BA4
	private TraceJsonReader CreateTraceJsonReader(JsonReader reader) { }

	[NullableContext(2)]
	// RVA: 0x19290D0 Offset: 0x19250D0 VA: 0x19290D0 Slot: 34
	internal virtual void SerializeInternal(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x1929864 Offset: 0x1925864 VA: 0x1929864
	internal IReferenceResolver GetReferenceResolver() { }

	// RVA: 0x19298D4 Offset: 0x19258D4 VA: 0x19298D4
	internal JsonConverter GetMatchingConverter(Type type) { }

	// RVA: 0x19298DC Offset: 0x19258DC VA: 0x19298DC
	internal static JsonConverter GetMatchingConverter(IList<JsonConverter> converters, Type objectType) { }

	// RVA: 0x1929A38 Offset: 0x1925A38 VA: 0x1929A38
	internal void OnError(ErrorEventArgs e) { }
}

// Namespace: Newtonsoft.Json
[NullableContext(2)]
[Nullable(0)]
public class JsonSerializerSettings // TypeDefIndex: 6022
{
	// Fields
	internal static readonly StreamingContext DefaultContext; // 0x0
	[Nullable(1)]
	internal static readonly CultureInfo DefaultCulture; // 0x10
	internal Nullable<Formatting> _formatting; // 0x10
	internal Nullable<DateFormatHandling> _dateFormatHandling; // 0x18
	internal Nullable<DateTimeZoneHandling> _dateTimeZoneHandling; // 0x20
	internal Nullable<DateParseHandling> _dateParseHandling; // 0x28
	internal Nullable<FloatFormatHandling> _floatFormatHandling; // 0x30
	internal Nullable<FloatParseHandling> _floatParseHandling; // 0x38
	internal Nullable<StringEscapeHandling> _stringEscapeHandling; // 0x40
	internal CultureInfo _culture; // 0x48
	internal Nullable<bool> _checkAdditionalContent; // 0x50
	internal Nullable<int> _maxDepth; // 0x54
	internal bool _maxDepthSet; // 0x5C
	internal string _dateFormatString; // 0x60
	internal bool _dateFormatStringSet; // 0x68
	internal Nullable<TypeNameAssemblyFormatHandling> _typeNameAssemblyFormatHandling; // 0x6C
	internal Nullable<DefaultValueHandling> _defaultValueHandling; // 0x74
	internal Nullable<PreserveReferencesHandling> _preserveReferencesHandling; // 0x7C
	internal Nullable<NullValueHandling> _nullValueHandling; // 0x84
	internal Nullable<ObjectCreationHandling> _objectCreationHandling; // 0x8C
	internal Nullable<MissingMemberHandling> _missingMemberHandling; // 0x94
	internal Nullable<ReferenceLoopHandling> _referenceLoopHandling; // 0x9C
	internal Nullable<StreamingContext> _context; // 0xA8
	internal Nullable<ConstructorHandling> _constructorHandling; // 0xC0
	internal Nullable<TypeNameHandling> _typeNameHandling; // 0xC8
	internal Nullable<MetadataPropertyHandling> _metadataPropertyHandling; // 0xD0
	[Nullable(1)]
	[CompilerGenerated]
	private IList<JsonConverter> <Converters>k__BackingField; // 0xD8
	[CompilerGenerated]
	private IContractResolver <ContractResolver>k__BackingField; // 0xE0
	[CompilerGenerated]
	private IEqualityComparer <EqualityComparer>k__BackingField; // 0xE8
	[CompilerGenerated]
	private Func<IReferenceResolver> <ReferenceResolverProvider>k__BackingField; // 0xF0
	[CompilerGenerated]
	private ITraceWriter <TraceWriter>k__BackingField; // 0xF8
	[CompilerGenerated]
	private ISerializationBinder <SerializationBinder>k__BackingField; // 0x100
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private EventHandler<ErrorEventArgs> <Error>k__BackingField; // 0x108

	// Properties
	public ReferenceLoopHandling ReferenceLoopHandling { get; }
	public MissingMemberHandling MissingMemberHandling { get; }
	public ObjectCreationHandling ObjectCreationHandling { get; }
	public NullValueHandling NullValueHandling { get; }
	public DefaultValueHandling DefaultValueHandling { get; }
	[Nullable(1)]
	public IList<JsonConverter> Converters { get; set; }
	public PreserveReferencesHandling PreserveReferencesHandling { get; }
	public TypeNameHandling TypeNameHandling { get; }
	public MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	public TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { get; }
	public ConstructorHandling ConstructorHandling { get; }
	public IContractResolver ContractResolver { get; }
	public IEqualityComparer EqualityComparer { get; }
	public Func<IReferenceResolver> ReferenceResolverProvider { get; }
	public ITraceWriter TraceWriter { get; }
	public ISerializationBinder SerializationBinder { get; }
	[Nullable(new[] { 2, 1 })]
	public EventHandler<ErrorEventArgs> Error { get; }
	public StreamingContext Context { get; }
	public DateParseHandling DateParseHandling { set; }

	// Methods

	// RVA: 0x1928350 Offset: 0x1924350 VA: 0x1928350
	public ReferenceLoopHandling get_ReferenceLoopHandling() { }

	// RVA: 0x192838C Offset: 0x192438C VA: 0x192838C
	public MissingMemberHandling get_MissingMemberHandling() { }

	// RVA: 0x19283C8 Offset: 0x19243C8 VA: 0x19283C8
	public ObjectCreationHandling get_ObjectCreationHandling() { }

	// RVA: 0x1928404 Offset: 0x1924404 VA: 0x1928404
	public NullValueHandling get_NullValueHandling() { }

	// RVA: 0x1928440 Offset: 0x1924440 VA: 0x1928440
	public DefaultValueHandling get_DefaultValueHandling() { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x1929A60 Offset: 0x1925A60 VA: 0x1929A60
	public IList<JsonConverter> get_Converters() { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x1929A68 Offset: 0x1925A68 VA: 0x1929A68
	public void set_Converters(IList<JsonConverter> value) { }

	// RVA: 0x1928314 Offset: 0x1924314 VA: 0x1928314
	public PreserveReferencesHandling get_PreserveReferencesHandling() { }

	// RVA: 0x1928260 Offset: 0x1924260 VA: 0x1928260
	public TypeNameHandling get_TypeNameHandling() { }

	// RVA: 0x192829C Offset: 0x192429C VA: 0x192829C
	public MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x1929A70 Offset: 0x1925A70 VA: 0x1929A70
	public void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x19282D8 Offset: 0x19242D8 VA: 0x19282D8
	public TypeNameAssemblyFormatHandling get_TypeNameAssemblyFormatHandling() { }

	// RVA: 0x192847C Offset: 0x192447C VA: 0x192847C
	public ConstructorHandling get_ConstructorHandling() { }

	[CompilerGenerated]
	// RVA: 0x1929AD8 Offset: 0x1925AD8 VA: 0x1929AD8
	public IContractResolver get_ContractResolver() { }

	[CompilerGenerated]
	// RVA: 0x1929AE0 Offset: 0x1925AE0 VA: 0x1929AE0
	public IEqualityComparer get_EqualityComparer() { }

	[CompilerGenerated]
	// RVA: 0x1929AE8 Offset: 0x1925AE8 VA: 0x1929AE8
	public Func<IReferenceResolver> get_ReferenceResolverProvider() { }

	[CompilerGenerated]
	// RVA: 0x1929AF0 Offset: 0x1925AF0 VA: 0x1929AF0
	public ITraceWriter get_TraceWriter() { }

	[CompilerGenerated]
	// RVA: 0x1929AF8 Offset: 0x1925AF8 VA: 0x1929AF8
	public ISerializationBinder get_SerializationBinder() { }

	[CompilerGenerated]
	// RVA: 0x1929B00 Offset: 0x1925B00 VA: 0x1929B00
	public EventHandler<ErrorEventArgs> get_Error() { }

	// RVA: 0x19284B8 Offset: 0x19244B8 VA: 0x19284B8
	public StreamingContext get_Context() { }

	// RVA: 0x1929B08 Offset: 0x1925B08 VA: 0x1929B08
	public void set_DateParseHandling(DateParseHandling value) { }

	// RVA: 0x1929B70 Offset: 0x1925B70 VA: 0x1929B70
	private static void .cctor() { }

	[DebuggerStepThrough]
	// RVA: 0x1929BF8 Offset: 0x1925BF8 VA: 0x1929BF8
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public class JsonTextReader : JsonReader, IJsonLineInfo // TypeDefIndex: 6023
{
	// Fields
	private readonly bool _safeAsync; // 0x72
	private readonly TextReader _reader; // 0x78
	[Nullable(2)]
	private char[] _chars; // 0x80
	private int _charsUsed; // 0x88
	private int _charPos; // 0x8C
	private int _lineStartPos; // 0x90
	private int _lineNumber; // 0x94
	private bool _isEndOfFile; // 0x98
	private StringBuffer _stringBuffer; // 0xA0
	private StringReference _stringReference; // 0xB0
	[Nullable(2)]
	private IArrayPool<char> _arrayPool; // 0xC0
	[Nullable(2)]
	[CompilerGenerated]
	private JsonNameTable <PropertyNameTable>k__BackingField; // 0xC8

	// Properties
	[Nullable(2)]
	public JsonNameTable PropertyNameTable { get; set; }
	public int LineNumber { get; }
	public int LinePosition { get; }

	// Methods

	// RVA: 0x1921CBC Offset: 0x191DCBC VA: 0x1921CBC
	public void .ctor(TextReader reader) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1929C80 Offset: 0x1925C80 VA: 0x1929C80
	public JsonNameTable get_PropertyNameTable() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1929C88 Offset: 0x1925C88 VA: 0x1929C88
	public void set_PropertyNameTable(JsonNameTable value) { }

	// RVA: 0x1929C90 Offset: 0x1925C90 VA: 0x1929C90
	private void EnsureBufferNotEmpty() { }

	// RVA: 0x1929CE4 Offset: 0x1925CE4 VA: 0x1929CE4
	private void SetNewLine(bool hasNextChar) { }

	// RVA: 0x1929D44 Offset: 0x1925D44 VA: 0x1929D44
	private void OnNewLine(int pos) { }

	// RVA: 0x1929D54 Offset: 0x1925D54 VA: 0x1929D54
	private void ParseString(char quote, ReadType readType) { }

	// RVA: 0x192A2C4 Offset: 0x19262C4 VA: 0x192A2C4
	private void ParseReadString(char quote, ReadType readType) { }

	// RVA: 0x192A664 Offset: 0x1926664 VA: 0x192A664
	private static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count) { }

	// RVA: 0x1929D9C Offset: 0x1925D9C VA: 0x1929D9C
	private void ShiftBufferIfNeeded() { }

	// RVA: 0x192A678 Offset: 0x1926678 VA: 0x192A678
	private int ReadData(bool append) { }

	// RVA: 0x192A710 Offset: 0x1926710 VA: 0x192A710
	private void PrepareBufferForReadData(bool append, int charsRequired) { }

	// RVA: 0x192A680 Offset: 0x1926680 VA: 0x192A680
	private int ReadData(bool append, int charsRequired) { }

	// RVA: 0x192A8CC Offset: 0x19268CC VA: 0x192A8CC
	private bool EnsureChars(int relativePosition, bool append) { }

	// RVA: 0x192A8EC Offset: 0x19268EC VA: 0x192A8EC
	private bool ReadChars(int relativePosition, bool append) { }

	// RVA: 0x192A95C Offset: 0x192695C VA: 0x192A95C Slot: 10
	public override bool Read() { }

	// RVA: 0x192B820 Offset: 0x1927820 VA: 0x192B820 Slot: 11
	public override Nullable<int> ReadAsInt32() { }

	// RVA: 0x192BCCC Offset: 0x1927CCC VA: 0x192BCCC Slot: 17
	public override Nullable<DateTime> ReadAsDateTime() { }

	[NullableContext(2)]
	// RVA: 0x192C290 Offset: 0x1928290 VA: 0x192C290 Slot: 12
	public override string ReadAsString() { }

	[NullableContext(2)]
	// RVA: 0x192C2C4 Offset: 0x19282C4 VA: 0x192C2C4 Slot: 13
	public override byte[] ReadAsBytes() { }

	[NullableContext(2)]
	// RVA: 0x192BD90 Offset: 0x1927D90 VA: 0x192BD90
	private object ReadStringValue(ReadType readType) { }

	[NullableContext(2)]
	// RVA: 0x192CB40 Offset: 0x1928B40 VA: 0x192CB40
	private object FinishReadQuotedStringValue(ReadType readType) { }

	// RVA: 0x192C8D8 Offset: 0x19288D8 VA: 0x192C8D8
	private JsonReaderException CreateUnexpectedCharacterException(char c) { }

	// RVA: 0x192D00C Offset: 0x192900C VA: 0x192D00C Slot: 15
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x192C874 Offset: 0x1928874 VA: 0x192C874
	private void ProcessValueComma() { }

	[NullableContext(2)]
	// RVA: 0x192B8E4 Offset: 0x19278E4 VA: 0x192B8E4
	private object ReadNumberValue(ReadType readType) { }

	[NullableContext(2)]
	// RVA: 0x192D5AC Offset: 0x19295AC VA: 0x192D5AC
	private object FinishReadQuotedNumber(ReadType readType) { }

	// RVA: 0x192D73C Offset: 0x192973C VA: 0x192D73C Slot: 18
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x192D818 Offset: 0x1929818 VA: 0x192D818 Slot: 16
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x192D8F4 Offset: 0x19298F4 VA: 0x192D8F4 Slot: 14
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x192C7A4 Offset: 0x19287A4 VA: 0x192C7A4
	private void HandleNull() { }

	// RVA: 0x192C9F8 Offset: 0x19289F8 VA: 0x192C9F8
	private void ReadFinished() { }

	// RVA: 0x192C754 Offset: 0x1928754 VA: 0x192C754
	private bool ReadNullChar() { }

	// RVA: 0x192AB78 Offset: 0x1926B78 VA: 0x192AB78
	private void EnsureBuffer() { }

	// RVA: 0x1929E5C Offset: 0x1925E5C VA: 0x1929E5C
	private void ReadStringIntoBuffer(char quote) { }

	// RVA: 0x192DAF4 Offset: 0x1929AF4 VA: 0x192DAF4
	private void FinishReadStringIntoBuffer(int charPos, int initialPosition, int lastWritePosition) { }

	// RVA: 0x192DAA4 Offset: 0x1929AA4 VA: 0x192DAA4
	private void WriteCharToBuffer(char writeChar, int lastWritePosition, int writeToPosition) { }

	// RVA: 0x192DB98 Offset: 0x1929B98 VA: 0x192DB98
	private char ConvertUnicode(bool enoughChars) { }

	// RVA: 0x192DA64 Offset: 0x1929A64 VA: 0x192DA64
	private char ParseUnicode() { }

	// RVA: 0x192DCEC Offset: 0x1929CEC VA: 0x192DCEC
	private void ReadNumberIntoBuffer() { }

	// RVA: 0x192DD70 Offset: 0x1929D70 VA: 0x192DD70
	private bool ReadNumberCharIntoBuffer(char currentChar, int charPos) { }

	// RVA: 0x192DED4 Offset: 0x1929ED4 VA: 0x192DED4
	private void ClearRecentString() { }

	// RVA: 0x192B1F0 Offset: 0x19271F0 VA: 0x192B1F0
	private bool ParsePostValue(bool ignoreComments) { }

	// RVA: 0x192B080 Offset: 0x1927080 VA: 0x192B080
	private bool ParseObject() { }

	// RVA: 0x192DEE0 Offset: 0x1929EE0 VA: 0x192DEE0
	private bool ParseProperty() { }

	// RVA: 0x192E108 Offset: 0x192A108 VA: 0x192E108
	private bool ValidIdentifierChar(char value) { }

	// RVA: 0x192E15C Offset: 0x192A15C VA: 0x192E15C
	private void ParseUnquotedProperty() { }

	// RVA: 0x192E24C Offset: 0x192A24C VA: 0x192E24C
	private bool ReadUnquotedPropertyReportIfDone(char currentChar, int initialPosition) { }

	// RVA: 0x192ABD8 Offset: 0x1926BD8 VA: 0x192ABD8
	private bool ParseValue() { }

	// RVA: 0x192C9DC Offset: 0x19289DC VA: 0x192C9DC
	private void ProcessLineFeed() { }

	// RVA: 0x192C994 Offset: 0x1928994 VA: 0x192C994
	private void ProcessCarriageReturn(bool append) { }

	// RVA: 0x192B498 Offset: 0x1927498 VA: 0x192B498
	private void EatWhitespace() { }

	// RVA: 0x192E52C Offset: 0x192A52C VA: 0x192E52C
	private void ParseConstructor() { }

	// RVA: 0x192CE00 Offset: 0x1928E00 VA: 0x192CE00
	private void ParseNumber(ReadType readType) { }

	// RVA: 0x192E8F8 Offset: 0x192A8F8 VA: 0x192E8F8
	private void ParseReadNumber(ReadType readType, char firstChar, int initialPosition) { }

	// RVA: 0x192F968 Offset: 0x192B968 VA: 0x192F968
	private JsonReaderException ThrowReaderError(string message, Exception ex) { }

	// RVA: 0x192F9D4 Offset: 0x192B9D4 VA: 0x192F9D4
	private static object BigIntegerParse(string number, CultureInfo culture) { }

	// RVA: 0x192B58C Offset: 0x192758C VA: 0x192B58C
	private void ParseComment(bool setToken) { }

	// RVA: 0x192FA5C Offset: 0x192BA5C VA: 0x192FA5C
	private void EndComment(bool setToken, int initialPosition, int endPosition) { }

	// RVA: 0x192FA9C Offset: 0x192BA9C VA: 0x192FA9C
	private bool MatchValue(string value) { }

	// RVA: 0x192FAF8 Offset: 0x192BAF8 VA: 0x192FAF8
	private bool MatchValue(bool enoughChars, string value) { }

	// RVA: 0x192CE68 Offset: 0x1928E68 VA: 0x192CE68
	private bool MatchValueWithTrailingSeparator(string value) { }

	// RVA: 0x192FBD0 Offset: 0x192BBD0 VA: 0x192FBD0
	private bool IsSeparator(char c) { }

	// RVA: 0x192E37C Offset: 0x192A37C VA: 0x192E37C
	private void ParseTrue() { }

	// RVA: 0x192D9B8 Offset: 0x19299B8 VA: 0x192D9B8
	private void ParseNull() { }

	// RVA: 0x192E84C Offset: 0x192A84C VA: 0x192E84C
	private void ParseUndefined() { }

	// RVA: 0x192E454 Offset: 0x192A454 VA: 0x192E454
	private void ParseFalse() { }

	// RVA: 0x192CD80 Offset: 0x1928D80 VA: 0x192CD80
	private object ParseNumberNegativeInfinity(ReadType readType) { }

	// RVA: 0x192FD18 Offset: 0x192BD18 VA: 0x192FD18
	private object ParseNumberNegativeInfinity(ReadType readType, bool matched) { }

	// RVA: 0x192CF0C Offset: 0x1928F0C VA: 0x192CF0C
	private object ParseNumberPositiveInfinity(ReadType readType) { }

	// RVA: 0x192FE60 Offset: 0x192BE60 VA: 0x192FE60
	private object ParseNumberPositiveInfinity(ReadType readType, bool matched) { }

	// RVA: 0x192CF8C Offset: 0x1928F8C VA: 0x192CF8C
	private object ParseNumberNaN(ReadType readType) { }

	// RVA: 0x192FFA8 Offset: 0x192BFA8 VA: 0x192FFA8
	private object ParseNumberNaN(ReadType readType, bool matched) { }

	// RVA: 0x19300F0 Offset: 0x192C0F0 VA: 0x19300F0 Slot: 20
	public override void Close() { }

	// RVA: 0x1930170 Offset: 0x192C170 VA: 0x1930170 Slot: 21
	public bool HasLineInfo() { }

	// RVA: 0x1930178 Offset: 0x192C178 VA: 0x1930178 Slot: 22
	public int get_LineNumber() { }

	// RVA: 0x19301C0 Offset: 0x192C1C0 VA: 0x19301C0 Slot: 23
	public int get_LinePosition() { }
}

// Namespace: Newtonsoft.Json
internal enum ReadType // TypeDefIndex: 6024
{
	// Fields
	public int value__; // 0x0
	public const ReadType Read = 0;
	public const ReadType ReadAsInt32 = 1;
	public const ReadType ReadAsInt64 = 2;
	public const ReadType ReadAsBytes = 3;
	public const ReadType ReadAsString = 4;
	public const ReadType ReadAsDecimal = 5;
	public const ReadType ReadAsDateTime = 6;
	public const ReadType ReadAsDateTimeOffset = 7;
	public const ReadType ReadAsDouble = 8;
	public const ReadType ReadAsBoolean = 9;
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public class JsonTextWriter : JsonWriter // TypeDefIndex: 6025
{
	// Fields
	private readonly bool _safeAsync; // 0x60
	private readonly TextWriter _writer; // 0x68
	[Nullable(2)]
	private Base64Encoder _base64Encoder; // 0x70
	private char _indentChar; // 0x78
	private int _indentation; // 0x7C
	private char _quoteChar; // 0x80
	private bool _quoteName; // 0x82
	[Nullable(2)]
	private bool[] _charEscapeFlags; // 0x88
	[Nullable(2)]
	private char[] _writeBuffer; // 0x90
	[Nullable(2)]
	private IArrayPool<char> _arrayPool; // 0x98
	[Nullable(2)]
	private char[] _indentChars; // 0xA0

	// Properties
	private Base64Encoder Base64Encoder { get; }
	public char QuoteChar { get; }

	// Methods

	// RVA: 0x19301CC Offset: 0x192C1CC VA: 0x19301CC
	private Base64Encoder get_Base64Encoder() { }

	// RVA: 0x1930250 Offset: 0x192C250 VA: 0x1930250
	public char get_QuoteChar() { }

	// RVA: 0x19218A0 Offset: 0x191D8A0 VA: 0x19218A0
	public void .ctor(TextWriter textWriter) { }

	// RVA: 0x19302F8 Offset: 0x192C2F8 VA: 0x19302F8 Slot: 6
	public override void Close() { }

	// RVA: 0x193032C Offset: 0x192C32C VA: 0x193032C
	private void CloseBufferAndWriter() { }

	// RVA: 0x1930390 Offset: 0x192C390 VA: 0x1930390 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0x1930408 Offset: 0x192C408 VA: 0x1930408 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0x1930440 Offset: 0x192C440 VA: 0x1930440 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x19304E8 Offset: 0x192C4E8 VA: 0x19304E8 Slot: 17
	protected override void WriteEnd(JsonToken token) { }

	// RVA: 0x19305DC Offset: 0x192C5DC VA: 0x19305DC Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0x1930714 Offset: 0x192C714 VA: 0x1930714 Slot: 14
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0x19307E4 Offset: 0x192C7E4 VA: 0x19307E4 Slot: 5
	internal override void OnStringEscapeHandlingChanged() { }

	// RVA: 0x1930284 Offset: 0x192C284 VA: 0x1930284
	private void UpdateCharEscapeFlags() { }

	// RVA: 0x19307E8 Offset: 0x192C7E8 VA: 0x19307E8 Slot: 18
	protected override void WriteIndent() { }

	// RVA: 0x193095C Offset: 0x192C95C VA: 0x193095C
	private int SetIndentChars() { }

	// RVA: 0x1930A50 Offset: 0x192CA50 VA: 0x1930A50 Slot: 19
	protected override void WriteValueDelimiter() { }

	// RVA: 0x1930A74 Offset: 0x192CA74 VA: 0x1930A74 Slot: 20
	protected override void WriteIndentSpace() { }

	// RVA: 0x1930A98 Offset: 0x192CA98 VA: 0x1930A98
	private void WriteValueInternal(string value, JsonToken token) { }

	[NullableContext(2)]
	// RVA: 0x1930AB8 Offset: 0x192CAB8 VA: 0x1930AB8 Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0x1930D28 Offset: 0x192CD28 VA: 0x1930D28 Slot: 21
	public override void WriteNull() { }

	// RVA: 0x1930DBC Offset: 0x192CDBC VA: 0x1930DBC Slot: 22
	public override void WriteUndefined() { }

	[NullableContext(2)]
	// RVA: 0x1930E50 Offset: 0x192CE50 VA: 0x1930E50 Slot: 23
	public override void WriteRaw(string json) { }

	[NullableContext(2)]
	// RVA: 0x1930E74 Offset: 0x192CE74 VA: 0x1930E74 Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0x1930658 Offset: 0x192C658 VA: 0x1930658
	private void WriteEscapedString(string value, bool quote) { }

	// RVA: 0x1930F74 Offset: 0x192CF74 VA: 0x1930F74 Slot: 26
	public override void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x1931000 Offset: 0x192D000 VA: 0x1931000 Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0x193108C Offset: 0x192D08C VA: 0x193108C Slot: 28
	public override void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x19310D0 Offset: 0x192D0D0 VA: 0x19310D0 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0x1931188 Offset: 0x192D188 VA: 0x1931188 Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0x1931240 Offset: 0x192D240 VA: 0x1931240 Slot: 47
	public override void WriteValue(Nullable<float> value) { }

	// RVA: 0x1931340 Offset: 0x192D340 VA: 0x1931340 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0x19313F8 Offset: 0x192D3F8 VA: 0x19313F8 Slot: 48
	public override void WriteValue(Nullable<double> value) { }

	// RVA: 0x1931504 Offset: 0x192D504 VA: 0x1931504 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0x19315A0 Offset: 0x192D5A0 VA: 0x19315A0 Slot: 33
	public override void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x19315E4 Offset: 0x192D5E4 VA: 0x19315E4 Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0x1931628 Offset: 0x192D628 VA: 0x1931628 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0x19316C4 Offset: 0x192D6C4 VA: 0x19316C4 Slot: 36
	public override void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1931708 Offset: 0x192D708 VA: 0x1931708 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0x193174C Offset: 0x192D74C VA: 0x193174C Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0x19317F8 Offset: 0x192D7F8 VA: 0x19317F8 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0x193198C Offset: 0x192D98C VA: 0x193198C
	private int WriteValueToBuffer(DateTime value) { }

	[NullableContext(2)]
	// RVA: 0x1931AA0 Offset: 0x192DAA0 VA: 0x1931AA0 Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0x1931B68 Offset: 0x192DB68 VA: 0x1931B68 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x1931CD0 Offset: 0x192DCD0 VA: 0x1931CD0
	private int WriteValueToBuffer(DateTimeOffset value) { }

	// RVA: 0x1931E3C Offset: 0x192DE3C VA: 0x1931E3C Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0x1931F48 Offset: 0x192DF48 VA: 0x1931F48 Slot: 42
	public override void WriteValue(TimeSpan value) { }

	[NullableContext(2)]
	// RVA: 0x193206C Offset: 0x192E06C VA: 0x193206C Slot: 61
	public override void WriteValue(Uri value) { }

	[NullableContext(2)]
	// RVA: 0x193213C Offset: 0x192E13C VA: 0x193213C Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0x1930F28 Offset: 0x192CF28 VA: 0x1930F28
	private void EnsureWriteBuffer() { }

	// RVA: 0x1931044 Offset: 0x192D044 VA: 0x1931044
	private void WriteIntegerValue(long value) { }

	// RVA: 0x1931118 Offset: 0x192D118 VA: 0x1931118
	private void WriteIntegerValue(ulong value, bool negative) { }

	// RVA: 0x19321FC Offset: 0x192E1FC VA: 0x19321FC
	private int WriteNumberToBuffer(ulong value, bool negative) { }

	// RVA: 0x1930FB8 Offset: 0x192CFB8 VA: 0x1930FB8
	private void WriteIntegerValue(int value) { }

	// RVA: 0x1932370 Offset: 0x192E370 VA: 0x1932370
	private void WriteIntegerValue(uint value, bool negative) { }

	// RVA: 0x19322C8 Offset: 0x192E2C8 VA: 0x19322C8
	private int WriteNumberToBuffer(uint value, bool negative) { }
}

// Namespace: Newtonsoft.Json
public enum JsonToken // TypeDefIndex: 6026
{
	// Fields
	public int value__; // 0x0
	public const JsonToken None = 0;
	public const JsonToken StartObject = 1;
	public const JsonToken StartArray = 2;
	public const JsonToken StartConstructor = 3;
	public const JsonToken PropertyName = 4;
	public const JsonToken Comment = 5;
	public const JsonToken Raw = 6;
	public const JsonToken Integer = 7;
	public const JsonToken Float = 8;
	public const JsonToken String = 9;
	public const JsonToken Boolean = 10;
	public const JsonToken Null = 11;
	public const JsonToken Undefined = 12;
	public const JsonToken EndObject = 13;
	public const JsonToken EndArray = 14;
	public const JsonToken EndConstructor = 15;
	public const JsonToken Date = 16;
	public const JsonToken Bytes = 17;
}

// Namespace: 
[NullableContext(0)]
internal enum JsonWriter.State // TypeDefIndex: 6027
{
	// Fields
	public int value__; // 0x0
	public const JsonWriter.State Start = 0;
	public const JsonWriter.State Property = 1;
	public const JsonWriter.State ObjectStart = 2;
	public const JsonWriter.State Object = 3;
	public const JsonWriter.State ArrayStart = 4;
	public const JsonWriter.State Array = 5;
	public const JsonWriter.State ConstructorStart = 6;
	public const JsonWriter.State Constructor = 7;
	public const JsonWriter.State Closed = 8;
	public const JsonWriter.State Error = 9;
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
public abstract class JsonWriter : IDisposable // TypeDefIndex: 6028
{
	// Fields
	private static readonly JsonWriter.State[][] StateArray; // 0x0
	internal static readonly JsonWriter.State[][] StateArrayTemplate; // 0x8
	[Nullable(2)]
	private List<JsonPosition> _stack; // 0x10
	private JsonPosition _currentPosition; // 0x18
	private JsonWriter.State _currentState; // 0x30
	private Formatting _formatting; // 0x34
	[CompilerGenerated]
	private bool <CloseOutput>k__BackingField; // 0x38
	[CompilerGenerated]
	private bool <AutoCompleteOnClose>k__BackingField; // 0x39
	private DateFormatHandling _dateFormatHandling; // 0x3C
	private DateTimeZoneHandling _dateTimeZoneHandling; // 0x40
	private StringEscapeHandling _stringEscapeHandling; // 0x44
	private FloatFormatHandling _floatFormatHandling; // 0x48
	[Nullable(2)]
	private string _dateFormatString; // 0x50
	[Nullable(2)]
	private CultureInfo _culture; // 0x58

	// Properties
	public bool CloseOutput { get; set; }
	public bool AutoCompleteOnClose { get; set; }
	protected internal int Top { get; }
	public WriteState WriteState { get; }
	internal string ContainerPath { get; }
	public string Path { get; }
	public Formatting Formatting { get; set; }
	public DateFormatHandling DateFormatHandling { get; set; }
	public DateTimeZoneHandling DateTimeZoneHandling { get; set; }
	public StringEscapeHandling StringEscapeHandling { get; set; }
	public FloatFormatHandling FloatFormatHandling { get; set; }
	[Nullable(2)]
	public string DateFormatString { get; set; }
	public CultureInfo Culture { get; set; }

	// Methods

	// RVA: 0x19323E0 Offset: 0x192E3E0 VA: 0x19323E0
	internal static JsonWriter.State[][] BuildStateArray() { }

	// RVA: 0x193265C Offset: 0x192E65C VA: 0x193265C
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x193297C Offset: 0x192E97C VA: 0x193297C
	public bool get_CloseOutput() { }

	[CompilerGenerated]
	// RVA: 0x1932984 Offset: 0x192E984 VA: 0x1932984
	public void set_CloseOutput(bool value) { }

	[CompilerGenerated]
	// RVA: 0x193298C Offset: 0x192E98C VA: 0x193298C
	public bool get_AutoCompleteOnClose() { }

	[CompilerGenerated]
	// RVA: 0x1932994 Offset: 0x192E994 VA: 0x1932994
	public void set_AutoCompleteOnClose(bool value) { }

	// RVA: 0x193090C Offset: 0x192C90C VA: 0x193090C
	protected internal int get_Top() { }

	// RVA: 0x19329A4 Offset: 0x192E9A4 VA: 0x19329A4
	public WriteState get_WriteState() { }

	// RVA: 0x1932A48 Offset: 0x192EA48 VA: 0x1932A48
	internal string get_ContainerPath() { }

	// RVA: 0x1932ADC Offset: 0x192EADC VA: 0x1932ADC
	public string get_Path() { }

	// RVA: 0x1932BE4 Offset: 0x192EBE4 VA: 0x1932BE4
	public Formatting get_Formatting() { }

	// RVA: 0x1921A08 Offset: 0x191DA08 VA: 0x1921A08
	public void set_Formatting(Formatting value) { }

	// RVA: 0x1932BEC Offset: 0x192EBEC VA: 0x1932BEC
	public DateFormatHandling get_DateFormatHandling() { }

	// RVA: 0x1929680 Offset: 0x1925680 VA: 0x1929680
	public void set_DateFormatHandling(DateFormatHandling value) { }

	// RVA: 0x1932BF4 Offset: 0x192EBF4 VA: 0x1932BF4
	public DateTimeZoneHandling get_DateTimeZoneHandling() { }

	// RVA: 0x19296DC Offset: 0x19256DC VA: 0x19296DC
	public void set_DateTimeZoneHandling(DateTimeZoneHandling value) { }

	// RVA: 0x1932BFC Offset: 0x192EBFC VA: 0x1932BFC
	public StringEscapeHandling get_StringEscapeHandling() { }

	// RVA: 0x1929794 Offset: 0x1925794 VA: 0x1929794
	public void set_StringEscapeHandling(StringEscapeHandling value) { }

	// RVA: 0x1932C04 Offset: 0x192EC04 VA: 0x1932C04 Slot: 5
	internal virtual void OnStringEscapeHandlingChanged() { }

	// RVA: 0x1932C08 Offset: 0x192EC08 VA: 0x1932C08
	public FloatFormatHandling get_FloatFormatHandling() { }

	// RVA: 0x1929738 Offset: 0x1925738 VA: 0x1929738
	public void set_FloatFormatHandling(FloatFormatHandling value) { }

	[NullableContext(2)]
	// RVA: 0x1932C10 Offset: 0x192EC10 VA: 0x1932C10
	public string get_DateFormatString() { }

	[NullableContext(2)]
	// RVA: 0x1932C18 Offset: 0x192EC18 VA: 0x1932C18
	public void set_DateFormatString(string value) { }

	// RVA: 0x19297FC Offset: 0x19257FC VA: 0x19297FC
	public CultureInfo get_Culture() { }

	// RVA: 0x1932C20 Offset: 0x192EC20 VA: 0x1932C20
	public void set_Culture(CultureInfo value) { }

	// RVA: 0x1930258 Offset: 0x192C258 VA: 0x1930258
	protected void .ctor() { }

	// RVA: 0x1932C28 Offset: 0x192EC28 VA: 0x1932C28
	internal void UpdateScopeWithFinishedValue() { }

	// RVA: 0x1932C40 Offset: 0x192EC40 VA: 0x1932C40
	private void Push(JsonContainerType value) { }

	// RVA: 0x1932DD4 Offset: 0x192EDD4 VA: 0x1932DD4
	private JsonContainerType Pop() { }

	// RVA: 0x193299C Offset: 0x192E99C VA: 0x193299C
	private JsonContainerType Peek() { }

	// RVA: 0x193031C Offset: 0x192C31C VA: 0x193031C Slot: 6
	public virtual void Close() { }

	// RVA: 0x1932EEC Offset: 0x192EEEC VA: 0x1932EEC Slot: 7
	public virtual void WriteStartObject() { }

	// RVA: 0x1932EF8 Offset: 0x192EEF8 VA: 0x1932EF8 Slot: 8
	public virtual void WriteEndObject() { }

	// RVA: 0x1932F04 Offset: 0x192EF04 VA: 0x1932F04 Slot: 9
	public virtual void WriteStartArray() { }

	// RVA: 0x1932F10 Offset: 0x192EF10 VA: 0x1932F10 Slot: 10
	public virtual void WriteEndArray() { }

	// RVA: 0x1932F18 Offset: 0x192EF18 VA: 0x1932F18 Slot: 11
	public virtual void WriteStartConstructor(string name) { }

	// RVA: 0x1932F24 Offset: 0x192EF24 VA: 0x1932F24 Slot: 12
	public virtual void WriteEndConstructor() { }

	// RVA: 0x1932F2C Offset: 0x192EF2C VA: 0x1932F2C Slot: 13
	public virtual void WritePropertyName(string name) { }

	// RVA: 0x1932F4C Offset: 0x192EF4C VA: 0x1932F4C Slot: 14
	public virtual void WritePropertyName(string name, bool escape) { }

	// RVA: 0x1932F5C Offset: 0x192EF5C VA: 0x1932F5C Slot: 15
	public virtual void WriteEnd() { }

	// RVA: 0x193303C Offset: 0x192F03C VA: 0x193303C
	public void WriteToken(JsonReader reader) { }

	// RVA: 0x1933044 Offset: 0x192F044 VA: 0x1933044
	public void WriteToken(JsonReader reader, bool writeChildren) { }

	[NullableContext(2)]
	// RVA: 0x19330C4 Offset: 0x192F0C4 VA: 0x19330C4
	public void WriteToken(JsonToken token, object value) { }

	// RVA: 0x1933778 Offset: 0x192F778 VA: 0x1933778 Slot: 16
	internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments) { }

	// RVA: 0x1933A8C Offset: 0x192FA8C VA: 0x1933A8C
	private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth) { }

	// RVA: 0x193395C Offset: 0x192F95C VA: 0x193395C
	private int CalculateWriteTokenInitialDepth(JsonReader reader) { }

	// RVA: 0x1933AF8 Offset: 0x192FAF8 VA: 0x1933AF8
	private int CalculateWriteTokenFinalDepth(JsonReader reader) { }

	// RVA: 0x19339C0 Offset: 0x192F9C0 VA: 0x19339C0
	private void WriteConstructorDate(JsonReader reader) { }

	// RVA: 0x1932F64 Offset: 0x192EF64 VA: 0x1932F64
	private void WriteEnd(JsonContainerType type) { }

	// RVA: 0x1932EAC Offset: 0x192EEAC VA: 0x1932EAC
	private void AutoCompleteAll() { }

	// RVA: 0x1933B58 Offset: 0x192FB58 VA: 0x1933B58
	private JsonToken GetCloseTokenForType(JsonContainerType type) { }

	// RVA: 0x1933BF4 Offset: 0x192FBF4 VA: 0x1933BF4
	private void AutoCompleteClose(JsonContainerType type) { }

	// RVA: 0x1933CB0 Offset: 0x192FCB0 VA: 0x1933CB0
	private int CalculateLevelsToComplete(JsonContainerType type) { }

	// RVA: 0x1933DA8 Offset: 0x192FDA8 VA: 0x1933DA8
	private void UpdateCurrentState() { }

	// RVA: 0x1933E58 Offset: 0x192FE58 VA: 0x1933E58 Slot: 17
	protected virtual void WriteEnd(JsonToken token) { }

	// RVA: 0x1933E5C Offset: 0x192FE5C VA: 0x1933E5C Slot: 18
	protected virtual void WriteIndent() { }

	// RVA: 0x1933E60 Offset: 0x192FE60 VA: 0x1933E60 Slot: 19
	protected virtual void WriteValueDelimiter() { }

	// RVA: 0x1933E64 Offset: 0x192FE64 VA: 0x1933E64 Slot: 20
	protected virtual void WriteIndentSpace() { }

	// RVA: 0x1933E68 Offset: 0x192FE68 VA: 0x1933E68
	internal void AutoComplete(JsonToken tokenBeingWritten) { }

	// RVA: 0x1934078 Offset: 0x1930078 VA: 0x1934078 Slot: 21
	public virtual void WriteNull() { }

	// RVA: 0x1934094 Offset: 0x1930094 VA: 0x1934094 Slot: 22
	public virtual void WriteUndefined() { }

	[NullableContext(2)]
	// RVA: 0x19340B0 Offset: 0x19300B0 VA: 0x19340B0 Slot: 23
	public virtual void WriteRaw(string json) { }

	[NullableContext(2)]
	// RVA: 0x19340B4 Offset: 0x19300B4 VA: 0x19340B4 Slot: 24
	public virtual void WriteRawValue(string json) { }

	[NullableContext(2)]
	// RVA: 0x1934104 Offset: 0x1930104 VA: 0x1934104 Slot: 25
	public virtual void WriteValue(string value) { }

	// RVA: 0x1934120 Offset: 0x1930120 VA: 0x1934120 Slot: 26
	public virtual void WriteValue(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x193413C Offset: 0x193013C VA: 0x193413C Slot: 27
	public virtual void WriteValue(uint value) { }

	// RVA: 0x1934158 Offset: 0x1930158 VA: 0x1934158 Slot: 28
	public virtual void WriteValue(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x1934174 Offset: 0x1930174 VA: 0x1934174 Slot: 29
	public virtual void WriteValue(ulong value) { }

	// RVA: 0x1934190 Offset: 0x1930190 VA: 0x1934190 Slot: 30
	public virtual void WriteValue(float value) { }

	// RVA: 0x19341AC Offset: 0x19301AC VA: 0x19341AC Slot: 31
	public virtual void WriteValue(double value) { }

	// RVA: 0x19341C8 Offset: 0x19301C8 VA: 0x19341C8 Slot: 32
	public virtual void WriteValue(bool value) { }

	// RVA: 0x19341E4 Offset: 0x19301E4 VA: 0x19341E4 Slot: 33
	public virtual void WriteValue(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x1934200 Offset: 0x1930200 VA: 0x1934200 Slot: 34
	public virtual void WriteValue(ushort value) { }

	// RVA: 0x193421C Offset: 0x193021C VA: 0x193421C Slot: 35
	public virtual void WriteValue(char value) { }

	// RVA: 0x1934238 Offset: 0x1930238 VA: 0x1934238 Slot: 36
	public virtual void WriteValue(byte value) { }

	[CLSCompliant(False)]
	// RVA: 0x1934254 Offset: 0x1930254 VA: 0x1934254 Slot: 37
	public virtual void WriteValue(sbyte value) { }

	// RVA: 0x1934270 Offset: 0x1930270 VA: 0x1934270 Slot: 38
	public virtual void WriteValue(Decimal value) { }

	// RVA: 0x193428C Offset: 0x193028C VA: 0x193428C Slot: 39
	public virtual void WriteValue(DateTime value) { }

	// RVA: 0x19342A8 Offset: 0x19302A8 VA: 0x19342A8 Slot: 40
	public virtual void WriteValue(DateTimeOffset value) { }

	// RVA: 0x19342C4 Offset: 0x19302C4 VA: 0x19342C4 Slot: 41
	public virtual void WriteValue(Guid value) { }

	// RVA: 0x19342E0 Offset: 0x19302E0 VA: 0x19342E0 Slot: 42
	public virtual void WriteValue(TimeSpan value) { }

	// RVA: 0x19342FC Offset: 0x19302FC VA: 0x19342FC Slot: 43
	public virtual void WriteValue(Nullable<int> value) { }

	[CLSCompliant(False)]
	// RVA: 0x1934378 Offset: 0x1930378 VA: 0x1934378 Slot: 44
	public virtual void WriteValue(Nullable<uint> value) { }

	// RVA: 0x19343F4 Offset: 0x19303F4 VA: 0x19343F4 Slot: 45
	public virtual void WriteValue(Nullable<long> value) { }

	[CLSCompliant(False)]
	// RVA: 0x1934480 Offset: 0x1930480 VA: 0x1934480 Slot: 46
	public virtual void WriteValue(Nullable<ulong> value) { }

	// RVA: 0x193450C Offset: 0x193050C VA: 0x193450C Slot: 47
	public virtual void WriteValue(Nullable<float> value) { }

	// RVA: 0x193458C Offset: 0x193058C VA: 0x193458C Slot: 48
	public virtual void WriteValue(Nullable<double> value) { }

	// RVA: 0x1934618 Offset: 0x1930618 VA: 0x1934618 Slot: 49
	public virtual void WriteValue(Nullable<bool> value) { }

	// RVA: 0x193469C Offset: 0x193069C VA: 0x193469C Slot: 50
	public virtual void WriteValue(Nullable<short> value) { }

	[CLSCompliant(False)]
	// RVA: 0x1934718 Offset: 0x1930718 VA: 0x1934718 Slot: 51
	public virtual void WriteValue(Nullable<ushort> value) { }

	// RVA: 0x1934794 Offset: 0x1930794 VA: 0x1934794 Slot: 52
	public virtual void WriteValue(Nullable<char> value) { }

	// RVA: 0x1934810 Offset: 0x1930810 VA: 0x1934810 Slot: 53
	public virtual void WriteValue(Nullable<byte> value) { }

	[CLSCompliant(False)]
	// RVA: 0x193488C Offset: 0x193088C VA: 0x193488C Slot: 54
	public virtual void WriteValue(Nullable<sbyte> value) { }

	// RVA: 0x1934908 Offset: 0x1930908 VA: 0x1934908 Slot: 55
	public virtual void WriteValue(Nullable<Decimal> value) { }

	// RVA: 0x1934988 Offset: 0x1930988 VA: 0x1934988 Slot: 56
	public virtual void WriteValue(Nullable<DateTime> value) { }

	// RVA: 0x1934A14 Offset: 0x1930A14 VA: 0x1934A14 Slot: 57
	public virtual void WriteValue(Nullable<DateTimeOffset> value) { }

	// RVA: 0x1934A94 Offset: 0x1930A94 VA: 0x1934A94 Slot: 58
	public virtual void WriteValue(Nullable<Guid> value) { }

	// RVA: 0x1934B18 Offset: 0x1930B18 VA: 0x1934B18 Slot: 59
	public virtual void WriteValue(Nullable<TimeSpan> value) { }

	[NullableContext(2)]
	// RVA: 0x1934BA4 Offset: 0x1930BA4 VA: 0x1934BA4 Slot: 60
	public virtual void WriteValue(byte[] value) { }

	[NullableContext(2)]
	// RVA: 0x1934BD4 Offset: 0x1930BD4 VA: 0x1934BD4 Slot: 61
	public virtual void WriteValue(Uri value) { }

	[NullableContext(2)]
	// RVA: 0x1930BF4 Offset: 0x192CBF4 VA: 0x1930BF4 Slot: 62
	public virtual void WriteValue(object value) { }

	[NullableContext(2)]
	// RVA: 0x1935CB4 Offset: 0x1931CB4 VA: 0x1935CB4 Slot: 63
	public virtual void WriteComment(string text) { }

	// RVA: 0x1935CBC Offset: 0x1931CBC VA: 0x1935CBC Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1935D2C Offset: 0x1931D2C VA: 0x1935D2C Slot: 64
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1934D38 Offset: 0x1930D38 VA: 0x1934D38
	internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value) { }

	// RVA: 0x1935D4C Offset: 0x1931D4C VA: 0x1935D4C
	private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value) { }

	// RVA: 0x1934C80 Offset: 0x1930C80 VA: 0x1934C80
	private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value) { }

	// RVA: 0x1935ECC Offset: 0x1931ECC VA: 0x1935ECC
	protected void SetWriteState(JsonToken token, object value) { }

	// RVA: 0x1932F00 Offset: 0x192EF00 VA: 0x1932F00
	internal void InternalWriteEnd(JsonContainerType container) { }

	// RVA: 0x1930638 Offset: 0x192C638 VA: 0x1930638
	internal void InternalWritePropertyName(string name) { }

	// RVA: 0x1930E70 Offset: 0x192CE70 VA: 0x1930E70
	internal void InternalWriteRaw() { }

	// RVA: 0x19303C8 Offset: 0x192C3C8 VA: 0x19303C8
	internal void InternalWriteStart(JsonToken token, JsonContainerType container) { }

	// RVA: 0x1930BDC Offset: 0x192CBDC VA: 0x1930BDC
	internal void InternalWriteValue(JsonToken token) { }

	// RVA: 0x19321F4 Offset: 0x192E1F4 VA: 0x19321F4
	internal void InternalWriteComment() { }
}

// Namespace: Newtonsoft.Json
[NullableContext(1)]
[Nullable(0)]
[Serializable]
public class JsonWriterException : JsonException // TypeDefIndex: 6029
{
	// Fields
	[Nullable(2)]
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; // 0x90

	// Methods

	// RVA: 0x19360A0 Offset: 0x19320A0 VA: 0x19360A0
	public void .ctor() { }

	// RVA: 0x19360A8 Offset: 0x19320A8 VA: 0x19360A8
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x19360B0 Offset: 0x19320B0 VA: 0x19360B0
	public void .ctor(string message, string path, Exception innerException) { }

	// RVA: 0x19360E4 Offset: 0x19320E4 VA: 0x19360E4
	internal static JsonWriterException Create(JsonWriter writer, string message, Exception ex) { }

	// RVA: 0x1936118 Offset: 0x1932118 VA: 0x1936118
	internal static JsonWriterException Create(string path, string message, Exception ex) { }
}

// Namespace: Newtonsoft.Json
public enum MemberSerialization // TypeDefIndex: 6030
{
	// Fields
	public int value__; // 0x0
	public const MemberSerialization OptOut = 0;
	public const MemberSerialization OptIn = 1;
	public const MemberSerialization Fields = 2;
}

// Namespace: Newtonsoft.Json
public enum MetadataPropertyHandling // TypeDefIndex: 6031
{
	// Fields
	public int value__; // 0x0
	public const MetadataPropertyHandling Default = 0;
	public const MetadataPropertyHandling ReadAhead = 1;
	public const MetadataPropertyHandling Ignore = 2;
}

// Namespace: Newtonsoft.Json
public enum MissingMemberHandling // TypeDefIndex: 6032
{
	// Fields
	public int value__; // 0x0
	public const MissingMemberHandling Ignore = 0;
	public const MissingMemberHandling Error = 1;
}

// Namespace: Newtonsoft.Json
public enum NullValueHandling // TypeDefIndex: 6033
{
	// Fields
	public int value__; // 0x0
	public const NullValueHandling Include = 0;
	public const NullValueHandling Ignore = 1;
}

// Namespace: Newtonsoft.Json
public enum ObjectCreationHandling // TypeDefIndex: 6034
{
	// Fields
	public int value__; // 0x0
	public const ObjectCreationHandling Auto = 0;
	public const ObjectCreationHandling Reuse = 1;
	public const ObjectCreationHandling Replace = 2;
}

// Namespace: Newtonsoft.Json
[Flags]
public enum PreserveReferencesHandling // TypeDefIndex: 6035
{
	// Fields
	public int value__; // 0x0
	public const PreserveReferencesHandling None = 0;
	public const PreserveReferencesHandling Objects = 1;
	public const PreserveReferencesHandling Arrays = 2;
	public const PreserveReferencesHandling All = 3;
}

// Namespace: Newtonsoft.Json
public enum ReferenceLoopHandling // TypeDefIndex: 6036
{
	// Fields
	public int value__; // 0x0
	public const ReferenceLoopHandling Error = 0;
	public const ReferenceLoopHandling Ignore = 1;
	public const ReferenceLoopHandling Serialize = 2;
}

// Namespace: Newtonsoft.Json
public enum Required // TypeDefIndex: 6037
{
	// Fields
	public int value__; // 0x0
	public const Required Default = 0;
	public const Required AllowNull = 1;
	public const Required Always = 2;
	public const Required DisallowNull = 3;
}

// Namespace: Newtonsoft.Json
public enum StringEscapeHandling // TypeDefIndex: 6038
{
	// Fields
	public int value__; // 0x0
	public const StringEscapeHandling Default = 0;
	public const StringEscapeHandling EscapeNonAscii = 1;
	public const StringEscapeHandling EscapeHtml = 2;
}

// Namespace: Newtonsoft.Json
public enum TypeNameAssemblyFormatHandling // TypeDefIndex: 6039
{
	// Fields
	public int value__; // 0x0
	public const TypeNameAssemblyFormatHandling Simple = 0;
	public const TypeNameAssemblyFormatHandling Full = 1;
}

// Namespace: Newtonsoft.Json
[Flags]
public enum TypeNameHandling // TypeDefIndex: 6040
{
	// Fields
	public int value__; // 0x0
	public const TypeNameHandling None = 0;
	public const TypeNameHandling Objects = 1;
	public const TypeNameHandling Arrays = 2;
	public const TypeNameHandling All = 3;
	public const TypeNameHandling Auto = 4;
}

// Namespace: Newtonsoft.Json
public enum WriteState // TypeDefIndex: 6041
{
	// Fields
	public int value__; // 0x0
	public const WriteState Error = 0;
	public const WriteState Closed = 1;
	public const WriteState Object = 2;
	public const WriteState Array = 3;
	public const WriteState Constructor = 4;
	public const WriteState Property = 5;
	public const WriteState Start = 6;
}
