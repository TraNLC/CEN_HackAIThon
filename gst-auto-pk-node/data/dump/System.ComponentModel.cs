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

// Namespace: System.ComponentModel
[Usage(32767)]
public class DefaultValueAttribute : Attribute // TypeDefIndex: 3952
{
	// Fields
	private object _value; // 0x10

	// Properties
	public virtual object Value { get; }

	// Methods

	// RVA: 0x1D28F7C Offset: 0x1D24F7C VA: 0x1D28F7C
	public void .ctor(int value) { }

	// RVA: 0x1D28FC8 Offset: 0x1D24FC8 VA: 0x1D28FC8
	public void .ctor(long value) { }

	// RVA: 0x1D29014 Offset: 0x1D25014 VA: 0x1D29014
	public void .ctor(bool value) { }

	// RVA: 0x1D29060 Offset: 0x1D25060 VA: 0x1D29060
	public void .ctor(string value) { }

	// RVA: 0x1D29090 Offset: 0x1D25090 VA: 0x1D29090
	public void .ctor(object value) { }

	// RVA: 0x1D290C0 Offset: 0x1D250C0 VA: 0x1D290C0 Slot: 7
	public virtual object get_Value() { }

	// RVA: 0x1D290C8 Offset: 0x1D250C8 VA: 0x1D290C8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D291C8 Offset: 0x1D251C8 VA: 0x1D291C8 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.ComponentModel
[Usage(6140)]
public sealed class EditorBrowsableAttribute : Attribute // TypeDefIndex: 3953
{
	// Fields
	private EditorBrowsableState browsableState; // 0x10

	// Methods

	// RVA: 0x1D291D0 Offset: 0x1D251D0 VA: 0x1D291D0
	public void .ctor(EditorBrowsableState state) { }

