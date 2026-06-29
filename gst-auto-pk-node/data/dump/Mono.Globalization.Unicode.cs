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

// Namespace: Mono.Globalization.Unicode
internal class CodePointIndexer // TypeDefIndex: 49
{
	// Fields
	private readonly CodePointIndexer.TableRange[] ranges; // 0x10
	public readonly int TotalCount; // 0x18
	private int defaultIndex; // 0x1C
	private int defaultCP; // 0x20

	// Methods

	// RVA: 0x1719BCC Offset: 0x1715BCC VA: 0x1719BCC
	public void .ctor(int[] starts, int[] ends, int defaultIndex, int defaultCP) { }

	// RVA: 0x1719D48 Offset: 0x1715D48 VA: 0x1719D48
	public int ToIndex(int cp) { }
}

// Namespace: Mono.Globalization.Unicode
internal class TailoringInfo // TypeDefIndex: 50
{
	// Fields
	public readonly int LCID; // 0x10
	public readonly int TailoringIndex; // 0x14
	public readonly int TailoringCount; // 0x18
	public readonly bool FrenchSort; // 0x1C

	// Methods

	// RVA: 0x1719DD0 Offset: 0x1715DD0 VA: 0x1719DD0
	public void .ctor(int lcid, int tailoringIndex, int tailoringCount, bool frenchSort) { }
}

// Namespace: Mono.Globalization.Unicode
internal class Contraction // TypeDefIndex: 51
{
	// Fields
	public int Index; // 0x10
	public readonly char[] Source; // 0x18
	public readonly string Replacement; // 0x20
	public readonly byte[] SortKey; // 0x28

	// Methods

	// RVA: 0x1719E14 Offset: 0x1715E14 VA: 0x1719E14
	public void .ctor(int index, char[] source, string replacement, byte[] sortkey) { }
}

// Namespace: Mono.Globalization.Unicode
internal class ContractionComparer : IComparer<Contraction> // TypeDefIndex: 52
{
	// Fields
	public static readonly ContractionComparer Instance; // 0x0

	// Methods

	// RVA: 0x1719E7C Offset: 0x1715E7C VA: 0x1719E7C Slot: 4
	public int Compare(Contraction c1, Contraction c2) { }

	// RVA: 0x1719F14 Offset: 0x1715F14 VA: 0x1719F14
	public void .ctor() { }

	// RVA: 0x1719F1C Offset: 0x1715F1C VA: 0x1719F1C
	private static void .cctor() { }
}

// Namespace: Mono.Globalization.Unicode
internal class Level2Map // TypeDefIndex: 53
{
	// Fields
	public byte Source; // 0x10
	public byte Replace; // 0x11

	// Methods

	// RVA: 0x1719F84 Offset: 0x1715F84 VA: 0x1719F84
	public void .ctor(byte source, byte replace) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MSCompatUnicodeTable.<>c // TypeDefIndex: 54
{
	// Fields
	public static readonly MSCompatUnicodeTable.<>c <>9; // 0x0
	public static Comparison<Level2Map> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x171BCA4 Offset: 0x1717CA4 VA: 0x171BCA4
	private static void .cctor() { }

	// RVA: 0x171BD0C Offset: 0x1717D0C VA: 0x171BD0C
	public void .ctor() { }

	// RVA: 0x171BD14 Offset: 0x1717D14 VA: 0x171BD14
	internal int <BuildTailoringTables>b__17_0(Level2Map a, Level2Map b) { }
}

// Namespace: Mono.Globalization.Unicode
internal class MSCompatUnicodeTable // TypeDefIndex: 55
{
	// Fields
	public static int MaxExpansionLength; // 0x0
	private static readonly byte* ignorableFlags; // 0x8
	private static readonly byte* categories; // 0x10
	private static readonly byte* level1; // 0x18
	private static readonly byte* level2; // 0x20
	private static readonly byte* level3; // 0x28
	private static byte* cjkCHScategory; // 0x30
	private static byte* cjkCHTcategory; // 0x38
	private static byte* cjkJAcategory; // 0x40
	private static byte* cjkKOcategory; // 0x48
	private static byte* cjkCHSlv1; // 0x50
	private static byte* cjkCHTlv1; // 0x58
	private static byte* cjkJAlv1; // 0x60
	private static byte* cjkKOlv1; // 0x68
	private static byte* cjkKOlv2; // 0x70
	private static readonly char[] tailoringArr; // 0x78
	private static readonly TailoringInfo[] tailoringInfos; // 0x80
	private static object forLock; // 0x88
	public static readonly bool isReady; // 0x90

	// Properties
	public static bool IsReady { get; }

	// Methods

