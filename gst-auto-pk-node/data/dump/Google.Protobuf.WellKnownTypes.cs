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

// Namespace: Google.Protobuf.WellKnownTypes
public static class AnyReflection // TypeDefIndex: 6355
{
	// Fields
	private static FileDescriptor descriptor; // 0x0

	// Properties
	public static FileDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x15E3ED4 Offset: 0x15DFED4 VA: 0x15E3ED4
	public static FileDescriptor get_Descriptor() { }

	// RVA: 0x15E3F2C Offset: 0x15DFF2C VA: 0x15E3F2C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Any.<>c // TypeDefIndex: 6356
{
	// Fields
	public static readonly Any.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15E509C Offset: 0x15E109C VA: 0x15E509C
	private static void .cctor() { }

	// RVA: 0x15E5104 Offset: 0x15E1104 VA: 0x15E5104
	public void .ctor() { }

	// RVA: 0x15E510C Offset: 0x15E110C VA: 0x15E510C
	internal Any <.cctor>b__41_0() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Any : IMessage<Any>, IMessage, IEquatable<Any>, IDeepCloneable<Any>, IBufferMessage // TypeDefIndex: 6357
{
	// Fields
	private static readonly MessageParser<Any> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private string typeUrl_; // 0x18
	private ByteString value_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Any> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TypeUrl { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString Value { get; set; }

	// Methods

	// RVA: 0x15E4338 Offset: 0x15E0338 VA: 0x15E4338
	public static MessageParser<Any> get_Parser() { }

	// RVA: 0x15D9594 Offset: 0x15D5594 VA: 0x15D9594
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15E4390 Offset: 0x15E0390 VA: 0x15E4390 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E43DC Offset: 0x15E03DC VA: 0x15E43DC
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E44A8 Offset: 0x15E04A8 VA: 0x15E44A8
	public void .ctor(Any other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E4504 Offset: 0x15E0504 VA: 0x15E4504 Slot: 10
	public Any Clone() { }

	// RVA: 0x15E455C Offset: 0x15E055C VA: 0x15E455C
	public string get_TypeUrl() { }

	// RVA: 0x15E4564 Offset: 0x15E0564 VA: 0x15E4564
	public void set_TypeUrl(string value) { }

	// RVA: 0x15E45E0 Offset: 0x15E05E0 VA: 0x15E45E0
	public ByteString get_Value() { }

	// RVA: 0x15E45E8 Offset: 0x15E05E8 VA: 0x15E45E8
	public void set_Value(ByteString value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E4664 Offset: 0x15E0664 VA: 0x15E4664 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E46C8 Offset: 0x15E06C8 VA: 0x15E46C8 Slot: 9
	public bool Equals(Any other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E4784 Offset: 0x15E0784 VA: 0x15E4784 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E480C Offset: 0x15E080C VA: 0x15E480C Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E4860 Offset: 0x15E0860 VA: 0x15E4860 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E487C Offset: 0x15E087C VA: 0x15E487C Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E4904 Offset: 0x15E0904 VA: 0x15E4904 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E49C4 Offset: 0x15E09C4 VA: 0x15E49C4 Slot: 4
	public void MergeFrom(Any other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E4A40 Offset: 0x15E0A40 VA: 0x15E4A40 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E4A5C Offset: 0x15E0A5C VA: 0x15E4A5C Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x15E4B6C Offset: 0x15E0B6C VA: 0x15E4B6C
	private static string GetTypeUrl(MessageDescriptor descriptor, string prefix) { }

	// RVA: 0x15DA618 Offset: 0x15D6618 VA: 0x15DA618
	public static string GetTypeName(string typeUrl) { }

	// RVA: 0x15E4BFC Offset: 0x15E0BFC VA: 0x15E4BFC
	public bool Is(MessageDescriptor descriptor) { }

	// RVA: -1 Offset: -1
	public T Unpack<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x101EB78 Offset: 0x101AB78 VA: 0x101EB78
	|-Any.Unpack<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool TryUnpack<T>(out T result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x101E910 Offset: 0x101A910 VA: 0x101E910
	|-Any.TryUnpack<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15E4CB4 Offset: 0x15E0CB4 VA: 0x15E4CB4
	public IMessage Unpack(TypeRegistry registry) { }

	// RVA: 0x15E4D78 Offset: 0x15E0D78 VA: 0x15E4D78
	public static Any Pack(IMessage message) { }

	// RVA: 0x15E4DE4 Offset: 0x15E0DE4 VA: 0x15E4DE4
	public static Any Pack(IMessage message, string typeUrlPrefix) { }

	// RVA: 0x15E4F84 Offset: 0x15E0F84 VA: 0x15E4F84
	private static void .cctor() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
public static class DurationReflection // TypeDefIndex: 6358
{
	// Fields
	private static FileDescriptor descriptor; // 0x0

	// Properties
	public static FileDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x15E515C Offset: 0x15E115C VA: 0x15E515C
	public static FileDescriptor get_Descriptor() { }

	// RVA: 0x15E51B4 Offset: 0x15E11B4 VA: 0x15E51B4
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Duration.<>c // TypeDefIndex: 6359
{
	// Fields
	public static readonly Duration.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15E65F0 Offset: 0x15E25F0 VA: 0x15E65F0
	private static void .cctor() { }

	// RVA: 0x15E6658 Offset: 0x15E2658 VA: 0x15E6658
	public void .ctor() { }

	// RVA: 0x15E6660 Offset: 0x15E2660 VA: 0x15E6660
	internal Duration <.cctor>b__49_0() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Duration : IMessage<Duration>, IMessage, IEquatable<Duration>, IDeepCloneable<Duration>, IBufferMessage, ICustomDiagnosticMessage, IComparable<Duration> // TypeDefIndex: 6360
{
	// Fields
	private static readonly MessageParser<Duration> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private long seconds_; // 0x18
	private int nanos_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Duration> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Seconds { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Nanos { get; set; }

	// Methods

	// RVA: 0x15E55F4 Offset: 0x15E15F4 VA: 0x15E55F4
	public static MessageParser<Duration> get_Parser() { }

	// RVA: 0x15D8264 Offset: 0x15D4264 VA: 0x15D8264
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15E564C Offset: 0x15E164C VA: 0x15E564C Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E5698 Offset: 0x15E1698 VA: 0x15E5698
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E56A0 Offset: 0x15E16A0 VA: 0x15E56A0
	public void .ctor(Duration other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E56EC Offset: 0x15E16EC VA: 0x15E56EC Slot: 10
	public Duration Clone() { }

	// RVA: 0x15E5744 Offset: 0x15E1744 VA: 0x15E5744
	public long get_Seconds() { }

	// RVA: 0x15E574C Offset: 0x15E174C VA: 0x15E574C
	public void set_Seconds(long value) { }

	// RVA: 0x15E5754 Offset: 0x15E1754 VA: 0x15E5754
	public int get_Nanos() { }

	// RVA: 0x15E575C Offset: 0x15E175C VA: 0x15E575C
	public void set_Nanos(int value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E5764 Offset: 0x15E1764 VA: 0x15E5764 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E57C8 Offset: 0x15E17C8 VA: 0x15E57C8 Slot: 9
	public bool Equals(Duration other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E5814 Offset: 0x15E1814 VA: 0x15E5814 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E5894 Offset: 0x15E1894 VA: 0x15E5894 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E58E8 Offset: 0x15E18E8 VA: 0x15E58E8 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E5904 Offset: 0x15E1904 VA: 0x15E5904 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E5978 Offset: 0x15E1978 VA: 0x15E5978 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E5A20 Offset: 0x15E1A20 VA: 0x15E5A20 Slot: 4
	public void MergeFrom(Duration other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E5A68 Offset: 0x15E1A68 VA: 0x15E5A68 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E5A84 Offset: 0x15E1A84 VA: 0x15E5A84 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x15E5BA8 Offset: 0x15E1BA8 VA: 0x15E5BA8
	internal static bool IsNormalized(long seconds, int nanoseconds) { }

	// RVA: 0x15E5C68 Offset: 0x15E1C68 VA: 0x15E5C68
	public TimeSpan ToTimeSpan() { }

	// RVA: 0x15E5DDC Offset: 0x15E1DDC VA: 0x15E5DDC
	public static Duration FromTimeSpan(TimeSpan timeSpan) { }

	// RVA: 0x15E5EA8 Offset: 0x15E1EA8 VA: 0x15E5EA8
	public static Duration op_UnaryNegation(Duration value) { }

	// RVA: 0x15E6060 Offset: 0x15E2060 VA: 0x15E6060
	public static Duration op_Addition(Duration lhs, Duration rhs) { }

	// RVA: 0x15E6194 Offset: 0x15E2194 VA: 0x15E6194
	public static Duration op_Subtraction(Duration lhs, Duration rhs) { }

	// RVA: 0x15E5F8C Offset: 0x15E1F8C VA: 0x15E5F8C
	internal static Duration Normalize(long seconds, int nanoseconds) { }

	// RVA: 0x15D9BFC Offset: 0x15D5BFC VA: 0x15D9BFC
	internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly) { }

	// RVA: 0x15E6434 Offset: 0x15E2434 VA: 0x15E6434 Slot: 13
	public string ToDiagnosticString() { }

	// RVA: 0x15E62C8 Offset: 0x15E22C8 VA: 0x15E62C8
	internal static void AppendNanoseconds(StringBuilder builder, int nanos) { }

	// RVA: 0x15E6498 Offset: 0x15E2498 VA: 0x15E6498 Slot: 14
	public int CompareTo(Duration other) { }

	// RVA: 0x15E64D8 Offset: 0x15E24D8 VA: 0x15E64D8
	private static void .cctor() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
public static class EmptyReflection // TypeDefIndex: 6361
{
	// Fields
	private static FileDescriptor descriptor; // 0x0

	// Properties
	public static FileDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x15E66B4 Offset: 0x15E26B4 VA: 0x15E66B4
	public static FileDescriptor get_Descriptor() { }

	// RVA: 0x15E670C Offset: 0x15E270C VA: 0x15E670C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Empty.<>c // TypeDefIndex: 6362
{
	// Fields
	public static readonly Empty.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15E7050 Offset: 0x15E3050 VA: 0x15E7050
	private static void .cctor() { }

	// RVA: 0x15E70B8 Offset: 0x15E30B8 VA: 0x15E70B8
	public void .ctor() { }

	// RVA: 0x15E70C0 Offset: 0x15E30C0 VA: 0x15E70C0
	internal Empty <.cctor>b__22_0() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Empty : IMessage<Empty>, IMessage, IEquatable<Empty>, IDeepCloneable<Empty>, IBufferMessage // TypeDefIndex: 6363
{
	// Fields
	private static readonly MessageParser<Empty> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Empty> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }

	// Methods

	// RVA: 0x15E6AA4 Offset: 0x15E2AA4 VA: 0x15E6AA4
	public static MessageParser<Empty> get_Parser() { }

	// RVA: 0x15E6AFC Offset: 0x15E2AFC VA: 0x15E6AFC
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15E6C00 Offset: 0x15E2C00 VA: 0x15E6C00 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E6C4C Offset: 0x15E2C4C VA: 0x15E6C4C
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E6C54 Offset: 0x15E2C54 VA: 0x15E6C54
	public void .ctor(Empty other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E6C94 Offset: 0x15E2C94 VA: 0x15E6C94 Slot: 10
	public Empty Clone() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E6CEC Offset: 0x15E2CEC VA: 0x15E6CEC Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E6D70 Offset: 0x15E2D70 VA: 0x15E6D70 Slot: 9
	public bool Equals(Empty other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E6D9C Offset: 0x15E2D9C VA: 0x15E6D9C Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E6DC8 Offset: 0x15E2DC8 VA: 0x15E6DC8 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E6E1C Offset: 0x15E2E1C VA: 0x15E6E1C Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E6E38 Offset: 0x15E2E38 VA: 0x15E6E38 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E6E48 Offset: 0x15E2E48 VA: 0x15E6E48 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E6E58 Offset: 0x15E2E58 VA: 0x15E6E58 Slot: 4
	public void MergeFrom(Empty other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E6E88 Offset: 0x15E2E88 VA: 0x15E6E88 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E6EA4 Offset: 0x15E2EA4 VA: 0x15E6EA4 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x15E6F38 Offset: 0x15E2F38 VA: 0x15E6F38
	private static void .cctor() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
public static class FieldMaskReflection // TypeDefIndex: 6364
{
	// Fields
	private static FileDescriptor descriptor; // 0x0

	// Properties
	public static FileDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x15E7114 Offset: 0x15E3114 VA: 0x15E7114
	public static FileDescriptor get_Descriptor() { }

	// RVA: 0x15E716C Offset: 0x15E316C VA: 0x15E716C
	private static void .cctor() { }
}

// Namespace: 
public sealed class FieldMask.MergeOptions // TypeDefIndex: 6365
{
	// Fields
	[CompilerGenerated]
	private bool <ReplaceMessageFields>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <ReplaceRepeatedFields>k__BackingField; // 0x11
	[CompilerGenerated]
	private bool <ReplacePrimitiveFields>k__BackingField; // 0x12

	// Properties
	public bool ReplaceMessageFields { get; }
	public bool ReplaceRepeatedFields { get; }
	public bool ReplacePrimitiveFields { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x15E876C Offset: 0x15E476C VA: 0x15E876C
	public bool get_ReplaceMessageFields() { }

	[CompilerGenerated]
	// RVA: 0x15E8774 Offset: 0x15E4774 VA: 0x15E8774
	public bool get_ReplaceRepeatedFields() { }

	[CompilerGenerated]
	// RVA: 0x15E877C Offset: 0x15E477C VA: 0x15E877C
	public bool get_ReplacePrimitiveFields() { }

	// RVA: 0x15E862C Offset: 0x15E462C VA: 0x15E862C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FieldMask.<>c // TypeDefIndex: 6366
{
	// Fields
	public static readonly FieldMask.<>c <>9; // 0x0
	public static Func<string, bool> <>9__29_0; // 0x8

	// Methods

	// RVA: 0x15E8784 Offset: 0x15E4784 VA: 0x15E8784
	private static void .cctor() { }

	// RVA: 0x15E87EC Offset: 0x15E47EC VA: 0x15E87EC
	public void .ctor() { }

	// RVA: 0x15E87F4 Offset: 0x15E47F4 VA: 0x15E87F4
	internal bool <ToJson>b__29_0(string p) { }

	// RVA: 0x15E8854 Offset: 0x15E4854 VA: 0x15E8854
	internal FieldMask <.cctor>b__47_0() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FieldMask : IMessage<FieldMask>, IMessage, IEquatable<FieldMask>, IDeepCloneable<FieldMask>, IBufferMessage, ICustomDiagnosticMessage // TypeDefIndex: 6367
{
	// Fields
	private static readonly MessageParser<FieldMask> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private static readonly FieldCodec<string> _repeated_paths_codec; // 0x8
	private readonly RepeatedField<string> paths_; // 0x18

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldMask> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> Paths { get; }

	// Methods

	// RVA: 0x15E7544 Offset: 0x15E3544 VA: 0x15E7544
	public static MessageParser<FieldMask> get_Parser() { }

	// RVA: 0x15D864C Offset: 0x15D464C VA: 0x15D864C
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15E759C Offset: 0x15E359C VA: 0x15E759C Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15D16E4 Offset: 0x15CD6E4 VA: 0x15D16E4
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E75E8 Offset: 0x15E35E8 VA: 0x15E75E8
	public void .ctor(FieldMask other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E7670 Offset: 0x15E3670 VA: 0x15E7670 Slot: 10
	public FieldMask Clone() { }

	// RVA: 0x15E76C8 Offset: 0x15E36C8 VA: 0x15E76C8
	public RepeatedField<string> get_Paths() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E76D0 Offset: 0x15E36D0 VA: 0x15E76D0 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E7734 Offset: 0x15E3734 VA: 0x15E7734 Slot: 9
	public bool Equals(FieldMask other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E77C4 Offset: 0x15E37C4 VA: 0x15E77C4 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E7810 Offset: 0x15E3810 VA: 0x15E7810 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E7864 Offset: 0x15E3864 VA: 0x15E7864 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E7880 Offset: 0x15E3880 VA: 0x15E7880 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E7934 Offset: 0x15E3934 VA: 0x15E7934 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E79D8 Offset: 0x15E39D8 VA: 0x15E79D8 Slot: 4
	public void MergeFrom(FieldMask other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E7A5C Offset: 0x15E3A5C VA: 0x15E7A5C Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E7A78 Offset: 0x15E3A78 VA: 0x15E7A78 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x15D9E7C Offset: 0x15D5E7C VA: 0x15D9E7C
	internal static string ToJson(IList<string> paths, bool diagnosticOnly) { }

	// RVA: 0x15E7B9C Offset: 0x15E3B9C VA: 0x15E7B9C Slot: 13
	public string ToDiagnosticString() { }

	// RVA: 0x15E7BF8 Offset: 0x15E3BF8 VA: 0x15E7BF8
	public static FieldMask FromString(string value) { }

	// RVA: -1 Offset: -1
	public static FieldMask FromString<T>(string value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113B50 Offset: 0x110FB50 VA: 0x1113B50
	|-FieldMask.FromString<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static FieldMask FromStringEnumerable<T>(IEnumerable<string> paths) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113C50 Offset: 0x110FC50 VA: 0x1113C50
	|-FieldMask.FromStringEnumerable<object>
	|
	|-RVA: 0x11140E4 Offset: 0x11100E4 VA: 0x11140E4
	|-FieldMask.FromStringEnumerable<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static FieldMask FromFieldNumbers<T>(int[] fieldNumbers) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113AE8 Offset: 0x110FAE8 VA: 0x1113AE8
	|-FieldMask.FromFieldNumbers<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static FieldMask FromFieldNumbers<T>(IEnumerable<int> fieldNumbers) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1113588 Offset: 0x110F588 VA: 0x1113588
	|-FieldMask.FromFieldNumbers<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15E7D04 Offset: 0x15E3D04 VA: 0x15E7D04
	private static bool IsPathValid(string input) { }

	// RVA: -1 Offset: -1
	public static bool IsValid<T>(FieldMask fieldMask) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114670 Offset: 0x1110670 VA: 0x1114670
	|-FieldMask.IsValid<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15E7DB0 Offset: 0x15E3DB0 VA: 0x15E7DB0
	public static bool IsValid(MessageDescriptor descriptor, FieldMask fieldMask) { }

	// RVA: -1 Offset: -1
	public static bool IsValid<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111457C Offset: 0x111057C VA: 0x111457C
	|-FieldMask.IsValid<object>
	|
	|-RVA: 0x11147F8 Offset: 0x11107F8 VA: 0x11147F8
	|-FieldMask.IsValid<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15E804C Offset: 0x15E404C VA: 0x15E804C
	public static bool IsValid(MessageDescriptor descriptor, string path) { }

	// RVA: 0x15E8168 Offset: 0x15E4168 VA: 0x15E8168
	public FieldMask Normalize() { }

	// RVA: 0x15E81C8 Offset: 0x15E41C8 VA: 0x15E81C8
	public FieldMask Union(FieldMask[] otherMasks) { }

	// RVA: 0x15E827C Offset: 0x15E427C VA: 0x15E827C
	public FieldMask Intersection(FieldMask additionalMask) { }

	// RVA: 0x15E8530 Offset: 0x15E4530 VA: 0x15E8530
	public void Merge(IMessage source, IMessage destination, FieldMask.MergeOptions options) { }

	// RVA: 0x15E85B8 Offset: 0x15E45B8 VA: 0x15E85B8
	public void Merge(IMessage source, IMessage destination) { }

	// RVA: 0x15E8634 Offset: 0x15E4634 VA: 0x15E8634
	private static void .cctor() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
public static class SourceContextReflection // TypeDefIndex: 6368
{
	// Fields
	private static FileDescriptor descriptor; // 0x0

	// Properties
	public static FileDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x15E88A4 Offset: 0x15E48A4 VA: 0x15E88A4
	public static FileDescriptor get_Descriptor() { }

	// RVA: 0x15E88FC Offset: 0x15E48FC VA: 0x15E88FC
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SourceContext.<>c // TypeDefIndex: 6369
{
	// Fields
	public static readonly SourceContext.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15E94FC Offset: 0x15E54FC VA: 0x15E94FC
	private static void .cctor() { }

	// RVA: 0x15E9564 Offset: 0x15E5564 VA: 0x15E9564
	public void .ctor() { }

	// RVA: 0x15E956C Offset: 0x15E556C VA: 0x15E956C
	internal SourceContext <.cctor>b__27_0() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SourceContext : IMessage<SourceContext>, IMessage, IEquatable<SourceContext>, IDeepCloneable<SourceContext>, IBufferMessage // TypeDefIndex: 6370
{
	// Fields
	private static readonly MessageParser<SourceContext> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private string fileName_; // 0x18

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SourceContext> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string FileName { get; set; }

	// Methods

	// RVA: 0x15E8D08 Offset: 0x15E4D08 VA: 0x15E8D08
	public static MessageParser<SourceContext> get_Parser() { }

	// RVA: 0x15E8D60 Offset: 0x15E4D60 VA: 0x15E8D60
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15E8E64 Offset: 0x15E4E64 VA: 0x15E8E64 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E8EB0 Offset: 0x15E4EB0 VA: 0x15E8EB0
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E8F08 Offset: 0x15E4F08 VA: 0x15E8F08
	public void .ctor(SourceContext other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E8F54 Offset: 0x15E4F54 VA: 0x15E8F54 Slot: 10
	public SourceContext Clone() { }

	// RVA: 0x15E8FAC Offset: 0x15E4FAC VA: 0x15E8FAC
	public string get_FileName() { }

	// RVA: 0x15E8FB4 Offset: 0x15E4FB4 VA: 0x15E8FB4
	public void set_FileName(string value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E9030 Offset: 0x15E5030 VA: 0x15E9030 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E9094 Offset: 0x15E5094 VA: 0x15E9094 Slot: 9
	public bool Equals(SourceContext other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E90F4 Offset: 0x15E50F4 VA: 0x15E90F4 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E9154 Offset: 0x15E5154 VA: 0x15E9154 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E91A8 Offset: 0x15E51A8 VA: 0x15E91A8 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E91C4 Offset: 0x15E51C4 VA: 0x15E91C4 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E9224 Offset: 0x15E5224 VA: 0x15E9224 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E92B0 Offset: 0x15E52B0 VA: 0x15E92B0 Slot: 4
	public void MergeFrom(SourceContext other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E9310 Offset: 0x15E5310 VA: 0x15E9310 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15E932C Offset: 0x15E532C VA: 0x15E932C Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x15E93E4 Offset: 0x15E53E4 VA: 0x15E93E4
	private static void .cctor() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
public static class StructReflection // TypeDefIndex: 6371
{
	// Fields
	private static FileDescriptor descriptor; // 0x0

	// Properties
	public static FileDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x15E95BC Offset: 0x15E55BC VA: 0x15E95BC
	public static FileDescriptor get_Descriptor() { }

	// RVA: 0x15E9614 Offset: 0x15E5614 VA: 0x15E9614
	private static void .cctor() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
public enum NullValue // TypeDefIndex: 6372
{
	// Fields
	public int value__; // 0x0
	[OriginalName("NULL_VALUE")]
	public const NullValue NullValue = 0;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Struct.<>c // TypeDefIndex: 6373
{
	// Fields
	public static readonly Struct.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15EA914 Offset: 0x15E6914 VA: 0x15EA914
	private static void .cctor() { }

	// RVA: 0x15EA97C Offset: 0x15E697C VA: 0x15EA97C
	public void .ctor() { }

	// RVA: 0x15EA984 Offset: 0x15E6984 VA: 0x15EA984
	internal Struct <.cctor>b__27_0() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Struct : IMessage<Struct>, IMessage, IEquatable<Struct>, IDeepCloneable<Struct>, IBufferMessage // TypeDefIndex: 6374
{
	// Fields
	private static readonly MessageParser<Struct> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private static readonly MapField.Codec<string, Value> _map_fields_codec; // 0x8
	private readonly MapField<string, Value> fields_; // 0x18

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Struct> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MapField<string, Value> Fields { get; }

	// Methods

	// RVA: 0x15EA008 Offset: 0x15E6008 VA: 0x15EA008
	public static MessageParser<Struct> get_Parser() { }

	// RVA: 0x15D8934 Offset: 0x15D4934 VA: 0x15D8934
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15EA060 Offset: 0x15E6060 VA: 0x15EA060 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EA0AC Offset: 0x15E60AC VA: 0x15EA0AC
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EA134 Offset: 0x15E6134 VA: 0x15EA134
	public void .ctor(Struct other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EA1BC Offset: 0x15E61BC VA: 0x15EA1BC Slot: 10
	public Struct Clone() { }

	// RVA: 0x15EA214 Offset: 0x15E6214 VA: 0x15EA214
	public MapField<string, Value> get_Fields() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EA21C Offset: 0x15E621C VA: 0x15EA21C Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EA280 Offset: 0x15E6280 VA: 0x15EA280 Slot: 9
	public bool Equals(Struct other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EA310 Offset: 0x15E6310 VA: 0x15EA310 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EA35C Offset: 0x15E635C VA: 0x15EA35C Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EA3B0 Offset: 0x15E63B0 VA: 0x15EA3B0 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EA3CC Offset: 0x15E63CC VA: 0x15EA3CC Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EA480 Offset: 0x15E6480 VA: 0x15EA480 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EA524 Offset: 0x15E6524 VA: 0x15EA524 Slot: 4
	public void MergeFrom(Struct other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EA5A8 Offset: 0x15E65A8 VA: 0x15EA5A8 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EA5C4 Offset: 0x15E65C4 VA: 0x15EA5C4 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x15EA6E8 Offset: 0x15E66E8 VA: 0x15EA6E8
	private static void .cctor() { }
}

// Namespace: 
public enum Value.KindOneofCase // TypeDefIndex: 6375
{
	// Fields
	public int value__; // 0x0
	public const Value.KindOneofCase None = 0;
	public const Value.KindOneofCase NullValue = 1;
	public const Value.KindOneofCase NumberValue = 2;
	public const Value.KindOneofCase StringValue = 3;
	public const Value.KindOneofCase BoolValue = 4;
	public const Value.KindOneofCase StructValue = 5;
	public const Value.KindOneofCase ListValue = 6;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Value.<>c // TypeDefIndex: 6376
{
	// Fields
	public static readonly Value.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15ECB34 Offset: 0x15E8B34 VA: 0x15ECB34
	private static void .cctor() { }

	// RVA: 0x15ECB9C Offset: 0x15E8B9C VA: 0x15ECB9C
	public void .ctor() { }

	// RVA: 0x15ECBA4 Offset: 0x15E8BA4 VA: 0x15ECBA4
	internal Value <.cctor>b__70_0() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Value : IMessage<Value>, IMessage, IEquatable<Value>, IDeepCloneable<Value>, IBufferMessage // TypeDefIndex: 6377
{
	// Fields
	private static readonly MessageParser<Value> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private object kind_; // 0x18
	private Value.KindOneofCase kindCase_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Value> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public NullValue NullValue { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasNullValue { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double NumberValue { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasNumberValue { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string StringValue { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasStringValue { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool BoolValue { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasBoolValue { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Struct StructValue { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ListValue ListValue { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Value.KindOneofCase KindCase { get; }

	// Methods

	// RVA: 0x15EA9D4 Offset: 0x15E69D4 VA: 0x15EA9D4
	public static MessageParser<Value> get_Parser() { }

	// RVA: 0x15D9058 Offset: 0x15D5058 VA: 0x15D9058
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15EAA2C Offset: 0x15E6A2C VA: 0x15EAA2C Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EAA78 Offset: 0x15E6A78 VA: 0x15EAA78
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EAA80 Offset: 0x15E6A80 VA: 0x15EAA80
	public void .ctor(Value other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EB0B0 Offset: 0x15E70B0 VA: 0x15EB0B0 Slot: 10
	public Value Clone() { }

	// RVA: 0x15EAC30 Offset: 0x15E6C30 VA: 0x15EAC30
	public NullValue get_NullValue() { }

	// RVA: 0x15EACB4 Offset: 0x15E6CB4 VA: 0x15EACB4
	public void set_NullValue(NullValue value) { }

	// RVA: 0x15EB108 Offset: 0x15E7108 VA: 0x15EB108
	public bool get_HasNullValue() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EB118 Offset: 0x15E7118 VA: 0x15EB118
	public void ClearNullValue() { }

	// RVA: 0x15EAD28 Offset: 0x15E6D28 VA: 0x15EAD28
	public double get_NumberValue() { }

	// RVA: 0x15EAD7C Offset: 0x15E6D7C VA: 0x15EAD7C
	public void set_NumberValue(double value) { }

	// RVA: 0x15EB148 Offset: 0x15E7148 VA: 0x15EB148
	public bool get_HasNumberValue() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EB158 Offset: 0x15E7158 VA: 0x15EB158
	public void ClearNumberValue() { }

	// RVA: 0x15EADC4 Offset: 0x15E6DC4 VA: 0x15EADC4
	public string get_StringValue() { }

	// RVA: 0x15EAE38 Offset: 0x15E6E38 VA: 0x15EAE38
	public void set_StringValue(string value) { }

	// RVA: 0x15EB178 Offset: 0x15E7178 VA: 0x15EB178
	public bool get_HasStringValue() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EB188 Offset: 0x15E7188 VA: 0x15EB188
	public void ClearStringValue() { }

	// RVA: 0x15EAEC0 Offset: 0x15E6EC0 VA: 0x15EAEC0
	public bool get_BoolValue() { }

	// RVA: 0x15EAF20 Offset: 0x15E6F20 VA: 0x15EAF20
	public void set_BoolValue(bool value) { }

	// RVA: 0x15EB1A8 Offset: 0x15E71A8 VA: 0x15EB1A8
	public bool get_HasBoolValue() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EB1B8 Offset: 0x15E71B8 VA: 0x15EB1B8
	public void ClearBoolValue() { }

	// RVA: 0x15EAF68 Offset: 0x15E6F68 VA: 0x15EAF68
	public Struct get_StructValue() { }

	// RVA: 0x15EAFD4 Offset: 0x15E6FD4 VA: 0x15EAFD4
	public void set_StructValue(Struct value) { }

	// RVA: 0x15EB00C Offset: 0x15E700C VA: 0x15EB00C
	public ListValue get_ListValue() { }

	// RVA: 0x15EB078 Offset: 0x15E7078 VA: 0x15EB078
	public void set_ListValue(ListValue value) { }

	// RVA: 0x15EB1D8 Offset: 0x15E71D8 VA: 0x15EB1D8
	public Value.KindOneofCase get_KindCase() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EB138 Offset: 0x15E7138 VA: 0x15EB138
	public void ClearKind() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EB1E0 Offset: 0x15E71E0 VA: 0x15EB1E0 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EB244 Offset: 0x15E7244 VA: 0x15EB244 Slot: 9
	public bool Equals(Value other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EB414 Offset: 0x15E7414 VA: 0x15EB414 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EB5F4 Offset: 0x15E75F4 VA: 0x15EB5F4 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EB648 Offset: 0x15E7648 VA: 0x15EB648 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EB664 Offset: 0x15E7664 VA: 0x15EB664 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EB7A4 Offset: 0x15E77A4 VA: 0x15EB7A4 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EB914 Offset: 0x15E7914 VA: 0x15EB914 Slot: 4
	public void MergeFrom(Value other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EBB60 Offset: 0x15E7B60 VA: 0x15EBB60 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EBB7C Offset: 0x15E7B7C VA: 0x15EBB7C Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x15EBF10 Offset: 0x15E7F10 VA: 0x15EBF10
	public static Value ForString(string value) { }

	// RVA: 0x15EBFBC Offset: 0x15E7FBC VA: 0x15EBFBC
	public static Value ForNumber(double value) { }

	// RVA: 0x15EC05C Offset: 0x15E805C VA: 0x15EC05C
	public static Value ForBool(bool value) { }

	// RVA: 0x15EC0F8 Offset: 0x15E80F8 VA: 0x15EC0F8
	public static Value ForNull() { }

	// RVA: 0x15EC160 Offset: 0x15E8160 VA: 0x15EC160
	public static Value ForList(Value[] values) { }

	// RVA: 0x15EC274 Offset: 0x15E8274 VA: 0x15EC274
	public static Value ForStruct(Struct value) { }

	// RVA: 0x15EC334 Offset: 0x15E8334 VA: 0x15EC334
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ListValue.<>c // TypeDefIndex: 6378
{
	// Fields
	public static readonly ListValue.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15ED5B0 Offset: 0x15E95B0 VA: 0x15ED5B0
	private static void .cctor() { }

	// RVA: 0x15ED618 Offset: 0x15E9618 VA: 0x15ED618
	public void .ctor() { }

	// RVA: 0x15ED620 Offset: 0x15E9620 VA: 0x15ED620
	internal ListValue <.cctor>b__27_0() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ListValue : IMessage<ListValue>, IMessage, IEquatable<ListValue>, IDeepCloneable<ListValue>, IBufferMessage // TypeDefIndex: 6379
{
	// Fields
	private static readonly MessageParser<ListValue> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private static readonly FieldCodec<Value> _repeated_values_codec; // 0x8
	private readonly RepeatedField<Value> values_; // 0x18

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ListValue> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Value> Values { get; }

	// Methods

	// RVA: 0x15ECBF8 Offset: 0x15E8BF8 VA: 0x15ECBF8
	public static MessageParser<ListValue> get_Parser() { }

	// RVA: 0x15ECC50 Offset: 0x15E8C50 VA: 0x15ECC50
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15ECD54 Offset: 0x15E8D54 VA: 0x15ECD54 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15ECDA0 Offset: 0x15E8DA0 VA: 0x15ECDA0
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15ECE28 Offset: 0x15E8E28 VA: 0x15ECE28
	public void .ctor(ListValue other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15ECEB4 Offset: 0x15E8EB4 VA: 0x15ECEB4 Slot: 10
	public ListValue Clone() { }

	// RVA: 0x15ECF0C Offset: 0x15E8F0C VA: 0x15ECF0C
	public RepeatedField<Value> get_Values() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15ECF14 Offset: 0x15E8F14 VA: 0x15ECF14 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15ECF78 Offset: 0x15E8F78 VA: 0x15ECF78 Slot: 9
	public bool Equals(ListValue other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15ED008 Offset: 0x15E9008 VA: 0x15ED008 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15ED054 Offset: 0x15E9054 VA: 0x15ED054 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15ED0AC Offset: 0x15E90AC VA: 0x15ED0AC Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15ED0CC Offset: 0x15E90CC VA: 0x15ED0CC Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15ED184 Offset: 0x15E9184 VA: 0x15ED184 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15ED22C Offset: 0x15E922C VA: 0x15ED22C Slot: 4
	public void MergeFrom(ListValue other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15ED2B4 Offset: 0x15E92B4 VA: 0x15ED2B4 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15ED2D4 Offset: 0x15E92D4 VA: 0x15ED2D4 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x15ED400 Offset: 0x15E9400 VA: 0x15ED400
	private static void .cctor() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
public static class TimestampReflection // TypeDefIndex: 6380
{
	// Fields
	private static FileDescriptor descriptor; // 0x0

	// Properties
	public static FileDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x15ED670 Offset: 0x15E9670 VA: 0x15ED670
	public static FileDescriptor get_Descriptor() { }

	// RVA: 0x15ED6C8 Offset: 0x15E96C8 VA: 0x15ED6C8
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Timestamp.<>c // TypeDefIndex: 6381
{
	// Fields
	public static readonly Timestamp.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15EF194 Offset: 0x15EB194 VA: 0x15EF194
	private static void .cctor() { }

	// RVA: 0x15EF1FC Offset: 0x15EB1FC VA: 0x15EF1FC
	public void .ctor() { }

	// RVA: 0x15EF204 Offset: 0x15EB204 VA: 0x15EF204
	internal Timestamp <.cctor>b__55_0() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Timestamp : IMessage<Timestamp>, IMessage, IEquatable<Timestamp>, IDeepCloneable<Timestamp>, IBufferMessage, ICustomDiagnosticMessage, IComparable<Timestamp> // TypeDefIndex: 6382
{
	// Fields
	private static readonly MessageParser<Timestamp> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private long seconds_; // 0x18
	private int nanos_; // 0x20
	private static readonly DateTime UnixEpoch; // 0x8

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Timestamp> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Seconds { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Nanos { get; set; }

	// Methods

	// RVA: 0x15EDB08 Offset: 0x15E9B08 VA: 0x15EDB08
	public static MessageParser<Timestamp> get_Parser() { }

	// RVA: 0x15EDB60 Offset: 0x15E9B60 VA: 0x15EDB60
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15EDC64 Offset: 0x15E9C64 VA: 0x15EDC64 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EDCB0 Offset: 0x15E9CB0 VA: 0x15EDCB0
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EDCB8 Offset: 0x15E9CB8 VA: 0x15EDCB8
	public void .ctor(Timestamp other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EDD08 Offset: 0x15E9D08 VA: 0x15EDD08 Slot: 10
	public Timestamp Clone() { }

	// RVA: 0x15EDD60 Offset: 0x15E9D60 VA: 0x15EDD60
	public long get_Seconds() { }

	// RVA: 0x15EDD68 Offset: 0x15E9D68 VA: 0x15EDD68
	public void set_Seconds(long value) { }

	// RVA: 0x15EDD70 Offset: 0x15E9D70 VA: 0x15EDD70
	public int get_Nanos() { }

	// RVA: 0x15EDD78 Offset: 0x15E9D78 VA: 0x15EDD78
	public void set_Nanos(int value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EDD80 Offset: 0x15E9D80 VA: 0x15EDD80 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EDDE4 Offset: 0x15E9DE4 VA: 0x15EDDE4 Slot: 9
	public bool Equals(Timestamp other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EDE30 Offset: 0x15E9E30 VA: 0x15EDE30 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EDEB0 Offset: 0x15E9EB0 VA: 0x15EDEB0 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EDF08 Offset: 0x15E9F08 VA: 0x15EDF08 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EDF28 Offset: 0x15E9F28 VA: 0x15EDF28 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EDFB0 Offset: 0x15E9FB0 VA: 0x15EDFB0 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EE064 Offset: 0x15EA064 VA: 0x15EE064 Slot: 4
	public void MergeFrom(Timestamp other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EE130 Offset: 0x15EA130 VA: 0x15EE130 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15EE150 Offset: 0x15EA150 VA: 0x15EE150 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x15EE284 Offset: 0x15EA284 VA: 0x15EE284
	private static bool IsNormalized(long seconds, int nanoseconds) { }

	// RVA: 0x15EE2B8 Offset: 0x15EA2B8 VA: 0x15EE2B8
	public static Duration op_Subtraction(Timestamp lhs, Timestamp rhs) { }

	// RVA: 0x15EE3F0 Offset: 0x15EA3F0 VA: 0x15EE3F0
	public static Timestamp op_Addition(Timestamp lhs, Duration rhs) { }

	// RVA: 0x15EE5F0 Offset: 0x15EA5F0 VA: 0x15EE5F0
	public static Timestamp op_Subtraction(Timestamp lhs, Duration rhs) { }

	// RVA: 0x15EE738 Offset: 0x15EA738 VA: 0x15EE738
	public DateTime ToDateTime() { }

	// RVA: 0x15EE8A0 Offset: 0x15EA8A0 VA: 0x15EE8A0
	public DateTimeOffset ToDateTimeOffset() { }

	// RVA: 0x15EE92C Offset: 0x15EA92C VA: 0x15EE92C
	public static Timestamp FromDateTime(DateTime dateTime) { }

	// RVA: 0x15EEABC Offset: 0x15EAABC VA: 0x15EEABC
	public static Timestamp FromDateTimeOffset(DateTimeOffset dateTimeOffset) { }

	// RVA: 0x15EE538 Offset: 0x15EA538 VA: 0x15EE538
	internal static Timestamp Normalize(long seconds, int nanoseconds) { }

	// RVA: 0x15EEB54 Offset: 0x15EAB54 VA: 0x15EEB54
	internal static string ToJson(long seconds, int nanoseconds, bool diagnosticOnly) { }

	// RVA: 0x15EEE28 Offset: 0x15EAE28 VA: 0x15EEE28 Slot: 14
	public int CompareTo(Timestamp other) { }

	// RVA: 0x15EEEC8 Offset: 0x15EAEC8 VA: 0x15EEEC8
	public static bool op_LessThan(Timestamp a, Timestamp b) { }

	// RVA: 0x15EEEE4 Offset: 0x15EAEE4 VA: 0x15EEEE4
	public static bool op_GreaterThan(Timestamp a, Timestamp b) { }

	// RVA: 0x15EEF04 Offset: 0x15EAF04 VA: 0x15EEF04
	public static bool op_LessThanOrEqual(Timestamp a, Timestamp b) { }

	// RVA: 0x15EEF24 Offset: 0x15EAF24 VA: 0x15EEF24
	public static bool op_GreaterThanOrEqual(Timestamp a, Timestamp b) { }

	// RVA: 0x15EE10C Offset: 0x15EA10C VA: 0x15EE10C
	public static bool op_Equality(Timestamp a, Timestamp b) { }

	// RVA: 0x15EEF44 Offset: 0x15EAF44 VA: 0x15EEF44
	public static bool op_Inequality(Timestamp a, Timestamp b) { }

	// RVA: 0x15EEFD4 Offset: 0x15EAFD4 VA: 0x15EEFD4 Slot: 13
	public string ToDiagnosticString() { }

	// RVA: 0x15EF038 Offset: 0x15EB038 VA: 0x15EF038
	private static void .cctor() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
public static class TypeReflection // TypeDefIndex: 6383
{
	// Fields
	private static FileDescriptor descriptor; // 0x0

	// Properties
	public static FileDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x15EF258 Offset: 0x15EB258 VA: 0x15EF258
	public static FileDescriptor get_Descriptor() { }

	// RVA: 0x15EF2B0 Offset: 0x15EB2B0 VA: 0x15EF2B0
	private static void .cctor() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
public enum Syntax // TypeDefIndex: 6384
{
	// Fields
	public int value__; // 0x0
	[OriginalName("SYNTAX_PROTO2")]
	public const Syntax Proto2 = 0;
	[OriginalName("SYNTAX_PROTO3")]
	public const Syntax Proto3 = 1;
	[OriginalName("SYNTAX_EDITIONS")]
	public const Syntax Editions = 2;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Type.<>c // TypeDefIndex: 6385
{
	// Fields
	public static readonly Type.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15F1B94 Offset: 0x15EDB94 VA: 0x15F1B94
	private static void .cctor() { }

	// RVA: 0x15F1BFC Offset: 0x15EDBFC VA: 0x15F1BFC
	public void .ctor() { }

	// RVA: 0x15F1C04 Offset: 0x15EDC04 VA: 0x15F1C04
	internal Type <.cctor>b__57_0() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Type : IMessage<Type>, IMessage, IEquatable<Type>, IDeepCloneable<Type>, IBufferMessage // TypeDefIndex: 6386
{
	// Fields
	private static readonly MessageParser<Type> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private string name_; // 0x18
	private static readonly FieldCodec<Field> _repeated_fields_codec; // 0x8
	private readonly RepeatedField<Field> fields_; // 0x20
	private static readonly FieldCodec<string> _repeated_oneofs_codec; // 0x10
	private readonly RepeatedField<string> oneofs_; // 0x28
	private static readonly FieldCodec<Option> _repeated_options_codec; // 0x18
	private readonly RepeatedField<Option> options_; // 0x30
	private SourceContext sourceContext_; // 0x38
	private Syntax syntax_; // 0x40
	private string edition_; // 0x48

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Type> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Field> Fields { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> Oneofs { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Option> Options { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SourceContext SourceContext { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Syntax Syntax { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Edition { get; set; }

	// Methods

	// RVA: 0x15F07A8 Offset: 0x15EC7A8 VA: 0x15F07A8
	public static MessageParser<Type> get_Parser() { }

	// RVA: 0x15F0800 Offset: 0x15EC800 VA: 0x15F0800
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15F0904 Offset: 0x15EC904 VA: 0x15F0904 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F0950 Offset: 0x15EC950 VA: 0x15F0950
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F0AB4 Offset: 0x15ECAB4 VA: 0x15F0AB4
	public void .ctor(Type other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F0BF8 Offset: 0x15ECBF8 VA: 0x15F0BF8 Slot: 10
	public Type Clone() { }

	// RVA: 0x15F0C50 Offset: 0x15ECC50 VA: 0x15F0C50
	public string get_Name() { }

	// RVA: 0x15F0C58 Offset: 0x15ECC58 VA: 0x15F0C58
	public void set_Name(string value) { }

	// RVA: 0x15F0CD4 Offset: 0x15ECCD4 VA: 0x15F0CD4
	public RepeatedField<Field> get_Fields() { }

	// RVA: 0x15F0CDC Offset: 0x15ECCDC VA: 0x15F0CDC
	public RepeatedField<string> get_Oneofs() { }

	// RVA: 0x15F0CE4 Offset: 0x15ECCE4 VA: 0x15F0CE4
	public RepeatedField<Option> get_Options() { }

	// RVA: 0x15F0CEC Offset: 0x15ECCEC VA: 0x15F0CEC
	public SourceContext get_SourceContext() { }

	// RVA: 0x15F0CF4 Offset: 0x15ECCF4 VA: 0x15F0CF4
	public void set_SourceContext(SourceContext value) { }

	// RVA: 0x15F0CFC Offset: 0x15ECCFC VA: 0x15F0CFC
	public Syntax get_Syntax() { }

	// RVA: 0x15F0D04 Offset: 0x15ECD04 VA: 0x15F0D04
	public void set_Syntax(Syntax value) { }

	// RVA: 0x15F0D0C Offset: 0x15ECD0C VA: 0x15F0D0C
	public string get_Edition() { }

	// RVA: 0x15F0D14 Offset: 0x15ECD14 VA: 0x15F0D14
	public void set_Edition(string value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F0D90 Offset: 0x15ECD90 VA: 0x15F0D90 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F0DF4 Offset: 0x15ECDF4 VA: 0x15F0DF4 Slot: 9
	public bool Equals(Type other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F0F28 Offset: 0x15ECF28 VA: 0x15F0F28 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F1044 Offset: 0x15ED044 VA: 0x15F1044 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F109C Offset: 0x15ED09C VA: 0x15F109C Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F10BC Offset: 0x15ED0BC VA: 0x15F10BC Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F128C Offset: 0x15ED28C VA: 0x15F128C Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F1490 Offset: 0x15ED490 VA: 0x15F1490 Slot: 4
	public void MergeFrom(Type other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F1610 Offset: 0x15ED610 VA: 0x15F1610 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F1630 Offset: 0x15ED630 VA: 0x15F1630 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x15F1928 Offset: 0x15ED928 VA: 0x15F1928
	private static void .cctor() { }
}

// Namespace: 
public enum Field.Types.Kind // TypeDefIndex: 6387
{
	// Fields
	public int value__; // 0x0
	[OriginalName("TYPE_UNKNOWN")]
	public const Field.Types.Kind TypeUnknown = 0;
	[OriginalName("TYPE_DOUBLE")]
	public const Field.Types.Kind TypeDouble = 1;
	[OriginalName("TYPE_FLOAT")]
	public const Field.Types.Kind TypeFloat = 2;
	[OriginalName("TYPE_INT64")]
	public const Field.Types.Kind TypeInt64 = 3;
	[OriginalName("TYPE_UINT64")]
	public const Field.Types.Kind TypeUint64 = 4;
	[OriginalName("TYPE_INT32")]
	public const Field.Types.Kind TypeInt32 = 5;
	[OriginalName("TYPE_FIXED64")]
	public const Field.Types.Kind TypeFixed64 = 6;
	[OriginalName("TYPE_FIXED32")]
	public const Field.Types.Kind TypeFixed32 = 7;
	[OriginalName("TYPE_BOOL")]
	public const Field.Types.Kind TypeBool = 8;
	[OriginalName("TYPE_STRING")]
	public const Field.Types.Kind TypeString = 9;
	[OriginalName("TYPE_GROUP")]
	public const Field.Types.Kind TypeGroup = 10;
	[OriginalName("TYPE_MESSAGE")]
	public const Field.Types.Kind TypeMessage = 11;
	[OriginalName("TYPE_BYTES")]
	public const Field.Types.Kind TypeBytes = 12;
	[OriginalName("TYPE_UINT32")]
	public const Field.Types.Kind TypeUint32 = 13;
	[OriginalName("TYPE_ENUM")]
	public const Field.Types.Kind TypeEnum = 14;
	[OriginalName("TYPE_SFIXED32")]
	public const Field.Types.Kind TypeSfixed32 = 15;
	[OriginalName("TYPE_SFIXED64")]
	public const Field.Types.Kind TypeSfixed64 = 16;
	[OriginalName("TYPE_SINT32")]
	public const Field.Types.Kind TypeSint32 = 17;
	[OriginalName("TYPE_SINT64")]
	public const Field.Types.Kind TypeSint64 = 18;
}

// Namespace: 
public enum Field.Types.Cardinality // TypeDefIndex: 6388
{
	// Fields
	public int value__; // 0x0
	[OriginalName("CARDINALITY_UNKNOWN")]
	public const Field.Types.Cardinality Unknown = 0;
	[OriginalName("CARDINALITY_OPTIONAL")]
	public const Field.Types.Cardinality Optional = 1;
	[OriginalName("CARDINALITY_REQUIRED")]
	public const Field.Types.Cardinality Required = 2;
	[OriginalName("CARDINALITY_REPEATED")]
	public const Field.Types.Cardinality Repeated = 3;
}

// Namespace: 
[DebuggerNonUserCode]
[GeneratedCode("protoc", null)]
public static class Field.Types // TypeDefIndex: 6389
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Field.<>c // TypeDefIndex: 6390
{
	// Fields
	public static readonly Field.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15F3110 Offset: 0x15EF110 VA: 0x15F3110
	private static void .cctor() { }

	// RVA: 0x15F3178 Offset: 0x15EF178 VA: 0x15F3178
	public void .ctor() { }

	// RVA: 0x15F3180 Offset: 0x15EF180 VA: 0x15F3180
	internal Field <.cctor>b__73_0() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Field : IMessage<Field>, IMessage, IEquatable<Field>, IDeepCloneable<Field>, IBufferMessage // TypeDefIndex: 6391
{
	// Fields
	private static readonly MessageParser<Field> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private Field.Types.Kind kind_; // 0x18
	private Field.Types.Cardinality cardinality_; // 0x1C
	private int number_; // 0x20
	private string name_; // 0x28
	private string typeUrl_; // 0x30
	private int oneofIndex_; // 0x38
	private bool packed_; // 0x3C
	private static readonly FieldCodec<Option> _repeated_options_codec; // 0x8
	private readonly RepeatedField<Option> options_; // 0x40
	private string jsonName_; // 0x48
	private string defaultValue_; // 0x50

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Field> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Field.Types.Kind Kind { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Field.Types.Cardinality Cardinality { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Number { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TypeUrl { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OneofIndex { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Packed { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Option> Options { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string JsonName { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DefaultValue { get; set; }

	// Methods

	// RVA: 0x15F1C54 Offset: 0x15EDC54 VA: 0x15F1C54
	public static MessageParser<Field> get_Parser() { }

	// RVA: 0x15F1CAC Offset: 0x15EDCAC VA: 0x15F1CAC
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15F1DB0 Offset: 0x15EDDB0 VA: 0x15F1DB0 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F1DFC Offset: 0x15EDDFC VA: 0x15F1DFC
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F1ED8 Offset: 0x15EDED8 VA: 0x15F1ED8
	public void .ctor(Field other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F1FC8 Offset: 0x15EDFC8 VA: 0x15F1FC8 Slot: 10
	public Field Clone() { }

	// RVA: 0x15F2020 Offset: 0x15EE020 VA: 0x15F2020
	public Field.Types.Kind get_Kind() { }

	// RVA: 0x15F2028 Offset: 0x15EE028 VA: 0x15F2028
	public void set_Kind(Field.Types.Kind value) { }

	// RVA: 0x15F2030 Offset: 0x15EE030 VA: 0x15F2030
	public Field.Types.Cardinality get_Cardinality() { }

	// RVA: 0x15F2038 Offset: 0x15EE038 VA: 0x15F2038
	public void set_Cardinality(Field.Types.Cardinality value) { }

	// RVA: 0x15F2040 Offset: 0x15EE040 VA: 0x15F2040
	public int get_Number() { }

	// RVA: 0x15F2048 Offset: 0x15EE048 VA: 0x15F2048
	public void set_Number(int value) { }

	// RVA: 0x15F2050 Offset: 0x15EE050 VA: 0x15F2050
	public string get_Name() { }

	// RVA: 0x15F2058 Offset: 0x15EE058 VA: 0x15F2058
	public void set_Name(string value) { }

	// RVA: 0x15F20D4 Offset: 0x15EE0D4 VA: 0x15F20D4
	public string get_TypeUrl() { }

	// RVA: 0x15F20DC Offset: 0x15EE0DC VA: 0x15F20DC
	public void set_TypeUrl(string value) { }

	// RVA: 0x15F2158 Offset: 0x15EE158 VA: 0x15F2158
	public int get_OneofIndex() { }

	// RVA: 0x15F2160 Offset: 0x15EE160 VA: 0x15F2160
	public void set_OneofIndex(int value) { }

	// RVA: 0x15F2168 Offset: 0x15EE168 VA: 0x15F2168
	public bool get_Packed() { }

	// RVA: 0x15F2170 Offset: 0x15EE170 VA: 0x15F2170
	public void set_Packed(bool value) { }

	// RVA: 0x15F2178 Offset: 0x15EE178 VA: 0x15F2178
	public RepeatedField<Option> get_Options() { }

	// RVA: 0x15F2180 Offset: 0x15EE180 VA: 0x15F2180
	public string get_JsonName() { }

	// RVA: 0x15F2188 Offset: 0x15EE188 VA: 0x15F2188
	public void set_JsonName(string value) { }

	// RVA: 0x15F2204 Offset: 0x15EE204 VA: 0x15F2204
	public string get_DefaultValue() { }

	// RVA: 0x15F220C Offset: 0x15EE20C VA: 0x15F220C
	public void set_DefaultValue(string value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F2288 Offset: 0x15EE288 VA: 0x15F2288 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F22EC Offset: 0x15EE2EC VA: 0x15F22EC Slot: 9
	public bool Equals(Field other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F242C Offset: 0x15EE42C VA: 0x15F242C Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F25C0 Offset: 0x15EE5C0 VA: 0x15F25C0 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F2618 Offset: 0x15EE618 VA: 0x15F2618 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F2638 Offset: 0x15EE638 VA: 0x15F2638 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F2878 Offset: 0x15EE878 VA: 0x15F2878 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F2AD4 Offset: 0x15EEAD4 VA: 0x15F2AD4 Slot: 4
	public void MergeFrom(Field other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F2BFC Offset: 0x15EEBFC VA: 0x15F2BFC Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F2C1C Offset: 0x15EEC1C VA: 0x15F2C1C Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x15F2F60 Offset: 0x15EEF60 VA: 0x15F2F60
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Enum.<>c // TypeDefIndex: 6392
{
	// Fields
	public static readonly Enum.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15F43B8 Offset: 0x15F03B8 VA: 0x15F43B8
	private static void .cctor() { }

	// RVA: 0x15F4420 Offset: 0x15F0420 VA: 0x15F4420
	public void .ctor() { }

	// RVA: 0x15F4428 Offset: 0x15F0428 VA: 0x15F4428
	internal Enum <.cctor>b__52_0() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Enum : IMessage<Enum>, IMessage, IEquatable<Enum>, IDeepCloneable<Enum>, IBufferMessage // TypeDefIndex: 6393
{
	// Fields
	private static readonly MessageParser<Enum> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private string name_; // 0x18
	private static readonly FieldCodec<EnumValue> _repeated_enumvalue_codec; // 0x8
	private readonly RepeatedField<EnumValue> enumvalue_; // 0x20
	private static readonly FieldCodec<Option> _repeated_options_codec; // 0x10
	private readonly RepeatedField<Option> options_; // 0x28
	private SourceContext sourceContext_; // 0x30
	private Syntax syntax_; // 0x38
	private string edition_; // 0x40

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Enum> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EnumValue> Enumvalue { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Option> Options { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SourceContext SourceContext { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Syntax Syntax { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Edition { get; set; }

	// Methods

	// RVA: 0x15F31D0 Offset: 0x15EF1D0 VA: 0x15F31D0
	public static MessageParser<Enum> get_Parser() { }

	// RVA: 0x15F3228 Offset: 0x15EF228 VA: 0x15F3228
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15F332C Offset: 0x15EF32C VA: 0x15F332C Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F3378 Offset: 0x15EF378 VA: 0x15F3378
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F3488 Offset: 0x15EF488 VA: 0x15F3488
	public void .ctor(Enum other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F3598 Offset: 0x15EF598 VA: 0x15F3598 Slot: 10
	public Enum Clone() { }

	// RVA: 0x15F35F0 Offset: 0x15EF5F0 VA: 0x15F35F0
	public string get_Name() { }

	// RVA: 0x15F35F8 Offset: 0x15EF5F8 VA: 0x15F35F8
	public void set_Name(string value) { }

	// RVA: 0x15F3674 Offset: 0x15EF674 VA: 0x15F3674
	public RepeatedField<EnumValue> get_Enumvalue() { }

	// RVA: 0x15F367C Offset: 0x15EF67C VA: 0x15F367C
	public RepeatedField<Option> get_Options() { }

	// RVA: 0x15F3684 Offset: 0x15EF684 VA: 0x15F3684
	public SourceContext get_SourceContext() { }

	// RVA: 0x15F368C Offset: 0x15EF68C VA: 0x15F368C
	public void set_SourceContext(SourceContext value) { }

	// RVA: 0x15F3694 Offset: 0x15EF694 VA: 0x15F3694
	public Syntax get_Syntax() { }

	// RVA: 0x15F369C Offset: 0x15EF69C VA: 0x15F369C
	public void set_Syntax(Syntax value) { }

	// RVA: 0x15F36A4 Offset: 0x15EF6A4 VA: 0x15F36A4
	public string get_Edition() { }

	// RVA: 0x15F36AC Offset: 0x15EF6AC VA: 0x15F36AC
	public void set_Edition(string value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F3728 Offset: 0x15EF728 VA: 0x15F3728 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F378C Offset: 0x15EF78C VA: 0x15F378C Slot: 9
	public bool Equals(Enum other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F3894 Offset: 0x15EF894 VA: 0x15F3894 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F3984 Offset: 0x15EF984 VA: 0x15F3984 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F39DC Offset: 0x15EF9DC VA: 0x15F39DC Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F39FC Offset: 0x15EF9FC VA: 0x15F39FC Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F3B98 Offset: 0x15EFB98 VA: 0x15F3B98 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F3D54 Offset: 0x15EFD54 VA: 0x15F3D54 Slot: 4
	public void MergeFrom(Enum other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F3EAC Offset: 0x15EFEAC VA: 0x15F3EAC Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F3ECC Offset: 0x15EFECC VA: 0x15F3ECC Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x15F4170 Offset: 0x15F0170 VA: 0x15F4170
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EnumValue.<>c // TypeDefIndex: 6394
{
	// Fields
	public static readonly EnumValue.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15F50E0 Offset: 0x15F10E0 VA: 0x15F50E0
	private static void .cctor() { }

	// RVA: 0x15F5148 Offset: 0x15F1148 VA: 0x15F5148
	public void .ctor() { }

	// RVA: 0x15F5150 Offset: 0x15F1150 VA: 0x15F5150
	internal EnumValue <.cctor>b__37_0() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnumValue : IMessage<EnumValue>, IMessage, IEquatable<EnumValue>, IDeepCloneable<EnumValue>, IBufferMessage // TypeDefIndex: 6395
{
	// Fields
	private static readonly MessageParser<EnumValue> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private string name_; // 0x18
	private int number_; // 0x20
	private static readonly FieldCodec<Option> _repeated_options_codec; // 0x8
	private readonly RepeatedField<Option> options_; // 0x28

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnumValue> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Number { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Option> Options { get; }

	// Methods

	// RVA: 0x15F4478 Offset: 0x15F0478 VA: 0x15F4478
	public static MessageParser<EnumValue> get_Parser() { }

	// RVA: 0x15F44D0 Offset: 0x15F04D0 VA: 0x15F44D0
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15F45D4 Offset: 0x15F05D4 VA: 0x15F45D4 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F4620 Offset: 0x15F0620 VA: 0x15F4620
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F46CC Offset: 0x15F06CC VA: 0x15F46CC
	public void .ctor(EnumValue other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F4774 Offset: 0x15F0774 VA: 0x15F4774 Slot: 10
	public EnumValue Clone() { }

	// RVA: 0x15F47CC Offset: 0x15F07CC VA: 0x15F47CC
	public string get_Name() { }

	// RVA: 0x15F47D4 Offset: 0x15F07D4 VA: 0x15F47D4
	public void set_Name(string value) { }

	// RVA: 0x15F4850 Offset: 0x15F0850 VA: 0x15F4850
	public int get_Number() { }

	// RVA: 0x15F4858 Offset: 0x15F0858 VA: 0x15F4858
	public void set_Number(int value) { }

	// RVA: 0x15F4860 Offset: 0x15F0860 VA: 0x15F4860
	public RepeatedField<Option> get_Options() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F4868 Offset: 0x15F0868 VA: 0x15F4868 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F48CC Offset: 0x15F08CC VA: 0x15F48CC Slot: 9
	public bool Equals(EnumValue other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F4980 Offset: 0x15F0980 VA: 0x15F4980 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F4A1C Offset: 0x15F0A1C VA: 0x15F4A1C Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F4A74 Offset: 0x15F0A74 VA: 0x15F4A74 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F4A94 Offset: 0x15F0A94 VA: 0x15F4A94 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F4BA4 Offset: 0x15F0BA4 VA: 0x15F4BA4 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F4CCC Offset: 0x15F0CCC VA: 0x15F4CCC Slot: 4
	public void MergeFrom(EnumValue other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F4D78 Offset: 0x15F0D78 VA: 0x15F4D78 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F4D98 Offset: 0x15F0D98 VA: 0x15F4D98 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x15F4F30 Offset: 0x15F0F30 VA: 0x15F4F30
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Option.<>c // TypeDefIndex: 6396
{
	// Fields
	public static readonly Option.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15F5BB8 Offset: 0x15F1BB8 VA: 0x15F5BB8
	private static void .cctor() { }

	// RVA: 0x15F5C20 Offset: 0x15F1C20 VA: 0x15F5C20
	public void .ctor() { }

	// RVA: 0x15F5C28 Offset: 0x15F1C28 VA: 0x15F5C28
	internal Option <.cctor>b__32_0() { }
}

// Namespace: Google.Protobuf.WellKnownTypes
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Option : IMessage<Option>, IMessage, IEquatable<Option>, IDeepCloneable<Option>, IBufferMessage // TypeDefIndex: 6397
{
	// Fields
	private static readonly MessageParser<Option> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private string name_; // 0x18
	private Any value_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Option> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Any Value { get; set; }

	// Methods

	// RVA: 0x15F51A0 Offset: 0x15F11A0 VA: 0x15F51A0
	public static MessageParser<Option> get_Parser() { }

	// RVA: 0x15F51F8 Offset: 0x15F11F8 VA: 0x15F51F8
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15F52FC Offset: 0x15F12FC VA: 0x15F52FC Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F5348 Offset: 0x15F1348 VA: 0x15F5348
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F53A0 Offset: 0x15F13A0 VA: 0x15F53A0
	public void .ctor(Option other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F5418 Offset: 0x15F1418 VA: 0x15F5418 Slot: 10
	public Option Clone() { }

	// RVA: 0x15F5470 Offset: 0x15F1470 VA: 0x15F5470
	public string get_Name() { }

	// RVA: 0x15F5478 Offset: 0x15F1478 VA: 0x15F5478
	public void set_Name(string value) { }

	// RVA: 0x15F54F4 Offset: 0x15F14F4 VA: 0x15F54F4
	public Any get_Value() { }

	// RVA: 0x15F54FC Offset: 0x15F14FC VA: 0x15F54FC
	public void set_Value(Any value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F5504 Offset: 0x15F1504 VA: 0x15F5504 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F5568 Offset: 0x15F1568 VA: 0x15F5568 Slot: 9
	public bool Equals(Option other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F55DC Offset: 0x15F15DC VA: 0x15F55DC Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F5654 Offset: 0x15F1654 VA: 0x15F5654 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F56AC Offset: 0x15F16AC VA: 0x15F56AC Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F56CC Offset: 0x15F16CC VA: 0x15F56CC Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F5760 Offset: 0x15F1760 VA: 0x15F5760 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F5828 Offset: 0x15F1828 VA: 0x15F5828 Slot: 4
	public void MergeFrom(Option other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F590C Offset: 0x15F190C VA: 0x15F590C Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15F592C Offset: 0x15F192C VA: 0x15F592C Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x15F5AA0 Offset: 0x15F1AA0 VA: 0x15F5AA0
	private static void .cctor() { }
}
