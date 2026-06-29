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

// Namespace: Mono.Net.Security
internal class BufferOffsetSize // TypeDefIndex: 3780
{
	// Fields
	public byte[] Buffer; // 0x10
	public int Offset; // 0x18
	public int Size; // 0x1C
	public int TotalBytes; // 0x20
	public bool Complete; // 0x24

	// Properties
	public int EndOffset { get; }
	public int Remaining { get; }

	// Methods

	// RVA: 0x1A21ADC Offset: 0x1A1DADC VA: 0x1A21ADC
	public int get_EndOffset() { }

	// RVA: 0x1A21AE8 Offset: 0x1A1DAE8 VA: 0x1A21AE8
	public int get_Remaining() { }

	// RVA: 0x1A21B0C Offset: 0x1A1DB0C VA: 0x1A21B0C
	public void .ctor(byte[] buffer, int offset, int size) { }

	// RVA: 0x1A21C10 Offset: 0x1A1DC10 VA: 0x1A21C10 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Net.Security
internal class BufferOffsetSize2 : BufferOffsetSize // TypeDefIndex: 3781
{
	// Fields
	public readonly int InitialSize; // 0x28

	// Methods

	// RVA: 0x1A21CA4 Offset: 0x1A1DCA4 VA: 0x1A21CA4
	public void .ctor(int size) { }

	// RVA: 0x1A21D14 Offset: 0x1A1DD14 VA: 0x1A21D14
	public void Reset() { }

	// RVA: 0x1A21D7C Offset: 0x1A1DD7C VA: 0x1A21D7C
	public void MakeRoom(int size) { }

	// RVA: 0x1A21E48 Offset: 0x1A1DE48 VA: 0x1A21E48
	public void AppendData(byte[] buffer, int offset, int size) { }
}

// Namespace: Mono.Net.Security
internal enum AsyncOperationStatus // TypeDefIndex: 3782
{
	// Fields
	public int value__; // 0x0
	public const AsyncOperationStatus Initialize = 0;
	public const AsyncOperationStatus Continue = 1;
	public const AsyncOperationStatus ReadDone = 2;
	public const AsyncOperationStatus Complete = 3;
}

// Namespace: Mono.Net.Security
internal class AsyncProtocolResult // TypeDefIndex: 3783
{
	// Fields
	[CompilerGenerated]
	private readonly int <UserResult>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly ExceptionDispatchInfo <Error>k__BackingField; // 0x18

	// Properties
	public int UserResult { get; }
	public ExceptionDispatchInfo Error { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A21EA8 Offset: 0x1A1DEA8 VA: 0x1A21EA8
	public int get_UserResult() { }

	[CompilerGenerated]
	// RVA: 0x1A21EB0 Offset: 0x1A1DEB0 VA: 0x1A21EB0
	public ExceptionDispatchInfo get_Error() { }

	// RVA: 0x1A21EB8 Offset: 0x1A1DEB8 VA: 0x1A21EB8
	public void .ctor(int result) { }

	// RVA: 0x1A21EE0 Offset: 0x1A1DEE0 VA: 0x1A21EE0
	public void .ctor(ExceptionDispatchInfo error) { }
}

// Namespace: 
[CompilerGenerated]
private struct AsyncProtocolRequest.<StartOperation>d__23 : IAsyncStateMachine // TypeDefIndex: 3784
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<AsyncProtocolResult> <>t__builder; // 0x8
	public AsyncProtocolRequest <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1A22470 Offset: 0x1A1E470 VA: 0x1A22470 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1A22864 Offset: 0x1A1E864 VA: 0x1A22864 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct AsyncProtocolRequest.<ProcessOperation>d__24 : IAsyncStateMachine // TypeDefIndex: 3785
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public AsyncProtocolRequest <>4__this; // 0x28
	private AsyncOperationStatus <status>5__2; // 0x30
	private AsyncOperationStatus <newStatus>5__3; // 0x34
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Nullable<int>> <>u__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x48

	// Methods

	// RVA: 0x1A228E0 Offset: 0x1A1E8E0 VA: 0x1A228E0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1A23104 Offset: 0x1A1F104 VA: 0x1A23104 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct AsyncProtocolRequest.<InnerRead>d__25 : IAsyncStateMachine // TypeDefIndex: 3786
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Nullable<int>> <>t__builder; // 0x8
	public AsyncProtocolRequest <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private Nullable<int> <totalRead>5__2; // 0x30
	private int <requestedSize>5__3; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x40

	// Methods

	// RVA: 0x1A2316C Offset: 0x1A1F16C VA: 0x1A2316C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1A23688 Offset: 0x1A1F688 VA: 0x1A23688 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Mono.Net.Security
internal abstract class AsyncProtocolRequest // TypeDefIndex: 3787
{
	// Fields
	[CompilerGenerated]
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly bool <RunSynchronously>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <UserResult>k__BackingField; // 0x1C
	private int Started; // 0x20
	private int RequestedSize; // 0x24
	private int WriteRequested; // 0x28
	private readonly object locker; // 0x30

