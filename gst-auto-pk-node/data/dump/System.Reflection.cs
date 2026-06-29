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

// Namespace: System.Reflection
[Serializable]
public sealed class AmbiguousMatchException : SystemException // TypeDefIndex: 1175
{
	// Methods

	// RVA: 0x17DB224 Offset: 0x17D7224 VA: 0x17DB224
	public void .ctor() { }

	// RVA: 0x17DB280 Offset: 0x17D7280 VA: 0x17DB280
	public void .ctor(string message) { }

	// RVA: 0x17DB2A4 Offset: 0x17D72A4 VA: 0x17DB2A4
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyCompanyAttribute : Attribute // TypeDefIndex: 1176
{
	// Fields
	[CompilerGenerated]
	private readonly string <Company>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17DB2AC Offset: 0x17D72AC VA: 0x17DB2AC
	public void .ctor(string company) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyConfigurationAttribute : Attribute // TypeDefIndex: 1177
{
	// Fields
	[CompilerGenerated]
	private readonly string <Configuration>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17DB2DC Offset: 0x17D72DC VA: 0x17DB2DC
	public void .ctor(string configuration) { }
}

// Namespace: System.Reflection
public enum AssemblyContentType // TypeDefIndex: 1178
{
	// Fields
	public int value__; // 0x0
	public const AssemblyContentType Default = 0;
	public const AssemblyContentType WindowsRuntime = 1;
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyCopyrightAttribute : Attribute // TypeDefIndex: 1179
{
	// Fields
	[CompilerGenerated]
	private readonly string <Copyright>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17DB30C Offset: 0x17D730C VA: 0x17DB30C
	public void .ctor(string copyright) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyDefaultAliasAttribute : Attribute // TypeDefIndex: 1180
{
	// Fields
	[CompilerGenerated]
	private readonly string <DefaultAlias>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17DB33C Offset: 0x17D733C VA: 0x17DB33C
	public void .ctor(string defaultAlias) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyDelaySignAttribute : Attribute // TypeDefIndex: 1181
{
	// Fields
	[CompilerGenerated]
	private readonly bool <DelaySign>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17DB36C Offset: 0x17D736C VA: 0x17DB36C
	public void .ctor(bool delaySign) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyDescriptionAttribute : Attribute // TypeDefIndex: 1182
{
	// Fields
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17DB394 Offset: 0x17D7394 VA: 0x17DB394
	public void .ctor(string description) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyFileVersionAttribute : Attribute // TypeDefIndex: 1183
{
	// Fields
	[CompilerGenerated]
	private readonly string <Version>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17DB3C4 Offset: 0x17D73C4 VA: 0x17DB3C4
	public void .ctor(string version) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyInformationalVersionAttribute : Attribute // TypeDefIndex: 1184
{
	// Fields
	[CompilerGenerated]
	private readonly string <InformationalVersion>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17DB440 Offset: 0x17D7440 VA: 0x17DB440
	public void .ctor(string informationalVersion) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyKeyFileAttribute : Attribute // TypeDefIndex: 1185
{
	// Fields
	[CompilerGenerated]
	private readonly string <KeyFile>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17DB470 Offset: 0x17D7470 VA: 0x17DB470
	public void .ctor(string keyFile) { }
}

// Namespace: System.Reflection
[Usage(1, AllowMultiple = True, Inherited = False)]
public sealed class AssemblyMetadataAttribute : Attribute // TypeDefIndex: 1186
{
	// Fields
	[CompilerGenerated]
	private readonly string <Key>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Value>k__BackingField; // 0x18

	// Methods

	// RVA: 0x17DB4A0 Offset: 0x17D74A0 VA: 0x17DB4A0
	public void .ctor(string key, string value) { }
}

// Namespace: System.Reflection
[Flags]
public enum AssemblyNameFlags // TypeDefIndex: 1187
{
	// Fields
	public int value__; // 0x0
	public const AssemblyNameFlags None = 0;
	public const AssemblyNameFlags PublicKey = 1;
	public const AssemblyNameFlags EnableJITcompileOptimizer = 16384;
	public const AssemblyNameFlags EnableJITcompileTracking = 32768;
	public const AssemblyNameFlags Retargetable = 256;
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyProductAttribute : Attribute // TypeDefIndex: 1188
{
	// Fields
	[CompilerGenerated]
	private readonly string <Product>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17DB4E4 Offset: 0x17D74E4 VA: 0x17DB4E4
	public void .ctor(string product) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyTitleAttribute : Attribute // TypeDefIndex: 1189
{
	// Fields
	[CompilerGenerated]
	private readonly string <Title>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17DB514 Offset: 0x17D7514 VA: 0x17DB514
	public void .ctor(string title) { }
}

// Namespace: System.Reflection
[Usage(1, Inherited = False)]
public sealed class AssemblyTrademarkAttribute : Attribute // TypeDefIndex: 1190
{
	// Fields
	[CompilerGenerated]
	private readonly string <Trademark>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17DB544 Offset: 0x17D7544 VA: 0x17DB544
	public void .ctor(string trademark) { }
}

// Namespace: System.Reflection
public abstract class Binder // TypeDefIndex: 1191
{
	// Methods

	// RVA: 0x17DB574 Offset: 0x17D7574 VA: 0x17DB574
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] names, out object state);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object ChangeType(object value, Type type, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ReorderArgumentArray(ref object[] args, object state);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers);
}

// Namespace: System.Reflection
[Flags]
public enum BindingFlags // TypeDefIndex: 1192
{
	// Fields
	public int value__; // 0x0
	public const BindingFlags Default = 0;
	public const BindingFlags IgnoreCase = 1;
	public const BindingFlags DeclaredOnly = 2;
	public const BindingFlags Instance = 4;
	public const BindingFlags Static = 8;
	public const BindingFlags Public = 16;
	public const BindingFlags NonPublic = 32;
	public const BindingFlags FlattenHierarchy = 64;
	public const BindingFlags InvokeMethod = 256;
	public const BindingFlags CreateInstance = 512;
	public const BindingFlags GetField = 1024;
	public const BindingFlags SetField = 2048;
	public const BindingFlags GetProperty = 4096;
	public const BindingFlags SetProperty = 8192;
	public const BindingFlags PutDispProperty = 16384;
	public const BindingFlags PutRefDispProperty = 32768;
	public const BindingFlags ExactBinding = 65536;
	public const BindingFlags SuppressChangeType = 131072;
	public const BindingFlags OptionalParamBinding = 262144;
	public const BindingFlags IgnoreReturn = 16777216;
	public const BindingFlags DoNotWrapExceptions = 33554432;
}

// Namespace: System.Reflection
[Flags]
public enum CallingConventions // TypeDefIndex: 1193
{
	// Fields
	public int value__; // 0x0
	public const CallingConventions Standard = 1;
	public const CallingConventions VarArgs = 2;
	public const CallingConventions Any = 3;
	public const CallingConventions HasThis = 32;
	public const CallingConventions ExplicitThis = 64;
}

// Namespace: System.Reflection
[Serializable]
public abstract class ConstructorInfo : MethodBase // TypeDefIndex: 1194
{
	// Fields
	public static readonly string ConstructorName; // 0x0
	public static readonly string TypeConstructorName; // 0x8

	// Properties
	public override MemberTypes MemberType { get; }

	// Methods

	// RVA: 0x17DB57C Offset: 0x17D757C VA: 0x17DB57C
	protected void .ctor() { }

	// RVA: 0x17DB58C Offset: 0x17D758C VA: 0x17DB58C Slot: 7
	public override MemberTypes get_MemberType() { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x17DB594 Offset: 0x17D7594 VA: 0x17DB594
	public object Invoke(object[] parameters) { }

	// RVA: -1 Offset: -1 Slot: 39
	public abstract object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: 0x17DB5B4 Offset: 0x17D75B4 VA: 0x17DB5B4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17DB5C4 Offset: 0x17D75C4 VA: 0x17DB5C4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17DB5D4 Offset: 0x17D75D4 VA: 0x17DB5D4
	public static bool op_Equality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x17DB600 Offset: 0x17D7600 VA: 0x17DB600
	public static bool op_Inequality(ConstructorInfo left, ConstructorInfo right) { }

	// RVA: 0x17DB694 Offset: 0x17D7694 VA: 0x17DB694
	private static void .cctor() { }
}

// Namespace: System.Reflection
[Serializable]
public class CustomAttributeFormatException : FormatException // TypeDefIndex: 1195
{
	// Methods

	// RVA: 0x17DB72C Offset: 0x17D772C VA: 0x17DB72C
	public void .ctor() { }

	// RVA: 0x17DB78C Offset: 0x17D778C VA: 0x17DB78C
	public void .ctor(string message) { }

	// RVA: 0x17DB7B4 Offset: 0x17D77B4 VA: 0x17DB7B4
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x17DB7D8 Offset: 0x17D77D8 VA: 0x17DB7D8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
[Usage(1036)]
public sealed class DefaultMemberAttribute : Attribute // TypeDefIndex: 1196
{
	// Fields
	[CompilerGenerated]
	private readonly string <MemberName>k__BackingField; // 0x10

	// Properties
	public string MemberName { get; }

	// Methods

	// RVA: 0x17DB7E0 Offset: 0x17D77E0 VA: 0x17DB7E0
	public void .ctor(string memberName) { }

	[CompilerGenerated]
	// RVA: 0x17DB810 Offset: 0x17D7810 VA: 0x17DB810
	public string get_MemberName() { }
}

// Namespace: System.Reflection
[Flags]
public enum EventAttributes // TypeDefIndex: 1197
{
	// Fields
	public int value__; // 0x0
	public const EventAttributes None = 0;
	public const EventAttributes SpecialName = 512;
	public const EventAttributes RTSpecialName = 1024;
	public const EventAttributes ReservedMask = 1024;
}

// Namespace: 
private sealed class EventInfo.AddEventAdapter : MulticastDelegate // TypeDefIndex: 1198
{
	// Methods

	// RVA: 0x17DBA58 Offset: 0x17D7A58 VA: 0x17DBA58
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17DBB64 Offset: 0x17D7B64 VA: 0x17DBB64 Slot: 12
	public virtual void Invoke(object _this, Delegate dele) { }
}

// Namespace: System.Reflection
[Serializable]
public abstract class EventInfo : MemberInfo // TypeDefIndex: 1199
{
	// Fields
	private EventInfo.AddEventAdapter cached_add_event; // 0x10

	// Properties
	public override MemberTypes MemberType { get; }
	public virtual Type EventHandlerType { get; }

	// Methods

	// RVA: 0x17DB818 Offset: 0x17D7818 VA: 0x17DB818
	protected void .ctor() { }

	// RVA: 0x17DB828 Offset: 0x17D7828 VA: 0x17DB828 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract MethodInfo GetAddMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract MethodInfo GetRemoveMethod(bool nonPublic);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodInfo GetRaiseMethod(bool nonPublic);

	// RVA: 0x17DB830 Offset: 0x17D7830 VA: 0x17DB830 Slot: 19
	public virtual Type get_EventHandlerType() { }

	// RVA: 0x17DB94C Offset: 0x17D794C VA: 0x17DB94C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17DB95C Offset: 0x17D795C VA: 0x17DB95C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17DB96C Offset: 0x17D796C VA: 0x17DB96C
	public static bool op_Equality(EventInfo left, EventInfo right) { }

	// RVA: 0x17DB998 Offset: 0x17D7998 VA: 0x17DB998
	public static bool op_Inequality(EventInfo left, EventInfo right) { }

	// RVA: 0x17DB9D4 Offset: 0x17D79D4 VA: 0x17DB9D4
	private static EventInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x17DB9D8 Offset: 0x17D79D8 VA: 0x17DB9D8
	internal static EventInfo GetEventFromHandle(RuntimeEventHandle handle, RuntimeTypeHandle reflectedType) { }
}

// Namespace: System.Reflection
[Flags]
public enum ExceptionHandlingClauseOptions // TypeDefIndex: 1200
{
	// Fields
	public int value__; // 0x0
	public const ExceptionHandlingClauseOptions Clause = 0;
	public const ExceptionHandlingClauseOptions Filter = 1;
	public const ExceptionHandlingClauseOptions Finally = 2;
	public const ExceptionHandlingClauseOptions Fault = 4;
}

// Namespace: System.Reflection
[Flags]
public enum FieldAttributes // TypeDefIndex: 1201
{
	// Fields
	public int value__; // 0x0
	public const FieldAttributes FieldAccessMask = 7;
	public const FieldAttributes PrivateScope = 0;
	public const FieldAttributes Private = 1;
	public const FieldAttributes FamANDAssem = 2;
	public const FieldAttributes Assembly = 3;
	public const FieldAttributes Family = 4;
	public const FieldAttributes FamORAssem = 5;
	public const FieldAttributes Public = 6;
	public const FieldAttributes Static = 16;
	public const FieldAttributes InitOnly = 32;
	public const FieldAttributes Literal = 64;
	public const FieldAttributes NotSerialized = 128;
	public const FieldAttributes SpecialName = 512;
	public const FieldAttributes PinvokeImpl = 8192;
	public const FieldAttributes RTSpecialName = 1024;
	public const FieldAttributes HasFieldMarshal = 4096;
	public const FieldAttributes HasDefault = 32768;
	public const FieldAttributes HasFieldRVA = 256;
	public const FieldAttributes ReservedMask = 38144;
}

// Namespace: System.Reflection
[Serializable]
public abstract class FieldInfo : MemberInfo // TypeDefIndex: 1202
{
	// Properties
	public override MemberTypes MemberType { get; }
	public abstract FieldAttributes Attributes { get; }
	public abstract Type FieldType { get; }
	public bool IsInitOnly { get; }
	public bool IsLiteral { get; }
	public bool IsNotSerialized { get; }
	public bool IsStatic { get; }
	public bool IsPrivate { get; }
	public bool IsPublic { get; }
	public abstract RuntimeFieldHandle FieldHandle { get; }

	// Methods

	// RVA: 0x17DBB78 Offset: 0x17D7B78 VA: 0x17DBB78
	protected void .ctor() { }

	// RVA: 0x17DBB80 Offset: 0x17D7B80 VA: 0x17DBB80 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract FieldAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract Type get_FieldType();

	// RVA: 0x17DBB88 Offset: 0x17D7B88 VA: 0x17DBB88 Slot: 18
	public bool get_IsInitOnly() { }

	// RVA: 0x17DBBA8 Offset: 0x17D7BA8 VA: 0x17DBBA8 Slot: 19
	public bool get_IsLiteral() { }

	// RVA: 0x17DBBC8 Offset: 0x17D7BC8 VA: 0x17DBBC8 Slot: 20
	public bool get_IsNotSerialized() { }

	// RVA: 0x17DBBE8 Offset: 0x17D7BE8 VA: 0x17DBBE8 Slot: 21
	public bool get_IsStatic() { }

	// RVA: 0x17DBC08 Offset: 0x17D7C08 VA: 0x17DBC08 Slot: 22
	public bool get_IsPrivate() { }

	// RVA: 0x17DBC30 Offset: 0x17D7C30 VA: 0x17DBC30 Slot: 23
	public bool get_IsPublic() { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract RuntimeFieldHandle get_FieldHandle();

	// RVA: 0x17DBC58 Offset: 0x17D7C58 VA: 0x17DBC58 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17DBC60 Offset: 0x17D7C60 VA: 0x17DBC60 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17DBC68 Offset: 0x17D7C68 VA: 0x17DBC68
	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	// RVA: 0x17DBC94 Offset: 0x17D7C94 VA: 0x17DBC94
	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract object GetValue(object obj);

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x17DBCD0 Offset: 0x17D7CD0 VA: 0x17DBCD0 Slot: 26
	public void SetValue(object obj, object value) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	[CLSCompliant(False)]
	// RVA: 0x17DBD38 Offset: 0x17D7D38 VA: 0x17DBD38 Slot: 28
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x17DBD84 Offset: 0x17D7D84 VA: 0x17DBD84 Slot: 29
	public virtual object GetRawConstantValue() { }

	// RVA: 0x17DBDD0 Offset: 0x17D7DD0 VA: 0x17DBDD0
	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	// RVA: 0x17DBDD4 Offset: 0x17D7DD4 VA: 0x17DBDD4
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[ComVisible(False)]
	// RVA: 0x17DBE2C Offset: 0x17D7E2C VA: 0x17DBE2C
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	// RVA: 0x17DBEAC Offset: 0x17D7EAC VA: 0x17DBEAC Slot: 30
	internal virtual int GetFieldOffset() { }

	// RVA: 0x17DBEF8 Offset: 0x17D7EF8 VA: 0x17DBEF8
	private MarshalAsAttribute get_marshal_info() { }

	// RVA: 0x17DBEFC Offset: 0x17D7EFC VA: 0x17DBEFC
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x17DC128 Offset: 0x17D8128 VA: 0x17DC128
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }
}

// Namespace: System.Reflection
[Flags]
public enum GenericParameterAttributes // TypeDefIndex: 1203
{
	// Fields
	public int value__; // 0x0
	public const GenericParameterAttributes None = 0;
	public const GenericParameterAttributes VarianceMask = 3;
	public const GenericParameterAttributes Covariant = 1;
	public const GenericParameterAttributes Contravariant = 2;
	public const GenericParameterAttributes SpecialConstraintMask = 28;
	public const GenericParameterAttributes ReferenceTypeConstraint = 4;
	public const GenericParameterAttributes NotNullableValueTypeConstraint = 8;
	public const GenericParameterAttributes DefaultConstructorConstraint = 16;
}

// Namespace: System.Reflection
public interface ICustomAttributeProvider // TypeDefIndex: 1204
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object[] GetCustomAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsDefined(Type attributeType, bool inherit);
}

// Namespace: System.Reflection
public interface IReflectableType // TypeDefIndex: 1205
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TypeInfo GetTypeInfo();
}

// Namespace: System.Reflection
[Extension]
public static class IntrospectionExtensions // TypeDefIndex: 1206
{
	// Methods

	[Extension]
	// RVA: 0x17DC97C Offset: 0x17D897C VA: 0x17DC97C
	public static TypeInfo GetTypeInfo(Type type) { }
}

// Namespace: System.Reflection
[Serializable]
public class InvalidFilterCriteriaException : ApplicationException // TypeDefIndex: 1207
{
	// Methods

	// RVA: 0x17DCB70 Offset: 0x17D8B70 VA: 0x17DCB70
	public void .ctor() { }

	// RVA: 0x17DCBD0 Offset: 0x17D8BD0 VA: 0x17DCBD0
	public void .ctor(string message) { }

	// RVA: 0x17DCBF8 Offset: 0x17D8BF8 VA: 0x17DCBF8
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x17DCC1C Offset: 0x17D8C1C VA: 0x17DCC1C
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
public sealed class MemberFilter : MulticastDelegate // TypeDefIndex: 1208
{
	// Methods

	// RVA: 0x17DCC24 Offset: 0x17D8C24 VA: 0x17DCC24
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17DCD30 Offset: 0x17D8D30 VA: 0x17DCD30 Slot: 12
	public virtual bool Invoke(MemberInfo m, object filterCriteria) { }
}

// Namespace: System.Reflection
[Serializable]
public abstract class MemberInfo : ICustomAttributeProvider // TypeDefIndex: 1209
{
	// Properties
	public abstract MemberTypes MemberType { get; }
	public abstract string Name { get; }
	public abstract Type DeclaringType { get; }
	public abstract Type ReflectedType { get; }
	public virtual Module Module { get; }
	public virtual int MetadataToken { get; }

	// Methods

	// RVA: 0x17DB820 Offset: 0x17D7820 VA: 0x17DB820
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract MemberTypes get_MemberType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_DeclaringType();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Type get_ReflectedType();

	// RVA: 0x17DCD44 Offset: 0x17D8D44 VA: 0x17DCD44 Slot: 11
	public virtual Module get_Module() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsDefined(Type attributeType, bool inherit);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract object[] GetCustomAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	// RVA: 0x17DCDF0 Offset: 0x17D8DF0 VA: 0x17DCDF0 Slot: 15
	public virtual int get_MetadataToken() { }

	// RVA: 0x17DB954 Offset: 0x17D7954 VA: 0x17DB954 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17DB964 Offset: 0x17D7964 VA: 0x17DB964 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17CE1C8 Offset: 0x17CA1C8 VA: 0x17CE1C8
	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	// RVA: 0x17CE4E8 Offset: 0x17CA4E8 VA: 0x17CE4E8
	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }
}

// Namespace: System.Reflection
[Flags]
public enum MemberTypes // TypeDefIndex: 1210
{
	// Fields
	public int value__; // 0x0
	public const MemberTypes Constructor = 1;
	public const MemberTypes Event = 2;
	public const MemberTypes Field = 4;
	public const MemberTypes Method = 8;
	public const MemberTypes Property = 16;
	public const MemberTypes TypeInfo = 32;
	public const MemberTypes Custom = 64;
	public const MemberTypes NestedType = 128;
	public const MemberTypes All = 191;
}

// Namespace: System.Reflection
[Flags]
public enum MethodAttributes // TypeDefIndex: 1211
{
	// Fields
	public int value__; // 0x0
	public const MethodAttributes MemberAccessMask = 7;
	public const MethodAttributes PrivateScope = 0;
	public const MethodAttributes Private = 1;
	public const MethodAttributes FamANDAssem = 2;
	public const MethodAttributes Assembly = 3;
	public const MethodAttributes Family = 4;
	public const MethodAttributes FamORAssem = 5;
	public const MethodAttributes Public = 6;
	public const MethodAttributes Static = 16;
	public const MethodAttributes Final = 32;
	public const MethodAttributes Virtual = 64;
	public const MethodAttributes HideBySig = 128;
	public const MethodAttributes CheckAccessOnOverride = 512;
	public const MethodAttributes VtableLayoutMask = 256;
	public const MethodAttributes ReuseSlot = 0;
	public const MethodAttributes NewSlot = 256;
	public const MethodAttributes Abstract = 1024;
	public const MethodAttributes SpecialName = 2048;
	public const MethodAttributes PinvokeImpl = 8192;
	public const MethodAttributes UnmanagedExport = 8;
	public const MethodAttributes RTSpecialName = 4096;
	public const MethodAttributes HasSecurity = 16384;
	public const MethodAttributes RequireSecObject = 32768;
	public const MethodAttributes ReservedMask = 53248;
}

// Namespace: System.Reflection
[Serializable]
public abstract class MethodBase : MemberInfo // TypeDefIndex: 1212
{
	// Properties
	public abstract MethodAttributes Attributes { get; }
	public virtual CallingConventions CallingConvention { get; }
	public bool IsAbstract { get; }
	public bool IsConstructor { get; }
	public bool IsSpecialName { get; }
	public bool IsStatic { get; }
	public bool IsVirtual { get; }
	public bool IsPublic { get; }
	public virtual bool IsGenericMethod { get; }
	public virtual bool IsGenericMethodDefinition { get; }
	public virtual bool ContainsGenericParameters { get; }
	public abstract RuntimeMethodHandle MethodHandle { get; }
	public virtual bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x17DB584 Offset: 0x17D7584 VA: 0x17DB584
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract ParameterInfo[] GetParameters();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract MethodAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodImplAttributes GetMethodImplementationFlags();

	// RVA: 0x17DD048 Offset: 0x17D9048 VA: 0x17DD048 Slot: 19
	public virtual CallingConventions get_CallingConvention() { }

	// RVA: 0x17DD050 Offset: 0x17D9050 VA: 0x17DD050 Slot: 20
	public bool get_IsAbstract() { }

	// RVA: 0x17DD070 Offset: 0x17D9070 VA: 0x17DD070 Slot: 21
	public bool get_IsConstructor() { }

	// RVA: 0x17DD134 Offset: 0x17D9134 VA: 0x17DD134 Slot: 22
	public bool get_IsSpecialName() { }

	// RVA: 0x17DD114 Offset: 0x17D9114 VA: 0x17DD114 Slot: 23
	public bool get_IsStatic() { }

	// RVA: 0x17DD154 Offset: 0x17D9154 VA: 0x17DD154 Slot: 24
	public bool get_IsVirtual() { }

	// RVA: 0x17DD174 Offset: 0x17D9174 VA: 0x17DD174 Slot: 25
	public bool get_IsPublic() { }

	// RVA: 0x17DD19C Offset: 0x17D919C VA: 0x17DD19C Slot: 26
	public virtual bool get_IsGenericMethod() { }

	// RVA: 0x17DD1A4 Offset: 0x17D91A4 VA: 0x17DD1A4 Slot: 27
	public virtual bool get_IsGenericMethodDefinition() { }

	// RVA: 0x17DD1AC Offset: 0x17D91AC VA: 0x17DD1AC Slot: 28
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x17DD1F8 Offset: 0x17D91F8 VA: 0x17DD1F8 Slot: 29
	public virtual bool get_ContainsGenericParameters() { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x17DD200 Offset: 0x17D9200 VA: 0x17DD200 Slot: 30
	public object Invoke(object obj, object[] parameters) { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract RuntimeMethodHandle get_MethodHandle();

	// RVA: 0x17DD220 Offset: 0x17D9220 VA: 0x17DD220 Slot: 33
	public virtual bool get_IsSecurityCritical() { }

	// RVA: 0x17DB5BC Offset: 0x17D75BC VA: 0x17DB5BC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17DB5CC Offset: 0x17D75CC VA: 0x17DB5CC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17DCE40 Offset: 0x17D8E40 VA: 0x17DCE40
	public static bool op_Equality(MethodBase left, MethodBase right) { }

	// RVA: 0x17DCE28 Offset: 0x17D8E28 VA: 0x17DCE28
	public static bool op_Inequality(MethodBase left, MethodBase right) { }

	// RVA: 0x17DD284 Offset: 0x17D9284 VA: 0x17DD284 Slot: 34
	internal virtual ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x17DD294 Offset: 0x17D9294 VA: 0x17DD294 Slot: 35
	internal virtual int GetParametersCount() { }

	// RVA: 0x17DD2BC Offset: 0x17D92BC VA: 0x17DD2BC Slot: 36
	internal virtual string FormatNameAndSig(bool serialization) { }

	// RVA: 0x17DD5D8 Offset: 0x17D95D8 VA: 0x17DD5D8 Slot: 37
	internal virtual Type[] GetParameterTypes() { }

	// RVA: 0x17DD6E4 Offset: 0x17D96E4 VA: 0x17DD6E4 Slot: 38
	internal virtual ParameterInfo[] GetParametersNoCopy() { }

	// RVA: 0x17DD6F4 Offset: 0x17D96F4 VA: 0x17DD6F4
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	// RVA: 0x17DD3E0 Offset: 0x17D93E0 VA: 0x17DD3E0
	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }
}

// Namespace: System.Reflection
public enum MethodImplAttributes // TypeDefIndex: 1213
{
	// Fields
	public int value__; // 0x0
	public const MethodImplAttributes CodeTypeMask = 3;
	public const MethodImplAttributes IL = 0;
	public const MethodImplAttributes Native = 1;
	public const MethodImplAttributes OPTIL = 2;
	public const MethodImplAttributes Runtime = 3;
	public const MethodImplAttributes ManagedMask = 4;
	public const MethodImplAttributes Unmanaged = 4;
	public const MethodImplAttributes Managed = 0;
	public const MethodImplAttributes ForwardRef = 16;
	public const MethodImplAttributes PreserveSig = 128;
	public const MethodImplAttributes InternalCall = 4096;
	public const MethodImplAttributes Synchronized = 32;
	public const MethodImplAttributes NoInlining = 8;
	public const MethodImplAttributes AggressiveInlining = 256;
	public const MethodImplAttributes NoOptimization = 64;
	public const MethodImplAttributes MaxMethodImplVal = 65535;
	public const MethodImplAttributes SecurityMitigations = 1024;
}

// Namespace: System.Reflection
[Serializable]
public abstract class MethodInfo : MethodBase // TypeDefIndex: 1214
{
	// Properties
	public override MemberTypes MemberType { get; }
	public virtual ParameterInfo ReturnParameter { get; }
	public virtual Type ReturnType { get; }
	internal virtual int GenericParameterCount { get; }

	// Methods

	// RVA: 0x17DD8B4 Offset: 0x17D98B4 VA: 0x17DD8B4
	protected void .ctor() { }

	// RVA: 0x17DD8BC Offset: 0x17D98BC VA: 0x17DD8BC Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x17DD8C4 Offset: 0x17D98C4 VA: 0x17DD8C4 Slot: 39
	public virtual ParameterInfo get_ReturnParameter() { }

	// RVA: 0x17DD8EC Offset: 0x17D98EC VA: 0x17DD8EC Slot: 40
	public virtual Type get_ReturnType() { }

	// RVA: 0x17DD914 Offset: 0x17D9914 VA: 0x17DD914 Slot: 28
	public override Type[] GetGenericArguments() { }

	// RVA: 0x17DD960 Offset: 0x17D9960 VA: 0x17DD960 Slot: 41
	public virtual MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x17DD9AC Offset: 0x17D99AC VA: 0x17DD9AC Slot: 42
	public virtual MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract MethodInfo GetBaseDefinition();

	// RVA: 0x17DD9F8 Offset: 0x17D99F8 VA: 0x17DD9F8 Slot: 44
	public virtual Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x17DDA44 Offset: 0x17D9A44 VA: 0x17DDA44 Slot: 45
	public virtual Delegate CreateDelegate(Type delegateType, object target) { }

	// RVA: 0x17DDA90 Offset: 0x17D9A90 VA: 0x17DDA90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17DDA98 Offset: 0x17D9A98 VA: 0x17DDA98 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17D184C Offset: 0x17CD84C VA: 0x17D184C
	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x17DD248 Offset: 0x17D9248 VA: 0x17DD248
	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x17DDAA0 Offset: 0x17D9AA0 VA: 0x17DDAA0 Slot: 46
	internal virtual int get_GenericParameterCount() { }
}

// Namespace: System.Reflection
public sealed class Missing : ISerializable // TypeDefIndex: 1215
{
	// Fields
	public static readonly Missing Value; // 0x0

	// Methods

	// RVA: 0x17DDAC8 Offset: 0x17D9AC8 VA: 0x17DDAC8
	private void .ctor() { }

	// RVA: 0x17DDAD0 Offset: 0x17D9AD0 VA: 0x17DDAD0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17DDB08 Offset: 0x17D9B08 VA: 0x17DDB08
	private static void .cctor() { }
}

// Namespace: System.Reflection
[Serializable]
public abstract class Module : ICustomAttributeProvider, ISerializable, _Module // TypeDefIndex: 1216
{
	// Fields
	public static readonly TypeFilter FilterTypeName; // 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; // 0x8
	private const BindingFlags DefaultLookup = 28;

	// Properties
	public virtual Assembly Assembly { get; }
	public virtual Guid ModuleVersionId { get; }
	public virtual string ScopeName { get; }

	// Methods

	// RVA: 0x17DDB70 Offset: 0x17D9B70 VA: 0x17DDB70
	protected void .ctor() { }

	// RVA: 0x17DDB78 Offset: 0x17D9B78 VA: 0x17DDB78 Slot: 8
	public virtual Assembly get_Assembly() { }

	// RVA: 0x17DDBA0 Offset: 0x17D9BA0 VA: 0x17DDBA0 Slot: 9
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x17DDBC8 Offset: 0x17D9BC8 VA: 0x17DDBC8 Slot: 10
	public virtual string get_ScopeName() { }

	// RVA: 0x17DDBF0 Offset: 0x17D9BF0 VA: 0x17DDBF0 Slot: 11
	public virtual bool IsResource() { }

	// RVA: 0x17DDC18 Offset: 0x17D9C18 VA: 0x17DDC18 Slot: 12
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17DDC40 Offset: 0x17D9C40 VA: 0x17DDC40 Slot: 13
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17DDC68 Offset: 0x17D9C68 VA: 0x17DDC68 Slot: 14
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17DDC90 Offset: 0x17D9C90 VA: 0x17DDC90 Slot: 15
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17DDCB8 Offset: 0x17D9CB8 VA: 0x17DDCB8 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x17DDCC0 Offset: 0x17D9CC0 VA: 0x17DDCC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17DDCC8 Offset: 0x17D9CC8 VA: 0x17DDCC8
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x17DDCF4 Offset: 0x17D9CF4 VA: 0x17DDCF4 Slot: 3
	public override string ToString() { }

	// RVA: 0x17DDD00 Offset: 0x17D9D00 VA: 0x17DDD00
	private static bool FilterTypeNameImpl(Type cls, object filterCriteria) { }

	// RVA: 0x17DDE10 Offset: 0x17D9E10 VA: 0x17DDE10
	private static bool FilterTypeNameIgnoreCaseImpl(Type cls, object filterCriteria) { }

	// RVA: 0x17DDF50 Offset: 0x17D9F50 VA: 0x17DDF50 Slot: 16
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x17DDF88 Offset: 0x17D9F88 VA: 0x17DDF88
	private static void .cctor() { }
}

// Namespace: System.Reflection
[Flags]
public enum ParameterAttributes // TypeDefIndex: 1217
{
	// Fields
	public int value__; // 0x0
	public const ParameterAttributes None = 0;
	public const ParameterAttributes In = 1;
	public const ParameterAttributes Out = 2;
	public const ParameterAttributes Lcid = 4;
	public const ParameterAttributes Retval = 8;
	public const ParameterAttributes Optional = 16;
	public const ParameterAttributes HasDefault = 4096;
	public const ParameterAttributes HasFieldMarshal = 8192;
	public const ParameterAttributes Reserved3 = 16384;
	public const ParameterAttributes Reserved4 = 32768;
	public const ParameterAttributes ReservedMask = 61440;
}

// Namespace: System.Reflection
[Serializable]
public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo // TypeDefIndex: 1218
{
	// Fields
	protected ParameterAttributes AttrsImpl; // 0x10
	protected Type ClassImpl; // 0x18
	protected object DefaultValueImpl; // 0x20
	protected MemberInfo MemberImpl; // 0x28
	protected string NameImpl; // 0x30
	protected int PositionImpl; // 0x38
	private const int MetadataToken_ParamDef = 134217728;

	// Properties
	public virtual ParameterAttributes Attributes { get; }
	public virtual MemberInfo Member { get; }
	public virtual string Name { get; }
	public virtual Type ParameterType { get; }
	public virtual int Position { get; }
	public bool IsIn { get; }
	public bool IsOptional { get; }
	public bool IsOut { get; }
	public virtual object DefaultValue { get; }

	// Methods

	// RVA: 0x17DE170 Offset: 0x17DA170 VA: 0x17DE170
	protected void .ctor() { }

	// RVA: 0x17DE178 Offset: 0x17DA178 VA: 0x17DE178 Slot: 8
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x17DE180 Offset: 0x17DA180 VA: 0x17DE180 Slot: 9
	public virtual MemberInfo get_Member() { }

	// RVA: 0x17DE188 Offset: 0x17DA188 VA: 0x17DE188 Slot: 10
	public virtual string get_Name() { }

	// RVA: 0x17DE190 Offset: 0x17DA190 VA: 0x17DE190 Slot: 11
	public virtual Type get_ParameterType() { }

	// RVA: 0x17DE198 Offset: 0x17DA198 VA: 0x17DE198 Slot: 12
	public virtual int get_Position() { }

	// RVA: 0x17DE1A0 Offset: 0x17DA1A0 VA: 0x17DE1A0
	public bool get_IsIn() { }

	// RVA: 0x17DE1BC Offset: 0x17DA1BC VA: 0x17DE1BC
	public bool get_IsOptional() { }

	// RVA: 0x17DE1D8 Offset: 0x17DA1D8 VA: 0x17DE1D8
	public bool get_IsOut() { }

	// RVA: 0x17DE1F4 Offset: 0x17DA1F4 VA: 0x17DE1F4 Slot: 13
	public virtual object get_DefaultValue() { }

	// RVA: 0x17DE21C Offset: 0x17DA21C VA: 0x17DE21C Slot: 14
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17DE2A4 Offset: 0x17DA2A4 VA: 0x17DE2A4 Slot: 15
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17DE338 Offset: 0x17DA338 VA: 0x17DE338 Slot: 16
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17DE444 Offset: 0x17DA444 VA: 0x17DE444 Slot: 7
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x17DE6A4 Offset: 0x17DA6A4 VA: 0x17DE6A4 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Reflection
[DefaultMember("Item")]
[IsReadOnly]
public struct ParameterModifier // TypeDefIndex: 1219
{
	// Fields
	private readonly bool[] _byRef; // 0x0
}

// Namespace: System.Reflection
[CLSCompliant(False)]
public sealed class Pointer : ISerializable // TypeDefIndex: 1220
{
	// Fields
	private readonly void* _ptr; // 0x10
	private readonly Type _ptrType; // 0x18

	// Methods

	// RVA: 0x17DE728 Offset: 0x17DA728 VA: 0x17DE728
	private void .ctor(void* ptr, Type ptrType) { }

	// RVA: 0x17DE760 Offset: 0x17DA760 VA: 0x17DE760
	public static object Box(void* ptr, Type type) { }

	// RVA: 0x17DE8D4 Offset: 0x17DA8D4 VA: 0x17DE8D4 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
public enum ProcessorArchitecture // TypeDefIndex: 1221
{
	// Fields
	public int value__; // 0x0
	public const ProcessorArchitecture None = 0;
	public const ProcessorArchitecture MSIL = 1;
	public const ProcessorArchitecture X86 = 2;
	public const ProcessorArchitecture IA64 = 3;
	public const ProcessorArchitecture Amd64 = 4;
	public const ProcessorArchitecture Arm = 5;
}

// Namespace: System.Reflection
[Flags]
public enum PropertyAttributes // TypeDefIndex: 1222
{
	// Fields
	public int value__; // 0x0
	public const PropertyAttributes None = 0;
	public const PropertyAttributes SpecialName = 512;
	public const PropertyAttributes RTSpecialName = 1024;
	public const PropertyAttributes HasDefault = 4096;
	public const PropertyAttributes Reserved2 = 8192;
	public const PropertyAttributes Reserved3 = 16384;
	public const PropertyAttributes Reserved4 = 32768;
	public const PropertyAttributes ReservedMask = 62464;
}

// Namespace: System.Reflection
[Serializable]
public abstract class PropertyInfo : MemberInfo // TypeDefIndex: 1223
{
	// Properties
	public override MemberTypes MemberType { get; }
	public abstract Type PropertyType { get; }
	public abstract bool CanRead { get; }
	public abstract bool CanWrite { get; }
	public virtual MethodInfo GetMethod { get; }

	// Methods

	// RVA: 0x17DE90C Offset: 0x17DA90C VA: 0x17DE90C
	protected void .ctor() { }

	// RVA: 0x17DE914 Offset: 0x17DA914 VA: 0x17DE914 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Type get_PropertyType();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract ParameterInfo[] GetIndexParameters();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract bool get_CanWrite();

	// RVA: 0x17DE91C Offset: 0x17DA91C VA: 0x17DE91C Slot: 20
	public virtual MethodInfo get_GetMethod() { }

	// RVA: 0x17DE930 Offset: 0x17DA930 VA: 0x17DE930 Slot: 21
	public MethodInfo GetGetMethod() { }

	// RVA: -1 Offset: -1 Slot: 22
	public abstract MethodInfo GetGetMethod(bool nonPublic);

	// RVA: 0x17DE944 Offset: 0x17DA944 VA: 0x17DE944 Slot: 23
	public MethodInfo GetSetMethod() { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract MethodInfo GetSetMethod(bool nonPublic);

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x17DE958 Offset: 0x17DA958 VA: 0x17DE958
	public object GetValue(object obj) { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x17DE96C Offset: 0x17DA96C VA: 0x17DE96C Slot: 25
	public virtual object GetValue(object obj, object[] index) { }

	// RVA: -1 Offset: -1 Slot: 26
	public abstract object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x17DE98C Offset: 0x17DA98C VA: 0x17DE98C
	public void SetValue(object obj, object value) { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x17DE9A0 Offset: 0x17DA9A0 VA: 0x17DE9A0 Slot: 27
	public virtual void SetValue(object obj, object value, object[] index) { }

	// RVA: -1 Offset: -1 Slot: 28
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture);

	// RVA: 0x17DE9C0 Offset: 0x17DA9C0 VA: 0x17DE9C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17DE9C8 Offset: 0x17DA9C8 VA: 0x17DE9C8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17DD01C Offset: 0x17D901C VA: 0x17DD01C
	public static bool op_Equality(PropertyInfo left, PropertyInfo right) { }

	// RVA: 0x17DCFE0 Offset: 0x17D8FE0 VA: 0x17DCFE0
	public static bool op_Inequality(PropertyInfo left, PropertyInfo right) { }
}

// Namespace: System.Reflection
[Serializable]
public sealed class ReflectionTypeLoadException : SystemException, ISerializable // TypeDefIndex: 1224
{
	// Fields
	[CompilerGenerated]
	private readonly Type[] <Types>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly Exception[] <LoaderExceptions>k__BackingField; // 0x98

	// Properties
	public Exception[] LoaderExceptions { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x17DE9D0 Offset: 0x17DA9D0 VA: 0x17DE9D0
	public void .ctor(Type[] classes, Exception[] exceptions) { }

	// RVA: 0x17DEA28 Offset: 0x17DAA28 VA: 0x17DEA28
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17DEB58 Offset: 0x17DAB58 VA: 0x17DEB58 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[CompilerGenerated]
	// RVA: 0x17DEC74 Offset: 0x17DAC74 VA: 0x17DEC74
	public Exception[] get_LoaderExceptions() { }

	// RVA: 0x17DEC7C Offset: 0x17DAC7C VA: 0x17DEC7C Slot: 5
	public override string get_Message() { }

	// RVA: 0x17DEDEC Offset: 0x17DADEC VA: 0x17DEDEC Slot: 3
	public override string ToString() { }

	// RVA: 0x17DEC84 Offset: 0x17DAC84 VA: 0x17DEC84
	private string CreateString(bool isMessage) { }
}

// Namespace: System.Reflection
internal sealed class SignatureArrayType : SignatureHasElementType // TypeDefIndex: 1225
{
	// Fields
	private readonly int _rank; // 0x20
	private readonly bool _isMultiDim; // 0x24

	// Properties
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	protected sealed override string Suffix { get; }

	// Methods

	// RVA: 0x17DEDF4 Offset: 0x17DADF4 VA: 0x17DEDF4
	internal void .ctor(SignatureType elementType, int rank, bool isMultiDim) { }

	// RVA: 0x17DEE68 Offset: 0x17DAE68 VA: 0x17DEE68 Slot: 32
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x17DEE70 Offset: 0x17DAE70 VA: 0x17DEE70 Slot: 34
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x17DEE78 Offset: 0x17DAE78 VA: 0x17DEE78 Slot: 36
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x17DEE80 Offset: 0x17DAE80 VA: 0x17DEE80 Slot: 42
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x17DEE90 Offset: 0x17DAE90 VA: 0x17DEE90 Slot: 43
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x17DEE98 Offset: 0x17DAE98 VA: 0x17DEE98 Slot: 47
	public sealed override int GetArrayRank() { }

	// RVA: 0x17DEEA0 Offset: 0x17DAEA0 VA: 0x17DEEA0 Slot: 133
	protected sealed override string get_Suffix() { }
}

// Namespace: System.Reflection
internal sealed class SignatureByRefType : SignatureHasElementType // TypeDefIndex: 1226
{
	// Properties
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	protected sealed override string Suffix { get; }

	// Methods

	// RVA: 0x17DEF68 Offset: 0x17DAF68 VA: 0x17DEF68
	internal void .ctor(SignatureType elementType) { }

	// RVA: 0x17DEF94 Offset: 0x17DAF94 VA: 0x17DEF94 Slot: 32
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x17DEF9C Offset: 0x17DAF9C VA: 0x17DEF9C Slot: 34
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x17DEFA4 Offset: 0x17DAFA4 VA: 0x17DEFA4 Slot: 36
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x17DEFAC Offset: 0x17DAFAC VA: 0x17DEFAC Slot: 42
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x17DEFB4 Offset: 0x17DAFB4 VA: 0x17DEFB4 Slot: 43
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x17DEFBC Offset: 0x17DAFBC VA: 0x17DEFBC Slot: 47
	public sealed override int GetArrayRank() { }

	// RVA: 0x17DF008 Offset: 0x17DB008 VA: 0x17DF008 Slot: 133
	protected sealed override string get_Suffix() { }
}

// Namespace: System.Reflection
internal sealed class SignatureConstructedGenericType : SignatureType // TypeDefIndex: 1227
{
	// Fields
	private readonly Type _genericTypeDefinition; // 0x18
	private readonly Type[] _genericTypeArguments; // 0x20

	// Properties
	public sealed override bool IsGenericTypeDefinition { get; }
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	public sealed override bool IsConstructedGenericType { get; }
	public sealed override bool IsGenericParameter { get; }
	public sealed override bool IsGenericMethodParameter { get; }
	public sealed override bool ContainsGenericParameters { get; }
	internal sealed override SignatureType ElementType { get; }
	public sealed override Type[] GenericTypeArguments { get; }
	public sealed override int GenericParameterPosition { get; }
	public sealed override string Name { get; }
	public sealed override string Namespace { get; }

	// Methods

	// RVA: 0x17DF048 Offset: 0x17DB048 VA: 0x17DF048
	internal void .ctor(Type genericTypeDefinition, Type[] typeArguments) { }

	// RVA: 0x17DF224 Offset: 0x17DB224 VA: 0x17DF224 Slot: 41
	public sealed override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x17DF22C Offset: 0x17DB22C VA: 0x17DF22C Slot: 45
	protected sealed override bool HasElementTypeImpl() { }

	// RVA: 0x17DF234 Offset: 0x17DB234 VA: 0x17DF234 Slot: 32
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x17DF23C Offset: 0x17DB23C VA: 0x17DF23C Slot: 34
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x17DF244 Offset: 0x17DB244 VA: 0x17DF244 Slot: 36
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x17DF24C Offset: 0x17DB24C VA: 0x17DF24C Slot: 42
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x17DF254 Offset: 0x17DB254 VA: 0x17DF254 Slot: 43
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x17DF25C Offset: 0x17DB25C VA: 0x17DF25C Slot: 37
	public sealed override bool get_IsConstructedGenericType() { }

	// RVA: 0x17DF264 Offset: 0x17DB264 VA: 0x17DF264 Slot: 38
	public sealed override bool get_IsGenericParameter() { }

	// RVA: 0x17DF26C Offset: 0x17DB26C VA: 0x17DF26C Slot: 39
	public sealed override bool get_IsGenericMethodParameter() { }

	// RVA: 0x17DF274 Offset: 0x17DB274 VA: 0x17DF274 Slot: 20
	public sealed override bool get_ContainsGenericParameters() { }

	// RVA: 0x17DF2E8 Offset: 0x17DB2E8 VA: 0x17DF2E8 Slot: 132
	internal sealed override SignatureType get_ElementType() { }

	// RVA: 0x17DF2F0 Offset: 0x17DB2F0 VA: 0x17DF2F0 Slot: 47
	public sealed override int GetArrayRank() { }

	// RVA: 0x17DF33C Offset: 0x17DB33C VA: 0x17DF33C Slot: 48
	public sealed override Type GetGenericTypeDefinition() { }

	// RVA: 0x17DF344 Offset: 0x17DB344 VA: 0x17DF344 Slot: 50
	public sealed override Type[] GetGenericArguments() { }

	// RVA: 0x17DF354 Offset: 0x17DB354 VA: 0x17DF354 Slot: 49
	public sealed override Type[] get_GenericTypeArguments() { }

	// RVA: 0x17DF3CC Offset: 0x17DB3CC VA: 0x17DF3CC Slot: 51
	public sealed override int get_GenericParameterPosition() { }

	// RVA: 0x17DF418 Offset: 0x17DB418 VA: 0x17DF418 Slot: 8
	public sealed override string get_Name() { }

	// RVA: 0x17DF434 Offset: 0x17DB434 VA: 0x17DF434 Slot: 24
	public sealed override string get_Namespace() { }

	// RVA: 0x17DF454 Offset: 0x17DB454 VA: 0x17DF454 Slot: 3
	public sealed override string ToString() { }
}

// Namespace: System.Reflection
internal abstract class SignatureHasElementType : SignatureType // TypeDefIndex: 1228
{
	// Fields
	private readonly SignatureType _elementType; // 0x18

	// Properties
	public sealed override bool IsGenericTypeDefinition { get; }
	public abstract override bool IsSZArray { get; }
	public abstract override bool IsVariableBoundArray { get; }
	public sealed override bool IsConstructedGenericType { get; }
	public sealed override bool IsGenericParameter { get; }
	public sealed override bool IsGenericMethodParameter { get; }
	public sealed override bool ContainsGenericParameters { get; }
	internal sealed override SignatureType ElementType { get; }
	public sealed override Type[] GenericTypeArguments { get; }
	public sealed override int GenericParameterPosition { get; }
	public sealed override string Name { get; }
	public sealed override string Namespace { get; }
	protected abstract string Suffix { get; }

	// Methods

	// RVA: 0x17DEE3C Offset: 0x17DAE3C VA: 0x17DEE3C
	protected void .ctor(SignatureType elementType) { }

	// RVA: 0x17DF578 Offset: 0x17DB578 VA: 0x17DF578 Slot: 41
	public sealed override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x17DF580 Offset: 0x17DB580 VA: 0x17DF580 Slot: 45
	protected sealed override bool HasElementTypeImpl() { }

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract override bool IsArrayImpl();

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract override bool IsByRefImpl();

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract override bool IsPointerImpl();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract override bool get_IsSZArray();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract override bool get_IsVariableBoundArray();

	// RVA: 0x17DF588 Offset: 0x17DB588 VA: 0x17DF588 Slot: 37
	public sealed override bool get_IsConstructedGenericType() { }

	// RVA: 0x17DF590 Offset: 0x17DB590 VA: 0x17DF590 Slot: 38
	public sealed override bool get_IsGenericParameter() { }

	// RVA: 0x17DF598 Offset: 0x17DB598 VA: 0x17DF598 Slot: 39
	public sealed override bool get_IsGenericMethodParameter() { }

	// RVA: 0x17DF5A0 Offset: 0x17DB5A0 VA: 0x17DF5A0 Slot: 20
	public sealed override bool get_ContainsGenericParameters() { }

	// RVA: 0x17DF5C0 Offset: 0x17DB5C0 VA: 0x17DF5C0 Slot: 132
	internal sealed override SignatureType get_ElementType() { }

	// RVA: -1 Offset: -1 Slot: 47
	public abstract override int GetArrayRank();

	// RVA: 0x17DF5C8 Offset: 0x17DB5C8 VA: 0x17DF5C8 Slot: 48
	public sealed override Type GetGenericTypeDefinition() { }

	// RVA: 0x17DF614 Offset: 0x17DB614 VA: 0x17DF614 Slot: 50
	public sealed override Type[] GetGenericArguments() { }

	// RVA: 0x17DF6A8 Offset: 0x17DB6A8 VA: 0x17DF6A8 Slot: 49
	public sealed override Type[] get_GenericTypeArguments() { }

	// RVA: 0x17DF73C Offset: 0x17DB73C VA: 0x17DF73C Slot: 51
	public sealed override int get_GenericParameterPosition() { }

	// RVA: 0x17DF788 Offset: 0x17DB788 VA: 0x17DF788 Slot: 8
	public sealed override string get_Name() { }

	// RVA: 0x17DF7DC Offset: 0x17DB7DC VA: 0x17DF7DC Slot: 24
	public sealed override string get_Namespace() { }

	// RVA: 0x17DF7FC Offset: 0x17DB7FC VA: 0x17DF7FC Slot: 3
	public sealed override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 133
	protected abstract string get_Suffix();
}

// Namespace: System.Reflection
internal sealed class SignaturePointerType : SignatureHasElementType // TypeDefIndex: 1229
{
	// Properties
	public sealed override bool IsSZArray { get; }
	public sealed override bool IsVariableBoundArray { get; }
	protected sealed override string Suffix { get; }

	// Methods

	// RVA: 0x17DF850 Offset: 0x17DB850 VA: 0x17DF850
	internal void .ctor(SignatureType elementType) { }

	// RVA: 0x17DF87C Offset: 0x17DB87C VA: 0x17DF87C Slot: 32
	protected sealed override bool IsArrayImpl() { }

	// RVA: 0x17DF884 Offset: 0x17DB884 VA: 0x17DF884 Slot: 34
	protected sealed override bool IsByRefImpl() { }

	// RVA: 0x17DF88C Offset: 0x17DB88C VA: 0x17DF88C Slot: 36
	protected sealed override bool IsPointerImpl() { }

	// RVA: 0x17DF894 Offset: 0x17DB894 VA: 0x17DF894 Slot: 42
	public sealed override bool get_IsSZArray() { }

	// RVA: 0x17DF89C Offset: 0x17DB89C VA: 0x17DF89C Slot: 43
	public sealed override bool get_IsVariableBoundArray() { }

	// RVA: 0x17DF8A4 Offset: 0x17DB8A4 VA: 0x17DF8A4 Slot: 47
	public sealed override int GetArrayRank() { }

	// RVA: 0x17DF8F0 Offset: 0x17DB8F0 VA: 0x17DF8F0 Slot: 133
	protected sealed override string get_Suffix() { }
}

// Namespace: System.Reflection
internal abstract class SignatureType : Type // TypeDefIndex: 1230
{
	// Properties
	public sealed override bool IsSignatureType { get; }
	public abstract override bool IsSZArray { get; }
	public abstract override bool IsVariableBoundArray { get; }
	public sealed override bool IsGenericType { get; }
	public abstract override bool IsGenericTypeDefinition { get; }
	public abstract override bool IsConstructedGenericType { get; }
	public abstract override bool IsGenericParameter { get; }
	public abstract override bool IsGenericMethodParameter { get; }
	public abstract override bool ContainsGenericParameters { get; }
	public sealed override MemberTypes MemberType { get; }
	public abstract override Type[] GenericTypeArguments { get; }
	public abstract override int GenericParameterPosition { get; }
	internal abstract SignatureType ElementType { get; }
	public sealed override Type UnderlyingSystemType { get; }
	public abstract override string Name { get; }
	public abstract override string Namespace { get; }
	public sealed override string FullName { get; }
	public sealed override string AssemblyQualifiedName { get; }
	public sealed override Assembly Assembly { get; }
	public sealed override Module Module { get; }
	public sealed override Type ReflectedType { get; }
	public sealed override Type BaseType { get; }
	public sealed override int MetadataToken { get; }
	public sealed override Type DeclaringType { get; }
	public sealed override MethodBase DeclaringMethod { get; }
	public sealed override GenericParameterAttributes GenericParameterAttributes { get; }
	public sealed override bool IsEnum { get; }
	public sealed override bool IsSerializable { get; }
	public sealed override RuntimeTypeHandle TypeHandle { get; }

	// Methods

	// RVA: 0x17DF930 Offset: 0x17DB930 VA: 0x17DF930 Slot: 76
	public sealed override bool get_IsSignatureType() { }

	// RVA: -1 Offset: -1 Slot: 45
	protected abstract override bool HasElementTypeImpl();

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract override bool IsArrayImpl();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract override bool get_IsSZArray();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract override bool get_IsVariableBoundArray();

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract override bool IsByRefImpl();

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract override bool IsPointerImpl();

	// RVA: 0x17DF938 Offset: 0x17DB938 VA: 0x17DF938 Slot: 40
	public sealed override bool get_IsGenericType() { }

	// RVA: -1 Offset: -1 Slot: 41
	public abstract override bool get_IsGenericTypeDefinition();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract override bool get_IsConstructedGenericType();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract override bool get_IsGenericParameter();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract override bool get_IsGenericMethodParameter();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract override bool get_ContainsGenericParameters();

	// RVA: 0x17DF978 Offset: 0x17DB978 VA: 0x17DF978 Slot: 7
	public sealed override MemberTypes get_MemberType() { }

	// RVA: 0x17DF980 Offset: 0x17DB980 VA: 0x17DF980 Slot: 122
	public sealed override Type MakeArrayType() { }

	// RVA: 0x17DF9F0 Offset: 0x17DB9F0 VA: 0x17DF9F0 Slot: 123
	public sealed override Type MakeArrayType(int rank) { }

	// RVA: 0x17DFAA0 Offset: 0x17DBAA0 VA: 0x17DFAA0 Slot: 124
	public sealed override Type MakeByRefType() { }

	// RVA: 0x17DFB04 Offset: 0x17DBB04 VA: 0x17DFB04 Slot: 126
	public sealed override Type MakePointerType() { }

	// RVA: 0x17DFB68 Offset: 0x17DBB68 VA: 0x17DFB68 Slot: 125
	public sealed override Type MakeGenericType(Type[] typeArguments) { }

	// RVA: 0x17DFBB4 Offset: 0x17DBBB4 VA: 0x17DFBB4 Slot: 46
	public sealed override Type GetElementType() { }

	// RVA: -1 Offset: -1 Slot: 47
	public abstract override int GetArrayRank();

	// RVA: -1 Offset: -1 Slot: 48
	public abstract override Type GetGenericTypeDefinition();

	// RVA: -1 Offset: -1 Slot: 49
	public abstract override Type[] get_GenericTypeArguments();

	// RVA: -1 Offset: -1 Slot: 50
	public abstract override Type[] GetGenericArguments();

	// RVA: -1 Offset: -1 Slot: 51
	public abstract override int get_GenericParameterPosition();

	// RVA: -1 Offset: -1 Slot: 132
	internal abstract SignatureType get_ElementType();

	// RVA: 0x17DFBC4 Offset: 0x17DBBC4 VA: 0x17DFBC4 Slot: 30
	public sealed override Type get_UnderlyingSystemType() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract override string get_Name();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract override string get_Namespace();

	// RVA: 0x17DFBC8 Offset: 0x17DBBC8 VA: 0x17DFBC8 Slot: 26
	public sealed override string get_FullName() { }

	// RVA: 0x17DFBD0 Offset: 0x17DBBD0 VA: 0x17DFBD0 Slot: 25
	public sealed override string get_AssemblyQualifiedName() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract override string ToString();

	// RVA: 0x17DFBD8 Offset: 0x17DBBD8 VA: 0x17DFBD8 Slot: 27
	public sealed override Assembly get_Assembly() { }

	// RVA: 0x17DFC24 Offset: 0x17DBC24 VA: 0x17DFC24 Slot: 28
	public sealed override Module get_Module() { }

	// RVA: 0x17DFC70 Offset: 0x17DBC70 VA: 0x17DFC70 Slot: 10
	public sealed override Type get_ReflectedType() { }

	// RVA: 0x17DFCBC Offset: 0x17DBCBC VA: 0x17DFCBC Slot: 115
	public sealed override Type get_BaseType() { }

	// RVA: 0x17DFD08 Offset: 0x17DBD08 VA: 0x17DFD08 Slot: 117
	public sealed override Type[] GetInterfaces() { }

	// RVA: 0x17DFD54 Offset: 0x17DBD54 VA: 0x17DFD54 Slot: 22
	public sealed override bool IsAssignableFrom(Type c) { }

	// RVA: 0x17DFDA0 Offset: 0x17DBDA0 VA: 0x17DFDA0 Slot: 15
	public sealed override int get_MetadataToken() { }

	// RVA: 0x17DFDEC Offset: 0x17DBDEC VA: 0x17DFDEC Slot: 9
	public sealed override Type get_DeclaringType() { }

	// RVA: 0x17DFE38 Offset: 0x17DBE38 VA: 0x17DFE38 Slot: 29
	public sealed override MethodBase get_DeclaringMethod() { }

	// RVA: 0x17DFE84 Offset: 0x17DBE84 VA: 0x17DFE84 Slot: 53
	public sealed override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x17DFED0 Offset: 0x17DBED0 VA: 0x17DFED0 Slot: 52
	public sealed override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x17DFF1C Offset: 0x17DBF1C VA: 0x17DFF1C Slot: 16
	public sealed override bool IsEnumDefined(object value) { }

	// RVA: 0x17DFF68 Offset: 0x17DBF68 VA: 0x17DFF68 Slot: 17
	public sealed override string GetEnumName(object value) { }

	// RVA: 0x17DFFB4 Offset: 0x17DBFB4 VA: 0x17DFFB4 Slot: 18
	public sealed override string[] GetEnumNames() { }

	// RVA: 0x17E0000 Offset: 0x17DC000 VA: 0x17E0000 Slot: 120
	public sealed override Type GetEnumUnderlyingType() { }

	// RVA: 0x17E004C Offset: 0x17DC04C VA: 0x17E004C Slot: 121
	public sealed override Array GetEnumValues() { }

	// RVA: 0x17E0098 Offset: 0x17DC098 VA: 0x17E0098 Slot: 114
	protected sealed override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x17E00E4 Offset: 0x17DC0E4 VA: 0x17E00E4 Slot: 55
	protected sealed override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x17E0130 Offset: 0x17DC130 VA: 0x17E0130 Slot: 82
	public sealed override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x17E017C Offset: 0x17DC17C VA: 0x17E017C Slot: 84
	public sealed override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17E01C8 Offset: 0x17DC1C8 VA: 0x17E01C8 Slot: 85
	public sealed override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x17E0214 Offset: 0x17DC214 VA: 0x17E0214 Slot: 87
	public sealed override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17E0260 Offset: 0x17DC260 VA: 0x17E0260 Slot: 89
	public sealed override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x17E02AC Offset: 0x17DC2AC VA: 0x17E02AC Slot: 93
	public sealed override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x17E02F8 Offset: 0x17DC2F8 VA: 0x17E02F8 Slot: 102
	public sealed override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x17E0344 Offset: 0x17DC344 VA: 0x17E0344 Slot: 103
	public sealed override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17E0390 Offset: 0x17DC390 VA: 0x17E0390 Slot: 104
	public sealed override Type[] GetNestedTypes(BindingFlags bindingAttr) { }

	// RVA: 0x17E03DC Offset: 0x17DC3DC VA: 0x17E03DC Slot: 112
	public sealed override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x17E0428 Offset: 0x17DC428 VA: 0x17E0428 Slot: 116
	public sealed override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x17E0474 Offset: 0x17DC474 VA: 0x17E0474 Slot: 100
	protected sealed override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x17E04C0 Offset: 0x17DC4C0 VA: 0x17E04C0 Slot: 111
	protected sealed override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x17E050C Offset: 0x17DC50C VA: 0x17E050C Slot: 91
	public sealed override MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17E0558 Offset: 0x17DC558 VA: 0x17E0558 Slot: 92
	public sealed override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x17E05A4 Offset: 0x17DC5A4 VA: 0x17E05A4 Slot: 13
	public sealed override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17E05F0 Offset: 0x17DC5F0 VA: 0x17E05F0 Slot: 14
	public sealed override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17E063C Offset: 0x17DC63C VA: 0x17E063C Slot: 12
	public sealed override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17E0688 Offset: 0x17DC688 VA: 0x17E0688 Slot: 80
	protected sealed override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x17E06D4 Offset: 0x17DC6D4 VA: 0x17E06D4 Slot: 65
	protected sealed override bool IsCOMObjectImpl() { }

	// RVA: 0x17E0720 Offset: 0x17DC720 VA: 0x17E0720 Slot: 73
	protected sealed override bool IsPrimitiveImpl() { }

	// RVA: 0x17E076C Offset: 0x17DC76C VA: 0x17E076C Slot: 67
	protected sealed override bool IsContextfulImpl() { }

	// RVA: 0x17E07B8 Offset: 0x17DC7B8 VA: 0x17E07B8 Slot: 69
	public sealed override bool get_IsEnum() { }

	// RVA: 0x17E0804 Offset: 0x17DC804 VA: 0x17E0804 Slot: 119
	public sealed override bool IsEquivalentTo(Type other) { }

	// RVA: 0x17E0850 Offset: 0x17DC850 VA: 0x17E0850 Slot: 118
	public sealed override bool IsInstanceOfType(object o) { }

	// RVA: 0x17E089C Offset: 0x17DC89C VA: 0x17E089C Slot: 71
	protected sealed override bool IsMarshalByRefImpl() { }

	// RVA: 0x17E08E8 Offset: 0x17DC8E8 VA: 0x17E08E8 Slot: 19
	public sealed override bool get_IsSerializable() { }

	// RVA: 0x17E0934 Offset: 0x17DC934 VA: 0x17E0934 Slot: 21
	public sealed override bool IsSubclassOf(Type c) { }

	// RVA: 0x17E0980 Offset: 0x17DC980 VA: 0x17E0980 Slot: 75
	protected sealed override bool IsValueTypeImpl() { }

	// RVA: 0x17E09CC Offset: 0x17DC9CC VA: 0x17E09CC Slot: 113
	public sealed override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x17DF1F0 Offset: 0x17DB1F0 VA: 0x17DF1F0
	protected void .ctor() { }
}

// Namespace: System.Reflection
[Extension]
internal static class SignatureTypeExtensions // TypeDefIndex: 1231
{
	// Methods

	[Extension]
	// RVA: 0x17E0A18 Offset: 0x17DCA18 VA: 0x17E0A18
	public static bool MatchesParameterTypeExactly(Type pattern, ParameterInfo parameter) { }

	[Extension]
	// RVA: 0x17E0AD4 Offset: 0x17DCAD4 VA: 0x17E0AD4
	internal static bool MatchesExactly(SignatureType pattern, Type actual) { }

	[Extension]
	// RVA: 0x17E0E78 Offset: 0x17DCE78 VA: 0x17E0E78
	internal static Type TryResolveAgainstGenericMethod(SignatureType signatureType, MethodInfo genericMethod) { }

	[Extension]
	// RVA: 0x17E0EB0 Offset: 0x17DCEB0 VA: 0x17E0EB0
	private static Type TryResolve(SignatureType signatureType, Type[] genericMethodParameters) { }

	[Extension]
	// RVA: 0x17E128C Offset: 0x17DD28C VA: 0x17E128C
	private static Type TryMakeArrayType(Type type) { }

	[Extension]
	// RVA: 0x17E1328 Offset: 0x17DD328 VA: 0x17E1328
	private static Type TryMakeArrayType(Type type, int rank) { }

	[Extension]
	// RVA: 0x17E13C4 Offset: 0x17DD3C4 VA: 0x17E13C4
	private static Type TryMakeByRefType(Type type) { }

	[Extension]
	// RVA: 0x17E1460 Offset: 0x17DD460 VA: 0x17E1460
	private static Type TryMakePointerType(Type type) { }

	[Extension]
	// RVA: 0x17E14FC Offset: 0x17DD4FC VA: 0x17E14FC
	private static Type TryMakeGenericType(Type type, Type[] instantiation) { }
}

// Namespace: System.Reflection
[Serializable]
public class TargetException : ApplicationException // TypeDefIndex: 1232
{
	// Methods

	// RVA: 0x17E1598 Offset: 0x17DD598 VA: 0x17E1598
	public void .ctor() { }

	// RVA: 0x17E15C4 Offset: 0x17DD5C4 VA: 0x17E15C4
	public void .ctor(string message) { }

	// RVA: 0x17E15EC Offset: 0x17DD5EC VA: 0x17E15EC
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x17E1610 Offset: 0x17DD610 VA: 0x17E1610
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
[Serializable]
public sealed class TargetInvocationException : ApplicationException // TypeDefIndex: 1233
{
	// Methods

	// RVA: 0x17E1618 Offset: 0x17DD618 VA: 0x17E1618
	public void .ctor(Exception inner) { }

	// RVA: 0x17E1684 Offset: 0x17DD684 VA: 0x17E1684
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x17E16A8 Offset: 0x17DD6A8 VA: 0x17E16A8
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
[Serializable]
public sealed class TargetParameterCountException : ApplicationException // TypeDefIndex: 1234
{
	// Methods

	// RVA: 0x17E16B0 Offset: 0x17DD6B0 VA: 0x17E16B0
	public void .ctor() { }

	// RVA: 0x17E170C Offset: 0x17DD70C VA: 0x17E170C
	public void .ctor(string message) { }

	// RVA: 0x17E1730 Offset: 0x17DD730 VA: 0x17E1730
	internal void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Reflection
[Flags]
public enum TypeAttributes // TypeDefIndex: 1235
{
	// Fields
	public int value__; // 0x0
	public const TypeAttributes VisibilityMask = 7;
	public const TypeAttributes NotPublic = 0;
	public const TypeAttributes Public = 1;
	public const TypeAttributes NestedPublic = 2;
	public const TypeAttributes NestedPrivate = 3;
	public const TypeAttributes NestedFamily = 4;
	public const TypeAttributes NestedAssembly = 5;
	public const TypeAttributes NestedFamANDAssem = 6;
	public const TypeAttributes NestedFamORAssem = 7;
	public const TypeAttributes LayoutMask = 24;
	public const TypeAttributes AutoLayout = 0;
	public const TypeAttributes SequentialLayout = 8;
	public const TypeAttributes ExplicitLayout = 16;
	public const TypeAttributes ClassSemanticsMask = 32;
	public const TypeAttributes Class = 0;
	public const TypeAttributes Interface = 32;
	public const TypeAttributes Abstract = 128;
	public const TypeAttributes Sealed = 256;
	public const TypeAttributes SpecialName = 1024;
	public const TypeAttributes Import = 4096;
	public const TypeAttributes Serializable = 8192;
	public const TypeAttributes WindowsRuntime = 16384;
	public const TypeAttributes StringFormatMask = 196608;
	public const TypeAttributes AnsiClass = 0;
	public const TypeAttributes UnicodeClass = 65536;
	public const TypeAttributes AutoClass = 131072;
	public const TypeAttributes CustomFormatClass = 196608;
	public const TypeAttributes CustomFormatMask = 12582912;
	public const TypeAttributes BeforeFieldInit = 1048576;
	public const TypeAttributes RTSpecialName = 2048;
	public const TypeAttributes HasSecurity = 262144;
	public const TypeAttributes ReservedMask = 264192;
}

// Namespace: System.Reflection
public class TypeDelegator : TypeInfo // TypeDefIndex: 1236
{
	// Fields
	protected Type typeImpl; // 0x18

	// Properties
	public override int MetadataToken { get; }
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override string Name { get; }
	public override string FullName { get; }
	public override string Namespace { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override bool IsSZArray { get; }
	public override bool IsGenericMethodParameter { get; }
	public override bool IsConstructedGenericType { get; }
	public override bool IsCollectible { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x17DCAD0 Offset: 0x17D8AD0 VA: 0x17DCAD0
	public void .ctor(Type delegatingType) { }

	// RVA: 0x17E176C Offset: 0x17DD76C VA: 0x17E176C Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x17E178C Offset: 0x17DD78C VA: 0x17E178C Slot: 116
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x17E17B8 Offset: 0x17DD7B8 VA: 0x17E17B8 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x17E17D8 Offset: 0x17DD7D8 VA: 0x17E17D8 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x17E17F8 Offset: 0x17DD7F8 VA: 0x17E17F8 Slot: 113
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x17E1818 Offset: 0x17DD818 VA: 0x17E1818 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17E1834 Offset: 0x17DD834 VA: 0x17E1834 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x17E1854 Offset: 0x17DD854 VA: 0x17E1854 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x17E1874 Offset: 0x17DD874 VA: 0x17E1874 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x17E1894 Offset: 0x17DD894 VA: 0x17E1894 Slot: 115
	public override Type get_BaseType() { }

	// RVA: 0x17E18B4 Offset: 0x17DD8B4 VA: 0x17E18B4 Slot: 80
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x17E18CC Offset: 0x17DD8CC VA: 0x17E18CC Slot: 82
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x17E18EC Offset: 0x17DD8EC VA: 0x17E18EC Slot: 100
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x17E191C Offset: 0x17DD91C VA: 0x17E191C Slot: 102
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x17E193C Offset: 0x17DD93C VA: 0x17E193C Slot: 87
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17E195C Offset: 0x17DD95C VA: 0x17E195C Slot: 89
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x17E197C Offset: 0x17DD97C VA: 0x17E197C Slot: 117
	public override Type[] GetInterfaces() { }

	// RVA: 0x17E199C Offset: 0x17DD99C VA: 0x17E199C Slot: 84
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17E19BC Offset: 0x17DD9BC VA: 0x17E19BC Slot: 111
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x17E1A84 Offset: 0x17DDA84 VA: 0x17E1A84 Slot: 112
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x17E1AA4 Offset: 0x17DDAA4 VA: 0x17E1AA4 Slot: 85
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x17E1AC4 Offset: 0x17DDAC4 VA: 0x17E1AC4 Slot: 104
	public override Type[] GetNestedTypes(BindingFlags bindingAttr) { }

	// RVA: 0x17E1AE4 Offset: 0x17DDAE4 VA: 0x17E1AE4 Slot: 103
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17E1B04 Offset: 0x17DDB04 VA: 0x17E1B04 Slot: 92
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x17E1B24 Offset: 0x17DDB24 VA: 0x17E1B24 Slot: 93
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x17E1B44 Offset: 0x17DDB44 VA: 0x17E1B44 Slot: 55
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x17E1B5C Offset: 0x17DDB5C VA: 0x17E1B5C Slot: 42
	public override bool get_IsSZArray() { }

	// RVA: 0x17E1B7C Offset: 0x17DDB7C VA: 0x17E1B7C Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x17E1B94 Offset: 0x17DDB94 VA: 0x17E1B94 Slot: 73
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x17E1BAC Offset: 0x17DDBAC VA: 0x17E1BAC Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x17E1BC4 Offset: 0x17DDBC4 VA: 0x17E1BC4 Slot: 39
	public override bool get_IsGenericMethodParameter() { }

	// RVA: 0x17E1BE4 Offset: 0x17DDBE4 VA: 0x17E1BE4 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x17E1BFC Offset: 0x17DDBFC VA: 0x17E1BFC Slot: 75
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x17E1C14 Offset: 0x17DDC14 VA: 0x17E1C14 Slot: 65
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x17E1C2C Offset: 0x17DDC2C VA: 0x17E1C2C Slot: 37
	public override bool get_IsConstructedGenericType() { }

	// RVA: 0x17E1C4C Offset: 0x17DDC4C VA: 0x17E1C4C Slot: 68
	public override bool get_IsCollectible() { }

	// RVA: 0x17E1C6C Offset: 0x17DDC6C VA: 0x17E1C6C Slot: 46
	public override Type GetElementType() { }

	// RVA: 0x17E1C8C Offset: 0x17DDC8C VA: 0x17E1C8C Slot: 45
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x17E1CA4 Offset: 0x17DDCA4 VA: 0x17E1CA4 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x17E1CC4 Offset: 0x17DDCC4 VA: 0x17E1CC4 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17E1CE8 Offset: 0x17DDCE8 VA: 0x17E1CE8 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17E1D0C Offset: 0x17DDD0C VA: 0x17E1D0C Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

// Namespace: System.Reflection
public sealed class TypeFilter : MulticastDelegate // TypeDefIndex: 1237
{
	// Methods

	// RVA: 0x17DE064 Offset: 0x17DA064 VA: 0x17DE064
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17E1D2C Offset: 0x17DDD2C VA: 0x17E1D2C Slot: 12
	public virtual bool Invoke(Type m, object filterCriteria) { }
}

// Namespace: System.Reflection
public abstract class TypeInfo : Type, IReflectableType // TypeDefIndex: 1238
{
	// Properties
	public virtual IEnumerable<FieldInfo> DeclaredFields { get; }
	public virtual IEnumerable<Type> ImplementedInterfaces { get; }

	// Methods

	// RVA: 0x17E1738 Offset: 0x17DD738 VA: 0x17E1738
	protected void .ctor() { }

	// RVA: 0x17E1D40 Offset: 0x17DDD40 VA: 0x17E1D40 Slot: 132
	private TypeInfo System.Reflection.IReflectableType.GetTypeInfo() { }

	// RVA: 0x17E1D44 Offset: 0x17DDD44 VA: 0x17E1D44 Slot: 133
	public virtual IEnumerable<FieldInfo> get_DeclaredFields() { }

	// RVA: 0x17E1D58 Offset: 0x17DDD58 VA: 0x17E1D58 Slot: 134
	public virtual IEnumerable<Type> get_ImplementedInterfaces() { }
}

// Namespace: System.Reflection
[Extension]
public static class RuntimeReflectionExtensions // TypeDefIndex: 1239
{
	// Methods

	[Extension]
	// RVA: 0x17E1D68 Offset: 0x17DDD68 VA: 0x17E1D68
	public static MethodInfo GetRuntimeMethod(Type type, string name, Type[] parameters) { }

	[Extension]
	// RVA: 0x17E1E18 Offset: 0x17DDE18 VA: 0x17E1E18
	public static PropertyInfo GetRuntimeProperty(Type type, string name) { }
}

// Namespace: System.Reflection
public struct CustomAttributeNamedArgument // TypeDefIndex: 1240
{
	// Fields
	[CompilerGenerated]
	private readonly CustomAttributeTypedArgument <TypedValue>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly bool <IsField>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <MemberName>k__BackingField; // 0x18
	private readonly Type _attributeType; // 0x20
	private MemberInfo _lazyMemberInfo; // 0x28

	// Properties
	public CustomAttributeTypedArgument TypedValue { get; }
	public bool IsField { get; }
	public string MemberName { get; }
	public MemberInfo MemberInfo { get; }

	// Methods

	// RVA: 0x17E1EC0 Offset: 0x17DDEC0 VA: 0x17E1EC0
	internal void .ctor(Type attributeType, string memberName, bool isField, CustomAttributeTypedArgument typedValue) { }

	// RVA: 0x17E1F2C Offset: 0x17DDF2C VA: 0x17E1F2C
	public void .ctor(MemberInfo memberInfo, object value) { }

	// RVA: 0x17E21B0 Offset: 0x17DE1B0 VA: 0x17E21B0
	public void .ctor(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x17E22FC Offset: 0x17DE2FC VA: 0x17E22FC
	public CustomAttributeTypedArgument get_TypedValue() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x17E2308 Offset: 0x17DE308 VA: 0x17E2308
	public bool get_IsField() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x17E2310 Offset: 0x17DE310 VA: 0x17E2310
	public string get_MemberName() { }

	// RVA: 0x17E2318 Offset: 0x17DE318 VA: 0x17E2318
	public MemberInfo get_MemberInfo() { }

	// RVA: 0x17E2408 Offset: 0x17DE408 VA: 0x17E2408 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17E2480 Offset: 0x17DE480 VA: 0x17E2480 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17E24EC Offset: 0x17DE4EC VA: 0x17E24EC
	public static bool op_Equality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	// RVA: 0x17E256C Offset: 0x17DE56C VA: 0x17E256C
	public static bool op_Inequality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	// RVA: 0x17E25F0 Offset: 0x17DE5F0 VA: 0x17E25F0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Reflection
public struct CustomAttributeTypedArgument // TypeDefIndex: 1241
{
	// Fields
	[CompilerGenerated]
	private readonly Type <ArgumentType>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; // 0x8

	// Properties
	public Type ArgumentType { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x17E31A8 Offset: 0x17DF1A8 VA: 0x17E31A8
	public void .ctor(object value) { }

	// RVA: 0x17DC6CC Offset: 0x17D86CC VA: 0x17DC6CC
	public void .ctor(Type argumentType, object value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x17E32C8 Offset: 0x17DF2C8 VA: 0x17E32C8
	public Type get_ArgumentType() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x17E32D0 Offset: 0x17DF2D0 VA: 0x17E32D0
	public object get_Value() { }

	// RVA: 0x17E32D8 Offset: 0x17DF2D8 VA: 0x17E32D8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17E3348 Offset: 0x17DF348 VA: 0x17E3348 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17E33AC Offset: 0x17DF3AC VA: 0x17E33AC
	public static bool op_Equality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	// RVA: 0x17E3424 Offset: 0x17DF424 VA: 0x17E3424
	public static bool op_Inequality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	// RVA: 0x17E34A0 Offset: 0x17DF4A0 VA: 0x17E34A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x17E28FC Offset: 0x17DE8FC VA: 0x17E28FC
	internal string ToString(bool typed) { }

	// RVA: 0x17E3240 Offset: 0x17DF240 VA: 0x17E3240
	private static object CanonicalizeValue(object value) { }
}

// Namespace: System.Reflection
public sealed class MissingMetadataException : TypeAccessException // TypeDefIndex: 1242
{
	// Methods

	// RVA: 0x17E34A8 Offset: 0x17DF4A8 VA: 0x17E34A8
	public void .ctor() { }
}

// Namespace: System.Reflection
[Extension]
public static class CustomAttributeExtensions // TypeDefIndex: 1243
{
	// Methods

	[Extension]
	// RVA: 0x17E34B0 Offset: 0x17DF4B0 VA: 0x17E34B0
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	[Extension]
	// RVA: 0x17E34B8 Offset: 0x17DF4B8 VA: 0x17E34B8
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(Assembly element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F4590 Offset: 0x10F0590 VA: 0x10F4590
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F4640 Offset: 0x10F0640 VA: 0x10F4640
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[Extension]
	// RVA: 0x17E34C0 Offset: 0x17DF4C0 VA: 0x17E34C0
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element) { }

	[Extension]
	// RVA: 0x17E34C8 Offset: 0x17DF4C8 VA: 0x17E34C8
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetCustomAttributes<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F46F0 Offset: 0x10F06F0 VA: 0x10F46F0
	|-CustomAttributeExtensions.GetCustomAttributes<object>
	*/

	[Extension]
	// RVA: 0x17E34D0 Offset: 0x17DF4D0 VA: 0x17E34D0
	public static bool IsDefined(MemberInfo element, Type attributeType) { }
}

// Namespace: System.Reflection
[Serializable]
internal enum CorElementType // TypeDefIndex: 1244
{
	// Fields
	public byte value__; // 0x0
	public const CorElementType End = 0;
	public const CorElementType Void = 1;
	public const CorElementType Boolean = 2;
	public const CorElementType Char = 3;
	public const CorElementType I1 = 4;
	public const CorElementType U1 = 5;
	public const CorElementType I2 = 6;
	public const CorElementType U2 = 7;
	public const CorElementType I4 = 8;
	public const CorElementType U4 = 9;
	public const CorElementType I8 = 10;
	public const CorElementType U8 = 11;
	public const CorElementType R4 = 12;
	public const CorElementType R8 = 13;
	public const CorElementType String = 14;
	public const CorElementType Ptr = 15;
	public const CorElementType ByRef = 16;
	public const CorElementType ValueType = 17;
	public const CorElementType Class = 18;
	public const CorElementType Var = 19;
	public const CorElementType Array = 20;
	public const CorElementType GenericInst = 21;
	public const CorElementType TypedByRef = 22;
	public const CorElementType I = 24;
	public const CorElementType U = 25;
	public const CorElementType FnPtr = 27;
	public const CorElementType Object = 28;
	public const CorElementType SzArray = 29;
	public const CorElementType MVar = 30;
	public const CorElementType CModReqd = 31;
	public const CorElementType CModOpt = 32;
	public const CorElementType Internal = 33;
	public const CorElementType Max = 34;
	public const CorElementType Modifier = 64;
	public const CorElementType Sentinel = 65;
	public const CorElementType Pinned = 69;
	public const CorElementType ELEMENT_TYPE_END = 0;
	public const CorElementType ELEMENT_TYPE_VOID = 1;
	public const CorElementType ELEMENT_TYPE_BOOLEAN = 2;
	public const CorElementType ELEMENT_TYPE_CHAR = 3;
	public const CorElementType ELEMENT_TYPE_I1 = 4;
	public const CorElementType ELEMENT_TYPE_U1 = 5;
	public const CorElementType ELEMENT_TYPE_I2 = 6;
	public const CorElementType ELEMENT_TYPE_U2 = 7;
	public const CorElementType ELEMENT_TYPE_I4 = 8;
	public const CorElementType ELEMENT_TYPE_U4 = 9;
	public const CorElementType ELEMENT_TYPE_I8 = 10;
	public const CorElementType ELEMENT_TYPE_U8 = 11;
	public const CorElementType ELEMENT_TYPE_R4 = 12;
	public const CorElementType ELEMENT_TYPE_R8 = 13;
	public const CorElementType ELEMENT_TYPE_STRING = 14;
	public const CorElementType ELEMENT_TYPE_PTR = 15;
	public const CorElementType ELEMENT_TYPE_BYREF = 16;
	public const CorElementType ELEMENT_TYPE_VALUETYPE = 17;
	public const CorElementType ELEMENT_TYPE_CLASS = 18;
	public const CorElementType ELEMENT_TYPE_VAR = 19;
	public const CorElementType ELEMENT_TYPE_ARRAY = 20;
	public const CorElementType ELEMENT_TYPE_GENERICINST = 21;
	public const CorElementType ELEMENT_TYPE_TYPEDBYREF = 22;
	public const CorElementType ELEMENT_TYPE_I = 24;
	public const CorElementType ELEMENT_TYPE_U = 25;
	public const CorElementType ELEMENT_TYPE_FNPTR = 27;
	public const CorElementType ELEMENT_TYPE_OBJECT = 28;
	public const CorElementType ELEMENT_TYPE_SZARRAY = 29;
	public const CorElementType ELEMENT_TYPE_MVAR = 30;
	public const CorElementType ELEMENT_TYPE_CMOD_REQD = 31;
	public const CorElementType ELEMENT_TYPE_CMOD_OPT = 32;
	public const CorElementType ELEMENT_TYPE_INTERNAL = 33;
	public const CorElementType ELEMENT_TYPE_MAX = 34;
	public const CorElementType ELEMENT_TYPE_MODIFIER = 64;
	public const CorElementType ELEMENT_TYPE_SENTINEL = 65;
	public const CorElementType ELEMENT_TYPE_PINNED = 69;
}

// Namespace: System.Reflection
[Flags]
[Serializable]
internal enum PInvokeAttributes // TypeDefIndex: 1245
{
	// Fields
	public int value__; // 0x0
	public const PInvokeAttributes NoMangle = 1;
	public const PInvokeAttributes CharSetMask = 6;
	public const PInvokeAttributes CharSetNotSpec = 0;
	public const PInvokeAttributes CharSetAnsi = 2;
	public const PInvokeAttributes CharSetUnicode = 4;
	public const PInvokeAttributes CharSetAuto = 6;
	public const PInvokeAttributes BestFitUseAssem = 0;
	public const PInvokeAttributes BestFitEnabled = 16;
	public const PInvokeAttributes BestFitDisabled = 32;
	public const PInvokeAttributes BestFitMask = 48;
	public const PInvokeAttributes ThrowOnUnmappableCharUseAssem = 0;
	public const PInvokeAttributes ThrowOnUnmappableCharEnabled = 4096;
	public const PInvokeAttributes ThrowOnUnmappableCharDisabled = 8192;
	public const PInvokeAttributes ThrowOnUnmappableCharMask = 12288;
	public const PInvokeAttributes SupportsLastError = 64;
	public const PInvokeAttributes CallConvMask = 1792;
	public const PInvokeAttributes CallConvWinapi = 256;
	public const PInvokeAttributes CallConvCdecl = 512;
	public const PInvokeAttributes CallConvStdcall = 768;
	public const PInvokeAttributes CallConvThiscall = 1024;
	public const PInvokeAttributes CallConvFastcall = 1280;
	public const PInvokeAttributes MaxValue = 65535;
}

// Namespace: System.Reflection
[Serializable]
internal class MemberInfoSerializationHolder : ISerializable, IObjectReference // TypeDefIndex: 1246
{
	// Fields
	private string m_memberName; // 0x10
	private RuntimeType m_reflectedType; // 0x18
	private string m_signature; // 0x20
	private string m_signature2; // 0x28
	private MemberTypes m_memberType; // 0x30
	private SerializationInfo m_info; // 0x38

	// Methods

	// RVA: 0x17E34D8 Offset: 0x17DF4D8 VA: 0x17E34D8
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, MemberTypes type) { }

	// RVA: 0x17E34E8 Offset: 0x17DF4E8 VA: 0x17E34E8
	public static void GetSerializationInfo(SerializationInfo info, string name, RuntimeType reflectedClass, string signature, string signature2, MemberTypes type, Type[] genericArguments) { }

	// RVA: 0x17E37E0 Offset: 0x17DF7E0 VA: 0x17E37E0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17E3B38 Offset: 0x17DFB38 VA: 0x17E3B38 Slot: 6
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17E3B90 Offset: 0x17DFB90 VA: 0x17E3B90 Slot: 7
	public virtual object GetRealObject(StreamingContext context) { }
}

// Namespace: 
internal class Assembly.ResolveEventHolder // TypeDefIndex: 1247
{
	// Methods

	// RVA: 0x17E4A30 Offset: 0x17E0A30 VA: 0x17E4A30
	public void .ctor() { }
}

// Namespace: System.Reflection
[ComDefaultInterface(typeof(_Assembly))]
[ComVisible(True)]
[ClassInterface(0)]
[Serializable]
public class Assembly : ICustomAttributeProvider, ISerializable, _Assembly // TypeDefIndex: 1248
{
	// Properties
	public virtual string CodeBase { get; }
	public virtual string FullName { get; }
	internal virtual IntPtr MonoAssembly { get; }
	[MonoTODO]
	public bool IsFullyTrusted { get; }

	// Methods

	// RVA: 0x17E43F4 Offset: 0x17E03F4 VA: 0x17E43F4 Slot: 8
	public virtual string get_CodeBase() { }

	// RVA: 0x17E442C Offset: 0x17E042C VA: 0x17E442C Slot: 9
	public virtual string get_FullName() { }

	// RVA: 0x17E4464 Offset: 0x17E0464 VA: 0x17E4464 Slot: 10
	internal virtual IntPtr get_MonoAssembly() { }

	// RVA: 0x17E449C Offset: 0x17E049C VA: 0x17E449C Slot: 11
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17E44D4 Offset: 0x17E04D4 VA: 0x17E44D4 Slot: 12
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17E450C Offset: 0x17E050C VA: 0x17E450C Slot: 13
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17E4544 Offset: 0x17E0544 VA: 0x17E4544 Slot: 14
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17E457C Offset: 0x17E057C VA: 0x17E457C Slot: 15
	public virtual FileStream GetFile(string name) { }

	// RVA: 0x17E45B4 Offset: 0x17E05B4 VA: 0x17E45B4 Slot: 16
	internal virtual Type[] GetTypes(bool exportedOnly) { }

	// RVA: 0x17E45B8 Offset: 0x17E05B8 VA: 0x17E45B8 Slot: 17
	public virtual Type[] GetTypes() { }

	// RVA: 0x17E45CC Offset: 0x17E05CC VA: 0x17E45CC Slot: 18
	public virtual Type GetType(string name) { }

	// RVA: 0x17E45E4 Offset: 0x17E05E4 VA: 0x17E45E4
	internal Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x17E45E8 Offset: 0x17E05E8 VA: 0x17E45E8
	internal static void InternalGetAssemblyName(string assemblyFile, out MonoAssemblyName aname, out string codebase) { }

	// RVA: 0x17E45EC Offset: 0x17E05EC VA: 0x17E45EC Slot: 19
	public virtual AssemblyName GetName(bool copiedName) { }

	// RVA: 0x17E4624 Offset: 0x17E0624 VA: 0x17E4624 Slot: 20
	public virtual AssemblyName GetName() { }

	// RVA: 0x17E4638 Offset: 0x17E0638 VA: 0x17E4638 Slot: 3
	public override string ToString() { }

	// RVA: 0x17E4640 Offset: 0x17E0640 VA: 0x17E4640
	public static Assembly GetAssembly(Type type) { }

	// RVA: 0x17E46E0 Offset: 0x17E06E0 VA: 0x17E46E0
	private static Assembly LoadFrom(string assemblyFile, bool refOnly, ref StackCrawlMark stackMark) { }

	[Obsolete]
	// RVA: 0x17E46E4 Offset: 0x17E06E4 VA: 0x17E46E4
	public static Assembly LoadFrom(string assemblyFile, Evidence securityEvidence) { }

	// RVA: 0x17E4704 Offset: 0x17E0704 VA: 0x17E4704
	public static Assembly Load(string assemblyString) { }

	// RVA: 0x17E472C Offset: 0x17E072C VA: 0x17E472C
	public static Assembly Load(AssemblyName assemblyRef) { }

	// RVA: 0x17E4754 Offset: 0x17E0754 VA: 0x17E4754
	public static Assembly ReflectionOnlyLoad(string assemblyString) { }

	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x17E479C Offset: 0x17E079C VA: 0x17E479C
	public static Assembly LoadWithPartialName(string partialName) { }

	// RVA: 0x17E47B0 Offset: 0x17E07B0 VA: 0x17E47B0
	private static Assembly load_with_partial_name(string name, Evidence e) { }

	[Obsolete("This method has been deprecated. Please use Assembly.Load() instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x17E47A8 Offset: 0x17E07A8 VA: 0x17E47A8
	public static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence) { }

	// RVA: 0x17E47B4 Offset: 0x17E07B4 VA: 0x17E47B4
	internal static Assembly LoadWithPartialName(string partialName, Evidence securityEvidence, bool oldBehavior) { }

	// RVA: 0x17E481C Offset: 0x17E081C VA: 0x17E481C Slot: 21
	internal virtual Module[] GetModulesInternal() { }

	// RVA: 0x17E4854 Offset: 0x17E0854 VA: 0x17E4854
	public static Assembly GetExecutingAssembly() { }

	// RVA: 0x17E4894 Offset: 0x17E0894 VA: 0x17E4894
	public static Assembly GetCallingAssembly() { }

	// RVA: 0x17E4898 Offset: 0x17E0898 VA: 0x17E4898 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17E48A0 Offset: 0x17E08A0 VA: 0x17E48A0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x17E48A8 Offset: 0x17E08A8 VA: 0x17E48A8
	private static Exception CreateNIE() { }

	// RVA: 0x17E4914 Offset: 0x17E0914 VA: 0x17E4914
	public bool get_IsFullyTrusted() { }

	// RVA: 0x17E491C Offset: 0x17E091C VA: 0x17E491C Slot: 22
	public virtual Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x17E4940 Offset: 0x17E0940 VA: 0x17E4940 Slot: 23
	public virtual Module GetModule(string name) { }

	// RVA: 0x17E4964 Offset: 0x17E0964 VA: 0x17E4964 Slot: 24
	public virtual Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x17E4988 Offset: 0x17E0988 VA: 0x17E4988
	public static bool op_Equality(Assembly left, Assembly right) { }

	// RVA: 0x17E49D0 Offset: 0x17E09D0 VA: 0x17E49D0
	public static bool op_Inequality(Assembly left, Assembly right) { }

	// RVA: 0x17E4A28 Offset: 0x17E0A28 VA: 0x17E4A28
	public void .ctor() { }
}

// Namespace: System.Reflection
[ClassInterface(0)]
[ComDefaultInterface(typeof(_AssemblyName))]
[ComVisible(True)]
[Serializable]
public sealed class AssemblyName : ICloneable, ISerializable, IDeserializationCallback, _AssemblyName // TypeDefIndex: 1249
{
	// Fields
	private string name; // 0x10
	private string codebase; // 0x18
	private int major; // 0x20
	private int minor; // 0x24
	private int build; // 0x28
	private int revision; // 0x2C
	private CultureInfo cultureinfo; // 0x30
	private AssemblyNameFlags flags; // 0x38
	private AssemblyHashAlgorithm hashalg; // 0x3C
	private StrongNameKeyPair keypair; // 0x40
	private byte[] publicKey; // 0x48
	private byte[] keyToken; // 0x50
	private AssemblyVersionCompatibility versioncompat; // 0x58
	private Version version; // 0x60
	private ProcessorArchitecture processor_architecture; // 0x68
	private AssemblyContentType contentType; // 0x6C

	// Properties
	public string Name { get; set; }
	public string CodeBase { get; }
	public CultureInfo CultureInfo { get; }
	public AssemblyNameFlags Flags { get; }
	public string FullName { get; }
	public Version Version { get; set; }
	private bool IsPublicKeyValid { get; }

	// Methods

	// RVA: 0x17E4A38 Offset: 0x17E0A38 VA: 0x17E4A38
	public void .ctor() { }

	// RVA: 0x17E4A58 Offset: 0x17E0A58 VA: 0x17E4A58
	private static bool ParseAssemblyName(IntPtr name, out MonoAssemblyName aname, out bool is_version_definited, out bool is_token_defined) { }

	// RVA: 0x17E4A5C Offset: 0x17E0A5C VA: 0x17E4A5C
	public void .ctor(string assemblyName) { }

	// RVA: 0x17E4FE4 Offset: 0x17E0FE4 VA: 0x17E4FE4
	internal void .ctor(SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x17E557C Offset: 0x17E157C VA: 0x17E557C
	public string get_Name() { }

	// RVA: 0x17E5584 Offset: 0x17E1584 VA: 0x17E5584
	public void set_Name(string value) { }

	// RVA: 0x17E558C Offset: 0x17E158C VA: 0x17E558C
	public string get_CodeBase() { }

	// RVA: 0x17E5594 Offset: 0x17E1594 VA: 0x17E5594
	public CultureInfo get_CultureInfo() { }

	// RVA: 0x17E559C Offset: 0x17E159C VA: 0x17E559C
	public AssemblyNameFlags get_Flags() { }

	// RVA: 0x17E55A4 Offset: 0x17E15A4 VA: 0x17E55A4
	public string get_FullName() { }

	// RVA: 0x17E59E4 Offset: 0x17E19E4 VA: 0x17E59E4
	public Version get_Version() { }

	// RVA: 0x17E59EC Offset: 0x17E19EC VA: 0x17E59EC
	public void set_Version(Version value) { }

	// RVA: 0x17E5A3C Offset: 0x17E1A3C VA: 0x17E5A3C Slot: 3
	public override string ToString() { }

	// RVA: 0x17E5A64 Offset: 0x17E1A64 VA: 0x17E5A64
	public byte[] GetPublicKeyToken() { }

	// RVA: 0x17E5B54 Offset: 0x17E1B54 VA: 0x17E5B54
	private bool get_IsPublicKeyValid() { }

	// RVA: 0x17E5900 Offset: 0x17E1900 VA: 0x17E5900
	private byte[] InternalGetPublicKeyToken() { }

	// RVA: 0x17E5C60 Offset: 0x17E1C60 VA: 0x17E5C60
	private static void get_public_token(byte* token, byte* pubkey, int len) { }

	// RVA: 0x17E5BD8 Offset: 0x17E1BD8 VA: 0x17E5BD8
	private byte[] ComputePublicKeyToken() { }

	// RVA: 0x17E5C64 Offset: 0x17E1C64 VA: 0x17E5C64 Slot: 5
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17E5F90 Offset: 0x17E1F90 VA: 0x17E5F90 Slot: 4
	public object Clone() { }

	// RVA: 0x17E6080 Offset: 0x17E2080 VA: 0x17E6080 Slot: 6
	public void OnDeserialization(object sender) { }

	// RVA: 0x17E6088 Offset: 0x17E2088 VA: 0x17E6088
	public static AssemblyName GetAssemblyName(string assemblyFile) { }

	// RVA: 0x17E6270 Offset: 0x17E2270 VA: 0x17E6270
	private static MonoAssemblyName* GetNativeName(IntPtr assembly_ptr) { }

	// RVA: 0x17E4D10 Offset: 0x17E0D10 VA: 0x17E4D10
	internal void FillName(MonoAssemblyName* native, string codeBase, bool addVersion, bool addPublickey, bool defaultToken, bool assemblyRef) { }

	// RVA: 0x17E6274 Offset: 0x17E2274 VA: 0x17E6274
	internal static AssemblyName Create(Assembly assembly, bool fillCodebase) { }
}

// Namespace: 
private class CustomAttributeData.LazyCAttrData // TypeDefIndex: 1250
{
	// Fields
	internal Assembly assembly; // 0x10
	internal IntPtr data; // 0x18
	internal uint data_length; // 0x20

	// Methods

	// RVA: 0x17E640C Offset: 0x17E240C VA: 0x17E640C
	public void .ctor() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
[Serializable]
public class CustomAttributeData // TypeDefIndex: 1251
{
	// Fields
	private ConstructorInfo ctorInfo; // 0x10
	private IList<CustomAttributeTypedArgument> ctorArgs; // 0x18
	private IList<CustomAttributeNamedArgument> namedArgs; // 0x20
	private CustomAttributeData.LazyCAttrData lazyData; // 0x28

	// Properties
	[ComVisible(True)]
	public virtual ConstructorInfo Constructor { get; }
	[ComVisible(True)]
	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments { get; }
	public virtual IList<CustomAttributeNamedArgument> NamedArguments { get; }
	public Type AttributeType { get; }

	// Methods

	// RVA: 0x17E633C Offset: 0x17E233C VA: 0x17E633C
	protected void .ctor() { }

	// RVA: 0x17E6344 Offset: 0x17E2344 VA: 0x17E6344
	internal void .ctor(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	// RVA: 0x17E6414 Offset: 0x17E2414 VA: 0x17E6414
	internal void .ctor(ConstructorInfo ctorInfo) { }

	// RVA: 0x17E6530 Offset: 0x17E2530 VA: 0x17E6530
	internal void .ctor(ConstructorInfo ctorInfo, IList<CustomAttributeTypedArgument> ctorArgs, IList<CustomAttributeNamedArgument> namedArgs) { }

	// RVA: 0x17E6590 Offset: 0x17E2590 VA: 0x17E6590
	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs) { }

	// RVA: 0x17E6594 Offset: 0x17E2594 VA: 0x17E6594
	private void ResolveArguments() { }

	// RVA: 0x17E6788 Offset: 0x17E2788 VA: 0x17E6788 Slot: 4
	public virtual ConstructorInfo get_Constructor() { }

	// RVA: 0x17E6790 Offset: 0x17E2790 VA: 0x17E6790 Slot: 5
	public virtual IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	// RVA: 0x17E67A8 Offset: 0x17E27A8 VA: 0x17E67A8 Slot: 6
	public virtual IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	// RVA: 0x17E67C0 Offset: 0x17E27C0 VA: 0x17E67C0
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	// RVA: 0x17E681C Offset: 0x17E281C VA: 0x17E681C
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	// RVA: 0x17E6878 Offset: 0x17E2878 VA: 0x17E6878
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	// RVA: 0x17E68D4 Offset: 0x17E28D4 VA: 0x17E68D4
	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	// RVA: 0x17E6930 Offset: 0x17E2930 VA: 0x17E6930
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	// RVA: 0x17E698C Offset: 0x17E298C VA: 0x17E698C
	public Type get_AttributeType() { }

	// RVA: 0x17E69A8 Offset: 0x17E29A8 VA: 0x17E69A8 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static T[] UnboxValues<T>(object[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F41A8 Offset: 0x10F01A8 VA: 0x10F41A8
	|-CustomAttributeData.UnboxValues<CustomAttributeNamedArgument>
	|
	|-RVA: 0x10F42C0 Offset: 0x10F02C0 VA: 0x10F42C0
	|-CustomAttributeData.UnboxValues<CustomAttributeTypedArgument>
	|
	|-RVA: 0x10F43D8 Offset: 0x10F03D8 VA: 0x10F43D8
	|-CustomAttributeData.UnboxValues<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17E6F34 Offset: 0x17E2F34 VA: 0x17E6F34 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17E75B8 Offset: 0x17E35B8 VA: 0x17E75B8 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
public class ExceptionHandlingClause // TypeDefIndex: 1252
{
	// Fields
	internal Type catch_type; // 0x10
	internal int filter_offset; // 0x18
	internal ExceptionHandlingClauseOptions flags; // 0x1C
	internal int try_offset; // 0x20
	internal int try_length; // 0x24
	internal int handler_offset; // 0x28
	internal int handler_length; // 0x2C

	// Methods

	// RVA: 0x17E78C4 Offset: 0x17E38C4 VA: 0x17E78C4
	protected void .ctor() { }

	// RVA: 0x17E78CC Offset: 0x17E38CC VA: 0x17E78CC Slot: 3
	public override string ToString() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
public class LocalVariableInfo // TypeDefIndex: 1253
{
	// Fields
	internal Type type; // 0x10
	internal bool is_pinned; // 0x18
	internal ushort position; // 0x1A

	// Methods

	// RVA: 0x17E7BAC Offset: 0x17E3BAC VA: 0x17E7BAC
	protected void .ctor() { }

	// RVA: 0x17E7BB4 Offset: 0x17E3BB4 VA: 0x17E7BB4 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Reflection
[ComDefaultInterface(typeof(_Assembly))]
[ClassInterface(0)]
[ComVisible(True)]
[Serializable]
internal class RuntimeAssembly : Assembly // TypeDefIndex: 1254
{
	// Fields
	internal IntPtr _mono_assembly; // 0x10
	private object _evidence; // 0x18
	internal Assembly.ResolveEventHolder resolve_event_holder; // 0x20
	private object _minimum; // 0x28
	private object _optional; // 0x30
	private object _refuse; // 0x38
	private object _granted; // 0x40
	private object _denied; // 0x48
	internal bool fromByteArray; // 0x50
	internal string assemblyName; // 0x58

	// Properties
	public override string CodeBase { get; }
	public override string FullName { get; }
	internal override IntPtr MonoAssembly { get; }

	// Methods

	// RVA: 0x17E7C68 Offset: 0x17E3C68 VA: 0x17E7C68
	protected void .ctor() { }

	// RVA: 0x17E7CD4 Offset: 0x17E3CD4 VA: 0x17E7CD4 Slot: 11
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17E7D5C Offset: 0x17E3D5C VA: 0x17E7D5C
	internal static RuntimeAssembly LoadWithPartialNameInternal(string partialName, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	// RVA: 0x17E7DE4 Offset: 0x17E3DE4 VA: 0x17E7DE4
	internal static RuntimeAssembly LoadWithPartialNameInternal(AssemblyName an, Evidence securityEvidence, ref StackCrawlMark stackMark) { }

	// RVA: 0x17E7E0C Offset: 0x17E3E0C VA: 0x17E7E0C Slot: 19
	public override AssemblyName GetName(bool copiedName) { }

	// RVA: 0x17E7E14 Offset: 0x17E3E14 VA: 0x17E7E14 Slot: 22
	public override Type GetType(string name, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x17E7ECC Offset: 0x17E3ECC VA: 0x17E7ECC Slot: 23
	public override Module GetModule(string name) { }

	// RVA: 0x17E7FF4 Offset: 0x17E3FF4 VA: 0x17E7FF4 Slot: 24
	public override Module[] GetModules(bool getResourceModules) { }

	// RVA: 0x17E8190 Offset: 0x17E4190 VA: 0x17E8190
	internal static byte[] GetAotId() { }

	// RVA: 0x17E81EC Offset: 0x17E41EC VA: 0x17E81EC
	private static string get_code_base(Assembly a, bool escaped) { }

	// RVA: 0x17E81F0 Offset: 0x17E41F0 VA: 0x17E81F0
	internal static string get_fullname(Assembly a) { }

	// RVA: 0x17E81E8 Offset: 0x17E41E8 VA: 0x17E81E8
	internal static bool GetAotIdInternal(byte[] aotid) { }

	// RVA: 0x17E81F4 Offset: 0x17E41F4 VA: 0x17E81F4
	internal static string GetCodeBase(Assembly a, bool escaped) { }

	// RVA: 0x17E81F8 Offset: 0x17E41F8 VA: 0x17E81F8 Slot: 8
	public override string get_CodeBase() { }

	// RVA: 0x17E8200 Offset: 0x17E4200 VA: 0x17E8200 Slot: 9
	public override string get_FullName() { }

	// RVA: 0x17E8204 Offset: 0x17E4204 VA: 0x17E8204 Slot: 10
	internal override IntPtr get_MonoAssembly() { }

	// RVA: 0x17E820C Offset: 0x17E420C VA: 0x17E820C
	internal IntPtr GetManifestResourceInternal(string name, out int size, out Module module) { }

	// RVA: 0x17E8210 Offset: 0x17E4210 VA: 0x17E8210 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17E8280 Offset: 0x17E4280 VA: 0x17E8280 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17E82E8 Offset: 0x17E42E8 VA: 0x17E82E8 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17E8358 Offset: 0x17E4358 VA: 0x17E8358 Slot: 21
	internal override Module[] GetModulesInternal() { }

	// RVA: 0x17E835C Offset: 0x17E435C VA: 0x17E835C
	private object GetFilesInternal(string name, bool getResourceModules) { }

	// RVA: 0x17E8360 Offset: 0x17E4360 VA: 0x17E8360 Slot: 15
	public override FileStream GetFile(string name) { }

	// RVA: 0x17E8494 Offset: 0x17E4494 VA: 0x17E8494 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17E849C Offset: 0x17E449C VA: 0x17E849C Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x17E8538 Offset: 0x17E4538 VA: 0x17E8538 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Reflection
internal struct MonoEventInfo // TypeDefIndex: 1255
{
	// Fields
	public Type declaring_type; // 0x0
	public Type reflected_type; // 0x8
	public string name; // 0x10
	public MethodInfo add_method; // 0x18
	public MethodInfo remove_method; // 0x20
	public MethodInfo raise_method; // 0x28
	public EventAttributes attrs; // 0x30
	public MethodInfo[] other_methods; // 0x38
}

// Namespace: System.Reflection
[Serializable]
internal sealed class RuntimeEventInfo : EventInfo, ISerializable // TypeDefIndex: 1256
{
	// Fields
	private IntPtr klass; // 0x18
	private IntPtr handle; // 0x20

	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override string Name { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x17E8580 Offset: 0x17E4580 VA: 0x17E8580
	private static void get_event_info(RuntimeEventInfo ev, out MonoEventInfo info) { }

	// RVA: 0x17E8584 Offset: 0x17E4584 VA: 0x17E8584
	internal static MonoEventInfo GetEventInfo(RuntimeEventInfo ev) { }

	// RVA: 0x17E85C0 Offset: 0x17E45C0 VA: 0x17E85C0 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x17E85E0 Offset: 0x17E45E0 VA: 0x17E85E0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x17E875C Offset: 0x17E475C VA: 0x17E875C
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x17E87E0 Offset: 0x17E47E0 VA: 0x17E87E0
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x17E85C4 Offset: 0x17E45C4 VA: 0x17E85C4
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x17E8864 Offset: 0x17E4864 VA: 0x17E8864 Slot: 20
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17E85E4 Offset: 0x17E45E4 VA: 0x17E85E4
	internal BindingFlags GetBindingFlags() { }

	// RVA: 0x17E88FC Offset: 0x17E48FC VA: 0x17E88FC Slot: 16
	public override MethodInfo GetAddMethod(bool nonPublic) { }

	// RVA: 0x17E896C Offset: 0x17E496C VA: 0x17E896C Slot: 18
	public override MethodInfo GetRaiseMethod(bool nonPublic) { }

	// RVA: 0x17E89DC Offset: 0x17E49DC VA: 0x17E89DC Slot: 17
	public override MethodInfo GetRemoveMethod(bool nonPublic) { }

	// RVA: 0x17E8A4C Offset: 0x17E4A4C VA: 0x17E8A4C Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x17E8A78 Offset: 0x17E4A78 VA: 0x17E8A78 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x17E8AA4 Offset: 0x17E4AA4 VA: 0x17E8AA4 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17E8AD0 Offset: 0x17E4AD0 VA: 0x17E8AD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x17E8B60 Offset: 0x17E4B60 VA: 0x17E8B60 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17E8BD0 Offset: 0x17E4BD0 VA: 0x17E8BD0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17E8C38 Offset: 0x17E4C38 VA: 0x17E8C38 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17E8CA8 Offset: 0x17E4CA8 VA: 0x17E8CA8 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x17E8CAC Offset: 0x17E4CAC VA: 0x17E8CAC
	internal static int get_metadata_token(RuntimeEventInfo monoEvent) { }

	// RVA: 0x17E8CB0 Offset: 0x17E4CB0 VA: 0x17E8CB0
	public void .ctor() { }
}

// Namespace: System.Reflection
internal abstract class RtFieldInfo : FieldInfo // TypeDefIndex: 1257
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 31
	internal abstract object UnsafeGetValue(object obj);

	// RVA: -1 Offset: -1 Slot: 32
	internal abstract void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 33
	internal abstract void CheckConsistency(object target);

	// RVA: 0x17E8CB8 Offset: 0x17E4CB8 VA: 0x17E8CB8
	protected void .ctor() { }
}

// Namespace: System.Reflection
[Serializable]
internal class RuntimeFieldInfo : RtFieldInfo, ISerializable // TypeDefIndex: 1258
{
	// Fields
	internal IntPtr klass; // 0x10
	internal RuntimeFieldHandle fhandle; // 0x18
	private string name; // 0x20
	private Type type; // 0x28
	private FieldAttributes attrs; // 0x30

	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override FieldAttributes Attributes { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type FieldType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x17E8CC0 Offset: 0x17E4CC0 VA: 0x17E8CC0
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x17E8CC8 Offset: 0x17E4CC8 VA: 0x17E8CC8 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x17E8CE8 Offset: 0x17E4CE8 VA: 0x17E8CE8
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x17E8D6C Offset: 0x17E4D6C VA: 0x17E8D6C
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x17E8CCC Offset: 0x17E4CCC VA: 0x17E8CCC
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x17E8DF0 Offset: 0x17E4DF0 VA: 0x17E8DF0 Slot: 34
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17E8EA4 Offset: 0x17E4EA4 VA: 0x17E8EA4 Slot: 31
	internal override object UnsafeGetValue(object obj) { }

	// RVA: 0x17E8EA8 Offset: 0x17E4EA8 VA: 0x17E8EA8 Slot: 33
	internal override void CheckConsistency(object target) { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x17E901C Offset: 0x17E501C VA: 0x17E901C Slot: 32
	internal override void UnsafeSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x17E907C Offset: 0x17E507C VA: 0x17E907C Slot: 28
	public override void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x17E91D8 Offset: 0x17E51D8 VA: 0x17E91D8 Slot: 16
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x17E91E0 Offset: 0x17E51E0 VA: 0x17E91E0 Slot: 24
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x17E91E8 Offset: 0x17E51E8 VA: 0x17E91E8
	private Type ResolveType() { }

	// RVA: 0x17E91EC Offset: 0x17E51EC VA: 0x17E91EC Slot: 17
	public override Type get_FieldType() { }

	// RVA: 0x17E9254 Offset: 0x17E5254 VA: 0x17E9254
	private Type GetParentType(bool declaring) { }

	// RVA: 0x17E9258 Offset: 0x17E5258 VA: 0x17E9258 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x17E9260 Offset: 0x17E5260 VA: 0x17E9260 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x17E9268 Offset: 0x17E5268 VA: 0x17E9268 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17E9270 Offset: 0x17E5270 VA: 0x17E9270 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17E92E0 Offset: 0x17E52E0 VA: 0x17E92E0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17E9348 Offset: 0x17E5348 VA: 0x17E9348 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17E93B8 Offset: 0x17E53B8 VA: 0x17E93B8 Slot: 30
	internal override int GetFieldOffset() { }

	// RVA: 0x17E93BC Offset: 0x17E53BC VA: 0x17E93BC
	private object GetValueInternal(object obj) { }

	// RVA: 0x17E93C0 Offset: 0x17E53C0 VA: 0x17E93C0 Slot: 25
	public override object GetValue(object obj) { }

	// RVA: 0x17E95C4 Offset: 0x17E55C4 VA: 0x17E95C4 Slot: 3
	public override string ToString() { }

	// RVA: 0x17E962C Offset: 0x17E562C VA: 0x17E962C
	private static void SetValueInternal(FieldInfo fi, object obj, object value) { }

	// RVA: 0x17E9630 Offset: 0x17E5630 VA: 0x17E9630 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x17E98D0 Offset: 0x17E58D0 VA: 0x17E98D0 Slot: 29
	public override object GetRawConstantValue() { }

	// RVA: 0x17E9548 Offset: 0x17E5548 VA: 0x17E9548
	private void CheckGeneric() { }

	// RVA: 0x17E98D4 Offset: 0x17E58D4 VA: 0x17E98D4 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x17E98D8 Offset: 0x17E58D8 VA: 0x17E98D8
	internal static int get_metadata_token(RuntimeFieldInfo monoField) { }

	// RVA: 0x17E98DC Offset: 0x17E58DC VA: 0x17E98DC
	public void .ctor() { }
}

// Namespace: System.Reflection
internal struct MonoMethodInfo // TypeDefIndex: 1259
{
	// Fields
	private Type parent; // 0x0
	private Type ret; // 0x8
	internal MethodAttributes attrs; // 0x10
	internal MethodImplAttributes iattrs; // 0x14
	private CallingConventions callconv; // 0x18

	// Methods

	// RVA: 0x17E98E4 Offset: 0x17E58E4 VA: 0x17E98E4
	private static void get_method_info(IntPtr handle, out MonoMethodInfo info) { }

	// RVA: 0x17E98E8 Offset: 0x17E58E8 VA: 0x17E98E8
	private static int get_method_attributes(IntPtr handle) { }

	// RVA: 0x17E98EC Offset: 0x17E58EC VA: 0x17E98EC
	internal static MonoMethodInfo GetMethodInfo(IntPtr handle) { }

	// RVA: 0x17E991C Offset: 0x17E591C VA: 0x17E991C
	internal static Type GetDeclaringType(IntPtr handle) { }

	// RVA: 0x17E9944 Offset: 0x17E5944 VA: 0x17E9944
	internal static Type GetReturnType(IntPtr handle) { }

	// RVA: 0x17E996C Offset: 0x17E596C VA: 0x17E996C
	internal static MethodAttributes GetAttributes(IntPtr handle) { }

	// RVA: 0x17E9970 Offset: 0x17E5970 VA: 0x17E9970
	internal static CallingConventions GetCallingConvention(IntPtr handle) { }

	// RVA: 0x17E9998 Offset: 0x17E5998 VA: 0x17E9998
	internal static MethodImplAttributes GetMethodImplementationFlags(IntPtr handle) { }

	// RVA: 0x17E99C0 Offset: 0x17E59C0 VA: 0x17E99C0
	private static ParameterInfo[] get_parameter_info(IntPtr handle, MemberInfo member) { }

	// RVA: 0x17E99C4 Offset: 0x17E59C4 VA: 0x17E99C4
	internal static ParameterInfo[] GetParametersInfo(IntPtr handle, MemberInfo member) { }

	// RVA: 0x17E99C8 Offset: 0x17E59C8 VA: 0x17E99C8
	private static MarshalAsAttribute get_retval_marshal(IntPtr handle) { }

	// RVA: 0x17E99CC Offset: 0x17E59CC VA: 0x17E99CC
	internal static ParameterInfo GetReturnParameterInfo(RuntimeMethodInfo method) { }
}

// Namespace: System.Reflection
[Serializable]
internal class RuntimeMethodInfo : MethodInfo, ISerializable // TypeDefIndex: 1260
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override ParameterInfo ReturnParameter { get; }
	public override Type ReturnType { get; }
	public override int MetadataToken { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsGenericMethodDefinition { get; }
	public override bool IsGenericMethod { get; }
	public override bool ContainsGenericParameters { get; }
	public override bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x17E9A94 Offset: 0x17E5A94 VA: 0x17E9A94
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x17E9A9C Offset: 0x17E5A9C VA: 0x17E9A9C Slot: 11
	public override Module get_Module() { }

	// RVA: 0x17E9B2C Offset: 0x17E5B2C VA: 0x17E9B2C
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x17E9BB0 Offset: 0x17E5BB0 VA: 0x17E9BB0 Slot: 36
	internal override string FormatNameAndSig(bool serialization) { }

	// RVA: 0x17E9F04 Offset: 0x17E5F04 VA: 0x17E9F04 Slot: 44
	public override Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x17E9F18 Offset: 0x17E5F18 VA: 0x17E9F18 Slot: 45
	public override Delegate CreateDelegate(Type delegateType, object target) { }

	// RVA: 0x17E9F30 Offset: 0x17E5F30 VA: 0x17E9F30 Slot: 3
	public override string ToString() { }

	// RVA: 0x17E9AA0 Offset: 0x17E5AA0 VA: 0x17E9AA0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x17E9FC0 Offset: 0x17E5FC0 VA: 0x17E9FC0 Slot: 47
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17EA0E0 Offset: 0x17E60E0 VA: 0x17EA0E0
	internal string SerializationToString() { }

	// RVA: 0x17EA17C Offset: 0x17E617C VA: 0x17EA17C
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle) { }

	// RVA: 0x17EA18C Offset: 0x17E618C VA: 0x17EA18C
	internal static MethodBase GetMethodFromHandleNoGenericCheck(RuntimeMethodHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x17EA194 Offset: 0x17E6194 VA: 0x17EA194
	internal static MethodBase GetMethodFromHandleInternalType(IntPtr method_handle, IntPtr type_handle) { }

	// RVA: 0x17EA188 Offset: 0x17E6188 VA: 0x17EA188
	private static MethodBase GetMethodFromHandleInternalType_native(IntPtr method_handle, IntPtr type_handle, bool genericCheck) { }

	// RVA: 0x17EA19C Offset: 0x17E619C VA: 0x17EA19C
	internal void .ctor() { }

	// RVA: 0x17EA1A4 Offset: 0x17E61A4 VA: 0x17EA1A4
	internal static string get_name(MethodBase method) { }

	// RVA: 0x17EA1A8 Offset: 0x17E61A8 VA: 0x17EA1A8
	internal static RuntimeMethodInfo get_base_method(RuntimeMethodInfo method, bool definition) { }

	// RVA: 0x17EA1AC Offset: 0x17E61AC VA: 0x17EA1AC
	internal static int get_metadata_token(RuntimeMethodInfo method) { }

	// RVA: 0x17EA1B0 Offset: 0x17E61B0 VA: 0x17EA1B0 Slot: 43
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x17EA1B8 Offset: 0x17E61B8 VA: 0x17EA1B8
	internal MethodInfo GetBaseMethod() { }

	// RVA: 0x17EA1C0 Offset: 0x17E61C0 VA: 0x17EA1C0 Slot: 39
	public override ParameterInfo get_ReturnParameter() { }

	// RVA: 0x17EA1C4 Offset: 0x17E61C4 VA: 0x17EA1C4 Slot: 40
	public override Type get_ReturnType() { }

	// RVA: 0x17EA1F0 Offset: 0x17E61F0 VA: 0x17EA1F0 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x17EA1F4 Offset: 0x17E61F4 VA: 0x17EA1F4 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x17EA220 Offset: 0x17E6220 VA: 0x17EA220 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x17EA2B0 Offset: 0x17E62B0 VA: 0x17EA2B0 Slot: 34
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x17EA2BC Offset: 0x17E62BC VA: 0x17EA2BC Slot: 35
	internal override int GetParametersCount() { }

	// RVA: 0x17EA2E0 Offset: 0x17E62E0 VA: 0x17EA2E0
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x17EA2E4 Offset: 0x17E62E4 VA: 0x17EA2E4 Slot: 31
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x17EA5D4 Offset: 0x17E65D4 VA: 0x17EA5D4
	internal static void ConvertValues(Binder binder, object[] args, ParameterInfo[] pinfo, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x17EA8A4 Offset: 0x17E68A4 VA: 0x17EA8A4 Slot: 32
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x17EA8AC Offset: 0x17E68AC VA: 0x17EA8AC Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x17EA8B4 Offset: 0x17E68B4 VA: 0x17EA8B4 Slot: 19
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x17EA8E0 Offset: 0x17E68E0 VA: 0x17EA8E0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x17EA8E8 Offset: 0x17E68E8 VA: 0x17EA8E8 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x17EA914 Offset: 0x17E6914 VA: 0x17EA914 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17EA928 Offset: 0x17E6928 VA: 0x17EA928 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EA998 Offset: 0x17E6998 VA: 0x17EA998 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EAA00 Offset: 0x17E6A00 VA: 0x17EAA00 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EAA70 Offset: 0x17E6A70 VA: 0x17EAA70
	internal void GetPInvoke(out PInvokeAttributes flags, out string entryPoint, out string dllName) { }

	// RVA: 0x17EAA74 Offset: 0x17E6A74 VA: 0x17EAA74
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x17EABF4 Offset: 0x17E6BF4 VA: 0x17EABF4
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	// RVA: 0x17EADC8 Offset: 0x17E6DC8 VA: 0x17EADC8
	private CustomAttributeData GetDllImportAttributeData() { }

	// RVA: 0x17EB4C0 Offset: 0x17E74C0 VA: 0x17EB4C0 Slot: 42
	public override MethodInfo MakeGenericMethod(Type[] methodInstantiation) { }

	// RVA: 0x17EB7EC Offset: 0x17E77EC VA: 0x17EB7EC
	private MethodInfo MakeGenericMethod_impl(Type[] types) { }

	// RVA: 0x17EB7F0 Offset: 0x17E77F0 VA: 0x17EB7F0 Slot: 28
	public override Type[] GetGenericArguments() { }

	// RVA: 0x17EB7F4 Offset: 0x17E77F4 VA: 0x17EB7F4
	private MethodInfo GetGenericMethodDefinition_impl() { }

	// RVA: 0x17EB7F8 Offset: 0x17E77F8 VA: 0x17EB7F8 Slot: 41
	public override MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x17EB854 Offset: 0x17E7854 VA: 0x17EB854 Slot: 27
	public override bool get_IsGenericMethodDefinition() { }

	// RVA: 0x17EB858 Offset: 0x17E7858 VA: 0x17EB858 Slot: 26
	public override bool get_IsGenericMethod() { }

	// RVA: 0x17EB85C Offset: 0x17E785C VA: 0x17EB85C Slot: 29
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x17EB930 Offset: 0x17E7930 VA: 0x17EB930
	private static int get_core_clr_security_level() { }

	// RVA: 0x17EB938 Offset: 0x17E7938 VA: 0x17EB938 Slot: 33
	public override bool get_IsSecurityCritical() { }
}

// Namespace: System.Reflection
[Serializable]
internal class RuntimeConstructorInfo : ConstructorInfo, ISerializable // TypeDefIndex: 1261
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x17EB940 Offset: 0x17E7940 VA: 0x17EB940 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x17EB944 Offset: 0x17E7944 VA: 0x17EB944
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x17EB9CC Offset: 0x17E79CC VA: 0x17EB9CC
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x17EB9D4 Offset: 0x17E79D4 VA: 0x17EB9D4
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x17EBA58 Offset: 0x17E7A58 VA: 0x17EBA58 Slot: 40
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17EBB30 Offset: 0x17E7B30 VA: 0x17EBB30
	internal string SerializationToString() { }

	// RVA: 0x17EBB44 Offset: 0x17E7B44 VA: 0x17EBB44
	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17EBC74 Offset: 0x17E7C74 VA: 0x17EBC74 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x17EBCA0 Offset: 0x17E7CA0 VA: 0x17EBCA0 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x17EBCAC Offset: 0x17E7CAC VA: 0x17EBCAC Slot: 34
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x17EBCB8 Offset: 0x17E7CB8 VA: 0x17EBCB8 Slot: 35
	internal override int GetParametersCount() { }

	// RVA: 0x17EBCD8 Offset: 0x17E7CD8 VA: 0x17EBCD8
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x17EBCDC Offset: 0x17E7CDC VA: 0x17EBCDC Slot: 31
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x17EBDD8 Offset: 0x17E7DD8 VA: 0x17EBDD8
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x17EBF90 Offset: 0x17E7F90 VA: 0x17EBF90
	public object InternalInvoke(object obj, object[] parameters, bool wrapExceptions) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x17EC124 Offset: 0x17E8124 VA: 0x17EC124 Slot: 39
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x17EC13C Offset: 0x17E813C VA: 0x17EC13C Slot: 32
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x17EC144 Offset: 0x17E8144 VA: 0x17EC144 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x17EC14C Offset: 0x17E814C VA: 0x17EC14C Slot: 19
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x17EC178 Offset: 0x17E8178 VA: 0x17EC178 Slot: 29
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x17EC1A4 Offset: 0x17E81A4 VA: 0x17EC1A4 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x17EC1AC Offset: 0x17E81AC VA: 0x17EC1AC Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x17EC1D8 Offset: 0x17E81D8 VA: 0x17EC1D8 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17EC1EC Offset: 0x17E81EC VA: 0x17EC1EC Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EC25C Offset: 0x17E825C VA: 0x17EC25C Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EC2C4 Offset: 0x17E82C4 VA: 0x17EC2C4 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EC334 Offset: 0x17E8334 VA: 0x17EC334 Slot: 3
	public override string ToString() { }

	// RVA: 0x17EC39C Offset: 0x17E839C VA: 0x17EC39C
	private static int get_core_clr_security_level() { }

	// RVA: 0x17EC3A4 Offset: 0x17E83A4 VA: 0x17EC3A4 Slot: 33
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x17EC3AC Offset: 0x17E83AC VA: 0x17EC3AC Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x17EC3B0 Offset: 0x17E83B0 VA: 0x17EC3B0
	internal static int get_metadata_token(RuntimeConstructorInfo method) { }

	// RVA: 0x17EC3B4 Offset: 0x17E83B4 VA: 0x17EC3B4
	public void .ctor() { }
}

// Namespace: System.Reflection
[ClassInterface(0)]
[ComDefaultInterface(typeof(_Module))]
[ComVisible(True)]
[Serializable]
internal class RuntimeModule : Module // TypeDefIndex: 1262
{
	// Fields
	internal IntPtr _impl; // 0x10
	internal Assembly assembly; // 0x18
	internal string fqname; // 0x20
	internal string name; // 0x28
	internal string scopename; // 0x30
	internal bool is_resource; // 0x38
	internal int token; // 0x3C

	// Properties
	public override Assembly Assembly { get; }
	public override string ScopeName { get; }
	public override Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x17EC40C Offset: 0x17E840C VA: 0x17EC40C Slot: 8
	public override Assembly get_Assembly() { }

	// RVA: 0x17EC414 Offset: 0x17E8414 VA: 0x17EC414 Slot: 10
	public override string get_ScopeName() { }

	// RVA: 0x17EC41C Offset: 0x17E841C VA: 0x17EC41C Slot: 9
	public override Guid get_ModuleVersionId() { }

	// RVA: 0x17EC42C Offset: 0x17E842C VA: 0x17EC42C Slot: 11
	public override bool IsResource() { }

	// RVA: 0x17EC434 Offset: 0x17E8434 VA: 0x17EC434 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EC49C Offset: 0x17E849C VA: 0x17EC49C Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EC50C Offset: 0x17E850C VA: 0x17EC50C Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EC57C Offset: 0x17E857C VA: 0x17EC57C Slot: 15
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17EC610 Offset: 0x17E8610 VA: 0x17EC610
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x17EC688 Offset: 0x17E8688 VA: 0x17EC688 Slot: 16
	internal override Guid GetModuleVersionId() { }

	// RVA: 0x17EC708 Offset: 0x17E8708 VA: 0x17EC708
	private static void GetGuidInternal(IntPtr module, byte[] guid) { }

	// RVA: 0x17EC70C Offset: 0x17E870C VA: 0x17EC70C
	public void .ctor() { }
}

// Namespace: System.Reflection
[ClassInterface(0)]
[ComDefaultInterface(typeof(_ParameterInfo))]
[ComVisible(True)]
[Serializable]
internal class RuntimeParameterInfo : ParameterInfo // TypeDefIndex: 1263
{
	// Fields
	internal MarshalAsAttribute marshalAs; // 0x40

	// Properties
	public override object DefaultValue { get; }

	// Methods

	// RVA: 0x17EC764 Offset: 0x17E8764 VA: 0x17EC764
	internal void .ctor(string name, Type type, int position, int attrs, object defaultValue, MemberInfo member, MarshalAsAttribute marshalAs) { }

	// RVA: 0x17E9D10 Offset: 0x17E5D10 VA: 0x17E9D10
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x17EC80C Offset: 0x17E880C VA: 0x17EC80C
	internal void .ctor(ParameterInfo pinfo, MemberInfo member) { }

	// RVA: 0x17EC978 Offset: 0x17E8978 VA: 0x17EC978
	internal void .ctor(Type type, MemberInfo member, MarshalAsAttribute marshalAs) { }

	// RVA: 0x17EC9F8 Offset: 0x17E89F8 VA: 0x17EC9F8 Slot: 13
	public override object get_DefaultValue() { }

	// RVA: 0x17ECD4C Offset: 0x17E8D4C VA: 0x17ECD4C Slot: 15
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17ECDA8 Offset: 0x17E8DA8 VA: 0x17ECDA8 Slot: 16
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EC8C8 Offset: 0x17E88C8 VA: 0x17EC8C8
	internal object GetDefaultValueImpl(ParameterInfo pinfo) { }

	// RVA: 0x17ECE14 Offset: 0x17E8E14 VA: 0x17ECE14 Slot: 14
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17ECE84 Offset: 0x17E8E84 VA: 0x17ECE84
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x17ED0FC Offset: 0x17E90FC VA: 0x17ED0FC
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }

	// RVA: 0x17ED620 Offset: 0x17E9620 VA: 0x17ED620
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }

	// RVA: 0x17E9A24 Offset: 0x17E5A24 VA: 0x17E9A24
	internal static ParameterInfo New(Type type, MemberInfo member, MarshalAsAttribute marshalAs) { }
}

// Namespace: System.Reflection
internal struct MonoPropertyInfo // TypeDefIndex: 1264
{
	// Fields
	public Type parent; // 0x0
	public Type declaring_type; // 0x8
	public string name; // 0x10
	public MethodInfo get_method; // 0x18
	public MethodInfo set_method; // 0x20
	public PropertyAttributes attrs; // 0x28
}

// Namespace: System.Reflection
[Flags]
internal enum PInfo // TypeDefIndex: 1265
{
	// Fields
	public int value__; // 0x0
	public const PInfo Attributes = 1;
	public const PInfo GetMethod = 2;
	public const PInfo SetMethod = 4;
	public const PInfo ReflectedType = 8;
	public const PInfo DeclaringType = 16;
	public const PInfo Name = 32;
}

// Namespace: 
private sealed class RuntimePropertyInfo.GetterAdapter : MulticastDelegate // TypeDefIndex: 1266
{
	// Methods

	// RVA: 0x17EE4DC Offset: 0x17EA4DC VA: 0x17EE4DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17EE5E4 Offset: 0x17EA5E4 VA: 0x17EE5E4 Slot: 12
	public virtual object Invoke(object _this) { }
}

// Namespace: 
private sealed class RuntimePropertyInfo.Getter<T, R> : MulticastDelegate // TypeDefIndex: 1267
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270620 Offset: 0x126C620 VA: 0x1270620
	|-RuntimePropertyInfo.Getter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual R Invoke(T _this) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127072C Offset: 0x126C72C VA: 0x127072C
	|-RuntimePropertyInfo.Getter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private sealed class RuntimePropertyInfo.StaticGetter<R> : MulticastDelegate // TypeDefIndex: 1268
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1465A94 Offset: 0x1461A94 VA: 0x1465A94
	|-RuntimePropertyInfo.StaticGetter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual R Invoke() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1465B34 Offset: 0x1461B34 VA: 0x1465B34
	|-RuntimePropertyInfo.StaticGetter<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: System.Reflection
[Serializable]
internal class RuntimePropertyInfo : PropertyInfo, ISerializable // TypeDefIndex: 1269
{
	// Fields
	internal IntPtr klass; // 0x10
	internal IntPtr prop; // 0x18
	private MonoPropertyInfo info; // 0x20
	private PInfo cached; // 0x50
	private RuntimePropertyInfo.GetterAdapter cached_getter; // 0x58

	// Properties
	internal BindingFlags BindingFlags { get; }
	public override Module Module { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x17ED688 Offset: 0x17E9688 VA: 0x17ED688
	internal static void get_property_info(RuntimePropertyInfo prop, ref MonoPropertyInfo info, PInfo req_info) { }

	// RVA: 0x17ED68C Offset: 0x17E968C VA: 0x17ED68C
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x17ED694 Offset: 0x17E9694 VA: 0x17ED694 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x17ED6B4 Offset: 0x17E96B4 VA: 0x17ED6B4
	internal RuntimeType GetDeclaringTypeInternal() { }

	// RVA: 0x17ED738 Offset: 0x17E9738 VA: 0x17ED738
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x17ED698 Offset: 0x17E9698 VA: 0x17ED698
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x17ED7BC Offset: 0x17E97BC VA: 0x17ED7BC Slot: 3
	public override string ToString() { }

	// RVA: 0x17ED7C4 Offset: 0x17E97C4 VA: 0x17ED7C4
	private string FormatNameAndSig(bool serialization) { }

	// RVA: 0x17ED934 Offset: 0x17E9934 VA: 0x17ED934 Slot: 29
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17EDA00 Offset: 0x17E9A00 VA: 0x17EDA00
	internal string SerializationToString() { }

	// RVA: 0x17EDA08 Offset: 0x17E9A08 VA: 0x17EDA08
	private void CachePropertyInfo(PInfo flags) { }

	// RVA: 0x17EDA48 Offset: 0x17E9A48 VA: 0x17EDA48 Slot: 18
	public override bool get_CanRead() { }

	// RVA: 0x17EDA88 Offset: 0x17E9A88 VA: 0x17EDA88 Slot: 19
	public override bool get_CanWrite() { }

	// RVA: 0x17EDAC8 Offset: 0x17E9AC8 VA: 0x17EDAC8 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x17EDB78 Offset: 0x17E9B78 VA: 0x17EDB78 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x17EDBB0 Offset: 0x17E9BB0 VA: 0x17EDBB0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x17EDBE8 Offset: 0x17E9BE8 VA: 0x17EDBE8 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17EDC20 Offset: 0x17E9C20 VA: 0x17EDC20 Slot: 22
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x17EDCA4 Offset: 0x17E9CA4 VA: 0x17EDCA4 Slot: 17
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x17EDE6C Offset: 0x17E9E6C VA: 0x17EDE6C Slot: 24
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x17EDEF0 Offset: 0x17E9EF0 VA: 0x17EDEF0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EDF5C Offset: 0x17E9F5C VA: 0x17EDF5C Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EDFB8 Offset: 0x17E9FB8 VA: 0x17EDFB8 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: -1 Offset: -1
	private static object GetterAdapterFrame<T, R>(RuntimePropertyInfo.Getter<T, R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1147FF4 Offset: 0x1143FF4 VA: 0x1147FF4
	|-RuntimePropertyInfo.GetterAdapterFrame<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static object StaticGetterAdapterFrame<R>(RuntimePropertyInfo.StaticGetter<R> getter, object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114811C Offset: 0x114411C VA: 0x114811C
	|-RuntimePropertyInfo.StaticGetterAdapterFrame<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x17EE024 Offset: 0x17EA024 VA: 0x17EE024 Slot: 25
	public override object GetValue(object obj, object[] index) { }

	// RVA: 0x17EE044 Offset: 0x17EA044 VA: 0x17EE044 Slot: 26
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17EE238 Offset: 0x17EA238 VA: 0x17EE238 Slot: 28
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17EE434 Offset: 0x17EA434 VA: 0x17EE434 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x17EE438 Offset: 0x17EA438 VA: 0x17EE438
	internal static int get_metadata_token(RuntimePropertyInfo monoProperty) { }

	// RVA: 0x17EE43C Offset: 0x17EA43C VA: 0x17EE43C
	private static PropertyInfo internal_from_handle_type(IntPtr event_handle, IntPtr type_handle) { }

	// RVA: 0x17EE440 Offset: 0x17EA440 VA: 0x17EE440
	internal static PropertyInfo GetPropertyFromHandle(RuntimePropertyHandle handle, RuntimeTypeHandle reflectedType) { }

	// RVA: 0x17EE4D4 Offset: 0x17EA4D4 VA: 0x17EE4D4
	public void .ctor() { }
}

// Namespace: System.Reflection
[ComVisible(True)]
[Serializable]
public class StrongNameKeyPair : ISerializable, IDeserializationCallback // TypeDefIndex: 1270
{
	// Fields
	private byte[] _publicKey; // 0x10
	private string _keyPairContainer; // 0x18
	private bool _keyPairExported; // 0x20
	private byte[] _keyPairArray; // 0x28

	// Methods

	// RVA: 0x17EE5F8 Offset: 0x17EA5F8 VA: 0x17EE5F8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17EE820 Offset: 0x17EA820 VA: 0x17EE820 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17EE95C Offset: 0x17EA95C VA: 0x17EE95C Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }
}
