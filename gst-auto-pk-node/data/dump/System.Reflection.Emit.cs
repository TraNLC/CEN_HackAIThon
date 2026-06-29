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

// Namespace: System.Reflection.Emit
public class AssemblyBuilder : Assembly // TypeDefIndex: 1271
{}

// Namespace: System.Reflection.Emit
public class ConstructorBuilder : ConstructorInfo // TypeDefIndex: 1272
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x17EE960 Offset: 0x17EA960 VA: 0x17EE960 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x17EE998 Offset: 0x17EA998 VA: 0x17EE998 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x17EE9D0 Offset: 0x17EA9D0 VA: 0x17EE9D0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17EEA08 Offset: 0x17EAA08 VA: 0x17EEA08 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x17EEA40 Offset: 0x17EAA40 VA: 0x17EEA40 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x17EEA78 Offset: 0x17EAA78 VA: 0x17EEA78 Slot: 32
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x17EEAB0 Offset: 0x17EAAB0 VA: 0x17EEAB0 Slot: 39
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x17EEAE8 Offset: 0x17EAAE8 VA: 0x17EEAE8 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EEB20 Offset: 0x17EAB20 VA: 0x17EEB20 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EEB58 Offset: 0x17EAB58 VA: 0x17EEB58 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EEB90 Offset: 0x17EAB90 VA: 0x17EEB90 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x17EEBC8 Offset: 0x17EABC8 VA: 0x17EEBC8 Slot: 31
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }
}

// Namespace: System.Reflection.Emit
public sealed class DynamicMethod : MethodInfo // TypeDefIndex: 1273
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x17EEC00 Offset: 0x17EAC00 VA: 0x17EEC00 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x17EEC38 Offset: 0x17EAC38 VA: 0x17EEC38 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x17EEC70 Offset: 0x17EAC70 VA: 0x17EEC70 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17EECA8 Offset: 0x17EACA8 VA: 0x17EECA8 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x17EECE0 Offset: 0x17EACE0 VA: 0x17EECE0 Slot: 32
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x17EED18 Offset: 0x17EAD18 VA: 0x17EED18 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x17EED50 Offset: 0x17EAD50 VA: 0x17EED50 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EED88 Offset: 0x17EAD88 VA: 0x17EED88 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EEDC0 Offset: 0x17EADC0 VA: 0x17EEDC0 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x17EEDF8 Offset: 0x17EADF8 VA: 0x17EEDF8 Slot: 43
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x17EEE30 Offset: 0x17EAE30 VA: 0x17EEE30 Slot: 31
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x17EEE68 Offset: 0x17EAE68 VA: 0x17EEE68 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

// Namespace: System.Reflection.Emit
public sealed class EnumBuilder : TypeInfo // TypeDefIndex: 1274
{
	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x17EEEA0 Offset: 0x17EAEA0 VA: 0x17EEEA0 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x17EEED8 Offset: 0x17EAED8 VA: 0x17EEED8 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x17EEF10 Offset: 0x17EAF10 VA: 0x17EEF10 Slot: 115
	public override Type get_BaseType() { }

	// RVA: 0x17EEF48 Offset: 0x17EAF48 VA: 0x17EEF48 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x17EEF80 Offset: 0x17EAF80 VA: 0x17EEF80 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x17EEFB8 Offset: 0x17EAFB8 VA: 0x17EEFB8 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17EEFF0 Offset: 0x17EAFF0 VA: 0x17EEFF0 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x17EF028 Offset: 0x17EB028 VA: 0x17EF028 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x17EF060 Offset: 0x17EB060 VA: 0x17EF060 Slot: 55
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x17EF098 Offset: 0x17EB098 VA: 0x17EF098 Slot: 80
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x17EF0D0 Offset: 0x17EB0D0 VA: 0x17EF0D0 Slot: 82
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x17EF108 Offset: 0x17EB108 VA: 0x17EF108 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EF140 Offset: 0x17EB140 VA: 0x17EF140 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EF178 Offset: 0x17EB178 VA: 0x17EF178 Slot: 46
	public override Type GetElementType() { }

	// RVA: 0x17EF1B0 Offset: 0x17EB1B0 VA: 0x17EF1B0 Slot: 84
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17EF1E8 Offset: 0x17EB1E8 VA: 0x17EF1E8 Slot: 85
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x17EF220 Offset: 0x17EB220 VA: 0x17EF220 Slot: 87
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17EF258 Offset: 0x17EB258 VA: 0x17EF258 Slot: 89
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x17EF290 Offset: 0x17EB290 VA: 0x17EF290 Slot: 117
	public override Type[] GetInterfaces() { }

