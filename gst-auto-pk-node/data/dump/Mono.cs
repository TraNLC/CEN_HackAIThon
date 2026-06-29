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

// Namespace: Mono
[Flags]
internal enum CertificateImportFlags // TypeDefIndex: 14
{
	// Fields
	public int value__; // 0x0
	public const CertificateImportFlags None = 0;
	public const CertificateImportFlags DisableNativeBackend = 1;
	public const CertificateImportFlags DisableAutomaticFallback = 2;
}

// Namespace: Mono
internal static class DependencyInjector // TypeDefIndex: 15
{
	// Fields
	private static object locker; // 0x0
	private static ISystemDependencyProvider systemDependency; // 0x8

	// Properties
	internal static ISystemDependencyProvider SystemProvider { get; }

	// Methods

	// RVA: 0x1716898 Offset: 0x1712898 VA: 0x1716898
	internal static ISystemDependencyProvider get_SystemProvider() { }

	// RVA: 0x1716BE0 Offset: 0x1712BE0 VA: 0x1716BE0
	internal static void Register(ISystemDependencyProvider provider) { }

	// RVA: 0x1716AA0 Offset: 0x1712AA0 VA: 0x1716AA0
	private static ISystemDependencyProvider ReflectionLoad() { }

	// RVA: 0x1716D74 Offset: 0x1712D74 VA: 0x1716D74
	private static void .cctor() { }
}

// Namespace: Mono
internal interface ISystemCertificateProvider // TypeDefIndex: 16
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = 0);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract X509CertificateImpl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = 0);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract X509CertificateImpl Import(X509Certificate cert, CertificateImportFlags importFlags = 0);
}

// Namespace: Mono
internal interface ISystemDependencyProvider // TypeDefIndex: 17
{
	// Properties
	public abstract ISystemCertificateProvider CertificateProvider { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ISystemCertificateProvider get_CertificateProvider();
}

// Namespace: Mono
public static class Runtime // TypeDefIndex: 18
{
	// Fields
	private static object dump; // 0x0

	// Methods

	// RVA: 0x1716DF0 Offset: 0x1712DF0 VA: 0x1716DF0
	private static void .cctor() { }
}

// Namespace: Mono
internal struct RuntimeClassHandle // TypeDefIndex: 19
{
	// Fields
	private RuntimeStructs.MonoClass* value; // 0x0

	// Properties
	internal RuntimeStructs.MonoClass* Value { get; }

	// Methods

	// RVA: 0x1716E6C Offset: 0x1712E6C VA: 0x1716E6C
	internal void .ctor(RuntimeStructs.MonoClass* value) { }

	// RVA: 0x1716E74 Offset: 0x1712E74 VA: 0x1716E74
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1716E94 Offset: 0x1712E94 VA: 0x1716E94
	internal RuntimeStructs.MonoClass* get_Value() { }

	// RVA: 0x1716E9C Offset: 0x1712E9C VA: 0x1716E9C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1716F94 Offset: 0x1712F94 VA: 0x1716F94 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1716FBC Offset: 0x1712FBC VA: 0x1716FBC
	internal static IntPtr GetTypeFromClass(RuntimeStructs.MonoClass* klass) { }

	// RVA: 0x1716FC0 Offset: 0x1712FC0 VA: 0x1716FC0
	internal RuntimeTypeHandle GetTypeHandle() { }
}

// Namespace: Mono
internal struct RuntimeRemoteClassHandle // TypeDefIndex: 20
{
	// Fields
	private RuntimeStructs.RemoteClass* value; // 0x0

	// Properties
	internal RuntimeClassHandle ProxyClass { get; }

	// Methods

	// RVA: 0x1716FC8 Offset: 0x1712FC8 VA: 0x1716FC8
	internal RuntimeClassHandle get_ProxyClass() { }
}

// Namespace: Mono
internal struct RuntimeGenericParamInfoHandle // TypeDefIndex: 21
{
	// Fields
	private RuntimeStructs.GenericParamInfo* value; // 0x0

	// Properties
	internal Type[] Constraints { get; }
	internal GenericParameterAttributes Attributes { get; }

	// Methods

	// RVA: 0x1716FE0 Offset: 0x1712FE0 VA: 0x1716FE0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1717000 Offset: 0x1713000 VA: 0x1717000
	internal Type[] get_Constraints() { }

	// RVA: 0x1717130 Offset: 0x1713130 VA: 0x1717130
	internal GenericParameterAttributes get_Attributes() { }

	// RVA: 0x1717004 Offset: 0x1713004 VA: 0x1717004
	private Type[] GetConstraints() { }

