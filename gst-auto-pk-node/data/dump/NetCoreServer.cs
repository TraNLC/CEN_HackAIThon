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

// Namespace: NetCoreServer
[DefaultMember("Item")]
public class Buffer // TypeDefIndex: 7938
{
	// Fields
	private byte[] _data; // 0x10
	private long _size; // 0x18
	private long _offset; // 0x20

	// Properties
	public bool IsEmpty { get; }
	public byte[] Data { get; }
	public long Capacity { get; }
	public long Size { get; }
	public long Offset { get; }
	public byte Item { get; }

	// Methods

	// RVA: 0xFF1E40 Offset: 0xFEDE40 VA: 0xFF1E40
	public bool get_IsEmpty() { }

	// RVA: 0xFF1E60 Offset: 0xFEDE60 VA: 0xFF1E60
	public byte[] get_Data() { }

	// RVA: 0xFF1E68 Offset: 0xFEDE68 VA: 0xFF1E68
	public long get_Capacity() { }

	// RVA: 0xFF1E80 Offset: 0xFEDE80 VA: 0xFF1E80
	public long get_Size() { }

	// RVA: 0xFF1E88 Offset: 0xFEDE88 VA: 0xFF1E88
	public long get_Offset() { }

	// RVA: 0xFF1E90 Offset: 0xFEDE90 VA: 0xFF1E90
	public byte get_Item(int index) { }

	// RVA: 0xFF1EC0 Offset: 0xFEDEC0 VA: 0xFF1EC0
	public void .ctor() { }

	// RVA: 0xFF1F2C Offset: 0xFEDF2C VA: 0xFF1F2C
	public void .ctor(long capacity) { }

	// RVA: 0xFF1FB0 Offset: 0xFEDFB0 VA: 0xFF1FB0
	public void .ctor(byte[] data) { }

	// RVA: 0xFF1FF4 Offset: 0xFEDFF4 VA: 0xFF1FF4 Slot: 3
	public override string ToString() { }

	// RVA: 0xFF20B4 Offset: 0xFEE0B4 VA: 0xFF20B4
	public void Clear() { }

	// RVA: 0xFF2000 Offset: 0xFEE000 VA: 0xFF2000
	public string ExtractString(long offset, long size) { }

	// RVA: 0xFF20BC Offset: 0xFEE0BC VA: 0xFF20BC
	public void Remove(long offset, long size) { }

	// RVA: 0xFF2198 Offset: 0xFEE198 VA: 0xFF2198
	public void Reserve(long capacity) { }

	// RVA: 0xFF22F0 Offset: 0xFEE2F0 VA: 0xFF22F0
	public void Resize(long size) { }

	// RVA: 0xFF2324 Offset: 0xFEE324 VA: 0xFF2324
	public void Shift(long offset) { }

	// RVA: 0xFF2334 Offset: 0xFEE334 VA: 0xFF2334
	public void Unshift(long offset) { }

	// RVA: 0xFF2344 Offset: 0xFEE344 VA: 0xFF2344
	public long Append(byte[] buffer) { }

	// RVA: 0xFF23A0 Offset: 0xFEE3A0 VA: 0xFF23A0
	public long Append(byte[] buffer, long offset, long size) { }

	// RVA: 0xFF2400 Offset: 0xFEE400 VA: 0xFF2400
	public long Append(string text) { }
}

// Namespace: NetCoreServer
public class SslClient : IDisposable // TypeDefIndex: 7939
{
	// Fields
	[CompilerGenerated]
	private readonly Guid <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Address>k__BackingField; // 0x20
	[CompilerGenerated]
	private SslContext <Context>k__BackingField; // 0x28
	[CompilerGenerated]
	private IPEndPoint <Endpoint>k__BackingField; // 0x30
	[CompilerGenerated]
	private Socket <Socket>k__BackingField; // 0x38
	[CompilerGenerated]
	private long <BytesPending>k__BackingField; // 0x40
	[CompilerGenerated]
	private long <BytesSending>k__BackingField; // 0x48
	[CompilerGenerated]
	private long <BytesSent>k__BackingField; // 0x50
	[CompilerGenerated]
	private long <BytesReceived>k__BackingField; // 0x58
	[CompilerGenerated]
	private bool <OptionDualMode>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <OptionKeepAlive>k__BackingField; // 0x61
	[CompilerGenerated]
	private bool <OptionNoDelay>k__BackingField; // 0x62
	[CompilerGenerated]
	private int <OptionReceiveBufferSize>k__BackingField; // 0x64
	[CompilerGenerated]
	private int <OptionSendBufferSize>k__BackingField; // 0x68
	private bool _disconnecting; // 0x6C
	private SocketAsyncEventArgs _connectEventArg; // 0x70
	private SslStream _sslStream; // 0x78
	private Nullable<Guid> _sslStreamId; // 0x80
	[CompilerGenerated]
	private bool <IsConnecting>k__BackingField; // 0x94
	[CompilerGenerated]
	private bool <IsConnected>k__BackingField; // 0x95
	[CompilerGenerated]
	private bool <IsHandshaking>k__BackingField; // 0x96
	[CompilerGenerated]
	private bool <IsHandshaked>k__BackingField; // 0x97
	private bool _receiving; // 0x98
	private Buffer _receiveBuffer; // 0xA0
	private readonly object _sendLock; // 0xA8
	private bool _sending; // 0xB0
	private Buffer _sendBufferMain; // 0xB8
	private Buffer _sendBufferFlush; // 0xC0
	private long _sendBufferFlushOffset; // 0xC8
	[CompilerGenerated]
	private bool <IsDisposed>k__BackingField; // 0xD0
	[CompilerGenerated]
	private bool <IsSocketDisposed>k__BackingField; // 0xD1

	// Properties
	public Guid Id { get; }
	public string Address { get; set; }
	public SslContext Context { get; set; }
	public IPEndPoint Endpoint { get; set; }
	public Socket Socket { get; set; }
	public long BytesPending { get; set; }
	public long BytesSending { get; set; }
	public long BytesSent { get; set; }
	public long BytesReceived { get; set; }
	public bool OptionDualMode { get; set; }
	public bool OptionKeepAlive { get; set; }
	public bool OptionNoDelay { get; set; }
	public int OptionReceiveBufferSize { get; set; }
	public int OptionSendBufferSize { get; set; }
	public bool IsConnecting { get; set; }
	public bool IsConnected { get; set; }
	public bool IsHandshaking { get; set; }
	public bool IsHandshaked { get; set; }
	public bool IsDisposed { get; set; }
	public bool IsSocketDisposed { get; set; }

	// Methods

	// RVA: 0xFF2498 Offset: 0xFEE498 VA: 0xFF2498
	public void .ctor(SslContext context, IPAddress address, int port) { }

	// RVA: 0xFF2600 Offset: 0xFEE600 VA: 0xFF2600
	public void .ctor(SslContext context, string address, int port) { }

	// RVA: 0xFF251C Offset: 0xFEE51C VA: 0xFF251C
	public void .ctor(SslContext context, IPEndPoint endpoint) { }

