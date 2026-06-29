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

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class Character : TextElement // TypeDefIndex: 7432
{
	// Methods

	// RVA: 0x1EA4474 Offset: 0x1EA0474 VA: 0x1EA4474
	public void .ctor() { }

	// RVA: 0x1EA44A0 Offset: 0x1EA04A0 VA: 0x1EA44A0
	public void .ctor(uint unicode, FontAsset fontAsset, Glyph glyph) { }

	// RVA: 0x1EA453C Offset: 0x1EA053C VA: 0x1EA453C
	internal void .ctor(uint unicode, uint glyphIndex) { }
}

// Namespace: UnityEngine.TextCore.Text
internal static class ColorUtilities // TypeDefIndex: 7433
{
	// Methods

	// RVA: 0x1EA45B8 Offset: 0x1EA05B8 VA: 0x1EA45B8
	internal static bool CompareColors(Color32 a, Color32 b) { }

	// RVA: 0x1EA45C8 Offset: 0x1EA05C8 VA: 0x1EA45C8
	internal static Color32 MultiplyColors(Color32 c1, Color32 c2) { }
}

// Namespace: UnityEngine.TextCore.Text
public class FastAction // TypeDefIndex: 7434
{
	// Fields
	private LinkedList<Action> delegates; // 0x10
	private Dictionary<Action, LinkedListNode<Action>> lookup; // 0x18

	// Methods

