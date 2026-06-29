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

// Namespace: System.Runtime.Remoting.Metadata
[ComVisible(True)]
public class SoapAttribute : Attribute // TypeDefIndex: 881
{
	// Fields
	private bool _useAttribute; // 0x10
	protected string ProtXmlNamespace; // 0x18
	protected object ReflectInfo; // 0x20

	// Properties
	public virtual bool UseAttribute { get; }
	public virtual string XmlNamespace { get; }

	// Methods

	// RVA: 0x179E684 Offset: 0x179A684 VA: 0x179E684
	public void .ctor() { }

	// RVA: 0x179E68C Offset: 0x179A68C VA: 0x179E68C Slot: 7
	public virtual bool get_UseAttribute() { }

	// RVA: 0x179E694 Offset: 0x179A694 VA: 0x179E694 Slot: 8
	public virtual string get_XmlNamespace() { }

	// RVA: 0x179E69C Offset: 0x179A69C VA: 0x179E69C Slot: 9
	internal virtual void SetReflectionObject(object reflectionObject) { }
}

// Namespace: System.Runtime.Remoting.Metadata
[Usage(256)]
[ComVisible(True)]
public sealed class SoapFieldAttribute : SoapAttribute // TypeDefIndex: 882
{
	// Fields
	private string _elementName; // 0x28
	private bool _isElement; // 0x30

	// Properties
	public string XmlElementName { get; }

	// Methods

	// RVA: 0x179E6A4 Offset: 0x179A6A4 VA: 0x179E6A4
	public void .ctor() { }

	// RVA: 0x179E6AC Offset: 0x179A6AC VA: 0x179E6AC
	public string get_XmlElementName() { }

	// RVA: 0x179E6B4 Offset: 0x179A6B4 VA: 0x179E6B4
	public bool IsInteropXmlElement() { }

	// RVA: 0x179E6BC Offset: 0x179A6BC VA: 0x179E6BC Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }
}

// Namespace: System.Runtime.Remoting.Metadata
[Usage(64)]
[ComVisible(True)]
public sealed class SoapMethodAttribute : SoapAttribute // TypeDefIndex: 883
{
	// Fields
	private string _responseElement; // 0x28
	private string _responseNamespace; // 0x30
	private string _returnElement; // 0x38
	private string _soapAction; // 0x40
	private bool _useAttribute; // 0x48
	private string _namespace; // 0x50

	// Properties
	public override bool UseAttribute { get; }
	public override string XmlNamespace { get; }

	// Methods

	// RVA: 0x179E770 Offset: 0x179A770 VA: 0x179E770
	public void .ctor() { }

	// RVA: 0x179E778 Offset: 0x179A778 VA: 0x179E778 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x179E780 Offset: 0x179A780 VA: 0x179E780 Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x179E788 Offset: 0x179A788 VA: 0x179E788 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }
}

// Namespace: System.Runtime.Remoting.Metadata
[Usage(2048)]
[ComVisible(True)]
public sealed class SoapParameterAttribute : SoapAttribute // TypeDefIndex: 884
{
	// Methods

	// RVA: 0x179E9A4 Offset: 0x179A9A4 VA: 0x179E9A4
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Metadata
[Usage(1052)]
[ComVisible(True)]
public sealed class SoapTypeAttribute : SoapAttribute // TypeDefIndex: 885
{
	// Fields
	private bool _useAttribute; // 0x28
	private string _xmlElementName; // 0x30
	private string _xmlNamespace; // 0x38
	private string _xmlTypeName; // 0x40
	private string _xmlTypeNamespace; // 0x48
	private bool _isType; // 0x50
	private bool _isElement; // 0x51

	// Properties
	public override bool UseAttribute { get; }
	public string XmlElementName { get; }
	public override string XmlNamespace { get; }
	public string XmlTypeName { get; }
	public string XmlTypeNamespace { get; }
	internal bool IsInteropXmlElement { get; }
	internal bool IsInteropXmlType { get; }

	// Methods

	// RVA: 0x179E9AC Offset: 0x179A9AC VA: 0x179E9AC
	public void .ctor() { }

	// RVA: 0x179E9B4 Offset: 0x179A9B4 VA: 0x179E9B4 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x179E9BC Offset: 0x179A9BC VA: 0x179E9BC
	public string get_XmlElementName() { }

	// RVA: 0x179E9C4 Offset: 0x179A9C4 VA: 0x179E9C4 Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x179E9CC Offset: 0x179A9CC VA: 0x179E9CC
	public string get_XmlTypeName() { }

	// RVA: 0x179E9D4 Offset: 0x179A9D4 VA: 0x179E9D4
	public string get_XmlTypeNamespace() { }

	// RVA: 0x179E9DC Offset: 0x179A9DC VA: 0x179E9DC
	internal bool get_IsInteropXmlElement() { }

	// RVA: 0x179E9E4 Offset: 0x179A9E4 VA: 0x179E9E4
	internal bool get_IsInteropXmlType() { }

	// RVA: 0x179E9EC Offset: 0x179A9EC VA: 0x179E9EC Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }
}