	// RVA: 0x17EF2C8 Offset: 0x17EB2C8 VA: 0x17EF2C8 Slot: 93
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x17EF300 Offset: 0x17EB300 VA: 0x17EF300 Slot: 100
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x17EF338 Offset: 0x17EB338 VA: 0x17EF338 Slot: 102
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x17EF370 Offset: 0x17EB370 VA: 0x17EF370 Slot: 103
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17EF3A8 Offset: 0x17EB3A8 VA: 0x17EF3A8 Slot: 104
	public override Type[] GetNestedTypes(BindingFlags bindingAttr) { }

	// RVA: 0x17EF3E0 Offset: 0x17EB3E0 VA: 0x17EF3E0 Slot: 112
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x17EF418 Offset: 0x17EB418 VA: 0x17EF418 Slot: 111
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x17EF450 Offset: 0x17EB450 VA: 0x17EF450 Slot: 45
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x17EF488 Offset: 0x17EB488 VA: 0x17EF488 Slot: 116
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x17EF4C0 Offset: 0x17EB4C0 VA: 0x17EF4C0 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x17EF4F8 Offset: 0x17EB4F8 VA: 0x17EF4F8 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x17EF530 Offset: 0x17EB530 VA: 0x17EF530 Slot: 65
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x17EF568 Offset: 0x17EB568 VA: 0x17EF568 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EF5A0 Offset: 0x17EB5A0 VA: 0x17EF5A0 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x17EF5D8 Offset: 0x17EB5D8 VA: 0x17EF5D8 Slot: 73
	protected override bool IsPrimitiveImpl() { }
}

// Namespace: System.Reflection.Emit
public class EventBuilder // TypeDefIndex: 1275
{}

// Namespace: System.Reflection.Emit
public sealed class FieldBuilder : FieldInfo // TypeDefIndex: 1276
{
	// Properties
	public override FieldAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override Type FieldType { get; }
	public override string Name { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x17EF610 Offset: 0x17EB610 VA: 0x17EF610 Slot: 16
	public override FieldAttributes get_Attributes() { }

	// RVA: 0x17EF618 Offset: 0x17EB618 VA: 0x17EF618 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x17EF620 Offset: 0x17EB620 VA: 0x17EF620 Slot: 24
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x17EF628 Offset: 0x17EB628 VA: 0x17EF628 Slot: 17
	public override Type get_FieldType() { }

	// RVA: 0x17EF630 Offset: 0x17EB630 VA: 0x17EF630 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17EF638 Offset: 0x17EB638 VA: 0x17EF638 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x17EF640 Offset: 0x17EB640 VA: 0x17EF640 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EF648 Offset: 0x17EB648 VA: 0x17EF648 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EF650 Offset: 0x17EB650 VA: 0x17EF650 Slot: 25
	public override object GetValue(object obj) { }

	// RVA: 0x17EF658 Offset: 0x17EB658 VA: 0x17EF658 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EF660 Offset: 0x17EB660 VA: 0x17EF660 Slot: 27
	public override void SetValue(object obj, object val, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }
}

// Namespace: System.Reflection.Emit
public sealed class GenericTypeParameterBuilder : TypeInfo // TypeDefIndex: 1277
{
	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x17EF698 Offset: 0x17EB698 VA: 0x17EF698 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x17EF6D0 Offset: 0x17EB6D0 VA: 0x17EF6D0 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x17EF708 Offset: 0x17EB708 VA: 0x17EF708 Slot: 115
	public override Type get_BaseType() { }

	// RVA: 0x17EF740 Offset: 0x17EB740 VA: 0x17EF740 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x17EF778 Offset: 0x17EB778 VA: 0x17EF778 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x17EF7B0 Offset: 0x17EB7B0 VA: 0x17EF7B0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17EF7E8 Offset: 0x17EB7E8 VA: 0x17EF7E8 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x17EF820 Offset: 0x17EB820 VA: 0x17EF820 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x17EF858 Offset: 0x17EB858 VA: 0x17EF858 Slot: 55
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x17EF890 Offset: 0x17EB890 VA: 0x17EF890 Slot: 80
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x17EF8C8 Offset: 0x17EB8C8 VA: 0x17EF8C8 Slot: 82
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x17EF900 Offset: 0x17EB900 VA: 0x17EF900 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EF938 Offset: 0x17EB938 VA: 0x17EF938 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EF970 Offset: 0x17EB970 VA: 0x17EF970 Slot: 46
	public override Type GetElementType() { }

	// RVA: 0x17EF9A8 Offset: 0x17EB9A8 VA: 0x17EF9A8 Slot: 84
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17EF9E0 Offset: 0x17EB9E0 VA: 0x17EF9E0 Slot: 85
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x17EFA18 Offset: 0x17EBA18 VA: 0x17EFA18 Slot: 87
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17EFA50 Offset: 0x17EBA50 VA: 0x17EFA50 Slot: 89
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x17EFA88 Offset: 0x17EBA88 VA: 0x17EFA88 Slot: 117
	public override Type[] GetInterfaces() { }

