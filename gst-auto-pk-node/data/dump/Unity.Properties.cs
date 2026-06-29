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

// Namespace: Unity.Properties
[Usage(384)]
public class CreatePropertyAttribute : RequiredMemberAttribute // TypeDefIndex: 7877
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <ReadOnly>k__BackingField; // 0x10

	// Properties
	public bool ReadOnly { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E9A544 Offset: 0x1E96544 VA: 0x1E9A544
	public bool get_ReadOnly() { }
}

// Namespace: Unity.Properties
[Usage(256)]
public class DontCreatePropertyAttribute : Attribute // TypeDefIndex: 7878
{}

// Namespace: Unity.Properties
public sealed class PropertyGetter<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 7879
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140E148 Offset: 0x140A148 VA: 0x140E148
	|-PropertyGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TValue Invoke(ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140E1FC Offset: 0x140A1FC VA: 0x140E1FC
	|-PropertyGetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Unity.Properties
public sealed class PropertySetter<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 7880
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140E210 Offset: 0x140A210 VA: 0x140E210
	|-PropertySetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(ref TContainer container, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140E2C8 Offset: 0x140A2C8 VA: 0x140E2C8
	|-PropertySetter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Unity.Properties
public class DelegateProperty<TContainer, TValue> : Property<TContainer, TValue> // TypeDefIndex: 7881
{
	// Fields
	private readonly PropertyGetter<TContainer, TValue> m_Getter; // 0x0
	private readonly PropertySetter<TContainer, TValue> m_Setter; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <Name>k__BackingField; // 0x0

	// Properties
	public override string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1579114 Offset: 0x1575114 VA: 0x1579114
	|-DelegateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	public void .ctor(string name, PropertyGetter<TContainer, TValue> getter, PropertySetter<TContainer, TValue> setter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157911C Offset: 0x157511C VA: 0x157911C
	|-DelegateProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public interface IProperty // TypeDefIndex: 7882
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type DeclaredValueType();
}

// Namespace: Unity.Properties
public interface IProperty<TContainer> : IProperty // TypeDefIndex: 7883
{}

// Namespace: Unity.Properties
public abstract class Property<TContainer, TValue> : IProperty<TContainer>, IProperty, IAttributes // TypeDefIndex: 7884
{
	// Fields
	private List<Attribute> m_Attributes; // 0x0

	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_Name();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public Type DeclaredValueType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140E2DC Offset: 0x140A2DC VA: 0x140E2DC
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DeclaredValueType
	*/

	// RVA: -1 Offset: -1
	protected void AddAttributes(IEnumerable<Attribute> attributes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140E314 Offset: 0x140A314 VA: 0x140E314
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddAttributes
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void Unity.Properties.Internal.IAttributes.AddAttributes(IEnumerable<Attribute> attributes) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140E3B8 Offset: 0x140A3B8 VA: 0x140E3B8
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.Internal.IAttributes.AddAttributes
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool HasAttribute<TAttribute>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1006684 Offset: 0x1002684 VA: 0x1006684
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.HasAttribute<object>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public TAttribute GetAttribute<TAttribute>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1006560 Offset: 0x1002560 VA: 0x1006560
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140E724 Offset: 0x140A724 VA: 0x140E724
	|-Property<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
internal interface IMemberInfo // TypeDefIndex: 7885
{
	// Properties
	public abstract string Name { get; }
	public abstract bool IsReadOnly { get; }
	public abstract Type ValueType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Type get_ValueType();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract IEnumerable<Attribute> GetCustomAttributes();
}

// Namespace: Unity.Properties
[IsReadOnly]
internal struct FieldMember : IMemberInfo // TypeDefIndex: 7886
{
	// Fields
	internal readonly FieldInfo m_FieldInfo; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <Name>k__BackingField; // 0x8

	// Properties
	public string Name { get; }
	public bool IsReadOnly { get; }
	public Type ValueType { get; }

	// Methods

	// RVA: 0x1E9A54C Offset: 0x1E9654C VA: 0x1E9A54C
	public void .ctor(FieldInfo fieldInfo) { }

	[CompilerGenerated]
	// RVA: 0x1E9A66C Offset: 0x1E9666C VA: 0x1E9A66C Slot: 4
	public string get_Name() { }

	// RVA: 0x1E9A674 Offset: 0x1E96674 VA: 0x1E9A674 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x1E9A68C Offset: 0x1E9668C VA: 0x1E9A68C Slot: 6
	public Type get_ValueType() { }

	// RVA: 0x1E9A6AC Offset: 0x1E966AC VA: 0x1E9A6AC Slot: 7
	public IEnumerable<Attribute> GetCustomAttributes() { }
}

// Namespace: Unity.Properties
[IsReadOnly]
internal struct PropertyMember : IMemberInfo // TypeDefIndex: 7887
{
	// Fields
	internal readonly PropertyInfo m_PropertyInfo; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x8

	// Properties
	public string Name { get; }
	public bool IsReadOnly { get; }
	public Type ValueType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E9A6B8 Offset: 0x1E966B8 VA: 0x1E9A6B8 Slot: 4
	public string get_Name() { }

	// RVA: 0x1E9A6C0 Offset: 0x1E966C0 VA: 0x1E9A6C0 Slot: 5
	public bool get_IsReadOnly() { }

	// RVA: 0x1E9A6F0 Offset: 0x1E966F0 VA: 0x1E9A6F0 Slot: 6
	public Type get_ValueType() { }

	// RVA: 0x1E9A710 Offset: 0x1E96710 VA: 0x1E9A710
	public void .ctor(PropertyInfo propertyInfo) { }

	// RVA: 0x1E9A73C Offset: 0x1E9673C VA: 0x1E9A73C Slot: 7
	public IEnumerable<Attribute> GetCustomAttributes() { }
}

// Namespace: 
private sealed class ReflectedMemberProperty.GetStructValueAction<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 7888
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1270558 Offset: 0x126C558 VA: 0x1270558
	|-ReflectedMemberProperty.GetStructValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TValue Invoke(ref TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127060C Offset: 0x126C60C VA: 0x127060C
	|-ReflectedMemberProperty.GetStructValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private sealed class ReflectedMemberProperty.SetStructValueAction<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 7889
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1456CE4 Offset: 0x1452CE4 VA: 0x1456CE4
	|-ReflectedMemberProperty.SetStructValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(ref TContainer container, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1456D9C Offset: 0x1452D9C VA: 0x1456D9C
	|-ReflectedMemberProperty.SetStructValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private sealed class ReflectedMemberProperty.GetClassValueAction<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 7890
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12702AC Offset: 0x126C2AC VA: 0x12702AC
	|-ReflectedMemberProperty.GetClassValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TValue Invoke(TContainer container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12703B8 Offset: 0x126C3B8 VA: 0x12703B8
	|-ReflectedMemberProperty.GetClassValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private sealed class ReflectedMemberProperty.SetClassValueAction<TContainer, TValue> : MulticastDelegate // TypeDefIndex: 7891
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1456A04 Offset: 0x1452A04 VA: 0x1456A04
	|-ReflectedMemberProperty.SetClassValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(TContainer container, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1456B14 Offset: 0x1452B14 VA: 0x1456B14
	|-ReflectedMemberProperty.SetClassValueAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Unity.Properties
public class ReflectedMemberProperty<TContainer, TValue> : Property<TContainer, TValue> // TypeDefIndex: 7892
{
	// Fields
	private readonly IMemberInfo m_Info; // 0x0
	private readonly bool m_IsStructContainerType; // 0x0
	private ReflectedMemberProperty.GetStructValueAction<TContainer, TValue> m_GetStructValueAction; // 0x0
	private ReflectedMemberProperty.SetStructValueAction<TContainer, TValue> m_SetStructValueAction; // 0x0
	private ReflectedMemberProperty.GetClassValueAction<TContainer, TValue> m_GetClassValueAction; // 0x0
	private ReflectedMemberProperty.SetClassValueAction<TContainer, TValue> m_SetClassValueAction; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly bool <IsReadOnly>k__BackingField; // 0x0

	// Properties
	public override string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143D7A8 Offset: 0x14397A8 VA: 0x143D7A8
	|-ReflectedMemberProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(IMemberInfo info, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143D7B0 Offset: 0x14397B0 VA: 0x143D7B0
	|-ReflectedMemberProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public sealed class ArrayPropertyBag<TElement> : IndexedCollectionPropertyBag<TElement[], TElement> // TypeDefIndex: 7893
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x117ADCC Offset: 0x1176DCC VA: 0x117ADCC
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override TElement[] InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x117ADD4 Offset: 0x1176DD4 VA: 0x117ADD4
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override TElement[] Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x117AE04 Offset: 0x1176E04 VA: 0x117AE04
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x117AE18 Offset: 0x1176E18 VA: 0x117AE18
	|-ArrayPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public abstract class ContainerPropertyBag<TContainer> : PropertyBag<TContainer> // TypeDefIndex: 7894
{
	// Fields
	private readonly List<IProperty<TContainer>> m_PropertiesList; // 0x0
	private readonly Dictionary<string, IProperty<TContainer>> m_PropertiesHash; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1576B24 Offset: 0x1572B24 VA: 0x1576B24
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	protected void AddProperty<TValue>(Property<TContainer, TValue> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1004D50 Offset: 0x1000D50 VA: 0x1004D50
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>.AddProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer> property) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1576C00 Offset: 0x1572C00 VA: 0x1576C00
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>.TryGetProperty
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1576C4C Offset: 0x1572C4C VA: 0x1576C4C
	|-ContainerPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class DictionaryPropertyBag<TKey, TValue> : KeyValueCollectionPropertyBag<Dictionary<TKey, TValue>, TKey, TValue> // TypeDefIndex: 7895
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157D258 Offset: 0x1579258 VA: 0x157D258
	|-DictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override Dictionary<TKey, TValue> Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157D260 Offset: 0x1579260 VA: 0x157D260
	|-DictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x157D2AC Offset: 0x15792AC VA: 0x157D2AC
	|-DictionaryPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class HashSetPropertyBag<TElement> : SetPropertyBagBase<HashSet<TElement>, TElement> // TypeDefIndex: 7896
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127158C Offset: 0x126D58C VA: 0x127158C
	|-HashSetPropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override HashSet<TElement> Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1271594 Offset: 0x126D594 VA: 0x1271594
	|-HashSetPropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12715E0 Offset: 0x126D5E0 VA: 0x12715E0
	|-HashSetPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public interface IPropertyBag // TypeDefIndex: 7897
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Accept(ITypeVisitor visitor);
}

// Namespace: Unity.Properties
public interface IPropertyBag<TContainer> : IPropertyBag // TypeDefIndex: 7898
{}

// Namespace: 
private class IndexedCollectionPropertyBag.ListElementProperty<TList, TElement> : Property<TList, TElement> // TypeDefIndex: 7899
{
	// Fields
	internal int m_Index; // 0x0

	// Properties
	public int Index { get; }
	public override string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Index() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F26B8 Offset: 0x12EE6B8 VA: 0x12F26B8
	|-IndexedCollectionPropertyBag.ListElementProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Index
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F26C0 Offset: 0x12EE6C0 VA: 0x12F26C0
	|-IndexedCollectionPropertyBag.ListElementProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F26F4 Offset: 0x12EE6F4 VA: 0x12F26F4
	|-IndexedCollectionPropertyBag.ListElementProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class IndexedCollectionPropertyBag<TList, TElement> : PropertyBag<TList>, IPropertyBag<TList>, IPropertyBag, IConstructorWithCount<TList>, IConstructor // TypeDefIndex: 7900
{
	// Fields
	private readonly IndexedCollectionPropertyBag.ListElementProperty<TList, TElement> m_Property; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 10
	private TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C6F8 Offset: 0x12786F8 VA: 0x127C6F8
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected virtual TList InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C7A4 Offset: 0x12787A4 VA: 0x127C7A4
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C7C4 Offset: 0x12787C4 VA: 0x127C7C4
	|-IndexedCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class KeyValueCollectionPropertyBag.KeyValuePairProperty<TDictionary, TKey, TValue> : Property<TDictionary, KeyValuePair<TKey, TValue>> // TypeDefIndex: 7901
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TKey <Key>k__BackingField; // 0x0

	// Properties
	public override string Name { get; }
	public TKey Key { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E0658 Offset: 0x12DC658 VA: 0x12E0658
	|-KeyValueCollectionPropertyBag.KeyValuePairProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 9
	public TKey get_Key() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E07A8 Offset: 0x12DC7A8 VA: 0x12E07A8
	|-KeyValueCollectionPropertyBag.KeyValuePairProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Key
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E07E8 Offset: 0x12DC7E8 VA: 0x12E07E8
	|-KeyValueCollectionPropertyBag.KeyValuePairProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class KeyValueCollectionPropertyBag<TDictionary, TKey, TValue> : PropertyBag<TDictionary>, IPropertyBag<TDictionary>, IPropertyBag // TypeDefIndex: 7902
{
	// Fields
	private readonly KeyValueCollectionPropertyBag.KeyValuePairProperty<TDictionary, TKey, TValue> m_KeyValuePairProperty; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E05AC Offset: 0x12DC5AC VA: 0x12E05AC
	|-KeyValueCollectionPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class KeyValuePairPropertyBag.<>c<TKey, TValue> // TypeDefIndex: 7903
{
	// Fields
	public static readonly KeyValuePairPropertyBag.<>c<TKey, TValue> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1153450 Offset: 0x114F450 VA: 0x1153450
	|-KeyValuePairPropertyBag.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115355C Offset: 0x114F55C VA: 0x115355C
	|-KeyValuePairPropertyBag.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal TKey <.cctor>b__7_0(ref KeyValuePair<TKey, TValue> container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1153564 Offset: 0x114F564 VA: 0x1153564
	|-KeyValuePairPropertyBag.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<.cctor>b__7_0
	*/

	// RVA: -1 Offset: -1
	internal TValue <.cctor>b__7_1(ref KeyValuePair<TKey, TValue> container) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1153604 Offset: 0x114F604 VA: 0x1153604
	|-KeyValuePairPropertyBag.<>c<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<.cctor>b__7_1
	*/
}

// Namespace: Unity.Properties
public class KeyValuePairPropertyBag<TKey, TValue> : PropertyBag<KeyValuePair<TKey, TValue>> // TypeDefIndex: 7904
{
	// Fields
	private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TKey> s_KeyProperty; // 0x0
	private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TValue> s_ValueProperty; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E07FC Offset: 0x12DC7FC VA: 0x12E07FC
	|-KeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12E0860 Offset: 0x12DC860 VA: 0x12E0860
	|-KeyValuePairPropertyBag<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.Properties
public class ListPropertyBag<TElement> : IndexedCollectionPropertyBag<List<TElement>, TElement> // TypeDefIndex: 7905
{
	// Properties
	protected override InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	protected override InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F2708 Offset: 0x12EE708 VA: 0x12F2708
	|-ListPropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override List<TElement> InstantiateWithCount(int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F2710 Offset: 0x12EE710 VA: 0x12F2710
	|-ListPropertyBag<__Il2CppFullySharedGenericType>.InstantiateWithCount
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override List<TElement> Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F276C Offset: 0x12EE76C VA: 0x12F276C
	|-ListPropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12F27B8 Offset: 0x12EE7B8 VA: 0x12F27B8
	|-ListPropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public abstract class PropertyBag<TContainer> : IPropertyBag<TContainer>, IPropertyBag, IPropertyBagRegister, IConstructor<TContainer>, IConstructor // TypeDefIndex: 7906
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly InstantiationKind <InstantiationKind>k__BackingField; // 0x0

	// Properties
	private InstantiationKind Unity.Properties.IConstructor.InstantiationKind { get; }
	protected virtual InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140DE50 Offset: 0x1409E50 VA: 0x140DE50
	|-PropertyBag<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private void Unity.Properties.Internal.IPropertyBagRegister.Register() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140DF2C Offset: 0x1409F2C VA: 0x140DF2C
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.Internal.IPropertyBagRegister.Register
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Accept(ITypeVisitor visitor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140DF9C Offset: 0x1409F9C VA: 0x140DF9C
	|-PropertyBag<__Il2CppFullySharedGenericType>.Accept
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private InstantiationKind Unity.Properties.IConstructor.get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140E06C Offset: 0x140A06C VA: 0x140E06C
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.IConstructor.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private TContainer Unity.Properties.IConstructor<TContainer>.Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140E078 Offset: 0x140A078 VA: 0x140E078
	|-PropertyBag<__Il2CppFullySharedGenericType>.Unity.Properties.IConstructor<TContainer>.Instantiate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	protected virtual InstantiationKind get_InstantiationKind() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140E118 Offset: 0x140A118 VA: 0x140E118
	|-PropertyBag<__Il2CppFullySharedGenericType>.get_InstantiationKind
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual TContainer Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140E120 Offset: 0x140A120 VA: 0x140E120
	|-PropertyBag<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x140E13C Offset: 0x140A13C VA: 0x140E13C
	|-PropertyBag<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private class SetPropertyBagBase.SetElementProperty<TSet, TElement> : Property<TSet, TElement> // TypeDefIndex: 7907
{
	// Fields
	internal TElement m_Value; // 0x0

	// Properties
	public override string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	public override string get_Name() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1456B28 Offset: 0x1452B28 VA: 0x1456B28
	|-SetPropertyBagBase.SetElementProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Name
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1456C24 Offset: 0x1452C24 VA: 0x1456C24
	|-SetPropertyBagBase.SetElementProperty<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public class SetPropertyBagBase<TSet, TElement> : PropertyBag<TSet>, IPropertyBag<TSet>, IPropertyBag // TypeDefIndex: 7908
{
	// Fields
	private readonly SetPropertyBagBase.SetElementProperty<TSet, TElement> m_Property; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1456C38 Offset: 0x1452C38 VA: 0x1456C38
	|-SetPropertyBagBase<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Unity.Properties
public interface ITypeVisitor // TypeDefIndex: 7909
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Visit<TContainer>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ITypeVisitor.Visit<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Unity.Properties
public static class TypeTraits // TypeDefIndex: 7910
{
	// Methods

	// RVA: 0x1E9A748 Offset: 0x1E96748 VA: 0x1E9A748
	public static bool IsContainer(Type type) { }
}

// Namespace: Unity.Properties
public static class TypeTraits<T> // TypeDefIndex: 7911
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsValueType>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsPrimitive>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsInterface>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsAbstract>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsArray>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsMultidimensionalArray>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsEnum>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsEnumFlags>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsNullable>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsObject>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsString>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsContainer>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <CanBeNull>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static readonly bool <IsPrimitiveOrString>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsAbstractOrInterface>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsUnityObject>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static readonly bool <IsLazyLoadReference>k__BackingField; // 0x0

	// Properties
	public static bool IsValueType { get; }
	public static bool IsPrimitive { get; }
	public static bool IsInterface { get; }
	public static bool IsAbstract { get; }
	public static bool IsArray { get; }
	public static bool IsEnum { get; }
	public static bool IsNullable { get; }
	public static bool IsObject { get; }
	public static bool IsString { get; }
	public static bool IsContainer { get; }
	public static bool CanBeNull { get; }
	public static bool IsAbstractOrInterface { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsValueType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1493618 Offset: 0x148F618 VA: 0x1493618
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsValueType
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsPrimitive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1493694 Offset: 0x148F694 VA: 0x1493694
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsPrimitive
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsInterface() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1493710 Offset: 0x148F710 VA: 0x1493710
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsInterface
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsAbstract() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149378C Offset: 0x148F78C VA: 0x149378C
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsAbstract
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1493808 Offset: 0x148F808 VA: 0x1493808
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsArray
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsEnum() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1493884 Offset: 0x148F884 VA: 0x1493884
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsEnum
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsNullable() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1493900 Offset: 0x148F900 VA: 0x1493900
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsNullable
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149397C Offset: 0x148F97C VA: 0x149397C
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsObject
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsString() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14939F8 Offset: 0x148F9F8 VA: 0x14939F8
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsString
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsContainer() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1493A74 Offset: 0x148FA74 VA: 0x1493A74
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsContainer
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_CanBeNull() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1493AF0 Offset: 0x148FAF0 VA: 0x1493AF0
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_CanBeNull
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public static bool get_IsAbstractOrInterface() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1493B6C Offset: 0x148FB6C VA: 0x1493B6C
	|-TypeTraits<__Il2CppFullySharedGenericType>.get_IsAbstractOrInterface
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1493BE8 Offset: 0x148FBE8 VA: 0x1493BE8
	|-TypeTraits<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: Unity.Properties
public enum InstantiationKind // TypeDefIndex: 7912
{
	// Fields
	public int value__; // 0x0
	public const InstantiationKind Activator = 0;
	public const InstantiationKind PropertyBagOverride = 1;
	public const InstantiationKind NotInstantiatable = 2;
}

// Namespace: Unity.Properties
internal interface IConstructor // TypeDefIndex: 7913
{
	// Properties
	public abstract InstantiationKind InstantiationKind { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract InstantiationKind get_InstantiationKind();
}

// Namespace: Unity.Properties
internal interface IConstructor<T> : IConstructor // TypeDefIndex: 7914
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T Instantiate();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IConstructor<__Il2CppFullySharedGenericType>.Instantiate
	*/
}

// Namespace: Unity.Properties
internal interface IConstructorWithCount<T> : IConstructor // TypeDefIndex: 7915
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T InstantiateWithCount(int count);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IConstructorWithCount<__Il2CppFullySharedGenericType>.InstantiateWithCount
	*/
}

// Namespace: 
private interface TypeUtility.ITypeConstructor // TypeDefIndex: 7916
{
	// Properties
	public abstract bool CanBeInstantiated { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_CanBeInstantiated();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object Instantiate();
}

// Namespace: 
private interface TypeUtility.ITypeConstructor<T> : TypeUtility.ITypeConstructor // TypeDefIndex: 7917
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T Instantiate();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeUtility.ITypeConstructor<__Il2CppFullySharedGenericType>.Instantiate
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetExplicitConstructor(Func<T> constructor);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-TypeUtility.ITypeConstructor<__Il2CppFullySharedGenericType>.SetExplicitConstructor
	*/
}

// Namespace: 
private class TypeUtility.TypeConstructor<T> : TypeUtility.ITypeConstructor<T>, TypeUtility.ITypeConstructor // TypeDefIndex: 7918
{
	// Fields
	private Func<T> m_ExplicitConstructor; // 0x0
	private Func<T> m_ImplicitConstructor; // 0x0
	private IConstructor<T> m_OverrideConstructor; // 0x0

	// Properties
	private bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 6
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14921DC Offset: 0x148E1DC VA: 0x14921DC
	|-TypeUtility.TypeConstructor<object>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	|
	|-RVA: 0x1492A48 Offset: 0x148EA48 VA: 0x1492A48
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1492314 Offset: 0x148E314 VA: 0x1492314
	|-TypeUtility.TypeConstructor<object>..ctor
	|
	|-RVA: 0x1492B80 Offset: 0x148EB80 VA: 0x1492B80
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void SetImplicitConstructor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149240C Offset: 0x148E40C VA: 0x149240C
	|-TypeUtility.TypeConstructor<object>.SetImplicitConstructor
	|
	|-RVA: 0x1492C80 Offset: 0x148EC80 VA: 0x1492C80
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.SetImplicitConstructor
	*/

	// RVA: -1 Offset: -1
	private static T CreateValueTypeInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149265C Offset: 0x148E65C VA: 0x149265C
	|-TypeUtility.TypeConstructor<object>.CreateValueTypeInstance
	|
	|-RVA: 0x1492EE4 Offset: 0x148EEE4 VA: 0x1492EE4
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.CreateValueTypeInstance
	*/

	// RVA: -1 Offset: -1
	private static T CreateScriptableObjectInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1492664 Offset: 0x148E664 VA: 0x1492664
	|-TypeUtility.TypeConstructor<object>.CreateScriptableObjectInstance
	|
	|-RVA: 0x1492F24 Offset: 0x148EF24 VA: 0x1492F24
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.CreateScriptableObjectInstance
	*/

	// RVA: -1 Offset: -1
	private static T CreateClassInstance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149272C Offset: 0x148E72C VA: 0x149272C
	|-TypeUtility.TypeConstructor<object>.CreateClassInstance
	|
	|-RVA: 0x1493078 Offset: 0x148F078 VA: 0x1493078
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.CreateClassInstance
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void SetExplicitConstructor(Func<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1492754 Offset: 0x148E754 VA: 0x1492754
	|-TypeUtility.TypeConstructor<object>.SetExplicitConstructor
	|
	|-RVA: 0x149318C Offset: 0x148F18C VA: 0x149318C
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.SetExplicitConstructor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private T Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149275C Offset: 0x148E75C VA: 0x149275C
	|-TypeUtility.TypeConstructor<object>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	|
	|-RVA: 0x1493194 Offset: 0x148F194 VA: 0x1493194
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.Unity.Properties.TypeUtility.ITypeConstructor<T>.Instantiate
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object Unity.Properties.TypeUtility.ITypeConstructor.Instantiate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14929BC Offset: 0x148E9BC VA: 0x14929BC
	|-TypeUtility.TypeConstructor<object>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	|
	|-RVA: 0x14934F8 Offset: 0x148F4F8 VA: 0x14934F8
	|-TypeUtility.TypeConstructor<__Il2CppFullySharedGenericType>.Unity.Properties.TypeUtility.ITypeConstructor.Instantiate
	*/
}

// Namespace: 
private class TypeUtility.NonConstructable : TypeUtility.ITypeConstructor // TypeDefIndex: 7919
{
	// Properties
	private bool Unity.Properties.TypeUtility.ITypeConstructor.CanBeInstantiated { get; }

	// Methods

	// RVA: 0x1E9BEF0 Offset: 0x1E97EF0 VA: 0x1E9BEF0 Slot: 4
	private bool Unity.Properties.TypeUtility.ITypeConstructor.get_CanBeInstantiated() { }

	// RVA: 0x1E9BEF8 Offset: 0x1E97EF8 VA: 0x1E9BEF8 Slot: 5
	public object Instantiate() { }

	// RVA: 0x1E9BAF4 Offset: 0x1E97AF4 VA: 0x1E9BAF4
	public void .ctor() { }
}

// Namespace: 
private struct TypeUtility.Cache<T> // TypeDefIndex: 7920
{
	// Fields
	public static TypeUtility.ITypeConstructor<T> TypeConstructor; // 0x0
}

// Namespace: 
private class TypeUtility.TypeConstructorVisitor : ITypeVisitor // TypeDefIndex: 7921
{
	// Fields
	public TypeUtility.ITypeConstructor TypeConstructor; // 0x10

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public void Visit<TContainer>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x104D644 Offset: 0x1049644 VA: 0x104D644
	|-TypeUtility.TypeConstructorVisitor.Visit<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E9BAEC Offset: 0x1E97AEC VA: 0x1E9BAEC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TypeUtility.<>c // TypeDefIndex: 7922
{
	// Fields
	public static readonly TypeUtility.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1E9BF44 Offset: 0x1E97F44 VA: 0x1E9BF44
	private static void .cctor() { }

	// RVA: 0x1E9BFAC Offset: 0x1E97FAC VA: 0x1E9BFAC
	public void .ctor() { }

	// RVA: 0x1E9BFB4 Offset: 0x1E97FB4 VA: 0x1E9BFB4
	internal StringBuilder <.cctor>b__11_0() { }

	// RVA: 0x1E9C008 Offset: 0x1E98008 VA: 0x1E9C008
	internal void <.cctor>b__11_1(StringBuilder sb) { }

	// RVA: 0x1E9C020 Offset: 0x1E98020 VA: 0x1E9C020
	internal string <.cctor>b__11_2() { }
}

// Namespace: Unity.Properties
[Extension]
public static class TypeUtility // TypeDefIndex: 7923
{
	// Fields
	private static readonly ConcurrentDictionary<Type, TypeUtility.ITypeConstructor> s_TypeConstructors; // 0x0
	private static readonly MethodInfo s_CreateTypeConstructor; // 0x8
	private static readonly ConcurrentDictionary<Type, string> s_CachedResolvedName; // 0x10
	private static readonly ObjectPool<StringBuilder> s_Builders; // 0x18
	private static readonly object syncedPoolObject; // 0x20

	// Methods

	// RVA: 0x1E9A858 Offset: 0x1E96858 VA: 0x1E9A858
	private static void .cctor() { }

	// RVA: 0x1E9AC90 Offset: 0x1E96C90 VA: 0x1E9AC90
	public static string GetTypeDisplayName(Type type) { }

	// RVA: 0x1E9ADB0 Offset: 0x1E96DB0 VA: 0x1E9ADB0
	private static string GetTypeDisplayName(Type type, IReadOnlyList<Type> args, ref int argIndex) { }

	[Extension]
	// RVA: 0x1E9B58C Offset: 0x1E9758C VA: 0x1E9B58C
	public static Type GetRootType(Type type) { }

	[Preserve]
	// RVA: 0x1E9B674 Offset: 0x1E97674 VA: 0x1E9B674
	private static TypeUtility.ITypeConstructor CreateTypeConstructor(Type type) { }

	// RVA: -1 Offset: -1
	private static TypeUtility.ITypeConstructor<T> CreateTypeConstructor<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1039E54 Offset: 0x1035E54 VA: 0x1039E54
	|-TypeUtility.CreateTypeConstructor<object>
	|
	|-RVA: 0x1039F88 Offset: 0x1035F88 VA: 0x1039F88
	|-TypeUtility.CreateTypeConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E9BAFC Offset: 0x1E97AFC VA: 0x1E9BAFC
	private static TypeUtility.ITypeConstructor GetTypeConstructor(Type type) { }

	// RVA: -1 Offset: -1
	private static TypeUtility.ITypeConstructor<T> GetTypeConstructor<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103A0C0 Offset: 0x10360C0 VA: 0x103A0C0
	|-TypeUtility.GetTypeConstructor<object>
	|
	|-RVA: 0x103A160 Offset: 0x1036160 VA: 0x103A160
	|-TypeUtility.GetTypeConstructor<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E9BBB4 Offset: 0x1E97BB4 VA: 0x1E9BBB4
	public static bool CanBeInstantiated(Type type) { }

	// RVA: -1 Offset: -1
	public static bool CanBeInstantiated<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1039C38 Offset: 0x1035C38 VA: 0x1039C38
	|-TypeUtility.CanBeInstantiated<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void SetExplicitInstantiationMethod<T>(Func<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103AE3C Offset: 0x1036E3C VA: 0x103AE3C
	|-TypeUtility.SetExplicitInstantiationMethod<object>
	|
	|-RVA: 0x103AF24 Offset: 0x1036F24 VA: 0x103AF24
	|-TypeUtility.SetExplicitInstantiationMethod<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103A204 Offset: 0x1036204 VA: 0x103A204
	|-TypeUtility.Instantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiate<T>(out T instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103B010 Offset: 0x1037010 VA: 0x103B010
	|-TypeUtility.TryInstantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(Type derivedType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103A388 Offset: 0x1036388 VA: 0x103A388
	|-TypeUtility.Instantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiate<T>(Type derivedType, out T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103B23C Offset: 0x103723C VA: 0x103B23C
	|-TypeUtility.TryInstantiate<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TArray InstantiateArray<TArray>(int count = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103A57C Offset: 0x103657C VA: 0x103A57C
	|-TypeUtility.InstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryInstantiateArray<TArray>(int count, out TArray instance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103B4CC Offset: 0x10374CC VA: 0x103B4CC
	|-TypeUtility.TryInstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TArray InstantiateArray<TArray>(Type derivedType, int count = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103A9DC Offset: 0x10369DC VA: 0x103A9DC
	|-TypeUtility.InstantiateArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E9BC80 Offset: 0x1E97C80 VA: 0x1E9BC80
	private static void CheckIsAssignableFrom(Type type, Type derivedType) { }

	// RVA: -1 Offset: -1
	private static void CheckCanBeInstantiated<T>(TypeUtility.ITypeConstructor<T> constructor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1039D08 Offset: 0x1035D08 VA: 0x1039D08
	|-TypeUtility.CheckCanBeInstantiated<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E9BDC0 Offset: 0x1E97DC0 VA: 0x1E9BDC0
	private static void CheckCanBeInstantiated(TypeUtility.ITypeConstructor constructor, Type type) { }
}
