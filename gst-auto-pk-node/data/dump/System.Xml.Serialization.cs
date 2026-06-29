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

// Namespace: System.Xml.Serialization
public class CodeIdentifier // TypeDefIndex: 3280
{
	// Fields
	internal static CodeDomProvider csharp; // 0x0

	// Methods

	// RVA: 0x1C758C4 Offset: 0x1C718C4 VA: 0x1C758C4
	public static string MakePascal(string identifier) { }

	// RVA: 0x1C75A70 Offset: 0x1C71A70 VA: 0x1C75A70
	public static string MakeValid(string identifier) { }

	// RVA: 0x1C75C44 Offset: 0x1C71C44 VA: 0x1C75C44
	private static bool IsValidStart(char c) { }

	// RVA: 0x1C75BF4 Offset: 0x1C71BF4 VA: 0x1C75BF4
	private static bool IsValid(char c) { }

	// RVA: 0x1C75C84 Offset: 0x1C71C84 VA: 0x1C75C84
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
public class XmlSerializerNamespaces // TypeDefIndex: 3281
{
	// Fields
	private Hashtable namespaces; // 0x10

	// Properties
	public int Count { get; }
	internal ArrayList NamespaceList { get; }
	internal Hashtable Namespaces { get; set; }

	// Methods

	// RVA: 0x1C75D00 Offset: 0x1C71D00 VA: 0x1C75D00
	public void .ctor() { }

	// RVA: 0x1C75D08 Offset: 0x1C71D08 VA: 0x1C75D08
	public void Add(string prefix, string ns) { }

	// RVA: 0x1C75DBC Offset: 0x1C71DBC VA: 0x1C75DBC
	internal void AddInternal(string prefix, string ns) { }

	// RVA: 0x1C75E68 Offset: 0x1C71E68 VA: 0x1C75E68
	public XmlQualifiedName[] ToArray() { }

	// RVA: 0x1C7634C Offset: 0x1C7234C VA: 0x1C7634C
	public int get_Count() { }

	// RVA: 0x1C75F58 Offset: 0x1C71F58 VA: 0x1C75F58
	internal ArrayList get_NamespaceList() { }

	// RVA: 0x1C75DF8 Offset: 0x1C71DF8 VA: 0x1C75DF8
	internal Hashtable get_Namespaces() { }