	// RVA: 0x17EFAC0 Offset: 0x17EBAC0 VA: 0x17EFAC0 Slot: 93
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x17EFAF8 Offset: 0x17EBAF8 VA: 0x17EFAF8 Slot: 100
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x17EFB30 Offset: 0x17EBB30 VA: 0x17EFB30 Slot: 102
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x17EFB68 Offset: 0x17EBB68 VA: 0x17EFB68 Slot: 103
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17EFBA0 Offset: 0x17EBBA0 VA: 0x17EFBA0 Slot: 104
	public override Type[] GetNestedTypes(BindingFlags bindingAttr) { }

	// RVA: 0x17EFBD8 Offset: 0x17EBBD8 VA: 0x17EFBD8 Slot: 112
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x17EFC10 Offset: 0x17EBC10 VA: 0x17EFC10 Slot: 111
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x17EFC48 Offset: 0x17EBC48 VA: 0x17EFC48 Slot: 45
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x17EFC80 Offset: 0x17EBC80 VA: 0x17EFC80 Slot: 116
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x17EFCB8 Offset: 0x17EBCB8 VA: 0x17EFCB8 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x17EFCF0 Offset: 0x17EBCF0 VA: 0x17EFCF0 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x17EFD28 Offset: 0x17EBD28 VA: 0x17EFD28 Slot: 65
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x17EFD60 Offset: 0x17EBD60 VA: 0x17EFD60 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17EFD98 Offset: 0x17EBD98 VA: 0x17EFD98 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x17EFDD0 Offset: 0x17EBDD0 VA: 0x17EFDD0 Slot: 73
	protected override bool IsPrimitiveImpl() { }
}

// Namespace: System.Reflection.Emit
public class ILGenerator // TypeDefIndex: 1278
{}

// Namespace: System.Reflection.Emit
public sealed class LocalBuilder : LocalVariableInfo // TypeDefIndex: 1279
{
	// Fields
	private string name; // 0x20
	internal ILGenerator ilgen; // 0x28
	private int startOffset; // 0x30
	private int endOffset; // 0x34
}

// Namespace: System.Reflection.Emit
public sealed class MethodBuilder : MethodInfo // TypeDefIndex: 1280
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override string Name { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x17EFE08 Offset: 0x17EBE08 VA: 0x17EFE08 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x17EFE40 Offset: 0x17EBE40 VA: 0x17EFE40 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x17EFE78 Offset: 0x17EBE78 VA: 0x17EFE78 Slot: 32
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x17EFEB0 Offset: 0x17EBEB0 VA: 0x17EFEB0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17EFEE8 Offset: 0x17EBEE8 VA: 0x17EFEE8 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x17EFF20 Offset: 0x17EBF20 VA: 0x17EFF20 Slot: 43
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x17EFF58 Offset: 0x17EBF58 VA: 0x17EFF58 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17EFF90 Offset: 0x17EBF90 VA: 0x17EFF90 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17EFFC8 Offset: 0x17EBFC8 VA: 0x17EFFC8 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x17F0000 Offset: 0x17EC000 VA: 0x17F0000 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x17F0038 Offset: 0x17EC038 VA: 0x17F0038 Slot: 31
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x17F0070 Offset: 0x17EC070 VA: 0x17F0070 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}

// Namespace: System.Reflection.Emit
public class ModuleBuilder : Module // TypeDefIndex: 1281
{}

// Namespace: System.Reflection.Emit
public class ParameterBuilder // TypeDefIndex: 1282
{}

// Namespace: System.Reflection.Emit
public sealed class PropertyBuilder : PropertyInfo // TypeDefIndex: 1283
{
	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override Type PropertyType { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x17F00A8 Offset: 0x17EC0A8 VA: 0x17F00A8 Slot: 18
	public override bool get_CanRead() { }

	// RVA: 0x17F00E0 Offset: 0x17EC0E0 VA: 0x17F00E0 Slot: 19
	public override bool get_CanWrite() { }

	// RVA: 0x17F0118 Offset: 0x17EC118 VA: 0x17F0118 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x17F0150 Offset: 0x17EC150 VA: 0x17F0150 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17F0188 Offset: 0x17EC188 VA: 0x17F0188 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x17F01C0 Offset: 0x17EC1C0 VA: 0x17F01C0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x17F01F8 Offset: 0x17EC1F8 VA: 0x17F01F8 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17F0230 Offset: 0x17EC230 VA: 0x17F0230 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17F0268 Offset: 0x17EC268 VA: 0x17F0268 Slot: 22
	public override MethodInfo GetGetMethod(bool nonPublic) { }

	// RVA: 0x17F02A0 Offset: 0x17EC2A0 VA: 0x17F02A0 Slot: 17
	public override ParameterInfo[] GetIndexParameters() { }

	// RVA: 0x17F02D8 Offset: 0x17EC2D8 VA: 0x17F02D8 Slot: 24
	public override MethodInfo GetSetMethod(bool nonPublic) { }

	// RVA: 0x17F0310 Offset: 0x17EC310 VA: 0x17F0310 Slot: 26
	public override object GetValue(object obj, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }

	// RVA: 0x17F0348 Offset: 0x17EC348 VA: 0x17F0348 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17F0380 Offset: 0x17EC380 VA: 0x17F0380 Slot: 28
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, object[] index, CultureInfo culture) { }
}

// Namespace: System.Reflection.Emit
public class SignatureHelper // TypeDefIndex: 1284
{}

// Namespace: System.Reflection.Emit
public sealed class TypeBuilder : TypeInfo // TypeDefIndex: 1285
{
	// Fields
	public const int UnspecifiedTypeSize = 0;

	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x17F03B8 Offset: 0x17EC3B8 VA: 0x17F03B8 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x17F03F0 Offset: 0x17EC3F0 VA: 0x17F03F0 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x17F0428 Offset: 0x17EC428 VA: 0x17F0428 Slot: 115
	public override Type get_BaseType() { }

