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

// Namespace: Google.Protobuf
[DefaultMember("Item")]
[DebuggerDisplay("Length = {Length}")]
[DebuggerTypeProxy(typeof(ByteString.ByteStringDebugView))]
public sealed class ByteString : IEnumerable<byte>, IEnumerable, IEquatable<ByteString> // TypeDefIndex: 6294
{
	// Fields
	private static readonly ByteString empty; // 0x0
	private readonly ReadOnlyMemory<byte> bytes; // 0x10

	// Properties
	public static ByteString Empty { get; }
	public int Length { get; }
	public ReadOnlySpan<byte> Span { get; }

	// Methods

	// RVA: 0x15CD8F4 Offset: 0x15C98F4 VA: 0x15CD8F4
	internal static ByteString AttachBytes(ReadOnlyMemory<byte> bytes) { }

	// RVA: 0x15CD9A4 Offset: 0x15C99A4 VA: 0x15CD9A4
	internal static ByteString AttachBytes(byte[] bytes) { }

	// RVA: 0x15CD96C Offset: 0x15C996C VA: 0x15CD96C
	private void .ctor(ReadOnlyMemory<byte> bytes) { }

	// RVA: 0x15CDA48 Offset: 0x15C9A48 VA: 0x15CDA48
	public static ByteString get_Empty() { }

	// RVA: 0x15CDAA0 Offset: 0x15C9AA0 VA: 0x15CDAA0
	public int get_Length() { }

	// RVA: 0x15CDAE8 Offset: 0x15C9AE8 VA: 0x15CDAE8
	public ReadOnlySpan<byte> get_Span() { }

	// RVA: 0x15CDB30 Offset: 0x15C9B30 VA: 0x15CDB30
	public string ToBase64() { }

	// RVA: 0x15CDC60 Offset: 0x15C9C60 VA: 0x15CDC60
	public static ByteString CopyFrom(byte[] bytes) { }

	// RVA: 0x15CDD3C Offset: 0x15C9D3C VA: 0x15CDD3C Slot: 4
	public IEnumerator<byte> GetEnumerator() { }

	// RVA: 0x15CDDFC Offset: 0x15C9DFC VA: 0x15CDDFC Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15CDE00 Offset: 0x15C9E00 VA: 0x15CDE00
	public CodedInputStream CreateCodedInput() { }

	// RVA: 0x15CE148 Offset: 0x15CA148 VA: 0x15CE148
	public static bool op_Equality(ByteString lhs, ByteString rhs) { }

	// RVA: 0x15CE1FC Offset: 0x15CA1FC VA: 0x15CE1FC
	public static bool op_Inequality(ByteString lhs, ByteString rhs) { }

	// RVA: 0x15CE26C Offset: 0x15CA26C VA: 0x15CE26C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15CE2EC Offset: 0x15CA2EC VA: 0x15CE2EC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15CE374 Offset: 0x15CA374 VA: 0x15CE374 Slot: 6
	public bool Equals(ByteString other) { }

	// RVA: 0x15CE3D8 Offset: 0x15CA3D8 VA: 0x15CE3D8
	private static void .cctor() { }
}

// Namespace: Google.Protobuf
public sealed class CodedInputStream : IDisposable // TypeDefIndex: 6295
{
	// Fields
	private readonly bool leaveOpen; // 0x10
	private readonly byte[] buffer; // 0x18
	private readonly Stream input; // 0x20
	private ParserInternalState state; // 0x28

	// Properties
	internal bool DiscardUnknownFields { set; }
	internal ExtensionRegistry ExtensionRegistry { set; }
	internal byte[] InternalBuffer { get; }
	internal Stream InternalInputStream { get; }
	internal ParserInternalState InternalState { get; }

	// Methods

	// RVA: 0x15CE0B8 Offset: 0x15CA0B8 VA: 0x15CE0B8
	public void .ctor(byte[] buffer) { }

	// RVA: 0x15CDF68 Offset: 0x15C9F68 VA: 0x15CDF68
	public void .ctor(byte[] buffer, int offset, int length) { }

	// RVA: 0x15CE4A0 Offset: 0x15CA4A0 VA: 0x15CE4A0
	internal void .ctor(Stream input, byte[] buffer, int bufferPos, int bufferSize, bool leaveOpen) { }

	// RVA: 0x15CE5B4 Offset: 0x15CA5B4 VA: 0x15CE5B4
	internal void set_DiscardUnknownFields(bool value) { }

	// RVA: 0x15CE5BC Offset: 0x15CA5BC VA: 0x15CE5BC
	internal void set_ExtensionRegistry(ExtensionRegistry value) { }

	// RVA: 0x15CE5C4 Offset: 0x15CA5C4 VA: 0x15CE5C4
	internal byte[] get_InternalBuffer() { }

	// RVA: 0x15CE5CC Offset: 0x15CA5CC VA: 0x15CE5CC
	internal Stream get_InternalInputStream() { }

	// RVA: 0x15CE5D4 Offset: 0x15CA5D4 VA: 0x15CE5D4
	internal ref ParserInternalState get_InternalState() { }

	// RVA: 0x15CE5DC Offset: 0x15CA5DC VA: 0x15CE5DC Slot: 4
	public void Dispose() { }

	// RVA: 0x15CE600 Offset: 0x15CA600 VA: 0x15CE600
	internal void CheckReadEndOfStreamTag() { }

	// RVA: 0x15CE684 Offset: 0x15CA684 VA: 0x15CE684
	public void ReadRawMessage(IMessage message) { }
}

// Namespace: 
public sealed class CodedOutputStream.OutOfSpaceException : IOException // TypeDefIndex: 6296
{
	// Methods

	// RVA: 0x15CF49C Offset: 0x15CB49C VA: 0x15CF49C
	internal void .ctor() { }
}

// Namespace: Google.Protobuf
public sealed class CodedOutputStream : IDisposable // TypeDefIndex: 6297
{
	// Fields
	public static readonly int DefaultBufferSize; // 0x0
	private readonly bool leaveOpen; // 0x10
	private readonly byte[] buffer; // 0x18
	private WriterInternalState state; // 0x20
	private readonly Stream output; // 0x38
	[CompilerGenerated]
	private bool <Deterministic>k__BackingField; // 0x40

	// Properties
	public bool Deterministic { get; }
	internal byte[] InternalBuffer { get; }
	internal Stream InternalOutputStream { get; }
	internal WriterInternalState InternalState { get; }

	// Methods

	// RVA: 0x15CEA8C Offset: 0x15CAA8C VA: 0x15CEA8C
	public static int ComputeUInt64Size(ulong value) { }

	// RVA: 0x15CEB70 Offset: 0x15CAB70 VA: 0x15CEB70
	public static int ComputeInt64Size(long value) { }

	// RVA: 0x15CEBC4 Offset: 0x15CABC4 VA: 0x15CEBC4
	public static int ComputeInt32Size(int value) { }

	// RVA: 0x15CECA4 Offset: 0x15CACA4 VA: 0x15CECA4
	public static int ComputeFixed64Size(ulong value) { }

	// RVA: 0x15CECAC Offset: 0x15CACAC VA: 0x15CECAC
	public static int ComputeFixed32Size(uint value) { }

	// RVA: 0x15CECB4 Offset: 0x15CACB4 VA: 0x15CECB4
	public static int ComputeStringSize(string value) { }

	// RVA: 0x15CEDF4 Offset: 0x15CADF4 VA: 0x15CEDF4
	public static int ComputeMessageSize(IMessage value) { }

	// RVA: 0x15CEED0 Offset: 0x15CAED0 VA: 0x15CEED0
	public static int ComputeBytesSize(ByteString value) { }

	// RVA: 0x15CEF50 Offset: 0x15CAF50 VA: 0x15CEF50
	public static int ComputeUInt32Size(uint value) { }

	// RVA: 0x15CEFE0 Offset: 0x15CAFE0 VA: 0x15CEFE0
	public static int ComputeEnumSize(int value) { }

	// RVA: 0x15CED64 Offset: 0x15CAD64 VA: 0x15CED64
	public static int ComputeLengthSize(int length) { }

	// RVA: 0x15CEC60 Offset: 0x15CAC60 VA: 0x15CEC60
	public static int ComputeRawVarint32Size(uint value) { }

	// RVA: 0x15CEAE0 Offset: 0x15CAAE0 VA: 0x15CEAE0
	public static int ComputeRawVarint64Size(ulong value) { }

	// RVA: 0x15CF034 Offset: 0x15CB034 VA: 0x15CF034
	public static int ComputeTagSize(int fieldNumber) { }

	// RVA: 0x15CF0D0 Offset: 0x15CB0D0 VA: 0x15CF0D0
	public void .ctor(byte[] flatArray) { }

	// RVA: 0x15CF0E8 Offset: 0x15CB0E8 VA: 0x15CF0E8
	private void .ctor(byte[] buffer, int offset, int length) { }

	[CompilerGenerated]
	// RVA: 0x15CF1C4 Offset: 0x15CB1C4 VA: 0x15CF1C4
	public bool get_Deterministic() { }

	// RVA: 0x15CF1CC Offset: 0x15CB1CC VA: 0x15CF1CC
	public void WriteRawMessage(IMessage value) { }

	// RVA: 0x15CF2F8 Offset: 0x15CB2F8 VA: 0x15CF2F8 Slot: 4
	public void Dispose() { }

	// RVA: 0x15CF32C Offset: 0x15CB32C VA: 0x15CF32C
	public void Flush() { }

	// RVA: 0x15CF42C Offset: 0x15CB42C VA: 0x15CF42C
	public void CheckNoSpaceLeft() { }

	// RVA: 0x15CF438 Offset: 0x15CB438 VA: 0x15CF438
	internal byte[] get_InternalBuffer() { }

	// RVA: 0x15CF440 Offset: 0x15CB440 VA: 0x15CF440
	internal Stream get_InternalOutputStream() { }

	// RVA: 0x15CF448 Offset: 0x15CB448 VA: 0x15CF448
	internal ref WriterInternalState get_InternalState() { }

	// RVA: 0x15CF450 Offset: 0x15CB450 VA: 0x15CF450
	private static void .cctor() { }
}

// Namespace: Google.Protobuf
public abstract class Extension // TypeDefIndex: 6298
{
	// Fields
	[CompilerGenerated]
	private readonly int <FieldNumber>k__BackingField; // 0x10

	// Properties
	internal abstract Type TargetType { get; }
	public int FieldNumber { get; }
	internal abstract bool IsRepeated { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract Type get_TargetType();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract IExtensionValue CreateValue();

	[CompilerGenerated]
	// RVA: 0x15CF4E8 Offset: 0x15CB4E8 VA: 0x15CF4E8
	public int get_FieldNumber() { }

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract bool get_IsRepeated();
}

// Namespace: Google.Protobuf
public sealed class Extension<TTarget, TValue> : Extension // TypeDefIndex: 6299
{
	// Fields
	private readonly FieldCodec<TValue> codec; // 0x0

	// Properties
	internal TValue DefaultValue { get; }
	internal override Type TargetType { get; }
	internal override bool IsRepeated { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal TValue get_DefaultValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1255E60 Offset: 0x1251E60 VA: 0x1255E60
	|-Extension<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_DefaultValue
	*/

	// RVA: -1 Offset: -1 Slot: 4
	internal override Type get_TargetType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1255F44 Offset: 0x1251F44 VA: 0x1255F44
	|-Extension<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_TargetType
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal override bool get_IsRepeated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1255F7C Offset: 0x1251F7C VA: 0x1255F7C
	|-Extension<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsRepeated
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override IExtensionValue CreateValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1255F84 Offset: 0x1251F84 VA: 0x1255F84
	|-Extension<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateValue
	*/
}

// Namespace: Google.Protobuf
public sealed class RepeatedExtension<TTarget, TValue> : Extension // TypeDefIndex: 6300
{
	// Fields
	private readonly FieldCodec<TValue> codec; // 0x0

	// Properties
	internal override Type TargetType { get; }
	internal override bool IsRepeated { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal override Type get_TargetType() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14489C8 Offset: 0x14449C8 VA: 0x14489C8
	|-RepeatedExtension<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_TargetType
	*/

	// RVA: -1 Offset: -1 Slot: 6
	internal override bool get_IsRepeated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448A00 Offset: 0x1444A00 VA: 0x1448A00
	|-RepeatedExtension<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsRepeated
	*/

	// RVA: -1 Offset: -1 Slot: 5
	internal override IExtensionValue CreateValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448A08 Offset: 0x1444A08 VA: 0x1448A08
	|-RepeatedExtension<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CreateValue
	*/
}

// Namespace: 
internal sealed class ExtensionRegistry.ExtensionComparer : IEqualityComparer<Extension> // TypeDefIndex: 6301
{
	// Fields
	internal static ExtensionRegistry.ExtensionComparer Instance; // 0x0

	// Methods

	// RVA: 0x15D03E0 Offset: 0x15CC3E0 VA: 0x15D03E0 Slot: 4
	public bool Equals(Extension a, Extension b) { }

	// RVA: 0x15D04BC Offset: 0x15CC4BC VA: 0x15D04BC Slot: 5
	public int GetHashCode(Extension a) { }

	// RVA: 0x15D0560 Offset: 0x15CC560 VA: 0x15D0560
	public void .ctor() { }

	// RVA: 0x15D0568 Offset: 0x15CC568 VA: 0x15D0568
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ExtensionRegistry.<>c // TypeDefIndex: 6302
{
	// Fields
	public static readonly ExtensionRegistry.<>c <>9; // 0x0
	public static Func<KeyValuePair<ObjectIntPair<Type>, Extension>, ObjectIntPair<Type>> <>9__3_0; // 0x8
	public static Func<KeyValuePair<ObjectIntPair<Type>, Extension>, Extension> <>9__3_1; // 0x10

	// Methods

	// RVA: 0x15D05D0 Offset: 0x15CC5D0 VA: 0x15D05D0
	private static void .cctor() { }

	// RVA: 0x15D0638 Offset: 0x15CC638 VA: 0x15D0638
	public void .ctor() { }

	// RVA: 0x15D0640 Offset: 0x15CC640 VA: 0x15D0640
	internal ObjectIntPair<Type> <.ctor>b__3_0(KeyValuePair<ObjectIntPair<Type>, Extension> k) { }

	// RVA: 0x15D067C Offset: 0x15CC67C VA: 0x15D067C
	internal Extension <.ctor>b__3_1(KeyValuePair<ObjectIntPair<Type>, Extension> v) { }
}

// Namespace: Google.Protobuf
public sealed class ExtensionRegistry : ICollection<Extension>, IEnumerable<Extension>, IEnumerable, IDeepCloneable<ExtensionRegistry> // TypeDefIndex: 6303
{
	// Fields
	private readonly IDictionary<ObjectIntPair<Type>, Extension> extensions; // 0x10

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<Google.Protobuf.Extension>.IsReadOnly { get; }

	// Methods

	// RVA: 0x15CF4F0 Offset: 0x15CB4F0 VA: 0x15CF4F0
	public void .ctor() { }

	// RVA: 0x15CF578 Offset: 0x15CB578 VA: 0x15CF578
	private void .ctor(IDictionary<ObjectIntPair<Type>, Extension> collection) { }

	// RVA: 0x15CF734 Offset: 0x15CB734 VA: 0x15CF734 Slot: 4
	public int get_Count() { }

