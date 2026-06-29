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

// Namespace: UnityEngine.TextCore
public enum OTL_FeatureTag // TypeDefIndex: 5138
{
	// Fields
	public uint value__; // 0x0
	public const OTL_FeatureTag kern = 1801810542;
	public const OTL_FeatureTag liga = 1818847073;
	public const OTL_FeatureTag mark = 1835102827;
	public const OTL_FeatureTag mkmk = 1835756907;
}

// Namespace: UnityEngine.TextCore
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
[NativeHeader("Modules/TextCoreTextEngine/Native/TextGenerationSettings.h")]
[UsedByNativeCode("TextGenerationSettings")]
internal struct NativeTextGenerationSettings // TypeDefIndex: 7425
{
	// Fields
	public IntPtr fontAsset; // 0x0
	public IntPtr textSettings; // 0x8
	public string text; // 0x10
	public int screenWidth; // 0x18
	public int screenHeight; // 0x1C
	public WhiteSpace wordWrap; // 0x20
	public TextOverflow overflow; // 0x24
	public LanguageDirection languageDirection; // 0x28
	public int vertexPadding; // 0x2C
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal HorizontalAlignment horizontalAlignment; // 0x30
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal VerticalAlignment verticalAlignment; // 0x34
	public int fontSize; // 0x38
	public FontStyles fontStyle; // 0x3C
	public TextFontWeight fontWeight; // 0x40
	public TextSpan[] textSpans; // 0x48
	public Color32 color; // 0x50
	public int characterSpacing; // 0x54
	public int wordSpacing; // 0x58
	public int paragraphSpacing; // 0x5C

	// Properties
	public static NativeTextGenerationSettings Default { get; }

	// Methods

	// RVA: 0x1EA3678 Offset: 0x1E9F678 VA: 0x1EA3678
	public static NativeTextGenerationSettings get_Default() { }