	// Properties
	public MobileAuthenticatedStream Parent { get; }
	public bool RunSynchronously { get; }
	public string Name { get; }
	public int UserResult { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A21F10 Offset: 0x1A1DF10 VA: 0x1A21F10
	public MobileAuthenticatedStream get_Parent() { }

	[CompilerGenerated]
	// RVA: 0x1A21F18 Offset: 0x1A1DF18 VA: 0x1A21F18
	public bool get_RunSynchronously() { }

	// RVA: 0x1A21F20 Offset: 0x1A1DF20 VA: 0x1A21F20
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x1A21F44 Offset: 0x1A1DF44 VA: 0x1A21F44
	public int get_UserResult() { }

	[CompilerGenerated]
	// RVA: 0x1A21F4C Offset: 0x1A1DF4C VA: 0x1A21F4C
	protected void set_UserResult(int value) { }

	// RVA: 0x1A21F54 Offset: 0x1A1DF54 VA: 0x1A21F54
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x1A21FEC Offset: 0x1A1DFEC VA: 0x1A21FEC
	internal void RequestRead(int size) { }

	// RVA: 0x1A220B4 Offset: 0x1A1E0B4 VA: 0x1A220B4
	internal void RequestWrite() { }

	[AsyncStateMachine(typeof(AsyncProtocolRequest.<StartOperation>d__23))]
	// RVA: 0x1A220C0 Offset: 0x1A1E0C0 VA: 0x1A220C0
	internal Task<AsyncProtocolResult> StartOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(AsyncProtocolRequest.<ProcessOperation>d__24))]
	// RVA: 0x1A221EC Offset: 0x1A1E1EC VA: 0x1A221EC
	private Task ProcessOperation(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(AsyncProtocolRequest.<InnerRead>d__25))]
	// RVA: 0x1A222E8 Offset: 0x1A1E2E8 VA: 0x1A222E8
	private Task<Nullable<int>> InnerRead(CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract AsyncOperationStatus Run(AsyncOperationStatus status);

	// RVA: 0x1A22418 Offset: 0x1A1E418 VA: 0x1A22418 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Net.Security
internal class AsyncHandshakeRequest : AsyncProtocolRequest // TypeDefIndex: 3788
{
	// Methods

	// RVA: 0x1A23704 Offset: 0x1A1F704 VA: 0x1A23704
	public void .ctor(MobileAuthenticatedStream parent, bool sync) { }

	// RVA: 0x1A23708 Offset: 0x1A1F708 VA: 0x1A23708 Slot: 4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }
}

// Namespace: Mono.Net.Security
internal abstract class AsyncReadOrWriteRequest : AsyncProtocolRequest // TypeDefIndex: 3789
{
	// Fields
	[CompilerGenerated]
	private readonly BufferOffsetSize <UserBuffer>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <CurrentSize>k__BackingField; // 0x40

	// Properties
	protected BufferOffsetSize UserBuffer { get; }
	protected int CurrentSize { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A23AB8 Offset: 0x1A1FAB8 VA: 0x1A23AB8
	protected BufferOffsetSize get_UserBuffer() { }

	[CompilerGenerated]
	// RVA: 0x1A23AC0 Offset: 0x1A1FAC0 VA: 0x1A23AC0
	protected int get_CurrentSize() { }

	[CompilerGenerated]
	// RVA: 0x1A23AC8 Offset: 0x1A1FAC8 VA: 0x1A23AC8
	protected void set_CurrentSize(int value) { }

	// RVA: 0x1A23AD0 Offset: 0x1A1FAD0 VA: 0x1A23AD0
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x1A23B74 Offset: 0x1A1FB74 VA: 0x1A23B74 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Net.Security
internal class AsyncReadRequest : AsyncReadOrWriteRequest // TypeDefIndex: 3790
{
	// Methods

	// RVA: 0x1A23BD0 Offset: 0x1A1FBD0 VA: 0x1A23BD0
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x1A23BD4 Offset: 0x1A1FBD4 VA: 0x1A23BD4 Slot: 4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }
}

// Namespace: Mono.Net.Security
internal class AsyncWriteRequest : AsyncReadOrWriteRequest // TypeDefIndex: 3791
{
	// Methods

	// RVA: 0x1A23D8C Offset: 0x1A1FD8C VA: 0x1A23D8C
	public void .ctor(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size) { }

	// RVA: 0x1A23D90 Offset: 0x1A1FD90 VA: 0x1A23D90 Slot: 4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }
}

// Namespace: Mono.Net.Security
internal class AsyncShutdownRequest : AsyncProtocolRequest // TypeDefIndex: 3792
{
	// Methods

	// RVA: 0x1A23F58 Offset: 0x1A1FF58 VA: 0x1A23F58
	public void .ctor(MobileAuthenticatedStream parent) { }

	// RVA: 0x1A23F60 Offset: 0x1A1FF60 VA: 0x1A23F60 Slot: 4
	protected override AsyncOperationStatus Run(AsyncOperationStatus status) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ChainValidationHelper.<>c__DisplayClass11_0 // TypeDefIndex: 3793
{
	// Fields
	public MonoTlsSettings settings; // 0x10

	// Methods

	// RVA: 0x1A247DC Offset: 0x1A207DC VA: 0x1A247DC
	public void .ctor() { }

	// RVA: 0x1A24F00 Offset: 0x1A20F00 VA: 0x1A24F00
	internal bool <GetValidationCallback>b__0(object s, X509Certificate c, X509Chain ch, SslPolicyErrors e) { }
}

// Namespace: Mono.Net.Security
internal class ChainValidationHelper : ICertificateValidator // TypeDefIndex: 3794
{
	// Fields
	private readonly WeakReference<SslStream> owner; // 0x10
	private readonly MonoTlsSettings settings; // 0x18
	private readonly MobileTlsProvider provider; // 0x20
	private readonly ServerCertValidationCallback certValidationCallback; // 0x28
	private readonly LocalCertSelectionCallback certSelectionCallback; // 0x30
	private readonly MonoTlsStream tlsStream; // 0x38
	private readonly HttpWebRequest request; // 0x40

	// Properties
	public MonoTlsSettings Settings { get; }

	// Methods

	// RVA: 0x1A2409C Offset: 0x1A2009C VA: 0x1A2409C
	internal static ChainValidationHelper GetInternalValidator(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings) { }

	// RVA: 0x1A2445C Offset: 0x1A2045C VA: 0x1A2445C
	internal static ChainValidationHelper Create(MobileTlsProvider provider, ref MonoTlsSettings settings, MonoTlsStream stream) { }

	// RVA: 0x1A24170 Offset: 0x1A20170 VA: 0x1A24170
	private void .ctor(SslStream owner, MobileTlsProvider provider, MonoTlsSettings settings, bool cloneSettings, MonoTlsStream stream) { }

	// RVA: 0x1A24610 Offset: 0x1A20610 VA: 0x1A24610
	private static ServerCertValidationCallback GetValidationCallback(MonoTlsSettings settings) { }

	// RVA: 0x1A247E4 Offset: 0x1A207E4 VA: 0x1A247E4
	private static X509Certificate DefaultSelectionCallback(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers) { }

	// RVA: 0x1A24820 Offset: 0x1A20820 VA: 0x1A24820 Slot: 4
	public MonoTlsSettings get_Settings() { }

	// RVA: 0x1A24828 Offset: 0x1A20828 VA: 0x1A24828 Slot: 5
	public bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate) { }

	// RVA: 0x1A2487C Offset: 0x1A2087C VA: 0x1A2487C
	public ValidationResult ValidateCertificate(string host, bool serverMode, X509Certificate leaf, X509Chain chain) { }

	// RVA: 0x1A24954 Offset: 0x1A20954 VA: 0x1A24954
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0x1A24A30 Offset: 0x1A20A30 VA: 0x1A24A30
	private ValidationResult ValidateChain(string host, bool server, X509Certificate leaf, ref X509Chain chain, X509CertificateCollection certs, SslPolicyErrors errors) { }

	// RVA: 0x1A24E44 Offset: 0x1A20E44 VA: 0x1A24E44
	private bool InvokeCallback(X509Certificate leaf, X509Chain chain, SslPolicyErrors errors) { }
}

// Namespace: 
private enum MobileAuthenticatedStream.Operation // TypeDefIndex: 3795
{
	// Fields
	public int value__; // 0x0
	public const MobileAuthenticatedStream.Operation None = 0;
	public const MobileAuthenticatedStream.Operation Handshake = 1;
	public const MobileAuthenticatedStream.Operation Authenticated = 2;
	public const MobileAuthenticatedStream.Operation Renegotiate = 3;
	public const MobileAuthenticatedStream.Operation Read = 4;
	public const MobileAuthenticatedStream.Operation Write = 5;
	public const MobileAuthenticatedStream.Operation Close = 6;
}

// Namespace: 
private enum MobileAuthenticatedStream.OperationType // TypeDefIndex: 3796
{
	// Fields
	public int value__; // 0x0
	public const MobileAuthenticatedStream.OperationType Read = 0;
	public const MobileAuthenticatedStream.OperationType Write = 1;
	public const MobileAuthenticatedStream.OperationType Renegotiate = 2;
	public const MobileAuthenticatedStream.OperationType Shutdown = 3;
}

// Namespace: 
[CompilerGenerated]
private struct MobileAuthenticatedStream.<ProcessAuthentication>d__48 : IAsyncStateMachine // TypeDefIndex: 3797
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public MonoSslAuthenticationOptions options; // 0x20
	public MobileAuthenticatedStream <>4__this; // 0x28
	public bool runSynchronously; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult> <>u__1; // 0x40

	// Methods

	// RVA: 0x1A266C8 Offset: 0x1A226C8 VA: 0x1A266C8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1A27020 Offset: 0x1A23020 VA: 0x1A27020 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct MobileAuthenticatedStream.<StartOperation>d__57 : IAsyncStateMachine // TypeDefIndex: 3798
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public MobileAuthenticatedStream <>4__this; // 0x20
	public MobileAuthenticatedStream.OperationType type; // 0x28
	public AsyncProtocolRequest asyncRequest; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<AsyncProtocolResult> <>u__1; // 0x40

	// Methods

	// RVA: 0x1A27088 Offset: 0x1A23088 VA: 0x1A27088 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1A2783C Offset: 0x1A2383C VA: 0x1A2783C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MobileAuthenticatedStream.<>c__DisplayClass66_0 // TypeDefIndex: 3799
{
	// Fields
	public MobileAuthenticatedStream <>4__this; // 0x10
	public int len; // 0x18

	// Methods

	// RVA: 0x1A278B8 Offset: 0x1A238B8 VA: 0x1A278B8
	public void .ctor() { }

	// RVA: 0x1A278C0 Offset: 0x1A238C0 VA: 0x1A278C0
	internal int <InnerRead>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private struct MobileAuthenticatedStream.<InnerRead>d__66 : IAsyncStateMachine // TypeDefIndex: 3800
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public MobileAuthenticatedStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public int requestedSize; // 0x30
	public bool sync; // 0x34
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x38

	// Methods

	// RVA: 0x1A27908 Offset: 0x1A23908 VA: 0x1A27908 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1A27DE0 Offset: 0x1A23DE0 VA: 0x1A27DE0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct MobileAuthenticatedStream.<InnerWrite>d__67 : IAsyncStateMachine // TypeDefIndex: 3801
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public MobileAuthenticatedStream <>4__this; // 0x28
	public bool sync; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x1A27E5C Offset: 0x1A23E5C VA: 0x1A27E5C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1A28184 Offset: 0x1A24184 VA: 0x1A28184 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Mono.Net.Security
internal abstract class MobileAuthenticatedStream : AuthenticatedStream, IDisposable // TypeDefIndex: 3802
{
	// Fields
	private MobileTlsContext xobileTlsContext; // 0x38
	private ExceptionDispatchInfo lastException; // 0x40
	private AsyncProtocolRequest asyncHandshakeRequest; // 0x48
	private AsyncProtocolRequest asyncReadRequest; // 0x50
	private AsyncProtocolRequest asyncWriteRequest; // 0x58
	private BufferOffsetSize2 readBuffer; // 0x60
	private BufferOffsetSize2 writeBuffer; // 0x68
	private object ioLock; // 0x70
	private int closeRequested; // 0x78
	private bool shutdown; // 0x7C
	private MobileAuthenticatedStream.Operation operation; // 0x80
	private static int uniqueNameInteger; // 0x0
	[CompilerGenerated]
	private readonly SslStream <SslStream>k__BackingField; // 0x88
	[CompilerGenerated]
	private readonly MonoTlsSettings <Settings>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly MobileTlsProvider <Provider>k__BackingField; // 0x98
	[CompilerGenerated]
	private string <TargetHost>k__BackingField; // 0xA0
	private static int nextId; // 0x4
	internal readonly int ID; // 0xA8

	// Properties
	public SslStream SslStream { get; }
	public MonoTlsSettings Settings { get; }
	public MobileTlsProvider Provider { get; }
	internal string TargetHost { get; set; }
	public override bool IsAuthenticated { get; }
	public X509Certificate LocalCertificate { get; }
	public X509Certificate InternalLocalCertificate { get; }
	public override bool CanRead { get; }
	public override bool CanTimeout { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x1A213EC Offset: 0x1A1D3EC VA: 0x1A213EC
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	[CompilerGenerated]
	// RVA: 0x1A25060 Offset: 0x1A21060 VA: 0x1A25060 Slot: 39
	public SslStream get_SslStream() { }

	[CompilerGenerated]
	// RVA: 0x1A25068 Offset: 0x1A21068 VA: 0x1A25068
	public MonoTlsSettings get_Settings() { }

	[CompilerGenerated]
	// RVA: 0x1A25070 Offset: 0x1A21070 VA: 0x1A25070
	public MobileTlsProvider get_Provider() { }

	[CompilerGenerated]
	// RVA: 0x1A25078 Offset: 0x1A21078 VA: 0x1A25078
	internal string get_TargetHost() { }

	[CompilerGenerated]
	// RVA: 0x1A25080 Offset: 0x1A21080 VA: 0x1A25080
	private void set_TargetHost(string value) { }

	// RVA: 0x1A25088 Offset: 0x1A21088 VA: 0x1A25088
	internal void CheckThrow(bool authSuccessCheck, bool shutdownCheck = False) { }

	// RVA: 0x1A22E64 Offset: 0x1A1EE64 VA: 0x1A22E64
	internal static Exception GetSSPIException(Exception e) { }

	// RVA: 0x1A25148 Offset: 0x1A21148 VA: 0x1A25148
	internal static Exception GetIOException(Exception e, string message) { }

	// RVA: 0x1A252C4 Offset: 0x1A212C4 VA: 0x1A252C4
	internal static Exception GetInternalError() { }

	// RVA: 0x1A25310 Offset: 0x1A21310 VA: 0x1A25310
	internal static Exception GetInvalidNestedCallException() { }

	// RVA: 0x1A22824 Offset: 0x1A1E824 VA: 0x1A22824
	internal ExceptionDispatchInfo SetException(Exception e) { }

	// RVA: 0x1A2535C Offset: 0x1A2135C VA: 0x1A2535C
	public void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x1A256C0 Offset: 0x1A216C0 VA: 0x1A256C0 Slot: 40
	public Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation) { }

	// RVA: 0x1A257DC Offset: 0x1A217DC VA: 0x1A257DC Slot: 41
	public Task ShutdownAsync() { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<ProcessAuthentication>d__48))]
	// RVA: 0x1A255A0 Offset: 0x1A215A0 VA: 0x1A255A0
	private Task ProcessAuthentication(bool runSynchronously, MonoSslAuthenticationOptions options, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 42
	protected abstract MobileTlsContext CreateContext(MonoSslAuthenticationOptions options);

	// RVA: 0x1A259CC Offset: 0x1A219CC VA: 0x1A259CC Slot: 32
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1A25AAC Offset: 0x1A21AAC VA: 0x1A25AAC Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1A25B78 Offset: 0x1A21B78 VA: 0x1A25B78 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1A25C0C Offset: 0x1A21C0C VA: 0x1A25C0C Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<StartOperation>d__57))]
	// RVA: 0x1A25878 Offset: 0x1A21878 VA: 0x1A25878
	private Task<int> StartOperation(MobileAuthenticatedStream.OperationType type, AsyncProtocolRequest asyncRequest, CancellationToken cancellationToken) { }

