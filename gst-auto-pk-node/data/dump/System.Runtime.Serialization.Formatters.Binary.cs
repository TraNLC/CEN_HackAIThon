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

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum BinaryHeaderEnum // TypeDefIndex: 983
{
	// Fields
	public int value__; // 0x0
	public const BinaryHeaderEnum SerializedStreamHeader = 0;
	public const BinaryHeaderEnum Object = 1;
	public const BinaryHeaderEnum ObjectWithMap = 2;
	public const BinaryHeaderEnum ObjectWithMapAssemId = 3;
	public const BinaryHeaderEnum ObjectWithMapTyped = 4;
	public const BinaryHeaderEnum ObjectWithMapTypedAssemId = 5;
	public const BinaryHeaderEnum ObjectString = 6;
	public const BinaryHeaderEnum Array = 7;
	public const BinaryHeaderEnum MemberPrimitiveTyped = 8;
	public const BinaryHeaderEnum MemberReference = 9;
	public const BinaryHeaderEnum ObjectNull = 10;
	public const BinaryHeaderEnum MessageEnd = 11;
	public const BinaryHeaderEnum Assembly = 12;
	public const BinaryHeaderEnum ObjectNullMultiple256 = 13;
	public const BinaryHeaderEnum ObjectNullMultiple = 14;
	public const BinaryHeaderEnum ArraySinglePrimitive = 15;
	public const BinaryHeaderEnum ArraySingleObject = 16;
	public const BinaryHeaderEnum ArraySingleString = 17;
	public const BinaryHeaderEnum CrossAppDomainMap = 18;
	public const BinaryHeaderEnum CrossAppDomainString = 19;
	public const BinaryHeaderEnum CrossAppDomainAssembly = 20;
	public const BinaryHeaderEnum MethodCall = 21;
	public const BinaryHeaderEnum MethodReturn = 22;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum BinaryTypeEnum // TypeDefIndex: 984
{
	// Fields
	public int value__; // 0x0
	public const BinaryTypeEnum Primitive = 0;
	public const BinaryTypeEnum String = 1;
	public const BinaryTypeEnum Object = 2;
	public const BinaryTypeEnum ObjectUrt = 3;
	public const BinaryTypeEnum ObjectUser = 4;
	public const BinaryTypeEnum ObjectArray = 5;
	public const BinaryTypeEnum StringArray = 6;
	public const BinaryTypeEnum PrimitiveArray = 7;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum BinaryArrayTypeEnum // TypeDefIndex: 985
{
	// Fields
	public int value__; // 0x0
	public const BinaryArrayTypeEnum Single = 0;
	public const BinaryArrayTypeEnum Jagged = 1;
	public const BinaryArrayTypeEnum Rectangular = 2;
	public const BinaryArrayTypeEnum SingleOffset = 3;
	public const BinaryArrayTypeEnum JaggedOffset = 4;
	public const BinaryArrayTypeEnum RectangularOffset = 5;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalSerializerTypeE // TypeDefIndex: 986
{
	// Fields
	public int value__; // 0x0
	public const InternalSerializerTypeE Soap = 1;
	public const InternalSerializerTypeE Binary = 2;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalParseTypeE // TypeDefIndex: 987
{
	// Fields
	public int value__; // 0x0
	public const InternalParseTypeE Empty = 0;
	public const InternalParseTypeE SerializedStreamHeader = 1;
	public const InternalParseTypeE Object = 2;
	public const InternalParseTypeE Member = 3;
	public const InternalParseTypeE ObjectEnd = 4;
	public const InternalParseTypeE MemberEnd = 5;
	public const InternalParseTypeE Headers = 6;
	public const InternalParseTypeE HeadersEnd = 7;
	public const InternalParseTypeE SerializedStreamHeaderEnd = 8;
	public const InternalParseTypeE Envelope = 9;
	public const InternalParseTypeE EnvelopeEnd = 10;
	public const InternalParseTypeE Body = 11;
	public const InternalParseTypeE BodyEnd = 12;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalObjectTypeE // TypeDefIndex: 988
{
	// Fields
	public int value__; // 0x0
	public const InternalObjectTypeE Empty = 0;
	public const InternalObjectTypeE Object = 1;
	public const InternalObjectTypeE Array = 2;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalObjectPositionE // TypeDefIndex: 989
{
	// Fields
	public int value__; // 0x0
	public const InternalObjectPositionE Empty = 0;
	public const InternalObjectPositionE Top = 1;
	public const InternalObjectPositionE Child = 2;
	public const InternalObjectPositionE Headers = 3;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalArrayTypeE // TypeDefIndex: 990
{
	// Fields
	public int value__; // 0x0
	public const InternalArrayTypeE Empty = 0;
	public const InternalArrayTypeE Single = 1;
	public const InternalArrayTypeE Jagged = 2;
	public const InternalArrayTypeE Rectangular = 3;
	public const InternalArrayTypeE Base64 = 4;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalMemberTypeE // TypeDefIndex: 991
{
	// Fields
	public int value__; // 0x0
	public const InternalMemberTypeE Empty = 0;
	public const InternalMemberTypeE Header = 1;
	public const InternalMemberTypeE Field = 2;
	public const InternalMemberTypeE Item = 3;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalMemberValueE // TypeDefIndex: 992
{
	// Fields
	public int value__; // 0x0
	public const InternalMemberValueE Empty = 0;
	public const InternalMemberValueE InlineValue = 1;
	public const InternalMemberValueE Nested = 2;
	public const InternalMemberValueE Reference = 3;
	public const InternalMemberValueE Null = 4;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum InternalPrimitiveTypeE // TypeDefIndex: 993
{
	// Fields
	public int value__; // 0x0
	public const InternalPrimitiveTypeE Invalid = 0;
	public const InternalPrimitiveTypeE Boolean = 1;
	public const InternalPrimitiveTypeE Byte = 2;
	public const InternalPrimitiveTypeE Char = 3;
	public const InternalPrimitiveTypeE Currency = 4;
	public const InternalPrimitiveTypeE Decimal = 5;
	public const InternalPrimitiveTypeE Double = 6;
	public const InternalPrimitiveTypeE Int16 = 7;
	public const InternalPrimitiveTypeE Int32 = 8;
	public const InternalPrimitiveTypeE Int64 = 9;
	public const InternalPrimitiveTypeE SByte = 10;
	public const InternalPrimitiveTypeE Single = 11;
	public const InternalPrimitiveTypeE TimeSpan = 12;
	public const InternalPrimitiveTypeE DateTime = 13;
	public const InternalPrimitiveTypeE UInt16 = 14;
	public const InternalPrimitiveTypeE UInt32 = 15;
	public const InternalPrimitiveTypeE UInt64 = 16;
	public const InternalPrimitiveTypeE Null = 17;
	public const InternalPrimitiveTypeE String = 18;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal enum ValueFixupEnum // TypeDefIndex: 994
{
	// Fields
	public int value__; // 0x0
	public const ValueFixupEnum Empty = 0;
	public const ValueFixupEnum Array = 1;
	public const ValueFixupEnum Header = 2;
	public const ValueFixupEnum Member = 3;
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal static class BinaryConverter // TypeDefIndex: 995
{
	// Methods

	// RVA: 0x17B7F94 Offset: 0x17B3F94 VA: 0x17B7F94
	internal static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out object typeInformation, out int assemId) { }

	// RVA: 0x17B8658 Offset: 0x17B4658 VA: 0x17B8658
	internal static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out object typeInformation) { }

	// RVA: 0x17B8968 Offset: 0x17B4968 VA: 0x17B8968
	internal static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, int assemId, __BinaryWriter sout) { }

	// RVA: 0x17B8C00 Offset: 0x17B4C00 VA: 0x17B8C00
	internal static object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId) { }

	// RVA: 0x17B8E48 Offset: 0x17B4E48 VA: 0x17B8E48
	internal static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out Type type, out bool isVariant) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal static class IOUtil // TypeDefIndex: 996
{
	// Methods

	// RVA: 0x17B95FC Offset: 0x17B55FC VA: 0x17B95FC
	internal static bool FlagTest(MessageEnum flag, MessageEnum target) { }

	// RVA: 0x17B9608 Offset: 0x17B5608 VA: 0x17B9608
	internal static void WriteStringWithCode(string value, __BinaryWriter sout) { }

	// RVA: 0x17B9684 Offset: 0x17B5684 VA: 0x17B9684
	internal static void WriteWithCode(Type type, object value, __BinaryWriter sout) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryAssemblyInfo // TypeDefIndex: 997
{
	// Fields
	internal string assemblyString; // 0x10
	private Assembly assembly; // 0x18

	// Methods

	// RVA: 0x17B9F04 Offset: 0x17B5F04 VA: 0x17B9F04
	internal void .ctor(string assemblyString) { }

	// RVA: 0x17B9F34 Offset: 0x17B5F34 VA: 0x17B9F34
	internal void .ctor(string assemblyString, Assembly assembly) { }

	// RVA: 0x17B9F78 Offset: 0x17B5F78 VA: 0x17B9F78
	internal Assembly GetAssembly() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerializationHeaderRecord // TypeDefIndex: 998
{
	// Fields
	internal int binaryFormatterMajorVersion; // 0x10
	internal int binaryFormatterMinorVersion; // 0x14
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x18
	internal int topId; // 0x1C
	internal int headerId; // 0x20
	internal int majorVersion; // 0x24
	internal int minorVersion; // 0x28

	// Methods

	// RVA: 0x17BA0A8 Offset: 0x17B60A8 VA: 0x17BA0A8
	internal void .ctor() { }

	// RVA: 0x17BA0B8 Offset: 0x17B60B8 VA: 0x17BA0B8
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum, int topId, int headerId, int majorVersion, int minorVersion) { }

	// RVA: 0x17BA110 Offset: 0x17B6110 VA: 0x17BA110 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x17BA1C0 Offset: 0x17B61C0 VA: 0x17BA1C0
	private static int GetInt32(byte[] buffer, int index) { }

	// RVA: 0x17BA230 Offset: 0x17B6230 VA: 0x17BA230 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x17BA3A8 Offset: 0x17B63A8 VA: 0x17BA3A8
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryAssembly // TypeDefIndex: 999
{
	// Fields
	internal int assemId; // 0x10
	internal string assemblyString; // 0x18

	// Methods

	// RVA: 0x17BA3AC Offset: 0x17B63AC VA: 0x17BA3AC
	internal void .ctor() { }

	// RVA: 0x17BA3B4 Offset: 0x17B63B4 VA: 0x17BA3B4
	internal void Set(int assemId, string assemblyString) { }

	// RVA: 0x17BA3C8 Offset: 0x17B63C8 VA: 0x17BA3C8 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x17BA438 Offset: 0x17B6438 VA: 0x17BA438 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x17BA4A0 Offset: 0x17B64A0 VA: 0x17BA4A0
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryCrossAppDomainAssembly // TypeDefIndex: 1000
{
	// Fields
	internal int assemId; // 0x10
	internal int assemblyIndex; // 0x14

	// Methods

	// RVA: 0x17BA4A4 Offset: 0x17B64A4 VA: 0x17BA4A4
	internal void .ctor() { }

	// RVA: 0x17BA4AC Offset: 0x17B64AC VA: 0x17BA4AC Slot: 4
	public void Read(__BinaryParser input) { }

	// RVA: 0x17BA50C Offset: 0x17B650C VA: 0x17BA50C
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObject // TypeDefIndex: 1001
{
	// Fields
	internal int objectId; // 0x10
	internal int mapId; // 0x14

	// Methods

	// RVA: 0x17BA510 Offset: 0x17B6510 VA: 0x17BA510
	internal void .ctor() { }

	// RVA: 0x17BA518 Offset: 0x17B6518 VA: 0x17BA518
	internal void Set(int objectId, int mapId) { }

	// RVA: 0x17BA520 Offset: 0x17B6520 VA: 0x17BA520 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x17BA590 Offset: 0x17B6590 VA: 0x17BA590 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x17BA5F0 Offset: 0x17B65F0 VA: 0x17BA5F0
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryMethodCall // TypeDefIndex: 1002
{
	// Fields
	private string methodName; // 0x10
	private string typeName; // 0x18
	private object[] args; // 0x20
	private object callContext; // 0x28
	private Type[] argTypes; // 0x30
	private bool bArgsPrimitive; // 0x38
	private MessageEnum messageEnum; // 0x3C

	// Methods

	// RVA: 0x17BA5F4 Offset: 0x17B65F4 VA: 0x17BA5F4
	internal void Write(__BinaryWriter sout) { }

	// RVA: 0x17BA71C Offset: 0x17B671C VA: 0x17BA71C
	internal void Dump() { }

	// RVA: 0x17BA720 Offset: 0x17B6720 VA: 0x17BA720
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryMethodReturn // TypeDefIndex: 1003
{
	// Fields
	private object returnValue; // 0x10
	private object[] args; // 0x18
	private object callContext; // 0x20
	private Type[] argTypes; // 0x28
	private bool bArgsPrimitive; // 0x30
	private MessageEnum messageEnum; // 0x34
	private Type returnType; // 0x38
	private static object instanceOfVoid; // 0x0

	// Methods

	// RVA: 0x17BA730 Offset: 0x17B6730 VA: 0x17BA730
	private static void .cctor() { }

	// RVA: 0x17BA7E8 Offset: 0x17B67E8 VA: 0x17BA7E8
	internal void .ctor() { }

	// RVA: 0x17BA7F8 Offset: 0x17B67F8 VA: 0x17BA7F8 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x17BA920 Offset: 0x17B6920 VA: 0x17BA920
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObjectString // TypeDefIndex: 1004
{
	// Fields
	internal int objectId; // 0x10
	internal string value; // 0x18

	// Methods

	// RVA: 0x17BA924 Offset: 0x17B6924 VA: 0x17BA924
	internal void .ctor() { }

	// RVA: 0x17BA92C Offset: 0x17B692C VA: 0x17BA92C
	internal void Set(int objectId, string value) { }

	// RVA: 0x17BA940 Offset: 0x17B6940 VA: 0x17BA940 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x17BA9B0 Offset: 0x17B69B0 VA: 0x17BA9B0 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x17BAA18 Offset: 0x17B6A18 VA: 0x17BAA18
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryCrossAppDomainString // TypeDefIndex: 1005
{
	// Fields
	internal int objectId; // 0x10
	internal int value; // 0x14

	// Methods

	// RVA: 0x17BAA1C Offset: 0x17B6A1C VA: 0x17BAA1C
	internal void .ctor() { }

	// RVA: 0x17BAA24 Offset: 0x17B6A24 VA: 0x17BAA24 Slot: 4
	public void Read(__BinaryParser input) { }

	// RVA: 0x17BAA84 Offset: 0x17B6A84 VA: 0x17BAA84
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryCrossAppDomainMap // TypeDefIndex: 1006
{
	// Fields
	internal int crossAppDomainArrayIndex; // 0x10

	// Methods

	// RVA: 0x17BAA88 Offset: 0x17B6A88 VA: 0x17BAA88
	internal void .ctor() { }

	// RVA: 0x17BAA90 Offset: 0x17B6A90 VA: 0x17BAA90 Slot: 4
	public void Read(__BinaryParser input) { }

	// RVA: 0x17BAAC4 Offset: 0x17B6AC4 VA: 0x17BAAC4
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class MemberPrimitiveTyped // TypeDefIndex: 1007
{
	// Fields
	internal InternalPrimitiveTypeE primitiveTypeEnum; // 0x10
	internal object value; // 0x18

	// Methods

	// RVA: 0x17BAAC8 Offset: 0x17B6AC8 VA: 0x17BAAC8
	internal void .ctor() { }

	// RVA: 0x17BAAD0 Offset: 0x17B6AD0 VA: 0x17BAAD0
	internal void Set(InternalPrimitiveTypeE primitiveTypeEnum, object value) { }

	// RVA: 0x17BAAE4 Offset: 0x17B6AE4 VA: 0x17BAAE4 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x17BAB44 Offset: 0x17B6B44 VA: 0x17BAB44 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x17BAF6C Offset: 0x17B6F6C VA: 0x17BAF6C
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObjectWithMap // TypeDefIndex: 1008
{
	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal int assemId; // 0x30

	// Methods

	// RVA: 0x17BAF70 Offset: 0x17B6F70 VA: 0x17BAF70
	internal void .ctor() { }

	// RVA: 0x17BAF78 Offset: 0x17B6F78 VA: 0x17BAF78
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x17BAFA0 Offset: 0x17B6FA0 VA: 0x17BAFA0
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId) { }

	// RVA: 0x17BB004 Offset: 0x17B7004 VA: 0x17BB004 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x17BB118 Offset: 0x17B7118 VA: 0x17BB118 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x17BB288 Offset: 0x17B7288 VA: 0x17BB288
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObjectWithMapTyped // TypeDefIndex: 1009
{
	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x30
	internal object[] typeInformationA; // 0x38
	internal int[] memberAssemIds; // 0x40
	internal int assemId; // 0x48

	// Methods

	// RVA: 0x17BB28C Offset: 0x17B728C VA: 0x17BB28C
	internal void .ctor() { }

	// RVA: 0x17BB294 Offset: 0x17B7294 VA: 0x17BB294
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x17BB2BC Offset: 0x17B72BC VA: 0x17BB2BC
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, int assemId) { }

	// RVA: 0x17BB36C Offset: 0x17B736C VA: 0x17BB36C Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x17BB544 Offset: 0x17B7544 VA: 0x17BB544 Slot: 5
	public void Read(__BinaryParser input) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryArray // TypeDefIndex: 1010
{
	// Fields
	internal int objectId; // 0x10
	internal int rank; // 0x14
	internal int[] lengthA; // 0x18
	internal int[] lowerBoundA; // 0x20
	internal BinaryTypeEnum binaryTypeEnum; // 0x28
	internal object typeInformation; // 0x30
	internal int assemId; // 0x38
	private BinaryHeaderEnum binaryHeaderEnum; // 0x3C
	internal BinaryArrayTypeEnum binaryArrayTypeEnum; // 0x40

	// Methods

	// RVA: 0x17BB890 Offset: 0x17B7890 VA: 0x17BB890
	internal void .ctor() { }

	// RVA: 0x17BB898 Offset: 0x17B7898 VA: 0x17BB898
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x17BB8C0 Offset: 0x17B78C0 VA: 0x17BB8C0
	internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	// RVA: 0x17BB95C Offset: 0x17B795C VA: 0x17BB95C Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x17BBC34 Offset: 0x17B7C34 VA: 0x17BBC34 Slot: 5
	public void Read(__BinaryParser input) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class MemberPrimitiveUnTyped // TypeDefIndex: 1011
{
	// Fields
	internal InternalPrimitiveTypeE typeInformation; // 0x10
	internal object value; // 0x18

	// Methods

	// RVA: 0x17BC0A8 Offset: 0x17B80A8 VA: 0x17BC0A8
	internal void .ctor() { }

	// RVA: 0x17BC0B0 Offset: 0x17B80B0 VA: 0x17BC0B0
	internal void Set(InternalPrimitiveTypeE typeInformation, object value) { }

	// RVA: 0x17BC0C4 Offset: 0x17B80C4 VA: 0x17BC0C4
	internal void Set(InternalPrimitiveTypeE typeInformation) { }

	// RVA: 0x17BC0CC Offset: 0x17B80CC VA: 0x17BC0CC Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x17BC0EC Offset: 0x17B80EC VA: 0x17BC0EC Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x17BC120 Offset: 0x17B8120 VA: 0x17BC120
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class MemberReference // TypeDefIndex: 1012
{
	// Fields
	internal int idRef; // 0x10

	// Methods

	// RVA: 0x17BC124 Offset: 0x17B8124 VA: 0x17BC124
	internal void .ctor() { }

	// RVA: 0x17BC12C Offset: 0x17B812C VA: 0x17BC12C
	internal void Set(int idRef) { }

	// RVA: 0x17BC134 Offset: 0x17B8134 VA: 0x17BC134 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x17BC188 Offset: 0x17B8188 VA: 0x17BC188 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x17BC1BC Offset: 0x17B81BC VA: 0x17BC1BC
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectNull // TypeDefIndex: 1013
{
	// Fields
	internal int nullCount; // 0x10

	// Methods

	// RVA: 0x17BC1C0 Offset: 0x17B81C0 VA: 0x17BC1C0
	internal void .ctor() { }

	// RVA: 0x17BC1C8 Offset: 0x17B81C8 VA: 0x17BC1C8
	internal void SetNullCount(int nullCount) { }

	// RVA: 0x17BC1D0 Offset: 0x17B81D0 VA: 0x17BC1D0 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x17BC284 Offset: 0x17B8284 VA: 0x17BC284
	public void Read(__BinaryParser input, BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x17BC2F8 Offset: 0x17B82F8 VA: 0x17BC2F8
	public void Dump() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class MessageEnd // TypeDefIndex: 1014
{
	// Methods

	// RVA: 0x17BC2FC Offset: 0x17B82FC VA: 0x17BC2FC
	internal void .ctor() { }

	// RVA: 0x17BC304 Offset: 0x17B8304 VA: 0x17BC304 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x17BC32C Offset: 0x17B832C VA: 0x17BC32C Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x17BC330 Offset: 0x17B8330 VA: 0x17BC330
	public void Dump() { }

	// RVA: 0x17BC334 Offset: 0x17B8334 VA: 0x17BC334
	public void Dump(Stream sout) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectMap // TypeDefIndex: 1015
{
	// Fields
	internal string objectName; // 0x10
	internal Type objectType; // 0x18
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x20
	internal object[] typeInformationA; // 0x28
	internal Type[] memberTypes; // 0x30
	internal string[] memberNames; // 0x38
	internal ReadObjectInfo objectInfo; // 0x40
	internal bool isInitObjectInfo; // 0x48
	internal ObjectReader objectReader; // 0x50
	internal int objectId; // 0x58
	internal BinaryAssemblyInfo assemblyInfo; // 0x60

	// Methods

	// RVA: 0x17BC338 Offset: 0x17B8338 VA: 0x17BC338
	internal void .ctor(string objectName, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	// RVA: 0x17BCA9C Offset: 0x17B8A9C VA: 0x17BCA9C
	internal void .ctor(string objectName, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	// RVA: 0x17BCE38 Offset: 0x17B8E38 VA: 0x17BCE38
	internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x17BCF6C Offset: 0x17B8F6C VA: 0x17BCF6C
	internal static ObjectMap Create(string name, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	// RVA: 0x17BD004 Offset: 0x17B9004 VA: 0x17BD004
	internal static ObjectMap Create(string name, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectProgress // TypeDefIndex: 1016
{
	// Fields
	internal static int opRecordIdCount; // 0x0
	internal bool isInitial; // 0x10
	internal int count; // 0x14
	internal BinaryTypeEnum expectedType; // 0x18
	internal object expectedTypeInformation; // 0x20
	internal string name; // 0x28
	internal InternalObjectTypeE objectTypeEnum; // 0x30
	internal InternalMemberTypeE memberTypeEnum; // 0x34
	internal InternalMemberValueE memberValueEnum; // 0x38
	internal Type dtType; // 0x40
	internal int numItems; // 0x48
	internal BinaryTypeEnum binaryTypeEnum; // 0x4C
	internal object typeInformation; // 0x50
	internal int nullCount; // 0x58
	internal int memberLength; // 0x5C
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x60
	internal object[] typeInformationA; // 0x68
	internal string[] memberNames; // 0x70
	internal Type[] memberTypes; // 0x78
	internal ParseRecord pr; // 0x80

	// Methods

	// RVA: 0x17BD0C0 Offset: 0x17B90C0 VA: 0x17BD0C0
	internal void .ctor() { }

	// RVA: 0x17BD134 Offset: 0x17B9134 VA: 0x17BD134
	internal void Init() { }

	// RVA: 0x17BD1F4 Offset: 0x17B91F4 VA: 0x17BD1F4
	internal void ArrayCountIncrement(int value) { }

	// RVA: 0x17BD204 Offset: 0x17B9204 VA: 0x17BD204
	internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation) { }

	// RVA: 0x17BD364 Offset: 0x17B9364 VA: 0x17BD364
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class Converter // TypeDefIndex: 1017
{
	// Fields
	private static int primitiveTypeEnumLength; // 0x0
	private static Type[] typeA; // 0x8
	private static Type[] arrayTypeA; // 0x10
	private static string[] valueA; // 0x18
	private static TypeCode[] typeCodeA; // 0x20
	private static InternalPrimitiveTypeE[] codeA; // 0x28
	internal static Type typeofISerializable; // 0x30
	internal static Type typeofString; // 0x38
	internal static Type typeofConverter; // 0x40
	internal static Type typeofBoolean; // 0x48
	internal static Type typeofByte; // 0x50
	internal static Type typeofChar; // 0x58
	internal static Type typeofDecimal; // 0x60
	internal static Type typeofDouble; // 0x68
	internal static Type typeofInt16; // 0x70
	internal static Type typeofInt32; // 0x78
	internal static Type typeofInt64; // 0x80
	internal static Type typeofSByte; // 0x88
	internal static Type typeofSingle; // 0x90
	internal static Type typeofTimeSpan; // 0x98
	internal static Type typeofDateTime; // 0xA0
	internal static Type typeofUInt16; // 0xA8
	internal static Type typeofUInt32; // 0xB0
	internal static Type typeofUInt64; // 0xB8
	internal static Type typeofObject; // 0xC0
	internal static Type typeofSystemVoid; // 0xC8
	internal static Assembly urtAssembly; // 0xD0
	internal static string urtAssemblyString; // 0xD8
	internal static Type typeofTypeArray; // 0xE0
	internal static Type typeofObjectArray; // 0xE8
	internal static Type typeofStringArray; // 0xF0
	internal static Type typeofBooleanArray; // 0xF8
	internal static Type typeofByteArray; // 0x100
	internal static Type typeofCharArray; // 0x108
	internal static Type typeofDecimalArray; // 0x110
	internal static Type typeofDoubleArray; // 0x118
	internal static Type typeofInt16Array; // 0x120
	internal static Type typeofInt32Array; // 0x128
	internal static Type typeofInt64Array; // 0x130
	internal static Type typeofSByteArray; // 0x138
	internal static Type typeofSingleArray; // 0x140
	internal static Type typeofTimeSpanArray; // 0x148
	internal static Type typeofDateTimeArray; // 0x150
	internal static Type typeofUInt16Array; // 0x158
	internal static Type typeofUInt32Array; // 0x160
	internal static Type typeofUInt64Array; // 0x168
	internal static Type typeofMarshalByRefObject; // 0x170

	// Methods

	// RVA: 0x17B8850 Offset: 0x17B4850 VA: 0x17B8850
	internal static InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x17BD468 Offset: 0x17B9468 VA: 0x17BD468
	internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code) { }

	// RVA: 0x17BD484 Offset: 0x17B9484 VA: 0x17BD484
	internal static int TypeLength(InternalPrimitiveTypeE code) { }

	// RVA: 0x17B9380 Offset: 0x17B5380 VA: 0x17B9380
	internal static Type ToArrayType(InternalPrimitiveTypeE code) { }

	// RVA: 0x17BD924 Offset: 0x17B9924 VA: 0x17BD924
	private static void InitTypeA() { }

	// RVA: 0x17BD4A8 Offset: 0x17B94A8 VA: 0x17BD4A8
	private static void InitArrayTypeA() { }

	// RVA: 0x17B92C8 Offset: 0x17B52C8 VA: 0x17B92C8
	internal static Type ToType(InternalPrimitiveTypeE code) { }

	// RVA: 0x17BDDA0 Offset: 0x17B9DA0 VA: 0x17BDDA0
	internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length) { }

	// RVA: 0x17B829C Offset: 0x17B429C VA: 0x17B829C
	internal static bool IsPrimitiveArray(Type type, out object typeInformation) { }

	// RVA: 0x17BDEC0 Offset: 0x17B9EC0 VA: 0x17BDEC0
	private static void InitValueA() { }

	// RVA: 0x17B9210 Offset: 0x17B5210 VA: 0x17B9210
	internal static string ToComType(InternalPrimitiveTypeE code) { }

	// RVA: 0x17BE27C Offset: 0x17BA27C VA: 0x17BE27C
	private static void InitTypeCodeA() { }

	// RVA: 0x17BE414 Offset: 0x17BA414 VA: 0x17BE414
	internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code) { }

	// RVA: 0x17BE4CC Offset: 0x17BA4CC VA: 0x17BE4CC
	private static void InitCodeA() { }

	// RVA: 0x17BD3B0 Offset: 0x17B93B0 VA: 0x17BD3B0
	internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode) { }

	// RVA: 0x17BE678 Offset: 0x17BA678 VA: 0x17BE678
	internal static object FromString(string value, InternalPrimitiveTypeE code) { }

	// RVA: 0x17BE764 Offset: 0x17BA764 VA: 0x17BE764
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
[ComVisible(True)]
public sealed class BinaryFormatter // TypeDefIndex: 1018
{
	// Fields
	internal ISurrogateSelector m_surrogates; // 0x10
	internal StreamingContext m_context; // 0x18
	internal SerializationBinder m_binder; // 0x28
	internal FormatterTypeStyle m_typeFormat; // 0x30
	internal FormatterAssemblyStyle m_assemblyFormat; // 0x34
	internal TypeFilterLevel m_securityLevel; // 0x38
	internal object[] m_crossAppDomainArray; // 0x40
	private static Dictionary<Type, TypeInformation> typeNameCache; // 0x0

	// Properties
	public FormatterAssemblyStyle AssemblyFormat { set; }
	public ISurrogateSelector SurrogateSelector { set; }

	// Methods

	// RVA: 0x17BEFE4 Offset: 0x17BAFE4 VA: 0x17BEFE4
	public void set_AssemblyFormat(FormatterAssemblyStyle value) { }

	// RVA: 0x17BEFEC Offset: 0x17BAFEC VA: 0x17BEFEC Slot: 4
	public void set_SurrogateSelector(ISurrogateSelector value) { }

	// RVA: 0x17BEFF4 Offset: 0x17BAFF4 VA: 0x17BEFF4
	public void .ctor() { }

	// RVA: 0x17BF060 Offset: 0x17BB060 VA: 0x17BF060
	public void .ctor(ISurrogateSelector selector, StreamingContext context) { }

	// RVA: 0x17BF0C4 Offset: 0x17BB0C4 VA: 0x17BF0C4 Slot: 5
	public object Deserialize(Stream serializationStream) { }

	// RVA: 0x17BF0D8 Offset: 0x17BB0D8 VA: 0x17BF0D8
	internal object Deserialize(Stream serializationStream, HeaderHandler handler, bool fCheck) { }

	// RVA: 0x17BF0D0 Offset: 0x17BB0D0 VA: 0x17BF0D0 Slot: 6
	public object Deserialize(Stream serializationStream, HeaderHandler handler) { }

	// RVA: 0x17BF930 Offset: 0x17BB930 VA: 0x17BF930 Slot: 7
	public void Serialize(Stream serializationStream, object graph) { }

	// RVA: 0x17BF93C Offset: 0x17BB93C VA: 0x17BF93C Slot: 8
	public void Serialize(Stream serializationStream, object graph, Header[] headers) { }

	// RVA: 0x17BF944 Offset: 0x17BB944 VA: 0x17BF944
	internal void Serialize(Stream serializationStream, object graph, Header[] headers, bool fCheck) { }

	// RVA: 0x17C014C Offset: 0x17BC14C VA: 0x17C014C
	internal static TypeInformation GetTypeInformation(Type type) { }

	// RVA: 0x17C03FC Offset: 0x17BC3FC VA: 0x17C03FC
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class __BinaryWriter // TypeDefIndex: 1019
{
	// Fields
	internal Stream sout; // 0x10
	internal FormatterTypeStyle formatterTypeStyle; // 0x18
	internal Hashtable objectMapTable; // 0x20
	internal ObjectWriter objectWriter; // 0x28
	internal BinaryWriter dataWriter; // 0x30
	internal int m_nestedObjectCount; // 0x38
	private int nullCount; // 0x3C
	internal BinaryMethodCall binaryMethodCall; // 0x40
	internal BinaryMethodReturn binaryMethodReturn; // 0x48
	internal BinaryObject binaryObject; // 0x50
	internal BinaryObjectWithMap binaryObjectWithMap; // 0x58
	internal BinaryObjectWithMapTyped binaryObjectWithMapTyped; // 0x60
	internal BinaryObjectString binaryObjectString; // 0x68
	internal BinaryArray binaryArray; // 0x70
	private byte[] byteBuffer; // 0x78
	private int chunkSize; // 0x80
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0x88
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0x90
	internal ObjectNull objectNull; // 0x98
	internal MemberReference memberReference; // 0xA0
	internal BinaryAssembly binaryAssembly; // 0xA8

	// Methods

	// RVA: 0x17BFC60 Offset: 0x17BBC60 VA: 0x17BFC60
	internal void .ctor(Stream sout, ObjectWriter objectWriter, FormatterTypeStyle formatterTypeStyle) { }

	// RVA: 0x17C0494 Offset: 0x17BC494 VA: 0x17C0494
	internal void WriteBegin() { }

	// RVA: 0x17C0498 Offset: 0x17BC498 VA: 0x17C0498
	internal void WriteEnd() { }

	// RVA: 0x17C04B4 Offset: 0x17BC4B4 VA: 0x17C04B4
	internal void WriteBoolean(bool value) { }

	// RVA: 0x17B8BA4 Offset: 0x17B4BA4 VA: 0x17B8BA4
	internal void WriteByte(byte value) { }

	// RVA: 0x17C04D4 Offset: 0x17BC4D4 VA: 0x17C04D4
	private void WriteBytes(byte[] value) { }

	// RVA: 0x17C04F0 Offset: 0x17BC4F0 VA: 0x17C04F0
	private void WriteBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x17C050C Offset: 0x17BC50C VA: 0x17C050C
	internal void WriteChar(char value) { }

	// RVA: 0x17C0528 Offset: 0x17BC528 VA: 0x17C0528
	internal void WriteChars(char[] value) { }

	// RVA: 0x17C0548 Offset: 0x17BC548 VA: 0x17C0548
	internal void WriteDecimal(Decimal value) { }

	// RVA: 0x17C0644 Offset: 0x17BC644 VA: 0x17C0644
	internal void WriteSingle(float value) { }

	// RVA: 0x17C0664 Offset: 0x17BC664 VA: 0x17C0664
	internal void WriteDouble(double value) { }

	// RVA: 0x17C0684 Offset: 0x17BC684 VA: 0x17C0684
	internal void WriteInt16(short value) { }

	// RVA: 0x17B8BE0 Offset: 0x17B4BE0 VA: 0x17B8BE0
	internal void WriteInt32(int value) { }

	// RVA: 0x17C06A4 Offset: 0x17BC6A4 VA: 0x17C06A4
	internal void WriteInt64(long value) { }

	// RVA: 0x17C06C4 Offset: 0x17BC6C4 VA: 0x17C06C4
	internal void WriteSByte(sbyte value) { }

	// RVA: 0x17B8BC0 Offset: 0x17B4BC0 VA: 0x17B8BC0
	internal void WriteString(string value) { }

	// RVA: 0x17C06E0 Offset: 0x17BC6E0 VA: 0x17C06E0
	internal void WriteTimeSpan(TimeSpan value) { }

	// RVA: 0x17C0758 Offset: 0x17BC758 VA: 0x17C0758
	internal void WriteDateTime(DateTime value) { }

	// RVA: 0x17C07D0 Offset: 0x17BC7D0 VA: 0x17C07D0
	internal void WriteUInt16(ushort value) { }

	// RVA: 0x17C07F0 Offset: 0x17BC7F0 VA: 0x17C07F0
	internal void WriteUInt32(uint value) { }

	// RVA: 0x17C0810 Offset: 0x17BC810 VA: 0x17C0810
	internal void WriteUInt64(ulong value) { }

	// RVA: 0x17C0830 Offset: 0x17BC830 VA: 0x17C0830
	internal void WriteObjectEnd(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x17C0834 Offset: 0x17BC834 VA: 0x17C0834
	internal void WriteSerializationHeaderEnd() { }

	// RVA: 0x17C0894 Offset: 0x17BC894 VA: 0x17C0894
	internal void WriteSerializationHeader(int topId, int headerId, int minorVersion, int majorVersion) { }

	// RVA: 0x17C0924 Offset: 0x17BC924 VA: 0x17C0924
	internal void WriteMethodCall() { }

	// RVA: 0x17C09AC Offset: 0x17BC9AC VA: 0x17C09AC
	internal void WriteMethodReturn() { }

	// RVA: 0x17C0A34 Offset: 0x17BCA34 VA: 0x17C0A34
	internal void WriteObject(NameInfo nameInfo, NameInfo typeNameInfo, int numMembers, string[] memberNames, Type[] memberTypes, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x17C11F8 Offset: 0x17BD1F8 VA: 0x17C11F8
	internal void WriteObjectString(int objectId, string value) { }

	// RVA: 0x17C12A8 Offset: 0x17BD2A8 VA: 0x17C12A8
	internal void WriteSingleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, Array array) { }

	// RVA: 0x17C1574 Offset: 0x17BD574 VA: 0x17C1574
	private void WriteArrayAsBytes(Array array, int typeLength) { }

	// RVA: 0x17C16CC Offset: 0x17BD6CC VA: 0x17C16CC
	internal void WriteJaggedArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound) { }

	// RVA: 0x17C1874 Offset: 0x17BD874 VA: 0x17C1874
	internal void WriteRectangleArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int rank, int[] lengthA, int[] lowerBoundA) { }

	// RVA: 0x17C19F0 Offset: 0x17BD9F0 VA: 0x17C19F0
	internal void WriteObjectByteArray(NameInfo memberNameInfo, NameInfo arrayNameInfo, WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, int length, int lowerBound, byte[] byteA) { }

	// RVA: 0x17C1A50 Offset: 0x17BDA50 VA: 0x17C1A50
	internal void WriteMember(NameInfo memberNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x17C1B8C Offset: 0x17BDB8C VA: 0x17C1B8C
	internal void WriteNullMember(NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x17C1C3C Offset: 0x17BDC3C VA: 0x17C1C3C
	internal void WriteMemberObjectRef(NameInfo memberNameInfo, int idRef) { }

	// RVA: 0x17C1CDC Offset: 0x17BDCDC VA: 0x17C1CDC
	internal void WriteMemberNested(NameInfo memberNameInfo) { }

	// RVA: 0x17C1CF8 Offset: 0x17BDCF8 VA: 0x17C1CF8
	internal void WriteMemberString(NameInfo memberNameInfo, NameInfo typeNameInfo, string value) { }

	// RVA: 0x17C1D40 Offset: 0x17BDD40 VA: 0x17C1D40
	internal void WriteItem(NameInfo itemNameInfo, NameInfo typeNameInfo, object value) { }

	// RVA: 0x17C1D80 Offset: 0x17BDD80 VA: 0x17C1D80
	internal void WriteNullItem(NameInfo itemNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x17C1D90 Offset: 0x17BDD90 VA: 0x17C1D90
	internal void WriteDelayedNullItem() { }

	// RVA: 0x17C1DA0 Offset: 0x17BDDA0 VA: 0x17C1DA0
	internal void WriteItemEnd() { }

	// RVA: 0x17C0FE4 Offset: 0x17BCFE4 VA: 0x17C0FE4
	private void InternalWriteItemNull() { }

	// RVA: 0x17C1DA4 Offset: 0x17BDDA4 VA: 0x17C1DA4
	internal void WriteItemObjectRef(NameInfo nameInfo, int idRef) { }

	// RVA: 0x17C1DD4 Offset: 0x17BDDD4 VA: 0x17C1DD4
	internal void WriteAssembly(Type type, string assemblyString, int assemId, bool isNew) { }

	// RVA: 0x17B97A4 Offset: 0x17B57A4 VA: 0x17B97A4
	internal void WriteValue(InternalPrimitiveTypeE code, object value) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectMapInfo // TypeDefIndex: 1020
{
	// Fields
	internal int objectId; // 0x10
	private int numMembers; // 0x14
	private string[] memberNames; // 0x18
	private Type[] memberTypes; // 0x20

	// Methods

	// RVA: 0x17C11A0 Offset: 0x17BD1A0 VA: 0x17C11A0
	internal void .ctor(int objectId, int numMembers, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x17C1080 Offset: 0x17BD080 VA: 0x17C1080
	internal bool isCompatible(int numMembers, string[] memberNames, Type[] memberTypes) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class WriteObjectInfo // TypeDefIndex: 1021
{
	// Fields
	internal int objectInfoId; // 0x10
	internal object obj; // 0x18
	internal Type objectType; // 0x20
	internal bool isSi; // 0x28
	internal bool isNamed; // 0x29
	internal bool isTyped; // 0x2A
	internal bool isArray; // 0x2B
	internal SerializationInfo si; // 0x30
	internal SerObjectInfoCache cache; // 0x38
	internal object[] memberData; // 0x40
	internal ISerializationSurrogate serializationSurrogate; // 0x48
	internal StreamingContext context; // 0x50
	internal SerObjectInfoInit serObjectInfoInit; // 0x60
	internal long objectId; // 0x68
	internal long assemId; // 0x70
	private string binderTypeName; // 0x78
	private string binderAssemblyString; // 0x80

	// Methods

	// RVA: 0x17C1EB8 Offset: 0x17BDEB8 VA: 0x17C1EB8
	internal void .ctor() { }

	// RVA: 0x17C1EC0 Offset: 0x17BDEC0 VA: 0x17C1EC0
	internal void ObjectEnd() { }

	// RVA: 0x17C1EEC Offset: 0x17BDEEC VA: 0x17C1EEC
	private void InternalInit() { }

	// RVA: 0x17C1F6C Offset: 0x17BDF6C VA: 0x17C1F6C
	internal static WriteObjectInfo Serialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x17C20C8 Offset: 0x17BE0C8 VA: 0x17C20C8
	internal void InitSerialize(object obj, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, ObjectWriter objectWriter, SerializationBinder binder) { }

	// RVA: 0x17C2F28 Offset: 0x17BEF28 VA: 0x17C2F28
	internal static WriteObjectInfo Serialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x17C2FB0 Offset: 0x17BEFB0 VA: 0x17C2FB0
	internal void InitSerialize(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, SerializationBinder binder) { }

	// RVA: 0x17C2770 Offset: 0x17BE770 VA: 0x17C2770
	private void InitSiWrite() { }

	// RVA: 0x17C2AA8 Offset: 0x17BEAA8 VA: 0x17C2AA8
	private static void CheckTypeForwardedFrom(SerObjectInfoCache cache, Type objectType, string binderAssemblyString) { }

	// RVA: 0x17C262C Offset: 0x17BE62C VA: 0x17C262C
	private void InitNoMembers() { }

	// RVA: 0x17C2C00 Offset: 0x17BEC00 VA: 0x17C2C00
	private void InitMemberInfo() { }

	// RVA: 0x17B8630 Offset: 0x17B4630 VA: 0x17B8630
	internal string GetTypeFullName() { }

	// RVA: 0x17B8608 Offset: 0x17B4608 VA: 0x17B8608
	internal string GetAssemblyString() { }

	// RVA: 0x17C2748 Offset: 0x17BE748 VA: 0x17C2748
	private void InvokeSerializationBinder(SerializationBinder binder) { }

	// RVA: 0x17C3400 Offset: 0x17BF400 VA: 0x17C3400
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x17C3570 Offset: 0x17BF570 VA: 0x17C3570
	internal void GetMemberInfo(out string[] outMemberNames, out Type[] outMemberTypes, out object[] outMemberData) { }

	// RVA: 0x17C1FFC Offset: 0x17BDFFC VA: 0x17C1FFC
	private static WriteObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }

	// RVA: 0x17C1ECC Offset: 0x17BDECC VA: 0x17C1ECC
	private static void PutObjectInfo(SerObjectInfoInit serObjectInfoInit, WriteObjectInfo objectInfo) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ReadObjectInfo // TypeDefIndex: 1022
{
	// Fields
	internal int objectInfoId; // 0x10
	internal static int readObjectInfoCounter; // 0x0
	internal Type objectType; // 0x18
	internal ObjectManager objectManager; // 0x20
	internal int count; // 0x28
	internal bool isSi; // 0x2C
	internal bool isNamed; // 0x2D
	internal bool isTyped; // 0x2E
	internal bool bSimpleAssembly; // 0x2F
	internal SerObjectInfoCache cache; // 0x30
	internal string[] wireMemberNames; // 0x38
	internal Type[] wireMemberTypes; // 0x40
	private int lastPosition; // 0x48
	internal ISerializationSurrogate serializationSurrogate; // 0x50
	internal StreamingContext context; // 0x58
	internal List<Type> memberTypesList; // 0x68
	internal SerObjectInfoInit serObjectInfoInit; // 0x70
	internal IFormatterConverter formatterConverter; // 0x78

	// Methods

	// RVA: 0x17C3638 Offset: 0x17BF638 VA: 0x17C3638
	internal void .ctor() { }

	// RVA: 0x17C3640 Offset: 0x17BF640 VA: 0x17C3640
	internal void ObjectEnd() { }

	// RVA: 0x17BCF64 Offset: 0x17B8F64 VA: 0x17BCF64
	internal void PrepareForReuse() { }

	// RVA: 0x17C3644 Offset: 0x17BF644 VA: 0x17C3644
	internal static ReadObjectInfo Create(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x17C3748 Offset: 0x17BF748 VA: 0x17C3748
	internal void Init(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x17C39AC Offset: 0x17BF9AC VA: 0x17C39AC
	internal static ReadObjectInfo Create(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x17C3A48 Offset: 0x17BFA48 VA: 0x17C3A48
	internal void Init(Type objectType, string[] memberNames, Type[] memberTypes, ISurrogateSelector surrogateSelector, StreamingContext context, ObjectManager objectManager, SerObjectInfoInit serObjectInfoInit, IFormatterConverter converter, bool bSimpleAssembly) { }

	// RVA: 0x17C37FC Offset: 0x17BF7FC VA: 0x17C37FC
	private void InitReadConstructor(Type objectType, ISurrogateSelector surrogateSelector, StreamingContext context) { }

	// RVA: 0x17C3BC8 Offset: 0x17BFBC8 VA: 0x17C3BC8
	private void InitSiRead() { }

	// RVA: 0x17C3B64 Offset: 0x17BFB64 VA: 0x17C3B64
	private void InitNoMembers() { }

	// RVA: 0x17C3C54 Offset: 0x17BFC54 VA: 0x17C3C54
	private void InitMemberInfo() { }

	// RVA: 0x17C4010 Offset: 0x17C0010 VA: 0x17C4010
	internal MemberInfo GetMemberInfo(string name) { }

	// RVA: 0x17C42D4 Offset: 0x17C02D4 VA: 0x17C42D4
	internal Type GetType(string name) { }

	// RVA: 0x17C4468 Offset: 0x17C0468 VA: 0x17C4468
	internal void AddValue(string name, object value, ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x17BCE78 Offset: 0x17B8E78 VA: 0x17BCE78
	internal void InitDataStore(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x17C4510 Offset: 0x17C0510 VA: 0x17C4510
	internal void RecordFixup(long objectId, string name, long idRef) { }

	// RVA: 0x17C45B4 Offset: 0x17C05B4 VA: 0x17C45B4
	internal void PopulateObjectMembers(object obj, object[] memberData) { }

	// RVA: 0x17C41A0 Offset: 0x17C01A0 VA: 0x17C41A0
	private int Position(string name) { }

	// RVA: 0x17BC5A4 Offset: 0x17B85A4 VA: 0x17BC5A4
	internal Type[] GetMemberTypes(string[] inMemberNames, Type objectType) { }

	// RVA: 0x17C3EA0 Offset: 0x17BFEA0 VA: 0x17C3EA0
	internal Type GetMemberType(MemberInfo objMember) { }

	// RVA: 0x17C36D4 Offset: 0x17BF6D4 VA: 0x17C36D4
	private static ReadObjectInfo GetObjectInfo(SerObjectInfoInit serObjectInfoInit) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerObjectInfoInit // TypeDefIndex: 1023
{
	// Fields
	internal Hashtable seenBeforeTable; // 0x10
	internal int objectInfoIdCount; // 0x18
	internal SerStack oiPool; // 0x20

	// Methods

	// RVA: 0x17C4650 Offset: 0x17C0650 VA: 0x17C4650
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerObjectInfoCache // TypeDefIndex: 1024
{
	// Fields
	internal string fullTypeName; // 0x10
	internal string assemblyString; // 0x18
	internal bool hasTypeForwardedFrom; // 0x20
	internal MemberInfo[] memberInfos; // 0x28
	internal string[] memberNames; // 0x30
	internal Type[] memberTypes; // 0x38

	// Methods

	// RVA: 0x17C33A8 Offset: 0x17BF3A8 VA: 0x17C33A8
	internal void .ctor(string typeName, string assemblyName, bool hasTypeForwardedFrom) { }

	// RVA: 0x17C3304 Offset: 0x17BF304 VA: 0x17C3304
	internal void .ctor(Type type) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class TypeInformation // TypeDefIndex: 1025
{
	// Fields
	private string fullTypeName; // 0x10
	private string assemblyString; // 0x18
	private bool hasTypeForwardedFrom; // 0x20

	// Properties
	internal string FullTypeName { get; }
	internal string AssemblyString { get; }
	internal bool HasTypeForwardedFrom { get; }

	// Methods

	// RVA: 0x17C471C Offset: 0x17C071C VA: 0x17C471C
	internal string get_FullTypeName() { }

	// RVA: 0x17C4724 Offset: 0x17C0724 VA: 0x17C4724
	internal string get_AssemblyString() { }

	// RVA: 0x17C472C Offset: 0x17C072C VA: 0x17C472C
	internal bool get_HasTypeForwardedFrom() { }

	// RVA: 0x17C03A4 Offset: 0x17BC3A4 VA: 0x17C03A4
	internal void .ctor(string fullTypeName, string assemblyString, bool hasTypeForwardedFrom) { }
}

// Namespace: 
internal class ObjectReader.TypeNAssembly // TypeDefIndex: 1026
{
	// Fields
	public Type type; // 0x10
	public string assemblyName; // 0x18

	// Methods

	// RVA: 0x17C7930 Offset: 0x17C3930 VA: 0x17C7930
	public void .ctor() { }
}

// Namespace: 
internal sealed class ObjectReader.TopLevelAssemblyTypeResolver // TypeDefIndex: 1027
{
	// Fields
	private Assembly m_topLevelAssembly; // 0x10

	// Methods

	// RVA: 0x17C7938 Offset: 0x17C3938 VA: 0x17C7938
	public void .ctor(Assembly topLevelAssembly) { }

	// RVA: 0x17C7968 Offset: 0x17C3968 VA: 0x17C7968
	public Type ResolveType(Assembly assembly, string simpleTypeName, bool ignoreCase) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectReader // TypeDefIndex: 1028
{
	// Fields
	internal Stream m_stream; // 0x10
	internal ISurrogateSelector m_surrogates; // 0x18
	internal StreamingContext m_context; // 0x20
	internal ObjectManager m_objectManager; // 0x30
	internal InternalFE formatterEnums; // 0x38
	internal SerializationBinder m_binder; // 0x40
	internal long topId; // 0x48
	internal bool bSimpleAssembly; // 0x50
	internal object handlerObject; // 0x58
	internal object m_topObject; // 0x60
	internal Header[] headers; // 0x68
	internal HeaderHandler handler; // 0x70
	internal SerObjectInfoInit serObjectInfoInit; // 0x78
	internal IFormatterConverter m_formatterConverter; // 0x80
	internal SerStack stack; // 0x88
	private SerStack valueFixupStack; // 0x90
	internal object[] crossAppDomainArray; // 0x98
	private bool bFullDeserialization; // 0xA0
	private bool bOldFormatDetected; // 0xA1
	private IntSizedArray valTypeObjectIdTable; // 0xA8
	private NameCache typeCache; // 0xB0
	private string previousAssemblyString; // 0xB8
	private string previousName; // 0xC0
	private Type previousType; // 0xC8

	// Properties
	private SerStack ValueFixupStack { get; }
	internal object TopObject { get; set; }

	// Methods

	// RVA: 0x17C4734 Offset: 0x17C0734 VA: 0x17C4734
	private SerStack get_ValueFixupStack() { }

	// RVA: 0x17C47BC Offset: 0x17C07BC VA: 0x17C47BC
	internal object get_TopObject() { }

	// RVA: 0x17C47C4 Offset: 0x17C07C4 VA: 0x17C47C4
	internal void set_TopObject(object value) { }

	// RVA: 0x17BF308 Offset: 0x17BB308 VA: 0x17BF308
	internal void .ctor(Stream stream, ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x17BF59C Offset: 0x17BB59C VA: 0x17BF59C
	internal object Deserialize(HeaderHandler handler, __BinaryParser serParser, bool fCheck) { }

	// RVA: 0x17C4D7C Offset: 0x17C0D7C VA: 0x17C4D7C
	private bool HasSurrogate(Type t) { }

	// RVA: 0x17C4E50 Offset: 0x17C0E50 VA: 0x17C4E50
	private void CheckSerializable(Type t) { }

	// RVA: 0x17C4F80 Offset: 0x17C0F80 VA: 0x17C4F80
	private void InitFullDeserialization() { }

	// RVA: 0x17C50AC Offset: 0x17C10AC VA: 0x17C50AC
	internal object CrossAppDomainArray(int index) { }

	// RVA: 0x17BC574 Offset: 0x17B8574 VA: 0x17BC574
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType) { }

	// RVA: 0x17BCDF8 Offset: 0x17B8DF8 VA: 0x17BCDF8
	internal ReadObjectInfo CreateReadObjectInfo(Type objectType, string[] memberNames, Type[] memberTypes) { }

	// RVA: 0x17C50DC Offset: 0x17C10DC VA: 0x17C50DC
	internal void Parse(ParseRecord pr) { }

	// RVA: 0x17C5DBC Offset: 0x17C1DBC VA: 0x17C5DBC
	private void ParseError(ParseRecord processing, ParseRecord onStack) { }

	// RVA: 0x17C5248 Offset: 0x17C1248 VA: 0x17C5248
	private void ParseSerializedStreamHeader(ParseRecord pr) { }

	// RVA: 0x17C5260 Offset: 0x17C1260 VA: 0x17C5260
	private void ParseSerializedStreamHeaderEnd(ParseRecord pr) { }

	// RVA: 0x17C5278 Offset: 0x17C1278 VA: 0x17C5278
	private void ParseObject(ParseRecord pr) { }

	// RVA: 0x17C55CC Offset: 0x17C15CC VA: 0x17C55CC
	private void ParseObjectEnd(ParseRecord pr) { }

	// RVA: 0x17C6008 Offset: 0x17C2008 VA: 0x17C6008
	private void ParseArray(ParseRecord pr) { }

	// RVA: 0x17C671C Offset: 0x17C271C VA: 0x17C671C
	private void NextRectangleMap(ParseRecord pr) { }

	// RVA: 0x17C67E8 Offset: 0x17C27E8 VA: 0x17C67E8
	private void ParseArrayMember(ParseRecord pr) { }

	// RVA: 0x17C6FBC Offset: 0x17C2FBC VA: 0x17C6FBC
	private void ParseArrayMemberEnd(ParseRecord pr) { }

	// RVA: 0x17C57FC Offset: 0x17C17FC VA: 0x17C57FC
	private void ParseMember(ParseRecord pr) { }

	// RVA: 0x17C5CF4 Offset: 0x17C1CF4 VA: 0x17C5CF4
	private void ParseMemberEnd(ParseRecord pr) { }

	// RVA: 0x17C6F84 Offset: 0x17C2F84 VA: 0x17C6F84
	private void ParseString(ParseRecord pr, ParseRecord parentPr) { }

	// RVA: 0x17C6714 Offset: 0x17C2714 VA: 0x17C6714
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr) { }

	// RVA: 0x17C6FDC Offset: 0x17C2FDC VA: 0x17C6FDC
	private void RegisterObject(object obj, ParseRecord pr, ParseRecord objectPr, bool bIsString) { }

	// RVA: 0x17C70EC Offset: 0x17C30EC VA: 0x17C70EC
	internal long GetId(long objectId) { }

	// RVA: 0x17C71E0 Offset: 0x17C31E0 VA: 0x17C71E0
	internal Type Bind(string assemblyString, string typeString) { }

	// RVA: 0x17C7238 Offset: 0x17C3238 VA: 0x17C7238
	internal Type FastBindToType(string assemblyName, string typeName) { }

	// RVA: 0x17C7534 Offset: 0x17C3534 VA: 0x17C7534
	private static Assembly ResolveSimpleAssemblyName(AssemblyName assemblyName) { }

	// RVA: 0x17C7594 Offset: 0x17C3594 VA: 0x17C7594
	private static void GetSimplyNamedTypeFromAssembly(Assembly assm, string typeName, ref Type type) { }

	// RVA: 0x17B9438 Offset: 0x17B5438 VA: 0x17B9438
	internal Type GetType(BinaryAssemblyInfo assemblyInfo, string name) { }

	// RVA: 0x17C77F0 Offset: 0x17C37F0 VA: 0x17C77F0
	private static void CheckTypeForwardedTo(Assembly sourceAssembly, Assembly destAssembly, Type resolvedType) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ObjectWriter // TypeDefIndex: 1029
{
	// Fields
	private Queue m_objectQueue; // 0x10
	private ObjectIDGenerator m_idGenerator; // 0x18
	private int m_currentId; // 0x20
	private ISurrogateSelector m_surrogates; // 0x28
	private StreamingContext m_context; // 0x30
	private __BinaryWriter serWriter; // 0x40
	private SerializationObjectManager m_objectManager; // 0x48
	private long topId; // 0x50
	private string topName; // 0x58
	private Header[] headers; // 0x60
	private InternalFE formatterEnums; // 0x68
	private SerializationBinder m_binder; // 0x70
	private SerObjectInfoInit serObjectInfoInit; // 0x78
	private IFormatterConverter m_formatterConverter; // 0x80
	internal object[] crossAppDomainArray; // 0x88
	private object previousObj; // 0x90
	private long previousId; // 0x98
	private Type previousType; // 0xA0
	private InternalPrimitiveTypeE previousCode; // 0xA8
	private Hashtable assemblyToIdTable; // 0xB0
	private SerStack niPool; // 0xB8

	// Properties
	internal SerializationObjectManager ObjectManager { get; }

	// Methods

	// RVA: 0x17BFB1C Offset: 0x17BBB1C VA: 0x17BFB1C
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, InternalFE formatterEnums, SerializationBinder binder) { }

	// RVA: 0x17BFD30 Offset: 0x17BBD30 VA: 0x17BFD30
	internal void Serialize(object graph, Header[] inHeaders, __BinaryWriter serWriter, bool fCheck) { }

	// RVA: 0x17C8240 Offset: 0x17C4240 VA: 0x17C8240
	internal SerializationObjectManager get_ObjectManager() { }

	// RVA: 0x17C7D20 Offset: 0x17C3D20 VA: 0x17C7D20
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo) { }

	// RVA: 0x17C8980 Offset: 0x17C4980 VA: 0x17C8980
	private void Write(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string[] memberNames, Type[] memberTypes, object[] memberData, WriteObjectInfo[] memberObjectInfos) { }

	// RVA: 0x17C8C04 Offset: 0x17C4C04 VA: 0x17C8C04
	private void WriteMemberSetup(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, string memberName, Type memberType, object memberData, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x17C8D44 Offset: 0x17C4D44 VA: 0x17C8D44
	private void WriteMembers(NameInfo memberNameInfo, NameInfo memberTypeNameInfo, object memberData, WriteObjectInfo objectInfo, NameInfo typeNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x17C8248 Offset: 0x17C4248 VA: 0x17C8248
	private void WriteArray(WriteObjectInfo objectInfo, NameInfo memberNameInfo, WriteObjectInfo memberObjectInfo) { }

	// RVA: 0x17C934C Offset: 0x17C534C VA: 0x17C934C
	private void WriteArrayMember(WriteObjectInfo objectInfo, NameInfo arrayElemTypeNameInfo, object data) { }

	// RVA: 0x17C95EC Offset: 0x17C55EC VA: 0x17C95EC
	private void WriteRectangle(WriteObjectInfo objectInfo, int rank, int[] maxA, Array array, NameInfo arrayElemNameTypeInfo, int[] lowerBoundA) { }

	// RVA: 0x17C80D0 Offset: 0x17C40D0 VA: 0x17C80D0
	private object GetNext(out long objID) { }

	// RVA: 0x17C79EC Offset: 0x17C39EC VA: 0x17C79EC
	private long InternalGetId(object obj, bool assignUniqueIdToValueType, Type type, out bool isNew) { }

	// RVA: 0x17C9834 Offset: 0x17C5834 VA: 0x17C9834
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type) { }

	// RVA: 0x17C91C4 Offset: 0x17C51C4 VA: 0x17C91C4
	private long Schedule(object obj, bool assignUniqueIdToValueType, Type type, WriteObjectInfo objectInfo) { }

	// RVA: 0x17C9260 Offset: 0x17C5260 VA: 0x17C9260
	private bool WriteKnownValueClass(NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x17C924C Offset: 0x17C524C VA: 0x17C924C
	private void WriteObjectRef(NameInfo nameInfo, long objectId) { }

	// RVA: 0x17C983C Offset: 0x17C583C VA: 0x17C983C
	private void WriteString(NameInfo memberNameInfo, NameInfo typeNameInfo, object stringObject) { }

	// RVA: 0x17C907C Offset: 0x17C507C VA: 0x17C907C
	private bool CheckForNull(WriteObjectInfo objectInfo, NameInfo memberNameInfo, NameInfo typeNameInfo, object data) { }

	// RVA: 0x17C79D0 Offset: 0x17C39D0 VA: 0x17C79D0
	private void WriteSerializedStreamHeader(long topId, long headerId) { }

	// RVA: 0x17C9908 Offset: 0x17C5908 VA: 0x17C9908
	private NameInfo TypeToNameInfo(Type type, WriteObjectInfo objectInfo, InternalPrimitiveTypeE code, NameInfo nameInfo) { }

	// RVA: 0x17C8D10 Offset: 0x17C4D10 VA: 0x17C8D10
	private NameInfo TypeToNameInfo(Type type) { }

	// RVA: 0x17C7CDC Offset: 0x17C3CDC VA: 0x17C7CDC
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo) { }

	// RVA: 0x17C9174 Offset: 0x17C5174 VA: 0x17C9174
	private NameInfo TypeToNameInfo(WriteObjectInfo objectInfo, NameInfo nameInfo) { }

	// RVA: 0x17C913C Offset: 0x17C513C VA: 0x17C913C
	private void TypeToNameInfo(Type type, NameInfo nameInfo) { }

	// RVA: 0x17C8BCC Offset: 0x17C4BCC VA: 0x17C8BCC
	private NameInfo MemberToNameInfo(string name) { }

	// RVA: 0x17B856C Offset: 0x17B456C VA: 0x17B856C
	internal InternalPrimitiveTypeE ToCode(Type type) { }

	// RVA: 0x17C7ACC Offset: 0x17C3ACC VA: 0x17C7ACC
	private long GetAssemblyId(WriteObjectInfo objectInfo) { }

	// RVA: 0x17C8968 Offset: 0x17C4968 VA: 0x17C8968
	private Type GetType(object obj) { }

	// RVA: 0x17C99B0 Offset: 0x17C59B0 VA: 0x17C99B0
	private NameInfo GetNameInfo() { }

	// RVA: 0x17C895C Offset: 0x17C495C VA: 0x17C895C
	private bool CheckTypeFormat(FormatterTypeStyle test, FormatterTypeStyle want) { }

	// RVA: 0x17C80B8 Offset: 0x17C40B8 VA: 0x17C80B8
	private void PutNameInfo(NameInfo nameInfo) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class __BinaryParser // TypeDefIndex: 1030
{
	// Fields
	internal ObjectReader objectReader; // 0x10
	internal Stream input; // 0x18
	internal long topId; // 0x20
	internal long headerId; // 0x28
	internal SizedArray objectMapIdTable; // 0x30
	internal SizedArray assemIdToAssemblyTable; // 0x38
	internal SerStack stack; // 0x40
	internal BinaryTypeEnum expectedType; // 0x48
	internal object expectedTypeInformation; // 0x50
	internal ParseRecord PRS; // 0x58
	private BinaryAssemblyInfo systemAssemblyInfo; // 0x60
	private BinaryReader dataReader; // 0x68
	private static Encoding encoding; // 0x0
	private SerStack opPool; // 0x70
	private BinaryObject binaryObject; // 0x78
	private BinaryObjectWithMap bowm; // 0x80
	private BinaryObjectWithMapTyped bowmt; // 0x88
	internal BinaryObjectString objectString; // 0x90
	internal BinaryCrossAppDomainString crossAppDomainString; // 0x98
	internal MemberPrimitiveTyped memberPrimitiveTyped; // 0xA0
	private byte[] byteBuffer; // 0xA8
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; // 0xB0
	internal MemberReference memberReference; // 0xB8
	internal ObjectNull objectNull; // 0xC0
	internal static MessageEnd messageEnd; // 0x8

	// Properties
	internal BinaryAssemblyInfo SystemAssemblyInfo { get; }
	internal SizedArray ObjectMapIdTable { get; }
	internal SizedArray AssemIdToAssemblyTable { get; }
	internal ParseRecord prs { get; }

	// Methods

	// RVA: 0x17BF460 Offset: 0x17BB460 VA: 0x17BF460
	internal void .ctor(Stream stream, ObjectReader objectReader) { }

	// RVA: 0x17C9A68 Offset: 0x17C5A68 VA: 0x17C9A68
	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	// RVA: 0x17C9B14 Offset: 0x17C5B14 VA: 0x17C9B14
	internal SizedArray get_ObjectMapIdTable() { }

	// RVA: 0x17C9B84 Offset: 0x17C5B84 VA: 0x17C9B84
	internal SizedArray get_AssemIdToAssemblyTable() { }

	// RVA: 0x17C9BF8 Offset: 0x17C5BF8 VA: 0x17C9BF8
	internal ParseRecord get_prs() { }

	// RVA: 0x17C4808 Offset: 0x17C0808 VA: 0x17C4808
	internal void Run() { }

	// RVA: 0x17C9C68 Offset: 0x17C5C68 VA: 0x17C9C68
	internal void ReadBegin() { }

	// RVA: 0x17CB974 Offset: 0x17C7974 VA: 0x17CB974
	internal void ReadEnd() { }

	// RVA: 0x17CBC94 Offset: 0x17C7C94 VA: 0x17CBC94
	internal bool ReadBoolean() { }

	// RVA: 0x17B8DEC Offset: 0x17B4DEC VA: 0x17B8DEC
	internal byte ReadByte() { }

	// RVA: 0x17BA388 Offset: 0x17B6388 VA: 0x17BA388
	internal byte[] ReadBytes(int length) { }

	// RVA: 0x17CBCB0 Offset: 0x17C7CB0 VA: 0x17CBCB0
	internal void ReadBytes(byte[] byteA, int offset, int size) { }

	// RVA: 0x17CBD2C Offset: 0x17C7D2C VA: 0x17CBD2C
	internal char ReadChar() { }

	// RVA: 0x17CBD48 Offset: 0x17C7D48 VA: 0x17CBD48
	internal char[] ReadChars(int length) { }

	// RVA: 0x17CBD68 Offset: 0x17C7D68 VA: 0x17CBD68
	internal Decimal ReadDecimal() { }

	// RVA: 0x17CBE1C Offset: 0x17C7E1C VA: 0x17CBE1C
	internal float ReadSingle() { }

	// RVA: 0x17CBE3C Offset: 0x17C7E3C VA: 0x17CBE3C
	internal double ReadDouble() { }

	// RVA: 0x17CBE5C Offset: 0x17C7E5C VA: 0x17CBE5C
	internal short ReadInt16() { }

	// RVA: 0x17B8E28 Offset: 0x17B4E28 VA: 0x17B8E28
	internal int ReadInt32() { }

	// RVA: 0x17CBE7C Offset: 0x17C7E7C VA: 0x17CBE7C
	internal long ReadInt64() { }

	// RVA: 0x17CBE9C Offset: 0x17C7E9C VA: 0x17CBE9C
	internal sbyte ReadSByte() { }

	// RVA: 0x17B8E08 Offset: 0x17B4E08 VA: 0x17B8E08
	internal string ReadString() { }

	// RVA: 0x17CBEB8 Offset: 0x17C7EB8 VA: 0x17CBEB8
	internal TimeSpan ReadTimeSpan() { }

	// RVA: 0x17CBED8 Offset: 0x17C7ED8 VA: 0x17CBED8
	internal DateTime ReadDateTime() { }

	// RVA: 0x17CBF54 Offset: 0x17C7F54 VA: 0x17CBF54
	internal ushort ReadUInt16() { }

	// RVA: 0x17CBF74 Offset: 0x17C7F74 VA: 0x17CBF74
	internal uint ReadUInt32() { }

	// RVA: 0x17CBF94 Offset: 0x17C7F94 VA: 0x17CBF94
	internal ulong ReadUInt64() { }

	// RVA: 0x17C9C6C Offset: 0x17C5C6C VA: 0x17C9C6C
	internal void ReadSerializationHeaderRecord() { }

	// RVA: 0x17C9D28 Offset: 0x17C5D28 VA: 0x17C9D28
	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x17C9F98 Offset: 0x17C5F98 VA: 0x17C9F98
	private void ReadObject() { }

	// RVA: 0x17CA360 Offset: 0x17C6360 VA: 0x17CA360
	internal void ReadCrossAppDomainMap() { }

	// RVA: 0x17CA4FC Offset: 0x17C64FC VA: 0x17CA4FC
	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x17CC05C Offset: 0x17C805C VA: 0x17CC05C
	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	// RVA: 0x17CA5A4 Offset: 0x17C65A4 VA: 0x17CA5A4
	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x17CC4CC Offset: 0x17C84CC VA: 0x17CC4CC
	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	// RVA: 0x17CA648 Offset: 0x17C6648 VA: 0x17CA648
	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x17CB150 Offset: 0x17C7150 VA: 0x17CB150
	private void ReadMemberPrimitiveTyped() { }

	// RVA: 0x17CAB98 Offset: 0x17C6B98 VA: 0x17CAB98
	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x17CC968 Offset: 0x17C8968 VA: 0x17CC968
	private void ReadArrayAsBytes(ParseRecord pr) { }

	// RVA: 0x17CB978 Offset: 0x17C7978 VA: 0x17CB978
	private void ReadMemberPrimitiveUnTyped() { }

	// RVA: 0x17CB4AC Offset: 0x17C74AC VA: 0x17CB4AC
	private void ReadMemberReference() { }

	// RVA: 0x17CB65C Offset: 0x17C765C VA: 0x17CB65C
	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x17CB820 Offset: 0x17C7820 VA: 0x17CB820
	private void ReadMessageEnd() { }

	// RVA: 0x17BAB98 Offset: 0x17B6B98 VA: 0x17BAB98
	internal object ReadValue(InternalPrimitiveTypeE code) { }

	// RVA: 0x17CBFB4 Offset: 0x17C7FB4 VA: 0x17CBFB4
	private ObjectProgress GetOp() { }

	// RVA: 0x17CBBF8 Offset: 0x17C7BF8 VA: 0x17CBBF8
	private void PutOp(ObjectProgress op) { }

	// RVA: 0x17CCBEC Offset: 0x17C8BEC VA: 0x17CCBEC
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ParseRecord // TypeDefIndex: 1031
{
	// Fields
	internal static int parseRecordIdCount; // 0x0
	internal InternalParseTypeE PRparseTypeEnum; // 0x10
	internal InternalObjectTypeE PRobjectTypeEnum; // 0x14
	internal InternalArrayTypeE PRarrayTypeEnum; // 0x18
	internal InternalMemberTypeE PRmemberTypeEnum; // 0x1C
	internal InternalMemberValueE PRmemberValueEnum; // 0x20
	internal InternalObjectPositionE PRobjectPositionEnum; // 0x24
	internal string PRname; // 0x28
	internal string PRvalue; // 0x30
	internal object PRvarValue; // 0x38
	internal string PRkeyDt; // 0x40
	internal Type PRdtType; // 0x48
	internal InternalPrimitiveTypeE PRdtTypeCode; // 0x50
	internal bool PRisEnum; // 0x54
	internal long PRobjectId; // 0x58
	internal long PRidRef; // 0x60
	internal string PRarrayElementTypeString; // 0x68
	internal Type PRarrayElementType; // 0x70
	internal bool PRisArrayVariant; // 0x78
	internal InternalPrimitiveTypeE PRarrayElementTypeCode; // 0x7C
	internal int PRrank; // 0x80
	internal int[] PRlengthA; // 0x88
	internal int[] PRpositionA; // 0x90
	internal int[] PRlowerBoundA; // 0x98
	internal int[] PRupperBoundA; // 0xA0
	internal int[] PRindexMap; // 0xA8
	internal int PRmemberIndex; // 0xB0
	internal int PRlinearlength; // 0xB4
	internal int[] PRrectangularMap; // 0xB8
	internal bool PRisLowerBound; // 0xC0
	internal long PRtopId; // 0xC8
	internal long PRheaderId; // 0xD0
	internal ReadObjectInfo PRobjectInfo; // 0xD8
	internal bool PRisValueTypeFixup; // 0xE0
	internal object PRnewObj; // 0xE8
	internal object[] PRobjectA; // 0xF0
	internal PrimitiveArray PRprimitiveArray; // 0xF8
	internal bool PRisRegistered; // 0x100
	internal object[] PRmemberData; // 0x108
	internal SerializationInfo PRsi; // 0x110
	internal int PRnullCount; // 0x118

	// Methods

	// RVA: 0x17CCC70 Offset: 0x17C8C70 VA: 0x17CCC70
	internal void .ctor() { }

	// RVA: 0x17CCC78 Offset: 0x17C8C78 VA: 0x17CCC78
	internal void Init() { }

	// RVA: 0x17CCDD8 Offset: 0x17C8DD8 VA: 0x17CCDD8
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class SerStack // TypeDefIndex: 1032
{
	// Fields
	internal object[] objects; // 0x10
	internal string stackId; // 0x18
	internal int top; // 0x20

	// Methods

	// RVA: 0x17CCE24 Offset: 0x17C8E24 VA: 0x17CCE24
	internal void .ctor(string stackId) { }

	// RVA: 0x17CCEAC Offset: 0x17C8EAC VA: 0x17CCEAC
	internal void Push(object obj) { }

	// RVA: 0x17CCFEC Offset: 0x17C8FEC VA: 0x17CCFEC
	internal object Pop() { }

	// RVA: 0x17CCF5C Offset: 0x17C8F5C VA: 0x17CCF5C
	internal void IncreaseCapacity() { }

	// RVA: 0x17CD048 Offset: 0x17C9048 VA: 0x17CD048
	internal object Peek() { }

	// RVA: 0x17CD088 Offset: 0x17C9088 VA: 0x17CD088
	internal object PeekPeek() { }

	// RVA: 0x17CD0CC Offset: 0x17C90CC VA: 0x17CD0CC
	internal bool IsEmpty() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
[DefaultMember("Item")]
[Serializable]
internal sealed class SizedArray : ICloneable // TypeDefIndex: 1033
{
	// Fields
	internal object[] objects; // 0x10
	internal object[] negObjects; // 0x18

	// Properties
	internal object Item { get; set; }

	// Methods

	// RVA: 0x17CD0DC Offset: 0x17C90DC VA: 0x17CD0DC
	internal void .ctor() { }

	// RVA: 0x17CD15C Offset: 0x17C915C VA: 0x17CD15C
	internal void .ctor(int length) { }

	// RVA: 0x17CD1E8 Offset: 0x17C91E8 VA: 0x17CD1E8
	private void .ctor(SizedArray sizedArray) { }

	// RVA: 0x17CD2C0 Offset: 0x17C92C0 VA: 0x17CD2C0 Slot: 4
	public object Clone() { }

	// RVA: 0x17CD318 Offset: 0x17C9318 VA: 0x17CD318
	internal object get_Item(int index) { }

	// RVA: 0x17CD38C Offset: 0x17C938C VA: 0x17CD38C
	internal void set_Item(int index, object value) { }

	// RVA: 0x17CD49C Offset: 0x17C949C VA: 0x17CD49C
	internal void IncreaseCapacity(int index) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
[DefaultMember("Item")]
[Serializable]
internal sealed class IntSizedArray : ICloneable // TypeDefIndex: 1034
{
	// Fields
	internal int[] objects; // 0x10
	internal int[] negObjects; // 0x18

	// Properties
	internal int Item { get; set; }

	// Methods

	// RVA: 0x17CD6D8 Offset: 0x17C96D8 VA: 0x17CD6D8
	public void .ctor() { }

	// RVA: 0x17CD758 Offset: 0x17C9758 VA: 0x17CD758
	private void .ctor(IntSizedArray sizedArray) { }

	// RVA: 0x17CD86C Offset: 0x17C986C VA: 0x17CD86C Slot: 4
	public object Clone() { }

	// RVA: 0x17CD8C4 Offset: 0x17C98C4 VA: 0x17CD8C4
	internal int get_Item(int index) { }

	// RVA: 0x17CD93C Offset: 0x17C993C VA: 0x17CD93C
	internal void set_Item(int index, int value) { }

	// RVA: 0x17CD9F4 Offset: 0x17C99F4 VA: 0x17CD9F4
	internal void IncreaseCapacity(int index) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class NameCache // TypeDefIndex: 1035
{
	// Fields
	private static ConcurrentDictionary<string, object> ht; // 0x0
	private string name; // 0x10

	// Methods

	// RVA: 0x17CDC30 Offset: 0x17C9C30 VA: 0x17CDC30
	internal object GetCachedValue(string name) { }

	// RVA: 0x17CDCE4 Offset: 0x17C9CE4 VA: 0x17CDCE4
	internal void SetCachedValue(object value) { }

	// RVA: 0x17CDD74 Offset: 0x17C9D74 VA: 0x17CDD74
	public void .ctor() { }

	// RVA: 0x17CDD7C Offset: 0x17C9D7C VA: 0x17CDD7C
	private static void .cctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class ValueFixup // TypeDefIndex: 1036
{
	// Fields
	internal ValueFixupEnum valueFixupEnum; // 0x10
	internal Array arrayObj; // 0x18
	internal int[] indexMap; // 0x20
	internal object header; // 0x28
	internal object memberObject; // 0x30
	internal static MemberInfo valueInfo; // 0x0
	internal ReadObjectInfo objectInfo; // 0x38
	internal string memberName; // 0x40

	// Methods

	// RVA: 0x17CDE14 Offset: 0x17C9E14 VA: 0x17CDE14
	internal void .ctor(Array arrayObj, int[] indexMap) { }

	// RVA: 0x17CDE60 Offset: 0x17C9E60 VA: 0x17CDE60
	internal void .ctor(object memberObject, string memberName, ReadObjectInfo objectInfo) { }

	// RVA: 0x17CDEC8 Offset: 0x17C9EC8 VA: 0x17CDEC8
	internal void Fixup(ParseRecord record, ParseRecord parent) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class InternalFE // TypeDefIndex: 1037
{
	// Fields
	internal FormatterTypeStyle FEtypeFormat; // 0x10
	internal FormatterAssemblyStyle FEassemblyFormat; // 0x14
	internal TypeFilterLevel FEsecurityLevel; // 0x18
	internal InternalSerializerTypeE FEserializerTypeEnum; // 0x1C

	// Methods

	// RVA: 0x17CE500 Offset: 0x17CA500 VA: 0x17CE500
	public void .ctor() { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class NameInfo // TypeDefIndex: 1038
{
	// Fields
	internal string NIFullName; // 0x10
	internal long NIobjectId; // 0x18
	internal long NIassemId; // 0x20
	internal InternalPrimitiveTypeE NIprimitiveTypeEnum; // 0x28
	internal Type NItype; // 0x30
	internal bool NIisSealed; // 0x38
	internal bool NIisArray; // 0x39
	internal bool NIisArrayItem; // 0x3A
	internal bool NItransmitTypeOnObject; // 0x3B
	internal bool NItransmitTypeOnMember; // 0x3C
	internal bool NIisParentTypeOnObject; // 0x3D
	internal InternalArrayTypeE NIarrayEnum; // 0x40
	private bool NIsealedStatusChecked; // 0x44

	// Properties
	public bool IsSealed { get; }
	public string NIname { get; set; }

	// Methods

	// RVA: 0x17CE508 Offset: 0x17CA508 VA: 0x17CE508
	internal void .ctor() { }

	// RVA: 0x17CE510 Offset: 0x17CA510 VA: 0x17CE510
	internal void Init() { }

	// RVA: 0x17CE554 Offset: 0x17CA554 VA: 0x17CE554
	public bool get_IsSealed() { }

	// RVA: 0x17CE5A4 Offset: 0x17CA5A4 VA: 0x17CE5A4
	public string get_NIname() { }

	// RVA: 0x17CE5F0 Offset: 0x17CA5F0 VA: 0x17CE5F0
	public void set_NIname(string value) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class PrimitiveArray // TypeDefIndex: 1039
{
	// Fields
	private InternalPrimitiveTypeE code; // 0x10
	private bool[] booleanA; // 0x18
	private char[] charA; // 0x20
	private double[] doubleA; // 0x28
	private short[] int16A; // 0x30
	private int[] int32A; // 0x38
	private long[] int64A; // 0x40
	private sbyte[] sbyteA; // 0x48
	private float[] singleA; // 0x50
	private ushort[] uint16A; // 0x58
	private uint[] uint32A; // 0x60
	private ulong[] uint64A; // 0x68

	// Methods

	// RVA: 0x17CE5F8 Offset: 0x17CA5F8 VA: 0x17CE5F8
	internal void .ctor(InternalPrimitiveTypeE code, Array array) { }

	// RVA: 0x17CE62C Offset: 0x17CA62C VA: 0x17CE62C
	internal void Init(InternalPrimitiveTypeE code, Array array) { }

	// RVA: 0x17CE9F8 Offset: 0x17CA9F8 VA: 0x17CE9F8
	internal void SetValue(string value, int index) { }
}

// Namespace: System.Runtime.Serialization.Formatters.Binary
[Flags]
[Serializable]
internal enum MessageEnum // TypeDefIndex: 1040
{
	// Fields
	public int value__; // 0x0
	public const MessageEnum NoArgs = 1;
	public const MessageEnum ArgsInline = 2;
	public const MessageEnum ArgsIsArray = 4;
	public const MessageEnum ArgsInArray = 8;
	public const MessageEnum NoContext = 16;
	public const MessageEnum ContextInline = 32;
	public const MessageEnum ContextInArray = 64;
	public const MessageEnum MethodSignatureInArray = 128;
	public const MessageEnum PropertyInArray = 256;
	public const MessageEnum NoReturnValue = 512;
	public const MessageEnum ReturnValueVoid = 1024;
	public const MessageEnum ReturnValueInline = 2048;
	public const MessageEnum ReturnValueInArray = 4096;
	public const MessageEnum ExceptionInArray = 8192;
	public const MessageEnum GenericMethod = 32768;
}
