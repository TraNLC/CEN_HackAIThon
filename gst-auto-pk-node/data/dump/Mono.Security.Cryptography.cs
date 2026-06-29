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

// Namespace: Mono.Security.Cryptography
internal sealed class CryptoConvert // TypeDefIndex: 69
{
	// Methods

	// RVA: 0x1726C6C Offset: 0x1722C6C VA: 0x1726C6C
	private static int ToInt32LE(byte[] bytes, int offset) { }

	// RVA: 0x1726CE0 Offset: 0x1722CE0 VA: 0x1726CE0
	private static uint ToUInt32LE(byte[] bytes, int offset) { }

	// RVA: 0x1726D54 Offset: 0x1722D54 VA: 0x1726D54
	private static byte[] Trim(byte[] array) { }

	// RVA: 0x1726E0C Offset: 0x1722E0C VA: 0x1726E0C
	public static RSA FromCapiPrivateKeyBlob(byte[] blob, int offset) { }

	// RVA: 0x1726E64 Offset: 0x1722E64 VA: 0x1726E64
	private static RSAParameters GetParametersFromCapiPrivateKeyBlob(byte[] blob, int offset) { }

	// RVA: 0x1727444 Offset: 0x1723444 VA: 0x1727444
	public static RSA FromCapiPublicKeyBlob(byte[] blob, int offset) { }

	// RVA: 0x1727584 Offset: 0x1723584 VA: 0x1727584
	private static RSAParameters GetParametersFromCapiPublicKeyBlob(byte[] blob, int offset) { }

	// RVA: 0x17279A8 Offset: 0x17239A8 VA: 0x17279A8
	public static RSA FromCapiKeyBlob(byte[] blob) { }

	// RVA: 0x17279B0 Offset: 0x17239B0 VA: 0x17279B0
	public static RSA FromCapiKeyBlob(byte[] blob, int offset) { }
}

// Namespace: Mono.Security.Cryptography
internal sealed class KeyBuilder // TypeDefIndex: 70
{
	// Fields
	private static RandomNumberGenerator rng; // 0x0

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x1727AC4 Offset: 0x1723AC4 VA: 0x1727AC4
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1727B3C Offset: 0x1723B3C VA: 0x1727B3C
	public static byte[] Key(int size) { }

	// RVA: 0x1727BAC Offset: 0x1723BAC VA: 0x1727BAC
	public static byte[] IV(int size) { }
}

// Namespace: Mono.Security.Cryptography
internal class KeyPairPersistence // TypeDefIndex: 71
{
	// Fields
	private static bool _userPathExists; // 0x0
	private static string _userPath; // 0x8
	private static bool _machinePathExists; // 0x10
	private static string _machinePath; // 0x18
	private CspParameters _params; // 0x10
	private string _keyvalue; // 0x18
	private string _filename; // 0x20
	private string _container; // 0x28
	private static object lockobj; // 0x20

	// Properties
	public string Filename { get; }
	public string KeyValue { get; set; }
	private static string UserPath { get; }
	private static string MachinePath { get; }
	private bool CanChange { get; }
	private bool UseDefaultKeyContainer { get; }
	private bool UseMachineKeyStore { get; }
	private string ContainerName { get; }

	// Methods

	// RVA: 0x1727C1C Offset: 0x1723C1C VA: 0x1727C1C
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x1727C24 Offset: 0x1723C24 VA: 0x1727C24
	public void .ctor(CspParameters parameters, string keyPair) { }

	// RVA: 0x1727D50 Offset: 0x1723D50 VA: 0x1727D50
	public string get_Filename() { }

	// RVA: 0x1728B70 Offset: 0x1724B70 VA: 0x1728B70
	public string get_KeyValue() { }

	// RVA: 0x1728B78 Offset: 0x1724B78 VA: 0x1728B78
	public void set_KeyValue(string value) { }

	// RVA: 0x1728B9C Offset: 0x1724B9C VA: 0x1728B9C
	public bool Load() { }

	// RVA: 0x1728E30 Offset: 0x1724E30 VA: 0x1728E30
	public void Save() { }

	// RVA: 0x1729368 Offset: 0x1725368 VA: 0x1729368
	public void Remove() { }

