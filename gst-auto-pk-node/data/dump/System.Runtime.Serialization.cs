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

// Namespace: System.Runtime.Serialization
public interface IDeserializationCallback // TypeDefIndex: 937
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDeserialization(object sender);
}

// Namespace: System.Runtime.Serialization
[CLSCompliant(False)]
public interface IFormatterConverter // TypeDefIndex: 938
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object Convert(object value, Type type);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool ToBoolean(object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int ToInt32(object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract long ToInt64(object value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float ToSingle(object value);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string ToString(object value);
}

// Namespace: System.Runtime.Serialization
public interface IObjectReference // TypeDefIndex: 939
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetRealObject(StreamingContext context);
}

// Namespace: System.Runtime.Serialization
public interface ISerializable // TypeDefIndex: 940
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetObjectData(SerializationInfo info, StreamingContext context);
}

// Namespace: System.Runtime.Serialization
[Serializable]
public class SerializationException : SystemException // TypeDefIndex: 941
{
	// Fields
	private static string s_nullMessage; // 0x0

	// Methods

	// RVA: 0x17AD09C Offset: 0x17A909C VA: 0x17AD09C
	public void .ctor() { }

	// RVA: 0x17AD110 Offset: 0x17A9110 VA: 0x17AD110
	public void .ctor(string message) { }

	// RVA: 0x17AD134 Offset: 0x17A9134 VA: 0x17AD134
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x17AD158 Offset: 0x17A9158 VA: 0x17AD158
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17AD160 Offset: 0x17A9160 VA: 0x17AD160
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization
[IsReadOnly]
public struct SerializationEntry // TypeDefIndex: 942
{
	// Fields
	private readonly string _name; // 0x0
	private readonly object _value; // 0x8
	private readonly Type _type; // 0x10

	// Properties
	public object Value { get; }
	public string Name { get; }

	// Methods

	// RVA: 0x17AD1C8 Offset: 0x17A91C8 VA: 0x17AD1C8
	internal void .ctor(string entryName, object entryValue, Type entryType) { }

	// RVA: 0x17AD20C Offset: 0x17A920C VA: 0x17AD20C
	public object get_Value() { }

	// RVA: 0x17AD214 Offset: 0x17A9214 VA: 0x17AD214
	public string get_Name() { }
}

// Namespace: System.Runtime.Serialization
public sealed class SerializationInfoEnumerator : IEnumerator // TypeDefIndex: 943
{
	// Fields
	private readonly string[] _members; // 0x10
	private readonly object[] _data; // 0x18
	private readonly Type[] _types; // 0x20
	private readonly int _numItems; // 0x28
	private int _currItem; // 0x2C
	private bool _current; // 0x30

	// Properties
	private object System.Collections.IEnumerator.Current { get; }
	public SerializationEntry Current { get; }
	public string Name { get; }
	public object Value { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x17AD21C Offset: 0x17A921C VA: 0x17AD21C
	internal void .ctor(string[] members, object[] info, Type[] types, int numItems) { }

	// RVA: 0x179F4C0 Offset: 0x179B4C0 VA: 0x179F4C0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x17AD294 Offset: 0x17A9294 VA: 0x17AD294 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x17A6BF0 Offset: 0x17A2BF0 VA: 0x17A6BF0
	public SerializationEntry get_Current() { }

	// RVA: 0x17AD304 Offset: 0x17A9304 VA: 0x17AD304 Slot: 6
	public void Reset() { }

	// RVA: 0x179F348 Offset: 0x179B348 VA: 0x179F348
	public string get_Name() { }

	// RVA: 0x179F3CC Offset: 0x179B3CC VA: 0x179F3CC
	public object get_Value() { }

	// RVA: 0x17AD314 Offset: 0x17A9314 VA: 0x17AD314
	public Type get_ObjectType() { }
}

// Namespace: System.Runtime.Serialization
internal sealed class DeserializationEventHandler : MulticastDelegate // TypeDefIndex: 944
{
	// Methods

	// RVA: 0x17AD398 Offset: 0x17A9398 VA: 0x17AD398
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17AD4A0 Offset: 0x17A94A0 VA: 0x17AD4A0 Slot: 12
	public virtual void Invoke(object sender) { }
}

// Namespace: System.Runtime.Serialization
public sealed class SerializationEventHandler : MulticastDelegate // TypeDefIndex: 945
{
	// Methods

	// RVA: 0x17AD4B4 Offset: 0x17A94B4 VA: 0x17AD4B4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17AD554 Offset: 0x17A9554 VA: 0x17AD554 Slot: 12
	public virtual void Invoke(StreamingContext context) { }
}

// Namespace: System.Runtime.Serialization
public class FormatterConverter : IFormatterConverter // TypeDefIndex: 946
{
	// Methods

	// RVA: 0x17AD568 Offset: 0x17A9568 VA: 0x17AD568 Slot: 4
	public object Convert(object value, Type type) { }

	// RVA: 0x17AD654 Offset: 0x17A9654 VA: 0x17AD654 Slot: 5
	public bool ToBoolean(object value) { }

	// RVA: 0x17AD6EC Offset: 0x17A96EC VA: 0x17AD6EC Slot: 6
	public int ToInt32(object value) { }

	// RVA: 0x17AD784 Offset: 0x17A9784 VA: 0x17AD784 Slot: 7
	public long ToInt64(object value) { }

	// RVA: 0x17AD81C Offset: 0x17A981C VA: 0x17AD81C Slot: 8
	public float ToSingle(object value) { }

	// RVA: 0x17AD8B4 Offset: 0x17A98B4 VA: 0x17AD8B4 Slot: 9
	public string ToString(object value) { }

	// RVA: 0x17AD608 Offset: 0x17A9608 VA: 0x17AD608
	private static void ThrowValueNullException() { }

	// RVA: 0x17AD94C Offset: 0x17A994C VA: 0x17AD94C
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization
public interface ISerializationSurrogate // TypeDefIndex: 947
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetObjectData(object obj, SerializationInfo info, StreamingContext context);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector);
}

// Namespace: System.Runtime.Serialization
public interface ISurrogateSelector // TypeDefIndex: 948
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector);
}

// Namespace: System.Runtime.Serialization
[Serializable]
internal sealed class MemberHolder // TypeDefIndex: 949
{
	// Fields
	internal readonly Type _memberType; // 0x10
	internal readonly StreamingContext _context; // 0x18

	// Methods

	// RVA: 0x17AD954 Offset: 0x17A9954 VA: 0x17AD954
	internal void .ctor(Type type, StreamingContext ctx) { }

