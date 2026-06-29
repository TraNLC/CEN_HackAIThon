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

// Namespace: System.Net.Security
public class SslClientAuthenticationOptions // TypeDefIndex: 4368
{
	// Fields
	private EncryptionPolicy _encryptionPolicy; // 0x10
	private X509RevocationMode _checkCertificateRevocation; // 0x14
	private SslProtocols _enabledSslProtocols; // 0x18
	private bool _allowRenegotiation; // 0x1C
	[CompilerGenerated]
	private string <TargetHost>k__BackingField; // 0x20
	[CompilerGenerated]
	private X509CertificateCollection <ClientCertificates>k__BackingField; // 0x28

	// Properties
	public string TargetHost { get; set; }
	public X509CertificateCollection ClientCertificates { get; set; }
	public X509RevocationMode CertificateRevocationCheckMode { set; }
	public EncryptionPolicy EncryptionPolicy { set; }
	public SslProtocols EnabledSslProtocols { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1CEEB88 Offset: 0x1CEAB88 VA: 0x1CEEB88
	public string get_TargetHost() { }

	[CompilerGenerated]
	// RVA: 0x1CEEB90 Offset: 0x1CEAB90 VA: 0x1CEEB90
	public void set_TargetHost(string value) { }

	[CompilerGenerated]
	// RVA: 0x1CEEB98 Offset: 0x1CEAB98 VA: 0x1CEEB98
	public X509CertificateCollection get_ClientCertificates() { }

	[CompilerGenerated]
	// RVA: 0x1CEEBA0 Offset: 0x1CEABA0 VA: 0x1CEEBA0
	public void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x1CEEBA8 Offset: 0x1CEABA8 VA: 0x1CEEBA8
	public void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x1CEEC3C Offset: 0x1CEAC3C VA: 0x1CEEC3C
	public void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x1CEECD0 Offset: 0x1CEACD0 VA: 0x1CEECD0
	public SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x1CEECD8 Offset: 0x1CEACD8 VA: 0x1CEECD8
	public void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x1CEECE0 Offset: 0x1CEACE0 VA: 0x1CEECE0
	public void .ctor() { }
}

// Namespace: System.Net.Security
public abstract class AuthenticatedStream : Stream // TypeDefIndex: 4369
{
	// Fields
	private Stream _InnerStream; // 0x28
	private bool _LeaveStreamOpen; // 0x30

	// Properties
	protected Stream InnerStream { get; }
	public abstract bool IsAuthenticated { get; }

	// Methods

	// RVA: 0x1CEECF0 Offset: 0x1CEACF0 VA: 0x1CEECF0
	protected void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x1CEEE8C Offset: 0x1CEAE8C VA: 0x1CEEE8C
	protected Stream get_InnerStream() { }

	// RVA: 0x1CEEE94 Offset: 0x1CEAE94 VA: 0x1CEEE94 Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 38
	public abstract bool get_IsAuthenticated();
}

// Namespace: System.Net.Security
public enum AuthenticationLevel // TypeDefIndex: 4370
{
	// Fields
	public int value__; // 0x0
	public const AuthenticationLevel None = 0;
	public const AuthenticationLevel MutualAuthRequested = 1;
	public const AuthenticationLevel MutualAuthRequired = 2;
}

// Namespace: System.Net.Security
public enum EncryptionPolicy // TypeDefIndex: 4371
{
	// Fields
	public int value__; // 0x0
	public const EncryptionPolicy RequireEncryption = 0;
	public const EncryptionPolicy AllowNoEncryption = 1;
	public const EncryptionPolicy NoEncryption = 2;
}

// Namespace: System.Net.Security
public sealed class LocalCertificateSelectionCallback : MulticastDelegate // TypeDefIndex: 4372
{
	// Methods

	// RVA: 0x1CEEF78 Offset: 0x1CEAF78 VA: 0x1CEEF78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1CEF084 Offset: 0x1CEB084 VA: 0x1CEF084 Slot: 12
	public virtual X509Certificate Invoke(object sender, string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}

// Namespace: System.Net.Security
public sealed class RemoteCertificateValidationCallback : MulticastDelegate // TypeDefIndex: 4373
{
	// Methods

	// RVA: 0x1CEF098 Offset: 0x1CEB098 VA: 0x1CEF098
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1CEF1A4 Offset: 0x1CEB1A4 VA: 0x1CEF1A4 Slot: 12
	public virtual bool Invoke(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}

// Namespace: System.Net.Security
[Flags]
public enum SslPolicyErrors // TypeDefIndex: 4374
{
	// Fields
	public int value__; // 0x0
	public const SslPolicyErrors None = 0;
	public const SslPolicyErrors RemoteCertificateNotAvailable = 1;
	public const SslPolicyErrors RemoteCertificateNameMismatch = 2;
	public const SslPolicyErrors RemoteCertificateChainErrors = 4;
}

// Namespace: System.Net.Security
internal sealed class LocalCertSelectionCallback : MulticastDelegate // TypeDefIndex: 4375
{
	// Methods

