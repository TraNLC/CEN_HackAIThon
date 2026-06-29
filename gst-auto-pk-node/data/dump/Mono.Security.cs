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

// Namespace: Mono.Security
[DefaultMember("Item")]
internal class ASN1 // TypeDefIndex: 64
{
	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte[] Value { get; }

	// Methods

	// RVA: 0x172249C Offset: 0x171E49C VA: 0x172249C
	public void .ctor(byte tag) { }

	// RVA: 0x17224D0 Offset: 0x171E4D0 VA: 0x17224D0
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x1722508 Offset: 0x171E508 VA: 0x1722508
	public void .ctor(byte[] data) { }

	// RVA: 0x17227A8 Offset: 0x171E7A8 VA: 0x17227A8
	public int get_Count() { }

	// RVA: 0x17227C4 Offset: 0x171E7C4 VA: 0x17227C4
	public byte[] get_Value() { }

	// RVA: 0x1722854 Offset: 0x171E854 VA: 0x1722854
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x17228EC Offset: 0x171E8EC VA: 0x17228EC Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1722684 Offset: 0x171E684 VA: 0x1722684
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1722F60 Offset: 0x171EF60 VA: 0x1722F60
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1723088 Offset: 0x171F088 VA: 0x1723088 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security
internal sealed class BitConverterLE // TypeDefIndex: 65
{
	// Methods

	// RVA: 0x172331C Offset: 0x171F31C VA: 0x172331C
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x17233B4 Offset: 0x171F3B4 VA: 0x17233B4
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x172348C Offset: 0x171F48C VA: 0x172348C
	internal static byte[] GetBytes(float value) { }

	// RVA: 0x17234A4 Offset: 0x171F4A4 VA: 0x17234A4
	internal static byte[] GetBytes(double value) { }

	// RVA: 0x17234BC Offset: 0x171F4BC VA: 0x17234BC
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1723540 Offset: 0x171F540 VA: 0x1723540
	private static void ULongFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x1723594 Offset: 0x171F594 VA: 0x1723594
	internal static float ToSingle(byte[] value, int startIndex) { }

	// RVA: 0x17235B8 Offset: 0x171F5B8 VA: 0x17235B8
	internal static double ToDouble(byte[] value, int startIndex) { }
}

// Namespace: Mono.Security
internal enum UriPartial // TypeDefIndex: 66
{
	// Fields
	public int value__; // 0x0
	public const UriPartial Scheme = 0;
	public const UriPartial Authority = 1;
	public const UriPartial Path = 2;
}

// Namespace: 
private struct Uri.UriScheme // TypeDefIndex: 67
{
	// Fields
	public string scheme; // 0x0
	public string delimiter; // 0x8
	public int defaultPort; // 0x10

	// Methods

	// RVA: 0x1726C30 Offset: 0x1722C30 VA: 0x1726C30
	public void .ctor(string s, string d, int p) { }
}

// Namespace: Mono.Security
internal class Uri // TypeDefIndex: 68
{
	// Fields
	private bool isUnixFilePath; // 0x10
	private string source; // 0x18
	private string scheme; // 0x20
	private string host; // 0x28
	private int port; // 0x30
	private string path; // 0x38
	private string query; // 0x40
	private string fragment; // 0x48
	private string userinfo; // 0x50
	private bool isUnc; // 0x58
	private bool isOpaquePart; // 0x59
	private bool userEscaped; // 0x5A
	private string cachedToString; // 0x60
	private string cachedLocalPath; // 0x68
	private int cachedHashCode; // 0x70
	private bool reduce; // 0x74
	private static readonly string hexUpperChars; // 0x0
	public static readonly string SchemeDelimiter; // 0x8
	public static readonly string UriSchemeFile; // 0x10
	public static readonly string UriSchemeFtp; // 0x18
	public static readonly string UriSchemeGopher; // 0x20
	public static readonly string UriSchemeHttp; // 0x28
	public static readonly string UriSchemeHttps; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	private static Uri.UriScheme[] schemes; // 0x50

	// Properties
	public string AbsolutePath { get; }
	public bool IsFile { get; }
	public bool IsUnc { get; }
	public string LocalPath { get; }

	// Methods

	// RVA: 0x17235D8 Offset: 0x171F5D8 VA: 0x17235D8
	public void .ctor(string uriString) { }

	// RVA: 0x17235E0 Offset: 0x171F5E0 VA: 0x17235E0
	public void .ctor(string uriString, bool dontEscape) { }

	// RVA: 0x1723780 Offset: 0x171F780 VA: 0x1723780
	public string get_AbsolutePath() { }

	// RVA: 0x1723788 Offset: 0x171F788 VA: 0x1723788
	public bool get_IsFile() { }

	// RVA: 0x17237F0 Offset: 0x171F7F0 VA: 0x17237F0
	public bool get_IsUnc() { }