	// RVA: 0x17AD9A8 Offset: 0x17A99A8 VA: 0x17AD9A8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17AD9C4 Offset: 0x17A99C4 VA: 0x17AD9C4 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: System.Runtime.Serialization
[Serializable]
public abstract class SerializationBinder // TypeDefIndex: 950
{
	// Methods

	// RVA: 0x17ADA44 Offset: 0x17A9A44 VA: 0x17ADA44 Slot: 4
	public virtual void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract Type BindToType(string assemblyName, string typeName);

	// RVA: 0x17ADA70 Offset: 0x17A9A70 VA: 0x17ADA70
	protected void .ctor() { }
}

// Namespace: System.Runtime.Serialization
internal sealed class SerializationEvents // TypeDefIndex: 951
{
	// Fields
	private readonly List<MethodInfo> _onSerializingMethods; // 0x10
	private readonly List<MethodInfo> _onSerializedMethods; // 0x18
	private readonly List<MethodInfo> _onDeserializingMethods; // 0x20
	private readonly List<MethodInfo> _onDeserializedMethods; // 0x28

	// Properties
	internal bool HasOnSerializingEvents { get; }

	// Methods

	// RVA: 0x17ADA78 Offset: 0x17A9A78 VA: 0x17ADA78
	internal void .ctor(Type t) { }

	// RVA: 0x17ADBCC Offset: 0x17A9BCC VA: 0x17ADBCC
	private List<MethodInfo> GetMethodsWithAttribute(Type attribute, Type t) { }

	// RVA: 0x17ADDF4 Offset: 0x17A9DF4 VA: 0x17ADDF4
	internal bool get_HasOnSerializingEvents() { }

	// RVA: 0x17ADE14 Offset: 0x17A9E14 VA: 0x17ADE14
	internal void InvokeOnSerializing(object obj, StreamingContext context) { }

	// RVA: 0x17ADEB8 Offset: 0x17A9EB8 VA: 0x17ADEB8
	internal void InvokeOnDeserializing(object obj, StreamingContext context) { }

	// RVA: 0x17ADF0C Offset: 0x17A9F0C VA: 0x17ADF0C
	internal void InvokeOnDeserialized(object obj, StreamingContext context) { }

	// RVA: 0x17ADF60 Offset: 0x17A9F60 VA: 0x17ADF60
	internal SerializationEventHandler AddOnSerialized(object obj, SerializationEventHandler handler) { }

	// RVA: 0x17AE1A4 Offset: 0x17AA1A4 VA: 0x17AE1A4
	internal SerializationEventHandler AddOnDeserialized(object obj, SerializationEventHandler handler) { }

	// RVA: 0x17ADE68 Offset: 0x17A9E68 VA: 0x17ADE68
	private static void InvokeOnDelegate(object obj, StreamingContext context, List<MethodInfo> methods) { }

	// RVA: 0x17ADF74 Offset: 0x17A9F74 VA: 0x17ADF74
	private static SerializationEventHandler AddOnDelegate(object obj, SerializationEventHandler handler, List<MethodInfo> methods) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SerializationEventsCache.<>c // TypeDefIndex: 952
{
	// Fields
	public static readonly SerializationEventsCache.<>c <>9; // 0x0
	public static Func<Type, SerializationEvents> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x17AE388 Offset: 0x17AA388 VA: 0x17AE388
	private static void .cctor() { }

	// RVA: 0x17AE3F0 Offset: 0x17AA3F0 VA: 0x17AE3F0
	public void .ctor() { }

	// RVA: 0x17AE3F8 Offset: 0x17AA3F8 VA: 0x17AE3F8
	internal SerializationEvents <GetSerializationEventsForType>b__1_0(Type type) { }
}

// Namespace: System.Runtime.Serialization
internal static class SerializationEventsCache // TypeDefIndex: 953
{
	// Fields
	private static readonly ConcurrentDictionary<Type, SerializationEvents> s_cache; // 0x0

	// Methods

	// RVA: 0x17AE1B8 Offset: 0x17AA1B8 VA: 0x17AE1B8
	internal static SerializationEvents GetSerializationEventsForType(Type t) { }

	// RVA: 0x17AE2F0 Offset: 0x17AA2F0 VA: 0x17AE2F0
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization
public sealed class SerializationObjectManager // TypeDefIndex: 954
{
	// Fields
	private readonly Dictionary<object, object> _objectSeenTable; // 0x10
	private readonly StreamingContext _context; // 0x18
	private SerializationEventHandler _onSerializedHandler; // 0x28

	// Methods

	// RVA: 0x17AE450 Offset: 0x17AA450 VA: 0x17AE450
	public void .ctor(StreamingContext context) { }

	// RVA: 0x17AE4FC Offset: 0x17AA4FC VA: 0x17AE4FC
	public void RegisterObject(object obj) { }

	// RVA: 0x17AE698 Offset: 0x17AA698 VA: 0x17AE698
	public void RaiseOnSerializedEvent() { }

	// RVA: 0x17AE600 Offset: 0x17AA600 VA: 0x17AE600
	private void AddOnSerialized(object obj) { }
}

// Namespace: System.Runtime.Serialization
internal sealed class ValueTypeFixupInfo // TypeDefIndex: 955
{
	// Fields
	private readonly long _containerID; // 0x10
	private readonly FieldInfo _parentField; // 0x18
	private readonly int[] _parentIndex; // 0x20

	// Properties
	public long ContainerID { get; }
	public FieldInfo ParentField { get; }
	public int[] ParentIndex { get; }

	// Methods

	// RVA: 0x17AE6BC Offset: 0x17AA6BC VA: 0x17AE6BC
	public void .ctor(long containerID, FieldInfo member, int[] parentIndex) { }

	// RVA: 0x17AE834 Offset: 0x17AA834 VA: 0x17AE834
	public long get_ContainerID() { }

	// RVA: 0x17AE83C Offset: 0x17AA83C VA: 0x17AE83C
	public FieldInfo get_ParentField() { }

