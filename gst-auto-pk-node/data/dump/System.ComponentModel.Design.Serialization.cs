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

// Namespace: System.ComponentModel.Design.Serialization
public sealed class InstanceDescriptor // TypeDefIndex: 4083
{
	// Fields
	[CompilerGenerated]
	private readonly ICollection <Arguments>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly bool <IsComplete>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly MemberInfo <MemberInfo>k__BackingField; // 0x20

	// Properties
	public ICollection Arguments { get; }
	public MemberInfo MemberInfo { get; }

	// Methods

	// RVA: 0x1D5A044 Offset: 0x1D56044 VA: 0x1D5A044
	public void .ctor(MemberInfo member, ICollection arguments) { }

	// RVA: 0x1D5A04C Offset: 0x1D5604C VA: 0x1D5A04C
	public void .ctor(MemberInfo member, ICollection arguments, bool isComplete) { }

	[CompilerGenerated]
	// RVA: 0x1D5A590 Offset: 0x1D56590 VA: 0x1D5A590
	public ICollection get_Arguments() { }

	[CompilerGenerated]
	// RVA: 0x1D5A598 Offset: 0x1D56598 VA: 0x1D5A598
	public MemberInfo get_MemberInfo() { }

	// RVA: 0x1D4CB04 Offset: 0x1D48B04 VA: 0x1D4CB04
	public object Invoke() { }
}

// Namespace: System.ComponentModel.Design.Serialization
[Obsolete("This attribute has been deprecated. Use DesignerSerializerAttribute instead.  For example, to specify a root designer for CodeDom, use DesignerSerializerAttribute(...,typeof(TypeCodeDomSerializer)).  https://go.microsoft.com/fwlink/?linkid=14202")]
[Usage(1028, AllowMultiple = True, Inherited = True)]
public sealed class RootDesignerSerializerAttribute : Attribute // TypeDefIndex: 4084
{
	// Fields
	private string _typeId; // 0x10
	[CompilerGenerated]
	private readonly bool <Reloadable>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <SerializerTypeName>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <SerializerBaseTypeName>k__BackingField; // 0x28

	// Properties
	public string SerializerBaseTypeName { get; }
	public override object TypeId { get; }

	// Methods

	// RVA: 0x1D5A5A0 Offset: 0x1D565A0 VA: 0x1D5A5A0
	public void .ctor(string serializerTypeName, string baseSerializerTypeName, bool reloadable) { }

	[CompilerGenerated]
	// RVA: 0x1D5A5F8 Offset: 0x1D565F8 VA: 0x1D5A5F8
	public string get_SerializerBaseTypeName() { }

	// RVA: 0x1D5A600 Offset: 0x1D56600 VA: 0x1D5A600 Slot: 4
	public override object get_TypeId() { }
}
