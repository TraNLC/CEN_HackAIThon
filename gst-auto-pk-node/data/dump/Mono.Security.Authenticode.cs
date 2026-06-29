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

// Namespace: Mono.Security.Authenticode
public class AuthenticodeBase // TypeDefIndex: 7578
{
	// Fields
	private byte[] fileblock; // 0x10
	private Stream fs; // 0x18
	private int blockNo; // 0x20
	private int blockLength; // 0x24
	private int peOffset; // 0x28
	private int dirSecurityOffset; // 0x2C
	private int dirSecuritySize; // 0x30
	private int coffSymbolTableOffset; // 0x34
	private bool pe64; // 0x38

	// Properties
	internal int PEOffset { get; }

	// Methods

	// RVA: 0x170F744 Offset: 0x170B744 VA: 0x170F744
	public void .ctor() { }

	// RVA: 0x170F7A8 Offset: 0x170B7A8 VA: 0x170F7A8
	internal int get_PEOffset() { }

	// RVA: 0x170F8A0 Offset: 0x170B8A0 VA: 0x170F8A0
	internal void Open(string filename) { }

	// RVA: 0x170F974 Offset: 0x170B974 VA: 0x170F974
	internal void Open(byte[] rawdata) { }

	// RVA: 0x170F938 Offset: 0x170B938 VA: 0x170F938
	internal void Close() { }

	// RVA: 0x170F7D0 Offset: 0x170B7D0 VA: 0x170F7D0
	internal void ReadFirstBlock() { }

	// RVA: 0x170FA04 Offset: 0x170BA04 VA: 0x170FA04
	internal int ProcessFirstBlock() { }

	// RVA: 0x170FC40 Offset: 0x170BC40 VA: 0x170FC40
	internal byte[] GetSecurityEntry() { }

	// RVA: 0x170FD10 Offset: 0x170BD10 VA: 0x170FD10
	internal byte[] GetHash(HashAlgorithm hash) { }
}

// Namespace: Mono.Security.Authenticode
public class AuthenticodeDeformatter : AuthenticodeBase // TypeDefIndex: 7579
{
	// Fields
	private string filename; // 0x40
	private byte[] rawdata; // 0x48
	private byte[] hash; // 0x50
	private X509CertificateCollection coll; // 0x58
	private ASN1 signedHash; // 0x60
	private DateTime timestamp; // 0x68
	private X509Certificate signingCertificate; // 0x70
	private int reason; // 0x78
	private bool trustedRoot; // 0x7C
	private bool trustedTimestampRoot; // 0x7D
	private byte[] entry; // 0x80
	private X509Chain signerChain; // 0x88
	private X509Chain timestampChain; // 0x90

	// Properties
	public byte[] RawData { set; }
	public X509Certificate SigningCertificate { get; }

	// Methods

	// RVA: 0x17101A8 Offset: 0x170C1A8 VA: 0x17101A8
	public void .ctor() { }

	// RVA: 0x171023C Offset: 0x170C23C VA: 0x171023C
	public void .ctor(byte[] rawData) { }

	// RVA: 0x1710264 Offset: 0x170C264 VA: 0x1710264
	public void set_RawData(byte[] value) { }

	// RVA: 0x171071C Offset: 0x170C71C VA: 0x171071C
	public X509Certificate get_SigningCertificate() { }

	// RVA: 0x1710434 Offset: 0x170C434 VA: 0x1710434
	private bool CheckSignature() { }

	// RVA: 0x17110E0 Offset: 0x170D0E0 VA: 0x17110E0
	private bool CompareIssuerSerial(string issuer, byte[] serial, X509Certificate x509) { }

	// RVA: 0x1710724 Offset: 0x170C724 VA: 0x1710724
	private bool VerifySignature(PKCS7.SignedData sd, byte[] calculatedMessageDigest, HashAlgorithm ha) { }

	// RVA: 0x17111E4 Offset: 0x170D1E4 VA: 0x17111E4
	private bool VerifyCounterSignature(PKCS7.SignerInfo cs, byte[] signature) { }