	// RVA: 0x1717148 Offset: 0x1713148 VA: 0x1717148
	private int GetConstraintsCount() { }
}

// Namespace: Mono
internal struct RuntimeEventHandle // TypeDefIndex: 22
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1717188 Offset: 0x1713188 VA: 0x1717188
	internal void .ctor(IntPtr v) { }

	// RVA: 0x1717190 Offset: 0x1713190 VA: 0x1717190
	public IntPtr get_Value() { }

	// RVA: 0x1717198 Offset: 0x1713198 VA: 0x1717198 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1717290 Offset: 0x1713290 VA: 0x1717290 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Mono
internal struct RuntimePropertyHandle // TypeDefIndex: 23
{
	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1717298 Offset: 0x1713298 VA: 0x1717298
	internal void .ctor(IntPtr v) { }

	// RVA: 0x17172A0 Offset: 0x17132A0 VA: 0x17172A0
	public IntPtr get_Value() { }

	// RVA: 0x17172A8 Offset: 0x17132A8 VA: 0x17172A8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17173A0 Offset: 0x17133A0 VA: 0x17173A0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: Mono
[DefaultMember("Item")]
internal struct RuntimeGPtrArrayHandle // TypeDefIndex: 24
{
	// Fields
	private RuntimeStructs.GPtrArray* value; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x17173A8 Offset: 0x17133A8 VA: 0x17173A8
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x17173C8 Offset: 0x17133C8 VA: 0x17173C8
	internal int get_Length() { }

	// RVA: 0x17173E0 Offset: 0x17133E0 VA: 0x17173E0
	internal IntPtr get_Item(int i) { }

	// RVA: 0x17173E4 Offset: 0x17133E4 VA: 0x17173E4
	internal IntPtr Lookup(int i) { }

	// RVA: 0x1717448 Offset: 0x1713448 VA: 0x1717448
	private static void GPtrArrayFree(RuntimeStructs.GPtrArray* value) { }

	// RVA: 0x171744C Offset: 0x171344C VA: 0x171744C
	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }
}

// Namespace: Mono
internal static class RuntimeMarshal // TypeDefIndex: 25
{
	// Methods

	// RVA: 0x1717468 Offset: 0x1713468 VA: 0x1717468
	internal static string PtrToUtf8String(IntPtr ptr) { }

	// RVA: 0x17174F8 Offset: 0x17134F8 VA: 0x17174F8
	internal static SafeStringMarshal MarshalString(string str) { }

	// RVA: 0x1717544 Offset: 0x1713544 VA: 0x1717544
	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) { }

	// RVA: 0x17175C0 Offset: 0x17135C0 VA: 0x17175C0
	internal static byte[] DecodeBlobArray(IntPtr ptr) { }

	// RVA: 0x1717678 Offset: 0x1713678 VA: 0x1717678
	internal static int AsciHexDigitValue(int c) { }

	// RVA: 0x17176A4 Offset: 0x17136A4 VA: 0x17176A4
	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }
}

// Namespace: 
internal struct RuntimeStructs.RemoteClass // TypeDefIndex: 26
{
	// Fields
	internal IntPtr default_vtable; // 0x0
	internal IntPtr xdomain_vtable; // 0x8
	internal RuntimeStructs.MonoClass* proxy_class; // 0x10
	internal IntPtr proxy_class_name; // 0x18
	internal uint interface_count; // 0x20
}

// Namespace: 
internal struct RuntimeStructs.MonoClass // TypeDefIndex: 27
{}

// Namespace: 
internal struct RuntimeStructs.GenericParamInfo // TypeDefIndex: 28
{
	// Fields
	internal RuntimeStructs.MonoClass* pklass; // 0x0
	internal IntPtr name; // 0x8
	internal ushort flags; // 0x10
	internal uint token; // 0x14
	internal RuntimeStructs.MonoClass** constraints; // 0x18
}

// Namespace: 
internal struct RuntimeStructs.GPtrArray // TypeDefIndex: 29
{
	// Fields
	internal IntPtr* data; // 0x0
	internal int len; // 0x8
}

// Namespace: Mono
internal static class RuntimeStructs // TypeDefIndex: 30
{}

// Namespace: 
[CompilerGenerated]
[UnsafeValueType]
public struct MonoAssemblyName.<public_key_token>e__FixedBuffer // TypeDefIndex: 31
{
	// Fields
	public byte FixedElementField; // 0x0
}

// Namespace: Mono
internal struct MonoAssemblyName // TypeDefIndex: 32
{
	// Fields
	internal IntPtr name; // 0x0
	internal IntPtr culture; // 0x8
	internal IntPtr hash_value; // 0x10
	internal IntPtr public_key; // 0x18
	[FixedBuffer(typeof(byte), 17)]
	internal MonoAssemblyName.<public_key_token>e__FixedBuffer public_key_token; // 0x20
	internal uint hash_alg; // 0x34
	internal uint hash_len; // 0x38
	internal uint flags; // 0x3C
	internal ushort major; // 0x40
	internal ushort minor; // 0x42
	internal ushort build; // 0x44
	internal ushort revision; // 0x46
	internal ushort arch; // 0x48
}