	// RVA: 0x1CEF1B8 Offset: 0x1CEB1B8 VA: 0x1CEF1B8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1CEF26C Offset: 0x1CEB26C VA: 0x1CEF26C Slot: 12
	public virtual X509Certificate Invoke(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }
}

// Namespace: System.Net.Security
internal sealed class ServerCertSelectionCallback : MulticastDelegate // TypeDefIndex: 4376
{
	// Methods

	// RVA: 0x1CEF280 Offset: 0x1CEB280 VA: 0x1CEF280
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1CEF330 Offset: 0x1CEB330 VA: 0x1CEF330 Slot: 12
	public virtual X509Certificate Invoke(string hostName) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SslStream.<>c__DisplayClass21_0 // TypeDefIndex: 4377
{
	// Fields
	public LocalCertificateSelectionCallback callback; // 0x10
	public SslStream <>4__this; // 0x18

	// Methods

	// RVA: 0x1CEF994 Offset: 0x1CEB994 VA: 0x1CEF994
	public void .ctor() { }

	// RVA: 0x1CF00FC Offset: 0x1CEC0FC VA: 0x1CF00FC
	internal X509Certificate <SetAndVerifySelectionCallback>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }
}

// Namespace: System.Net.Security
public class SslStream : AuthenticatedStream // TypeDefIndex: 4378
{
	// Fields
	private MobileTlsProvider provider; // 0x38
	private MonoTlsSettings settings; // 0x40
	private RemoteCertificateValidationCallback validationCallback; // 0x48
	private LocalCertificateSelectionCallback selectionCallback; // 0x50
	private MobileAuthenticatedStream impl; // 0x58
	private bool explicitSettings; // 0x60

	// Properties
	internal MobileAuthenticatedStream Impl { get; }
	internal string InternalTargetHost { get; }
	public override bool IsAuthenticated { get; }
	public virtual X509Certificate LocalCertificate { get; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanTimeout { get; }
	public override bool CanWrite { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1CEF344 Offset: 0x1CEB344 VA: 0x1CEF344
	internal MobileAuthenticatedStream get_Impl() { }

	// RVA: 0x1CEF3B4 Offset: 0x1CEB3B4 VA: 0x1CEF3B4
	internal string get_InternalTargetHost() { }

	// RVA: 0x1CEF3D8 Offset: 0x1CEB3D8 VA: 0x1CEF3D8
	private static MobileTlsProvider GetProvider() { }

	// RVA: 0x1CEF448 Offset: 0x1CEB448 VA: 0x1CEF448
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen) { }

	// RVA: 0x1CEF4D8 Offset: 0x1CEB4D8 VA: 0x1CEF4D8
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback) { }

	// RVA: 0x1CEF4E0 Offset: 0x1CEB4E0 VA: 0x1CEF4E0
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback) { }

	// RVA: 0x1CEF850 Offset: 0x1CEB850 VA: 0x1CEF850
	internal void .ctor(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x1CEF598 Offset: 0x1CEB598 VA: 0x1CEF598
	private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback) { }

	// RVA: 0x1CEF694 Offset: 0x1CEB694 VA: 0x1CEF694
	private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback) { }

	// RVA: 0x1CEF99C Offset: 0x1CEB99C VA: 0x1CEF99C Slot: 39
	public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x1CEF9F0 Offset: 0x1CEB9F0 VA: 0x1CEF9F0 Slot: 40
	public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1CEFA64 Offset: 0x1CEBA64 VA: 0x1CEFA64 Slot: 41
	public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x1CEFA70 Offset: 0x1CEBA70 VA: 0x1CEFA70 Slot: 42
	public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x1CEFAC4 Offset: 0x1CEBAC4 VA: 0x1CEFAC4 Slot: 43
	public virtual Task ShutdownAsync() { }

	// RVA: 0x1CEFAE8 Offset: 0x1CEBAE8 VA: 0x1CEFAE8 Slot: 38
	public override bool get_IsAuthenticated() { }

	// RVA: 0x1CEFB14 Offset: 0x1CEBB14 VA: 0x1CEFB14 Slot: 44
	public virtual X509Certificate get_LocalCertificate() { }

	// RVA: 0x1CEFB38 Offset: 0x1CEBB38 VA: 0x1CEFB38 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1CEFB40 Offset: 0x1CEBB40 VA: 0x1CEFB40 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1CEFB58 Offset: 0x1CEBB58 VA: 0x1CEFB58 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1CEFB74 Offset: 0x1CEBB74 VA: 0x1CEFB74 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1CEFB8C Offset: 0x1CEBB8C VA: 0x1CEFB8C Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1CEFBB8 Offset: 0x1CEBBB8 VA: 0x1CEFBB8 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1CEFBF4 Offset: 0x1CEBBF4 VA: 0x1CEFBF4 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1CEFC20 Offset: 0x1CEBC20 VA: 0x1CEFC20 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1CEFC5C Offset: 0x1CEBC5C VA: 0x1CEFC5C Slot: 11
	public override long get_Length() { }

