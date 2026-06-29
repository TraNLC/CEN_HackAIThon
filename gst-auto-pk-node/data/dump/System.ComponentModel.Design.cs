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

// Namespace: System.ComponentModel.Design
[Serializable]
public class CheckoutException : ExternalException // TypeDefIndex: 4070
{
	// Fields
	public static readonly CheckoutException Canceled; // 0x0

	// Methods

	// RVA: 0x1D58F00 Offset: 0x1D54F00 VA: 0x1D58F00
	public void .ctor() { }

	// RVA: 0x1D58F08 Offset: 0x1D54F08 VA: 0x1D58F08
	public void .ctor(string message, int errorCode) { }

	// RVA: 0x1D58F10 Offset: 0x1D54F10 VA: 0x1D58F10
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D58F18 Offset: 0x1D54F18 VA: 0x1D58F18
	private static void .cctor() { }
}

// Namespace: System.ComponentModel.Design
public interface IComponentChangeService // TypeDefIndex: 4071
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnComponentChanging(object component, MemberDescriptor member);
}

// Namespace: System.ComponentModel.Design
public interface IDesigner : IDisposable // TypeDefIndex: 4072
{}

// Namespace: System.ComponentModel.Design
public interface IDesignerHost : IServiceProvider // TypeDefIndex: 4073
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDesigner GetDesigner(IComponent component);
}

// Namespace: System.ComponentModel.Design
public interface IDictionaryService // TypeDefIndex: 4074
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetValue(object key);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetValue(object key, object value);
}

// Namespace: System.ComponentModel.Design
public interface IExtenderListService // TypeDefIndex: 4075
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IExtenderProvider[] GetExtenderProviders();
}

// Namespace: System.ComponentModel.Design
public interface IReferenceService // TypeDefIndex: 4076
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetReference(string name);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string GetName(object reference);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object[] GetReferences(Type baseType);
}

// Namespace: System.ComponentModel.Design
public interface ITypeDescriptorFilterService // TypeDefIndex: 4077
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool FilterAttributes(IComponent component, IDictionary attributes);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool FilterEvents(IComponent component, IDictionary events);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool FilterProperties(IComponent component, IDictionary properties);
}

// Namespace: 
private sealed class DesignerOptionService.DesignerOptionCollection.WrappedPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4078
{
	// Fields
	private object target; // 0x88
	private PropertyDescriptor property; // 0x90

	// Properties
	public override AttributeCollection Attributes { get; }
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x1D59758 Offset: 0x1D55758 VA: 0x1D59758
	internal void .ctor(PropertyDescriptor property, object target) { }

	// RVA: 0x1D5983C Offset: 0x1D5583C VA: 0x1D5983C Slot: 6
	public override AttributeCollection get_Attributes() { }

	// RVA: 0x1D59858 Offset: 0x1D55858 VA: 0x1D59858 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x1D59878 Offset: 0x1D55878 VA: 0x1D59878 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x1D59898 Offset: 0x1D55898 VA: 0x1D59898 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x1D598B8 Offset: 0x1D558B8 VA: 0x1D598B8 Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x1D598E0 Offset: 0x1D558E0 VA: 0x1D598E0 Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x1D59908 Offset: 0x1D55908 VA: 0x1D59908 Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x1D59930 Offset: 0x1D55930 VA: 0x1D59930 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x1D59958 Offset: 0x1D55958 VA: 0x1D59958 Slot: 22
	public override bool ShouldSerializeValue(object component) { }
}

// Namespace: 
[DefaultMember("Item")]
[TypeConverter(typeof(DesignerOptionService.DesignerOptionConverter))]
[Editor("", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public sealed class DesignerOptionService.DesignerOptionCollection : ICollection // TypeDefIndex: 4079
{
	// Fields
	private DesignerOptionService _service; // 0x10
	private string _name; // 0x18
	private object _value; // 0x20
	private ArrayList _children; // 0x28
	private PropertyDescriptorCollection _properties; // 0x30

	// Properties
	public int Count { get; }
	public string Name { get; }
	public PropertyDescriptorCollection Properties { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x1D58FA4 Offset: 0x1D54FA4 VA: 0x1D58FA4 Slot: 5
	public int get_Count() { }

	// RVA: 0x1D59070 Offset: 0x1D55070 VA: 0x1D59070
	public string get_Name() { }

	// RVA: 0x1D59078 Offset: 0x1D55078 VA: 0x1D59078
	public PropertyDescriptorCollection get_Properties() { }

	// RVA: 0x1D597C0 Offset: 0x1D557C0 VA: 0x1D597C0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1D58FD0 Offset: 0x1D54FD0 VA: 0x1D58FD0
	private void EnsurePopulated() { }

	// RVA: 0x1D59804 Offset: 0x1D55804 VA: 0x1D59804 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1D59830 Offset: 0x1D55830 VA: 0x1D59830 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x1D59838 Offset: 0x1D55838 VA: 0x1D59838 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }
}

// Namespace: 
private class DesignerOptionService.DesignerOptionConverter.OptionPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 4080
{
	// Fields
	private DesignerOptionService.DesignerOptionCollection _option; // 0x88

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }

	// Methods

	// RVA: 0x1D59EEC Offset: 0x1D55EEC VA: 0x1D59EEC
	internal void .ctor(DesignerOptionService.DesignerOptionCollection option) { }

	// RVA: 0x1D59FEC Offset: 0x1D55FEC VA: 0x1D59FEC Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x1D5A004 Offset: 0x1D56004 VA: 0x1D5A004 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x1D5A00C Offset: 0x1D5600C VA: 0x1D5A00C Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x1D5A024 Offset: 0x1D56024 VA: 0x1D5A024 Slot: 17
	public override bool CanResetValue(object component) { }

	// RVA: 0x1D5A02C Offset: 0x1D5602C VA: 0x1D5A02C Slot: 18
	public override object GetValue(object component) { }

	// RVA: 0x1D5A034 Offset: 0x1D56034 VA: 0x1D5A034 Slot: 20
	public override void ResetValue(object component) { }

	// RVA: 0x1D5A038 Offset: 0x1D56038 VA: 0x1D5A038 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x1D5A03C Offset: 0x1D5603C VA: 0x1D5A03C Slot: 22
	public override bool ShouldSerializeValue(object component) { }
}

// Namespace: 
internal sealed class DesignerOptionService.DesignerOptionConverter : TypeConverter // TypeDefIndex: 4081
{
	// Methods

	// RVA: 0x1D59980 Offset: 0x1D55980 VA: 0x1D59980 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext cxt) { }

	// RVA: 0x1D59988 Offset: 0x1D55988 VA: 0x1D59988 Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext cxt, object value, Attribute[] attributes) { }

	// RVA: 0x1D59F2C Offset: 0x1D55F2C VA: 0x1D59F2C Slot: 7
	public override object ConvertTo(ITypeDescriptorContext cxt, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x1D59FE4 Offset: 0x1D55FE4 VA: 0x1D59FE4
	public void .ctor() { }
}

// Namespace: System.ComponentModel.Design
public abstract class DesignerOptionService // TypeDefIndex: 4082
{
	// Methods

	// RVA: 0x1D58FA0 Offset: 0x1D54FA0 VA: 0x1D58FA0 Slot: 4
	protected virtual void PopulateOptionCollection(DesignerOptionService.DesignerOptionCollection options) { }
}
