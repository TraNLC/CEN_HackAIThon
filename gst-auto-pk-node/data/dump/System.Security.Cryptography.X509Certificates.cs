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

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509ContentType // TypeDefIndex: 779
{
	// Fields
	public int value__; // 0x0
	public const X509ContentType Unknown = 0;
	public const X509ContentType Cert = 1;
	public const X509ContentType SerializedCert = 2;
	public const X509ContentType Pfx = 3;
	public const X509ContentType Pkcs12 = 3;
	public const X509ContentType SerializedStore = 4;
	public const X509ContentType Pkcs7 = 5;
	public const X509ContentType Authenticode = 6;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum X509KeyStorageFlags // TypeDefIndex: 780
{
	// Fields
	public int value__; // 0x0
	public const X509KeyStorageFlags DefaultKeySet = 0;
	public const X509KeyStorageFlags UserKeySet = 1;
	public const X509KeyStorageFlags MachineKeySet = 2;
	public const X509KeyStorageFlags Exportable = 4;
	public const X509KeyStorageFlags UserProtected = 8;
	public const X509KeyStorageFlags PersistKeySet = 16;
	public const X509KeyStorageFlags EphemeralKeySet = 32;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Serializable]
public class X509Certificate : IDisposable, IDeserializationCallback, ISerializable // TypeDefIndex: 781
{
	// Fields
	private X509CertificateImpl impl; // 0x10
	private byte[] lazyCertHash; // 0x18
	private byte[] lazySerialNumber; // 0x20
	private string lazyIssuer; // 0x28
	private string lazySubject; // 0x30
	private string lazyKeyAlgorithm; // 0x38
	private byte[] lazyKeyAlgorithmParameters; // 0x40
	private byte[] lazyPublicKey; // 0x48
	private DateTime lazyNotBefore; // 0x50
	private DateTime lazyNotAfter; // 0x58

	// Properties
	public string Issuer { get; }
	public string Subject { get; }
	internal X509CertificateImpl Impl { get; }
	internal bool IsValid { get; }

	// Methods

	// RVA: 0x177A4E4 Offset: 0x17764E4 VA: 0x177A4E4 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x177A66C Offset: 0x177666C VA: 0x177A66C
	public void .ctor() { }

	// RVA: 0x177A6E0 Offset: 0x17766E0 VA: 0x177A6E0
	public void .ctor(byte[] data) { }

	// RVA: 0x177A840 Offset: 0x1776840 VA: 0x177A840
	public void .ctor(byte[] rawData, string password) { }

	// RVA: 0x177A848 Offset: 0x1776848 VA: 0x177A848
	public void .ctor(byte[] rawData, string password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x177AC48 Offset: 0x1776C48 VA: 0x177AC48
	internal void .ctor(X509CertificateImpl impl) { }

	// RVA: 0x177AD08 Offset: 0x1776D08 VA: 0x177AD08
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x177AE9C Offset: 0x1776E9C VA: 0x177AE9C
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x177AED8 Offset: 0x1776ED8 VA: 0x177AED8 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x177AF10 Offset: 0x1776F10 VA: 0x177AF10 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x177AF48 Offset: 0x1776F48 VA: 0x177AF48
	public string get_Issuer() { }

	// RVA: 0x177AFB4 Offset: 0x1776FB4 VA: 0x177AFB4
	public string get_Subject() { }

	// RVA: 0x177B018 Offset: 0x1777018 VA: 0x177B018 Slot: 4
	public void Dispose() { }

	// RVA: 0x177B028 Offset: 0x1777028 VA: 0x177B028 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x177B03C Offset: 0x177703C VA: 0x177B03C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x177B0D0 Offset: 0x17770D0 VA: 0x177B0D0 Slot: 9
	public virtual bool Equals(X509Certificate other) { }

	// RVA: 0x177B204 Offset: 0x1777204 VA: 0x177B204 Slot: 10
	public virtual byte[] GetCertHash() { }

	// RVA: 0x177B284 Offset: 0x1777284 VA: 0x177B284 Slot: 11
	public virtual string GetCertHashString() { }

	// RVA: 0x177B228 Offset: 0x1777228 VA: 0x177B228
	private byte[] GetRawCertHash() { }

	// RVA: 0x177B2A8 Offset: 0x17772A8 VA: 0x177B2A8 Slot: 12
	public virtual byte[] GetRawCertData() { }

	// RVA: 0x177B2DC Offset: 0x17772DC VA: 0x177B2DC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x177B33C Offset: 0x177733C VA: 0x177B33C Slot: 13
	public virtual string GetKeyAlgorithm() { }

	// RVA: 0x177B3A4 Offset: 0x17773A4 VA: 0x177B3A4 Slot: 14
	public virtual byte[] GetKeyAlgorithmParameters() { }

	// RVA: 0x177B410 Offset: 0x1777410 VA: 0x177B410 Slot: 15
	public virtual byte[] GetPublicKey() { }

	// RVA: 0x177B47C Offset: 0x177747C VA: 0x177B47C Slot: 16
	public virtual byte[] GetSerialNumber() { }

	// RVA: 0x177B4E4 Offset: 0x17774E4 VA: 0x177B4E4 Slot: 17
	public virtual string GetSerialNumberString() { }

	// RVA: 0x177B1A4 Offset: 0x17771A4 VA: 0x177B1A4
	private byte[] GetRawSerialNumber() { }

	// RVA: 0x177B508 Offset: 0x1777508 VA: 0x177B508 Slot: 3
	public override string ToString() { }

	// RVA: 0x177B51C Offset: 0x177751C VA: 0x177B51C Slot: 18
	public virtual string ToString(bool fVerbose) { }

	// RVA: 0x177BA34 Offset: 0x1777A34 VA: 0x177BA34
	internal DateTime GetNotAfter() { }

	// RVA: 0x177B850 Offset: 0x1777850 VA: 0x177B850
	internal DateTime GetNotBefore() { }

	// RVA: 0x177B8EC Offset: 0x17778EC VA: 0x177B8EC
	protected static string FormatDate(DateTime date) { }

	// RVA: 0x177AA78 Offset: 0x1776A78 VA: 0x177AA78
	internal static void ValidateKeyStorageFlags(X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x177BAD0 Offset: 0x1777AD0 VA: 0x177BAD0
	internal void ImportHandle(X509CertificateImpl impl) { }

	// RVA: 0x177BB08 Offset: 0x1777B08 VA: 0x177BB08
	internal X509CertificateImpl get_Impl() { }

	// RVA: 0x177BB10 Offset: 0x1777B10 VA: 0x177BB10
	internal bool get_IsValid() { }

	// RVA: 0x177AFAC Offset: 0x1776FAC VA: 0x177AFAC
	internal void ThrowIfInvalid() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509CertificateImpl : IDisposable // TypeDefIndex: 782
{
	// Properties
	public abstract bool IsValid { get; }
	public abstract string Issuer { get; }
	public abstract string Subject { get; }
	public abstract byte[] RawData { get; }
	public abstract DateTime NotAfter { get; }
	public abstract DateTime NotBefore { get; }
	public abstract byte[] Thumbprint { get; }
	public abstract string KeyAlgorithm { get; }
	public abstract byte[] KeyAlgorithmParameters { get; }
	public abstract byte[] PublicKeyValue { get; }
	public abstract byte[] SerialNumber { get; }
	public abstract bool HasPrivateKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: 0x177BB68 Offset: 0x1777B68 VA: 0x177BB68
	protected void ThrowIfContextInvalid() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509CertificateImpl Clone();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Issuer();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Subject();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract byte[] get_RawData();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract DateTime get_NotAfter();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DateTime get_NotBefore();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract byte[] get_Thumbprint();

	// RVA: 0x177BC24 Offset: 0x1777C24 VA: 0x177BC24 Slot: 2
	public sealed override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract string get_KeyAlgorithm();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract byte[] get_KeyAlgorithmParameters();

	// RVA: -1 Offset: -1 Slot: 15
	public abstract byte[] get_PublicKeyValue();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract byte[] get_SerialNumber();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool get_HasPrivateKey();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract RSA GetRSAPrivateKey();

	// RVA: -1 Offset: -1 Slot: 19
	public abstract DSA GetDSAPrivateKey();

	// RVA: 0x177BC9C Offset: 0x1777C9C VA: 0x177BC9C Slot: 0
	public sealed override bool Equals(object obj) { }

	// RVA: 0x177A5FC Offset: 0x17765FC VA: 0x177A5FC Slot: 4
	public void Dispose() { }

	// RVA: 0x177BDFC Offset: 0x1777DFC VA: 0x177BDFC Slot: 20
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x177BE00 Offset: 0x1777E00 VA: 0x177BE00 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x177BE94 Offset: 0x1777E94 VA: 0x177BE94
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal static class X509Helper // TypeDefIndex: 783
{
	// Properties
	private static ISystemCertificateProvider CertificateProvider { get; }

	// Methods

	// RVA: 0x177BE9C Offset: 0x1777E9C VA: 0x177BE9C
	private static ISystemCertificateProvider get_CertificateProvider() { }

	// RVA: 0x177ADEC Offset: 0x1776DEC VA: 0x177ADEC
	public static X509CertificateImpl InitFromCertificate(X509Certificate cert) { }

	// RVA: 0x177ACF4 Offset: 0x1776CF4 VA: 0x177ACF4
	public static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl) { }

	// RVA: 0x177B83C Offset: 0x177783C VA: 0x177B83C
	public static bool IsValid(X509CertificateImpl impl) { }

	// RVA: 0x177BB28 Offset: 0x1777B28 VA: 0x177BB28
	internal static void ThrowIfContextInvalid(X509CertificateImpl impl) { }

	// RVA: 0x177BBA4 Offset: 0x1777BA4 VA: 0x177BBA4
	internal static Exception GetInvalidContextException() { }

	// RVA: 0x177A794 Offset: 0x1776794 VA: 0x177A794
	public static X509CertificateImpl Import(byte[] rawData) { }

	// RVA: 0x177AB80 Offset: 0x1776B80 VA: 0x177AB80
	public static X509CertificateImpl Import(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum OpenFlags // TypeDefIndex: 3912
{
	// Fields
	public int value__; // 0x0
	public const OpenFlags ReadOnly = 0;
	public const OpenFlags ReadWrite = 1;
	public const OpenFlags MaxAllowed = 2;
	public const OpenFlags OpenExistingOnly = 4;
	public const OpenFlags IncludeArchived = 8;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum StoreLocation // TypeDefIndex: 3913
{
	// Fields
	public int value__; // 0x0
	public const StoreLocation CurrentUser = 1;
	public const StoreLocation LocalMachine = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum StoreName // TypeDefIndex: 3914
{
	// Fields
	public int value__; // 0x0
	public const StoreName AddressBook = 1;
	public const StoreName AuthRoot = 2;
	public const StoreName CertificateAuthority = 3;
	public const StoreName Disallowed = 4;
	public const StoreName My = 5;
	public const StoreName Root = 6;
	public const StoreName TrustedPeople = 7;
	public const StoreName TrustedPublisher = 8;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum X500DistinguishedNameFlags // TypeDefIndex: 3915
{
	// Fields
	public int value__; // 0x0
	public const X500DistinguishedNameFlags None = 0;
	public const X500DistinguishedNameFlags Reversed = 1;
	public const X500DistinguishedNameFlags UseSemicolons = 16;
	public const X500DistinguishedNameFlags DoNotUsePlusSign = 32;
	public const X500DistinguishedNameFlags DoNotUseQuotes = 64;
	public const X500DistinguishedNameFlags UseCommas = 128;
	public const X500DistinguishedNameFlags UseNewLines = 256;
	public const X500DistinguishedNameFlags UseUTF8Encoding = 4096;
	public const X500DistinguishedNameFlags UseT61Encoding = 8192;
	public const X500DistinguishedNameFlags ForceUTF8Encoding = 16384;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum X509ChainStatusFlags // TypeDefIndex: 3916
{
	// Fields
	public int value__; // 0x0
	public const X509ChainStatusFlags NoError = 0;
	public const X509ChainStatusFlags NotTimeValid = 1;
	public const X509ChainStatusFlags NotTimeNested = 2;
	public const X509ChainStatusFlags Revoked = 4;
	public const X509ChainStatusFlags NotSignatureValid = 8;
	public const X509ChainStatusFlags NotValidForUsage = 16;
	public const X509ChainStatusFlags UntrustedRoot = 32;
	public const X509ChainStatusFlags RevocationStatusUnknown = 64;
	public const X509ChainStatusFlags Cyclic = 128;
	public const X509ChainStatusFlags InvalidExtension = 256;
	public const X509ChainStatusFlags InvalidPolicyConstraints = 512;
	public const X509ChainStatusFlags InvalidBasicConstraints = 1024;
	public const X509ChainStatusFlags InvalidNameConstraints = 2048;
	public const X509ChainStatusFlags HasNotSupportedNameConstraint = 4096;
	public const X509ChainStatusFlags HasNotDefinedNameConstraint = 8192;
	public const X509ChainStatusFlags HasNotPermittedNameConstraint = 16384;
	public const X509ChainStatusFlags HasExcludedNameConstraint = 32768;
	public const X509ChainStatusFlags PartialChain = 65536;
	public const X509ChainStatusFlags CtlNotTimeValid = 131072;
	public const X509ChainStatusFlags CtlNotSignatureValid = 262144;
	public const X509ChainStatusFlags CtlNotValidForUsage = 524288;
	public const X509ChainStatusFlags OfflineRevocation = 16777216;
	public const X509ChainStatusFlags NoIssuanceChainPolicy = 33554432;
	public const X509ChainStatusFlags ExplicitDistrust = 67108864;
	public const X509ChainStatusFlags HasNotSupportedCriticalExtension = 134217728;
	public const X509ChainStatusFlags HasWeakSignature = 1048576;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509FindType // TypeDefIndex: 3917
{
	// Fields
	public int value__; // 0x0
	public const X509FindType FindByThumbprint = 0;
	public const X509FindType FindBySubjectName = 1;
	public const X509FindType FindBySubjectDistinguishedName = 2;
	public const X509FindType FindByIssuerName = 3;
	public const X509FindType FindByIssuerDistinguishedName = 4;
	public const X509FindType FindBySerialNumber = 5;
	public const X509FindType FindByTimeValid = 6;
	public const X509FindType FindByTimeNotYetValid = 7;
	public const X509FindType FindByTimeExpired = 8;
	public const X509FindType FindByTemplateName = 9;
	public const X509FindType FindByApplicationPolicy = 10;
	public const X509FindType FindByCertificatePolicy = 11;
	public const X509FindType FindByExtension = 12;
	public const X509FindType FindByKeyUsage = 13;
	public const X509FindType FindBySubjectKeyIdentifier = 14;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum X509KeyUsageFlags // TypeDefIndex: 3918
{
	// Fields
	public int value__; // 0x0
	public const X509KeyUsageFlags None = 0;
	public const X509KeyUsageFlags EncipherOnly = 1;
	public const X509KeyUsageFlags CrlSign = 2;
	public const X509KeyUsageFlags KeyCertSign = 4;
	public const X509KeyUsageFlags KeyAgreement = 8;
	public const X509KeyUsageFlags DataEncipherment = 16;
	public const X509KeyUsageFlags KeyEncipherment = 32;
	public const X509KeyUsageFlags NonRepudiation = 64;
	public const X509KeyUsageFlags DigitalSignature = 128;
	public const X509KeyUsageFlags DecipherOnly = 32768;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509NameType // TypeDefIndex: 3919
{
	// Fields
	public int value__; // 0x0
	public const X509NameType SimpleName = 0;
	public const X509NameType EmailName = 1;
	public const X509NameType UpnName = 2;
	public const X509NameType DnsName = 3;
	public const X509NameType DnsFromAlternativeName = 4;
	public const X509NameType UrlName = 5;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509RevocationFlag // TypeDefIndex: 3920
{
	// Fields
	public int value__; // 0x0
	public const X509RevocationFlag EndCertificateOnly = 0;
	public const X509RevocationFlag EntireChain = 1;
	public const X509RevocationFlag ExcludeRoot = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509RevocationMode // TypeDefIndex: 3921
{
	// Fields
	public int value__; // 0x0
	public const X509RevocationMode NoCheck = 0;
	public const X509RevocationMode Online = 1;
	public const X509RevocationMode Offline = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
public enum X509SubjectKeyIdentifierHashAlgorithm // TypeDefIndex: 3922
{
	// Fields
	public int value__; // 0x0
	public const X509SubjectKeyIdentifierHashAlgorithm Sha1 = 0;
	public const X509SubjectKeyIdentifierHashAlgorithm ShortSha1 = 1;
	public const X509SubjectKeyIdentifierHashAlgorithm CapiSha1 = 2;
}

// Namespace: System.Security.Cryptography.X509Certificates
[Flags]
public enum X509VerificationFlags // TypeDefIndex: 3923
{
	// Fields
	public int value__; // 0x0
	public const X509VerificationFlags NoFlag = 0;
	public const X509VerificationFlags IgnoreNotTimeValid = 1;
	public const X509VerificationFlags IgnoreCtlNotTimeValid = 2;
	public const X509VerificationFlags IgnoreNotTimeNested = 4;
	public const X509VerificationFlags IgnoreInvalidBasicConstraints = 8;
	public const X509VerificationFlags AllowUnknownCertificateAuthority = 16;
	public const X509VerificationFlags IgnoreWrongUsage = 32;
	public const X509VerificationFlags IgnoreInvalidName = 64;
	public const X509VerificationFlags IgnoreInvalidPolicy = 128;
	public const X509VerificationFlags IgnoreEndRevocationUnknown = 256;
	public const X509VerificationFlags IgnoreCtlSignerRevocationUnknown = 512;
	public const X509VerificationFlags IgnoreCertificateAuthorityRevocationUnknown = 1024;
	public const X509VerificationFlags IgnoreRootRevocationUnknown = 2048;
	public const X509VerificationFlags AllFlags = 4095;
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class PublicKey // TypeDefIndex: 3924
{
	// Fields
	private AsnEncodedData _keyValue; // 0x10
	private AsnEncodedData _params; // 0x18
	private Oid _oid; // 0x20
	private static byte[] Empty; // 0x0

	// Properties
	public AsnEncodedData EncodedKeyValue { get; }
	public AsnEncodedData EncodedParameters { get; }
	public AsymmetricAlgorithm Key { get; }
	public Oid Oid { get; }

	// Methods

	// RVA: 0x1D19524 Offset: 0x1D15524 VA: 0x1D19524
	public void .ctor(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue) { }

	// RVA: 0x1D1969C Offset: 0x1D1569C VA: 0x1D1969C
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x1D196A4 Offset: 0x1D156A4 VA: 0x1D196A4
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x1D196AC Offset: 0x1D156AC VA: 0x1D196AC
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0x1D1A0E0 Offset: 0x1D160E0 VA: 0x1D1A0E0
	public Oid get_Oid() { }

	// RVA: 0x1D1A0E8 Offset: 0x1D160E8 VA: 0x1D1A0E8
	private static byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x1D19C08 Offset: 0x1D15C08 VA: 0x1D19C08
	internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters) { }

	// RVA: 0x1D19850 Offset: 0x1D15850 VA: 0x1D19850
	internal static RSA DecodeRSA(byte[] rawPublicKey) { }

	// RVA: 0x1D1A17C Offset: 0x1D1617C VA: 0x1D1A17C
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[MonoTODO("Some X500DistinguishedNameFlags options aren't supported, like DoNotUsePlusSign, DoNotUseQuotes and ForceUTF8Encoding")]
public sealed class X500DistinguishedName : AsnEncodedData // TypeDefIndex: 3925
{
	// Fields
	private string name; // 0x20
	private byte[] canonEncoding; // 0x28

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x1D1A1F0 Offset: 0x1D161F0 VA: 0x1D1A1F0
	public void .ctor(byte[] encodedDistinguishedName) { }

	// RVA: 0x1D1A3D0 Offset: 0x1D163D0 VA: 0x1D1A3D0
	public string get_Name() { }

	// RVA: 0x1D1A3D8 Offset: 0x1D163D8 VA: 0x1D1A3D8
	public string Decode(X500DistinguishedNameFlags flag) { }

	// RVA: 0x1D1A594 Offset: 0x1D16594 VA: 0x1D1A594 Slot: 5
	public override string Format(bool multiLine) { }

	// RVA: 0x1D1A51C Offset: 0x1D1651C VA: 0x1D1A51C
	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

	// RVA: 0x1D1A2EC Offset: 0x1D162EC VA: 0x1D1A2EC
	private void DecodeRawData() { }

	// RVA: 0x1D1A5F0 Offset: 0x1D165F0 VA: 0x1D1A5F0
	private static string Canonize(string s) { }

	// RVA: 0x1D1A7C0 Offset: 0x1D167C0 VA: 0x1D1A7C0
	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509BasicConstraintsExtension : X509Extension // TypeDefIndex: 3926
{
	// Fields
	internal const string oid = "2.5.29.19";
	internal const string friendlyName = "Basic Constraints";
	private bool _certificateAuthority; // 0x21
	private bool _hasPathLengthConstraint; // 0x22
	private int _pathLengthConstraint; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Properties
	public bool CertificateAuthority { get; }
	public bool HasPathLengthConstraint { get; }
	public int PathLengthConstraint { get; }

	// Methods

	// RVA: 0x1D1A994 Offset: 0x1D16994 VA: 0x1D1A994
	public void .ctor() { }

	// RVA: 0x1D19184 Offset: 0x1D15184 VA: 0x1D19184
	public void .ctor(AsnEncodedData encodedBasicConstraints, bool critical) { }

	// RVA: 0x1D1AC0C Offset: 0x1D16C0C VA: 0x1D1AC0C
	public void .ctor(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical) { }

	// RVA: 0x1D1AEA0 Offset: 0x1D16EA0 VA: 0x1D1AEA0
	public bool get_CertificateAuthority() { }

	// RVA: 0x1D1AF04 Offset: 0x1D16F04 VA: 0x1D1AF04
	public bool get_HasPathLengthConstraint() { }

	// RVA: 0x1D1AF68 Offset: 0x1D16F68 VA: 0x1D1AF68
	public int get_PathLengthConstraint() { }

	// RVA: 0x1D1AFCC Offset: 0x1D16FCC VA: 0x1D1AFCC Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1D1AA3C Offset: 0x1D16A3C VA: 0x1D1AA3C
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1D1AD44 Offset: 0x1D16D44 VA: 0x1D1AD44
	internal byte[] Encode() { }

	// RVA: 0x1D1B198 Offset: 0x1D17198 VA: 0x1D1B198 Slot: 6
	internal override string ToString(bool multiLine) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[Serializable]
public class X509Certificate2 : X509Certificate // TypeDefIndex: 3927
{
	// Fields
	private byte[] lazyRawData; // 0x60
	private Oid lazySignatureAlgorithm; // 0x68
	private int lazyVersion; // 0x70
	private X500DistinguishedName lazySubjectName; // 0x78
	private X500DistinguishedName lazyIssuerName; // 0x80
	private PublicKey lazyPublicKey; // 0x88
	private AsymmetricAlgorithm lazyPrivateKey; // 0x90
	private X509ExtensionCollection lazyExtensions; // 0x98

	// Properties
	public X509ExtensionCollection Extensions { get; }
	public bool HasPrivateKey { get; }
	public AsymmetricAlgorithm PrivateKey { get; }
	public X500DistinguishedName IssuerName { get; }
	public DateTime NotAfter { get; }
	public DateTime NotBefore { get; }
	public PublicKey PublicKey { get; }
	public byte[] RawData { get; }
	public string SerialNumber { get; }
	public Oid SignatureAlgorithm { get; }
	public X500DistinguishedName SubjectName { get; }
	public string Thumbprint { get; }
	public int Version { get; }
	internal X509Certificate2Impl Impl { get; }

	// Methods

	// RVA: 0x1D1B504 Offset: 0x1D17504 VA: 0x1D1B504 Slot: 7
	public override void Reset() { }

	// RVA: 0x1D1B5B0 Offset: 0x1D175B0 VA: 0x1D1B5B0
	public void .ctor() { }

	// RVA: 0x1D1B5B8 Offset: 0x1D175B8 VA: 0x1D1B5B8
	public void .ctor(byte[] rawData) { }

	// RVA: 0x1D1B738 Offset: 0x1D17738 VA: 0x1D1B738
	public void .ctor(byte[] rawData, string password) { }

	// RVA: 0x1D1B740 Offset: 0x1D17740 VA: 0x1D1B740
	public void .ctor(X509Certificate certificate) { }

	// RVA: 0x1D1B748 Offset: 0x1D17748 VA: 0x1D1B748
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1D1B788 Offset: 0x1D17788 VA: 0x1D1B788
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x1D1BE50 Offset: 0x1D17E50 VA: 0x1D1BE50
	public bool get_HasPrivateKey() { }

	// RVA: 0x1D1BE84 Offset: 0x1D17E84 VA: 0x1D1BE84
	public AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x1D1BFE8 Offset: 0x1D17FE8 VA: 0x1D1BFE8
	public X500DistinguishedName get_IssuerName() { }

	// RVA: 0x1D1C054 Offset: 0x1D18054 VA: 0x1D1C054
	public DateTime get_NotAfter() { }

	// RVA: 0x1D1C05C Offset: 0x1D1805C VA: 0x1D1C05C
	public DateTime get_NotBefore() { }

	// RVA: 0x1D1C064 Offset: 0x1D18064 VA: 0x1D1C064
	public PublicKey get_PublicKey() { }

	// RVA: 0x1D1C1BC Offset: 0x1D181BC VA: 0x1D1C1BC
	public byte[] get_RawData() { }

	// RVA: 0x1D1C228 Offset: 0x1D18228 VA: 0x1D1C228
	public string get_SerialNumber() { }

	// RVA: 0x1D1C238 Offset: 0x1D18238 VA: 0x1D1C238
	public Oid get_SignatureAlgorithm() { }

	// RVA: 0x1D1C2AC Offset: 0x1D182AC VA: 0x1D1C2AC
	public X500DistinguishedName get_SubjectName() { }

	// RVA: 0x1D1C318 Offset: 0x1D18318 VA: 0x1D1C318
	public string get_Thumbprint() { }

	// RVA: 0x1D1C334 Offset: 0x1D18334 VA: 0x1D1C334
	public int get_Version() { }

	// RVA: 0x1D1C390 Offset: 0x1D18390 VA: 0x1D1C390
	public static X509ContentType GetCertContentType(byte[] rawData) { }

	// RVA: 0x1D1C428 Offset: 0x1D18428 VA: 0x1D1C428
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x1D1C464 Offset: 0x1D18464 VA: 0x1D1C464 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D1C470 Offset: 0x1D18470 VA: 0x1D1C470 Slot: 18
	public override string ToString(bool verbose) { }

	// RVA: 0x1D1D528 Offset: 0x1D19528 VA: 0x1D1D528
	public bool Verify() { }

	// RVA: 0x1D1BC1C Offset: 0x1D17C1C VA: 0x1D1BC1C
	private static X509Extension CreateCustomExtensionIfAny(Oid oid) { }

	// RVA: 0x1D1BB90 Offset: 0x1D17B90 VA: 0x1D1BB90
	internal X509Certificate2Impl get_Impl() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
public class X509Certificate2Collection : X509CertificateCollection // TypeDefIndex: 3928
{
	// Fields
	private static string[] newline_split; // 0x0

	// Properties
	public X509Certificate2 Item { get; }

	// Methods

	// RVA: 0x1D1D734 Offset: 0x1D19734 VA: 0x1D1D734
	public void .ctor() { }

	// RVA: 0x1D1D744 Offset: 0x1D19744 VA: 0x1D1D744
	public void .ctor(X509Certificate2Collection certificates) { }

	// RVA: 0x1D1D7E0 Offset: 0x1D197E0 VA: 0x1D1D7E0
	public X509Certificate2 get_Item(int index) { }

	// RVA: 0x1D1D904 Offset: 0x1D19904 VA: 0x1D1D904
	public int Add(X509Certificate2 certificate) { }

	[MonoTODO("Method isn't transactional (like documented)")]
	// RVA: 0x1D1D770 Offset: 0x1D19770 VA: 0x1D1D770
	public void AddRange(X509Certificate2Collection certificates) { }

	// RVA: 0x1D1D974 Offset: 0x1D19974 VA: 0x1D1D974
	public bool Contains(X509Certificate2 certificate) { }

	// RVA: 0x1D1DC88 Offset: 0x1D19C88 VA: 0x1D1DC88
	private string GetKeyIdentifier(X509Certificate2 x) { }

	[MonoTODO("Does not support X509FindType.FindByTemplateName, FindByApplicationPolicy and FindByCertificatePolicy")]
	// RVA: 0x1D1E4FC Offset: 0x1D1A4FC VA: 0x1D1E4FC
	public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly) { }

	// RVA: 0x1D1F5AC Offset: 0x1D1B5AC VA: 0x1D1F5AC
	public X509Certificate2Enumerator GetEnumerator() { }

	// RVA: 0x1D1F6C0 Offset: 0x1D1B6C0 VA: 0x1D1F6C0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Certificate2Enumerator : IEnumerator // TypeDefIndex: 3929
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Certificate2 Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1D1F604 Offset: 0x1D1B604 VA: 0x1D1F604
	internal void .ctor(X509Certificate2Collection collection) { }

	// RVA: 0x1D1F764 Offset: 0x1D1B764 VA: 0x1D1F764
	public X509Certificate2 get_Current() { }

	// RVA: 0x1D1F854 Offset: 0x1D1B854 VA: 0x1D1F854
	public bool MoveNext() { }

	// RVA: 0x1D1F8F4 Offset: 0x1D1B8F4 VA: 0x1D1F8F4 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1D1F998 Offset: 0x1D1B998 VA: 0x1D1F998 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1D1FA38 Offset: 0x1D1BA38 VA: 0x1D1FA38 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2Impl : X509CertificateImpl // TypeDefIndex: 3930
{
	// Properties
	public abstract IEnumerable<X509Extension> Extensions { get; }
	public abstract X500DistinguishedName IssuerName { get; }
	public abstract AsymmetricAlgorithm PrivateKey { get; set; }
	public abstract string SignatureAlgorithm { get; }
	public abstract X500DistinguishedName SubjectName { get; }
	public abstract int Version { get; }
	internal abstract X509CertificateImplCollection IntermediateCertificates { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 21
	public abstract IEnumerable<X509Extension> get_Extensions();

	// RVA: -1 Offset: -1 Slot: 22
	public abstract X500DistinguishedName get_IssuerName();

	// RVA: -1 Offset: -1 Slot: 23
	public abstract AsymmetricAlgorithm get_PrivateKey();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void set_PrivateKey(AsymmetricAlgorithm value);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract string get_SignatureAlgorithm();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract X500DistinguishedName get_SubjectName();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract int get_Version();

	// RVA: -1 Offset: -1 Slot: 28
	internal abstract X509CertificateImplCollection get_IntermediateCertificates();

	// RVA: -1 Offset: -1 Slot: 29
	public abstract string GetNameInfo(X509NameType nameType, bool forIssuer);

	// RVA: -1 Offset: -1 Slot: 30
	public abstract bool Verify(X509Certificate2 thisCertificate);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void AppendPrivateKeyInfo(StringBuilder sb);

	// RVA: 0x1D1FADC Offset: 0x1D1BADC VA: 0x1D1FADC
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509Certificate2ImplMono : X509Certificate2ImplUnix // TypeDefIndex: 3931
{
	// Fields
	private X509CertificateImplCollection intermediateCerts; // 0xB0
	private X509Certificate _cert; // 0xB8
	private static string empty_error; // 0x0
	private static byte[] signedData; // 0x8

	// Properties
	public override bool IsValid { get; }
	private X509Certificate Cert { get; }
	public override bool HasPrivateKey { get; }
	public override AsymmetricAlgorithm PrivateKey { get; set; }
	internal override X509CertificateImplCollection IntermediateCertificates { get; }
	internal X509Certificate MonoCertificate { get; }

	// Methods

	// RVA: 0x1D1FAE4 Offset: 0x1D1BAE4 VA: 0x1D1FAE4 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x1D1FAF4 Offset: 0x1D1BAF4 VA: 0x1D1FAF4
	public void .ctor(X509Certificate cert) { }

	// RVA: 0x1D1FB2C Offset: 0x1D1BB2C VA: 0x1D1FB2C
	private void .ctor(X509Certificate2ImplMono other) { }

	// RVA: 0x1D1FBE4 Offset: 0x1D1BBE4 VA: 0x1D1FBE4
	public void .ctor(byte[] rawData, SafePasswordHandle password, X509KeyStorageFlags keyStorageFlags) { }

	// RVA: 0x1D1FDB8 Offset: 0x1D1BDB8 VA: 0x1D1FDB8 Slot: 6
	public override X509CertificateImpl Clone() { }

	// RVA: 0x1D1FE1C Offset: 0x1D1BE1C VA: 0x1D1FE1C
	private X509Certificate get_Cert() { }

	// RVA: 0x1D1FE38 Offset: 0x1D1BE38 VA: 0x1D1FE38 Slot: 32
	protected override byte[] GetRawCertData() { }

	// RVA: 0x1D1FE70 Offset: 0x1D1BE70 VA: 0x1D1FE70 Slot: 17
	public override bool get_HasPrivateKey() { }

	// RVA: 0x1D1FE94 Offset: 0x1D1BE94 VA: 0x1D1FE94 Slot: 23
	public override AsymmetricAlgorithm get_PrivateKey() { }

	// RVA: 0x1D202B0 Offset: 0x1D1C2B0 VA: 0x1D202B0 Slot: 24
	public override void set_PrivateKey(AsymmetricAlgorithm value) { }

	// RVA: 0x1D20438 Offset: 0x1D1C438 VA: 0x1D20438 Slot: 18
	public override RSA GetRSAPrivateKey() { }

	// RVA: 0x1D204C4 Offset: 0x1D1C4C4 VA: 0x1D204C4 Slot: 19
	public override DSA GetDSAPrivateKey() { }

	// RVA: 0x1D1FD60 Offset: 0x1D1BD60 VA: 0x1D1FD60
	private X509Certificate ImportPkcs12(byte[] rawData, SafePasswordHandle password) { }

	// RVA: 0x1D20550 Offset: 0x1D1C550 VA: 0x1D20550
	private X509Certificate ImportPkcs12(byte[] rawData, string password) { }

	[MonoTODO("by default this depends on the incomplete X509Chain")]
	// RVA: 0x1D20DDC Offset: 0x1D1CDDC VA: 0x1D20DDC Slot: 30
	public override bool Verify(X509Certificate2 thisCertificate) { }

	// RVA: 0x1D20EF8 Offset: 0x1D1CEF8 VA: 0x1D20EF8 Slot: 28
	internal override X509CertificateImplCollection get_IntermediateCertificates() { }

	// RVA: 0x1D20F00 Offset: 0x1D1CF00 VA: 0x1D20F00
	internal X509Certificate get_MonoCertificate() { }

	// RVA: 0x1D20F08 Offset: 0x1D1CF08 VA: 0x1D20F08
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509Certificate2ImplUnix : X509Certificate2Impl // TypeDefIndex: 3932
{
	// Fields
	private bool readCertData; // 0x10
	private CertificateData certData; // 0x18

	// Properties
	public sealed override string KeyAlgorithm { get; }
	public sealed override byte[] KeyAlgorithmParameters { get; }
	public sealed override byte[] PublicKeyValue { get; }
	public sealed override byte[] SerialNumber { get; }
	public sealed override string SignatureAlgorithm { get; }
	public sealed override int Version { get; }
	public sealed override X500DistinguishedName SubjectName { get; }
	public sealed override X500DistinguishedName IssuerName { get; }
	public sealed override string Subject { get; }
	public sealed override string Issuer { get; }
	public sealed override byte[] RawData { get; }
	public sealed override byte[] Thumbprint { get; }
	public sealed override IEnumerable<X509Extension> Extensions { get; }
	public sealed override DateTime NotAfter { get; }
	public sealed override DateTime NotBefore { get; }

	// Methods

	// RVA: 0x1D20FDC Offset: 0x1D1CFDC VA: 0x1D20FDC
	private void EnsureCertData() { }

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract byte[] GetRawCertData();

	// RVA: 0x1D2106C Offset: 0x1D1D06C VA: 0x1D2106C Slot: 13
	public sealed override string get_KeyAlgorithm() { }

	// RVA: 0x1D21084 Offset: 0x1D1D084 VA: 0x1D21084 Slot: 14
	public sealed override byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x1D2109C Offset: 0x1D1D09C VA: 0x1D2109C Slot: 15
	public sealed override byte[] get_PublicKeyValue() { }

	// RVA: 0x1D210B4 Offset: 0x1D1D0B4 VA: 0x1D210B4 Slot: 16
	public sealed override byte[] get_SerialNumber() { }

	// RVA: 0x1D210CC Offset: 0x1D1D0CC VA: 0x1D210CC Slot: 25
	public sealed override string get_SignatureAlgorithm() { }

	// RVA: 0x1D210E4 Offset: 0x1D1D0E4 VA: 0x1D210E4 Slot: 27
	public sealed override int get_Version() { }

	// RVA: 0x1D21100 Offset: 0x1D1D100 VA: 0x1D21100 Slot: 26
	public sealed override X500DistinguishedName get_SubjectName() { }

	// RVA: 0x1D21118 Offset: 0x1D1D118 VA: 0x1D21118 Slot: 22
	public sealed override X500DistinguishedName get_IssuerName() { }

	// RVA: 0x1D21130 Offset: 0x1D1D130 VA: 0x1D21130 Slot: 8
	public sealed override string get_Subject() { }

	// RVA: 0x1D21158 Offset: 0x1D1D158 VA: 0x1D21158 Slot: 7
	public sealed override string get_Issuer() { }

	// RVA: 0x1D21180 Offset: 0x1D1D180 VA: 0x1D21180 Slot: 9
	public sealed override byte[] get_RawData() { }

	// RVA: 0x1D21198 Offset: 0x1D1D198 VA: 0x1D21198 Slot: 12
	public sealed override byte[] get_Thumbprint() { }

	// RVA: 0x1D212D8 Offset: 0x1D1D2D8 VA: 0x1D212D8 Slot: 29
	public sealed override string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x1D2130C Offset: 0x1D1D30C VA: 0x1D2130C Slot: 21
	public sealed override IEnumerable<X509Extension> get_Extensions() { }

	// RVA: 0x1D21324 Offset: 0x1D1D324 VA: 0x1D21324 Slot: 10
	public sealed override DateTime get_NotAfter() { }

	// RVA: 0x1D21384 Offset: 0x1D1D384 VA: 0x1D21384 Slot: 11
	public sealed override DateTime get_NotBefore() { }

	// RVA: 0x1D213E4 Offset: 0x1D1D3E4 VA: 0x1D213E4 Slot: 31
	public sealed override void AppendPrivateKeyInfo(StringBuilder sb) { }

	// RVA: 0x1D1FB24 Offset: 0x1D1BB24 VA: 0x1D1FB24
	protected void .ctor() { }
}

// Namespace: 
public class X509CertificateCollection.X509CertificateEnumerator : IEnumerator // TypeDefIndex: 3933
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Certificate Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1D21754 Offset: 0x1D1D754 VA: 0x1D21754
	public void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0x1D2182C Offset: 0x1D1D82C VA: 0x1D2182C
	public X509Certificate get_Current() { }

	// RVA: 0x1D2191C Offset: 0x1D1D91C VA: 0x1D2191C Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1D219C0 Offset: 0x1D1D9C0 VA: 0x1D219C0 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1D21A60 Offset: 0x1D1DA60 VA: 0x1D21A60 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1D21B04 Offset: 0x1D1DB04 VA: 0x1D21B04
	public bool MoveNext() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
[Serializable]
public class X509CertificateCollection : CollectionBase // TypeDefIndex: 3934
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0x1D1D73C Offset: 0x1D1973C VA: 0x1D1D73C
	public void .ctor() { }

	// RVA: 0x1D21478 Offset: 0x1D1D478 VA: 0x1D21478
	public void .ctor(X509Certificate[] value) { }

	// RVA: 0x1D21568 Offset: 0x1D1D568 VA: 0x1D21568
	public void .ctor(X509CertificateCollection value) { }

	// RVA: 0x1D21664 Offset: 0x1D1D664 VA: 0x1D21664
	public X509Certificate get_Item(int index) { }

	// RVA: 0x1D214A4 Offset: 0x1D1D4A4 VA: 0x1D214A4
	public void AddRange(X509Certificate[] value) { }

	// RVA: 0x1D21594 Offset: 0x1D1D594 VA: 0x1D21594
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x1D216FC Offset: 0x1D1D6FC VA: 0x1D216FC
	public X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x1D21810 Offset: 0x1D1D810 VA: 0x1D21810 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
internal class X509CertificateImplCollection : IDisposable // TypeDefIndex: 3935
{
	// Fields
	private List<X509CertificateImpl> list; // 0x10

	// Properties
	public int Count { get; }
	public X509CertificateImpl Item { get; }

	// Methods

	// RVA: 0x1D20C7C Offset: 0x1D1CC7C VA: 0x1D20C7C
	public void .ctor() { }

	// RVA: 0x1D21BA4 Offset: 0x1D1DBA4 VA: 0x1D21BA4
	private void .ctor(X509CertificateImplCollection other) { }

	// RVA: 0x1D21DBC Offset: 0x1D1DDBC VA: 0x1D21DBC
	public int get_Count() { }

	// RVA: 0x1D21E04 Offset: 0x1D1DE04 VA: 0x1D21E04
	public X509CertificateImpl get_Item(int index) { }

	// RVA: 0x1D20D04 Offset: 0x1D1CD04 VA: 0x1D20D04
	public void Add(X509CertificateImpl impl, bool takeOwnership) { }

	// RVA: 0x1D1FB8C Offset: 0x1D1BB8C VA: 0x1D1FB8C
	public X509CertificateImplCollection Clone() { }

	// RVA: 0x1D21E5C Offset: 0x1D1DE5C VA: 0x1D21E5C Slot: 4
	public void Dispose() { }

	// RVA: 0x1D21EC8 Offset: 0x1D1DEC8 VA: 0x1D21EC8 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1D220F8 Offset: 0x1D1E0F8 VA: 0x1D220F8 Slot: 1
	protected override void Finalize() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Chain : IDisposable // TypeDefIndex: 3936
{
	// Fields
	private X509ChainImpl impl; // 0x10

	// Properties
	internal X509ChainImpl Impl { get; }
	public X509ChainElementCollection ChainElements { get; }
	public X509ChainPolicy ChainPolicy { get; }

	// Methods

	// RVA: 0x1D22188 Offset: 0x1D1E188 VA: 0x1D22188
	internal X509ChainImpl get_Impl() { }

	// RVA: 0x1D221E4 Offset: 0x1D1E1E4 VA: 0x1D221E4
	public void .ctor() { }

	// RVA: 0x1D221EC Offset: 0x1D1E1EC VA: 0x1D221EC
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x1D2227C Offset: 0x1D1E27C VA: 0x1D2227C
	internal void .ctor(X509ChainImpl impl) { }

	[MonoTODO("Mono's X509Chain is fully managed. All handles are invalid.")]
	// RVA: 0x1D222B4 Offset: 0x1D1E2B4 VA: 0x1D222B4
	public void .ctor(IntPtr chainContext) { }

	// RVA: 0x1D222F4 Offset: 0x1D1E2F4 VA: 0x1D222F4
	public X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x1D22320 Offset: 0x1D1E320 VA: 0x1D22320
	public X509ChainPolicy get_ChainPolicy() { }

	[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	// RVA: 0x1D20EBC Offset: 0x1D1CEBC VA: 0x1D20EBC
	public bool Build(X509Certificate2 certificate) { }

	// RVA: 0x1D2234C Offset: 0x1D1E34C VA: 0x1D2234C
	public void Reset() { }

	// RVA: 0x1D20E68 Offset: 0x1D1CE68 VA: 0x1D20E68
	public static X509Chain Create() { }

	// RVA: 0x1D22378 Offset: 0x1D1E378 VA: 0x1D22378 Slot: 4
	public void Dispose() { }

	// RVA: 0x1D223E4 Offset: 0x1D1E3E4 VA: 0x1D223E4 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1D22480 Offset: 0x1D1E480 VA: 0x1D22480 Slot: 1
	protected override void Finalize() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509ChainElement // TypeDefIndex: 3937
{
	// Fields
	private X509Certificate2 certificate; // 0x10
	private X509ChainStatus[] status; // 0x18
	private string info; // 0x20
	private X509ChainStatusFlags compressed_status_flags; // 0x28

	// Properties
	public X509Certificate2 Certificate { get; }
	public X509ChainStatus[] ChainElementStatus { get; }
	internal X509ChainStatusFlags StatusFlags { get; set; }

	// Methods

	// RVA: 0x1D22510 Offset: 0x1D1E510 VA: 0x1D22510
	internal void .ctor(X509Certificate2 certificate) { }

	// RVA: 0x1D22560 Offset: 0x1D1E560 VA: 0x1D22560
	public X509Certificate2 get_Certificate() { }

	// RVA: 0x1D22568 Offset: 0x1D1E568 VA: 0x1D22568
	public X509ChainStatus[] get_ChainElementStatus() { }

	// RVA: 0x1D22570 Offset: 0x1D1E570 VA: 0x1D22570
	internal X509ChainStatusFlags get_StatusFlags() { }

	// RVA: 0x1D22578 Offset: 0x1D1E578 VA: 0x1D22578
	internal void set_StatusFlags(X509ChainStatusFlags value) { }

	// RVA: 0x1D22580 Offset: 0x1D1E580 VA: 0x1D22580
	private int Count(X509ChainStatusFlags flags) { }

	// RVA: 0x1D225A4 Offset: 0x1D1E5A4 VA: 0x1D225A4
	private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

	// RVA: 0x1D227B0 Offset: 0x1D1E7B0 VA: 0x1D227B0
	internal void UncompressFlags() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
public sealed class X509ChainElementCollection : ICollection, IEnumerable // TypeDefIndex: 3938
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public bool IsSynchronized { get; }
	public X509ChainElement Item { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x1D22A14 Offset: 0x1D1EA14 VA: 0x1D22A14
	internal void .ctor() { }

	// RVA: 0x1D22A80 Offset: 0x1D1EA80 VA: 0x1D22A80 Slot: 5
	public int get_Count() { }

	// RVA: 0x1D22AA0 Offset: 0x1D1EAA0 VA: 0x1D22AA0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x1D22AC0 Offset: 0x1D1EAC0 VA: 0x1D22AC0
	public X509ChainElement get_Item(int index) { }

	// RVA: 0x1D22B58 Offset: 0x1D1EB58 VA: 0x1D22B58 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1D22B78 Offset: 0x1D1EB78 VA: 0x1D22B78 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1D22B98 Offset: 0x1D1EB98 VA: 0x1D22B98
	public X509ChainElementEnumerator GetEnumerator() { }

	// RVA: 0x1D22CB0 Offset: 0x1D1ECB0 VA: 0x1D22CB0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1D22D0C Offset: 0x1D1ED0C VA: 0x1D22D0C
	internal void Add(X509Certificate2 certificate) { }

	// RVA: 0x1D22D8C Offset: 0x1D1ED8C VA: 0x1D22D8C
	internal void Clear() { }

	// RVA: 0x1D22DAC Offset: 0x1D1EDAC VA: 0x1D22DAC
	internal bool Contains(X509Certificate2 certificate) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainElementEnumerator : IEnumerator // TypeDefIndex: 3939
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509ChainElement Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1D22BF4 Offset: 0x1D1EBF4 VA: 0x1D22BF4
	internal void .ctor(IEnumerable enumerable) { }

	// RVA: 0x1D22EA0 Offset: 0x1D1EEA0 VA: 0x1D22EA0
	public X509ChainElement get_Current() { }

	// RVA: 0x1D22F90 Offset: 0x1D1EF90 VA: 0x1D22F90 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1D23034 Offset: 0x1D1F034 VA: 0x1D23034 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1D230D4 Offset: 0x1D1F0D4 VA: 0x1D230D4 Slot: 6
	public void Reset() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal abstract class X509ChainImpl : IDisposable // TypeDefIndex: 3940
{
	// Properties
	public abstract bool IsValid { get; }
	public abstract X509ChainElementCollection ChainElements { get; }
	public abstract X509ChainPolicy ChainPolicy { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsValid();

	// RVA: 0x1D23178 Offset: 0x1D1F178 VA: 0x1D23178
	protected void ThrowIfContextInvalid() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract X509ChainElementCollection get_ChainElements();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract X509ChainPolicy get_ChainPolicy();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool Build(X509Certificate2 certificate);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void AddStatus(X509ChainStatusFlags errorCode);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Reset();

	// RVA: 0x1D22414 Offset: 0x1D1E414 VA: 0x1D22414 Slot: 4
	public void Dispose() { }

	// RVA: 0x1D23234 Offset: 0x1D1F234 VA: 0x1D23234 Slot: 11
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1D23238 Offset: 0x1D1F238 VA: 0x1D23238 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1D232C8 Offset: 0x1D1F2C8 VA: 0x1D232C8
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal class X509ChainImplMono : X509ChainImpl // TypeDefIndex: 3941
{
	// Fields
	private StoreLocation location; // 0x10
	private X509ChainElementCollection elements; // 0x18
	private X509ChainPolicy policy; // 0x20
	private X509ChainStatus[] status; // 0x28
	private static X509ChainStatus[] Empty; // 0x0
	private int max_path_length; // 0x30
	private X500DistinguishedName working_issuer_name; // 0x38
	private AsymmetricAlgorithm working_public_key; // 0x40
	private X509ChainElement bce_restriction; // 0x48
	private X509Certificate2Collection roots; // 0x50
	private X509Certificate2Collection cas; // 0x58
	private X509Store root_store; // 0x60
	private X509Store ca_store; // 0x68
	private X509Store user_root_store; // 0x70
	private X509Store user_ca_store; // 0x78
	private X509Certificate2Collection collection; // 0x80

	// Properties
	public override bool IsValid { get; }
	public override X509ChainElementCollection ChainElements { get; }
	public override X509ChainPolicy ChainPolicy { get; }
	private X509Certificate2Collection Roots { get; }
	private X509Certificate2Collection CertificateAuthorities { get; }
	private X509Store LMRootStore { get; }
	private X509Store UserRootStore { get; }
	private X509Store LMCAStore { get; }
	private X509Store UserCAStore { get; }
	private X509Certificate2Collection CertificateCollection { get; }

	// Methods

	// RVA: 0x1D232D0 Offset: 0x1D1F2D0 VA: 0x1D232D0
	public void .ctor(bool useMachineContext) { }

	// RVA: 0x1D233B0 Offset: 0x1D1F3B0 VA: 0x1D233B0 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x1D233B8 Offset: 0x1D1F3B8 VA: 0x1D233B8 Slot: 6
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x1D233C0 Offset: 0x1D1F3C0 VA: 0x1D233C0 Slot: 7
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x1D233C8 Offset: 0x1D1F3C8 VA: 0x1D233C8 Slot: 9
	public override void AddStatus(X509ChainStatusFlags error) { }

	[MonoTODO("Not totally RFC3280 compliant, but neither is MS implementation...")]
	// RVA: 0x1D233CC Offset: 0x1D1F3CC VA: 0x1D233CC Slot: 8
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x1D23BF4 Offset: 0x1D1FBF4 VA: 0x1D23BF4 Slot: 10
	public override void Reset() { }

	// RVA: 0x1D23D74 Offset: 0x1D1FD74 VA: 0x1D23D74
	private X509Certificate2Collection get_Roots() { }

	// RVA: 0x1D240C0 Offset: 0x1D200C0 VA: 0x1D240C0
	private X509Certificate2Collection get_CertificateAuthorities() { }

	// RVA: 0x1D23E48 Offset: 0x1D1FE48 VA: 0x1D23E48
	private X509Store get_LMRootStore() { }

	// RVA: 0x1D23F40 Offset: 0x1D1FF40 VA: 0x1D23F40
	private X509Store get_UserRootStore() { }

	// RVA: 0x1D24194 Offset: 0x1D20194 VA: 0x1D24194
	private X509Store get_LMCAStore() { }

	// RVA: 0x1D2428C Offset: 0x1D2028C VA: 0x1D2428C
	private X509Store get_UserCAStore() { }

	// RVA: 0x1D24870 Offset: 0x1D20870 VA: 0x1D24870
	private X509Certificate2Collection get_CertificateCollection() { }

	// RVA: 0x1D239B8 Offset: 0x1D1F9B8 VA: 0x1D239B8
	private X509ChainStatusFlags BuildChainFrom(X509Certificate2 certificate) { }

	// RVA: 0x1D24D5C Offset: 0x1D20D5C VA: 0x1D24D5C
	private X509Certificate2 SelectBestFromCollection(X509Certificate2 child, X509Certificate2Collection c) { }

	// RVA: 0x1D24B80 Offset: 0x1D20B80 VA: 0x1D24B80
	private X509Certificate2 FindParent(X509Certificate2 certificate) { }

	// RVA: 0x1D24C94 Offset: 0x1D20C94 VA: 0x1D24C94
	private bool IsChainComplete(X509Certificate2 certificate) { }

	// RVA: 0x1D25020 Offset: 0x1D21020 VA: 0x1D25020
	private bool IsSelfIssued(X509Certificate2 certificate) { }

	// RVA: 0x1D23A9C Offset: 0x1D1FA9C VA: 0x1D23A9C
	private void ValidateChain(X509ChainStatusFlags flag) { }

	// RVA: 0x1D25068 Offset: 0x1D21068 VA: 0x1D25068
	private void Process(int n) { }

	// RVA: 0x1D25310 Offset: 0x1D21310 VA: 0x1D25310
	private void PrepareForNextCertificate(int n) { }

	// RVA: 0x1D256F8 Offset: 0x1D216F8 VA: 0x1D256F8
	private void WrapUp() { }

	// RVA: 0x1D2588C Offset: 0x1D2188C VA: 0x1D2588C
	private void ProcessCertificateExtensions(X509ChainElement element) { }

	// RVA: 0x1D25854 Offset: 0x1D21854 VA: 0x1D25854
	private bool IsSignedWith(X509Certificate2 signed, AsymmetricAlgorithm pubkey) { }

	// RVA: 0x1D24F7C Offset: 0x1D20F7C VA: 0x1D24F7C
	private string GetSubjectKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x1D24EE8 Offset: 0x1D20EE8 VA: 0x1D24EE8
	private static string GetAuthorityKeyIdentifier(X509Certificate2 certificate) { }

	// RVA: 0x1D25ACC Offset: 0x1D21ACC VA: 0x1D25ACC
	private static string GetAuthorityKeyIdentifier(X509Crl crl) { }

	// RVA: 0x1D25974 Offset: 0x1D21974 VA: 0x1D25974
	private static string GetAuthorityKeyIdentifier(X509Extension ext) { }

	// RVA: 0x1D2550C Offset: 0x1D2150C VA: 0x1D2550C
	private void CheckRevocationOnChain(X509ChainStatusFlags flag) { }

	// RVA: 0x1D25B58 Offset: 0x1D21B58 VA: 0x1D25B58
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, int ca, bool online) { }

	// RVA: 0x1D25C20 Offset: 0x1D21C20 VA: 0x1D25C20
	private X509ChainStatusFlags CheckRevocation(X509Certificate2 certificate, X509Certificate2 ca_cert, bool online) { }

	// RVA: 0x1D26554 Offset: 0x1D22554 VA: 0x1D26554
	private static X509Crl CheckCrls(string subject, string ski, X509Store store) { }

	// RVA: 0x1D25DF4 Offset: 0x1D21DF4 VA: 0x1D25DF4
	private X509Crl FindCrl(X509Certificate2 caCertificate) { }

	// RVA: 0x1D26240 Offset: 0x1D22240 VA: 0x1D26240
	private bool ProcessCrlExtensions(X509Crl crl) { }

	// RVA: 0x1D25F68 Offset: 0x1D21F68 VA: 0x1D25F68
	private bool ProcessCrlEntryExtensions(X509Crl.X509CrlEntry entry) { }

	// RVA: 0x1D268A0 Offset: 0x1D228A0 VA: 0x1D268A0
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ChainPolicy // TypeDefIndex: 3942
{
	// Fields
	private OidCollection apps; // 0x10
	private OidCollection cert; // 0x18
	private X509CertificateCollection store; // 0x20
	private X509Certificate2Collection store2; // 0x28
	private X509RevocationFlag rflag; // 0x30
	private X509RevocationMode mode; // 0x34
	private TimeSpan timeout; // 0x38
	private X509VerificationFlags vflags; // 0x40
	private DateTime vtime; // 0x48

	// Properties
	public X509Certificate2Collection ExtraStore { get; }
	public X509RevocationFlag RevocationFlag { get; }
	public X509RevocationMode RevocationMode { get; set; }
	public X509VerificationFlags VerificationFlags { get; set; }
	public DateTime VerificationTime { get; }

	// Methods

	// RVA: 0x1D23394 Offset: 0x1D1F394 VA: 0x1D23394
	public void .ctor() { }

	// RVA: 0x1D24954 Offset: 0x1D20954 VA: 0x1D24954
	public X509Certificate2Collection get_ExtraStore() { }

	// RVA: 0x1D26A24 Offset: 0x1D22A24 VA: 0x1D26A24
	public X509RevocationFlag get_RevocationFlag() { }

	// RVA: 0x1D26A2C Offset: 0x1D22A2C VA: 0x1D26A2C
	public X509RevocationMode get_RevocationMode() { }

	// RVA: 0x1D26A34 Offset: 0x1D22A34 VA: 0x1D26A34
	public void set_RevocationMode(X509RevocationMode value) { }

	// RVA: 0x1D26A90 Offset: 0x1D22A90 VA: 0x1D26A90
	public X509VerificationFlags get_VerificationFlags() { }

	// RVA: 0x1D26A98 Offset: 0x1D22A98 VA: 0x1D26A98
	public void set_VerificationFlags(X509VerificationFlags value) { }

	// RVA: 0x1D26AF4 Offset: 0x1D22AF4 VA: 0x1D26AF4
	public DateTime get_VerificationTime() { }

	// RVA: 0x1D26914 Offset: 0x1D22914 VA: 0x1D26914
	public void Reset() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public struct X509ChainStatus // TypeDefIndex: 3943
{
	// Fields
	private X509ChainStatusFlags status; // 0x0
	private string info; // 0x8

	// Properties
	public X509ChainStatusFlags Status { get; set; }
	public string StatusInformation { set; }

	// Methods

	// RVA: 0x1D23BCC Offset: 0x1D1FBCC VA: 0x1D23BCC
	internal void .ctor(X509ChainStatusFlags flag) { }

	// RVA: 0x1D26AFC Offset: 0x1D22AFC VA: 0x1D26AFC
	public X509ChainStatusFlags get_Status() { }

	// RVA: 0x1D26B04 Offset: 0x1D22B04 VA: 0x1D26B04
	public void set_Status(X509ChainStatusFlags value) { }

	// RVA: 0x1D26B0C Offset: 0x1D22B0C VA: 0x1D26B0C
	public void set_StatusInformation(string value) { }

	// RVA: 0x1D2262C Offset: 0x1D1E62C VA: 0x1D2262C
	internal static string GetInformation(X509ChainStatusFlags flags) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509EnhancedKeyUsageExtension : X509Extension // TypeDefIndex: 3944
{
	// Fields
	private OidCollection _enhKeyUsage; // 0x28
	private AsnDecodeStatus _status; // 0x30

	// Methods

	// RVA: 0x1D1D5F4 Offset: 0x1D195F4 VA: 0x1D1D5F4
	public void .ctor() { }

	// RVA: 0x1D1926C Offset: 0x1D1526C VA: 0x1D1926C
	public void .ctor(AsnEncodedData encodedEnhancedKeyUsages, bool critical) { }

	// RVA: 0x1D26D60 Offset: 0x1D22D60 VA: 0x1D26D60
	public void .ctor(OidCollection enhancedKeyUsages, bool critical) { }

	// RVA: 0x1D26FAC Offset: 0x1D22FAC VA: 0x1D26FAC Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1D26B14 Offset: 0x1D22B14 VA: 0x1D26B14
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1D26EF0 Offset: 0x1D22EF0 VA: 0x1D26EF0
	internal byte[] Encode() { }

	// RVA: 0x1D27178 Offset: 0x1D23178 VA: 0x1D27178 Slot: 6
	internal override string ToString(bool multiLine) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public class X509Extension : AsnEncodedData // TypeDefIndex: 3945
{
	// Fields
	private bool _critical; // 0x20

	// Properties
	public bool Critical { get; set; }

	// Methods

	// RVA: 0x1D1AA34 Offset: 0x1D16A34 VA: 0x1D1AA34
	protected void .ctor() { }

	// RVA: 0x1D27444 Offset: 0x1D23444 VA: 0x1D27444
	public void .ctor(string oid, byte[] rawData, bool critical) { }

	// RVA: 0x1D27468 Offset: 0x1D23468 VA: 0x1D27468
	public bool get_Critical() { }

	// RVA: 0x1D27470 Offset: 0x1D23470 VA: 0x1D27470
	public void set_Critical(bool value) { }

	// RVA: 0x1D27478 Offset: 0x1D23478 VA: 0x1D27478 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1D1B3F4 Offset: 0x1D173F4 VA: 0x1D1B3F4
	internal string FormatUnkownData(byte[] data) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[DefaultMember("Item")]
public sealed class X509ExtensionCollection : ICollection, IEnumerable // TypeDefIndex: 3946
{
	// Fields
	private static byte[] Empty; // 0x0
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x1D1BB24 Offset: 0x1D17B24 VA: 0x1D1BB24
	public void .ctor() { }

	// RVA: 0x1D1D31C Offset: 0x1D1931C VA: 0x1D1D31C Slot: 5
	public int get_Count() { }

	// RVA: 0x1D27598 Offset: 0x1D23598 VA: 0x1D27598 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x1D275B8 Offset: 0x1D235B8 VA: 0x1D275B8 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1D1DD44 Offset: 0x1D19D44 VA: 0x1D1DD44
	public X509Extension get_Item(string oid) { }

	// RVA: 0x1D1BDE0 Offset: 0x1D17DE0 VA: 0x1D1BDE0
	public int Add(X509Extension extension) { }

	// RVA: 0x1D275BC Offset: 0x1D235BC VA: 0x1D275BC Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1D1D33C Offset: 0x1D1933C VA: 0x1D1D33C
	public X509ExtensionEnumerator GetEnumerator() { }

	// RVA: 0x1D27700 Offset: 0x1D23700 VA: 0x1D27700 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1D2775C Offset: 0x1D2375C VA: 0x1D2775C
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509ExtensionEnumerator : IEnumerator // TypeDefIndex: 3947
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Extension Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1D276B4 Offset: 0x1D236B4 VA: 0x1D276B4
	internal void .ctor(ArrayList list) { }

	// RVA: 0x1D1D398 Offset: 0x1D19398 VA: 0x1D1D398
	public X509Extension get_Current() { }

	// RVA: 0x1D277D0 Offset: 0x1D237D0 VA: 0x1D277D0 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1D1D488 Offset: 0x1D19488 VA: 0x1D1D488 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1D27874 Offset: 0x1D23874 VA: 0x1D27874 Slot: 6
	public void Reset() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
internal static class X509Helper2 // TypeDefIndex: 3948
{
	// Methods

	[MonoTODO("Investigate replacement; see comments in source.")]
	// RVA: 0x1D2578C Offset: 0x1D2178C VA: 0x1D2578C
	internal static X509Certificate GetMonoCertificate(X509Certificate2 certificate) { }

	// RVA: 0x1D22224 Offset: 0x1D1E224 VA: 0x1D22224
	internal static X509ChainImpl CreateChainImpl(bool useMachineContext) { }

	// RVA: 0x1D27918 Offset: 0x1D23918 VA: 0x1D27918
	public static bool IsValid(X509ChainImpl impl) { }

	// RVA: 0x1D221A4 Offset: 0x1D1E1A4 VA: 0x1D221A4
	internal static void ThrowIfContextInvalid(X509ChainImpl impl) { }

	// RVA: 0x1D231B4 Offset: 0x1D1F1B4 VA: 0x1D231B4
	internal static Exception GetInvalidChainContextException() { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509KeyUsageExtension : X509Extension // TypeDefIndex: 3949
{
	// Fields
	internal const string oid = "2.5.29.15";
	internal const string friendlyName = "Key Usage";
	internal const X509KeyUsageFlags all = 33023;
	private X509KeyUsageFlags _keyUsages; // 0x24
	private AsnDecodeStatus _status; // 0x28

	// Properties
	public X509KeyUsageFlags KeyUsages { get; }

	// Methods

	// RVA: 0x1D1D554 Offset: 0x1D19554 VA: 0x1D1D554
	public void .ctor() { }

	// RVA: 0x1D19354 Offset: 0x1D15354 VA: 0x1D19354
	public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x1D27ADC Offset: 0x1D23ADC VA: 0x1D27ADC
	public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x1D1F548 Offset: 0x1D1B548 VA: 0x1D1F548
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x1D27D34 Offset: 0x1D23D34 VA: 0x1D27D34 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1D27BB8 Offset: 0x1D23BB8 VA: 0x1D27BB8
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x1D2792C Offset: 0x1D2392C VA: 0x1D2792C
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1D27BC8 Offset: 0x1D23BC8 VA: 0x1D27BC8
	internal byte[] Encode() { }

	// RVA: 0x1D27F00 Offset: 0x1D23F00 VA: 0x1D27F00 Slot: 6
	internal override string ToString(bool multiLine) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509Store : IDisposable // TypeDefIndex: 3950
{
	// Fields
	private string _name; // 0x10
	private StoreLocation _location; // 0x18
	private X509Certificate2Collection list; // 0x20
	private OpenFlags _flags; // 0x28
	private X509Store store; // 0x30

	// Properties
	public X509Certificate2Collection Certificates { get; }
	private X509Stores Factory { get; }
	internal X509Store Store { get; }

	// Methods

	// RVA: 0x1D24384 Offset: 0x1D20384 VA: 0x1D24384
	public void .ctor(StoreName storeName, StoreLocation storeLocation) { }

	// RVA: 0x1D24038 Offset: 0x1D20038 VA: 0x1D24038
	public X509Certificate2Collection get_Certificates() { }

	// RVA: 0x1D28464 Offset: 0x1D24464 VA: 0x1D28464
	private X509Stores get_Factory() { }

	// RVA: 0x1D28480 Offset: 0x1D24480 VA: 0x1D28480
	internal X509Store get_Store() { }

	// RVA: 0x1D23D40 Offset: 0x1D1FD40 VA: 0x1D23D40
	public void Close() { }

	// RVA: 0x1D28488 Offset: 0x1D24488 VA: 0x1D28488 Slot: 4
	public void Dispose() { }

	// RVA: 0x1D244BC Offset: 0x1D204BC VA: 0x1D244BC
	public void Open(OpenFlags flags) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509SubjectKeyIdentifierExtension : X509Extension // TypeDefIndex: 3951
{
	// Fields
	internal const string oid = "2.5.29.14";
	internal const string friendlyName = "Subject Key Identifier";
	private byte[] _subjectKeyIdentifier; // 0x28
	private string _ski; // 0x30
	private AsnDecodeStatus _status; // 0x38

	// Properties
	public string SubjectKeyIdentifier { get; }

	// Methods

	// RVA: 0x1D1D694 Offset: 0x1D19694 VA: 0x1D1D694
	public void .ctor() { }

	// RVA: 0x1D1943C Offset: 0x1D1543C VA: 0x1D1943C
	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x1D285FC Offset: 0x1D245FC VA: 0x1D285FC
	public void .ctor(byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x1D28848 Offset: 0x1D24848 VA: 0x1D28848
	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x1D28AA0 Offset: 0x1D24AA0 VA: 0x1D28AA0
	public void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x1D1E0A0 Offset: 0x1D1A0A0 VA: 0x1D1E0A0
	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x1D1E470 Offset: 0x1D1A470 VA: 0x1D1E470
	public string get_SubjectKeyIdentifier() { }

	// RVA: 0x1D28AAC Offset: 0x1D24AAC VA: 0x1D28AAC Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1D28C78 Offset: 0x1D24C78 VA: 0x1D28C78
	internal static byte FromHexChar(char c) { }

	// RVA: 0x1D28CB4 Offset: 0x1D24CB4 VA: 0x1D28CB4
	internal static byte FromHexChars(char c1, char c2) { }

	// RVA: 0x1D289B0 Offset: 0x1D249B0 VA: 0x1D289B0
	internal static byte[] FromHex(string hex) { }

	// RVA: 0x1D2848C Offset: 0x1D2448C VA: 0x1D2848C
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x1D287D4 Offset: 0x1D247D4 VA: 0x1D287D4
	internal byte[] Encode() { }

	// RVA: 0x1D28D50 Offset: 0x1D24D50 VA: 0x1D28D50 Slot: 6
	internal override string ToString(bool multiLine) { }
}

// Namespace: System.Security.Cryptography.X509Certificates
[Extension]
public static class RSACertificateExtensions // TypeDefIndex: 5353
{
	// Methods

	[Extension]
	// RVA: 0x19A46CC Offset: 0x19A06CC VA: 0x19A46CC
	public static RSA GetRSAPublicKey(X509Certificate2 certificate) { }
}
