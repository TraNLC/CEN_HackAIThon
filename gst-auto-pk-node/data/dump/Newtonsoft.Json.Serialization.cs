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

// Namespace: Newtonsoft.Json.Serialization
internal static class CachedAttributeGetter<T> // TypeDefIndex: 6133
{
	// Fields
	[Nullable(new[] { 1, 1, 2 })]
	private static readonly ThreadSafeStore<object, T> TypeAttributeCache; // 0x0

	// Methods

	[NullableContext(1)]
	// RVA: -1 Offset: -1
	public static T GetAttribute(object type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DF120 Offset: 0x14DB120 VA: 0x14DF120
	|-CachedAttributeGetter<object>.GetAttribute
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DF1DC Offset: 0x14DB1DC VA: 0x14DF1DC
	|-CachedAttributeGetter<object>..cctor
	*/
}

// Namespace: Newtonsoft.Json.Serialization
public class CamelCaseNamingStrategy : NamingStrategy // TypeDefIndex: 6134
{
	// Methods

	// RVA: 0x194E8D4 Offset: 0x194A8D4 VA: 0x194E8D4
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0x194E904 Offset: 0x194A904 VA: 0x194E904
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0x1943178 Offset: 0x193F178 VA: 0x1943178
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x194E944 Offset: 0x194A944 VA: 0x194E944 Slot: 7
	protected override string ResolvePropertyName(string name) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<TEnumeratorKey, TEnumeratorValue> : IEnumerator<KeyValuePair<object, object>>, IEnumerator, IDisposable // TypeDefIndex: 6135
{
	// Fields
	private int <>1__state; // 0x0
	[Nullable(new[] { 0, 1, 1 })]
	private KeyValuePair<object, object> <>2__current; // 0x0
	public DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> <>4__this; // 0x0
	[Nullable(new[] { 0, 0, 1, 1 })]
	private IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> <>7__wrap1; // 0x0

	// Properties
	private KeyValuePair<object, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1164AD0 Offset: 0x1160AD0 VA: 0x1164AD0
	|-DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1164AF8 Offset: 0x1160AF8 VA: 0x1164AF8
	|-DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1164B24 Offset: 0x1160B24 VA: 0x1164B24
	|-DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void <>m__Finally1() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1164FEC Offset: 0x1160FEC VA: 0x1164FEC
	|-DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<>m__Finally1
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private KeyValuePair<object, object> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116509C Offset: 0x116109C VA: 0x116509C
	|-DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Object,System.Object>>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11650A8 Offset: 0x11610A8 VA: 0x11650A8
	|-DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11650DC Offset: 0x11610DC VA: 0x11650DC
	|-DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: 
[NullableContext(0)]
internal class DefaultContractResolver.EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> : IEnumerable<KeyValuePair<object, object>>, IEnumerable // TypeDefIndex: 6136
{
	// Fields
	[Nullable(new[] { 1, 0, 1, 1 })]
	private readonly IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E4660 Offset: 0x11E0660 VA: 0x11E4660
	|-DefaultContractResolver.EnumerableDictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[IteratorStateMachine(typeof(DefaultContractResolver.EnumerableDictionaryWrapper.<GetEnumerator>d__2<TEnumeratorKey, TEnumeratorValue>))]
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<KeyValuePair<object, object>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E46D4 Offset: 0x11E06D4 VA: 0x11E46D4
	|-DefaultContractResolver.EnumerableDictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11E4754 Offset: 0x11E0754 VA: 0x11E4754
	|-DefaultContractResolver.EnumerableDictionaryWrapper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DefaultContractResolver.<>c // TypeDefIndex: 6137
{
	// Fields
	[Nullable(0)]
	public static readonly DefaultContractResolver.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<MemberInfo, bool> <>9__40_0; // 0x8
	[Nullable(0)]
	public static Func<MemberInfo, bool> <>9__40_1; // 0x10
	[Nullable(0)]
	public static Func<Type, IEnumerable<MemberInfo>> <>9__44_0; // 0x18
	[Nullable(0)]
	public static Func<MemberInfo, bool> <>9__44_1; // 0x20
	[Nullable(0)]
	public static Func<ConstructorInfo, bool> <>9__47_0; // 0x28
	[Nullable(0)]
	public static Func<JsonProperty, int> <>9__75_0; // 0x30

	// Methods

	// RVA: 0x1955F0C Offset: 0x1951F0C VA: 0x1955F0C
	private static void .cctor() { }

	// RVA: 0x1955F74 Offset: 0x1951F74 VA: 0x1955F74
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1955F7C Offset: 0x1951F7C VA: 0x1955F7C
	internal bool <GetSerializableMembers>b__40_0(MemberInfo m) { }

	[NullableContext(0)]
	// RVA: 0x195602C Offset: 0x195202C VA: 0x195602C
	internal bool <GetSerializableMembers>b__40_1(MemberInfo m) { }

	[NullableContext(0)]
	// RVA: 0x195609C Offset: 0x195209C VA: 0x195609C
	internal IEnumerable<MemberInfo> <GetExtensionDataMemberForType>b__44_0(Type baseType) { }

	[NullableContext(0)]
	// RVA: 0x195617C Offset: 0x195217C VA: 0x195617C
	internal bool <GetExtensionDataMemberForType>b__44_1(MemberInfo m) { }

	[NullableContext(0)]
	// RVA: 0x1956538 Offset: 0x1952538 VA: 0x1956538
	internal bool <GetAttributeConstructor>b__47_0(ConstructorInfo c) { }

	[NullableContext(0)]
	// RVA: 0x19565BC Offset: 0x19525BC VA: 0x19565BC
	internal int <CreateProperties>b__75_0(JsonProperty p) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass42_0 // TypeDefIndex: 6138
{
	// Fields
	[Nullable(0)]
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0x1956618 Offset: 0x1952618 VA: 0x1956618
	public void .ctor() { }

	// RVA: 0x1956620 Offset: 0x1952620 VA: 0x1956620
	internal string <CreateObjectContract>b__0(string s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass45_0 // TypeDefIndex: 6139
{
	// Fields
	[Nullable(new[] { 0, 1, 2 })]
	public Func<object, object> getExtensionDataDictionary; // 0x10
	[Nullable(0)]
	public MemberInfo member; // 0x18

	// Methods

	// RVA: 0x195663C Offset: 0x195263C VA: 0x195663C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass45_1 // TypeDefIndex: 6140
{
	// Fields
	[Nullable(new[] { 0, 1, 2 })]
	public Action<object, object> setExtensionDataDictionary; // 0x10
	[Nullable(new[] { 0, 1 })]
	public Func<object> createExtensionDataDictionary; // 0x18
	[Nullable(new[] { 0, 1, 2 })]
	public MethodCall<object, object> setExtensionDataDictionaryValue; // 0x20
	[Nullable(0)]
	public DefaultContractResolver.<>c__DisplayClass45_0 CS$<>8__locals1; // 0x28

	// Methods

	// RVA: 0x1956644 Offset: 0x1952644 VA: 0x1956644
	public void .ctor() { }

	// RVA: 0x195664C Offset: 0x195264C VA: 0x195664C
	internal void <SetExtensionDataDelegates>b__0(object o, string key, object value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass45_2 // TypeDefIndex: 6141
{
	// Fields
	[Nullable(new[] { 0, 1 })]
	public ObjectConstructor<object> createEnumerableWrapper; // 0x10
	[Nullable(0)]
	public DefaultContractResolver.<>c__DisplayClass45_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x1956858 Offset: 0x1952858 VA: 0x1956858
	public void .ctor() { }

	// RVA: 0x1956860 Offset: 0x1952860 VA: 0x1956860
	internal IEnumerable<KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass62_0 // TypeDefIndex: 6142
{
	// Fields
	[Nullable(0)]
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0x1956978 Offset: 0x1952978 VA: 0x1956978
	public void .ctor() { }

	// RVA: 0x1956980 Offset: 0x1952980 VA: 0x1956980
	internal string <CreateDictionaryContract>b__0(string s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass67_0 // TypeDefIndex: 6143
{
	// Fields
	[Nullable(0)]
	public NamingStrategy namingStrategy; // 0x10

	// Methods

	// RVA: 0x195699C Offset: 0x195299C VA: 0x195699C
	public void .ctor() { }

	// RVA: 0x19569A4 Offset: 0x19529A4 VA: 0x19569A4
	internal string <CreateDynamicContract>b__0(string s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass80_0 // TypeDefIndex: 6144
{
	// Fields
	[Nullable(new[] { 0, 1, 2 })]
	public MethodCall<object, object> shouldSerializeCall; // 0x10

	// Methods

	// RVA: 0x19569C0 Offset: 0x19529C0 VA: 0x19569C0
	public void .ctor() { }

	// RVA: 0x19569C8 Offset: 0x19529C8 VA: 0x19569C8
	internal bool <CreateShouldSerializeTest>b__0(object o) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DefaultContractResolver.<>c__DisplayClass81_0 // TypeDefIndex: 6145
{
	// Fields
	[Nullable(new[] { 0, 1, 1 })]
	public Func<object, object> specifiedPropertyGet; // 0x10

	// Methods

	// RVA: 0x1956ABC Offset: 0x1952ABC VA: 0x1956ABC
	public void .ctor() { }

	// RVA: 0x1956AC4 Offset: 0x1952AC4 VA: 0x1956AC4
	internal bool <SetIsSpecifiedActions>b__0(object o) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class DefaultContractResolver : IContractResolver // TypeDefIndex: 6146
{
	// Fields
	private static readonly IContractResolver _instance; // 0x0
	private static readonly string[] BlacklistedTypeNames; // 0x8
	private static readonly JsonConverter[] BuiltInConverters; // 0x10
	private readonly DefaultJsonNameTable _nameTable; // 0x10
	private readonly ThreadSafeStore<Type, JsonContract> _contractCache; // 0x18
	[CompilerGenerated]
	private BindingFlags <DefaultMembersSearchFlags>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <SerializeCompilerGeneratedMembers>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IgnoreSerializableInterface>k__BackingField; // 0x25
	[CompilerGenerated]
	private bool <IgnoreSerializableAttribute>k__BackingField; // 0x26
	[CompilerGenerated]
	private bool <IgnoreIsSpecifiedMembers>k__BackingField; // 0x27
	[CompilerGenerated]
	private bool <IgnoreShouldSerializeMembers>k__BackingField; // 0x28
	[Nullable(2)]
	[CompilerGenerated]
	private NamingStrategy <NamingStrategy>k__BackingField; // 0x30

	// Properties
	internal static IContractResolver Instance { get; }
	[Obsolete("DefaultMembersSearchFlags is obsolete. To modify the members serialized inherit from DefaultContractResolver and override the GetSerializableMembers method instead.")]
	public BindingFlags DefaultMembersSearchFlags { get; set; }
	public bool SerializeCompilerGeneratedMembers { get; }
	public bool IgnoreSerializableInterface { get; }
	public bool IgnoreSerializableAttribute { get; set; }
	public bool IgnoreIsSpecifiedMembers { get; }
	public bool IgnoreShouldSerializeMembers { get; }
	[Nullable(2)]
	public NamingStrategy NamingStrategy { get; }

	// Methods

	// RVA: 0x194E94C Offset: 0x194A94C VA: 0x194E94C
	internal static IContractResolver get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x194E9A4 Offset: 0x194A9A4 VA: 0x194E9A4
	public BindingFlags get_DefaultMembersSearchFlags() { }

	[CompilerGenerated]
	// RVA: 0x194E9AC Offset: 0x194A9AC VA: 0x194E9AC
	public void set_DefaultMembersSearchFlags(BindingFlags value) { }

	[CompilerGenerated]
	// RVA: 0x194E9B4 Offset: 0x194A9B4 VA: 0x194E9B4
	public bool get_SerializeCompilerGeneratedMembers() { }

	[CompilerGenerated]
	// RVA: 0x194E9BC Offset: 0x194A9BC VA: 0x194E9BC
	public bool get_IgnoreSerializableInterface() { }

	[CompilerGenerated]
	// RVA: 0x194E9C4 Offset: 0x194A9C4 VA: 0x194E9C4
	public bool get_IgnoreSerializableAttribute() { }

	[CompilerGenerated]
	// RVA: 0x194E9CC Offset: 0x194A9CC VA: 0x194E9CC
	public void set_IgnoreSerializableAttribute(bool value) { }

	[CompilerGenerated]
	// RVA: 0x194E9D4 Offset: 0x194A9D4 VA: 0x194E9D4
	public bool get_IgnoreIsSpecifiedMembers() { }

	[CompilerGenerated]
	// RVA: 0x194E9DC Offset: 0x194A9DC VA: 0x194E9DC
	public bool get_IgnoreShouldSerializeMembers() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x194E9E4 Offset: 0x194A9E4 VA: 0x194E9E4
	public NamingStrategy get_NamingStrategy() { }

	// RVA: 0x194E9EC Offset: 0x194A9EC VA: 0x194E9EC
	public void .ctor() { }

	// RVA: 0x194EAFC Offset: 0x194AAFC VA: 0x194EAFC Slot: 5
	public virtual JsonContract ResolveContract(Type type) { }

	// RVA: 0x194EB7C Offset: 0x194AB7C VA: 0x194EB7C
	private static bool FilterMembers(MemberInfo member) { }

	// RVA: 0x194ECC0 Offset: 0x194ACC0 VA: 0x194ECC0 Slot: 6
	protected virtual List<MemberInfo> GetSerializableMembers(Type objectType) { }

	// RVA: 0x194F9C0 Offset: 0x194B9C0 VA: 0x194F9C0
	private bool ShouldSerializeEntityMember(MemberInfo memberInfo) { }

	// RVA: 0x194FAC8 Offset: 0x194BAC8 VA: 0x194FAC8 Slot: 7
	protected virtual JsonObjectContract CreateObjectContract(Type objectType) { }

	// RVA: 0x195156C Offset: 0x194D56C VA: 0x195156C
	private static void ThrowUnableToSerializeError(object o, StreamingContext context) { }

	// RVA: 0x1950B28 Offset: 0x194CB28 VA: 0x1950B28
	private MemberInfo GetExtensionDataMemberForType(Type type) { }

	// RVA: 0x1950CF4 Offset: 0x194CCF4 VA: 0x1950CF4
	private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member) { }

	// RVA: 0x195031C Offset: 0x194C31C VA: 0x195031C
	private ConstructorInfo GetAttributeConstructor(Type objectType) { }

	// RVA: 0x1950874 Offset: 0x194C874 VA: 0x1950874
	private ConstructorInfo GetImmutableConstructor(Type objectType, JsonPropertyCollection memberProperties) { }

	// RVA: 0x195082C Offset: 0x194C82C VA: 0x195082C
	private ConstructorInfo GetParameterizedConstructor(Type objectType) { }

	// RVA: 0x1951810 Offset: 0x194D810 VA: 0x1951810 Slot: 8
	protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties) { }

	// RVA: 0x1951798 Offset: 0x194D798 VA: 0x1951798
	private JsonProperty MatchProperty(JsonPropertyCollection properties, string name, Type type) { }

	// RVA: 0x195198C Offset: 0x194D98C VA: 0x195198C Slot: 9
	protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo) { }

	// RVA: 0x19522A0 Offset: 0x194E2A0 VA: 0x19522A0 Slot: 10
	protected virtual JsonConverter ResolveContractConverter(Type objectType) { }

	// RVA: 0x19522F8 Offset: 0x194E2F8 VA: 0x19522F8
	private Func<object> GetDefaultCreator(Type createdType) { }

	// RVA: 0x19500B8 Offset: 0x194C0B8 VA: 0x19500B8
	private void InitializeContract(JsonContract contract) { }

	// RVA: 0x1952398 Offset: 0x194E398 VA: 0x1952398
	private void ResolveCallbackMethods(JsonContract contract, Type t) { }

	// RVA: 0x19524D8 Offset: 0x194E4D8 VA: 0x19524D8
	private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError) { }

	// RVA: 0x195363C Offset: 0x194F63C VA: 0x195363C
	private static bool IsConcurrentOrObservableCollection(Type t) { }

	// RVA: 0x1952F24 Offset: 0x194EF24 VA: 0x1952F24
	private static bool ShouldSkipDeserialized(Type t) { }

	// RVA: 0x1952E50 Offset: 0x194EE50 VA: 0x1952E50
	private static bool ShouldSkipSerializing(Type t) { }

	// RVA: 0x1951600 Offset: 0x194D600 VA: 0x1951600
	private List<Type> GetClassHierarchyForType(Type type) { }

	// RVA: 0x1953784 Offset: 0x194F784 VA: 0x1953784 Slot: 11
	protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType) { }

	// RVA: 0x1953CE8 Offset: 0x194FCE8 VA: 0x1953CE8 Slot: 12
	protected virtual JsonArrayContract CreateArrayContract(Type objectType) { }

	// RVA: 0x1954020 Offset: 0x1950020 VA: 0x1954020 Slot: 13
	protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType) { }

	// RVA: 0x1954094 Offset: 0x1950094 VA: 0x1954094 Slot: 14
	protected virtual JsonLinqContract CreateLinqContract(Type objectType) { }

	// RVA: 0x1954108 Offset: 0x1950108 VA: 0x1954108 Slot: 15
	protected virtual JsonISerializableContract CreateISerializableContract(Type objectType) { }

	// RVA: 0x1954344 Offset: 0x1950344 VA: 0x1954344 Slot: 16
	protected virtual JsonDynamicContract CreateDynamicContract(Type objectType) { }

	// RVA: 0x195455C Offset: 0x195055C VA: 0x195455C Slot: 17
	protected virtual JsonStringContract CreateStringContract(Type objectType) { }

	// RVA: 0x19545D0 Offset: 0x19505D0 VA: 0x19545D0 Slot: 18
	protected virtual JsonContract CreateContract(Type objectType) { }

	// RVA: 0x19549C8 Offset: 0x19509C8 VA: 0x19549C8
	internal static bool IsJsonPrimitiveType(Type t) { }

	// RVA: 0x1954B20 Offset: 0x1950B20 VA: 0x1954B20
	internal static bool IsIConvertible(Type t) { }

	// RVA: 0x1954A28 Offset: 0x1950A28 VA: 0x1954A28
	internal static bool CanConvertToString(Type type) { }

	// RVA: 0x1952FF8 Offset: 0x194EFF8 VA: 0x1952FF8
	private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType) { }

	// RVA: 0x1954C8C Offset: 0x1950C8C VA: 0x1954C8C
	internal static string GetClrTypeFullName(Type type) { }

	// RVA: 0x1954D8C Offset: 0x1950D8C VA: 0x1954D8C Slot: 19
	protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization) { }

	// RVA: 0x19551B8 Offset: 0x19511B8 VA: 0x19551B8 Slot: 20
	internal virtual DefaultJsonNameTable GetNameTable() { }

	// RVA: 0x19551C0 Offset: 0x19511C0 VA: 0x19551C0 Slot: 21
	protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member) { }

	// RVA: 0x195521C Offset: 0x195121C VA: 0x195521C Slot: 22
	protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) { }

	// RVA: 0x1951C38 Offset: 0x194DC38 VA: 0x1951C38
	private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess) { }

	// RVA: 0x1955434 Offset: 0x1951434 VA: 0x1955434
	private Predicate<object> CreateShouldSerializeTest(MemberInfo member) { }

	// RVA: 0x1955678 Offset: 0x1951678 VA: 0x1955678
	private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess) { }

	// RVA: 0x1955970 Offset: 0x1951970 VA: 0x1955970 Slot: 23
	protected virtual string ResolvePropertyName(string propertyName) { }

	// RVA: 0x1955990 Offset: 0x1951990 VA: 0x1955990 Slot: 24
	protected virtual string ResolveExtensionDataName(string extensionDataName) { }

	// RVA: 0x19559AC Offset: 0x19519AC VA: 0x19559AC Slot: 25
	protected virtual string ResolveDictionaryKey(string dictionaryKey) { }

	// RVA: 0x19559D8 Offset: 0x19519D8 VA: 0x19559D8
	public string GetResolvedPropertyName(string propertyName) { }

	// RVA: 0x19559E8 Offset: 0x19519E8 VA: 0x19559E8
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
public class DefaultNamingStrategy : NamingStrategy // TypeDefIndex: 6147
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x1956B1C Offset: 0x1952B1C VA: 0x1956B1C Slot: 7
	protected override string ResolvePropertyName(string name) { }

	// RVA: 0x1956B24 Offset: 0x1952B24 VA: 0x1956B24
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class DefaultReferenceResolver : IReferenceResolver // TypeDefIndex: 6148
{
	// Fields
	private int _referenceCount; // 0x10

	// Methods

	// RVA: 0x1956B2C Offset: 0x1952B2C VA: 0x1956B2C
	private BidirectionalDictionary<string, object> GetMappings(object context) { }

	// RVA: 0x1956D48 Offset: 0x1952D48 VA: 0x1956D48 Slot: 4
	public object ResolveReference(object context, string reference) { }

	// RVA: 0x1956DBC Offset: 0x1952DBC VA: 0x1956DBC Slot: 5
	public string GetReference(object context, object value) { }

	// RVA: 0x1956EB0 Offset: 0x1952EB0 VA: 0x1956EB0 Slot: 7
	public void AddReference(object context, string reference, object value) { }

	// RVA: 0x1956F1C Offset: 0x1952F1C VA: 0x1956F1C Slot: 6
	public bool IsReferenced(object context, object value) { }

	// RVA: 0x1956F90 Offset: 0x1952F90 VA: 0x1956F90
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class DefaultSerializationBinder : SerializationBinder, ISerializationBinder // TypeDefIndex: 6149
{
	// Fields
	internal static readonly DefaultSerializationBinder Instance; // 0x0
	[Nullable(new[] { 1, 0, 2, 1, 1 })]
	private readonly ThreadSafeStore<StructMultiKey<string, string>, Type> _typeCache; // 0x10

	// Methods

	// RVA: 0x1956F98 Offset: 0x1952F98 VA: 0x1956F98
	public void .ctor() { }

	// RVA: 0x1957070 Offset: 0x1953070 VA: 0x1957070
	private Type GetTypeFromTypeNameKey(StructMultiKey<string, string> typeNameKey) { }

	// RVA: 0x195748C Offset: 0x195348C VA: 0x195748C
	private Type GetGenericTypeFromTypeName(string typeName, Assembly assembly) { }

	// RVA: 0x1957740 Offset: 0x1953740 VA: 0x1957740
	private Type GetTypeByName(StructMultiKey<string, string> typeNameKey) { }

	// RVA: 0x19577A8 Offset: 0x19537A8 VA: 0x19577A8 Slot: 5
	public override Type BindToType(string assemblyName, string typeName) { }

	[NullableContext(2)]
	// RVA: 0x1957824 Offset: 0x1953824 VA: 0x1957824 Slot: 4
	public override void BindToName(Type serializedType, out string assemblyName, out string typeName) { }

	// RVA: 0x19578A0 Offset: 0x19538A0 VA: 0x19578A0
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class ErrorContext // TypeDefIndex: 6150
{
	// Fields
	[CompilerGenerated]
	private bool <Traced>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Exception <Error>k__BackingField; // 0x18
	[Nullable(2)]
	[CompilerGenerated]
	private readonly object <OriginalObject>k__BackingField; // 0x20
	[Nullable(2)]
	[CompilerGenerated]
	private readonly object <Member>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <Handled>k__BackingField; // 0x38

	// Properties
	internal bool Traced { get; set; }
	public Exception Error { get; }
	public bool Handled { get; }

	// Methods

	// RVA: 0x1957904 Offset: 0x1953904 VA: 0x1957904
	internal void .ctor(object originalObject, object member, string path, Exception error) { }

	[CompilerGenerated]
	// RVA: 0x1957978 Offset: 0x1953978 VA: 0x1957978
	internal bool get_Traced() { }

	[CompilerGenerated]
	// RVA: 0x1957980 Offset: 0x1953980 VA: 0x1957980
	internal void set_Traced(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1957988 Offset: 0x1953988 VA: 0x1957988
	public Exception get_Error() { }

	[CompilerGenerated]
	// RVA: 0x1957990 Offset: 0x1953990 VA: 0x1957990
	public bool get_Handled() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class ErrorEventArgs : EventArgs // TypeDefIndex: 6151
{
	// Fields
	[Nullable(2)]
	[CompilerGenerated]
	private readonly object <CurrentObject>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ErrorContext <ErrorContext>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1957998 Offset: 0x1953998 VA: 0x1957998
	public void .ctor(object currentObject, ErrorContext errorContext) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface IAttributeProvider // TypeDefIndex: 6152
{}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface IContractResolver // TypeDefIndex: 6153
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract JsonContract ResolveContract(Type type);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface IReferenceResolver // TypeDefIndex: 6154
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object ResolveReference(object context, string reference);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetReference(object context, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsReferenced(object context, object value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddReference(object context, string reference, object value);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface ISerializationBinder // TypeDefIndex: 6155
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type BindToType(string assemblyName, string typeName);

	[NullableContext(2)]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void BindToName(Type serializedType, out string assemblyName, out string typeName);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface ITraceWriter // TypeDefIndex: 6156
{
	// Properties
	public abstract TraceLevel LevelFilter { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TraceLevel get_LevelFilter();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Trace(TraceLevel level, string message, Exception ex);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
public interface IValueProvider // TypeDefIndex: 6157
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetValue(object target, object value);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object GetValue(object target);
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(2)]
[Nullable(0)]
public class JsonArrayContract : JsonContainerContract // TypeDefIndex: 6158
{
	// Fields
	[CompilerGenerated]
	private readonly Type <CollectionItemType>k__BackingField; // 0xC0
	[CompilerGenerated]
	private readonly bool <IsMultidimensionalArray>k__BackingField; // 0xC8
	private readonly Type _genericCollectionDefinitionType; // 0xD0
	private Type _genericWrapperType; // 0xD8
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _genericWrapperCreator; // 0xE0
	[Nullable(new[] { 2, 1 })]
	private Func<object> _genericTemporaryCollectionCreator; // 0xE8
	[CompilerGenerated]
	private readonly bool <IsArray>k__BackingField; // 0xF0
	[CompilerGenerated]
	private readonly bool <ShouldCreateWrapper>k__BackingField; // 0xF1
	[CompilerGenerated]
	private bool <CanDeserialize>k__BackingField; // 0xF2
	private readonly ConstructorInfo _parameterizedConstructor; // 0xF8
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _parameterizedCreator; // 0x100
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _overrideCreator; // 0x108
	[CompilerGenerated]
	private bool <HasParameterizedCreator>k__BackingField; // 0x110

	// Properties
	public Type CollectionItemType { get; }
	public bool IsMultidimensionalArray { get; }
	internal bool IsArray { get; }
	internal bool ShouldCreateWrapper { get; }
	internal bool CanDeserialize { get; set; }
	[Nullable(new[] { 2, 1 })]
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> OverrideCreator { get; set; }
	public bool HasParameterizedCreator { get; set; }
	internal bool HasParameterizedCreatorInternal { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1957A20 Offset: 0x1953A20 VA: 0x1957A20
	public Type get_CollectionItemType() { }

	[CompilerGenerated]
	// RVA: 0x1957A28 Offset: 0x1953A28 VA: 0x1957A28
	public bool get_IsMultidimensionalArray() { }

	[CompilerGenerated]
	// RVA: 0x1957A30 Offset: 0x1953A30 VA: 0x1957A30
	internal bool get_IsArray() { }

	[CompilerGenerated]
	// RVA: 0x1957A38 Offset: 0x1953A38 VA: 0x1957A38
	internal bool get_ShouldCreateWrapper() { }

	[CompilerGenerated]
	// RVA: 0x1957A40 Offset: 0x1953A40 VA: 0x1957A40
	internal bool get_CanDeserialize() { }

	[CompilerGenerated]
	// RVA: 0x1957A48 Offset: 0x1953A48 VA: 0x1957A48
	private void set_CanDeserialize(bool value) { }

	// RVA: 0x1957A50 Offset: 0x1953A50 VA: 0x1957A50
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0x1957B18 Offset: 0x1953B18 VA: 0x1957B18
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x1957B20 Offset: 0x1953B20 VA: 0x1957B20
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGenerated]
	// RVA: 0x1957B44 Offset: 0x1953B44 VA: 0x1957B44
	public bool get_HasParameterizedCreator() { }

	[CompilerGenerated]
	// RVA: 0x1957B4C Offset: 0x1953B4C VA: 0x1957B4C
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0x1957B54 Offset: 0x1953B54 VA: 0x1957B54
	internal bool get_HasParameterizedCreatorInternal() { }

	[NullableContext(1)]
	// RVA: 0x1957BD4 Offset: 0x1953BD4 VA: 0x1957BD4
	public void .ctor(Type underlyingType) { }

	[NullableContext(1)]
	// RVA: 0x1958CD4 Offset: 0x1954CD4 VA: 0x1958CD4
	internal IWrappedCollection CreateWrapper(object list) { }

	[NullableContext(1)]
	// RVA: 0x19590E4 Offset: 0x19550E4 VA: 0x19590E4
	internal IList CreateTemporaryCollection() { }

	[NullableContext(1)]
	// RVA: 0x1958BB4 Offset: 0x1954BB4 VA: 0x1958BB4
	private void StoreFSharpListCreatorIfNecessary(Type underlyingType) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(2)]
[Nullable(0)]
public class JsonContainerContract : JsonContract // TypeDefIndex: 6159
{
	// Fields
	private JsonContract _itemContract; // 0x90
	private JsonContract _finalItemContract; // 0x98
	[CompilerGenerated]
	private JsonConverter <ItemConverter>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Nullable<bool> <ItemIsReference>k__BackingField; // 0xA8
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xAC
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xB4

	// Properties
	internal JsonContract ItemContract { get; set; }
	internal JsonContract FinalItemContract { get; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }

	// Methods

	// RVA: 0x1959328 Offset: 0x1955328 VA: 0x1959328
	internal JsonContract get_ItemContract() { }

	// RVA: 0x1959330 Offset: 0x1955330 VA: 0x1959330
	internal void set_ItemContract(JsonContract value) { }

	// RVA: 0x1959390 Offset: 0x1955390 VA: 0x1959390
	internal JsonContract get_FinalItemContract() { }

	[CompilerGenerated]
	// RVA: 0x1959398 Offset: 0x1955398 VA: 0x1959398
	public JsonConverter get_ItemConverter() { }

	[CompilerGenerated]
	// RVA: 0x19593A0 Offset: 0x19553A0 VA: 0x19593A0
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x19593A8 Offset: 0x19553A8 VA: 0x19593A8
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGenerated]
	// RVA: 0x19593B0 Offset: 0x19553B0 VA: 0x19593B0
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x19593B8 Offset: 0x19553B8 VA: 0x19593B8
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGenerated]
	// RVA: 0x19593C0 Offset: 0x19553C0 VA: 0x19593C0
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x19593C8 Offset: 0x19553C8 VA: 0x19593C8
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGenerated]
	// RVA: 0x19593D0 Offset: 0x19553D0 VA: 0x19593D0
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[NullableContext(1)]
	// RVA: 0x19589F0 Offset: 0x19549F0 VA: 0x19589F0
	internal void .ctor(Type underlyingType) { }
}

// Namespace: Newtonsoft.Json.Serialization
internal enum JsonContractType // TypeDefIndex: 6160
{
	// Fields
	public int value__; // 0x0
	public const JsonContractType None = 0;
	public const JsonContractType Object = 1;
	public const JsonContractType Array = 2;
	public const JsonContractType Primitive = 3;
	public const JsonContractType String = 4;
	public const JsonContractType Dictionary = 5;
	public const JsonContractType Dynamic = 6;
	public const JsonContractType Serializable = 7;
	public const JsonContractType Linq = 8;
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class SerializationCallback : MulticastDelegate // TypeDefIndex: 6161
{
	// Methods

	// RVA: 0x1959554 Offset: 0x1955554 VA: 0x1959554
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x1959660 Offset: 0x1955660 VA: 0x1959660 Slot: 12
	public virtual void Invoke(object o, StreamingContext context) { }
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class SerializationErrorCallback : MulticastDelegate // TypeDefIndex: 6162
{
	// Methods

	// RVA: 0x1959674 Offset: 0x1955674 VA: 0x1959674
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x1959780 Offset: 0x1955780 VA: 0x1959780 Slot: 12
	public virtual void Invoke(object o, StreamingContext context, ErrorContext errorContext) { }
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataSetter : MulticastDelegate // TypeDefIndex: 6163
{
	// Methods

	// RVA: 0x1959794 Offset: 0x1955794 VA: 0x1959794
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x19598A0 Offset: 0x19558A0 VA: 0x19598A0 Slot: 12
	public virtual void Invoke(object o, string key, object value) { }
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ExtensionDataGetter : MulticastDelegate // TypeDefIndex: 6164
{
	// Methods

	// RVA: 0x19598B4 Offset: 0x19558B4 VA: 0x19598B4
	public void .ctor(object object, IntPtr method) { }

	[NullableContext(1)]
	// RVA: 0x19599BC Offset: 0x19559BC VA: 0x19599BC Slot: 12
	public virtual IEnumerable<KeyValuePair<object, object>> Invoke(object o) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JsonContract.<>c__DisplayClass57_0 // TypeDefIndex: 6165
{
	// Fields
	[Nullable(0)]
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0x195A450 Offset: 0x1956450 VA: 0x195A450
	public void .ctor() { }

	// RVA: 0x195A518 Offset: 0x1956518 VA: 0x195A518
	internal void <CreateSerializationCallback>b__0(object o, StreamingContext context) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JsonContract.<>c__DisplayClass58_0 // TypeDefIndex: 6166
{
	// Fields
	[Nullable(0)]
	public MethodInfo callbackMethodInfo; // 0x10

	// Methods

	// RVA: 0x195A510 Offset: 0x1956510 VA: 0x195A510
	public void .ctor() { }

	// RVA: 0x195A618 Offset: 0x1956618 VA: 0x195A618
	internal void <CreateSerializationErrorCallback>b__0(object o, StreamingContext context, ErrorContext econtext) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public abstract class JsonContract // TypeDefIndex: 6167
{
	// Fields
	internal bool IsNullable; // 0x10
	internal bool IsConvertable; // 0x11
	internal bool IsEnum; // 0x12
	internal Type NonNullableUnderlyingType; // 0x18
	internal ReadType InternalReadType; // 0x20
	internal JsonContractType ContractType; // 0x24
	internal bool IsReadOnlyOrFixedSize; // 0x28
	internal bool IsSealed; // 0x29
	internal bool IsInstantiable; // 0x2A
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onDeserializedCallbacks; // 0x30
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onDeserializingCallbacks; // 0x38
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onSerializedCallbacks; // 0x40
	[Nullable(new[] { 2, 1 })]
	private List<SerializationCallback> _onSerializingCallbacks; // 0x48
	[Nullable(new[] { 2, 1 })]
	private List<SerializationErrorCallback> _onErrorCallbacks; // 0x50
	private Type _createdType; // 0x58
	[CompilerGenerated]
	private readonly Type <UnderlyingType>k__BackingField; // 0x60
	[CompilerGenerated]
	private Nullable<bool> <IsReference>k__BackingField; // 0x68
	[Nullable(2)]
	[CompilerGenerated]
	private JsonConverter <Converter>k__BackingField; // 0x70
	[Nullable(2)]
	[CompilerGenerated]
	private JsonConverter <InternalConverter>k__BackingField; // 0x78
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Func<object> <DefaultCreator>k__BackingField; // 0x80
	[CompilerGenerated]
	private bool <DefaultCreatorNonPublic>k__BackingField; // 0x88

	// Properties
	public Type UnderlyingType { get; }
	public Type CreatedType { get; set; }
	public Nullable<bool> IsReference { get; set; }
	[Nullable(2)]
	public JsonConverter Converter { get; set; }
	[Nullable(2)]
	public JsonConverter InternalConverter { get; set; }
	public IList<SerializationCallback> OnDeserializedCallbacks { get; }
	public IList<SerializationCallback> OnDeserializingCallbacks { get; }
	public IList<SerializationCallback> OnSerializedCallbacks { get; }
	public IList<SerializationCallback> OnSerializingCallbacks { get; }
	public IList<SerializationErrorCallback> OnErrorCallbacks { get; }
	[Nullable(new[] { 2, 1 })]
	public Func<object> DefaultCreator { get; set; }
	public bool DefaultCreatorNonPublic { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19599D0 Offset: 0x19559D0 VA: 0x19599D0
	public Type get_UnderlyingType() { }

	// RVA: 0x19599D8 Offset: 0x19559D8 VA: 0x19599D8
	public Type get_CreatedType() { }

	// RVA: 0x1958AFC Offset: 0x1954AFC VA: 0x1958AFC
	public void set_CreatedType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x19599E0 Offset: 0x19559E0 VA: 0x19599E0
	public Nullable<bool> get_IsReference() { }

	[CompilerGenerated]
	// RVA: 0x19599E8 Offset: 0x19559E8 VA: 0x19599E8
	public void set_IsReference(Nullable<bool> value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x19599F0 Offset: 0x19559F0 VA: 0x19599F0
	public JsonConverter get_Converter() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x19599F8 Offset: 0x19559F8 VA: 0x19599F8
	public void set_Converter(JsonConverter value) { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1959A00 Offset: 0x1955A00 VA: 0x1959A00
	public JsonConverter get_InternalConverter() { }

	[NullableContext(2)]
	[CompilerGenerated]
	// RVA: 0x1959A08 Offset: 0x1955A08 VA: 0x1959A08
	internal void set_InternalConverter(JsonConverter value) { }

	// RVA: 0x1959A10 Offset: 0x1955A10 VA: 0x1959A10
	public IList<SerializationCallback> get_OnDeserializedCallbacks() { }

	// RVA: 0x1959A94 Offset: 0x1955A94 VA: 0x1959A94
	public IList<SerializationCallback> get_OnDeserializingCallbacks() { }

	// RVA: 0x1959B18 Offset: 0x1955B18 VA: 0x1959B18
	public IList<SerializationCallback> get_OnSerializedCallbacks() { }

	// RVA: 0x1959B9C Offset: 0x1955B9C VA: 0x1959B9C
	public IList<SerializationCallback> get_OnSerializingCallbacks() { }

	// RVA: 0x1959C20 Offset: 0x1955C20 VA: 0x1959C20
	public IList<SerializationErrorCallback> get_OnErrorCallbacks() { }

	[CompilerGenerated]
	// RVA: 0x1959CA4 Offset: 0x1955CA4 VA: 0x1959CA4
	public Func<object> get_DefaultCreator() { }

	[CompilerGenerated]
	// RVA: 0x1959CAC Offset: 0x1955CAC VA: 0x1959CAC
	public void set_DefaultCreator(Func<object> value) { }

	[CompilerGenerated]
	// RVA: 0x1959CB4 Offset: 0x1955CB4 VA: 0x1959CB4
	public bool get_DefaultCreatorNonPublic() { }

	[CompilerGenerated]
	// RVA: 0x1959CBC Offset: 0x1955CBC VA: 0x1959CBC
	public void set_DefaultCreatorNonPublic(bool value) { }

	// RVA: 0x19593D8 Offset: 0x19553D8 VA: 0x19593D8
	internal void .ctor(Type underlyingType) { }

	// RVA: 0x1959CC4 Offset: 0x1955CC4 VA: 0x1959CC4
	internal void InvokeOnSerializing(object o, StreamingContext context) { }

	// RVA: 0x1959E20 Offset: 0x1955E20 VA: 0x1959E20
	internal void InvokeOnSerialized(object o, StreamingContext context) { }

	// RVA: 0x1959F7C Offset: 0x1955F7C VA: 0x1959F7C
	internal void InvokeOnDeserializing(object o, StreamingContext context) { }

	// RVA: 0x195A0D8 Offset: 0x19560D8 VA: 0x195A0D8
	internal void InvokeOnDeserialized(object o, StreamingContext context) { }

	// RVA: 0x195A234 Offset: 0x1956234 VA: 0x195A234
	internal void InvokeOnError(object o, StreamingContext context, ErrorContext errorContext) { }

	// RVA: 0x195A398 Offset: 0x1956398 VA: 0x195A398
	internal static SerializationCallback CreateSerializationCallback(MethodInfo callbackMethodInfo) { }

	// RVA: 0x195A458 Offset: 0x1956458 VA: 0x195A458
	internal static SerializationErrorCallback CreateSerializationErrorCallback(MethodInfo callbackMethodInfo) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(2)]
[Nullable(0)]
public class JsonDictionaryContract : JsonContainerContract // TypeDefIndex: 6168
{
	// Fields
	[Nullable(new[] { 2, 1, 1 })]
	[CompilerGenerated]
	private Func<string, string> <DictionaryKeyResolver>k__BackingField; // 0xC0
	[CompilerGenerated]
	private readonly Type <DictionaryKeyType>k__BackingField; // 0xC8
	[CompilerGenerated]
	private readonly Type <DictionaryValueType>k__BackingField; // 0xD0
	[CompilerGenerated]
	private JsonContract <KeyContract>k__BackingField; // 0xD8
	private readonly Type _genericCollectionDefinitionType; // 0xE0
	private Type _genericWrapperType; // 0xE8
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _genericWrapperCreator; // 0xF0
	[Nullable(new[] { 2, 1 })]
	private Func<object> _genericTemporaryDictionaryCreator; // 0xF8
	[CompilerGenerated]
	private readonly bool <ShouldCreateWrapper>k__BackingField; // 0x100
	private readonly ConstructorInfo _parameterizedConstructor; // 0x108
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _overrideCreator; // 0x110
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _parameterizedCreator; // 0x118
	[CompilerGenerated]
	private bool <HasParameterizedCreator>k__BackingField; // 0x120

	// Properties
	[Nullable(new[] { 2, 1, 1 })]
	public Func<string, string> DictionaryKeyResolver { get; set; }
	public Type DictionaryKeyType { get; }
	public Type DictionaryValueType { get; }
	internal JsonContract KeyContract { get; set; }
	internal bool ShouldCreateWrapper { get; }
	[Nullable(new[] { 2, 1 })]
	internal ObjectConstructor<object> ParameterizedCreator { get; }
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> OverrideCreator { get; set; }
	public bool HasParameterizedCreator { get; set; }
	internal bool HasParameterizedCreatorInternal { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x195A758 Offset: 0x1956758 VA: 0x195A758
	public Func<string, string> get_DictionaryKeyResolver() { }

	[CompilerGenerated]
	// RVA: 0x195A760 Offset: 0x1956760 VA: 0x195A760
	public void set_DictionaryKeyResolver(Func<string, string> value) { }

	[CompilerGenerated]
	// RVA: 0x195A768 Offset: 0x1956768 VA: 0x195A768
	public Type get_DictionaryKeyType() { }

	[CompilerGenerated]
	// RVA: 0x195A770 Offset: 0x1956770 VA: 0x195A770
	public Type get_DictionaryValueType() { }

	[CompilerGenerated]
	// RVA: 0x195A778 Offset: 0x1956778 VA: 0x195A778
	internal JsonContract get_KeyContract() { }

	[CompilerGenerated]
	// RVA: 0x195A780 Offset: 0x1956780 VA: 0x195A780
	internal void set_KeyContract(JsonContract value) { }

	[CompilerGenerated]
	// RVA: 0x195A788 Offset: 0x1956788 VA: 0x195A788
	internal bool get_ShouldCreateWrapper() { }

	// RVA: 0x195A790 Offset: 0x1956790 VA: 0x195A790
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0x195A858 Offset: 0x1956858 VA: 0x195A858
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x195A860 Offset: 0x1956860 VA: 0x195A860
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	[CompilerGenerated]
	// RVA: 0x195A870 Offset: 0x1956870 VA: 0x195A870
	public bool get_HasParameterizedCreator() { }

	[CompilerGenerated]
	// RVA: 0x195A878 Offset: 0x1956878 VA: 0x195A878
	public void set_HasParameterizedCreator(bool value) { }

	// RVA: 0x195A880 Offset: 0x1956880 VA: 0x195A880
	internal bool get_HasParameterizedCreatorInternal() { }

	[NullableContext(1)]
	// RVA: 0x195A900 Offset: 0x1956900 VA: 0x195A900
	public void .ctor(Type underlyingType) { }

	[NullableContext(1)]
	// RVA: 0x195B348 Offset: 0x1957348 VA: 0x195B348
	internal IWrappedDictionary CreateWrapper(object dictionary) { }

	[NullableContext(1)]
	// RVA: 0x195B610 Offset: 0x1957610 VA: 0x195B610
	internal IDictionary CreateTemporaryDictionary() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class JsonDynamicContract : JsonContainerContract // TypeDefIndex: 6169
{
	// Fields
	[CompilerGenerated]
	private readonly JsonPropertyCollection <Properties>k__BackingField; // 0xC0
	[Nullable(new[] { 2, 1, 1 })]
	[CompilerGenerated]
	private Func<string, string> <PropertyNameResolver>k__BackingField; // 0xC8
	private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object>>> _callSiteGetters; // 0xD0
	[Nullable(new[] { 1, 1, 1, 1, 1, 1, 2, 1 })]
	private readonly ThreadSafeStore<string, CallSite<Func<CallSite, object, object, object>>> _callSiteSetters; // 0xD8

	// Properties
	public JsonPropertyCollection Properties { get; }
	[Nullable(new[] { 2, 1, 1 })]
	public Func<string, string> PropertyNameResolver { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x195B88C Offset: 0x195788C VA: 0x195B88C
	public JsonPropertyCollection get_Properties() { }

	[CompilerGenerated]
	// RVA: 0x195B894 Offset: 0x1957894 VA: 0x195B894
	public Func<string, string> get_PropertyNameResolver() { }

	[CompilerGenerated]
	// RVA: 0x195B89C Offset: 0x195789C VA: 0x195B89C
	public void set_PropertyNameResolver(Func<string, string> value) { }

	// RVA: 0x195B8A4 Offset: 0x19578A4 VA: 0x195B8A4
	private static CallSite<Func<CallSite, object, object>> CreateCallSiteGetter(string name) { }

	// RVA: 0x195B9BC Offset: 0x19579BC VA: 0x195B9BC
	private static CallSite<Func<CallSite, object, object, object>> CreateCallSiteSetter(string name) { }

	// RVA: 0x195BAD4 Offset: 0x1957AD4 VA: 0x195BAD4
	public void .ctor(Type underlyingType) { }

	// RVA: 0x195BE18 Offset: 0x1957E18 VA: 0x195BE18
	internal bool TryGetMember(IDynamicMetaObjectProvider dynamicProvider, string name, out object value) { }

	// RVA: 0x195BF28 Offset: 0x1957F28 VA: 0x195BF28
	internal bool TrySetMember(IDynamicMetaObjectProvider dynamicProvider, string name, object value) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class JsonFormatterConverter : IFormatterConverter // TypeDefIndex: 6170
{
	// Fields
	private readonly JsonSerializerInternalReader _reader; // 0x10
	private readonly JsonISerializableContract _contract; // 0x18
	[Nullable(2)]
	private readonly JsonProperty _member; // 0x20

	// Methods

	// RVA: 0x195C028 Offset: 0x1958028 VA: 0x195C028
	public void .ctor(JsonSerializerInternalReader reader, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: -1 Offset: -1
	private T GetTokenValue<T>(object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111AF08 Offset: 0x1116F08 VA: 0x111AF08
	|-JsonFormatterConverter.GetTokenValue<bool>
	|
	|-RVA: 0x111B0A8 Offset: 0x11170A8 VA: 0x111B0A8
	|-JsonFormatterConverter.GetTokenValue<int>
	|
	|-RVA: 0x111B248 Offset: 0x1117248 VA: 0x111B248
	|-JsonFormatterConverter.GetTokenValue<long>
	|
	|-RVA: 0x111B3E8 Offset: 0x11173E8 VA: 0x111B3E8
	|-JsonFormatterConverter.GetTokenValue<object>
	|
	|-RVA: 0x111B584 Offset: 0x1117584 VA: 0x111B584
	|-JsonFormatterConverter.GetTokenValue<float>
	|
	|-RVA: 0x111B724 Offset: 0x1117724 VA: 0x111B724
	|-JsonFormatterConverter.GetTokenValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x195C0F0 Offset: 0x19580F0 VA: 0x195C0F0 Slot: 4
	public object Convert(object value, Type type) { }

	// RVA: 0x195C32C Offset: 0x195832C VA: 0x195C32C Slot: 5
	public bool ToBoolean(object value) { }

	// RVA: 0x195C384 Offset: 0x1958384 VA: 0x195C384 Slot: 6
	public int ToInt32(object value) { }

	// RVA: 0x195C3DC Offset: 0x19583DC VA: 0x195C3DC Slot: 7
	public long ToInt64(object value) { }

	// RVA: 0x195C434 Offset: 0x1958434 VA: 0x195C434 Slot: 8
	public float ToSingle(object value) { }

	// RVA: 0x195C48C Offset: 0x195848C VA: 0x195C48C Slot: 9
	public string ToString(object value) { }
}

// Namespace: Newtonsoft.Json.Serialization
public class JsonISerializableContract : JsonContainerContract // TypeDefIndex: 6171
{
	// Fields
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private ObjectConstructor<object> <ISerializableCreator>k__BackingField; // 0xC0

	// Properties
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> ISerializableCreator { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x195C4E4 Offset: 0x19584E4 VA: 0x195C4E4
	public ObjectConstructor<object> get_ISerializableCreator() { }

	[CompilerGenerated]
	// RVA: 0x195C4EC Offset: 0x19584EC VA: 0x195C4EC
	public void set_ISerializableCreator(ObjectConstructor<object> value) { }

	[NullableContext(1)]
	// RVA: 0x195C4F4 Offset: 0x19584F4 VA: 0x195C4F4
	public void .ctor(Type underlyingType) { }
}

// Namespace: Newtonsoft.Json.Serialization
public class JsonLinqContract : JsonContract // TypeDefIndex: 6172
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x195C510 Offset: 0x1958510 VA: 0x195C510
	public void .ctor(Type underlyingType) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(2)]
[Nullable(0)]
public class JsonObjectContract : JsonContainerContract // TypeDefIndex: 6173
{
	// Fields
	[CompilerGenerated]
	private MemberSerialization <MemberSerialization>k__BackingField; // 0xBC
	[CompilerGenerated]
	private Nullable<MissingMemberHandling> <MissingMemberHandling>k__BackingField; // 0xC0
	[CompilerGenerated]
	private Nullable<Required> <ItemRequired>k__BackingField; // 0xC8
	[CompilerGenerated]
	private Nullable<NullValueHandling> <ItemNullValueHandling>k__BackingField; // 0xD0
	[Nullable(1)]
	[CompilerGenerated]
	private readonly JsonPropertyCollection <Properties>k__BackingField; // 0xD8
	[CompilerGenerated]
	private ExtensionDataSetter <ExtensionDataSetter>k__BackingField; // 0xE0
	[CompilerGenerated]
	private ExtensionDataGetter <ExtensionDataGetter>k__BackingField; // 0xE8
	[Nullable(new[] { 2, 1, 1 })]
	[CompilerGenerated]
	private Func<string, string> <ExtensionDataNameResolver>k__BackingField; // 0xF0
	internal bool ExtensionDataIsJToken; // 0xF8
	private Nullable<bool> _hasRequiredOrDefaultValueProperties; // 0xF9
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _overrideCreator; // 0x100
	[Nullable(new[] { 2, 1 })]
	private ObjectConstructor<object> _parameterizedCreator; // 0x108
	private JsonPropertyCollection _creatorParameters; // 0x110
	private Type _extensionDataValueType; // 0x118

	// Properties
	public MemberSerialization MemberSerialization { get; set; }
	public Nullable<MissingMemberHandling> MissingMemberHandling { get; set; }
	public Nullable<Required> ItemRequired { get; set; }
	public Nullable<NullValueHandling> ItemNullValueHandling { get; set; }
	[Nullable(1)]
	public JsonPropertyCollection Properties { get; }
	[Nullable(1)]
	public JsonPropertyCollection CreatorParameters { get; }
	[Nullable(new[] { 2, 1 })]
	public ObjectConstructor<object> OverrideCreator { get; set; }
	[Nullable(new[] { 2, 1 })]
	internal ObjectConstructor<object> ParameterizedCreator { get; set; }
	public ExtensionDataSetter ExtensionDataSetter { get; set; }
	public ExtensionDataGetter ExtensionDataGetter { get; set; }
	public Type ExtensionDataValueType { set; }
	[Nullable(new[] { 2, 1, 1 })]
	public Func<string, string> ExtensionDataNameResolver { get; set; }
	internal bool HasRequiredOrDefaultValueProperties { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x195C52C Offset: 0x195852C VA: 0x195C52C
	public MemberSerialization get_MemberSerialization() { }

	[CompilerGenerated]
	// RVA: 0x195C534 Offset: 0x1958534 VA: 0x195C534
	public void set_MemberSerialization(MemberSerialization value) { }

	[CompilerGenerated]
	// RVA: 0x195C53C Offset: 0x195853C VA: 0x195C53C
	public Nullable<MissingMemberHandling> get_MissingMemberHandling() { }

	[CompilerGenerated]
	// RVA: 0x195C544 Offset: 0x1958544 VA: 0x195C544
	public void set_MissingMemberHandling(Nullable<MissingMemberHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x195C54C Offset: 0x195854C VA: 0x195C54C
	public Nullable<Required> get_ItemRequired() { }

	[CompilerGenerated]
	// RVA: 0x195C554 Offset: 0x1958554 VA: 0x195C554
	public void set_ItemRequired(Nullable<Required> value) { }

	[CompilerGenerated]
	// RVA: 0x195C55C Offset: 0x195855C VA: 0x195C55C
	public Nullable<NullValueHandling> get_ItemNullValueHandling() { }

	[CompilerGenerated]
	// RVA: 0x195C564 Offset: 0x1958564 VA: 0x195C564
	public void set_ItemNullValueHandling(Nullable<NullValueHandling> value) { }

	[NullableContext(1)]
	[CompilerGenerated]
	// RVA: 0x195C56C Offset: 0x195856C VA: 0x195C56C
	public JsonPropertyCollection get_Properties() { }

	[NullableContext(1)]
	// RVA: 0x195C574 Offset: 0x1958574 VA: 0x195C574
	public JsonPropertyCollection get_CreatorParameters() { }

	// RVA: 0x195C5E8 Offset: 0x19585E8 VA: 0x195C5E8
	public ObjectConstructor<object> get_OverrideCreator() { }

	// RVA: 0x195C5F0 Offset: 0x19585F0 VA: 0x195C5F0
	public void set_OverrideCreator(ObjectConstructor<object> value) { }

	// RVA: 0x195C600 Offset: 0x1958600 VA: 0x195C600
	internal ObjectConstructor<object> get_ParameterizedCreator() { }

	// RVA: 0x195C608 Offset: 0x1958608 VA: 0x195C608
	internal void set_ParameterizedCreator(ObjectConstructor<object> value) { }

	[CompilerGenerated]
	// RVA: 0x195C618 Offset: 0x1958618 VA: 0x195C618
	public ExtensionDataSetter get_ExtensionDataSetter() { }

	[CompilerGenerated]
	// RVA: 0x195C620 Offset: 0x1958620 VA: 0x195C620
	public void set_ExtensionDataSetter(ExtensionDataSetter value) { }

	[CompilerGenerated]
	// RVA: 0x195C628 Offset: 0x1958628 VA: 0x195C628
	public ExtensionDataGetter get_ExtensionDataGetter() { }

	[CompilerGenerated]
	// RVA: 0x195C630 Offset: 0x1958630 VA: 0x195C630
	public void set_ExtensionDataGetter(ExtensionDataGetter value) { }

	// RVA: 0x195C638 Offset: 0x1958638 VA: 0x195C638
	public void set_ExtensionDataValueType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x195C704 Offset: 0x1958704 VA: 0x195C704
	public Func<string, string> get_ExtensionDataNameResolver() { }

	[CompilerGenerated]
	// RVA: 0x195C70C Offset: 0x195870C VA: 0x195C70C
	public void set_ExtensionDataNameResolver(Func<string, string> value) { }

	// RVA: 0x195C714 Offset: 0x1958714 VA: 0x195C714
	internal bool get_HasRequiredOrDefaultValueProperties() { }

	[NullableContext(1)]
	// RVA: 0x195CB1C Offset: 0x1958B1C VA: 0x195CB1C
	public void .ctor(Type underlyingType) { }

	[NullableContext(1)]
	// RVA: 0x195CBA0 Offset: 0x1958BA0 VA: 0x195CBA0
	internal object GetUninitializedObject() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class JsonPrimitiveContract : JsonContract // TypeDefIndex: 6174
{
	// Fields
	[CompilerGenerated]
	private PrimitiveTypeCode <TypeCode>k__BackingField; // 0x8C
	private static readonly Dictionary<Type, ReadType> ReadTypeMap; // 0x0

	// Properties
	internal PrimitiveTypeCode TypeCode { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x195CCA4 Offset: 0x1958CA4 VA: 0x195CCA4
	internal PrimitiveTypeCode get_TypeCode() { }

	[CompilerGenerated]
	// RVA: 0x195CCAC Offset: 0x1958CAC VA: 0x195CCAC
	internal void set_TypeCode(PrimitiveTypeCode value) { }

	// RVA: 0x195CCB4 Offset: 0x1958CB4 VA: 0x195CCB4
	public void .ctor(Type underlyingType) { }

	// RVA: 0x195CDAC Offset: 0x1958DAC VA: 0x195CDAC
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(2)]
[Nullable(0)]
public class JsonProperty // TypeDefIndex: 6175
{
	// Fields
	internal Nullable<Required> _required; // 0x10
	internal bool _hasExplicitDefaultValue; // 0x18
	private object _defaultValue; // 0x20
	private bool _hasGeneratedDefaultValue; // 0x28
	private string _propertyName; // 0x30
	internal bool _skipPropertyNameEscape; // 0x38
	private Type _propertyType; // 0x40
	[CompilerGenerated]
	private JsonContract <PropertyContract>k__BackingField; // 0x48
	[CompilerGenerated]
	private Type <DeclaringType>k__BackingField; // 0x50
	[CompilerGenerated]
	private Nullable<int> <Order>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <UnderlyingName>k__BackingField; // 0x60
	[CompilerGenerated]
	private IValueProvider <ValueProvider>k__BackingField; // 0x68
	[CompilerGenerated]
	private IAttributeProvider <AttributeProvider>k__BackingField; // 0x70
	[CompilerGenerated]
	private JsonConverter <Converter>k__BackingField; // 0x78
	[CompilerGenerated]
	private bool <Ignored>k__BackingField; // 0x80
	[CompilerGenerated]
	private bool <Readable>k__BackingField; // 0x81
	[CompilerGenerated]
	private bool <Writable>k__BackingField; // 0x82
	[CompilerGenerated]
	private bool <HasMemberAttribute>k__BackingField; // 0x83
	[CompilerGenerated]
	private Nullable<bool> <IsReference>k__BackingField; // 0x84
	[CompilerGenerated]
	private Nullable<NullValueHandling> <NullValueHandling>k__BackingField; // 0x88
	[CompilerGenerated]
	private Nullable<DefaultValueHandling> <DefaultValueHandling>k__BackingField; // 0x90
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ReferenceLoopHandling>k__BackingField; // 0x98
	[CompilerGenerated]
	private Nullable<ObjectCreationHandling> <ObjectCreationHandling>k__BackingField; // 0xA0
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <TypeNameHandling>k__BackingField; // 0xA8
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Predicate<object> <ShouldSerialize>k__BackingField; // 0xB0
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Predicate<object> <ShouldDeserialize>k__BackingField; // 0xB8
	[Nullable(new[] { 2, 1 })]
	[CompilerGenerated]
	private Predicate<object> <GetIsSpecified>k__BackingField; // 0xC0
	[Nullable(new[] { 2, 1, 2 })]
	[CompilerGenerated]
	private Action<object, object> <SetIsSpecified>k__BackingField; // 0xC8
	[CompilerGenerated]
	private JsonConverter <ItemConverter>k__BackingField; // 0xD0
	[CompilerGenerated]
	private Nullable<bool> <ItemIsReference>k__BackingField; // 0xD8
	[CompilerGenerated]
	private Nullable<TypeNameHandling> <ItemTypeNameHandling>k__BackingField; // 0xDC
	[CompilerGenerated]
	private Nullable<ReferenceLoopHandling> <ItemReferenceLoopHandling>k__BackingField; // 0xE4

	// Properties
	internal JsonContract PropertyContract { get; set; }
	public string PropertyName { get; set; }
	public Type DeclaringType { get; set; }
	public Nullable<int> Order { get; set; }
	public string UnderlyingName { get; set; }
	public IValueProvider ValueProvider { get; set; }
	public IAttributeProvider AttributeProvider { set; }
	public Type PropertyType { get; set; }
	public JsonConverter Converter { get; set; }
	public bool Ignored { get; set; }
	public bool Readable { get; set; }
	public bool Writable { get; set; }
	public bool HasMemberAttribute { get; set; }
	public object DefaultValue { get; set; }
	public Required Required { get; }
	public Nullable<bool> IsReference { get; set; }
	public Nullable<NullValueHandling> NullValueHandling { get; set; }
	public Nullable<DefaultValueHandling> DefaultValueHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ReferenceLoopHandling { get; set; }
	public Nullable<ObjectCreationHandling> ObjectCreationHandling { get; set; }
	public Nullable<TypeNameHandling> TypeNameHandling { get; set; }
	[Nullable(new[] { 2, 1 })]
	public Predicate<object> ShouldSerialize { get; set; }
	[Nullable(new[] { 2, 1 })]
	public Predicate<object> ShouldDeserialize { get; }
	[Nullable(new[] { 2, 1 })]
	public Predicate<object> GetIsSpecified { get; set; }
	[Nullable(new[] { 2, 1, 2 })]
	public Action<object, object> SetIsSpecified { get; set; }
	public JsonConverter ItemConverter { get; set; }
	public Nullable<bool> ItemIsReference { get; set; }
	public Nullable<TypeNameHandling> ItemTypeNameHandling { get; set; }
	public Nullable<ReferenceLoopHandling> ItemReferenceLoopHandling { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x195D074 Offset: 0x1959074 VA: 0x195D074
	internal JsonContract get_PropertyContract() { }

	[CompilerGenerated]
	// RVA: 0x195D07C Offset: 0x195907C VA: 0x195D07C
	internal void set_PropertyContract(JsonContract value) { }

	// RVA: 0x195D084 Offset: 0x1959084 VA: 0x195D084
	public string get_PropertyName() { }

	// RVA: 0x195D08C Offset: 0x195908C VA: 0x195D08C
	public void set_PropertyName(string value) { }

	[CompilerGenerated]
	// RVA: 0x195D124 Offset: 0x1959124 VA: 0x195D124
	public Type get_DeclaringType() { }

	[CompilerGenerated]
	// RVA: 0x195D12C Offset: 0x195912C VA: 0x195D12C
	public void set_DeclaringType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x195D134 Offset: 0x1959134 VA: 0x195D134
	public Nullable<int> get_Order() { }

	[CompilerGenerated]
	// RVA: 0x195D13C Offset: 0x195913C VA: 0x195D13C
	public void set_Order(Nullable<int> value) { }

	[CompilerGenerated]
	// RVA: 0x195D144 Offset: 0x1959144 VA: 0x195D144
	public string get_UnderlyingName() { }

	[CompilerGenerated]
	// RVA: 0x195D14C Offset: 0x195914C VA: 0x195D14C
	public void set_UnderlyingName(string value) { }

	[CompilerGenerated]
	// RVA: 0x195D154 Offset: 0x1959154 VA: 0x195D154
	public IValueProvider get_ValueProvider() { }

	[CompilerGenerated]
	// RVA: 0x195D15C Offset: 0x195915C VA: 0x195D15C
	public void set_ValueProvider(IValueProvider value) { }

	[CompilerGenerated]
	// RVA: 0x195D164 Offset: 0x1959164 VA: 0x195D164
	public void set_AttributeProvider(IAttributeProvider value) { }

	// RVA: 0x195D16C Offset: 0x195916C VA: 0x195D16C
	public Type get_PropertyType() { }

	// RVA: 0x195D174 Offset: 0x1959174 VA: 0x195D174
	public void set_PropertyType(Type value) { }

	[CompilerGenerated]
	// RVA: 0x195D1E0 Offset: 0x19591E0 VA: 0x195D1E0
	public JsonConverter get_Converter() { }

	[CompilerGenerated]
	// RVA: 0x195D1E8 Offset: 0x19591E8 VA: 0x195D1E8
	public void set_Converter(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x195D1F0 Offset: 0x19591F0 VA: 0x195D1F0
	public bool get_Ignored() { }

	[CompilerGenerated]
	// RVA: 0x195D1F8 Offset: 0x19591F8 VA: 0x195D1F8
	public void set_Ignored(bool value) { }

	[CompilerGenerated]
	// RVA: 0x195D200 Offset: 0x1959200 VA: 0x195D200
	public bool get_Readable() { }

	[CompilerGenerated]
	// RVA: 0x195D208 Offset: 0x1959208 VA: 0x195D208
	public void set_Readable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x195D210 Offset: 0x1959210 VA: 0x195D210
	public bool get_Writable() { }

	[CompilerGenerated]
	// RVA: 0x195D218 Offset: 0x1959218 VA: 0x195D218
	public void set_Writable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x195D220 Offset: 0x1959220 VA: 0x195D220
	public bool get_HasMemberAttribute() { }

	[CompilerGenerated]
	// RVA: 0x195D228 Offset: 0x1959228 VA: 0x195D228
	public void set_HasMemberAttribute(bool value) { }

	// RVA: 0x195D230 Offset: 0x1959230 VA: 0x195D230
	public object get_DefaultValue() { }

	// RVA: 0x195D248 Offset: 0x1959248 VA: 0x195D248
	public void set_DefaultValue(object value) { }

	// RVA: 0x195D258 Offset: 0x1959258 VA: 0x195D258
	internal object GetResolvedDefaultValue() { }

	// RVA: 0x195CAE0 Offset: 0x1958AE0 VA: 0x195CAE0
	public Required get_Required() { }

	[CompilerGenerated]
	// RVA: 0x195D320 Offset: 0x1959320 VA: 0x195D320
	public Nullable<bool> get_IsReference() { }

	[CompilerGenerated]
	// RVA: 0x195D328 Offset: 0x1959328 VA: 0x195D328
	public void set_IsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x195D330 Offset: 0x1959330 VA: 0x195D330
	public Nullable<NullValueHandling> get_NullValueHandling() { }

	[CompilerGenerated]
	// RVA: 0x195D338 Offset: 0x1959338 VA: 0x195D338
	public void set_NullValueHandling(Nullable<NullValueHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x195D340 Offset: 0x1959340 VA: 0x195D340
	public Nullable<DefaultValueHandling> get_DefaultValueHandling() { }

	[CompilerGenerated]
	// RVA: 0x195D348 Offset: 0x1959348 VA: 0x195D348
	public void set_DefaultValueHandling(Nullable<DefaultValueHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x195D350 Offset: 0x1959350 VA: 0x195D350
	public Nullable<ReferenceLoopHandling> get_ReferenceLoopHandling() { }

	[CompilerGenerated]
	// RVA: 0x195D358 Offset: 0x1959358 VA: 0x195D358
	public void set_ReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x195D360 Offset: 0x1959360 VA: 0x195D360
	public Nullable<ObjectCreationHandling> get_ObjectCreationHandling() { }

	[CompilerGenerated]
	// RVA: 0x195D368 Offset: 0x1959368 VA: 0x195D368
	public void set_ObjectCreationHandling(Nullable<ObjectCreationHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x195D370 Offset: 0x1959370 VA: 0x195D370
	public Nullable<TypeNameHandling> get_TypeNameHandling() { }

	[CompilerGenerated]
	// RVA: 0x195D378 Offset: 0x1959378 VA: 0x195D378
	public void set_TypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x195D380 Offset: 0x1959380 VA: 0x195D380
	public Predicate<object> get_ShouldSerialize() { }

	[CompilerGenerated]
	// RVA: 0x195D388 Offset: 0x1959388 VA: 0x195D388
	public void set_ShouldSerialize(Predicate<object> value) { }

	[CompilerGenerated]
	// RVA: 0x195D390 Offset: 0x1959390 VA: 0x195D390
	public Predicate<object> get_ShouldDeserialize() { }

	[CompilerGenerated]
	// RVA: 0x195D398 Offset: 0x1959398 VA: 0x195D398
	public Predicate<object> get_GetIsSpecified() { }

	[CompilerGenerated]
	// RVA: 0x195D3A0 Offset: 0x19593A0 VA: 0x195D3A0
	public void set_GetIsSpecified(Predicate<object> value) { }

	[CompilerGenerated]
	// RVA: 0x195D3A8 Offset: 0x19593A8 VA: 0x195D3A8
	public Action<object, object> get_SetIsSpecified() { }

	[CompilerGenerated]
	// RVA: 0x195D3B0 Offset: 0x19593B0 VA: 0x195D3B0
	public void set_SetIsSpecified(Action<object, object> value) { }

	[NullableContext(1)]
	// RVA: 0x195D3B8 Offset: 0x19593B8 VA: 0x195D3B8 Slot: 3
	public override string ToString() { }

	[CompilerGenerated]
	// RVA: 0x195D3DC Offset: 0x19593DC VA: 0x195D3DC
	public JsonConverter get_ItemConverter() { }

	[CompilerGenerated]
	// RVA: 0x195D3E4 Offset: 0x19593E4 VA: 0x195D3E4
	public void set_ItemConverter(JsonConverter value) { }

	[CompilerGenerated]
	// RVA: 0x195D3EC Offset: 0x19593EC VA: 0x195D3EC
	public Nullable<bool> get_ItemIsReference() { }

	[CompilerGenerated]
	// RVA: 0x195D3F4 Offset: 0x19593F4 VA: 0x195D3F4
	public void set_ItemIsReference(Nullable<bool> value) { }

	[CompilerGenerated]
	// RVA: 0x195D3FC Offset: 0x19593FC VA: 0x195D3FC
	public Nullable<TypeNameHandling> get_ItemTypeNameHandling() { }

	[CompilerGenerated]
	// RVA: 0x195D404 Offset: 0x1959404 VA: 0x195D404
	public void set_ItemTypeNameHandling(Nullable<TypeNameHandling> value) { }

	[CompilerGenerated]
	// RVA: 0x195D40C Offset: 0x195940C VA: 0x195D40C
	public Nullable<ReferenceLoopHandling> get_ItemReferenceLoopHandling() { }

	[CompilerGenerated]
	// RVA: 0x195D414 Offset: 0x1959414 VA: 0x195D414
	public void set_ItemReferenceLoopHandling(Nullable<ReferenceLoopHandling> value) { }

	[NullableContext(1)]
	// RVA: 0x195D41C Offset: 0x195941C VA: 0x195D41C
	internal void WritePropertyName(JsonWriter writer) { }

	// RVA: 0x195D474 Offset: 0x1959474 VA: 0x195D474
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(new[] { 0, 1, 1 })]
public class JsonPropertyCollection : KeyedCollection<string, JsonProperty> // TypeDefIndex: 6176
{
	// Fields
	private readonly Type _type; // 0x30
	private readonly List<JsonProperty> _list; // 0x38

	// Methods

	// RVA: 0x195BC98 Offset: 0x1957C98 VA: 0x195BC98
	public void .ctor(Type type) { }

	// RVA: 0x195D47C Offset: 0x195947C VA: 0x195D47C Slot: 39
	protected override string GetKeyForItem(JsonProperty item) { }

	// RVA: 0x195D490 Offset: 0x1959490 VA: 0x195D490
	public void AddProperty(JsonProperty property) { }

	// RVA: 0x195D740 Offset: 0x1959740 VA: 0x195D740
	public JsonProperty GetClosestMatchProperty(string propertyName) { }

	// RVA: 0x195D86C Offset: 0x195986C VA: 0x195D86C
	private bool TryGetProperty(string key, out JsonProperty item) { }

	// RVA: 0x195D780 Offset: 0x1959780 VA: 0x195D780
	public JsonProperty GetProperty(string propertyName, StringComparison comparisonType) { }
}

// Namespace: 
[NullableContext(0)]
private class JsonSerializerInternalBase.ReferenceEqualsEqualityComparer : IEqualityComparer<object> // TypeDefIndex: 6177
{
	// Methods

	[NullableContext(2)]
	// RVA: 0x195DFA4 Offset: 0x1959FA4 VA: 0x195DFA4 Slot: 4
	private bool System.Collections.Generic.IEqualityComparer<System.Object>.Equals(object x, object y) { }

	[NullableContext(1)]
	// RVA: 0x195DFB0 Offset: 0x1959FB0 VA: 0x195DFB0 Slot: 5
	private int System.Collections.Generic.IEqualityComparer<System.Object>.GetHashCode(object obj) { }

	// RVA: 0x195D9F0 Offset: 0x19599F0 VA: 0x195D9F0
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal abstract class JsonSerializerInternalBase // TypeDefIndex: 6178
{
	// Fields
	[Nullable(2)]
	private ErrorContext _currentErrorContext; // 0x10
	[Nullable(new[] { 2, 1, 1 })]
	private BidirectionalDictionary<string, object> _mappings; // 0x18
	internal readonly JsonSerializer Serializer; // 0x20
	[Nullable(2)]
	internal readonly ITraceWriter TraceWriter; // 0x28
	[Nullable(2)]
	protected JsonSerializerProxy InternalSerializer; // 0x30

	// Properties
	internal BidirectionalDictionary<string, object> DefaultReferenceMappings { get; }

	// Methods

	// RVA: 0x195D954 Offset: 0x1959954 VA: 0x195D954
	protected void .ctor(JsonSerializer serializer) { }

	// RVA: 0x1956C38 Offset: 0x1952C38 VA: 0x1956C38
	internal BidirectionalDictionary<string, object> get_DefaultReferenceMappings() { }

	// RVA: 0x195D9F8 Offset: 0x19599F8 VA: 0x195D9F8
	protected NullValueHandling ResolvedNullValueHandling(JsonObjectContract containerContract, JsonProperty property) { }

	// RVA: 0x195DA8C Offset: 0x1959A8C VA: 0x195DA8C
	private ErrorContext GetErrorContext(object currentObject, object member, string path, Exception error) { }

	// RVA: 0x195DB84 Offset: 0x1959B84 VA: 0x195DB84
	protected void ClearErrorContext() { }

	[NullableContext(2)]
	// RVA: 0x195DBE4 Offset: 0x1959BE4 VA: 0x195DBE4
	protected bool IsErrorHandled(object currentObject, JsonContract contract, object keyValue, IJsonLineInfo lineInfo, string path, Exception ex) { }
}

// Namespace: 
[NullableContext(0)]
internal enum JsonSerializerInternalReader.PropertyPresence // TypeDefIndex: 6179
{
	// Fields
	public int value__; // 0x0
	public const JsonSerializerInternalReader.PropertyPresence None = 0;
	public const JsonSerializerInternalReader.PropertyPresence Null = 1;
	public const JsonSerializerInternalReader.PropertyPresence Value = 2;
}

// Namespace: 
[NullableContext(2)]
[Nullable(0)]
internal class JsonSerializerInternalReader.CreatorPropertyContext // TypeDefIndex: 6180
{
	// Fields
	[Nullable(1)]
	public readonly string Name; // 0x10
	public JsonProperty Property; // 0x18
	public JsonProperty ConstructorProperty; // 0x20
	public Nullable<JsonSerializerInternalReader.PropertyPresence> Presence; // 0x28
	public object Value; // 0x30
	public bool Used; // 0x38

	// Methods

	[NullableContext(1)]
	// RVA: 0x196910C Offset: 0x196510C VA: 0x196910C
	public void .ctor(string name) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class JsonSerializerInternalReader.<>c // TypeDefIndex: 6181
{
	// Fields
	[Nullable(0)]
	public static readonly JsonSerializerInternalReader.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<JsonProperty, string> <>9__38_0; // 0x8
	[Nullable(new[] { 0, 0, 1 })]
	public static Func<JsonProperty, string> <>9__38_2; // 0x10
	[Nullable(0)]
	public static Func<JsonProperty, JsonProperty> <>9__42_0; // 0x18
	[Nullable(0)]
	public static Func<JsonProperty, JsonSerializerInternalReader.PropertyPresence> <>9__42_1; // 0x20

	// Methods

	// RVA: 0x1969B38 Offset: 0x1965B38 VA: 0x1969B38
	private static void .cctor() { }

	// RVA: 0x1969BA0 Offset: 0x1965BA0 VA: 0x1969BA0
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1969BA8 Offset: 0x1965BA8 VA: 0x1969BA8
	internal string <CreateObjectUsingCreatorWithParameters>b__38_0(JsonProperty p) { }

	[NullableContext(0)]
	// RVA: 0x1969BBC Offset: 0x1965BBC VA: 0x1969BBC
	internal string <CreateObjectUsingCreatorWithParameters>b__38_2(JsonProperty p) { }

	[NullableContext(0)]
	// RVA: 0x1969BD0 Offset: 0x1965BD0 VA: 0x1969BD0
	internal JsonProperty <PopulateObject>b__42_0(JsonProperty m) { }

	[NullableContext(0)]
	// RVA: 0x1969BD8 Offset: 0x1965BD8 VA: 0x1969BD8
	internal JsonSerializerInternalReader.PropertyPresence <PopulateObject>b__42_1(JsonProperty m) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JsonSerializerInternalReader.<>c__DisplayClass38_0 // TypeDefIndex: 6182
{
	// Fields
	[Nullable(0)]
	public JsonProperty property; // 0x10

	// Methods

	// RVA: 0x1969104 Offset: 0x1965104 VA: 0x1969104
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x1969BE0 Offset: 0x1965BE0 VA: 0x1969BE0
	internal bool <CreateObjectUsingCreatorWithParameters>b__1(JsonSerializerInternalReader.CreatorPropertyContext p) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 6183
{
	// Methods

	// RVA: 0x195DFBC Offset: 0x1959FBC VA: 0x195DFBC
	public void .ctor(JsonSerializer serializer) { }

	// RVA: 0x195DFC0 Offset: 0x1959FC0 VA: 0x195DFC0
	public void Populate(JsonReader reader, object target) { }

	[NullableContext(2)]
	// RVA: 0x195FEC8 Offset: 0x195BEC8 VA: 0x195FEC8
	private JsonContract GetContractSafe(Type type) { }

	// RVA: 0x195FF2C Offset: 0x195BF2C VA: 0x195FF2C
	private JsonContract GetContract(Type type) { }

	[NullableContext(2)]
	// RVA: 0x195FFDC Offset: 0x195BFDC VA: 0x195FFDC
	public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent) { }

	// RVA: 0x1960CAC Offset: 0x195CCAC VA: 0x1960CAC
	private JsonSerializerProxy GetInternalSerializer() { }

	[NullableContext(2)]
	// RVA: 0x1960D24 Offset: 0x195CD24 VA: 0x1960D24
	private JToken CreateJToken(JsonReader reader, JsonContract contract) { }

	// RVA: 0x19610F8 Offset: 0x195D0F8 VA: 0x19610F8
	private JToken CreateJObject(JsonReader reader) { }

	[NullableContext(2)]
	// RVA: 0x1960790 Offset: 0x195C790 VA: 0x1960790
	private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	[NullableContext(2)]
	// RVA: 0x1962B5C Offset: 0x195EB5C VA: 0x1962B5C
	private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s) { }

	// RVA: 0x1962C44 Offset: 0x195EC44 VA: 0x1962C44
	internal string GetExpectedDescription(JsonContract contract) { }

	[NullableContext(2)]
	// RVA: 0x196030C Offset: 0x195C30C VA: 0x196030C
	private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x1961534 Offset: 0x195D534 VA: 0x1961534
	private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue) { }

	[NullableContext(2)]
	// RVA: 0x1962CFC Offset: 0x195ECFC VA: 0x1962CFC
	private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	[NullableContext(2)]
	// RVA: 0x1963450 Offset: 0x195F450 VA: 0x1963450
	private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id) { }

	[NullableContext(2)]
	// RVA: 0x1964C18 Offset: 0x1960C18 VA: 0x1964C18
	private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName) { }

	// RVA: 0x1965230 Offset: 0x1961230 VA: 0x1965230
	private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract) { }

	[NullableContext(2)]
	// RVA: 0x1961F3C Offset: 0x195DF3C VA: 0x1961F3C
	private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id) { }

	[NullableContext(2)]
	// RVA: 0x19639FC Offset: 0x195F9FC VA: 0x19639FC
	private bool HasNoDefinedType(JsonContract contract) { }

	[NullableContext(2)]
	// RVA: 0x19625B8 Offset: 0x195E5B8 VA: 0x19625B8
	private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType) { }

	// RVA: 0x1965D30 Offset: 0x1961D30 VA: 0x1965D30
	private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target) { }

	[NullableContext(2)]
	// RVA: 0x19661A4 Offset: 0x19621A4 VA: 0x19661A4
	private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue, out bool ignoredValue) { }

	// RVA: 0x1966830 Offset: 0x1962830 VA: 0x1966830
	private void AddReference(JsonReader reader, string id, object value) { }

	// RVA: 0x1966824 Offset: 0x1962824 VA: 0x1966824
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	[NullableContext(2)]
	// RVA: 0x1966728 Offset: 0x1962728 VA: 0x1966728
	private bool ShouldSetPropertyValue(JsonProperty property, JsonObjectContract contract, object value) { }

	// RVA: 0x19653B0 Offset: 0x19613B0 VA: 0x19653B0
	private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x1963D04 Offset: 0x195FD04 VA: 0x1963D04
	private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x1966BF4 Offset: 0x1962BF4 VA: 0x1966BF4
	private void OnDeserializing(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x1966E20 Offset: 0x1962E20 VA: 0x1966E20
	private void OnDeserialized(JsonReader reader, JsonContract contract, object value) { }

	// RVA: 0x195EA2C Offset: 0x195AA2C VA: 0x195EA2C
	private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x1965640 Offset: 0x1961640 VA: 0x1965640
	private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x196704C Offset: 0x196304C VA: 0x196704C
	private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message) { }

	// RVA: 0x195E4E0 Offset: 0x195A4E0 VA: 0x195E4E0
	private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id) { }

	// RVA: 0x1964578 Offset: 0x1960578 VA: 0x1964578
	private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id) { }

	// RVA: 0x195C208 Offset: 0x1958208 VA: 0x195C208
	internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member) { }

	// RVA: 0x1963F38 Offset: 0x195FF38 VA: 0x1963F38
	private object CreateDynamic(JsonReader reader, JsonDynamicContract contract, JsonProperty member, string id) { }

	// RVA: 0x1967180 Offset: 0x1963180 VA: 0x1967180
	private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id) { }

	// RVA: 0x1960378 Offset: 0x195C378 VA: 0x1960378
	private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue) { }

	// RVA: 0x1968A5C Offset: 0x1964A5C VA: 0x1968A5C
	private List<JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType) { }

	// RVA: 0x1963AD8 Offset: 0x195FAD8 VA: 0x1963AD8
	public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator) { }

	// RVA: 0x195F44C Offset: 0x195B44C VA: 0x195F44C
	private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id) { }

	// RVA: 0x19697E4 Offset: 0x19657E4 VA: 0x19697E4
	private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target) { }

	// RVA: 0x1961418 Offset: 0x195D418 VA: 0x1961418
	private bool CheckPropertyName(JsonReader reader, string memberName) { }

	// RVA: 0x1969670 Offset: 0x1965670 VA: 0x1969670
	private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o) { }

	// RVA: 0x19695B4 Offset: 0x19655B4 VA: 0x19695B4
	private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader) { }

	// RVA: 0x196913C Offset: 0x196513C VA: 0x196913C
	private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue) { }

	// RVA: 0x1969A3C Offset: 0x1965A3C VA: 0x1969A3C
	private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, JsonSerializerInternalReader.PropertyPresence> requiredProperties) { }

	// RVA: 0x1960C44 Offset: 0x195CC44 VA: 0x1960C44
	private void HandleError(JsonReader reader, bool readPastError, int initialDepth) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 6184
{
	// Fields
	[Nullable(2)]
	private Type _rootType; // 0x38
	private int _rootLevel; // 0x40
	private readonly List<object> _serializeStack; // 0x48

	// Methods

	// RVA: 0x1969C00 Offset: 0x1965C00 VA: 0x1969C00
	public void .ctor(JsonSerializer serializer) { }

	[NullableContext(2)]
	// RVA: 0x1969C8C Offset: 0x1965C8C VA: 0x1969C8C
	public void Serialize(JsonWriter jsonWriter, object value, Type objectType) { }

	// RVA: 0x196AA74 Offset: 0x1966A74 VA: 0x196AA74
	private JsonSerializerProxy GetInternalSerializer() { }

	[NullableContext(2)]
	// RVA: 0x1969F48 Offset: 0x1965F48 VA: 0x1969F48
	private JsonContract GetContractSafe(object value) { }

	// RVA: 0x196AAEC Offset: 0x1966AEC VA: 0x196AAEC
	private JsonContract GetContract(object value) { }

	// RVA: 0x196ABB0 Offset: 0x1966BB0 VA: 0x196ABB0
	private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x196A378 Offset: 0x1966378 VA: 0x196A378
	private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x196DBA8 Offset: 0x1969BA8 VA: 0x196DBA8
	private Nullable<bool> ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x1969F58 Offset: 0x1965F58 VA: 0x1969F58
	private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x196DC64 Offset: 0x1969C64 VA: 0x196DC64
	private bool ShouldWriteProperty(object memberValue, JsonObjectContract containerContract, JsonProperty property) { }

	[NullableContext(2)]
	// RVA: 0x196DD40 Offset: 0x1969D40 VA: 0x196DD40
	private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x196A0FC Offset: 0x19660FC VA: 0x196A0FC
	private void WriteReference(JsonWriter writer, object value) { }

	// RVA: 0x196E18C Offset: 0x196A18C VA: 0x196E18C
	private string GetReference(JsonWriter writer, object value) { }

	// RVA: 0x196E378 Offset: 0x196A378 VA: 0x196E378
	internal static bool TryConvertToString(object value, Type type, out string s) { }

	// RVA: 0x196C69C Offset: 0x196869C VA: 0x196C69C
	private void SerializeString(JsonWriter writer, object value, JsonStringContract contract) { }

	// RVA: 0x196E488 Offset: 0x196A488 VA: 0x196E488
	private void OnSerializing(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x196E68C Offset: 0x196A68C VA: 0x196E68C
	private void OnSerialized(JsonWriter writer, JsonContract contract, object value) { }

	// RVA: 0x196B690 Offset: 0x1967690 VA: 0x196B690
	private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x196E9D4 Offset: 0x196A9D4 VA: 0x196E9D4
	private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue) { }

	// RVA: 0x196E890 Offset: 0x196A890 VA: 0x196E890
	private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x196F7DC Offset: 0x196B7DC VA: 0x196F7DC
	private bool HasCreatorParameter(JsonContainerContract contract, JsonProperty property) { }

	// RVA: 0x196F890 Offset: 0x196B890 VA: 0x196F890
	private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value) { }

	// RVA: 0x196AEEC Offset: 0x1966EEC VA: 0x196AEEC
	private void WriteTypeProperty(JsonWriter writer, Type type) { }

	// RVA: 0x196DD34 Offset: 0x1969D34 VA: 0x196DD34
	private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag) { }

	// RVA: 0x196DC58 Offset: 0x1969C58 VA: 0x196DC58
	private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag) { }

	// RVA: 0x196FADC Offset: 0x196BADC VA: 0x196FADC
	private bool HasFlag(TypeNameHandling value, TypeNameHandling flag) { }

	// RVA: 0x196B16C Offset: 0x196716C VA: 0x196B16C
	private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x196BDC0 Offset: 0x1967DC0 VA: 0x196BDC0
	private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x196C494 Offset: 0x1968494 VA: 0x196C494
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x196FD68 Offset: 0x196BD68 VA: 0x196FD68
	private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices) { }

	// RVA: 0x196FAE8 Offset: 0x196BAE8 VA: 0x196FAE8
	private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x196D730 Offset: 0x1969730 VA: 0x196D730
	private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x196CF88 Offset: 0x1968F88 VA: 0x196CF88
	private void SerializeDynamic(JsonWriter writer, IDynamicMetaObjectProvider value, JsonDynamicContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	[NullableContext(2)]
	// RVA: 0x19700EC Offset: 0x196C0EC VA: 0x19700EC
	private bool ShouldWriteDynamicProperty(object memberValue) { }

	[NullableContext(2)]
	// RVA: 0x196AD18 Offset: 0x1966D18 VA: 0x196AD18
	private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty) { }

	// RVA: 0x196C720 Offset: 0x1968720 VA: 0x196C720
	private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty) { }

	// RVA: 0x196EE2C Offset: 0x196AE2C VA: 0x196EE2C
	private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape) { }

	// RVA: 0x196AA00 Offset: 0x1966A00 VA: 0x196AA00
	private void HandleError(JsonWriter writer, int initialDepth) { }

	// RVA: 0x196F334 Offset: 0x196B334 VA: 0x196F334
	private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target) { }

	// RVA: 0x196F588 Offset: 0x196B588 VA: 0x196F588
	private bool IsSpecified(JsonWriter writer, JsonProperty property, object target) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class JsonSerializerProxy : JsonSerializer // TypeDefIndex: 6185
{
	// Fields
	[Nullable(2)]
	private readonly JsonSerializerInternalReader _serializerReader; // 0xE0
	[Nullable(2)]
	private readonly JsonSerializerInternalWriter _serializerWriter; // 0xE8
	internal readonly JsonSerializer _serializer; // 0xF0

	// Properties
	[Nullable(2)]
	public override IReferenceResolver ReferenceResolver { set; }
	[Nullable(2)]
	public override ITraceWriter TraceWriter { get; set; }
	[Nullable(2)]
	public override IEqualityComparer EqualityComparer { set; }
	public override JsonConverterCollection Converters { get; }
	public override DefaultValueHandling DefaultValueHandling { set; }
	public override IContractResolver ContractResolver { get; set; }
	public override MissingMemberHandling MissingMemberHandling { set; }
	public override NullValueHandling NullValueHandling { get; set; }
	public override ObjectCreationHandling ObjectCreationHandling { set; }
	public override ReferenceLoopHandling ReferenceLoopHandling { set; }
	public override PreserveReferencesHandling PreserveReferencesHandling { set; }
	public override TypeNameHandling TypeNameHandling { set; }
	public override MetadataPropertyHandling MetadataPropertyHandling { get; set; }
	public override TypeNameAssemblyFormatHandling TypeNameAssemblyFormatHandling { set; }
	public override ConstructorHandling ConstructorHandling { set; }
	public override ISerializationBinder SerializationBinder { set; }
	public override StreamingContext Context { get; set; }
	public override Formatting Formatting { get; }
	public override Nullable<int> MaxDepth { get; }
	public override bool CheckAdditionalContent { get; set; }

	// Methods

	// RVA: 0x19701A8 Offset: 0x196C1A8 VA: 0x19701A8 Slot: 4
	public override void add_Error(EventHandler<ErrorEventArgs> value) { }

	// RVA: 0x19701C4 Offset: 0x196C1C4 VA: 0x19701C4 Slot: 5
	public override void remove_Error(EventHandler<ErrorEventArgs> value) { }

	[NullableContext(2)]
	// RVA: 0x19701E0 Offset: 0x196C1E0 VA: 0x19701E0 Slot: 6
	public override void set_ReferenceResolver(IReferenceResolver value) { }

	[NullableContext(2)]
	// RVA: 0x19701FC Offset: 0x196C1FC VA: 0x19701FC Slot: 8
	public override ITraceWriter get_TraceWriter() { }

	[NullableContext(2)]
	// RVA: 0x1970218 Offset: 0x196C218 VA: 0x1970218 Slot: 9
	public override void set_TraceWriter(ITraceWriter value) { }

	[NullableContext(2)]
	// RVA: 0x1970234 Offset: 0x196C234 VA: 0x1970234 Slot: 10
	public override void set_EqualityComparer(IEqualityComparer value) { }

	// RVA: 0x1970250 Offset: 0x196C250 VA: 0x1970250 Slot: 23
	public override JsonConverterCollection get_Converters() { }

	// RVA: 0x1970270 Offset: 0x196C270 VA: 0x1970270 Slot: 18
	public override void set_DefaultValueHandling(DefaultValueHandling value) { }

	// RVA: 0x1970290 Offset: 0x196C290 VA: 0x1970290 Slot: 24
	public override IContractResolver get_ContractResolver() { }

	// RVA: 0x19702B0 Offset: 0x196C2B0 VA: 0x19702B0 Slot: 25
	public override void set_ContractResolver(IContractResolver value) { }

	// RVA: 0x19702D0 Offset: 0x196C2D0 VA: 0x19702D0 Slot: 15
	public override void set_MissingMemberHandling(MissingMemberHandling value) { }

	// RVA: 0x19702F0 Offset: 0x196C2F0 VA: 0x19702F0 Slot: 16
	public override NullValueHandling get_NullValueHandling() { }

	// RVA: 0x1970310 Offset: 0x196C310 VA: 0x1970310 Slot: 17
	public override void set_NullValueHandling(NullValueHandling value) { }

	// RVA: 0x1970330 Offset: 0x196C330 VA: 0x1970330 Slot: 19
	public override void set_ObjectCreationHandling(ObjectCreationHandling value) { }

	// RVA: 0x1970350 Offset: 0x196C350 VA: 0x1970350 Slot: 14
	public override void set_ReferenceLoopHandling(ReferenceLoopHandling value) { }

	// RVA: 0x1970370 Offset: 0x196C370 VA: 0x1970370 Slot: 13
	public override void set_PreserveReferencesHandling(PreserveReferencesHandling value) { }

	// RVA: 0x1970390 Offset: 0x196C390 VA: 0x1970390 Slot: 11
	public override void set_TypeNameHandling(TypeNameHandling value) { }

	// RVA: 0x19703AC Offset: 0x196C3AC VA: 0x19703AC Slot: 21
	public override MetadataPropertyHandling get_MetadataPropertyHandling() { }

	// RVA: 0x19703CC Offset: 0x196C3CC VA: 0x19703CC Slot: 22
	public override void set_MetadataPropertyHandling(MetadataPropertyHandling value) { }

	// RVA: 0x19703EC Offset: 0x196C3EC VA: 0x19703EC Slot: 12
	public override void set_TypeNameAssemblyFormatHandling(TypeNameAssemblyFormatHandling value) { }

	// RVA: 0x1970408 Offset: 0x196C408 VA: 0x1970408 Slot: 20
	public override void set_ConstructorHandling(ConstructorHandling value) { }

	// RVA: 0x1970428 Offset: 0x196C428 VA: 0x1970428 Slot: 7
	public override void set_SerializationBinder(ISerializationBinder value) { }

	// RVA: 0x1970444 Offset: 0x196C444 VA: 0x1970444 Slot: 26
	public override StreamingContext get_Context() { }

	// RVA: 0x1970464 Offset: 0x196C464 VA: 0x1970464 Slot: 27
	public override void set_Context(StreamingContext value) { }

	// RVA: 0x1970484 Offset: 0x196C484 VA: 0x1970484 Slot: 28
	public override Formatting get_Formatting() { }

	// RVA: 0x19704A4 Offset: 0x196C4A4 VA: 0x19704A4 Slot: 29
	public override Nullable<int> get_MaxDepth() { }

	// RVA: 0x19704C4 Offset: 0x196C4C4 VA: 0x19704C4 Slot: 30
	public override bool get_CheckAdditionalContent() { }

	// RVA: 0x19704E4 Offset: 0x196C4E4 VA: 0x19704E4 Slot: 31
	public override void set_CheckAdditionalContent(bool value) { }

	// RVA: 0x1970508 Offset: 0x196C508 VA: 0x1970508
	internal JsonSerializerInternalBase GetInternalSerializer() { }

	// RVA: 0x1970524 Offset: 0x196C524 VA: 0x1970524
	public void .ctor(JsonSerializerInternalReader serializerReader) { }

	// RVA: 0x19705B0 Offset: 0x196C5B0 VA: 0x19705B0
	public void .ctor(JsonSerializerInternalWriter serializerWriter) { }

	[NullableContext(2)]
	// RVA: 0x197063C Offset: 0x196C63C VA: 0x197063C Slot: 33
	internal override object DeserializeInternal(JsonReader reader, Type objectType) { }

	// RVA: 0x197066C Offset: 0x196C66C VA: 0x197066C Slot: 32
	internal override void PopulateInternal(JsonReader reader, object target) { }

	[NullableContext(2)]
	// RVA: 0x1970698 Offset: 0x196C698 VA: 0x1970698 Slot: 34
	internal override void SerializeInternal(JsonWriter jsonWriter, object value, Type rootType) { }
}

// Namespace: Newtonsoft.Json.Serialization
public class JsonStringContract : JsonPrimitiveContract // TypeDefIndex: 6186
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x19706C4 Offset: 0x196C6C4 VA: 0x19706C4
	public void .ctor(Type underlyingType) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class JsonTypeReflector.<>c // TypeDefIndex: 6187
{
	// Fields
	[Nullable(0)]
	public static readonly JsonTypeReflector.<>c <>9; // 0x0
	[Nullable(0)]
	public static Func<object, Type> <>9__22_1; // 0x8

	// Methods

	// RVA: 0x1971964 Offset: 0x196D964 VA: 0x1971964
	private static void .cctor() { }

	// RVA: 0x19719CC Offset: 0x196D9CC VA: 0x19719CC
	public void .ctor() { }

	[NullableContext(0)]
	// RVA: 0x19719D4 Offset: 0x196D9D4 VA: 0x19719D4
	internal Type <GetCreator>b__22_1(object param) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class JsonTypeReflector.<>c__DisplayClass22_0 // TypeDefIndex: 6188
{
	// Fields
	[Nullable(0)]
	public Type type; // 0x10
	[Nullable(new[] { 0, 1 })]
	public Func<object> defaultConstructor; // 0x18

	// Methods

	// RVA: 0x19712FC Offset: 0x196D2FC VA: 0x19712FC
	public void .ctor() { }

	// RVA: 0x1971A30 Offset: 0x196DA30 VA: 0x1971A30
	internal object <GetCreator>b__0(object[] parameters) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal static class JsonTypeReflector // TypeDefIndex: 6189
{
	// Fields
	private static Nullable<bool> _fullyTrusted; // 0x0
	[Nullable(new[] { 1, 1, 1, 2, 1, 1 })]
	private static readonly ThreadSafeStore<Type, Func<object[], object>> CreatorCache; // 0x8
	[Nullable(new[] { 1, 1, 2 })]
	private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache; // 0x10
	[Nullable(2)]
	private static ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18

	// Properties
	public static bool FullyTrusted { get; }
	public static ReflectionDelegateFactory ReflectionDelegateFactory { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T GetCachedAttribute<T>(object attributeProvider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111C1DC Offset: 0x11181DC VA: 0x111C1DC
	|-JsonTypeReflector.GetCachedAttribute<object>
	*/

	// RVA: 0x1970738 Offset: 0x196C738 VA: 0x1970738
	public static bool CanTypeDescriptorConvertString(Type type, out TypeConverter typeConverter) { }

	// RVA: 0x1970914 Offset: 0x196C914 VA: 0x1970914
	public static DataContractAttribute GetDataContractAttribute(Type type) { }

	// RVA: 0x19709D4 Offset: 0x196C9D4 VA: 0x19709D4
	public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo) { }

	// RVA: 0x1970C5C Offset: 0x196CC5C VA: 0x1970C5C
	public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute) { }

	// RVA: 0x1970DB0 Offset: 0x196CDB0 VA: 0x1970DB0
	public static JsonConverter GetJsonConverter(object attributeProvider) { }

	// RVA: 0x1970ED0 Offset: 0x196CED0 VA: 0x1970ED0
	public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] args) { }

	// RVA: 0x1970FC4 Offset: 0x196CFC4 VA: 0x1970FC4
	public static NamingStrategy CreateNamingStrategyInstance(Type namingStrategyType, object[] args) { }

	// RVA: 0x19710B8 Offset: 0x196D0B8 VA: 0x19710B8
	public static NamingStrategy GetContainerNamingStrategy(JsonContainerAttribute containerAttribute) { }

	// RVA: 0x1971178 Offset: 0x196D178 VA: 0x1971178
	private static Func<object[], object> GetCreator(Type type) { }

	// RVA: 0x197138C Offset: 0x196D38C VA: 0x197138C
	private static Type GetAssociatedMetadataType(Type type) { }

	// RVA: 0x197140C Offset: 0x196D40C VA: 0x197140C
	private static Type GetAssociateMetadataTypeFromAttribute(Type type) { }

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111C048 Offset: 0x1118048 VA: 0x111C048
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	private static T GetAttribute<T>(MemberInfo memberInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111BC98 Offset: 0x1117C98 VA: 0x111BC98
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: 0x1971650 Offset: 0x196D650 VA: 0x1971650
	public static bool IsNonSerializable(object provider) { }

	// RVA: 0x1970D34 Offset: 0x196CD34 VA: 0x1970D34
	public static bool IsSerializable(object provider) { }

	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(object provider) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111BF00 Offset: 0x1117F00 VA: 0x111BF00
	|-JsonTypeReflector.GetAttribute<object>
	*/

	// RVA: 0x19716CC Offset: 0x196D6CC VA: 0x19716CC
	public static bool get_FullyTrusted() { }

	// RVA: 0x1971304 Offset: 0x196D304 VA: 0x1971304
	public static ReflectionDelegateFactory get_ReflectionDelegateFactory() { }

	// RVA: 0x19717DC Offset: 0x196D7DC VA: 0x19717DC
	private static void .cctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
public class KebabCaseNamingStrategy : NamingStrategy // TypeDefIndex: 6190
{
	// Methods

	// RVA: 0x1971E60 Offset: 0x196DE60 VA: 0x1971E60
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0x1971E98 Offset: 0x196DE98 VA: 0x1971E98
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0x1971ED8 Offset: 0x196DED8 VA: 0x1971ED8
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x1971EE0 Offset: 0x196DEE0 VA: 0x1971EE0 Slot: 7
	protected override string ResolvePropertyName(string name) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public abstract class NamingStrategy // TypeDefIndex: 6191
{
	// Fields
	[CompilerGenerated]
	private bool <ProcessDictionaryKeys>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <ProcessExtensionDataNames>k__BackingField; // 0x11
	[CompilerGenerated]
	private bool <OverrideSpecifiedNames>k__BackingField; // 0x12

	// Properties
	public bool ProcessDictionaryKeys { get; set; }
	public bool ProcessExtensionDataNames { get; set; }
	public bool OverrideSpecifiedNames { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1971EEC Offset: 0x196DEEC VA: 0x1971EEC
	public bool get_ProcessDictionaryKeys() { }

	[CompilerGenerated]
	// RVA: 0x1971EF4 Offset: 0x196DEF4 VA: 0x1971EF4
	public void set_ProcessDictionaryKeys(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1971EFC Offset: 0x196DEFC VA: 0x1971EFC
	public bool get_ProcessExtensionDataNames() { }

	[CompilerGenerated]
	// RVA: 0x1971F04 Offset: 0x196DF04 VA: 0x1971F04
	public void set_ProcessExtensionDataNames(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1971F0C Offset: 0x196DF0C VA: 0x1971F0C
	public bool get_OverrideSpecifiedNames() { }

	[CompilerGenerated]
	// RVA: 0x1971F14 Offset: 0x196DF14 VA: 0x1971F14
	public void set_OverrideSpecifiedNames(bool value) { }

	// RVA: 0x1971F1C Offset: 0x196DF1C VA: 0x1971F1C Slot: 4
	public virtual string GetPropertyName(string name, bool hasSpecifiedName) { }

	// RVA: 0x1971F3C Offset: 0x196DF3C VA: 0x1971F3C Slot: 5
	public virtual string GetExtensionDataName(string name) { }

	// RVA: 0x1971F58 Offset: 0x196DF58 VA: 0x1971F58 Slot: 6
	public virtual string GetDictionaryKey(string key) { }

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract string ResolvePropertyName(string name);

	// RVA: 0x1971F74 Offset: 0x196DF74 VA: 0x1971F74 Slot: 2
	public override int GetHashCode() { }

	[NullableContext(2)]
	// RVA: 0x1972030 Offset: 0x196E030 VA: 0x1972030 Slot: 0
	public override bool Equals(object obj) { }

	[NullableContext(2)]
	// RVA: 0x19720B0 Offset: 0x196E0B0 VA: 0x19720B0
	protected bool Equals(NamingStrategy other) { }

	// RVA: 0x1971E90 Offset: 0x196DE90 VA: 0x1971E90
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json.Serialization
public sealed class ObjectConstructor<T> : MulticastDelegate // TypeDefIndex: 6192
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E976C Offset: 0x13E576C VA: 0x13E976C
	|-ObjectConstructor<object>..ctor
	|
	|-RVA: 0x13E9888 Offset: 0x13E5888 VA: 0x13E9888
	|-ObjectConstructor<__Il2CppFullySharedGenericType>..ctor
	*/

	[NullableContext(1)]
	// RVA: -1 Offset: -1 Slot: 12
	public virtual object Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13E9874 Offset: 0x13E5874 VA: 0x13E9874
	|-ObjectConstructor<object>.Invoke
	|
	|-RVA: 0x13E9990 Offset: 0x13E5990 VA: 0x13E9990
	|-ObjectConstructor<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Newtonsoft.Json.Serialization
[Usage(64, Inherited = False)]
public sealed class OnErrorAttribute : Attribute // TypeDefIndex: 6193
{}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class ReflectionAttributeProvider : IAttributeProvider // TypeDefIndex: 6194
{
	// Fields
	private readonly object _attributeProvider; // 0x10

	// Methods

	// RVA: 0x1972190 Offset: 0x196E190 VA: 0x1972190
	public void .ctor(object attributeProvider) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
public class ReflectionValueProvider : IValueProvider // TypeDefIndex: 6195
{
	// Fields
	private readonly MemberInfo _memberInfo; // 0x10

	// Methods

	// RVA: 0x1972204 Offset: 0x196E204 VA: 0x1972204
	public void .ctor(MemberInfo memberInfo) { }

	// RVA: 0x1972278 Offset: 0x196E278 VA: 0x1972278 Slot: 4
	public void SetValue(object target, object value) { }

	// RVA: 0x1972414 Offset: 0x196E414 VA: 0x1972414 Slot: 5
	public object GetValue(object target) { }
}

// Namespace: Newtonsoft.Json.Serialization
public class SnakeCaseNamingStrategy : NamingStrategy // TypeDefIndex: 6196
{
	// Methods

	// RVA: 0x19726AC Offset: 0x196E6AC VA: 0x19726AC
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames) { }

	// RVA: 0x19726DC Offset: 0x196E6DC VA: 0x19726DC
	public void .ctor(bool processDictionaryKeys, bool overrideSpecifiedNames, bool processExtensionDataNames) { }

	// RVA: 0x197271C Offset: 0x196E71C VA: 0x197271C
	public void .ctor() { }

	[NullableContext(1)]
	// RVA: 0x1972724 Offset: 0x196E724 VA: 0x1972724 Slot: 7
	protected override string ResolvePropertyName(string name) { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class TraceJsonReader : JsonReader, IJsonLineInfo // TypeDefIndex: 6197
{
	// Fields
	private readonly JsonReader _innerReader; // 0x78
	private readonly JsonTextWriter _textWriter; // 0x80
	private readonly StringWriter _sw; // 0x88

	// Properties
	public override int Depth { get; }
	public override string Path { get; }
	public override JsonToken TokenType { get; }
	[Nullable(2)]
	public override object Value { get; }
	[Nullable(2)]
	public override Type ValueType { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LineNumber { get; }
	private int Newtonsoft.Json.IJsonLineInfo.LinePosition { get; }

	// Methods

	// RVA: 0x1972730 Offset: 0x196E730 VA: 0x1972730
	public void .ctor(JsonReader innerReader) { }

	// RVA: 0x197289C Offset: 0x196E89C VA: 0x197289C
	public string GetDeserializedJsonMessage() { }

	// RVA: 0x19728B8 Offset: 0x196E8B8 VA: 0x19728B8 Slot: 10
	public override bool Read() { }

	// RVA: 0x197292C Offset: 0x196E92C VA: 0x197292C Slot: 11
	public override Nullable<int> ReadAsInt32() { }

	[NullableContext(2)]
	// RVA: 0x197296C Offset: 0x196E96C VA: 0x197296C Slot: 12
	public override string ReadAsString() { }

	[NullableContext(2)]
	// RVA: 0x19729AC Offset: 0x196E9AC VA: 0x19729AC Slot: 13
	public override byte[] ReadAsBytes() { }

	// RVA: 0x19729F0 Offset: 0x196E9F0 VA: 0x19729F0 Slot: 16
	public override Nullable<Decimal> ReadAsDecimal() { }

	// RVA: 0x1972A7C Offset: 0x196EA7C VA: 0x1972A7C Slot: 14
	public override Nullable<double> ReadAsDouble() { }

	// RVA: 0x1972AC8 Offset: 0x196EAC8 VA: 0x1972AC8 Slot: 15
	public override Nullable<bool> ReadAsBoolean() { }

	// RVA: 0x1972B0C Offset: 0x196EB0C VA: 0x1972B0C Slot: 17
	public override Nullable<DateTime> ReadAsDateTime() { }

	// RVA: 0x1972B58 Offset: 0x196EB58 VA: 0x1972B58 Slot: 18
	public override Nullable<DateTimeOffset> ReadAsDateTimeOffset() { }

	// RVA: 0x19728F8 Offset: 0x196E8F8 VA: 0x19728F8
	public void WriteCurrentToken() { }

	// RVA: 0x1972BB4 Offset: 0x196EBB4 VA: 0x1972BB4 Slot: 8
	public override int get_Depth() { }

	// RVA: 0x1972BD0 Offset: 0x196EBD0 VA: 0x1972BD0 Slot: 9
	public override string get_Path() { }

	// RVA: 0x1972BEC Offset: 0x196EBEC VA: 0x1972BEC Slot: 5
	public override JsonToken get_TokenType() { }

	[NullableContext(2)]
	// RVA: 0x1972C08 Offset: 0x196EC08 VA: 0x1972C08 Slot: 6
	public override object get_Value() { }

	[NullableContext(2)]
	// RVA: 0x1972C24 Offset: 0x196EC24 VA: 0x1972C24 Slot: 7
	public override Type get_ValueType() { }

	// RVA: 0x1972C40 Offset: 0x196EC40 VA: 0x1972C40 Slot: 20
	public override void Close() { }

	// RVA: 0x1972C60 Offset: 0x196EC60 VA: 0x1972C60 Slot: 21
	private bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { }

	// RVA: 0x1972D14 Offset: 0x196ED14 VA: 0x1972D14 Slot: 22
	private int Newtonsoft.Json.IJsonLineInfo.get_LineNumber() { }

	// RVA: 0x1972DCC Offset: 0x196EDCC VA: 0x1972DCC Slot: 23
	private int Newtonsoft.Json.IJsonLineInfo.get_LinePosition() { }
}

// Namespace: Newtonsoft.Json.Serialization
[NullableContext(1)]
[Nullable(0)]
internal class TraceJsonWriter : JsonWriter // TypeDefIndex: 6198
{
	// Fields
	private readonly JsonWriter _innerWriter; // 0x60
	private readonly JsonTextWriter _textWriter; // 0x68
	private readonly StringWriter _sw; // 0x70

	// Methods

	// RVA: 0x1972E84 Offset: 0x196EE84 VA: 0x1972E84
	public void .ctor(JsonWriter innerWriter) { }

	// RVA: 0x197308C Offset: 0x196F08C VA: 0x197308C
	public string GetSerializedJsonMessage() { }

	// RVA: 0x19730A8 Offset: 0x196F0A8 VA: 0x19730A8 Slot: 38
	public override void WriteValue(Decimal value) { }

	// RVA: 0x1973114 Offset: 0x196F114 VA: 0x1973114 Slot: 55
	public override void WriteValue(Nullable<Decimal> value) { }

	// RVA: 0x1973220 Offset: 0x196F220 VA: 0x1973220 Slot: 32
	public override void WriteValue(bool value) { }

	// RVA: 0x1973284 Offset: 0x196F284 VA: 0x1973284 Slot: 49
	public override void WriteValue(Nullable<bool> value) { }

	// RVA: 0x1973334 Offset: 0x196F334 VA: 0x1973334 Slot: 36
	public override void WriteValue(byte value) { }

	// RVA: 0x1973394 Offset: 0x196F394 VA: 0x1973394 Slot: 53
	public override void WriteValue(Nullable<byte> value) { }

	// RVA: 0x1973440 Offset: 0x196F440 VA: 0x1973440 Slot: 35
	public override void WriteValue(char value) { }

	// RVA: 0x19734A0 Offset: 0x196F4A0 VA: 0x19734A0 Slot: 52
	public override void WriteValue(Nullable<char> value) { }

	[NullableContext(2)]
	// RVA: 0x197354C Offset: 0x196F54C VA: 0x197354C Slot: 60
	public override void WriteValue(byte[] value) { }

	// RVA: 0x19735C0 Offset: 0x196F5C0 VA: 0x19735C0 Slot: 39
	public override void WriteValue(DateTime value) { }

	// RVA: 0x1973620 Offset: 0x196F620 VA: 0x1973620 Slot: 56
	public override void WriteValue(Nullable<DateTime> value) { }

	// RVA: 0x19736E0 Offset: 0x196F6E0 VA: 0x19736E0 Slot: 40
	public override void WriteValue(DateTimeOffset value) { }

	// RVA: 0x197374C Offset: 0x196F74C VA: 0x197374C Slot: 57
	public override void WriteValue(Nullable<DateTimeOffset> value) { }

	// RVA: 0x1973820 Offset: 0x196F820 VA: 0x1973820 Slot: 31
	public override void WriteValue(double value) { }

	// RVA: 0x1973880 Offset: 0x196F880 VA: 0x1973880 Slot: 48
	public override void WriteValue(Nullable<double> value) { }

	// RVA: 0x1973944 Offset: 0x196F944 VA: 0x1973944 Slot: 22
	public override void WriteUndefined() { }

	// RVA: 0x1973990 Offset: 0x196F990 VA: 0x1973990 Slot: 21
	public override void WriteNull() { }

	// RVA: 0x19739DC Offset: 0x196F9DC VA: 0x19739DC Slot: 30
	public override void WriteValue(float value) { }

	// RVA: 0x1973A3C Offset: 0x196FA3C VA: 0x1973A3C Slot: 47
	public override void WriteValue(Nullable<float> value) { }

	// RVA: 0x1973AEC Offset: 0x196FAEC VA: 0x1973AEC Slot: 41
	public override void WriteValue(Guid value) { }

	// RVA: 0x1973B58 Offset: 0x196FB58 VA: 0x1973B58 Slot: 58
	public override void WriteValue(Nullable<Guid> value) { }

	// RVA: 0x1973C30 Offset: 0x196FC30 VA: 0x1973C30 Slot: 26
	public override void WriteValue(int value) { }

	// RVA: 0x1973C90 Offset: 0x196FC90 VA: 0x1973C90 Slot: 43
	public override void WriteValue(Nullable<int> value) { }

	// RVA: 0x1973D3C Offset: 0x196FD3C VA: 0x1973D3C Slot: 28
	public override void WriteValue(long value) { }

	// RVA: 0x1973D9C Offset: 0x196FD9C VA: 0x1973D9C Slot: 45
	public override void WriteValue(Nullable<long> value) { }

	[NullableContext(2)]
	// RVA: 0x1973E5C Offset: 0x196FE5C VA: 0x1973E5C Slot: 62
	public override void WriteValue(object value) { }

	// RVA: 0x1973F54 Offset: 0x196FF54 VA: 0x1973F54 Slot: 37
	public override void WriteValue(sbyte value) { }

	// RVA: 0x1973FB4 Offset: 0x196FFB4 VA: 0x1973FB4 Slot: 54
	public override void WriteValue(Nullable<sbyte> value) { }

	// RVA: 0x1974060 Offset: 0x1970060 VA: 0x1974060 Slot: 33
	public override void WriteValue(short value) { }

	// RVA: 0x19740C0 Offset: 0x19700C0 VA: 0x19740C0 Slot: 50
	public override void WriteValue(Nullable<short> value) { }

	[NullableContext(2)]
	// RVA: 0x197416C Offset: 0x197016C VA: 0x197416C Slot: 25
	public override void WriteValue(string value) { }

	// RVA: 0x19741CC Offset: 0x19701CC VA: 0x19741CC Slot: 42
	public override void WriteValue(TimeSpan value) { }

	// RVA: 0x197422C Offset: 0x197022C VA: 0x197422C Slot: 59
	public override void WriteValue(Nullable<TimeSpan> value) { }

	// RVA: 0x19742EC Offset: 0x19702EC VA: 0x19742EC Slot: 27
	public override void WriteValue(uint value) { }

	// RVA: 0x197434C Offset: 0x197034C VA: 0x197434C Slot: 44
	public override void WriteValue(Nullable<uint> value) { }

	// RVA: 0x19743F8 Offset: 0x19703F8 VA: 0x19743F8 Slot: 29
	public override void WriteValue(ulong value) { }

	// RVA: 0x1974458 Offset: 0x1970458 VA: 0x1974458 Slot: 46
	public override void WriteValue(Nullable<ulong> value) { }

	[NullableContext(2)]
	// RVA: 0x1974518 Offset: 0x1970518 VA: 0x1974518 Slot: 61
	public override void WriteValue(Uri value) { }

	// RVA: 0x19745DC Offset: 0x19705DC VA: 0x19745DC Slot: 34
	public override void WriteValue(ushort value) { }

	// RVA: 0x197463C Offset: 0x197063C VA: 0x197463C Slot: 51
	public override void WriteValue(Nullable<ushort> value) { }

	[NullableContext(2)]
	// RVA: 0x19746E8 Offset: 0x19706E8 VA: 0x19746E8 Slot: 63
	public override void WriteComment(string text) { }

	// RVA: 0x1974748 Offset: 0x1970748 VA: 0x1974748 Slot: 9
	public override void WriteStartArray() { }

	// RVA: 0x197478C Offset: 0x197078C VA: 0x197478C Slot: 10
	public override void WriteEndArray() { }

	// RVA: 0x19747D0 Offset: 0x19707D0 VA: 0x19747D0 Slot: 11
	public override void WriteStartConstructor(string name) { }

	// RVA: 0x1974828 Offset: 0x1970828 VA: 0x1974828 Slot: 12
	public override void WriteEndConstructor() { }

	// RVA: 0x197486C Offset: 0x197086C VA: 0x197486C Slot: 13
	public override void WritePropertyName(string name) { }

	// RVA: 0x19748CC Offset: 0x19708CC VA: 0x19748CC Slot: 14
	public override void WritePropertyName(string name, bool escape) { }

	// RVA: 0x1974938 Offset: 0x1970938 VA: 0x1974938 Slot: 7
	public override void WriteStartObject() { }

	// RVA: 0x197497C Offset: 0x197097C VA: 0x197497C Slot: 8
	public override void WriteEndObject() { }

	[NullableContext(2)]
	// RVA: 0x19749C0 Offset: 0x19709C0 VA: 0x19749C0 Slot: 24
	public override void WriteRawValue(string json) { }

	[NullableContext(2)]
	// RVA: 0x1974A20 Offset: 0x1970A20 VA: 0x1974A20 Slot: 23
	public override void WriteRaw(string json) { }

	// RVA: 0x1974A80 Offset: 0x1970A80 VA: 0x1974A80 Slot: 6
	public override void Close() { }
}
