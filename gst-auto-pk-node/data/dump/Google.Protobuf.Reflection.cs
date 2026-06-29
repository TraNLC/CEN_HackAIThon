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

// Namespace: Google.Protobuf.Reflection
public static class DescriptorReflection // TypeDefIndex: 6398
{
	// Fields
	private static FileDescriptor descriptor; // 0x0

	// Properties
	public static FileDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x15F5C78 Offset: 0x15F1C78 VA: 0x15F5C78
	public static FileDescriptor get_Descriptor() { }

	// RVA: 0x15F5CD0 Offset: 0x15F1CD0 VA: 0x15F5CD0
	private static void .cctor() { }
}

// Namespace: Google.Protobuf.Reflection
public enum Edition // TypeDefIndex: 6399
{
	// Fields
	public int value__; // 0x0
	[OriginalName("EDITION_UNKNOWN")]
	public const Edition Unknown = 0;
	[OriginalName("EDITION_LEGACY")]
	public const Edition Legacy = 900;
	[OriginalName("EDITION_PROTO2")]
	public const Edition Proto2 = 998;
	[OriginalName("EDITION_PROTO3")]
	public const Edition Proto3 = 999;
	[OriginalName("EDITION_2023")]
	public const Edition _2023 = 1000;
	[OriginalName("EDITION_2024")]
	public const Edition _2024 = 1001;
	[OriginalName("EDITION_1_TEST_ONLY")]
	public const Edition _1TestOnly = 1;
	[OriginalName("EDITION_2_TEST_ONLY")]
	public const Edition _2TestOnly = 2;
	[OriginalName("EDITION_99997_TEST_ONLY")]
	public const Edition _99997TestOnly = 99997;
	[OriginalName("EDITION_99998_TEST_ONLY")]
	public const Edition _99998TestOnly = 99998;
	[OriginalName("EDITION_99999_TEST_ONLY")]
	public const Edition _99999TestOnly = 99999;
	[OriginalName("EDITION_MAX")]
	public const Edition Max = 2147483647;
}

// Namespace: Google.Protobuf.Reflection
public enum SymbolVisibility // TypeDefIndex: 6400
{
	// Fields
	public int value__; // 0x0
	[OriginalName("VISIBILITY_UNSET")]
	public const SymbolVisibility VisibilityUnset = 0;
	[OriginalName("VISIBILITY_LOCAL")]
	public const SymbolVisibility VisibilityLocal = 1;
	[OriginalName("VISIBILITY_EXPORT")]
	public const SymbolVisibility VisibilityExport = 2;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FileDescriptorSet.<>c // TypeDefIndex: 6401
{
	// Fields
	public static readonly FileDescriptorSet.<>c <>9; // 0x0

	// Methods

	// RVA: 0x15FDF5C Offset: 0x15F9F5C VA: 0x15FDF5C
	private static void .cctor() { }

	// RVA: 0x15FDFC4 Offset: 0x15F9FC4 VA: 0x15FDFC4
	public void .ctor() { }

	// RVA: 0x15FDFCC Offset: 0x15F9FCC VA: 0x15FDFCC
	internal FileDescriptorSet <.cctor>b__37_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FileDescriptorSet : IExtendableMessage<FileDescriptorSet>, IMessage<FileDescriptorSet>, IMessage, IEquatable<FileDescriptorSet>, IDeepCloneable<FileDescriptorSet>, IBufferMessage // TypeDefIndex: 6402
{
	// Fields
	private static readonly MessageParser<FileDescriptorSet> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	internal ExtensionSet<FileDescriptorSet> _extensions; // 0x18
	private static readonly FieldCodec<FileDescriptorProto> _repeated_file_codec; // 0x8
	private readonly RepeatedField<FileDescriptorProto> file_; // 0x20

	// Properties
	private ExtensionSet<FileDescriptorSet> _Extensions { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FileDescriptorSet> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FileDescriptorProto> File { get; }

	// Methods

	// RVA: 0x15FD49C Offset: 0x15F949C VA: 0x15FD49C
	private ExtensionSet<FileDescriptorSet> get__Extensions() { }

	// RVA: 0x15FD4A4 Offset: 0x15F94A4 VA: 0x15FD4A4
	public static MessageParser<FileDescriptorSet> get_Parser() { }

	// RVA: 0x15FD4FC Offset: 0x15F94FC VA: 0x15FD4FC
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15FD600 Offset: 0x15F9600 VA: 0x15FD600 Slot: 14
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FD64C Offset: 0x15F964C VA: 0x15FD64C
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FD6D4 Offset: 0x15F96D4 VA: 0x15FD6D4
	public void .ctor(FileDescriptorSet other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FD790 Offset: 0x15F9790 VA: 0x15FD790 Slot: 16
	public FileDescriptorSet Clone() { }

	// RVA: 0x15FD7E8 Offset: 0x15F97E8 VA: 0x15FD7E8
	public RepeatedField<FileDescriptorProto> get_File() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FD7F0 Offset: 0x15F97F0 VA: 0x15FD7F0 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FD854 Offset: 0x15F9854 VA: 0x15FD854 Slot: 15
	public bool Equals(FileDescriptorSet other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FD8F8 Offset: 0x15F98F8 VA: 0x15FD8F8 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FD964 Offset: 0x15F9964 VA: 0x15FD964 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FD9BC Offset: 0x15F99BC VA: 0x15FD9BC Slot: 12
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FD9DC Offset: 0x15F99DC VA: 0x15FD9DC Slot: 18
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FDABC Offset: 0x15F9ABC VA: 0x15FDABC Slot: 13
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FDB8C Offset: 0x15F9B8C VA: 0x15FDB8C Slot: 10
	public void MergeFrom(FileDescriptorSet other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FDC38 Offset: 0x15F9C38 VA: 0x15FDC38 Slot: 11
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FDC58 Offset: 0x15F9C58 VA: 0x15FDC58 Slot: 17
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: -1 Offset: -1 Slot: 4
	public TValue GetExtension<TValue>(Extension<FileDescriptorSet, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114DB0 Offset: 0x1110DB0 VA: 0x1114DB0
	|-FileDescriptorSet.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FileDescriptorSet, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114E74 Offset: 0x1110E74 VA: 0x1114E74
	|-FileDescriptorSet.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<FileDescriptorSet, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114EB8 Offset: 0x1110EB8 VA: 0x1114EB8
	|-FileDescriptorSet.GetOrInitializeExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SetExtension<TValue>(Extension<FileDescriptorSet, TValue> extension, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114F40 Offset: 0x1110F40 VA: 0x1114F40
	|-FileDescriptorSet.SetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasExtension<TValue>(Extension<FileDescriptorSet, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114EFC Offset: 0x1110EFC VA: 0x1114EFC
	|-FileDescriptorSet.HasExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void ClearExtension<TValue>(Extension<FileDescriptorSet, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114D28 Offset: 0x1110D28 VA: 0x1114D28
	|-FileDescriptorSet.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void ClearExtension<TValue>(RepeatedExtension<FileDescriptorSet, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114D6C Offset: 0x1110D6C VA: 0x1114D6C
	|-FileDescriptorSet.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15FDDAC Offset: 0x15F9DAC VA: 0x15FDDAC
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FileDescriptorProto.<>c // TypeDefIndex: 6403
{
	// Fields
	public static readonly FileDescriptorProto.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1600350 Offset: 0x15FC350 VA: 0x1600350
	private static void .cctor() { }

	// RVA: 0x16003B8 Offset: 0x15FC3B8 VA: 0x16003B8
	public void .ctor() { }

	// RVA: 0x16003C0 Offset: 0x15FC3C0 VA: 0x16003C0
	internal FileDescriptorProto <.cctor>b__109_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FileDescriptorProto : IMessage<FileDescriptorProto>, IMessage, IEquatable<FileDescriptorProto>, IDeepCloneable<FileDescriptorProto>, IBufferMessage // TypeDefIndex: 6404
{
	// Fields
	private static readonly MessageParser<FileDescriptorProto> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly string NameDefaultValue; // 0x8
	private string name_; // 0x20
	private static readonly string PackageDefaultValue; // 0x10
	private string package_; // 0x28
	private static readonly FieldCodec<string> _repeated_dependency_codec; // 0x18
	private readonly RepeatedField<string> dependency_; // 0x30
	private static readonly FieldCodec<int> _repeated_publicDependency_codec; // 0x20
	private readonly RepeatedField<int> publicDependency_; // 0x38
	private static readonly FieldCodec<int> _repeated_weakDependency_codec; // 0x28
	private readonly RepeatedField<int> weakDependency_; // 0x40
	private static readonly FieldCodec<string> _repeated_optionDependency_codec; // 0x30
	private readonly RepeatedField<string> optionDependency_; // 0x48
	private static readonly FieldCodec<DescriptorProto> _repeated_messageType_codec; // 0x38
	private readonly RepeatedField<DescriptorProto> messageType_; // 0x50
	private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; // 0x40
	private readonly RepeatedField<EnumDescriptorProto> enumType_; // 0x58
	private static readonly FieldCodec<ServiceDescriptorProto> _repeated_service_codec; // 0x48
	private readonly RepeatedField<ServiceDescriptorProto> service_; // 0x60
	private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec; // 0x50
	private readonly RepeatedField<FieldDescriptorProto> extension_; // 0x68
	private FileOptions options_; // 0x70
	private SourceCodeInfo sourceCodeInfo_; // 0x78
	private static readonly string SyntaxDefaultValue; // 0x58
	private string syntax_; // 0x80
	private static readonly Edition EditionDefaultValue; // 0x60
	private Edition edition_; // 0x88

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FileDescriptorProto> Parser { get; }
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
	public bool HasName { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Package { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPackage { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> Dependency { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> PublicDependency { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> WeakDependency { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> OptionDependency { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DescriptorProto> MessageType { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EnumDescriptorProto> EnumType { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ServiceDescriptorProto> Service { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FieldDescriptorProto> Extension { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FileOptions Options { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SourceCodeInfo SourceCodeInfo { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Syntax { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasSyntax { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Edition Edition { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEdition { get; }

	// Methods

	// RVA: 0x15FE01C Offset: 0x15FA01C VA: 0x15FE01C
	public static MessageParser<FileDescriptorProto> get_Parser() { }

	// RVA: 0x15FE074 Offset: 0x15FA074 VA: 0x15FE074
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x15FE178 Offset: 0x15FA178 VA: 0x15FE178 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FE1C4 Offset: 0x15FA1C4 VA: 0x15FE1C4
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FE428 Offset: 0x15FA428 VA: 0x15FE428
	public void .ctor(FileDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FE690 Offset: 0x15FA690 VA: 0x15FE690 Slot: 10
	public FileDescriptorProto Clone() { }

	// RVA: 0x15FE6E8 Offset: 0x15FA6E8 VA: 0x15FE6E8
	public string get_Name() { }

	// RVA: 0x15FE74C Offset: 0x15FA74C VA: 0x15FE74C
	public void set_Name(string value) { }

	// RVA: 0x15FE7C8 Offset: 0x15FA7C8 VA: 0x15FE7C8
	public bool get_HasName() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FE7D8 Offset: 0x15FA7D8 VA: 0x15FE7D8
	public void ClearName() { }

	// RVA: 0x15FE7E4 Offset: 0x15FA7E4 VA: 0x15FE7E4
	public string get_Package() { }

	// RVA: 0x15FE848 Offset: 0x15FA848 VA: 0x15FE848
	public void set_Package(string value) { }

	// RVA: 0x15FE8C4 Offset: 0x15FA8C4 VA: 0x15FE8C4
	public bool get_HasPackage() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FE8D4 Offset: 0x15FA8D4 VA: 0x15FE8D4
	public void ClearPackage() { }

	// RVA: 0x15FE8E0 Offset: 0x15FA8E0 VA: 0x15FE8E0
	public RepeatedField<string> get_Dependency() { }

	// RVA: 0x15FE8E8 Offset: 0x15FA8E8 VA: 0x15FE8E8
	public RepeatedField<int> get_PublicDependency() { }

	// RVA: 0x15FE8F0 Offset: 0x15FA8F0 VA: 0x15FE8F0
	public RepeatedField<int> get_WeakDependency() { }

	// RVA: 0x15FE8F8 Offset: 0x15FA8F8 VA: 0x15FE8F8
	public RepeatedField<string> get_OptionDependency() { }

	// RVA: 0x15FE900 Offset: 0x15FA900 VA: 0x15FE900
	public RepeatedField<DescriptorProto> get_MessageType() { }

	// RVA: 0x15FE908 Offset: 0x15FA908 VA: 0x15FE908
	public RepeatedField<EnumDescriptorProto> get_EnumType() { }

	// RVA: 0x15FE910 Offset: 0x15FA910 VA: 0x15FE910
	public RepeatedField<ServiceDescriptorProto> get_Service() { }

	// RVA: 0x15FE918 Offset: 0x15FA918 VA: 0x15FE918
	public RepeatedField<FieldDescriptorProto> get_Extension() { }

	// RVA: 0x15FE920 Offset: 0x15FA920 VA: 0x15FE920
	public FileOptions get_Options() { }

	// RVA: 0x15FE928 Offset: 0x15FA928 VA: 0x15FE928
	public void set_Options(FileOptions value) { }

	// RVA: 0x15FE930 Offset: 0x15FA930 VA: 0x15FE930
	public SourceCodeInfo get_SourceCodeInfo() { }

	// RVA: 0x15FE938 Offset: 0x15FA938 VA: 0x15FE938
	public void set_SourceCodeInfo(SourceCodeInfo value) { }

	// RVA: 0x15FE940 Offset: 0x15FA940 VA: 0x15FE940
	public string get_Syntax() { }

	// RVA: 0x15FE9A4 Offset: 0x15FA9A4 VA: 0x15FE9A4
	public void set_Syntax(string value) { }

	// RVA: 0x15FEA20 Offset: 0x15FAA20 VA: 0x15FEA20
	public bool get_HasSyntax() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FEA30 Offset: 0x15FAA30 VA: 0x15FEA30
	public void ClearSyntax() { }

	// RVA: 0x15FEA3C Offset: 0x15FAA3C VA: 0x15FEA3C
	public Edition get_Edition() { }

	// RVA: 0x15FEAAC Offset: 0x15FAAAC VA: 0x15FEAAC
	public void set_Edition(Edition value) { }

	// RVA: 0x15FEAC0 Offset: 0x15FAAC0 VA: 0x15FEAC0
	public bool get_HasEdition() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FEACC Offset: 0x15FAACC VA: 0x15FEACC
	public void ClearEdition() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FEADC Offset: 0x15FAADC VA: 0x15FEADC Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FEB40 Offset: 0x15FAB40 VA: 0x15FEB40 Slot: 9
	public bool Equals(FileDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FEDA4 Offset: 0x15FADA4 VA: 0x15FEDA4 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FEFC4 Offset: 0x15FAFC4 VA: 0x15FEFC4 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FF01C Offset: 0x15FB01C VA: 0x15FF01C Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FF03C Offset: 0x15FB03C VA: 0x15FF03C Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FF37C Offset: 0x15FB37C VA: 0x15FF37C Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FF71C Offset: 0x15FB71C VA: 0x15FF71C Slot: 4
	public void MergeFrom(FileDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FF9D4 Offset: 0x15FB9D4 VA: 0x15FF9D4 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x15FF9F4 Offset: 0x15FB9F4 VA: 0x15FF9F4 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x15FFEE0 Offset: 0x15FBEE0 VA: 0x15FFEE0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DescriptorProto.Types.ExtensionRange.<>c // TypeDefIndex: 6405
{
	// Fields
	public static readonly DescriptorProto.Types.ExtensionRange.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16030F4 Offset: 0x15FF0F4 VA: 0x16030F4
	private static void .cctor() { }

	// RVA: 0x160315C Offset: 0x15FF15C VA: 0x160315C
	public void .ctor() { }

	// RVA: 0x1603164 Offset: 0x15FF164 VA: 0x1603164
	internal DescriptorProto.Types.ExtensionRange <.cctor>b__46_0() { }
}

// Namespace: 
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DescriptorProto.Types.ExtensionRange : IMessage<DescriptorProto.Types.ExtensionRange>, IMessage, IEquatable<DescriptorProto.Types.ExtensionRange>, IDeepCloneable<DescriptorProto.Types.ExtensionRange>, IBufferMessage // TypeDefIndex: 6406
{
	// Fields
	private static readonly MessageParser<DescriptorProto.Types.ExtensionRange> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly int StartDefaultValue; // 0x8
	private int start_; // 0x1C
	private static readonly int EndDefaultValue; // 0xC
	private int end_; // 0x20
	private ExtensionRangeOptions options_; // 0x28

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DescriptorProto.Types.ExtensionRange> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Start { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasStart { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int End { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEnd { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExtensionRangeOptions Options { get; set; }

	// Methods

	// RVA: 0x16022A8 Offset: 0x15FE2A8 VA: 0x16022A8
	public static MessageParser<DescriptorProto.Types.ExtensionRange> get_Parser() { }

	// RVA: 0x1602300 Offset: 0x15FE300 VA: 0x1602300
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16023CC Offset: 0x15FE3CC VA: 0x16023CC Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1602418 Offset: 0x15FE418 VA: 0x1602418
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1602420 Offset: 0x15FE420 VA: 0x1602420
	public void .ctor(DescriptorProto.Types.ExtensionRange other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16024F0 Offset: 0x15FE4F0 VA: 0x16024F0 Slot: 10
	public DescriptorProto.Types.ExtensionRange Clone() { }

	// RVA: 0x1602548 Offset: 0x15FE548 VA: 0x1602548
	public int get_Start() { }

	// RVA: 0x16025B8 Offset: 0x15FE5B8 VA: 0x16025B8
	public void set_Start(int value) { }

	// RVA: 0x16025C8 Offset: 0x15FE5C8 VA: 0x16025C8
	public bool get_HasStart() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16025D4 Offset: 0x15FE5D4 VA: 0x16025D4
	public void ClearStart() { }

	// RVA: 0x16025E4 Offset: 0x15FE5E4 VA: 0x16025E4
	public int get_End() { }

	// RVA: 0x1602654 Offset: 0x15FE654 VA: 0x1602654
	public void set_End(int value) { }

	// RVA: 0x1602668 Offset: 0x15FE668 VA: 0x1602668
	public bool get_HasEnd() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1602674 Offset: 0x15FE674 VA: 0x1602674
	public void ClearEnd() { }

	// RVA: 0x1602684 Offset: 0x15FE684 VA: 0x1602684
	public ExtensionRangeOptions get_Options() { }

	// RVA: 0x160268C Offset: 0x15FE68C VA: 0x160268C
	public void set_Options(ExtensionRangeOptions value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1602694 Offset: 0x15FE694 VA: 0x1602694 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16026F8 Offset: 0x15FE6F8 VA: 0x16026F8 Slot: 9
	public bool Equals(DescriptorProto.Types.ExtensionRange other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1602790 Offset: 0x15FE790 VA: 0x1602790 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1602834 Offset: 0x15FE834 VA: 0x1602834 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160288C Offset: 0x15FE88C VA: 0x160288C Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16028AC Offset: 0x15FE8AC VA: 0x16028AC Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160296C Offset: 0x15FE96C VA: 0x160296C Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1602A78 Offset: 0x15FEA78 VA: 0x1602A78 Slot: 4
	public void MergeFrom(DescriptorProto.Types.ExtensionRange other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1602DB8 Offset: 0x15FEDB8 VA: 0x1602DB8 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1602DD8 Offset: 0x15FEDD8 VA: 0x1602DD8 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x1602FCC Offset: 0x15FEFCC VA: 0x1602FCC
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DescriptorProto.Types.ReservedRange.<>c // TypeDefIndex: 6407
{
	// Fields
	public static readonly DescriptorProto.Types.ReservedRange.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1603B80 Offset: 0x15FFB80 VA: 0x1603B80
	private static void .cctor() { }

	// RVA: 0x1603BE8 Offset: 0x15FFBE8 VA: 0x1603BE8
	public void .ctor() { }

	// RVA: 0x1603BF0 Offset: 0x15FFBF0 VA: 0x1603BF0
	internal DescriptorProto.Types.ReservedRange <.cctor>b__41_0() { }
}

// Namespace: 
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DescriptorProto.Types.ReservedRange : IMessage<DescriptorProto.Types.ReservedRange>, IMessage, IEquatable<DescriptorProto.Types.ReservedRange>, IDeepCloneable<DescriptorProto.Types.ReservedRange>, IBufferMessage // TypeDefIndex: 6408
{
	// Fields
	private static readonly MessageParser<DescriptorProto.Types.ReservedRange> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly int StartDefaultValue; // 0x8
	private int start_; // 0x1C
	private static readonly int EndDefaultValue; // 0xC
	private int end_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DescriptorProto.Types.ReservedRange> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Start { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasStart { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int End { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEnd { get; }

	// Methods

	// RVA: 0x16031B8 Offset: 0x15FF1B8 VA: 0x16031B8
	public static MessageParser<DescriptorProto.Types.ReservedRange> get_Parser() { }

	// RVA: 0x1603210 Offset: 0x15FF210 VA: 0x1603210
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16032DC Offset: 0x15FF2DC VA: 0x16032DC Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1603328 Offset: 0x15FF328 VA: 0x1603328
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1603330 Offset: 0x15FF330 VA: 0x1603330
	public void .ctor(DescriptorProto.Types.ReservedRange other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1603384 Offset: 0x15FF384 VA: 0x1603384 Slot: 10
	public DescriptorProto.Types.ReservedRange Clone() { }

	// RVA: 0x16033DC Offset: 0x15FF3DC VA: 0x16033DC
	public int get_Start() { }

	// RVA: 0x160344C Offset: 0x15FF44C VA: 0x160344C
	public void set_Start(int value) { }

	// RVA: 0x160345C Offset: 0x15FF45C VA: 0x160345C
	public bool get_HasStart() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1603468 Offset: 0x15FF468 VA: 0x1603468
	public void ClearStart() { }

	// RVA: 0x1603478 Offset: 0x15FF478 VA: 0x1603478
	public int get_End() { }

	// RVA: 0x16034E8 Offset: 0x15FF4E8 VA: 0x16034E8
	public void set_End(int value) { }

	// RVA: 0x16034FC Offset: 0x15FF4FC VA: 0x16034FC
	public bool get_HasEnd() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1603508 Offset: 0x15FF508 VA: 0x1603508
	public void ClearEnd() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1603518 Offset: 0x15FF518 VA: 0x1603518 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160357C Offset: 0x15FF57C VA: 0x160357C Slot: 9
	public bool Equals(DescriptorProto.Types.ReservedRange other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1603600 Offset: 0x15FF600 VA: 0x1603600 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160368C Offset: 0x15FF68C VA: 0x160368C Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16036E4 Offset: 0x15FF6E4 VA: 0x16036E4 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1603704 Offset: 0x15FF704 VA: 0x1603704 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160379C Offset: 0x15FF79C VA: 0x160379C Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1603874 Offset: 0x15FF874 VA: 0x1603874 Slot: 4
	public void MergeFrom(DescriptorProto.Types.ReservedRange other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16038F4 Offset: 0x15FF8F4 VA: 0x16038F4 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1603914 Offset: 0x15FF914 VA: 0x1603914 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x1603A58 Offset: 0x15FFA58 VA: 0x1603A58
	private static void .cctor() { }
}

// Namespace: 
[DebuggerNonUserCode]
[GeneratedCode("protoc", null)]
public static class DescriptorProto.Types // TypeDefIndex: 6409
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DescriptorProto.<>c // TypeDefIndex: 6410
{
	// Fields
	public static readonly DescriptorProto.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1603C44 Offset: 0x15FFC44 VA: 0x1603C44
	private static void .cctor() { }

	// RVA: 0x1603CAC Offset: 0x15FFCAC VA: 0x1603CAC
	public void .ctor() { }

	// RVA: 0x1603CB4 Offset: 0x15FFCB4 VA: 0x1603CB4
	internal DescriptorProto <.cctor>b__87_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DescriptorProto : IMessage<DescriptorProto>, IMessage, IEquatable<DescriptorProto>, IDeepCloneable<DescriptorProto>, IBufferMessage // TypeDefIndex: 6411
{
	// Fields
	private static readonly MessageParser<DescriptorProto> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly string NameDefaultValue; // 0x8
	private string name_; // 0x20
	private static readonly FieldCodec<FieldDescriptorProto> _repeated_field_codec; // 0x10
	private readonly RepeatedField<FieldDescriptorProto> field_; // 0x28
	private static readonly FieldCodec<FieldDescriptorProto> _repeated_extension_codec; // 0x18
	private readonly RepeatedField<FieldDescriptorProto> extension_; // 0x30
	private static readonly FieldCodec<DescriptorProto> _repeated_nestedType_codec; // 0x20
	private readonly RepeatedField<DescriptorProto> nestedType_; // 0x38
	private static readonly FieldCodec<EnumDescriptorProto> _repeated_enumType_codec; // 0x28
	private readonly RepeatedField<EnumDescriptorProto> enumType_; // 0x40
	private static readonly FieldCodec<DescriptorProto.Types.ExtensionRange> _repeated_extensionRange_codec; // 0x30
	private readonly RepeatedField<DescriptorProto.Types.ExtensionRange> extensionRange_; // 0x48
	private static readonly FieldCodec<OneofDescriptorProto> _repeated_oneofDecl_codec; // 0x38
	private readonly RepeatedField<OneofDescriptorProto> oneofDecl_; // 0x50
	private MessageOptions options_; // 0x58
	private static readonly FieldCodec<DescriptorProto.Types.ReservedRange> _repeated_reservedRange_codec; // 0x40
	private readonly RepeatedField<DescriptorProto.Types.ReservedRange> reservedRange_; // 0x60
	private static readonly FieldCodec<string> _repeated_reservedName_codec; // 0x48
	private readonly RepeatedField<string> reservedName_; // 0x68
	private static readonly SymbolVisibility VisibilityDefaultValue; // 0x50
	private SymbolVisibility visibility_; // 0x70

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DescriptorProto> Parser { get; }
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
	public bool HasName { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FieldDescriptorProto> Field { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FieldDescriptorProto> Extension { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DescriptorProto> NestedType { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EnumDescriptorProto> EnumType { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DescriptorProto.Types.ExtensionRange> ExtensionRange { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<OneofDescriptorProto> OneofDecl { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MessageOptions Options { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<DescriptorProto.Types.ReservedRange> ReservedRange { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> ReservedName { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SymbolVisibility Visibility { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasVisibility { get; }

	// Methods

	// RVA: 0x1600410 Offset: 0x15FC410 VA: 0x1600410
	public static MessageParser<DescriptorProto> get_Parser() { }

	// RVA: 0x1600468 Offset: 0x15FC468 VA: 0x1600468
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x160056C Offset: 0x15FC56C VA: 0x160056C Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16005B8 Offset: 0x15FC5B8 VA: 0x16005B8
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1600844 Offset: 0x15FC844 VA: 0x1600844
	public void .ctor(DescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1600A70 Offset: 0x15FCA70 VA: 0x1600A70 Slot: 10
	public DescriptorProto Clone() { }

	// RVA: 0x1600AC8 Offset: 0x15FCAC8 VA: 0x1600AC8
	public string get_Name() { }

	// RVA: 0x1600B2C Offset: 0x15FCB2C VA: 0x1600B2C
	public void set_Name(string value) { }

	// RVA: 0x1600BA8 Offset: 0x15FCBA8 VA: 0x1600BA8
	public bool get_HasName() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1600BB8 Offset: 0x15FCBB8 VA: 0x1600BB8
	public void ClearName() { }

	// RVA: 0x1600BC4 Offset: 0x15FCBC4 VA: 0x1600BC4
	public RepeatedField<FieldDescriptorProto> get_Field() { }

	// RVA: 0x1600BCC Offset: 0x15FCBCC VA: 0x1600BCC
	public RepeatedField<FieldDescriptorProto> get_Extension() { }

	// RVA: 0x1600BD4 Offset: 0x15FCBD4 VA: 0x1600BD4
	public RepeatedField<DescriptorProto> get_NestedType() { }

	// RVA: 0x1600BDC Offset: 0x15FCBDC VA: 0x1600BDC
	public RepeatedField<EnumDescriptorProto> get_EnumType() { }

	// RVA: 0x1600BE4 Offset: 0x15FCBE4 VA: 0x1600BE4
	public RepeatedField<DescriptorProto.Types.ExtensionRange> get_ExtensionRange() { }

	// RVA: 0x1600BEC Offset: 0x15FCBEC VA: 0x1600BEC
	public RepeatedField<OneofDescriptorProto> get_OneofDecl() { }

	// RVA: 0x1600BF4 Offset: 0x15FCBF4 VA: 0x1600BF4
	public MessageOptions get_Options() { }

	// RVA: 0x1600BFC Offset: 0x15FCBFC VA: 0x1600BFC
	public void set_Options(MessageOptions value) { }

	// RVA: 0x1600C04 Offset: 0x15FCC04 VA: 0x1600C04
	public RepeatedField<DescriptorProto.Types.ReservedRange> get_ReservedRange() { }

	// RVA: 0x1600C0C Offset: 0x15FCC0C VA: 0x1600C0C
	public RepeatedField<string> get_ReservedName() { }

	// RVA: 0x1600C14 Offset: 0x15FCC14 VA: 0x1600C14
	public SymbolVisibility get_Visibility() { }

	// RVA: 0x1600C84 Offset: 0x15FCC84 VA: 0x1600C84
	public void set_Visibility(SymbolVisibility value) { }

	// RVA: 0x1600C98 Offset: 0x15FCC98 VA: 0x1600C98
	public bool get_HasVisibility() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1600CA4 Offset: 0x15FCCA4 VA: 0x1600CA4
	public void ClearVisibility() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1600CB4 Offset: 0x15FCCB4 VA: 0x1600CB4 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1600D18 Offset: 0x15FCD18 VA: 0x1600D18 Slot: 9
	public bool Equals(DescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1600F20 Offset: 0x15FCF20 VA: 0x1600F20 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16010C0 Offset: 0x15FD0C0 VA: 0x16010C0 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1601118 Offset: 0x15FD118 VA: 0x1601118 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1601138 Offset: 0x15FD138 VA: 0x1601138 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16013E4 Offset: 0x15FD3E4 VA: 0x16013E4 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16016F0 Offset: 0x15FD6F0 VA: 0x16016F0 Slot: 4
	public void MergeFrom(DescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1601924 Offset: 0x15FD924 VA: 0x1601924 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1601944 Offset: 0x15FD944 VA: 0x1601944 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x1601D64 Offset: 0x15FDD64 VA: 0x1601D64
	private static void .cctor() { }
}

// Namespace: 
public enum ExtensionRangeOptions.Types.VerificationState // TypeDefIndex: 6412
{
	// Fields
	public int value__; // 0x0
	[OriginalName("DECLARATION")]
	public const ExtensionRangeOptions.Types.VerificationState Declaration = 0;
	[OriginalName("UNVERIFIED")]
	public const ExtensionRangeOptions.Types.VerificationState Unverified = 1;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ExtensionRangeOptions.Types.Declaration.<>c // TypeDefIndex: 6413
{
	// Fields
	public static readonly ExtensionRangeOptions.Types.Declaration.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1605B34 Offset: 0x1601B34 VA: 0x1605B34
	private static void .cctor() { }

	// RVA: 0x1605B9C Offset: 0x1601B9C VA: 0x1605B9C
	public void .ctor() { }

	// RVA: 0x1605BA4 Offset: 0x1601BA4 VA: 0x1605BA4
	internal ExtensionRangeOptions.Types.Declaration <.cctor>b__68_0() { }
}

// Namespace: 
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExtensionRangeOptions.Types.Declaration : IMessage<ExtensionRangeOptions.Types.Declaration>, IMessage, IEquatable<ExtensionRangeOptions.Types.Declaration>, IDeepCloneable<ExtensionRangeOptions.Types.Declaration>, IBufferMessage // TypeDefIndex: 6414
{
	// Fields
	private static readonly MessageParser<ExtensionRangeOptions.Types.Declaration> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly int NumberDefaultValue; // 0x8
	private int number_; // 0x1C
	private static readonly string FullNameDefaultValue; // 0x10
	private string fullName_; // 0x20
	private static readonly string TypeDefaultValue; // 0x18
	private string type_; // 0x28
	private static readonly bool ReservedDefaultValue; // 0x20
	private bool reserved_; // 0x30
	private static readonly bool RepeatedDefaultValue; // 0x21
	private bool repeated_; // 0x31

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExtensionRangeOptions.Types.Declaration> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Number { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasNumber { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string FullName { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFullName { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Type { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasType { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Reserved { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasReserved { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Repeated { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRepeated { get; }

	// Methods

	// RVA: 0x1604B60 Offset: 0x1600B60 VA: 0x1604B60
	public static MessageParser<ExtensionRangeOptions.Types.Declaration> get_Parser() { }

	// RVA: 0x1604BB8 Offset: 0x1600BB8 VA: 0x1604BB8
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x1604C84 Offset: 0x1600C84 VA: 0x1604C84 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1604CD0 Offset: 0x1600CD0 VA: 0x1604CD0
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1604CD8 Offset: 0x1600CD8 VA: 0x1604CD8
	public void .ctor(ExtensionRangeOptions.Types.Declaration other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1604D4C Offset: 0x1600D4C VA: 0x1604D4C Slot: 10
	public ExtensionRangeOptions.Types.Declaration Clone() { }

	// RVA: 0x1604DA4 Offset: 0x1600DA4 VA: 0x1604DA4
	public int get_Number() { }

	// RVA: 0x1604E14 Offset: 0x1600E14 VA: 0x1604E14
	public void set_Number(int value) { }

	// RVA: 0x1604E24 Offset: 0x1600E24 VA: 0x1604E24
	public bool get_HasNumber() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1604E30 Offset: 0x1600E30 VA: 0x1604E30
	public void ClearNumber() { }

	// RVA: 0x1604E40 Offset: 0x1600E40 VA: 0x1604E40
	public string get_FullName() { }

	// RVA: 0x1604EA4 Offset: 0x1600EA4 VA: 0x1604EA4
	public void set_FullName(string value) { }

	// RVA: 0x1604F20 Offset: 0x1600F20 VA: 0x1604F20
	public bool get_HasFullName() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1604F30 Offset: 0x1600F30 VA: 0x1604F30
	public void ClearFullName() { }

	// RVA: 0x1604F3C Offset: 0x1600F3C VA: 0x1604F3C
	public string get_Type() { }

	// RVA: 0x1604FA0 Offset: 0x1600FA0 VA: 0x1604FA0
	public void set_Type(string value) { }

	// RVA: 0x160501C Offset: 0x160101C VA: 0x160501C
	public bool get_HasType() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160502C Offset: 0x160102C VA: 0x160502C
	public void ClearType() { }

	// RVA: 0x1605038 Offset: 0x1601038 VA: 0x1605038
	public bool get_Reserved() { }

	// RVA: 0x16050A8 Offset: 0x16010A8 VA: 0x16050A8
	public void set_Reserved(bool value) { }

	// RVA: 0x16050BC Offset: 0x16010BC VA: 0x16050BC
	public bool get_HasReserved() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16050C8 Offset: 0x16010C8 VA: 0x16050C8
	public void ClearReserved() { }

	// RVA: 0x16050D8 Offset: 0x16010D8 VA: 0x16050D8
	public bool get_Repeated() { }

	// RVA: 0x1605148 Offset: 0x1601148 VA: 0x1605148
	public void set_Repeated(bool value) { }

	// RVA: 0x160515C Offset: 0x160115C VA: 0x160515C
	public bool get_HasRepeated() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1605168 Offset: 0x1601168 VA: 0x1605168
	public void ClearRepeated() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1605178 Offset: 0x1601178 VA: 0x1605178 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16051DC Offset: 0x16011DC VA: 0x16051DC Slot: 9
	public bool Equals(ExtensionRangeOptions.Types.Declaration other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16052CC Offset: 0x16012CC VA: 0x16052CC Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1605408 Offset: 0x1601408 VA: 0x1605408 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1605460 Offset: 0x1601460 VA: 0x1605460 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1605480 Offset: 0x1601480 VA: 0x1605480 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16055A8 Offset: 0x16015A8 VA: 0x16055A8 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16056D8 Offset: 0x16016D8 VA: 0x16056D8 Slot: 4
	public void MergeFrom(ExtensionRangeOptions.Types.Declaration other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16057B4 Offset: 0x16017B4 VA: 0x16057B4 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16057D4 Offset: 0x16017D4 VA: 0x16057D4 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16059CC Offset: 0x16019CC VA: 0x16059CC
	private static void .cctor() { }
}

// Namespace: 
[DebuggerNonUserCode]
[GeneratedCode("protoc", null)]
public static class ExtensionRangeOptions.Types // TypeDefIndex: 6415
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ExtensionRangeOptions.<>c // TypeDefIndex: 6416
{
	// Fields
	public static readonly ExtensionRangeOptions.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1605BF8 Offset: 0x1601BF8 VA: 0x1605BF8
	private static void .cctor() { }

	// RVA: 0x1605C60 Offset: 0x1601C60 VA: 0x1605C60
	public void .ctor() { }

	// RVA: 0x1605C68 Offset: 0x1601C68 VA: 0x1605C68
	internal ExtensionRangeOptions <.cctor>b__58_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ExtensionRangeOptions : IExtendableMessage<ExtensionRangeOptions>, IMessage<ExtensionRangeOptions>, IMessage, IEquatable<ExtensionRangeOptions>, IDeepCloneable<ExtensionRangeOptions>, IBufferMessage // TypeDefIndex: 6417
{
	// Fields
	private static readonly MessageParser<ExtensionRangeOptions> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	internal ExtensionSet<ExtensionRangeOptions> _extensions; // 0x18
	private int _hasBits0; // 0x20
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x8
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x28
	private static readonly FieldCodec<ExtensionRangeOptions.Types.Declaration> _repeated_declaration_codec; // 0x10
	private readonly RepeatedField<ExtensionRangeOptions.Types.Declaration> declaration_; // 0x30
	private FeatureSet features_; // 0x38
	private static readonly ExtensionRangeOptions.Types.VerificationState VerificationDefaultValue; // 0x18
	private ExtensionRangeOptions.Types.VerificationState verification_; // 0x40

	// Properties
	private ExtensionSet<ExtensionRangeOptions> _Extensions { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ExtensionRangeOptions> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<UninterpretedOption> UninterpretedOption { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<ExtensionRangeOptions.Types.Declaration> Declaration { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet Features { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ExtensionRangeOptions.Types.VerificationState Verification { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasVerification { get; }

	// Methods

	// RVA: 0x1603D04 Offset: 0x15FFD04 VA: 0x1603D04
	private ExtensionSet<ExtensionRangeOptions> get__Extensions() { }

	// RVA: 0x1603D0C Offset: 0x15FFD0C VA: 0x1603D0C
	public static MessageParser<ExtensionRangeOptions> get_Parser() { }

	// RVA: 0x1603D64 Offset: 0x15FFD64 VA: 0x1603D64
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x1603E68 Offset: 0x15FFE68 VA: 0x1603E68 Slot: 14
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1602B7C Offset: 0x15FEB7C VA: 0x1602B7C
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1603EB4 Offset: 0x15FFEB4 VA: 0x1603EB4
	public void .ctor(ExtensionRangeOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1602498 Offset: 0x15FE498 VA: 0x1602498 Slot: 16
	public ExtensionRangeOptions Clone() { }

	// RVA: 0x1603FDC Offset: 0x15FFFDC VA: 0x1603FDC
	public RepeatedField<UninterpretedOption> get_UninterpretedOption() { }

	// RVA: 0x1603FE4 Offset: 0x15FFFE4 VA: 0x1603FE4
	public RepeatedField<ExtensionRangeOptions.Types.Declaration> get_Declaration() { }

	// RVA: 0x1603FEC Offset: 0x15FFFEC VA: 0x1603FEC
	public FeatureSet get_Features() { }

	// RVA: 0x1603FF4 Offset: 0x15FFFF4 VA: 0x1603FF4
	public void set_Features(FeatureSet value) { }

	// RVA: 0x1603FFC Offset: 0x15FFFFC VA: 0x1603FFC
	public ExtensionRangeOptions.Types.VerificationState get_Verification() { }

	// RVA: 0x160406C Offset: 0x160006C VA: 0x160406C
	public void set_Verification(ExtensionRangeOptions.Types.VerificationState value) { }

	// RVA: 0x1604080 Offset: 0x1600080 VA: 0x1604080
	public bool get_HasVerification() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160408C Offset: 0x160008C VA: 0x160408C
	public void ClearVerification() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160409C Offset: 0x160009C VA: 0x160409C Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1604100 Offset: 0x1600100 VA: 0x1604100 Slot: 15
	public bool Equals(ExtensionRangeOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1604200 Offset: 0x1600200 VA: 0x1604200 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16042CC Offset: 0x16002CC VA: 0x16042CC Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1604324 Offset: 0x1600324 VA: 0x1604324 Slot: 12
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1604344 Offset: 0x1600344 VA: 0x1604344 Slot: 18
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16044C8 Offset: 0x16004C8 VA: 0x16044C8 Slot: 13
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1602C58 Offset: 0x15FEC58 VA: 0x1602C58 Slot: 10
	public void MergeFrom(ExtensionRangeOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1604650 Offset: 0x1600650 VA: 0x1604650 Slot: 11
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1604670 Offset: 0x1600670 VA: 0x1604670 Slot: 17
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: -1 Offset: -1 Slot: 4
	public TValue GetExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1110380 Offset: 0x110C380 VA: 0x1110380
	|-ExtensionRangeOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1110444 Offset: 0x110C444 VA: 0x1110444
	|-ExtensionRangeOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1110488 Offset: 0x110C488 VA: 0x1110488
	|-ExtensionRangeOptions.GetOrInitializeExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SetExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1110510 Offset: 0x110C510 VA: 0x1110510
	|-ExtensionRangeOptions.SetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11104CC Offset: 0x110C4CC VA: 0x11104CC
	|-ExtensionRangeOptions.HasExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void ClearExtension<TValue>(Extension<ExtensionRangeOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11102F8 Offset: 0x110C2F8 VA: 0x11102F8
	|-ExtensionRangeOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void ClearExtension<TValue>(RepeatedExtension<ExtensionRangeOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111033C Offset: 0x110C33C VA: 0x111033C
	|-ExtensionRangeOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1604904 Offset: 0x1600904 VA: 0x1604904
	private static void .cctor() { }
}

// Namespace: 
public enum FieldDescriptorProto.Types.Type // TypeDefIndex: 6418
{
	// Fields
	public int value__; // 0x0
	[OriginalName("TYPE_DOUBLE")]
	public const FieldDescriptorProto.Types.Type Double = 1;
	[OriginalName("TYPE_FLOAT")]
	public const FieldDescriptorProto.Types.Type Float = 2;
	[OriginalName("TYPE_INT64")]
	public const FieldDescriptorProto.Types.Type Int64 = 3;
	[OriginalName("TYPE_UINT64")]
	public const FieldDescriptorProto.Types.Type Uint64 = 4;
	[OriginalName("TYPE_INT32")]
	public const FieldDescriptorProto.Types.Type Int32 = 5;
	[OriginalName("TYPE_FIXED64")]
	public const FieldDescriptorProto.Types.Type Fixed64 = 6;
	[OriginalName("TYPE_FIXED32")]
	public const FieldDescriptorProto.Types.Type Fixed32 = 7;
	[OriginalName("TYPE_BOOL")]
	public const FieldDescriptorProto.Types.Type Bool = 8;
	[OriginalName("TYPE_STRING")]
	public const FieldDescriptorProto.Types.Type String = 9;
	[OriginalName("TYPE_GROUP")]
	public const FieldDescriptorProto.Types.Type Group = 10;
	[OriginalName("TYPE_MESSAGE")]
	public const FieldDescriptorProto.Types.Type Message = 11;
	[OriginalName("TYPE_BYTES")]
	public const FieldDescriptorProto.Types.Type Bytes = 12;
	[OriginalName("TYPE_UINT32")]
	public const FieldDescriptorProto.Types.Type Uint32 = 13;
	[OriginalName("TYPE_ENUM")]
	public const FieldDescriptorProto.Types.Type Enum = 14;
	[OriginalName("TYPE_SFIXED32")]
	public const FieldDescriptorProto.Types.Type Sfixed32 = 15;
	[OriginalName("TYPE_SFIXED64")]
	public const FieldDescriptorProto.Types.Type Sfixed64 = 16;
	[OriginalName("TYPE_SINT32")]
	public const FieldDescriptorProto.Types.Type Sint32 = 17;
	[OriginalName("TYPE_SINT64")]
	public const FieldDescriptorProto.Types.Type Sint64 = 18;
}

// Namespace: 
public enum FieldDescriptorProto.Types.Label // TypeDefIndex: 6419
{
	// Fields
	public int value__; // 0x0
	[OriginalName("LABEL_OPTIONAL")]
	public const FieldDescriptorProto.Types.Label Optional = 1;
	[OriginalName("LABEL_REPEATED")]
	public const FieldDescriptorProto.Types.Label Repeated = 3;
	[OriginalName("LABEL_REQUIRED")]
	public const FieldDescriptorProto.Types.Label Required = 2;
}

// Namespace: 
[DebuggerNonUserCode]
[GeneratedCode("protoc", null)]
public static class FieldDescriptorProto.Types // TypeDefIndex: 6420
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FieldDescriptorProto.<>c // TypeDefIndex: 6421
{
	// Fields
	public static readonly FieldDescriptorProto.<>c <>9; // 0x0

	// Methods

	// RVA: 0x160790C Offset: 0x160390C VA: 0x160790C
	private static void .cctor() { }

	// RVA: 0x1607974 Offset: 0x1603974 VA: 0x1607974
	public void .ctor() { }

	// RVA: 0x160797C Offset: 0x160397C VA: 0x160797C
	internal FieldDescriptorProto <.cctor>b__119_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FieldDescriptorProto : IMessage<FieldDescriptorProto>, IMessage, IEquatable<FieldDescriptorProto>, IDeepCloneable<FieldDescriptorProto>, IBufferMessage // TypeDefIndex: 6422
{
	// Fields
	private static readonly MessageParser<FieldDescriptorProto> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly string NameDefaultValue; // 0x8
	private string name_; // 0x20
	private static readonly int NumberDefaultValue; // 0x10
	private int number_; // 0x28
	private static readonly FieldDescriptorProto.Types.Label LabelDefaultValue; // 0x14
	private FieldDescriptorProto.Types.Label label_; // 0x2C
	private static readonly FieldDescriptorProto.Types.Type TypeDefaultValue; // 0x18
	private FieldDescriptorProto.Types.Type type_; // 0x30
	private static readonly string TypeNameDefaultValue; // 0x20
	private string typeName_; // 0x38
	private static readonly string ExtendeeDefaultValue; // 0x28
	private string extendee_; // 0x40
	private static readonly string DefaultValueDefaultValue; // 0x30
	private string defaultValue_; // 0x48
	private static readonly int OneofIndexDefaultValue; // 0x38
	private int oneofIndex_; // 0x50
	private static readonly string JsonNameDefaultValue; // 0x40
	private string jsonName_; // 0x58
	private FieldOptions options_; // 0x60
	private static readonly bool Proto3OptionalDefaultValue; // 0x48
	private bool proto3Optional_; // 0x68

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldDescriptorProto> Parser { get; }
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
	public bool HasName { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Number { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasNumber { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldDescriptorProto.Types.Label Label { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasLabel { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldDescriptorProto.Types.Type Type { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasType { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TypeName { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasTypeName { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Extendee { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasExtendee { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DefaultValue { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDefaultValue { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int OneofIndex { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasOneofIndex { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string JsonName { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJsonName { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldOptions Options { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Proto3Optional { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasProto3Optional { get; }

	// Methods

	// RVA: 0x1605CB8 Offset: 0x1601CB8 VA: 0x1605CB8
	public static MessageParser<FieldDescriptorProto> get_Parser() { }

	// RVA: 0x1605D10 Offset: 0x1601D10 VA: 0x1605D10
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x1605E14 Offset: 0x1601E14 VA: 0x1605E14 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1605E60 Offset: 0x1601E60 VA: 0x1605E60
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1605E68 Offset: 0x1601E68 VA: 0x1605E68
	public void .ctor(FieldDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1605F4C Offset: 0x1601F4C VA: 0x1605F4C Slot: 10
	public FieldDescriptorProto Clone() { }

	// RVA: 0x1605FA4 Offset: 0x1601FA4 VA: 0x1605FA4
	public string get_Name() { }

	// RVA: 0x1606008 Offset: 0x1602008 VA: 0x1606008
	public void set_Name(string value) { }

	// RVA: 0x1606084 Offset: 0x1602084 VA: 0x1606084
	public bool get_HasName() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1606094 Offset: 0x1602094 VA: 0x1606094
	public void ClearName() { }

	// RVA: 0x16060A0 Offset: 0x16020A0 VA: 0x16060A0
	public int get_Number() { }

	// RVA: 0x1606110 Offset: 0x1602110 VA: 0x1606110
	public void set_Number(int value) { }

	// RVA: 0x1606124 Offset: 0x1602124 VA: 0x1606124
	public bool get_HasNumber() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1606130 Offset: 0x1602130 VA: 0x1606130
	public void ClearNumber() { }

	// RVA: 0x1606140 Offset: 0x1602140 VA: 0x1606140
	public FieldDescriptorProto.Types.Label get_Label() { }

	// RVA: 0x16061B0 Offset: 0x16021B0 VA: 0x16061B0
	public void set_Label(FieldDescriptorProto.Types.Label value) { }

	// RVA: 0x16061C4 Offset: 0x16021C4 VA: 0x16061C4
	public bool get_HasLabel() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16061D0 Offset: 0x16021D0 VA: 0x16061D0
	public void ClearLabel() { }

	// RVA: 0x16061E0 Offset: 0x16021E0 VA: 0x16061E0
	public FieldDescriptorProto.Types.Type get_Type() { }

	// RVA: 0x1606250 Offset: 0x1602250 VA: 0x1606250
	public void set_Type(FieldDescriptorProto.Types.Type value) { }

	// RVA: 0x1606264 Offset: 0x1602264 VA: 0x1606264
	public bool get_HasType() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1606270 Offset: 0x1602270 VA: 0x1606270
	public void ClearType() { }

	// RVA: 0x1606280 Offset: 0x1602280 VA: 0x1606280
	public string get_TypeName() { }

	// RVA: 0x16062E4 Offset: 0x16022E4 VA: 0x16062E4
	public void set_TypeName(string value) { }

	// RVA: 0x1606360 Offset: 0x1602360 VA: 0x1606360
	public bool get_HasTypeName() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1606370 Offset: 0x1602370 VA: 0x1606370
	public void ClearTypeName() { }

	// RVA: 0x160637C Offset: 0x160237C VA: 0x160637C
	public string get_Extendee() { }

	// RVA: 0x16063E0 Offset: 0x16023E0 VA: 0x16063E0
	public void set_Extendee(string value) { }

	// RVA: 0x160645C Offset: 0x160245C VA: 0x160645C
	public bool get_HasExtendee() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160646C Offset: 0x160246C VA: 0x160646C
	public void ClearExtendee() { }

	// RVA: 0x1606478 Offset: 0x1602478 VA: 0x1606478
	public string get_DefaultValue() { }

	// RVA: 0x16064DC Offset: 0x16024DC VA: 0x16064DC
	public void set_DefaultValue(string value) { }

	// RVA: 0x1606558 Offset: 0x1602558 VA: 0x1606558
	public bool get_HasDefaultValue() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1606568 Offset: 0x1602568 VA: 0x1606568
	public void ClearDefaultValue() { }

	// RVA: 0x1606574 Offset: 0x1602574 VA: 0x1606574
	public int get_OneofIndex() { }

	// RVA: 0x16065E4 Offset: 0x16025E4 VA: 0x16065E4
	public void set_OneofIndex(int value) { }

	// RVA: 0x16065F8 Offset: 0x16025F8 VA: 0x16065F8
	public bool get_HasOneofIndex() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1606604 Offset: 0x1602604 VA: 0x1606604
	public void ClearOneofIndex() { }

	// RVA: 0x1606614 Offset: 0x1602614 VA: 0x1606614
	public string get_JsonName() { }

	// RVA: 0x1606678 Offset: 0x1602678 VA: 0x1606678
	public void set_JsonName(string value) { }

	// RVA: 0x16066F4 Offset: 0x16026F4 VA: 0x16066F4
	public bool get_HasJsonName() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1606704 Offset: 0x1602704 VA: 0x1606704
	public void ClearJsonName() { }

	// RVA: 0x1606710 Offset: 0x1602710 VA: 0x1606710
	public FieldOptions get_Options() { }

	// RVA: 0x1606718 Offset: 0x1602718 VA: 0x1606718
	public void set_Options(FieldOptions value) { }

	// RVA: 0x1606720 Offset: 0x1602720 VA: 0x1606720
	public bool get_Proto3Optional() { }

	// RVA: 0x1606790 Offset: 0x1602790 VA: 0x1606790
	public void set_Proto3Optional(bool value) { }

	// RVA: 0x16067A4 Offset: 0x16027A4 VA: 0x16067A4
	public bool get_HasProto3Optional() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16067B0 Offset: 0x16027B0 VA: 0x16067B0
	public void ClearProto3Optional() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16067C0 Offset: 0x16027C0 VA: 0x16067C0 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1606824 Offset: 0x1602824 VA: 0x1606824 Slot: 9
	public bool Equals(FieldDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16069D8 Offset: 0x16029D8 VA: 0x16069D8 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1606BD4 Offset: 0x1602BD4 VA: 0x1606BD4 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1606C2C Offset: 0x1602C2C VA: 0x1606C2C Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1606C4C Offset: 0x1602C4C VA: 0x1606C4C Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1606E9C Offset: 0x1602E9C VA: 0x1606E9C Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1607164 Offset: 0x1603164 VA: 0x1607164 Slot: 4
	public void MergeFrom(FieldDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160736C Offset: 0x160336C VA: 0x160736C Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160738C Offset: 0x160338C VA: 0x160738C Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x1607754 Offset: 0x1603754 VA: 0x1607754
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class OneofDescriptorProto.<>c // TypeDefIndex: 6423
{
	// Fields
	public static readonly OneofDescriptorProto.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1608640 Offset: 0x1604640 VA: 0x1608640
	private static void .cctor() { }

	// RVA: 0x16086A8 Offset: 0x16046A8 VA: 0x16086A8
	public void .ctor() { }

	// RVA: 0x16086B0 Offset: 0x16046B0 VA: 0x16086B0
	internal OneofDescriptorProto <.cctor>b__36_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OneofDescriptorProto : IMessage<OneofDescriptorProto>, IMessage, IEquatable<OneofDescriptorProto>, IDeepCloneable<OneofDescriptorProto>, IBufferMessage // TypeDefIndex: 6424
{
	// Fields
	private static readonly MessageParser<OneofDescriptorProto> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private static readonly string NameDefaultValue; // 0x8
	private string name_; // 0x18
	private OneofOptions options_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OneofDescriptorProto> Parser { get; }
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
	public bool HasName { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OneofOptions Options { get; set; }

	// Methods

	// RVA: 0x16079D0 Offset: 0x16039D0 VA: 0x16079D0
	public static MessageParser<OneofDescriptorProto> get_Parser() { }

	// RVA: 0x1607A28 Offset: 0x1603A28 VA: 0x1607A28
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x1607B2C Offset: 0x1603B2C VA: 0x1607B2C Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1607B78 Offset: 0x1603B78 VA: 0x1607B78
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1607B80 Offset: 0x1603B80 VA: 0x1607B80
	public void .ctor(OneofDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1607C50 Offset: 0x1603C50 VA: 0x1607C50 Slot: 10
	public OneofDescriptorProto Clone() { }

	// RVA: 0x1607CA8 Offset: 0x1603CA8 VA: 0x1607CA8
	public string get_Name() { }

	// RVA: 0x1607D0C Offset: 0x1603D0C VA: 0x1607D0C
	public void set_Name(string value) { }

	// RVA: 0x1607D88 Offset: 0x1603D88 VA: 0x1607D88
	public bool get_HasName() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1607D98 Offset: 0x1603D98 VA: 0x1607D98
	public void ClearName() { }

	// RVA: 0x1607DA4 Offset: 0x1603DA4 VA: 0x1607DA4
	public OneofOptions get_Options() { }

	// RVA: 0x1607DAC Offset: 0x1603DAC VA: 0x1607DAC
	public void set_Options(OneofOptions value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1607DB4 Offset: 0x1603DB4 VA: 0x1607DB4 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1607E18 Offset: 0x1603E18 VA: 0x1607E18 Slot: 9
	public bool Equals(OneofDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1607EA0 Offset: 0x1603EA0 VA: 0x1607EA0 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1607F1C Offset: 0x1603F1C VA: 0x1607F1C Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1607F74 Offset: 0x1603F74 VA: 0x1607F74 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1607F94 Offset: 0x1603F94 VA: 0x1607F94 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1608024 Offset: 0x1604024 VA: 0x1608024 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16080F0 Offset: 0x16040F0 VA: 0x16080F0 Slot: 4
	public void MergeFrom(OneofDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1608370 Offset: 0x1604370 VA: 0x1608370 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1608390 Offset: 0x1604390 VA: 0x1608390 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x1608500 Offset: 0x1604500 VA: 0x1608500
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EnumDescriptorProto.Types.EnumReservedRange.<>c // TypeDefIndex: 6425
{
	// Fields
	public static readonly EnumDescriptorProto.Types.EnumReservedRange.<>c <>9; // 0x0

	// Methods

	// RVA: 0x160A72C Offset: 0x160672C VA: 0x160A72C
	private static void .cctor() { }

	// RVA: 0x160A794 Offset: 0x1606794 VA: 0x160A794
	public void .ctor() { }

	// RVA: 0x160A79C Offset: 0x160679C VA: 0x160A79C
	internal EnumDescriptorProto.Types.EnumReservedRange <.cctor>b__41_0() { }
}

// Namespace: 
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnumDescriptorProto.Types.EnumReservedRange : IMessage<EnumDescriptorProto.Types.EnumReservedRange>, IMessage, IEquatable<EnumDescriptorProto.Types.EnumReservedRange>, IDeepCloneable<EnumDescriptorProto.Types.EnumReservedRange>, IBufferMessage // TypeDefIndex: 6426
{
	// Fields
	private static readonly MessageParser<EnumDescriptorProto.Types.EnumReservedRange> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly int StartDefaultValue; // 0x8
	private int start_; // 0x1C
	private static readonly int EndDefaultValue; // 0xC
	private int end_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnumDescriptorProto.Types.EnumReservedRange> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Start { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasStart { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int End { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEnd { get; }

	// Methods

	// RVA: 0x1609D64 Offset: 0x1605D64 VA: 0x1609D64
	public static MessageParser<EnumDescriptorProto.Types.EnumReservedRange> get_Parser() { }

	// RVA: 0x1609DBC Offset: 0x1605DBC VA: 0x1609DBC
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x1609E88 Offset: 0x1605E88 VA: 0x1609E88 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1609ED4 Offset: 0x1605ED4 VA: 0x1609ED4
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1609EDC Offset: 0x1605EDC VA: 0x1609EDC
	public void .ctor(EnumDescriptorProto.Types.EnumReservedRange other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1609F30 Offset: 0x1605F30 VA: 0x1609F30 Slot: 10
	public EnumDescriptorProto.Types.EnumReservedRange Clone() { }

	// RVA: 0x1609F88 Offset: 0x1605F88 VA: 0x1609F88
	public int get_Start() { }

	// RVA: 0x1609FF8 Offset: 0x1605FF8 VA: 0x1609FF8
	public void set_Start(int value) { }

	// RVA: 0x160A008 Offset: 0x1606008 VA: 0x160A008
	public bool get_HasStart() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160A014 Offset: 0x1606014 VA: 0x160A014
	public void ClearStart() { }

	// RVA: 0x160A024 Offset: 0x1606024 VA: 0x160A024
	public int get_End() { }

	// RVA: 0x160A094 Offset: 0x1606094 VA: 0x160A094
	public void set_End(int value) { }

	// RVA: 0x160A0A8 Offset: 0x16060A8 VA: 0x160A0A8
	public bool get_HasEnd() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160A0B4 Offset: 0x16060B4 VA: 0x160A0B4
	public void ClearEnd() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160A0C4 Offset: 0x16060C4 VA: 0x160A0C4 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160A128 Offset: 0x1606128 VA: 0x160A128 Slot: 9
	public bool Equals(EnumDescriptorProto.Types.EnumReservedRange other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160A1AC Offset: 0x16061AC VA: 0x160A1AC Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160A238 Offset: 0x1606238 VA: 0x160A238 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160A290 Offset: 0x1606290 VA: 0x160A290 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160A2B0 Offset: 0x16062B0 VA: 0x160A2B0 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160A348 Offset: 0x1606348 VA: 0x160A348 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160A420 Offset: 0x1606420 VA: 0x160A420 Slot: 4
	public void MergeFrom(EnumDescriptorProto.Types.EnumReservedRange other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160A4A0 Offset: 0x16064A0 VA: 0x160A4A0 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160A4C0 Offset: 0x16064C0 VA: 0x160A4C0 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x160A604 Offset: 0x1606604 VA: 0x160A604
	private static void .cctor() { }
}

// Namespace: 
[DebuggerNonUserCode]
[GeneratedCode("protoc", null)]
public static class EnumDescriptorProto.Types // TypeDefIndex: 6427
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EnumDescriptorProto.<>c // TypeDefIndex: 6428
{
	// Fields
	public static readonly EnumDescriptorProto.<>c <>9; // 0x0

	// Methods

	// RVA: 0x160A7F0 Offset: 0x16067F0 VA: 0x160A7F0
	private static void .cctor() { }

	// RVA: 0x160A858 Offset: 0x1606858 VA: 0x160A858
	public void .ctor() { }

	// RVA: 0x160A860 Offset: 0x1606860 VA: 0x160A860
	internal EnumDescriptorProto <.cctor>b__62_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnumDescriptorProto : IMessage<EnumDescriptorProto>, IMessage, IEquatable<EnumDescriptorProto>, IDeepCloneable<EnumDescriptorProto>, IBufferMessage // TypeDefIndex: 6429
{
	// Fields
	private static readonly MessageParser<EnumDescriptorProto> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly string NameDefaultValue; // 0x8
	private string name_; // 0x20
	private static readonly FieldCodec<EnumValueDescriptorProto> _repeated_value_codec; // 0x10
	private readonly RepeatedField<EnumValueDescriptorProto> value_; // 0x28
	private EnumOptions options_; // 0x30
	private static readonly FieldCodec<EnumDescriptorProto.Types.EnumReservedRange> _repeated_reservedRange_codec; // 0x18
	private readonly RepeatedField<EnumDescriptorProto.Types.EnumReservedRange> reservedRange_; // 0x38
	private static readonly FieldCodec<string> _repeated_reservedName_codec; // 0x20
	private readonly RepeatedField<string> reservedName_; // 0x40
	private static readonly SymbolVisibility VisibilityDefaultValue; // 0x28
	private SymbolVisibility visibility_; // 0x48

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnumDescriptorProto> Parser { get; }
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
	public bool HasName { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EnumValueDescriptorProto> Value { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnumOptions Options { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<EnumDescriptorProto.Types.EnumReservedRange> ReservedRange { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> ReservedName { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SymbolVisibility Visibility { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasVisibility { get; }

	// Methods

	// RVA: 0x1608704 Offset: 0x1604704 VA: 0x1608704
	public static MessageParser<EnumDescriptorProto> get_Parser() { }

	// RVA: 0x160875C Offset: 0x160475C VA: 0x160875C
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x1608860 Offset: 0x1604860 VA: 0x1608860 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16088AC Offset: 0x16048AC VA: 0x16088AC
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16089DC Offset: 0x16049DC VA: 0x16089DC
	public void .ctor(EnumDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1608B6C Offset: 0x1604B6C VA: 0x1608B6C Slot: 10
	public EnumDescriptorProto Clone() { }

	// RVA: 0x1608BC4 Offset: 0x1604BC4 VA: 0x1608BC4
	public string get_Name() { }

	// RVA: 0x1608C28 Offset: 0x1604C28 VA: 0x1608C28
	public void set_Name(string value) { }

	// RVA: 0x1608CA4 Offset: 0x1604CA4 VA: 0x1608CA4
	public bool get_HasName() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1608CB4 Offset: 0x1604CB4 VA: 0x1608CB4
	public void ClearName() { }

	// RVA: 0x1608CC0 Offset: 0x1604CC0 VA: 0x1608CC0
	public RepeatedField<EnumValueDescriptorProto> get_Value() { }

	// RVA: 0x1608CC8 Offset: 0x1604CC8 VA: 0x1608CC8
	public EnumOptions get_Options() { }

	// RVA: 0x1608CD0 Offset: 0x1604CD0 VA: 0x1608CD0
	public void set_Options(EnumOptions value) { }

	// RVA: 0x1608CD8 Offset: 0x1604CD8 VA: 0x1608CD8
	public RepeatedField<EnumDescriptorProto.Types.EnumReservedRange> get_ReservedRange() { }

	// RVA: 0x1608CE0 Offset: 0x1604CE0 VA: 0x1608CE0
	public RepeatedField<string> get_ReservedName() { }

	// RVA: 0x1608CE8 Offset: 0x1604CE8 VA: 0x1608CE8
	public SymbolVisibility get_Visibility() { }

	// RVA: 0x1608D58 Offset: 0x1604D58 VA: 0x1608D58
	public void set_Visibility(SymbolVisibility value) { }

	// RVA: 0x1608D6C Offset: 0x1604D6C VA: 0x1608D6C
	public bool get_HasVisibility() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1608D78 Offset: 0x1604D78 VA: 0x1608D78
	public void ClearVisibility() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1608D88 Offset: 0x1604D88 VA: 0x1608D88 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1608DEC Offset: 0x1604DEC VA: 0x1608DEC Slot: 9
	public bool Equals(EnumDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1608F2C Offset: 0x1604F2C VA: 0x1608F2C Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1609020 Offset: 0x1605020 VA: 0x1609020 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1609078 Offset: 0x1605078 VA: 0x1609078 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1609098 Offset: 0x1605098 VA: 0x1609098 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1609254 Offset: 0x1605254 VA: 0x1609254 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160943C Offset: 0x160543C VA: 0x160943C Slot: 4
	public void MergeFrom(EnumDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16097CC Offset: 0x16057CC VA: 0x16097CC Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16097EC Offset: 0x16057EC VA: 0x16097EC Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x1609AB8 Offset: 0x1605AB8 VA: 0x1609AB8
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EnumValueDescriptorProto.<>c // TypeDefIndex: 6430
{
	// Fields
	public static readonly EnumValueDescriptorProto.<>c <>9; // 0x0

	// Methods

	// RVA: 0x160B7B4 Offset: 0x16077B4 VA: 0x160B7B4
	private static void .cctor() { }

	// RVA: 0x160B81C Offset: 0x160781C VA: 0x160B81C
	public void .ctor() { }

	// RVA: 0x160B824 Offset: 0x1607824 VA: 0x160B824
	internal EnumValueDescriptorProto <.cctor>b__46_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnumValueDescriptorProto : IMessage<EnumValueDescriptorProto>, IMessage, IEquatable<EnumValueDescriptorProto>, IDeepCloneable<EnumValueDescriptorProto>, IBufferMessage // TypeDefIndex: 6431
{
	// Fields
	private static readonly MessageParser<EnumValueDescriptorProto> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly string NameDefaultValue; // 0x8
	private string name_; // 0x20
	private static readonly int NumberDefaultValue; // 0x10
	private int number_; // 0x28
	private EnumValueOptions options_; // 0x30

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnumValueDescriptorProto> Parser { get; }
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
	public bool HasName { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Number { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasNumber { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EnumValueOptions Options { get; set; }

	// Methods

	// RVA: 0x160A8B0 Offset: 0x16068B0 VA: 0x160A8B0
	public static MessageParser<EnumValueDescriptorProto> get_Parser() { }

	// RVA: 0x160A908 Offset: 0x1606908 VA: 0x160A908
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x160AA0C Offset: 0x1606A0C VA: 0x160AA0C Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160AA58 Offset: 0x1606A58 VA: 0x160AA58
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160AA60 Offset: 0x1606A60 VA: 0x160AA60
	public void .ctor(EnumValueDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160AB44 Offset: 0x1606B44 VA: 0x160AB44 Slot: 10
	public EnumValueDescriptorProto Clone() { }

	// RVA: 0x160AB9C Offset: 0x1606B9C VA: 0x160AB9C
	public string get_Name() { }

	// RVA: 0x160AC00 Offset: 0x1606C00 VA: 0x160AC00
	public void set_Name(string value) { }

	// RVA: 0x160AC7C Offset: 0x1606C7C VA: 0x160AC7C
	public bool get_HasName() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160AC8C Offset: 0x1606C8C VA: 0x160AC8C
	public void ClearName() { }

	// RVA: 0x160AC98 Offset: 0x1606C98 VA: 0x160AC98
	public int get_Number() { }

	// RVA: 0x160AD08 Offset: 0x1606D08 VA: 0x160AD08
	public void set_Number(int value) { }

	// RVA: 0x160AD1C Offset: 0x1606D1C VA: 0x160AD1C
	public bool get_HasNumber() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160AD28 Offset: 0x1606D28 VA: 0x160AD28
	public void ClearNumber() { }

	// RVA: 0x160AD38 Offset: 0x1606D38 VA: 0x160AD38
	public EnumValueOptions get_Options() { }

	// RVA: 0x160AD40 Offset: 0x1606D40 VA: 0x160AD40
	public void set_Options(EnumValueOptions value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160AD48 Offset: 0x1606D48 VA: 0x160AD48 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160ADAC Offset: 0x1606DAC VA: 0x160ADAC Slot: 9
	public bool Equals(EnumValueDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160AE50 Offset: 0x1606E50 VA: 0x160AE50 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160AEF4 Offset: 0x1606EF4 VA: 0x160AEF4 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160AF4C Offset: 0x1606F4C VA: 0x160AF4C Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160AF6C Offset: 0x1606F6C VA: 0x160AF6C Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160B02C Offset: 0x160702C VA: 0x160B02C Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160B134 Offset: 0x1607134 VA: 0x160B134 Slot: 4
	public void MergeFrom(EnumValueDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160B478 Offset: 0x1607478 VA: 0x160B478 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160B498 Offset: 0x1607498 VA: 0x160B498 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x160B664 Offset: 0x1607664 VA: 0x160B664
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ServiceDescriptorProto.<>c // TypeDefIndex: 6432
{
	// Fields
	public static readonly ServiceDescriptorProto.<>c <>9; // 0x0

	// Methods

	// RVA: 0x160C858 Offset: 0x1608858 VA: 0x160C858
	private static void .cctor() { }

	// RVA: 0x160C8C0 Offset: 0x16088C0 VA: 0x160C8C0
	public void .ctor() { }

	// RVA: 0x160C8C8 Offset: 0x16088C8 VA: 0x160C8C8
	internal ServiceDescriptorProto <.cctor>b__41_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ServiceDescriptorProto : IMessage<ServiceDescriptorProto>, IMessage, IEquatable<ServiceDescriptorProto>, IDeepCloneable<ServiceDescriptorProto>, IBufferMessage // TypeDefIndex: 6433
{
	// Fields
	private static readonly MessageParser<ServiceDescriptorProto> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private static readonly string NameDefaultValue; // 0x8
	private string name_; // 0x18
	private static readonly FieldCodec<MethodDescriptorProto> _repeated_method_codec; // 0x10
	private readonly RepeatedField<MethodDescriptorProto> method_; // 0x20
	private ServiceOptions options_; // 0x28

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ServiceDescriptorProto> Parser { get; }
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
	public bool HasName { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<MethodDescriptorProto> Method { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServiceOptions Options { get; set; }

	// Methods

	// RVA: 0x160B878 Offset: 0x1607878 VA: 0x160B878
	public static MessageParser<ServiceDescriptorProto> get_Parser() { }

	// RVA: 0x160B8D0 Offset: 0x16078D0 VA: 0x160B8D0
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x160B9D4 Offset: 0x16079D4 VA: 0x160B9D4 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160BA20 Offset: 0x1607A20 VA: 0x160BA20
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160BAA8 Offset: 0x1607AA8 VA: 0x160BAA8
	public void .ctor(ServiceDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160BBC0 Offset: 0x1607BC0 VA: 0x160BBC0 Slot: 10
	public ServiceDescriptorProto Clone() { }

	// RVA: 0x160BC18 Offset: 0x1607C18 VA: 0x160BC18
	public string get_Name() { }

	// RVA: 0x160BC7C Offset: 0x1607C7C VA: 0x160BC7C
	public void set_Name(string value) { }

	// RVA: 0x160BCF8 Offset: 0x1607CF8 VA: 0x160BCF8
	public bool get_HasName() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160BD08 Offset: 0x1607D08 VA: 0x160BD08
	public void ClearName() { }

	// RVA: 0x160BD14 Offset: 0x1607D14 VA: 0x160BD14
	public RepeatedField<MethodDescriptorProto> get_Method() { }

	// RVA: 0x160BD1C Offset: 0x1607D1C VA: 0x160BD1C
	public ServiceOptions get_Options() { }

	// RVA: 0x160BD24 Offset: 0x1607D24 VA: 0x160BD24
	public void set_Options(ServiceOptions value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160BD2C Offset: 0x1607D2C VA: 0x160BD2C Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160BD90 Offset: 0x1607D90 VA: 0x160BD90 Slot: 9
	public bool Equals(ServiceDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160BE5C Offset: 0x1607E5C VA: 0x160BE5C Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160BEF4 Offset: 0x1607EF4 VA: 0x160BEF4 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160BF4C Offset: 0x1607F4C VA: 0x160BF4C Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160BF6C Offset: 0x1607F6C VA: 0x160BF6C Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160C07C Offset: 0x160807C VA: 0x160C07C Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160C1A8 Offset: 0x16081A8 VA: 0x160C1A8 Slot: 4
	public void MergeFrom(ServiceDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160C474 Offset: 0x1608474 VA: 0x160C474 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160C494 Offset: 0x1608494 VA: 0x160C494 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x160C678 Offset: 0x1608678 VA: 0x160C678
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MethodDescriptorProto.<>c // TypeDefIndex: 6434
{
	// Fields
	public static readonly MethodDescriptorProto.<>c <>9; // 0x0

	// Methods

	// RVA: 0x160DDA0 Offset: 0x1609DA0 VA: 0x160DDA0
	private static void .cctor() { }

	// RVA: 0x160DE08 Offset: 0x1609E08 VA: 0x160DE08
	public void .ctor() { }

	// RVA: 0x160DE10 Offset: 0x1609E10 VA: 0x160DE10
	internal MethodDescriptorProto <.cctor>b__73_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MethodDescriptorProto : IMessage<MethodDescriptorProto>, IMessage, IEquatable<MethodDescriptorProto>, IDeepCloneable<MethodDescriptorProto>, IBufferMessage // TypeDefIndex: 6435
{
	// Fields
	private static readonly MessageParser<MethodDescriptorProto> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly string NameDefaultValue; // 0x8
	private string name_; // 0x20
	private static readonly string InputTypeDefaultValue; // 0x10
	private string inputType_; // 0x28
	private static readonly string OutputTypeDefaultValue; // 0x18
	private string outputType_; // 0x30
	private MethodOptions options_; // 0x38
	private static readonly bool ClientStreamingDefaultValue; // 0x20
	private bool clientStreaming_; // 0x40
	private static readonly bool ServerStreamingDefaultValue; // 0x21
	private bool serverStreaming_; // 0x41

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MethodDescriptorProto> Parser { get; }
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
	public bool HasName { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string InputType { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasInputType { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string OutputType { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasOutputType { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MethodOptions Options { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ClientStreaming { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasClientStreaming { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool ServerStreaming { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasServerStreaming { get; }

	// Methods

	// RVA: 0x160C918 Offset: 0x1608918 VA: 0x160C918
	public static MessageParser<MethodDescriptorProto> get_Parser() { }

	// RVA: 0x160C970 Offset: 0x1608970 VA: 0x160C970
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x160CA74 Offset: 0x1608A74 VA: 0x160CA74 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160CAC0 Offset: 0x1608AC0 VA: 0x160CAC0
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160CAC8 Offset: 0x1608AC8 VA: 0x160CAC8
	public void .ctor(MethodDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160CBC8 Offset: 0x1608BC8 VA: 0x160CBC8 Slot: 10
	public MethodDescriptorProto Clone() { }

	// RVA: 0x160CC20 Offset: 0x1608C20 VA: 0x160CC20
	public string get_Name() { }

	// RVA: 0x160CC84 Offset: 0x1608C84 VA: 0x160CC84
	public void set_Name(string value) { }

	// RVA: 0x160CD00 Offset: 0x1608D00 VA: 0x160CD00
	public bool get_HasName() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160CD10 Offset: 0x1608D10 VA: 0x160CD10
	public void ClearName() { }

	// RVA: 0x160CD1C Offset: 0x1608D1C VA: 0x160CD1C
	public string get_InputType() { }

	// RVA: 0x160CD80 Offset: 0x1608D80 VA: 0x160CD80
	public void set_InputType(string value) { }

	// RVA: 0x160CDFC Offset: 0x1608DFC VA: 0x160CDFC
	public bool get_HasInputType() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160CE0C Offset: 0x1608E0C VA: 0x160CE0C
	public void ClearInputType() { }

	// RVA: 0x160CE18 Offset: 0x1608E18 VA: 0x160CE18
	public string get_OutputType() { }

	// RVA: 0x160CE7C Offset: 0x1608E7C VA: 0x160CE7C
	public void set_OutputType(string value) { }

	// RVA: 0x160CEF8 Offset: 0x1608EF8 VA: 0x160CEF8
	public bool get_HasOutputType() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160CF08 Offset: 0x1608F08 VA: 0x160CF08
	public void ClearOutputType() { }

	// RVA: 0x160CF14 Offset: 0x1608F14 VA: 0x160CF14
	public MethodOptions get_Options() { }

	// RVA: 0x160CF1C Offset: 0x1608F1C VA: 0x160CF1C
	public void set_Options(MethodOptions value) { }

	// RVA: 0x160CF24 Offset: 0x1608F24 VA: 0x160CF24
	public bool get_ClientStreaming() { }

	// RVA: 0x160CF94 Offset: 0x1608F94 VA: 0x160CF94
	public void set_ClientStreaming(bool value) { }

	// RVA: 0x160CFA8 Offset: 0x1608FA8 VA: 0x160CFA8
	public bool get_HasClientStreaming() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160CFB4 Offset: 0x1608FB4 VA: 0x160CFB4
	public void ClearClientStreaming() { }

	// RVA: 0x160CFC4 Offset: 0x1608FC4 VA: 0x160CFC4
	public bool get_ServerStreaming() { }

	// RVA: 0x160D034 Offset: 0x1609034 VA: 0x160D034
	public void set_ServerStreaming(bool value) { }

	// RVA: 0x160D048 Offset: 0x1609048 VA: 0x160D048
	public bool get_HasServerStreaming() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160D054 Offset: 0x1609054 VA: 0x160D054
	public void ClearServerStreaming() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160D064 Offset: 0x1609064 VA: 0x160D064 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160D0C8 Offset: 0x16090C8 VA: 0x160D0C8 Slot: 9
	public bool Equals(MethodDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160D1D8 Offset: 0x16091D8 VA: 0x160D1D8 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160D328 Offset: 0x1609328 VA: 0x160D328 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160D380 Offset: 0x1609380 VA: 0x160D380 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160D3A0 Offset: 0x16093A0 VA: 0x160D3A0 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160D4F0 Offset: 0x16094F0 VA: 0x160D4F0 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160D648 Offset: 0x1609648 VA: 0x160D648 Slot: 4
	public void MergeFrom(MethodDescriptorProto other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160D98C Offset: 0x160998C VA: 0x160D98C Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160D9AC Offset: 0x16099AC VA: 0x160D9AC Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x160DC28 Offset: 0x1609C28 VA: 0x160DC28
	private static void .cctor() { }
}

// Namespace: 
public enum FileOptions.Types.OptimizeMode // TypeDefIndex: 6436
{
	// Fields
	public int value__; // 0x0
	[OriginalName("SPEED")]
	public const FileOptions.Types.OptimizeMode Speed = 1;
	[OriginalName("CODE_SIZE")]
	public const FileOptions.Types.OptimizeMode CodeSize = 2;
	[OriginalName("LITE_RUNTIME")]
	public const FileOptions.Types.OptimizeMode LiteRuntime = 3;
}

// Namespace: 
[DebuggerNonUserCode]
[GeneratedCode("protoc", null)]
public static class FileOptions.Types // TypeDefIndex: 6437
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FileOptions.<>c // TypeDefIndex: 6438
{
	// Fields
	public static readonly FileOptions.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16110A4 Offset: 0x160D0A4 VA: 0x16110A4
	private static void .cctor() { }

	// RVA: 0x161110C Offset: 0x160D10C VA: 0x161110C
	public void .ctor() { }

	// RVA: 0x1611114 Offset: 0x160D114 VA: 0x1611114
	internal FileOptions <.cctor>b__215_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FileOptions : IExtendableMessage<FileOptions>, IMessage<FileOptions>, IMessage, IEquatable<FileOptions>, IDeepCloneable<FileOptions>, IBufferMessage // TypeDefIndex: 6439
{
	// Fields
	private static readonly MessageParser<FileOptions> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	internal ExtensionSet<FileOptions> _extensions; // 0x18
	private int _hasBits0; // 0x20
	private static readonly string JavaPackageDefaultValue; // 0x8
	private string javaPackage_; // 0x28
	private static readonly string JavaOuterClassnameDefaultValue; // 0x10
	private string javaOuterClassname_; // 0x30
	private static readonly bool JavaMultipleFilesDefaultValue; // 0x18
	private bool javaMultipleFiles_; // 0x38
	private static readonly bool JavaGenerateEqualsAndHashDefaultValue; // 0x19
	private bool javaGenerateEqualsAndHash_; // 0x39
	private static readonly bool JavaStringCheckUtf8DefaultValue; // 0x1A
	private bool javaStringCheckUtf8_; // 0x3A
	private static readonly FileOptions.Types.OptimizeMode OptimizeForDefaultValue; // 0x1C
	private FileOptions.Types.OptimizeMode optimizeFor_; // 0x3C
	private static readonly string GoPackageDefaultValue; // 0x20
	private string goPackage_; // 0x40
	private static readonly bool CcGenericServicesDefaultValue; // 0x28
	private bool ccGenericServices_; // 0x48
	private static readonly bool JavaGenericServicesDefaultValue; // 0x29
	private bool javaGenericServices_; // 0x49
	private static readonly bool PyGenericServicesDefaultValue; // 0x2A
	private bool pyGenericServices_; // 0x4A
	private static readonly bool DeprecatedDefaultValue; // 0x2B
	private bool deprecated_; // 0x4B
	private static readonly bool CcEnableArenasDefaultValue; // 0x2C
	private bool ccEnableArenas_; // 0x4C
	private static readonly string ObjcClassPrefixDefaultValue; // 0x30
	private string objcClassPrefix_; // 0x50
	private static readonly string CsharpNamespaceDefaultValue; // 0x38
	private string csharpNamespace_; // 0x58
	private static readonly string SwiftPrefixDefaultValue; // 0x40
	private string swiftPrefix_; // 0x60
	private static readonly string PhpClassPrefixDefaultValue; // 0x48
	private string phpClassPrefix_; // 0x68
	private static readonly string PhpNamespaceDefaultValue; // 0x50
	private string phpNamespace_; // 0x70
	private static readonly string PhpMetadataNamespaceDefaultValue; // 0x58
	private string phpMetadataNamespace_; // 0x78
	private static readonly string RubyPackageDefaultValue; // 0x60
	private string rubyPackage_; // 0x80
	private FeatureSet features_; // 0x88
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x68
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x90

	// Properties
	private ExtensionSet<FileOptions> _Extensions { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FileOptions> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string JavaPackage { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJavaPackage { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string JavaOuterClassname { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJavaOuterClassname { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JavaMultipleFiles { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJavaMultipleFiles { get; }
	[Obsolete]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JavaGenerateEqualsAndHash { get; set; }
	[Obsolete]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJavaGenerateEqualsAndHash { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JavaStringCheckUtf8 { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJavaStringCheckUtf8 { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FileOptions.Types.OptimizeMode OptimizeFor { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasOptimizeFor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string GoPackage { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasGoPackage { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CcGenericServices { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasCcGenericServices { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool JavaGenericServices { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJavaGenericServices { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool PyGenericServices { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPyGenericServices { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Deprecated { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDeprecated { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool CcEnableArenas { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasCcEnableArenas { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string ObjcClassPrefix { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasObjcClassPrefix { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CsharpNamespace { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasCsharpNamespace { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SwiftPrefix { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasSwiftPrefix { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PhpClassPrefix { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPhpClassPrefix { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PhpNamespace { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPhpNamespace { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string PhpMetadataNamespace { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPhpMetadataNamespace { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string RubyPackage { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRubyPackage { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet Features { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<UninterpretedOption> UninterpretedOption { get; }

	// Methods

	// RVA: 0x160DE64 Offset: 0x1609E64 VA: 0x160DE64
	private ExtensionSet<FileOptions> get__Extensions() { }

	// RVA: 0x160DE6C Offset: 0x1609E6C VA: 0x160DE6C
	public static MessageParser<FileOptions> get_Parser() { }

	// RVA: 0x160DEC4 Offset: 0x1609EC4 VA: 0x160DEC4
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x160DFC8 Offset: 0x1609FC8 VA: 0x160DFC8 Slot: 14
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160E014 Offset: 0x160A014 VA: 0x160E014
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160E09C Offset: 0x160A09C VA: 0x160E09C
	public void .ctor(FileOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160E250 Offset: 0x160A250 VA: 0x160E250 Slot: 16
	public FileOptions Clone() { }

	// RVA: 0x160E2A8 Offset: 0x160A2A8 VA: 0x160E2A8
	public string get_JavaPackage() { }

	// RVA: 0x160E30C Offset: 0x160A30C VA: 0x160E30C
	public void set_JavaPackage(string value) { }

	// RVA: 0x160E388 Offset: 0x160A388 VA: 0x160E388
	public bool get_HasJavaPackage() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160E398 Offset: 0x160A398 VA: 0x160E398
	public void ClearJavaPackage() { }

	// RVA: 0x160E3A4 Offset: 0x160A3A4 VA: 0x160E3A4
	public string get_JavaOuterClassname() { }

	// RVA: 0x160E408 Offset: 0x160A408 VA: 0x160E408
	public void set_JavaOuterClassname(string value) { }

	// RVA: 0x160E484 Offset: 0x160A484 VA: 0x160E484
	public bool get_HasJavaOuterClassname() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160E494 Offset: 0x160A494 VA: 0x160E494
	public void ClearJavaOuterClassname() { }

	// RVA: 0x160E4A0 Offset: 0x160A4A0 VA: 0x160E4A0
	public bool get_JavaMultipleFiles() { }

	// RVA: 0x160E510 Offset: 0x160A510 VA: 0x160E510
	public void set_JavaMultipleFiles(bool value) { }

	// RVA: 0x160E524 Offset: 0x160A524 VA: 0x160E524
	public bool get_HasJavaMultipleFiles() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160E530 Offset: 0x160A530 VA: 0x160E530
	public void ClearJavaMultipleFiles() { }

	// RVA: 0x160E540 Offset: 0x160A540 VA: 0x160E540
	public bool get_JavaGenerateEqualsAndHash() { }

	// RVA: 0x160E5B0 Offset: 0x160A5B0 VA: 0x160E5B0
	public void set_JavaGenerateEqualsAndHash(bool value) { }

	// RVA: 0x160E5C4 Offset: 0x160A5C4 VA: 0x160E5C4
	public bool get_HasJavaGenerateEqualsAndHash() { }

	[Obsolete]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160E5D0 Offset: 0x160A5D0 VA: 0x160E5D0
	public void ClearJavaGenerateEqualsAndHash() { }

	// RVA: 0x160E5E0 Offset: 0x160A5E0 VA: 0x160E5E0
	public bool get_JavaStringCheckUtf8() { }

	// RVA: 0x160E650 Offset: 0x160A650 VA: 0x160E650
	public void set_JavaStringCheckUtf8(bool value) { }

	// RVA: 0x160E664 Offset: 0x160A664 VA: 0x160E664
	public bool get_HasJavaStringCheckUtf8() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160E670 Offset: 0x160A670 VA: 0x160E670
	public void ClearJavaStringCheckUtf8() { }

	// RVA: 0x160E680 Offset: 0x160A680 VA: 0x160E680
	public FileOptions.Types.OptimizeMode get_OptimizeFor() { }

	// RVA: 0x160E6F0 Offset: 0x160A6F0 VA: 0x160E6F0
	public void set_OptimizeFor(FileOptions.Types.OptimizeMode value) { }

	// RVA: 0x160E704 Offset: 0x160A704 VA: 0x160E704
	public bool get_HasOptimizeFor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160E710 Offset: 0x160A710 VA: 0x160E710
	public void ClearOptimizeFor() { }

	// RVA: 0x160E720 Offset: 0x160A720 VA: 0x160E720
	public string get_GoPackage() { }

	// RVA: 0x160E784 Offset: 0x160A784 VA: 0x160E784
	public void set_GoPackage(string value) { }

	// RVA: 0x160E800 Offset: 0x160A800 VA: 0x160E800
	public bool get_HasGoPackage() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160E810 Offset: 0x160A810 VA: 0x160E810
	public void ClearGoPackage() { }

	// RVA: 0x160E81C Offset: 0x160A81C VA: 0x160E81C
	public bool get_CcGenericServices() { }

	// RVA: 0x160E88C Offset: 0x160A88C VA: 0x160E88C
	public void set_CcGenericServices(bool value) { }

	// RVA: 0x160E8A0 Offset: 0x160A8A0 VA: 0x160E8A0
	public bool get_HasCcGenericServices() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160E8AC Offset: 0x160A8AC VA: 0x160E8AC
	public void ClearCcGenericServices() { }

	// RVA: 0x160E8BC Offset: 0x160A8BC VA: 0x160E8BC
	public bool get_JavaGenericServices() { }

	// RVA: 0x160E92C Offset: 0x160A92C VA: 0x160E92C
	public void set_JavaGenericServices(bool value) { }

	// RVA: 0x160E940 Offset: 0x160A940 VA: 0x160E940
	public bool get_HasJavaGenericServices() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160E94C Offset: 0x160A94C VA: 0x160E94C
	public void ClearJavaGenericServices() { }

	// RVA: 0x160E95C Offset: 0x160A95C VA: 0x160E95C
	public bool get_PyGenericServices() { }

	// RVA: 0x160E9CC Offset: 0x160A9CC VA: 0x160E9CC
	public void set_PyGenericServices(bool value) { }

	// RVA: 0x160E9E0 Offset: 0x160A9E0 VA: 0x160E9E0
	public bool get_HasPyGenericServices() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160E9EC Offset: 0x160A9EC VA: 0x160E9EC
	public void ClearPyGenericServices() { }

	// RVA: 0x160E9FC Offset: 0x160A9FC VA: 0x160E9FC
	public bool get_Deprecated() { }

	// RVA: 0x160EA6C Offset: 0x160AA6C VA: 0x160EA6C
	public void set_Deprecated(bool value) { }

	// RVA: 0x160EA80 Offset: 0x160AA80 VA: 0x160EA80
	public bool get_HasDeprecated() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160EA8C Offset: 0x160AA8C VA: 0x160EA8C
	public void ClearDeprecated() { }

	// RVA: 0x160EA9C Offset: 0x160AA9C VA: 0x160EA9C
	public bool get_CcEnableArenas() { }

	// RVA: 0x160EB0C Offset: 0x160AB0C VA: 0x160EB0C
	public void set_CcEnableArenas(bool value) { }

	// RVA: 0x160EB20 Offset: 0x160AB20 VA: 0x160EB20
	public bool get_HasCcEnableArenas() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160EB2C Offset: 0x160AB2C VA: 0x160EB2C
	public void ClearCcEnableArenas() { }

	// RVA: 0x160EB3C Offset: 0x160AB3C VA: 0x160EB3C
	public string get_ObjcClassPrefix() { }

	// RVA: 0x160EBA0 Offset: 0x160ABA0 VA: 0x160EBA0
	public void set_ObjcClassPrefix(string value) { }

	// RVA: 0x160EC1C Offset: 0x160AC1C VA: 0x160EC1C
	public bool get_HasObjcClassPrefix() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160EC2C Offset: 0x160AC2C VA: 0x160EC2C
	public void ClearObjcClassPrefix() { }

	// RVA: 0x160EC38 Offset: 0x160AC38 VA: 0x160EC38
	public string get_CsharpNamespace() { }

	// RVA: 0x160EC9C Offset: 0x160AC9C VA: 0x160EC9C
	public void set_CsharpNamespace(string value) { }

	// RVA: 0x160ED18 Offset: 0x160AD18 VA: 0x160ED18
	public bool get_HasCsharpNamespace() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160ED28 Offset: 0x160AD28 VA: 0x160ED28
	public void ClearCsharpNamespace() { }

	// RVA: 0x160ED34 Offset: 0x160AD34 VA: 0x160ED34
	public string get_SwiftPrefix() { }

	// RVA: 0x160ED98 Offset: 0x160AD98 VA: 0x160ED98
	public void set_SwiftPrefix(string value) { }

	// RVA: 0x160EE14 Offset: 0x160AE14 VA: 0x160EE14
	public bool get_HasSwiftPrefix() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160EE24 Offset: 0x160AE24 VA: 0x160EE24
	public void ClearSwiftPrefix() { }

	// RVA: 0x160EE30 Offset: 0x160AE30 VA: 0x160EE30
	public string get_PhpClassPrefix() { }

	// RVA: 0x160EE94 Offset: 0x160AE94 VA: 0x160EE94
	public void set_PhpClassPrefix(string value) { }

	// RVA: 0x160EF10 Offset: 0x160AF10 VA: 0x160EF10
	public bool get_HasPhpClassPrefix() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160EF20 Offset: 0x160AF20 VA: 0x160EF20
	public void ClearPhpClassPrefix() { }

	// RVA: 0x160EF2C Offset: 0x160AF2C VA: 0x160EF2C
	public string get_PhpNamespace() { }

	// RVA: 0x160EF90 Offset: 0x160AF90 VA: 0x160EF90
	public void set_PhpNamespace(string value) { }

	// RVA: 0x160F00C Offset: 0x160B00C VA: 0x160F00C
	public bool get_HasPhpNamespace() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160F01C Offset: 0x160B01C VA: 0x160F01C
	public void ClearPhpNamespace() { }

	// RVA: 0x160F028 Offset: 0x160B028 VA: 0x160F028
	public string get_PhpMetadataNamespace() { }

	// RVA: 0x160F08C Offset: 0x160B08C VA: 0x160F08C
	public void set_PhpMetadataNamespace(string value) { }

	// RVA: 0x160F108 Offset: 0x160B108 VA: 0x160F108
	public bool get_HasPhpMetadataNamespace() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160F118 Offset: 0x160B118 VA: 0x160F118
	public void ClearPhpMetadataNamespace() { }

	// RVA: 0x160F124 Offset: 0x160B124 VA: 0x160F124
	public string get_RubyPackage() { }

	// RVA: 0x160F188 Offset: 0x160B188 VA: 0x160F188
	public void set_RubyPackage(string value) { }

	// RVA: 0x160F204 Offset: 0x160B204 VA: 0x160F204
	public bool get_HasRubyPackage() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160F214 Offset: 0x160B214 VA: 0x160F214
	public void ClearRubyPackage() { }

	// RVA: 0x160F220 Offset: 0x160B220 VA: 0x160F220
	public FeatureSet get_Features() { }

	// RVA: 0x160F228 Offset: 0x160B228 VA: 0x160F228
	public void set_Features(FeatureSet value) { }

	// RVA: 0x160F230 Offset: 0x160B230 VA: 0x160F230
	public RepeatedField<UninterpretedOption> get_UninterpretedOption() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160F238 Offset: 0x160B238 VA: 0x160F238 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160F29C Offset: 0x160B29C VA: 0x160F29C Slot: 15
	public bool Equals(FileOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160F5E0 Offset: 0x160B5E0 VA: 0x160F5E0 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160FA14 Offset: 0x160BA14 VA: 0x160FA14 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160FA6C Offset: 0x160BA6C VA: 0x160FA6C Slot: 12
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160FA8C Offset: 0x160BA8C VA: 0x160FA8C Slot: 18
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160FF7C Offset: 0x160BF7C VA: 0x160FF7C Slot: 13
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161038C Offset: 0x160C38C VA: 0x161038C Slot: 10
	public void MergeFrom(FileOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1610720 Offset: 0x160C720 VA: 0x1610720 Slot: 11
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1610740 Offset: 0x160C740 VA: 0x1610740 Slot: 17
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: -1 Offset: -1 Slot: 4
	public TValue GetExtension<TValue>(Extension<FileOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11150AC Offset: 0x11110AC VA: 0x11150AC
	|-FileOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1115170 Offset: 0x1111170 VA: 0x1115170
	|-FileOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11151B4 Offset: 0x11111B4 VA: 0x11151B4
	|-FileOptions.GetOrInitializeExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SetExtension<TValue>(Extension<FileOptions, TValue> extension, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111523C Offset: 0x111123C VA: 0x111523C
	|-FileOptions.SetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasExtension<TValue>(Extension<FileOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11151F8 Offset: 0x11111F8 VA: 0x11151F8
	|-FileOptions.HasExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void ClearExtension<TValue>(Extension<FileOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1115024 Offset: 0x1111024 VA: 0x1115024
	|-FileOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void ClearExtension<TValue>(RepeatedExtension<FileOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1115068 Offset: 0x1111068 VA: 0x1115068
	|-FileOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1610DF8 Offset: 0x160CDF8 VA: 0x1610DF8
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MessageOptions.<>c // TypeDefIndex: 6440
{
	// Fields
	public static readonly MessageOptions.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1612700 Offset: 0x160E700 VA: 0x1612700
	private static void .cctor() { }

	// RVA: 0x1612768 Offset: 0x160E768 VA: 0x1612768
	public void .ctor() { }

	// RVA: 0x1612770 Offset: 0x160E770 VA: 0x1612770
	internal MessageOptions <.cctor>b__88_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MessageOptions : IExtendableMessage<MessageOptions>, IMessage<MessageOptions>, IMessage, IEquatable<MessageOptions>, IDeepCloneable<MessageOptions>, IBufferMessage // TypeDefIndex: 6441
{
	// Fields
	private static readonly MessageParser<MessageOptions> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	internal ExtensionSet<MessageOptions> _extensions; // 0x18
	private int _hasBits0; // 0x20
	private static readonly bool MessageSetWireFormatDefaultValue; // 0x8
	private bool messageSetWireFormat_; // 0x24
	private static readonly bool NoStandardDescriptorAccessorDefaultValue; // 0x9
	private bool noStandardDescriptorAccessor_; // 0x25
	private static readonly bool DeprecatedDefaultValue; // 0xA
	private bool deprecated_; // 0x26
	private static readonly bool MapEntryDefaultValue; // 0xB
	private bool mapEntry_; // 0x27
	private static readonly bool DeprecatedLegacyJsonFieldConflictsDefaultValue; // 0xC
	private bool deprecatedLegacyJsonFieldConflicts_; // 0x28
	private FeatureSet features_; // 0x30
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x38

	// Properties
	private ExtensionSet<MessageOptions> _Extensions { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MessageOptions> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MessageSetWireFormat { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMessageSetWireFormat { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool NoStandardDescriptorAccessor { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasNoStandardDescriptorAccessor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Deprecated { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDeprecated { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool MapEntry { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMapEntry { get; }
	[Obsolete]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DeprecatedLegacyJsonFieldConflicts { get; set; }
	[Obsolete]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDeprecatedLegacyJsonFieldConflicts { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet Features { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<UninterpretedOption> UninterpretedOption { get; }

	// Methods

	// RVA: 0x1611164 Offset: 0x160D164 VA: 0x1611164
	private ExtensionSet<MessageOptions> get__Extensions() { }

	// RVA: 0x161116C Offset: 0x160D16C VA: 0x161116C
	public static MessageParser<MessageOptions> get_Parser() { }

	// RVA: 0x16111C4 Offset: 0x160D1C4 VA: 0x16111C4
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16112C8 Offset: 0x160D2C8 VA: 0x16112C8 Slot: 14
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1611314 Offset: 0x160D314 VA: 0x1611314
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161139C Offset: 0x160D39C VA: 0x161139C
	public void .ctor(MessageOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1611490 Offset: 0x160D490 VA: 0x1611490 Slot: 16
	public MessageOptions Clone() { }

	// RVA: 0x16114E8 Offset: 0x160D4E8 VA: 0x16114E8
	public bool get_MessageSetWireFormat() { }

	// RVA: 0x1611558 Offset: 0x160D558 VA: 0x1611558
	public void set_MessageSetWireFormat(bool value) { }

	// RVA: 0x161156C Offset: 0x160D56C VA: 0x161156C
	public bool get_HasMessageSetWireFormat() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1611578 Offset: 0x160D578 VA: 0x1611578
	public void ClearMessageSetWireFormat() { }

	// RVA: 0x1611588 Offset: 0x160D588 VA: 0x1611588
	public bool get_NoStandardDescriptorAccessor() { }

	// RVA: 0x16115F8 Offset: 0x160D5F8 VA: 0x16115F8
	public void set_NoStandardDescriptorAccessor(bool value) { }

	// RVA: 0x161160C Offset: 0x160D60C VA: 0x161160C
	public bool get_HasNoStandardDescriptorAccessor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1611618 Offset: 0x160D618 VA: 0x1611618
	public void ClearNoStandardDescriptorAccessor() { }

	// RVA: 0x1611628 Offset: 0x160D628 VA: 0x1611628
	public bool get_Deprecated() { }

	// RVA: 0x1611698 Offset: 0x160D698 VA: 0x1611698
	public void set_Deprecated(bool value) { }

	// RVA: 0x16116AC Offset: 0x160D6AC VA: 0x16116AC
	public bool get_HasDeprecated() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16116B8 Offset: 0x160D6B8 VA: 0x16116B8
	public void ClearDeprecated() { }

	// RVA: 0x16116C8 Offset: 0x160D6C8 VA: 0x16116C8
	public bool get_MapEntry() { }

	// RVA: 0x1611738 Offset: 0x160D738 VA: 0x1611738
	public void set_MapEntry(bool value) { }

	// RVA: 0x161174C Offset: 0x160D74C VA: 0x161174C
	public bool get_HasMapEntry() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1611758 Offset: 0x160D758 VA: 0x1611758
	public void ClearMapEntry() { }

	// RVA: 0x1611768 Offset: 0x160D768 VA: 0x1611768
	public bool get_DeprecatedLegacyJsonFieldConflicts() { }

	// RVA: 0x16117D8 Offset: 0x160D7D8 VA: 0x16117D8
	public void set_DeprecatedLegacyJsonFieldConflicts(bool value) { }

	// RVA: 0x16117EC Offset: 0x160D7EC VA: 0x16117EC
	public bool get_HasDeprecatedLegacyJsonFieldConflicts() { }

	[Obsolete]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16117F8 Offset: 0x160D7F8 VA: 0x16117F8
	public void ClearDeprecatedLegacyJsonFieldConflicts() { }

	// RVA: 0x1611808 Offset: 0x160D808 VA: 0x1611808
	public FeatureSet get_Features() { }

	// RVA: 0x1611810 Offset: 0x160D810 VA: 0x1611810
	public void set_Features(FeatureSet value) { }

	// RVA: 0x1611818 Offset: 0x160D818 VA: 0x1611818
	public RepeatedField<UninterpretedOption> get_UninterpretedOption() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1611820 Offset: 0x160D820 VA: 0x1611820 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1611884 Offset: 0x160D884 VA: 0x1611884 Slot: 15
	public bool Equals(MessageOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16119C8 Offset: 0x160D9C8 VA: 0x16119C8 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1611BA4 Offset: 0x160DBA4 VA: 0x1611BA4 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1611BFC Offset: 0x160DBFC VA: 0x1611BFC Slot: 12
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1611C1C Offset: 0x160DC1C VA: 0x1611C1C Slot: 18
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1611E28 Offset: 0x160DE28 VA: 0x1611E28 Slot: 13
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1611F80 Offset: 0x160DF80 VA: 0x1611F80 Slot: 10
	public void MergeFrom(MessageOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1612160 Offset: 0x160E160 VA: 0x1612160 Slot: 11
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1612180 Offset: 0x160E180 VA: 0x1612180 Slot: 17
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: -1 Offset: -1 Slot: 4
	public TValue GetExtension<TValue>(Extension<MessageOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113697C Offset: 0x113297C VA: 0x113697C
	|-MessageOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136A40 Offset: 0x1132A40 VA: 0x1136A40
	|-MessageOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136A84 Offset: 0x1132A84 VA: 0x1136A84
	|-MessageOptions.GetOrInitializeExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SetExtension<TValue>(Extension<MessageOptions, TValue> extension, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136B0C Offset: 0x1132B0C VA: 0x1136B0C
	|-MessageOptions.SetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasExtension<TValue>(Extension<MessageOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136AC8 Offset: 0x1132AC8 VA: 0x1136AC8
	|-MessageOptions.HasExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void ClearExtension<TValue>(Extension<MessageOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11368F4 Offset: 0x11328F4 VA: 0x11368F4
	|-MessageOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void ClearExtension<TValue>(RepeatedExtension<MessageOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136938 Offset: 0x1132938 VA: 0x1136938
	|-MessageOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1612540 Offset: 0x160E540 VA: 0x1612540
	private static void .cctor() { }
}

// Namespace: 
public enum FieldOptions.Types.CType // TypeDefIndex: 6442
{
	// Fields
	public int value__; // 0x0
	[OriginalName("STRING")]
	public const FieldOptions.Types.CType String = 0;
	[OriginalName("CORD")]
	public const FieldOptions.Types.CType Cord = 1;
	[OriginalName("STRING_PIECE")]
	public const FieldOptions.Types.CType StringPiece = 2;
}

// Namespace: 
public enum FieldOptions.Types.JSType // TypeDefIndex: 6443
{
	// Fields
	public int value__; // 0x0
	[OriginalName("JS_NORMAL")]
	public const FieldOptions.Types.JSType JsNormal = 0;
	[OriginalName("JS_STRING")]
	public const FieldOptions.Types.JSType JsString = 1;
	[OriginalName("JS_NUMBER")]
	public const FieldOptions.Types.JSType JsNumber = 2;
}

// Namespace: 
public enum FieldOptions.Types.OptionRetention // TypeDefIndex: 6444
{
	// Fields
	public int value__; // 0x0
	[OriginalName("RETENTION_UNKNOWN")]
	public const FieldOptions.Types.OptionRetention RetentionUnknown = 0;
	[OriginalName("RETENTION_RUNTIME")]
	public const FieldOptions.Types.OptionRetention RetentionRuntime = 1;
	[OriginalName("RETENTION_SOURCE")]
	public const FieldOptions.Types.OptionRetention RetentionSource = 2;
}

// Namespace: 
public enum FieldOptions.Types.OptionTargetType // TypeDefIndex: 6445
{
	// Fields
	public int value__; // 0x0
	[OriginalName("TARGET_TYPE_UNKNOWN")]
	public const FieldOptions.Types.OptionTargetType TargetTypeUnknown = 0;
	[OriginalName("TARGET_TYPE_FILE")]
	public const FieldOptions.Types.OptionTargetType TargetTypeFile = 1;
	[OriginalName("TARGET_TYPE_EXTENSION_RANGE")]
	public const FieldOptions.Types.OptionTargetType TargetTypeExtensionRange = 2;
	[OriginalName("TARGET_TYPE_MESSAGE")]
	public const FieldOptions.Types.OptionTargetType TargetTypeMessage = 3;
	[OriginalName("TARGET_TYPE_FIELD")]
	public const FieldOptions.Types.OptionTargetType TargetTypeField = 4;
	[OriginalName("TARGET_TYPE_ONEOF")]
	public const FieldOptions.Types.OptionTargetType TargetTypeOneof = 5;
	[OriginalName("TARGET_TYPE_ENUM")]
	public const FieldOptions.Types.OptionTargetType TargetTypeEnum = 6;
	[OriginalName("TARGET_TYPE_ENUM_ENTRY")]
	public const FieldOptions.Types.OptionTargetType TargetTypeEnumEntry = 7;
	[OriginalName("TARGET_TYPE_SERVICE")]
	public const FieldOptions.Types.OptionTargetType TargetTypeService = 8;
	[OriginalName("TARGET_TYPE_METHOD")]
	public const FieldOptions.Types.OptionTargetType TargetTypeMethod = 9;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FieldOptions.Types.EditionDefault.<>c // TypeDefIndex: 6446
{
	// Fields
	public static readonly FieldOptions.Types.EditionDefault.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1615680 Offset: 0x1611680 VA: 0x1615680
	private static void .cctor() { }

	// RVA: 0x16156E8 Offset: 0x16116E8 VA: 0x16156E8
	public void .ctor() { }

	// RVA: 0x16156F0 Offset: 0x16116F0 VA: 0x16156F0
	internal FieldOptions.Types.EditionDefault <.cctor>b__41_0() { }
}

// Namespace: 
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FieldOptions.Types.EditionDefault : IMessage<FieldOptions.Types.EditionDefault>, IMessage, IEquatable<FieldOptions.Types.EditionDefault>, IDeepCloneable<FieldOptions.Types.EditionDefault>, IBufferMessage // TypeDefIndex: 6447
{
	// Fields
	private static readonly MessageParser<FieldOptions.Types.EditionDefault> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly Edition EditionDefaultValue; // 0x8
	private Edition edition_; // 0x1C
	private static readonly string ValueDefaultValue; // 0x10
	private string value_; // 0x20

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldOptions.Types.EditionDefault> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Edition Edition { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEdition { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Value { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasValue { get; }

	// Methods

	// RVA: 0x1614C64 Offset: 0x1610C64 VA: 0x1614C64
	public static MessageParser<FieldOptions.Types.EditionDefault> get_Parser() { }

	// RVA: 0x1614CBC Offset: 0x1610CBC VA: 0x1614CBC
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x1614D88 Offset: 0x1610D88 VA: 0x1614D88 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1614DD4 Offset: 0x1610DD4 VA: 0x1614DD4
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1614DDC Offset: 0x1610DDC VA: 0x1614DDC
	public void .ctor(FieldOptions.Types.EditionDefault other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1614E38 Offset: 0x1610E38 VA: 0x1614E38 Slot: 10
	public FieldOptions.Types.EditionDefault Clone() { }

	// RVA: 0x1614E90 Offset: 0x1610E90 VA: 0x1614E90
	public Edition get_Edition() { }

	// RVA: 0x1614F00 Offset: 0x1610F00 VA: 0x1614F00
	public void set_Edition(Edition value) { }

	// RVA: 0x1614F10 Offset: 0x1610F10 VA: 0x1614F10
	public bool get_HasEdition() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1614F1C Offset: 0x1610F1C VA: 0x1614F1C
	public void ClearEdition() { }

	// RVA: 0x1614F2C Offset: 0x1610F2C VA: 0x1614F2C
	public string get_Value() { }

	// RVA: 0x1614F90 Offset: 0x1610F90 VA: 0x1614F90
	public void set_Value(string value) { }

	// RVA: 0x161500C Offset: 0x161100C VA: 0x161500C
	public bool get_HasValue() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161501C Offset: 0x161101C VA: 0x161501C
	public void ClearValue() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1615028 Offset: 0x1611028 VA: 0x1615028 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161508C Offset: 0x161108C VA: 0x161508C Slot: 9
	public bool Equals(FieldOptions.Types.EditionDefault other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161511C Offset: 0x161111C VA: 0x161511C Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16151A8 Offset: 0x16111A8 VA: 0x16151A8 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1615200 Offset: 0x1611200 VA: 0x1615200 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1615220 Offset: 0x1611220 VA: 0x1615220 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16152B8 Offset: 0x16112B8 VA: 0x16152B8 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161538C Offset: 0x161138C VA: 0x161538C Slot: 4
	public void MergeFrom(FieldOptions.Types.EditionDefault other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1615404 Offset: 0x1611404 VA: 0x1615404 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1615424 Offset: 0x1611424 VA: 0x1615424 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x161553C Offset: 0x161153C VA: 0x161553C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FieldOptions.Types.FeatureSupport.<>c // TypeDefIndex: 6448
{
	// Fields
	public static readonly FieldOptions.Types.FeatureSupport.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16163F4 Offset: 0x16123F4 VA: 0x16163F4
	private static void .cctor() { }

	// RVA: 0x161645C Offset: 0x161245C VA: 0x161645C
	public void .ctor() { }

	// RVA: 0x1616464 Offset: 0x1612464 VA: 0x1616464
	internal FieldOptions.Types.FeatureSupport <.cctor>b__59_0() { }
}

// Namespace: 
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FieldOptions.Types.FeatureSupport : IMessage<FieldOptions.Types.FeatureSupport>, IMessage, IEquatable<FieldOptions.Types.FeatureSupport>, IDeepCloneable<FieldOptions.Types.FeatureSupport>, IBufferMessage // TypeDefIndex: 6449
{
	// Fields
	private static readonly MessageParser<FieldOptions.Types.FeatureSupport> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly Edition EditionIntroducedDefaultValue; // 0x8
	private Edition editionIntroduced_; // 0x1C
	private static readonly Edition EditionDeprecatedDefaultValue; // 0xC
	private Edition editionDeprecated_; // 0x20
	private static readonly string DeprecationWarningDefaultValue; // 0x10
	private string deprecationWarning_; // 0x28
	private static readonly Edition EditionRemovedDefaultValue; // 0x18
	private Edition editionRemoved_; // 0x30

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldOptions.Types.FeatureSupport> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Edition EditionIntroduced { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEditionIntroduced { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Edition EditionDeprecated { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEditionDeprecated { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string DeprecationWarning { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDeprecationWarning { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Edition EditionRemoved { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEditionRemoved { get; }

	// Methods

	// RVA: 0x1615744 Offset: 0x1611744 VA: 0x1615744
	public static MessageParser<FieldOptions.Types.FeatureSupport> get_Parser() { }

	// RVA: 0x161579C Offset: 0x161179C VA: 0x161579C
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x1615868 Offset: 0x1611868 VA: 0x1615868 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161420C Offset: 0x161020C VA: 0x161420C
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16158B4 Offset: 0x16118B4 VA: 0x16158B4
	public void .ctor(FieldOptions.Types.FeatureSupport other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1612C40 Offset: 0x160EC40 VA: 0x1612C40 Slot: 10
	public FieldOptions.Types.FeatureSupport Clone() { }

	// RVA: 0x1615920 Offset: 0x1611920 VA: 0x1615920
	public Edition get_EditionIntroduced() { }

	// RVA: 0x1615990 Offset: 0x1611990 VA: 0x1615990
	public void set_EditionIntroduced(Edition value) { }

	// RVA: 0x16159A0 Offset: 0x16119A0 VA: 0x16159A0
	public bool get_HasEditionIntroduced() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16159AC Offset: 0x16119AC VA: 0x16159AC
	public void ClearEditionIntroduced() { }

	// RVA: 0x16159BC Offset: 0x16119BC VA: 0x16159BC
	public Edition get_EditionDeprecated() { }

	// RVA: 0x1615A2C Offset: 0x1611A2C VA: 0x1615A2C
	public void set_EditionDeprecated(Edition value) { }

	// RVA: 0x1615A40 Offset: 0x1611A40 VA: 0x1615A40
	public bool get_HasEditionDeprecated() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1615A4C Offset: 0x1611A4C VA: 0x1615A4C
	public void ClearEditionDeprecated() { }

	// RVA: 0x1615A5C Offset: 0x1611A5C VA: 0x1615A5C
	public string get_DeprecationWarning() { }

	// RVA: 0x1615AC0 Offset: 0x1611AC0 VA: 0x1615AC0
	public void set_DeprecationWarning(string value) { }

	// RVA: 0x1615B3C Offset: 0x1611B3C VA: 0x1615B3C
	public bool get_HasDeprecationWarning() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1615B4C Offset: 0x1611B4C VA: 0x1615B4C
	public void ClearDeprecationWarning() { }

	// RVA: 0x1615B58 Offset: 0x1611B58 VA: 0x1615B58
	public Edition get_EditionRemoved() { }

	// RVA: 0x1615BC8 Offset: 0x1611BC8 VA: 0x1615BC8
	public void set_EditionRemoved(Edition value) { }

	// RVA: 0x1615BDC Offset: 0x1611BDC VA: 0x1615BDC
	public bool get_HasEditionRemoved() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1615BE8 Offset: 0x1611BE8 VA: 0x1615BE8
	public void ClearEditionRemoved() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1615BF8 Offset: 0x1611BF8 VA: 0x1615BF8 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1615C5C Offset: 0x1611C5C VA: 0x1615C5C Slot: 9
	public bool Equals(FieldOptions.Types.FeatureSupport other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1615D24 Offset: 0x1611D24 VA: 0x1615D24 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1615DFC Offset: 0x1611DFC VA: 0x1615DFC Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1615E54 Offset: 0x1611E54 VA: 0x1615E54 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1615E74 Offset: 0x1611E74 VA: 0x1615E74 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1615F6C Offset: 0x1611F6C VA: 0x1615F6C Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1614214 Offset: 0x1610214 VA: 0x1614214 Slot: 4
	public void MergeFrom(FieldOptions.Types.FeatureSupport other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16160C4 Offset: 0x16120C4 VA: 0x16160C4 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16160E4 Offset: 0x16120E4 VA: 0x16160E4 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16162A0 Offset: 0x16122A0 VA: 0x16162A0
	private static void .cctor() { }
}

// Namespace: 
[DebuggerNonUserCode]
[GeneratedCode("protoc", null)]
public static class FieldOptions.Types // TypeDefIndex: 6450
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FieldOptions.<>c // TypeDefIndex: 6451
{
	// Fields
	public static readonly FieldOptions.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16164B8 Offset: 0x16124B8 VA: 0x16164B8
	private static void .cctor() { }

	// RVA: 0x1616520 Offset: 0x1612520 VA: 0x1616520
	public void .ctor() { }

	// RVA: 0x1616528 Offset: 0x1612528 VA: 0x1616528
	internal FieldOptions <.cctor>b__140_0() { }

	// RVA: 0x1616578 Offset: 0x1612578 VA: 0x1616578
	internal int <.cctor>b__140_1(FieldOptions.Types.OptionTargetType x) { }

	// RVA: 0x1616580 Offset: 0x1612580 VA: 0x1616580
	internal FieldOptions.Types.OptionTargetType <.cctor>b__140_2(int x) { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FieldOptions : IExtendableMessage<FieldOptions>, IMessage<FieldOptions>, IMessage, IEquatable<FieldOptions>, IDeepCloneable<FieldOptions>, IBufferMessage // TypeDefIndex: 6452
{
	// Fields
	private static readonly MessageParser<FieldOptions> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	internal ExtensionSet<FieldOptions> _extensions; // 0x18
	private int _hasBits0; // 0x20
	private static readonly FieldOptions.Types.CType CtypeDefaultValue; // 0x8
	private FieldOptions.Types.CType ctype_; // 0x24
	private static readonly bool PackedDefaultValue; // 0xC
	private bool packed_; // 0x28
	private static readonly FieldOptions.Types.JSType JstypeDefaultValue; // 0x10
	private FieldOptions.Types.JSType jstype_; // 0x2C
	private static readonly bool LazyDefaultValue; // 0x14
	private bool lazy_; // 0x30
	private static readonly bool UnverifiedLazyDefaultValue; // 0x15
	private bool unverifiedLazy_; // 0x31
	private static readonly bool DeprecatedDefaultValue; // 0x16
	private bool deprecated_; // 0x32
	private static readonly bool WeakDefaultValue; // 0x17
	private bool weak_; // 0x33
	private static readonly bool DebugRedactDefaultValue; // 0x18
	private bool debugRedact_; // 0x34
	private static readonly FieldOptions.Types.OptionRetention RetentionDefaultValue; // 0x1C
	private FieldOptions.Types.OptionRetention retention_; // 0x38
	private static readonly FieldCodec<FieldOptions.Types.OptionTargetType> _repeated_targets_codec; // 0x20
	private readonly RepeatedField<FieldOptions.Types.OptionTargetType> targets_; // 0x40
	private static readonly FieldCodec<FieldOptions.Types.EditionDefault> _repeated_editionDefaults_codec; // 0x28
	private readonly RepeatedField<FieldOptions.Types.EditionDefault> editionDefaults_; // 0x48
	private FeatureSet features_; // 0x50
	private FieldOptions.Types.FeatureSupport featureSupport_; // 0x58
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x30
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x60

	// Properties
	private ExtensionSet<FieldOptions> _Extensions { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FieldOptions> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldOptions.Types.CType Ctype { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasCtype { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Packed { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPacked { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldOptions.Types.JSType Jstype { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJstype { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Lazy { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasLazy { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool UnverifiedLazy { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasUnverifiedLazy { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Deprecated { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDeprecated { get; }
	[Obsolete]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Weak { get; set; }
	[Obsolete]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasWeak { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DebugRedact { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDebugRedact { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldOptions.Types.OptionRetention Retention { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRetention { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FieldOptions.Types.OptionTargetType> Targets { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FieldOptions.Types.EditionDefault> EditionDefaults { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet Features { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldOptions.Types.FeatureSupport FeatureSupport { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<UninterpretedOption> UninterpretedOption { get; }

	// Methods

	// RVA: 0x16127C0 Offset: 0x160E7C0 VA: 0x16127C0
	private ExtensionSet<FieldOptions> get__Extensions() { }

	// RVA: 0x16127C8 Offset: 0x160E7C8 VA: 0x16127C8
	public static MessageParser<FieldOptions> get_Parser() { }

	// RVA: 0x1612820 Offset: 0x160E820 VA: 0x1612820
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x1612924 Offset: 0x160E924 VA: 0x1612924 Slot: 14
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1612970 Offset: 0x160E970 VA: 0x1612970
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1612AA0 Offset: 0x160EAA0 VA: 0x1612AA0
	public void .ctor(FieldOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1612C98 Offset: 0x160EC98 VA: 0x1612C98 Slot: 16
	public FieldOptions Clone() { }

	// RVA: 0x1612CF0 Offset: 0x160ECF0 VA: 0x1612CF0
	public FieldOptions.Types.CType get_Ctype() { }

	// RVA: 0x1612D60 Offset: 0x160ED60 VA: 0x1612D60
	public void set_Ctype(FieldOptions.Types.CType value) { }

	// RVA: 0x1612D70 Offset: 0x160ED70 VA: 0x1612D70
	public bool get_HasCtype() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1612D7C Offset: 0x160ED7C VA: 0x1612D7C
	public void ClearCtype() { }

	// RVA: 0x1612D8C Offset: 0x160ED8C VA: 0x1612D8C
	public bool get_Packed() { }

	// RVA: 0x1612DFC Offset: 0x160EDFC VA: 0x1612DFC
	public void set_Packed(bool value) { }

	// RVA: 0x1612E10 Offset: 0x160EE10 VA: 0x1612E10
	public bool get_HasPacked() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1612E1C Offset: 0x160EE1C VA: 0x1612E1C
	public void ClearPacked() { }

	// RVA: 0x1612E2C Offset: 0x160EE2C VA: 0x1612E2C
	public FieldOptions.Types.JSType get_Jstype() { }

	// RVA: 0x1612E9C Offset: 0x160EE9C VA: 0x1612E9C
	public void set_Jstype(FieldOptions.Types.JSType value) { }

	// RVA: 0x1612EB0 Offset: 0x160EEB0 VA: 0x1612EB0
	public bool get_HasJstype() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1612EBC Offset: 0x160EEBC VA: 0x1612EBC
	public void ClearJstype() { }

	// RVA: 0x1612ECC Offset: 0x160EECC VA: 0x1612ECC
	public bool get_Lazy() { }

	// RVA: 0x1612F3C Offset: 0x160EF3C VA: 0x1612F3C
	public void set_Lazy(bool value) { }

	// RVA: 0x1612F50 Offset: 0x160EF50 VA: 0x1612F50
	public bool get_HasLazy() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1612F5C Offset: 0x160EF5C VA: 0x1612F5C
	public void ClearLazy() { }

	// RVA: 0x1612F6C Offset: 0x160EF6C VA: 0x1612F6C
	public bool get_UnverifiedLazy() { }

	// RVA: 0x1612FDC Offset: 0x160EFDC VA: 0x1612FDC
	public void set_UnverifiedLazy(bool value) { }

	// RVA: 0x1612FF0 Offset: 0x160EFF0 VA: 0x1612FF0
	public bool get_HasUnverifiedLazy() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1612FFC Offset: 0x160EFFC VA: 0x1612FFC
	public void ClearUnverifiedLazy() { }

	// RVA: 0x161300C Offset: 0x160F00C VA: 0x161300C
	public bool get_Deprecated() { }

	// RVA: 0x161307C Offset: 0x160F07C VA: 0x161307C
	public void set_Deprecated(bool value) { }

	// RVA: 0x1613090 Offset: 0x160F090 VA: 0x1613090
	public bool get_HasDeprecated() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161309C Offset: 0x160F09C VA: 0x161309C
	public void ClearDeprecated() { }

	// RVA: 0x16130AC Offset: 0x160F0AC VA: 0x16130AC
	public bool get_Weak() { }

	// RVA: 0x161311C Offset: 0x160F11C VA: 0x161311C
	public void set_Weak(bool value) { }

	// RVA: 0x1613130 Offset: 0x160F130 VA: 0x1613130
	public bool get_HasWeak() { }

	[Obsolete]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161313C Offset: 0x160F13C VA: 0x161313C
	public void ClearWeak() { }

	// RVA: 0x161314C Offset: 0x160F14C VA: 0x161314C
	public bool get_DebugRedact() { }

	// RVA: 0x16131BC Offset: 0x160F1BC VA: 0x16131BC
	public void set_DebugRedact(bool value) { }

	// RVA: 0x16131D0 Offset: 0x160F1D0 VA: 0x16131D0
	public bool get_HasDebugRedact() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16131DC Offset: 0x160F1DC VA: 0x16131DC
	public void ClearDebugRedact() { }

	// RVA: 0x16131EC Offset: 0x160F1EC VA: 0x16131EC
	public FieldOptions.Types.OptionRetention get_Retention() { }

	// RVA: 0x161325C Offset: 0x160F25C VA: 0x161325C
	public void set_Retention(FieldOptions.Types.OptionRetention value) { }

	// RVA: 0x1613270 Offset: 0x160F270 VA: 0x1613270
	public bool get_HasRetention() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161327C Offset: 0x160F27C VA: 0x161327C
	public void ClearRetention() { }

	// RVA: 0x161328C Offset: 0x160F28C VA: 0x161328C
	public RepeatedField<FieldOptions.Types.OptionTargetType> get_Targets() { }

	// RVA: 0x1613294 Offset: 0x160F294 VA: 0x1613294
	public RepeatedField<FieldOptions.Types.EditionDefault> get_EditionDefaults() { }

	// RVA: 0x161329C Offset: 0x160F29C VA: 0x161329C
	public FeatureSet get_Features() { }

	// RVA: 0x16132A4 Offset: 0x160F2A4 VA: 0x16132A4
	public void set_Features(FeatureSet value) { }

	// RVA: 0x16132AC Offset: 0x160F2AC VA: 0x16132AC
	public FieldOptions.Types.FeatureSupport get_FeatureSupport() { }

	// RVA: 0x16132B4 Offset: 0x160F2B4 VA: 0x16132B4
	public void set_FeatureSupport(FieldOptions.Types.FeatureSupport value) { }

	// RVA: 0x16132BC Offset: 0x160F2BC VA: 0x16132BC
	public RepeatedField<UninterpretedOption> get_UninterpretedOption() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16132C4 Offset: 0x160F2C4 VA: 0x16132C4 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1613328 Offset: 0x160F328 VA: 0x1613328 Slot: 15
	public bool Equals(FieldOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1613548 Offset: 0x160F548 VA: 0x1613548 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1613834 Offset: 0x160F834 VA: 0x1613834 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161388C Offset: 0x160F88C VA: 0x161388C Slot: 12
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16138AC Offset: 0x160F8AC VA: 0x16138AC Slot: 18
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1613C38 Offset: 0x160FC38 VA: 0x1613C38 Slot: 13
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1613EEC Offset: 0x160FEEC VA: 0x1613EEC Slot: 10
	public void MergeFrom(FieldOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16142D0 Offset: 0x16102D0 VA: 0x16142D0 Slot: 11
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16142F0 Offset: 0x16102F0 VA: 0x16142F0 Slot: 17
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: -1 Offset: -1 Slot: 4
	public TValue GetExtension<TValue>(Extension<FieldOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114A08 Offset: 0x1110A08 VA: 0x1114A08
	|-FieldOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114ACC Offset: 0x1110ACC VA: 0x1114ACC
	|-FieldOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114B10 Offset: 0x1110B10 VA: 0x1114B10
	|-FieldOptions.GetOrInitializeExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SetExtension<TValue>(Extension<FieldOptions, TValue> extension, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114B98 Offset: 0x1110B98 VA: 0x1114B98
	|-FieldOptions.SetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasExtension<TValue>(Extension<FieldOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114B54 Offset: 0x1110B54 VA: 0x1114B54
	|-FieldOptions.HasExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void ClearExtension<TValue>(Extension<FieldOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114980 Offset: 0x1110980 VA: 0x1114980
	|-FieldOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void ClearExtension<TValue>(RepeatedExtension<FieldOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11149C4 Offset: 0x11109C4 VA: 0x11149C4
	|-FieldOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1614910 Offset: 0x1610910 VA: 0x1614910
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class OneofOptions.<>c // TypeDefIndex: 6453
{
	// Fields
	public static readonly OneofOptions.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1617040 Offset: 0x1613040 VA: 0x1617040
	private static void .cctor() { }

	// RVA: 0x16170A8 Offset: 0x16130A8 VA: 0x16170A8
	public void .ctor() { }

	// RVA: 0x16170B0 Offset: 0x16130B0 VA: 0x16170B0
	internal OneofOptions <.cctor>b__42_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OneofOptions : IExtendableMessage<OneofOptions>, IMessage<OneofOptions>, IMessage, IEquatable<OneofOptions>, IDeepCloneable<OneofOptions>, IBufferMessage // TypeDefIndex: 6454
{
	// Fields
	private static readonly MessageParser<OneofOptions> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	internal ExtensionSet<OneofOptions> _extensions; // 0x18
	private FeatureSet features_; // 0x20
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x8
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x28

	// Properties
	private ExtensionSet<OneofOptions> _Extensions { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<OneofOptions> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet Features { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<UninterpretedOption> UninterpretedOption { get; }

	// Methods

	// RVA: 0x1616588 Offset: 0x1612588 VA: 0x1616588
	private ExtensionSet<OneofOptions> get__Extensions() { }

	// RVA: 0x1616590 Offset: 0x1612590 VA: 0x1616590
	public static MessageParser<OneofOptions> get_Parser() { }

	// RVA: 0x16165E8 Offset: 0x16125E8 VA: 0x16165E8
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16166EC Offset: 0x16126EC VA: 0x16166EC Slot: 14
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16081D0 Offset: 0x16041D0 VA: 0x16081D0
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1616738 Offset: 0x1612738 VA: 0x1616738
	public void .ctor(OneofOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1607BF8 Offset: 0x1603BF8 VA: 0x1607BF8 Slot: 16
	public OneofOptions Clone() { }

	// RVA: 0x1616824 Offset: 0x1612824 VA: 0x1616824
	public FeatureSet get_Features() { }

	// RVA: 0x161682C Offset: 0x161282C VA: 0x161682C
	public void set_Features(FeatureSet value) { }

	// RVA: 0x1616834 Offset: 0x1612834 VA: 0x1616834
	public RepeatedField<UninterpretedOption> get_UninterpretedOption() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161683C Offset: 0x161283C VA: 0x161683C Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16168A0 Offset: 0x16128A0 VA: 0x16168A0 Slot: 15
	public bool Equals(OneofOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1616958 Offset: 0x1612958 VA: 0x1616958 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16169E4 Offset: 0x16129E4 VA: 0x16169E4 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1616A3C Offset: 0x1612A3C VA: 0x1616A3C Slot: 12
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1616A5C Offset: 0x1612A5C VA: 0x1616A5C Slot: 18
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1616B64 Offset: 0x1612B64 VA: 0x1616B64 Slot: 13
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1608258 Offset: 0x1604258 VA: 0x1608258 Slot: 10
	public void MergeFrom(OneofOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1616C80 Offset: 0x1612C80 VA: 0x1616C80 Slot: 11
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1616CA0 Offset: 0x1612CA0 VA: 0x1616CA0 Slot: 17
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: -1 Offset: -1 Slot: 4
	public TValue GetExtension<TValue>(Extension<OneofOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113A5E4 Offset: 0x11365E4 VA: 0x113A5E4
	|-OneofOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<OneofOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113A6A8 Offset: 0x11366A8 VA: 0x113A6A8
	|-OneofOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<OneofOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113A6EC Offset: 0x11366EC VA: 0x113A6EC
	|-OneofOptions.GetOrInitializeExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SetExtension<TValue>(Extension<OneofOptions, TValue> extension, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113A774 Offset: 0x1136774 VA: 0x113A774
	|-OneofOptions.SetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasExtension<TValue>(Extension<OneofOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113A730 Offset: 0x1136730 VA: 0x113A730
	|-OneofOptions.HasExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void ClearExtension<TValue>(Extension<OneofOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113A55C Offset: 0x113655C VA: 0x113A55C
	|-OneofOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void ClearExtension<TValue>(RepeatedExtension<OneofOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113A5A0 Offset: 0x11365A0 VA: 0x113A5A0
	|-OneofOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1616E90 Offset: 0x1612E90 VA: 0x1616E90
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EnumOptions.<>c // TypeDefIndex: 6455
{
	// Fields
	public static readonly EnumOptions.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16180A4 Offset: 0x16140A4 VA: 0x16180A4
	private static void .cctor() { }

	// RVA: 0x161810C Offset: 0x161410C VA: 0x161810C
	public void .ctor() { }

	// RVA: 0x1618114 Offset: 0x1614114 VA: 0x1618114
	internal EnumOptions <.cctor>b__70_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnumOptions : IExtendableMessage<EnumOptions>, IMessage<EnumOptions>, IMessage, IEquatable<EnumOptions>, IDeepCloneable<EnumOptions>, IBufferMessage // TypeDefIndex: 6456
{
	// Fields
	private static readonly MessageParser<EnumOptions> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	internal ExtensionSet<EnumOptions> _extensions; // 0x18
	private int _hasBits0; // 0x20
	private static readonly bool AllowAliasDefaultValue; // 0x8
	private bool allowAlias_; // 0x24
	private static readonly bool DeprecatedDefaultValue; // 0x9
	private bool deprecated_; // 0x25
	private static readonly bool DeprecatedLegacyJsonFieldConflictsDefaultValue; // 0xA
	private bool deprecatedLegacyJsonFieldConflicts_; // 0x26
	private FeatureSet features_; // 0x28
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x30

	// Properties
	private ExtensionSet<EnumOptions> _Extensions { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnumOptions> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool AllowAlias { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasAllowAlias { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Deprecated { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDeprecated { get; }
	[Obsolete]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DeprecatedLegacyJsonFieldConflicts { get; set; }
	[Obsolete]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDeprecatedLegacyJsonFieldConflicts { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet Features { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<UninterpretedOption> UninterpretedOption { get; }

	// Methods

	// RVA: 0x1617100 Offset: 0x1613100 VA: 0x1617100
	private ExtensionSet<EnumOptions> get__Extensions() { }

	// RVA: 0x1617108 Offset: 0x1613108 VA: 0x1617108
	public static MessageParser<EnumOptions> get_Parser() { }

	// RVA: 0x1617160 Offset: 0x1613160 VA: 0x1617160
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x1617264 Offset: 0x1613264 VA: 0x1617264 Slot: 14
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16095B4 Offset: 0x16055B4 VA: 0x16095B4
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16172B0 Offset: 0x16132B0 VA: 0x16172B0
	public void .ctor(EnumOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1608B14 Offset: 0x1604B14 VA: 0x1608B14 Slot: 16
	public EnumOptions Clone() { }

	// RVA: 0x16173AC Offset: 0x16133AC VA: 0x16173AC
	public bool get_AllowAlias() { }

	// RVA: 0x161741C Offset: 0x161341C VA: 0x161741C
	public void set_AllowAlias(bool value) { }

	// RVA: 0x1617430 Offset: 0x1613430 VA: 0x1617430
	public bool get_HasAllowAlias() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161743C Offset: 0x161343C VA: 0x161743C
	public void ClearAllowAlias() { }

	// RVA: 0x161744C Offset: 0x161344C VA: 0x161744C
	public bool get_Deprecated() { }

	// RVA: 0x16174BC Offset: 0x16134BC VA: 0x16174BC
	public void set_Deprecated(bool value) { }

	// RVA: 0x16174D0 Offset: 0x16134D0 VA: 0x16174D0
	public bool get_HasDeprecated() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16174DC Offset: 0x16134DC VA: 0x16174DC
	public void ClearDeprecated() { }

	// RVA: 0x16174EC Offset: 0x16134EC VA: 0x16174EC
	public bool get_DeprecatedLegacyJsonFieldConflicts() { }

	// RVA: 0x161755C Offset: 0x161355C VA: 0x161755C
	public void set_DeprecatedLegacyJsonFieldConflicts(bool value) { }

	// RVA: 0x1617570 Offset: 0x1613570 VA: 0x1617570
	public bool get_HasDeprecatedLegacyJsonFieldConflicts() { }

	[Obsolete]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161757C Offset: 0x161357C VA: 0x161757C
	public void ClearDeprecatedLegacyJsonFieldConflicts() { }

	// RVA: 0x161758C Offset: 0x161358C VA: 0x161758C
	public FeatureSet get_Features() { }

	// RVA: 0x1617594 Offset: 0x1613594 VA: 0x1617594
	public void set_Features(FeatureSet value) { }

	// RVA: 0x161759C Offset: 0x161359C VA: 0x161759C
	public RepeatedField<UninterpretedOption> get_UninterpretedOption() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16175A4 Offset: 0x16135A4 VA: 0x16175A4 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1617608 Offset: 0x1613608 VA: 0x1617608 Slot: 15
	public bool Equals(EnumOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1617714 Offset: 0x1613714 VA: 0x1617714 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161786C Offset: 0x161386C VA: 0x161786C Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16178C4 Offset: 0x16138C4 VA: 0x16178C4 Slot: 12
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16178E4 Offset: 0x16138E4 VA: 0x16178E4 Slot: 18
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1617A88 Offset: 0x1613A88 VA: 0x1617A88 Slot: 13
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160963C Offset: 0x160563C VA: 0x160963C Slot: 10
	public void MergeFrom(EnumOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1617BBC Offset: 0x1613BBC VA: 0x1617BBC Slot: 11
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1617BDC Offset: 0x1613BDC VA: 0x1617BDC Slot: 17
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: -1 Offset: -1 Slot: 4
	public TValue GetExtension<TValue>(Extension<EnumOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FA990 Offset: 0x10F6990 VA: 0x10FA990
	|-EnumOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAA54 Offset: 0x10F6A54 VA: 0x10FAA54
	|-EnumOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAA98 Offset: 0x10F6A98 VA: 0x10FAA98
	|-EnumOptions.GetOrInitializeExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SetExtension<TValue>(Extension<EnumOptions, TValue> extension, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAB20 Offset: 0x10F6B20 VA: 0x10FAB20
	|-EnumOptions.SetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasExtension<TValue>(Extension<EnumOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAADC Offset: 0x10F6ADC VA: 0x10FAADC
	|-EnumOptions.HasExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void ClearExtension<TValue>(Extension<EnumOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FA908 Offset: 0x10F6908 VA: 0x10FA908
	|-EnumOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void ClearExtension<TValue>(RepeatedExtension<EnumOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FA94C Offset: 0x10F694C VA: 0x10FA94C
	|-EnumOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1617EE4 Offset: 0x1613EE4 VA: 0x1617EE4
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class EnumValueOptions.<>c // TypeDefIndex: 6457
{
	// Fields
	public static readonly EnumValueOptions.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1619070 Offset: 0x1615070 VA: 0x1619070
	private static void .cctor() { }

	// RVA: 0x16190D8 Offset: 0x16150D8 VA: 0x16190D8
	public void .ctor() { }

	// RVA: 0x16190E0 Offset: 0x16150E0 VA: 0x16190E0
	internal EnumValueOptions <.cctor>b__66_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class EnumValueOptions : IExtendableMessage<EnumValueOptions>, IMessage<EnumValueOptions>, IMessage, IEquatable<EnumValueOptions>, IDeepCloneable<EnumValueOptions>, IBufferMessage // TypeDefIndex: 6458
{
	// Fields
	private static readonly MessageParser<EnumValueOptions> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	internal ExtensionSet<EnumValueOptions> _extensions; // 0x18
	private int _hasBits0; // 0x20
	private static readonly bool DeprecatedDefaultValue; // 0x8
	private bool deprecated_; // 0x24
	private FeatureSet features_; // 0x28
	private static readonly bool DebugRedactDefaultValue; // 0x9
	private bool debugRedact_; // 0x30
	private FieldOptions.Types.FeatureSupport featureSupport_; // 0x38
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x40

	// Properties
	private ExtensionSet<EnumValueOptions> _Extensions { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<EnumValueOptions> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Deprecated { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDeprecated { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet Features { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool DebugRedact { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDebugRedact { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FieldOptions.Types.FeatureSupport FeatureSupport { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<UninterpretedOption> UninterpretedOption { get; }

	// Methods

	// RVA: 0x1618164 Offset: 0x1614164 VA: 0x1618164
	private ExtensionSet<EnumValueOptions> get__Extensions() { }

	// RVA: 0x161816C Offset: 0x161416C VA: 0x161816C
	public static MessageParser<EnumValueOptions> get_Parser() { }

	// RVA: 0x16181C4 Offset: 0x16141C4 VA: 0x16181C4
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16182C8 Offset: 0x16142C8 VA: 0x16182C8 Slot: 14
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160B234 Offset: 0x1607234 VA: 0x160B234
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1618314 Offset: 0x1614314 VA: 0x1618314
	public void .ctor(EnumValueOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160AAEC Offset: 0x1606AEC VA: 0x160AAEC Slot: 16
	public EnumValueOptions Clone() { }

	// RVA: 0x1618430 Offset: 0x1614430 VA: 0x1618430
	public bool get_Deprecated() { }

	// RVA: 0x16184A0 Offset: 0x16144A0 VA: 0x16184A0
	public void set_Deprecated(bool value) { }

	// RVA: 0x16184B4 Offset: 0x16144B4 VA: 0x16184B4
	public bool get_HasDeprecated() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16184C0 Offset: 0x16144C0 VA: 0x16184C0
	public void ClearDeprecated() { }

	// RVA: 0x16184D0 Offset: 0x16144D0 VA: 0x16184D0
	public FeatureSet get_Features() { }

	// RVA: 0x16184D8 Offset: 0x16144D8 VA: 0x16184D8
	public void set_Features(FeatureSet value) { }

	// RVA: 0x16184E0 Offset: 0x16144E0 VA: 0x16184E0
	public bool get_DebugRedact() { }

	// RVA: 0x1618550 Offset: 0x1614550 VA: 0x1618550
	public void set_DebugRedact(bool value) { }

	// RVA: 0x1618564 Offset: 0x1614564 VA: 0x1618564
	public bool get_HasDebugRedact() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1618570 Offset: 0x1614570 VA: 0x1618570
	public void ClearDebugRedact() { }

	// RVA: 0x1618580 Offset: 0x1614580 VA: 0x1618580
	public FieldOptions.Types.FeatureSupport get_FeatureSupport() { }

	// RVA: 0x1618588 Offset: 0x1614588 VA: 0x1618588
	public void set_FeatureSupport(FieldOptions.Types.FeatureSupport value) { }

	// RVA: 0x1618590 Offset: 0x1614590 VA: 0x1618590
	public RepeatedField<UninterpretedOption> get_UninterpretedOption() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1618598 Offset: 0x1614598 VA: 0x1618598 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16185FC Offset: 0x16145FC VA: 0x16185FC Slot: 15
	public bool Equals(EnumValueOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1618700 Offset: 0x1614700 VA: 0x1618700 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1618830 Offset: 0x1614830 VA: 0x1618830 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1618888 Offset: 0x1614888 VA: 0x1618888 Slot: 12
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16188A8 Offset: 0x16148A8 VA: 0x16188A8 Slot: 18
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1618A38 Offset: 0x1614A38 VA: 0x1618A38 Slot: 13
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160B2BC Offset: 0x16072BC VA: 0x160B2BC Slot: 10
	public void MergeFrom(EnumValueOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1618B90 Offset: 0x1614B90 VA: 0x1618B90 Slot: 11
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1618BB0 Offset: 0x1614BB0 VA: 0x1618BB0 Slot: 17
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: -1 Offset: -1 Slot: 4
	public TValue GetExtension<TValue>(Extension<EnumValueOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAC8C Offset: 0x10F6C8C VA: 0x10FAC8C
	|-EnumValueOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAD50 Offset: 0x10F6D50 VA: 0x10FAD50
	|-EnumValueOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAD94 Offset: 0x10F6D94 VA: 0x10FAD94
	|-EnumValueOptions.GetOrInitializeExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SetExtension<TValue>(Extension<EnumValueOptions, TValue> extension, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAE1C Offset: 0x10F6E1C VA: 0x10FAE1C
	|-EnumValueOptions.SetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasExtension<TValue>(Extension<EnumValueOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FADD8 Offset: 0x10F6DD8 VA: 0x10FADD8
	|-EnumValueOptions.HasExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void ClearExtension<TValue>(Extension<EnumValueOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAC04 Offset: 0x10F6C04 VA: 0x10FAC04
	|-EnumValueOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void ClearExtension<TValue>(RepeatedExtension<EnumValueOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FAC48 Offset: 0x10F6C48 VA: 0x10FAC48
	|-EnumValueOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1618EB4 Offset: 0x1614EB4 VA: 0x1618EB4
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ServiceOptions.<>c // TypeDefIndex: 6459
{
	// Fields
	public static readonly ServiceOptions.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1619DA0 Offset: 0x1615DA0 VA: 0x1619DA0
	private static void .cctor() { }

	// RVA: 0x1619E08 Offset: 0x1615E08 VA: 0x1619E08
	public void .ctor() { }

	// RVA: 0x1619E10 Offset: 0x1615E10 VA: 0x1619E10
	internal ServiceOptions <.cctor>b__52_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ServiceOptions : IExtendableMessage<ServiceOptions>, IMessage<ServiceOptions>, IMessage, IEquatable<ServiceOptions>, IDeepCloneable<ServiceOptions>, IBufferMessage // TypeDefIndex: 6460
{
	// Fields
	private static readonly MessageParser<ServiceOptions> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	internal ExtensionSet<ServiceOptions> _extensions; // 0x18
	private int _hasBits0; // 0x20
	private FeatureSet features_; // 0x28
	private static readonly bool DeprecatedDefaultValue; // 0x8
	private bool deprecated_; // 0x30
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x38

	// Properties
	private ExtensionSet<ServiceOptions> _Extensions { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ServiceOptions> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet Features { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Deprecated { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDeprecated { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<UninterpretedOption> UninterpretedOption { get; }

	// Methods

	// RVA: 0x1619130 Offset: 0x1615130 VA: 0x1619130
	private ExtensionSet<ServiceOptions> get__Extensions() { }

	// RVA: 0x1619138 Offset: 0x1615138 VA: 0x1619138
	public static MessageParser<ServiceOptions> get_Parser() { }

	// RVA: 0x1619190 Offset: 0x1615190 VA: 0x1619190
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x1619294 Offset: 0x1615294 VA: 0x1619294 Slot: 14
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160C2B0 Offset: 0x16082B0 VA: 0x160C2B0
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16192E0 Offset: 0x16152E0 VA: 0x16192E0
	public void .ctor(ServiceOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160BB68 Offset: 0x1607B68 VA: 0x160BB68 Slot: 16
	public ServiceOptions Clone() { }

	// RVA: 0x16193D0 Offset: 0x16153D0 VA: 0x16193D0
	public FeatureSet get_Features() { }

	// RVA: 0x16193D8 Offset: 0x16153D8 VA: 0x16193D8
	public void set_Features(FeatureSet value) { }

	// RVA: 0x16193E0 Offset: 0x16153E0 VA: 0x16193E0
	public bool get_Deprecated() { }

	// RVA: 0x1619450 Offset: 0x1615450 VA: 0x1619450
	public void set_Deprecated(bool value) { }

	// RVA: 0x1619464 Offset: 0x1615464 VA: 0x1619464
	public bool get_HasDeprecated() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1619470 Offset: 0x1615470 VA: 0x1619470
	public void ClearDeprecated() { }

	// RVA: 0x1619480 Offset: 0x1615480 VA: 0x1619480
	public RepeatedField<UninterpretedOption> get_UninterpretedOption() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1619488 Offset: 0x1615488 VA: 0x1619488 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16194EC Offset: 0x16154EC VA: 0x16194EC Slot: 15
	public bool Equals(ServiceOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16195C0 Offset: 0x16155C0 VA: 0x16195C0 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1619694 Offset: 0x1615694 VA: 0x1619694 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16196EC Offset: 0x16156EC VA: 0x16196EC Slot: 12
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161970C Offset: 0x161570C VA: 0x161970C Slot: 18
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161984C Offset: 0x161584C VA: 0x161984C Slot: 13
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160C338 Offset: 0x1608338 VA: 0x160C338 Slot: 10
	public void MergeFrom(ServiceOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1619978 Offset: 0x1615978 VA: 0x1619978 Slot: 11
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1619998 Offset: 0x1615998 VA: 0x1619998 Slot: 17
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: -1 Offset: -1 Slot: 4
	public TValue GetExtension<TValue>(Extension<ServiceOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1148598 Offset: 0x1144598 VA: 0x1148598
	|-ServiceOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114865C Offset: 0x114465C VA: 0x114865C
	|-ServiceOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11486A0 Offset: 0x11446A0 VA: 0x11486A0
	|-ServiceOptions.GetOrInitializeExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SetExtension<TValue>(Extension<ServiceOptions, TValue> extension, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1148728 Offset: 0x1144728 VA: 0x1148728
	|-ServiceOptions.SetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasExtension<TValue>(Extension<ServiceOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11486E4 Offset: 0x11446E4 VA: 0x11486E4
	|-ServiceOptions.HasExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void ClearExtension<TValue>(Extension<ServiceOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1148510 Offset: 0x1144510 VA: 0x1148510
	|-ServiceOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void ClearExtension<TValue>(RepeatedExtension<ServiceOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1148554 Offset: 0x1144554 VA: 0x1148554
	|-ServiceOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1619BE4 Offset: 0x1615BE4 VA: 0x1619BE4
	private static void .cctor() { }
}

// Namespace: 
public enum MethodOptions.Types.IdempotencyLevel // TypeDefIndex: 6461
{
	// Fields
	public int value__; // 0x0
	[OriginalName("IDEMPOTENCY_UNKNOWN")]
	public const MethodOptions.Types.IdempotencyLevel IdempotencyUnknown = 0;
	[OriginalName("NO_SIDE_EFFECTS")]
	public const MethodOptions.Types.IdempotencyLevel NoSideEffects = 1;
	[OriginalName("IDEMPOTENT")]
	public const MethodOptions.Types.IdempotencyLevel Idempotent = 2;
}

// Namespace: 
[DebuggerNonUserCode]
[GeneratedCode("protoc", null)]
public static class MethodOptions.Types // TypeDefIndex: 6462
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MethodOptions.<>c // TypeDefIndex: 6463
{
	// Fields
	public static readonly MethodOptions.<>c <>9; // 0x0

	// Methods

	// RVA: 0x161AC88 Offset: 0x1616C88 VA: 0x161AC88
	private static void .cctor() { }

	// RVA: 0x161ACF0 Offset: 0x1616CF0 VA: 0x161ACF0
	public void .ctor() { }

	// RVA: 0x161ACF8 Offset: 0x1616CF8 VA: 0x161ACF8
	internal MethodOptions <.cctor>b__62_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MethodOptions : IExtendableMessage<MethodOptions>, IMessage<MethodOptions>, IMessage, IEquatable<MethodOptions>, IDeepCloneable<MethodOptions>, IBufferMessage // TypeDefIndex: 6464
{
	// Fields
	private static readonly MessageParser<MethodOptions> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	internal ExtensionSet<MethodOptions> _extensions; // 0x18
	private int _hasBits0; // 0x20
	private static readonly bool DeprecatedDefaultValue; // 0x8
	private bool deprecated_; // 0x24
	private static readonly MethodOptions.Types.IdempotencyLevel IdempotencyLevelDefaultValue; // 0xC
	private MethodOptions.Types.IdempotencyLevel idempotencyLevel_; // 0x28
	private FeatureSet features_; // 0x30
	private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec; // 0x10
	private readonly RepeatedField<UninterpretedOption> uninterpretedOption_; // 0x38

	// Properties
	private ExtensionSet<MethodOptions> _Extensions { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MethodOptions> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Deprecated { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDeprecated { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MethodOptions.Types.IdempotencyLevel IdempotencyLevel { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasIdempotencyLevel { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet Features { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<UninterpretedOption> UninterpretedOption { get; }

	// Methods

	// RVA: 0x1619E60 Offset: 0x1615E60 VA: 0x1619E60
	private ExtensionSet<MethodOptions> get__Extensions() { }

	// RVA: 0x1619E68 Offset: 0x1615E68 VA: 0x1619E68
	public static MessageParser<MethodOptions> get_Parser() { }

	// RVA: 0x1619EC0 Offset: 0x1615EC0 VA: 0x1619EC0
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x1619FC4 Offset: 0x1615FC4 VA: 0x1619FC4 Slot: 14
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160D7A8 Offset: 0x16097A8 VA: 0x160D7A8
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161A010 Offset: 0x1616010 VA: 0x161A010
	public void .ctor(MethodOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160CB70 Offset: 0x1608B70 VA: 0x160CB70 Slot: 16
	public MethodOptions Clone() { }

	// RVA: 0x161A104 Offset: 0x1616104 VA: 0x161A104
	public bool get_Deprecated() { }

	// RVA: 0x161A174 Offset: 0x1616174 VA: 0x161A174
	public void set_Deprecated(bool value) { }

	// RVA: 0x161A188 Offset: 0x1616188 VA: 0x161A188
	public bool get_HasDeprecated() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161A194 Offset: 0x1616194 VA: 0x161A194
	public void ClearDeprecated() { }

	// RVA: 0x161A1A4 Offset: 0x16161A4 VA: 0x161A1A4
	public MethodOptions.Types.IdempotencyLevel get_IdempotencyLevel() { }

	// RVA: 0x161A214 Offset: 0x1616214 VA: 0x161A214
	public void set_IdempotencyLevel(MethodOptions.Types.IdempotencyLevel value) { }

	// RVA: 0x161A228 Offset: 0x1616228 VA: 0x161A228
	public bool get_HasIdempotencyLevel() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161A234 Offset: 0x1616234 VA: 0x161A234
	public void ClearIdempotencyLevel() { }

	// RVA: 0x161A244 Offset: 0x1616244 VA: 0x161A244
	public FeatureSet get_Features() { }

	// RVA: 0x161A24C Offset: 0x161624C VA: 0x161A24C
	public void set_Features(FeatureSet value) { }

	// RVA: 0x161A254 Offset: 0x1616254 VA: 0x161A254
	public RepeatedField<UninterpretedOption> get_UninterpretedOption() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161A25C Offset: 0x161625C VA: 0x161A25C Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161A2C0 Offset: 0x16162C0 VA: 0x161A2C0 Slot: 15
	public bool Equals(MethodOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161A3B0 Offset: 0x16163B0 VA: 0x161A3B0 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161A4B0 Offset: 0x16164B0 VA: 0x161A4B0 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161A508 Offset: 0x1616508 VA: 0x161A508 Slot: 12
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161A528 Offset: 0x1616528 VA: 0x161A528 Slot: 18
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161A69C Offset: 0x161669C VA: 0x161A69C Slot: 13
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x160D830 Offset: 0x1609830 VA: 0x160D830 Slot: 10
	public void MergeFrom(MethodOptions other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161A7F8 Offset: 0x16167F8 VA: 0x161A7F8 Slot: 11
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161A818 Offset: 0x1616818 VA: 0x161A818 Slot: 17
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: -1 Offset: -1 Slot: 4
	public TValue GetExtension<TValue>(Extension<MethodOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136C78 Offset: 0x1132C78 VA: 0x1136C78
	|-MethodOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136D3C Offset: 0x1132D3C VA: 0x1136D3C
	|-MethodOptions.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136D80 Offset: 0x1132D80 VA: 0x1136D80
	|-MethodOptions.GetOrInitializeExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SetExtension<TValue>(Extension<MethodOptions, TValue> extension, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136E08 Offset: 0x1132E08 VA: 0x1136E08
	|-MethodOptions.SetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasExtension<TValue>(Extension<MethodOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136DC4 Offset: 0x1132DC4 VA: 0x1136DC4
	|-MethodOptions.HasExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void ClearExtension<TValue>(Extension<MethodOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136BF0 Offset: 0x1132BF0 VA: 0x1136BF0
	|-MethodOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void ClearExtension<TValue>(RepeatedExtension<MethodOptions, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136C34 Offset: 0x1132C34 VA: 0x1136C34
	|-MethodOptions.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x161AAC8 Offset: 0x1616AC8 VA: 0x161AAC8
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UninterpretedOption.Types.NamePart.<>c // TypeDefIndex: 6465
{
	// Fields
	public static readonly UninterpretedOption.Types.NamePart.<>c <>9; // 0x0

	// Methods

	// RVA: 0x161CF58 Offset: 0x1618F58 VA: 0x161CF58
	private static void .cctor() { }

	// RVA: 0x161CFC0 Offset: 0x1618FC0 VA: 0x161CFC0
	public void .ctor() { }

	// RVA: 0x161CFC8 Offset: 0x1618FC8 VA: 0x161CFC8
	internal UninterpretedOption.Types.NamePart <.cctor>b__41_0() { }
}

// Namespace: 
[DebuggerDisplay("{ToString(),nq}")]
public sealed class UninterpretedOption.Types.NamePart : IMessage<UninterpretedOption.Types.NamePart>, IMessage, IEquatable<UninterpretedOption.Types.NamePart>, IDeepCloneable<UninterpretedOption.Types.NamePart>, IBufferMessage // TypeDefIndex: 6466
{
	// Fields
	private static readonly MessageParser<UninterpretedOption.Types.NamePart> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly string NamePart_DefaultValue; // 0x8
	private string namePart_; // 0x20
	private static readonly bool IsExtensionDefaultValue; // 0x10
	private bool isExtension_; // 0x28

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UninterpretedOption.Types.NamePart> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string NamePart_ { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasNamePart_ { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsExtension { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasIsExtension { get; }

	// Methods

	// RVA: 0x161C524 Offset: 0x1618524 VA: 0x161C524
	public static MessageParser<UninterpretedOption.Types.NamePart> get_Parser() { }

	// RVA: 0x161C57C Offset: 0x161857C VA: 0x161C57C
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x161C64C Offset: 0x161864C VA: 0x161C64C Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161C698 Offset: 0x1618698 VA: 0x161C698
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161C6A0 Offset: 0x16186A0 VA: 0x161C6A0
	public void .ctor(UninterpretedOption.Types.NamePart other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161C704 Offset: 0x1618704 VA: 0x161C704 Slot: 10
	public UninterpretedOption.Types.NamePart Clone() { }

	// RVA: 0x161C75C Offset: 0x161875C VA: 0x161C75C
	public string get_NamePart_() { }

	// RVA: 0x161C7C0 Offset: 0x16187C0 VA: 0x161C7C0
	public void set_NamePart_(string value) { }

	// RVA: 0x161C83C Offset: 0x161883C VA: 0x161C83C
	public bool get_HasNamePart_() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161C84C Offset: 0x161884C VA: 0x161C84C
	public void ClearNamePart_() { }

	// RVA: 0x161C858 Offset: 0x1618858 VA: 0x161C858
	public bool get_IsExtension() { }

	// RVA: 0x161C8C8 Offset: 0x16188C8 VA: 0x161C8C8
	public void set_IsExtension(bool value) { }

	// RVA: 0x161C8DC Offset: 0x16188DC VA: 0x161C8DC
	public bool get_HasIsExtension() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161C8E8 Offset: 0x16188E8 VA: 0x161C8E8
	public void ClearIsExtension() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161C8F8 Offset: 0x16188F8 VA: 0x161C8F8 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161C95C Offset: 0x161895C VA: 0x161C95C Slot: 9
	public bool Equals(UninterpretedOption.Types.NamePart other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161C9EC Offset: 0x16189EC VA: 0x161C9EC Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161CA98 Offset: 0x1618A98 VA: 0x161CA98 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161CAF0 Offset: 0x1618AF0 VA: 0x161CAF0 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161CB10 Offset: 0x1618B10 VA: 0x161CB10 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161CBA8 Offset: 0x1618BA8 VA: 0x161CBA8 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161CC44 Offset: 0x1618C44 VA: 0x161CC44 Slot: 4
	public void MergeFrom(UninterpretedOption.Types.NamePart other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161CCC4 Offset: 0x1618CC4 VA: 0x161CCC4 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161CCE4 Offset: 0x1618CE4 VA: 0x161CCE4 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x161CE08 Offset: 0x1618E08 VA: 0x161CE08
	private static void .cctor() { }
}

// Namespace: 
[DebuggerNonUserCode]
[GeneratedCode("protoc", null)]
public static class UninterpretedOption.Types // TypeDefIndex: 6467
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UninterpretedOption.<>c // TypeDefIndex: 6468
{
	// Fields
	public static readonly UninterpretedOption.<>c <>9; // 0x0

	// Methods

	// RVA: 0x161D01C Offset: 0x161901C VA: 0x161D01C
	private static void .cctor() { }

	// RVA: 0x161D084 Offset: 0x1619084 VA: 0x161D084
	public void .ctor() { }

	// RVA: 0x161D08C Offset: 0x161908C VA: 0x161D08C
	internal UninterpretedOption <.cctor>b__83_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class UninterpretedOption : IMessage<UninterpretedOption>, IMessage, IEquatable<UninterpretedOption>, IDeepCloneable<UninterpretedOption>, IBufferMessage // TypeDefIndex: 6469
{
	// Fields
	private static readonly MessageParser<UninterpretedOption> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly FieldCodec<UninterpretedOption.Types.NamePart> _repeated_name_codec; // 0x8
	private readonly RepeatedField<UninterpretedOption.Types.NamePart> name_; // 0x20
	private static readonly string IdentifierValueDefaultValue; // 0x10
	private string identifierValue_; // 0x28
	private static readonly ulong PositiveIntValueDefaultValue; // 0x18
	private ulong positiveIntValue_; // 0x30
	private static readonly long NegativeIntValueDefaultValue; // 0x20
	private long negativeIntValue_; // 0x38
	private static readonly double DoubleValueDefaultValue; // 0x28
	private double doubleValue_; // 0x40
	private static readonly ByteString StringValueDefaultValue; // 0x30
	private ByteString stringValue_; // 0x48
	private static readonly string AggregateValueDefaultValue; // 0x38
	private string aggregateValue_; // 0x50

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UninterpretedOption> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<UninterpretedOption.Types.NamePart> Name { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string IdentifierValue { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasIdentifierValue { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong PositiveIntValue { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasPositiveIntValue { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long NegativeIntValue { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasNegativeIntValue { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double DoubleValue { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDoubleValue { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ByteString StringValue { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasStringValue { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string AggregateValue { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasAggregateValue { get; }

	// Methods

	// RVA: 0x161AD48 Offset: 0x1616D48 VA: 0x161AD48
	public static MessageParser<UninterpretedOption> get_Parser() { }

	// RVA: 0x161ADA0 Offset: 0x1616DA0 VA: 0x161ADA0
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x161AEA4 Offset: 0x1616EA4 VA: 0x161AEA4 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161AEF0 Offset: 0x1616EF0 VA: 0x161AEF0
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161AF78 Offset: 0x1616F78 VA: 0x161AF78
	public void .ctor(UninterpretedOption other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161B04C Offset: 0x161704C VA: 0x161B04C Slot: 10
	public UninterpretedOption Clone() { }

	// RVA: 0x161B0A4 Offset: 0x16170A4 VA: 0x161B0A4
	public RepeatedField<UninterpretedOption.Types.NamePart> get_Name() { }

	// RVA: 0x161B0AC Offset: 0x16170AC VA: 0x161B0AC
	public string get_IdentifierValue() { }

	// RVA: 0x161B110 Offset: 0x1617110 VA: 0x161B110
	public void set_IdentifierValue(string value) { }

	// RVA: 0x161B18C Offset: 0x161718C VA: 0x161B18C
	public bool get_HasIdentifierValue() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161B19C Offset: 0x161719C VA: 0x161B19C
	public void ClearIdentifierValue() { }

	// RVA: 0x161B1A8 Offset: 0x16171A8 VA: 0x161B1A8
	public ulong get_PositiveIntValue() { }

	// RVA: 0x161B218 Offset: 0x1617218 VA: 0x161B218
	public void set_PositiveIntValue(ulong value) { }

	// RVA: 0x161B22C Offset: 0x161722C VA: 0x161B22C
	public bool get_HasPositiveIntValue() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161B238 Offset: 0x1617238 VA: 0x161B238
	public void ClearPositiveIntValue() { }

	// RVA: 0x161B248 Offset: 0x1617248 VA: 0x161B248
	public long get_NegativeIntValue() { }

	// RVA: 0x161B2B8 Offset: 0x16172B8 VA: 0x161B2B8
	public void set_NegativeIntValue(long value) { }

	// RVA: 0x161B2CC Offset: 0x16172CC VA: 0x161B2CC
	public bool get_HasNegativeIntValue() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161B2D8 Offset: 0x16172D8 VA: 0x161B2D8
	public void ClearNegativeIntValue() { }

	// RVA: 0x161B2E8 Offset: 0x16172E8 VA: 0x161B2E8
	public double get_DoubleValue() { }

	// RVA: 0x161B358 Offset: 0x1617358 VA: 0x161B358
	public void set_DoubleValue(double value) { }

	// RVA: 0x161B36C Offset: 0x161736C VA: 0x161B36C
	public bool get_HasDoubleValue() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161B378 Offset: 0x1617378 VA: 0x161B378
	public void ClearDoubleValue() { }

	// RVA: 0x161B388 Offset: 0x1617388 VA: 0x161B388
	public ByteString get_StringValue() { }

	// RVA: 0x161B3EC Offset: 0x16173EC VA: 0x161B3EC
	public void set_StringValue(ByteString value) { }

	// RVA: 0x161B468 Offset: 0x1617468 VA: 0x161B468
	public bool get_HasStringValue() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161B4C8 Offset: 0x16174C8 VA: 0x161B4C8
	public void ClearStringValue() { }

	// RVA: 0x161B4D4 Offset: 0x16174D4 VA: 0x161B4D4
	public string get_AggregateValue() { }

	// RVA: 0x161B538 Offset: 0x1617538 VA: 0x161B538
	public void set_AggregateValue(string value) { }

	// RVA: 0x161B5B4 Offset: 0x16175B4 VA: 0x161B5B4
	public bool get_HasAggregateValue() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161B5C4 Offset: 0x16175C4 VA: 0x161B5C4
	public void ClearAggregateValue() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161B5D0 Offset: 0x16175D0 VA: 0x161B5D0 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161B634 Offset: 0x1617634 VA: 0x161B634 Slot: 9
	public bool Equals(UninterpretedOption other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161B84C Offset: 0x161784C VA: 0x161B84C Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161BA14 Offset: 0x1617A14 VA: 0x161BA14 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161BA6C Offset: 0x1617A6C VA: 0x161BA6C Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161BA8C Offset: 0x1617A8C VA: 0x161BA8C Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161BC70 Offset: 0x1617C70 VA: 0x161BC70 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161BE70 Offset: 0x1617E70 VA: 0x161BE70 Slot: 4
	public void MergeFrom(UninterpretedOption other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161BFBC Offset: 0x1617FBC VA: 0x161BFBC Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161BFDC Offset: 0x1617FDC VA: 0x161BFDC Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x161C2B8 Offset: 0x16182B8 VA: 0x161C2B8
	private static void .cctor() { }
}

// Namespace: 
public enum FeatureSet.Types.FieldPresence // TypeDefIndex: 6470
{
	// Fields
	public int value__; // 0x0
	[OriginalName("FIELD_PRESENCE_UNKNOWN")]
	public const FeatureSet.Types.FieldPresence Unknown = 0;
	[OriginalName("EXPLICIT")]
	public const FeatureSet.Types.FieldPresence Explicit = 1;
	[OriginalName("IMPLICIT")]
	public const FeatureSet.Types.FieldPresence Implicit = 2;
	[OriginalName("LEGACY_REQUIRED")]
	public const FeatureSet.Types.FieldPresence LegacyRequired = 3;
}

// Namespace: 
public enum FeatureSet.Types.EnumType // TypeDefIndex: 6471
{
	// Fields
	public int value__; // 0x0
	[OriginalName("ENUM_TYPE_UNKNOWN")]
	public const FeatureSet.Types.EnumType Unknown = 0;
	[OriginalName("OPEN")]
	public const FeatureSet.Types.EnumType Open = 1;
	[OriginalName("CLOSED")]
	public const FeatureSet.Types.EnumType Closed = 2;
}

// Namespace: 
public enum FeatureSet.Types.RepeatedFieldEncoding // TypeDefIndex: 6472
{
	// Fields
	public int value__; // 0x0
	[OriginalName("REPEATED_FIELD_ENCODING_UNKNOWN")]
	public const FeatureSet.Types.RepeatedFieldEncoding Unknown = 0;
	[OriginalName("PACKED")]
	public const FeatureSet.Types.RepeatedFieldEncoding Packed = 1;
	[OriginalName("EXPANDED")]
	public const FeatureSet.Types.RepeatedFieldEncoding Expanded = 2;
}

// Namespace: 
public enum FeatureSet.Types.Utf8Validation // TypeDefIndex: 6473
{
	// Fields
	public int value__; // 0x0
	[OriginalName("UTF8_VALIDATION_UNKNOWN")]
	public const FeatureSet.Types.Utf8Validation Unknown = 0;
	[OriginalName("VERIFY")]
	public const FeatureSet.Types.Utf8Validation Verify = 2;
	[OriginalName("NONE")]
	public const FeatureSet.Types.Utf8Validation None = 3;
}

// Namespace: 
public enum FeatureSet.Types.MessageEncoding // TypeDefIndex: 6474
{
	// Fields
	public int value__; // 0x0
	[OriginalName("MESSAGE_ENCODING_UNKNOWN")]
	public const FeatureSet.Types.MessageEncoding Unknown = 0;
	[OriginalName("LENGTH_PREFIXED")]
	public const FeatureSet.Types.MessageEncoding LengthPrefixed = 1;
	[OriginalName("DELIMITED")]
	public const FeatureSet.Types.MessageEncoding Delimited = 2;
}

// Namespace: 
public enum FeatureSet.Types.JsonFormat // TypeDefIndex: 6475
{
	// Fields
	public int value__; // 0x0
	[OriginalName("JSON_FORMAT_UNKNOWN")]
	public const FeatureSet.Types.JsonFormat Unknown = 0;
	[OriginalName("ALLOW")]
	public const FeatureSet.Types.JsonFormat Allow = 1;
	[OriginalName("LEGACY_BEST_EFFORT")]
	public const FeatureSet.Types.JsonFormat LegacyBestEffort = 2;
}

// Namespace: 
public enum FeatureSet.Types.EnforceNamingStyle // TypeDefIndex: 6476
{
	// Fields
	public int value__; // 0x0
	[OriginalName("ENFORCE_NAMING_STYLE_UNKNOWN")]
	public const FeatureSet.Types.EnforceNamingStyle Unknown = 0;
	[OriginalName("STYLE2024")]
	public const FeatureSet.Types.EnforceNamingStyle Style2024 = 1;
	[OriginalName("STYLE_LEGACY")]
	public const FeatureSet.Types.EnforceNamingStyle StyleLegacy = 2;
}

// Namespace: 
public enum FeatureSet.Types.VisibilityFeature.Types.DefaultSymbolVisibility // TypeDefIndex: 6477
{
	// Fields
	public int value__; // 0x0
	[OriginalName("DEFAULT_SYMBOL_VISIBILITY_UNKNOWN")]
	public const FeatureSet.Types.VisibilityFeature.Types.DefaultSymbolVisibility Unknown = 0;
	[OriginalName("EXPORT_ALL")]
	public const FeatureSet.Types.VisibilityFeature.Types.DefaultSymbolVisibility ExportAll = 1;
	[OriginalName("EXPORT_TOP_LEVEL")]
	public const FeatureSet.Types.VisibilityFeature.Types.DefaultSymbolVisibility ExportTopLevel = 2;
	[OriginalName("LOCAL_ALL")]
	public const FeatureSet.Types.VisibilityFeature.Types.DefaultSymbolVisibility LocalAll = 3;
	[OriginalName("STRICT")]
	public const FeatureSet.Types.VisibilityFeature.Types.DefaultSymbolVisibility Strict = 4;
}

// Namespace: 
[DebuggerNonUserCode]
[GeneratedCode("protoc", null)]
public static class FeatureSet.Types.VisibilityFeature.Types // TypeDefIndex: 6478
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FeatureSet.Types.VisibilityFeature.<>c // TypeDefIndex: 6479
{
	// Fields
	public static readonly FeatureSet.Types.VisibilityFeature.<>c <>9; // 0x0

	// Methods

	// RVA: 0x161ECCC Offset: 0x161ACCC VA: 0x161ECCC
	private static void .cctor() { }

	// RVA: 0x161ED34 Offset: 0x161AD34 VA: 0x161ED34
	public void .ctor() { }

	// RVA: 0x161ED3C Offset: 0x161AD3C VA: 0x161ED3C
	internal FeatureSet.Types.VisibilityFeature <.cctor>b__23_0() { }
}

// Namespace: 
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FeatureSet.Types.VisibilityFeature : IMessage<FeatureSet.Types.VisibilityFeature>, IMessage, IEquatable<FeatureSet.Types.VisibilityFeature>, IDeepCloneable<FeatureSet.Types.VisibilityFeature>, IBufferMessage // TypeDefIndex: 6480
{
	// Fields
	private static readonly MessageParser<FeatureSet.Types.VisibilityFeature> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FeatureSet.Types.VisibilityFeature> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }

	// Methods

	// RVA: 0x161E734 Offset: 0x161A734 VA: 0x161E734
	public static MessageParser<FeatureSet.Types.VisibilityFeature> get_Parser() { }

	// RVA: 0x161E78C Offset: 0x161A78C VA: 0x161E78C
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x161E858 Offset: 0x161A858 VA: 0x161E858 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161E8A4 Offset: 0x161A8A4 VA: 0x161E8A4
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161E8AC Offset: 0x161A8AC VA: 0x161E8AC
	public void .ctor(FeatureSet.Types.VisibilityFeature other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161E8F0 Offset: 0x161A8F0 VA: 0x161E8F0 Slot: 10
	public FeatureSet.Types.VisibilityFeature Clone() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161E948 Offset: 0x161A948 VA: 0x161E948 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161E9CC Offset: 0x161A9CC VA: 0x161E9CC Slot: 9
	public bool Equals(FeatureSet.Types.VisibilityFeature other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161E9F8 Offset: 0x161A9F8 VA: 0x161E9F8 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161EA24 Offset: 0x161AA24 VA: 0x161EA24 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161EA7C Offset: 0x161AA7C VA: 0x161EA7C Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161EA9C Offset: 0x161AA9C VA: 0x161EA9C Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161EAB0 Offset: 0x161AAB0 VA: 0x161EAB0 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161EAC4 Offset: 0x161AAC4 VA: 0x161EAC4 Slot: 4
	public void MergeFrom(FeatureSet.Types.VisibilityFeature other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161EAF8 Offset: 0x161AAF8 VA: 0x161EAF8 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161EB18 Offset: 0x161AB18 VA: 0x161EB18 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x161EBB4 Offset: 0x161ABB4 VA: 0x161EBB4
	private static void .cctor() { }
}

// Namespace: 
[DebuggerNonUserCode]
[GeneratedCode("protoc", null)]
public static class FeatureSet.Types // TypeDefIndex: 6481
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FeatureSet.<>c // TypeDefIndex: 6482
{
	// Fields
	public static readonly FeatureSet.<>c <>9; // 0x0

	// Methods

	// RVA: 0x161ED90 Offset: 0x161AD90 VA: 0x161ED90
	private static void .cctor() { }

	// RVA: 0x161EDF8 Offset: 0x161ADF8 VA: 0x161EDF8
	public void .ctor() { }

	// RVA: 0x161EE00 Offset: 0x161AE00 VA: 0x161EE00
	internal FeatureSet <.cctor>b__106_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FeatureSet : IExtendableMessage<FeatureSet>, IMessage<FeatureSet>, IMessage, IEquatable<FeatureSet>, IDeepCloneable<FeatureSet>, IBufferMessage // TypeDefIndex: 6483
{
	// Fields
	private static readonly MessageParser<FeatureSet> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	internal ExtensionSet<FeatureSet> _extensions; // 0x18
	private int _hasBits0; // 0x20
	private static readonly FeatureSet.Types.FieldPresence FieldPresenceDefaultValue; // 0x8
	private FeatureSet.Types.FieldPresence fieldPresence_; // 0x24
	private static readonly FeatureSet.Types.EnumType EnumTypeDefaultValue; // 0xC
	private FeatureSet.Types.EnumType enumType_; // 0x28
	private static readonly FeatureSet.Types.RepeatedFieldEncoding RepeatedFieldEncodingDefaultValue; // 0x10
	private FeatureSet.Types.RepeatedFieldEncoding repeatedFieldEncoding_; // 0x2C
	private static readonly FeatureSet.Types.Utf8Validation Utf8ValidationDefaultValue; // 0x14
	private FeatureSet.Types.Utf8Validation utf8Validation_; // 0x30
	private static readonly FeatureSet.Types.MessageEncoding MessageEncodingDefaultValue; // 0x18
	private FeatureSet.Types.MessageEncoding messageEncoding_; // 0x34
	private static readonly FeatureSet.Types.JsonFormat JsonFormatDefaultValue; // 0x1C
	private FeatureSet.Types.JsonFormat jsonFormat_; // 0x38
	private static readonly FeatureSet.Types.EnforceNamingStyle EnforceNamingStyleDefaultValue; // 0x20
	private FeatureSet.Types.EnforceNamingStyle enforceNamingStyle_; // 0x3C
	private static readonly FeatureSet.Types.VisibilityFeature.Types.DefaultSymbolVisibility DefaultSymbolVisibilityDefaultValue; // 0x24
	private FeatureSet.Types.VisibilityFeature.Types.DefaultSymbolVisibility defaultSymbolVisibility_; // 0x40

	// Properties
	private ExtensionSet<FeatureSet> _Extensions { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FeatureSet> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet.Types.FieldPresence FieldPresence { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasFieldPresence { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet.Types.EnumType EnumType { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEnumType { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet.Types.RepeatedFieldEncoding RepeatedFieldEncoding { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasRepeatedFieldEncoding { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet.Types.Utf8Validation Utf8Validation { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasUtf8Validation { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet.Types.MessageEncoding MessageEncoding { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMessageEncoding { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet.Types.JsonFormat JsonFormat { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasJsonFormat { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet.Types.EnforceNamingStyle EnforceNamingStyle { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEnforceNamingStyle { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet.Types.VisibilityFeature.Types.DefaultSymbolVisibility DefaultSymbolVisibility { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDefaultSymbolVisibility { get; }

	// Methods

	// RVA: 0x161D0E0 Offset: 0x16190E0 VA: 0x161D0E0
	private ExtensionSet<FeatureSet> get__Extensions() { }

	// RVA: 0x161D0E8 Offset: 0x16190E8 VA: 0x161D0E8
	public static MessageParser<FeatureSet> get_Parser() { }

	// RVA: 0x161D140 Offset: 0x1619140 VA: 0x161D140
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x161D244 Offset: 0x1619244 VA: 0x161D244 Slot: 14
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161D290 Offset: 0x1619290 VA: 0x161D290
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161D298 Offset: 0x1619298 VA: 0x161D298
	public void .ctor(FeatureSet other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161D33C Offset: 0x161933C VA: 0x161D33C Slot: 16
	public FeatureSet Clone() { }

	// RVA: 0x161D394 Offset: 0x1619394 VA: 0x161D394
	public FeatureSet.Types.FieldPresence get_FieldPresence() { }

	// RVA: 0x161D404 Offset: 0x1619404 VA: 0x161D404
	public void set_FieldPresence(FeatureSet.Types.FieldPresence value) { }

	// RVA: 0x161D414 Offset: 0x1619414 VA: 0x161D414
	public bool get_HasFieldPresence() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161D420 Offset: 0x1619420 VA: 0x161D420
	public void ClearFieldPresence() { }

	// RVA: 0x161D430 Offset: 0x1619430 VA: 0x161D430
	public FeatureSet.Types.EnumType get_EnumType() { }

	// RVA: 0x161D4A0 Offset: 0x16194A0 VA: 0x161D4A0
	public void set_EnumType(FeatureSet.Types.EnumType value) { }

	// RVA: 0x161D4B4 Offset: 0x16194B4 VA: 0x161D4B4
	public bool get_HasEnumType() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161D4C0 Offset: 0x16194C0 VA: 0x161D4C0
	public void ClearEnumType() { }

	// RVA: 0x161D4D0 Offset: 0x16194D0 VA: 0x161D4D0
	public FeatureSet.Types.RepeatedFieldEncoding get_RepeatedFieldEncoding() { }

	// RVA: 0x161D540 Offset: 0x1619540 VA: 0x161D540
	public void set_RepeatedFieldEncoding(FeatureSet.Types.RepeatedFieldEncoding value) { }

	// RVA: 0x161D554 Offset: 0x1619554 VA: 0x161D554
	public bool get_HasRepeatedFieldEncoding() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161D560 Offset: 0x1619560 VA: 0x161D560
	public void ClearRepeatedFieldEncoding() { }

	// RVA: 0x161D570 Offset: 0x1619570 VA: 0x161D570
	public FeatureSet.Types.Utf8Validation get_Utf8Validation() { }

	// RVA: 0x161D5E0 Offset: 0x16195E0 VA: 0x161D5E0
	public void set_Utf8Validation(FeatureSet.Types.Utf8Validation value) { }

	// RVA: 0x161D5F4 Offset: 0x16195F4 VA: 0x161D5F4
	public bool get_HasUtf8Validation() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161D600 Offset: 0x1619600 VA: 0x161D600
	public void ClearUtf8Validation() { }

	// RVA: 0x161D610 Offset: 0x1619610 VA: 0x161D610
	public FeatureSet.Types.MessageEncoding get_MessageEncoding() { }

	// RVA: 0x161D680 Offset: 0x1619680 VA: 0x161D680
	public void set_MessageEncoding(FeatureSet.Types.MessageEncoding value) { }

	// RVA: 0x161D694 Offset: 0x1619694 VA: 0x161D694
	public bool get_HasMessageEncoding() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161D6A0 Offset: 0x16196A0 VA: 0x161D6A0
	public void ClearMessageEncoding() { }

	// RVA: 0x161D6B0 Offset: 0x16196B0 VA: 0x161D6B0
	public FeatureSet.Types.JsonFormat get_JsonFormat() { }

	// RVA: 0x161D720 Offset: 0x1619720 VA: 0x161D720
	public void set_JsonFormat(FeatureSet.Types.JsonFormat value) { }

	// RVA: 0x161D734 Offset: 0x1619734 VA: 0x161D734
	public bool get_HasJsonFormat() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161D740 Offset: 0x1619740 VA: 0x161D740
	public void ClearJsonFormat() { }

	// RVA: 0x161D750 Offset: 0x1619750 VA: 0x161D750
	public FeatureSet.Types.EnforceNamingStyle get_EnforceNamingStyle() { }

	// RVA: 0x161D7C0 Offset: 0x16197C0 VA: 0x161D7C0
	public void set_EnforceNamingStyle(FeatureSet.Types.EnforceNamingStyle value) { }

	// RVA: 0x161D7D4 Offset: 0x16197D4 VA: 0x161D7D4
	public bool get_HasEnforceNamingStyle() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161D7E0 Offset: 0x16197E0 VA: 0x161D7E0
	public void ClearEnforceNamingStyle() { }

	// RVA: 0x161D7F0 Offset: 0x16197F0 VA: 0x161D7F0
	public FeatureSet.Types.VisibilityFeature.Types.DefaultSymbolVisibility get_DefaultSymbolVisibility() { }

	// RVA: 0x161D860 Offset: 0x1619860 VA: 0x161D860
	public void set_DefaultSymbolVisibility(FeatureSet.Types.VisibilityFeature.Types.DefaultSymbolVisibility value) { }

	// RVA: 0x161D874 Offset: 0x1619874 VA: 0x161D874
	public bool get_HasDefaultSymbolVisibility() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161D880 Offset: 0x1619880 VA: 0x161D880
	public void ClearDefaultSymbolVisibility() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161D890 Offset: 0x1619890 VA: 0x161D890 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161D8F4 Offset: 0x16198F4 VA: 0x161D8F4 Slot: 15
	public bool Equals(FeatureSet other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161DA34 Offset: 0x1619A34 VA: 0x161DA34 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161DBD4 Offset: 0x1619BD4 VA: 0x161DBD4 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161DC2C Offset: 0x1619C2C VA: 0x161DC2C Slot: 12
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161DC4C Offset: 0x1619C4C VA: 0x161DC4C Slot: 18
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161DE60 Offset: 0x1619E60 VA: 0x161DE60 Slot: 13
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161E0E8 Offset: 0x161A0E8 VA: 0x161E0E8 Slot: 10
	public void MergeFrom(FeatureSet other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161E284 Offset: 0x161A284 VA: 0x161E284 Slot: 11
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161E2A4 Offset: 0x161A2A4 VA: 0x161E2A4 Slot: 17
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: -1 Offset: -1 Slot: 4
	public TValue GetExtension<TValue>(Extension<FeatureSet, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11129B0 Offset: 0x110E9B0 VA: 0x11129B0
	|-FeatureSet.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<FeatureSet, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1112A74 Offset: 0x110EA74 VA: 0x1112A74
	|-FeatureSet.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<FeatureSet, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1112AB8 Offset: 0x110EAB8 VA: 0x1112AB8
	|-FeatureSet.GetOrInitializeExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SetExtension<TValue>(Extension<FeatureSet, TValue> extension, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1112B40 Offset: 0x110EB40 VA: 0x1112B40
	|-FeatureSet.SetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasExtension<TValue>(Extension<FeatureSet, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1112AFC Offset: 0x110EAFC VA: 0x1112AFC
	|-FeatureSet.HasExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void ClearExtension<TValue>(Extension<FeatureSet, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1112928 Offset: 0x110E928 VA: 0x1112928
	|-FeatureSet.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void ClearExtension<TValue>(RepeatedExtension<FeatureSet, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111296C Offset: 0x110E96C VA: 0x111296C
	|-FeatureSet.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x161E604 Offset: 0x161A604 VA: 0x161E604
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FeatureSetDefaults.Types.FeatureSetEditionDefault.<>c // TypeDefIndex: 6484
{
	// Fields
	public static readonly FeatureSetDefaults.Types.FeatureSetEditionDefault.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16206F4 Offset: 0x161C6F4 VA: 0x16206F4
	private static void .cctor() { }

	// RVA: 0x162075C Offset: 0x161C75C VA: 0x162075C
	public void .ctor() { }

	// RVA: 0x1620764 Offset: 0x161C764 VA: 0x1620764
	internal FeatureSetDefaults.Types.FeatureSetEditionDefault <.cctor>b__42_0() { }
}

// Namespace: 
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FeatureSetDefaults.Types.FeatureSetEditionDefault : IMessage<FeatureSetDefaults.Types.FeatureSetEditionDefault>, IMessage, IEquatable<FeatureSetDefaults.Types.FeatureSetEditionDefault>, IDeepCloneable<FeatureSetDefaults.Types.FeatureSetEditionDefault>, IBufferMessage // TypeDefIndex: 6485
{
	// Fields
	private static readonly MessageParser<FeatureSetDefaults.Types.FeatureSetEditionDefault> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly Edition EditionDefaultValue; // 0x8
	private Edition edition_; // 0x1C
	private FeatureSet overridableFeatures_; // 0x20
	private FeatureSet fixedFeatures_; // 0x28

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FeatureSetDefaults.Types.FeatureSetEditionDefault> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Edition Edition { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEdition { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet OverridableFeatures { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FeatureSet FixedFeatures { get; set; }

	// Methods

	// RVA: 0x161FBC4 Offset: 0x161BBC4 VA: 0x161FBC4
	public static MessageParser<FeatureSetDefaults.Types.FeatureSetEditionDefault> get_Parser() { }

	// RVA: 0x161FC1C Offset: 0x161BC1C VA: 0x161FC1C
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x161FCE8 Offset: 0x161BCE8 VA: 0x161FCE8 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161FD34 Offset: 0x161BD34 VA: 0x161FD34
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161FD3C Offset: 0x161BD3C VA: 0x161FD3C
	public void .ctor(FeatureSetDefaults.Types.FeatureSetEditionDefault other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161FDD0 Offset: 0x161BDD0 VA: 0x161FDD0 Slot: 10
	public FeatureSetDefaults.Types.FeatureSetEditionDefault Clone() { }

	// RVA: 0x161FE28 Offset: 0x161BE28 VA: 0x161FE28
	public Edition get_Edition() { }

	// RVA: 0x161FE98 Offset: 0x161BE98 VA: 0x161FE98
	public void set_Edition(Edition value) { }

	// RVA: 0x161FEA8 Offset: 0x161BEA8 VA: 0x161FEA8
	public bool get_HasEdition() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161FEB4 Offset: 0x161BEB4 VA: 0x161FEB4
	public void ClearEdition() { }

	// RVA: 0x161FEC4 Offset: 0x161BEC4 VA: 0x161FEC4
	public FeatureSet get_OverridableFeatures() { }

	// RVA: 0x161FECC Offset: 0x161BECC VA: 0x161FECC
	public void set_OverridableFeatures(FeatureSet value) { }

	// RVA: 0x161FED4 Offset: 0x161BED4 VA: 0x161FED4
	public FeatureSet get_FixedFeatures() { }

	// RVA: 0x161FEDC Offset: 0x161BEDC VA: 0x161FEDC
	public void set_FixedFeatures(FeatureSet value) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161FEE4 Offset: 0x161BEE4 VA: 0x161FEE4 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161FF48 Offset: 0x161BF48 VA: 0x161FF48 Slot: 9
	public bool Equals(FeatureSetDefaults.Types.FeatureSetEditionDefault other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161FFD8 Offset: 0x161BFD8 VA: 0x161FFD8 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x162006C Offset: 0x161C06C VA: 0x162006C Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16200C4 Offset: 0x161C0C4 VA: 0x16200C4 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16200E4 Offset: 0x161C0E4 VA: 0x16200E4 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x162019C Offset: 0x161C19C VA: 0x162019C Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1620294 Offset: 0x161C294 VA: 0x1620294 Slot: 4
	public void MergeFrom(FeatureSetDefaults.Types.FeatureSetEditionDefault other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16203C8 Offset: 0x161C3C8 VA: 0x16203C8 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16203E8 Offset: 0x161C3E8 VA: 0x16203E8 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x16205CC Offset: 0x161C5CC VA: 0x16205CC
	private static void .cctor() { }
}

// Namespace: 
[DebuggerNonUserCode]
[GeneratedCode("protoc", null)]
public static class FeatureSetDefaults.Types // TypeDefIndex: 6486
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FeatureSetDefaults.<>c // TypeDefIndex: 6487
{
	// Fields
	public static readonly FeatureSetDefaults.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16207B8 Offset: 0x161C7B8 VA: 0x16207B8
	private static void .cctor() { }

	// RVA: 0x1620820 Offset: 0x161C820 VA: 0x1620820
	public void .ctor() { }

	// RVA: 0x1620828 Offset: 0x161C828 VA: 0x1620828
	internal FeatureSetDefaults <.cctor>b__47_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FeatureSetDefaults : IMessage<FeatureSetDefaults>, IMessage, IEquatable<FeatureSetDefaults>, IDeepCloneable<FeatureSetDefaults>, IBufferMessage // TypeDefIndex: 6488
{
	// Fields
	private static readonly MessageParser<FeatureSetDefaults> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly FieldCodec<FeatureSetDefaults.Types.FeatureSetEditionDefault> _repeated_defaults_codec; // 0x8
	private readonly RepeatedField<FeatureSetDefaults.Types.FeatureSetEditionDefault> defaults_; // 0x20
	private static readonly Edition MinimumEditionDefaultValue; // 0x10
	private Edition minimumEdition_; // 0x28
	private static readonly Edition MaximumEditionDefaultValue; // 0x14
	private Edition maximumEdition_; // 0x2C

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FeatureSetDefaults> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FeatureSetDefaults.Types.FeatureSetEditionDefault> Defaults { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Edition MinimumEdition { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMinimumEdition { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Edition MaximumEdition { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasMaximumEdition { get; }

	// Methods

	// RVA: 0x161EE54 Offset: 0x161AE54 VA: 0x161EE54
	public static MessageParser<FeatureSetDefaults> get_Parser() { }

	// RVA: 0x161EEAC Offset: 0x161AEAC VA: 0x161EEAC
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x161EFB0 Offset: 0x161AFB0 VA: 0x161EFB0 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161EFFC Offset: 0x161AFFC VA: 0x161EFFC
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161F084 Offset: 0x161B084 VA: 0x161F084
	public void .ctor(FeatureSetDefaults other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161F120 Offset: 0x161B120 VA: 0x161F120 Slot: 10
	public FeatureSetDefaults Clone() { }

	// RVA: 0x161F178 Offset: 0x161B178 VA: 0x161F178
	public RepeatedField<FeatureSetDefaults.Types.FeatureSetEditionDefault> get_Defaults() { }

	// RVA: 0x161F180 Offset: 0x161B180 VA: 0x161F180
	public Edition get_MinimumEdition() { }

	// RVA: 0x161F1F0 Offset: 0x161B1F0 VA: 0x161F1F0
	public void set_MinimumEdition(Edition value) { }

	// RVA: 0x161F204 Offset: 0x161B204 VA: 0x161F204
	public bool get_HasMinimumEdition() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161F210 Offset: 0x161B210 VA: 0x161F210
	public void ClearMinimumEdition() { }

	// RVA: 0x161F220 Offset: 0x161B220 VA: 0x161F220
	public Edition get_MaximumEdition() { }

	// RVA: 0x161F290 Offset: 0x161B290 VA: 0x161F290
	public void set_MaximumEdition(Edition value) { }

	// RVA: 0x161F2A4 Offset: 0x161B2A4 VA: 0x161F2A4
	public bool get_HasMaximumEdition() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161F2B0 Offset: 0x161B2B0 VA: 0x161F2B0
	public void ClearMaximumEdition() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161F2C0 Offset: 0x161B2C0 VA: 0x161F2C0 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161F324 Offset: 0x161B324 VA: 0x161F324 Slot: 9
	public bool Equals(FeatureSetDefaults other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161F3EC Offset: 0x161B3EC VA: 0x161F3EC Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161F488 Offset: 0x161B488 VA: 0x161F488 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161F4E0 Offset: 0x161B4E0 VA: 0x161F4E0 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161F500 Offset: 0x161B500 VA: 0x161F500 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161F618 Offset: 0x161B618 VA: 0x161F618 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161F750 Offset: 0x161B750 VA: 0x161F750 Slot: 4
	public void MergeFrom(FeatureSetDefaults other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161F818 Offset: 0x161B818 VA: 0x161F818 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x161F838 Offset: 0x161B838 VA: 0x161F838 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x161FA04 Offset: 0x161BA04 VA: 0x161FA04
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SourceCodeInfo.Types.Location.<>c // TypeDefIndex: 6489
{
	// Fields
	public static readonly SourceCodeInfo.Types.Location.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1622404 Offset: 0x161E404 VA: 0x1622404
	private static void .cctor() { }

	// RVA: 0x162246C Offset: 0x161E46C VA: 0x162246C
	public void .ctor() { }

	// RVA: 0x1622474 Offset: 0x161E474 VA: 0x1622474
	internal SourceCodeInfo.Types.Location <.cctor>b__55_0() { }
}

// Namespace: 
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SourceCodeInfo.Types.Location : IMessage<SourceCodeInfo.Types.Location>, IMessage, IEquatable<SourceCodeInfo.Types.Location>, IDeepCloneable<SourceCodeInfo.Types.Location>, IBufferMessage // TypeDefIndex: 6490
{
	// Fields
	private static readonly MessageParser<SourceCodeInfo.Types.Location> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private static readonly FieldCodec<int> _repeated_path_codec; // 0x8
	private readonly RepeatedField<int> path_; // 0x18
	private static readonly FieldCodec<int> _repeated_span_codec; // 0x10
	private readonly RepeatedField<int> span_; // 0x20
	private static readonly string LeadingCommentsDefaultValue; // 0x18
	private string leadingComments_; // 0x28
	private static readonly string TrailingCommentsDefaultValue; // 0x20
	private string trailingComments_; // 0x30
	private static readonly FieldCodec<string> _repeated_leadingDetachedComments_codec; // 0x28
	private readonly RepeatedField<string> leadingDetachedComments_; // 0x38

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SourceCodeInfo.Types.Location> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Path { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Span { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string LeadingComments { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasLeadingComments { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string TrailingComments { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasTrailingComments { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<string> LeadingDetachedComments { get; }

	// Methods

	// RVA: 0x1621338 Offset: 0x161D338 VA: 0x1621338
	public static MessageParser<SourceCodeInfo.Types.Location> get_Parser() { }

	// RVA: 0x1621390 Offset: 0x161D390 VA: 0x1621390
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x162145C Offset: 0x161D45C VA: 0x162145C Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16214A8 Offset: 0x161D4A8 VA: 0x16214A8
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16215A8 Offset: 0x161D5A8 VA: 0x16215A8
	public void .ctor(SourceCodeInfo.Types.Location other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16216A8 Offset: 0x161D6A8 VA: 0x16216A8 Slot: 10
	public SourceCodeInfo.Types.Location Clone() { }

	// RVA: 0x1621700 Offset: 0x161D700 VA: 0x1621700
	public RepeatedField<int> get_Path() { }

	// RVA: 0x1621708 Offset: 0x161D708 VA: 0x1621708
	public RepeatedField<int> get_Span() { }

	// RVA: 0x1621710 Offset: 0x161D710 VA: 0x1621710
	public string get_LeadingComments() { }

	// RVA: 0x1621774 Offset: 0x161D774 VA: 0x1621774
	public void set_LeadingComments(string value) { }

	// RVA: 0x16217F0 Offset: 0x161D7F0 VA: 0x16217F0
	public bool get_HasLeadingComments() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1621800 Offset: 0x161D800 VA: 0x1621800
	public void ClearLeadingComments() { }

	// RVA: 0x162180C Offset: 0x161D80C VA: 0x162180C
	public string get_TrailingComments() { }

	// RVA: 0x1621870 Offset: 0x161D870 VA: 0x1621870
	public void set_TrailingComments(string value) { }

	// RVA: 0x16218EC Offset: 0x161D8EC VA: 0x16218EC
	public bool get_HasTrailingComments() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16218FC Offset: 0x161D8FC VA: 0x16218FC
	public void ClearTrailingComments() { }

	// RVA: 0x1621908 Offset: 0x161D908 VA: 0x1621908
	public RepeatedField<string> get_LeadingDetachedComments() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1621910 Offset: 0x161D910 VA: 0x1621910 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1621974 Offset: 0x161D974 VA: 0x1621974 Slot: 9
	public bool Equals(SourceCodeInfo.Types.Location other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1621A98 Offset: 0x161DA98 VA: 0x1621A98 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1621B6C Offset: 0x161DB6C VA: 0x1621B6C Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1621BC4 Offset: 0x161DBC4 VA: 0x1621BC4 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1621BE4 Offset: 0x161DBE4 VA: 0x1621BE4 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1621D64 Offset: 0x161DD64 VA: 0x1621D64 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1621F0C Offset: 0x161DF0C VA: 0x1621F0C Slot: 4
	public void MergeFrom(SourceCodeInfo.Types.Location other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1622008 Offset: 0x161E008 VA: 0x1622008 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1622028 Offset: 0x161E028 VA: 0x1622028 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x1622244 Offset: 0x161E244 VA: 0x1622244
	private static void .cctor() { }
}

// Namespace: 
[DebuggerNonUserCode]
[GeneratedCode("protoc", null)]
public static class SourceCodeInfo.Types // TypeDefIndex: 6491
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SourceCodeInfo.<>c // TypeDefIndex: 6492
{
	// Fields
	public static readonly SourceCodeInfo.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16224C4 Offset: 0x161E4C4 VA: 0x16224C4
	private static void .cctor() { }

	// RVA: 0x162252C Offset: 0x161E52C VA: 0x162252C
	public void .ctor() { }

	// RVA: 0x1622534 Offset: 0x161E534 VA: 0x1622534
	internal SourceCodeInfo <.cctor>b__38_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class SourceCodeInfo : IExtendableMessage<SourceCodeInfo>, IMessage<SourceCodeInfo>, IMessage, IEquatable<SourceCodeInfo>, IDeepCloneable<SourceCodeInfo>, IBufferMessage // TypeDefIndex: 6493
{
	// Fields
	private static readonly MessageParser<SourceCodeInfo> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	internal ExtensionSet<SourceCodeInfo> _extensions; // 0x18
	private static readonly FieldCodec<SourceCodeInfo.Types.Location> _repeated_location_codec; // 0x8
	private readonly RepeatedField<SourceCodeInfo.Types.Location> location_; // 0x20

	// Properties
	private ExtensionSet<SourceCodeInfo> _Extensions { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SourceCodeInfo> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<SourceCodeInfo.Types.Location> Location { get; }

	// Methods

	// RVA: 0x1620878 Offset: 0x161C878 VA: 0x1620878
	private ExtensionSet<SourceCodeInfo> get__Extensions() { }

	// RVA: 0x1620880 Offset: 0x161C880 VA: 0x1620880
	public static MessageParser<SourceCodeInfo> get_Parser() { }

	// RVA: 0x16208D8 Offset: 0x161C8D8 VA: 0x16208D8
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16209DC Offset: 0x161C9DC VA: 0x16209DC Slot: 14
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1620A28 Offset: 0x161CA28 VA: 0x1620A28
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1620AB0 Offset: 0x161CAB0 VA: 0x1620AB0
	public void .ctor(SourceCodeInfo other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1620B6C Offset: 0x161CB6C VA: 0x1620B6C Slot: 16
	public SourceCodeInfo Clone() { }

	// RVA: 0x1620BC4 Offset: 0x161CBC4 VA: 0x1620BC4
	public RepeatedField<SourceCodeInfo.Types.Location> get_Location() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1620BCC Offset: 0x161CBCC VA: 0x1620BCC Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1620C30 Offset: 0x161CC30 VA: 0x1620C30 Slot: 15
	public bool Equals(SourceCodeInfo other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1620CD4 Offset: 0x161CCD4 VA: 0x1620CD4 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1620D40 Offset: 0x161CD40 VA: 0x1620D40 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1620D98 Offset: 0x161CD98 VA: 0x1620D98 Slot: 12
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1620DB8 Offset: 0x161CDB8 VA: 0x1620DB8 Slot: 18
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1620E98 Offset: 0x161CE98 VA: 0x1620E98 Slot: 13
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1620F68 Offset: 0x161CF68 VA: 0x1620F68 Slot: 10
	public void MergeFrom(SourceCodeInfo other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1621014 Offset: 0x161D014 VA: 0x1621014 Slot: 11
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1621034 Offset: 0x161D034 VA: 0x1621034 Slot: 17
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: -1 Offset: -1 Slot: 4
	public TValue GetExtension<TValue>(Extension<SourceCodeInfo, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1149490 Offset: 0x1145490 VA: 0x1149490
	|-SourceCodeInfo.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<SourceCodeInfo, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1149554 Offset: 0x1145554 VA: 0x1149554
	|-SourceCodeInfo.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<SourceCodeInfo, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1149598 Offset: 0x1145598 VA: 0x1149598
	|-SourceCodeInfo.GetOrInitializeExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void SetExtension<TValue>(Extension<SourceCodeInfo, TValue> extension, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1149620 Offset: 0x1145620 VA: 0x1149620
	|-SourceCodeInfo.SetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public bool HasExtension<TValue>(Extension<SourceCodeInfo, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11495DC Offset: 0x11455DC VA: 0x11495DC
	|-SourceCodeInfo.HasExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void ClearExtension<TValue>(Extension<SourceCodeInfo, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1149408 Offset: 0x1145408 VA: 0x1149408
	|-SourceCodeInfo.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 19
	public void ClearExtension<TValue>(RepeatedExtension<SourceCodeInfo, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114944C Offset: 0x114544C VA: 0x114944C
	|-SourceCodeInfo.ClearExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1621188 Offset: 0x161D188 VA: 0x1621188
	private static void .cctor() { }
}

// Namespace: 
public enum GeneratedCodeInfo.Types.Annotation.Types.Semantic // TypeDefIndex: 6494
{
	// Fields
	public int value__; // 0x0
	[OriginalName("NONE")]
	public const GeneratedCodeInfo.Types.Annotation.Types.Semantic None = 0;
	[OriginalName("SET")]
	public const GeneratedCodeInfo.Types.Annotation.Types.Semantic Set = 1;
	[OriginalName("ALIAS")]
	public const GeneratedCodeInfo.Types.Annotation.Types.Semantic Alias = 2;
}

// Namespace: 
[DebuggerNonUserCode]
[GeneratedCode("protoc", null)]
public static class GeneratedCodeInfo.Types.Annotation.Types // TypeDefIndex: 6495
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GeneratedCodeInfo.Types.Annotation.<>c // TypeDefIndex: 6496
{
	// Fields
	public static readonly GeneratedCodeInfo.Types.Annotation.<>c <>9; // 0x0

	// Methods

	// RVA: 0x162403C Offset: 0x162003C VA: 0x162403C
	private static void .cctor() { }

	// RVA: 0x16240A4 Offset: 0x16200A4 VA: 0x16240A4
	public void .ctor() { }

	// RVA: 0x16240AC Offset: 0x16200AC VA: 0x16240AC
	internal GeneratedCodeInfo.Types.Annotation <.cctor>b__65_0() { }
}

// Namespace: 
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GeneratedCodeInfo.Types.Annotation : IMessage<GeneratedCodeInfo.Types.Annotation>, IMessage, IEquatable<GeneratedCodeInfo.Types.Annotation>, IDeepCloneable<GeneratedCodeInfo.Types.Annotation>, IBufferMessage // TypeDefIndex: 6497
{
	// Fields
	private static readonly MessageParser<GeneratedCodeInfo.Types.Annotation> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private int _hasBits0; // 0x18
	private static readonly FieldCodec<int> _repeated_path_codec; // 0x8
	private readonly RepeatedField<int> path_; // 0x20
	private static readonly string SourceFileDefaultValue; // 0x10
	private string sourceFile_; // 0x28
	private static readonly int BeginDefaultValue; // 0x18
	private int begin_; // 0x30
	private static readonly int EndDefaultValue; // 0x1C
	private int end_; // 0x34
	private static readonly GeneratedCodeInfo.Types.Annotation.Types.Semantic SemanticDefaultValue; // 0x20
	private GeneratedCodeInfo.Types.Annotation.Types.Semantic semantic_; // 0x38

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GeneratedCodeInfo.Types.Annotation> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Path { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string SourceFile { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasSourceFile { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Begin { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasBegin { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int End { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasEnd { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GeneratedCodeInfo.Types.Annotation.Types.Semantic Semantic { get; set; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasSemantic { get; }

	// Methods

	// RVA: 0x1622F3C Offset: 0x161EF3C VA: 0x1622F3C
	public static MessageParser<GeneratedCodeInfo.Types.Annotation> get_Parser() { }

	// RVA: 0x1622F94 Offset: 0x161EF94 VA: 0x1622F94
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x1623060 Offset: 0x161F060 VA: 0x1623060 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16230AC Offset: 0x161F0AC VA: 0x16230AC
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1623134 Offset: 0x161F134 VA: 0x1623134
	public void .ctor(GeneratedCodeInfo.Types.Annotation other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16231E8 Offset: 0x161F1E8 VA: 0x16231E8 Slot: 10
	public GeneratedCodeInfo.Types.Annotation Clone() { }

	// RVA: 0x1623240 Offset: 0x161F240 VA: 0x1623240
	public RepeatedField<int> get_Path() { }

	// RVA: 0x1623248 Offset: 0x161F248 VA: 0x1623248
	public string get_SourceFile() { }

	// RVA: 0x16232AC Offset: 0x161F2AC VA: 0x16232AC
	public void set_SourceFile(string value) { }

	// RVA: 0x1623328 Offset: 0x161F328 VA: 0x1623328
	public bool get_HasSourceFile() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1623338 Offset: 0x161F338 VA: 0x1623338
	public void ClearSourceFile() { }

	// RVA: 0x1623344 Offset: 0x161F344 VA: 0x1623344
	public int get_Begin() { }

	// RVA: 0x16233B4 Offset: 0x161F3B4 VA: 0x16233B4
	public void set_Begin(int value) { }

	// RVA: 0x16233C8 Offset: 0x161F3C8 VA: 0x16233C8
	public bool get_HasBegin() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16233D4 Offset: 0x161F3D4 VA: 0x16233D4
	public void ClearBegin() { }

	// RVA: 0x16233E4 Offset: 0x161F3E4 VA: 0x16233E4
	public int get_End() { }

	// RVA: 0x1623454 Offset: 0x161F454 VA: 0x1623454
	public void set_End(int value) { }

	// RVA: 0x1623468 Offset: 0x161F468 VA: 0x1623468
	public bool get_HasEnd() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1623474 Offset: 0x161F474 VA: 0x1623474
	public void ClearEnd() { }

	// RVA: 0x1623484 Offset: 0x161F484 VA: 0x1623484
	public GeneratedCodeInfo.Types.Annotation.Types.Semantic get_Semantic() { }

	// RVA: 0x16234F4 Offset: 0x161F4F4 VA: 0x16234F4
	public void set_Semantic(GeneratedCodeInfo.Types.Annotation.Types.Semantic value) { }

	// RVA: 0x1623508 Offset: 0x161F508 VA: 0x1623508
	public bool get_HasSemantic() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1623514 Offset: 0x161F514 VA: 0x1623514
	public void ClearSemantic() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1623524 Offset: 0x161F524 VA: 0x1623524 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1623588 Offset: 0x161F588 VA: 0x1623588 Slot: 9
	public bool Equals(GeneratedCodeInfo.Types.Annotation other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1623694 Offset: 0x161F694 VA: 0x1623694 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1623784 Offset: 0x161F784 VA: 0x1623784 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16237DC Offset: 0x161F7DC VA: 0x16237DC Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16237FC Offset: 0x161F7FC VA: 0x16237FC Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1623980 Offset: 0x161F980 VA: 0x1623980 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1623B3C Offset: 0x161FB3C VA: 0x1623B3C Slot: 4
	public void MergeFrom(GeneratedCodeInfo.Types.Annotation other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1623C4C Offset: 0x161FC4C VA: 0x1623C4C Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1623C6C Offset: 0x161FC6C VA: 0x1623C6C Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x1623EC4 Offset: 0x161FEC4 VA: 0x1623EC4
	private static void .cctor() { }
}

// Namespace: 
[DebuggerNonUserCode]
[GeneratedCode("protoc", null)]
public static class GeneratedCodeInfo.Types // TypeDefIndex: 6498
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GeneratedCodeInfo.<>c // TypeDefIndex: 6499
{
	// Fields
	public static readonly GeneratedCodeInfo.<>c <>9; // 0x0

	// Methods

	// RVA: 0x16240FC Offset: 0x16200FC VA: 0x16240FC
	private static void .cctor() { }

	// RVA: 0x1624164 Offset: 0x1620164 VA: 0x1624164
	public void .ctor() { }

	// RVA: 0x162416C Offset: 0x162016C VA: 0x162416C
	internal GeneratedCodeInfo <.cctor>b__28_0() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GeneratedCodeInfo : IMessage<GeneratedCodeInfo>, IMessage, IEquatable<GeneratedCodeInfo>, IDeepCloneable<GeneratedCodeInfo>, IBufferMessage // TypeDefIndex: 6500
{
	// Fields
	private static readonly MessageParser<GeneratedCodeInfo> _parser; // 0x0
	private UnknownFieldSet _unknownFields; // 0x10
	private static readonly FieldCodec<GeneratedCodeInfo.Types.Annotation> _repeated_annotation_codec; // 0x8
	private readonly RepeatedField<GeneratedCodeInfo.Types.Annotation> annotation_; // 0x18

	// Properties
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GeneratedCodeInfo> Parser { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GeneratedCodeInfo.Types.Annotation> Annotation { get; }

	// Methods

	// RVA: 0x1622584 Offset: 0x161E584 VA: 0x1622584
	public static MessageParser<GeneratedCodeInfo> get_Parser() { }

	// RVA: 0x16225DC Offset: 0x161E5DC VA: 0x16225DC
	public static MessageDescriptor get_Descriptor() { }

	// RVA: 0x16226E0 Offset: 0x161E6E0 VA: 0x16226E0 Slot: 8
	private MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x162272C Offset: 0x161E72C VA: 0x162272C
	public void .ctor() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16227B4 Offset: 0x161E7B4 VA: 0x16227B4
	public void .ctor(GeneratedCodeInfo other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1622840 Offset: 0x161E840 VA: 0x1622840 Slot: 10
	public GeneratedCodeInfo Clone() { }

	// RVA: 0x1622898 Offset: 0x161E898 VA: 0x1622898
	public RepeatedField<GeneratedCodeInfo.Types.Annotation> get_Annotation() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16228A0 Offset: 0x161E8A0 VA: 0x16228A0 Slot: 0
	public override bool Equals(object other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1622904 Offset: 0x161E904 VA: 0x1622904 Slot: 9
	public bool Equals(GeneratedCodeInfo other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1622994 Offset: 0x161E994 VA: 0x1622994 Slot: 2
	public override int GetHashCode() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x16229E0 Offset: 0x161E9E0 VA: 0x16229E0 Slot: 3
	public override string ToString() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1622A38 Offset: 0x161EA38 VA: 0x1622A38 Slot: 6
	public void WriteTo(CodedOutputStream output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1622A58 Offset: 0x161EA58 VA: 0x1622A58 Slot: 12
	private void pb::Google.Protobuf.IBufferMessage.InternalWriteTo(ref WriteContext output) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1622B10 Offset: 0x161EB10 VA: 0x1622B10 Slot: 7
	public int CalculateSize() { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1622BB8 Offset: 0x161EBB8 VA: 0x1622BB8 Slot: 4
	public void MergeFrom(GeneratedCodeInfo other) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1622C40 Offset: 0x161EC40 VA: 0x1622C40 Slot: 5
	public void MergeFrom(CodedInputStream input) { }

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	// RVA: 0x1622C60 Offset: 0x161EC60 VA: 0x1622C60 Slot: 11
	private void pb::Google.Protobuf.IBufferMessage.InternalMergeFrom(ref ParseContext input) { }

	// RVA: 0x1622D8C Offset: 0x161ED8C VA: 0x1622D8C
	private static void .cctor() { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("Type = {GetType().Name,nq}, FullName = {FullName}")]
public abstract class DescriptorBase : IDescriptor // TypeDefIndex: 6501
{
	// Fields
	[CompilerGenerated]
	private readonly FeatureSetDescriptor <Features>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <FullName>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly FileDescriptor <File>k__BackingField; // 0x28

	// Properties
	internal FeatureSetDescriptor Features { get; }
	public abstract string Name { get; }
	public string FullName { get; }
	public FileDescriptor File { get; }

	// Methods

	// RVA: 0x16241BC Offset: 0x16201BC VA: 0x16241BC
	internal void .ctor(FileDescriptor file, string fullName, int index, FeatureSetDescriptor features) { }

	[CompilerGenerated]
	// RVA: 0x1624224 Offset: 0x1620224 VA: 0x1624224
	internal FeatureSetDescriptor get_Features() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Name();

	[CompilerGenerated]
	// RVA: 0x162422C Offset: 0x162022C VA: 0x162422C Slot: 5
	public string get_FullName() { }

	[CompilerGenerated]
	// RVA: 0x1624234 Offset: 0x1620234 VA: 0x1624234 Slot: 6
	public FileDescriptor get_File() { }

	// RVA: 0x162423C Offset: 0x162023C VA: 0x162423C Slot: 8
	internal virtual IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) { }
}

// Namespace: Google.Protobuf.Reflection
public sealed class DescriptorDeclaration // TypeDefIndex: 6502
{
	// Fields
	[CompilerGenerated]
	private readonly IDescriptor <Descriptor>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly int <StartLine>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly int <StartColumn>k__BackingField; // 0x1C
	[CompilerGenerated]
	private readonly int <EndLine>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly int <EndColumn>k__BackingField; // 0x24
	[CompilerGenerated]
	private readonly string <LeadingComments>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <TrailingComments>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly IReadOnlyList<string> <LeadingDetachedComments>k__BackingField; // 0x38

	// Properties
	public int StartLine { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1624244 Offset: 0x1620244 VA: 0x1624244
	public int get_StartLine() { }

	// RVA: 0x162424C Offset: 0x162024C VA: 0x162424C
	private void .ctor(IDescriptor descriptor, SourceCodeInfo.Types.Location location) { }

	// RVA: 0x1624408 Offset: 0x1620408 VA: 0x1624408
	internal static DescriptorDeclaration FromProto(IDescriptor descriptor, SourceCodeInfo.Types.Location location) { }
}

// Namespace: 
private struct DescriptorPool.EnumValueByNameDescriptorKey : IEquatable<DescriptorPool.EnumValueByNameDescriptorKey> // TypeDefIndex: 6503
{
	// Fields
	private readonly string name; // 0x0
	private readonly IDescriptor descriptor; // 0x8

	// Methods

	// RVA: 0x16263C8 Offset: 0x16223C8 VA: 0x16263C8
	internal void .ctor(EnumDescriptor descriptor, string valueName) { }

	// RVA: 0x16266E8 Offset: 0x16226E8 VA: 0x16266E8 Slot: 4
	public bool Equals(DescriptorPool.EnumValueByNameDescriptorKey other) { }

	// RVA: 0x1626708 Offset: 0x1622708 VA: 0x1626708 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1626794 Offset: 0x1622794 VA: 0x1626794 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Google.Protobuf.Reflection
internal sealed class DescriptorPool // TypeDefIndex: 6504
{
	// Fields
	private readonly IDictionary<string, IDescriptor> descriptorsByName; // 0x10
	private readonly IDictionary<ObjectIntPair<IDescriptor>, FieldDescriptor> fieldsByNumber; // 0x18
	private readonly IDictionary<ObjectIntPair<IDescriptor>, EnumValueDescriptor> enumValuesByNumber; // 0x20
	private readonly IDictionary<DescriptorPool.EnumValueByNameDescriptorKey, EnumValueDescriptor> enumValuesByName; // 0x28
	private readonly HashSet<FileDescriptor> dependencies; // 0x30

	// Methods

	// RVA: 0x1624470 Offset: 0x1620470 VA: 0x1624470
	internal void .ctor(IEnumerable<FileDescriptor> dependencyFiles) { }

	// RVA: 0x1624B1C Offset: 0x1620B1C VA: 0x1624B1C
	private void ImportPublicDependencies(FileDescriptor file) { }

	// RVA: -1 Offset: -1
	internal T FindSymbol<T>(string fullName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FA040 Offset: 0x10F6040 VA: 0x10FA040
	|-DescriptorPool.FindSymbol<object>
	*/

	// RVA: 0x1624E1C Offset: 0x1620E1C VA: 0x1624E1C
	internal void AddPackage(string fullName, FileDescriptor file) { }

	// RVA: 0x1625320 Offset: 0x1621320 VA: 0x1625320
	internal void AddSymbol(IDescriptor descriptor) { }

	// RVA: 0x162573C Offset: 0x162173C VA: 0x162573C
	private static string GetDescriptorAlreadyAddedExceptionMessage(IDescriptor descriptor, string fullName, IDescriptor old) { }

	// RVA: 0x1625524 Offset: 0x1621524 VA: 0x1625524
	private static void ValidateSymbolName(IDescriptor descriptor) { }

	// RVA: 0x1625BEC Offset: 0x1621BEC VA: 0x1625BEC
	internal FieldDescriptor FindFieldByNumber(MessageDescriptor messageDescriptor, int number) { }

	// RVA: 0x1625CF0 Offset: 0x1621CF0 VA: 0x1625CF0
	internal void AddFieldByNumber(FieldDescriptor field) { }

	// RVA: 0x162608C Offset: 0x162208C VA: 0x162608C
	internal void AddEnumValue(EnumValueDescriptor enumValue) { }

	// RVA: 0x16263F8 Offset: 0x16223F8 VA: 0x16263F8
	internal IDescriptor LookupSymbol(string name, IDescriptor relativeTo) { }

	[CompilerGenerated]
	// RVA: 0x1625B24 Offset: 0x1621B24 VA: 0x1625B24
	internal static bool <ValidateSymbolName>g__IsAsciiLetter|11_0(char c) { }

	[CompilerGenerated]
	// RVA: 0x1625BD8 Offset: 0x1621BD8 VA: 0x1625BD8
	internal static bool <ValidateSymbolName>g__IsAsciiDigit|11_1(char c) { }

	[CompilerGenerated]
	// RVA: 0x1625B3C Offset: 0x1621B3C VA: 0x1625B3C
	internal static void <ValidateSymbolName>g__ThrowInvalidSymbolNameException|11_2(IDescriptor descriptor) { }
}

// Namespace: 
internal sealed class DescriptorUtil.IndexedConverter<TInput, TOutput> : MulticastDelegate // TypeDefIndex: 6505
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C870 Offset: 0x1278870 VA: 0x127C870
	|-DescriptorUtil.IndexedConverter<object, object>..ctor
	|
	|-RVA: 0x127C990 Offset: 0x1278990 VA: 0x127C990
	|-DescriptorUtil.IndexedConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TOutput Invoke(TInput element, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127C97C Offset: 0x127897C VA: 0x127C97C
	|-DescriptorUtil.IndexedConverter<object, object>.Invoke
	|
	|-RVA: 0x127CAA0 Offset: 0x1278AA0 VA: 0x127CAA0
	|-DescriptorUtil.IndexedConverter<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Google.Protobuf.Reflection
internal static class DescriptorUtil // TypeDefIndex: 6506
{
	// Methods

	// RVA: -1 Offset: -1
	internal static IList<TOutput> ConvertAndMakeReadOnly<TInput, TOutput>(IList<TInput> input, DescriptorUtil.IndexedConverter<TInput, TOutput> converter) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FA32C Offset: 0x10F632C VA: 0x10FA32C
	|-DescriptorUtil.ConvertAndMakeReadOnly<object, object>
	|
	|-RVA: 0x10FA530 Offset: 0x10F6530 VA: 0x10FA530
	|-DescriptorUtil.ConvertAndMakeReadOnly<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/
}

// Namespace: Google.Protobuf.Reflection
public sealed class DescriptorValidationException : Exception // TypeDefIndex: 6507
{
	// Fields
	[CompilerGenerated]
	private readonly string <ProblemSymbolName>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly string <Description>k__BackingField; // 0x98

	// Methods

	// RVA: 0x162512C Offset: 0x162112C VA: 0x162512C
	internal void .ctor(IDescriptor problemDescriptor, string description) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EnumDescriptor.<>c__DisplayClass0_0 // TypeDefIndex: 6508
{
	// Fields
	public FileDescriptor file; // 0x10
	public EnumDescriptor <>4__this; // 0x18

	// Methods

	// RVA: 0x1626A38 Offset: 0x1622A38 VA: 0x1626A38
	public void .ctor() { }

	// RVA: 0x1626D00 Offset: 0x1622D00 VA: 0x1626D00
	internal EnumValueDescriptor <.ctor>b__0(EnumValueDescriptorProto value, int i) { }
}

// Namespace: Google.Protobuf.Reflection
public sealed class EnumDescriptor : DescriptorBase // TypeDefIndex: 6509
{
	// Fields
	[CompilerGenerated]
	private readonly EnumDescriptorProto <Proto>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly Type <ClrType>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly MessageDescriptor <ContainingType>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly IList<EnumValueDescriptor> <Values>k__BackingField; // 0x48

	// Properties
	internal EnumDescriptorProto Proto { get; }
	public override string Name { get; }
	public IList<EnumValueDescriptor> Values { get; }

	// Methods

	// RVA: 0x16267EC Offset: 0x16227EC VA: 0x16267EC
	internal void .ctor(EnumDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, Type clrType) { }

	[CompilerGenerated]
	// RVA: 0x1626C60 Offset: 0x1622C60 VA: 0x1626C60
	internal EnumDescriptorProto get_Proto() { }

	// RVA: 0x1626C68 Offset: 0x1622C68 VA: 0x1626C68 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1626C80 Offset: 0x1622C80 VA: 0x1626C80 Slot: 8
	internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) { }

	[CompilerGenerated]
	// RVA: 0x1626CF8 Offset: 0x1622CF8 VA: 0x1626CF8
	public IList<EnumValueDescriptor> get_Values() { }
}

// Namespace: Google.Protobuf.Reflection
public sealed class EnumValueDescriptor : DescriptorBase // TypeDefIndex: 6510
{
	// Fields
	[CompilerGenerated]
	private readonly EnumValueDescriptorProto <Proto>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly EnumDescriptor <EnumDescriptor>k__BackingField; // 0x38

	// Properties
	internal EnumValueDescriptorProto Proto { get; }
	public override string Name { get; }
	public int Number { get; }
	public EnumDescriptor EnumDescriptor { get; }

	// Methods

	// RVA: 0x1626D78 Offset: 0x1622D78 VA: 0x1626D78
	internal void .ctor(EnumValueDescriptorProto proto, FileDescriptor file, EnumDescriptor parent, int index) { }

	[CompilerGenerated]
	// RVA: 0x1626E8C Offset: 0x1622E8C VA: 0x1626E8C
	internal EnumValueDescriptorProto get_Proto() { }

	// RVA: 0x1626E94 Offset: 0x1622E94 VA: 0x1626E94 Slot: 7
	public override string get_Name() { }

	// RVA: 0x16263B0 Offset: 0x16223B0 VA: 0x16263B0
	public int get_Number() { }

	[CompilerGenerated]
	// RVA: 0x1626EAC Offset: 0x1622EAC VA: 0x1626EAC
	public EnumDescriptor get_EnumDescriptor() { }
}

// Namespace: Google.Protobuf.Reflection
internal sealed class ExtensionAccessor : IFieldAccessor // TypeDefIndex: 6511
{
	// Fields
	private readonly Extension extension; // 0x10
	private readonly ReflectionUtil.IExtensionReflectionHelper helper; // 0x18
	[CompilerGenerated]
	private readonly FieldDescriptor <Descriptor>k__BackingField; // 0x20

	// Properties
	public FieldDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x1626EB4 Offset: 0x1622EB4 VA: 0x1626EB4
	internal void .ctor(FieldDescriptor descriptor) { }

	[CompilerGenerated]
	// RVA: 0x1627180 Offset: 0x1623180 VA: 0x1627180 Slot: 4
	public FieldDescriptor get_Descriptor() { }

	// RVA: 0x1627188 Offset: 0x1623188 VA: 0x1627188 Slot: 5
	public void Clear(IMessage message) { }

	// RVA: 0x1627234 Offset: 0x1623234 VA: 0x1627234 Slot: 7
	public bool HasValue(IMessage message) { }

	// RVA: 0x16272E0 Offset: 0x16232E0 VA: 0x16272E0 Slot: 6
	public object GetValue(IMessage message) { }

	// RVA: 0x1627388 Offset: 0x1623388 VA: 0x1627388 Slot: 8
	public void SetValue(IMessage message, object value) { }
}

// Namespace: 
private sealed class ExtensionCollection.ExtensionCollectionDebugView // TypeDefIndex: 6512
{}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ExtensionCollection.<>c // TypeDefIndex: 6513
{
	// Fields
	public static readonly ExtensionCollection.<>c <>9; // 0x0
	public static Func<KeyValuePair<MessageDescriptor, IList<FieldDescriptor>>, MessageDescriptor> <>9__9_0; // 0x8
	public static Func<KeyValuePair<MessageDescriptor, IList<FieldDescriptor>>, IList<FieldDescriptor>> <>9__9_1; // 0x10
	public static Func<KeyValuePair<MessageDescriptor, IList<FieldDescriptor>>, MessageDescriptor> <>9__9_2; // 0x18
	public static Func<FieldDescriptor, int> <>9__9_4; // 0x20
	public static Func<KeyValuePair<MessageDescriptor, IList<FieldDescriptor>>, IList<FieldDescriptor>> <>9__9_3; // 0x28

	// Methods

	// RVA: 0x1628278 Offset: 0x1624278 VA: 0x1628278
	private static void .cctor() { }

	// RVA: 0x16282E0 Offset: 0x16242E0 VA: 0x16282E0
	public void .ctor() { }

	// RVA: 0x16282E8 Offset: 0x16242E8 VA: 0x16282E8
	internal MessageDescriptor <CrossLink>b__9_0(KeyValuePair<MessageDescriptor, IList<FieldDescriptor>> kvp) { }

	// RVA: 0x1628324 Offset: 0x1624324 VA: 0x1628324
	internal IList<FieldDescriptor> <CrossLink>b__9_1(KeyValuePair<MessageDescriptor, IList<FieldDescriptor>> kvp) { }

	// RVA: 0x16283A8 Offset: 0x16243A8 VA: 0x16283A8
	internal MessageDescriptor <CrossLink>b__9_2(KeyValuePair<MessageDescriptor, IList<FieldDescriptor>> kvp) { }

	// RVA: 0x16283E4 Offset: 0x16243E4 VA: 0x16283E4
	internal IList<FieldDescriptor> <CrossLink>b__9_3(KeyValuePair<MessageDescriptor, IList<FieldDescriptor>> kvp) { }

	// RVA: 0x1628564 Offset: 0x1624564 VA: 0x1628564
	internal int <CrossLink>b__9_4(FieldDescriptor field) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ExtensionCollection.<>c__DisplayClass2_0 // TypeDefIndex: 6514
{
	// Fields
	public Extension[] extensions; // 0x10
	public FileDescriptor file; // 0x18

	// Methods

	// RVA: 0x1627568 Offset: 0x1623568 VA: 0x1627568
	public void .ctor() { }

	// RVA: 0x1628584 Offset: 0x1624584 VA: 0x1628584
	internal FieldDescriptor <.ctor>b__0(FieldDescriptorProto extension, int i) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ExtensionCollection.<>c__DisplayClass3_0 // TypeDefIndex: 6515
{
	// Fields
	public Extension[] extensions; // 0x10
	public MessageDescriptor message; // 0x18

	// Methods

	// RVA: 0x1627694 Offset: 0x1623694 VA: 0x1627694
	public void .ctor() { }

	// RVA: 0x1628A38 Offset: 0x1624A38 VA: 0x1628A38
	internal FieldDescriptor <.ctor>b__0(FieldDescriptorProto extension, int i) { }
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("Count = {UnorderedExtensions.Count}")]
[DebuggerTypeProxy(typeof(ExtensionCollection.ExtensionCollectionDebugView))]
public sealed class ExtensionCollection // TypeDefIndex: 6516
{
	// Fields
	private IDictionary<MessageDescriptor, IList<FieldDescriptor>> extensionsByTypeInDeclarationOrder; // 0x10
	private IDictionary<MessageDescriptor, IList<FieldDescriptor>> extensionsByTypeInNumberOrder; // 0x18
	[CompilerGenerated]
	private readonly IList<FieldDescriptor> <UnorderedExtensions>k__BackingField; // 0x20

	// Properties
	public IList<FieldDescriptor> UnorderedExtensions { get; }

	// Methods

	// RVA: 0x1627444 Offset: 0x1623444 VA: 0x1627444
	internal void .ctor(FileDescriptor file, Extension[] extensions) { }

	// RVA: 0x1627570 Offset: 0x1623570 VA: 0x1627570
	internal void .ctor(MessageDescriptor message, Extension[] extensions) { }

	[CompilerGenerated]
	// RVA: 0x162769C Offset: 0x162369C VA: 0x162769C
	public IList<FieldDescriptor> get_UnorderedExtensions() { }

	// RVA: 0x16276A4 Offset: 0x16236A4 VA: 0x16276A4
	internal void CrossLink() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FeatureSetDescriptor.<>c // TypeDefIndex: 6517
{
	// Fields
	public static readonly FeatureSetDescriptor.<>c <>9; // 0x0
	public static Func<Edition, Edition> <>9__2_0; // 0x8
	public static Func<FeatureSet, FeatureSetDescriptor> <>9__14_0; // 0x10

	// Methods

	// RVA: 0x1629574 Offset: 0x1625574 VA: 0x1629574
	private static void .cctor() { }

	// RVA: 0x16295DC Offset: 0x16255DC VA: 0x16295DC
	public void .ctor() { }

	// RVA: 0x16295E4 Offset: 0x16255E4 VA: 0x16295E4
	internal Edition <BuildEditionDefaults>b__2_0(Edition x) { }

	// RVA: 0x16295EC Offset: 0x16255EC VA: 0x16295EC
	internal FeatureSetDescriptor <MergedWith>b__14_0(FeatureSet clone) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FeatureSetDescriptor.<>c__DisplayClass2_0 // TypeDefIndex: 6518
{
	// Fields
	public FeatureSetDefaults featureSetDefaults; // 0x10

	// Methods

	// RVA: 0x1629190 Offset: 0x1625190 VA: 0x1629190
	public void .ctor() { }

	// RVA: 0x1629654 Offset: 0x1625654 VA: 0x1629654
	internal bool <BuildEditionDefaults>b__1(Edition e) { }

	// RVA: 0x1629198 Offset: 0x1625198 VA: 0x1629198
	internal FeatureSetDescriptor <BuildEditionDefaults>g__MaybeCreateDescriptor|2(Edition edition) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FeatureSetDescriptor.<>c__DisplayClass2_1 // TypeDefIndex: 6519
{
	// Fields
	public Edition edition; // 0x10

	// Methods

	// RVA: 0x16296A4 Offset: 0x16256A4 VA: 0x16296A4
	public void .ctor() { }

	// RVA: 0x16296AC Offset: 0x16256AC VA: 0x16296AC
	internal bool <BuildEditionDefaults>b__3(FeatureSetDefaults.Types.FeatureSetEditionDefault d) { }
}

// Namespace: Google.Protobuf.Reflection
internal sealed class FeatureSetDescriptor // TypeDefIndex: 6520
{
	// Fields
	private static readonly ConcurrentDictionary<FeatureSet, FeatureSetDescriptor> cache; // 0x0
	private static readonly IReadOnlyDictionary<Edition, FeatureSetDescriptor> descriptorsByEdition; // 0x8
	[CompilerGenerated]
	private readonly FeatureSet <Proto>k__BackingField; // 0x10

	// Properties
	internal FeatureSet Proto { get; }
	internal FeatureSet.Types.FieldPresence FieldPresence { get; }
	internal FeatureSet.Types.MessageEncoding MessageEncoding { get; }

	// Methods

	// RVA: 0x1628B34 Offset: 0x1624B34 VA: 0x1628B34
	private static IReadOnlyDictionary<Edition, FeatureSetDescriptor> BuildEditionDefaults() { }

	// RVA: 0x1629300 Offset: 0x1625300 VA: 0x1629300
	internal static FeatureSetDescriptor GetEditionDefaults(Edition edition) { }

	[CompilerGenerated]
	// RVA: 0x1629460 Offset: 0x1625460 VA: 0x1629460
	internal FeatureSet get_Proto() { }

	// RVA: 0x1629468 Offset: 0x1625468 VA: 0x1629468
	internal FeatureSet.Types.FieldPresence get_FieldPresence() { }

	// RVA: 0x162947C Offset: 0x162547C VA: 0x162947C
	internal FeatureSet.Types.MessageEncoding get_MessageEncoding() { }

	// RVA: 0x1629490 Offset: 0x1625490 VA: 0x1629490
	private void .ctor(FeatureSet proto) { }

	// RVA: 0x1626AF0 Offset: 0x1622AF0 VA: 0x1626AF0
	public FeatureSetDescriptor MergedWith(FeatureSet overrides) { }

	// RVA: 0x16294C0 Offset: 0x16254C0 VA: 0x16294C0
	private static void .cctor() { }
}

// Namespace: Google.Protobuf.Reflection
internal abstract class FieldAccessorBase : IFieldAccessor // TypeDefIndex: 6521
{
	// Fields
	private readonly Func<IMessage, object> getValueDelegate; // 0x10
	[CompilerGenerated]
	private readonly FieldDescriptor <Descriptor>k__BackingField; // 0x18

	// Properties
	public FieldDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x16296D8 Offset: 0x16256D8 VA: 0x16296D8
	internal void .ctor(PropertyInfo property, FieldDescriptor descriptor) { }

	[CompilerGenerated]
	// RVA: 0x1629890 Offset: 0x1625890 VA: 0x1629890 Slot: 4
	public FieldDescriptor get_Descriptor() { }

	// RVA: 0x1629898 Offset: 0x1625898 VA: 0x1629898 Slot: 6
	public object GetValue(IMessage message) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool HasValue(IMessage message);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Clear(IMessage message);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void SetValue(IMessage message, object value);
}

// Namespace: Google.Protobuf.Reflection
public sealed class FieldDescriptor : DescriptorBase, IComparable<FieldDescriptor> // TypeDefIndex: 6522
{
	// Fields
	private EnumDescriptor enumType; // 0x30
	private MessageDescriptor extendeeType; // 0x38
	private MessageDescriptor messageType; // 0x40
	private IFieldAccessor accessor; // 0x48
	[CompilerGenerated]
	private readonly MessageDescriptor <ContainingType>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly OneofDescriptor <ContainingOneof>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly string <JsonName>k__BackingField; // 0x60
	[CompilerGenerated]
	private readonly string <PropertyName>k__BackingField; // 0x68
	[CompilerGenerated]
	private readonly FieldDescriptorProto <Proto>k__BackingField; // 0x70
	[CompilerGenerated]
	private readonly Extension <Extension>k__BackingField; // 0x78
	[CompilerGenerated]
	private FieldType <FieldType>k__BackingField; // 0x80

	// Properties
	public MessageDescriptor ContainingType { get; }
	public OneofDescriptor ContainingOneof { get; }
	public OneofDescriptor RealContainingOneof { get; }
	public string JsonName { get; }
	public string PropertyName { get; }
	public bool HasPresence { get; }
	internal FieldDescriptorProto Proto { get; }
	public Extension Extension { get; }
	public override string Name { get; }
	public IFieldAccessor Accessor { get; }
	public bool IsRepeated { get; }
	public bool IsMap { get; }
	public FieldType FieldType { get; set; }
	public int FieldNumber { get; }
	public MessageDescriptor MessageType { get; }
	public MessageDescriptor ExtendeeType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x16298B8 Offset: 0x16258B8 VA: 0x16298B8
	public MessageDescriptor get_ContainingType() { }

	[CompilerGenerated]
	// RVA: 0x16298C0 Offset: 0x16258C0 VA: 0x16298C0
	public OneofDescriptor get_ContainingOneof() { }

	// RVA: 0x16298C8 Offset: 0x16258C8 VA: 0x16298C8
	public OneofDescriptor get_RealContainingOneof() { }

	[CompilerGenerated]
	// RVA: 0x16298E8 Offset: 0x16258E8 VA: 0x16298E8
	public string get_JsonName() { }

	[CompilerGenerated]
	// RVA: 0x16298F0 Offset: 0x16258F0 VA: 0x16298F0
	public string get_PropertyName() { }

	// RVA: 0x16298F8 Offset: 0x16258F8 VA: 0x16298F8
	public bool get_HasPresence() { }

	[CompilerGenerated]
	// RVA: 0x16299D0 Offset: 0x16259D0 VA: 0x16299D0
	internal FieldDescriptorProto get_Proto() { }

	[CompilerGenerated]
	// RVA: 0x16299D8 Offset: 0x16259D8 VA: 0x16299D8
	public Extension get_Extension() { }

	// RVA: 0x1628660 Offset: 0x1624660 VA: 0x1628660
	internal void .ctor(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string propertyName, Extension extension) { }

	// RVA: 0x16299E0 Offset: 0x16259E0 VA: 0x16299E0
	private static FeatureSetDescriptor GetDirectParentFeatures(FieldDescriptorProto proto, FileDescriptor file, MessageDescriptor parent) { }

	// RVA: 0x1629B14 Offset: 0x1625B14 VA: 0x1629B14
	private static FeatureSet InferFeatures(FileDescriptor file, FieldDescriptorProto proto) { }

	// RVA: 0x1629DF0 Offset: 0x1625DF0 VA: 0x1629DF0 Slot: 7
	public override string get_Name() { }

	// RVA: 0x1629E08 Offset: 0x1625E08 VA: 0x1629E08
	public IFieldAccessor get_Accessor() { }

	// RVA: 0x1629CD8 Offset: 0x1625CD8 VA: 0x1629CD8
	private static FieldType GetFieldTypeFromProtoType(FieldDescriptorProto.Types.Type type) { }

	// RVA: 0x1629980 Offset: 0x1625980 VA: 0x1629980
	public bool get_IsRepeated() { }

	// RVA: 0x16299A8 Offset: 0x16259A8 VA: 0x16299A8
	public bool get_IsMap() { }

	[CompilerGenerated]
	// RVA: 0x1629E34 Offset: 0x1625E34 VA: 0x1629E34
	public FieldType get_FieldType() { }

	[CompilerGenerated]
	// RVA: 0x1629E3C Offset: 0x1625E3C VA: 0x1629E3C
	private void set_FieldType(FieldType value) { }

	// RVA: 0x1626074 Offset: 0x1622074 VA: 0x1626074
	public int get_FieldNumber() { }

	// RVA: 0x1629E44 Offset: 0x1625E44 VA: 0x1629E44 Slot: 9
	public int CompareTo(FieldDescriptor other) { }

	// RVA: 0x1629EE0 Offset: 0x1625EE0 VA: 0x1629EE0
	public MessageDescriptor get_MessageType() { }

	// RVA: 0x1626000 Offset: 0x1622000 VA: 0x1626000
	public MessageDescriptor get_ExtendeeType() { }

	// RVA: 0x1627DB0 Offset: 0x1623DB0 VA: 0x1627DB0
	internal void CrossLink() { }

	// RVA: 0x1629F44 Offset: 0x1625F44 VA: 0x1629F44
	private IFieldAccessor CreateAccessor() { }
}

// Namespace: Google.Protobuf.Reflection
public enum FieldType // TypeDefIndex: 6523
{
	// Fields
	public int value__; // 0x0
	public const FieldType Double = 0;
	public const FieldType Float = 1;
	public const FieldType Int64 = 2;
	public const FieldType UInt64 = 3;
	public const FieldType Int32 = 4;
	public const FieldType Fixed64 = 5;
	public const FieldType Fixed32 = 6;
	public const FieldType Bool = 7;
	public const FieldType String = 8;
	public const FieldType Group = 9;
	public const FieldType Message = 10;
	public const FieldType Bytes = 11;
	public const FieldType UInt32 = 12;
	public const FieldType SFixed32 = 13;
	public const FieldType SFixed64 = 14;
	public const FieldType SInt32 = 15;
	public const FieldType SInt64 = 16;
	public const FieldType Enum = 17;
}

// Namespace: Google.Protobuf.Reflection
[Obsolete("Use features instead")]
public enum Syntax // TypeDefIndex: 6524
{
	// Fields
	public int value__; // 0x0
	public const Syntax Proto2 = 0;
	public const Syntax Proto3 = 1;
	public const Syntax Editions = 2;
	public const Syntax Unknown = 3;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FileDescriptor.<>c // TypeDefIndex: 6525
{
	// Fields
	public static readonly FileDescriptor.<>c <>9; // 0x0
	public static Func<FileDescriptor, string> <>9__9_0; // 0x8
	public static Func<GeneratedClrTypeInfo, bool> <>9__58_0; // 0x10
	public static Func<FieldDescriptor, Extension> <>9__59_0; // 0x18
	public static Func<Extension, bool> <>9__59_1; // 0x20
	public static Func<FieldDescriptor, Extension> <>9__60_0; // 0x28
	public static Func<Extension, bool> <>9__60_1; // 0x30

	// Methods

	// RVA: 0x162D644 Offset: 0x1629644 VA: 0x162D644
	private static void .cctor() { }

	// RVA: 0x162D6AC Offset: 0x16296AC VA: 0x162D6AC
	public void .ctor() { }

	// RVA: 0x162D6B4 Offset: 0x16296B4 VA: 0x162D6B4
	internal string <DeterminePublicDependencies>b__9_0(FileDescriptor file) { }

	// RVA: 0x162D6D4 Offset: 0x16296D4 VA: 0x162D6D4
	internal bool <GetAllGeneratedExtensions>b__58_0(GeneratedClrTypeInfo t) { }

	// RVA: 0x162D6E0 Offset: 0x16296E0 VA: 0x162D6E0
	internal Extension <GetAllDependedExtensions>b__59_0(FieldDescriptor s) { }

	// RVA: 0x162D6F4 Offset: 0x16296F4 VA: 0x162D6F4
	internal bool <GetAllDependedExtensions>b__59_1(Extension e) { }

	// RVA: 0x162D700 Offset: 0x1629700 VA: 0x162D700
	internal Extension <GetAllDependedExtensionsFromMessage>b__60_0(FieldDescriptor s) { }

	// RVA: 0x162D714 Offset: 0x1629714 VA: 0x162D714
	internal bool <GetAllDependedExtensionsFromMessage>b__60_1(Extension e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FileDescriptor.<>c__DisplayClass2_0 // TypeDefIndex: 6526
{
	// Fields
	public FileDescriptor <>4__this; // 0x10
	public GeneratedClrTypeInfo generatedCodeInfo; // 0x18

	// Methods

	// RVA: 0x162AC08 Offset: 0x1626C08 VA: 0x162AC08
	public void .ctor() { }

	// RVA: 0x162D720 Offset: 0x1629720 VA: 0x162D720
	internal MessageDescriptor <.ctor>b__0(DescriptorProto message, int index) { }

	// RVA: 0x162E0F8 Offset: 0x162A0F8 VA: 0x162E0F8
	internal EnumDescriptor <.ctor>b__1(EnumDescriptorProto enumType, int index) { }

	// RVA: 0x162E1A4 Offset: 0x162A1A4 VA: 0x162E1A4
	internal ServiceDescriptor <.ctor>b__2(ServiceDescriptorProto service, int index) { }
}

// Namespace: Google.Protobuf.Reflection
public sealed class FileDescriptor : IDescriptor // TypeDefIndex: 6527
{
	// Fields
	private readonly Lazy<Dictionary<IDescriptor, DescriptorDeclaration>> declarations; // 0x10
	[CompilerGenerated]
	private readonly FileDescriptorProto <Proto>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly FeatureSetDescriptor <Features>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly IList<MessageDescriptor> <MessageTypes>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly IList<EnumDescriptor> <EnumTypes>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly IList<ServiceDescriptor> <Services>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly ExtensionCollection <Extensions>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly IList<FileDescriptor> <Dependencies>k__BackingField; // 0x48
	[CompilerGenerated]
	private readonly IList<FileDescriptor> <PublicDependencies>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly ByteString <SerializedData>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly DescriptorPool <DescriptorPool>k__BackingField; // 0x60

	// Properties
	internal FileDescriptorProto Proto { get; }
	internal FeatureSetDescriptor Features { get; }
	internal Edition Edition { get; }
	public string Name { get; }
	public string Package { get; }
	public IList<MessageDescriptor> MessageTypes { get; }
	public IList<EnumDescriptor> EnumTypes { get; }
	public IList<ServiceDescriptor> Services { get; }
	public ExtensionCollection Extensions { get; }
	public IList<FileDescriptor> Dependencies { get; }
	public IList<FileDescriptor> PublicDependencies { get; }
	private string Google.Protobuf.Reflection.IDescriptor.FullName { get; }
	private FileDescriptor Google.Protobuf.Reflection.IDescriptor.File { get; }
	internal DescriptorPool DescriptorPool { get; }

	// Methods

	// RVA: 0x162A6A8 Offset: 0x16266A8 VA: 0x162A6A8
	private static void .cctor() { }

	// RVA: 0x162A768 Offset: 0x1626768 VA: 0x162A768
	private void .ctor(ByteString descriptorData, FileDescriptorProto proto, IList<FileDescriptor> dependencies, DescriptorPool pool, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo) { }

	// RVA: 0x162AFA8 Offset: 0x1626FA8 VA: 0x162AFA8
	private Dictionary<IDescriptor, DescriptorDeclaration> CreateDeclarationMap() { }

	// RVA: 0x162B370 Offset: 0x1627370 VA: 0x162B370
	private IDescriptor FindDescriptorForPath(IList<int> path) { }

	// RVA: 0x162B7AC Offset: 0x16277AC VA: 0x162B7AC
	private static DescriptorBase GetDescriptorFromList(IReadOnlyList<DescriptorBase> list, int index) { }

	// RVA: 0x162B710 Offset: 0x1627710 VA: 0x162B710
	private IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) { }

	// RVA: 0x1626A40 Offset: 0x1622A40 VA: 0x1626A40
	internal string ComputeFullName(MessageDescriptor parent, string name) { }

	// RVA: 0x162AC10 Offset: 0x1626C10 VA: 0x162AC10
	private static IList<FileDescriptor> DeterminePublicDependencies(FileDescriptor this, FileDescriptorProto proto, IEnumerable<FileDescriptor> dependencies, bool allowUnknownDependencies) { }

	[CompilerGenerated]
	// RVA: 0x162B91C Offset: 0x162791C VA: 0x162B91C
	internal FileDescriptorProto get_Proto() { }

	[CompilerGenerated]
	// RVA: 0x162B924 Offset: 0x1627924 VA: 0x162B924
	internal FeatureSetDescriptor get_Features() { }

	// RVA: 0x1629D40 Offset: 0x1625D40 VA: 0x1629D40
	internal Edition get_Edition() { }

	// RVA: 0x1625114 Offset: 0x1621114 VA: 0x1625114 Slot: 4
	public string get_Name() { }

	// RVA: 0x1624E04 Offset: 0x1620E04 VA: 0x1624E04
	public string get_Package() { }

	[CompilerGenerated]
	// RVA: 0x162B92C Offset: 0x162792C VA: 0x162B92C
	public IList<MessageDescriptor> get_MessageTypes() { }

	[CompilerGenerated]
	// RVA: 0x162B934 Offset: 0x1627934 VA: 0x162B934
	public IList<EnumDescriptor> get_EnumTypes() { }

	[CompilerGenerated]
	// RVA: 0x162B93C Offset: 0x162793C VA: 0x162B93C
	public IList<ServiceDescriptor> get_Services() { }

	[CompilerGenerated]
	// RVA: 0x162B944 Offset: 0x1627944 VA: 0x162B944
	public ExtensionCollection get_Extensions() { }

	[CompilerGenerated]
	// RVA: 0x162B94C Offset: 0x162794C VA: 0x162B94C
	public IList<FileDescriptor> get_Dependencies() { }

	[CompilerGenerated]
	// RVA: 0x162B954 Offset: 0x1627954 VA: 0x162B954
	public IList<FileDescriptor> get_PublicDependencies() { }

	// RVA: 0x162B95C Offset: 0x162795C VA: 0x162B95C Slot: 5
	private string Google.Protobuf.Reflection.IDescriptor.get_FullName() { }

	// RVA: 0x162B974 Offset: 0x1627974 VA: 0x162B974 Slot: 6
	private FileDescriptor Google.Protobuf.Reflection.IDescriptor.get_File() { }

	[CompilerGenerated]
	// RVA: 0x162B978 Offset: 0x1627978 VA: 0x162B978
	internal DescriptorPool get_DescriptorPool() { }

	// RVA: 0x162B980 Offset: 0x1627980 VA: 0x162B980
	private static FileDescriptor BuildFrom(ByteString descriptorData, FileDescriptorProto proto, FileDescriptor[] dependencies, bool allowUnknownDependencies, GeneratedClrTypeInfo generatedCodeInfo) { }

	// RVA: 0x162BAE0 Offset: 0x1627AE0 VA: 0x162BAE0
	private void CrossLink() { }

	// RVA: 0x162C974 Offset: 0x1628974 VA: 0x162C974
	public static FileDescriptor FromGeneratedCode(byte[] descriptorData, FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedCodeInfo) { }

	// RVA: 0x162CD08 Offset: 0x1628D08 VA: 0x162CD08
	private static IEnumerable<Extension> GetAllExtensions(FileDescriptor[] dependencies, GeneratedClrTypeInfo generatedInfo) { }

	// RVA: 0x162CE64 Offset: 0x1628E64 VA: 0x162CE64
	private static IEnumerable<Extension> GetAllGeneratedExtensions(GeneratedClrTypeInfo generated) { }

	// RVA: 0x162D018 Offset: 0x1629018 VA: 0x162D018
	private static IEnumerable<Extension> GetAllDependedExtensions(FileDescriptor descriptor) { }

	// RVA: 0x162D364 Offset: 0x1629364 VA: 0x162D364
	private static IEnumerable<Extension> GetAllDependedExtensionsFromMessage(MessageDescriptor descriptor) { }

	// RVA: 0x162D5E0 Offset: 0x16295E0 VA: 0x162D5E0 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	public static void ForceReflectionInitialization<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1114C7C Offset: 0x1110C7C VA: 0x1114C7C
	|-FileDescriptor.ForceReflectionInitialization<Int32Enum>
	|
	|-RVA: 0x1114CD0 Offset: 0x1110CD0 VA: 0x1114CD0
	|-FileDescriptor.ForceReflectionInitialization<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("ClrType = {ClrType}")]
public sealed class GeneratedClrTypeInfo // TypeDefIndex: 6528
{
	// Fields
	private static readonly string[] EmptyNames; // 0x0
	private static readonly GeneratedClrTypeInfo[] EmptyCodeInfo; // 0x8
	private static readonly Extension[] EmptyExtensions; // 0x10
	[CompilerGenerated]
	private readonly Type <ClrType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly MessageParser <Parser>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string[] <PropertyNames>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly Extension[] <Extensions>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string[] <OneofNames>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly GeneratedClrTypeInfo[] <NestedTypes>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly Type[] <NestedEnums>k__BackingField; // 0x40

	// Properties
	[DynamicallyAccessedMembers(1547)]
	public Type ClrType { get; }
	public MessageParser Parser { get; }
	public string[] PropertyNames { get; }
	public Extension[] Extensions { get; }
	public string[] OneofNames { get; }
	public GeneratedClrTypeInfo[] NestedTypes { get; }
	public Type[] NestedEnums { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x162E3CC Offset: 0x162A3CC VA: 0x162E3CC
	public Type get_ClrType() { }

	[CompilerGenerated]
	// RVA: 0x162E3D4 Offset: 0x162A3D4 VA: 0x162E3D4
	public MessageParser get_Parser() { }

	[CompilerGenerated]
	// RVA: 0x162E3DC Offset: 0x162A3DC VA: 0x162E3DC
	public string[] get_PropertyNames() { }

	[CompilerGenerated]
	// RVA: 0x162E3E4 Offset: 0x162A3E4 VA: 0x162E3E4
	public Extension[] get_Extensions() { }

	[CompilerGenerated]
	// RVA: 0x162E3EC Offset: 0x162A3EC VA: 0x162E3EC
	public string[] get_OneofNames() { }

	[CompilerGenerated]
	// RVA: 0x162E3F4 Offset: 0x162A3F4 VA: 0x162E3F4
	public GeneratedClrTypeInfo[] get_NestedTypes() { }

	[CompilerGenerated]
	// RVA: 0x162E3FC Offset: 0x162A3FC VA: 0x162E3FC
	public Type[] get_NestedEnums() { }

	// RVA: 0x162E404 Offset: 0x162A404 VA: 0x162E404
	public void .ctor(Type clrType, MessageParser parser, string[] propertyNames, string[] oneofNames, Type[] nestedEnums, Extension[] extensions, GeneratedClrTypeInfo[] nestedTypes) { }

	// RVA: 0x162E5C4 Offset: 0x162A5C4 VA: 0x162E5C4
	public void .ctor(Type[] nestedEnums, Extension[] extensions, GeneratedClrTypeInfo[] nestedTypes) { }

	// RVA: 0x162E5F8 Offset: 0x162A5F8 VA: 0x162E5F8
	private static void .cctor() { }
}

// Namespace: Google.Protobuf.Reflection
public interface IDescriptor // TypeDefIndex: 6529
{
	// Properties
	public abstract string Name { get; }
	public abstract string FullName { get; }
	public abstract FileDescriptor File { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_FullName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract FileDescriptor get_File();
}

// Namespace: Google.Protobuf.Reflection
public interface IFieldAccessor // TypeDefIndex: 6530
{
	// Properties
	public abstract FieldDescriptor Descriptor { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract FieldDescriptor get_Descriptor();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Clear(IMessage message);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object GetValue(IMessage message);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool HasValue(IMessage message);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetValue(IMessage message, object value);
}

// Namespace: Google.Protobuf.Reflection
internal sealed class MapFieldAccessor : FieldAccessorBase // TypeDefIndex: 6531
{
	// Methods

	// RVA: 0x162A6A4 Offset: 0x16266A4 VA: 0x162A6A4
	internal void .ctor(PropertyInfo property, FieldDescriptor descriptor) { }

	// RVA: 0x162E6E4 Offset: 0x162A6E4 VA: 0x162E6E4 Slot: 10
	public override void Clear(IMessage message) { }

	// RVA: 0x162E7E8 Offset: 0x162A7E8 VA: 0x162E7E8 Slot: 9
	public override bool HasValue(IMessage message) { }

	// RVA: 0x162E834 Offset: 0x162A834 VA: 0x162E834 Slot: 11
	public override void SetValue(IMessage message, object value) { }
}

// Namespace: 
private sealed class MessageDescriptor.FieldCollection.FieldCollectionDebugView // TypeDefIndex: 6532
{}

// Namespace: 
[DefaultMember("Item")]
[DebuggerDisplay("Count = {InFieldNumberOrder().Count}")]
[DebuggerTypeProxy(typeof(MessageDescriptor.FieldCollection.FieldCollectionDebugView))]
public sealed class MessageDescriptor.FieldCollection // TypeDefIndex: 6533
{
	// Fields
	private readonly MessageDescriptor messageDescriptor; // 0x10

	// Properties
	public FieldDescriptor Item { get; }

	// Methods

	// RVA: 0x162EE2C Offset: 0x162AE2C VA: 0x162EE2C
	internal void .ctor(MessageDescriptor messageDescriptor) { }

	// RVA: 0x162F7D0 Offset: 0x162B7D0 VA: 0x162F7D0
	public IList<FieldDescriptor> InDeclarationOrder() { }

	// RVA: 0x162F7E8 Offset: 0x162B7E8 VA: 0x162F7E8
	public IList<FieldDescriptor> InFieldNumberOrder() { }

	// RVA: 0x162F800 Offset: 0x162B800 VA: 0x162F800
	public FieldDescriptor get_Item(int number) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MessageDescriptor.<>c // TypeDefIndex: 6534
{
	// Fields
	public static readonly MessageDescriptor.<>c <>9; // 0x0
	public static Func<FieldDescriptor, int> <>9__5_4; // 0x8

	// Methods

	// RVA: 0x162F868 Offset: 0x162B868 VA: 0x162F868
	private static void .cctor() { }

	// RVA: 0x162F8D0 Offset: 0x162B8D0 VA: 0x162F8D0
	public void .ctor() { }

	// RVA: 0x162F8D8 Offset: 0x162B8D8 VA: 0x162F8D8
	internal int <.ctor>b__5_4(FieldDescriptor field) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MessageDescriptor.<>c__DisplayClass5_0 // TypeDefIndex: 6535
{
	// Fields
	public FileDescriptor file; // 0x10
	public MessageDescriptor <>4__this; // 0x18
	public GeneratedClrTypeInfo generatedCodeInfo; // 0x20

	// Methods

	// RVA: 0x162E880 Offset: 0x162A880 VA: 0x162E880
	public void .ctor() { }

	// RVA: 0x162F8F8 Offset: 0x162B8F8 VA: 0x162F8F8
	internal OneofDescriptor <.ctor>b__0(OneofDescriptorProto oneof, int index) { }

	// RVA: 0x162FB78 Offset: 0x162BB78 VA: 0x162FB78
	internal MessageDescriptor <.ctor>b__1(DescriptorProto type, int index) { }

	// RVA: 0x162FC30 Offset: 0x162BC30 VA: 0x162FC30
	internal EnumDescriptor <.ctor>b__2(EnumDescriptorProto type, int index) { }

	// RVA: 0x162FCE8 Offset: 0x162BCE8 VA: 0x162FCE8
	internal FieldDescriptor <.ctor>b__3(FieldDescriptorProto field, int index) { }
}

// Namespace: Google.Protobuf.Reflection
public sealed class MessageDescriptor : DescriptorBase // TypeDefIndex: 6536
{
	// Fields
	private static readonly HashSet<string> WellKnownTypeNames; // 0x0
	private readonly IList<FieldDescriptor> fieldsInDeclarationOrder; // 0x30
	private readonly IList<FieldDescriptor> fieldsInNumberOrder; // 0x38
	private readonly IDictionary<string, FieldDescriptor> jsonFieldMap; // 0x40
	[CompilerGenerated]
	private readonly DescriptorProto <Proto>k__BackingField; // 0x48
	[CompilerGenerated]
	private readonly Type <ClrType>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly MessageParser <Parser>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly MessageDescriptor <ContainingType>k__BackingField; // 0x60
	[CompilerGenerated]
	private readonly MessageDescriptor.FieldCollection <Fields>k__BackingField; // 0x68
	[CompilerGenerated]
	private readonly ExtensionCollection <Extensions>k__BackingField; // 0x70
	[CompilerGenerated]
	private readonly IList<MessageDescriptor> <NestedTypes>k__BackingField; // 0x78
	[CompilerGenerated]
	private readonly IList<EnumDescriptor> <EnumTypes>k__BackingField; // 0x80
	[CompilerGenerated]
	private readonly IList<OneofDescriptor> <Oneofs>k__BackingField; // 0x88
	[CompilerGenerated]
	private readonly int <RealOneofCount>k__BackingField; // 0x90

	// Properties
	public override string Name { get; }
	internal DescriptorProto Proto { get; }
	[DynamicallyAccessedMembers(1547)]
	public Type ClrType { get; }
	public MessageParser Parser { get; }
	internal bool IsWellKnownType { get; }
	internal bool IsWrapperType { get; }
	public bool IsMapEntry { get; }
	public MessageDescriptor.FieldCollection Fields { get; }
	public ExtensionCollection Extensions { get; }
	public IList<MessageDescriptor> NestedTypes { get; }
	public IList<EnumDescriptor> EnumTypes { get; }
	public IList<OneofDescriptor> Oneofs { get; }

	// Methods

	// RVA: 0x162D7CC Offset: 0x16297CC VA: 0x162D7CC
	internal void .ctor(DescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int typeIndex, GeneratedClrTypeInfo generatedCodeInfo) { }

	// RVA: 0x162E888 Offset: 0x162A888 VA: 0x162E888
	private static ReadOnlyDictionary<string, FieldDescriptor> CreateJsonFieldMap(IList<FieldDescriptor> fields) { }

	// RVA: 0x162EE5C Offset: 0x162AE5C VA: 0x162EE5C Slot: 7
	public override string get_Name() { }

	// RVA: 0x162EE74 Offset: 0x162AE74 VA: 0x162EE74 Slot: 8
	internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) { }

	[CompilerGenerated]
	// RVA: 0x162EF34 Offset: 0x162AF34 VA: 0x162EF34
	internal DescriptorProto get_Proto() { }

	[CompilerGenerated]
	// RVA: 0x162EF3C Offset: 0x162AF3C VA: 0x162EF3C
	public Type get_ClrType() { }

	[CompilerGenerated]
	// RVA: 0x162EF44 Offset: 0x162AF44 VA: 0x162EF44
	public MessageParser get_Parser() { }

	// RVA: 0x162EF4C Offset: 0x162AF4C VA: 0x162EF4C
	internal bool get_IsWellKnownType() { }

	// RVA: 0x162F038 Offset: 0x162B038 VA: 0x162F038
	internal bool get_IsWrapperType() { }

	// RVA: 0x1629E10 Offset: 0x1625E10 VA: 0x1629E10
	public bool get_IsMapEntry() { }

	[CompilerGenerated]
	// RVA: 0x162F0E8 Offset: 0x162B0E8 VA: 0x162F0E8
	public MessageDescriptor.FieldCollection get_Fields() { }

	[CompilerGenerated]
	// RVA: 0x162F0F0 Offset: 0x162B0F0 VA: 0x162F0F0
	public ExtensionCollection get_Extensions() { }

	[CompilerGenerated]
	// RVA: 0x162F0F8 Offset: 0x162B0F8 VA: 0x162F0F8
	public IList<MessageDescriptor> get_NestedTypes() { }

	[CompilerGenerated]
	// RVA: 0x162F100 Offset: 0x162B100 VA: 0x162F100
	public IList<EnumDescriptor> get_EnumTypes() { }

	[CompilerGenerated]
	// RVA: 0x162F108 Offset: 0x162B108 VA: 0x162F108
	public IList<OneofDescriptor> get_Oneofs() { }

	// RVA: 0x162F110 Offset: 0x162B110 VA: 0x162F110
	public FieldDescriptor FindFieldByName(string name) { }

	// RVA: 0x162F19C Offset: 0x162B19C VA: 0x162F19C
	public FieldDescriptor FindFieldByNumber(int number) { }

	// RVA: 0x162BFBC Offset: 0x1627FBC VA: 0x162BFBC
	internal void CrossLink() { }

	// RVA: 0x162F59C Offset: 0x162B59C VA: 0x162F59C
	private static void .cctor() { }
}

// Namespace: Google.Protobuf.Reflection
public sealed class MethodDescriptor : DescriptorBase // TypeDefIndex: 6537
{
	// Fields
	[CompilerGenerated]
	private readonly ServiceDescriptor <Service>k__BackingField; // 0x30
	[CompilerGenerated]
	private MessageDescriptor <InputType>k__BackingField; // 0x38
	[CompilerGenerated]
	private MessageDescriptor <OutputType>k__BackingField; // 0x40
	[CompilerGenerated]
	private MethodDescriptorProto <Proto>k__BackingField; // 0x48

	// Properties
	private MessageDescriptor InputType { set; }
	private MessageDescriptor OutputType { set; }
	internal MethodDescriptorProto Proto { get; set; }
	public override string Name { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x162FDA4 Offset: 0x162BDA4 VA: 0x162FDA4
	private void set_InputType(MessageDescriptor value) { }

	[CompilerGenerated]
	// RVA: 0x162FDAC Offset: 0x162BDAC VA: 0x162FDAC
	private void set_OutputType(MessageDescriptor value) { }

	// RVA: 0x162FDB4 Offset: 0x162BDB4 VA: 0x162FDB4
	internal void .ctor(MethodDescriptorProto proto, FileDescriptor file, ServiceDescriptor parent, int index) { }

	[CompilerGenerated]
	// RVA: 0x162FEB8 Offset: 0x162BEB8 VA: 0x162FEB8
	internal MethodDescriptorProto get_Proto() { }

	[CompilerGenerated]
	// RVA: 0x162FEC0 Offset: 0x162BEC0 VA: 0x162FEC0
	private void set_Proto(MethodDescriptorProto value) { }

	// RVA: 0x162FEC8 Offset: 0x162BEC8 VA: 0x162FEC8 Slot: 7
	public override string get_Name() { }

	// RVA: 0x162FEE0 Offset: 0x162BEE0 VA: 0x162FEE0
	internal void CrossLink() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class OneofAccessor.<>c__DisplayClass4_0 // TypeDefIndex: 6538
{
	// Fields
	public OneofDescriptor descriptor; // 0x10

	// Methods

	// RVA: 0x1630518 Offset: 0x162C518 VA: 0x1630518
	public void .ctor() { }

	// RVA: 0x163059C Offset: 0x162C59C VA: 0x163059C
	internal int <ForSyntheticOneof>b__0(IMessage message) { }

	// RVA: 0x163076C Offset: 0x162C76C VA: 0x163076C
	internal void <ForSyntheticOneof>b__1(IMessage message) { }
}

// Namespace: Google.Protobuf.Reflection
public sealed class OneofAccessor // TypeDefIndex: 6539
{
	// Fields
	private readonly Func<IMessage, int> caseDelegate; // 0x10
	private readonly Action<IMessage> clearDelegate; // 0x18
	[CompilerGenerated]
	private readonly OneofDescriptor <Descriptor>k__BackingField; // 0x20

	// Properties
	public OneofDescriptor Descriptor { get; }

	// Methods

	// RVA: 0x1630070 Offset: 0x162C070 VA: 0x1630070
	private void .ctor(OneofDescriptor descriptor, Func<IMessage, int> caseDelegate, Action<IMessage> clearDelegate) { }

	// RVA: 0x16300D0 Offset: 0x162C0D0 VA: 0x16300D0
	internal static OneofAccessor ForRegularOneof(OneofDescriptor descriptor, PropertyInfo caseProperty, MethodInfo clearMethod) { }

	// RVA: 0x16303D0 Offset: 0x162C3D0 VA: 0x16303D0
	internal static OneofAccessor ForSyntheticOneof(OneofDescriptor descriptor) { }

	[CompilerGenerated]
	// RVA: 0x1630520 Offset: 0x162C520 VA: 0x1630520
	public OneofDescriptor get_Descriptor() { }

	// RVA: 0x1630528 Offset: 0x162C528 VA: 0x1630528
	public void Clear(IMessage message) { }

	// RVA: 0x1630548 Offset: 0x162C548 VA: 0x1630548
	public FieldDescriptor GetCaseFieldDescriptor(IMessage message) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class OneofDescriptor.<>c__DisplayClass3_0 // TypeDefIndex: 6540
{
	// Fields
	public int index; // 0x10

	// Methods

	// RVA: 0x163089C Offset: 0x162C89C VA: 0x163089C
	public void .ctor() { }

	// RVA: 0x1630B14 Offset: 0x162CB14 VA: 0x1630B14
	internal bool <.ctor>b__0(FieldDescriptorProto fieldProto) { }
}

// Namespace: Google.Protobuf.Reflection
public sealed class OneofDescriptor : DescriptorBase // TypeDefIndex: 6541
{
	// Fields
	private MessageDescriptor containingType; // 0x30
	private IList<FieldDescriptor> fields; // 0x38
	private readonly OneofAccessor accessor; // 0x40
	[CompilerGenerated]
	private readonly OneofDescriptorProto <Proto>k__BackingField; // 0x48
	[CompilerGenerated]
	private readonly bool <IsSynthetic>k__BackingField; // 0x50

	// Properties
	public override string Name { get; }
	internal OneofDescriptorProto Proto { get; }
	public MessageDescriptor ContainingType { get; }
	public IList<FieldDescriptor> Fields { get; }
	public bool IsSynthetic { get; }
	public OneofAccessor Accessor { get; }

	// Methods

	// RVA: 0x162F9B0 Offset: 0x162B9B0 VA: 0x162F9B0
	internal void .ctor(OneofDescriptorProto proto, FileDescriptor file, MessageDescriptor parent, int index, string clrName) { }

	// RVA: 0x1630AD4 Offset: 0x162CAD4 VA: 0x1630AD4 Slot: 7
	public override string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x1630AEC Offset: 0x162CAEC VA: 0x1630AEC
	internal OneofDescriptorProto get_Proto() { }

	// RVA: 0x1630AF4 Offset: 0x162CAF4 VA: 0x1630AF4
	public MessageDescriptor get_ContainingType() { }

	// RVA: 0x1630AFC Offset: 0x162CAFC VA: 0x1630AFC
	public IList<FieldDescriptor> get_Fields() { }

	[CompilerGenerated]
	// RVA: 0x1630B04 Offset: 0x162CB04 VA: 0x1630B04
	public bool get_IsSynthetic() { }

	// RVA: 0x1630B0C Offset: 0x162CB0C VA: 0x1630B0C
	public OneofAccessor get_Accessor() { }

	// RVA: 0x162F1C8 Offset: 0x162B1C8 VA: 0x162F1C8
	internal void CrossLink() { }

	// RVA: 0x16308A4 Offset: 0x162C8A4 VA: 0x16308A4
	private OneofAccessor CreateAccessor(string clrName) { }
}

// Namespace: Google.Protobuf.Reflection
[Usage(256)]
public class OriginalNameAttribute : Attribute // TypeDefIndex: 6542
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <PreferredAlias>k__BackingField; // 0x18

	// Properties
	public string Name { get; set; }
	public bool PreferredAlias { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1630B68 Offset: 0x162CB68 VA: 0x1630B68
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x1630B70 Offset: 0x162CB70 VA: 0x1630B70
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x1630B78 Offset: 0x162CB78 VA: 0x1630B78
	public bool get_PreferredAlias() { }

	[CompilerGenerated]
	// RVA: 0x1630B80 Offset: 0x162CB80 VA: 0x1630B80
	public void set_PreferredAlias(bool value) { }

	// RVA: 0x1630B88 Offset: 0x162CB88 VA: 0x1630B88
	public void .ctor(string name) { }
}

// Namespace: Google.Protobuf.Reflection
internal sealed class PackageDescriptor : IDescriptor // TypeDefIndex: 6543
{
	// Fields
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <FullName>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly FileDescriptor <File>k__BackingField; // 0x20

	// Properties
	public string Name { get; }
	public string FullName { get; }
	public FileDescriptor File { get; }

	// Methods

	// RVA: 0x16252C0 Offset: 0x16212C0 VA: 0x16252C0
	internal void .ctor(string name, string fullName, FileDescriptor file) { }

	[CompilerGenerated]
	// RVA: 0x1630C1C Offset: 0x162CC1C VA: 0x1630C1C Slot: 4
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x1630C24 Offset: 0x162CC24 VA: 0x1630C24 Slot: 5
	public string get_FullName() { }

	[CompilerGenerated]
	// RVA: 0x1630C2C Offset: 0x162CC2C VA: 0x1630C2C Slot: 6
	public FileDescriptor get_File() { }
}

// Namespace: 
private interface ReflectionUtil.IReflectionHelper // TypeDefIndex: 6544
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Action<IMessage> CreateActionIMessage(MethodInfo method);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract Action<IMessage, object> CreateActionIMessageObject(MethodInfo method);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method);
}

// Namespace: 
internal interface ReflectionUtil.IExtensionReflectionHelper // TypeDefIndex: 6545
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object GetExtension(IMessage message);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetExtension(IMessage message, object value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool HasExtension(IMessage message);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ClearExtension(IMessage message);
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<T1, T2> // TypeDefIndex: 6546
{
	// Fields
	public Func<T1, int> del; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1154DB4 Offset: 0x1150DB4 VA: 0x1154DB4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Nullable<bool>>..ctor
	|
	|-RVA: 0x1154E38 Offset: 0x1150E38 VA: 0x1154E38
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Nullable<double>>..ctor
	|
	|-RVA: 0x1154EBC Offset: 0x1150EBC VA: 0x1154EBC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Nullable<int>>..ctor
	|
	|-RVA: 0x1154F40 Offset: 0x1150F40 VA: 0x1154F40
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Nullable<long>>..ctor
	|
	|-RVA: 0x1154FC4 Offset: 0x1150FC4 VA: 0x1154FC4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Nullable<float>>..ctor
	|
	|-RVA: 0x1155048 Offset: 0x1151048 VA: 0x1155048
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Nullable<uint>>..ctor
	|
	|-RVA: 0x11550CC Offset: 0x11510CC VA: 0x11550CC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Nullable<ulong>>..ctor
	|
	|-RVA: 0x1155150 Offset: 0x1151150 VA: 0x1155150
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, bool>..ctor
	|
	|-RVA: 0x11551D4 Offset: 0x11511D4 VA: 0x11551D4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, double>..ctor
	|
	|-RVA: 0x1155258 Offset: 0x1151258 VA: 0x1155258
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, int>..ctor
	|
	|-RVA: 0x11552DC Offset: 0x11512DC VA: 0x11552DC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Int32Enum>..ctor
	|
	|-RVA: 0x1155360 Offset: 0x1151360 VA: 0x1155360
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, long>..ctor
	|
	|-RVA: 0x11553E4 Offset: 0x11513E4 VA: 0x11553E4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, object>..ctor
	|
	|-RVA: 0x1155468 Offset: 0x1151468 VA: 0x1155468
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, float>..ctor
	|
	|-RVA: 0x11554EC Offset: 0x11514EC VA: 0x11554EC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, uint>..ctor
	|
	|-RVA: 0x1155570 Offset: 0x1151570 VA: 0x1155570
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, ulong>..ctor
	|
	|-RVA: 0x11555F4 Offset: 0x11515F4 VA: 0x11555F4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int <CreateFuncIMessageInt32>b__0(IMessage message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1154DBC Offset: 0x1150DBC VA: 0x1154DBC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Nullable<bool>>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x1154E40 Offset: 0x1150E40 VA: 0x1154E40
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Nullable<double>>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x1154EC4 Offset: 0x1150EC4 VA: 0x1154EC4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Nullable<int>>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x1154F48 Offset: 0x1150F48 VA: 0x1154F48
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Nullable<long>>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x1154FCC Offset: 0x1150FCC VA: 0x1154FCC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Nullable<float>>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x1155050 Offset: 0x1151050 VA: 0x1155050
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Nullable<uint>>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x11550D4 Offset: 0x11510D4 VA: 0x11550D4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Nullable<ulong>>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x1155158 Offset: 0x1151158 VA: 0x1155158
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, bool>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x11551DC Offset: 0x11511DC VA: 0x11551DC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, double>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x1155260 Offset: 0x1151260 VA: 0x1155260
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, int>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x11552E4 Offset: 0x11512E4 VA: 0x11552E4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, Int32Enum>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x1155368 Offset: 0x1151368 VA: 0x1155368
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, long>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x11553EC Offset: 0x11513EC VA: 0x11553EC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, object>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x1155470 Offset: 0x1151470 VA: 0x1155470
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, float>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x11554F4 Offset: 0x11514F4 VA: 0x11554F4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, uint>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x1155578 Offset: 0x1151578 VA: 0x1155578
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<object, ulong>.<CreateFuncIMessageInt32>b__0
	|
	|-RVA: 0x11555FC Offset: 0x11515FC VA: 0x11555FC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateFuncIMessageInt32>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<T1, T2> // TypeDefIndex: 6547
{
	// Fields
	public Func<T1, T2> del; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11556F4 Offset: 0x11516F4 VA: 0x11556F4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Nullable<bool>>..ctor
	|
	|-RVA: 0x11557D4 Offset: 0x11517D4 VA: 0x11557D4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Nullable<double>>..ctor
	|
	|-RVA: 0x11558B8 Offset: 0x11518B8 VA: 0x11558B8
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Nullable<int>>..ctor
	|
	|-RVA: 0x1155994 Offset: 0x1151994 VA: 0x1155994
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Nullable<long>>..ctor
	|
	|-RVA: 0x1155A78 Offset: 0x1151A78 VA: 0x1155A78
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Nullable<float>>..ctor
	|
	|-RVA: 0x1155B54 Offset: 0x1151B54 VA: 0x1155B54
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Nullable<uint>>..ctor
	|
	|-RVA: 0x1155C30 Offset: 0x1151C30 VA: 0x1155C30
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Nullable<ulong>>..ctor
	|
	|-RVA: 0x1155D14 Offset: 0x1151D14 VA: 0x1155D14
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, bool>..ctor
	|
	|-RVA: 0x1155DF4 Offset: 0x1151DF4 VA: 0x1155DF4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, double>..ctor
	|
	|-RVA: 0x1155ED0 Offset: 0x1151ED0 VA: 0x1155ED0
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, int>..ctor
	|
	|-RVA: 0x1155FB0 Offset: 0x1151FB0 VA: 0x1155FB0
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Int32Enum>..ctor
	|
	|-RVA: 0x1156090 Offset: 0x1152090 VA: 0x1156090
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, long>..ctor
	|
	|-RVA: 0x115616C Offset: 0x115216C VA: 0x115616C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, object>..ctor
	|
	|-RVA: 0x1156224 Offset: 0x1152224 VA: 0x1156224
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, float>..ctor
	|
	|-RVA: 0x1156300 Offset: 0x1152300 VA: 0x1156300
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, uint>..ctor
	|
	|-RVA: 0x11563E0 Offset: 0x11523E0 VA: 0x11563E0
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, ulong>..ctor
	|
	|-RVA: 0x11564BC Offset: 0x11524BC VA: 0x11564BC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal int <CreateFuncIMessageInt32>b__1(IMessage message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11556FC Offset: 0x11516FC VA: 0x11556FC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Nullable<bool>>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x11557DC Offset: 0x11517DC VA: 0x11557DC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Nullable<double>>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x11558C0 Offset: 0x11518C0 VA: 0x11558C0
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Nullable<int>>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x115599C Offset: 0x115199C VA: 0x115599C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Nullable<long>>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x1155A80 Offset: 0x1151A80 VA: 0x1155A80
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Nullable<float>>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x1155B5C Offset: 0x1151B5C VA: 0x1155B5C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Nullable<uint>>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x1155C38 Offset: 0x1151C38 VA: 0x1155C38
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Nullable<ulong>>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x1155D1C Offset: 0x1151D1C VA: 0x1155D1C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, bool>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x1155DFC Offset: 0x1151DFC VA: 0x1155DFC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, double>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x1155ED8 Offset: 0x1151ED8 VA: 0x1155ED8
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, int>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x1155FB8 Offset: 0x1151FB8 VA: 0x1155FB8
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, Int32Enum>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x1156098 Offset: 0x1152098 VA: 0x1156098
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, long>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x1156174 Offset: 0x1152174 VA: 0x1156174
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, object>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x115622C Offset: 0x115222C VA: 0x115622C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, float>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x1156308 Offset: 0x1152308 VA: 0x1156308
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, uint>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x11563E8 Offset: 0x11523E8 VA: 0x11563E8
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<object, ulong>.<CreateFuncIMessageInt32>b__1
	|
	|-RVA: 0x11564C4 Offset: 0x11524C4 VA: 0x11564C4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass0_1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateFuncIMessageInt32>b__1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<T1, T2> // TypeDefIndex: 6548
{
	// Fields
	public Action<T1> del; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1156BEC Offset: 0x1152BEC VA: 0x1156BEC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Nullable<bool>>..ctor
	|
	|-RVA: 0x1156C70 Offset: 0x1152C70 VA: 0x1156C70
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Nullable<double>>..ctor
	|
	|-RVA: 0x1156CF4 Offset: 0x1152CF4 VA: 0x1156CF4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Nullable<int>>..ctor
	|
	|-RVA: 0x1156D78 Offset: 0x1152D78 VA: 0x1156D78
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Nullable<long>>..ctor
	|
	|-RVA: 0x1156DFC Offset: 0x1152DFC VA: 0x1156DFC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Nullable<float>>..ctor
	|
	|-RVA: 0x1156E80 Offset: 0x1152E80 VA: 0x1156E80
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Nullable<uint>>..ctor
	|
	|-RVA: 0x1156F04 Offset: 0x1152F04 VA: 0x1156F04
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Nullable<ulong>>..ctor
	|
	|-RVA: 0x1156F88 Offset: 0x1152F88 VA: 0x1156F88
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, bool>..ctor
	|
	|-RVA: 0x115700C Offset: 0x115300C VA: 0x115700C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, double>..ctor
	|
	|-RVA: 0x1157090 Offset: 0x1153090 VA: 0x1157090
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, int>..ctor
	|
	|-RVA: 0x1157114 Offset: 0x1153114 VA: 0x1157114
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Int32Enum>..ctor
	|
	|-RVA: 0x1157198 Offset: 0x1153198 VA: 0x1157198
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, long>..ctor
	|
	|-RVA: 0x115721C Offset: 0x115321C VA: 0x115721C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, object>..ctor
	|
	|-RVA: 0x11572A0 Offset: 0x11532A0 VA: 0x11572A0
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, float>..ctor
	|
	|-RVA: 0x1157324 Offset: 0x1153324 VA: 0x1157324
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, uint>..ctor
	|
	|-RVA: 0x11573A8 Offset: 0x11533A8 VA: 0x11573A8
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, ulong>..ctor
	|
	|-RVA: 0x115742C Offset: 0x115342C VA: 0x115742C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateActionIMessage>b__0(IMessage message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1156BF4 Offset: 0x1152BF4 VA: 0x1156BF4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Nullable<bool>>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x1156C78 Offset: 0x1152C78 VA: 0x1156C78
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Nullable<double>>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x1156CFC Offset: 0x1152CFC VA: 0x1156CFC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Nullable<int>>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x1156D80 Offset: 0x1152D80 VA: 0x1156D80
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Nullable<long>>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x1156E04 Offset: 0x1152E04 VA: 0x1156E04
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Nullable<float>>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x1156E88 Offset: 0x1152E88 VA: 0x1156E88
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Nullable<uint>>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x1156F0C Offset: 0x1152F0C VA: 0x1156F0C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Nullable<ulong>>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x1156F90 Offset: 0x1152F90 VA: 0x1156F90
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, bool>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x1157014 Offset: 0x1153014 VA: 0x1157014
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, double>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x1157098 Offset: 0x1153098 VA: 0x1157098
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, int>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x115711C Offset: 0x115311C VA: 0x115711C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, Int32Enum>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x11571A0 Offset: 0x11531A0 VA: 0x11571A0
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, long>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x1157224 Offset: 0x1153224 VA: 0x1157224
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, object>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x11572A8 Offset: 0x11532A8 VA: 0x11572A8
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, float>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x115732C Offset: 0x115332C VA: 0x115732C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, uint>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x11573B0 Offset: 0x11533B0 VA: 0x11573B0
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<object, ulong>.<CreateActionIMessage>b__0
	|
	|-RVA: 0x1157434 Offset: 0x1153434 VA: 0x1157434
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass1_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateActionIMessage>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<T1, T2> // TypeDefIndex: 6549
{
	// Fields
	public Func<T1, T2> del; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1157610 Offset: 0x1153610 VA: 0x1157610
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Nullable<bool>>..ctor
	|
	|-RVA: 0x11576C0 Offset: 0x11536C0 VA: 0x11576C0
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Nullable<double>>..ctor
	|
	|-RVA: 0x1157774 Offset: 0x1153774 VA: 0x1157774
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Nullable<int>>..ctor
	|
	|-RVA: 0x1157820 Offset: 0x1153820 VA: 0x1157820
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Nullable<long>>..ctor
	|
	|-RVA: 0x11578D4 Offset: 0x11538D4 VA: 0x11578D4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Nullable<float>>..ctor
	|
	|-RVA: 0x1157980 Offset: 0x1153980 VA: 0x1157980
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Nullable<uint>>..ctor
	|
	|-RVA: 0x1157A2C Offset: 0x1153A2C VA: 0x1157A2C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Nullable<ulong>>..ctor
	|
	|-RVA: 0x1157AE0 Offset: 0x1153AE0 VA: 0x1157AE0
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, bool>..ctor
	|
	|-RVA: 0x1157B90 Offset: 0x1153B90 VA: 0x1157B90
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, double>..ctor
	|
	|-RVA: 0x1157C3C Offset: 0x1153C3C VA: 0x1157C3C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, int>..ctor
	|
	|-RVA: 0x1157CEC Offset: 0x1153CEC VA: 0x1157CEC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Int32Enum>..ctor
	|
	|-RVA: 0x1157D9C Offset: 0x1153D9C VA: 0x1157D9C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, long>..ctor
	|
	|-RVA: 0x1157E48 Offset: 0x1153E48 VA: 0x1157E48
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, object>..ctor
	|
	|-RVA: 0x1157ECC Offset: 0x1153ECC VA: 0x1157ECC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, float>..ctor
	|
	|-RVA: 0x1157F78 Offset: 0x1153F78 VA: 0x1157F78
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, uint>..ctor
	|
	|-RVA: 0x1158028 Offset: 0x1154028 VA: 0x1158028
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, ulong>..ctor
	|
	|-RVA: 0x11580D4 Offset: 0x11540D4 VA: 0x11580D4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal object <CreateFuncIMessageObject>b__0(IMessage message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1157618 Offset: 0x1153618 VA: 0x1157618
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Nullable<bool>>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x11576C8 Offset: 0x11536C8 VA: 0x11576C8
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Nullable<double>>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x115777C Offset: 0x115377C VA: 0x115777C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Nullable<int>>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x1157828 Offset: 0x1153828 VA: 0x1157828
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Nullable<long>>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x11578DC Offset: 0x11538DC VA: 0x11578DC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Nullable<float>>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x1157988 Offset: 0x1153988 VA: 0x1157988
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Nullable<uint>>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x1157A34 Offset: 0x1153A34 VA: 0x1157A34
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Nullable<ulong>>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x1157AE8 Offset: 0x1153AE8 VA: 0x1157AE8
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, bool>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x1157B98 Offset: 0x1153B98 VA: 0x1157B98
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, double>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x1157C44 Offset: 0x1153C44 VA: 0x1157C44
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, int>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x1157CF4 Offset: 0x1153CF4 VA: 0x1157CF4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, Int32Enum>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x1157DA4 Offset: 0x1153DA4 VA: 0x1157DA4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, long>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x1157E50 Offset: 0x1153E50 VA: 0x1157E50
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, object>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x1157ED4 Offset: 0x1153ED4 VA: 0x1157ED4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, float>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x1157F80 Offset: 0x1153F80 VA: 0x1157F80
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, uint>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x1158030 Offset: 0x1154030 VA: 0x1158030
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<object, ulong>.<CreateFuncIMessageObject>b__0
	|
	|-RVA: 0x11580DC Offset: 0x11540DC VA: 0x11580DC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass2_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateFuncIMessageObject>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<T1, T2> // TypeDefIndex: 6550
{
	// Fields
	public Action<T1, T2> del; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115950C Offset: 0x115550C VA: 0x115950C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Nullable<bool>>..ctor
	|
	|-RVA: 0x1159600 Offset: 0x1155600 VA: 0x1159600
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Nullable<double>>..ctor
	|
	|-RVA: 0x1159744 Offset: 0x1155744 VA: 0x1159744
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Nullable<int>>..ctor
	|
	|-RVA: 0x1159888 Offset: 0x1155888 VA: 0x1159888
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Nullable<long>>..ctor
	|
	|-RVA: 0x11599CC Offset: 0x11559CC VA: 0x11599CC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Nullable<float>>..ctor
	|
	|-RVA: 0x1159B10 Offset: 0x1155B10 VA: 0x1159B10
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Nullable<uint>>..ctor
	|
	|-RVA: 0x1159C54 Offset: 0x1155C54 VA: 0x1159C54
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Nullable<ulong>>..ctor
	|
	|-RVA: 0x1159D98 Offset: 0x1155D98 VA: 0x1159D98
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, bool>..ctor
	|
	|-RVA: 0x1159E88 Offset: 0x1155E88 VA: 0x1159E88
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, double>..ctor
	|
	|-RVA: 0x1159F78 Offset: 0x1155F78 VA: 0x1159F78
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, int>..ctor
	|
	|-RVA: 0x115A068 Offset: 0x1156068 VA: 0x115A068
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Int32Enum>..ctor
	|
	|-RVA: 0x115A158 Offset: 0x1156158 VA: 0x115A158
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, long>..ctor
	|
	|-RVA: 0x115A248 Offset: 0x1156248 VA: 0x115A248
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, object>..ctor
	|
	|-RVA: 0x115A334 Offset: 0x1156334 VA: 0x115A334
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, float>..ctor
	|
	|-RVA: 0x115A424 Offset: 0x1156424 VA: 0x115A424
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, uint>..ctor
	|
	|-RVA: 0x115A514 Offset: 0x1156514 VA: 0x115A514
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, ulong>..ctor
	|
	|-RVA: 0x115A604 Offset: 0x1156604 VA: 0x115A604
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <CreateActionIMessageObject>b__0(IMessage message, object arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1159514 Offset: 0x1155514 VA: 0x1159514
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Nullable<bool>>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x1159608 Offset: 0x1155608 VA: 0x1159608
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Nullable<double>>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x115974C Offset: 0x115574C VA: 0x115974C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Nullable<int>>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x1159890 Offset: 0x1155890 VA: 0x1159890
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Nullable<long>>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x11599D4 Offset: 0x11559D4 VA: 0x11599D4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Nullable<float>>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x1159B18 Offset: 0x1155B18 VA: 0x1159B18
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Nullable<uint>>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x1159C5C Offset: 0x1155C5C VA: 0x1159C5C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Nullable<ulong>>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x1159DA0 Offset: 0x1155DA0 VA: 0x1159DA0
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, bool>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x1159E90 Offset: 0x1155E90 VA: 0x1159E90
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, double>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x1159F80 Offset: 0x1155F80 VA: 0x1159F80
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, int>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x115A070 Offset: 0x1156070 VA: 0x115A070
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, Int32Enum>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x115A160 Offset: 0x1156160 VA: 0x115A160
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, long>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x115A250 Offset: 0x1156250 VA: 0x115A250
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, object>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x115A33C Offset: 0x115633C VA: 0x115A33C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, float>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x115A42C Offset: 0x115642C VA: 0x115A42C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, uint>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x115A51C Offset: 0x115651C VA: 0x115A51C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<object, ulong>.<CreateActionIMessageObject>b__0
	|
	|-RVA: 0x115A60C Offset: 0x115660C VA: 0x115A60C
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass3_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateActionIMessageObject>b__0
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<T1, T2> // TypeDefIndex: 6551
{
	// Fields
	public Func<T1, bool> del; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115A9A4 Offset: 0x11569A4 VA: 0x115A9A4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Nullable<bool>>..ctor
	|
	|-RVA: 0x115AA28 Offset: 0x1156A28 VA: 0x115AA28
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Nullable<double>>..ctor
	|
	|-RVA: 0x115AAAC Offset: 0x1156AAC VA: 0x115AAAC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Nullable<int>>..ctor
	|
	|-RVA: 0x115AB30 Offset: 0x1156B30 VA: 0x115AB30
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Nullable<long>>..ctor
	|
	|-RVA: 0x115ABB4 Offset: 0x1156BB4 VA: 0x115ABB4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Nullable<float>>..ctor
	|
	|-RVA: 0x115AC38 Offset: 0x1156C38 VA: 0x115AC38
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Nullable<uint>>..ctor
	|
	|-RVA: 0x115ACBC Offset: 0x1156CBC VA: 0x115ACBC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Nullable<ulong>>..ctor
	|
	|-RVA: 0x115AD40 Offset: 0x1156D40 VA: 0x115AD40
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, bool>..ctor
	|
	|-RVA: 0x115ADC4 Offset: 0x1156DC4 VA: 0x115ADC4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, double>..ctor
	|
	|-RVA: 0x115AE48 Offset: 0x1156E48 VA: 0x115AE48
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, int>..ctor
	|
	|-RVA: 0x115AECC Offset: 0x1156ECC VA: 0x115AECC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Int32Enum>..ctor
	|
	|-RVA: 0x115AF50 Offset: 0x1156F50 VA: 0x115AF50
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, long>..ctor
	|
	|-RVA: 0x115AFD4 Offset: 0x1156FD4 VA: 0x115AFD4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, object>..ctor
	|
	|-RVA: 0x115B058 Offset: 0x1157058 VA: 0x115B058
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, float>..ctor
	|
	|-RVA: 0x115B0DC Offset: 0x11570DC VA: 0x115B0DC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, uint>..ctor
	|
	|-RVA: 0x115B160 Offset: 0x1157160 VA: 0x115B160
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, ulong>..ctor
	|
	|-RVA: 0x115B1E4 Offset: 0x11571E4 VA: 0x115B1E4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <CreateFuncIMessageBool>b__0(IMessage message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115A9AC Offset: 0x11569AC VA: 0x115A9AC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Nullable<bool>>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115AA30 Offset: 0x1156A30 VA: 0x115AA30
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Nullable<double>>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115AAB4 Offset: 0x1156AB4 VA: 0x115AAB4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Nullable<int>>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115AB38 Offset: 0x1156B38 VA: 0x115AB38
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Nullable<long>>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115ABBC Offset: 0x1156BBC VA: 0x115ABBC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Nullable<float>>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115AC40 Offset: 0x1156C40 VA: 0x115AC40
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Nullable<uint>>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115ACC4 Offset: 0x1156CC4 VA: 0x115ACC4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Nullable<ulong>>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115AD48 Offset: 0x1156D48 VA: 0x115AD48
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, bool>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115ADCC Offset: 0x1156DCC VA: 0x115ADCC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, double>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115AE50 Offset: 0x1156E50 VA: 0x115AE50
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, int>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115AED4 Offset: 0x1156ED4 VA: 0x115AED4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, Int32Enum>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115AF58 Offset: 0x1156F58 VA: 0x115AF58
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, long>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115AFDC Offset: 0x1156FDC VA: 0x115AFDC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, object>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115B060 Offset: 0x1157060 VA: 0x115B060
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, float>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115B0E4 Offset: 0x11570E4 VA: 0x115B0E4
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, uint>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115B168 Offset: 0x1157168 VA: 0x115B168
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<object, ulong>.<CreateFuncIMessageBool>b__0
	|
	|-RVA: 0x115B1EC Offset: 0x11571EC VA: 0x115B1EC
	|-ReflectionUtil.ReflectionHelper.<>c__DisplayClass4_0<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.<CreateFuncIMessageBool>b__0
	*/
}

// Namespace: 
private sealed class ReflectionUtil.ReflectionHelper<T1, T2> : ReflectionUtil.IReflectionHelper // TypeDefIndex: 6552
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143DE64 Offset: 0x1439E64 VA: 0x143DE64
	|-ReflectionUtil.ReflectionHelper<object, Nullable<bool>>.CreateFuncIMessageInt32
	|
	|-RVA: 0x143E838 Offset: 0x143A838 VA: 0x143E838
	|-ReflectionUtil.ReflectionHelper<object, Nullable<double>>.CreateFuncIMessageInt32
	|
	|-RVA: 0x143F20C Offset: 0x143B20C VA: 0x143F20C
	|-ReflectionUtil.ReflectionHelper<object, Nullable<int>>.CreateFuncIMessageInt32
	|
	|-RVA: 0x143FBE0 Offset: 0x143BBE0 VA: 0x143FBE0
	|-ReflectionUtil.ReflectionHelper<object, Nullable<long>>.CreateFuncIMessageInt32
	|
	|-RVA: 0x14405B4 Offset: 0x143C5B4 VA: 0x14405B4
	|-ReflectionUtil.ReflectionHelper<object, Nullable<float>>.CreateFuncIMessageInt32
	|
	|-RVA: 0x1440F88 Offset: 0x143CF88 VA: 0x1440F88
	|-ReflectionUtil.ReflectionHelper<object, Nullable<uint>>.CreateFuncIMessageInt32
	|
	|-RVA: 0x144195C Offset: 0x143D95C VA: 0x144195C
	|-ReflectionUtil.ReflectionHelper<object, Nullable<ulong>>.CreateFuncIMessageInt32
	|
	|-RVA: 0x1442330 Offset: 0x143E330 VA: 0x1442330
	|-ReflectionUtil.ReflectionHelper<object, bool>.CreateFuncIMessageInt32
	|
	|-RVA: 0x1442D04 Offset: 0x143ED04 VA: 0x1442D04
	|-ReflectionUtil.ReflectionHelper<object, double>.CreateFuncIMessageInt32
	|
	|-RVA: 0x14436D8 Offset: 0x143F6D8 VA: 0x14436D8
	|-ReflectionUtil.ReflectionHelper<object, int>.CreateFuncIMessageInt32
	|
	|-RVA: 0x14440AC Offset: 0x14400AC VA: 0x14440AC
	|-ReflectionUtil.ReflectionHelper<object, Int32Enum>.CreateFuncIMessageInt32
	|
	|-RVA: 0x1444A80 Offset: 0x1440A80 VA: 0x1444A80
	|-ReflectionUtil.ReflectionHelper<object, long>.CreateFuncIMessageInt32
	|
	|-RVA: 0x1445454 Offset: 0x1441454 VA: 0x1445454
	|-ReflectionUtil.ReflectionHelper<object, object>.CreateFuncIMessageInt32
	|
	|-RVA: 0x1445E28 Offset: 0x1441E28 VA: 0x1445E28
	|-ReflectionUtil.ReflectionHelper<object, float>.CreateFuncIMessageInt32
	|
	|-RVA: 0x14467FC Offset: 0x14427FC VA: 0x14467FC
	|-ReflectionUtil.ReflectionHelper<object, uint>.CreateFuncIMessageInt32
	|
	|-RVA: 0x14471D0 Offset: 0x14431D0 VA: 0x14471D0
	|-ReflectionUtil.ReflectionHelper<object, ulong>.CreateFuncIMessageInt32
	|
	|-RVA: 0x1447BA4 Offset: 0x1443BA4 VA: 0x1447BA4
	|-ReflectionUtil.ReflectionHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateFuncIMessageInt32
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public Action<IMessage> CreateActionIMessage(MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143E1A0 Offset: 0x143A1A0 VA: 0x143E1A0
	|-ReflectionUtil.ReflectionHelper<object, Nullable<bool>>.CreateActionIMessage
	|
	|-RVA: 0x143EB74 Offset: 0x143AB74 VA: 0x143EB74
	|-ReflectionUtil.ReflectionHelper<object, Nullable<double>>.CreateActionIMessage
	|
	|-RVA: 0x143F548 Offset: 0x143B548 VA: 0x143F548
	|-ReflectionUtil.ReflectionHelper<object, Nullable<int>>.CreateActionIMessage
	|
	|-RVA: 0x143FF1C Offset: 0x143BF1C VA: 0x143FF1C
	|-ReflectionUtil.ReflectionHelper<object, Nullable<long>>.CreateActionIMessage
	|
	|-RVA: 0x14408F0 Offset: 0x143C8F0 VA: 0x14408F0
	|-ReflectionUtil.ReflectionHelper<object, Nullable<float>>.CreateActionIMessage
	|
	|-RVA: 0x14412C4 Offset: 0x143D2C4 VA: 0x14412C4
	|-ReflectionUtil.ReflectionHelper<object, Nullable<uint>>.CreateActionIMessage
	|
	|-RVA: 0x1441C98 Offset: 0x143DC98 VA: 0x1441C98
	|-ReflectionUtil.ReflectionHelper<object, Nullable<ulong>>.CreateActionIMessage
	|
	|-RVA: 0x144266C Offset: 0x143E66C VA: 0x144266C
	|-ReflectionUtil.ReflectionHelper<object, bool>.CreateActionIMessage
	|
	|-RVA: 0x1443040 Offset: 0x143F040 VA: 0x1443040
	|-ReflectionUtil.ReflectionHelper<object, double>.CreateActionIMessage
	|
	|-RVA: 0x1443A14 Offset: 0x143FA14 VA: 0x1443A14
	|-ReflectionUtil.ReflectionHelper<object, int>.CreateActionIMessage
	|
	|-RVA: 0x14443E8 Offset: 0x14403E8 VA: 0x14443E8
	|-ReflectionUtil.ReflectionHelper<object, Int32Enum>.CreateActionIMessage
	|
	|-RVA: 0x1444DBC Offset: 0x1440DBC VA: 0x1444DBC
	|-ReflectionUtil.ReflectionHelper<object, long>.CreateActionIMessage
	|
	|-RVA: 0x1445790 Offset: 0x1441790 VA: 0x1445790
	|-ReflectionUtil.ReflectionHelper<object, object>.CreateActionIMessage
	|
	|-RVA: 0x1446164 Offset: 0x1442164 VA: 0x1446164
	|-ReflectionUtil.ReflectionHelper<object, float>.CreateActionIMessage
	|
	|-RVA: 0x1446B38 Offset: 0x1442B38 VA: 0x1446B38
	|-ReflectionUtil.ReflectionHelper<object, uint>.CreateActionIMessage
	|
	|-RVA: 0x144750C Offset: 0x144350C VA: 0x144750C
	|-ReflectionUtil.ReflectionHelper<object, ulong>.CreateActionIMessage
	|
	|-RVA: 0x1447EE8 Offset: 0x1443EE8 VA: 0x1447EE8
	|-ReflectionUtil.ReflectionHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateActionIMessage
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143E344 Offset: 0x143A344 VA: 0x143E344
	|-ReflectionUtil.ReflectionHelper<object, Nullable<bool>>.CreateFuncIMessageObject
	|
	|-RVA: 0x143ED18 Offset: 0x143AD18 VA: 0x143ED18
	|-ReflectionUtil.ReflectionHelper<object, Nullable<double>>.CreateFuncIMessageObject
	|
	|-RVA: 0x143F6EC Offset: 0x143B6EC VA: 0x143F6EC
	|-ReflectionUtil.ReflectionHelper<object, Nullable<int>>.CreateFuncIMessageObject
	|
	|-RVA: 0x14400C0 Offset: 0x143C0C0 VA: 0x14400C0
	|-ReflectionUtil.ReflectionHelper<object, Nullable<long>>.CreateFuncIMessageObject
	|
	|-RVA: 0x1440A94 Offset: 0x143CA94 VA: 0x1440A94
	|-ReflectionUtil.ReflectionHelper<object, Nullable<float>>.CreateFuncIMessageObject
	|
	|-RVA: 0x1441468 Offset: 0x143D468 VA: 0x1441468
	|-ReflectionUtil.ReflectionHelper<object, Nullable<uint>>.CreateFuncIMessageObject
	|
	|-RVA: 0x1441E3C Offset: 0x143DE3C VA: 0x1441E3C
	|-ReflectionUtil.ReflectionHelper<object, Nullable<ulong>>.CreateFuncIMessageObject
	|
	|-RVA: 0x1442810 Offset: 0x143E810 VA: 0x1442810
	|-ReflectionUtil.ReflectionHelper<object, bool>.CreateFuncIMessageObject
	|
	|-RVA: 0x14431E4 Offset: 0x143F1E4 VA: 0x14431E4
	|-ReflectionUtil.ReflectionHelper<object, double>.CreateFuncIMessageObject
	|
	|-RVA: 0x1443BB8 Offset: 0x143FBB8 VA: 0x1443BB8
	|-ReflectionUtil.ReflectionHelper<object, int>.CreateFuncIMessageObject
	|
	|-RVA: 0x144458C Offset: 0x144058C VA: 0x144458C
	|-ReflectionUtil.ReflectionHelper<object, Int32Enum>.CreateFuncIMessageObject
	|
	|-RVA: 0x1444F60 Offset: 0x1440F60 VA: 0x1444F60
	|-ReflectionUtil.ReflectionHelper<object, long>.CreateFuncIMessageObject
	|
	|-RVA: 0x1445934 Offset: 0x1441934 VA: 0x1445934
	|-ReflectionUtil.ReflectionHelper<object, object>.CreateFuncIMessageObject
	|
	|-RVA: 0x1446308 Offset: 0x1442308 VA: 0x1446308
	|-ReflectionUtil.ReflectionHelper<object, float>.CreateFuncIMessageObject
	|
	|-RVA: 0x1446CDC Offset: 0x1442CDC VA: 0x1446CDC
	|-ReflectionUtil.ReflectionHelper<object, uint>.CreateFuncIMessageObject
	|
	|-RVA: 0x14476B0 Offset: 0x14436B0 VA: 0x14476B0
	|-ReflectionUtil.ReflectionHelper<object, ulong>.CreateFuncIMessageObject
	|
	|-RVA: 0x1448090 Offset: 0x1444090 VA: 0x1448090
	|-ReflectionUtil.ReflectionHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateFuncIMessageObject
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public Action<IMessage, object> CreateActionIMessageObject(MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143E4E8 Offset: 0x143A4E8 VA: 0x143E4E8
	|-ReflectionUtil.ReflectionHelper<object, Nullable<bool>>.CreateActionIMessageObject
	|
	|-RVA: 0x143EEBC Offset: 0x143AEBC VA: 0x143EEBC
	|-ReflectionUtil.ReflectionHelper<object, Nullable<double>>.CreateActionIMessageObject
	|
	|-RVA: 0x143F890 Offset: 0x143B890 VA: 0x143F890
	|-ReflectionUtil.ReflectionHelper<object, Nullable<int>>.CreateActionIMessageObject
	|
	|-RVA: 0x1440264 Offset: 0x143C264 VA: 0x1440264
	|-ReflectionUtil.ReflectionHelper<object, Nullable<long>>.CreateActionIMessageObject
	|
	|-RVA: 0x1440C38 Offset: 0x143CC38 VA: 0x1440C38
	|-ReflectionUtil.ReflectionHelper<object, Nullable<float>>.CreateActionIMessageObject
	|
	|-RVA: 0x144160C Offset: 0x143D60C VA: 0x144160C
	|-ReflectionUtil.ReflectionHelper<object, Nullable<uint>>.CreateActionIMessageObject
	|
	|-RVA: 0x1441FE0 Offset: 0x143DFE0 VA: 0x1441FE0
	|-ReflectionUtil.ReflectionHelper<object, Nullable<ulong>>.CreateActionIMessageObject
	|
	|-RVA: 0x14429B4 Offset: 0x143E9B4 VA: 0x14429B4
	|-ReflectionUtil.ReflectionHelper<object, bool>.CreateActionIMessageObject
	|
	|-RVA: 0x1443388 Offset: 0x143F388 VA: 0x1443388
	|-ReflectionUtil.ReflectionHelper<object, double>.CreateActionIMessageObject
	|
	|-RVA: 0x1443D5C Offset: 0x143FD5C VA: 0x1443D5C
	|-ReflectionUtil.ReflectionHelper<object, int>.CreateActionIMessageObject
	|
	|-RVA: 0x1444730 Offset: 0x1440730 VA: 0x1444730
	|-ReflectionUtil.ReflectionHelper<object, Int32Enum>.CreateActionIMessageObject
	|
	|-RVA: 0x1445104 Offset: 0x1441104 VA: 0x1445104
	|-ReflectionUtil.ReflectionHelper<object, long>.CreateActionIMessageObject
	|
	|-RVA: 0x1445AD8 Offset: 0x1441AD8 VA: 0x1445AD8
	|-ReflectionUtil.ReflectionHelper<object, object>.CreateActionIMessageObject
	|
	|-RVA: 0x14464AC Offset: 0x14424AC VA: 0x14464AC
	|-ReflectionUtil.ReflectionHelper<object, float>.CreateActionIMessageObject
	|
	|-RVA: 0x1446E80 Offset: 0x1442E80 VA: 0x1446E80
	|-ReflectionUtil.ReflectionHelper<object, uint>.CreateActionIMessageObject
	|
	|-RVA: 0x1447854 Offset: 0x1443854 VA: 0x1447854
	|-ReflectionUtil.ReflectionHelper<object, ulong>.CreateActionIMessageObject
	|
	|-RVA: 0x1448238 Offset: 0x1444238 VA: 0x1448238
	|-ReflectionUtil.ReflectionHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateActionIMessageObject
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143E68C Offset: 0x143A68C VA: 0x143E68C
	|-ReflectionUtil.ReflectionHelper<object, Nullable<bool>>.CreateFuncIMessageBool
	|
	|-RVA: 0x143F060 Offset: 0x143B060 VA: 0x143F060
	|-ReflectionUtil.ReflectionHelper<object, Nullable<double>>.CreateFuncIMessageBool
	|
	|-RVA: 0x143FA34 Offset: 0x143BA34 VA: 0x143FA34
	|-ReflectionUtil.ReflectionHelper<object, Nullable<int>>.CreateFuncIMessageBool
	|
	|-RVA: 0x1440408 Offset: 0x143C408 VA: 0x1440408
	|-ReflectionUtil.ReflectionHelper<object, Nullable<long>>.CreateFuncIMessageBool
	|
	|-RVA: 0x1440DDC Offset: 0x143CDDC VA: 0x1440DDC
	|-ReflectionUtil.ReflectionHelper<object, Nullable<float>>.CreateFuncIMessageBool
	|
	|-RVA: 0x14417B0 Offset: 0x143D7B0 VA: 0x14417B0
	|-ReflectionUtil.ReflectionHelper<object, Nullable<uint>>.CreateFuncIMessageBool
	|
	|-RVA: 0x1442184 Offset: 0x143E184 VA: 0x1442184
	|-ReflectionUtil.ReflectionHelper<object, Nullable<ulong>>.CreateFuncIMessageBool
	|
	|-RVA: 0x1442B58 Offset: 0x143EB58 VA: 0x1442B58
	|-ReflectionUtil.ReflectionHelper<object, bool>.CreateFuncIMessageBool
	|
	|-RVA: 0x144352C Offset: 0x143F52C VA: 0x144352C
	|-ReflectionUtil.ReflectionHelper<object, double>.CreateFuncIMessageBool
	|
	|-RVA: 0x1443F00 Offset: 0x143FF00 VA: 0x1443F00
	|-ReflectionUtil.ReflectionHelper<object, int>.CreateFuncIMessageBool
	|
	|-RVA: 0x14448D4 Offset: 0x14408D4 VA: 0x14448D4
	|-ReflectionUtil.ReflectionHelper<object, Int32Enum>.CreateFuncIMessageBool
	|
	|-RVA: 0x14452A8 Offset: 0x14412A8 VA: 0x14452A8
	|-ReflectionUtil.ReflectionHelper<object, long>.CreateFuncIMessageBool
	|
	|-RVA: 0x1445C7C Offset: 0x1441C7C VA: 0x1445C7C
	|-ReflectionUtil.ReflectionHelper<object, object>.CreateFuncIMessageBool
	|
	|-RVA: 0x1446650 Offset: 0x1442650 VA: 0x1446650
	|-ReflectionUtil.ReflectionHelper<object, float>.CreateFuncIMessageBool
	|
	|-RVA: 0x1447024 Offset: 0x1443024 VA: 0x1447024
	|-ReflectionUtil.ReflectionHelper<object, uint>.CreateFuncIMessageBool
	|
	|-RVA: 0x14479F8 Offset: 0x14439F8 VA: 0x14479F8
	|-ReflectionUtil.ReflectionHelper<object, ulong>.CreateFuncIMessageBool
	|
	|-RVA: 0x14483E0 Offset: 0x14443E0 VA: 0x14483E0
	|-ReflectionUtil.ReflectionHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateFuncIMessageBool
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x143E830 Offset: 0x143A830 VA: 0x143E830
	|-ReflectionUtil.ReflectionHelper<object, Nullable<bool>>..ctor
	|
	|-RVA: 0x143F204 Offset: 0x143B204 VA: 0x143F204
	|-ReflectionUtil.ReflectionHelper<object, Nullable<double>>..ctor
	|
	|-RVA: 0x143FBD8 Offset: 0x143BBD8 VA: 0x143FBD8
	|-ReflectionUtil.ReflectionHelper<object, Nullable<int>>..ctor
	|
	|-RVA: 0x14405AC Offset: 0x143C5AC VA: 0x14405AC
	|-ReflectionUtil.ReflectionHelper<object, Nullable<long>>..ctor
	|
	|-RVA: 0x1440F80 Offset: 0x143CF80 VA: 0x1440F80
	|-ReflectionUtil.ReflectionHelper<object, Nullable<float>>..ctor
	|
	|-RVA: 0x1441954 Offset: 0x143D954 VA: 0x1441954
	|-ReflectionUtil.ReflectionHelper<object, Nullable<uint>>..ctor
	|
	|-RVA: 0x1442328 Offset: 0x143E328 VA: 0x1442328
	|-ReflectionUtil.ReflectionHelper<object, Nullable<ulong>>..ctor
	|
	|-RVA: 0x1442CFC Offset: 0x143ECFC VA: 0x1442CFC
	|-ReflectionUtil.ReflectionHelper<object, bool>..ctor
	|
	|-RVA: 0x14436D0 Offset: 0x143F6D0 VA: 0x14436D0
	|-ReflectionUtil.ReflectionHelper<object, double>..ctor
	|
	|-RVA: 0x14440A4 Offset: 0x14400A4 VA: 0x14440A4
	|-ReflectionUtil.ReflectionHelper<object, int>..ctor
	|
	|-RVA: 0x1444A78 Offset: 0x1440A78 VA: 0x1444A78
	|-ReflectionUtil.ReflectionHelper<object, Int32Enum>..ctor
	|
	|-RVA: 0x144544C Offset: 0x144144C VA: 0x144544C
	|-ReflectionUtil.ReflectionHelper<object, long>..ctor
	|
	|-RVA: 0x1445E20 Offset: 0x1441E20 VA: 0x1445E20
	|-ReflectionUtil.ReflectionHelper<object, object>..ctor
	|
	|-RVA: 0x14467F4 Offset: 0x14427F4 VA: 0x14467F4
	|-ReflectionUtil.ReflectionHelper<object, float>..ctor
	|
	|-RVA: 0x14471C8 Offset: 0x14431C8 VA: 0x14471C8
	|-ReflectionUtil.ReflectionHelper<object, uint>..ctor
	|
	|-RVA: 0x1447B9C Offset: 0x1443B9C VA: 0x1447B9C
	|-ReflectionUtil.ReflectionHelper<object, ulong>..ctor
	|
	|-RVA: 0x1448588 Offset: 0x1444588 VA: 0x1448588
	|-ReflectionUtil.ReflectionHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private sealed class ReflectionUtil.ExtensionReflectionHelper<T1, T3> : ReflectionUtil.IExtensionReflectionHelper // TypeDefIndex: 6553
{
	// Fields
	private readonly Extension extension; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Extension extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12530DC Offset: 0x124F0DC VA: 0x12530DC
	|-ReflectionUtil.ExtensionReflectionHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public object GetExtension(IMessage message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125310C Offset: 0x124F10C VA: 0x125310C
	|-ReflectionUtil.ExtensionReflectionHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetExtension
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool HasExtension(IMessage message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1253460 Offset: 0x124F460 VA: 0x1253460
	|-ReflectionUtil.ExtensionReflectionHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.HasExtension
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void SetExtension(IMessage message, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1253728 Offset: 0x124F728 VA: 0x1253728
	|-ReflectionUtil.ExtensionReflectionHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.SetExtension
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void ClearExtension(IMessage message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1253A6C Offset: 0x124FA6C VA: 0x1253A6C
	|-ReflectionUtil.ExtensionReflectionHelper<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ClearExtension
	*/
}

// Namespace: 
public enum ReflectionUtil.SampleEnum // TypeDefIndex: 6554
{
	// Fields
	public int value__; // 0x0
	public const ReflectionUtil.SampleEnum X = 0;
}

// Namespace: Google.Protobuf.Reflection
internal static class ReflectionUtil // TypeDefIndex: 6555
{
	// Fields
	internal static readonly Type[] EmptyTypes; // 0x0
	[CompilerGenerated]
	private static readonly bool <CanConvertEnumFuncToInt32Func>k__BackingField; // 0x8

	// Properties
	private static bool CanConvertEnumFuncToInt32Func { get; }

	// Methods

	// RVA: 0x1630C34 Offset: 0x162CC34 VA: 0x1630C34
	private static void .cctor() { }

	// RVA: -1 Offset: -1
	internal static void ForceInitialize<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1140B00 Offset: 0x113CB00 VA: 0x1140B00
	|-ReflectionUtil.ForceInitialize<Nullable<bool>>
	|
	|-RVA: 0x1140B44 Offset: 0x113CB44 VA: 0x1140B44
	|-ReflectionUtil.ForceInitialize<Nullable<double>>
	|
	|-RVA: 0x1140B88 Offset: 0x113CB88 VA: 0x1140B88
	|-ReflectionUtil.ForceInitialize<Nullable<int>>
	|
	|-RVA: 0x1140BCC Offset: 0x113CBCC VA: 0x1140BCC
	|-ReflectionUtil.ForceInitialize<Nullable<long>>
	|
	|-RVA: 0x1140C10 Offset: 0x113CC10 VA: 0x1140C10
	|-ReflectionUtil.ForceInitialize<Nullable<float>>
	|
	|-RVA: 0x1140C54 Offset: 0x113CC54 VA: 0x1140C54
	|-ReflectionUtil.ForceInitialize<Nullable<uint>>
	|
	|-RVA: 0x1140C98 Offset: 0x113CC98 VA: 0x1140C98
	|-ReflectionUtil.ForceInitialize<Nullable<ulong>>
	|
	|-RVA: 0x1140CDC Offset: 0x113CCDC VA: 0x1140CDC
	|-ReflectionUtil.ForceInitialize<bool>
	|
	|-RVA: 0x1140D20 Offset: 0x113CD20 VA: 0x1140D20
	|-ReflectionUtil.ForceInitialize<double>
	|
	|-RVA: 0x1140D64 Offset: 0x113CD64 VA: 0x1140D64
	|-ReflectionUtil.ForceInitialize<int>
	|
	|-RVA: 0x1140DA8 Offset: 0x113CDA8 VA: 0x1140DA8
	|-ReflectionUtil.ForceInitialize<Int32Enum>
	|
	|-RVA: 0x1140DEC Offset: 0x113CDEC VA: 0x1140DEC
	|-ReflectionUtil.ForceInitialize<long>
	|
	|-RVA: 0x1140E30 Offset: 0x113CE30 VA: 0x1140E30
	|-ReflectionUtil.ForceInitialize<object>
	|
	|-RVA: 0x1140E74 Offset: 0x113CE74 VA: 0x1140E74
	|-ReflectionUtil.ForceInitialize<float>
	|
	|-RVA: 0x1140EB8 Offset: 0x113CEB8 VA: 0x1140EB8
	|-ReflectionUtil.ForceInitialize<uint>
	|
	|-RVA: 0x1140EFC Offset: 0x113CEFC VA: 0x1140EFC
	|-ReflectionUtil.ForceInitialize<ulong>
	|
	|-RVA: 0x1140F40 Offset: 0x113CF40 VA: 0x1140F40
	|-ReflectionUtil.ForceInitialize<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1629784 Offset: 0x1625784 VA: 0x1629784
	internal static Func<IMessage, object> CreateFuncIMessageObject(MethodInfo method) { }

	// RVA: 0x163019C Offset: 0x162C19C VA: 0x163019C
	internal static Func<IMessage, int> CreateFuncIMessageInt32(MethodInfo method) { }

	// RVA: 0x1631174 Offset: 0x162D174 VA: 0x1631174
	internal static Action<IMessage, object> CreateActionIMessageObject(MethodInfo method) { }

	// RVA: 0x16302A4 Offset: 0x162C2A4 VA: 0x16302A4
	internal static Action<IMessage> CreateActionIMessage(MethodInfo method) { }

	// RVA: 0x16312A4 Offset: 0x162D2A4 VA: 0x16312A4
	internal static Func<IMessage, bool> CreateFuncIMessageBool(MethodInfo method) { }

	[UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Type parameter members are preserved with DynamicallyAccessedMembers on GeneratedClrTypeInfo.ctor clrType parameter.")]
	[UnconditionalSuppressMessage("AOT", "IL3050", Justification = "Dynamic code won't call Type.MakeGenericType.")]
	// RVA: 0x1626F58 Offset: 0x1622F58 VA: 0x1626F58
	internal static ReflectionUtil.IExtensionReflectionHelper CreateExtensionHelper(Extension extension) { }

	[UnconditionalSuppressMessage("Trimming", "IL2026", Justification = "Type parameter members are preserved with DynamicallyAccessedMembers on GeneratedClrTypeInfo.ctor clrType parameter.")]
	[UnconditionalSuppressMessage("AOT", "IL3050", Justification = "Dynamic code won't call Type.MakeGenericType.")]
	// RVA: 0x1630FFC Offset: 0x162CFFC VA: 0x1630FFC
	private static ReflectionUtil.IReflectionHelper GetReflectionHelper(Type t1, Type t2) { }

	[CompilerGenerated]
	// RVA: 0x16313B0 Offset: 0x162D3B0 VA: 0x16313B0
	private static bool get_CanConvertEnumFuncToInt32Func() { }

	// RVA: 0x1630E9C Offset: 0x162CE9C VA: 0x1630E9C
	private static bool CheckCanConvertEnumFuncToInt32Func() { }

	// RVA: 0x1630FF4 Offset: 0x162CFF4 VA: 0x1630FF4
	public static ReflectionUtil.SampleEnum SampleEnumMethod() { }
}

// Namespace: Google.Protobuf.Reflection
internal sealed class RepeatedFieldAccessor : FieldAccessorBase // TypeDefIndex: 6556
{
	// Methods

	// RVA: 0x162A6A0 Offset: 0x16266A0 VA: 0x162A6A0
	internal void .ctor(PropertyInfo property, FieldDescriptor descriptor) { }

	// RVA: 0x1631408 Offset: 0x162D408 VA: 0x1631408 Slot: 10
	public override void Clear(IMessage message) { }

	// RVA: 0x163150C Offset: 0x162D50C VA: 0x163150C Slot: 9
	public override bool HasValue(IMessage message) { }

	// RVA: 0x1631558 Offset: 0x162D558 VA: 0x1631558 Slot: 11
	public override void SetValue(IMessage message, object value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ServiceDescriptor.<>c__DisplayClass0_0 // TypeDefIndex: 6557
{
	// Fields
	public FileDescriptor file; // 0x10
	public ServiceDescriptor <>4__this; // 0x18

	// Methods

	// RVA: 0x16315A4 Offset: 0x162D5A4 VA: 0x16315A4
	public void .ctor() { }

	// RVA: 0x163164C Offset: 0x162D64C VA: 0x163164C
	internal MethodDescriptor <.ctor>b__0(MethodDescriptorProto method, int i) { }
}

// Namespace: Google.Protobuf.Reflection
public sealed class ServiceDescriptor : DescriptorBase // TypeDefIndex: 6558
{
	// Fields
	[CompilerGenerated]
	private readonly ServiceDescriptorProto <Proto>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly IList<MethodDescriptor> <Methods>k__BackingField; // 0x38

	// Properties
	public override string Name { get; }
	internal ServiceDescriptorProto Proto { get; }
	public IList<MethodDescriptor> Methods { get; }

	// Methods

	// RVA: 0x162E218 Offset: 0x162A218 VA: 0x162E218
	internal void .ctor(ServiceDescriptorProto proto, FileDescriptor file, int index) { }

	// RVA: 0x16315AC Offset: 0x162D5AC VA: 0x16315AC Slot: 7
	public override string get_Name() { }

	// RVA: 0x16315C4 Offset: 0x162D5C4 VA: 0x16315C4 Slot: 8
	internal override IReadOnlyList<DescriptorBase> GetNestedDescriptorListForField(int fieldNumber) { }

	[CompilerGenerated]
	// RVA: 0x163163C Offset: 0x162D63C VA: 0x163163C
	internal ServiceDescriptorProto get_Proto() { }

	[CompilerGenerated]
	// RVA: 0x1631644 Offset: 0x162D644 VA: 0x1631644
	public IList<MethodDescriptor> get_Methods() { }

	// RVA: 0x162C6D4 Offset: 0x16286D4 VA: 0x162C6D4
	internal void CrossLink() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SingleFieldAccessor.<>c // TypeDefIndex: 6559
{
	// Fields
	public static readonly SingleFieldAccessor.<>c <>9; // 0x0
	public static Func<IMessage, bool> <>9__3_4; // 0x8

	// Methods

	// RVA: 0x16318DC Offset: 0x162D8DC VA: 0x16318DC
	private static void .cctor() { }

	// RVA: 0x1631944 Offset: 0x162D944 VA: 0x1631944
	public void .ctor() { }

	// RVA: 0x163194C Offset: 0x162D94C VA: 0x163194C
	internal bool <.ctor>b__3_4(IMessage message) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SingleFieldAccessor.<>c__DisplayClass3_0 // TypeDefIndex: 6560
{
	// Fields
	public SingleFieldAccessor <>4__this; // 0x10
	public FieldDescriptor descriptor; // 0x18

	// Methods

	// RVA: 0x16316C4 Offset: 0x162D6C4 VA: 0x16316C4
	public void .ctor() { }

	// RVA: 0x1631998 Offset: 0x162D998 VA: 0x1631998
	internal bool <.ctor>b__0(IMessage message) { }

	// RVA: 0x16319D0 Offset: 0x162D9D0 VA: 0x16319D0
	internal void <.ctor>b__1(IMessage message) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SingleFieldAccessor.<>c__DisplayClass3_1 // TypeDefIndex: 6561
{
	// Fields
	public OneofAccessor oneofAccessor; // 0x10
	public SingleFieldAccessor.<>c__DisplayClass3_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0x16316CC Offset: 0x162D6CC VA: 0x16316CC
	public void .ctor() { }

	// RVA: 0x16319F0 Offset: 0x162D9F0 VA: 0x16319F0
	internal bool <.ctor>b__2(IMessage message) { }

	// RVA: 0x1631A24 Offset: 0x162DA24 VA: 0x1631A24
	internal void <.ctor>b__3(IMessage message) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SingleFieldAccessor.<>c__DisplayClass3_2 // TypeDefIndex: 6562
{
	// Fields
	public object defaultValue; // 0x10
	public SingleFieldAccessor.<>c__DisplayClass3_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0x16316D4 Offset: 0x162D6D4 VA: 0x16316D4
	public void .ctor() { }

	// RVA: 0x1631A90 Offset: 0x162DA90 VA: 0x1631A90
	internal void <.ctor>b__5(IMessage message) { }
}

// Namespace: Google.Protobuf.Reflection
internal sealed class SingleFieldAccessor : FieldAccessorBase // TypeDefIndex: 6563
{
	// Fields
	private readonly Action<IMessage, object> setValueDelegate; // 0x20
	private readonly Action<IMessage> clearDelegate; // 0x28
	private readonly Func<IMessage, bool> hasDelegate; // 0x30

	// Methods

	// RVA: 0x162A0F8 Offset: 0x16260F8 VA: 0x162A0F8
	internal void .ctor(Type messageType, PropertyInfo property, FieldDescriptor descriptor) { }

	// RVA: 0x16316DC Offset: 0x162D6DC VA: 0x16316DC
	private static object GetDefaultValue(FieldDescriptor descriptor) { }

	// RVA: 0x163187C Offset: 0x162D87C VA: 0x163187C Slot: 10
	public override void Clear(IMessage message) { }

	// RVA: 0x163189C Offset: 0x162D89C VA: 0x163189C Slot: 9
	public override bool HasValue(IMessage message) { }

	// RVA: 0x16318BC Offset: 0x162D8BC VA: 0x16318BC Slot: 11
	public override void SetValue(IMessage message, object value) { }
}

// Namespace: 
private sealed class TypeRegistry.TypeRegistryDebugView // TypeDefIndex: 6564
{}

// Namespace: Google.Protobuf.Reflection
[DebuggerDisplay("Count = {fullNameToMessageMap.Count}")]
[DebuggerTypeProxy(typeof(TypeRegistry.TypeRegistryDebugView))]
public sealed class TypeRegistry // TypeDefIndex: 6565
{
	// Fields
	[CompilerGenerated]
	private static readonly TypeRegistry <Empty>k__BackingField; // 0x0
	private readonly Dictionary<string, MessageDescriptor> fullNameToMessageMap; // 0x10

	// Properties
	public static TypeRegistry Empty { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1631AC0 Offset: 0x162DAC0 VA: 0x1631AC0
	public static TypeRegistry get_Empty() { }

	// RVA: 0x1631B18 Offset: 0x162DB18 VA: 0x1631B18
	private void .ctor(Dictionary<string, MessageDescriptor> fullNameToMessageMap) { }

	// RVA: 0x1631B48 Offset: 0x162DB48 VA: 0x1631B48
	public MessageDescriptor Find(string fullName) { }

	// RVA: 0x1631BB8 Offset: 0x162DBB8 VA: 0x1631BB8
	private static void .cctor() { }
}
