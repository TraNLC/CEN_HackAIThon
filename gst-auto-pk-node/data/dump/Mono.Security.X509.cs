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

// Namespace: Mono.Security.X509
internal class SafeBag // TypeDefIndex: 7525
{
	// Fields
	private string _bagOID; // 0x10
	private ASN1 _asn1; // 0x18

	// Properties
	public string BagOID { get; }
	public ASN1 ASN1 { get; }

	// Methods

	// RVA: 0x16F6CD0 Offset: 0x16F2CD0 VA: 0x16F6CD0
	public void .ctor(string bagOID, ASN1 asn1) { }

	// RVA: 0x16F6D14 Offset: 0x16F2D14 VA: 0x16F6D14
	public string get_BagOID() { }

	// RVA: 0x16F6D1C Offset: 0x16F2D1C VA: 0x16F6D1C
	public ASN1 get_ASN1() { }
}

// Namespace: 
public class PKCS12.DeriveBytes // TypeDefIndex: 7526
{
	// Fields
	private static byte[] keyDiversifier; // 0x0
	private static byte[] ivDiversifier; // 0x8
	private static byte[] macDiversifier; // 0x10
	private string _hashName; // 0x10
	private int _iterations; // 0x18
	private byte[] _password; // 0x20
	private byte[] _salt; // 0x28

	// Properties
	public string HashName { set; }
	public int IterationCount { set; }
	public byte[] Password { set; }
	public byte[] Salt { set; }

	// Methods

	// RVA: 0x16F9340 Offset: 0x16F5340 VA: 0x16F9340
	public void .ctor() { }

	// RVA: 0x16FD8F8 Offset: 0x16F98F8 VA: 0x16FD8F8
	public void set_HashName(string value) { }

	// RVA: 0x16FD900 Offset: 0x16F9900 VA: 0x16FD900
	public void set_IterationCount(int value) { }

	// RVA: 0x16F9348 Offset: 0x16F5348 VA: 0x16F9348
	public void set_Password(byte[] value) { }

	// RVA: 0x16F940C Offset: 0x16F540C VA: 0x16F940C
	public void set_Salt(byte[] value) { }

	// RVA: 0x16FD908 Offset: 0x16F9908 VA: 0x16FD908
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x16FD9B8 Offset: 0x16F99B8 VA: 0x16FD9B8
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x16F94C8 Offset: 0x16F54C8 VA: 0x16F94C8
	public byte[] DeriveKey(int size) { }

	// RVA: 0x16F9538 Offset: 0x16F5538 VA: 0x16F9538
	public byte[] DeriveIV(int size) { }

	// RVA: 0x16FACD0 Offset: 0x16F6CD0 VA: 0x16FACD0
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x16FDDE8 Offset: 0x16F9DE8 VA: 0x16FDDE8
	private static void .cctor() { }
}

// Namespace: Mono.Security.X509
public class PKCS12 : ICloneable // TypeDefIndex: 7527
{
	// Fields
	private byte[] _password; // 0x10
	private ArrayList _keyBags; // 0x18
	private ArrayList _secretBags; // 0x20
	private X509CertificateCollection _certs; // 0x28
	private bool _keyBagsChanged; // 0x30
	private bool _secretBagsChanged; // 0x31
	private bool _certsChanged; // 0x32
	private int _iterations; // 0x34
	private ArrayList _safeBags; // 0x38
	private RandomNumberGenerator _rng; // 0x40
	private static int password_max_length; // 0x0

	// Properties
	public string Password { set; }
	public int IterationCount { get; set; }
	public ArrayList Keys { get; }
	public X509CertificateCollection Certificates { get; }
	internal RandomNumberGenerator RNG { get; }
	public static int MaximumPasswordLength { get; }

	// Methods

	// RVA: 0x16F6D24 Offset: 0x16F2D24 VA: 0x16F6D24
	public void .ctor() { }

	// RVA: 0x16F6E28 Offset: 0x16F2E28 VA: 0x16F6E28
	public void .ctor(byte[] data) { }

	// RVA: 0x16F76DC Offset: 0x16F36DC VA: 0x16F76DC
	public void .ctor(byte[] data, string password) { }

	// RVA: 0x16F704C Offset: 0x16F304C VA: 0x16F704C
	private void Decode(byte[] data) { }

