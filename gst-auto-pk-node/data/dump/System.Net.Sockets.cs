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

// Namespace: System.Net.Sockets
public class NetworkStream : Stream // TypeDefIndex: 4330
{
	// Fields
	private readonly Socket _streamSocket; // 0x28
	private readonly bool _ownsSocket; // 0x30
	private bool _readable; // 0x31
	private bool _writeable; // 0x32
	private int _closeTimeout; // 0x34
	private bool _cleanedUp; // 0x38
	private int _currentReadTimeout; // 0x3C
	private int _currentWriteTimeout; // 0x40

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }
	internal Socket InternalSocket { get; }

	// Methods

	// RVA: 0x1CD9FCC Offset: 0x1CD5FCC VA: 0x1CD9FCC
	public void .ctor(Socket socket) { }

	// RVA: 0x1CDA188 Offset: 0x1CD6188 VA: 0x1CDA188
	public void .ctor(Socket socket, bool ownsSocket) { }

	// RVA: 0x1CD9FD8 Offset: 0x1CD5FD8 VA: 0x1CD9FD8
	public void .ctor(Socket socket, FileAccess access, bool ownsSocket) { }

	// RVA: 0x1CDA194 Offset: 0x1CD6194 VA: 0x1CDA194 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1CDA19C Offset: 0x1CD619C VA: 0x1CDA19C Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1CDA1A4 Offset: 0x1CD61A4 VA: 0x1CDA1A4 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1CDA1AC Offset: 0x1CD61AC VA: 0x1CDA1AC Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1CDA1B4 Offset: 0x1CD61B4 VA: 0x1CDA1B4 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1CDA39C Offset: 0x1CD639C VA: 0x1CDA39C Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1CDA5CC Offset: 0x1CD65CC VA: 0x1CDA5CC Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1CDA628 Offset: 0x1CD6628 VA: 0x1CDA628 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1CDA6AC Offset: 0x1CD66AC VA: 0x1CDA6AC Slot: 11
	public override long get_Length() { }

	// RVA: 0x1CDA6F8 Offset: 0x1CD66F8 VA: 0x1CDA6F8 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1CDA744 Offset: 0x1CD6744 VA: 0x1CDA744 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1CDA790 Offset: 0x1CD6790 VA: 0x1CDA790 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1CDA7DC Offset: 0x1CD67DC VA: 0x1CDA7DC Slot: 32
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1CDAB70 Offset: 0x1CD6B70 VA: 0x1CDAB70 Slot: 33
	public override int Read(Span<byte> destination) { }

	// RVA: 0x1CDAECC Offset: 0x1CD6ECC VA: 0x1CDAECC Slot: 34
	public override int ReadByte() { }

	// RVA: 0x1CDAF30 Offset: 0x1CD6F30 VA: 0x1CDAF30 Slot: 35
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1CDB2C4 Offset: 0x1CD72C4 VA: 0x1CDB2C4 Slot: 36
	public override void Write(ReadOnlySpan<byte> source) { }

	// RVA: 0x1CDB5A4 Offset: 0x1CD75A4 VA: 0x1CDB5A4 Slot: 37
	public override void WriteByte(byte value) { }

	// RVA: 0x1CDB5FC Offset: 0x1CD75FC VA: 0x1CDB5FC
	public void Close(int timeout) { }

	// RVA: 0x1CDB660 Offset: 0x1CD7660 VA: 0x1CDB660 Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1CDB768 Offset: 0x1CD7768 VA: 0x1CDB768 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1CDB7FC Offset: 0x1CD77FC VA: 0x1CDB7FC Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1CDBBC0 Offset: 0x1CD7BC0 VA: 0x1CDBBC0 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1CDBE70 Offset: 0x1CD7E70 VA: 0x1CDBE70 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1CDC234 Offset: 0x1CD8234 VA: 0x1CDC234 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1CDC4E4 Offset: 0x1CD84E4 VA: 0x1CDC4E4 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1CDCBD4 Offset: 0x1CD8BD4 VA: 0x1CDCBD4 Slot: 25
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1CDCE64 Offset: 0x1CD8E64 VA: 0x1CDCE64 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1CDD568 Offset: 0x1CD9568 VA: 0x1CDD568 Slot: 29
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1CDD7F4 Offset: 0x1CD97F4 VA: 0x1CDD7F4 Slot: 21
	public override void Flush() { }

	// RVA: 0x1CDD7F8 Offset: 0x1CD97F8 VA: 0x1CDD7F8 Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1CDA420 Offset: 0x1CD6420 VA: 0x1CDA420
	internal void SetSocketTimeoutOption(SocketShutdown mode, int timeout, bool silent) { }

	// RVA: 0x1CDD980 Offset: 0x1CD9980 VA: 0x1CDD980
	internal Socket get_InternalSocket() { }
}

// Namespace: 
private sealed class Socket.CachedEventArgs // TypeDefIndex: 4331
{
	// Fields
	public Socket.TaskSocketAsyncEventArgs<Socket> TaskAccept; // 0x10
	public Socket.Int32TaskSocketAsyncEventArgs TaskReceive; // 0x18
	public Socket.Int32TaskSocketAsyncEventArgs TaskSend; // 0x20
	public Socket.AwaitableSocketAsyncEventArgs ValueTaskReceive; // 0x28
	public Socket.AwaitableSocketAsyncEventArgs ValueTaskSend; // 0x30

	// Methods

	// RVA: 0x1CE84EC Offset: 0x1CE44EC VA: 0x1CE84EC
	public void .ctor() { }
}

// Namespace: 
private class Socket.TaskSocketAsyncEventArgs<TResult> : SocketAsyncEventArgs // TypeDefIndex: 4332
{
	// Fields
	internal AsyncTaskMethodBuilder<TResult> _builder; // 0x0
	internal bool _accessed; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473148 Offset: 0x146F148 VA: 0x1473148
	|-Socket.TaskSocketAsyncEventArgs<int>..ctor
	|
	|-RVA: 0x1473294 Offset: 0x146F294 VA: 0x1473294
	|-Socket.TaskSocketAsyncEventArgs<object>..ctor
	|
	|-RVA: 0x14733E0 Offset: 0x146F3E0 VA: 0x14733E0
	|-Socket.TaskSocketAsyncEventArgs<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal AsyncTaskMethodBuilder<TResult> GetCompletionResponsibility(out bool responsibleForReturningToPool) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1473154 Offset: 0x146F154 VA: 0x1473154
	|-Socket.TaskSocketAsyncEventArgs<int>.GetCompletionResponsibility
	|
	|-RVA: 0x14732A0 Offset: 0x146F2A0 VA: 0x14732A0
	|-Socket.TaskSocketAsyncEventArgs<object>.GetCompletionResponsibility
	|
	|-RVA: 0x14733EC Offset: 0x146F3EC VA: 0x14733EC
	|-Socket.TaskSocketAsyncEventArgs<__Il2CppFullySharedGenericType>.GetCompletionResponsibility
	*/
}

// Namespace: 
private sealed class Socket.Int32TaskSocketAsyncEventArgs : Socket.TaskSocketAsyncEventArgs<int> // TypeDefIndex: 4333
{
	// Fields
	internal bool _wrapExceptionsInIOExceptions; // 0xD1

	// Methods

	// RVA: 0x1CE84A4 Offset: 0x1CE44A4 VA: 0x1CE84A4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Socket.AwaitableSocketAsyncEventArgs.<>c // TypeDefIndex: 4334
{
	// Fields
	public static readonly Socket.AwaitableSocketAsyncEventArgs.<>c <>9; // 0x0
	public static ContextCallback <>9__14_0; // 0x8
	public static SendOrPostCallback <>9__20_0; // 0x10

	// Methods

	// RVA: 0x1CE9210 Offset: 0x1CE5210 VA: 0x1CE9210
	private static void .cctor() { }

	// RVA: 0x1CE9278 Offset: 0x1CE5278 VA: 0x1CE9278
	public void .ctor() { }

	// RVA: 0x1CE9280 Offset: 0x1CE5280 VA: 0x1CE9280
	internal void <OnCompleted>b__14_0(object runState) { }

	// RVA: 0x1CE9330 Offset: 0x1CE5330 VA: 0x1CE9330
	internal void <InvokeContinuation>b__20_0(object s) { }

	// RVA: 0x1CE93DC Offset: 0x1CE53DC VA: 0x1CE93DC
	internal void <.cctor>b__27_0(object state) { }

	// RVA: 0x1CE9428 Offset: 0x1CE5428 VA: 0x1CE9428
	internal void <.cctor>b__27_1(object state) { }
}

// Namespace: 
internal sealed class Socket.AwaitableSocketAsyncEventArgs : SocketAsyncEventArgs, IValueTaskSource, IValueTaskSource<int> // TypeDefIndex: 4335
{
	// Fields
	internal static readonly Socket.AwaitableSocketAsyncEventArgs Reserved; // 0x0
	private static readonly Action<object> s_completedSentinel; // 0x8
	private static readonly Action<object> s_availableSentinel; // 0x10
	private Action<object> _continuation; // 0xB8
	private ExecutionContext _executionContext; // 0xC0
	private object _scheduler; // 0xC8
	private short _token; // 0xD0
	[CompilerGenerated]
	private bool <WrapExceptionsInIOExceptions>k__BackingField; // 0xD2

	// Properties
	public bool WrapExceptionsInIOExceptions { get; set; }

	// Methods

	// RVA: 0x1CE84F4 Offset: 0x1CE44F4 VA: 0x1CE84F4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x1CE85FC Offset: 0x1CE45FC VA: 0x1CE85FC
	public bool get_WrapExceptionsInIOExceptions() { }

	[CompilerGenerated]
	// RVA: 0x1CE8604 Offset: 0x1CE4604 VA: 0x1CE8604
	public void set_WrapExceptionsInIOExceptions(bool value) { }

	// RVA: 0x1CDDA14 Offset: 0x1CD9A14 VA: 0x1CDDA14
	public bool Reserve() { }

	// RVA: 0x1CE860C Offset: 0x1CE460C VA: 0x1CE860C
	private void Release() { }

	// RVA: 0x1CE8684 Offset: 0x1CE4684 VA: 0x1CE8684 Slot: 5
	protected override void OnCompleted(SocketAsyncEventArgs _) { }

	// RVA: 0x1CDDB88 Offset: 0x1CD9B88 VA: 0x1CDDB88
	public ValueTask<int> ReceiveAsync(Socket socket) { }

	// RVA: 0x1CDE038 Offset: 0x1CDA038 VA: 0x1CDE038
	public ValueTask SendAsyncForNetworkStream(Socket socket) { }