	// RVA: 0x17237F8 Offset: 0x171F7F8 VA: 0x17237F8
	public string get_LocalPath() { }

	// RVA: 0x1723ADC Offset: 0x171FADC VA: 0x1723ADC Slot: 0
	public override bool Equals(object comparant) { }

	// RVA: 0x1723CFC Offset: 0x171FCFC VA: 0x1723CFC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1723DD0 Offset: 0x171FDD0 VA: 0x1723DD0
	public string GetLeftPart(UriPartial part) { }

	// RVA: 0x1724350 Offset: 0x1720350 VA: 0x1724350
	public static int FromHex(char digit) { }

	// RVA: 0x17243E0 Offset: 0x17203E0 VA: 0x17243E0
	public static string HexEscape(char character) { }

	// RVA: 0x172453C Offset: 0x172053C VA: 0x172453C
	public static char HexUnescape(string pattern, ref int index) { }

	// RVA: 0x1724854 Offset: 0x1720854 VA: 0x1724854
	public static bool IsHexDigit(char digit) { }

	// RVA: 0x1724884 Offset: 0x1720884 VA: 0x1724884
	public static bool IsHexEncoding(string pattern, int index) { }

	// RVA: 0x17249C4 Offset: 0x17209C4 VA: 0x17249C4 Slot: 3
	public override string ToString() { }

	// RVA: 0x1724C50 Offset: 0x1720C50 VA: 0x1724C50
	protected static string EscapeString(string str) { }

	// RVA: 0x1724CB0 Offset: 0x1720CB0 VA: 0x1724CB0
	internal static string EscapeString(string str, bool escapeReserved, bool escapeHex, bool escapeBrackets) { }

	// RVA: 0x17236D0 Offset: 0x171F6D0 VA: 0x17236D0
	protected void Parse() { }

	// RVA: 0x1723AD4 Offset: 0x171FAD4 VA: 0x1723AD4
	protected string Unescape(string str) { }

	// RVA: 0x1724AB0 Offset: 0x1720AB0 VA: 0x1724AB0
	internal string Unescape(string str, bool excludeSharp) { }

	// RVA: 0x1725C04 Offset: 0x1721C04 VA: 0x1725C04
	private void ParseAsWindowsUNC(string uriString) { }

	// RVA: 0x1725DEC Offset: 0x1721DEC VA: 0x1725DEC
	private void ParseAsWindowsAbsoluteFilePath(string uriString) { }

	// RVA: 0x1725F94 Offset: 0x1721F94 VA: 0x1725F94
	private void ParseAsUnixAbsoluteFilePath(string uriString) { }

	// RVA: 0x1724FA4 Offset: 0x1720FA4 VA: 0x1724FA4
	private void Parse(string uriString) { }

	// RVA: 0x1726314 Offset: 0x1722314 VA: 0x1726314
	private static string Reduce(string path) { }

	// RVA: 0x1726648 Offset: 0x1722648 VA: 0x1726648
	internal static string GetSchemeDelimiter(string scheme) { }

	// RVA: 0x1724244 Offset: 0x1720244 VA: 0x1724244
	internal static int GetDefaultPort(string scheme) { }

	// RVA: 0x17241C0 Offset: 0x17201C0 VA: 0x17241C0
	private string GetOpaqueWiseSchemeDelimiter() { }

	// RVA: 0x1726150 Offset: 0x1722150 VA: 0x1726150
	private static bool IsPredefinedScheme(string scheme) { }

	// RVA: 0x1726764 Offset: 0x1722764 VA: 0x1726764
	private static void .cctor() { }
}

// Namespace: Mono.Security
[DefaultMember("Item")]
public class ASN1 // TypeDefIndex: 7517
{
	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x16F3428 Offset: 0x16EF428 VA: 0x16F3428
	public void .ctor(byte tag) { }

	// RVA: 0x16F345C Offset: 0x16EF45C VA: 0x16F345C
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x16F3494 Offset: 0x16EF494 VA: 0x16F3494
	public void .ctor(byte[] data) { }

	// RVA: 0x16F3734 Offset: 0x16EF734 VA: 0x16F3734
	public int get_Count() { }

	// RVA: 0x16F3750 Offset: 0x16EF750 VA: 0x16F3750
	public byte get_Tag() { }

	// RVA: 0x16F3758 Offset: 0x16EF758 VA: 0x16F3758
	public int get_Length() { }

	// RVA: 0x16F3770 Offset: 0x16EF770 VA: 0x16F3770
	public byte[] get_Value() { }

	// RVA: 0x16F3800 Offset: 0x16EF800 VA: 0x16F3800
	public void set_Value(byte[] value) { }

	// RVA: 0x16F38BC Offset: 0x16EF8BC VA: 0x16F38BC
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x16F3924 Offset: 0x16EF924 VA: 0x16F3924
	public bool CompareValue(byte[] value) { }