	// RVA: 0x16F8000 Offset: 0x16F4000 VA: 0x16F8000 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x16F6E5C Offset: 0x16F2E5C VA: 0x16F6E5C
	public void set_Password(string value) { }

	// RVA: 0x16F80AC Offset: 0x16F40AC VA: 0x16F80AC
	public int get_IterationCount() { }

	// RVA: 0x16F80B4 Offset: 0x16F40B4 VA: 0x16F80B4
	public void set_IterationCount(int value) { }

	// RVA: 0x16F80BC Offset: 0x16F40BC VA: 0x16F80BC
	public ArrayList get_Keys() { }

	// RVA: 0x16F890C Offset: 0x16F490C VA: 0x16F890C
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x16F8D0C Offset: 0x16F4D0C VA: 0x16F8D0C
	internal RandomNumberGenerator get_RNG() { }

	// RVA: 0x16F7870 Offset: 0x16F3870 VA: 0x16F7870
	private bool Compare(byte[] expected, byte[] actual) { }

	// RVA: 0x16F8D3C Offset: 0x16F4D3C VA: 0x16F8D3C
	private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount) { }

	// RVA: 0x16F876C Offset: 0x16F476C VA: 0x16F876C
	public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData) { }

	// RVA: 0x16F7F70 Offset: 0x16F3F70 VA: 0x16F7F70
	public byte[] Decrypt(PKCS7.EncryptedData ed) { }

	// RVA: 0x16F95A8 Offset: 0x16F55A8 VA: 0x16F95A8
	public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data) { }

	// RVA: 0x16F97A8 Offset: 0x16F57A8 VA: 0x16F97A8
	private DSAParameters GetExistingParameters(out bool found) { }

	// RVA: 0x16F9EC8 Offset: 0x16F5EC8 VA: 0x16F9EC8
	private void AddPrivateKey(PKCS8.PrivateKeyInfo pki) { }

	// RVA: 0x16F78D8 Offset: 0x16F38D8 VA: 0x16F78D8
	private void ReadSafeBag(ASN1 safeBag) { }

	// RVA: 0x16FA120 Offset: 0x16F6120 VA: 0x16FA120
	private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes) { }

	// RVA: 0x16F7714 Offset: 0x16F3714 VA: 0x16F7714
	private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data) { }

	// RVA: 0x16FAD40 Offset: 0x16F6D40 VA: 0x16FAD40
	public byte[] GetBytes() { }

	// RVA: 0x16FCCFC Offset: 0x16F8CFC VA: 0x16FCCFC
	private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid) { }

	// RVA: 0x16FCCF4 Offset: 0x16F8CF4 VA: 0x16FCCF4
	public void AddCertificate(X509Certificate cert) { }

	// RVA: 0x16FD04C Offset: 0x16F904C VA: 0x16FD04C
	public void AddCertificate(X509Certificate cert, IDictionary attributes) { }

	// RVA: 0x16FCCEC Offset: 0x16F8CEC VA: 0x16FCCEC
	public void RemoveCertificate(X509Certificate cert) { }

	// RVA: 0x16FD290 Offset: 0x16F9290 VA: 0x16FD290
	public void RemoveCertificate(X509Certificate cert, IDictionary attrs) { }

	// RVA: 0x16FD78C Offset: 0x16F978C VA: 0x16FD78C Slot: 4
	public object Clone() { }

	// RVA: 0x16FD854 Offset: 0x16F9854 VA: 0x16FD854
	public static int get_MaximumPasswordLength() { }

	// RVA: 0x16FD8AC Offset: 0x16F98AC VA: 0x16FD8AC
	private static void .cctor() { }
}

// Namespace: Mono.Security.X509
public sealed class X501 // TypeDefIndex: 7528
{
	// Fields
	private static byte[] countryName; // 0x0
	private static byte[] organizationName; // 0x8
	private static byte[] organizationalUnitName; // 0x10
	private static byte[] commonName; // 0x18
	private static byte[] localityName; // 0x20
	private static byte[] stateOrProvinceName; // 0x28
	private static byte[] streetAddress; // 0x30
	private static byte[] serialNumber; // 0x38
	private static byte[] domainComponent; // 0x40
	private static byte[] userid; // 0x48
	private static byte[] email; // 0x50
	private static byte[] dnQualifier; // 0x58
	private static byte[] title; // 0x60
	private static byte[] surname; // 0x68
	private static byte[] givenName; // 0x70
	private static byte[] initial; // 0x78