	[CompilerGenerated]
	// RVA: 0xFF26CC Offset: 0xFEE6CC VA: 0xFF26CC
	public Guid get_Id() { }

	[CompilerGenerated]
	// RVA: 0xFF26D8 Offset: 0xFEE6D8 VA: 0xFF26D8
	public string get_Address() { }

	[CompilerGenerated]
	// RVA: 0xFF26E0 Offset: 0xFEE6E0 VA: 0xFF26E0
	public void set_Address(string value) { }

	[CompilerGenerated]
	// RVA: 0xFF26E8 Offset: 0xFEE6E8 VA: 0xFF26E8
	public SslContext get_Context() { }

	[CompilerGenerated]
	// RVA: 0xFF26F0 Offset: 0xFEE6F0 VA: 0xFF26F0
	private void set_Context(SslContext value) { }

	[CompilerGenerated]
	// RVA: 0xFF26F8 Offset: 0xFEE6F8 VA: 0xFF26F8
	public IPEndPoint get_Endpoint() { }

	[CompilerGenerated]
	// RVA: 0xFF2700 Offset: 0xFEE700 VA: 0xFF2700
	private void set_Endpoint(IPEndPoint value) { }

	[CompilerGenerated]
	// RVA: 0xFF2708 Offset: 0xFEE708 VA: 0xFF2708
	public Socket get_Socket() { }

	[CompilerGenerated]
	// RVA: 0xFF2710 Offset: 0xFEE710 VA: 0xFF2710
	private void set_Socket(Socket value) { }

	[CompilerGenerated]
	// RVA: 0xFF2718 Offset: 0xFEE718 VA: 0xFF2718
	public long get_BytesPending() { }

	[CompilerGenerated]
	// RVA: 0xFF2720 Offset: 0xFEE720 VA: 0xFF2720
	private void set_BytesPending(long value) { }

	[CompilerGenerated]
	// RVA: 0xFF2728 Offset: 0xFEE728 VA: 0xFF2728
	public long get_BytesSending() { }

	[CompilerGenerated]
	// RVA: 0xFF2730 Offset: 0xFEE730 VA: 0xFF2730
	private void set_BytesSending(long value) { }

	[CompilerGenerated]
	// RVA: 0xFF2738 Offset: 0xFEE738 VA: 0xFF2738
	public long get_BytesSent() { }

	[CompilerGenerated]
	// RVA: 0xFF2740 Offset: 0xFEE740 VA: 0xFF2740
	private void set_BytesSent(long value) { }

	[CompilerGenerated]
	// RVA: 0xFF2748 Offset: 0xFEE748 VA: 0xFF2748
	public long get_BytesReceived() { }

	[CompilerGenerated]
	// RVA: 0xFF2750 Offset: 0xFEE750 VA: 0xFF2750
	private void set_BytesReceived(long value) { }

	[CompilerGenerated]
	// RVA: 0xFF2758 Offset: 0xFEE758 VA: 0xFF2758
	public bool get_OptionDualMode() { }