	// RVA: 0x1C76370 Offset: 0x1C72370 VA: 0x1C76370
	internal void set_Namespaces(Hashtable value) { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlAttributeEventHandler : MulticastDelegate // TypeDefIndex: 3282
{
	// Methods

	// RVA: 0x1C76378 Offset: 0x1C72378 VA: 0x1C76378
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C76484 Offset: 0x1C72484 VA: 0x1C76484 Slot: 12
	public virtual void Invoke(object sender, XmlAttributeEventArgs e) { }
}

// Namespace: System.Xml.Serialization
public class XmlAttributeEventArgs : EventArgs // TypeDefIndex: 3283
{
	// Fields
	private object o; // 0x10
	private XmlAttribute attr; // 0x18
	private string qnames; // 0x20
	private int lineNumber; // 0x28
	private int linePosition; // 0x2C

	// Methods

	// RVA: 0x1C76498 Offset: 0x1C72498 VA: 0x1C76498
	internal void .ctor(XmlAttribute attr, int lineNumber, int linePosition, object o, string qnames) { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlElementEventHandler : MulticastDelegate // TypeDefIndex: 3284
{
	// Methods

	// RVA: 0x1C76554 Offset: 0x1C72554 VA: 0x1C76554
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C76660 Offset: 0x1C72660 VA: 0x1C76660 Slot: 12
	public virtual void Invoke(object sender, XmlElementEventArgs e) { }
}

// Namespace: System.Xml.Serialization
public class XmlElementEventArgs : EventArgs // TypeDefIndex: 3285
{
	// Fields
	private object o; // 0x10
	private XmlElement elem; // 0x18
	private string qnames; // 0x20
	private int lineNumber; // 0x28
	private int linePosition; // 0x2C

	// Methods

	// RVA: 0x1C76674 Offset: 0x1C72674 VA: 0x1C76674
	internal void .ctor(XmlElement elem, int lineNumber, int linePosition, object o, string qnames) { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlNodeEventHandler : MulticastDelegate // TypeDefIndex: 3286
{
	// Methods

	// RVA: 0x1C76730 Offset: 0x1C72730 VA: 0x1C76730
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C7683C Offset: 0x1C7283C VA: 0x1C7683C Slot: 12
	public virtual void Invoke(object sender, XmlNodeEventArgs e) { }
}

// Namespace: System.Xml.Serialization
public class XmlNodeEventArgs : EventArgs // TypeDefIndex: 3287
{
	// Fields
	private object o; // 0x10
	private XmlNode xmlNode; // 0x18
	private int lineNumber; // 0x20
	private int linePosition; // 0x24

	// Methods

	// RVA: 0x1C76850 Offset: 0x1C72850 VA: 0x1C76850
	internal void .ctor(XmlNode xmlNode, int lineNumber, int linePosition, object o) { }
}

// Namespace: System.Xml.Serialization
public sealed class UnreferencedObjectEventHandler : MulticastDelegate // TypeDefIndex: 3288
{
	// Methods

	// RVA: 0x1C768F0 Offset: 0x1C728F0 VA: 0x1C768F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C769FC Offset: 0x1C729FC VA: 0x1C769FC Slot: 12
	public virtual void Invoke(object sender, UnreferencedObjectEventArgs e) { }
}

// Namespace: System.Xml.Serialization
public class UnreferencedObjectEventArgs : EventArgs // TypeDefIndex: 3289
{
	// Fields
	private object o; // 0x10
	private string id; // 0x18

	// Methods

	// RVA: 0x1C76A10 Offset: 0x1C72A10 VA: 0x1C76A10
	public void .ctor(object o, string id) { }
}

// Namespace: System.Xml.Serialization
public interface IXmlSerializable // TypeDefIndex: 3290
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract XmlSchema GetSchema();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ReadXml(XmlReader reader);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void WriteXml(XmlWriter writer);
}

// Namespace: System.Xml.Serialization
public interface IXmlTextParser // TypeDefIndex: 3291
{
	// Properties
	public abstract bool Normalized { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_Normalized();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Normalized(bool value);
}

// Namespace: System.Xml.Serialization
internal class KeyHelper // TypeDefIndex: 3292
{
	// Methods

	// RVA: 0x1C76A98 Offset: 0x1C72A98 VA: 0x1C76A98
	public static void AddField(StringBuilder sb, int n, string val) { }

	// RVA: 0x1C76AA0 Offset: 0x1C72AA0 VA: 0x1C76AA0
	public static void AddField(StringBuilder sb, int n, string val, string def) { }

	// RVA: 0x1C76B84 Offset: 0x1C72B84 VA: 0x1C76B84
	public static void AddField(StringBuilder sb, int n, bool val) { }

	// RVA: 0x1C76B8C Offset: 0x1C72B8C VA: 0x1C76B8C
	public static void AddField(StringBuilder sb, int n, bool val, bool def) { }

	// RVA: 0x1C76BDC Offset: 0x1C72BDC VA: 0x1C76BDC
	public static void AddField(StringBuilder sb, int n, int val, int def) { }

	// RVA: 0x1C76C94 Offset: 0x1C72C94 VA: 0x1C76C94
	public static void AddField(StringBuilder sb, int n, Type val) { }
}

// Namespace: System.Xml.Serialization
internal class ReflectionHelper // TypeDefIndex: 3293
{
	// Fields
	private Hashtable _clrTypes; // 0x10
	private Hashtable _schemaTypes; // 0x18
	private static readonly ParameterModifier[] empty_modifiers; // 0x0

	// Methods

	// RVA: 0x1C76D74 Offset: 0x1C72D74 VA: 0x1C76D74
	public void RegisterSchemaType(XmlTypeMapping map, string xmlType, string ns) { }

	// RVA: 0x1C76E40 Offset: 0x1C72E40 VA: 0x1C76E40
	public XmlTypeMapping GetRegisteredSchemaType(string xmlType, string ns) { }

	// RVA: 0x1C76F14 Offset: 0x1C72F14 VA: 0x1C76F14
	public void RegisterClrType(XmlTypeMapping map, Type type, string ns) { }

	// RVA: 0x1C77040 Offset: 0x1C73040 VA: 0x1C77040
	public XmlTypeMapping GetRegisteredClrType(Type type, string ns) { }

	// RVA: 0x1C77180 Offset: 0x1C73180 VA: 0x1C77180
	public static void CheckSerializableType(Type type, bool allowPrivateConstructors) { }

	// RVA: 0x1C774BC Offset: 0x1C734BC VA: 0x1C774BC
	public void .ctor() { }

	// RVA: 0x1C7754C Offset: 0x1C7354C VA: 0x1C7754C
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
internal enum SchemaTypes // TypeDefIndex: 3294
{
	// Fields
	public int value__; // 0x0
	public const SchemaTypes NotSet = 0;
	public const SchemaTypes Primitive = 1;
	public const SchemaTypes Enum = 2;
	public const SchemaTypes Array = 3;
	public const SchemaTypes Class = 4;
	public const SchemaTypes XmlSerializable = 5;
	public const SchemaTypes XmlNode = 6;
	public const SchemaTypes Void = 7;
}

// Namespace: System.Xml.Serialization
internal abstract class SerializationSource // TypeDefIndex: 3295
{
	// Fields
	private Type[] includedTypes; // 0x10
	private string namspace; // 0x18
	private bool canBeGenerated; // 0x20

	// Methods

	// RVA: 0x1C775C0 Offset: 0x1C735C0 VA: 0x1C775C0
	public void .ctor(string namspace, Type[] includedTypes) { }

	// RVA: 0x1C7760C Offset: 0x1C7360C VA: 0x1C7760C
	protected bool BaseEquals(SerializationSource other) { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeSerializationSource : SerializationSource // TypeDefIndex: 3296
{
	// Fields
	private string attributeOverridesHash; // 0x28
	private Type type; // 0x30
	private string rootHash; // 0x38

	// Methods

	// RVA: 0x1C776F4 Offset: 0x1C736F4 VA: 0x1C776F4
	public void .ctor(Type type, XmlRootAttribute root, XmlAttributeOverrides attributeOverrides, string namspace, Type[] includedTypes) { }

	// RVA: 0x1C77810 Offset: 0x1C73810 VA: 0x1C77810 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1C778E8 Offset: 0x1C738E8 VA: 0x1C778E8 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Xml.Serialization
[Usage(4, AllowMultiple = False)]
internal class XmlTypeConvertorAttribute : Attribute // TypeDefIndex: 3297
{
	// Fields
	[CompilerGenerated]
	private string <Method>k__BackingField; // 0x10

	// Properties
	public string Method { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1C77904 Offset: 0x1C73904 VA: 0x1C77904
	public string get_Method() { }

	[CompilerGenerated]
	// RVA: 0x1C7790C Offset: 0x1C7390C VA: 0x1C7790C
	private void set_Method(string value) { }

	// RVA: 0x1C77914 Offset: 0x1C73914 VA: 0x1C77914
	public void .ctor(string method) { }
}

// Namespace: System.Xml.Serialization
internal class TypeData // TypeDefIndex: 3298
{
	// Fields
	private Type type; // 0x10
	private string elementName; // 0x18
	private SchemaTypes sType; // 0x20
	private Type listItemType; // 0x28
	private string typeName; // 0x30
	private string fullTypeName; // 0x38
	private TypeData listItemTypeData; // 0x40
	private TypeData mappedType; // 0x48
	private XmlSchemaPatternFacet facet; // 0x50
	private MethodInfo typeConvertor; // 0x58
	private bool hasPublicConstructor; // 0x60
	private bool nullableOverride; // 0x61
	private static string[] keywords; // 0x0

	// Properties
	public string TypeName { get; }
	public string XmlType { get; }
	public Type Type { get; }
	public string FullTypeName { get; }
	public SchemaTypes SchemaType { get; }
	public bool IsListType { get; }
	public bool IsComplexType { get; }
	public bool IsValueType { get; }
	public bool IsNullable { get; set; }
	public TypeData ListItemTypeData { get; }
	public Type ListItemType { get; }
	public bool IsXsdType { get; }
	public bool HasPublicConstructor { get; }

	// Methods

	// RVA: 0x1C77944 Offset: 0x1C73944 VA: 0x1C77944
	public void .ctor(Type type, string elementName, bool isPrimitive) { }

	// RVA: 0x1C77950 Offset: 0x1C73950 VA: 0x1C77950
	public void .ctor(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet) { }

	// RVA: 0x1C77EEC Offset: 0x1C73EEC VA: 0x1C77EEC
	private void LookupTypeConvertor() { }

	// RVA: 0x1C77FA0 Offset: 0x1C73FA0 VA: 0x1C77FA0
	internal void ConvertForAssignment(ref object value) { }

	// RVA: 0x1C78094 Offset: 0x1C74094 VA: 0x1C78094
	public string get_TypeName() { }

	// RVA: 0x1C7809C Offset: 0x1C7409C VA: 0x1C7809C
	public string get_XmlType() { }

	// RVA: 0x1C780A4 Offset: 0x1C740A4 VA: 0x1C780A4
	public Type get_Type() { }

	// RVA: 0x1C780AC Offset: 0x1C740AC VA: 0x1C780AC
	public string get_FullTypeName() { }

	// RVA: 0x1C780B4 Offset: 0x1C740B4 VA: 0x1C780B4
	public SchemaTypes get_SchemaType() { }

	// RVA: 0x1C774AC Offset: 0x1C734AC VA: 0x1C774AC
	public bool get_IsListType() { }

	// RVA: 0x1C780BC Offset: 0x1C740BC VA: 0x1C780BC
	public bool get_IsComplexType() { }

	// RVA: 0x1C780F4 Offset: 0x1C740F4 VA: 0x1C780F4
	public bool get_IsValueType() { }

	// RVA: 0x1C78168 Offset: 0x1C74168 VA: 0x1C78168
	public bool get_IsNullable() { }

	// RVA: 0x1C78270 Offset: 0x1C74270 VA: 0x1C78270
	public void set_IsNullable(bool value) { }

	// RVA: 0x1C77D30 Offset: 0x1C73D30 VA: 0x1C77D30
	public TypeData get_ListItemTypeData() { }

	// RVA: 0x1C78278 Offset: 0x1C74278 VA: 0x1C78278
	public Type get_ListItemType() { }

	// RVA: 0x1C780E4 Offset: 0x1C740E4 VA: 0x1C780E4
	public bool get_IsXsdType() { }

	// RVA: 0x1C78D6C Offset: 0x1C74D6C VA: 0x1C78D6C
	public bool get_HasPublicConstructor() { }

	// RVA: 0x1C78B54 Offset: 0x1C74B54 VA: 0x1C78B54
	public static PropertyInfo GetIndexerProperty(Type collectionType) { }

	// RVA: 0x1C78C58 Offset: 0x1C74C58 VA: 0x1C78C58
	private static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType) { }

	// RVA: 0x1C7896C Offset: 0x1C7496C VA: 0x1C7896C
	internal static Type GetGenericListItemType(Type type) { }

	// RVA: 0x1C78D74 Offset: 0x1C74D74 VA: 0x1C78D74
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
internal sealed class TypeMember // TypeDefIndex: 3299
{
	// Fields
	private Type type; // 0x10
	private string member; // 0x18

	// Methods

	// RVA: 0x1C79D64 Offset: 0x1C75D64 VA: 0x1C79D64
	internal void .ctor(Type type, string member) { }

	// RVA: 0x1C79DA8 Offset: 0x1C75DA8 VA: 0x1C79DA8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C79DF0 Offset: 0x1C75DF0 VA: 0x1C79DF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1C79E60 Offset: 0x1C75E60 VA: 0x1C79E60
	public static bool Equals(TypeMember tm1, TypeMember tm2) { }

	// RVA: 0x1C79EF4 Offset: 0x1C75EF4 VA: 0x1C79EF4 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Xml.Serialization
internal class TypeTranslator // TypeDefIndex: 3300
{
	// Fields
	private static Hashtable nameCache; // 0x0
	private static Hashtable primitiveTypes; // 0x8
	private static Hashtable primitiveArrayTypes; // 0x10
	private static Hashtable nullableTypes; // 0x18

	// Methods

	// RVA: 0x1C79F58 Offset: 0x1C75F58 VA: 0x1C79F58
	private static void .cctor() { }

	// RVA: 0x1C77450 Offset: 0x1C73450 VA: 0x1C77450
	public static TypeData GetTypeData(Type type) { }

	// RVA: 0x1C7C2F4 Offset: 0x1C782F4 VA: 0x1C7C2F4
	public static TypeData GetTypeData(Type runtimeType, string xmlDataType, bool underlyingEnumType = False) { }

	// RVA: 0x1C7CBFC Offset: 0x1C78BFC VA: 0x1C7CBFC
	public static TypeData GetPrimitiveTypeData(string typeName) { }

	// RVA: 0x1C7CC54 Offset: 0x1C78C54 VA: 0x1C7CC54
	public static TypeData GetPrimitiveTypeData(string typeName, bool nullable) { }

	// RVA: 0x1C7CE54 Offset: 0x1C78E54 VA: 0x1C7CE54
	public static TypeData FindPrimitiveTypeData(string typeName) { }

	// RVA: 0x1C77DE8 Offset: 0x1C73DE8 VA: 0x1C77DE8
	public static string GetArrayName(string elemName) { }

	// RVA: 0x1C7CF14 Offset: 0x1C78F14 VA: 0x1C7CF14
	public static void ParseArrayType(string arrayType, out string type, out string ns, out string dimensions) { }
}

// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlAnyAttributeAttribute : Attribute // TypeDefIndex: 3301
{
	// Methods

	// RVA: 0x1C7D0A0 Offset: 0x1C790A0 VA: 0x1C7D0A0
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = True)]
public class XmlAnyElementAttribute : Attribute // TypeDefIndex: 3302
{
	// Fields
	private string elementName; // 0x10
	private string ns; // 0x18
	private int order; // 0x20

	// Properties
	public string Name { get; }
	public string Namespace { get; }
	public int Order { get; }

	// Methods

	// RVA: 0x1C7D0A8 Offset: 0x1C790A8 VA: 0x1C7D0A8
	public void .ctor() { }

	// RVA: 0x1C7D0B8 Offset: 0x1C790B8 VA: 0x1C7D0B8
	public string get_Name() { }

	// RVA: 0x1C7D0DC Offset: 0x1C790DC VA: 0x1C7D0DC
	public string get_Namespace() { }

	// RVA: 0x1C7D0E4 Offset: 0x1C790E4 VA: 0x1C7D0E4
	public int get_Order() { }

	// RVA: 0x1C7D0EC Offset: 0x1C790EC VA: 0x1C7D0EC
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[DefaultMember("Item")]
public class XmlAnyElementAttributes : CollectionBase // TypeDefIndex: 3303
{
	// Properties
	public XmlAnyElementAttribute Item { get; }
	internal int Order { get; }

	// Methods

	// RVA: 0x1C7D17C Offset: 0x1C7917C VA: 0x1C7D17C
	public XmlAnyElementAttribute get_Item(int index) { }

	// RVA: 0x1C7D27C Offset: 0x1C7927C VA: 0x1C7D27C
	public int Add(XmlAnyElementAttribute attribute) { }

	// RVA: 0x1C7D334 Offset: 0x1C79334 VA: 0x1C7D334
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1C7D400 Offset: 0x1C79400 VA: 0x1C7D400
	internal int get_Order() { }

	// RVA: 0x1C7D69C Offset: 0x1C7969C VA: 0x1C7D69C
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = False)]
public class XmlArrayAttribute : Attribute // TypeDefIndex: 3304
{
	// Fields
	private string elementName; // 0x10
	private XmlSchemaForm form; // 0x18
	private bool isNullable; // 0x1C
	private string ns; // 0x20
	private int order; // 0x28

	// Properties
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public bool IsNullable { get; }
	public string Namespace { get; }
	public int Order { get; }

	// Methods

	// RVA: 0x1C7D6A4 Offset: 0x1C796A4 VA: 0x1C7D6A4
	public string get_ElementName() { }

	// RVA: 0x1C7D6C8 Offset: 0x1C796C8 VA: 0x1C7D6C8
	public XmlSchemaForm get_Form() { }

	// RVA: 0x1C7D6D0 Offset: 0x1C796D0 VA: 0x1C7D6D0
	public bool get_IsNullable() { }

	// RVA: 0x1C7D6D8 Offset: 0x1C796D8 VA: 0x1C7D6D8
	public string get_Namespace() { }

	// RVA: 0x1C7D6E0 Offset: 0x1C796E0 VA: 0x1C7D6E0
	public int get_Order() { }

	// RVA: 0x1C7D6E8 Offset: 0x1C796E8 VA: 0x1C7D6E8
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = True)]
public class XmlArrayItemAttribute : Attribute // TypeDefIndex: 3305
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private bool isNullableSpecified; // 0x31
	private int nestingLevel; // 0x34
	private Type type; // 0x38

	// Properties
	public string DataType { get; }
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }
	public bool IsNullable { get; }
	internal bool IsNullableSpecified { get; }
	public Type Type { get; }
	public int NestingLevel { get; }

	// Methods

	// RVA: 0x1C7D808 Offset: 0x1C79808 VA: 0x1C7D808
	public string get_DataType() { }

	// RVA: 0x1C7D82C Offset: 0x1C7982C VA: 0x1C7D82C
	public string get_ElementName() { }

	// RVA: 0x1C7D850 Offset: 0x1C79850 VA: 0x1C7D850
	public XmlSchemaForm get_Form() { }

	// RVA: 0x1C7D858 Offset: 0x1C79858 VA: 0x1C7D858
	public string get_Namespace() { }

	// RVA: 0x1C7D860 Offset: 0x1C79860 VA: 0x1C7D860
	public bool get_IsNullable() { }

	// RVA: 0x1C7D868 Offset: 0x1C79868 VA: 0x1C7D868
	internal bool get_IsNullableSpecified() { }

	// RVA: 0x1C7D870 Offset: 0x1C79870 VA: 0x1C7D870
	public Type get_Type() { }

	// RVA: 0x1C7D878 Offset: 0x1C79878 VA: 0x1C7D878
	public int get_NestingLevel() { }

	// RVA: 0x1C7D880 Offset: 0x1C79880 VA: 0x1C7D880
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[DefaultMember("Item")]
public class XmlArrayItemAttributes : CollectionBase // TypeDefIndex: 3306
{
	// Properties
	public XmlArrayItemAttribute Item { get; }

	// Methods

	// RVA: 0x1C7D9E4 Offset: 0x1C799E4 VA: 0x1C7D9E4
	public XmlArrayItemAttribute get_Item(int index) { }

	// RVA: 0x1C7DAE4 Offset: 0x1C79AE4 VA: 0x1C7DAE4
	public int Add(XmlArrayItemAttribute attribute) { }

	// RVA: 0x1C7DB9C Offset: 0x1C79B9C VA: 0x1C7DB9C
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1C7DC68 Offset: 0x1C79C68 VA: 0x1C7DC68
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlAttributeAttribute : Attribute // TypeDefIndex: 3307
{
	// Fields
	private string attributeName; // 0x10
	private string dataType; // 0x18
	private Type type; // 0x20
	private XmlSchemaForm form; // 0x28
	private string ns; // 0x30

	// Properties
	public string AttributeName { get; }
	public string DataType { get; set; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }

	// Methods

	// RVA: 0x1C7DC70 Offset: 0x1C79C70 VA: 0x1C7DC70
	public void .ctor(string attributeName) { }

	// RVA: 0x1C7DCA0 Offset: 0x1C79CA0 VA: 0x1C7DCA0
	public string get_AttributeName() { }

	// RVA: 0x1C7DCC4 Offset: 0x1C79CC4 VA: 0x1C7DCC4
	public string get_DataType() { }

	// RVA: 0x1C7DCE8 Offset: 0x1C79CE8 VA: 0x1C7DCE8
	public void set_DataType(string value) { }

	// RVA: 0x1C7DCF0 Offset: 0x1C79CF0 VA: 0x1C7DCF0
	public XmlSchemaForm get_Form() { }

	// RVA: 0x1C7DCF8 Offset: 0x1C79CF8 VA: 0x1C7DCF8
	public string get_Namespace() { }

	// RVA: 0x1C7DD00 Offset: 0x1C79D00 VA: 0x1C7DD00
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[DefaultMember("Item")]
public class XmlAttributeOverrides // TypeDefIndex: 3308
{
	// Fields
	private Hashtable overrides; // 0x10

	// Properties
	public XmlAttributes Item { get; }
	public XmlAttributes Item { get; }

	// Methods

	// RVA: 0x1C7DE34 Offset: 0x1C79E34 VA: 0x1C7DE34
	public void .ctor() { }

	// RVA: 0x1C7DEA0 Offset: 0x1C79EA0 VA: 0x1C7DEA0
	public XmlAttributes get_Item(Type type) { }

	// RVA: 0x1C7DEB8 Offset: 0x1C79EB8 VA: 0x1C7DEB8
	public XmlAttributes get_Item(Type type, string member) { }

	// RVA: 0x1C7DF6C Offset: 0x1C79F6C VA: 0x1C7DF6C
	private TypeMember GetKey(Type type, string member) { }

	// RVA: 0x1C7DFD8 Offset: 0x1C79FD8 VA: 0x1C7DFD8
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
public class XmlAttributes // TypeDefIndex: 3309
{
	// Fields
	private XmlAnyAttributeAttribute xmlAnyAttribute; // 0x10
	private XmlAnyElementAttributes xmlAnyElements; // 0x18
	private XmlArrayAttribute xmlArray; // 0x20
	private XmlArrayItemAttributes xmlArrayItems; // 0x28
	private XmlAttributeAttribute xmlAttribute; // 0x30
	private XmlChoiceIdentifierAttribute xmlChoiceIdentifier; // 0x38
	private object xmlDefaultValue; // 0x40
	private XmlElementAttributes xmlElements; // 0x48
	private XmlEnumAttribute xmlEnum; // 0x50
	private bool xmlIgnore; // 0x58
	private bool xmlns; // 0x59
	private XmlRootAttribute xmlRoot; // 0x60
	private XmlTextAttribute xmlText; // 0x68
	private XmlTypeAttribute xmlType; // 0x70

	// Properties
	public XmlAnyAttributeAttribute XmlAnyAttribute { get; }
	public XmlAnyElementAttributes XmlAnyElements { get; }
	public XmlArrayAttribute XmlArray { get; }
	public XmlArrayItemAttributes XmlArrayItems { get; }
	public XmlAttributeAttribute XmlAttribute { get; }
	public XmlChoiceIdentifierAttribute XmlChoiceIdentifier { get; }
	public object XmlDefaultValue { get; }
	public XmlElementAttributes XmlElements { get; }
	public bool XmlIgnore { get; }
	public bool Xmlns { get; }
	public XmlRootAttribute XmlRoot { get; }
	public XmlTextAttribute XmlText { get; }
	public XmlTypeAttribute XmlType { get; }
	internal Nullable<int> Order { get; }
	internal int SortableOrder { get; }

	// Methods

	// RVA: 0x1C7E700 Offset: 0x1C7A700 VA: 0x1C7E700
	public void .ctor() { }

	// RVA: 0x1C7E828 Offset: 0x1C7A828 VA: 0x1C7E828
	public void .ctor(ICustomAttributeProvider provider) { }

	// RVA: 0x1C7F0F0 Offset: 0x1C7B0F0 VA: 0x1C7F0F0
	public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	// RVA: 0x1C7F0F8 Offset: 0x1C7B0F8 VA: 0x1C7F0F8
	public XmlAnyElementAttributes get_XmlAnyElements() { }

	// RVA: 0x1C7F100 Offset: 0x1C7B100 VA: 0x1C7F100
	public XmlArrayAttribute get_XmlArray() { }

	// RVA: 0x1C7F108 Offset: 0x1C7B108 VA: 0x1C7F108
	public XmlArrayItemAttributes get_XmlArrayItems() { }

	// RVA: 0x1C7F110 Offset: 0x1C7B110 VA: 0x1C7F110
	public XmlAttributeAttribute get_XmlAttribute() { }

	// RVA: 0x1C7F118 Offset: 0x1C7B118 VA: 0x1C7F118
	public XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

	// RVA: 0x1C7F120 Offset: 0x1C7B120 VA: 0x1C7F120
	public object get_XmlDefaultValue() { }

	// RVA: 0x1C7F128 Offset: 0x1C7B128 VA: 0x1C7F128
	public XmlElementAttributes get_XmlElements() { }

	// RVA: 0x1C7F130 Offset: 0x1C7B130 VA: 0x1C7F130
	public bool get_XmlIgnore() { }

	// RVA: 0x1C7F138 Offset: 0x1C7B138 VA: 0x1C7F138
	public bool get_Xmlns() { }

	// RVA: 0x1C7F140 Offset: 0x1C7B140 VA: 0x1C7F140
	public XmlRootAttribute get_XmlRoot() { }

	// RVA: 0x1C7F148 Offset: 0x1C7B148 VA: 0x1C7F148
	public XmlTextAttribute get_XmlText() { }

	// RVA: 0x1C7F150 Offset: 0x1C7B150 VA: 0x1C7F150
	public XmlTypeAttribute get_XmlType() { }

	// RVA: 0x1C7E490 Offset: 0x1C7A490 VA: 0x1C7E490
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1C80010 Offset: 0x1C7C010 VA: 0x1C80010
	internal Nullable<int> get_Order() { }

	// RVA: 0x1C80368 Offset: 0x1C7C368 VA: 0x1C80368
	internal int get_SortableOrder() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = False)]
public class XmlChoiceIdentifierAttribute : Attribute // TypeDefIndex: 3310
{
	// Fields
	private string memberName; // 0x10

	// Properties
	public string MemberName { get; }

	// Methods

	// RVA: 0x1C803EC Offset: 0x1C7C3EC VA: 0x1C803EC
	public string get_MemberName() { }

	// RVA: 0x1C7FF94 Offset: 0x1C7BF94 VA: 0x1C7FF94
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
internal class XmlCustomFormatter // TypeDefIndex: 3311
{
	// Fields
	private static string[] allTimeFormats; // 0x0

	// Methods

	// RVA: 0x1C80410 Offset: 0x1C7C410 VA: 0x1C80410
	internal static string FromEnum(long value, string[] values, long[] ids, string typeName) { }

	// RVA: 0x1C80684 Offset: 0x1C7C684 VA: 0x1C80684
	internal static string FromXmlName(string name) { }

	// RVA: 0x1C806DC Offset: 0x1C7C6DC VA: 0x1C806DC
	internal static string FromXmlNCName(string ncName) { }

	// RVA: 0x1C7F224 Offset: 0x1C7B224 VA: 0x1C7F224
	internal static string ToXmlString(TypeData type, object value) { }

	// RVA: 0x1C80734 Offset: 0x1C7C734 VA: 0x1C80734
	internal static object FromXmlString(TypeData type, string value) { }

	// RVA: 0x1C81238 Offset: 0x1C7D238 VA: 0x1C81238
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624, AllowMultiple = True)]
public class XmlElementAttribute : Attribute // TypeDefIndex: 3312
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private Type type; // 0x38
	private int order; // 0x40

	// Properties
	public string DataType { get; }
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }
	public bool IsNullable { get; }
	public int Order { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1C81794 Offset: 0x1C7D794 VA: 0x1C81794
	public void .ctor(string elementName) { }

	// RVA: 0x1C817CC Offset: 0x1C7D7CC VA: 0x1C817CC
	public void .ctor(string elementName, Type type) { }

	// RVA: 0x1C81818 Offset: 0x1C7D818 VA: 0x1C81818
	public string get_DataType() { }

	// RVA: 0x1C8183C Offset: 0x1C7D83C VA: 0x1C8183C
	public string get_ElementName() { }

	// RVA: 0x1C81860 Offset: 0x1C7D860 VA: 0x1C81860
	public XmlSchemaForm get_Form() { }

	// RVA: 0x1C81868 Offset: 0x1C7D868 VA: 0x1C81868
	public string get_Namespace() { }

	// RVA: 0x1C81870 Offset: 0x1C7D870 VA: 0x1C81870
	public bool get_IsNullable() { }

	// RVA: 0x1C81878 Offset: 0x1C7D878 VA: 0x1C81878
	public int get_Order() { }

	// RVA: 0x1C81880 Offset: 0x1C7D880 VA: 0x1C81880
	public Type get_Type() { }

	// RVA: 0x1C81888 Offset: 0x1C7D888 VA: 0x1C81888
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[DefaultMember("Item")]
public class XmlElementAttributes : CollectionBase // TypeDefIndex: 3313
{
	// Properties
	public XmlElementAttribute Item { get; }
	internal int Order { get; }

	// Methods

	// RVA: 0x1C819D0 Offset: 0x1C7D9D0 VA: 0x1C819D0
	public XmlElementAttribute get_Item(int index) { }

	// RVA: 0x1C7F038 Offset: 0x1C7B038 VA: 0x1C7F038
	public int Add(XmlElementAttribute attribute) { }

	// RVA: 0x1C7F158 Offset: 0x1C7B158 VA: 0x1C7F158
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x1C800CC Offset: 0x1C7C0CC VA: 0x1C800CC
	internal int get_Order() { }

	// RVA: 0x1C7E820 Offset: 0x1C7A820 VA: 0x1C7E820
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(256)]
public class XmlEnumAttribute : Attribute // TypeDefIndex: 3314
{
	// Fields
	private string name; // 0x10

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x1C81AD0 Offset: 0x1C7DAD0 VA: 0x1C81AD0
	public void .ctor(string name) { }

	// RVA: 0x1C81B00 Offset: 0x1C7DB00 VA: 0x1C81B00
	public string get_Name() { }

	// RVA: 0x1C7FE60 Offset: 0x1C7BE60 VA: 0x1C7FE60
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlIgnoreAttribute : Attribute // TypeDefIndex: 3315
{
	// Methods

	// RVA: 0x1C81B08 Offset: 0x1C7DB08 VA: 0x1C81B08
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
[Usage(1100, AllowMultiple = True)]
public class XmlIncludeAttribute : Attribute // TypeDefIndex: 3316
{
	// Fields
	private Type type; // 0x10

	// Properties
	public Type Type { get; }

	// Methods

	// RVA: 0x1C81B10 Offset: 0x1C7DB10 VA: 0x1C81B10
	public Type get_Type() { }
}

// Namespace: System.Xml.Serialization
public abstract class XmlMapping // TypeDefIndex: 3317
{
	// Fields
	private ObjectMap map; // 0x10
	private ArrayList relatedMaps; // 0x18
	private SerializationFormat format; // 0x20
	private SerializationSource source; // 0x28
	internal string _elementName; // 0x30
	internal string _namespace; // 0x38
	private string key; // 0x40

	// Properties
	public string ElementName { get; }
	public string Namespace { get; }
	internal ObjectMap ObjectMap { get; set; }
	internal ArrayList RelatedMaps { get; set; }
	internal SerializationFormat Format { get; set; }
	internal SerializationSource Source { get; }

	// Methods

	// RVA: 0x1C81B18 Offset: 0x1C7DB18 VA: 0x1C81B18
	internal void .ctor(string elementName, string ns) { }

	// RVA: 0x1C81B5C Offset: 0x1C7DB5C VA: 0x1C81B5C
	public string get_ElementName() { }

	// RVA: 0x1C81B64 Offset: 0x1C7DB64 VA: 0x1C81B64
	public string get_Namespace() { }

	// RVA: 0x1C81B6C Offset: 0x1C7DB6C VA: 0x1C81B6C
	public void SetKey(string key) { }

	// RVA: 0x1C81B74 Offset: 0x1C7DB74 VA: 0x1C81B74
	internal ObjectMap get_ObjectMap() { }

	// RVA: 0x1C81B7C Offset: 0x1C7DB7C VA: 0x1C81B7C
	internal void set_ObjectMap(ObjectMap value) { }

	// RVA: 0x1C81B84 Offset: 0x1C7DB84 VA: 0x1C81B84
	internal ArrayList get_RelatedMaps() { }

	// RVA: 0x1C81B8C Offset: 0x1C7DB8C VA: 0x1C81B8C
	internal void set_RelatedMaps(ArrayList value) { }

	// RVA: 0x1C81B94 Offset: 0x1C7DB94 VA: 0x1C81B94
	internal SerializationFormat get_Format() { }

	// RVA: 0x1C81B9C Offset: 0x1C7DB9C VA: 0x1C81B9C
	internal void set_Format(SerializationFormat value) { }

	// RVA: 0x1C81BA4 Offset: 0x1C7DBA4 VA: 0x1C81BA4
	internal SerializationSource get_Source() { }
}

// Namespace: System.Xml.Serialization
internal class ObjectMap // TypeDefIndex: 3318
{
	// Methods

	// RVA: 0x1C81BAC Offset: 0x1C7DBAC VA: 0x1C81BAC
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal enum SerializationFormat // TypeDefIndex: 3319
{
	// Fields
	public int value__; // 0x0
	public const SerializationFormat Encoded = 0;
	public const SerializationFormat Literal = 1;
}

// Namespace: System.Xml.Serialization
public class XmlMemberMapping // TypeDefIndex: 3320
{}

// Namespace: System.Xml.Serialization
[DefaultMember("Item")]
public class XmlMembersMapping : XmlMapping // TypeDefIndex: 3321
{
	// Fields
	private bool _hasWrapperElement; // 0x48
	private XmlMemberMapping[] _mapping; // 0x50

	// Properties
	public int Count { get; }
	internal bool HasWrapperElement { get; }

	// Methods

	// RVA: 0x1C81BB4 Offset: 0x1C7DBB4 VA: 0x1C81BB4
	public int get_Count() { }

	// RVA: 0x1C81BCC Offset: 0x1C7DBCC VA: 0x1C81BCC
	internal bool get_HasWrapperElement() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlNamespaceDeclarationsAttribute : Attribute // TypeDefIndex: 3322
{
	// Methods

	// RVA: 0x1C81BD4 Offset: 0x1C7DBD4 VA: 0x1C81BD4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class XmlReflectionImporter.<>c // TypeDefIndex: 3323
{
	// Fields
	public static readonly XmlReflectionImporter.<>c <>9; // 0x0
	public static Comparison<XmlReflectionMember> <>9__28_0; // 0x8

	// Methods

	// RVA: 0x1C88864 Offset: 0x1C84864 VA: 0x1C88864
	private static void .cctor() { }

	// RVA: 0x1C888CC Offset: 0x1C848CC VA: 0x1C888CC
	public void .ctor() { }

	// RVA: 0x1C888D4 Offset: 0x1C848D4 VA: 0x1C888D4
	internal int <ImportClassMapping>b__28_0(XmlReflectionMember m1, XmlReflectionMember m2) { }
}

// Namespace: System.Xml.Serialization
public class XmlReflectionImporter // TypeDefIndex: 3324
{
	// Fields
	private string initialDefaultNamespace; // 0x10
	private XmlAttributeOverrides attributeOverrides; // 0x18
	private ArrayList includedTypes; // 0x20
	private ReflectionHelper helper; // 0x28
	private int arrayChoiceCount; // 0x30
	private ArrayList relatedMaps; // 0x38
	private bool allowPrivateTypes; // 0x40
	private static readonly string errSimple; // 0x0
	private static readonly string errSimple2; // 0x8

	// Methods

	// RVA: 0x1C81BDC Offset: 0x1C7DBDC VA: 0x1C81BDC
	public void .ctor(XmlAttributeOverrides attributeOverrides, string defaultNamespace) { }

	// RVA: 0x1C81D0C Offset: 0x1C7DD0C VA: 0x1C81D0C
	public XmlTypeMapping ImportTypeMapping(Type type) { }

	// RVA: 0x1C81ECC Offset: 0x1C7DECC VA: 0x1C81ECC
	public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace) { }

	// RVA: 0x1C81D18 Offset: 0x1C7DD18 VA: 0x1C81D18
	public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1C81ED8 Offset: 0x1C7DED8 VA: 0x1C81ED8
	private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1C848C0 Offset: 0x1C808C0 VA: 0x1C848C0
	private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace) { }

	// RVA: 0x1C84D40 Offset: 0x1C80D40 VA: 0x1C84D40
	private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x1C82354 Offset: 0x1C7E354 VA: 0x1C82354
	private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = False) { }

	// RVA: 0x1C8665C Offset: 0x1C8265C VA: 0x1C8665C
	private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap) { }

	// RVA: 0x1C84DD0 Offset: 0x1C80DD0 VA: 0x1C84DD0
	private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1C86864 Offset: 0x1C82864 VA: 0x1C86864
	private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x1C83274 Offset: 0x1C7F274 VA: 0x1C83274
	private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel) { }

	// RVA: 0x1C83F74 Offset: 0x1C7FF74 VA: 0x1C83F74
	private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1C84110 Offset: 0x1C80110 VA: 0x1C84110
	private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1C841C4 Offset: 0x1C801C4 VA: 0x1C841C4
	private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1C847AC Offset: 0x1C807AC VA: 0x1C847AC
	private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1C86740 Offset: 0x1C82740 VA: 0x1C86740
	private void ImportIncludedTypes(Type type, string defaultNamespace) { }

	// RVA: 0x1C84EF0 Offset: 0x1C80EF0 VA: 0x1C84EF0
	private List<XmlReflectionMember> GetReflectionMembers(Type type) { }

	// RVA: 0x1C85C88 Offset: 0x1C81C88 VA: 0x1C85C88
	private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace) { }

	// RVA: 0x1C86F60 Offset: 0x1C82F60 VA: 0x1C86F60
	private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x1C86964 Offset: 0x1C82964 VA: 0x1C86964
	private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts) { }

	// RVA: 0x1C87FE8 Offset: 0x1C83FE8 VA: 0x1C87FE8
	private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace) { }

	// RVA: 0x1C84CDC Offset: 0x1C80CDC VA: 0x1C84CDC
	private bool CanBeNull(TypeData type) { }

	// RVA: 0x1C88328 Offset: 0x1C84328 VA: 0x1C88328
	public void IncludeType(Type type) { }

	// RVA: 0x1C87E28 Offset: 0x1C83E28 VA: 0x1C87E28
	private object GetDefaultValue(TypeData typeData, object defaultValue) { }

	// RVA: 0x1C887CC Offset: 0x1C847CC VA: 0x1C887CC
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
public class XmlReflectionMember // TypeDefIndex: 3325
{
	// Fields
	private bool isReturnValue; // 0x10
	private string memberName; // 0x18
	private Type memberType; // 0x20
	private XmlAttributes xmlAttributes; // 0x28
	private Type declaringType; // 0x30

	// Properties
	public bool IsReturnValue { get; }
	public string MemberName { get; }
	public Type MemberType { get; }
	public XmlAttributes XmlAttributes { get; }
	internal Type DeclaringType { get; set; }

	// Methods

	// RVA: 0x1C86904 Offset: 0x1C82904 VA: 0x1C86904
	internal void .ctor(string name, Type type, XmlAttributes attributes) { }

	// RVA: 0x1C88920 Offset: 0x1C84920 VA: 0x1C88920
	public bool get_IsReturnValue() { }

	// RVA: 0x1C88928 Offset: 0x1C84928 VA: 0x1C88928
	public string get_MemberName() { }

	// RVA: 0x1C88930 Offset: 0x1C84930 VA: 0x1C88930
	public Type get_MemberType() { }

	// RVA: 0x1C85C1C Offset: 0x1C81C1C VA: 0x1C85C1C
	public XmlAttributes get_XmlAttributes() { }

	// RVA: 0x1C88938 Offset: 0x1C84938 VA: 0x1C88938
	internal Type get_DeclaringType() { }

	// RVA: 0x1C88940 Offset: 0x1C84940 VA: 0x1C88940
	internal void set_DeclaringType(Type value) { }
}

// Namespace: System.Xml.Serialization
[Usage(9244)]
public class XmlRootAttribute : Attribute // TypeDefIndex: 3326
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private bool isNullable; // 0x20
	private string ns; // 0x28

	// Properties
	public string DataType { get; set; }
	public string ElementName { get; set; }
	public bool IsNullable { get; set; }
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x1C88948 Offset: 0x1C84948 VA: 0x1C88948
	public void .ctor() { }

	// RVA: 0x1C88958 Offset: 0x1C84958 VA: 0x1C88958
	public void .ctor(string elementName) { }

	// RVA: 0x1C88990 Offset: 0x1C84990 VA: 0x1C88990
	public string get_DataType() { }

	// RVA: 0x1C889B4 Offset: 0x1C849B4 VA: 0x1C889B4
	public void set_DataType(string value) { }

	// RVA: 0x1C84D1C Offset: 0x1C80D1C VA: 0x1C84D1C
	public string get_ElementName() { }

	// RVA: 0x1C889BC Offset: 0x1C849BC VA: 0x1C889BC
	public void set_ElementName(string value) { }

	// RVA: 0x1C889C4 Offset: 0x1C849C4 VA: 0x1C889C4
	public bool get_IsNullable() { }

	// RVA: 0x1C889CC Offset: 0x1C849CC VA: 0x1C889CC
	public void set_IsNullable(bool value) { }

	// RVA: 0x1C889D4 Offset: 0x1C849D4 VA: 0x1C889D4
	public string get_Namespace() { }

	// RVA: 0x1C889DC Offset: 0x1C849DC VA: 0x1C889DC
	public void set_Namespace(string value) { }

	// RVA: 0x1C7FEDC Offset: 0x1C7BEDC VA: 0x1C7FEDC
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[Usage(1036)]
public sealed class XmlSchemaProviderAttribute : Attribute // TypeDefIndex: 3327
{
	// Fields
	private string _methodName; // 0x10
	private bool _isAny; // 0x18

	// Properties
	public string MethodName { get; }
	public bool IsAny { get; set; }

	// Methods

	// RVA: 0x1C889E4 Offset: 0x1C849E4 VA: 0x1C889E4
	public void .ctor(string methodName) { }

	// RVA: 0x1C88A14 Offset: 0x1C84A14 VA: 0x1C88A14
	public string get_MethodName() { }

	// RVA: 0x1C88A1C Offset: 0x1C84A1C VA: 0x1C88A1C
	public bool get_IsAny() { }

	// RVA: 0x1C88A24 Offset: 0x1C84A24 VA: 0x1C88A24
	public void set_IsAny(bool value) { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationCollectionFixupCallback : MulticastDelegate // TypeDefIndex: 3328
{
	// Methods

	// RVA: 0x1C88A2C Offset: 0x1C84A2C VA: 0x1C88A2C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C88B38 Offset: 0x1C84B38 VA: 0x1C88B38 Slot: 12
	public virtual void Invoke(object collection, object collectionItems) { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationFixupCallback : MulticastDelegate // TypeDefIndex: 3329
{
	// Methods

	// RVA: 0x1C88B4C Offset: 0x1C84B4C VA: 0x1C88B4C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C88C54 Offset: 0x1C84C54 VA: 0x1C88C54 Slot: 12
	public virtual void Invoke(object fixup) { }
}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializationGeneratedCode // TypeDefIndex: 3330
{
	// Methods

	// RVA: 0x1C88C68 Offset: 0x1C84C68 VA: 0x1C88C68
	protected void .ctor() { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationReadCallback : MulticastDelegate // TypeDefIndex: 3331
{
	// Methods

	// RVA: 0x1C88C70 Offset: 0x1C84C70 VA: 0x1C88C70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C88D0C Offset: 0x1C84D0C VA: 0x1C88D0C Slot: 12
	public virtual object Invoke() { }
}

// Namespace: 
private class XmlSerializationReader.WriteCallbackInfo // TypeDefIndex: 3332
{
	// Fields
	public Type Type; // 0x10
	public string TypeName; // 0x18
	public string TypeNs; // 0x20
	public XmlSerializationReadCallback Callback; // 0x28

	// Methods

	// RVA: 0x1C894E4 Offset: 0x1C854E4 VA: 0x1C894E4
	public void .ctor() { }
}

// Namespace: 
protected class XmlSerializationReader.CollectionFixup // TypeDefIndex: 3333
{
	// Fields
	private XmlSerializationCollectionFixupCallback callback; // 0x10
	private object collection; // 0x18
	private object collectionItems; // 0x20
	private string id; // 0x28

	// Properties
	public XmlSerializationCollectionFixupCallback Callback { get; }
	public object Collection { get; }
	internal object Id { get; }
	public object CollectionItems { get; set; }

	// Methods

	// RVA: 0x1C8D328 Offset: 0x1C89328 VA: 0x1C8D328
	internal void .ctor(object collection, XmlSerializationCollectionFixupCallback callback, string id) { }

	// RVA: 0x1C8D388 Offset: 0x1C89388 VA: 0x1C8D388
	public XmlSerializationCollectionFixupCallback get_Callback() { }

	// RVA: 0x1C8D390 Offset: 0x1C89390 VA: 0x1C8D390
	public object get_Collection() { }

	// RVA: 0x1C8D398 Offset: 0x1C89398 VA: 0x1C8D398
	internal object get_Id() { }

	// RVA: 0x1C8D3A0 Offset: 0x1C893A0 VA: 0x1C8D3A0
	public object get_CollectionItems() { }

	// RVA: 0x1C8D3A8 Offset: 0x1C893A8 VA: 0x1C8D3A8
	internal void set_CollectionItems(object value) { }
}

// Namespace: 
protected class XmlSerializationReader.Fixup // TypeDefIndex: 3334
{
	// Fields
	private object source; // 0x10
	private string[] ids; // 0x18
	private XmlSerializationFixupCallback callback; // 0x20

	// Properties
	public XmlSerializationFixupCallback Callback { get; }
	public string[] Ids { get; }
	public object Source { get; }

	// Methods

	// RVA: 0x1C8D3B0 Offset: 0x1C893B0 VA: 0x1C8D3B0
	public void .ctor(object o, XmlSerializationFixupCallback callback, int count) { }

	// RVA: 0x1C8D450 Offset: 0x1C89450 VA: 0x1C8D450
	public XmlSerializationFixupCallback get_Callback() { }

	// RVA: 0x1C8D458 Offset: 0x1C89458 VA: 0x1C8D458
	public string[] get_Ids() { }

	// RVA: 0x1C8D460 Offset: 0x1C89460 VA: 0x1C8D460
	public object get_Source() { }
}

// Namespace: 
private class XmlSerializationReader.CollectionItemFixup // TypeDefIndex: 3335
{
	// Fields
	private Array list; // 0x10
	private int index; // 0x18
	private string id; // 0x20

	// Properties
	public Array Collection { get; }
	public int Index { get; }
	public string Id { get; }

	// Methods

	// RVA: 0x1C8B7F8 Offset: 0x1C877F8 VA: 0x1C8B7F8
	public void .ctor(Array list, int index, string id) { }

	// RVA: 0x1C8D468 Offset: 0x1C89468 VA: 0x1C8D468
	public Array get_Collection() { }

	// RVA: 0x1C8D470 Offset: 0x1C89470 VA: 0x1C8D470
	public int get_Index() { }

	// RVA: 0x1C8D478 Offset: 0x1C89478 VA: 0x1C8D478
	public string get_Id() { }
}

// Namespace: System.Xml.Serialization
[MonoTODO]
public abstract class XmlSerializationReader : XmlSerializationGeneratedCode // TypeDefIndex: 3336
{
	// Fields
	private XmlDocument document; // 0x10
	private XmlReader reader; // 0x18
	private ArrayList fixups; // 0x20
	private Hashtable collFixups; // 0x28
	private ArrayList collItemFixups; // 0x30
	private Hashtable typesCallbacks; // 0x38
	private ArrayList noIDTargets; // 0x40
	private Hashtable targets; // 0x48
	private Hashtable delayedListFixups; // 0x50
	private XmlSerializer eventSource; // 0x58
	private int delayedFixupId; // 0x60
	private Hashtable referencedObjects; // 0x68
	private int readCount; // 0x70
	private int whileIterationCount; // 0x74
	private string w3SchemaNS; // 0x78
	private string w3InstanceNS; // 0x80
	private string w3InstanceNS2000; // 0x88
	private string w3InstanceNS1999; // 0x90
	private string soapNS; // 0x98
	private string wsdlNS; // 0xA0
	private string nullX; // 0xA8
	private string nil; // 0xB0
	private string typeX; // 0xB8
	private string arrayType; // 0xC0
	private XmlQualifiedName arrayQName; // 0xC8

	// Properties
	protected XmlDocument Document { get; }
	protected XmlReader Reader { get; }

	// Methods

	// RVA: 0x1C88D20 Offset: 0x1C84D20 VA: 0x1C88D20
	internal void Initialize(XmlReader reader, XmlSerializer eventSource) { }

	// RVA: 0x1C890E0 Offset: 0x1C850E0 VA: 0x1C890E0
	private ArrayList EnsureArrayList(ArrayList list) { }

	// RVA: 0x1C8913C Offset: 0x1C8513C VA: 0x1C8913C
	private Hashtable EnsureHashtable(Hashtable hash) { }

	// RVA: 0x1C89198 Offset: 0x1C85198 VA: 0x1C89198
	protected void .ctor() { }

	// RVA: 0x1C891A0 Offset: 0x1C851A0 VA: 0x1C891A0
	protected XmlDocument get_Document() { }

	// RVA: 0x1C8923C Offset: 0x1C8523C VA: 0x1C8923C
	protected XmlReader get_Reader() { }

	// RVA: 0x1C89244 Offset: 0x1C85244 VA: 0x1C89244
	protected void AddFixup(XmlSerializationReader.CollectionFixup fixup) { }

	// RVA: 0x1C89318 Offset: 0x1C85318 VA: 0x1C89318
	protected void AddFixup(XmlSerializationReader.Fixup fixup) { }

	// RVA: 0x1C8936C Offset: 0x1C8536C VA: 0x1C8936C
	private void AddFixup(XmlSerializationReader.CollectionItemFixup fixup) { }

	// RVA: 0x1C893C0 Offset: 0x1C853C0 VA: 0x1C893C0
	protected void AddReadCallback(string name, string ns, Type type, XmlSerializationReadCallback read) { }

	// RVA: 0x1C894EC Offset: 0x1C854EC VA: 0x1C894EC
	protected void AddTarget(string id, object o) { }

	// RVA: 0x1C895B4 Offset: 0x1C855B4 VA: 0x1C895B4
	private string CurrentTag() { }

	// RVA: 0x1C89728 Offset: 0x1C85728 VA: 0x1C89728
	protected Exception CreateReadOnlyCollectionException(string name) { }

	// RVA: 0x1C897B8 Offset: 0x1C857B8 VA: 0x1C897B8
	protected Exception CreateUnknownConstantException(string value, Type enumType) { }

	// RVA: 0x1C89850 Offset: 0x1C85850 VA: 0x1C89850
	protected Exception CreateUnknownNodeException() { }

	// RVA: 0x1C898E4 Offset: 0x1C858E4 VA: 0x1C898E4
	protected Exception CreateUnknownTypeException(XmlQualifiedName type) { }

	// RVA: 0x1C89A8C Offset: 0x1C85A8C VA: 0x1C89A8C
	protected Array EnsureArrayIndex(Array a, int index, Type elementType) { }

	// RVA: 0x1C89B18 Offset: 0x1C85B18 VA: 0x1C89B18
	protected bool GetNullAttr() { }

	// RVA: 0x1C89BC8 Offset: 0x1C85BC8 VA: 0x1C89BC8
	protected object GetTarget(string id) { }

	// RVA: 0x1C89C8C Offset: 0x1C85C8C VA: 0x1C89C8C
	private bool TargetReady(string id) { }

	// RVA: 0x1C89CA8 Offset: 0x1C85CA8 VA: 0x1C89CA8
	protected XmlQualifiedName GetXsiType() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: -1 Offset: -1 Slot: 5
	protected abstract void InitIDs();

	// RVA: 0x1C89EAC Offset: 0x1C85EAC VA: 0x1C89EAC
	protected bool IsXmlnsAttribute(string name) { }

	// RVA: 0x1C89F4C Offset: 0x1C85F4C VA: 0x1C89F4C
	protected void ParseWsdlArrayType(XmlAttribute attr) { }

	// RVA: 0x1C8A0D0 Offset: 0x1C860D0 VA: 0x1C8A0D0
	protected XmlQualifiedName ReadElementQualifiedName() { }

	// RVA: 0x1C8A3C4 Offset: 0x1C863C4 VA: 0x1C8A3C4
	protected void ReadEndElement() { }

	// RVA: 0x1C8A46C Offset: 0x1C8646C VA: 0x1C8A46C
	protected bool ReadNull() { }

	// RVA: 0x1C8A570 Offset: 0x1C86570 VA: 0x1C8A570
	protected XmlQualifiedName ReadNullableQualifiedName() { }

	// RVA: 0x1C8A598 Offset: 0x1C86598 VA: 0x1C8A598
	protected string ReadNullableString() { }

	// RVA: 0x1C8A5E0 Offset: 0x1C865E0 VA: 0x1C8A5E0
	protected object ReadReferencedElement() { }

	// RVA: 0x1C8A904 Offset: 0x1C86904 VA: 0x1C8A904
	private XmlSerializationReader.WriteCallbackInfo GetCallbackInfo(XmlQualifiedName qname) { }

	// RVA: 0x1C8A638 Offset: 0x1C86638 VA: 0x1C8A638
	protected object ReadReferencedElement(string name, string ns) { }

	// RVA: 0x1C8A9F8 Offset: 0x1C869F8 VA: 0x1C8A9F8
	private bool ReadList(out object resultList) { }

	// RVA: 0x1C8B84C Offset: 0x1C8784C VA: 0x1C8B84C
	protected void ReadReferencedElements() { }

	// RVA: 0x1C8C638 Offset: 0x1C88638 VA: 0x1C8C638
	protected object ReadReferencingElement(out string fixupReference) { }

	// RVA: 0x1C8B7EC Offset: 0x1C877EC VA: 0x1C8B7EC
	protected object ReadReferencingElement(string name, string ns, out string fixupReference) { }

	// RVA: 0x1C8C69C Offset: 0x1C8869C VA: 0x1C8C69C
	protected object ReadReferencingElement(string name, string ns, bool elementCanBeType, out string fixupReference) { }

	// RVA: 0x1C8CA10 Offset: 0x1C88A10 VA: 0x1C8CA10
	protected IXmlSerializable ReadSerializable(IXmlSerializable serializable) { }

	// RVA: 0x1C8CBA4 Offset: 0x1C88BA4 VA: 0x1C8CBA4
	protected object ReadTypedPrimitive(XmlQualifiedName type) { }

	// RVA: 0x1C8AECC Offset: 0x1C86ECC VA: 0x1C8AECC
	private object ReadTypedPrimitive(XmlQualifiedName qname, bool reportUnknown) { }

	// RVA: 0x1C8CE24 Offset: 0x1C88E24 VA: 0x1C8CE24
	protected XmlNode ReadXmlNode(bool wrapped) { }

	// RVA: 0x1C8CE8C Offset: 0x1C88E8C VA: 0x1C8CE8C
	protected XmlDocument ReadXmlDocument(bool wrapped) { }

	// RVA: 0x1C8CFA8 Offset: 0x1C88FA8 VA: 0x1C8CFA8
	protected Array ShrinkArray(Array a, int length, Type elementType, bool isNullable) { }

	// RVA: 0x1C8A1A4 Offset: 0x1C861A4 VA: 0x1C8A1A4
	protected XmlQualifiedName ToXmlQualifiedName(string value) { }

	// RVA: 0x1C8D038 Offset: 0x1C89038 VA: 0x1C8D038
	protected void UnknownAttribute(object o, XmlAttribute attr, string qnames) { }

	// RVA: 0x1C8D194 Offset: 0x1C89194 VA: 0x1C8D194
	protected void UnknownElement(object o, XmlElement elem, string qnames) { }

	// RVA: 0x1C8A53C Offset: 0x1C8653C VA: 0x1C8A53C
	protected void UnknownNode(object o) { }

	// RVA: 0x1C8D2F0 Offset: 0x1C892F0 VA: 0x1C8D2F0
	protected void UnknownNode(object o, string qnames) { }

	// RVA: 0x1C8CBAC Offset: 0x1C88BAC VA: 0x1C8CBAC
	private void OnUnknownNode(XmlNode node, object o, string qnames) { }

	// RVA: 0x1C8C5A4 Offset: 0x1C885A4 VA: 0x1C8C5A4
	protected void UnreferencedObject(string id, object o) { }
}

// Namespace: 
private class XmlSerializationReaderInterpreter.FixupCallbackInfo // TypeDefIndex: 3337
{
	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private ClassMap _map; // 0x18
	private bool _isValueList; // 0x20

	// Methods

	// RVA: 0x1C91948 Offset: 0x1C8D948 VA: 0x1C91948
	public void .ctor(XmlSerializationReaderInterpreter sri, ClassMap map, bool isValueList) { }

	// RVA: 0x1C92A44 Offset: 0x1C8EA44 VA: 0x1C92A44
	public void FixupMembers(object fixup) { }
}

// Namespace: 
private class XmlSerializationReaderInterpreter.ReaderCallbackInfo // TypeDefIndex: 3338
{
	// Fields
	private XmlSerializationReaderInterpreter _sri; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x1C8D850 Offset: 0x1C89850 VA: 0x1C8D850
	public void .ctor(XmlSerializationReaderInterpreter sri, XmlTypeMapping typeMap) { }

	// RVA: 0x1C92A68 Offset: 0x1C8EA68 VA: 0x1C92A68
	internal object ReadObject() { }
}

// Namespace: System.Xml.Serialization
internal class XmlSerializationReaderInterpreter : XmlSerializationReader // TypeDefIndex: 3339
{
	// Fields
	private XmlMapping _typeMap; // 0xD0
	private SerializationFormat _format; // 0xD8
	private static readonly XmlQualifiedName AnyType; // 0x0
	private static readonly object[] empty_array; // 0x8

	// Methods

	// RVA: 0x1C8D480 Offset: 0x1C89480 VA: 0x1C8D480
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x1C8D4C4 Offset: 0x1C894C4 VA: 0x1C8D4C4 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x1C8D894 Offset: 0x1C89894 VA: 0x1C8D894 Slot: 5
	protected override void InitIDs() { }

	// RVA: 0x1C8D898 Offset: 0x1C89898 VA: 0x1C8D898
	public object ReadRoot() { }

	// RVA: 0x1C8DA78 Offset: 0x1C89A78 VA: 0x1C8DA78
	private object ReadEncodedObject(XmlTypeMapping typeMap) { }

	// RVA: 0x1C8DB7C Offset: 0x1C89B7C VA: 0x1C8DB7C Slot: 6
	protected virtual object ReadMessage(XmlMembersMapping typeMap) { }

	// RVA: 0x1C8D9A0 Offset: 0x1C899A0 VA: 0x1C8D9A0
	private object ReadRoot(XmlTypeMapping rootMap) { }

	// RVA: 0x1C905D0 Offset: 0x1C8C5D0 VA: 0x1C905D0 Slot: 7
	protected virtual object ReadObject(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x1C90D20 Offset: 0x1C8CD20 VA: 0x1C90D20 Slot: 8
	protected virtual object ReadClassInstance(XmlTypeMapping typeMap, bool isNullable, bool checkType) { }

	// RVA: 0x1C90FDC Offset: 0x1C8CFDC VA: 0x1C90FDC Slot: 9
	protected virtual void ReadClassInstanceMembers(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x1C8E10C Offset: 0x1C8A10C VA: 0x1C8E10C
	private void ReadAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1C8E500 Offset: 0x1C8A500 VA: 0x1C8E500
	private void ReadMembers(ClassMap map, object ob, bool isValueList, bool readBySoapOrder) { }

	// RVA: 0x1C91714 Offset: 0x1C8D714 VA: 0x1C91714
	private void SetListMembersDefaults(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1C91C98 Offset: 0x1C8DC98 VA: 0x1C91C98
	internal void FixupMembers(ClassMap map, object obfixup, bool isValueList) { }

	// RVA: 0x1C92060 Offset: 0x1C8E060 VA: 0x1C92060 Slot: 10
	protected virtual void ProcessUnknownAttribute(object target) { }

	// RVA: 0x1C92094 Offset: 0x1C8E094 VA: 0x1C92094 Slot: 11
	protected virtual void ProcessUnknownElement(object target) { }

	// RVA: 0x1C91858 Offset: 0x1C8D858 VA: 0x1C91858
	private bool IsReadOnly(XmlTypeMapMember member, TypeData memType, object ob, bool isValueList) { }

	// RVA: 0x1C911AC Offset: 0x1C8D1AC VA: 0x1C911AC
	private void SetMemberValue(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x1C8E06C Offset: 0x1C8A06C VA: 0x1C8E06C
	private void SetMemberValueFromAttr(XmlTypeMapMember member, object ob, object value, bool isValueList) { }

	// RVA: 0x1C91340 Offset: 0x1C8D340 VA: 0x1C91340
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x1C91A3C Offset: 0x1C8DA3C VA: 0x1C91A3C
	private object ReadObjectElement(XmlTypeMapElementInfo elem) { }

	// RVA: 0x1C920C8 Offset: 0x1C8E0C8 VA: 0x1C920C8
	private object ReadPrimitiveValue(XmlTypeMapElementInfo elem) { }

	// RVA: 0x1C91084 Offset: 0x1C8D084 VA: 0x1C91084
	private object GetValueFromXmlString(string value, TypeData typeData, XmlTypeMapping typeMap) { }

	// RVA: 0x1C906C8 Offset: 0x1C8C6C8 VA: 0x1C906C8
	private object ReadListElement(XmlTypeMapping typeMap, bool isNullable, object list, bool canCreateInstance) { }

	// RVA: 0x1C921D4 Offset: 0x1C8E1D4 VA: 0x1C921D4
	private object ReadListString(XmlTypeMapping typeMap, string values) { }

	// RVA: 0x1C91410 Offset: 0x1C8D410 VA: 0x1C91410
	private void AddListValue(TypeData listType, ref object list, int index, object value, bool canCreateInstance) { }

	// RVA: 0x1C90FD4 Offset: 0x1C8CFD4 VA: 0x1C90FD4
	private static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: 0x1C8E008 Offset: 0x1C8A008 VA: 0x1C8E008
	private object CreateInstance(Type type) { }

	// RVA: 0x1C919A0 Offset: 0x1C8D9A0 VA: 0x1C919A0
	private object CreateList(Type listType) { }

	// RVA: 0x1C918BC Offset: 0x1C8D8BC VA: 0x1C918BC
	private object InitializeList(TypeData listType) { }

	// RVA: 0x1C92530 Offset: 0x1C8E530 VA: 0x1C92530
	private void FillList(object list, object items) { }

	// RVA: 0x1C92540 Offset: 0x1C8E540 VA: 0x1C92540
	private void CopyEnumerableList(object source, object dest) { }

	// RVA: 0x1C905B8 Offset: 0x1C8C5B8 VA: 0x1C905B8
	private object ReadXmlNodeElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1C91BE4 Offset: 0x1C8DBE4 VA: 0x1C91BE4
	private object ReadXmlNode(TypeData type, bool wrapped) { }

	// RVA: 0x1C90A68 Offset: 0x1C8CA68 VA: 0x1C90A68
	private object ReadPrimitiveElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1C90B20 Offset: 0x1C8CB20 VA: 0x1C90B20
	private object ReadEnumElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1C923F8 Offset: 0x1C8E3F8 VA: 0x1C923F8
	private object GetEnumValue(XmlTypeMapping typeMap, string val) { }

	// RVA: 0x1C90B8C Offset: 0x1C8CB8C VA: 0x1C90B8C
	private object ReadXmlSerializableElement(XmlTypeMapping typeMap, bool isNullable) { }

	// RVA: 0x1C92950 Offset: 0x1C8E950 VA: 0x1C92950
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
public sealed class XmlSerializationWriteCallback : MulticastDelegate // TypeDefIndex: 3340
{
	// Methods

	// RVA: 0x1C92A94 Offset: 0x1C8EA94 VA: 0x1C92A94
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1C92B9C Offset: 0x1C8EB9C VA: 0x1C92B9C Slot: 12
	public virtual void Invoke(object o) { }
}

// Namespace: 
private class XmlSerializationWriter.WriteCallbackInfo // TypeDefIndex: 3341
{
	// Fields
	public Type Type; // 0x10
	public string TypeName; // 0x18
	public string TypeNs; // 0x20
	public XmlSerializationWriteCallback Callback; // 0x28

	// Methods

	// RVA: 0x1C95D24 Offset: 0x1C91D24 VA: 0x1C95D24
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializationWriter : XmlSerializationGeneratedCode // TypeDefIndex: 3342
{
	// Fields
	private ObjectIDGenerator idGenerator; // 0x10
	private int qnameCount; // 0x18
	private bool topLevelElement; // 0x1C
	private ArrayList namespaces; // 0x20
	private XmlWriter writer; // 0x28
	private Queue referencedElements; // 0x30
	private Hashtable callbacks; // 0x38
	private Hashtable serializedObjects; // 0x40

	// Properties
	protected XmlWriter Writer { get; }

	// Methods

	// RVA: 0x1C92BB0 Offset: 0x1C8EBB0 VA: 0x1C92BB0
	protected void .ctor() { }

	// RVA: 0x1C92C20 Offset: 0x1C8EC20 VA: 0x1C92C20
	internal void Initialize(XmlWriter writer, XmlSerializerNamespaces nss) { }

	// RVA: 0x1C92D50 Offset: 0x1C8ED50 VA: 0x1C92D50
	protected XmlWriter get_Writer() { }

	// RVA: 0x1C92D58 Offset: 0x1C8ED58 VA: 0x1C92D58
	protected void AddWriteCallback(Type type, string typeName, string typeNs, XmlSerializationWriteCallback callback) { }

	// RVA: 0x1C92E70 Offset: 0x1C8EE70 VA: 0x1C92E70
	protected Exception CreateUnknownAnyElementException(string name, string ns) { }

	// RVA: 0x1C92F08 Offset: 0x1C8EF08 VA: 0x1C92F08
	protected Exception CreateUnknownTypeException(object o) { }

	// RVA: 0x1C92F2C Offset: 0x1C8EF2C VA: 0x1C92F2C
	protected Exception CreateUnknownTypeException(Type type) { }

	// RVA: 0x1C92FBC Offset: 0x1C8EFBC VA: 0x1C92FBC
	protected string FromXmlQualifiedName(XmlQualifiedName xmlQualifiedName) { }

	// RVA: 0x1C9313C Offset: 0x1C8F13C VA: 0x1C9313C
	private string GetId(object o, bool addToReferencesList) { }

	// RVA: 0x1C93250 Offset: 0x1C8F250 VA: 0x1C93250
	private bool AlreadyQueued(object ob) { }

	// RVA: 0x1C93284 Offset: 0x1C8F284 VA: 0x1C93284
	private string GetNamespacePrefix(string ns) { }

	// RVA: 0x1C9307C Offset: 0x1C8F07C VA: 0x1C9307C
	private string GetQualifiedName(string name, string ns) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void InitCallbacks();

	// RVA: 0x1C933B4 Offset: 0x1C8F3B4 VA: 0x1C933B4
	protected void TopLevelElement() { }

	// RVA: 0x1C933C0 Offset: 0x1C8F3C0 VA: 0x1C933C0
	protected void WriteAttribute(string localName, string ns, string value) { }

	// RVA: 0x1C93394 Offset: 0x1C8F394 VA: 0x1C93394
	protected void WriteAttribute(string prefix, string localName, string ns, string value) { }

	// RVA: 0x1C933D4 Offset: 0x1C8F3D4 VA: 0x1C933D4
	private void WriteXmlNode(XmlNode node) { }

	// RVA: 0x1C93474 Offset: 0x1C8F474 VA: 0x1C93474
	protected void WriteElementEncoded(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x1C93628 Offset: 0x1C8F628 VA: 0x1C93628
	protected void WriteElementLiteral(XmlNode node, string name, string ns, bool isNullable, bool any) { }

	// RVA: 0x1C937E0 Offset: 0x1C8F7E0 VA: 0x1C937E0
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value) { }

	// RVA: 0x1C937E8 Offset: 0x1C8F7E8 VA: 0x1C937E8
	protected void WriteElementQualifiedName(string localName, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x1C939E4 Offset: 0x1C8F9E4 VA: 0x1C939E4
	protected void WriteElementString(string localName, string ns, string value) { }

	// RVA: 0x1C939EC Offset: 0x1C8F9EC VA: 0x1C939EC
	protected void WriteElementString(string localName, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x1C939C8 Offset: 0x1C8F9C8 VA: 0x1C939C8
	protected void WriteEndElement() { }

	// RVA: 0x1C93B3C Offset: 0x1C8FB3C VA: 0x1C93B3C
	protected void WriteEndElement(object o) { }

	// RVA: 0x1C93B7C Offset: 0x1C8FB7C VA: 0x1C93B7C
	protected void WriteNamespaceDeclarations(XmlSerializerNamespaces xmlns) { }

	// RVA: 0x1C93F68 Offset: 0x1C8FF68 VA: 0x1C93F68
	protected void WriteNullableQualifiedNameEncoded(string name, string ns, XmlQualifiedName value, XmlQualifiedName xsiType) { }

	// RVA: 0x1C94020 Offset: 0x1C90020 VA: 0x1C94020
	protected void WriteNullableQualifiedNameLiteral(string name, string ns, XmlQualifiedName value) { }

	// RVA: 0x1C940D4 Offset: 0x1C900D4 VA: 0x1C940D4
	protected void WriteNullableStringEncoded(string name, string ns, string value, XmlQualifiedName xsiType) { }

	// RVA: 0x1C940E0 Offset: 0x1C900E0 VA: 0x1C940E0
	protected void WriteNullableStringLiteral(string name, string ns, string value) { }

	// RVA: 0x1C93568 Offset: 0x1C8F568 VA: 0x1C93568
	protected void WriteNullTagEncoded(string name, string ns) { }

	// RVA: 0x1C9371C Offset: 0x1C8F71C VA: 0x1C9371C
	protected void WriteNullTagLiteral(string name, string ns) { }

	// RVA: 0x1C940F0 Offset: 0x1C900F0 VA: 0x1C940F0
	protected void WritePotentiallyReferencingElement(string n, string ns, object o, Type ambientType, bool suppressReference, bool isNullable) { }

	// RVA: 0x1C946BC Offset: 0x1C906BC VA: 0x1C946BC
	protected void WriteReferencedElements() { }

	// RVA: 0x1C94600 Offset: 0x1C90600 VA: 0x1C94600
	private bool IsPrimitiveArray(TypeData td) { }

	// RVA: 0x1C948D4 Offset: 0x1C908D4 VA: 0x1C948D4
	private void WriteArray(object o, TypeData td) { }

	// RVA: 0x1C94BC8 Offset: 0x1C90BC8 VA: 0x1C94BC8
	protected void WriteReferencingElement(string n, string ns, object o, bool isNullable) { }

	// RVA: 0x1C94578 Offset: 0x1C90578 VA: 0x1C94578
	private void CheckReferenceQueue() { }

	// RVA: 0x1C94D24 Offset: 0x1C90D24 VA: 0x1C94D24
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable) { }

	// RVA: 0x1C94D2C Offset: 0x1C90D2C VA: 0x1C94D2C
	protected void WriteSerializable(IXmlSerializable serializable, string name, string ns, bool isNullable, bool wrapped) { }

	// RVA: 0x1C94EE0 Offset: 0x1C90EE0 VA: 0x1C94EE0
	protected void WriteStartDocument() { }

	// RVA: 0x1C93904 Offset: 0x1C8F904 VA: 0x1C93904
	protected void WriteStartElement(string name, string ns) { }

	// RVA: 0x1C94568 Offset: 0x1C90568 VA: 0x1C94568
	protected void WriteStartElement(string name, string ns, bool writePrefixed) { }

	// RVA: 0x1C94F30 Offset: 0x1C90F30 VA: 0x1C94F30
	protected void WriteStartElement(string name, string ns, object o) { }

	// RVA: 0x1C94F28 Offset: 0x1C90F28 VA: 0x1C94F28
	protected void WriteStartElement(string name, string ns, object o, bool writePrefixed) { }

	// RVA: 0x1C94F3C Offset: 0x1C90F3C VA: 0x1C94F3C
	private void WriteStartElement(string name, string ns, object o, bool writePrefixed, ICollection namespaces) { }

	// RVA: 0x1C957A0 Offset: 0x1C917A0 VA: 0x1C957A0
	protected void WriteTypedPrimitive(string name, string ns, object o, bool xsiType) { }

	// RVA: 0x1C95A6C Offset: 0x1C91A6C VA: 0x1C95A6C
	protected void WriteValue(string value) { }

	// RVA: 0x1C95A94 Offset: 0x1C91A94 VA: 0x1C95A94
	protected void WriteXmlAttribute(XmlNode node, object container) { }

	// RVA: 0x1C93914 Offset: 0x1C8F914 VA: 0x1C93914
	protected void WriteXsiType(string name, string ns) { }
}

// Namespace: 
private class XmlSerializationWriterInterpreter.CallbackInfo // TypeDefIndex: 3343
{
	// Fields
	private XmlSerializationWriterInterpreter _swi; // 0x10
	private XmlTypeMapping _typeMap; // 0x18

	// Methods

	// RVA: 0x1C96140 Offset: 0x1C92140 VA: 0x1C96140
	public void .ctor(XmlSerializationWriterInterpreter swi, XmlTypeMapping typeMap) { }

	// RVA: 0x1C9C22C Offset: 0x1C9822C VA: 0x1C9C22C
	internal void WriteObject(object ob) { }

	// RVA: 0x1C9C27C Offset: 0x1C9827C VA: 0x1C9C27C
	internal void WriteEnum(object ob) { }
}

// Namespace: System.Xml.Serialization
internal class XmlSerializationWriterInterpreter : XmlSerializationWriter // TypeDefIndex: 3344
{
	// Fields
	private XmlMapping _typeMap; // 0x48
	private SerializationFormat _format; // 0x50

	// Methods

	// RVA: 0x1C95D2C Offset: 0x1C91D2C VA: 0x1C95D2C
	public void .ctor(XmlMapping typeMap) { }

	// RVA: 0x1C95D70 Offset: 0x1C91D70 VA: 0x1C95D70 Slot: 4
	protected override void InitCallbacks() { }

	// RVA: 0x1C96184 Offset: 0x1C92184 VA: 0x1C96184
	public void WriteRoot(object ob) { }

	// RVA: 0x1C96390 Offset: 0x1C92390 VA: 0x1C96390 Slot: 5
	protected virtual void WriteObject(XmlTypeMapping typeMap, object ob, string element, string namesp, bool isNullable, bool needType, bool writeWrappingElem) { }

	// RVA: 0x1C96E98 Offset: 0x1C92E98 VA: 0x1C96E98 Slot: 6
	protected virtual void WriteMessage(XmlMembersMapping membersMap, object[] parameters) { }

	// RVA: 0x1C970C8 Offset: 0x1C930C8 VA: 0x1C970C8 Slot: 7
	protected virtual void WriteObjectElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x1C97300 Offset: 0x1C93300 VA: 0x1C97300 Slot: 8
	protected virtual void WriteObjectElementAttributes(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x1C97A6C Offset: 0x1C93A6C VA: 0x1C97A6C Slot: 9
	protected virtual void WriteObjectElementElements(XmlTypeMapping typeMap, object ob) { }

	// RVA: 0x1C97088 Offset: 0x1C93088 VA: 0x1C97088
	private void WriteMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1C973A4 Offset: 0x1C933A4 VA: 0x1C973A4
	private void WriteAttributeMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1C97B10 Offset: 0x1C93B10 VA: 0x1C97B10
	private void WriteElementMembers(ClassMap map, object ob, bool isValueList) { }

	// RVA: 0x1C98438 Offset: 0x1C94438 VA: 0x1C98438
	private object GetMemberValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x1C98218 Offset: 0x1C94218 VA: 0x1C98218
	private bool MemberHasValue(XmlTypeMapMember member, object ob, bool isValueList) { }

	// RVA: 0x1C98BA0 Offset: 0x1C94BA0 VA: 0x1C98BA0
	private void WriteMemberElement(XmlTypeMapElementInfo elem, object memberValue) { }

	// RVA: 0x1C96A40 Offset: 0x1C92A40 VA: 0x1C96A40
	internal static object ImplicitConvert(object obj, Type type) { }

	// RVA: 0x1C9A798 Offset: 0x1C96798 VA: 0x1C9A798
	private void WritePrimitiveValueLiteral(object memberValue, string name, string ns, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x1C9AAB8 Offset: 0x1C96AB8 VA: 0x1C9AAB8
	private void WritePrimitiveValueEncoded(object memberValue, string name, string ns, XmlQualifiedName xsiType, XmlTypeMapping mappedType, TypeData typeData, bool wrapped, bool isNullable) { }

	// RVA: 0x1C9AD70 Offset: 0x1C96D70 VA: 0x1C9AD70 Slot: 10
	protected virtual void WriteListElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x1C99130 Offset: 0x1C95130 VA: 0x1C99130
	private void WriteListContent(object container, TypeData listType, ListMap map, object ob, StringBuilder targetString) { }

	// RVA: 0x1C9AF50 Offset: 0x1C96F50 VA: 0x1C9AF50
	private int GetListCount(TypeData listType, object ob) { }

	// RVA: 0x1C998E4 Offset: 0x1C958E4 VA: 0x1C998E4
	private void WriteAnyElementContent(XmlTypeMapMemberAnyElement member, object memberValue) { }

	// RVA: 0x1C9BD9C Offset: 0x1C97D9C VA: 0x1C9BD9C Slot: 11
	protected virtual void WritePrimitiveElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x1C9BDD8 Offset: 0x1C97DD8 VA: 0x1C9BDD8 Slot: 12
	protected virtual void WriteEnumElement(XmlTypeMapping typeMap, object ob, string element, string namesp) { }

	// RVA: 0x1C988F4 Offset: 0x1C948F4 VA: 0x1C988F4
	private string GetStringValue(XmlTypeMapping typeMap, TypeData type, object value) { }

	// RVA: 0x1C9BE08 Offset: 0x1C97E08 VA: 0x1C9BE08
	private string GetEnumXmlValue(XmlTypeMapping typeMap, object ob) { }
}

// Namespace: 
internal class XmlSerializer.SerializerData // TypeDefIndex: 3345
{
	// Fields
	public MethodInfo ReaderMethod; // 0x10
	public Type WriterType; // 0x18
	public MethodInfo WriterMethod; // 0x20
	public XmlSerializerImplementation Implementation; // 0x28

	// Methods

	// RVA: 0x1C9D1F4 Offset: 0x1C991F4 VA: 0x1C9D1F4
	public XmlSerializationWriter CreateWriter() { }
}

// Namespace: System.Xml.Serialization
public class XmlSerializer // TypeDefIndex: 3346
{
	// Fields
	private static int generationThreshold; // 0x0
	private static bool backgroundGeneration; // 0x4
	private static bool deleteTempFiles; // 0x5
	private static bool generatorFallback; // 0x6
	private bool customSerializer; // 0x10
	private XmlMapping typeMapping; // 0x18
	private XmlSerializer.SerializerData serializerData; // 0x20
	private static Hashtable serializerTypes; // 0x8
	private UnreferencedObjectEventHandler onUnreferencedObject; // 0x28
	private XmlAttributeEventHandler onUnknownAttribute; // 0x30
	private XmlElementEventHandler onUnknownElement; // 0x38
	private XmlNodeEventHandler onUnknownNode; // 0x40

	// Properties
	internal XmlMapping Mapping { get; }

	// Methods

	// RVA: 0x1C9C2CC Offset: 0x1C982CC VA: 0x1C9C2CC
	private static void .cctor() { }

	// RVA: 0x1C9C380 Offset: 0x1C98380 VA: 0x1C9C380
	public void .ctor(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1C9C504 Offset: 0x1C98504 VA: 0x1C9C504
	internal XmlMapping get_Mapping() { }

	// RVA: 0x1C9C50C Offset: 0x1C9850C VA: 0x1C9C50C Slot: 4
	internal virtual void OnUnknownAttribute(XmlAttributeEventArgs e) { }

	// RVA: 0x1C9C534 Offset: 0x1C98534 VA: 0x1C9C534 Slot: 5
	internal virtual void OnUnknownElement(XmlElementEventArgs e) { }

	// RVA: 0x1C9C55C Offset: 0x1C9855C VA: 0x1C9C55C Slot: 6
	internal virtual void OnUnknownNode(XmlNodeEventArgs e) { }

	// RVA: 0x1C9C584 Offset: 0x1C98584 VA: 0x1C9C584 Slot: 7
	internal virtual void OnUnreferencedObject(UnreferencedObjectEventArgs e) { }

	// RVA: 0x1C9C5AC Offset: 0x1C985AC VA: 0x1C9C5AC Slot: 8
	protected virtual XmlSerializationReader CreateReader() { }

	// RVA: 0x1C9C5E4 Offset: 0x1C985E4 VA: 0x1C9C5E4 Slot: 9
	protected virtual XmlSerializationWriter CreateWriter() { }

	// RVA: 0x1C9C61C Offset: 0x1C9861C VA: 0x1C9C61C
	public object Deserialize(TextReader textReader) { }

	// RVA: 0x1C9C6B0 Offset: 0x1C986B0 VA: 0x1C9C6B0
	public object Deserialize(XmlReader xmlReader) { }

	// RVA: 0x1C9C77C Offset: 0x1C9877C VA: 0x1C9C77C Slot: 10
	protected virtual object Deserialize(XmlSerializationReader reader) { }

	// RVA: 0x1C9CA54 Offset: 0x1C98A54 VA: 0x1C9CA54 Slot: 11
	protected virtual void Serialize(object o, XmlSerializationWriter writer) { }

	// RVA: 0x1C9CC48 Offset: 0x1C98C48 VA: 0x1C9CC48
	public void Serialize(TextWriter textWriter, object o) { }

	// RVA: 0x1C9CFEC Offset: 0x1C98FEC VA: 0x1C9CFEC
	public void Serialize(XmlWriter xmlWriter, object o) { }

	// RVA: 0x1C9CCD8 Offset: 0x1C98CD8 VA: 0x1C9CCD8
	public void Serialize(XmlWriter xmlWriter, object o, XmlSerializerNamespaces namespaces) { }

	// RVA: 0x1C9CFF4 Offset: 0x1C98FF4 VA: 0x1C9CFF4
	private XmlSerializationWriter CreateWriter(XmlMapping typeMapping) { }

	// RVA: 0x1C9C720 Offset: 0x1C98720 VA: 0x1C9C720
	private XmlSerializationReader CreateReader(XmlMapping typeMapping) { }
}

// Namespace: System.Xml.Serialization
public class XmlSerializerFactory // TypeDefIndex: 3347
{
	// Fields
	private static Hashtable serializersBySource; // 0x0

	// Methods

	// RVA: 0x1C9D2C0 Offset: 0x1C992C0 VA: 0x1C9D2C0
	public void .ctor() { }

	// RVA: 0x1C9D2C8 Offset: 0x1C992C8 VA: 0x1C9D2C8
	public XmlSerializer CreateSerializer(Type type) { }

	// RVA: 0x1C9D558 Offset: 0x1C99558 VA: 0x1C9D558
	public XmlSerializer CreateSerializer(Type type, XmlRootAttribute root) { }

	// RVA: 0x1C9D2DC Offset: 0x1C992DC VA: 0x1C9D2DC
	public XmlSerializer CreateSerializer(Type type, XmlAttributeOverrides overrides, Type[] extraTypes, XmlRootAttribute root, string defaultNamespace) { }

	// RVA: 0x1C9D56C Offset: 0x1C9956C VA: 0x1C9D56C
	private static void .cctor() { }
}

// Namespace: System.Xml.Serialization
public abstract class XmlSerializerImplementation // TypeDefIndex: 3348
{
	// Properties
	public virtual XmlSerializationWriter Writer { get; }

	// Methods

	// RVA: 0x1C9D5E8 Offset: 0x1C995E8 VA: 0x1C9D5E8 Slot: 4
	public virtual XmlSerializationWriter get_Writer() { }
}

// Namespace: System.Xml.Serialization
[Usage(10624)]
public class XmlTextAttribute : Attribute // TypeDefIndex: 3349
{
	// Fields
	private string dataType; // 0x10
	private Type type; // 0x18

	// Properties
	public string DataType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x1C9D620 Offset: 0x1C99620 VA: 0x1C9D620
	public void .ctor() { }

	// RVA: 0x1C9D628 Offset: 0x1C99628 VA: 0x1C9D628
	public string get_DataType() { }

	// RVA: 0x1C9D64C Offset: 0x1C9964C VA: 0x1C9D64C
	public Type get_Type() { }

	// RVA: 0x1C9D654 Offset: 0x1C99654 VA: 0x1C9D654
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
[Usage(1052)]
public class XmlTypeAttribute : Attribute // TypeDefIndex: 3350
{
	// Fields
	private bool includeInSchema; // 0x10
	private string ns; // 0x18
	private string typeName; // 0x20

	// Properties
	public bool IncludeInSchema { get; }
	public string Namespace { get; }
	public string TypeName { get; }

	// Methods

	// RVA: 0x1C9D6E4 Offset: 0x1C996E4 VA: 0x1C9D6E4
	public bool get_IncludeInSchema() { }

	// RVA: 0x1C9D6EC Offset: 0x1C996EC VA: 0x1C9D6EC
	public string get_Namespace() { }

	// RVA: 0x1C9D6F4 Offset: 0x1C996F4 VA: 0x1C9D6F4
	public string get_TypeName() { }

	// RVA: 0x1C9D718 Offset: 0x1C99718 VA: 0x1C9D718
	internal void AddKeyHash(StringBuilder sb) { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapElementInfo // TypeDefIndex: 3351
{
	// Fields
	private string _elementName; // 0x10
	private string _namespace; // 0x18
	private XmlSchemaForm _form; // 0x20
	private XmlTypeMapMember _member; // 0x28
	private object _choiceValue; // 0x30
	private bool _isNullable; // 0x38
	private int _nestingLevel; // 0x3C
	private XmlTypeMapping _mappedType; // 0x40
	private TypeData _type; // 0x48
	private bool _wrappedElement; // 0x50
	private int _explicitOrder; // 0x54

	// Properties
	public TypeData TypeData { get; }
	public object ChoiceValue { get; set; }
	public string ElementName { get; set; }
	public string Namespace { get; set; }
	public string DataTypeNamespace { get; }
	public string DataTypeName { get; }
	public XmlSchemaForm Form { get; set; }
	public XmlTypeMapping MappedType { get; set; }
	public bool IsNullable { get; set; }
	public XmlTypeMapMember Member { get; }
	public int NestingLevel { set; }
	public bool MultiReferenceType { get; }
	public bool WrappedElement { get; set; }
	public bool IsTextElement { get; set; }
	public bool IsUnnamedAnyElement { get; set; }
	public int ExplicitOrder { get; set; }

	// Methods

	// RVA: 0x1C9D7BC Offset: 0x1C997BC VA: 0x1C9D7BC
	public void .ctor(XmlTypeMapMember member, TypeData type) { }

	// RVA: 0x1C9D888 Offset: 0x1C99888 VA: 0x1C9D888
	public TypeData get_TypeData() { }

	// RVA: 0x1C9D890 Offset: 0x1C99890 VA: 0x1C9D890
	public object get_ChoiceValue() { }

	// RVA: 0x1C9D898 Offset: 0x1C99898 VA: 0x1C9D898
	public void set_ChoiceValue(object value) { }

	// RVA: 0x1C9D8A0 Offset: 0x1C998A0 VA: 0x1C9D8A0
	public string get_ElementName() { }

	// RVA: 0x1C9D8A8 Offset: 0x1C998A8 VA: 0x1C9D8A8
	public void set_ElementName(string value) { }

	// RVA: 0x1C9D8B0 Offset: 0x1C998B0 VA: 0x1C9D8B0
	public string get_Namespace() { }

	// RVA: 0x1C9D8B8 Offset: 0x1C998B8 VA: 0x1C9D8B8
	public void set_Namespace(string value) { }

	// RVA: 0x1C9AA50 Offset: 0x1C96A50 VA: 0x1C9AA50
	public string get_DataTypeNamespace() { }

	// RVA: 0x1C9AA24 Offset: 0x1C96A24 VA: 0x1C9AA24
	public string get_DataTypeName() { }

	// RVA: 0x1C9D8C0 Offset: 0x1C998C0 VA: 0x1C9D8C0
	public XmlSchemaForm get_Form() { }

	// RVA: 0x1C9D8C8 Offset: 0x1C998C8 VA: 0x1C9D8C8
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x1C9D8D0 Offset: 0x1C998D0 VA: 0x1C9D8D0
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x1C9D8D8 Offset: 0x1C998D8 VA: 0x1C9D8D8
	public void set_MappedType(XmlTypeMapping value) { }

	// RVA: 0x1C9D8E0 Offset: 0x1C998E0 VA: 0x1C9D8E0
	public bool get_IsNullable() { }

	// RVA: 0x1C9D8E8 Offset: 0x1C998E8 VA: 0x1C9D8E8
	public void set_IsNullable(bool value) { }

	// RVA: 0x1C9D8F0 Offset: 0x1C998F0 VA: 0x1C9D8F0
	public XmlTypeMapMember get_Member() { }

	// RVA: 0x1C9D8F8 Offset: 0x1C998F8 VA: 0x1C9D8F8
	public void set_NestingLevel(int value) { }

	// RVA: 0x1C9D900 Offset: 0x1C99900 VA: 0x1C9D900
	public bool get_MultiReferenceType() { }

	// RVA: 0x1C9D920 Offset: 0x1C99920 VA: 0x1C9D920
	public bool get_WrappedElement() { }

	// RVA: 0x1C9D928 Offset: 0x1C99928 VA: 0x1C9D928
	public void set_WrappedElement(bool value) { }

	// RVA: 0x1C9D930 Offset: 0x1C99930 VA: 0x1C9D930
	public bool get_IsTextElement() { }

	// RVA: 0x1C9D97C Offset: 0x1C9997C VA: 0x1C9D97C
	public void set_IsTextElement(bool value) { }

	// RVA: 0x1C9DA38 Offset: 0x1C99A38 VA: 0x1C9DA38
	public bool get_IsUnnamedAnyElement() { }

	// RVA: 0x1C9DA58 Offset: 0x1C99A58 VA: 0x1C9DA58
	public void set_IsUnnamedAnyElement(bool value) { }

	// RVA: 0x1C9DAEC Offset: 0x1C99AEC VA: 0x1C9DAEC
	public int get_ExplicitOrder() { }

	// RVA: 0x1C9DAF4 Offset: 0x1C99AF4 VA: 0x1C9DAF4
	public void set_ExplicitOrder(int value) { }

	// RVA: 0x1C9DAFC Offset: 0x1C99AFC VA: 0x1C9DAFC Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1C9DC34 Offset: 0x1C99C34 VA: 0x1C9DC34 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapElementInfoList : ArrayList // TypeDefIndex: 3352
{
	// Methods

	// RVA: 0x1C9DC3C Offset: 0x1C99C3C VA: 0x1C9DC3C
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMember // TypeDefIndex: 3353
{
	// Fields
	private string _name; // 0x10
	private int _index; // 0x18
	private int _globalIndex; // 0x1C
	private int _specifiedGlobalIndex; // 0x20
	private TypeData _typeData; // 0x28
	private MemberInfo _member; // 0x30
	private MemberInfo _specifiedMember; // 0x38
	private MethodInfo _shouldSerialize; // 0x40
	private object _defaultValue; // 0x48
	private int _flags; // 0x50

	// Properties
	public string Name { get; set; }
	public object DefaultValue { get; set; }
	public TypeData TypeData { get; set; }
	public int Index { get; set; }
	public int GlobalIndex { get; set; }
	public bool IsOptionalValueType { get; set; }
	public bool IsReturnValue { get; set; }

	// Methods

	// RVA: 0x1C9DC44 Offset: 0x1C99C44 VA: 0x1C9DC44
	public void .ctor() { }

	// RVA: 0x1C9DCBC Offset: 0x1C99CBC VA: 0x1C9DCBC
	public string get_Name() { }

	// RVA: 0x1C9DCC4 Offset: 0x1C99CC4 VA: 0x1C9DCC4
	public void set_Name(string value) { }

	// RVA: 0x1C9DCCC Offset: 0x1C99CCC VA: 0x1C9DCCC
	public object get_DefaultValue() { }

	// RVA: 0x1C9DCD4 Offset: 0x1C99CD4 VA: 0x1C9DCD4
	public void set_DefaultValue(object value) { }

	// RVA: 0x1C9DCDC Offset: 0x1C99CDC VA: 0x1C9DCDC
	public bool IsReadOnly(Type type) { }

	// RVA: 0x1C9DFE4 Offset: 0x1C99FE4 VA: 0x1C9DFE4
	public static object GetValue(object ob, string name) { }

	// RVA: 0x1C971F0 Offset: 0x1C931F0 VA: 0x1C971F0
	public object GetValue(object ob) { }

	// RVA: 0x1C9E100 Offset: 0x1C9A100 VA: 0x1C9E100
	public void SetValue(object ob, object value) { }

	// RVA: 0x1C9E234 Offset: 0x1C9A234 VA: 0x1C9E234
	public static void SetValue(object ob, string name, object value) { }

	// RVA: 0x1C9DD90 Offset: 0x1C99D90 VA: 0x1C9DD90
	private void InitMember(Type type) { }

	// RVA: 0x1C9E364 Offset: 0x1C9A364 VA: 0x1C9E364
	public TypeData get_TypeData() { }

	// RVA: 0x1C9E36C Offset: 0x1C9A36C VA: 0x1C9E36C
	public void set_TypeData(TypeData value) { }

	// RVA: 0x1C9E374 Offset: 0x1C9A374 VA: 0x1C9E374
	public int get_Index() { }

	// RVA: 0x1C9E37C Offset: 0x1C9A37C VA: 0x1C9E37C
	public void set_Index(int value) { }

	// RVA: 0x1C9E384 Offset: 0x1C9A384 VA: 0x1C9E384
	public int get_GlobalIndex() { }

	// RVA: 0x1C9E38C Offset: 0x1C9A38C VA: 0x1C9E38C
	public void set_GlobalIndex(int value) { }

	// RVA: 0x1C9A55C Offset: 0x1C9655C VA: 0x1C9A55C
	public bool get_IsOptionalValueType() { }

	// RVA: 0x1C9E394 Offset: 0x1C9A394 VA: 0x1C9E394
	public void set_IsOptionalValueType(bool value) { }

	// RVA: 0x1C9E3A4 Offset: 0x1C9A3A4 VA: 0x1C9E3A4
	public bool get_IsReturnValue() { }

	// RVA: 0x1C9E3B0 Offset: 0x1C9A3B0 VA: 0x1C9E3B0
	public void set_IsReturnValue(bool value) { }

	// RVA: 0x1C9E3D0 Offset: 0x1C9A3D0 VA: 0x1C9E3D0
	public void CheckOptionalValueType(Type type) { }

	// RVA: 0x1C9A568 Offset: 0x1C96568 VA: 0x1C9A568
	public bool GetValueSpecified(object ob) { }

	// RVA: 0x1C9E44C Offset: 0x1C9A44C VA: 0x1C9E44C
	public void SetValueSpecified(object ob, bool value) { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAttribute : XmlTypeMapMember // TypeDefIndex: 3354
{
	// Fields
	private string _attributeName; // 0x58
	private string _namespace; // 0x60
	private XmlSchemaForm _form; // 0x68
	private XmlTypeMapping _mappedType; // 0x70

	// Properties
	public string AttributeName { get; set; }
	public string Namespace { get; set; }
	public XmlSchemaForm Form { set; }
	public XmlTypeMapping MappedType { get; set; }

	// Methods

	// RVA: 0x1C9E6C4 Offset: 0x1C9A6C4 VA: 0x1C9E6C4
	public void .ctor() { }

	// RVA: 0x1C9E718 Offset: 0x1C9A718 VA: 0x1C9E718
	public string get_AttributeName() { }

	// RVA: 0x1C9E720 Offset: 0x1C9A720 VA: 0x1C9E720
	public void set_AttributeName(string value) { }

	// RVA: 0x1C9E728 Offset: 0x1C9A728 VA: 0x1C9E728
	public string get_Namespace() { }

	// RVA: 0x1C9E730 Offset: 0x1C9A730 VA: 0x1C9E730
	public void set_Namespace(string value) { }

	// RVA: 0x1C9E738 Offset: 0x1C9A738 VA: 0x1C9E738
	public void set_Form(XmlSchemaForm value) { }

	// RVA: 0x1C9E740 Offset: 0x1C9A740 VA: 0x1C9E740
	public XmlTypeMapping get_MappedType() { }

	// RVA: 0x1C9E748 Offset: 0x1C9A748 VA: 0x1C9E748
	public void set_MappedType(XmlTypeMapping value) { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberElement : XmlTypeMapMember // TypeDefIndex: 3355
{
	// Fields
	private XmlTypeMapElementInfoList _elementInfo; // 0x58
	private string _choiceMember; // 0x60
	private bool _isTextCollector; // 0x68
	private TypeData _choiceTypeData; // 0x70

	// Properties
	public XmlTypeMapElementInfoList ElementInfo { get; set; }
	public string ChoiceMember { get; set; }
	public TypeData ChoiceTypeData { get; set; }
	public bool IsXmlTextCollector { get; set; }

	// Methods

	// RVA: 0x1C9E750 Offset: 0x1C9A750 VA: 0x1C9E750
	public void .ctor() { }

	// RVA: 0x1C98B30 Offset: 0x1C94B30 VA: 0x1C98B30
	public XmlTypeMapElementInfoList get_ElementInfo() { }

	// RVA: 0x1C9E754 Offset: 0x1C9A754 VA: 0x1C9E754
	public void set_ElementInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x1C9E75C Offset: 0x1C9A75C VA: 0x1C9E75C
	public string get_ChoiceMember() { }

	// RVA: 0x1C9E764 Offset: 0x1C9A764 VA: 0x1C9E764
	public void set_ChoiceMember(string value) { }

	// RVA: 0x1C9E76C Offset: 0x1C9A76C VA: 0x1C9E76C
	public TypeData get_ChoiceTypeData() { }

	// RVA: 0x1C9E774 Offset: 0x1C9A774 VA: 0x1C9E774
	public void set_ChoiceTypeData(TypeData value) { }

	// RVA: 0x1C99ED0 Offset: 0x1C95ED0 VA: 0x1C99ED0
	public XmlTypeMapElementInfo FindElement(object ob, object memberValue) { }

	// RVA: 0x1C9E77C Offset: 0x1C9A77C VA: 0x1C9E77C
	public void SetChoice(object ob, object choice) { }

	// RVA: 0x1C9E78C Offset: 0x1C9A78C VA: 0x1C9E78C
	public bool get_IsXmlTextCollector() { }

	// RVA: 0x1C9E794 Offset: 0x1C9A794 VA: 0x1C9E794
	public void set_IsXmlTextCollector(bool value) { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberList : XmlTypeMapMemberElement // TypeDefIndex: 3356
{
	// Methods

	// RVA: 0x1C9E79C Offset: 0x1C9A79C VA: 0x1C9E79C
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberExpandable : XmlTypeMapMemberElement // TypeDefIndex: 3357
{
	// Fields
	private int _flatArrayIndex; // 0x78

	// Properties
	public int FlatArrayIndex { get; set; }

	// Methods

	// RVA: 0x1C9E7A0 Offset: 0x1C9A7A0 VA: 0x1C9E7A0
	public int get_FlatArrayIndex() { }

	// RVA: 0x1C9E7A8 Offset: 0x1C9A7A8 VA: 0x1C9E7A8
	public void set_FlatArrayIndex(int value) { }

	// RVA: 0x1C9E7B0 Offset: 0x1C9A7B0 VA: 0x1C9E7B0
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberFlatList : XmlTypeMapMemberExpandable // TypeDefIndex: 3358
{
	// Fields
	private ListMap _listMap; // 0x80

	// Properties
	public ListMap ListMap { get; set; }

	// Methods

	// RVA: 0x1C9E7B4 Offset: 0x1C9A7B4 VA: 0x1C9E7B4
	public ListMap get_ListMap() { }

	// RVA: 0x1C9E7BC Offset: 0x1C9A7BC VA: 0x1C9E7BC
	public void set_ListMap(ListMap value) { }

	// RVA: 0x1C9E7C4 Offset: 0x1C9A7C4 VA: 0x1C9E7C4
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyElement : XmlTypeMapMemberExpandable // TypeDefIndex: 3359
{
	// Properties
	public bool IsDefaultAny { get; }

	// Methods

	// RVA: 0x1C9BA78 Offset: 0x1C97A78 VA: 0x1C9BA78
	public bool IsElementDefined(string name, string ns) { }

	// RVA: 0x1C9E7C8 Offset: 0x1C9A7C8 VA: 0x1C9E7C8
	public bool get_IsDefaultAny() { }

	// RVA: 0x1C9EAA4 Offset: 0x1C9AAA4 VA: 0x1C9EAA4
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberAnyAttribute : XmlTypeMapMember // TypeDefIndex: 3360
{
	// Methods

	// RVA: 0x1C9EAA8 Offset: 0x1C9AAA8 VA: 0x1C9EAA8
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class XmlTypeMapMemberNamespaces : XmlTypeMapMember // TypeDefIndex: 3361
{
	// Methods

	// RVA: 0x1C9EAAC Offset: 0x1C9AAAC VA: 0x1C9EAAC
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
public class XmlTypeMapping : XmlMapping // TypeDefIndex: 3362
{
	// Fields
	private string xmlType; // 0x48
	private string xmlTypeNamespace; // 0x50
	private TypeData type; // 0x58
	private XmlTypeMapping baseMap; // 0x60
	private bool multiReferenceType; // 0x68
	private bool includeInSchema; // 0x69
	private bool isNullable; // 0x6A
	private bool isAny; // 0x6B
	private ArrayList _derivedTypes; // 0x70

	// Properties
	public string TypeFullName { get; }
	internal TypeData TypeData { get; }
	internal string XmlType { get; set; }
	internal string XmlTypeNamespace { get; set; }
	internal bool HasXmlTypeNamespace { get; }
	internal ArrayList DerivedTypes { get; }
	internal bool MultiReferenceType { get; }
	internal XmlTypeMapping BaseMap { get; set; }
	internal bool IncludeInSchema { set; }
	internal bool IsNullable { get; set; }
	internal bool IsAny { get; set; }

	// Methods

	// RVA: 0x1C9EAB0 Offset: 0x1C9AAB0 VA: 0x1C9EAB0
	internal void .ctor(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }

	// RVA: 0x1C9BEB0 Offset: 0x1C97EB0 VA: 0x1C9BEB0
	public string get_TypeFullName() { }

	// RVA: 0x1C9EB88 Offset: 0x1C9AB88 VA: 0x1C9EB88
	internal TypeData get_TypeData() { }

	// RVA: 0x1C9EB90 Offset: 0x1C9AB90 VA: 0x1C9EB90
	internal string get_XmlType() { }

	// RVA: 0x1C9EB98 Offset: 0x1C9AB98 VA: 0x1C9EB98
	internal void set_XmlType(string value) { }

	// RVA: 0x1C96E74 Offset: 0x1C92E74 VA: 0x1C96E74
	internal string get_XmlTypeNamespace() { }

	// RVA: 0x1C9EBA0 Offset: 0x1C9ABA0 VA: 0x1C9EBA0
	internal void set_XmlTypeNamespace(string value) { }

	// RVA: 0x1C9EBA8 Offset: 0x1C9ABA8 VA: 0x1C9EBA8
	internal bool get_HasXmlTypeNamespace() { }

	// RVA: 0x1C9EBB8 Offset: 0x1C9ABB8 VA: 0x1C9EBB8
	internal ArrayList get_DerivedTypes() { }

	// RVA: 0x1C9EBC0 Offset: 0x1C9ABC0 VA: 0x1C9EBC0
	internal bool get_MultiReferenceType() { }

	// RVA: 0x1C9EBC8 Offset: 0x1C9ABC8 VA: 0x1C9EBC8
	internal XmlTypeMapping get_BaseMap() { }

	// RVA: 0x1C9EBD0 Offset: 0x1C9ABD0 VA: 0x1C9EBD0
	internal void set_BaseMap(XmlTypeMapping value) { }

	// RVA: 0x1C9EBD8 Offset: 0x1C9ABD8 VA: 0x1C9EBD8
	internal void set_IncludeInSchema(bool value) { }

	// RVA: 0x1C9EBE0 Offset: 0x1C9ABE0 VA: 0x1C9EBE0
	internal bool get_IsNullable() { }

	// RVA: 0x1C9EBE8 Offset: 0x1C9ABE8 VA: 0x1C9EBE8
	internal void set_IsNullable(bool value) { }

	// RVA: 0x1C9EBF0 Offset: 0x1C9ABF0 VA: 0x1C9EBF0
	internal bool get_IsAny() { }

	// RVA: 0x1C9EBF8 Offset: 0x1C9ABF8 VA: 0x1C9EBF8
	internal void set_IsAny(bool value) { }

	// RVA: 0x1C96D10 Offset: 0x1C92D10 VA: 0x1C96D10
	internal XmlTypeMapping GetRealTypeMap(Type objectType) { }

	// RVA: 0x1C9EC00 Offset: 0x1C9AC00 VA: 0x1C9EC00
	internal XmlTypeMapping GetRealElementMap(string name, string ens) { }

	// RVA: 0x1C9EF50 Offset: 0x1C9AF50 VA: 0x1C9EF50
	internal void UpdateRoot(XmlQualifiedName qname) { }
}

// Namespace: System.Xml.Serialization
internal class XmlSerializableMapping : XmlTypeMapping // TypeDefIndex: 3363
{
	// Fields
	private XmlSchema _schema; // 0x78
	private XmlSchemaComplexType _schemaType; // 0x80
	private XmlQualifiedName _schemaTypeName; // 0x88

	// Methods

	// RVA: 0x1C9EFF4 Offset: 0x1C9AFF4 VA: 0x1C9EFF4
	internal void .ctor(XmlRootAttribute root, string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace) { }
}

// Namespace: System.Xml.Serialization
internal class ClassMap : ObjectMap // TypeDefIndex: 3364
{
	// Fields
	private Hashtable _elements; // 0x10
	private ArrayList _elementMembers; // 0x18
	private Hashtable _attributeMembers; // 0x20
	private XmlTypeMapMemberAttribute[] _attributeMembersArray; // 0x28
	private ArrayList _flatLists; // 0x30
	private ArrayList _allMembers; // 0x38
	private ArrayList _membersWithDefault; // 0x40
	private ArrayList _listMembers; // 0x48
	private XmlTypeMapMemberAnyElement _defaultAnyElement; // 0x50
	private XmlTypeMapMemberAnyAttribute _defaultAnyAttribute; // 0x58
	private XmlTypeMapMemberNamespaces _namespaceDeclarations; // 0x60
	private XmlTypeMapMember _xmlTextCollector; // 0x68
	private XmlTypeMapMember _returnMember; // 0x70
	private bool _ignoreMemberNamespace; // 0x78
	private bool _canBeSimpleType; // 0x79
	private Nullable<bool> _isOrderDependentMap; // 0x7A

	// Properties
	public bool IsOrderDependentMap { get; }
	public XmlTypeMapMemberAnyElement DefaultAnyElementMember { get; }
	public XmlTypeMapMemberAnyAttribute DefaultAnyAttributeMember { get; }
	public XmlTypeMapMemberNamespaces NamespaceDeclarations { get; }
	public ICollection AttributeMembers { get; }
	public ICollection ElementMembers { get; }
	public ArrayList AllMembers { get; }
	public ArrayList FlatLists { get; }
	public ArrayList ListMembers { get; }
	public XmlTypeMapMember XmlTextCollector { get; }
	public XmlTypeMapMember ReturnMember { get; }
	public XmlQualifiedName SimpleContentBaseType { get; }
	public bool HasSimpleContent { get; }

	// Methods

	// RVA: 0x1C9F7EC Offset: 0x1C9B7EC VA: 0x1C9F7EC
	public void AddMember(XmlTypeMapMember member) { }

	// RVA: 0x1CA03F8 Offset: 0x1C9C3F8 VA: 0x1CA03F8
	private void RegisterFlatList(XmlTypeMapMemberExpandable member) { }

	// RVA: 0x1CA04A8 Offset: 0x1C9C4A8 VA: 0x1CA04A8
	public XmlTypeMapMemberAttribute GetAttribute(string name, string ns) { }

	// RVA: 0x1CA0564 Offset: 0x1C9C564 VA: 0x1CA0564
	public XmlTypeMapElementInfo GetElement(string name, string ns, int minimalOrder) { }

	// RVA: 0x1CA0910 Offset: 0x1C9C910 VA: 0x1CA0910
	public XmlTypeMapElementInfo GetElement(string name, string ns) { }

	// RVA: 0x1CA0318 Offset: 0x1C9C318 VA: 0x1CA0318
	private string BuildKey(string name, string ns, int explicitOrder) { }

	// RVA: 0x1CA0C78 Offset: 0x1C9CC78 VA: 0x1CA0C78
	public bool get_IsOrderDependentMap() { }

	// RVA: 0x1CA1014 Offset: 0x1C9D014 VA: 0x1CA1014
	public XmlTypeMapMemberAnyElement get_DefaultAnyElementMember() { }

	// RVA: 0x1CA101C Offset: 0x1C9D01C VA: 0x1CA101C
	public XmlTypeMapMemberAnyAttribute get_DefaultAnyAttributeMember() { }

	// RVA: 0x1CA1024 Offset: 0x1C9D024 VA: 0x1CA1024
	public XmlTypeMapMemberNamespaces get_NamespaceDeclarations() { }

	// RVA: 0x1C98504 Offset: 0x1C94504 VA: 0x1C98504
	public ICollection get_AttributeMembers() { }

	// RVA: 0x1CA102C Offset: 0x1C9D02C VA: 0x1CA102C
	public ICollection get_ElementMembers() { }

	// RVA: 0x1CA1034 Offset: 0x1C9D034 VA: 0x1CA1034
	public ArrayList get_AllMembers() { }

	// RVA: 0x1CA103C Offset: 0x1C9D03C VA: 0x1CA103C
	public ArrayList get_FlatLists() { }

	// RVA: 0x1CA1044 Offset: 0x1C9D044 VA: 0x1CA1044
	public ArrayList get_ListMembers() { }

	// RVA: 0x1CA104C Offset: 0x1C9D04C VA: 0x1CA104C
	public XmlTypeMapMember get_XmlTextCollector() { }

	// RVA: 0x1CA1054 Offset: 0x1C9D054 VA: 0x1CA1054
	public XmlTypeMapMember get_ReturnMember() { }

	// RVA: 0x1CA105C Offset: 0x1C9D05C VA: 0x1CA105C
	public XmlQualifiedName get_SimpleContentBaseType() { }

	// RVA: 0x1CA1230 Offset: 0x1C9D230 VA: 0x1CA1230
	public void SetCanBeSimpleType(bool can) { }

	// RVA: 0x1CA1238 Offset: 0x1C9D238 VA: 0x1CA1238
	public bool get_HasSimpleContent() { }

	// RVA: 0x1CA12A4 Offset: 0x1C9D2A4 VA: 0x1CA12A4
	public void .ctor() { }
}

// Namespace: System.Xml.Serialization
internal class ListMap : ObjectMap // TypeDefIndex: 3365
{
	// Fields
	private XmlTypeMapElementInfoList _itemInfo; // 0x10
	private string _choiceMember; // 0x18

	// Properties
	public string ChoiceMember { set; }
	public XmlTypeMapElementInfoList ItemInfo { get; set; }

	// Methods

	// RVA: 0x1CA1358 Offset: 0x1C9D358 VA: 0x1CA1358
	public void set_ChoiceMember(string value) { }

	// RVA: 0x1CA1360 Offset: 0x1C9D360 VA: 0x1CA1360
	public XmlTypeMapElementInfoList get_ItemInfo() { }

	// RVA: 0x1CA1368 Offset: 0x1C9D368 VA: 0x1CA1368
	public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x1C9B298 Offset: 0x1C97298 VA: 0x1C9B298
	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	// RVA: 0x1CA1370 Offset: 0x1C9D370 VA: 0x1CA1370
	public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	// RVA: 0x1CA165C Offset: 0x1C9D65C VA: 0x1CA165C
	public XmlTypeMapElementInfo FindTextElement() { }

	// RVA: 0x1C9B060 Offset: 0x1C97060 VA: 0x1C9B060
	public void GetArrayType(int itemCount, out string localName, out string ns) { }

	// RVA: 0x1CA1918 Offset: 0x1C9D918 VA: 0x1CA1918 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1CA1A70 Offset: 0x1C9DA70 VA: 0x1CA1A70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CA1A78 Offset: 0x1C9DA78 VA: 0x1CA1A78
	public void .ctor() { }
}

// Namespace: 
public class EnumMap.EnumMapMember // TypeDefIndex: 3366
{
	// Fields
	private readonly string _xmlName; // 0x10
	private readonly string _enumName; // 0x18
	private readonly long _value; // 0x20

	// Properties
	public string XmlName { get; }
	public string EnumName { get; }
	public long Value { get; }

	// Methods

	// RVA: 0x1CA1F18 Offset: 0x1C9DF18 VA: 0x1CA1F18
	public void .ctor(string xmlName, string enumName, long value) { }

	// RVA: 0x1CA1F70 Offset: 0x1C9DF70 VA: 0x1CA1F70
	public string get_XmlName() { }

	// RVA: 0x1CA1F78 Offset: 0x1C9DF78 VA: 0x1CA1F78
	public string get_EnumName() { }

	// RVA: 0x1CA1F80 Offset: 0x1C9DF80 VA: 0x1CA1F80
	public long get_Value() { }
}

// Namespace: System.Xml.Serialization
internal class EnumMap : ObjectMap // TypeDefIndex: 3367
{
	// Fields
	private readonly EnumMap.EnumMapMember[] _members; // 0x10
	private readonly bool _isFlags; // 0x18
	private readonly string[] _enumNames; // 0x20
	private readonly string[] _xmlNames; // 0x28
	private readonly long[] _values; // 0x30

	// Properties
	public bool IsFlags { get; }
	public string[] EnumNames { get; }
	public string[] XmlNames { get; }
	public long[] Values { get; }

	// Methods

	// RVA: 0x1CA1A80 Offset: 0x1C9DA80 VA: 0x1CA1A80
	public void .ctor(EnumMap.EnumMapMember[] members, bool isFlags) { }

	// RVA: 0x1CA1C28 Offset: 0x1C9DC28 VA: 0x1CA1C28
	public bool get_IsFlags() { }

	// RVA: 0x1CA1C30 Offset: 0x1C9DC30 VA: 0x1CA1C30
	public string[] get_EnumNames() { }

	// RVA: 0x1CA1C38 Offset: 0x1C9DC38 VA: 0x1CA1C38
	public string[] get_XmlNames() { }

	// RVA: 0x1CA1C40 Offset: 0x1C9DC40 VA: 0x1CA1C40
	public long[] get_Values() { }

	// RVA: 0x1C9BEC8 Offset: 0x1C97EC8 VA: 0x1C9BEC8
	public string GetXmlName(string typeName, object enumValue) { }

	// RVA: 0x1CA1C48 Offset: 0x1C9DC48 VA: 0x1CA1C48
	public string GetEnumName(string typeName, string xmlName) { }
}