	// RVA: 0x1728610 Offset: 0x1724610 VA: 0x1728610
	private static string get_UserPath() { }

	// RVA: 0x17280B0 Offset: 0x17240B0 VA: 0x17280B0
	private static string get_MachinePath() { }

	// RVA: 0x17294E0 Offset: 0x17254E0 VA: 0x17294E0
	internal static bool _CanSecure(char* root) { }

	// RVA: 0x17294E4 Offset: 0x17254E4 VA: 0x17294E4
	internal static bool _ProtectUser(char* path) { }

	// RVA: 0x17294E8 Offset: 0x17254E8 VA: 0x17294E8
	internal static bool _ProtectMachine(char* path) { }

	// RVA: 0x17294EC Offset: 0x17254EC VA: 0x17294EC
	internal static bool _IsUserProtected(char* path) { }

	// RVA: 0x17294F0 Offset: 0x17254F0 VA: 0x17294F0
	internal static bool _IsMachineProtected(char* path) { }

	// RVA: 0x17294F4 Offset: 0x17254F4 VA: 0x17294F4
	private static bool CanSecure(string path) { }

	// RVA: 0x17292D8 Offset: 0x17252D8 VA: 0x17292D8
	private static bool ProtectUser(string path) { }

	// RVA: 0x1729248 Offset: 0x1725248 VA: 0x1729248
	private static bool ProtectMachine(string path) { }

	// RVA: 0x17293C0 Offset: 0x17253C0 VA: 0x17293C0
	private static bool IsUserProtected(string path) { }

	// RVA: 0x1729450 Offset: 0x1725450 VA: 0x1729450
	private static bool IsMachineProtected(string path) { }

	// RVA: 0x1728B8C Offset: 0x1724B8C VA: 0x1728B8C
	private bool get_CanChange() { }

	// RVA: 0x1729594 Offset: 0x1725594 VA: 0x1729594
	private bool get_UseDefaultKeyContainer() { }

	// RVA: 0x1728094 Offset: 0x1724094 VA: 0x1728094
	private bool get_UseMachineKeyStore() { }

	// RVA: 0x1727F20 Offset: 0x1723F20 VA: 0x1727F20
	private string get_ContainerName() { }

	// RVA: 0x1727CBC Offset: 0x1723CBC VA: 0x1727CBC
	private CspParameters Copy(CspParameters p) { }

	// RVA: 0x1728CF8 Offset: 0x1724CF8 VA: 0x1728CF8
	private void FromXml(string xml) { }

	// RVA: 0x1729040 Offset: 0x1725040 VA: 0x1729040
	private string ToXml() { }

	// RVA: 0x17295B4 Offset: 0x17255B4 VA: 0x17295B4
	private static void .cctor() { }
}

// Namespace: Mono.Security.Cryptography
internal abstract class MD2 : HashAlgorithm // TypeDefIndex: 72
{
	// Methods

	// RVA: 0x1729628 Offset: 0x1725628 VA: 0x1729628
	protected void .ctor() { }

	// RVA: 0x1729648 Offset: 0x1725648 VA: 0x1729648
	public static MD2 Create() { }
}

// Namespace: Mono.Security.Cryptography
internal class MD2Managed : MD2 // TypeDefIndex: 73
{
	// Fields
	private byte[] state; // 0x28
	private byte[] checksum; // 0x30
	private byte[] buffer; // 0x38
	private int count; // 0x40
	private byte[] x; // 0x48
	private static readonly byte[] PI_SUBST; // 0x0

	// Methods

	// RVA: 0x172976C Offset: 0x172576C VA: 0x172976C
	private byte[] Padding(int nLength) { }

	// RVA: 0x1729698 Offset: 0x1725698 VA: 0x1729698
	public void .ctor() { }

	// RVA: 0x1729804 Offset: 0x1725804 VA: 0x1729804 Slot: 18
	public override void Initialize() { }

	// RVA: 0x1729864 Offset: 0x1725864 VA: 0x1729864 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x1729BA4 Offset: 0x1725BA4 VA: 0x1729BA4 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1729940 Offset: 0x1725940 VA: 0x1729940
	private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) { }

	// RVA: 0x1729C94 Offset: 0x1725C94 VA: 0x1729C94
	private static void .cctor() { }
}