	// RVA: 0x15CF7D4 Offset: 0x15CB7D4 VA: 0x15CF7D4 Slot: 5
	private bool System.Collections.Generic.ICollection<Google.Protobuf.Extension>.get_IsReadOnly() { }

	// RVA: 0x15CF7DC Offset: 0x15CB7DC VA: 0x15CF7DC
	internal bool ContainsInputField(uint lastTag, Type target, out Extension extension) { }

	// RVA: 0x15CF8F0 Offset: 0x15CB8F0 VA: 0x15CF8F0 Slot: 6
	public void Add(Extension extension) { }

	// RVA: 0x15CFA34 Offset: 0x15CBA34 VA: 0x15CFA34
	public void AddRange(IEnumerable<Extension> extensions) { }

	// RVA: 0x15CFD0C Offset: 0x15CBD0C VA: 0x15CFD0C Slot: 7
	public void Clear() { }

	// RVA: 0x15CFDB0 Offset: 0x15CBDB0 VA: 0x15CFDB0 Slot: 8
	public bool Contains(Extension item) { }

	// RVA: 0x15CFEF4 Offset: 0x15CBEF4 VA: 0x15CFEF4 Slot: 9
	private void System.Collections.Generic.ICollection<Google.Protobuf.Extension>.CopyTo(Extension[] array, int arrayIndex) { }

	// RVA: 0x15D0124 Offset: 0x15CC124 VA: 0x15D0124 Slot: 11
	public IEnumerator<Extension> GetEnumerator() { }

	// RVA: 0x15D023C Offset: 0x15CC23C VA: 0x15D023C Slot: 10
	public bool Remove(Extension item) { }

	// RVA: 0x15D0380 Offset: 0x15CC380 VA: 0x15D0380 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x15D0384 Offset: 0x15CC384 VA: 0x15D0384 Slot: 13
	public ExtensionRegistry Clone() { }
}

// Namespace: Google.Protobuf
public static class ExtensionSet // TypeDefIndex: 6304
{
	// Methods