	// RVA: 0x1EA36C4 Offset: 0x1E9F6C4 VA: 0x1EA36C4 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.TextCore
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal struct TextSpan // TypeDefIndex: 7426
{
	// Fields
	public int startIndex; // 0x0
	public int length; // 0x4
	public IntPtr fontAsset; // 0x8
	public int fontSize; // 0x10
	public Color32 color; // 0x14
	public FontStyles fontStyle; // 0x18
	public TextFontWeight fontWeight; // 0x1C
	public int linkID; // 0x20

	// Methods

	// RVA: 0x1EA4090 Offset: 0x1EA0090 VA: 0x1EA4090 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.TextCore
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal enum HorizontalAlignment // TypeDefIndex: 7427
{
	// Fields
	public int value__; // 0x0
	public const HorizontalAlignment Left = 0;
	public const HorizontalAlignment Center = 1;
	public const HorizontalAlignment Right = 2;
	public const HorizontalAlignment Justified = 3;
}

// Namespace: UnityEngine.TextCore
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal enum VerticalAlignment // TypeDefIndex: 7428
{
	// Fields
	public int value__; // 0x0
	public const VerticalAlignment Top = 0;
	public const VerticalAlignment Middle = 1;
	public const VerticalAlignment Bottom = 2;
}

// Namespace: UnityEngine.TextCore
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal enum LanguageDirection // TypeDefIndex: 7429
{
	// Fields
	public int value__; // 0x0
	public const LanguageDirection LTR = 0;
	public const LanguageDirection RTL = 1;
}

// Namespace: UnityEngine.TextCore
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal enum WhiteSpace // TypeDefIndex: 7430
{
	// Fields
	public int value__; // 0x0
	public const WhiteSpace Normal = 0;
	public const WhiteSpace NoWrap = 1;
	public const WhiteSpace Pre = 2;
	public const WhiteSpace PreWrap = 3;
}

// Namespace: UnityEngine.TextCore
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal enum TextOverflow // TypeDefIndex: 7431
{
	// Fields
	public int value__; // 0x0
	public const TextOverflow Clip = 0;
	public const TextOverflow Ellipsis = 1;
}

// Namespace: UnityEngine.TextCore
[UsedByNativeCode]
[Serializable]
public struct FaceInfo // TypeDefIndex: 7788
{
	// Fields
	[SerializeField]
	[NativeName("faceIndex")]
	private int m_FaceIndex; // 0x0
	[SerializeField]
	[NativeName("familyName")]
	private string m_FamilyName; // 0x8
	[SerializeField]
	[NativeName("styleName")]
	private string m_StyleName; // 0x10
	[SerializeField]
	[NativeName("pointSize")]
	private float m_PointSize; // 0x18
	[NativeName("scale")]
	[SerializeField]
	private float m_Scale; // 0x1C
	[NativeName("unitsPerEM")]
	[SerializeField]
	private int m_UnitsPerEM; // 0x20
	[NativeName("lineHeight")]
	[SerializeField]
	private float m_LineHeight; // 0x24
	[NativeName("ascentLine")]
	[SerializeField]
	private float m_AscentLine; // 0x28
	[SerializeField]
	[NativeName("capLine")]
	private float m_CapLine; // 0x2C
	[SerializeField]
	[NativeName("meanLine")]
	private float m_MeanLine; // 0x30
	[SerializeField]
	[NativeName("baseline")]
	private float m_Baseline; // 0x34
	[NativeName("descentLine")]
	[SerializeField]
	private float m_DescentLine; // 0x38
	[SerializeField]
	[NativeName("superscriptOffset")]
	private float m_SuperscriptOffset; // 0x3C
	[SerializeField]
	[NativeName("superscriptSize")]
	private float m_SuperscriptSize; // 0x40
	[SerializeField]
	[NativeName("subscriptOffset")]
	private float m_SubscriptOffset; // 0x44
	[SerializeField]
	[NativeName("subscriptSize")]
	private float m_SubscriptSize; // 0x48
	[NativeName("underlineOffset")]
	[SerializeField]
	private float m_UnderlineOffset; // 0x4C
	[NativeName("underlineThickness")]
	[SerializeField]
	private float m_UnderlineThickness; // 0x50
	[NativeName("strikethroughOffset")]
	[SerializeField]
	private float m_StrikethroughOffset; // 0x54
	[NativeName("strikethroughThickness")]
	[SerializeField]
	private float m_StrikethroughThickness; // 0x58
	[SerializeField]
	[NativeName("tabWidth")]
	private float m_TabWidth; // 0x5C

	// Properties
	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	internal int faceIndex { get; }
	public string familyName { get; }
	public string styleName { get; }
	public float pointSize { get; }
	public float scale { get; set; }
	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	internal int unitsPerEM { get; set; }
	public float lineHeight { get; }
	public float ascentLine { get; }
	public float capLine { get; set; }
	public float meanLine { get; set; }
	public float baseline { get; }
	public float descentLine { get; }
	public float superscriptOffset { get; }
	public float superscriptSize { get; }
	public float subscriptOffset { get; }
	public float subscriptSize { get; }
	public float underlineOffset { get; }
	public float underlineThickness { get; }
	public float strikethroughOffset { get; set; }
	public float tabWidth { get; }

	// Methods

	// RVA: 0x1E9DE40 Offset: 0x1E99E40 VA: 0x1E9DE40
	internal int get_faceIndex() { }

	// RVA: 0x1E9DE48 Offset: 0x1E99E48 VA: 0x1E9DE48
	public string get_familyName() { }

	// RVA: 0x1E9DE50 Offset: 0x1E99E50 VA: 0x1E9DE50
	public string get_styleName() { }

	// RVA: 0x1E9DE58 Offset: 0x1E99E58 VA: 0x1E9DE58
	public float get_pointSize() { }

	// RVA: 0x1E9DE60 Offset: 0x1E99E60 VA: 0x1E9DE60
	public float get_scale() { }

	// RVA: 0x1E9DE68 Offset: 0x1E99E68 VA: 0x1E9DE68
	public void set_scale(float value) { }

	// RVA: 0x1E9DE70 Offset: 0x1E99E70 VA: 0x1E9DE70
	internal int get_unitsPerEM() { }

	// RVA: 0x1E9DE78 Offset: 0x1E99E78 VA: 0x1E9DE78
	internal void set_unitsPerEM(int value) { }

	// RVA: 0x1E9DE80 Offset: 0x1E99E80 VA: 0x1E9DE80
	public float get_lineHeight() { }

	// RVA: 0x1E9DE88 Offset: 0x1E99E88 VA: 0x1E9DE88
	public float get_ascentLine() { }

	// RVA: 0x1E9DE90 Offset: 0x1E99E90 VA: 0x1E9DE90
	public float get_capLine() { }

	// RVA: 0x1E9DE98 Offset: 0x1E99E98 VA: 0x1E9DE98
	public void set_capLine(float value) { }

	// RVA: 0x1E9DEA0 Offset: 0x1E99EA0 VA: 0x1E9DEA0
	public float get_meanLine() { }

	// RVA: 0x1E9DEA8 Offset: 0x1E99EA8 VA: 0x1E9DEA8
	public void set_meanLine(float value) { }

	// RVA: 0x1E9DEB0 Offset: 0x1E99EB0 VA: 0x1E9DEB0
	public float get_baseline() { }

	// RVA: 0x1E9DEB8 Offset: 0x1E99EB8 VA: 0x1E9DEB8
	public float get_descentLine() { }

	// RVA: 0x1E9DEC0 Offset: 0x1E99EC0 VA: 0x1E9DEC0
	public float get_superscriptOffset() { }

	// RVA: 0x1E9DEC8 Offset: 0x1E99EC8 VA: 0x1E9DEC8
	public float get_superscriptSize() { }

	// RVA: 0x1E9DED0 Offset: 0x1E99ED0 VA: 0x1E9DED0
	public float get_subscriptOffset() { }

	// RVA: 0x1E9DED8 Offset: 0x1E99ED8 VA: 0x1E9DED8
	public float get_subscriptSize() { }

	// RVA: 0x1E9DEE0 Offset: 0x1E99EE0 VA: 0x1E9DEE0
	public float get_underlineOffset() { }

	// RVA: 0x1E9DEE8 Offset: 0x1E99EE8 VA: 0x1E9DEE8
	public float get_underlineThickness() { }

	// RVA: 0x1E9DEF0 Offset: 0x1E99EF0 VA: 0x1E9DEF0
	public float get_strikethroughOffset() { }

	// RVA: 0x1E9DEF8 Offset: 0x1E99EF8 VA: 0x1E9DEF8
	public void set_strikethroughOffset(float value) { }

	// RVA: 0x1E9DF00 Offset: 0x1E99F00 VA: 0x1E9DF00
	public float get_tabWidth() { }
}

// Namespace: UnityEngine.TextCore
public enum GlyphClassDefinitionType // TypeDefIndex: 7789
{
	// Fields
	public int value__; // 0x0
	public const GlyphClassDefinitionType Undefined = 0;
	public const GlyphClassDefinitionType Base = 1;
	public const GlyphClassDefinitionType Ligature = 2;
	public const GlyphClassDefinitionType Mark = 3;
	public const GlyphClassDefinitionType Component = 4;
}

// Namespace: UnityEngine.TextCore
[UsedByNativeCode]
[Serializable]
public struct GlyphRect : IEquatable<GlyphRect> // TypeDefIndex: 7790
{
	// Fields
	[SerializeField]
	[NativeName("x")]
	private int m_X; // 0x0
	[SerializeField]
	[NativeName("y")]
	private int m_Y; // 0x4
	[NativeName("width")]
	[SerializeField]
	private int m_Width; // 0x8
	[NativeName("height")]
	[SerializeField]
	private int m_Height; // 0xC
	private static readonly GlyphRect s_ZeroGlyphRect; // 0x0

	// Properties
	public int x { get; }
	public int y { get; }
	public int width { get; }
	public int height { get; }
	public static GlyphRect zero { get; }

	// Methods

	// RVA: 0x1E9DF08 Offset: 0x1E99F08 VA: 0x1E9DF08
	public int get_x() { }

	// RVA: 0x1E9DF10 Offset: 0x1E99F10 VA: 0x1E9DF10
	public int get_y() { }

	// RVA: 0x1E9DF18 Offset: 0x1E99F18 VA: 0x1E9DF18
	public int get_width() { }

	// RVA: 0x1E9DF20 Offset: 0x1E99F20 VA: 0x1E9DF20
	public int get_height() { }

	// RVA: 0x1E9DF28 Offset: 0x1E99F28 VA: 0x1E9DF28
	public static GlyphRect get_zero() { }

	// RVA: 0x1E9DF80 Offset: 0x1E99F80 VA: 0x1E9DF80
	public void .ctor(int x, int y, int width, int height) { }

	// RVA: 0x1E9DF8C Offset: 0x1E99F8C VA: 0x1E9DF8C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E9DFF0 Offset: 0x1E99FF0 VA: 0x1E9DFF0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E9E068 Offset: 0x1E9A068 VA: 0x1E9E068 Slot: 4
	public bool Equals(GlyphRect other) { }

	// RVA: 0x1E9E0FC Offset: 0x1E9A0FC VA: 0x1E9E0FC
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore
[UsedByNativeCode]
[Serializable]
public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 7791
{
	// Fields
	[NativeName("width")]
	[SerializeField]
	private float m_Width; // 0x0
	[SerializeField]
	[NativeName("height")]
	private float m_Height; // 0x4
	[SerializeField]
	[NativeName("horizontalBearingX")]
	private float m_HorizontalBearingX; // 0x8
	[SerializeField]
	[NativeName("horizontalBearingY")]
	private float m_HorizontalBearingY; // 0xC
	[SerializeField]
	[NativeName("horizontalAdvance")]
	private float m_HorizontalAdvance; // 0x10

	// Properties
	public float width { get; }
	public float height { get; }
	public float horizontalBearingX { get; }
	public float horizontalBearingY { get; }
	public float horizontalAdvance { get; }

	// Methods

	// RVA: 0x1E9E144 Offset: 0x1E9A144 VA: 0x1E9E144
	public float get_width() { }

	// RVA: 0x1E9E14C Offset: 0x1E9A14C VA: 0x1E9E14C
	public float get_height() { }

	// RVA: 0x1E9E154 Offset: 0x1E9A154 VA: 0x1E9E154
	public float get_horizontalBearingX() { }

	// RVA: 0x1E9E15C Offset: 0x1E9A15C VA: 0x1E9E15C
	public float get_horizontalBearingY() { }

	// RVA: 0x1E9E164 Offset: 0x1E9A164 VA: 0x1E9E164
	public float get_horizontalAdvance() { }

	// RVA: 0x1E9E16C Offset: 0x1E9A16C VA: 0x1E9E16C
	public void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	// RVA: 0x1E9E17C Offset: 0x1E9A17C VA: 0x1E9E17C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E9E1E8 Offset: 0x1E9A1E8 VA: 0x1E9E1E8 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E9E268 Offset: 0x1E9A268 VA: 0x1E9E268 Slot: 4
	public bool Equals(GlyphMetrics other) { }
}

// Namespace: UnityEngine.TextCore
[UsedByNativeCode]
[Serializable]
public class Glyph // TypeDefIndex: 7792
{
	// Fields
	[SerializeField]
	[NativeName("index")]
	private uint m_Index; // 0x10
	[SerializeField]
	[NativeName("metrics")]
	private GlyphMetrics m_Metrics; // 0x14
	[SerializeField]
	[NativeName("glyphRect")]
	private GlyphRect m_GlyphRect; // 0x28
	[NativeName("scale")]
	[SerializeField]
	private float m_Scale; // 0x38
	[SerializeField]
	[NativeName("atlasIndex")]
	private int m_AtlasIndex; // 0x3C
	[NativeName("type")]
	[SerializeField]
	private GlyphClassDefinitionType m_ClassDefinitionType; // 0x40

	// Properties
	public uint index { get; set; }
	public GlyphMetrics metrics { get; set; }
	public GlyphRect glyphRect { get; set; }
	public float scale { get; set; }
	public int atlasIndex { get; set; }

	// Methods

	// RVA: 0x1E9E30C Offset: 0x1E9A30C VA: 0x1E9E30C
	public uint get_index() { }

	// RVA: 0x1E9E314 Offset: 0x1E9A314 VA: 0x1E9E314
	public void set_index(uint value) { }

	// RVA: 0x1E9E31C Offset: 0x1E9A31C VA: 0x1E9E31C
	public GlyphMetrics get_metrics() { }

	// RVA: 0x1E9E330 Offset: 0x1E9A330 VA: 0x1E9E330
	public void set_metrics(GlyphMetrics value) { }

	// RVA: 0x1E9E344 Offset: 0x1E9A344 VA: 0x1E9E344
	public GlyphRect get_glyphRect() { }

	// RVA: 0x1E9E350 Offset: 0x1E9A350 VA: 0x1E9E350
	public void set_glyphRect(GlyphRect value) { }

	// RVA: 0x1E9E358 Offset: 0x1E9A358 VA: 0x1E9E358
	public float get_scale() { }

	// RVA: 0x1E9E360 Offset: 0x1E9A360 VA: 0x1E9E360
	public void set_scale(float value) { }

	// RVA: 0x1E9E368 Offset: 0x1E9A368 VA: 0x1E9E368
	public int get_atlasIndex() { }

	// RVA: 0x1E9E370 Offset: 0x1E9A370 VA: 0x1E9E370
	public void set_atlasIndex(int value) { }

	// RVA: 0x1E9E378 Offset: 0x1E9A378 VA: 0x1E9E378
	public void .ctor() { }

	// RVA: 0x1E9E3A0 Offset: 0x1E9A3A0 VA: 0x1E9E3A0
	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x1E9E41C Offset: 0x1E9A41C VA: 0x1E9E41C
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }
}