	// RVA: 0x16F3934 Offset: 0x16EF934 VA: 0x16F3934
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x16F39CC Offset: 0x16EF9CC VA: 0x16F39CC Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x16F3610 Offset: 0x16EF610 VA: 0x16F3610
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x16F4040 Offset: 0x16F0040 VA: 0x16F4040
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x16F4168 Offset: 0x16F0168 VA: 0x16F4168
	public ASN1 get_Item(int index) { }

	// RVA: 0x16F4298 Offset: 0x16F0298 VA: 0x16F4298
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x16F43EC Offset: 0x16F03EC VA: 0x16F43EC Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security
public static class ASN1Convert // TypeDefIndex: 7518
{
	// Methods

	// RVA: 0x16F4680 Offset: 0x16F0680 VA: 0x16F4680
	public static ASN1 FromInt32(int value) { }

	// RVA: 0x16F4810 Offset: 0x16F0810 VA: 0x16F4810
	public static ASN1 FromOid(string oid) { }

	// RVA: 0x16F48EC Offset: 0x16F08EC VA: 0x16F48EC
	public static ASN1 FromUnsignedBigInteger(byte[] big) { }

	// RVA: 0x16F4A08 Offset: 0x16F0A08 VA: 0x16F4A08
	public static int ToInt32(ASN1 asn1) { }

	// RVA: 0x16F4B0C Offset: 0x16F0B0C VA: 0x16F4B0C
	public static string ToOid(ASN1 asn1) { }

	// RVA: 0x16F4D80 Offset: 0x16F0D80 VA: 0x16F4D80
	public static DateTime ToDateTime(ASN1 time) { }
}

// Namespace: Mono.Security
internal sealed class BitConverterLE // TypeDefIndex: 7519
{
	// Methods

	// RVA: 0x16F533C Offset: 0x16F133C VA: 0x16F533C
	private static byte[] GetUIntBytes(byte* bytes) { }

	// RVA: 0x16F53D4 Offset: 0x16F13D4 VA: 0x16F53D4
	private static byte[] GetULongBytes(byte* bytes) { }

	// RVA: 0x16F47F8 Offset: 0x16F07F8 VA: 0x16F47F8
	internal static byte[] GetBytes(int value) { }

	// RVA: 0x16F54AC Offset: 0x16F14AC VA: 0x16F54AC
	internal static byte[] GetBytes(long value) { }

	// RVA: 0x16F54C0 Offset: 0x16F14C0 VA: 0x16F54C0
	private static void UShortFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x16F550C Offset: 0x16F150C VA: 0x16F550C
	private static void UIntFromBytes(byte* dst, byte[] src, int startIndex) { }

	// RVA: 0x16F5590 Offset: 0x16F1590 VA: 0x16F5590
	internal static int ToInt32(byte[] value, int startIndex) { }

	// RVA: 0x16F55B4 Offset: 0x16F15B4 VA: 0x16F55B4
	internal static ushort ToUInt16(byte[] value, int startIndex) { }

	// RVA: 0x16F55D8 Offset: 0x16F15D8 VA: 0x16F55D8
	internal static uint ToUInt32(byte[] value, int startIndex) { }
}

// Namespace: 
public class PKCS7.ContentInfo // TypeDefIndex: 7520
{
	// Fields
	private string contentType; // 0x10
	private ASN1 content; // 0x18

	// Properties
	public ASN1 ASN1 { get; }
	public ASN1 Content { get; set; }
	public string ContentType { get; set; }

	// Methods

	// RVA: 0x16F55FC Offset: 0x16F15FC VA: 0x16F55FC
	public void .ctor() { }

	// RVA: 0x16F5680 Offset: 0x16F1680 VA: 0x16F5680
	public void .ctor(string oid) { }

	// RVA: 0x16F56AC Offset: 0x16F16AC VA: 0x16F56AC
	public void .ctor(byte[] data) { }

	// RVA: 0x16F5714 Offset: 0x16F1714 VA: 0x16F5714
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x16F58B0 Offset: 0x16F18B0 VA: 0x16F58B0
	public ASN1 get_ASN1() { }

	// RVA: 0x16F596C Offset: 0x16F196C VA: 0x16F596C
	public ASN1 get_Content() { }

	// RVA: 0x16F5974 Offset: 0x16F1974 VA: 0x16F5974
	public void set_Content(ASN1 value) { }

	// RVA: 0x16F597C Offset: 0x16F197C VA: 0x16F597C
	public string get_ContentType() { }

	// RVA: 0x16F5984 Offset: 0x16F1984 VA: 0x16F5984
	public void set_ContentType(string value) { }

