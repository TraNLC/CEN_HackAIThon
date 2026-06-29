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

// Namespace: System.IO
internal static class FileSystem // TypeDefIndex: 1547
{
	// Methods

	// RVA: 0x18549C8 Offset: 0x18509C8 VA: 0x18549C8
	private static bool CopyDanglingSymlink(string sourceFullPath, string destFullPath) { }

	// RVA: 0x1854B30 Offset: 0x1850B30 VA: 0x1854B30
	public static void CopyFile(string sourceFullPath, string destFullPath, bool overwrite) { }

	// RVA: 0x1854F08 Offset: 0x1850F08 VA: 0x1854F08
	public static void DeleteFile(string fullPath) { }

	// RVA: 0x1855300 Offset: 0x1851300 VA: 0x1855300
	public static void CreateDirectory(string fullPath) { }

	// RVA: 0x1855B34 Offset: 0x1851B34 VA: 0x1855B34
	public static void RemoveDirectory(string fullPath, bool recursive) { }

	// RVA: 0x1855C7C Offset: 0x1851C7C VA: 0x1855C7C
	private static void RemoveDirectoryInternal(DirectoryInfo directory, bool recursive, bool throwOnTopLevelDirectoryNotFound) { }

	// RVA: 0x1854EEC Offset: 0x1850EEC VA: 0x1854EEC
	public static bool DirectoryExists(ReadOnlySpan<char> fullPath) { }

	// RVA: 0x1855B28 Offset: 0x1851B28 VA: 0x1855B28
	private static bool DirectoryExists(ReadOnlySpan<char> fullPath, out Interop.ErrorInfo errorInfo) { }

	// RVA: 0x1855AAC Offset: 0x1851AAC VA: 0x1855AAC
	public static bool FileExists(ReadOnlySpan<char> fullPath) { }

	// RVA: 0x18551F0 Offset: 0x18511F0 VA: 0x18551F0
	private static bool FileExists(ReadOnlySpan<char> fullPath, int fileType, out Interop.ErrorInfo errorInfo) { }

	// RVA: 0x1856484 Offset: 0x1852484 VA: 0x1856484
	private static bool ShouldIgnoreDirectory(string name) { }

	// RVA: 0x18565EC Offset: 0x18525EC VA: 0x18565EC
	public static void SetLastWriteTime(string fullPath, DateTimeOffset time, bool asDirectory) { }
}

// Namespace: System.IO
[Serializable]
public class DirectoryNotFoundException : IOException // TypeDefIndex: 1548
{
	// Methods

	// RVA: 0x1856858 Offset: 0x1852858 VA: 0x1856858
	public void .ctor() { }

	// RVA: 0x18568B4 Offset: 0x18528B4 VA: 0x18568B4
	public void .ctor(string message) { }

	// RVA: 0x18568D8 Offset: 0x18528D8 VA: 0x18568D8
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
[Serializable]
public class EndOfStreamException : IOException // TypeDefIndex: 1549
{
	// Methods

	// RVA: 0x18568E8 Offset: 0x18528E8 VA: 0x18568E8
	public void .ctor() { }

	// RVA: 0x1856944 Offset: 0x1852944 VA: 0x1856944
	public void .ctor(string message) { }

	// RVA: 0x1856968 Offset: 0x1852968 VA: 0x1856968
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
internal static class Error // TypeDefIndex: 1550
{
	// Methods

	// RVA: 0x1856970 Offset: 0x1852970 VA: 0x1856970
	internal static Exception GetStreamIsClosed() { }

	// RVA: 0x18569E0 Offset: 0x18529E0 VA: 0x18569E0
	internal static Exception GetEndOfFile() { }

	// RVA: 0x1856A58 Offset: 0x1852A58 VA: 0x1856A58
	internal static Exception GetReadNotSupported() { }

	// RVA: 0x1856AC4 Offset: 0x1852AC4 VA: 0x1856AC4
	internal static Exception GetWriteNotSupported() { }
}

// Namespace: System.IO
[Flags]
public enum FileAccess // TypeDefIndex: 1551
{
	// Fields
	public int value__; // 0x0
	public const FileAccess Read = 1;
	public const FileAccess Write = 2;
	public const FileAccess ReadWrite = 3;
}

// Namespace: System.IO
[Serializable]
public class FileLoadException : IOException // TypeDefIndex: 1552
{
	// Fields
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly string <FusionLog>k__BackingField; // 0x98

	// Properties
	public override string Message { get; }
	public string FileName { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x1856B30 Offset: 0x1852B30 VA: 0x1856B30
	public void .ctor() { }

	// RVA: 0x1856B8C Offset: 0x1852B8C VA: 0x1856B8C
	public void .ctor(string message) { }

	// RVA: 0x1856BB0 Offset: 0x1852BB0 VA: 0x1856BB0 Slot: 5
	public override string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x1856C64 Offset: 0x1852C64 VA: 0x1856C64
	public string get_FileName() { }

	[CompilerGenerated]
	// RVA: 0x1856C6C Offset: 0x1852C6C VA: 0x1856C6C
	public string get_FusionLog() { }

	// RVA: 0x1856C74 Offset: 0x1852C74 VA: 0x1856C74 Slot: 3
	public override string ToString() { }

	// RVA: 0x1856E58 Offset: 0x1852E58 VA: 0x1856E58
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1856F1C Offset: 0x1852F1C VA: 0x1856F1C Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1856BF0 Offset: 0x1852BF0 VA: 0x1856BF0
	internal static string FormatFileLoadExceptionMessage(string fileName, int hResult) { }
}

// Namespace: System.IO
public enum FileMode // TypeDefIndex: 1553
{
	// Fields
	public int value__; // 0x0
	public const FileMode CreateNew = 1;
	public const FileMode Create = 2;
	public const FileMode Open = 3;
	public const FileMode OpenOrCreate = 4;
	public const FileMode Truncate = 5;
	public const FileMode Append = 6;
}

// Namespace: System.IO
[Serializable]
public class FileNotFoundException : IOException // TypeDefIndex: 1554
{
	// Fields
	[CompilerGenerated]
	private readonly string <FileName>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly string <FusionLog>k__BackingField; // 0x98

	// Properties
	public override string Message { get; }
	public string FileName { get; }
	public string FusionLog { get; }

	// Methods

	// RVA: 0x1857010 Offset: 0x1853010 VA: 0x1857010
	public void .ctor() { }

	// RVA: 0x185706C Offset: 0x185306C VA: 0x185706C
	public void .ctor(string message) { }

	// RVA: 0x1857090 Offset: 0x1853090 VA: 0x1857090
	public void .ctor(string message, string fileName) { }

	// RVA: 0x18570CC Offset: 0x18530CC VA: 0x18570CC Slot: 5
	public override string get_Message() { }

	// RVA: 0x18570E4 Offset: 0x18530E4 VA: 0x18570E4
	private void SetMessageField() { }

	[CompilerGenerated]
	// RVA: 0x1857170 Offset: 0x1853170 VA: 0x1857170
	public string get_FileName() { }

	[CompilerGenerated]
	// RVA: 0x1857178 Offset: 0x1853178 VA: 0x1857178
	public string get_FusionLog() { }

	// RVA: 0x1857180 Offset: 0x1853180 VA: 0x1857180 Slot: 3
	public override string ToString() { }

	// RVA: 0x1857364 Offset: 0x1853364 VA: 0x1857364
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1857428 Offset: 0x1853428 VA: 0x1857428 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
[Flags]
public enum FileOptions // TypeDefIndex: 1555
{
	// Fields
	public int value__; // 0x0
	public const FileOptions None = 0;
	public const FileOptions WriteThrough = -2147483648;
	public const FileOptions Asynchronous = 1073741824;
	public const FileOptions RandomAccess = 268435456;
	public const FileOptions DeleteOnClose = 67108864;
	public const FileOptions SequentialScan = 134217728;
	public const FileOptions Encrypted = 16384;
}

// Namespace: System.IO
[Flags]
public enum FileShare // TypeDefIndex: 1556
{
	// Fields
	public int value__; // 0x0
	public const FileShare None = 0;
	public const FileShare Read = 1;
	public const FileShare Write = 2;
	public const FileShare ReadWrite = 3;
	public const FileShare Delete = 4;
	public const FileShare Inheritable = 16;
}

// Namespace: System.IO
[Serializable]
public class IOException : SystemException // TypeDefIndex: 1557
{
	// Methods

	// RVA: 0x185751C Offset: 0x185351C VA: 0x185751C
	public void .ctor() { }

	// RVA: 0x1855954 Offset: 0x1851954 VA: 0x1855954
	public void .ctor(string message) { }

	// RVA: 0x1857578 Offset: 0x1853578 VA: 0x1857578
	public void .ctor(string message, int hresult) { }

	// RVA: 0x18575A0 Offset: 0x18535A0 VA: 0x18575A0
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x18568E0 Offset: 0x18528E0 VA: 0x18568E0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
[Serializable]
public class MemoryStream : Stream // TypeDefIndex: 1558
{
	// Fields
	private byte[] _buffer; // 0x28
	private int _origin; // 0x30
	private int _position; // 0x34
	private int _length; // 0x38
	private int _capacity; // 0x3C
	private bool _expandable; // 0x40
	private bool _writable; // 0x41
	private bool _exposable; // 0x42
	private bool _isOpen; // 0x43
	private Task<int> _lastReadTask; // 0x48

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public virtual int Capacity { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x18575C4 Offset: 0x18535C4 VA: 0x18575C4
	public void .ctor() { }

	// RVA: 0x18575CC Offset: 0x18535CC VA: 0x18575CC
	public void .ctor(int capacity) { }

	// RVA: 0x1857754 Offset: 0x1853754 VA: 0x1857754
	public void .ctor(byte[] buffer) { }

	// RVA: 0x185775C Offset: 0x185375C VA: 0x185775C
	public void .ctor(byte[] buffer, bool writable) { }

	// RVA: 0x1857854 Offset: 0x1853854 VA: 0x1857854
	public void .ctor(byte[] buffer, int index, int count) { }

	// RVA: 0x1857860 Offset: 0x1853860 VA: 0x1857860
	public void .ctor(byte[] buffer, int index, int count, bool writable, bool publiclyVisible) { }

	// RVA: 0x1857A34 Offset: 0x1853A34 VA: 0x1857A34 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1857A3C Offset: 0x1853A3C VA: 0x1857A3C Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1857A44 Offset: 0x1853A44 VA: 0x1857A44 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1857A4C Offset: 0x1853A4C VA: 0x1857A4C
	private void EnsureNotClosed() { }

	// RVA: 0x1857A7C Offset: 0x1853A7C VA: 0x1857A7C
	private void EnsureWriteable() { }

	// RVA: 0x1857AB8 Offset: 0x1853AB8 VA: 0x1857AB8 Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1857B10 Offset: 0x1853B10 VA: 0x1857B10
	private bool EnsureCapacity(int value) { }

	// RVA: 0x1857BC4 Offset: 0x1853BC4 VA: 0x1857BC4 Slot: 21
	public override void Flush() { }

	// RVA: 0x1857BC8 Offset: 0x1853BC8 VA: 0x1857BC8 Slot: 38
	public virtual byte[] GetBuffer() { }

	// RVA: 0x1857C24 Offset: 0x1853C24 VA: 0x1857C24
	internal byte[] InternalGetBuffer() { }

	// RVA: 0x1857C2C Offset: 0x1853C2C VA: 0x1857C2C
	internal int InternalGetPosition() { }

	// RVA: 0x1857C34 Offset: 0x1853C34 VA: 0x1857C34
	internal int InternalReadInt32() { }

	// RVA: 0x1857CEC Offset: 0x1853CEC VA: 0x1857CEC
	internal int InternalEmulateRead(int count) { }

	// RVA: 0x1857D28 Offset: 0x1853D28 VA: 0x1857D28 Slot: 39
	public virtual int get_Capacity() { }

	// RVA: 0x1857D48 Offset: 0x1853D48 VA: 0x1857D48 Slot: 40
	public virtual void set_Capacity(int value) { }

	// RVA: 0x1857ED4 Offset: 0x1853ED4 VA: 0x1857ED4 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1857EF8 Offset: 0x1853EF8 VA: 0x1857EF8 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1857F18 Offset: 0x1853F18 VA: 0x1857F18 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1857FDC Offset: 0x1853FDC VA: 0x1857FDC Slot: 32
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x18581F4 Offset: 0x18541F4 VA: 0x18581F4 Slot: 33
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x1858638 Offset: 0x1854638 VA: 0x1858638 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1858A00 Offset: 0x1854A00 VA: 0x1858A00 Slot: 25
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1858DB8 Offset: 0x1854DB8 VA: 0x1858DB8 Slot: 34
	public override int ReadByte() { }

	// RVA: 0x1858E10 Offset: 0x1854E10 VA: 0x1858E10 Slot: 18
	public override void CopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x185932C Offset: 0x185532C VA: 0x185932C Slot: 30
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x1859478 Offset: 0x1855478 VA: 0x1859478 Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1859550 Offset: 0x1855550 VA: 0x1859550 Slot: 41
	public virtual byte[] ToArray() { }

	// RVA: 0x1859644 Offset: 0x1855644 VA: 0x1859644 Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x18598DC Offset: 0x18558DC VA: 0x18598DC Slot: 36
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x1859CC4 Offset: 0x1855CC4 VA: 0x1859CC4 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x185A028 Offset: 0x1856028 VA: 0x185A028 Slot: 29
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x185A350 Offset: 0x1856350 VA: 0x185A350 Slot: 37
	public override void WriteByte(byte value) { }
}

// Namespace: System.IO
internal static class PathInternal // TypeDefIndex: 1559
{
	// Fields
	private static readonly bool s_isCaseSensitive; // 0x0

	// Properties
	internal static bool IsCaseSensitive { get; }

	// Methods

	// RVA: 0x1855978 Offset: 0x1851978 VA: 0x1855978
	internal static int GetRootLength(ReadOnlySpan<char> path) { }

	// RVA: 0x1855944 Offset: 0x1851944 VA: 0x1855944
	internal static bool IsDirectorySeparator(char c) { }

	// RVA: 0x18558C4 Offset: 0x18518C4 VA: 0x18558C4
	internal static bool EndsInDirectorySeparator(ReadOnlySpan<char> path) { }

	// RVA: 0x185A41C Offset: 0x185641C VA: 0x185A41C
	internal static bool StartsWithDirectorySeparator(ReadOnlySpan<char> path) { }

	// RVA: 0x18550B0 Offset: 0x18510B0 VA: 0x18550B0
	internal static string TrimEndingDirectorySeparator(string path) { }

	// RVA: 0x1856508 Offset: 0x1852508 VA: 0x1856508
	internal static ReadOnlySpan<char> TrimEndingDirectorySeparator(ReadOnlySpan<char> path) { }

	// RVA: 0x185A498 Offset: 0x1856498 VA: 0x185A498
	internal static bool IsRoot(ReadOnlySpan<char> path) { }