	// RVA: 0x1A1FA40 Offset: 0x1A1BA40 VA: 0x1A1FA40
	internal int InternalRead(byte[] buffer, int offset, int size, out bool outWantMore) { }

	// RVA: 0x1A25CA0 Offset: 0x1A21CA0 VA: 0x1A25CA0
	private ValueTuple<int, bool> InternalRead(AsyncProtocolRequest asyncRequest, BufferOffsetSize internalBuffer, byte[] buffer, int offset, int size) { }

	// RVA: 0x1A1F558 Offset: 0x1A1B558 VA: 0x1A1F558
	internal bool InternalWrite(byte[] buffer, int offset, int size) { }

	// RVA: 0x1A25E10 Offset: 0x1A21E10 VA: 0x1A25E10
	private bool InternalWrite(AsyncProtocolRequest asyncRequest, BufferOffsetSize2 internalBuffer, byte[] buffer, int offset, int size) { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<InnerRead>d__66))]
	// RVA: 0x1A23540 Offset: 0x1A1F540 VA: 0x1A23540
	internal Task<int> InnerRead(bool sync, int requestedSize, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(MobileAuthenticatedStream.<InnerWrite>d__67))]
	// RVA: 0x1A22FF8 Offset: 0x1A1EFF8 VA: 0x1A22FF8
	internal Task InnerWrite(bool sync, CancellationToken cancellationToken) { }

	// RVA: 0x1A23720 Offset: 0x1A1F720 VA: 0x1A23720
	internal AsyncOperationStatus ProcessHandshake(AsyncOperationStatus status, bool renegotiate) { }

	// RVA: 0x1A23C3C Offset: 0x1A1FC3C VA: 0x1A23C3C
	internal ValueTuple<int, bool> ProcessRead(BufferOffsetSize userBuffer) { }

	// RVA: 0x1A23E08 Offset: 0x1A1FE08 VA: 0x1A23E08
	internal ValueTuple<int, bool> ProcessWrite(BufferOffsetSize userBuffer) { }

	// RVA: 0x1A23F74 Offset: 0x1A1FF74 VA: 0x1A23F74
	internal AsyncOperationStatus ProcessShutdown(AsyncOperationStatus status) { }

	// RVA: 0x1A25F08 Offset: 0x1A21F08 VA: 0x1A25F08 Slot: 38
	public override bool get_IsAuthenticated() { }

	// RVA: 0x1A25FF4 Offset: 0x1A21FF4 VA: 0x1A25FF4 Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1A26234 Offset: 0x1A22234 VA: 0x1A26234 Slot: 21
	public override void Flush() { }

	// RVA: 0x1A26254 Offset: 0x1A22254 VA: 0x1A26254 Slot: 43
	public X509Certificate get_LocalCertificate() { }

	// RVA: 0x1A26330 Offset: 0x1A22330 VA: 0x1A26330 Slot: 44
	public X509Certificate get_InternalLocalCertificate() { }

	// RVA: 0x1A26434 Offset: 0x1A22434 VA: 0x1A26434 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1A2646C Offset: 0x1A2246C VA: 0x1A2646C Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1A2648C Offset: 0x1A2248C VA: 0x1A2648C Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1A264D0 Offset: 0x1A224D0 VA: 0x1A264D0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1A264EC Offset: 0x1A224EC VA: 0x1A264EC Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1A26550 Offset: 0x1A22550 VA: 0x1A26550 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1A26558 Offset: 0x1A22558 VA: 0x1A26558 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1A26574 Offset: 0x1A22574 VA: 0x1A26574 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1A26590 Offset: 0x1A22590 VA: 0x1A26590 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1A265C8 Offset: 0x1A225C8 VA: 0x1A265C8 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1A265E8 Offset: 0x1A225E8 VA: 0x1A265E8 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1A26608 Offset: 0x1A22608 VA: 0x1A26608 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1A26628 Offset: 0x1A22628 VA: 0x1A26628 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1A26648 Offset: 0x1A22648 VA: 0x1A26648
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1A26694 Offset: 0x1A22694 VA: 0x1A26694
	private void <InnerWrite>b__67_0() { }
}