	// RVA: 0x17AE844 Offset: 0x17AA844 VA: 0x17AE844
	public int[] get_ParentIndex() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FormatterServices.<>c__DisplayClass9_0 // TypeDefIndex: 956
{
	// Fields
	public Type type; // 0x10

	// Methods

	// RVA: 0x17AF98C Offset: 0x17AB98C VA: 0x17AF98C
	public void .ctor() { }

	// RVA: 0x17B0D90 Offset: 0x17ACD90 VA: 0x17B0D90
	internal MemberInfo[] <GetSerializableMembers>b__0(MemberHolder _) { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
public static class FormatterServices // TypeDefIndex: 957
{
	// Fields
	internal static ConcurrentDictionary<MemberHolder, MemberInfo[]> m_MemberInfoTable; // 0x0
	private static bool unsafeTypeForwardersIsEnabled; // 0x8
	private static bool unsafeTypeForwardersIsEnabledInitialized; // 0x9
	private static readonly Type[] advancedTypes; // 0x10
	private static Binder s_binder; // 0x18

	// Methods

	// RVA: 0x17AE84C Offset: 0x17AA84C VA: 0x17AE84C
	private static void .cctor() { }

	// RVA: 0x17AE9EC Offset: 0x17AA9EC VA: 0x17AE9EC
	private static MemberInfo[] GetSerializableMembers(RuntimeType type) { }

	// RVA: 0x17AEB90 Offset: 0x17AAB90 VA: 0x17AEB90
	private static bool CheckSerializable(RuntimeType type) { }

	// RVA: 0x17AEBAC Offset: 0x17AABAC VA: 0x17AEBAC
	private static MemberInfo[] InternalGetSerializableMembers(RuntimeType type) { }

	// RVA: 0x17AF250 Offset: 0x17AB250 VA: 0x17AF250
	private static bool GetParentTypes(RuntimeType parentType, out RuntimeType[] parentTypes, out int parentTypeCount) { }

	// RVA: 0x17AF6EC Offset: 0x17AB6EC VA: 0x17AF6EC
	public static MemberInfo[] GetSerializableMembers(Type type, StreamingContext context) { }

	// RVA: 0x17AF994 Offset: 0x17AB994 VA: 0x17AF994
	public static object GetUninitializedObject(Type type) { }

	// RVA: 0x17AFB54 Offset: 0x17ABB54 VA: 0x17AFB54
	private static object nativeGetUninitializedObject(RuntimeType type) { }

	// RVA: 0x17AFB5C Offset: 0x17ABB5C VA: 0x17AFB5C
	private static bool GetEnableUnsafeTypeForwarders() { }

	// RVA: 0x17AFB64 Offset: 0x17ABB64 VA: 0x17AFB64
	internal static bool UnsafeTypeForwardersIsEnabled() { }

	// RVA: 0x17AFC0C Offset: 0x17ABC0C VA: 0x17AFC0C
	internal static void SerializationSetValue(MemberInfo fi, object target, object value) { }

	// RVA: 0x17AFEBC Offset: 0x17ABEBC VA: 0x17AFEBC
	public static object PopulateObjectMembers(object obj, MemberInfo[] members, object[] data) { }

	// RVA: 0x17B01B0 Offset: 0x17AC1B0 VA: 0x17B01B0
	public static object[] GetObjectData(object obj, MemberInfo[] members) { }

	// RVA: 0x17B05A0 Offset: 0x17AC5A0 VA: 0x17B05A0
	public static Type GetTypeFromAssembly(Assembly assem, string name) { }

	// RVA: 0x17B0638 Offset: 0x17AC638 VA: 0x17B0638
	internal static Assembly LoadAssemblyFromString(string assemblyName) { }

	// RVA: 0x17B0640 Offset: 0x17AC640 VA: 0x17B0640
	internal static Assembly LoadAssemblyFromStringNoThrow(string assemblyName) { }

	// RVA: 0x17B0714 Offset: 0x17AC714 VA: 0x17B0714
	internal static string GetClrAssemblyName(Type type, out bool hasTypeForwardedFrom) { }

	// RVA: 0x17B0870 Offset: 0x17AC870 VA: 0x17B0870
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x17B08F8 Offset: 0x17AC8F8 VA: 0x17B08F8
	private static string GetClrTypeFullNameForArray(Type type) { }

	// RVA: 0x17B0B20 Offset: 0x17ACB20 VA: 0x17B0B20
	private static string GetClrTypeFullNameForNonArrayTypes(Type type) { }
}

// Namespace: System.Runtime.Serialization
internal sealed class SurrogateForCyclicalReference : ISerializationSurrogate // TypeDefIndex: 958
{
	// Fields
	private ISerializationSurrogate innerSurrogate; // 0x10

	// Methods

	// RVA: 0x17B0E3C Offset: 0x17ACE3C VA: 0x17B0E3C Slot: 4
	public void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17B0F0C Offset: 0x17ACF0C VA: 0x17B0F0C Slot: 5
	public object SetObjectData(object obj, SerializationInfo info, StreamingContext context, ISurrogateSelector selector) { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Serializable]
public class ObjectIDGenerator // TypeDefIndex: 959
{
	// Fields
	internal int m_currentCount; // 0x10
	internal int m_currentSize; // 0x14
	internal long[] m_ids; // 0x18
	internal object[] m_objs; // 0x20
	private static readonly int[] sizes; // 0x0

	// Methods

	// RVA: 0x17B0FE8 Offset: 0x17ACFE8 VA: 0x17B0FE8
	public void .ctor() { }

	// RVA: 0x17B10D4 Offset: 0x17AD0D4 VA: 0x17B10D4
	private int FindElement(object obj, out bool found) { }

	// RVA: 0x17B11A0 Offset: 0x17AD1A0 VA: 0x17B11A0 Slot: 4
	public virtual long GetId(object obj, out bool firstTime) { }

	// RVA: 0x17B160C Offset: 0x17AD60C VA: 0x17B160C Slot: 5
	public virtual long HasId(object obj, out bool firstTime) { }

	// RVA: 0x17B1320 Offset: 0x17AD320 VA: 0x17B1320
	private void Rehash() { }

	// RVA: 0x17B16DC Offset: 0x17AD6DC VA: 0x17B16DC
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
public class ObjectManager // TypeDefIndex: 960
{
	// Fields
	private DeserializationEventHandler m_onDeserializationHandler; // 0x10
	private SerializationEventHandler m_onDeserializedHandler; // 0x18
	internal ObjectHolder[] m_objects; // 0x20
	internal object m_topObject; // 0x28
	internal ObjectHolderList m_specialFixupObjects; // 0x30
	internal long m_fixupCount; // 0x38
	internal ISurrogateSelector m_selector; // 0x40
	internal StreamingContext m_context; // 0x48

	// Properties
	internal object TopObject { get; set; }
	internal ObjectHolderList SpecialFixupObjects { get; }

	// Methods

	// RVA: 0x17B177C Offset: 0x17AD77C VA: 0x17B177C
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain) { }

	// RVA: 0x17B1820 Offset: 0x17AD820 VA: 0x17B1820
	private bool CanCallGetType(object obj) { }

	// RVA: 0x17B1828 Offset: 0x17AD828 VA: 0x17B1828
	internal void set_TopObject(object value) { }

	// RVA: 0x17B1830 Offset: 0x17AD830 VA: 0x17B1830
	internal object get_TopObject() { }

	// RVA: 0x17B1838 Offset: 0x17AD838 VA: 0x17B1838
	internal ObjectHolderList get_SpecialFixupObjects() { }

	// RVA: 0x17B18B0 Offset: 0x17AD8B0 VA: 0x17B18B0
	internal ObjectHolder FindObjectHolder(long objectID) { }

	// RVA: 0x17B1910 Offset: 0x17AD910 VA: 0x17B1910
	internal ObjectHolder FindOrCreateObjectHolder(long objectID) { }

	// RVA: 0x17B19E0 Offset: 0x17AD9E0 VA: 0x17B19E0
	private void AddObjectHolder(ObjectHolder holder) { }

	// RVA: 0x17B1B14 Offset: 0x17ADB14 VA: 0x17B1B14
	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing) { }

	// RVA: 0x17B1DF0 Offset: 0x17ADDF0 VA: 0x17B1DF0
	private void FixupSpecialObject(ObjectHolder holder) { }

	// RVA: 0x17B2BB0 Offset: 0x17AEBB0 VA: 0x17B2BB0
	private bool ResolveObjectReference(ObjectHolder holder) { }

	// RVA: 0x17B259C Offset: 0x17AE59C VA: 0x17B259C
	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value) { }

	// RVA: 0x17B2E3C Offset: 0x17AEE3C VA: 0x17B2E3C
	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete) { }

	// RVA: 0x17B2AD8 Offset: 0x17AEAD8 VA: 0x17B2AD8
	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder) { }