	// RVA: 0x185A514 Offset: 0x1856514 VA: 0x185A514
	internal static bool get_IsCaseSensitive() { }

	// RVA: 0x185A56C Offset: 0x185656C VA: 0x185A56C
	private static bool GetIsCaseSensitive() { }

	// RVA: 0x185AA0C Offset: 0x1856A0C VA: 0x185AA0C
	public static bool IsPartiallyQualified(string path) { }

	// RVA: 0x185AA14 Offset: 0x1856A14 VA: 0x185AA14
	private static void .cctor() { }
}

// Namespace: System.IO
[Serializable]
public class PathTooLongException : IOException // TypeDefIndex: 1560
{
	// Methods

	// RVA: 0x185AA64 Offset: 0x1856A64 VA: 0x185AA64
	public void .ctor() { }

	// RVA: 0x185AAC0 Offset: 0x1856AC0 VA: 0x185AAC0
	public void .ctor(string message) { }

	// RVA: 0x185AAE4 Offset: 0x1856AE4 VA: 0x185AAE4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
internal sealed class PinnedBufferMemoryStream : UnmanagedMemoryStream // TypeDefIndex: 1561
{
	// Fields
	private byte[] _array; // 0x68
	private GCHandle _pinningHandle; // 0x70

	// Methods

	// RVA: 0x185AAEC Offset: 0x1856AEC VA: 0x185AAEC
	internal void .ctor(byte[] array) { }

	// RVA: 0x185AE00 Offset: 0x1856E00 VA: 0x185AE00 Slot: 33
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x185B024 Offset: 0x1857024 VA: 0x185B024 Slot: 36
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x185B308 Offset: 0x1857308 VA: 0x185B308 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x185B39C Offset: 0x185739C VA: 0x185B39C Slot: 20
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.IO
public enum SeekOrigin // TypeDefIndex: 1562
{
	// Fields
	public int value__; // 0x0
	public const SeekOrigin Begin = 0;
	public const SeekOrigin Current = 1;
	public const SeekOrigin End = 2;
}

// Namespace: System.IO
internal static class StreamHelpers // TypeDefIndex: 1563
{
	// Methods

	// RVA: 0x1858F40 Offset: 0x1854F40 VA: 0x1858F40
	public static void ValidateCopyToArgs(Stream source, Stream destination, int bufferSize) { }
}

// Namespace: 
private class StreamReader.NullStreamReader : StreamReader // TypeDefIndex: 1564
{
	// Properties
	public override Stream BaseStream { get; }
	public override Encoding CurrentEncoding { get; }

	// Methods

	// RVA: 0x185CEF4 Offset: 0x1858EF4 VA: 0x185CEF4
	internal void .ctor() { }

	// RVA: 0x185CF90 Offset: 0x1858F90 VA: 0x185CF90 Slot: 15
	public override Stream get_BaseStream() { }

	// RVA: 0x185CFE8 Offset: 0x1858FE8 VA: 0x185CFE8 Slot: 14
	public override Encoding get_CurrentEncoding() { }

	// RVA: 0x185CFF0 Offset: 0x1858FF0 VA: 0x185CFF0 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x185CFF4 Offset: 0x1858FF4 VA: 0x185CFF4 Slot: 9
	public override int Peek() { }

	// RVA: 0x185CFFC Offset: 0x1858FFC VA: 0x185CFFC Slot: 10
	public override int Read() { }

	// RVA: 0x185D004 Offset: 0x1859004 VA: 0x185D004 Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x185D00C Offset: 0x185900C VA: 0x185D00C Slot: 13
	public override string ReadLine() { }

	// RVA: 0x185D014 Offset: 0x1859014 VA: 0x185D014 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x185D02C Offset: 0x185902C VA: 0x185D02C Slot: 16
	internal override int ReadBuffer() { }
}

// Namespace: System.IO
[Serializable]
public class StreamReader : TextReader // TypeDefIndex: 1565
{
	// Fields
	public static readonly StreamReader Null; // 0x0
	private Stream _stream; // 0x18
	private Encoding _encoding; // 0x20
	private Decoder _decoder; // 0x28
	private byte[] _byteBuffer; // 0x30
	private char[] _charBuffer; // 0x38
	private int _charPos; // 0x40
	private int _charLen; // 0x44
	private int _byteLen; // 0x48
	private int _bytePos; // 0x4C
	private int _maxCharsPerBuffer; // 0x50
	private bool _detectEncoding; // 0x54
	private bool _checkPreamble; // 0x55
	private bool _isBlocked; // 0x56
	private bool _closable; // 0x57
	private Task _asyncReadTask; // 0x58

	// Properties
	public virtual Encoding CurrentEncoding { get; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }

	// Methods

	// RVA: 0x185B3D0 Offset: 0x18573D0 VA: 0x185B3D0
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x185B43C Offset: 0x185743C VA: 0x185B43C
	private static void ThrowAsyncIOInProgress() { }

	// RVA: 0x185B488 Offset: 0x1857488 VA: 0x185B488
	internal void .ctor() { }

	// RVA: 0x185B554 Offset: 0x1857554 VA: 0x185B554
	public void .ctor(Stream stream) { }

