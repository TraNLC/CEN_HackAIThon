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

// Namespace: Mono.Security.Protocol.Ntlm
[Obsolete("Use of this API is highly discouraged, it selects legacy-mode LM/NTLM authentication, which sends your password in very weak encryption over the wire even if the server supports the more secure NTLMv2 / NTLMv2 Session. You need to use the new `Type3Message (Type2Message)' constructor to use the more secure NTLMv2 / NTLMv2 Session authentication modes. These require the Type 2 message from the server to compute the response.")]
public class ChallengeResponse : IDisposable // TypeDefIndex: 7543
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8
	private bool _disposed; // 0x10
	private byte[] _challenge; // 0x18
	private byte[] _lmpwd; // 0x20
	private byte[] _ntpwd; // 0x28

	// Properties
	public string Password { set; }
	public byte[] Challenge { set; }
	public byte[] LM { get; }
	public byte[] NT { get; }

	// Methods

	// RVA: 0x17050CC Offset: 0x17010CC VA: 0x17050CC
	public void .ctor() { }

	// RVA: 0x1705150 Offset: 0x1701150 VA: 0x1705150
	public void .ctor(string password, byte[] challenge) { }

	// RVA: 0x17056C0 Offset: 0x17016C0 VA: 0x17056C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1705188 Offset: 0x1701188 VA: 0x1705188
	public void set_Password(string value) { }

	// RVA: 0x1705590 Offset: 0x1701590 VA: 0x1705590
	public void set_Challenge(byte[] value) { }

	// RVA: 0x17058F4 Offset: 0x17018F4 VA: 0x17058F4
	public byte[] get_LM() { }

	// RVA: 0x1705C2C Offset: 0x1701C2C VA: 0x1705C2C
	public byte[] get_NT() { }

	// RVA: 0x170574C Offset: 0x170174C VA: 0x170574C Slot: 4
	public void Dispose() { }

	// RVA: 0x1705C88 Offset: 0x1701C88 VA: 0x1705C88
	private void Dispose(bool disposing) { }

	// RVA: 0x1705950 Offset: 0x1701950 VA: 0x1705950
	private byte[] GetResponse(byte[] pwd) { }

	// RVA: 0x1705CF4 Offset: 0x1701CF4 VA: 0x1705CF4
	private byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x17057B0 Offset: 0x17017B0 VA: 0x17057B0
	private byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x1705EEC Offset: 0x1701EEC VA: 0x1705EEC
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public static class ChallengeResponse2 // TypeDefIndex: 7544
{
	// Fields
	private static byte[] magic; // 0x0
	private static byte[] nullEncMagic; // 0x8

	// Methods

	// RVA: 0x1705FD0 Offset: 0x1701FD0 VA: 0x1705FD0
	private static byte[] Compute_LM(string password, byte[] challenge) { }

	// RVA: 0x1706758 Offset: 0x1702758 VA: 0x1706758
	private static byte[] Compute_NTLM_Password(string password) { }

	// RVA: 0x170685C Offset: 0x170285C VA: 0x170685C
	private static byte[] Compute_NTLM(string password, byte[] challenge) { }

	// RVA: 0x17068C8 Offset: 0x17028C8 VA: 0x17068C8
	private static void Compute_NTLMv2_Session(string password, byte[] challenge, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1706AAC Offset: 0x1702AAC VA: 0x1706AAC
	private static byte[] Compute_NTLMv2(Type2Message type2, string username, string password, string domain) { }

	// RVA: 0x1706FD4 Offset: 0x1702FD4 VA: 0x1706FD4
	public static void Compute(Type2Message type2, NtlmAuthLevel level, string username, string password, string domain, out byte[] lm, out byte[] ntlm) { }

	// RVA: 0x1706464 Offset: 0x1702464 VA: 0x1706464
	private static byte[] GetResponse(byte[] challenge, byte[] pwd) { }

	// RVA: 0x17071E0 Offset: 0x17031E0 VA: 0x17071E0
	private static byte[] PrepareDESKey(byte[] key56bits, int position) { }

	// RVA: 0x17062FC Offset: 0x17022FC VA: 0x17062FC
	private static byte[] PasswordToKey(string password, int position) { }

	// RVA: 0x17073D8 Offset: 0x17033D8 VA: 0x17073D8
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public abstract class MessageBase // TypeDefIndex: 7545
{
	// Fields
	private static byte[] header; // 0x0
	private int _type; // 0x10
	private NtlmFlags _flags; // 0x14

	// Properties
	public NtlmFlags Flags { get; set; }
	public int Type { get; }

	// Methods

	// RVA: 0x17074BC Offset: 0x17034BC VA: 0x17074BC
	protected void .ctor(int messageType) { }

	// RVA: 0x17074E4 Offset: 0x17034E4 VA: 0x17074E4
	public NtlmFlags get_Flags() { }

	// RVA: 0x17074EC Offset: 0x17034EC VA: 0x17074EC
	public void set_Flags(NtlmFlags value) { }

	// RVA: 0x17074F4 Offset: 0x17034F4 VA: 0x17074F4
	public int get_Type() { }

	// RVA: 0x17074FC Offset: 0x17034FC VA: 0x17074FC
	protected byte[] PrepareMessage(int messageSize) { }

	// RVA: 0x17075FC Offset: 0x17035FC VA: 0x17075FC Slot: 4
	protected virtual void Decode(byte[] message) { }

	// RVA: 0x1707794 Offset: 0x1703794 VA: 0x1707794
	protected bool CheckHeader(byte[] message) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract byte[] GetBytes();

	// RVA: 0x17078A8 Offset: 0x17038A8 VA: 0x17078A8
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public enum NtlmAuthLevel // TypeDefIndex: 7546
{
	// Fields
	public int value__; // 0x0
	public const NtlmAuthLevel LM_and_NTLM = 0;
	public const NtlmAuthLevel LM_and_NTLM_and_try_NTLMv2_Session = 1;
	public const NtlmAuthLevel NTLM_only = 2;
	public const NtlmAuthLevel NTLMv2_only = 3;
}

// Namespace: Mono.Security.Protocol.Ntlm
[Flags]
public enum NtlmFlags // TypeDefIndex: 7547
{
	// Fields
	public int value__; // 0x0
	public const NtlmFlags NegotiateUnicode = 1;
	public const NtlmFlags NegotiateOem = 2;
	public const NtlmFlags RequestTarget = 4;
	public const NtlmFlags NegotiateNtlm = 512;
	public const NtlmFlags NegotiateDomainSupplied = 4096;
	public const NtlmFlags NegotiateWorkstationSupplied = 8192;
	public const NtlmFlags NegotiateAlwaysSign = 32768;
	public const NtlmFlags NegotiateNtlm2Key = 524288;
	public const NtlmFlags Negotiate128 = 536870912;
	public const NtlmFlags Negotiate56 = -2147483648;
}

// Namespace: Mono.Security.Protocol.Ntlm
public static class NtlmSettings // TypeDefIndex: 7548
{
	// Fields
	private static NtlmAuthLevel defaultAuthLevel; // 0x0

	// Properties
	public static NtlmAuthLevel DefaultAuthLevel { get; }

	// Methods

	// RVA: 0x1707948 Offset: 0x1703948 VA: 0x1707948
	public static NtlmAuthLevel get_DefaultAuthLevel() { }

	// RVA: 0x17079A0 Offset: 0x17039A0 VA: 0x17079A0
	private static void .cctor() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type1Message : MessageBase // TypeDefIndex: 7549
{
	// Fields
	private string _host; // 0x18
	private string _domain; // 0x20

	// Properties
	public string Domain { set; }
	public string Host { set; }

	// Methods

	// RVA: 0x17079EC Offset: 0x17039EC VA: 0x17079EC
	public void .ctor() { }

	// RVA: 0x1707A88 Offset: 0x1703A88 VA: 0x1707A88
	public void set_Domain(string value) { }

	// RVA: 0x1707B14 Offset: 0x1703B14 VA: 0x1707B14
	public void set_Host(string value) { }

	// RVA: 0x1707BA0 Offset: 0x1703BA0 VA: 0x1707BA0 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x1707CA8 Offset: 0x1703CA8 VA: 0x1707CA8 Slot: 5
	public override byte[] GetBytes() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type2Message : MessageBase // TypeDefIndex: 7550
{
	// Fields
	private byte[] _nonce; // 0x18
	private string _targetName; // 0x20
	private byte[] _targetInfo; // 0x28

	// Properties
	public byte[] Nonce { get; }
	public string TargetName { get; }
	public byte[] TargetInfo { get; }

	// Methods

	// RVA: 0x1707F00 Offset: 0x1703F00 VA: 0x1707F00
	public void .ctor(byte[] message) { }

	// RVA: 0x1707FB0 Offset: 0x1703FB0 VA: 0x1707FB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1706F5C Offset: 0x1702F5C VA: 0x1706F5C
	public byte[] get_Nonce() { }

	// RVA: 0x170804C Offset: 0x170404C VA: 0x170804C
	public string get_TargetName() { }

	// RVA: 0x1706EE4 Offset: 0x1702EE4 VA: 0x1706EE4
	public byte[] get_TargetInfo() { }

	// RVA: 0x1708054 Offset: 0x1704054 VA: 0x1708054 Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x17081EC Offset: 0x17041EC VA: 0x17081EC Slot: 5
	public override byte[] GetBytes() { }
}

// Namespace: Mono.Security.Protocol.Ntlm
public class Type3Message : MessageBase // TypeDefIndex: 7551
{
	// Fields
	private NtlmAuthLevel _level; // 0x18
	private byte[] _challenge; // 0x20
	private string _host; // 0x28
	private string _domain; // 0x30
	private string _username; // 0x38
	private string _password; // 0x40
	private Type2Message _type2; // 0x48
	private byte[] _lm; // 0x50
	private byte[] _nt; // 0x58

	// Properties
	public string Domain { set; }
	public string Password { set; }
	public string Username { set; }

	// Methods

	// RVA: 0x17082A4 Offset: 0x17042A4 VA: 0x17082A4
	public void .ctor(Type2Message type2) { }

	// RVA: 0x17084E0 Offset: 0x17044E0 VA: 0x17084E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17085C0 Offset: 0x17045C0 VA: 0x17085C0
	public void set_Domain(string value) { }

	// RVA: 0x170864C Offset: 0x170464C VA: 0x170864C
	public void set_Password(string value) { }

	// RVA: 0x1708654 Offset: 0x1704654 VA: 0x1708654
	public void set_Username(string value) { }

	// RVA: 0x170865C Offset: 0x170465C VA: 0x170865C Slot: 4
	protected override void Decode(byte[] message) { }

	// RVA: 0x17088CC Offset: 0x17048CC VA: 0x17088CC
	private string DecodeString(byte[] buffer, int offset, int len) { }

	// RVA: 0x1708924 Offset: 0x1704924 VA: 0x1708924
	private byte[] EncodeString(string text) { }

	// RVA: 0x17089B4 Offset: 0x17049B4 VA: 0x17089B4 Slot: 5
	public override byte[] GetBytes() { }
}