// Namespace: Mono
internal struct ValueTuple // TypeDefIndex: 33
{}

// Namespace: Mono
internal struct ValueTuple<T1> // TypeDefIndex: 34
{
	// Fields
	public T1 Item1; // 0x0
}

// Namespace: Mono
internal struct ValueTuple<T1, T2> // TypeDefIndex: 35
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
}

// Namespace: Mono
internal struct ValueTuple<T1, T2, T3> // TypeDefIndex: 36
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
}

// Namespace: Mono
internal struct ValueTuple<T1, T2, T3, T4> // TypeDefIndex: 37
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
}

// Namespace: Mono
internal struct ValueTuple<T1, T2, T3, T4, T5> // TypeDefIndex: 38
{
	// Fields
	public T1 Item1; // 0x0
	public T2 Item2; // 0x0
	public T3 Item3; // 0x0
	public T4 Item4; // 0x0
	public T5 Item5; // 0x0
}

// Namespace: Mono
[DefaultMember("Item")]
internal struct SafeGPtrArrayHandle : IDisposable // TypeDefIndex: 39
{
	// Fields
	private RuntimeGPtrArrayHandle handle; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x17176A8 Offset: 0x17136A8 VA: 0x17176A8
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x17176C8 Offset: 0x17136C8 VA: 0x17176C8 Slot: 4
	public void Dispose() { }

	// RVA: 0x17176E4 Offset: 0x17136E4 VA: 0x17176E4
	internal int get_Length() { }

	// RVA: 0x17176FC Offset: 0x17136FC VA: 0x17176FC
	internal IntPtr get_Item(int i) { }
}

// Namespace: Mono
internal struct SafeStringMarshal : IDisposable // TypeDefIndex: 40
{
	// Fields
	private readonly string str; // 0x0
	private IntPtr marshaled_string; // 0x8

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1717700 Offset: 0x1713700 VA: 0x1717700
	private static IntPtr StringToUtf8_icall(ref string str) { }

	// RVA: 0x1717704 Offset: 0x1713704 VA: 0x1717704
	public static IntPtr StringToUtf8(string str) { }

	// RVA: 0x1717718 Offset: 0x1713718 VA: 0x1717718
	public static void GFree(IntPtr ptr) { }

	// RVA: 0x1717528 Offset: 0x1713528 VA: 0x1717528
	public void .ctor(string str) { }

	// RVA: 0x171771C Offset: 0x171371C VA: 0x171771C
	public IntPtr get_Value() { }

	// RVA: 0x171775C Offset: 0x171375C VA: 0x171775C Slot: 4
	public void Dispose() { }
}

// Namespace: Mono
internal class SystemCertificateProvider : ISystemCertificateProvider // TypeDefIndex: 3712
{
	// Fields
	private static int initialized; // 0x0
	private static X509PalImpl x509pal; // 0x8
	private static object syncRoot; // 0x10

	// Properties
	public X509PalImpl X509Pal { get; }

	// Methods

	// RVA: 0x1A1A30C Offset: 0x1A1630C VA: 0x1A1A30C
	private static X509PalImpl GetX509Pal() { }

	// RVA: 0x1A1A3B4 Offset: 0x1A163B4 VA: 0x1A1A3B4
	private static void EnsureInitialized() { }

	// RVA: 0x1A1A50C Offset: 0x1A1650C VA: 0x1A1A50C
	public X509PalImpl get_X509Pal() { }

	// RVA: 0x1A1A568 Offset: 0x1A16568 VA: 0x1A1A568 Slot: 4
	public X509CertificateImpl Import(byte[] data, CertificateImportFlags importFlags = 0) { }

	// RVA: 0x1A1A784 Offset: 0x1A16784 VA: 0x1A1A784 Slot: 5
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags) { }

	// RVA: 0x1A1A788 Offset: 0x1A16788 VA: 0x1A1A788
	public X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags, CertificateImportFlags importFlags = 0) { }

	// RVA: 0x1A1A88C Offset: 0x1A1688C VA: 0x1A1A88C Slot: 6
	private X509CertificateImpl Mono.ISystemCertificateProvider.Import(X509Certificate cert, CertificateImportFlags importFlags) { }

	// RVA: 0x1A1A890 Offset: 0x1A16890 VA: 0x1A1A890
	public X509Certificate2Impl Import(X509Certificate cert, CertificateImportFlags importFlags = 0) { }

	// RVA: 0x1A1A9A4 Offset: 0x1A169A4 VA: 0x1A1A9A4
	public void .ctor() { }

	// RVA: 0x1A1A9AC Offset: 0x1A169AC VA: 0x1A1A9AC
	private static void .cctor() { }
}