// Namespace: Mono.Net.Security
internal abstract class MobileTlsContext : IDisposable // TypeDefIndex: 3803
{
	// Fields
	private ChainValidationHelper certificateValidator; // 0x10
	[CompilerGenerated]
	private readonly MonoSslAuthenticationOptions <Options>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly MobileAuthenticatedStream <Parent>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly bool <IsServer>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <TargetHost>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly string <ServerName>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly bool <AskForClientCertificate>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly SslProtocols <EnabledProtocols>k__BackingField; // 0x44
	[CompilerGenerated]
	private readonly X509CertificateCollection <ClientCertificates>k__BackingField; // 0x48
	[CompilerGenerated]
	private X509Certificate <LocalServerCertificate>k__BackingField; // 0x50

	// Properties
	internal MobileAuthenticatedStream Parent { get; }
	public MonoTlsSettings Settings { get; }
	public abstract bool IsAuthenticated { get; }
	public bool IsServer { get; }
	internal string TargetHost { get; }
	protected string ServerName { get; }
	protected bool AskForClientCertificate { get; }
	protected X509CertificateCollection ClientCertificates { get; }
	internal X509Certificate LocalServerCertificate { get; set; }
	internal abstract X509Certificate LocalClientCertificate { get; }
	public abstract X509Certificate2 RemoteCertificate { get; }