	// RVA: 0x16F58B4 Offset: 0x16F18B4 VA: 0x16F58B4
	internal ASN1 GetASN1() { }
}

// Namespace: 
public class PKCS7.EncryptedData // TypeDefIndex: 7521
{
	// Fields
	private byte _version; // 0x10
	private PKCS7.ContentInfo _content; // 0x18
	private PKCS7.ContentInfo _encryptionAlgorithm; // 0x20
	private byte[] _encrypted; // 0x28

	// Properties
	public PKCS7.ContentInfo EncryptionAlgorithm { get; }
	public byte[] EncryptedContent { get; }

	// Methods

	// RVA: 0x16F598C Offset: 0x16F198C VA: 0x16F598C
	public void .ctor() { }

	// RVA: 0x16F59A8 Offset: 0x16F19A8 VA: 0x16F59A8
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x16F5C9C Offset: 0x16F1C9C VA: 0x16F5C9C
	public PKCS7.ContentInfo get_EncryptionAlgorithm() { }

	// RVA: 0x16F5CA4 Offset: 0x16F1CA4 VA: 0x16F5CA4
	public byte[] get_EncryptedContent() { }
}

// Namespace: 
public class PKCS7.SignedData // TypeDefIndex: 7522
{
	// Fields
	private byte version; // 0x10
	private string hashAlgorithm; // 0x18
	private PKCS7.ContentInfo contentInfo; // 0x20
	private X509CertificateCollection certs; // 0x28
	private ArrayList crls; // 0x30
	private PKCS7.SignerInfo signerInfo; // 0x38
	private bool mda; // 0x40

	// Properties
	public X509CertificateCollection Certificates { get; }
	public PKCS7.ContentInfo ContentInfo { get; }
	public string HashName { set; }
	public PKCS7.SignerInfo SignerInfo { get; }

	// Methods

	// RVA: 0x16F5D18 Offset: 0x16F1D18 VA: 0x16F5D18
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x16F6A64 Offset: 0x16F2A64 VA: 0x16F6A64
	public X509CertificateCollection get_Certificates() { }

	// RVA: 0x16F6A6C Offset: 0x16F2A6C VA: 0x16F6A6C
	public PKCS7.ContentInfo get_ContentInfo() { }

	// RVA: 0x16F6A28 Offset: 0x16F2A28 VA: 0x16F6A28
	public void set_HashName(string value) { }

	// RVA: 0x16F6A74 Offset: 0x16F2A74 VA: 0x16F6A74
	public PKCS7.SignerInfo get_SignerInfo() { }

	// RVA: 0x16F6874 Offset: 0x16F2874 VA: 0x16F6874
	internal string OidToName(string oid) { }
}

// Namespace: 
public class PKCS7.SignerInfo // TypeDefIndex: 7523
{
	// Fields
	private byte version; // 0x10
	private string hashAlgorithm; // 0x18
	private ArrayList authenticatedAttributes; // 0x20
	private ArrayList unauthenticatedAttributes; // 0x28
	private byte[] signature; // 0x30
	private string issuer; // 0x38
	private byte[] serial; // 0x40
	private byte[] ski; // 0x48

	// Properties
	public string IssuerName { get; }
	public byte[] SerialNumber { get; }
	public ArrayList AuthenticatedAttributes { get; }
	public string HashName { get; set; }
	public byte[] Signature { get; }
	public ArrayList UnauthenticatedAttributes { get; }
	public byte Version { get; }

	// Methods

	// RVA: 0x16F67DC Offset: 0x16F27DC VA: 0x16F67DC
	public void .ctor() { }

	// RVA: 0x16F6434 Offset: 0x16F2434 VA: 0x16F6434
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x16F6BB8 Offset: 0x16F2BB8 VA: 0x16F6BB8
	public string get_IssuerName() { }

	// RVA: 0x16F6BC0 Offset: 0x16F2BC0 VA: 0x16F6BC0
	public byte[] get_SerialNumber() { }

	// RVA: 0x16F6C34 Offset: 0x16F2C34 VA: 0x16F6C34
	public ArrayList get_AuthenticatedAttributes() { }

	// RVA: 0x16F6C3C Offset: 0x16F2C3C VA: 0x16F6C3C
	public string get_HashName() { }

	// RVA: 0x16F6C44 Offset: 0x16F2C44 VA: 0x16F6C44
	public void set_HashName(string value) { }

	// RVA: 0x16F6C4C Offset: 0x16F2C4C VA: 0x16F6C4C
	public byte[] get_Signature() { }

	// RVA: 0x16F6CC0 Offset: 0x16F2CC0 VA: 0x16F6CC0
	public ArrayList get_UnauthenticatedAttributes() { }

	// RVA: 0x16F6CC8 Offset: 0x16F2CC8 VA: 0x16F6CC8
	public byte get_Version() { }
}

// Namespace: Mono.Security
public sealed class PKCS7 // TypeDefIndex: 7524
{}