	// Methods

	// RVA: 0x16F6A7C Offset: 0x16F2A7C VA: 0x16F6A7C
	public static string ToString(ASN1 seq) { }

	// RVA: 0x16FE6E8 Offset: 0x16FA6E8 VA: 0x16FE6E8
	public static string ToString(ASN1 seq, bool reversed, string separator, bool quotes) { }

	// RVA: 0x16FDF18 Offset: 0x16F9F18 VA: 0x16FDF18
	private static void AppendEntry(StringBuilder sb, ASN1 entry, bool quotes) { }

	// RVA: 0x16FE8A8 Offset: 0x16FA8A8 VA: 0x16FE8A8
	private static void .cctor() { }
}

// Namespace: 
public class X509Crl.X509CrlEntry // TypeDefIndex: 7529
{
	// Fields
	private byte[] sn; // 0x10
	private DateTime revocationDate; // 0x18
	private X509ExtensionCollection extensions; // 0x20

	// Properties
	public byte[] SerialNumber { get; }
	public DateTime RevocationDate { get; }
	public X509ExtensionCollection Extensions { get; }

	// Methods

	// RVA: 0x16FF52C Offset: 0x16FB52C VA: 0x16FF52C
	internal void .ctor(ASN1 entry) { }

	// RVA: 0x16FFB68 Offset: 0x16FBB68 VA: 0x16FFB68
	public byte[] get_SerialNumber() { }

	// RVA: 0x17000F8 Offset: 0x16FC0F8 VA: 0x17000F8
	public DateTime get_RevocationDate() { }

	// RVA: 0x1700100 Offset: 0x16FC100 VA: 0x1700100
	public X509ExtensionCollection get_Extensions() { }
}

// Namespace: Mono.Security.X509
[DefaultMember("Item")]
public class X509Crl // TypeDefIndex: 7530
{
	// Fields
	private string issuer; // 0x10
	private byte version; // 0x18
	private DateTime thisUpdate; // 0x20
	private DateTime nextUpdate; // 0x28
	private ArrayList entries; // 0x30
	private string signatureOID; // 0x38
	private byte[] signature; // 0x40
	private X509ExtensionCollection extensions; // 0x48
	private byte[] encoded; // 0x50
	private byte[] hash_value; // 0x58

	// Properties
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public string IssuerName { get; }
	public DateTime NextUpdate { get; }

	// Methods

	// RVA: 0x16FED5C Offset: 0x16FAD5C VA: 0x16FED5C
	public void .ctor(byte[] crl) { }

	// RVA: 0x16FEE78 Offset: 0x16FAE78 VA: 0x16FEE78
	private void Parse(byte[] crl) { }

	// RVA: 0x16FF750 Offset: 0x16FB750 VA: 0x16FF750
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x16FF758 Offset: 0x16FB758 VA: 0x16FF758
	public byte[] get_Hash() { }

	// RVA: 0x16FF930 Offset: 0x16FB930 VA: 0x16FF930
	public string get_IssuerName() { }

	// RVA: 0x16FF938 Offset: 0x16FB938 VA: 0x16FF938
	public DateTime get_NextUpdate() { }

	// RVA: 0x16FF940 Offset: 0x16FB940 VA: 0x16FF940
	private bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x16FF9A8 Offset: 0x16FB9A8 VA: 0x16FF9A8
	public X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509) { }

	// RVA: 0x16FFA24 Offset: 0x16FBA24 VA: 0x16FFA24
	public X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber) { }

	// RVA: 0x16FFBE0 Offset: 0x16FBBE0 VA: 0x16FFBE0
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x16FFEA4 Offset: 0x16FBEA4 VA: 0x16FFEA4
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x16FFF78 Offset: 0x16FBF78 VA: 0x16FFF78
	public bool VerifySignature(AsymmetricAlgorithm aa) { }
}