	// RVA: 0x1CE8C90 Offset: 0x1CE4C90 VA: 0x1CE8C90 Slot: 9
	public ValueTaskSourceStatus GetStatus(short token) { }

	// RVA: 0x1CE8D70 Offset: 0x1CE4D70 VA: 0x1CE8D70 Slot: 10
	public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags) { }

	// RVA: 0x1CE88B4 Offset: 0x1CE48B4 VA: 0x1CE88B4
	private void InvokeContinuation(Action<object> continuation, object state, bool forceAsync) { }

	// RVA: 0x1CE9000 Offset: 0x1CE5000 VA: 0x1CE9000 Slot: 11
	public int GetResult(short token) { }

	// RVA: 0x1CE906C Offset: 0x1CE506C VA: 0x1CE906C Slot: 8
	private void System.Threading.Tasks.Sources.IValueTaskSource.GetResult(short token) { }

	// RVA: 0x1CE8D24 Offset: 0x1CE4D24 VA: 0x1CE8D24
	private void ThrowIncorrectTokenException() { }

	// RVA: 0x1CE8FB4 Offset: 0x1CE4FB4 VA: 0x1CE8FB4
	private void ThrowMultipleContinuationsException() { }

	// RVA: 0x1CE9048 Offset: 0x1CE5048 VA: 0x1CE9048
	private void ThrowException(SocketError error) { }

	// RVA: 0x1CE8BA4 Offset: 0x1CE4BA4 VA: 0x1CE8BA4
	private Exception CreateException(SocketError error) { }

	// RVA: 0x1CE90AC Offset: 0x1CE50AC VA: 0x1CE90AC
	private static void .cctor() { }
}