	// RVA: 0x17B36B0 Offset: 0x17AF6B0 VA: 0x17B36B0 Slot: 4
	public virtual object GetObject(long objectID) { }

	// RVA: 0x17B3760 Offset: 0x17AF760 VA: 0x17B3760
	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member) { }

	// RVA: 0x17B3980 Offset: 0x17AF980 VA: 0x17B3980
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex) { }

	// RVA: 0x17B22BC Offset: 0x17AE2BC VA: 0x17B22BC
	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17B4338 Offset: 0x17B0338 VA: 0x17B4338
	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t) { }

	// RVA: 0x17B4468 Offset: 0x17B0468 VA: 0x17B4468 Slot: 5
	public virtual void DoFixups() { }

	// RVA: 0x17B48BC Offset: 0x17B08BC VA: 0x17B48BC
	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired) { }

	// RVA: 0x17B4AE0 Offset: 0x17B0AE0 VA: 0x17B4AE0 Slot: 6
	public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired) { }

	// RVA: 0x17B4DC0 Offset: 0x17B0DC0 VA: 0x17B4DC0 Slot: 7
	public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }

	// RVA: 0x17B4F24 Offset: 0x17B0F24 VA: 0x17B4F24 Slot: 8
	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired) { }

	// RVA: 0x17B5088 Offset: 0x17B1088 VA: 0x17B5088 Slot: 9
	public virtual void RaiseDeserializationEvent() { }

	// RVA: 0x17B50D4 Offset: 0x17B10D4 VA: 0x17B50D4 Slot: 10
	internal virtual void AddOnDeserialization(DeserializationEventHandler handler) { }

	// RVA: 0x17B5164 Offset: 0x17B1164 VA: 0x17B5164 Slot: 11
	internal virtual void AddOnDeserialized(object obj) { }

	// RVA: 0x17B51FC Offset: 0x17B11FC VA: 0x17B51FC Slot: 12
	internal virtual void RaiseOnDeserializedEvent(object obj) { }

	// RVA: 0x17B5280 Offset: 0x17B1280 VA: 0x17B5280
	public void RaiseOnDeserializingEvent(object obj) { }
}

// Namespace: System.Runtime.Serialization
internal sealed class ObjectHolder // TypeDefIndex: 961
{
	// Fields
	private object m_object; // 0x10
	internal long m_id; // 0x18
	private int m_missingElementsRemaining; // 0x20
	private int m_missingDecendents; // 0x24
	internal SerializationInfo m_serInfo; // 0x28
	internal ISerializationSurrogate m_surrogate; // 0x30
	internal FixupHolderList m_missingElements; // 0x38
	internal LongList m_dependentObjects; // 0x40
	internal ObjectHolder m_next; // 0x48
	internal int m_flags; // 0x50
	private bool m_markForFixupWhenAvailable; // 0x54
	private ValueTypeFixupInfo m_valueFixup; // 0x58
	private TypeLoadExceptionHolder m_typeLoad; // 0x60
	private bool m_reachable; // 0x68

	// Properties
	internal bool IsIncompleteObjectReference { get; set; }
	internal bool RequiresDelayedFixup { get; }
	internal bool RequiresValueTypeFixup { get; }
	internal bool ValueTypeFixupPerformed { get; set; }
	internal bool HasISerializable { get; }
	internal bool HasSurrogate { get; }
	internal bool CanSurrogatedObjectValueChange { get; }
	internal bool CanObjectValueChange { get; }
	internal int DirectlyDependentObjects { get; }
	internal int TotalDependentObjects { get; }
	internal bool Reachable { get; set; }
	internal bool TypeLoadExceptionReachable { get; }
	internal TypeLoadExceptionHolder TypeLoadException { get; set; }
	internal object ObjectValue { get; }
	internal SerializationInfo SerializationInfo { get; set; }
	internal ISerializationSurrogate Surrogate { get; }
	internal LongList DependentObjects { get; set; }
	internal bool RequiresSerInfoFixup { get; set; }
	internal ValueTypeFixupInfo ValueFixup { get; }
	internal bool CompletelyFixed { get; }
	internal long ContainerID { get; }

	// Methods

	// RVA: 0x17B19AC Offset: 0x17AD9AC VA: 0x17B19AC
	internal void .ctor(long objID) { }

	// RVA: 0x17B3F34 Offset: 0x17AFF34 VA: 0x17B3F34
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x17B3858 Offset: 0x17AF858 VA: 0x17B3858
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x17B5304 Offset: 0x17B1304 VA: 0x17B5304
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x17B3588 Offset: 0x17AF588 VA: 0x17B3588
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x17B35AC Offset: 0x17AF5AC VA: 0x17B35AC
	internal void RemoveDependency(long id) { }

