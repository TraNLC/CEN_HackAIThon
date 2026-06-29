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

// Namespace: System.IO.Enumeration
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
public struct FileSystemEntry // TypeDefIndex: 1617
{
	// Fields
	internal Interop.Sys.DirectoryEntry _directoryEntry; // 0x0
	private FileStatus _status; // 0x10
	private Span<char> _pathBuffer; // 0x88
	private ReadOnlySpan<char> _fullPath; // 0x98
	private ReadOnlySpan<char> _fileName; // 0xA8
	[FixedBuffer(typeof(char), 256)]
	private FileSystemEntry.<_fileNameBuffer>e__FixedBuffer _fileNameBuffer; // 0xB8
	private FileAttributes _initialAttributes; // 0x2B8
	[CompilerGenerated]
	private ReadOnlySpan<char> <Directory>k__BackingField; // 0x2C0
	[CompilerGenerated]
	private ReadOnlySpan<char> <RootDirectory>k__BackingField; // 0x2D0
	[CompilerGenerated]
	private ReadOnlySpan<char> <OriginalRootDirectory>k__BackingField; // 0x2E0

	// Properties
	private ReadOnlySpan<char> FullPath { get; }
	public ReadOnlySpan<char> FileName { get; }
	public ReadOnlySpan<char> Directory { get; set; }
	public ReadOnlySpan<char> RootDirectory { get; set; }
	public ReadOnlySpan<char> OriginalRootDirectory { get; set; }
	public FileAttributes Attributes { get; }
	public bool IsDirectory { get; }

	// Methods

	// RVA: 0x1875B14 Offset: 0x1871B14 VA: 0x1875B14
	internal static FileAttributes Initialize(ref FileSystemEntry entry, Interop.Sys.DirectoryEntry directoryEntry, ReadOnlySpan<char> directory, ReadOnlySpan<char> rootDirectory, ReadOnlySpan<char> originalRootDirectory, Span<char> pathBuffer) { }

	// RVA: 0x1875E10 Offset: 0x1871E10 VA: 0x1875E10
	private ReadOnlySpan<char> get_FullPath() { }

	// RVA: 0x1875F44 Offset: 0x1871F44 VA: 0x1875F44
	public ReadOnlySpan<char> get_FileName() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1875FB4 Offset: 0x1871FB4 VA: 0x1875FB4
	public ReadOnlySpan<char> get_Directory() { }