// Namespace: Mono.Security.Cryptography
internal abstract class MD4 : HashAlgorithm // TypeDefIndex: 74
{
	// Methods

	// RVA: 0x1729D34 Offset: 0x1725D34 VA: 0x1729D34
	protected void .ctor() { }

	// RVA: 0x1729D54 Offset: 0x1725D54 VA: 0x1729D54
	public static MD4 Create() { }
}

// Namespace: Mono.Security.Cryptography
internal class MD4Managed : MD4 // TypeDefIndex: 75
{
	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x1729DA4 Offset: 0x1725DA4 VA: 0x1729DA4
	public void .ctor() { }

	// RVA: 0x1729EB0 Offset: 0x1725EB0 VA: 0x1729EB0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x1729F64 Offset: 0x1725F64 VA: 0x1729F64 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x172A6F8 Offset: 0x17266F8 VA: 0x172A6F8 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x172A8EC Offset: 0x17268EC VA: 0x172A8EC
	private byte[] Padding(int nLength) { }

	// RVA: 0x172A964 Offset: 0x1726964 VA: 0x172A964
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x172A974 Offset: 0x1726974 VA: 0x172A974
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x172A988 Offset: 0x1726988 VA: 0x172A988
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x172A994 Offset: 0x1726994 VA: 0x172A994
	private uint ROL(uint x, byte n) { }

	// RVA: 0x172A9A0 Offset: 0x17269A0 VA: 0x172A9A0
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x172A9C8 Offset: 0x17269C8 VA: 0x172A9C8
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x172AA00 Offset: 0x1726A00 VA: 0x172AA00
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x172A7F4 Offset: 0x17267F4 VA: 0x172A7F4
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x172AA30 Offset: 0x1726A30 VA: 0x172AA30
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x172A088 Offset: 0x1726088 VA: 0x172A088
	private void MD4Transform(uint[] state, byte[] block, int index) { }
}

// Namespace: Mono.Security.Cryptography
internal sealed class PKCS1 // TypeDefIndex: 76
{
	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x172AAFC Offset: 0x1726AFC VA: 0x172AAFC
	private static bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x172AB64 Offset: 0x1726B64 VA: 0x172AB64
	public static byte[] I2OSP(byte[] x, int size) { }

	// RVA: 0x172ABF0 Offset: 0x1726BF0 VA: 0x172ABF0
	public static byte[] OS2IP(byte[] x) { }

	// RVA: 0x172ACB4 Offset: 0x1726CB4 VA: 0x172ACB4
	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	// RVA: 0x172ACCC Offset: 0x1726CCC VA: 0x172ACCC
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature) { }

	// RVA: 0x172AF24 Offset: 0x1726F24 VA: 0x172AF24
	internal static bool Verify_v15(RSA rsa, string hashName, byte[] hashValue, byte[] signature) { }

	// RVA: 0x172AD4C Offset: 0x1726D4C VA: 0x172AD4C
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0x172B484 Offset: 0x1727484 VA: 0x172B484
	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	// RVA: 0x172B0B4 Offset: 0x17270B4 VA: 0x172B0B4
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x172B860 Offset: 0x1727860 VA: 0x172B860
	private static void .cctor() { }
}

// Namespace: 
public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 77
{
	// Methods

	// RVA: 0x172DF3C Offset: 0x1729F3C VA: 0x172DF3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x172E048 Offset: 0x172A048 VA: 0x172E048 Slot: 12
	public virtual void Invoke(object sender, EventArgs e) { }
}

