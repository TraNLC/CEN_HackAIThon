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

// Namespace: System.Globalization
public static class CharUnicodeInfo // TypeDefIndex: 1293
{
	// Properties
	private static ReadOnlySpan<byte> CategoryLevel1Index { get; }
	private static ReadOnlySpan<byte> CategoryLevel2Index { get; }
	private static ReadOnlySpan<byte> CategoryLevel3Index { get; }
	private static ReadOnlySpan<byte> CategoriesValue { get; }

	// Methods

	// RVA: 0x17F0C2C Offset: 0x17ECC2C VA: 0x17F0C2C
	internal static int InternalConvertToUtf32(string s, int index) { }

	// RVA: 0x17F0CC4 Offset: 0x17ECCC4 VA: 0x17F0CC4
	public static UnicodeCategory GetUnicodeCategory(char ch) { }

	// RVA: 0x17F0CF8 Offset: 0x17ECCF8 VA: 0x17F0CF8
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x17F0CE0 Offset: 0x17ECCE0 VA: 0x17F0CE0
	public static UnicodeCategory GetUnicodeCategory(int codePoint) { }

	// RVA: 0x17F0DBC Offset: 0x17ECDBC VA: 0x17F0DBC
	internal static byte InternalGetCategoryValue(int ch, int offset) { }

	// RVA: 0x17F0DA0 Offset: 0x17ECDA0 VA: 0x17F0DA0
	internal static UnicodeCategory InternalGetUnicodeCategory(string value, int index) { }

	// RVA: 0x17F0FAC Offset: 0x17ECFAC VA: 0x17F0FAC
	internal static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x17F0FC8 Offset: 0x17ECFC8 VA: 0x17F0FC8
	internal static bool IsWhiteSpace(char c) { }

	// RVA: 0x17F0E6C Offset: 0x17ECE6C VA: 0x17F0E6C
	private static ReadOnlySpan<byte> get_CategoryLevel1Index() { }

	// RVA: 0x17F0EBC Offset: 0x17ECEBC VA: 0x17F0EBC
	private static ReadOnlySpan<byte> get_CategoryLevel2Index() { }

	// RVA: 0x17F0F0C Offset: 0x17ECF0C VA: 0x17F0F0C
	private static ReadOnlySpan<byte> get_CategoryLevel3Index() { }

	// RVA: 0x17F0F5C Offset: 0x17ECF5C VA: 0x17F0F5C
	private static ReadOnlySpan<byte> get_CategoriesValue() { }
}

// Namespace: System.Globalization
[Serializable]
public class CompareInfo : IDeserializationCallback // TypeDefIndex: 1294
{
	// Fields
	private const CompareOptions ValidIndexMaskOffFlags = -32;
	private const CompareOptions ValidCompareMaskOffFlags = -536870944;
	private const CompareOptions ValidHashCodeOfStringMaskOffFlags = -32;
	private const CompareOptions ValidSortkeyCtorMaskOffFlags = -536870944;
	internal static readonly CompareInfo Invariant; // 0x0
	[OptionalField(VersionAdded = 2)]
	private string m_name; // 0x10
	private string _sortName; // 0x18
	[OptionalField(VersionAdded = 3)]
	private SortVersion m_SortVersion; // 0x20
	private int culture; // 0x28
	private ISimpleCollator collator; // 0x30
	private static Dictionary<string, ISimpleCollator> collators; // 0x8
	private static bool managedCollation; // 0x10
	private static bool managedCollationChecked; // 0x11

	// Properties
	public virtual string Name { get; }
	private static bool UseManagedCollation { get; }

	// Methods