	// RVA: 0x185B590 Offset: 0x1857590 VA: 0x185B590
	public void .ctor(Stream stream, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x185B7E8 Offset: 0x18577E8 VA: 0x185B7E8
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x185B5D0 Offset: 0x18575D0 VA: 0x185B5D0
	public void .ctor(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x185B960 Offset: 0x1857960 VA: 0x185B960
	public void .ctor(string path) { }

	// RVA: 0x185B998 Offset: 0x1857998 VA: 0x185B998
	public void .ctor(string path, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x185BC10 Offset: 0x1857C10 VA: 0x185BC10
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks) { }

	// RVA: 0x185B9D4 Offset: 0x18579D4 VA: 0x185B9D4
	public void .ctor(string path, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize) { }

	// RVA: 0x185B7F8 Offset: 0x18577F8 VA: 0x185B7F8
	private void Init(Stream stream, Encoding encoding, bool detectEncodingFromByteOrderMarks, int bufferSize, bool leaveOpen) { }

	// RVA: 0x185BC18 Offset: 0x1857C18 VA: 0x185BC18
	internal void Init(Stream stream) { }

	// RVA: 0x185BC3C Offset: 0x1857C3C VA: 0x185BC3C Slot: 7
	public override void Close() { }

	// RVA: 0x185BC4C Offset: 0x1857C4C VA: 0x185BC4C Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x185BCF0 Offset: 0x1857CF0 VA: 0x185BCF0 Slot: 14
	public virtual Encoding get_CurrentEncoding() { }

	// RVA: 0x185BCF8 Offset: 0x1857CF8 VA: 0x185BCF8 Slot: 15
	public virtual Stream get_BaseStream() { }

	// RVA: 0x185BCE0 Offset: 0x1857CE0 VA: 0x185BCE0
	internal bool get_LeaveOpen() { }

	// RVA: 0x185BD00 Offset: 0x1857D00 VA: 0x185BD00 Slot: 9
	public override int Peek() { }

	// RVA: 0x185BDC4 Offset: 0x1857DC4 VA: 0x185BDC4 Slot: 10
	public override int Read() { }

	// RVA: 0x185BE88 Offset: 0x1857E88 VA: 0x185BE88 Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x185C014 Offset: 0x1858014 VA: 0x185C014
	private int ReadSpan(Span<char> buffer) { }

	// RVA: 0x185C544 Offset: 0x1858544 VA: 0x185C544 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x185C65C Offset: 0x185865C VA: 0x185C65C
	private void CompressBuffer(int n) { }

	// RVA: 0x185C6A0 Offset: 0x18586A0 VA: 0x185C6A0
	private void DetectEncoding() { }

	// RVA: 0x185C978 Offset: 0x1858978 VA: 0x185C978
	private bool IsPreamble() { }

	// RVA: 0x185CAA0 Offset: 0x1858AA0 VA: 0x185CAA0 Slot: 16
	internal virtual int ReadBuffer() { }

	// RVA: 0x185C234 Offset: 0x1858234 VA: 0x185C234
	private int ReadBuffer(Span<char> userBuffer, out bool readToUserBuffer) { }

	// RVA: 0x185CC04 Offset: 0x1858C04 VA: 0x185CC04 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x185CE6C Offset: 0x1858E6C VA: 0x185CE6C
	internal bool DataAvailable() { }

	// RVA: 0x185CE7C Offset: 0x1858E7C VA: 0x185CE7C
	private static void .cctor() { }
}

// Namespace: System.IO
[Serializable]
public class StreamWriter : TextWriter // TypeDefIndex: 1566
{
	// Fields
	public static readonly StreamWriter Null; // 0x0
	private Stream _stream; // 0x30
	private Encoding _encoding; // 0x38
	private Encoder _encoder; // 0x40
	private byte[] _byteBuffer; // 0x48
	private char[] _charBuffer; // 0x50
	private int _charPos; // 0x58
	private int _charLen; // 0x5C
	private bool _autoFlush; // 0x60
	private bool _haveWrittenPreamble; // 0x61
	private bool _closable; // 0x62
	private Task _asyncWriteTask; // 0x68

	// Properties
	private static Encoding UTF8NoBOM { get; }
	public virtual bool AutoFlush { set; }
	public virtual Stream BaseStream { get; }
	internal bool LeaveOpen { get; }
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x185D034 Offset: 0x1859034 VA: 0x185D034
	private void CheckAsyncTaskInProgress() { }

	// RVA: 0x185D0A0 Offset: 0x18590A0 VA: 0x185D0A0
	private static void ThrowAsyncIOInProgress() { }

	// RVA: 0x185D0EC Offset: 0x18590EC VA: 0x185D0EC
	private static Encoding get_UTF8NoBOM() { }

	// RVA: 0x185D13C Offset: 0x185913C VA: 0x185D13C
	internal void .ctor() { }

	// RVA: 0x185D2A4 Offset: 0x18592A4 VA: 0x185D2A4
	public void .ctor(Stream stream) { }

	// RVA: 0x185D520 Offset: 0x1859520 VA: 0x185D520
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x185D318 Offset: 0x1859318 VA: 0x185D318
	public void .ctor(Stream stream, Encoding encoding, int bufferSize, bool leaveOpen) { }

	// RVA: 0x185D6AC Offset: 0x18596AC VA: 0x185D6AC
	public void .ctor(string path) { }

	// RVA: 0x185D964 Offset: 0x1859964 VA: 0x185D964
	public void .ctor(string path, bool append, Encoding encoding) { }

	// RVA: 0x185D720 Offset: 0x1859720 VA: 0x185D720
	public void .ctor(string path, bool append, Encoding encoding, int bufferSize) { }

	// RVA: 0x185D52C Offset: 0x185952C VA: 0x185D52C
	private void Init(Stream streamArg, Encoding encodingArg, int bufferSize, bool shouldLeaveOpen) { }

	// RVA: 0x185DA04 Offset: 0x1859A04 VA: 0x185DA04 Slot: 8
	public override void Close() { }

	// RVA: 0x185DA70 Offset: 0x1859A70 VA: 0x185DA70 Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x185DC7C Offset: 0x1859C7C VA: 0x185DC7C Slot: 10
	public override void Flush() { }

	// RVA: 0x185DB00 Offset: 0x1859B00 VA: 0x185DB00
	private void Flush(bool flushStream, bool flushEncoder) { }

	// RVA: 0x185DC9C Offset: 0x1859C9C VA: 0x185DC9C Slot: 19
	public virtual void set_AutoFlush(bool value) { }

	// RVA: 0x185DCDC Offset: 0x1859CDC VA: 0x185DCDC Slot: 20
	public virtual Stream get_BaseStream() { }

	// RVA: 0x185DCE4 Offset: 0x1859CE4 VA: 0x185DCE4
	internal bool get_LeaveOpen() { }

	// RVA: 0x185DCF4 Offset: 0x1859CF4 VA: 0x185DCF4 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x185DCFC Offset: 0x1859CFC VA: 0x185DCFC Slot: 13
	public override void Write(char value) { }

	// RVA: 0x185DD88 Offset: 0x1859D88 VA: 0x185DD88 Slot: 14
	public override void Write(char[] buffer) { }

	// RVA: 0x185DDFC Offset: 0x1859DFC VA: 0x185DDFC Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x185DFD8 Offset: 0x1859FD8 VA: 0x185DFD8
	private void WriteSpan(ReadOnlySpan<char> buffer, bool appendNewLine) { }

	// RVA: 0x185E294 Offset: 0x185A294 VA: 0x185E294 Slot: 16
	public override void Write(string value) { }

	// RVA: 0x185E304 Offset: 0x185A304 VA: 0x185E304 Slot: 18
	public override void WriteLine(string value) { }

	// RVA: 0x185E378 Offset: 0x185A378 VA: 0x185E378
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
private sealed class TextReader.NullTextReader : TextReader // TypeDefIndex: 1567
{
	// Methods

	// RVA: 0x185EA60 Offset: 0x185AA60 VA: 0x185EA60
	public void .ctor() { }

	// RVA: 0x185EAB8 Offset: 0x185AAB8 VA: 0x185EAB8 Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x185EAC0 Offset: 0x185AAC0 VA: 0x185EAC0 Slot: 13
	public override string ReadLine() { }
}

// Namespace: 
[Serializable]
internal sealed class TextReader.SyncTextReader : TextReader // TypeDefIndex: 1568
{
	// Fields
	internal readonly TextReader _in; // 0x18

	// Methods

	// RVA: 0x185E974 Offset: 0x185A974 VA: 0x185E974
	internal void .ctor(TextReader t) { }

	// RVA: 0x185EAC8 Offset: 0x185AAC8 VA: 0x185EAC8 Slot: 7
	public override void Close() { }

	// RVA: 0x185EAE4 Offset: 0x185AAE4 VA: 0x185EAE4 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x185EB98 Offset: 0x185AB98 VA: 0x185EB98 Slot: 9
	public override int Peek() { }

	// RVA: 0x185EBB4 Offset: 0x185ABB4 VA: 0x185EBB4 Slot: 10
	public override int Read() { }

	// RVA: 0x185EBD0 Offset: 0x185ABD0 VA: 0x185EBD0 Slot: 11
	public override int Read(char[] buffer, int index, int count) { }

	// RVA: 0x185EBEC Offset: 0x185ABEC VA: 0x185EBEC Slot: 13
	public override string ReadLine() { }

	// RVA: 0x185EC0C Offset: 0x185AC0C VA: 0x185EC0C Slot: 12
	public override string ReadToEnd() { }
}

// Namespace: System.IO
[Serializable]
public abstract class TextReader : MarshalByRefObject, IDisposable // TypeDefIndex: 1569
{
	// Fields
	public static readonly TextReader Null; // 0x0

	// Methods

	// RVA: 0x185B54C Offset: 0x185754C VA: 0x185B54C
	protected void .ctor() { }

	// RVA: 0x185E430 Offset: 0x185A430 VA: 0x185E430 Slot: 7
	public virtual void Close() { }

	// RVA: 0x185E49C Offset: 0x185A49C VA: 0x185E49C Slot: 6
	public void Dispose() { }

	// RVA: 0x185E508 Offset: 0x185A508 VA: 0x185E508 Slot: 8
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x185E50C Offset: 0x185A50C VA: 0x185E50C Slot: 9
	public virtual int Peek() { }

	// RVA: 0x185E514 Offset: 0x185A514 VA: 0x185E514 Slot: 10
	public virtual int Read() { }

	// RVA: 0x185E51C Offset: 0x185A51C VA: 0x185E51C Slot: 11
	public virtual int Read(char[] buffer, int index, int count) { }

	// RVA: 0x185E6C8 Offset: 0x185A6C8 VA: 0x185E6C8 Slot: 12
	public virtual string ReadToEnd() { }

	// RVA: 0x185E7C8 Offset: 0x185A7C8 VA: 0x185E7C8 Slot: 13
	public virtual string ReadLine() { }

	// RVA: 0x185E8C0 Offset: 0x185A8C0 VA: 0x185E8C0
	public static TextReader Synchronized(TextReader reader) { }

	// RVA: 0x185E9E8 Offset: 0x185A9E8 VA: 0x185E9E8
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
private sealed class TextWriter.NullTextWriter : TextWriter // TypeDefIndex: 1570
{
	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x185F194 Offset: 0x185B194 VA: 0x185F194
	internal void .ctor() { }

	// RVA: 0x185F220 Offset: 0x185B220 VA: 0x185F220 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x185F228 Offset: 0x185B228 VA: 0x185F228 Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x185F22C Offset: 0x185B22C VA: 0x185F22C Slot: 16
	public override void Write(string value) { }

	// RVA: 0x185F230 Offset: 0x185B230 VA: 0x185F230 Slot: 17
	public override void WriteLine() { }

	// RVA: 0x185F234 Offset: 0x185B234 VA: 0x185F234 Slot: 18
	public override void WriteLine(string value) { }

	// RVA: 0x185F238 Offset: 0x185B238 VA: 0x185F238 Slot: 13
	public override void Write(char value) { }
}

// Namespace: 
[Serializable]
internal sealed class TextWriter.SyncTextWriter : TextWriter, IDisposable // TypeDefIndex: 1571
{
	// Fields
	private readonly TextWriter _out; // 0x30

	// Properties
	public override Encoding Encoding { get; }
	public override IFormatProvider FormatProvider { get; }
	public override string NewLine { get; }

	// Methods

	// RVA: 0x185F068 Offset: 0x185B068 VA: 0x185F068
	internal void .ctor(TextWriter t) { }

	// RVA: 0x185F23C Offset: 0x185B23C VA: 0x185F23C Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x185F258 Offset: 0x185B258 VA: 0x185F258 Slot: 7
	public override IFormatProvider get_FormatProvider() { }

	// RVA: 0x185F274 Offset: 0x185B274 VA: 0x185F274 Slot: 12
	public override string get_NewLine() { }

	// RVA: 0x185F290 Offset: 0x185B290 VA: 0x185F290 Slot: 8
	public override void Close() { }

	// RVA: 0x185F2AC Offset: 0x185B2AC VA: 0x185F2AC Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x185F360 Offset: 0x185B360 VA: 0x185F360 Slot: 10
	public override void Flush() { }

	// RVA: 0x185F37C Offset: 0x185B37C VA: 0x185F37C Slot: 13
	public override void Write(char value) { }

	// RVA: 0x185F39C Offset: 0x185B39C VA: 0x185F39C Slot: 14
	public override void Write(char[] buffer) { }

	// RVA: 0x185F3BC Offset: 0x185B3BC VA: 0x185F3BC Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x185F3DC Offset: 0x185B3DC VA: 0x185F3DC Slot: 16
	public override void Write(string value) { }

	// RVA: 0x185F3FC Offset: 0x185B3FC VA: 0x185F3FC Slot: 17
	public override void WriteLine() { }

	// RVA: 0x185F41C Offset: 0x185B41C VA: 0x185F41C Slot: 18
	public override void WriteLine(string value) { }
}

// Namespace: System.IO
[Serializable]
public abstract class TextWriter : MarshalByRefObject, IDisposable // TypeDefIndex: 1572
{
	// Fields
	public static readonly TextWriter Null; // 0x0
	private static readonly char[] s_coreNewLine; // 0x8
	protected char[] CoreNewLine; // 0x18
	private string CoreNewLineStr; // 0x20
	private IFormatProvider _internalFormatProvider; // 0x28

	// Properties
	public virtual IFormatProvider FormatProvider { get; }
	public abstract Encoding Encoding { get; }
	public virtual string NewLine { get; }

	// Methods

	// RVA: 0x185D96C Offset: 0x185996C VA: 0x185D96C
	protected void .ctor() { }

	// RVA: 0x185D200 Offset: 0x1859200 VA: 0x185D200
	protected void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x185EC28 Offset: 0x185AC28 VA: 0x185EC28 Slot: 7
	public virtual IFormatProvider get_FormatProvider() { }

	// RVA: 0x185EC90 Offset: 0x185AC90 VA: 0x185EC90 Slot: 8
	public virtual void Close() { }

	// RVA: 0x185ECFC Offset: 0x185ACFC VA: 0x185ECFC Slot: 9
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x185ED00 Offset: 0x185AD00 VA: 0x185ED00 Slot: 6
	public void Dispose() { }

	// RVA: 0x185ED6C Offset: 0x185AD6C VA: 0x185ED6C Slot: 10
	public virtual void Flush() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Encoding get_Encoding();

	// RVA: 0x185ED70 Offset: 0x185AD70 VA: 0x185ED70 Slot: 12
	public virtual string get_NewLine() { }

	// RVA: 0x185ED78 Offset: 0x185AD78 VA: 0x185ED78 Slot: 13
	public virtual void Write(char value) { }

	// RVA: 0x185ED7C Offset: 0x185AD7C VA: 0x185ED7C Slot: 14
	public virtual void Write(char[] buffer) { }

	// RVA: 0x185ED9C Offset: 0x185AD9C VA: 0x185ED9C Slot: 15
	public virtual void Write(char[] buffer, int index, int count) { }

	// RVA: 0x185EF2C Offset: 0x185AF2C VA: 0x185EF2C Slot: 16
	public virtual void Write(string value) { }

	// RVA: 0x185EF64 Offset: 0x185AF64 VA: 0x185EF64 Slot: 17
	public virtual void WriteLine() { }

	// RVA: 0x185EF78 Offset: 0x185AF78 VA: 0x185EF78 Slot: 18
	public virtual void WriteLine(string value) { }

	// RVA: 0x185EFB4 Offset: 0x185AFB4 VA: 0x185EFB4
	public static TextWriter Synchronized(TextWriter writer) { }

	// RVA: 0x185F0EC Offset: 0x185B0EC VA: 0x185F0EC
	private static void .cctor() { }
}

// Namespace: System.IO
public class UnmanagedMemoryStream : Stream // TypeDefIndex: 1573
{
	// Fields
	private SafeBuffer _buffer; // 0x28
	private byte* _mem; // 0x30
	private long _length; // 0x38
	private long _capacity; // 0x40
	private long _position; // 0x48
	private long _offset; // 0x50
	private FileAccess _access; // 0x58
	internal bool _isOpen; // 0x5C
	private Task<int> _lastReadTask; // 0x60

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	[CLSCompliant(False)]
	public byte* PositionPointer { get; }

	// Methods

	// RVA: 0x185ABB0 Offset: 0x1856BB0 VA: 0x185ABB0
	protected void .ctor() { }

	[CLSCompliant(False)]
	// RVA: 0x185F43C Offset: 0x185B43C VA: 0x185F43C
	public void .ctor(byte* pointer, long length, long capacity, FileAccess access) { }

	[CLSCompliant(False)]
	// RVA: 0x185AC14 Offset: 0x1856C14 VA: 0x185AC14
	protected void Initialize(byte* pointer, long length, long capacity, FileAccess access) { }

	// RVA: 0x185F4CC Offset: 0x185B4CC VA: 0x185F4CC Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x185F4E8 Offset: 0x185B4E8 VA: 0x185F4E8 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x185F4F0 Offset: 0x185B4F0 VA: 0x185F4F0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x185B3C4 Offset: 0x18573C4 VA: 0x185B3C4 Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x185F510 Offset: 0x185B510 VA: 0x185F510
	private void EnsureNotClosed() { }

	// RVA: 0x185F540 Offset: 0x185B540 VA: 0x185F540
	private void EnsureReadable() { }

	// RVA: 0x185F57C Offset: 0x185B57C VA: 0x185F57C
	private void EnsureWriteable() { }

	// RVA: 0x185F5B8 Offset: 0x185B5B8 VA: 0x185F5B8 Slot: 21
	public override void Flush() { }

	// RVA: 0x185F5BC Offset: 0x185B5BC VA: 0x185F5BC Slot: 11
	public override long get_Length() { }

	// RVA: 0x185F5D8 Offset: 0x185B5D8 VA: 0x185F5D8 Slot: 12
	public override long get_Position() { }

	// RVA: 0x185F620 Offset: 0x185B620 VA: 0x185F620 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x185F6C4 Offset: 0x185B6C4 VA: 0x185F6C4
	public byte* get_PositionPointer() { }

	// RVA: 0x185F77C Offset: 0x185B77C VA: 0x185F77C Slot: 32
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x185F8FC Offset: 0x185B8FC VA: 0x185F8FC Slot: 33
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x185AE04 Offset: 0x1856E04 VA: 0x185AE04
	internal int ReadCore(Span<byte> buffer) { }

	// RVA: 0x185F9C4 Offset: 0x185B9C4 VA: 0x185F9C4 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x185FD20 Offset: 0x185BD20 VA: 0x185FD20 Slot: 25
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x186006C Offset: 0x185C06C VA: 0x186006C Slot: 34
	public override int ReadByte() { }

	// RVA: 0x18601C8 Offset: 0x185C1C8 VA: 0x18601C8 Slot: 30
	public override long Seek(long offset, SeekOrigin loc) { }

	// RVA: 0x18602B8 Offset: 0x185C2B8 VA: 0x18602B8 Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1860420 Offset: 0x185C420 VA: 0x1860420 Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x18605CC Offset: 0x185C5CC VA: 0x18605CC Slot: 36
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x185B028 Offset: 0x1857028 VA: 0x185B028
	internal void WriteCore(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x1860694 Offset: 0x185C694 VA: 0x1860694 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x186098C Offset: 0x185C98C VA: 0x186098C Slot: 29
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1860C48 Offset: 0x185CC48 VA: 0x1860C48 Slot: 37
	public override void WriteByte(byte value) { }
}

// Namespace: System.IO
[Serializable]
public class DriveNotFoundException : IOException // TypeDefIndex: 1574
{
	// Methods

	// RVA: 0x1860E5C Offset: 0x185CE5C VA: 0x1860E5C
	public void .ctor() { }

	// RVA: 0x1860EB8 Offset: 0x185CEB8 VA: 0x1860EB8
	public void .ctor(string message) { }

	// RVA: 0x1860EDC Offset: 0x185CEDC VA: 0x1860EDC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
public static class Directory // TypeDefIndex: 1575
{
	// Methods

	// RVA: 0x1860EE4 Offset: 0x185CEE4 VA: 0x1860EE4
	public static DirectoryInfo CreateDirectory(string path) { }

	// RVA: 0x1861024 Offset: 0x185D024 VA: 0x1861024
	public static bool Exists(string path) { }

	// RVA: 0x18611A0 Offset: 0x185D1A0 VA: 0x18611A0
	public static string[] GetFiles(string path) { }

	// RVA: 0x18612B0 Offset: 0x185D2B0 VA: 0x18612B0
	public static string[] GetFiles(string path, string searchPattern) { }

	// RVA: 0x1861350 Offset: 0x185D350 VA: 0x1861350
	public static string[] GetFiles(string path, string searchPattern, SearchOption searchOption) { }

	// RVA: 0x1861248 Offset: 0x185D248 VA: 0x1861248
	public static string[] GetFiles(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	// RVA: 0x1861510 Offset: 0x185D510 VA: 0x1861510
	internal static IEnumerable<string> InternalEnumeratePaths(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options) { }

	// RVA: 0x18563D8 Offset: 0x18523D8 VA: 0x18563D8
	public static IEnumerable<string> EnumerateFileSystemEntries(string path) { }

	// RVA: 0x18616D0 Offset: 0x185D6D0 VA: 0x18616D0
	public static IEnumerable<string> EnumerateFileSystemEntries(string path, string searchPattern, EnumerationOptions enumerationOptions) { }

	// RVA: 0x18559F4 Offset: 0x18519F4 VA: 0x18559F4
	internal static string InternalGetDirectoryRoot(string path) { }

	// RVA: 0x18616DC Offset: 0x185D6DC VA: 0x18616DC
	public static string GetCurrentDirectory() { }

	// RVA: 0x18616E4 Offset: 0x185D6E4 VA: 0x18616E4
	internal static string InsecureGetCurrentDirectory() { }
}

// Namespace: System.IO
[Serializable]
public sealed class DirectoryInfo : FileSystemInfo // TypeDefIndex: 1576
{
	// Methods

	// RVA: 0x1855BF8 Offset: 0x1851BF8 VA: 0x1855BF8
	public void .ctor(string path) { }

	// RVA: 0x18567FC Offset: 0x18527FC VA: 0x18567FC
	internal void .ctor(string originalPath, string fullPath, string fileName, bool isNormalized = False) { }

	// RVA: 0x18617F4 Offset: 0x185D7F4 VA: 0x18617F4
	private void Init(string originalPath, string fullPath, string fileName, bool isNormalized = False) { }

	// RVA: 0x1861A94 Offset: 0x185DA94 VA: 0x1861A94
	public FileInfo[] GetFiles() { }

	// RVA: 0x1861B3C Offset: 0x185DB3C VA: 0x1861B3C
	public FileInfo[] GetFiles(string searchPattern, EnumerationOptions enumerationOptions) { }

	// RVA: 0x1861D94 Offset: 0x185DD94 VA: 0x1861D94
	public DirectoryInfo[] GetDirectories() { }

	// RVA: 0x1861E3C Offset: 0x185DE3C VA: 0x1861E3C
	public DirectoryInfo[] GetDirectories(string searchPattern, EnumerationOptions enumerationOptions) { }

	// RVA: 0x1861BDC Offset: 0x185DBDC VA: 0x1861BDC
	internal static IEnumerable<FileSystemInfo> InternalEnumerateInfos(string path, string searchPattern, SearchTarget searchTarget, EnumerationOptions options) { }

	// RVA: 0x1861EDC Offset: 0x185DEDC VA: 0x1861EDC Slot: 11
	public override void Delete() { }

	// RVA: 0x1861EE8 Offset: 0x185DEE8 VA: 0x1861EE8
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
public class EnumerationOptions // TypeDefIndex: 1577
{
	// Fields
	[CompilerGenerated]
	private static readonly EnumerationOptions <Compatible>k__BackingField; // 0x0
	[CompilerGenerated]
	private static readonly EnumerationOptions <CompatibleRecursive>k__BackingField; // 0x8
	[CompilerGenerated]
	private static readonly EnumerationOptions <Default>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <RecurseSubdirectories>k__BackingField; // 0x10
	[CompilerGenerated]
	private bool <IgnoreInaccessible>k__BackingField; // 0x11
	[CompilerGenerated]
	private FileAttributes <AttributesToSkip>k__BackingField; // 0x14
	[CompilerGenerated]
	private MatchType <MatchType>k__BackingField; // 0x18
	[CompilerGenerated]
	private MatchCasing <MatchCasing>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <ReturnSpecialDirectories>k__BackingField; // 0x20

	// Properties
	internal static EnumerationOptions Compatible { get; }
	private static EnumerationOptions CompatibleRecursive { get; }
	internal static EnumerationOptions Default { get; }
	public bool RecurseSubdirectories { get; set; }
	public bool IgnoreInaccessible { get; set; }
	public FileAttributes AttributesToSkip { get; set; }
	public MatchType MatchType { get; set; }
	public MatchCasing MatchCasing { get; }
	public bool ReturnSpecialDirectories { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x186204C Offset: 0x185E04C VA: 0x186204C
	internal static EnumerationOptions get_Compatible() { }

	[CompilerGenerated]
	// RVA: 0x18620A4 Offset: 0x185E0A4 VA: 0x18620A4
	private static EnumerationOptions get_CompatibleRecursive() { }

	[CompilerGenerated]
	// RVA: 0x18620FC Offset: 0x185E0FC VA: 0x18620FC
	internal static EnumerationOptions get_Default() { }

	// RVA: 0x1862154 Offset: 0x185E154 VA: 0x1862154
	public void .ctor() { }

	// RVA: 0x18613C4 Offset: 0x185D3C4 VA: 0x18613C4
	internal static EnumerationOptions FromSearchOption(SearchOption searchOption) { }

	[CompilerGenerated]
	// RVA: 0x186217C Offset: 0x185E17C VA: 0x186217C
	public bool get_RecurseSubdirectories() { }

	[CompilerGenerated]
	// RVA: 0x1862184 Offset: 0x185E184 VA: 0x1862184
	public void set_RecurseSubdirectories(bool value) { }

	[CompilerGenerated]
	// RVA: 0x186218C Offset: 0x185E18C VA: 0x186218C
	public bool get_IgnoreInaccessible() { }

	[CompilerGenerated]
	// RVA: 0x1862194 Offset: 0x185E194 VA: 0x1862194
	public void set_IgnoreInaccessible(bool value) { }

	[CompilerGenerated]
	// RVA: 0x186219C Offset: 0x185E19C VA: 0x186219C
	public FileAttributes get_AttributesToSkip() { }

	[CompilerGenerated]
	// RVA: 0x18621A4 Offset: 0x185E1A4 VA: 0x18621A4
	public void set_AttributesToSkip(FileAttributes value) { }

	[CompilerGenerated]
	// RVA: 0x18621AC Offset: 0x185E1AC VA: 0x18621AC
	public MatchType get_MatchType() { }

	[CompilerGenerated]
	// RVA: 0x18621B4 Offset: 0x185E1B4 VA: 0x18621B4
	public void set_MatchType(MatchType value) { }

	[CompilerGenerated]
	// RVA: 0x18621BC Offset: 0x185E1BC VA: 0x18621BC
	public MatchCasing get_MatchCasing() { }

	[CompilerGenerated]
	// RVA: 0x18621C4 Offset: 0x185E1C4 VA: 0x18621C4
	public bool get_ReturnSpecialDirectories() { }

	// RVA: 0x18621CC Offset: 0x185E1CC VA: 0x18621CC
	private static void .cctor() { }
}

// Namespace: System.IO
public static class File // TypeDefIndex: 1578
{
	// Methods

	// RVA: 0x18622B4 Offset: 0x185E2B4 VA: 0x18622B4
	public static StreamReader OpenText(string path) { }

	// RVA: 0x1862370 Offset: 0x185E370 VA: 0x1862370
	public static void Copy(string sourceFileName, string destFileName, bool overwrite) { }

	// RVA: 0x1862504 Offset: 0x185E504 VA: 0x1862504
	public static void Delete(string path) { }

	// RVA: 0x185A850 Offset: 0x1856850 VA: 0x185A850
	public static bool Exists(string path) { }

	// RVA: 0x18625AC Offset: 0x185E5AC VA: 0x18625AC
	public static FileStream Open(string path, FileMode mode) { }

	// RVA: 0x18625C0 Offset: 0x185E5C0 VA: 0x18625C0
	public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share) { }

	// RVA: 0x1862644 Offset: 0x185E644 VA: 0x1862644
	internal static DateTimeOffset GetUtcDateTimeOffset(DateTime dateTime) { }

	// RVA: 0x1862720 Offset: 0x185E720 VA: 0x1862720
	public static void SetLastWriteTime(string path, DateTime lastWriteTime) { }

	// RVA: 0x18627D8 Offset: 0x185E7D8 VA: 0x18627D8
	public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc) { }

	// RVA: 0x1862864 Offset: 0x185E864 VA: 0x1862864
	public static FileStream OpenRead(string path) { }

	// RVA: 0x18628CC Offset: 0x185E8CC VA: 0x18628CC
	public static string ReadAllText(string path) { }

	// RVA: 0x1862B04 Offset: 0x185EB04 VA: 0x1862B04
	public static string ReadAllText(string path, Encoding encoding) { }

	// RVA: 0x1862990 Offset: 0x185E990 VA: 0x1862990
	private static string InternalReadAllText(string path, Encoding encoding) { }

	// RVA: 0x1862BD8 Offset: 0x185EBD8 VA: 0x1862BD8
	public static void WriteAllText(string path, string contents) { }

	// RVA: 0x1862DCC Offset: 0x185EDCC VA: 0x1862DCC
	public static void WriteAllText(string path, string contents, Encoding encoding) { }

	// RVA: 0x1862FFC Offset: 0x185EFFC VA: 0x1862FFC
	public static byte[] ReadAllBytes(string path) { }

	// RVA: 0x1863284 Offset: 0x185F284 VA: 0x1863284
	private static byte[] ReadAllBytesUnknownLength(FileStream fs) { }

	// RVA: 0x1863744 Offset: 0x185F744 VA: 0x1863744
	public static void WriteAllBytes(string path, byte[] bytes) { }

	// RVA: 0x1863840 Offset: 0x185F840 VA: 0x1863840
	private static void InternalWriteAllBytes(string path, byte[] bytes) { }
}

// Namespace: System.IO
[Serializable]
public sealed class FileInfo : FileSystemInfo // TypeDefIndex: 1579
{
	// Properties
	public long Length { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x18639BC Offset: 0x185F9BC VA: 0x18639BC
	private void .ctor() { }

	// RVA: 0x18639C0 Offset: 0x185F9C0 VA: 0x18639C0
	public void .ctor(string fileName) { }

	// RVA: 0x18566BC Offset: 0x18526BC VA: 0x18566BC
	internal void .ctor(string originalPath, string fullPath, string fileName, bool isNormalized = False) { }

	// RVA: 0x18639D0 Offset: 0x185F9D0 VA: 0x18639D0
	public long get_Length() { }

	// RVA: 0x1863AC4 Offset: 0x185FAC4 VA: 0x1863AC4 Slot: 11
	public override void Delete() { }

	// RVA: 0x1863ACC Offset: 0x185FACC VA: 0x1863ACC
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1863AD0 Offset: 0x185FAD0 VA: 0x1863AD0 Slot: 9
	public override string get_Name() { }
}

// Namespace: System.IO
internal struct FileStatus // TypeDefIndex: 1580
{
	// Fields
	private Interop.Sys.FileStatus _fileStatus; // 0x0
	private int _fileStatusInitialized; // 0x70
	[CompilerGenerated]
	private bool <InitiallyDirectory>k__BackingField; // 0x74
	internal bool _isDirectory; // 0x75
	private bool _exists; // 0x76

	// Properties
	internal bool InitiallyDirectory { get; set; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1863AD8 Offset: 0x185FAD8 VA: 0x1863AD8
	internal bool get_InitiallyDirectory() { }

	[CompilerGenerated]
	// RVA: 0x1863AE0 Offset: 0x185FAE0 VA: 0x1863AE0
	private void set_InitiallyDirectory(bool value) { }

	// RVA: 0x1863AE8 Offset: 0x185FAE8 VA: 0x1863AE8
	internal static void Initialize(ref FileStatus status, bool isDirectory) { }

	// RVA: 0x1863AF8 Offset: 0x185FAF8 VA: 0x1863AF8
	internal bool IsReadOnly(ReadOnlySpan<char> path, bool continueOnError = False) { }

	// RVA: 0x1863CA4 Offset: 0x185FCA4 VA: 0x1863CA4
	public FileAttributes GetAttributes(ReadOnlySpan<char> path, ReadOnlySpan<char> fileName) { }

	// RVA: 0x1863D8C Offset: 0x185FD8C VA: 0x1863D8C
	internal bool GetExists(ReadOnlySpan<char> path) { }

	// RVA: 0x1863F60 Offset: 0x185FF60 VA: 0x1863F60
	internal DateTimeOffset GetLastWriteTime(ReadOnlySpan<char> path, bool continueOnError = False) { }

	// RVA: 0x18640B4 Offset: 0x18600B4 VA: 0x18640B4
	internal void SetLastWriteTime(string path, DateTimeOffset time) { }

	// RVA: 0x1863FFC Offset: 0x185FFFC VA: 0x1863FFC
	private DateTimeOffset UnixTimeToDateTimeOffset(long seconds, long nanoseconds) { }

	// RVA: 0x18641F4 Offset: 0x18601F4 VA: 0x18641F4
	private void SetAccessWriteTimes(string path, Nullable<long> accessSec, Nullable<long> accessUSec, Nullable<long> writeSec, Nullable<long> writeUSec) { }

	// RVA: 0x18643A4 Offset: 0x18603A4 VA: 0x18643A4
	internal long GetLength(ReadOnlySpan<char> path, bool continueOnError = False) { }

	// RVA: 0x1863DD0 Offset: 0x185FDD0 VA: 0x1863DD0
	public void Refresh(ReadOnlySpan<char> path) { }

	// RVA: 0x1863BE4 Offset: 0x185FBE4 VA: 0x1863BE4
	internal void EnsureStatInitialized(ReadOnlySpan<char> path, bool continueOnError = False) { }
}

// Namespace: System.IO
[Serializable]
public abstract class FileSystemInfo : MarshalByRefObject, ISerializable // TypeDefIndex: 1581
{
	// Fields
	private FileStatus _fileStatus; // 0x18
	protected string FullPath; // 0x90
	protected string OriginalPath; // 0x98
	internal string _name; // 0xA0

	// Properties
	public FileAttributes Attributes { get; }
	internal bool ExistsCore { get; }
	internal DateTimeOffset LastWriteTimeCore { get; set; }
	internal long LengthCore { get; }
	public virtual string FullName { get; }
	public virtual string Name { get; }
	public virtual bool Exists { get; }
	public DateTime LastWriteTimeUtc { get; }

	// Methods

	// RVA: 0x1861780 Offset: 0x185D780 VA: 0x1861780
	protected void .ctor() { }

	// RVA: 0x18643BC Offset: 0x18603BC VA: 0x18643BC
	internal static FileSystemInfo Create(string fullPath, string fileName, ref FileStatus fileStatus) { }

	// RVA: 0x186448C Offset: 0x186048C VA: 0x186448C
	internal void Init(ref FileStatus fileStatus) { }

	// RVA: 0x185630C Offset: 0x185230C VA: 0x185630C
	public FileAttributes get_Attributes() { }

	// RVA: 0x1864504 Offset: 0x1860504 VA: 0x1864504
	internal bool get_ExistsCore() { }

	// RVA: 0x186459C Offset: 0x186059C VA: 0x186459C
	internal DateTimeOffset get_LastWriteTimeCore() { }

	// RVA: 0x1856844 Offset: 0x1852844 VA: 0x1856844
	internal void set_LastWriteTimeCore(DateTimeOffset value) { }

	// RVA: 0x1863A50 Offset: 0x185FA50 VA: 0x1863A50
	internal long get_LengthCore() { }

	// RVA: 0x1861EEC Offset: 0x185DEEC VA: 0x1861EEC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	[ComVisible(False)]
	// RVA: 0x1864608 Offset: 0x1860608 VA: 0x1864608 Slot: 7
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1864734 Offset: 0x1860734 VA: 0x1864734 Slot: 8
	public virtual string get_FullName() { }

	// RVA: 0x186473C Offset: 0x186073C VA: 0x186473C Slot: 9
	public virtual string get_Name() { }

	// RVA: 0x1864744 Offset: 0x1860744 VA: 0x1864744 Slot: 10
	public virtual bool get_Exists() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void Delete();

	// RVA: 0x18647CC Offset: 0x18607CC VA: 0x18647CC
	public DateTime get_LastWriteTimeUtc() { }

	// RVA: 0x1864844 Offset: 0x1860844 VA: 0x1864844 Slot: 3
	public override string ToString() { }
}

// Namespace: System.IO
public enum MatchCasing // TypeDefIndex: 1582
{
	// Fields
	public int value__; // 0x0
	public const MatchCasing PlatformDefault = 0;
	public const MatchCasing CaseSensitive = 1;
	public const MatchCasing CaseInsensitive = 2;
}

// Namespace: System.IO
public enum MatchType // TypeDefIndex: 1583
{
	// Fields
	public int value__; // 0x0
	public const MatchType Simple = 0;
	public const MatchType Win32 = 1;
}

// Namespace: System.IO
public enum SearchOption // TypeDefIndex: 1584
{
	// Fields
	public int value__; // 0x0
	public const SearchOption TopDirectoryOnly = 0;
	public const SearchOption AllDirectories = 1;
}

// Namespace: System.IO
internal enum SearchTarget // TypeDefIndex: 1585
{
	// Fields
	public int value__; // 0x0
	public const SearchTarget Files = 1;
	public const SearchTarget Directories = 2;
	public const SearchTarget Both = 3;
}

// Namespace: System.IO
[Flags]
public enum FileAttributes // TypeDefIndex: 1586
{
	// Fields
	public int value__; // 0x0
	public const FileAttributes ReadOnly = 1;
	public const FileAttributes Hidden = 2;
	public const FileAttributes System = 4;
	public const FileAttributes Directory = 16;
	public const FileAttributes Archive = 32;
	public const FileAttributes Device = 64;
	public const FileAttributes Normal = 128;
	public const FileAttributes Temporary = 256;
	public const FileAttributes SparseFile = 512;
	public const FileAttributes ReparsePoint = 1024;
	public const FileAttributes Compressed = 2048;
	public const FileAttributes Offline = 4096;
	public const FileAttributes NotContentIndexed = 8192;
	public const FileAttributes Encrypted = 16384;
	public const FileAttributes IntegrityStream = 32768;
	public const FileAttributes NoScrubData = 131072;
}

// Namespace: 
private struct Stream.ReadWriteParameters // TypeDefIndex: 1587
{
	// Fields
	internal byte[] Buffer; // 0x0
	internal int Offset; // 0x8
	internal int Count; // 0xC
}

// Namespace: 
private sealed class Stream.ReadWriteTask : Task<int>, ITaskCompletionAction // TypeDefIndex: 1588
{
	// Fields
	internal readonly bool _isRead; // 0x54
	internal readonly bool _apm; // 0x55
	internal Stream _stream; // 0x58
	internal byte[] _buffer; // 0x60
	internal readonly int _offset; // 0x68
	internal readonly int _count; // 0x6C
	private AsyncCallback _callback; // 0x70
	private ExecutionContext _context; // 0x78
	private static ContextCallback s_invokeAsyncCallback; // 0x0

	// Properties
	private bool System.Threading.Tasks.ITaskCompletionAction.InvokeMayRunArbitraryCode { get; }

	// Methods

	// RVA: 0x1866DCC Offset: 0x1862DCC VA: 0x1866DCC
	internal void ClearBeginState() { }

	// RVA: 0x1864E30 Offset: 0x1860E30 VA: 0x1864E30
	public void .ctor(bool isRead, bool apm, Func<object, int> function, object state, Stream stream, byte[] buffer, int offset, int count, AsyncCallback callback) { }

	// RVA: 0x1866DF4 Offset: 0x1862DF4 VA: 0x1866DF4
	private static void InvokeAsyncCallback(object completedTask) { }

	// RVA: 0x1866E7C Offset: 0x1862E7C VA: 0x1866E7C Slot: 14
	private void System.Threading.Tasks.ITaskCompletionAction.Invoke(Task completingTask) { }

	// RVA: 0x1866FC0 Offset: 0x1862FC0 VA: 0x1866FC0 Slot: 15
	private bool System.Threading.Tasks.ITaskCompletionAction.get_InvokeMayRunArbitraryCode() { }
}

// Namespace: 
private sealed class Stream.NullStream : Stream // TypeDefIndex: 1589
{
	// Fields
	private static readonly Task<int> s_zeroTask; // 0x0

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1866D74 Offset: 0x1862D74 VA: 0x1866D74
	internal void .ctor() { }

	// RVA: 0x1866FC8 Offset: 0x1862FC8 VA: 0x1866FC8 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1866FD0 Offset: 0x1862FD0 VA: 0x1866FD0 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1866FD8 Offset: 0x1862FD8 VA: 0x1866FD8 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1866FE0 Offset: 0x1862FE0 VA: 0x1866FE0 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1866FE8 Offset: 0x1862FE8 VA: 0x1866FE8 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1866FF0 Offset: 0x1862FF0 VA: 0x1866FF0 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1866FF4 Offset: 0x1862FF4 VA: 0x1866FF4 Slot: 18
	public override void CopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x1866FF8 Offset: 0x1862FF8 VA: 0x1866FF8 Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1866FFC Offset: 0x1862FFC VA: 0x1866FFC Slot: 21
	public override void Flush() { }

	// RVA: 0x1867000 Offset: 0x1863000 VA: 0x1867000 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1867088 Offset: 0x1863088 VA: 0x1867088 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1867128 Offset: 0x1863128 VA: 0x1867128 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x18671B0 Offset: 0x18631B0 VA: 0x18671B0 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1867250 Offset: 0x1863250 VA: 0x1867250 Slot: 32
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1867258 Offset: 0x1863258 VA: 0x1867258 Slot: 33
	public override int Read(Span<byte> buffer) { }

	// RVA: 0x1867260 Offset: 0x1863260 VA: 0x1867260 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x18672B8 Offset: 0x18632B8 VA: 0x18672B8 Slot: 25
	public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x186730C Offset: 0x186330C VA: 0x186730C Slot: 34
	public override int ReadByte() { }

	// RVA: 0x1867314 Offset: 0x1863314 VA: 0x1867314 Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1867318 Offset: 0x1863318 VA: 0x1867318 Slot: 36
	public override void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x186731C Offset: 0x186331C VA: 0x186731C Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1867400 Offset: 0x1863400 VA: 0x1867400 Slot: 29
	public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x18674DC Offset: 0x18634DC VA: 0x18674DC Slot: 37
	public override void WriteByte(byte value) { }

	// RVA: 0x18674E0 Offset: 0x18634E0 VA: 0x18674E0 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x18674E8 Offset: 0x18634E8 VA: 0x18674E8 Slot: 31
	public override void SetLength(long length) { }

	// RVA: 0x18674EC Offset: 0x18634EC VA: 0x18674EC
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Stream.SynchronousAsyncResult.<>c // TypeDefIndex: 1590
{
	// Fields
	public static readonly Stream.SynchronousAsyncResult.<>c <>9; // 0x0
	public static Func<ManualResetEvent> <>9__12_0; // 0x8

	// Methods

	// RVA: 0x18676A8 Offset: 0x18636A8 VA: 0x18676A8
	private static void .cctor() { }

	// RVA: 0x1867710 Offset: 0x1863710 VA: 0x1867710
	public void .ctor() { }

	// RVA: 0x1867718 Offset: 0x1863718 VA: 0x1867718
	internal ManualResetEvent <get_AsyncWaitHandle>b__12_0() { }
}

// Namespace: 
private sealed class Stream.SynchronousAsyncResult : IAsyncResult // TypeDefIndex: 1591
{
	// Fields
	private readonly object _stateObject; // 0x10
	private readonly bool _isWrite; // 0x18
	private ManualResetEvent _waitHandle; // 0x20
	private ExceptionDispatchInfo _exceptionInfo; // 0x28
	private bool _endXxxCalled; // 0x30
	private int _bytesRead; // 0x34

	// Properties
	public bool IsCompleted { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }

	// Methods

	// RVA: 0x18668DC Offset: 0x18628DC VA: 0x18668DC
	internal void .ctor(int bytesRead, object asyncStateObject) { }

	// RVA: 0x1866BD0 Offset: 0x1862BD0 VA: 0x1866BD0
	internal void .ctor(object asyncStateObject) { }

	// RVA: 0x1866914 Offset: 0x1862914 VA: 0x1866914
	internal void .ctor(Exception ex, object asyncStateObject, bool isWrite) { }

	// RVA: 0x1867584 Offset: 0x1863584 VA: 0x1867584 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x186758C Offset: 0x186358C VA: 0x186758C Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1867684 Offset: 0x1863684 VA: 0x1867684 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x186768C Offset: 0x186368C VA: 0x186768C Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1867694 Offset: 0x1863694 VA: 0x1867694
	internal void ThrowIfError() { }

	// RVA: 0x186697C Offset: 0x186297C VA: 0x186697C
	internal static int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1866C10 Offset: 0x1862C10 VA: 0x1866C10
	internal static void EndWrite(IAsyncResult asyncResult) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Stream.<>c // TypeDefIndex: 1592
{
	// Fields
	public static readonly Stream.<>c <>9; // 0x0
	public static Func<SemaphoreSlim> <>9__4_0; // 0x8
	public static Func<object, int> <>9__40_0; // 0x10
	public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__45_0; // 0x18
	public static Func<Stream, IAsyncResult, int> <>9__45_1; // 0x20
	public static Func<object, int> <>9__48_0; // 0x28
	public static Action<Task, object> <>9__49_0; // 0x30
	public static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, object, IAsyncResult> <>9__58_0; // 0x38
	public static Func<Stream, IAsyncResult, VoidTaskResult> <>9__58_1; // 0x40

	// Methods

	// RVA: 0x1867770 Offset: 0x1863770 VA: 0x1867770
	private static void .cctor() { }

	// RVA: 0x18677D8 Offset: 0x18637D8 VA: 0x18677D8
	public void .ctor() { }

	// RVA: 0x18677E0 Offset: 0x18637E0 VA: 0x18677E0
	internal SemaphoreSlim <EnsureAsyncActiveSemaphoreInitialized>b__4_0() { }

	// RVA: 0x186783C Offset: 0x186383C VA: 0x186783C
	internal int <BeginReadInternal>b__40_0(object <p0>) { }

	// RVA: 0x18679E4 Offset: 0x18639E4 VA: 0x18679E4
	internal IAsyncResult <BeginEndReadAsync>b__45_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x1867A14 Offset: 0x1863A14 VA: 0x1867A14
	internal int <BeginEndReadAsync>b__45_1(Stream stream, IAsyncResult asyncResult) { }

	// RVA: 0x1867A3C Offset: 0x1863A3C VA: 0x1867A3C
	internal int <BeginWriteInternal>b__48_0(object <p0>) { }

	// RVA: 0x1867BD4 Offset: 0x1863BD4 VA: 0x1867BD4
	internal void <RunReadWriteTaskWhenReady>b__49_0(Task t, object state) { }

	// RVA: 0x1867C40 Offset: 0x1863C40 VA: 0x1867C40
	internal IAsyncResult <BeginEndWriteAsync>b__58_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, object state) { }

	// RVA: 0x1867C70 Offset: 0x1863C70 VA: 0x1867C70
	internal VoidTaskResult <BeginEndWriteAsync>b__58_1(Stream stream, IAsyncResult asyncResult) { }
}

// Namespace: 
[CompilerGenerated]
private struct Stream.<FinishWriteAsync>d__57 : IAsyncStateMachine // TypeDefIndex: 1593
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Task writeTask; // 0x20
	public byte[] localBuffer; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1867CA4 Offset: 0x1863CA4 VA: 0x1867CA4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1867F40 Offset: 0x1863F40 VA: 0x1867F40 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct Stream.<<ReadAsync>g__FinishReadAsync|44_0>d : IAsyncStateMachine // TypeDefIndex: 1594
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncValueTaskMethodBuilder<int> <>t__builder; // 0x8
	public Task<int> readTask; // 0x28
	public byte[] localBuffer; // 0x30
	public Memory<byte> localDestination; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48

	// Methods

	// RVA: 0x1867FA8 Offset: 0x1863FA8 VA: 0x1867FA8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1868334 Offset: 0x1864334 VA: 0x1868334 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.IO
[Serializable]
public abstract class Stream : MarshalByRefObject, IDisposable // TypeDefIndex: 1595
{
	// Fields
	public static readonly Stream Null; // 0x0
	private Stream.ReadWriteTask _activeReadWriteTask; // 0x18
	private SemaphoreSlim _asyncActiveSemaphore; // 0x20

	// Properties
	public abstract bool CanRead { get; }
	public abstract bool CanSeek { get; }
	public virtual bool CanTimeout { get; }
	public abstract bool CanWrite { get; }
	public abstract long Length { get; }
	public abstract long Position { get; set; }
	public virtual int ReadTimeout { get; set; }
	public virtual int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x1864868 Offset: 0x1860868 VA: 0x1864868
	internal SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_CanRead();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool get_CanSeek();

	// RVA: 0x1864960 Offset: 0x1860960 VA: 0x1864960 Slot: 9
	public virtual bool get_CanTimeout() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_CanWrite();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract long get_Length();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract long get_Position();

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void set_Position(long value);

	// RVA: 0x1864968 Offset: 0x1860968 VA: 0x1864968 Slot: 14
	public virtual int get_ReadTimeout() { }

	// RVA: 0x18649B4 Offset: 0x18609B4 VA: 0x18649B4 Slot: 15
	public virtual void set_ReadTimeout(int value) { }

	// RVA: 0x1864A00 Offset: 0x1860A00 VA: 0x1864A00 Slot: 16
	public virtual int get_WriteTimeout() { }

	// RVA: 0x1864A4C Offset: 0x1860A4C VA: 0x1864A4C Slot: 17
	public virtual void set_WriteTimeout(int value) { }

	// RVA: 0x1864A98 Offset: 0x1860A98 VA: 0x1864A98
	public void CopyTo(Stream destination) { }

	// RVA: 0x1859164 Offset: 0x1855164 VA: 0x1859164 Slot: 18
	public virtual void CopyTo(Stream destination, int bufferSize) { }

	// RVA: 0x1864AD0 Offset: 0x1860AD0 VA: 0x1864AD0
	private int GetCopyBufferSize() { }

	// RVA: 0x1864B94 Offset: 0x1860B94 VA: 0x1864B94 Slot: 19
	public virtual void Close() { }

	// RVA: 0x1864C04 Offset: 0x1860C04 VA: 0x1864C04 Slot: 6
	public void Dispose() { }

	// RVA: 0x185F50C Offset: 0x185B50C VA: 0x185F50C Slot: 20
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void Flush();

	// RVA: 0x1864C14 Offset: 0x1860C14 VA: 0x1864C14 Slot: 22
	public virtual IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1864C34 Offset: 0x1860C34 VA: 0x1864C34
	internal IAsyncResult BeginReadInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	// RVA: 0x1865204 Offset: 0x1861204 VA: 0x1865204 Slot: 23
	public virtual int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x18653C0 Offset: 0x18613C0 VA: 0x18653C0
	public Task<int> ReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x1865454 Offset: 0x1861454 VA: 0x1865454 Slot: 24
	public virtual Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1865714 Offset: 0x1861714 VA: 0x1865714 Slot: 25
	public virtual ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken) { }

	// RVA: 0x1865534 Offset: 0x1861534 VA: 0x1865534
	private Task<int> BeginEndReadAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x1865B3C Offset: 0x1861B3C VA: 0x1865B3C Slot: 26
	public virtual IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1865B5C Offset: 0x1861B5C VA: 0x1865B5C
	internal IAsyncResult BeginWriteInternal(byte[] buffer, int offset, int count, AsyncCallback callback, object state, bool serializeAsynchronously, bool apm) { }

	// RVA: 0x1864FB4 Offset: 0x1860FB4 VA: 0x1864FB4
	private void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x186513C Offset: 0x186113C VA: 0x186513C
	private void RunReadWriteTask(Stream.ReadWriteTask readWriteTask) { }

	// RVA: 0x1865D64 Offset: 0x1861D64 VA: 0x1865D64
	private void FinishTrackingAsyncOperation() { }

	// RVA: 0x1865D94 Offset: 0x1861D94 VA: 0x1865D94 Slot: 27
	public virtual void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1865F48 Offset: 0x1861F48 VA: 0x1865F48
	public Task WriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: 0x1865FDC Offset: 0x1861FDC VA: 0x1865FDC Slot: 28
	public virtual Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1866288 Offset: 0x1862288 VA: 0x1866288 Slot: 29
	public virtual ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(Stream.<FinishWriteAsync>d__57))]
	// RVA: 0x1866550 Offset: 0x1862550 VA: 0x1866550
	private Task FinishWriteAsync(Task writeTask, byte[] localBuffer) { }

	// RVA: 0x18660A8 Offset: 0x18620A8 VA: 0x18660A8
	private Task BeginEndWriteAsync(byte[] buffer, int offset, int count) { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract long Seek(long offset, SeekOrigin origin);

	// RVA: -1 Offset: -1 Slot: 31
	public abstract void SetLength(long value);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract int Read(byte[] buffer, int offset, int count);

	// RVA: 0x18583C0 Offset: 0x18543C0 VA: 0x18583C0 Slot: 33
	public virtual int Read(Span<byte> buffer) { }

	// RVA: 0x1866650 Offset: 0x1862650 VA: 0x1866650 Slot: 34
	public virtual int ReadByte() { }

	// RVA: -1 Offset: -1 Slot: 35
	public abstract void Write(byte[] buffer, int offset, int count);

	// RVA: 0x1859AEC Offset: 0x1855AEC VA: 0x1859AEC Slot: 36
	public virtual void Write(ReadOnlySpan<byte> buffer) { }

	// RVA: 0x18666E4 Offset: 0x18626E4 VA: 0x18666E4 Slot: 37
	public virtual void WriteByte(byte value) { }

	// RVA: 0x1866770 Offset: 0x1862770 VA: 0x1866770
	internal IAsyncResult BlockingBeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1866978 Offset: 0x1862978 VA: 0x1866978
	internal static int BlockingEndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1866A64 Offset: 0x1862A64 VA: 0x1866A64
	internal IAsyncResult BlockingBeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1866C0C Offset: 0x1862C0C VA: 0x1866C0C
	internal static void BlockingEndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1865B34 Offset: 0x1861B34 VA: 0x1865B34
	private bool HasOverriddenBeginEndRead() { }

	// RVA: 0x1866648 Offset: 0x1862648 VA: 0x1866648
	private bool HasOverriddenBeginEndWrite() { }

	// RVA: 0x185774C Offset: 0x185374C VA: 0x185774C
	protected void .ctor() { }

	// RVA: 0x1866CFC Offset: 0x1862CFC VA: 0x1866CFC
	private static void .cctor() { }

	[AsyncStateMachine(typeof(Stream.<<ReadAsync>g__FinishReadAsync|44_0>d))]
	[CompilerGenerated]
	// RVA: 0x18659C8 Offset: 0x18619C8 VA: 0x18659C8
	internal static ValueTask<int> <ReadAsync>g__FinishReadAsync|44_0(Task<int> readTask, byte[] localBuffer, Memory<byte> localDestination) { }
}

// Namespace: System.IO
internal static class __Error // TypeDefIndex: 1596
{
	// Methods

	// RVA: 0x186838C Offset: 0x186438C VA: 0x186838C
	internal static void EndOfFile() { }

	// RVA: 0x18683E0 Offset: 0x18643E0 VA: 0x18683E0
	internal static void FileNotOpen() { }

	// RVA: 0x186843C Offset: 0x186443C VA: 0x186843C
	internal static void ReaderClosed() { }

	// RVA: 0x1868498 Offset: 0x1864498 VA: 0x1868498
	internal static string GetDisplayablePath(string path, bool isInvalidPath) { }

	// RVA: 0x18685D0 Offset: 0x18645D0 VA: 0x18685D0
	internal static void WinIOError(int errorCode, string maybeFullPath) { }

	// RVA: 0x1868AF8 Offset: 0x1864AF8 VA: 0x1868AF8
	internal static void WriterClosed() { }
}

// Namespace: System.IO
[ComVisible(True)]
public class BinaryReader : IDisposable // TypeDefIndex: 1597
{
	// Fields
	private Stream m_stream; // 0x10
	private byte[] m_buffer; // 0x18
	private Decoder m_decoder; // 0x20
	private byte[] m_charBytes; // 0x28
	private char[] m_singleChar; // 0x30
	private char[] m_charBuffer; // 0x38
	private int m_maxCharsSize; // 0x40
	private bool m_2BytesPerChar; // 0x44
	private bool m_isMemoryStream; // 0x45
	private bool m_leaveOpen; // 0x46

	// Properties
	public virtual Stream BaseStream { get; }

	// Methods

	// RVA: 0x1868B54 Offset: 0x1864B54 VA: 0x1868B54
	public void .ctor(Stream input) { }

	// RVA: 0x1868E54 Offset: 0x1864E54 VA: 0x1868E54
	public void .ctor(Stream input, Encoding encoding) { }

	// RVA: 0x1868BC4 Offset: 0x1864BC4 VA: 0x1868BC4
	public void .ctor(Stream input, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x1868E5C Offset: 0x1864E5C VA: 0x1868E5C Slot: 5
	public virtual Stream get_BaseStream() { }

	// RVA: 0x1868E64 Offset: 0x1864E64 VA: 0x1868E64 Slot: 6
	public virtual void Close() { }

	// RVA: 0x1868E74 Offset: 0x1864E74 VA: 0x1868E74 Slot: 7
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1868F20 Offset: 0x1864F20 VA: 0x1868F20 Slot: 4
	public void Dispose() { }

	// RVA: 0x1868F30 Offset: 0x1864F30 VA: 0x1868F30 Slot: 8
	public virtual int Read() { }

	// RVA: 0x18691D8 Offset: 0x18651D8 VA: 0x18691D8 Slot: 9
	public virtual bool ReadBoolean() { }

	// RVA: 0x1869220 Offset: 0x1865220 VA: 0x1869220 Slot: 10
	public virtual byte ReadByte() { }

	[CLSCompliant(False)]
	// RVA: 0x1869254 Offset: 0x1865254 VA: 0x1869254 Slot: 11
	public virtual sbyte ReadSByte() { }

	// RVA: 0x1869294 Offset: 0x1865294 VA: 0x1869294 Slot: 12
	public virtual char ReadChar() { }

	// RVA: 0x18692B8 Offset: 0x18652B8 VA: 0x18692B8 Slot: 13
	public virtual short ReadInt16() { }

	[CLSCompliant(False)]
	// RVA: 0x1869300 Offset: 0x1865300 VA: 0x1869300 Slot: 14
	public virtual ushort ReadUInt16() { }

	// RVA: 0x1869348 Offset: 0x1865348 VA: 0x1869348 Slot: 15
	public virtual int ReadInt32() { }

	[CLSCompliant(False)]
	// RVA: 0x1869438 Offset: 0x1865438 VA: 0x1869438 Slot: 16
	public virtual uint ReadUInt32() { }

	// RVA: 0x18694A8 Offset: 0x18654A8 VA: 0x18694A8 Slot: 17
	public virtual long ReadInt64() { }

	[CLSCompliant(False)]
	// RVA: 0x1869558 Offset: 0x1865558 VA: 0x1869558 Slot: 18
	public virtual ulong ReadUInt64() { }

	// RVA: 0x1869608 Offset: 0x1865608 VA: 0x1869608 Slot: 19
	public virtual float ReadSingle() { }

	// RVA: 0x1869638 Offset: 0x1865638 VA: 0x1869638 Slot: 20
	public virtual double ReadDouble() { }

	// RVA: 0x1869668 Offset: 0x1865668 VA: 0x1869668 Slot: 21
	public virtual Decimal ReadDecimal() { }

	// RVA: 0x186984C Offset: 0x186584C VA: 0x186984C Slot: 22
	public virtual string ReadString() { }

	// RVA: 0x1869B9C Offset: 0x1865B9C VA: 0x1869B9C
	private int InternalReadChars(char[] buffer, int index, int count) { }

	// RVA: 0x1868F44 Offset: 0x1864F44 VA: 0x1868F44
	private int InternalReadOneChar() { }

	// RVA: 0x1869EC4 Offset: 0x1865EC4 VA: 0x1869EC4 Slot: 23
	public virtual char[] ReadChars(int count) { }

	// RVA: 0x186A020 Offset: 0x1866020 VA: 0x186A020 Slot: 24
	public virtual int Read(byte[] buffer, int index, int count) { }

	// RVA: 0x186A190 Offset: 0x1866190 VA: 0x186A190 Slot: 25
	public virtual byte[] ReadBytes(int count) { }

	// RVA: 0x186A31C Offset: 0x186631C VA: 0x186A31C Slot: 26
	protected virtual void FillBuffer(int numBytes) { }

	// RVA: 0x1869AFC Offset: 0x1865AFC VA: 0x1869AFC
	protected internal int Read7BitEncodedInt() { }
}

// Namespace: System.IO
[ComVisible(True)]
[Serializable]
public class BinaryWriter : IDisposable // TypeDefIndex: 1598
{
	// Fields
	public static readonly BinaryWriter Null; // 0x0
	protected Stream OutStream; // 0x10
	private byte[] _buffer; // 0x18
	private Encoding _encoding; // 0x20
	private Encoder _encoder; // 0x28
	[OptionalField]
	private bool _leaveOpen; // 0x30
	private byte[] _largeByteBuffer; // 0x38
	private int _maxChars; // 0x40

	// Properties
	public virtual Stream BaseStream { get; }

	// Methods

	// RVA: 0x186A738 Offset: 0x1866738 VA: 0x186A738
	protected void .ctor() { }

	// RVA: 0x186A850 Offset: 0x1866850 VA: 0x186A850
	public void .ctor(Stream output) { }

	// RVA: 0x186AA70 Offset: 0x1866A70 VA: 0x186AA70
	public void .ctor(Stream output, Encoding encoding) { }

	// RVA: 0x186A8C8 Offset: 0x18668C8 VA: 0x186A8C8
	public void .ctor(Stream output, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x186AA78 Offset: 0x1866A78 VA: 0x186AA78 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x186AACC Offset: 0x1866ACC VA: 0x186AACC Slot: 4
	public void Dispose() { }

	// RVA: 0x186AADC Offset: 0x1866ADC VA: 0x186AADC Slot: 6
	public virtual Stream get_BaseStream() { }

	// RVA: 0x186AAFC Offset: 0x1866AFC VA: 0x186AAFC Slot: 7
	public virtual void Flush() { }

	// RVA: 0x186AB1C Offset: 0x1866B1C VA: 0x186AB1C Slot: 8
	public virtual void Write(bool value) { }

	// RVA: 0x186AB6C Offset: 0x1866B6C VA: 0x186AB6C Slot: 9
	public virtual void Write(byte value) { }

	// RVA: 0x186AB8C Offset: 0x1866B8C VA: 0x186AB8C Slot: 10
	public virtual void Write(byte[] buffer) { }

	// RVA: 0x186AC04 Offset: 0x1866C04 VA: 0x186AC04 Slot: 11
	public virtual void Write(byte[] buffer, int index, int count) { }

	// RVA: 0x186AC24 Offset: 0x1866C24 VA: 0x186AC24 Slot: 12
	public virtual void Write(char ch) { }

	// RVA: 0x186AD20 Offset: 0x1866D20 VA: 0x186AD20 Slot: 13
	public virtual void Write(char[] chars) { }

	// RVA: 0x186ADC4 Offset: 0x1866DC4 VA: 0x186ADC4 Slot: 14
	public virtual void Write(double value) { }

	// RVA: 0x186AE00 Offset: 0x1866E00 VA: 0x186AE00 Slot: 15
	public virtual void Write(short value) { }

	[CLSCompliant(False)]
	// RVA: 0x186AE68 Offset: 0x1866E68 VA: 0x186AE68 Slot: 16
	public virtual void Write(ushort value) { }

	// RVA: 0x186AED0 Offset: 0x1866ED0 VA: 0x186AED0 Slot: 17
	public virtual void Write(int value) { }

	[CLSCompliant(False)]
	// RVA: 0x186AF70 Offset: 0x1866F70 VA: 0x186AF70 Slot: 18
	public virtual void Write(uint value) { }

	// RVA: 0x186B010 Offset: 0x1867010 VA: 0x186B010 Slot: 19
	public virtual void Write(long value) { }

	[CLSCompliant(False)]
	// RVA: 0x186B120 Offset: 0x1867120 VA: 0x186B120 Slot: 20
	public virtual void Write(ulong value) { }

	// RVA: 0x186B230 Offset: 0x1867230 VA: 0x186B230 Slot: 21
	public virtual void Write(float value) { }

	// RVA: 0x186B26C Offset: 0x186726C VA: 0x186B26C Slot: 22
	public virtual void Write(string value) { }

	// RVA: 0x186B52C Offset: 0x186752C VA: 0x186B52C
	protected void Write7BitEncodedInt(int value) { }

	// RVA: 0x186B588 Offset: 0x1867588 VA: 0x186B588
	private static void .cctor() { }
}

// Namespace: System.IO
[ComVisible(True)]
[Serializable]
public class StringReader : TextReader // TypeDefIndex: 1599
{
	// Fields
	private string _s; // 0x18
	private int _pos; // 0x20
	private int _length; // 0x24

	// Methods

	// RVA: 0x186B5EC Offset: 0x18675EC VA: 0x186B5EC
	public void .ctor(string s) { }

	// RVA: 0x186B6B8 Offset: 0x18676B8 VA: 0x186B6B8 Slot: 7
	public override void Close() { }

	// RVA: 0x186B6C8 Offset: 0x18676C8 VA: 0x186B6C8 Slot: 8
	protected override void Dispose(bool disposing) { }

	// RVA: 0x186B700 Offset: 0x1867700 VA: 0x186B700 Slot: 9
	public override int Peek() { }

	// RVA: 0x186B74C Offset: 0x186774C VA: 0x186B74C Slot: 10
	public override int Read() { }

	// RVA: 0x186B7A0 Offset: 0x18677A0 VA: 0x186B7A0 Slot: 11
	public override int Read([In] [Out] char[] buffer, int index, int count) { }

	// RVA: 0x186B968 Offset: 0x1867968 VA: 0x186B968 Slot: 12
	public override string ReadToEnd() { }

	// RVA: 0x186B9B4 Offset: 0x18679B4 VA: 0x186B9B4 Slot: 13
	public override string ReadLine() { }
}

// Namespace: System.IO
[ComVisible(True)]
[Serializable]
public class StringWriter : TextWriter // TypeDefIndex: 1600
{
	// Fields
	private static UnicodeEncoding m_encoding; // 0x0
	private StringBuilder _sb; // 0x30
	private bool _isOpen; // 0x38

	// Properties
	public override Encoding Encoding { get; }

	// Methods

	// RVA: 0x186BACC Offset: 0x1867ACC VA: 0x186BACC
	public void .ctor() { }

	// RVA: 0x186BC50 Offset: 0x1867C50 VA: 0x186BC50
	public void .ctor(IFormatProvider formatProvider) { }

	// RVA: 0x186BCBC Offset: 0x1867CBC VA: 0x186BCBC
	public void .ctor(StringBuilder sb) { }

	// RVA: 0x186BB60 Offset: 0x1867B60 VA: 0x186BB60
	public void .ctor(StringBuilder sb, IFormatProvider formatProvider) { }

	// RVA: 0x186BD2C Offset: 0x1867D2C VA: 0x186BD2C Slot: 8
	public override void Close() { }

	// RVA: 0x186BD3C Offset: 0x1867D3C VA: 0x186BD3C Slot: 9
	protected override void Dispose(bool disposing) { }

	// RVA: 0x186BD48 Offset: 0x1867D48 VA: 0x186BD48 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x186BDFC Offset: 0x1867DFC VA: 0x186BDFC Slot: 13
	public override void Write(char value) { }

	// RVA: 0x186BE3C Offset: 0x1867E3C VA: 0x186BE3C Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x186BFD8 Offset: 0x1867FD8 VA: 0x186BFD8 Slot: 16
	public override void Write(string value) { }

	// RVA: 0x186C02C Offset: 0x186802C VA: 0x186C02C Slot: 3
	public override string ToString() { }
}

// Namespace: 
private sealed class FileStream.ReadDelegate : MulticastDelegate // TypeDefIndex: 1601
{
	// Methods

	// RVA: 0x186F5B8 Offset: 0x186B5B8 VA: 0x186F5B8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1871178 Offset: 0x186D178 VA: 0x1871178 Slot: 12
	public virtual int Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x186F66C Offset: 0x186B66C VA: 0x186F66C Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x186F850 Offset: 0x186B850 VA: 0x186F850 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: 
private sealed class FileStream.WriteDelegate : MulticastDelegate // TypeDefIndex: 1602
{
	// Methods

	// RVA: 0x18701E8 Offset: 0x186C1E8 VA: 0x18701E8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x187118C Offset: 0x186D18C VA: 0x187118C Slot: 12
	public virtual void Invoke(byte[] buffer, int offset, int count) { }

	// RVA: 0x187029C Offset: 0x186C29C VA: 0x187029C Slot: 13
	public virtual IAsyncResult BeginInvoke(byte[] buffer, int offset, int count, AsyncCallback callback, object object) { }

	// RVA: 0x1870484 Offset: 0x186C484 VA: 0x1870484 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: System.IO
[ComVisible(True)]
public class FileStream : Stream // TypeDefIndex: 1603
{
	// Fields
	private static byte[] buf_recycle; // 0x0
	private static readonly object buf_recycle_lock; // 0x8
	private byte[] buf; // 0x28
	private string name; // 0x30
	private SafeFileHandle safeHandle; // 0x38
	private bool isExposed; // 0x40
	private long append_startpos; // 0x48
	private FileAccess access; // 0x50
	private bool owner; // 0x54
	private bool async; // 0x55
	private bool canseek; // 0x56
	private bool anonymous; // 0x57
	private bool buf_dirty; // 0x58
	private int buf_size; // 0x5C
	private int buf_length; // 0x60
	private int buf_offset; // 0x64
	private long buf_start; // 0x68

	// Properties
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	public override bool CanSeek { get; }
	public virtual string Name { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public virtual SafeFileHandle SafeFileHandle { get; }

	// Methods

	// RVA: 0x186C048 Offset: 0x1868048 VA: 0x186C048
	internal void .ctor(IntPtr handle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x186C4CC Offset: 0x18684CC VA: 0x186C4CC
	public void .ctor(string path, FileMode mode, FileAccess access) { }

	// RVA: 0x186C510 Offset: 0x1868510 VA: 0x186C510
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share) { }

	// RVA: 0x186CC40 Offset: 0x1868C40 VA: 0x186CC40
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize) { }

	// RVA: 0x186CC60 Offset: 0x1868C60 VA: 0x186CC60
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool useAsync) { }

	// RVA: 0x186CC88 Offset: 0x1868C88 VA: 0x186CC88
	public void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, FileOptions options) { }

	// RVA: 0x186C4F8 Offset: 0x18684F8 VA: 0x186C4F8
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool isAsync, bool anonymous) { }

	// RVA: 0x186C534 Offset: 0x1868534 VA: 0x186C534
	internal void .ctor(string path, FileMode mode, FileAccess access, FileShare share, int bufferSize, bool anonymous, FileOptions options) { }

	// RVA: 0x186C1E8 Offset: 0x18681E8 VA: 0x186C1E8
	private void Init(SafeFileHandle safeHandle, FileAccess access, bool ownsHandle, int bufferSize, bool isAsync, bool isConsoleWrapper) { }

	// RVA: 0x186E540 Offset: 0x186A540 VA: 0x186E540 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x186E554 Offset: 0x186A554 VA: 0x186E554 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x186E568 Offset: 0x186A568 VA: 0x186E568 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x186E570 Offset: 0x186A570 VA: 0x186E570 Slot: 38
	public virtual string get_Name() { }

	// RVA: 0x186E578 Offset: 0x186A578 VA: 0x186E578 Slot: 11
	public override long get_Length() { }

	// RVA: 0x186E818 Offset: 0x186A818 VA: 0x186E818 Slot: 12
	public override long get_Position() { }

	// RVA: 0x186E980 Offset: 0x186A980 VA: 0x186E980 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x186EA04 Offset: 0x186AA04 VA: 0x186EA04 Slot: 39
	public virtual SafeFileHandle get_SafeFileHandle() { }

	// RVA: 0x186E3CC Offset: 0x186A3CC VA: 0x186E3CC
	private void ExposeHandle() { }

	// RVA: 0x186EBB8 Offset: 0x186ABB8 VA: 0x186EBB8 Slot: 34
	public override int ReadByte() { }

	// RVA: 0x186EE48 Offset: 0x186AE48 VA: 0x186EE48 Slot: 37
	public override void WriteByte(byte value) { }

	// RVA: 0x186EF9C Offset: 0x186AF9C VA: 0x186EF9C Slot: 32
	public override int Read([In] [Out] byte[] array, int offset, int count) { }

	// RVA: 0x186F1E8 Offset: 0x186B1E8 VA: 0x186F1E8
	private int ReadInternal(byte[] dest, int offset, int count) { }

	// RVA: 0x186F340 Offset: 0x186B340 VA: 0x186F340 Slot: 22
	public override IAsyncResult BeginRead(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x186F6F0 Offset: 0x186B6F0 VA: 0x186F6F0 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x186F878 Offset: 0x186B878 VA: 0x186F878 Slot: 35
	public override void Write(byte[] array, int offset, int count) { }

	// RVA: 0x186FA9C Offset: 0x186BA9C VA: 0x186FA9C
	private void WriteInternal(byte[] src, int offset, int count) { }

	// RVA: 0x186FE28 Offset: 0x186BE28 VA: 0x186FE28 Slot: 26
	public override IAsyncResult BeginWrite(byte[] array, int offset, int numBytes, AsyncCallback userCallback, object stateObject) { }

	// RVA: 0x1870320 Offset: 0x186C320 VA: 0x1870320 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1870490 Offset: 0x186C490 VA: 0x1870490 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x18706F0 Offset: 0x186C6F0 VA: 0x18706F0 Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1870A30 Offset: 0x186CA30 VA: 0x1870A30 Slot: 21
	public override void Flush() { }

	// RVA: 0x1870AA4 Offset: 0x186CAA4 VA: 0x1870AA4 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1870B38 Offset: 0x186CB38 VA: 0x1870B38 Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1870E90 Offset: 0x186CE90 VA: 0x1870E90 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1870E98 Offset: 0x186CE98 VA: 0x1870E98 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x186F288 Offset: 0x186B288 VA: 0x186F288
	private int ReadSegment(byte[] dest, int dest_offset, int count) { }

	// RVA: 0x186FDB0 Offset: 0x186BDB0 VA: 0x186FDB0
	private int WriteSegment(byte[] src, int src_offset, int count) { }

	// RVA: 0x186EA40 Offset: 0x186AA40 VA: 0x186EA40
	private void FlushBuffer() { }

	// RVA: 0x186E6D4 Offset: 0x186A6D4 VA: 0x186E6D4
	private void FlushBufferIfDirty() { }

	// RVA: 0x186EE18 Offset: 0x186AE18 VA: 0x186EE18
	private void RefillBuffer() { }

	// RVA: 0x186ECF8 Offset: 0x186ACF8 VA: 0x186ECF8
	private int ReadData(SafeHandle safeHandle, byte[] buf, int offset, int count) { }

	// RVA: 0x186E108 Offset: 0x186A108 VA: 0x186E108
	private void InitBuffer(int size, bool isZeroSize) { }

	// RVA: 0x186D848 Offset: 0x1869848 VA: 0x186D848
	private string GetSecureFileName(string filename) { }

	// RVA: 0x186D324 Offset: 0x1869324 VA: 0x186D324
	private string GetSecureFileName(string filename, bool full) { }

	// RVA: 0x1871104 Offset: 0x186D104 VA: 0x1871104
	private static void .cctor() { }
}

// Namespace: System.IO
internal class FileStreamAsyncResult : IAsyncResult // TypeDefIndex: 1604
{
	// Fields
	private object state; // 0x10
	private bool completed; // 0x18
	private ManualResetEvent wh; // 0x20
	private AsyncCallback cb; // 0x28
	private bool completedSynch; // 0x30
	public int Count; // 0x34
	public int OriginalCount; // 0x38
	public int BytesRead; // 0x3C
	private AsyncCallback realcb; // 0x40

	// Properties
	public object AsyncState { get; }
	public bool CompletedSynchronously { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool IsCompleted { get; }

	// Methods

	// RVA: 0x18700E8 Offset: 0x186C0E8 VA: 0x18700E8
	public void .ctor(AsyncCallback cb, object state) { }

	// RVA: 0x18711A0 Offset: 0x186D1A0 VA: 0x18711A0
	private static void CBWrapper(IAsyncResult ares) { }

	// RVA: 0x1871234 Offset: 0x186D234 VA: 0x1871234 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x187123C Offset: 0x186D23C VA: 0x187123C Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1871244 Offset: 0x186D244 VA: 0x1871244 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x187124C Offset: 0x186D24C VA: 0x187124C Slot: 4
	public bool get_IsCompleted() { }
}

// Namespace: System.IO
internal enum MonoFileType // TypeDefIndex: 1605
{
	// Fields
	public int value__; // 0x0
	public const MonoFileType Unknown = 0;
	public const MonoFileType Disk = 1;
	public const MonoFileType Char = 2;
	public const MonoFileType Pipe = 3;
	public const MonoFileType Remote = 32768;
}

// Namespace: System.IO
internal static class MonoIO // TypeDefIndex: 1606
{
	// Fields
	public static readonly IntPtr InvalidHandle; // 0x0
	private static bool dump_handles; // 0x8

	// Properties
	public static IntPtr ConsoleOutput { get; }
	public static IntPtr ConsoleInput { get; }
	public static IntPtr ConsoleError { get; }
	public static char VolumeSeparatorChar { get; }
	public static char DirectorySeparatorChar { get; }
	public static char AltDirectorySeparatorChar { get; }
	public static char PathSeparator { get; }

	// Methods

	// RVA: 0x1871254 Offset: 0x186D254 VA: 0x1871254
	public static Exception GetException(MonoIOError error) { }

	// RVA: 0x186D8CC Offset: 0x18698CC VA: 0x186D8CC
	public static Exception GetException(string path, MonoIOError error) { }

	// RVA: 0x1871370 Offset: 0x186D370 VA: 0x1871370
	public static string GetCurrentDirectory(out MonoIOError error) { }

	// RVA: 0x1871374 Offset: 0x186D374 VA: 0x1871374
	private static MonoFileType GetFileType(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x186DFD4 Offset: 0x1869FD4 VA: 0x186DFD4
	public static MonoFileType GetFileType(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x1871378 Offset: 0x186D378 VA: 0x1871378
	private static IntPtr Open(char* filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x186D7AC Offset: 0x18697AC VA: 0x186D7AC
	public static IntPtr Open(string filename, FileMode mode, FileAccess access, FileShare share, FileOptions options, out MonoIOError error) { }

	// RVA: 0x1870E8C Offset: 0x186CE8C VA: 0x1870E8C
	public static bool Close(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x187137C Offset: 0x186D37C VA: 0x187137C
	private static int Read(IntPtr handle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x1870EA0 Offset: 0x186CEA0 VA: 0x1870EA0
	public static int Read(SafeHandle safeHandle, byte[] dest, int dest_offset, int count, out MonoIOError error) { }

	// RVA: 0x1871380 Offset: 0x186D380 VA: 0x1871380
	private static int Write(IntPtr handle, [In] byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x186FC58 Offset: 0x186BC58 VA: 0x186FC58
	public static int Write(SafeHandle safeHandle, byte[] src, int src_offset, int count, out MonoIOError error) { }

	// RVA: 0x1871384 Offset: 0x186D384 VA: 0x1871384
	private static long Seek(IntPtr handle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x186E3F4 Offset: 0x186A3F4 VA: 0x186E3F4
	public static long Seek(SafeHandle safeHandle, long offset, SeekOrigin origin, out MonoIOError error) { }

	// RVA: 0x1871388 Offset: 0x186D388 VA: 0x1871388
	private static long GetLength(IntPtr handle, out MonoIOError error) { }

	// RVA: 0x186E6E4 Offset: 0x186A6E4 VA: 0x186E6E4
	public static long GetLength(SafeHandle safeHandle, out MonoIOError error) { }

	// RVA: 0x187138C Offset: 0x186D38C VA: 0x187138C
	private static bool SetLength(IntPtr handle, long length, out MonoIOError error) { }

	// RVA: 0x18708F0 Offset: 0x186C8F0 VA: 0x18708F0
	public static bool SetLength(SafeHandle safeHandle, long length, out MonoIOError error) { }

	// RVA: 0x1871390 Offset: 0x186D390 VA: 0x1871390
	public static IntPtr get_ConsoleOutput() { }

	// RVA: 0x1871394 Offset: 0x186D394 VA: 0x1871394
	public static IntPtr get_ConsoleInput() { }

	// RVA: 0x1871398 Offset: 0x186D398 VA: 0x1871398
	public static IntPtr get_ConsoleError() { }

	// RVA: 0x187139C Offset: 0x186D39C VA: 0x187139C
	public static char get_VolumeSeparatorChar() { }

	// RVA: 0x18713A0 Offset: 0x186D3A0 VA: 0x18713A0
	public static char get_DirectorySeparatorChar() { }

	// RVA: 0x18713A4 Offset: 0x186D3A4 VA: 0x18713A4
	public static char get_AltDirectorySeparatorChar() { }

	// RVA: 0x18713A8 Offset: 0x186D3A8 VA: 0x18713A8
	public static char get_PathSeparator() { }

	// RVA: 0x187136C Offset: 0x186D36C VA: 0x187136C
	private static void DumpHandles() { }

	// RVA: 0x18713AC Offset: 0x186D3AC VA: 0x18713AC
	public static bool RemapPath(string path, out string newPath) { }

	// RVA: 0x18713B0 Offset: 0x186D3B0 VA: 0x18713B0
	private static void .cctor() { }
}

// Namespace: System.IO
internal enum MonoIOError // TypeDefIndex: 1607
{
	// Fields
	public int value__; // 0x0
	public const MonoIOError ERROR_SUCCESS = 0;
	public const MonoIOError ERROR_FILE_NOT_FOUND = 2;
	public const MonoIOError ERROR_PATH_NOT_FOUND = 3;
	public const MonoIOError ERROR_TOO_MANY_OPEN_FILES = 4;
	public const MonoIOError ERROR_ACCESS_DENIED = 5;
	public const MonoIOError ERROR_INVALID_HANDLE = 6;
	public const MonoIOError ERROR_INVALID_DRIVE = 15;
	public const MonoIOError ERROR_NOT_SAME_DEVICE = 17;
	public const MonoIOError ERROR_NO_MORE_FILES = 18;
	public const MonoIOError ERROR_NOT_READY = 21;
	public const MonoIOError ERROR_WRITE_FAULT = 29;
	public const MonoIOError ERROR_READ_FAULT = 30;
	public const MonoIOError ERROR_GEN_FAILURE = 31;
	public const MonoIOError ERROR_SHARING_VIOLATION = 32;
	public const MonoIOError ERROR_LOCK_VIOLATION = 33;
	public const MonoIOError ERROR_HANDLE_DISK_FULL = 39;
	public const MonoIOError ERROR_NOT_SUPPORTED = 50;
	public const MonoIOError ERROR_FILE_EXISTS = 80;
	public const MonoIOError ERROR_CANNOT_MAKE = 82;
	public const MonoIOError ERROR_INVALID_PARAMETER = 87;
	public const MonoIOError ERROR_BROKEN_PIPE = 109;
	public const MonoIOError ERROR_INVALID_NAME = 123;
	public const MonoIOError ERROR_DIR_NOT_EMPTY = 145;
	public const MonoIOError ERROR_ALREADY_EXISTS = 183;
	public const MonoIOError ERROR_FILENAME_EXCED_RANGE = 206;
	public const MonoIOError ERROR_DIRECTORY = 267;
	public const MonoIOError ERROR_ENCRYPTION_FAILED = 6000;
}

// Namespace: System.IO
internal struct MonoIOStat // TypeDefIndex: 1608
{
	// Fields
	public FileAttributes fileAttributes; // 0x0
	public long Length; // 0x8
	public long CreationTime; // 0x10
	public long LastAccessTime; // 0x18
	public long LastWriteTime; // 0x20
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Path.<>c // TypeDefIndex: 1609
{
	// Fields
	public static readonly Path.<>c <>9; // 0x0
	[TupleElementNames(new[] { "First", "FirstLength", "Second", "SecondLength", "HasSeparator" })]
	public static SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, bool>> <>9__56_0; // 0x8
	[TupleElementNames(new[] { "First", "FirstLength", "Second", "SecondLength", "Third", "ThirdLength", "FirstHasSeparator", "ThirdHasSeparator", null })]
	public static SpanAction<char, ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>> <>9__57_0; // 0x10

	// Methods

	// RVA: 0x1873E70 Offset: 0x186FE70 VA: 0x1873E70
	private static void .cctor() { }

	// RVA: 0x1873ED8 Offset: 0x186FED8 VA: 0x1873ED8
	public void .ctor() { }

	// RVA: 0x1873EE0 Offset: 0x186FEE0 VA: 0x1873EE0
	internal void <JoinInternal>b__56_0(Span<char> destination, ValueTuple<IntPtr, int, IntPtr, int, bool> state) { }

	// RVA: 0x1874038 Offset: 0x1870038 VA: 0x1874038
	internal void <JoinInternal>b__57_0(Span<char> destination, ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>> state) { }
}

// Namespace: System.IO
[ComVisible(True)]
public static class Path // TypeDefIndex: 1610
{
	// Fields
	[Obsolete("see GetInvalidPathChars and GetInvalidFileNameChars methods.")]
	public static readonly char[] InvalidPathChars; // 0x0
	public static readonly char AltDirectorySeparatorChar; // 0x8
	public static readonly char DirectorySeparatorChar; // 0xA
	public static readonly char PathSeparator; // 0xC
	internal static readonly string DirectorySeparatorStr; // 0x10
	public static readonly char VolumeSeparatorChar; // 0x18
	internal static readonly char[] PathSeparatorChars; // 0x20
	private static readonly bool dirEqualsVolume; // 0x28
	internal static readonly char[] trimEndCharsWindows; // 0x30
	internal static readonly char[] trimEndCharsUnix; // 0x38

	// Methods

	// RVA: 0x187143C Offset: 0x186D43C VA: 0x187143C
	public static string ChangeExtension(string path, string extension) { }

	// RVA: 0x18716B4 Offset: 0x186D6B4 VA: 0x18716B4
	public static string Combine(string path1, string path2) { }

	// RVA: 0x1871A38 Offset: 0x186DA38 VA: 0x1871A38
	internal static string CleanPath(string s) { }

	// RVA: 0x186D3CC Offset: 0x18693CC VA: 0x186D3CC
	public static string GetDirectoryName(string path) { }

	// RVA: 0x18722B4 Offset: 0x186E2B4 VA: 0x18722B4
	public static ReadOnlySpan<char> GetDirectoryName(ReadOnlySpan<char> path) { }

	// RVA: 0x1872384 Offset: 0x186E384 VA: 0x1872384
	public static string GetExtension(string path) { }

	// RVA: 0x1870FF8 Offset: 0x186CFF8 VA: 0x1870FF8
	public static string GetFileName(string path) { }

	// RVA: 0x18724A0 Offset: 0x186E4A0 VA: 0x18724A0
	public static string GetFileNameWithoutExtension(string path) { }

	// RVA: 0x186D744 Offset: 0x1869744 VA: 0x186D744
	public static string GetFullPath(string path) { }

	// RVA: 0x18724FC Offset: 0x186E4FC VA: 0x18724FC
	internal static string GetFullPathInternal(string path) { }

	// RVA: 0x186CCA8 Offset: 0x1868CA8 VA: 0x186CCA8
	internal static string InsecureGetFullPath(string path) { }

	// RVA: 0x1872550 Offset: 0x186E550 VA: 0x1872550
	internal static bool IsDirectorySeparator(char c) { }

	// RVA: 0x1871E94 Offset: 0x186DE94 VA: 0x1871E94
	public static string GetPathRoot(string path) { }

	// RVA: 0x18729F4 Offset: 0x186E9F4 VA: 0x18729F4
	public static string GetTempPath() { }

	// RVA: 0x1872AF4 Offset: 0x186EAF4 VA: 0x1872AF4
	private static string get_temp_path() { }

	// RVA: 0x1872AF8 Offset: 0x186EAF8 VA: 0x1872AF8
	public static bool IsPathRooted(ReadOnlySpan<char> path) { }

	// RVA: 0x1871914 Offset: 0x186D914 VA: 0x1871914
	public static bool IsPathRooted(string path) { }

	// RVA: 0x1872BFC Offset: 0x186EBFC VA: 0x1872BFC
	public static char[] GetInvalidPathChars() { }

	// RVA: 0x1871620 Offset: 0x186D620 VA: 0x1871620
	private static int findExtension(string path) { }

	// RVA: 0x1872C8C Offset: 0x186EC8C VA: 0x1872C8C
	private static void .cctor() { }

	// RVA: 0x18725E0 Offset: 0x186E5E0 VA: 0x18725E0
	private static string CanonicalizePath(string path) { }

	// RVA: 0x1872E8C Offset: 0x186EE8C VA: 0x1872E8C
	public static string Combine(string[] paths) { }

	// RVA: 0x187317C Offset: 0x186F17C VA: 0x187317C
	public static string Combine(string path1, string path2, string path3) { }

	// RVA: 0x18732FC Offset: 0x186F2FC VA: 0x18732FC
	public static ReadOnlySpan<char> GetFileName(ReadOnlySpan<char> path) { }

	// RVA: 0x1873464 Offset: 0x186F464 VA: 0x1873464
	public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2) { }

	// RVA: 0x1873794 Offset: 0x186F794 VA: 0x1873794
	public static string Join(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, ReadOnlySpan<char> path3) { }

	// RVA: 0x1873C00 Offset: 0x186FC00 VA: 0x1873C00
	public static bool TryJoin(ReadOnlySpan<char> path1, ReadOnlySpan<char> path2, Span<char> destination, out int charsWritten) { }

	// RVA: 0x187351C Offset: 0x186F51C VA: 0x187351C
	private static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second) { }

	// RVA: 0x18738A4 Offset: 0x186F8A4 VA: 0x18738A4
	private static string JoinInternal(ReadOnlySpan<char> first, ReadOnlySpan<char> second, ReadOnlySpan<char> third) { }
}

// Namespace: System.IO
internal class UnexceptionalStreamReader : StreamReader // TypeDefIndex: 1611
{
	// Fields
	private static bool[] newline; // 0x0
	private static char newlineChar; // 0x8

	// Methods

	// RVA: 0x1874230 Offset: 0x1870230 VA: 0x1874230
	private static void .cctor() { }

	// RVA: 0x18742E0 Offset: 0x18702E0 VA: 0x18742E0
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x1874350 Offset: 0x1870350 VA: 0x1874350 Slot: 9
	public override int Peek() { }

	// RVA: 0x18743D8 Offset: 0x18703D8 VA: 0x18743D8 Slot: 10
	public override int Read() { }

	// RVA: 0x1874460 Offset: 0x1870460 VA: 0x1874460 Slot: 11
	public override int Read([In] [Out] char[] dest_buffer, int index, int count) { }

	// RVA: 0x18746E4 Offset: 0x18706E4 VA: 0x18746E4
	private bool CheckEOL(char current) { }

	// RVA: 0x187487C Offset: 0x187087C VA: 0x187487C Slot: 13
	public override string ReadLine() { }

	// RVA: 0x1874904 Offset: 0x1870904 VA: 0x1874904 Slot: 12
	public override string ReadToEnd() { }
}

// Namespace: System.IO
internal class UnexceptionalStreamWriter : StreamWriter // TypeDefIndex: 1612
{
	// Methods

	// RVA: 0x187498C Offset: 0x187098C VA: 0x187498C
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x1874A04 Offset: 0x1870A04 VA: 0x1874A04 Slot: 10
	public override void Flush() { }

	// RVA: 0x1874A88 Offset: 0x1870A88 VA: 0x1874A88 Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1874B0C Offset: 0x1870B0C VA: 0x1874B0C Slot: 13
	public override void Write(char value) { }

	// RVA: 0x1874B90 Offset: 0x1870B90 VA: 0x1874B90 Slot: 14
	public override void Write(char[] value) { }

	// RVA: 0x1874C14 Offset: 0x1870C14 VA: 0x1874C14 Slot: 16
	public override void Write(string value) { }
}

// Namespace: System.IO
internal class CStreamReader : StreamReader // TypeDefIndex: 1613
{
	// Fields
	private TermInfoDriver driver; // 0x60

	// Methods

	// RVA: 0x1874C98 Offset: 0x1870C98 VA: 0x1874C98
	public void .ctor(Stream stream, Encoding encoding) { }

	// RVA: 0x1874DBC Offset: 0x1870DBC VA: 0x1874DBC Slot: 9
	public override int Peek() { }

	// RVA: 0x1874E44 Offset: 0x1870E44 VA: 0x1874E44 Slot: 10
	public override int Read() { }

	// RVA: 0x1874F14 Offset: 0x1870F14 VA: 0x1874F14 Slot: 11
	public override int Read([In] [Out] char[] dest, int index, int count) { }

	// RVA: 0x18750B4 Offset: 0x18710B4 VA: 0x18750B4 Slot: 13
	public override string ReadLine() { }

	// RVA: 0x187514C Offset: 0x187114C VA: 0x187514C Slot: 12
	public override string ReadToEnd() { }
}

// Namespace: System.IO
internal class CStreamWriter : StreamWriter // TypeDefIndex: 1614
{
	// Fields
	private TermInfoDriver driver; // 0x70

	// Methods

	// RVA: 0x18751E4 Offset: 0x18711E4 VA: 0x18751E4
	public void .ctor(Stream stream, Encoding encoding, bool leaveOpen) { }

	// RVA: 0x187531C Offset: 0x187131C VA: 0x187531C Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x18756B8 Offset: 0x18716B8 VA: 0x18756B8 Slot: 13
	public override void Write(char val) { }

	// RVA: 0x18758D0 Offset: 0x18718D0 VA: 0x18758D0
	public void InternalWriteString(string val) { }

	// RVA: 0x187584C Offset: 0x187184C VA: 0x187584C
	public void InternalWriteChar(char val) { }

	// RVA: 0x1875954 Offset: 0x1871954 VA: 0x1875954
	public void InternalWriteChars(char[] buffer, int n) { }

	// RVA: 0x18759E0 Offset: 0x18719E0 VA: 0x18759E0 Slot: 14
	public override void Write(char[] val) { }

	// RVA: 0x1875A04 Offset: 0x1871A04 VA: 0x1875A04 Slot: 16
	public override void Write(string val) { }

	// RVA: 0x1875AD0 Offset: 0x1871AD0 VA: 0x1875AD0 Slot: 18
	public override void WriteLine(string val) { }
}

// Namespace: System.IO
[Extension]
internal static class MonoLinqHelper // TypeDefIndex: 1615
{
	// Methods

	[Extension]
	// RVA: -1 Offset: -1
	public static T[] ToArray<T>(IEnumerable<T> source) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136EEC Offset: 0x1132EEC VA: 0x1136EEC
	|-MonoLinqHelper.ToArray<object>
	|
	|-RVA: 0x1136F24 Offset: 0x1132F24 VA: 0x1136F24
	|-MonoLinqHelper.ToArray<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct FileSystemEntry.<_fileNameBuffer>e__FixedBuffer // TypeDefIndex: 1616
{
	// Fields
	public char FixedElementField; // 0x0
}

// Namespace: System.IO
[Serializable]
public sealed class InvalidDataException : SystemException // TypeDefIndex: 4106
{
	// Methods

	// RVA: 0x1D60090 Offset: 0x1D5C090 VA: 0x1D60090
	public void .ctor() { }

	// RVA: 0x1D600F8 Offset: 0x1D5C0F8 VA: 0x1D600F8
	public void .ctor(string message) { }

	// RVA: 0x1D6011C Offset: 0x1D5C11C VA: 0x1D6011C
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1D60140 Offset: 0x1D5C140 VA: 0x1D60140
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.IO
internal static class PathInternal // TypeDefIndex: 8107
{
	// Fields
	private static readonly bool s_isCaseSensitive; // 0x0

	// Properties
	internal static StringComparison StringComparison { get; }

	// Methods

	// RVA: 0x1B31758 Offset: 0x1B2D758 VA: 0x1B31758
	internal static StringComparison get_StringComparison() { }

	// RVA: 0x1B317BC Offset: 0x1B2D7BC VA: 0x1B317BC
	private static bool GetIsCaseSensitive() { }

	// RVA: 0x1B31AA4 Offset: 0x1B2DAA4 VA: 0x1B31AA4
	private static void .cctor() { }
}