// Namespace: Mono.Security.X509
public class X509Certificate : ISerializable // TypeDefIndex: 7531
{
	// Fields
	private ASN1 decoder; // 0x10
	private byte[] m_encodedcert; // 0x18
	private DateTime m_from; // 0x20
	private DateTime m_until; // 0x28
	private ASN1 issuer; // 0x30
	private string m_issuername; // 0x38
	private string m_keyalgo; // 0x40
	private byte[] m_keyalgoparams; // 0x48
	private ASN1 subject; // 0x50
	private string m_subject; // 0x58
	private byte[] m_publickey; // 0x60
	private byte[] signature; // 0x68
	private string m_signaturealgo; // 0x70
	private byte[] m_signaturealgoparams; // 0x78
	private byte[] certhash; // 0x80
	private RSA _rsa; // 0x88
	private DSA _dsa; // 0x90
	private int version; // 0x98
	private byte[] serialnumber; // 0xA0
	private byte[] issuerUniqueID; // 0xA8
	private byte[] subjectUniqueID; // 0xB0
	private X509ExtensionCollection extensions; // 0xB8
	private static string encoding_error; // 0x0

	// Properties
	public DSA DSA { get; set; }
	public X509ExtensionCollection Extensions { get; }
	public byte[] Hash { get; }
	public virtual string IssuerName { get; }
	public virtual string KeyAlgorithm { get; }
	public virtual byte[] KeyAlgorithmParameters { get; set; }
	public virtual byte[] PublicKey { get; }
	public virtual RSA RSA { get; set; }
	public virtual byte[] RawData { get; }
	public virtual byte[] SerialNumber { get; }
	public virtual byte[] Signature { get; }
	public virtual string SubjectName { get; }
	public virtual DateTime ValidFrom { get; }
	public virtual DateTime ValidUntil { get; }
	public int Version { get; }
	public bool IsCurrent { get; }
	public bool IsSelfSigned { get; }

	// Methods

	// RVA: 0x1700108 Offset: 0x16FC108 VA: 0x1700108
	private void Parse(byte[] data) { }

	// RVA: 0x16F6238 Offset: 0x16F2238 VA: 0x16F6238
	public void .ctor(byte[] data) { }

	// RVA: 0x1700C1C Offset: 0x16FCC1C VA: 0x1700C1C
	private byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x16F9B44 Offset: 0x16F5B44 VA: 0x16F9B44
	public DSA get_DSA() { }

	// RVA: 0x1700CB0 Offset: 0x16FCCB0 VA: 0x1700CB0
	public void set_DSA(DSA value) { }

	// RVA: 0x1700CF0 Offset: 0x16FCCF0 VA: 0x1700CF0
	public X509ExtensionCollection get_Extensions() { }

	// RVA: 0x1700CF8 Offset: 0x16FCCF8 VA: 0x1700CF8
	public byte[] get_Hash() { }

	// RVA: 0x1700F48 Offset: 0x16FCF48 VA: 0x1700F48 Slot: 5
	public virtual string get_IssuerName() { }

	// RVA: 0x1700F50 Offset: 0x16FCF50 VA: 0x1700F50 Slot: 6
	public virtual string get_KeyAlgorithm() { }

	// RVA: 0x1700F58 Offset: 0x16FCF58 VA: 0x1700F58 Slot: 7
	public virtual byte[] get_KeyAlgorithmParameters() { }

	// RVA: 0x1700FCC Offset: 0x16FCFCC VA: 0x1700FCC Slot: 8
	public virtual void set_KeyAlgorithmParameters(byte[] value) { }

	// RVA: 0x1700FD4 Offset: 0x16FCFD4 VA: 0x1700FD4 Slot: 9
	public virtual byte[] get_PublicKey() { }

	// RVA: 0x1701048 Offset: 0x16FD048 VA: 0x1701048 Slot: 10
	public virtual RSA get_RSA() { }

	// RVA: 0x17011FC Offset: 0x16FD1FC VA: 0x17011FC Slot: 11
	public virtual void set_RSA(RSA value) { }

	// RVA: 0x1701238 Offset: 0x16FD238 VA: 0x1701238 Slot: 12
	public virtual byte[] get_RawData() { }

	// RVA: 0x17012AC Offset: 0x16FD2AC VA: 0x17012AC Slot: 13
	public virtual byte[] get_SerialNumber() { }

	// RVA: 0x1701320 Offset: 0x16FD320 VA: 0x1701320 Slot: 14
	public virtual byte[] get_Signature() { }

	// RVA: 0x1701754 Offset: 0x16FD754 VA: 0x1701754 Slot: 15
	public virtual string get_SubjectName() { }

