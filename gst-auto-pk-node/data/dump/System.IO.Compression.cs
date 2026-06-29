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

// Namespace: System.IO.Compression
public enum CompressionLevel // TypeDefIndex: 4107
{
	// Fields
	public int value__; // 0x0
	public const CompressionLevel Optimal = 0;
	public const CompressionLevel Fastest = 1;
	public const CompressionLevel NoCompression = 2;
}

// Namespace: System.IO.Compression
public enum CompressionMode // TypeDefIndex: 4108
{
	// Fields
	public int value__; // 0x0
	public const CompressionMode Decompress = 0;
	public const CompressionMode Compress = 1;
}

// Namespace: System.IO.Compression
public class GZipStream : Stream // TypeDefIndex: 4109
{
	// Fields
	private DeflateStream _deflateStream; // 0x28

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1D60148 Offset: 0x1D5C148 VA: 0x1D60148
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1D60150 Offset: 0x1D5C150 VA: 0x1D60150
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x1D60210 Offset: 0x1D5C210 VA: 0x1D60210 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1D60228 Offset: 0x1D5C228 VA: 0x1D60228 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1D60240 Offset: 0x1D5C240 VA: 0x1D60240 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1D60258 Offset: 0x1D5C258 VA: 0x1D60258 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1D602A4 Offset: 0x1D5C2A4 VA: 0x1D602A4 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1D602F0 Offset: 0x1D5C2F0 VA: 0x1D602F0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1D6033C Offset: 0x1D5C33C VA: 0x1D6033C Slot: 21
	public override void Flush() { }

	// RVA: 0x1D60370 Offset: 0x1D5C370 VA: 0x1D60370 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1D603BC Offset: 0x1D5C3BC VA: 0x1D603BC Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1D60408 Offset: 0x1D5C408 VA: 0x1D60408 Slot: 34
	public override int ReadByte() { }

	// RVA: 0x1D60428 Offset: 0x1D5C428 VA: 0x1D60428 Slot: 22
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1D604DC Offset: 0x1D5C4DC VA: 0x1D604DC Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1D60524 Offset: 0x1D5C524 VA: 0x1D60524 Slot: 32
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x1D60544 Offset: 0x1D5C544 VA: 0x1D60544 Slot: 33
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x1D60730 Offset: 0x1D5C730 VA: 0x1D60730 Slot: 26
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1D607E4 Offset: 0x1D5C7E4 VA: 0x1D607E4 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1D607F0 Offset: 0x1D5C7F0 VA: 0x1D607F0 Slot: 35
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1D60810 Offset: 0x1D5C810 VA: 0x1D60810 Slot: 36
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x1D60968 Offset: 0x1D5C968 VA: 0x1D60968 Slot: 18
	public override void CopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x1D60988 Offset: 0x1D5C988 VA: 0x1D60988 Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1D60A40 Offset: 0x1D5CA40 VA: 0x1D60A40 Slot: 24
	public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1D60A60 Offset: 0x1D5CA60 VA: 0x1D60A60 Slot: 25
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1D60B38 Offset: 0x1D5CB38 VA: 0x1D60B38 Slot: 28
	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1D60B58 Offset: 0x1D5CB58 VA: 0x1D60B58 Slot: 29
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1D6035C Offset: 0x1D5C35C VA: 0x1D6035C
	private void CheckDeflateStream() { }

	// RVA: 0x1D60C30 Offset: 0x1D5CC30 VA: 0x1D60C30
	private static void ThrowStreamClosedException() { }
}

// Namespace: 
private sealed class DeflateStream.ReadMethod : MulticastDelegate // TypeDefIndex: 4110
{
	// Methods

	// RVA: 0x1D61A78 Offset: 0x1D5DA78 VA: 0x1D61A78
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D62388 Offset: 0x1D5E388 VA: 0x1D62388 Slot: 12
	public virtual int Invoke(byte[] array, int offset, int count) { }