	// Methods

	// RVA: 0x1A1E308 Offset: 0x1A1A308 VA: 0x1A1E308
	protected void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	[CompilerGenerated]
	// RVA: 0x1A281EC Offset: 0x1A241EC VA: 0x1A281EC
	internal MobileAuthenticatedStream get_Parent() { }

	// RVA: 0x1A1ED18 Offset: 0x1A1AD18 VA: 0x1A1ED18
	public MonoTlsSettings get_Settings() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool get_IsAuthenticated();

	[CompilerGenerated]
	// RVA: 0x1A281F4 Offset: 0x1A241F4 VA: 0x1A281F4
	public bool get_IsServer() { }

	[CompilerGenerated]
	// RVA: 0x1A281FC Offset: 0x1A241FC VA: 0x1A281FC
	internal string get_TargetHost() { }

	[CompilerGenerated]
	// RVA: 0x1A28204 Offset: 0x1A24204 VA: 0x1A28204
	protected string get_ServerName() { }

	[CompilerGenerated]
	// RVA: 0x1A2820C Offset: 0x1A2420C VA: 0x1A2820C
	protected bool get_AskForClientCertificate() { }

	[CompilerGenerated]
	// RVA: 0x1A28214 Offset: 0x1A24214 VA: 0x1A28214
	protected X509CertificateCollection get_ClientCertificates() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void StartHandshake();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool ProcessHandshake();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void FinishHandshake();