	// RVA: 0x1710340 Offset: 0x170C340 VA: 0x1710340
	private void Reset() { }
}

// Namespace: 
public enum BigInteger.Sign // TypeDefIndex: 7580
{
	// Fields
	public int value__; // 0x0
	public const BigInteger.Sign Negative = -1;
	public const BigInteger.Sign Zero = 0;
	public const BigInteger.Sign Positive = 1;
}

// Namespace: 
public sealed class BigInteger.ModulusRing // TypeDefIndex: 7581
{
	// Fields
	private BigInteger mod; // 0x10
	private BigInteger constant; // 0x18

	// Methods

	// RVA: 0x1713A54 Offset: 0x170FA54 VA: 0x1713A54
	public void .ctor(BigInteger modulus) { }

	// RVA: 0x1713D9C Offset: 0x170FD9C VA: 0x1713D9C
	public void BarrettReduction(BigInteger x) { }

	// RVA: 0x1714394 Offset: 0x1710394 VA: 0x1714394
	public BigInteger Multiply(BigInteger a, BigInteger b) { }

	// RVA: 0x1714510 Offset: 0x1710510 VA: 0x1714510
	public BigInteger Difference(BigInteger a, BigInteger b) { }

	// RVA: 0x1713B54 Offset: 0x170FB54 VA: 0x1713B54
	public BigInteger Pow(BigInteger a, BigInteger k) { }

	[CLSCompliant(False)]
	// RVA: 0x17146C4 Offset: 0x17106C4 VA: 0x17146C4
	public BigInteger Pow(uint b, BigInteger exp) { }
}

// Namespace: 
private sealed class BigInteger.Kernel // TypeDefIndex: 7582
{
	// Methods

	// RVA: 0x1712030 Offset: 0x170E030 VA: 0x1712030
	public static BigInteger Subtract(BigInteger big, BigInteger small) { }

	// RVA: 0x1714104 Offset: 0x1710104 VA: 0x1714104
	public static void MinusEq(BigInteger big, BigInteger small) { }

	// RVA: 0x1714208 Offset: 0x1710208 VA: 0x1714208
	public static void PlusEq(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1711EEC Offset: 0x170DEEC VA: 0x1711EEC
	public static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1713280 Offset: 0x170F280 VA: 0x1713280
	public static uint SingleByteDivideInPlace(BigInteger n, uint d) { }

	// RVA: 0x17121DC Offset: 0x170E1DC VA: 0x17121DC
	public static uint DwordMod(BigInteger n, uint d) { }

	// RVA: 0x1714734 Offset: 0x1710734 VA: 0x1714734
	public static BigInteger[] DwordDivMod(BigInteger n, uint d) { }

	// RVA: 0x1712240 Offset: 0x170E240 VA: 0x1712240
	public static BigInteger[] multiByteDivide(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x171281C Offset: 0x170E81C VA: 0x171281C
	public static BigInteger LeftShift(BigInteger bi, int n) { }

	// RVA: 0x17129F0 Offset: 0x170E9F0 VA: 0x17129F0
	public static BigInteger RightShift(BigInteger bi, int n) { }

	// RVA: 0x1712734 Offset: 0x170E734 VA: 0x1712734
	public static void Multiply(uint[] x, uint xOffset, uint xLen, uint[] y, uint yOffset, uint yLen, uint[] d, uint dOffset) { }

	// RVA: 0x1713FF4 Offset: 0x170FFF4 VA: 0x1713FF4
	public static void MultiplyMod2p32pmod(uint[] x, int xOffset, int xLen, uint[] y, int yOffest, int yLen, uint[] d, int dOffset, int mod) { }

	// RVA: 0x17148D4 Offset: 0x17108D4 VA: 0x17148D4
	public static uint modInverse(BigInteger bi, uint modulus) { }

	// RVA: 0x1713478 Offset: 0x170F478 VA: 0x1713478
	public static BigInteger modInverse(BigInteger bi, BigInteger modulus) { }
}