	// RVA: 0x1719FB4 Offset: 0x1715FB4 VA: 0x1719FB4
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x171A0B8 Offset: 0x17160B8 VA: 0x171A0B8
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x171A830 Offset: 0x1716830 VA: 0x171A830
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x171AA90 Offset: 0x1716A90 VA: 0x171AA90
	public static byte Category(int cp) { }

	// RVA: 0x171AB34 Offset: 0x1716B34 VA: 0x171AB34
	public static byte Level1(int cp) { }

	// RVA: 0x171ABD8 Offset: 0x1716BD8 VA: 0x171ABD8
	public static byte Level2(int cp) { }

	// RVA: 0x171AC7C Offset: 0x1716C7C VA: 0x171AC7C
	public static byte Level3(int cp) { }

	// RVA: 0x171AD20 Offset: 0x1716D20 VA: 0x171AD20
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x171AE30 Offset: 0x1716E30 VA: 0x171AE30
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x171AE88 Offset: 0x1716E88 VA: 0x171AE88
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x171AEA0 Offset: 0x1716EA0 VA: 0x171AEA0
	public static int ToWidthCompat(int i) { }

	// RVA: 0x171B020 Offset: 0x1717020 VA: 0x171B020
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x171B0A4 Offset: 0x17170A4 VA: 0x171B0A4
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x171B0B8 Offset: 0x17170B8 VA: 0x171B0B8
	public static bool IsHiragana(char c) { }

	// RVA: 0x171B0CC Offset: 0x17170CC VA: 0x171B0CC
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x171B1CC Offset: 0x17171CC VA: 0x171B1CC
	public static bool get_IsReady() { }

	// RVA: 0x171B224 Offset: 0x1717224 VA: 0x171B224
	private static IntPtr GetResource(string name) { }

	// RVA: 0x171B2DC Offset: 0x17172DC VA: 0x171B2DC
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x171B308 Offset: 0x1717308 VA: 0x171B308
	private static void .cctor() { }

	// RVA: 0x171B6D0 Offset: 0x17176D0 VA: 0x171B6D0
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x171B840 Offset: 0x1717840 VA: 0x171B840
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }
}

// Namespace: Mono.Globalization.Unicode
internal class MSCompatUnicodeTableUtil // TypeDefIndex: 56
{
	// Fields
	public static readonly CodePointIndexer Ignorable; // 0x0
	public static readonly CodePointIndexer Category; // 0x8
	public static readonly CodePointIndexer Level1; // 0x10
	public static readonly CodePointIndexer Level2; // 0x18
	public static readonly CodePointIndexer Level3; // 0x20
	public static readonly CodePointIndexer CjkCHS; // 0x28
	public static readonly CodePointIndexer Cjk; // 0x30

	// Methods

	// RVA: 0x171BD38 Offset: 0x1717D38 VA: 0x171BD38
	private static void .cctor() { }
}

// Namespace: Mono.Globalization.Unicode
internal class NormalizationTableUtil // TypeDefIndex: 57
{
	// Fields
	public static readonly CodePointIndexer Prop; // 0x0
	public static readonly CodePointIndexer Map; // 0x8
	public static readonly CodePointIndexer Combining; // 0x10
	public static readonly CodePointIndexer Composite; // 0x18
	public static readonly CodePointIndexer Helper; // 0x20

	// Methods

	// RVA: 0x171C1A8 Offset: 0x17181A8 VA: 0x171C1A8
	private static void .cctor() { }

	// RVA: 0x171C51C Offset: 0x171851C VA: 0x171C51C
	public static int PropIdx(int cp) { }

	// RVA: 0x171C584 Offset: 0x1718584 VA: 0x171C584
	public static int MapIdx(int cp) { }
}

// Namespace: 
internal struct SimpleCollator.Context // TypeDefIndex: 58
{
	// Fields
	public readonly CompareOptions Option; // 0x0
	public readonly byte* NeverMatchFlags; // 0x8
	public readonly byte* AlwaysMatchFlags; // 0x10
	public byte* Buffer1; // 0x18
	public byte* Buffer2; // 0x20
	public int PrevCode; // 0x28
	public byte* PrevSortKey; // 0x30

	// Methods

	// RVA: 0x171DFB8 Offset: 0x1719FB8 VA: 0x171DFB8
	public void .ctor(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1) { }
}

// Namespace: 
private struct SimpleCollator.PreviousInfo // TypeDefIndex: 59
{
	// Fields
	public int Code; // 0x0
	public byte* SortKey; // 0x8

	// Methods

	// RVA: 0x171FB54 Offset: 0x171BB54 VA: 0x171FB54
	public void .ctor(bool dummy) { }
}