	// RVA: 0x1CEFC84 Offset: 0x1CEBC84 VA: 0x1CEFC84 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1CEFCAC Offset: 0x1CEBCAC VA: 0x1CEFCAC Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1CEFD04 Offset: 0x1CEBD04 VA: 0x1CEFD04 Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1CEFD40 Offset: 0x1CEBD40 VA: 0x1CEFD40 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1CEFD98 Offset: 0x1CEBD98 VA: 0x1CEFD98 Slot: 21
	public override void Flush() { }

	// RVA: 0x1CEF35C Offset: 0x1CEB35C VA: 0x1CEF35C
	private void CheckDisposed() { }

	// RVA: 0x1CEFDB8 Offset: 0x1CEBDB8 VA: 0x1CEFDB8 Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1CEFE70 Offset: 0x1CEBE70 VA: 0x1CEFE70 Slot: 32
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1CEFEC4 Offset: 0x1CEBEC4 VA: 0x1CEFEC4 Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1CEFF18 Offset: 0x1CEBF18 VA: 0x1CEFF18 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1CEFF74 Offset: 0x1CEBF74 VA: 0x1CEFF74 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1CEFFD0 Offset: 0x1CEBFD0 VA: 0x1CEFFD0 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1CF003C Offset: 0x1CEC03C VA: 0x1CF003C Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1CF0084 Offset: 0x1CEC084 VA: 0x1CF0084 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1CF00F0 Offset: 0x1CEC0F0 VA: 0x1CF00F0 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 // TypeDefIndex: 4379
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 // TypeDefIndex: 4380
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 4381
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 // TypeDefIndex: 4382
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 4383
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 // TypeDefIndex: 4384
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 // TypeDefIndex: 4385
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 4386
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 4387
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 00C700F38385659BA060672F86D4A9A5376EADF9ED1CABB1C63290A0FDEFE36A /*Metadata offset 0x3E5EA8*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 04D9D643E5A26924DC98C9906714082D395DCB17CEE9674D5EBFEC15D098C2B5 /*Metadata offset 0x3E5FB0*/; // 0x100
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 063691760A57230E8119DF650327304D68AE1C009E476E48BE8C73DCA199D374 /*Metadata offset 0x3E5FD8*/; // 0x120
	internal static readonly long 1417FCAA8455DC8E3C88BF916DD5C75746A2597CC052F212A8E4394C890E012B = 2533330625626144; // 0x140
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 27625E383C3A91E8B65BC745FF5D4048C82B883CCD293B07DED697BF82733811 /*Metadata offset 0x3E6010*/; // 0x148
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 2EF83B43314F8CD03190EEE30ECCF048DA37791237F27C62A579F23EACE9FD70 /*Metadata offset 0x3E6020*/; // 0x151
	internal static readonly long 3505B8A2248AC03FE41ACADF8F29294572BBADEE1DD2E1A45D025766681C012C = 2533317740920864; // 0x178
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 356A582FCE68ACAE8FC944F7B4F0C0DA2BFF4A90D3767C75905F3EDE2E4E66CF /*Metadata offset 0x3E6058*/; // 0x180
	internal static readonly long 6C8F647E1FCD63826D12272FF0930E9C16F1FFEF719948703A4C0F3B90052885 = 2814805604696096; // 0x190
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 8109EF063456779751E8A4AEE94A0BE9AE32827B6EB153ABD7F40057FF2C9CE3 /*Metadata offset 0x3E6078*/; // 0x198
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 9001C3EDE1D7E939C07996B84F82F7CBE59A7266C1FC2735E959E3C8609602E8 /*Metadata offset 0x3E6100*/; // 0x218
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 9F58F1261D211553DE8FBC1AFA477C84EA3974B9BFF38223D771D0CDA787E15A /*Metadata offset 0x3E6130*/; // 0x244
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 B849624EC20707184A433E21DAAC963906D4B261A19BD8F139F0E269E59E308C /*Metadata offset 0x3E6138*/; // 0x24A
	internal static readonly long BB6BB42AC5453BD8AA992CCB8929F1CB7D4E112E3FC56E57D711E106D1F72859 = 11540663026319392; // 0x2D0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=14 DFA7289CF8D8029ACEE90F30530C6926950E8DD20285772458F271AFD015BAD5 /*Metadata offset 0x3E61D0*/; // 0x2D8

	// Methods

	// RVA: 0x1CF0134 Offset: 0x1CEC134 VA: 0x1CF0134
	internal static uint ComputeStringHash(string s) { }
}
