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

// Namespace: Unity.Properties.Internal
internal interface IAttributes // TypeDefIndex: 7924
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AddAttributes(IEnumerable<Attribute> attributes);
}

// Namespace: Unity.Properties.Internal
internal interface IPropertyBagRegister // TypeDefIndex: 7925
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Register();
}

// Namespace: 
internal struct PropertyBagStore.TypedStore<TContainer> // TypeDefIndex: 7926
{
	// Fields
	public static IPropertyBag<TContainer> PropertyBag; // 0x0
}

// Namespace: Unity.Properties.Internal
internal static class PropertyBagStore // TypeDefIndex: 7927
{
	// Fields
	private static readonly ConcurrentDictionary<Type, IPropertyBag> s_PropertyBags; // 0x0
	private static readonly List<Type> s_RegisteredTypes; // 0x8
	private static ReflectedPropertyBagProvider s_PropertyBagProvider; // 0x10

	// Properties
	private static ReflectedPropertyBagProvider ReflectedPropertyBagProvider { get; }

	// Methods

	// RVA: 0x1E9C038 Offset: 0x1E98038 VA: 0x1E9C038
	private static ReflectedPropertyBagProvider get_ReflectedPropertyBagProvider() { }

	// RVA: -1 Offset: -1
	internal static void AddPropertyBag<TContainer>(IPropertyBag<TContainer> propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113C50C Offset: 0x113850C VA: 0x113C50C
	|-PropertyBagStore.AddPropertyBag<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static IPropertyBag<TContainer> GetPropertyBag<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113C9E4 Offset: 0x11389E4 VA: 0x113C9E4
	|-PropertyBagStore.GetPropertyBag<object>
	|
	|-RVA: 0x113CB2C Offset: 0x1138B2C VA: 0x113CB2C
	|-PropertyBagStore.GetPropertyBag<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E9B8F8 Offset: 0x1E978F8 VA: 0x1E9B8F8
	internal static IPropertyBag GetPropertyBag(Type type) { }

	// RVA: 0x1E9C610 Offset: 0x1E98610 VA: 0x1E9C610
	private static void .cctor() { }
}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagAttribute : Attribute // TypeDefIndex: 7928
{
	// Methods

	// RVA: 0x1E9C714 Offset: 0x1E98714 VA: 0x1E9C714
	public void .ctor() { }
}

// Namespace: Unity.Properties.Internal
[ReflectedPropertyBag]
internal class ReflectedPropertyBag<TContainer> : ContainerPropertyBag<TContainer> // TypeDefIndex: 7929
{
	// Methods