	// RVA: 0x170175C Offset: 0x16FD75C VA: 0x170175C Slot: 16
	public virtual DateTime get_ValidFrom() { }

	// RVA: 0x1701764 Offset: 0x16FD764 VA: 0x1701764 Slot: 17
	public virtual DateTime get_ValidUntil() { }

	// RVA: 0x170176C Offset: 0x16FD76C VA: 0x170176C
	public int get_Version() { }

	// RVA: 0x1701774 Offset: 0x16FD774 VA: 0x1701774
	public bool get_IsCurrent() { }

	// RVA: 0x17017D4 Offset: 0x16FD7D4 VA: 0x17017D4
	public bool WasCurrent(DateTime instant) { }

	// RVA: 0x17018AC Offset: 0x16FD8AC VA: 0x17018AC
	internal bool VerifySignature(DSA dsa) { }

	// RVA: 0x1701974 Offset: 0x16FD974 VA: 0x1701974
	internal bool VerifySignature(RSA rsa) { }

	// RVA: 0x1701A9C Offset: 0x16FDA9C VA: 0x1701A9C
	public bool VerifySignature(AsymmetricAlgorithm aa) { }

	// RVA: 0x1701C1C Offset: 0x16FDC1C VA: 0x1701C1C
	public bool get_IsSelfSigned() { }

	// RVA: 0x1701D24 Offset: 0x16FDD24 VA: 0x1701D24 Slot: 18
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1700AE8 Offset: 0x16FCAE8 VA: 0x1700AE8
	private static byte[] PEM(string type, byte[] data) { }

	// RVA: 0x1701D80 Offset: 0x16FDD80 VA: 0x1701D80
	private static void .cctor() { }
}

// Namespace: 
public class X509CertificateCollection.X509CertificateEnumerator : IEnumerator // TypeDefIndex: 7532
{
	// Fields
	private IEnumerator enumerator; // 0x10

	// Properties
	public X509Certificate Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x17020B0 Offset: 0x16FE0B0 VA: 0x17020B0
	public void .ctor(X509CertificateCollection mappings) { }

	// RVA: 0x16F9A54 Offset: 0x16F5A54 VA: 0x16F9A54
	public X509Certificate get_Current() { }

	// RVA: 0x1702210 Offset: 0x16FE210 VA: 0x1702210 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x17022B4 Offset: 0x16FE2B4 VA: 0x17022B4 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1702354 Offset: 0x16FE354 VA: 0x1702354 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x16F9E28 Offset: 0x16F5E28 VA: 0x16F9E28
	public bool MoveNext() { }
}

// Namespace: Mono.Security.X509
[DefaultMember("Item")]
[Serializable]
public class X509CertificateCollection : CollectionBase, IEnumerable // TypeDefIndex: 7533
{
	// Properties
	public X509Certificate Item { get; }

	// Methods

	// RVA: 0x16F6230 Offset: 0x16F2230 VA: 0x16F6230
	public void .ctor() { }

	// RVA: 0x1701DE8 Offset: 0x16FDDE8 VA: 0x1701DE8
	public X509Certificate get_Item(int index) { }

	// RVA: 0x16F63C4 Offset: 0x16F23C4 VA: 0x16F63C4
	public int Add(X509Certificate value) { }

	// RVA: 0x1701E80 Offset: 0x16FDE80 VA: 0x1701E80
	public void AddRange(X509CertificateCollection value) { }

	// RVA: 0x1701F50 Offset: 0x16FDF50 VA: 0x1701F50
	public bool Contains(X509Certificate value) { }

	// RVA: 0x16F99FC Offset: 0x16F59FC VA: 0x16F99FC
	public X509CertificateCollection.X509CertificateEnumerator GetEnumerator() { }

	// RVA: 0x170216C Offset: 0x16FE16C VA: 0x170216C Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x170218C Offset: 0x16FE18C VA: 0x170218C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1701F68 Offset: 0x16FDF68 VA: 0x1701F68
	public int IndexOf(X509Certificate value) { }

	// RVA: 0x17021A8 Offset: 0x16FE1A8 VA: 0x17021A8
	private bool Compare(byte[] array1, byte[] array2) { }
}