	// RVA: 0x17F0460 Offset: 0x17EC460 VA: 0x17F0460 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x17F0498 Offset: 0x17EC498 VA: 0x17F0498 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x17F04D0 Offset: 0x17EC4D0 VA: 0x17F04D0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17F0508 Offset: 0x17EC508 VA: 0x17F0508 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x17F0540 Offset: 0x17EC540 VA: 0x17F0540 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x17F0578 Offset: 0x17EC578 VA: 0x17F0578 Slot: 55
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x17F05B0 Offset: 0x17EC5B0 VA: 0x17F05B0 Slot: 80
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x17F05E8 Offset: 0x17EC5E8 VA: 0x17F05E8 Slot: 82
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x17F0620 Offset: 0x17EC620 VA: 0x17F0620 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17F0658 Offset: 0x17EC658 VA: 0x17F0658 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17F0690 Offset: 0x17EC690 VA: 0x17F0690 Slot: 46
	public override Type GetElementType() { }

	// RVA: 0x17F06C8 Offset: 0x17EC6C8 VA: 0x17F06C8 Slot: 84
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17F0700 Offset: 0x17EC700 VA: 0x17F0700 Slot: 85
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x17F0738 Offset: 0x17EC738 VA: 0x17F0738 Slot: 87
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17F0770 Offset: 0x17EC770 VA: 0x17F0770 Slot: 89
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x17F07A8 Offset: 0x17EC7A8 VA: 0x17F07A8 Slot: 117
	public override Type[] GetInterfaces() { }

	// RVA: 0x17F07E0 Offset: 0x17EC7E0 VA: 0x17F07E0 Slot: 93
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x17F0818 Offset: 0x17EC818 VA: 0x17F0818 Slot: 100
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x17F0850 Offset: 0x17EC850 VA: 0x17F0850 Slot: 102
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x17F0888 Offset: 0x17EC888 VA: 0x17F0888 Slot: 103
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x17F08C0 Offset: 0x17EC8C0 VA: 0x17F08C0 Slot: 104
	public override Type[] GetNestedTypes(BindingFlags bindingAttr) { }

	// RVA: 0x17F08F8 Offset: 0x17EC8F8 VA: 0x17F08F8 Slot: 112
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x17F0930 Offset: 0x17EC930 VA: 0x17F0930 Slot: 111
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x17F0968 Offset: 0x17EC968 VA: 0x17F0968 Slot: 45
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x17F09A0 Offset: 0x17EC9A0 VA: 0x17F09A0 Slot: 116
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x17F09D8 Offset: 0x17EC9D8 VA: 0x17F09D8 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x17F0A10 Offset: 0x17ECA10 VA: 0x17F0A10 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x17F0A48 Offset: 0x17ECA48 VA: 0x17F0A48 Slot: 65
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x17F0A80 Offset: 0x17ECA80 VA: 0x17F0A80 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17F0AB8 Offset: 0x17ECAB8 VA: 0x17F0AB8 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x17F0AF0 Offset: 0x17ECAF0 VA: 0x17F0AF0 Slot: 73
	protected override bool IsPrimitiveImpl() { }
}

// Namespace: System.Reflection.Emit
[Obsolete("An alternate API is available: Emit the MarshalAs custom attribute instead.")]
[ComVisible(True)]
[Serializable]
public sealed class UnmanagedMarshal // TypeDefIndex: 1286
{
	// Methods

	// RVA: 0x17F0B28 Offset: 0x17ECB28 VA: 0x17F0B28
	private void .ctor() { }
}