	// RVA: -1 Offset: -1
	private static bool TryGetValue<TTarget>(ref ExtensionSet<TTarget> set, Extension extension, out IExtensionValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1112070 Offset: 0x110E070 VA: 0x1112070
	|-ExtensionSet.TryGetValue<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static TValue Get<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1110C98 Offset: 0x110CC98 VA: 0x1110C98
	|-ExtensionSet.Get<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static RepeatedField<TValue> Get<TTarget, TValue>(ref ExtensionSet<TTarget> set, RepeatedExtension<TTarget, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11110FC Offset: 0x110D0FC VA: 0x11110FC
	|-ExtensionSet.Get<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static RepeatedField<TValue> GetOrInitialize<TTarget, TValue>(ref ExtensionSet<TTarget> set, RepeatedExtension<TTarget, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11113D4 Offset: 0x110D3D4 VA: 0x11113D4
	|-ExtensionSet.GetOrInitialize<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Set<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111D24 Offset: 0x110DD24 VA: 0x1111D24
	|-ExtensionSet.Set<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool Has<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11115D4 Offset: 0x110D5D4 VA: 0x11115D4
	|-ExtensionSet.Has<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Clear<TTarget, TValue>(ref ExtensionSet<TTarget> set, Extension<TTarget, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11105F4 Offset: 0x110C5F4 VA: 0x11105F4
	|-ExtensionSet.Clear<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Clear<TTarget, TValue>(ref ExtensionSet<TTarget> set, RepeatedExtension<TTarget, TValue> extension) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11106C4 Offset: 0x110C6C4 VA: 0x11106C4
	|-ExtensionSet.Clear<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool TryMergeFieldFrom<TTarget>(ref ExtensionSet<TTarget> set, ref ParseContext ctx) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111211C Offset: 0x110E11C VA: 0x111211C
	|-ExtensionSet.TryMergeFieldFrom<object>
	|
	|-RVA: 0x11123CC Offset: 0x110E3CC VA: 0x11123CC
	|-ExtensionSet.TryMergeFieldFrom<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void MergeFrom<TTarget>(ref ExtensionSet<TTarget> first, ExtensionSet<TTarget> second) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1111630 Offset: 0x110D630 VA: 0x1111630
	|-ExtensionSet.MergeFrom<object>
	|
	|-RVA: 0x1111990 Offset: 0x110D990 VA: 0x1111990
	|-ExtensionSet.MergeFrom<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static ExtensionSet<TTarget> Clone<TTarget>(ExtensionSet<TTarget> set) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1110794 Offset: 0x110C794 VA: 0x1110794
	|-ExtensionSet.Clone<object>
	|
	|-RVA: 0x1110A00 Offset: 0x110CA00 VA: 0x1110A00
	|-ExtensionSet.Clone<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Google.Protobuf
public sealed class ExtensionSet<TTarget> // TypeDefIndex: 6305
{
	// Fields
	[CompilerGenerated]
	private readonly Dictionary<int, IExtensionValue> <ValuesByNumber>k__BackingField; // 0x0

	// Properties
	internal Dictionary<int, IExtensionValue> ValuesByNumber { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal Dictionary<int, IExtensionValue> get_ValuesByNumber() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1253DA4 Offset: 0x124FDA4 VA: 0x1253DA4
	|-ExtensionSet<object>.get_ValuesByNumber
	|
	|-RVA: 0x1254660 Offset: 0x1250660 VA: 0x1254660
	|-ExtensionSet<__Il2CppFullySharedGenericType>.get_ValuesByNumber
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1253DAC Offset: 0x124FDAC VA: 0x1253DAC
	|-ExtensionSet<object>.GetHashCode
	|
	|-RVA: 0x1254668 Offset: 0x1250668 VA: 0x1254668
	|-ExtensionSet<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1253F7C Offset: 0x124FF7C VA: 0x1253F7C
	|-ExtensionSet<object>.Equals
	|
	|-RVA: 0x1254848 Offset: 0x1250848 VA: 0x1254848
	|-ExtensionSet<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1
	public int CalculateSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1254244 Offset: 0x1250244 VA: 0x1254244
	|-ExtensionSet<object>.CalculateSize
	|
	|-RVA: 0x1254B6C Offset: 0x1250B6C VA: 0x1254B6C
	|-ExtensionSet<__Il2CppFullySharedGenericType>.CalculateSize
	*/

	// RVA: -1 Offset: -1
	public void WriteTo(ref WriteContext ctx) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1254410 Offset: 0x1250410 VA: 0x1254410
	|-ExtensionSet<object>.WriteTo
	|
	|-RVA: 0x1254D50 Offset: 0x1250D50 VA: 0x1254D50
	|-ExtensionSet<__Il2CppFullySharedGenericType>.WriteTo
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12545D8 Offset: 0x12505D8 VA: 0x12545D8
	|-ExtensionSet<object>..ctor
	|
	|-RVA: 0x1254F30 Offset: 0x1250F30 VA: 0x1254F30
	|-ExtensionSet<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: Google.Protobuf
internal interface IExtensionValue : IEquatable<IExtensionValue>, IDeepCloneable<IExtensionValue> // TypeDefIndex: 6306
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void MergeFrom(ref ParseContext ctx);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void MergeFrom(IExtensionValue value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void WriteTo(ref WriteContext ctx);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int CalculateSize();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object GetValue();
}

// Namespace: Google.Protobuf
internal sealed class ExtensionValue<T> : IExtensionValue, IEquatable<IExtensionValue>, IDeepCloneable<IExtensionValue> // TypeDefIndex: 6307
{
	// Fields
	private T field; // 0x0
	private readonly FieldCodec<T> codec; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(FieldCodec<T> codec) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1254FB8 Offset: 0x1250FB8 VA: 0x1254FB8
	|-ExtensionValue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public int CalculateSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12550C0 Offset: 0x12510C0 VA: 0x12550C0
	|-ExtensionValue<__Il2CppFullySharedGenericType>.CalculateSize
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public IExtensionValue Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12551C8 Offset: 0x12511C8 VA: 0x12551C8
	|-ExtensionValue<__Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool Equals(IExtensionValue other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12554F0 Offset: 0x12514F0 VA: 0x12554F0
	|-ExtensionValue<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125571C Offset: 0x125171C VA: 0x125571C
	|-ExtensionValue<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void MergeFrom(ref ParseContext ctx) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125586C Offset: 0x125186C VA: 0x125586C
	|-ExtensionValue<__Il2CppFullySharedGenericType>.MergeFrom
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void MergeFrom(IExtensionValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1255914 Offset: 0x1251914 VA: 0x1255914
	|-ExtensionValue<__Il2CppFullySharedGenericType>.MergeFrom
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void WriteTo(ref WriteContext ctx) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1255AD4 Offset: 0x1251AD4 VA: 0x1255AD4
	|-ExtensionValue<__Il2CppFullySharedGenericType>.WriteTo
	*/

	// RVA: -1 Offset: -1
	public T GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1255CD0 Offset: 0x1251CD0 VA: 0x1255CD0
	|-ExtensionValue<__Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object Google.Protobuf.IExtensionValue.GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1255D10 Offset: 0x1251D10 VA: 0x1255D10
	|-ExtensionValue<__Il2CppFullySharedGenericType>.Google.Protobuf.IExtensionValue.GetValue
	*/

	// RVA: -1 Offset: -1
	public void SetValue(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1255DB0 Offset: 0x1251DB0 VA: 0x1255DB0
	|-ExtensionValue<__Il2CppFullySharedGenericType>.SetValue
	*/
}

// Namespace: Google.Protobuf
internal sealed class RepeatedExtensionValue<T> : IExtensionValue, IEquatable<IExtensionValue>, IDeepCloneable<IExtensionValue> // TypeDefIndex: 6308
{
	// Fields
	private RepeatedField<T> field; // 0x0
	private readonly FieldCodec<T> codec; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(FieldCodec<T> codec) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448590 Offset: 0x1444590 VA: 0x1448590
	|-RepeatedExtensionValue<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public int CalculateSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144860C Offset: 0x144460C VA: 0x144860C
	|-RepeatedExtensionValue<__Il2CppFullySharedGenericType>.CalculateSize
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public IExtensionValue Clone() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448638 Offset: 0x1444638 VA: 0x1448638
	|-RepeatedExtensionValue<__Il2CppFullySharedGenericType>.Clone
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool Equals(IExtensionValue other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14486D4 Offset: 0x14446D4 VA: 0x14486D4
	|-RepeatedExtensionValue<__Il2CppFullySharedGenericType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1448838 Offset: 0x1444838 VA: 0x1448838
	|-RepeatedExtensionValue<__Il2CppFullySharedGenericType>.GetHashCode
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void MergeFrom(ref ParseContext ctx) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144888C Offset: 0x144488C VA: 0x144888C
	|-RepeatedExtensionValue<__Il2CppFullySharedGenericType>.MergeFrom
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void MergeFrom(IExtensionValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14488B8 Offset: 0x14448B8 VA: 0x14488B8
	|-RepeatedExtensionValue<__Il2CppFullySharedGenericType>.MergeFrom
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public void WriteTo(ref WriteContext ctx) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x144898C Offset: 0x144498C VA: 0x144898C
	|-RepeatedExtensionValue<__Il2CppFullySharedGenericType>.WriteTo
	*/

	// RVA: -1 Offset: -1
	public RepeatedField<T> GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14489B8 Offset: 0x14449B8 VA: 0x14489B8
	|-RepeatedExtensionValue<__Il2CppFullySharedGenericType>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private object Google.Protobuf.IExtensionValue.GetValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14489C0 Offset: 0x14449C0 VA: 0x14489C0
	|-RepeatedExtensionValue<__Il2CppFullySharedGenericType>.Google.Protobuf.IExtensionValue.GetValue
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FieldCodec.<>c // TypeDefIndex: 6309
{
	// Fields
	public static readonly FieldCodec.<>c <>9; // 0x0
	public static ValueReader<string> <>9__16_0; // 0x8
	public static ValueWriter<string> <>9__16_1; // 0x10
	public static ValueReader<int> <>9__19_0; // 0x18
	public static ValueWriter<int> <>9__19_1; // 0x20
	public static ValueReader<long> <>9__24_0; // 0x28
	public static ValueWriter<long> <>9__24_1; // 0x30

	// Methods

	// RVA: 0x15D0D64 Offset: 0x15CCD64 VA: 0x15D0D64
	private static void .cctor() { }

	// RVA: 0x15D0DCC Offset: 0x15CCDCC VA: 0x15D0DCC
	public void .ctor() { }

	// RVA: 0x15D0DD4 Offset: 0x15CCDD4 VA: 0x15D0DD4
	internal string <ForString>b__16_0(ref ParseContext ctx) { }

	// RVA: 0x15D0DE0 Offset: 0x15CCDE0 VA: 0x15D0DE0
	internal void <ForString>b__16_1(ref WriteContext ctx, string value) { }

	// RVA: 0x15D0E54 Offset: 0x15CCE54 VA: 0x15D0E54
	internal int <ForInt32>b__19_0(ref ParseContext ctx) { }

	// RVA: 0x15D0EAC Offset: 0x15CCEAC VA: 0x15D0EAC
	internal void <ForInt32>b__19_1(ref WriteContext output, int value) { }

	// RVA: 0x15D0F20 Offset: 0x15CCF20 VA: 0x15D0F20
	internal long <ForInt64>b__24_0(ref ParseContext ctx) { }

	// RVA: 0x15D0F78 Offset: 0x15CCF78 VA: 0x15D0F78
	internal void <ForInt64>b__24_1(ref WriteContext output, long value) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FieldCodec.<>c__32<T> // TypeDefIndex: 6310
{
	// Fields
	public static readonly FieldCodec.<>c__32<T> <>9; // 0x0
	public static ValueWriter<T> <>9__32_1; // 0x0
	public static FieldCodec.ValuesMerger<T> <>9__32_3; // 0x0
	public static Func<T, int> <>9__32_4; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11541A4 Offset: 0x11501A4 VA: 0x11541A4
	|-FieldCodec.<>c__32<object>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115427C Offset: 0x115027C VA: 0x115427C
	|-FieldCodec.<>c__32<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <ForMessage>b__32_1(ref WriteContext output, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1154284 Offset: 0x1150284 VA: 0x1154284
	|-FieldCodec.<>c__32<object>.<ForMessage>b__32_1
	*/

	// RVA: -1 Offset: -1
	internal bool <ForMessage>b__32_3(ref T v, T v2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1154294 Offset: 0x1150294 VA: 0x1154294
	|-FieldCodec.<>c__32<object>.<ForMessage>b__32_3
	*/

	// RVA: -1 Offset: -1
	internal int <ForMessage>b__32_4(T message) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11543C8 Offset: 0x11503C8 VA: 0x11543C8
	|-FieldCodec.<>c__32<object>.<ForMessage>b__32_4
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class FieldCodec.<>c__DisplayClass31_0<T> // TypeDefIndex: 6311
{
	// Fields
	public Func<int, T> fromInt32; // 0x0
	public Func<T, int> toInt32; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1158200 Offset: 0x1154200 VA: 0x1158200
	|-FieldCodec.<>c__DisplayClass31_0<Int32Enum>..ctor
	|
	|-RVA: 0x1158348 Offset: 0x1154348 VA: 0x1158348
	|-FieldCodec.<>c__DisplayClass31_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T <ForEnum>b__0(ref ParseContext ctx) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1158208 Offset: 0x1154208 VA: 0x1158208
	|-FieldCodec.<>c__DisplayClass31_0<Int32Enum>.<ForEnum>b__0
	|
	|-RVA: 0x1158350 Offset: 0x1154350 VA: 0x1158350
	|-FieldCodec.<>c__DisplayClass31_0<__Il2CppFullySharedGenericType>.<ForEnum>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <ForEnum>b__1(ref WriteContext output, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1158284 Offset: 0x1154284 VA: 0x1158284
	|-FieldCodec.<>c__DisplayClass31_0<Int32Enum>.<ForEnum>b__1
	|
	|-RVA: 0x115847C Offset: 0x115447C VA: 0x115847C
	|-FieldCodec.<>c__DisplayClass31_0<__Il2CppFullySharedGenericType>.<ForEnum>b__1
	*/

	// RVA: -1 Offset: -1
	internal int <ForEnum>b__2(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11582C4 Offset: 0x11542C4 VA: 0x11582C4
	|-FieldCodec.<>c__DisplayClass31_0<Int32Enum>.<ForEnum>b__2
	|
	|-RVA: 0x1158568 Offset: 0x1154568 VA: 0x1158568
	|-FieldCodec.<>c__DisplayClass31_0<__Il2CppFullySharedGenericType>.<ForEnum>b__2
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class FieldCodec.<>c__DisplayClass32_0<T> // TypeDefIndex: 6312
{
	// Fields
	public MessageParser<T> parser; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1158690 Offset: 0x1154690 VA: 0x1158690
	|-FieldCodec.<>c__DisplayClass32_0<object>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T <ForMessage>b__0(ref ParseContext ctx) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1158698 Offset: 0x1154698 VA: 0x1158698
	|-FieldCodec.<>c__DisplayClass32_0<object>.<ForMessage>b__0
	*/

	// RVA: -1 Offset: -1
	internal void <ForMessage>b__2(ref ParseContext ctx, ref T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115871C Offset: 0x115471C VA: 0x115871C
	|-FieldCodec.<>c__DisplayClass32_0<object>.<ForMessage>b__2
	*/
}

// Namespace: Google.Protobuf
public static class FieldCodec // TypeDefIndex: 6313
{
	// Methods

	// RVA: 0x15D06B8 Offset: 0x15CC6B8 VA: 0x15D06B8
	public static FieldCodec<string> ForString(uint tag) { }

	// RVA: 0x15D091C Offset: 0x15CC91C VA: 0x15D091C
	public static FieldCodec<int> ForInt32(uint tag) { }

	// RVA: 0x15D0B40 Offset: 0x15CCB40 VA: 0x15D0B40
	public static FieldCodec<long> ForInt64(uint tag) { }

	// RVA: -1 Offset: -1
	public static FieldCodec<T> ForEnum<T>(uint tag, Func<T, int> toInt32, Func<int, T> fromInt32) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1112C24 Offset: 0x110EC24 VA: 0x1112C24
	|-FieldCodec.ForEnum<Int32Enum>
	|
	|-RVA: 0x1112C78 Offset: 0x110EC78 VA: 0x1112C78
	|-FieldCodec.ForEnum<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15D0700 Offset: 0x15CC700 VA: 0x15D0700
	public static FieldCodec<string> ForString(uint tag, string defaultValue) { }

	// RVA: 0x15D0924 Offset: 0x15CC924 VA: 0x15D0924
	public static FieldCodec<int> ForInt32(uint tag, int defaultValue) { }

	// RVA: 0x15D0B48 Offset: 0x15CCB48 VA: 0x15D0B48
	public static FieldCodec<long> ForInt64(uint tag, long defaultValue) { }

	// RVA: -1 Offset: -1
	public static FieldCodec<T> ForEnum<T>(uint tag, Func<T, int> toInt32, Func<int, T> fromInt32, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1112D58 Offset: 0x110ED58 VA: 0x1112D58
	|-FieldCodec.ForEnum<Int32Enum>
	|
	|-RVA: 0x1112ED0 Offset: 0x110EED0 VA: 0x1112ED0
	|-FieldCodec.ForEnum<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static FieldCodec<T> ForMessage<T>(uint tag, MessageParser<T> parser) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111310C Offset: 0x110F10C VA: 0x111310C
	|-FieldCodec.ForMessage<object>
	*/
}

// Namespace: Google.Protobuf
internal sealed class ValueReader<TValue> : MulticastDelegate // TypeDefIndex: 6314
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AD81C Offset: 0x14A981C VA: 0x14AD81C
	|-ValueReader<int>..ctor
	|
	|-RVA: 0x14AD8E0 Offset: 0x14A98E0 VA: 0x14AD8E0
	|-ValueReader<Int32Enum>..ctor
	|
	|-RVA: 0x14AD9A4 Offset: 0x14A99A4 VA: 0x14AD9A4
	|-ValueReader<long>..ctor
	|
	|-RVA: 0x14ADA68 Offset: 0x14A9A68 VA: 0x14ADA68
	|-ValueReader<object>..ctor
	|
	|-RVA: 0x14ADB2C Offset: 0x14A9B2C VA: 0x14ADB2C
	|-ValueReader<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TValue Invoke(ref ParseContext ctx) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14AD8CC Offset: 0x14A98CC VA: 0x14AD8CC
	|-ValueReader<int>.Invoke
	|
	|-RVA: 0x14AD990 Offset: 0x14A9990 VA: 0x14AD990
	|-ValueReader<Int32Enum>.Invoke
	|
	|-RVA: 0x14ADA54 Offset: 0x14A9A54 VA: 0x14ADA54
	|-ValueReader<long>.Invoke
	|
	|-RVA: 0x14ADB18 Offset: 0x14A9B18 VA: 0x14ADB18
	|-ValueReader<object>.Invoke
	|
	|-RVA: 0x14ADBE0 Offset: 0x14A9BE0 VA: 0x14ADBE0
	|-ValueReader<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: Google.Protobuf
internal sealed class ValueWriter<T> : MulticastDelegate // TypeDefIndex: 6315
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1517D68 Offset: 0x1513D68 VA: 0x1517D68
	|-ValueWriter<int>..ctor
	|
	|-RVA: 0x1517E30 Offset: 0x1513E30 VA: 0x1517E30
	|-ValueWriter<Int32Enum>..ctor
	|
	|-RVA: 0x1517EF8 Offset: 0x1513EF8 VA: 0x1517EF8
	|-ValueWriter<long>..ctor
	|
	|-RVA: 0x1517FC0 Offset: 0x1513FC0 VA: 0x1517FC0
	|-ValueWriter<object>..ctor
	|
	|-RVA: 0x1518088 Offset: 0x1514088 VA: 0x1518088
	|-ValueWriter<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(ref WriteContext ctx, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1517E1C Offset: 0x1513E1C VA: 0x1517E1C
	|-ValueWriter<int>.Invoke
	|
	|-RVA: 0x1517EE4 Offset: 0x1513EE4 VA: 0x1517EE4
	|-ValueWriter<Int32Enum>.Invoke
	|
	|-RVA: 0x1517FAC Offset: 0x1513FAC VA: 0x1517FAC
	|-ValueWriter<long>.Invoke
	|
	|-RVA: 0x1518074 Offset: 0x1514074 VA: 0x1518074
	|-ValueWriter<object>.Invoke
	|
	|-RVA: 0x1518140 Offset: 0x1514140 VA: 0x1518140
	|-ValueWriter<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
internal sealed class FieldCodec.InputMerger<T> : MulticastDelegate // TypeDefIndex: 6316
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127EC90 Offset: 0x127AC90 VA: 0x127EC90
	|-FieldCodec.InputMerger<int>..ctor
	|
	|-RVA: 0x127ED58 Offset: 0x127AD58 VA: 0x127ED58
	|-FieldCodec.InputMerger<Int32Enum>..ctor
	|
	|-RVA: 0x127EE20 Offset: 0x127AE20 VA: 0x127EE20
	|-FieldCodec.InputMerger<long>..ctor
	|
	|-RVA: 0x127EEE8 Offset: 0x127AEE8 VA: 0x127EEE8
	|-FieldCodec.InputMerger<object>..ctor
	|
	|-RVA: 0x127EFB0 Offset: 0x127AFB0 VA: 0x127EFB0
	|-FieldCodec.InputMerger<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(ref ParseContext ctx, ref T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127ED44 Offset: 0x127AD44 VA: 0x127ED44
	|-FieldCodec.InputMerger<int>.Invoke
	|
	|-RVA: 0x127EE0C Offset: 0x127AE0C VA: 0x127EE0C
	|-FieldCodec.InputMerger<Int32Enum>.Invoke
	|
	|-RVA: 0x127EED4 Offset: 0x127AED4 VA: 0x127EED4
	|-FieldCodec.InputMerger<long>.Invoke
	|
	|-RVA: 0x127EF9C Offset: 0x127AF9C VA: 0x127EF9C
	|-FieldCodec.InputMerger<object>.Invoke
	|
	|-RVA: 0x127F064 Offset: 0x127B064 VA: 0x127F064
	|-FieldCodec.InputMerger<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
internal sealed class FieldCodec.ValuesMerger<T> : MulticastDelegate // TypeDefIndex: 6317
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1518154 Offset: 0x1514154 VA: 0x1518154
	|-FieldCodec.ValuesMerger<int>..ctor
	|
	|-RVA: 0x151821C Offset: 0x151421C VA: 0x151821C
	|-FieldCodec.ValuesMerger<Int32Enum>..ctor
	|
	|-RVA: 0x15182E4 Offset: 0x15142E4 VA: 0x15182E4
	|-FieldCodec.ValuesMerger<long>..ctor
	|
	|-RVA: 0x15183AC Offset: 0x15143AC VA: 0x15183AC
	|-FieldCodec.ValuesMerger<object>..ctor
	|
	|-RVA: 0x1518474 Offset: 0x1514474 VA: 0x1518474
	|-FieldCodec.ValuesMerger<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual bool Invoke(ref T value, T other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1518208 Offset: 0x1514208 VA: 0x1518208
	|-FieldCodec.ValuesMerger<int>.Invoke
	|
	|-RVA: 0x15182D0 Offset: 0x15142D0 VA: 0x15182D0
	|-FieldCodec.ValuesMerger<Int32Enum>.Invoke
	|
	|-RVA: 0x1518398 Offset: 0x1514398 VA: 0x1518398
	|-FieldCodec.ValuesMerger<long>.Invoke
	|
	|-RVA: 0x1518460 Offset: 0x1514460 VA: 0x1518460
	|-FieldCodec.ValuesMerger<object>.Invoke
	|
	|-RVA: 0x151852C Offset: 0x151452C VA: 0x151852C
	|-FieldCodec.ValuesMerger<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FieldCodec.<>c<T> // TypeDefIndex: 6318
{
	// Fields
	public static readonly FieldCodec.<>c<T> <>9; // 0x0
	public static FieldCodec.ValuesMerger<T> <>9__39_1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150260 Offset: 0x114C260 VA: 0x1150260
	|-FieldCodec.<>c<int>..cctor
	|
	|-RVA: 0x11506F8 Offset: 0x114C6F8 VA: 0x11506F8
	|-FieldCodec.<>c<Int32Enum>..cctor
	|
	|-RVA: 0x11507E4 Offset: 0x114C7E4 VA: 0x11507E4
	|-FieldCodec.<>c<long>..cctor
	|
	|-RVA: 0x1150CD0 Offset: 0x114CCD0 VA: 0x1150CD0
	|-FieldCodec.<>c<object>..cctor
	|
	|-RVA: 0x1151490 Offset: 0x114D490 VA: 0x1151490
	|-FieldCodec.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150338 Offset: 0x114C338 VA: 0x1150338
	|-FieldCodec.<>c<int>..ctor
	|
	|-RVA: 0x11507D0 Offset: 0x114C7D0 VA: 0x11507D0
	|-FieldCodec.<>c<Int32Enum>..ctor
	|
	|-RVA: 0x11508BC Offset: 0x114C8BC VA: 0x11508BC
	|-FieldCodec.<>c<long>..ctor
	|
	|-RVA: 0x1150DA8 Offset: 0x114CDA8 VA: 0x1150DA8
	|-FieldCodec.<>c<object>..ctor
	|
	|-RVA: 0x115159C Offset: 0x114D59C VA: 0x115159C
	|-FieldCodec.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal bool <.ctor>b__39_1(ref T v, T v2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150340 Offset: 0x114C340 VA: 0x1150340
	|-FieldCodec.<>c<int>.<.ctor>b__39_1
	|
	|-RVA: 0x11507D8 Offset: 0x114C7D8 VA: 0x11507D8
	|-FieldCodec.<>c<Int32Enum>.<.ctor>b__39_1
	|
	|-RVA: 0x11508C4 Offset: 0x114C8C4 VA: 0x11508C4
	|-FieldCodec.<>c<long>.<.ctor>b__39_1
	|
	|-RVA: 0x1150DB0 Offset: 0x114CDB0 VA: 0x1150DB0
	|-FieldCodec.<>c<object>.<.ctor>b__39_1
	|
	|-RVA: 0x11515A4 Offset: 0x114D5A4 VA: 0x11515A4
	|-FieldCodec.<>c<__Il2CppFullySharedGenericType>.<.ctor>b__39_1
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class FieldCodec.<>c__DisplayClass39_0<T> // TypeDefIndex: 6319
{
	// Fields
	public ValueReader<T> reader; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11592CC Offset: 0x11552CC VA: 0x11592CC
	|-FieldCodec.<>c__DisplayClass39_0<int>..ctor
	|
	|-RVA: 0x1159304 Offset: 0x1155304 VA: 0x1159304
	|-FieldCodec.<>c__DisplayClass39_0<Int32Enum>..ctor
	|
	|-RVA: 0x115933C Offset: 0x115533C VA: 0x115933C
	|-FieldCodec.<>c__DisplayClass39_0<long>..ctor
	|
	|-RVA: 0x1159374 Offset: 0x1155374 VA: 0x1159374
	|-FieldCodec.<>c__DisplayClass39_0<object>..ctor
	|
	|-RVA: 0x11593B4 Offset: 0x11553B4 VA: 0x11593B4
	|-FieldCodec.<>c__DisplayClass39_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.ctor>b__0(ref ParseContext ctx, ref T v) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11592D4 Offset: 0x11552D4 VA: 0x11592D4
	|-FieldCodec.<>c__DisplayClass39_0<int>.<.ctor>b__0
	|
	|-RVA: 0x115930C Offset: 0x115530C VA: 0x115930C
	|-FieldCodec.<>c__DisplayClass39_0<Int32Enum>.<.ctor>b__0
	|
	|-RVA: 0x1159344 Offset: 0x1155344 VA: 0x1159344
	|-FieldCodec.<>c__DisplayClass39_0<long>.<.ctor>b__0
	|
	|-RVA: 0x115937C Offset: 0x115537C VA: 0x115937C
	|-FieldCodec.<>c__DisplayClass39_0<object>.<.ctor>b__0
	|
	|-RVA: 0x11593BC Offset: 0x11553BC VA: 0x11593BC
	|-FieldCodec.<>c__DisplayClass39_0<__Il2CppFullySharedGenericType>.<.ctor>b__0
	*/
}

// Namespace: Google.Protobuf
public sealed class FieldCodec<T> // TypeDefIndex: 6320
{
	// Fields
	private static readonly EqualityComparer<T> EqualityComparer; // 0x0
	private static readonly T DefaultDefault; // 0x0
	private static readonly bool TypeSupportsPacking; // 0x0
	[CompilerGenerated]
	private readonly bool <PackedRepeatedField>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly ValueWriter<T> <ValueWriter>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly Func<T, int> <ValueSizeCalculator>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly ValueReader<T> <ValueReader>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly FieldCodec.InputMerger<T> <ValueMerger>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly FieldCodec.ValuesMerger<T> <FieldMerger>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly int <FixedSize>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly uint <Tag>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly uint <EndTag>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly T <DefaultValue>k__BackingField; // 0x0
	private readonly int tagSize; // 0x0

	// Properties
	internal bool PackedRepeatedField { get; }
	internal ValueWriter<T> ValueWriter { get; }
	internal Func<T, int> ValueSizeCalculator { get; }
	internal ValueReader<T> ValueReader { get; }
	internal FieldCodec.InputMerger<T> ValueMerger { get; }
	internal FieldCodec.ValuesMerger<T> FieldMerger { get; }
	internal int FixedSize { get; }
	internal uint Tag { get; }
	internal uint EndTag { get; }
	internal T DefaultValue { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12582CC Offset: 0x12542CC VA: 0x12582CC
	|-FieldCodec<int>..cctor
	|
	|-RVA: 0x1258EF0 Offset: 0x1254EF0 VA: 0x1258EF0
	|-FieldCodec<Int32Enum>..cctor
	|
	|-RVA: 0x1259B14 Offset: 0x1255B14 VA: 0x1259B14
	|-FieldCodec<long>..cctor
	|
	|-RVA: 0x125A738 Offset: 0x1256738 VA: 0x125A738
	|-FieldCodec<object>..cctor
	|
	|-RVA: 0x125B4F0 Offset: 0x12574F0 VA: 0x125B4F0
	|-FieldCodec<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	internal static bool IsPackedRepeatedField(uint tag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258620 Offset: 0x1254620 VA: 0x1258620
	|-FieldCodec<int>.IsPackedRepeatedField
	|
	|-RVA: 0x1259244 Offset: 0x1255244 VA: 0x1259244
	|-FieldCodec<Int32Enum>.IsPackedRepeatedField
	|
	|-RVA: 0x1259E68 Offset: 0x1255E68 VA: 0x1259E68
	|-FieldCodec<long>.IsPackedRepeatedField
	|
	|-RVA: 0x125AC18 Offset: 0x1256C18 VA: 0x125AC18
	|-FieldCodec<object>.IsPackedRepeatedField
	|
	|-RVA: 0x125B884 Offset: 0x1257884 VA: 0x125B884
	|-FieldCodec<__Il2CppFullySharedGenericType>.IsPackedRepeatedField
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal bool get_PackedRepeatedField() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12586D0 Offset: 0x12546D0 VA: 0x12586D0
	|-FieldCodec<int>.get_PackedRepeatedField
	|
	|-RVA: 0x12592F4 Offset: 0x12552F4 VA: 0x12592F4
	|-FieldCodec<Int32Enum>.get_PackedRepeatedField
	|
	|-RVA: 0x1259F18 Offset: 0x1255F18 VA: 0x1259F18
	|-FieldCodec<long>.get_PackedRepeatedField
	|
	|-RVA: 0x125ACC8 Offset: 0x1256CC8 VA: 0x125ACC8
	|-FieldCodec<object>.get_PackedRepeatedField
	|
	|-RVA: 0x125B92C Offset: 0x125792C VA: 0x125B92C
	|-FieldCodec<__Il2CppFullySharedGenericType>.get_PackedRepeatedField
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal ValueWriter<T> get_ValueWriter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12586D8 Offset: 0x12546D8 VA: 0x12586D8
	|-FieldCodec<int>.get_ValueWriter
	|
	|-RVA: 0x12592FC Offset: 0x12552FC VA: 0x12592FC
	|-FieldCodec<Int32Enum>.get_ValueWriter
	|
	|-RVA: 0x1259F20 Offset: 0x1255F20 VA: 0x1259F20
	|-FieldCodec<long>.get_ValueWriter
	|
	|-RVA: 0x125ACD0 Offset: 0x1256CD0 VA: 0x125ACD0
	|-FieldCodec<object>.get_ValueWriter
	|
	|-RVA: 0x125B954 Offset: 0x1257954 VA: 0x125B954
	|-FieldCodec<__Il2CppFullySharedGenericType>.get_ValueWriter
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal Func<T, int> get_ValueSizeCalculator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12586E0 Offset: 0x12546E0 VA: 0x12586E0
	|-FieldCodec<int>.get_ValueSizeCalculator
	|
	|-RVA: 0x1259304 Offset: 0x1255304 VA: 0x1259304
	|-FieldCodec<Int32Enum>.get_ValueSizeCalculator
	|
	|-RVA: 0x1259F28 Offset: 0x1255F28 VA: 0x1259F28
	|-FieldCodec<long>.get_ValueSizeCalculator
	|
	|-RVA: 0x125ACD8 Offset: 0x1256CD8 VA: 0x125ACD8
	|-FieldCodec<object>.get_ValueSizeCalculator
	|
	|-RVA: 0x125B97C Offset: 0x125797C VA: 0x125B97C
	|-FieldCodec<__Il2CppFullySharedGenericType>.get_ValueSizeCalculator
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal ValueReader<T> get_ValueReader() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12586E8 Offset: 0x12546E8 VA: 0x12586E8
	|-FieldCodec<int>.get_ValueReader
	|
	|-RVA: 0x125930C Offset: 0x125530C VA: 0x125930C
	|-FieldCodec<Int32Enum>.get_ValueReader
	|
	|-RVA: 0x1259F30 Offset: 0x1255F30 VA: 0x1259F30
	|-FieldCodec<long>.get_ValueReader
	|
	|-RVA: 0x125ACE0 Offset: 0x1256CE0 VA: 0x125ACE0
	|-FieldCodec<object>.get_ValueReader
	|
	|-RVA: 0x125B9A4 Offset: 0x12579A4 VA: 0x125B9A4
	|-FieldCodec<__Il2CppFullySharedGenericType>.get_ValueReader
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal FieldCodec.InputMerger<T> get_ValueMerger() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12586F0 Offset: 0x12546F0 VA: 0x12586F0
	|-FieldCodec<int>.get_ValueMerger
	|
	|-RVA: 0x1259314 Offset: 0x1255314 VA: 0x1259314
	|-FieldCodec<Int32Enum>.get_ValueMerger
	|
	|-RVA: 0x1259F38 Offset: 0x1255F38 VA: 0x1259F38
	|-FieldCodec<long>.get_ValueMerger
	|
	|-RVA: 0x125ACE8 Offset: 0x1256CE8 VA: 0x125ACE8
	|-FieldCodec<object>.get_ValueMerger
	|
	|-RVA: 0x125B9CC Offset: 0x12579CC VA: 0x125B9CC
	|-FieldCodec<__Il2CppFullySharedGenericType>.get_ValueMerger
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal FieldCodec.ValuesMerger<T> get_FieldMerger() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12586F8 Offset: 0x12546F8 VA: 0x12586F8
	|-FieldCodec<int>.get_FieldMerger
	|
	|-RVA: 0x125931C Offset: 0x125531C VA: 0x125931C
	|-FieldCodec<Int32Enum>.get_FieldMerger
	|
	|-RVA: 0x1259F40 Offset: 0x1255F40 VA: 0x1259F40
	|-FieldCodec<long>.get_FieldMerger
	|
	|-RVA: 0x125ACF0 Offset: 0x1256CF0 VA: 0x125ACF0
	|-FieldCodec<object>.get_FieldMerger
	|
	|-RVA: 0x125B9F4 Offset: 0x12579F4 VA: 0x125B9F4
	|-FieldCodec<__Il2CppFullySharedGenericType>.get_FieldMerger
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal int get_FixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258700 Offset: 0x1254700 VA: 0x1258700
	|-FieldCodec<int>.get_FixedSize
	|
	|-RVA: 0x1259324 Offset: 0x1255324 VA: 0x1259324
	|-FieldCodec<Int32Enum>.get_FixedSize
	|
	|-RVA: 0x1259F48 Offset: 0x1255F48 VA: 0x1259F48
	|-FieldCodec<long>.get_FixedSize
	|
	|-RVA: 0x125ACF8 Offset: 0x1256CF8 VA: 0x125ACF8
	|-FieldCodec<object>.get_FixedSize
	|
	|-RVA: 0x125BA1C Offset: 0x1257A1C VA: 0x125BA1C
	|-FieldCodec<__Il2CppFullySharedGenericType>.get_FixedSize
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal uint get_Tag() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258708 Offset: 0x1254708 VA: 0x1258708
	|-FieldCodec<int>.get_Tag
	|
	|-RVA: 0x125932C Offset: 0x125532C VA: 0x125932C
	|-FieldCodec<Int32Enum>.get_Tag
	|
	|-RVA: 0x1259F50 Offset: 0x1255F50 VA: 0x1259F50
	|-FieldCodec<long>.get_Tag
	|
	|-RVA: 0x125AD00 Offset: 0x1256D00 VA: 0x125AD00
	|-FieldCodec<object>.get_Tag
	|
	|-RVA: 0x125BA44 Offset: 0x1257A44 VA: 0x125BA44
	|-FieldCodec<__Il2CppFullySharedGenericType>.get_Tag
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal uint get_EndTag() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258710 Offset: 0x1254710 VA: 0x1258710
	|-FieldCodec<int>.get_EndTag
	|
	|-RVA: 0x1259334 Offset: 0x1255334 VA: 0x1259334
	|-FieldCodec<Int32Enum>.get_EndTag
	|
	|-RVA: 0x1259F58 Offset: 0x1255F58 VA: 0x1259F58
	|-FieldCodec<long>.get_EndTag
	|
	|-RVA: 0x125AD08 Offset: 0x1256D08 VA: 0x125AD08
	|-FieldCodec<object>.get_EndTag
	|
	|-RVA: 0x125BA6C Offset: 0x1257A6C VA: 0x125BA6C
	|-FieldCodec<__Il2CppFullySharedGenericType>.get_EndTag
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	internal T get_DefaultValue() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258718 Offset: 0x1254718 VA: 0x1258718
	|-FieldCodec<int>.get_DefaultValue
	|
	|-RVA: 0x125933C Offset: 0x125533C VA: 0x125933C
	|-FieldCodec<Int32Enum>.get_DefaultValue
	|
	|-RVA: 0x1259F60 Offset: 0x1255F60 VA: 0x1259F60
	|-FieldCodec<long>.get_DefaultValue
	|
	|-RVA: 0x125AD10 Offset: 0x1256D10 VA: 0x125AD10
	|-FieldCodec<object>.get_DefaultValue
	|
	|-RVA: 0x125BA94 Offset: 0x1257A94 VA: 0x125BA94
	|-FieldCodec<__Il2CppFullySharedGenericType>.get_DefaultValue
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(ValueReader<T> reader, ValueWriter<T> writer, Func<T, int> sizeCalculator, uint tag, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258720 Offset: 0x1254720 VA: 0x1258720
	|-FieldCodec<int>..ctor
	|
	|-RVA: 0x1259344 Offset: 0x1255344 VA: 0x1259344
	|-FieldCodec<Int32Enum>..ctor
	|
	|-RVA: 0x1259F68 Offset: 0x1255F68 VA: 0x1259F68
	|-FieldCodec<long>..ctor
	|
	|-RVA: 0x125AD18 Offset: 0x1256D18 VA: 0x125AD18
	|-FieldCodec<object>..ctor
	|
	|-RVA: 0x125BAD8 Offset: 0x1257AD8 VA: 0x125BAD8
	|-FieldCodec<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(ValueReader<T> reader, ValueWriter<T> writer, FieldCodec.InputMerger<T> inputMerger, FieldCodec.ValuesMerger<T> valuesMerger, Func<T, int> sizeCalculator, uint tag, uint endTag = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258978 Offset: 0x1254978 VA: 0x1258978
	|-FieldCodec<int>..ctor
	|
	|-RVA: 0x125959C Offset: 0x125559C VA: 0x125959C
	|-FieldCodec<Int32Enum>..ctor
	|
	|-RVA: 0x125A1BC Offset: 0x12561BC VA: 0x125A1BC
	|-FieldCodec<long>..ctor
	|
	|-RVA: 0x125AF6C Offset: 0x1256F6C VA: 0x125AF6C
	|-FieldCodec<object>..ctor
	|
	|-RVA: 0x125BDB4 Offset: 0x1257DB4 VA: 0x125BDB4
	|-FieldCodec<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(ValueReader<T> reader, ValueWriter<T> writer, FieldCodec.InputMerger<T> inputMerger, FieldCodec.ValuesMerger<T> valuesMerger, Func<T, int> sizeCalculator, uint tag, uint endTag, T defaultValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258A60 Offset: 0x1254A60 VA: 0x1258A60
	|-FieldCodec<int>..ctor
	|
	|-RVA: 0x1259684 Offset: 0x1255684 VA: 0x1259684
	|-FieldCodec<Int32Enum>..ctor
	|
	|-RVA: 0x125A2A0 Offset: 0x12562A0 VA: 0x125A2A0
	|-FieldCodec<long>..ctor
	|
	|-RVA: 0x125B050 Offset: 0x1257050 VA: 0x125B050
	|-FieldCodec<object>..ctor
	|
	|-RVA: 0x125BEF4 Offset: 0x1257EF4 VA: 0x125BEF4
	|-FieldCodec<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void WriteTagAndValue(ref WriteContext ctx, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258BDC Offset: 0x1254BDC VA: 0x1258BDC
	|-FieldCodec<int>.WriteTagAndValue
	|
	|-RVA: 0x1259800 Offset: 0x1255800 VA: 0x1259800
	|-FieldCodec<Int32Enum>.WriteTagAndValue
	|
	|-RVA: 0x125A420 Offset: 0x1256420 VA: 0x125A420
	|-FieldCodec<long>.WriteTagAndValue
	|
	|-RVA: 0x125B1D8 Offset: 0x12571D8 VA: 0x125B1D8
	|-FieldCodec<object>.WriteTagAndValue
	|
	|-RVA: 0x125C22C Offset: 0x125822C VA: 0x125C22C
	|-FieldCodec<__Il2CppFullySharedGenericType>.WriteTagAndValue
	*/

	// RVA: -1 Offset: -1
	public T Read(CodedInputStream input) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258C64 Offset: 0x1254C64 VA: 0x1258C64
	|-FieldCodec<int>.Read
	|
	|-RVA: 0x1259888 Offset: 0x1255888 VA: 0x1259888
	|-FieldCodec<Int32Enum>.Read
	|
	|-RVA: 0x125A4A8 Offset: 0x12564A8 VA: 0x125A4A8
	|-FieldCodec<long>.Read
	|
	|-RVA: 0x125B260 Offset: 0x1257260 VA: 0x125B260
	|-FieldCodec<object>.Read
	|
	|-RVA: 0x125C410 Offset: 0x1258410 VA: 0x125C410
	|-FieldCodec<__Il2CppFullySharedGenericType>.Read
	*/

	// RVA: -1 Offset: -1
	public T Read(ref ParseContext ctx) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258DAC Offset: 0x1254DAC VA: 0x1258DAC
	|-FieldCodec<int>.Read
	|
	|-RVA: 0x12599D0 Offset: 0x12559D0 VA: 0x12599D0
	|-FieldCodec<Int32Enum>.Read
	|
	|-RVA: 0x125A5F4 Offset: 0x12565F4 VA: 0x125A5F4
	|-FieldCodec<long>.Read
	|
	|-RVA: 0x125B3AC Offset: 0x12573AC VA: 0x125B3AC
	|-FieldCodec<object>.Read
	|
	|-RVA: 0x125C674 Offset: 0x1258674 VA: 0x125C674
	|-FieldCodec<__Il2CppFullySharedGenericType>.Read
	*/

	// RVA: -1 Offset: -1
	public int CalculateSizeWithTag(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258DCC Offset: 0x1254DCC VA: 0x1258DCC
	|-FieldCodec<int>.CalculateSizeWithTag
	|
	|-RVA: 0x12599F0 Offset: 0x12559F0 VA: 0x12599F0
	|-FieldCodec<Int32Enum>.CalculateSizeWithTag
	|
	|-RVA: 0x125A614 Offset: 0x1256614 VA: 0x125A614
	|-FieldCodec<long>.CalculateSizeWithTag
	|
	|-RVA: 0x125B3CC Offset: 0x12573CC VA: 0x125B3CC
	|-FieldCodec<object>.CalculateSizeWithTag
	|
	|-RVA: 0x125C750 Offset: 0x1258750 VA: 0x125C750
	|-FieldCodec<__Il2CppFullySharedGenericType>.CalculateSizeWithTag
	*/

	// RVA: -1 Offset: -1
	internal int CalculateUnconditionalSizeWithTag(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258E2C Offset: 0x1254E2C VA: 0x1258E2C
	|-FieldCodec<int>.CalculateUnconditionalSizeWithTag
	|
	|-RVA: 0x1259A50 Offset: 0x1255A50 VA: 0x1259A50
	|-FieldCodec<Int32Enum>.CalculateUnconditionalSizeWithTag
	|
	|-RVA: 0x125A674 Offset: 0x1256674 VA: 0x125A674
	|-FieldCodec<long>.CalculateUnconditionalSizeWithTag
	|
	|-RVA: 0x125B42C Offset: 0x125742C VA: 0x125B42C
	|-FieldCodec<object>.CalculateUnconditionalSizeWithTag
	|
	|-RVA: 0x125C8EC Offset: 0x12588EC VA: 0x125C8EC
	|-FieldCodec<__Il2CppFullySharedGenericType>.CalculateUnconditionalSizeWithTag
	*/

	// RVA: -1 Offset: -1
	private bool IsDefault(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258E60 Offset: 0x1254E60 VA: 0x1258E60
	|-FieldCodec<int>.IsDefault
	|
	|-RVA: 0x1259A84 Offset: 0x1255A84 VA: 0x1259A84
	|-FieldCodec<Int32Enum>.IsDefault
	|
	|-RVA: 0x125A6A8 Offset: 0x12566A8 VA: 0x125A6A8
	|-FieldCodec<long>.IsDefault
	|
	|-RVA: 0x125B460 Offset: 0x1257460 VA: 0x125B460
	|-FieldCodec<object>.IsDefault
	|
	|-RVA: 0x125CA20 Offset: 0x1258A20 VA: 0x125CA20
	|-FieldCodec<__Il2CppFullySharedGenericType>.IsDefault
	*/
}

// Namespace: 
internal sealed class FieldMaskTree.Node // TypeDefIndex: 6321
{
	// Fields
	[CompilerGenerated]
	private readonly Dictionary<string, FieldMaskTree.Node> <Children>k__BackingField; // 0x10

	// Properties
	public Dictionary<string, FieldMaskTree.Node> Children { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x15D3140 Offset: 0x15CF140 VA: 0x15D3140
	public Dictionary<string, FieldMaskTree.Node> get_Children() { }

	// RVA: 0x15D1054 Offset: 0x15CD054 VA: 0x15D1054
	public void .ctor() { }
}

// Namespace: Google.Protobuf
internal sealed class FieldMaskTree // TypeDefIndex: 6322
{
	// Fields
	private readonly FieldMaskTree.Node root; // 0x10

	// Methods

	// RVA: 0x15D0FEC Offset: 0x15CCFEC VA: 0x15D0FEC
	public void .ctor() { }

	// RVA: 0x15D10DC Offset: 0x15CD0DC VA: 0x15D10DC
	public void .ctor(FieldMask mask) { }

	// RVA: 0x15D13B8 Offset: 0x15CD3B8 VA: 0x15D13B8 Slot: 3
	public override string ToString() { }

	// RVA: 0x15D14F8 Offset: 0x15CD4F8 VA: 0x15D14F8
	public FieldMaskTree AddFieldPath(string path) { }

	// RVA: 0x15D115C Offset: 0x15CD15C VA: 0x15D115C
	public FieldMaskTree MergeFromFieldMask(FieldMask mask) { }

	// RVA: 0x15D13D8 Offset: 0x15CD3D8 VA: 0x15D13D8
	public FieldMask ToFieldMask() { }

	// RVA: 0x15D176C Offset: 0x15CD76C VA: 0x15D176C
	private void GetFieldPaths(FieldMaskTree.Node node, string path, List<string> paths) { }

	// RVA: 0x15D19D4 Offset: 0x15CD9D4 VA: 0x15D19D4
	public void IntersectFieldPath(string path, FieldMaskTree output) { }

	// RVA: 0x15D1CB0 Offset: 0x15CDCB0 VA: 0x15D1CB0
	public void Merge(IMessage source, IMessage destination, FieldMask.MergeOptions options) { }

	// RVA: 0x15D1E98 Offset: 0x15CDE98 VA: 0x15D1E98
	private void Merge(FieldMaskTree.Node node, string path, IMessage source, IMessage destination, FieldMask.MergeOptions options) { }
}

// Namespace: Google.Protobuf
public interface IBufferMessage : IMessage // TypeDefIndex: 6323
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void InternalMergeFrom(ref ParseContext ctx);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void InternalWriteTo(ref WriteContext ctx);
}

// Namespace: Google.Protobuf
public interface ICustomDiagnosticMessage : IMessage // TypeDefIndex: 6324
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string ToDiagnosticString();
}

// Namespace: Google.Protobuf
public interface IDeepCloneable<T> // TypeDefIndex: 6325
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract T Clone();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IDeepCloneable<__Il2CppFullySharedGenericType>.Clone
	*/
}

// Namespace: Google.Protobuf
public interface IExtendableMessage<T> : IMessage<T>, IMessage, IEquatable<T>, IDeepCloneable<T> // TypeDefIndex: 6326
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TValue GetExtension<TValue>(Extension<T, TValue> extension);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IExtendableMessage<__Il2CppFullySharedGenericType>.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract RepeatedField<TValue> GetExtension<TValue>(RepeatedExtension<T, TValue> extension);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IExtendableMessage<__Il2CppFullySharedGenericType>.GetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract RepeatedField<TValue> GetOrInitializeExtension<TValue>(RepeatedExtension<T, TValue> extension);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IExtendableMessage<__Il2CppFullySharedGenericType>.GetOrInitializeExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void SetExtension<TValue>(Extension<T, TValue> extension, TValue value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IExtendableMessage<__Il2CppFullySharedGenericType>.SetExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool HasExtension<TValue>(Extension<T, TValue> extension);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IExtendableMessage<__Il2CppFullySharedGenericType>.HasExtension<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ClearExtension<TValue>(Extension<T, TValue> extension);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IExtendableMessage<__Il2CppFullySharedGenericType>.ClearExtension<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Google.Protobuf
public interface IMessage // TypeDefIndex: 6327
{
	// Properties
	public abstract MessageDescriptor Descriptor { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void MergeFrom(CodedInputStream input);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void WriteTo(CodedOutputStream output);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int CalculateSize();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract MessageDescriptor get_Descriptor();
}

// Namespace: Google.Protobuf
public interface IMessage<T> : IMessage, IEquatable<T>, IDeepCloneable<T> // TypeDefIndex: 6328
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void MergeFrom(T message);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IMessage<__Il2CppFullySharedGenericType>.MergeFrom
	*/
}

// Namespace: Google.Protobuf
public sealed class InvalidProtocolBufferException : IOException // TypeDefIndex: 6329
{
	// Methods

	// RVA: 0x15D1E90 Offset: 0x15CDE90 VA: 0x15D1E90
	internal void .ctor(string message) { }

	// RVA: 0x15D3148 Offset: 0x15CF148 VA: 0x15D3148
	internal void .ctor(string message, Exception innerException) { }

	// RVA: 0x15D3150 Offset: 0x15CF150 VA: 0x15D3150
	internal static InvalidProtocolBufferException MoreDataAvailable() { }

	// RVA: 0x15D31BC Offset: 0x15CF1BC VA: 0x15D31BC
	internal static InvalidProtocolBufferException TruncatedMessage() { }

	// RVA: 0x15D3228 Offset: 0x15CF228 VA: 0x15D3228
	internal static InvalidProtocolBufferException NegativeSize() { }

	// RVA: 0x15D3294 Offset: 0x15CF294 VA: 0x15D3294
	internal static InvalidProtocolBufferException MalformedVarint() { }

	// RVA: 0x15D3300 Offset: 0x15CF300 VA: 0x15D3300
	internal static InvalidProtocolBufferException InvalidTag() { }

	// RVA: 0x15D336C Offset: 0x15CF36C VA: 0x15D336C
	internal static InvalidProtocolBufferException InvalidWireType() { }

	// RVA: 0x15D33D8 Offset: 0x15CF3D8 VA: 0x15D33D8
	internal static InvalidProtocolBufferException InvalidUtf8(Exception innerException) { }

	// RVA: 0x15D3454 Offset: 0x15CF454 VA: 0x15D3454
	internal static InvalidProtocolBufferException InvalidEndTag() { }

	// RVA: 0x15D34C0 Offset: 0x15CF4C0 VA: 0x15D34C0
	internal static InvalidProtocolBufferException RecursionLimitExceeded() { }

	// RVA: 0x15D352C Offset: 0x15CF52C VA: 0x15D352C
	internal static InvalidProtocolBufferException SizeLimitExceeded() { }
}

// Namespace: 
public sealed class JsonFormatter.Settings // TypeDefIndex: 6330
{
	// Fields
	[CompilerGenerated]
	private static readonly JsonFormatter.Settings <Default>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly bool <FormatDefaultValues>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly TypeRegistry <TypeRegistry>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly bool <FormatEnumsAsIntegers>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly bool <PreserveProtoFieldNames>k__BackingField; // 0x21
	[CompilerGenerated]
	private readonly string <Indentation>k__BackingField; // 0x28

	// Properties
	public static JsonFormatter.Settings Default { get; }
	public bool FormatDefaultValues { get; }
	public TypeRegistry TypeRegistry { get; }
	public bool FormatEnumsAsIntegers { get; }
	public bool PreserveProtoFieldNames { get; }
	public string Indentation { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x15DA858 Offset: 0x15D6858 VA: 0x15DA858
	public static JsonFormatter.Settings get_Default() { }

	// RVA: 0x15DA8B0 Offset: 0x15D68B0 VA: 0x15DA8B0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x15DA9C4 Offset: 0x15D69C4 VA: 0x15DA9C4
	public bool get_FormatDefaultValues() { }

	[CompilerGenerated]
	// RVA: 0x15DA9CC Offset: 0x15D69CC VA: 0x15DA9CC
	public TypeRegistry get_TypeRegistry() { }

	[CompilerGenerated]
	// RVA: 0x15DA9D4 Offset: 0x15D69D4 VA: 0x15DA9D4
	public bool get_FormatEnumsAsIntegers() { }

	[CompilerGenerated]
	// RVA: 0x15DA9DC Offset: 0x15D69DC VA: 0x15DA9DC
	public bool get_PreserveProtoFieldNames() { }

	[CompilerGenerated]
	// RVA: 0x15DA9E4 Offset: 0x15D69E4 VA: 0x15DA9E4
	public string get_Indentation() { }

	// RVA: 0x15DA918 Offset: 0x15D6918 VA: 0x15DA918
	public void .ctor(bool formatDefaultValues) { }

	// RVA: 0x15DA9EC Offset: 0x15D69EC VA: 0x15DA9EC
	public void .ctor(bool formatDefaultValues, TypeRegistry typeRegistry) { }

	// RVA: 0x15DA9FC Offset: 0x15D69FC VA: 0x15DA9FC
	private void .ctor(bool formatDefaultValues, TypeRegistry typeRegistry, bool formatEnumsAsIntegers, bool preserveProtoFieldNames, string indentation) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class JsonFormatter.OriginalEnumValueHelper.<>c // TypeDefIndex: 6331
{
	// Fields
	public static readonly JsonFormatter.OriginalEnumValueHelper.<>c <>9; // 0x0
	public static Func<Type, Dictionary<object, string>> <>9__1_0; // 0x8
	public static Func<FieldInfo, bool> <>9__2_0; // 0x10
	public static Func<FieldInfo, bool> <>9__2_1; // 0x18
	public static Func<FieldInfo, object> <>9__2_2; // 0x20
	public static Func<FieldInfo, string> <>9__2_3; // 0x28

	// Methods

	// RVA: 0x15DAEB0 Offset: 0x15D6EB0 VA: 0x15DAEB0
	private static void .cctor() { }

	// RVA: 0x15DAF18 Offset: 0x15D6F18 VA: 0x15DAF18
	public void .ctor() { }

	// RVA: 0x15DAF20 Offset: 0x15D6F20 VA: 0x15DAF20
	internal Dictionary<object, string> <GetOriginalName>b__1_0(Type t) { }

	// RVA: 0x15DAF74 Offset: 0x15D6F74 VA: 0x15DAF74
	internal bool <GetNameMapping>b__2_0(FieldInfo f) { }

	// RVA: 0x15DAF8C Offset: 0x15D6F8C VA: 0x15DAF8C
	internal bool <GetNameMapping>b__2_1(FieldInfo f) { }

	// RVA: 0x15DB014 Offset: 0x15D7014 VA: 0x15DB014
	internal object <GetNameMapping>b__2_2(FieldInfo f) { }

	// RVA: 0x15DB038 Offset: 0x15D7038 VA: 0x15DB038
	internal string <GetNameMapping>b__2_3(FieldInfo f) { }
}

// Namespace: 
private static class JsonFormatter.OriginalEnumValueHelper // TypeDefIndex: 6332
{
	// Fields
	private static readonly ConcurrentDictionary<Type, Dictionary<object, string>> dictionaries; // 0x0

	// Methods

	[UnconditionalSuppressMessage("Trimming", "IL2072", Justification = "The field for the value must still be present. It will be returned by reflection, will be in this collection, and its name can be resolved.")]
	[UnconditionalSuppressMessage("Trimming", "IL2067", Justification = "The field for the value must still be present. It will be returned by reflection, will be in this collection, and its name can be resolved.")]
	// RVA: 0x15D7DF0 Offset: 0x15D3DF0 VA: 0x15D7DF0
	internal static string GetOriginalName(object value) { }

	// RVA: 0x15DAAEC Offset: 0x15D6AEC VA: 0x15DAAEC
	private static Dictionary<object, string> GetNameMapping(Type enumType) { }

	// RVA: 0x15DAE18 Offset: 0x15D6E18 VA: 0x15DAE18
	private static void .cctor() { }
}

// Namespace: Google.Protobuf
public sealed class JsonFormatter // TypeDefIndex: 6333
{
	// Fields
	[CompilerGenerated]
	private static readonly JsonFormatter <Default>k__BackingField; // 0x0
	private static readonly JsonFormatter diagnosticFormatter; // 0x8
	private static readonly string[] CommonRepresentations; // 0x10
	private readonly JsonFormatter.Settings settings; // 0x10

	// Properties
	public static JsonFormatter Default { get; }
	private bool DiagnosticOnly { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x15D3598 Offset: 0x15CF598 VA: 0x15D3598
	public static JsonFormatter get_Default() { }

	// RVA: 0x15D35F0 Offset: 0x15CF5F0 VA: 0x15D35F0
	private static void .cctor() { }

	// RVA: 0x15D4FFC Offset: 0x15D0FFC VA: 0x15D4FFC
	private bool get_DiagnosticOnly() { }

	// RVA: 0x15D4F74 Offset: 0x15D0F74 VA: 0x15D4F74
	public void .ctor(JsonFormatter.Settings settings) { }

	// RVA: 0x15D5060 Offset: 0x15D1060 VA: 0x15D5060
	public string Format(IMessage message) { }

	// RVA: 0x15D5068 Offset: 0x15D1068 VA: 0x15D5068
	public string Format(IMessage message, int indentationLevel) { }

	// RVA: 0x15D50F4 Offset: 0x15D10F4 VA: 0x15D50F4
	public void Format(IMessage message, TextWriter writer, int indentationLevel) { }

	// RVA: 0x15D5A24 Offset: 0x15D1A24 VA: 0x15D5A24
	public static string ToDiagnosticString(IMessage message) { }

	// RVA: 0x15D58A0 Offset: 0x15D18A0 VA: 0x15D58A0
	private void WriteMessage(TextWriter writer, IMessage message, int indentationLevel) { }

	// RVA: 0x15D5B9C Offset: 0x15D1B9C VA: 0x15D5B9C
	private bool WriteMessageFields(TextWriter writer, IMessage message, bool assumeFirstFieldWritten, int indentationLevel) { }

	// RVA: 0x15D63A4 Offset: 0x15D23A4 VA: 0x15D63A4
	private void MaybeWriteValueSeparator(TextWriter writer, bool first) { }

	// RVA: 0x15D6274 Offset: 0x15D2274 VA: 0x15D6274
	private bool ShouldFormatFieldValue(IMessage message, FieldDescriptor field, object value) { }

	// RVA: 0x15D72B8 Offset: 0x15D32B8 VA: 0x15D72B8
	internal static string ToJsonName(string name) { }

	// RVA: 0x15D5AD0 Offset: 0x15D1AD0 VA: 0x15D5AD0
	private static void WriteNull(TextWriter writer) { }

	// RVA: 0x15D6E90 Offset: 0x15D2E90 VA: 0x15D6E90
	private static bool IsDefaultValue(FieldDescriptor descriptor, object value) { }

	// RVA: 0x15D73D0 Offset: 0x15D33D0 VA: 0x15D73D0
	public void WriteValue(TextWriter writer, object value) { }

	// RVA: 0x15D67E0 Offset: 0x15D27E0 VA: 0x15D67E0
	public void WriteValue(TextWriter writer, object value, int indentationLevel) { }

	// RVA: 0x15D52D4 Offset: 0x15D12D4 VA: 0x15D52D4
	private void WriteWellKnownTypeValue(TextWriter writer, MessageDescriptor descriptor, object value, int indentationLevel) { }

	// RVA: 0x15D7F7C Offset: 0x15D3F7C VA: 0x15D7F7C
	private void WriteTimestamp(TextWriter writer, IMessage value) { }

	// RVA: 0x15D8368 Offset: 0x15D4368 VA: 0x15D8368
	private void WriteDuration(TextWriter writer, IMessage value) { }

	// RVA: 0x15D8750 Offset: 0x15D4750 VA: 0x15D8750
	private void WriteFieldMask(TextWriter writer, IMessage value) { }

	// RVA: 0x15D9698 Offset: 0x15D5698 VA: 0x15D9698
	private void WriteAny(TextWriter writer, IMessage value, int indentationLevel) { }

	// RVA: 0x15DA1F8 Offset: 0x15D61F8 VA: 0x15DA1F8
	private static void WriteDiagnosticOnlyAny(TextWriter writer, IMessage value) { }

	// RVA: 0x15D8A38 Offset: 0x15D4A38 VA: 0x15D8A38
	private void WriteStruct(TextWriter writer, IMessage message, int indentationLevel) { }

	// RVA: 0x15D915C Offset: 0x15D515C VA: 0x15D915C
	private void WriteStructFieldValue(TextWriter writer, IMessage message, int indentationLevel) { }

	// RVA: 0x15D7ABC Offset: 0x15D3ABC VA: 0x15D7ABC
	internal void WriteList(TextWriter writer, IList list, int indentationLevel = 0) { }

	// RVA: 0x15D73D8 Offset: 0x15D33D8 VA: 0x15D73D8
	internal void WriteDictionary(TextWriter writer, IDictionary dictionary, int indentationLevel = 0) { }

	// RVA: 0x15D64B0 Offset: 0x15D24B0 VA: 0x15D64B0
	internal static void WriteString(TextWriter writer, string text) { }

	// RVA: 0x15DA6D8 Offset: 0x15D66D8 VA: 0x15DA6D8
	private static void HexEncodeUtf16CodeUnit(TextWriter writer, char c) { }

	// RVA: 0x15D5B2C Offset: 0x15D1B2C VA: 0x15D5B2C
	private void WriteBracketOpen(TextWriter writer, char openChar) { }

	// RVA: 0x15D6198 Offset: 0x15D2198 VA: 0x15D6198
	private void WriteBracketClose(TextWriter writer, char closeChar, bool hasFields, int indentationLevel) { }

	// RVA: 0x15D644C Offset: 0x15D244C VA: 0x15D644C
	private void MaybeWriteValueWhitespace(TextWriter writer, int indentationLevel) { }

	// RVA: 0x15DA800 Offset: 0x15D6800 VA: 0x15DA800
	private void WriteIndentation(TextWriter writer, int indentationLevel) { }
}

// Namespace: Google.Protobuf
[Extension]
public static class MessageExtensions // TypeDefIndex: 6334
{
	// Methods

	[Extension]
	// RVA: 0x15D30E4 Offset: 0x15CF0E4 VA: 0x15D30E4
	public static void MergeFrom(IMessage message, ByteString data) { }

	[Extension]
	// RVA: 0x15DB23C Offset: 0x15D723C VA: 0x15DB23C
	public static byte[] ToByteArray(IMessage message) { }

	[Extension]
	// RVA: 0x15D3040 Offset: 0x15CF040 VA: 0x15D3040
	public static ByteString ToByteString(IMessage message) { }

	[Extension]
	// RVA: 0x15DB3E8 Offset: 0x15D73E8 VA: 0x15DB3E8
	internal static void MergeFrom(IMessage message, byte[] data, bool discardUnknownFields, ExtensionRegistry registry) { }

	[Extension]
	// RVA: 0x15DB0D8 Offset: 0x15D70D8 VA: 0x15DB0D8
	internal static void MergeFrom(IMessage message, ByteString data, bool discardUnknownFields, ExtensionRegistry registry) { }
}

// Namespace: Google.Protobuf
public class MessageParser // TypeDefIndex: 6335
{
	// Fields
	private readonly Func<IMessage> factory; // 0x10
	[CompilerGenerated]
	private readonly bool <DiscardUnknownFields>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly ExtensionRegistry <Extensions>k__BackingField; // 0x20

	// Properties
	internal bool DiscardUnknownFields { get; }
	internal ExtensionRegistry Extensions { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x15DB570 Offset: 0x15D7570 VA: 0x15DB570
	internal bool get_DiscardUnknownFields() { }

	[CompilerGenerated]
	// RVA: 0x15DB578 Offset: 0x15D7578 VA: 0x15DB578
	internal ExtensionRegistry get_Extensions() { }

	// RVA: 0x15DB580 Offset: 0x15D7580 VA: 0x15DB580
	internal void .ctor(Func<IMessage> factory, bool discardUnknownFields, ExtensionRegistry extensions) { }

	// RVA: 0x15D3020 Offset: 0x15CF020 VA: 0x15D3020
	internal IMessage CreateTemplate() { }

	// RVA: 0x15D30F0 Offset: 0x15CF0F0 VA: 0x15D30F0
	public IMessage ParseFrom(ByteString data) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MessageParser.<>c__DisplayClass2_0<T> // TypeDefIndex: 6336
{
	// Fields
	public Func<T> factory; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1157524 Offset: 0x1153524 VA: 0x1157524
	|-MessageParser.<>c__DisplayClass2_0<object>..ctor
	|
	|-RVA: 0x115754C Offset: 0x115354C VA: 0x115754C
	|-MessageParser.<>c__DisplayClass2_0<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal IMessage <.ctor>b__0() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x115752C Offset: 0x115352C VA: 0x115752C
	|-MessageParser.<>c__DisplayClass2_0<object>.<.ctor>b__0
	|
	|-RVA: 0x1157554 Offset: 0x1153554 VA: 0x1157554
	|-MessageParser.<>c__DisplayClass2_0<__Il2CppFullySharedGenericType>.<.ctor>b__0
	*/
}

// Namespace: Google.Protobuf
public sealed class MessageParser<T> : MessageParser // TypeDefIndex: 6337
{
	// Fields
	private readonly Func<T> factory; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Func<T> factory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D14F0 Offset: 0x13CD4F0 VA: 0x13D14F0
	|-MessageParser<object>..ctor
	|
	|-RVA: 0x13D16F8 Offset: 0x13CD6F8 VA: 0x13D16F8
	|-MessageParser<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(Func<T> factory, bool discardUnknownFields, ExtensionRegistry extensions) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D1508 Offset: 0x13CD508 VA: 0x13D1508
	|-MessageParser<object>..ctor
	|
	|-RVA: 0x13D1714 Offset: 0x13CD714 VA: 0x13D1714
	|-MessageParser<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal T CreateTemplate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D1608 Offset: 0x13CD608 VA: 0x13D1608
	|-MessageParser<object>.CreateTemplate
	|
	|-RVA: 0x13D1818 Offset: 0x13CD818 VA: 0x13D1818
	|-MessageParser<__Il2CppFullySharedGenericType>.CreateTemplate
	*/

	// RVA: -1 Offset: -1
	public T ParseFrom(byte[] data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D1628 Offset: 0x13CD628 VA: 0x13D1628
	|-MessageParser<object>.ParseFrom
	|
	|-RVA: 0x13D18D0 Offset: 0x13CD8D0 VA: 0x13D18D0
	|-MessageParser<__Il2CppFullySharedGenericType>.ParseFrom
	*/

	// RVA: -1 Offset: -1
	public MessageParser<T> WithExtensionRegistry(ExtensionRegistry registry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13D167C Offset: 0x13CD67C VA: 0x13D167C
	|-MessageParser<object>.WithExtensionRegistry
	|
	|-RVA: 0x13D19E8 Offset: 0x13CD9E8 VA: 0x13D19E8
	|-MessageParser<__Il2CppFullySharedGenericType>.WithExtensionRegistry
	*/
}

// Namespace: Google.Protobuf
internal struct ObjectIntPair<T> : IEquatable<ObjectIntPair<T>> // TypeDefIndex: 6338
{
	// Fields
	private readonly int number; // 0x0
	private readonly T obj; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(T obj, int number) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD30C Offset: 0x13F930C VA: 0x13FD30C
	|-ObjectIntPair<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public bool Equals(ObjectIntPair<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD318 Offset: 0x13F9318 VA: 0x13FD318
	|-ObjectIntPair<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD33C Offset: 0x13F933C VA: 0x13FD33C
	|-ObjectIntPair<object>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13FD430 Offset: 0x13F9430 VA: 0x13FD430
	|-ObjectIntPair<object>.GetHashCode
	*/
}

// Namespace: Google.Protobuf
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct ParseContext // TypeDefIndex: 6339
{
	// Fields
	internal ReadOnlySpan<byte> buffer; // 0x0
	internal ParserInternalState state; // 0x10

	// Properties
	internal uint LastTag { get; }
	internal bool DiscardUnknownFields { get; }
	internal ExtensionRegistry ExtensionRegistry { get; }

	// Methods

	// RVA: 0x15DB5D4 Offset: 0x15D75D4 VA: 0x15DB5D4
	internal static void Initialize(CodedInputStream input, out ParseContext ctx) { }

	// RVA: 0x15DB650 Offset: 0x15D7650 VA: 0x15DB650
	internal static void Initialize(ReadOnlySequence<byte> input, out ParseContext ctx) { }

	// RVA: 0x15DB704 Offset: 0x15D7704 VA: 0x15DB704
	internal static void Initialize(ReadOnlySequence<byte> input, int recursionLimit, out ParseContext ctx) { }

	// RVA: 0x15DB7B0 Offset: 0x15D77B0 VA: 0x15DB7B0
	internal uint get_LastTag() { }

	// RVA: 0x15DB7B8 Offset: 0x15D77B8 VA: 0x15DB7B8
	internal bool get_DiscardUnknownFields() { }

	// RVA: 0x15DB7C0 Offset: 0x15D77C0 VA: 0x15DB7C0
	internal ExtensionRegistry get_ExtensionRegistry() { }

	// RVA: 0x15DB7C8 Offset: 0x15D77C8 VA: 0x15DB7C8
	public uint ReadTag() { }

	// RVA: 0x15DB964 Offset: 0x15D7964 VA: 0x15DB964
	public double ReadDouble() { }

	// RVA: 0x15DBAC0 Offset: 0x15D7AC0 VA: 0x15DBAC0
	public ulong ReadUInt64() { }

	// RVA: 0x15DBC24 Offset: 0x15D7C24 VA: 0x15DBC24
	public long ReadInt64() { }

	// RVA: 0x15DBC7C Offset: 0x15D7C7C VA: 0x15DBC7C
	public int ReadInt32() { }

	// RVA: 0x15DBE8C Offset: 0x15D7E8C VA: 0x15DBE8C
	public ulong ReadFixed64() { }

	// RVA: 0x15DC02C Offset: 0x15D802C VA: 0x15DC02C
	public uint ReadFixed32() { }

	// RVA: 0x15DC1CC Offset: 0x15D81CC VA: 0x15DC1CC
	public bool ReadBool() { }

	// RVA: 0x15DC230 Offset: 0x15D8230 VA: 0x15DC230
	public string ReadString() { }

	// RVA: 0x15DC2F8 Offset: 0x15D82F8 VA: 0x15DC2F8
	public void ReadMessage(IMessage message) { }

	// RVA: 0x15DC4D4 Offset: 0x15D84D4 VA: 0x15DC4D4
	public ByteString ReadBytes() { }

	// RVA: 0x15DC530 Offset: 0x15D8530 VA: 0x15DC530
	public uint ReadUInt32() { }

	// RVA: 0x15DC588 Offset: 0x15D8588 VA: 0x15DC588
	public int ReadEnum() { }

	// RVA: 0x15DC5E0 Offset: 0x15D85E0 VA: 0x15DC5E0
	public int ReadLength() { }

	// RVA: 0x15DC638 Offset: 0x15D8638 VA: 0x15DC638
	internal void CopyStateTo(CodedInputStream input) { }

	// RVA: 0x15DC66C Offset: 0x15D866C VA: 0x15DC66C
	internal void LoadStateFrom(CodedInputStream input) { }
}

// Namespace: Google.Protobuf
internal struct ParserInternalState // TypeDefIndex: 6340
{
	// Fields
	internal int bufferPos; // 0x0
	internal int bufferSize; // 0x4
	internal int bufferSizeAfterLimit; // 0x8
	internal int currentLimit; // 0xC
	internal int totalBytesRetired; // 0x10
	internal int recursionDepth; // 0x14
	internal SegmentedBufferHelper segmentedBufferHelper; // 0x18
	internal uint lastTag; // 0x60
	internal uint nextTag; // 0x64
	internal bool hasNextTag; // 0x68
	internal int sizeLimit; // 0x6C
	internal int recursionLimit; // 0x70
	[CompilerGenerated]
	private bool <DiscardUnknownFields>k__BackingField; // 0x74
	[CompilerGenerated]
	private ExtensionRegistry <ExtensionRegistry>k__BackingField; // 0x78

	// Properties
	internal CodedInputStream CodedInputStream { get; }
	internal bool DiscardUnknownFields { get; set; }
	internal ExtensionRegistry ExtensionRegistry { get; set; }

	// Methods

	// RVA: 0x15DC69C Offset: 0x15D869C VA: 0x15DC69C
	internal CodedInputStream get_CodedInputStream() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x15DC6A4 Offset: 0x15D86A4 VA: 0x15DC6A4
	internal bool get_DiscardUnknownFields() { }

	[CompilerGenerated]
	// RVA: 0x15DC6AC Offset: 0x15D86AC VA: 0x15DC6AC
	internal void set_DiscardUnknownFields(bool value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x15DC6B4 Offset: 0x15D86B4 VA: 0x15DC6B4
	internal ExtensionRegistry get_ExtensionRegistry() { }

	[CompilerGenerated]
	// RVA: 0x15DC6BC Offset: 0x15D86BC VA: 0x15DC6BC
	internal void set_ExtensionRegistry(ExtensionRegistry value) { }
}

// Namespace: Google.Protobuf
internal static class ParsingPrimitives // TypeDefIndex: 6341
{
	// Fields
	internal static readonly Encoding Utf8Encoding; // 0x0

	// Methods

	// RVA: 0x15DC6C4 Offset: 0x15D86C4 VA: 0x15DC6C4
	public static int ParseLength(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DB820 Offset: 0x15D7820 VA: 0x15DB820
	public static uint ParseTag(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DC728 Offset: 0x15D8728 VA: 0x15DC728
	public static bool MaybeConsumeTag(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, uint tag) { }

	// RVA: 0x15DC7A8 Offset: 0x15D87A8 VA: 0x15DC7A8
	public static uint PeekTag(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DBB18 Offset: 0x15D7B18 VA: 0x15DBB18
	public static ulong ParseRawVarint64(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DC828 Offset: 0x15D8828 VA: 0x15DC828
	private static ulong ParseRawVarint64SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DBCD4 Offset: 0x15D7CD4 VA: 0x15DBCD4
	public static uint ParseRawVarint32(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DC944 Offset: 0x15D8944 VA: 0x15DC944
	private static uint ParseRawVarint32SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DC084 Offset: 0x15D8084 VA: 0x15DC084
	public static uint ParseRawLittleEndian32(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DCAC0 Offset: 0x15D8AC0 VA: 0x15DCAC0
	private static uint ParseRawLittleEndian32SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DBEE4 Offset: 0x15D7EE4 VA: 0x15DBEE4
	public static ulong ParseRawLittleEndian64(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DCB68 Offset: 0x15D8B68 VA: 0x15DCB68
	private static ulong ParseRawLittleEndian64SlowPath(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DB9BC Offset: 0x15D79BC VA: 0x15DB9BC
	public static double ParseDouble(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DCC70 Offset: 0x15D8C70 VA: 0x15DCC70
	public static byte[] ReadRawBytes(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size) { }

	// RVA: 0x15DCE1C Offset: 0x15D8E1C VA: 0x15DCE1C
	private static byte[] ReadRawBytesSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size) { }

	// RVA: 0x15DD6B4 Offset: 0x15D96B4 VA: 0x15DD6B4
	public static void SkipRawBytes(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size) { }

	// RVA: 0x15DD7B4 Offset: 0x15D97B4 VA: 0x15DD7B4
	public static string ReadString(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DDA6C Offset: 0x15D9A6C VA: 0x15DDA6C
	public static ByteString ReadBytes(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DD858 Offset: 0x15D9858 VA: 0x15DD858
	public static string ReadRawString(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int length) { }

	// RVA: 0x15DDB44 Offset: 0x15D9B44 VA: 0x15DDB44
	private static string ReadStringSlow(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int length) { }

	// RVA: 0x15DD390 Offset: 0x15D9390 VA: 0x15DD390
	private static void ValidateCurrentLimit(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int size) { }

	// RVA: 0x15DC8E4 Offset: 0x15D88E4 VA: 0x15DC8E4
	private static byte ReadRawByte(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DE110 Offset: 0x15DA110 VA: 0x15DE110
	public static bool IsDataAvailable(ref ParserInternalState state, int size) { }

	// RVA: 0x15DD40C Offset: 0x15D940C VA: 0x15DD40C
	private static bool IsDataAvailableInSource(ref ParserInternalState state, int size) { }

	// RVA: 0x15DD4DC Offset: 0x15D94DC VA: 0x15DD4DC
	private static void ReadRawBytesIntoSpan(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int length, Span<byte> byteSpan) { }

	// RVA: 0x15DE18C Offset: 0x15DA18C VA: 0x15DE18C
	internal static void ReadPackedFieldLittleEndian(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, int length, Span<byte> outBuffer) { }

	// RVA: 0x15DE2D4 Offset: 0x15DA2D4 VA: 0x15DE2D4
	private static void .cctor() { }
}

// Namespace: Google.Protobuf
internal static class ParsingPrimitivesMessages // TypeDefIndex: 6342
{
	// Fields
	private static readonly byte[] ZeroLengthMessageStreamData; // 0x0

	// Methods

	// RVA: 0x15DE358 Offset: 0x15DA358 VA: 0x15DE358
	public static void SkipLastField(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DE59C Offset: 0x15DA59C VA: 0x15DE59C
	public static void SkipGroup(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, uint startGroupTag) { }

	// RVA: 0x15DC35C Offset: 0x15D835C VA: 0x15DC35C
	public static void ReadMessage(ref ParseContext ctx, IMessage message) { }

	// RVA: -1 Offset: -1
	public static KeyValuePair<TKey, TValue> ReadMapEntry<TKey, TValue>(ref ParseContext ctx, MapField.Codec<TKey, TValue> codec) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113A858 Offset: 0x1136858 VA: 0x113A858
	|-ParsingPrimitivesMessages.ReadMapEntry<int, object>
	|
	|-RVA: 0x113AC4C Offset: 0x1136C4C VA: 0x113AC4C
	|-ParsingPrimitivesMessages.ReadMapEntry<object, object>
	|
	|-RVA: 0x113B040 Offset: 0x1137040 VA: 0x113B040
	|-ParsingPrimitivesMessages.ReadMapEntry<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15DE810 Offset: 0x15DA810 VA: 0x15DE810
	public static void ReadGroup(ref ParseContext ctx, int fieldNumber, UnknownFieldSet set) { }

	// RVA: 0x15CE7F4 Offset: 0x15CA7F4 VA: 0x15CE7F4
	public static void ReadRawMessage(ref ParseContext ctx, IMessage message) { }

	// RVA: 0x15CE654 Offset: 0x15CA654 VA: 0x15CE654
	public static void CheckReadEndOfStreamTag(ref ParserInternalState state) { }

	// RVA: 0x15DE950 Offset: 0x15DA950 VA: 0x15DE950
	private static void CheckLastTagWas(ref ParserInternalState state, uint expectedTag) { }

	// RVA: 0x15DE984 Offset: 0x15DA984 VA: 0x15DE984
	private static void .cctor() { }
}

// Namespace: Google.Protobuf
public static class ProtoPreconditions // TypeDefIndex: 6343
{
	// Methods

	// RVA: -1 Offset: -1
	public static T CheckNotNull<T>(T value, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113CC74 Offset: 0x1138C74 VA: 0x113CC74
	|-ProtoPreconditions.CheckNotNull<object>
	*/

	// RVA: -1 Offset: -1
	internal static T CheckNotNullUnconstrained<T>(T value, string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113CCB8 Offset: 0x1138CB8 VA: 0x113CCB8
	|-ProtoPreconditions.CheckNotNullUnconstrained<int>
	|
	|-RVA: 0x113CCBC Offset: 0x1138CBC VA: 0x113CCBC
	|-ProtoPreconditions.CheckNotNullUnconstrained<Int32Enum>
	|
	|-RVA: 0x113CCC0 Offset: 0x1138CC0 VA: 0x113CCC0
	|-ProtoPreconditions.CheckNotNullUnconstrained<long>
	|
	|-RVA: 0x113CCC4 Offset: 0x1138CC4 VA: 0x113CCC4
	|-ProtoPreconditions.CheckNotNullUnconstrained<object>
	|
	|-RVA: 0x113CD08 Offset: 0x1138D08 VA: 0x113CD08
	|-ProtoPreconditions.CheckNotNullUnconstrained<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: Google.Protobuf
internal struct SegmentedBufferHelper // TypeDefIndex: 6344
{
	// Fields
	private Nullable<int> totalLength; // 0x0
	private ReadOnlySequence.Enumerator<byte> readOnlySequenceEnumerator; // 0x8
	private CodedInputStream codedInputStream; // 0x40

	// Properties
	public Nullable<int> TotalLength { get; }
	public CodedInputStream CodedInputStream { get; }

	// Methods

	// RVA: 0x15DE9F8 Offset: 0x15DA9F8 VA: 0x15DE9F8
	public static void Initialize(CodedInputStream codedInputStream, out SegmentedBufferHelper instance) { }

	// RVA: 0x15DEAA4 Offset: 0x15DAAA4 VA: 0x15DEAA4
	public static void Initialize(ReadOnlySequence<byte> sequence, out SegmentedBufferHelper instance, out ReadOnlySpan<byte> firstSpan) { }

	// RVA: 0x15DD69C Offset: 0x15D969C VA: 0x15DD69C
	public bool RefillBuffer(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, bool mustSucceed) { }

	// RVA: 0x15DEFA4 Offset: 0x15DAFA4 VA: 0x15DEFA4
	public Nullable<int> get_TotalLength() { }

	// RVA: 0x15DEFAC Offset: 0x15DAFAC VA: 0x15DEFAC
	public CodedInputStream get_CodedInputStream() { }

	// RVA: 0x15DE734 Offset: 0x15DA734 VA: 0x15DE734
	public static int PushLimit(ref ParserInternalState state, int byteLimit) { }

	// RVA: 0x15DE7D8 Offset: 0x15DA7D8 VA: 0x15DE7D8
	public static void PopLimit(ref ParserInternalState state, int oldLimit) { }

	// RVA: 0x15DE7A8 Offset: 0x15DA7A8 VA: 0x15DE7A8
	public static bool IsReachedLimit(ref ParserInternalState state) { }

	// RVA: 0x15DEFE8 Offset: 0x15DAFE8 VA: 0x15DEFE8
	public static bool IsAtEnd(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state) { }

	// RVA: 0x15DEE30 Offset: 0x15DAE30 VA: 0x15DEE30
	private bool RefillFromReadOnlySequence(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, bool mustSucceed) { }

	// RVA: 0x15DECCC Offset: 0x15DACCC VA: 0x15DECCC
	private bool RefillFromCodedInputStream(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, bool mustSucceed) { }

	// RVA: 0x15DEFB4 Offset: 0x15DAFB4 VA: 0x15DEFB4
	private static void RecomputeBufferSizeAfterLimit(ref ParserInternalState state) { }

	// RVA: 0x15DF024 Offset: 0x15DB024 VA: 0x15DF024
	private static void CheckCurrentBufferIsEmpty(ref ParserInternalState state) { }
}

// Namespace: Google.Protobuf
internal sealed class UnknownField // TypeDefIndex: 6345
{
	// Fields
	private List<ulong> varintList; // 0x10
	private List<uint> fixed32List; // 0x18
	private List<ulong> fixed64List; // 0x20
	private List<ByteString> lengthDelimitedList; // 0x28
	private List<UnknownFieldSet> groupList; // 0x30

	// Methods

	// RVA: 0x15DF080 Offset: 0x15DB080 VA: 0x15DF080
	public void .ctor() { }

	// RVA: 0x15DF088 Offset: 0x15DB088 VA: 0x15DF088 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x15DF1AC Offset: 0x15DB1AC VA: 0x15DF1AC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15DF2B4 Offset: 0x15DB2B4 VA: 0x15DF2B4
	internal void WriteTo(int fieldNumber, ref WriteContext output) { }

	// RVA: 0x15DFCE8 Offset: 0x15DBCE8 VA: 0x15DFCE8
	internal int GetSerializedSize(int fieldNumber) { }

	// RVA: 0x15E0464 Offset: 0x15DC464 VA: 0x15E0464
	internal UnknownField MergeFrom(UnknownField other) { }

	// RVA: -1 Offset: -1
	private static List<T> AddAll<T>(List<T> current, IList<T> extras) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103BC30 Offset: 0x1037C30 VA: 0x103BC30
	|-UnknownField.AddAll<object>
	|
	|-RVA: 0x103BD28 Offset: 0x1037D28 VA: 0x103BD28
	|-UnknownField.AddAll<uint>
	|
	|-RVA: 0x103BE20 Offset: 0x1037E20 VA: 0x103BE20
	|-UnknownField.AddAll<ulong>
	|
	|-RVA: 0x103BF18 Offset: 0x1037F18 VA: 0x103BF18
	|-UnknownField.AddAll<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x15E05B4 Offset: 0x15DC5B4 VA: 0x15E05B4
	internal UnknownField AddVarint(ulong value) { }

	// RVA: 0x15E0628 Offset: 0x15DC628 VA: 0x15E0628
	internal UnknownField AddFixed32(uint value) { }

	// RVA: 0x15E069C Offset: 0x15DC69C VA: 0x15E069C
	internal UnknownField AddFixed64(ulong value) { }

	// RVA: 0x15E0710 Offset: 0x15DC710 VA: 0x15E0710
	internal UnknownField AddLengthDelimited(ByteString value) { }

	// RVA: 0x15E0784 Offset: 0x15DC784 VA: 0x15E0784
	internal UnknownField AddGroup(UnknownFieldSet value) { }

	// RVA: -1 Offset: -1
	private static List<T> Add<T>(List<T> list, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103B870 Offset: 0x1037870 VA: 0x103B870
	|-UnknownField.Add<object>
	|
	|-RVA: 0x103B944 Offset: 0x1037944 VA: 0x103B944
	|-UnknownField.Add<uint>
	|
	|-RVA: 0x103BA10 Offset: 0x1037A10 VA: 0x103BA10
	|-UnknownField.Add<ulong>
	|
	|-RVA: 0x103BADC Offset: 0x1037ADC VA: 0x103BADC
	|-UnknownField.Add<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
private sealed class UnknownFieldSet.UnknownFieldSetDebugView // TypeDefIndex: 6346
{}

// Namespace: Google.Protobuf
[DebuggerDisplay("Count = {fields.Count}")]
[DebuggerTypeProxy(typeof(UnknownFieldSet.UnknownFieldSetDebugView))]
public sealed class UnknownFieldSet // TypeDefIndex: 6347
{
	// Fields
	private readonly IDictionary<int, UnknownField> fields; // 0x10
	private int lastFieldNumber; // 0x18
	private UnknownField lastField; // 0x20

	// Methods

	// RVA: 0x15E07F8 Offset: 0x15DC7F8 VA: 0x15E07F8
	internal void .ctor() { }

	// RVA: 0x15E0880 Offset: 0x15DC880 VA: 0x15E0880
	internal bool HasField(int field) { }

	// RVA: 0x15DFA18 Offset: 0x15DBA18 VA: 0x15DFA18
	public void WriteTo(ref WriteContext ctx) { }

	// RVA: 0x15E0184 Offset: 0x15DC184 VA: 0x15E0184
	public int CalculateSize() { }

	// RVA: 0x15E092C Offset: 0x15DC92C VA: 0x15E092C Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x15E0DBC Offset: 0x15DCDBC VA: 0x15E0DBC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15E10C0 Offset: 0x15DD0C0 VA: 0x15E10C0
	private UnknownField GetOrAddField(int number) { }

	// RVA: 0x15E1200 Offset: 0x15DD200 VA: 0x15E1200
	internal UnknownFieldSet AddOrReplaceField(int number, UnknownField field) { }

	// RVA: 0x15E1324 Offset: 0x15DD324 VA: 0x15E1324
	private bool MergeFieldFrom(ref ParseContext ctx) { }

	// RVA: 0x15DE8D8 Offset: 0x15DA8D8 VA: 0x15DE8D8
	internal void MergeGroupFrom(ref ParseContext ctx) { }

	// RVA: 0x15E15D0 Offset: 0x15DD5D0 VA: 0x15E15D0
	public static UnknownFieldSet MergeFieldFrom(UnknownFieldSet unknownFields, ref ParseContext ctx) { }

	// RVA: 0x15E16C4 Offset: 0x15DD6C4 VA: 0x15E16C4
	private UnknownFieldSet MergeFrom(UnknownFieldSet other) { }

	// RVA: 0x15E1A50 Offset: 0x15DDA50 VA: 0x15E1A50
	public static UnknownFieldSet MergeFrom(UnknownFieldSet unknownFields, UnknownFieldSet other) { }

	// RVA: 0x15E1994 Offset: 0x15DD994 VA: 0x15E1994
	private UnknownFieldSet MergeField(int number, UnknownField field) { }

	// RVA: 0x15E1AC4 Offset: 0x15DDAC4 VA: 0x15E1AC4
	public static UnknownFieldSet Clone(UnknownFieldSet other) { }
}

// Namespace: 
public enum WireFormat.WireType // TypeDefIndex: 6348
{
	// Fields
	public uint value__; // 0x0
	public const WireFormat.WireType Varint = 0;
	public const WireFormat.WireType Fixed64 = 1;
	public const WireFormat.WireType LengthDelimited = 2;
	public const WireFormat.WireType StartGroup = 3;
	public const WireFormat.WireType EndGroup = 4;
	public const WireFormat.WireType Fixed32 = 5;
}

// Namespace: Google.Protobuf
public static class WireFormat // TypeDefIndex: 6349
{
	// Methods

	// RVA: 0x15DE594 Offset: 0x15DA594 VA: 0x15DE594
	public static WireFormat.WireType GetTagWireType(uint tag) { }

	// RVA: 0x15CF8E8 Offset: 0x15CB8E8 VA: 0x15CF8E8
	public static int GetTagFieldNumber(uint tag) { }

	// RVA: 0x15CF0C8 Offset: 0x15CB0C8 VA: 0x15CF0C8
	public static uint MakeTag(int fieldNumber, WireFormat.WireType wireType) { }
}

// Namespace: Google.Protobuf
internal struct WriteBufferHelper // TypeDefIndex: 6350
{
	// Fields
	private IBufferWriter<byte> bufferWriter; // 0x0
	private CodedOutputStream codedOutputStream; // 0x8

	// Properties
	public CodedOutputStream CodedOutputStream { get; }

	// Methods

	// RVA: 0x15E1B38 Offset: 0x15DDB38 VA: 0x15E1B38
	public CodedOutputStream get_CodedOutputStream() { }

	// RVA: 0x15E1B40 Offset: 0x15DDB40 VA: 0x15E1B40
	public static void Initialize(CodedOutputStream codedOutputStream, out WriteBufferHelper instance) { }

	// RVA: 0x15E1B78 Offset: 0x15DDB78 VA: 0x15E1B78
	public static void CheckNoSpaceLeft(ref WriterInternalState state) { }

	// RVA: 0x15E1C2C Offset: 0x15DDC2C VA: 0x15E1C2C
	public static int GetSpaceLeft(ref WriterInternalState state) { }

	// RVA: 0x15E1C9C Offset: 0x15DDC9C VA: 0x15E1C9C
	public static void RefreshBuffer(ref Span<byte> buffer, ref WriterInternalState state) { }

	// RVA: 0x15E1E38 Offset: 0x15DDE38 VA: 0x15E1E38
	public static void Flush(ref Span<byte> buffer, ref WriterInternalState state) { }
}

// Namespace: Google.Protobuf
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct WriteContext // TypeDefIndex: 6351
{
	// Fields
	internal Span<byte> buffer; // 0x0
	internal WriterInternalState state; // 0x10

	// Methods

	// RVA: 0x15E1F28 Offset: 0x15DDF28 VA: 0x15E1F28
	internal static void Initialize(ref Span<byte> buffer, ref WriterInternalState state, out WriteContext ctx) { }

	// RVA: 0x15E1F50 Offset: 0x15DDF50 VA: 0x15E1F50
	public void WriteDouble(double value) { }

	// RVA: 0x15DF878 Offset: 0x15DB878 VA: 0x15DF878
	public void WriteUInt64(ulong value) { }

	// RVA: 0x15D0F84 Offset: 0x15CCF84 VA: 0x15D0F84
	public void WriteInt64(long value) { }

	// RVA: 0x15D0EB8 Offset: 0x15CCEB8 VA: 0x15D0EB8
	public void WriteInt32(int value) { }

	// RVA: 0x15DF948 Offset: 0x15DB948 VA: 0x15DF948
	public void WriteFixed64(ulong value) { }

	// RVA: 0x15DF8E0 Offset: 0x15DB8E0 VA: 0x15DF8E0
	public void WriteFixed32(uint value) { }

	// RVA: 0x15E2270 Offset: 0x15DE270 VA: 0x15E2270
	public void WriteBool(bool value) { }

	// RVA: 0x15D0DEC Offset: 0x15CCDEC VA: 0x15D0DEC
	public void WriteString(string value) { }

	// RVA: 0x15E2540 Offset: 0x15DE540 VA: 0x15E2540
	public void WriteMessage(IMessage value) { }

	// RVA: 0x15DF9B0 Offset: 0x15DB9B0 VA: 0x15DF9B0
	public void WriteBytes(ByteString value) { }

	// RVA: 0x15E25E8 Offset: 0x15DE5E8 VA: 0x15E25E8
	public void WriteUInt32(uint value) { }

	// RVA: 0x15E26BC Offset: 0x15DE6BC VA: 0x15E26BC
	public void WriteEnum(int value) { }

	// RVA: 0x15E2790 Offset: 0x15DE790 VA: 0x15E2790
	public void WriteLength(int length) { }

	// RVA: 0x15DF808 Offset: 0x15DB808 VA: 0x15DF808
	public void WriteTag(int fieldNumber, WireFormat.WireType type) { }

	// RVA: 0x15E28DC Offset: 0x15DE8DC VA: 0x15E28DC
	public void WriteTag(uint tag) { }

	// RVA: 0x15E29B0 Offset: 0x15DE9B0 VA: 0x15E29B0
	public void WriteRawTag(byte b1) { }

	// RVA: 0x15E2A84 Offset: 0x15DEA84 VA: 0x15E2A84
	public void WriteRawTag(byte b1, byte b2) { }

	// RVA: 0x15E2BD8 Offset: 0x15DEBD8 VA: 0x15E2BD8
	internal void CopyStateTo(CodedOutputStream output) { }

	// RVA: 0x15E2C04 Offset: 0x15DEC04 VA: 0x15E2C04
	internal void LoadStateFrom(CodedOutputStream output) { }
}

// Namespace: Google.Protobuf
internal struct WriterInternalState // TypeDefIndex: 6352
{
	// Fields
	internal int limit; // 0x0
	internal int position; // 0x4
	internal WriteBufferHelper writeBufferHelper; // 0x8

	// Properties
	internal CodedOutputStream CodedOutputStream { get; }

	// Methods

	// RVA: 0x15E2C34 Offset: 0x15DEC34 VA: 0x15E2C34
	internal CodedOutputStream get_CodedOutputStream() { }
}

// Namespace: Google.Protobuf
internal static class WritingPrimitives // TypeDefIndex: 6353
{
	// Fields
	internal static readonly Encoding Utf8Encoding; // 0x0

	// Methods

	// RVA: 0x15E1FB8 Offset: 0x15DDFB8 VA: 0x15E1FB8
	public static void WriteDouble(ref Span<byte> buffer, ref WriterInternalState state, double value) { }

	// RVA: 0x15E202C Offset: 0x15DE02C VA: 0x15E202C
	public static void WriteUInt64(ref Span<byte> buffer, ref WriterInternalState state, ulong value) { }

	// RVA: 0x15E2098 Offset: 0x15DE098 VA: 0x15E2098
	public static void WriteInt64(ref Span<byte> buffer, ref WriterInternalState state, long value) { }

	// RVA: 0x15E2104 Offset: 0x15DE104 VA: 0x15E2104
	public static void WriteInt32(ref Span<byte> buffer, ref WriterInternalState state, int value) { }

	// RVA: 0x15E2198 Offset: 0x15DE198 VA: 0x15E2198
	public static void WriteFixed64(ref Span<byte> buffer, ref WriterInternalState state, ulong value) { }

	// RVA: 0x15E2204 Offset: 0x15DE204 VA: 0x15E2204
	public static void WriteFixed32(ref Span<byte> buffer, ref WriterInternalState state, uint value) { }

	// RVA: 0x15E22D8 Offset: 0x15DE2D8 VA: 0x15E22D8
	public static void WriteBool(ref Span<byte> buffer, ref WriterInternalState state, bool value) { }

	// RVA: 0x15E2344 Offset: 0x15DE344 VA: 0x15E2344
	public static void WriteString(ref Span<byte> buffer, ref WriterInternalState state, string value) { }

	// RVA: 0x15E3390 Offset: 0x15DF390 VA: 0x15E3390
	private static void WriteAsciiStringToBuffer(Span<byte> buffer, ref WriterInternalState state, string value, int length) { }

	// RVA: 0x15E363C Offset: 0x15DF63C VA: 0x15E363C
	private static void NarrowFourUtf16CharsToAsciiAndWriteToBuffer(ref byte outputBuffer, ulong value) { }

	// RVA: 0x15E323C Offset: 0x15DF23C VA: 0x15E323C
	private static int WriteStringToBuffer(Span<byte> buffer, ref WriterInternalState state, string value) { }

	// RVA: 0x15E2548 Offset: 0x15DE548 VA: 0x15E2548
	public static void WriteBytes(ref Span<byte> buffer, ref WriterInternalState state, ByteString value) { }

	// RVA: 0x15E2650 Offset: 0x15DE650 VA: 0x15E2650
	public static void WriteUInt32(ref Span<byte> buffer, ref WriterInternalState state, uint value) { }

	// RVA: 0x15E2724 Offset: 0x15DE724 VA: 0x15E2724
	public static void WriteEnum(ref Span<byte> buffer, ref WriterInternalState state, int value) { }

	// RVA: 0x15E27F8 Offset: 0x15DE7F8 VA: 0x15E27F8
	public static void WriteLength(ref Span<byte> buffer, ref WriterInternalState state, int length) { }

	// RVA: 0x15E2EF8 Offset: 0x15DEEF8 VA: 0x15E2EF8
	public static void WriteRawVarint32(ref Span<byte> buffer, ref WriterInternalState state, uint value) { }

	// RVA: 0x15E2DB4 Offset: 0x15DEDB4 VA: 0x15E2DB4
	public static void WriteRawVarint64(ref Span<byte> buffer, ref WriterInternalState state, ulong value) { }

	// RVA: 0x15E303C Offset: 0x15DF03C VA: 0x15E303C
	public static void WriteRawLittleEndian32(ref Span<byte> buffer, ref WriterInternalState state, uint value) { }

	// RVA: 0x15E38E8 Offset: 0x15DF8E8 VA: 0x15E38E8
	private static void WriteRawLittleEndian32SlowPath(ref Span<byte> buffer, ref WriterInternalState state, uint value) { }

	// RVA: 0x15E2C3C Offset: 0x15DEC3C VA: 0x15E2C3C
	public static void WriteRawLittleEndian64(ref Span<byte> buffer, ref WriterInternalState state, ulong value) { }

	// RVA: 0x15E3984 Offset: 0x15DF984 VA: 0x15E3984
	public static void WriteRawLittleEndian64SlowPath(ref Span<byte> buffer, ref WriterInternalState state, ulong value) { }

	// RVA: 0x15E31B4 Offset: 0x15DF1B4 VA: 0x15E31B4
	private static void WriteRawByte(ref Span<byte> buffer, ref WriterInternalState state, byte value) { }

	// RVA: 0x15E35AC Offset: 0x15DF5AC VA: 0x15E35AC
	public static void WriteRawBytes(ref Span<byte> buffer, ref WriterInternalState state, byte[] value) { }

	// RVA: 0x15E365C Offset: 0x15DF65C VA: 0x15E365C
	public static void WriteRawBytes(ref Span<byte> buffer, ref WriterInternalState state, ReadOnlySpan<byte> value) { }

	// RVA: 0x15E2864 Offset: 0x15DE864 VA: 0x15E2864
	public static void WriteTag(ref Span<byte> buffer, ref WriterInternalState state, int fieldNumber, WireFormat.WireType type) { }

	// RVA: 0x15E2944 Offset: 0x15DE944 VA: 0x15E2944
	public static void WriteTag(ref Span<byte> buffer, ref WriterInternalState state, uint tag) { }

	// RVA: 0x15E2A18 Offset: 0x15DEA18 VA: 0x15E2A18
	public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1) { }

	// RVA: 0x15E2AF4 Offset: 0x15DEAF4 VA: 0x15E2AF4
	public static void WriteRawTag(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2) { }

	// RVA: 0x15E3A60 Offset: 0x15DFA60 VA: 0x15E3A60
	private static void WriteRawTagSlowPath(ref Span<byte> buffer, ref WriterInternalState state, byte b1, byte b2) { }

	// RVA: 0x15E3AE8 Offset: 0x15DFAE8 VA: 0x15E3AE8
	private static void .cctor() { }
}

// Namespace: Google.Protobuf
internal static class WritingPrimitivesMessages // TypeDefIndex: 6354
{
	// Methods

	// RVA: 0x15E3B44 Offset: 0x15DFB44 VA: 0x15E3B44
	public static void WriteMessage(ref WriteContext ctx, IMessage value) { }

	// RVA: 0x15E3C34 Offset: 0x15DFC34 VA: 0x15E3C34
	public static void WriteRawMessage(ref WriteContext ctx, IMessage message) { }
}