	[CompilerGenerated]
	// RVA: 0xFF2760 Offset: 0xFEE760 VA: 0xFF2760
	public void set_OptionDualMode(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF2768 Offset: 0xFEE768 VA: 0xFF2768
	public bool get_OptionKeepAlive() { }

	[CompilerGenerated]
	// RVA: 0xFF2770 Offset: 0xFEE770 VA: 0xFF2770
	public void set_OptionKeepAlive(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF2778 Offset: 0xFEE778 VA: 0xFF2778
	public bool get_OptionNoDelay() { }

	[CompilerGenerated]
	// RVA: 0xFF2780 Offset: 0xFEE780 VA: 0xFF2780
	public void set_OptionNoDelay(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF2788 Offset: 0xFEE788 VA: 0xFF2788
	public int get_OptionReceiveBufferSize() { }

	[CompilerGenerated]
	// RVA: 0xFF2790 Offset: 0xFEE790 VA: 0xFF2790
	public void set_OptionReceiveBufferSize(int value) { }

	[CompilerGenerated]
	// RVA: 0xFF2798 Offset: 0xFEE798 VA: 0xFF2798
	public int get_OptionSendBufferSize() { }

	[CompilerGenerated]
	// RVA: 0xFF27A0 Offset: 0xFEE7A0 VA: 0xFF27A0
	public void set_OptionSendBufferSize(int value) { }

	[CompilerGenerated]
	// RVA: 0xFF27A8 Offset: 0xFEE7A8 VA: 0xFF27A8
	public bool get_IsConnecting() { }

	[CompilerGenerated]
	// RVA: 0xFF27B0 Offset: 0xFEE7B0 VA: 0xFF27B0
	private void set_IsConnecting(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF27B8 Offset: 0xFEE7B8 VA: 0xFF27B8
	public bool get_IsConnected() { }

	[CompilerGenerated]
	// RVA: 0xFF27C0 Offset: 0xFEE7C0 VA: 0xFF27C0
	private void set_IsConnected(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF27C8 Offset: 0xFEE7C8 VA: 0xFF27C8
	public bool get_IsHandshaking() { }

	[CompilerGenerated]
	// RVA: 0xFF27D0 Offset: 0xFEE7D0 VA: 0xFF27D0
	private void set_IsHandshaking(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF27D8 Offset: 0xFEE7D8 VA: 0xFF27D8
	public bool get_IsHandshaked() { }

	[CompilerGenerated]
	// RVA: 0xFF27E0 Offset: 0xFEE7E0 VA: 0xFF27E0
	private void set_IsHandshaked(bool value) { }

	// RVA: 0xFF27E8 Offset: 0xFEE7E8 VA: 0xFF27E8 Slot: 5
	protected virtual Socket CreateSocket() { }

	// RVA: 0xFF286C Offset: 0xFEE86C VA: 0xFF286C Slot: 6
	public virtual bool Connect() { }

	// RVA: 0xFF2FEC Offset: 0xFEEFEC VA: 0xFF2FEC Slot: 7
	public virtual bool Disconnect() { }

	// RVA: 0xFF3424 Offset: 0xFEF424 VA: 0xFF3424 Slot: 8
	public virtual bool Reconnect() { }

	// RVA: 0xFF345C Offset: 0xFEF45C VA: 0xFF345C Slot: 9
	public virtual bool ConnectAsync() { }

	// RVA: 0xFF3B50 Offset: 0xFEFB50 VA: 0xFF3B50 Slot: 10
	public virtual bool DisconnectAsync() { }

	// RVA: 0xFF3B5C Offset: 0xFEFB5C VA: 0xFF3B5C Slot: 11
	public virtual bool ReconnectAsync() { }

	// RVA: 0xFF3BA8 Offset: 0xFEFBA8 VA: 0xFF3BA8 Slot: 12
	public virtual long Send(byte[] buffer) { }

	// RVA: 0xFF3BCC Offset: 0xFEFBCC VA: 0xFF3BCC Slot: 13
	public virtual long Send(byte[] buffer, long offset, long size) { }

	// RVA: 0xFF3CCC Offset: 0xFEFCCC VA: 0xFF3CCC Slot: 14
	public virtual long Send(string text) { }

	// RVA: 0xFF3D1C Offset: 0xFEFD1C VA: 0xFF3D1C Slot: 15
	public virtual bool SendAsync(byte[] buffer) { }

	// RVA: 0xFF3D40 Offset: 0xFEFD40 VA: 0xFF3D40 Slot: 16
	public virtual bool SendAsync(byte[] buffer, long offset, long size) { }

	// RVA: 0xFF4180 Offset: 0xFF0180 VA: 0xFF4180 Slot: 17
	public virtual bool SendAsync(string text) { }

	// RVA: 0xFF41D4 Offset: 0xFF01D4 VA: 0xFF41D4 Slot: 18
	public virtual long Receive(byte[] buffer) { }

	// RVA: 0xFF41F8 Offset: 0xFF01F8 VA: 0xFF41F8 Slot: 19
	public virtual long Receive(byte[] buffer, long offset, long size) { }

	// RVA: 0xFF4308 Offset: 0xFF0308 VA: 0xFF4308 Slot: 20
	public virtual string Receive(long size) { }

	// RVA: 0xFF43B4 Offset: 0xFF03B4 VA: 0xFF43B4 Slot: 21
	public virtual void ReceiveAsync() { }

	// RVA: 0xFF43B8 Offset: 0xFF03B8 VA: 0xFF43B8
	private void TryReceive() { }

	// RVA: 0xFF3E7C Offset: 0xFEFE7C VA: 0xFF3E7C
	private void TrySend() { }

	// RVA: 0xFF3340 Offset: 0xFEF340 VA: 0xFF3340
	private void ClearBuffers() { }

	// RVA: 0xFF4620 Offset: 0xFF0620 VA: 0xFF4620
	private void OnAsyncCompleted(object sender, SocketAsyncEventArgs e) { }

	// RVA: 0xFF3668 Offset: 0xFEF668 VA: 0xFF3668
	private void ProcessConnect(SocketAsyncEventArgs e) { }

	// RVA: 0xFF469C Offset: 0xFF069C VA: 0xFF469C
	private void ProcessHandshake(IAsyncResult result) { }

	// RVA: 0xFF49D8 Offset: 0xFF09D8 VA: 0xFF49D8
	private void ProcessReceive(IAsyncResult result) { }

	// RVA: 0xFF4DCC Offset: 0xFF0DCC VA: 0xFF4DCC
	private void ProcessSend(IAsyncResult result) { }

	// RVA: 0xFF50FC Offset: 0xFF10FC VA: 0xFF50FC Slot: 22
	protected virtual void OnConnecting() { }

	// RVA: 0xFF5100 Offset: 0xFF1100 VA: 0xFF5100 Slot: 23
	protected virtual void OnConnected() { }

	// RVA: 0xFF5104 Offset: 0xFF1104 VA: 0xFF5104 Slot: 24
	protected virtual void OnHandshaking() { }

	// RVA: 0xFF5108 Offset: 0xFF1108 VA: 0xFF5108 Slot: 25
	protected virtual void OnHandshaked() { }

	// RVA: 0xFF510C Offset: 0xFF110C VA: 0xFF510C Slot: 26
	protected virtual void OnDisconnecting() { }

	// RVA: 0xFF5110 Offset: 0xFF1110 VA: 0xFF5110 Slot: 27
	protected virtual void OnDisconnected() { }

	// RVA: 0xFF5114 Offset: 0xFF1114 VA: 0xFF5114 Slot: 28
	protected virtual void OnReceived(byte[] buffer, long offset, long size) { }

	// RVA: 0xFF5118 Offset: 0xFF1118 VA: 0xFF5118 Slot: 29
	protected virtual void OnSent(long sent, long pending) { }

	// RVA: 0xFF511C Offset: 0xFF111C VA: 0xFF511C Slot: 30
	protected virtual void OnEmpty() { }

	// RVA: 0xFF5120 Offset: 0xFF1120 VA: 0xFF5120 Slot: 31
	protected virtual void OnError(SocketError error) { }

	// RVA: 0xFF2FAC Offset: 0xFEEFAC VA: 0xFF2FAC
	private void SendError(SocketError error) { }

	[CompilerGenerated]
	// RVA: 0xFF5124 Offset: 0xFF1124 VA: 0xFF5124
	public bool get_IsDisposed() { }

	[CompilerGenerated]
	// RVA: 0xFF512C Offset: 0xFF112C VA: 0xFF512C
	private void set_IsDisposed(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF5134 Offset: 0xFF1134 VA: 0xFF5134
	public bool get_IsSocketDisposed() { }

	[CompilerGenerated]
	// RVA: 0xFF513C Offset: 0xFF113C VA: 0xFF513C
	private void set_IsSocketDisposed(bool value) { }

	// RVA: 0xFF5144 Offset: 0xFF1144 VA: 0xFF5144 Slot: 4
	public void Dispose() { }

	// RVA: 0xFF51B4 Offset: 0xFF11B4 VA: 0xFF51B4 Slot: 32
	protected virtual void Dispose(bool disposingManagedResources) { }

	// RVA: 0xFF51EC Offset: 0xFF11EC VA: 0xFF51EC Slot: 1
	protected override void Finalize() { }
}

// Namespace: NetCoreServer
public class SslContext // TypeDefIndex: 7940
{
	// Fields
	[CompilerGenerated]
	private SslProtocols <Protocols>k__BackingField; // 0x10
	[CompilerGenerated]
	private X509Certificate <Certificate>k__BackingField; // 0x18
	[CompilerGenerated]
	private X509Certificate2Collection <Certificates>k__BackingField; // 0x20
	[CompilerGenerated]
	private RemoteCertificateValidationCallback <CertificateValidationCallback>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <ClientCertificateRequired>k__BackingField; // 0x30

	// Properties
	public SslProtocols Protocols { get; set; }
	public X509Certificate Certificate { get; set; }
	public X509Certificate2Collection Certificates { get; set; }
	public RemoteCertificateValidationCallback CertificateValidationCallback { get; set; }
	public bool ClientCertificateRequired { get; set; }

	// Methods

	// RVA: 0xFF5280 Offset: 0xFF1280 VA: 0xFF5280
	public void .ctor() { }

	// RVA: 0xFF52A0 Offset: 0xFF12A0 VA: 0xFF52A0
	public void .ctor(SslProtocols protocols) { }

	// RVA: 0xFF52C8 Offset: 0xFF12C8 VA: 0xFF52C8
	public void .ctor(SslProtocols protocols, X509Certificate certificate) { }

	// RVA: 0xFF52D0 Offset: 0xFF12D0 VA: 0xFF52D0
	public void .ctor(SslProtocols protocols, X509Certificate certificate, RemoteCertificateValidationCallback certificateValidationCallback) { }

	// RVA: 0xFF5324 Offset: 0xFF1324 VA: 0xFF5324
	public void .ctor(SslProtocols protocols, X509Certificate2Collection certificates) { }

	// RVA: 0xFF532C Offset: 0xFF132C VA: 0xFF532C
	public void .ctor(SslProtocols protocols, X509Certificate2Collection certificates, RemoteCertificateValidationCallback certificateValidationCallback) { }

	[CompilerGenerated]
	// RVA: 0xFF5380 Offset: 0xFF1380 VA: 0xFF5380
	public SslProtocols get_Protocols() { }

	[CompilerGenerated]
	// RVA: 0xFF5388 Offset: 0xFF1388 VA: 0xFF5388
	public void set_Protocols(SslProtocols value) { }

	[CompilerGenerated]
	// RVA: 0xFF5390 Offset: 0xFF1390 VA: 0xFF5390
	public X509Certificate get_Certificate() { }

	[CompilerGenerated]
	// RVA: 0xFF5398 Offset: 0xFF1398 VA: 0xFF5398
	public void set_Certificate(X509Certificate value) { }

	[CompilerGenerated]
	// RVA: 0xFF53A0 Offset: 0xFF13A0 VA: 0xFF53A0
	public X509Certificate2Collection get_Certificates() { }

	[CompilerGenerated]
	// RVA: 0xFF53A8 Offset: 0xFF13A8 VA: 0xFF53A8
	public void set_Certificates(X509Certificate2Collection value) { }

	[CompilerGenerated]
	// RVA: 0xFF53B0 Offset: 0xFF13B0 VA: 0xFF53B0
	public RemoteCertificateValidationCallback get_CertificateValidationCallback() { }

	[CompilerGenerated]
	// RVA: 0xFF53B8 Offset: 0xFF13B8 VA: 0xFF53B8
	public void set_CertificateValidationCallback(RemoteCertificateValidationCallback value) { }

	[CompilerGenerated]
	// RVA: 0xFF53C0 Offset: 0xFF13C0 VA: 0xFF53C0
	public bool get_ClientCertificateRequired() { }

	[CompilerGenerated]
	// RVA: 0xFF53C8 Offset: 0xFF13C8 VA: 0xFF53C8
	public void set_ClientCertificateRequired(bool value) { }
}

// Namespace: NetCoreServer
public class TcpClient : IDisposable // TypeDefIndex: 7941
{
	// Fields
	[CompilerGenerated]
	private readonly Guid <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private IPEndPoint <Endpoint>k__BackingField; // 0x20
	[CompilerGenerated]
	private Socket <Socket>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <BytesPending>k__BackingField; // 0x30
	[CompilerGenerated]
	private long <BytesSending>k__BackingField; // 0x38
	[CompilerGenerated]
	private long <BytesSent>k__BackingField; // 0x40
	[CompilerGenerated]
	private long <BytesReceived>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <OptionDualMode>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <OptionKeepAlive>k__BackingField; // 0x51
	[CompilerGenerated]
	private bool <OptionNoDelay>k__BackingField; // 0x52
	[CompilerGenerated]
	private int <OptionReceiveBufferSize>k__BackingField; // 0x54
	[CompilerGenerated]
	private int <OptionSendBufferSize>k__BackingField; // 0x58
	private SocketAsyncEventArgs _connectEventArg; // 0x60
	[CompilerGenerated]
	private bool <IsConnecting>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <IsConnected>k__BackingField; // 0x69
	private bool _receiving; // 0x6A
	private Buffer _receiveBuffer; // 0x70
	private SocketAsyncEventArgs _receiveEventArg; // 0x78
	private readonly object _sendLock; // 0x80
	private bool _sending; // 0x88
	private Buffer _sendBufferMain; // 0x90
	private Buffer _sendBufferFlush; // 0x98
	private SocketAsyncEventArgs _sendEventArg; // 0xA0
	private long _sendBufferFlushOffset; // 0xA8
	[CompilerGenerated]
	private bool <IsDisposed>k__BackingField; // 0xB0
	[CompilerGenerated]
	private bool <IsSocketDisposed>k__BackingField; // 0xB1

	// Properties
	public Guid Id { get; }
	public IPEndPoint Endpoint { get; set; }
	public Socket Socket { get; set; }
	public long BytesPending { get; set; }
	public long BytesSending { get; set; }
	public long BytesSent { get; set; }
	public long BytesReceived { get; set; }
	public bool OptionDualMode { get; set; }
	public bool OptionKeepAlive { get; set; }
	public bool OptionNoDelay { get; set; }
	public int OptionReceiveBufferSize { get; set; }
	public int OptionSendBufferSize { get; set; }
	public bool IsConnecting { get; set; }
	public bool IsConnected { get; set; }
	public bool IsDisposed { get; set; }
	public bool IsSocketDisposed { get; set; }

	// Methods

	// RVA: 0xFF53D0 Offset: 0xFF13D0 VA: 0xFF53D0
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0xFF54F0 Offset: 0xFF14F0 VA: 0xFF54F0
	public void .ctor(string address, int port) { }

	// RVA: 0xFF5444 Offset: 0xFF1444 VA: 0xFF5444
	public void .ctor(IPEndPoint endpoint) { }

	[CompilerGenerated]
	// RVA: 0xFF559C Offset: 0xFF159C VA: 0xFF559C
	public Guid get_Id() { }

	[CompilerGenerated]
	// RVA: 0xFF55A8 Offset: 0xFF15A8 VA: 0xFF55A8
	public IPEndPoint get_Endpoint() { }

	[CompilerGenerated]
	// RVA: 0xFF55B0 Offset: 0xFF15B0 VA: 0xFF55B0
	private void set_Endpoint(IPEndPoint value) { }

	[CompilerGenerated]
	// RVA: 0xFF55B8 Offset: 0xFF15B8 VA: 0xFF55B8
	public Socket get_Socket() { }

	[CompilerGenerated]
	// RVA: 0xFF55C0 Offset: 0xFF15C0 VA: 0xFF55C0
	private void set_Socket(Socket value) { }

	[CompilerGenerated]
	// RVA: 0xFF55C8 Offset: 0xFF15C8 VA: 0xFF55C8
	public long get_BytesPending() { }

	[CompilerGenerated]
	// RVA: 0xFF55D0 Offset: 0xFF15D0 VA: 0xFF55D0
	private void set_BytesPending(long value) { }

	[CompilerGenerated]
	// RVA: 0xFF55D8 Offset: 0xFF15D8 VA: 0xFF55D8
	public long get_BytesSending() { }

	[CompilerGenerated]
	// RVA: 0xFF55E0 Offset: 0xFF15E0 VA: 0xFF55E0
	private void set_BytesSending(long value) { }

	[CompilerGenerated]
	// RVA: 0xFF55E8 Offset: 0xFF15E8 VA: 0xFF55E8
	public long get_BytesSent() { }

	[CompilerGenerated]
	// RVA: 0xFF55F0 Offset: 0xFF15F0 VA: 0xFF55F0
	private void set_BytesSent(long value) { }

	[CompilerGenerated]
	// RVA: 0xFF55F8 Offset: 0xFF15F8 VA: 0xFF55F8
	public long get_BytesReceived() { }

	[CompilerGenerated]
	// RVA: 0xFF5600 Offset: 0xFF1600 VA: 0xFF5600
	private void set_BytesReceived(long value) { }

	[CompilerGenerated]
	// RVA: 0xFF5608 Offset: 0xFF1608 VA: 0xFF5608
	public bool get_OptionDualMode() { }

	[CompilerGenerated]
	// RVA: 0xFF5610 Offset: 0xFF1610 VA: 0xFF5610
	public void set_OptionDualMode(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF5618 Offset: 0xFF1618 VA: 0xFF5618
	public bool get_OptionKeepAlive() { }

	[CompilerGenerated]
	// RVA: 0xFF5620 Offset: 0xFF1620 VA: 0xFF5620
	public void set_OptionKeepAlive(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF5628 Offset: 0xFF1628 VA: 0xFF5628
	public bool get_OptionNoDelay() { }

	[CompilerGenerated]
	// RVA: 0xFF5630 Offset: 0xFF1630 VA: 0xFF5630
	public void set_OptionNoDelay(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF5638 Offset: 0xFF1638 VA: 0xFF5638
	public int get_OptionReceiveBufferSize() { }

	[CompilerGenerated]
	// RVA: 0xFF5640 Offset: 0xFF1640 VA: 0xFF5640
	public void set_OptionReceiveBufferSize(int value) { }

	[CompilerGenerated]
	// RVA: 0xFF5648 Offset: 0xFF1648 VA: 0xFF5648
	public int get_OptionSendBufferSize() { }

	[CompilerGenerated]
	// RVA: 0xFF5650 Offset: 0xFF1650 VA: 0xFF5650
	public void set_OptionSendBufferSize(int value) { }

	[CompilerGenerated]
	// RVA: 0xFF5658 Offset: 0xFF1658 VA: 0xFF5658
	public bool get_IsConnecting() { }

	[CompilerGenerated]
	// RVA: 0xFF5660 Offset: 0xFF1660 VA: 0xFF5660
	private void set_IsConnecting(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF5668 Offset: 0xFF1668 VA: 0xFF5668
	public bool get_IsConnected() { }

	[CompilerGenerated]
	// RVA: 0xFF5670 Offset: 0xFF1670 VA: 0xFF5670
	private void set_IsConnected(bool value) { }

	// RVA: 0xFF5678 Offset: 0xFF1678 VA: 0xFF5678 Slot: 5
	protected virtual Socket CreateSocket() { }

	// RVA: 0xFF56FC Offset: 0xFF16FC VA: 0xFF56FC Slot: 6
	public virtual bool Connect() { }

	// RVA: 0xFF5CB4 Offset: 0xFF1CB4 VA: 0xFF5CB4 Slot: 7
	public virtual bool Disconnect() { }

	// RVA: 0xFF60A4 Offset: 0xFF20A4 VA: 0xFF60A4 Slot: 8
	public virtual bool Reconnect() { }

	// RVA: 0xFF60DC Offset: 0xFF20DC VA: 0xFF60DC Slot: 9
	public virtual bool ConnectAsync() { }

	// RVA: 0xFF64B8 Offset: 0xFF24B8 VA: 0xFF64B8 Slot: 10
	public virtual bool DisconnectAsync() { }

	// RVA: 0xFF64C4 Offset: 0xFF24C4 VA: 0xFF64C4 Slot: 11
	public virtual bool ReconnectAsync() { }

	// RVA: 0xFF6510 Offset: 0xFF2510 VA: 0xFF6510 Slot: 12
	public virtual long Send(byte[] buffer) { }

	// RVA: 0xFF6534 Offset: 0xFF2534 VA: 0xFF6534 Slot: 13
	public virtual long Send(byte[] buffer, long offset, long size) { }

	// RVA: 0xFF65D8 Offset: 0xFF25D8 VA: 0xFF65D8 Slot: 14
	public virtual long Send(string text) { }

	// RVA: 0xFF6628 Offset: 0xFF2628 VA: 0xFF6628 Slot: 15
	public virtual bool SendAsync(byte[] buffer) { }

	// RVA: 0xFF664C Offset: 0xFF264C VA: 0xFF664C Slot: 16
	public virtual bool SendAsync(byte[] buffer, long offset, long size) { }

	// RVA: 0xFF6A1C Offset: 0xFF2A1C VA: 0xFF6A1C Slot: 17
	public virtual bool SendAsync(string text) { }

	// RVA: 0xFF6A70 Offset: 0xFF2A70 VA: 0xFF6A70 Slot: 18
	public virtual long Receive(byte[] buffer) { }

	// RVA: 0xFF6A94 Offset: 0xFF2A94 VA: 0xFF6A94 Slot: 19
	public virtual long Receive(byte[] buffer, long offset, long size) { }

	// RVA: 0xFF6B44 Offset: 0xFF2B44 VA: 0xFF6B44 Slot: 20
	public virtual string Receive(long size) { }

	// RVA: 0xFF6BF0 Offset: 0xFF2BF0 VA: 0xFF6BF0 Slot: 21
	public virtual void ReceiveAsync() { }

	// RVA: 0xFF6BF4 Offset: 0xFF2BF4 VA: 0xFF6BF4
	private void TryReceive() { }

	// RVA: 0xFF6788 Offset: 0xFF2788 VA: 0xFF6788
	private void TrySend() { }

	// RVA: 0xFF5FC0 Offset: 0xFF1FC0 VA: 0xFF5FC0
	private void ClearBuffers() { }

	// RVA: 0xFF6ED0 Offset: 0xFF2ED0 VA: 0xFF6ED0
	private void OnAsyncCompleted(object sender, SocketAsyncEventArgs e) { }

	// RVA: 0xFF6398 Offset: 0xFF2398 VA: 0xFF6398
	private void ProcessConnect(SocketAsyncEventArgs e) { }

	// RVA: 0xFF6D48 Offset: 0xFF2D48 VA: 0xFF6D48
	private bool ProcessReceive(SocketAsyncEventArgs e) { }

	// RVA: 0xFF6E14 Offset: 0xFF2E14 VA: 0xFF6E14
	private bool ProcessSend(SocketAsyncEventArgs e) { }

	// RVA: 0xFF6F9C Offset: 0xFF2F9C VA: 0xFF6F9C Slot: 22
	protected virtual void OnConnecting() { }

	// RVA: 0xFF6FA0 Offset: 0xFF2FA0 VA: 0xFF6FA0 Slot: 23
	protected virtual void OnConnected() { }

	// RVA: 0xFF6FA4 Offset: 0xFF2FA4 VA: 0xFF6FA4 Slot: 24
	protected virtual void OnDisconnecting() { }

	// RVA: 0xFF6FA8 Offset: 0xFF2FA8 VA: 0xFF6FA8 Slot: 25
	protected virtual void OnDisconnected() { }

	// RVA: 0xFF6FAC Offset: 0xFF2FAC VA: 0xFF6FAC Slot: 26
	protected virtual void OnReceived(byte[] buffer, long offset, long size) { }

	// RVA: 0xFF6FB0 Offset: 0xFF2FB0 VA: 0xFF6FB0 Slot: 27
	protected virtual void OnSent(long sent, long pending) { }

	// RVA: 0xFF6FB4 Offset: 0xFF2FB4 VA: 0xFF6FB4 Slot: 28
	protected virtual void OnEmpty() { }

	// RVA: 0xFF6FB8 Offset: 0xFF2FB8 VA: 0xFF6FB8 Slot: 29
	protected virtual void OnError(SocketError error) { }

	// RVA: 0xFF5C74 Offset: 0xFF1C74 VA: 0xFF5C74
	private void SendError(SocketError error) { }

	[CompilerGenerated]
	// RVA: 0xFF6FBC Offset: 0xFF2FBC VA: 0xFF6FBC
	public bool get_IsDisposed() { }

	[CompilerGenerated]
	// RVA: 0xFF6FC4 Offset: 0xFF2FC4 VA: 0xFF6FC4
	private void set_IsDisposed(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF6FCC Offset: 0xFF2FCC VA: 0xFF6FCC
	public bool get_IsSocketDisposed() { }

	[CompilerGenerated]
	// RVA: 0xFF6FD4 Offset: 0xFF2FD4 VA: 0xFF6FD4
	private void set_IsSocketDisposed(bool value) { }

	// RVA: 0xFF6FDC Offset: 0xFF2FDC VA: 0xFF6FDC Slot: 4
	public void Dispose() { }

	// RVA: 0xFF704C Offset: 0xFF304C VA: 0xFF704C Slot: 30
	protected virtual void Dispose(bool disposingManagedResources) { }

	// RVA: 0xFF7084 Offset: 0xFF3084 VA: 0xFF7084 Slot: 1
	protected override void Finalize() { }
}

// Namespace: NetCoreServer
public class UdpClient : IDisposable // TypeDefIndex: 7942
{
	// Fields
	[CompilerGenerated]
	private readonly Guid <Id>k__BackingField; // 0x10
	[CompilerGenerated]
	private IPEndPoint <Endpoint>k__BackingField; // 0x20
	[CompilerGenerated]
	private Socket <Socket>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <BytesPending>k__BackingField; // 0x30
	[CompilerGenerated]
	private long <BytesSending>k__BackingField; // 0x38
	[CompilerGenerated]
	private long <BytesSent>k__BackingField; // 0x40
	[CompilerGenerated]
	private long <BytesReceived>k__BackingField; // 0x48
	[CompilerGenerated]
	private long <DatagramsSent>k__BackingField; // 0x50
	[CompilerGenerated]
	private long <DatagramsReceived>k__BackingField; // 0x58
	[CompilerGenerated]
	private bool <OptionDualMode>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <OptionReuseAddress>k__BackingField; // 0x61
	[CompilerGenerated]
	private bool <OptionExclusiveAddressUse>k__BackingField; // 0x62
	[CompilerGenerated]
	private bool <OptionMulticast>k__BackingField; // 0x63
	[CompilerGenerated]
	private int <OptionReceiveBufferSize>k__BackingField; // 0x64
	[CompilerGenerated]
	private int <OptionSendBufferSize>k__BackingField; // 0x68
	[CompilerGenerated]
	private bool <IsConnected>k__BackingField; // 0x6C
	private EndPoint _receiveEndpoint; // 0x70
	private EndPoint _sendEndpoint; // 0x78
	private bool _receiving; // 0x80
	private Buffer _receiveBuffer; // 0x88
	private SocketAsyncEventArgs _receiveEventArg; // 0x90
	private bool _sending; // 0x98
	private Buffer _sendBuffer; // 0xA0
	private SocketAsyncEventArgs _sendEventArg; // 0xA8
	[CompilerGenerated]
	private bool <IsDisposed>k__BackingField; // 0xB0
	[CompilerGenerated]
	private bool <IsSocketDisposed>k__BackingField; // 0xB1

	// Properties
	public Guid Id { get; }
	public IPEndPoint Endpoint { get; set; }
	public Socket Socket { get; set; }
	public long BytesPending { get; set; }
	public long BytesSending { get; set; }
	public long BytesSent { get; set; }
	public long BytesReceived { get; set; }
	public long DatagramsSent { get; set; }
	public long DatagramsReceived { get; set; }
	public bool OptionDualMode { get; set; }
	public bool OptionReuseAddress { get; set; }
	public bool OptionExclusiveAddressUse { get; set; }
	public bool OptionMulticast { get; set; }
	public int OptionReceiveBufferSize { get; set; }
	public int OptionSendBufferSize { get; set; }
	public bool IsConnected { get; set; }
	public bool IsDisposed { get; set; }
	public bool IsSocketDisposed { get; set; }

	// Methods

	// RVA: 0xFF7118 Offset: 0xFF3118 VA: 0xFF7118
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0xFF71E0 Offset: 0xFF31E0 VA: 0xFF71E0
	public void .ctor(string address, int port) { }

	// RVA: 0xFF718C Offset: 0xFF318C VA: 0xFF718C
	public void .ctor(IPEndPoint endpoint) { }

	[CompilerGenerated]
	// RVA: 0xFF728C Offset: 0xFF328C VA: 0xFF728C
	public Guid get_Id() { }

	[CompilerGenerated]
	// RVA: 0xFF7298 Offset: 0xFF3298 VA: 0xFF7298
	public IPEndPoint get_Endpoint() { }

	[CompilerGenerated]
	// RVA: 0xFF72A0 Offset: 0xFF32A0 VA: 0xFF72A0
	private void set_Endpoint(IPEndPoint value) { }

	[CompilerGenerated]
	// RVA: 0xFF72A8 Offset: 0xFF32A8 VA: 0xFF72A8
	public Socket get_Socket() { }

	[CompilerGenerated]
	// RVA: 0xFF72B0 Offset: 0xFF32B0 VA: 0xFF72B0
	private void set_Socket(Socket value) { }

	[CompilerGenerated]
	// RVA: 0xFF72B8 Offset: 0xFF32B8 VA: 0xFF72B8
	public long get_BytesPending() { }

	[CompilerGenerated]
	// RVA: 0xFF72C0 Offset: 0xFF32C0 VA: 0xFF72C0
	private void set_BytesPending(long value) { }

	[CompilerGenerated]
	// RVA: 0xFF72C8 Offset: 0xFF32C8 VA: 0xFF72C8
	public long get_BytesSending() { }

	[CompilerGenerated]
	// RVA: 0xFF72D0 Offset: 0xFF32D0 VA: 0xFF72D0
	private void set_BytesSending(long value) { }

	[CompilerGenerated]
	// RVA: 0xFF72D8 Offset: 0xFF32D8 VA: 0xFF72D8
	public long get_BytesSent() { }

	[CompilerGenerated]
	// RVA: 0xFF72E0 Offset: 0xFF32E0 VA: 0xFF72E0
	private void set_BytesSent(long value) { }

	[CompilerGenerated]
	// RVA: 0xFF72E8 Offset: 0xFF32E8 VA: 0xFF72E8
	public long get_BytesReceived() { }

	[CompilerGenerated]
	// RVA: 0xFF72F0 Offset: 0xFF32F0 VA: 0xFF72F0
	private void set_BytesReceived(long value) { }

	[CompilerGenerated]
	// RVA: 0xFF72F8 Offset: 0xFF32F8 VA: 0xFF72F8
	public long get_DatagramsSent() { }

	[CompilerGenerated]
	// RVA: 0xFF7300 Offset: 0xFF3300 VA: 0xFF7300
	private void set_DatagramsSent(long value) { }

	[CompilerGenerated]
	// RVA: 0xFF7308 Offset: 0xFF3308 VA: 0xFF7308
	public long get_DatagramsReceived() { }

	[CompilerGenerated]
	// RVA: 0xFF7310 Offset: 0xFF3310 VA: 0xFF7310
	private void set_DatagramsReceived(long value) { }

	[CompilerGenerated]
	// RVA: 0xFF7318 Offset: 0xFF3318 VA: 0xFF7318
	public bool get_OptionDualMode() { }

	[CompilerGenerated]
	// RVA: 0xFF7320 Offset: 0xFF3320 VA: 0xFF7320
	public void set_OptionDualMode(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF7328 Offset: 0xFF3328 VA: 0xFF7328
	public bool get_OptionReuseAddress() { }

	[CompilerGenerated]
	// RVA: 0xFF7330 Offset: 0xFF3330 VA: 0xFF7330
	public void set_OptionReuseAddress(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF7338 Offset: 0xFF3338 VA: 0xFF7338
	public bool get_OptionExclusiveAddressUse() { }

	[CompilerGenerated]
	// RVA: 0xFF7340 Offset: 0xFF3340 VA: 0xFF7340
	public void set_OptionExclusiveAddressUse(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF7348 Offset: 0xFF3348 VA: 0xFF7348
	public bool get_OptionMulticast() { }

	[CompilerGenerated]
	// RVA: 0xFF7350 Offset: 0xFF3350 VA: 0xFF7350
	public void set_OptionMulticast(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF7358 Offset: 0xFF3358 VA: 0xFF7358
	public int get_OptionReceiveBufferSize() { }

	[CompilerGenerated]
	// RVA: 0xFF7360 Offset: 0xFF3360 VA: 0xFF7360
	public void set_OptionReceiveBufferSize(int value) { }

	[CompilerGenerated]
	// RVA: 0xFF7368 Offset: 0xFF3368 VA: 0xFF7368
	public int get_OptionSendBufferSize() { }

	[CompilerGenerated]
	// RVA: 0xFF7370 Offset: 0xFF3370 VA: 0xFF7370
	public void set_OptionSendBufferSize(int value) { }

	[CompilerGenerated]
	// RVA: 0xFF7378 Offset: 0xFF3378 VA: 0xFF7378
	public bool get_IsConnected() { }

	[CompilerGenerated]
	// RVA: 0xFF7380 Offset: 0xFF3380 VA: 0xFF7380
	private void set_IsConnected(bool value) { }

	// RVA: 0xFF7388 Offset: 0xFF3388 VA: 0xFF7388 Slot: 5
	protected virtual Socket CreateSocket() { }

	// RVA: 0xFF740C Offset: 0xFF340C VA: 0xFF740C Slot: 6
	public virtual bool Connect() { }

	// RVA: 0xFF79C4 Offset: 0xFF39C4 VA: 0xFF79C4 Slot: 7
	public virtual bool Disconnect() { }

	// RVA: 0xFF7BD8 Offset: 0xFF3BD8 VA: 0xFF7BD8 Slot: 8
	public virtual bool Reconnect() { }

	// RVA: 0xFF7C10 Offset: 0xFF3C10 VA: 0xFF7C10 Slot: 9
	public virtual void SetupMulticast(bool enable) { }

	// RVA: 0xFF7C1C Offset: 0xFF3C1C VA: 0xFF7C1C Slot: 10
	public virtual void JoinMulticastGroup(IPAddress address) { }

	// RVA: 0xFF7D10 Offset: 0xFF3D10 VA: 0xFF7D10 Slot: 11
	public virtual void JoinMulticastGroup(string address) { }

	// RVA: 0xFF7D88 Offset: 0xFF3D88 VA: 0xFF7D88 Slot: 12
	public virtual void LeaveMulticastGroup(IPAddress address) { }

	// RVA: 0xFF7E7C Offset: 0xFF3E7C VA: 0xFF7E7C Slot: 13
	public virtual void LeaveMulticastGroup(string address) { }

	// RVA: 0xFF7EF4 Offset: 0xFF3EF4 VA: 0xFF7EF4 Slot: 14
	public virtual long Send(byte[] buffer) { }

	// RVA: 0xFF7F18 Offset: 0xFF3F18 VA: 0xFF7F18 Slot: 15
	public virtual long Send(byte[] buffer, long offset, long size) { }

	// RVA: 0xFF7F38 Offset: 0xFF3F38 VA: 0xFF7F38 Slot: 16
	public virtual long Send(string text) { }

	// RVA: 0xFF7F8C Offset: 0xFF3F8C VA: 0xFF7F8C Slot: 17
	public virtual long Send(EndPoint endpoint, byte[] buffer) { }

	// RVA: 0xFF7FB0 Offset: 0xFF3FB0 VA: 0xFF7FB0 Slot: 18
	public virtual long Send(EndPoint endpoint, byte[] buffer, long offset, long size) { }

	// RVA: 0xFF811C Offset: 0xFF411C VA: 0xFF811C Slot: 19
	public virtual long Send(EndPoint endpoint, string text) { }

	// RVA: 0xFF8178 Offset: 0xFF4178 VA: 0xFF8178 Slot: 20
	public virtual bool SendAsync(byte[] buffer) { }

	// RVA: 0xFF819C Offset: 0xFF419C VA: 0xFF819C Slot: 21
	public virtual bool SendAsync(byte[] buffer, long offset, long size) { }

	// RVA: 0xFF81BC Offset: 0xFF41BC VA: 0xFF81BC Slot: 22
	public virtual bool SendAsync(string text) { }

	// RVA: 0xFF8210 Offset: 0xFF4210 VA: 0xFF8210 Slot: 23
	public virtual bool SendAsync(EndPoint endpoint, byte[] buffer) { }

	// RVA: 0xFF8234 Offset: 0xFF4234 VA: 0xFF8234 Slot: 24
	public virtual bool SendAsync(EndPoint endpoint, byte[] buffer, long offset, long size) { }

	// RVA: 0xFF83D0 Offset: 0xFF43D0 VA: 0xFF83D0 Slot: 25
	public virtual bool SendAsync(EndPoint endpoint, string text) { }

	// RVA: 0xFF842C Offset: 0xFF442C VA: 0xFF842C Slot: 26
	public virtual long Receive(ref EndPoint endpoint, byte[] buffer) { }

	// RVA: 0xFF8450 Offset: 0xFF4450 VA: 0xFF8450 Slot: 27
	public virtual long Receive(ref EndPoint endpoint, byte[] buffer, long offset, long size) { }

	// RVA: 0xFF85D8 Offset: 0xFF45D8 VA: 0xFF85D8 Slot: 28
	public virtual string Receive(ref EndPoint endpoint, long size) { }

	// RVA: 0xFF868C Offset: 0xFF468C VA: 0xFF868C Slot: 29
	public virtual void ReceiveAsync() { }

	// RVA: 0xFF8690 Offset: 0xFF4690 VA: 0xFF8690
	private void TryReceive() { }

	// RVA: 0xFF82B4 Offset: 0xFF42B4 VA: 0xFF82B4
	private void TrySend() { }

	// RVA: 0xFF7BBC Offset: 0xFF3BBC VA: 0xFF7BBC
	private void ClearBuffers() { }

	// RVA: 0xFF8908 Offset: 0xFF4908 VA: 0xFF8908
	private void OnAsyncCompleted(object sender, SocketAsyncEventArgs e) { }

	// RVA: 0xFF87B0 Offset: 0xFF47B0 VA: 0xFF87B0
	private void ProcessReceiveFrom(SocketAsyncEventArgs e) { }

	// RVA: 0xFF887C Offset: 0xFF487C VA: 0xFF887C
	private void ProcessSendTo(SocketAsyncEventArgs e) { }

	// RVA: 0xFF8998 Offset: 0xFF4998 VA: 0xFF8998 Slot: 30
	protected virtual void OnConnecting() { }

	// RVA: 0xFF899C Offset: 0xFF499C VA: 0xFF899C Slot: 31
	protected virtual void OnConnected() { }

	// RVA: 0xFF89A0 Offset: 0xFF49A0 VA: 0xFF89A0 Slot: 32
	protected virtual void OnDisconnecting() { }

	// RVA: 0xFF89A4 Offset: 0xFF49A4 VA: 0xFF89A4 Slot: 33
	protected virtual void OnDisconnected() { }

	// RVA: 0xFF89A8 Offset: 0xFF49A8 VA: 0xFF89A8 Slot: 34
	protected virtual void OnJoinedMulticastGroup(IPAddress address) { }

	// RVA: 0xFF89AC Offset: 0xFF49AC VA: 0xFF89AC Slot: 35
	protected virtual void OnLeftMulticastGroup(IPAddress address) { }

	// RVA: 0xFF89B0 Offset: 0xFF49B0 VA: 0xFF89B0 Slot: 36
	protected virtual void OnReceived(EndPoint endpoint, byte[] buffer, long offset, long size) { }

	// RVA: 0xFF89B4 Offset: 0xFF49B4 VA: 0xFF89B4 Slot: 37
	protected virtual void OnSent(EndPoint endpoint, long sent) { }

	// RVA: 0xFF89B8 Offset: 0xFF49B8 VA: 0xFF89B8 Slot: 38
	protected virtual void OnError(SocketError error) { }

	// RVA: 0xFF7984 Offset: 0xFF3984 VA: 0xFF7984
	private void SendError(SocketError error) { }

	[CompilerGenerated]
	// RVA: 0xFF89BC Offset: 0xFF49BC VA: 0xFF89BC
	public bool get_IsDisposed() { }

	[CompilerGenerated]
	// RVA: 0xFF89C4 Offset: 0xFF49C4 VA: 0xFF89C4
	private void set_IsDisposed(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFF89CC Offset: 0xFF49CC VA: 0xFF89CC
	public bool get_IsSocketDisposed() { }

	[CompilerGenerated]
	// RVA: 0xFF89D4 Offset: 0xFF49D4 VA: 0xFF89D4
	private void set_IsSocketDisposed(bool value) { }

	// RVA: 0xFF89DC Offset: 0xFF49DC VA: 0xFF89DC Slot: 4
	public void Dispose() { }

	// RVA: 0xFF8A4C Offset: 0xFF4A4C VA: 0xFF8A4C Slot: 39
	protected virtual void Dispose(bool disposingManagedResources) { }

	// RVA: 0xFF8A84 Offset: 0xFF4A84 VA: 0xFF8A84 Slot: 1
	protected override void Finalize() { }
}

// Namespace: NetCoreServer
[IsReadOnly]
public struct BufferPointer // TypeDefIndex: 7943
{
	// Fields
	public readonly int Offset; // 0x0
	public readonly int Length; // 0x4

	// Methods

	// RVA: 0xFF8B18 Offset: 0xFF4B18 VA: 0xFF8B18
	public void .ctor(int offset, int length) { }
}

// Namespace: NetCoreServer
[Serializable]
public class ByteFileAsset // TypeDefIndex: 7944
{
	// Fields
	[SerializeField]
	private string guid; // 0x10
	[SerializeField]
	private byte[] bytes; // 0x18

	// Properties
	public string Guid { get; }
	public byte[] Bytes { get; }

	// Methods

	// RVA: 0xFF8B20 Offset: 0xFF4B20 VA: 0xFF8B20
	public string get_Guid() { }

	// RVA: 0xFF8B28 Offset: 0xFF4B28 VA: 0xFF8B28
	public byte[] get_Bytes() { }

	// RVA: 0xFF8B30 Offset: 0xFF4B30 VA: 0xFF8B30
	public void .ctor() { }
}

// Namespace: NetCoreServer
[CreateAssetMenu(menuName = "SslCertificateAsset", fileName = "SslCertificateAsset", order = 0)]
public class SslCertificateAsset : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 7945
{
	// Fields
	[SerializeField]
	private ByteFileAsset certificateBytesAsset; // 0x18
	[SerializeField]
	private string password; // 0x20
	private SslProtocols protocols; // 0x28
	private SslContext sslContext; // 0x30

	// Methods

	// RVA: 0xFF8B38 Offset: 0xFF4B38 VA: 0xFF8B38
	public SslContext GetContext() { }

	// RVA: 0xFF8CE8 Offset: 0xFF4CE8 VA: 0xFF8CE8
	private bool OnValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslpolicyerrors) { }

	// RVA: 0xFF8DB0 Offset: 0xFF4DB0 VA: 0xFF8DB0 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0xFF8DBC Offset: 0xFF4DBC VA: 0xFF8DBC Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0xFF8DC8 Offset: 0xFF4DC8 VA: 0xFF8DC8
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=240 // TypeDefIndex: 7946
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=688 // TypeDefIndex: 7947
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7948
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=240 2B44A08C3B68838421864E1360A28B4EB197EC1C6B8F52007B44A0C2E22D5762 /*Metadata offset 0x3F99D0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=688 D02EBE2DEE4B11FF7809D9AC900E019F7A994F6D1243BA52D98B686A7BB2BBBA /*Metadata offset 0x3F9AC8*/; // 0xF0
}

// Namespace: 
internal class <Module> // TypeDefIndex: 7949
{}
