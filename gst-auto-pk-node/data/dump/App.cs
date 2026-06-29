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

// Namespace: App
public static class MasterserverReflection // TypeDefIndex: 5098
{
	// Fields
	private static FileDescriptor descriptor; // 0x0

	// Properties
	public static FileDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x16CEE0C Offset: 0x16CAE0C VA: 0x16CEE0C
	public static FileDescriptor get_Descriptor() { }

	// RVA: 0x16CEE64 Offset: 0x16CAE64 VA: 0x16CEE64
	private static void .cctor() { }
}

// Namespace: App
public enum MSCode // TypeDefIndex: 5099
{
	// Fields
	public int value__; // 0x0
	[OriginalName("Unidentified")]
	public const MSCode Unidentified = 0;
	[OriginalName("StringData")]
	public const MSCode StringData = 9;
	[OriginalName("Passcode")]
	public const MSCode Passcode = 23;
	[OriginalName("UnityRegisterRequest")]
	public const MSCode UnityRegisterRequest = 1;
	[OriginalName("UnityRegisterResponse")]
	public const MSCode UnityRegisterResponse = 2;
	[OriginalName("UnityLoginRequest")]
	public const MSCode UnityLoginRequest = 3;
	[OriginalName("UnityLoginResponse")]
	public const MSCode UnityLoginResponse = 4;
	[OriginalName("UnityCreateCharacterRequest")]
	public const MSCode UnityCreateCharacterRequest = 5;
	[OriginalName("UnityCreateCharacterResponse")]
	public const MSCode UnityCreateCharacterResponse = 6;
	[OriginalName("UnityEntergameRequest")]
	public const MSCode UnityEntergameRequest = 7;
	[OriginalName("UnityEntergameResponse")]
	public const MSCode UnityEntergameResponse = 8;
	[OriginalName("UnityRegisterFields")]
	public const MSCode UnityRegisterFields = 61;
	[OriginalName("UnityLoginQueueStart")]
	public const MSCode UnityLoginQueueStart = 71;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MSUnityLoginQueueStart.<>c // TypeDefIndex: 5100
{
	// Fields
	public static readonly MSUnityLoginQueueStart.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16D0B14 Offset: 0x16CCB14 VA: 0x16D0B14
	private static void .cctor() { }

	// RVA: 0x16D0B7C Offset: 0x16CCB7C VA: 0x16D0B7C
	public void .ctor() { }

	// RVA: 0x16D0B84 Offset: 0x16CCB84 VA: 0x16D0B84
	internal MSUnityLoginQueueStart <.cctor>b__27_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MSUnityLoginQueueStart : IMessage<MSUnityLoginQueueStart>, IMessage, IEquatable<MSUnityLoginQueueStart>, IDeepCloneable<MSUnityLoginQueueStart>, IBufferMessage // TypeDefIndex: 5101
{
	// Fields
	private static readonly MessageParser<MSUnityLoginQueueStart> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int orderNumber_; // 0x18

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MSUnityLoginQueueStart> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OrderNumber { get; set; }

	// Methods

	// RVA: 0x16D03F8 Offset: 0x16CC3F8 VA: 0x16D03F8
	public static MessageParser<MSUnityLoginQueueStart> get_Parser() { }

	// RVA: 0x16D0450 Offset: 0x16CC450 VA: 0x16D0450
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16D0554 Offset: 0x16CC554 VA: 0x16D0554 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D05A0 Offset: 0x16CC5A0 VA: 0x16D05A0
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D05A8 Offset: 0x16CC5A8 VA: 0x16D05A8
	public void .ctor(MSUnityLoginQueueStart other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D05F4 Offset: 0x16CC5F4 VA: 0x16D05F4 Slot: 10
	public MSUnityLoginQueueStart Clone() { }

	// RVA: 0x16D064C Offset: 0x16CC64C VA: 0x16D064C
	public int get_OrderNumber() { }

	// RVA: 0x16D0654 Offset: 0x16CC654 VA: 0x16D0654
	public void set_OrderNumber(int value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D065C Offset: 0x16CC65C VA: 0x16D065C Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D06C0 Offset: 0x16CC6C0 VA: 0x16D06C0 Slot: 9
	public bool Equals(MSUnityLoginQueueStart other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D06FC Offset: 0x16CC6FC VA: 0x16D06FC Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D0758 Offset: 0x16CC758 VA: 0x16D0758 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D07B0 Offset: 0x16CC7B0 VA: 0x16D07B0 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D07D0 Offset: 0x16CC7D0 VA: 0x16D07D0 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D0830 Offset: 0x16CC830 VA: 0x16D0830 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D08B0 Offset: 0x16CC8B0 VA: 0x16D08B0 Slot: 4
	public void MergeFrom(MSUnityLoginQueueStart other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D08F0 Offset: 0x16CC8F0 VA: 0x16D08F0 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D0910 Offset: 0x16CC910 VA: 0x16D0910 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16D09FC Offset: 0x16CC9FC VA: 0x16D09FC
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MSUnityRegisterRequest.<>c // TypeDefIndex: 5102
{
	// Fields
	public static readonly MSUnityRegisterRequest.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16D157C Offset: 0x16CD57C VA: 0x16D157C
	private static void .cctor() { }

	// RVA: 0x16D15E4 Offset: 0x16CD5E4 VA: 0x16D15E4
	public void .ctor() { }

	// RVA: 0x16D15EC Offset: 0x16CD5EC VA: 0x16D15EC
	internal MSUnityRegisterRequest <.cctor>b__32_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MSUnityRegisterRequest : IMessage<MSUnityRegisterRequest>, IMessage, IEquatable<MSUnityRegisterRequest>, IDeepCloneable<MSUnityRegisterRequest>, IBufferMessage // TypeDefIndex: 5103
{
	// Fields
	private static readonly MessageParser<MSUnityRegisterRequest> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private string account_; // 0x18
	private string password_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MSUnityRegisterRequest> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Account { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Password { get; set; }

	// Methods

	// RVA: 0x16D0BD8 Offset: 0x16CCBD8 VA: 0x16D0BD8
	public static MessageParser<MSUnityRegisterRequest> get_Parser() { }

	// RVA: 0x16D0C30 Offset: 0x16CCC30 VA: 0x16D0C30
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16D0D34 Offset: 0x16CCD34 VA: 0x16D0D34 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D0D80 Offset: 0x16CCD80 VA: 0x16D0D80
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D0DE8 Offset: 0x16CCDE8 VA: 0x16D0DE8
	public void .ctor(MSUnityRegisterRequest other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D0E48 Offset: 0x16CCE48 VA: 0x16D0E48 Slot: 10
	public MSUnityRegisterRequest Clone() { }

	// RVA: 0x16D0EA0 Offset: 0x16CCEA0 VA: 0x16D0EA0
	public string get_Account() { }

	// RVA: 0x16D0EA8 Offset: 0x16CCEA8 VA: 0x16D0EA8
	public void set_Account(string value) { }

	// RVA: 0x16D0F24 Offset: 0x16CCF24 VA: 0x16D0F24
	public string get_Password() { }

	// RVA: 0x16D0F2C Offset: 0x16CCF2C VA: 0x16D0F2C
	public void set_Password(string value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D0FA8 Offset: 0x16CCFA8 VA: 0x16D0FA8 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D100C Offset: 0x16CD00C VA: 0x16D100C Slot: 9
	public bool Equals(MSUnityRegisterRequest other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1080 Offset: 0x16CD080 VA: 0x16D1080 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1100 Offset: 0x16CD100 VA: 0x16D1100 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1158 Offset: 0x16CD158 VA: 0x16D1158 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1178 Offset: 0x16CD178 VA: 0x16D1178 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1214 Offset: 0x16CD214 VA: 0x16D1214 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D12E4 Offset: 0x16CD2E4 VA: 0x16D12E4 Slot: 4
	public void MergeFrom(MSUnityRegisterRequest other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1360 Offset: 0x16CD360 VA: 0x16D1360 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1380 Offset: 0x16CD380 VA: 0x16D1380 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16D1464 Offset: 0x16CD464 VA: 0x16D1464
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MSUnityRegisterResponse.<>c // TypeDefIndex: 5104
{
	// Fields
	public static readonly MSUnityRegisterResponse.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16D20E0 Offset: 0x16CE0E0 VA: 0x16D20E0
	private static void .cctor() { }

	// RVA: 0x16D2148 Offset: 0x16CE148 VA: 0x16D2148
	public void .ctor() { }

	// RVA: 0x16D2150 Offset: 0x16CE150 VA: 0x16D2150
	internal MSUnityRegisterResponse <.cctor>b__37_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MSUnityRegisterResponse : IMessage<MSUnityRegisterResponse>, IMessage, IEquatable<MSUnityRegisterResponse>, IDeepCloneable<MSUnityRegisterResponse>, IBufferMessage // TypeDefIndex: 5105
{
	// Fields
	private static readonly MessageParser<MSUnityRegisterResponse> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private bool isOk_; // 0x18
	private string account_; // 0x20
	private string message_; // 0x28

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MSUnityRegisterResponse> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsOk { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Account { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Message { get; set; }

	// Methods

	// RVA: 0x16D163C Offset: 0x16CD63C VA: 0x16D163C
	public static MessageParser<MSUnityRegisterResponse> get_Parser() { }

	// RVA: 0x16D1694 Offset: 0x16CD694 VA: 0x16D1694
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16D1798 Offset: 0x16CD798 VA: 0x16D1798 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D17E4 Offset: 0x16CD7E4 VA: 0x16D17E4
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D184C Offset: 0x16CD84C VA: 0x16D184C
	public void .ctor(MSUnityRegisterResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D18B4 Offset: 0x16CD8B4 VA: 0x16D18B4 Slot: 10
	public MSUnityRegisterResponse Clone() { }

	// RVA: 0x16D190C Offset: 0x16CD90C VA: 0x16D190C
	public bool get_IsOk() { }

	// RVA: 0x16D1914 Offset: 0x16CD914 VA: 0x16D1914
	public void set_IsOk(bool value) { }

	// RVA: 0x16D191C Offset: 0x16CD91C VA: 0x16D191C
	public string get_Account() { }

	// RVA: 0x16D1924 Offset: 0x16CD924 VA: 0x16D1924
	public void set_Account(string value) { }

	// RVA: 0x16D19A0 Offset: 0x16CD9A0 VA: 0x16D19A0
	public string get_Message() { }

	// RVA: 0x16D19A8 Offset: 0x16CD9A8 VA: 0x16D19A8
	public void set_Message(string value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1A24 Offset: 0x16CDA24 VA: 0x16D1A24 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1A88 Offset: 0x16CDA88 VA: 0x16D1A88 Slot: 9
	public bool Equals(MSUnityRegisterResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1B1C Offset: 0x16CDB1C VA: 0x16D1B1C Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1BD0 Offset: 0x16CDBD0 VA: 0x16D1BD0 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1C28 Offset: 0x16CDC28 VA: 0x16D1C28 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1C48 Offset: 0x16CDC48 VA: 0x16D1C48 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1D0C Offset: 0x16CDD0C VA: 0x16D1D0C Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1DE0 Offset: 0x16CDDE0 VA: 0x16D1DE0 Slot: 4
	public void MergeFrom(MSUnityRegisterResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1E6C Offset: 0x16CDE6C VA: 0x16D1E6C Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D1E8C Offset: 0x16CDE8C VA: 0x16D1E8C Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16D1FC8 Offset: 0x16CDFC8 VA: 0x16D1FC8
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MSUnityLoginRequest.<>c // TypeDefIndex: 5106
{
	// Fields
	public static readonly MSUnityLoginRequest.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16D2B44 Offset: 0x16CEB44 VA: 0x16D2B44
	private static void .cctor() { }

	// RVA: 0x16D2BAC Offset: 0x16CEBAC VA: 0x16D2BAC
	public void .ctor() { }

	// RVA: 0x16D2BB4 Offset: 0x16CEBB4 VA: 0x16D2BB4
	internal MSUnityLoginRequest <.cctor>b__32_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MSUnityLoginRequest : IMessage<MSUnityLoginRequest>, IMessage, IEquatable<MSUnityLoginRequest>, IDeepCloneable<MSUnityLoginRequest>, IBufferMessage // TypeDefIndex: 5107
{
	// Fields
	private static readonly MessageParser<MSUnityLoginRequest> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private string account_; // 0x18
	private string password_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MSUnityLoginRequest> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Account { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Password { get; set; }

	// Methods

	// RVA: 0x16D21A0 Offset: 0x16CE1A0 VA: 0x16D21A0
	public static MessageParser<MSUnityLoginRequest> get_Parser() { }

	// RVA: 0x16D21F8 Offset: 0x16CE1F8 VA: 0x16D21F8
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16D22FC Offset: 0x16CE2FC VA: 0x16D22FC Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D2348 Offset: 0x16CE348 VA: 0x16D2348
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D23B0 Offset: 0x16CE3B0 VA: 0x16D23B0
	public void .ctor(MSUnityLoginRequest other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D2410 Offset: 0x16CE410 VA: 0x16D2410 Slot: 10
	public MSUnityLoginRequest Clone() { }

	// RVA: 0x16D2468 Offset: 0x16CE468 VA: 0x16D2468
	public string get_Account() { }

	// RVA: 0x16D2470 Offset: 0x16CE470 VA: 0x16D2470
	public void set_Account(string value) { }

	// RVA: 0x16D24EC Offset: 0x16CE4EC VA: 0x16D24EC
	public string get_Password() { }

	// RVA: 0x16D24F4 Offset: 0x16CE4F4 VA: 0x16D24F4
	public void set_Password(string value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D2570 Offset: 0x16CE570 VA: 0x16D2570 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D25D4 Offset: 0x16CE5D4 VA: 0x16D25D4 Slot: 9
	public bool Equals(MSUnityLoginRequest other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D2648 Offset: 0x16CE648 VA: 0x16D2648 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D26C8 Offset: 0x16CE6C8 VA: 0x16D26C8 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D2720 Offset: 0x16CE720 VA: 0x16D2720 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D2740 Offset: 0x16CE740 VA: 0x16D2740 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D27DC Offset: 0x16CE7DC VA: 0x16D27DC Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D28AC Offset: 0x16CE8AC VA: 0x16D28AC Slot: 4
	public void MergeFrom(MSUnityLoginRequest other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D2928 Offset: 0x16CE928 VA: 0x16D2928 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D2948 Offset: 0x16CE948 VA: 0x16D2948 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16D2A2C Offset: 0x16CEA2C VA: 0x16D2A2C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MSUnityLoginResponse.<>c // TypeDefIndex: 5108
{
	// Fields
	public static readonly MSUnityLoginResponse.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16D3624 Offset: 0x16CF624 VA: 0x16D3624
	private static void .cctor() { }

	// RVA: 0x16D368C Offset: 0x16CF68C VA: 0x16D368C
	public void .ctor() { }

	// RVA: 0x16D3694 Offset: 0x16CF694 VA: 0x16D3694
	internal MSUnityLoginResponse <.cctor>b__37_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MSUnityLoginResponse : IMessage<MSUnityLoginResponse>, IMessage, IEquatable<MSUnityLoginResponse>, IDeepCloneable<MSUnityLoginResponse>, IBufferMessage // TypeDefIndex: 5109
{
	// Fields
	private static readonly MessageParser<MSUnityLoginResponse> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private bool isOk_; // 0x18
	private bool haveCharacter_; // 0x19
	private string message_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MSUnityLoginResponse> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsOk { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HaveCharacter { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Message { get; set; }

	// Methods

	// RVA: 0x16D2C04 Offset: 0x16CEC04 VA: 0x16D2C04
	public static MessageParser<MSUnityLoginResponse> get_Parser() { }

	// RVA: 0x16D2C5C Offset: 0x16CEC5C VA: 0x16D2C5C
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16D2D60 Offset: 0x16CED60 VA: 0x16D2D60 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D2DAC Offset: 0x16CEDAC VA: 0x16D2DAC
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D2E04 Offset: 0x16CEE04 VA: 0x16D2E04
	public void .ctor(MSUnityLoginResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D2E5C Offset: 0x16CEE5C VA: 0x16D2E5C Slot: 10
	public MSUnityLoginResponse Clone() { }

	// RVA: 0x16D2EB4 Offset: 0x16CEEB4 VA: 0x16D2EB4
	public bool get_IsOk() { }

	// RVA: 0x16D2EBC Offset: 0x16CEEBC VA: 0x16D2EBC
	public void set_IsOk(bool value) { }

	// RVA: 0x16D2EC4 Offset: 0x16CEEC4 VA: 0x16D2EC4
	public bool get_HaveCharacter() { }

	// RVA: 0x16D2ECC Offset: 0x16CEECC VA: 0x16D2ECC
	public void set_HaveCharacter(bool value) { }

	// RVA: 0x16D2ED4 Offset: 0x16CEED4 VA: 0x16D2ED4
	public string get_Message() { }

	// RVA: 0x16D2EDC Offset: 0x16CEEDC VA: 0x16D2EDC
	public void set_Message(string value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D2F58 Offset: 0x16CEF58 VA: 0x16D2F58 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D2FBC Offset: 0x16CEFBC VA: 0x16D2FBC Slot: 9
	public bool Equals(MSUnityLoginResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D305C Offset: 0x16CF05C VA: 0x16D305C Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D3128 Offset: 0x16CF128 VA: 0x16D3128 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D3180 Offset: 0x16CF180 VA: 0x16D3180 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D31A0 Offset: 0x16CF1A0 VA: 0x16D31A0 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D325C Offset: 0x16CF25C VA: 0x16D325C Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D3304 Offset: 0x16CF304 VA: 0x16D3304 Slot: 4
	public void MergeFrom(MSUnityLoginResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D3388 Offset: 0x16CF388 VA: 0x16D3388 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D33A8 Offset: 0x16CF3A8 VA: 0x16D33A8 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16D350C Offset: 0x16CF50C VA: 0x16D350C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MSUnityCreateCharacterRequest.<>c // TypeDefIndex: 5110
{
	// Fields
	public static readonly MSUnityCreateCharacterRequest.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16D4270 Offset: 0x16D0270 VA: 0x16D4270
	private static void .cctor() { }

	// RVA: 0x16D42D8 Offset: 0x16D02D8 VA: 0x16D42D8
	public void .ctor() { }

	// RVA: 0x16D42E0 Offset: 0x16D02E0 VA: 0x16D42E0
	internal MSUnityCreateCharacterRequest <.cctor>b__42_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MSUnityCreateCharacterRequest : IMessage<MSUnityCreateCharacterRequest>, IMessage, IEquatable<MSUnityCreateCharacterRequest>, IDeepCloneable<MSUnityCreateCharacterRequest>, IBufferMessage // TypeDefIndex: 5111
{
	// Fields
	private static readonly MessageParser<MSUnityCreateCharacterRequest> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private string data_; // 0x18
	private int factionId_; // 0x20
	private string name_; // 0x28
	private int sex_; // 0x30

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MSUnityCreateCharacterRequest> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Data { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FactionId { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Sex { get; set; }

	// Methods

	// RVA: 0x16D36E4 Offset: 0x16CF6E4 VA: 0x16D36E4
	public static MessageParser<MSUnityCreateCharacterRequest> get_Parser() { }

	// RVA: 0x16D373C Offset: 0x16CF73C VA: 0x16D373C
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16D3840 Offset: 0x16CF840 VA: 0x16D3840 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D388C Offset: 0x16CF88C VA: 0x16D388C
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D38F4 Offset: 0x16CF8F4 VA: 0x16D38F4
	public void .ctor(MSUnityCreateCharacterRequest other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D3964 Offset: 0x16CF964 VA: 0x16D3964 Slot: 10
	public MSUnityCreateCharacterRequest Clone() { }

	// RVA: 0x16D39BC Offset: 0x16CF9BC VA: 0x16D39BC
	public string get_Data() { }

	// RVA: 0x16D39C4 Offset: 0x16CF9C4 VA: 0x16D39C4
	public void set_Data(string value) { }

	// RVA: 0x16D3A40 Offset: 0x16CFA40 VA: 0x16D3A40
	public int get_FactionId() { }

	// RVA: 0x16D3A48 Offset: 0x16CFA48 VA: 0x16D3A48
	public void set_FactionId(int value) { }

	// RVA: 0x16D3A50 Offset: 0x16CFA50 VA: 0x16D3A50
	public string get_Name() { }

	// RVA: 0x16D3A58 Offset: 0x16CFA58 VA: 0x16D3A58
	public void set_Name(string value) { }

	// RVA: 0x16D3AD4 Offset: 0x16CFAD4 VA: 0x16D3AD4
	public int get_Sex() { }

	// RVA: 0x16D3ADC Offset: 0x16CFADC VA: 0x16D3ADC
	public void set_Sex(int value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D3AE4 Offset: 0x16CFAE4 VA: 0x16D3AE4 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D3B48 Offset: 0x16CFB48 VA: 0x16D3B48 Slot: 9
	public bool Equals(MSUnityCreateCharacterRequest other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D3BDC Offset: 0x16CFBDC VA: 0x16D3BDC Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D3C98 Offset: 0x16CFC98 VA: 0x16D3C98 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D3CF0 Offset: 0x16CFCF0 VA: 0x16D3CF0 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D3D10 Offset: 0x16CFD10 VA: 0x16D3D10 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D3DFC Offset: 0x16CFDFC VA: 0x16D3DFC Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D3F24 Offset: 0x16CFF24 VA: 0x16D3F24 Slot: 4
	public void MergeFrom(MSUnityCreateCharacterRequest other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D3FB8 Offset: 0x16CFFB8 VA: 0x16D3FB8 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D3FD8 Offset: 0x16CFFD8 VA: 0x16D3FD8 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16D4158 Offset: 0x16D0158 VA: 0x16D4158
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MSUnityCreateCharacterResponse.<>c // TypeDefIndex: 5112
{
	// Fields
	public static readonly MSUnityCreateCharacterResponse.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16D4C54 Offset: 0x16D0C54 VA: 0x16D4C54
	private static void .cctor() { }

	// RVA: 0x16D4CBC Offset: 0x16D0CBC VA: 0x16D4CBC
	public void .ctor() { }

	// RVA: 0x16D4CC4 Offset: 0x16D0CC4 VA: 0x16D4CC4
	internal MSUnityCreateCharacterResponse <.cctor>b__32_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MSUnityCreateCharacterResponse : IMessage<MSUnityCreateCharacterResponse>, IMessage, IEquatable<MSUnityCreateCharacterResponse>, IDeepCloneable<MSUnityCreateCharacterResponse>, IBufferMessage // TypeDefIndex: 5113
{
	// Fields
	private static readonly MessageParser<MSUnityCreateCharacterResponse> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private bool isOk_; // 0x18
	private string message_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MSUnityCreateCharacterResponse> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsOk { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Message { get; set; }

	// Methods

	// RVA: 0x16D4330 Offset: 0x16D0330 VA: 0x16D4330
	public static MessageParser<MSUnityCreateCharacterResponse> get_Parser() { }

	// RVA: 0x16D4388 Offset: 0x16D0388 VA: 0x16D4388
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16D448C Offset: 0x16D048C VA: 0x16D448C Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D44D8 Offset: 0x16D04D8 VA: 0x16D44D8
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D4530 Offset: 0x16D0530 VA: 0x16D4530
	public void .ctor(MSUnityCreateCharacterResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D4588 Offset: 0x16D0588 VA: 0x16D4588 Slot: 10
	public MSUnityCreateCharacterResponse Clone() { }

	// RVA: 0x16D45E0 Offset: 0x16D05E0 VA: 0x16D45E0
	public bool get_IsOk() { }

	// RVA: 0x16D45E8 Offset: 0x16D05E8 VA: 0x16D45E8
	public void set_IsOk(bool value) { }

	// RVA: 0x16D45F0 Offset: 0x16D05F0 VA: 0x16D45F0
	public string get_Message() { }

	// RVA: 0x16D45F8 Offset: 0x16D05F8 VA: 0x16D45F8
	public void set_Message(string value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D4674 Offset: 0x16D0674 VA: 0x16D4674 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D46D8 Offset: 0x16D06D8 VA: 0x16D46D8 Slot: 9
	public bool Equals(MSUnityCreateCharacterResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D4758 Offset: 0x16D0758 VA: 0x16D4758 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D47EC Offset: 0x16D07EC VA: 0x16D47EC Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D4844 Offset: 0x16D0844 VA: 0x16D4844 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D4864 Offset: 0x16D0864 VA: 0x16D4864 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D48F8 Offset: 0x16D08F8 VA: 0x16D48F8 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D4990 Offset: 0x16D0990 VA: 0x16D4990 Slot: 4
	public void MergeFrom(MSUnityCreateCharacterResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D4A04 Offset: 0x16D0A04 VA: 0x16D4A04 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D4A24 Offset: 0x16D0A24 VA: 0x16D4A24 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16D4B3C Offset: 0x16D0B3C VA: 0x16D4B3C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MSUnityEntergameRequest.<>c // TypeDefIndex: 5114
{
	// Fields
	public static readonly MSUnityEntergameRequest.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16D5518 Offset: 0x16D1518 VA: 0x16D5518
	private static void .cctor() { }

	// RVA: 0x16D5580 Offset: 0x16D1580 VA: 0x16D5580
	public void .ctor() { }

	// RVA: 0x16D5588 Offset: 0x16D1588 VA: 0x16D5588
	internal MSUnityEntergameRequest <.cctor>b__32_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MSUnityEntergameRequest : IMessage<MSUnityEntergameRequest>, IMessage, IEquatable<MSUnityEntergameRequest>, IDeepCloneable<MSUnityEntergameRequest>, IBufferMessage // TypeDefIndex: 5115
{
	// Fields
	private static readonly MessageParser<MSUnityEntergameRequest> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int resourceVersion_; // 0x18
	private int protocolVersion_; // 0x1C

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MSUnityEntergameRequest> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ResourceVersion { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ProtocolVersion { get; set; }

	// Methods

	// RVA: 0x16D4D14 Offset: 0x16D0D14 VA: 0x16D4D14
	public static MessageParser<MSUnityEntergameRequest> get_Parser() { }

	// RVA: 0x16D4D6C Offset: 0x16D0D6C VA: 0x16D4D6C
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16D4E70 Offset: 0x16D0E70 VA: 0x16D4E70 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D4EBC Offset: 0x16D0EBC VA: 0x16D4EBC
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D4EC4 Offset: 0x16D0EC4 VA: 0x16D4EC4
	public void .ctor(MSUnityEntergameRequest other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D4F10 Offset: 0x16D0F10 VA: 0x16D4F10 Slot: 10
	public MSUnityEntergameRequest Clone() { }

	// RVA: 0x16D4F68 Offset: 0x16D0F68 VA: 0x16D4F68
	public int get_ResourceVersion() { }

	// RVA: 0x16D4F70 Offset: 0x16D0F70 VA: 0x16D4F70
	public void set_ResourceVersion(int value) { }

	// RVA: 0x16D4F78 Offset: 0x16D0F78 VA: 0x16D4F78
	public int get_ProtocolVersion() { }

	// RVA: 0x16D4F80 Offset: 0x16D0F80 VA: 0x16D4F80
	public void set_ProtocolVersion(int value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D4F88 Offset: 0x16D0F88 VA: 0x16D4F88 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D4FEC Offset: 0x16D0FEC VA: 0x16D4FEC Slot: 9
	public bool Equals(MSUnityEntergameRequest other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5038 Offset: 0x16D1038 VA: 0x16D5038 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D50B0 Offset: 0x16D10B0 VA: 0x16D50B0 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5108 Offset: 0x16D1108 VA: 0x16D5108 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5128 Offset: 0x16D1128 VA: 0x16D5128 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D51B0 Offset: 0x16D11B0 VA: 0x16D51B0 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5264 Offset: 0x16D1264 VA: 0x16D5264 Slot: 4
	public void MergeFrom(MSUnityEntergameRequest other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D52B0 Offset: 0x16D12B0 VA: 0x16D52B0 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D52D0 Offset: 0x16D12D0 VA: 0x16D52D0 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16D5400 Offset: 0x16D1400 VA: 0x16D5400
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MSUnityEntergameResponse.<>c // TypeDefIndex: 5116
{
	// Fields
	public static readonly MSUnityEntergameResponse.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16D61F8 Offset: 0x16D21F8 VA: 0x16D61F8
	private static void .cctor() { }

	// RVA: 0x16D6260 Offset: 0x16D2260 VA: 0x16D6260
	public void .ctor() { }

	// RVA: 0x16D6268 Offset: 0x16D2268 VA: 0x16D6268
	internal MSUnityEntergameResponse <.cctor>b__42_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MSUnityEntergameResponse : IMessage<MSUnityEntergameResponse>, IMessage, IEquatable<MSUnityEntergameResponse>, IDeepCloneable<MSUnityEntergameResponse>, IBufferMessage // TypeDefIndex: 5117
{
	// Fields
	private static readonly MessageParser<MSUnityEntergameResponse> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private string serverIp_; // 0x18
	private int serverPort_; // 0x20
	private string loginCode_; // 0x28
	private string cid_; // 0x30

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MSUnityEntergameResponse> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ServerIp { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ServerPort { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LoginCode { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Cid { get; set; }

	// Methods

	// RVA: 0x16D55DC Offset: 0x16D15DC VA: 0x16D55DC
	public static MessageParser<MSUnityEntergameResponse> get_Parser() { }

	// RVA: 0x16D5634 Offset: 0x16D1634 VA: 0x16D5634
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16D5738 Offset: 0x16D1738 VA: 0x16D5738 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5784 Offset: 0x16D1784 VA: 0x16D5784
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D57FC Offset: 0x16D17FC VA: 0x16D57FC
	public void .ctor(MSUnityEntergameResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5874 Offset: 0x16D1874 VA: 0x16D5874 Slot: 10
	public MSUnityEntergameResponse Clone() { }

	// RVA: 0x16D58CC Offset: 0x16D18CC VA: 0x16D58CC
	public string get_ServerIp() { }

	// RVA: 0x16D58D4 Offset: 0x16D18D4 VA: 0x16D58D4
	public void set_ServerIp(string value) { }

	// RVA: 0x16D5950 Offset: 0x16D1950 VA: 0x16D5950
	public int get_ServerPort() { }

	// RVA: 0x16D5958 Offset: 0x16D1958 VA: 0x16D5958
	public void set_ServerPort(int value) { }

	// RVA: 0x16D5960 Offset: 0x16D1960 VA: 0x16D5960
	public string get_LoginCode() { }

	// RVA: 0x16D5968 Offset: 0x16D1968 VA: 0x16D5968
	public void set_LoginCode(string value) { }

	// RVA: 0x16D59E4 Offset: 0x16D19E4 VA: 0x16D59E4
	public string get_Cid() { }

	// RVA: 0x16D59EC Offset: 0x16D19EC VA: 0x16D59EC
	public void set_Cid(string value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5A68 Offset: 0x16D1A68 VA: 0x16D5A68 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5ACC Offset: 0x16D1ACC VA: 0x16D5ACC Slot: 9
	public bool Equals(MSUnityEntergameResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5B64 Offset: 0x16D1B64 VA: 0x16D5B64 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5C24 Offset: 0x16D1C24 VA: 0x16D5C24 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5C7C Offset: 0x16D1C7C VA: 0x16D5C7C Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5C9C Offset: 0x16D1C9C VA: 0x16D5C9C Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5D90 Offset: 0x16D1D90 VA: 0x16D5D90 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5EC0 Offset: 0x16D1EC0 VA: 0x16D5EC0 Slot: 4
	public void MergeFrom(MSUnityEntergameResponse other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5F60 Offset: 0x16D1F60 VA: 0x16D5F60 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D5F80 Offset: 0x16D1F80 VA: 0x16D5F80 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16D60E0 Offset: 0x16D20E0 VA: 0x16D60E0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MSUnityRegisterFields.<>c // TypeDefIndex: 5118
{
	// Fields
	public static readonly MSUnityRegisterFields.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16D6ADC Offset: 0x16D2ADC VA: 0x16D6ADC
	private static void .cctor() { }

	// RVA: 0x16D6B44 Offset: 0x16D2B44 VA: 0x16D6B44
	public void .ctor() { }

	// RVA: 0x16D6B4C Offset: 0x16D2B4C VA: 0x16D6B4C
	internal MSUnityRegisterFields <.cctor>b__27_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MSUnityRegisterFields : IMessage<MSUnityRegisterFields>, IMessage, IEquatable<MSUnityRegisterFields>, IDeepCloneable<MSUnityRegisterFields>, IBufferMessage // TypeDefIndex: 5119
{
	// Fields
	private static readonly MessageParser<MSUnityRegisterFields> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	public const int DataFieldNumber = 1;
	private string data_; // 0x18

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MSUnityRegisterFields> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Data { get; set; }

	// Methods

	// RVA: 0x16D62B8 Offset: 0x16D22B8 VA: 0x16D62B8
	public static MessageParser<MSUnityRegisterFields> get_Parser() { }

	// RVA: 0x16D6310 Offset: 0x16D2310 VA: 0x16D6310
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16D6414 Offset: 0x16D2414 VA: 0x16D6414 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6460 Offset: 0x16D2460 VA: 0x16D6460
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D64B8 Offset: 0x16D24B8 VA: 0x16D64B8
	public void .ctor(MSUnityRegisterFields other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6508 Offset: 0x16D2508 VA: 0x16D6508 Slot: 10
	public MSUnityRegisterFields Clone() { }

	// RVA: 0x16D6560 Offset: 0x16D2560 VA: 0x16D6560
	public string get_Data() { }

	// RVA: 0x16D6568 Offset: 0x16D2568 VA: 0x16D6568
	public void set_Data(string value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D65E4 Offset: 0x16D25E4 VA: 0x16D65E4 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6648 Offset: 0x16D2648 VA: 0x16D6648 Slot: 9
	public bool Equals(MSUnityRegisterFields other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D66A8 Offset: 0x16D26A8 VA: 0x16D66A8 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6708 Offset: 0x16D2708 VA: 0x16D6708 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6760 Offset: 0x16D2760 VA: 0x16D6760 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6780 Offset: 0x16D2780 VA: 0x16D6780 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D67EC Offset: 0x16D27EC VA: 0x16D67EC Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6880 Offset: 0x16D2880 VA: 0x16D6880 Slot: 4
	public void MergeFrom(MSUnityRegisterFields other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D68E4 Offset: 0x16D28E4 VA: 0x16D68E4 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6904 Offset: 0x16D2904 VA: 0x16D6904 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16D69C4 Offset: 0x16D29C4 VA: 0x16D69C4
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MSPasscode.<>c // TypeDefIndex: 5120
{
	// Fields
	public static readonly MSPasscode.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16D72B8 Offset: 0x16D32B8 VA: 0x16D72B8
	private static void .cctor() { }

	// RVA: 0x16D7320 Offset: 0x16D3320 VA: 0x16D7320
	public void .ctor() { }

	// RVA: 0x16D7328 Offset: 0x16D3328 VA: 0x16D7328
	internal MSPasscode <.cctor>b__27_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MSPasscode : IMessage<MSPasscode>, IMessage, IEquatable<MSPasscode>, IDeepCloneable<MSPasscode>, IBufferMessage // TypeDefIndex: 5121
{
	// Fields
	private static readonly MessageParser<MSPasscode> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int passcode_; // 0x18

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MSPasscode> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Passcode { get; set; }

	// Methods

	// RVA: 0x16D6B9C Offset: 0x16D2B9C VA: 0x16D6B9C
	public static MessageParser<MSPasscode> get_Parser() { }

	// RVA: 0x16D6BF4 Offset: 0x16D2BF4 VA: 0x16D6BF4
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16D6CF8 Offset: 0x16D2CF8 VA: 0x16D6CF8 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6D44 Offset: 0x16D2D44 VA: 0x16D6D44
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6D4C Offset: 0x16D2D4C VA: 0x16D6D4C
	public void .ctor(MSPasscode other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6D98 Offset: 0x16D2D98 VA: 0x16D6D98 Slot: 10
	public MSPasscode Clone() { }

	// RVA: 0x16D6DF0 Offset: 0x16D2DF0 VA: 0x16D6DF0
	public int get_Passcode() { }

	// RVA: 0x16D6DF8 Offset: 0x16D2DF8 VA: 0x16D6DF8
	public void set_Passcode(int value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6E00 Offset: 0x16D2E00 VA: 0x16D6E00 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6E64 Offset: 0x16D2E64 VA: 0x16D6E64 Slot: 9
	public bool Equals(MSPasscode other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6EA0 Offset: 0x16D2EA0 VA: 0x16D6EA0 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6EFC Offset: 0x16D2EFC VA: 0x16D6EFC Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6F54 Offset: 0x16D2F54 VA: 0x16D6F54 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6F74 Offset: 0x16D2F74 VA: 0x16D6F74 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D6FD4 Offset: 0x16D2FD4 VA: 0x16D6FD4 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D7054 Offset: 0x16D3054 VA: 0x16D7054 Slot: 4
	public void MergeFrom(MSPasscode other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D7094 Offset: 0x16D3094 VA: 0x16D7094 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D70B4 Offset: 0x16D30B4 VA: 0x16D70B4 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16D71A0 Offset: 0x16D31A0 VA: 0x16D71A0
	private static void .cctor() { }
}

// Namespace: App
public static class DatabaseReflection // TypeDefIndex: 5122
{
	// Fields
	private static FileDescriptor descriptor; // 0x0

	// Properties
	public static FileDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x16D737C Offset: 0x16D337C VA: 0x16D737C
	public static FileDescriptor get_Descriptor() { }

	// RVA: 0x16D73D4 Offset: 0x16D33D4 VA: 0x16D73D4
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HotkeyItemDatabase.<>c // TypeDefIndex: 5123
{
	// Fields
	public static readonly HotkeyItemDatabase.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16D9E20 Offset: 0x16D5E20 VA: 0x16D9E20
	private static void .cctor() { }

	// RVA: 0x16D9E88 Offset: 0x16D5E88 VA: 0x16D9E88
	public void .ctor() { }

	// RVA: 0x16D9E90 Offset: 0x16D5E90 VA: 0x16D9E90
	internal HotkeyItemDatabase <.cctor>b__32_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HotkeyItemDatabase : IMessage<HotkeyItemDatabase>, IMessage, IEquatable<HotkeyItemDatabase>, IDeepCloneable<HotkeyItemDatabase>, IBufferMessage // TypeDefIndex: 5124
{
	// Fields
	private static readonly MessageParser<HotkeyItemDatabase> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	public const int CidFieldNumber = 1;
	private string cid_; // 0x18
	public const int ListFieldNumber = 2;
	private static readonly FieldCodec<int> _repeated_list_codec; // 0x8
	private readonly RepeatedField<int> list_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HotkeyItemDatabase> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Cid { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> List { get; }

	// Methods

	// RVA: 0x16D9318 Offset: 0x16D5318 VA: 0x16D9318
	public static MessageParser<HotkeyItemDatabase> get_Parser() { }

	// RVA: 0x16D9370 Offset: 0x16D5370 VA: 0x16D9370
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16D9474 Offset: 0x16D5474 VA: 0x16D9474 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D94C0 Offset: 0x16D54C0 VA: 0x16D94C0
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D956C Offset: 0x16D556C VA: 0x16D956C
	public void .ctor(HotkeyItemDatabase other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D9608 Offset: 0x16D5608 VA: 0x16D9608 Slot: 10
	public HotkeyItemDatabase Clone() { }

	// RVA: 0x16D9660 Offset: 0x16D5660 VA: 0x16D9660
	public string get_Cid() { }

	// RVA: 0x16D9668 Offset: 0x16D5668 VA: 0x16D9668
	public void set_Cid(string value) { }

	// RVA: 0x16D96E4 Offset: 0x16D56E4 VA: 0x16D96E4
	public RepeatedField<int> get_List() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D96EC Offset: 0x16D56EC VA: 0x16D96EC Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D9750 Offset: 0x16D5750 VA: 0x16D9750 Slot: 9
	public bool Equals(HotkeyItemDatabase other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D97F4 Offset: 0x16D57F4 VA: 0x16D97F4 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D9870 Offset: 0x16D5870 VA: 0x16D9870 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D98C8 Offset: 0x16D58C8 VA: 0x16D98C8 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D98E8 Offset: 0x16D58E8 VA: 0x16D98E8 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D99D0 Offset: 0x16D59D0 VA: 0x16D99D0 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D9ACC Offset: 0x16D5ACC VA: 0x16D9ACC Slot: 4
	public void MergeFrom(HotkeyItemDatabase other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D9B6C Offset: 0x16D5B6C VA: 0x16D9B6C Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16D9B8C Offset: 0x16D5B8C VA: 0x16D9B8C Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16D9CE4 Offset: 0x16D5CE4 VA: 0x16D9CE4
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SalesmanItem.<>c // TypeDefIndex: 5125
{
	// Fields
	public static readonly SalesmanItem.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16DAB98 Offset: 0x16D6B98 VA: 0x16DAB98
	private static void .cctor() { }

	// RVA: 0x16DAC00 Offset: 0x16D6C00 VA: 0x16DAC00
	public void .ctor() { }

	// RVA: 0x16DAC08 Offset: 0x16D6C08 VA: 0x16DAC08
	internal SalesmanItem <.cctor>b__37_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SalesmanItem : IMessage<SalesmanItem>, IMessage, IEquatable<SalesmanItem>, IDeepCloneable<SalesmanItem>, IBufferMessage // TypeDefIndex: 5126
{
	// Fields
	private static readonly MessageParser<SalesmanItem> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	public const int ItemFieldNumber = 1;
	private Item item_; // 0x18
	public const int MoneyFieldNumber = 2;
	private int money_; // 0x20
	public const int KnbFieldNumber = 3;
	private int knb_; // 0x24

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SalesmanItem> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Item Item { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Money { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Knb { get; set; }

	// Methods

	// RVA: 0x16D9EE0 Offset: 0x16D5EE0 VA: 0x16D9EE0
	public static MessageParser<SalesmanItem> get_Parser() { }

	// RVA: 0x16D9F38 Offset: 0x16D5F38 VA: 0x16D9F38
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16DA03C Offset: 0x16D603C VA: 0x16DA03C Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA088 Offset: 0x16D6088 VA: 0x16DA088
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA090 Offset: 0x16D6090 VA: 0x16DA090
	public void .ctor(SalesmanItem other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA15C Offset: 0x16D615C VA: 0x16DA15C Slot: 10
	public SalesmanItem Clone() { }

	// RVA: 0x16DA1B4 Offset: 0x16D61B4 VA: 0x16DA1B4
	public Item get_Item() { }

	// RVA: 0x16DA1BC Offset: 0x16D61BC VA: 0x16DA1BC
	public void set_Item(Item value) { }

	// RVA: 0x16DA1C4 Offset: 0x16D61C4 VA: 0x16DA1C4
	public int get_Money() { }

	// RVA: 0x16DA1CC Offset: 0x16D61CC VA: 0x16DA1CC
	public void set_Money(int value) { }

	// RVA: 0x16DA1D4 Offset: 0x16D61D4 VA: 0x16DA1D4
	public int get_Knb() { }

	// RVA: 0x16DA1DC Offset: 0x16D61DC VA: 0x16DA1DC
	public void set_Knb(int value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA1E4 Offset: 0x16D61E4 VA: 0x16DA1E4 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA248 Offset: 0x16D6248 VA: 0x16DA248 Slot: 9
	public bool Equals(SalesmanItem other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA2C8 Offset: 0x16D62C8 VA: 0x16DA2C8 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA358 Offset: 0x16D6358 VA: 0x16DA358 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA3B0 Offset: 0x16D63B0 VA: 0x16DA3B0 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA3D0 Offset: 0x16D63D0 VA: 0x16DA3D0 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA480 Offset: 0x16D6480 VA: 0x16DA480 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA560 Offset: 0x16D6560 VA: 0x16DA560 Slot: 4
	public void MergeFrom(SalesmanItem other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA880 Offset: 0x16D6880 VA: 0x16DA880 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA8A0 Offset: 0x16D68A0 VA: 0x16DA8A0 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16DAA80 Offset: 0x16D6A80 VA: 0x16DAA80
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TongMember.<>c // TypeDefIndex: 5127
{
	// Fields
	public static readonly TongMember.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16DBC44 Offset: 0x16D7C44 VA: 0x16DBC44
	private static void .cctor() { }

	// RVA: 0x16DBCAC Offset: 0x16D7CAC VA: 0x16DBCAC
	public void .ctor() { }

	// RVA: 0x16DBCB4 Offset: 0x16D7CB4 VA: 0x16DBCB4
	internal TongMember <.cctor>b__62_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TongMember : IMessage<TongMember>, IMessage, IEquatable<TongMember>, IDeepCloneable<TongMember>, IBufferMessage // TypeDefIndex: 5128
{
	// Fields
	private static readonly MessageParser<TongMember> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private string cid_; // 0x18
	private string name_; // 0x20
	private int figure_; // 0x28
	private string title_; // 0x30
	private bool isOnline_; // 0x38
	private int level_; // 0x3C
	private int sect_; // 0x40
	private int joinTime_; // 0x44

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TongMember> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Cid { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Figure { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Title { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsOnline { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Level { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Sect { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int JoinTime { get; set; }

	// Methods

	// RVA: 0x16DAC5C Offset: 0x16D6C5C VA: 0x16DAC5C
	public static MessageParser<TongMember> get_Parser() { }

	// RVA: 0x16DACB4 Offset: 0x16D6CB4 VA: 0x16DACB4
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16DADB8 Offset: 0x16D6DB8 VA: 0x16DADB8 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DAE04 Offset: 0x16D6E04 VA: 0x16DAE04
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DAE7C Offset: 0x16D6E7C VA: 0x16DAE7C
	public void .ctor(TongMember other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DAF0C Offset: 0x16D6F0C VA: 0x16DAF0C Slot: 10
	public TongMember Clone() { }

	// RVA: 0x16DAF64 Offset: 0x16D6F64 VA: 0x16DAF64
	public string get_Cid() { }

	// RVA: 0x16DAF6C Offset: 0x16D6F6C VA: 0x16DAF6C
	public void set_Cid(string value) { }

	// RVA: 0x16DAFE8 Offset: 0x16D6FE8 VA: 0x16DAFE8
	public string get_Name() { }

	// RVA: 0x16DAFF0 Offset: 0x16D6FF0 VA: 0x16DAFF0
	public void set_Name(string value) { }

	// RVA: 0x16DB06C Offset: 0x16D706C VA: 0x16DB06C
	public int get_Figure() { }

	// RVA: 0x16DB074 Offset: 0x16D7074 VA: 0x16DB074
	public void set_Figure(int value) { }

	// RVA: 0x16DB07C Offset: 0x16D707C VA: 0x16DB07C
	public string get_Title() { }

	// RVA: 0x16DB084 Offset: 0x16D7084 VA: 0x16DB084
	public void set_Title(string value) { }

	// RVA: 0x16DB100 Offset: 0x16D7100 VA: 0x16DB100
	public bool get_IsOnline() { }

	// RVA: 0x16DB108 Offset: 0x16D7108 VA: 0x16DB108
	public void set_IsOnline(bool value) { }

	// RVA: 0x16DB110 Offset: 0x16D7110 VA: 0x16DB110
	public int get_Level() { }

	// RVA: 0x16DB118 Offset: 0x16D7118 VA: 0x16DB118
	public void set_Level(int value) { }

	// RVA: 0x16DB120 Offset: 0x16D7120 VA: 0x16DB120
	public int get_Sect() { }

	// RVA: 0x16DB128 Offset: 0x16D7128 VA: 0x16DB128
	public void set_Sect(int value) { }

	// RVA: 0x16DB130 Offset: 0x16D7130 VA: 0x16DB130
	public int get_JoinTime() { }

	// RVA: 0x16DB138 Offset: 0x16D7138 VA: 0x16DB138
	public void set_JoinTime(int value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DB140 Offset: 0x16D7140 VA: 0x16DB140 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DB1A4 Offset: 0x16D71A4 VA: 0x16DB1A4 Slot: 9
	public bool Equals(TongMember other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DB28C Offset: 0x16D728C VA: 0x16DB28C Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DB3DC Offset: 0x16D73DC VA: 0x16DB3DC Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DB434 Offset: 0x16D7434 VA: 0x16DB434 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DB454 Offset: 0x16D7454 VA: 0x16DB454 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DB5E8 Offset: 0x16D75E8 VA: 0x16DB5E8 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DB7AC Offset: 0x16D77AC VA: 0x16DB7AC Slot: 4
	public void MergeFrom(TongMember other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DB880 Offset: 0x16D7880 VA: 0x16DB880 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DB8A0 Offset: 0x16D78A0 VA: 0x16DB8A0 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16DBB2C Offset: 0x16D7B2C VA: 0x16DBB2C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Skill.<>c // TypeDefIndex: 5129
{
	// Fields
	public static readonly Skill.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16DC6EC Offset: 0x16D86EC VA: 0x16DC6EC
	private static void .cctor() { }

	// RVA: 0x16DC754 Offset: 0x16D8754 VA: 0x16DC754
	public void .ctor() { }

	// RVA: 0x16DC75C Offset: 0x16D875C VA: 0x16DC75C
	internal Skill <.cctor>b__42_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Skill : IMessage<Skill>, IMessage, IEquatable<Skill>, IDeepCloneable<Skill>, IBufferMessage // TypeDefIndex: 5130
{
	// Fields
	private static readonly MessageParser<Skill> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	public const int IdFieldNumber = 1;
	private int id_; // 0x18
	public const int LevelFieldNumber = 2;
	private int level_; // 0x1C
	public const int ExpFieldNumber = 3;
	private long exp_; // 0x20
	public const int TempEnhancedPointFieldNumber = 4;
	private int tempEnhancedPoint_; // 0x28

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Skill> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Id { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Level { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Exp { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TempEnhancedPoint { get; set; }

	// Methods

	// RVA: 0x16DBD04 Offset: 0x16D7D04 VA: 0x16DBD04
	public static MessageParser<Skill> get_Parser() { }

	// RVA: 0x16DBD5C Offset: 0x16D7D5C VA: 0x16DBD5C
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16DBE60 Offset: 0x16D7E60 VA: 0x16DBE60 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DBEAC Offset: 0x16D7EAC VA: 0x16DBEAC
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DBEB4 Offset: 0x16D7EB4 VA: 0x16DBEB4
	public void .ctor(Skill other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DBF10 Offset: 0x16D7F10 VA: 0x16DBF10 Slot: 10
	public Skill Clone() { }

	// RVA: 0x16DBF68 Offset: 0x16D7F68 VA: 0x16DBF68
	public int get_Id() { }

	// RVA: 0x16DBF70 Offset: 0x16D7F70 VA: 0x16DBF70
	public void set_Id(int value) { }

	// RVA: 0x16DBF78 Offset: 0x16D7F78 VA: 0x16DBF78
	public int get_Level() { }

	// RVA: 0x16DBF80 Offset: 0x16D7F80 VA: 0x16DBF80
	public void set_Level(int value) { }

	// RVA: 0x16DBF88 Offset: 0x16D7F88 VA: 0x16DBF88
	public long get_Exp() { }

	// RVA: 0x16DBF90 Offset: 0x16D7F90 VA: 0x16DBF90
	public void set_Exp(long value) { }

	// RVA: 0x16DBF98 Offset: 0x16D7F98 VA: 0x16DBF98
	public int get_TempEnhancedPoint() { }

	// RVA: 0x16DBFA0 Offset: 0x16D7FA0 VA: 0x16DBFA0
	public void set_TempEnhancedPoint(int value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DBFA8 Offset: 0x16D7FA8 VA: 0x16DBFA8 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DC00C Offset: 0x16D800C VA: 0x16DC00C Slot: 9
	public bool Equals(Skill other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DC078 Offset: 0x16D8078 VA: 0x16DC078 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DC130 Offset: 0x16D8130 VA: 0x16DC130 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DC188 Offset: 0x16D8188 VA: 0x16DC188 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DC1A8 Offset: 0x16D81A8 VA: 0x16DC1A8 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DC280 Offset: 0x16D8280 VA: 0x16DC280 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DC38C Offset: 0x16D838C VA: 0x16DC38C Slot: 4
	public void MergeFrom(Skill other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DC3F0 Offset: 0x16D83F0 VA: 0x16DC3F0 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DC410 Offset: 0x16D8410 VA: 0x16DC410 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16DC5D4 Offset: 0x16D85D4 VA: 0x16DC5D4
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Item.<>c // TypeDefIndex: 5131
{
	// Fields
	public static readonly Item.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16DD9E4 Offset: 0x16D99E4 VA: 0x16DD9E4
	private static void .cctor() { }

	// RVA: 0x16DDA4C Offset: 0x16D9A4C VA: 0x16DDA4C
	public void .ctor() { }

	// RVA: 0x16DDA54 Offset: 0x16D9A54 VA: 0x16DDA54
	internal Item <.cctor>b__77_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Item : IMessage<Item>, IMessage, IEquatable<Item>, IDeepCloneable<Item>, IBufferMessage // TypeDefIndex: 5132
{
	// Fields
	private static readonly MessageParser<Item> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	public const int IdentifyFieldNumber = 1;
	private int identify_; // 0x18
	public const int RowIndexAndTypeFieldNumber = 2;
	private int rowIndexAndType_; // 0x1C
	public const int DetailAndGenreFieldNumber = 3;
	private int detailAndGenre_; // 0x20
	public const int ParticularAndLevelFieldNumber = 4;
	private int particularAndLevel_; // 0x24
	public const int StackAndSeriesFieldNumber = 5;
	private int stackAndSeries_; // 0x28
	public const int DurabilityAndLockStateFieldNumber = 6;
	private int durabilityAndLockState_; // 0x2C
	public const int CreateTimestampSecondsFieldNumber = 7;
	private long createTimestampSeconds_; // 0x30
	public const int SourceCidFieldNumber = 8;
	private string sourceCid_; // 0x38
	public const int SourceNameFieldNumber = 9;
	private string sourceName_; // 0x40
	public const int StateFieldNumber = 10;
	private static readonly FieldCodec<long> _repeated_state_codec; // 0x8
	private readonly RepeatedField<long> state_; // 0x48
	public const int MagicFieldNumber = 11;
	private static readonly FieldCodec<int> _repeated_magic_codec; // 0x10
	private readonly RepeatedField<int> magic_; // 0x50

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Item> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Identify { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RowIndexAndType { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DetailAndGenre { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ParticularAndLevel { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StackAndSeries { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int DurabilityAndLockState { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long CreateTimestampSeconds { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SourceCid { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SourceName { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<long> State { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Magic { get; }

	// Methods

	// RVA: 0x16DC7B0 Offset: 0x16D87B0 VA: 0x16DC7B0
	public static MessageParser<Item> get_Parser() { }

	// RVA: 0x16DC808 Offset: 0x16D8808 VA: 0x16DC808
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16DC90C Offset: 0x16D890C VA: 0x16DC90C Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA63C Offset: 0x16D663C VA: 0x16DA63C
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DC958 Offset: 0x16D8958 VA: 0x16DC958
	public void .ctor(Item other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA104 Offset: 0x16D6104 VA: 0x16DA104 Slot: 10
	public Item Clone() { }

	// RVA: 0x16DCA4C Offset: 0x16D8A4C VA: 0x16DCA4C
	public int get_Identify() { }

	// RVA: 0x16DCA54 Offset: 0x16D8A54 VA: 0x16DCA54
	public void set_Identify(int value) { }

	// RVA: 0x16DCA5C Offset: 0x16D8A5C VA: 0x16DCA5C
	public int get_RowIndexAndType() { }

	// RVA: 0x16DCA64 Offset: 0x16D8A64 VA: 0x16DCA64
	public void set_RowIndexAndType(int value) { }

	// RVA: 0x16DCA6C Offset: 0x16D8A6C VA: 0x16DCA6C
	public int get_DetailAndGenre() { }

	// RVA: 0x16DCA74 Offset: 0x16D8A74 VA: 0x16DCA74
	public void set_DetailAndGenre(int value) { }

	// RVA: 0x16DCA7C Offset: 0x16D8A7C VA: 0x16DCA7C
	public int get_ParticularAndLevel() { }

	// RVA: 0x16DCA84 Offset: 0x16D8A84 VA: 0x16DCA84
	public void set_ParticularAndLevel(int value) { }

	// RVA: 0x16DCA8C Offset: 0x16D8A8C VA: 0x16DCA8C
	public int get_StackAndSeries() { }

	// RVA: 0x16DCA94 Offset: 0x16D8A94 VA: 0x16DCA94
	public void set_StackAndSeries(int value) { }

	// RVA: 0x16DCA9C Offset: 0x16D8A9C VA: 0x16DCA9C
	public int get_DurabilityAndLockState() { }

	// RVA: 0x16DCAA4 Offset: 0x16D8AA4 VA: 0x16DCAA4
	public void set_DurabilityAndLockState(int value) { }

	// RVA: 0x16DCAAC Offset: 0x16D8AAC VA: 0x16DCAAC
	public long get_CreateTimestampSeconds() { }

	// RVA: 0x16DCAB4 Offset: 0x16D8AB4 VA: 0x16DCAB4
	public void set_CreateTimestampSeconds(long value) { }

	// RVA: 0x16DCABC Offset: 0x16D8ABC VA: 0x16DCABC
	public string get_SourceCid() { }

	// RVA: 0x16DCAC4 Offset: 0x16D8AC4 VA: 0x16DCAC4
	public void set_SourceCid(string value) { }

	// RVA: 0x16DCB40 Offset: 0x16D8B40 VA: 0x16DCB40
	public string get_SourceName() { }

	// RVA: 0x16DCB48 Offset: 0x16D8B48 VA: 0x16DCB48
	public void set_SourceName(string value) { }

	// RVA: 0x16DCBC4 Offset: 0x16D8BC4 VA: 0x16DCBC4
	public RepeatedField<long> get_State() { }

	// RVA: 0x16DCBCC Offset: 0x16D8BCC VA: 0x16DCBCC
	public RepeatedField<int> get_Magic() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DCBD4 Offset: 0x16D8BD4 VA: 0x16DCBD4 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DCC38 Offset: 0x16D8C38 VA: 0x16DCC38 Slot: 9
	public bool Equals(Item other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DCD8C Offset: 0x16D8D8C VA: 0x16DCD8C Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DCF14 Offset: 0x16D8F14 VA: 0x16DCF14 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DCF6C Offset: 0x16D8F6C VA: 0x16DCF6C Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DCF8C Offset: 0x16D8F8C VA: 0x16DCF8C Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DD1F0 Offset: 0x16D91F0 VA: 0x16DD1F0 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DA74C Offset: 0x16D674C VA: 0x16DA74C Slot: 4
	public void MergeFrom(Item other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DD48C Offset: 0x16D948C VA: 0x16DD48C Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DD4AC Offset: 0x16D94AC VA: 0x16DD4AC Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16DD884 Offset: 0x16D9884 VA: 0x16DD884
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Character.<>c // TypeDefIndex: 5133
{
	// Fields
	public static readonly Character.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16E1960 Offset: 0x16DD960 VA: 0x16E1960
	private static void .cctor() { }

	// RVA: 0x16E19C8 Offset: 0x16DD9C8 VA: 0x16E19C8
	public void .ctor() { }

	// RVA: 0x16E19D0 Offset: 0x16DD9D0 VA: 0x16E19D0
	internal Character <.cctor>b__312_0() { }
}

// Namespace: App
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Character : IMessage<Character>, IMessage, IEquatable<Character>, IDeepCloneable<Character>, IBufferMessage // TypeDefIndex: 5134
{
	// Fields
	private static readonly MessageParser<Character> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	public const int CidFieldNumber = 1;
	private string cid_; // 0x18
	public const int AccountFieldNumber = 2;
	private string account_; // 0x20
	public const int NameFieldNumber = 3;
	private string name_; // 0x28
	public const int SexFieldNumber = 4;
	private int sex_; // 0x30
	public const int SectFieldNumber = 5;
	private int sect_; // 0x34
	public const int RevivalOnLoginFieldNumber = 6;
	private int revivalOnLogin_; // 0x38
	public const int TongIdentifyFieldNumber = 7;
	private string tongIdentify_; // 0x40
	public const int BagarateMoneyFieldNumber = 8;
	private long bagarateMoney_; // 0x48
	public const int SeriesFieldNumber = 9;
	private int series_; // 0x50
	public const int TeamIdFieldNumber = 10;
	private int teamId_; // 0x54
	public const int LevelFieldNumber = 11;
	private int level_; // 0x58
	public const int ExpFieldNumber = 12;
	private long exp_; // 0x60
	public const int PowerFieldNumber = 13;
	private int power_; // 0x68
	public const int AgilityFieldNumber = 14;
	private int agility_; // 0x6C
	public const int OuterFieldNumber = 15;
	private int outer_; // 0x70
	public const int InsideFieldNumber = 16;
	private int inside_; // 0x74
	public const int LuckFieldNumber = 17;
	private int luck_; // 0x78
	public const int MaxLifeFieldNumber = 18;
	private int maxLife_; // 0x7C
	public const int MaxStaminaFieldNumber = 19;
	private int maxStamina_; // 0x80
	public const int MaxInnerFieldNumber = 20;
	private int maxInner_; // 0x84
	public const int LeftPropFieldNumber = 21;
	private int leftProp_; // 0x88
	public const int LeftFightFieldNumber = 22;
	private int leftFight_; // 0x8C
	public const int FightModeFieldNumber = 23;
	private int fightMode_; // 0x90
	public const int ArmorResFieldNumber = 24;
	private int armorRes_; // 0x94
	public const int WeaponResFieldNumber = 25;
	private int weaponRes_; // 0x98
	public const int HelmResFieldNumber = 26;
	private int helmRes_; // 0x9C
	public const int HorseResFieldNumber = 27;
	private int horseRes_; // 0xA0
	public const int CampFieldNumber = 28;
	private int camp_; // 0xA4
	public const int MapIdFieldNumber = 29;
	private int mapId_; // 0xA8
	public const int MapXFieldNumber = 30;
	private int mapX_; // 0xAC
	public const int MapYFieldNumber = 31;
	private int mapY_; // 0xB0
	public const int CurLifeFieldNumber = 32;
	private int curLife_; // 0xB4
	public const int CurInnerFieldNumber = 33;
	private int curInner_; // 0xB8
	public const int CurStaminaFieldNumber = 34;
	private int curStamina_; // 0xBC
	public const int WorldRankFieldNumber = 35;
	private int worldRank_; // 0xC0
	public const int StorageCellMaximumFieldNumber = 36;
	private int storageCellMaximum_; // 0xC4
	public const int BagarateCellMaximumFieldNumber = 37;
	private int bagarateCellMaximum_; // 0xC8
	public const int PkStatusFieldNumber = 38;
	private int pkStatus_; // 0xCC
	public const int PkvalueFieldNumber = 39;
	private int pkvalue_; // 0xD0
	public const int TongIndexFieldNumber = 40;
	private int tongIndex_; // 0xD4
	public const int RevivalMapIdFieldNumber = 41;
	private int revivalMapId_; // 0xD8
	public const int RevivalMapXFieldNumber = 42;
	private int revivalMapX_; // 0xDC
	public const int RevivalMapYFieldNumber = 43;
	private int revivalMapY_; // 0xE0
	public const int KnbFieldNumber = 44;
	private int knb_; // 0xE4
	public const int CampCurrentlyFieldNumber = 45;
	private int campCurrently_; // 0xE8
	public const int RunSpeedFieldNumber = 46;
	private int runSpeed_; // 0xEC
	public const int ActionFieldNumber = 47;
	private int action_; // 0xF0
	public const int DirectionFieldNumber = 48;
	private int direction_; // 0xF4
	public const int AttackSpeedFieldNumber = 49;
	private int attackSpeed_; // 0xF8
	public const int CastSpeedFieldNumber = 50;
	private int castSpeed_; // 0xFC
	public const int StateStatureFieldNumber = 51;
	private int stateStature_; // 0x100
	public const int TitleCurrentlyFieldNumber = 52;
	private string titleCurrently_; // 0x108
	public const int StorageMoneyFieldNumber = 53;
	private long storageMoney_; // 0x110
	public const int TeamLatestIdFieldNumber = 54;
	private int teamLatestId_; // 0x118
	public const int LastSavedTimeFieldNumber = 55;
	private int lastSavedTime_; // 0x11C
	public const int ExpLimitCheckFieldNumber = 56;
	private int expLimitCheck_; // 0x120
	public const int ExpLimitReceivedFieldNumber = 57;
	private uint expLimitReceived_; // 0x124
	public const int ExpLimitMaximumFieldNumber = 58;
	private uint expLimitMaximum_; // 0x128

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<Character> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Cid { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Account { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Sex { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Sect { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RevivalOnLogin { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TongIdentify { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long BagarateMoney { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Series { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TeamId { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Level { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Exp { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Power { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Agility { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Outer { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Inside { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Luck { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxLife { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxStamina { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MaxInner { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LeftProp { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LeftFight { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int FightMode { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ArmorRes { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WeaponRes { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HelmRes { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HorseRes { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Camp { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MapId { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MapX { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MapY { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CurLife { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CurInner { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CurStamina { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WorldRank { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StorageCellMaximum { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int BagarateCellMaximum { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int PkStatus { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Pkvalue { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TongIndex { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RevivalMapId { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RevivalMapX { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RevivalMapY { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Knb { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CampCurrently { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int RunSpeed { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Action { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Direction { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AttackSpeed { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CastSpeed { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int StateStature { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TitleCurrently { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long StorageMoney { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int TeamLatestId { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LastSavedTime { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ExpLimitCheck { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ExpLimitReceived { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ExpLimitMaximum { get; set; }

	// Methods

	// RVA: 0x16DDAA4 Offset: 0x16D9AA4 VA: 0x16DDAA4
	public static MessageParser<Character> get_Parser() { }

	// RVA: 0x16DDAFC Offset: 0x16D9AFC VA: 0x16DDAFC
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16DDC00 Offset: 0x16D9C00 VA: 0x16DDC00 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DDC4C Offset: 0x16D9C4C VA: 0x16DDC4C
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DDCE4 Offset: 0x16D9CE4 VA: 0x16DDCE4
	public void .ctor(Character other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DDE1C Offset: 0x16D9E1C VA: 0x16DDE1C Slot: 10
	public Character Clone() { }

	// RVA: 0x16DDE74 Offset: 0x16D9E74 VA: 0x16DDE74
	public string get_Cid() { }

	// RVA: 0x16DDE7C Offset: 0x16D9E7C VA: 0x16DDE7C
	public void set_Cid(string value) { }

	// RVA: 0x16DDEF8 Offset: 0x16D9EF8 VA: 0x16DDEF8
	public string get_Account() { }

	// RVA: 0x16DDF00 Offset: 0x16D9F00 VA: 0x16DDF00
	public void set_Account(string value) { }

	// RVA: 0x16DDF7C Offset: 0x16D9F7C VA: 0x16DDF7C
	public string get_Name() { }

	// RVA: 0x16DDF84 Offset: 0x16D9F84 VA: 0x16DDF84
	public void set_Name(string value) { }

	// RVA: 0x16DE000 Offset: 0x16DA000 VA: 0x16DE000
	public int get_Sex() { }

	// RVA: 0x16DE008 Offset: 0x16DA008 VA: 0x16DE008
	public void set_Sex(int value) { }

	// RVA: 0x16DE010 Offset: 0x16DA010 VA: 0x16DE010
	public int get_Sect() { }

	// RVA: 0x16DE018 Offset: 0x16DA018 VA: 0x16DE018
	public void set_Sect(int value) { }

	// RVA: 0x16DE020 Offset: 0x16DA020 VA: 0x16DE020
	public int get_RevivalOnLogin() { }

	// RVA: 0x16DE028 Offset: 0x16DA028 VA: 0x16DE028
	public void set_RevivalOnLogin(int value) { }

	// RVA: 0x16DE030 Offset: 0x16DA030 VA: 0x16DE030
	public string get_TongIdentify() { }

	// RVA: 0x16DE038 Offset: 0x16DA038 VA: 0x16DE038
	public void set_TongIdentify(string value) { }

	// RVA: 0x16DE0B4 Offset: 0x16DA0B4 VA: 0x16DE0B4
	public long get_BagarateMoney() { }

	// RVA: 0x16DE0BC Offset: 0x16DA0BC VA: 0x16DE0BC
	public void set_BagarateMoney(long value) { }

	// RVA: 0x16DE0C4 Offset: 0x16DA0C4 VA: 0x16DE0C4
	public int get_Series() { }

	// RVA: 0x16DE0CC Offset: 0x16DA0CC VA: 0x16DE0CC
	public void set_Series(int value) { }

	// RVA: 0x16DE0D4 Offset: 0x16DA0D4 VA: 0x16DE0D4
	public int get_TeamId() { }

	// RVA: 0x16DE0DC Offset: 0x16DA0DC VA: 0x16DE0DC
	public void set_TeamId(int value) { }

	// RVA: 0x16DE0E4 Offset: 0x16DA0E4 VA: 0x16DE0E4
	public int get_Level() { }

	// RVA: 0x16DE0EC Offset: 0x16DA0EC VA: 0x16DE0EC
	public void set_Level(int value) { }

	// RVA: 0x16DE0F4 Offset: 0x16DA0F4 VA: 0x16DE0F4
	public long get_Exp() { }

	// RVA: 0x16DE0FC Offset: 0x16DA0FC VA: 0x16DE0FC
	public void set_Exp(long value) { }

	// RVA: 0x16DE104 Offset: 0x16DA104 VA: 0x16DE104
	public int get_Power() { }

	// RVA: 0x16DE10C Offset: 0x16DA10C VA: 0x16DE10C
	public void set_Power(int value) { }

	// RVA: 0x16DE114 Offset: 0x16DA114 VA: 0x16DE114
	public int get_Agility() { }

	// RVA: 0x16DE11C Offset: 0x16DA11C VA: 0x16DE11C
	public void set_Agility(int value) { }

	// RVA: 0x16DE124 Offset: 0x16DA124 VA: 0x16DE124
	public int get_Outer() { }

	// RVA: 0x16DE12C Offset: 0x16DA12C VA: 0x16DE12C
	public void set_Outer(int value) { }

	// RVA: 0x16DE134 Offset: 0x16DA134 VA: 0x16DE134
	public int get_Inside() { }

	// RVA: 0x16DE13C Offset: 0x16DA13C VA: 0x16DE13C
	public void set_Inside(int value) { }

	// RVA: 0x16DE144 Offset: 0x16DA144 VA: 0x16DE144
	public int get_Luck() { }

	// RVA: 0x16DE14C Offset: 0x16DA14C VA: 0x16DE14C
	public void set_Luck(int value) { }

	// RVA: 0x16DE154 Offset: 0x16DA154 VA: 0x16DE154
	public int get_MaxLife() { }

	// RVA: 0x16DE15C Offset: 0x16DA15C VA: 0x16DE15C
	public void set_MaxLife(int value) { }

	// RVA: 0x16DE164 Offset: 0x16DA164 VA: 0x16DE164
	public int get_MaxStamina() { }

	// RVA: 0x16DE16C Offset: 0x16DA16C VA: 0x16DE16C
	public void set_MaxStamina(int value) { }

	// RVA: 0x16DE174 Offset: 0x16DA174 VA: 0x16DE174
	public int get_MaxInner() { }

	// RVA: 0x16DE17C Offset: 0x16DA17C VA: 0x16DE17C
	public void set_MaxInner(int value) { }

	// RVA: 0x16DE184 Offset: 0x16DA184 VA: 0x16DE184
	public int get_LeftProp() { }

	// RVA: 0x16DE18C Offset: 0x16DA18C VA: 0x16DE18C
	public void set_LeftProp(int value) { }

	// RVA: 0x16DE194 Offset: 0x16DA194 VA: 0x16DE194
	public int get_LeftFight() { }

	// RVA: 0x16DE19C Offset: 0x16DA19C VA: 0x16DE19C
	public void set_LeftFight(int value) { }

	// RVA: 0x16DE1A4 Offset: 0x16DA1A4 VA: 0x16DE1A4
	public int get_FightMode() { }

	// RVA: 0x16DE1AC Offset: 0x16DA1AC VA: 0x16DE1AC
	public void set_FightMode(int value) { }

	// RVA: 0x16DE1B4 Offset: 0x16DA1B4 VA: 0x16DE1B4
	public int get_ArmorRes() { }

	// RVA: 0x16DE1BC Offset: 0x16DA1BC VA: 0x16DE1BC
	public void set_ArmorRes(int value) { }

	// RVA: 0x16DE1C4 Offset: 0x16DA1C4 VA: 0x16DE1C4
	public int get_WeaponRes() { }

	// RVA: 0x16DE1CC Offset: 0x16DA1CC VA: 0x16DE1CC
	public void set_WeaponRes(int value) { }

	// RVA: 0x16DE1D4 Offset: 0x16DA1D4 VA: 0x16DE1D4
	public int get_HelmRes() { }

	// RVA: 0x16DE1DC Offset: 0x16DA1DC VA: 0x16DE1DC
	public void set_HelmRes(int value) { }

	// RVA: 0x16DE1E4 Offset: 0x16DA1E4 VA: 0x16DE1E4
	public int get_HorseRes() { }

	// RVA: 0x16DE1EC Offset: 0x16DA1EC VA: 0x16DE1EC
	public void set_HorseRes(int value) { }

	// RVA: 0x16DE1F4 Offset: 0x16DA1F4 VA: 0x16DE1F4
	public int get_Camp() { }

	// RVA: 0x16DE1FC Offset: 0x16DA1FC VA: 0x16DE1FC
	public void set_Camp(int value) { }

	// RVA: 0x16DE204 Offset: 0x16DA204 VA: 0x16DE204
	public int get_MapId() { }

	// RVA: 0x16DE20C Offset: 0x16DA20C VA: 0x16DE20C
	public void set_MapId(int value) { }

	// RVA: 0x16DE214 Offset: 0x16DA214 VA: 0x16DE214
	public int get_MapX() { }

	// RVA: 0x16DE21C Offset: 0x16DA21C VA: 0x16DE21C
	public void set_MapX(int value) { }

	// RVA: 0x16DE224 Offset: 0x16DA224 VA: 0x16DE224
	public int get_MapY() { }

	// RVA: 0x16DE22C Offset: 0x16DA22C VA: 0x16DE22C
	public void set_MapY(int value) { }

	// RVA: 0x16DE234 Offset: 0x16DA234 VA: 0x16DE234
	public int get_CurLife() { }

	// RVA: 0x16DE23C Offset: 0x16DA23C VA: 0x16DE23C
	public void set_CurLife(int value) { }

	// RVA: 0x16DE244 Offset: 0x16DA244 VA: 0x16DE244
	public int get_CurInner() { }

	// RVA: 0x16DE24C Offset: 0x16DA24C VA: 0x16DE24C
	public void set_CurInner(int value) { }

	// RVA: 0x16DE254 Offset: 0x16DA254 VA: 0x16DE254
	public int get_CurStamina() { }

	// RVA: 0x16DE25C Offset: 0x16DA25C VA: 0x16DE25C
	public void set_CurStamina(int value) { }

	// RVA: 0x16DE264 Offset: 0x16DA264 VA: 0x16DE264
	public int get_WorldRank() { }

	// RVA: 0x16DE26C Offset: 0x16DA26C VA: 0x16DE26C
	public void set_WorldRank(int value) { }

	// RVA: 0x16DE274 Offset: 0x16DA274 VA: 0x16DE274
	public int get_StorageCellMaximum() { }

	// RVA: 0x16DE27C Offset: 0x16DA27C VA: 0x16DE27C
	public void set_StorageCellMaximum(int value) { }

	// RVA: 0x16DE284 Offset: 0x16DA284 VA: 0x16DE284
	public int get_BagarateCellMaximum() { }

	// RVA: 0x16DE28C Offset: 0x16DA28C VA: 0x16DE28C
	public void set_BagarateCellMaximum(int value) { }

	// RVA: 0x16DE294 Offset: 0x16DA294 VA: 0x16DE294
	public int get_PkStatus() { }

	// RVA: 0x16DE29C Offset: 0x16DA29C VA: 0x16DE29C
	public void set_PkStatus(int value) { }

	// RVA: 0x16DE2A4 Offset: 0x16DA2A4 VA: 0x16DE2A4
	public int get_Pkvalue() { }

	// RVA: 0x16DE2AC Offset: 0x16DA2AC VA: 0x16DE2AC
	public void set_Pkvalue(int value) { }

	// RVA: 0x16DE2B4 Offset: 0x16DA2B4 VA: 0x16DE2B4
	public int get_TongIndex() { }

	// RVA: 0x16DE2BC Offset: 0x16DA2BC VA: 0x16DE2BC
	public void set_TongIndex(int value) { }

	// RVA: 0x16DE2C4 Offset: 0x16DA2C4 VA: 0x16DE2C4
	public int get_RevivalMapId() { }

	// RVA: 0x16DE2CC Offset: 0x16DA2CC VA: 0x16DE2CC
	public void set_RevivalMapId(int value) { }

	// RVA: 0x16DE2D4 Offset: 0x16DA2D4 VA: 0x16DE2D4
	public int get_RevivalMapX() { }

	// RVA: 0x16DE2DC Offset: 0x16DA2DC VA: 0x16DE2DC
	public void set_RevivalMapX(int value) { }

	// RVA: 0x16DE2E4 Offset: 0x16DA2E4 VA: 0x16DE2E4
	public int get_RevivalMapY() { }

	// RVA: 0x16DE2EC Offset: 0x16DA2EC VA: 0x16DE2EC
	public void set_RevivalMapY(int value) { }

	// RVA: 0x16DE2F4 Offset: 0x16DA2F4 VA: 0x16DE2F4
	public int get_Knb() { }

	// RVA: 0x16DE2FC Offset: 0x16DA2FC VA: 0x16DE2FC
	public void set_Knb(int value) { }

	// RVA: 0x16DE304 Offset: 0x16DA304 VA: 0x16DE304
	public int get_CampCurrently() { }

	// RVA: 0x16DE30C Offset: 0x16DA30C VA: 0x16DE30C
	public void set_CampCurrently(int value) { }

	// RVA: 0x16DE314 Offset: 0x16DA314 VA: 0x16DE314
	public int get_RunSpeed() { }

	// RVA: 0x16DE31C Offset: 0x16DA31C VA: 0x16DE31C
	public void set_RunSpeed(int value) { }

	// RVA: 0x16DE324 Offset: 0x16DA324 VA: 0x16DE324
	public int get_Action() { }

	// RVA: 0x16DE32C Offset: 0x16DA32C VA: 0x16DE32C
	public void set_Action(int value) { }

	// RVA: 0x16DE334 Offset: 0x16DA334 VA: 0x16DE334
	public int get_Direction() { }

	// RVA: 0x16DE33C Offset: 0x16DA33C VA: 0x16DE33C
	public void set_Direction(int value) { }

	// RVA: 0x16DE344 Offset: 0x16DA344 VA: 0x16DE344
	public int get_AttackSpeed() { }

	// RVA: 0x16DE34C Offset: 0x16DA34C VA: 0x16DE34C
	public void set_AttackSpeed(int value) { }

	// RVA: 0x16DE354 Offset: 0x16DA354 VA: 0x16DE354
	public int get_CastSpeed() { }

	// RVA: 0x16DE35C Offset: 0x16DA35C VA: 0x16DE35C
	public void set_CastSpeed(int value) { }

	// RVA: 0x16DE364 Offset: 0x16DA364 VA: 0x16DE364
	public int get_StateStature() { }

	// RVA: 0x16DE36C Offset: 0x16DA36C VA: 0x16DE36C
	public void set_StateStature(int value) { }

	// RVA: 0x16DE374 Offset: 0x16DA374 VA: 0x16DE374
	public string get_TitleCurrently() { }

	// RVA: 0x16DE37C Offset: 0x16DA37C VA: 0x16DE37C
	public void set_TitleCurrently(string value) { }

	// RVA: 0x16DE3F8 Offset: 0x16DA3F8 VA: 0x16DE3F8
	public long get_StorageMoney() { }

	// RVA: 0x16DE400 Offset: 0x16DA400 VA: 0x16DE400
	public void set_StorageMoney(long value) { }

	// RVA: 0x16DE408 Offset: 0x16DA408 VA: 0x16DE408
	public int get_TeamLatestId() { }

	// RVA: 0x16DE410 Offset: 0x16DA410 VA: 0x16DE410
	public void set_TeamLatestId(int value) { }

	// RVA: 0x16DE418 Offset: 0x16DA418 VA: 0x16DE418
	public int get_LastSavedTime() { }

	// RVA: 0x16DE420 Offset: 0x16DA420 VA: 0x16DE420
	public void set_LastSavedTime(int value) { }

	// RVA: 0x16DE428 Offset: 0x16DA428 VA: 0x16DE428
	public int get_ExpLimitCheck() { }

	// RVA: 0x16DE430 Offset: 0x16DA430 VA: 0x16DE430
	public void set_ExpLimitCheck(int value) { }

	// RVA: 0x16DE438 Offset: 0x16DA438 VA: 0x16DE438
	public uint get_ExpLimitReceived() { }

	// RVA: 0x16DE440 Offset: 0x16DA440 VA: 0x16DE440
	public void set_ExpLimitReceived(uint value) { }

	// RVA: 0x16DE448 Offset: 0x16DA448 VA: 0x16DE448
	public uint get_ExpLimitMaximum() { }

	// RVA: 0x16DE450 Offset: 0x16DA450 VA: 0x16DE450
	public void set_ExpLimitMaximum(uint value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DE458 Offset: 0x16DA458 VA: 0x16DE458 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DE4BC Offset: 0x16DA4BC VA: 0x16DE4BC Slot: 9
	public bool Equals(Character other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DE8BC Offset: 0x16DA8BC VA: 0x16DE8BC Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DEF74 Offset: 0x16DAF74 VA: 0x16DEF74 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DEFCC Offset: 0x16DAFCC VA: 0x16DEFCC Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DEFEC Offset: 0x16DAFEC VA: 0x16DEFEC Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16DFA0C Offset: 0x16DBA0C VA: 0x16DFA0C Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16E0494 Offset: 0x16DC494 VA: 0x16E0494 Slot: 4
	public void MergeFrom(Character other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16E07D4 Offset: 0x16DC7D4 VA: 0x16E07D4 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16E07F4 Offset: 0x16DC7F4 VA: 0x16E07F4 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16E1848 Offset: 0x16DD848 VA: 0x16E1848
	private static void .cctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 5135
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 5136
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
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 5137
{
	// Methods

	// RVA: 0x1DB01D8 Offset: 0x1DAC1D8 VA: 0x1DB01D8
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x1DB02CC Offset: 0x1DAC2CC VA: 0x1DB02CC
	public void .ctor() { }
}