// Namespace: Mono.Security.X509
public class X509Chain // TypeDefIndex: 7534
{
	// Fields
	private X509CertificateCollection roots; // 0x10
	private X509CertificateCollection certs; // 0x18
	private X509Certificate _root; // 0x20
	private X509CertificateCollection _chain; // 0x28
	private X509ChainStatusFlags _status; // 0x30

	// Properties
	public X509CertificateCollection TrustAnchors { get; }

	// Methods

	// RVA: 0x17023F8 Offset: 0x16FE3F8 VA: 0x17023F8
	public void .ctor() { }

	// RVA: 0x1702464 Offset: 0x16FE464 VA: 0x1702464
	public X509CertificateCollection get_TrustAnchors() { }

	// RVA: 0x170258C Offset: 0x16FE58C VA: 0x170258C
	public void LoadCertificates(X509CertificateCollection collection) { }

	// RVA: 0x17025A0 Offset: 0x16FE5A0 VA: 0x17025A0
	public bool Build(X509Certificate leaf) { }

	// RVA: 0x1702EC8 Offset: 0x16FEEC8 VA: 0x1702EC8
	public void Reset() { }

	// RVA: 0x1702E1C Offset: 0x16FEE1C VA: 0x1702E1C
	private bool IsValid(X509Certificate cert) { }

	// RVA: 0x1702924 Offset: 0x16FE924 VA: 0x1702924
	private X509Certificate FindCertificateParent(X509Certificate child) { }

	// RVA: 0x1702AC8 Offset: 0x16FEAC8 VA: 0x1702AC8
	private X509Certificate FindCertificateRoot(X509Certificate potentialRoot) { }

	// RVA: 0x1702F24 Offset: 0x16FEF24 VA: 0x1702F24
	private bool IsTrusted(X509Certificate potentialTrusted) { }

	// RVA: 0x1702CD8 Offset: 0x16FECD8 VA: 0x1702CD8
	private bool IsParent(X509Certificate child, X509Certificate parent) { }
}

// Namespace: Mono.Security.X509
[Flags]
[Serializable]
public enum X509ChainStatusFlags // TypeDefIndex: 7535
{
	// Fields
	public int value__; // 0x0
	public const X509ChainStatusFlags InvalidBasicConstraints = 1024;
	public const X509ChainStatusFlags NoError = 0;
	public const X509ChainStatusFlags NotSignatureValid = 8;
	public const X509ChainStatusFlags NotTimeNested = 2;
	public const X509ChainStatusFlags NotTimeValid = 1;
	public const X509ChainStatusFlags PartialChain = 65536;
	public const X509ChainStatusFlags UntrustedRoot = 32;
}

// Namespace: Mono.Security.X509
public class X509Extension // TypeDefIndex: 7536
{
	// Fields
	protected string extnOid; // 0x10
	protected bool extnCritical; // 0x18
	protected ASN1 extnValue; // 0x20

	// Properties
	public string Oid { get; }
	public bool Critical { get; }
	public ASN1 Value { get; }

	// Methods

	// RVA: 0x1703004 Offset: 0x16FF004 VA: 0x1703004
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x17032E4 Offset: 0x16FF2E4 VA: 0x17032E4
	public void .ctor(X509Extension extension) { }

	// RVA: 0x1703464 Offset: 0x16FF464 VA: 0x1703464 Slot: 4
	protected virtual void Decode() { }

	// RVA: 0x1703468 Offset: 0x16FF468 VA: 0x1703468 Slot: 5
	protected virtual void Encode() { }

	// RVA: 0x170346C Offset: 0x16FF46C VA: 0x170346C
	public string get_Oid() { }

	// RVA: 0x1703474 Offset: 0x16FF474 VA: 0x1703474
	public bool get_Critical() { }

	// RVA: 0x1703438 Offset: 0x16FF438 VA: 0x1703438
	public ASN1 get_Value() { }

	// RVA: 0x170347C Offset: 0x16FF47C VA: 0x170347C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17035A8 Offset: 0x16FF5A8 VA: 0x17035A8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17035C4 Offset: 0x16FF5C4 VA: 0x17035C4
	private void WriteLine(StringBuilder sb, int n, int pos) { }