	// RVA: 0x1EA46AC Offset: 0x1EA06AC VA: 0x1EA46AC
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
public class FastAction<A> // TypeDefIndex: 7435
{
	// Fields
	private LinkedList<Action<A>> delegates; // 0x0
	private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1256C50 Offset: 0x1252C50 VA: 0x1256C50
	|-FastAction<bool>..ctor
	|
	|-RVA: 0x1256D08 Offset: 0x1252D08 VA: 0x1256D08
	|-FastAction<object>..ctor
	|
	|-RVA: 0x1256DC0 Offset: 0x1252DC0 VA: 0x1256DC0
	|-FastAction<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.TextCore.Text
public class FastAction<A, B> // TypeDefIndex: 7436
{
	// Fields
	private LinkedList<Action<A, B>> delegates; // 0x0
	private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Call(A a, B b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12576F8 Offset: 0x12536F8 VA: 0x12576F8
	|-FastAction<bool, object>.Call
	|
	|-RVA: 0x1257828 Offset: 0x1253828 VA: 0x1257828
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257770 Offset: 0x1253770 VA: 0x1257770
	|-FastAction<bool, object>..ctor
	|
	|-RVA: 0x12579F0 Offset: 0x12539F0 VA: 0x12579F0
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.TextCore.Text
public class FastAction<A, B, C> // TypeDefIndex: 7437
{
	// Fields
	private LinkedList<Action<A, B, C>> delegates; // 0x0
	private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1258154 Offset: 0x1254154 VA: 0x1258154
	|-FastAction<object, object, object>..ctor
	|
	|-RVA: 0x125820C Offset: 0x125420C VA: 0x125820C
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: UnityEngine.TextCore.Text
public enum OTL_FeatureTag // TypeDefIndex: 7438
{
	// Fields
	public uint value__; // 0x0
	public const OTL_FeatureTag kern = 1801810542;
	public const OTL_FeatureTag liga = 1818847073;
	public const OTL_FeatureTag mark = 1835102827;
	public const OTL_FeatureTag mkmk = 1835756907;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FontFeatureTable.<>c // TypeDefIndex: 7439
{
	// Fields
	public static readonly FontFeatureTable.<>c <>9; // 0x0
	public static Func<GlyphPairAdjustmentRecord, uint> <>9__24_0; // 0x8
	public static Func<GlyphPairAdjustmentRecord, uint> <>9__24_1; // 0x10
	public static Func<MarkToBaseAdjustmentRecord, uint> <>9__25_0; // 0x18
	public static Func<MarkToBaseAdjustmentRecord, uint> <>9__25_1; // 0x20
	public static Func<MarkToMarkAdjustmentRecord, uint> <>9__26_0; // 0x28
	public static Func<MarkToMarkAdjustmentRecord, uint> <>9__26_1; // 0x30

	// Methods

	// RVA: 0x1EA5090 Offset: 0x1EA1090 VA: 0x1EA5090
	private static void .cctor() { }

	// RVA: 0x1EA50F8 Offset: 0x1EA10F8 VA: 0x1EA50F8
	public void .ctor() { }

	// RVA: 0x1EA5100 Offset: 0x1EA1100 VA: 0x1EA5100
	internal uint <SortGlyphPairAdjustmentRecords>b__24_0(GlyphPairAdjustmentRecord s) { }

	// RVA: 0x1EA5148 Offset: 0x1EA1148 VA: 0x1EA5148
	internal uint <SortGlyphPairAdjustmentRecords>b__24_1(GlyphPairAdjustmentRecord s) { }

	// RVA: 0x1EA5190 Offset: 0x1EA1190 VA: 0x1EA5190
	internal uint <SortMarkToBaseAdjustmentRecords>b__25_0(MarkToBaseAdjustmentRecord s) { }

	// RVA: 0x1EA519C Offset: 0x1EA119C VA: 0x1EA519C
	internal uint <SortMarkToBaseAdjustmentRecords>b__25_1(MarkToBaseAdjustmentRecord s) { }

	// RVA: 0x1EA51A8 Offset: 0x1EA11A8 VA: 0x1EA51A8
	internal uint <SortMarkToMarkAdjustmentRecords>b__26_0(MarkToMarkAdjustmentRecord s) { }

	// RVA: 0x1EA51B4 Offset: 0x1EA11B4 VA: 0x1EA51B4
	internal uint <SortMarkToMarkAdjustmentRecords>b__26_1(MarkToMarkAdjustmentRecord s) { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class FontFeatureTable // TypeDefIndex: 7440
{
	// Fields
	[SerializeField]
	internal List<MultipleSubstitutionRecord> m_MultipleSubstitutionRecords; // 0x10
	[SerializeField]
	internal List<LigatureSubstitutionRecord> m_LigatureSubstitutionRecords; // 0x18
	[SerializeField]
	private List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x20
	[SerializeField]
	internal List<MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords; // 0x28
	[SerializeField]
	internal List<MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords; // 0x30
	internal Dictionary<uint, List<LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup; // 0x38
	internal Dictionary<uint, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; // 0x40
	internal Dictionary<uint, MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup; // 0x48
	internal Dictionary<uint, MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup; // 0x50

	// Properties
	internal List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; }
	internal List<MarkToBaseAdjustmentRecord> MarkToBaseAdjustmentRecords { get; }
	internal List<MarkToMarkAdjustmentRecord> MarkToMarkAdjustmentRecords { get; }

	// Methods

	// RVA: 0x1EA4788 Offset: 0x1EA0788 VA: 0x1EA4788
	internal List<GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	// RVA: 0x1EA4790 Offset: 0x1EA0790 VA: 0x1EA4790
	internal List<MarkToBaseAdjustmentRecord> get_MarkToBaseAdjustmentRecords() { }

	// RVA: 0x1EA4798 Offset: 0x1EA0798 VA: 0x1EA4798
	internal List<MarkToMarkAdjustmentRecord> get_MarkToMarkAdjustmentRecords() { }

	// RVA: 0x1EA47A0 Offset: 0x1EA07A0 VA: 0x1EA47A0
	internal void .ctor() { }

	// RVA: 0x1EA4A54 Offset: 0x1EA0A54 VA: 0x1EA4A54
	public void SortGlyphPairAdjustmentRecords() { }

	// RVA: 0x1EA4C60 Offset: 0x1EA0C60 VA: 0x1EA4C60
	public void SortMarkToBaseAdjustmentRecords() { }

	// RVA: 0x1EA4E78 Offset: 0x1EA0E78 VA: 0x1EA4E78
	public void SortMarkToMarkAdjustmentRecords() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct Extents // TypeDefIndex: 7441
{
	// Fields
	public Vector2 min; // 0x0
	public Vector2 max; // 0x8

	// Methods

	// RVA: 0x1EA51C0 Offset: 0x1EA11C0 VA: 0x1EA51C0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal struct LineInfo // TypeDefIndex: 7442
{
	// Fields
	internal int controlCharacterCount; // 0x0
	public int characterCount; // 0x4
	public int visibleCharacterCount; // 0x8
	public int visibleSpaceCount; // 0xC
	public int spaceCount; // 0x10
	public int wordCount; // 0x14
	public int firstCharacterIndex; // 0x18
	public int firstVisibleCharacterIndex; // 0x1C
	public int lastCharacterIndex; // 0x20
	public int lastVisibleCharacterIndex; // 0x24
	public float length; // 0x28
	public float lineHeight; // 0x2C
	public float ascender; // 0x30
	public float baseline; // 0x34
	public float descender; // 0x38
	public float maxAdvance; // 0x3C
	public float width; // 0x40
	public float marginLeft; // 0x44
	public float marginRight; // 0x48
	public TextAlignment alignment; // 0x4C
	public Extents lineExtents; // 0x50
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal struct LinkInfo // TypeDefIndex: 7443
{
	// Fields
	public int hashCode; // 0x0
	public int linkIdFirstCharacterIndex; // 0x4
	public int linkIdLength; // 0x8
	public int linkTextfirstCharacterIndex; // 0xC
	public int linkTextLength; // 0x10
	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	internal char[] linkId; // 0x18
	private string m_LinkIdString; // 0x20
	private string m_LinkTextString; // 0x28

	// Methods

	// RVA: 0x1EA53E8 Offset: 0x1EA13E8 VA: 0x1EA53E8
	internal void SetLinkId(char[] text, int startIndex, int length) { }
}

// Namespace: UnityEngine.TextCore.Text
internal static class MaterialManager // TypeDefIndex: 7444
{
	// Fields
	private static Dictionary<long, Material> s_FallbackMaterials; // 0x0

	// Methods

	// RVA: 0x1EA54F8 Offset: 0x1EA14F8 VA: 0x1EA54F8
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x1EA5BC8 Offset: 0x1EA1BC8 VA: 0x1EA5BC8
	public static Material GetFallbackMaterial(FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x1EA5940 Offset: 0x1EA1940 VA: 0x1EA5940
	private static void CopyMaterialPresetProperties(Material source, Material destination) { }

	// RVA: 0x1EA5E00 Offset: 0x1EA1E00 VA: 0x1EA5E00
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct MaterialReference // TypeDefIndex: 7445
{
	// Fields
	public int index; // 0x0
	public FontAsset fontAsset; // 0x8
	public SpriteAsset spriteAsset; // 0x10
	public Material material; // 0x18
	public bool isFallbackMaterial; // 0x20
	public Material fallbackMaterial; // 0x28
	public float padding; // 0x30
	public int referenceCount; // 0x34

	// Methods

	// RVA: 0x1EA5E98 Offset: 0x1EA1E98 VA: 0x1EA5E98
	public void .ctor(int index, FontAsset fontAsset, SpriteAsset spriteAsset, Material material, float padding) { }

	// RVA: 0x1EA5F10 Offset: 0x1EA1F10 VA: 0x1EA5F10
	public static int AddMaterialReference(Material material, FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

	// RVA: 0x1EA6110 Offset: 0x1EA2110 VA: 0x1EA6110
	public static int AddMaterialReference(Material material, SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }
}

// Namespace: UnityEngine.TextCore.Text
internal class MaterialReferenceManager // TypeDefIndex: 7446
{
	// Fields
	private static MaterialReferenceManager s_Instance; // 0x0
	private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
	private Dictionary<int, FontAsset> m_FontAssetReferenceLookup; // 0x18
	private Dictionary<int, SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
	private Dictionary<int, TextColorGradient> m_ColorGradientReferenceLookup; // 0x28

	// Properties
	public static MaterialReferenceManager instance { get; }

	// Methods

	// RVA: 0x1EA6314 Offset: 0x1EA2314 VA: 0x1EA6314
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0x1EA651C Offset: 0x1EA251C VA: 0x1EA651C
	public static void AddFontAsset(FontAsset fontAsset) { }

	// RVA: 0x1EA653C Offset: 0x1EA253C VA: 0x1EA653C
	private void AddFontAssetInternal(FontAsset fontAsset) { }

	// RVA: 0x1EA66EC Offset: 0x1EA26EC VA: 0x1EA66EC
	public static void AddSpriteAsset(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x1EA671C Offset: 0x1EA271C VA: 0x1EA671C
	private void AddSpriteAssetInternal(int hashCode, SpriteAsset spriteAsset) { }

	// RVA: 0x1EA67F4 Offset: 0x1EA27F4 VA: 0x1EA67F4
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0x1EA6824 Offset: 0x1EA2824 VA: 0x1EA6824
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0x1EA688C Offset: 0x1EA288C VA: 0x1EA688C
	public static void AddColorGradientPreset(int hashCode, TextColorGradient spriteAsset) { }

	// RVA: 0x1EA68BC Offset: 0x1EA28BC VA: 0x1EA68BC
	private void AddColorGradientPreset_Internal(int hashCode, TextColorGradient spriteAsset) { }

	// RVA: 0x1EA6960 Offset: 0x1EA2960 VA: 0x1EA6960
	public static bool TryGetFontAsset(int hashCode, out FontAsset fontAsset) { }

	// RVA: 0x1EA6990 Offset: 0x1EA2990 VA: 0x1EA6990
	private bool TryGetFontAssetInternal(int hashCode, out FontAsset fontAsset) { }

	// RVA: 0x1EA6A08 Offset: 0x1EA2A08 VA: 0x1EA6A08
	public static bool TryGetSpriteAsset(int hashCode, out SpriteAsset spriteAsset) { }

	// RVA: 0x1EA6A38 Offset: 0x1EA2A38 VA: 0x1EA6A38
	private bool TryGetSpriteAssetInternal(int hashCode, out SpriteAsset spriteAsset) { }

	// RVA: 0x1EA6AB0 Offset: 0x1EA2AB0 VA: 0x1EA6AB0
	public static bool TryGetColorGradientPreset(int hashCode, out TextColorGradient gradientPreset) { }

	// RVA: 0x1EA6AE0 Offset: 0x1EA2AE0 VA: 0x1EA6AE0
	private bool TryGetColorGradientPresetInternal(int hashCode, out TextColorGradient gradientPreset) { }

	// RVA: 0x1EA6B58 Offset: 0x1EA2B58 VA: 0x1EA6B58
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	// RVA: 0x1EA6B88 Offset: 0x1EA2B88 VA: 0x1EA6B88
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	// RVA: 0x1EA6398 Offset: 0x1EA2398 VA: 0x1EA6398
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[NativeHeader("Modules/TextCoreTextEngine/Native/MeshInfo.h")]
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
[UsedByNativeCode("MeshInfo")]
internal struct MeshInfoBindings // TypeDefIndex: 7447
{
	// Fields
	public TextCoreVertex[] vertexData; // 0x0
	public Material material; // 0x8
	public int vertexCount; // 0x10
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal struct MeshInfo // TypeDefIndex: 7448
{
	// Fields
	public int vertexCount; // 0x0
	public TextCoreVertex[] vertexData; // 0x8
	public Material material; // 0x10
	[Ignore]
	public int vertexBufferSize; // 0x18
	[Ignore]
	public bool applySDF; // 0x1C
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal GlyphRenderMode glyphRenderMode; // 0x20

	// Methods

	// RVA: 0x1EA6C00 Offset: 0x1EA2C00 VA: 0x1EA6C00
	public void .ctor(int size, bool isIMGUI) { }

	// RVA: 0x1EA6CC8 Offset: 0x1EA2CC8 VA: 0x1EA6CC8
	internal void ResizeMeshInfo(int size, bool isIMGUI) { }

	// RVA: 0x1EA6D3C Offset: 0x1EA2D3C VA: 0x1EA6D3C
	internal void Clear(bool uploadChanges) { }

	// RVA: 0x1EA6D7C Offset: 0x1EA2D7C VA: 0x1EA6D7C
	internal void ClearUnusedVertices() { }
}

// Namespace: UnityEngine.TextCore.Text
public enum TextFontWeight // TypeDefIndex: 7449
{
	// Fields
	public int value__; // 0x0
	public const TextFontWeight Thin = 100;
	public const TextFontWeight ExtraLight = 200;
	public const TextFontWeight Light = 300;
	public const TextFontWeight Regular = 400;
	public const TextFontWeight Medium = 500;
	public const TextFontWeight SemiBold = 600;
	public const TextFontWeight Bold = 700;
	public const TextFontWeight Heavy = 800;
	public const TextFontWeight Black = 900;
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public struct FontWeightPair // TypeDefIndex: 7450
{
	// Fields
	public FontAsset regularTypeface; // 0x0
	public FontAsset italicTypeface; // 0x8
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromDocs]
[Serializable]
public struct FontAssetCreationEditorSettings // TypeDefIndex: 7451
{
	// Fields
	public string sourceFontFileGUID; // 0x0
	public int faceIndex; // 0x8
	public int pointSizeSamplingMode; // 0xC
	public float pointSize; // 0x10
	public int padding; // 0x14
	public int paddingMode; // 0x18
	public int packingMode; // 0x1C
	public int atlasWidth; // 0x20
	public int atlasHeight; // 0x24
	public int characterSetSelectionMode; // 0x28
	public string characterSequence; // 0x30
	public string referencedFontAssetGUID; // 0x38
	public string referencedTextAssetGUID; // 0x40
	public int fontStyle; // 0x48
	public float fontStyleModifier; // 0x4C
	public int renderMode; // 0x50
	public bool includeFontFeatures; // 0x54
}

// Namespace: UnityEngine.TextCore.Text
public enum AtlasPopulationMode // TypeDefIndex: 7452
{
	// Fields
	public int value__; // 0x0
	public const AtlasPopulationMode Static = 0;
	public const AtlasPopulationMode Dynamic = 1;
	public const AtlasPopulationMode DynamicOS = 2;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FontAsset.<>c // TypeDefIndex: 7453
{
	// Fields
	public static readonly FontAsset.<>c <>9; // 0x0
	public static Func<Character, uint> <>9__190_0; // 0x8
	public static Func<Glyph, uint> <>9__191_0; // 0x10

	// Methods

	// RVA: 0x1EB38B8 Offset: 0x1EAF8B8 VA: 0x1EB38B8
	private static void .cctor() { }

	// RVA: 0x1EB3920 Offset: 0x1EAF920 VA: 0x1EB3920
	public void .ctor() { }

	// RVA: 0x1EB3928 Offset: 0x1EAF928 VA: 0x1EB3928
	internal uint <SortCharacterTable>b__190_0(Character c) { }

	// RVA: 0x1EB3940 Offset: 0x1EAF940 VA: 0x1EB3940
	internal uint <SortGlyphTable>b__191_0(Glyph c) { }
}

// Namespace: UnityEngine.TextCore.Text
[NativeHeader("Modules/TextCoreTextEngine/Native/FontAsset.h")]
[ExcludeFromPreset]
[Serializable]
public class FontAsset : TextAsset // TypeDefIndex: 7454
{
	// Fields
	private static Dictionary<int, FontAsset> kFontAssetByInstanceId; // 0x0
	[SerializeField]
	internal string m_SourceFontFileGUID; // 0x38
	[SerializeField]
	internal FontAssetCreationEditorSettings m_fontAssetCreationEditorSettings; // 0x40
	[SerializeField]
	private Font m_SourceFontFile; // 0x98
	[SerializeField]
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal string m_SourceFontFilePath; // 0xA0
	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode; // 0xA8
	[SerializeField]
	internal bool InternalDynamicOS; // 0xAC
	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	[SerializeField]
	internal bool IsEditorFont; // 0xAD
	[SerializeField]
	internal FaceInfo m_FaceInfo; // 0xB0
	private int m_FamilyNameHashCode; // 0x110
	private int m_StyleNameHashCode; // 0x114
	[SerializeField]
	[Nullable(1)]
	internal List<Glyph> m_GlyphTable; // 0x118
	internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0x120
	[SerializeField]
	internal List<Character> m_CharacterTable; // 0x128
	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	internal Dictionary<uint, Character> m_CharacterLookupDictionary; // 0x130
	internal Texture2D m_AtlasTexture; // 0x138
	[SerializeField]
	internal Texture2D[] m_AtlasTextures; // 0x140
	[SerializeField]
	internal int m_AtlasTextureIndex; // 0x148
	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled; // 0x14C
	[SerializeField]
	private bool m_GetFontFeatures; // 0x14D
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; // 0x14E
	[SerializeField]
	internal int m_AtlasWidth; // 0x150
	[SerializeField]
	internal int m_AtlasHeight; // 0x154
	[SerializeField]
	internal int m_AtlasPadding; // 0x158
	[SerializeField]
	internal GlyphRenderMode m_AtlasRenderMode; // 0x15C
	[SerializeField]
	private List<GlyphRect> m_UsedGlyphRects; // 0x160
	[SerializeField]
	private List<GlyphRect> m_FreeGlyphRects; // 0x168
	[SerializeField]
	internal FontFeatureTable m_FontFeatureTable; // 0x170
	[SerializeField]
	internal bool m_ShouldReimportFontFeatures; // 0x178
	[SerializeField]
	internal List<FontAsset> m_FallbackFontAssetTable; // 0x180
	[SerializeField]
	private FontWeightPair[] m_FontWeightTable; // 0x188
	[FormerlySerializedAs("normalStyle")]
	[SerializeField]
	internal float m_RegularStyleWeight; // 0x190
	[SerializeField]
	[FormerlySerializedAs("normalSpacingOffset")]
	internal float m_RegularStyleSpacing; // 0x194
	[SerializeField]
	[FormerlySerializedAs("boldStyle")]
	internal float m_BoldStyleWeight; // 0x198
	[FormerlySerializedAs("boldSpacing")]
	[SerializeField]
	internal float m_BoldStyleSpacing; // 0x19C
	[FormerlySerializedAs("italicStyle")]
	[SerializeField]
	internal byte m_ItalicStyleSlant; // 0x1A0
	[SerializeField]
	[FormerlySerializedAs("tabSize")]
	internal byte m_TabMultiple; // 0x1A1
	internal bool IsFontAssetLookupTablesDirty; // 0x1A2
	private IntPtr m_NativeFontAsset; // 0x1A8
	private List<Glyph> m_GlyphsToRender; // 0x1B0
	private List<Glyph> m_GlyphsRendered; // 0x1B8
	private List<uint> m_GlyphIndexList; // 0x1C0
	private List<uint> m_GlyphIndexListNewlyAdded; // 0x1C8
	internal List<uint> m_GlyphsToAdd; // 0x1D0
	internal HashSet<uint> m_GlyphsToAddLookup; // 0x1D8
	internal List<Character> m_CharactersToAdd; // 0x1E0
	internal HashSet<uint> m_CharactersToAddLookup; // 0x1E8
	internal List<uint> s_MissingCharacterList; // 0x1F0
	internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x1F8
	internal Dictionary<ValueTuple<uint, uint>, uint> m_VariantGlyphIndexes; // 0x200
	internal bool m_IsClone; // 0x208
	private static readonly List<WeakReference<FontAsset>> s_CallbackInstances; // 0x8
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x10
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x18
	private static ProfilerMarker k_TryAddGlyphMarker; // 0x20
	private static ProfilerMarker k_TryAddCharacterMarker; // 0x28
	private static ProfilerMarker k_TryAddCharactersMarker; // 0x30
	private static ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker; // 0x38
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x40
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; // 0x48
	private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x50
	private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x58
	private static string s_DefaultMaterialSuffix; // 0x60
	private static HashSet<int> k_SearchedFontAssetLookup; // 0x68
	private static List<FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x70
	private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x78
	private static List<FontAsset> k_FontAssets_KerningUpdateQueue; // 0x80
	private static HashSet<int> k_FontAssets_KerningUpdateQueueLookup; // 0x88
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; // 0x90
	private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x98
	internal static uint[] k_GlyphIndexArray; // 0xA0
	private static HashSet<int> visitedFontAssets; // 0xA8

	// Properties
	public FontAssetCreationEditorSettings fontAssetCreationEditorSettings { get; set; }
	public Font sourceFontFile { get; set; }
	public AtlasPopulationMode atlasPopulationMode { get; set; }
	public FaceInfo faceInfo { get; set; }
	internal int familyNameHashCode { get; set; }
	internal int styleNameHashCode { get; set; }
	[Nullable(1)]
	public List<Glyph> glyphTable { get; set; }
	public Dictionary<uint, Glyph> glyphLookupTable { get; }
	public List<Character> characterTable { get; set; }
	public Dictionary<uint, Character> characterLookupTable { get; }
	public Texture2D atlasTexture { get; }
	public Texture2D[] atlasTextures { get; set; }
	public int atlasTextureCount { get; }
	public bool isMultiAtlasTexturesEnabled { get; set; }
	public bool getFontFeatures { get; set; }
	internal bool clearDynamicDataOnBuild { get; set; }
	public int atlasWidth { get; set; }
	public int atlasHeight { get; set; }
	public int atlasPadding { get; set; }
	public GlyphRenderMode atlasRenderMode { get; set; }
	internal List<GlyphRect> usedGlyphRects { get; set; }
	internal List<GlyphRect> freeGlyphRects { get; set; }
	public FontFeatureTable fontFeatureTable { get; set; }
	public List<FontAsset> fallbackFontAssetTable { get; set; }
	public FontWeightPair[] fontWeightTable { get; set; }
	public float regularStyleWeight { get; set; }
	public float regularStyleSpacing { get; set; }
	public float boldStyleWeight { get; set; }
	public float boldStyleSpacing { get; set; }
	public byte italicStyleSlant { get; set; }
	public byte tabMultiple { get; set; }
	internal IntPtr nativeFontAsset { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static void EnsureAdditionalCapacity<T>(List<T> container, int additionalCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1115320 Offset: 0x1111320 VA: 0x1115320
	|-FontAsset.EnsureAdditionalCapacity<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x1115394 Offset: 0x1111394 VA: 0x1115394
	|-FontAsset.EnsureAdditionalCapacity<LigatureSubstitutionRecord>
	|
	|-RVA: 0x1115408 Offset: 0x1111408 VA: 0x1115408
	|-FontAsset.EnsureAdditionalCapacity<object>
	|
	|-RVA: 0x111547C Offset: 0x111147C VA: 0x111547C
	|-FontAsset.EnsureAdditionalCapacity<uint>
	|
	|-RVA: 0x11154F0 Offset: 0x11114F0 VA: 0x11154F0
	|-FontAsset.EnsureAdditionalCapacity<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void EnsureAdditionalCapacity<TKey, TValue>(Dictionary<TKey, TValue> container, int additionalCapacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111557C Offset: 0x111157C VA: 0x111557C
	|-FontAsset.EnsureAdditionalCapacity<uint, GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x11155D4 Offset: 0x11115D4 VA: 0x11155D4
	|-FontAsset.EnsureAdditionalCapacity<uint, object>
	|
	|-RVA: 0x111562C Offset: 0x111162C VA: 0x111562C
	|-FontAsset.EnsureAdditionalCapacity<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1EA6DC4 Offset: 0x1EA2DC4 VA: 0x1EA6DC4
	public FontAssetCreationEditorSettings get_fontAssetCreationEditorSettings() { }

	// RVA: 0x1EA6DD4 Offset: 0x1EA2DD4 VA: 0x1EA6DD4
	public void set_fontAssetCreationEditorSettings(FontAssetCreationEditorSettings value) { }

	// RVA: 0x1EA6DF8 Offset: 0x1EA2DF8 VA: 0x1EA6DF8
	public Font get_sourceFontFile() { }

	// RVA: 0x1EA6E00 Offset: 0x1EA2E00 VA: 0x1EA6E00
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x1EA6E08 Offset: 0x1EA2E08 VA: 0x1EA6E08
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x1EA6E10 Offset: 0x1EA2E10 VA: 0x1EA6E10
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0x1EA6E18 Offset: 0x1EA2E18 VA: 0x1EA6E18
	public FaceInfo get_faceInfo() { }

	// RVA: 0x1EA6E28 Offset: 0x1EA2E28 VA: 0x1EA6E28
	public void set_faceInfo(FaceInfo value) { }

	// RVA: 0x1EA6EF4 Offset: 0x1EA2EF4 VA: 0x1EA6EF4
	internal int get_familyNameHashCode() { }

	// RVA: 0x1EA6F24 Offset: 0x1EA2F24 VA: 0x1EA6F24
	internal void set_familyNameHashCode(int value) { }

	// RVA: 0x1EA6F2C Offset: 0x1EA2F2C VA: 0x1EA6F2C
	internal int get_styleNameHashCode() { }

	// RVA: 0x1EA6F5C Offset: 0x1EA2F5C VA: 0x1EA6F5C
	internal void set_styleNameHashCode(int value) { }

	[NullableContext(1)]
	// RVA: 0x1EA6F64 Offset: 0x1EA2F64 VA: 0x1EA6F64
	public List<Glyph> get_glyphTable() { }

	[NullableContext(1)]
	// RVA: 0x1EA6F6C Offset: 0x1EA2F6C VA: 0x1EA6F6C
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0x1EA6F7C Offset: 0x1EA2F7C VA: 0x1EA6F7C
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x1EA7670 Offset: 0x1EA3670 VA: 0x1EA7670
	public List<Character> get_characterTable() { }

	// RVA: 0x1EA7678 Offset: 0x1EA3678 VA: 0x1EA7678
	internal void set_characterTable(List<Character> value) { }

	// RVA: 0x1EA7688 Offset: 0x1EA3688 VA: 0x1EA7688
	public Dictionary<uint, Character> get_characterLookupTable() { }

	// RVA: 0x1EA76AC Offset: 0x1EA36AC VA: 0x1EA76AC
	public Texture2D get_atlasTexture() { }

	// RVA: 0x1EA7740 Offset: 0x1EA3740 VA: 0x1EA7740
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0x1EA7748 Offset: 0x1EA3748 VA: 0x1EA7748
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x1EA7758 Offset: 0x1EA3758 VA: 0x1EA7758
	public int get_atlasTextureCount() { }

	// RVA: 0x1EA7764 Offset: 0x1EA3764 VA: 0x1EA7764
	public bool get_isMultiAtlasTexturesEnabled() { }

	// RVA: 0x1EA776C Offset: 0x1EA376C VA: 0x1EA776C
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	// RVA: 0x1EA7774 Offset: 0x1EA3774 VA: 0x1EA7774
	public bool get_getFontFeatures() { }

	// RVA: 0x1EA777C Offset: 0x1EA377C VA: 0x1EA777C
	public void set_getFontFeatures(bool value) { }

	// RVA: 0x1EA7784 Offset: 0x1EA3784 VA: 0x1EA7784
	internal bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x1EA778C Offset: 0x1EA378C VA: 0x1EA778C
	internal void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x1EA7794 Offset: 0x1EA3794 VA: 0x1EA7794
	public int get_atlasWidth() { }

	// RVA: 0x1EA779C Offset: 0x1EA379C VA: 0x1EA779C
	internal void set_atlasWidth(int value) { }

	// RVA: 0x1EA77A4 Offset: 0x1EA37A4 VA: 0x1EA77A4
	public int get_atlasHeight() { }

	// RVA: 0x1EA77AC Offset: 0x1EA37AC VA: 0x1EA77AC
	internal void set_atlasHeight(int value) { }

	// RVA: 0x1EA77B4 Offset: 0x1EA37B4 VA: 0x1EA77B4
	public int get_atlasPadding() { }

	// RVA: 0x1EA77BC Offset: 0x1EA37BC VA: 0x1EA77BC
	internal void set_atlasPadding(int value) { }

	// RVA: 0x1EA77C4 Offset: 0x1EA37C4 VA: 0x1EA77C4
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0x1EA77CC Offset: 0x1EA37CC VA: 0x1EA77CC
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x1EA77D4 Offset: 0x1EA37D4 VA: 0x1EA77D4
	internal bool IsBitmap() { }

	// RVA: 0x1EA77EC Offset: 0x1EA37EC VA: 0x1EA77EC
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x1EA77F4 Offset: 0x1EA37F4 VA: 0x1EA77F4
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x1EA7804 Offset: 0x1EA3804 VA: 0x1EA7804
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x1EA780C Offset: 0x1EA380C VA: 0x1EA780C
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x1EA781C Offset: 0x1EA381C VA: 0x1EA781C
	public FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0x1EA7824 Offset: 0x1EA3824 VA: 0x1EA7824
	internal void set_fontFeatureTable(FontFeatureTable value) { }

	// RVA: 0x1EA7834 Offset: 0x1EA3834 VA: 0x1EA7834
	public List<FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x1EA783C Offset: 0x1EA383C VA: 0x1EA783C
	public void set_fallbackFontAssetTable(List<FontAsset> value) { }

	// RVA: 0x1EA784C Offset: 0x1EA384C VA: 0x1EA784C
	public FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0x1EA7854 Offset: 0x1EA3854 VA: 0x1EA7854
	internal void set_fontWeightTable(FontWeightPair[] value) { }

	// RVA: 0x1EA7864 Offset: 0x1EA3864 VA: 0x1EA7864
	public float get_regularStyleWeight() { }

	// RVA: 0x1EA786C Offset: 0x1EA386C VA: 0x1EA786C
	public void set_regularStyleWeight(float value) { }

	// RVA: 0x1EA7874 Offset: 0x1EA3874 VA: 0x1EA7874
	public float get_regularStyleSpacing() { }

	// RVA: 0x1EA787C Offset: 0x1EA387C VA: 0x1EA787C
	public void set_regularStyleSpacing(float value) { }

	// RVA: 0x1EA7884 Offset: 0x1EA3884 VA: 0x1EA7884
	public float get_boldStyleWeight() { }

	// RVA: 0x1EA788C Offset: 0x1EA388C VA: 0x1EA788C
	public void set_boldStyleWeight(float value) { }

	// RVA: 0x1EA7894 Offset: 0x1EA3894 VA: 0x1EA7894
	public float get_boldStyleSpacing() { }

	// RVA: 0x1EA789C Offset: 0x1EA389C VA: 0x1EA789C
	public void set_boldStyleSpacing(float value) { }

	// RVA: 0x1EA78A4 Offset: 0x1EA38A4 VA: 0x1EA78A4
	public byte get_italicStyleSlant() { }

	// RVA: 0x1EA78AC Offset: 0x1EA38AC VA: 0x1EA78AC
	public void set_italicStyleSlant(byte value) { }

	// RVA: 0x1EA78B4 Offset: 0x1EA38B4 VA: 0x1EA78B4
	public byte get_tabMultiple() { }

	// RVA: 0x1EA78BC Offset: 0x1EA38BC VA: 0x1EA78BC
	public void set_tabMultiple(byte value) { }

	// RVA: 0x1EA78C4 Offset: 0x1EA38C4 VA: 0x1EA78C4
	public static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	[NullableContext(1)]
	// RVA: 0x1EA7AC4 Offset: 0x1EA3AC4 VA: 0x1EA7AC4
	internal static FontAsset CreateFontAssetInternal(string familyName, string styleName, int pointSize = 90) { }

	[NullableContext(1)]
	// RVA: 0x1EA7D6C Offset: 0x1EA3D6C VA: 0x1EA7D6C
	internal static FontAsset CreateFontAsset(string familyName, string styleName, int pointSize, int padding, GlyphRenderMode renderMode) { }

	// RVA: 0x1EA7E64 Offset: 0x1EA3E64 VA: 0x1EA7E64
	internal static List<FontAsset> CreateFontAssetOSFallbackList(string[] fallbacksFamilyNames, int pointSize = 90) { }

	// RVA: 0x1EA8178 Offset: 0x1EA4178 VA: 0x1EA8178
	internal static FontAsset CreateFontAssetWithOSFallbackList(string[] fallbacksFamilyNames, int pointSize = 90) { }

	// RVA: 0x1EA8010 Offset: 0x1EA4010 VA: 0x1EA8010
	private static FontAsset CreateFontAssetFromFamilyName(string familyName, int pointSize = 90) { }

	// RVA: 0x1EA843C Offset: 0x1EA443C VA: 0x1EA843C
	public static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	// RVA: 0x1EA7BAC Offset: 0x1EA3BAC VA: 0x1EA7BAC
	private static FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x1EA8AC8 Offset: 0x1EA4AC8 VA: 0x1EA8AC8
	public static FontAsset CreateFontAsset(Font font) { }

	// RVA: 0x1EA8B44 Offset: 0x1EA4B44 VA: 0x1EA8B44
	public static FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x1EA8C04 Offset: 0x1EA4C04 VA: 0x1EA8C04
	private static FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x1EA84F0 Offset: 0x1EA44F0 VA: 0x1EA84F0
	private static FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1EA8F58 Offset: 0x1EA4F58 VA: 0x1EA8F58
	internal static FontAsset GetFontAssetByID(int id) { }

	// RVA: 0x1EA8FD8 Offset: 0x1EA4FD8 VA: 0x1EA8FD8
	private void RegisterCallbackInstance(FontAsset instance) { }

	// RVA: 0x1EA92E4 Offset: 0x1EA52E4 VA: 0x1EA92E4
	private void OnDestroy() { }

	// RVA: 0x1EA6FA0 Offset: 0x1EA2FA0 VA: 0x1EA6FA0
	public void ReadFontAssetDefinition() { }

	// RVA: 0x1EA95B8 Offset: 0x1EA55B8 VA: 0x1EA95B8
	internal void InitializeDictionaryLookupTables() { }

	// RVA: -1 Offset: -1
	private static void InitializeLookup<T>(ICollection source, ref Dictionary<uint, T> lookup, int defaultCapacity = 16) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11158F0 Offset: 0x11118F0 VA: 0x11158F0
	|-FontAsset.InitializeLookup<GlyphPairAdjustmentRecord>
	|
	|-RVA: 0x1115A20 Offset: 0x1111A20 VA: 0x1115A20
	|-FontAsset.InitializeLookup<MarkToBaseAdjustmentRecord>
	|
	|-RVA: 0x1115B50 Offset: 0x1111B50 VA: 0x1115B50
	|-FontAsset.InitializeLookup<MarkToMarkAdjustmentRecord>
	|
	|-RVA: 0x1115C80 Offset: 0x1111C80 VA: 0x1115C80
	|-FontAsset.InitializeLookup<object>
	|
	|-RVA: 0x1115DB0 Offset: 0x1111DB0 VA: 0x1115DB0
	|-FontAsset.InitializeLookup<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void InitializeList<T>(ICollection source, ref List<T> list, int defaultCapacity = 16) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111568C Offset: 0x111168C VA: 0x111568C
	|-FontAsset.InitializeList<uint>
	|
	|-RVA: 0x11157B4 Offset: 0x11117B4 VA: 0x11157B4
	|-FontAsset.InitializeList<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1EA97E0 Offset: 0x1EA57E0 VA: 0x1EA97E0
	internal void InitializeGlyphLookupDictionary() { }

	// RVA: 0x1EA9A78 Offset: 0x1EA5A78 VA: 0x1EA9A78
	internal void InitializeCharacterLookupDictionary() { }

	// RVA: 0x1EAA86C Offset: 0x1EA686C VA: 0x1EAA86C
	internal void ClearFallbackCharacterTable() { }

	// RVA: 0x1EA9DE4 Offset: 0x1EA5DE4 VA: 0x1EA9DE4
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	// RVA: 0x1EAA1B8 Offset: 0x1EA61B8 VA: 0x1EAA1B8
	internal void InitializeGlyphPairAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x1EAA43C Offset: 0x1EA643C VA: 0x1EAA43C
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x1EAA654 Offset: 0x1EA6654 VA: 0x1EAA654
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x1EA9610 Offset: 0x1EA5610 VA: 0x1EA9610
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	// RVA: 0x1EAAD68 Offset: 0x1EA6D68 VA: 0x1EAAD68
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = False) { }

	// RVA: 0x1EAB610 Offset: 0x1EA7610 VA: 0x1EAB610
	internal void AddCharacterToLookupCache(uint unicode, Character character) { }

	// RVA: 0x1EAB61C Offset: 0x1EA761C VA: 0x1EAB61C
	internal void AddCharacterToLookupCache(uint unicode, Character character, FontStyles fontStyle, TextFontWeight fontWeight) { }

	// RVA: 0x1EAB6CC Offset: 0x1EA76CC VA: 0x1EAB6CC
	internal bool GetCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight, out Character character) { }

	// RVA: 0x1EAB77C Offset: 0x1EA777C VA: 0x1EAB77C
	internal void RemoveCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight) { }

	// RVA: 0x1EAB81C Offset: 0x1EA781C VA: 0x1EAB81C
	internal bool ContainsCharacterInLookupCache(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight) { }

	// RVA: 0x1EAB5B4 Offset: 0x1EA75B4 VA: 0x1EAB5B4
	private uint CreateCompositeKey(uint unicode, FontStyles fontStyle = 0, TextFontWeight fontWeight = 400) { }

	// RVA: 0x1EAABE8 Offset: 0x1EA6BE8 VA: 0x1EAABE8
	internal FontEngineError LoadFontFace() { }

	// RVA: 0x1EAB8BC Offset: 0x1EA78BC VA: 0x1EAB8BC
	internal void SortCharacterTable() { }

	// RVA: 0x1EABA10 Offset: 0x1EA7A10 VA: 0x1EABA10
	internal void SortGlyphTable() { }

	// RVA: 0x1EABB64 Offset: 0x1EA7B64 VA: 0x1EABB64
	internal void SortFontFeatureTable() { }

	// RVA: 0x1EABB98 Offset: 0x1EA7B98 VA: 0x1EABB98
	internal void SortAllTables() { }

	// RVA: 0x1EABBB8 Offset: 0x1EA7BB8 VA: 0x1EABBB8
	public bool HasCharacter(int character) { }

	// RVA: 0x1EABC28 Offset: 0x1EA7C28 VA: 0x1EABC28
	public bool HasCharacter(char character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x1EABC30 Offset: 0x1EA7C30 VA: 0x1EABC30
	public bool HasCharacter(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x1EAC4FC Offset: 0x1EA84FC VA: 0x1EAC4FC
	private bool HasCharacterWithStyle_Internal(uint character, FontStyles fontStyle, TextFontWeight fontWeight, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x1EAC2C8 Offset: 0x1EA82C8 VA: 0x1EAC2C8
	private bool HasCharacter_Internal(uint character, FontStyles fontStyle = 0, TextFontWeight fontWeight = 400, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x1EAC500 Offset: 0x1EA8500 VA: 0x1EAC500
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0x1EAC7C0 Offset: 0x1EA87C0 VA: 0x1EAC7C0
	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x1EACC2C Offset: 0x1EA8C2C VA: 0x1EACC2C
	public bool HasCharacters(string text) { }

	// RVA: 0x1EACD00 Offset: 0x1EA8D00 VA: 0x1EACD00
	public static string GetCharacters(FontAsset fontAsset) { }

	// RVA: 0x1EACDF4 Offset: 0x1EA8DF4 VA: 0x1EACDF4
	public static int[] GetCharactersArray(FontAsset fontAsset) { }

	// RVA: 0x1EACEDC Offset: 0x1EA8EDC VA: 0x1EACEDC
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x1EACEF4 Offset: 0x1EA8EF4 VA: 0x1EACEF4
	internal uint GetGlyphIndex(uint unicode, out bool success) { }

	// RVA: 0x1EAD01C Offset: 0x1EA901C VA: 0x1EAD01C
	internal uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode) { }

	// RVA: 0x1EAD0A8 Offset: 0x1EA90A8 VA: 0x1EAD0A8
	internal void UpdateFontAssetData() { }

	// RVA: 0x1EAD688 Offset: 0x1EA9688 VA: 0x1EAD688
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0x1EAD91C Offset: 0x1EA991C VA: 0x1EAD91C
	internal void ClearCharacterAndGlyphTablesInternal() { }

	// RVA: 0x1EAD1D0 Offset: 0x1EA91D0 VA: 0x1EAD1D0
	private void ClearCharacterAndGlyphTables() { }

	// RVA: 0x1EAD3A4 Offset: 0x1EA93A4 VA: 0x1EAD3A4
	private void ClearFontFeaturesTables() { }

	// RVA: 0x1EAD478 Offset: 0x1EA9478 VA: 0x1EAD478
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = False) { }

	// RVA: 0x1EA9474 Offset: 0x1EA5474 VA: 0x1EA9474
	private void DestroyAtlasTextures() { }

	// RVA: 0x1EAD940 Offset: 0x1EA9940 VA: 0x1EAD940
	internal static void RegisterFontAssetForFontFeatureUpdate(FontAsset fontAsset) { }

	// RVA: 0x1EADA84 Offset: 0x1EA9A84 VA: 0x1EADA84
	internal static void RegisterFontAssetForKerningUpdate(FontAsset fontAsset) { }

	// RVA: 0x1EADBC8 Offset: 0x1EA9BC8 VA: 0x1EADBC8
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	// RVA: 0x1EADEC4 Offset: 0x1EA9EC4 VA: 0x1EADEC4
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	// RVA: 0x1EAE000 Offset: 0x1EAA000 VA: 0x1EAE000
	internal static void UpdateAtlasTexturesInQueue() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	// RVA: 0x1EAE174 Offset: 0x1EAA174 VA: 0x1EAE174
	internal static void UpdateFontAssetsInUpdateQueue() { }

	// RVA: 0x1EAD66C Offset: 0x1EA966C VA: 0x1EAD66C
	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = False) { }

	// RVA: 0x1EAE1C4 Offset: 0x1EAA1C4 VA: 0x1EAE1C4
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = False) { }

	// RVA: 0x1EAFA00 Offset: 0x1EABA00 VA: 0x1EAFA00
	public bool TryAddCharacters(string characters, bool includeFontFeatures = False) { }

	// RVA: 0x1EAFA1C Offset: 0x1EABA1C VA: 0x1EAFA1C
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = False) { }

	// RVA: 0x1EAFBBC Offset: 0x1EABBBC VA: 0x1EAFBBC
	internal bool TryAddGlyphVariantIndexInternal(uint unicode, uint nextCharacter, uint variantGlyphIndex) { }

	// RVA: 0x1EAFC68 Offset: 0x1EABC68 VA: 0x1EAFC68
	internal bool TryGetGlyphVariantIndexInternal(uint unicode, uint nextCharacter, out uint variantGlyphIndex) { }

	// RVA: 0x1EAFD14 Offset: 0x1EABD14 VA: 0x1EAFD14
	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph) { }

	// RVA: 0x1EB027C Offset: 0x1EAC27C VA: 0x1EB027C
	internal bool TryAddCharacterInternal(uint unicode, out Character character) { }

	// RVA: 0x1EABF60 Offset: 0x1EA7F60 VA: 0x1EABF60
	internal bool TryAddCharacterInternal(uint unicode, FontStyles fontStyle, TextFontWeight fontWeight, out Character character, bool populateLigatures = True) { }

	// RVA: 0x1EAFEB8 Offset: 0x1EABEB8 VA: 0x1EAFEB8
	private bool TryAddGlyphToAtlas(uint glyphIndex, out Glyph glyph, bool populateLigatures = True) { }

	// RVA: 0x1EB0400 Offset: 0x1EAC400 VA: 0x1EB0400
	private bool TryAddGlyphToTexture(uint glyphIndex, out Glyph glyph, bool populateLigatures = True) { }

	// RVA: 0x1EAF4C8 Offset: 0x1EAB4C8 VA: 0x1EAF4C8
	private bool TryAddGlyphsToNewAtlasTexture() { }

	// RVA: 0x1EB0728 Offset: 0x1EAC728 VA: 0x1EB0728
	private void SetupNewAtlasTexture() { }

	// RVA: 0x1EB0290 Offset: 0x1EAC290 VA: 0x1EB0290
	private Character CreateCharacterAndAddToCache(uint unicode, Glyph glyph, FontStyles fontStyle, TextFontWeight fontWeight) { }

	// RVA: 0x1EAF998 Offset: 0x1EAB998 VA: 0x1EAF998
	private void UpdateFontFeaturesForNewlyAddedGlyphs() { }

	// RVA: 0x1EADE6C Offset: 0x1EA9E6C VA: 0x1EADE6C
	private void UpdateGlyphAdjustmentRecordsForNewGlyphs() { }

	// RVA: 0x1EADE0C Offset: 0x1EA9E0C VA: 0x1EADE0C
	private void UpdateGPOSFontFeaturesForNewlyAddedGlyphs() { }

	// RVA: 0x1EA9CF4 Offset: 0x1EA5CF4 VA: 0x1EA9CF4
	internal void ImportFontFeatures() { }

	// RVA: 0x1EB0994 Offset: 0x1EAC994 VA: 0x1EB0994
	private void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex) { }

	// RVA: 0x1EB0A18 Offset: 0x1EACA18 VA: 0x1EB0A18
	internal void UpdateLigatureSubstitutionRecords() { }

	// RVA: 0x1EB16A0 Offset: 0x1EAD6A0 VA: 0x1EB16A0
	private void AddLigatureSubstitutionRecords(LigatureSubstitutionRecord[] records) { }

	// RVA: 0x1EB0A90 Offset: 0x1EACA90 VA: 0x1EB0A90
	internal void UpdateGlyphAdjustmentRecords() { }

	// RVA: 0x1EB0C80 Offset: 0x1EACC80 VA: 0x1EB0C80
	private void AddPairAdjustmentRecords(GlyphPairAdjustmentRecord[] records) { }

	// RVA: 0x1EB0B10 Offset: 0x1EACB10 VA: 0x1EB0B10
	internal void UpdateDiacriticalMarkAdjustmentRecords() { }

	// RVA: 0x1EB0FCC Offset: 0x1EACFCC VA: 0x1EB0FCC
	private void AddMarkToBaseAdjustmentRecords(MarkToBaseAdjustmentRecord[] records) { }

	// RVA: 0x1EB1330 Offset: 0x1EAD330 VA: 0x1EB1330
	private void AddMarkToMarkAdjustmentRecords(MarkToMarkAdjustmentRecord[] records) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1EB1B64 Offset: 0x1EADB64 VA: 0x1EB1B64
	internal IntPtr get_nativeFontAsset() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1EB1B7C Offset: 0x1EADB7C VA: 0x1EB1B7C
	internal void EnsureNativeFontAssetIsCreated() { }

	// RVA: 0x1EB26E8 Offset: 0x1EAE6E8 VA: 0x1EB26E8
	internal void UpdateFallbacks() { }

	// RVA: 0x1EB2858 Offset: 0x1EAE858 VA: 0x1EB2858
	internal void UpdateWeightFallbacks() { }

	// RVA: 0x1EA6E64 Offset: 0x1EA2E64 VA: 0x1EA6E64
	internal void UpdateFaceInfo() { }

	// RVA: 0x1EB1CCC Offset: 0x1EADCCC VA: 0x1EB1CCC
	internal IntPtr[] GetFallbacks() { }

	// RVA: 0x1EB2AA8 Offset: 0x1EAEAA8 VA: 0x1EB2AA8
	private bool HasRecursion(FontAsset fontAsset) { }

	// RVA: 0x1EB2B3C Offset: 0x1EAEB3C VA: 0x1EB2B3C
	private bool HasRecursionInternal(FontAsset fontAsset) { }

	// RVA: 0x1EB20BC Offset: 0x1EAE0BC VA: 0x1EB20BC
	private ValueTuple<IntPtr[], IntPtr[]> GetWeightFallbacks() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1EB2EA0 Offset: 0x1EAEEA0 VA: 0x1EB2EA0
	internal static void CreateHbFaceIfNeeded() { }

	// RVA: 0x1EB275C Offset: 0x1EAE75C VA: 0x1EB275C
	private static void UpdateFallbacks(IntPtr ptr, IntPtr[] fallbacks) { }

	// RVA: 0x1EB28D8 Offset: 0x1EAE8D8 VA: 0x1EB28D8
	private static void UpdateWeightFallbacks(IntPtr ptr, IntPtr[] regularFallbacks, IntPtr[] italicFallbacks) { }

	// RVA: 0x1EB23A0 Offset: 0x1EAE3A0 VA: 0x1EB23A0
	private static IntPtr Create(FaceInfo faceInfo, Font sourceFontFile, Font sourceFont_EditorRef, string sourceFontFilePath, int fontInstanceID, IntPtr[] fallbacks, IntPtr[] weightFallbacks, IntPtr[] italicFallbacks) { }

	// RVA: 0x1EB2A24 Offset: 0x1EAEA24 VA: 0x1EB2A24
	private static void UpdateFaceInfo(IntPtr ptr, FaceInfo faceInfo) { }

	[FreeFunction("FontAsset::Destroy")]
	// RVA: 0x1EA957C Offset: 0x1EA557C VA: 0x1EA957C
	private static void Destroy(IntPtr ptr) { }

	// RVA: 0x1EB3030 Offset: 0x1EAF030 VA: 0x1EB3030
	public void .ctor() { }

	// RVA: 0x1EB33B0 Offset: 0x1EAF3B0 VA: 0x1EB33B0
	private static void .cctor() { }

	// RVA: 0x1EB2EC8 Offset: 0x1EAEEC8 VA: 0x1EB2EC8
	private static void UpdateFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper fallbacks) { }

	// RVA: 0x1EB2F0C Offset: 0x1EAEF0C VA: 0x1EB2F0C
	private static void UpdateWeightFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper regularFallbacks, ref ManagedSpanWrapper italicFallbacks) { }

	// RVA: 0x1EB2F60 Offset: 0x1EAEF60 VA: 0x1EB2F60
	private static IntPtr Create_Injected(in FaceInfo faceInfo, IntPtr sourceFontFile, IntPtr sourceFont_EditorRef, ref ManagedSpanWrapper sourceFontFilePath, int fontInstanceID, ref ManagedSpanWrapper fallbacks, ref ManagedSpanWrapper weightFallbacks, ref ManagedSpanWrapper italicFallbacks) { }

	// RVA: 0x1EB2FEC Offset: 0x1EAEFEC VA: 0x1EB2FEC
	private static void UpdateFaceInfo_Injected(IntPtr ptr, in FaceInfo faceInfo) { }
}

// Namespace: UnityEngine.TextCore.Text
[Nullable(0)]
[NullableContext(1)]
internal class FontAssetFactory // TypeDefIndex: 7455
{
	// Fields
	private static readonly HashSet<FontAsset> visitedFontAssets; // 0x0

	// Methods

	// RVA: 0x1EB3958 Offset: 0x1EAF958 VA: 0x1EB3958
	internal static FontAsset ConvertFontToFontAsset(Font font) { }

	// RVA: 0x1EB3A6C Offset: 0x1EAFA6C VA: 0x1EB3A6C
	internal static void SetupFontAssetSettings(FontAsset fontAsset) { }

	// RVA: 0x1EA8380 Offset: 0x1EA4380 VA: 0x1EA8380
	public static void SetHideFlags(FontAsset fontAsset) { }

	// RVA: 0x1EB3B0C Offset: 0x1EAFB0C VA: 0x1EB3B0C
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal static class FontAssetUtilities // TypeDefIndex: 7456
{
	// Fields
	private static HashSet<int> k_SearchedAssets; // 0x0

	// Methods

	// RVA: 0x1EB3BA4 Offset: 0x1EAFBA4 VA: 0x1EB3BA4
	internal static Character GetCharacterFromFontAsset(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures) { }

	// RVA: 0x1EB3CBC Offset: 0x1EAFCBC VA: 0x1EB3CBC
	private static Character GetCharacterFromFontAsset_Internal(uint unicode, FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures) { }

	// RVA: 0x1EB42E4 Offset: 0x1EB02E4 VA: 0x1EB42E4
	internal static Character GetCharacterFromFontAssetsInternal(uint unicode, FontAsset sourceFontAsset, List<FontAsset> fontAssets, List<FontAsset> OSFallbackList, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures = True) { }

	// RVA: 0x1EB444C Offset: 0x1EB044C VA: 0x1EB444C
	private static Character GetCharacterFromFontAssetsInternal(uint unicode, List<FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures = True) { }

	// RVA: 0x1EB4620 Offset: 0x1EB0620 VA: 0x1EB4620
	internal static TextElement GetTextElementFromTextAssets(uint unicode, FontAsset sourceFontAsset, List<TextAsset> textAssets, bool includeFallbacks, FontStyles fontStyle, TextFontWeight fontWeight, out bool isAlternativeTypeface, bool populateLigatures) { }

	// RVA: 0x1EB4AAC Offset: 0x1EB0AAC VA: 0x1EB4AAC
	public static SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x1EB48F0 Offset: 0x1EB08F0 VA: 0x1EB48F0
	private static SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x1EAC6C0 Offset: 0x1EA86C0 VA: 0x1EAC6C0
	public static uint GetCodePoint(string text, ref int index) { }

	// RVA: 0x1EAF3C8 Offset: 0x1EAB3C8 VA: 0x1EAF3C8
	public static uint GetCodePoint(uint[] codesPoints, ref int index) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SpriteAsset.<>c // TypeDefIndex: 7457
{
	// Fields
	public static readonly SpriteAsset.<>c <>9; // 0x0
	public static Func<SpriteGlyph, uint> <>9__44_0; // 0x8
	public static Func<SpriteCharacter, uint> <>9__45_0; // 0x10

	// Methods

	// RVA: 0x1EB61E8 Offset: 0x1EB21E8 VA: 0x1EB61E8
	private static void .cctor() { }

	// RVA: 0x1EB6250 Offset: 0x1EB2250 VA: 0x1EB6250
	public void .ctor() { }

	// RVA: 0x1EB6258 Offset: 0x1EB2258 VA: 0x1EB6258
	internal uint <SortGlyphTable>b__44_0(SpriteGlyph item) { }

	// RVA: 0x1EB6270 Offset: 0x1EB2270 VA: 0x1EB6270
	internal uint <SortCharacterTable>b__45_0(SpriteCharacter c) { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromPreset]
[HelpURL("https://docs.unity3d.com/2023.3/Documentation/Manual/UIE-sprite.html")]
public class SpriteAsset : TextAsset // TypeDefIndex: 7458
{
	// Fields
	internal Dictionary<int, int> m_NameLookup; // 0x38
	internal Dictionary<uint, int> m_GlyphIndexLookup; // 0x40
	[SerializeField]
	internal FaceInfo m_FaceInfo; // 0x48
	[FormerlySerializedAs("spriteSheet")]
	[SerializeField]
	internal Texture m_SpriteAtlasTexture; // 0xA8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private float <width>k__BackingField; // 0xB0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private float <height>k__BackingField; // 0xB4
	[SerializeField]
	private List<SpriteCharacter> m_SpriteCharacterTable; // 0xB8
	internal Dictionary<uint, SpriteCharacter> m_SpriteCharacterLookup; // 0xC0
	[SerializeField]
	private List<SpriteGlyph> m_SpriteGlyphTable; // 0xC8
	internal Dictionary<uint, SpriteGlyph> m_SpriteGlyphLookup; // 0xD0
	[SerializeField]
	public List<SpriteAsset> fallbackSpriteAssets; // 0xD8
	internal bool m_IsSpriteAssetLookupTablesDirty; // 0xE0

	// Properties
	public FaceInfo faceInfo { get; set; }
	public Texture spriteSheet { get; set; }
	internal float width { get; set; }
	internal float height { get; set; }
	public List<SpriteCharacter> spriteCharacterTable { get; set; }
	public Dictionary<uint, SpriteCharacter> spriteCharacterLookupTable { get; set; }
	public List<SpriteGlyph> spriteGlyphTable { get; set; }

	// Methods

	// RVA: 0x1EB4D90 Offset: 0x1EB0D90 VA: 0x1EB4D90
	public FaceInfo get_faceInfo() { }

	// RVA: 0x1EB4DA0 Offset: 0x1EB0DA0 VA: 0x1EB4DA0
	internal void set_faceInfo(FaceInfo value) { }

	// RVA: 0x1EB4DC4 Offset: 0x1EB0DC4 VA: 0x1EB4DC4
	public Texture get_spriteSheet() { }

	// RVA: 0x1EB4DCC Offset: 0x1EB0DCC VA: 0x1EB4DCC
	internal void set_spriteSheet(Texture value) { }

	[CompilerGenerated]
	// RVA: 0x1EB4E30 Offset: 0x1EB0E30 VA: 0x1EB4E30
	internal float get_width() { }

	[CompilerGenerated]
	// RVA: 0x1EB4E38 Offset: 0x1EB0E38 VA: 0x1EB4E38
	private void set_width(float value) { }

	[CompilerGenerated]
	// RVA: 0x1EB4E40 Offset: 0x1EB0E40 VA: 0x1EB4E40
	internal float get_height() { }

	[CompilerGenerated]
	// RVA: 0x1EB4E48 Offset: 0x1EB0E48 VA: 0x1EB4E48
	private void set_height(float value) { }

	// RVA: 0x1EB4E50 Offset: 0x1EB0E50 VA: 0x1EB4E50
	public List<SpriteCharacter> get_spriteCharacterTable() { }

	// RVA: 0x1EB53D0 Offset: 0x1EB13D0 VA: 0x1EB53D0
	internal void set_spriteCharacterTable(List<SpriteCharacter> value) { }

	// RVA: 0x1EB4D6C Offset: 0x1EB0D6C VA: 0x1EB4D6C
	public Dictionary<uint, SpriteCharacter> get_spriteCharacterLookupTable() { }

	// RVA: 0x1EB53D8 Offset: 0x1EB13D8 VA: 0x1EB53D8
	internal void set_spriteCharacterLookupTable(Dictionary<uint, SpriteCharacter> value) { }

	// RVA: 0x1EB53E0 Offset: 0x1EB13E0 VA: 0x1EB53E0
	public List<SpriteGlyph> get_spriteGlyphTable() { }

	// RVA: 0x1EB53E8 Offset: 0x1EB13E8 VA: 0x1EB53E8
	internal void set_spriteGlyphTable(List<SpriteGlyph> value) { }

	// RVA: 0x1EB53F0 Offset: 0x1EB13F0 VA: 0x1EB53F0
	private void Awake() { }

	// RVA: 0x1EB4E74 Offset: 0x1EB0E74 VA: 0x1EB4E74
	public void UpdateLookupTables() { }

	// RVA: 0x1EB53FC Offset: 0x1EB13FC VA: 0x1EB53FC
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	// RVA: 0x1EB5484 Offset: 0x1EB1484 VA: 0x1EB5484
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	// RVA: 0x1EB551C Offset: 0x1EB151C VA: 0x1EB551C
	public int GetSpriteIndexFromName(string name) { }

	// RVA: 0x1EB555C Offset: 0x1EB155C VA: 0x1EB555C
	public static SpriteAsset SearchForSpriteByUnicode(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x1EB56C8 Offset: 0x1EB16C8 VA: 0x1EB56C8
	private static SpriteAsset SearchForSpriteByUnicodeInternal(List<SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, HashSet<int> searchedSpriteAssets, out int spriteIndex) { }

	// RVA: 0x1EB584C Offset: 0x1EB184C VA: 0x1EB584C
	private static SpriteAsset SearchForSpriteByUnicodeInternal(SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, HashSet<int> searchedSpriteAssets, out int spriteIndex) { }

	// RVA: 0x1EB5910 Offset: 0x1EB1910 VA: 0x1EB5910
	public static SpriteAsset SearchForSpriteByHashCode(SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex, TextSettings textSettings) { }

	// RVA: 0x1EB5C00 Offset: 0x1EB1C00 VA: 0x1EB5C00
	private static SpriteAsset SearchForSpriteByHashCodeInternal(List<SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, HashSet<int> searchedSpriteAssets, out int spriteIndex) { }

	// RVA: 0x1EB5D88 Offset: 0x1EB1D88 VA: 0x1EB5D88
	private static SpriteAsset SearchForSpriteByHashCodeInternal(SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, HashSet<int> searchedSpriteAssets, out int spriteIndex) { }

	// RVA: 0x1EB5E4C Offset: 0x1EB1E4C VA: 0x1EB5E4C
	public void SortGlyphTable() { }

	// RVA: 0x1EB5F9C Offset: 0x1EB1F9C VA: 0x1EB5F9C
	internal void SortCharacterTable() { }

	// RVA: 0x1EB60F0 Offset: 0x1EB20F0 VA: 0x1EB60F0
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0x1EB6108 Offset: 0x1EB2108 VA: 0x1EB6108
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class SpriteCharacter : TextElement // TypeDefIndex: 7459
{
	// Fields
	[SerializeField]
	private string m_Name; // 0x30

	// Properties
	public string name { get; }

	// Methods

	// RVA: 0x1EB53F4 Offset: 0x1EB13F4 VA: 0x1EB53F4
	public string get_name() { }

	// RVA: 0x1EB6288 Offset: 0x1EB2288 VA: 0x1EB6288
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class SpriteGlyph : Glyph // TypeDefIndex: 7460
{
	// Fields
	public Sprite sprite; // 0x48

	// Methods

	// RVA: 0x1EB62A8 Offset: 0x1EB22A8 VA: 0x1EB62A8
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromObjectFactory]
[Serializable]
public abstract class TextAsset : ScriptableObject // TypeDefIndex: 7461
{
	// Fields
	[SerializeField]
	internal string m_Version; // 0x18
	internal int m_InstanceID; // 0x20
	internal int m_HashCode; // 0x24
	[FormerlySerializedAs("material")]
	[SerializeField]
	internal Material m_Material; // 0x28
	internal int m_MaterialHashCode; // 0x30

	// Properties
	public string version { get; set; }
	public int instanceID { get; }
	public int hashCode { get; set; }
	public Material material { get; set; }
	public int materialHashCode { get; set; }

	// Methods

	// RVA: 0x1EB62B0 Offset: 0x1EB22B0 VA: 0x1EB62B0
	public string get_version() { }

	// RVA: 0x1EB62B8 Offset: 0x1EB22B8 VA: 0x1EB62B8
	internal void set_version(string value) { }

	// RVA: 0x1EA944C Offset: 0x1EA544C VA: 0x1EA944C
	public int get_instanceID() { }

	// RVA: 0x1EA6624 Offset: 0x1EA2624 VA: 0x1EA6624
	public int get_hashCode() { }

	// RVA: 0x1EB62C0 Offset: 0x1EB22C0 VA: 0x1EB62C0
	public void set_hashCode(int value) { }

	// RVA: 0x1EB62C8 Offset: 0x1EB22C8 VA: 0x1EB62C8
	public Material get_material() { }

	// RVA: 0x1EB62D0 Offset: 0x1EB22D0 VA: 0x1EB62D0
	public void set_material(Material value) { }

	// RVA: 0x1EA6654 Offset: 0x1EA2654 VA: 0x1EA6654
	public int get_materialHashCode() { }

	// RVA: 0x1EB62D8 Offset: 0x1EB22D8 VA: 0x1EB62D8
	public void set_materialHashCode(int value) { }

	// RVA: 0x1EB33A8 Offset: 0x1EAF3A8 VA: 0x1EB33A8
	protected void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
public enum ColorGradientMode // TypeDefIndex: 7462
{
	// Fields
	public int value__; // 0x0
	public const ColorGradientMode Single = 0;
	public const ColorGradientMode HorizontalGradient = 1;
	public const ColorGradientMode VerticalGradient = 2;
	public const ColorGradientMode FourCornersGradient = 3;
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[Serializable]
public class TextColorGradient : ScriptableObject // TypeDefIndex: 7463
{
	// Fields
	public ColorGradientMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorGradientMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0

	// Methods

	// RVA: 0x1EB62E0 Offset: 0x1EB22E0 VA: 0x1EB62E0
	public void .ctor() { }

	// RVA: 0x1EB637C Offset: 0x1EB237C VA: 0x1EB637C
	public void .ctor(Color color) { }

	// RVA: 0x1EB63E8 Offset: 0x1EB23E8 VA: 0x1EB63E8
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0x1EB648C Offset: 0x1EB248C VA: 0x1EB648C
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
internal struct TextSettings.FontReferenceMap // TypeDefIndex: 7464
{
	// Fields
	public Font font; // 0x0
	public FontAsset fontAsset; // 0x8

	// Methods

	// RVA: 0x1EC9360 Offset: 0x1EC5360 VA: 0x1EC9360
	public void .ctor(Font font, FontAsset fontAsset) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TextSettings.<>c__DisplayClass96_0 // TypeDefIndex: 7465
{
	// Fields
	public List<IntPtr> globalFontAssetFallbacks; // 0x10

	// Methods

	// RVA: 0x1EC9390 Offset: 0x1EC5390 VA: 0x1EC9390
	public void .ctor() { }

	// RVA: 0x1EC9398 Offset: 0x1EC5398 VA: 0x1EC9398
	internal void <GetGlobalFallbacks>b__0(FontAsset fallback) { }

	// RVA: 0x1EC955C Offset: 0x1EC555C VA: 0x1EC955C
	internal void <GetGlobalFallbacks>b__1(FontAsset fallback) { }

	// RVA: 0x1EC9720 Offset: 0x1EC5720 VA: 0x1EC9720
	internal void <GetGlobalFallbacks>b__2(TextAsset fallback) { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromPreset]
[ExcludeFromObjectFactory]
[NativeHeader("Modules/TextCoreTextEngine/Native/TextSettings.h")]
[Serializable]
public class TextSettings : ScriptableObject // TypeDefIndex: 7466
{
	// Fields
	[SerializeField]
	protected string m_Version; // 0x18
	[FormerlySerializedAs("m_defaultFontAsset")]
	[SerializeField]
	protected FontAsset m_DefaultFontAsset; // 0x20
	[FormerlySerializedAs("m_defaultFontAssetPath")]
	[SerializeField]
	protected string m_DefaultFontAssetPath; // 0x28
	[FormerlySerializedAs("m_fallbackFontAssets")]
	[SerializeField]
	protected List<FontAsset> m_FallbackFontAssets; // 0x30
	private static List<FontAsset> s_FallbackOSFontAssetInternal; // 0x0
	[FormerlySerializedAs("m_matchMaterialPreset")]
	[SerializeField]
	protected bool m_MatchMaterialPreset; // 0x38
	[SerializeField]
	[FormerlySerializedAs("m_missingGlyphCharacter")]
	protected int m_MissingCharacterUnicode; // 0x3C
	[SerializeField]
	protected bool m_ClearDynamicDataOnBuild; // 0x40
	[SerializeField]
	private bool m_EnableEmojiSupport; // 0x41
	[SerializeField]
	private List<TextAsset> m_EmojiFallbackTextAssets; // 0x48
	[FormerlySerializedAs("m_defaultSpriteAsset")]
	[SerializeField]
	protected SpriteAsset m_DefaultSpriteAsset; // 0x50
	[FormerlySerializedAs("m_defaultSpriteAssetPath")]
	[SerializeField]
	protected string m_DefaultSpriteAssetPath; // 0x58
	[SerializeField]
	protected List<SpriteAsset> m_FallbackSpriteAssets; // 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static SpriteAsset <s_GlobalSpriteAsset>k__BackingField; // 0x8
	[SerializeField]
	protected uint m_MissingSpriteCharacterUnicode; // 0x68
	[FormerlySerializedAs("m_defaultStyleSheet")]
	[SerializeField]
	protected TextStyleSheet m_DefaultStyleSheet; // 0x70
	[SerializeField]
	protected string m_StyleSheetsResourcePath; // 0x78
	[FormerlySerializedAs("m_defaultColorGradientPresetsPath")]
	[SerializeField]
	protected string m_DefaultColorGradientPresetsPath; // 0x80
	[SerializeField]
	protected UnicodeLineBreakingRules m_UnicodeLineBreakingRules; // 0x88
	[FormerlySerializedAs("m_warningsDisabled")]
	[SerializeField]
	protected bool m_DisplayWarnings; // 0x90
	internal Dictionary<int, FontAsset> m_FontLookup; // 0x98
	internal List<TextSettings.FontReferenceMap> m_FontReferences; // 0xA0
	private IntPtr m_NativeTextSettings; // 0xA8
	private bool m_IsNativeTextSettingsDirty; // 0xB0

	// Properties
	public string version { get; set; }
	public FontAsset defaultFontAsset { get; set; }
	public string defaultFontAssetPath { get; set; }
	public List<FontAsset> fallbackFontAssets { get; set; }
	internal List<FontAsset> fallbackOSFontAssets { get; }
	public bool matchMaterialPreset { get; set; }
	public int missingCharacterUnicode { get; set; }
	public bool clearDynamicDataOnBuild { get; set; }
	public bool enableEmojiSupport { get; set; }
	public List<TextAsset> emojiFallbackTextAssets { get; set; }
	public SpriteAsset defaultSpriteAsset { get; set; }
	public string defaultSpriteAssetPath { get; set; }
	[Obsolete("The Fallback Sprite Assets list is now obsolete. Use the emojiFallbackTextAssets instead.", True)]
	public List<SpriteAsset> fallbackSpriteAssets { get; set; }
	internal static SpriteAsset s_GlobalSpriteAsset { get; set; }
	public uint missingSpriteCharacterUnicode { get; set; }
	public TextStyleSheet defaultStyleSheet { get; set; }
	public string styleSheetsResourcePath { get; set; }
	public string defaultColorGradientPresetsPath { get; set; }
	public UnicodeLineBreakingRules lineBreakingRules { get; set; }
	public bool displayWarnings { get; set; }
	internal IntPtr nativeTextSettings { get; }

	// Methods

	// RVA: 0x1EB64D8 Offset: 0x1EB24D8 VA: 0x1EB64D8
	public string get_version() { }

	// RVA: 0x1EB64E0 Offset: 0x1EB24E0 VA: 0x1EB64E0
	internal void set_version(string value) { }

	// RVA: 0x1EB64E8 Offset: 0x1EB24E8 VA: 0x1EB64E8
	public FontAsset get_defaultFontAsset() { }

	// RVA: 0x1EB64F0 Offset: 0x1EB24F0 VA: 0x1EB64F0
	public void set_defaultFontAsset(FontAsset value) { }

	// RVA: 0x1EB64F8 Offset: 0x1EB24F8 VA: 0x1EB64F8
	public string get_defaultFontAssetPath() { }

	// RVA: 0x1EB6500 Offset: 0x1EB2500 VA: 0x1EB6500
	public void set_defaultFontAssetPath(string value) { }

	// RVA: 0x1EB6508 Offset: 0x1EB2508 VA: 0x1EB6508
	public List<FontAsset> get_fallbackFontAssets() { }

	// RVA: 0x1EB6510 Offset: 0x1EB2510 VA: 0x1EB6510
	public void set_fallbackFontAssets(List<FontAsset> value) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1EB6534 Offset: 0x1EB2534 VA: 0x1EB6534
	internal List<FontAsset> get_fallbackOSFontAssets() { }

	// RVA: 0x1EB65DC Offset: 0x1EB25DC VA: 0x1EB65DC Slot: 4
	internal virtual List<FontAsset> GetStaticFallbackOSFontAsset() { }

	// RVA: 0x1EB6624 Offset: 0x1EB2624 VA: 0x1EB6624 Slot: 5
	internal virtual void SetStaticFallbackOSFontAsset(List<FontAsset> fontAssets) { }

	// RVA: 0x1EB667C Offset: 0x1EB267C VA: 0x1EB667C Slot: 6
	internal virtual List<FontAsset> GetFallbackFontAssets(int textPixelSize = -1) { }

	// RVA: 0x1EB6684 Offset: 0x1EB2684 VA: 0x1EB6684
	public bool get_matchMaterialPreset() { }

	// RVA: 0x1EB668C Offset: 0x1EB268C VA: 0x1EB668C
	public void set_matchMaterialPreset(bool value) { }

	// RVA: 0x1EB6694 Offset: 0x1EB2694 VA: 0x1EB6694
	public int get_missingCharacterUnicode() { }

	// RVA: 0x1EB669C Offset: 0x1EB269C VA: 0x1EB669C
	public void set_missingCharacterUnicode(int value) { }

	// RVA: 0x1EB66A4 Offset: 0x1EB26A4 VA: 0x1EB66A4
	public bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x1EB66AC Offset: 0x1EB26AC VA: 0x1EB66AC
	public void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x1EB66B4 Offset: 0x1EB26B4 VA: 0x1EB66B4
	public bool get_enableEmojiSupport() { }

	// RVA: 0x1EB66BC Offset: 0x1EB26BC VA: 0x1EB66BC
	public void set_enableEmojiSupport(bool value) { }

	// RVA: 0x1EB66C4 Offset: 0x1EB26C4 VA: 0x1EB66C4
	public List<TextAsset> get_emojiFallbackTextAssets() { }

	// RVA: 0x1EB66CC Offset: 0x1EB26CC VA: 0x1EB66CC
	public void set_emojiFallbackTextAssets(List<TextAsset> value) { }

	// RVA: 0x1EB66F0 Offset: 0x1EB26F0 VA: 0x1EB66F0
	public SpriteAsset get_defaultSpriteAsset() { }

	// RVA: 0x1EB66F8 Offset: 0x1EB26F8 VA: 0x1EB66F8
	public void set_defaultSpriteAsset(SpriteAsset value) { }

	// RVA: 0x1EB6700 Offset: 0x1EB2700 VA: 0x1EB6700
	public string get_defaultSpriteAssetPath() { }

	// RVA: 0x1EB6708 Offset: 0x1EB2708 VA: 0x1EB6708
	public void set_defaultSpriteAssetPath(string value) { }

	// RVA: 0x1EB6710 Offset: 0x1EB2710 VA: 0x1EB6710
	public List<SpriteAsset> get_fallbackSpriteAssets() { }

	// RVA: 0x1EB6718 Offset: 0x1EB2718 VA: 0x1EB6718
	public void set_fallbackSpriteAssets(List<SpriteAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x1EB6720 Offset: 0x1EB2720 VA: 0x1EB6720
	private static void set_s_GlobalSpriteAsset(SpriteAsset value) { }

	[CompilerGenerated]
	// RVA: 0x1EB6770 Offset: 0x1EB2770 VA: 0x1EB6770
	internal static SpriteAsset get_s_GlobalSpriteAsset() { }

	// RVA: 0x1EB67B8 Offset: 0x1EB27B8 VA: 0x1EB67B8
	public uint get_missingSpriteCharacterUnicode() { }

	// RVA: 0x1EB67C0 Offset: 0x1EB27C0 VA: 0x1EB67C0
	public void set_missingSpriteCharacterUnicode(uint value) { }

	// RVA: 0x1EB67C8 Offset: 0x1EB27C8 VA: 0x1EB67C8
	public TextStyleSheet get_defaultStyleSheet() { }

	// RVA: 0x1EB67D0 Offset: 0x1EB27D0 VA: 0x1EB67D0
	public void set_defaultStyleSheet(TextStyleSheet value) { }

	// RVA: 0x1EB67D8 Offset: 0x1EB27D8 VA: 0x1EB67D8
	public string get_styleSheetsResourcePath() { }

	// RVA: 0x1EB67E0 Offset: 0x1EB27E0 VA: 0x1EB67E0
	public void set_styleSheetsResourcePath(string value) { }

	// RVA: 0x1EB67E8 Offset: 0x1EB27E8 VA: 0x1EB67E8
	public string get_defaultColorGradientPresetsPath() { }

	// RVA: 0x1EB67F0 Offset: 0x1EB27F0 VA: 0x1EB67F0
	public void set_defaultColorGradientPresetsPath(string value) { }

	// RVA: 0x1EB67F8 Offset: 0x1EB27F8 VA: 0x1EB67F8
	public UnicodeLineBreakingRules get_lineBreakingRules() { }

	// RVA: 0x1EB687C Offset: 0x1EB287C VA: 0x1EB687C
	public void set_lineBreakingRules(UnicodeLineBreakingRules value) { }

	// RVA: 0x1EB6884 Offset: 0x1EB2884 VA: 0x1EB6884
	public bool get_displayWarnings() { }

	// RVA: 0x1EB688C Offset: 0x1EB288C VA: 0x1EB688C
	public void set_displayWarnings(bool value) { }

	// RVA: 0x1EB6894 Offset: 0x1EB2894 VA: 0x1EB6894
	private void OnEnable() { }

	// RVA: 0x1EB69CC Offset: 0x1EB29CC VA: 0x1EB69CC
	private void OnDestroy() { }

	// RVA: 0x1EB6A54 Offset: 0x1EB2A54 VA: 0x1EB6A54
	protected void InitializeFontReferenceLookup() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	// RVA: 0x1EB6C9C Offset: 0x1EB2C9C VA: 0x1EB6C9C
	internal FontAsset GetCachedFontAsset(Font font) { }

	// RVA: 0x1EB6578 Offset: 0x1EB2578 VA: 0x1EB6578
	private List<FontAsset> GetOSFontAssetList() { }

	[NativeMethod(Name = "TextSettings::Create")]
	// RVA: 0x1EB6F60 Offset: 0x1EB2F60 VA: 0x1EB6F60
	private static IntPtr CreateNativeObject(IntPtr[] fallbacks) { }

	[NativeMethod(Name = "TextSettings::Destroy")]
	// RVA: 0x1EB6A18 Offset: 0x1EB2A18 VA: 0x1EB6A18
	private static void DestroyNativeObject(IntPtr m_NativeTextSettings) { }

	// RVA: 0x1EB7068 Offset: 0x1EB3068 VA: 0x1EB7068
	private static void UpdateFallbacks(IntPtr ptr, IntPtr[] fallbacks) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1EB7180 Offset: 0x1EB3180 VA: 0x1EB7180
	internal IntPtr get_nativeTextSettings() { }

	// RVA: 0x1EB71F4 Offset: 0x1EB31F4 VA: 0x1EB71F4
	private IntPtr[] GetGlobalFallbacks() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1EB7198 Offset: 0x1EB3198 VA: 0x1EB7198
	internal void UpdateNativeTextSettings() { }

	// RVA: 0x1EB7400 Offset: 0x1EB3400 VA: 0x1EB7400
	public void .ctor() { }

	// RVA: 0x1EB702C Offset: 0x1EB302C VA: 0x1EB702C
	private static IntPtr CreateNativeObject_Injected(ref ManagedSpanWrapper fallbacks) { }

	// RVA: 0x1EB713C Offset: 0x1EB313C VA: 0x1EB713C
	private static void UpdateFallbacks_Injected(IntPtr ptr, ref ManagedSpanWrapper fallbacks) { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class TextStyle // TypeDefIndex: 7467
{
	// Fields
	internal static TextStyle k_NormalStyle; // 0x0
	[SerializeField]
	private string m_Name; // 0x10
	[SerializeField]
	private int m_HashCode; // 0x18
	[SerializeField]
	private string m_OpeningDefinition; // 0x20
	[SerializeField]
	private string m_ClosingDefinition; // 0x28
	[SerializeField]
	private uint[] m_OpeningTagArray; // 0x30
	[SerializeField]
	private uint[] m_ClosingTagArray; // 0x38
	[SerializeField]
	internal uint[] m_OpeningTagUnicodeArray; // 0x40
	[SerializeField]
	internal uint[] m_ClosingTagUnicodeArray; // 0x48

	// Properties
	public int hashCode { get; }
	public uint[] styleOpeningTagArray { get; }
	public uint[] styleClosingTagArray { get; }

	// Methods

	// RVA: 0x1EC9914 Offset: 0x1EC5914 VA: 0x1EC9914
	public int get_hashCode() { }

	// RVA: 0x1EC991C Offset: 0x1EC591C VA: 0x1EC991C
	public uint[] get_styleOpeningTagArray() { }

	// RVA: 0x1EC9924 Offset: 0x1EC5924 VA: 0x1EC9924
	public uint[] get_styleClosingTagArray() { }

	// RVA: 0x1EC992C Offset: 0x1EC592C VA: 0x1EC992C
	internal void .ctor(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	// RVA: 0x1EC9A14 Offset: 0x1EC5A14 VA: 0x1EC9A14
	public void RefreshStyle() { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[Serializable]
public class TextStyleSheet : ScriptableObject // TypeDefIndex: 7468
{
	// Fields
	[SerializeField]
	private List<TextStyle> m_StyleList; // 0x18
	private Dictionary<int, TextStyle> m_StyleLookupDictionary; // 0x20
	private object styleLookupLock; // 0x28

	// Properties
	internal List<TextStyle> styles { get; }

	// Methods

	// RVA: 0x1EC9C00 Offset: 0x1EC5C00 VA: 0x1EC9C00
	internal List<TextStyle> get_styles() { }

	// RVA: 0x1EC9C08 Offset: 0x1EC5C08 VA: 0x1EC9C08
	private void Reset() { }

	// RVA: 0x1EC9ECC Offset: 0x1EC5ECC VA: 0x1EC9ECC
	public TextStyle GetStyle(int hashCode) { }

	// RVA: 0x1EC9FF8 Offset: 0x1EC5FF8 VA: 0x1EC9FF8
	public TextStyle GetStyle(string name) { }

	// RVA: 0x1ECA08C Offset: 0x1EC608C VA: 0x1ECA08C
	public void RefreshStyles() { }

	// RVA: 0x1EC9C0C Offset: 0x1EC5C0C VA: 0x1EC9C0C
	private void LoadStyleDictionaryInternal() { }

	// RVA: 0x1ECA090 Offset: 0x1EC6090 VA: 0x1ECA090
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[UsedByNativeCode("TextCoreVertex")]
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
[NativeHeader("Modules/TextCoreTextEngine/Native/TextCoreVertex.h")]
internal struct TextCoreVertex // TypeDefIndex: 7469
{
	// Fields
	public Vector3 position; // 0x0
	public Color32 color; // 0xC
	public Vector2 uv0; // 0x10
	public Vector2 uv2; // 0x18
}

// Namespace: UnityEngine.TextCore.Text
public enum TextElementType // TypeDefIndex: 7470
{
	// Fields
	public byte value__; // 0x0
	public const TextElementType Character = 1;
	public const TextElementType Sprite = 2;
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public abstract class TextElement // TypeDefIndex: 7471
{
	// Fields
	[SerializeField]
	protected TextElementType m_ElementType; // 0x10
	[SerializeField]
	internal uint m_Unicode; // 0x14
	internal TextAsset m_TextAsset; // 0x18
	internal Glyph m_Glyph; // 0x20
	[SerializeField]
	internal uint m_GlyphIndex; // 0x28
	[SerializeField]
	internal float m_Scale; // 0x2C

	// Properties
	public TextElementType elementType { get; }
	public uint unicode { get; set; }
	public TextAsset textAsset { get; set; }
	public Glyph glyph { get; set; }
	public uint glyphIndex { get; set; }
	public float scale { set; }

	// Methods

	// RVA: 0x1ECA154 Offset: 0x1EC6154 VA: 0x1ECA154
	public TextElementType get_elementType() { }

	// RVA: 0x1ECA15C Offset: 0x1EC615C VA: 0x1ECA15C
	public uint get_unicode() { }

	// RVA: 0x1ECA164 Offset: 0x1EC6164 VA: 0x1ECA164
	public void set_unicode(uint value) { }

	// RVA: 0x1ECA16C Offset: 0x1EC616C VA: 0x1ECA16C
	public TextAsset get_textAsset() { }

	// RVA: 0x1ECA174 Offset: 0x1EC6174 VA: 0x1ECA174
	public void set_textAsset(TextAsset value) { }

	// RVA: 0x1ECA17C Offset: 0x1EC617C VA: 0x1ECA17C
	public Glyph get_glyph() { }

	// RVA: 0x1ECA184 Offset: 0x1EC6184 VA: 0x1ECA184
	public void set_glyph(Glyph value) { }

	// RVA: 0x1ECA18C Offset: 0x1EC618C VA: 0x1ECA18C
	public uint get_glyphIndex() { }

	// RVA: 0x1ECA194 Offset: 0x1EC6194 VA: 0x1ECA194
	public void set_glyphIndex(uint value) { }

	// RVA: 0x1ECA19C Offset: 0x1EC619C VA: 0x1ECA19C
	public void set_scale(float value) { }

	// RVA: 0x1ECA1A4 Offset: 0x1EC61A4 VA: 0x1ECA1A4
	protected void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct TextVertex // TypeDefIndex: 7472
{
	// Fields
	public Vector3 position; // 0x0
	public Vector4 uv; // 0xC
	public Vector2 uv2; // 0x1C
	public Color32 color; // 0x24
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal struct TextElementInfo // TypeDefIndex: 7473
{
	// Fields
	public uint character; // 0x0
	public int index; // 0x4
	public TextElementType elementType; // 0x8
	public int stringLength; // 0xC
	public TextElement textElement; // 0x10
	public Glyph alternativeGlyph; // 0x18
	public FontAsset fontAsset; // 0x20
	public SpriteAsset spriteAsset; // 0x28
	public Material material; // 0x30
	public int materialReferenceIndex; // 0x38
	public bool isUsingAlternateTypeface; // 0x3C
	public float pointSize; // 0x40
	public int lineNumber; // 0x44
	public int vertexIndex; // 0x48
	public TextVertex vertexTopLeft; // 0x4C
	public TextVertex vertexBottomLeft; // 0x74
	public TextVertex vertexTopRight; // 0x9C
	public TextVertex vertexBottomRight; // 0xC4
	public Vector3 topLeft; // 0xEC
	public Vector3 bottomLeft; // 0xF8
	public Vector3 topRight; // 0x104
	public Vector3 bottomRight; // 0x110
	public float origin; // 0x11C
	public float ascender; // 0x120
	public float baseLine; // 0x124
	public float descender; // 0x128
	internal float adjustedAscender; // 0x12C
	internal float adjustedDescender; // 0x130
	internal float adjustedHorizontalAdvance; // 0x134
	public float xAdvance; // 0x138
	public float aspectRatio; // 0x13C
	public float scale; // 0x140
	public Color32 color; // 0x144
	public Color32 underlineColor; // 0x148
	public int underlineVertexIndex; // 0x14C
	public Color32 strikethroughColor; // 0x150
	public int strikethroughVertexIndex; // 0x154
	public Color32 highlightColor; // 0x158
	public HighlightState highlightState; // 0x15C
	public FontStyles style; // 0x170
	public bool isVisible; // 0x174

	// Methods

	// RVA: 0x1ECA1AC Offset: 0x1EC61AC VA: 0x1ECA1AC Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.TextCore.Text
public static class TextEventManager // TypeDefIndex: 7474
{
	// Fields
	public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT; // 0x0
	public static readonly FastAction<bool, Object> FONT_PROPERTY_EVENT; // 0x8
	public static readonly FastAction<bool, Object> SPRITE_ASSET_PROPERTY_EVENT; // 0x10
	public static readonly FastAction<bool, Object> TEXTMESHPRO_PROPERTY_EVENT; // 0x18
	public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; // 0x20
	public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT; // 0x28
	public static readonly FastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT; // 0x30
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; // 0x38
	public static readonly FastAction RESOURCE_LOAD_EVENT; // 0x40
	public static readonly FastAction<bool, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT; // 0x48
	public static readonly FastAction OnPreRenderObject_Event; // 0x50
	public static readonly FastAction<Object> TEXT_CHANGED_EVENT; // 0x58

	// Methods

	// RVA: 0x1ECB960 Offset: 0x1EC7960 VA: 0x1ECB960
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, Object font) { }

	// RVA: 0x1ECB9F0 Offset: 0x1EC79F0 VA: 0x1ECB9F0
	private static void .cctor() { }
}

// Namespace: 
public sealed class TextGenerator.MissingCharacterEventCallback : MulticastDelegate // TypeDefIndex: 7475
{
	// Methods

	// RVA: 0x1ECBD0C Offset: 0x1EC7D0C VA: 0x1ECBD0C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1ECBDAC Offset: 0x1EC7DAC VA: 0x1ECBDAC Slot: 12
	public virtual void Invoke(uint unicode, int stringIndex, TextInfo text, FontAsset fontAsset) { }
}

// Namespace: 
protected struct TextGenerator.SpecialCharacter // TypeDefIndex: 7476
{
	// Fields
	public Character character; // 0x0
	public FontAsset fontAsset; // 0x8
	public Material material; // 0x10
	public int materialIndex; // 0x18

	// Methods

	// RVA: 0x1ECBDC0 Offset: 0x1EC7DC0 VA: 0x1ECBDC0
	public void .ctor(Character character, int materialIndex) { }
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal class TextGenerator // TypeDefIndex: 7477
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static bool <IsExecutingJob>k__BackingField; // 0x0
	private TextBackingContainer m_TextBackingArray; // 0x10
	internal TextProcessingElement[] m_TextProcessingArray; // 0x20
	internal int m_InternalTextProcessingArraySize; // 0x28
	[SerializeField]
	protected bool m_VertexBufferAutoSizeReduction; // 0x2C
	private char[] m_HtmlTag; // 0x30
	internal HighlightState m_HighlightState; // 0x38
	protected bool m_IsIgnoringAlignment; // 0x4C
	protected bool m_IsTextTruncated; // 0x4D
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static TextGenerator.MissingCharacterEventCallback OnMissingCharacter; // 0x8
	private Vector3[] m_RectTransformCorners; // 0x50
	private float m_MarginWidth; // 0x58
	private float m_MarginHeight; // 0x5C
	private float m_PreferredWidth; // 0x60
	private float m_PreferredHeight; // 0x64
	private FontAsset m_CurrentFontAsset; // 0x68
	private Material m_CurrentMaterial; // 0x70
	private int m_CurrentMaterialIndex; // 0x78
	private TextProcessingStack<MaterialReference> m_MaterialReferenceStack; // 0x80
	private float m_Padding; // 0xD8
	private SpriteAsset m_CurrentSpriteAsset; // 0xE0
	private int m_TotalCharacterCount; // 0xE8
	private float m_FontSize; // 0xEC
	private float m_FontScaleMultiplier; // 0xF0
	private float m_CurrentFontSize; // 0xF4
	private TextProcessingStack<float> m_SizeStack; // 0xF8
	protected TextProcessingStack<int>[] m_TextStyleStacks; // 0x118
	protected int m_TextStyleStackDepth; // 0x120
	private FontStyles m_FontStyleInternal; // 0x124
	private FontStyleStack m_FontStyleStack; // 0x128
	private TextFontWeight m_FontWeightInternal; // 0x134
	private TextProcessingStack<TextFontWeight> m_FontWeightStack; // 0x138
	private TextAlignment m_LineJustification; // 0x158
	private TextProcessingStack<TextAlignment> m_LineJustificationStack; // 0x160
	private float m_BaselineOffset; // 0x180
	private TextProcessingStack<float> m_BaselineOffsetStack; // 0x188
	private Color32 m_FontColor32; // 0x1A8
	private Color32 m_HtmlColor; // 0x1AC
	private Color32 m_UnderlineColor; // 0x1B0
	private Color32 m_StrikethroughColor; // 0x1B4
	private TextProcessingStack<Color32> m_ColorStack; // 0x1B8
	private TextProcessingStack<Color32> m_UnderlineColorStack; // 0x1D8
	private TextProcessingStack<Color32> m_StrikethroughColorStack; // 0x1F8
	private TextProcessingStack<Color32> m_HighlightColorStack; // 0x218
	private TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x238
	private TextProcessingStack<int> m_ItalicAngleStack; // 0x268
	private TextColorGradient m_ColorGradientPreset; // 0x288
	private TextProcessingStack<TextColorGradient> m_ColorGradientStack; // 0x290
	private bool m_ColorGradientPresetIsTinted; // 0x2B8
	private TextProcessingStack<int> m_ActionStack; // 0x2C0
	private float m_LineOffset; // 0x2E0
	private float m_LineHeight; // 0x2E4
	private bool m_IsDrivenLineSpacing; // 0x2E8
	private float m_CSpacing; // 0x2EC
	private float m_MonoSpacing; // 0x2F0
	private bool m_DuoSpace; // 0x2F4
	private float m_XAdvance; // 0x2F8
	private float m_TagLineIndent; // 0x2FC
	private float m_TagIndent; // 0x300
	private TextProcessingStack<float> m_IndentStack; // 0x308
	private bool m_TagNoParsing; // 0x328
	private int m_CharacterCount; // 0x32C
	private int m_FirstCharacterOfLine; // 0x330
	private int m_LastCharacterOfLine; // 0x334
	private int m_FirstVisibleCharacterOfLine; // 0x338
	private int m_LastVisibleCharacterOfLine; // 0x33C
	private float m_MaxLineAscender; // 0x340
	private float m_MaxLineDescender; // 0x344
	private int m_LineNumber; // 0x348
	private int m_LineVisibleCharacterCount; // 0x34C
	private int m_LineVisibleSpaceCount; // 0x350
	private int m_FirstOverflowCharacterIndex; // 0x354
	private float m_MarginLeft; // 0x358
	private float m_MarginRight; // 0x35C
	private float m_Width; // 0x360
	private Extents m_MeshExtents; // 0x364
	private float m_MaxCapHeight; // 0x374
	private float m_MaxAscender; // 0x378
	private float m_MaxDescender; // 0x37C
	private bool m_IsNonBreakingSpace; // 0x380
	private WordWrapState m_SavedWordWrapState; // 0x388
	private WordWrapState m_SavedLineState; // 0x720
	private WordWrapState m_SavedEllipsisState; // 0xAB8
	private WordWrapState m_SavedLastValidState; // 0xE50
	private WordWrapState m_SavedSoftLineBreakState; // 0x11E8
	private TextElementType m_TextElementType; // 0x1580
	private bool m_isTextLayoutPhase; // 0x1581
	private int m_SpriteIndex; // 0x1584
	private Color32 m_SpriteColor; // 0x1588
	private TextElement m_CachedTextElement; // 0x1590
	private Color32 m_HighlightColor; // 0x1598
	private float m_CharWidthAdjDelta; // 0x159C
	private float m_MaxFontSize; // 0x15A0
	private float m_MinFontSize; // 0x15A4
	private int m_AutoSizeIterationCount; // 0x15A8
	private int m_AutoSizeMaxIterationCount; // 0x15AC
	private float m_StartOfLineAscender; // 0x15B0
	private float m_LineSpacingDelta; // 0x15B4
	internal MaterialReference[] m_MaterialReferences; // 0x15B8
	private int m_SpriteCount; // 0x15C0
	private TextProcessingStack<int> m_StyleStack; // 0x15C8
	private TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x15E8
	private int m_SpriteAnimationId; // 0x19A0
	private int m_ItalicAngle; // 0x19A4
	private Vector3 m_FXScale; // 0x19A8
	private Quaternion m_FXRotation; // 0x19B4
	private int m_LastBaseGlyphIndex; // 0x19C4
	private float m_PageAscender; // 0x19C8
	private RichTextTagAttribute[] m_XmlAttribute; // 0x19D0
	private float[] m_AttributeParameterValues; // 0x19D8
	private Dictionary<int, int> m_MaterialReferenceIndexLookup; // 0x19E0
	private bool m_IsCalculatingPreferredValues; // 0x19E8
	private bool m_TintSprite; // 0x19E9
	protected TextGenerator.SpecialCharacter m_Ellipsis; // 0x19F0
	protected TextGenerator.SpecialCharacter m_Underline; // 0x1A10

	// Properties
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static bool IsExecutingJob { get; }
	public bool isTextTruncated { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1EB753C Offset: 0x1EB353C VA: 0x1EB753C
	internal static bool get_IsExecutingJob() { }

	// RVA: 0x1EB7584 Offset: 0x1EB3584 VA: 0x1EB7584
	public void GenerateText(TextGenerationSettings settings, TextInfo textInfo) { }

	// RVA: 0x1EB7B00 Offset: 0x1EB3B00 VA: 0x1EB7B00
	public bool get_isTextTruncated() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1EB7870 Offset: 0x1EB3870 VA: 0x1EB7870
	internal void GenerateTextMesh(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x1EBE53C Offset: 0x1EBA53C VA: 0x1EBE53C
	private bool ValidateHtmlTag(TextProcessingElement[] chars, int startIndex, out int endIndex, TextGenerationSettings generationSettings, TextInfo textInfo, out bool isThreadSuccess) { }

	// RVA: 0x1EC2C8C Offset: 0x1EBEC8C VA: 0x1EC2C8C
	internal void CloseLastLinkTag(TextInfo textInfo) { }

	// RVA: 0x1EC2D24 Offset: 0x1EBED24 VA: 0x1EC2D24
	internal void CloseAllLinkTags(TextInfo textInfo) { }

	// RVA: 0x1EC2CC4 Offset: 0x1EBECC4 VA: 0x1EC2CC4
	private void CloseLinkTag(TextInfo textInfo, int index) { }

	// RVA: 0x1EC2C28 Offset: 0x1EBEC28 VA: 0x1EC2C28
	private void ClearMarkupTagAttributes() { }

	// RVA: 0x1EC2D70 Offset: 0x1EBED70 VA: 0x1EC2D70
	private void SaveWordWrappingState(ref WordWrapState state, int index, int count, TextInfo textInfo) { }

	// RVA: 0x1EC30E8 Offset: 0x1EBF0E8 VA: 0x1EC30E8
	private int RestoreWordWrappingState(ref WordWrapState state, TextInfo textInfo) { }

	// RVA: 0x1EC3438 Offset: 0x1EBF438 VA: 0x1EC3438
	private void SaveGlyphVertexInfo(float padding, float stylePadding, Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x1EC3C8C Offset: 0x1EBFC8C VA: 0x1EC3C8C
	private void SaveSpriteVertexInfo(Color32 vertexColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x1EC4218 Offset: 0x1EC0218 VA: 0x1EC4218
	private void EnsureMeshInfoCapacityForMaterialReferences(TextInfo textInfo, TextGenerationSettings generationSettings) { }

	// RVA: 0x1EC449C Offset: 0x1EC049C VA: 0x1EC449C
	private void DrawUnderlineMesh(Vector3 start, Vector3 end, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x1EC521C Offset: 0x1EC121C VA: 0x1EC521C
	private void DrawTextHighlight(Vector3 start, Vector3 end, Color32 highlightColor, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x1EB7B08 Offset: 0x1EB3B08 VA: 0x1EB7B08
	private static void ClearMesh(bool updateMesh, TextInfo textInfo) { }

	// RVA: 0x1EBC17C Offset: 0x1EB817C VA: 0x1EBC17C
	public void LayoutPhase(TextInfo textInfo, TextGenerationSettings generationSettings, float maxVisibleDescender) { }

	// RVA: 0x1EB7B28 Offset: 0x1EB3B28 VA: 0x1EB7B28
	public void ParsingPhase(TextInfo textInfo, TextGenerationSettings generationSettings, out uint charCode, out float maxVisibleDescender) { }

	// RVA: 0x1EC56B0 Offset: 0x1EC16B0 VA: 0x1EC56B0
	private void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1EB7738 Offset: 0x1EB3738 VA: 0x1EB7738
	internal void Prepare(TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x1EC6A9C Offset: 0x1EC2A9C VA: 0x1EC6A9C
	private int SetArraySizes(TextProcessingElement[] textProcessingArray, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x1EC8708 Offset: 0x1EC4708 VA: 0x1EC8708
	private TextElement GetTextElement(TextGenerationSettings generationSettings, uint unicode, FontAsset fontAsset, FontStyles fontStyle, TextFontWeight fontWeight, out bool isUsingAlternativeTypeface, bool populateLigatures) { }

	// RVA: 0x1EC5C74 Offset: 0x1EC1C74 VA: 0x1EC5C74
	private void PopulateTextBackingArray(in RenderedText sourceText) { }

	// RVA: 0x1EC5D48 Offset: 0x1EC1D48 VA: 0x1EC5D48
	private void PopulateTextProcessingArray(TextGenerationSettings generationSettings) { }

	// RVA: 0x1EC5C0C Offset: 0x1EC1C0C VA: 0x1EC5C0C
	private void ComputeMarginSize(Rect rect, Vector4 margins) { }

	// RVA: 0x1EC5BC4 Offset: 0x1EC1BC4 VA: 0x1EC5BC4
	protected bool GetSpecialCharacters(TextGenerationSettings generationSettings) { }

	// RVA: 0x1EC842C Offset: 0x1EC442C VA: 0x1EC842C
	protected bool GetEllipsisSpecialCharacter(TextGenerationSettings generationSettings) { }

	// RVA: 0x1EC4DA8 Offset: 0x1EC0DA8 VA: 0x1EC4DA8
	protected bool GetUnderlineSpecialCharacter(TextGenerationSettings generationSettings) { }

	// RVA: 0x1EC8B2C Offset: 0x1EC4B2C VA: 0x1EC8B2C
	protected void DoMissingGlyphCallback(uint unicode, int stringIndex, FontAsset fontAsset, TextInfo textInfo) { }

	// RVA: 0x1EC8BC8 Offset: 0x1EC4BC8 VA: 0x1EC8BC8
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal class TextGenerationSettings : IEquatable<TextGenerationSettings> // TypeDefIndex: 7478
{
	// Fields
	private RenderedText m_RenderedText; // 0x10
	private string m_CachedRenderedText; // 0x30
	public Rect screenRect; // 0x38
	public float pixelsPerPoint; // 0x48
	public bool isEditorRenderingModeBitmap; // 0x4C
	public FontAsset fontAsset; // 0x50
	public FontStyles fontStyle; // 0x58
	public TextSettings textSettings; // 0x60
	public TextAlignment textAlignment; // 0x68
	public TextOverflowMode overflowMode; // 0x6C
	public Color color; // 0x70
	public bool shouldConvertToLinearSpace; // 0x80
	public float fontSize; // 0x84
	internal static readonly List<OTL_FeatureTag> fontFeatures; // 0x0
	public bool emojiFallbackSupport; // 0x88
	public bool richText; // 0x89
	public bool isRightToLeft; // 0x8A
	public float extraPadding; // 0x8C
	public bool parseControlCharacters; // 0x90
	public bool isPlaceholder; // 0x91
	public float characterSpacing; // 0x94
	public float wordSpacing; // 0x98
	public float paragraphSpacing; // 0x9C
	public TextWrappingMode textWrappingMode; // 0xA0
	public TextFontWeight fontWeight; // 0xA4
	public bool isIMGUI; // 0xA8

	// Properties
	public RenderedText renderedText { get; set; }
	public string text { get; set; }

	// Methods

	// RVA: 0x1ECBF0C Offset: 0x1EC7F0C VA: 0x1ECBF0C
	public RenderedText get_renderedText() { }

	// RVA: 0x1ECBF18 Offset: 0x1EC7F18 VA: 0x1ECBF18
	public void set_renderedText(RenderedText value) { }

	// RVA: 0x1ECBF44 Offset: 0x1EC7F44 VA: 0x1ECBF44
	public string get_text() { }

	// RVA: 0x1ECC0A4 Offset: 0x1EC80A4 VA: 0x1ECC0A4
	public void set_text(string value) { }

	// RVA: 0x1ECC124 Offset: 0x1EC8124 VA: 0x1ECC124
	public void .ctor() { }

	// RVA: 0x1ECC17C Offset: 0x1EC817C VA: 0x1ECC17C Slot: 4
	public bool Equals(TextGenerationSettings other) { }

	// RVA: 0x1ECC44C Offset: 0x1EC844C VA: 0x1ECC44C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1ECC54C Offset: 0x1EC854C VA: 0x1ECC54C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ECC7E8 Offset: 0x1EC87E8 VA: 0x1ECC7E8
	public static bool op_Inequality(TextGenerationSettings left, TextGenerationSettings right) { }

	// RVA: 0x1ECC804 Offset: 0x1EC8804 VA: 0x1ECC804 Slot: 3
	public override string ToString() { }

	// RVA: 0x1ECD6A0 Offset: 0x1EC96A0 VA: 0x1ECD6A0
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal enum TextAlignment // TypeDefIndex: 7479
{
	// Fields
	public int value__; // 0x0
	public const TextAlignment TopLeft = 257;
	public const TextAlignment TopCenter = 258;
	public const TextAlignment TopRight = 260;
	public const TextAlignment TopJustified = 264;
	public const TextAlignment TopFlush = 272;
	public const TextAlignment TopGeoAligned = 288;
	public const TextAlignment MiddleLeft = 513;
	public const TextAlignment MiddleCenter = 514;
	public const TextAlignment MiddleRight = 516;
	public const TextAlignment MiddleJustified = 520;
	public const TextAlignment MiddleFlush = 528;
	public const TextAlignment MiddleGeoAligned = 544;
	public const TextAlignment BottomLeft = 1025;
	public const TextAlignment BottomCenter = 1026;
	public const TextAlignment BottomRight = 1028;
	public const TextAlignment BottomJustified = 1032;
	public const TextAlignment BottomFlush = 1040;
	public const TextAlignment BottomGeoAligned = 1056;
	public const TextAlignment BaselineLeft = 2049;
	public const TextAlignment BaselineCenter = 2050;
	public const TextAlignment BaselineRight = 2052;
	public const TextAlignment BaselineJustified = 2056;
	public const TextAlignment BaselineFlush = 2064;
	public const TextAlignment BaselineGeoAligned = 2080;
	public const TextAlignment MidlineLeft = 4097;
	public const TextAlignment MidlineCenter = 4098;
	public const TextAlignment MidlineRight = 4100;
	public const TextAlignment MidlineJustified = 4104;
	public const TextAlignment MidlineFlush = 4112;
	public const TextAlignment MidlineGeoAligned = 4128;
	public const TextAlignment CaplineLeft = 8193;
	public const TextAlignment CaplineCenter = 8194;
	public const TextAlignment CaplineRight = 8196;
	public const TextAlignment CaplineJustified = 8200;
	public const TextAlignment CaplineFlush = 8208;
	public const TextAlignment CaplineGeoAligned = 8224;
}

// Namespace: UnityEngine.TextCore.Text
[Flags]
public enum FontStyles // TypeDefIndex: 7480
{
	// Fields
	public int value__; // 0x0
	public const FontStyles Normal = 0;
	public const FontStyles Bold = 1;
	public const FontStyles Italic = 2;
	public const FontStyles Underline = 4;
	public const FontStyles LowerCase = 8;
	public const FontStyles UpperCase = 16;
	public const FontStyles SmallCaps = 32;
	public const FontStyles Strikethrough = 64;
	public const FontStyles Superscript = 128;
	public const FontStyles Subscript = 256;
	public const FontStyles Highlight = 512;
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal enum TextOverflowMode // TypeDefIndex: 7481
{
	// Fields
	public int value__; // 0x0
	public const TextOverflowMode Overflow = 0;
	public const TextOverflowMode Ellipsis = 1;
	public const TextOverflowMode Masking = 2;
	public const TextOverflowMode Truncate = 3;
	public const TextOverflowMode ScrollRect = 4;
	public const TextOverflowMode Linked = 6;
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal enum TextWrappingMode // TypeDefIndex: 7482
{
	// Fields
	public int value__; // 0x0
	public const TextWrappingMode NoWrap = 0;
	public const TextWrappingMode Normal = 1;
	public const TextWrappingMode PreserveWhitespace = 2;
	public const TextWrappingMode PreserveWhitespaceNoWrap = 3;
}

// Namespace: 
public struct RenderedText.Enumerator // TypeDefIndex: 7483
{
	// Fields
	private readonly RenderedText m_Source; // 0x0
	private int m_Stage; // 0x20
	private int m_StageIndex; // 0x24
	private char m_Current; // 0x28

	// Properties
	public char Current { get; }

	// Methods

	// RVA: 0x1ECDC18 Offset: 0x1EC9C18 VA: 0x1ECDC18
	public char get_Current() { }

	// RVA: 0x1ECD8BC Offset: 0x1EC98BC VA: 0x1ECD8BC
	public void .ctor(in RenderedText source) { }

	// RVA: 0x1ECD8E4 Offset: 0x1EC98E4 VA: 0x1ECD8E4
	public bool MoveNext() { }
}

// Namespace: UnityEngine.TextCore.Text
[IsReadOnly]
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule", "UnityEngine.IMGUIModule", "UnityEditor.GraphToolsFoundationModule" })]
internal struct RenderedText : IEquatable<RenderedText>, IEquatable<string> // TypeDefIndex: 7484
{
	// Fields
	public readonly string value; // 0x0
	public readonly int valueStart; // 0x8
	public readonly int valueLength; // 0xC
	public readonly string suffix; // 0x10
	public readonly char repeat; // 0x18
	public readonly int repeatCount; // 0x1C

	// Properties
	public int CharacterCount { get; }

	// Methods

	// RVA: 0x1ECC108 Offset: 0x1EC8108 VA: 0x1ECC108
	public void .ctor(string value) { }

	// RVA: 0x1ECD7AC Offset: 0x1EC97AC VA: 0x1ECD7AC
	public void .ctor(string value, int start, int length, string suffix) { }

	// RVA: 0x1ECD86C Offset: 0x1EC986C VA: 0x1ECD86C
	public int get_CharacterCount() { }

	// RVA: 0x1ECD88C Offset: 0x1EC988C VA: 0x1ECD88C
	public RenderedText.Enumerator GetEnumerator() { }

	// RVA: 0x1ECBFA0 Offset: 0x1EC7FA0 VA: 0x1ECBFA0
	public string CreateString() { }

	// RVA: 0x1ECC3C0 Offset: 0x1EC83C0 VA: 0x1ECC3C0 Slot: 4
	public bool Equals(RenderedText other) { }

	// RVA: 0x1ECD9C8 Offset: 0x1EC99C8 VA: 0x1ECD9C8 Slot: 5
	public bool Equals(string other) { }

	// RVA: 0x1ECDABC Offset: 0x1EC9ABC VA: 0x1ECDABC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1ECDB74 Offset: 0x1EC9B74 VA: 0x1ECDB74 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct RichTextTagAttribute // TypeDefIndex: 7485
{
	// Fields
	public int nameHashCode; // 0x0
	public int valueHashCode; // 0x4
	public TagValueType valueType; // 0x8
	public int valueStartIndex; // 0xC
	public int valueLength; // 0x10
	public TagUnitType unitType; // 0x14
}

// Namespace: UnityEngine.TextCore.Text
[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
internal struct TextProcessingElement // TypeDefIndex: 7486
{
	// Fields
	public TextProcessingElementType elementType; // 0x0
	public uint unicode; // 0x4
	public int stringIndex; // 0x8
	public int length; // 0xC
}

// Namespace: UnityEngine.TextCore.Text
[DefaultMember("Item")]
internal struct TextBackingContainer // TypeDefIndex: 7487
{
	// Fields
	private uint[] m_Array; // 0x0
	private int m_Count; // 0x8

	// Properties
	public int Capacity { get; }
	public int Count { get; set; }
	public uint Item { get; set; }

	// Methods

	// RVA: 0x1ECDC20 Offset: 0x1EC9C20 VA: 0x1ECDC20
	public int get_Capacity() { }

	// RVA: 0x1ECDC38 Offset: 0x1EC9C38 VA: 0x1ECDC38
	public int get_Count() { }

	// RVA: 0x1ECDC40 Offset: 0x1EC9C40 VA: 0x1ECDC40
	public void set_Count(int value) { }

	// RVA: 0x1ECDC48 Offset: 0x1EC9C48 VA: 0x1ECDC48
	public uint get_Item(int index) { }

	// RVA: 0x1ECDC78 Offset: 0x1EC9C78 VA: 0x1ECDC78
	public void set_Item(int index, uint value) { }

	// RVA: 0x1ECDD44 Offset: 0x1EC9D44 VA: 0x1ECDD44
	public void .ctor(int size) { }

	// RVA: 0x1ECDCD8 Offset: 0x1EC9CD8 VA: 0x1ECDCD8
	public void Resize(int size) { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct CharacterSubstitution // TypeDefIndex: 7488
{
	// Fields
	public int index; // 0x0
	public uint unicode; // 0x4

	// Methods

	// RVA: 0x1ECDDB0 Offset: 0x1EC9DB0 VA: 0x1ECDDB0
	public void .ctor(int index, uint unicode) { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct Offset // TypeDefIndex: 7489
{
	// Fields
	private float m_Left; // 0x0
	private float m_Right; // 0x4
	private float m_Top; // 0x8
	private float m_Bottom; // 0xC
	private static readonly Offset k_ZeroOffset; // 0x0

	// Properties
	public float left { get; }
	public float right { get; }
	public float top { get; }
	public float bottom { get; }
	public static Offset zero { get; }

	// Methods

	// RVA: 0x1ECDDB8 Offset: 0x1EC9DB8 VA: 0x1ECDDB8
	public float get_left() { }

	// RVA: 0x1ECDDC0 Offset: 0x1EC9DC0 VA: 0x1ECDDC0
	public float get_right() { }

	// RVA: 0x1ECDDC8 Offset: 0x1EC9DC8 VA: 0x1ECDDC8
	public float get_top() { }

	// RVA: 0x1ECDDD0 Offset: 0x1EC9DD0 VA: 0x1ECDDD0
	public float get_bottom() { }

	// RVA: 0x1ECDDD8 Offset: 0x1EC9DD8 VA: 0x1ECDDD8
	public static Offset get_zero() { }

	// RVA: 0x1ECDE34 Offset: 0x1EC9E34 VA: 0x1ECDE34
	public void .ctor(float left, float right, float top, float bottom) { }

	// RVA: 0x1ECDE40 Offset: 0x1EC9E40 VA: 0x1ECDE40
	public static bool op_Equality(Offset lhs, Offset rhs) { }

	// RVA: 0x1ECDE68 Offset: 0x1EC9E68 VA: 0x1ECDE68
	public static Offset op_Multiply(Offset a, float b) { }

	// RVA: 0x1ECDE7C Offset: 0x1EC9E7C VA: 0x1ECDE7C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ECDEE0 Offset: 0x1EC9EE0 VA: 0x1ECDEE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1ECDF58 Offset: 0x1EC9F58 VA: 0x1ECDF58
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct HighlightState // TypeDefIndex: 7490
{
	// Fields
	public Color32 color; // 0x0
	public Offset padding; // 0x4

	// Methods

	// RVA: 0x1ECDFA0 Offset: 0x1EC9FA0 VA: 0x1ECDFA0
	public void .ctor(Color32 color, Offset padding) { }

	// RVA: 0x1ECDFB0 Offset: 0x1EC9FB0 VA: 0x1ECDFB0
	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x1ECE0A0 Offset: 0x1ECA0A0 VA: 0x1ECE0A0
	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x1ECE0E8 Offset: 0x1ECA0E8 VA: 0x1ECE0E8 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1ECE154 Offset: 0x1ECA154 VA: 0x1ECE154 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct WordWrapState // TypeDefIndex: 7491
{
	// Fields
	public int previousWordBreak; // 0x0
	public int totalCharacterCount; // 0x4
	public int visibleCharacterCount; // 0x8
	public int visibleSpaceCount; // 0xC
	public int visibleSpriteCount; // 0x10
	public int visibleLinkCount; // 0x14
	public int firstCharacterIndex; // 0x18
	public int firstVisibleCharacterIndex; // 0x1C
	public int lastCharacterIndex; // 0x20
	public int lastVisibleCharIndex; // 0x24
	public int lineNumber; // 0x28
	public float maxCapHeight; // 0x2C
	public float maxAscender; // 0x30
	public float maxDescender; // 0x34
	public float maxLineAscender; // 0x38
	public float maxLineDescender; // 0x3C
	public float startOfLineAscender; // 0x40
	public float xAdvance; // 0x44
	public float preferredWidth; // 0x48
	public float preferredHeight; // 0x4C
	public float previousLineScale; // 0x50
	public float pageAscender; // 0x54
	public int wordCount; // 0x58
	public FontStyles fontStyle; // 0x5C
	public float fontScale; // 0x60
	public float fontScaleMultiplier; // 0x64
	public int italicAngle; // 0x68
	public float currentFontSize; // 0x6C
	public float baselineOffset; // 0x70
	public float lineOffset; // 0x74
	public TextInfo textInfo; // 0x78
	public LineInfo lineInfo; // 0x80
	public Color32 vertexColor; // 0xE0
	public Color32 underlineColor; // 0xE4
	public Color32 strikethroughColor; // 0xE8
	public Color32 highlightColor; // 0xEC
	public HighlightState highlightState; // 0xF0
	public FontStyleStack basicStyleStack; // 0x104
	public TextProcessingStack<int> italicAngleStack; // 0x110
	public TextProcessingStack<Color32> colorStack; // 0x130
	public TextProcessingStack<Color32> underlineColorStack; // 0x150
	public TextProcessingStack<Color32> strikethroughColorStack; // 0x170
	public TextProcessingStack<Color32> highlightColorStack; // 0x190
	public TextProcessingStack<HighlightState> highlightStateStack; // 0x1B0
	public TextProcessingStack<TextColorGradient> colorGradientStack; // 0x1E0
	public TextProcessingStack<float> sizeStack; // 0x208
	public TextProcessingStack<float> indentStack; // 0x228
	public TextProcessingStack<TextFontWeight> fontWeightStack; // 0x248
	public TextProcessingStack<int> styleStack; // 0x268
	public TextProcessingStack<float> baselineStack; // 0x288
	public TextProcessingStack<int> actionStack; // 0x2A8
	public TextProcessingStack<MaterialReference> materialReferenceStack; // 0x2C8
	public TextProcessingStack<TextAlignment> lineJustificationStack; // 0x320
	public int lastBaseGlyphIndex; // 0x340
	public int spriteAnimationId; // 0x344
	public FontAsset currentFontAsset; // 0x348
	public SpriteAsset currentSpriteAsset; // 0x350
	public Material currentMaterial; // 0x358
	public int currentMaterialIndex; // 0x360
	public Extents meshExtents; // 0x364
	public bool tagNoParsing; // 0x374
	public bool isNonBreakingSpace; // 0x375
	public bool isDrivenLineSpacing; // 0x376
	public Vector3 fxScale; // 0x378
	public Quaternion fxRotation; // 0x384
}

// Namespace: UnityEngine.TextCore.Text
[Extension]
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal static class TextGeneratorUtilities // TypeDefIndex: 7492
{
	// Fields
	public static readonly Vector2 largePositiveVector2; // 0x0
	public static readonly Vector2 largeNegativeVector2; // 0x8
	private static readonly HashSet<uint> k_EmojiLookup; // 0x10
	private static readonly HashSet<uint> k_EmojiPresentationFormLookup; // 0x18

	// Methods

	// RVA: 0x1ECE1D4 Offset: 0x1ECA1D4 VA: 0x1ECE1D4
	public static bool Approximately(float a, float b) { }

	// RVA: 0x1ECE1FC Offset: 0x1ECA1FC VA: 0x1ECE1FC
	public static Color32 HexCharsToColor(char[] hexChars, int startIndex, int tagCount) { }

	// RVA: 0x1ECE624 Offset: 0x1ECA624 VA: 0x1ECE624
	public static uint HexToInt(char hex) { }

	// RVA: 0x1ECE650 Offset: 0x1ECA650 VA: 0x1ECE650
	public static float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x1ECE6D0 Offset: 0x1ECA6D0 VA: 0x1ECE6D0
	public static float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: -1 Offset: -1
	public static void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x103863C Offset: 0x103463C VA: 0x103863C
	|-TextGeneratorUtilities.ResizeInternalArray<TextProcessingElement>
	|
	|-RVA: 0x103869C Offset: 0x103469C VA: 0x103869C
	|-TextGeneratorUtilities.ResizeInternalArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1038700 Offset: 0x1034700 VA: 0x1038700
	|-TextGeneratorUtilities.ResizeInternalArray<TextProcessingElement>
	|
	|-RVA: 0x1038754 Offset: 0x1034754 VA: 0x1038754
	|-TextGeneratorUtilities.ResizeInternalArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1ECE82C Offset: 0x1ECA82C VA: 0x1ECE82C
	internal static void InsertOpeningTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x1ECEDE0 Offset: 0x1ECADE0 VA: 0x1ECEDE0
	internal static void InsertClosingTextStyle(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x1ECEED8 Offset: 0x1ECAED8 VA: 0x1ECEED8
	public static bool ReplaceOpeningStyleTag(ref TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x1ECF1E4 Offset: 0x1ECB1E4 VA: 0x1ECF1E4
	private static bool ReplaceOpeningStyleTag(ref uint[] sourceText, int srcIndex, out int srcOffset, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x1ECF40C Offset: 0x1ECB40C VA: 0x1ECF40C
	public static void ReplaceClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x1ECF538 Offset: 0x1ECB538 VA: 0x1ECF538
	internal static void InsertOpeningStyleTag(TextStyle style, ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x1ECF610 Offset: 0x1ECB610 VA: 0x1ECF610
	internal static void InsertClosingStyleTag(ref TextProcessingElement[] charBuffer, ref int writeIndex, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x1ECE924 Offset: 0x1ECA924 VA: 0x1ECE924
	private static void InsertTextStyleInTextProcessingArray(ref TextProcessingElement[] charBuffer, ref int writeIndex, uint[] styleDefinition, ref int textStyleStackDepth, ref TextProcessingStack<int>[] textStyleStacks, ref TextGenerationSettings generationSettings) { }

	// RVA: 0x1ECF11C Offset: 0x1ECB11C VA: 0x1ECF11C
	public static TextStyle GetStyle(TextGenerationSettings generationSetting, int hashCode) { }

	// RVA: 0x1ECF33C Offset: 0x1ECB33C VA: 0x1ECF33C
	public static int GetStyleHashCode(ref uint[] text, int index, out int closeIndex) { }

	// RVA: 0x1ECF030 Offset: 0x1ECB030 VA: 0x1ECF030
	public static int GetStyleHashCode(ref TextBackingContainer text, int index, out int closeIndex) { }

	// RVA: 0x1ECF6F4 Offset: 0x1ECB6F4 VA: 0x1ECF6F4
	public static uint GetUTF16(uint[] text, int i) { }

	// RVA: 0x1ECFAD0 Offset: 0x1ECBAD0 VA: 0x1ECFAD0
	public static uint GetUTF16(TextBackingContainer text, int i) { }

	// RVA: 0x1ECF7DC Offset: 0x1ECB7DC VA: 0x1ECF7DC
	public static uint GetUTF32(uint[] text, int i) { }

	// RVA: 0x1ECFB8C Offset: 0x1ECBB8C VA: 0x1ECFB8C
	public static uint GetUTF32(TextBackingContainer text, int i) { }

	// RVA: 0x1ECFC98 Offset: 0x1ECBC98 VA: 0x1ECFC98
	public static void FillCharacterVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x1ED057C Offset: 0x1ECC57C VA: 0x1ED057C
	public static void FillSpriteVertexBuffers(int i, bool convertToLinearSpace, TextGenerationSettings generationSettings, TextInfo textInfo) { }

	// RVA: 0x1ED0D2C Offset: 0x1ECCD2C VA: 0x1ED0D2C
	public static void AdjustLineOffset(int startIndex, int endIndex, float offset, TextInfo textInfo) { }

	// RVA: 0x1ED0EAC Offset: 0x1ECCEAC VA: 0x1ED0EAC
	public static void ResizeLineExtents(int size, TextInfo textInfo) { }

	// RVA: 0x1ED1058 Offset: 0x1ECD058 VA: 0x1ED1058
	public static FontStyles LegacyStyleToNewStyle(FontStyle fontStyle) { }

	// RVA: 0x1ED1068 Offset: 0x1ECD068 VA: 0x1ED1068
	public static TextAlignment LegacyAlignmentToNewAlignment(TextAnchor anchor) { }

	// RVA: 0x1ED108C Offset: 0x1ECD08C VA: 0x1ED108C
	public static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	// RVA: 0x1ED10A0 Offset: 0x1ECD0A0 VA: 0x1ED10A0
	public static int GetMarkupTagHashCode(TextBackingContainer styleDefinition, int readIndex) { }

	// RVA: 0x1ECF95C Offset: 0x1ECB95C VA: 0x1ECF95C
	public static int GetMarkupTagHashCode(uint[] styleDefinition, int readIndex) { }

	// RVA: 0x1ECFA5C Offset: 0x1ECBA5C VA: 0x1ECFA5C
	public static char ToUpperASCIIFast(char c) { }

	// RVA: 0x1ED1190 Offset: 0x1ECD190 VA: 0x1ED1190
	public static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x1ED1204 Offset: 0x1ECD204 VA: 0x1ED1204
	public static char ToUpperFast(char c) { }

	// RVA: 0x1ED1278 Offset: 0x1ECD278 VA: 0x1ED1278
	public static int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x1ED1364 Offset: 0x1ECD364 VA: 0x1ED1364
	public static bool IsBaseGlyph(uint c) { }

	[Extension]
	// RVA: 0x1ED14E4 Offset: 0x1ECD4E4 VA: 0x1ED14E4
	public static Color MinAlpha(Color c1, Color c2) { }

	// RVA: 0x1ED04E8 Offset: 0x1ECC4E8 VA: 0x1ED04E8
	internal static Color32 GammaToLinear(Color32 c) { }

	// RVA: 0x1ED14F0 Offset: 0x1ECD4F0 VA: 0x1ED14F0
	private static byte GammaToLinear(byte value) { }

	// RVA: 0x1ED1590 Offset: 0x1ECD590 VA: 0x1ED1590
	public static bool IsValidUTF16(TextBackingContainer text, int index) { }

	// RVA: 0x1ED162C Offset: 0x1ECD62C VA: 0x1ED162C
	public static bool IsValidUTF32(TextBackingContainer text, int index) { }

	// RVA: 0x1ED16C8 Offset: 0x1ECD6C8 VA: 0x1ED16C8
	internal static bool IsEmoji(uint c) { }

	// RVA: 0x1ED1748 Offset: 0x1ECD748 VA: 0x1ED1748
	internal static bool IsEmojiPresentationForm(uint c) { }

	// RVA: 0x1ED17C8 Offset: 0x1ECD7C8 VA: 0x1ED17C8
	internal static bool IsHangul(uint c) { }

	// RVA: 0x1ED185C Offset: 0x1ECD85C VA: 0x1ED185C
	internal static bool IsCJK(uint c) { }

	// RVA: 0x1ED19B0 Offset: 0x1ECD9B0 VA: 0x1ED19B0
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal static class TextGenerationInfo // TypeDefIndex: 7493
{
	// Methods

	// RVA: 0x1ED1B14 Offset: 0x1ECDB14 VA: 0x1ED1B14
	public static void Destroy(IntPtr ptr) { }
}

// Namespace: UnityEngine.TextCore.Text
[NativeHeader("Modules/TextCoreTextEngine/Native/TextSelectionService.h")]
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule", "Unity.UIElements.PlayModeTests" })]
internal class TextSelectionService // TypeDefIndex: 7494
{
	// Methods

	[NativeMethod(Name = "TextSelectionService::GetCursorPositionFromLogicalIndex")]
	// RVA: 0x1ED1B50 Offset: 0x1ECDB50 VA: 0x1ED1B50
	internal static Vector2 GetCursorPositionFromLogicalIndex(IntPtr textGenerationInfo, int logicalIndex) { }

	// RVA: 0x1ED1BAC Offset: 0x1ECDBAC VA: 0x1ED1BAC
	private static void GetCursorPositionFromLogicalIndex_Injected(IntPtr textGenerationInfo, int logicalIndex, out Vector2 ret) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TextHandle.<>c // TypeDefIndex: 7495
{
	// Fields
	public static readonly TextHandle.<>c <>9; // 0x0
	public static Func<TextGenerationSettings> <>9__7_0; // 0x8
	public static Func<TextGenerator> <>9__10_0; // 0x10
	public static Func<TextInfo> <>9__13_0; // 0x18

	// Methods

	// RVA: 0x1ED300C Offset: 0x1ECF00C VA: 0x1ED300C
	private static void .cctor() { }

	// RVA: 0x1ED3074 Offset: 0x1ECF074 VA: 0x1ED3074
	public void .ctor() { }

	// RVA: 0x1ED307C Offset: 0x1ECF07C VA: 0x1ED307C
	internal TextGenerationSettings <get_settingsArray>b__7_0() { }

	// RVA: 0x1ED30CC Offset: 0x1ECF0CC VA: 0x1ED30CC
	internal TextGenerator <get_generators>b__10_0() { }

	// RVA: 0x1ED3120 Offset: 0x1ECF120 VA: 0x1ED3120
	internal TextInfo <get_textInfosCommon>b__13_0() { }
}

// Namespace: UnityEngine.TextCore.Text
[DebuggerDisplay("{settings.text}")]
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal class TextHandle // TypeDefIndex: 7496
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static TextHandleTemporaryCache s_TemporaryCache; // 0x0
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static TextHandlePermanentCache s_PermanentCache; // 0x8
	private static TextGenerationSettings[] s_Settings; // 0x10
	private static TextGenerator[] s_Generators; // 0x18
	private static TextInfo[] s_TextInfosCommon; // 0x20
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal NativeTextGenerationSettings nativeSettings; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Vector2 <preferredSize>k__BackingField; // 0x70
	private Rect m_ScreenRect; // 0x78
	private float m_LineHeightDefault; // 0x88
	private bool m_IsPlaceholder; // 0x8C
	protected bool m_IsEllided; // 0x8D
	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	internal IntPtr textGenerationInfo; // 0x90
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private LinkedListNode<TextInfo> <TextInfoNode>k__BackingField; // 0x98
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <IsCachedPermanent>k__BackingField; // 0xA0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <IsCachedTemporary>k__BackingField; // 0xA1
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal int m_PreviousGenerationSettingsHash; // 0xA4
	protected bool isDirty; // 0xA8

	// Properties
	internal static TextGenerationSettings[] settingsArray { get; }
	internal static TextGenerator[] generators { get; }
	internal static TextInfo[] textInfosCommon { get; }
	internal static TextInfo textInfoCommon { get; }
	private static TextGenerator generator { get; }
	internal static TextGenerationSettings settings { get; }
	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	internal Vector2 preferredSize { get; set; }
	internal LinkedListNode<TextInfo> TextInfoNode { get; set; }
	internal bool IsCachedPermanent { get; set; }
	internal bool IsCachedTemporary { get; set; }
	internal bool useAdvancedText { get; }
	internal TextInfo textInfo { get; }

	// Methods

	// RVA: 0x1ED1C00 Offset: 0x1ECDC00 VA: 0x1ED1C00
	public void .ctor() { }

	// RVA: 0x1ED1C50 Offset: 0x1ECDC50 VA: 0x1ED1C50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1ED1DF4 Offset: 0x1ECDDF4 VA: 0x1ED1DF4
	internal static TextGenerationSettings[] get_settingsArray() { }

	// RVA: 0x1ED1F64 Offset: 0x1ECDF64 VA: 0x1ED1F64
	internal static TextGenerator[] get_generators() { }

	// RVA: 0x1ED20D4 Offset: 0x1ECE0D4 VA: 0x1ED20D4
	internal static TextInfo[] get_textInfosCommon() { }

	// RVA: -1 Offset: -1
	private static void InitArray<T>(ref T[] array, Func<T> createInstance) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10387AC Offset: 0x10347AC VA: 0x10387AC
	|-TextHandle.InitArray<object>
	|
	|-RVA: 0x10388A4 Offset: 0x10348A4 VA: 0x10388A4
	|-TextHandle.InitArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1ED2244 Offset: 0x1ECE244 VA: 0x1ED2244
	internal static TextInfo get_textInfoCommon() { }

	// RVA: 0x1ED22C0 Offset: 0x1ECE2C0 VA: 0x1ED22C0
	private static TextGenerator get_generator() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	// RVA: 0x1ED233C Offset: 0x1ECE33C VA: 0x1ED233C
	internal static TextGenerationSettings get_settings() { }

	[CompilerGenerated]
	// RVA: 0x1ED23B8 Offset: 0x1ECE3B8 VA: 0x1ED23B8
	internal Vector2 get_preferredSize() { }

	[CompilerGenerated]
	// RVA: 0x1ED23C0 Offset: 0x1ECE3C0 VA: 0x1ED23C0
	internal void set_preferredSize(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x1ED23C8 Offset: 0x1ECE3C8 VA: 0x1ED23C8
	internal LinkedListNode<TextInfo> get_TextInfoNode() { }

	[CompilerGenerated]
	// RVA: 0x1ED23D0 Offset: 0x1ECE3D0 VA: 0x1ED23D0
	internal void set_TextInfoNode(LinkedListNode<TextInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x1ED23D8 Offset: 0x1ECE3D8 VA: 0x1ED23D8
	internal bool get_IsCachedPermanent() { }

	[CompilerGenerated]
	// RVA: 0x1ED23E0 Offset: 0x1ECE3E0 VA: 0x1ED23E0
	internal void set_IsCachedPermanent(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1ED23E8 Offset: 0x1ECE3E8 VA: 0x1ED23E8
	internal bool get_IsCachedTemporary() { }

	[CompilerGenerated]
	// RVA: 0x1ED23F0 Offset: 0x1ECE3F0 VA: 0x1ED23F0
	internal void set_IsCachedTemporary(bool value) { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	// RVA: 0x1ED23F8 Offset: 0x1ECE3F8 VA: 0x1ED23F8
	internal bool get_useAdvancedText() { }

	// RVA: 0x1ED2404 Offset: 0x1ECE404 VA: 0x1ED2404 Slot: 4
	public virtual void AddTextInfoToPermanentCache() { }

	// RVA: 0x1ED1CDC Offset: 0x1ECDCDC VA: 0x1ED1CDC
	public void RemoveTextInfoFromTemporaryCache() { }

	// RVA: 0x1ED1D4C Offset: 0x1ECDD4C VA: 0x1ED1D4C
	public void RemoveTextInfoFromPermanentCache() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	// RVA: 0x1ED2604 Offset: 0x1ECE604 VA: 0x1ED2604
	internal TextInfo get_textInfo() { }

	// RVA: 0x1ED2678 Offset: 0x1ECE678 VA: 0x1ED2678
	public void SetDirty() { }

	// RVA: 0x1ED2684 Offset: 0x1ECE684 VA: 0x1ED2684
	public bool IsDirty(int hashCode) { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	// RVA: 0x1ED26C0 Offset: 0x1ECE6C0 VA: 0x1ED26C0
	internal TextInfo Update() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	// RVA: 0x1ED2730 Offset: 0x1ECE730 VA: 0x1ED2730
	internal TextInfo UpdateWithHash(int hashCode) { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	// RVA: 0x1ED2A5C Offset: 0x1ECEA5C VA: 0x1ED2A5C
	internal void UpdatePreferredSize() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	// RVA: 0x1ED2914 Offset: 0x1ECE914 VA: 0x1ED2914
	internal static float GetLineHeightDefault(TextGenerationSettings settings) { }

	// RVA: 0x1ED2C88 Offset: 0x1ECEC88 VA: 0x1ED2C88
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, bool useXAdvance = False, bool inverseYAxis = True) { }

	// RVA: 0x1ED2DCC Offset: 0x1ECEDCC VA: 0x1ED2DCC Slot: 5
	internal virtual bool IsAdvancedTextEnabledForElement() { }

	// RVA: 0x1ED2DD4 Offset: 0x1ECEDD4 VA: 0x1ED2DD4
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal class TextHandlePermanentCache // TypeDefIndex: 7497
{
	// Fields
	internal LinkedList<TextInfo> s_TextInfoPool; // 0x10
	private object syncRoot; // 0x18

	// Methods

	// RVA: 0x1ED3340 Offset: 0x1ECF340 VA: 0x1ED3340 Slot: 4
	public virtual void AddTextInfoToCache(TextHandle textHandle) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1ED24D0 Offset: 0x1ECE4D0 VA: 0x1ED24D0
	public void RemoveTextInfoFromCache(TextHandle textHandle) { }

	// RVA: 0x1ED2F4C Offset: 0x1ECEF4C VA: 0x1ED2F4C
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal class TextHandleTemporaryCache // TypeDefIndex: 7498
{
	// Fields
	internal LinkedList<TextInfo> s_TextInfoPool; // 0x10
	private object syncRoot; // 0x18

	// Methods

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1ED3578 Offset: 0x1ECF578 VA: 0x1ED3578 Slot: 4
	public virtual void RemoveTextInfoFromCache(TextHandle textHandle) { }

	// RVA: 0x1ED2E8C Offset: 0x1ECEE8C VA: 0x1ED2E8C
	public void .ctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal struct WordInfo // TypeDefIndex: 7499
{
	// Fields
	public int firstCharacterIndex; // 0x0
	public int lastCharacterIndex; // 0x4
	public int characterCount; // 0x8
}

// Namespace: UnityEngine.TextCore.Text
[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
internal class TextInfo // TypeDefIndex: 7500
{
	// Fields
	private static Vector2 s_InfinityVectorPositive; // 0x0
	private static Vector2 s_InfinityVectorNegative; // 0x8
	public int characterCount; // 0x10
	public int spriteCount; // 0x14
	public int spaceCount; // 0x18
	public int wordCount; // 0x1C
	public int linkCount; // 0x20
	public int lineCount; // 0x24
	public int materialCount; // 0x28
	public TextElementInfo[] textElementInfo; // 0x30
	public WordInfo[] wordInfo; // 0x38
	public LinkInfo[] linkInfo; // 0x40
	public LineInfo[] lineInfo; // 0x48
	public MeshInfo[] meshInfo; // 0x50
	public double lastTimeInCache; // 0x58
	public Action removedFromCache; // 0x60
	public bool hasMultipleColors; // 0x68

	// Methods

	// RVA: 0x1ED3170 Offset: 0x1ECF170 VA: 0x1ED3170
	public void .ctor() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1ED3718 Offset: 0x1ECF718 VA: 0x1ED3718
	internal void Clear() { }

	// RVA: 0x1ED376C Offset: 0x1ECF76C VA: 0x1ED376C
	internal void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x1ED37E0 Offset: 0x1ECF7E0 VA: 0x1ED37E0
	internal void ClearLineInfo() { }

	// RVA: -1 Offset: -1
	internal static void Resize<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1038A78 Offset: 0x1034A78 VA: 0x1038A78
	|-TextInfo.Resize<LinkInfo>
	|
	|-RVA: 0x1038AD8 Offset: 0x1034AD8 VA: 0x1038AD8
	|-TextInfo.Resize<WordInfo>
	|
	|-RVA: 0x1038B38 Offset: 0x1034B38 VA: 0x1038B38
	|-TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1038B9C Offset: 0x1034B9C VA: 0x1038B9C
	|-TextInfo.Resize<MeshInfo>
	|
	|-RVA: 0x1038C48 Offset: 0x1034C48 VA: 0x1038C48
	|-TextInfo.Resize<TextElementInfo>
	|
	|-RVA: 0x1038CF4 Offset: 0x1034CF4 VA: 0x1038CF4
	|-TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1ED2D18 Offset: 0x1ECED18 VA: 0x1ED2D18
	public Vector2 GetCursorPositionFromStringIndexUsingLineHeight(int index, Rect screenRect, float lineHeight, bool useXAdvance = False, bool inverseYAxis = True) { }

	// RVA: 0x1ED3960 Offset: 0x1ECF960 VA: 0x1ED3960
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
internal enum MarkupTag // TypeDefIndex: 7501
{
	// Fields
	public int value__; // 0x0
	public const MarkupTag BOLD = 66;
	public const MarkupTag SLASH_BOLD = 1613;
	public const MarkupTag ITALIC = 73;
	public const MarkupTag SLASH_ITALIC = 1606;
	public const MarkupTag UNDERLINE = 85;
	public const MarkupTag SLASH_UNDERLINE = 1626;
	public const MarkupTag STRIKETHROUGH = 83;
	public const MarkupTag SLASH_STRIKETHROUGH = 1628;
	public const MarkupTag MARK = 2699125;
	public const MarkupTag SLASH_MARK = 57644506;
	public const MarkupTag SUBSCRIPT = 92132;
	public const MarkupTag SLASH_SUBSCRIPT = 1770219;
	public const MarkupTag SUPERSCRIPT = 92150;
	public const MarkupTag SLASH_SUPERSCRIPT = 1770233;
	public const MarkupTag COLOR = 81999901;
	public const MarkupTag SLASH_COLOR = 1909026194;
	public const MarkupTag ALPHA = 75165780;
	public const MarkupTag A = 65;
	public const MarkupTag SLASH_A = 1614;
	public const MarkupTag SIZE = 3061285;
	public const MarkupTag SLASH_SIZE = 58429962;
	public const MarkupTag SPRITE = -991527447;
	public const MarkupTag NO_BREAK = 2856657;
	public const MarkupTag SLASH_NO_BREAK = 57477502;
	public const MarkupTag STYLE = 100252951;
	public const MarkupTag SLASH_STYLE = 1927738392;
	public const MarkupTag FONT = 2586451;
	public const MarkupTag SLASH_FONT = 57747708;
	public const MarkupTag SLASH_MATERIAL = -1100708252;
	public const MarkupTag LINK = 2656128;
	public const MarkupTag SLASH_LINK = 57686191;
	public const MarkupTag FONT_WEIGHT = -1889896162;
	public const MarkupTag SLASH_FONT_WEIGHT = -757976431;
	public const MarkupTag NO_PARSE = -408011596;
	public const MarkupTag SLASH_NO_PARSE = -294095813;
	public const MarkupTag POSITION = 85420;
	public const MarkupTag SLASH_POSITION = 1777699;
	public const MarkupTag VERTICAL_OFFSET = 1952379995;
	public const MarkupTag SLASH_VERTICAL_OFFSET = -11107948;
	public const MarkupTag SPACE = 100083556;
	public const MarkupTag SLASH_SPACE = 1927873067;
	public const MarkupTag PAGE = 2808691;
	public const MarkupTag SLASH_PAGE = 58683868;
	public const MarkupTag ALIGN = 75138797;
	public const MarkupTag SLASH_ALIGN = 1916026786;
	public const MarkupTag WIDTH = 105793766;
	public const MarkupTag SLASH_WIDTH = 1923459625;
	public const MarkupTag GRADIENT = -1999759898;
	public const MarkupTag SLASH_GRADIENT = -1854491959;
	public const MarkupTag CHARACTER_SPACE = -1584382009;
	public const MarkupTag SLASH_CHARACTER_SPACE = -1394426712;
	public const MarkupTag MONOSPACE = -1340221943;
	public const MarkupTag SLASH_MONOSPACE = -1638865562;
	public const MarkupTag CLASS = 82115566;
	public const MarkupTag INDENT = -1514123076;
	public const MarkupTag SLASH_INDENT = -1496889389;
	public const MarkupTag LINE_INDENT = -844305121;
	public const MarkupTag SLASH_LINE_INDENT = 93886352;
	public const MarkupTag MARGIN = -1355614050;
	public const MarkupTag SLASH_MARGIN = -1649644303;
	public const MarkupTag MARGIN_LEFT = -272933656;
	public const MarkupTag MARGIN_RIGHT = -447416589;
	public const MarkupTag LINE_HEIGHT = -799081892;
	public const MarkupTag SLASH_LINE_HEIGHT = 200452819;
	public const MarkupTag ACTION = -1827519330;
	public const MarkupTag SLASH_ACTION = -1187217679;
	public const MarkupTag SCALE = 100553336;
	public const MarkupTag SLASH_SCALE = 1928413879;
	public const MarkupTag ROTATE = -1000007783;
	public const MarkupTag SLASH_ROTATE = -764695562;
	public const MarkupTag TABLE = 226476955;
	public const MarkupTag SLASH_TABLE = -979118220;
	public const MarkupTag TH = 5862489;
	public const MarkupTag SLASH_TH = 193346070;
	public const MarkupTag TR = 5862467;
	public const MarkupTag SLASH_TR = 193346060;
	public const MarkupTag TD = 5862485;
	public const MarkupTag SLASH_TD = 193346074;
	public const MarkupTag LOWERCASE = -1506899689;
	public const MarkupTag SLASH_LOWERCASE = -1451284584;
	public const MarkupTag ALLCAPS = 218273952;
	public const MarkupTag SLASH_ALLCAPS = -797437649;
	public const MarkupTag UPPERCASE = -305409418;
	public const MarkupTag SLASH_UPPERCASE = -582368199;
	public const MarkupTag SMALLCAPS = -766062114;
	public const MarkupTag SLASH_SMALLCAPS = 199921873;
	public const MarkupTag LIGA = 2655971;
	public const MarkupTag SLASH_LIGA = 57686604;
	public const MarkupTag FRAC = 2598518;
	public const MarkupTag SLASH_FRAC = 57774681;
	public const MarkupTag NAME = 2875623;
	public const MarkupTag INDEX = 84268030;
	public const MarkupTag TINT = 2960519;
	public const MarkupTag ANIM = 2283339;
	public const MarkupTag MATERIAL = 825491659;
	public const MarkupTag HREF = 2535353;
	public const MarkupTag ANGLE = 75347905;
	public const MarkupTag PADDING = -2144568463;
	public const MarkupTag FAMILYNAME = 704251153;
	public const MarkupTag STYLENAME = -1207081936;
	public const MarkupTag DUOSPACE = 582810522;
	public const MarkupTag RED = 91635;
	public const MarkupTag GREEN = 87065851;
	public const MarkupTag BLUE = 2457214;
	public const MarkupTag YELLOW = -882444668;
	public const MarkupTag ORANGE = -1108587920;
	public const MarkupTag BLACK = 81074727;
	public const MarkupTag WHITE = 105680263;
	public const MarkupTag PURPLE = -1250222130;
	public const MarkupTag GREY = 2638345;
	public const MarkupTag LIGHTBLUE = 341063360;
	public const MarkupTag TEAL = 2947772;
	public const MarkupTag CYAN = 2504597;
	public const MarkupTag DARKBLUE = -1960309918;
	public const MarkupTag FUCHSIA = -1002715645;
	public const MarkupTag SILVER = -960329321;
	public const MarkupTag BROWN = 81017702;
	public const MarkupTag MAROON = -1355621936;
	public const MarkupTag OLIVE = 95492953;
	public const MarkupTag NAVY = 2876352;
	public const MarkupTag AQUA = 2284356;
	public const MarkupTag MAGENTA = -1812576107;
	public const MarkupTag TRANSPARENT = -1014785338;
	public const MarkupTag LIME = 2656045;
	public const MarkupTag BR = 2256;
	public const MarkupTag CR = 2289;
	public const MarkupTag ZWSP = 3288238;
	public const MarkupTag ZWJ = 99623;
	public const MarkupTag NBSP = 2869039;
	public const MarkupTag SHY = 92674;
	public const MarkupTag LEFT = 2660507;
	public const MarkupTag RIGHT = 99937376;
	public const MarkupTag CENTER = -1591113269;
	public const MarkupTag JUSTIFIED = 817091359;
	public const MarkupTag FLUSH = 85552164;
	public const MarkupTag NONE = 2857034;
	public const MarkupTag PLUS = 43;
	public const MarkupTag MINUS = 45;
	public const MarkupTag PX = 2568;
	public const MarkupTag PLUS_PX = 49507;
	public const MarkupTag MINUS_PX = 47461;
	public const MarkupTag EM = 2216;
	public const MarkupTag PLUS_EM = 49091;
	public const MarkupTag MINUS_EM = 46789;
	public const MarkupTag PCT = 85031;
	public const MarkupTag PLUS_PCT = 1634348;
	public const MarkupTag MINUS_PCT = 1567082;
	public const MarkupTag PERCENTAGE = 37;
	public const MarkupTag PLUS_PERCENTAGE = 1454;
	public const MarkupTag MINUS_PERCENTAGE = 1512;
	public const MarkupTag TRUE = 2932022;
	public const MarkupTag FALSE = 85422813;
	public const MarkupTag INVALID = 1585415185;
	public const MarkupTag NOTDEF = 612146780;
	public const MarkupTag NORMAL = -1183493901;
	public const MarkupTag DEFAULT = -620974005;
	public const MarkupTag REGULAR = 1291372090;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TagValueType // TypeDefIndex: 7502
{
	// Fields
	public int value__; // 0x0
	public const TagValueType None = 0;
	public const TagValueType NumericalValue = 1;
	public const TagValueType StringValue = 2;
	public const TagValueType ColorValue = 4;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TagUnitType // TypeDefIndex: 7503
{
	// Fields
	public int value__; // 0x0
	public const TagUnitType Pixels = 0;
	public const TagUnitType FontUnits = 1;
	public const TagUnitType Percentage = 2;
}

// Namespace: UnityEngine.TextCore.Text
internal enum TextProcessingElementType // TypeDefIndex: 7504
{
	// Fields
	public int value__; // 0x0
	public const TextProcessingElementType Undefined = 0;
	public const TextProcessingElementType TextCharacterElement = 1;
	public const TextProcessingElementType TextMarkupElement = 2;
}

// Namespace: UnityEngine.TextCore.Text
internal struct FontStyleStack // TypeDefIndex: 7505
{
	// Fields
	public byte bold; // 0x0
	public byte italic; // 0x1
	public byte underline; // 0x2
	public byte strikethrough; // 0x3
	public byte highlight; // 0x4
	public byte superscript; // 0x5
	public byte subscript; // 0x6
	public byte uppercase; // 0x7
	public byte lowercase; // 0x8
	public byte smallcaps; // 0x9

	// Methods

	// RVA: 0x1ED39CC Offset: 0x1ECF9CC VA: 0x1ED39CC
	public void Clear() { }

	// RVA: 0x1ED39D8 Offset: 0x1ECF9D8 VA: 0x1ED39D8
	public byte Add(FontStyles style) { }

	// RVA: 0x1ED3ADC Offset: 0x1ECFADC VA: 0x1ED3ADC
	public byte Remove(FontStyles style) { }
}

// Namespace: UnityEngine.TextCore.Text
[DebuggerDisplay("Item count = {m_Count}")]
internal struct TextProcessingStack<T> // TypeDefIndex: 7506
{
	// Fields
	public T[] itemStack; // 0x0
	public int index; // 0x0
	private T m_DefaultItem; // 0x0
	private int m_Capacity; // 0x0
	private int m_RolloverSize; // 0x0
	private int m_Count; // 0x0

	// Properties
	public int Count { get; }
	public T current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147A6A4 Offset: 0x14766A4 VA: 0x147A6A4
	|-TextProcessingStack<Color32>..ctor
	|
	|-RVA: 0x147AC0C Offset: 0x1476C0C VA: 0x147AC0C
	|-TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x147B2D4 Offset: 0x14772D4 VA: 0x147B2D4
	|-TextProcessingStack<int>..ctor
	|
	|-RVA: 0x147B83C Offset: 0x147783C VA: 0x147B83C
	|-TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x147BDA4 Offset: 0x1477DA4 VA: 0x147BDA4
	|-TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x147C584 Offset: 0x1478584 VA: 0x147C584
	|-TextProcessingStack<object>..ctor
	|
	|-RVA: 0x147CB20 Offset: 0x1478B20 VA: 0x147CB20
	|-TextProcessingStack<float>..ctor
	|
	|-RVA: 0x147D094 Offset: 0x1479094 VA: 0x147D094
	|-TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x147D8A4 Offset: 0x14798A4 VA: 0x147D8A4
	|-TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147A6E4 Offset: 0x14766E4 VA: 0x147A6E4
	|-TextProcessingStack<Color32>..ctor
	|
	|-RVA: 0x147AC4C Offset: 0x1476C4C VA: 0x147AC4C
	|-TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x147B314 Offset: 0x1477314 VA: 0x147B314
	|-TextProcessingStack<int>..ctor
	|
	|-RVA: 0x147B87C Offset: 0x147787C VA: 0x147B87C
	|-TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x147BDF0 Offset: 0x1477DF0 VA: 0x147BDF0
	|-TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x147C5C4 Offset: 0x14785C4 VA: 0x147C5C4
	|-TextProcessingStack<object>..ctor
	|
	|-RVA: 0x147CB60 Offset: 0x1478B60 VA: 0x147CB60
	|-TextProcessingStack<float>..ctor
	|
	|-RVA: 0x147D0E4 Offset: 0x14790E4 VA: 0x147D0E4
	|-TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x147DA28 Offset: 0x1479A28 VA: 0x147DA28
	|-TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int rolloverSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147A75C Offset: 0x147675C VA: 0x147A75C
	|-TextProcessingStack<Color32>..ctor
	|
	|-RVA: 0x147ACC4 Offset: 0x1476CC4 VA: 0x147ACC4
	|-TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x147B38C Offset: 0x147738C VA: 0x147B38C
	|-TextProcessingStack<int>..ctor
	|
	|-RVA: 0x147B8F4 Offset: 0x14778F4 VA: 0x147B8F4
	|-TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x147BE74 Offset: 0x1477E74 VA: 0x147BE74
	|-TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x147C63C Offset: 0x147863C VA: 0x147C63C
	|-TextProcessingStack<object>..ctor
	|
	|-RVA: 0x147CBD8 Offset: 0x1478BD8 VA: 0x147CBD8
	|-TextProcessingStack<float>..ctor
	|
	|-RVA: 0x147D16C Offset: 0x147916C VA: 0x147D16C
	|-TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x147DBE4 Offset: 0x1479BE4 VA: 0x147DBE4
	|-TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147A7D4 Offset: 0x14767D4 VA: 0x147A7D4
	|-TextProcessingStack<Color32>.get_Count
	|
	|-RVA: 0x147AD44 Offset: 0x1476D44 VA: 0x147AD44
	|-TextProcessingStack<HighlightState>.get_Count
	|
	|-RVA: 0x147B404 Offset: 0x1477404 VA: 0x147B404
	|-TextProcessingStack<int>.get_Count
	|
	|-RVA: 0x147B96C Offset: 0x147796C VA: 0x147B96C
	|-TextProcessingStack<Int32Enum>.get_Count
	|
	|-RVA: 0x147BEFC Offset: 0x1477EFC VA: 0x147BEFC
	|-TextProcessingStack<MaterialReference>.get_Count
	|
	|-RVA: 0x147C6B8 Offset: 0x14786B8 VA: 0x147C6B8
	|-TextProcessingStack<object>.get_Count
	|
	|-RVA: 0x147CC50 Offset: 0x1478C50 VA: 0x147CC50
	|-TextProcessingStack<float>.get_Count
	|
	|-RVA: 0x147D1F8 Offset: 0x14791F8 VA: 0x147D1F8
	|-TextProcessingStack<WordWrapState>.get_Count
	|
	|-RVA: 0x147DDAC Offset: 0x1479DAC VA: 0x147DDAC
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147A7DC Offset: 0x14767DC VA: 0x147A7DC
	|-TextProcessingStack<Color32>.get_current
	|
	|-RVA: 0x147AD4C Offset: 0x1476D4C VA: 0x147AD4C
	|-TextProcessingStack<HighlightState>.get_current
	|
	|-RVA: 0x147B40C Offset: 0x147740C VA: 0x147B40C
	|-TextProcessingStack<int>.get_current
	|
	|-RVA: 0x147B974 Offset: 0x1477974 VA: 0x147B974
	|-TextProcessingStack<Int32Enum>.get_current
	|
	|-RVA: 0x147BF04 Offset: 0x1477F04 VA: 0x147BF04
	|-TextProcessingStack<MaterialReference>.get_current
	|
	|-RVA: 0x147C6C0 Offset: 0x14786C0 VA: 0x147C6C0
	|-TextProcessingStack<object>.get_current
	|
	|-RVA: 0x147CC58 Offset: 0x1478C58 VA: 0x147CC58
	|-TextProcessingStack<float>.get_current
	|
	|-RVA: 0x147D200 Offset: 0x1479200 VA: 0x147D200
	|-TextProcessingStack<WordWrapState>.get_current
	|
	|-RVA: 0x147DDF4 Offset: 0x1479DF4 VA: 0x147DDF4
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.get_current
	*/

	// RVA: -1 Offset: -1
	internal static void SetDefault(TextProcessingStack<T>[] stack, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147A82C Offset: 0x147682C VA: 0x147A82C
	|-TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x147ADB8 Offset: 0x1476DB8 VA: 0x147ADB8
	|-TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x147B45C Offset: 0x147745C VA: 0x147B45C
	|-TextProcessingStack<int>.SetDefault
	|
	|-RVA: 0x147B9C4 Offset: 0x14779C4 VA: 0x147B9C4
	|-TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x147BF80 Offset: 0x1477F80 VA: 0x147BF80
	|-TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x147C710 Offset: 0x1478710 VA: 0x147C710
	|-TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x147CCA8 Offset: 0x1478CA8 VA: 0x147CCA8
	|-TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x147D294 Offset: 0x1479294 VA: 0x147D294
	|-TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x147DFEC Offset: 0x1479FEC VA: 0x147DFEC
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147A8BC Offset: 0x14768BC VA: 0x147A8BC
	|-TextProcessingStack<Color32>.Clear
	|
	|-RVA: 0x147AE6C Offset: 0x1476E6C VA: 0x147AE6C
	|-TextProcessingStack<HighlightState>.Clear
	|
	|-RVA: 0x147B4EC Offset: 0x14774EC VA: 0x147B4EC
	|-TextProcessingStack<int>.Clear
	|
	|-RVA: 0x147BA54 Offset: 0x1477A54 VA: 0x147BA54
	|-TextProcessingStack<Int32Enum>.Clear
	|
	|-RVA: 0x147C044 Offset: 0x1478044 VA: 0x147C044
	|-TextProcessingStack<MaterialReference>.Clear
	|
	|-RVA: 0x147C7A0 Offset: 0x14787A0 VA: 0x147C7A0
	|-TextProcessingStack<object>.Clear
	|
	|-RVA: 0x147CD40 Offset: 0x1478D40 VA: 0x147CD40
	|-TextProcessingStack<float>.Clear
	|
	|-RVA: 0x147D358 Offset: 0x1479358 VA: 0x147D358
	|-TextProcessingStack<WordWrapState>.Clear
	|
	|-RVA: 0x147E1E0 Offset: 0x147A1E0 VA: 0x147E1E0
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147A8C8 Offset: 0x14768C8 VA: 0x147A8C8
	|-TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x147AE78 Offset: 0x1476E78 VA: 0x147AE78
	|-TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x147B4F8 Offset: 0x14774F8 VA: 0x147B4F8
	|-TextProcessingStack<int>.SetDefault
	|
	|-RVA: 0x147BA60 Offset: 0x1477A60 VA: 0x147BA60
	|-TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x147C050 Offset: 0x1478050 VA: 0x147C050
	|-TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x147C7AC Offset: 0x14787AC VA: 0x147C7AC
	|-TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x147CD4C Offset: 0x1478D4C VA: 0x147CD4C
	|-TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x147D364 Offset: 0x1479364 VA: 0x147D364
	|-TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x147E260 Offset: 0x147A260 VA: 0x147E260
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147A964 Offset: 0x1476964 VA: 0x147A964
	|-TextProcessingStack<Color32>.Add
	|
	|-RVA: 0x147AF54 Offset: 0x1476F54 VA: 0x147AF54
	|-TextProcessingStack<HighlightState>.Add
	|
	|-RVA: 0x147B594 Offset: 0x1477594 VA: 0x147B594
	|-TextProcessingStack<int>.Add
	|
	|-RVA: 0x147BAFC Offset: 0x1477AFC VA: 0x147BAFC
	|-TextProcessingStack<Int32Enum>.Add
	|
	|-RVA: 0x147C154 Offset: 0x1478154 VA: 0x147C154
	|-TextProcessingStack<MaterialReference>.Add
	|
	|-RVA: 0x147C850 Offset: 0x1478850 VA: 0x147C850
	|-TextProcessingStack<object>.Add
	|
	|-RVA: 0x147CDE8 Offset: 0x1478DE8 VA: 0x147CDE8
	|-TextProcessingStack<float>.Add
	|
	|-RVA: 0x147D458 Offset: 0x1479458 VA: 0x147D458
	|-TextProcessingStack<WordWrapState>.Add
	|
	|-RVA: 0x147E598 Offset: 0x147A598 VA: 0x147E598
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147A9AC Offset: 0x14769AC VA: 0x147A9AC
	|-TextProcessingStack<Color32>.Remove
	|
	|-RVA: 0x147AFB0 Offset: 0x1476FB0 VA: 0x147AFB0
	|-TextProcessingStack<HighlightState>.Remove
	|
	|-RVA: 0x147B5DC Offset: 0x14775DC VA: 0x147B5DC
	|-TextProcessingStack<int>.Remove
	|
	|-RVA: 0x147BB44 Offset: 0x1477B44 VA: 0x147BB44
	|-TextProcessingStack<Int32Enum>.Remove
	|
	|-RVA: 0x147C1C8 Offset: 0x14781C8 VA: 0x147C1C8
	|-TextProcessingStack<MaterialReference>.Remove
	|
	|-RVA: 0x147C8A0 Offset: 0x14788A0 VA: 0x147C8A0
	|-TextProcessingStack<object>.Remove
	|
	|-RVA: 0x147CE2C Offset: 0x1478E2C VA: 0x147CE2C
	|-TextProcessingStack<float>.Remove
	|
	|-RVA: 0x147D4C4 Offset: 0x14794C4 VA: 0x147D4C4
	|-TextProcessingStack<WordWrapState>.Remove
	|
	|-RVA: 0x147E86C Offset: 0x147A86C VA: 0x147E86C
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147AA20 Offset: 0x1476A20 VA: 0x147AA20
	|-TextProcessingStack<Color32>.Push
	|
	|-RVA: 0x147B044 Offset: 0x1477044 VA: 0x147B044
	|-TextProcessingStack<HighlightState>.Push
	|
	|-RVA: 0x147B650 Offset: 0x1477650 VA: 0x147B650
	|-TextProcessingStack<int>.Push
	|
	|-RVA: 0x147BBB8 Offset: 0x1477BB8 VA: 0x147BBB8
	|-TextProcessingStack<Int32Enum>.Push
	|
	|-RVA: 0x147C26C Offset: 0x147826C VA: 0x147C26C
	|-TextProcessingStack<MaterialReference>.Push
	|
	|-RVA: 0x147C914 Offset: 0x1478914 VA: 0x147C914
	|-TextProcessingStack<object>.Push
	|
	|-RVA: 0x147CEA0 Offset: 0x1478EA0 VA: 0x147CEA0
	|-TextProcessingStack<float>.Push
	|
	|-RVA: 0x147D580 Offset: 0x1479580 VA: 0x147D580
	|-TextProcessingStack<WordWrapState>.Push
	|
	|-RVA: 0x147EB8C Offset: 0x147AB8C VA: 0x147EB8C
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147AAF0 Offset: 0x1476AF0 VA: 0x147AAF0
	|-TextProcessingStack<Color32>.Pop
	|
	|-RVA: 0x147B128 Offset: 0x1477128 VA: 0x147B128
	|-TextProcessingStack<HighlightState>.Pop
	|
	|-RVA: 0x147B720 Offset: 0x1477720 VA: 0x147B720
	|-TextProcessingStack<int>.Pop
	|
	|-RVA: 0x147BC88 Offset: 0x1477C88 VA: 0x147BC88
	|-TextProcessingStack<Int32Enum>.Pop
	|
	|-RVA: 0x147C364 Offset: 0x1478364 VA: 0x147C364
	|-TextProcessingStack<MaterialReference>.Pop
	|
	|-RVA: 0x147C9EC Offset: 0x14789EC VA: 0x147C9EC
	|-TextProcessingStack<object>.Pop
	|
	|-RVA: 0x147CF74 Offset: 0x1478F74 VA: 0x147CF74
	|-TextProcessingStack<float>.Pop
	|
	|-RVA: 0x147D66C Offset: 0x147966C VA: 0x147D66C
	|-TextProcessingStack<WordWrapState>.Pop
	|
	|-RVA: 0x147F204 Offset: 0x147B204 VA: 0x147F204
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147AB74 Offset: 0x1476B74 VA: 0x147AB74
	|-TextProcessingStack<Color32>.Peek
	|
	|-RVA: 0x147B200 Offset: 0x1477200 VA: 0x147B200
	|-TextProcessingStack<HighlightState>.Peek
	|
	|-RVA: 0x147B7A4 Offset: 0x14777A4 VA: 0x147B7A4
	|-TextProcessingStack<int>.Peek
	|
	|-RVA: 0x147BD0C Offset: 0x1477D0C VA: 0x147BD0C
	|-TextProcessingStack<Int32Enum>.Peek
	|
	|-RVA: 0x147C490 Offset: 0x1478490 VA: 0x147C490
	|-TextProcessingStack<MaterialReference>.Peek
	|
	|-RVA: 0x147CA88 Offset: 0x1478A88 VA: 0x147CA88
	|-TextProcessingStack<object>.Peek
	|
	|-RVA: 0x147CFFC Offset: 0x1478FFC VA: 0x147CFFC
	|-TextProcessingStack<float>.Peek
	|
	|-RVA: 0x147D784 Offset: 0x1479784 VA: 0x147D784
	|-TextProcessingStack<WordWrapState>.Peek
	|
	|-RVA: 0x147F854 Offset: 0x147B854 VA: 0x147F854
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x147ABBC Offset: 0x1476BBC VA: 0x147ABBC
	|-TextProcessingStack<Color32>.CurrentItem
	|
	|-RVA: 0x147B268 Offset: 0x1477268 VA: 0x147B268
	|-TextProcessingStack<HighlightState>.CurrentItem
	|
	|-RVA: 0x147B7EC Offset: 0x14777EC VA: 0x147B7EC
	|-TextProcessingStack<int>.CurrentItem
	|
	|-RVA: 0x147BD54 Offset: 0x1477D54 VA: 0x147BD54
	|-TextProcessingStack<Int32Enum>.CurrentItem
	|
	|-RVA: 0x147C508 Offset: 0x1478508 VA: 0x147C508
	|-TextProcessingStack<MaterialReference>.CurrentItem
	|
	|-RVA: 0x147CAD0 Offset: 0x1478AD0 VA: 0x147CAD0
	|-TextProcessingStack<object>.CurrentItem
	|
	|-RVA: 0x147D044 Offset: 0x1479044 VA: 0x147D044
	|-TextProcessingStack<float>.CurrentItem
	|
	|-RVA: 0x147D810 Offset: 0x1479810 VA: 0x147D810
	|-TextProcessingStack<WordWrapState>.CurrentItem
	|
	|-RVA: 0x147FA40 Offset: 0x147BA40 VA: 0x147FA40
	|-TextProcessingStack<__Il2CppFullySharedGenericType>.CurrentItem
	*/
}

// Namespace: 
private struct TextResourceManager.FontAssetRef // TypeDefIndex: 7507
{
	// Fields
	public int nameHashCode; // 0x0
	public int familyNameHashCode; // 0x4
	public int styleNameHashCode; // 0x8
	public long familyNameAndStyleHashCode; // 0x10
	public readonly FontAsset fontAsset; // 0x18

	// Methods

	// RVA: 0x1ED4128 Offset: 0x1ED0128 VA: 0x1ED4128
	public void .ctor(int nameHashCode, int familyNameHashCode, int styleNameHashCode, FontAsset fontAsset) { }
}

// Namespace: UnityEngine.TextCore.Text
internal class TextResourceManager // TypeDefIndex: 7508
{
	// Fields
	private static readonly Dictionary<int, TextResourceManager.FontAssetRef> s_FontAssetReferences; // 0x0
	private static readonly Dictionary<int, FontAsset> s_FontAssetNameReferenceLookup; // 0x8
	private static readonly Dictionary<long, FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; // 0x10
	private static readonly List<int> s_FontAssetRemovalList; // 0x18
	private static readonly int k_RegularStyleHashCode; // 0x20

	// Methods

	// RVA: 0x1ED3C04 Offset: 0x1ECFC04 VA: 0x1ED3C04
	internal static void AddFontAsset(FontAsset fontAsset) { }

	// RVA: 0x1ED4150 Offset: 0x1ED0150 VA: 0x1ED4150
	private static void .cctor() { }
}

// Namespace: UnityEngine.TextCore.Text
[ExcludeFromDocs]
public static class TextShaderUtilities // TypeDefIndex: 7509
{
	// Fields
	public static int ID_MainTex; // 0x0
	public static int ID_FaceTex; // 0x4
	public static int ID_FaceColor; // 0x8
	public static int ID_FaceDilate; // 0xC
	public static int ID_Shininess; // 0x10
	public static int ID_OutlineOffset1; // 0x14
	public static int ID_OutlineOffset2; // 0x18
	public static int ID_OutlineOffset3; // 0x1C
	public static int ID_OutlineMode; // 0x20
	public static int ID_IsoPerimeter; // 0x24
	public static int ID_Softness; // 0x28
	public static int ID_UnderlayColor; // 0x2C
	public static int ID_UnderlayOffsetX; // 0x30
	public static int ID_UnderlayOffsetY; // 0x34
	public static int ID_UnderlayDilate; // 0x38
	public static int ID_UnderlaySoftness; // 0x3C
	public static int ID_UnderlayOffset; // 0x40
	public static int ID_UnderlayIsoPerimeter; // 0x44
	public static int ID_WeightNormal; // 0x48
	public static int ID_WeightBold; // 0x4C
	public static int ID_OutlineTex; // 0x50
	public static int ID_OutlineWidth; // 0x54
	public static int ID_OutlineSoftness; // 0x58
	public static int ID_OutlineColor; // 0x5C
	public static int ID_Outline2Color; // 0x60
	public static int ID_Outline2Width; // 0x64
	public static int ID_Padding; // 0x68
	public static int ID_GradientScale; // 0x6C
	public static int ID_ScaleX; // 0x70
	public static int ID_ScaleY; // 0x74
	public static int ID_PerspectiveFilter; // 0x78
	public static int ID_Sharpness; // 0x7C
	public static int ID_TextureWidth; // 0x80
	public static int ID_TextureHeight; // 0x84
	public static int ID_BevelAmount; // 0x88
	public static int ID_GlowColor; // 0x8C
	public static int ID_GlowOffset; // 0x90
	public static int ID_GlowPower; // 0x94
	public static int ID_GlowOuter; // 0x98
	public static int ID_GlowInner; // 0x9C
	public static int ID_LightAngle; // 0xA0
	public static int ID_EnvMap; // 0xA4
	public static int ID_EnvMatrix; // 0xA8
	public static int ID_EnvMatrixRotation; // 0xAC
	public static int ID_MaskCoord; // 0xB0
	public static int ID_ClipRect; // 0xB4
	public static int ID_MaskSoftnessX; // 0xB8
	public static int ID_MaskSoftnessY; // 0xBC
	public static int ID_VertexOffsetX; // 0xC0
	public static int ID_VertexOffsetY; // 0xC4
	public static int ID_UseClipRect; // 0xC8
	public static int ID_StencilID; // 0xCC
	public static int ID_StencilOp; // 0xD0
	public static int ID_StencilComp; // 0xD4
	public static int ID_StencilReadMask; // 0xD8
	public static int ID_StencilWriteMask; // 0xDC
	public static int ID_ShaderFlags; // 0xE0
	public static int ID_ScaleRatio_A; // 0xE4
	public static int ID_ScaleRatio_B; // 0xE8
	public static int ID_ScaleRatio_C; // 0xEC
	public static string Keyword_Bevel; // 0xF0
	public static string Keyword_Glow; // 0xF8
	public static string Keyword_Underlay; // 0x100
	public static string Keyword_Ratios; // 0x108
	public static string Keyword_MASK_SOFT; // 0x110
	public static string Keyword_MASK_HARD; // 0x118
	public static string Keyword_MASK_TEX; // 0x120
	public static string Keyword_Outline; // 0x128
	public static string ShaderTag_ZTestMode; // 0x130
	public static string ShaderTag_CullMode; // 0x138
	private static float m_clamp; // 0x140
	public static bool isInitialized; // 0x144
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static readonly string k_SDFText; // 0x148
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static readonly string k_BitmapText; // 0x150
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static readonly string k_SpriteText; // 0x158
	private static Shader k_ShaderRef_MobileSDF; // 0x160
	private static Shader k_ShaderRef_MobileBitmap; // 0x168
	private static Shader k_ShaderRef_Sprite; // 0x170

	// Properties
	internal static Shader ShaderRef_MobileSDF { get; }
	internal static Shader ShaderRef_MobileBitmap { get; }
	internal static Shader ShaderRef_Sprite { get; }

	// Methods

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1ED4320 Offset: 0x1ED0320 VA: 0x1ED4320
	internal static Shader get_ShaderRef_MobileSDF() { }

	// RVA: 0x1ED43D0 Offset: 0x1ED03D0 VA: 0x1ED43D0
	internal static Shader get_ShaderRef_MobileBitmap() { }

	// RVA: 0x1ED44BC Offset: 0x1ED04BC VA: 0x1ED44BC
	internal static Shader get_ShaderRef_Sprite() { }

	// RVA: 0x1ED4628 Offset: 0x1ED0628 VA: 0x1ED4628
	private static void .cctor() { }

	// RVA: 0x1ED48C4 Offset: 0x1ED08C4 VA: 0x1ED48C4
	internal static void GetShaderPropertyIDs() { }
}

// Namespace: UnityEngine.TextCore.Text
[Extension]
internal static class TextUtilities // TypeDefIndex: 7510
{
	// Methods

	// RVA: 0x1ED5478 Offset: 0x1ED1478 VA: 0x1ED5478
	internal static char ToUpperFast(char c) { }

	// RVA: 0x1EC99A4 Offset: 0x1EC59A4 VA: 0x1EC99A4
	public static int GetHashCodeCaseInSensitive(string s) { }

	// RVA: 0x1ED54EC Offset: 0x1ED14EC VA: 0x1ED54EC
	internal static int GetTextFontWeightIndex(TextFontWeight fontWeight) { }
}

// Namespace: UnityEngine.TextCore.Text
[Serializable]
public class UnicodeLineBreakingRules // TypeDefIndex: 7511
{
	// Fields
	[SerializeField]
	private TextAsset m_UnicodeLineBreakingRules; // 0x10
	[SerializeField]
	private TextAsset m_LeadingCharacters; // 0x18
	[SerializeField]
	private TextAsset m_FollowingCharacters; // 0x20
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules; // 0x28
	private HashSet<uint> m_LeadingCharactersLookup; // 0x30
	private HashSet<uint> m_FollowingCharactersLookup; // 0x38

	// Properties
	internal HashSet<uint> leadingCharactersLookup { get; }
	internal HashSet<uint> followingCharactersLookup { get; }
	public bool useModernHangulLineBreakingRules { get; }

	// Methods

	// RVA: 0x1ED5580 Offset: 0x1ED1580 VA: 0x1ED5580
	internal HashSet<uint> get_leadingCharactersLookup() { }

	// RVA: 0x1ED57C8 Offset: 0x1ED17C8 VA: 0x1ED57C8
	internal HashSet<uint> get_followingCharactersLookup() { }

	// RVA: 0x1ED57EC Offset: 0x1ED17EC VA: 0x1ED57EC
	public bool get_useModernHangulLineBreakingRules() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1ED55A4 Offset: 0x1ED15A4 VA: 0x1ED55A4
	internal void LoadLineBreakingRules() { }

	// RVA: 0x1ED57F4 Offset: 0x1ED17F4 VA: 0x1ED57F4
	private static HashSet<uint> GetCharacters(TextAsset file) { }

	// RVA: 0x1ED58DC Offset: 0x1ED18DC VA: 0x1ED58DC
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4848 // TypeDefIndex: 7512
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5724 // TypeDefIndex: 7513
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7514
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=4848 5E4436000B53AC505FD7CB9E80FF70C5BA5B44441C00C6F0B891C673FEE1E7D2 /*Metadata offset 0x3EFC90*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5724 EC5D648DA3EF6677AD390F11A61371CC7A7A89F9355DDDACC33ADB5AE069596B /*Metadata offset 0x3F0F88*/; // 0x12F0
}

// Namespace: 
internal class <Module> // TypeDefIndex: 7515
{}

// Namespace: 
internal sealed class Locale // TypeDefIndex: 7516
{
	// Methods

	// RVA: 0x16F341C Offset: 0x16EF41C VA: 0x16F341C
	public static string GetText(string msg) { }

	// RVA: 0x16F3420 Offset: 0x16EF420 VA: 0x16F3420
	public static string GetText(string fmt, object[] args) { }
}
