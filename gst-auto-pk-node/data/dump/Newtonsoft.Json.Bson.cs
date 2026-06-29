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

// Namespace: Newtonsoft.Json.Bson
[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class BsonObjectId // TypeDefIndex: 6266
{
	// Fields
	[CompilerGenerated]
	private readonly byte[] <Value>k__BackingField; // 0x10

	// Properties
	public byte[] Value { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x199E750 Offset: 0x199A750 VA: 0x199E750
	public byte[] get_Value() { }

	// RVA: 0x199E758 Offset: 0x199A758 VA: 0x199E758
	public void .ctor(byte[] value) { }
}

// Namespace: Newtonsoft.Json.Bson
internal abstract class BsonToken // TypeDefIndex: 6267
{
	// Fields
	[CompilerGenerated]
	private BsonToken <Parent>k__BackingField; // 0x10

	// Properties
	public abstract BsonType Type { get; }
	public BsonToken Parent { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract BsonType get_Type();

	[CompilerGenerated]
	// RVA: 0x199E83C Offset: 0x199A83C VA: 0x199E83C
	public void set_Parent(BsonToken value) { }

	// RVA: 0x199E844 Offset: 0x199A844 VA: 0x199E844
	protected void .ctor() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonObject : BsonToken // TypeDefIndex: 6268
{
	// Fields
	private readonly List<BsonProperty> _children; // 0x18

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0x199E84C Offset: 0x199A84C VA: 0x199E84C
	public void Add(string name, BsonToken token) { }

	// RVA: 0x199E9F4 Offset: 0x199A9F4 VA: 0x199E9F4 Slot: 4
	public override BsonType get_Type() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonArray : BsonToken // TypeDefIndex: 6269
{
	// Fields
	private readonly List<BsonToken> _children; // 0x18

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0x199E9FC Offset: 0x199A9FC VA: 0x199E9FC
	public void Add(BsonToken token) { }

	// RVA: 0x199EAB8 Offset: 0x199AAB8 VA: 0x199EAB8 Slot: 4
	public override BsonType get_Type() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonValue : BsonToken // TypeDefIndex: 6270
{
	// Fields
	private readonly object _value; // 0x18
	private readonly BsonType _type; // 0x20

	// Properties
	public override BsonType Type { get; }

	// Methods

	// RVA: 0x199EAC0 Offset: 0x199AAC0 VA: 0x199EAC0
	public void .ctor(object value, BsonType type) { }

	// RVA: 0x199EAFC Offset: 0x199AAFC VA: 0x199EAFC Slot: 4
	public override BsonType get_Type() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonString : BsonValue // TypeDefIndex: 6271
{
	// Fields
	[CompilerGenerated]
	private readonly bool <IncludeLength>k__BackingField; // 0x21

	// Methods

	// RVA: 0x199E9B0 Offset: 0x199A9B0 VA: 0x199E9B0
	public void .ctor(object value, bool includeLength) { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonRegex : BsonToken // TypeDefIndex: 6272
{
	// Fields
	[CompilerGenerated]
	private BsonString <Pattern>k__BackingField; // 0x18
	[CompilerGenerated]
	private BsonString <Options>k__BackingField; // 0x20

	// Properties
	public BsonString Pattern { set; }
	public BsonString Options { set; }
	public override BsonType Type { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x199EB04 Offset: 0x199AB04 VA: 0x199EB04
	public void set_Pattern(BsonString value) { }

	[CompilerGenerated]
	// RVA: 0x199EB0C Offset: 0x199AB0C VA: 0x199EB0C
	public void set_Options(BsonString value) { }

	// RVA: 0x199EB14 Offset: 0x199AB14 VA: 0x199EB14
	public void .ctor(string pattern, string options) { }

	// RVA: 0x199EBE8 Offset: 0x199ABE8 VA: 0x199EBE8 Slot: 4
	public override BsonType get_Type() { }
}

// Namespace: Newtonsoft.Json.Bson
internal class BsonProperty // TypeDefIndex: 6273
{
	// Fields
	[CompilerGenerated]
	private BsonString <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private BsonToken <Value>k__BackingField; // 0x18

	// Properties
	public BsonString Name { set; }
	public BsonToken Value { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x199EBF0 Offset: 0x199ABF0 VA: 0x199EBF0
	public void set_Name(BsonString value) { }

	[CompilerGenerated]
	// RVA: 0x199EBF8 Offset: 0x199ABF8 VA: 0x199EBF8
	public void set_Value(BsonToken value) { }

	// RVA: 0x199E9A8 Offset: 0x199A9A8 VA: 0x199E9A8
	public void .ctor() { }
}

// Namespace: Newtonsoft.Json.Bson
internal enum BsonType // TypeDefIndex: 6274
{
	// Fields
	public sbyte value__; // 0x0
	public const BsonType Number = 1;
	public const BsonType String = 2;
	public const BsonType Object = 3;
	public const BsonType Array = 4;
	public const BsonType Binary = 5;
	public const BsonType Undefined = 6;
	public const BsonType Oid = 7;
	public const BsonType Boolean = 8;
	public const BsonType Date = 9;
	public const BsonType Null = 10;
	public const BsonType Regex = 11;
	public const BsonType Reference = 12;
	public const BsonType Code = 13;
	public const BsonType Symbol = 14;
	public const BsonType CodeWScope = 15;
	public const BsonType Integer = 16;
	public const BsonType TimeStamp = 17;
	public const BsonType Long = 18;
	public const BsonType MinKey = -1;
	public const BsonType MaxKey = 127;
}

// Namespace: Newtonsoft.Json.Bson
[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class BsonWriter : JsonWriter // TypeDefIndex: 6275
{
	// Fields
	private BsonToken _root; // 0x60
	private BsonToken _parent; // 0x68
	private string _propertyName; // 0x70

	// Methods

	// RVA: 0x199EC00 Offset: 0x199AC00 VA: 0x199EC00
	private void AddValue(object value, BsonType type) { }

	// RVA: 0x199EC80 Offset: 0x199AC80 VA: 0x199EC80
	internal void AddToken(BsonToken token) { }

	// RVA: 0x199EE68 Offset: 0x199AE68 VA: 0x199EE68
	public void WriteObjectId(byte[] value) { }

	// RVA: 0x1990B24 Offset: 0x198CB24 VA: 0x1990B24
	public void WriteRegex(string pattern, string options) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 // TypeDefIndex: 6276
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 // TypeDefIndex: 6277
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 6278
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 // TypeDefIndex: 6279
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 // TypeDefIndex: 6280
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 // TypeDefIndex: 6281
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 // TypeDefIndex: 6282
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 // TypeDefIndex: 6283
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 // TypeDefIndex: 6284
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 6285
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 0698228BF899CAEAB9A53E5E6C7099E846C44F56432050D234DDF03AD772F139 /*Metadata offset 0x3EB970*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 19AE20A57B073E3E8DD45C6F6A4E9AB1076EA3EBFFF28E4AEB58B411472CF994 /*Metadata offset 0x3EB9A0*/; // 0x2C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 223D6CA32241C349E421A0164F2341E20CC5B65D5A04AA021CFF71D623895570 /*Metadata offset 0x3EB9B0*/; // 0x36
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 33350F5DA385CE1B8749AEC68BA060CD54EE981968522B5EDF62178537A1FEEE /*Metadata offset 0x3EB9E0*/; // 0x5E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 38809B9974198671140931F729415F3FD75DF68A6398E3486AE3B58554329A63 /*Metadata offset 0x3EB9F8*/; // 0x72
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 499E4F5C84E20C7347E10100E0EC90C1945EA21C7C80809E4F7F474179B39DF6 /*Metadata offset 0x3EBA28*/; // 0x9A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 4EDE3546F1189E450DF4D4A2739BE90BEB3B1708B3B9F406B02E0773A92A10FF /*Metadata offset 0x3EBA48*/; // 0xB6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA /*Metadata offset 0x3EBA60*/; // 0xC6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 5ADB7CA81690556AB2A3201A849839FA3562604BB469382C7D6D78AB426283E2 /*Metadata offset 0x3EBA98*/; // 0xFA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 5DDF815AC046E7D4603FA586D1BDE42118AD4FE9875D64F716BC7D2740EE52C9 /*Metadata offset 0x3EBAB8*/; // 0x116
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 605A3F93AE7A97E00C156F977E942027EA532E263A5B440A4219984F803FDD04 /*Metadata offset 0x3EBAD8*/; // 0x12E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 7367A65185E4F747AA29364AB199D01646A010A62129A6BA2E35E929D7294D62 /*Metadata offset 0x3EBAF0*/; // 0x13E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 7439A4C9E30AC42BCC55AD1A2B617E29E7129B6DDAC79C886944B17819262CC1 /*Metadata offset 0x3EBB18*/; // 0x162
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 990F3F1286CC3928725497B2745CFF7BC7C9803B4EB8271611540BA6BF6654B5 /*Metadata offset 0x3EBB48*/; // 0x18A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 A8636D08B42D058EFC34703DD37B6468FCE56138DF242B862C3F1CA138CB3B89 /*Metadata offset 0x3EBB78*/; // 0x1B2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 B1D1BCD1D06B4A563944BE3C67D51F63DF23702E5BE760D7897C6AD1F51C6122 /*Metadata offset 0x3EBB90*/; // 0x1C2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 CAA07D7573596B3356BD202533F0EAFDD05309981F270193A99E300D57587326 /*Metadata offset 0x3EBBA8*/; // 0x1D6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 D4B3B8EBA0589FC38724A0D318B46104B07BC528744109ED69ED71604B7EEC1A /*Metadata offset 0x3EBBC0*/; // 0x1EA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 F6EDC1733B068F457C63E03BB041B9AB6BFAD5CD7673D3E0841968D3FBCB12C7 /*Metadata offset 0x3EBBF0*/; // 0x212
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315 /*Metadata offset 0x3EBC20*/; // 0x23A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 FCA56C548368F7065472C8C8EE4D63921B4F16BB51181EC202A0C252D5209E6A /*Metadata offset 0x3EBC58*/; // 0x26E
}

// Namespace: 
internal class <Module> // TypeDefIndex: 6286
{}