// Namespace: 
private struct Socket.WSABUF // TypeDefIndex: 4336
{
	// Fields
	public int len; // 0x0
	public IntPtr buf; // 0x8
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Socket.<>c // TypeDefIndex: 4337
{
	// Fields
	public static readonly Socket.<>c <>9; // 0x0
	public static Func<Socket.CachedEventArgs> <>9__14_0; // 0x8
	public static Func<Socket.AwaitableSocketAsyncEventArgs> <>9__14_1; // 0x10
	public static AsyncCallback <>9__15_0; // 0x18
	public static AsyncCallback <>9__15_1; // 0x20
	public static Func<Socket.CachedEventArgs> <>9__22_0; // 0x28
	public static Func<Socket.AwaitableSocketAsyncEventArgs> <>9__22_1; // 0x30
	public static AsyncCallback <>9__23_0; // 0x38
	public static AsyncCallback <>9__23_1; // 0x40
	public static IOAsyncCallback <>9__295_0; // 0x48
	public static IOAsyncCallback <>9__297_0; // 0x50
	public static IOAsyncCallback <>9__308_0; // 0x58

	// Methods

	// RVA: 0x1CE9474 Offset: 0x1CE5474 VA: 0x1CE9474
	private static void .cctor() { }

	// RVA: 0x1CE94DC Offset: 0x1CE54DC VA: 0x1CE94DC
	public void .ctor() { }

	// RVA: 0x1CE94E4 Offset: 0x1CE54E4 VA: 0x1CE94E4
	internal Socket.CachedEventArgs <ReceiveAsync>b__14_0() { }

	// RVA: 0x1CE9538 Offset: 0x1CE5538 VA: 0x1CE9538
	internal Socket.AwaitableSocketAsyncEventArgs <ReceiveAsync>b__14_1() { }

	// RVA: 0x1CE9588 Offset: 0x1CE5588 VA: 0x1CE9588
	internal void <ReceiveAsyncApm>b__15_0(IAsyncResult iar) { }

	// RVA: 0x1CE97BC Offset: 0x1CE57BC VA: 0x1CE97BC
	internal void <ReceiveAsyncApm>b__15_1(IAsyncResult iar) { }

	// RVA: 0x1CE9C20 Offset: 0x1CE5C20 VA: 0x1CE9C20
	internal Socket.CachedEventArgs <SendAsyncForNetworkStream>b__22_0() { }

	// RVA: 0x1CE9C74 Offset: 0x1CE5C74 VA: 0x1CE9C74
	internal Socket.AwaitableSocketAsyncEventArgs <SendAsyncForNetworkStream>b__22_1() { }

	// RVA: 0x1CE9CC4 Offset: 0x1CE5CC4 VA: 0x1CE9CC4
	internal void <SendAsyncApm>b__23_0(IAsyncResult iar) { }

	// RVA: 0x1CE9EF8 Offset: 0x1CE5EF8 VA: 0x1CE9EF8
	internal void <SendAsyncApm>b__23_1(IAsyncResult iar) { }

	// RVA: 0x1CEA21C Offset: 0x1CE621C VA: 0x1CEA21C
	internal void <SendAsync>b__295_0(IOAsyncResult s) { }

	// RVA: 0x1CEA2AC Offset: 0x1CE62AC VA: 0x1CEA2AC
	internal void <BeginSend>b__297_0(IOAsyncResult s) { }

	// RVA: 0x1CEA33C Offset: 0x1CE633C VA: 0x1CEA33C
	internal void <SendToAsync>b__308_0(IOAsyncResult s) { }

	// RVA: 0x1CEA3CC Offset: 0x1CE63CC VA: 0x1CEA3CC
	internal void <.cctor>b__367_0(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x1CEA4C0 Offset: 0x1CE64C0 VA: 0x1CEA4C0
	internal void <.cctor>b__367_1(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x1CEA59C Offset: 0x1CE659C VA: 0x1CEA59C
	internal void <.cctor>b__367_2(object s, SocketAsyncEventArgs e) { }

	// RVA: 0x1CEA678 Offset: 0x1CE6678 VA: 0x1CEA678
	internal void <.cctor>b__367_3(IAsyncResult ares) { }

	// RVA: 0x1CEA928 Offset: 0x1CE6928 VA: 0x1CEA928
	internal void <.cctor>b__367_4(IOAsyncResult ares) { }

	// RVA: 0x1CEAA78 Offset: 0x1CE6A78 VA: 0x1CEAA78
	internal void <.cctor>b__367_5(IOAsyncResult ares) { }

	// RVA: 0x1CEACFC Offset: 0x1CE6CFC VA: 0x1CEACFC
	internal void <.cctor>b__367_6(IAsyncResult ares) { }

	// RVA: 0x1CEAFA4 Offset: 0x1CE6FA4 VA: 0x1CEAFA4
	internal void <.cctor>b__367_7(IOAsyncResult ares) { }

	// RVA: 0x1CEB258 Offset: 0x1CE7258 VA: 0x1CEB258
	internal void <.cctor>b__367_8(IAsyncResult ares) { }

	// RVA: 0x1CEB500 Offset: 0x1CE7500 VA: 0x1CEB500
	internal void <.cctor>b__367_9(IOAsyncResult ares) { }

	// RVA: 0x1CEB608 Offset: 0x1CE7608 VA: 0x1CEB608
	internal void <.cctor>b__367_10(IAsyncResult ares) { }

	// RVA: 0x1CEB8BC Offset: 0x1CE78BC VA: 0x1CEB8BC
	internal void <.cctor>b__367_11(IOAsyncResult ares) { }

	// RVA: 0x1CEBB98 Offset: 0x1CE7B98 VA: 0x1CEBB98
	internal void <.cctor>b__367_12(IOAsyncResult ares) { }

	// RVA: 0x1CEBCAC Offset: 0x1CE7CAC VA: 0x1CEBCAC
	internal void <.cctor>b__367_13(IAsyncResult ares) { }

	// RVA: 0x1CEBF7C Offset: 0x1CE7F7C VA: 0x1CEBF7C
	internal void <.cctor>b__367_14(IOAsyncResult ares) { }

	// RVA: 0x1CEC108 Offset: 0x1CE8108 VA: 0x1CEC108
	internal void <.cctor>b__367_15(IAsyncResult ares) { }

	// RVA: 0x1CEC3BC Offset: 0x1CE83BC VA: 0x1CEC3BC
	internal void <.cctor>b__367_16(IOAsyncResult ares) { }

	// RVA: 0x1CEC4D0 Offset: 0x1CE84D0 VA: 0x1CEC4D0
	internal void <.cctor>b__367_17(IAsyncResult ares) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Socket.<>c__DisplayClass240_0 // TypeDefIndex: 4338
{
	// Fields
	public SocketAsyncResult sockares; // 0x10

	// Methods

	// RVA: 0x1CE439C Offset: 0x1CE039C VA: 0x1CE439C
	public void .ctor() { }

	// RVA: 0x1CEC784 Offset: 0x1CE8784 VA: 0x1CEC784
	internal void <BeginConnect>b__0(Task<IPAddress[]> t) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Socket.<>c__DisplayClass298_0 // TypeDefIndex: 4339
{
	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x1CE63F4 Offset: 0x1CE23F4 VA: 0x1CE63F4
	public void .ctor() { }

	// RVA: 0x1CEC8BC Offset: 0x1CE88BC VA: 0x1CEC8BC
	internal void <BeginSendCallback>b__0(IOAsyncResult s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Socket.<>c__DisplayClass311_0 // TypeDefIndex: 4340
{
	// Fields
	public int sent_so_far; // 0x10

	// Methods

	// RVA: 0x1CE6E90 Offset: 0x1CE2E90 VA: 0x1CE6E90
	public void .ctor() { }

	// RVA: 0x1CEC95C Offset: 0x1CE895C VA: 0x1CEC95C
	internal void <BeginSendToCallback>b__0(IOAsyncResult s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Socket.<>c__DisplayClass355_0 // TypeDefIndex: 4341
{
	// Fields
	public Socket <>4__this; // 0x10
	public IOSelectorJob job; // 0x18
	public IntPtr handle; // 0x20

	// Methods

	// RVA: 0x1CE7A40 Offset: 0x1CE3A40 VA: 0x1CE7A40
	public void .ctor() { }

	// RVA: 0x1CEC9FC Offset: 0x1CE89FC VA: 0x1CEC9FC
	internal void <QueueIOSelectorJob>b__0(Task t) { }
}

// Namespace: System.Net.Sockets
public class Socket : IDisposable // TypeDefIndex: 4342
{
	// Fields
	private static readonly EventHandler<SocketAsyncEventArgs> AcceptCompletedHandler; // 0x0
	private static readonly EventHandler<SocketAsyncEventArgs> ReceiveCompletedHandler; // 0x8
	private static readonly EventHandler<SocketAsyncEventArgs> SendCompletedHandler; // 0x10
	private static readonly Socket.TaskSocketAsyncEventArgs<Socket> s_rentedSocketSentinel; // 0x18
	private static readonly Socket.Int32TaskSocketAsyncEventArgs s_rentedInt32Sentinel; // 0x20
	private static readonly Task<int> s_zeroTask; // 0x28
	private Socket.CachedEventArgs _cachedTaskEventArgs; // 0x10
	private static object s_InternalSyncObject; // 0x30
	internal static bool s_SupportsIPv4; // 0x38
	internal static bool s_SupportsIPv6; // 0x39
	internal static bool s_OSSupportsIPv6; // 0x3A
	internal static bool s_Initialized; // 0x3B
	private static bool s_LoggingEnabled; // 0x3C
	internal static bool s_PerfCountersEnabled; // 0x3D
	internal const int DefaultCloseTimeout = -1;
	private const int SOCKET_CLOSED_CODE = 10004;
	private const string TIMEOUT_EXCEPTION_MSG = "A connection attempt failed because the connected party did not properly respondafter a period of time, or established connection failed because connected host has failed to respond";
	private bool is_closed; // 0x18
	private bool is_listening; // 0x19
	private bool useOverlappedIO; // 0x1A
	private int linger_timeout; // 0x1C
	private AddressFamily addressFamily; // 0x20
	private SocketType socketType; // 0x24
	private ProtocolType protocolType; // 0x28
	internal SafeSocketHandle m_Handle; // 0x30
	internal EndPoint seed_endpoint; // 0x38
	internal SemaphoreSlim ReadSem; // 0x40
	internal SemaphoreSlim WriteSem; // 0x48
	internal bool is_blocking; // 0x50
	internal bool is_bound; // 0x51
	internal bool is_connected; // 0x52
	private int m_IntCleanedUp; // 0x54
	internal bool connect_in_progress; // 0x58
	internal readonly int ID; // 0x5C
	private static AsyncCallback AcceptAsyncCallback; // 0x40
	private static IOAsyncCallback BeginAcceptCallback; // 0x48
	private static IOAsyncCallback BeginAcceptReceiveCallback; // 0x50
	private static AsyncCallback ConnectAsyncCallback; // 0x58
	private static IOAsyncCallback BeginConnectCallback; // 0x60
	private static AsyncCallback DisconnectAsyncCallback; // 0x68
	private static IOAsyncCallback BeginDisconnectCallback; // 0x70
	private static AsyncCallback ReceiveAsyncCallback; // 0x78
	private static IOAsyncCallback BeginReceiveCallback; // 0x80
	private static IOAsyncCallback BeginReceiveGenericCallback; // 0x88
	private static AsyncCallback ReceiveFromAsyncCallback; // 0x90
	private static IOAsyncCallback BeginReceiveFromCallback; // 0x98
	private static AsyncCallback SendAsyncCallback; // 0xA0
	private static IOAsyncCallback BeginSendGenericCallback; // 0xA8
	private static AsyncCallback SendToAsyncCallback; // 0xB0

	// Properties
	public static bool OSSupportsIPv4 { get; }
	public static bool OSSupportsIPv6 { get; }
	public IntPtr Handle { get; }
	public AddressFamily AddressFamily { get; }
	public SocketType SocketType { get; }
	public ProtocolType ProtocolType { get; }
	public bool DontFragment { set; }
	public bool DualMode { get; set; }
	private bool IsDualMode { get; }
	private static object InternalSyncObject { get; }
	internal bool CleanedUp { get; }
	public EndPoint LocalEndPoint { get; }
	public bool Blocking { get; set; }
	public bool Connected { get; }
	public bool NoDelay { set; }
	public EndPoint RemoteEndPoint { get; }
	internal static int FamilyHint { get; }

	// Methods

	// RVA: 0x1CDC8D0 Offset: 0x1CD88D0 VA: 0x1CDC8D0
	internal ValueTask<int> ReceiveAsync(Memory<byte> buffer, SocketFlags socketFlags, bool fromNetworkStream, CancellationToken cancellationToken) { }

	// RVA: 0x1CDDC38 Offset: 0x1CD9C38 VA: 0x1CDDC38
	private Task<int> ReceiveAsyncApm(Memory<byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x1CDD260 Offset: 0x1CD9260 VA: 0x1CDD260
	internal ValueTask SendAsyncForNetworkStream(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags, CancellationToken cancellationToken) { }

	// RVA: 0x1CDE0B4 Offset: 0x1CDA0B4 VA: 0x1CDE0B4
	private Task<int> SendAsyncApm(ReadOnlyMemory<byte> buffer, SocketFlags socketFlags) { }

	// RVA: 0x1CDE510 Offset: 0x1CDA510 VA: 0x1CDE510
	private static void CompleteAccept(Socket s, Socket.TaskSocketAsyncEventArgs<Socket> saea) { }

	// RVA: 0x1CDE7AC Offset: 0x1CDA7AC VA: 0x1CDE7AC
	private static void CompleteSendReceive(Socket s, Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x1CDE6C4 Offset: 0x1CDA6C4 VA: 0x1CDE6C4
	private static Exception GetException(SocketError error, bool wrapExceptionsInIOExceptions = False) { }

	// RVA: 0x1CDE91C Offset: 0x1CDA91C VA: 0x1CDE91C
	private void ReturnSocketAsyncEventArgs(Socket.Int32TaskSocketAsyncEventArgs saea, bool isReceive) { }

	// RVA: 0x1CDE668 Offset: 0x1CDA668 VA: 0x1CDE668
	private void ReturnSocketAsyncEventArgs(Socket.TaskSocketAsyncEventArgs<Socket> saea) { }

	// RVA: 0x1CDE974 Offset: 0x1CDA974 VA: 0x1CDE974
	public void .ctor(AddressFamily addressFamily, SocketType socketType, ProtocolType protocolType) { }

	// RVA: 0x1CDF0FC Offset: 0x1CDB0FC VA: 0x1CDF0FC
	public static bool get_OSSupportsIPv4() { }

	// RVA: 0x1CDF160 Offset: 0x1CDB160 VA: 0x1CDF160
	public static bool get_OSSupportsIPv6() { }

	// RVA: 0x1CDF1C4 Offset: 0x1CDB1C4 VA: 0x1CDF1C4
	public IntPtr get_Handle() { }

	// RVA: 0x1CDF1DC Offset: 0x1CDB1DC VA: 0x1CDF1DC
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x1CDF1E4 Offset: 0x1CDB1E4 VA: 0x1CDF1E4
	public SocketType get_SocketType() { }

	// RVA: 0x1CDF1EC Offset: 0x1CDB1EC VA: 0x1CDF1EC
	public ProtocolType get_ProtocolType() { }

	// RVA: 0x1CDF1F4 Offset: 0x1CDB1F4 VA: 0x1CDF1F4
	public void set_DontFragment(bool value) { }

	// RVA: 0x1CDF380 Offset: 0x1CDB380 VA: 0x1CDF380
	public bool get_DualMode() { }

	// RVA: 0x1CDF438 Offset: 0x1CDB438 VA: 0x1CDF438
	public void set_DualMode(bool value) { }

	// RVA: 0x1CDF4B0 Offset: 0x1CDB4B0 VA: 0x1CDF4B0
	private bool get_IsDualMode() { }

	// RVA: 0x1CDF4C8 Offset: 0x1CDB4C8 VA: 0x1CDF4C8
	internal bool CanTryAddressFamily(AddressFamily family) { }

	// RVA: 0x1CDF4F8 Offset: 0x1CDB4F8 VA: 0x1CDF4F8
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x1CDB268 Offset: 0x1CD7268 VA: 0x1CDB268
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x1CDAB14 Offset: 0x1CD6B14 VA: 0x1CDAB14
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags) { }

	// RVA: 0x1CDFDC0 Offset: 0x1CDBDC0 VA: 0x1CDFDC0
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags) { }

	// RVA: 0x1CE03E0 Offset: 0x1CDC3E0 VA: 0x1CE03E0
	public int IOControl(IOControlCode ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x1CDEF44 Offset: 0x1CDAF44 VA: 0x1CDEF44
	public void SetIPProtectionLevel(IPProtectionLevel level) { }

	// RVA: 0x1CDC1C0 Offset: 0x1CD81C0 VA: 0x1CDC1C0
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x1CDC488 Offset: 0x1CD8488 VA: 0x1CDC488
	public int EndSend(IAsyncResult asyncResult) { }

	// RVA: 0x1CDBB4C Offset: 0x1CD7B4C VA: 0x1CDBB4C
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, AsyncCallback callback, object state) { }

	// RVA: 0x1CDBE14 Offset: 0x1CD7E14 VA: 0x1CDBE14
	public int EndReceive(IAsyncResult asyncResult) { }

	// RVA: 0x1CE0B18 Offset: 0x1CDCB18 VA: 0x1CE0B18
	private static object get_InternalSyncObject() { }

	// RVA: 0x1CE0BE4 Offset: 0x1CDCBE4 VA: 0x1CE0BE4
	internal bool get_CleanedUp() { }

	// RVA: 0x1CDEBE0 Offset: 0x1CDABE0 VA: 0x1CDEBE0
	internal static void InitializeSockets() { }

	// RVA: 0x1CE0C48 Offset: 0x1CDCC48 VA: 0x1CE0C48 Slot: 4
	public void Dispose() { }

	// RVA: 0x1CE0CB4 Offset: 0x1CDCCB4 VA: 0x1CE0CB4 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1CDB6D8 Offset: 0x1CD76D8 VA: 0x1CDB6D8
	internal void InternalShutdown(SocketShutdown how) { }

	// RVA: 0x1CDD844 Offset: 0x1CD9844 VA: 0x1CDD844
	internal void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue, bool silent) { }

	// RVA: 0x1CE0FD4 Offset: 0x1CDCFD4 VA: 0x1CE0FD4
	internal void .ctor(AddressFamily family, SocketType type, ProtocolType proto, SafeSocketHandle safe_handle) { }

	// RVA: 0x1CDF028 Offset: 0x1CDB028 VA: 0x1CDF028
	private void SocketDefaults() { }

	// RVA: 0x1CDEE44 Offset: 0x1CDAE44 VA: 0x1CDEE44
	private static IntPtr Socket_icall(AddressFamily family, SocketType type, ProtocolType proto, out int error) { }

	// RVA: 0x1CE1128 Offset: 0x1CDD128 VA: 0x1CE1128
	public EndPoint get_LocalEndPoint() { }

	// RVA: 0x1CE128C Offset: 0x1CDD28C VA: 0x1CE128C
	private static SocketAddress LocalEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x1CE13CC Offset: 0x1CDD3CC VA: 0x1CE13CC
	private static SocketAddress LocalEndPoint_icall(IntPtr socket, int family, out int error) { }

	// RVA: 0x1CE13D0 Offset: 0x1CDD3D0 VA: 0x1CE13D0
	public bool get_Blocking() { }

	// RVA: 0x1CE13D8 Offset: 0x1CDD3D8 VA: 0x1CE13D8
	public void set_Blocking(bool value) { }

	// RVA: 0x1CE1498 Offset: 0x1CDD498 VA: 0x1CE1498
	private static void Blocking_internal(SafeSocketHandle safeHandle, bool block, out int error) { }

	// RVA: 0x1CE15C8 Offset: 0x1CDD5C8 VA: 0x1CE15C8
	internal static void Blocking_icall(IntPtr socket, bool block, out int error) { }

	// RVA: 0x1CE15CC Offset: 0x1CDD5CC VA: 0x1CE15CC
	public bool get_Connected() { }

	// RVA: 0x1CE10E8 Offset: 0x1CDD0E8 VA: 0x1CE10E8
	public void set_NoDelay(bool value) { }

	// RVA: 0x1CE161C Offset: 0x1CDD61C VA: 0x1CE161C
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x1CE170C Offset: 0x1CDD70C VA: 0x1CE170C
	private static SocketAddress RemoteEndPoint_internal(SafeSocketHandle safeHandle, int family, out int error) { }

	// RVA: 0x1CE184C Offset: 0x1CDD84C VA: 0x1CE184C
	private static SocketAddress RemoteEndPoint_icall(IntPtr socket, int family, out int error) { }

	// RVA: 0x1CE1850 Offset: 0x1CDD850 VA: 0x1CE1850
	public bool Poll(int microSeconds, SelectMode mode) { }

	// RVA: 0x1CE19D4 Offset: 0x1CDD9D4 VA: 0x1CE19D4
	private static bool Poll_internal(SafeSocketHandle safeHandle, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x1CE1B20 Offset: 0x1CDDB20 VA: 0x1CE1B20
	private static bool Poll_icall(IntPtr socket, SelectMode mode, int timeout, out int error) { }

	// RVA: 0x1CE1B24 Offset: 0x1CDDB24 VA: 0x1CE1B24
	public Socket Accept() { }

	// RVA: 0x1CE1DA8 Offset: 0x1CDDDA8 VA: 0x1CE1DA8
	internal void Accept(Socket acceptSocket) { }

	// RVA: 0x1CE1ED0 Offset: 0x1CDDED0 VA: 0x1CE1ED0
	public IAsyncResult BeginAccept(AsyncCallback callback, object state) { }

	// RVA: 0x1CE2210 Offset: 0x1CDE210 VA: 0x1CE2210
	public Socket EndAccept(IAsyncResult asyncResult) { }

	// RVA: 0x1CE2238 Offset: 0x1CDE238 VA: 0x1CE2238
	public Socket EndAccept(out byte[] buffer, out int bytesTransferred, IAsyncResult asyncResult) { }

	// RVA: 0x1CE1C5C Offset: 0x1CDDC5C VA: 0x1CE1C5C
	private static SafeSocketHandle Accept_internal(SafeSocketHandle safeHandle, out int error, bool blocking) { }

	// RVA: 0x1CE2648 Offset: 0x1CDE648 VA: 0x1CE2648
	private static IntPtr Accept_icall(IntPtr sock, out int error, bool blocking) { }

	// RVA: 0x1CE264C Offset: 0x1CDE64C VA: 0x1CE264C
	public void Bind(EndPoint localEP) { }

	// RVA: 0x1CE287C Offset: 0x1CDE87C VA: 0x1CE287C
	private static void Bind_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error) { }

	// RVA: 0x1CE29AC Offset: 0x1CDE9AC VA: 0x1CE29AC
	private static void Bind_icall(IntPtr sock, SocketAddress sa, out int error) { }

	// RVA: 0x1CE29B0 Offset: 0x1CDE9B0 VA: 0x1CE29B0
	public void Listen(int backlog) { }

	// RVA: 0x1CE2A94 Offset: 0x1CDEA94 VA: 0x1CE2A94
	private static void Listen_internal(SafeSocketHandle safeHandle, int backlog, out int error) { }

	// RVA: 0x1CE2BC4 Offset: 0x1CDEBC4 VA: 0x1CE2BC4
	private static void Listen_icall(IntPtr sock, int backlog, out int error) { }

	// RVA: 0x1CE2BC8 Offset: 0x1CDEBC8 VA: 0x1CE2BC8
	public void Connect(IPAddress address, int port) { }

	// RVA: 0x1CE2C3C Offset: 0x1CDEC3C VA: 0x1CE2C3C
	public void Connect(EndPoint remoteEP) { }

	// RVA: 0x1CE30A0 Offset: 0x1CDF0A0 VA: 0x1CE30A0
	public bool ConnectAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x1CE4024 Offset: 0x1CE0024 VA: 0x1CE4024
	public static void CancelConnectAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x1CE40C0 Offset: 0x1CE00C0 VA: 0x1CE40C0
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback callback, object state) { }

	// RVA: 0x1CE43A4 Offset: 0x1CE03A4 VA: 0x1CE43A4
	public IAsyncResult BeginConnect(EndPoint remoteEP, AsyncCallback callback, object state) { }

	// RVA: 0x1CE3D28 Offset: 0x1CDFD28 VA: 0x1CE3D28
	private static bool BeginMConnect(SocketAsyncResult sockares) { }

	// RVA: 0x1CE3848 Offset: 0x1CDF848 VA: 0x1CE3848
	private static bool BeginSConnect(SocketAsyncResult sockares) { }

	// RVA: 0x1CE3F48 Offset: 0x1CDFF48 VA: 0x1CE3F48
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x1CE2F88 Offset: 0x1CDEF88 VA: 0x1CE2F88
	private static void Connect_internal(SafeSocketHandle safeHandle, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1CE44F8 Offset: 0x1CE04F8 VA: 0x1CE44F8
	private static void Connect_icall(IntPtr sock, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1CE3668 Offset: 0x1CDF668 VA: 0x1CE3668
	private bool GetCheckedIPs(SocketAsyncEventArgs e, out IPAddress[] addresses) { }

	// RVA: 0x1CE4504 Offset: 0x1CE0504 VA: 0x1CE4504
	public void Disconnect(bool reuseSocket) { }

	// RVA: 0x1CE471C Offset: 0x1CE071C VA: 0x1CE471C
	public void EndDisconnect(IAsyncResult asyncResult) { }

	// RVA: 0x1CE45EC Offset: 0x1CE05EC VA: 0x1CE45EC
	private static void Disconnect_internal(SafeSocketHandle safeHandle, bool reuse, out int error) { }

	// RVA: 0x1CE47C4 Offset: 0x1CE07C4 VA: 0x1CE47C4
	private static void Disconnect_icall(IntPtr sock, bool reuse, out int error) { }

	// RVA: 0x1CDFCB4 Offset: 0x1CDBCB4 VA: 0x1CDFCB4
	public int Receive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x1CE4A80 Offset: 0x1CE0A80 VA: 0x1CE4A80
	private int Receive(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliant(False)]
	// RVA: 0x1CDFE1C Offset: 0x1CDBE1C VA: 0x1CDFE1C
	public int Receive(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x1CDADC4 Offset: 0x1CD6DC4 VA: 0x1CDADC4
	public int Receive(Span<byte> buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x1CDB518 Offset: 0x1CD7518 VA: 0x1CDB518
	public int Send(ReadOnlySpan<byte> buffer, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x1CE4DC8 Offset: 0x1CE0DC8 VA: 0x1CE4DC8
	public bool ReceiveAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x1CE087C Offset: 0x1CDC87C VA: 0x1CE087C
	public IAsyncResult BeginReceive(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x1CE0A34 Offset: 0x1CDCA34 VA: 0x1CE0A34
	public int EndReceive(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x1CE4C88 Offset: 0x1CE0C88 VA: 0x1CE4C88
	private static int Receive_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1CE50B8 Offset: 0x1CE10B8 VA: 0x1CE50B8
	private static int Receive_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1CE4940 Offset: 0x1CE0940 VA: 0x1CE4940
	private static int Receive_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1CE50BC Offset: 0x1CE10BC VA: 0x1CE50BC
	private static int Receive_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1CE50C0 Offset: 0x1CE10C0 VA: 0x1CE50C0
	public int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP) { }

	// RVA: 0x1CE51C8 Offset: 0x1CE11C8 VA: 0x1CE51C8
	internal int ReceiveFrom(byte[] buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0x1CE54A0 Offset: 0x1CE14A0 VA: 0x1CE54A0
	private int ReceiveFrom(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, ref EndPoint remoteEP, out SocketError errorCode) { }

	// RVA: 0x1CE5730 Offset: 0x1CE1730 VA: 0x1CE5730
	public bool ReceiveFromAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x1CE5A00 Offset: 0x1CE1A00 VA: 0x1CE5A00
	private int EndReceiveFrom_internal(SocketAsyncResult sockares, SocketAsyncEventArgs ares) { }

	// RVA: 0x1CE5354 Offset: 0x1CE1354 VA: 0x1CE5354
	private static int ReceiveFrom_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x1CE5AD0 Offset: 0x1CE1AD0 VA: 0x1CE5AD0
	private static int ReceiveFrom_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, ref SocketAddress sockaddr, out int error, bool blocking) { }

	// RVA: 0x1CDFB70 Offset: 0x1CDBB70 VA: 0x1CDFB70
	public int Send(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode) { }

	[CLSCompliant(False)]
	// RVA: 0x1CDF554 Offset: 0x1CDB554 VA: 0x1CDF554
	public int Send(IList<ArraySegment<byte>> buffers, SocketFlags socketFlags, out SocketError errorCode) { }

	// RVA: 0x1CE5D54 Offset: 0x1CE1D54 VA: 0x1CE5D54
	public bool SendAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x1CE0554 Offset: 0x1CDC554 VA: 0x1CE0554
	public IAsyncResult BeginSend(byte[] buffer, int offset, int size, SocketFlags socketFlags, out SocketError errorCode, AsyncCallback callback, object state) { }

	// RVA: 0x1CE603C Offset: 0x1CE203C VA: 0x1CE603C
	private static void BeginSendCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x1CE0798 Offset: 0x1CDC798 VA: 0x1CE0798
	public int EndSend(IAsyncResult asyncResult, out SocketError errorCode) { }

	// RVA: 0x1CE5C14 Offset: 0x1CE1C14 VA: 0x1CE5C14
	private static int Send_internal(SafeSocketHandle safeHandle, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1CE6420 Offset: 0x1CE2420 VA: 0x1CE6420
	private static int Send_array_icall(IntPtr sock, Socket.WSABUF* bufarray, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1CE5AD4 Offset: 0x1CE1AD4 VA: 0x1CE5AD4
	private static int Send_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1CE6424 Offset: 0x1CE2424 VA: 0x1CE6424
	private static int Send_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, out int error, bool blocking) { }

	// RVA: 0x1CE6428 Offset: 0x1CE2428 VA: 0x1CE6428
	public int SendTo(byte[] buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x1CE6720 Offset: 0x1CE2720 VA: 0x1CE6720
	private int SendTo(Memory<byte> buffer, int offset, int size, SocketFlags socketFlags, EndPoint remoteEP) { }

	// RVA: 0x1CE69B0 Offset: 0x1CE29B0 VA: 0x1CE69B0
	public bool SendToAsync(SocketAsyncEventArgs e) { }

	// RVA: 0x1CE6C68 Offset: 0x1CE2C68 VA: 0x1CE6C68
	private static void BeginSendToCallback(SocketAsyncResult sockares, int sent_so_far) { }

	// RVA: 0x1CE708C Offset: 0x1CE308C VA: 0x1CE708C
	public int EndSendTo(IAsyncResult asyncResult) { }

	// RVA: 0x1CE65D4 Offset: 0x1CE25D4 VA: 0x1CE65D4
	private static int SendTo_internal(SafeSocketHandle safeHandle, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1CE713C Offset: 0x1CE313C VA: 0x1CE713C
	private static int SendTo_icall(IntPtr sock, byte* buffer, int count, SocketFlags flags, SocketAddress sa, out int error, bool blocking) { }

	// RVA: 0x1CDA210 Offset: 0x1CD6210 VA: 0x1CDA210
	public object GetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName) { }

	// RVA: 0x1CE7140 Offset: 0x1CE3140 VA: 0x1CE7140
	private static void GetSocketOption_obj_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x1CE7288 Offset: 0x1CE3288 VA: 0x1CE7288
	private static void GetSocketOption_obj_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, out object obj_val, out int error) { }

	// RVA: 0x1CE728C Offset: 0x1CE328C VA: 0x1CE728C
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, object optionValue) { }

	// RVA: 0x1CE75D8 Offset: 0x1CE35D8 VA: 0x1CE75D8
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, bool optionValue) { }

	// RVA: 0x1CDF268 Offset: 0x1CDB268 VA: 0x1CDF268
	public void SetSocketOption(SocketOptionLevel optionLevel, SocketOptionName optionName, int optionValue) { }

	// RVA: 0x1CE0E74 Offset: 0x1CDCE74 VA: 0x1CE0E74
	private static void SetSocketOption_internal(SafeSocketHandle safeHandle, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x1CE75E0 Offset: 0x1CE35E0 VA: 0x1CE75E0
	private static void SetSocketOption_icall(IntPtr socket, SocketOptionLevel level, SocketOptionName name, object obj_val, byte[] byte_val, int int_val, out int error) { }

	// RVA: 0x1CE03E4 Offset: 0x1CDC3E4 VA: 0x1CE03E4
	public int IOControl(int ioControlCode, byte[] optionInValue, byte[] optionOutValue) { }

	// RVA: 0x1CE75E4 Offset: 0x1CE35E4 VA: 0x1CE75E4
	private static int IOControl_internal(SafeSocketHandle safeHandle, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x1CE773C Offset: 0x1CE373C VA: 0x1CE773C
	private static int IOControl_icall(IntPtr sock, int ioctl_code, byte[] input, byte[] output, out int error) { }

	// RVA: 0x1CE40B8 Offset: 0x1CE00B8 VA: 0x1CE40B8
	public void Close() { }

	// RVA: 0x1CDB760 Offset: 0x1CD7760 VA: 0x1CDB760
	public void Close(int timeout) { }

	// RVA: 0x1CE7740 Offset: 0x1CE3740 VA: 0x1CE7740
	internal static void Close_icall(IntPtr socket, out int error) { }

	// RVA: 0x1CE7744 Offset: 0x1CE3744 VA: 0x1CE7744
	public void Shutdown(SocketShutdown how) { }

	// RVA: 0x1CE0D44 Offset: 0x1CDCD44 VA: 0x1CE0D44
	private static void Shutdown_internal(SafeSocketHandle safeHandle, SocketShutdown how, out int error) { }

	// RVA: 0x1CE7844 Offset: 0x1CE3844 VA: 0x1CE7844
	internal static void Shutdown_icall(IntPtr socket, SocketShutdown how, out int error) { }

	// RVA: 0x1CE7848 Offset: 0x1CE3848 VA: 0x1CE7848 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1CE78A8 Offset: 0x1CE38A8 VA: 0x1CE78A8
	private void Linger(IntPtr handle) { }

	// RVA: 0x1CE1210 Offset: 0x1CDD210 VA: 0x1CE1210
	private void ThrowIfDisposedAndClosed() { }

	// RVA: 0x1CE47C8 Offset: 0x1CE07C8 VA: 0x1CE47C8
	private void ThrowIfBufferNull(byte[] buffer) { }

	// RVA: 0x1CE481C Offset: 0x1CE081C VA: 0x1CE481C
	private void ThrowIfBufferOutOfRange(byte[] buffer, int offset, int size) { }

	// RVA: 0x1CE15D4 Offset: 0x1CDD5D4 VA: 0x1CE15D4
	private void ThrowIfUdp() { }

	// RVA: 0x1CE2330 Offset: 0x1CDE330 VA: 0x1CE2330
	private SocketAsyncResult ValidateEndIAsyncResult(IAsyncResult ares, string methodName, string argName) { }

	// RVA: 0x1CE20B4 Offset: 0x1CDE0B4 VA: 0x1CE20B4
	private void QueueIOSelectorJob(SemaphoreSlim sem, IntPtr handle, IOSelectorJob job) { }

	// RVA: 0x1CE35EC Offset: 0x1CDF5EC VA: 0x1CE35EC
	private void InitSocketAsyncEventArgs(SocketAsyncEventArgs e, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x1CE7B78 Offset: 0x1CE3B78 VA: 0x1CE7B78
	private SocketAsyncOperation SocketOperationToSocketAsyncOperation(SocketOperation op) { }

	// RVA: 0x1CE27C4 Offset: 0x1CDE7C4 VA: 0x1CE27C4
	private IPEndPoint RemapIPEndPoint(IPEndPoint input) { }

	// RVA: 0x1CE7CD8 Offset: 0x1CE3CD8 VA: 0x1CE7CD8
	internal static void cancel_blocking_socket_operation(Thread thread) { }

	// RVA: 0x1CE7CDC Offset: 0x1CE3CDC VA: 0x1CE7CDC
	internal static int get_FamilyHint() { }

	// RVA: 0x1CE7D5C Offset: 0x1CE3D5C VA: 0x1CE7D5C
	private static bool IsProtocolSupported_internal(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x1CE0BF4 Offset: 0x1CDCBF4 VA: 0x1CE0BF4
	private static bool IsProtocolSupported(NetworkInterfaceComponent networkInterface) { }

	// RVA: 0x1CE7D60 Offset: 0x1CE3D60 VA: 0x1CE7D60
	private static void .cctor() { }
}

// Namespace: System.Net.Sockets
[Serializable]
public class SocketException : Win32Exception // TypeDefIndex: 4343
{
	// Fields
	private EndPoint m_EndPoint; // 0x90

	// Properties
	public override string Message { get; }
	public SocketError SocketErrorCode { get; }

	// Methods

	// RVA: 0x1CECA40 Offset: 0x1CE8A40 VA: 0x1CECA40
	private static int WSAGetLastError_icall() { }

	// RVA: 0x1CDEF24 Offset: 0x1CDAF24 VA: 0x1CDEF24
	public void .ctor() { }

	// RVA: 0x1CECA44 Offset: 0x1CE8A44 VA: 0x1CECA44
	internal void .ctor(int error, string message) { }

	// RVA: 0x1CDAEC4 Offset: 0x1CD6EC4 VA: 0x1CDAEC4
	public void .ctor(int errorCode) { }

	// RVA: 0x1CDFB68 Offset: 0x1CDBB68 VA: 0x1CDFB68
	internal void .ctor(SocketError socketError) { }

	// RVA: 0x1CECA4C Offset: 0x1CE8A4C VA: 0x1CECA4C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1CECA54 Offset: 0x1CE8A54 VA: 0x1CECA54 Slot: 5
	public override string get_Message() { }

	// RVA: 0x1CE3FF0 Offset: 0x1CDFFF0 VA: 0x1CE3FF0
	public SocketError get_SocketErrorCode() { }
}

// Namespace: System.Net.Sockets
public enum AddressFamily // TypeDefIndex: 4344
{
	// Fields
	public int value__; // 0x0
	public const AddressFamily Unknown = -1;
	public const AddressFamily Unspecified = 0;
	public const AddressFamily Unix = 1;
	public const AddressFamily InterNetwork = 2;
	public const AddressFamily ImpLink = 3;
	public const AddressFamily Pup = 4;
	public const AddressFamily Chaos = 5;
	public const AddressFamily NS = 6;
	public const AddressFamily Ipx = 6;
	public const AddressFamily Iso = 7;
	public const AddressFamily Osi = 7;
	public const AddressFamily Ecma = 8;
	public const AddressFamily DataKit = 9;
	public const AddressFamily Ccitt = 10;
	public const AddressFamily Sna = 11;
	public const AddressFamily DecNet = 12;
	public const AddressFamily DataLink = 13;
	public const AddressFamily Lat = 14;
	public const AddressFamily HyperChannel = 15;
	public const AddressFamily AppleTalk = 16;
	public const AddressFamily NetBios = 17;
	public const AddressFamily VoiceView = 18;
	public const AddressFamily FireFox = 19;
	public const AddressFamily Banyan = 21;
	public const AddressFamily Atm = 22;
	public const AddressFamily InterNetworkV6 = 23;
	public const AddressFamily Cluster = 24;
	public const AddressFamily Ieee12844 = 25;
	public const AddressFamily Irda = 26;
	public const AddressFamily NetworkDesigners = 28;
	public const AddressFamily Max = 29;
}

// Namespace: System.Net.Sockets
public enum IOControlCode // TypeDefIndex: 4345
{
	// Fields
	public long value__; // 0x0
	public const IOControlCode AsyncIO = 2147772029;
	public const IOControlCode NonBlockingIO = 2147772030;
	public const IOControlCode DataToRead = 1074030207;
	public const IOControlCode OobDataRead = 1074033415;
	public const IOControlCode AssociateHandle = 2281701377;
	public const IOControlCode EnableCircularQueuing = 671088642;
	public const IOControlCode Flush = 671088644;
	public const IOControlCode GetBroadcastAddress = 1207959557;
	public const IOControlCode GetExtensionFunctionPointer = 3355443206;
	public const IOControlCode GetQos = 3355443207;
	public const IOControlCode GetGroupQos = 3355443208;
	public const IOControlCode MultipointLoopback = 2281701385;
	public const IOControlCode MulticastScope = 2281701386;
	public const IOControlCode SetQos = 2281701387;
	public const IOControlCode SetGroupQos = 2281701388;
	public const IOControlCode TranslateHandle = 3355443213;
	public const IOControlCode RoutingInterfaceQuery = 3355443220;
	public const IOControlCode RoutingInterfaceChange = 2281701397;
	public const IOControlCode AddressListQuery = 1207959574;
	public const IOControlCode AddressListChange = 671088663;
	public const IOControlCode QueryTargetPnpHandle = 1207959576;
	public const IOControlCode NamespaceChange = 2281701401;
	public const IOControlCode AddressListSort = 3355443225;
	public const IOControlCode ReceiveAll = 2550136833;
	public const IOControlCode ReceiveAllMulticast = 2550136834;
	public const IOControlCode ReceiveAllIgmpMulticast = 2550136835;
	public const IOControlCode KeepAliveValues = 2550136836;
	public const IOControlCode AbsorbRouterAlert = 2550136837;
	public const IOControlCode UnicastInterface = 2550136838;
	public const IOControlCode LimitBroadcasts = 2550136839;
	public const IOControlCode BindToInterface = 2550136840;
	public const IOControlCode MulticastInterface = 2550136841;
	public const IOControlCode AddMulticastGroupOnInterface = 2550136842;
	public const IOControlCode DeleteMulticastGroupFromInterface = 2550136843;
}

// Namespace: System.Net.Sockets
public struct IPPacketInformation // TypeDefIndex: 4346
{
	// Fields
	private IPAddress address; // 0x0
	private int networkInterface; // 0x8

	// Methods

	// RVA: 0x1CECAE4 Offset: 0x1CE8AE4 VA: 0x1CECAE4 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1CECB80 Offset: 0x1CE8B80 VA: 0x1CECB80 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Net.Sockets
public enum IPProtectionLevel // TypeDefIndex: 4347
{
	// Fields
	public int value__; // 0x0
	public const IPProtectionLevel Unspecified = -1;
	public const IPProtectionLevel Unrestricted = 10;
	public const IPProtectionLevel EdgeRestricted = 20;
	public const IPProtectionLevel Restricted = 30;
}

// Namespace: System.Net.Sockets
public class LingerOption // TypeDefIndex: 4348
{
	// Fields
	private bool enabled; // 0x10
	private int lingerTime; // 0x14

	// Properties
	public bool Enabled { set; }
	public int LingerTime { set; }

	// Methods

	// RVA: 0x1CE7A10 Offset: 0x1CE3A10 VA: 0x1CE7A10
	public void .ctor(bool enable, int seconds) { }

	// RVA: 0x1CECBC4 Offset: 0x1CE8BC4 VA: 0x1CECBC4
	public void set_Enabled(bool value) { }

	// RVA: 0x1CECBCC Offset: 0x1CE8BCC VA: 0x1CECBCC
	public void set_LingerTime(int value) { }
}

// Namespace: System.Net.Sockets
public class MulticastOption // TypeDefIndex: 4349
{
	// Fields
	private IPAddress group; // 0x10
	private IPAddress localAddress; // 0x18
	private int ifIndex; // 0x20

	// Properties
	public IPAddress Group { set; }
	public IPAddress LocalAddress { set; }

	// Methods

	// RVA: 0x1CECBD4 Offset: 0x1CE8BD4 VA: 0x1CECBD4
	public void .ctor(IPAddress group) { }

	// RVA: 0x1CECCB4 Offset: 0x1CE8CB4 VA: 0x1CECCB4
	public void set_Group(IPAddress value) { }

	// RVA: 0x1CECCA8 Offset: 0x1CE8CA8 VA: 0x1CECCA8
	public void set_LocalAddress(IPAddress value) { }
}

// Namespace: System.Net.Sockets
public class IPv6MulticastOption // TypeDefIndex: 4350
{
	// Fields
	private IPAddress m_Group; // 0x10
	private long m_Interface; // 0x18

	// Properties
	public IPAddress Group { set; }
	public long InterfaceIndex { set; }

	// Methods

	// RVA: 0x1CECCBC Offset: 0x1CE8CBC VA: 0x1CECCBC
	public void .ctor(IPAddress group) { }

	// RVA: 0x1CECD3C Offset: 0x1CE8D3C VA: 0x1CECD3C
	public void set_Group(IPAddress value) { }

	// RVA: 0x1CECD94 Offset: 0x1CE8D94 VA: 0x1CECD94
	public void set_InterfaceIndex(long value) { }
}

// Namespace: System.Net.Sockets
public enum ProtocolType // TypeDefIndex: 4351
{
	// Fields
	public int value__; // 0x0
	public const ProtocolType IP = 0;
	public const ProtocolType IPv6HopByHopOptions = 0;
	public const ProtocolType Icmp = 1;
	public const ProtocolType Igmp = 2;
	public const ProtocolType Ggp = 3;
	public const ProtocolType IPv4 = 4;
	public const ProtocolType Tcp = 6;
	public const ProtocolType Pup = 12;
	public const ProtocolType Udp = 17;
	public const ProtocolType Idp = 22;
	public const ProtocolType IPv6 = 41;
	public const ProtocolType IPv6RoutingHeader = 43;
	public const ProtocolType IPv6FragmentHeader = 44;
	public const ProtocolType IPSecEncapsulatingSecurityPayload = 50;
	public const ProtocolType IPSecAuthenticationHeader = 51;
	public const ProtocolType IcmpV6 = 58;
	public const ProtocolType IPv6NoNextHeader = 59;
	public const ProtocolType IPv6DestinationOptions = 60;
	public const ProtocolType ND = 77;
	public const ProtocolType Raw = 255;
	public const ProtocolType Unspecified = 0;
	public const ProtocolType Ipx = 1000;
	public const ProtocolType Spx = 1256;
	public const ProtocolType SpxII = 1257;
	public const ProtocolType Unknown = -1;
}

// Namespace: System.Net.Sockets
public enum SelectMode // TypeDefIndex: 4352
{
	// Fields
	public int value__; // 0x0
	public const SelectMode SelectRead = 0;
	public const SelectMode SelectWrite = 1;
	public const SelectMode SelectError = 2;
}

// Namespace: System.Net.Sockets
public enum SocketAsyncOperation // TypeDefIndex: 4353
{
	// Fields
	public int value__; // 0x0
	public const SocketAsyncOperation None = 0;
	public const SocketAsyncOperation Accept = 1;
	public const SocketAsyncOperation Connect = 2;
	public const SocketAsyncOperation Disconnect = 3;
	public const SocketAsyncOperation Receive = 4;
	public const SocketAsyncOperation ReceiveFrom = 5;
	public const SocketAsyncOperation ReceiveMessageFrom = 6;
	public const SocketAsyncOperation Send = 7;
	public const SocketAsyncOperation SendPackets = 8;
	public const SocketAsyncOperation SendTo = 9;
}

// Namespace: System.Net.Sockets
public class SendPacketsElement // TypeDefIndex: 4354
{
	// Fields
	internal string m_FilePath; // 0x10
	internal byte[] m_Buffer; // 0x18
	internal int m_Offset; // 0x20
	internal int m_Count; // 0x24
	private bool m_endOfPacket; // 0x28

	// Methods

	// RVA: 0x1CECDF0 Offset: 0x1CE8DF0 VA: 0x1CECDF0
	private void .ctor() { }
}

// Namespace: System.Net.Sockets
public enum SocketError // TypeDefIndex: 4355
{
	// Fields
	public int value__; // 0x0
	public const SocketError Success = 0;
	public const SocketError SocketError = -1;
	public const SocketError Interrupted = 10004;
	public const SocketError AccessDenied = 10013;
	public const SocketError Fault = 10014;
	public const SocketError InvalidArgument = 10022;
	public const SocketError TooManyOpenSockets = 10024;
	public const SocketError WouldBlock = 10035;
	public const SocketError InProgress = 10036;
	public const SocketError AlreadyInProgress = 10037;
	public const SocketError NotSocket = 10038;
	public const SocketError DestinationAddressRequired = 10039;
	public const SocketError MessageSize = 10040;
	public const SocketError ProtocolType = 10041;
	public const SocketError ProtocolOption = 10042;
	public const SocketError ProtocolNotSupported = 10043;
	public const SocketError SocketNotSupported = 10044;
	public const SocketError OperationNotSupported = 10045;
	public const SocketError ProtocolFamilyNotSupported = 10046;
	public const SocketError AddressFamilyNotSupported = 10047;
	public const SocketError AddressAlreadyInUse = 10048;
	public const SocketError AddressNotAvailable = 10049;
	public const SocketError NetworkDown = 10050;
	public const SocketError NetworkUnreachable = 10051;
	public const SocketError NetworkReset = 10052;
	public const SocketError ConnectionAborted = 10053;
	public const SocketError ConnectionReset = 10054;
	public const SocketError NoBufferSpaceAvailable = 10055;
	public const SocketError IsConnected = 10056;
	public const SocketError NotConnected = 10057;
	public const SocketError Shutdown = 10058;
	public const SocketError TimedOut = 10060;
	public const SocketError ConnectionRefused = 10061;
	public const SocketError HostDown = 10064;
	public const SocketError HostUnreachable = 10065;
	public const SocketError ProcessLimit = 10067;
	public const SocketError SystemNotReady = 10091;
	public const SocketError VersionNotSupported = 10092;
	public const SocketError NotInitialized = 10093;
	public const SocketError Disconnecting = 10101;
	public const SocketError TypeNotFound = 10109;
	public const SocketError HostNotFound = 11001;
	public const SocketError TryAgain = 11002;
	public const SocketError NoRecovery = 11003;
	public const SocketError NoData = 11004;
	public const SocketError IOPending = 997;
	public const SocketError OperationAborted = 995;
}

// Namespace: System.Net.Sockets
[Flags]
public enum SocketFlags // TypeDefIndex: 4356
{
	// Fields
	public int value__; // 0x0
	public const SocketFlags None = 0;
	public const SocketFlags OutOfBand = 1;
	public const SocketFlags Peek = 2;
	public const SocketFlags DontRoute = 4;
	public const SocketFlags MaxIOVectorLength = 16;
	public const SocketFlags Truncated = 256;
	public const SocketFlags ControlDataTruncated = 512;
	public const SocketFlags Broadcast = 1024;
	public const SocketFlags Multicast = 2048;
	public const SocketFlags Partial = 32768;
}

// Namespace: System.Net.Sockets
public enum SocketOptionLevel // TypeDefIndex: 4357
{
	// Fields
	public int value__; // 0x0
	public const SocketOptionLevel Socket = 65535;
	public const SocketOptionLevel IP = 0;
	public const SocketOptionLevel IPv6 = 41;
	public const SocketOptionLevel Tcp = 6;
	public const SocketOptionLevel Udp = 17;
}

// Namespace: System.Net.Sockets
public enum SocketOptionName // TypeDefIndex: 4358
{
	// Fields
	public int value__; // 0x0
	public const SocketOptionName Debug = 1;
	public const SocketOptionName AcceptConnection = 2;
	public const SocketOptionName ReuseAddress = 4;
	public const SocketOptionName KeepAlive = 8;
	public const SocketOptionName DontRoute = 16;
	public const SocketOptionName Broadcast = 32;
	public const SocketOptionName UseLoopback = 64;
	public const SocketOptionName Linger = 128;
	public const SocketOptionName OutOfBandInline = 256;
	public const SocketOptionName DontLinger = -129;
	public const SocketOptionName ExclusiveAddressUse = -5;
	public const SocketOptionName SendBuffer = 4097;
	public const SocketOptionName ReceiveBuffer = 4098;
	public const SocketOptionName SendLowWater = 4099;
	public const SocketOptionName ReceiveLowWater = 4100;
	public const SocketOptionName SendTimeout = 4101;
	public const SocketOptionName ReceiveTimeout = 4102;
	public const SocketOptionName Error = 4103;
	public const SocketOptionName Type = 4104;
	public const SocketOptionName ReuseUnicastPort = 12295;
	public const SocketOptionName MaxConnections = 2147483647;
	public const SocketOptionName IPOptions = 1;
	public const SocketOptionName HeaderIncluded = 2;
	public const SocketOptionName TypeOfService = 3;
	public const SocketOptionName IpTimeToLive = 4;
	public const SocketOptionName MulticastInterface = 9;
	public const SocketOptionName MulticastTimeToLive = 10;
	public const SocketOptionName MulticastLoopback = 11;
	public const SocketOptionName AddMembership = 12;
	public const SocketOptionName DropMembership = 13;
	public const SocketOptionName DontFragment = 14;
	public const SocketOptionName AddSourceMembership = 15;
	public const SocketOptionName DropSourceMembership = 16;
	public const SocketOptionName BlockSource = 17;
	public const SocketOptionName UnblockSource = 18;
	public const SocketOptionName PacketInformation = 19;
	public const SocketOptionName HopLimit = 21;
	public const SocketOptionName IPProtectionLevel = 23;
	public const SocketOptionName IPv6Only = 27;
	public const SocketOptionName NoDelay = 1;
	public const SocketOptionName BsdUrgent = 2;
	public const SocketOptionName Expedited = 2;
	public const SocketOptionName NoChecksum = 1;
	public const SocketOptionName ChecksumCoverage = 20;
	public const SocketOptionName UpdateAcceptContext = 28683;
	public const SocketOptionName UpdateConnectContext = 28688;
}

// Namespace: System.Net.Sockets
public enum SocketShutdown // TypeDefIndex: 4359
{
	// Fields
	public int value__; // 0x0
	public const SocketShutdown Receive = 0;
	public const SocketShutdown Send = 1;
	public const SocketShutdown Both = 2;
}

// Namespace: System.Net.Sockets
public enum SocketType // TypeDefIndex: 4360
{
	// Fields
	public int value__; // 0x0
	public const SocketType Stream = 1;
	public const SocketType Dgram = 2;
	public const SocketType Raw = 3;
	public const SocketType Rdm = 4;
	public const SocketType Seqpacket = 5;
	public const SocketType Unknown = -1;
}

// Namespace: System.Net.Sockets
public class TcpClient : IDisposable // TypeDefIndex: 4361
{
	// Fields
	private Socket m_ClientSocket; // 0x10
	private bool m_Active; // 0x18
	private NetworkStream m_DataStream; // 0x20
	private AddressFamily m_Family; // 0x28
	private bool m_CleanedUp; // 0x2C

	// Properties
	public Socket Client { get; set; }

	// Methods

	// RVA: 0x1CECDF8 Offset: 0x1CE8DF8 VA: 0x1CECDF8
	public void .ctor() { }

	// RVA: 0x1CECE18 Offset: 0x1CE8E18 VA: 0x1CECE18
	public void .ctor(AddressFamily family) { }

	// RVA: 0x1CECF98 Offset: 0x1CE8F98 VA: 0x1CECF98
	public Socket get_Client() { }

	// RVA: 0x1CECFA0 Offset: 0x1CE8FA0 VA: 0x1CECFA0
	public void set_Client(Socket value) { }

	// RVA: 0x1CECFA8 Offset: 0x1CE8FA8 VA: 0x1CECFA8
	public void Connect(string hostname, int port) { }

	// RVA: 0x1CED694 Offset: 0x1CE9694 VA: 0x1CED694
	public void Connect(IPEndPoint remoteEP) { }

	// RVA: 0x1CED790 Offset: 0x1CE9790 VA: 0x1CED790
	public IAsyncResult BeginConnect(string host, int port, AsyncCallback requestCallback, object state) { }

	// RVA: 0x1CED7F8 Offset: 0x1CE97F8 VA: 0x1CED7F8
	public void EndConnect(IAsyncResult asyncResult) { }

	// RVA: 0x1CED83C Offset: 0x1CE983C VA: 0x1CED83C
	public Task ConnectAsync(string host, int port) { }

	// RVA: 0x1CED9A8 Offset: 0x1CE99A8 VA: 0x1CED9A8
	public NetworkStream GetStream() { }

	// RVA: 0x1CEDAEC Offset: 0x1CE9AEC VA: 0x1CEDAEC Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1CEDCC0 Offset: 0x1CE9CC0 VA: 0x1CEDCC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1CEDCD0 Offset: 0x1CE9CD0 VA: 0x1CEDCD0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1CECF24 Offset: 0x1CE8F24 VA: 0x1CECF24
	private void initialize() { }
}

// Namespace: System.Net.Sockets
[Flags]
public enum TransmitFileOptions // TypeDefIndex: 4362
{
	// Fields
	public int value__; // 0x0
	public const TransmitFileOptions UseDefaultWorkerThread = 0;
	public const TransmitFileOptions Disconnect = 1;
	public const TransmitFileOptions ReuseSocket = 2;
	public const TransmitFileOptions WriteBehind = 4;
	public const TransmitFileOptions UseSystemThread = 16;
	public const TransmitFileOptions UseKernelApc = 32;
}

// Namespace: System.Net.Sockets
internal sealed class SafeSocketHandle : SafeHandleMinusOneIsInvalid // TypeDefIndex: 4363
{
	// Fields
	private List<Thread> blocking_threads; // 0x20
	private Dictionary<Thread, StackTrace> threads_stacktraces; // 0x28
	private bool in_cleanup; // 0x30
	private const int SOCKET_CLOSED = 10004;
	private const int ABORT_RETRIES = 10;
	private static bool THROW_ON_ABORT_RETRIES; // 0x0

	// Methods

	// RVA: 0x1CDEE48 Offset: 0x1CDAE48 VA: 0x1CDEE48
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x1CEDD60 Offset: 0x1CE9D60 VA: 0x1CEDD60
	internal void .ctor() { }

	// RVA: 0x1CEDD6C Offset: 0x1CE9D6C VA: 0x1CEDD6C Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x1CE2508 Offset: 0x1CDE508 VA: 0x1CE2508
	public void RegisterForBlockingSyscall() { }

	// RVA: 0x1CEE2FC Offset: 0x1CEA2FC VA: 0x1CEE2FC
	public void UnRegisterForBlockingSyscall() { }

	// RVA: 0x1CEE4E8 Offset: 0x1CEA4E8 VA: 0x1CEE4E8
	private static void .cctor() { }
}

// Namespace: System.Net.Sockets
public class SocketAsyncEventArgs : EventArgs, IDisposable // TypeDefIndex: 4364
{
	// Fields
	private bool disposed; // 0x10
	internal int in_progress; // 0x14
	private EndPoint remote_ep; // 0x18
	private Socket current_socket; // 0x20
	internal SocketAsyncResult socket_async_result; // 0x28
	[CompilerGenerated]
	private Exception <ConnectByNameError>k__BackingField; // 0x30
	[CompilerGenerated]
	private Socket <AcceptSocket>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <BytesTransferred>k__BackingField; // 0x40
	[CompilerGenerated]
	private bool <DisconnectReuseSocket>k__BackingField; // 0x44
	[CompilerGenerated]
	private SocketAsyncOperation <LastOperation>k__BackingField; // 0x48
	[CompilerGenerated]
	private IPPacketInformation <ReceiveMessageFromPacketInfo>k__BackingField; // 0x50
	[CompilerGenerated]
	private SendPacketsElement[] <SendPacketsElements>k__BackingField; // 0x60
	[CompilerGenerated]
	private TransmitFileOptions <SendPacketsFlags>k__BackingField; // 0x68
	[CompilerGenerated]
	private int <SendPacketsSendSize>k__BackingField; // 0x6C
	[CompilerGenerated]
	private SocketError <SocketError>k__BackingField; // 0x70
	[CompilerGenerated]
	private SocketFlags <SocketFlags>k__BackingField; // 0x74
	[CompilerGenerated]
	private object <UserToken>k__BackingField; // 0x78
	[CompilerGenerated]
	private EventHandler<SocketAsyncEventArgs> Completed; // 0x80
	private Memory<byte> _buffer; // 0x88
	private int _offset; // 0x98
	private int _count; // 0x9C
	private bool _bufferIsExplicitArray; // 0xA0
	private IList<ArraySegment<byte>> _bufferList; // 0xA8
	private List<ArraySegment<byte>> _bufferListInternal; // 0xB0

	// Properties
	private Exception ConnectByNameError { set; }
	public Socket AcceptSocket { get; set; }
	public int BytesTransferred { get; set; }
	public SocketAsyncOperation LastOperation { get; set; }
	public EndPoint RemoteEndPoint { get; set; }
	[MonoTODO("unused property")]
	public int SendPacketsSendSize { set; }
	public SocketError SocketError { get; set; }
	public SocketFlags SocketFlags { get; set; }
	public object UserToken { get; set; }
	internal Socket CurrentSocket { get; }
	public byte[] Buffer { get; }
	public Memory<byte> MemoryBuffer { get; }
	public int Offset { get; }
	public int Count { get; }
	public IList<ArraySegment<byte>> BufferList { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1CEE57C Offset: 0x1CEA57C VA: 0x1CEE57C
	private void set_ConnectByNameError(Exception value) { }

	[CompilerGenerated]
	// RVA: 0x1CEE584 Offset: 0x1CEA584 VA: 0x1CEE584
	public Socket get_AcceptSocket() { }

	[CompilerGenerated]
	// RVA: 0x1CEE58C Offset: 0x1CEA58C VA: 0x1CEE58C
	public void set_AcceptSocket(Socket value) { }

	[CompilerGenerated]
	// RVA: 0x1CEE594 Offset: 0x1CEA594 VA: 0x1CEE594
	public int get_BytesTransferred() { }

	[CompilerGenerated]
	// RVA: 0x1CEE59C Offset: 0x1CEA59C VA: 0x1CEE59C
	private void set_BytesTransferred(int value) { }

	[CompilerGenerated]
	// RVA: 0x1CEE5A4 Offset: 0x1CEA5A4 VA: 0x1CEE5A4
	public SocketAsyncOperation get_LastOperation() { }

	[CompilerGenerated]
	// RVA: 0x1CEE5AC Offset: 0x1CEA5AC VA: 0x1CEE5AC
	private void set_LastOperation(SocketAsyncOperation value) { }

	// RVA: 0x1CEE5B4 Offset: 0x1CEA5B4 VA: 0x1CEE5B4
	public EndPoint get_RemoteEndPoint() { }

	// RVA: 0x1CEE5BC Offset: 0x1CEA5BC VA: 0x1CEE5BC
	public void set_RemoteEndPoint(EndPoint value) { }

	[CompilerGenerated]
	// RVA: 0x1CEE5C4 Offset: 0x1CEA5C4 VA: 0x1CEE5C4
	public void set_SendPacketsSendSize(int value) { }

	[CompilerGenerated]
	// RVA: 0x1CEE5CC Offset: 0x1CEA5CC VA: 0x1CEE5CC
	public SocketError get_SocketError() { }

	[CompilerGenerated]
	// RVA: 0x1CEE5D4 Offset: 0x1CEA5D4 VA: 0x1CEE5D4
	public void set_SocketError(SocketError value) { }

	[CompilerGenerated]
	// RVA: 0x1CEE5DC Offset: 0x1CEA5DC VA: 0x1CEE5DC
	public SocketFlags get_SocketFlags() { }

	[CompilerGenerated]
	// RVA: 0x1CEE5E4 Offset: 0x1CEA5E4 VA: 0x1CEE5E4
	public void set_SocketFlags(SocketFlags value) { }

	[CompilerGenerated]
	// RVA: 0x1CEE5EC Offset: 0x1CEA5EC VA: 0x1CEE5EC
	public object get_UserToken() { }

	[CompilerGenerated]
	// RVA: 0x1CEE5F4 Offset: 0x1CEA5F4 VA: 0x1CEE5F4
	public void set_UserToken(object value) { }

	[CompilerGenerated]
	// RVA: 0x1CEE5FC Offset: 0x1CEA5FC VA: 0x1CEE5FC
	public void add_Completed(EventHandler<SocketAsyncEventArgs> value) { }

	[CompilerGenerated]
	// RVA: 0x1CEE6AC Offset: 0x1CEA6AC VA: 0x1CEE6AC
	public void remove_Completed(EventHandler<SocketAsyncEventArgs> value) { }

	// RVA: 0x1CEE75C Offset: 0x1CEA75C VA: 0x1CEE75C
	public void .ctor() { }

	// RVA: 0x1CE8564 Offset: 0x1CE4564 VA: 0x1CE8564
	internal void .ctor(bool flowExecutionContext) { }

	// RVA: 0x1CEE808 Offset: 0x1CEA808 VA: 0x1CEE808 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1CEE818 Offset: 0x1CEA818 VA: 0x1CEE818
	private void Dispose(bool disposing) { }

	// RVA: 0x1CEE82C Offset: 0x1CEA82C VA: 0x1CEE82C Slot: 4
	public void Dispose() { }

	// RVA: 0x1CE44FC Offset: 0x1CE04FC VA: 0x1CE44FC
	internal void SetConnectByNameError(Exception error) { }

	// RVA: 0x1CE7CD0 Offset: 0x1CE3CD0 VA: 0x1CE7CD0
	internal void SetBytesTransferred(int value) { }

	// RVA: 0x1CEE890 Offset: 0x1CEA890 VA: 0x1CEE890
	internal Socket get_CurrentSocket() { }

	// RVA: 0x1CEE898 Offset: 0x1CEA898 VA: 0x1CEE898
	internal void SetCurrentSocket(Socket socket) { }

	// RVA: 0x1CE7C14 Offset: 0x1CE3C14 VA: 0x1CE7C14
	internal void SetLastOperation(SocketAsyncOperation op) { }

	// RVA: 0x1CEE8A0 Offset: 0x1CEA8A0 VA: 0x1CEE8A0
	internal void Complete_internal() { }

	// RVA: 0x1CEE8C8 Offset: 0x1CEA8C8 VA: 0x1CEE8C8 Slot: 5
	protected virtual void OnCompleted(SocketAsyncEventArgs e) { }

	// RVA: 0x1CE5944 Offset: 0x1CE1944 VA: 0x1CE5944
	public byte[] get_Buffer() { }

	// RVA: 0x1CEE8F0 Offset: 0x1CEA8F0 VA: 0x1CEE8F0
	public Memory<byte> get_MemoryBuffer() { }

	// RVA: 0x1CEE8FC Offset: 0x1CEA8FC VA: 0x1CEE8FC
	public int get_Offset() { }

	// RVA: 0x1CEE904 Offset: 0x1CEA904 VA: 0x1CEE904
	public int get_Count() { }

	// RVA: 0x1CEE90C Offset: 0x1CEA90C VA: 0x1CEE90C
	public IList<ArraySegment<byte>> get_BufferList() { }

	// RVA: 0x1CEE914 Offset: 0x1CEA914 VA: 0x1CEE914
	public void SetBuffer(byte[] buffer, int offset, int count) { }

	// RVA: 0x1CDDA90 Offset: 0x1CD9A90 VA: 0x1CDDA90
	public void SetBuffer(Memory<byte> buffer) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SocketAsyncResult.<>c // TypeDefIndex: 4365
{
	// Fields
	public static readonly SocketAsyncResult.<>c <>9; // 0x0
	public static WaitCallback <>9__27_0; // 0x8

	// Methods

	// RVA: 0x1CEEAA0 Offset: 0x1CEAAA0 VA: 0x1CEEAA0
	private static void .cctor() { }

	// RVA: 0x1CEEB08 Offset: 0x1CEAB08 VA: 0x1CEEB08
	public void .ctor() { }

	// RVA: 0x1CEEB10 Offset: 0x1CEAB10 VA: 0x1CEEB10
	internal void <Complete>b__27_0(object state) { }
}

// Namespace: System.Net.Sockets
internal sealed class SocketAsyncResult : IOAsyncResult // TypeDefIndex: 4366
{
	// Fields
	public Socket socket; // 0x30
	public SocketOperation operation; // 0x38
	private Exception DelayedException; // 0x40
	public EndPoint EndPoint; // 0x48
	public Memory<byte> Buffer; // 0x50
	public int Offset; // 0x60
	public int Size; // 0x64
	public SocketFlags SockFlags; // 0x68
	public Socket AcceptSocket; // 0x70
	public IPAddress[] Addresses; // 0x78
	public int Port; // 0x80
	public IList<ArraySegment<byte>> Buffers; // 0x88
	public bool ReuseSocket; // 0x90
	public int CurrentAddress; // 0x94
	public Socket AcceptedSocket; // 0x98
	public int Total; // 0xA0
	internal int error; // 0xA4
	public int EndCalled; // 0xA8

	// Properties
	public IntPtr Handle { get; }
	public SocketError ErrorCode { get; }

	// Methods

	// RVA: 0x1CE208C Offset: 0x1CDE08C VA: 0x1CE208C
	public IntPtr get_Handle() { }

	// RVA: 0x1CEE800 Offset: 0x1CEA800 VA: 0x1CEE800
	public void .ctor() { }

	// RVA: 0x1CE7A48 Offset: 0x1CE3A48 VA: 0x1CE7A48
	public void Init(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x1CE2048 Offset: 0x1CDE048 VA: 0x1CE2048
	public void .ctor(Socket socket, AsyncCallback callback, object state, SocketOperation operation) { }

	// RVA: 0x1CE5034 Offset: 0x1CE1034 VA: 0x1CE5034
	public SocketError get_ErrorCode() { }

	// RVA: 0x1CE2468 Offset: 0x1CDE468 VA: 0x1CE2468
	public void CheckIfThrowDelayedException() { }

	// RVA: 0x1CEEA9C Offset: 0x1CEAA9C VA: 0x1CEEA9C Slot: 8
	internal override void CompleteDisposed() { }

	// RVA: 0x1CE6E98 Offset: 0x1CE2E98 VA: 0x1CE6E98
	public void Complete() { }

	// RVA: 0x1CE44F0 Offset: 0x1CE04F0 VA: 0x1CE44F0
	public void Complete(bool synch) { }

	// RVA: 0x1CE6418 Offset: 0x1CE2418 VA: 0x1CE6418
	public void Complete(int total) { }

	// RVA: 0x1CE3FF8 Offset: 0x1CDFFF8 VA: 0x1CE3FF8
	public void Complete(Exception e, bool synch) { }

	// RVA: 0x1CE63FC Offset: 0x1CE23FC VA: 0x1CE63FC
	public void Complete(Exception e) { }

	// RVA: 0x1CEAA5C Offset: 0x1CE6A5C VA: 0x1CEAA5C
	public void Complete(Socket s) { }

	// RVA: 0x1CEACD0 Offset: 0x1CE6CD0 VA: 0x1CEACD0
	public void Complete(Socket s, int total) { }
}

// Namespace: System.Net.Sockets
internal enum SocketOperation // TypeDefIndex: 4367
{
	// Fields
	public int value__; // 0x0
	public const SocketOperation Accept = 0;
	public const SocketOperation Connect = 1;
	public const SocketOperation Receive = 2;
	public const SocketOperation ReceiveFrom = 3;
	public const SocketOperation Send = 4;
	public const SocketOperation SendTo = 5;
	public const SocketOperation RecvJustCallback = 6;
	public const SocketOperation SendJustCallback = 7;
	public const SocketOperation Disconnect = 8;
	public const SocketOperation AcceptReceive = 9;
	public const SocketOperation ReceiveGeneric = 10;
	public const SocketOperation SendGeneric = 11;
}