	// RVA: 0x17B4994 Offset: 0x17B0994 VA: 0x17B4994
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x17B5314 Offset: 0x17B1314 VA: 0x17B5314
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x17B4A60 Offset: 0x17B0A60 VA: 0x17B4A60
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x17B4180 Offset: 0x17B0180 VA: 0x17B4180
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0x17B3624 Offset: 0x17AF624 VA: 0x17B3624
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x17B2204 Offset: 0x17AE204 VA: 0x17B2204
	internal void SetFlags() { }

	// RVA: 0x17B1DE4 Offset: 0x17ADDE4 VA: 0x17B1DE4
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x17B2E2C Offset: 0x17AEE2C VA: 0x17B2E2C
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x17B4170 Offset: 0x17B0170 VA: 0x17B4170
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0x17B2558 Offset: 0x17AE558 VA: 0x17B2558
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x17B2564 Offset: 0x17AE564 VA: 0x17B2564
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x17B35D0 Offset: 0x17AF5D0 VA: 0x17B35D0
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0x17B348C Offset: 0x17AF48C VA: 0x17B348C
	internal bool get_HasISerializable() { }

	// RVA: 0x17B2048 Offset: 0x17AE048 VA: 0x17B2048
	internal bool get_HasSurrogate() { }

	// RVA: 0x17B2054 Offset: 0x17AE054 VA: 0x17B2054
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x17B1DC4 Offset: 0x17ADDC4 VA: 0x17B1DC4
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x17B54AC Offset: 0x17B14AC VA: 0x17B54AC
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x17B432C Offset: 0x17B032C VA: 0x17B432C
	internal int get_TotalDependentObjects() { }

	// RVA: 0x17B54B4 Offset: 0x17B14B4 VA: 0x17B54B4
	internal bool get_Reachable() { }

	// RVA: 0x17B54BC Offset: 0x17B14BC VA: 0x17B54BC
	internal void set_Reachable(bool value) { }

	// RVA: 0x17B35C0 Offset: 0x17AF5C0 VA: 0x17B35C0
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x17B54C4 Offset: 0x17B14C4 VA: 0x17B54C4
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0x17B54CC Offset: 0x17B14CC VA: 0x17B54CC
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x17B54D4 Offset: 0x17B14D4 VA: 0x17B54D4
	internal object get_ObjectValue() { }

	// RVA: 0x17B20F0 Offset: 0x17AE0F0 VA: 0x17B20F0
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x17B54DC Offset: 0x17B14DC VA: 0x17B54DC
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x17B54E4 Offset: 0x17B14E4 VA: 0x17B54E4
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x17B54EC Offset: 0x17B14EC VA: 0x17B54EC
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x17B54F4 Offset: 0x17B14F4 VA: 0x17B54F4
	internal LongList get_DependentObjects() { }

	// RVA: 0x17B54FC Offset: 0x17B14FC VA: 0x17B54FC
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x17B47F4 Offset: 0x17B07F4 VA: 0x17B47F4
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x17B2538 Offset: 0x17AE538 VA: 0x17B2538
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x17B5504 Offset: 0x17B1504 VA: 0x17B5504
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x17B1DA4 Offset: 0x17ADDA4 VA: 0x17B1DA4
	internal bool get_CompletelyFixed() { }

	// RVA: 0x17B540C Offset: 0x17B140C VA: 0x17B540C
	internal long get_ContainerID() { }
}

// Namespace: System.Runtime.Serialization
[Serializable]
internal class FixupHolder // TypeDefIndex: 962
{
	// Fields
	internal long m_id; // 0x10
	internal object m_fixupInfo; // 0x18
	internal int m_fixupType; // 0x20

	// Methods

	// RVA: 0x17B4D74 Offset: 0x17B0D74 VA: 0x17B4D74
	internal void .ctor(long id, object fixupInfo, int fixupType) { }
}

// Namespace: System.Runtime.Serialization
[Serializable]
internal class FixupHolderList // TypeDefIndex: 963
{
	// Fields
	internal FixupHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Methods

	// RVA: 0x17B5404 Offset: 0x17B1404 VA: 0x17B5404
	internal void .ctor() { }

	// RVA: 0x17B550C Offset: 0x17B150C VA: 0x17B550C
	internal void .ctor(int startingSize) { }

	// RVA: 0x17B5580 Offset: 0x17B1580 VA: 0x17B5580 Slot: 4
	internal virtual void Add(FixupHolder fixup) { }

	// RVA: 0x17B562C Offset: 0x17B162C VA: 0x17B562C
	private void EnlargeArray() { }
}

// Namespace: System.Runtime.Serialization
[Serializable]
internal class LongList // TypeDefIndex: 964
{
	// Fields
	private long[] m_values; // 0x10
	private int m_count; // 0x18
	private int m_totalItems; // 0x1C
	private int m_currentItem; // 0x20

	// Properties
	internal int Count { get; }
	internal long Current { get; }

	// Methods

	// RVA: 0x17B5424 Offset: 0x17B1424 VA: 0x17B5424
	internal void .ctor() { }

	// RVA: 0x17B56C0 Offset: 0x17B16C0 VA: 0x17B56C0
	internal void .ctor(int startingSize) { }

	// RVA: 0x17B542C Offset: 0x17B142C VA: 0x17B542C
	internal void Add(long value) { }

	// RVA: 0x17B57C8 Offset: 0x17B17C8 VA: 0x17B57C8
	internal int get_Count() { }

	// RVA: 0x17B35E4 Offset: 0x17AF5E4 VA: 0x17B35E4
	internal void StartEnumeration() { }

	// RVA: 0x17B3630 Offset: 0x17AF630 VA: 0x17B3630
	internal bool MoveNext() { }

	// RVA: 0x17B35F0 Offset: 0x17AF5F0 VA: 0x17B35F0
	internal long get_Current() { }

	// RVA: 0x17B5374 Offset: 0x17B1374 VA: 0x17B5374
	internal bool RemoveElement(long value) { }

	// RVA: 0x17B5734 Offset: 0x17B1734 VA: 0x17B5734
	private void EnlargeArray() { }
}

// Namespace: System.Runtime.Serialization
internal class ObjectHolderList // TypeDefIndex: 965
{
	// Fields
	internal ObjectHolder[] m_values; // 0x10
	internal int m_count; // 0x18

	// Properties
	internal int Version { get; }
	internal int Count { get; }

	// Methods