	// RVA: -1 Offset: -1
	internal void AddProperty<TValue>(Property<TContainer, TValue> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10067B0 Offset: 0x10027B0 VA: 0x10067B0
	|-ReflectedPropertyBag<__Il2CppFullySharedGenericType>.AddProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143DE00 Offset: 0x1439E00 VA: 0x143DE00
	|-ReflectedPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ReflectedPropertyBagProvider.<>c // TypeDefIndex: 7930
{
	// Fields
	public static readonly ReflectedPropertyBagProvider.<>c <>9; // 0x0
	public static Func<MethodInfo, bool> <>9__10_0; // 0x8
	public static Func<MemberInfo, int> <>9__22_0; // 0x10

	// Methods

	// RVA: 0x1E9CA08 Offset: 0x1E98A08 VA: 0x1E9CA08
	private static void .cctor() { }

	// RVA: 0x1E9CA70 Offset: 0x1E98A70 VA: 0x1E9CA70
	public void .ctor() { }

	// RVA: 0x1E9CA78 Offset: 0x1E98A78 VA: 0x1E9CA78
	internal bool <.ctor>b__10_0(MethodInfo x) { }

	// RVA: 0x1E9CB00 Offset: 0x1E98B00 VA: 0x1E9CB00
	internal int <GetPropertyMembers>b__22_0(MemberInfo x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectedPropertyBagProvider.<GetPropertyMembers>d__22 : IEnumerable<MemberInfo>, IEnumerable, IEnumerator<MemberInfo>, IEnumerator, IDisposable // TypeDefIndex: 7931
{
	// Fields
	private int <>1__state; // 0x10
	private MemberInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x20
	private Type type; // 0x28
	public Type <>3__type; // 0x30
	private IOrderedEnumerable<MemberInfo> <members>5__1; // 0x38
	private IEnumerator<MemberInfo> <>s__2; // 0x40
	private MemberInfo <member>5__3; // 0x48
	private bool <hasDontCreatePropertyAttribute>5__4; // 0x50
	private bool <hasCreatePropertyAttribute>5__5; // 0x51
	private bool <hasNonSerializedAttribute>5__6; // 0x52
	private bool <hasSerializedFieldAttribute>5__7; // 0x53
	private bool <hasSerializeReferenceAttribute>5__8; // 0x54
	private FieldInfo <field>5__9; // 0x58

	// Properties
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1E9C79C Offset: 0x1E9879C VA: 0x1E9C79C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1E9CB24 Offset: 0x1E98B24 VA: 0x1E9CB24 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1E9CB40 Offset: 0x1E98B40 VA: 0x1E9CB40 Slot: 8
	private bool MoveNext() { }

	// RVA: 0x1E9D35C Offset: 0x1E9935C VA: 0x1E9D35C
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0x1E9D40C Offset: 0x1E9940C VA: 0x1E9D40C Slot: 6
	private MemberInfo System.Collections.Generic.IEnumerator<System.Reflection.MemberInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1E9D414 Offset: 0x1E99414 VA: 0x1E9D414 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1E9D44C Offset: 0x1E9944C VA: 0x1E9D44C Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1E9D454 Offset: 0x1E99454 VA: 0x1E9D454 Slot: 4
	private IEnumerator<MemberInfo> System.Collections.Generic.IEnumerable<System.Reflection.MemberInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1E9D4F8 Offset: 0x1E994F8 VA: 0x1E9D4F8 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Unity.Properties.Internal
internal class ReflectedPropertyBagProvider // TypeDefIndex: 7932
{
	// Fields
	private readonly MethodInfo m_CreatePropertyMethod; // 0x10
	private readonly MethodInfo m_CreatePropertyBagMethod; // 0x18
	private readonly MethodInfo m_CreateIndexedCollectionPropertyBagMethod; // 0x20
	private readonly MethodInfo m_CreateSetPropertyBagMethod; // 0x28
	private readonly MethodInfo m_CreateKeyValueCollectionPropertyBagMethod; // 0x30
	private readonly MethodInfo m_CreateKeyValuePairPropertyBagMethod; // 0x38
	private readonly MethodInfo m_CreateArrayPropertyBagMethod; // 0x40
	private readonly MethodInfo m_CreateListPropertyBagMethod; // 0x48
	private readonly MethodInfo m_CreateHashSetPropertyBagMethod; // 0x50
	private readonly MethodInfo m_CreateDictionaryPropertyBagMethod; // 0x58

	// Methods

	// RVA: 0x1E9C0E0 Offset: 0x1E980E0 VA: 0x1E9C0E0
	public void .ctor() { }

	// RVA: 0x1E9C4E0 Offset: 0x1E984E0 VA: 0x1E9C4E0
	public IPropertyBag CreatePropertyBag(Type type) { }

	// RVA: -1 Offset: -1
	public IPropertyBag<TContainer> CreatePropertyBag<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113F358 Offset: 0x113B358 VA: 0x113F358
	|-ReflectedPropertyBagProvider.CreatePropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private void CreateProperty<TContainer, TValue>(IMemberInfo member, ReflectedPropertyBag<TContainer> propertyBag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113F1F8 Offset: 0x113B1F8 VA: 0x113F1F8
	|-ReflectedPropertyBagProvider.CreateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TList> CreateIndexedCollectionPropertyBag<TList, TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113F0A8 Offset: 0x113B0A8 VA: 0x113F0A8
	|-ReflectedPropertyBagProvider.CreateIndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TSet> CreateSetPropertyBag<TSet, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1140454 Offset: 0x113C454 VA: 0x1140454
	|-ReflectedPropertyBagProvider.CreateSetPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TDictionary> CreateKeyValueCollectionPropertyBag<TDictionary, TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113F0FC Offset: 0x113B0FC VA: 0x113F0FC
	|-ReflectedPropertyBagProvider.CreateKeyValueCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<KeyValuePair<TKey, TValue>> CreateKeyValuePairPropertyBag<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113F150 Offset: 0x113B150 VA: 0x113F150
	|-ReflectedPropertyBagProvider.CreateKeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<TElement[]> CreateArrayPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113EFAC Offset: 0x113AFAC VA: 0x113EFAC
	|-ReflectedPropertyBagProvider.CreateArrayPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<List<TElement>> CreateListPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113F1A4 Offset: 0x113B1A4 VA: 0x113F1A4
	|-ReflectedPropertyBagProvider.CreateListPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<HashSet<TElement>> CreateHashSetPropertyBag<TElement>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113F054 Offset: 0x113B054 VA: 0x113F054
	|-ReflectedPropertyBagProvider.CreateHashSetPropertyBag<__Il2CppFullySharedGenericType>
	*/

	[Preserve]
	// RVA: -1 Offset: -1
	private IPropertyBag<Dictionary<TKey, TValue>> CreateDictionaryPropertyBag<TKey, TValue>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113F000 Offset: 0x113B000 VA: 0x113F000
	|-ReflectedPropertyBagProvider.CreateDictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	[IteratorStateMachine(typeof(ReflectedPropertyBagProvider.<GetPropertyMembers>d__22))]
	// RVA: 0x1E9C71C Offset: 0x1E9871C VA: 0x1E9C71C
	private static IEnumerable<MemberInfo> GetPropertyMembers(Type type) { }

	// RVA: 0x1E9C7D0 Offset: 0x1E987D0 VA: 0x1E9C7D0
	private static bool IsValidMember(MemberInfo memberInfo) { }

	// RVA: 0x1E9C914 Offset: 0x1E98914 VA: 0x1E9C914
	private static bool IsValidPropertyType(Type type) { }
}

// Namespace: Unity.Properties.Internal
internal static class ReflectionUtilities // TypeDefIndex: 7933
{
	// Methods

	// RVA: 0x1E9A578 Offset: 0x1E96578 VA: 0x1E9A578
	public static string SanitizeMemberName(MemberInfo info) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 7934
{}

// Namespace: 
internal class <Module> // TypeDefIndex: 7935
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 7936
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 7937
{
	// Methods

	// RVA: 0xFF1D48 Offset: 0xFEDD48 VA: 0xFF1D48
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0xFF1E38 Offset: 0xFEDE38 VA: 0xFF1E38
	public void .ctor() { }
}