// Namespace: Mono.Security.Cryptography
internal class RSAManaged : RSA // TypeDefIndex: 78
{
	// Fields
	private bool isCRTpossible; // 0x20
	private bool keyBlinding; // 0x21
	private bool keypairGenerated; // 0x22
	private bool m_disposed; // 0x23
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGenerated]
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x172B9D4 Offset: 0x17279D4 VA: 0x172B9D4
	public void .ctor(int keySize) { }

	// RVA: 0x172BABC Offset: 0x1727ABC VA: 0x172BABC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x172BB4C Offset: 0x1727B4C VA: 0x172BB4C
	private void GenerateKeyPair() { }

	// RVA: 0x172C428 Offset: 0x1728428 VA: 0x172C428 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x172C4C4 Offset: 0x17284C4 VA: 0x172C4C4
	public bool get_PublicOnly() { }

	// RVA: 0x172C614 Offset: 0x1728614 VA: 0x172C614 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x172CACC Offset: 0x1728ACC VA: 0x172CACC Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x172CF90 Offset: 0x1728F90 VA: 0x172CF90 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x172D4DC Offset: 0x17294DC VA: 0x172D4DC Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	// RVA: 0x172D760 Offset: 0x1729760 VA: 0x172D760
	public void add_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x172D7FC Offset: 0x17297FC VA: 0x172D7FC
	public void remove_KeyGenerated(RSAManaged.KeyGeneratedEventHandler value) { }

	// RVA: 0x172D898 Offset: 0x1729898 VA: 0x172D898 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x172C9C8 Offset: 0x17289C8 VA: 0x172C9C8
	private byte[] GetPaddedValue(BigInteger value, int length) { }
}

// Namespace: Mono.Security.Cryptography
internal abstract class SymmetricTransform : ICryptoTransform, IDisposable // TypeDefIndex: 79
{
	// Fields
	protected SymmetricAlgorithm algo; // 0x10
	protected bool encrypt; // 0x18
	protected int BlockSizeByte; // 0x1C
	protected byte[] temp; // 0x20
	protected byte[] temp2; // 0x28
	private byte[] workBuff; // 0x30
	private byte[] workout; // 0x38
	protected PaddingMode padmode; // 0x40
	protected int FeedBackByte; // 0x44
	private bool m_disposed; // 0x48
	protected bool lastBlock; // 0x49
	private RandomNumberGenerator _rng; // 0x50

	// Properties
	public virtual bool CanTransformMultipleBlocks { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	private bool KeepLastBlock { get; }

	// Methods

	// RVA: 0x172E05C Offset: 0x172A05C VA: 0x172E05C
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x172E344 Offset: 0x172A344 VA: 0x172E344 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x172E3D4 Offset: 0x172A3D4 VA: 0x172E3D4 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x172E440 Offset: 0x172A440 VA: 0x172E440 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x172E4C0 Offset: 0x172A4C0 VA: 0x172E4C0 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x172E4C8 Offset: 0x172A4C8 VA: 0x172E4C8 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x172E4D0 Offset: 0x172A4D0 VA: 0x172E4D0 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x172E4D8 Offset: 0x172A4D8 VA: 0x172E4D8 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output);

	// RVA: 0x172E648 Offset: 0x172A648 VA: 0x172E648 Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x172E7AC Offset: 0x172A7AC VA: 0x172E7AC Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x172E974 Offset: 0x172A974 VA: 0x172E974 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x172E9C0 Offset: 0x172A9C0 VA: 0x172E9C0 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x172EA0C Offset: 0x172AA0C VA: 0x172EA0C
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x172EB50 Offset: 0x172AB50 VA: 0x172EB50 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x172ED58 Offset: 0x172AD58 VA: 0x172ED58
	private bool get_KeepLastBlock() { }

	// RVA: 0x172ED7C Offset: 0x172AD7C VA: 0x172ED7C
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x172EF34 Offset: 0x172AF34 VA: 0x172EF34
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x172EFF0 Offset: 0x172AFF0 VA: 0x172EFF0
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x172F188 Offset: 0x172B188 VA: 0x172F188 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x172F41C Offset: 0x172B41C VA: 0x172F41C Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x172F6B4 Offset: 0x172B6B4 VA: 0x172F6B4 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}

// Namespace: 
public sealed class DSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 80
{
	// Methods

	// RVA: 0x17313EC Offset: 0x172D3EC VA: 0x17313EC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17314F8 Offset: 0x172D4F8 VA: 0x17314F8 Slot: 12
	public virtual void Invoke(object sender, EventArgs e) { }
}