	// RVA: 0x17B18A8 Offset: 0x17AD8A8 VA: 0x17B18A8
	internal void .ctor() { }

	// RVA: 0x17B57D0 Offset: 0x17B17D0 VA: 0x17B57D0
	internal void .ctor(int startingSize) { }

	// RVA: 0x17B5844 Offset: 0x17B1844 VA: 0x17B5844 Slot: 4
	internal virtual void Add(ObjectHolder value) { }

	// RVA: 0x17B475C Offset: 0x17B075C VA: 0x17B475C
	internal ObjectHolderListEnumerator GetFixupEnumerator() { }

	// RVA: 0x17B58BC Offset: 0x17B18BC VA: 0x17B58BC
	private void EnlargeArray() { }

	// RVA: 0x17B59B4 Offset: 0x17B19B4 VA: 0x17B59B4
	internal int get_Version() { }

	// RVA: 0x17B59BC Offset: 0x17B19BC VA: 0x17B59BC
	internal int get_Count() { }
}

// Namespace: System.Runtime.Serialization
internal class ObjectHolderListEnumerator // TypeDefIndex: 966
{
	// Fields
	private bool m_isFixupEnumerator; // 0x10
	private ObjectHolderList m_list; // 0x18
	private int m_startingVersion; // 0x20
	private int m_currPos; // 0x24

	// Properties
	internal ObjectHolder Current { get; }

	// Methods

	// RVA: 0x17B5950 Offset: 0x17B1950 VA: 0x17B5950
	internal void .ctor(ObjectHolderList list, bool isFixupEnumerator) { }

	// RVA: 0x17B480C Offset: 0x17B080C VA: 0x17B480C
	internal bool MoveNext() { }

	// RVA: 0x17B47B8 Offset: 0x17B07B8 VA: 0x17B47B8
	internal ObjectHolder get_Current() { }
}

// Namespace: System.Runtime.Serialization
internal class TypeLoadExceptionHolder // TypeDefIndex: 967
{
	// Fields
	private string m_typeName; // 0x10

	// Properties
	internal string TypeName { get; }

	// Methods

	// RVA: 0x17B59C4 Offset: 0x17B19C4 VA: 0x17B59C4
	internal void .ctor(string typeName) { }

	// RVA: 0x17B59F4 Offset: 0x17B19F4 VA: 0x17B59F4
	internal string get_TypeName() { }
}

// Namespace: System.Runtime.Serialization
public sealed class SafeSerializationEventArgs : EventArgs // TypeDefIndex: 968
{
	// Fields
	private StreamingContext m_streamingContext; // 0x10
	private List<object> m_serializedStates; // 0x20

	// Properties
	internal IList<object> SerializedStates { get; }

	// Methods

	// RVA: 0x17B59FC Offset: 0x17B19FC VA: 0x17B59FC
	internal void .ctor(StreamingContext streamingContext) { }

	// RVA: 0x17B5ACC Offset: 0x17B1ACC VA: 0x17B5ACC
	internal IList<object> get_SerializedStates() { }
}

// Namespace: System.Runtime.Serialization
public interface ISafeSerializationData // TypeDefIndex: 969
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CompleteDeserialization(object deserialized);
}

// Namespace: System.Runtime.Serialization
[Serializable]
internal sealed class SafeSerializationManager : IObjectReference, ISerializable // TypeDefIndex: 970
{
	// Fields
	private IList<object> m_serializedStates; // 0x10
	private SerializationInfo m_savedSerializationInfo; // 0x18
	private object m_realObject; // 0x20
	private RuntimeType m_realType; // 0x28
	[CompilerGenerated]
	private EventHandler<SafeSerializationEventArgs> SerializeObjectState; // 0x30

	// Properties
	internal bool IsActive { get; }

	// Methods

	// RVA: 0x17B5AD4 Offset: 0x17B1AD4 VA: 0x17B5AD4
	internal void .ctor() { }

	// RVA: 0x17B5ADC Offset: 0x17B1ADC VA: 0x17B5ADC
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17B600C Offset: 0x17B200C VA: 0x17B600C
	internal bool get_IsActive() { }