	[CompilerGenerated]
	// RVA: 0x1A2821C Offset: 0x1A2421C VA: 0x1A2821C
	internal X509Certificate get_LocalServerCertificate() { }

	[CompilerGenerated]
	// RVA: 0x1A28224 Offset: 0x1A24224 VA: 0x1A28224
	private void set_LocalServerCertificate(X509Certificate value) { }

	// RVA: -1 Offset: -1 Slot: 9
	internal abstract X509Certificate get_LocalClientCertificate();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract X509Certificate2 get_RemoteCertificate();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract ValueTuple<int, bool> Read(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract ValueTuple<int, bool> Write(byte[] buffer, int offset, int count);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void Shutdown();

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool PendingRenegotiation();

	// RVA: 0x1A1F130 Offset: 0x1A1B130 VA: 0x1A1F130
	protected bool ValidateCertificate(X509Certificate2 leaf, X509Chain chain) { }

	// RVA: 0x1A20240 Offset: 0x1A1C240 VA: 0x1A20240
	protected X509Certificate SelectClientCertificate(string[] acceptableIssuers) { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract void Renegotiate();

	// RVA: 0x1A261C4 Offset: 0x1A221C4 VA: 0x1A261C4 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A2822C Offset: 0x1A2422C VA: 0x1A2822C Slot: 16
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1A28230 Offset: 0x1A24230 VA: 0x1A28230 Slot: 1
	protected override void Finalize() { }
}

// Namespace: Mono.Net.Security
internal abstract class MobileTlsProvider : MonoTlsProvider // TypeDefIndex: 3804
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	internal abstract MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings);

	// RVA: -1 Offset: -1 Slot: 12
	internal abstract bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11);

	// RVA: 0x1A213E4 Offset: 0x1A1D3E4 VA: 0x1A213E4
	protected void .ctor() { }
}

// Namespace: Mono.Net.Security
internal abstract class MonoSslAuthenticationOptions // TypeDefIndex: 3805
{
	// Fields
	[CompilerGenerated]
	private ServerCertSelectionCallback <ServerCertSelectionDelegate>k__BackingField; // 0x10