	// RVA: 0x17037EC Offset: 0x16FF7EC VA: 0x17037EC Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.X509
[DefaultMember("Item")]
public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 7537
{
	// Fields
	private bool readOnly; // 0x18

	// Properties
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x17038C4 Offset: 0x16FF8C4 VA: 0x17038C4
	public void .ctor() { }

	// RVA: 0x16FF61C Offset: 0x16FB61C VA: 0x16FF61C
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x17038CC Offset: 0x16FF8CC VA: 0x17038CC
	public int IndexOf(string oid) { }

	// RVA: 0x1703A04 Offset: 0x16FFA04 VA: 0x1703A04 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1702F50 Offset: 0x16FEF50 VA: 0x1702F50
	public X509Extension get_Item(string oid) { }
}

// Namespace: Mono.Security.X509
public class X509Store // TypeDefIndex: 7538
{
	// Fields
	private string _storePath; // 0x10
	private X509CertificateCollection _certificates; // 0x18
	private ArrayList _crls; // 0x20
	private bool _crl; // 0x28
	private bool _newFormat; // 0x29

	// Properties
	public X509CertificateCollection Certificates { get; }
	public ArrayList Crls { get; }

	// Methods

	// RVA: 0x1703A24 Offset: 0x16FFA24 VA: 0x1703A24
	internal void .ctor(string path, bool crl, bool newFormat) { }

	// RVA: 0x1703A70 Offset: 0x16FFA70 VA: 0x1703A70
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x1703C8C Offset: 0x16FFC8C VA: 0x1703C8C
	public ArrayList get_Crls() { }

	// RVA: 0x1703EE8 Offset: 0x16FFEE8 VA: 0x1703EE8
	private byte[] Load(string filename) { }

	// RVA: 0x17040AC Offset: 0x17000AC VA: 0x17040AC
	private X509Certificate LoadCertificate(string filename) { }

	// RVA: 0x1704114 Offset: 0x1700114 VA: 0x1704114
	private X509Crl LoadCrl(string filename) { }

	// RVA: 0x170417C Offset: 0x170017C VA: 0x170417C
	private bool CheckStore(string path, bool throwException) { }

	// RVA: 0x1703AB4 Offset: 0x16FFAB4 VA: 0x1703AB4
	private X509CertificateCollection BuildCertificatesCollection(string storeName) { }

	// RVA: 0x1703D24 Offset: 0x16FFD24 VA: 0x1703D24
	private ArrayList BuildCrlsCollection(string storeName) { }
}

// Namespace: Mono.Security.X509
public sealed class X509StoreManager // TypeDefIndex: 7539
{
	// Fields
	private static string _userPath; // 0x0
	private static string _localMachinePath; // 0x8
	private static X509Stores _userStore; // 0x10
	private static X509Stores _machineStore; // 0x18

	// Properties
	internal static string CurrentUserPath { get; }
	internal static string LocalMachinePath { get; }
	public static X509Stores CurrentUser { get; }
	public static X509Stores LocalMachine { get; }
	public static X509CertificateCollection TrustedRootCertificates { get; }

	// Methods

	// RVA: 0x1704258 Offset: 0x1700258 VA: 0x1704258
	internal static string get_CurrentUserPath() { }

	// RVA: 0x1704370 Offset: 0x1700370 VA: 0x1704370
	internal static string get_LocalMachinePath() { }

	// RVA: 0x1704480 Offset: 0x1700480 VA: 0x1704480
	public static X509Stores get_CurrentUser() { }

	// RVA: 0x1704570 Offset: 0x1700570 VA: 0x1704570
	public static X509Stores get_LocalMachine() { }

	// RVA: 0x17024F0 Offset: 0x16FE4F0 VA: 0x17024F0
	public static X509CertificateCollection get_TrustedRootCertificates() { }
}

// Namespace: Mono.Security.X509
public class X509Stores // TypeDefIndex: 7540
{
	// Fields
	private string _storePath; // 0x10
	private bool _newFormat; // 0x18
	private X509Store _trusted; // 0x20

	// Properties
	public X509Store TrustedRoot { get; }

	// Methods

	// RVA: 0x1704534 Offset: 0x1700534 VA: 0x1704534
	internal void .ctor(string path, bool newFormat) { }

	// RVA: 0x1704624 Offset: 0x1700624 VA: 0x1704624
	public X509Store get_TrustedRoot() { }

	// RVA: 0x1704714 Offset: 0x1700714 VA: 0x1704714
	public X509Store Open(string storeName, bool create) { }
}
