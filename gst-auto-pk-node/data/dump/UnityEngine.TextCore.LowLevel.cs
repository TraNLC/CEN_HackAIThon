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

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[Flags]
public enum GlyphLoadFlags // TypeDefIndex: 7793
{
	// Fields
	public int value__; // 0x0
	public const GlyphLoadFlags LOAD_DEFAULT = 0;
	public const GlyphLoadFlags LOAD_NO_SCALE = 1;
	public const GlyphLoadFlags LOAD_NO_HINTING = 2;
	public const GlyphLoadFlags LOAD_RENDER = 4;
	public const GlyphLoadFlags LOAD_NO_BITMAP = 8;
	public const GlyphLoadFlags LOAD_FORCE_AUTOHINT = 32;
	public const GlyphLoadFlags LOAD_MONOCHROME = 4096;
	public const GlyphLoadFlags LOAD_NO_AUTOHINT = 32768;
	public const GlyphLoadFlags LOAD_COLOR = 1048576;
	public const GlyphLoadFlags LOAD_COMPUTE_METRICS = 2097152;
	public const GlyphLoadFlags LOAD_BITMAP_METRICS_ONLY = 4194304;
}

// Namespace: UnityEngine.TextCore.LowLevel
[Flags]
[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
internal enum GlyphRasterModes // TypeDefIndex: 7794
{
	// Fields
	public int value__; // 0x0
	public const GlyphRasterModes RASTER_MODE_8BIT = 1;
	public const GlyphRasterModes RASTER_MODE_MONO = 2;
	public const GlyphRasterModes RASTER_MODE_NO_HINTING = 4;
	public const GlyphRasterModes RASTER_MODE_HINTED = 8;
	public const GlyphRasterModes RASTER_MODE_BITMAP = 16;
	public const GlyphRasterModes RASTER_MODE_SDF = 32;
	public const GlyphRasterModes RASTER_MODE_SDFAA = 64;
	public const GlyphRasterModes RASTER_MODE_MSDF = 256;
	public const GlyphRasterModes RASTER_MODE_MSDFA = 512;
	public const GlyphRasterModes RASTER_MODE_1X = 4096;
	public const GlyphRasterModes RASTER_MODE_8X = 8192;
	public const GlyphRasterModes RASTER_MODE_16X = 16384;
	public const GlyphRasterModes RASTER_MODE_32X = 32768;
	public const GlyphRasterModes RASTER_MODE_COLOR = 65536;
}

// Namespace: UnityEngine.TextCore.LowLevel
public enum FontEngineError // TypeDefIndex: 7795
{
	// Fields
	public int value__; // 0x0
	public const FontEngineError Success = 0;
	public const FontEngineError Invalid_File_Path = 1;
	public const FontEngineError Invalid_File_Format = 2;
	public const FontEngineError Invalid_File_Structure = 3;
	public const FontEngineError Invalid_File = 4;
	public const FontEngineError Invalid_Table = 8;
	public const FontEngineError Invalid_Glyph_Index = 16;
	public const FontEngineError Invalid_Character_Code = 17;
	public const FontEngineError Invalid_Pixel_Size = 23;
	public const FontEngineError Invalid_Library = 33;
	public const FontEngineError Invalid_Face = 35;
	public const FontEngineError Invalid_Library_or_Face = 41;
	public const FontEngineError Atlas_Generation_Cancelled = 100;
	public const FontEngineError Invalid_SharedTextureData = 101;
	public const FontEngineError OpenTypeLayoutLookup_Mismatch = 116;
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
public enum GlyphRenderMode // TypeDefIndex: 7796
{
	// Fields
	public int value__; // 0x0
	public const GlyphRenderMode DEFAULT = 0;
	public const GlyphRenderMode SMOOTH_HINTED = 4121;
	public const GlyphRenderMode SMOOTH = 4117;
	public const GlyphRenderMode COLOR_HINTED = 69656;
	public const GlyphRenderMode COLOR = 69652;
	public const GlyphRenderMode RASTER_HINTED = 4122;
	public const GlyphRenderMode RASTER = 4118;
	public const GlyphRenderMode SDF = 4134;
	public const GlyphRenderMode SDF8 = 8230;
	public const GlyphRenderMode SDF16 = 16422;
	public const GlyphRenderMode SDF32 = 32806;
	public const GlyphRenderMode SDFAA_HINTED = 4169;
	public const GlyphRenderMode SDFAA = 4165;
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
public enum GlyphPackingMode // TypeDefIndex: 7797
{
	// Fields
	public int value__; // 0x0
	public const GlyphPackingMode BestShortSideFit = 0;
	public const GlyphPackingMode BestLongSideFit = 1;
	public const GlyphPackingMode BestAreaFit = 2;
	public const GlyphPackingMode BottomLeftRule = 3;
	public const GlyphPackingMode ContactPointRule = 4;
}

// Namespace: UnityEngine.TextCore.LowLevel
[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
[UsedByNativeCode]
[DebuggerDisplay("{familyName} - {styleName}")]
internal struct FontReference // TypeDefIndex: 7798
{
	// Fields
	public string familyName; // 0x0
	public string styleName; // 0x8
	public int faceIndex; // 0x10
	public string filePath; // 0x18
}

// Namespace: UnityEngine.TextCore.LowLevel
[NativeHeader("Modules/TextCoreFontEngine/Native/FontEngine.h")]
public sealed class FontEngine // TypeDefIndex: 7799
{
	// Fields
	private static Glyph[] s_Glyphs; // 0x0
	private static uint[] s_GlyphIndexes_MarshallingArray_A; // 0x8
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_IN; // 0x10
	private static GlyphMarshallingStruct[] s_GlyphMarshallingStruct_OUT; // 0x18
	private static GlyphRect[] s_FreeGlyphRects; // 0x20
	private static GlyphRect[] s_UsedGlyphRects; // 0x28
	private static LigatureSubstitutionRecord[] s_LigatureSubstitutionRecords_MarshallingArray; // 0x30
	private static GlyphPairAdjustmentRecord[] s_PairAdjustmentRecords_MarshallingArray; // 0x38
	private static MarkToBaseAdjustmentRecord[] s_MarkToBaseAdjustmentRecords_MarshallingArray; // 0x40
	private static MarkToMarkAdjustmentRecord[] s_MarkToMarkAdjustmentRecords_MarshallingArray; // 0x48
	private static Dictionary<uint, Glyph> s_GlyphLookupDictionary; // 0x50

	// Methods

	// RVA: 0x1E9E48C Offset: 0x1E9A48C VA: 0x1E9E48C
	public static FontEngineError LoadFontFace(string filePath) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x1E9E4E0 Offset: 0x1E9A4E0 VA: 0x1E9E4E0
	private static int LoadFontFace_Internal(string filePath) { }

	// RVA: 0x1E9E6B4 Offset: 0x1E9A6B4 VA: 0x1E9E6B4
	public static FontEngineError LoadFontFace(string filePath, float pointSize, int faceIndex) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x1E9E7AC Offset: 0x1E9A7AC VA: 0x1E9E7AC
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal(string filePath, int pointSize, int faceIndex) { }

	// RVA: 0x1E9E9B0 Offset: 0x1E9A9B0 VA: 0x1E9E9B0
	public static FontEngineError LoadFontFace(Font font, float pointSize, int faceIndex) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x1E9EAA8 Offset: 0x1E9AAA8 VA: 0x1E9EAA8
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal(Font font, int pointSize, int faceIndex) { }

	// RVA: 0x1E9EBB4 Offset: 0x1E9ABB4 VA: 0x1E9EBB4
	public static FontEngineError LoadFontFace(string familyName, string styleName, float pointSize) { }

	[NativeMethod(Name = "TextCore::FontEngine::LoadFontFace", IsFreeFunction = True)]
	// RVA: 0x1E9ECAC Offset: 0x1E9ACAC VA: 0x1E9ECAC
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal(string familyName, string styleName, int pointSize) { }

	// RVA: 0x1E9EF70 Offset: 0x1E9AF70 VA: 0x1E9EF70
	public static FontEngineError UnloadFontFace() { }

	[NativeMethod(Name = "TextCore::FontEngine::UnloadFontFace", IsFreeFunction = True)]
	// RVA: 0x1E9EFD8 Offset: 0x1E9AFD8 VA: 0x1E9EFD8
	private static int UnloadFontFace_Internal() { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x1E9F000 Offset: 0x1E9B000 VA: 0x1E9F000
	internal static bool IsColorFontFace() { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x1E9F028 Offset: 0x1E9B028 VA: 0x1E9F028
	internal static bool TryGetSystemFontReference(string familyName, string styleName, out FontReference fontRef) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryGetSystemFontReference", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x1E9F094 Offset: 0x1E9B094 VA: 0x1E9F094
	private static bool TryGetSystemFontReference_Internal(string familyName, string styleName, out FontReference fontRef) { }

	// RVA: 0x1E9F35C Offset: 0x1E9B35C VA: 0x1E9F35C
	public static FaceInfo GetFaceInfo() { }

	[NativeMethod(Name = "TextCore::FontEngine::GetFaceInfo", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x1E9F3FC Offset: 0x1E9B3FC VA: 0x1E9F3FC
	private static int GetFaceInfo_Internal(ref FaceInfo faceInfo) { }

	// RVA: 0x1E9F438 Offset: 0x1E9B438 VA: 0x1E9F438
	public static string[] GetFontFaces() { }

	[NativeMethod(Name = "TextCore::FontEngine::GetFontFaces", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x1E9F4B4 Offset: 0x1E9B4B4 VA: 0x1E9F4B4
	private static string[] GetFontFaces_Internal() { }

	[NativeMethod(Name = "TextCore::FontEngine::GetVariantGlyphIndex", IsThreadSafe = True, IsFreeFunction = True)]
	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x1E9F4DC Offset: 0x1E9B4DC VA: 0x1E9F4DC
	internal static uint GetVariantGlyphIndex(uint unicode, uint variantSelectorUnicode) { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	[NativeMethod(Name = "TextCore::FontEngine::GetGlyphIndex", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x1E9F520 Offset: 0x1E9B520 VA: 0x1E9F520
	internal static uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x1E9F55C Offset: 0x1E9B55C VA: 0x1E9F55C
	public static bool TryGetGlyphWithUnicodeValue(uint unicode, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithUnicodeValue", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x1E9F69C Offset: 0x1E9B69C VA: 0x1E9F69C
	private static bool TryGetGlyphWithUnicodeValue_Internal(uint unicode, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x1E9F6F0 Offset: 0x1E9B6F0 VA: 0x1E9F6F0
	public static bool TryGetGlyphWithIndexValue(uint glyphIndex, GlyphLoadFlags flags, out Glyph glyph) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryGetGlyphWithIndexValue", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x1E9F830 Offset: 0x1E9B830 VA: 0x1E9F830
	private static bool TryGetGlyphWithIndexValue_Internal(uint glyphIndex, GlyphLoadFlags loadFlags, ref GlyphMarshallingStruct glyphStruct) { }

	[NativeMethod(Name = "TextCore::FontEngine::SetTextureUploadMode", IsThreadSafe = True, IsFreeFunction = True)]
	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x1E9F884 Offset: 0x1E9B884 VA: 0x1E9F884
	internal static void SetTextureUploadMode(bool shouldUploadImmediately) { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x1E9F8C0 Offset: 0x1E9B8C0 VA: 0x1E9F8C0
	internal static bool TryAddGlyphToTexture(uint glyphIndex, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph glyph) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphToTexture", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x1E9FDAC Offset: 0x1E9BDAC VA: 0x1E9FDAC
	private static bool TryAddGlyphToTexture_Internal(uint glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, out GlyphMarshallingStruct glyph) { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x1EA0078 Offset: 0x1E9C078 VA: 0x1EA0078
	internal static bool TryAddGlyphsToTexture(List<uint> glyphIndexes, int padding, GlyphPackingMode packingMode, List<GlyphRect> freeGlyphRects, List<GlyphRect> usedGlyphRects, GlyphRenderMode renderMode, Texture2D texture, out Glyph[] glyphs) { }

	[NativeMethod(Name = "TextCore::FontEngine::TryAddGlyphsToTexture", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x1EA0910 Offset: 0x1E9C910 VA: 0x1EA0910
	private static bool TryAddGlyphsToTexture_Internal(uint[] glyphIndex, int padding, GlyphPackingMode packingMode, [Out] GlyphRect[] freeGlyphRects, ref int freeGlyphRectCount, [Out] GlyphRect[] usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, Texture2D texture, [Out] GlyphMarshallingStruct[] glyphs, ref int glyphCount) { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	[NativeMethod(Name = "TextCore::FontEngine::GetAllLigatureSubstitutionRecords", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x1EA0CF4 Offset: 0x1E9CCF4 VA: 0x1EA0CF4
	internal static LigatureSubstitutionRecord[] GetAllLigatureSubstitutionRecords() { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x1EA0D1C Offset: 0x1E9CD1C VA: 0x1EA0D1C
	internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint glyphIndex) { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x1EA0F4C Offset: 0x1E9CF4C VA: 0x1EA0F4C
	internal static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(List<uint> glyphIndexes) { }

	// RVA: 0x1EA0E28 Offset: 0x1E9CE28 VA: 0x1EA0E28
	private static LigatureSubstitutionRecord[] GetLigatureSubstitutionRecords(uint[] glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulateLigatureSubstitutionRecordMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x1EA0FD8 Offset: 0x1E9CFD8 VA: 0x1EA0FD8
	private static int PopulateLigatureSubstitutionRecordMarshallingArray(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetLigatureSubstitutionRecordsFromMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x1EA10D4 Offset: 0x1E9D0D4 VA: 0x1EA10D4
	private static int GetLigatureSubstitutionRecordsFromMarshallingArray([Out] LigatureSubstitutionRecord[] ligatureSubstitutionRecords) { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x1EA1154 Offset: 0x1E9D154 VA: 0x1EA1154
	internal static GlyphPairAdjustmentRecord[] GetGlyphPairAdjustmentTable(uint[] glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArrayFromKernTable", IsFreeFunction = True)]
	// RVA: 0x1EA127C Offset: 0x1E9D27C VA: 0x1EA127C
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetAllPairAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x1EA1494 Offset: 0x1E9D494 VA: 0x1EA1494
	internal static GlyphPairAdjustmentRecord[] GetAllPairAdjustmentRecords() { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x1EA1604 Offset: 0x1E9D604 VA: 0x1EA1604
	internal static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x1EA1690 Offset: 0x1E9D690 VA: 0x1EA1690
	private static GlyphPairAdjustmentRecord[] GetPairAdjustmentRecords(uint[] glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulatePairAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x1EA17B8 Offset: 0x1E9D7B8 VA: 0x1EA17B8
	private static int PopulatePairAdjustmentRecordMarshallingArray(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetGlyphPairAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x1EA1378 Offset: 0x1E9D378 VA: 0x1EA1378
	private static int GetPairAdjustmentRecordsFromMarshallingArray(Span<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetAllMarkToBaseAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x1EA1934 Offset: 0x1E9D934 VA: 0x1EA1934
	internal static MarkToBaseAdjustmentRecord[] GetAllMarkToBaseAdjustmentRecords() { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x1EA1AA4 Offset: 0x1E9DAA4 VA: 0x1EA1AA4
	internal static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x1EA1B30 Offset: 0x1E9DB30 VA: 0x1EA1B30
	private static MarkToBaseAdjustmentRecord[] GetMarkToBaseAdjustmentRecords(uint[] glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulateMarkToBaseAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x1EA1C54 Offset: 0x1E9DC54 VA: 0x1EA1C54
	private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetMarkToBaseAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x1EA1D50 Offset: 0x1E9DD50 VA: 0x1EA1D50
	private static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray(Span<MarkToBaseAdjustmentRecord> adjustmentRecords) { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	[NativeMethod(Name = "TextCore::FontEngine::GetAllMarkToMarkAdjustmentRecords", IsThreadSafe = True, IsFreeFunction = True)]
	// RVA: 0x1EA1EA8 Offset: 0x1E9DEA8 VA: 0x1EA1EA8
	internal static MarkToMarkAdjustmentRecord[] GetAllMarkToMarkAdjustmentRecords() { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x1EA2018 Offset: 0x1E9E018 VA: 0x1EA2018
	internal static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(List<uint> glyphIndexes) { }

	// RVA: 0x1EA2098 Offset: 0x1E9E098 VA: 0x1EA2098
	private static MarkToMarkAdjustmentRecord[] GetMarkToMarkAdjustmentRecords(uint[] glyphIndexes) { }

	[NativeMethod(Name = "TextCore::FontEngine::PopulateMarkToMarkAdjustmentRecordMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x1EA21C0 Offset: 0x1E9E1C0 VA: 0x1EA21C0
	private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray(uint[] glyphIndexes, out int recordCount) { }

	[NativeMethod(Name = "TextCore::FontEngine::GetMarkToMarkAdjustmentRecordsFromMarshallingArray", IsFreeFunction = True)]
	// RVA: 0x1EA22BC Offset: 0x1E9E2BC VA: 0x1EA22BC
	private static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray(Span<MarkToMarkAdjustmentRecord> adjustmentRecords) { }

	// RVA: 0x1EA0D8C Offset: 0x1E9CD8C VA: 0x1EA0D8C
	private static void GlyphIndexToMarshallingArray(uint glyphIndex, ref uint[] dstArray) { }

	// RVA: -1 Offset: -1
	private static void GenericListToMarshallingArray<T>(ref List<T> srcList, ref T[] dstArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1115EEC Offset: 0x1111EEC VA: 0x1115EEC
	|-FontEngine.GenericListToMarshallingArray<uint>
	|
	|-RVA: 0x111601C Offset: 0x111201C VA: 0x111601C
	|-FontEngine.GenericListToMarshallingArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void SetMarshallingArraySize<T>(ref T[] marshallingArray, int recordCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11162D0 Offset: 0x11122D0 VA: 0x11162D0
	|-FontEngine.SetMarshallingArraySize<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x111637C Offset: 0x111237C VA: 0x111637C
	|-FontEngine.SetMarshallingArraySize<LigatureSubstitutionRecord>
	|
	|-RVA: 0x1116428 Offset: 0x1112428 VA: 0x1116428
	|-FontEngine.SetMarshallingArraySize<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x11164D4 Offset: 0x11124D4 VA: 0x11164D4
	|-FontEngine.SetMarshallingArraySize<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x1116580 Offset: 0x1112580 VA: 0x1116580
	|-FontEngine.SetMarshallingArraySize<__Il2CppFullySharedGenericType>
	*/

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	[NativeMethod(Name = "TextCore::FontEngine::ResetAtlasTexture", IsFreeFunction = True)]
	// RVA: 0x1EA2414 Offset: 0x1E9E414 VA: 0x1EA2414
	internal static void ResetAtlasTexture(Texture2D texture) { }

	// RVA: 0x1EA24F0 Offset: 0x1E9E4F0 VA: 0x1EA24F0
	private static void .cctor() { }

	// RVA: 0x1E9E678 Offset: 0x1E9A678 VA: 0x1E9E678
	private static int LoadFontFace_Internal_Injected(ref ManagedSpanWrapper filePath) { }

	// RVA: 0x1E9E95C Offset: 0x1E9A95C VA: 0x1E9E95C
	private static int LoadFontFace_With_Size_And_FaceIndex_Internal_Injected(ref ManagedSpanWrapper filePath, int pointSize, int faceIndex) { }

	// RVA: 0x1E9EB60 Offset: 0x1E9AB60 VA: 0x1E9EB60
	private static int LoadFontFace_With_Size_and_FaceIndex_FromFont_Internal_Injected(IntPtr font, int pointSize, int faceIndex) { }

	// RVA: 0x1E9EF1C Offset: 0x1E9AF1C VA: 0x1E9EF1C
	private static int LoadFontFace_With_Size_by_FamilyName_and_StyleName_Internal_Injected(ref ManagedSpanWrapper familyName, ref ManagedSpanWrapper styleName, int pointSize) { }

	// RVA: 0x1E9F308 Offset: 0x1E9B308 VA: 0x1E9F308
	private static bool TryGetSystemFontReference_Internal_Injected(ref ManagedSpanWrapper familyName, ref ManagedSpanWrapper styleName, out FontReference fontRef) { }

	// RVA: 0x1E9FFDC Offset: 0x1E9BFDC VA: 0x1E9FFDC
	private static bool TryAddGlyphToTexture_Internal_Injected(uint glyphIndex, int padding, GlyphPackingMode packingMode, out BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, out BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, IntPtr texture, out GlyphMarshallingStruct glyph) { }

	// RVA: 0x1EA0C4C Offset: 0x1E9CC4C VA: 0x1EA0C4C
	private static bool TryAddGlyphsToTexture_Internal_Injected(ref ManagedSpanWrapper glyphIndex, int padding, GlyphPackingMode packingMode, out BlittableArrayWrapper freeGlyphRects, ref int freeGlyphRectCount, out BlittableArrayWrapper usedGlyphRects, ref int usedGlyphRectCount, GlyphRenderMode renderMode, IntPtr texture, out BlittableArrayWrapper glyphs, ref int glyphCount) { }

	// RVA: 0x1EA1110 Offset: 0x1E9D110 VA: 0x1EA1110
	private static int PopulateLigatureSubstitutionRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	// RVA: 0x1EA1450 Offset: 0x1E9D450 VA: 0x1EA1450
	private static int PopulatePairAdjustmentRecordMarshallingArray_from_KernTable_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	// RVA: 0x1EA15C8 Offset: 0x1E9D5C8 VA: 0x1EA15C8
	private static void GetAllPairAdjustmentRecords_Injected(out BlittableArrayWrapper ret) { }

	// RVA: 0x1EA18B4 Offset: 0x1E9D8B4 VA: 0x1EA18B4
	private static int PopulatePairAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	// RVA: 0x1EA18F8 Offset: 0x1E9D8F8 VA: 0x1EA18F8
	private static int GetPairAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper glyphPairAdjustmentRecords) { }

	// RVA: 0x1EA1A68 Offset: 0x1E9DA68 VA: 0x1EA1A68
	private static void GetAllMarkToBaseAdjustmentRecords_Injected(out BlittableArrayWrapper ret) { }

	// RVA: 0x1EA1E28 Offset: 0x1E9DE28 VA: 0x1EA1E28
	private static int PopulateMarkToBaseAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	// RVA: 0x1EA1E6C Offset: 0x1E9DE6C VA: 0x1EA1E6C
	private static int GetMarkToBaseAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper adjustmentRecords) { }

	// RVA: 0x1EA1FDC Offset: 0x1E9DFDC VA: 0x1EA1FDC
	private static void GetAllMarkToMarkAdjustmentRecords_Injected(out BlittableArrayWrapper ret) { }

	// RVA: 0x1EA2394 Offset: 0x1E9E394 VA: 0x1EA2394
	private static int PopulateMarkToMarkAdjustmentRecordMarshallingArray_Injected(ref ManagedSpanWrapper glyphIndexes, out int recordCount) { }

	// RVA: 0x1EA23D8 Offset: 0x1E9E3D8 VA: 0x1EA23D8
	private static int GetMarkToMarkAdjustmentRecordsFromMarshallingArray_Injected(ref ManagedSpanWrapper adjustmentRecords) { }

	// RVA: 0x1EA24B4 Offset: 0x1E9E4B4 VA: 0x1EA24B4
	private static void ResetAtlasTexture_Injected(IntPtr texture) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
internal struct FontEngineUtilities // TypeDefIndex: 7800
{
	// Methods

	// RVA: 0x1EA08FC Offset: 0x1E9C8FC VA: 0x1EA08FC
	internal static int MaxValue(int a, int b, int c) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
internal struct GlyphMarshallingStruct // TypeDefIndex: 7801
{
	// Fields
	public uint index; // 0x0
	public GlyphMetrics metrics; // 0x4
	public GlyphRect glyphRect; // 0x18
	public float scale; // 0x28
	public int atlasIndex; // 0x2C
	public GlyphClassDefinitionType classDefinitionType; // 0x30
}

// Namespace: UnityEngine.TextCore.LowLevel
[Flags]
public enum FontFeatureLookupFlags // TypeDefIndex: 7802
{
	// Fields
	public int value__; // 0x0
	public const FontFeatureLookupFlags None = 0;
	public const FontFeatureLookupFlags IgnoreLigatures = 4;
	public const FontFeatureLookupFlags IgnoreSpacingAdjustments = 256;
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[Serializable]
public struct GlyphValueRecord : IEquatable<GlyphValueRecord> // TypeDefIndex: 7803
{
	// Fields
	[NativeName("xPlacement")]
	[SerializeField]
	private float m_XPlacement; // 0x0
	[NativeName("yPlacement")]
	[SerializeField]
	private float m_YPlacement; // 0x4
	[NativeName("xAdvance")]
	[SerializeField]
	private float m_XAdvance; // 0x8
	[NativeName("yAdvance")]
	[SerializeField]
	private float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; set; }
	public float yAdvance { get; }

	// Methods

	// RVA: 0x1EA267C Offset: 0x1E9E67C VA: 0x1EA267C
	public float get_xPlacement() { }

	// RVA: 0x1EA2684 Offset: 0x1E9E684 VA: 0x1EA2684
	public void set_xPlacement(float value) { }

	// RVA: 0x1EA268C Offset: 0x1E9E68C VA: 0x1EA268C
	public float get_yPlacement() { }

	// RVA: 0x1EA2694 Offset: 0x1E9E694 VA: 0x1EA2694
	public void set_yPlacement(float value) { }

	// RVA: 0x1EA269C Offset: 0x1E9E69C VA: 0x1EA269C
	public float get_xAdvance() { }

	// RVA: 0x1EA26A4 Offset: 0x1E9E6A4 VA: 0x1EA26A4
	public void set_xAdvance(float value) { }

	// RVA: 0x1EA26AC Offset: 0x1E9E6AC VA: 0x1EA26AC
	public float get_yAdvance() { }

	// RVA: 0x1EA26B4 Offset: 0x1E9E6B4 VA: 0x1EA26B4
	public void .ctor(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	// RVA: 0x1EA26C0 Offset: 0x1E9E6C0 VA: 0x1EA26C0
	public static GlyphValueRecord op_Addition(GlyphValueRecord a, GlyphValueRecord b) { }

	// RVA: 0x1EA26D4 Offset: 0x1E9E6D4 VA: 0x1EA26D4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EA2738 Offset: 0x1E9E738 VA: 0x1EA2738 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EA27B0 Offset: 0x1E9E7B0 VA: 0x1EA27B0 Slot: 4
	public bool Equals(GlyphValueRecord other) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[Serializable]
public struct GlyphAdjustmentRecord : IEquatable<GlyphAdjustmentRecord> // TypeDefIndex: 7804
{
	// Fields
	[NativeName("glyphIndex")]
	[SerializeField]
	private uint m_GlyphIndex; // 0x0
	[NativeName("glyphValueRecord")]
	[SerializeField]
	private GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; }
	public GlyphValueRecord glyphValueRecord { get; }

	// Methods

	// RVA: 0x1EA2858 Offset: 0x1E9E858 VA: 0x1EA2858
	public uint get_glyphIndex() { }

	// RVA: 0x1EA2860 Offset: 0x1E9E860 VA: 0x1EA2860
	public GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0x1EA286C Offset: 0x1E9E86C VA: 0x1EA286C
	public void .ctor(uint glyphIndex, GlyphValueRecord glyphValueRecord) { }

	[ExcludeFromDocs]
	// RVA: 0x1EA287C Offset: 0x1E9E87C VA: 0x1EA287C Slot: 2
	public override int GetHashCode() { }

	[ExcludeFromDocs]
	// RVA: 0x1EA28E8 Offset: 0x1E9E8E8 VA: 0x1EA28E8 Slot: 0
	public override bool Equals(object obj) { }

	[ExcludeFromDocs]
	// RVA: 0x1EA2968 Offset: 0x1E9E968 VA: 0x1EA2968 Slot: 4
	public bool Equals(GlyphAdjustmentRecord other) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[DebuggerDisplay("First glyphIndex = {m_FirstAdjustmentRecord.m_GlyphIndex},  Second glyphIndex = {m_SecondAdjustmentRecord.m_GlyphIndex}")]
[Serializable]
public struct GlyphPairAdjustmentRecord : IEquatable<GlyphPairAdjustmentRecord> // TypeDefIndex: 7805
{
	// Fields
	[NativeName("firstAdjustmentRecord")]
	[SerializeField]
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x0
	[SerializeField]
	[NativeName("secondAdjustmentRecord")]
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x14
	[SerializeField]
	private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x28

	// Properties
	public GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
	public GlyphAdjustmentRecord secondAdjustmentRecord { get; }
	public FontFeatureLookupFlags featureLookupFlags { get; }

	// Methods

	// RVA: 0x1EA2A0C Offset: 0x1E9EA0C VA: 0x1EA2A0C
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x1EA2A20 Offset: 0x1E9EA20 VA: 0x1EA2A20
	public void set_firstAdjustmentRecord(GlyphAdjustmentRecord value) { }

	// RVA: 0x1EA2A34 Offset: 0x1E9EA34 VA: 0x1EA2A34
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0x1EA2A48 Offset: 0x1E9EA48 VA: 0x1EA2A48
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0x1EA2A50 Offset: 0x1E9EA50 VA: 0x1EA2A50
	public void .ctor(GlyphAdjustmentRecord firstAdjustmentRecord, GlyphAdjustmentRecord secondAdjustmentRecord) { }

	[ExcludeFromDocs]
	// RVA: 0x1EA2A74 Offset: 0x1E9EA74 VA: 0x1EA2A74 Slot: 2
	public override int GetHashCode() { }

	[ExcludeFromDocs]
	// RVA: 0x1EA2AE0 Offset: 0x1E9EAE0 VA: 0x1EA2AE0 Slot: 0
	public override bool Equals(object obj) { }

	[ExcludeFromDocs]
	// RVA: 0x1EA2B60 Offset: 0x1E9EB60 VA: 0x1EA2B60 Slot: 4
	public bool Equals(GlyphPairAdjustmentRecord other) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
[Serializable]
internal struct GlyphAnchorPoint // TypeDefIndex: 7806
{
	// Fields
	[SerializeField]
	[NativeName("xPositionAdjustment")]
	private float m_XCoordinate; // 0x0
	[SerializeField]
	[NativeName("yPositionAdjustment")]
	private float m_YCoordinate; // 0x4

	// Properties
	public float xCoordinate { get; set; }
	public float yCoordinate { get; set; }

	// Methods

	// RVA: 0x1EA2C04 Offset: 0x1E9EC04 VA: 0x1EA2C04
	public float get_xCoordinate() { }

	// RVA: 0x1EA2C0C Offset: 0x1E9EC0C VA: 0x1EA2C0C
	public void set_xCoordinate(float value) { }

	// RVA: 0x1EA2C14 Offset: 0x1E9EC14 VA: 0x1EA2C14
	public float get_yCoordinate() { }

	// RVA: 0x1EA2C1C Offset: 0x1E9EC1C VA: 0x1EA2C1C
	public void set_yCoordinate(float value) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
[UsedByNativeCode]
[Serializable]
internal struct MarkPositionAdjustment // TypeDefIndex: 7807
{
	// Fields
	[SerializeField]
	[NativeName("xCoordinate")]
	private float m_XPositionAdjustment; // 0x0
	[SerializeField]
	[NativeName("yCoordinate")]
	private float m_YPositionAdjustment; // 0x4

	// Properties
	public float xPositionAdjustment { get; set; }
	public float yPositionAdjustment { get; set; }

	// Methods

	// RVA: 0x1EA2C24 Offset: 0x1E9EC24 VA: 0x1EA2C24
	public float get_xPositionAdjustment() { }

	// RVA: 0x1EA2C2C Offset: 0x1E9EC2C VA: 0x1EA2C2C
	public void set_xPositionAdjustment(float value) { }

	// RVA: 0x1EA2C34 Offset: 0x1E9EC34 VA: 0x1EA2C34
	public float get_yPositionAdjustment() { }

	// RVA: 0x1EA2C3C Offset: 0x1E9EC3C VA: 0x1EA2C3C
	public void set_yPositionAdjustment(float value) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
[Serializable]
internal struct MarkToBaseAdjustmentRecord // TypeDefIndex: 7808
{
	// Fields
	[SerializeField]
	[NativeName("baseGlyphID")]
	private uint m_BaseGlyphID; // 0x0
	[SerializeField]
	[NativeName("baseAnchor")]
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; // 0x4
	[SerializeField]
	[NativeName("markGlyphID")]
	private uint m_MarkGlyphID; // 0xC
	[SerializeField]
	[NativeName("markPositionAdjustment")]
	private MarkPositionAdjustment m_MarkPositionAdjustment; // 0x10

	// Properties
	public uint baseGlyphID { get; set; }
	public GlyphAnchorPoint baseGlyphAnchorPoint { get; set; }
	public uint markGlyphID { get; set; }
	public MarkPositionAdjustment markPositionAdjustment { get; set; }

	// Methods

	// RVA: 0x1EA2C44 Offset: 0x1E9EC44 VA: 0x1EA2C44
	public uint get_baseGlyphID() { }

	// RVA: 0x1EA2C4C Offset: 0x1E9EC4C VA: 0x1EA2C4C
	public void set_baseGlyphID(uint value) { }

	// RVA: 0x1EA2C54 Offset: 0x1E9EC54 VA: 0x1EA2C54
	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	// RVA: 0x1EA2C5C Offset: 0x1E9EC5C VA: 0x1EA2C5C
	public void set_baseGlyphAnchorPoint(GlyphAnchorPoint value) { }

	// RVA: 0x1EA2C64 Offset: 0x1E9EC64 VA: 0x1EA2C64
	public uint get_markGlyphID() { }

	// RVA: 0x1EA2C6C Offset: 0x1E9EC6C VA: 0x1EA2C6C
	public void set_markGlyphID(uint value) { }

	// RVA: 0x1EA2C74 Offset: 0x1E9EC74 VA: 0x1EA2C74
	public MarkPositionAdjustment get_markPositionAdjustment() { }

	// RVA: 0x1EA2C7C Offset: 0x1E9EC7C VA: 0x1EA2C7C
	public void set_markPositionAdjustment(MarkPositionAdjustment value) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
[Serializable]
internal struct MarkToMarkAdjustmentRecord // TypeDefIndex: 7809
{
	// Fields
	[SerializeField]
	[NativeName("baseMarkGlyphID")]
	private uint m_BaseMarkGlyphID; // 0x0
	[SerializeField]
	[NativeName("baseMarkAnchor")]
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; // 0x4
	[SerializeField]
	[NativeName("combiningMarkGlyphID")]
	private uint m_CombiningMarkGlyphID; // 0xC
	[SerializeField]
	[NativeName("combiningMarkPositionAdjustment")]
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; // 0x10

	// Properties
	public uint baseMarkGlyphID { get; set; }
	public GlyphAnchorPoint baseMarkGlyphAnchorPoint { get; set; }
	public uint combiningMarkGlyphID { get; set; }
	public MarkPositionAdjustment combiningMarkPositionAdjustment { get; set; }

	// Methods

	// RVA: 0x1EA2C84 Offset: 0x1E9EC84 VA: 0x1EA2C84
	public uint get_baseMarkGlyphID() { }

	// RVA: 0x1EA2C8C Offset: 0x1E9EC8C VA: 0x1EA2C8C
	public void set_baseMarkGlyphID(uint value) { }

	// RVA: 0x1EA2C94 Offset: 0x1E9EC94 VA: 0x1EA2C94
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	// RVA: 0x1EA2C9C Offset: 0x1E9EC9C VA: 0x1EA2C9C
	public void set_baseMarkGlyphAnchorPoint(GlyphAnchorPoint value) { }

	// RVA: 0x1EA2CA4 Offset: 0x1E9ECA4 VA: 0x1EA2CA4
	public uint get_combiningMarkGlyphID() { }

	// RVA: 0x1EA2CAC Offset: 0x1E9ECAC VA: 0x1EA2CAC
	public void set_combiningMarkGlyphID(uint value) { }

	// RVA: 0x1EA2CB4 Offset: 0x1E9ECB4 VA: 0x1EA2CB4
	public MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }

	// RVA: 0x1EA2CBC Offset: 0x1E9ECBC VA: 0x1EA2CBC
	public void set_combiningMarkPositionAdjustment(MarkPositionAdjustment value) { }
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
[Serializable]
internal struct MultipleSubstitutionRecord // TypeDefIndex: 7810
{
	// Fields
	[SerializeField]
	[NativeName("targetGlyphID")]
	private uint m_TargetGlyphID; // 0x0
	[NativeName("substituteGlyphIDs")]
	[SerializeField]
	private uint[] m_SubstituteGlyphIDs; // 0x8
}

// Namespace: UnityEngine.TextCore.LowLevel
[UsedByNativeCode]
[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule", "UnityEditor.TextCoreTextEngineModule" })]
[Serializable]
internal struct LigatureSubstitutionRecord : IEquatable<LigatureSubstitutionRecord> // TypeDefIndex: 7811
{
	// Fields
	[NativeName("componentGlyphs")]
	[SerializeField]
	private uint[] m_ComponentGlyphIDs; // 0x0
	[NativeName("ligatureGlyph")]
	[SerializeField]
	private uint m_LigatureGlyphID; // 0x8

	// Properties
	public uint[] componentGlyphIDs { get; set; }
	public uint ligatureGlyphID { get; set; }

	// Methods

	// RVA: 0x1EA2CC4 Offset: 0x1E9ECC4 VA: 0x1EA2CC4
	public uint[] get_componentGlyphIDs() { }

	// RVA: 0x1EA2CCC Offset: 0x1E9ECCC VA: 0x1EA2CCC
	public void set_componentGlyphIDs(uint[] value) { }

	// RVA: 0x1EA2CD4 Offset: 0x1E9ECD4 VA: 0x1EA2CD4
	public uint get_ligatureGlyphID() { }

	// RVA: 0x1EA2CDC Offset: 0x1E9ECDC VA: 0x1EA2CDC
	public void set_ligatureGlyphID(uint value) { }

	// RVA: 0x1EA2CE4 Offset: 0x1E9ECE4 VA: 0x1EA2CE4 Slot: 4
	public bool Equals(LigatureSubstitutionRecord other) { }

	// RVA: 0x1EA2D58 Offset: 0x1E9ED58 VA: 0x1EA2D58 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1EA2DD4 Offset: 0x1E9EDD4 VA: 0x1EA2DD4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1EA2CFC Offset: 0x1E9ECFC VA: 0x1EA2CFC
	public static bool op_Equality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 7812
{}

// Namespace: 
internal static class Consts // TypeDefIndex: 7813
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