	// RVA: 0x17B601C Offset: 0x17B201C VA: 0x17B601C
	internal void CompleteSerialization(object serializedObject, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17B6214 Offset: 0x17B2214 VA: 0x17B6214
	internal void CompleteDeserialization(object deserializedObject) { }

	// RVA: 0x17B6568 Offset: 0x17B2568 VA: 0x17B6568 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17B660C Offset: 0x17B260C VA: 0x17B660C Slot: 4
	private object System.Runtime.Serialization.IObjectReference.GetRealObject(StreamingContext context) { }

	[OnDeserialized]
	// RVA: 0x17B68D8 Offset: 0x17B28D8 VA: 0x17B68D8
	private void OnDeserialized(StreamingContext context) { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Usage(256, Inherited = False)]
public sealed class OptionalFieldAttribute : Attribute // TypeDefIndex: 971
{
	// Fields
	private int versionAdded; // 0x10

	// Properties
	public int VersionAdded { set; }

	// Methods

	// RVA: 0x17B698C Offset: 0x17B298C VA: 0x17B698C
	public void .ctor() { }

	// RVA: 0x17B699C Offset: 0x17B299C VA: 0x17B699C
	public void set_VersionAdded(int value) { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Usage(64, Inherited = False)]
public sealed class OnSerializingAttribute : Attribute // TypeDefIndex: 972
{
	// Methods

	// RVA: 0x17B6A04 Offset: 0x17B2A04 VA: 0x17B6A04
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization
[Usage(64, Inherited = False)]
[ComVisible(True)]
public sealed class OnSerializedAttribute : Attribute // TypeDefIndex: 973
{
	// Methods

	// RVA: 0x17B6A0C Offset: 0x17B2A0C VA: 0x17B6A0C
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Usage(64, Inherited = False)]
public sealed class OnDeserializingAttribute : Attribute // TypeDefIndex: 974
{
	// Methods

	// RVA: 0x17B6A14 Offset: 0x17B2A14 VA: 0x17B6A14
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Usage(64, Inherited = False)]
public sealed class OnDeserializedAttribute : Attribute // TypeDefIndex: 975
{
	// Methods

	// RVA: 0x17B6A1C Offset: 0x17B2A1C VA: 0x17B6A1C
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization
internal sealed class SerializationFieldInfo : FieldInfo // TypeDefIndex: 976
{
	// Fields
	private RuntimeFieldInfo m_field; // 0x10
	private string m_serializationName; // 0x18

	// Properties
	public override Module Module { get; }
	public override int MetadataToken { get; }
	public override string Name { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override Type FieldType { get; }
	internal RuntimeFieldInfo FieldInfo { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override FieldAttributes Attributes { get; }

	// Methods

	// RVA: 0x17B6A24 Offset: 0x17B2A24 VA: 0x17B6A24 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x17B6A40 Offset: 0x17B2A40 VA: 0x17B6A40 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x17AF644 Offset: 0x17AB644 VA: 0x17AF644
	internal void .ctor(RuntimeFieldInfo field, string namePrefix) { }

	// RVA: 0x17B6A60 Offset: 0x17B2A60 VA: 0x17B6A60 Slot: 8
	public override string get_Name() { }

	// RVA: 0x17B6A68 Offset: 0x17B2A68 VA: 0x17B6A68 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x17B6A84 Offset: 0x17B2A84 VA: 0x17B6A84 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x17B6AA0 Offset: 0x17B2AA0 VA: 0x17B6AA0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x17B6AC4 Offset: 0x17B2AC4 VA: 0x17B6AC4 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x17B6AE8 Offset: 0x17B2AE8 VA: 0x17B6AE8 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x17B6B08 Offset: 0x17B2B08 VA: 0x17B6B08 Slot: 17
	public override Type get_FieldType() { }

	// RVA: 0x17B6B28 Offset: 0x17B2B28 VA: 0x17B6B28 Slot: 25
	public override object GetValue(object obj) { }

	// RVA: 0x17B0520 Offset: 0x17AC520 VA: 0x17B0520
	internal object InternalGetValue(object obj) { }

	// RVA: 0x17B6B48 Offset: 0x17B2B48 VA: 0x17B6B48 Slot: 27
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x17AFE0C Offset: 0x17ABE0C VA: 0x17AFE0C
	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x17B6B68 Offset: 0x17B2B68 VA: 0x17B6B68
	internal RuntimeFieldInfo get_FieldInfo() { }

	// RVA: 0x17B6B70 Offset: 0x17B2B70 VA: 0x17B6B70 Slot: 24
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0x17B6B90 Offset: 0x17B2B90 VA: 0x17B6B90 Slot: 16
	public override FieldAttributes get_Attributes() { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
public sealed class SerializationInfo // TypeDefIndex: 977
{
	// Fields
	internal string[] m_members; // 0x10
	internal object[] m_data; // 0x18
	internal Type[] m_types; // 0x20
	private Dictionary<string, int> m_nameToIndex; // 0x28
	internal int m_currMember; // 0x30
	internal IFormatterConverter m_converter; // 0x38
	private string m_fullTypeName; // 0x40
	private string m_assemName; // 0x48
	private Type objectType; // 0x50
	private bool isFullTypeNameSetExplicit; // 0x58
	private bool isAssemblyNameSetExplicit; // 0x59
	private bool requireSameTokenInPartialTrust; // 0x5A

	// Properties
	public string FullTypeName { get; }
	public string AssemblyName { get; }
	public int MemberCount { get; }
	public Type ObjectType { get; }
	public bool IsFullTypeNameSetExplicit { get; }
	public bool IsAssemblyNameSetExplicit { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x17B6BB0 Offset: 0x17B2BB0 VA: 0x17B6BB0
	public void .ctor(Type type, IFormatterConverter converter) { }

	[CLSCompliant(False)]
	// RVA: 0x17B6BB8 Offset: 0x17B2BB8 VA: 0x17B6BB8
	public void .ctor(Type type, IFormatterConverter converter, bool requireSameTokenInPartialTrust) { }

	// RVA: 0x17B6DF4 Offset: 0x17B2DF4 VA: 0x17B6DF4
	public string get_FullTypeName() { }

	// RVA: 0x17B6DFC Offset: 0x17B2DFC VA: 0x17B6DFC
	public string get_AssemblyName() { }

	// RVA: 0x179F824 Offset: 0x179B824 VA: 0x179F824
	public void SetType(Type type) { }

	// RVA: 0x17B6E08 Offset: 0x17B2E08 VA: 0x17B6E08
	private static bool Compare(byte[] a, byte[] b) { }

	// RVA: 0x17B6E04 Offset: 0x17B2E04 VA: 0x17B6E04
	internal static void DemandForUnsafeAssemblyNameAssignments(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x17B6E74 Offset: 0x17B2E74 VA: 0x17B6E74
	internal static bool IsAssemblyNameAssignmentSafe(string originalAssemblyName, string newAssemblyName) { }

	// RVA: 0x17B6FA8 Offset: 0x17B2FA8 VA: 0x17B6FA8
	public int get_MemberCount() { }

	// RVA: 0x17B6FB0 Offset: 0x17B2FB0 VA: 0x17B6FB0
	public Type get_ObjectType() { }

	// RVA: 0x17B6FB8 Offset: 0x17B2FB8 VA: 0x17B6FB8
	public bool get_IsFullTypeNameSetExplicit() { }

	// RVA: 0x17B6FC0 Offset: 0x17B2FC0 VA: 0x17B6FC0
	public bool get_IsAssemblyNameSetExplicit() { }

	// RVA: 0x179F2D0 Offset: 0x179B2D0 VA: 0x179F2D0
	public SerializationInfoEnumerator GetEnumerator() { }

	// RVA: 0x17B6FC8 Offset: 0x17B2FC8 VA: 0x17B6FC8
	private void ExpandArrays() { }

	// RVA: 0x17B6198 Offset: 0x17B2198 VA: 0x17B6198
	public void AddValue(string name, object value, Type type) { }

	// RVA: 0x179F97C Offset: 0x179B97C VA: 0x179F97C
	public void AddValue(string name, object value) { }

	// RVA: 0x179F9F8 Offset: 0x179B9F8 VA: 0x179F9F8
	public void AddValue(string name, bool value) { }

	// RVA: 0x17B72DC Offset: 0x17B32DC VA: 0x17B72DC
	public void AddValue(string name, byte value) { }

	// RVA: 0x17B7354 Offset: 0x17B3354 VA: 0x17B7354
	public void AddValue(string name, short value) { }

	// RVA: 0x17AB528 Offset: 0x17A7528 VA: 0x17AB528
	public void AddValue(string name, int value) { }

	// RVA: 0x17B73CC Offset: 0x17B33CC VA: 0x17B73CC
	public void AddValue(string name, long value) { }

	[CLSCompliant(False)]
	// RVA: 0x17B7444 Offset: 0x17B3444 VA: 0x17B7444
	public void AddValue(string name, ulong value) { }

	// RVA: 0x17B74BC Offset: 0x17B34BC VA: 0x17B74BC
	public void AddValue(string name, float value) { }

	// RVA: 0x17B7534 Offset: 0x17B3534 VA: 0x17B7534
	public void AddValue(string name, DateTime value) { }

	// RVA: 0x17B7110 Offset: 0x17B3110 VA: 0x17B7110
	internal void AddValueInternal(string name, object value, Type type) { }

	// RVA: 0x17B3498 Offset: 0x17AF498 VA: 0x17B3498
	internal void UpdateValue(string name, object value, Type type) { }

	// RVA: 0x17B75F4 Offset: 0x17B35F4 VA: 0x17B75F4
	private int FindElement(string name) { }

	// RVA: 0x17B76B8 Offset: 0x17B36B8 VA: 0x17B76B8
	private object GetElement(string name, out Type foundType) { }

	[ComVisible(True)]
	// RVA: 0x17B77C8 Offset: 0x17B37C8 VA: 0x17B77C8
	private object GetElementNoThrow(string name, out Type foundType) { }

	// RVA: 0x17B5E04 Offset: 0x17B1E04 VA: 0x17B5E04
	public object GetValue(string name, Type type) { }

	[ComVisible(True)]
	// RVA: 0x17B5CFC Offset: 0x17B1CFC VA: 0x17B5CFC
	internal object GetValueNoThrow(string name, Type type) { }

	// RVA: 0x17B7864 Offset: 0x17B3864 VA: 0x17B7864
	public bool GetBoolean(string name) { }

	// RVA: 0x17B79B0 Offset: 0x17B39B0 VA: 0x17B79B0
	public int GetInt32(string name) { }

	// RVA: 0x17B7AF0 Offset: 0x17B3AF0 VA: 0x17B7AF0
	public long GetInt64(string name) { }

	// RVA: 0x17B7C30 Offset: 0x17B3C30 VA: 0x17B7C30
	public float GetSingle(string name) { }

	// RVA: 0x17B7D70 Offset: 0x17B3D70 VA: 0x17B7D70
	public string GetString(string name) { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[IsReadOnly]
[Serializable]
public struct StreamingContext // TypeDefIndex: 978
{
	// Fields
	internal readonly object m_additionalContext; // 0x0
	internal readonly StreamingContextStates m_state; // 0x8

	// Properties
	public object Context { get; }
	public StreamingContextStates State { get; }

	// Methods

	// RVA: 0x17B7EA8 Offset: 0x17B3EA8 VA: 0x17B7EA8
	public void .ctor(StreamingContextStates state) { }

	// RVA: 0x17B7EBC Offset: 0x17B3EBC VA: 0x17B7EBC
	public void .ctor(StreamingContextStates state, object additional) { }

	// RVA: 0x17B7ECC Offset: 0x17B3ECC VA: 0x17B7ECC
	public object get_Context() { }

	// RVA: 0x17B7ED4 Offset: 0x17B3ED4 VA: 0x17B7ED4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17B7F84 Offset: 0x17B3F84 VA: 0x17B7F84 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17B7F8C Offset: 0x17B3F8C VA: 0x17B7F8C
	public StreamingContextStates get_State() { }
}

// Namespace: System.Runtime.Serialization
[ComVisible(True)]
[Flags]
[Serializable]
public enum StreamingContextStates // TypeDefIndex: 979
{
	// Fields
	public int value__; // 0x0
	public const StreamingContextStates CrossProcess = 1;
	public const StreamingContextStates CrossMachine = 2;
	public const StreamingContextStates File = 4;
	public const StreamingContextStates Persistence = 8;
	public const StreamingContextStates Remoting = 16;
	public const StreamingContextStates Other = 32;
	public const StreamingContextStates Clone = 64;
	public const StreamingContextStates CrossAppDomain = 128;
	public const StreamingContextStates All = 255;
}

// Namespace: System.Runtime.Serialization
[Usage(28, Inherited = False, AllowMultiple = False)]
public sealed class DataContractAttribute : Attribute // TypeDefIndex: 8119
{
	// Fields
	private bool isReference; // 0x10

	// Properties
	public bool IsReference { get; }

	// Methods

	// RVA: 0x1B3EDCC Offset: 0x1B3ADCC VA: 0x1B3EDCC
	public bool get_IsReference() { }
}

// Namespace: System.Runtime.Serialization
[Usage(384, Inherited = False, AllowMultiple = False)]
public sealed class DataMemberAttribute : Attribute // TypeDefIndex: 8120
{
	// Fields
	private string name; // 0x10
	private int order; // 0x18
	private bool isRequired; // 0x1C
	private bool emitDefaultValue; // 0x1D

	// Properties
	public string Name { get; }
	public int Order { get; }
	public bool IsRequired { get; }
	public bool EmitDefaultValue { get; }

	// Methods

	// RVA: 0x1B3EDD4 Offset: 0x1B3ADD4 VA: 0x1B3EDD4
	public string get_Name() { }

	// RVA: 0x1B3EDDC Offset: 0x1B3ADDC VA: 0x1B3EDDC
	public int get_Order() { }

	// RVA: 0x1B3EDE4 Offset: 0x1B3ADE4 VA: 0x1B3EDE4
	public bool get_IsRequired() { }

	// RVA: 0x1B3EDEC Offset: 0x1B3ADEC VA: 0x1B3EDEC
	public bool get_EmitDefaultValue() { }
}

// Namespace: System.Runtime.Serialization
[Usage(256, Inherited = False, AllowMultiple = False)]
public sealed class EnumMemberAttribute : Attribute // TypeDefIndex: 8121
{
	// Fields
	private string value; // 0x10

	// Properties
	public string Value { get; }

	// Methods

	// RVA: 0x1B3EDF4 Offset: 0x1B3ADF4 VA: 0x1B3EDF4
	public string get_Value() { }
}

// Namespace: System.Runtime.Serialization
[Usage(384, Inherited = False, AllowMultiple = False)]
public sealed class IgnoreDataMemberAttribute : Attribute // TypeDefIndex: 8122
{}

// Namespace: 
internal class <Module> // TypeDefIndex: 8123
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 8124
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[CompilerGenerated]
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 8125
{
	// Methods

	// RVA: 0xFF1C00 Offset: 0xFEDC00 VA: 0xFF1C00
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0xFF1CF0 Offset: 0xFEDCF0 VA: 0xFF1CF0
	public void .ctor() { }
}