// Namespace: Mono.Security.Cryptography
internal class DSAManaged : DSA // TypeDefIndex: 81
{
	// Fields
	private bool keypairGenerated; // 0x20
	private bool m_disposed; // 0x21
	private BigInteger p; // 0x28
	private BigInteger q; // 0x30
	private BigInteger g; // 0x38
	private BigInteger x; // 0x40
	private BigInteger y; // 0x48
	private BigInteger j; // 0x50
	private BigInteger seed; // 0x58
	private int counter; // 0x60
	private bool j_missing; // 0x64
	private RandomNumberGenerator rng; // 0x68
	[CompilerGenerated]
	private DSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x70

	// Properties
	private RandomNumberGenerator Random { get; }
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x172F770 Offset: 0x172B770 VA: 0x172F770
	public void .ctor(int dwKeySize) { }

	// RVA: 0x172F840 Offset: 0x172B840 VA: 0x172F840 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x172F8D0 Offset: 0x172B8D0 VA: 0x172F8D0
	private void Generate() { }

	// RVA: 0x172FE74 Offset: 0x172BE74 VA: 0x172FE74
	private void GenerateKeyPair() { }

	// RVA: 0x17300A4 Offset: 0x172C0A4 VA: 0x17300A4
	private void add(byte[] a, byte[] b, int value) { }

	// RVA: 0x172F91C Offset: 0x172B91C VA: 0x172F91C
	private void GenerateParams(int keyLength) { }

	// RVA: 0x173013C Offset: 0x172C13C VA: 0x173013C
	private RandomNumberGenerator get_Random() { }

	// RVA: 0x1730480 Offset: 0x172C480 VA: 0x1730480 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x17304A4 Offset: 0x172C4A4 VA: 0x17304A4
	public bool get_PublicOnly() { }

	// RVA: 0x1730518 Offset: 0x172C518 VA: 0x1730518
	private byte[] NormalizeArray(byte[] array) { }

	// RVA: 0x17305B8 Offset: 0x172C5B8 VA: 0x17305B8 Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x17308D8 Offset: 0x172C8D8 VA: 0x17308D8 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x1730BE8 Offset: 0x172CBE8 VA: 0x1730BE8 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x1731074 Offset: 0x172D074 VA: 0x1731074 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	// RVA: 0x17312B4 Offset: 0x172D2B4 VA: 0x17312B4
	public void add_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1731350 Offset: 0x172D350 VA: 0x1731350
	public void remove_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }
}

// Namespace: 
public enum BigInteger.Sign // TypeDefIndex: 82
{
	// Fields
	public int value__; // 0x0
	public const BigInteger.Sign Negative = -1;
	public const BigInteger.Sign Zero = 0;
	public const BigInteger.Sign Positive = 1;
}

// Namespace: 
internal sealed class BigInteger.ModulusRing // TypeDefIndex: 83
{
	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0x1733550 Offset: 0x172F550 VA: 0x1733550
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x17338E4 Offset: 0x172F8E4 VA: 0x17338E4
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x1733EDC Offset: 0x172FEDC VA: 0x1733EDC
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x1734058 Offset: 0x1730058 VA: 0x1734058
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x1733650 Offset: 0x172F650 VA: 0x1733650
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	// RVA: 0x173420C Offset: 0x173020C VA: 0x173420C
	public BigInteger Pow(uint b, BigInteger exp) { }
}

// Namespace: 
private sealed class BigInteger.Kernel // TypeDefIndex: 84
{
	// Methods

	// RVA: 0x173198C Offset: 0x172D98C VA: 0x173198C
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x1733C4C Offset: 0x172FC4C VA: 0x1733C4C
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x1733D50 Offset: 0x172FD50 VA: 0x1733D50
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1731848 Offset: 0x172D848 VA: 0x1731848
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1732D40 Offset: 0x172ED40 VA: 0x1732D40
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x1731B38 Offset: 0x172DB38 VA: 0x1731B38
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x173427C Offset: 0x173027C VA: 0x173427C
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x1731B9C Offset: 0x172DB9C VA: 0x1731B9C
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1732240 Offset: 0x172E240 VA: 0x1732240
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x1732414 Offset: 0x172E414 VA: 0x1732414
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x173214C Offset: 0x172E14C VA: 0x173214C
	public static BigInteger MultiplyByDword(BigInteger n, uint f) { }