	[CompilerGenerated]
	// RVA: 0x1875FC4 Offset: 0x1871FC4 VA: 0x1875FC4
	private void set_Directory(ReadOnlySpan<char> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1875FD0 Offset: 0x1871FD0 VA: 0x1875FD0
	public ReadOnlySpan<char> get_RootDirectory() { }

	[CompilerGenerated]
	// RVA: 0x1875FE0 Offset: 0x1871FE0 VA: 0x1875FE0
	private void set_RootDirectory(ReadOnlySpan<char> value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1875FEC Offset: 0x1871FEC VA: 0x1875FEC
	public ReadOnlySpan<char> get_OriginalRootDirectory() { }

	[CompilerGenerated]
	// RVA: 0x1875FFC Offset: 0x1871FFC VA: 0x1875FFC
	private void set_OriginalRootDirectory(ReadOnlySpan<char> value) { }

	// RVA: 0x1876008 Offset: 0x1872008 VA: 0x1876008
	public FileAttributes get_Attributes() { }

	// RVA: 0x1876050 Offset: 0x1872050 VA: 0x1876050
	public bool get_IsDirectory() { }

	// RVA: 0x1876058 Offset: 0x1872058 VA: 0x1876058
	public FileSystemInfo ToFileSystemInfo() { }

	// RVA: 0x18760C8 Offset: 0x18720C8 VA: 0x18760C8
	public string ToFullPath() { }

	// RVA: 0x18760F0 Offset: 0x18720F0 VA: 0x18760F0
	public string ToSpecifiedFullPath() { }
}

// Namespace: 
public sealed class FileSystemEnumerable.FindPredicate<TResult> : MulticastDelegate // TypeDefIndex: 1618
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x126082C Offset: 0x125C82C VA: 0x126082C
	|-FileSystemEnumerable.FindPredicate<object>..ctor
	|
	|-RVA: 0x12608F0 Offset: 0x125C8F0 VA: 0x12608F0
	|-FileSystemEnumerable.FindPredicate<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual bool Invoke(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12608DC Offset: 0x125C8DC VA: 0x12608DC
	|-FileSystemEnumerable.FindPredicate<object>.Invoke
	|
	|-RVA: 0x12609A0 Offset: 0x125C9A0 VA: 0x12609A0
	|-FileSystemEnumerable.FindPredicate<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
public sealed class FileSystemEnumerable.FindTransform<TResult> : MulticastDelegate // TypeDefIndex: 1619
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12609B4 Offset: 0x125C9B4 VA: 0x12609B4
	|-FileSystemEnumerable.FindTransform<object>..ctor
	|
	|-RVA: 0x1260A78 Offset: 0x125CA78 VA: 0x1260A78
	|-FileSystemEnumerable.FindTransform<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual TResult Invoke(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1260A64 Offset: 0x125CA64 VA: 0x1260A64
	|-FileSystemEnumerable.FindTransform<object>.Invoke
	|
	|-RVA: 0x1260B2C Offset: 0x125CB2C VA: 0x1260B2C
	|-FileSystemEnumerable.FindTransform<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: 
private sealed class FileSystemEnumerable.DelegateEnumerator<TResult> : FileSystemEnumerator<TResult> // TypeDefIndex: 1620
{
	// Fields
	private readonly FileSystemEnumerable<TResult> _enumerable; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(FileSystemEnumerable<TResult> enumerable) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1578E10 Offset: 0x1574E10 VA: 0x1578E10
	|-FileSystemEnumerable.DelegateEnumerator<object>..ctor
	|
	|-RVA: 0x1578EE4 Offset: 0x1574EE4 VA: 0x1578EE4
	|-FileSystemEnumerable.DelegateEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected override TResult TransformEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1578E58 Offset: 0x1574E58 VA: 0x1578E58
	|-FileSystemEnumerable.DelegateEnumerator<object>.TransformEntry
	|
	|-RVA: 0x1578F40 Offset: 0x1574F40 VA: 0x1578F40
	|-FileSystemEnumerable.DelegateEnumerator<__Il2CppFullySharedGenericType>.TransformEntry
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1578E84 Offset: 0x1574E84 VA: 0x1578E84
	|-FileSystemEnumerable.DelegateEnumerator<object>.ShouldRecurseIntoEntry
	|
	|-RVA: 0x1579024 Offset: 0x1575024 VA: 0x1579024
	|-FileSystemEnumerable.DelegateEnumerator<__Il2CppFullySharedGenericType>.ShouldRecurseIntoEntry
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected override bool ShouldIncludeEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1578EB4 Offset: 0x1574EB4 VA: 0x1578EB4
	|-FileSystemEnumerable.DelegateEnumerator<object>.ShouldIncludeEntry
	|
	|-RVA: 0x157909C Offset: 0x157509C VA: 0x157909C
	|-FileSystemEnumerable.DelegateEnumerator<__Il2CppFullySharedGenericType>.ShouldIncludeEntry
	*/
}

// Namespace: System.IO.Enumeration
public class FileSystemEnumerable<TResult> : IEnumerable<TResult>, IEnumerable // TypeDefIndex: 1621
{
	// Fields
	private FileSystemEnumerable.DelegateEnumerator<TResult> _enumerator; // 0x0
	private readonly FileSystemEnumerable.FindTransform<TResult> _transform; // 0x0
	private readonly EnumerationOptions _options; // 0x0
	private readonly string _directory; // 0x0
	[CompilerGenerated]
	private FileSystemEnumerable.FindPredicate<TResult> <ShouldIncludePredicate>k__BackingField; // 0x0
	[CompilerGenerated]
	private FileSystemEnumerable.FindPredicate<TResult> <ShouldRecursePredicate>k__BackingField; // 0x0

	// Properties
	public FileSystemEnumerable.FindPredicate<TResult> ShouldIncludePredicate { get; set; }
	public FileSystemEnumerable.FindPredicate<TResult> ShouldRecursePredicate { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string directory, FileSystemEnumerable.FindTransform<TResult> transform, EnumerationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CB9C Offset: 0x1258B9C VA: 0x125CB9C
	|-FileSystemEnumerable<object>..ctor
	|
	|-RVA: 0x125CDCC Offset: 0x1258DCC VA: 0x125CDCC
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>..ctor
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public FileSystemEnumerable.FindPredicate<TResult> get_ShouldIncludePredicate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CD38 Offset: 0x1258D38 VA: 0x125CD38
	|-FileSystemEnumerable<object>.get_ShouldIncludePredicate
	|
	|-RVA: 0x125CF6C Offset: 0x1258F6C VA: 0x125CF6C
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.get_ShouldIncludePredicate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void set_ShouldIncludePredicate(FileSystemEnumerable.FindPredicate<TResult> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CD40 Offset: 0x1258D40 VA: 0x125CD40
	|-FileSystemEnumerable<object>.set_ShouldIncludePredicate
	|
	|-RVA: 0x125CF74 Offset: 0x1258F74 VA: 0x125CF74
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.set_ShouldIncludePredicate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public FileSystemEnumerable.FindPredicate<TResult> get_ShouldRecursePredicate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CD48 Offset: 0x1258D48 VA: 0x125CD48
	|-FileSystemEnumerable<object>.get_ShouldRecursePredicate
	|
	|-RVA: 0x125CF7C Offset: 0x1258F7C VA: 0x125CF7C
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.get_ShouldRecursePredicate
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<TResult> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CD50 Offset: 0x1258D50 VA: 0x125CD50
	|-FileSystemEnumerable<object>.GetEnumerator
	|
	|-RVA: 0x125CF84 Offset: 0x1258F84 VA: 0x125CF84
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125CDBC Offset: 0x1258DBC VA: 0x125CDBC
	|-FileSystemEnumerable<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x125CFF4 Offset: 0x1258FF4 VA: 0x125CFF4
	|-FileSystemEnumerable<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}

// Namespace: 
[CompilerGenerated]
private sealed class FileSystemEnumerableFactory.<>c__DisplayClass3_0 // TypeDefIndex: 1622
{
	// Fields
	public string expression; // 0x10
	public EnumerationOptions options; // 0x18

	// Methods

	// RVA: 0x1877008 Offset: 0x1873008 VA: 0x1877008
	public void .ctor() { }

	// RVA: 0x1877A9C Offset: 0x1873A9C VA: 0x1877A9C
	internal bool <UserFiles>b__1(ref FileSystemEntry entry) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FileSystemEnumerableFactory.<>c // TypeDefIndex: 1623
{
	// Fields
	public static readonly FileSystemEnumerableFactory.<>c <>9; // 0x0
	public static FileSystemEnumerable.FindTransform<string> <>9__3_0; // 0x8
	public static FileSystemEnumerable.FindTransform<string> <>9__4_0; // 0x10
	public static FileSystemEnumerable.FindTransform<string> <>9__5_0; // 0x18
	public static FileSystemEnumerable.FindTransform<FileInfo> <>9__6_0; // 0x20
	public static FileSystemEnumerable.FindTransform<DirectoryInfo> <>9__7_0; // 0x28
	public static FileSystemEnumerable.FindTransform<FileSystemInfo> <>9__8_0; // 0x30

	// Methods

	// RVA: 0x1877B3C Offset: 0x1873B3C VA: 0x1877B3C
	private static void .cctor() { }

	// RVA: 0x1877BA4 Offset: 0x1873BA4 VA: 0x1877BA4
	public void .ctor() { }

	// RVA: 0x1877BAC Offset: 0x1873BAC VA: 0x1877BAC
	internal string <UserFiles>b__3_0(ref FileSystemEntry entry) { }

	// RVA: 0x1877BB4 Offset: 0x1873BB4 VA: 0x1877BB4
	internal string <UserDirectories>b__4_0(ref FileSystemEntry entry) { }

	// RVA: 0x1877BBC Offset: 0x1873BBC VA: 0x1877BBC
	internal string <UserEntries>b__5_0(ref FileSystemEntry entry) { }

	// RVA: 0x1877BC4 Offset: 0x1873BC4 VA: 0x1877BC4
	internal FileInfo <FileInfos>b__6_0(ref FileSystemEntry entry) { }

	// RVA: 0x1877C24 Offset: 0x1873C24 VA: 0x1877C24
	internal DirectoryInfo <DirectoryInfos>b__7_0(ref FileSystemEntry entry) { }

	// RVA: 0x1877C84 Offset: 0x1873C84 VA: 0x1877C84
	internal FileSystemInfo <FileSystemInfos>b__8_0(ref FileSystemEntry entry) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FileSystemEnumerableFactory.<>c__DisplayClass4_0 // TypeDefIndex: 1624
{
	// Fields
	public string expression; // 0x10
	public EnumerationOptions options; // 0x18

	// Methods

	// RVA: 0x1877204 Offset: 0x1873204 VA: 0x1877204
	public void .ctor() { }

	// RVA: 0x1877C8C Offset: 0x1873C8C VA: 0x1877C8C
	internal bool <UserDirectories>b__1(ref FileSystemEntry entry) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FileSystemEnumerableFactory.<>c__DisplayClass5_0 // TypeDefIndex: 1625
{
	// Fields
	public string expression; // 0x10
	public EnumerationOptions options; // 0x18

	// Methods

	// RVA: 0x1877400 Offset: 0x1873400 VA: 0x1877400
	public void .ctor() { }

	// RVA: 0x1877D2C Offset: 0x1873D2C VA: 0x1877D2C
	internal bool <UserEntries>b__1(ref FileSystemEntry entry) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FileSystemEnumerableFactory.<>c__DisplayClass6_0 // TypeDefIndex: 1626
{
	// Fields
	public string expression; // 0x10
	public EnumerationOptions options; // 0x18

	// Methods

	// RVA: 0x18775FC Offset: 0x18735FC VA: 0x18775FC
	public void .ctor() { }

	// RVA: 0x1877DB0 Offset: 0x1873DB0 VA: 0x1877DB0
	internal bool <FileInfos>b__1(ref FileSystemEntry entry) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FileSystemEnumerableFactory.<>c__DisplayClass7_0 // TypeDefIndex: 1627
{
	// Fields
	public string expression; // 0x10
	public EnumerationOptions options; // 0x18

	// Methods

	// RVA: 0x18777F8 Offset: 0x18737F8 VA: 0x18777F8
	public void .ctor() { }

	// RVA: 0x1877E50 Offset: 0x1873E50 VA: 0x1877E50
	internal bool <DirectoryInfos>b__1(ref FileSystemEntry entry) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FileSystemEnumerableFactory.<>c__DisplayClass8_0 // TypeDefIndex: 1628
{
	// Fields
	public string expression; // 0x10
	public EnumerationOptions options; // 0x18

	// Methods

	// RVA: 0x18779F4 Offset: 0x18739F4 VA: 0x18779F4
	public void .ctor() { }

	// RVA: 0x1877EF0 Offset: 0x1873EF0 VA: 0x1877EF0
	internal bool <FileSystemInfos>b__1(ref FileSystemEntry entry) { }
}

// Namespace: System.IO.Enumeration
internal static class FileSystemEnumerableFactory // TypeDefIndex: 1629
{
	// Fields
	private static readonly char[] s_unixEscapeChars; // 0x0

	// Methods

	// RVA: 0x187627C Offset: 0x187227C VA: 0x187627C
	internal static void NormalizeInputs(ref string directory, ref string expression, EnumerationOptions options) { }

	// RVA: 0x1876ADC Offset: 0x1872ADC VA: 0x1876ADC
	private static bool MatchesPattern(string expression, ReadOnlySpan<char> name, EnumerationOptions options) { }

	// RVA: 0x1876E14 Offset: 0x1872E14 VA: 0x1876E14
	internal static IEnumerable<string> UserFiles(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x1877010 Offset: 0x1873010 VA: 0x1877010
	internal static IEnumerable<string> UserDirectories(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x187720C Offset: 0x187320C VA: 0x187720C
	internal static IEnumerable<string> UserEntries(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x1877408 Offset: 0x1873408 VA: 0x1877408
	internal static IEnumerable<FileInfo> FileInfos(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x1877604 Offset: 0x1873604 VA: 0x1877604
	internal static IEnumerable<DirectoryInfo> DirectoryInfos(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x1877800 Offset: 0x1873800 VA: 0x1877800
	internal static IEnumerable<FileSystemInfo> FileSystemInfos(string directory, string expression, EnumerationOptions options) { }

	// RVA: 0x18779FC Offset: 0x18739FC VA: 0x18779FC
	private static void .cctor() { }
}

// Namespace: System.IO.Enumeration
public abstract class FileSystemEnumerator<TResult> : CriticalFinalizerObject, IEnumerator<TResult>, IDisposable, IEnumerator // TypeDefIndex: 1630
{
	// Fields
	private readonly string _originalRootDirectory; // 0x0
	private readonly string _rootDirectory; // 0x0
	private readonly EnumerationOptions _options; // 0x0
	private readonly object _lock; // 0x0
	private string _currentPath; // 0x0
	private IntPtr _directoryHandle; // 0x0
	private bool _lastEntryFound; // 0x0
	private Queue<string> _pending; // 0x0
	private Interop.Sys.DirectoryEntry _entry; // 0x0
	private TResult _current; // 0x0
	private char[] _pathBuffer; // 0x0
	private byte[] _entryBuffer; // 0x0

	// Properties
	public TResult Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(string directory, EnumerationOptions options) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D008 Offset: 0x1259008 VA: 0x125D008
	|-FileSystemEnumerator<object>..ctor
	|
	|-RVA: 0x125E3E0 Offset: 0x125A3E0 VA: 0x125E3E0
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private bool InternalContinueOnError(Interop.ErrorInfo info, bool ignoreNotFound = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D490 Offset: 0x1259490 VA: 0x125D490
	|-FileSystemEnumerator<object>.InternalContinueOnError
	|
	|-RVA: 0x125E970 Offset: 0x125A970 VA: 0x125E970
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.InternalContinueOnError
	*/

	// RVA: -1 Offset: -1
	private static bool IsDirectoryNotFound(Interop.ErrorInfo info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D53C Offset: 0x125953C VA: 0x125D53C
	|-FileSystemEnumerator<object>.IsDirectoryNotFound
	|
	|-RVA: 0x125EA38 Offset: 0x125AA38 VA: 0x125EA38
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.IsDirectoryNotFound
	*/

	// RVA: -1 Offset: -1
	private static bool IsAccessError(Interop.ErrorInfo info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D558 Offset: 0x1259558 VA: 0x125D558
	|-FileSystemEnumerator<object>.IsAccessError
	|
	|-RVA: 0x125EA54 Offset: 0x125AA54 VA: 0x125EA54
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.IsAccessError
	*/

	// RVA: -1 Offset: -1
	private IntPtr CreateDirectoryHandle(string path, bool ignoreNotFound = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D594 Offset: 0x1259594 VA: 0x125D594
	|-FileSystemEnumerator<object>.CreateDirectoryHandle
	|
	|-RVA: 0x125EA90 Offset: 0x125AA90 VA: 0x125EA90
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.CreateDirectoryHandle
	*/

	// RVA: -1 Offset: -1
	private void CloseDirectoryHandle() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D664 Offset: 0x1259664 VA: 0x125D664
	|-FileSystemEnumerator<object>.CloseDirectoryHandle
	|
	|-RVA: 0x125EB70 Offset: 0x125AB70 VA: 0x125EB70
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.CloseDirectoryHandle
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125D6E0 Offset: 0x12596E0 VA: 0x125D6E0
	|-FileSystemEnumerator<object>.MoveNext
	|
	|-RVA: 0x125EC08 Offset: 0x125AC08 VA: 0x125EC08
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private void FindNextEntry() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DC9C Offset: 0x1259C9C VA: 0x125DC9C
	|-FileSystemEnumerator<object>.FindNextEntry
	|
	|-RVA: 0x125F628 Offset: 0x125B628 VA: 0x125F628
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.FindNextEntry
	*/

	// RVA: -1 Offset: -1
	private void FindNextEntry(byte* entryBufferPtr, int bufferLength) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DCD0 Offset: 0x1259CD0 VA: 0x125DCD0
	|-FileSystemEnumerator<object>.FindNextEntry
	|
	|-RVA: 0x125F6F0 Offset: 0x125B6F0 VA: 0x125F6F0
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.FindNextEntry
	*/

	// RVA: -1 Offset: -1
	private bool DequeueNextDirectory() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DDF8 Offset: 0x1259DF8 VA: 0x125DDF8
	|-FileSystemEnumerator<object>.DequeueNextDirectory
	|
	|-RVA: 0x125F88C Offset: 0x125B88C VA: 0x125F88C
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.DequeueNextDirectory
	*/

	// RVA: -1 Offset: -1
	private void InternalDispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125DEB0 Offset: 0x1259EB0 VA: 0x125DEB0
	|-FileSystemEnumerator<object>.InternalDispose
	|
	|-RVA: 0x125FA60 Offset: 0x125BA60 VA: 0x125FA60
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.InternalDispose
	*/

	// RVA: -1 Offset: -1 Slot: 9
	protected virtual bool ShouldIncludeEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E19C Offset: 0x125A19C VA: 0x125E19C
	|-FileSystemEnumerator<object>.ShouldIncludeEntry
	|
	|-RVA: 0x125FE5C Offset: 0x125BE5C VA: 0x125FE5C
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.ShouldIncludeEntry
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected virtual bool ShouldRecurseIntoEntry(ref FileSystemEntry entry) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E1A4 Offset: 0x125A1A4 VA: 0x125E1A4
	|-FileSystemEnumerator<object>.ShouldRecurseIntoEntry
	|
	|-RVA: 0x125FE64 Offset: 0x125BE64 VA: 0x125FE64
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.ShouldRecurseIntoEntry
	*/

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract TResult TransformEntry(ref FileSystemEntry entry);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.TransformEntry
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected virtual void OnDirectoryFinished(ReadOnlySpan<char> directory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E1AC Offset: 0x125A1AC VA: 0x125E1AC
	|-FileSystemEnumerator<object>.OnDirectoryFinished
	|
	|-RVA: 0x125FE6C Offset: 0x125BE6C VA: 0x125FE6C
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.OnDirectoryFinished
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual bool ContinueOnError(int error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E1B0 Offset: 0x125A1B0 VA: 0x125E1B0
	|-FileSystemEnumerator<object>.ContinueOnError
	|
	|-RVA: 0x125FE70 Offset: 0x125BE70 VA: 0x125FE70
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.ContinueOnError
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TResult get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E1B8 Offset: 0x125A1B8 VA: 0x125E1B8
	|-FileSystemEnumerator<object>.get_Current
	|
	|-RVA: 0x125FE78 Offset: 0x125BE78 VA: 0x125FE78
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E1C0 Offset: 0x125A1C0 VA: 0x125E1C0
	|-FileSystemEnumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x125FEBC Offset: 0x125BEBC VA: 0x125FEBC
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1
	private void DirectoryFinished() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E1C8 Offset: 0x125A1C8 VA: 0x125E1C8
	|-FileSystemEnumerator<object>.DirectoryFinished
	|
	|-RVA: 0x125FF60 Offset: 0x125BF60 VA: 0x125FF60
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.DirectoryFinished
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E290 Offset: 0x125A290 VA: 0x125E290
	|-FileSystemEnumerator<object>.Reset
	|
	|-RVA: 0x1260084 Offset: 0x125C084 VA: 0x1260084
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E2C4 Offset: 0x125A2C4 VA: 0x125E2C4
	|-FileSystemEnumerator<object>.Dispose
	|
	|-RVA: 0x12600B8 Offset: 0x125C0B8 VA: 0x12600B8
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 14
	protected virtual void Dispose(bool disposing) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E340 Offset: 0x125A340 VA: 0x125E340
	|-FileSystemEnumerator<object>.Dispose
	|
	|-RVA: 0x1260138 Offset: 0x125C138 VA: 0x1260138
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x125E344 Offset: 0x125A344 VA: 0x125E344
	|-FileSystemEnumerator<object>.Finalize
	|
	|-RVA: 0x126013C Offset: 0x125C13C VA: 0x126013C
	|-FileSystemEnumerator<__Il2CppFullySharedGenericType>.Finalize
	*/
}

// Namespace: System.IO.Enumeration
public static class FileSystemName // TypeDefIndex: 1631
{
	// Fields
	private static readonly char[] s_wildcardChars; // 0x0
	private static readonly char[] s_simpleWildcardChars; // 0x8

	// Methods

	// RVA: 0x1876740 Offset: 0x1872740 VA: 0x1876740
	public static string TranslateWin32Expression(string expression) { }

	// RVA: 0x1876D8C Offset: 0x1872D8C VA: 0x1876D8C
	public static bool MatchesWin32Expression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = True) { }

	// RVA: 0x1876D04 Offset: 0x1872D04 VA: 0x1876D04
	public static bool MatchesSimpleExpression(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase = True) { }

	// RVA: 0x1877F74 Offset: 0x1873F74 VA: 0x1877F74
	private static bool MatchPattern(ReadOnlySpan<char> expression, ReadOnlySpan<char> name, bool ignoreCase, bool useExtendedWildcards) { }

	// RVA: 0x18786D8 Offset: 0x18746D8 VA: 0x18786D8
	private static void .cctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 // TypeDefIndex: 1632
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 // TypeDefIndex: 1633
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 // TypeDefIndex: 1634
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 1635
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15 // TypeDefIndex: 1636
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 // TypeDefIndex: 1637
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 1638
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 // TypeDefIndex: 1639
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 // TypeDefIndex: 1640
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 1641
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 // TypeDefIndex: 1642
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 // TypeDefIndex: 1643
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 // TypeDefIndex: 1644
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=42 // TypeDefIndex: 1645
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 // TypeDefIndex: 1646
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 // TypeDefIndex: 1647
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 // TypeDefIndex: 1648
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 // TypeDefIndex: 1649
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 1650
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 // TypeDefIndex: 1651
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 // TypeDefIndex: 1652
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=84 // TypeDefIndex: 1653
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=94 // TypeDefIndex: 1654
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 // TypeDefIndex: 1655
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 // TypeDefIndex: 1656
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=130 // TypeDefIndex: 1657
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 // TypeDefIndex: 1658
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=170 // TypeDefIndex: 1659
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=172 // TypeDefIndex: 1660
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=174 // TypeDefIndex: 1661
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 // TypeDefIndex: 1662
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=240 // TypeDefIndex: 1663
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 1664
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=262 // TypeDefIndex: 1665
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=288 // TypeDefIndex: 1666
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=336 // TypeDefIndex: 1667
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=360 // TypeDefIndex: 1668
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=640 // TypeDefIndex: 1669
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=648 // TypeDefIndex: 1670
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=998 // TypeDefIndex: 1671
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1018 // TypeDefIndex: 1672
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 // TypeDefIndex: 1673
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1208 // TypeDefIndex: 1674
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1450 // TypeDefIndex: 1675
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1472 // TypeDefIndex: 1676
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1665 // TypeDefIndex: 1677
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 // TypeDefIndex: 1678
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2100 // TypeDefIndex: 1679
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2176 // TypeDefIndex: 1680
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2350 // TypeDefIndex: 1681
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2382 // TypeDefIndex: 1682
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 // TypeDefIndex: 1683
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 // TypeDefIndex: 1684
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5952 // TypeDefIndex: 1685
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10800 // TypeDefIndex: 1686
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 1687
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 001D686DB504E20C792EAA07FE09224A45FF328E24A80072D04D16ABC5C2B5D2 /*Metadata offset 0x3BC770*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=170 021022D5891F99B3B525763EB77BAEC69B107268F560721F5060FCDBD4D5AAE8 /*Metadata offset 0x3BC7B8*/; // 0x40
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 042957A0DB5FF2D38A343AC5AE5F8635B88F10C32EB87A238B1DFB4756468476 /*Metadata offset 0x3BC868*/; // 0xEA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=56 07FA6E88C946B2528C09C16C2FB8E9CDA49AFFAFC601774C437FD9F2DF3ECE01 /*Metadata offset 0x3BC878*/; // 0xF6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=84 0C496C9AE05419BD25256D0EF4F31AFD291119F14B8BD683BF1774F91E08659D /*Metadata offset 0x3BC8B8*/; // 0x12E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 0E499E7743BCDFF289B85890E4DFDD635594DB16246DC094C3C19556B6C1262C /*Metadata offset 0x3BC910*/; // 0x182
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 0F9E3C7E66CDEF5C44FA29E65CA676C480F7A2A4A067F70107FDC292C68D38B0 /*Metadata offset 0x3BC960*/; // 0x1CA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 1199C3B39A2FA058EFF5B3829616AE81EE2B59A51D89C107A5FA4B6FEF95DD16 /*Metadata offset 0x3BC970*/; // 0x1D6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=640 125CF2084D7EEC18DC9795BE4BAA221655C0EABAB89E90A74FB0370378A60293 /*Metadata offset 0x3BC9C0*/; // 0x222
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2100 12D518BA10F3DD1A331E65FBD4C330930C0A0BD9F50F37BE0BDF596E964B9A78 /*Metadata offset 0x3BCC48*/; // 0x4A2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=128 195ABC1ABB69B6BD65F20ACAFA79EED2D330BF513E25C830F24B8A78D8703446 /*Metadata offset 0x3BD480*/; // 0xCD6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 1A07BC77B9912D8D87E9B28E0167F53A9B09BB017B35A35F3913989C9440A60B /*Metadata offset 0x3BD508*/; // 0xD56
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1450 1B9CC34A0CF8DBCC350E200673FAC4124DDAD581F1FC2C16FF9A1C0154691687 /*Metadata offset 0x3BD518*/; // 0xD60
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=360 1C4B3A80ED7AEC83916479BCE280E1258D5785D07F0EA22A5E27592ACCAE692B /*Metadata offset 0x3BDAC8*/; // 0x130A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=42 1F38DEB3F70291588D06D3830D0D4241CE0570C9F4EE8B00F606C4753EB016E2 /*Metadata offset 0x3BDC38*/; // 0x1472
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 21244F82B210125632917591768F6BF22EB6861F80C6C25A25BD26DFB580EA7B /*Metadata offset 0x3BDC68*/; // 0x149C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 215E3E0B11A214B3198654E87B3D953AC8FB1ABC7045AF841A7C4892624BDE49 /*Metadata offset 0x3BDD70*/; // 0x159C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 2403FBEA85D0741C5727760E97EF16C9BF23294F21C0F1265A4BAF7F22202A64 /*Metadata offset 0x3BDD80*/; // 0x15A6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 24CB9F17C8326D8BB8EC908716519DF7F265AE825F0DD13BB04E03A90B07D90E /*Metadata offset 0x3BDD90*/; // 0x15B2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 25308BAB47481701F1E861B1EA4F2409E73ABB14E9579C26DF4ABE440A0DCF0A /*Metadata offset 0x3BDDA8*/; // 0x15C2
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 25E3E48132FBDBE9B7C0C6C54D7C10A5DE12A105AA3E5DE2A0DC808BF245B7A5 /*Metadata offset 0x3BDDF8*/; // 0x160E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 2CCF4119215BDAD102DA7AD5B57E0E6CA19CC8FF5524856FC58907E824213E1F /*Metadata offset 0x3BEA38*/; // 0x224A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 3444EB31231B2CCC1B05C7A44EBD1B2A009C1D9977A99B453F52E2F81DD6C32F /*Metadata offset 0x3BEA88*/; // 0x2292
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 3D95E4501B1964D7FCE16E3F5682A038752B462357D87343880B1E819F6163FE /*Metadata offset 0x3BEAD8*/; // 0x22DA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 3F62692E2AD5078353EC4471A13421A61EE493294CF59DC66626A6EF9CCCD2C4 /*Metadata offset 0x3BEAF0*/; // 0x22EA
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 42E1421FC2A5A6A33E964D7EB9603EB101818D858DDA09B2BC9B5A888C1C351C /*Metadata offset 0x3BEB40*/; // 0x2332
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 44D066BAE9848B4A4B2C31F1854666526A32D0588635569423BDA1DA303C97DF /*Metadata offset 0x3BEB50*/; // 0x233E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 4623CA5867960AA898AA1F65E720CD5ECD3552542E0C6F6FB65B21D14DD1CBC2 /*Metadata offset 0x3BEB58*/; // 0x2344
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 4800FBFC4566EB02D1727A4B1C949CCBC7535C216A0766564C199308631B5DD6 /*Metadata offset 0x3BEBD8*/; // 0x23BC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 493402F3E4397B2945B16273E795816C0BDF80F76F42FCAA75F3DF2E215ABC1B /*Metadata offset 0x3BEC10*/; // 0x23EC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=174 494C32E1A18F6E8AD8ED5FAB0A5AF07F801BE7AF3C936942B020918CE2953046 /*Metadata offset 0x3BFC18*/; // 0x33EC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2382 4E0B9E024FA510B6F03C92D95BB204E78CDC6E3FD2EC8D35787B7BC76F0655A0 /*Metadata offset 0x3BFCC8*/; // 0x349A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 508085E0DDEEA9CE48BFAE98CEC779F8D06301AE973555D37680D08190CAFA70 /*Metadata offset 0x3C0618*/; // 0x3DE8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 510FDFA4743E58DD45DCDD7CB4F8509BF6294CC1D1D4958CA30A9E7604973006 /*Metadata offset 0x3C0648*/; // 0x3E14
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=42 5292FD0A8E62FCCBE41F34EFE7575D097990A66FE23B3507971C5BF272A4362E /*Metadata offset 0x3C0698*/; // 0x3E5C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 533B8C444F951E83EFF7305E3807B66CE0005DE0A2D0A44873C130895A3BE6AA /*Metadata offset 0x3C06C8*/; // 0x3E86
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 543172FF9822CE5240DF89FF3AD8C7FD9824F97D0EED9B1432E60345FBBDE9A9 /*Metadata offset 0x3C06E0*/; // 0x3E9A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 55D0BF716B334D123E0088CFB3F8E2FEA17AF5025BB527F95EEB09BA978EA329 /*Metadata offset 0x3C0718*/; // 0x3ECE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10800 56073E3CC3FC817690CC306D0DB7EA63EBCB0801359567CA44CA3D3B9BF63854 /*Metadata offset 0x3C0820*/; // 0x3FCE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA /*Metadata offset 0x3C3258*/; // 0x69FE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 5DF6E0E2761359D30A8275058E299FCC0381534545F55CF43E41983F5D4C9456 /*Metadata offset 0x3C3290*/; // 0x6A32
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 5EC4E50DA95A113769D73E5F7F8221A876185CEE6498ABB16FBB9F0563C15BBF /*Metadata offset 0x3C32B8*/; // 0x6A52
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=94 61D639BE11384EE21CDE2B40357F4F9D80A106C97C592D18A9F4CAA442CA5D31 /*Metadata offset 0x3C3308*/; // 0x6A9A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 62E6F13B53D67FDD780E20D89A6E8EE503B197AC16AC3F1D2571C147FDD324C9 /*Metadata offset 0x3C3368*/; // 0x6AF8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=28 64A0AD5A7BF0B569FABE66AF3006423DA81FF79CD282E8D781CD013B1FD7D5CE /*Metadata offset 0x3C3470*/; // 0x6BF8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 668BB69E184E0C32DC3BC488001C506C87EE5A95C7E7B6B87D24C3A6DC779956 /*Metadata offset 0x3C3490*/; // 0x6C14
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 6708B572BDBE5D5E79701DBB9744AF74B50FED7608218F2D7BF1B5D87E5A53ED /*Metadata offset 0x3C3C98*/; // 0x7414
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=648 67856A16DB0550FDAB4D1A9B208B0C155C4679CA116BF867B74ED2A0AA4D2955 /*Metadata offset 0x3C3CD0*/; // 0x7444
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 6DC92D3617F0357376502FBA4CDD465B5423818DABE8B2CA1A06E1351F2F1C85 /*Metadata offset 0x3C3F60*/; // 0x76CC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 71F7F6B226CBC11C8B26D506869FAE022928427389882579DB316F36FF34A096 /*Metadata offset 0x3C3FB0*/; // 0x7714
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 73F5D95C401726B2C92EC96A696BA15F0E5A5C6DD9AC6BEB3736A81772A11531 /*Metadata offset 0x3C4088*/; // 0x77E8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=288 74BCD6ED20AF2231F2BB1CDE814C5F4FF48E54BAC46029EEF90DDF4A208E2B20 /*Metadata offset 0x3C4890*/; // 0x7FE8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 74EF7306E7452D6859B6463CE496B8DF30925F69E1B2969E1F3F34BBC9C6AF04 /*Metadata offset 0x3C49B8*/; // 0x8108
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 78AD7906208AA1E531D0C1100062DE3D252210B1E4214061294A0BB7C94762B8 /*Metadata offset 0x3C4AC0*/; // 0x8208
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1472 7BEC6AD454781FDCD8D475B3418629CBABB3BF9CA66FA80009D608A1A60D0696 /*Metadata offset 0x3C4B40*/; // 0x8280
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 7F777906B0704EB248888E491577584D5BEBE71B375BD595A06444390B471915 /*Metadata offset 0x3C5108*/; // 0x8840
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 801494072CDD59E61F9AA9345A80D045378705DFDCE94902C22EAEAE049BE780 /*Metadata offset 0x3C5158*/; // 0x8888
	internal static readonly long 819B40F8CF7DC49B4275955A17C10239F1BBBB3BF96E26E25ED844B96B645D7F = 23362753784184900; // 0x8988
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 8259E3EBA4D41CA02AE5322BBD280034A9C9860D9CD0D2038139FC9EBE6B6C77 /*Metadata offset 0x3C5270*/; // 0x8990
	internal static readonly long 82B100804CE219CD73E155C7C6457FCF04EA539DE5B19F4736E800098714EB21 = -44474084896931794; // 0x89D8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 861FD05B0EAD3D0AA9418B140CC37846BBC5F195214D90CEF42919D1E36EED10 /*Metadata offset 0x3C52D0*/; // 0x89E0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=998 86BDA34D2165AC08F2DE4918B302E44205CDEA674FCA7F2C7F56D4F12D8B0C73 /*Metadata offset 0x3C5320*/; // 0x8A28
	internal static readonly long 8BFD94DEAAC0F168DC8B50A00AC120A113B550B68FEF344F807D503D1A6E5DED = 17451706256326748; // 0x8E10
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1665 8CCE27079B32C13BB310169A6AD26AE419CDC98B7E2EFD3CC9997257F4BC1DEF /*Metadata offset 0x3C5718*/; // 0x8E18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5952 9086502742CE7F0595B57A4E5B32901FF4CF97959B92F7E91A435E4765AC1115 /*Metadata offset 0x3C5DA0*/; // 0x9499
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=336 93B42898102ACB2421875C45676880B8A07390D8DF0E1EE85C5D1AA26964B0C6 /*Metadata offset 0x3C74E8*/; // 0xABD9
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 93F28AF88A06482BE13F8D0354B6A7676DDAED573EA3938C50F6E53E6D6BB0B6 /*Metadata offset 0x3C7640*/; // 0xAD29
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=174 95BDE712712F10D07813AE3DEEA40D1F38E3FCF1A92CC435F17A326CC22242EB /*Metadata offset 0x3C7678*/; // 0xAD5D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=262 964889A5283FD0A3DFC8AE256721E6F67B8212FD6841AB1C821DE3134DE79B07 /*Metadata offset 0x3C7728*/; // 0xAE0B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=15 96E3FDE919EC36694EFBEC22FEF80F84EE640CC5E46CED07C3E65AC04607C7D6 /*Metadata offset 0x3C7830*/; // 0xAF11
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 9960C7FC60CDD325C8A2A00995BE7064EAC3F6295C6A5C4E797D2281846131E4 /*Metadata offset 0x3C7840*/; // 0xAF20
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=44 99E66DACA3EFF94776AF1258E0E5B2F4DF2900E4EA32351B0DF37A87F2426B1F /*Metadata offset 0x3C7868*/; // 0xAF44
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 A252A93D042C5E2453990C2829A425C6DD749CCDCDF13DB58C11BBC78E8D3CE9 /*Metadata offset 0x3C7898*/; // 0xAF70
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=120 A2DFDF9C2CED8BB1C0B9B06064345ACC9C22DFE5FEC9976FF061F0994451519B /*Metadata offset 0x3C78E8*/; // 0xAFB8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=76 A2EC7CB9B0FE89F9A9BEA547D773225AFE6E4535DF28325A0D6CD7A5E2D20376 /*Metadata offset 0x3C7968*/; // 0xB030
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 A30E1152CFB528AE968FAC58E83BBEB3611BFDE2E6CF60B4FA9535A7D0A9B8EA /*Metadata offset 0x3C79B8*/; // 0xB07C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=40 A516EECB41051151F0183A8B0B6F6693C43F7D9E1815F85CAAAB18E00A5269A2 /*Metadata offset 0x3C7A08*/; // 0xB0C4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 AAF4528994DD7C464F43C131F6CD44DF41ACC18462C95877252FFC7EAC0164EF /*Metadata offset 0x3C7A38*/; // 0xB0EC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 B215DD70A77190680641703C6DF73729B4583E285AF8B51ACF9086655FB2D0F3 /*Metadata offset 0x3C7A88*/; // 0xB134
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 B21802DE889E5F4F5344C8E0D366F59B68F886F88EFE45EA5CE01534A3F5C0E5 /*Metadata offset 0x3C8A90*/; // 0xC134
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2176 B55F94CD2F415D0279D7A1AF2265C4D9A90CE47F8C900D5D09AD088796210838 /*Metadata offset 0x3C8AC8*/; // 0xC168
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 BABD01C34E7E65E57E4C431281E782B4101CE0644A8090AD6E501F1C6CF2C9DF /*Metadata offset 0x3C9350*/; // 0xC9E8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 BB425A9B43E10C921902A25D07A4317DEFF9F606A788672E1B21633C143407F0 /*Metadata offset 0x3C9378*/; // 0xCA0C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 C250CAD28060A4EB63B4C4A643DDA196CCD35FD2FC67FB749ADF4BAC6D62E1A0 /*Metadata offset 0x3C9390*/; // 0xCA1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 C2D8E5EED6CBEBD8625FC18F81486A7733C04F9B0129FFBE974C68B90308B4F2 /*Metadata offset 0x3C93B8*/; // 0xCA40
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 C5733A1245383FBF067B4A9BDB41E3FB8E3A6BDEF37B3D5418F389422875783F /*Metadata offset 0x3C94C0*/; // 0xCB40
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1024 C8EC70AC5A448C3A45CF1DFCC1375BE4E80DC6793E97D5E89BD97A0DC232B2E3 /*Metadata offset 0x3C9510*/; // 0xCB88
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 C95D810E738DB5F591EE691CE884EED2F110D9F82B1F7A8BE6ED257FDF4CDBEB /*Metadata offset 0x3C9918*/; // 0xCF88
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=130 C9830DF6956357ACE51CE1F82298578B36EB45A0CFDB8AEC5B9FDA7DB17E8063 /*Metadata offset 0x3C9930*/; // 0xCF98
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 CAF8A46B3A07E26F84FE849B57A877051A0D06194B1C057985446B64BCC6E016 /*Metadata offset 0x3C99B8*/; // 0xD01A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=36 CAFFFC9D15E4037EE8FBDB1A45DFE456F0936BDC7310F1882EAF14B706A76658 /*Metadata offset 0x3C9A08*/; // 0xD062
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 CE11D6DEAFFC6D6EF6030E30E7444C933E6261F32AA737064EF0446C219ECE22 /*Metadata offset 0x3C9A30*/; // 0xD086
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 D1A99909A2923269BB67E72C1AED693F74961BDA58360FCC133007740CEBF5F1 /*Metadata offset 0x3CAA38*/; // 0xE086
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=6 D3B16F8D71CB719B941527D5A1ADA7ED83F4EB967FEE117DDA2FE4021E1D283F /*Metadata offset 0x3CAA88*/; // 0xE0CE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 D503954AE2C3616EA32CEB0D66F5B2E119D03CE722773E5D7E1A8BC8F1803631 /*Metadata offset 0x3CAA90*/; // 0xE0D4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=172 D6691EE5A533DE7E0859066942261B24D0C836D7EE016D2251377BFEE40FEA15 /*Metadata offset 0x3CAAE0*/; // 0xE11C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2048 D870074914025E855AA5985A2D6778F1E277036BF9C9F03DEC61F3C496FEC35C /*Metadata offset 0x3CAB90*/; // 0xE1C8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 D896D464C3726A21162F271ACB711464AD07EA9C9CE78E0297FD0DE934471FA6 /*Metadata offset 0x3CB398*/; // 0xE9C8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 D8A29F3D197FBB54CF9F4B105AFBA6B1257ADF6449F0184F843380AAAA24639C /*Metadata offset 0x3CB3A8*/; // 0xE9D4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 DCDCF594464B904F763D4CE53B1DBE08A47E551AE86FD5D61F63FD0C3313FDC3 /*Metadata offset 0x3CB3F8*/; // 0xEA1C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=2350 DCE88EE5233B9D0FD0D7A6222C82BC3AEE83B15E9992F939B17AB40530DB555C /*Metadata offset 0x3CB448*/; // 0xEA64
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=152 DD471F12FFA94CC557A02A91C2CBB95F551AB28C8BBF297B2F953B8886BCCF6D /*Metadata offset 0x3CBD78*/; // 0xF392
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 DF29A050CD2EBD9DFDC783DB1CC74D3D716DAEC1630A337EE31B9E2E03D34D2D /*Metadata offset 0x3CBE18*/; // 0xF42A
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4096 E148B2057CF0C1595155635E761FB66AAE634C40D8FABC4CE79A2DB8886525D4 /*Metadata offset 0x3CBE68*/; // 0xF472
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=38 E2C673A3A737B04369A63F1FB1A30F6E742B066E2CCCD9B1838793CBB5590598 /*Metadata offset 0x3CCE70*/; // 0x10472
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 E32C465157D21F39B3DBF186A98FB02185C63B0260B47247A7A5FDF2B061EAA8 /*Metadata offset 0x3CCE98*/; // 0x10498
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 E5F4F6214036DF103321A8A0CE30C2EF935694B4199D52BC538E7EF3F045CB92 /*Metadata offset 0x3CCEA8*/; // 0x104A4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 E768EDCAE10BAB68BB5DF102FDBB8CF4F31B9D60159B44DA3F33ABC36388308B /*Metadata offset 0x3CCEC8*/; // 0x104BC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1018 E8588351183F6F6A7DAD54DC28357628F3C4D4B358AB92A18AE7D08B0D9B0092 /*Metadata offset 0x3CCF10*/; // 0x104FC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 EBE07C3718876777F609CD22058F4C3A6CCCC695F5BDE90998DC1E12E0CBE63D /*Metadata offset 0x3CD310*/; // 0x108F6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 EE415D5C3ECC6C8C19F71BCD4E03847F5A15931374A7F5BF88C24B722F04B8FE /*Metadata offset 0x3CD320*/; // 0x10902
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 EF39C5A882F9477B2A250BA257247825CEB07FC53C3C984385F2C2E5F8222431 /*Metadata offset 0x3CD348*/; // 0x10922
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=16 EF82B163CA8252A793A6E73F57775D843C9A21F65586926EB11893FA8BB603E9 /*Metadata offset 0x3CD450*/; // 0x10A22
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=240 F0CF66F9B123DCEBB39C38C5D8E4821D4E94DB593889C506BCA0827036F1B7EB /*Metadata offset 0x3CD468*/; // 0x10A32
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 F1945CD6C19E56B3C1C78943EF5EC18116907A4CA1EFC40A57D48AB1DB7ADFC5 /*Metadata offset 0x3CD560*/; // 0x10B22
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 F2830F044682E33B39018B5912634835B641562914E192CA66C654F5E4492FA8 /*Metadata offset 0x3CD568*/; // 0x10B25
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=72 F4BD8144313C3B67E191C6F3CD8B00540FF1809837C5BCA5C2FDA0D518681563 /*Metadata offset 0x3CD670*/; // 0x10C25
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=212 F7D381AF73D85950E0B064CF1AA8F14938A1F38084B46CE36AAEFE81BEF739F3 /*Metadata offset 0x3CD6C0*/; // 0x10C6D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=52 FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D8315 /*Metadata offset 0x3CD798*/; // 0x10D41
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=1208 FB2089AF82E09593374B65EC2440779FDCF5DD6DA07D26E57AF6790667B937CD /*Metadata offset 0x3CD7D0*/; // 0x10D75
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=240 FD68700E95459C5E7A49C5830F8BD0A9BA4BD171252663D8066B09E7768C5C5D /*Metadata offset 0x3CDC90*/; // 0x1122D
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=24 FEC387BA57A54BB6066E4CA8A4F9C0FF9C36B9CBD6600C3683F6FB1BDB5077EB /*Metadata offset 0x3CDD88*/; // 0x1131D

	// Methods

	// RVA: 0x18787C4 Offset: 0x18747C4 VA: 0x18787C4
	internal static uint ComputeStringHash(string s) { }
}