	// RVA: 0x17F0FF0 Offset: 0x17ECFF0 VA: 0x17F0FF0
	internal static int InvariantIndexOf(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x17F14BC Offset: 0x17ED4BC VA: 0x17F14BC
	internal static int InvariantLastIndexOf(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x17F10BC Offset: 0x17ED0BC VA: 0x17F10BC
	private static int InvariantFindString(char* source, int sourceCount, char* value, int valueCount, bool ignoreCase, bool start) { }

	// RVA: 0x17F1590 Offset: 0x17ED590 VA: 0x17F1590
	private static char InvariantToUpper(char c) { }

	// RVA: 0x17F15A8 Offset: 0x17ED5A8 VA: 0x17F15A8
	private SortKey InvariantCreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x17F1844 Offset: 0x17ED844 VA: 0x17F1844
	internal void .ctor(CultureInfo culture) { }

	// RVA: 0x17F18A4 Offset: 0x17ED8A4 VA: 0x17F18A4
	public static CompareInfo GetCompareInfo(string name) { }

	[OnDeserializing]
	// RVA: 0x17F195C Offset: 0x17ED95C VA: 0x17F195C
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x17F1968 Offset: 0x17ED968 VA: 0x17F1968 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[OnDeserialized]
	// RVA: 0x17F1A1C Offset: 0x17EDA1C VA: 0x17F1A1C
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x17F196C Offset: 0x17ED96C VA: 0x17F196C
	private void OnDeserialized() { }

	[OnSerializing]
	// RVA: 0x17F1A20 Offset: 0x17EDA20 VA: 0x17F1A20
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x17F1AAC Offset: 0x17EDAAC VA: 0x17F1AAC Slot: 5
	public virtual string get_Name() { }

	// RVA: 0x17F1B38 Offset: 0x17EDB38 VA: 0x17F1B38 Slot: 6
	public virtual int Compare(string string1, string string2) { }

	// RVA: 0x17F1B48 Offset: 0x17EDB48 VA: 0x17F1B48 Slot: 7
	public virtual int Compare(string string1, string string2, CompareOptions options) { }

	// RVA: 0x17F20D8 Offset: 0x17EE0D8 VA: 0x17F20D8
	internal int Compare(ReadOnlySpan<char> string1, string string2, CompareOptions options) { }

	// RVA: 0x17F24A8 Offset: 0x17EE4A8 VA: 0x17F24A8
	internal int CompareOptionIgnoreCase(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2) { }

	// RVA: 0x17F26D4 Offset: 0x17EE6D4 VA: 0x17F26D4 Slot: 8
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x17F2BFC Offset: 0x17EEBFC VA: 0x17F2BFC
	internal static int CompareOrdinalIgnoreCase(string strA, int indexA, int lengthA, string strB, int indexB, int lengthB) { }

	// RVA: 0x17F1DE8 Offset: 0x17EDDE8 VA: 0x17F1DE8
	internal static int CompareOrdinalIgnoreCase(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB) { }

	// RVA: 0x17F2EF0 Offset: 0x17EEEF0 VA: 0x17F2EF0 Slot: 9
	public virtual bool IsPrefix(string source, string prefix, CompareOptions options) { }

	// RVA: 0x17F3288 Offset: 0x17EF288 VA: 0x17F3288 Slot: 10
	public virtual bool IsSuffix(string source, string suffix, CompareOptions options) { }

	// RVA: 0x17F361C Offset: 0x17EF61C VA: 0x17F361C
	internal bool IsSuffix(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options) { }

	// RVA: 0x17F3680 Offset: 0x17EF680 VA: 0x17F3680 Slot: 11
	public virtual int IndexOf(string source, string value, CompareOptions options) { }

	// RVA: 0x17F36E8 Offset: 0x17EF6E8 VA: 0x17F36E8 Slot: 12
	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x17F39A8 Offset: 0x17EF9A8 VA: 0x17F39A8
	internal int IndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x17F3B1C Offset: 0x17EFB1C VA: 0x17F3B1C Slot: 13
	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x17F3E60 Offset: 0x17EFE60 VA: 0x17F3E60
	internal int LastIndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x17F3FBC Offset: 0x17EFFBC VA: 0x17F3FBC Slot: 14
	public virtual SortKey GetSortKey(string source, CompareOptions options) { }

	// RVA: 0x17F413C Offset: 0x17F013C VA: 0x17F413C Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x17F41F0 Offset: 0x17F01F0 VA: 0x17F41F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17F4218 Offset: 0x17F0218 VA: 0x17F4218
	internal static int GetIgnoreCaseHash(string source) { }

	// RVA: 0x17F46B0 Offset: 0x17F06B0 VA: 0x17F46B0
	internal int GetHashCodeOfString(string source, CompareOptions options) { }

	// RVA: 0x17F487C Offset: 0x17F087C VA: 0x17F487C Slot: 15
	public virtual int GetHashCode(string source, CompareOptions options) { }

	// RVA: 0x17F497C Offset: 0x17F097C VA: 0x17F497C Slot: 3
	public override string ToString() { }

	// RVA: 0x17F49DC Offset: 0x17F09DC VA: 0x17F49DC
	private static bool get_UseManagedCollation() { }

	// RVA: 0x17F4B28 Offset: 0x17F0B28 VA: 0x17F4B28
	private ISimpleCollator GetCollator() { }

	// RVA: 0x17F4E54 Offset: 0x17F0E54 VA: 0x17F4E54
	private SortKey CreateSortKeyCore(string source, CompareOptions options) { }

	// RVA: 0x17F4F8C Offset: 0x17F0F8C VA: 0x17F4F8C
	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x17F1FDC Offset: 0x17EDFDC VA: 0x17F1FDC
	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x17F5390 Offset: 0x17F1390 VA: 0x17F5390
	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x17F5194 Offset: 0x17F1194 VA: 0x17F5194
	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x17F5490 Offset: 0x17F1490 VA: 0x17F5490
	private static int internal_compare_icall(char* str1, int length1, char* str2, int length2, CompareOptions options) { }

	// RVA: 0x17F52DC Offset: 0x17F12DC VA: 0x17F52DC
	private static int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x17F5494 Offset: 0x17F1494 VA: 0x17F5494
	private static int internal_index_icall(char* source, int sindex, int count, char* value, int value_length, bool first) { }

	// RVA: 0x17F50E0 Offset: 0x17F10E0 VA: 0x17F50E0
	private static int internal_index(string source, int sindex, int count, string value, bool first) { }

	// RVA: 0x17F188C Offset: 0x17ED88C VA: 0x17F188C
	private void InitSort(CultureInfo culture) { }

	// RVA: 0x17F2D70 Offset: 0x17EED70 VA: 0x17F2D70
	private static int CompareStringOrdinalIgnoreCase(char* pString1, int length1, char* pString2, int length2) { }

	// RVA: 0x17F3AF0 Offset: 0x17EFAF0 VA: 0x17F3AF0
	internal static int IndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x17F3F90 Offset: 0x17EFF90 VA: 0x17F3F90
	internal static int LastIndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x17F3F78 Offset: 0x17EFF78 VA: 0x17F3F78
	private int LastIndexOfCore(string source, string target, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x17F3AC0 Offset: 0x17EFAC0 VA: 0x17F3AC0
	private int IndexOfCore(string source, string target, int startIndex, int count, CompareOptions options, int* matchLengthPtr) { }

	// RVA: 0x17F2444 Offset: 0x17EE444 VA: 0x17F2444
	private int CompareString(ReadOnlySpan<char> string1, string string2, CompareOptions options) { }

	// RVA: 0x17F25E4 Offset: 0x17EE5E4 VA: 0x17F25E4
	private int CompareString(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options) { }

	// RVA: 0x17F4084 Offset: 0x17F0084 VA: 0x17F4084
	private SortKey CreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x17F3114 Offset: 0x17EF114 VA: 0x17F3114
	private bool StartsWith(string source, string prefix, CompareOptions options) { }

	// RVA: 0x17F34AC Offset: 0x17EF4AC VA: 0x17F34AC
	private bool EndsWith(string source, string suffix, CompareOptions options) { }

	// RVA: 0x17F3620 Offset: 0x17EF620 VA: 0x17F3620
	private bool EndsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options) { }

	// RVA: 0x17F4850 Offset: 0x17F0850 VA: 0x17F4850
	internal int GetHashCodeOfStringCore(string source, CompareOptions options) { }

	// RVA: 0x17F5498 Offset: 0x17F1498 VA: 0x17F5498
	private static void .cctor() { }

	// RVA: 0x17F552C Offset: 0x17F152C VA: 0x17F552C
	internal void .ctor() { }
}

// Namespace: System.Globalization
[Flags]
public enum CompareOptions // TypeDefIndex: 1295
{
	// Fields
	public int value__; // 0x0
	public const CompareOptions None = 0;
	public const CompareOptions IgnoreCase = 1;
	public const CompareOptions IgnoreNonSpace = 2;
	public const CompareOptions IgnoreSymbols = 4;
	public const CompareOptions IgnoreKanaType = 8;
	public const CompareOptions IgnoreWidth = 16;
	public const CompareOptions OrdinalIgnoreCase = 268435456;
	public const CompareOptions StringSort = 536870912;
	public const CompareOptions Ordinal = 1073741824;
}

// Namespace: System.Globalization
[Serializable]
public class CultureNotFoundException : ArgumentException // TypeDefIndex: 1296
{
	// Fields
	private string _invalidCultureName; // 0x98
	private Nullable<int> _invalidCultureId; // 0xA0

	// Properties
	public virtual Nullable<int> InvalidCultureId { get; }
	public virtual string InvalidCultureName { get; }
	private static string DefaultMessage { get; }
	private string FormatedInvalidCultureId { get; }
	public override string Message { get; }

	// Methods

	// RVA: 0x17F5564 Offset: 0x17F1564 VA: 0x17F5564
	public void .ctor() { }

	// RVA: 0x17F55F0 Offset: 0x17F15F0 VA: 0x17F55F0
	public void .ctor(string paramName, string message) { }

	// RVA: 0x17F5604 Offset: 0x17F1604 VA: 0x17F5604
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17F57F8 Offset: 0x17F17F8 VA: 0x17F57F8 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17F5940 Offset: 0x17F1940 VA: 0x17F5940 Slot: 12
	public virtual Nullable<int> get_InvalidCultureId() { }

	// RVA: 0x17F5948 Offset: 0x17F1948 VA: 0x17F5948 Slot: 13
	public virtual string get_InvalidCultureName() { }

	// RVA: 0x17F55B0 Offset: 0x17F15B0 VA: 0x17F55B0
	private static string get_DefaultMessage() { }

	// RVA: 0x17F5950 Offset: 0x17F1950 VA: 0x17F5950
	private string get_FormatedInvalidCultureId() { }

	// RVA: 0x17F5A84 Offset: 0x17F1A84 VA: 0x17F5A84 Slot: 5
	public override string get_Message() { }
}

// Namespace: System.Globalization
[Flags]
public enum CultureTypes // TypeDefIndex: 1297
{
	// Fields
	public int value__; // 0x0
	public const CultureTypes NeutralCultures = 1;
	public const CultureTypes SpecificCultures = 2;
	public const CultureTypes InstalledWin32Cultures = 4;
	public const CultureTypes AllCultures = 7;
	public const CultureTypes UserCustomCulture = 8;
	public const CultureTypes ReplacementCultures = 16;
	[Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
	public const CultureTypes WindowsOnlyCultures = 32;
	[Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
	public const CultureTypes FrameworkCultures = 64;
}

// Namespace: System.Globalization
[Flags]
internal enum MonthNameStyles // TypeDefIndex: 1298
{
	// Fields
	public int value__; // 0x0
	public const MonthNameStyles Regular = 0;
	public const MonthNameStyles Genitive = 1;
	public const MonthNameStyles LeapYear = 2;
}

// Namespace: System.Globalization
[Flags]
internal enum DateTimeFormatFlags // TypeDefIndex: 1299
{
	// Fields
	public int value__; // 0x0
	public const DateTimeFormatFlags None = 0;
	public const DateTimeFormatFlags UseGenitiveMonth = 1;
	public const DateTimeFormatFlags UseLeapYearMonth = 2;
	public const DateTimeFormatFlags UseSpacesInMonthNames = 4;
	public const DateTimeFormatFlags UseHebrewRule = 8;
	public const DateTimeFormatFlags UseSpacesInDayNames = 16;
	public const DateTimeFormatFlags UseDigitPrefixInTokens = 32;
	public const DateTimeFormatFlags NotInitialized = -1;
}

// Namespace: 
internal class DateTimeFormatInfo.TokenHashValue // TypeDefIndex: 1300
{
	// Fields
	internal string tokenString; // 0x10
	internal TokenType tokenType; // 0x18
	internal int tokenValue; // 0x1C

	// Methods

	// RVA: 0x17FB664 Offset: 0x17F7664 VA: 0x17FB664
	internal void .ctor(string tokenString, TokenType tokenType, int tokenValue) { }
}

// Namespace: System.Globalization
[Serializable]
public sealed class DateTimeFormatInfo : IFormatProvider, ICloneable // TypeDefIndex: 1301
{
	// Fields
	private static DateTimeFormatInfo s_invariantInfo; // 0x0
	private CultureData _cultureData; // 0x10
	private string _name; // 0x18
	private string _langName; // 0x20
	private CompareInfo _compareInfo; // 0x28
	private CultureInfo _cultureInfo; // 0x30
	private string amDesignator; // 0x38
	private string pmDesignator; // 0x40
	private string dateSeparator; // 0x48
	private string generalShortTimePattern; // 0x50
	private string generalLongTimePattern; // 0x58
	private string timeSeparator; // 0x60
	private string monthDayPattern; // 0x68
	private string dateTimeOffsetPattern; // 0x70
	private const string rfc1123Pattern = "ddd, dd MMM yyyy HH\':\'mm\':\'ss \'GMT\'";
	private const string sortableDateTimePattern = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss";
	private const string universalSortableDateTimePattern = "yyyy\'-\'MM\'-\'dd HH\':\'mm\':\'ss\'Z\'";
	private Calendar calendar; // 0x78
	private int firstDayOfWeek; // 0x80
	private int calendarWeekRule; // 0x84
	private string fullDateTimePattern; // 0x88
	private string[] abbreviatedDayNames; // 0x90
	private string[] m_superShortDayNames; // 0x98
	private string[] dayNames; // 0xA0
	private string[] abbreviatedMonthNames; // 0xA8
	private string[] monthNames; // 0xB0
	private string[] genitiveMonthNames; // 0xB8
	private string[] m_genitiveAbbreviatedMonthNames; // 0xC0
	private string[] leapYearMonthNames; // 0xC8
	private string longDatePattern; // 0xD0
	private string shortDatePattern; // 0xD8
	private string yearMonthPattern; // 0xE0
	private string longTimePattern; // 0xE8
	private string shortTimePattern; // 0xF0
	private string[] allYearMonthPatterns; // 0xF8
	private string[] allShortDatePatterns; // 0x100
	private string[] allLongDatePatterns; // 0x108
	private string[] allShortTimePatterns; // 0x110
	private string[] allLongTimePatterns; // 0x118
	private string[] m_eraNames; // 0x120
	private string[] m_abbrevEraNames; // 0x128
	private string[] m_abbrevEnglishEraNames; // 0x130
	private CalendarId[] optionalCalendars; // 0x138
	private const int DEFAULT_ALL_DATETIMES_SIZE = 132;
	internal bool _isReadOnly; // 0x140
	private DateTimeFormatFlags formatFlags; // 0x144
	private static readonly char[] s_monthSpaces; // 0x8
	internal const string RoundtripFormat = "yyyy\'-\'MM\'-\'dd\'T\'HH\':\'mm\':\'ss.fffffffK";
	internal const string RoundtripDateTimeUnfixed = "yyyy\'-\'MM\'-\'ddTHH\':\'mm\':\'ss zzz";
	private string _fullTimeSpanPositivePattern; // 0x148
	private string _fullTimeSpanNegativePattern; // 0x150
	internal const DateTimeStyles InvalidDateTimeStyles = -256;
	private DateTimeFormatInfo.TokenHashValue[] _dtfiTokenHash; // 0x158
	private const int TOKEN_HASH_SIZE = 199;
	private const int SECOND_PRIME = 197;
	private const string dateSeparatorOrTimeZoneOffset = "-";
	private const string invariantDateSeparator = "/";
	private const string invariantTimeSeparator = ":";
	internal const string IgnorablePeriod = ".";
	internal const string IgnorableComma = ",";
	internal const string CJKYearSuff = "年";
	internal const string CJKMonthSuff = "月";
	internal const string CJKDaySuff = "日";
	internal const string KoreanYearSuff = "년";
	internal const string KoreanMonthSuff = "월";
	internal const string KoreanDaySuff = "일";
	internal const string KoreanHourSuff = "시";
	internal const string KoreanMinuteSuff = "분";
	internal const string KoreanSecondSuff = "초";
	internal const string CJKHourSuff = "時";
	internal const string ChineseHourSuff = "时";
	internal const string CJKMinuteSuff = "分";
	internal const string CJKSecondSuff = "秒";
	internal const string JapaneseEraStart = "元";
	internal const string LocalTimeMark = "T";
	internal const string GMTName = "GMT";
	internal const string ZuluName = "Z";
	internal const string KoreanLangName = "ko";
	internal const string JapaneseLangName = "ja";
	internal const string EnglishLangName = "en";
	private static DateTimeFormatInfo s_jajpDTFI; // 0x10
	private static DateTimeFormatInfo s_zhtwDTFI; // 0x18

	// Properties
	private string CultureName { get; }
	private CultureInfo Culture { get; }
	private string LanguageName { get; }
	public static DateTimeFormatInfo InvariantInfo { get; }
	public static DateTimeFormatInfo CurrentInfo { get; }
	public string AMDesignator { get; }
	public Calendar Calendar { get; set; }
	private CalendarId[] OptionalCalendars { get; }
	internal string[] EraNames { get; }
	internal string[] AbbreviatedEraNames { get; }
	internal string[] AbbreviatedEnglishEraNames { get; }
	public string DateSeparator { get; }
	public string FullDateTimePattern { get; }
	public string LongDatePattern { get; }
	public string LongTimePattern { get; }
	public string MonthDayPattern { get; }
	public string PMDesignator { get; }
	public string RFC1123Pattern { get; }
	public string ShortDatePattern { get; }
	public string ShortTimePattern { get; }
	public string SortableDateTimePattern { get; }
	internal string GeneralShortTimePattern { get; }
	internal string GeneralLongTimePattern { get; }
	internal string DateTimeOffsetPattern { get; }
	public string TimeSeparator { get; }
	public string UniversalSortableDateTimePattern { get; }
	public string YearMonthPattern { get; }
	public string[] AbbreviatedDayNames { get; }
	public string[] DayNames { get; }
	public string[] AbbreviatedMonthNames { get; }
	public string[] MonthNames { get; }
	internal bool HasSpacesInMonthNames { get; }
	internal bool HasSpacesInDayNames { get; }
	private string[] AllYearMonthPatterns { get; }
	private string[] AllShortDatePatterns { get; }
	private string[] AllShortTimePatterns { get; }
	private string[] AllLongDatePatterns { get; }
	private string[] AllLongTimePatterns { get; }
	private string[] UnclonedYearMonthPatterns { get; }
	private string[] UnclonedShortDatePatterns { get; }
	private string[] UnclonedLongDatePatterns { get; }
	private string[] UnclonedShortTimePatterns { get; }
	private string[] UnclonedLongTimePatterns { get; }
	public bool IsReadOnly { get; }
	public string[] MonthGenitiveNames { get; }
	internal string FullTimeSpanPositivePattern { get; }
	internal string FullTimeSpanNegativePattern { get; }
	internal CompareInfo CompareInfo { get; }
	internal DateTimeFormatFlags FormatFlags { get; }
	internal bool HasForceTwoDigitYears { get; }
	internal bool HasYearMonthAdjustment { get; }

	// Methods

	// RVA: 0x17F5B40 Offset: 0x17F1B40 VA: 0x17F5B40
	private string get_CultureName() { }

	// RVA: 0x17F5B7C Offset: 0x17F1B7C VA: 0x17F5B7C
	private CultureInfo get_Culture() { }

	// RVA: 0x17F5C08 Offset: 0x17F1C08 VA: 0x17F5C08
	private string get_LanguageName() { }

	// RVA: 0x17F5C44 Offset: 0x17F1C44 VA: 0x17F5C44
	private string[] internalGetAbbreviatedDayOfWeekNames() { }

	// RVA: 0x17F5C58 Offset: 0x17F1C58 VA: 0x17F5C58
	private string[] internalGetAbbreviatedDayOfWeekNamesCore() { }

	// RVA: 0x17F5CB4 Offset: 0x17F1CB4 VA: 0x17F5CB4
	private string[] internalGetDayOfWeekNames() { }

	// RVA: 0x17F5CC8 Offset: 0x17F1CC8 VA: 0x17F5CC8
	private string[] internalGetDayOfWeekNamesCore() { }

	// RVA: 0x17F5D24 Offset: 0x17F1D24 VA: 0x17F5D24
	private string[] internalGetAbbreviatedMonthNames() { }

	// RVA: 0x17F5D38 Offset: 0x17F1D38 VA: 0x17F5D38
	private string[] internalGetAbbreviatedMonthNamesCore() { }

	// RVA: 0x17F5D94 Offset: 0x17F1D94 VA: 0x17F5D94
	private string[] internalGetMonthNames() { }

	// RVA: 0x17F5DA8 Offset: 0x17F1DA8 VA: 0x17F5DA8
	private string[] internalGetMonthNamesCore() { }

	// RVA: 0x17F5E04 Offset: 0x17F1E04 VA: 0x17F5E04
	public void .ctor() { }

	// RVA: 0x17F6074 Offset: 0x17F2074 VA: 0x17F6074
	internal void .ctor(CultureData cultureData, Calendar cal) { }

	// RVA: 0x17F5EF4 Offset: 0x17F1EF4 VA: 0x17F5EF4
	private void InitializeOverridableProperties(CultureData cultureData, int calendarId) { }

	// RVA: 0x17F64C0 Offset: 0x17F24C0 VA: 0x17F64C0
	public static DateTimeFormatInfo get_InvariantInfo() { }

	// RVA: 0x17F65A0 Offset: 0x17F25A0 VA: 0x17F65A0
	public static DateTimeFormatInfo get_CurrentInfo() { }

	// RVA: 0x17F66A0 Offset: 0x17F26A0 VA: 0x17F66A0
	public static DateTimeFormatInfo GetInstance(IFormatProvider provider) { }

	// RVA: 0x17F683C Offset: 0x17F283C VA: 0x17F683C Slot: 4
	public object GetFormat(Type formatType) { }

	// RVA: 0x17F68C8 Offset: 0x17F28C8 VA: 0x17F68C8 Slot: 5
	public object Clone() { }

	// RVA: 0x17F69E4 Offset: 0x17F29E4 VA: 0x17F69E4
	public string get_AMDesignator() { }

	// RVA: 0x17F6A20 Offset: 0x17F2A20 VA: 0x17F6A20
	public Calendar get_Calendar() { }

	// RVA: 0x17F60C4 Offset: 0x17F20C4 VA: 0x17F60C4
	public void set_Calendar(Calendar value) { }

	// RVA: 0x17F6ACC Offset: 0x17F2ACC VA: 0x17F6ACC
	private CalendarId[] get_OptionalCalendars() { }

	// RVA: 0x17F6B34 Offset: 0x17F2B34 VA: 0x17F6B34
	internal string[] get_EraNames() { }

	// RVA: 0x17F6B98 Offset: 0x17F2B98 VA: 0x17F6B98
	public string GetEraName(int era) { }

	// RVA: 0x17F6C70 Offset: 0x17F2C70 VA: 0x17F6C70
	internal string[] get_AbbreviatedEraNames() { }

	// RVA: 0x17F6CD4 Offset: 0x17F2CD4 VA: 0x17F6CD4
	public string GetAbbreviatedEraName(int era) { }

	// RVA: 0x17F6DBC Offset: 0x17F2DBC VA: 0x17F6DBC
	internal string[] get_AbbreviatedEnglishEraNames() { }

	// RVA: 0x17F6E20 Offset: 0x17F2E20 VA: 0x17F6E20
	public string get_DateSeparator() { }

	// RVA: 0x17F6E8C Offset: 0x17F2E8C VA: 0x17F6E8C
	public string get_FullDateTimePattern() { }

	// RVA: 0x17F6F14 Offset: 0x17F2F14 VA: 0x17F6F14
	public string get_LongDatePattern() { }

	// RVA: 0x17F6F60 Offset: 0x17F2F60 VA: 0x17F6F60
	public string get_LongTimePattern() { }

	// RVA: 0x17F7050 Offset: 0x17F3050 VA: 0x17F7050
	public string get_MonthDayPattern() { }

	// RVA: 0x17F70BC Offset: 0x17F30BC VA: 0x17F70BC
	public string get_PMDesignator() { }

	// RVA: 0x17F70F8 Offset: 0x17F30F8 VA: 0x17F70F8
	public string get_RFC1123Pattern() { }

	// RVA: 0x17F7138 Offset: 0x17F3138 VA: 0x17F7138
	public string get_ShortDatePattern() { }

	// RVA: 0x17F71E8 Offset: 0x17F31E8 VA: 0x17F71E8
	public string get_ShortTimePattern() { }

	// RVA: 0x17F7274 Offset: 0x17F3274 VA: 0x17F7274
	public string get_SortableDateTimePattern() { }

	// RVA: 0x17F72B4 Offset: 0x17F32B4 VA: 0x17F72B4
	internal string get_GeneralShortTimePattern() { }

	// RVA: 0x17F733C Offset: 0x17F333C VA: 0x17F733C
	internal string get_GeneralLongTimePattern() { }

	// RVA: 0x17F73C4 Offset: 0x17F33C4 VA: 0x17F73C4
	internal string get_DateTimeOffsetPattern() { }

	// RVA: 0x17F7570 Offset: 0x17F3570 VA: 0x17F7570
	public string get_TimeSeparator() { }

	// RVA: 0x17F75AC Offset: 0x17F35AC VA: 0x17F75AC
	public string get_UniversalSortableDateTimePattern() { }

	// RVA: 0x17F75EC Offset: 0x17F35EC VA: 0x17F75EC
	public string get_YearMonthPattern() { }

	// RVA: 0x17F76A4 Offset: 0x17F36A4 VA: 0x17F76A4
	public string[] get_AbbreviatedDayNames() { }

	// RVA: 0x17F7728 Offset: 0x17F3728 VA: 0x17F7728
	public string[] get_DayNames() { }

	// RVA: 0x17F77AC Offset: 0x17F37AC VA: 0x17F77AC
	public string[] get_AbbreviatedMonthNames() { }

	// RVA: 0x17F7830 Offset: 0x17F3830 VA: 0x17F7830
	public string[] get_MonthNames() { }

	// RVA: 0x17F78B4 Offset: 0x17F38B4 VA: 0x17F78B4
	internal bool get_HasSpacesInMonthNames() { }

	// RVA: 0x17F78F4 Offset: 0x17F38F4 VA: 0x17F78F4
	internal bool get_HasSpacesInDayNames() { }

	// RVA: 0x17F791C Offset: 0x17F391C VA: 0x17F791C
	internal string internalGetMonthName(int month, MonthNameStyles style, bool abbreviated) { }

	// RVA: 0x17F7A78 Offset: 0x17F3A78 VA: 0x17F7A78
	private string[] internalGetGenitiveMonthNames(bool abbreviated) { }

	// RVA: 0x17F7B20 Offset: 0x17F3B20 VA: 0x17F7B20
	internal string[] internalGetLeapYearMonthNames() { }

	// RVA: 0x17F7B8C Offset: 0x17F3B8C VA: 0x17F7B8C
	public string GetAbbreviatedDayName(DayOfWeek dayofweek) { }

	// RVA: 0x17F7C88 Offset: 0x17F3C88 VA: 0x17F7C88
	private static string[] GetCombinedPatterns(string[] patterns1, string[] patterns2, string connectString) { }

	// RVA: 0x17F7DC0 Offset: 0x17F3DC0 VA: 0x17F7DC0
	public string[] GetAllDateTimePatterns(char format) { }

	// RVA: 0x17F8400 Offset: 0x17F4400 VA: 0x17F8400
	public string GetDayName(DayOfWeek dayofweek) { }

	// RVA: 0x17F84FC Offset: 0x17F44FC VA: 0x17F84FC
	public string GetAbbreviatedMonthName(int month) { }

	// RVA: 0x17F85F4 Offset: 0x17F45F4 VA: 0x17F85F4
	public string GetMonthName(int month) { }

	// RVA: 0x17F86EC Offset: 0x17F46EC VA: 0x17F86EC
	private static string[] GetMergedPatterns(string[] patterns, string defaultPattern) { }

	// RVA: 0x17F838C Offset: 0x17F438C VA: 0x17F838C
	private string[] get_AllYearMonthPatterns() { }

	// RVA: 0x17F81BC Offset: 0x17F41BC VA: 0x17F81BC
	private string[] get_AllShortDatePatterns() { }

	// RVA: 0x17F82A4 Offset: 0x17F42A4 VA: 0x17F82A4
	private string[] get_AllShortTimePatterns() { }

	// RVA: 0x17F8230 Offset: 0x17F4230 VA: 0x17F8230
	private string[] get_AllLongDatePatterns() { }

	// RVA: 0x17F8318 Offset: 0x17F4318 VA: 0x17F8318
	private string[] get_AllLongTimePatterns() { }

	// RVA: 0x17F7638 Offset: 0x17F3638 VA: 0x17F7638
	private string[] get_UnclonedYearMonthPatterns() { }

	// RVA: 0x17F7184 Offset: 0x17F3184 VA: 0x17F7184
	private string[] get_UnclonedShortDatePatterns() { }

	// RVA: 0x17F6FAC Offset: 0x17F2FAC VA: 0x17F6FAC
	private string[] get_UnclonedLongDatePatterns() { }

	// RVA: 0x17F7234 Offset: 0x17F3234 VA: 0x17F7234
	private string[] get_UnclonedShortTimePatterns() { }

	// RVA: 0x17F7010 Offset: 0x17F3010 VA: 0x17F7010
	private string[] get_UnclonedLongTimePatterns() { }

	// RVA: 0x17F6A28 Offset: 0x17F2A28 VA: 0x17F6A28
	public bool get_IsReadOnly() { }

	// RVA: 0x17F88A8 Offset: 0x17F48A8 VA: 0x17F88A8
	public string[] get_MonthGenitiveNames() { }

	// RVA: 0x17F8928 Offset: 0x17F4928 VA: 0x17F8928
	internal string get_FullTimeSpanPositivePattern() { }

	// RVA: 0x17F8A04 Offset: 0x17F4A04 VA: 0x17F8A04
	internal string get_FullTimeSpanNegativePattern() { }

	// RVA: 0x17F8A7C Offset: 0x17F4A7C VA: 0x17F8A7C
	internal CompareInfo get_CompareInfo() { }

	// RVA: 0x17F8B10 Offset: 0x17F4B10 VA: 0x17F8B10
	internal static void ValidateStyles(DateTimeStyles style, string parameterName) { }

	// RVA: 0x17F78DC Offset: 0x17F38DC VA: 0x17F78DC
	internal DateTimeFormatFlags get_FormatFlags() { }

	// RVA: 0x17F8BE0 Offset: 0x17F4BE0 VA: 0x17F8BE0
	private DateTimeFormatFlags InitializeFormatFlags() { }

	// RVA: 0x17F8E44 Offset: 0x17F4E44 VA: 0x17F8E44
	internal bool get_HasForceTwoDigitYears() { }

	// RVA: 0x17F8E78 Offset: 0x17F4E78 VA: 0x17F8E78
	internal bool get_HasYearMonthAdjustment() { }

	// RVA: 0x17F8EA0 Offset: 0x17F4EA0 VA: 0x17F8EA0
	internal bool YearMonthAdjustment(ref int year, ref int month, bool parsedMonthName) { }

	// RVA: 0x17F8FD4 Offset: 0x17F4FD4 VA: 0x17F8FD4
	internal static DateTimeFormatInfo GetJapaneseCalendarDTFI() { }

	// RVA: 0x17F9170 Offset: 0x17F5170 VA: 0x17F9170
	internal static DateTimeFormatInfo GetTaiwanCalendarDTFI() { }

	// RVA: 0x17F6B0C Offset: 0x17F2B0C VA: 0x17F6B0C
	private void ClearTokenHashTable() { }

	// RVA: 0x17F930C Offset: 0x17F530C VA: 0x17F930C
	internal DateTimeFormatInfo.TokenHashValue[] CreateTokenHashTable() { }

	// RVA: 0x17F9E9C Offset: 0x17F5E9C VA: 0x17F9E9C
	private void PopulateSpecialTokenHashTable(DateTimeFormatInfo.TokenHashValue[] temp, ref bool useDateSepAsIgnorableSymbol) { }

	// RVA: 0x17FAB3C Offset: 0x17F6B3C VA: 0x17FAB3C
	private static bool IsJapaneseCalendar(Calendar calendar) { }

	// RVA: 0x17FA764 Offset: 0x17F6764 VA: 0x17FA764
	private void AddMonthNames(DateTimeFormatInfo.TokenHashValue[] temp, string monthPostfix) { }

	// RVA: 0x17FAC64 Offset: 0x17F6C64 VA: 0x17FAC64
	private static bool TryParseHebrewNumber(ref __DTString str, out bool badFormat, out int number) { }

	// RVA: 0x17FADC8 Offset: 0x17F6DC8 VA: 0x17FADC8
	private static bool IsHebrewChar(char ch) { }

	// RVA: 0x17FADDC Offset: 0x17F6DDC VA: 0x17FADDC
	private bool IsAllowedJapaneseTokenFollowedByNonSpaceLetter(string tokenString, char nextCh) { }

	// RVA: 0x17FAEE4 Offset: 0x17F6EE4 VA: 0x17FAEE4
	internal bool Tokenize(TokenType TokenMask, out TokenType tokenType, out int tokenValue, ref __DTString str) { }

	// RVA: 0x17FB464 Offset: 0x17F7464 VA: 0x17FB464
	private void InsertAtCurrentHashNode(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, char ch, TokenType tokenType, int tokenValue, int pos, int hashcode, int hashProbe) { }

	// RVA: 0x17F9B84 Offset: 0x17F5B84 VA: 0x17F9B84
	private void InsertHash(DateTimeFormatInfo.TokenHashValue[] hashTable, string str, TokenType tokenType, int tokenValue) { }

	// RVA: 0x17FB6AC Offset: 0x17F76AC VA: 0x17FB6AC
	private bool CompareStringIgnoreCaseOptimized(string string1, int offset1, int length1, string string2, int offset2, int length2) { }

	// RVA: 0x17FB7A0 Offset: 0x17F77A0 VA: 0x17FB7A0
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal enum FORMATFLAGS // TypeDefIndex: 1302
{
	// Fields
	public int value__; // 0x0
	public const FORMATFLAGS None = 0;
	public const FORMATFLAGS UseGenitiveMonth = 1;
	public const FORMATFLAGS UseLeapYearMonth = 2;
	public const FORMATFLAGS UseSpacesInMonthNames = 4;
	public const FORMATFLAGS UseHebrewParsing = 8;
	public const FORMATFLAGS UseSpacesInDayNames = 16;
	public const FORMATFLAGS UseDigitPrefixInTokens = 32;
}

// Namespace: System.Globalization
internal enum CalendarId // TypeDefIndex: 1303
{
	// Fields
	public ushort value__; // 0x0
	public const CalendarId UNINITIALIZED_VALUE = 0;
	public const CalendarId GREGORIAN = 1;
	public const CalendarId GREGORIAN_US = 2;
	public const CalendarId JAPAN = 3;
	public const CalendarId TAIWAN = 4;
	public const CalendarId KOREA = 5;
	public const CalendarId HIJRI = 6;
	public const CalendarId THAI = 7;
	public const CalendarId HEBREW = 8;
	public const CalendarId GREGORIAN_ME_FRENCH = 9;
	public const CalendarId GREGORIAN_ARABIC = 10;
	public const CalendarId GREGORIAN_XLIT_ENGLISH = 11;
	public const CalendarId GREGORIAN_XLIT_FRENCH = 12;
	public const CalendarId JULIAN = 13;
	public const CalendarId JAPANESELUNISOLAR = 14;
	public const CalendarId CHINESELUNISOLAR = 15;
	public const CalendarId SAKA = 16;
	public const CalendarId LUNAR_ETO_CHN = 17;
	public const CalendarId LUNAR_ETO_KOR = 18;
	public const CalendarId LUNAR_ETO_ROKUYOU = 19;
	public const CalendarId KOREANLUNISOLAR = 20;
	public const CalendarId TAIWANLUNISOLAR = 21;
	public const CalendarId PERSIAN = 22;
	public const CalendarId UMALQURA = 23;
	public const CalendarId LAST_CALENDAR = 23;
}

// Namespace: 
private enum DateTimeFormatInfoScanner.FoundDatePattern // TypeDefIndex: 1304
{
	// Fields
	public int value__; // 0x0
	public const DateTimeFormatInfoScanner.FoundDatePattern None = 0;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundYearPatternFlag = 1;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundMonthPatternFlag = 2;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundDayPatternFlag = 4;
	public const DateTimeFormatInfoScanner.FoundDatePattern FoundYMDPatternFlag = 7;
}

// Namespace: System.Globalization
internal class DateTimeFormatInfoScanner // TypeDefIndex: 1305
{
	// Fields
	internal List<string> m_dateWords; // 0x10
	private static Dictionary<string, string> s_knownWords; // 0x0
	private DateTimeFormatInfoScanner.FoundDatePattern _ymdFlags; // 0x18

	// Properties
	private static Dictionary<string, string> KnownWords { get; }

	// Methods

	// RVA: 0x17FB838 Offset: 0x17F7838 VA: 0x17FB838
	private static Dictionary<string, string> get_KnownWords() { }

	// RVA: 0x17FBC24 Offset: 0x17F7C24 VA: 0x17FBC24
	internal static int SkipWhiteSpacesAndNonLetter(string pattern, int currentIndex) { }

	// RVA: 0x17FBD00 Offset: 0x17F7D00 VA: 0x17FBD00
	internal void AddDateWordOrPostfix(string formatPostfix, string str) { }

	// RVA: 0x17FC0BC Offset: 0x17F80BC VA: 0x17FC0BC
	internal int AddDateWords(string pattern, int index, string formatPostfix) { }

	// RVA: 0x17FC294 Offset: 0x17F8294 VA: 0x17FC294
	internal static int ScanRepeatChar(string pattern, char ch, int index, out int count) { }

	// RVA: 0x17FBF48 Offset: 0x17F7F48 VA: 0x17FBF48
	internal void AddIgnorableSymbols(string text) { }

	// RVA: 0x17FC318 Offset: 0x17F8318 VA: 0x17FC318
	internal void ScanDateWord(string pattern) { }

	// RVA: 0x17FA898 Offset: 0x17F6898 VA: 0x17FA898
	internal string[] GetDateWordsOfDTFI(DateTimeFormatInfo dtfi) { }

	// RVA: 0x17F8D1C Offset: 0x17F4D1C VA: 0x17F8D1C
	internal static FORMATFLAGS GetFormatFlagGenitiveMonth(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x17F8D5C Offset: 0x17F4D5C VA: 0x17F8D5C
	internal static FORMATFLAGS GetFormatFlagUseSpaceInMonthNames(string[] monthNames, string[] genitveMonthNames, string[] abbrevMonthNames, string[] genetiveAbbrevMonthNames) { }

	// RVA: 0x17F8E04 Offset: 0x17F4E04 VA: 0x17F8E04
	internal static FORMATFLAGS GetFormatFlagUseSpaceInDayNames(string[] dayNames, string[] abbrevDayNames) { }

	// RVA: 0x17F8E34 Offset: 0x17F4E34 VA: 0x17F8E34
	internal static FORMATFLAGS GetFormatFlagUseHebrewCalendar(int calID) { }

	// RVA: 0x17FC548 Offset: 0x17F8548 VA: 0x17FC548
	private static bool EqualStringArrays(string[] array1, string[] array2) { }

	// RVA: 0x17FC848 Offset: 0x17F8848 VA: 0x17FC848
	private static bool ArrayElementsHaveSpace(string[] array) { }

	// RVA: 0x17FC5F8 Offset: 0x17F85F8 VA: 0x17FC5F8
	private static bool ArrayElementsBeginWithDigit(string[] array) { }

	// RVA: 0x17FA810 Offset: 0x17F6810 VA: 0x17FA810
	public void .ctor() { }
}

// Namespace: System.Globalization
[Flags]
public enum DateTimeStyles // TypeDefIndex: 1306
{
	// Fields
	public int value__; // 0x0
	public const DateTimeStyles None = 0;
	public const DateTimeStyles AllowLeadingWhite = 1;
	public const DateTimeStyles AllowTrailingWhite = 2;
	public const DateTimeStyles AllowInnerWhite = 4;
	public const DateTimeStyles AllowWhiteSpaces = 7;
	public const DateTimeStyles NoCurrentDateDefault = 8;
	public const DateTimeStyles AdjustToUniversal = 16;
	public const DateTimeStyles AssumeLocal = 32;
	public const DateTimeStyles AssumeUniversal = 64;
	public const DateTimeStyles RoundtripKind = 128;
}

// Namespace: System.Globalization
[IsReadOnly]
internal struct DaylightTimeStruct // TypeDefIndex: 1307
{
	// Fields
	public readonly DateTime Start; // 0x0
	public readonly DateTime End; // 0x8
	public readonly TimeSpan Delta; // 0x10

	// Methods

	// RVA: 0x17FCAC4 Offset: 0x17F8AC4 VA: 0x17FCAC4
	public void .ctor(DateTime start, DateTime end, TimeSpan delta) { }
}

// Namespace: System.Globalization
internal struct HebrewNumberParsingContext // TypeDefIndex: 1308
{
	// Fields
	internal HebrewNumber.HS state; // 0x0
	internal int result; // 0x4

	// Methods

	// RVA: 0x17FCAD0 Offset: 0x17F8AD0 VA: 0x17FCAD0
	public void .ctor(int result) { }
}

// Namespace: System.Globalization
internal enum HebrewNumberParsingState // TypeDefIndex: 1309
{
	// Fields
	public int value__; // 0x0
	public const HebrewNumberParsingState InvalidHebrewNumber = 0;
	public const HebrewNumberParsingState NotHebrewDigit = 1;
	public const HebrewNumberParsingState FoundEndOfHebrewNumber = 2;
	public const HebrewNumberParsingState ContinueParsing = 3;
}

// Namespace: 
private enum HebrewNumber.HebrewToken // TypeDefIndex: 1310
{
	// Fields
	public short value__; // 0x0
	public const HebrewNumber.HebrewToken Invalid = -1;
	public const HebrewNumber.HebrewToken Digit400 = 0;
	public const HebrewNumber.HebrewToken Digit200_300 = 1;
	public const HebrewNumber.HebrewToken Digit100 = 2;
	public const HebrewNumber.HebrewToken Digit10 = 3;
	public const HebrewNumber.HebrewToken Digit1 = 4;
	public const HebrewNumber.HebrewToken Digit6_7 = 5;
	public const HebrewNumber.HebrewToken Digit7 = 6;
	public const HebrewNumber.HebrewToken Digit9 = 7;
	public const HebrewNumber.HebrewToken SingleQuote = 8;
	public const HebrewNumber.HebrewToken DoubleQuote = 9;
}

// Namespace: 
private struct HebrewNumber.HebrewValue // TypeDefIndex: 1311
{
	// Fields
	internal HebrewNumber.HebrewToken token; // 0x0
	internal short value; // 0x2

	// Methods

	// RVA: 0x17FD2B0 Offset: 0x17F92B0 VA: 0x17FD2B0
	internal void .ctor(HebrewNumber.HebrewToken token, short value) { }
}

// Namespace: 
internal enum HebrewNumber.HS // TypeDefIndex: 1312
{
	// Fields
	public sbyte value__; // 0x0
	public const HebrewNumber.HS _err = -1;
	public const HebrewNumber.HS Start = 0;
	public const HebrewNumber.HS S400 = 1;
	public const HebrewNumber.HS S400_400 = 2;
	public const HebrewNumber.HS S400_X00 = 3;
	public const HebrewNumber.HS S400_X0 = 4;
	public const HebrewNumber.HS X00_DQ = 5;
	public const HebrewNumber.HS S400_X00_X0 = 6;
	public const HebrewNumber.HS X0_DQ = 7;
	public const HebrewNumber.HS X = 8;
	public const HebrewNumber.HS X0 = 9;
	public const HebrewNumber.HS X00 = 10;
	public const HebrewNumber.HS S400_DQ = 11;
	public const HebrewNumber.HS S400_400_DQ = 12;
	public const HebrewNumber.HS S400_400_100 = 13;
	public const HebrewNumber.HS S9 = 14;
	public const HebrewNumber.HS X00_S9 = 15;
	public const HebrewNumber.HS S9_DQ = 16;
	public const HebrewNumber.HS END = 100;
}

// Namespace: System.Globalization
internal class HebrewNumber // TypeDefIndex: 1313
{
	// Fields
	private static readonly HebrewNumber.HebrewValue[] s_hebrewValues; // 0x0
	private static char s_maxHebrewNumberCh; // 0x8
	private static readonly HebrewNumber.HS[] s_numberPasingState; // 0x10

	// Methods

	// RVA: 0x17FCADC Offset: 0x17F8ADC VA: 0x17FCADC
	internal static string ToString(int Number) { }

	// RVA: 0x17FCD88 Offset: 0x17F8D88 VA: 0x17FCD88
	internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context) { }

	// RVA: 0x17FCF20 Offset: 0x17F8F20 VA: 0x17FCF20
	internal static bool IsDigit(char ch) { }

	// RVA: 0x17FCFEC Offset: 0x17F8FEC VA: 0x17FCFEC
	private static void .cctor() { }
}

// Namespace: System.Globalization
[Flags]
public enum NumberStyles // TypeDefIndex: 1314
{
	// Fields
	public int value__; // 0x0
	public const NumberStyles None = 0;
	public const NumberStyles AllowLeadingWhite = 1;
	public const NumberStyles AllowTrailingWhite = 2;
	public const NumberStyles AllowLeadingSign = 4;
	public const NumberStyles AllowTrailingSign = 8;
	public const NumberStyles AllowParentheses = 16;
	public const NumberStyles AllowDecimalPoint = 32;
	public const NumberStyles AllowThousands = 64;
	public const NumberStyles AllowExponent = 128;
	public const NumberStyles AllowCurrencySymbol = 256;
	public const NumberStyles AllowHexSpecifier = 512;
	public const NumberStyles Integer = 7;
	public const NumberStyles HexNumber = 515;
	public const NumberStyles Number = 111;
	public const NumberStyles Float = 167;
	public const NumberStyles Currency = 383;
	public const NumberStyles Any = 511;
}

// Namespace: System.Globalization
[Serializable]
public sealed class SortVersion // TypeDefIndex: 1315
{}

// Namespace: 
internal enum TimeSpanFormat.Pattern // TypeDefIndex: 1316
{
	// Fields
	public int value__; // 0x0
	public const TimeSpanFormat.Pattern None = 0;
	public const TimeSpanFormat.Pattern Minimum = 1;
	public const TimeSpanFormat.Pattern Full = 2;
}

// Namespace: 
internal struct TimeSpanFormat.FormatLiterals // TypeDefIndex: 1317
{
	// Fields
	internal string AppCompatLiteral; // 0x0
	internal int dd; // 0x8
	internal int hh; // 0xC
	internal int mm; // 0x10
	internal int ss; // 0x14
	internal int ff; // 0x18
	private string[] _literals; // 0x20

	// Properties
	internal string Start { get; }
	internal string DayHourSep { get; }
	internal string HourMinuteSep { get; }
	internal string MinuteSecondSep { get; }
	internal string SecondFractionSep { get; }
	internal string End { get; }

	// Methods

	// RVA: 0x17FE85C Offset: 0x17FA85C VA: 0x17FE85C
	internal string get_Start() { }

	// RVA: 0x17FE884 Offset: 0x17FA884 VA: 0x17FE884
	internal string get_DayHourSep() { }

	// RVA: 0x17FE8B0 Offset: 0x17FA8B0 VA: 0x17FE8B0
	internal string get_HourMinuteSep() { }

	// RVA: 0x17FE8DC Offset: 0x17FA8DC VA: 0x17FE8DC
	internal string get_MinuteSecondSep() { }

	// RVA: 0x17FE908 Offset: 0x17FA908 VA: 0x17FE908
	internal string get_SecondFractionSep() { }

	// RVA: 0x17FE934 Offset: 0x17FA934 VA: 0x17FE934
	internal string get_End() { }

	// RVA: 0x17FEA10 Offset: 0x17FAA10 VA: 0x17FEA10
	internal static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative) { }

	// RVA: 0x17FE434 Offset: 0x17FA434 VA: 0x17FE434
	internal void Init(ReadOnlySpan<char> format, bool useInvariantFieldLengths) { }
}

// Namespace: System.Globalization
internal static class TimeSpanFormat // TypeDefIndex: 1318
{
	// Fields
	internal static readonly TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals; // 0x0
	internal static readonly TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals; // 0x28

	// Methods

	// RVA: 0x17FD2BC Offset: 0x17F92BC VA: 0x17FD2BC
	private static void AppendNonNegativeInt32(StringBuilder sb, int n, int digits) { }

	// RVA: 0x17FD3C0 Offset: 0x17F93C0 VA: 0x17FD3C0
	internal static string Format(TimeSpan value, string format, IFormatProvider formatProvider) { }

	// RVA: 0x17FD76C Offset: 0x17F976C VA: 0x17FD76C
	internal static bool TryFormat(TimeSpan value, Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider formatProvider) { }

	// RVA: 0x17FD478 Offset: 0x17F9478 VA: 0x17FD478
	private static StringBuilder FormatToBuilder(TimeSpan value, ReadOnlySpan<char> format, IFormatProvider formatProvider) { }

	// RVA: 0x17FD88C Offset: 0x17F988C VA: 0x17FD88C
	private static StringBuilder FormatStandard(TimeSpan value, bool isInvariant, ReadOnlySpan<char> format, TimeSpanFormat.Pattern pattern) { }

	// RVA: 0x17FDD68 Offset: 0x17F9D68 VA: 0x17FDD68
	private static StringBuilder FormatCustomized(TimeSpan value, ReadOnlySpan<char> format, DateTimeFormatInfo dtfi, StringBuilder result) { }

	// RVA: 0x17FE960 Offset: 0x17FA960 VA: 0x17FE960
	private static void .cctor() { }
}

// Namespace: 
private enum TimeSpanParse.ParseFailureKind // TypeDefIndex: 1319
{
	// Fields
	public byte value__; // 0x0
	public const TimeSpanParse.ParseFailureKind None = 0;
	public const TimeSpanParse.ParseFailureKind ArgumentNull = 1;
	public const TimeSpanParse.ParseFailureKind Format = 2;
	public const TimeSpanParse.ParseFailureKind FormatWithParameter = 3;
	public const TimeSpanParse.ParseFailureKind Overflow = 4;
}

// Namespace: 
[Flags]
private enum TimeSpanParse.TimeSpanStandardStyles // TypeDefIndex: 1320
{
	// Fields
	public byte value__; // 0x0
	public const TimeSpanParse.TimeSpanStandardStyles None = 0;
	public const TimeSpanParse.TimeSpanStandardStyles Invariant = 1;
	public const TimeSpanParse.TimeSpanStandardStyles Localized = 2;
	public const TimeSpanParse.TimeSpanStandardStyles RequireFull = 4;
	public const TimeSpanParse.TimeSpanStandardStyles Any = 3;
}

// Namespace: 
private enum TimeSpanParse.TTT // TypeDefIndex: 1321
{
	// Fields
	public byte value__; // 0x0
	public const TimeSpanParse.TTT None = 0;
	public const TimeSpanParse.TTT End = 1;
	public const TimeSpanParse.TTT Num = 2;
	public const TimeSpanParse.TTT Sep = 3;
	public const TimeSpanParse.TTT NumOverflow = 4;
}

// Namespace: 
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
private struct TimeSpanParse.TimeSpanToken // TypeDefIndex: 1322
{
	// Fields
	internal TimeSpanParse.TTT _ttt; // 0x0
	internal int _num; // 0x4
	internal int _zeroes; // 0x8
	internal ReadOnlySpan<char> _sep; // 0x10

	// Methods

	// RVA: 0x1803D64 Offset: 0x17FFD64 VA: 0x1803D64
	public void .ctor(TimeSpanParse.TTT type) { }

	// RVA: 0x1801B70 Offset: 0x17FDB70 VA: 0x1801B70
	public void .ctor(int number) { }

	// RVA: 0x1803B5C Offset: 0x17FFB5C VA: 0x1803B5C
	public void .ctor(int number, int leadingZeroes) { }

	// RVA: 0x1803D74 Offset: 0x17FFD74 VA: 0x1803D74
	public void .ctor(TimeSpanParse.TTT type, int number, int leadingZeroes, ReadOnlySpan<char> separator) { }

	// RVA: 0x17FED44 Offset: 0x17FAD44 VA: 0x17FED44
	public bool IsInvalidFraction() { }
}

// Namespace: 
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[IsByRefLike]
private struct TimeSpanParse.TimeSpanTokenizer // TypeDefIndex: 1323
{
	// Fields
	private ReadOnlySpan<char> _value; // 0x0
	private int _pos; // 0x10

	// Properties
	internal bool EOL { get; }
	internal char NextChar { get; }

	// Methods

	// RVA: 0x17FF24C Offset: 0x17FB24C VA: 0x17FF24C
	internal void .ctor(ReadOnlySpan<char> input) { }

	// RVA: 0x1803924 Offset: 0x17FF924 VA: 0x1803924
	internal void .ctor(ReadOnlySpan<char> input, int startPosition) { }

	// RVA: 0x17FF2AC Offset: 0x17FB2AC VA: 0x17FF2AC
	internal TimeSpanParse.TimeSpanToken GetNextToken() { }

	// RVA: 0x1803B10 Offset: 0x17FFB10 VA: 0x1803B10
	internal bool get_EOL() { }

	// RVA: 0x1803B70 Offset: 0x17FFB70 VA: 0x1803B70
	internal void BackOne() { }

	// RVA: 0x1803AB0 Offset: 0x17FFAB0 VA: 0x1803AB0
	internal char get_NextChar() { }
}

// Namespace: 
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
private struct TimeSpanParse.TimeSpanRawInfo // TypeDefIndex: 1324
{
	// Fields
	internal TimeSpanParse.TTT _lastSeenTTT; // 0x0
	internal int _tokenCount; // 0x4
	internal int _sepCount; // 0x8
	internal int _numCount; // 0xC
	private TimeSpanFormat.FormatLiterals _posLoc; // 0x10
	private TimeSpanFormat.FormatLiterals _negLoc; // 0x38
	private bool _posLocInit; // 0x60
	private bool _negLocInit; // 0x61
	private string _fullPosPattern; // 0x68
	private string _fullNegPattern; // 0x70
	internal TimeSpanParse.TimeSpanToken _numbers0; // 0x78
	internal TimeSpanParse.TimeSpanToken _numbers1; // 0x98
	internal TimeSpanParse.TimeSpanToken _numbers2; // 0xB8
	internal TimeSpanParse.TimeSpanToken _numbers3; // 0xD8
	internal TimeSpanParse.TimeSpanToken _numbers4; // 0xF8
	internal ReadOnlySpan<char> _literals0; // 0x118
	internal ReadOnlySpan<char> _literals1; // 0x128
	internal ReadOnlySpan<char> _literals2; // 0x138
	internal ReadOnlySpan<char> _literals3; // 0x148
	internal ReadOnlySpan<char> _literals4; // 0x158
	internal ReadOnlySpan<char> _literals5; // 0x168

	// Properties
	internal TimeSpanFormat.FormatLiterals PositiveInvariant { get; }
	internal TimeSpanFormat.FormatLiterals NegativeInvariant { get; }
	internal TimeSpanFormat.FormatLiterals PositiveLocalized { get; }
	internal TimeSpanFormat.FormatLiterals NegativeLocalized { get; }

	// Methods

	// RVA: 0x1803D84 Offset: 0x17FFD84 VA: 0x1803D84
	internal TimeSpanFormat.FormatLiterals get_PositiveInvariant() { }

	// RVA: 0x1803DEC Offset: 0x17FFDEC VA: 0x1803DEC
	internal TimeSpanFormat.FormatLiterals get_NegativeInvariant() { }

	// RVA: 0x1801A0C Offset: 0x17FDA0C VA: 0x1801A0C
	internal TimeSpanFormat.FormatLiterals get_PositiveLocalized() { }

	// RVA: 0x1801ABC Offset: 0x17FDABC VA: 0x1801ABC
	internal TimeSpanFormat.FormatLiterals get_NegativeLocalized() { }

	// RVA: 0x18021DC Offset: 0x17FE1DC VA: 0x18021DC
	internal bool FullAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1802B08 Offset: 0x17FEB08 VA: 0x1802B08
	internal bool PartialAppCompatMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x18016B0 Offset: 0x17FD6B0 VA: 0x18016B0
	internal bool FullMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1803064 Offset: 0x17FF064 VA: 0x1803064
	internal bool FullDMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1802E04 Offset: 0x17FEE04 VA: 0x1802E04
	internal bool FullHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1802804 Offset: 0x17FE804 VA: 0x1802804
	internal bool FullDHMMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1802500 Offset: 0x17FE500 VA: 0x1802500
	internal bool FullHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1801EB0 Offset: 0x17FDEB0 VA: 0x1801EB0
	internal bool FullDHMSMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x1801B84 Offset: 0x17FDB84 VA: 0x1801B84
	internal bool FullHMSFMatch(TimeSpanFormat.FormatLiterals pattern) { }

	// RVA: 0x17FF258 Offset: 0x17FB258 VA: 0x17FF258
	internal void Init(DateTimeFormatInfo dtfi) { }

	// RVA: 0x17FF528 Offset: 0x17FB528 VA: 0x17FF528
	internal bool ProcessToken(ref TimeSpanParse.TimeSpanToken tok, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1803E58 Offset: 0x17FFE58 VA: 0x1803E58
	private bool AddSep(ReadOnlySpan<char> sep, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1803F6C Offset: 0x17FFF6C VA: 0x1803F6C
	private bool AddNum(TimeSpanParse.TimeSpanToken num, ref TimeSpanParse.TimeSpanResult result) { }
}

// Namespace: 
private struct TimeSpanParse.TimeSpanResult // TypeDefIndex: 1325
{
	// Fields
	internal TimeSpan parsedTimeSpan; // 0x0
	private readonly bool _throwOnFailure; // 0x8

	// Methods

	// RVA: 0x17FEDD4 Offset: 0x17FADD4 VA: 0x17FEDD4
	internal void .ctor(bool throwOnFailure) { }

	// RVA: 0x17FF124 Offset: 0x17FB124 VA: 0x17FF124
	internal bool SetFailure(TimeSpanParse.ParseFailureKind kind, string resourceKey, object messageArgument, string argumentName) { }
}

// Namespace: 
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
private struct TimeSpanParse.StringParser // TypeDefIndex: 1326
{
	// Fields
	private ReadOnlySpan<char> _str; // 0x0
	private char _ch; // 0x10
	private int _pos; // 0x14
	private int _len; // 0x18

	// Methods

	// RVA: 0x1804058 Offset: 0x1800058 VA: 0x1804058
	internal void NextChar() { }

	// RVA: 0x18040A0 Offset: 0x18000A0 VA: 0x18040A0
	internal char NextNonDigit() { }

	// RVA: 0x1803B84 Offset: 0x17FFB84 VA: 0x1803B84
	internal bool TryParse(ReadOnlySpan<char> input, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x18042E8 Offset: 0x18002E8 VA: 0x18042E8
	internal bool ParseInt(int max, out int i, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1804130 Offset: 0x1800130 VA: 0x1804130
	internal bool ParseTime(out long time, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1804100 Offset: 0x1800100 VA: 0x1804100
	internal void SkipBlanks() { }
}

// Namespace: System.Globalization
internal static class TimeSpanParse // TypeDefIndex: 1327
{
	// Methods

	// RVA: 0x17FE7CC Offset: 0x17FA7CC VA: 0x17FE7CC
	internal static long Pow10(int pow) { }

	// RVA: 0x17FEBF4 Offset: 0x17FABF4 VA: 0x17FEBF4
	private static bool TryTimeToTicks(bool positive, TimeSpanParse.TimeSpanToken days, TimeSpanParse.TimeSpanToken hours, TimeSpanParse.TimeSpanToken minutes, TimeSpanParse.TimeSpanToken seconds, TimeSpanParse.TimeSpanToken fraction, out long result) { }

	// RVA: 0x17FEDA0 Offset: 0x17FADA0 VA: 0x17FEDA0
	internal static TimeSpan Parse(ReadOnlySpan<char> input, IFormatProvider formatProvider) { }

	// RVA: 0x17FEF6C Offset: 0x17FAF6C VA: 0x17FEF6C
	internal static bool TryParseExact(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, out TimeSpan result) { }

	// RVA: 0x17FEDE0 Offset: 0x17FADE0 VA: 0x17FEDE0
	private static bool TryParseTimeSpan(ReadOnlySpan<char> input, TimeSpanParse.TimeSpanStandardStyles style, IFormatProvider formatProvider, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x17FF63C Offset: 0x17FB63C VA: 0x17FF63C
	private static bool ProcessTerminalState(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1801454 Offset: 0x17FD454 VA: 0x1801454
	private static bool ProcessTerminal_DHMSF(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x180090C Offset: 0x17FC90C VA: 0x180090C
	private static bool ProcessTerminal_HMS_F_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x17FFD40 Offset: 0x17FBD40 VA: 0x17FFD40
	private static bool ProcessTerminal_HM_S_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x17FFA80 Offset: 0x17FBA80 VA: 0x17FFA80
	private static bool ProcessTerminal_HM(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x17FF7B8 Offset: 0x17FB7B8 VA: 0x17FF7B8
	private static bool ProcessTerminal_D(ref TimeSpanParse.TimeSpanRawInfo raw, TimeSpanParse.TimeSpanStandardStyles style, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x17FEFA8 Offset: 0x17FAFA8 VA: 0x17FEFA8
	private static bool TryParseExactTimeSpan(ReadOnlySpan<char> input, ReadOnlySpan<char> format, IFormatProvider formatProvider, TimeSpanStyles styles, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1803254 Offset: 0x17FF254 VA: 0x1803254
	private static bool TryParseByFormat(ReadOnlySpan<char> input, ReadOnlySpan<char> format, TimeSpanStyles styles, ref TimeSpanParse.TimeSpanResult result) { }

	// RVA: 0x1803930 Offset: 0x17FF930 VA: 0x1803930
	private static bool ParseExactDigits(ref TimeSpanParse.TimeSpanTokenizer tokenizer, int minDigitLength, out int result) { }

	// RVA: 0x1803960 Offset: 0x17FF960 VA: 0x1803960
	private static bool ParseExactDigits(ref TimeSpanParse.TimeSpanTokenizer tokenizer, int minDigitLength, int maxDigitLength, out int zeroes, out int result) { }

	// RVA: 0x1803A24 Offset: 0x17FFA24 VA: 0x1803A24
	private static bool ParseExactLiteral(ref TimeSpanParse.TimeSpanTokenizer tokenizer, StringBuilder enquotedString) { }

	// RVA: 0x1803220 Offset: 0x17FF220 VA: 0x1803220
	private static bool TryParseTimeSpanConstant(ReadOnlySpan<char> input, ref TimeSpanParse.TimeSpanResult result) { }
}

// Namespace: System.Globalization
[Flags]
public enum TimeSpanStyles // TypeDefIndex: 1328
{
	// Fields
	public int value__; // 0x0
	public const TimeSpanStyles None = 0;
	public const TimeSpanStyles AssumeNegative = 1;
}

// Namespace: System.Globalization
public enum UnicodeCategory // TypeDefIndex: 1329
{
	// Fields
	public int value__; // 0x0
	public const UnicodeCategory UppercaseLetter = 0;
	public const UnicodeCategory LowercaseLetter = 1;
	public const UnicodeCategory TitlecaseLetter = 2;
	public const UnicodeCategory ModifierLetter = 3;
	public const UnicodeCategory OtherLetter = 4;
	public const UnicodeCategory NonSpacingMark = 5;
	public const UnicodeCategory SpacingCombiningMark = 6;
	public const UnicodeCategory EnclosingMark = 7;
	public const UnicodeCategory DecimalDigitNumber = 8;
	public const UnicodeCategory LetterNumber = 9;
	public const UnicodeCategory OtherNumber = 10;
	public const UnicodeCategory SpaceSeparator = 11;
	public const UnicodeCategory LineSeparator = 12;
	public const UnicodeCategory ParagraphSeparator = 13;
	public const UnicodeCategory Control = 14;
	public const UnicodeCategory Format = 15;
	public const UnicodeCategory Surrogate = 16;
	public const UnicodeCategory PrivateUse = 17;
	public const UnicodeCategory ConnectorPunctuation = 18;
	public const UnicodeCategory DashPunctuation = 19;
	public const UnicodeCategory OpenPunctuation = 20;
	public const UnicodeCategory ClosePunctuation = 21;
	public const UnicodeCategory InitialQuotePunctuation = 22;
	public const UnicodeCategory FinalQuotePunctuation = 23;
	public const UnicodeCategory OtherPunctuation = 24;
	public const UnicodeCategory MathSymbol = 25;
	public const UnicodeCategory CurrencySymbol = 26;
	public const UnicodeCategory ModifierSymbol = 27;
	public const UnicodeCategory OtherSymbol = 28;
	public const UnicodeCategory OtherNotAssigned = 29;
}

// Namespace: System.Globalization
internal static class GlobalizationMode // TypeDefIndex: 1330
{
	// Fields
	[CompilerGenerated]
	private static readonly bool <Invariant>k__BackingField; // 0x0

	// Properties
	internal static bool Invariant { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18043F4 Offset: 0x18003F4 VA: 0x18043F4
	internal static bool get_Invariant() { }

	// RVA: 0x180444C Offset: 0x180044C VA: 0x180444C
	private static bool GetGlobalizationInvariantMode() { }

	// RVA: 0x1804454 Offset: 0x1800454 VA: 0x1804454
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public abstract class Calendar : ICloneable // TypeDefIndex: 1331
{
	// Fields
	internal int m_currentEraValue; // 0x10
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; // 0x14
	internal int twoDigitYearMax; // 0x18

	// Properties
	[ComVisible(False)]
	public virtual DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public virtual DateTime MaxSupportedDateTime { get; }
	internal virtual int ID { get; }
	internal virtual int BaseCalendarID { get; }
	internal virtual int CurrentEraValue { get; }
	public abstract int[] Eras { get; }
	public virtual int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x180449C Offset: 0x180049C VA: 0x180449C Slot: 5
	public virtual DateTime get_MinSupportedDateTime() { }

	// RVA: 0x18044F4 Offset: 0x18004F4 VA: 0x18044F4 Slot: 6
	public virtual DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x180454C Offset: 0x180054C VA: 0x180454C
	protected void .ctor() { }

	// RVA: 0x1804560 Offset: 0x1800560 VA: 0x1804560 Slot: 7
	internal virtual int get_ID() { }

	// RVA: 0x1804568 Offset: 0x1800568 VA: 0x1804568 Slot: 8
	internal virtual int get_BaseCalendarID() { }

	[ComVisible(False)]
	// RVA: 0x1804574 Offset: 0x1800574 VA: 0x1804574 Slot: 9
	public virtual object Clone() { }

	// RVA: 0x18045FC Offset: 0x18005FC VA: 0x18045FC
	internal void VerifyWritable() { }

	// RVA: 0x1804660 Offset: 0x1800660 VA: 0x1804660
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x1804668 Offset: 0x1800668 VA: 0x1804668 Slot: 10
	internal virtual int get_CurrentEraValue() { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int GetDayOfMonth(DateTime time);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract DayOfWeek GetDayOfWeek(DateTime time);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract int GetDaysInMonth(int year, int month, int era);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract int GetDaysInYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract int GetEra(DateTime time);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract int[] get_Eras();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract int GetMonth(DateTime time);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract int GetMonthsInYear(int year, int era);

	// RVA: -1 Offset: -1 Slot: 19
	public abstract int GetYear(DateTime time);

	// RVA: 0x180479C Offset: 0x180079C VA: 0x180479C Slot: 20
	public virtual bool IsLeapYear(int year) { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract bool IsLeapYear(int year, int era);

	// RVA: 0x18047B0 Offset: 0x18007B0 VA: 0x18047B0 Slot: 22
	public virtual DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era);

	// RVA: 0x18047D8 Offset: 0x18007D8 VA: 0x18047D8 Slot: 24
	internal virtual bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x1804938 Offset: 0x1800938 VA: 0x1804938 Slot: 25
	internal virtual bool IsValidYear(int year, int era) { }

	// RVA: 0x18049BC Offset: 0x18009BC VA: 0x18049BC Slot: 26
	internal virtual bool IsValidMonth(int year, int month, int era) { }

	// RVA: 0x1804A34 Offset: 0x1800A34 VA: 0x1804A34 Slot: 27
	internal virtual bool IsValidDay(int year, int month, int day, int era) { }

	// RVA: 0x1804AB4 Offset: 0x1800AB4 VA: 0x1804AB4 Slot: 28
	public virtual int get_TwoDigitYearMax() { }

	// RVA: 0x1804ABC Offset: 0x1800ABC VA: 0x1804ABC Slot: 29
	public virtual void set_TwoDigitYearMax(int value) { }

	// RVA: 0x1804AE0 Offset: 0x1800AE0 VA: 0x1804AE0 Slot: 30
	public virtual int ToFourDigitYear(int year) { }

	// RVA: 0x1804BD8 Offset: 0x1800BD8 VA: 0x1804BD8
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x1804D84 Offset: 0x1800D84 VA: 0x1804D84
	internal static int GetSystemTwoDigitYearSetting(int CalID, int defaultYearValue) { }
}

// Namespace: System.Globalization
internal class CalendarData // TypeDefIndex: 1332
{
	// Fields
	internal const int MAX_CALENDARS = 23;
	internal string sNativeName; // 0x10
	internal string[] saShortDates; // 0x18
	internal string[] saYearMonths; // 0x20
	internal string[] saLongDates; // 0x28
	internal string sMonthDay; // 0x30
	internal string[] saEraNames; // 0x38
	internal string[] saAbbrevEraNames; // 0x40
	internal string[] saAbbrevEnglishEraNames; // 0x48
	internal string[] saDayNames; // 0x50
	internal string[] saAbbrevDayNames; // 0x58
	internal string[] saSuperShortDayNames; // 0x60
	internal string[] saMonthNames; // 0x68
	internal string[] saAbbrevMonthNames; // 0x70
	internal string[] saMonthGenitiveNames; // 0x78
	internal string[] saAbbrevMonthGenitiveNames; // 0x80
	internal string[] saLeapYearMonthNames; // 0x88
	internal int iTwoDigitYearMax; // 0x90
	internal int iCurrentEra; // 0x94
	internal bool bUseUserOverrides; // 0x98
	internal static CalendarData Invariant; // 0x0
	private static string[] HEBREW_MONTH_NAMES; // 0x8
	private static string[] HEBREW_LEAP_MONTH_NAMES; // 0x10

	// Methods

	// RVA: 0x1804DE0 Offset: 0x1800DE0 VA: 0x1804DE0
	private void .ctor() { }

	// RVA: 0x1804DF0 Offset: 0x1800DF0 VA: 0x1804DF0
	private static void .cctor() { }

	// RVA: 0x1805FE4 Offset: 0x1801FE4 VA: 0x1805FE4
	internal void .ctor(string localeName, int calendarId, bool bUseUserOverrides) { }

	// RVA: 0x1806704 Offset: 0x1802704 VA: 0x1806704
	private void InitializeEraNames(string localeName, int calendarId) { }

	// RVA: 0x1806FCC Offset: 0x1802FCC VA: 0x1806FCC
	private static string[] GetJapaneseEraNames() { }

	// RVA: 0x1806EE8 Offset: 0x1802EE8 VA: 0x1806EE8
	private static string[] GetJapaneseEnglishEraNames() { }

	// RVA: 0x1806B68 Offset: 0x1802B68 VA: 0x1806B68
	private void InitializeAbbreviatedEraNames(string localeName, int calendarId) { }

	// RVA: 0x18046F4 Offset: 0x18006F4 VA: 0x18046F4
	internal static CalendarData GetCalendarData(int calendarId) { }

	// RVA: 0x1807298 Offset: 0x1803298 VA: 0x1807298
	private static string CalendarIdToCultureName(int calendarId) { }

	// RVA: 0x1804DD8 Offset: 0x1800DD8 VA: 0x1804DD8
	public static int nativeGetTwoDigitYearMax(int calID) { }

	// RVA: 0x1806634 Offset: 0x1802634 VA: 0x1806634
	private static bool nativeGetCalendarData(CalendarData data, string localeName, int calendarId) { }

	// RVA: 0x1807364 Offset: 0x1803364 VA: 0x1807364
	private bool fill_calendar_data(string localeName, int datetimeIndex) { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class GregorianCalendar : Calendar // TypeDefIndex: 1333
{
	// Fields
	internal GregorianCalendarTypes m_type; // 0x1C
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	private static Calendar s_defaultInstance; // 0x10

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	[OnDeserialized]
	// RVA: 0x1807368 Offset: 0x1803368 VA: 0x1807368
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x1807434 Offset: 0x1803434 VA: 0x1807434 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x180748C Offset: 0x180348C VA: 0x180748C Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x18074E4 Offset: 0x18034E4 VA: 0x18074E4
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x18075B8 Offset: 0x18035B8 VA: 0x18075B8
	public void .ctor() { }

	// RVA: 0x18075E4 Offset: 0x18035E4 VA: 0x18075E4
	public void .ctor(GregorianCalendarTypes type) { }

	// RVA: 0x180772C Offset: 0x180372C VA: 0x180772C Slot: 7
	internal override int get_ID() { }

	// RVA: 0x1807734 Offset: 0x1803734 VA: 0x1807734 Slot: 31
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x180793C Offset: 0x180393C VA: 0x180793C
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x1807B0C Offset: 0x1803B0C VA: 0x1807B0C Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x1807B90 Offset: 0x1803B90 VA: 0x1807B90 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x1807C38 Offset: 0x1803C38 VA: 0x1807C38 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x1807EC8 Offset: 0x1803EC8 VA: 0x1807EC8 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x1808048 Offset: 0x1804048 VA: 0x1808048 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x1808050 Offset: 0x1804050 VA: 0x1808050 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x18080B4 Offset: 0x18040B4 VA: 0x18080B4 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x1808138 Offset: 0x1804138 VA: 0x1808138 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x180827C Offset: 0x180427C VA: 0x180827C Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x1808300 Offset: 0x1804300 VA: 0x1808300 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x1808490 Offset: 0x1804490 VA: 0x1808490 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x180852C Offset: 0x180452C VA: 0x180852C Slot: 24
	internal override bool TryToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era, out DateTime result) { }

	// RVA: 0x1808620 Offset: 0x1804620 VA: 0x1808620 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x1808664 Offset: 0x1804664 VA: 0x1808664 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x1808770 Offset: 0x1804770 VA: 0x1808770 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x1808884 Offset: 0x1804884 VA: 0x1808884
	private static void .cctor() { }
}

// Namespace: System.Globalization
[Serializable]
internal class EraInfo // TypeDefIndex: 1334
{
	// Fields
	internal int era; // 0x10
	internal long ticks; // 0x18
	internal int yearOffset; // 0x20
	internal int minEraYear; // 0x24
	internal int maxEraYear; // 0x28
	[OptionalField(VersionAdded = 4)]
	internal string eraName; // 0x30
	[OptionalField(VersionAdded = 4)]
	internal string abbrevEraName; // 0x38
	[OptionalField(VersionAdded = 4)]
	internal string englishEraName; // 0x40

	// Methods

	// RVA: 0x1808968 Offset: 0x1804968 VA: 0x1808968
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear) { }

	// RVA: 0x1808A4C Offset: 0x1804A4C VA: 0x1808A4C
	internal void .ctor(int era, int startYear, int startMonth, int startDay, int yearOffset, int minEraYear, int maxEraYear, string eraName, string abbrevEraName, string englishEraName) { }
}

// Namespace: System.Globalization
[Serializable]
internal class GregorianCalendarHelper // TypeDefIndex: 1335
{
	// Fields
	internal static readonly int[] DaysToMonth365; // 0x0
	internal static readonly int[] DaysToMonth366; // 0x8
	[OptionalField(VersionAdded = 1)]
	internal int m_maxYear; // 0x10
	[OptionalField(VersionAdded = 1)]
	internal int m_minYear; // 0x14
	internal Calendar m_Cal; // 0x18
	[OptionalField(VersionAdded = 1)]
	internal EraInfo[] m_EraInfo; // 0x20
	[OptionalField(VersionAdded = 1)]
	internal int[] m_eras; // 0x28
	[OptionalField(VersionAdded = 1)]
	internal DateTime m_minDate; // 0x30

	// Properties
	internal int MaxYear { get; }
	public int[] Eras { get; }

	// Methods

	// RVA: 0x1808B6C Offset: 0x1804B6C VA: 0x1808B6C
	internal int get_MaxYear() { }

	// RVA: 0x1808B74 Offset: 0x1804B74 VA: 0x1808B74
	internal void .ctor(Calendar cal, EraInfo[] eraInfo) { }

	// RVA: 0x1808C14 Offset: 0x1804C14 VA: 0x1808C14
	private int GetYearOffset(int year, int era, bool throwOnError) { }

	// RVA: 0x1808EF8 Offset: 0x1804EF8 VA: 0x1808EF8
	internal int GetGregorianYear(int year, int era) { }

	// RVA: 0x1808F14 Offset: 0x1804F14 VA: 0x1808F14
	internal bool IsValidYear(int year, int era) { }

	// RVA: 0x1808F30 Offset: 0x1804F30 VA: 0x1808F30 Slot: 4
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x1809334 Offset: 0x1805334 VA: 0x1809334
	internal static long GetAbsoluteDate(int year, int month, int day) { }

	// RVA: 0x1809504 Offset: 0x1805504 VA: 0x1809504
	internal static long DateToTicks(int year, int month, int day) { }

	// RVA: 0x1809584 Offset: 0x1805584 VA: 0x1809584
	internal static long TimeToTicks(int hour, int minute, int second, int millisecond) { }

	// RVA: 0x1809150 Offset: 0x1805150 VA: 0x1809150
	internal void CheckTicksRange(long ticks) { }

	// RVA: 0x1809730 Offset: 0x1805730 VA: 0x1809730
	public int GetDayOfMonth(DateTime time) { }

	// RVA: 0x18097B0 Offset: 0x18057B0 VA: 0x18097B0
	public DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x180987C Offset: 0x180587C VA: 0x180987C
	public int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x1809A18 Offset: 0x1805A18 VA: 0x1809A18
	public int GetDaysInYear(int year, int era) { }

	// RVA: 0x1809A78 Offset: 0x1805A78 VA: 0x1809A78
	public int GetEra(DateTime time) { }

	// RVA: 0x1809B84 Offset: 0x1805B84 VA: 0x1809B84
	public int[] get_Eras() { }

	// RVA: 0x1809C90 Offset: 0x1805C90 VA: 0x1809C90
	public int GetMonth(DateTime time) { }

	// RVA: 0x1809D10 Offset: 0x1805D10 VA: 0x1809D10
	public int GetMonthsInYear(int year, int era) { }

	// RVA: 0x1809D28 Offset: 0x1805D28 VA: 0x1809D28
	public int GetYear(DateTime time) { }

	// RVA: 0x1809E54 Offset: 0x1805E54 VA: 0x1809E54
	public bool IsLeapYear(int year, int era) { }

	// RVA: 0x1809EC4 Offset: 0x1805EC4 VA: 0x1809EC4
	public DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x1809FC8 Offset: 0x1805FC8 VA: 0x1809FC8
	public int ToFourDigitYear(int year, int twoDigitYearMax) { }

	// RVA: 0x180A134 Offset: 0x1806134 VA: 0x180A134
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public enum GregorianCalendarTypes // TypeDefIndex: 1336
{
	// Fields
	public int value__; // 0x0
	public const GregorianCalendarTypes Localized = 1;
	public const GregorianCalendarTypes USEnglish = 2;
	public const GregorianCalendarTypes MiddleEastFrench = 9;
	public const GregorianCalendarTypes Arabic = 10;
	public const GregorianCalendarTypes TransliteratedEnglish = 11;
	public const GregorianCalendarTypes TransliteratedFrench = 12;
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class HijriCalendar : Calendar // TypeDefIndex: 1337
{
	// Fields
	public static readonly int HijriEra; // 0x0
	internal static readonly int[] HijriMonthDays; // 0x8
	private int m_HijriAdvance; // 0x1C
	internal static readonly DateTime calendarMinValue; // 0x10
	internal static readonly DateTime calendarMaxValue; // 0x18

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public int HijriAdjustment { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x180A218 Offset: 0x1806218 VA: 0x180A218 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x180A270 Offset: 0x1806270 VA: 0x180A270 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x180A2C8 Offset: 0x18062C8 VA: 0x180A2C8
	public void .ctor() { }

	// RVA: 0x180A2E4 Offset: 0x18062E4 VA: 0x180A2E4 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x180A2EC Offset: 0x18062EC VA: 0x180A2EC
	private long GetAbsoluteDateHijri(int y, int m, int d) { }

	// RVA: 0x180A3B4 Offset: 0x18063B4 VA: 0x180A3B4
	private long DaysUpToHijriYear(int HijriYear) { }

	// RVA: 0x180A46C Offset: 0x180646C VA: 0x180A46C
	public int get_HijriAdjustment() { }

	// RVA: 0x180A4D4 Offset: 0x18064D4 VA: 0x180A4D4
	private static int GetAdvanceHijriDate() { }

	// RVA: 0x180A4DC Offset: 0x18064DC VA: 0x180A4DC
	internal static void CheckTicksRange(long ticks) { }

	// RVA: 0x180A6BC Offset: 0x18066BC VA: 0x180A6BC
	internal static void CheckEraRange(int era) { }

	// RVA: 0x180A788 Offset: 0x1806788 VA: 0x180A788
	internal static void CheckYearRange(int year, int era) { }

	// RVA: 0x180A8D4 Offset: 0x18068D4 VA: 0x180A8D4
	internal static void CheckYearMonthRange(int year, int month, int era) { }

	// RVA: 0x180AA50 Offset: 0x1806A50 VA: 0x180AA50 Slot: 31
	internal virtual int GetDatePart(long ticks, int part) { }

	// RVA: 0x180ACC0 Offset: 0x1806CC0 VA: 0x180ACC0 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x180AD44 Offset: 0x1806D44 VA: 0x180AD44 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x180ADEC Offset: 0x1806DEC VA: 0x180ADEC Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x180AEA8 Offset: 0x1806EA8 VA: 0x180AEA8 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x180AF3C Offset: 0x1806F3C VA: 0x180AF3C Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x180AFD8 Offset: 0x1806FD8 VA: 0x180AFD8 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x180B074 Offset: 0x1807074 VA: 0x180B074 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x180B0F8 Offset: 0x18070F8 VA: 0x180B0F8 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x180B164 Offset: 0x1807164 VA: 0x180B164 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x180B1E8 Offset: 0x18071E8 VA: 0x180B1E8 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x180B288 Offset: 0x1807288 VA: 0x180B288 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x180B454 Offset: 0x1807454 VA: 0x180B454 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x180B498 Offset: 0x1807498 VA: 0x180B498 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x180B5A4 Offset: 0x18075A4 VA: 0x180B5A4 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x180B6D4 Offset: 0x18076D4 VA: 0x180B6D4
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class JapaneseCalendar : Calendar // TypeDefIndex: 1338
{
	// Fields
	internal static readonly DateTime calendarMinValue; // 0x0
	internal static EraInfo[] japaneseEraInfo; // 0x8
	internal static Calendar s_defaultInstance; // 0x10
	internal GregorianCalendarHelper helper; // 0x20

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x180B7F0 Offset: 0x18077F0 VA: 0x180B7F0 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x180B848 Offset: 0x1807848 VA: 0x180B848 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x180B8A0 Offset: 0x18078A0 VA: 0x180B8A0
	internal static EraInfo[] GetEraInfo() { }

	// RVA: 0x180BD58 Offset: 0x1807D58 VA: 0x180BD58
	private static EraInfo[] GetErasFromRegistry() { }

	// RVA: 0x180BD60 Offset: 0x1807D60 VA: 0x180BD60
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x180BE1C Offset: 0x1807E1C VA: 0x180BE1C
	public void .ctor() { }

	// RVA: 0x180BFDC Offset: 0x1807FDC VA: 0x180BFDC Slot: 7
	internal override int get_ID() { }

	// RVA: 0x180BFE4 Offset: 0x1807FE4 VA: 0x180BFE4 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x180BFF8 Offset: 0x1807FF8 VA: 0x180BFF8 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x180C00C Offset: 0x180800C VA: 0x180C00C Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x180C020 Offset: 0x1808020 VA: 0x180C020 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x180C034 Offset: 0x1808034 VA: 0x180C034 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x180C058 Offset: 0x1808058 VA: 0x180C058 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x180C06C Offset: 0x180806C VA: 0x180C06C Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x180C080 Offset: 0x1808080 VA: 0x180C080 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x180C094 Offset: 0x1808094 VA: 0x180C094 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x180C0A8 Offset: 0x18080A8 VA: 0x180C0A8 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x180C0C8 Offset: 0x18080C8 VA: 0x180C0C8 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x180C20C Offset: 0x180820C VA: 0x180C20C Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x18070B0 Offset: 0x18030B0 VA: 0x18070B0
	internal static string[] EraNames() { }

	// RVA: 0x18071A4 Offset: 0x18031A4 VA: 0x18071A4
	internal static string[] EnglishEraNames() { }

	// RVA: 0x180C220 Offset: 0x1808220 VA: 0x180C220 Slot: 25
	internal override bool IsValidYear(int year, int era) { }

	// RVA: 0x180C248 Offset: 0x1808248 VA: 0x180C248 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x180C28C Offset: 0x180828C VA: 0x180C28C Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x180C3BC Offset: 0x18083BC VA: 0x180C3BC
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public sealed class NumberFormatInfo : ICloneable, IFormatProvider // TypeDefIndex: 1339
{
	// Fields
	private static NumberFormatInfo invariantInfo; // 0x0
	internal int[] numberGroupSizes; // 0x10
	internal int[] currencyGroupSizes; // 0x18
	internal int[] percentGroupSizes; // 0x20
	internal string positiveSign; // 0x28
	internal string negativeSign; // 0x30
	internal string numberDecimalSeparator; // 0x38
	internal string numberGroupSeparator; // 0x40
	internal string currencyGroupSeparator; // 0x48
	internal string currencyDecimalSeparator; // 0x50
	internal string currencySymbol; // 0x58
	internal string ansiCurrencySymbol; // 0x60
	internal string nanSymbol; // 0x68
	internal string positiveInfinitySymbol; // 0x70
	internal string negativeInfinitySymbol; // 0x78
	internal string percentDecimalSeparator; // 0x80
	internal string percentGroupSeparator; // 0x88
	internal string percentSymbol; // 0x90
	internal string perMilleSymbol; // 0x98
	[OptionalField(VersionAdded = 2)]
	internal string[] nativeDigits; // 0xA0
	[OptionalField(VersionAdded = 1)]
	internal int m_dataItem; // 0xA8
	internal int numberDecimalDigits; // 0xAC
	internal int currencyDecimalDigits; // 0xB0
	internal int currencyPositivePattern; // 0xB4
	internal int currencyNegativePattern; // 0xB8
	internal int numberNegativePattern; // 0xBC
	internal int percentPositivePattern; // 0xC0
	internal int percentNegativePattern; // 0xC4
	internal int percentDecimalDigits; // 0xC8
	[OptionalField(VersionAdded = 2)]
	internal int digitSubstitution; // 0xCC
	internal bool isReadOnly; // 0xD0
	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride; // 0xD1
	[OptionalField(VersionAdded = 2)]
	internal bool m_isInvariant; // 0xD2
	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsNumber; // 0xD3
	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsCurrency; // 0xD4
	private const NumberStyles InvalidNumberStyles = -1024;

	// Properties
	public static NumberFormatInfo InvariantInfo { get; }
	public int CurrencyDecimalDigits { get; }
	public string CurrencyDecimalSeparator { get; }
	public bool IsReadOnly { get; }
	public int[] CurrencyGroupSizes { get; }
	public int[] NumberGroupSizes { get; }
	public int[] PercentGroupSizes { get; }
	public string CurrencyGroupSeparator { get; }
	public string CurrencySymbol { get; }
	public static NumberFormatInfo CurrentInfo { get; }
	public string NaNSymbol { get; set; }
	public int CurrencyNegativePattern { get; }
	public int NumberNegativePattern { get; }
	public int PercentPositivePattern { get; }
	public int PercentNegativePattern { get; }
	public string NegativeInfinitySymbol { get; }
	public string NegativeSign { get; }
	public int NumberDecimalDigits { get; }
	public string NumberDecimalSeparator { get; }
	public string NumberGroupSeparator { get; }
	public int CurrencyPositivePattern { get; }
	public string PositiveInfinitySymbol { get; }
	public string PositiveSign { get; }
	public int PercentDecimalDigits { get; }
	public string PercentDecimalSeparator { get; }
	public string PercentGroupSeparator { get; }
	public string PercentSymbol { get; }
	public string PerMilleSymbol { get; }

	// Methods

	// RVA: 0x180C424 Offset: 0x1808424 VA: 0x180C424
	public void .ctor() { }

	[OnSerializing]
	// RVA: 0x180C9DC Offset: 0x18089DC VA: 0x180C9DC
	private void OnSerializing(StreamingContext ctx) { }

	[OnDeserializing]
	// RVA: 0x180CA60 Offset: 0x1808A60 VA: 0x180CA60
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x180CA64 Offset: 0x1808A64 VA: 0x180CA64
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x180C42C Offset: 0x180842C VA: 0x180C42C
	internal void .ctor(CultureData cultureData) { }

	// RVA: 0x180CA68 Offset: 0x1808A68 VA: 0x180CA68
	private void VerifyWritable() { }

	// RVA: 0x180CACC Offset: 0x1808ACC VA: 0x180CACC
	public static NumberFormatInfo get_InvariantInfo() { }

	// RVA: 0x180CC50 Offset: 0x1808C50 VA: 0x180CC50
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider) { }

	// RVA: 0x180CED8 Offset: 0x1808ED8 VA: 0x180CED8 Slot: 4
	public object Clone() { }

	// RVA: 0x180CF44 Offset: 0x1808F44 VA: 0x180CF44
	public int get_CurrencyDecimalDigits() { }

	// RVA: 0x180CF4C Offset: 0x1808F4C VA: 0x180CF4C
	public string get_CurrencyDecimalSeparator() { }

	// RVA: 0x180CF54 Offset: 0x1808F54 VA: 0x180CF54
	public bool get_IsReadOnly() { }

	// RVA: 0x180CF5C Offset: 0x1808F5C VA: 0x180CF5C
	public int[] get_CurrencyGroupSizes() { }

	// RVA: 0x180CFD4 Offset: 0x1808FD4 VA: 0x180CFD4
	public int[] get_NumberGroupSizes() { }

	// RVA: 0x180D04C Offset: 0x180904C VA: 0x180D04C
	public int[] get_PercentGroupSizes() { }

	// RVA: 0x180D0C4 Offset: 0x18090C4 VA: 0x180D0C4
	public string get_CurrencyGroupSeparator() { }

	// RVA: 0x180D0CC Offset: 0x18090CC VA: 0x180D0CC
	public string get_CurrencySymbol() { }

	// RVA: 0x180CDF0 Offset: 0x1808DF0 VA: 0x180CDF0
	public static NumberFormatInfo get_CurrentInfo() { }

	// RVA: 0x180D0D4 Offset: 0x18090D4 VA: 0x180D0D4
	public string get_NaNSymbol() { }

	// RVA: 0x180D0DC Offset: 0x18090DC VA: 0x180D0DC
	public void set_NaNSymbol(string value) { }

	// RVA: 0x180D170 Offset: 0x1809170 VA: 0x180D170
	public int get_CurrencyNegativePattern() { }

	// RVA: 0x180D178 Offset: 0x1809178 VA: 0x180D178
	public int get_NumberNegativePattern() { }

	// RVA: 0x180D180 Offset: 0x1809180 VA: 0x180D180
	public int get_PercentPositivePattern() { }

	// RVA: 0x180D188 Offset: 0x1809188 VA: 0x180D188
	public int get_PercentNegativePattern() { }

	// RVA: 0x180D190 Offset: 0x1809190 VA: 0x180D190
	public string get_NegativeInfinitySymbol() { }

	// RVA: 0x180D198 Offset: 0x1809198 VA: 0x180D198
	public string get_NegativeSign() { }

	// RVA: 0x180D1A0 Offset: 0x18091A0 VA: 0x180D1A0
	public int get_NumberDecimalDigits() { }

	// RVA: 0x180D1A8 Offset: 0x18091A8 VA: 0x180D1A8
	public string get_NumberDecimalSeparator() { }

	// RVA: 0x180D1B0 Offset: 0x18091B0 VA: 0x180D1B0
	public string get_NumberGroupSeparator() { }

	// RVA: 0x180D1B8 Offset: 0x18091B8 VA: 0x180D1B8
	public int get_CurrencyPositivePattern() { }

	// RVA: 0x180D1C0 Offset: 0x18091C0 VA: 0x180D1C0
	public string get_PositiveInfinitySymbol() { }

	// RVA: 0x180D1C8 Offset: 0x18091C8 VA: 0x180D1C8
	public string get_PositiveSign() { }

	// RVA: 0x180D1D0 Offset: 0x18091D0 VA: 0x180D1D0
	public int get_PercentDecimalDigits() { }

	// RVA: 0x180D1D8 Offset: 0x18091D8 VA: 0x180D1D8
	public string get_PercentDecimalSeparator() { }

	// RVA: 0x180D1E0 Offset: 0x18091E0 VA: 0x180D1E0
	public string get_PercentGroupSeparator() { }

	// RVA: 0x180D1E8 Offset: 0x18091E8 VA: 0x180D1E8
	public string get_PercentSymbol() { }

	// RVA: 0x180D1F0 Offset: 0x18091F0 VA: 0x180D1F0
	public string get_PerMilleSymbol() { }

	// RVA: 0x180D1F8 Offset: 0x18091F8 VA: 0x180D1F8 Slot: 5
	public object GetFormat(Type formatType) { }

	// RVA: 0x180CB80 Offset: 0x1808B80 VA: 0x180CB80
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi) { }

	// RVA: 0x180D284 Offset: 0x1809284 VA: 0x180D284
	internal static void ValidateParseStyleInteger(NumberStyles style) { }

	// RVA: 0x180D350 Offset: 0x1809350 VA: 0x180D350
	internal static void ValidateParseStyleFloatingPoint(NumberStyles style) { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class TaiwanCalendar : Calendar // TypeDefIndex: 1340
{
	// Fields
	internal static EraInfo[] taiwanEraInfo; // 0x0
	internal static Calendar s_defaultInstance; // 0x8
	internal GregorianCalendarHelper helper; // 0x20
	internal static readonly DateTime calendarMinValue; // 0x10

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x180D414 Offset: 0x1809414 VA: 0x180D414
	internal static Calendar GetDefaultInstance() { }

	// RVA: 0x180D690 Offset: 0x1809690 VA: 0x180D690 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x180D6E8 Offset: 0x18096E8 VA: 0x180D6E8 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x180D4D0 Offset: 0x18094D0 VA: 0x180D4D0
	public void .ctor() { }

	// RVA: 0x180D740 Offset: 0x1809740 VA: 0x180D740 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x180D748 Offset: 0x1809748 VA: 0x180D748 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x180D75C Offset: 0x180975C VA: 0x180D75C Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x180D770 Offset: 0x1809770 VA: 0x180D770 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x180D784 Offset: 0x1809784 VA: 0x180D784 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x180D798 Offset: 0x1809798 VA: 0x180D798 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x180D7BC Offset: 0x18097BC VA: 0x180D7BC Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x180D7D0 Offset: 0x18097D0 VA: 0x180D7D0 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x180D7E4 Offset: 0x18097E4 VA: 0x180D7E4 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x180D7F8 Offset: 0x18097F8 VA: 0x180D7F8 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x180D80C Offset: 0x180980C VA: 0x180D80C Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x180D82C Offset: 0x180982C VA: 0x180D82C Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x180D840 Offset: 0x1809840 VA: 0x180D840 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x180D884 Offset: 0x1809884 VA: 0x180D884 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x180D9B4 Offset: 0x18099B4 VA: 0x180D9B4 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x180DAF8 Offset: 0x1809AF8 VA: 0x180DAF8
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class TextInfo : ICloneable, IDeserializationCallback // TypeDefIndex: 1341
{
	// Fields
	[OptionalField(VersionAdded = 2)]
	private bool m_isReadOnly; // 0x10
	[OptionalField(VersionAdded = 3)]
	private string m_cultureName; // 0x18
	private CultureData m_cultureData; // 0x20
	private string m_textInfoName; // 0x28
	private Nullable<bool> m_IsAsciiCasingSameAsInvariant; // 0x30
	internal static TextInfo s_Invariant; // 0x0
	[OptionalField(VersionAdded = 2)]
	private string customCultureName; // 0x38
	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride; // 0x40
	[OptionalField(VersionAdded = 1)]
	internal int m_win32LangID; // 0x44

	// Properties
	internal static TextInfo Invariant { get; }
	[ComVisible(False)]
	public string CultureName { get; }
	private bool IsAsciiCasingSameAsInvariant { get; }

	// Methods

	// RVA: 0x180DC34 Offset: 0x1809C34 VA: 0x180DC34
	internal static TextInfo get_Invariant() { }

	// RVA: 0x180DCDC Offset: 0x1809CDC VA: 0x180DCDC
	internal void .ctor(CultureData cultureData) { }

	[OnDeserializing]
	// RVA: 0x180DD48 Offset: 0x1809D48 VA: 0x180DD48
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x180DD70 Offset: 0x1809D70 VA: 0x180DD70
	private void OnDeserialized() { }

	[OnDeserialized]
	// RVA: 0x180DE98 Offset: 0x1809E98 VA: 0x180DE98
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializing]
	// RVA: 0x180DE9C Offset: 0x1809E9C VA: 0x180DE9C
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x180DF28 Offset: 0x1809F28 VA: 0x180DF28
	public string get_CultureName() { }

	[ComVisible(False)]
	// RVA: 0x180DF30 Offset: 0x1809F30 VA: 0x180DF30 Slot: 6
	public virtual object Clone() { }

	// RVA: 0x180DFB8 Offset: 0x1809FB8 VA: 0x180DFB8
	internal void SetReadOnlyState(bool readOnly) { }

	// RVA: 0x180DFC0 Offset: 0x1809FC0 VA: 0x180DFC0 Slot: 7
	public virtual char ToLower(char c) { }

	// RVA: 0x180E5B0 Offset: 0x180A5B0 VA: 0x180E5B0 Slot: 8
	public virtual string ToLower(string str) { }

	// RVA: 0x180E130 Offset: 0x180A130 VA: 0x180E130
	private static char ToLowerAsciiInvariant(char c) { }

	// RVA: 0x180E6C8 Offset: 0x180A6C8 VA: 0x180E6C8 Slot: 9
	public virtual char ToUpper(char c) { }

	// RVA: 0x180EBF8 Offset: 0x180ABF8 VA: 0x180EBF8 Slot: 10
	public virtual string ToUpper(string str) { }

	// RVA: 0x180E728 Offset: 0x180A728 VA: 0x180E728
	internal static char ToUpperAsciiInvariant(char c) { }

	// RVA: 0x180E01C Offset: 0x180A01C VA: 0x180E01C
	private static bool IsAscii(char c) { }

	// RVA: 0x180E02C Offset: 0x180A02C VA: 0x180E02C
	private bool get_IsAsciiCasingSameAsInvariant() { }

	// RVA: 0x180ED10 Offset: 0x180AD10 VA: 0x180ED10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x180EDA8 Offset: 0x180ADA8 VA: 0x180EDA8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x180EDC4 Offset: 0x180ADC4 VA: 0x180EDC4 Slot: 3
	public override string ToString() { }

	// RVA: 0x180EE1C Offset: 0x180AE1C VA: 0x180EE1C Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x180EC4C Offset: 0x180AC4C VA: 0x180EC4C
	private string ToUpperInternal(string str) { }

	// RVA: 0x180E604 Offset: 0x180A604 VA: 0x180E604
	private string ToLowerInternal(string str) { }

	// RVA: 0x180E744 Offset: 0x180A744 VA: 0x180E744
	private char ToUpperInternal(char c) { }

	// RVA: 0x180E148 Offset: 0x180A148 VA: 0x180E148
	private char ToLowerInternal(char c) { }

	// RVA: 0x180EE20 Offset: 0x180AE20 VA: 0x180EE20
	internal void ToUpperAsciiInvariant(ReadOnlySpan<char> source, Span<char> destination) { }

	// RVA: 0x180EEA8 Offset: 0x180AEA8 VA: 0x180EEA8
	internal void ChangeCase(ReadOnlySpan<char> source, Span<char> destination, bool toUpper) { }

	// RVA: 0x180EFE8 Offset: 0x180AFE8 VA: 0x180EFE8
	internal void .ctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class ThaiBuddhistCalendar : Calendar // TypeDefIndex: 1342
{
	// Fields
	internal static EraInfo[] thaiBuddhistEraInfo; // 0x0
	internal GregorianCalendarHelper helper; // 0x20

	// Properties
	[ComVisible(False)]
	public override DateTime MinSupportedDateTime { get; }
	[ComVisible(False)]
	public override DateTime MaxSupportedDateTime { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x180F020 Offset: 0x180B020 VA: 0x180F020 Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x180F078 Offset: 0x180B078 VA: 0x180F078 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x180F0D0 Offset: 0x180B0D0 VA: 0x180F0D0
	public void .ctor() { }

	// RVA: 0x180F17C Offset: 0x180B17C VA: 0x180F17C Slot: 7
	internal override int get_ID() { }

	// RVA: 0x180F184 Offset: 0x180B184 VA: 0x180F184 Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x180F198 Offset: 0x180B198 VA: 0x180F198 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x180F1AC Offset: 0x180B1AC VA: 0x180F1AC Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x180F1C0 Offset: 0x180B1C0 VA: 0x180F1C0 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x180F1D4 Offset: 0x180B1D4 VA: 0x180F1D4 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x180F1F8 Offset: 0x180B1F8 VA: 0x180F1F8 Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x180F20C Offset: 0x180B20C VA: 0x180F20C Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x180F220 Offset: 0x180B220 VA: 0x180F220 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x180F234 Offset: 0x180B234 VA: 0x180F234 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x180F248 Offset: 0x180B248 VA: 0x180F248 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x180F268 Offset: 0x180B268 VA: 0x180F268 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x180F27C Offset: 0x180B27C VA: 0x180F27C Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x180F2C0 Offset: 0x180B2C0 VA: 0x180F2C0 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x180F3F0 Offset: 0x180B3F0 VA: 0x180F3F0 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x180F498 Offset: 0x180B498 VA: 0x180F498
	private static void .cctor() { }
}

// Namespace: 
internal struct UmAlQuraCalendar.DateMapping // TypeDefIndex: 1343
{
	// Fields
	internal int HijriMonthsLengthFlags; // 0x0
	internal DateTime GregorianDate; // 0x8

	// Methods

	// RVA: 0x180F70C Offset: 0x180B70C VA: 0x180F70C
	internal void .ctor(int MonthsLengthFlags, int GYear, int GMonth, int GDay) { }
}

// Namespace: System.Globalization
[Serializable]
public class UmAlQuraCalendar : Calendar // TypeDefIndex: 1344
{
	// Fields
	private static readonly UmAlQuraCalendar.DateMapping[] HijriYearInfo; // 0x0
	internal static DateTime minDate; // 0x8
	internal static DateTime maxDate; // 0x10

	// Properties
	public override DateTime MinSupportedDateTime { get; }
	public override DateTime MaxSupportedDateTime { get; }
	internal override int BaseCalendarID { get; }
	internal override int ID { get; }
	public override int[] Eras { get; }
	public override int TwoDigitYearMax { get; set; }

	// Methods

	// RVA: 0x180F5A4 Offset: 0x180B5A4 VA: 0x180F5A4
	private static UmAlQuraCalendar.DateMapping[] InitDateMapping() { }

	// RVA: 0x180F74C Offset: 0x180B74C VA: 0x180F74C Slot: 5
	public override DateTime get_MinSupportedDateTime() { }

	// RVA: 0x180F7A4 Offset: 0x180B7A4 VA: 0x180F7A4 Slot: 6
	public override DateTime get_MaxSupportedDateTime() { }

	// RVA: 0x180F7FC Offset: 0x180B7FC VA: 0x180F7FC
	public void .ctor() { }

	// RVA: 0x180F810 Offset: 0x180B810 VA: 0x180F810 Slot: 8
	internal override int get_BaseCalendarID() { }

	// RVA: 0x180F818 Offset: 0x180B818 VA: 0x180F818 Slot: 7
	internal override int get_ID() { }

	// RVA: 0x180F820 Offset: 0x180B820 VA: 0x180F820
	private static void ConvertHijriToGregorian(int HijriYear, int HijriMonth, int HijriDay, ref int yg, ref int mg, ref int dg) { }

	// RVA: 0x180F974 Offset: 0x180B974 VA: 0x180F974
	private static long GetAbsoluteDateUmAlQura(int year, int month, int day) { }

	// RVA: 0x180FA38 Offset: 0x180BA38 VA: 0x180FA38
	internal static void CheckTicksRange(long ticks) { }

	// RVA: 0x180FC18 Offset: 0x180BC18 VA: 0x180FC18
	internal static void CheckEraRange(int era) { }

	// RVA: 0x180FC90 Offset: 0x180BC90 VA: 0x180FC90
	internal static void CheckYearRange(int year, int era) { }

	// RVA: 0x180FDD0 Offset: 0x180BDD0 VA: 0x180FDD0
	internal static void CheckYearMonthRange(int year, int month, int era) { }

	// RVA: 0x180FEAC Offset: 0x180BEAC VA: 0x180FEAC
	private static void ConvertGregorianToHijri(DateTime time, ref int HijriYear, ref int HijriMonth, ref int HijriDay) { }

	// RVA: 0x1810198 Offset: 0x180C198 VA: 0x1810198 Slot: 31
	internal virtual int GetDatePart(DateTime time, int part) { }

	// RVA: 0x1810320 Offset: 0x180C320 VA: 0x1810320 Slot: 11
	public override int GetDayOfMonth(DateTime time) { }

	// RVA: 0x1810334 Offset: 0x180C334 VA: 0x1810334 Slot: 12
	public override DayOfWeek GetDayOfWeek(DateTime time) { }

	// RVA: 0x18103DC Offset: 0x180C3DC VA: 0x18103DC Slot: 13
	public override int GetDaysInMonth(int year, int month, int era) { }

	// RVA: 0x1810490 Offset: 0x180C490 VA: 0x1810490
	internal static int RealGetDaysInYear(int year) { }

	// RVA: 0x1810530 Offset: 0x180C530 VA: 0x1810530 Slot: 14
	public override int GetDaysInYear(int year, int era) { }

	// RVA: 0x181059C Offset: 0x180C59C VA: 0x181059C Slot: 15
	public override int GetEra(DateTime time) { }

	// RVA: 0x1810630 Offset: 0x180C630 VA: 0x1810630 Slot: 16
	public override int[] get_Eras() { }

	// RVA: 0x1810694 Offset: 0x180C694 VA: 0x1810694 Slot: 17
	public override int GetMonth(DateTime time) { }

	// RVA: 0x18106A8 Offset: 0x180C6A8 VA: 0x18106A8 Slot: 18
	public override int GetMonthsInYear(int year, int era) { }

	// RVA: 0x1810714 Offset: 0x180C714 VA: 0x1810714 Slot: 19
	public override int GetYear(DateTime time) { }

	// RVA: 0x1810728 Offset: 0x180C728 VA: 0x1810728 Slot: 21
	public override bool IsLeapYear(int year, int era) { }

	// RVA: 0x18107A0 Offset: 0x180C7A0 VA: 0x18107A0 Slot: 23
	public override DateTime ToDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, int era) { }

	// RVA: 0x18109E0 Offset: 0x180C9E0 VA: 0x18109E0 Slot: 28
	public override int get_TwoDigitYearMax() { }

	// RVA: 0x1810A24 Offset: 0x180CA24 VA: 0x1810A24 Slot: 29
	public override void set_TwoDigitYearMax(int value) { }

	// RVA: 0x1810B38 Offset: 0x180CB38 VA: 0x1810B38 Slot: 30
	public override int ToFourDigitYear(int year) { }

	// RVA: 0x1810C68 Offset: 0x180CC68 VA: 0x1810C68
	private static void .cctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class SortKey // TypeDefIndex: 1345
{
	// Fields
	private readonly string source; // 0x10
	private readonly byte[] key; // 0x18
	private readonly CompareOptions options; // 0x20
	private readonly int lcid; // 0x24

	// Properties
	public virtual string OriginalString { get; }
	public virtual byte[] KeyData { get; }

	// Methods

	// RVA: 0x1810D8C Offset: 0x180CD8C VA: 0x1810D8C
	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	// RVA: 0x1810EFC Offset: 0x180CEFC VA: 0x1810EFC
	internal void .ctor(int lcid, string source, CompareOptions opt) { }

	// RVA: 0x1810FEC Offset: 0x180CFEC VA: 0x1810FEC
	internal void .ctor(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	// RVA: 0x181104C Offset: 0x180D04C VA: 0x181104C
	internal void .ctor(string localeName, string str, CompareOptions options, byte[] keyData) { }

	// RVA: 0x181108C Offset: 0x180D08C VA: 0x181108C Slot: 4
	public virtual string get_OriginalString() { }

	// RVA: 0x1811094 Offset: 0x180D094 VA: 0x1811094 Slot: 5
	public virtual byte[] get_KeyData() { }

	// RVA: 0x181109C Offset: 0x180D09C VA: 0x181109C Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x181114C Offset: 0x180D14C VA: 0x181114C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18111B4 Offset: 0x180D1B4 VA: 0x18111B4 Slot: 3
	public override string ToString() { }

	// RVA: 0x181134C Offset: 0x180D34C VA: 0x181134C
	internal void .ctor() { }
}

// Namespace: System.Globalization
internal interface ISimpleCollator // TypeDefIndex: 1346
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SortKey GetSortKey(string source, CompareOptions options);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsPrefix(string src, string target, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool IsSuffix(string src, string target, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int IndexOf(string s, string target, int start, int length, CompareOptions opt);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int LastIndexOf(string s, string target, int start, int length, CompareOptions opt);
}

// Namespace: 
internal struct CultureData.NumberFormatEntryManaged // TypeDefIndex: 1347
{
	// Fields
	internal int currency_decimal_digits; // 0x0
	internal int currency_decimal_separator; // 0x4
	internal int currency_group_separator; // 0x8
	internal int currency_group_sizes0; // 0xC
	internal int currency_group_sizes1; // 0x10
	internal int currency_negative_pattern; // 0x14
	internal int currency_positive_pattern; // 0x18
	internal int currency_symbol; // 0x1C
	internal int nan_symbol; // 0x20
	internal int negative_infinity_symbol; // 0x24
	internal int negative_sign; // 0x28
	internal int number_decimal_digits; // 0x2C
	internal int number_decimal_separator; // 0x30
	internal int number_group_separator; // 0x34
	internal int number_group_sizes0; // 0x38
	internal int number_group_sizes1; // 0x3C
	internal int number_negative_pattern; // 0x40
	internal int per_mille_symbol; // 0x44
	internal int percent_negative_pattern; // 0x48
	internal int percent_positive_pattern; // 0x4C
	internal int percent_symbol; // 0x50
	internal int positive_infinity_symbol; // 0x54
	internal int positive_sign; // 0x58
}

// Namespace: System.Globalization
internal class CultureData // TypeDefIndex: 1348
{
	// Fields
	private string sAM1159; // 0x10
	private string sPM2359; // 0x18
	private string sTimeSeparator; // 0x20
	private string[] saLongTimes; // 0x28
	private string[] saShortTimes; // 0x30
	private int iFirstDayOfWeek; // 0x38
	private int iFirstWeekOfYear; // 0x3C
	private int[] waCalendars; // 0x40
	private CalendarData[] calendars; // 0x48
	private string sISO639Language; // 0x50
	private readonly string sRealName; // 0x58
	private bool bUseOverrides; // 0x60
	private int calendarId; // 0x64
	private int numberIndex; // 0x68
	private int iDefaultAnsiCodePage; // 0x6C
	private int iDefaultOemCodePage; // 0x70
	private int iDefaultMacCodePage; // 0x74
	private int iDefaultEbcdicCodePage; // 0x78
	private bool isRightToLeft; // 0x7C
	private string sListSeparator; // 0x80
	private static CultureData s_Invariant; // 0x0

	// Properties
	public static CultureData Invariant { get; }
	internal string[] LongTimes { get; }
	internal string[] ShortTimes { get; }
	internal string SISO639LANGNAME { get; }
	internal int IFIRSTDAYOFWEEK { get; }
	internal int IFIRSTWEEKOFYEAR { get; }
	internal string SAM1159 { get; }
	internal string SPM2359 { get; }
	internal string TimeSeparator { get; }
	internal int[] CalendarIds { get; }
	internal bool IsInvariantCulture { get; }
	internal string CultureName { get; }
	internal string SCOMPAREINFO { get; }
	internal string STEXTINFO { get; }
	internal bool UseUserOverride { get; }

	// Methods

	// RVA: 0x182D330 Offset: 0x1829330 VA: 0x182D330
	private void .ctor(string name) { }

	// RVA: 0x182D360 Offset: 0x1829360 VA: 0x182D360
	public static CultureData get_Invariant() { }

	// RVA: 0x182D72C Offset: 0x182972C VA: 0x182D72C
	public static CultureData GetCultureData(string cultureName, bool useUserOverride) { }

	// RVA: 0x182D81C Offset: 0x182981C VA: 0x182D81C
	public static CultureData GetCultureData(string cultureName, bool useUserOverride, int datetimeIndex, int calendarId, int numberIndex, string iso2lang, int ansiCodePage, int oemCodePage, int macCodePage, int ebcdicCodePage, bool rightToLeft, string listSeparator) { }

	// RVA: 0x182D950 Offset: 0x1829950 VA: 0x182D950
	private void fill_culture_data(int datetimeIndex) { }

	// RVA: 0x182D954 Offset: 0x1829954 VA: 0x182D954
	public CalendarData GetCalendar(int calendarId) { }

	// RVA: 0x182DA88 Offset: 0x1829A88 VA: 0x182DA88
	internal string[] get_LongTimes() { }

	// RVA: 0x182DAA0 Offset: 0x1829AA0 VA: 0x182DAA0
	internal string[] get_ShortTimes() { }

	// RVA: 0x182DAB8 Offset: 0x1829AB8 VA: 0x182DAB8
	internal string get_SISO639LANGNAME() { }

	// RVA: 0x182DAC0 Offset: 0x1829AC0 VA: 0x182DAC0
	internal int get_IFIRSTDAYOFWEEK() { }

	// RVA: 0x182DAC8 Offset: 0x1829AC8 VA: 0x182DAC8
	internal int get_IFIRSTWEEKOFYEAR() { }

	// RVA: 0x182DAD0 Offset: 0x1829AD0 VA: 0x182DAD0
	internal string get_SAM1159() { }

	// RVA: 0x182DAD8 Offset: 0x1829AD8 VA: 0x182DAD8
	internal string get_SPM2359() { }

	// RVA: 0x182DAE0 Offset: 0x1829AE0 VA: 0x182DAE0
	internal string get_TimeSeparator() { }

	// RVA: 0x182DAE8 Offset: 0x1829AE8 VA: 0x182DAE8
	internal int[] get_CalendarIds() { }

	// RVA: 0x182DCB0 Offset: 0x1829CB0 VA: 0x182DCB0
	internal CalendarId[] GetCalendarIds() { }

	// RVA: 0x182DD80 Offset: 0x1829D80 VA: 0x182DD80
	internal bool get_IsInvariantCulture() { }

	// RVA: 0x182DD8C Offset: 0x1829D8C VA: 0x182DD8C
	internal string get_CultureName() { }

	// RVA: 0x182DD94 Offset: 0x1829D94 VA: 0x182DD94
	internal string get_SCOMPAREINFO() { }

	// RVA: 0x182DDD4 Offset: 0x1829DD4 VA: 0x182DDD4
	internal string get_STEXTINFO() { }

	// RVA: 0x182DDDC Offset: 0x1829DDC VA: 0x182DDDC
	internal bool get_UseUserOverride() { }

	// RVA: 0x182DDE4 Offset: 0x1829DE4 VA: 0x182DDE4
	internal string[] EraNames(int calendarId) { }

	// RVA: 0x182DE00 Offset: 0x1829E00 VA: 0x182DE00
	internal string[] AbbrevEraNames(int calendarId) { }

	// RVA: 0x182DE1C Offset: 0x1829E1C VA: 0x182DE1C
	internal string[] AbbreviatedEnglishEraNames(int calendarId) { }

	// RVA: 0x182DE38 Offset: 0x1829E38 VA: 0x182DE38
	internal string[] ShortDates(int calendarId) { }

	// RVA: 0x182DE54 Offset: 0x1829E54 VA: 0x182DE54
	internal string[] LongDates(int calendarId) { }

	// RVA: 0x182DE70 Offset: 0x1829E70 VA: 0x182DE70
	internal string[] YearMonths(int calendarId) { }

	// RVA: 0x182DE8C Offset: 0x1829E8C VA: 0x182DE8C
	internal string[] DayNames(int calendarId) { }

	// RVA: 0x182DEA8 Offset: 0x1829EA8 VA: 0x182DEA8
	internal string[] AbbreviatedDayNames(int calendarId) { }

	// RVA: 0x182DEC4 Offset: 0x1829EC4 VA: 0x182DEC4
	internal string[] MonthNames(int calendarId) { }

	// RVA: 0x182DEE0 Offset: 0x1829EE0 VA: 0x182DEE0
	internal string[] GenitiveMonthNames(int calendarId) { }

	// RVA: 0x182DEFC Offset: 0x1829EFC VA: 0x182DEFC
	internal string[] AbbreviatedMonthNames(int calendarId) { }

	// RVA: 0x182DF18 Offset: 0x1829F18 VA: 0x182DF18
	internal string[] AbbreviatedGenitiveMonthNames(int calendarId) { }

	// RVA: 0x182DF34 Offset: 0x1829F34 VA: 0x182DF34
	internal string[] LeapYearMonthNames(int calendarId) { }

	// RVA: 0x182DF50 Offset: 0x1829F50 VA: 0x182DF50
	internal string MonthDay(int calendarId) { }

	// RVA: 0x182DF6C Offset: 0x1829F6C VA: 0x182DF6C
	internal string DateSeparator(int calendarId) { }

	// RVA: 0x182E018 Offset: 0x182A018 VA: 0x182E018
	private static string GetDateSeparator(string format) { }

	// RVA: 0x182E060 Offset: 0x182A060 VA: 0x182E060
	private static string GetSeparator(string format, string timeParts) { }

	// RVA: 0x182E140 Offset: 0x182A140 VA: 0x182E140
	private static int IndexOfTimePart(string format, int startIndex, string timeParts) { }

	// RVA: 0x182E22C Offset: 0x182A22C VA: 0x182E22C
	private static string UnescapeNlsString(string str, int start, int end) { }

	// RVA: 0x182E3D0 Offset: 0x182A3D0 VA: 0x182E3D0
	internal static string[] ReescapeWin32Strings(string[] array) { }

	// RVA: 0x182E3D4 Offset: 0x182A3D4 VA: 0x182E3D4
	internal static string ReescapeWin32String(string str) { }

	// RVA: 0x182E3D8 Offset: 0x182A3D8 VA: 0x182E3D8
	private static int strlen(byte* s) { }

	// RVA: 0x182E3F0 Offset: 0x182A3F0 VA: 0x182E3F0
	private static string idx2string(byte* data, int idx) { }

	// RVA: 0x182E434 Offset: 0x182A434 VA: 0x182E434
	private int[] create_group_sizes_array(int gs0, int gs1) { }

	// RVA: 0x182E4E8 Offset: 0x182A4E8 VA: 0x182E4E8
	internal void GetNFIValues(NumberFormatInfo nfi) { }

	// RVA: 0x182E740 Offset: 0x182A740 VA: 0x182E740
	private static byte* fill_number_data(int index, ref CultureData.NumberFormatEntryManaged nfe) { }
}

// Namespace: System.Globalization
[Serializable]
internal class CodePageDataItem // TypeDefIndex: 1349
{
	// Fields
	internal int m_dataIndex; // 0x10
	internal int m_uiFamilyCodePage; // 0x14
	internal string m_webName; // 0x18
	internal string m_headerName; // 0x20
	internal string m_bodyName; // 0x28
	internal uint m_flags; // 0x30
	private static readonly char[] sep; // 0x0

	// Properties
	public string WebName { get; }
	public virtual int UIFamilyCodePage { get; }
	public string HeaderName { get; }
	public string BodyName { get; }
	public uint Flags { get; }

	// Methods

	// RVA: 0x182E744 Offset: 0x182A744 VA: 0x182E744
	internal void .ctor(int dataIndex) { }

	// RVA: 0x182E7E8 Offset: 0x182A7E8 VA: 0x182E7E8
	internal static string CreateString(string pStrings, uint index) { }

	// RVA: 0x182E89C Offset: 0x182A89C VA: 0x182E89C
	public string get_WebName() { }

	// RVA: 0x182E96C Offset: 0x182A96C VA: 0x182E96C Slot: 4
	public virtual int get_UIFamilyCodePage() { }

	// RVA: 0x182E974 Offset: 0x182A974 VA: 0x182E974
	public string get_HeaderName() { }

	// RVA: 0x182EA44 Offset: 0x182AA44 VA: 0x182EA44
	public string get_BodyName() { }

	// RVA: 0x182EB14 Offset: 0x182AB14 VA: 0x182EB14
	public uint get_Flags() { }

	// RVA: 0x182EB1C Offset: 0x182AB1C VA: 0x182EB1C
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal static class EncodingTable // TypeDefIndex: 1350
{
	// Fields
	internal static InternalEncodingDataItem[] encodingDataPtr; // 0x0
	internal static InternalCodePageDataItem[] codePageDataPtr; // 0x8
	private static int lastEncodingItem; // 0x10
	private static Dictionary<string, int> hashByName; // 0x18
	private static Dictionary<int, CodePageDataItem> hashByCodePage; // 0x20

	// Methods

	// RVA: 0x182EBAC Offset: 0x182ABAC VA: 0x182EBAC
	private static int GetNumEncodingItems() { }

	// RVA: 0x182EC10 Offset: 0x182AC10 VA: 0x182EC10
	private static InternalEncodingDataItem ENC(string name, ushort cp) { }

	// RVA: 0x182EC40 Offset: 0x182AC40 VA: 0x182EC40
	private static InternalCodePageDataItem MapCodePageDataItem(ushort cp, ushort fcp, string names, uint flags) { }

	// RVA: 0x182EC78 Offset: 0x182AC78 VA: 0x182EC78
	private static void .cctor() { }

	// RVA: 0x1838328 Offset: 0x1834328 VA: 0x1838328
	private static int internalGetCodePageFromName(string name) { }

	// RVA: 0x1838584 Offset: 0x1834584 VA: 0x1838584
	internal static int GetCodePageFromName(string name) { }

	// RVA: 0x1838808 Offset: 0x1834808 VA: 0x1838808
	internal static CodePageDataItem GetCodePageDataItem(int codepage) { }
}

// Namespace: System.Globalization
internal struct InternalEncodingDataItem // TypeDefIndex: 1351
{
	// Fields
	internal string webName; // 0x0
	internal ushort codePage; // 0x8
}

// Namespace: System.Globalization
internal struct InternalCodePageDataItem // TypeDefIndex: 1352
{
	// Fields
	internal ushort codePage; // 0x0
	internal ushort uiFamilyCodePage; // 0x2
	internal uint flags; // 0x4
	internal string Names; // 0x8
}

// Namespace: System.Globalization
internal static class TextInfoToUpperData // TypeDefIndex: 1353
{
	// Fields
	public static readonly char[] range_00e0_0586; // 0x0
	public static readonly char[] range_1e01_1ff3; // 0x8
	public static readonly char[] range_2170_2184; // 0x10
	public static readonly char[] range_24d0_24e9; // 0x18
	public static readonly char[] range_2c30_2ce3; // 0x20
	public static readonly char[] range_2d00_2d25; // 0x28
	public static readonly char[] range_a641_a697; // 0x30
	public static readonly char[] range_a723_a78c; // 0x38

	// Methods

	// RVA: 0x1838ABC Offset: 0x1834ABC VA: 0x1838ABC
	private static void .cctor() { }
}

// Namespace: System.Globalization
internal static class TextInfoToLowerData // TypeDefIndex: 1354
{
	// Fields
	public static readonly char[] range_00c0_0556; // 0x0
	public static readonly char[] range_10a0_10c5; // 0x8
	public static readonly char[] range_1e00_1ffc; // 0x10
	public static readonly char[] range_2160_216f; // 0x18
	public static readonly char[] range_24b6_24cf; // 0x20
	public static readonly char[] range_2c00_2c2e; // 0x28
	public static readonly char[] range_2c60_2ce2; // 0x30
	public static readonly char[] range_a640_a696; // 0x38
	public static readonly char[] range_a722_a78b; // 0x40

	// Methods

	// RVA: 0x1838D50 Offset: 0x1834D50 VA: 0x1838D50
	private static void .cctor() { }
}

// Namespace: 
private struct CultureInfo.Data // TypeDefIndex: 1355
{
	// Fields
	public int ansi; // 0x0
	public int ebcdic; // 0x4
	public int mac; // 0x8
	public int oem; // 0xC
	public bool right_to_left; // 0x10
	public byte list_sep; // 0x11
}

// Namespace: 
private sealed class CultureInfo.OnCultureInfoChangedDelegate : MulticastDelegate // TypeDefIndex: 1356
{
	// Methods

	// RVA: 0x183E204 Offset: 0x183A204 VA: 0x183E204
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x183E2B4 Offset: 0x183A2B4 VA: 0x183E2B4 Slot: 12
	public virtual void Invoke(string language) { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class CultureInfo : ICloneable, IFormatProvider // TypeDefIndex: 1357
{
	// Fields
	private static CultureInfo invariant_culture_info; // 0x0
	private static object shared_table_lock; // 0x8
	private static CultureInfo default_current_culture; // 0x10
	private bool m_isReadOnly; // 0x10
	private int cultureID; // 0x14
	private int parent_lcid; // 0x18
	private int datetime_index; // 0x1C
	private int number_index; // 0x20
	private int default_calendar_type; // 0x24
	private bool m_useUserOverride; // 0x28
	internal NumberFormatInfo numInfo; // 0x30
	internal DateTimeFormatInfo dateTimeInfo; // 0x38
	private TextInfo textInfo; // 0x40
	internal string m_name; // 0x48
	private string englishname; // 0x50
	private string nativename; // 0x58
	private string iso3lang; // 0x60
	private string iso2lang; // 0x68
	private string win3lang; // 0x70
	private string territory; // 0x78
	private string[] native_calendar_names; // 0x80
	private CompareInfo compareInfo; // 0x88
	private readonly void* textinfo_data; // 0x90
	private int m_dataItem; // 0x98
	private Calendar calendar; // 0xA0
	private CultureInfo parent_culture; // 0xA8
	private bool constructed; // 0xB0
	internal byte[] cached_serialized_form; // 0xB8
	internal CultureData m_cultureData; // 0xC0
	internal bool m_isInherited; // 0xC8
	internal const int InvariantCultureId = 127;
	private const int CalendarTypeBits = 8;
	internal const int LOCALE_INVARIANT = 127;
	private const string MSG_READONLY = "This instance is read only";
	private static CultureInfo s_DefaultThreadCurrentUICulture; // 0x18
	private static CultureInfo s_DefaultThreadCurrentCulture; // 0x20
	private static Dictionary<int, CultureInfo> shared_by_number; // 0x28
	private static Dictionary<string, CultureInfo> shared_by_name; // 0x30
	private static CultureInfo s_UserPreferredCultureInfoInAppX; // 0x38
	internal static readonly bool IsTaiwanSku; // 0x40

	// Properties
	internal CultureData _cultureData { get; }
	internal bool _isInherited { get; }
	public static CultureInfo InvariantCulture { get; }
	public static CultureInfo CurrentCulture { get; }
	public static CultureInfo CurrentUICulture { get; }
	internal string Territory { get; }
	internal string _name { get; }
	public virtual int LCID { get; }
	public virtual string Name { get; }
	public virtual Calendar Calendar { get; }
	public virtual CultureInfo Parent { get; }
	public virtual TextInfo TextInfo { get; }
	public virtual CompareInfo CompareInfo { get; }
	public virtual bool IsNeutralCulture { get; }
	public virtual NumberFormatInfo NumberFormat { get; set; }
	public virtual DateTimeFormatInfo DateTimeFormat { get; set; }
	public virtual string EnglishName { get; }
	internal int CalendarType { get; }
	public static CultureInfo DefaultThreadCurrentCulture { get; }
	public static CultureInfo DefaultThreadCurrentUICulture { get; }
	internal string SortName { get; }
	internal static CultureInfo UserDefaultUICulture { get; }
	internal static CultureInfo UserDefaultCulture { get; }

	// Methods

	// RVA: 0x18390C8 Offset: 0x18350C8 VA: 0x18390C8
	internal CultureData get__cultureData() { }

	// RVA: 0x18390D0 Offset: 0x18350D0 VA: 0x18390D0
	internal bool get__isInherited() { }

	// RVA: 0x18390D8 Offset: 0x18350D8 VA: 0x18390D8
	public static CultureInfo get_InvariantCulture() { }

	// RVA: 0x1838564 Offset: 0x1834564 VA: 0x1838564
	public static CultureInfo get_CurrentCulture() { }

	// RVA: 0x1839138 Offset: 0x1835138 VA: 0x1839138
	public static CultureInfo get_CurrentUICulture() { }

	// RVA: 0x1839158 Offset: 0x1835158 VA: 0x1839158
	internal static CultureInfo ConstructCurrentCulture() { }

	// RVA: 0x1839590 Offset: 0x1835590 VA: 0x1839590
	internal static CultureInfo ConstructCurrentUICulture() { }

	// RVA: 0x18395DC Offset: 0x18355DC VA: 0x18395DC
	internal string get_Territory() { }

	// RVA: 0x18395E4 Offset: 0x18355E4 VA: 0x18395E4
	internal string get__name() { }

	// RVA: 0x18395EC Offset: 0x18355EC VA: 0x18395EC Slot: 6
	public virtual int get_LCID() { }

	// RVA: 0x18395F4 Offset: 0x18355F4 VA: 0x18395F4 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x18395FC Offset: 0x18355FC VA: 0x18395FC Slot: 8
	public virtual Calendar get_Calendar() { }

	// RVA: 0x18398D8 Offset: 0x18358D8 VA: 0x18398D8 Slot: 9
	public virtual CultureInfo get_Parent() { }

	// RVA: 0x1839B64 Offset: 0x1835B64 VA: 0x1839B64 Slot: 10
	public virtual TextInfo get_TextInfo() { }

	// RVA: 0x1839D0C Offset: 0x1835D0C VA: 0x1839D0C Slot: 11
	public virtual object Clone() { }

	// RVA: 0x1839EB4 Offset: 0x1835EB4 VA: 0x1839EB4 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1839F54 Offset: 0x1835F54 VA: 0x1839F54
	public static CultureInfo[] GetCultures(CultureTypes types) { }

	// RVA: 0x183A1C0 Offset: 0x18361C0 VA: 0x183A1C0
	private CultureInfo.Data GetTextInfoData() { }

	// RVA: 0x183A248 Offset: 0x1836248 VA: 0x183A248 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x183A254 Offset: 0x1836254 VA: 0x183A254 Slot: 3
	public override string ToString() { }

	// RVA: 0x183A25C Offset: 0x183625C VA: 0x183A25C Slot: 12
	public virtual CompareInfo get_CompareInfo() { }

	// RVA: 0x183A3B8 Offset: 0x18363B8 VA: 0x183A3B8 Slot: 13
	public virtual bool get_IsNeutralCulture() { }

	// RVA: 0x183A400 Offset: 0x1836400 VA: 0x183A400
	private void CheckNeutral() { }

	// RVA: 0x183A404 Offset: 0x1836404 VA: 0x183A404 Slot: 14
	public virtual NumberFormatInfo get_NumberFormat() { }

	// RVA: 0x183A4A8 Offset: 0x18364A8 VA: 0x183A4A8 Slot: 15
	public virtual void set_NumberFormat(NumberFormatInfo value) { }

	// RVA: 0x183A578 Offset: 0x1836578 VA: 0x183A578 Slot: 16
	public virtual DateTimeFormatInfo get_DateTimeFormat() { }

	// RVA: 0x183A6E0 Offset: 0x18366E0 VA: 0x183A6E0 Slot: 17
	public virtual void set_DateTimeFormat(DateTimeFormatInfo value) { }

	// RVA: 0x183A7B0 Offset: 0x18367B0 VA: 0x183A7B0 Slot: 18
	public virtual string get_EnglishName() { }

	// RVA: 0x183A7E0 Offset: 0x18367E0 VA: 0x183A7E0 Slot: 19
	public virtual object GetFormat(Type formatType) { }

	// RVA: 0x1839694 Offset: 0x1835694 VA: 0x1839694
	private void Construct() { }

	// RVA: 0x183A8EC Offset: 0x18368EC VA: 0x183A8EC
	private bool construct_internal_locale_from_lcid(int lcid) { }

	// RVA: 0x183A8F0 Offset: 0x18368F0 VA: 0x183A8F0
	private bool construct_internal_locale_from_name(string name) { }

	// RVA: 0x1839344 Offset: 0x1835344 VA: 0x1839344
	private static string get_current_locale_name() { }

	// RVA: 0x183A1BC Offset: 0x18361BC VA: 0x183A1BC
	private static CultureInfo[] internal_get_cultures(bool neutral, bool specific, bool installed) { }

	// RVA: 0x183A8F4 Offset: 0x18368F4 VA: 0x183A8F4
	private void ConstructInvariant(bool read_only) { }

	// RVA: 0x1839C90 Offset: 0x1835C90 VA: 0x1839C90
	private TextInfo CreateTextInfo(bool readOnly) { }

	// RVA: 0x1839B58 Offset: 0x1835B58 VA: 0x1839B58
	public void .ctor(int culture) { }

	// RVA: 0x183AAA8 Offset: 0x1836AA8 VA: 0x183AAA8
	public void .ctor(int culture, bool useUserOverride) { }

	// RVA: 0x183AAB0 Offset: 0x1836AB0 VA: 0x183AAB0
	private void .ctor(int culture, bool useUserOverride, bool read_only) { }

	// RVA: 0x1839B4C Offset: 0x1835B4C VA: 0x1839B4C
	public void .ctor(string name) { }

	// RVA: 0x182D814 Offset: 0x1829814 VA: 0x182D814
	public void .ctor(string name, bool useUserOverride) { }

	// RVA: 0x183AD58 Offset: 0x1836D58 VA: 0x183AD58
	private void .ctor(string name, bool useUserOverride, bool read_only) { }

	// RVA: 0x183B11C Offset: 0x183711C VA: 0x183B11C
	private void .ctor() { }

	// RVA: 0x183B13C Offset: 0x183713C VA: 0x183B13C
	private static void insert_into_shared_tables(CultureInfo c) { }

	// RVA: 0x183B2C8 Offset: 0x18372C8 VA: 0x183B2C8
	public static CultureInfo GetCultureInfo(int culture) { }

	// RVA: 0x183B4E4 Offset: 0x18374E4 VA: 0x183B4E4
	public static CultureInfo GetCultureInfo(string name) { }

	// RVA: 0x183B6E8 Offset: 0x18376E8 VA: 0x183B6E8
	internal static CultureInfo CreateCulture(string name, bool reference) { }

	// RVA: 0x1839348 Offset: 0x1835348 VA: 0x1839348
	public static CultureInfo CreateSpecificCulture(string name) { }

	// RVA: 0x183AFB4 Offset: 0x1836FB4 VA: 0x183AFB4
	private bool ConstructLocaleFromName(string name) { }

	// RVA: 0x183B75C Offset: 0x183775C VA: 0x183B75C
	private static CultureInfo CreateSpecificCultureFromNeutral(string name) { }

	// RVA: 0x183A1D8 Offset: 0x18361D8 VA: 0x183A1D8
	internal int get_CalendarType() { }

	// RVA: 0x18396B4 Offset: 0x18356B4 VA: 0x18396B4
	private static Calendar CreateCalendar(int calendarType) { }

	// RVA: 0x183B054 Offset: 0x1837054 VA: 0x183B054
	private static Exception CreateNotFoundException(string name) { }

	// RVA: 0x183DF0C Offset: 0x1839F0C VA: 0x183DF0C
	public static CultureInfo get_DefaultThreadCurrentCulture() { }

	// RVA: 0x183DF6C Offset: 0x1839F6C VA: 0x183DF6C
	public static CultureInfo get_DefaultThreadCurrentUICulture() { }

	// RVA: 0x183DFCC Offset: 0x1839FCC VA: 0x183DFCC
	internal string get_SortName() { }

	// RVA: 0x183DFD4 Offset: 0x1839FD4 VA: 0x183DFD4
	internal static CultureInfo get_UserDefaultUICulture() { }

	// RVA: 0x183E020 Offset: 0x183A020 VA: 0x183E020
	internal static CultureInfo get_UserDefaultCulture() { }

	// RVA: 0x183E06C Offset: 0x183A06C VA: 0x183E06C
	private static extern void InitializeUserPreferredCultureInfoInAppX(CultureInfo.OnCultureInfoChangedDelegate onCultureInfoChangedInAppX) { }

	[MonoPInvokeCallback(typeof(CultureInfo.OnCultureInfoChangedDelegate))]
	// RVA: 0x1839028 Offset: 0x1835028 VA: 0x1839028
	private static void OnCultureInfoChangedInAppX(string language) { }

	// RVA: 0x183E07C Offset: 0x183A07C VA: 0x183E07C
	internal static CultureInfo GetCultureInfoForUserPreferredLanguageInAppX() { }

	// RVA: 0x183E154 Offset: 0x183A154 VA: 0x183E154
	private static void .cctor() { }
}

// Namespace: System.Globalization
public sealed class IdnMapping // TypeDefIndex: 1358
{
	// Fields
	private bool allow_unassigned; // 0x10
	private bool use_std3; // 0x11
	private Punycode puny; // 0x18

	// Methods

	// RVA: 0x183E2C8 Offset: 0x183A2C8 VA: 0x183E2C8
	public void .ctor() { }

	// RVA: 0x183E39C Offset: 0x183A39C VA: 0x183E39C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x183E41C Offset: 0x183A41C VA: 0x183E41C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x183E42C Offset: 0x183A42C VA: 0x183E42C
	public string GetAscii(string unicode) { }

	// RVA: 0x183E488 Offset: 0x183A488 VA: 0x183E488
	public string GetAscii(string unicode, int index, int count) { }

	// RVA: 0x183E550 Offset: 0x183A550 VA: 0x183E550
	private string Convert(string input, int index, int count, bool toAscii) { }

	// RVA: 0x183E768 Offset: 0x183A768 VA: 0x183E768
	private string ToAscii(string s, int offset) { }

	// RVA: 0x183F19C Offset: 0x183B19C VA: 0x183F19C
	private void VerifyLength(string s, int offset) { }

	// RVA: 0x183EB6C Offset: 0x183AB6C VA: 0x183EB6C
	private string NamePrep(string s, int offset) { }

	// RVA: 0x183F260 Offset: 0x183B260 VA: 0x183F260
	private void VerifyProhibitedCharacters(string s, int offset) { }

	// RVA: 0x183EC84 Offset: 0x183AC84 VA: 0x183EC84
	private void VerifyStd3AsciiRules(string s, int offset) { }

	// RVA: 0x183F450 Offset: 0x183B450 VA: 0x183F450
	public string GetUnicode(string ascii) { }

	// RVA: 0x183F4AC Offset: 0x183B4AC VA: 0x183F4AC
	public string GetUnicode(string ascii, int index, int count) { }

	// RVA: 0x183E99C Offset: 0x183A99C VA: 0x183E99C
	private string ToUnicode(string s, int offset) { }
}

// Namespace: System.Globalization
internal class Bootstring // TypeDefIndex: 1359
{
	// Fields
	private readonly char delimiter; // 0x10
	private readonly int base_num; // 0x14
	private readonly int tmin; // 0x18
	private readonly int tmax; // 0x1C
	private readonly int skew; // 0x20
	private readonly int damp; // 0x24
	private readonly int initial_bias; // 0x28
	private readonly int initial_n; // 0x2C

	// Methods

	// RVA: 0x183F84C Offset: 0x183B84C VA: 0x183F84C
	public void .ctor(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN) { }

	// RVA: 0x183EE54 Offset: 0x183AE54 VA: 0x183EE54
	public string Encode(string s, int offset) { }

	// RVA: 0x183F8B8 Offset: 0x183B8B8 VA: 0x183F8B8
	private char EncodeDigit(int d) { }

	// RVA: 0x183F944 Offset: 0x183B944 VA: 0x183F944
	private int DecodeDigit(char c) { }

	// RVA: 0x183F8D0 Offset: 0x183B8D0 VA: 0x183F8D0
	private int Adapt(int delta, int numPoints, bool firstTime) { }

	// RVA: 0x183F574 Offset: 0x183B574 VA: 0x183F574
	public string Decode(string s, int offset) { }
}

// Namespace: System.Globalization
internal class Punycode : Bootstring // TypeDefIndex: 1360
{
	// Methods

	// RVA: 0x183E35C Offset: 0x183A35C VA: 0x183E35C
	public void .ctor() { }
}

// Namespace: System.Globalization
[ComVisible(True)]
[Serializable]
public class RegionInfo // TypeDefIndex: 1361
{
	// Fields
	private static RegionInfo currentRegion; // 0x0
	private int regionId; // 0x10
	private string iso2Name; // 0x18
	private string iso3Name; // 0x20
	private string win3Name; // 0x28
	private string englishName; // 0x30
	private string nativeName; // 0x38
	private string currencySymbol; // 0x40
	private string isoCurrencySymbol; // 0x48
	private string currencyEnglishName; // 0x50
	private string currencyNativeName; // 0x58

	// Properties
	public static RegionInfo CurrentRegion { get; }
	[ComVisible(False)]
	public virtual string CurrencyEnglishName { get; }
	public virtual string CurrencySymbol { get; }
	[MonoTODO("DisplayName currently only returns the EnglishName")]
	public virtual string DisplayName { get; }
	public virtual string EnglishName { get; }
	[ComVisible(False)]
	public virtual int GeoId { get; }
	public virtual bool IsMetric { get; }
	public virtual string ISOCurrencySymbol { get; }
	[ComVisible(False)]
	public virtual string NativeName { get; }
	[ComVisible(False)]
	public virtual string CurrencyNativeName { get; }
	public virtual string Name { get; }
	public virtual string ThreeLetterISORegionName { get; }
	public virtual string ThreeLetterWindowsRegionName { get; }
	public virtual string TwoLetterISORegionName { get; }

	// Methods

	// RVA: 0x183F984 Offset: 0x183B984 VA: 0x183F984
	public static RegionInfo get_CurrentRegion() { }

	// RVA: 0x183FC38 Offset: 0x183BC38 VA: 0x183FC38
	public void .ctor(int culture) { }

	// RVA: 0x183FDE8 Offset: 0x183BDE8 VA: 0x183FDE8
	public void .ctor(string name) { }

	// RVA: 0x183FA48 Offset: 0x183BA48 VA: 0x183FA48
	private void .ctor(CultureInfo ci) { }

	// RVA: 0x183FD40 Offset: 0x183BD40 VA: 0x183FD40
	private bool GetByTerritory(CultureInfo ci) { }

	// RVA: 0x183FF20 Offset: 0x183BF20 VA: 0x183FF20
	private bool construct_internal_region_from_name(string name) { }

	// RVA: 0x183FF24 Offset: 0x183BF24 VA: 0x183FF24 Slot: 4
	public virtual string get_CurrencyEnglishName() { }

	// RVA: 0x183FF2C Offset: 0x183BF2C VA: 0x183FF2C Slot: 5
	public virtual string get_CurrencySymbol() { }

	// RVA: 0x183FF34 Offset: 0x183BF34 VA: 0x183FF34 Slot: 6
	public virtual string get_DisplayName() { }

	// RVA: 0x183FF3C Offset: 0x183BF3C VA: 0x183FF3C Slot: 7
	public virtual string get_EnglishName() { }

	// RVA: 0x183FF44 Offset: 0x183BF44 VA: 0x183FF44 Slot: 8
	public virtual int get_GeoId() { }

	// RVA: 0x183FF4C Offset: 0x183BF4C VA: 0x183FF4C Slot: 9
	public virtual bool get_IsMetric() { }

	// RVA: 0x183FFD8 Offset: 0x183BFD8 VA: 0x183FFD8 Slot: 10
	public virtual string get_ISOCurrencySymbol() { }

	// RVA: 0x183FFE0 Offset: 0x183BFE0 VA: 0x183FFE0 Slot: 11
	public virtual string get_NativeName() { }

	// RVA: 0x183FFE8 Offset: 0x183BFE8 VA: 0x183FFE8 Slot: 12
	public virtual string get_CurrencyNativeName() { }

	// RVA: 0x183FFF0 Offset: 0x183BFF0 VA: 0x183FFF0 Slot: 13
	public virtual string get_Name() { }

	// RVA: 0x183FFF8 Offset: 0x183BFF8 VA: 0x183FFF8 Slot: 14
	public virtual string get_ThreeLetterISORegionName() { }

	// RVA: 0x1840000 Offset: 0x183C000 VA: 0x1840000 Slot: 15
	public virtual string get_ThreeLetterWindowsRegionName() { }

	// RVA: 0x1840008 Offset: 0x183C008 VA: 0x1840008 Slot: 16
	public virtual string get_TwoLetterISORegionName() { }

	// RVA: 0x1840010 Offset: 0x183C010 VA: 0x1840010 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x18400CC Offset: 0x183C0CC VA: 0x18400CC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18400F8 Offset: 0x183C0F8 VA: 0x18400F8 Slot: 3
	public override string ToString() { }

	// RVA: 0x1840108 Offset: 0x183C108 VA: 0x1840108
	internal static void ClearCachedData() { }
}

// Namespace: System.Globalization
internal class FormatProvider // TypeDefIndex: 7836
{
	// Methods

	// RVA: 0x1B39D1C Offset: 0x1B35D1C VA: 0x1B39D1C
	internal static void FormatBigInteger(ref ValueStringBuilder sb, int precision, int scale, bool sign, ReadOnlySpan<char> format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) { }

	// RVA: 0x1B380E8 Offset: 0x1B340E8 VA: 0x1B380E8
	internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) { }
}