	// Properties
	public abstract bool ServerMode { get; }
	public abstract SslProtocols EnabledSslProtocols { get; set; }
	public abstract EncryptionPolicy EncryptionPolicy { set; }
	public abstract X509RevocationMode CertificateRevocationCheckMode { set; }
	public abstract string TargetHost { get; set; }
	public abstract X509Certificate ServerCertificate { get; }
	public abstract X509CertificateCollection ClientCertificates { get; set; }
	public abstract bool ClientCertificateRequired { get; }
	internal ServerCertSelectionCallback ServerCertSelectionDelegate { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_ServerMode();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract SslProtocols get_EnabledSslProtocols();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void set_EnabledSslProtocols(SslProtocols value);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_EncryptionPolicy(EncryptionPolicy value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void set_CertificateRevocationCheckMode(X509RevocationMode value);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_TargetHost();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void set_TargetHost(string value);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract X509Certificate get_ServerCertificate();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract X509CertificateCollection get_ClientCertificates();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_ClientCertificates(X509CertificateCollection value);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract bool get_ClientCertificateRequired();

	[CompilerGenerated]
	// RVA: 0x1A282C4 Offset: 0x1A242C4 VA: 0x1A282C4
	internal ServerCertSelectionCallback get_ServerCertSelectionDelegate() { }

	// RVA: 0x1A282CC Offset: 0x1A242CC VA: 0x1A282CC
	protected void .ctor() { }
}

// Namespace: Mono.Net.Security
internal sealed class MonoSslClientAuthenticationOptions : MonoSslAuthenticationOptions // TypeDefIndex: 3806
{
	// Fields
	[CompilerGenerated]
	private readonly SslClientAuthenticationOptions <Options>k__BackingField; // 0x18

	// Properties
	public SslClientAuthenticationOptions Options { get; }
	public override bool ServerMode { get; }
	public override X509RevocationMode CertificateRevocationCheckMode { set; }
	public override EncryptionPolicy EncryptionPolicy { set; }
	public override SslProtocols EnabledSslProtocols { get; set; }
	public override string TargetHost { get; set; }
	public override bool ClientCertificateRequired { get; }
	public override X509CertificateCollection ClientCertificates { get; set; }
	public override X509Certificate ServerCertificate { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1A282D4 Offset: 0x1A242D4 VA: 0x1A282D4
	public SslClientAuthenticationOptions get_Options() { }

	// RVA: 0x1A282DC Offset: 0x1A242DC VA: 0x1A282DC Slot: 4
	public override bool get_ServerMode() { }

	// RVA: 0x1A25534 Offset: 0x1A21534 VA: 0x1A25534
	public void .ctor() { }

	// RVA: 0x1A282E4 Offset: 0x1A242E4 VA: 0x1A282E4 Slot: 8
	public override void set_CertificateRevocationCheckMode(X509RevocationMode value) { }

	// RVA: 0x1A282FC Offset: 0x1A242FC VA: 0x1A282FC Slot: 7
	public override void set_EncryptionPolicy(EncryptionPolicy value) { }

	// RVA: 0x1A28314 Offset: 0x1A24314 VA: 0x1A28314 Slot: 5
	public override SslProtocols get_EnabledSslProtocols() { }

	// RVA: 0x1A2832C Offset: 0x1A2432C VA: 0x1A2832C Slot: 6
	public override void set_EnabledSslProtocols(SslProtocols value) { }

	// RVA: 0x1A28344 Offset: 0x1A24344 VA: 0x1A28344 Slot: 9
	public override string get_TargetHost() { }

	// RVA: 0x1A2835C Offset: 0x1A2435C VA: 0x1A2835C Slot: 10
	public override void set_TargetHost(string value) { }

	// RVA: 0x1A28374 Offset: 0x1A24374 VA: 0x1A28374 Slot: 14
	public override bool get_ClientCertificateRequired() { }

	// RVA: 0x1A283AC Offset: 0x1A243AC VA: 0x1A283AC Slot: 12
	public override X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1A283C4 Offset: 0x1A243C4 VA: 0x1A283C4 Slot: 13
	public override void set_ClientCertificates(X509CertificateCollection value) { }

	// RVA: 0x1A283DC Offset: 0x1A243DC VA: 0x1A283DC Slot: 11
	public override X509Certificate get_ServerCertificate() { }
}

// Namespace: Mono.Net.Security
internal static class MonoTlsProviderFactory // TypeDefIndex: 3807
{
	// Fields
	private static object locker; // 0x0
	private static bool initialized; // 0x8
	private static MobileTlsProvider defaultProvider; // 0x10
	private static Dictionary<string, Tuple<Guid, string>> providerRegistration; // 0x18
	private static Dictionary<Guid, MobileTlsProvider> providerCache; // 0x20
	internal static readonly Guid UnityTlsId; // 0x28
	internal static readonly Guid AppleTlsId; // 0x38
	internal static readonly Guid BtlsId; // 0x48

	// Methods

	// RVA: 0x1A244F0 Offset: 0x1A204F0 VA: 0x1A244F0
	internal static MobileTlsProvider GetProviderInternal() { }

	// RVA: 0x1A28414 Offset: 0x1A24414 VA: 0x1A28414
	internal static void InitializeInternal() { }

	// RVA: 0x1A28B70 Offset: 0x1A24B70 VA: 0x1A28B70
	private static MobileTlsProvider LookupProvider(string name, bool throwOnError) { }

	// RVA: 0x1A287E0 Offset: 0x1A247E0 VA: 0x1A287E0
	private static void InitializeProviderRegistration() { }

	// RVA: 0x1A290EC Offset: 0x1A250EC VA: 0x1A290EC
	private static void PopulateUnityProviders() { }

	// RVA: 0x1A2922C Offset: 0x1A2522C VA: 0x1A2922C
	private static void PopulateProviders() { }

	// RVA: 0x1A289E8 Offset: 0x1A249E8 VA: 0x1A289E8
	private static MobileTlsProvider CreateDefaultProviderImpl() { }

	// RVA: 0x1A2927C Offset: 0x1A2527C VA: 0x1A2927C
	internal static MobileTlsProvider GetProvider() { }

	// RVA: 0x1A292C8 Offset: 0x1A252C8 VA: 0x1A292C8
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct MonoTlsStream.<CreateStream>d__18 : IAsyncStateMachine // TypeDefIndex: 3808
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<Stream> <>t__builder; // 0x8
	public MonoTlsStream <>4__this; // 0x20
	public WebConnectionTunnel tunnel; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private Socket <socket>5__2; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x1A29878 Offset: 0x1A25878 VA: 0x1A29878 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1A2A018 Offset: 0x1A26018 VA: 0x1A2A018 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: Mono.Net.Security
internal class MonoTlsStream : IDisposable // TypeDefIndex: 3809
{
	// Fields
	private readonly MobileTlsProvider provider; // 0x10
	private readonly NetworkStream networkStream; // 0x18
	private readonly HttpWebRequest request; // 0x20
	private readonly MonoTlsSettings settings; // 0x28
	private SslStream sslStream; // 0x30
	private readonly object sslStreamLock; // 0x38
	private WebExceptionStatus status; // 0x40
	[CompilerGenerated]
	private bool <CertificateValidationFailed>k__BackingField; // 0x44

	// Properties
	internal HttpWebRequest Request { get; }
	internal WebExceptionStatus ExceptionStatus { get; }
	internal bool CertificateValidationFailed { get; set; }

	// Methods

	// RVA: 0x1A29408 Offset: 0x1A25408 VA: 0x1A29408
	internal HttpWebRequest get_Request() { }

	// RVA: 0x1A29410 Offset: 0x1A25410 VA: 0x1A29410
	internal WebExceptionStatus get_ExceptionStatus() { }

	[CompilerGenerated]
	// RVA: 0x1A29418 Offset: 0x1A25418 VA: 0x1A29418
	internal bool get_CertificateValidationFailed() { }

	[CompilerGenerated]
	// RVA: 0x1A29420 Offset: 0x1A25420 VA: 0x1A29420
	internal void set_CertificateValidationFailed(bool value) { }

	// RVA: 0x1A29428 Offset: 0x1A25428 VA: 0x1A29428
	public void .ctor(HttpWebRequest request, NetworkStream networkStream) { }

	[AsyncStateMachine(typeof(MonoTlsStream.<CreateStream>d__18))]
	// RVA: 0x1A29654 Offset: 0x1A25654 VA: 0x1A29654
	internal Task<Stream> CreateStream(WebConnectionTunnel tunnel, CancellationToken cancellationToken) { }

	// RVA: 0x1A297A0 Offset: 0x1A257A0 VA: 0x1A297A0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1A297A4 Offset: 0x1A257A4 VA: 0x1A297A4
	private void CloseSslStream() { }
}

// Namespace: Mono.Net.Security
internal static class NoReflectionHelper // TypeDefIndex: 3810
{
	// Methods

	// RVA: 0x1A2A094 Offset: 0x1A26094 VA: 0x1A2A094
	internal static object GetProvider() { }
}

// Namespace: Mono.Net.Security
internal static class SystemCertificateValidator // TypeDefIndex: 3811
{
	// Fields
	private static bool is_macosx; // 0x0
	private static X509KeyUsageFlags s_flags; // 0x4

	// Methods

	// RVA: 0x1A2A0E0 Offset: 0x1A260E0 VA: 0x1A2A0E0
	private static void .cctor() { }

	// RVA: 0x1A24EF8 Offset: 0x1A20EF8 VA: 0x1A24EF8
	internal static bool NeedsChain(MonoTlsSettings settings) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CallbackHelpers.<>c__DisplayClass0_0 // TypeDefIndex: 3812
{
	// Fields
	public RemoteCertificateValidationCallback callback; // 0x10

	// Methods

	// RVA: 0x1A2A130 Offset: 0x1A26130 VA: 0x1A2A130
	public void .ctor() { }

	// RVA: 0x1A2A140 Offset: 0x1A26140 VA: 0x1A2A140
	internal bool <PublicToMono>b__0(string h, X509Certificate c, X509Chain ch, MonoSslPolicyErrors e) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class CallbackHelpers.<>c__DisplayClass6_0 // TypeDefIndex: 3813
{
	// Fields
	public MonoLocalCertificateSelectionCallback callback; // 0x10

	// Methods

	// RVA: 0x1A2A138 Offset: 0x1A26138 VA: 0x1A2A138
	public void .ctor() { }

	// RVA: 0x1A2A160 Offset: 0x1A26160 VA: 0x1A2A160
	internal X509Certificate <MonoToInternal>b__0(string t, X509CertificateCollection lc, X509Certificate rc, string[] ai) { }
}