// Namespace: 
private struct SimpleCollator.Escape // TypeDefIndex: 60
{
	// Fields
	public string Source; // 0x0
	public int Index; // 0x8
	public int Start; // 0xC
	public int End; // 0x10
	public int Optional; // 0x14
}

// Namespace: 
private enum SimpleCollator.ExtenderType // TypeDefIndex: 61
{
	// Fields
	public int value__; // 0x0
	public const SimpleCollator.ExtenderType None = 0;
	public const SimpleCollator.ExtenderType Simple = 1;
	public const SimpleCollator.ExtenderType Voiced = 2;
	public const SimpleCollator.ExtenderType Conditional = 3;
	public const SimpleCollator.ExtenderType Buggy = 4;
}

// Namespace: Mono.Globalization.Unicode
internal class SimpleCollator : ISimpleCollator // TypeDefIndex: 62
{
	// Fields
	private static SimpleCollator invariant; // 0x0
	private readonly TextInfo textInfo; // 0x10
	private readonly CodePointIndexer cjkIndexer; // 0x18
	private readonly Contraction[] contractions; // 0x20
	private readonly Level2Map[] level2Maps; // 0x28
	private readonly byte[] unsafeFlags; // 0x30
	private readonly byte* cjkCatTable; // 0x38
	private readonly byte* cjkLv1Table; // 0x40
	private readonly byte* cjkLv2Table; // 0x48
	private readonly CodePointIndexer cjkLv2Indexer; // 0x50
	private readonly int lcid; // 0x58
	private readonly bool frenchSort; // 0x5C

	// Methods

	// RVA: 0x171C5EC Offset: 0x17185EC VA: 0x171C5EC
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x171C92C Offset: 0x171892C VA: 0x171C92C
	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x171CA08 Offset: 0x1718A08 VA: 0x171CA08
	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	// RVA: 0x171CA78 Offset: 0x1718A78 VA: 0x171CA78
	private byte Category(int cp) { }

	// RVA: 0x171CB0C Offset: 0x1718B0C VA: 0x171CB0C
	private byte Level1(int cp) { }

	// RVA: 0x171CBA0 Offset: 0x1718BA0 VA: 0x171CBA0
	private byte Level2(int cp, SimpleCollator.ExtenderType ext) { }

	// RVA: 0x171CCD8 Offset: 0x1718CD8 VA: 0x171CCD8
	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	// RVA: 0x171CD48 Offset: 0x1718D48 VA: 0x171CD48
	private Contraction GetContraction(string s, int start, int end) { }

	// RVA: 0x171CE08 Offset: 0x1718E08 VA: 0x171CE08
	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x171CF30 Offset: 0x1718F30 VA: 0x171CF30
	private Contraction GetTailContraction(string s, int start, int end) { }

	// RVA: 0x171CFF0 Offset: 0x1718FF0 VA: 0x171CFF0
	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x171D1D0 Offset: 0x17191D0 VA: 0x171D1D0
	private int FilterOptions(int i, CompareOptions opt) { }

	// RVA: 0x171D2B4 Offset: 0x17192B4 VA: 0x171D2B4
	private SimpleCollator.ExtenderType GetExtenderType(int i) { }

	// RVA: 0x171D3B0 Offset: 0x17193B0 VA: 0x171D3B0
	private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x171D3D8 Offset: 0x17193D8 VA: 0x171D3D8
	private int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x171D5E8 Offset: 0x17195E8 VA: 0x171D5E8
	private static bool IsIgnorable(int i, CompareOptions opt) { }

	// RVA: 0x171D664 Offset: 0x1719664 VA: 0x171D664
	private bool IsSafe(int i) { }

	// RVA: 0x171D6C0 Offset: 0x17196C0 VA: 0x171D6C0 Slot: 4
	public SortKey GetSortKey(string s, CompareOptions options) { }

	// RVA: 0x171D6DC Offset: 0x17196DC VA: 0x171D6DC
	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	// RVA: 0x171D9C0 Offset: 0x17199C0 VA: 0x171D9C0
	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x171DFD4 Offset: 0x1719FD4 VA: 0x171DFD4
	private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x171E4F4 Offset: 0x171A4F4 VA: 0x171E4F4
	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	// RVA: 0x171E63C Offset: 0x171A63C VA: 0x171E63C Slot: 5
	private int System.Globalization.ISimpleCollator.Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x171E640 Offset: 0x171A640 VA: 0x171E640
	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x171DD54 Offset: 0x1719D54 VA: 0x171DD54
	private void ClearBuffer(byte* buffer, int size) { }