	// RVA: 0x1732068 Offset: 0x172E068 VA: 0x1732068
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x1733B3C Offset: 0x172FB3C VA: 0x1733B3C
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x173441C Offset: 0x173041C VA: 0x173441C
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x1732F74 Offset: 0x172EF74 VA: 0x1732F74
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }
}

// Namespace: Mono.Security.Cryptography
public sealed class CryptoConvert // TypeDefIndex: 7567
{
	// Methods

	// RVA: 0x1709960 Offset: 0x1705960 VA: 0x1709960
	public static string ToHex(byte[] input) { }
}

// Namespace: Mono.Security.Cryptography
public abstract class MD2 : HashAlgorithm // TypeDefIndex: 7568
{
	// Methods

	// RVA: 0x1709A9C Offset: 0x1705A9C VA: 0x1709A9C
	protected void .ctor() { }

	// RVA: 0x1709ABC Offset: 0x1705ABC VA: 0x1709ABC
	public static MD2 Create() { }
}

// Namespace: Mono.Security.Cryptography
public class MD2Managed : MD2 // TypeDefIndex: 7569
{
	// Fields
	private byte[] state; // 0x28
	private byte[] checksum; // 0x30
	private byte[] buffer; // 0x38
	private int count; // 0x40
	private byte[] x; // 0x48
	private static readonly byte[] PI_SUBST; // 0x0

	// Methods

	// RVA: 0x1709BE0 Offset: 0x1705BE0 VA: 0x1709BE0
	private byte[] Padding(int nLength) { }

	// RVA: 0x1709B0C Offset: 0x1705B0C VA: 0x1709B0C
	public void .ctor() { }

	// RVA: 0x1709C78 Offset: 0x1705C78 VA: 0x1709C78 Slot: 18
	public override void Initialize() { }

	// RVA: 0x1709CD8 Offset: 0x1705CD8 VA: 0x1709CD8 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x170A018 Offset: 0x1706018 VA: 0x170A018 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1709DB4 Offset: 0x1705DB4 VA: 0x1709DB4
	private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) { }

	// RVA: 0x170A108 Offset: 0x1706108 VA: 0x170A108
	private static void .cctor() { }
}

// Namespace: Mono.Security.Cryptography
public abstract class MD4 : HashAlgorithm // TypeDefIndex: 7570
{
	// Methods

	// RVA: 0x170A1A8 Offset: 0x17061A8 VA: 0x170A1A8
	protected void .ctor() { }

	// RVA: 0x170A1C8 Offset: 0x17061C8 VA: 0x170A1C8
	public static MD4 Create() { }
}

// Namespace: Mono.Security.Cryptography
public class MD4Managed : MD4 // TypeDefIndex: 7571
{
	// Fields
	private uint[] state; // 0x28
	private byte[] buffer; // 0x30
	private uint[] count; // 0x38
	private uint[] x; // 0x40
	private byte[] digest; // 0x48

	// Methods

	// RVA: 0x170A218 Offset: 0x1706218 VA: 0x170A218
	public void .ctor() { }

	// RVA: 0x170A324 Offset: 0x1706324 VA: 0x170A324 Slot: 18
	public override void Initialize() { }

	// RVA: 0x170A3D8 Offset: 0x17063D8 VA: 0x170A3D8 Slot: 16
	protected override void HashCore(byte[] array, int ibStart, int cbSize) { }

	// RVA: 0x170AB6C Offset: 0x1706B6C VA: 0x170AB6C Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x170AD60 Offset: 0x1706D60 VA: 0x170AD60
	private byte[] Padding(int nLength) { }

	// RVA: 0x170ADD8 Offset: 0x1706DD8 VA: 0x170ADD8
	private uint F(uint x, uint y, uint z) { }

	// RVA: 0x170ADE8 Offset: 0x1706DE8 VA: 0x170ADE8
	private uint G(uint x, uint y, uint z) { }

	// RVA: 0x170ADFC Offset: 0x1706DFC VA: 0x170ADFC
	private uint H(uint x, uint y, uint z) { }

	// RVA: 0x170AE08 Offset: 0x1706E08 VA: 0x170AE08
	private uint ROL(uint x, byte n) { }