// Namespace: Mono
internal class SystemDependencyProvider : ISystemDependencyProvider // TypeDefIndex: 3713
{
	// Fields
	private static SystemDependencyProvider instance; // 0x0
	private static object syncRoot; // 0x8
	[CompilerGenerated]
	private readonly SystemCertificateProvider <CertificateProvider>k__BackingField; // 0x10

	// Properties
	public static SystemDependencyProvider Instance { get; }
	private ISystemCertificateProvider Mono.ISystemDependencyProvider.CertificateProvider { get; }
	public SystemCertificateProvider CertificateProvider { get; }
	public X509PalImpl X509Pal { get; }

	// Methods

	// RVA: 0x1A1AA20 Offset: 0x1A16A20 VA: 0x1A1AA20
	public static SystemDependencyProvider get_Instance() { }

	// RVA: 0x1A1AA7C Offset: 0x1A16A7C VA: 0x1A1AA7C
	internal static void Initialize() { }

	// RVA: 0x1A1AC74 Offset: 0x1A16C74 VA: 0x1A1AC74 Slot: 4
	private ISystemCertificateProvider Mono.ISystemDependencyProvider.get_CertificateProvider() { }

	[CompilerGenerated]
	// RVA: 0x1A1AC7C Offset: 0x1A16C7C VA: 0x1A1AC7C
	public SystemCertificateProvider get_CertificateProvider() { }

	// RVA: 0x1A1AC84 Offset: 0x1A16C84 VA: 0x1A1AC84
	public X509PalImpl get_X509Pal() { }

	// RVA: 0x1A1ABD0 Offset: 0x1A16BD0 VA: 0x1A1ABD0
	private void .ctor() { }

	// RVA: 0x1A1AC98 Offset: 0x1A16C98 VA: 0x1A1AC98
	private static void .cctor() { }
}

// Namespace: Mono
internal static class X509Pal // TypeDefIndex: 3714
{
	// Properties
	public static X509PalImpl Instance { get; }

	// Methods

	// RVA: 0x1A1AD0C Offset: 0x1A16D0C VA: 0x1A1AD0C
	public static X509PalImpl get_Instance() { }
}

// Namespace: Mono
internal class X509PalImplMono : X509PalImpl // TypeDefIndex: 3715
{
	// Methods

	// RVA: 0x1A1AD6C Offset: 0x1A16D6C VA: 0x1A1AD6C Slot: 4
	public override X509CertificateImpl Import(byte[] data) { }

	// RVA: 0x1A1AD70 Offset: 0x1A16D70 VA: 0x1A1AD70 Slot: 5
	public override X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1A1AD74 Offset: 0x1A16D74 VA: 0x1A1AD74 Slot: 6
	public override X509Certificate2Impl Import(X509Certificate cert) { }

	// RVA: 0x1A1A35C Offset: 0x1A1635C VA: 0x1A1A35C
	public void .ctor() { }
}

// Namespace: Mono
internal abstract class X509PalImpl // TypeDefIndex: 3716
{
	// Fields
	private static byte[] signedData; // 0x0

	// Properties
	public bool SupportsLegacyBasicConstraintsExtension { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract X509CertificateImpl Import(byte[] data);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract X509Certificate2Impl Import(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509Certificate2Impl Import(X509Certificate cert);

	// RVA: 0x1A1AD84 Offset: 0x1A16D84 VA: 0x1A1AD84
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x1A1AEB8 Offset: 0x1A16EB8 VA: 0x1A1AEB8
	protected static byte[] ConvertData(byte[] data) { }

	// RVA: 0x1A1A5D4 Offset: 0x1A165D4 VA: 0x1A1A5D4
	internal X509Certificate2Impl ImportFallback(byte[] data) { }

	// RVA: 0x1A1A818 Offset: 0x1A16818 VA: 0x1A1A818
	internal X509Certificate2Impl ImportFallback(byte[] data, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1A1AFC4 Offset: 0x1A16FC4 VA: 0x1A1AFC4
	public bool get_SupportsLegacyBasicConstraintsExtension() { }

	// RVA: 0x1A1AFCC Offset: 0x1A16FCC VA: 0x1A1AFCC
	public X509ContentType GetCertContentType(byte[] rawData) { }

	// RVA: 0x1A1AD7C Offset: 0x1A16D7C VA: 0x1A1AD7C
	protected void .ctor() { }

	// RVA: 0x1A1B3C8 Offset: 0x1A173C8 VA: 0x1A1B3C8
	private static void .cctor() { }
}