	// RVA: 0x1D291F8 Offset: 0x1D251F8 VA: 0x1D291F8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D29278 Offset: 0x1D25278 VA: 0x1D29278 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.ComponentModel
public enum EditorBrowsableState // TypeDefIndex: 3954
{
	// Fields
	public int value__; // 0x0
	public const EditorBrowsableState Always = 0;
	public const EditorBrowsableState Never = 1;
	public const EditorBrowsableState Advanced = 2;
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class BrowsableAttribute : Attribute // TypeDefIndex: 3955
{
	// Fields
	public static readonly BrowsableAttribute Yes; // 0x0
	public static readonly BrowsableAttribute No; // 0x8
	public static readonly BrowsableAttribute Default; // 0x10
	[CompilerGenerated]
	private readonly bool <Browsable>k__BackingField; // 0x10

	// Properties
	public bool Browsable { get; }

	// Methods

	// RVA: 0x1D29280 Offset: 0x1D25280 VA: 0x1D29280
	public void .ctor(bool browsable) { }

	[CompilerGenerated]
	// RVA: 0x1D292A8 Offset: 0x1D252A8 VA: 0x1D292A8
	public bool get_Browsable() { }

	// RVA: 0x1D292B0 Offset: 0x1D252B0 VA: 0x1D292B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D29394 Offset: 0x1D25394 VA: 0x1D29394 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D293CC Offset: 0x1D253CC VA: 0x1D293CC Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1D29434 Offset: 0x1D25434 VA: 0x1D29434
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class ComponentCollection : ReadOnlyCollectionBase // TypeDefIndex: 3956
{
	// Properties
	public virtual IComponent Item { get; }

	// Methods

	// RVA: 0x1D294E4 Offset: 0x1D254E4 VA: 0x1D294E4 Slot: 11
	public virtual IComponent get_Item(string name) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class DesignOnlyAttribute : Attribute // TypeDefIndex: 3957
{
	// Fields
	[CompilerGenerated]
	private readonly bool <IsDesignOnly>k__BackingField; // 0x10
	public static readonly DesignOnlyAttribute Yes; // 0x0
	public static readonly DesignOnlyAttribute No; // 0x8
	public static readonly DesignOnlyAttribute Default; // 0x10

	// Properties
	public bool IsDesignOnly { get; }

	// Methods

	// RVA: 0x1D29A28 Offset: 0x1D25A28 VA: 0x1D29A28
	public void .ctor(bool isDesignOnly) { }

	[CompilerGenerated]
	// RVA: 0x1D29A50 Offset: 0x1D25A50 VA: 0x1D29A50
	public bool get_IsDesignOnly() { }

	// RVA: 0x1D29A58 Offset: 0x1D25A58 VA: 0x1D29A58 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D29B3C Offset: 0x1D25B3C VA: 0x1D29B3C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D29B74 Offset: 0x1D25B74 VA: 0x1D29B74 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1D29BF4 Offset: 0x1D25BF4 VA: 0x1D29BF4
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(4, AllowMultiple = False, Inherited = True)]
public sealed class DesignerCategoryAttribute : Attribute // TypeDefIndex: 3958
{
	// Fields
	public static readonly DesignerCategoryAttribute Component; // 0x0
	public static readonly DesignerCategoryAttribute Default; // 0x8
	public static readonly DesignerCategoryAttribute Form; // 0x10
	public static readonly DesignerCategoryAttribute Generic; // 0x18
	[CompilerGenerated]
	private readonly string <Category>k__BackingField; // 0x10

	// Properties
	public string Category { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x1D29CA4 Offset: 0x1D25CA4 VA: 0x1D29CA4
	public void .ctor() { }

	// RVA: 0x1D29CD8 Offset: 0x1D25CD8 VA: 0x1D29CD8
	public void .ctor(string category) { }

	[CompilerGenerated]
	// RVA: 0x1D29D08 Offset: 0x1D25D08 VA: 0x1D29D08
	public string get_Category() { }

	// RVA: 0x1D29D10 Offset: 0x1D25D10 VA: 0x1D29D10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D29D94 Offset: 0x1D25D94 VA: 0x1D29D94 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D29DB0 Offset: 0x1D25DB0 VA: 0x1D29DB0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1D29E28 Offset: 0x1D25E28 VA: 0x1D29E28 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x1D29E60 Offset: 0x1D25E60 VA: 0x1D29E60
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public enum DesignerSerializationVisibility // TypeDefIndex: 3959
{
	// Fields
	public int value__; // 0x0
	public const DesignerSerializationVisibility Hidden = 0;
	public const DesignerSerializationVisibility Visible = 1;
	public const DesignerSerializationVisibility Content = 2;
}

// Namespace: System.ComponentModel
[Usage(960)]
public sealed class DesignerSerializationVisibilityAttribute : Attribute // TypeDefIndex: 3960
{
	// Fields
	public static readonly DesignerSerializationVisibilityAttribute Content; // 0x0
	public static readonly DesignerSerializationVisibilityAttribute Hidden; // 0x8
	public static readonly DesignerSerializationVisibilityAttribute Visible; // 0x10
	public static readonly DesignerSerializationVisibilityAttribute Default; // 0x18
	[CompilerGenerated]
	private readonly DesignerSerializationVisibility <Visibility>k__BackingField; // 0x10

	// Properties
	public DesignerSerializationVisibility Visibility { get; }

	// Methods

	// RVA: 0x1D29FE0 Offset: 0x1D25FE0 VA: 0x1D29FE0
	public void .ctor(DesignerSerializationVisibility visibility) { }

	[CompilerGenerated]
	// RVA: 0x1D2A008 Offset: 0x1D26008 VA: 0x1D2A008
	public DesignerSerializationVisibility get_Visibility() { }

	// RVA: 0x1D2A010 Offset: 0x1D26010 VA: 0x1D2A010 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D2A0E0 Offset: 0x1D260E0 VA: 0x1D2A0E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D2A0E8 Offset: 0x1D260E8 VA: 0x1D2A0E8 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1D2A150 Offset: 0x1D26150 VA: 0x1D2A150
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(708)]
public class DisplayNameAttribute : Attribute // TypeDefIndex: 3961
{
	// Fields
	public static readonly DisplayNameAttribute Default; // 0x0
	[CompilerGenerated]
	private string <DisplayNameValue>k__BackingField; // 0x10

	// Properties
	public virtual string DisplayName { get; }
	protected string DisplayNameValue { get; set; }

	// Methods

	// RVA: 0x1D2A230 Offset: 0x1D26230 VA: 0x1D2A230
	public void .ctor() { }

	// RVA: 0x1D2A270 Offset: 0x1D26270 VA: 0x1D2A270
	public void .ctor(string displayName) { }

	// RVA: 0x1D2A2A0 Offset: 0x1D262A0 VA: 0x1D2A2A0 Slot: 7
	public virtual string get_DisplayName() { }

	[CompilerGenerated]
	// RVA: 0x1D2A2A8 Offset: 0x1D262A8 VA: 0x1D2A2A8
	protected string get_DisplayNameValue() { }

	[CompilerGenerated]
	// RVA: 0x1D2A2B0 Offset: 0x1D262B0 VA: 0x1D2A2B0
	protected void set_DisplayNameValue(string value) { }

	// RVA: 0x1D2A2B8 Offset: 0x1D262B8 VA: 0x1D2A2B8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D2A378 Offset: 0x1D26378 VA: 0x1D2A378 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D2A3A0 Offset: 0x1D263A0 VA: 0x1D2A3A0 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1D2A408 Offset: 0x1D26408 VA: 0x1D2A408
	private static void .cctor() { }
}

// Namespace: 
private sealed class EventHandlerList.ListEntry // TypeDefIndex: 3962
{
	// Fields
	internal EventHandlerList.ListEntry _next; // 0x10
	internal object _key; // 0x18
	internal Delegate _handler; // 0x20
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public sealed class EventHandlerList // TypeDefIndex: 3963
{
	// Fields
	private EventHandlerList.ListEntry _head; // 0x10
	private Component _parent; // 0x18

	// Properties
	public Delegate Item { get; }

	// Methods

	// RVA: 0x1D2A494 Offset: 0x1D26494 VA: 0x1D2A494
	public Delegate get_Item(object key) { }

	// RVA: 0x1D2A4F4 Offset: 0x1D264F4 VA: 0x1D2A4F4
	private EventHandlerList.ListEntry Find(object key) { }
}

// Namespace: System.ComponentModel
public interface IContainer : IDisposable // TypeDefIndex: 3964
{
	// Properties
	public abstract ComponentCollection Components { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ComponentCollection get_Components();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Remove(IComponent component);
}

// Namespace: System.ComponentModel
public interface ISite : IServiceProvider // TypeDefIndex: 3965
{
	// Properties
	public abstract IContainer Container { get; }
	public abstract bool DesignMode { get; }
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IContainer get_Container();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_DesignMode();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Name();
}

// Namespace: System.ComponentModel
[Serializable]
public class InvalidEnumArgumentException : ArgumentException // TypeDefIndex: 3966
{
	// Methods

	// RVA: 0x1D2A50C Offset: 0x1D2650C VA: 0x1D2A50C
	public void .ctor() { }

	// RVA: 0x1D2A518 Offset: 0x1D26518 VA: 0x1D2A518
	public void .ctor(string message) { }

	// RVA: 0x1D2A520 Offset: 0x1D26520 VA: 0x1D2A520
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class ReadOnlyAttribute : Attribute // TypeDefIndex: 3967
{
	// Fields
	public static readonly ReadOnlyAttribute Yes; // 0x0
	public static readonly ReadOnlyAttribute No; // 0x8
	public static readonly ReadOnlyAttribute Default; // 0x10
	[CompilerGenerated]
	private readonly bool <IsReadOnly>k__BackingField; // 0x10

	// Properties
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x1D2A528 Offset: 0x1D26528 VA: 0x1D2A528
	public void .ctor(bool isReadOnly) { }

	[CompilerGenerated]
	// RVA: 0x1D2A550 Offset: 0x1D26550 VA: 0x1D2A550
	public bool get_IsReadOnly() { }

	// RVA: 0x1D2A558 Offset: 0x1D26558 VA: 0x1D2A558 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1D2A63C Offset: 0x1D2663C VA: 0x1D2A63C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D2A644 Offset: 0x1D26644 VA: 0x1D2A644 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1D2A6C4 Offset: 0x1D266C4 VA: 0x1D2A6C4
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class AmbientValueAttribute : Attribute // TypeDefIndex: 3968
{
	// Fields
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; // 0x10

	// Properties
	public object Value { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D2A774 Offset: 0x1D26774 VA: 0x1D2A774
	public object get_Value() { }
}

// Namespace: 
private class ArrayConverter.ArrayPropertyDescriptor : TypeConverter.SimplePropertyDescriptor // TypeDefIndex: 3969
{
	// Fields
	private readonly int _index; // 0x98

	// Methods

	// RVA: 0x1D2AAEC Offset: 0x1D26AEC VA: 0x1D2AAEC
	public void .ctor(Type arrayType, Type elementType, int index) { }

	// RVA: 0x1D2ABB4 Offset: 0x1D26BB4 VA: 0x1D2ABB4 Slot: 18
	public override object GetValue(object instance) { }

	// RVA: 0x1D2AC3C Offset: 0x1D26C3C VA: 0x1D2AC3C Slot: 21
	public override void SetValue(object instance, object value) { }
}

// Namespace: System.ComponentModel
public class ArrayConverter : CollectionConverter // TypeDefIndex: 3970
{
	// Methods

	// RVA: 0x1D2A77C Offset: 0x1D2677C VA: 0x1D2A77C Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D2A910 Offset: 0x1D26910 VA: 0x1D2A910 Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1D2ABA4 Offset: 0x1D26BA4 VA: 0x1D2ABA4 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1D2ABAC Offset: 0x1D26BAC VA: 0x1D2ABAC
	public void .ctor() { }
}

// Namespace: 
private struct AttributeCollection.AttributeEntry // TypeDefIndex: 3971
{
	// Fields
	public Type type; // 0x0
	public int index; // 0x8
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class AttributeCollection : ICollection, IEnumerable // TypeDefIndex: 3972
{
	// Fields
	public static readonly AttributeCollection Empty; // 0x0
	private static Hashtable s_defaultAttributes; // 0x8
	private readonly Attribute[] _attributes; // 0x10
	private static readonly object s_internalSyncObject; // 0x10
	private AttributeCollection.AttributeEntry[] _foundAttributeTypes; // 0x18
	private int _index; // 0x20

	// Properties
	protected virtual Attribute[] Attributes { get; }
	public int Count { get; }
	public virtual Attribute Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }

	// Methods

	// RVA: 0x1D2AD30 Offset: 0x1D26D30 VA: 0x1D2AD30
	public void .ctor(Attribute[] attributes) { }

	// RVA: 0x1D2AE7C Offset: 0x1D26E7C VA: 0x1D2AE7C Slot: 9
	protected virtual Attribute[] get_Attributes() { }

	// RVA: 0x1D2AE84 Offset: 0x1D26E84 VA: 0x1D2AE84
	public int get_Count() { }

	// RVA: 0x1D2AEA8 Offset: 0x1D26EA8 VA: 0x1D2AEA8 Slot: 10
	public virtual Attribute get_Item(Type attributeType) { }

	// RVA: 0x1D2B914 Offset: 0x1D27914 VA: 0x1D2B914
	public bool Contains(Attribute attribute) { }

	// RVA: 0x1D2B398 Offset: 0x1D27398 VA: 0x1D2B398
	protected Attribute GetDefaultAttribute(Type attributeType) { }

	// RVA: 0x1D2B974 Offset: 0x1D27974 VA: 0x1D2B974
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1D2B998 Offset: 0x1D27998 VA: 0x1D2B998 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1D2B9A0 Offset: 0x1D279A0 VA: 0x1D2B9A0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1D2B9A8 Offset: 0x1D279A8 VA: 0x1D2B9A8 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1D2B9CC Offset: 0x1D279CC VA: 0x1D2B9CC Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1D2B9D0 Offset: 0x1D279D0 VA: 0x1D2B9D0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1D2BA3C Offset: 0x1D27A3C VA: 0x1D2BA3C
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(128)]
public class AttributeProviderAttribute : Attribute // TypeDefIndex: 3973
{
	// Fields
	[CompilerGenerated]
	private readonly string <TypeName>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <PropertyName>k__BackingField; // 0x18

	// Properties
	public string TypeName { get; }
	public string PropertyName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D2BAE0 Offset: 0x1D27AE0 VA: 0x1D2BAE0
	public string get_TypeName() { }

	[CompilerGenerated]
	// RVA: 0x1D2BAE8 Offset: 0x1D27AE8 VA: 0x1D2BAE8
	public string get_PropertyName() { }
}

// Namespace: System.ComponentModel
public abstract class BaseNumberConverter : TypeConverter // TypeDefIndex: 3974
{
	// Properties
	internal virtual bool AllowHex { get; }
	internal abstract Type TargetType { get; }

	// Methods

	// RVA: 0x1D2BAF0 Offset: 0x1D27AF0 VA: 0x1D2BAF0
	internal void .ctor() { }

	// RVA: 0x1D2BAF8 Offset: 0x1D27AF8 VA: 0x1D2BAF8 Slot: 16
	internal virtual bool get_AllowHex() { }

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract Type get_TargetType();

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract object FromString(string value, int radix);

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract object FromString(string value, NumberFormatInfo formatInfo);

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract string ToString(object value, NumberFormatInfo formatInfo);

	// RVA: 0x1D2BB00 Offset: 0x1D27B00 VA: 0x1D2BB00 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1D2BB8C Offset: 0x1D27B8C VA: 0x1D2BB8C Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1D2BF64 Offset: 0x1D27F64 VA: 0x1D2BF64 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D2C1E4 Offset: 0x1D281E4 VA: 0x1D2C1E4 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }
}

// Namespace: System.ComponentModel
public class BooleanConverter : TypeConverter // TypeDefIndex: 3975
{
	// Fields
	private static TypeConverter.StandardValuesCollection s_values; // 0x0

	// Methods

	// RVA: 0x1D2C21C Offset: 0x1D2821C VA: 0x1D2C21C Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1D2C2A8 Offset: 0x1D282A8 VA: 0x1D2C2A8 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1D2C460 Offset: 0x1D28460 VA: 0x1D2C460 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1D2C5DC Offset: 0x1D285DC VA: 0x1D2C5DC Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1D2C5E4 Offset: 0x1D285E4 VA: 0x1D2C5E4 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1D2C5EC Offset: 0x1D285EC VA: 0x1D2C5EC
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class ByteConverter : BaseNumberConverter // TypeDefIndex: 3976
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1D2C5F4 Offset: 0x1D285F4 VA: 0x1D2C5F4 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x1D2C624 Offset: 0x1D28624 VA: 0x1D2C624 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1D2C6AC Offset: 0x1D286AC VA: 0x1D2C6AC Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D2C6E4 Offset: 0x1D286E4 VA: 0x1D2C6E4 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D2C788 Offset: 0x1D28788 VA: 0x1D2C788
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class CharConverter : TypeConverter // TypeDefIndex: 3977
{
	// Methods

	// RVA: 0x1D2C790 Offset: 0x1D28790 VA: 0x1D2C790 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1D2C81C Offset: 0x1D2881C VA: 0x1D2C81C Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D2C90C Offset: 0x1D2890C VA: 0x1D2C90C Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1D2CA24 Offset: 0x1D28A24 VA: 0x1D2CA24
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public enum CollectionChangeAction // TypeDefIndex: 3978
{
	// Fields
	public int value__; // 0x0
	public const CollectionChangeAction Add = 1;
	public const CollectionChangeAction Remove = 2;
	public const CollectionChangeAction Refresh = 3;
}

// Namespace: System.ComponentModel
public class CollectionChangeEventArgs : EventArgs // TypeDefIndex: 3979
{
	// Fields
	[CompilerGenerated]
	private readonly CollectionChangeAction <Action>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly object <Element>k__BackingField; // 0x18

	// Properties
	public virtual CollectionChangeAction Action { get; }
	public virtual object Element { get; }

	// Methods

	// RVA: 0x1D2CA2C Offset: 0x1D28A2C VA: 0x1D2CA2C
	public void .ctor(CollectionChangeAction action, object element) { }

	[CompilerGenerated]
	// RVA: 0x1D2CAA8 Offset: 0x1D28AA8 VA: 0x1D2CAA8 Slot: 4
	public virtual CollectionChangeAction get_Action() { }

	[CompilerGenerated]
	// RVA: 0x1D2CAB0 Offset: 0x1D28AB0 VA: 0x1D2CAB0 Slot: 5
	public virtual object get_Element() { }
}

// Namespace: System.ComponentModel
public sealed class CollectionChangeEventHandler : MulticastDelegate // TypeDefIndex: 3980
{
	// Methods

	// RVA: 0x1D2CAB8 Offset: 0x1D28AB8 VA: 0x1D2CAB8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D2CBC4 Offset: 0x1D28BC4 VA: 0x1D2CBC4 Slot: 12
	public virtual void Invoke(object sender, CollectionChangeEventArgs e) { }
}

// Namespace: 
private class CultureInfoConverter.CultureComparer : IComparer // TypeDefIndex: 3981
{
	// Fields
	private CultureInfoConverter _converter; // 0x10

	// Methods

	// RVA: 0x1D2DD5C Offset: 0x1D29D5C VA: 0x1D2DD5C
	public void .ctor(CultureInfoConverter cultureConverter) { }

	// RVA: 0x1D2DDA4 Offset: 0x1D29DA4 VA: 0x1D2DDA4 Slot: 4
	public int Compare(object item1, object item2) { }
}

// Namespace: 
private static class CultureInfoConverter.CultureInfoMapper // TypeDefIndex: 3982
{
	// Fields
	private static readonly Dictionary<string, string> s_cultureInfoNameMap; // 0x0

	// Methods

	// RVA: 0x1D2DF10 Offset: 0x1D29F10 VA: 0x1D2DF10
	private static Dictionary<string, string> CreateMap() { }

	// RVA: 0x1D2D630 Offset: 0x1D29630 VA: 0x1D2D630
	public static string GetCultureInfoName(string cultureInfoDisplayName) { }

	// RVA: 0x1D31FF0 Offset: 0x1D2DFF0 VA: 0x1D31FF0
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class CultureInfoConverter : TypeConverter // TypeDefIndex: 3983
{
	// Fields
	private TypeConverter.StandardValuesCollection _values; // 0x10
	private const string DefaultInvariantCultureString = "(Default)";

	// Properties
	private string DefaultCultureString { get; }

	// Methods

	// RVA: 0x1D2CBD8 Offset: 0x1D28BD8 VA: 0x1D2CBD8
	private string get_DefaultCultureString() { }

	// RVA: 0x1D2CC18 Offset: 0x1D28C18 VA: 0x1D2CC18 Slot: 16
	protected virtual string GetCultureName(CultureInfo culture) { }

	// RVA: 0x1D2CC38 Offset: 0x1D28C38 VA: 0x1D2CC38 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1D2CCC4 Offset: 0x1D28CC4 VA: 0x1D2CCC4 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1D2CD74 Offset: 0x1D28D74 VA: 0x1D2CD74 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1D2D6D0 Offset: 0x1D296D0 VA: 0x1D2D6D0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D2DB40 Offset: 0x1D29B40 VA: 0x1D2DB40 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1D2DD8C Offset: 0x1D29D8C VA: 0x1D2DD8C Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1D2DD94 Offset: 0x1D29D94 VA: 0x1D2DD94 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1D2DD9C Offset: 0x1D29D9C VA: 0x1D2DD9C
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public abstract class CustomTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 3984
{
	// Fields
	private readonly ICustomTypeDescriptor _parent; // 0x10

	// Methods

	// RVA: 0x1D32048 Offset: 0x1D2E048 VA: 0x1D32048
	protected void .ctor() { }

	// RVA: 0x1D32050 Offset: 0x1D2E050 VA: 0x1D32050 Slot: 9
	public virtual AttributeCollection GetAttributes() { }

	// RVA: 0x1D32128 Offset: 0x1D2E128 VA: 0x1D32128 Slot: 10
	public virtual TypeConverter GetConverter() { }

	// RVA: 0x1D32200 Offset: 0x1D2E200 VA: 0x1D32200 Slot: 11
	public virtual PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x1D322DC Offset: 0x1D2E2DC VA: 0x1D322DC Slot: 12
	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: 0x1D323C0 Offset: 0x1D2E3C0 VA: 0x1D323C0 Slot: 13
	public virtual object GetPropertyOwner(PropertyDescriptor pd) { }
}

// Namespace: System.ComponentModel
public class DateTimeConverter : TypeConverter // TypeDefIndex: 3985
{
	// Methods

	// RVA: 0x1D32478 Offset: 0x1D2E478 VA: 0x1D32478 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1D32504 Offset: 0x1D2E504 VA: 0x1D32504 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1D325B4 Offset: 0x1D2E5B4 VA: 0x1D325B4 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1D328CC Offset: 0x1D2E8CC VA: 0x1D328CC Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D32C88 Offset: 0x1D2EC88 VA: 0x1D32C88
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class DecimalConverter : BaseNumberConverter // TypeDefIndex: 3986
{
	// Properties
	internal override bool AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1D32C90 Offset: 0x1D2EC90 VA: 0x1D32C90 Slot: 16
	internal override bool get_AllowHex() { }

	// RVA: 0x1D32C98 Offset: 0x1D2EC98 VA: 0x1D32C98 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x1D32CF8 Offset: 0x1D2ECF8 VA: 0x1D32CF8 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1D32DA8 Offset: 0x1D2EDA8 VA: 0x1D32DA8 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D330D8 Offset: 0x1D2F0D8 VA: 0x1D330D8 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1D331C4 Offset: 0x1D2F1C4 VA: 0x1D331C4 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D33270 Offset: 0x1D2F270 VA: 0x1D33270 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D3337C Offset: 0x1D2F37C VA: 0x1D3337C
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Usage(4)]
public sealed class DefaultEventAttribute : Attribute // TypeDefIndex: 3987
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultEventAttribute Default; // 0x0

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x1D33384 Offset: 0x1D2F384 VA: 0x1D33384
	public void .ctor(string name) { }

	[CompilerGenerated]
	// RVA: 0x1D333B4 Offset: 0x1D2F3B4 VA: 0x1D333B4
	public string get_Name() { }

	// RVA: 0x1D333BC Offset: 0x1D2F3BC VA: 0x1D333BC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D33430 Offset: 0x1D2F430 VA: 0x1D33430 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D33438 Offset: 0x1D2F438 VA: 0x1D33438
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(4)]
public sealed class DefaultPropertyAttribute : Attribute // TypeDefIndex: 3988
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	public static readonly DefaultPropertyAttribute Default; // 0x0

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x1D334B0 Offset: 0x1D2F4B0 VA: 0x1D334B0
	public void .ctor(string name) { }

	[CompilerGenerated]
	// RVA: 0x1D334E0 Offset: 0x1D2F4E0 VA: 0x1D334E0
	public string get_Name() { }

	// RVA: 0x1D334E8 Offset: 0x1D2F4E8 VA: 0x1D334E8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D3355C Offset: 0x1D2F55C VA: 0x1D3355C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D33564 Offset: 0x1D2F564 VA: 0x1D33564
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 3989
{
	// Fields
	private readonly Type _type; // 0x20

	// Properties
	internal TypeDescriptionProvider Provider { get; }

	// Methods

	// RVA: 0x1D335DC Offset: 0x1D2F5DC VA: 0x1D335DC
	internal void .ctor(Type type) { }

	// RVA: 0x1D33614 Offset: 0x1D2F614 VA: 0x1D33614
	internal TypeDescriptionProvider get_Provider() { }

	// RVA: 0x1D33670 Offset: 0x1D2F670 VA: 0x1D33670 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1D336C0 Offset: 0x1D2F6C0 VA: 0x1D336C0 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x1D336E8 Offset: 0x1D2F6E8 VA: 0x1D336E8 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1D33710 Offset: 0x1D2F710 VA: 0x1D33710 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1D33738 Offset: 0x1D2F738 VA: 0x1D33738 Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x1D33770 Offset: 0x1D2F770 VA: 0x1D33770 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public class ToolboxItemAttribute : Attribute // TypeDefIndex: 3990
{
	// Fields
	private string _toolboxItemTypeName; // 0x10
	public static readonly ToolboxItemAttribute Default; // 0x0
	public static readonly ToolboxItemAttribute None; // 0x8

	// Properties
	public string ToolboxItemTypeName { get; }

	// Methods

	// RVA: 0x1D337A8 Offset: 0x1D2F7A8 VA: 0x1D337A8 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1D33810 Offset: 0x1D2F810 VA: 0x1D33810
	public void .ctor(bool defaultType) { }

	// RVA: 0x1D3387C Offset: 0x1D2F87C VA: 0x1D3387C
	public void .ctor(string toolboxItemTypeName) { }

	// RVA: 0x1D33910 Offset: 0x1D2F910 VA: 0x1D33910
	public string get_ToolboxItemTypeName() { }

	// RVA: 0x1D33934 Offset: 0x1D2F934 VA: 0x1D33934 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D33A04 Offset: 0x1D2FA04 VA: 0x1D33A04 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D33A28 Offset: 0x1D2FA28 VA: 0x1D33A28
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(1028)]
public sealed class DesignTimeVisibleAttribute : Attribute // TypeDefIndex: 3991
{
	// Fields
	[CompilerGenerated]
	private readonly bool <Visible>k__BackingField; // 0x10
	public static readonly DesignTimeVisibleAttribute Yes; // 0x0
	public static readonly DesignTimeVisibleAttribute No; // 0x8
	public static readonly DesignTimeVisibleAttribute Default; // 0x10

	// Properties
	public bool Visible { get; }

	// Methods

	// RVA: 0x1D33AF0 Offset: 0x1D2FAF0 VA: 0x1D33AF0
	public void .ctor(bool visible) { }

	[CompilerGenerated]
	// RVA: 0x1D33B18 Offset: 0x1D2FB18 VA: 0x1D33B18
	public bool get_Visible() { }

	// RVA: 0x1D33B20 Offset: 0x1D2FB20 VA: 0x1D33B20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D33BAC Offset: 0x1D2FBAC VA: 0x1D33BAC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D33C34 Offset: 0x1D2FC34 VA: 0x1D33C34 Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1D33CB4 Offset: 0x1D2FCB4 VA: 0x1D33CB4
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class DoubleConverter : BaseNumberConverter // TypeDefIndex: 3992
{
	// Properties
	internal override bool AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1D33D64 Offset: 0x1D2FD64 VA: 0x1D33D64 Slot: 16
	internal override bool get_AllowHex() { }

	// RVA: 0x1D33D6C Offset: 0x1D2FD6C VA: 0x1D33D6C Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x1D33D9C Offset: 0x1D2FD9C VA: 0x1D33D9C Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1D33E50 Offset: 0x1D2FE50 VA: 0x1D33E50 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D33E84 Offset: 0x1D2FE84 VA: 0x1D33E84 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D33F28 Offset: 0x1D2FF28 VA: 0x1D33F28
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Usage(32767, AllowMultiple = True, Inherited = True)]
public sealed class EditorAttribute : Attribute // TypeDefIndex: 3993
{
	// Fields
	private string _typeId; // 0x10
	[CompilerGenerated]
	private readonly string <EditorBaseTypeName>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <EditorTypeName>k__BackingField; // 0x20

	// Properties
	public string EditorBaseTypeName { get; }
	public string EditorTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x1D33F30 Offset: 0x1D2FF30 VA: 0x1D33F30
	public void .ctor(string typeName, string baseTypeName) { }

	[CompilerGenerated]
	// RVA: 0x1D33FD8 Offset: 0x1D2FFD8 VA: 0x1D33FD8
	public string get_EditorBaseTypeName() { }

	[CompilerGenerated]
	// RVA: 0x1D33FE0 Offset: 0x1D2FFE0 VA: 0x1D33FE0
	public string get_EditorTypeName() { }

	// RVA: 0x1D33FE8 Offset: 0x1D2FFE8 VA: 0x1D33FE8 Slot: 4
	public override object get_TypeId() { }

	// RVA: 0x1D34088 Offset: 0x1D30088 VA: 0x1D34088 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D34120 Offset: 0x1D30120 VA: 0x1D34120 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.ComponentModel
public abstract class EventDescriptor : MemberDescriptor // TypeDefIndex: 3994
{}

// Namespace: 
private class EventDescriptorCollection.ArraySubsetEnumerator : IEnumerator // TypeDefIndex: 3995
{
	// Fields
	private readonly Array _array; // 0x10
	private readonly int _total; // 0x18
	private int _current; // 0x1C

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1D34B94 Offset: 0x1D30B94 VA: 0x1D34B94
	public void .ctor(Array array, int count) { }

	// RVA: 0x1D3511C Offset: 0x1D3111C VA: 0x1D3511C Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1D35140 Offset: 0x1D31140 VA: 0x1D35140 Slot: 6
	public void Reset() { }

	// RVA: 0x1D3514C Offset: 0x1D3114C VA: 0x1D3514C Slot: 5
	public object get_Current() { }
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class EventDescriptorCollection : ICollection, IEnumerable, IList // TypeDefIndex: 3996
{
	// Fields
	private EventDescriptor[] _events; // 0x10
	private string[] _namedSort; // 0x18
	private readonly IComparer _comparer; // 0x20
	private bool _eventsOwned; // 0x28
	private bool _needSort; // 0x29
	private readonly bool _readOnly; // 0x2A
	public static readonly EventDescriptorCollection Empty; // 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x2C

	// Properties
	public int Count { get; set; }
	public virtual EventDescriptor Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }

	// Methods

	// RVA: 0x1D34128 Offset: 0x1D30128 VA: 0x1D34128
	public void .ctor(EventDescriptor[] events) { }

	// RVA: 0x1D34208 Offset: 0x1D30208 VA: 0x1D34208
	public void .ctor(EventDescriptor[] events, bool readOnly) { }

	[CompilerGenerated]
	// RVA: 0x1D3422C Offset: 0x1D3022C VA: 0x1D3422C
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x1D34234 Offset: 0x1D30234 VA: 0x1D34234
	private void set_Count(int value) { }

	// RVA: 0x1D3423C Offset: 0x1D3023C VA: 0x1D3423C Slot: 20
	public virtual EventDescriptor get_Item(int index) { }

	// RVA: 0x1D3437C Offset: 0x1D3037C VA: 0x1D3437C
	public int Add(EventDescriptor value) { }

	// RVA: 0x1D34570 Offset: 0x1D30570 VA: 0x1D34570
	public void Clear() { }

	// RVA: 0x1D345B8 Offset: 0x1D305B8 VA: 0x1D345B8
	public bool Contains(EventDescriptor value) { }

	// RVA: 0x1D34630 Offset: 0x1D30630 VA: 0x1D34630 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1D342C0 Offset: 0x1D302C0 VA: 0x1D342C0
	private void EnsureEventsOwned() { }

	// RVA: 0x1D3444C Offset: 0x1D3044C VA: 0x1D3444C
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x1D345D0 Offset: 0x1D305D0 VA: 0x1D345D0
	public int IndexOf(EventDescriptor value) { }

	// RVA: 0x1D348E0 Offset: 0x1D308E0 VA: 0x1D348E0
	public void Insert(int index, EventDescriptor value) { }

	// RVA: 0x1D349D0 Offset: 0x1D309D0 VA: 0x1D349D0
	public void Remove(EventDescriptor value) { }

	// RVA: 0x1D34A38 Offset: 0x1D30A38 VA: 0x1D34A38
	public void RemoveAt(int index) { }

	// RVA: 0x1D34AF4 Offset: 0x1D30AF4 VA: 0x1D34AF4
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1D3466C Offset: 0x1D3066C VA: 0x1D3466C
	protected void InternalSort(string[] names) { }

	// RVA: 0x1D34BD4 Offset: 0x1D30BD4 VA: 0x1D34BD4
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x1D34C4C Offset: 0x1D30C4C VA: 0x1D34C4C Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1D34C54 Offset: 0x1D30C54 VA: 0x1D34C54 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1D34C5C Offset: 0x1D30C5C VA: 0x1D34C5C Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1D34C64 Offset: 0x1D30C64 VA: 0x1D34C64 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1D34C68 Offset: 0x1D30C68 VA: 0x1D34C68 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1D34C78 Offset: 0x1D30C78 VA: 0x1D34C78 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1D34DE4 Offset: 0x1D30DE4 VA: 0x1D34DE4 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1D34E68 Offset: 0x1D30E68 VA: 0x1D34E68 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1D34EF8 Offset: 0x1D30EF8 VA: 0x1D34EF8 Slot: 13
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1D34EFC Offset: 0x1D30EFC VA: 0x1D34EFC Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1D34F80 Offset: 0x1D30F80 VA: 0x1D34F80 Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1D35014 Offset: 0x1D31014 VA: 0x1D35014 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1D35098 Offset: 0x1D31098 VA: 0x1D35098 Slot: 19
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1D3509C Offset: 0x1D3109C VA: 0x1D3509C Slot: 14
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1D350A4 Offset: 0x1D310A4 VA: 0x1D350A4 Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1D350AC Offset: 0x1D310AC VA: 0x1D350AC
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class ExpandableObjectConverter : TypeConverter // TypeDefIndex: 3997
{
	// Methods

	// RVA: 0x1D351A8 Offset: 0x1D311A8 VA: 0x1D351A8
	public void .ctor() { }

	// RVA: 0x1D351B0 Offset: 0x1D311B0 VA: 0x1D351B0 Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1D35218 Offset: 0x1D31218 VA: 0x1D35218 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }
}

// Namespace: System.ComponentModel
internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 3998
{
	// Fields
	private readonly ReflectPropertyDescriptor _extenderInfo; // 0x88
	private readonly IExtenderProvider _provider; // 0x90

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	public override string DisplayName { get; }

	// Methods

	// RVA: 0x1D35220 Offset: 0x1D31220 VA: 0x1D35220
	public void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	// RVA: 0x1D3552C Offset: 0x1D3152C VA: 0x1D3552C Slot: 17
	public override bool CanResetValue(object comp) { }

	// RVA: 0x1D357CC Offset: 0x1D317CC VA: 0x1D357CC Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x1D357EC Offset: 0x1D317EC VA: 0x1D357EC Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x1D358D0 Offset: 0x1D318D0 VA: 0x1D358D0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x1D35900 Offset: 0x1D31900 VA: 0x1D35900 Slot: 9
	public override string get_DisplayName() { }

	// RVA: 0x1D35CD4 Offset: 0x1D31CD4 VA: 0x1D35CD4 Slot: 18
	public override object GetValue(object comp) { }

	// RVA: 0x1D35E30 Offset: 0x1D31E30 VA: 0x1D35E30 Slot: 20
	public override void ResetValue(object comp) { }

	// RVA: 0x1D362E4 Offset: 0x1D322E4 VA: 0x1D362E4 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x1D36778 Offset: 0x1D32778 VA: 0x1D36778 Slot: 22
	public override bool ShouldSerializeValue(object comp) { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class ExtenderProvidedPropertyAttribute : Attribute // TypeDefIndex: 3999
{
	// Fields
	[CompilerGenerated]
	private PropertyDescriptor <ExtenderProperty>k__BackingField; // 0x10
	[CompilerGenerated]
	private IExtenderProvider <Provider>k__BackingField; // 0x18
	[CompilerGenerated]
	private Type <ReceiverType>k__BackingField; // 0x20

	// Properties
	public PropertyDescriptor ExtenderProperty { get; set; }
	public IExtenderProvider Provider { get; set; }
	public Type ReceiverType { get; set; }

	// Methods

	// RVA: 0x1D3548C Offset: 0x1D3148C VA: 0x1D3548C
	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	// RVA: 0x1D36BD0 Offset: 0x1D32BD0 VA: 0x1D36BD0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1D36BD8 Offset: 0x1D32BD8 VA: 0x1D36BD8
	public PropertyDescriptor get_ExtenderProperty() { }

	[CompilerGenerated]
	// RVA: 0x1D36BE0 Offset: 0x1D32BE0 VA: 0x1D36BE0
	private void set_ExtenderProperty(PropertyDescriptor value) { }

	[CompilerGenerated]
	// RVA: 0x1D36BE8 Offset: 0x1D32BE8 VA: 0x1D36BE8
	public IExtenderProvider get_Provider() { }

	[CompilerGenerated]
	// RVA: 0x1D36BF0 Offset: 0x1D32BF0 VA: 0x1D36BF0
	private void set_Provider(IExtenderProvider value) { }

	[CompilerGenerated]
	// RVA: 0x1D36BF8 Offset: 0x1D32BF8 VA: 0x1D36BF8
	public Type get_ReceiverType() { }

	[CompilerGenerated]
	// RVA: 0x1D36C00 Offset: 0x1D32C00 VA: 0x1D36C00
	private void set_ReceiverType(Type value) { }

	// RVA: 0x1D36C08 Offset: 0x1D32C08 VA: 0x1D36C08 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D36CD4 Offset: 0x1D32CD4 VA: 0x1D36CD4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D36CDC Offset: 0x1D32CDC VA: 0x1D36CDC Slot: 6
	public override bool IsDefaultAttribute() { }
}

// Namespace: System.ComponentModel
public class GuidConverter : TypeConverter // TypeDefIndex: 4000
{
	// Methods

	// RVA: 0x1D36D14 Offset: 0x1D32D14 VA: 0x1D36D14 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1D36DA0 Offset: 0x1D32DA0 VA: 0x1D36DA0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1D36E50 Offset: 0x1D32E50 VA: 0x1D36E50 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1D36F24 Offset: 0x1D32F24 VA: 0x1D36F24 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D3723C Offset: 0x1D3323C VA: 0x1D3723C
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public interface IBindingList : IList, ICollection, IEnumerable // TypeDefIndex: 4001
{}

// Namespace: System.ComponentModel
public interface ICustomTypeDescriptor // TypeDefIndex: 4002
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract AttributeCollection GetAttributes();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TypeConverter GetConverter();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract PropertyDescriptorCollection GetProperties();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract PropertyDescriptorCollection GetProperties(Attribute[] attributes);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetPropertyOwner(PropertyDescriptor pd);
}

// Namespace: System.ComponentModel
public interface IExtenderProvider // TypeDefIndex: 4003
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanExtend(object extendee);
}

// Namespace: System.ComponentModel
public interface ITypeDescriptorContext : IServiceProvider // TypeDefIndex: 4004
{
	// Properties
	public abstract IContainer Container { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IContainer get_Container();
}

// Namespace: System.ComponentModel
public class Int16Converter : BaseNumberConverter // TypeDefIndex: 4005
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1D37244 Offset: 0x1D33244 VA: 0x1D37244 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x1D37274 Offset: 0x1D33274 VA: 0x1D37274 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1D372FC Offset: 0x1D332FC VA: 0x1D372FC Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D37334 Offset: 0x1D33334 VA: 0x1D37334 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D373D8 Offset: 0x1D333D8 VA: 0x1D373D8
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class Int32Converter : BaseNumberConverter // TypeDefIndex: 4006
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1D373E0 Offset: 0x1D333E0 VA: 0x1D373E0 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x1D37410 Offset: 0x1D33410 VA: 0x1D37410 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1D37498 Offset: 0x1D33498 VA: 0x1D37498 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D374D0 Offset: 0x1D334D0 VA: 0x1D374D0 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D37574 Offset: 0x1D33574 VA: 0x1D37574
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class Int64Converter : BaseNumberConverter // TypeDefIndex: 4007
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1D3757C Offset: 0x1D3357C VA: 0x1D3757C Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x1D375AC Offset: 0x1D335AC VA: 0x1D375AC Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1D37634 Offset: 0x1D33634 VA: 0x1D37634 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D3766C Offset: 0x1D3366C VA: 0x1D3766C Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D37710 Offset: 0x1D33710 VA: 0x1D37710
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class ListBindableAttribute : Attribute // TypeDefIndex: 4008
{
	// Fields
	public static readonly ListBindableAttribute Yes; // 0x0
	public static readonly ListBindableAttribute No; // 0x8
	public static readonly ListBindableAttribute Default; // 0x10
	private bool _isDefault; // 0x10
	[CompilerGenerated]
	private readonly bool <ListBindable>k__BackingField; // 0x11

	// Properties
	public bool ListBindable { get; }

	// Methods

	// RVA: 0x1D37718 Offset: 0x1D33718 VA: 0x1D37718
	public void .ctor(bool listBindable) { }

	[CompilerGenerated]
	// RVA: 0x1D37740 Offset: 0x1D33740 VA: 0x1D37740
	public bool get_ListBindable() { }

	// RVA: 0x1D37748 Offset: 0x1D33748 VA: 0x1D37748 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D377D4 Offset: 0x1D337D4 VA: 0x1D377D4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D377DC Offset: 0x1D337DC VA: 0x1D377DC Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1D37860 Offset: 0x1D33860 VA: 0x1D37860
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class ListChangedEventArgs : EventArgs // TypeDefIndex: 4009
{
	// Fields
	[CompilerGenerated]
	private readonly ListChangedType <ListChangedType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <NewIndex>k__BackingField; // 0x14
	[CompilerGenerated]
	private readonly int <OldIndex>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly PropertyDescriptor <PropertyDescriptor>k__BackingField; // 0x20

	// Properties
	public ListChangedType ListChangedType { get; }
	public int NewIndex { get; }
	public int OldIndex { get; }

	// Methods

	// RVA: 0x1D37910 Offset: 0x1D33910 VA: 0x1D37910
	public void .ctor(ListChangedType listChangedType, int newIndex) { }

	// RVA: 0x1D37998 Offset: 0x1D33998 VA: 0x1D37998
	public void .ctor(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	// RVA: 0x1D379D4 Offset: 0x1D339D4 VA: 0x1D379D4
	public void .ctor(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	// RVA: 0x1D37918 Offset: 0x1D33918 VA: 0x1D37918
	public void .ctor(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	[CompilerGenerated]
	// RVA: 0x1D37A50 Offset: 0x1D33A50 VA: 0x1D37A50
	public ListChangedType get_ListChangedType() { }

	[CompilerGenerated]
	// RVA: 0x1D37A58 Offset: 0x1D33A58 VA: 0x1D37A58
	public int get_NewIndex() { }

	[CompilerGenerated]
	// RVA: 0x1D37A60 Offset: 0x1D33A60 VA: 0x1D37A60
	public int get_OldIndex() { }
}

// Namespace: System.ComponentModel
public sealed class ListChangedEventHandler : MulticastDelegate // TypeDefIndex: 4010
{
	// Methods

	// RVA: 0x1D37A68 Offset: 0x1D33A68 VA: 0x1D37A68
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D37B74 Offset: 0x1D33B74 VA: 0x1D37B74 Slot: 12
	public virtual void Invoke(object sender, ListChangedEventArgs e) { }
}

// Namespace: System.ComponentModel
public enum ListChangedType // TypeDefIndex: 4011
{
	// Fields
	public int value__; // 0x0
	public const ListChangedType Reset = 0;
	public const ListChangedType ItemAdded = 1;
	public const ListChangedType ItemDeleted = 2;
	public const ListChangedType ItemMoved = 3;
	public const ListChangedType ItemChanged = 4;
	public const ListChangedType PropertyDescriptorAdded = 5;
	public const ListChangedType PropertyDescriptorDeleted = 6;
	public const ListChangedType PropertyDescriptorChanged = 7;
}

// Namespace: System.ComponentModel
[TypeConverter(typeof(ComponentConverter))]
[DesignerCategory("Component")]
public class MarshalByValueComponent : IComponent, IDisposable, IServiceProvider // TypeDefIndex: 4012
{
	// Fields
	private static readonly object s_eventDisposed; // 0x0
	private ISite _site; // 0x10
	private EventHandlerList _events; // 0x18

	// Properties
	[Browsable(False)]
	[DesignerSerializationVisibility(0)]
	public virtual ISite Site { get; }

	// Methods

	// RVA: 0x1D37B88 Offset: 0x1D33B88 VA: 0x1D37B88
	public void .ctor() { }

	// RVA: 0x1D37B90 Offset: 0x1D33B90 VA: 0x1D37B90 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1D37C20 Offset: 0x1D33C20 VA: 0x1D37C20 Slot: 7
	public virtual ISite get_Site() { }

	// RVA: 0x1D37C28 Offset: 0x1D33C28 VA: 0x1D37C28 Slot: 5
	public void Dispose() { }

	// RVA: 0x1D37C94 Offset: 0x1D33C94 VA: 0x1D37C94 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1D37F2C Offset: 0x1D33F2C VA: 0x1D37F2C Slot: 9
	public virtual object GetService(Type service) { }

	// RVA: 0x1D37FE0 Offset: 0x1D33FE0 VA: 0x1D37FE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D38110 Offset: 0x1D34110 VA: 0x1D38110
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class MultilineStringConverter : TypeConverter // TypeDefIndex: 4013
{
	// Methods

	// RVA: 0x1D3818C Offset: 0x1D3418C VA: 0x1D3818C Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D382D8 Offset: 0x1D342D8 VA: 0x1D382D8 Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1D382E0 Offset: 0x1D342E0 VA: 0x1D382E0 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1D382E8 Offset: 0x1D342E8 VA: 0x1D382E8
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class NullableConverter : TypeConverter // TypeDefIndex: 4014
{
	// Fields
	[CompilerGenerated]
	private readonly Type <NullableType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Type <UnderlyingType>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly TypeConverter <UnderlyingTypeConverter>k__BackingField; // 0x20

	// Properties
	public Type NullableType { get; }
	public Type UnderlyingType { get; }
	public TypeConverter UnderlyingTypeConverter { get; }

	// Methods

	// RVA: 0x1D382F0 Offset: 0x1D342F0 VA: 0x1D382F0
	public void .ctor(Type type) { }

	// RVA: 0x1D38428 Offset: 0x1D34428 VA: 0x1D38428 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1D384CC Offset: 0x1D344CC VA: 0x1D384CC Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1D385D4 Offset: 0x1D345D4 VA: 0x1D385D4 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1D38678 Offset: 0x1D34678 VA: 0x1D38678 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D38824 Offset: 0x1D34824 VA: 0x1D38824 Slot: 8
	public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x1D38848 Offset: 0x1D34848 VA: 0x1D38848 Slot: 9
	public override bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1D3886C Offset: 0x1D3486C VA: 0x1D3886C Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1D38890 Offset: 0x1D34890 VA: 0x1D38890 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1D388B4 Offset: 0x1D348B4 VA: 0x1D388B4 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1D38C50 Offset: 0x1D34C50 VA: 0x1D38C50 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1D38C78 Offset: 0x1D34C78 VA: 0x1D38C78 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1D38CA0 Offset: 0x1D34CA0 VA: 0x1D38CA0 Slot: 15
	public override bool IsValid(ITypeDescriptorContext context, object value) { }

	[CompilerGenerated]
	// RVA: 0x1D38CD4 Offset: 0x1D34CD4 VA: 0x1D38CD4
	public Type get_NullableType() { }

	[CompilerGenerated]
	// RVA: 0x1D38CDC Offset: 0x1D34CDC VA: 0x1D38CDC
	public Type get_UnderlyingType() { }

	[CompilerGenerated]
	// RVA: 0x1D38CE4 Offset: 0x1D34CE4 VA: 0x1D38CE4
	public TypeConverter get_UnderlyingTypeConverter() { }
}

// Namespace: System.ComponentModel
public abstract class PropertyDescriptor : MemberDescriptor // TypeDefIndex: 4015
{
	// Fields
	private TypeConverter _converter; // 0x60
	private Hashtable _valueChangedHandlers; // 0x68
	private object[] _editors; // 0x70
	private Type[] _editorTypes; // 0x78
	private int _editorCount; // 0x80

	// Properties
	public abstract Type ComponentType { get; }
	public virtual TypeConverter Converter { get; }
	public abstract bool IsReadOnly { get; }
	public abstract Type PropertyType { get; }

	// Methods

	// RVA: 0x1D38CEC Offset: 0x1D34CEC VA: 0x1D38CEC
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x1D35488 Offset: 0x1D31488 VA: 0x1D35488
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Type get_ComponentType();

	// RVA: 0x1D3930C Offset: 0x1D3530C VA: 0x1D3930C Slot: 14
	public virtual TypeConverter get_Converter() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Type get_PropertyType();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool CanResetValue(object component);

	// RVA: 0x1D39960 Offset: 0x1D35960 VA: 0x1D39960 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D39768 Offset: 0x1D35768 VA: 0x1D39768
	protected object CreateInstance(Type type) { }

	// RVA: 0x1D39B44 Offset: 0x1D35B44 VA: 0x1D39B44 Slot: 11
	protected override void FillAttributes(IList attributeList) { }

	// RVA: 0x1D39C8C Offset: 0x1D35C8C VA: 0x1D39C8C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D39CE0 Offset: 0x1D35CE0 VA: 0x1D39CE0 Slot: 12
	protected override object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x1D39578 Offset: 0x1D35578 VA: 0x1D39578
	protected Type GetTypeFromName(string typeName) { }

	// RVA: -1 Offset: -1 Slot: 18
	public abstract object GetValue(object component);

	// RVA: 0x1D39EB8 Offset: 0x1D35EB8 VA: 0x1D39EB8 Slot: 19
	protected virtual void OnValueChanged(object component, EventArgs e) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ResetValue(object component);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void SetValue(object component, object value);

	// RVA: -1 Offset: -1 Slot: 22
	public abstract bool ShouldSerializeValue(object component);
}

// Namespace: 
private class PropertyDescriptorCollection.PropertyDescriptorEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 4016
{
	// Fields
	private PropertyDescriptorCollection _owner; // 0x10
	private int _index; // 0x18

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1D3B350 Offset: 0x1D37350 VA: 0x1D3B350
	public void .ctor(PropertyDescriptorCollection owner) { }

	// RVA: 0x1D3BE2C Offset: 0x1D37E2C VA: 0x1D3BE2C Slot: 8
	public object get_Current() { }

	// RVA: 0x1D3BE90 Offset: 0x1D37E90 VA: 0x1D3BE90 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x1D3BEF8 Offset: 0x1D37EF8 VA: 0x1D3BEF8 Slot: 4
	public object get_Key() { }

	// RVA: 0x1D3BF34 Offset: 0x1D37F34 VA: 0x1D3BF34 Slot: 5
	public object get_Value() { }

	// RVA: 0x1D3BF70 Offset: 0x1D37F70 VA: 0x1D3BF70 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x1D3BFA8 Offset: 0x1D37FA8 VA: 0x1D3BFA8 Slot: 9
	public void Reset() { }
}

// Namespace: System.ComponentModel
[DefaultMember("Item")]
public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary // TypeDefIndex: 4017
{
	// Fields
	public static readonly PropertyDescriptorCollection Empty; // 0x0
	private IDictionary _cachedFoundProperties; // 0x10
	private bool _cachedIgnoreCase; // 0x18
	private PropertyDescriptor[] _properties; // 0x20
	private readonly string[] _namedSort; // 0x28
	private readonly IComparer _comparer; // 0x30
	private bool _propsOwned; // 0x38
	private bool _needSort; // 0x39
	private bool _readOnly; // 0x3A
	private readonly object _internalSyncObject; // 0x40
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x48

	// Properties
	public int Count { get; set; }
	public virtual PropertyDescriptor Item { get; }
	public virtual PropertyDescriptor Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x1D39F68 Offset: 0x1D35F68 VA: 0x1D39F68
	public void .ctor(PropertyDescriptor[] properties) { }

	// RVA: 0x1D3A088 Offset: 0x1D36088 VA: 0x1D3A088
	public void .ctor(PropertyDescriptor[] properties, bool readOnly) { }

	// RVA: 0x1D3A0AC Offset: 0x1D360AC VA: 0x1D3A0AC
	private void .ctor(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer) { }

	[CompilerGenerated]
	// RVA: 0x1D3A1F8 Offset: 0x1D361F8 VA: 0x1D3A1F8
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x1D3A200 Offset: 0x1D36200 VA: 0x1D3A200
	private void set_Count(int value) { }

	// RVA: 0x1D3A208 Offset: 0x1D36208 VA: 0x1D3A208 Slot: 29
	public virtual PropertyDescriptor get_Item(int index) { }

	// RVA: 0x1D3A348 Offset: 0x1D36348 VA: 0x1D3A348 Slot: 30
	public virtual PropertyDescriptor get_Item(string name) { }

	// RVA: 0x1D3A35C Offset: 0x1D3635C VA: 0x1D3A35C
	public int Add(PropertyDescriptor value) { }

	// RVA: 0x1D3A550 Offset: 0x1D36550 VA: 0x1D3A550
	public void Clear() { }

	// RVA: 0x1D3A5A0 Offset: 0x1D365A0 VA: 0x1D3A5A0
	public bool Contains(PropertyDescriptor value) { }

	// RVA: 0x1D3A618 Offset: 0x1D36618 VA: 0x1D3A618 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1D3A28C Offset: 0x1D3628C VA: 0x1D3A28C
	private void EnsurePropsOwned() { }

	// RVA: 0x1D3A42C Offset: 0x1D3642C VA: 0x1D3A42C
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x1D3A8C8 Offset: 0x1D368C8 VA: 0x1D3A8C8 Slot: 31
	public virtual PropertyDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x1D3A5B8 Offset: 0x1D365B8 VA: 0x1D3A5B8
	public int IndexOf(PropertyDescriptor value) { }

	// RVA: 0x1D3ADFC Offset: 0x1D36DFC VA: 0x1D3ADFC
	public void Insert(int index, PropertyDescriptor value) { }

	// RVA: 0x1D3AEEC Offset: 0x1D36EEC VA: 0x1D3AEEC
	public void Remove(PropertyDescriptor value) { }

	// RVA: 0x1D3AF54 Offset: 0x1D36F54 VA: 0x1D3AF54
	public void RemoveAt(int index) { }

	// RVA: 0x1D3B010 Offset: 0x1D37010 VA: 0x1D3B010 Slot: 32
	public virtual PropertyDescriptorCollection Sort(string[] names) { }

	// RVA: 0x1D3A654 Offset: 0x1D36654 VA: 0x1D3A654
	protected void InternalSort(string[] names) { }

	// RVA: 0x1D3B08C Offset: 0x1D3708C VA: 0x1D3B08C
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x1D3B104 Offset: 0x1D37104 VA: 0x1D3B104 Slot: 33
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1D3B1A0 Offset: 0x1D371A0 VA: 0x1D3B1A0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1D3B1A8 Offset: 0x1D371A8 VA: 0x1D3B1A8 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1D3B1B0 Offset: 0x1D371B0 VA: 0x1D3B1B0 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1D3B1B8 Offset: 0x1D371B8 VA: 0x1D3B1B8 Slot: 13
	private void System.Collections.IList.Clear() { }

	// RVA: 0x1D3B1BC Offset: 0x1D371BC VA: 0x1D3B1BC Slot: 25
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x1D3B1C0 Offset: 0x1D371C0 VA: 0x1D3B1C0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1D3B1D0 Offset: 0x1D371D0 VA: 0x1D3B1D0 Slot: 19
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x1D3B1D4 Offset: 0x1D371D4 VA: 0x1D3B1D4 Slot: 24
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x1D3B298 Offset: 0x1D37298 VA: 0x1D3B298 Slot: 23
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x1D3B2E0 Offset: 0x1D372E0 VA: 0x1D3B2E0 Slot: 27
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x1D3B388 Offset: 0x1D37388 VA: 0x1D3B388 Slot: 26
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x1D3B390 Offset: 0x1D37390 VA: 0x1D3B390 Slot: 20
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x1D3B3C4 Offset: 0x1D373C4 VA: 0x1D3B3C4 Slot: 21
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x1D3B75C Offset: 0x1D3775C VA: 0x1D3B75C Slot: 22
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x1D3B834 Offset: 0x1D37834 VA: 0x1D3B834 Slot: 28
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x1D3B91C Offset: 0x1D3791C VA: 0x1D3B91C Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x1D3B9A0 Offset: 0x1D379A0 VA: 0x1D3B9A0 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x1D3BA30 Offset: 0x1D37A30 VA: 0x1D3BA30 Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x1D3BAB4 Offset: 0x1D37AB4 VA: 0x1D3BAB4 Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1D3BB48 Offset: 0x1D37B48 VA: 0x1D3BB48 Slot: 14
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1D3BB50 Offset: 0x1D37B50 VA: 0x1D3BB50 Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x1D3BB58 Offset: 0x1D37B58 VA: 0x1D3BB58 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x1D3BBDC Offset: 0x1D37BDC VA: 0x1D3BBDC Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x1D3BBEC Offset: 0x1D37BEC VA: 0x1D3BBEC Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x1D3BDBC Offset: 0x1D37DBC VA: 0x1D3BDBC
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Usage(4, AllowMultiple = True)]
public sealed class ProvidePropertyAttribute : Attribute // TypeDefIndex: 4018
{
	// Fields
	[CompilerGenerated]
	private readonly string <PropertyName>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <ReceiverTypeName>k__BackingField; // 0x18

	// Properties
	public string PropertyName { get; }
	public string ReceiverTypeName { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D3BFB4 Offset: 0x1D37FB4 VA: 0x1D3BFB4
	public string get_PropertyName() { }

	[CompilerGenerated]
	// RVA: 0x1D3BFBC Offset: 0x1D37FBC VA: 0x1D3BFBC
	public string get_ReceiverTypeName() { }
}

// Namespace: 
private class ReferenceConverter.ReferenceComparer : IComparer // TypeDefIndex: 4019
{
	// Fields
	private ReferenceConverter _converter; // 0x10

	// Methods

	// RVA: 0x1D3CF80 Offset: 0x1D38F80 VA: 0x1D3CF80
	public void .ctor(ReferenceConverter converter) { }

	// RVA: 0x1D3D030 Offset: 0x1D39030 VA: 0x1D3D030 Slot: 4
	public int Compare(object item1, object item2) { }
}

// Namespace: System.ComponentModel
public class ReferenceConverter : TypeConverter // TypeDefIndex: 4020
{
	// Fields
	private static readonly string s_none; // 0x0
	private Type _type; // 0x10

	// Methods

	// RVA: 0x1D3BFC4 Offset: 0x1D37FC4 VA: 0x1D3BFC4
	public void .ctor(Type type) { }

	// RVA: 0x1D3BFF4 Offset: 0x1D37FF4 VA: 0x1D3BFF4 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1D3C084 Offset: 0x1D38084 VA: 0x1D3C084 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1D3C3AC Offset: 0x1D383AC VA: 0x1D3C3AC Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D3C7C8 Offset: 0x1D387C8 VA: 0x1D3C7C8 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1D3CFB0 Offset: 0x1D38FB0 VA: 0x1D3CFB0 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1D3CFB8 Offset: 0x1D38FB8 VA: 0x1D3CFB8 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1D3CFC0 Offset: 0x1D38FC0 VA: 0x1D3CFC0 Slot: 16
	protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1D3CFC8 Offset: 0x1D38FC8 VA: 0x1D3CFC8
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class RefreshEventArgs : EventArgs // TypeDefIndex: 4021
{
	// Fields
	[CompilerGenerated]
	private readonly Type <TypeChanged>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1D3D0E8 Offset: 0x1D390E8 VA: 0x1D3D0E8
	public void .ctor(Type typeChanged) { }
}

// Namespace: System.ComponentModel
public sealed class RefreshEventHandler : MulticastDelegate // TypeDefIndex: 4022
{
	// Methods

	// RVA: 0x1D3D15C Offset: 0x1D3915C VA: 0x1D3D15C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D3D264 Offset: 0x1D39264 VA: 0x1D3D264 Slot: 12
	public virtual void Invoke(RefreshEventArgs e) { }
}

// Namespace: System.ComponentModel
public class SByteConverter : BaseNumberConverter // TypeDefIndex: 4023
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1D3D278 Offset: 0x1D39278 VA: 0x1D3D278 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x1D3D2A8 Offset: 0x1D392A8 VA: 0x1D3D2A8 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1D3D330 Offset: 0x1D39330 VA: 0x1D3D330 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D3D368 Offset: 0x1D39368 VA: 0x1D3D368 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D3D40C Offset: 0x1D3940C VA: 0x1D3D40C
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class SingleConverter : BaseNumberConverter // TypeDefIndex: 4024
{
	// Properties
	internal override bool AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1D3D414 Offset: 0x1D39414 VA: 0x1D3D414 Slot: 16
	internal override bool get_AllowHex() { }

	// RVA: 0x1D3D41C Offset: 0x1D3941C VA: 0x1D3D41C Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x1D3D44C Offset: 0x1D3944C VA: 0x1D3D44C Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1D3D500 Offset: 0x1D39500 VA: 0x1D3D500 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D3D534 Offset: 0x1D39534 VA: 0x1D3D534 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D3D5D8 Offset: 0x1D395D8 VA: 0x1D3D5D8
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class StringConverter : TypeConverter // TypeDefIndex: 4025
{
	// Methods

	// RVA: 0x1D3D5E0 Offset: 0x1D395E0 VA: 0x1D3D5E0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1D3D66C Offset: 0x1D3966C VA: 0x1D3D66C Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1D3D6A0 Offset: 0x1D396A0 VA: 0x1D3D6A0
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class TimeSpanConverter : TypeConverter // TypeDefIndex: 4026
{
	// Methods

	// RVA: 0x1D3D6A8 Offset: 0x1D396A8 VA: 0x1D3D6A8 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1D3D734 Offset: 0x1D39734 VA: 0x1D3D734 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1D3D7E4 Offset: 0x1D397E4 VA: 0x1D3D7E4 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1D3D9E0 Offset: 0x1D399E0 VA: 0x1D3D9E0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D3DCE4 Offset: 0x1D39CE4 VA: 0x1D3DCE4
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class TypeConverterAttribute : Attribute // TypeDefIndex: 4027
{
	// Fields
	public static readonly TypeConverterAttribute Default; // 0x0
	[CompilerGenerated]
	private readonly string <ConverterTypeName>k__BackingField; // 0x10

	// Properties
	public string ConverterTypeName { get; }

	// Methods

	// RVA: 0x1D3DCEC Offset: 0x1D39CEC VA: 0x1D3DCEC
	public void .ctor() { }

	// RVA: 0x1D3DD20 Offset: 0x1D39D20 VA: 0x1D3DD20
	public void .ctor(Type type) { }

	// RVA: 0x1D3DD6C Offset: 0x1D39D6C VA: 0x1D3DD6C
	public void .ctor(string typeName) { }

	[CompilerGenerated]
	// RVA: 0x1D3DD9C Offset: 0x1D39D9C VA: 0x1D3DD9C
	public string get_ConverterTypeName() { }

	// RVA: 0x1D3DDA4 Offset: 0x1D39DA4 VA: 0x1D3DDA4 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D3DE18 Offset: 0x1D39E18 VA: 0x1D3DE18 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D3DE34 Offset: 0x1D39E34 VA: 0x1D3DE34
	private static void .cctor() { }
}

// Namespace: 
private sealed class TypeDescriptionProvider.EmptyCustomTypeDescriptor : CustomTypeDescriptor // TypeDefIndex: 4028
{
	// Methods

	// RVA: 0x1D3E028 Offset: 0x1D3A028 VA: 0x1D3E028
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public abstract class TypeDescriptionProvider // TypeDefIndex: 4029
{
	// Fields
	private readonly TypeDescriptionProvider _parent; // 0x10
	private TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

	// Methods

	// RVA: 0x1D3360C Offset: 0x1D2F60C VA: 0x1D3360C
	protected void .ctor() { }

	// RVA: 0x1D3DEBC Offset: 0x1D39EBC VA: 0x1D3DEBC Slot: 4
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1D3DF7C Offset: 0x1D39F7C VA: 0x1D3DF7C Slot: 5
	public virtual IDictionary GetCache(object instance) { }

	// RVA: 0x1D3DF94 Offset: 0x1D39F94 VA: 0x1D3DF94 Slot: 6
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1D3E030 Offset: 0x1D3A030 VA: 0x1D3E030 Slot: 7
	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1D3E138 Offset: 0x1D3A138 VA: 0x1D3E138
	public Type GetReflectionType(Type objectType) { }

	// RVA: 0x1D3E148 Offset: 0x1D3A148 VA: 0x1D3E148 Slot: 8
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x1D3E164 Offset: 0x1D3A164 VA: 0x1D3E164
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	// RVA: 0x1D3E174 Offset: 0x1D3A174 VA: 0x1D3E174
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	// RVA: 0x1D3E1FC Offset: 0x1D3A1FC VA: 0x1D3E1FC Slot: 9
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }
}

// Namespace: System.ComponentModel
[Usage(4, Inherited = True)]
public sealed class TypeDescriptionProviderAttribute : Attribute // TypeDefIndex: 4030
{
	// Fields
	[CompilerGenerated]
	private readonly string <TypeName>k__BackingField; // 0x10

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x1D3E2A4 Offset: 0x1D3A2A4 VA: 0x1D3E2A4
	public void .ctor(string typeName) { }

	[CompilerGenerated]
	// RVA: 0x1D3E320 Offset: 0x1D3A320 VA: 0x1D3E320
	public string get_TypeName() { }
}

// Namespace: System.ComponentModel
public abstract class TypeListConverter : TypeConverter // TypeDefIndex: 4031
{
	// Fields
	private readonly Type[] _types; // 0x10
	private TypeConverter.StandardValuesCollection _values; // 0x18

	// Methods

	// RVA: 0x1D3E328 Offset: 0x1D3A328 VA: 0x1D3E328
	protected void .ctor(Type[] types) { }

	// RVA: 0x1D3E358 Offset: 0x1D3A358 VA: 0x1D3E358 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1D3E3E4 Offset: 0x1D3A3E4 VA: 0x1D3E3E4 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1D3E494 Offset: 0x1D3A494 VA: 0x1D3E494 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1D3E590 Offset: 0x1D3A590 VA: 0x1D3E590 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D3E720 Offset: 0x1D3A720 VA: 0x1D3E720 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1D3E7EC Offset: 0x1D3A7EC VA: 0x1D3E7EC Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1D3E7F4 Offset: 0x1D3A7F4 VA: 0x1D3E7F4 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }
}

// Namespace: System.ComponentModel
public class UInt16Converter : BaseNumberConverter // TypeDefIndex: 4032
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1D3E7FC Offset: 0x1D3A7FC VA: 0x1D3E7FC Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x1D3E82C Offset: 0x1D3A82C VA: 0x1D3E82C Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1D3E8B4 Offset: 0x1D3A8B4 VA: 0x1D3E8B4 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D3E8EC Offset: 0x1D3A8EC VA: 0x1D3E8EC Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D3E990 Offset: 0x1D3A990 VA: 0x1D3E990
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class UInt32Converter : BaseNumberConverter // TypeDefIndex: 4033
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1D3E998 Offset: 0x1D3A998 VA: 0x1D3E998 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x1D3E9C8 Offset: 0x1D3A9C8 VA: 0x1D3E9C8 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1D3EA50 Offset: 0x1D3AA50 VA: 0x1D3EA50 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D3EA88 Offset: 0x1D3AA88 VA: 0x1D3EA88 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D3EB2C Offset: 0x1D3AB2C VA: 0x1D3EB2C
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class UInt64Converter : BaseNumberConverter // TypeDefIndex: 4034
{
	// Properties
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x1D3EB34 Offset: 0x1D3AB34 VA: 0x1D3EB34 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x1D3EB64 Offset: 0x1D3AB64 VA: 0x1D3EB64 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x1D3EBEC Offset: 0x1D3ABEC VA: 0x1D3EBEC Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D3EC24 Offset: 0x1D3AC24 VA: 0x1D3EC24 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x1D3ECC8 Offset: 0x1D3ACC8 VA: 0x1D3ECC8
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public interface IChangeTracking // TypeDefIndex: 4035
{
	// Properties
	public abstract bool IsChanged { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsChanged();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AcceptChanges();
}

// Namespace: System.ComponentModel
public interface IRevertibleChangeTracking : IChangeTracking // TypeDefIndex: 4036
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RejectChanges();
}

// Namespace: System.ComponentModel
public class PropertyChangedEventArgs : EventArgs // TypeDefIndex: 4037
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Methods

	// RVA: 0x1D3ECD0 Offset: 0x1D3ACD0 VA: 0x1D3ECD0
	public void .ctor(string propertyName) { }
}

// Namespace: System.ComponentModel
public sealed class PropertyChangedEventHandler : MulticastDelegate // TypeDefIndex: 4038
{
	// Methods

	// RVA: 0x1D3ED44 Offset: 0x1D3AD44 VA: 0x1D3ED44
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D3EE50 Offset: 0x1D3AE50 VA: 0x1D3EE50 Slot: 12
	public virtual void Invoke(object sender, PropertyChangedEventArgs e) { }
}

// Namespace: System.ComponentModel
public class PropertyChangingEventArgs : EventArgs // TypeDefIndex: 4039
{
	// Fields
	private readonly string _propertyName; // 0x10

	// Methods

	// RVA: 0x1D3EE64 Offset: 0x1D3AE64 VA: 0x1D3EE64
	public void .ctor(string propertyName) { }
}

// Namespace: System.ComponentModel
public sealed class PropertyChangingEventHandler : MulticastDelegate // TypeDefIndex: 4040
{
	// Methods

	// RVA: 0x1D3EED8 Offset: 0x1D3AED8 VA: 0x1D3EED8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D3EFE4 Offset: 0x1D3AFE4 VA: 0x1D3EFE4 Slot: 12
	public virtual void Invoke(object sender, PropertyChangingEventArgs e) { }
}

// Namespace: System.ComponentModel
public class CollectionConverter : TypeConverter // TypeDefIndex: 4041
{
	// Methods

	// RVA: 0x1D3EFF8 Offset: 0x1D3AFF8 VA: 0x1D3EFF8 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D3F158 Offset: 0x1D3B158 VA: 0x1D3F158 Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1D3F160 Offset: 0x1D3B160 VA: 0x1D3F160 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1D3F168 Offset: 0x1D3B168 VA: 0x1D3F168
	public void .ctor() { }
}

// Namespace: System.ComponentModel
[ComVisible(True)]
[DesignerCategory("Component")]
[ClassInterface(1)]
public class Component : MarshalByRefObject // TypeDefIndex: 4042
{
	// Fields
	private static readonly object EventDisposed; // 0x0

	// Properties
	protected virtual bool CanRaiseEvents { get; }
	internal bool CanRaiseEventsInternal { get; }

	// Methods

	// RVA: 0x1D3F170 Offset: 0x1D3B170 VA: 0x1D3F170 Slot: 6
	protected virtual bool get_CanRaiseEvents() { }

	// RVA: 0x1D3F178 Offset: 0x1D3B178 VA: 0x1D3F178
	internal bool get_CanRaiseEventsInternal() { }

	// RVA: 0x1D3F184 Offset: 0x1D3B184 VA: 0x1D3F184
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
public class ComponentConverter : ReferenceConverter // TypeDefIndex: 4043
{
	// Methods

	// RVA: 0x1D3F200 Offset: 0x1D3B200 VA: 0x1D3F200
	public void .ctor(Type type) { }

	// RVA: 0x1D3F274 Offset: 0x1D3B274 VA: 0x1D3F274 Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1D3F2DC Offset: 0x1D3B2DC VA: 0x1D3F2DC Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }
}

// Namespace: System.ComponentModel
public class DateTimeOffsetConverter : TypeConverter // TypeDefIndex: 4044
{
	// Methods

	// RVA: 0x1D3F2E4 Offset: 0x1D3B2E4 VA: 0x1D3F2E4 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1D3F370 Offset: 0x1D3B370 VA: 0x1D3F370 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1D3F420 Offset: 0x1D3B420 VA: 0x1D3F420 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1D3F794 Offset: 0x1D3B794 VA: 0x1D3F794 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D403CC Offset: 0x1D3C3CC VA: 0x1D403CC
	public void .ctor() { }
}

// Namespace: System.ComponentModel
public class EnumConverter : TypeConverter // TypeDefIndex: 4045
{
	// Fields
	private TypeConverter.StandardValuesCollection values; // 0x10
	private Type type; // 0x18

	// Properties
	protected Type EnumType { get; }
	protected TypeConverter.StandardValuesCollection Values { get; set; }
	protected virtual IComparer Comparer { get; }

	// Methods

	// RVA: 0x1D403D4 Offset: 0x1D3C3D4 VA: 0x1D403D4
	public void .ctor(Type type) { }

	// RVA: 0x1D40404 Offset: 0x1D3C404 VA: 0x1D40404
	protected Type get_EnumType() { }

	// RVA: 0x1D4040C Offset: 0x1D3C40C VA: 0x1D4040C
	protected TypeConverter.StandardValuesCollection get_Values() { }

	// RVA: 0x1D40414 Offset: 0x1D3C414 VA: 0x1D40414
	protected void set_Values(TypeConverter.StandardValuesCollection value) { }

	// RVA: 0x1D4041C Offset: 0x1D3C41C VA: 0x1D4041C Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1D40500 Offset: 0x1D3C500 VA: 0x1D40500 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1D405F8 Offset: 0x1D3C5F8 VA: 0x1D405F8 Slot: 16
	protected virtual IComparer get_Comparer() { }

	// RVA: 0x1D40650 Offset: 0x1D3C650 VA: 0x1D40650 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1D40B1C Offset: 0x1D3CB1C VA: 0x1D40B1C Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D418A0 Offset: 0x1D3D8A0 VA: 0x1D418A0 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1D41C80 Offset: 0x1D3DC80 VA: 0x1D41C80 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1D41D14 Offset: 0x1D3DD14 VA: 0x1D41D14 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1D41D1C Offset: 0x1D3DD1C VA: 0x1D41D1C Slot: 15
	public override bool IsValid(ITypeDescriptorContext context, object value) { }
}

// Namespace: System.ComponentModel
[ComVisible(True)]
[TypeConverter(typeof(ComponentConverter))]
[RootDesignerSerializer("System.ComponentModel.Design.Serialization.RootCodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.ComponentModel.Design.Serialization.CodeDomSerializer, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", True)]
public interface IComponent : IDisposable // TypeDefIndex: 4046
{
	// Properties
	public abstract ISite Site { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISite get_Site();
}

// Namespace: System.ComponentModel
[ComVisible(True)]
public abstract class MemberDescriptor // TypeDefIndex: 4047
{
	// Fields
	private string name; // 0x10
	private string displayName; // 0x18
	private int nameHash; // 0x20
	private AttributeCollection attributeCollection; // 0x28
	private Attribute[] attributes; // 0x30
	private Attribute[] originalAttributes; // 0x38
	private bool attributesFiltered; // 0x40
	private bool attributesFilled; // 0x41
	private int metadataVersion; // 0x44
	private string category; // 0x48
	private string description; // 0x50
	private object lockCookie; // 0x58

	// Properties
	protected virtual Attribute[] AttributeArray { get; set; }
	public virtual AttributeCollection Attributes { get; }
	public virtual string Name { get; }
	protected virtual int NameHashCode { get; }
	public virtual string DisplayName { get; }

	// Methods

	// RVA: 0x1D38CF0 Offset: 0x1D34CF0 VA: 0x1D38CF0
	protected void .ctor(string name, Attribute[] attributes) { }

	// RVA: 0x1D38EC8 Offset: 0x1D34EC8 VA: 0x1D38EC8
	protected void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	// RVA: 0x1D41D60 Offset: 0x1D3DD60 VA: 0x1D41D60 Slot: 4
	protected virtual Attribute[] get_AttributeArray() { }

	// RVA: 0x1D4257C Offset: 0x1D3E57C VA: 0x1D4257C Slot: 5
	protected virtual void set_AttributeArray(Attribute[] value) { }

	// RVA: 0x1D42670 Offset: 0x1D3E670 VA: 0x1D42670 Slot: 6
	public virtual AttributeCollection get_Attributes() { }

	// RVA: 0x1D42774 Offset: 0x1D3E774 VA: 0x1D42774 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x1D427C4 Offset: 0x1D3E7C4 VA: 0x1D427C4 Slot: 8
	protected virtual int get_NameHashCode() { }

	// RVA: 0x1D35AC8 Offset: 0x1D31AC8 VA: 0x1D35AC8 Slot: 9
	public virtual string get_DisplayName() { }

	// RVA: 0x1D41D80 Offset: 0x1D3DD80 VA: 0x1D41D80
	private void CheckAttributesValid() { }

	// RVA: 0x1D427CC Offset: 0x1D3E7CC VA: 0x1D427CC Slot: 10
	protected virtual AttributeCollection CreateAttributeCollection() { }

	// RVA: 0x1D42840 Offset: 0x1D3E840 VA: 0x1D42840 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1D39B98 Offset: 0x1D35B98 VA: 0x1D39B98 Slot: 11
	protected virtual void FillAttributes(IList attributeList) { }

	// RVA: 0x1D41E48 Offset: 0x1D3DE48 VA: 0x1D41E48
	private void FilterAttributesIfNeeded() { }

	// RVA: 0x1D42A88 Offset: 0x1D3EA88 VA: 0x1D42A88
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	// RVA: 0x1D42A90 Offset: 0x1D3EA90 VA: 0x1D42A90
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	// RVA: 0x1D42B34 Offset: 0x1D3EB34 VA: 0x1D42B34 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D39DC0 Offset: 0x1D35DC0 VA: 0x1D39DC0 Slot: 12
	protected virtual object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x1D35BD8 Offset: 0x1D31BD8 VA: 0x1D35BD8
	protected static ISite GetSite(object component) { }
}

// Namespace: System.ComponentModel
internal sealed class ReflectPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4048
{
	// Fields
	private static readonly Type[] argsNone; // 0x0
	private static readonly object noValue; // 0x8
	private static TraceSwitch PropDescCreateSwitch; // 0x10
	private static TraceSwitch PropDescUsageSwitch; // 0x18
	private static readonly int BitDefaultValueQueried; // 0x20
	private static readonly int BitGetQueried; // 0x24
	private static readonly int BitSetQueried; // 0x28
	private static readonly int BitShouldSerializeQueried; // 0x2C
	private static readonly int BitResetQueried; // 0x30
	private static readonly int BitChangedQueried; // 0x34
	private static readonly int BitIPropChangedQueried; // 0x38
	private static readonly int BitReadOnlyChecked; // 0x3C
	private static readonly int BitAmbientValueQueried; // 0x40
	private static readonly int BitSetOnDemand; // 0x44
	private BitVector32 state; // 0x84
	private Type componentClass; // 0x88
	private Type type; // 0x90
	private object defaultValue; // 0x98
	private object ambientValue; // 0xA0
	private PropertyInfo propInfo; // 0xA8
	private MethodInfo getMethod; // 0xB0
	private MethodInfo setMethod; // 0xB8
	private MethodInfo shouldSerializeMethod; // 0xC0
	private MethodInfo resetMethod; // 0xC8
	private EventDescriptor realChangedEvent; // 0xD0
	private Type receiverType; // 0xD8

	// Properties
	private object AmbientValue { get; }
	public override Type ComponentType { get; }
	private object DefaultValue { get; }
	private MethodInfo GetMethodValue { get; }
	private bool IsExtender { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	private MethodInfo ResetMethodValue { get; }
	private MethodInfo SetMethodValue { get; }
	private MethodInfo ShouldSerializeMethodValue { get; }

	// Methods

	// RVA: 0x1D42B3C Offset: 0x1D3EB3C VA: 0x1D42B3C
	public void .ctor(Type componentClass, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x1D42DD8 Offset: 0x1D3EDD8 VA: 0x1D42DD8
	public void .ctor(Type componentClass, string name, Type type, PropertyInfo propInfo, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x1D42F20 Offset: 0x1D3EF20 VA: 0x1D42F20
	public void .ctor(Type componentClass, string name, Type type, Type receiverType, MethodInfo getMethod, MethodInfo setMethod, Attribute[] attrs) { }

	// RVA: 0x1D43010 Offset: 0x1D3F010 VA: 0x1D43010
	private object get_AmbientValue() { }

	// RVA: 0x1D43180 Offset: 0x1D3F180 VA: 0x1D43180 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x1D43188 Offset: 0x1D3F188 VA: 0x1D43188
	private object get_DefaultValue() { }

	// RVA: 0x1D43418 Offset: 0x1D3F418 VA: 0x1D43418
	private MethodInfo get_GetMethodValue() { }

	// RVA: 0x1D43878 Offset: 0x1D3F878 VA: 0x1D43878
	private bool get_IsExtender() { }

	// RVA: 0x1D438B0 Offset: 0x1D3F8B0 VA: 0x1D438B0 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x1D43EC4 Offset: 0x1D3FEC4 VA: 0x1D43EC4 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x1D43ECC Offset: 0x1D3FECC VA: 0x1D43ECC
	private MethodInfo get_ResetMethodValue() { }

	// RVA: 0x1D439A4 Offset: 0x1D3F9A4 VA: 0x1D439A4
	private MethodInfo get_SetMethodValue() { }

	// RVA: 0x1D440BC Offset: 0x1D400BC VA: 0x1D440BC
	private MethodInfo get_ShouldSerializeMethodValue() { }

	// RVA: 0x1D3554C Offset: 0x1D3154C VA: 0x1D3554C
	internal bool ExtenderCanResetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x1D442AC Offset: 0x1D402AC VA: 0x1D442AC
	internal Type ExtenderGetReceiverType() { }

	// RVA: 0x1D358F0 Offset: 0x1D318F0 VA: 0x1D358F0
	internal Type ExtenderGetType(IExtenderProvider provider) { }

	// RVA: 0x1D35CF4 Offset: 0x1D31CF4 VA: 0x1D35CF4
	internal object ExtenderGetValue(IExtenderProvider provider, object component) { }

	// RVA: 0x1D35E50 Offset: 0x1D31E50 VA: 0x1D35E50
	internal void ExtenderResetValue(IExtenderProvider provider, object component, PropertyDescriptor notifyDesc) { }

	// RVA: 0x1D36308 Offset: 0x1D32308 VA: 0x1D36308
	internal void ExtenderSetValue(IExtenderProvider provider, object component, object value, PropertyDescriptor notifyDesc) { }

	// RVA: 0x1D36798 Offset: 0x1D32798 VA: 0x1D36798
	internal bool ExtenderShouldSerializeValue(IExtenderProvider provider, object component) { }

	// RVA: 0x1D442B4 Offset: 0x1D402B4 VA: 0x1D442B4 Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x1D444FC Offset: 0x1D404FC VA: 0x1D444FC Slot: 11
	protected override void FillAttributes(IList attributes) { }

	// RVA: 0x1D45390 Offset: 0x1D41390 VA: 0x1D45390 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x1D45660 Offset: 0x1D41660 VA: 0x1D45660 Slot: 19
	protected override void OnValueChanged(object component, EventArgs e) { }

	// RVA: 0x1D45700 Offset: 0x1D41700 VA: 0x1D45700 Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x1D45B00 Offset: 0x1D41B00 VA: 0x1D45B00 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x1D460E4 Offset: 0x1D420E4 VA: 0x1D460E4 Slot: 22
	public override bool ShouldSerializeValue(object component) { }

	// RVA: 0x1D46408 Offset: 0x1D42408 VA: 0x1D46408
	private static void .cctor() { }
}

// Namespace: 
private class ReflectTypeDescriptionProvider.ReflectedTypeData // TypeDefIndex: 4049
{
	// Fields
	private Type _type; // 0x10
	private AttributeCollection _attributes; // 0x18
	private EventDescriptorCollection _events; // 0x20
	private PropertyDescriptorCollection _properties; // 0x28
	private TypeConverter _converter; // 0x30
	private object[] _editors; // 0x38
	private Type[] _editorTypes; // 0x40
	private int _editorCount; // 0x48

	// Properties
	internal bool IsPopulated { get; }

	// Methods

	// RVA: 0x1D4B580 Offset: 0x1D47580 VA: 0x1D4B580
	internal void .ctor(Type type) { }

	// RVA: 0x1D4B5B0 Offset: 0x1D475B0 VA: 0x1D4B5B0
	internal bool get_IsPopulated() { }

	// RVA: 0x1D4B5CC Offset: 0x1D475CC VA: 0x1D4B5CC
	internal AttributeCollection GetAttributes() { }

	// RVA: 0x1D4BEAC Offset: 0x1D47EAC VA: 0x1D4BEAC
	internal TypeConverter GetConverter(object instance) { }

	// RVA: 0x1D4C588 Offset: 0x1D48588 VA: 0x1D4C588
	internal PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x1D4C3E8 Offset: 0x1D483E8 VA: 0x1D4C3E8
	private Type GetTypeFromName(string typeName) { }

	// RVA: 0x1D4C878 Offset: 0x1D48878 VA: 0x1D4C878
	internal void Refresh() { }
}

// Namespace: System.ComponentModel
internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 4050
{
	// Fields
	private Hashtable _typeData; // 0x20
	private static Type[] _typeConstructor; // 0x0
	private static Hashtable _intrinsicTypeConverters; // 0x8
	private static object _intrinsicReferenceKey; // 0x10
	private static object _intrinsicNullableKey; // 0x18
	private static object _dictionaryKey; // 0x20
	private static Hashtable _propertyCache; // 0x28
	private static Hashtable _attributeCache; // 0x30
	private static Hashtable _extendedPropertyCache; // 0x38
	private static readonly Guid _extenderProviderKey; // 0x40
	private static readonly Guid _extenderPropertiesKey; // 0x50
	private static readonly Guid _extenderProviderPropertiesKey; // 0x60
	private static readonly Type[] _skipInterfaceAttributeList; // 0x70
	private static object _internalSyncObject; // 0x78

	// Properties
	private static Hashtable IntrinsicTypeConverters { get; }

	// Methods

	// RVA: 0x1D46660 Offset: 0x1D42660 VA: 0x1D46660
	internal void .ctor() { }

	// RVA: 0x1D46668 Offset: 0x1D42668 VA: 0x1D46668
	private static Hashtable get_IntrinsicTypeConverters() { }

	// RVA: 0x1D47030 Offset: 0x1D43030 VA: 0x1D47030 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1D471E4 Offset: 0x1D431E4 VA: 0x1D471E4
	private static object CreateInstance(Type objectType, Type callingType) { }

	// RVA: 0x1D472EC Offset: 0x1D432EC VA: 0x1D472EC
	internal AttributeCollection GetAttributes(Type type) { }

	// RVA: 0x1D47584 Offset: 0x1D43584 VA: 0x1D47584 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x1D4788C Offset: 0x1D4388C VA: 0x1D4788C
	internal TypeConverter GetConverter(Type type, object instance) { }

	// RVA: 0x1D478B4 Offset: 0x1D438B4 VA: 0x1D478B4
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	// RVA: 0x1D4790C Offset: 0x1D4390C VA: 0x1D4790C
	internal TypeConverter GetExtendedConverter(object instance) { }

	// RVA: 0x1D47948 Offset: 0x1D43948 VA: 0x1D47948
	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	// RVA: 0x1D48DB8 Offset: 0x1D44DB8 VA: 0x1D48DB8 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1D49238 Offset: 0x1D45238 VA: 0x1D49238
	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	// RVA: 0x1D49D10 Offset: 0x1D45D10 VA: 0x1D49D10
	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	// RVA: 0x1D49DA4 Offset: 0x1D45DA4 VA: 0x1D49DA4 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1D49DAC Offset: 0x1D45DAC VA: 0x1D49DAC
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	// RVA: 0x1D49D3C Offset: 0x1D45D3C VA: 0x1D49D3C
	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	// RVA: 0x1D49DCC Offset: 0x1D45DCC VA: 0x1D49DCC Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x1D4730C Offset: 0x1D4330C VA: 0x1D4730C
	private ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	// RVA: 0x1D49DD4 Offset: 0x1D45DD4 VA: 0x1D49DD4 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x1D49DDC Offset: 0x1D45DDC VA: 0x1D49DDC
	private static Type GetTypeFromName(string typeName) { }

	// RVA: 0x1D49EE0 Offset: 0x1D45EE0 VA: 0x1D49EE0
	internal bool IsPopulated(Type type) { }

	// RVA: 0x1D49F04 Offset: 0x1D45F04 VA: 0x1D49F04
	private static Attribute[] ReflectGetAttributes(Type type) { }

	// RVA: 0x1D44F54 Offset: 0x1D40F54 VA: 0x1D44F54
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	// RVA: 0x1D47E8C Offset: 0x1D43E8C VA: 0x1D47E8C
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	// RVA: 0x1D4A340 Offset: 0x1D46340 VA: 0x1D4A340
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	// RVA: 0x1D4A950 Offset: 0x1D46950 VA: 0x1D4A950
	internal void Refresh(Type type) { }

	// RVA: 0x1D4A974 Offset: 0x1D46974 VA: 0x1D4A974
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	// RVA: 0x1D4B260 Offset: 0x1D47260 VA: 0x1D4B260
	private static void .cctor() { }
}

// Namespace: 
protected abstract class TypeConverter.SimplePropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4051
{
	// Fields
	private Type componentType; // 0x88
	private Type propertyType; // 0x90

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x1D4DB4C Offset: 0x1D49B4C VA: 0x1D4DB4C
	protected void .ctor(Type componentType, string name, Type propertyType) { }

	// RVA: 0x1D4DBC8 Offset: 0x1D49BC8 VA: 0x1D4DBC8
	protected void .ctor(Type componentType, string name, Type propertyType, Attribute[] attributes) { }

	// RVA: 0x1D4DC14 Offset: 0x1D49C14 VA: 0x1D4DC14 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x1D4DC1C Offset: 0x1D49C1C VA: 0x1D4DC1C Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x1D4DCA0 Offset: 0x1D49CA0 VA: 0x1D4DCA0 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x1D4DCA8 Offset: 0x1D49CA8 VA: 0x1D4DCA8 Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x1D4DDE0 Offset: 0x1D49DE0 VA: 0x1D4DDE0 Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x1D4DF00 Offset: 0x1D49F00 VA: 0x1D4DF00 Slot: 22
	public override bool ShouldSerializeValue(object component) { }
}

// Namespace: 
[DefaultMember("Item")]
public class TypeConverter.StandardValuesCollection : ICollection, IEnumerable // TypeDefIndex: 4052
{
	// Fields
	private ICollection values; // 0x10
	private Array valueArray; // 0x18

	// Properties
	public int Count { get; }
	public object Item { get; }
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x1D4DF08 Offset: 0x1D49F08 VA: 0x1D4DF08
	public void .ctor(ICollection values) { }

	// RVA: 0x1D4DFC0 Offset: 0x1D49FC0 VA: 0x1D4DFC0
	public int get_Count() { }

	// RVA: 0x1D4E07C Offset: 0x1D4A07C VA: 0x1D4E07C
	public object get_Item(int index) { }

	// RVA: 0x1D4E27C Offset: 0x1D4A27C VA: 0x1D4E27C
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1D4E334 Offset: 0x1D4A334 VA: 0x1D4E334
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1D4E3D4 Offset: 0x1D4A3D4 VA: 0x1D4E3D4 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x1D4E3D8 Offset: 0x1D4A3D8 VA: 0x1D4E3D8 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1D4E3E0 Offset: 0x1D4A3E0 VA: 0x1D4E3E0 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x1D4E3E8 Offset: 0x1D4A3E8 VA: 0x1D4E3E8 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1D4E3EC Offset: 0x1D4A3EC VA: 0x1D4E3EC Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.ComponentModel
[ComVisible(True)]
public class TypeConverter // TypeDefIndex: 4053
{
	// Fields
	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
	private static bool useCompatibleTypeConversion; // 0x0

	// Properties
	private static bool UseCompatibleTypeConversion { get; }

	// Methods

	// RVA: 0x1D4C8E8 Offset: 0x1D488E8 VA: 0x1D4C8E8
	private static bool get_UseCompatibleTypeConversion() { }

	// RVA: 0x1D4C938 Offset: 0x1D48938 VA: 0x1D4C938
	public bool CanConvertFrom(Type sourceType) { }

	// RVA: 0x1D4C94C Offset: 0x1D4894C VA: 0x1D4C94C Slot: 4
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x1D4C9C0 Offset: 0x1D489C0 VA: 0x1D4C9C0
	public bool CanConvertTo(Type destinationType) { }

	// RVA: 0x1D4C9D4 Offset: 0x1D489D4 VA: 0x1D4C9D4 Slot: 5
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x1D4CA20 Offset: 0x1D48A20 VA: 0x1D4CA20
	public object ConvertFrom(object value) { }

	// RVA: 0x1D4CA9C Offset: 0x1D48A9C VA: 0x1D4CA9C Slot: 6
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1D4CFBC Offset: 0x1D48FBC VA: 0x1D4CFBC
	public object ConvertFromInvariantString(string text) { }

	// RVA: 0x1D4D044 Offset: 0x1D49044 VA: 0x1D4D044
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x1D4D0C4 Offset: 0x1D490C4 VA: 0x1D4D0C4
	public object ConvertFromString(string text) { }

	// RVA: 0x1D4D0DC Offset: 0x1D490DC VA: 0x1D4D0DC
	public object ConvertFromString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x1D4D038 Offset: 0x1D49038 VA: 0x1D4D038
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	// RVA: 0x1D4D15C Offset: 0x1D4915C VA: 0x1D4D15C
	public object ConvertTo(object value, Type destinationType) { }

	// RVA: 0x1D4D178 Offset: 0x1D49178 VA: 0x1D4D178 Slot: 7
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D4D4E0 Offset: 0x1D494E0 VA: 0x1D4D4E0
	public string ConvertToInvariantString(object value) { }

	// RVA: 0x1D4D5EC Offset: 0x1D495EC VA: 0x1D4D5EC
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1D4D664 Offset: 0x1D49664 VA: 0x1D4D664
	public string ConvertToString(object value) { }

	// RVA: 0x1D4D730 Offset: 0x1D49730 VA: 0x1D4D730
	public string ConvertToString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1D4D554 Offset: 0x1D49554 VA: 0x1D4D554
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x1D4D808 Offset: 0x1D49808 VA: 0x1D4D808
	public object CreateInstance(IDictionary propertyValues) { }

	// RVA: 0x1D4D81C Offset: 0x1D4981C VA: 0x1D4D81C Slot: 8
	public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x1D4CE98 Offset: 0x1D48E98 VA: 0x1D4CE98
	protected Exception GetConvertFromException(object value) { }

	// RVA: 0x1D4D378 Offset: 0x1D49378 VA: 0x1D4D378
	protected Exception GetConvertToException(object value, Type destinationType) { }

	// RVA: 0x1D4D824 Offset: 0x1D49824 VA: 0x1D4D824
	public bool GetCreateInstanceSupported() { }

	// RVA: 0x1D4D834 Offset: 0x1D49834 VA: 0x1D4D834 Slot: 9
	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1D4D83C Offset: 0x1D4983C VA: 0x1D4D83C
	public PropertyDescriptorCollection GetProperties(object value) { }

	// RVA: 0x1D4D848 Offset: 0x1D49848 VA: 0x1D4D848
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1D4D944 Offset: 0x1D49944 VA: 0x1D4D944 Slot: 10
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x1D4D94C Offset: 0x1D4994C VA: 0x1D4D94C
	public bool GetPropertiesSupported() { }

	// RVA: 0x1D4D95C Offset: 0x1D4995C VA: 0x1D4D95C Slot: 11
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1D4D964 Offset: 0x1D49964 VA: 0x1D4D964
	public ICollection GetStandardValues() { }

	// RVA: 0x1D4D974 Offset: 0x1D49974 VA: 0x1D4D974 Slot: 12
	public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1D4D97C Offset: 0x1D4997C VA: 0x1D4D97C
	public bool GetStandardValuesExclusive() { }

	// RVA: 0x1D4D990 Offset: 0x1D49990 VA: 0x1D4D990 Slot: 13
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x1D4D998 Offset: 0x1D49998 VA: 0x1D4D998
	public bool GetStandardValuesSupported() { }

	// RVA: 0x1D4D9AC Offset: 0x1D499AC VA: 0x1D4D9AC Slot: 14
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x1D4D9B4 Offset: 0x1D499B4 VA: 0x1D4D9B4
	public bool IsValid(object value) { }

	// RVA: 0x1D4D9CC Offset: 0x1D499CC VA: 0x1D4D9CC Slot: 15
	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x1D4DB0C Offset: 0x1D49B0C VA: 0x1D4DB0C
	protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names) { }

	// RVA: 0x1D4DB44 Offset: 0x1D49B44 VA: 0x1D4DB44
	public void .ctor() { }
}

// Namespace: 
private sealed class TypeDescriptor.AttributeFilterCacheItem // TypeDefIndex: 4054
{
	// Fields
	private Attribute[] _filter; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x1D55328 Offset: 0x1D51328 VA: 0x1D55328
	internal void .ctor(Attribute[] filter, ICollection filteredMembers) { }

	// RVA: 0x1D552B4 Offset: 0x1D512B4 VA: 0x1D552B4
	internal bool IsValid(Attribute[] filter) { }
}

// Namespace: 
private sealed class TypeDescriptor.FilterCacheItem // TypeDefIndex: 4055
{
	// Fields
	private ITypeDescriptorFilterService _filterService; // 0x10
	internal ICollection FilteredMembers; // 0x18

	// Methods

	// RVA: 0x1D554A8 Offset: 0x1D514A8 VA: 0x1D554A8
	internal void .ctor(ITypeDescriptorFilterService filterService, ICollection filteredMembers) { }

	// RVA: 0x1D5536C Offset: 0x1D5136C VA: 0x1D5536C
	internal bool IsValid(ITypeDescriptorFilterService filterService) { }
}

// Namespace: 
private interface TypeDescriptor.IUnimplemented // TypeDefIndex: 4056
{}

// Namespace: 
private sealed class TypeDescriptor.MemberDescriptorComparer : IComparer // TypeDefIndex: 4057
{
	// Fields
	public static readonly TypeDescriptor.MemberDescriptorComparer Instance; // 0x0

	// Methods

	// RVA: 0x1D55A3C Offset: 0x1D51A3C VA: 0x1D55A3C Slot: 4
	public int Compare(object left, object right) { }

	// RVA: 0x1D55B58 Offset: 0x1D51B58 VA: 0x1D55B58
	public void .ctor() { }

	// RVA: 0x1D55B60 Offset: 0x1D51B60 VA: 0x1D55B60
	private static void .cctor() { }
}

// Namespace: 
private sealed class TypeDescriptor.MergedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 4058
{
	// Fields
	private ICustomTypeDescriptor _primary; // 0x10
	private ICustomTypeDescriptor _secondary; // 0x18

	// Methods

	// RVA: 0x1D53DA4 Offset: 0x1D4FDA4 VA: 0x1D53DA4
	internal void .ctor(ICustomTypeDescriptor primary, ICustomTypeDescriptor secondary) { }

	// RVA: 0x1D55BC8 Offset: 0x1D51BC8 VA: 0x1D55BC8 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x1D55CD8 Offset: 0x1D51CD8 VA: 0x1D55CD8 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x1D55DF0 Offset: 0x1D51DF0 VA: 0x1D55DF0 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1D55F08 Offset: 0x1D51F08 VA: 0x1D55F08 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x1D56038 Offset: 0x1D52038 VA: 0x1D56038 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }
}

// Namespace: 
private struct TypeDescriptor.TypeDescriptionNode.DefaultExtendedTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 4059
{
	// Fields
	private TypeDescriptor.TypeDescriptionNode _node; // 0x0
	private object _instance; // 0x8

	// Methods

	// RVA: 0x1D56400 Offset: 0x1D52400 VA: 0x1D56400
	internal void .ctor(TypeDescriptor.TypeDescriptionNode node, object instance) { }

	// RVA: 0x1D566F8 Offset: 0x1D526F8 VA: 0x1D566F8 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x1D569BC Offset: 0x1D529BC VA: 0x1D569BC Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x1D56C4C Offset: 0x1D52C4C VA: 0x1D56C4C Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1D56EDC Offset: 0x1D52EDC VA: 0x1D56EDC Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x1D57174 Offset: 0x1D53174 VA: 0x1D57174 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }
}

// Namespace: 
private struct TypeDescriptor.TypeDescriptionNode.DefaultTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 4060
{
	// Fields
	private TypeDescriptor.TypeDescriptionNode _node; // 0x0
	private Type _objectType; // 0x8
	private object _instance; // 0x10

	// Methods

	// RVA: 0x1D566B4 Offset: 0x1D526B4 VA: 0x1D566B4
	internal void .ctor(TypeDescriptor.TypeDescriptionNode node, Type objectType, object instance) { }

	// RVA: 0x1D57388 Offset: 0x1D53388 VA: 0x1D57388 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x1D57618 Offset: 0x1D53618 VA: 0x1D57618 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x1D578A8 Offset: 0x1D538A8 VA: 0x1D578A8 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x1D57B3C Offset: 0x1D53B3C VA: 0x1D57B3C Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x1D57DD8 Offset: 0x1D53DD8 VA: 0x1D57DD8 Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }
}

// Namespace: 
private sealed class TypeDescriptor.TypeDescriptionNode : TypeDescriptionProvider // TypeDefIndex: 4061
{
	// Fields
	internal TypeDescriptor.TypeDescriptionNode Next; // 0x20
	internal TypeDescriptionProvider Provider; // 0x28

	// Methods

	// RVA: 0x1D4EC5C Offset: 0x1D4AC5C VA: 0x1D4EC5C
	internal void .ctor(TypeDescriptionProvider provider) { }

	// RVA: 0x1D56168 Offset: 0x1D52168 VA: 0x1D56168 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1D562BC Offset: 0x1D522BC VA: 0x1D562BC Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x1D56328 Offset: 0x1D52328 VA: 0x1D56328 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x1D56430 Offset: 0x1D52430 VA: 0x1D56430 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x1D5649C Offset: 0x1D5249C VA: 0x1D5649C Slot: 8
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x1D56550 Offset: 0x1D52550 VA: 0x1D56550 Slot: 9
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }
}

// Namespace: 
[TypeDescriptionProvider("System.Windows.Forms.ComponentModel.Com2Interop.ComNativeDescriptor, System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
private sealed class TypeDescriptor.TypeDescriptorComObject // TypeDefIndex: 4062
{}

// Namespace: 
private sealed class TypeDescriptor.TypeDescriptorInterface // TypeDefIndex: 4063
{}

// Namespace: System.ComponentModel
public sealed class TypeDescriptor // TypeDefIndex: 4064
{
	// Fields
	private static WeakHashtable _providerTable; // 0x0
	private static Hashtable _providerTypeTable; // 0x8
	private static Hashtable _defaultProviders; // 0x10
	private static WeakHashtable _associationTable; // 0x18
	private static int _metadataVersion; // 0x20
	private static int _collisionIndex; // 0x24
	private static BooleanSwitch TraceDescriptor; // 0x28
	private static readonly Guid[] _pipelineInitializeKeys; // 0x30
	private static readonly Guid[] _pipelineMergeKeys; // 0x38
	private static readonly Guid[] _pipelineFilterKeys; // 0x40
	private static readonly Guid[] _pipelineAttributeFilterKeys; // 0x48
	private static object _internalSyncObject; // 0x50
	[CompilerGenerated]
	private static RefreshEventHandler Refreshed; // 0x58

	// Properties
	[EditorBrowsable(2)]
	public static Type ComObjectType { get; }
	[EditorBrowsable(2)]
	public static Type InterfaceType { get; }
	internal static int MetadataVersion { get; }

	// Methods

	// RVA: 0x1D4E3F0 Offset: 0x1D4A3F0 VA: 0x1D4E3F0
	public static Type get_ComObjectType() { }

	// RVA: 0x1D4E450 Offset: 0x1D4A450 VA: 0x1D4E450
	public static Type get_InterfaceType() { }

	// RVA: 0x1D4E4B0 Offset: 0x1D4A4B0 VA: 0x1D4E4B0
	internal static int get_MetadataVersion() { }

	[EditorBrowsable(2)]
	// RVA: 0x1D4E508 Offset: 0x1D4A508 VA: 0x1D4E508
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	// RVA: 0x1D4F200 Offset: 0x1D4B200 VA: 0x1D4F200
	private static void CheckDefaultProvider(Type type) { }

	// RVA: 0x1D4F810 Offset: 0x1D4B810 VA: 0x1D4F810
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x1D4FB18 Offset: 0x1D4BB18 VA: 0x1D4FB18
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	[EditorBrowsable(2)]
	// RVA: 0x1D4FEFC Offset: 0x1D4BEFC VA: 0x1D4FEFC
	public static object GetAssociation(Type type, object primary) { }

	// RVA: 0x1D4BAE4 Offset: 0x1D47AE4 VA: 0x1D4BAE4
	public static AttributeCollection GetAttributes(Type componentType) { }

	// RVA: 0x1D4C390 Offset: 0x1D48390 VA: 0x1D4C390
	public static AttributeCollection GetAttributes(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x1D50584 Offset: 0x1D4C584 VA: 0x1D50584
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1D534E4 Offset: 0x1D4F4E4 VA: 0x1D534E4
	internal static IDictionary GetCache(object instance) { }

	// RVA: 0x1D53CBC Offset: 0x1D4FCBC VA: 0x1D53CBC
	public static TypeConverter GetConverter(Type type) { }

	// RVA: 0x1D504B4 Offset: 0x1D4C4B4 VA: 0x1D504B4
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	// RVA: 0x1D5099C Offset: 0x1D4C99C VA: 0x1D5099C
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1D50BA4 Offset: 0x1D4CBA4 VA: 0x1D50BA4
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	// RVA: 0x1D53DE8 Offset: 0x1D4FDE8 VA: 0x1D53DE8
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	// RVA: 0x1D540EC Offset: 0x1D500EC VA: 0x1D540EC
	private static Type GetNodeForBaseType(Type searchType) { }

	// RVA: 0x1D541C4 Offset: 0x1D501C4 VA: 0x1D541C4
	public static PropertyDescriptorCollection GetProperties(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x1D5421C Offset: 0x1D5021C VA: 0x1D5421C
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	// RVA: 0x1D548E8 Offset: 0x1D508E8 VA: 0x1D548E8
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) { }

	// RVA: 0x1D54950 Offset: 0x1D50950 VA: 0x1D54950
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x1D54288 Offset: 0x1D50288 VA: 0x1D54288
	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	// RVA: 0x1D55010 Offset: 0x1D51010 VA: 0x1D55010
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x1D55068 Offset: 0x1D51068 VA: 0x1D55068
	public static Type GetReflectionType(Type type) { }

	// RVA: 0x1D4FAC0 Offset: 0x1D4BAC0 VA: 0x1D4FAC0
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type) { }

	// RVA: 0x1D4E790 Offset: 0x1D4A790 VA: 0x1D4E790
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	// RVA: 0x1D53C64 Offset: 0x1D4FC64 VA: 0x1D53C64
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance) { }

	// RVA: 0x1D55144 Offset: 0x1D51144 VA: 0x1D55144
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	// RVA: 0x1D549C0 Offset: 0x1D509C0 VA: 0x1D549C0
	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	// RVA: 0x1D51CC8 Offset: 0x1D4DCC8 VA: 0x1D51CC8
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	// RVA: 0x1D53550 Offset: 0x1D4F550 VA: 0x1D53550
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	// RVA: 0x1D50C5C Offset: 0x1D4CC5C VA: 0x1D50C5C
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	// RVA: 0x1D554EC Offset: 0x1D514EC VA: 0x1D554EC
	private static void RaiseRefresh(Type type) { }

	// RVA: 0x1D4EC8C Offset: 0x1D4AC8C VA: 0x1D4EC8C
	public static void Refresh(Type type) { }

	// RVA: 0x1D4FE70 Offset: 0x1D4BE70 VA: 0x1D4FE70
	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	// RVA: 0x1D55598 Offset: 0x1D51598 VA: 0x1D55598
	public static void SortDescriptorArray(IList infos) { }

	// RVA: 0x1D5566C Offset: 0x1D5166C VA: 0x1D5566C
	private static void .cctor() { }
}

// Namespace: System.ComponentModel
[Serializable]
public class Win32Exception : ExternalException, ISerializable // TypeDefIndex: 4065
{
	// Fields
	private readonly int nativeErrorCode; // 0x8C

	// Properties
	public int NativeErrorCode { get; }

	// Methods

	// RVA: 0x1D57FEC Offset: 0x1D53FEC VA: 0x1D57FEC
	public void .ctor() { }

	// RVA: 0x1D58060 Offset: 0x1D54060 VA: 0x1D58060
	public void .ctor(int error) { }

	// RVA: 0x1D58990 Offset: 0x1D54990 VA: 0x1D58990
	public void .ctor(int error, string message) { }

	// RVA: 0x1D589BC Offset: 0x1D549BC VA: 0x1D589BC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D58A44 Offset: 0x1D54A44 VA: 0x1D58A44
	public int get_NativeErrorCode() { }

	// RVA: 0x1D58A4C Offset: 0x1D54A4C VA: 0x1D58A4C Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D58098 Offset: 0x1D54098 VA: 0x1D58098
	internal static string GetErrorMessage(int error) { }
}

// Namespace: System.ComponentModel
public enum RefreshProperties // TypeDefIndex: 4066
{
	// Fields
	public int value__; // 0x0
	public const RefreshProperties None = 0;
	public const RefreshProperties All = 1;
	public const RefreshProperties Repaint = 2;
}

// Namespace: System.ComponentModel
[Usage(32767)]
public sealed class RefreshPropertiesAttribute : Attribute // TypeDefIndex: 4067
{
	// Fields
	public static readonly RefreshPropertiesAttribute All; // 0x0
	public static readonly RefreshPropertiesAttribute Repaint; // 0x8
	public static readonly RefreshPropertiesAttribute Default; // 0x10
	private RefreshProperties refresh; // 0x10

	// Properties
	public RefreshProperties RefreshProperties { get; }

	// Methods

	// RVA: 0x1D58B14 Offset: 0x1D54B14 VA: 0x1D58B14
	public void .ctor(RefreshProperties refresh) { }

	// RVA: 0x1D58B3C Offset: 0x1D54B3C VA: 0x1D58B3C
	public RefreshProperties get_RefreshProperties() { }

	// RVA: 0x1D58B44 Offset: 0x1D54B44 VA: 0x1D58B44 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1D58BB4 Offset: 0x1D54BB4 VA: 0x1D58BB4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D58BBC Offset: 0x1D54BBC VA: 0x1D58BBC Slot: 6
	public override bool IsDefaultAttribute() { }

	// RVA: 0x1D58C24 Offset: 0x1D54C24 VA: 0x1D58C24
	private static void .cctor() { }
}

// Namespace: 
private class WeakHashtable.WeakKeyComparer : IEqualityComparer // TypeDefIndex: 4068
{
	// Methods

	// RVA: 0x1D58D84 Offset: 0x1D54D84 VA: 0x1D58D84 Slot: 4
	private bool System.Collections.IEqualityComparer.Equals(object x, object y) { }

	// RVA: 0x1D58EE0 Offset: 0x1D54EE0 VA: 0x1D58EE0 Slot: 5
	private int System.Collections.IEqualityComparer.GetHashCode(object obj) { }

	// RVA: 0x1D58D7C Offset: 0x1D54D7C VA: 0x1D58D7C
	public void .ctor() { }
}

// Namespace: System.ComponentModel
internal sealed class WeakHashtable : Hashtable // TypeDefIndex: 4069
{
	// Fields
	private static IEqualityComparer _comparer; // 0x0

	// Methods

	// RVA: 0x1D559D8 Offset: 0x1D519D8 VA: 0x1D559D8
	internal void .ctor() { }

	// RVA: 0x1D58CF0 Offset: 0x1D54CF0 VA: 0x1D58CF0 Slot: 22
	public override void Clear() { }

	// RVA: 0x1D58CF8 Offset: 0x1D54CF8 VA: 0x1D58CF8 Slot: 36
	public override void Remove(object key) { }

	// RVA: 0x1D58D00 Offset: 0x1D54D00 VA: 0x1D58D00
	private static void .cctor() { }
}