	// RVA: 0x170AE14 Offset: 0x1706E14 VA: 0x170AE14
	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x170AE3C Offset: 0x1706E3C VA: 0x170AE3C
	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x170AE74 Offset: 0x1706E74 VA: 0x170AE74
	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	// RVA: 0x170AC68 Offset: 0x1706C68 VA: 0x170AC68
	private void Encode(byte[] output, uint[] input) { }

	// RVA: 0x170AEA4 Offset: 0x1706EA4 VA: 0x170AEA4
	private void Decode(uint[] output, byte[] input, int index) { }

	// RVA: 0x170A4FC Offset: 0x17064FC VA: 0x170A4FC
	private void MD4Transform(uint[] state, byte[] block, int index) { }
}

// Namespace: Mono.Security.Cryptography
public sealed class PKCS1 // TypeDefIndex: 7572
{
	// Fields
	private static byte[] emptySHA1; // 0x0
	private static byte[] emptySHA256; // 0x8
	private static byte[] emptySHA384; // 0x10
	private static byte[] emptySHA512; // 0x18

	// Methods

	// RVA: 0x170AF70 Offset: 0x1706F70 VA: 0x170AF70
	private static bool Compare(byte[] array1, byte[] array2) { }

	// RVA: 0x170AFD8 Offset: 0x1706FD8 VA: 0x170AFD8
	public static byte[] I2OSP(byte[] x, int size) { }

	// RVA: 0x170B064 Offset: 0x1707064 VA: 0x170B064
	public static byte[] OS2IP(byte[] x) { }

	// RVA: 0x170B128 Offset: 0x1707128 VA: 0x170B128
	public static byte[] RSAVP1(RSA rsa, byte[] s) { }

	// RVA: 0x170B140 Offset: 0x1707140 VA: 0x170B140
	public static bool Verify_v15(RSA rsa, HashAlgorithm hash, byte[] hashValue, byte[] signature, bool tryNonStandardEncoding) { }

	// RVA: 0x170B318 Offset: 0x1707318 VA: 0x170B318
	public static byte[] Encode_v15(HashAlgorithm hash, byte[] hashValue, int emLength) { }

	// RVA: 0x170B660 Offset: 0x1707660 VA: 0x170B660
	internal static string HashNameFromOid(string oid, bool throwOnError = True) { }

	// RVA: 0x170BA68 Offset: 0x1707A68 VA: 0x170BA68
	internal static HashAlgorithm CreateFromOid(string oid) { }

	// RVA: 0x170BAC4 Offset: 0x1707AC4 VA: 0x170BAC4
	internal static HashAlgorithm CreateFromName(string name) { }

	// RVA: 0x170BEB4 Offset: 0x1707EB4 VA: 0x170BEB4
	private static void .cctor() { }
}

// Namespace: 
public class PKCS8.PrivateKeyInfo // TypeDefIndex: 7573
{
	// Fields
	private int _version; // 0x10
	private string _algorithm; // 0x18
	private byte[] _key; // 0x20
	private ArrayList _list; // 0x28

	// Properties
	public string Algorithm { get; }
	public byte[] PrivateKey { get; }

	// Methods

	// RVA: 0x170C028 Offset: 0x1708028 VA: 0x170C028
	public void .ctor() { }

	// RVA: 0x170C098 Offset: 0x1708098 VA: 0x170C098
	public void .ctor(byte[] data) { }

	// RVA: 0x170C328 Offset: 0x1708328 VA: 0x170C328
	public string get_Algorithm() { }

	// RVA: 0x170C330 Offset: 0x1708330 VA: 0x170C330
	public byte[] get_PrivateKey() { }

	// RVA: 0x170C0C0 Offset: 0x17080C0 VA: 0x170C0C0
	private void Decode(byte[] data) { }

	// RVA: 0x170C3A4 Offset: 0x17083A4 VA: 0x170C3A4
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x170C440 Offset: 0x1708440 VA: 0x170C440
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x170C4E0 Offset: 0x17084E0 VA: 0x170C4E0
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x170C93C Offset: 0x170893C VA: 0x170C93C
	public static byte[] Encode(RSA rsa) { }

	// RVA: 0x170CB34 Offset: 0x1708B34 VA: 0x170CB34
	public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