	// RVA: 0x171E6F8 Offset: 0x171A6F8 VA: 0x171E6F8
	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx) { }

	// RVA: 0x171FB64 Offset: 0x171BB64 VA: 0x171FB64
	private int CompareFlagPair(bool b1, bool b2) { }

	// RVA: 0x171FB80 Offset: 0x171BB80 VA: 0x171FB80 Slot: 6
	public bool IsPrefix(string src, string target, CompareOptions opt) { }

	// RVA: 0x171FB9C Offset: 0x171BB9C VA: 0x171FB9C
	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x171FC4C Offset: 0x171BC4C VA: 0x171FC4C
	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx) { }

	// RVA: 0x171FCB8 Offset: 0x171BCB8 VA: 0x171FCB8 Slot: 7
	public bool IsSuffix(string src, string target, CompareOptions opt) { }

	// RVA: 0x171FCD4 Offset: 0x171BCD4 VA: 0x171FCD4
	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x171FF04 Offset: 0x171BF04 VA: 0x171FF04
	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	// RVA: 0x172006C Offset: 0x171C06C VA: 0x172006C Slot: 8
	public int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x17206E0 Offset: 0x171C6E0 VA: 0x17206E0
	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x17207B8 Offset: 0x171C7B8 VA: 0x17207B8
	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	// RVA: 0x1720828 Offset: 0x171C828 VA: 0x1720828
	private int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x172026C Offset: 0x171C26C VA: 0x172026C
	private int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x171FD68 Offset: 0x171BD68 VA: 0x171FD68 Slot: 9
	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x1720F68 Offset: 0x171CF68 VA: 0x1720F68
	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x17210A0 Offset: 0x171D0A0 VA: 0x17210A0
	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1720A60 Offset: 0x171CA60 VA: 0x1720A60
	private int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x17208BC Offset: 0x171C8BC VA: 0x17208BC
	private bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x17212EC Offset: 0x171D2EC VA: 0x17212EC
	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1721660 Offset: 0x171D660 VA: 0x1721660
	private bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4) { }

	// RVA: 0x172113C Offset: 0x171D13C VA: 0x172113C
	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1721894 Offset: 0x171D894 VA: 0x1721894
	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1721D3C Offset: 0x171DD3C VA: 0x1721D3C
	private static void .cctor() { }
}

// Namespace: Mono.Globalization.Unicode
internal class SortKeyBuffer // TypeDefIndex: 63
{
	// Fields
	private byte[] l1b; // 0x10
	private byte[] l2b; // 0x18
	private byte[] l3b; // 0x20
	private byte[] l4sb; // 0x28
	private byte[] l4tb; // 0x30
	private byte[] l4kb; // 0x38
	private byte[] l4wb; // 0x40
	private byte[] l5b; // 0x48
	private string source; // 0x50
	private int l1; // 0x58
	private int l2; // 0x5C
	private int l3; // 0x60
	private int l4s; // 0x64
	private int l4t; // 0x68
	private int l4k; // 0x6C
	private int l4w; // 0x70
	private int l5; // 0x74
	private int lcid; // 0x78
	private CompareOptions options; // 0x7C
	private bool processLevel2; // 0x80
	private bool frenchSort; // 0x81
	private bool frenchSorted; // 0x82

	// Methods

	// RVA: 0x171D7A4 Offset: 0x17197A4 VA: 0x171D7A4
	public void .ctor(int lcid) { }

	// RVA: 0x1721DD8 Offset: 0x171DDD8 VA: 0x1721DD8
	public void Reset() { }

	// RVA: 0x171D7AC Offset: 0x17197AC VA: 0x171D7AC
	internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort) { }

	// RVA: 0x171E470 Offset: 0x171A470 VA: 0x171E470
	internal void AppendCJKExtension(byte lv1msb, byte lv1lsb) { }

	// RVA: 0x171E5A8 Offset: 0x171A5A8 VA: 0x171E5A8
	internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth) { }

	// RVA: 0x171E340 Offset: 0x171A340 VA: 0x171E340
	internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3) { }

	// RVA: 0x1721ECC Offset: 0x171DECC VA: 0x1721ECC
	private void AppendLevel5(byte category, byte lv1) { }

	// RVA: 0x1721DEC Offset: 0x171DDEC VA: 0x1721DEC
	private void AppendBufferPrimitive(byte value, ref byte[] buf, ref int bidx) { }

	// RVA: 0x171DD30 Offset: 0x1719D30 VA: 0x171DD30
	public SortKey GetResultAndReset() { }

	// RVA: 0x1722438 Offset: 0x171E438 VA: 0x1722438
	private int GetOptimizedLength(byte[] data, int len, byte defaultValue) { }

	// RVA: 0x1721F5C Offset: 0x171DF5C VA: 0x1721F5C
	public SortKey GetResult() { }
}