	// RVA: 0x1D61B2C Offset: 0x1D5DB2C VA: 0x1D61B2C Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x1D62088 Offset: 0x1D5E088 VA: 0x1D62088 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class DeflateStream.WriteMethod : MulticastDelegate // TypeDefIndex: 4111
{
	// Methods

	// RVA: 0x1D61E14 Offset: 0x1D5DE14 VA: 0x1D61E14
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D6239C Offset: 0x1D5E39C VA: 0x1D6239C Slot: 12
	public virtual void Invoke(byte[] array, int offset, int count) { }

	// RVA: 0x1D61EC8 Offset: 0x1D5DEC8 VA: 0x1D61EC8 Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] array, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x1D621F0 Offset: 0x1D5E1F0 VA: 0x1D621F0 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.IO.Compression
public class DeflateStream : Stream // TypeDefIndex: 4112
{
	// Fields
	private Stream base_stream; // 0x28
	private CompressionMode mode; // 0x30
	private bool leaveOpen; // 0x34
	private bool disposed; // 0x35
	private DeflateStreamNative native; // 0x38

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1D60C80 Offset: 0x1D5CC80 VA: 0x1D60C80
	public void .ctor(Stream stream, CompressionMode mode) { }

	// RVA: 0x1D60E0C Offset: 0x1D5CE0C VA: 0x1D60E0C
	public void .ctor(Stream stream, CompressionMode mode, bool leaveOpen) { }

	// RVA: 0x1D60208 Offset: 0x1D5C208 VA: 0x1D60208
	internal void .ctor(Stream stream, CompressionMode mode, bool leaveOpen, int windowsBits) { }

	// RVA: 0x1D60C8C Offset: 0x1D5CC8C VA: 0x1D60C8C
	internal void .ctor(Stream compressedStream, CompressionMode mode, bool leaveOpen, bool gzip) { }

	// RVA: 0x1D60F84 Offset: 0x1D5CF84 VA: 0x1D60F84
	public void .ctor(Stream stream, CompressionLevel compressionLevel, bool leaveOpen) { }

	// RVA: 0x1D60F90 Offset: 0x1D5CF90 VA: 0x1D60F90
	internal void .ctor(Stream stream, CompressionLevel compressionLevel, bool leaveOpen, bool gzip) { }

	// RVA: 0x1D60F98 Offset: 0x1D5CF98 VA: 0x1D60F98 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1D6102C Offset: 0x1D5D02C VA: 0x1D6102C Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1D61204 Offset: 0x1D5D204 VA: 0x1D61204
	private int ReadInternal(byte[] array, int offset, int count) { }

	// RVA: 0x1D60B30 Offset: 0x1D5CB30 VA: 0x1D60B30
	internal ValueTask<int> ReadAsyncMemory(Memory<byte> destination, CancellationToken cancellationToken) { }

	// RVA: 0x1D60618 Offset: 0x1D5C618 VA: 0x1D60618
	internal int ReadCore(Span<byte> destination) { }

	// RVA: 0x1D612BC Offset: 0x1D5D2BC VA: 0x1D612BC Slot: 32
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x1D6148C Offset: 0x1D5D48C VA: 0x1D6148C
	private void WriteInternal(byte[] array, int offset, int count) { }

	// RVA: 0x1D60C28 Offset: 0x1D5CC28 VA: 0x1D60C28
	internal ValueTask WriteAsyncMemory(ReadOnlyMemory<byte> source, CancellationToken cancellationToken) { }

	// RVA: 0x1D608E4 Offset: 0x1D5C8E4 VA: 0x1D608E4
	internal void WriteCore(ReadOnlySpan<byte> source) { }

	// RVA: 0x1D61534 Offset: 0x1D5D534 VA: 0x1D61534 Slot: 35
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1D61710 Offset: 0x1D5D710 VA: 0x1D61710 Slot: 21
	public override void Flush() { }

	// RVA: 0x1D61814 Offset: 0x1D5D814 VA: 0x1D61814 Slot: 22
	public override IAsyncResult BeginRead(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1D61BB0 Offset: 0x1D5DBB0 VA: 0x1D61BB0 Slot: 26
	public override IAsyncResult BeginWrite(byte[] array, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1D61F4C Offset: 0x1D5DF4C VA: 0x1D61F4C Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1D620B0 Offset: 0x1D5E0B0 VA: 0x1D620B0 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1D621FC Offset: 0x1D5E1FC VA: 0x1D621FC Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1D62234 Offset: 0x1D5E234 VA: 0x1D62234 Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1D6226C Offset: 0x1D5E26C VA: 0x1D6226C Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1D622A0 Offset: 0x1D5E2A0 VA: 0x1D622A0 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1D622A8 Offset: 0x1D5E2A8 VA: 0x1D622A8 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1D622E0 Offset: 0x1D5E2E0 VA: 0x1D622E0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1D62318 Offset: 0x1D5E318 VA: 0x1D62318 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1D62350 Offset: 0x1D5E350 VA: 0x1D62350 Slot: 13
	public override void set_Position(long value) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
private sealed class DeflateStreamNative.UnmanagedReadOrWrite : MulticastDelegate // TypeDefIndex: 4113
{
	// Methods

	// RVA: 0x1D625D8 Offset: 0x1D5E5D8 VA: 0x1D625D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D62D94 Offset: 0x1D5ED94 VA: 0x1D62D94 Slot: 12
	public virtual int Invoke(IntPtr buffer, int length, IntPtr data) { }
}

// Namespace: 
private sealed class DeflateStreamNative.SafeDeflateStreamHandle : SafeHandle // TypeDefIndex: 4114
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x1D62DA8 Offset: 0x1D5EDA8 VA: 0x1D62DA8 Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x1D62D80 Offset: 0x1D5ED80 VA: 0x1D62D80
	private void .ctor() { }

	// RVA: 0x1D62DB8 Offset: 0x1D5EDB8 VA: 0x1D62DB8 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: System.IO.Compression
internal class DeflateStreamNative // TypeDefIndex: 4115
{
	// Fields
	private DeflateStreamNative.UnmanagedReadOrWrite feeder; // 0x10
	private Stream base_stream; // 0x18
	private DeflateStreamNative.SafeDeflateStreamHandle z_stream; // 0x20
	private GCHandle data; // 0x28
	private bool disposed; // 0x30
	private byte[] io_buffer; // 0x38
	private Exception last_error; // 0x40

	// Methods

	// RVA: 0x1D625D0 Offset: 0x1D5E5D0 VA: 0x1D625D0
	private void .ctor() { }

	// RVA: 0x1D60E14 Offset: 0x1D5CE14 VA: 0x1D60E14
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x1D6271C Offset: 0x1D5E71C VA: 0x1D6271C Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1D610F4 Offset: 0x1D5D0F4 VA: 0x1D610F4
	public void Dispose(bool disposing) { }

	// RVA: 0x1D617C0 Offset: 0x1D5D7C0 VA: 0x1D617C0
	public void Flush() { }

	// RVA: 0x1D61244 Offset: 0x1D5D244 VA: 0x1D61244
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x1D614C8 Offset: 0x1D5D4C8 VA: 0x1D614C8
	public void WriteZStream(IntPtr buffer, int length) { }

	[MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
	// RVA: 0x1D623B0 Offset: 0x1D5E3B0 VA: 0x1D623B0
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1D629D4 Offset: 0x1D5E9D4 VA: 0x1D629D4
	private int UnmanagedRead(IntPtr buffer, int length) { }

	[MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
	// RVA: 0x1D624C0 Offset: 0x1D5E4C0 VA: 0x1D624C0
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1D62B94 Offset: 0x1D5EB94 VA: 0x1D62B94
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x1D62808 Offset: 0x1D5E808 VA: 0x1D62808
	private void CheckResult(int result, string where) { }

	// RVA: 0x1D62678 Offset: 0x1D5E678 VA: 0x1D62678
	private static extern DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x1D62D90 Offset: 0x1D5ED90 VA: 0x1D62D90
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x1D627A4 Offset: 0x1D5E7A4 VA: 0x1D627A4
	private static extern int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream) { }

	// RVA: 0x1D628DC Offset: 0x1D5E8DC VA: 0x1D628DC
	private static extern int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x1D62958 Offset: 0x1D5E958 VA: 0x1D62958
	private static extern int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }
}

// Namespace: 
[Flags]
private enum ContextAwareResult.StateFlags // TypeDefIndex: 4116
{
	// Fields
	public byte value__; // 0x0
	public const ContextAwareResult.StateFlags None = 0;
	public const ContextAwareResult.StateFlags CaptureIdentity = 1;
	public const ContextAwareResult.StateFlags CaptureContext = 2;
	public const ContextAwareResult.StateFlags ThreadSafeContextCopy = 4;
	public const ContextAwareResult.StateFlags PostBlockStarted = 8;
	public const ContextAwareResult.StateFlags PostBlockFinished = 16;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ContextAwareResult.<>c // TypeDefIndex: 4117
{
	// Fields
	public static readonly ContextAwareResult.<>c <>9; // 0x0
	public static ContextCallback <>9__17_0; // 0x8

	// Methods

	// RVA: 0x1D63B58 Offset: 0x1D5FB58 VA: 0x1D63B58
	private static void .cctor() { }

	// RVA: 0x1D63BC0 Offset: 0x1D5FBC0 VA: 0x1D63BC0
	public void .ctor() { }

	// RVA: 0x1D63BC8 Offset: 0x1D5FBC8 VA: 0x1D63BC8
	internal void <Complete>b__17_0(object s) { }
}

// Namespace: System.IO.Compression
internal enum BlockType // TypeDefIndex: 7650
{
	// Fields
	public int value__; // 0x0
	public const BlockType Uncompressed = 0;
	public const BlockType Static = 1;
	public const BlockType Dynamic = 2;
}

// Namespace: System.IO.Compression
internal sealed class CopyEncoder // TypeDefIndex: 7651
{
	// Methods

	// RVA: 0x1B22230 Offset: 0x1B1E230 VA: 0x1B22230
	public void GetBlock(DeflateInput input, OutputBuffer output, bool isFinal) { }

	// RVA: 0x1B224DC Offset: 0x1B1E4DC VA: 0x1B224DC
	private void WriteLenNLen(ushort len, OutputBuffer output) { }
}

// Namespace: 
[IsReadOnly]
internal struct DeflateInput.InputState // TypeDefIndex: 7652
{
	// Fields
	internal readonly int _count; // 0x0
	internal readonly int _startIndex; // 0x4

	// Methods

	// RVA: 0x1B22628 Offset: 0x1B1E628 VA: 0x1B22628
	internal void .ctor(int count, int startIndex) { }
}

// Namespace: System.IO.Compression
internal sealed class DeflateInput // TypeDefIndex: 7653
{
	// Fields
	[CompilerGenerated]
	private byte[] <Buffer>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x18
	[CompilerGenerated]
	private int <StartIndex>k__BackingField; // 0x1C

	// Properties
	internal byte[] Buffer { get; set; }
	internal int Count { get; set; }
	internal int StartIndex { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B225F0 Offset: 0x1B1E5F0 VA: 0x1B225F0
	internal byte[] get_Buffer() { }

	[CompilerGenerated]
	// RVA: 0x1B225F8 Offset: 0x1B1E5F8 VA: 0x1B225F8
	internal void set_Buffer(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x1B22600 Offset: 0x1B1E600 VA: 0x1B22600
	internal int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x1B22608 Offset: 0x1B1E608 VA: 0x1B22608
	internal void set_Count(int value) { }

	[CompilerGenerated]
	// RVA: 0x1B22610 Offset: 0x1B1E610 VA: 0x1B22610
	internal int get_StartIndex() { }

	[CompilerGenerated]
	// RVA: 0x1B22618 Offset: 0x1B1E618 VA: 0x1B22618
	internal void set_StartIndex(int value) { }

	// RVA: 0x1B22574 Offset: 0x1B1E574 VA: 0x1B22574
	internal void ConsumeBytes(int n) { }

	// RVA: 0x1B22620 Offset: 0x1B1E620 VA: 0x1B22620
	internal DeflateInput.InputState DumpState() { }

	// RVA: 0x1B22630 Offset: 0x1B1E630 VA: 0x1B22630
	internal void RestoreState(DeflateInput.InputState state) { }

	// RVA: 0x1B22638 Offset: 0x1B1E638 VA: 0x1B22638
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct DeflateManagedStream.<ReadAsyncCore>d__40 : IAsyncStateMachine // TypeDefIndex: 7654
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public Task<int> readTask; // 0x20
	public DeflateManagedStream <>4__this; // 0x28
	public CancellationToken cancellationToken; // 0x30
	public byte[] array; // 0x38
	public int offset; // 0x40
	public int count; // 0x44
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48

	// Methods

	// RVA: 0x1B242E4 Offset: 0x1B202E4 VA: 0x1B242E4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1B2484C Offset: 0x1B2084C VA: 0x1B2484C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct DeflateManagedStream.<WriteAsyncCore>d__47 : IAsyncStateMachine // TypeDefIndex: 7655
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public DeflateManagedStream <>4__this; // 0x20
	public byte[] array; // 0x28
	public int offset; // 0x30
	public int count; // 0x34
	public CancellationToken cancellationToken; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40

	// Methods

	// RVA: 0x1B248C8 Offset: 0x1B208C8 VA: 0x1B248C8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1B24BD4 Offset: 0x1B20BD4 VA: 0x1B24BD4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.IO.Compression
internal sealed class DeflateManagedStream : Stream // TypeDefIndex: 7656
{
	// Fields
	private Stream _stream; // 0x28
	private CompressionMode _mode; // 0x30
	private bool _leaveOpen; // 0x34
	private InflaterManaged _inflater; // 0x38
	private DeflaterManaged _deflater; // 0x40
	private byte[] _buffer; // 0x48
	private int _asyncOperations; // 0x50
	private IFileFormatWriter _formatWriter; // 0x58
	private bool _wroteHeader; // 0x60
	private bool _wroteBytes; // 0x61

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1B22640 Offset: 0x1B1E640 VA: 0x1B22640
	internal void .ctor(Stream stream, ZipArchiveEntry.CompressionMethodValues method) { }

	// RVA: 0x1B22778 Offset: 0x1B1E778 VA: 0x1B22778
	internal void InitializeInflater(Stream stream, bool leaveOpen, IFileFormatReader reader, ZipArchiveEntry.CompressionMethodValues method = 8) { }

	// RVA: 0x1B22A38 Offset: 0x1B1EA38 VA: 0x1B22A38 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1B22A60 Offset: 0x1B1EA60 VA: 0x1B22A60 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1B22A8C Offset: 0x1B1EA8C VA: 0x1B22A8C Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1B22A94 Offset: 0x1B1EA94 VA: 0x1B22A94 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1B22AE0 Offset: 0x1B1EAE0 VA: 0x1B22AE0 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1B22B2C Offset: 0x1B1EB2C VA: 0x1B22B2C Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1B22B78 Offset: 0x1B1EB78 VA: 0x1B22B78 Slot: 21
	public override void Flush() { }

	// RVA: 0x1B22BA0 Offset: 0x1B1EBA0 VA: 0x1B22BA0 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1B22BEC Offset: 0x1B1EBEC VA: 0x1B22BEC Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1B22C38 Offset: 0x1B1EC38 VA: 0x1B22C38 Slot: 32
	public override int Read(byte[] array, int offset, int count) { }

	// RVA: 0x1B22DA8 Offset: 0x1B1EDA8 VA: 0x1B22DA8
	private void ValidateParameters(byte[] array, int offset, int count) { }

	// RVA: 0x1B22B8C Offset: 0x1B1EB8C VA: 0x1B22B8C
	private void EnsureNotDisposed() { }

	// RVA: 0x1B230A8 Offset: 0x1B1F0A8 VA: 0x1B230A8
	private static void ThrowStreamClosedException() { }

	// RVA: 0x1B22D94 Offset: 0x1B1ED94 VA: 0x1B22D94
	private void EnsureDecompressionMode() { }

	// RVA: 0x1B230F8 Offset: 0x1B1F0F8 VA: 0x1B230F8
	private static void ThrowCannotReadFromDeflateManagedStreamException() { }

	// RVA: 0x1B23144 Offset: 0x1B1F144 VA: 0x1B23144
	private void EnsureCompressionMode() { }

	// RVA: 0x1B2315C Offset: 0x1B1F15C VA: 0x1B2315C
	private static void ThrowCannotWriteToDeflateManagedStreamException() { }

	// RVA: 0x1B231A8 Offset: 0x1B1F1A8 VA: 0x1B231A8 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1B23258 Offset: 0x1B1F258 VA: 0x1B23258 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1B232A0 Offset: 0x1B1F2A0 VA: 0x1B232A0 Slot: 24
	public override Task<int> ReadAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(DeflateManagedStream.<ReadAsyncCore>d__40))]
	// RVA: 0x1B23604 Offset: 0x1B1F604 VA: 0x1B23604
	private Task<int> ReadAsyncCore(Task<int> readTask, byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1B2377C Offset: 0x1B1F77C VA: 0x1B2377C Slot: 35
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x1B23988 Offset: 0x1B1F988 VA: 0x1B23988
	private void WriteDeflaterOutput() { }

	// RVA: 0x1B23804 Offset: 0x1B1F804 VA: 0x1B23804
	private void DoMaintenance(byte[] array, int offset, int count) { }

	// RVA: 0x1B23D44 Offset: 0x1B1FD44 VA: 0x1B23D44
	private void PurgeBuffers(bool disposing) { }

	// RVA: 0x1B23F08 Offset: 0x1B1FF08 VA: 0x1B23F08 Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1B23F9C Offset: 0x1B1FF9C VA: 0x1B23F9C Slot: 28
	public override Task WriteAsync(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(DeflateManagedStream.<WriteAsyncCore>d__47))]
	// RVA: 0x1B240FC Offset: 0x1B200FC VA: 0x1B240FC
	private Task WriteAsyncCore(byte[] array, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1B24224 Offset: 0x1B20224 VA: 0x1B24224 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback asyncCallback, object asyncState) { }

	// RVA: 0x1B242D4 Offset: 0x1B202D4 VA: 0x1B242D4 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	[DebuggerHidden]
	[CompilerGenerated]
	// RVA: 0x1B242DC Offset: 0x1B202DC VA: 0x1B242DC
	private Task <>n__0(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }
}

// Namespace: 
private enum DeflaterManaged.DeflaterState // TypeDefIndex: 7657
{
	// Fields
	public int value__; // 0x0
	public const DeflaterManaged.DeflaterState NotStarted = 0;
	public const DeflaterManaged.DeflaterState SlowDownForIncompressible1 = 1;
	public const DeflaterManaged.DeflaterState SlowDownForIncompressible2 = 2;
	public const DeflaterManaged.DeflaterState StartingSmallData = 3;
	public const DeflaterManaged.DeflaterState CompressThenCheck = 4;
	public const DeflaterManaged.DeflaterState CheckingForIncompressible = 5;
	public const DeflaterManaged.DeflaterState HandlingSmallData = 6;
}

// Namespace: System.IO.Compression
internal sealed class DeflaterManaged // TypeDefIndex: 7658
{
	// Fields
	private readonly FastEncoder _deflateEncoder; // 0x10
	private readonly CopyEncoder _copyEncoder; // 0x18
	private readonly DeflateInput _input; // 0x20
	private readonly OutputBuffer _output; // 0x28
	private DeflaterManaged.DeflaterState _processingState; // 0x30
	private DeflateInput _inputFromHistory; // 0x38

	// Methods

	// RVA: 0x1B23D00 Offset: 0x1B1FD00 VA: 0x1B23D00
	internal bool NeedsInput() { }

	// RVA: 0x1B239F0 Offset: 0x1B1F9F0 VA: 0x1B239F0
	internal void SetInput(byte[] inputBuffer, int startIndex, int count) { }

	// RVA: 0x1B23A60 Offset: 0x1B1FA60 VA: 0x1B23A60
	internal int GetDeflateOutput(byte[] outputBuffer) { }

	// RVA: 0x1B23E7C Offset: 0x1B1FE7C VA: 0x1B23E7C
	internal bool Finish(byte[] outputBuffer, out int bytesRead) { }

	// RVA: 0x1B24C98 Offset: 0x1B20C98 VA: 0x1B24C98
	private bool UseCompressed(double ratio) { }

	// RVA: 0x1B24CB8 Offset: 0x1B20CB8 VA: 0x1B24CB8
	private void FlushInputWindows() { }

	// RVA: 0x1B24D50 Offset: 0x1B20D50 VA: 0x1B24D50
	private void WriteFinal() { }

	// RVA: 0x1B24D74 Offset: 0x1B20D74 VA: 0x1B24D74 Slot: 4
	public void Dispose() { }
}

// Namespace: System.IO.Compression
internal sealed class FastEncoder // TypeDefIndex: 7659
{
	// Fields
	private readonly FastEncoderWindow _inputWindow; // 0x10
	private readonly Match _currentMatch; // 0x18
	private double _lastCompressionRatio; // 0x20

	// Properties
	internal int BytesInHistory { get; }
	internal DeflateInput UnprocessedInput { get; }
	internal double LastCompressionRatio { get; }

	// Methods

	// RVA: 0x1B24C3C Offset: 0x1B20C3C VA: 0x1B24C3C
	internal int get_BytesInHistory() { }

	// RVA: 0x1B24CD8 Offset: 0x1B20CD8 VA: 0x1B24CD8
	internal DeflateInput get_UnprocessedInput() { }

	// RVA: 0x1B24CF0 Offset: 0x1B20CF0 VA: 0x1B24CF0
	internal void FlushInput() { }

	// RVA: 0x1B24E04 Offset: 0x1B20E04 VA: 0x1B24E04
	internal double get_LastCompressionRatio() { }

	// RVA: 0x1B24D04 Offset: 0x1B20D04 VA: 0x1B24D04
	internal void GetBlock(DeflateInput input, OutputBuffer output, int maxBytesToCopy) { }

	// RVA: 0x1B24C90 Offset: 0x1B20C90 VA: 0x1B24C90
	internal void GetCompressedData(DeflateInput input, OutputBuffer output) { }

	// RVA: 0x1B24C88 Offset: 0x1B20C88 VA: 0x1B24C88
	internal void GetBlockHeader(OutputBuffer output) { }

	// RVA: 0x1B24CEC Offset: 0x1B20CEC VA: 0x1B24CEC
	internal void GetBlockFooter(OutputBuffer output) { }

	// RVA: 0x1B24E90 Offset: 0x1B20E90 VA: 0x1B24E90
	private void GetCompressedOutput(DeflateInput input, OutputBuffer output, int maxBytesToCopy) { }

	// RVA: 0x1B25124 Offset: 0x1B21124 VA: 0x1B25124
	private void GetCompressedOutput(OutputBuffer output) { }

	// RVA: 0x1B251FC Offset: 0x1B211FC VA: 0x1B251FC
	private bool InputAvailable(DeflateInput input) { }

	// RVA: 0x1B251CC Offset: 0x1B211CC VA: 0x1B251CC
	private bool SafeToWriteTo(OutputBuffer output) { }

	// RVA: 0x1B25044 Offset: 0x1B21044 VA: 0x1B25044
	private void WriteEndOfBlock(OutputBuffer output) { }

	// RVA: 0x1B254E8 Offset: 0x1B214E8 VA: 0x1B254E8
	internal static void WriteMatch(int matchLen, int matchPos, OutputBuffer output) { }

	// RVA: 0x1B25450 Offset: 0x1B21450 VA: 0x1B25450
	internal static void WriteChar(byte b, OutputBuffer output) { }

	// RVA: 0x1B24E0C Offset: 0x1B20E0C VA: 0x1B24E0C
	internal static void WriteDeflatePreamble(OutputBuffer output) { }
}

// Namespace: System.IO.Compression
internal static class FastEncoderStatics // TypeDefIndex: 7660
{
	// Fields
	internal static readonly byte[] FastEncoderTreeStructureData; // 0x0
	internal static readonly byte[] BFinalFastEncoderTreeStructureData; // 0x8
	internal static readonly uint[] FastEncoderLiteralCodeInfo; // 0x10
	internal static readonly uint[] FastEncoderDistanceCodeInfo; // 0x18
	internal static readonly uint[] BitMask; // 0x20
	internal static readonly byte[] ExtraLengthBits; // 0x28
	internal static readonly byte[] ExtraDistanceBits; // 0x30
	private static readonly byte[] s_distLookup; // 0x38

	// Methods

	// RVA: 0x1B256E8 Offset: 0x1B216E8 VA: 0x1B256E8
	private static byte[] CreateDistanceLookup() { }

	// RVA: 0x1B2565C Offset: 0x1B2165C VA: 0x1B2565C
	internal static int GetSlot(int pos) { }

	// RVA: 0x1B25870 Offset: 0x1B21870 VA: 0x1B25870
	public static uint BitReverse(uint code, int length) { }

	// RVA: 0x1B25898 Offset: 0x1B21898 VA: 0x1B25898
	private static void .cctor() { }
}

// Namespace: System.IO.Compression
internal sealed class FastEncoderWindow // TypeDefIndex: 7661
{
	// Fields
	private byte[] _window; // 0x10
	private int _bufPos; // 0x18
	private int _bufEnd; // 0x1C
	private ushort[] _prev; // 0x20
	private ushort[] _lookup; // 0x28

	// Properties
	public int BytesAvailable { get; }
	public DeflateInput UnprocessedInput { get; }
	public int FreeWindowSpace { get; }

	// Methods

	// RVA: 0x1B24D78 Offset: 0x1B20D78 VA: 0x1B24D78
	public int get_BytesAvailable() { }

	// RVA: 0x1B24D84 Offset: 0x1B20D84 VA: 0x1B24D84
	public DeflateInput get_UnprocessedInput() { }

	// RVA: 0x1B24E00 Offset: 0x1B20E00 VA: 0x1B24E00
	public void FlushWindow() { }

	// RVA: 0x1B25B18 Offset: 0x1B21B18 VA: 0x1B25B18
	private void ResetWindow() { }

	// RVA: 0x1B250CC Offset: 0x1B210CC VA: 0x1B250CC
	public int get_FreeWindowSpace() { }

	// RVA: 0x1B250DC Offset: 0x1B210DC VA: 0x1B250DC
	public void CopyBytes(byte[] inputBuffer, int startIndex, int count) { }

	// RVA: 0x1B25BD0 Offset: 0x1B21BD0 VA: 0x1B25BD0
	public void MoveWindows() { }

	// RVA: 0x1B25C88 Offset: 0x1B21C88 VA: 0x1B25C88
	private uint HashValue(uint hash, byte b) { }

	// RVA: 0x1B25C94 Offset: 0x1B21C94 VA: 0x1B25C94
	private uint InsertString(ref uint hash) { }

	// RVA: 0x1B25D20 Offset: 0x1B21D20 VA: 0x1B25D20
	private void InsertStrings(ref uint hash, int matchLen) { }

	// RVA: 0x1B2523C Offset: 0x1B2123C VA: 0x1B2523C
	internal bool GetNextSymbolOrMatch(Match match) { }

	// RVA: 0x1B25D8C Offset: 0x1B21D8C VA: 0x1B25D8C
	private int FindMatch(int search, out int matchPos, int searchDepth, int niceLength) { }
}

// Namespace: System.IO.Compression
internal interface IFileFormatWriter // TypeDefIndex: 7662
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract byte[] GetHeader();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void UpdateWithBytesRead(byte[] buffer, int offset, int bytesToCopy);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract byte[] GetFooter();
}

// Namespace: System.IO.Compression
internal interface IFileFormatReader // TypeDefIndex: 7663
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool ReadHeader(InputBuffer input);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool ReadFooter(InputBuffer input);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UpdateWithBytesRead(byte[] buffer, int offset, int bytesToCopy);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Validate();
}

// Namespace: System.IO.Compression
internal sealed class HuffmanTree // TypeDefIndex: 7664
{
	// Fields
	private readonly int _tableBits; // 0x10
	private readonly short[] _table; // 0x18
	private readonly short[] _left; // 0x20
	private readonly short[] _right; // 0x28
	private readonly byte[] _codeLengthArray; // 0x30
	private readonly int _tableMask; // 0x38
	[CompilerGenerated]
	private static readonly HuffmanTree <StaticLiteralLengthTree>k__BackingField; // 0x0
	[CompilerGenerated]
	private static readonly HuffmanTree <StaticDistanceTree>k__BackingField; // 0x8

	// Properties
	public static HuffmanTree StaticLiteralLengthTree { get; }
	public static HuffmanTree StaticDistanceTree { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B25EF4 Offset: 0x1B21EF4 VA: 0x1B25EF4
	public static HuffmanTree get_StaticLiteralLengthTree() { }

	[CompilerGenerated]
	// RVA: 0x1B25F4C Offset: 0x1B21F4C VA: 0x1B25F4C
	public static HuffmanTree get_StaticDistanceTree() { }

	// RVA: 0x1B25FA4 Offset: 0x1B21FA4 VA: 0x1B25FA4
	public void .ctor(byte[] codeLengths) { }

	// RVA: 0x1B26248 Offset: 0x1B22248 VA: 0x1B26248
	private static byte[] GetStaticLiteralTreeLength() { }

	// RVA: 0x1B2632C Offset: 0x1B2232C VA: 0x1B2632C
	private static byte[] GetStaticDistanceTreeLength() { }

	// RVA: 0x1B263A8 Offset: 0x1B223A8 VA: 0x1B263A8
	private uint[] CalculateHuffmanCode() { }

	// RVA: 0x1B260B0 Offset: 0x1B220B0 VA: 0x1B260B0
	private void CreateTable() { }

	// RVA: 0x1B265C0 Offset: 0x1B225C0 VA: 0x1B265C0
	public int GetNextSymbol(InputBuffer input) { }

	// RVA: 0x1B2681C Offset: 0x1B2281C VA: 0x1B2681C
	private static void .cctor() { }
}

// Namespace: System.IO.Compression
internal sealed class InflaterManaged // TypeDefIndex: 7665
{
	// Fields
	private static readonly byte[] s_extraLengthBits; // 0x0
	private static readonly int[] s_lengthBase; // 0x8
	private static readonly int[] s_distanceBasePosition; // 0x10
	private static readonly byte[] s_codeOrder; // 0x18
	private static readonly byte[] s_staticDistanceTreeTable; // 0x20
	private readonly OutputWindow _output; // 0x10
	private readonly InputBuffer _input; // 0x18
	private HuffmanTree _literalLengthTree; // 0x20
	private HuffmanTree _distanceTree; // 0x28
	private InflaterState _state; // 0x30
	private bool _hasFormatReader; // 0x34
	private int _bfinal; // 0x38
	private BlockType _blockType; // 0x3C
	private readonly byte[] _blockLengthBuffer; // 0x40
	private int _blockLength; // 0x48
	private int _length; // 0x4C
	private int _distanceCode; // 0x50
	private int _extraBits; // 0x54
	private int _loopCounter; // 0x58
	private int _literalLengthCodeCount; // 0x5C
	private int _distanceCodeCount; // 0x60
	private int _codeLengthCodeCount; // 0x64
	private int _codeArraySize; // 0x68
	private int _lengthCode; // 0x6C
	private readonly byte[] _codeList; // 0x70
	private readonly byte[] _codeLengthTreeCodeLength; // 0x78
	private readonly bool _deflate64; // 0x80
	private HuffmanTree _codeLengthTree; // 0x88
	private IFileFormatReader _formatReader; // 0x90

	// Methods

	// RVA: 0x1B228D0 Offset: 0x1B1E8D0 VA: 0x1B228D0
	internal void .ctor(IFileFormatReader reader, bool deflate64) { }

	// RVA: 0x1B26930 Offset: 0x1B22930 VA: 0x1B26930
	private void Reset() { }

	// RVA: 0x1B2306C Offset: 0x1B1F06C VA: 0x1B2306C
	public void SetInput(byte[] inputBytes, int offset, int length) { }

	// RVA: 0x1B23058 Offset: 0x1B1F058 VA: 0x1B23058
	public bool Finished() { }

	// RVA: 0x1B22EA0 Offset: 0x1B1EEA0 VA: 0x1B22EA0
	public int Inflate(byte[] bytes, int offset, int length) { }

	// RVA: 0x1B26A38 Offset: 0x1B22A38 VA: 0x1B26A38
	private bool Decode() { }

	// RVA: 0x1B27A3C Offset: 0x1B23A3C VA: 0x1B27A3C
	private bool DecodeUncompressedBlock(out bool end_of_block) { }

	// RVA: 0x1B27624 Offset: 0x1B23624 VA: 0x1B27624
	private bool DecodeBlock(out bool end_of_block_code_seen) { }

	// RVA: 0x1B26ED8 Offset: 0x1B22ED8 VA: 0x1B26ED8
	private bool DecodeDynamicBlockHeader() { }

	// RVA: 0x1B27EF8 Offset: 0x1B23EF8 VA: 0x1B27EF8
	public void Dispose() { }

	// RVA: 0x1B27EFC Offset: 0x1B23EFC VA: 0x1B27EFC
	private static void .cctor() { }
}

// Namespace: System.IO.Compression
internal enum InflaterState // TypeDefIndex: 7666
{
	// Fields
	public int value__; // 0x0
	public const InflaterState ReadingHeader = 0;
	public const InflaterState ReadingBFinal = 2;
	public const InflaterState ReadingBType = 3;
	public const InflaterState ReadingNumLitCodes = 4;
	public const InflaterState ReadingNumDistCodes = 5;
	public const InflaterState ReadingNumCodeLengthCodes = 6;
	public const InflaterState ReadingCodeLengthCodes = 7;
	public const InflaterState ReadingTreeCodesBefore = 8;
	public const InflaterState ReadingTreeCodesAfter = 9;
	public const InflaterState DecodeTop = 10;
	public const InflaterState HaveInitialLength = 11;
	public const InflaterState HaveFullLength = 12;
	public const InflaterState HaveDistCode = 13;
	public const InflaterState UncompressedAligning = 15;
	public const InflaterState UncompressedByte1 = 16;
	public const InflaterState UncompressedByte2 = 17;
	public const InflaterState UncompressedByte3 = 18;
	public const InflaterState UncompressedByte4 = 19;
	public const InflaterState DecodingUncompressed = 20;
	public const InflaterState StartReadingFooter = 21;
	public const InflaterState ReadingFooter = 22;
	public const InflaterState VerifyingFooter = 23;
	public const InflaterState Done = 24;
}

// Namespace: System.IO.Compression
internal sealed class InputBuffer // TypeDefIndex: 7667
{
	// Fields
	private byte[] _buffer; // 0x10
	private int _start; // 0x18
	private int _end; // 0x1C
	private uint _bitBuffer; // 0x20
	private int _bitsInBuffer; // 0x24

	// Properties
	public int AvailableBits { get; }
	public int AvailableBytes { get; }

	// Methods

	// RVA: 0x1B280D0 Offset: 0x1B240D0 VA: 0x1B280D0
	public int get_AvailableBits() { }

	// RVA: 0x1B280D8 Offset: 0x1B240D8 VA: 0x1B280D8
	public int get_AvailableBytes() { }

	// RVA: 0x1B26DE8 Offset: 0x1B22DE8 VA: 0x1B26DE8
	public bool EnsureBitsAvailable(int count) { }

	// RVA: 0x1B26718 Offset: 0x1B22718 VA: 0x1B26718
	public uint TryLoad16Bits() { }

	// RVA: 0x1B28108 Offset: 0x1B24108 VA: 0x1B28108
	private uint GetBitMask(int count) { }

	// RVA: 0x1B26E94 Offset: 0x1B22E94 VA: 0x1B26E94
	public int GetBits(int count) { }

	// RVA: 0x1B28118 Offset: 0x1B24118 VA: 0x1B28118
	public int CopyTo(byte[] output, int offset, int length) { }

	// RVA: 0x1B280F8 Offset: 0x1B240F8 VA: 0x1B280F8
	public bool NeedsInput() { }

	// RVA: 0x1B26954 Offset: 0x1B22954 VA: 0x1B26954
	public void SetInput(byte[] buffer, int offset, int length) { }

	// RVA: 0x1B26808 Offset: 0x1B22808 VA: 0x1B26808
	public void SkipBits(int n) { }

	// RVA: 0x1B27C38 Offset: 0x1B23C38 VA: 0x1B27C38
	public void SkipToByteBoundary() { }

	// RVA: 0x1B26928 Offset: 0x1B22928 VA: 0x1B26928
	public void .ctor() { }
}

// Namespace: System.IO.Compression
internal sealed class Match // TypeDefIndex: 7668
{
	// Fields
	[CompilerGenerated]
	private MatchState <State>k__BackingField; // 0x10
	[CompilerGenerated]
	private int <Position>k__BackingField; // 0x14
	[CompilerGenerated]
	private int <Length>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <Symbol>k__BackingField; // 0x1C

	// Properties
	internal MatchState State { get; set; }
	internal int Position { get; set; }
	internal int Length { get; set; }
	internal byte Symbol { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1B281F8 Offset: 0x1B241F8 VA: 0x1B281F8
	internal MatchState get_State() { }

	[CompilerGenerated]
	// RVA: 0x1B28200 Offset: 0x1B24200 VA: 0x1B28200
	internal void set_State(MatchState value) { }

	[CompilerGenerated]
	// RVA: 0x1B28208 Offset: 0x1B24208 VA: 0x1B28208
	internal int get_Position() { }

	[CompilerGenerated]
	// RVA: 0x1B28210 Offset: 0x1B24210 VA: 0x1B28210
	internal void set_Position(int value) { }

	[CompilerGenerated]
	// RVA: 0x1B28218 Offset: 0x1B24218 VA: 0x1B28218
	internal int get_Length() { }

	[CompilerGenerated]
	// RVA: 0x1B28220 Offset: 0x1B24220 VA: 0x1B28220
	internal void set_Length(int value) { }

	[CompilerGenerated]
	// RVA: 0x1B28228 Offset: 0x1B24228 VA: 0x1B28228
	internal byte get_Symbol() { }

	[CompilerGenerated]
	// RVA: 0x1B28230 Offset: 0x1B24230 VA: 0x1B28230
	internal void set_Symbol(byte value) { }
}

// Namespace: System.IO.Compression
internal enum MatchState // TypeDefIndex: 7669
{
	// Fields
	public int value__; // 0x0
	public const MatchState HasSymbol = 1;
	public const MatchState HasMatch = 2;
	public const MatchState HasSymbolAndMatch = 3;
}

// Namespace: 
[IsReadOnly]
internal struct OutputBuffer.BufferState // TypeDefIndex: 7670
{
	// Fields
	internal readonly int _pos; // 0x0
	internal readonly uint _bitBuf; // 0x4
	internal readonly int _bitCount; // 0x8

	// Methods

	// RVA: 0x1B282CC Offset: 0x1B242CC VA: 0x1B282CC
	internal void .ctor(int pos, uint bitBuf, int bitCount) { }
}

// Namespace: System.IO.Compression
internal sealed class OutputBuffer // TypeDefIndex: 7671
{
	// Fields
	private byte[] _byteBuffer; // 0x10
	private int _pos; // 0x18
	private uint _bitBuf; // 0x1C
	private int _bitCount; // 0x20

	// Properties
	internal int BytesWritten { get; }
	internal int FreeBytes { get; }
	internal int BitsInBuffer { get; }

	// Methods

	// RVA: 0x1B24C58 Offset: 0x1B20C58 VA: 0x1B24C58
	internal void UpdateBuffer(byte[] output) { }

	// RVA: 0x1B28238 Offset: 0x1B24238 VA: 0x1B28238
	internal int get_BytesWritten() { }

	// RVA: 0x1B22364 Offset: 0x1B1E364 VA: 0x1B22364
	internal int get_FreeBytes() { }

	// RVA: 0x1B22588 Offset: 0x1B1E588 VA: 0x1B22588
	internal void WriteUInt16(ushort value) { }

	// RVA: 0x1B223A0 Offset: 0x1B1E3A0 VA: 0x1B223A0
	internal void WriteBits(int n, uint bits) { }

	// RVA: 0x1B22440 Offset: 0x1B1E440 VA: 0x1B22440
	internal void FlushBits() { }

	// RVA: 0x1B22510 Offset: 0x1B1E510 VA: 0x1B22510
	internal void WriteBytes(byte[] byteArray, int offset, int count) { }

	// RVA: 0x1B28240 Offset: 0x1B24240 VA: 0x1B28240
	private void WriteBytesUnaligned(byte[] byteArray, int offset, int count) { }

	// RVA: 0x1B282C0 Offset: 0x1B242C0 VA: 0x1B282C0
	private void WriteByteUnaligned(byte b) { }

	// RVA: 0x1B22384 Offset: 0x1B1E384 VA: 0x1B22384
	internal int get_BitsInBuffer() { }

	// RVA: 0x1B24C78 Offset: 0x1B20C78 VA: 0x1B24C78
	internal OutputBuffer.BufferState DumpState() { }

	// RVA: 0x1B24CA8 Offset: 0x1B20CA8 VA: 0x1B24CA8
	internal void RestoreState(OutputBuffer.BufferState state) { }
}

// Namespace: System.IO.Compression
internal sealed class OutputWindow // TypeDefIndex: 7672
{
	// Fields
	private readonly byte[] _window; // 0x10
	private int _end; // 0x18
	private int _bytesUsed; // 0x1C

	// Properties
	public int FreeBytes { get; }
	public int AvailableBytes { get; }

	// Methods

	// RVA: 0x1B27D74 Offset: 0x1B23D74 VA: 0x1B27D74
	public void Write(byte b) { }

	// RVA: 0x1B27DCC Offset: 0x1B23DCC VA: 0x1B27DCC
	public void WriteLengthDistance(int length, int distance) { }

	// RVA: 0x1B27C5C Offset: 0x1B23C5C VA: 0x1B27C5C
	public int CopyFrom(InputBuffer input, int length) { }

	// RVA: 0x1B27D64 Offset: 0x1B23D64 VA: 0x1B27D64
	public int get_FreeBytes() { }

	// RVA: 0x1B282D8 Offset: 0x1B242D8 VA: 0x1B282D8
	public int get_AvailableBytes() { }

	// RVA: 0x1B26988 Offset: 0x1B22988 VA: 0x1B26988
	public int CopyTo(byte[] output, int offset, int length) { }

	// RVA: 0x1B268C4 Offset: 0x1B228C4 VA: 0x1B268C4
	public void .ctor() { }
}

// Namespace: System.IO.Compression
internal sealed class PositionPreservingWriteOnlyStreamWrapper : Stream // TypeDefIndex: 7673
{
	// Fields
	private readonly Stream _stream; // 0x28
	private long _position; // 0x30

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Position { get; set; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }

	// Methods

	// RVA: 0x1B282E0 Offset: 0x1B242E0 VA: 0x1B282E0
	public void .ctor(Stream stream) { }

	// RVA: 0x1B28354 Offset: 0x1B24354 VA: 0x1B28354 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1B2835C Offset: 0x1B2435C VA: 0x1B2835C Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1B28364 Offset: 0x1B24364 VA: 0x1B28364 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1B2836C Offset: 0x1B2436C VA: 0x1B2836C Slot: 12
	public override long get_Position() { }

	// RVA: 0x1B28374 Offset: 0x1B24374 VA: 0x1B28374 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1B283C0 Offset: 0x1B243C0 VA: 0x1B283C0 Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1B283EC Offset: 0x1B243EC VA: 0x1B283EC Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1B28418 Offset: 0x1B24418 VA: 0x1B28418 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1B28438 Offset: 0x1B24438 VA: 0x1B28438 Slot: 37
	public override void WriteByte(byte value) { }

	// RVA: 0x1B28464 Offset: 0x1B24464 VA: 0x1B28464 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1B28490 Offset: 0x1B24490 VA: 0x1B28490 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1B284AC Offset: 0x1B244AC VA: 0x1B284AC Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1B284CC Offset: 0x1B244CC VA: 0x1B284CC Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1B284EC Offset: 0x1B244EC VA: 0x1B284EC Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1B2850C Offset: 0x1B2450C VA: 0x1B2850C Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1B2852C Offset: 0x1B2452C VA: 0x1B2852C Slot: 21
	public override void Flush() { }

	// RVA: 0x1B2854C Offset: 0x1B2454C VA: 0x1B2854C Slot: 19
	public override void Close() { }

	// RVA: 0x1B2856C Offset: 0x1B2456C VA: 0x1B2856C Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1B2858C Offset: 0x1B2458C VA: 0x1B2858C Slot: 11
	public override long get_Length() { }

	// RVA: 0x1B285D8 Offset: 0x1B245D8 VA: 0x1B285D8 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1B28624 Offset: 0x1B24624 VA: 0x1B28624 Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1B28670 Offset: 0x1B24670 VA: 0x1B28670 Slot: 32
	public override int Read(byte[] buffer, int offset, int count) { }
}

// Namespace: System.IO.Compression
public class ZipArchive : IDisposable // TypeDefIndex: 7674
{
	// Fields
	private Stream _archiveStream; // 0x10
	private ZipArchiveEntry _archiveStreamOwner; // 0x18
	private BinaryReader _archiveReader; // 0x20
	private ZipArchiveMode _mode; // 0x28
	private List<ZipArchiveEntry> _entries; // 0x30
	private ReadOnlyCollection<ZipArchiveEntry> _entriesCollection; // 0x38
	private Dictionary<string, ZipArchiveEntry> _entriesDictionary; // 0x40
	private bool _readEntries; // 0x48
	private bool _leaveOpen; // 0x49
	private long _centralDirectoryStart; // 0x50
	private bool _isDisposed; // 0x58
	private uint _numberOfThisDisk; // 0x5C
	private long _expectedNumberOfEntries; // 0x60
	private Stream _backingStream; // 0x68
	private byte[] _archiveComment; // 0x70
	private Encoding _entryNameEncoding; // 0x78

	// Properties
	public ReadOnlyCollection<ZipArchiveEntry> Entries { get; }
	public ZipArchiveMode Mode { get; }
	internal BinaryReader ArchiveReader { get; }
	internal Stream ArchiveStream { get; }
	internal uint NumberOfThisDisk { get; }
	internal Encoding EntryNameEncoding { get; set; }

	// Methods

	// RVA: 0x1B286BC Offset: 0x1B246BC VA: 0x1B286BC
	public void .ctor(Stream stream, ZipArchiveMode mode, bool leaveOpen, Encoding entryNameEncoding) { }

	// RVA: 0x1B28F7C Offset: 0x1B24F7C VA: 0x1B28F7C
	public ReadOnlyCollection<ZipArchiveEntry> get_Entries() { }

	// RVA: 0x1B29098 Offset: 0x1B25098 VA: 0x1B29098
	public ZipArchiveMode get_Mode() { }

	// RVA: 0x1B290A0 Offset: 0x1B250A0 VA: 0x1B290A0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1B29560 Offset: 0x1B25560 VA: 0x1B29560 Slot: 4
	public void Dispose() { }

	// RVA: 0x1B295CC Offset: 0x1B255CC VA: 0x1B295CC
	internal BinaryReader get_ArchiveReader() { }

	// RVA: 0x1B295D4 Offset: 0x1B255D4 VA: 0x1B295D4
	internal Stream get_ArchiveStream() { }

	// RVA: 0x1B295DC Offset: 0x1B255DC VA: 0x1B295DC
	internal uint get_NumberOfThisDisk() { }

	// RVA: 0x1B295E4 Offset: 0x1B255E4 VA: 0x1B295E4
	internal Encoding get_EntryNameEncoding() { }

	// RVA: 0x1B2875C Offset: 0x1B2475C VA: 0x1B2875C
	private void set_EntryNameEncoding(Encoding value) { }

	// RVA: 0x1B295EC Offset: 0x1B255EC VA: 0x1B295EC
	private void AddEntry(ZipArchiveEntry entry) { }

	// RVA: 0x1B29700 Offset: 0x1B25700 VA: 0x1B29700
	internal void ReleaseArchiveStream(ZipArchiveEntry entry) { }

	// RVA: 0x1B2970C Offset: 0x1B2570C VA: 0x1B2970C
	internal void RemoveEntry(ZipArchiveEntry entry) { }

	// RVA: 0x1B29000 Offset: 0x1B25000 VA: 0x1B29000
	internal void ThrowIfDisposed() { }

	// RVA: 0x1B29790 Offset: 0x1B25790 VA: 0x1B29790
	private void CloseStreams() { }

	// RVA: 0x1B29070 Offset: 0x1B25070 VA: 0x1B29070
	private void EnsureCentralDirectoryRead() { }

	// RVA: 0x1B28824 Offset: 0x1B24824 VA: 0x1B28824
	private void Init(Stream stream, ZipArchiveMode mode, bool leaveOpen) { }

	// RVA: 0x1B297FC Offset: 0x1B257FC VA: 0x1B297FC
	private void ReadCentralDirectory() { }

	// RVA: 0x1B29A3C Offset: 0x1B25A3C VA: 0x1B29A3C
	private void ReadEndOfCentralDirectory() { }

	// RVA: 0x1B2914C Offset: 0x1B2514C VA: 0x1B2914C
	private void WriteFile() { }

	// RVA: 0x1B2B5A0 Offset: 0x1B275A0 VA: 0x1B2B5A0
	private void WriteArchiveEpilogue(long startOfCentralDirectory, long sizeOfCentralDirectory) { }
}

// Namespace: 
private sealed class ZipArchiveEntry.DirectToArchiveWriterStream : Stream // TypeDefIndex: 7675
{
	// Fields
	private long _position; // 0x28
	private CheckSumAndSizeWriteStream _crcSizeStream; // 0x30
	private bool _everWritten; // 0x38
	private bool _isDisposed; // 0x39
	private ZipArchiveEntry _entry; // 0x40
	private bool _usedZip64inLH; // 0x48
	private bool _canWrite; // 0x49

	// Properties
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }

	// Methods

	// RVA: 0x1B2DC00 Offset: 0x1B29C00 VA: 0x1B2DC00
	public void .ctor(CheckSumAndSizeWriteStream crcSizeStream, ZipArchiveEntry entry) { }

	// RVA: 0x1B2E634 Offset: 0x1B2A634 VA: 0x1B2E634 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1B2E708 Offset: 0x1B2A708 VA: 0x1B2E708 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1B2E720 Offset: 0x1B2A720 VA: 0x1B2E720 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1B2E770 Offset: 0x1B2A770 VA: 0x1B2E770 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1B2E778 Offset: 0x1B2A778 VA: 0x1B2E778 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1B2E780 Offset: 0x1B2A780 VA: 0x1B2E780 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1B2E684 Offset: 0x1B2A684 VA: 0x1B2E684
	private void ThrowIfDisposed() { }

	// RVA: 0x1B2E788 Offset: 0x1B2A788 VA: 0x1B2E788 Slot: 32
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1B2E7D8 Offset: 0x1B2A7D8 VA: 0x1B2E7D8 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1B2E828 Offset: 0x1B2A828 VA: 0x1B2E828 Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1B2E878 Offset: 0x1B2A878 VA: 0x1B2E878 Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1B2EA08 Offset: 0x1B2AA08 VA: 0x1B2EA08 Slot: 21
	public override void Flush() { }

	// RVA: 0x1B2EA34 Offset: 0x1B2AA34 VA: 0x1B2EA34 Slot: 20
	protected override void Dispose(bool disposing) { }
}

// Namespace: 
[Flags]
private enum ZipArchiveEntry.BitFlagValues // TypeDefIndex: 7676
{
	// Fields
	public ushort value__; // 0x0
	public const ZipArchiveEntry.BitFlagValues DataDescriptor = 8;
	public const ZipArchiveEntry.BitFlagValues UnicodeFileName = 2048;
}

// Namespace: 
internal enum ZipArchiveEntry.CompressionMethodValues // TypeDefIndex: 7677
{
	// Fields
	public ushort value__; // 0x0
	public const ZipArchiveEntry.CompressionMethodValues Stored = 0;
	public const ZipArchiveEntry.CompressionMethodValues Deflate = 8;
	public const ZipArchiveEntry.CompressionMethodValues Deflate64 = 9;
	public const ZipArchiveEntry.CompressionMethodValues BZip2 = 12;
	public const ZipArchiveEntry.CompressionMethodValues LZMA = 14;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ZipArchiveEntry.<>c // TypeDefIndex: 7678
{
	// Fields
	public static readonly ZipArchiveEntry.<>c <>9; // 0x0
	public static Action<long, long, uint, Stream, ZipArchiveEntry, EventHandler> <>9__69_0; // 0x8
	public static EventHandler <>9__72_0; // 0x10
	public static Action<ZipArchiveEntry> <>9__73_0; // 0x18

	// Methods

	// RVA: 0x1B2EAE8 Offset: 0x1B2AAE8 VA: 0x1B2EAE8
	private static void .cctor() { }

	// RVA: 0x1B2EB50 Offset: 0x1B2AB50 VA: 0x1B2EB50
	public void .ctor() { }

	// RVA: 0x1B2EB58 Offset: 0x1B2AB58 VA: 0x1B2EB58
	internal void <GetDataCompressor>b__69_0(long initialPosition, long currentPosition, uint checkSum, Stream backing, ZipArchiveEntry thisRef, EventHandler closeHandler) { }

	// RVA: 0x1B2EC2C Offset: 0x1B2AC2C VA: 0x1B2EC2C
	internal void <OpenInWriteMode>b__72_0(object o, EventArgs e) { }

	// RVA: 0x1B2ECC8 Offset: 0x1B2ACC8 VA: 0x1B2ECC8
	internal void <OpenInUpdateMode>b__73_0(ZipArchiveEntry thisRef) { }
}

// Namespace: System.IO.Compression
public class ZipArchiveEntry // TypeDefIndex: 7679
{
	// Fields
	private ZipArchive _archive; // 0x10
	private readonly bool _originallyInArchive; // 0x18
	private readonly int _diskNumberStart; // 0x1C
	private readonly ZipVersionMadeByPlatform _versionMadeByPlatform; // 0x20
	private ZipVersionNeededValues _versionMadeBySpecification; // 0x22
	private ZipVersionNeededValues _versionToExtract; // 0x24
	private ZipArchiveEntry.BitFlagValues _generalPurposeBitFlag; // 0x26
	private ZipArchiveEntry.CompressionMethodValues _storedCompressionMethod; // 0x28
	private DateTimeOffset _lastModified; // 0x30
	private long _compressedSize; // 0x40
	private long _uncompressedSize; // 0x48
	private long _offsetOfLocalHeader; // 0x50
	private Nullable<long> _storedOffsetOfCompressedData; // 0x58
	private uint _crc32; // 0x68
	private byte[][] _compressedBytes; // 0x70
	private MemoryStream _storedUncompressedData; // 0x78
	private bool _currentlyOpenForWrite; // 0x80
	private bool _everOpenedForWrite; // 0x81
	private Stream _outstandingWriteStream; // 0x88
	private uint _externalFileAttr; // 0x90
	private string _storedEntryName; // 0x98
	private byte[] _storedEntryNameBytes; // 0xA0
	private List<ZipGenericExtraField> _cdUnknownExtraFields; // 0xA8
	private List<ZipGenericExtraField> _lhUnknownExtraFields; // 0xB0
	private byte[] _fileComment; // 0xB8
	private Nullable<CompressionLevel> _compressionLevel; // 0xC0
	private static readonly bool s_allowLargeZipArchiveEntriesInUpdateMode; // 0x0
	internal static readonly ZipVersionMadeByPlatform CurrentZipPlatform; // 0x1

	// Properties
	public string FullName { get; set; }
	public DateTimeOffset LastWriteTime { get; }
	public long Length { get; }
	private long OffsetOfCompressedData { get; }
	private MemoryStream UncompressedData { get; }
	private ZipArchiveEntry.CompressionMethodValues CompressionMethod { get; set; }

	// Methods

	// RVA: 0x1B2A0B0 Offset: 0x1B260B0 VA: 0x1B2A0B0
	internal void .ctor(ZipArchive archive, ZipCentralDirectoryFileHeader cd) { }

	// RVA: 0x1B2BD80 Offset: 0x1B27D80 VA: 0x1B2BD80
	public string get_FullName() { }

	// RVA: 0x1B2BC28 Offset: 0x1B27C28 VA: 0x1B2BC28
	private void set_FullName(string value) { }

	// RVA: 0x1B2BF40 Offset: 0x1B27F40 VA: 0x1B2BF40
	public DateTimeOffset get_LastWriteTime() { }

	// RVA: 0x1B2BF4C Offset: 0x1B27F4C VA: 0x1B2BF4C
	public long get_Length() { }

	// RVA: 0x1B2AFF8 Offset: 0x1B26FF8 VA: 0x1B2AFF8
	public void Delete() { }

	// RVA: 0x1B2BFE4 Offset: 0x1B27FE4 VA: 0x1B2BFE4
	public Stream Open() { }

	// RVA: 0x1B2C4C4 Offset: 0x1B284C4 VA: 0x1B2C4C4 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B2C4CC Offset: 0x1B284CC VA: 0x1B2C4CC
	private long get_OffsetOfCompressedData() { }

	// RVA: 0x1B2C794 Offset: 0x1B28794 VA: 0x1B2C794
	private MemoryStream get_UncompressedData() { }

	// RVA: 0x1B2CA30 Offset: 0x1B28A30 VA: 0x1B2CA30
	private ZipArchiveEntry.CompressionMethodValues get_CompressionMethod() { }

	// RVA: 0x1B2BA50 Offset: 0x1B27A50 VA: 0x1B2BA50
	private void set_CompressionMethod(ZipArchiveEntry.CompressionMethodValues value) { }

	// RVA: 0x1B2BBE0 Offset: 0x1B27BE0 VA: 0x1B2BBE0
	private string DecodeEntryName(byte[] entryNameBytes) { }

	// RVA: 0x1B2BD88 Offset: 0x1B27D88 VA: 0x1B2BD88
	private byte[] EncodeEntryName(string entryName, out bool isUTF8) { }

	// RVA: 0x1B2B0E4 Offset: 0x1B270E4 VA: 0x1B2B0E4
	internal void WriteAndFinishLocalEntry() { }

	// RVA: 0x1B2B110 Offset: 0x1B27110 VA: 0x1B2B110
	internal void WriteCentralDirectoryFileHeader() { }

	// RVA: 0x1B2AD1C Offset: 0x1B26D1C VA: 0x1B2AD1C
	internal bool LoadLocalHeaderExtraFieldAndCompressedBytesIfNeeded() { }

	// RVA: 0x1B2A050 Offset: 0x1B26050 VA: 0x1B2A050
	internal void ThrowIfNotOpenable(bool needToUncompress, bool needToLoadIntoMemory) { }

	// RVA: 0x1B2D7FC Offset: 0x1B297FC VA: 0x1B2D7FC
	private CheckSumAndSizeWriteStream GetDataCompressor(Stream backingStream, bool leaveBackingStreamOpen, EventHandler onClose) { }

	// RVA: 0x1B2DAB8 Offset: 0x1B29AB8 VA: 0x1B2DAB8
	private Stream GetDataDecompressor(Stream compressedStreamToRead) { }

	// RVA: 0x1B2C084 Offset: 0x1B28084 VA: 0x1B2C084
	private Stream OpenInReadMode(bool checkOpenable) { }

	// RVA: 0x1B2C12C Offset: 0x1B2812C VA: 0x1B2C12C
	private Stream OpenInWriteMode() { }

	// RVA: 0x1B2C308 Offset: 0x1B28308 VA: 0x1B2C308
	private Stream OpenInUpdateMode() { }

	// RVA: 0x1B2D59C Offset: 0x1B2959C VA: 0x1B2D59C
	private bool IsOpenable(bool needToUncompress, bool needToLoadIntoMemory, out string message) { }

	// RVA: 0x1B2CD80 Offset: 0x1B28D80 VA: 0x1B2CD80
	private bool SizesTooLarge() { }

	// RVA: 0x1B2DCB8 Offset: 0x1B29CB8 VA: 0x1B2DCB8
	private bool WriteLocalFileHeader(bool isEmptyFile) { }

	// RVA: 0x1B2CABC Offset: 0x1B28ABC VA: 0x1B2CABC
	private void WriteLocalFileHeaderAndDataIfNeeded() { }

	// RVA: 0x1B2E09C Offset: 0x1B2A09C VA: 0x1B2E09C
	private void WriteCrcAndSizesInLocalHeader(bool zip64HeaderUsed) { }

	// RVA: 0x1B2E37C Offset: 0x1B2A37C VA: 0x1B2E37C
	private void WriteDataDescriptor() { }

	// RVA: 0x1B2BFA8 Offset: 0x1B27FA8 VA: 0x1B2BFA8
	private void UnloadStreams() { }

	// RVA: 0x1B2CAA8 Offset: 0x1B28AA8 VA: 0x1B2CAA8
	private void CloseStreams() { }

	// RVA: 0x1B2BF18 Offset: 0x1B27F18 VA: 0x1B2BF18
	private void VersionToExtractAtLeast(ZipVersionNeededValues value) { }

	// RVA: 0x1B2C02C Offset: 0x1B2802C VA: 0x1B2C02C
	private void ThrowIfInvalidArchive() { }

	// RVA: 0x1B2E498 Offset: 0x1B2A498 VA: 0x1B2E498
	private static string GetFileName_Windows(string path) { }

	// RVA: 0x1B2E528 Offset: 0x1B2A528 VA: 0x1B2E528
	private static string GetFileName_Unix(string path) { }

	// RVA: 0x1B2BE68 Offset: 0x1B27E68 VA: 0x1B2BE68
	internal static string ParseFileName(string path, ZipVersionMadeByPlatform madeByPlatform) { }

	// RVA: 0x1B2E590 Offset: 0x1B2A590 VA: 0x1B2E590
	private static void .cctor() { }
}

// Namespace: System.IO.Compression
public enum ZipArchiveMode // TypeDefIndex: 7680
{
	// Fields
	public int value__; // 0x0
	public const ZipArchiveMode Read = 0;
	public const ZipArchiveMode Create = 1;
	public const ZipArchiveMode Update = 2;
}

// Namespace: System.IO.Compression
internal struct ZipGenericExtraField // TypeDefIndex: 7681
{
	// Fields
	private ushort _tag; // 0x0
	private ushort _size; // 0x2
	private byte[] _data; // 0x8

	// Properties
	public ushort Tag { get; }
	public ushort Size { get; }
	public byte[] Data { get; }

	// Methods

	// RVA: 0x1B2ECDC Offset: 0x1B2ACDC VA: 0x1B2ECDC
	public ushort get_Tag() { }

	// RVA: 0x1B2ECE4 Offset: 0x1B2ACE4 VA: 0x1B2ECE4
	public ushort get_Size() { }

	// RVA: 0x1B2ECEC Offset: 0x1B2ACEC VA: 0x1B2ECEC
	public byte[] get_Data() { }

	// RVA: 0x1B2ECF4 Offset: 0x1B2ACF4 VA: 0x1B2ECF4
	public void WriteBlock(Stream stream) { }

	// RVA: 0x1B2EDA0 Offset: 0x1B2ADA0 VA: 0x1B2EDA0
	public static bool TryReadBlock(BinaryReader reader, long endExtraField, out ZipGenericExtraField field) { }

	// RVA: 0x1B2EE84 Offset: 0x1B2AE84 VA: 0x1B2EE84
	public static List<ZipGenericExtraField> ParseExtraField(Stream extraFieldData) { }

	// RVA: 0x1B2CDD0 Offset: 0x1B28DD0 VA: 0x1B2CDD0
	public static int TotalSize(List<ZipGenericExtraField> fields) { }

	// RVA: 0x1B2D180 Offset: 0x1B29180 VA: 0x1B2D180
	public static void WriteAllBlocks(List<ZipGenericExtraField> fields, Stream stream) { }
}

// Namespace: System.IO.Compression
internal struct Zip64ExtraField // TypeDefIndex: 7682
{
	// Fields
	private ushort _size; // 0x0
	private Nullable<long> _uncompressedSize; // 0x8
	private Nullable<long> _compressedSize; // 0x18
	private Nullable<long> _localHeaderOffset; // 0x28
	private Nullable<int> _startDiskNumber; // 0x38

	// Properties
	public ushort TotalSize { get; }
	public Nullable<long> UncompressedSize { get; set; }
	public Nullable<long> CompressedSize { get; set; }
	public Nullable<long> LocalHeaderOffset { get; set; }
	public Nullable<int> StartDiskNumber { get; }

	// Methods

	// RVA: 0x1B2CDC4 Offset: 0x1B28DC4 VA: 0x1B2CDC4
	public ushort get_TotalSize() { }

	// RVA: 0x1B2F0C8 Offset: 0x1B2B0C8 VA: 0x1B2F0C8
	public Nullable<long> get_UncompressedSize() { }

	// RVA: 0x1B2CDB4 Offset: 0x1B28DB4 VA: 0x1B2CDB4
	public void set_UncompressedSize(Nullable<long> value) { }

	// RVA: 0x1B2F160 Offset: 0x1B2B160 VA: 0x1B2F160
	public Nullable<long> get_CompressedSize() { }

	// RVA: 0x1B2CDAC Offset: 0x1B28DAC VA: 0x1B2CDAC
	public void set_CompressedSize(Nullable<long> value) { }

	// RVA: 0x1B2F16C Offset: 0x1B2B16C VA: 0x1B2F16C
	public Nullable<long> get_LocalHeaderOffset() { }

	// RVA: 0x1B2CDBC Offset: 0x1B28DBC VA: 0x1B2CDBC
	public void set_LocalHeaderOffset(Nullable<long> value) { }

	// RVA: 0x1B2F178 Offset: 0x1B2B178 VA: 0x1B2F178
	public Nullable<int> get_StartDiskNumber() { }

	// RVA: 0x1B2F0D4 Offset: 0x1B2B0D4 VA: 0x1B2F0D4
	private void UpdateSize() { }

	// RVA: 0x1B2F180 Offset: 0x1B2B180 VA: 0x1B2F180
	public static Zip64ExtraField GetJustZip64Block(Stream extraFieldStream, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber) { }

	// RVA: 0x1B2F3BC Offset: 0x1B2B3BC VA: 0x1B2F3BC
	private static bool TryGetZip64BlockFromGenericExtraField(ZipGenericExtraField extraField, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber, out Zip64ExtraField zip64Block) { }

	// RVA: 0x1B2F944 Offset: 0x1B2B944 VA: 0x1B2F944
	public static Zip64ExtraField GetAndRemoveZip64Block(List<ZipGenericExtraField> extraFields, bool readUncompressedSize, bool readCompressedSize, bool readLocalHeaderOffset, bool readStartDiskNumber) { }

	// RVA: 0x1B2FC88 Offset: 0x1B2BC88 VA: 0x1B2FC88
	public static void RemoveZip64Blocks(List<ZipGenericExtraField> extraFields) { }

	// RVA: 0x1B2CFE8 Offset: 0x1B28FE8 VA: 0x1B2CFE8
	public void WriteBlock(Stream stream) { }
}

// Namespace: System.IO.Compression
internal struct Zip64EndOfCentralDirectoryLocator // TypeDefIndex: 7683
{
	// Fields
	public uint NumberOfDiskWithZip64EOCD; // 0x0
	public ulong OffsetOfZip64EOCD; // 0x8
	public uint TotalNumberOfDisks; // 0x10

	// Methods

	// RVA: 0x1B2AB34 Offset: 0x1B26B34 VA: 0x1B2AB34
	public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryLocator zip64EOCDLocator) { }

	// RVA: 0x1B2B7E4 Offset: 0x1B277E4 VA: 0x1B2B7E4
	public static void WriteBlock(Stream stream, long zip64EOCDRecordStart) { }
}

// Namespace: System.IO.Compression
internal struct Zip64EndOfCentralDirectoryRecord // TypeDefIndex: 7684
{
	// Fields
	public ulong SizeOfThisRecord; // 0x0
	public ushort VersionMadeBy; // 0x8
	public ushort VersionNeededToExtract; // 0xA
	public uint NumberOfThisDisk; // 0xC
	public uint NumberOfDiskWithStartOfCD; // 0x10
	public ulong NumberOfEntriesOnThisDisk; // 0x18
	public ulong NumberOfEntriesTotal; // 0x20
	public ulong SizeOfCentralDirectory; // 0x28
	public ulong OffsetOfCentralDirectory; // 0x30

	// Methods

	// RVA: 0x1B2ABDC Offset: 0x1B26BDC VA: 0x1B2ABDC
	public static bool TryReadBlock(BinaryReader reader, out Zip64EndOfCentralDirectoryRecord zip64EOCDRecord) { }

	// RVA: 0x1B2B678 Offset: 0x1B27678 VA: 0x1B2B678
	public static void WriteBlock(Stream stream, long numberOfEntries, long startOfCentralDirectory, long sizeOfCentralDirectory) { }
}

// Namespace: System.IO.Compression
[IsReadOnly]
internal struct ZipLocalFileHeader // TypeDefIndex: 7685
{
	// Methods

	// RVA: 0x1B2D2BC Offset: 0x1B292BC VA: 0x1B2D2BC
	public static List<ZipGenericExtraField> GetExtraFields(BinaryReader reader) { }

	// RVA: 0x1B2C60C Offset: 0x1B2860C VA: 0x1B2C60C
	public static bool TrySkipBlock(BinaryReader reader) { }
}

// Namespace: System.IO.Compression
internal struct ZipCentralDirectoryFileHeader // TypeDefIndex: 7686
{
	// Fields
	public byte VersionMadeByCompatibility; // 0x0
	public byte VersionMadeBySpecification; // 0x1
	public ushort VersionNeededToExtract; // 0x2
	public ushort GeneralPurposeBitFlag; // 0x4
	public ushort CompressionMethod; // 0x6
	public uint LastModified; // 0x8
	public uint Crc32; // 0xC
	public long CompressedSize; // 0x10
	public long UncompressedSize; // 0x18
	public ushort FilenameLength; // 0x20
	public ushort ExtraFieldLength; // 0x22
	public ushort FileCommentLength; // 0x24
	public int DiskNumberStart; // 0x28
	public ushort InternalFileAttributes; // 0x2C
	public uint ExternalFileAttributes; // 0x30
	public long RelativeOffsetOfLocalHeader; // 0x38
	public byte[] Filename; // 0x40
	public byte[] FileComment; // 0x48
	public List<ZipGenericExtraField> ExtraFields; // 0x50

	// Methods

	// RVA: 0x1B2A244 Offset: 0x1B26244 VA: 0x1B2A244
	public static bool TryReadBlock(BinaryReader reader, bool saveExtraFieldsAndComments, out ZipCentralDirectoryFileHeader header) { }
}

// Namespace: System.IO.Compression
internal struct ZipEndOfCentralDirectoryBlock // TypeDefIndex: 7687
{
	// Fields
	public uint Signature; // 0x0
	public ushort NumberOfThisDisk; // 0x4
	public ushort NumberOfTheDiskWithTheStartOfTheCentralDirectory; // 0x6
	public ushort NumberOfEntriesInTheCentralDirectoryOnThisDisk; // 0x8
	public ushort NumberOfEntriesInTheCentralDirectory; // 0xA
	public uint SizeOfCentralDirectory; // 0xC
	public uint OffsetOfStartOfCentralDirectoryWithRespectToTheStartingDiskNumber; // 0x10
	public byte[] ArchiveComment; // 0x18

	// Methods

	// RVA: 0x1B2B8B0 Offset: 0x1B278B0 VA: 0x1B2B8B0
	public static void WriteBlock(Stream stream, long numberOfEntries, long startOfCentralDirectory, long sizeOfCentralDirectory, byte[] archiveComment) { }

	// RVA: 0x1B2AA04 Offset: 0x1B26A04 VA: 0x1B2AA04
	public static bool TryReadBlock(BinaryReader reader, out ZipEndOfCentralDirectoryBlock eocdBlock) { }
}

// Namespace: System.IO.Compression
internal sealed class WrappedStream : Stream // TypeDefIndex: 7688
{
	// Fields
	private readonly Stream _baseStream; // 0x28
	private readonly bool _closeBaseStream; // 0x30
	private readonly Action<ZipArchiveEntry> _onClosed; // 0x38
	private readonly ZipArchiveEntry _zipArchiveEntry; // 0x40
	private bool _isDisposed; // 0x48

	// Properties
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }

	// Methods

	// RVA: 0x1B2DC9C Offset: 0x1B29C9C VA: 0x1B2DC9C
	internal void .ctor(Stream baseStream, bool closeBaseStream) { }

	// RVA: 0x1B30030 Offset: 0x1B2C030 VA: 0x1B30030
	private void .ctor(Stream baseStream, bool closeBaseStream, ZipArchiveEntry entry, Action<ZipArchiveEntry> onClosed) { }

	// RVA: 0x1B2DCA8 Offset: 0x1B29CA8 VA: 0x1B2DCA8
	internal void .ctor(Stream baseStream, ZipArchiveEntry entry, Action<ZipArchiveEntry> onClosed) { }

	// RVA: 0x1B300E8 Offset: 0x1B2C0E8 VA: 0x1B300E8 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1B30194 Offset: 0x1B2C194 VA: 0x1B30194 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1B301BC Offset: 0x1B2C1BC VA: 0x1B301BC Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1B30264 Offset: 0x1B2C264 VA: 0x1B30264 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1B30290 Offset: 0x1B2C290 VA: 0x1B30290 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1B302BC Offset: 0x1B2C2BC VA: 0x1B302BC Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1B30110 Offset: 0x1B2C110 VA: 0x1B30110
	private void ThrowIfDisposed() { }

	// RVA: 0x1B302E8 Offset: 0x1B2C2E8 VA: 0x1B302E8
	private void ThrowIfCantRead() { }

	// RVA: 0x1B3034C Offset: 0x1B2C34C VA: 0x1B3034C
	private void ThrowIfCantWrite() { }

	// RVA: 0x1B30200 Offset: 0x1B2C200 VA: 0x1B30200
	private void ThrowIfCantSeek() { }

	// RVA: 0x1B303B0 Offset: 0x1B2C3B0 VA: 0x1B303B0 Slot: 32
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1B3040C Offset: 0x1B2C40C VA: 0x1B3040C Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1B30458 Offset: 0x1B2C458 VA: 0x1B30458 Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1B304A4 Offset: 0x1B2C4A4 VA: 0x1B304A4 Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1B30500 Offset: 0x1B2C500 VA: 0x1B30500 Slot: 21
	public override void Flush() { }

	// RVA: 0x1B30534 Offset: 0x1B2C534 VA: 0x1B30534 Slot: 20
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.IO.Compression
internal sealed class SubReadStream : Stream // TypeDefIndex: 7689
{
	// Fields
	private readonly long _startInSuperStream; // 0x28
	private long _positionInSuperStream; // 0x30
	private readonly long _endInSuperStream; // 0x38
	private readonly Stream _superStream; // 0x40
	private bool _canRead; // 0x48
	private bool _isDisposed; // 0x49

	// Properties
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }

	// Methods

	// RVA: 0x1B2DB64 Offset: 0x1B29B64 VA: 0x1B2DB64
	public void .ctor(Stream superStream, long startPosition, long maxLength) { }

	// RVA: 0x1B305A8 Offset: 0x1B2C5A8 VA: 0x1B305A8 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1B3064C Offset: 0x1B2C64C VA: 0x1B3064C Slot: 12
	public override long get_Position() { }

	// RVA: 0x1B30668 Offset: 0x1B2C668 VA: 0x1B30668 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1B306B8 Offset: 0x1B2C6B8 VA: 0x1B306B8 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1B306F8 Offset: 0x1B2C6F8 VA: 0x1B306F8 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1B30700 Offset: 0x1B2C700 VA: 0x1B30700 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1B305C8 Offset: 0x1B2C5C8 VA: 0x1B305C8
	private void ThrowIfDisposed() { }

	// RVA: 0x1B30708 Offset: 0x1B2C708 VA: 0x1B30708
	private void ThrowIfCantRead() { }

	// RVA: 0x1B3076C Offset: 0x1B2C76C VA: 0x1B3076C Slot: 32
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1B30824 Offset: 0x1B2C824 VA: 0x1B30824 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1B30874 Offset: 0x1B2C874 VA: 0x1B30874 Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1B308C4 Offset: 0x1B2C8C4 VA: 0x1B308C4 Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1B30914 Offset: 0x1B2C914 VA: 0x1B30914 Slot: 21
	public override void Flush() { }

	// RVA: 0x1B30964 Offset: 0x1B2C964 VA: 0x1B30964 Slot: 20
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.IO.Compression
internal sealed class CheckSumAndSizeWriteStream : Stream // TypeDefIndex: 7690
{
	// Fields
	private readonly Stream _baseStream; // 0x28
	private readonly Stream _baseBaseStream; // 0x30
	private long _position; // 0x38
	private uint _checksum; // 0x40
	private readonly bool _leaveOpenOnClose; // 0x44
	private bool _canWrite; // 0x45
	private bool _isDisposed; // 0x46
	private bool _everWritten; // 0x47
	private long _initialPosition; // 0x48
	private readonly ZipArchiveEntry _zipArchiveEntry; // 0x50
	private readonly EventHandler _onClose; // 0x58
	private readonly Action<long, long, uint, Stream, ZipArchiveEntry, EventHandler> _saveCrcAndSizes; // 0x60

	// Properties
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }

	// Methods

	// RVA: 0x1B2D9C4 Offset: 0x1B299C4 VA: 0x1B2D9C4
	public void .ctor(Stream baseStream, Stream baseBaseStream, bool leaveOpenOnClose, ZipArchiveEntry entry, EventHandler onClose, Action<long, long, uint, Stream, ZipArchiveEntry, EventHandler> saveCrcAndSizes) { }

	// RVA: 0x1B30984 Offset: 0x1B2C984 VA: 0x1B30984 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1B30A58 Offset: 0x1B2CA58 VA: 0x1B30A58 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1B30A70 Offset: 0x1B2CA70 VA: 0x1B30A70 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1B30AC0 Offset: 0x1B2CAC0 VA: 0x1B30AC0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1B30AC8 Offset: 0x1B2CAC8 VA: 0x1B30AC8 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1B30AD0 Offset: 0x1B2CAD0 VA: 0x1B30AD0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1B309D4 Offset: 0x1B2C9D4 VA: 0x1B309D4
	private void ThrowIfDisposed() { }

	// RVA: 0x1B30AD8 Offset: 0x1B2CAD8 VA: 0x1B30AD8 Slot: 32
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1B30B28 Offset: 0x1B2CB28 VA: 0x1B30B28 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1B30B78 Offset: 0x1B2CB78 VA: 0x1B30B78 Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1B30BC8 Offset: 0x1B2CBC8 VA: 0x1B30BC8 Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1B30E30 Offset: 0x1B2CE30 VA: 0x1B30E30 Slot: 21
	public override void Flush() { }

	// RVA: 0x1B30E5C Offset: 0x1B2CE5C VA: 0x1B30E5C Slot: 20
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.IO.Compression
[Extension]
internal static class ZipHelper // TypeDefIndex: 7691
{
	// Fields
	private static readonly DateTime s_invalidDateIndicator; // 0x0

	// Methods

	// RVA: 0x1B2CA38 Offset: 0x1B28A38 VA: 0x1B2CA38
	internal static bool RequiresUnicode(string test) { }

	// RVA: 0x1B2D4E4 Offset: 0x1B294E4 VA: 0x1B2D4E4
	internal static void ReadBytes(Stream stream, byte[] buffer, int bytesToRead) { }

	// RVA: 0x1B2BABC Offset: 0x1B27ABC VA: 0x1B2BABC
	internal static DateTime DosTimeToDateTime(uint dateTime) { }

	// RVA: 0x1B2CF00 Offset: 0x1B28F00 VA: 0x1B2CF00
	internal static uint DateTimeToDosTime(DateTime dateTime) { }

	// RVA: 0x1B2A8C0 Offset: 0x1B268C0 VA: 0x1B2A8C0
	internal static bool SeekBackwardsToSignature(Stream stream, uint signatureToFind) { }

	[Extension]
	// RVA: 0x1B2FF38 Offset: 0x1B2BF38 VA: 0x1B2FF38
	internal static void AdvanceToPosition(Stream stream, long position) { }

	// RVA: 0x1B30F20 Offset: 0x1B2CF20 VA: 0x1B30F20
	private static bool SeekBackwardsAndRead(Stream stream, byte[] buffer, out int bufferPointer) { }

	// RVA: 0x1B31098 Offset: 0x1B2D098 VA: 0x1B31098
	private static void .cctor() { }
}

// Namespace: System.IO.Compression
internal enum ZipVersionNeededValues // TypeDefIndex: 7692
{
	// Fields
	public ushort value__; // 0x0
	public const ZipVersionNeededValues Default = 10;
	public const ZipVersionNeededValues ExplicitDirectory = 20;
	public const ZipVersionNeededValues Deflate = 20;
	public const ZipVersionNeededValues Deflate64 = 21;
	public const ZipVersionNeededValues Zip64 = 45;
}

// Namespace: System.IO.Compression
internal enum ZipVersionMadeByPlatform // TypeDefIndex: 7693
{
	// Fields
	public byte value__; // 0x0
	public const ZipVersionMadeByPlatform Windows = 0;
	public const ZipVersionMadeByPlatform Unix = 3;
}

// Namespace: System.IO.Compression
internal static class Crc32Helper // TypeDefIndex: 7694
{
	// Fields
	private static readonly uint[] s_crcTable_0; // 0x0
	private static readonly uint[] s_crcTable_1; // 0x8
	private static readonly uint[] s_crcTable_2; // 0x10
	private static readonly uint[] s_crcTable_3; // 0x18
	private static readonly uint[] s_crcTable_4; // 0x20
	private static readonly uint[] s_crcTable_5; // 0x28
	private static readonly uint[] s_crcTable_6; // 0x30
	private static readonly uint[] s_crcTable_7; // 0x38

	// Methods

	// RVA: 0x1B30DB4 Offset: 0x1B2CDB4 VA: 0x1B30DB4
	public static uint UpdateCrc32(uint crc32, byte[] buffer, int offset, int length) { }

	// RVA: 0x1B3110C Offset: 0x1B2D10C VA: 0x1B3110C
	private static uint ManagedCrc32(uint crc32, byte[] buffer, int offset, int length) { }

	// RVA: 0x1B31424 Offset: 0x1B2D424 VA: 0x1B31424
	private static void .cctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=19 // TypeDefIndex: 7695
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=29 // TypeDefIndex: 7696
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 7697
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 7698
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=98 // TypeDefIndex: 7699
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=116 // TypeDefIndex: 7700
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 // TypeDefIndex: 7701
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 // TypeDefIndex: 7702
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2052 // TypeDefIndex: 7703
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7704
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=19 111B15B20E0428A22EEAA1E54B0D3B008A7A3E79C8F7F4E783710F569E9CEF15 /*Metadata offset 0x3F38B8*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 12F3E0576D447EB37B36D82BA0C1C5481B8F0D12FDC70347CE4A076B229D4C86 /*Metadata offset 0x3F38D0*/; // 0x13
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 173FC2842CC37C43473B27D45B59B1A45DB9526EBDE9E2200921BCF7DD0C10EB /*Metadata offset 0x3F3CD8*/; // 0x413
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 27C36B8C06C0271A973E583417426E79BA840E2D887711B48754EECCA5504698 /*Metadata offset 0x3F40E0*/; // 0x813
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 3BA5013CDA6EDD541CADB772A5A98D00834C8FADF0CB30FBCA395ADB8381D8FF /*Metadata offset 0x3F4128*/; // 0x853
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 6E1812F3F28F9664C814D9F31417576204DC332FB8F6AF2BB74B53D5568F1ABF /*Metadata offset 0x3F4530*/; // 0xC53
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=29 73AA5A9F081C8049AA00AE8CEF554E85A334986D1E0AF7AF996F0F17F7AA0BAD /*Metadata offset 0x3F4558*/; // 0xC73
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 85F902FC25B01D62E00C2B48C0246DC27425600C06C44D60365C5BF9C566F2BF /*Metadata offset 0x3F4578*/; // 0xC90
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 959A3233BA53857D0FC9F6DC22C4A0762F7523990B7A329849041B16C4020926 /*Metadata offset 0x3F4600*/; // 0xD10
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=116 9904D3EECE4D6804EE8E8FB77D26027A711E53D12137176433B94661389DE511 /*Metadata offset 0x3F4A08*/; // 0x1110
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=29 B672541D472D0DF45EA7ADFD9CBBEEF9C1EBA5995647FEBC9C983D5B4190B36B /*Metadata offset 0x3F4A80*/; // 0x1184
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 B8E85B9CF5A7912BB02F1CF93F5F7FEBAC206CF473FC768F8D541FF3F4D0C00E /*Metadata offset 0x3F4AA0*/; // 0x11A1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=98 BA5DDECCF08DCED93F4CD2E949DD3C677C1B0ED36A5E7CE4617B187669D1504B /*Metadata offset 0x3F4AC8*/; // 0x11C1
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 BCC6DA7033D7BD35C3C4A0B79A4BDE6673F6700D4F1F8D85072F87907C4FDADF /*Metadata offset 0x3F4B30*/; // 0x1223
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 C267D4987FDC6B820E3DE539450A37A4F2017D977A06EAB159939CF971F538C5 /*Metadata offset 0x3F4F38*/; // 0x1623
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=98 C2E5E05EAC0B7DBBD623008DDE67325395F5F4E2B275201B59B409DE0E22CC66 /*Metadata offset 0x3F4FC0*/; // 0x16A3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 DA23A731F5CB6C49DED3DC9980961955E5EA5BB52B7D0D1E4D0A6A0EAE73F494 /*Metadata offset 0x3F5028*/; // 0x1705
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 DFE0020BB6F2D7F230A4E0FB7849C8AAD0B36BC326ACD36FEEC967E86D016F3E /*Metadata offset 0x3F5430*/; // 0x1B05
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2052 E4B61E8996D29E5E5CA72544AF61F6FA97A3FD90F3A722451D54A08C6933C76E /*Metadata offset 0x3F5838*/; // 0x1F05
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 FBFA46A6E618F71C0581E682B63B80024BCCF54FD38C7349749BCE1291188BD1 /*Metadata offset 0x3F6040*/; // 0x2709
}

// Namespace: 
internal class <Module> // TypeDefIndex: 7705
{}

// Namespace: 
internal static class Consts // TypeDefIndex: 7706
{
	// Fields
	public const string MonoCorlibVersion = "1A5E0066-58DC-428A-B21C-0AD6CDAE2789";
	public const string MonoVersion = "6.13.0.0";
	public const string MonoCompany = "Mono development team";
	public const string MonoProduct = "Mono Common Language Infrastructure";
	public const string MonoCopyright = "(c) Various Mono authors";
	public const string FxVersion = "4.0.0.0";
	public const string FxFileVersion = "4.6.57.0";
	public const string EnvironmentVersion = "4.0.30319.42000";
	public const string VsVersion = "0.0.0.0";
	public const string VsFileVersion = "11.0.0.0";
	private const string PublicKeyToken = "b77a5c561934e089";
	public const string AssemblyI18N = "I18N, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
	public const string AssemblyMicrosoft_JScript = "Microsoft.JScript, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblyMicrosoft_VisualStudio = "Microsoft.VisualStudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblyMicrosoft_VisualStudio_Web = "Microsoft.VisualStudio.Web, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblyMicrosoft_VSDesigner = "Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblyMono_Http = "Mono.Http, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
	public const string AssemblyMono_Posix = "Mono.Posix, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
	public const string AssemblyMono_Security = "Mono.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
	public const string AssemblyMono_Messaging_RabbitMQ = "Mono.Messaging.RabbitMQ, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";
	public const string AssemblyCorlib = "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string AssemblySystem = "System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string AssemblySystem_Data = "System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string AssemblySystem_Design = "System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_DirectoryServices = "System.DirectoryServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_Drawing = "System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_Drawing_Design = "System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_Messaging = "System.Messaging, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_Security = "System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_ServiceProcess = "System.ServiceProcess, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_Web = "System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";
	public const string AssemblySystem_Windows_Forms = "System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string AssemblySystem_2_0 = "System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string AssemblySystemCore_3_5 = "System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string AssemblySystem_Core = "System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	public const string WindowsBase_3_0 = "WindowsBase, Version=3.0.0.0, PublicKeyToken=31bf3856ad364e35";
	public const string AssemblyWindowsBase = "WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
	public const string AssemblyPresentationCore_3_5 = "PresentationCore, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
	public const string AssemblyPresentationCore_4_0 = "PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
	public const string AssemblyPresentationFramework_3_5 = "PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";
	public const string AssemblySystemServiceModel_3_0 = "System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
}

// Namespace: System.IO.Compression
public static class ZipFile // TypeDefIndex: 8108
{
	// Methods

	// RVA: 0x1B31AF4 Offset: 0x1B2DAF4 VA: 0x1B31AF4
	public static ZipArchive Open(string archiveFileName, ZipArchiveMode mode, Encoding entryNameEncoding) { }

	// RVA: 0x1B31CA8 Offset: 0x1B2DCA8 VA: 0x1B31CA8
	public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, bool overwrite) { }

	// RVA: 0x1B31CB4 Offset: 0x1B2DCB4 VA: 0x1B31CB4
	public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, Encoding entryNameEncoding, bool overwrite) { }
}

// Namespace: System.IO.Compression
[EditorBrowsable(1)]
[Extension]
public static class ZipFileExtensions // TypeDefIndex: 8109
{
	// Methods

	[Extension]
	// RVA: 0x1B31E38 Offset: 0x1B2DE38 VA: 0x1B31E38
	public static void ExtractToDirectory(ZipArchive source, string destinationDirectoryName, bool overwrite) { }

	[Extension]
	// RVA: 0x1B323A4 Offset: 0x1B2E3A4 VA: 0x1B323A4
	public static void ExtractToFile(ZipArchiveEntry source, string destinationFileName, bool overwrite) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 8110
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 8111
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[CompilerGenerated]
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 8112
{
	// Methods

	// RVA: 0xFF186C Offset: 0xFED86C VA: 0xFF186C
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0xFF195C Offset: 0xFED95C VA: 0xFF195C
	public void .ctor() { }
}