	// RVA: 0x170CC58 Offset: 0x1708C58 VA: 0x170CC58
	public static byte[] Encode(DSA dsa) { }

	// RVA: 0x170CCA4 Offset: 0x1708CA4 VA: 0x170CCA4
	public static byte[] Encode(AsymmetricAlgorithm aa) { }
}

// Namespace: 
public class PKCS8.EncryptedPrivateKeyInfo // TypeDefIndex: 7574
{
	// Fields
	private string _algorithm; // 0x10
	private byte[] _salt; // 0x18
	private int _iterations; // 0x20
	private byte[] _data; // 0x28

	// Properties
	public string Algorithm { get; }
	public byte[] EncryptedData { get; }
	public byte[] Salt { get; }
	public int IterationCount { get; }

	// Methods

	// RVA: 0x170CDC8 Offset: 0x1708DC8 VA: 0x170CDC8
	public void .ctor() { }

	// RVA: 0x170CDD0 Offset: 0x1708DD0 VA: 0x170CDD0
	public void .ctor(byte[] data) { }

	// RVA: 0x170D0A8 Offset: 0x17090A8 VA: 0x170D0A8
	public string get_Algorithm() { }

	// RVA: 0x170D0B0 Offset: 0x17090B0 VA: 0x170D0B0
	public byte[] get_EncryptedData() { }

	// RVA: 0x170D124 Offset: 0x1709124 VA: 0x170D124
	public byte[] get_Salt() { }

	// RVA: 0x170D1E4 Offset: 0x17091E4 VA: 0x170D1E4
	public int get_IterationCount() { }

	// RVA: 0x170CDFC Offset: 0x1708DFC VA: 0x170CDFC
	private void Decode(byte[] data) { }
}

// Namespace: Mono.Security.Cryptography
public sealed class PKCS8 // TypeDefIndex: 7575
{}

// Namespace: 
public sealed class RSAManaged.KeyGeneratedEventHandler : MulticastDelegate // TypeDefIndex: 7576
{
	// Methods

	// RVA: 0x170F624 Offset: 0x170B624 VA: 0x170F624
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x170F730 Offset: 0x170B730 VA: 0x170F730 Slot: 12
	public virtual void Invoke(object sender, EventArgs e) { }
}

// Namespace: Mono.Security.Cryptography
public class RSAManaged : RSA // TypeDefIndex: 7577
{
	// Fields
	private bool isCRTpossible; // 0x20
	private bool keyBlinding; // 0x21
	private bool keypairGenerated; // 0x22
	private bool m_disposed; // 0x23
	private BigInteger d; // 0x28
	private BigInteger p; // 0x30
	private BigInteger q; // 0x38
	private BigInteger dp; // 0x40
	private BigInteger dq; // 0x48
	private BigInteger qInv; // 0x50
	private BigInteger n; // 0x58
	private BigInteger e; // 0x60
	[CompilerGenerated]
	private RSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x68

	// Properties
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x170D1EC Offset: 0x17091EC VA: 0x170D1EC
	public void .ctor() { }

	// RVA: 0x170D1F4 Offset: 0x17091F4 VA: 0x170D1F4
	public void .ctor(int keySize) { }

	// RVA: 0x170D2DC Offset: 0x17092DC VA: 0x170D2DC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x170D36C Offset: 0x170936C VA: 0x170D36C
	private void GenerateKeyPair() { }

	// RVA: 0x170DC48 Offset: 0x1709C48 VA: 0x170DC48 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x170DCE4 Offset: 0x1709CE4 VA: 0x170DCE4
	public bool get_PublicOnly() { }

	// RVA: 0x170DE34 Offset: 0x1709E34 VA: 0x170DE34 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x170E2EC Offset: 0x170A2EC VA: 0x170E2EC Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x170E7B0 Offset: 0x170A7B0 VA: 0x170E7B0 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x170ECFC Offset: 0x170ACFC VA: 0x170ECFC Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x170EF80 Offset: 0x170AF80 VA: 0x170EF80 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: 0x170E1E8 Offset: 0x170A1E8 VA: 0x170E1E8
	private byte[] GetPaddedValue(BigInteger value, int length) { }
}
