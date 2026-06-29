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

// Namespace: TMPro
public class FastAction // TypeDefIndex: 5139
{
	// Fields
	private LinkedList<Action> delegates; // 0x10
	private Dictionary<Action, LinkedListNode<Action>> lookup; // 0x18

	// Methods

	// RVA: 0x1DB02D4 Offset: 0x1DAC2D4 VA: 0x1DB02D4
	public void Add(Action rhs) { }

	// RVA: 0x1DB0394 Offset: 0x1DAC394 VA: 0x1DB0394
	public void Remove(Action rhs) { }

	// RVA: 0x1DB0454 Offset: 0x1DAC454 VA: 0x1DB0454
	public void Call() { }

	// RVA: 0x1DB04EC Offset: 0x1DAC4EC VA: 0x1DB04EC
	public void .ctor() { }
}

// Namespace: TMPro
public class FastAction<A> // TypeDefIndex: 5140
{
	// Fields
	private LinkedList<Action<A>> delegates; // 0x0
	private Dictionary<Action<A>, LinkedListNode<Action<A>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1256458 Offset: 0x1252458 VA: 0x1256458
	|-FastAction<bool>.Add
	|
	|-RVA: 0x1256688 Offset: 0x1252688 VA: 0x1256688
	|-FastAction<object>.Add
	|
	|-RVA: 0x12568B8 Offset: 0x12528B8 VA: 0x12568B8
	|-FastAction<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12564E0 Offset: 0x12524E0 VA: 0x12564E0
	|-FastAction<bool>.Remove
	|
	|-RVA: 0x1256710 Offset: 0x1252710 VA: 0x1256710
	|-FastAction<object>.Remove
	|
	|-RVA: 0x1256974 Offset: 0x1252974 VA: 0x1256974
	|-FastAction<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1256568 Offset: 0x1252568 VA: 0x1256568
	|-FastAction<bool>.Call
	|
	|-RVA: 0x1256798 Offset: 0x1252798 VA: 0x1256798
	|-FastAction<object>.Call
	|
	|-RVA: 0x1256A28 Offset: 0x1252A28 VA: 0x1256A28
	|-FastAction<__Il2CppFullySharedGenericType>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12565D0 Offset: 0x12525D0 VA: 0x12565D0
	|-FastAction<bool>..ctor
	|
	|-RVA: 0x1256800 Offset: 0x1252800 VA: 0x1256800
	|-FastAction<object>..ctor
	|
	|-RVA: 0x1256B90 Offset: 0x1252B90 VA: 0x1256B90
	|-FastAction<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: TMPro
public class FastAction<A, B> // TypeDefIndex: 5141
{
	// Fields
	private LinkedList<Action<A, B>> delegates; // 0x0
	private Dictionary<Action<A, B>, LinkedListNode<Action<A, B>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1256E80 Offset: 0x1252E80 VA: 0x1256E80
	|-FastAction<bool, object>.Add
	|
	|-RVA: 0x12570C0 Offset: 0x12530C0 VA: 0x12570C0
	|-FastAction<object, object>.Add
	|
	|-RVA: 0x1257300 Offset: 0x1253300 VA: 0x1257300
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1256F08 Offset: 0x1252F08 VA: 0x1256F08
	|-FastAction<bool, object>.Remove
	|
	|-RVA: 0x1257148 Offset: 0x1253148 VA: 0x1257148
	|-FastAction<object, object>.Remove
	|
	|-RVA: 0x12573BC Offset: 0x12533BC VA: 0x12573BC
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1256F90 Offset: 0x1252F90 VA: 0x1256F90
	|-FastAction<bool, object>.Call
	|
	|-RVA: 0x12571D0 Offset: 0x12531D0 VA: 0x12571D0
	|-FastAction<object, object>.Call
	|
	|-RVA: 0x1257470 Offset: 0x1253470 VA: 0x1257470
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257008 Offset: 0x1253008 VA: 0x1257008
	|-FastAction<bool, object>..ctor
	|
	|-RVA: 0x1257248 Offset: 0x1253248 VA: 0x1257248
	|-FastAction<object, object>..ctor
	|
	|-RVA: 0x1257638 Offset: 0x1253638 VA: 0x1257638
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: TMPro
public class FastAction<A, B, C> // TypeDefIndex: 5142
{
	// Fields
	private LinkedList<Action<A, B, C>> delegates; // 0x0
	private Dictionary<Action<A, B, C>, LinkedListNode<Action<A, B, C>>> lookup; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void Add(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257AB0 Offset: 0x1253AB0 VA: 0x1257AB0
	|-FastAction<object, object, object>.Add
	|
	|-RVA: 0x1257CF8 Offset: 0x1253CF8 VA: 0x1257CF8
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(Action<A, B, C> rhs) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257B38 Offset: 0x1253B38 VA: 0x1257B38
	|-FastAction<object, object, object>.Remove
	|
	|-RVA: 0x1257DB4 Offset: 0x1253DB4 VA: 0x1257DB4
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Call(A a, B b, C c) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257BC0 Offset: 0x1253BC0 VA: 0x1257BC0
	|-FastAction<object, object, object>.Call
	|
	|-RVA: 0x1257E68 Offset: 0x1253E68 VA: 0x1257E68
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Call
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1257C40 Offset: 0x1253C40 VA: 0x1257C40
	|-FastAction<object, object, object>..ctor
	|
	|-RVA: 0x1258094 Offset: 0x1254094 VA: 0x1258094
	|-FastAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: TMPro
[Serializable]
public struct GlyphAnchorPoint // TypeDefIndex: 5143
{
	// Fields
	[SerializeField]
	private float m_XCoordinate; // 0x0
	[SerializeField]
	private float m_YCoordinate; // 0x4

	// Properties
	public float xCoordinate { get; set; }
	public float yCoordinate { get; set; }

	// Methods

	// RVA: 0x1DB05C8 Offset: 0x1DAC5C8 VA: 0x1DB05C8
	public float get_xCoordinate() { }

	// RVA: 0x1DB05D0 Offset: 0x1DAC5D0 VA: 0x1DB05D0
	public void set_xCoordinate(float value) { }

	// RVA: 0x1DB05D8 Offset: 0x1DAC5D8 VA: 0x1DB05D8
	public float get_yCoordinate() { }

	// RVA: 0x1DB05E0 Offset: 0x1DAC5E0 VA: 0x1DB05E0
	public void set_yCoordinate(float value) { }
}

// Namespace: TMPro
[Serializable]
public struct MarkPositionAdjustment // TypeDefIndex: 5144
{
	// Fields
	[SerializeField]
	private float m_XPositionAdjustment; // 0x0
	[SerializeField]
	private float m_YPositionAdjustment; // 0x4

	// Properties
	public float xPositionAdjustment { get; set; }
	public float yPositionAdjustment { get; set; }

	// Methods

	// RVA: 0x1DB05E8 Offset: 0x1DAC5E8 VA: 0x1DB05E8
	public float get_xPositionAdjustment() { }

	// RVA: 0x1DB05F0 Offset: 0x1DAC5F0 VA: 0x1DB05F0
	public void set_xPositionAdjustment(float value) { }

	// RVA: 0x1DB05F8 Offset: 0x1DAC5F8 VA: 0x1DB05F8
	public float get_yPositionAdjustment() { }

	// RVA: 0x1DB0600 Offset: 0x1DAC600 VA: 0x1DB0600
	public void set_yPositionAdjustment(float value) { }

	// RVA: 0x1DB0608 Offset: 0x1DAC608 VA: 0x1DB0608
	public void .ctor(float x, float y) { }
}

// Namespace: TMPro
[Serializable]
public struct MarkToBaseAdjustmentRecord // TypeDefIndex: 5145
{
	// Fields
	[SerializeField]
	private uint m_BaseGlyphID; // 0x0
	[SerializeField]
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; // 0x4
	[SerializeField]
	private uint m_MarkGlyphID; // 0xC
	[SerializeField]
	private MarkPositionAdjustment m_MarkPositionAdjustment; // 0x10

	// Properties
	public uint baseGlyphID { get; set; }
	public GlyphAnchorPoint baseGlyphAnchorPoint { get; set; }
	public uint markGlyphID { get; set; }
	public MarkPositionAdjustment markPositionAdjustment { get; set; }

	// Methods

	// RVA: 0x1DB0610 Offset: 0x1DAC610 VA: 0x1DB0610
	public uint get_baseGlyphID() { }

	// RVA: 0x1DB0618 Offset: 0x1DAC618 VA: 0x1DB0618
	public void set_baseGlyphID(uint value) { }

	// RVA: 0x1DB0620 Offset: 0x1DAC620 VA: 0x1DB0620
	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	// RVA: 0x1DB0628 Offset: 0x1DAC628 VA: 0x1DB0628
	public void set_baseGlyphAnchorPoint(GlyphAnchorPoint value) { }

	// RVA: 0x1DB0630 Offset: 0x1DAC630 VA: 0x1DB0630
	public uint get_markGlyphID() { }

	// RVA: 0x1DB0638 Offset: 0x1DAC638 VA: 0x1DB0638
	public void set_markGlyphID(uint value) { }

	// RVA: 0x1DB0640 Offset: 0x1DAC640 VA: 0x1DB0640
	public MarkPositionAdjustment get_markPositionAdjustment() { }

	// RVA: 0x1DB0648 Offset: 0x1DAC648 VA: 0x1DB0648
	public void set_markPositionAdjustment(MarkPositionAdjustment value) { }
}

// Namespace: TMPro
[Serializable]
public struct MarkToMarkAdjustmentRecord // TypeDefIndex: 5146
{
	// Fields
	[SerializeField]
	private uint m_BaseMarkGlyphID; // 0x0
	[SerializeField]
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; // 0x4
	[SerializeField]
	private uint m_CombiningMarkGlyphID; // 0xC
	[SerializeField]
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; // 0x10

	// Properties
	public uint baseMarkGlyphID { get; set; }
	public GlyphAnchorPoint baseMarkGlyphAnchorPoint { get; set; }
	public uint combiningMarkGlyphID { get; set; }
	public MarkPositionAdjustment combiningMarkPositionAdjustment { get; set; }

	// Methods

	// RVA: 0x1DB0650 Offset: 0x1DAC650 VA: 0x1DB0650
	public uint get_baseMarkGlyphID() { }

	// RVA: 0x1DB0658 Offset: 0x1DAC658 VA: 0x1DB0658
	public void set_baseMarkGlyphID(uint value) { }

	// RVA: 0x1DB0660 Offset: 0x1DAC660 VA: 0x1DB0660
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	// RVA: 0x1DB0668 Offset: 0x1DAC668 VA: 0x1DB0668
	public void set_baseMarkGlyphAnchorPoint(GlyphAnchorPoint value) { }

	// RVA: 0x1DB0670 Offset: 0x1DAC670 VA: 0x1DB0670
	public uint get_combiningMarkGlyphID() { }

	// RVA: 0x1DB0678 Offset: 0x1DAC678 VA: 0x1DB0678
	public void set_combiningMarkGlyphID(uint value) { }

	// RVA: 0x1DB0680 Offset: 0x1DAC680 VA: 0x1DB0680
	public MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }

	// RVA: 0x1DB0688 Offset: 0x1DAC688 VA: 0x1DB0688
	public void set_combiningMarkPositionAdjustment(MarkPositionAdjustment value) { }
}

// Namespace: TMPro
[Serializable]
public struct SingleSubstitutionRecord // TypeDefIndex: 5147
{}

// Namespace: TMPro
[Serializable]
public struct MultipleSubstitutionRecord // TypeDefIndex: 5148
{
	// Fields
	[SerializeField]
	private uint m_TargetGlyphID; // 0x0
	[SerializeField]
	private uint[] m_SubstituteGlyphIDs; // 0x8

	// Properties
	public uint targetGlyphID { get; set; }
	public uint[] substituteGlyphIDs { get; set; }

	// Methods

	// RVA: 0x1DB0690 Offset: 0x1DAC690 VA: 0x1DB0690
	public uint get_targetGlyphID() { }

	// RVA: 0x1DB0698 Offset: 0x1DAC698 VA: 0x1DB0698
	public void set_targetGlyphID(uint value) { }

	// RVA: 0x1DB06A0 Offset: 0x1DAC6A0 VA: 0x1DB06A0
	public uint[] get_substituteGlyphIDs() { }

	// RVA: 0x1DB06A8 Offset: 0x1DAC6A8 VA: 0x1DB06A8
	public void set_substituteGlyphIDs(uint[] value) { }
}

// Namespace: TMPro
[Serializable]
public struct AlternateSubstitutionRecord // TypeDefIndex: 5149
{}

// Namespace: TMPro
[Serializable]
public struct LigatureSubstitutionRecord // TypeDefIndex: 5150
{
	// Fields
	[SerializeField]
	private uint[] m_ComponentGlyphIDs; // 0x0
	[SerializeField]
	private uint m_LigatureGlyphID; // 0x8

	// Properties
	public uint[] componentGlyphIDs { get; set; }
	public uint ligatureGlyphID { get; set; }

	// Methods

	// RVA: 0x1DB06B0 Offset: 0x1DAC6B0 VA: 0x1DB06B0
	public uint[] get_componentGlyphIDs() { }

	// RVA: 0x1DB06B8 Offset: 0x1DAC6B8 VA: 0x1DB06B8
	public void set_componentGlyphIDs(uint[] value) { }

	// RVA: 0x1DB06C0 Offset: 0x1DAC6C0 VA: 0x1DB06C0
	public uint get_ligatureGlyphID() { }

	// RVA: 0x1DB06C8 Offset: 0x1DAC6C8 VA: 0x1DB06C8
	public void set_ligatureGlyphID(uint value) { }

	// RVA: 0x1DB06D0 Offset: 0x1DAC6D0 VA: 0x1DB06D0
	public static bool op_Equality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }

	// RVA: 0x1DB0740 Offset: 0x1DAC740 VA: 0x1DB0740
	public static bool op_Inequality(LigatureSubstitutionRecord lhs, LigatureSubstitutionRecord rhs) { }
}

// Namespace: TMPro
public interface ITextPreprocessor // TypeDefIndex: 5151
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string PreprocessText(string text);
}

// Namespace: TMPro
public class MaterialReferenceManager // TypeDefIndex: 5152
{
	// Fields
	private static MaterialReferenceManager s_Instance; // 0x0
	private Dictionary<int, Material> m_FontMaterialReferenceLookup; // 0x10
	private Dictionary<int, TMP_FontAsset> m_FontAssetReferenceLookup; // 0x18
	private Dictionary<int, TMP_SpriteAsset> m_SpriteAssetReferenceLookup; // 0x20
	private Dictionary<int, TMP_ColorGradient> m_ColorGradientReferenceLookup; // 0x28

	// Properties
	public static MaterialReferenceManager instance { get; }

	// Methods

	// RVA: 0x1DB0758 Offset: 0x1DAC758 VA: 0x1DB0758
	public static MaterialReferenceManager get_instance() { }

	// RVA: 0x1DB0960 Offset: 0x1DAC960 VA: 0x1DB0960
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x1DB0980 Offset: 0x1DAC980 VA: 0x1DB0980
	private void AddFontAssetInternal(TMP_FontAsset fontAsset) { }

	// RVA: 0x1DB0BAC Offset: 0x1DACBAC VA: 0x1DB0BAC
	public static void AddSpriteAsset(TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x1DB0BCC Offset: 0x1DACBCC VA: 0x1DB0BCC
	private void AddSpriteAssetInternal(TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x1DB0CB4 Offset: 0x1DACCB4 VA: 0x1DB0CB4
	public static void AddSpriteAsset(int hashCode, TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x1DB0CE4 Offset: 0x1DACCE4 VA: 0x1DB0CE4
	private void AddSpriteAssetInternal(int hashCode, TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x1DB0DBC Offset: 0x1DACDBC VA: 0x1DB0DBC
	public static void AddFontMaterial(int hashCode, Material material) { }

	// RVA: 0x1DB0DEC Offset: 0x1DACDEC VA: 0x1DB0DEC
	private void AddFontMaterialInternal(int hashCode, Material material) { }

	// RVA: 0x1DB0E54 Offset: 0x1DACE54 VA: 0x1DB0E54
	public static void AddColorGradientPreset(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0x1DB0E84 Offset: 0x1DACE84 VA: 0x1DB0E84
	private void AddColorGradientPreset_Internal(int hashCode, TMP_ColorGradient spriteAsset) { }

	// RVA: 0x1DB0F28 Offset: 0x1DACF28 VA: 0x1DB0F28
	public bool Contains(TMP_FontAsset font) { }

	// RVA: 0x1DB0F90 Offset: 0x1DACF90 VA: 0x1DB0F90
	public bool Contains(TMP_SpriteAsset sprite) { }

	// RVA: 0x1DB0FF8 Offset: 0x1DACFF8 VA: 0x1DB0FF8
	public static bool TryGetFontAsset(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x1DB1028 Offset: 0x1DAD028 VA: 0x1DB1028
	private bool TryGetFontAssetInternal(int hashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x1DB10A0 Offset: 0x1DAD0A0 VA: 0x1DB10A0
	public static bool TryGetSpriteAsset(int hashCode, out TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x1DB10D0 Offset: 0x1DAD0D0 VA: 0x1DB10D0
	private bool TryGetSpriteAssetInternal(int hashCode, out TMP_SpriteAsset spriteAsset) { }

	// RVA: 0x1DB1148 Offset: 0x1DAD148 VA: 0x1DB1148
	public static bool TryGetColorGradientPreset(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0x1DB1178 Offset: 0x1DAD178 VA: 0x1DB1178
	private bool TryGetColorGradientPresetInternal(int hashCode, out TMP_ColorGradient gradientPreset) { }

	// RVA: 0x1DB11F0 Offset: 0x1DAD1F0 VA: 0x1DB11F0
	public static bool TryGetMaterial(int hashCode, out Material material) { }

	// RVA: 0x1DB1220 Offset: 0x1DAD220 VA: 0x1DB1220
	private bool TryGetMaterialInternal(int hashCode, out Material material) { }

	// RVA: 0x1DB07DC Offset: 0x1DAC7DC VA: 0x1DB07DC
	public void .ctor() { }
}

// Namespace: TMPro
public struct TMP_MaterialReference // TypeDefIndex: 5153
{
	// Fields
	public Material material; // 0x0
	public int referenceCount; // 0x8
}

// Namespace: TMPro
public struct MaterialReference // TypeDefIndex: 5154
{
	// Fields
	public int index; // 0x0
	public TMP_FontAsset fontAsset; // 0x8
	public TMP_SpriteAsset spriteAsset; // 0x10
	public Material material; // 0x18
	public bool isDefaultMaterial; // 0x20
	public bool isFallbackMaterial; // 0x21
	public Material fallbackMaterial; // 0x28
	public float padding; // 0x30
	public int referenceCount; // 0x34

	// Methods

	// RVA: 0x1DB1298 Offset: 0x1DAD298 VA: 0x1DB1298
	public void .ctor(int index, TMP_FontAsset fontAsset, TMP_SpriteAsset spriteAsset, Material material, float padding) { }

	// RVA: 0x1DB1354 Offset: 0x1DAD354 VA: 0x1DB1354
	public static bool Contains(MaterialReference[] materialReferences, TMP_FontAsset fontAsset) { }

	// RVA: 0x1DB145C Offset: 0x1DAD45C VA: 0x1DB145C
	public static int AddMaterialReference(Material material, TMP_FontAsset fontAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }

	// RVA: 0x1DB1698 Offset: 0x1DAD698 VA: 0x1DB1698
	public static int AddMaterialReference(Material material, TMP_SpriteAsset spriteAsset, ref MaterialReference[] materialReferences, Dictionary<int, int> materialReferenceIndexLookup) { }
}

// Namespace: TMPro
[Serializable]
public abstract class TMP_Asset : ScriptableObject // TypeDefIndex: 5155
{
	// Fields
	[SerializeField]
	internal string m_Version; // 0x18
	internal int m_InstanceID; // 0x20
	internal int m_HashCode; // 0x24
	[SerializeField]
	internal FaceInfo m_FaceInfo; // 0x28
	[SerializeField]
	[FormerlySerializedAs("material")]
	internal Material m_Material; // 0x88
	internal int m_MaterialHashCode; // 0x90

	// Properties
	public string version { get; set; }
	public int instanceID { get; }
	public int hashCode { get; set; }
	public FaceInfo faceInfo { get; set; }
	public Material material { get; set; }
	public int materialHashCode { get; set; }

	// Methods

	// RVA: 0x1DB18A0 Offset: 0x1DAD8A0 VA: 0x1DB18A0
	public string get_version() { }

	// RVA: 0x1DB18A8 Offset: 0x1DAD8A8 VA: 0x1DB18A8
	internal void set_version(string value) { }

	// RVA: 0x1DB18B0 Offset: 0x1DAD8B0 VA: 0x1DB18B0
	public int get_instanceID() { }

	// RVA: 0x1DB0A68 Offset: 0x1DACA68 VA: 0x1DB0A68
	public int get_hashCode() { }

	// RVA: 0x1DB18D8 Offset: 0x1DAD8D8 VA: 0x1DB18D8
	public void set_hashCode(int value) { }

	// RVA: 0x1DB18E0 Offset: 0x1DAD8E0 VA: 0x1DB18E0
	public FaceInfo get_faceInfo() { }

	// RVA: 0x1DB18F0 Offset: 0x1DAD8F0 VA: 0x1DB18F0
	public void set_faceInfo(FaceInfo value) { }

	// RVA: 0x1DB1914 Offset: 0x1DAD914 VA: 0x1DB1914
	public Material get_material() { }

	// RVA: 0x1DB191C Offset: 0x1DAD91C VA: 0x1DB191C
	public void set_material(Material value) { }

	// RVA: 0x1DB0AE4 Offset: 0x1DACAE4 VA: 0x1DB0AE4
	public int get_materialHashCode() { }

	// RVA: 0x1DB1924 Offset: 0x1DAD924 VA: 0x1DB1924
	public void set_materialHashCode(int value) { }

	// RVA: 0x1DB192C Offset: 0x1DAD92C VA: 0x1DB192C
	protected void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Character : TMP_TextElement // TypeDefIndex: 5156
{
	// Methods

	// RVA: 0x1DB1934 Offset: 0x1DAD934 VA: 0x1DB1934
	public void .ctor() { }

	// RVA: 0x1DB195C Offset: 0x1DAD95C VA: 0x1DB195C
	public void .ctor(uint unicode, Glyph glyph) { }

	// RVA: 0x1DB19CC Offset: 0x1DAD9CC VA: 0x1DB19CC
	public void .ctor(uint unicode, TMP_FontAsset fontAsset, Glyph glyph) { }

	// RVA: 0x1DB1A48 Offset: 0x1DADA48 VA: 0x1DB1A48
	internal void .ctor(uint unicode, uint glyphIndex) { }
}

// Namespace: TMPro
public struct TMP_Vertex // TypeDefIndex: 5157
{
	// Fields
	public Vector3 position; // 0x0
	public Vector4 uv; // 0xC
	public Vector2 uv2; // 0x1C
	public Color32 color; // 0x24
	private static readonly TMP_Vertex k_Zero; // 0x0

	// Properties
	public static TMP_Vertex zero { get; }

	// Methods

	// RVA: 0x1DB1AA4 Offset: 0x1DADAA4 VA: 0x1DB1AA4
	public static TMP_Vertex get_zero() { }

	// RVA: 0x1DB1B0C Offset: 0x1DADB0C VA: 0x1DB1B0C
	private static void .cctor() { }
}

// Namespace: TMPro
public struct TMP_Offset // TypeDefIndex: 5158
{
	// Fields
	private float m_Left; // 0x0
	private float m_Right; // 0x4
	private float m_Top; // 0x8
	private float m_Bottom; // 0xC
	private static readonly TMP_Offset k_ZeroOffset; // 0x0

	// Properties
	public float left { get; set; }
	public float right { get; set; }
	public float top { get; set; }
	public float bottom { get; set; }
	public float horizontal { get; set; }
	public float vertical { get; set; }
	public static TMP_Offset zero { get; }

	// Methods

	// RVA: 0x1DB1B10 Offset: 0x1DADB10 VA: 0x1DB1B10
	public float get_left() { }

	// RVA: 0x1DB1B18 Offset: 0x1DADB18 VA: 0x1DB1B18
	public void set_left(float value) { }

	// RVA: 0x1DB1B20 Offset: 0x1DADB20 VA: 0x1DB1B20
	public float get_right() { }

	// RVA: 0x1DB1B28 Offset: 0x1DADB28 VA: 0x1DB1B28
	public void set_right(float value) { }

	// RVA: 0x1DB1B30 Offset: 0x1DADB30 VA: 0x1DB1B30
	public float get_top() { }

	// RVA: 0x1DB1B38 Offset: 0x1DADB38 VA: 0x1DB1B38
	public void set_top(float value) { }

	// RVA: 0x1DB1B40 Offset: 0x1DADB40 VA: 0x1DB1B40
	public float get_bottom() { }

	// RVA: 0x1DB1B48 Offset: 0x1DADB48 VA: 0x1DB1B48
	public void set_bottom(float value) { }

	// RVA: 0x1DB1B50 Offset: 0x1DADB50 VA: 0x1DB1B50
	public float get_horizontal() { }

	// RVA: 0x1DB1B58 Offset: 0x1DADB58 VA: 0x1DB1B58
	public void set_horizontal(float value) { }

	// RVA: 0x1DB1B60 Offset: 0x1DADB60 VA: 0x1DB1B60
	public float get_vertical() { }

	// RVA: 0x1DB1B68 Offset: 0x1DADB68 VA: 0x1DB1B68
	public void set_vertical(float value) { }

	// RVA: 0x1DB1B70 Offset: 0x1DADB70 VA: 0x1DB1B70
	public static TMP_Offset get_zero() { }

	// RVA: 0x1DB1BCC Offset: 0x1DADBCC VA: 0x1DB1BCC
	public void .ctor(float left, float right, float top, float bottom) { }

	// RVA: 0x1DB1BD8 Offset: 0x1DADBD8 VA: 0x1DB1BD8
	public void .ctor(float horizontal, float vertical) { }

	// RVA: 0x1DB1BE4 Offset: 0x1DADBE4 VA: 0x1DB1BE4
	public static bool op_Equality(TMP_Offset lhs, TMP_Offset rhs) { }

	// RVA: 0x1DB1C0C Offset: 0x1DADC0C VA: 0x1DB1C0C
	public static bool op_Inequality(TMP_Offset lhs, TMP_Offset rhs) { }

	// RVA: 0x1DB1CBC Offset: 0x1DADCBC VA: 0x1DB1CBC
	public static TMP_Offset op_Multiply(TMP_Offset a, float b) { }

	// RVA: 0x1DB1CD0 Offset: 0x1DADCD0 VA: 0x1DB1CD0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1DB1D34 Offset: 0x1DADD34 VA: 0x1DB1D34 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1DB1DAC Offset: 0x1DADDAC VA: 0x1DB1DAC
	public bool Equals(TMP_Offset other) { }

	// RVA: 0x1DB1E54 Offset: 0x1DADE54 VA: 0x1DB1E54
	private static void .cctor() { }
}

// Namespace: TMPro
public struct HighlightState // TypeDefIndex: 5159
{
	// Fields
	public Color32 color; // 0x0
	public TMP_Offset padding; // 0x4

	// Methods

	// RVA: 0x1DB1E9C Offset: 0x1DADE9C VA: 0x1DB1E9C
	public void .ctor(Color32 color, TMP_Offset padding) { }

	// RVA: 0x1DB1EAC Offset: 0x1DADEAC VA: 0x1DB1EAC
	public static bool op_Equality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x1DB1F50 Offset: 0x1DADF50 VA: 0x1DB1F50
	public static bool op_Inequality(HighlightState lhs, HighlightState rhs) { }

	// RVA: 0x1DB1F98 Offset: 0x1DADF98 VA: 0x1DB1F98 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1DB2004 Offset: 0x1DAE004 VA: 0x1DB2004 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1DB2084 Offset: 0x1DAE084 VA: 0x1DB2084
	public bool Equals(HighlightState other) { }
}

// Namespace: TMPro
[DebuggerDisplay("Unicode '{character}'  ({((uint)character).ToString("X")})")]
public struct TMP_CharacterInfo // TypeDefIndex: 5160
{
	// Fields
	public TMP_TextElementType elementType; // 0x0
	public char character; // 0x4
	public int index; // 0x8
	public int stringLength; // 0xC
	public TMP_TextElement textElement; // 0x10
	public Glyph alternativeGlyph; // 0x18
	public TMP_FontAsset fontAsset; // 0x20
	public Material material; // 0x28
	public int materialReferenceIndex; // 0x30
	public bool isUsingAlternateTypeface; // 0x34
	public float pointSize; // 0x38
	public int lineNumber; // 0x3C
	public int pageNumber; // 0x40
	public int vertexIndex; // 0x44
	public TMP_Vertex vertex_BL; // 0x48
	public TMP_Vertex vertex_TL; // 0x70
	public TMP_Vertex vertex_TR; // 0x98
	public TMP_Vertex vertex_BR; // 0xC0
	public Vector3 topLeft; // 0xE8
	public Vector3 bottomLeft; // 0xF4
	public Vector3 topRight; // 0x100
	public Vector3 bottomRight; // 0x10C
	public float origin; // 0x118
	public float xAdvance; // 0x11C
	public float ascender; // 0x120
	public float baseLine; // 0x124
	public float descender; // 0x128
	internal float adjustedAscender; // 0x12C
	internal float adjustedDescender; // 0x130
	internal float adjustedHorizontalAdvance; // 0x134
	public float aspectRatio; // 0x138
	public float scale; // 0x13C
	public Color32 color; // 0x140
	public Color32 underlineColor; // 0x144
	public int underlineVertexIndex; // 0x148
	public Color32 strikethroughColor; // 0x14C
	public int strikethroughVertexIndex; // 0x150
	public Color32 highlightColor; // 0x154
	public HighlightState highlightState; // 0x158
	public FontStyles style; // 0x16C
	public bool isVisible; // 0x170
}

// Namespace: TMPro
public enum ColorMode // TypeDefIndex: 5161
{
	// Fields
	public int value__; // 0x0
	public const ColorMode Single = 0;
	public const ColorMode HorizontalGradient = 1;
	public const ColorMode VerticalGradient = 2;
	public const ColorMode FourCornersGradient = 3;
}

// Namespace: TMPro
[ExcludeFromPreset]
[Serializable]
public class TMP_ColorGradient : ScriptableObject // TypeDefIndex: 5162
{
	// Fields
	public ColorMode colorMode; // 0x18
	public Color topLeft; // 0x1C
	public Color topRight; // 0x2C
	public Color bottomLeft; // 0x3C
	public Color bottomRight; // 0x4C
	private const ColorMode k_DefaultColorMode = 3;
	private static readonly Color k_DefaultColor; // 0x0

	// Methods

	// RVA: 0x1DB2128 Offset: 0x1DAE128 VA: 0x1DB2128
	public void .ctor() { }

	// RVA: 0x1DB21C4 Offset: 0x1DAE1C4 VA: 0x1DB21C4
	public void .ctor(Color color) { }

	// RVA: 0x1DB2230 Offset: 0x1DAE230 VA: 0x1DB2230
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }

	// RVA: 0x1DB22D4 Offset: 0x1DAE2D4 VA: 0x1DB22D4
	private static void .cctor() { }
}

// Namespace: 
public enum TMP_Compatibility.AnchorPositions // TypeDefIndex: 5163
{
	// Fields
	public int value__; // 0x0
	public const TMP_Compatibility.AnchorPositions TopLeft = 0;
	public const TMP_Compatibility.AnchorPositions Top = 1;
	public const TMP_Compatibility.AnchorPositions TopRight = 2;
	public const TMP_Compatibility.AnchorPositions Left = 3;
	public const TMP_Compatibility.AnchorPositions Center = 4;
	public const TMP_Compatibility.AnchorPositions Right = 5;
	public const TMP_Compatibility.AnchorPositions BottomLeft = 6;
	public const TMP_Compatibility.AnchorPositions Bottom = 7;
	public const TMP_Compatibility.AnchorPositions BottomRight = 8;
	public const TMP_Compatibility.AnchorPositions BaseLine = 9;
	public const TMP_Compatibility.AnchorPositions None = 10;
}

// Namespace: TMPro
public static class TMP_Compatibility // TypeDefIndex: 5164
{
	// Methods

	// RVA: 0x1DB2320 Offset: 0x1DAE320 VA: 0x1DB2320
	public static TextAlignmentOptions ConvertTextAlignmentEnumValues(TextAlignmentOptions oldValue) { }
}

// Namespace: TMPro
internal interface ITweenValue // TypeDefIndex: 5165
{
	// Properties
	public abstract bool ignoreTimeScale { get; }
	public abstract float duration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TweenValue(float floatPercentage);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_ignoreTimeScale();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_duration();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool ValidTarget();
}

// Namespace: 
public enum ColorTween.ColorTweenMode // TypeDefIndex: 5166
{
	// Fields
	public int value__; // 0x0
	public const ColorTween.ColorTweenMode All = 0;
	public const ColorTween.ColorTweenMode RGB = 1;
	public const ColorTween.ColorTweenMode Alpha = 2;
}

// Namespace: 
public class ColorTween.ColorTweenCallback : UnityEvent<Color> // TypeDefIndex: 5167
{
	// Methods

	// RVA: 0x1DB2520 Offset: 0x1DAE520 VA: 0x1DB2520
	public void .ctor() { }
}

// Namespace: TMPro
internal struct ColorTween : ITweenValue // TypeDefIndex: 5168
{
	// Fields
	private ColorTween.ColorTweenCallback m_Target; // 0x0
	private Color m_StartColor; // 0x8
	private Color m_TargetColor; // 0x18
	private ColorTween.ColorTweenMode m_TweenMode; // 0x28
	private float m_Duration; // 0x2C
	private bool m_IgnoreTimeScale; // 0x30

	// Properties
	public Color startColor { get; set; }
	public Color targetColor { get; set; }
	public ColorTween.ColorTweenMode tweenMode { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x1DB2344 Offset: 0x1DAE344 VA: 0x1DB2344
	public Color get_startColor() { }

	// RVA: 0x1DB2350 Offset: 0x1DAE350 VA: 0x1DB2350
	public void set_startColor(Color value) { }

	// RVA: 0x1DB235C Offset: 0x1DAE35C VA: 0x1DB235C
	public Color get_targetColor() { }

	// RVA: 0x1DB2368 Offset: 0x1DAE368 VA: 0x1DB2368
	public void set_targetColor(Color value) { }

	// RVA: 0x1DB2374 Offset: 0x1DAE374 VA: 0x1DB2374
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0x1DB237C Offset: 0x1DAE37C VA: 0x1DB237C
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x1DB2384 Offset: 0x1DAE384 VA: 0x1DB2384 Slot: 6
	public float get_duration() { }

	// RVA: 0x1DB238C Offset: 0x1DAE38C VA: 0x1DB238C
	public void set_duration(float value) { }

	// RVA: 0x1DB2394 Offset: 0x1DAE394 VA: 0x1DB2394 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x1DB239C Offset: 0x1DAE39C VA: 0x1DB239C
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x1DB23A4 Offset: 0x1DAE3A4 VA: 0x1DB23A4 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x1DB248C Offset: 0x1DAE48C VA: 0x1DB248C
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x1DB2568 Offset: 0x1DAE568 VA: 0x1DB2568
	public bool GetIgnoreTimescale() { }

	// RVA: 0x1DB2570 Offset: 0x1DAE570 VA: 0x1DB2570
	public float GetDuration() { }

	// RVA: 0x1DB247C Offset: 0x1DAE47C VA: 0x1DB247C Slot: 7
	public bool ValidTarget() { }
}

// Namespace: 
public class FloatTween.FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 5169
{
	// Methods

	// RVA: 0x1DB26EC Offset: 0x1DAE6EC VA: 0x1DB26EC
	public void .ctor() { }
}

// Namespace: TMPro
internal struct FloatTween : ITweenValue // TypeDefIndex: 5170
{
	// Fields
	private FloatTween.FloatTweenCallback m_Target; // 0x0
	private float m_StartValue; // 0x8
	private float m_TargetValue; // 0xC
	private float m_Duration; // 0x10
	private bool m_IgnoreTimeScale; // 0x14

	// Properties
	public float startValue { get; set; }
	public float targetValue { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x1DB2578 Offset: 0x1DAE578 VA: 0x1DB2578
	public float get_startValue() { }

	// RVA: 0x1DB2580 Offset: 0x1DAE580 VA: 0x1DB2580
	public void set_startValue(float value) { }

	// RVA: 0x1DB2588 Offset: 0x1DAE588 VA: 0x1DB2588
	public float get_targetValue() { }

	// RVA: 0x1DB2590 Offset: 0x1DAE590 VA: 0x1DB2590
	public void set_targetValue(float value) { }

	// RVA: 0x1DB2598 Offset: 0x1DAE598 VA: 0x1DB2598 Slot: 6
	public float get_duration() { }

	// RVA: 0x1DB25A0 Offset: 0x1DAE5A0 VA: 0x1DB25A0
	public void set_duration(float value) { }

	// RVA: 0x1DB25A8 Offset: 0x1DAE5A8 VA: 0x1DB25A8 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x1DB25B0 Offset: 0x1DAE5B0 VA: 0x1DB25B0
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x1DB25B8 Offset: 0x1DAE5B8 VA: 0x1DB25B8 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x1DB2658 Offset: 0x1DAE658 VA: 0x1DB2658
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0x1DB2734 Offset: 0x1DAE734 VA: 0x1DB2734
	public bool GetIgnoreTimescale() { }

	// RVA: 0x1DB273C Offset: 0x1DAE73C VA: 0x1DB273C
	public float GetDuration() { }

	// RVA: 0x1DB2648 Offset: 0x1DAE648 VA: 0x1DB2648 Slot: 7
	public bool ValidTarget() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TweenRunner.<Start>d__2<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5171
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public T tweenInfo; // 0x0
	private float <elapsedTime>5__2; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116E1C0 Offset: 0x116A1C0 VA: 0x116E1C0
	|-TweenRunner.<Start>d__2<FloatTween>..ctor
	|
	|-RVA: 0x116E4B0 Offset: 0x116A4B0 VA: 0x116E4B0
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116E1E8 Offset: 0x116A1E8 VA: 0x116E1E8
	|-TweenRunner.<Start>d__2<FloatTween>.System.IDisposable.Dispose
	|
	|-RVA: 0x116E4F0 Offset: 0x116A4F0 VA: 0x116E4F0
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116E1EC Offset: 0x116A1EC VA: 0x116E1EC
	|-TweenRunner.<Start>d__2<FloatTween>.MoveNext
	|
	|-RVA: 0x116E4F4 Offset: 0x116A4F4 VA: 0x116E4F4
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116E2F4 Offset: 0x116A2F4 VA: 0x116E2F4
	|-TweenRunner.<Start>d__2<FloatTween>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	|
	|-RVA: 0x116EB30 Offset: 0x116AB30 VA: 0x116EB30
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116E2FC Offset: 0x116A2FC VA: 0x116E2FC
	|-TweenRunner.<Start>d__2<FloatTween>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x116EB58 Offset: 0x116AB58 VA: 0x116EB58
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116E330 Offset: 0x116A330 VA: 0x116E330
	|-TweenRunner.<Start>d__2<FloatTween>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x116EB8C Offset: 0x116AB8C VA: 0x116EB8C
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: TMPro
internal class TweenRunner<T> // TypeDefIndex: 5172
{
	// Fields
	protected MonoBehaviour m_CoroutineContainer; // 0x0
	protected IEnumerator m_Tween; // 0x0

	// Methods

	[IteratorStateMachine(typeof(TweenRunner.<Start>d__2<T>))]
	// RVA: -1 Offset: -1
	private static IEnumerator Start(T tweenInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14911B8 Offset: 0x148D1B8 VA: 0x14911B8
	|-TweenRunner<FloatTween>.Start
	|
	|-RVA: 0x1491424 Offset: 0x148D424 VA: 0x1491424
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.Start
	*/

	// RVA: -1 Offset: -1
	public void Init(MonoBehaviour coroutineContainer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1491268 Offset: 0x148D268 VA: 0x1491268
	|-TweenRunner<FloatTween>.Init
	|
	|-RVA: 0x14915BC Offset: 0x148D5BC VA: 0x14915BC
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.Init
	*/

	// RVA: -1 Offset: -1
	public void StartTween(T info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1491270 Offset: 0x148D270 VA: 0x1491270
	|-TweenRunner<FloatTween>.StartTween
	|
	|-RVA: 0x14915C4 Offset: 0x148D5C4 VA: 0x14915C4
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.StartTween
	*/

	// RVA: -1 Offset: -1
	public void StopTween() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14913DC Offset: 0x148D3DC VA: 0x14913DC
	|-TweenRunner<FloatTween>.StopTween
	|
	|-RVA: 0x1491844 Offset: 0x148D844 VA: 0x1491844
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.StopTween
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149141C Offset: 0x148D41C VA: 0x149141C
	|-TweenRunner<FloatTween>..ctor
	|
	|-RVA: 0x1491884 Offset: 0x148D884 VA: 0x1491884
	|-TweenRunner<__Il2CppFullySharedGenericStructType>..ctor
	*/
}

// Namespace: 
public struct TMP_DefaultControls.Resources // TypeDefIndex: 5173
{
	// Fields
	public Sprite standard; // 0x0
	public Sprite background; // 0x8
	public Sprite inputField; // 0x10
	public Sprite knob; // 0x18
	public Sprite checkmark; // 0x20
	public Sprite dropdown; // 0x28
	public Sprite mask; // 0x30
}

// Namespace: TMPro
public static class TMP_DefaultControls // TypeDefIndex: 5174
{
	// Fields
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_TextElementSize; // 0x0
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Color s_DefaultSelectableColor; // 0x18
	private static Color s_TextColor; // 0x28

	// Methods

	// RVA: 0x1DB2744 Offset: 0x1DAE744 VA: 0x1DB2744
	private static GameObject CreateUIElementRoot(string name, Vector2 size) { }

	// RVA: 0x1DB27EC Offset: 0x1DAE7EC VA: 0x1DB27EC
	private static GameObject CreateUIObject(string name, GameObject parent) { }

	// RVA: 0x1DB29AC Offset: 0x1DAE9AC VA: 0x1DB29AC
	private static void SetDefaultTextValues(TMP_Text lbl) { }

	// RVA: 0x1DB2A34 Offset: 0x1DAEA34 VA: 0x1DB2A34
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x1DB28AC Offset: 0x1DAE8AC VA: 0x1DB28AC
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x1DB2A94 Offset: 0x1DAEA94 VA: 0x1DB2A94
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x1DB2B78 Offset: 0x1DAEB78 VA: 0x1DB2B78
	public static GameObject CreateScrollbar(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x1DB2E40 Offset: 0x1DAEE40 VA: 0x1DB2E40
	public static GameObject CreateButton(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x1DB3104 Offset: 0x1DAF104 VA: 0x1DB3104
	public static GameObject CreateText(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x1DB31A4 Offset: 0x1DAF1A4 VA: 0x1DB31A4
	public static GameObject CreateInputField(TMP_DefaultControls.Resources resources) { }

	// RVA: 0x1DB3804 Offset: 0x1DAF804 VA: 0x1DB3804
	public static GameObject CreateDropdown(TMP_DefaultControls.Resources resources) { }

	// RVA: -1 Offset: -1
	private static T AddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114DDC8 Offset: 0x1149DC8 VA: 0x114DDC8
	|-TMP_DefaultControls.AddComponent<object>
	*/

	// RVA: 0x1DB4B60 Offset: 0x1DB0B60 VA: 0x1DB4B60
	private static void .cctor() { }
}

// Namespace: 
protected internal class TMP_Dropdown.DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler // TypeDefIndex: 5175
{
	// Fields
	[SerializeField]
	private TMP_Text m_Text; // 0x20
	[SerializeField]
	private Image m_Image; // 0x28
	[SerializeField]
	private RectTransform m_RectTransform; // 0x30
	[SerializeField]
	private Toggle m_Toggle; // 0x38

	// Properties
	public TMP_Text text { get; set; }
	public Image image { get; set; }
	public RectTransform rectTransform { get; set; }
	public Toggle toggle { get; set; }

	// Methods

	// RVA: 0x1DB8608 Offset: 0x1DB4608 VA: 0x1DB8608
	public TMP_Text get_text() { }

	// RVA: 0x1DB8610 Offset: 0x1DB4610 VA: 0x1DB8610
	public void set_text(TMP_Text value) { }

	// RVA: 0x1DB8618 Offset: 0x1DB4618 VA: 0x1DB8618
	public Image get_image() { }

	// RVA: 0x1DB8620 Offset: 0x1DB4620 VA: 0x1DB8620
	public void set_image(Image value) { }

	// RVA: 0x1DB8628 Offset: 0x1DB4628 VA: 0x1DB8628
	public RectTransform get_rectTransform() { }

	// RVA: 0x1DB8630 Offset: 0x1DB4630 VA: 0x1DB8630
	public void set_rectTransform(RectTransform value) { }

	// RVA: 0x1DB8638 Offset: 0x1DB4638 VA: 0x1DB8638
	public Toggle get_toggle() { }

	// RVA: 0x1DB8640 Offset: 0x1DB4640 VA: 0x1DB8640
	public void set_toggle(Toggle value) { }

	// RVA: 0x1DB8648 Offset: 0x1DB4648 VA: 0x1DB8648 Slot: 6
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1DB86C4 Offset: 0x1DB46C4 VA: 0x1DB86C4 Slot: 7
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1DB8770 Offset: 0x1DB4770 VA: 0x1DB8770
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_Dropdown.OptionData // TypeDefIndex: 5176
{
	// Fields
	[SerializeField]
	private string m_Text; // 0x10
	[SerializeField]
	private Sprite m_Image; // 0x18
	[SerializeField]
	private Color m_Color; // 0x20

	// Properties
	public string text { get; set; }
	public Sprite image { get; set; }
	public Color color { get; set; }

	// Methods

	// RVA: 0x1DB8778 Offset: 0x1DB4778 VA: 0x1DB8778
	public string get_text() { }

	// RVA: 0x1DB8780 Offset: 0x1DB4780 VA: 0x1DB8780
	public void set_text(string value) { }

	// RVA: 0x1DB8788 Offset: 0x1DB4788 VA: 0x1DB8788
	public Sprite get_image() { }

	// RVA: 0x1DB8790 Offset: 0x1DB4790 VA: 0x1DB8790
	public void set_image(Sprite value) { }

	// RVA: 0x1DB8798 Offset: 0x1DB4798 VA: 0x1DB8798
	public Color get_color() { }

	// RVA: 0x1DB87A4 Offset: 0x1DB47A4 VA: 0x1DB87A4
	public void set_color(Color value) { }

	// RVA: 0x1DB46BC Offset: 0x1DB06BC VA: 0x1DB46BC
	public void .ctor() { }

	// RVA: 0x1DB57FC Offset: 0x1DB17FC VA: 0x1DB57FC
	public void .ctor(string text) { }

	// RVA: 0x1DB59B0 Offset: 0x1DB19B0 VA: 0x1DB59B0
	public void .ctor(Sprite image) { }

	// RVA: 0x1DB87B0 Offset: 0x1DB47B0 VA: 0x1DB87B0
	public void .ctor(string text, Sprite image, Color color) { }
}

// Namespace: 
[Serializable]
public class TMP_Dropdown.OptionDataList // TypeDefIndex: 5177
{
	// Fields
	[SerializeField]
	private List<TMP_Dropdown.OptionData> m_Options; // 0x10

	// Properties
	public List<TMP_Dropdown.OptionData> options { get; set; }

	// Methods

	// RVA: 0x1DB8830 Offset: 0x1DB4830 VA: 0x1DB8830
	public List<TMP_Dropdown.OptionData> get_options() { }

	// RVA: 0x1DB8838 Offset: 0x1DB4838 VA: 0x1DB8838
	public void set_options(List<TMP_Dropdown.OptionData> value) { }

	// RVA: 0x1DB4FF0 Offset: 0x1DB0FF0 VA: 0x1DB4FF0
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_Dropdown.DropdownEvent : UnityEvent<int> // TypeDefIndex: 5178
{
	// Methods

	// RVA: 0x1DB5078 Offset: 0x1DB1078 VA: 0x1DB5078
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_Dropdown.<>c__DisplayClass76_0 // TypeDefIndex: 5179
{
	// Fields
	public Toggle nothingToggle; // 0x10
	public Toggle everythingToggle; // 0x18
	public TMP_Dropdown <>4__this; // 0x20

	// Methods

	// RVA: 0x1DB7370 Offset: 0x1DB3370 VA: 0x1DB7370
	public void .ctor() { }

	// RVA: 0x1DB8840 Offset: 0x1DB4840 VA: 0x1DB8840
	internal void <Show>b__0(bool x) { }

	// RVA: 0x1DB885C Offset: 0x1DB485C VA: 0x1DB885C
	internal void <Show>b__1(bool x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_Dropdown.<>c__DisplayClass76_1 // TypeDefIndex: 5180
{
	// Fields
	public TMP_Dropdown.DropdownItem item; // 0x10
	public TMP_Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x1DB76A0 Offset: 0x1DB36A0 VA: 0x1DB76A0
	public void .ctor() { }

	// RVA: 0x1DB8878 Offset: 0x1DB4878 VA: 0x1DB8878
	internal void <Show>b__2(bool x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_Dropdown.<DelayedDestroyDropdownList>d__90 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5181
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float delay; // 0x20
	public TMP_Dropdown <>4__this; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1DB8094 Offset: 0x1DB4094 VA: 0x1DB8094
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1DB889C Offset: 0x1DB489C VA: 0x1DB889C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1DB88A0 Offset: 0x1DB48A0 VA: 0x1DB88A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DB8958 Offset: 0x1DB4958 VA: 0x1DB8958 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1DB8960 Offset: 0x1DB4960 VA: 0x1DB8960 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1DB8998 Offset: 0x1DB4998 VA: 0x1DB8998 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: TMPro
[AddComponentMenu("UI/Dropdown - TextMeshPro", 35)]
[RequireComponent(typeof(RectTransform))]
public class TMP_Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 5182
{
	// Fields
	private static readonly TMP_Dropdown.OptionData k_NothingOption; // 0x0
	private static readonly TMP_Dropdown.OptionData k_EverythingOption; // 0x8
	private static readonly TMP_Dropdown.OptionData k_MixedOption; // 0x10
	[SerializeField]
	private RectTransform m_Template; // 0x100
	[SerializeField]
	private TMP_Text m_CaptionText; // 0x108
	[SerializeField]
	private Image m_CaptionImage; // 0x110
	[SerializeField]
	private Graphic m_Placeholder; // 0x118
	[Space]
	[SerializeField]
	private TMP_Text m_ItemText; // 0x120
	[SerializeField]
	private Image m_ItemImage; // 0x128
	[Space]
	[SerializeField]
	private int m_Value; // 0x130
	[SerializeField]
	private bool m_MultiSelect; // 0x134
	[Space]
	[SerializeField]
	private TMP_Dropdown.OptionDataList m_Options; // 0x138
	[Space]
	[SerializeField]
	private TMP_Dropdown.DropdownEvent m_OnValueChanged; // 0x140
	[SerializeField]
	private float m_AlphaFadeSpeed; // 0x148
	private GameObject m_Dropdown; // 0x150
	private GameObject m_Blocker; // 0x158
	private List<TMP_Dropdown.DropdownItem> m_Items; // 0x160
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x168
	private bool validTemplate; // 0x170
	private Coroutine m_Coroutine; // 0x178
	private static TMP_Dropdown.OptionData s_NoOptionData; // 0x18

	// Properties
	public RectTransform template { get; set; }
	public TMP_Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Graphic placeholder { get; set; }
	public TMP_Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<TMP_Dropdown.OptionData> options { get; set; }
	public TMP_Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }
	public bool IsExpanded { get; }
	public bool MultiSelect { get; set; }

	// Methods

	// RVA: 0x1DB4BF0 Offset: 0x1DB0BF0 VA: 0x1DB4BF0
	public RectTransform get_template() { }

	// RVA: 0x1DB4644 Offset: 0x1DB0644 VA: 0x1DB4644
	public void set_template(RectTransform value) { }

	// RVA: 0x1DB4BF8 Offset: 0x1DB0BF8 VA: 0x1DB4BF8
	public TMP_Text get_captionText() { }

	// RVA: 0x1DB4664 Offset: 0x1DB0664 VA: 0x1DB4664
	public void set_captionText(TMP_Text value) { }

	// RVA: 0x1DB4C00 Offset: 0x1DB0C00 VA: 0x1DB4C00
	public Image get_captionImage() { }

	// RVA: 0x1DB4C08 Offset: 0x1DB0C08 VA: 0x1DB4C08
	public void set_captionImage(Image value) { }

	// RVA: 0x1DB4C28 Offset: 0x1DB0C28 VA: 0x1DB4C28
	public Graphic get_placeholder() { }

	// RVA: 0x1DB4C30 Offset: 0x1DB0C30 VA: 0x1DB4C30
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1DB4C50 Offset: 0x1DB0C50 VA: 0x1DB4C50
	public TMP_Text get_itemText() { }

	// RVA: 0x1DB4684 Offset: 0x1DB0684 VA: 0x1DB4684
	public void set_itemText(TMP_Text value) { }

	// RVA: 0x1DB4C58 Offset: 0x1DB0C58 VA: 0x1DB4C58
	public Image get_itemImage() { }

	// RVA: 0x1DB4C60 Offset: 0x1DB0C60 VA: 0x1DB4C60
	public void set_itemImage(Image value) { }

	// RVA: 0x1DB46A4 Offset: 0x1DB06A4 VA: 0x1DB46A4
	public List<TMP_Dropdown.OptionData> get_options() { }

	// RVA: 0x1DB4C80 Offset: 0x1DB0C80 VA: 0x1DB4C80
	public void set_options(List<TMP_Dropdown.OptionData> value) { }

	// RVA: 0x1DB4CA8 Offset: 0x1DB0CA8 VA: 0x1DB4CA8
	public TMP_Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x1DB4CB0 Offset: 0x1DB0CB0 VA: 0x1DB4CB0
	public void set_onValueChanged(TMP_Dropdown.DropdownEvent value) { }

	// RVA: 0x1DB4CC0 Offset: 0x1DB0CC0 VA: 0x1DB4CC0
	public float get_alphaFadeSpeed() { }

	// RVA: 0x1DB4CC8 Offset: 0x1DB0CC8 VA: 0x1DB4CC8
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x1DB4CD0 Offset: 0x1DB0CD0 VA: 0x1DB4CD0
	public int get_value() { }

	// RVA: 0x1DB4CD8 Offset: 0x1DB0CD8 VA: 0x1DB4CD8
	public void set_value(int value) { }

	// RVA: 0x1DB4E50 Offset: 0x1DB0E50 VA: 0x1DB4E50
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x1DB4CE0 Offset: 0x1DB0CE0 VA: 0x1DB4CE0
	private void SetValue(int value, bool sendCallback = True) { }

	// RVA: 0x1DB4E58 Offset: 0x1DB0E58 VA: 0x1DB4E58
	public bool get_IsExpanded() { }

	// RVA: 0x1DB4EB8 Offset: 0x1DB0EB8 VA: 0x1DB4EB8
	public bool get_MultiSelect() { }

	// RVA: 0x1DB4EC0 Offset: 0x1DB0EC0 VA: 0x1DB4EC0
	public void set_MultiSelect(bool value) { }

	// RVA: 0x1DB4EC8 Offset: 0x1DB0EC8 VA: 0x1DB4EC8
	protected void .ctor() { }

	// RVA: 0x1DB50C0 Offset: 0x1DB10C0 VA: 0x1DB50C0 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1DB51E4 Offset: 0x1DB11E4 VA: 0x1DB51E4 Slot: 6
	protected override void Start() { }

	// RVA: 0x1DB5298 Offset: 0x1DB1298 VA: 0x1DB5298 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1DB46CC Offset: 0x1DB06CC VA: 0x1DB46CC
	public void RefreshShownValue() { }

	// RVA: 0x1DB5618 Offset: 0x1DB1618 VA: 0x1DB5618
	public void AddOptions(List<TMP_Dropdown.OptionData> options) { }

	// RVA: 0x1DB5680 Offset: 0x1DB1680 VA: 0x1DB5680
	public void AddOptions(List<string> options) { }

	// RVA: 0x1DB5834 Offset: 0x1DB1834 VA: 0x1DB5834
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x1DB59E8 Offset: 0x1DB19E8 VA: 0x1DB59E8
	public void ClearOptions() { }

	// RVA: 0x1DB5A98 Offset: 0x1DB1A98 VA: 0x1DB5A98
	private void SetupTemplate() { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114DE08 Offset: 0x1149E08 VA: 0x114DE08
	|-TMP_Dropdown.GetOrAddComponent<object>
	*/

	// RVA: 0x1DB6120 Offset: 0x1DB2120 VA: 0x1DB6120 Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1DB723C Offset: 0x1DB323C VA: 0x1DB723C Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1DB7240 Offset: 0x1DB3240 VA: 0x1DB7240 Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1DB6124 Offset: 0x1DB2124 VA: 0x1DB6124
	public void Show() { }

	// RVA: 0x1DB550C Offset: 0x1DB150C VA: 0x1DB550C
	private static bool IsEverythingValue(int count, int value) { }

	// RVA: 0x1DB77B4 Offset: 0x1DB37B4 VA: 0x1DB77B4
	private static int EverythingValue(int count) { }

	// RVA: 0x1DB7828 Offset: 0x1DB3828 VA: 0x1DB7828 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x1DB7D58 Offset: 0x1DB3D58 VA: 0x1DB7D58 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x1DB7DB0 Offset: 0x1DB3DB0 VA: 0x1DB7DB0 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x1DB7E1C Offset: 0x1DB3E1C VA: 0x1DB7E1C Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x1DB7E74 Offset: 0x1DB3E74 VA: 0x1DB7E74 Slot: 49
	protected virtual TMP_Dropdown.DropdownItem CreateItem(TMP_Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x1DB7EE0 Offset: 0x1DB3EE0 VA: 0x1DB7EE0 Slot: 50
	protected virtual void DestroyItem(TMP_Dropdown.DropdownItem item) { }

	// RVA: 0x1DB7378 Offset: 0x1DB3378 VA: 0x1DB7378
	private TMP_Dropdown.DropdownItem AddItem(TMP_Dropdown.OptionData data, bool selected, TMP_Dropdown.DropdownItem itemTemplate, List<TMP_Dropdown.DropdownItem> items) { }

	// RVA: 0x1DB7EE4 Offset: 0x1DB3EE4 VA: 0x1DB7EE4
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x1DB76A8 Offset: 0x1DB36A8 VA: 0x1DB76A8
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x1DB7F64 Offset: 0x1DB3F64 VA: 0x1DB7F64
	private void SetAlpha(float alpha) { }

	// RVA: 0x1DB7244 Offset: 0x1DB3244 VA: 0x1DB7244
	public void Hide() { }

	[IteratorStateMachine(typeof(TMP_Dropdown.<DelayedDestroyDropdownList>d__90))]
	// RVA: 0x1DB8018 Offset: 0x1DB4018 VA: 0x1DB8018
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x1DB5338 Offset: 0x1DB1338 VA: 0x1DB5338
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x1DB80BC Offset: 0x1DB40BC VA: 0x1DB80BC
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x1DB54E4 Offset: 0x1DB14E4 VA: 0x1DB54E4
	private static int FirstActiveFlagIndex(int value) { }

	// RVA: 0x1DB846C Offset: 0x1DB446C VA: 0x1DB846C
	private static void .cctor() { }
}

// Namespace: 
public struct TMP_DynamicFontAssetUtilities.FontReference // TypeDefIndex: 5183
{
	// Fields
	public string familyName; // 0x0
	public string styleName; // 0x8
	public int faceIndex; // 0x10
	public string filePath; // 0x18
	public ulong hashCode; // 0x20

	// Methods

	// RVA: 0x1DB9038 Offset: 0x1DB5038 VA: 0x1DB9038
	public void .ctor(string fontFilePath, string faceNameAndStyle, int index) { }
}

// Namespace: TMPro
internal class TMP_DynamicFontAssetUtilities // TypeDefIndex: 5184
{
	// Fields
	private static TMP_DynamicFontAssetUtilities s_Instance; // 0x0
	private Dictionary<ulong, TMP_DynamicFontAssetUtilities.FontReference> s_SystemFontLookup; // 0x10
	private string[] s_SystemFontPaths; // 0x18
	private uint s_RegularStyleNameHashCode; // 0x20

	// Methods

	// RVA: 0x1DB89A0 Offset: 0x1DB49A0 VA: 0x1DB89A0
	private void InitializeSystemFontReferenceCache() { }

	// RVA: 0x1DB92CC Offset: 0x1DB52CC VA: 0x1DB92CC
	public static bool TryGetSystemFontReference(string familyName, out TMP_DynamicFontAssetUtilities.FontReference fontRef) { }

	// RVA: 0x1DB9604 Offset: 0x1DB5604 VA: 0x1DB9604
	public static bool TryGetSystemFontReference(string familyName, string styleName, out TMP_DynamicFontAssetUtilities.FontReference fontRef) { }

	// RVA: 0x1DB9348 Offset: 0x1DB5348 VA: 0x1DB9348
	private bool TryGetSystemFontReferenceInternal(string familyName, string styleName, out TMP_DynamicFontAssetUtilities.FontReference fontRef) { }

	// RVA: 0x1DB9684 Offset: 0x1DB5684 VA: 0x1DB9684
	public void .ctor() { }

	// RVA: 0x1DB9698 Offset: 0x1DB5698 VA: 0x1DB9698
	private static void .cctor() { }
}

// Namespace: TMPro
public enum AtlasPopulationMode // TypeDefIndex: 5185
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
private sealed class TMP_FontAsset.<>c // TypeDefIndex: 5186
{
	// Fields
	public static readonly TMP_FontAsset.<>c <>9; // 0x0
	public static Func<TMP_Character, uint> <>9__145_0; // 0x8
	public static Func<Glyph, uint> <>9__146_0; // 0x10

	// Methods

	// RVA: 0x1DC478C Offset: 0x1DC078C VA: 0x1DC478C
	private static void .cctor() { }

	// RVA: 0x1DC47F4 Offset: 0x1DC07F4 VA: 0x1DC47F4
	public void .ctor() { }

	// RVA: 0x1DC47FC Offset: 0x1DC07FC VA: 0x1DC47FC
	internal uint <SortCharacterTable>b__145_0(TMP_Character c) { }

	// RVA: 0x1DC4810 Offset: 0x1DC0810 VA: 0x1DC4810
	internal uint <SortGlyphTable>b__146_0(Glyph c) { }
}

// Namespace: TMPro
[ExcludeFromPreset]
[Serializable]
public class TMP_FontAsset : TMP_Asset // TypeDefIndex: 5187
{
	// Fields
	[SerializeField]
	internal string m_SourceFontFileGUID; // 0x98
	[SerializeField]
	internal FontAssetCreationSettings m_CreationSettings; // 0xA0
	[SerializeField]
	private Font m_SourceFontFile; // 0x100
	[SerializeField]
	private string m_SourceFontFilePath; // 0x108
	[SerializeField]
	private AtlasPopulationMode m_AtlasPopulationMode; // 0x110
	[SerializeField]
	internal bool InternalDynamicOS; // 0x114
	private int m_FamilyNameHashCode; // 0x118
	private int m_StyleNameHashCode; // 0x11C
	[SerializeField]
	internal List<Glyph> m_GlyphTable; // 0x120
	internal Dictionary<uint, Glyph> m_GlyphLookupDictionary; // 0x128
	[SerializeField]
	internal List<TMP_Character> m_CharacterTable; // 0x130
	internal Dictionary<uint, TMP_Character> m_CharacterLookupDictionary; // 0x138
	internal Texture2D m_AtlasTexture; // 0x140
	[SerializeField]
	internal Texture2D[] m_AtlasTextures; // 0x148
	[SerializeField]
	internal int m_AtlasTextureIndex; // 0x150
	[SerializeField]
	private bool m_IsMultiAtlasTexturesEnabled; // 0x154
	[SerializeField]
	private bool m_GetFontFeatures; // 0x155
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; // 0x156
	[SerializeField]
	internal int m_AtlasWidth; // 0x158
	[SerializeField]
	internal int m_AtlasHeight; // 0x15C
	[SerializeField]
	internal int m_AtlasPadding; // 0x160
	[SerializeField]
	internal GlyphRenderMode m_AtlasRenderMode; // 0x164
	[SerializeField]
	private List<GlyphRect> m_UsedGlyphRects; // 0x168
	[SerializeField]
	private List<GlyphRect> m_FreeGlyphRects; // 0x170
	[SerializeField]
	internal TMP_FontFeatureTable m_FontFeatureTable; // 0x178
	[SerializeField]
	internal bool m_ShouldReimportFontFeatures; // 0x180
	[SerializeField]
	internal List<TMP_FontAsset> m_FallbackFontAssetTable; // 0x188
	[SerializeField]
	private TMP_FontWeightPair[] m_FontWeightTable; // 0x190
	[SerializeField]
	private TMP_FontWeightPair[] fontWeights; // 0x198
	public float normalStyle; // 0x1A0
	public float normalSpacingOffset; // 0x1A4
	public float boldStyle; // 0x1A8
	public float boldSpacing; // 0x1AC
	public byte italicStyle; // 0x1B0
	public byte tabSize; // 0x1B1
	internal bool IsFontAssetLookupTablesDirty; // 0x1B2
	[SerializeField]
	private FaceInfo_Legacy m_fontInfo; // 0x1B8
	[SerializeField]
	internal List<TMP_Glyph> m_glyphInfoList; // 0x1C0
	[SerializeField]
	[FormerlySerializedAs("m_kerningInfo")]
	internal KerningTable m_KerningTable; // 0x1C8
	[SerializeField]
	private List<TMP_FontAsset> fallbackFontAssets; // 0x1D0
	[SerializeField]
	public Texture2D atlas; // 0x1D8
	private static readonly List<WeakReference<TMP_FontAsset>> s_CallbackInstances; // 0x0
	private static ProfilerMarker k_ReadFontAssetDefinitionMarker; // 0x8
	private static ProfilerMarker k_AddSynthesizedCharactersMarker; // 0x10
	private static ProfilerMarker k_TryAddGlyphMarker; // 0x18
	private static ProfilerMarker k_TryAddCharacterMarker; // 0x20
	private static ProfilerMarker k_TryAddCharactersMarker; // 0x28
	private static ProfilerMarker k_UpdateLigatureSubstitutionRecordsMarker; // 0x30
	private static ProfilerMarker k_UpdateGlyphAdjustmentRecordsMarker; // 0x38
	private static ProfilerMarker k_UpdateDiacriticalMarkAdjustmentRecordsMarker; // 0x40
	private static ProfilerMarker k_ClearFontAssetDataMarker; // 0x48
	private static ProfilerMarker k_UpdateFontAssetDataMarker; // 0x50
	private static string s_DefaultMaterialSuffix; // 0x58
	private static HashSet<int> k_SearchedFontAssetLookup; // 0x60
	private static List<TMP_FontAsset> k_FontAssets_FontFeaturesUpdateQueue; // 0x68
	private static HashSet<int> k_FontAssets_FontFeaturesUpdateQueueLookup; // 0x70
	private static List<Texture2D> k_FontAssets_AtlasTexturesUpdateQueue; // 0x78
	private static HashSet<int> k_FontAssets_AtlasTexturesUpdateQueueLookup; // 0x80
	private List<Glyph> m_GlyphsToRender; // 0x1E0
	private List<Glyph> m_GlyphsRendered; // 0x1E8
	private List<uint> m_GlyphIndexList; // 0x1F0
	private List<uint> m_GlyphIndexListNewlyAdded; // 0x1F8
	internal List<uint> m_GlyphsToAdd; // 0x200
	internal HashSet<uint> m_GlyphsToAddLookup; // 0x208
	internal List<TMP_Character> m_CharactersToAdd; // 0x210
	internal HashSet<uint> m_CharactersToAddLookup; // 0x218
	internal List<uint> s_MissingCharacterList; // 0x220
	internal HashSet<uint> m_MissingUnicodesFromFontFile; // 0x228
	internal static uint[] k_GlyphIndexArray; // 0x88

	// Properties
	public FontAssetCreationSettings creationSettings { get; set; }
	public Font sourceFontFile { get; set; }
	public AtlasPopulationMode atlasPopulationMode { get; set; }
	internal int familyNameHashCode { get; set; }
	internal int styleNameHashCode { get; set; }
	public List<Glyph> glyphTable { get; set; }
	public Dictionary<uint, Glyph> glyphLookupTable { get; }
	public List<TMP_Character> characterTable { get; set; }
	public Dictionary<uint, TMP_Character> characterLookupTable { get; }
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
	public TMP_FontFeatureTable fontFeatureTable { get; set; }
	public List<TMP_FontAsset> fallbackFontAssetTable { get; set; }
	public TMP_FontWeightPair[] fontWeightTable { get; set; }
	[Obsolete("The fontInfo property and underlying type is now obsolete. Please use the faceInfo property and FaceInfo type instead.")]
	public FaceInfo_Legacy fontInfo { get; }

	// Methods

	// RVA: 0x1DB970C Offset: 0x1DB570C VA: 0x1DB970C
	public FontAssetCreationSettings get_creationSettings() { }

	// RVA: 0x1DB971C Offset: 0x1DB571C VA: 0x1DB971C
	public void set_creationSettings(FontAssetCreationSettings value) { }

	// RVA: 0x1DB9740 Offset: 0x1DB5740 VA: 0x1DB9740
	public Font get_sourceFontFile() { }

	// RVA: 0x1DB9748 Offset: 0x1DB5748 VA: 0x1DB9748
	internal void set_sourceFontFile(Font value) { }

	// RVA: 0x1DB9758 Offset: 0x1DB5758 VA: 0x1DB9758
	public AtlasPopulationMode get_atlasPopulationMode() { }

	// RVA: 0x1DB9760 Offset: 0x1DB5760 VA: 0x1DB9760
	public void set_atlasPopulationMode(AtlasPopulationMode value) { }

	// RVA: 0x1DB9768 Offset: 0x1DB5768 VA: 0x1DB9768
	internal int get_familyNameHashCode() { }

	// RVA: 0x1DB97E4 Offset: 0x1DB57E4 VA: 0x1DB97E4
	internal void set_familyNameHashCode(int value) { }

	// RVA: 0x1DB97EC Offset: 0x1DB57EC VA: 0x1DB97EC
	internal int get_styleNameHashCode() { }

	// RVA: 0x1DB9868 Offset: 0x1DB5868 VA: 0x1DB9868
	internal void set_styleNameHashCode(int value) { }

	// RVA: 0x1DB9870 Offset: 0x1DB5870 VA: 0x1DB9870
	public List<Glyph> get_glyphTable() { }

	// RVA: 0x1DB9878 Offset: 0x1DB5878 VA: 0x1DB9878
	internal void set_glyphTable(List<Glyph> value) { }

	// RVA: 0x1DB9888 Offset: 0x1DB5888 VA: 0x1DB9888
	public Dictionary<uint, Glyph> get_glyphLookupTable() { }

	// RVA: 0x1DB9FCC Offset: 0x1DB5FCC VA: 0x1DB9FCC
	public List<TMP_Character> get_characterTable() { }

	// RVA: 0x1DB9FD4 Offset: 0x1DB5FD4 VA: 0x1DB9FD4
	internal void set_characterTable(List<TMP_Character> value) { }

	// RVA: 0x1DB9FE4 Offset: 0x1DB5FE4 VA: 0x1DB9FE4
	public Dictionary<uint, TMP_Character> get_characterLookupTable() { }

	// RVA: 0x1DBA008 Offset: 0x1DB6008 VA: 0x1DBA008
	public Texture2D get_atlasTexture() { }

	// RVA: 0x1DBA09C Offset: 0x1DB609C VA: 0x1DBA09C
	public Texture2D[] get_atlasTextures() { }

	// RVA: 0x1DBA0A4 Offset: 0x1DB60A4 VA: 0x1DBA0A4
	public void set_atlasTextures(Texture2D[] value) { }

	// RVA: 0x1DBA0B4 Offset: 0x1DB60B4 VA: 0x1DBA0B4
	public int get_atlasTextureCount() { }

	// RVA: 0x1DBA0C0 Offset: 0x1DB60C0 VA: 0x1DBA0C0
	public bool get_isMultiAtlasTexturesEnabled() { }

	// RVA: 0x1DBA0C8 Offset: 0x1DB60C8 VA: 0x1DBA0C8
	public void set_isMultiAtlasTexturesEnabled(bool value) { }

	// RVA: 0x1DBA0D0 Offset: 0x1DB60D0 VA: 0x1DBA0D0
	public bool get_getFontFeatures() { }

	// RVA: 0x1DBA0D8 Offset: 0x1DB60D8 VA: 0x1DBA0D8
	public void set_getFontFeatures(bool value) { }

	// RVA: 0x1DBA0E0 Offset: 0x1DB60E0 VA: 0x1DBA0E0
	internal bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x1DBA0E8 Offset: 0x1DB60E8 VA: 0x1DBA0E8
	internal void set_clearDynamicDataOnBuild(bool value) { }

	// RVA: 0x1DBA0F0 Offset: 0x1DB60F0 VA: 0x1DBA0F0
	public int get_atlasWidth() { }

	// RVA: 0x1DBA0F8 Offset: 0x1DB60F8 VA: 0x1DBA0F8
	internal void set_atlasWidth(int value) { }

	// RVA: 0x1DBA100 Offset: 0x1DB6100 VA: 0x1DBA100
	public int get_atlasHeight() { }

	// RVA: 0x1DBA108 Offset: 0x1DB6108 VA: 0x1DBA108
	internal void set_atlasHeight(int value) { }

	// RVA: 0x1DBA110 Offset: 0x1DB6110 VA: 0x1DBA110
	public int get_atlasPadding() { }

	// RVA: 0x1DBA118 Offset: 0x1DB6118 VA: 0x1DBA118
	internal void set_atlasPadding(int value) { }

	// RVA: 0x1DBA120 Offset: 0x1DB6120 VA: 0x1DBA120
	public GlyphRenderMode get_atlasRenderMode() { }

	// RVA: 0x1DBA128 Offset: 0x1DB6128 VA: 0x1DBA128
	internal void set_atlasRenderMode(GlyphRenderMode value) { }

	// RVA: 0x1DBA130 Offset: 0x1DB6130 VA: 0x1DBA130
	internal List<GlyphRect> get_usedGlyphRects() { }

	// RVA: 0x1DBA138 Offset: 0x1DB6138 VA: 0x1DBA138
	internal void set_usedGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x1DBA148 Offset: 0x1DB6148 VA: 0x1DBA148
	internal List<GlyphRect> get_freeGlyphRects() { }

	// RVA: 0x1DBA150 Offset: 0x1DB6150 VA: 0x1DBA150
	internal void set_freeGlyphRects(List<GlyphRect> value) { }

	// RVA: 0x1DBA160 Offset: 0x1DB6160 VA: 0x1DBA160
	public TMP_FontFeatureTable get_fontFeatureTable() { }

	// RVA: 0x1DBA168 Offset: 0x1DB6168 VA: 0x1DBA168
	internal void set_fontFeatureTable(TMP_FontFeatureTable value) { }

	// RVA: 0x1DBA178 Offset: 0x1DB6178 VA: 0x1DBA178
	public List<TMP_FontAsset> get_fallbackFontAssetTable() { }

	// RVA: 0x1DBA180 Offset: 0x1DB6180 VA: 0x1DBA180
	public void set_fallbackFontAssetTable(List<TMP_FontAsset> value) { }

	// RVA: 0x1DBA190 Offset: 0x1DB6190 VA: 0x1DBA190
	public TMP_FontWeightPair[] get_fontWeightTable() { }

	// RVA: 0x1DBA198 Offset: 0x1DB6198 VA: 0x1DBA198
	internal void set_fontWeightTable(TMP_FontWeightPair[] value) { }

	// RVA: 0x1DBA1A8 Offset: 0x1DB61A8 VA: 0x1DBA1A8
	public FaceInfo_Legacy get_fontInfo() { }

	// RVA: 0x1DBA1B0 Offset: 0x1DB61B0 VA: 0x1DBA1B0
	public static TMP_FontAsset CreateFontAsset(string familyName, string styleName, int pointSize = 90) { }

	// RVA: 0x1DBA568 Offset: 0x1DB6568 VA: 0x1DBA568
	public static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight) { }

	// RVA: 0x1DBA3E0 Offset: 0x1DB63E0 VA: 0x1DBA3E0
	private static TMP_FontAsset CreateFontAsset(string fontFilePath, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x1DBAB78 Offset: 0x1DB6B78 VA: 0x1DBAB78
	public static TMP_FontAsset CreateFontAsset(Font font) { }

	// RVA: 0x1DBABF4 Offset: 0x1DB6BF4 VA: 0x1DBABF4
	public static TMP_FontAsset CreateFontAsset(Font font, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x1DBACB4 Offset: 0x1DB6CB4 VA: 0x1DBACB4
	private static TMP_FontAsset CreateFontAsset(Font font, int faceIndex, int samplingPointSize, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode = 1, bool enableMultiAtlasSupport = True) { }

	// RVA: 0x1DBA61C Offset: 0x1DB661C VA: 0x1DBA61C
	private static TMP_FontAsset CreateFontAssetInstance(Font font, int atlasPadding, GlyphRenderMode renderMode, int atlasWidth, int atlasHeight, AtlasPopulationMode atlasPopulationMode, bool enableMultiAtlasSupport) { }

	// RVA: 0x1DBAE4C Offset: 0x1DB6E4C VA: 0x1DBAE4C
	private void RegisterCallbackInstance(TMP_FontAsset instance) { }

	// RVA: 0x1DBB158 Offset: 0x1DB7158 VA: 0x1DBB158
	private void OnDestroy() { }

	// RVA: 0x1DB98AC Offset: 0x1DB58AC VA: 0x1DB98AC
	public void ReadFontAssetDefinition() { }

	// RVA: 0x1DBB280 Offset: 0x1DB7280 VA: 0x1DBB280
	internal void InitializeDictionaryLookupTables() { }

	// RVA: 0x1DBB4D8 Offset: 0x1DB74D8 VA: 0x1DBB4D8
	internal void InitializeGlyphLookupDictionary() { }

	// RVA: 0x1DBB784 Offset: 0x1DB7784 VA: 0x1DBB784
	internal void InitializeCharacterLookupDictionary() { }

	// RVA: 0x1DBC368 Offset: 0x1DB8368 VA: 0x1DBC368
	internal void ClearFallbackCharacterTable() { }

	// RVA: 0x1DBBA74 Offset: 0x1DB7A74 VA: 0x1DBBA74
	internal void InitializeLigatureSubstitutionLookupDictionary() { }

	// RVA: 0x1DBBD74 Offset: 0x1DB7D74 VA: 0x1DBBD74
	internal void InitializeGlyphPaidAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x1DBBFE0 Offset: 0x1DB7FE0 VA: 0x1DBBFE0
	internal void InitializeMarkToBaseAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x1DBC1A4 Offset: 0x1DB81A4 VA: 0x1DBC1A4
	internal void InitializeMarkToMarkAdjustmentRecordsLookupDictionary() { }

	// RVA: 0x1DBB2D8 Offset: 0x1DB72D8 VA: 0x1DBB2D8
	internal void AddSynthesizedCharactersAndFaceMetrics() { }

	// RVA: 0x1DBCC38 Offset: 0x1DB8C38 VA: 0x1DBCC38
	private void AddSynthesizedCharacter(uint unicode, bool isFontFaceLoaded, bool addImmediately = False) { }

	// RVA: 0x1DBCE50 Offset: 0x1DB8E50 VA: 0x1DBCE50
	internal void AddCharacterToLookupCache(uint unicode, TMP_Character character, FontStyles fontStyle = 0, FontWeight fontWeight = 400, bool isAlternativeTypeface = False) { }

	// RVA: 0x1DBCAB8 Offset: 0x1DB8AB8 VA: 0x1DBCAB8
	internal FontEngineError LoadFontFace() { }

	// RVA: 0x1DBCF00 Offset: 0x1DB8F00 VA: 0x1DBCF00
	internal void SortCharacterTable() { }

	// RVA: 0x1DBD054 Offset: 0x1DB9054 VA: 0x1DBD054
	internal void SortGlyphTable() { }

	// RVA: 0x1DBD1A8 Offset: 0x1DB91A8 VA: 0x1DBD1A8
	internal void SortFontFeatureTable() { }

	// RVA: 0x1DBD1E8 Offset: 0x1DB91E8 VA: 0x1DBD1E8
	internal void SortAllTables() { }

	// RVA: 0x1DBD208 Offset: 0x1DB9208 VA: 0x1DBD208
	public bool HasCharacter(int character) { }

	// RVA: 0x1DBD278 Offset: 0x1DB9278 VA: 0x1DBD278
	public bool HasCharacter(char character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x1DBE1D4 Offset: 0x1DBA1D4 VA: 0x1DBE1D4
	private bool HasCharacter_Internal(uint character, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x1DBE3F0 Offset: 0x1DBA3F0 VA: 0x1DBE3F0
	public bool HasCharacters(string text, out List<char> missingCharacters) { }

	// RVA: 0x1DBE5E0 Offset: 0x1DBA5E0 VA: 0x1DBE5E0
	public bool HasCharacters(string text, out uint[] missingCharacters, bool searchFallbacks = False, bool tryAddCharacter = False) { }

	// RVA: 0x1DBEC94 Offset: 0x1DBAC94 VA: 0x1DBEC94
	public bool HasCharacters(string text) { }

	// RVA: 0x1DBED90 Offset: 0x1DBAD90 VA: 0x1DBED90
	public static string GetCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x1DBEE80 Offset: 0x1DBAE80 VA: 0x1DBEE80
	public static int[] GetCharactersArray(TMP_FontAsset fontAsset) { }

	// RVA: 0x1DBEF64 Offset: 0x1DBAF64 VA: 0x1DBEF64
	internal uint GetGlyphIndex(uint unicode) { }

	// RVA: 0x1DBF040 Offset: 0x1DBB040 VA: 0x1DBF040
	internal uint GetGlyphVariantIndex(uint unicode, uint variantSelectorUnicode) { }

	// RVA: 0x1DBF0CC Offset: 0x1DBB0CC VA: 0x1DBF0CC
	internal static void RegisterFontAssetForFontFeatureUpdate(TMP_FontAsset fontAsset) { }

	// RVA: 0x1DBF210 Offset: 0x1DBB210 VA: 0x1DBF210
	internal static void UpdateFontFeaturesForFontAssetsInQueue() { }

	// RVA: 0x1DBF3D8 Offset: 0x1DBB3D8 VA: 0x1DBF3D8
	internal static void RegisterAtlasTextureForApply(Texture2D texture) { }

	// RVA: 0x1DBF514 Offset: 0x1DBB514 VA: 0x1DBF514
	internal static void UpdateAtlasTexturesInQueue() { }

	// RVA: 0x1DBF688 Offset: 0x1DBB688 VA: 0x1DBF688
	internal static void UpdateFontAssetsInUpdateQueue() { }

	// RVA: 0x1DBF6D8 Offset: 0x1DBB6D8 VA: 0x1DBF6D8
	public bool TryAddCharacters(uint[] unicodes, bool includeFontFeatures = False) { }

	// RVA: 0x1DBF6F4 Offset: 0x1DBB6F4 VA: 0x1DBF6F4
	public bool TryAddCharacters(uint[] unicodes, out uint[] missingUnicodes, bool includeFontFeatures = False) { }

	// RVA: 0x1DC0868 Offset: 0x1DBC868 VA: 0x1DC0868
	public bool TryAddCharacters(string characters, bool includeFontFeatures = False) { }

	// RVA: 0x1DC0884 Offset: 0x1DBC884 VA: 0x1DC0884
	public bool TryAddCharacters(string characters, out string missingCharacters, bool includeFontFeatures = False) { }

	// RVA: 0x1DC148C Offset: 0x1DBD48C VA: 0x1DC148C
	internal bool AddGlyphInternal(uint glyphIndex) { }

	// RVA: 0x1DC14A4 Offset: 0x1DBD4A4 VA: 0x1DC14A4
	internal bool TryAddGlyphInternal(uint glyphIndex, out Glyph glyph) { }

	// RVA: 0x1DBD7CC Offset: 0x1DB97CC VA: 0x1DBD7CC
	internal bool TryAddCharacterInternal(uint unicode, out TMP_Character character) { }

	// RVA: 0x1DC1E80 Offset: 0x1DBDE80 VA: 0x1DC1E80
	internal bool TryGetCharacter_and_QueueRenderToTexture(uint unicode, out TMP_Character character) { }

	// RVA: 0x1DC2450 Offset: 0x1DBE450 VA: 0x1DC2450
	internal void TryAddGlyphsToAtlasTextures() { }

	// RVA: 0x1DC035C Offset: 0x1DBC35C VA: 0x1DC035C
	private bool TryAddGlyphsToNewAtlasTexture() { }

	// RVA: 0x1DC1C54 Offset: 0x1DBDC54 VA: 0x1DC1C54
	private void SetupNewAtlasTexture() { }

	// RVA: 0x1DC2454 Offset: 0x1DBE454 VA: 0x1DC2454
	internal void UpdateAtlasTexture() { }

	// RVA: 0x1DC0800 Offset: 0x1DBC800 VA: 0x1DC0800
	private void UpdateFontFeaturesForNewlyAddedGlyphs() { }

	// RVA: 0x1DBF378 Offset: 0x1DBB378 VA: 0x1DBF378
	private void UpdateGPOSFontFeaturesForNewlyAddedGlyphs() { }

	// RVA: 0x1DBB984 Offset: 0x1DB7984 VA: 0x1DBB984
	internal void ImportFontFeatures() { }

	// RVA: 0x1DC1BD0 Offset: 0x1DBDBD0 VA: 0x1DC1BD0
	private void UpdateGSUBFontFeaturesForNewGlyphIndex(uint glyphIndex) { }

	// RVA: 0x1DC25D4 Offset: 0x1DBE5D4 VA: 0x1DC25D4
	internal void UpdateLigatureSubstitutionRecords() { }

	// RVA: 0x1DC305C Offset: 0x1DBF05C VA: 0x1DC305C
	private void AddLigatureSubstitutionRecords(LigatureSubstitutionRecord[] records) { }

	// RVA: 0x1DC264C Offset: 0x1DBE64C VA: 0x1DC264C
	internal void UpdateGlyphAdjustmentRecords() { }

	// RVA: 0x1DC276C Offset: 0x1DBE76C VA: 0x1DC276C
	private void AddPairAdjustmentRecords(GlyphPairAdjustmentRecord[] records) { }

	// RVA: 0x1DC34E0 Offset: 0x1DBF4E0 VA: 0x1DC34E0
	internal void UpdateGlyphAdjustmentRecords(uint[] glyphIndexes) { }

	// RVA: 0x1DC26C4 Offset: 0x1DBE6C4 VA: 0x1DC26C4
	internal void UpdateDiacriticalMarkAdjustmentRecords() { }

	// RVA: 0x1DC2A64 Offset: 0x1DBEA64 VA: 0x1DC2A64
	private void AddMarkToBaseAdjustmentRecords(MarkToBaseAdjustmentRecord[] records) { }

	// RVA: 0x1DC2D60 Offset: 0x1DBED60 VA: 0x1DC2D60
	private void AddMarkToMarkAdjustmentRecords(MarkToMarkAdjustmentRecord[] records) { }

	// RVA: -1 Offset: -1
	private void CopyListDataToArray<T>(List<T> srcList, ref T[] dstArray) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114DEAC Offset: 0x1149EAC VA: 0x114DEAC
	|-TMP_FontAsset.CopyListDataToArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1DC37FC Offset: 0x1DBF7FC VA: 0x1DC37FC
	internal void UpdateFontAssetData() { }

	// RVA: 0x1DC3E00 Offset: 0x1DBFE00 VA: 0x1DC3E00
	public void ClearFontAssetData(bool setAtlasSizeToZero = False) { }

	// RVA: 0x1DC3FB0 Offset: 0x1DBFFB0 VA: 0x1DC3FB0
	internal void ClearCharacterAndGlyphTablesInternal() { }

	// RVA: 0x1DC3FD4 Offset: 0x1DBFFD4 VA: 0x1DC3FD4
	internal void ClearFontFeaturesInternal() { }

	// RVA: 0x1DC395C Offset: 0x1DBF95C VA: 0x1DC395C
	private void ClearCharacterAndGlyphTables() { }

	// RVA: 0x1DC3B30 Offset: 0x1DBFB30 VA: 0x1DC3B30
	private void ClearFontFeaturesTables() { }

	// RVA: 0x1DC3C04 Offset: 0x1DBFC04 VA: 0x1DC3C04
	internal void ClearAtlasTextures(bool setAtlasSizeToZero = False) { }

	// RVA: 0x1DBB1BC Offset: 0x1DB71BC VA: 0x1DBB1BC
	private void DestroyAtlasTextures() { }

	// RVA: 0x1DBC6DC Offset: 0x1DB86DC VA: 0x1DBC6DC
	private void UpgradeGlyphAdjustmentTableToFontFeatureTable() { }

	// RVA: 0x1DC3FEC Offset: 0x1DBFFEC VA: 0x1DC3FEC
	public void .ctor() { }

	// RVA: 0x1DC434C Offset: 0x1DC034C VA: 0x1DC434C
	private static void .cctor() { }
}

// Namespace: TMPro
[Serializable]
public class FaceInfo_Legacy // TypeDefIndex: 5188
{
	// Fields
	public string Name; // 0x10
	public float PointSize; // 0x18
	public float Scale; // 0x1C
	public int CharacterCount; // 0x20
	public float LineHeight; // 0x24
	public float Baseline; // 0x28
	public float Ascender; // 0x2C
	public float CapHeight; // 0x30
	public float Descender; // 0x34
	public float CenterLine; // 0x38
	public float SuperscriptOffset; // 0x3C
	public float SubscriptOffset; // 0x40
	public float SubSize; // 0x44
	public float Underline; // 0x48
	public float UnderlineThickness; // 0x4C
	public float strikethrough; // 0x50
	public float strikethroughThickness; // 0x54
	public float TabWidth; // 0x58
	public float Padding; // 0x5C
	public float AtlasWidth; // 0x60
	public float AtlasHeight; // 0x64

	// Methods

	// RVA: 0x1DC4828 Offset: 0x1DC0828 VA: 0x1DC4828
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Glyph : TMP_TextElement_Legacy // TypeDefIndex: 5189
{
	// Methods

	// RVA: 0x1DC4830 Offset: 0x1DC0830 VA: 0x1DC4830
	public static TMP_Glyph Clone(TMP_Glyph source) { }

	// RVA: 0x1DC48AC Offset: 0x1DC08AC VA: 0x1DC48AC
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public struct FontAssetCreationSettings // TypeDefIndex: 5190
{
	// Fields
	public string sourceFontFileName; // 0x0
	public string sourceFontFileGUID; // 0x8
	public int faceIndex; // 0x10
	public int pointSizeSamplingMode; // 0x14
	public int pointSize; // 0x18
	public int padding; // 0x1C
	public int paddingMode; // 0x20
	public int packingMode; // 0x24
	public int atlasWidth; // 0x28
	public int atlasHeight; // 0x2C
	public int characterSetSelectionMode; // 0x30
	public string characterSequence; // 0x38
	public string referencedFontAssetGUID; // 0x40
	public string referencedTextAssetGUID; // 0x48
	public int fontStyle; // 0x50
	public float fontStyleModifier; // 0x54
	public int renderMode; // 0x58
	public bool includeFontFeatures; // 0x5C

	// Methods

	// RVA: 0x1DC48B4 Offset: 0x1DC08B4 VA: 0x1DC48B4
	internal void .ctor(string sourceFontFileGUID, int pointSize, int pointSizeSamplingMode, int padding, int packingMode, int atlasWidth, int atlasHeight, int characterSelectionMode, string characterSet, int renderMode) { }
}

// Namespace: TMPro
[Serializable]
public struct TMP_FontWeightPair // TypeDefIndex: 5191
{
	// Fields
	public TMP_FontAsset regularTypeface; // 0x0
	public TMP_FontAsset italicTypeface; // 0x8
}

// Namespace: TMPro
public struct KerningPairKey // TypeDefIndex: 5192
{
	// Fields
	public uint ascii_Left; // 0x0
	public uint ascii_Right; // 0x4
	public uint key; // 0x8

	// Methods

	// RVA: 0x1DC49AC Offset: 0x1DC09AC VA: 0x1DC49AC
	public void .ctor(uint ascii_left, uint ascii_right) { }
}

// Namespace: TMPro
[Serializable]
public struct GlyphValueRecord_Legacy // TypeDefIndex: 5193
{
	// Fields
	public float xPlacement; // 0x0
	public float yPlacement; // 0x4
	public float xAdvance; // 0x8
	public float yAdvance; // 0xC

	// Methods

	// RVA: 0x1DC49BC Offset: 0x1DC09BC VA: 0x1DC49BC
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0x1DC4A1C Offset: 0x1DC0A1C VA: 0x1DC4A1C
	public static GlyphValueRecord_Legacy op_Addition(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b) { }
}

// Namespace: TMPro
[Serializable]
public class KerningPair // TypeDefIndex: 5194
{
	// Fields
	[FormerlySerializedAs("AscII_Left")]
	[SerializeField]
	private uint m_FirstGlyph; // 0x10
	[SerializeField]
	private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
	[FormerlySerializedAs("AscII_Right")]
	[SerializeField]
	private uint m_SecondGlyph; // 0x24
	[SerializeField]
	private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
	[FormerlySerializedAs("XadvanceOffset")]
	public float xOffset; // 0x38
	internal static KerningPair empty; // 0x0
	[SerializeField]
	private bool m_IgnoreSpacingAdjustments; // 0x3C

	// Properties
	public uint firstGlyph { get; set; }
	public GlyphValueRecord_Legacy firstGlyphAdjustments { get; }
	public uint secondGlyph { get; set; }
	public GlyphValueRecord_Legacy secondGlyphAdjustments { get; }
	public bool ignoreSpacingAdjustments { get; }

	// Methods

	// RVA: 0x1DC4A30 Offset: 0x1DC0A30 VA: 0x1DC4A30
	public uint get_firstGlyph() { }

	// RVA: 0x1DC4A38 Offset: 0x1DC0A38 VA: 0x1DC4A38
	public void set_firstGlyph(uint value) { }

	// RVA: 0x1DC4A40 Offset: 0x1DC0A40 VA: 0x1DC4A40
	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	// RVA: 0x1DC4A4C Offset: 0x1DC0A4C VA: 0x1DC4A4C
	public uint get_secondGlyph() { }

	// RVA: 0x1DC4A54 Offset: 0x1DC0A54 VA: 0x1DC4A54
	public void set_secondGlyph(uint value) { }

	// RVA: 0x1DC4A5C Offset: 0x1DC0A5C VA: 0x1DC4A5C
	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	// RVA: 0x1DC4A68 Offset: 0x1DC0A68 VA: 0x1DC4A68
	public bool get_ignoreSpacingAdjustments() { }

	// RVA: 0x1DC4A70 Offset: 0x1DC0A70 VA: 0x1DC4A70
	public void .ctor() { }

	// RVA: 0x1DC4A94 Offset: 0x1DC0A94 VA: 0x1DC4A94
	public void .ctor(uint left, uint right, float offset) { }

	// RVA: 0x1DC4AD4 Offset: 0x1DC0AD4 VA: 0x1DC4AD4
	public void .ctor(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	// RVA: 0x1DC4B54 Offset: 0x1DC0B54 VA: 0x1DC4B54
	internal void ConvertLegacyKerningData() { }

	// RVA: 0x1DC4B60 Offset: 0x1DC0B60 VA: 0x1DC4B60
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class KerningTable.<>c // TypeDefIndex: 5195
{
	// Fields
	public static readonly KerningTable.<>c <>9; // 0x0
	public static Func<KerningPair, uint> <>9__7_0; // 0x8
	public static Func<KerningPair, uint> <>9__7_1; // 0x10

	// Methods

	// RVA: 0x1DC5598 Offset: 0x1DC1598 VA: 0x1DC5598
	private static void .cctor() { }

	// RVA: 0x1DC5600 Offset: 0x1DC1600 VA: 0x1DC5600
	public void .ctor() { }

	// RVA: 0x1DC5608 Offset: 0x1DC1608 VA: 0x1DC5608
	internal uint <SortKerningPairs>b__7_0(KerningPair s) { }

	// RVA: 0x1DC561C Offset: 0x1DC161C VA: 0x1DC561C
	internal uint <SortKerningPairs>b__7_1(KerningPair s) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KerningTable.<>c__DisplayClass3_0 // TypeDefIndex: 5196
{
	// Fields
	public uint first; // 0x10
	public uint second; // 0x14

	// Methods

	// RVA: 0x1DC4FF0 Offset: 0x1DC0FF0 VA: 0x1DC4FF0
	public void .ctor() { }

	// RVA: 0x1DC5630 Offset: 0x1DC1630 VA: 0x1DC5630
	internal bool <AddKerningPair>b__0(KerningPair item) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KerningTable.<>c__DisplayClass4_0 // TypeDefIndex: 5197
{
	// Fields
	public uint first; // 0x10
	public uint second; // 0x14

	// Methods

	// RVA: 0x1DC51F0 Offset: 0x1DC11F0 VA: 0x1DC51F0
	public void .ctor() { }

	// RVA: 0x1DC5668 Offset: 0x1DC1668 VA: 0x1DC5668
	internal bool <AddGlyphPairAdjustmentRecord>b__0(KerningPair item) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class KerningTable.<>c__DisplayClass5_0 // TypeDefIndex: 5198
{
	// Fields
	public int left; // 0x10
	public int right; // 0x14

	// Methods

	// RVA: 0x1DC5320 Offset: 0x1DC1320 VA: 0x1DC5320
	public void .ctor() { }

	// RVA: 0x1DC56A0 Offset: 0x1DC16A0 VA: 0x1DC56A0
	internal bool <RemoveKerningPair>b__0(KerningPair item) { }
}

// Namespace: TMPro
[Serializable]
public class KerningTable // TypeDefIndex: 5199
{
	// Fields
	public List<KerningPair> kerningPairs; // 0x10

	// Methods

	// RVA: 0x1DC4BD4 Offset: 0x1DC0BD4 VA: 0x1DC4BD4
	public void .ctor() { }

	// RVA: 0x1DC4C5C Offset: 0x1DC0C5C VA: 0x1DC4C5C
	public void AddKerningPair() { }

	// RVA: 0x1DC4E38 Offset: 0x1DC0E38 VA: 0x1DC4E38
	public int AddKerningPair(uint first, uint second, float offset) { }

	// RVA: 0x1DC4FF8 Offset: 0x1DC0FF8 VA: 0x1DC4FF8
	public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments) { }

	// RVA: 0x1DC51F8 Offset: 0x1DC11F8 VA: 0x1DC51F8
	public void RemoveKerningPair(int left, int right) { }

	// RVA: 0x1DC5328 Offset: 0x1DC1328 VA: 0x1DC5328
	public void RemoveKerningPair(int index) { }

	// RVA: 0x1DC5380 Offset: 0x1DC1380 VA: 0x1DC5380
	public void SortKerningPairs() { }
}

// Namespace: TMPro
public static class TMP_FontUtilities // TypeDefIndex: 5200
{
	// Fields
	private static List<int> k_searchedFontAssets; // 0x0

	// Methods

	// RVA: 0x1DC56D8 Offset: 0x1DC16D8 VA: 0x1DC56D8
	public static TMP_FontAsset SearchForCharacter(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0x1DC5AB8 Offset: 0x1DC1AB8 VA: 0x1DC5AB8
	public static TMP_FontAsset SearchForCharacter(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }

	// RVA: 0x1DC57C8 Offset: 0x1DC17C8 VA: 0x1DC57C8
	private static TMP_FontAsset SearchForCharacterInternal(TMP_FontAsset font, uint unicode, out TMP_Character character) { }

	// RVA: 0x1DC5ABC Offset: 0x1DC1ABC VA: 0x1DC5ABC
	private static TMP_FontAsset SearchForCharacterInternal(List<TMP_FontAsset> fonts, uint unicode, out TMP_Character character) { }
}

// Namespace: TMPro
public class TMP_FontAssetUtilities // TypeDefIndex: 5201
{
	// Fields
	private static readonly TMP_FontAssetUtilities s_Instance; // 0x0
	private static HashSet<int> k_SearchedAssets; // 0x8

	// Properties
	public static TMP_FontAssetUtilities instance { get; }

	// Methods

	// RVA: 0x1DC5BB8 Offset: 0x1DC1BB8 VA: 0x1DC5BB8
	private static void .cctor() { }

	// RVA: 0x1DC5C28 Offset: 0x1DC1C28 VA: 0x1DC5C28
	public static TMP_FontAssetUtilities get_instance() { }

	// RVA: 0x1DC5C80 Offset: 0x1DC1C80 VA: 0x1DC5C80
	public static TMP_Character GetCharacterFromFontAsset(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x1DC5DDC Offset: 0x1DC1DDC VA: 0x1DC5DDC
	private static TMP_Character GetCharacterFromFontAsset_Internal(uint unicode, TMP_FontAsset sourceFontAsset, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x1DC6248 Offset: 0x1DC2248 VA: 0x1DC6248
	private static TMP_Character SearchFallbacksForCharacter(uint unicode, TMP_FontAsset sourceFontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x1DC63E8 Offset: 0x1DC23E8 VA: 0x1DC63E8
	public static TMP_Character GetCharacterFromFontAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_FontAsset> fontAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x1DC6604 Offset: 0x1DC2604 VA: 0x1DC6604
	internal static TMP_TextElement GetTextElementFromTextAssets(uint unicode, TMP_FontAsset sourceFontAsset, List<TMP_Asset> textAssets, bool includeFallbacks, FontStyles fontStyle, FontWeight fontWeight, out bool isAlternativeTypeface) { }

	// RVA: 0x1DC6B0C Offset: 0x1DC2B0C VA: 0x1DC6B0C
	public static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x1DC6938 Offset: 0x1DC2938 VA: 0x1DC6938
	private static TMP_SpriteCharacter GetSpriteCharacterFromSpriteAsset_Internal(uint unicode, TMP_SpriteAsset spriteAsset, bool includeFallbacks) { }

	// RVA: 0x1DC6E08 Offset: 0x1DC2E08 VA: 0x1DC6E08
	internal static uint GetCodePoint(string text, ref int index) { }

	// RVA: 0x1DC6F08 Offset: 0x1DC2F08 VA: 0x1DC6F08
	internal static uint GetCodePoint(uint[] codesPoints, ref int index) { }

	// RVA: 0x1DC5C20 Offset: 0x1DC1C20 VA: 0x1DC5C20
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TMP_FontFeatureTable.<>c // TypeDefIndex: 5202
{
	// Fields
	public static readonly TMP_FontFeatureTable.<>c <>9; // 0x0
	public static Func<GlyphPairAdjustmentRecord, uint> <>9__25_0; // 0x8
	public static Func<GlyphPairAdjustmentRecord, uint> <>9__25_1; // 0x10
	public static Func<MarkToBaseAdjustmentRecord, uint> <>9__26_0; // 0x18
	public static Func<MarkToBaseAdjustmentRecord, uint> <>9__26_1; // 0x20
	public static Func<MarkToMarkAdjustmentRecord, uint> <>9__27_0; // 0x28
	public static Func<MarkToMarkAdjustmentRecord, uint> <>9__27_1; // 0x30

	// Methods

	// RVA: 0x1DC7954 Offset: 0x1DC3954 VA: 0x1DC7954
	private static void .cctor() { }

	// RVA: 0x1DC79BC Offset: 0x1DC39BC VA: 0x1DC79BC
	public void .ctor() { }

	// RVA: 0x1DC79C4 Offset: 0x1DC39C4 VA: 0x1DC79C4
	internal uint <SortGlyphPairAdjustmentRecords>b__25_0(GlyphPairAdjustmentRecord s) { }

	// RVA: 0x1DC7A0C Offset: 0x1DC3A0C VA: 0x1DC7A0C
	internal uint <SortGlyphPairAdjustmentRecords>b__25_1(GlyphPairAdjustmentRecord s) { }

	// RVA: 0x1DC7A54 Offset: 0x1DC3A54 VA: 0x1DC7A54
	internal uint <SortMarkToBaseAdjustmentRecords>b__26_0(MarkToBaseAdjustmentRecord s) { }

	// RVA: 0x1DC7A5C Offset: 0x1DC3A5C VA: 0x1DC7A5C
	internal uint <SortMarkToBaseAdjustmentRecords>b__26_1(MarkToBaseAdjustmentRecord s) { }

	// RVA: 0x1DC7A64 Offset: 0x1DC3A64 VA: 0x1DC7A64
	internal uint <SortMarkToMarkAdjustmentRecords>b__27_0(MarkToMarkAdjustmentRecord s) { }

	// RVA: 0x1DC7A6C Offset: 0x1DC3A6C VA: 0x1DC7A6C
	internal uint <SortMarkToMarkAdjustmentRecords>b__27_1(MarkToMarkAdjustmentRecord s) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_FontFeatureTable // TypeDefIndex: 5203
{
	// Fields
	[SerializeField]
	internal List<MultipleSubstitutionRecord> m_MultipleSubstitutionRecords; // 0x10
	[SerializeField]
	internal List<LigatureSubstitutionRecord> m_LigatureSubstitutionRecords; // 0x18
	[SerializeField]
	internal List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x20
	[SerializeField]
	internal List<MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords; // 0x28
	[SerializeField]
	internal List<MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords; // 0x30
	internal Dictionary<uint, List<LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup; // 0x38
	internal Dictionary<uint, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; // 0x40
	internal Dictionary<uint, MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup; // 0x48
	internal Dictionary<uint, MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup; // 0x50

	// Properties
	public List<MultipleSubstitutionRecord> multipleSubstitutionRecords { get; set; }
	public List<LigatureSubstitutionRecord> ligatureRecords { get; set; }
	public List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; }
	public List<MarkToBaseAdjustmentRecord> MarkToBaseAdjustmentRecords { get; set; }
	public List<MarkToMarkAdjustmentRecord> MarkToMarkAdjustmentRecords { get; set; }

	// Methods

	// RVA: 0x1DC7008 Offset: 0x1DC3008 VA: 0x1DC7008
	public List<MultipleSubstitutionRecord> get_multipleSubstitutionRecords() { }

	// RVA: 0x1DC7010 Offset: 0x1DC3010 VA: 0x1DC7010
	public void set_multipleSubstitutionRecords(List<MultipleSubstitutionRecord> value) { }

	// RVA: 0x1DC7018 Offset: 0x1DC3018 VA: 0x1DC7018
	public List<LigatureSubstitutionRecord> get_ligatureRecords() { }

	// RVA: 0x1DC7020 Offset: 0x1DC3020 VA: 0x1DC7020
	public void set_ligatureRecords(List<LigatureSubstitutionRecord> value) { }

	// RVA: 0x1DC7028 Offset: 0x1DC3028 VA: 0x1DC7028
	public List<GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	// RVA: 0x1DC7030 Offset: 0x1DC3030 VA: 0x1DC7030
	public void set_glyphPairAdjustmentRecords(List<GlyphPairAdjustmentRecord> value) { }

	// RVA: 0x1DC7038 Offset: 0x1DC3038 VA: 0x1DC7038
	public List<MarkToBaseAdjustmentRecord> get_MarkToBaseAdjustmentRecords() { }

	// RVA: 0x1DC7040 Offset: 0x1DC3040 VA: 0x1DC7040
	public void set_MarkToBaseAdjustmentRecords(List<MarkToBaseAdjustmentRecord> value) { }

	// RVA: 0x1DC7048 Offset: 0x1DC3048 VA: 0x1DC7048
	public List<MarkToMarkAdjustmentRecord> get_MarkToMarkAdjustmentRecords() { }

	// RVA: 0x1DC7050 Offset: 0x1DC3050 VA: 0x1DC7050
	public void set_MarkToMarkAdjustmentRecords(List<MarkToMarkAdjustmentRecord> value) { }

	// RVA: 0x1DC7058 Offset: 0x1DC3058 VA: 0x1DC7058
	public void .ctor() { }

	// RVA: 0x1DC730C Offset: 0x1DC330C VA: 0x1DC730C
	public void SortGlyphPairAdjustmentRecords() { }

	// RVA: 0x1DC7524 Offset: 0x1DC3524 VA: 0x1DC7524
	public void SortMarkToBaseAdjustmentRecords() { }

	// RVA: 0x1DC773C Offset: 0x1DC373C VA: 0x1DC773C
	public void SortMarkToMarkAdjustmentRecords() { }
}

// Namespace: TMPro
[Flags]
public enum FontFeatureLookupFlags // TypeDefIndex: 5204
{
	// Fields
	public int value__; // 0x0
	public const FontFeatureLookupFlags None = 0;
	public const FontFeatureLookupFlags IgnoreLigatures = 4;
	public const FontFeatureLookupFlags IgnoreSpacingAdjustments = 256;
}

// Namespace: TMPro
[Serializable]
public struct TMP_GlyphValueRecord // TypeDefIndex: 5205
{
	// Fields
	[SerializeField]
	internal float m_XPlacement; // 0x0
	[SerializeField]
	internal float m_YPlacement; // 0x4
	[SerializeField]
	internal float m_XAdvance; // 0x8
	[SerializeField]
	internal float m_YAdvance; // 0xC

	// Properties
	public float xPlacement { get; set; }
	public float yPlacement { get; set; }
	public float xAdvance { get; set; }
	public float yAdvance { get; set; }

	// Methods

	// RVA: 0x1DC7A74 Offset: 0x1DC3A74 VA: 0x1DC7A74
	public float get_xPlacement() { }

	// RVA: 0x1DC7A7C Offset: 0x1DC3A7C VA: 0x1DC7A7C
	public void set_xPlacement(float value) { }

	// RVA: 0x1DC7A84 Offset: 0x1DC3A84 VA: 0x1DC7A84
	public float get_yPlacement() { }

	// RVA: 0x1DC7A8C Offset: 0x1DC3A8C VA: 0x1DC7A8C
	public void set_yPlacement(float value) { }

	// RVA: 0x1DC7A94 Offset: 0x1DC3A94 VA: 0x1DC7A94
	public float get_xAdvance() { }

	// RVA: 0x1DC7A9C Offset: 0x1DC3A9C VA: 0x1DC7A9C
	public void set_xAdvance(float value) { }

	// RVA: 0x1DC7AA4 Offset: 0x1DC3AA4 VA: 0x1DC7AA4
	public float get_yAdvance() { }

	// RVA: 0x1DC7AAC Offset: 0x1DC3AAC VA: 0x1DC7AAC
	public void set_yAdvance(float value) { }

	// RVA: 0x1DC7AB4 Offset: 0x1DC3AB4 VA: 0x1DC7AB4
	public void .ctor(float xPlacement, float yPlacement, float xAdvance, float yAdvance) { }

	// RVA: 0x1DC7AC0 Offset: 0x1DC3AC0 VA: 0x1DC7AC0
	internal void .ctor(GlyphValueRecord_Legacy valueRecord) { }

	// RVA: 0x1DC7ACC Offset: 0x1DC3ACC VA: 0x1DC7ACC
	internal void .ctor(GlyphValueRecord valueRecord) { }

	// RVA: 0x1DC7B2C Offset: 0x1DC3B2C VA: 0x1DC7B2C
	public static TMP_GlyphValueRecord op_Addition(TMP_GlyphValueRecord a, TMP_GlyphValueRecord b) { }
}

// Namespace: TMPro
[Serializable]
public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 5206
{
	// Fields
	[SerializeField]
	internal uint m_GlyphIndex; // 0x0
	[SerializeField]
	internal TMP_GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; set; }
	public TMP_GlyphValueRecord glyphValueRecord { get; set; }

	// Methods

	// RVA: 0x1DC7B40 Offset: 0x1DC3B40 VA: 0x1DC7B40
	public uint get_glyphIndex() { }

	// RVA: 0x1DC7B48 Offset: 0x1DC3B48 VA: 0x1DC7B48
	public void set_glyphIndex(uint value) { }

	// RVA: 0x1DC7B50 Offset: 0x1DC3B50 VA: 0x1DC7B50
	public TMP_GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0x1DC7B5C Offset: 0x1DC3B5C VA: 0x1DC7B5C
	public void set_glyphValueRecord(TMP_GlyphValueRecord value) { }

	// RVA: 0x1DC7B68 Offset: 0x1DC3B68 VA: 0x1DC7B68
	public void .ctor(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord) { }

	// RVA: 0x1DC7B78 Offset: 0x1DC3B78 VA: 0x1DC7B78
	internal void .ctor(GlyphAdjustmentRecord adjustmentRecord) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 5207
{
	// Fields
	[SerializeField]
	internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
	[SerializeField]
	internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
	[SerializeField]
	internal FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38

	// Properties
	public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
	public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; }
	public FontFeatureLookupFlags featureLookupFlags { get; set; }

	// Methods

	// RVA: 0x1DC7BCC Offset: 0x1DC3BCC VA: 0x1DC7BCC
	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x1DC7BE0 Offset: 0x1DC3BE0 VA: 0x1DC7BE0
	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x1DC7BF4 Offset: 0x1DC3BF4 VA: 0x1DC7BF4
	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0x1DC7C08 Offset: 0x1DC3C08 VA: 0x1DC7C08
	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x1DC7C1C Offset: 0x1DC3C1C VA: 0x1DC7C1C
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0x1DC7C24 Offset: 0x1DC3C24 VA: 0x1DC7C24
	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	// RVA: 0x1DC7C2C Offset: 0x1DC3C2C VA: 0x1DC7C2C
	public void .ctor(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	// RVA: 0x1DC7C74 Offset: 0x1DC3C74 VA: 0x1DC7C74
	internal void .ctor(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }
}

// Namespace: TMPro
public struct GlyphPairKey // TypeDefIndex: 5208
{
	// Fields
	public uint firstGlyphIndex; // 0x0
	public uint secondGlyphIndex; // 0x4
	public uint key; // 0x8

	// Methods

	// RVA: 0x1DC7D28 Offset: 0x1DC3D28 VA: 0x1DC7D28
	public void .ctor(uint firstGlyphIndex, uint secondGlyphIndex) { }

	// RVA: 0x1DC7D38 Offset: 0x1DC3D38 VA: 0x1DC7D38
	internal void .ctor(TMP_GlyphPairAdjustmentRecord record) { }
}

// Namespace: 
public enum TMP_InputField.ContentType // TypeDefIndex: 5209
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.ContentType Standard = 0;
	public const TMP_InputField.ContentType Autocorrected = 1;
	public const TMP_InputField.ContentType IntegerNumber = 2;
	public const TMP_InputField.ContentType DecimalNumber = 3;
	public const TMP_InputField.ContentType Alphanumeric = 4;
	public const TMP_InputField.ContentType Name = 5;
	public const TMP_InputField.ContentType EmailAddress = 6;
	public const TMP_InputField.ContentType Password = 7;
	public const TMP_InputField.ContentType Pin = 8;
	public const TMP_InputField.ContentType Custom = 9;
}

// Namespace: 
public enum TMP_InputField.InputType // TypeDefIndex: 5210
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.InputType Standard = 0;
	public const TMP_InputField.InputType AutoCorrect = 1;
	public const TMP_InputField.InputType Password = 2;
}

// Namespace: 
public enum TMP_InputField.CharacterValidation // TypeDefIndex: 5211
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.CharacterValidation None = 0;
	public const TMP_InputField.CharacterValidation Digit = 1;
	public const TMP_InputField.CharacterValidation Integer = 2;
	public const TMP_InputField.CharacterValidation Decimal = 3;
	public const TMP_InputField.CharacterValidation Alphanumeric = 4;
	public const TMP_InputField.CharacterValidation Name = 5;
	public const TMP_InputField.CharacterValidation Regex = 6;
	public const TMP_InputField.CharacterValidation EmailAddress = 7;
	public const TMP_InputField.CharacterValidation CustomValidator = 8;
}

// Namespace: 
public enum TMP_InputField.LineType // TypeDefIndex: 5212
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.LineType SingleLine = 0;
	public const TMP_InputField.LineType MultiLineSubmit = 1;
	public const TMP_InputField.LineType MultiLineNewline = 2;
}

// Namespace: 
public sealed class TMP_InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 5213
{
	// Methods

	// RVA: 0x1DF5AE0 Offset: 0x1DF1AE0 VA: 0x1DF5AE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1DF5B94 Offset: 0x1DF1B94 VA: 0x1DF5B94 Slot: 12
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0x1DF5BA8 Offset: 0x1DF1BA8 VA: 0x1DF5BA8 Slot: 13
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0x1DF5C2C Offset: 0x1DF1C2C VA: 0x1DF5C2C Slot: 14
	public virtual char EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[Serializable]
public class TMP_InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 5214
{
	// Methods

	// RVA: 0x1DF5C54 Offset: 0x1DF1C54 VA: 0x1DF5C54
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 5215
{
	// Methods

	// RVA: 0x1DF5C9C Offset: 0x1DF1C9C VA: 0x1DF5C9C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_InputField.SelectionEvent : UnityEvent<string> // TypeDefIndex: 5216
{
	// Methods

	// RVA: 0x1DF5CE4 Offset: 0x1DF1CE4 VA: 0x1DF5CE4
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_InputField.TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 5217
{
	// Methods

	// RVA: 0x1DF5D2C Offset: 0x1DF1D2C VA: 0x1DF5D2C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class TMP_InputField.TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 5218
{
	// Methods

	// RVA: 0x1DF5D74 Offset: 0x1DF1D74 VA: 0x1DF5D74
	public void .ctor() { }
}

// Namespace: 
protected enum TMP_InputField.EditState // TypeDefIndex: 5219
{
	// Fields
	public int value__; // 0x0
	public const TMP_InputField.EditState Continue = 0;
	public const TMP_InputField.EditState Finish = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_InputField.<CaretBlink>d__295 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5220
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TMP_InputField <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1DF5DBC Offset: 0x1DF1DBC VA: 0x1DF5DBC
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1DF5DE4 Offset: 0x1DF1DE4 VA: 0x1DF5DE4 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1DF5DE8 Offset: 0x1DF1DE8 VA: 0x1DF5DE8 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DF5F0C Offset: 0x1DF1F0C VA: 0x1DF5F0C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1DF5F14 Offset: 0x1DF1F14 VA: 0x1DF5F14 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1DF5F4C Offset: 0x1DF1F4C VA: 0x1DF5F4C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_InputField.<MouseDragOutsideRect>d__316 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5221
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TMP_InputField <>4__this; // 0x20
	public PointerEventData eventData; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1DF5F54 Offset: 0x1DF1F54 VA: 0x1DF5F54
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1DF5F7C Offset: 0x1DF1F7C VA: 0x1DF5F7C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1DF5F80 Offset: 0x1DF1F80 VA: 0x1DF5F80 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DF61C8 Offset: 0x1DF21C8 VA: 0x1DF61C8 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1DF61D0 Offset: 0x1DF21D0 VA: 0x1DF61D0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1DF6208 Offset: 0x1DF2208 VA: 0x1DF6208 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: TMPro
[AddComponentMenu("UI/TextMeshPro - Input Field", 11)]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/index.html")]
public class TMP_InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICancelHandler, ICanvasElement, ILayoutElement, IScrollHandler // TypeDefIndex: 5222
{
	// Fields
	protected TouchScreenKeyboard m_SoftKeyboard; // 0x100
	private static readonly char[] kSeparators; // 0x0
	private static bool s_IsQuestDeviceEvaluated; // 0x8
	private static bool s_IsQuestDevice; // 0x9
	protected RectTransform m_RectTransform; // 0x108
	[SerializeField]
	protected RectTransform m_TextViewport; // 0x110
	protected RectMask2D m_TextComponentRectMask; // 0x118
	protected RectMask2D m_TextViewportRectMask; // 0x120
	[SerializeField]
	protected TMP_Text m_TextComponent; // 0x128
	protected RectTransform m_TextComponentRectTransform; // 0x130
	[SerializeField]
	protected Graphic m_Placeholder; // 0x138
	[SerializeField]
	protected Scrollbar m_VerticalScrollbar; // 0x140
	[SerializeField]
	protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x148
	private bool m_IsDrivenByLayoutComponents; // 0x150
	[SerializeField]
	private LayoutGroup m_LayoutGroup; // 0x158
	private IScrollHandler m_IScrollHandlerParent; // 0x160
	private float m_ScrollPosition; // 0x168
	[SerializeField]
	protected float m_ScrollSensitivity; // 0x16C
	[SerializeField]
	private TMP_InputField.ContentType m_ContentType; // 0x170
	[SerializeField]
	private TMP_InputField.InputType m_InputType; // 0x174
	[SerializeField]
	private char m_AsteriskChar; // 0x178
	[SerializeField]
	private TouchScreenKeyboardType m_KeyboardType; // 0x17C
	[SerializeField]
	private TMP_InputField.LineType m_LineType; // 0x180
	[SerializeField]
	private bool m_HideMobileInput; // 0x184
	[SerializeField]
	private bool m_HideSoftKeyboard; // 0x185
	[SerializeField]
	private TMP_InputField.CharacterValidation m_CharacterValidation; // 0x188
	[SerializeField]
	private string m_RegexValue; // 0x190
	[SerializeField]
	private float m_GlobalPointSize; // 0x198
	[SerializeField]
	private int m_CharacterLimit; // 0x19C
	[SerializeField]
	private TMP_InputField.SubmitEvent m_OnEndEdit; // 0x1A0
	[SerializeField]
	private TMP_InputField.SubmitEvent m_OnSubmit; // 0x1A8
	[SerializeField]
	private TMP_InputField.SelectionEvent m_OnSelect; // 0x1B0
	[SerializeField]
	private TMP_InputField.SelectionEvent m_OnDeselect; // 0x1B8
	[SerializeField]
	private TMP_InputField.TextSelectionEvent m_OnTextSelection; // 0x1C0
	[SerializeField]
	private TMP_InputField.TextSelectionEvent m_OnEndTextSelection; // 0x1C8
	[SerializeField]
	private TMP_InputField.OnChangeEvent m_OnValueChanged; // 0x1D0
	[SerializeField]
	private TMP_InputField.TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x1D8
	[SerializeField]
	private TMP_InputField.OnValidateInput m_OnValidateInput; // 0x1E0
	[SerializeField]
	private Color m_CaretColor; // 0x1E8
	[SerializeField]
	private bool m_CustomCaretColor; // 0x1F8
	[SerializeField]
	private Color m_SelectionColor; // 0x1FC
	[SerializeField]
	[TextArea(5, 10)]
	protected string m_Text; // 0x210
	[SerializeField]
	[Range(0, 4)]
	private float m_CaretBlinkRate; // 0x218
	[SerializeField]
	[Range(1, 5)]
	private int m_CaretWidth; // 0x21C
	[SerializeField]
	private bool m_ReadOnly; // 0x220
	[SerializeField]
	private bool m_RichText; // 0x221
	protected int m_StringPosition; // 0x224
	protected int m_StringSelectPosition; // 0x228
	protected int m_CaretPosition; // 0x22C
	protected int m_CaretSelectPosition; // 0x230
	private RectTransform caretRectTrans; // 0x238
	protected UIVertex[] m_CursorVerts; // 0x240
	private CanvasRenderer m_CachedInputRenderer; // 0x248
	private Vector2 m_LastPosition; // 0x250
	protected Mesh m_Mesh; // 0x258
	private bool m_AllowInput; // 0x260
	private bool m_ShouldActivateNextUpdate; // 0x261
	private bool m_UpdateDrag; // 0x262
	private bool m_DragPositionOutOfBounds; // 0x263
	private const float kHScrollSpeed = 0.05;
	private const float kVScrollSpeed = 0.1;
	protected bool m_CaretVisible; // 0x264
	private Coroutine m_BlinkCoroutine; // 0x268
	private float m_BlinkStartTime; // 0x270
	private Coroutine m_DragCoroutine; // 0x278
	private string m_OriginalText; // 0x280
	private bool m_WasCanceled; // 0x288
	private bool m_HasDoneFocusTransition; // 0x289
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x290
	private bool m_PreventCallback; // 0x298
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x299
	private bool m_IsTextComponentUpdateRequired; // 0x29A
	private bool m_HasTextBeenRemoved; // 0x29B
	private float m_PointerDownClickStartTime; // 0x29C
	private float m_KeyDownStartTime; // 0x2A0
	private float m_DoubleClickDelay; // 0x2A4
	private bool m_IsApplePlatform; // 0x2A8
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private const string kOculusQuestDeviceModel = "Oculus Quest";
	private bool m_IsCompositionActive; // 0x2A9
	private bool m_ShouldUpdateIMEWindowPosition; // 0x2AA
	private int m_PreviousIMEInsertionLine; // 0x2AC
	[SerializeField]
	protected TMP_FontAsset m_GlobalFontAsset; // 0x2B0
	[SerializeField]
	protected bool m_OnFocusSelectAll; // 0x2B8
	protected bool m_isSelectAll; // 0x2B9
	[SerializeField]
	protected bool m_ResetOnDeActivation; // 0x2BA
	private bool m_SelectionStillActive; // 0x2BB
	private bool m_ReleaseSelection; // 0x2BC
	private KeyCode m_LastKeyCode; // 0x2C0
	private GameObject m_PreviouslySelectedObject; // 0x2C8
	[SerializeField]
	private bool m_KeepTextSelectionVisible; // 0x2D0
	[SerializeField]
	private bool m_RestoreOriginalTextOnEscape; // 0x2D1
	[SerializeField]
	protected bool m_isRichTextEditingAllowed; // 0x2D2
	[SerializeField]
	protected int m_LineLimit; // 0x2D4
	public bool isAlert; // 0x2D8
	[SerializeField]
	protected TMP_InputValidator m_InputValidator; // 0x2E0
	[SerializeField]
	private bool m_ShouldActivateOnSelect; // 0x2E8
	private bool m_isSelected; // 0x2E9
	private bool m_IsStringPositionDirty; // 0x2EA
	private bool m_IsCaretPositionDirty; // 0x2EB
	private bool m_forceRectTransformAdjustment; // 0x2EC
	private bool m_IsKeyboardBeingClosedInHoloLens; // 0x2ED
	private Event m_ProcessingEvent; // 0x2F0

	// Properties
	private BaseInput inputSystem { get; }
	private string compositionString { get; }
	private int compositionLength { get; }
	protected Mesh mesh { get; }
	public virtual bool shouldActivateOnSelect { get; set; }
	public bool shouldHideMobileInput { get; set; }
	public bool shouldHideSoftKeyboard { get; set; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public RectTransform textViewport { get; set; }
	public TMP_Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public float scrollSensitivity { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public TMP_InputField.SubmitEvent onEndEdit { get; set; }
	public TMP_InputField.SubmitEvent onSubmit { get; set; }
	public TMP_InputField.SelectionEvent onSelect { get; set; }
	public TMP_InputField.SelectionEvent onDeselect { get; set; }
	public TMP_InputField.TextSelectionEvent onTextSelection { get; set; }
	public TMP_InputField.TextSelectionEvent onEndTextSelection { get; set; }
	public TMP_InputField.OnChangeEvent onValueChanged { get; set; }
	public TMP_InputField.TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get; set; }
	public TMP_InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public float pointSize { get; set; }
	public TMP_FontAsset fontAsset { get; set; }
	public bool onFocusSelectAll { get; set; }
	public bool resetOnDeActivation { get; set; }
	public bool keepTextSelectionVisible { get; set; }
	public bool restoreOriginalTextOnEscape { get; set; }
	public bool isRichTextEditingAllowed { get; set; }
	public TMP_InputField.ContentType contentType { get; set; }
	public TMP_InputField.LineType lineType { get; set; }
	public int lineLimit { get; set; }
	public TMP_InputField.InputType inputType { get; set; }
	public TouchScreenKeyboard touchScreenKeyboard { get; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public TMP_InputField.CharacterValidation characterValidation { get; set; }
	public TMP_InputValidator inputValidator { get; set; }
	public bool readOnly { get; set; }
	public bool richText { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int stringPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	protected int stringSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	public int stringPosition { get; set; }
	public int selectionStringAnchorPosition { get; set; }
	public int selectionStringFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x1DC7D5C Offset: 0x1DC3D5C VA: 0x1DC7D5C
	private BaseInput get_inputSystem() { }

	// RVA: 0x1DC7E6C Offset: 0x1DC3E6C VA: 0x1DC7E6C
	private string get_compositionString() { }

	// RVA: 0x1DC7F00 Offset: 0x1DC3F00 VA: 0x1DC7F00
	private int get_compositionLength() { }

	// RVA: 0x1DC7F2C Offset: 0x1DC3F2C VA: 0x1DC7F2C
	protected void .ctor() { }

	// RVA: 0x1DC82CC Offset: 0x1DC42CC VA: 0x1DC82CC
	protected Mesh get_mesh() { }

	// RVA: 0x1DC8374 Offset: 0x1DC4374 VA: 0x1DC8374 Slot: 61
	public virtual void set_shouldActivateOnSelect(bool value) { }

	// RVA: 0x1DC837C Offset: 0x1DC437C VA: 0x1DC837C Slot: 62
	public virtual bool get_shouldActivateOnSelect() { }

	// RVA: 0x1DC83EC Offset: 0x1DC43EC VA: 0x1DC83EC
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x1DC8484 Offset: 0x1DC4484 VA: 0x1DC8484
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x1DC854C Offset: 0x1DC454C VA: 0x1DC854C
	public bool get_shouldHideSoftKeyboard() { }

	// RVA: 0x1DC862C Offset: 0x1DC462C VA: 0x1DC862C
	public void set_shouldHideSoftKeyboard(bool value) { }

	// RVA: 0x1DC8790 Offset: 0x1DC4790 VA: 0x1DC8790
	private bool isKeyboardUsingEvents() { }

	// RVA: 0x1DC891C Offset: 0x1DC491C VA: 0x1DC891C
	private bool isUWP() { }

	// RVA: 0x1DC89C0 Offset: 0x1DC49C0 VA: 0x1DC89C0
	public string get_text() { }

	// RVA: 0x1DC89C8 Offset: 0x1DC49C8 VA: 0x1DC89C8
	public void set_text(string value) { }

	// RVA: 0x1DC8B04 Offset: 0x1DC4B04 VA: 0x1DC8B04
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x1DC89D0 Offset: 0x1DC49D0 VA: 0x1DC89D0
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0x1DC900C Offset: 0x1DC500C VA: 0x1DC900C
	public bool get_isFocused() { }

	// RVA: 0x1DC9014 Offset: 0x1DC5014 VA: 0x1DC9014
	public float get_caretBlinkRate() { }

	// RVA: 0x1DC901C Offset: 0x1DC501C VA: 0x1DC901C
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x1DC90F8 Offset: 0x1DC50F8 VA: 0x1DC90F8
	public int get_caretWidth() { }

	// RVA: 0x1DC9100 Offset: 0x1DC5100 VA: 0x1DC9100
	public void set_caretWidth(int value) { }

	// RVA: 0x1DC91CC Offset: 0x1DC51CC VA: 0x1DC91CC
	public RectTransform get_textViewport() { }

	// RVA: 0x1DC91D4 Offset: 0x1DC51D4 VA: 0x1DC91D4
	public void set_textViewport(RectTransform value) { }

	// RVA: 0x1DC922C Offset: 0x1DC522C VA: 0x1DC922C
	public TMP_Text get_textComponent() { }

	// RVA: 0x1DC9234 Offset: 0x1DC5234 VA: 0x1DC9234
	public void set_textComponent(TMP_Text value) { }

	// RVA: 0x1DC92A8 Offset: 0x1DC52A8 VA: 0x1DC92A8
	public Graphic get_placeholder() { }

	// RVA: 0x1DC92B0 Offset: 0x1DC52B0 VA: 0x1DC92B0
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1DC9308 Offset: 0x1DC5308 VA: 0x1DC9308
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x1DC9310 Offset: 0x1DC5310 VA: 0x1DC9310
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x1DC94B4 Offset: 0x1DC54B4 VA: 0x1DC94B4
	public float get_scrollSensitivity() { }

	// RVA: 0x1DC94BC Offset: 0x1DC54BC VA: 0x1DC94BC
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x1DC9530 Offset: 0x1DC5530 VA: 0x1DC9530
	public Color get_caretColor() { }

	// RVA: 0x1DC9574 Offset: 0x1DC5574 VA: 0x1DC9574
	public void set_caretColor(Color value) { }

	// RVA: 0x1DC95A0 Offset: 0x1DC55A0 VA: 0x1DC95A0
	public bool get_customCaretColor() { }

	// RVA: 0x1DC95A8 Offset: 0x1DC55A8 VA: 0x1DC95A8
	public void set_customCaretColor(bool value) { }

	// RVA: 0x1DC95C4 Offset: 0x1DC55C4 VA: 0x1DC95C4
	public Color get_selectionColor() { }

	// RVA: 0x1DC95D8 Offset: 0x1DC55D8 VA: 0x1DC95D8
	public void set_selectionColor(Color value) { }

	// RVA: 0x1DC9604 Offset: 0x1DC5604 VA: 0x1DC9604
	public TMP_InputField.SubmitEvent get_onEndEdit() { }

	// RVA: 0x1DC960C Offset: 0x1DC560C VA: 0x1DC960C
	public void set_onEndEdit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0x1DC9664 Offset: 0x1DC5664 VA: 0x1DC9664
	public TMP_InputField.SubmitEvent get_onSubmit() { }

	// RVA: 0x1DC966C Offset: 0x1DC566C VA: 0x1DC966C
	public void set_onSubmit(TMP_InputField.SubmitEvent value) { }

	// RVA: 0x1DC96C4 Offset: 0x1DC56C4 VA: 0x1DC96C4
	public TMP_InputField.SelectionEvent get_onSelect() { }

	// RVA: 0x1DC96CC Offset: 0x1DC56CC VA: 0x1DC96CC
	public void set_onSelect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x1DC9724 Offset: 0x1DC5724 VA: 0x1DC9724
	public TMP_InputField.SelectionEvent get_onDeselect() { }

	// RVA: 0x1DC972C Offset: 0x1DC572C VA: 0x1DC972C
	public void set_onDeselect(TMP_InputField.SelectionEvent value) { }

	// RVA: 0x1DC9784 Offset: 0x1DC5784 VA: 0x1DC9784
	public TMP_InputField.TextSelectionEvent get_onTextSelection() { }

	// RVA: 0x1DC978C Offset: 0x1DC578C VA: 0x1DC978C
	public void set_onTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0x1DC97E4 Offset: 0x1DC57E4 VA: 0x1DC97E4
	public TMP_InputField.TextSelectionEvent get_onEndTextSelection() { }

	// RVA: 0x1DC97EC Offset: 0x1DC57EC VA: 0x1DC97EC
	public void set_onEndTextSelection(TMP_InputField.TextSelectionEvent value) { }

	// RVA: 0x1DC9844 Offset: 0x1DC5844 VA: 0x1DC9844
	public TMP_InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x1DC984C Offset: 0x1DC584C VA: 0x1DC984C
	public void set_onValueChanged(TMP_InputField.OnChangeEvent value) { }

	// RVA: 0x1DC98A4 Offset: 0x1DC58A4 VA: 0x1DC98A4
	public TMP_InputField.TouchScreenKeyboardEvent get_onTouchScreenKeyboardStatusChanged() { }

	// RVA: 0x1DC98AC Offset: 0x1DC58AC VA: 0x1DC98AC
	public void set_onTouchScreenKeyboardStatusChanged(TMP_InputField.TouchScreenKeyboardEvent value) { }

	// RVA: 0x1DC9904 Offset: 0x1DC5904 VA: 0x1DC9904
	public TMP_InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x1DC990C Offset: 0x1DC590C VA: 0x1DC990C
	public void set_onValidateInput(TMP_InputField.OnValidateInput value) { }

	// RVA: 0x1DC9964 Offset: 0x1DC5964 VA: 0x1DC9964
	public int get_characterLimit() { }

	// RVA: 0x1DC996C Offset: 0x1DC596C VA: 0x1DC996C
	public void set_characterLimit(int value) { }

	// RVA: 0x1DC9A28 Offset: 0x1DC5A28 VA: 0x1DC9A28
	public float get_pointSize() { }

	// RVA: 0x1DC9A30 Offset: 0x1DC5A30 VA: 0x1DC9A30
	public void set_pointSize(float value) { }

	// RVA: 0x1DC9BC8 Offset: 0x1DC5BC8 VA: 0x1DC9BC8
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x1DC9BD0 Offset: 0x1DC5BD0 VA: 0x1DC9BD0
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x1DC9D30 Offset: 0x1DC5D30 VA: 0x1DC9D30
	public bool get_onFocusSelectAll() { }

	// RVA: 0x1DC9D38 Offset: 0x1DC5D38 VA: 0x1DC9D38
	public void set_onFocusSelectAll(bool value) { }

	// RVA: 0x1DC9D40 Offset: 0x1DC5D40 VA: 0x1DC9D40
	public bool get_resetOnDeActivation() { }

	// RVA: 0x1DC9D48 Offset: 0x1DC5D48 VA: 0x1DC9D48
	public void set_resetOnDeActivation(bool value) { }

	// RVA: 0x1DC9D50 Offset: 0x1DC5D50 VA: 0x1DC9D50
	public bool get_keepTextSelectionVisible() { }

	// RVA: 0x1DC9D58 Offset: 0x1DC5D58 VA: 0x1DC9D58
	public void set_keepTextSelectionVisible(bool value) { }

	// RVA: 0x1DC9D60 Offset: 0x1DC5D60 VA: 0x1DC9D60
	public bool get_restoreOriginalTextOnEscape() { }

	// RVA: 0x1DC9D68 Offset: 0x1DC5D68 VA: 0x1DC9D68
	public void set_restoreOriginalTextOnEscape(bool value) { }

	// RVA: 0x1DC9D70 Offset: 0x1DC5D70 VA: 0x1DC9D70
	public bool get_isRichTextEditingAllowed() { }

	// RVA: 0x1DC9D78 Offset: 0x1DC5D78 VA: 0x1DC9D78
	public void set_isRichTextEditingAllowed(bool value) { }

	// RVA: 0x1DC9D80 Offset: 0x1DC5D80 VA: 0x1DC9D80
	public TMP_InputField.ContentType get_contentType() { }

	// RVA: 0x1DC9D88 Offset: 0x1DC5D88 VA: 0x1DC9D88
	public void set_contentType(TMP_InputField.ContentType value) { }

	// RVA: 0x1DC9F04 Offset: 0x1DC5F04 VA: 0x1DC9F04
	public TMP_InputField.LineType get_lineType() { }

	// RVA: 0x1DC9F0C Offset: 0x1DC5F0C VA: 0x1DC9F0C
	public void set_lineType(TMP_InputField.LineType value) { }

	// RVA: 0x1DCA034 Offset: 0x1DC6034 VA: 0x1DCA034
	public int get_lineLimit() { }

	// RVA: 0x1DCA03C Offset: 0x1DC603C VA: 0x1DCA03C
	public void set_lineLimit(int value) { }

	// RVA: 0x1DCA0A8 Offset: 0x1DC60A8 VA: 0x1DCA0A8
	public TMP_InputField.InputType get_inputType() { }

	// RVA: 0x1DCA0B0 Offset: 0x1DC60B0 VA: 0x1DCA0B0
	public void set_inputType(TMP_InputField.InputType value) { }

	// RVA: 0x1DCA14C Offset: 0x1DC614C VA: 0x1DCA14C
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0x1DCA154 Offset: 0x1DC6154 VA: 0x1DCA154
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x1DCA15C Offset: 0x1DC615C VA: 0x1DCA15C
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x1DCA1E0 Offset: 0x1DC61E0 VA: 0x1DCA1E0
	public TMP_InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x1DCA1E8 Offset: 0x1DC61E8 VA: 0x1DCA1E8
	public void set_characterValidation(TMP_InputField.CharacterValidation value) { }

	// RVA: 0x1DCA26C Offset: 0x1DC626C VA: 0x1DCA26C
	public TMP_InputValidator get_inputValidator() { }

	// RVA: 0x1DCA274 Offset: 0x1DC6274 VA: 0x1DCA274
	public void set_inputValidator(TMP_InputValidator value) { }

	// RVA: 0x1DCA310 Offset: 0x1DC6310 VA: 0x1DCA310
	public bool get_readOnly() { }

	// RVA: 0x1DCA318 Offset: 0x1DC6318 VA: 0x1DCA318
	public void set_readOnly(bool value) { }

	// RVA: 0x1DCA320 Offset: 0x1DC6320 VA: 0x1DCA320
	public bool get_richText() { }

	// RVA: 0x1DCA328 Offset: 0x1DC6328 VA: 0x1DCA328
	public void set_richText(bool value) { }

	// RVA: 0x1DCA3B8 Offset: 0x1DC63B8 VA: 0x1DCA3B8
	public bool get_multiLine() { }

	// RVA: 0x1DCA3CC Offset: 0x1DC63CC VA: 0x1DCA3CC
	public char get_asteriskChar() { }

	// RVA: 0x1DCA3D4 Offset: 0x1DC63D4 VA: 0x1DCA3D4
	public void set_asteriskChar(char value) { }

	// RVA: 0x1DCA448 Offset: 0x1DC6448 VA: 0x1DCA448
	public bool get_wasCanceled() { }

	// RVA: 0x1DCA450 Offset: 0x1DC6450 VA: 0x1DCA450
	protected void ClampStringPos(ref int pos) { }

	// RVA: 0x1DCA488 Offset: 0x1DC6488 VA: 0x1DCA488
	protected void ClampCaretPos(ref int pos) { }

	// RVA: 0x1DCA504 Offset: 0x1DC6504 VA: 0x1DCA504
	private int ClampArrayIndex(int index) { }

	// RVA: 0x1DCA50C Offset: 0x1DC650C VA: 0x1DCA50C
	protected int get_caretPositionInternal() { }

	// RVA: 0x1DCA524 Offset: 0x1DC6524 VA: 0x1DCA524
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x1DCA534 Offset: 0x1DC6534 VA: 0x1DCA534
	protected int get_stringPositionInternal() { }

	// RVA: 0x1DCA54C Offset: 0x1DC654C VA: 0x1DCA54C
	protected void set_stringPositionInternal(int value) { }

	// RVA: 0x1DCA584 Offset: 0x1DC6584 VA: 0x1DCA584
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x1DCA59C Offset: 0x1DC659C VA: 0x1DCA59C
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x1DCA5AC Offset: 0x1DC65AC VA: 0x1DCA5AC
	protected int get_stringSelectPositionInternal() { }

	// RVA: 0x1DCA5C4 Offset: 0x1DC65C4 VA: 0x1DCA5C4
	protected void set_stringSelectPositionInternal(int value) { }

	// RVA: 0x1DCA5FC Offset: 0x1DC65FC VA: 0x1DCA5FC
	private bool get_hasSelection() { }

	// RVA: 0x1DCA638 Offset: 0x1DC6638 VA: 0x1DCA638
	public int get_caretPosition() { }

	// RVA: 0x1DCA650 Offset: 0x1DC6650 VA: 0x1DCA650
	public void set_caretPosition(int value) { }

	// RVA: 0x1DCA77C Offset: 0x1DC677C VA: 0x1DCA77C
	public int get_selectionAnchorPosition() { }

	// RVA: 0x1DCA680 Offset: 0x1DC6680 VA: 0x1DCA680
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x1DCA794 Offset: 0x1DC6794 VA: 0x1DCA794
	public int get_selectionFocusPosition() { }

	// RVA: 0x1DCA6BC Offset: 0x1DC66BC VA: 0x1DCA6BC
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x1DCA7AC Offset: 0x1DC67AC VA: 0x1DCA7AC
	public int get_stringPosition() { }

	// RVA: 0x1DCA7C4 Offset: 0x1DC67C4 VA: 0x1DCA7C4
	public void set_stringPosition(int value) { }

	// RVA: 0x1DCA914 Offset: 0x1DC6914 VA: 0x1DCA914
	public int get_selectionStringAnchorPosition() { }

	// RVA: 0x1DCA7F4 Offset: 0x1DC67F4 VA: 0x1DCA7F4
	public void set_selectionStringAnchorPosition(int value) { }

	// RVA: 0x1DCA92C Offset: 0x1DC692C VA: 0x1DCA92C
	public int get_selectionStringFocusPosition() { }

	// RVA: 0x1DCA850 Offset: 0x1DC6850 VA: 0x1DCA850
	public void set_selectionStringFocusPosition(int value) { }

	// RVA: 0x1DCA944 Offset: 0x1DC6944 VA: 0x1DCA944 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1DCAA04 Offset: 0x1DC6A04 VA: 0x1DCAA04 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1DCB748 Offset: 0x1DC7748 VA: 0x1DCB748 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1DCBC70 Offset: 0x1DC7C70 VA: 0x1DCBC70
	private void ON_TEXT_CHANGED(Object obj) { }

	[IteratorStateMachine(typeof(TMP_InputField.<CaretBlink>d__295))]
	// RVA: 0x1DCBE40 Offset: 0x1DC7E40 VA: 0x1DCBE40
	private IEnumerator CaretBlink() { }

	// RVA: 0x1DCBEB4 Offset: 0x1DC7EB4 VA: 0x1DCBEB4
	private void SetCaretVisible() { }

	// RVA: 0x1DC9098 Offset: 0x1DC5098 VA: 0x1DC9098
	private void SetCaretActive() { }

	// RVA: 0x1DCBEE8 Offset: 0x1DC7EE8 VA: 0x1DCBEE8
	protected void OnFocus() { }

	// RVA: 0x1DCBF1C Offset: 0x1DC7F1C VA: 0x1DCBF1C
	protected void SelectAll() { }

	// RVA: 0x1DCBF48 Offset: 0x1DC7F48 VA: 0x1DCBF48
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x1DCC110 Offset: 0x1DC8110 VA: 0x1DCC110
	public void MoveTextStart(bool shift) { }

	// RVA: 0x1DCC214 Offset: 0x1DC8214 VA: 0x1DCC214
	public void MoveToEndOfLine(bool shift, bool ctrl) { }

	// RVA: 0x1DCC3CC Offset: 0x1DC83CC VA: 0x1DCC3CC
	public void MoveToStartOfLine(bool shift, bool ctrl) { }

	// RVA: 0x1DCC5B8 Offset: 0x1DC85B8 VA: 0x1DCC5B8
	private static string get_clipboard() { }

	// RVA: 0x1DCC608 Offset: 0x1DC8608 VA: 0x1DCC608
	private static void set_clipboard(string value) { }

	// RVA: 0x1DC8894 Offset: 0x1DC4894 VA: 0x1DC8894
	private bool InPlaceEditing() { }

	// RVA: 0x1DCC660 Offset: 0x1DC8660 VA: 0x1DCC660
	private bool InPlaceEditingChanged() { }

	// RVA: 0x1DCC6E0 Offset: 0x1DC86E0 VA: 0x1DCC6E0
	private bool TouchScreenKeyboardShouldBeUsed() { }

	// RVA: 0x1DCC798 Offset: 0x1DC8798 VA: 0x1DCC798
	private void UpdateKeyboardStringPosition() { }

	// RVA: 0x1DCC904 Offset: 0x1DC8904 VA: 0x1DCC904
	private void UpdateStringPositionFromKeyboard() { }

	// RVA: 0x1DCCAFC Offset: 0x1DC8AFC VA: 0x1DCCAFC Slot: 63
	protected virtual void LateUpdate() { }

	// RVA: 0x1DCE0E4 Offset: 0x1DCA0E4 VA: 0x1DCE0E4
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1DCE1BC Offset: 0x1DCA1BC VA: 0x1DCE1BC Slot: 64
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1DCE1DC Offset: 0x1DCA1DC VA: 0x1DCE1DC Slot: 65
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(TMP_InputField.<MouseDragOutsideRect>d__316))]
	// RVA: 0x1DCE568 Offset: 0x1DCA568 VA: 0x1DCE568
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x1DCE5F8 Offset: 0x1DCA5F8 VA: 0x1DCE5F8 Slot: 66
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1DCE614 Offset: 0x1DCA614 VA: 0x1DCE614 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1DCEEFC Offset: 0x1DCAEFC VA: 0x1DCEEFC
	protected TMP_InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x1DD08F0 Offset: 0x1DCC8F0 VA: 0x1DD08F0 Slot: 67
	protected virtual bool IsValidChar(char c) { }

	// RVA: 0x1DD092C Offset: 0x1DCC92C VA: 0x1DD092C
	public void ProcessEvent(Event e) { }

	// RVA: 0x1DD0930 Offset: 0x1DCC930 VA: 0x1DD0930 Slot: 68
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x1DD0B58 Offset: 0x1DCCB58 VA: 0x1DD0B58 Slot: 69
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x1DD0D1C Offset: 0x1DCCD1C VA: 0x1DD0D1C
	private float GetScrollPositionRelativeToViewport() { }

	// RVA: 0x1DCFB48 Offset: 0x1DCBB48 VA: 0x1DCFB48
	private string GetSelectedString() { }

	// RVA: 0x1DD0FF4 Offset: 0x1DCCFF4 VA: 0x1DD0FF4
	private int FindNextWordBegin() { }

	// RVA: 0x1DD03C4 Offset: 0x1DCC3C4 VA: 0x1DD03C4
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x1DD10C8 Offset: 0x1DCD0C8 VA: 0x1DD10C8
	private int FindPrevWordBegin() { }

	// RVA: 0x1DCFF0C Offset: 0x1DCBF0C VA: 0x1DCFF0C
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x1DD1180 Offset: 0x1DCD180 VA: 0x1DD1180
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x1DD136C Offset: 0x1DCD36C VA: 0x1DD136C
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x1DD158C Offset: 0x1DCD58C VA: 0x1DD158C
	private int PageUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x1DD182C Offset: 0x1DCD82C VA: 0x1DD182C
	private int PageDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x1DD08D8 Offset: 0x1DCC8D8 VA: 0x1DD08D8
	private void MoveDown(bool shift) { }

	// RVA: 0x1DD1B40 Offset: 0x1DCDB40 VA: 0x1DD1B40
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x1DD08D0 Offset: 0x1DCC8D0 VA: 0x1DD08D0
	private void MoveUp(bool shift) { }

	// RVA: 0x1DD1CFC Offset: 0x1DCDCFC VA: 0x1DD1CFC
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x1DD08E0 Offset: 0x1DCC8E0 VA: 0x1DD08E0
	private void MovePageUp(bool shift) { }

	// RVA: 0x1DD1EA0 Offset: 0x1DCDEA0 VA: 0x1DD1EA0
	private void MovePageUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x1DD08E8 Offset: 0x1DCC8E8 VA: 0x1DD08E8
	private void MovePageDown(bool shift) { }

	// RVA: 0x1DD2140 Offset: 0x1DCE140 VA: 0x1DD2140
	private void MovePageDown(bool shift, bool goToLastChar) { }

	// RVA: 0x1DCFC14 Offset: 0x1DCBC14 VA: 0x1DCFC14
	private void Delete() { }

	// RVA: 0x1DCF818 Offset: 0x1DCB818 VA: 0x1DCF818
	private void DeleteKey() { }

	// RVA: 0x1DCF3A8 Offset: 0x1DCB3A8 VA: 0x1DCF3A8
	private void Backspace() { }

	// RVA: 0x1DD23F4 Offset: 0x1DCE3F4 VA: 0x1DD23F4 Slot: 70
	protected virtual void Append(string input) { }

	// RVA: 0x1DD24A4 Offset: 0x1DCE4A4 VA: 0x1DD24A4 Slot: 71
	protected virtual void Append(char input) { }

	// RVA: 0x1DD2818 Offset: 0x1DCE818 VA: 0x1DD2818
	private void Insert(char c) { }

	// RVA: 0x1DCFED0 Offset: 0x1DCBED0 VA: 0x1DCFED0
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x1DCE0CC Offset: 0x1DCA0CC VA: 0x1DCE0CC
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x1DC8FB0 Offset: 0x1DC4FB0 VA: 0x1DC8FB0
	private void SendOnValueChanged() { }

	// RVA: 0x1DD2914 Offset: 0x1DCE914 VA: 0x1DD2914
	protected void SendOnEndEdit() { }

	// RVA: 0x1DD0AFC Offset: 0x1DCCAFC VA: 0x1DD0AFC
	protected void SendOnSubmit() { }

	// RVA: 0x1DD2970 Offset: 0x1DCE970 VA: 0x1DD2970
	protected void SendOnFocus() { }

	// RVA: 0x1DD29CC Offset: 0x1DCE9CC VA: 0x1DD29CC
	protected void SendOnFocusLost() { }

	// RVA: 0x1DD2A28 Offset: 0x1DCEA28 VA: 0x1DD2A28
	protected void SendOnTextSelection() { }

	// RVA: 0x1DD2AD0 Offset: 0x1DCEAD0 VA: 0x1DD2AD0
	protected void SendOnEndTextSelection() { }

	// RVA: 0x1DCD80C Offset: 0x1DC980C VA: 0x1DCD80C
	protected void SendTouchScreenKeyboardStatusChanged() { }

	// RVA: 0x1DC8B0C Offset: 0x1DC4B0C VA: 0x1DC8B0C
	protected void UpdateLabel() { }

	// RVA: 0x1DCBD68 Offset: 0x1DC7D68 VA: 0x1DCBD68
	private void UpdateScrollbar() { }

	// RVA: 0x1DD2B6C Offset: 0x1DCEB6C VA: 0x1DD2B6C
	private void OnScrollbarValueChange(float value) { }

	// RVA: 0x1DCB744 Offset: 0x1DC7744 VA: 0x1DCB744
	private void UpdateMaskRegions() { }

	// RVA: 0x1DD0E50 Offset: 0x1DCCE50 VA: 0x1DD0E50
	private void AdjustTextPositionRelativeToViewport(float relativePosition) { }

	// RVA: 0x1DCCA58 Offset: 0x1DC8A58 VA: 0x1DCCA58
	private int GetCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x1DD2BA8 Offset: 0x1DCEBA8 VA: 0x1DD2BA8
	private int GetMinCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x1DD2C8C Offset: 0x1DCEC8C VA: 0x1DD2C8C
	private int GetMaxCaretPositionFromStringIndex(int stringIndex) { }

	// RVA: 0x1DCC0A8 Offset: 0x1DC80A8 VA: 0x1DCC0A8
	private int GetStringIndexFromCaretPosition(int caretPosition) { }

	// RVA: 0x1DCA6F8 Offset: 0x1DC66F8 VA: 0x1DCA6F8
	private void UpdateStringIndexFromCaretPosition() { }

	// RVA: 0x1DCA8AC Offset: 0x1DC68AC VA: 0x1DCA8AC
	private void UpdateCaretPositionFromStringIndex() { }

	// RVA: 0x1DD2D30 Offset: 0x1DCED30 VA: 0x1DD2D30
	public void ForceLabelUpdate() { }

	// RVA: 0x1DC9174 Offset: 0x1DC5174 VA: 0x1DC9174
	private void MarkGeometryAsDirty() { }

	// RVA: 0x1DD2D34 Offset: 0x1DCED34 VA: 0x1DD2D34 Slot: 72
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1DD2E00 Offset: 0x1DCEE00 VA: 0x1DD2E00 Slot: 73
	public virtual void LayoutComplete() { }

	// RVA: 0x1DD2E04 Offset: 0x1DCEE04 VA: 0x1DD2E04 Slot: 74
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1DD2D44 Offset: 0x1DCED44 VA: 0x1DD2D44
	private void UpdateGeometry() { }

	// RVA: 0x1DCB244 Offset: 0x1DC7244 VA: 0x1DCB244
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x1DD2E08 Offset: 0x1DCEE08 VA: 0x1DD2E08
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x1DD305C Offset: 0x1DCF05C VA: 0x1DD305C
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x1DD3D30 Offset: 0x1DCFD30 VA: 0x1DD3D30
	private void CreateCursorVerts() { }

	// RVA: 0x1DD374C Offset: 0x1DCF74C VA: 0x1DD374C
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x1DD3E78 Offset: 0x1DCFE78 VA: 0x1DD3E78
	private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible) { }

	// RVA: 0x1DCD87C Offset: 0x1DC987C VA: 0x1DCD87C
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x1DD4334 Offset: 0x1DD0334 VA: 0x1DD4334
	public void ActivateInputField() { }

	// RVA: 0x1DCD364 Offset: 0x1DC9364 VA: 0x1DCD364
	private void ActivateInputFieldInternal() { }

	// RVA: 0x1DD4448 Offset: 0x1DD0448 VA: 0x1DD4448 Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1DD448C Offset: 0x1DD048C VA: 0x1DD448C Slot: 75
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1DD44A8 Offset: 0x1DD04A8 VA: 0x1DD44A8
	public void OnControlClick() { }

	// RVA: 0x1DCD7D0 Offset: 0x1DC97D0 VA: 0x1DCD7D0
	public void ReleaseSelection() { }

	// RVA: 0x1DCBA84 Offset: 0x1DC7A84 VA: 0x1DCBA84
	public void DeactivateInputField(bool clearSelection = False) { }

	// RVA: 0x1DD44AC Offset: 0x1DD04AC VA: 0x1DD44AC Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1DD4510 Offset: 0x1DD0510 VA: 0x1DD4510 Slot: 76
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1DD4598 Offset: 0x1DD0598 VA: 0x1DD4598 Slot: 77
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1DD4624 Offset: 0x1DD0624 VA: 0x1DD4624 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x1DC9DFC Offset: 0x1DC5DFC VA: 0x1DC9DFC
	private void EnforceContentType() { }

	// RVA: 0x1DC8228 Offset: 0x1DC4228 VA: 0x1DC8228
	private void SetTextComponentWrapMode() { }

	// RVA: 0x1DCA330 Offset: 0x1DC6330 VA: 0x1DCA330
	private void SetTextComponentRichTextMode() { }

	// RVA: 0x1DC9FCC Offset: 0x1DC5FCC VA: 0x1DC9FCC
	private void SetToCustomIfContentTypeIsNot(TMP_InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x1DCA134 Offset: 0x1DC6134 VA: 0x1DCA134
	private void SetToCustom() { }

	// RVA: 0x1DCA2F8 Offset: 0x1DC62F8 VA: 0x1DCA2F8
	private void SetToCustom(TMP_InputField.CharacterValidation characterValidation) { }

	// RVA: 0x1DD4638 Offset: 0x1DD0638 VA: 0x1DD4638 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x1DD4664 Offset: 0x1DD0664 VA: 0x1DD4664 Slot: 78
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1DD4668 Offset: 0x1DD0668 VA: 0x1DD4668 Slot: 79
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1DD466C Offset: 0x1DD066C VA: 0x1DD466C Slot: 80
	public virtual float get_minWidth() { }

	// RVA: 0x1DD4674 Offset: 0x1DD0674 VA: 0x1DD4674 Slot: 81
	public virtual float get_preferredWidth() { }

	// RVA: 0x1DD47A4 Offset: 0x1DD07A4 VA: 0x1DD47A4 Slot: 82
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1DD47AC Offset: 0x1DD07AC VA: 0x1DD47AC Slot: 83
	public virtual float get_minHeight() { }

	// RVA: 0x1DD47B4 Offset: 0x1DD07B4 VA: 0x1DD47B4 Slot: 84
	public virtual float get_preferredHeight() { }

	// RVA: 0x1DD48E4 Offset: 0x1DD08E4 VA: 0x1DD48E4 Slot: 85
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1DD48EC Offset: 0x1DD08EC VA: 0x1DD48EC Slot: 86
	public virtual int get_layoutPriority() { }

	// RVA: 0x1DC9AE0 Offset: 0x1DC5AE0 VA: 0x1DC9AE0
	public void SetGlobalPointSize(float pointSize) { }

	// RVA: 0x1DC9C50 Offset: 0x1DC5C50 VA: 0x1DC9C50
	public void SetGlobalFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x1DD48F4 Offset: 0x1DD08F4 VA: 0x1DD48F4
	private static void .cctor() { }

	// RVA: 0x1DD49A4 Offset: 0x1DD09A4 VA: 0x1DD49A4 Slot: 47
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: TMPro
internal static class SetPropertyUtility // TypeDefIndex: 5223
{
	// Methods

	// RVA: 0x1DF6210 Offset: 0x1DF2210 VA: 0x1DF6210
	public static bool SetColor(ref Color currentValue, Color newValue) { }

	// RVA: -1 Offset: -1
	public static bool SetEquatableStruct<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1148868 Offset: 0x1144868 VA: 0x1148868
	|-SetPropertyUtility.SetEquatableStruct<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool SetStruct<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1148A18 Offset: 0x1144A18 VA: 0x1148A18
	|-SetPropertyUtility.SetStruct<bool>
	|
	|-RVA: 0x1148AA8 Offset: 0x1144AA8 VA: 0x1148AA8
	|-SetPropertyUtility.SetStruct<char>
	|
	|-RVA: 0x1148B38 Offset: 0x1144B38 VA: 0x1148B38
	|-SetPropertyUtility.SetStruct<int>
	|
	|-RVA: 0x1148BA8 Offset: 0x1144BA8 VA: 0x1148BA8
	|-SetPropertyUtility.SetStruct<Int32Enum>
	|
	|-RVA: 0x1148C48 Offset: 0x1144C48 VA: 0x1148C48
	|-SetPropertyUtility.SetStruct<float>
	|
	|-RVA: 0x1148CC0 Offset: 0x1144CC0 VA: 0x1148CC0
	|-SetPropertyUtility.SetStruct<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static bool SetClass<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114880C Offset: 0x114480C VA: 0x114880C
	|-SetPropertyUtility.SetClass<object>
	*/
}

// Namespace: TMPro
[Serializable]
public abstract class TMP_InputValidator : ScriptableObject // TypeDefIndex: 5224
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract char Validate(ref string text, ref int pos, char ch);

	// RVA: 0x1DF625C Offset: 0x1DF225C VA: 0x1DF625C
	protected void .ctor() { }
}

// Namespace: TMPro
public struct TMP_LineInfo // TypeDefIndex: 5225
{
	// Fields
	internal int controlCharacterCount; // 0x0
	public int characterCount; // 0x4
	public int visibleCharacterCount; // 0x8
	public int spaceCount; // 0xC
	public int visibleSpaceCount; // 0x10
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
	public HorizontalAlignmentOptions alignment; // 0x4C
	public Extents lineExtents; // 0x50
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TMP_ListPool.<>c<T> // TypeDefIndex: 5226
{
	// Fields
	public static readonly TMP_ListPool.<>c<T> <>9; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150EB8 Offset: 0x114CEB8 VA: 0x1150EB8
	|-TMP_ListPool.<>c<object>..cctor
	|
	|-RVA: 0x1151940 Offset: 0x114D940 VA: 0x1151940
	|-TMP_ListPool.<>c<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150F90 Offset: 0x114CF90 VA: 0x1150F90
	|-TMP_ListPool.<>c<object>..ctor
	|
	|-RVA: 0x1151A4C Offset: 0x114DA4C VA: 0x1151A4C
	|-TMP_ListPool.<>c<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal void <.cctor>b__3_0(List<T> l) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1150F98 Offset: 0x114CF98 VA: 0x1150F98
	|-TMP_ListPool.<>c<object>.<.cctor>b__3_0
	|
	|-RVA: 0x1151A54 Offset: 0x114DA54 VA: 0x1151A54
	|-TMP_ListPool.<>c<__Il2CppFullySharedGenericType>.<.cctor>b__3_0
	*/
}

// Namespace: TMPro
internal static class TMP_ListPool<T> // TypeDefIndex: 5227
{
	// Fields
	private static readonly TMP_ObjectPool<List<T>> s_ListPool; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public static List<T> Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1466BE0 Offset: 0x1462BE0 VA: 0x1466BE0
	|-TMP_ListPool<object>.Get
	|
	|-RVA: 0x1466F3C Offset: 0x1462F3C VA: 0x1466F3C
	|-TMP_ListPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public static void Release(List<T> toRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1466C8C Offset: 0x1462C8C VA: 0x1466C8C
	|-TMP_ListPool<object>.Release
	|
	|-RVA: 0x1467034 Offset: 0x1463034 VA: 0x1467034
	|-TMP_ListPool<__Il2CppFullySharedGenericType>.Release
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1466D48 Offset: 0x1462D48 VA: 0x1466D48
	|-TMP_ListPool<object>..cctor
	|
	|-RVA: 0x1467140 Offset: 0x1463140 VA: 0x1467140
	|-TMP_ListPool<__Il2CppFullySharedGenericType>..cctor
	*/
}

// Namespace: 
private class TMP_MaterialManager.FallbackMaterial // TypeDefIndex: 5228
{
	// Fields
	public long fallbackID; // 0x10
	public Material sourceMaterial; // 0x18
	internal int sourceMaterialCRC; // 0x20
	public Material fallbackMaterial; // 0x28
	public int count; // 0x30

	// Methods

	// RVA: 0x1DF9308 Offset: 0x1DF5308 VA: 0x1DF9308
	public void .ctor() { }
}

// Namespace: 
private class TMP_MaterialManager.MaskingMaterial // TypeDefIndex: 5229
{
	// Fields
	public Material baseMaterial; // 0x10
	public Material stencilMaterial; // 0x18
	public int count; // 0x20
	public int stencilID; // 0x24

	// Methods

	// RVA: 0x1DF77A8 Offset: 0x1DF37A8 VA: 0x1DF77A8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_MaterialManager.<>c__DisplayClass11_0 // TypeDefIndex: 5230
{
	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x1DF7EB8 Offset: 0x1DF3EB8 VA: 0x1DF7EB8
	public void .ctor() { }

	// RVA: 0x1DF9C84 Offset: 0x1DF5C84 VA: 0x1DF9C84
	internal bool <AddMaskingMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_MaterialManager.<>c__DisplayClass12_0 // TypeDefIndex: 5231
{
	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x1DF8028 Offset: 0x1DF4028 VA: 0x1DF8028
	public void .ctor() { }

	// RVA: 0x1DF9CF4 Offset: 0x1DF5CF4 VA: 0x1DF9CF4
	internal bool <RemoveStencilMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_MaterialManager.<>c__DisplayClass13_0 // TypeDefIndex: 5232
{
	// Fields
	public Material baseMaterial; // 0x10

	// Methods

	// RVA: 0x1DF8548 Offset: 0x1DF4548 VA: 0x1DF8548
	public void .ctor() { }

	// RVA: 0x1DF9D64 Offset: 0x1DF5D64 VA: 0x1DF9D64
	internal bool <ReleaseBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_MaterialManager.<>c__DisplayClass9_0 // TypeDefIndex: 5233
{
	// Fields
	public Material stencilMaterial; // 0x10

	// Methods

	// RVA: 0x1DF7B30 Offset: 0x1DF3B30 VA: 0x1DF7B30
	public void .ctor() { }

	// RVA: 0x1DF9DD4 Offset: 0x1DF5DD4 VA: 0x1DF9DD4
	internal bool <GetBaseMaterial>b__0(TMP_MaterialManager.MaskingMaterial item) { }
}

// Namespace: TMPro
public static class TMP_MaterialManager // TypeDefIndex: 5234
{
	// Fields
	private static List<TMP_MaterialManager.MaskingMaterial> m_materialList; // 0x0
	private static Dictionary<long, TMP_MaterialManager.FallbackMaterial> m_fallbackMaterials; // 0x8
	private static Dictionary<int, long> m_fallbackMaterialLookup; // 0x10
	private static List<TMP_MaterialManager.FallbackMaterial> m_fallbackCleanupList; // 0x18
	private static bool isFallbackListDirty; // 0x20

	// Methods

	// RVA: 0x1DF6264 Offset: 0x1DF2264 VA: 0x1DF6264
	private static void .cctor() { }

	// RVA: 0x1DF6454 Offset: 0x1DF2454 VA: 0x1DF6454
	private static void OnPreRender() { }

	// RVA: 0x1DF66F8 Offset: 0x1DF26F8 VA: 0x1DF66F8
	public static Material GetStencilMaterial(Material baseMaterial, int stencilID) { }

	// RVA: 0x1DF77B0 Offset: 0x1DF37B0 VA: 0x1DF77B0
	public static void ReleaseStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x1DF79C4 Offset: 0x1DF39C4 VA: 0x1DF79C4
	public static Material GetBaseMaterial(Material stencilMaterial) { }

	// RVA: 0x1DF7B38 Offset: 0x1DF3B38 VA: 0x1DF7B38
	public static Material SetStencil(Material material, int stencilID) { }

	// RVA: 0x1DF7BF4 Offset: 0x1DF3BF4 VA: 0x1DF7BF4
	public static void AddMaskingMaterial(Material baseMaterial, Material stencilMaterial, int stencilID) { }

	// RVA: 0x1DF7EC0 Offset: 0x1DF3EC0 VA: 0x1DF7EC0
	public static void RemoveStencilMaterial(Material stencilMaterial) { }

	// RVA: 0x1DF8030 Offset: 0x1DF4030 VA: 0x1DF8030
	public static void ReleaseBaseMaterial(Material baseMaterial) { }

	// RVA: 0x1DF8550 Offset: 0x1DF4550 VA: 0x1DF8550
	public static void ClearMaterials() { }

	// RVA: 0x1DF8724 Offset: 0x1DF4724 VA: 0x1DF8724
	public static int GetStencilID(GameObject obj) { }

	// RVA: 0x1DF8B90 Offset: 0x1DF4B90 VA: 0x1DF8B90
	public static Material GetMaterialForRendering(MaskableGraphic graphic, Material baseMaterial) { }

	// RVA: 0x1DF89F0 Offset: 0x1DF49F0 VA: 0x1DF89F0
	private static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x1DF8D8C Offset: 0x1DF4D8C VA: 0x1DF8D8C
	internal static Material GetFallbackMaterial(TMP_FontAsset fontAsset, Material sourceMaterial, int atlasIndex) { }

	// RVA: 0x1DF9310 Offset: 0x1DF5310 VA: 0x1DF9310
	public static Material GetFallbackMaterial(Material sourceMaterial, Material targetMaterial) { }

	// RVA: 0x1DF9770 Offset: 0x1DF5770 VA: 0x1DF9770
	public static void AddFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x1DF98B4 Offset: 0x1DF58B4 VA: 0x1DF98B4
	public static void RemoveFallbackMaterialReference(Material targetMaterial) { }

	// RVA: 0x1DF64CC Offset: 0x1DF24CC VA: 0x1DF64CC
	public static void CleanupFallbackMaterials() { }

	// RVA: 0x1DF9A8C Offset: 0x1DF5A8C VA: 0x1DF9A8C
	public static void ReleaseFallbackMaterial(Material fallbackMaterial) { }

	// RVA: 0x1DF9080 Offset: 0x1DF5080 VA: 0x1DF9080
	public static void CopyMaterialPresetProperties(Material source, Material destination) { }
}

// Namespace: TMPro
public enum VertexSortingOrder // TypeDefIndex: 5235
{
	// Fields
	public int value__; // 0x0
	public const VertexSortingOrder Normal = 0;
	public const VertexSortingOrder Reverse = 1;
}

// Namespace: TMPro
public struct TMP_MeshInfo // TypeDefIndex: 5236
{
	// Fields
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x4
	private static readonly Vector4 s_DefaultTangent; // 0x10
	private static readonly Bounds s_DefaultBounds; // 0x20
	public Mesh mesh; // 0x0
	public int vertexCount; // 0x8
	public Vector3[] vertices; // 0x10
	public Vector3[] normals; // 0x18
	public Vector4[] tangents; // 0x20
	public Vector4[] uvs0; // 0x28
	public Vector2[] uvs2; // 0x30
	public Color32[] colors32; // 0x38
	public int[] triangles; // 0x40
	public Material material; // 0x48

	// Methods

	// RVA: 0x1DF9E44 Offset: 0x1DF5E44 VA: 0x1DF9E44
	public void .ctor(Mesh mesh, int size) { }

	// RVA: 0x1DFA408 Offset: 0x1DF6408 VA: 0x1DFA408
	public void .ctor(Mesh mesh, int size, bool isVolumetric) { }

	// RVA: 0x1DFAC20 Offset: 0x1DF6C20 VA: 0x1DFAC20
	public void ResizeMeshInfo(int size) { }

	// RVA: 0x1DFB098 Offset: 0x1DF7098 VA: 0x1DFB098
	public void ResizeMeshInfo(int size, bool isVolumetric) { }

	// RVA: 0x1DFB96C Offset: 0x1DF796C VA: 0x1DFB96C
	public void Clear() { }

	// RVA: 0x1DFBA10 Offset: 0x1DF7A10 VA: 0x1DFBA10
	public void Clear(bool uploadChanges) { }

	// RVA: 0x1DFBB38 Offset: 0x1DF7B38 VA: 0x1DFBB38
	public void ClearUnusedVertices() { }

	// RVA: 0x1DFBB6C Offset: 0x1DF7B6C VA: 0x1DFBB6C
	public void ClearUnusedVertices(int startIndex) { }

	// RVA: 0x1DFBB98 Offset: 0x1DF7B98 VA: 0x1DFBB98
	public void ClearUnusedVertices(int startIndex, bool updateMesh) { }

	// RVA: 0x1DFBC5C Offset: 0x1DF7C5C VA: 0x1DFBC5C
	public void SortGeometry(VertexSortingOrder order) { }

	// RVA: 0x1DFC28C Offset: 0x1DF828C VA: 0x1DFC28C
	public void SortGeometry(IList<int> sortingOrder) { }

	// RVA: 0x1DFBD10 Offset: 0x1DF7D10 VA: 0x1DFBD10
	public void SwapVertexData(int src, int dst) { }

	// RVA: 0x1DFC484 Offset: 0x1DF8484 VA: 0x1DFC484
	private static void .cctor() { }
}

// Namespace: TMPro
internal class TMP_ObjectPool<T> // TypeDefIndex: 5237
{
	// Fields
	private readonly Stack<T> m_Stack; // 0x0
	private readonly UnityAction<T> m_ActionOnGet; // 0x0
	private readonly UnityAction<T> m_ActionOnRelease; // 0x0
	[CompilerGenerated]
	private int <countAll>k__BackingField; // 0x0

	// Properties
	public int countAll { get; set; }
	public int countActive { get; }
	public int countInactive { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_countAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146738C Offset: 0x146338C VA: 0x146738C
	|-TMP_ObjectPool<object>.get_countAll
	|
	|-RVA: 0x14675D8 Offset: 0x14635D8 VA: 0x14675D8
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.get_countAll
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_countAll(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467394 Offset: 0x1463394 VA: 0x1467394
	|-TMP_ObjectPool<object>.set_countAll
	|
	|-RVA: 0x14675E0 Offset: 0x14635E0 VA: 0x14675E0
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.set_countAll
	*/

	// RVA: -1 Offset: -1
	public int get_countActive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146739C Offset: 0x146339C VA: 0x146739C
	|-TMP_ObjectPool<object>.get_countActive
	|
	|-RVA: 0x14675E8 Offset: 0x14635E8 VA: 0x14675E8
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.get_countActive
	*/

	// RVA: -1 Offset: -1
	public int get_countInactive() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14673BC Offset: 0x14633BC VA: 0x14673BC
	|-TMP_ObjectPool<object>.get_countInactive
	|
	|-RVA: 0x1467638 Offset: 0x1463638 VA: 0x1467638
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.get_countInactive
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T> actionOnGet, UnityAction<T> actionOnRelease) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14673D4 Offset: 0x14633D4 VA: 0x14673D4
	|-TMP_ObjectPool<object>..ctor
	|
	|-RVA: 0x146765C Offset: 0x146365C VA: 0x146765C
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T Get() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467478 Offset: 0x1463478 VA: 0x1467478
	|-TMP_ObjectPool<object>.Get
	|
	|-RVA: 0x1467704 Offset: 0x1463704 VA: 0x1467704
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.Get
	*/

	// RVA: -1 Offset: -1
	public void Release(T element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14674F4 Offset: 0x14634F4 VA: 0x14674F4
	|-TMP_ObjectPool<object>.Release
	|
	|-RVA: 0x14678F0 Offset: 0x14638F0 VA: 0x14678F0
	|-TMP_ObjectPool<__Il2CppFullySharedGenericType>.Release
	*/
}

// Namespace: 
private struct TMP_ResourceManager.FontAssetRef // TypeDefIndex: 5238
{
	// Fields
	public int nameHashCode; // 0x0
	public int familyNameHashCode; // 0x4
	public int styleNameHashCode; // 0x8
	public long familyNameAndStyleHashCode; // 0x10
	public readonly TMP_FontAsset fontAsset; // 0x18

	// Methods

	// RVA: 0x1DFCB40 Offset: 0x1DF8B40 VA: 0x1DFCB40
	public void .ctor(int nameHashCode, int familyNameHashCode, int styleNameHashCode, TMP_FontAsset fontAsset) { }
}

// Namespace: TMPro
public class TMP_ResourceManager // TypeDefIndex: 5239
{
	// Fields
	private static TMP_Settings s_TextSettings; // 0x0
	private static readonly Dictionary<int, TMP_ResourceManager.FontAssetRef> s_FontAssetReferences; // 0x8
	private static readonly Dictionary<int, TMP_FontAsset> s_FontAssetNameReferenceLookup; // 0x10
	private static readonly Dictionary<long, TMP_FontAsset> s_FontAssetFamilyNameAndStyleReferenceLookup; // 0x18
	private static readonly List<int> s_FontAssetRemovalList; // 0x20
	private static readonly int k_RegularStyleHashCode; // 0x28

	// Methods

	// RVA: 0x1DFC504 Offset: 0x1DF8504 VA: 0x1DFC504
	internal static TMP_Settings GetTextSettings() { }

	// RVA: 0x1DFC61C Offset: 0x1DF861C VA: 0x1DFC61C
	public static void AddFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x1DFCB68 Offset: 0x1DF8B68 VA: 0x1DFCB68
	public static void RemoveFontAsset(TMP_FontAsset fontAsset) { }

	// RVA: 0x1DFCCBC Offset: 0x1DF8CBC VA: 0x1DFCCBC
	internal static bool TryGetFontAssetByName(int nameHashcode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x1DFCD5C Offset: 0x1DF8D5C VA: 0x1DFCD5C
	internal static bool TryGetFontAssetByFamilyName(int familyNameHashCode, int styleNameHashCode, out TMP_FontAsset fontAsset) { }

	// RVA: 0x1DFCE20 Offset: 0x1DF8E20 VA: 0x1DFCE20
	public static void ClearFontAssetGlyphCache() { }

	// RVA: 0x1DFCE6C Offset: 0x1DF8E6C VA: 0x1DFCE6C
	internal static void RebuildFontAssetCache() { }

	// RVA: 0x1DFD2AC Offset: 0x1DF92AC VA: 0x1DFD2AC
	public void .ctor() { }

	// RVA: 0x1DFD2B4 Offset: 0x1DF92B4 VA: 0x1DFD2B4
	private static void .cctor() { }
}

// Namespace: TMPro
internal enum MarkupTag // TypeDefIndex: 5240
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

// Namespace: TMPro
public enum TagValueType // TypeDefIndex: 5241
{
	// Fields
	public int value__; // 0x0
	public const TagValueType None = 0;
	public const TagValueType NumericalValue = 1;
	public const TagValueType StringValue = 2;
	public const TagValueType ColorValue = 4;
}

// Namespace: TMPro
public enum TagUnitType // TypeDefIndex: 5242
{
	// Fields
	public int value__; // 0x0
	public const TagUnitType Pixels = 0;
	public const TagUnitType FontUnits = 1;
	public const TagUnitType Percentage = 2;
}

// Namespace: TMPro
internal static class CodePoint // TypeDefIndex: 5243
{
	// Fields
	public const uint SPACE = 32;
	public const uint DOUBLE_QUOTE = 34;
	public const uint NUMBER_SIGN = 35;
	public const uint PERCENTAGE = 37;
	public const uint PLUS = 43;
	public const uint MINUS = 45;
	public const uint PERIOD = 46;
	public const uint HYPHEN_MINUS = 45;
	public const uint SOFT_HYPHEN = 173;
	public const uint HYPHEN = 8208;
	public const uint NON_BREAKING_HYPHEN = 8209;
	public const uint ZERO_WIDTH_SPACE = 8203;
	public const uint RIGHT_SINGLE_QUOTATION = 8217;
	public const uint APOSTROPHE = 39;
	public const uint WORD_JOINER = 8288;
	public const uint HIGH_SURROGATE_START = 55296;
	public const uint HIGH_SURROGATE_END = 56319;
	public const uint LOW_SURROGATE_START = 56320;
	public const uint LOW_SURROGATE_END = 57343;
	public const uint UNICODE_PLANE01_START = 65536;
}

// Namespace: TMPro
public class TMP_ScrollbarEventHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 5244
{
	// Fields
	public bool isSelected; // 0x20

	// Methods

	// RVA: 0x1DFD4A4 Offset: 0x1DF94A4 VA: 0x1DFD4A4 Slot: 4
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1DFD50C Offset: 0x1DF950C VA: 0x1DFD50C Slot: 5
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1DFD584 Offset: 0x1DF9584 VA: 0x1DFD584 Slot: 6
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1DFD5F8 Offset: 0x1DF95F8 VA: 0x1DFD5F8
	public void .ctor() { }
}

// Namespace: TMPro
[RequireComponent(typeof(CanvasRenderer))]
public class TMP_SelectionCaret : MaskableGraphic // TypeDefIndex: 5245
{
	// Methods

	// RVA: 0x1DFD600 Offset: 0x1DF9600 VA: 0x1DFD600 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x1DFD6D0 Offset: 0x1DF96D0 VA: 0x1DFD6D0 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x1DFD6D4 Offset: 0x1DF96D4 VA: 0x1DFD6D4
	public void .ctor() { }
}

// Namespace: 
public class TMP_Settings.LineBreakingTable // TypeDefIndex: 5246
{
	// Fields
	public HashSet<uint> leadingCharacters; // 0x10
	public HashSet<uint> followingCharacters; // 0x18

	// Methods

	// RVA: 0x1DFF100 Offset: 0x1DFB100 VA: 0x1DFF100
	public void .ctor() { }
}

// Namespace: TMPro
[ExcludeFromPreset]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/Settings.html")]
[Serializable]
public class TMP_Settings : ScriptableObject // TypeDefIndex: 5247
{
	// Fields
	private static TMP_Settings s_Instance; // 0x0
	[SerializeField]
	internal string assetVersion; // 0x18
	internal static string s_CurrentAssetVersion; // 0x8
	[FormerlySerializedAs("m_enableWordWrapping")]
	[SerializeField]
	private TextWrappingModes m_TextWrappingMode; // 0x20
	[SerializeField]
	private bool m_enableKerning; // 0x24
	[SerializeField]
	private List<OTL_FeatureTag> m_ActiveFontFeatures; // 0x28
	[SerializeField]
	private bool m_enableExtraPadding; // 0x30
	[SerializeField]
	private bool m_enableTintAllSprites; // 0x31
	[SerializeField]
	private bool m_enableParseEscapeCharacters; // 0x32
	[SerializeField]
	private bool m_EnableRaycastTarget; // 0x33
	[SerializeField]
	private bool m_GetFontFeaturesAtRuntime; // 0x34
	[SerializeField]
	private int m_missingGlyphCharacter; // 0x38
	[SerializeField]
	private bool m_ClearDynamicDataOnBuild; // 0x3C
	[SerializeField]
	private bool m_warningsDisabled; // 0x3D
	[SerializeField]
	private TMP_FontAsset m_defaultFontAsset; // 0x40
	[SerializeField]
	private string m_defaultFontAssetPath; // 0x48
	[SerializeField]
	private float m_defaultFontSize; // 0x50
	[SerializeField]
	private float m_defaultAutoSizeMinRatio; // 0x54
	[SerializeField]
	private float m_defaultAutoSizeMaxRatio; // 0x58
	[SerializeField]
	private Vector2 m_defaultTextMeshProTextContainerSize; // 0x5C
	[SerializeField]
	private Vector2 m_defaultTextMeshProUITextContainerSize; // 0x64
	[SerializeField]
	private bool m_autoSizeTextContainer; // 0x6C
	[SerializeField]
	private bool m_IsTextObjectScaleStatic; // 0x6D
	[SerializeField]
	private List<TMP_FontAsset> m_fallbackFontAssets; // 0x70
	[SerializeField]
	private bool m_matchMaterialPreset; // 0x78
	[SerializeField]
	private bool m_HideSubTextObjects; // 0x79
	[SerializeField]
	private TMP_SpriteAsset m_defaultSpriteAsset; // 0x80
	[SerializeField]
	private string m_defaultSpriteAssetPath; // 0x88
	[SerializeField]
	private bool m_enableEmojiSupport; // 0x90
	[SerializeField]
	private uint m_MissingCharacterSpriteUnicode; // 0x94
	[SerializeField]
	private List<TMP_Asset> m_EmojiFallbackTextAssets; // 0x98
	[SerializeField]
	private string m_defaultColorGradientPresetsPath; // 0xA0
	[SerializeField]
	private TMP_StyleSheet m_defaultStyleSheet; // 0xA8
	[SerializeField]
	private string m_StyleSheetsResourcePath; // 0xB0
	[SerializeField]
	private TextAsset m_leadingCharacters; // 0xB8
	[SerializeField]
	private TextAsset m_followingCharacters; // 0xC0
	[SerializeField]
	private TMP_Settings.LineBreakingTable m_linebreakingRules; // 0xC8
	[SerializeField]
	private bool m_UseModernHangulLineBreakingRules; // 0xD0

	// Properties
	public static string version { get; }
	public static TextWrappingModes textWrappingMode { get; }
	[Obsolete("The "enableKerning" property has been deprecated. Use the "fontFeatures" property to control what features are enabled by default on newly created text components.")]
	public static bool enableKerning { get; }
	public static List<OTL_FeatureTag> fontFeatures { get; }
	public static bool enableExtraPadding { get; }
	public static bool enableTintAllSprites { get; }
	public static bool enableParseEscapeCharacters { get; }
	public static bool enableRaycastTarget { get; }
	public static bool getFontFeaturesAtRuntime { get; }
	public static int missingGlyphCharacter { get; set; }
	public static bool clearDynamicDataOnBuild { get; }
	public static bool warningsDisabled { get; }
	public static TMP_FontAsset defaultFontAsset { get; set; }
	public static string defaultFontAssetPath { get; }
	public static float defaultFontSize { get; }
	public static float defaultTextAutoSizingMinRatio { get; }
	public static float defaultTextAutoSizingMaxRatio { get; }
	public static Vector2 defaultTextMeshProTextContainerSize { get; }
	public static Vector2 defaultTextMeshProUITextContainerSize { get; }
	public static bool autoSizeTextContainer { get; }
	public static bool isTextObjectScaleStatic { get; set; }
	public static List<TMP_FontAsset> fallbackFontAssets { get; set; }
	public static bool matchMaterialPreset { get; }
	public static bool hideSubTextObjects { get; }
	public static TMP_SpriteAsset defaultSpriteAsset { get; set; }
	public static string defaultSpriteAssetPath { get; }
	public static bool enableEmojiSupport { get; set; }
	public static uint missingCharacterSpriteUnicode { get; set; }
	public static List<TMP_Asset> emojiFallbackTextAssets { get; set; }
	public static string defaultColorGradientPresetsPath { get; }
	public static TMP_StyleSheet defaultStyleSheet { get; set; }
	public static string styleSheetsResourcePath { get; }
	public static TextAsset leadingCharacters { get; }
	public static TextAsset followingCharacters { get; }
	public static TMP_Settings.LineBreakingTable linebreakingRules { get; }
	public static bool useModernHangulLineBreakingRules { get; set; }
	public static TMP_Settings instance { get; }
	internal static bool isTMPSettingsNull { get; }

	// Methods

	// RVA: 0x1DFD6DC Offset: 0x1DF96DC VA: 0x1DFD6DC
	public static string get_version() { }

	// RVA: 0x1DFD71C Offset: 0x1DF971C VA: 0x1DFD71C
	internal void SetAssetVersion() { }

	// RVA: 0x1DFD780 Offset: 0x1DF9780 VA: 0x1DFD780
	public static TextWrappingModes get_textWrappingMode() { }

	// RVA: 0x1DFDA28 Offset: 0x1DF9A28 VA: 0x1DFDA28
	public static bool get_enableKerning() { }

	// RVA: 0x1DFDAEC Offset: 0x1DF9AEC VA: 0x1DFDAEC
	public static List<OTL_FeatureTag> get_fontFeatures() { }

	// RVA: 0x1DFDB48 Offset: 0x1DF9B48 VA: 0x1DFDB48
	public static bool get_enableExtraPadding() { }

	// RVA: 0x1DFDBA4 Offset: 0x1DF9BA4 VA: 0x1DFDBA4
	public static bool get_enableTintAllSprites() { }

	// RVA: 0x1DFDC00 Offset: 0x1DF9C00 VA: 0x1DFDC00
	public static bool get_enableParseEscapeCharacters() { }

	// RVA: 0x1DFDC5C Offset: 0x1DF9C5C VA: 0x1DFDC5C
	public static bool get_enableRaycastTarget() { }

	// RVA: 0x1DFDCB8 Offset: 0x1DF9CB8 VA: 0x1DFDCB8
	public static bool get_getFontFeaturesAtRuntime() { }

	// RVA: 0x1DFDD14 Offset: 0x1DF9D14 VA: 0x1DFDD14
	public static int get_missingGlyphCharacter() { }

	// RVA: 0x1DFDD70 Offset: 0x1DF9D70 VA: 0x1DFDD70
	public static void set_missingGlyphCharacter(int value) { }

	// RVA: 0x1DFDDD0 Offset: 0x1DF9DD0 VA: 0x1DFDDD0
	public static bool get_clearDynamicDataOnBuild() { }

	// RVA: 0x1DFDE2C Offset: 0x1DF9E2C VA: 0x1DFDE2C
	public static bool get_warningsDisabled() { }

	// RVA: 0x1DFDE88 Offset: 0x1DF9E88 VA: 0x1DFDE88
	public static TMP_FontAsset get_defaultFontAsset() { }

	// RVA: 0x1DFDEE4 Offset: 0x1DF9EE4 VA: 0x1DFDEE4
	public static void set_defaultFontAsset(TMP_FontAsset value) { }

	// RVA: 0x1DFDF48 Offset: 0x1DF9F48 VA: 0x1DFDF48
	public static string get_defaultFontAssetPath() { }

	// RVA: 0x1DFDFA4 Offset: 0x1DF9FA4 VA: 0x1DFDFA4
	public static float get_defaultFontSize() { }

	// RVA: 0x1DFE000 Offset: 0x1DFA000 VA: 0x1DFE000
	public static float get_defaultTextAutoSizingMinRatio() { }

	// RVA: 0x1DFE05C Offset: 0x1DFA05C VA: 0x1DFE05C
	public static float get_defaultTextAutoSizingMaxRatio() { }

	// RVA: 0x1DFE0B8 Offset: 0x1DFA0B8 VA: 0x1DFE0B8
	public static Vector2 get_defaultTextMeshProTextContainerSize() { }

	// RVA: 0x1DFE114 Offset: 0x1DFA114 VA: 0x1DFE114
	public static Vector2 get_defaultTextMeshProUITextContainerSize() { }

	// RVA: 0x1DFE170 Offset: 0x1DFA170 VA: 0x1DFE170
	public static bool get_autoSizeTextContainer() { }

	// RVA: 0x1DFE1CC Offset: 0x1DFA1CC VA: 0x1DFE1CC
	public static bool get_isTextObjectScaleStatic() { }

	// RVA: 0x1DFE228 Offset: 0x1DFA228 VA: 0x1DFE228
	public static void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x1DFE28C Offset: 0x1DFA28C VA: 0x1DFE28C
	public static List<TMP_FontAsset> get_fallbackFontAssets() { }

	// RVA: 0x1DFE2E8 Offset: 0x1DFA2E8 VA: 0x1DFE2E8
	public static void set_fallbackFontAssets(List<TMP_FontAsset> value) { }

	// RVA: 0x1DFE34C Offset: 0x1DFA34C VA: 0x1DFE34C
	public static bool get_matchMaterialPreset() { }

	// RVA: 0x1DFE3A8 Offset: 0x1DFA3A8 VA: 0x1DFE3A8
	public static bool get_hideSubTextObjects() { }

	// RVA: 0x1DFE404 Offset: 0x1DFA404 VA: 0x1DFE404
	public static TMP_SpriteAsset get_defaultSpriteAsset() { }

	// RVA: 0x1DFE460 Offset: 0x1DFA460 VA: 0x1DFE460
	public static void set_defaultSpriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x1DFE4C4 Offset: 0x1DFA4C4 VA: 0x1DFE4C4
	public static string get_defaultSpriteAssetPath() { }

	// RVA: 0x1DFE520 Offset: 0x1DFA520 VA: 0x1DFE520
	public static bool get_enableEmojiSupport() { }

	// RVA: 0x1DFE57C Offset: 0x1DFA57C VA: 0x1DFE57C
	public static void set_enableEmojiSupport(bool value) { }

	// RVA: 0x1DFE5E0 Offset: 0x1DFA5E0 VA: 0x1DFE5E0
	public static uint get_missingCharacterSpriteUnicode() { }

	// RVA: 0x1DFE63C Offset: 0x1DFA63C VA: 0x1DFE63C
	public static void set_missingCharacterSpriteUnicode(uint value) { }

	// RVA: 0x1DFE69C Offset: 0x1DFA69C VA: 0x1DFE69C
	public static List<TMP_Asset> get_emojiFallbackTextAssets() { }

	// RVA: 0x1DFE6F8 Offset: 0x1DFA6F8 VA: 0x1DFE6F8
	public static void set_emojiFallbackTextAssets(List<TMP_Asset> value) { }

	// RVA: 0x1DFE75C Offset: 0x1DFA75C VA: 0x1DFE75C
	public static string get_defaultColorGradientPresetsPath() { }

	// RVA: 0x1DFE7B8 Offset: 0x1DFA7B8 VA: 0x1DFE7B8
	public static TMP_StyleSheet get_defaultStyleSheet() { }

	// RVA: 0x1DFE814 Offset: 0x1DFA814 VA: 0x1DFE814
	public static void set_defaultStyleSheet(TMP_StyleSheet value) { }

	// RVA: 0x1DFE878 Offset: 0x1DFA878 VA: 0x1DFE878
	public static string get_styleSheetsResourcePath() { }

	// RVA: 0x1DFE8D4 Offset: 0x1DFA8D4 VA: 0x1DFE8D4
	public static TextAsset get_leadingCharacters() { }

	// RVA: 0x1DFE930 Offset: 0x1DFA930 VA: 0x1DFE930
	public static TextAsset get_followingCharacters() { }

	// RVA: 0x1DFE98C Offset: 0x1DFA98C VA: 0x1DFE98C
	public static TMP_Settings.LineBreakingTable get_linebreakingRules() { }

	// RVA: 0x1DFEBA0 Offset: 0x1DFABA0 VA: 0x1DFEBA0
	public static bool get_useModernHangulLineBreakingRules() { }

	// RVA: 0x1DFEBFC Offset: 0x1DFABFC VA: 0x1DFEBFC
	public static void set_useModernHangulLineBreakingRules(bool value) { }

	// RVA: 0x1DFD7DC Offset: 0x1DF97DC VA: 0x1DFD7DC
	public static TMP_Settings get_instance() { }

	// RVA: 0x1DFEC60 Offset: 0x1DFAC60 VA: 0x1DFEC60
	internal static bool get_isTMPSettingsNull() { }

	// RVA: 0x1DFECEC Offset: 0x1DFACEC VA: 0x1DFECEC
	public static TMP_Settings LoadDefaultSettings() { }

	// RVA: 0x1DFEE28 Offset: 0x1DFAE28 VA: 0x1DFEE28
	public static TMP_Settings GetSettings() { }

	// RVA: 0x1DFEED8 Offset: 0x1DFAED8 VA: 0x1DFEED8
	public static TMP_FontAsset GetFontAsset() { }

	// RVA: 0x1DFEF90 Offset: 0x1DFAF90 VA: 0x1DFEF90
	public static TMP_SpriteAsset GetSpriteAsset() { }

	// RVA: 0x1DFF048 Offset: 0x1DFB048 VA: 0x1DFF048
	public static TMP_StyleSheet GetStyleSheet() { }

	// RVA: 0x1DFEA1C Offset: 0x1DFAA1C VA: 0x1DFEA1C
	public static void LoadLinebreakingRules() { }

	// RVA: 0x1DFF108 Offset: 0x1DFB108 VA: 0x1DFF108
	private static HashSet<uint> GetCharacters(TextAsset file) { }

	// RVA: 0x1DFF1F0 Offset: 0x1DFB1F0 VA: 0x1DFF1F0
	public void .ctor() { }

	// RVA: 0x1DFF2FC Offset: 0x1DFB2FC VA: 0x1DFF2FC
	private static void .cctor() { }
}

// Namespace: TMPro
public static class ShaderUtilities // TypeDefIndex: 5248
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
	private static Shader k_ShaderRef_MobileSDF; // 0x148
	private static Shader k_ShaderRef_MobileBitmap; // 0x150

	// Properties
	internal static Shader ShaderRef_MobileSDF { get; }
	internal static Shader ShaderRef_MobileBitmap { get; }

	// Methods

	// RVA: 0x1DFF35C Offset: 0x1DFB35C VA: 0x1DFF35C
	internal static Shader get_ShaderRef_MobileSDF() { }

	// RVA: 0x1DFF45C Offset: 0x1DFB45C VA: 0x1DFF45C
	internal static Shader get_ShaderRef_MobileBitmap() { }

	// RVA: 0x1DFF55C Offset: 0x1DFB55C VA: 0x1DFF55C
	private static void .cctor() { }

	// RVA: 0x1DF6AC8 Offset: 0x1DF2AC8 VA: 0x1DF6AC8
	public static void GetShaderPropertyIDs() { }

	// RVA: 0x1DFF77C Offset: 0x1DFB77C VA: 0x1DFF77C
	public static void UpdateShaderRatios(Material mat) { }

	// RVA: 0x1DFFBEC Offset: 0x1DFBBEC VA: 0x1DFFBEC
	public static Vector4 GetFontExtent(Material material) { }

	// RVA: 0x1DFFC30 Offset: 0x1DFBC30 VA: 0x1DFFC30
	public static bool IsMaskingEnabled(Material material) { }

	// RVA: 0x1DFFDCC Offset: 0x1DFBDCC VA: 0x1DFFDCC
	public static float GetPadding(Material material, bool enableExtraPadding, bool isBold) { }

	// RVA: 0x1E005A8 Offset: 0x1DFC5A8 VA: 0x1E005A8
	private static float ComputePaddingForProperties(Material mat) { }

	// RVA: 0x1E008B8 Offset: 0x1DFC8B8 VA: 0x1E008B8
	public static float GetPadding(Material[] materials, bool enableExtraPadding, bool isBold) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Sprite : TMP_TextElement_Legacy // TypeDefIndex: 5249
{
	// Fields
	public string name; // 0x38
	public int hashCode; // 0x40
	public int unicode; // 0x44
	public Vector2 pivot; // 0x48
	public Sprite sprite; // 0x50

	// Methods

	// RVA: 0x1E01190 Offset: 0x1DFD190 VA: 0x1E01190
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TMP_SpriteAnimator.<DoSpriteAnimationInternal>d__7 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5250
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TMP_SpriteAnimator <>4__this; // 0x20
	public int start; // 0x28
	public int end; // 0x2C
	public TMP_SpriteAsset spriteAsset; // 0x30
	public int currentCharacter; // 0x38
	public int framerate; // 0x3C
	private int <currentFrame>5__2; // 0x40
	private TMP_CharacterInfo <charInfo>5__3; // 0x48
	private int <materialIndex>5__4; // 0x1C0
	private int <vertexIndex>5__5; // 0x1C4
	private TMP_MeshInfo <meshInfo>5__6; // 0x1C8
	private float <baseSpriteScale>5__7; // 0x218
	private float <elapsedTime>5__8; // 0x21C
	private float <targetTime>5__9; // 0x220

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1E013F8 Offset: 0x1DFD3F8 VA: 0x1E013F8
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1E014AC Offset: 0x1DFD4AC VA: 0x1E014AC Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1E014B0 Offset: 0x1DFD4B0 VA: 0x1E014B0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1E01E20 Offset: 0x1DFDE20 VA: 0x1E01E20 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1E01E28 Offset: 0x1DFDE28 VA: 0x1E01E28 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1E01E60 Offset: 0x1DFDE60 VA: 0x1E01E60 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: TMPro
[DisallowMultipleComponent]
public class TMP_SpriteAnimator : MonoBehaviour // TypeDefIndex: 5251
{
	// Fields
	private Dictionary<int, bool> m_animations; // 0x20
	private TMP_Text m_TextComponent; // 0x28

	// Methods

	// RVA: 0x1E011A0 Offset: 0x1DFD1A0 VA: 0x1E011A0
	private void Awake() { }

	// RVA: 0x1E011F8 Offset: 0x1DFD1F8 VA: 0x1E011F8
	private void OnEnable() { }

	// RVA: 0x1E011FC Offset: 0x1DFD1FC VA: 0x1E011FC
	private void OnDisable() { }

	// RVA: 0x1E01200 Offset: 0x1DFD200 VA: 0x1E01200
	public void StopAllAnimations() { }

	// RVA: 0x1E0125C Offset: 0x1DFD25C VA: 0x1E0125C
	public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	[IteratorStateMachine(typeof(TMP_SpriteAnimator.<DoSpriteAnimationInternal>d__7))]
	// RVA: 0x1E01344 Offset: 0x1DFD344 VA: 0x1E01344
	private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate) { }

	// RVA: 0x1E01420 Offset: 0x1DFD420 VA: 0x1E01420
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TMP_SpriteAsset.<>c // TypeDefIndex: 5252
{
	// Fields
	public static readonly TMP_SpriteAsset.<>c <>9; // 0x0
	public static Func<TMP_SpriteGlyph, uint> <>9__32_0; // 0x8
	public static Func<TMP_SpriteCharacter, uint> <>9__33_0; // 0x10

	// Methods

	// RVA: 0x1E03A7C Offset: 0x1DFFA7C VA: 0x1E03A7C
	private static void .cctor() { }

	// RVA: 0x1E03AE4 Offset: 0x1DFFAE4 VA: 0x1E03AE4
	public void .ctor() { }

	// RVA: 0x1E03AEC Offset: 0x1DFFAEC VA: 0x1E03AEC
	internal uint <SortGlyphTable>b__32_0(TMP_SpriteGlyph item) { }

	// RVA: 0x1E03B04 Offset: 0x1DFFB04 VA: 0x1E03B04
	internal uint <SortCharacterTable>b__33_0(TMP_SpriteCharacter c) { }
}

// Namespace: TMPro
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/Sprites.html")]
[ExcludeFromPreset]
public class TMP_SpriteAsset : TMP_Asset // TypeDefIndex: 5253
{
	// Fields
	internal Dictionary<int, int> m_NameLookup; // 0x98
	internal Dictionary<uint, int> m_GlyphIndexLookup; // 0xA0
	public Texture spriteSheet; // 0xA8
	[SerializeField]
	private List<TMP_SpriteCharacter> m_SpriteCharacterTable; // 0xB0
	internal Dictionary<uint, TMP_SpriteCharacter> m_SpriteCharacterLookup; // 0xB8
	[FormerlySerializedAs("m_SpriteGlyphTable")]
	[SerializeField]
	private List<TMP_SpriteGlyph> m_GlyphTable; // 0xC0
	internal Dictionary<uint, TMP_SpriteGlyph> m_SpriteGlyphLookup; // 0xC8
	public List<TMP_Sprite> spriteInfoList; // 0xD0
	[SerializeField]
	public List<TMP_SpriteAsset> fallbackSpriteAssets; // 0xD8
	internal bool m_IsSpriteAssetLookupTablesDirty; // 0xE0
	private static HashSet<int> k_searchedSpriteAssets; // 0x0

	// Properties
	public List<TMP_SpriteCharacter> spriteCharacterTable { get; set; }
	public Dictionary<uint, TMP_SpriteCharacter> spriteCharacterLookupTable { get; set; }
	public List<TMP_SpriteGlyph> spriteGlyphTable { get; set; }

	// Methods

	// RVA: 0x1E01DFC Offset: 0x1DFDDFC VA: 0x1E01DFC
	public List<TMP_SpriteCharacter> get_spriteCharacterTable() { }

	// RVA: 0x1E023F8 Offset: 0x1DFE3F8 VA: 0x1E023F8
	internal void set_spriteCharacterTable(List<TMP_SpriteCharacter> value) { }

	// RVA: 0x1E02400 Offset: 0x1DFE400 VA: 0x1E02400
	public Dictionary<uint, TMP_SpriteCharacter> get_spriteCharacterLookupTable() { }

	// RVA: 0x1E02424 Offset: 0x1DFE424 VA: 0x1E02424
	internal void set_spriteCharacterLookupTable(Dictionary<uint, TMP_SpriteCharacter> value) { }

	// RVA: 0x1E0242C Offset: 0x1DFE42C VA: 0x1E0242C
	public List<TMP_SpriteGlyph> get_spriteGlyphTable() { }

	// RVA: 0x1E02434 Offset: 0x1DFE434 VA: 0x1E02434
	internal void set_spriteGlyphTable(List<TMP_SpriteGlyph> value) { }

	// RVA: 0x1E0243C Offset: 0x1DFE43C VA: 0x1E0243C
	private void Awake() { }

	// RVA: 0x1E029D8 Offset: 0x1DFE9D8 VA: 0x1E029D8
	private Material GetDefaultSpriteMaterial() { }

	// RVA: 0x1E01E68 Offset: 0x1DFDE68 VA: 0x1E01E68
	public void UpdateLookupTables() { }

	// RVA: 0x1E02AB0 Offset: 0x1DFEAB0 VA: 0x1E02AB0
	public int GetSpriteIndexFromHashcode(int hashCode) { }

	// RVA: 0x1E02B38 Offset: 0x1DFEB38 VA: 0x1E02B38
	public int GetSpriteIndexFromUnicode(uint unicode) { }

	// RVA: 0x1E02BCC Offset: 0x1DFEBCC VA: 0x1E02BCC
	public int GetSpriteIndexFromName(string name) { }

	// RVA: 0x1E02C44 Offset: 0x1DFEC44 VA: 0x1E02C44
	public static TMP_SpriteAsset SearchForSpriteByUnicode(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x1E02EA0 Offset: 0x1DFEEA0 VA: 0x1E02EA0
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(List<TMP_SpriteAsset> spriteAssets, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x1E0303C Offset: 0x1DFF03C VA: 0x1E0303C
	private static TMP_SpriteAsset SearchForSpriteByUnicodeInternal(TMP_SpriteAsset spriteAsset, uint unicode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x1E030EC Offset: 0x1DFF0EC VA: 0x1E030EC
	public static TMP_SpriteAsset SearchForSpriteByHashCode(TMP_SpriteAsset spriteAsset, int hashCode, bool includeFallbacks, out int spriteIndex) { }

	// RVA: 0x1E03470 Offset: 0x1DFF470 VA: 0x1E03470
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(List<TMP_SpriteAsset> spriteAssets, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x1E0360C Offset: 0x1DFF60C VA: 0x1E0360C
	private static TMP_SpriteAsset SearchForSpriteByHashCodeInternal(TMP_SpriteAsset spriteAsset, int hashCode, bool searchFallbacks, out int spriteIndex) { }

	// RVA: 0x1E036BC Offset: 0x1DFF6BC VA: 0x1E036BC
	public void SortGlyphTable() { }

	// RVA: 0x1E0380C Offset: 0x1DFF80C VA: 0x1E0380C
	internal void SortCharacterTable() { }

	// RVA: 0x1E03960 Offset: 0x1DFF960 VA: 0x1E03960
	internal void SortGlyphAndCharacterTables() { }

	// RVA: 0x1E024C4 Offset: 0x1DFE4C4 VA: 0x1E024C4
	private void UpgradeSpriteAsset() { }

	// RVA: 0x1E039A0 Offset: 0x1DFF9A0 VA: 0x1E039A0
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_SpriteCharacter : TMP_TextElement // TypeDefIndex: 5254
{
	// Fields
	[SerializeField]
	private string m_Name; // 0x30

	// Properties
	public string name { get; set; }

	// Methods

	// RVA: 0x1E03B18 Offset: 0x1DFFB18 VA: 0x1E03B18
	public string get_name() { }

	// RVA: 0x1E03B20 Offset: 0x1DFFB20 VA: 0x1E03B20
	public void set_name(string value) { }

	// RVA: 0x1E03980 Offset: 0x1DFF980 VA: 0x1E03980
	public void .ctor() { }

	// RVA: 0x1E03B30 Offset: 0x1DFFB30 VA: 0x1E03B30
	public void .ctor(uint unicode, TMP_SpriteGlyph glyph) { }

	// RVA: 0x1E03B94 Offset: 0x1DFFB94 VA: 0x1E03B94
	public void .ctor(uint unicode, TMP_SpriteAsset spriteAsset, TMP_SpriteGlyph glyph) { }

	// RVA: 0x1E03C10 Offset: 0x1DFFC10 VA: 0x1E03C10
	internal void .ctor(uint unicode, uint glyphIndex) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_SpriteGlyph : Glyph // TypeDefIndex: 5255
{
	// Fields
	public Sprite sprite; // 0x48

	// Methods

	// RVA: 0x1E03978 Offset: 0x1DFF978 VA: 0x1E03978
	public void .ctor() { }

	// RVA: 0x1E03C6C Offset: 0x1DFFC6C VA: 0x1E03C6C
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

	// RVA: 0x1E03D28 Offset: 0x1DFFD28 VA: 0x1E03D28
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex, Sprite sprite) { }
}

// Namespace: TMPro
[Serializable]
public class TMP_Style // TypeDefIndex: 5256
{
	// Fields
	internal static TMP_Style k_NormalStyle; // 0x0
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

	// Properties
	public static TMP_Style NormalStyle { get; }
	public string name { get; set; }
	public int hashCode { get; set; }
	public string styleOpeningDefinition { get; }
	public string styleClosingDefinition { get; }
	public uint[] styleOpeningTagArray { get; }
	public uint[] styleClosingTagArray { get; }

	// Methods

	// RVA: 0x1E03DF8 Offset: 0x1DFFDF8 VA: 0x1E03DF8
	public static TMP_Style get_NormalStyle() { }

	// RVA: 0x1E03F6C Offset: 0x1DFFF6C VA: 0x1E03F6C
	public string get_name() { }

	// RVA: 0x1E03F74 Offset: 0x1DFFF74 VA: 0x1E03F74
	public void set_name(string value) { }

	// RVA: 0x1E03FC0 Offset: 0x1DFFFC0 VA: 0x1E03FC0
	public int get_hashCode() { }

	// RVA: 0x1E03FC8 Offset: 0x1DFFFC8 VA: 0x1E03FC8
	public void set_hashCode(int value) { }

	// RVA: 0x1E03FDC Offset: 0x1DFFFDC VA: 0x1E03FDC
	public string get_styleOpeningDefinition() { }

	// RVA: 0x1E03FE4 Offset: 0x1DFFFE4 VA: 0x1E03FE4
	public string get_styleClosingDefinition() { }

	// RVA: 0x1E03FEC Offset: 0x1DFFFEC VA: 0x1E03FEC
	public uint[] get_styleOpeningTagArray() { }

	// RVA: 0x1E03FF4 Offset: 0x1DFFFF4 VA: 0x1E03FF4
	public uint[] get_styleClosingTagArray() { }

	// RVA: 0x1E03EB0 Offset: 0x1DFFEB0 VA: 0x1E03EB0
	internal void .ctor(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	// RVA: 0x1E040B8 Offset: 0x1E000B8 VA: 0x1E040B8
	public void RefreshStyle() { }
}

// Namespace: TMPro
[ExcludeFromPreset]
[Serializable]
public class TMP_StyleSheet : ScriptableObject // TypeDefIndex: 5257
{
	// Fields
	[SerializeField]
	private List<TMP_Style> m_StyleList; // 0x18
	private Dictionary<int, TMP_Style> m_StyleLookupDictionary; // 0x20

	// Properties
	internal List<TMP_Style> styles { get; }

	// Methods

	// RVA: 0x1E04224 Offset: 0x1E00224 VA: 0x1E04224
	internal List<TMP_Style> get_styles() { }

	// RVA: 0x1E0422C Offset: 0x1E0022C VA: 0x1E0422C
	private void Reset() { }

	// RVA: 0x1E04548 Offset: 0x1E00548 VA: 0x1E04548
	public TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x1E045D0 Offset: 0x1E005D0 VA: 0x1E045D0
	public TMP_Style GetStyle(string name) { }

	// RVA: 0x1E04688 Offset: 0x1E00688 VA: 0x1E04688
	public void RefreshStyles() { }

	// RVA: 0x1E04230 Offset: 0x1E00230 VA: 0x1E04230
	private void LoadStyleDictionaryInternal() { }

	// RVA: 0x1E0468C Offset: 0x1E0068C VA: 0x1E0468C
	public void .ctor() { }
}

// Namespace: TMPro
[RequireComponent(typeof(MeshRenderer))]
[ExecuteAlways]
public class TMP_SubMesh : MonoBehaviour // TypeDefIndex: 5258
{
	// Fields
	[SerializeField]
	private TMP_FontAsset m_fontAsset; // 0x20
	[SerializeField]
	private TMP_SpriteAsset m_spriteAsset; // 0x28
	[SerializeField]
	private Material m_material; // 0x30
	[SerializeField]
	private Material m_sharedMaterial; // 0x38
	private Material m_fallbackMaterial; // 0x40
	private Material m_fallbackSourceMaterial; // 0x48
	[SerializeField]
	private bool m_isDefaultMaterial; // 0x50
	[SerializeField]
	private float m_padding; // 0x54
	[SerializeField]
	private Renderer m_renderer; // 0x58
	private MeshFilter m_meshFilter; // 0x60
	private Mesh m_mesh; // 0x68
	[SerializeField]
	private TextMeshPro m_TextComponent; // 0x70
	private bool m_isRegisteredForEvents; // 0x78

	// Properties
	public TMP_FontAsset fontAsset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public Renderer renderer { get; }
	public MeshFilter meshFilter { get; }
	public Mesh mesh { get; set; }
	public TMP_Text textComponent { get; }

	// Methods

	// RVA: 0x1E04718 Offset: 0x1E00718 VA: 0x1E04718
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x1E04720 Offset: 0x1E00720 VA: 0x1E04720
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x1E04728 Offset: 0x1E00728 VA: 0x1E04728
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x1E04730 Offset: 0x1E00730 VA: 0x1E04730
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x1E04738 Offset: 0x1E00738 VA: 0x1E04738
	public Material get_material() { }

	// RVA: 0x1E04888 Offset: 0x1E00888 VA: 0x1E04888
	public void set_material(Material value) { }

	// RVA: 0x1E0499C Offset: 0x1E0099C VA: 0x1E0499C
	public Material get_sharedMaterial() { }

	// RVA: 0x1E049A4 Offset: 0x1E009A4 VA: 0x1E049A4
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x1E049D0 Offset: 0x1E009D0 VA: 0x1E049D0
	public Material get_fallbackMaterial() { }

	// RVA: 0x1E049D8 Offset: 0x1E009D8 VA: 0x1E049D8
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x1E04B20 Offset: 0x1E00B20 VA: 0x1E04B20
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x1E04B28 Offset: 0x1E00B28 VA: 0x1E04B28
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x1E04B30 Offset: 0x1E00B30 VA: 0x1E04B30
	public bool get_isDefaultMaterial() { }

	// RVA: 0x1E04B38 Offset: 0x1E00B38 VA: 0x1E04B38
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x1E04B40 Offset: 0x1E00B40 VA: 0x1E04B40
	public float get_padding() { }

	// RVA: 0x1E04B48 Offset: 0x1E00B48 VA: 0x1E04B48
	public void set_padding(float value) { }

	// RVA: 0x1E04B50 Offset: 0x1E00B50 VA: 0x1E04B50
	public Renderer get_renderer() { }

	// RVA: 0x1E04BF0 Offset: 0x1E00BF0 VA: 0x1E04BF0
	public MeshFilter get_meshFilter() { }

	// RVA: 0x1E04D14 Offset: 0x1E00D14 VA: 0x1E04D14
	public Mesh get_mesh() { }

	// RVA: 0x1E04DD0 Offset: 0x1E00DD0 VA: 0x1E04DD0
	public void set_mesh(Mesh value) { }

	// RVA: 0x1E04DD8 Offset: 0x1E00DD8 VA: 0x1E04DD8
	public TMP_Text get_textComponent() { }

	// RVA: 0x1E04E78 Offset: 0x1E00E78 VA: 0x1E04E78
	public static TMP_SubMesh AddSubTextObject(TextMeshPro textComponent, MaterialReference materialReference) { }

	// RVA: 0x1E0516C Offset: 0x1E0116C VA: 0x1E0516C
	private void OnEnable() { }

	// RVA: 0x1E05298 Offset: 0x1E01298 VA: 0x1E05298
	private void OnDisable() { }

	// RVA: 0x1E05360 Offset: 0x1E01360 VA: 0x1E05360
	private void OnDestroy() { }

	// RVA: 0x1E054C4 Offset: 0x1E014C4 VA: 0x1E054C4
	public void DestroySelf() { }

	// RVA: 0x1E04740 Offset: 0x1E00740 VA: 0x1E04740
	private Material GetMaterial(Material mat) { }

	// RVA: 0x1E05534 Offset: 0x1E01534 VA: 0x1E05534
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0x1E055F4 Offset: 0x1E015F4 VA: 0x1E055F4
	private Material GetSharedMaterial() { }

	// RVA: 0x1E049A8 Offset: 0x1E009A8 VA: 0x1E049A8
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0x1E04920 Offset: 0x1E00920 VA: 0x1E04920
	public float GetPaddingForMaterial() { }

	// RVA: 0x1E056A0 Offset: 0x1E016A0 VA: 0x1E056A0
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x1E04994 Offset: 0x1E00994 VA: 0x1E04994
	public void SetVerticesDirty() { }

	// RVA: 0x1E04998 Offset: 0x1E00998 VA: 0x1E04998
	public void SetMaterialDirty() { }

	// RVA: 0x1E05714 Offset: 0x1E01714 VA: 0x1E05714
	protected void UpdateMaterial() { }

	// RVA: 0x1E058D8 Offset: 0x1E018D8 VA: 0x1E058D8
	public void .ctor() { }
}

// Namespace: TMPro
[ExecuteAlways]
[RequireComponent(typeof(CanvasRenderer))]
public class TMP_SubMeshUI : MaskableGraphic // TypeDefIndex: 5259
{
	// Fields
	[SerializeField]
	private TMP_FontAsset m_fontAsset; // 0xD8
	[SerializeField]
	private TMP_SpriteAsset m_spriteAsset; // 0xE0
	[SerializeField]
	private Material m_material; // 0xE8
	[SerializeField]
	private Material m_sharedMaterial; // 0xF0
	private Material m_fallbackMaterial; // 0xF8
	private Material m_fallbackSourceMaterial; // 0x100
	[SerializeField]
	private bool m_isDefaultMaterial; // 0x108
	[SerializeField]
	private float m_padding; // 0x10C
	private Mesh m_mesh; // 0x110
	[SerializeField]
	private TextMeshProUGUI m_TextComponent; // 0x118
	private bool m_isRegisteredForEvents; // 0x120
	private bool m_materialDirty; // 0x121
	[SerializeField]
	private int m_materialReferenceIndex; // 0x124
	private Transform m_RootCanvasTransform; // 0x128

	// Properties
	public TMP_FontAsset fontAsset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public override Texture mainTexture { get; }
	public override Material material { get; set; }
	public Material sharedMaterial { get; set; }
	public Material fallbackMaterial { get; set; }
	public Material fallbackSourceMaterial { get; set; }
	public override Material materialForRendering { get; }
	public bool isDefaultMaterial { get; set; }
	public float padding { get; set; }
	public Mesh mesh { get; set; }
	public TMP_Text textComponent { get; }

	// Methods

	// RVA: 0x1E058E0 Offset: 0x1E018E0 VA: 0x1E058E0
	public TMP_FontAsset get_fontAsset() { }

	// RVA: 0x1E058E8 Offset: 0x1E018E8 VA: 0x1E058E8
	public void set_fontAsset(TMP_FontAsset value) { }

	// RVA: 0x1E058F0 Offset: 0x1E018F0 VA: 0x1E058F0
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x1E058F8 Offset: 0x1E018F8 VA: 0x1E058F8
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x1E05900 Offset: 0x1E01900 VA: 0x1E05900 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x1E059BC Offset: 0x1E019BC VA: 0x1E059BC Slot: 32
	public override Material get_material() { }

	// RVA: 0x1E05AD0 Offset: 0x1E01AD0 VA: 0x1E05AD0 Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x1E05C4C Offset: 0x1E01C4C VA: 0x1E05C4C
	public Material get_sharedMaterial() { }

	// RVA: 0x1E05C54 Offset: 0x1E01C54 VA: 0x1E05C54
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x1E05CAC Offset: 0x1E01CAC VA: 0x1E05CAC
	public Material get_fallbackMaterial() { }

	// RVA: 0x1E05CB4 Offset: 0x1E01CB4 VA: 0x1E05CB4
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x1E05DFC Offset: 0x1E01DFC VA: 0x1E05DFC
	public Material get_fallbackSourceMaterial() { }

	// RVA: 0x1E05E04 Offset: 0x1E01E04 VA: 0x1E05E04
	public void set_fallbackSourceMaterial(Material value) { }

	// RVA: 0x1E05E14 Offset: 0x1E01E14 VA: 0x1E05E14 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x1E05E70 Offset: 0x1E01E70 VA: 0x1E05E70
	public bool get_isDefaultMaterial() { }

	// RVA: 0x1E05E78 Offset: 0x1E01E78 VA: 0x1E05E78
	public void set_isDefaultMaterial(bool value) { }

	// RVA: 0x1E05E80 Offset: 0x1E01E80 VA: 0x1E05E80
	public float get_padding() { }

	// RVA: 0x1E05E88 Offset: 0x1E01E88 VA: 0x1E05E88
	public void set_padding(float value) { }

	// RVA: 0x1E05E90 Offset: 0x1E01E90 VA: 0x1E05E90
	public Mesh get_mesh() { }

	// RVA: 0x1E05F4C Offset: 0x1E01F4C VA: 0x1E05F4C
	public void set_mesh(Mesh value) { }

	// RVA: 0x1E05F5C Offset: 0x1E01F5C VA: 0x1E05F5C
	public TMP_Text get_textComponent() { }

	// RVA: 0x1E05FF8 Offset: 0x1E01FF8 VA: 0x1E05FF8
	public static TMP_SubMeshUI AddSubTextObject(TextMeshProUGUI textComponent, MaterialReference materialReference) { }

	// RVA: 0x1E062FC Offset: 0x1E022FC VA: 0x1E062FC Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1E0636C Offset: 0x1E0236C VA: 0x1E0636C Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1E06428 Offset: 0x1E02428 VA: 0x1E06428 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1E065E4 Offset: 0x1E025E4 VA: 0x1E065E4 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1E06638 Offset: 0x1E02638 VA: 0x1E06638 Slot: 58
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1E05BD8 Offset: 0x1E01BD8 VA: 0x1E05BD8
	public float GetPaddingForMaterial() { }

	// RVA: 0x1E06748 Offset: 0x1E02748 VA: 0x1E06748
	public float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x1E067BC Offset: 0x1E027BC VA: 0x1E067BC
	public void UpdateMeshPadding(bool isExtraPadding, bool isUsingBold) { }

	// RVA: 0x1E06830 Offset: 0x1E02830 VA: 0x1E06830 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x1E06834 Offset: 0x1E02834 VA: 0x1E06834 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x1E06838 Offset: 0x1E02838 VA: 0x1E06838 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x1E0683C Offset: 0x1E0283C VA: 0x1E0683C Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x1E06880 Offset: 0x1E02880 VA: 0x1E06880
	public void SetPivotDirty() { }

	// RVA: 0x1E068E8 Offset: 0x1E028E8 VA: 0x1E068E8
	private Transform GetRootCanvasTransform() { }

	// RVA: 0x1E06990 Offset: 0x1E02990 VA: 0x1E06990 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x1E06994 Offset: 0x1E02994 VA: 0x1E06994 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x1E06998 Offset: 0x1E02998 VA: 0x1E06998 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1E069D0 Offset: 0x1E029D0 VA: 0x1E069D0
	public void RefreshMaterial() { }

	// RVA: 0x1E069E0 Offset: 0x1E029E0 VA: 0x1E069E0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x1E06BB4 Offset: 0x1E02BB4 VA: 0x1E06BB4 Slot: 63
	public override void RecalculateClipping() { }

	// RVA: 0x1E06BBC Offset: 0x1E02BBC VA: 0x1E06BBC
	private Material GetMaterial() { }

	// RVA: 0x1E059C4 Offset: 0x1E019C4 VA: 0x1E059C4
	private Material GetMaterial(Material mat) { }

	// RVA: 0x1E06BC4 Offset: 0x1E02BC4 VA: 0x1E06BC4
	private Material CreateMaterialInstance(Material source) { }

	// RVA: 0x1E06C84 Offset: 0x1E02C84 VA: 0x1E06C84
	private Material GetSharedMaterial() { }

	// RVA: 0x1E05C58 Offset: 0x1E01C58 VA: 0x1E05C58
	private void SetSharedMaterial(Material mat) { }

	// RVA: 0x1E06CA4 Offset: 0x1E02CA4 VA: 0x1E06CA4
	public void .ctor() { }
}

// Namespace: TMPro
public interface ITextElement // TypeDefIndex: 5260
{
	// Properties
	public abstract Material sharedMaterial { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Material get_sharedMaterial();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Rebuild(CanvasUpdate update);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int GetInstanceID();
}

// Namespace: TMPro
public enum TextAlignmentOptions // TypeDefIndex: 5261
{
	// Fields
	public int value__; // 0x0
	public const TextAlignmentOptions TopLeft = 257;
	public const TextAlignmentOptions Top = 258;
	public const TextAlignmentOptions TopRight = 260;
	public const TextAlignmentOptions TopJustified = 264;
	public const TextAlignmentOptions TopFlush = 272;
	public const TextAlignmentOptions TopGeoAligned = 288;
	public const TextAlignmentOptions Left = 513;
	public const TextAlignmentOptions Center = 514;
	public const TextAlignmentOptions Right = 516;
	public const TextAlignmentOptions Justified = 520;
	public const TextAlignmentOptions Flush = 528;
	public const TextAlignmentOptions CenterGeoAligned = 544;
	public const TextAlignmentOptions BottomLeft = 1025;
	public const TextAlignmentOptions Bottom = 1026;
	public const TextAlignmentOptions BottomRight = 1028;
	public const TextAlignmentOptions BottomJustified = 1032;
	public const TextAlignmentOptions BottomFlush = 1040;
	public const TextAlignmentOptions BottomGeoAligned = 1056;
	public const TextAlignmentOptions BaselineLeft = 2049;
	public const TextAlignmentOptions Baseline = 2050;
	public const TextAlignmentOptions BaselineRight = 2052;
	public const TextAlignmentOptions BaselineJustified = 2056;
	public const TextAlignmentOptions BaselineFlush = 2064;
	public const TextAlignmentOptions BaselineGeoAligned = 2080;
	public const TextAlignmentOptions MidlineLeft = 4097;
	public const TextAlignmentOptions Midline = 4098;
	public const TextAlignmentOptions MidlineRight = 4100;
	public const TextAlignmentOptions MidlineJustified = 4104;
	public const TextAlignmentOptions MidlineFlush = 4112;
	public const TextAlignmentOptions MidlineGeoAligned = 4128;
	public const TextAlignmentOptions CaplineLeft = 8193;
	public const TextAlignmentOptions Capline = 8194;
	public const TextAlignmentOptions CaplineRight = 8196;
	public const TextAlignmentOptions CaplineJustified = 8200;
	public const TextAlignmentOptions CaplineFlush = 8208;
	public const TextAlignmentOptions CaplineGeoAligned = 8224;
	public const TextAlignmentOptions Converted = 65535;
}

// Namespace: TMPro
public enum HorizontalAlignmentOptions // TypeDefIndex: 5262
{
	// Fields
	public int value__; // 0x0
	public const HorizontalAlignmentOptions Left = 1;
	public const HorizontalAlignmentOptions Center = 2;
	public const HorizontalAlignmentOptions Right = 4;
	public const HorizontalAlignmentOptions Justified = 8;
	public const HorizontalAlignmentOptions Flush = 16;
	public const HorizontalAlignmentOptions Geometry = 32;
}

// Namespace: TMPro
public enum VerticalAlignmentOptions // TypeDefIndex: 5263
{
	// Fields
	public int value__; // 0x0
	public const VerticalAlignmentOptions Top = 256;
	public const VerticalAlignmentOptions Middle = 512;
	public const VerticalAlignmentOptions Bottom = 1024;
	public const VerticalAlignmentOptions Baseline = 2048;
	public const VerticalAlignmentOptions Geometry = 4096;
	public const VerticalAlignmentOptions Capline = 8192;
}

// Namespace: TMPro
public enum TextRenderFlags // TypeDefIndex: 5264
{
	// Fields
	public int value__; // 0x0
	public const TextRenderFlags DontRender = 0;
	public const TextRenderFlags Render = 255;
}

// Namespace: TMPro
public enum TMP_TextElementType // TypeDefIndex: 5265
{
	// Fields
	public int value__; // 0x0
	public const TMP_TextElementType Character = 0;
	public const TMP_TextElementType Sprite = 1;
}

// Namespace: TMPro
public enum MaskingTypes // TypeDefIndex: 5266
{
	// Fields
	public int value__; // 0x0
	public const MaskingTypes MaskOff = 0;
	public const MaskingTypes MaskHard = 1;
	public const MaskingTypes MaskSoft = 2;
}

// Namespace: TMPro
public enum TextOverflowModes // TypeDefIndex: 5267
{
	// Fields
	public int value__; // 0x0
	public const TextOverflowModes Overflow = 0;
	public const TextOverflowModes Ellipsis = 1;
	public const TextOverflowModes Masking = 2;
	public const TextOverflowModes Truncate = 3;
	public const TextOverflowModes ScrollRect = 4;
	public const TextOverflowModes Page = 5;
	public const TextOverflowModes Linked = 6;
}

// Namespace: TMPro
public enum TextWrappingModes // TypeDefIndex: 5268
{
	// Fields
	public int value__; // 0x0
	public const TextWrappingModes NoWrap = 0;
	public const TextWrappingModes Normal = 1;
	public const TextWrappingModes PreserveWhitespace = 2;
	public const TextWrappingModes PreserveWhitespaceNoWrap = 3;
}

// Namespace: TMPro
public enum MaskingOffsetMode // TypeDefIndex: 5269
{
	// Fields
	public int value__; // 0x0
	public const MaskingOffsetMode Percentage = 0;
	public const MaskingOffsetMode Pixel = 1;
}

// Namespace: TMPro
public enum TextureMappingOptions // TypeDefIndex: 5270
{
	// Fields
	public int value__; // 0x0
	public const TextureMappingOptions Character = 0;
	public const TextureMappingOptions Line = 1;
	public const TextureMappingOptions Paragraph = 2;
	public const TextureMappingOptions MatchAspect = 3;
}

// Namespace: TMPro
[Flags]
public enum FontStyles // TypeDefIndex: 5271
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

// Namespace: TMPro
public enum FontWeight // TypeDefIndex: 5272
{
	// Fields
	public int value__; // 0x0
	public const FontWeight Thin = 100;
	public const FontWeight ExtraLight = 200;
	public const FontWeight Light = 300;
	public const FontWeight Regular = 400;
	public const FontWeight Medium = 500;
	public const FontWeight SemiBold = 600;
	public const FontWeight Bold = 700;
	public const FontWeight Heavy = 800;
	public const FontWeight Black = 900;
}

// Namespace: 
public sealed class TMP_Text.MissingCharacterEventCallback : MulticastDelegate // TypeDefIndex: 5273
{
	// Methods

	// RVA: 0x1E06CAC Offset: 0x1E02CAC VA: 0x1E06CAC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E06D4C Offset: 0x1E02D4C VA: 0x1E06D4C Slot: 12
	public virtual void Invoke(int unicode, int stringIndex, string text, TMP_FontAsset fontAsset, TMP_Text textComponent) { }

	// RVA: 0x1E06D60 Offset: 0x1E02D60 VA: 0x1E06D60 Slot: 13
	public virtual IAsyncResult BeginInvoke(int unicode, int stringIndex, string text, TMP_FontAsset fontAsset, TMP_Text textComponent, AsyncCallback callback, object object) { }

	// RVA: 0x1E06DF8 Offset: 0x1E02DF8 VA: 0x1E06DF8 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
protected struct TMP_Text.CharacterSubstitution // TypeDefIndex: 5274
{
	// Fields
	public int index; // 0x0
	public uint unicode; // 0x4

	// Methods

	// RVA: 0x1E06E04 Offset: 0x1E02E04 VA: 0x1E06E04
	public void .ctor(int index, uint unicode) { }
}

// Namespace: 
internal enum TMP_Text.TextInputSources // TypeDefIndex: 5275
{
	// Fields
	public int value__; // 0x0
	public const TMP_Text.TextInputSources TextInputBox = 0;
	public const TMP_Text.TextInputSources SetText = 1;
	public const TMP_Text.TextInputSources SetTextArray = 2;
	public const TMP_Text.TextInputSources TextString = 3;
}

// Namespace: 
[DebuggerDisplay("Unicode ({unicode})  '{(char)unicode}'")]
internal struct TMP_Text.TextProcessingElement // TypeDefIndex: 5276
{
	// Fields
	public TextProcessingElementType elementType; // 0x0
	public uint unicode; // 0x4
	public int stringIndex; // 0x8
	public int length; // 0xC
}

// Namespace: 
protected struct TMP_Text.SpecialCharacter // TypeDefIndex: 5277
{
	// Fields
	public TMP_Character character; // 0x0
	public TMP_FontAsset fontAsset; // 0x8
	public Material material; // 0x10
	public int materialIndex; // 0x18

	// Methods

	// RVA: 0x1E06E0C Offset: 0x1E02E0C VA: 0x1E06E0C
	public void .ctor(TMP_Character character, int materialIndex) { }
}

// Namespace: 
[DefaultMember("Item")]
private struct TMP_Text.TextBackingContainer // TypeDefIndex: 5278
{
	// Fields
	private uint[] m_Array; // 0x0
	private int m_Index; // 0x8

	// Properties
	public uint[] Text { get; }
	public int Capacity { get; }
	public int Count { get; set; }
	public uint Item { get; set; }

	// Methods

	// RVA: 0x1E06F58 Offset: 0x1E02F58 VA: 0x1E06F58
	public uint[] get_Text() { }

	// RVA: 0x1E06F60 Offset: 0x1E02F60 VA: 0x1E06F60
	public int get_Capacity() { }

	// RVA: 0x1E06F78 Offset: 0x1E02F78 VA: 0x1E06F78
	public int get_Count() { }

	// RVA: 0x1E06F80 Offset: 0x1E02F80 VA: 0x1E06F80
	public void set_Count(int value) { }

	// RVA: 0x1E06F88 Offset: 0x1E02F88 VA: 0x1E06F88
	public uint get_Item(int index) { }

	// RVA: 0x1E06FB8 Offset: 0x1E02FB8 VA: 0x1E06FB8
	public void set_Item(int index, uint value) { }

	// RVA: 0x1E07084 Offset: 0x1E03084 VA: 0x1E07084
	public void .ctor(int size) { }

	// RVA: 0x1E07018 Offset: 0x1E03018 VA: 0x1E07018
	public void Resize(int size) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TMP_Text.<>c // TypeDefIndex: 5279
{
	// Fields
	public static readonly TMP_Text.<>c <>9; // 0x0
	public static Action<TMP_TextInfo> <>9__648_0; // 0x8

	// Methods

	// RVA: 0x1E070F0 Offset: 0x1E030F0 VA: 0x1E070F0
	private static void .cctor() { }

	// RVA: 0x1E07158 Offset: 0x1E03158 VA: 0x1E07158
	public void .ctor() { }

	// RVA: 0x1E07160 Offset: 0x1E03160 VA: 0x1E07160
	internal void <.ctor>b__648_0(TMP_TextInfo <p0>) { }
}

// Namespace: TMPro
public abstract class TMP_Text : MaskableGraphic // TypeDefIndex: 5280
{
	// Fields
	[SerializeField]
	[TextArea(5, 10)]
	protected string m_text; // 0xD8
	private bool m_IsTextBackingStringDirty; // 0xE0
	[SerializeField]
	protected ITextPreprocessor m_TextPreprocessor; // 0xE8
	[SerializeField]
	protected bool m_isRightToLeft; // 0xF0
	[SerializeField]
	protected TMP_FontAsset m_fontAsset; // 0xF8
	protected TMP_FontAsset m_currentFontAsset; // 0x100
	protected bool m_isSDFShader; // 0x108
	[SerializeField]
	protected Material m_sharedMaterial; // 0x110
	protected Material m_currentMaterial; // 0x118
	protected static MaterialReference[] m_materialReferences; // 0x0
	protected static Dictionary<int, int> m_materialReferenceIndexLookup; // 0x8
	protected static TMP_TextProcessingStack<MaterialReference> m_materialReferenceStack; // 0x10
	protected int m_currentMaterialIndex; // 0x120
	[SerializeField]
	protected Material[] m_fontSharedMaterials; // 0x128
	[SerializeField]
	protected Material m_fontMaterial; // 0x130
	[SerializeField]
	protected Material[] m_fontMaterials; // 0x138
	protected bool m_isMaterialDirty; // 0x140
	[SerializeField]
	protected Color32 m_fontColor32; // 0x144
	[SerializeField]
	protected Color m_fontColor; // 0x148
	protected static Color32 s_colorWhite; // 0x68
	protected Color32 m_underlineColor; // 0x158
	protected Color32 m_strikethroughColor; // 0x15C
	internal HighlightState m_HighlightState; // 0x160
	internal bool m_ConvertToLinearSpace; // 0x174
	[SerializeField]
	protected bool m_enableVertexGradient; // 0x175
	[SerializeField]
	protected ColorMode m_colorMode; // 0x178
	[SerializeField]
	protected VertexGradient m_fontColorGradient; // 0x17C
	[SerializeField]
	protected TMP_ColorGradient m_fontColorGradientPreset; // 0x1C0
	[SerializeField]
	protected TMP_SpriteAsset m_spriteAsset; // 0x1C8
	[SerializeField]
	protected bool m_tintAllSprites; // 0x1D0
	protected bool m_tintSprite; // 0x1D1
	protected Color32 m_spriteColor; // 0x1D4
	[SerializeField]
	protected TMP_StyleSheet m_StyleSheet; // 0x1D8
	internal TMP_Style m_TextStyle; // 0x1E0
	[SerializeField]
	protected int m_TextStyleHashCode; // 0x1E8
	[SerializeField]
	protected bool m_overrideHtmlColors; // 0x1EC
	[SerializeField]
	protected Color32 m_faceColor; // 0x1F0
	protected Color32 m_outlineColor; // 0x1F4
	protected float m_outlineWidth; // 0x1F8
	protected Vector3 m_currentEnvMapRotation; // 0x1FC
	protected bool m_hasEnvMapProperty; // 0x208
	[SerializeField]
	protected float m_fontSize; // 0x20C
	protected float m_currentFontSize; // 0x210
	[SerializeField]
	protected float m_fontSizeBase; // 0x214
	protected TMP_TextProcessingStack<float> m_sizeStack; // 0x218
	[SerializeField]
	protected FontWeight m_fontWeight; // 0x238
	protected FontWeight m_FontWeightInternal; // 0x23C
	protected TMP_TextProcessingStack<FontWeight> m_FontWeightStack; // 0x240
	[SerializeField]
	protected bool m_enableAutoSizing; // 0x260
	protected float m_maxFontSize; // 0x264
	protected float m_minFontSize; // 0x268
	protected int m_AutoSizeIterationCount; // 0x26C
	protected int m_AutoSizeMaxIterationCount; // 0x270
	protected bool m_IsAutoSizePointSizeSet; // 0x274
	[SerializeField]
	protected float m_fontSizeMin; // 0x278
	[SerializeField]
	protected float m_fontSizeMax; // 0x27C
	[SerializeField]
	protected FontStyles m_fontStyle; // 0x280
	protected FontStyles m_FontStyleInternal; // 0x284
	protected TMP_FontStyleStack m_fontStyleStack; // 0x288
	protected bool m_isUsingBold; // 0x292
	[SerializeField]
	protected HorizontalAlignmentOptions m_HorizontalAlignment; // 0x294
	[SerializeField]
	protected VerticalAlignmentOptions m_VerticalAlignment; // 0x298
	[SerializeField]
	[FormerlySerializedAs("m_lineJustification")]
	protected TextAlignmentOptions m_textAlignment; // 0x29C
	protected HorizontalAlignmentOptions m_lineJustification; // 0x2A0
	protected TMP_TextProcessingStack<HorizontalAlignmentOptions> m_lineJustificationStack; // 0x2A8
	protected Vector3[] m_textContainerLocalCorners; // 0x2C8
	[SerializeField]
	protected float m_characterSpacing; // 0x2D0
	protected float m_cSpacing; // 0x2D4
	protected float m_monoSpacing; // 0x2D8
	protected bool m_duoSpace; // 0x2DC
	[SerializeField]
	internal float m_characterHorizontalScale; // 0x2E0
	[SerializeField]
	protected float m_wordSpacing; // 0x2E4
	[SerializeField]
	protected float m_lineSpacing; // 0x2E8
	protected float m_lineSpacingDelta; // 0x2EC
	protected float m_lineHeight; // 0x2F0
	protected bool m_IsDrivenLineSpacing; // 0x2F4
	[SerializeField]
	protected float m_lineSpacingMax; // 0x2F8
	[SerializeField]
	protected float m_paragraphSpacing; // 0x2FC
	[SerializeField]
	protected float m_charWidthMaxAdj; // 0x300
	protected float m_charWidthAdjDelta; // 0x304
	[SerializeField]
	[FormerlySerializedAs("m_enableWordWrapping")]
	protected TextWrappingModes m_TextWrappingMode; // 0x308
	protected bool m_isCharacterWrappingEnabled; // 0x30C
	protected bool m_isNonBreakingSpace; // 0x30D
	protected bool m_isIgnoringAlignment; // 0x30E
	[SerializeField]
	protected float m_wordWrappingRatios; // 0x310
	[SerializeField]
	protected TextOverflowModes m_overflowMode; // 0x314
	protected int m_firstOverflowCharacterIndex; // 0x318
	[SerializeField]
	protected TMP_Text m_linkedTextComponent; // 0x320
	[SerializeField]
	internal TMP_Text parentLinkedComponent; // 0x328
	protected bool m_isTextTruncated; // 0x330
	[SerializeField]
	protected bool m_enableKerning; // 0x331
	protected int m_LastBaseGlyphIndex; // 0x334
	[SerializeField]
	protected List<OTL_FeatureTag> m_ActiveFontFeatures; // 0x338
	[SerializeField]
	protected bool m_enableExtraPadding; // 0x340
	[SerializeField]
	protected bool checkPaddingRequired; // 0x341
	[SerializeField]
	protected bool m_isRichText; // 0x342
	[SerializeField]
	private bool m_EmojiFallbackSupport; // 0x343
	[SerializeField]
	protected bool m_parseCtrlCharacters; // 0x344
	protected bool m_isOverlay; // 0x345
	[SerializeField]
	protected bool m_isOrthographic; // 0x346
	[SerializeField]
	protected bool m_isCullingEnabled; // 0x347
	protected bool m_isMaskingEnabled; // 0x348
	protected bool isMaskUpdateRequired; // 0x349
	protected bool m_ignoreCulling; // 0x34A
	[SerializeField]
	protected TextureMappingOptions m_horizontalMapping; // 0x34C
	[SerializeField]
	protected TextureMappingOptions m_verticalMapping; // 0x350
	[SerializeField]
	protected float m_uvLineOffset; // 0x354
	protected TextRenderFlags m_renderMode; // 0x358
	[SerializeField]
	protected VertexSortingOrder m_geometrySortingOrder; // 0x35C
	[SerializeField]
	protected bool m_IsTextObjectScaleStatic; // 0x360
	[SerializeField]
	protected bool m_VertexBufferAutoSizeReduction; // 0x361
	protected int m_firstVisibleCharacter; // 0x364
	protected int m_maxVisibleCharacters; // 0x368
	protected int m_maxVisibleWords; // 0x36C
	protected int m_maxVisibleLines; // 0x370
	[SerializeField]
	protected bool m_useMaxVisibleDescender; // 0x374
	[SerializeField]
	protected int m_pageToDisplay; // 0x378
	protected bool m_isNewPage; // 0x37C
	[SerializeField]
	protected Vector4 m_margin; // 0x380
	protected float m_marginLeft; // 0x390
	protected float m_marginRight; // 0x394
	protected float m_marginWidth; // 0x398
	protected float m_marginHeight; // 0x39C
	protected float m_width; // 0x3A0
	protected TMP_TextInfo m_textInfo; // 0x3A8
	protected bool m_havePropertiesChanged; // 0x3B0
	[SerializeField]
	protected bool m_isUsingLegacyAnimationComponent; // 0x3B1
	protected Transform m_transform; // 0x3B8
	protected RectTransform m_rectTransform; // 0x3C0
	protected Vector2 m_PreviousRectTransformSize; // 0x3C8
	protected Vector2 m_PreviousPivotPosition; // 0x3D0
	[CompilerGenerated]
	private bool <autoSizeTextContainer>k__BackingField; // 0x3D8
	protected bool m_autoSizeTextContainer; // 0x3D9
	protected Mesh m_mesh; // 0x3E0
	[SerializeField]
	protected bool m_isVolumetricText; // 0x3E8
	[CompilerGenerated]
	private static Func<int, string, TMP_FontAsset> OnFontAssetRequest; // 0x70
	[CompilerGenerated]
	private static Func<int, string, TMP_SpriteAsset> OnSpriteAssetRequest; // 0x78
	[CompilerGenerated]
	private static TMP_Text.MissingCharacterEventCallback OnMissingCharacter; // 0x80
	[CompilerGenerated]
	private Action<TMP_TextInfo> OnPreRenderText; // 0x3F0
	protected TMP_SpriteAnimator m_spriteAnimator; // 0x3F8
	protected float m_flexibleHeight; // 0x400
	protected float m_flexibleWidth; // 0x404
	protected float m_minWidth; // 0x408
	protected float m_minHeight; // 0x40C
	protected float m_maxWidth; // 0x410
	protected float m_maxHeight; // 0x414
	protected LayoutElement m_LayoutElement; // 0x418
	protected float m_preferredWidth; // 0x420
	protected float m_RenderedWidth; // 0x424
	protected bool m_isPreferredWidthDirty; // 0x428
	protected float m_preferredHeight; // 0x42C
	protected float m_RenderedHeight; // 0x430
	protected bool m_isPreferredHeightDirty; // 0x434
	protected bool m_isCalculatingPreferredValues; // 0x435
	protected int m_layoutPriority; // 0x438
	protected bool m_isLayoutDirty; // 0x43C
	protected bool m_isAwake; // 0x43D
	internal bool m_isWaitingOnResourceLoad; // 0x43E
	internal TMP_Text.TextInputSources m_inputSource; // 0x440
	protected float m_fontScaleMultiplier; // 0x444
	private static char[] m_htmlTag; // 0x88
	private static RichTextTagAttribute[] m_xmlAttribute; // 0x90
	private static float[] m_attributeParameterValues; // 0x98
	protected float tag_LineIndent; // 0x448
	protected float tag_Indent; // 0x44C
	protected TMP_TextProcessingStack<float> m_indentStack; // 0x450
	protected bool tag_NoParsing; // 0x470
	protected bool m_isTextLayoutPhase; // 0x471
	protected Quaternion m_FXRotation; // 0x474
	protected Vector3 m_FXScale; // 0x484
	internal TMP_Text.TextProcessingElement[] m_TextProcessingArray; // 0x490
	internal int m_InternalTextProcessingArraySize; // 0x498
	private TMP_CharacterInfo[] m_internalCharacterInfo; // 0x4A0
	protected int m_totalCharacterCount; // 0x4A8
	internal static WordWrapState m_SavedWordWrapState; // 0xA0
	internal static WordWrapState m_SavedLineState; // 0x458
	internal static WordWrapState m_SavedEllipsisState; // 0x810
	internal static WordWrapState m_SavedLastValidState; // 0xBC8
	internal static WordWrapState m_SavedSoftLineBreakState; // 0xF80
	internal static TMP_TextProcessingStack<WordWrapState> m_EllipsisInsertionCandidateStack; // 0x1338
	protected int m_characterCount; // 0x4AC
	protected int m_firstCharacterOfLine; // 0x4B0
	protected int m_firstVisibleCharacterOfLine; // 0x4B4
	protected int m_lastCharacterOfLine; // 0x4B8
	protected int m_lastVisibleCharacterOfLine; // 0x4BC
	protected int m_lineNumber; // 0x4C0
	protected int m_lineVisibleCharacterCount; // 0x4C4
	protected int m_lineVisibleSpaceCount; // 0x4C8
	protected int m_pageNumber; // 0x4CC
	protected float m_PageAscender; // 0x4D0
	protected float m_maxTextAscender; // 0x4D4
	protected float m_maxCapHeight; // 0x4D8
	protected float m_ElementAscender; // 0x4DC
	protected float m_ElementDescender; // 0x4E0
	protected float m_maxLineAscender; // 0x4E4
	protected float m_maxLineDescender; // 0x4E8
	protected float m_startOfLineAscender; // 0x4EC
	protected float m_startOfLineDescender; // 0x4F0
	protected float m_lineOffset; // 0x4F4
	protected Extents m_meshExtents; // 0x4F8
	protected Color32 m_htmlColor; // 0x508
	protected TMP_TextProcessingStack<Color32> m_colorStack; // 0x510
	protected TMP_TextProcessingStack<Color32> m_underlineColorStack; // 0x530
	protected TMP_TextProcessingStack<Color32> m_strikethroughColorStack; // 0x550
	protected TMP_TextProcessingStack<HighlightState> m_HighlightStateStack; // 0x570
	protected TMP_ColorGradient m_colorGradientPreset; // 0x5A0
	protected TMP_TextProcessingStack<TMP_ColorGradient> m_colorGradientStack; // 0x5A8
	protected bool m_colorGradientPresetIsTinted; // 0x5D0
	protected float m_tabSpacing; // 0x5D4
	protected float m_spacing; // 0x5D8
	protected TMP_TextProcessingStack<int>[] m_TextStyleStacks; // 0x5E0
	protected int m_TextStyleStackDepth; // 0x5E8
	protected TMP_TextProcessingStack<int> m_ItalicAngleStack; // 0x5F0
	protected int m_ItalicAngle; // 0x610
	protected TMP_TextProcessingStack<int> m_actionStack; // 0x618
	protected float m_padding; // 0x638
	protected float m_baselineOffset; // 0x63C
	protected TMP_TextProcessingStack<float> m_baselineOffsetStack; // 0x640
	protected float m_xAdvance; // 0x660
	protected TMP_TextElementType m_textElementType; // 0x664
	protected TMP_TextElement m_cached_TextElement; // 0x668
	protected TMP_Text.SpecialCharacter m_Ellipsis; // 0x670
	protected TMP_Text.SpecialCharacter m_Underline; // 0x690
	protected TMP_SpriteAsset m_defaultSpriteAsset; // 0x6B0
	protected TMP_SpriteAsset m_currentSpriteAsset; // 0x6B8
	protected int m_spriteCount; // 0x6C0
	protected int m_spriteIndex; // 0x6C4
	protected int m_spriteAnimationID; // 0x6C8
	private static ProfilerMarker k_ParseTextMarker; // 0x1710
	private static ProfilerMarker k_InsertNewLineMarker; // 0x1718
	protected bool m_ignoreActiveState; // 0x6CC
	private TMP_Text.TextBackingContainer m_TextBackingArray; // 0x6D0
	private readonly Decimal[] k_Power; // 0x6E0
	protected static Vector2 k_LargePositiveVector2; // 0x1720
	protected static Vector2 k_LargeNegativeVector2; // 0x1728
	protected static float k_LargePositiveFloat; // 0x1730
	protected static float k_LargeNegativeFloat; // 0x1734
	protected static int k_LargePositiveInt; // 0x1738
	protected static int k_LargeNegativeInt; // 0x173C

	// Properties
	public virtual string text { get; set; }
	public ITextPreprocessor textPreprocessor { get; set; }
	public bool isRightToLeftText { get; set; }
	public TMP_FontAsset font { get; set; }
	public virtual Material fontSharedMaterial { get; set; }
	public virtual Material[] fontSharedMaterials { get; set; }
	public Material fontMaterial { get; set; }
	public virtual Material[] fontMaterials { get; set; }
	public override Color color { get; set; }
	public float alpha { get; set; }
	public bool enableVertexGradient { get; set; }
	public VertexGradient colorGradient { get; set; }
	public TMP_ColorGradient colorGradientPreset { get; set; }
	public TMP_SpriteAsset spriteAsset { get; set; }
	public bool tintAllSprites { get; set; }
	public TMP_StyleSheet styleSheet { get; set; }
	public TMP_Style textStyle { get; set; }
	public bool overrideColorTags { get; set; }
	public Color32 faceColor { get; set; }
	public Color32 outlineColor { get; set; }
	public float outlineWidth { get; set; }
	public float fontSize { get; set; }
	public FontWeight fontWeight { get; set; }
	public float pixelsPerUnit { get; }
	public bool enableAutoSizing { get; set; }
	public float fontSizeMin { get; set; }
	public float fontSizeMax { get; set; }
	public FontStyles fontStyle { get; set; }
	public bool isUsingBold { get; }
	public HorizontalAlignmentOptions horizontalAlignment { get; set; }
	public VerticalAlignmentOptions verticalAlignment { get; set; }
	public TextAlignmentOptions alignment { get; set; }
	public float characterSpacing { get; set; }
	public float characterHorizontalScale { get; set; }
	public float wordSpacing { get; set; }
	public float lineSpacing { get; set; }
	public float lineSpacingAdjustment { get; set; }
	public float paragraphSpacing { get; set; }
	public float characterWidthAdjustment { get; set; }
	public TextWrappingModes textWrappingMode { get; set; }
	[Obsolete("The enabledWordWrapping property is now obsolete. Please use the textWrappingMode property instead.")]
	public bool enableWordWrapping { get; set; }
	public float wordWrappingRatios { get; set; }
	public TextOverflowModes overflowMode { get; set; }
	public bool isTextOverflowing { get; }
	public int firstOverflowCharacterIndex { get; }
	public TMP_Text linkedTextComponent { get; set; }
	public bool isTextTruncated { get; }
	[Obsolete("The "enableKerning" property has been deprecated. Use the "fontFeatures" property to control what features are enabled on the text component.")]
	public bool enableKerning { get; set; }
	public List<OTL_FeatureTag> fontFeatures { get; set; }
	public bool extraPadding { get; set; }
	public bool richText { get; set; }
	public bool emojiFallbackSupport { get; set; }
	public bool parseCtrlCharacters { get; set; }
	public bool isOverlay { get; set; }
	public bool isOrthographic { get; set; }
	public bool enableCulling { get; set; }
	public bool ignoreVisibility { get; set; }
	public TextureMappingOptions horizontalMapping { get; set; }
	public TextureMappingOptions verticalMapping { get; set; }
	public float mappingUvLineOffset { get; set; }
	public TextRenderFlags renderMode { get; set; }
	public VertexSortingOrder geometrySortingOrder { get; set; }
	public bool isTextObjectScaleStatic { get; set; }
	public bool vertexBufferAutoSizeReduction { get; set; }
	public int firstVisibleCharacter { get; set; }
	public int maxVisibleCharacters { get; set; }
	public int maxVisibleWords { get; set; }
	public int maxVisibleLines { get; set; }
	public bool useMaxVisibleDescender { get; set; }
	public int pageToDisplay { get; set; }
	public virtual Vector4 margin { get; set; }
	public TMP_TextInfo textInfo { get; }
	public bool havePropertiesChanged { get; set; }
	public bool isUsingLegacyAnimationComponent { get; set; }
	public Transform transform { get; }
	public RectTransform rectTransform { get; }
	public virtual bool autoSizeTextContainer { get; set; }
	public virtual Mesh mesh { get; }
	public bool isVolumetricText { get; set; }
	public Bounds bounds { get; }
	public Bounds textBounds { get; }
	protected TMP_SpriteAnimator spriteAnimator { get; }
	public float flexibleHeight { get; }
	public float flexibleWidth { get; }
	public float minWidth { get; }
	public float minHeight { get; }
	public float maxWidth { get; }
	public float maxHeight { get; }
	protected LayoutElement layoutElement { get; }
	public virtual float preferredWidth { get; }
	public virtual float preferredHeight { get; }
	public virtual float renderedWidth { get; }
	public virtual float renderedHeight { get; }
	public int layoutPriority { get; }

	// Methods

	// RVA: 0x1DD4A04 Offset: 0x1DD0A04 VA: 0x1DD4A04 Slot: 65
	public virtual string get_text() { }

	// RVA: 0x1DD4AE8 Offset: 0x1DD0AE8 VA: 0x1DD4AE8 Slot: 66
	public virtual void set_text(string value) { }

	// RVA: 0x1DD4B8C Offset: 0x1DD0B8C VA: 0x1DD4B8C
	public ITextPreprocessor get_textPreprocessor() { }

	// RVA: 0x1DD4B94 Offset: 0x1DD0B94 VA: 0x1DD4B94
	public void set_textPreprocessor(ITextPreprocessor value) { }

	// RVA: 0x1DD4B9C Offset: 0x1DD0B9C VA: 0x1DD4B9C
	public bool get_isRightToLeftText() { }

	// RVA: 0x1DD4BA4 Offset: 0x1DD0BA4 VA: 0x1DD4BA4
	public void set_isRightToLeftText(bool value) { }

	// RVA: 0x1DD4BF4 Offset: 0x1DD0BF4 VA: 0x1DD4BF4
	public TMP_FontAsset get_font() { }

	// RVA: 0x1DD4BFC Offset: 0x1DD0BFC VA: 0x1DD4BFC
	public void set_font(TMP_FontAsset value) { }

	// RVA: 0x1DD4CD4 Offset: 0x1DD0CD4 VA: 0x1DD4CD4 Slot: 67
	public virtual Material get_fontSharedMaterial() { }

	// RVA: 0x1DD4CDC Offset: 0x1DD0CDC VA: 0x1DD4CDC Slot: 68
	public virtual void set_fontSharedMaterial(Material value) { }

	// RVA: 0x1DD4DA4 Offset: 0x1DD0DA4 VA: 0x1DD4DA4 Slot: 69
	public virtual Material[] get_fontSharedMaterials() { }

	// RVA: 0x1DD4DB4 Offset: 0x1DD0DB4 VA: 0x1DD4DB4 Slot: 70
	public virtual void set_fontSharedMaterials(Material[] value) { }

	// RVA: 0x1DD4E00 Offset: 0x1DD0E00 VA: 0x1DD4E00
	public Material get_fontMaterial() { }

	// RVA: 0x1DD4E14 Offset: 0x1DD0E14 VA: 0x1DD4E14
	public void set_fontMaterial(Material value) { }

	// RVA: 0x1DD4F1C Offset: 0x1DD0F1C VA: 0x1DD4F1C Slot: 71
	public virtual Material[] get_fontMaterials() { }

	// RVA: 0x1DD4F30 Offset: 0x1DD0F30 VA: 0x1DD4F30 Slot: 72
	public virtual void set_fontMaterials(Material[] value) { }

	// RVA: 0x1DD4F7C Offset: 0x1DD0F7C VA: 0x1DD4F7C Slot: 22
	public override Color get_color() { }

	// RVA: 0x1DD4F90 Offset: 0x1DD0F90 VA: 0x1DD4F90 Slot: 23
	public override void set_color(Color value) { }

	// RVA: 0x1DD5008 Offset: 0x1DD1008 VA: 0x1DD5008
	public float get_alpha() { }

	// RVA: 0x1DD5010 Offset: 0x1DD1010 VA: 0x1DD5010
	public void set_alpha(float value) { }

	// RVA: 0x1DD503C Offset: 0x1DD103C VA: 0x1DD503C
	public bool get_enableVertexGradient() { }

	// RVA: 0x1DD5044 Offset: 0x1DD1044 VA: 0x1DD5044
	public void set_enableVertexGradient(bool value) { }

	// RVA: 0x1DD5074 Offset: 0x1DD1074 VA: 0x1DD5074
	public VertexGradient get_colorGradient() { }

	// RVA: 0x1DD508C Offset: 0x1DD108C VA: 0x1DD508C
	public void set_colorGradient(VertexGradient value) { }

	// RVA: 0x1DD50B8 Offset: 0x1DD10B8 VA: 0x1DD50B8
	public TMP_ColorGradient get_colorGradientPreset() { }

	// RVA: 0x1DD50C0 Offset: 0x1DD10C0 VA: 0x1DD50C0
	public void set_colorGradientPreset(TMP_ColorGradient value) { }

	// RVA: 0x1DD50F4 Offset: 0x1DD10F4 VA: 0x1DD50F4
	public TMP_SpriteAsset get_spriteAsset() { }

	// RVA: 0x1DD50FC Offset: 0x1DD10FC VA: 0x1DD50FC
	public void set_spriteAsset(TMP_SpriteAsset value) { }

	// RVA: 0x1DD5144 Offset: 0x1DD1144 VA: 0x1DD5144
	public bool get_tintAllSprites() { }

	// RVA: 0x1DD514C Offset: 0x1DD114C VA: 0x1DD514C
	public void set_tintAllSprites(bool value) { }

	// RVA: 0x1DD517C Offset: 0x1DD117C VA: 0x1DD517C
	public TMP_StyleSheet get_styleSheet() { }

	// RVA: 0x1DD5184 Offset: 0x1DD1184 VA: 0x1DD5184
	public void set_styleSheet(TMP_StyleSheet value) { }

	// RVA: 0x1DD51CC Offset: 0x1DD11CC VA: 0x1DD51CC
	public TMP_Style get_textStyle() { }

	// RVA: 0x1DD5348 Offset: 0x1DD1348 VA: 0x1DD5348
	public void set_textStyle(TMP_Style value) { }

	// RVA: 0x1DD53A4 Offset: 0x1DD13A4 VA: 0x1DD53A4
	public bool get_overrideColorTags() { }

	// RVA: 0x1DD53AC Offset: 0x1DD13AC VA: 0x1DD53AC
	public void set_overrideColorTags(bool value) { }

	// RVA: 0x1DD53DC Offset: 0x1DD13DC VA: 0x1DD53DC
	public Color32 get_faceColor() { }

	// RVA: 0x1DD54A0 Offset: 0x1DD14A0 VA: 0x1DD54A0
	public void set_faceColor(Color32 value) { }

	// RVA: 0x1DD5524 Offset: 0x1DD1524 VA: 0x1DD5524
	public Color32 get_outlineColor() { }

	// RVA: 0x1DD55E8 Offset: 0x1DD15E8 VA: 0x1DD55E8
	public void set_outlineColor(Color32 value) { }

	// RVA: 0x1DD5658 Offset: 0x1DD1658 VA: 0x1DD5658
	public float get_outlineWidth() { }

	// RVA: 0x1DD5714 Offset: 0x1DD1714 VA: 0x1DD5714
	public void set_outlineWidth(float value) { }

	// RVA: 0x1DD576C Offset: 0x1DD176C VA: 0x1DD576C
	public float get_fontSize() { }

	// RVA: 0x1DD5774 Offset: 0x1DD1774 VA: 0x1DD5774
	public void set_fontSize(float value) { }

	// RVA: 0x1DD57D0 Offset: 0x1DD17D0 VA: 0x1DD57D0
	public FontWeight get_fontWeight() { }

	// RVA: 0x1DD57D8 Offset: 0x1DD17D8 VA: 0x1DD57D8
	public void set_fontWeight(FontWeight value) { }

	// RVA: 0x1DD5824 Offset: 0x1DD1824 VA: 0x1DD5824
	public float get_pixelsPerUnit() { }

	// RVA: 0x1DD599C Offset: 0x1DD199C VA: 0x1DD599C
	public bool get_enableAutoSizing() { }

	// RVA: 0x1DD59A4 Offset: 0x1DD19A4 VA: 0x1DD59A4
	public void set_enableAutoSizing(bool value) { }

	// RVA: 0x1DD59EC Offset: 0x1DD19EC VA: 0x1DD59EC
	public float get_fontSizeMin() { }

	// RVA: 0x1DD59F4 Offset: 0x1DD19F4 VA: 0x1DD59F4
	public void set_fontSizeMin(float value) { }

	// RVA: 0x1DD5A38 Offset: 0x1DD1A38 VA: 0x1DD5A38
	public float get_fontSizeMax() { }

	// RVA: 0x1DD5A40 Offset: 0x1DD1A40 VA: 0x1DD5A40
	public void set_fontSizeMax(float value) { }

	// RVA: 0x1DD5A84 Offset: 0x1DD1A84 VA: 0x1DD5A84
	public FontStyles get_fontStyle() { }

	// RVA: 0x1DD5A8C Offset: 0x1DD1A8C VA: 0x1DD5A8C
	public void set_fontStyle(FontStyles value) { }

	// RVA: 0x1DD5AD8 Offset: 0x1DD1AD8 VA: 0x1DD5AD8
	public bool get_isUsingBold() { }

	// RVA: 0x1DD5AE0 Offset: 0x1DD1AE0 VA: 0x1DD5AE0
	public HorizontalAlignmentOptions get_horizontalAlignment() { }

	// RVA: 0x1DD5AE8 Offset: 0x1DD1AE8 VA: 0x1DD5AE8
	public void set_horizontalAlignment(HorizontalAlignmentOptions value) { }

	// RVA: 0x1DD5B18 Offset: 0x1DD1B18 VA: 0x1DD5B18
	public VerticalAlignmentOptions get_verticalAlignment() { }

	// RVA: 0x1DD5B20 Offset: 0x1DD1B20 VA: 0x1DD5B20
	public void set_verticalAlignment(VerticalAlignmentOptions value) { }

	// RVA: 0x1DD5B50 Offset: 0x1DD1B50 VA: 0x1DD5B50
	public TextAlignmentOptions get_alignment() { }

	// RVA: 0x1DD5B60 Offset: 0x1DD1B60 VA: 0x1DD5B60
	public void set_alignment(TextAlignmentOptions value) { }

	// RVA: 0x1DD5BA4 Offset: 0x1DD1BA4 VA: 0x1DD5BA4
	public float get_characterSpacing() { }

	// RVA: 0x1DD5BAC Offset: 0x1DD1BAC VA: 0x1DD5BAC
	public void set_characterSpacing(float value) { }

	// RVA: 0x1DD5BF8 Offset: 0x1DD1BF8 VA: 0x1DD5BF8
	public float get_characterHorizontalScale() { }

	// RVA: 0x1DD5C00 Offset: 0x1DD1C00 VA: 0x1DD5C00
	public void set_characterHorizontalScale(float value) { }

	// RVA: 0x1DD5C4C Offset: 0x1DD1C4C VA: 0x1DD5C4C
	public float get_wordSpacing() { }

	// RVA: 0x1DD5C54 Offset: 0x1DD1C54 VA: 0x1DD5C54
	public void set_wordSpacing(float value) { }

	// RVA: 0x1DD5CA0 Offset: 0x1DD1CA0 VA: 0x1DD5CA0
	public float get_lineSpacing() { }

	// RVA: 0x1DD5CA8 Offset: 0x1DD1CA8 VA: 0x1DD5CA8
	public void set_lineSpacing(float value) { }

	// RVA: 0x1DD5CF4 Offset: 0x1DD1CF4 VA: 0x1DD5CF4
	public float get_lineSpacingAdjustment() { }

	// RVA: 0x1DD5CFC Offset: 0x1DD1CFC VA: 0x1DD5CFC
	public void set_lineSpacingAdjustment(float value) { }

	// RVA: 0x1DD5D48 Offset: 0x1DD1D48 VA: 0x1DD5D48
	public float get_paragraphSpacing() { }

	// RVA: 0x1DD5D50 Offset: 0x1DD1D50 VA: 0x1DD5D50
	public void set_paragraphSpacing(float value) { }

	// RVA: 0x1DD5D9C Offset: 0x1DD1D9C VA: 0x1DD5D9C
	public float get_characterWidthAdjustment() { }

	// RVA: 0x1DD5DA4 Offset: 0x1DD1DA4 VA: 0x1DD5DA4
	public void set_characterWidthAdjustment(float value) { }

	// RVA: 0x1DD5DF0 Offset: 0x1DD1DF0 VA: 0x1DD5DF0
	public TextWrappingModes get_textWrappingMode() { }

	// RVA: 0x1DD5DF8 Offset: 0x1DD1DF8 VA: 0x1DD5DF8
	public void set_textWrappingMode(TextWrappingModes value) { }

	// RVA: 0x1DD5E48 Offset: 0x1DD1E48 VA: 0x1DD5E48
	public bool get_enableWordWrapping() { }

	// RVA: 0x1DD5E5C Offset: 0x1DD1E5C VA: 0x1DD5E5C
	public void set_enableWordWrapping(bool value) { }

	// RVA: 0x1DD5EAC Offset: 0x1DD1EAC VA: 0x1DD5EAC
	public float get_wordWrappingRatios() { }

	// RVA: 0x1DD5EB4 Offset: 0x1DD1EB4 VA: 0x1DD5EB4
	public void set_wordWrappingRatios(float value) { }

	// RVA: 0x1DD5F00 Offset: 0x1DD1F00 VA: 0x1DD5F00
	public TextOverflowModes get_overflowMode() { }

	// RVA: 0x1DD5F08 Offset: 0x1DD1F08 VA: 0x1DD5F08
	public void set_overflowMode(TextOverflowModes value) { }

	// RVA: 0x1DD5F54 Offset: 0x1DD1F54 VA: 0x1DD5F54
	public bool get_isTextOverflowing() { }

	// RVA: 0x1DD5F64 Offset: 0x1DD1F64 VA: 0x1DD5F64
	public int get_firstOverflowCharacterIndex() { }

	// RVA: 0x1DD5F6C Offset: 0x1DD1F6C VA: 0x1DD5F6C
	public TMP_Text get_linkedTextComponent() { }

	// RVA: 0x1DD5F74 Offset: 0x1DD1F74 VA: 0x1DD5F74
	public void set_linkedTextComponent(TMP_Text value) { }

	// RVA: 0x1DD6288 Offset: 0x1DD2288 VA: 0x1DD6288
	public bool get_isTextTruncated() { }

	// RVA: 0x1DD6290 Offset: 0x1DD2290 VA: 0x1DD6290
	public bool get_enableKerning() { }

	// RVA: 0x1DD62E8 Offset: 0x1DD22E8 VA: 0x1DD62E8
	public void set_enableKerning(bool value) { }

	// RVA: 0x1DD6440 Offset: 0x1DD2440 VA: 0x1DD6440
	public List<OTL_FeatureTag> get_fontFeatures() { }

	// RVA: 0x1DD6448 Offset: 0x1DD2448 VA: 0x1DD6448
	public void set_fontFeatures(List<OTL_FeatureTag> value) { }

	// RVA: 0x1DD6498 Offset: 0x1DD2498 VA: 0x1DD6498
	public bool get_extraPadding() { }

	// RVA: 0x1DD64A0 Offset: 0x1DD24A0 VA: 0x1DD64A0
	public void set_extraPadding(bool value) { }

	// RVA: 0x1DD64F0 Offset: 0x1DD24F0 VA: 0x1DD64F0
	public bool get_richText() { }

	// RVA: 0x1DD64F8 Offset: 0x1DD24F8 VA: 0x1DD64F8
	public void set_richText(bool value) { }

	// RVA: 0x1DD6548 Offset: 0x1DD2548 VA: 0x1DD6548
	public bool get_emojiFallbackSupport() { }

	// RVA: 0x1DD6550 Offset: 0x1DD2550 VA: 0x1DD6550
	public void set_emojiFallbackSupport(bool value) { }

	// RVA: 0x1DD65A0 Offset: 0x1DD25A0 VA: 0x1DD65A0
	public bool get_parseCtrlCharacters() { }

	// RVA: 0x1DD65A8 Offset: 0x1DD25A8 VA: 0x1DD65A8
	public void set_parseCtrlCharacters(bool value) { }

	// RVA: 0x1DD65F8 Offset: 0x1DD25F8 VA: 0x1DD65F8
	public bool get_isOverlay() { }

	// RVA: 0x1DD6600 Offset: 0x1DD2600 VA: 0x1DD6600
	public void set_isOverlay(bool value) { }

	// RVA: 0x1DD6650 Offset: 0x1DD2650 VA: 0x1DD6650
	public bool get_isOrthographic() { }

	// RVA: 0x1DD6658 Offset: 0x1DD2658 VA: 0x1DD6658
	public void set_isOrthographic(bool value) { }

	// RVA: 0x1DD6688 Offset: 0x1DD2688 VA: 0x1DD6688
	public bool get_enableCulling() { }

	// RVA: 0x1DD6690 Offset: 0x1DD2690 VA: 0x1DD6690
	public void set_enableCulling(bool value) { }

	// RVA: 0x1DD66CC Offset: 0x1DD26CC VA: 0x1DD66CC
	public bool get_ignoreVisibility() { }

	// RVA: 0x1DD66D4 Offset: 0x1DD26D4 VA: 0x1DD66D4
	public void set_ignoreVisibility(bool value) { }

	// RVA: 0x1DD66F4 Offset: 0x1DD26F4 VA: 0x1DD66F4
	public TextureMappingOptions get_horizontalMapping() { }

	// RVA: 0x1DD66FC Offset: 0x1DD26FC VA: 0x1DD66FC
	public void set_horizontalMapping(TextureMappingOptions value) { }

	// RVA: 0x1DD672C Offset: 0x1DD272C VA: 0x1DD672C
	public TextureMappingOptions get_verticalMapping() { }

	// RVA: 0x1DD6734 Offset: 0x1DD2734 VA: 0x1DD6734
	public void set_verticalMapping(TextureMappingOptions value) { }

	// RVA: 0x1DD6764 Offset: 0x1DD2764 VA: 0x1DD6764
	public float get_mappingUvLineOffset() { }

	// RVA: 0x1DD676C Offset: 0x1DD276C VA: 0x1DD676C
	public void set_mappingUvLineOffset(float value) { }

	// RVA: 0x1DD6798 Offset: 0x1DD2798 VA: 0x1DD6798
	public TextRenderFlags get_renderMode() { }

	// RVA: 0x1DD67A0 Offset: 0x1DD27A0 VA: 0x1DD67A0
	public void set_renderMode(TextRenderFlags value) { }

	// RVA: 0x1DD67BC Offset: 0x1DD27BC VA: 0x1DD67BC
	public VertexSortingOrder get_geometrySortingOrder() { }

	// RVA: 0x1DD67C4 Offset: 0x1DD27C4 VA: 0x1DD67C4
	public void set_geometrySortingOrder(VertexSortingOrder value) { }

	// RVA: 0x1DD67E4 Offset: 0x1DD27E4 VA: 0x1DD67E4
	public bool get_isTextObjectScaleStatic() { }

	// RVA: 0x1DD67EC Offset: 0x1DD27EC VA: 0x1DD67EC
	public void set_isTextObjectScaleStatic(bool value) { }

	// RVA: 0x1DD687C Offset: 0x1DD287C VA: 0x1DD687C
	public bool get_vertexBufferAutoSizeReduction() { }

	// RVA: 0x1DD6884 Offset: 0x1DD2884 VA: 0x1DD6884
	public void set_vertexBufferAutoSizeReduction(bool value) { }

	// RVA: 0x1DD68A4 Offset: 0x1DD28A4 VA: 0x1DD68A4
	public int get_firstVisibleCharacter() { }

	// RVA: 0x1DD68AC Offset: 0x1DD28AC VA: 0x1DD68AC
	public void set_firstVisibleCharacter(int value) { }

	// RVA: 0x1DD68DC Offset: 0x1DD28DC VA: 0x1DD68DC
	public int get_maxVisibleCharacters() { }

	// RVA: 0x1DD68E4 Offset: 0x1DD28E4 VA: 0x1DD68E4
	public void set_maxVisibleCharacters(int value) { }

	// RVA: 0x1DD6914 Offset: 0x1DD2914 VA: 0x1DD6914
	public int get_maxVisibleWords() { }

	// RVA: 0x1DD691C Offset: 0x1DD291C VA: 0x1DD691C
	public void set_maxVisibleWords(int value) { }

	// RVA: 0x1DD694C Offset: 0x1DD294C VA: 0x1DD694C
	public int get_maxVisibleLines() { }

	// RVA: 0x1DD6954 Offset: 0x1DD2954 VA: 0x1DD6954
	public void set_maxVisibleLines(int value) { }

	// RVA: 0x1DD6984 Offset: 0x1DD2984 VA: 0x1DD6984
	public bool get_useMaxVisibleDescender() { }

	// RVA: 0x1DD698C Offset: 0x1DD298C VA: 0x1DD698C
	public void set_useMaxVisibleDescender(bool value) { }

	// RVA: 0x1DD69BC Offset: 0x1DD29BC VA: 0x1DD69BC
	public int get_pageToDisplay() { }

	// RVA: 0x1DD69C4 Offset: 0x1DD29C4 VA: 0x1DD69C4
	public void set_pageToDisplay(int value) { }

	// RVA: 0x1DD69F4 Offset: 0x1DD29F4 VA: 0x1DD69F4 Slot: 73
	public virtual Vector4 get_margin() { }

	// RVA: 0x1DD6A08 Offset: 0x1DD2A08 VA: 0x1DD6A08 Slot: 74
	public virtual void set_margin(Vector4 value) { }

	// RVA: 0x1DD6AA0 Offset: 0x1DD2AA0 VA: 0x1DD6AA0
	public TMP_TextInfo get_textInfo() { }

	// RVA: 0x1DD6B14 Offset: 0x1DD2B14 VA: 0x1DD6B14
	public bool get_havePropertiesChanged() { }

	// RVA: 0x1DD6B1C Offset: 0x1DD2B1C VA: 0x1DD6B1C
	public void set_havePropertiesChanged(bool value) { }

	// RVA: 0x1DD6B44 Offset: 0x1DD2B44 VA: 0x1DD6B44
	public bool get_isUsingLegacyAnimationComponent() { }

	// RVA: 0x1DD6B4C Offset: 0x1DD2B4C VA: 0x1DD6B4C
	public void set_isUsingLegacyAnimationComponent(bool value) { }

	// RVA: 0x1DD6B54 Offset: 0x1DD2B54 VA: 0x1DD6B54
	public Transform get_transform() { }

	// RVA: 0x1DD6BF4 Offset: 0x1DD2BF4 VA: 0x1DD6BF4
	public RectTransform get_rectTransform() { }

	[CompilerGenerated]
	// RVA: 0x1DD6C94 Offset: 0x1DD2C94 VA: 0x1DD6C94 Slot: 75
	public virtual bool get_autoSizeTextContainer() { }

	[CompilerGenerated]
	// RVA: 0x1DD6C9C Offset: 0x1DD2C9C VA: 0x1DD6C9C Slot: 76
	public virtual void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x1DD6CA4 Offset: 0x1DD2CA4 VA: 0x1DD6CA4 Slot: 77
	public virtual Mesh get_mesh() { }

	// RVA: 0x1DD6CAC Offset: 0x1DD2CAC VA: 0x1DD6CAC
	public bool get_isVolumetricText() { }

	// RVA: 0x1DD6CB4 Offset: 0x1DD2CB4 VA: 0x1DD6CB4
	public void set_isVolumetricText(bool value) { }

	// RVA: 0x1DD6D1C Offset: 0x1DD2D1C VA: 0x1DD6D1C
	public Bounds get_bounds() { }

	// RVA: 0x1DD6DCC Offset: 0x1DD2DCC VA: 0x1DD6DCC
	public Bounds get_textBounds() { }

	[CompilerGenerated]
	// RVA: 0x1DD6FD8 Offset: 0x1DD2FD8 VA: 0x1DD6FD8
	public static void add_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x1DD70CC Offset: 0x1DD30CC VA: 0x1DD70CC
	public static void remove_OnFontAssetRequest(Func<int, string, TMP_FontAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x1DD71C0 Offset: 0x1DD31C0 VA: 0x1DD71C0
	public static void add_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x1DD72B4 Offset: 0x1DD32B4 VA: 0x1DD72B4
	public static void remove_OnSpriteAssetRequest(Func<int, string, TMP_SpriteAsset> value) { }

	[CompilerGenerated]
	// RVA: 0x1DD73A8 Offset: 0x1DD33A8 VA: 0x1DD73A8
	public static void add_OnMissingCharacter(TMP_Text.MissingCharacterEventCallback value) { }

	[CompilerGenerated]
	// RVA: 0x1DD7484 Offset: 0x1DD3484 VA: 0x1DD7484
	public static void remove_OnMissingCharacter(TMP_Text.MissingCharacterEventCallback value) { }

	[CompilerGenerated]
	// RVA: 0x1DD7560 Offset: 0x1DD3560 VA: 0x1DD7560 Slot: 78
	public virtual void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x1DD7610 Offset: 0x1DD3610 VA: 0x1DD7610 Slot: 79
	public virtual void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x1DD76C0 Offset: 0x1DD36C0 VA: 0x1DD76C0
	protected TMP_SpriteAnimator get_spriteAnimator() { }

	// RVA: 0x1DD77D0 Offset: 0x1DD37D0 VA: 0x1DD77D0 Slot: 80
	public float get_flexibleHeight() { }

	// RVA: 0x1DD77D8 Offset: 0x1DD37D8 VA: 0x1DD77D8 Slot: 81
	public float get_flexibleWidth() { }

	// RVA: 0x1DD77E0 Offset: 0x1DD37E0 VA: 0x1DD77E0 Slot: 82
	public float get_minWidth() { }

	// RVA: 0x1DD77E8 Offset: 0x1DD37E8 VA: 0x1DD77E8 Slot: 83
	public float get_minHeight() { }

	// RVA: 0x1DD77F0 Offset: 0x1DD37F0 VA: 0x1DD77F0
	public float get_maxWidth() { }

	// RVA: 0x1DD77F8 Offset: 0x1DD37F8 VA: 0x1DD77F8
	public float get_maxHeight() { }

	// RVA: 0x1DD7800 Offset: 0x1DD3800 VA: 0x1DD7800
	protected LayoutElement get_layoutElement() { }

	// RVA: 0x1DD78A0 Offset: 0x1DD38A0 VA: 0x1DD78A0 Slot: 84
	public virtual float get_preferredWidth() { }

	// RVA: 0x1DD7A28 Offset: 0x1DD3A28 VA: 0x1DD7A28 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x1DD7BE0 Offset: 0x1DD3BE0 VA: 0x1DD7BE0 Slot: 86
	public virtual float get_renderedWidth() { }

	// RVA: 0x1DD7C28 Offset: 0x1DD3C28 VA: 0x1DD7C28 Slot: 87
	public virtual float get_renderedHeight() { }

	// RVA: 0x1DD7C70 Offset: 0x1DD3C70 VA: 0x1DD7C70 Slot: 88
	public int get_layoutPriority() { }

	// RVA: 0x1DD7C78 Offset: 0x1DD3C78 VA: 0x1DD7C78 Slot: 89
	protected virtual void LoadFontAsset() { }

	// RVA: 0x1DD7C7C Offset: 0x1DD3C7C VA: 0x1DD7C7C Slot: 90
	protected virtual void SetSharedMaterial(Material mat) { }

	// RVA: 0x1DD7C80 Offset: 0x1DD3C80 VA: 0x1DD7C80 Slot: 91
	protected virtual Material GetMaterial(Material mat) { }

	// RVA: 0x1DD7C88 Offset: 0x1DD3C88 VA: 0x1DD7C88 Slot: 92
	protected virtual void SetFontBaseMaterial(Material mat) { }

	// RVA: 0x1DD7C8C Offset: 0x1DD3C8C VA: 0x1DD7C8C Slot: 93
	protected virtual Material[] GetSharedMaterials() { }

	// RVA: 0x1DD7C94 Offset: 0x1DD3C94 VA: 0x1DD7C94 Slot: 94
	protected virtual void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x1DD7C98 Offset: 0x1DD3C98 VA: 0x1DD7C98 Slot: 95
	protected virtual Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x1DD7CA0 Offset: 0x1DD3CA0 VA: 0x1DD7CA0 Slot: 96
	protected virtual Material CreateMaterialInstance(Material source) { }

	// RVA: 0x1DD7D60 Offset: 0x1DD3D60 VA: 0x1DD7D60
	protected void SetVertexColorGradient(TMP_ColorGradient gradient) { }

	// RVA: 0x1DD7E1C Offset: 0x1DD3E1C VA: 0x1DD7E1C
	protected void SetTextSortingOrder(VertexSortingOrder order) { }

	// RVA: 0x1DD7E20 Offset: 0x1DD3E20 VA: 0x1DD7E20
	protected void SetTextSortingOrder(int[] order) { }

	// RVA: 0x1DD7E24 Offset: 0x1DD3E24 VA: 0x1DD7E24 Slot: 97
	protected virtual void SetFaceColor(Color32 color) { }

	// RVA: 0x1DD7E28 Offset: 0x1DD3E28 VA: 0x1DD7E28 Slot: 98
	protected virtual void SetOutlineColor(Color32 color) { }

	// RVA: 0x1DD7E2C Offset: 0x1DD3E2C VA: 0x1DD7E2C Slot: 99
	protected virtual void SetOutlineThickness(float thickness) { }

	// RVA: 0x1DD7E30 Offset: 0x1DD3E30 VA: 0x1DD7E30 Slot: 100
	protected virtual void SetShaderDepth() { }

	// RVA: 0x1DD7E34 Offset: 0x1DD3E34 VA: 0x1DD7E34 Slot: 101
	protected virtual void SetCulling() { }

	// RVA: 0x1DD7E38 Offset: 0x1DD3E38 VA: 0x1DD7E38 Slot: 102
	internal virtual void UpdateCulling() { }

	// RVA: 0x1DD7E3C Offset: 0x1DD3E3C VA: 0x1DD7E3C Slot: 103
	protected virtual float GetPaddingForMaterial() { }

	// RVA: 0x1DD7F5C Offset: 0x1DD3F5C VA: 0x1DD7F5C Slot: 104
	protected virtual float GetPaddingForMaterial(Material mat) { }

	// RVA: 0x1DD805C Offset: 0x1DD405C VA: 0x1DD805C Slot: 105
	protected virtual Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x1DD8064 Offset: 0x1DD4064 VA: 0x1DD8064 Slot: 106
	public virtual void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x1DD8068 Offset: 0x1DD4068 VA: 0x1DD8068 Slot: 107
	public virtual void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x1DD806C Offset: 0x1DD406C VA: 0x1DD806C Slot: 108
	public virtual void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x1DD8070 Offset: 0x1DD4070 VA: 0x1DD8070 Slot: 109
	public virtual void UpdateVertexData() { }

	// RVA: 0x1DD8074 Offset: 0x1DD4074 VA: 0x1DD8074 Slot: 110
	public virtual void SetVertices(Vector3[] vertices) { }

	// RVA: 0x1DD8078 Offset: 0x1DD4078 VA: 0x1DD8078 Slot: 111
	public virtual void UpdateMeshPadding() { }

	// RVA: 0x1DD807C Offset: 0x1DD407C VA: 0x1DD807C Slot: 47
	public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x1DD80FC Offset: 0x1DD40FC VA: 0x1DD80FC Slot: 49
	public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x1DD814C Offset: 0x1DD414C VA: 0x1DD814C Slot: 112
	protected virtual void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x1DD8150 Offset: 0x1DD4150 VA: 0x1DD8150 Slot: 113
	protected virtual void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x1DD8154 Offset: 0x1DD4154 VA: 0x1DD8154
	protected void ParseInputText() { }

	// RVA: 0x1DD8258 Offset: 0x1DD4258 VA: 0x1DD8258
	private void PopulateTextBackingArray(string sourceText) { }

	// RVA: 0x1DD8CA4 Offset: 0x1DD4CA4 VA: 0x1DD8CA4
	private void PopulateTextBackingArray(string sourceText, int start, int length) { }

	// RVA: 0x1DD8D9C Offset: 0x1DD4D9C VA: 0x1DD8D9C
	private void PopulateTextBackingArray(StringBuilder sourceText, int start, int length) { }

	// RVA: 0x1DD8EC0 Offset: 0x1DD4EC0 VA: 0x1DD8EC0
	private void PopulateTextBackingArray(char[] sourceText, int start, int length) { }

	// RVA: 0x1DD8270 Offset: 0x1DD4270 VA: 0x1DD8270
	private void PopulateTextProcessingArray() { }

	// RVA: 0x1DD9850 Offset: 0x1DD5850 VA: 0x1DD9850
	private void SetTextInternal(string sourceText) { }

	// RVA: 0x1DD989C Offset: 0x1DD589C VA: 0x1DD989C
	public void SetText(string sourceText) { }

	[Obsolete("Use the SetText(string) function instead.")]
	// RVA: 0x1DD9924 Offset: 0x1DD5924 VA: 0x1DD9924
	public void SetText(string sourceText, bool syncTextInputBox = True) { }

	// RVA: 0x1DD99AC Offset: 0x1DD59AC VA: 0x1DD99AC
	public void SetText(string sourceText, float arg0) { }

	// RVA: 0x1DD9D1C Offset: 0x1DD5D1C VA: 0x1DD9D1C
	public void SetText(string sourceText, float arg0, float arg1) { }

	// RVA: 0x1DD9D38 Offset: 0x1DD5D38 VA: 0x1DD9D38
	public void SetText(string sourceText, float arg0, float arg1, float arg2) { }

	// RVA: 0x1DD9D50 Offset: 0x1DD5D50 VA: 0x1DD9D50
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3) { }

	// RVA: 0x1DD9D64 Offset: 0x1DD5D64 VA: 0x1DD9D64
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4) { }

	// RVA: 0x1DD9D74 Offset: 0x1DD5D74 VA: 0x1DD9D74
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5) { }

	// RVA: 0x1DD9D80 Offset: 0x1DD5D80 VA: 0x1DD9D80
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6) { }

	// RVA: 0x1DD99CC Offset: 0x1DD59CC VA: 0x1DD99CC
	public void SetText(string sourceText, float arg0, float arg1, float arg2, float arg3, float arg4, float arg5, float arg6, float arg7) { }

	// RVA: 0x1DDA07C Offset: 0x1DD607C VA: 0x1DDA07C
	public void SetText(StringBuilder sourceText) { }

	// RVA: 0x1DDA0C0 Offset: 0x1DD60C0 VA: 0x1DDA0C0
	private void SetText(StringBuilder sourceText, int start, int length) { }

	// RVA: 0x1DDA11C Offset: 0x1DD611C VA: 0x1DDA11C
	public void SetText(char[] sourceText) { }

	// RVA: 0x1DDA190 Offset: 0x1DD6190 VA: 0x1DDA190
	public void SetText(char[] sourceText, int start, int length) { }

	// RVA: 0x1DDA194 Offset: 0x1DD6194 VA: 0x1DDA194
	public void SetCharArray(char[] sourceText) { }

	// RVA: 0x1DDA134 Offset: 0x1DD6134 VA: 0x1DDA134
	public void SetCharArray(char[] sourceText, int start, int length) { }

	// RVA: 0x1DD5224 Offset: 0x1DD1224 VA: 0x1DD5224
	private TMP_Style GetStyle(int hashCode) { }

	// RVA: 0x1DD9484 Offset: 0x1DD5484 VA: 0x1DD9484
	private void InsertOpeningTextStyle(TMP_Style style, ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1DD9638 Offset: 0x1DD5638 VA: 0x1DD9638
	private void InsertClosingTextStyle(TMP_Style style, ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1DDA1AC Offset: 0x1DD61AC VA: 0x1DDA1AC
	private void InsertTextStyleInTextProcessingArray(ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex, uint[] styleDefinition) { }

	// RVA: 0x1DD953C Offset: 0x1DD553C VA: 0x1DD953C
	private bool ReplaceOpeningStyleTag(ref TMP_Text.TextBackingContainer sourceText, int srcIndex, out int srcOffset, ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1DDA8D8 Offset: 0x1DD68D8 VA: 0x1DDA8D8
	private bool ReplaceOpeningStyleTag(ref uint[] sourceText, int srcIndex, out int srcOffset, ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1DD96F0 Offset: 0x1DD56F0 VA: 0x1DD96F0
	private void ReplaceClosingStyleTag(ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1DD8FD0 Offset: 0x1DD4FD0 VA: 0x1DD8FD0
	private void InsertOpeningStyleTag(TMP_Style style, ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1DD97B4 Offset: 0x1DD57B4 VA: 0x1DD97B4
	private void InsertClosingStyleTag(ref TMP_Text.TextProcessingElement[] charBuffer, ref int writeIndex) { }

	// RVA: 0x1DDA7D4 Offset: 0x1DD67D4 VA: 0x1DDA7D4
	private int GetMarkupTagHashCode(uint[] styleDefinition, int readIndex) { }

	// RVA: 0x1DD9390 Offset: 0x1DD5390 VA: 0x1DD9390
	private int GetMarkupTagHashCode(TMP_Text.TextBackingContainer styleDefinition, int readIndex) { }

	// RVA: 0x1DDAAE0 Offset: 0x1DD6AE0 VA: 0x1DDAAE0
	private int GetStyleHashCode(ref uint[] text, int index, out int closeIndex) { }

	// RVA: 0x1DDA9D4 Offset: 0x1DD69D4 VA: 0x1DDA9D4
	private int GetStyleHashCode(ref TMP_Text.TextBackingContainer text, int index, out int closeIndex) { }

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114E0A8 Offset: 0x114A0A8 VA: 0x114E0A8
	|-TMP_Text.ResizeInternalArray<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x114E10C Offset: 0x114A10C VA: 0x114E10C
	|-TMP_Text.ResizeInternalArray<TMP_Text.TextProcessingElement>
	*/

	// RVA: -1 Offset: -1
	private void ResizeInternalArray<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114E16C Offset: 0x114A16C VA: 0x114E16C
	|-TMP_Text.ResizeInternalArray<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0x114E1C4 Offset: 0x114A1C4 VA: 0x114E1C4
	|-TMP_Text.ResizeInternalArray<TMP_Text.TextProcessingElement>
	*/

	// RVA: 0x1DD9D88 Offset: 0x1DD5D88 VA: 0x1DD9D88
	private void AddFloatToInternalTextBackingArray(float value, int padding, int precision, ref int writeIndex) { }

	// RVA: 0x1DDABB4 Offset: 0x1DD6BB4 VA: 0x1DDABB4
	private void AddIntegerToInternalTextBackingArray(double number, int padding, ref int writeIndex) { }

	// RVA: 0x1DD4A18 Offset: 0x1DD0A18 VA: 0x1DD4A18
	private string InternalTextBackingArrayToString() { }

	// RVA: 0x1DDACE0 Offset: 0x1DD6CE0 VA: 0x1DDACE0 Slot: 114
	internal virtual int SetArraySizes(TMP_Text.TextProcessingElement[] unicodeChars) { }

	// RVA: 0x1DDACE8 Offset: 0x1DD6CE8 VA: 0x1DDACE8
	public Vector2 GetPreferredValues() { }

	// RVA: 0x1DDAD34 Offset: 0x1DD6D34 VA: 0x1DDAD34
	public Vector2 GetPreferredValues(float width, float height) { }

	// RVA: 0x1DDAE9C Offset: 0x1DD6E9C VA: 0x1DDAE9C
	public Vector2 GetPreferredValues(string text) { }

	// RVA: 0x1DDAF70 Offset: 0x1DD6F70 VA: 0x1DDAF70
	public Vector2 GetPreferredValues(string text, float width, float height) { }

	// RVA: 0x1DD78B8 Offset: 0x1DD38B8 VA: 0x1DD78B8
	protected float GetPreferredWidth() { }

	// RVA: 0x1DDAD94 Offset: 0x1DD6D94 VA: 0x1DDAD94
	private float GetPreferredWidth(Vector2 margin) { }

	// RVA: 0x1DDB034 Offset: 0x1DD7034 VA: 0x1DDB034
	private float GetPreferredWidth(Vector2 margin, TextWrappingModes wrapMode) { }

	// RVA: 0x1DD7A40 Offset: 0x1DD3A40 VA: 0x1DD7A40
	protected float GetPreferredHeight() { }

	// RVA: 0x1DDADFC Offset: 0x1DD6DFC VA: 0x1DDADFC
	private float GetPreferredHeight(Vector2 margin) { }

	// RVA: 0x1DDB090 Offset: 0x1DD7090 VA: 0x1DDB090
	public Vector2 GetRenderedValues() { }

	// RVA: 0x1DDB0B8 Offset: 0x1DD70B8 VA: 0x1DDB0B8
	public Vector2 GetRenderedValues(bool onlyVisibleCharacters) { }

	// RVA: 0x1DD7C04 Offset: 0x1DD3C04 VA: 0x1DD7C04
	private float GetRenderedWidth() { }

	// RVA: 0x1DDB2FC Offset: 0x1DD72FC VA: 0x1DDB2FC
	protected float GetRenderedWidth(bool onlyVisibleCharacters) { }

	// RVA: 0x1DD7C4C Offset: 0x1DD3C4C VA: 0x1DD7C4C
	private float GetRenderedHeight() { }

	// RVA: 0x1DDB320 Offset: 0x1DD7320 VA: 0x1DDB320
	protected float GetRenderedHeight(bool onlyVisibleCharacters) { }

	// RVA: 0x1DDB344 Offset: 0x1DD7344 VA: 0x1DDB344 Slot: 115
	protected virtual Vector2 CalculatePreferredValues(ref float fontSize, Vector2 marginSize, bool isTextAutoSizingEnabled, TextWrappingModes textWrapMode) { }

	// RVA: 0x1DE3610 Offset: 0x1DDF610 VA: 0x1DE3610 Slot: 116
	protected virtual Bounds GetCompoundBounds() { }

	// RVA: 0x1DE361C Offset: 0x1DDF61C VA: 0x1DE361C Slot: 117
	internal virtual Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x1DD6E10 Offset: 0x1DD2E10 VA: 0x1DD6E10
	protected Bounds GetTextBounds() { }

	// RVA: 0x1DDB0E0 Offset: 0x1DD70E0 VA: 0x1DDB0E0
	protected Bounds GetTextBounds(bool onlyVisibleCharacters) { }

	// RVA: 0x1DE3624 Offset: 0x1DDF624 VA: 0x1DE3624
	protected void AdjustLineOffset(int startIndex, int endIndex, float offset) { }

	// RVA: 0x1DE37E0 Offset: 0x1DDF7E0 VA: 0x1DE37E0
	protected void ResizeLineExtents(int size) { }

	// RVA: 0x1DE3984 Offset: 0x1DDF984 VA: 0x1DE3984 Slot: 118
	public virtual TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x1DE398C Offset: 0x1DDF98C VA: 0x1DE398C Slot: 119
	public virtual void ComputeMarginSize() { }

	// RVA: 0x1DE3990 Offset: 0x1DDF990 VA: 0x1DE3990
	internal void InsertNewLine(int i, float baseScale, float currentElementScale, float currentEmScale, float boldSpacingAdjustment, float characterSpacingAdjustment, float width, float lineGap, ref bool isMaxVisibleDescenderSet, ref float maxVisibleDescender) { }

	// RVA: 0x1DE3268 Offset: 0x1DDF268 VA: 0x1DE3268
	internal void SaveWordWrappingState(ref WordWrapState state, int index, int count) { }

	// RVA: 0x1DE2EB0 Offset: 0x1DDEEB0 VA: 0x1DE2EB0
	internal int RestoreWordWrappingState(ref WordWrapState state) { }

	// RVA: 0x1DE3E5C Offset: 0x1DDFE5C VA: 0x1DE3E5C Slot: 120
	protected virtual void SaveGlyphVertexInfo(float padding, float style_padding, Color32 vertexColor) { }

	// RVA: 0x1DE4AF4 Offset: 0x1DE0AF4 VA: 0x1DE4AF4 Slot: 121
	protected virtual void SaveSpriteVertexInfo(Color32 vertexColor) { }

	// RVA: 0x1DE5274 Offset: 0x1DE1274 VA: 0x1DE5274 Slot: 122
	protected virtual void FillCharacterVertexBuffers(int i) { }

	// RVA: 0x1DE5A98 Offset: 0x1DE1A98 VA: 0x1DE5A98 Slot: 123
	protected virtual void FillCharacterVertexBuffers(int i, bool isVolumetric) { }

	// RVA: 0x1DE65B0 Offset: 0x1DE25B0 VA: 0x1DE65B0 Slot: 124
	protected virtual void FillSpriteVertexBuffers(int i) { }

	// RVA: 0x1DE6DD4 Offset: 0x1DE2DD4 VA: 0x1DE6DD4 Slot: 125
	protected virtual void DrawUnderlineMesh(Vector3 start, Vector3 end, ref int index, float startScale, float endScale, float maxScale, float sdfScale, Color32 underlineColor) { }

	// RVA: 0x1DE7C44 Offset: 0x1DE3C44 VA: 0x1DE7C44 Slot: 126
	protected virtual void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor) { }

	// RVA: 0x1DE81D0 Offset: 0x1DE41D0 VA: 0x1DE81D0
	protected void LoadDefaultSettings() { }

	// RVA: 0x1DE85A8 Offset: 0x1DE45A8 VA: 0x1DE85A8
	protected void GetSpecialCharacters(TMP_FontAsset fontAsset) { }

	// RVA: 0x1DE85D0 Offset: 0x1DE45D0 VA: 0x1DE85D0
	protected void GetEllipsisSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x1DE7B84 Offset: 0x1DE3B84 VA: 0x1DE7B84
	protected void GetUnderlineSpecialCharacter(TMP_FontAsset fontAsset) { }

	// RVA: 0x1DE8884 Offset: 0x1DE4884 VA: 0x1DE8884
	protected void ReplaceTagWithCharacter(int[] chars, int insertionIndex, int tagLength, char c) { }

	// RVA: 0x1DE88F8 Offset: 0x1DE48F8 VA: 0x1DE88F8
	protected TMP_FontAsset GetFontAssetForWeight(int fontWeight) { }

	// RVA: 0x1DE899C Offset: 0x1DE499C VA: 0x1DE899C
	internal TMP_TextElement GetTextElement(uint unicode, TMP_FontAsset fontAsset, FontStyles fontStyle, FontWeight fontWeight, out bool isUsingAlternativeTypeface) { }

	// RVA: 0x1DE8F40 Offset: 0x1DE4F40 VA: 0x1DE8F40 Slot: 127
	protected virtual void SetActiveSubMeshes(bool state) { }

	// RVA: 0x1DE8F44 Offset: 0x1DE4F44 VA: 0x1DE8F44 Slot: 128
	protected virtual void DestroySubMeshObjects() { }

	// RVA: 0x1DE8F48 Offset: 0x1DE4F48 VA: 0x1DE8F48 Slot: 129
	public virtual void ClearMesh() { }

	// RVA: 0x1DE8F4C Offset: 0x1DE4F4C VA: 0x1DE8F4C Slot: 130
	public virtual void ClearMesh(bool uploadGeometry) { }

	// RVA: 0x1DE8F50 Offset: 0x1DE4F50 VA: 0x1DE8F50 Slot: 131
	public virtual string GetParsedText() { }

	// RVA: 0x1DD61A8 Offset: 0x1DD21A8 VA: 0x1DD61A8
	internal bool IsSelfOrLinkedAncestor(TMP_Text targetTextComponent) { }

	// RVA: 0x1DD6084 Offset: 0x1DD2084 VA: 0x1DD6084
	internal void ReleaseLinkedTextComponent(TMP_Text targetTextComponent) { }

	// RVA: 0x1DE9044 Offset: 0x1DE5044 VA: 0x1DE9044
	protected void DoMissingGlyphCallback(int unicode, int stringIndex, TMP_FontAsset fontAsset) { }

	// RVA: 0x1DE90F4 Offset: 0x1DE50F4 VA: 0x1DE90F4
	protected Vector2 PackUV(float x, float y, float scale) { }

	// RVA: 0x1DE914C Offset: 0x1DE514C VA: 0x1DE914C
	protected float PackUV(float x, float y) { }

	// RVA: 0x1DE91AC Offset: 0x1DE51AC VA: 0x1DE91AC Slot: 132
	internal virtual void InternalUpdate() { }

	// RVA: 0x1DE91B0 Offset: 0x1DE51B0 VA: 0x1DE91B0
	protected uint HexToInt(char hex) { }

	// RVA: 0x1DD9068 Offset: 0x1DD5068 VA: 0x1DD9068
	private bool IsValidUTF16(TMP_Text.TextBackingContainer text, int index) { }

	// RVA: 0x1DDA5E4 Offset: 0x1DD65E4 VA: 0x1DDA5E4
	private uint GetUTF16(uint[] text, int i) { }

	// RVA: 0x1DD910C Offset: 0x1DD510C VA: 0x1DD910C
	private uint GetUTF16(TMP_Text.TextBackingContainer text, int i) { }

	// RVA: 0x1DD91B4 Offset: 0x1DD51B4 VA: 0x1DD91B4
	private bool IsValidUTF32(TMP_Text.TextBackingContainer text, int index) { }

	// RVA: 0x1DDA68C Offset: 0x1DD668C VA: 0x1DDA68C
	private uint GetUTF32(uint[] text, int i) { }

	// RVA: 0x1DD9258 Offset: 0x1DD5258 VA: 0x1DD9258
	private uint GetUTF32(TMP_Text.TextBackingContainer text, int i) { }

	// RVA: 0x1DE91DC Offset: 0x1DE51DC VA: 0x1DE91DC
	protected Color32 HexCharsToColor(char[] hexChars, int tagCount) { }

	// RVA: 0x1DE9638 Offset: 0x1DE5638 VA: 0x1DE9638
	protected Color32 HexCharsToColor(char[] hexChars, int startIndex, int length) { }

	// RVA: 0x1DE9884 Offset: 0x1DE5884 VA: 0x1DE9884
	private int GetAttributeParameters(char[] chars, int startIndex, int length, ref float[] parameters) { }

	// RVA: 0x1DE9AA4 Offset: 0x1DE5AA4 VA: 0x1DE9AA4
	protected float ConvertToFloat(char[] chars, int startIndex, int length) { }

	// RVA: 0x1DE9930 Offset: 0x1DE5930 VA: 0x1DE9930
	protected float ConvertToFloat(char[] chars, int startIndex, int length, out int lastIndex) { }

	// RVA: 0x1DDDCD4 Offset: 0x1DD9CD4 VA: 0x1DDDCD4
	internal bool ValidateHtmlTag(TMP_Text.TextProcessingElement[] chars, int startIndex, out int endIndex) { }

	// RVA: 0x1DE9ABC Offset: 0x1DE5ABC VA: 0x1DE9ABC
	protected void .ctor() { }

	// RVA: 0x1DEA66C Offset: 0x1DE666C VA: 0x1DEA66C
	private static void .cctor() { }
}

// Namespace: TMPro
public enum TextElementType // TypeDefIndex: 5281
{
	// Fields
	public byte value__; // 0x0
	public const TextElementType Character = 1;
	public const TextElementType Sprite = 2;
}

// Namespace: TMPro
[Serializable]
public class TMP_TextElement // TypeDefIndex: 5282
{
	// Fields
	[SerializeField]
	internal TextElementType m_ElementType; // 0x10
	[SerializeField]
	internal uint m_Unicode; // 0x14
	internal TMP_Asset m_TextAsset; // 0x18
	internal Glyph m_Glyph; // 0x20
	[SerializeField]
	internal uint m_GlyphIndex; // 0x28
	[SerializeField]
	internal float m_Scale; // 0x2C

	// Properties
	public TextElementType elementType { get; }
	public uint unicode { get; set; }
	public TMP_Asset textAsset { get; set; }
	public Glyph glyph { get; set; }
	public uint glyphIndex { get; set; }
	public float scale { get; set; }

	// Methods

	// RVA: 0x1E07164 Offset: 0x1E03164 VA: 0x1E07164
	public TextElementType get_elementType() { }

	// RVA: 0x1E0716C Offset: 0x1E0316C VA: 0x1E0716C
	public uint get_unicode() { }

	// RVA: 0x1E07174 Offset: 0x1E03174 VA: 0x1E07174
	public void set_unicode(uint value) { }

	// RVA: 0x1E0717C Offset: 0x1E0317C VA: 0x1E0717C
	public TMP_Asset get_textAsset() { }

	// RVA: 0x1E07184 Offset: 0x1E03184 VA: 0x1E07184
	public void set_textAsset(TMP_Asset value) { }

	// RVA: 0x1E0718C Offset: 0x1E0318C VA: 0x1E0718C
	public Glyph get_glyph() { }

	// RVA: 0x1E07194 Offset: 0x1E03194 VA: 0x1E07194
	public void set_glyph(Glyph value) { }

	// RVA: 0x1E0719C Offset: 0x1E0319C VA: 0x1E0719C
	public uint get_glyphIndex() { }

	// RVA: 0x1E071A4 Offset: 0x1E031A4 VA: 0x1E071A4
	public void set_glyphIndex(uint value) { }

	// RVA: 0x1E071AC Offset: 0x1E031AC VA: 0x1E071AC
	public float get_scale() { }

	// RVA: 0x1E071B4 Offset: 0x1E031B4 VA: 0x1E071B4
	public void set_scale(float value) { }

	// RVA: 0x1E03B28 Offset: 0x1DFFB28 VA: 0x1E03B28
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_TextElement_Legacy // TypeDefIndex: 5283
{
	// Fields
	public int id; // 0x10
	public float x; // 0x14
	public float y; // 0x18
	public float width; // 0x1C
	public float height; // 0x20
	public float xOffset; // 0x24
	public float yOffset; // 0x28
	public float xAdvance; // 0x2C
	public float scale; // 0x30

	// Methods

	// RVA: 0x1E01198 Offset: 0x1DFD198 VA: 0x1E01198
	public void .ctor() { }
}

// Namespace: TMPro
[Serializable]
public class TMP_TextInfo // TypeDefIndex: 5284
{
	// Fields
	internal static Vector2 k_InfinityVectorPositive; // 0x0
	internal static Vector2 k_InfinityVectorNegative; // 0x8
	public TMP_Text textComponent; // 0x10
	public int characterCount; // 0x18
	public int spriteCount; // 0x1C
	public int spaceCount; // 0x20
	public int wordCount; // 0x24
	public int linkCount; // 0x28
	public int lineCount; // 0x2C
	public int pageCount; // 0x30
	public int materialCount; // 0x34
	public TMP_CharacterInfo[] characterInfo; // 0x38
	public TMP_WordInfo[] wordInfo; // 0x40
	public TMP_LinkInfo[] linkInfo; // 0x48
	public TMP_LineInfo[] lineInfo; // 0x50
	public TMP_PageInfo[] pageInfo; // 0x58
	public TMP_MeshInfo[] meshInfo; // 0x60
	private TMP_MeshInfo[] m_CachedMeshInfo; // 0x68

	// Methods

	// RVA: 0x1E071BC Offset: 0x1E031BC VA: 0x1E071BC
	public void .ctor() { }

	// RVA: 0x1E07328 Offset: 0x1E03328 VA: 0x1E07328
	internal void .ctor(int characterCount) { }

	// RVA: 0x1E07498 Offset: 0x1E03498 VA: 0x1E07498
	public void .ctor(TMP_Text textComponent) { }

	// RVA: 0x1E07668 Offset: 0x1E03668 VA: 0x1E07668
	internal void Clear() { }

	// RVA: 0x1E076BC Offset: 0x1E036BC VA: 0x1E076BC
	internal void ClearAllData() { }

	// RVA: 0x1E0782C Offset: 0x1E0382C VA: 0x1E0782C
	public void ClearMeshInfo(bool updateMesh) { }

	// RVA: 0x1E078E0 Offset: 0x1E038E0 VA: 0x1E078E0
	public void ClearAllMeshInfo() { }

	// RVA: 0x1E07990 Offset: 0x1E03990 VA: 0x1E07990
	public void ResetVertexLayout(bool isVolumetric) { }

	// RVA: 0x1E07A48 Offset: 0x1E03A48 VA: 0x1E07A48
	public void ClearUnusedVertices(MaterialReference[] materials) { }

	// RVA: 0x1E07AF8 Offset: 0x1E03AF8 VA: 0x1E07AF8
	internal void ClearLineInfo() { }

	// RVA: 0x1E07C84 Offset: 0x1E03C84 VA: 0x1E07C84
	internal void ClearPageInfo() { }

	// RVA: 0x1E07D2C Offset: 0x1E03D2C VA: 0x1E07D2C
	public TMP_MeshInfo[] CopyMeshInfoVertexData() { }

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114E218 Offset: 0x114A218 VA: 0x114E218
	|-TMP_TextInfo.Resize<object>
	|
	|-RVA: 0x114E278 Offset: 0x114A278 VA: 0x114E278
	|-TMP_TextInfo.Resize<TMP_LinkInfo>
	|
	|-RVA: 0x114E2D8 Offset: 0x114A2D8 VA: 0x114E2D8
	|-TMP_TextInfo.Resize<TMP_WordInfo>
	|
	|-RVA: 0x114E338 Offset: 0x114A338 VA: 0x114E338
	|-TMP_TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Resize<T>(ref T[] array, int size, bool isBlockAllocated) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114E39C Offset: 0x114A39C VA: 0x114E39C
	|-TMP_TextInfo.Resize<object>
	|
	|-RVA: 0x114E448 Offset: 0x114A448 VA: 0x114E448
	|-TMP_TextInfo.Resize<TMP_CharacterInfo>
	|
	|-RVA: 0x114E4F4 Offset: 0x114A4F4 VA: 0x114E4F4
	|-TMP_TextInfo.Resize<TMP_MeshInfo>
	|
	|-RVA: 0x114E5A0 Offset: 0x114A5A0 VA: 0x114E5A0
	|-TMP_TextInfo.Resize<TMP_PageInfo>
	|
	|-RVA: 0x114E64C Offset: 0x114A64C VA: 0x114E64C
	|-TMP_TextInfo.Resize<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E08170 Offset: 0x1E04170 VA: 0x1E08170
	private static void .cctor() { }
}

// Namespace: TMPro
public class TMP_TextParsingUtilities // TypeDefIndex: 5285
{
	// Fields
	private static readonly TMP_TextParsingUtilities s_Instance; // 0x0
	private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";
	private static readonly HashSet<uint> k_EmojiLookup; // 0x8
	private static readonly HashSet<uint> k_EmojiPresentationFormLookup; // 0x10

	// Properties
	public static TMP_TextParsingUtilities instance { get; }

	// Methods

	// RVA: 0x1DEAB10 Offset: 0x1DE6B10 VA: 0x1DEAB10
	private static void .cctor() { }

	// RVA: 0x1E081DC Offset: 0x1E041DC VA: 0x1E081DC
	public static TMP_TextParsingUtilities get_instance() { }

	// RVA: 0x1E03FFC Offset: 0x1DFFFFC VA: 0x1E03FFC
	public static int GetHashCode(string s) { }

	// RVA: 0x1E082A8 Offset: 0x1E042A8 VA: 0x1E082A8
	public static int GetHashCodeCaseSensitive(string s) { }

	// RVA: 0x1E08314 Offset: 0x1E04314 VA: 0x1E08314
	public static char ToLowerASCIIFast(char c) { }

	// RVA: 0x1E08234 Offset: 0x1E04234 VA: 0x1E08234
	public static char ToUpperASCIIFast(char c) { }

	// RVA: 0x1E08388 Offset: 0x1E04388 VA: 0x1E08388
	public static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x1E083FC Offset: 0x1E043FC VA: 0x1E083FC
	public static uint ToLowerASCIIFast(uint c) { }

	// RVA: 0x1E08470 Offset: 0x1E04470 VA: 0x1E08470
	public static bool IsHighSurrogate(uint c) { }

	// RVA: 0x1E08484 Offset: 0x1E04484 VA: 0x1E08484
	public static bool IsLowSurrogate(uint c) { }

	// RVA: 0x1E08498 Offset: 0x1E04498 VA: 0x1E08498
	internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	// RVA: 0x1E084AC Offset: 0x1E044AC VA: 0x1E084AC
	internal static bool IsDiacriticalMark(uint c) { }

	// RVA: 0x1E084EC Offset: 0x1E044EC VA: 0x1E084EC
	internal static bool IsBaseGlyph(uint c) { }

	// RVA: 0x1E0861C Offset: 0x1E0461C VA: 0x1E0861C
	internal static bool IsIgnorableForLigature(uint cp) { }

	// RVA: 0x1E08650 Offset: 0x1E04650 VA: 0x1E08650
	internal static bool IsEmoji(uint c) { }

	// RVA: 0x1E086D0 Offset: 0x1E046D0 VA: 0x1E086D0
	internal static bool IsEmojiPresentationForm(uint c) { }

	// RVA: 0x1E08750 Offset: 0x1E04750 VA: 0x1E08750
	internal static bool IsHangul(uint c) { }

	// RVA: 0x1E087AC Offset: 0x1E047AC VA: 0x1E087AC
	internal static bool IsCJK(uint c) { }

	// RVA: 0x1E088E8 Offset: 0x1E048E8 VA: 0x1E088E8
	public void .ctor() { }
}

// Namespace: TMPro
internal enum TextProcessingElementType // TypeDefIndex: 5286
{
	// Fields
	public int value__; // 0x0
	public const TextProcessingElementType Undefined = 0;
	public const TextProcessingElementType TextCharacterElement = 1;
	public const TextProcessingElementType TextMarkupElement = 2;
}

// Namespace: TMPro
internal struct CharacterElement // TypeDefIndex: 5287
{
	// Fields
	private uint m_Unicode; // 0x0
	private TMP_TextElement m_TextElement; // 0x8

	// Properties
	public uint Unicode { get; set; }

	// Methods

	// RVA: 0x1E088F0 Offset: 0x1E048F0 VA: 0x1E088F0
	public uint get_Unicode() { }

	// RVA: 0x1E088F8 Offset: 0x1E048F8 VA: 0x1E088F8
	public void set_Unicode(uint value) { }

	// RVA: 0x1E08900 Offset: 0x1E04900 VA: 0x1E08900
	public void .ctor(TMP_TextElement textElement) { }
}

// Namespace: TMPro
internal struct MarkupAttribute // TypeDefIndex: 5288
{
	// Fields
	private int m_NameHashCode; // 0x0
	private int m_ValueHashCode; // 0x4
	private int m_ValueStartIndex; // 0x8
	private int m_ValueLength; // 0xC

	// Properties
	public int NameHashCode { get; set; }
	public int ValueHashCode { get; set; }
	public int ValueStartIndex { get; set; }
	public int ValueLength { get; set; }

	// Methods

	// RVA: 0x1E0891C Offset: 0x1E0491C VA: 0x1E0891C
	public int get_NameHashCode() { }

	// RVA: 0x1E08924 Offset: 0x1E04924 VA: 0x1E08924
	public void set_NameHashCode(int value) { }

	// RVA: 0x1E0892C Offset: 0x1E0492C VA: 0x1E0892C
	public int get_ValueHashCode() { }

	// RVA: 0x1E08934 Offset: 0x1E04934 VA: 0x1E08934
	public void set_ValueHashCode(int value) { }

	// RVA: 0x1E0893C Offset: 0x1E0493C VA: 0x1E0893C
	public int get_ValueStartIndex() { }

	// RVA: 0x1E08944 Offset: 0x1E04944 VA: 0x1E08944
	public void set_ValueStartIndex(int value) { }

	// RVA: 0x1E0894C Offset: 0x1E0494C VA: 0x1E0894C
	public int get_ValueLength() { }

	// RVA: 0x1E08954 Offset: 0x1E04954 VA: 0x1E08954
	public void set_ValueLength(int value) { }
}

// Namespace: TMPro
internal struct MarkupElement // TypeDefIndex: 5289
{
	// Fields
	private MarkupAttribute[] m_Attributes; // 0x0

	// Properties
	public int NameHashCode { get; set; }
	public int ValueHashCode { get; set; }
	public int ValueStartIndex { get; set; }
	public int ValueLength { get; set; }
	public MarkupAttribute[] Attributes { get; set; }

	// Methods

	// RVA: 0x1E18704 Offset: 0x1E14704 VA: 0x1E18704
	public int get_NameHashCode() { }

	// RVA: 0x1E1872C Offset: 0x1E1472C VA: 0x1E1872C
	public void set_NameHashCode(int value) { }

	// RVA: 0x1E187B0 Offset: 0x1E147B0 VA: 0x1E187B0
	public int get_ValueHashCode() { }

	// RVA: 0x1E187D8 Offset: 0x1E147D8 VA: 0x1E187D8
	public void set_ValueHashCode(int value) { }

	// RVA: 0x1E18800 Offset: 0x1E14800 VA: 0x1E18800
	public int get_ValueStartIndex() { }

	// RVA: 0x1E18828 Offset: 0x1E14828 VA: 0x1E18828
	public void set_ValueStartIndex(int value) { }

	// RVA: 0x1E18850 Offset: 0x1E14850 VA: 0x1E18850
	public int get_ValueLength() { }

	// RVA: 0x1E18878 Offset: 0x1E14878 VA: 0x1E18878
	public void set_ValueLength(int value) { }

	// RVA: 0x1E188A0 Offset: 0x1E148A0 VA: 0x1E188A0
	public MarkupAttribute[] get_Attributes() { }

	// RVA: 0x1E188A8 Offset: 0x1E148A8 VA: 0x1E188A8
	public void set_Attributes(MarkupAttribute[] value) { }

	// RVA: 0x1E188B0 Offset: 0x1E148B0 VA: 0x1E188B0
	public void .ctor(int nameHashCode, int startIndex, int length) { }
}

// Namespace: TMPro
[DebuggerDisplay("{DebuggerDisplay()}")]
internal struct TextProcessingElement // TypeDefIndex: 5290
{
	// Fields
	private TextProcessingElementType m_ElementType; // 0x0
	private int m_StartIndex; // 0x4
	private int m_Length; // 0x8
	private CharacterElement m_CharacterElement; // 0x10
	private MarkupElement m_MarkupElement; // 0x20

	// Properties
	public TextProcessingElementType ElementType { get; set; }
	public int StartIndex { get; set; }
	public int Length { get; set; }
	public CharacterElement CharacterElement { get; }
	public MarkupElement MarkupElement { get; set; }
	public static TextProcessingElement Undefined { get; }

	// Methods

	// RVA: 0x1E18948 Offset: 0x1E14948 VA: 0x1E18948
	public TextProcessingElementType get_ElementType() { }

	// RVA: 0x1E18950 Offset: 0x1E14950 VA: 0x1E18950
	public void set_ElementType(TextProcessingElementType value) { }

	// RVA: 0x1E18958 Offset: 0x1E14958 VA: 0x1E18958
	public int get_StartIndex() { }

	// RVA: 0x1E18960 Offset: 0x1E14960 VA: 0x1E18960
	public void set_StartIndex(int value) { }

	// RVA: 0x1E18968 Offset: 0x1E14968 VA: 0x1E18968
	public int get_Length() { }

	// RVA: 0x1E18970 Offset: 0x1E14970 VA: 0x1E18970
	public void set_Length(int value) { }

	// RVA: 0x1E18978 Offset: 0x1E14978 VA: 0x1E18978
	public CharacterElement get_CharacterElement() { }

	// RVA: 0x1E18984 Offset: 0x1E14984 VA: 0x1E18984
	public MarkupElement get_MarkupElement() { }

	// RVA: 0x1E1898C Offset: 0x1E1498C VA: 0x1E1898C
	public void set_MarkupElement(MarkupElement value) { }

	// RVA: 0x1E18998 Offset: 0x1E14998 VA: 0x1E18998
	public void .ctor(TextProcessingElementType elementType, int startIndex, int length) { }

	// RVA: 0x1E189AC Offset: 0x1E149AC VA: 0x1E189AC
	public void .ctor(TMP_TextElement textElement, int startIndex, int length) { }

	// RVA: 0x1E189F8 Offset: 0x1E149F8 VA: 0x1E189F8
	public void .ctor(CharacterElement characterElement, int startIndex, int length) { }

	// RVA: 0x1E18A28 Offset: 0x1E14A28 VA: 0x1E18A28
	public void .ctor(MarkupElement markupElement) { }

	// RVA: 0x1E18A70 Offset: 0x1E14A70 VA: 0x1E18A70
	public static TextProcessingElement get_Undefined() { }

	// RVA: 0x1E18A80 Offset: 0x1E14A80 VA: 0x1E18A80
	private string DebuggerDisplay() { }
}

// Namespace: TMPro
public struct TMP_FontStyleStack // TypeDefIndex: 5291
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

	// RVA: 0x1E18B90 Offset: 0x1E14B90 VA: 0x1E18B90
	public void Clear() { }

	// RVA: 0x1E18B9C Offset: 0x1E14B9C VA: 0x1E18B9C
	public byte Add(FontStyles style) { }

	// RVA: 0x1E18CA0 Offset: 0x1E14CA0 VA: 0x1E18CA0
	public byte Remove(FontStyles style) { }
}

// Namespace: TMPro
[DebuggerDisplay("Item count = {m_Count}")]
public struct TMP_TextProcessingStack<T> // TypeDefIndex: 5292
{
	// Fields
	public T[] itemStack; // 0x0
	public int index; // 0x0
	private T m_DefaultItem; // 0x0
	private int m_Capacity; // 0x0
	private int m_RolloverSize; // 0x0
	private int m_Count; // 0x0
	private const int k_DefaultCapacity = 4;

	// Properties
	public int Count { get; }
	public T current { get; }
	public int rolloverSize { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(T[] stack) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467B60 Offset: 0x1463B60 VA: 0x1467B60
	|-TMP_TextProcessingStack<Color32>..ctor
	|
	|-RVA: 0x146811C Offset: 0x146411C VA: 0x146811C
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x1468840 Offset: 0x1464840 VA: 0x1468840
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x1468DFC Offset: 0x1464DFC VA: 0x1468DFC
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x14693B8 Offset: 0x14653B8 VA: 0x14693B8
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x1469BE0 Offset: 0x1465BE0 VA: 0x1469BE0
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x146A1D0 Offset: 0x14661D0 VA: 0x146A1D0
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x146A798 Offset: 0x1466798 VA: 0x146A798
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x146AF6C Offset: 0x1466F6C VA: 0x146AF6C
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467BA0 Offset: 0x1463BA0 VA: 0x1467BA0
	|-TMP_TextProcessingStack<Color32>..ctor
	|
	|-RVA: 0x146815C Offset: 0x146415C VA: 0x146815C
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x1468880 Offset: 0x1464880 VA: 0x1468880
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x1468E3C Offset: 0x1464E3C VA: 0x1468E3C
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x1469404 Offset: 0x1465404 VA: 0x1469404
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x1469C20 Offset: 0x1465C20 VA: 0x1469C20
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x146A210 Offset: 0x1466210 VA: 0x146A210
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x146A7E8 Offset: 0x14667E8 VA: 0x146A7E8
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x146B0F0 Offset: 0x14670F0 VA: 0x146B0F0
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, int rolloverSize) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467C18 Offset: 0x1463C18 VA: 0x1467C18
	|-TMP_TextProcessingStack<Color32>..ctor
	|
	|-RVA: 0x14681D4 Offset: 0x14641D4 VA: 0x14681D4
	|-TMP_TextProcessingStack<HighlightState>..ctor
	|
	|-RVA: 0x14688F8 Offset: 0x14648F8 VA: 0x14688F8
	|-TMP_TextProcessingStack<int>..ctor
	|
	|-RVA: 0x1468EB4 Offset: 0x1464EB4 VA: 0x1468EB4
	|-TMP_TextProcessingStack<Int32Enum>..ctor
	|
	|-RVA: 0x1469488 Offset: 0x1465488 VA: 0x1469488
	|-TMP_TextProcessingStack<MaterialReference>..ctor
	|
	|-RVA: 0x1469C98 Offset: 0x1465C98 VA: 0x1469C98
	|-TMP_TextProcessingStack<object>..ctor
	|
	|-RVA: 0x146A288 Offset: 0x1466288 VA: 0x146A288
	|-TMP_TextProcessingStack<float>..ctor
	|
	|-RVA: 0x146A870 Offset: 0x1466870 VA: 0x146A870
	|-TMP_TextProcessingStack<WordWrapState>..ctor
	|
	|-RVA: 0x146B2AC Offset: 0x14672AC VA: 0x146B2AC
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467C90 Offset: 0x1463C90 VA: 0x1467C90
	|-TMP_TextProcessingStack<Color32>.get_Count
	|
	|-RVA: 0x1468254 Offset: 0x1464254 VA: 0x1468254
	|-TMP_TextProcessingStack<HighlightState>.get_Count
	|
	|-RVA: 0x1468970 Offset: 0x1464970 VA: 0x1468970
	|-TMP_TextProcessingStack<int>.get_Count
	|
	|-RVA: 0x1468F2C Offset: 0x1464F2C VA: 0x1468F2C
	|-TMP_TextProcessingStack<Int32Enum>.get_Count
	|
	|-RVA: 0x1469510 Offset: 0x1465510 VA: 0x1469510
	|-TMP_TextProcessingStack<MaterialReference>.get_Count
	|
	|-RVA: 0x1469D14 Offset: 0x1465D14 VA: 0x1469D14
	|-TMP_TextProcessingStack<object>.get_Count
	|
	|-RVA: 0x146A300 Offset: 0x1466300 VA: 0x146A300
	|-TMP_TextProcessingStack<float>.get_Count
	|
	|-RVA: 0x146A8FC Offset: 0x14668FC VA: 0x146A8FC
	|-TMP_TextProcessingStack<WordWrapState>.get_Count
	|
	|-RVA: 0x146B474 Offset: 0x1467474 VA: 0x146B474
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public T get_current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467C98 Offset: 0x1463C98 VA: 0x1467C98
	|-TMP_TextProcessingStack<Color32>.get_current
	|
	|-RVA: 0x146825C Offset: 0x146425C VA: 0x146825C
	|-TMP_TextProcessingStack<HighlightState>.get_current
	|
	|-RVA: 0x1468978 Offset: 0x1464978 VA: 0x1468978
	|-TMP_TextProcessingStack<int>.get_current
	|
	|-RVA: 0x1468F34 Offset: 0x1464F34 VA: 0x1468F34
	|-TMP_TextProcessingStack<Int32Enum>.get_current
	|
	|-RVA: 0x1469518 Offset: 0x1465518 VA: 0x1469518
	|-TMP_TextProcessingStack<MaterialReference>.get_current
	|
	|-RVA: 0x1469D1C Offset: 0x1465D1C VA: 0x1469D1C
	|-TMP_TextProcessingStack<object>.get_current
	|
	|-RVA: 0x146A308 Offset: 0x1466308 VA: 0x146A308
	|-TMP_TextProcessingStack<float>.get_current
	|
	|-RVA: 0x146A904 Offset: 0x1466904 VA: 0x146A904
	|-TMP_TextProcessingStack<WordWrapState>.get_current
	|
	|-RVA: 0x146B4BC Offset: 0x14674BC VA: 0x146B4BC
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.get_current
	*/

	// RVA: -1 Offset: -1
	public int get_rolloverSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467CE4 Offset: 0x1463CE4 VA: 0x1467CE4
	|-TMP_TextProcessingStack<Color32>.get_rolloverSize
	|
	|-RVA: 0x14682B8 Offset: 0x14642B8 VA: 0x14682B8
	|-TMP_TextProcessingStack<HighlightState>.get_rolloverSize
	|
	|-RVA: 0x14689C4 Offset: 0x14649C4 VA: 0x14689C4
	|-TMP_TextProcessingStack<int>.get_rolloverSize
	|
	|-RVA: 0x1468F80 Offset: 0x1464F80 VA: 0x1468F80
	|-TMP_TextProcessingStack<Int32Enum>.get_rolloverSize
	|
	|-RVA: 0x146957C Offset: 0x146557C VA: 0x146957C
	|-TMP_TextProcessingStack<MaterialReference>.get_rolloverSize
	|
	|-RVA: 0x1469D68 Offset: 0x1465D68 VA: 0x1469D68
	|-TMP_TextProcessingStack<object>.get_rolloverSize
	|
	|-RVA: 0x146A354 Offset: 0x1466354 VA: 0x146A354
	|-TMP_TextProcessingStack<float>.get_rolloverSize
	|
	|-RVA: 0x146A95C Offset: 0x146695C VA: 0x146A95C
	|-TMP_TextProcessingStack<WordWrapState>.get_rolloverSize
	|
	|-RVA: 0x146B620 Offset: 0x1467620 VA: 0x146B620
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.get_rolloverSize
	*/

	// RVA: -1 Offset: -1
	public void set_rolloverSize(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467CEC Offset: 0x1463CEC VA: 0x1467CEC
	|-TMP_TextProcessingStack<Color32>.set_rolloverSize
	|
	|-RVA: 0x14682C0 Offset: 0x14642C0 VA: 0x14682C0
	|-TMP_TextProcessingStack<HighlightState>.set_rolloverSize
	|
	|-RVA: 0x14689CC Offset: 0x14649CC VA: 0x14689CC
	|-TMP_TextProcessingStack<int>.set_rolloverSize
	|
	|-RVA: 0x1468F88 Offset: 0x1464F88 VA: 0x1468F88
	|-TMP_TextProcessingStack<Int32Enum>.set_rolloverSize
	|
	|-RVA: 0x1469584 Offset: 0x1465584 VA: 0x1469584
	|-TMP_TextProcessingStack<MaterialReference>.set_rolloverSize
	|
	|-RVA: 0x1469D70 Offset: 0x1465D70 VA: 0x1469D70
	|-TMP_TextProcessingStack<object>.set_rolloverSize
	|
	|-RVA: 0x146A35C Offset: 0x146635C VA: 0x146A35C
	|-TMP_TextProcessingStack<float>.set_rolloverSize
	|
	|-RVA: 0x146A964 Offset: 0x1466964 VA: 0x146A964
	|-TMP_TextProcessingStack<WordWrapState>.set_rolloverSize
	|
	|-RVA: 0x146B668 Offset: 0x1467668 VA: 0x146B668
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.set_rolloverSize
	*/

	// RVA: -1 Offset: -1
	internal static void SetDefault(TMP_TextProcessingStack<T>[] stack, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467CF4 Offset: 0x1463CF4 VA: 0x1467CF4
	|-TMP_TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x14682C8 Offset: 0x14642C8 VA: 0x14682C8
	|-TMP_TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x14689D4 Offset: 0x14649D4 VA: 0x14689D4
	|-TMP_TextProcessingStack<int>.SetDefault
	|
	|-RVA: 0x1468F90 Offset: 0x1464F90 VA: 0x1468F90
	|-TMP_TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x146958C Offset: 0x146558C VA: 0x146958C
	|-TMP_TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x1469D78 Offset: 0x1465D78 VA: 0x1469D78
	|-TMP_TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x146A364 Offset: 0x1466364 VA: 0x146A364
	|-TMP_TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x146A96C Offset: 0x146696C VA: 0x146A96C
	|-TMP_TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x146B6B8 Offset: 0x14676B8 VA: 0x146B6B8
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467D84 Offset: 0x1463D84 VA: 0x1467D84
	|-TMP_TextProcessingStack<Color32>.Clear
	|
	|-RVA: 0x146837C Offset: 0x146437C VA: 0x146837C
	|-TMP_TextProcessingStack<HighlightState>.Clear
	|
	|-RVA: 0x1468A64 Offset: 0x1464A64 VA: 0x1468A64
	|-TMP_TextProcessingStack<int>.Clear
	|
	|-RVA: 0x1469020 Offset: 0x1465020 VA: 0x1469020
	|-TMP_TextProcessingStack<Int32Enum>.Clear
	|
	|-RVA: 0x1469650 Offset: 0x1465650 VA: 0x1469650
	|-TMP_TextProcessingStack<MaterialReference>.Clear
	|
	|-RVA: 0x1469E08 Offset: 0x1465E08 VA: 0x1469E08
	|-TMP_TextProcessingStack<object>.Clear
	|
	|-RVA: 0x146A3FC Offset: 0x14663FC VA: 0x146A3FC
	|-TMP_TextProcessingStack<float>.Clear
	|
	|-RVA: 0x146AA30 Offset: 0x1466A30 VA: 0x146AA30
	|-TMP_TextProcessingStack<WordWrapState>.Clear
	|
	|-RVA: 0x146B8AC Offset: 0x14678AC VA: 0x146B8AC
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	public void SetDefault(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467D90 Offset: 0x1463D90 VA: 0x1467D90
	|-TMP_TextProcessingStack<Color32>.SetDefault
	|
	|-RVA: 0x1468388 Offset: 0x1464388 VA: 0x1468388
	|-TMP_TextProcessingStack<HighlightState>.SetDefault
	|
	|-RVA: 0x1468A70 Offset: 0x1464A70 VA: 0x1468A70
	|-TMP_TextProcessingStack<int>.SetDefault
	|
	|-RVA: 0x146902C Offset: 0x146502C VA: 0x146902C
	|-TMP_TextProcessingStack<Int32Enum>.SetDefault
	|
	|-RVA: 0x146965C Offset: 0x146565C VA: 0x146965C
	|-TMP_TextProcessingStack<MaterialReference>.SetDefault
	|
	|-RVA: 0x1469E14 Offset: 0x1465E14 VA: 0x1469E14
	|-TMP_TextProcessingStack<object>.SetDefault
	|
	|-RVA: 0x146A408 Offset: 0x1466408 VA: 0x146A408
	|-TMP_TextProcessingStack<float>.SetDefault
	|
	|-RVA: 0x146AA3C Offset: 0x1466A3C VA: 0x146AA3C
	|-TMP_TextProcessingStack<WordWrapState>.SetDefault
	|
	|-RVA: 0x146B92C Offset: 0x146792C VA: 0x146B92C
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.SetDefault
	*/

	// RVA: -1 Offset: -1
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467E2C Offset: 0x1463E2C VA: 0x1467E2C
	|-TMP_TextProcessingStack<Color32>.Add
	|
	|-RVA: 0x1468464 Offset: 0x1464464 VA: 0x1468464
	|-TMP_TextProcessingStack<HighlightState>.Add
	|
	|-RVA: 0x1468B0C Offset: 0x1464B0C VA: 0x1468B0C
	|-TMP_TextProcessingStack<int>.Add
	|
	|-RVA: 0x14690C8 Offset: 0x14650C8 VA: 0x14690C8
	|-TMP_TextProcessingStack<Int32Enum>.Add
	|
	|-RVA: 0x1469760 Offset: 0x1465760 VA: 0x1469760
	|-TMP_TextProcessingStack<MaterialReference>.Add
	|
	|-RVA: 0x1469EB8 Offset: 0x1465EB8 VA: 0x1469EB8
	|-TMP_TextProcessingStack<object>.Add
	|
	|-RVA: 0x146A4A4 Offset: 0x14664A4 VA: 0x146A4A4
	|-TMP_TextProcessingStack<float>.Add
	|
	|-RVA: 0x146AB30 Offset: 0x1466B30 VA: 0x146AB30
	|-TMP_TextProcessingStack<WordWrapState>.Add
	|
	|-RVA: 0x146BC64 Offset: 0x1467C64 VA: 0x146BC64
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public T Remove() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467E74 Offset: 0x1463E74 VA: 0x1467E74
	|-TMP_TextProcessingStack<Color32>.Remove
	|
	|-RVA: 0x14684C0 Offset: 0x14644C0 VA: 0x14684C0
	|-TMP_TextProcessingStack<HighlightState>.Remove
	|
	|-RVA: 0x1468B54 Offset: 0x1464B54 VA: 0x1468B54
	|-TMP_TextProcessingStack<int>.Remove
	|
	|-RVA: 0x1469110 Offset: 0x1465110 VA: 0x1469110
	|-TMP_TextProcessingStack<Int32Enum>.Remove
	|
	|-RVA: 0x14697D4 Offset: 0x14657D4 VA: 0x14697D4
	|-TMP_TextProcessingStack<MaterialReference>.Remove
	|
	|-RVA: 0x1469F08 Offset: 0x1465F08 VA: 0x1469F08
	|-TMP_TextProcessingStack<object>.Remove
	|
	|-RVA: 0x146A4E8 Offset: 0x14664E8 VA: 0x146A4E8
	|-TMP_TextProcessingStack<float>.Remove
	|
	|-RVA: 0x146AB9C Offset: 0x1466B9C VA: 0x146AB9C
	|-TMP_TextProcessingStack<WordWrapState>.Remove
	|
	|-RVA: 0x146BF38 Offset: 0x1467F38 VA: 0x146BF38
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Push(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467EE8 Offset: 0x1463EE8 VA: 0x1467EE8
	|-TMP_TextProcessingStack<Color32>.Push
	|
	|-RVA: 0x1468544 Offset: 0x1464544 VA: 0x1468544
	|-TMP_TextProcessingStack<HighlightState>.Push
	|
	|-RVA: 0x1468BC8 Offset: 0x1464BC8 VA: 0x1468BC8
	|-TMP_TextProcessingStack<int>.Push
	|
	|-RVA: 0x1469184 Offset: 0x1465184 VA: 0x1469184
	|-TMP_TextProcessingStack<Int32Enum>.Push
	|
	|-RVA: 0x1469860 Offset: 0x1465860 VA: 0x1469860
	|-TMP_TextProcessingStack<MaterialReference>.Push
	|
	|-RVA: 0x1469F7C Offset: 0x1465F7C VA: 0x1469F7C
	|-TMP_TextProcessingStack<object>.Push
	|
	|-RVA: 0x146A55C Offset: 0x146655C VA: 0x146A55C
	|-TMP_TextProcessingStack<float>.Push
	|
	|-RVA: 0x146AC1C Offset: 0x1466C1C VA: 0x146AC1C
	|-TMP_TextProcessingStack<WordWrapState>.Push
	|
	|-RVA: 0x146C1C4 Offset: 0x14681C4 VA: 0x146C1C4
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Push
	*/

	// RVA: -1 Offset: -1
	public T Pop() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1467FB8 Offset: 0x1463FB8 VA: 0x1467FB8
	|-TMP_TextProcessingStack<Color32>.Pop
	|
	|-RVA: 0x1468628 Offset: 0x1464628 VA: 0x1468628
	|-TMP_TextProcessingStack<HighlightState>.Pop
	|
	|-RVA: 0x1468C98 Offset: 0x1464C98 VA: 0x1468C98
	|-TMP_TextProcessingStack<int>.Pop
	|
	|-RVA: 0x1469254 Offset: 0x1465254 VA: 0x1469254
	|-TMP_TextProcessingStack<Int32Enum>.Pop
	|
	|-RVA: 0x1469958 Offset: 0x1465958 VA: 0x1469958
	|-TMP_TextProcessingStack<MaterialReference>.Pop
	|
	|-RVA: 0x146A054 Offset: 0x1466054 VA: 0x146A054
	|-TMP_TextProcessingStack<object>.Pop
	|
	|-RVA: 0x146A630 Offset: 0x1466630 VA: 0x146A630
	|-TMP_TextProcessingStack<float>.Pop
	|
	|-RVA: 0x146AD08 Offset: 0x1466D08 VA: 0x146AD08
	|-TMP_TextProcessingStack<WordWrapState>.Pop
	|
	|-RVA: 0x146C83C Offset: 0x146883C VA: 0x146C83C
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Pop
	*/

	// RVA: -1 Offset: -1
	public T Peek() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x146803C Offset: 0x146403C VA: 0x146803C
	|-TMP_TextProcessingStack<Color32>.Peek
	|
	|-RVA: 0x1468730 Offset: 0x1464730 VA: 0x1468730
	|-TMP_TextProcessingStack<HighlightState>.Peek
	|
	|-RVA: 0x1468D1C Offset: 0x1464D1C VA: 0x1468D1C
	|-TMP_TextProcessingStack<int>.Peek
	|
	|-RVA: 0x14692D8 Offset: 0x14652D8 VA: 0x14692D8
	|-TMP_TextProcessingStack<Int32Enum>.Peek
	|
	|-RVA: 0x1469AB8 Offset: 0x1465AB8 VA: 0x1469AB8
	|-TMP_TextProcessingStack<MaterialReference>.Peek
	|
	|-RVA: 0x146A0F0 Offset: 0x14660F0 VA: 0x146A0F0
	|-TMP_TextProcessingStack<object>.Peek
	|
	|-RVA: 0x146A6B8 Offset: 0x14666B8 VA: 0x146A6B8
	|-TMP_TextProcessingStack<float>.Peek
	|
	|-RVA: 0x146AE6C Offset: 0x1466E6C VA: 0x146AE6C
	|-TMP_TextProcessingStack<WordWrapState>.Peek
	|
	|-RVA: 0x146CEB4 Offset: 0x1468EB4 VA: 0x146CEB4
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.Peek
	*/

	// RVA: -1 Offset: -1
	public T CurrentItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1468084 Offset: 0x1464084 VA: 0x1468084
	|-TMP_TextProcessingStack<Color32>.CurrentItem
	|
	|-RVA: 0x1468788 Offset: 0x1464788 VA: 0x1468788
	|-TMP_TextProcessingStack<HighlightState>.CurrentItem
	|
	|-RVA: 0x1468D64 Offset: 0x1464D64 VA: 0x1468D64
	|-TMP_TextProcessingStack<int>.CurrentItem
	|
	|-RVA: 0x1469320 Offset: 0x1465320 VA: 0x1469320
	|-TMP_TextProcessingStack<Int32Enum>.CurrentItem
	|
	|-RVA: 0x1469B18 Offset: 0x1465B18 VA: 0x1469B18
	|-TMP_TextProcessingStack<MaterialReference>.CurrentItem
	|
	|-RVA: 0x146A138 Offset: 0x1466138 VA: 0x146A138
	|-TMP_TextProcessingStack<object>.CurrentItem
	|
	|-RVA: 0x146A700 Offset: 0x1466700 VA: 0x146A700
	|-TMP_TextProcessingStack<float>.CurrentItem
	|
	|-RVA: 0x146AEBC Offset: 0x1466EBC VA: 0x146AEBC
	|-TMP_TextProcessingStack<WordWrapState>.CurrentItem
	|
	|-RVA: 0x146D00C Offset: 0x146900C VA: 0x146D00C
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.CurrentItem
	*/

	// RVA: -1 Offset: -1
	public T PreviousItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14680D0 Offset: 0x14640D0 VA: 0x14680D0
	|-TMP_TextProcessingStack<Color32>.PreviousItem
	|
	|-RVA: 0x14687E4 Offset: 0x14647E4 VA: 0x14687E4
	|-TMP_TextProcessingStack<HighlightState>.PreviousItem
	|
	|-RVA: 0x1468DB0 Offset: 0x1464DB0 VA: 0x1468DB0
	|-TMP_TextProcessingStack<int>.PreviousItem
	|
	|-RVA: 0x146936C Offset: 0x146536C VA: 0x146936C
	|-TMP_TextProcessingStack<Int32Enum>.PreviousItem
	|
	|-RVA: 0x1469B7C Offset: 0x1465B7C VA: 0x1469B7C
	|-TMP_TextProcessingStack<MaterialReference>.PreviousItem
	|
	|-RVA: 0x146A184 Offset: 0x1466184 VA: 0x146A184
	|-TMP_TextProcessingStack<object>.PreviousItem
	|
	|-RVA: 0x146A74C Offset: 0x146674C VA: 0x146A74C
	|-TMP_TextProcessingStack<float>.PreviousItem
	|
	|-RVA: 0x146AF14 Offset: 0x1466F14 VA: 0x146AF14
	|-TMP_TextProcessingStack<WordWrapState>.PreviousItem
	|
	|-RVA: 0x146D170 Offset: 0x1469170 VA: 0x146D170
	|-TMP_TextProcessingStack<__Il2CppFullySharedGenericType>.PreviousItem
	*/
}

// Namespace: TMPro
public enum CaretPosition // TypeDefIndex: 5293
{
	// Fields
	public int value__; // 0x0
	public const CaretPosition None = 0;
	public const CaretPosition Left = 1;
	public const CaretPosition Right = 2;
}

// Namespace: TMPro
public struct CaretInfo // TypeDefIndex: 5294
{
	// Fields
	public int index; // 0x0
	public CaretPosition position; // 0x4

	// Methods

	// RVA: 0x1E18DEC Offset: 0x1E14DEC VA: 0x1E18DEC
	public void .ctor(int index, CaretPosition position) { }
}

// Namespace: 
private struct TMP_TextUtilities.LineSegment // TypeDefIndex: 5295
{
	// Fields
	public Vector3 Point1; // 0x0
	public Vector3 Point2; // 0xC

	// Methods

	// RVA: 0x1E1C2F0 Offset: 0x1E182F0 VA: 0x1E1C2F0
	public void .ctor(Vector3 p1, Vector3 p2) { }
}

// Namespace: TMPro
public static class TMP_TextUtilities // TypeDefIndex: 5296
{
	// Fields
	private static Vector3[] m_rectWorldCorners; // 0x0
	private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Methods

	// RVA: 0x1E18DF4 Offset: 0x1E14DF4 VA: 0x1E18DF4
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera) { }

	// RVA: 0x1E195D0 Offset: 0x1E155D0 VA: 0x1E195D0
	public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor) { }

	// RVA: 0x1E197E0 Offset: 0x1E157E0 VA: 0x1E197E0
	public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1E19980 Offset: 0x1E15980 VA: 0x1E19980
	public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly) { }

	// RVA: 0x1E1A03C Offset: 0x1E1603C VA: 0x1E1A03C
	public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera) { }

	// RVA: 0x1E1A168 Offset: 0x1E16168 VA: 0x1E1A168
	public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x1E18F58 Offset: 0x1E14F58 VA: 0x1E18F58
	public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly) { }

	// RVA: 0x1E1A3A0 Offset: 0x1E163A0 VA: 0x1E1A3A0
	public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1E1A84C Offset: 0x1E1684C VA: 0x1E1A84C
	public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1E1AF6C Offset: 0x1E16F6C VA: 0x1E1AF6C
	public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1E1B0E4 Offset: 0x1E170E4 VA: 0x1E1B0E4
	public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1E1B46C Offset: 0x1E1746C VA: 0x1E1B46C
	public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera) { }

	// RVA: 0x1E19D5C Offset: 0x1E15D5C VA: 0x1E19D5C
	private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d) { }

	// RVA: 0x1E192B4 Offset: 0x1E152B4 VA: 0x1E192B4
	public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x1E1BBD4 Offset: 0x1E17BD4 VA: 0x1E1BBD4
	private static bool IntersectLinePlane(TMP_TextUtilities.LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint) { }

	// RVA: 0x1E19F20 Offset: 0x1E15F20 VA: 0x1E19F20
	public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point) { }

	// RVA: 0x1E1BD40 Offset: 0x1E17D40 VA: 0x1E1BD40
	public static char ToLowerFast(char c) { }

	// RVA: 0x1E1BDB4 Offset: 0x1E17DB4 VA: 0x1E1BDB4
	public static char ToUpperFast(char c) { }

	// RVA: 0x1E1BE28 Offset: 0x1E17E28 VA: 0x1E1BE28
	internal static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x1E1BE9C Offset: 0x1E17E9C VA: 0x1E1BE9C
	public static int GetHashCode(string s) { }

	// RVA: 0x1E1BF68 Offset: 0x1E17F68 VA: 0x1E1BF68
	public static int GetSimpleHashCode(string s) { }

	// RVA: 0x1E1BFD4 Offset: 0x1E17FD4 VA: 0x1E1BFD4
	public static uint GetSimpleHashCodeLowercase(string s) { }

	// RVA: 0x1E1C090 Offset: 0x1E18090 VA: 0x1E1C090
	public static uint GetHashCodeCaseInSensitive(string s) { }

	// RVA: 0x1E1C14C Offset: 0x1E1814C VA: 0x1E1C14C
	public static int HexToInt(char hex) { }

	// RVA: 0x1E1C178 Offset: 0x1E18178 VA: 0x1E1C178
	public static int StringHexToInt(string s) { }

	// RVA: 0x1E1C27C Offset: 0x1E1827C VA: 0x1E1C27C
	private static void .cctor() { }
}

// Namespace: TMPro
public class TMP_UpdateManager // TypeDefIndex: 5297
{
	// Fields
	private static TMP_UpdateManager s_Instance; // 0x0
	private readonly HashSet<int> m_LayoutQueueLookup; // 0x10
	private readonly List<TMP_Text> m_LayoutRebuildQueue; // 0x18
	private readonly HashSet<int> m_GraphicQueueLookup; // 0x20
	private readonly List<TMP_Text> m_GraphicRebuildQueue; // 0x28
	private readonly HashSet<int> m_InternalUpdateLookup; // 0x30
	private readonly List<TMP_Text> m_InternalUpdateQueue; // 0x38
	private readonly HashSet<int> m_CullingUpdateLookup; // 0x40
	private readonly List<TMP_Text> m_CullingUpdateQueue; // 0x48
	private static ProfilerMarker k_RegisterTextObjectForUpdateMarker; // 0x8
	private static ProfilerMarker k_RegisterTextElementForGraphicRebuildMarker; // 0x10
	private static ProfilerMarker k_RegisterTextElementForCullingUpdateMarker; // 0x18
	private static ProfilerMarker k_UnregisterTextObjectForUpdateMarker; // 0x20
	private static ProfilerMarker k_UnregisterTextElementForGraphicRebuildMarker; // 0x28

	// Properties
	private static TMP_UpdateManager instance { get; }

	// Methods

	// RVA: 0x1E1C300 Offset: 0x1E18300 VA: 0x1E1C300
	private static TMP_UpdateManager get_instance() { }

	// RVA: 0x1E1C3B0 Offset: 0x1E183B0 VA: 0x1E1C3B0
	private void .ctor() { }

	// RVA: 0x1E1C5BC Offset: 0x1E185BC VA: 0x1E1C5BC
	internal static void RegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x1E1C61C Offset: 0x1E1861C VA: 0x1E1C61C
	private void InternalRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x1E1C740 Offset: 0x1E18740 VA: 0x1E1C740
	public static void RegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x1E1C7A0 Offset: 0x1E187A0 VA: 0x1E1C7A0
	private void InternalRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x1E1C8C4 Offset: 0x1E188C4 VA: 0x1E1C8C4
	public static void RegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x1E1C924 Offset: 0x1E18924 VA: 0x1E1C924
	private void InternalRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x1E1CA48 Offset: 0x1E18A48 VA: 0x1E1CA48
	public static void RegisterTextElementForCullingUpdate(TMP_Text element) { }

	// RVA: 0x1E1CAA8 Offset: 0x1E18AA8 VA: 0x1E1CAA8
	private void InternalRegisterTextElementForCullingUpdate(TMP_Text element) { }

	// RVA: 0x1E1CBCC Offset: 0x1E18BCC VA: 0x1E1CBCC
	private void OnCameraPreCull() { }

	// RVA: 0x1E1CBD0 Offset: 0x1E18BD0 VA: 0x1E1CBD0
	private void DoRebuilds() { }

	// RVA: 0x1E1CE20 Offset: 0x1E18E20 VA: 0x1E1CE20
	internal static void UnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x1E1CF18 Offset: 0x1E18F18 VA: 0x1E1CF18
	public static void UnRegisterTextElementForRebuild(TMP_Text element) { }

	// RVA: 0x1E1CF98 Offset: 0x1E18F98 VA: 0x1E1CF98
	private void InternalUnRegisterTextElementForGraphicRebuild(TMP_Text element) { }

	// RVA: 0x1E1D030 Offset: 0x1E19030 VA: 0x1E1D030
	private void InternalUnRegisterTextElementForLayoutRebuild(TMP_Text element) { }

	// RVA: 0x1E1CE80 Offset: 0x1E18E80 VA: 0x1E1CE80
	private void InternalUnRegisterTextObjectForUpdate(TMP_Text textObject) { }

	// RVA: 0x1E1D0C8 Offset: 0x1E190C8 VA: 0x1E1D0C8
	private static void .cctor() { }
}

// Namespace: TMPro
public class TMP_UpdateRegistry // TypeDefIndex: 5298
{
	// Fields
	private static TMP_UpdateRegistry s_Instance; // 0x0
	private readonly List<ICanvasElement> m_LayoutRebuildQueue; // 0x10
	private HashSet<int> m_LayoutQueueLookup; // 0x18
	private readonly List<ICanvasElement> m_GraphicRebuildQueue; // 0x20
	private HashSet<int> m_GraphicQueueLookup; // 0x28

	// Properties
	public static TMP_UpdateRegistry instance { get; }

	// Methods

	// RVA: 0x1E1D23C Offset: 0x1E1923C VA: 0x1E1D23C
	public static TMP_UpdateRegistry get_instance() { }

	// RVA: 0x1E1D2C0 Offset: 0x1E192C0 VA: 0x1E1D2C0
	protected void .ctor() { }

	// RVA: 0x1E1D43C Offset: 0x1E1943C VA: 0x1E1D43C
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1E1D45C Offset: 0x1E1945C VA: 0x1E1D45C
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1E1D5C8 Offset: 0x1E195C8 VA: 0x1E1D5C8
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1E1D5E8 Offset: 0x1E195E8 VA: 0x1E1D5E8
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1E1D754 Offset: 0x1E19754 VA: 0x1E1D754
	private void PerformUpdateForCanvasRendererObjects() { }

	// RVA: 0x1E1D9AC Offset: 0x1E199AC VA: 0x1E1D9AC
	private void PerformUpdateForMeshRendererObjects() { }

	// RVA: 0x1E1DA14 Offset: 0x1E19A14 VA: 0x1E1DA14
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x1E1DA44 Offset: 0x1E19A44 VA: 0x1E1DA44
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1E1DB20 Offset: 0x1E19B20 VA: 0x1E1DB20
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }
}

// Namespace: TMPro
public enum Compute_DistanceTransform_EventTypes // TypeDefIndex: 5299
{
	// Fields
	public int value__; // 0x0
	public const Compute_DistanceTransform_EventTypes Processing = 0;
	public const Compute_DistanceTransform_EventTypes Completed = 1;
}

// Namespace: TMPro
public static class TMPro_EventManager // TypeDefIndex: 5300
{
	// Fields
	public static readonly FastAction<object, Compute_DT_EventArgs> COMPUTE_DT_EVENT; // 0x0
	public static readonly FastAction<bool, Material> MATERIAL_PROPERTY_EVENT; // 0x8
	public static readonly FastAction<bool, Object> FONT_PROPERTY_EVENT; // 0x10
	public static readonly FastAction<bool, Object> SPRITE_ASSET_PROPERTY_EVENT; // 0x18
	public static readonly FastAction<bool, Object> TEXTMESHPRO_PROPERTY_EVENT; // 0x20
	public static readonly FastAction<GameObject, Material, Material> DRAG_AND_DROP_MATERIAL_EVENT; // 0x28
	public static readonly FastAction<bool> TEXT_STYLE_PROPERTY_EVENT; // 0x30
	public static readonly FastAction<Object> COLOR_GRADIENT_PROPERTY_EVENT; // 0x38
	public static readonly FastAction TMP_SETTINGS_PROPERTY_EVENT; // 0x40
	public static readonly FastAction RESOURCE_LOAD_EVENT; // 0x48
	public static readonly FastAction<bool, Object> TEXTMESHPRO_UGUI_PROPERTY_EVENT; // 0x50
	public static readonly FastAction<Object> TEXT_CHANGED_EVENT; // 0x58

	// Methods

	// RVA: 0x1E1DBFC Offset: 0x1E19BFC VA: 0x1E1DBFC
	public static void ON_MATERIAL_PROPERTY_CHANGED(bool isChanged, Material mat) { }

	// RVA: 0x1E1DC8C Offset: 0x1E19C8C VA: 0x1E1DC8C
	public static void ON_FONT_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x1E1DD1C Offset: 0x1E19D1C VA: 0x1E1DD1C
	public static void ON_SPRITE_ASSET_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x1E1DDAC Offset: 0x1E19DAC VA: 0x1E1DDAC
	public static void ON_TEXTMESHPRO_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x1E1DE3C Offset: 0x1E19E3C VA: 0x1E1DE3C
	public static void ON_DRAG_AND_DROP_MATERIAL_CHANGED(GameObject sender, Material currentMaterial, Material newMaterial) { }

	// RVA: 0x1E1DED4 Offset: 0x1E19ED4 VA: 0x1E1DED4
	public static void ON_TEXT_STYLE_PROPERTY_CHANGED(bool isChanged) { }

	// RVA: 0x1E1DF54 Offset: 0x1E19F54 VA: 0x1E1DF54
	public static void ON_COLOR_GRADIENT_PROPERTY_CHANGED(Object obj) { }

	// RVA: 0x1E1DFD4 Offset: 0x1E19FD4 VA: 0x1E1DFD4
	public static void ON_TEXT_CHANGED(Object obj) { }

	// RVA: 0x1E1E054 Offset: 0x1E1A054 VA: 0x1E1E054
	public static void ON_TMP_SETTINGS_CHANGED() { }

	// RVA: 0x1E1E0B8 Offset: 0x1E1A0B8 VA: 0x1E1E0B8
	public static void ON_RESOURCES_LOADED() { }

	// RVA: 0x1E1E11C Offset: 0x1E1A11C VA: 0x1E1E11C
	public static void ON_TEXTMESHPRO_UGUI_PROPERTY_CHANGED(bool isChanged, Object obj) { }

	// RVA: 0x1E1E1AC Offset: 0x1E1A1AC VA: 0x1E1E1AC
	public static void ON_COMPUTE_DT_EVENT(object Sender, Compute_DT_EventArgs e) { }

	// RVA: 0x1E1E23C Offset: 0x1E1A23C VA: 0x1E1E23C
	private static void .cctor() { }
}

// Namespace: TMPro
public class Compute_DT_EventArgs // TypeDefIndex: 5301
{
	// Fields
	public Compute_DistanceTransform_EventTypes EventType; // 0x10
	public float ProgressPercentage; // 0x14
	public Color[] Colors; // 0x18

	// Methods

	// RVA: 0x1E1E580 Offset: 0x1E1A580 VA: 0x1E1E580
	public void .ctor(Compute_DistanceTransform_EventTypes type, float progress) { }

	// RVA: 0x1E1E5B8 Offset: 0x1E1A5B8 VA: 0x1E1E5B8
	public void .ctor(Compute_DistanceTransform_EventTypes type, Color[] colors) { }
}

// Namespace: TMPro
[Extension]
public static class TMPro_ExtensionMethods // TypeDefIndex: 5302
{
	// Methods

	[Extension]
	// RVA: 0x1E1E5F0 Offset: 0x1E1A5F0 VA: 0x1E1E5F0
	internal static int TagToInt(string s) { }

	[Extension]
	// RVA: 0x1E1E690 Offset: 0x1E1A690 VA: 0x1E1E690
	public static int[] ToIntArray(string text) { }

	[Extension]
	// RVA: 0x1E1E744 Offset: 0x1E1A744 VA: 0x1E1E744
	public static string ArrayToString(char[] chars) { }

	[Extension]
	// RVA: 0x1E1E800 Offset: 0x1E1A800 VA: 0x1E1E800
	public static string IntToString(int[] unicodes) { }

	[Extension]
	// RVA: 0x1E1E8A4 Offset: 0x1E1A8A4 VA: 0x1E1E8A4
	internal static string UintToString(List<uint> unicodes) { }

	[Extension]
	// RVA: 0x1E1E97C Offset: 0x1E1A97C VA: 0x1E1E97C
	public static string IntToString(int[] unicodes, int start, int length) { }

	[Extension]
	// RVA: -1 Offset: -1
	public static int FindInstanceID<T>(List<T> list, T target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114E6FC Offset: 0x114A6FC VA: 0x114E6FC
	|-TMPro_ExtensionMethods.FindInstanceID<object>
	*/

	[Extension]
	// RVA: 0x1E1EA7C Offset: 0x1E1AA7C VA: 0x1E1EA7C
	public static bool Compare(Color32 a, Color32 b) { }

	[Extension]
	// RVA: 0x1E1EA8C Offset: 0x1E1AA8C VA: 0x1E1EA8C
	public static bool CompareRGB(Color32 a, Color32 b) { }

	[Extension]
	// RVA: 0x1E1EA9C Offset: 0x1E1AA9C VA: 0x1E1EA9C
	public static bool Compare(Color a, Color b) { }

	[Extension]
	// RVA: 0x1E1EAC4 Offset: 0x1E1AAC4 VA: 0x1E1EAC4
	public static bool CompareRGB(Color a, Color b) { }

	[Extension]
	// RVA: 0x1E1EAE8 Offset: 0x1E1AAE8 VA: 0x1E1EAE8
	public static Color32 Multiply(Color32 c1, Color32 c2) { }

	[Extension]
	// RVA: 0x1E1EBCC Offset: 0x1E1ABCC VA: 0x1E1EBCC
	public static Color32 Tint(Color32 c1, Color32 c2) { }

	[Extension]
	// RVA: 0x1E1ECB0 Offset: 0x1E1ACB0 VA: 0x1E1ECB0
	public static Color32 Tint(Color32 c1, float tint) { }

	[Extension]
	// RVA: 0x1E1ED98 Offset: 0x1E1AD98 VA: 0x1E1ED98
	internal static Color32 GammaToLinear(Color32 c) { }

	// RVA: 0x1E1EDEC Offset: 0x1E1ADEC VA: 0x1E1EDEC
	private static byte GammaToLinear(byte value) { }

	[Extension]
	// RVA: 0x1E1EE8C Offset: 0x1E1AE8C VA: 0x1E1EE8C
	public static Color MinAlpha(Color c1, Color c2) { }

	[Extension]
	// RVA: 0x1E1EE98 Offset: 0x1E1AE98 VA: 0x1E1EE98
	public static bool Compare(Vector3 v1, Vector3 v2, int accuracy) { }

	[Extension]
	// RVA: 0x1E1EF18 Offset: 0x1E1AF18 VA: 0x1E1EF18
	public static bool Compare(Quaternion q1, Quaternion q2, int accuracy) { }
}

// Namespace: TMPro
public static class TMP_Math // TypeDefIndex: 5303
{
	// Fields
	public const float FLOAT_MAX = 32767;
	public const float FLOAT_MIN = -32767;
	public const int INT_MAX = 2147483647;
	public const int INT_MIN = -2147483647;
	public const float FLOAT_UNSET = -32767;
	public const int INT_UNSET = -32767;
	public static Vector2 MAX_16BIT; // 0x0
	public static Vector2 MIN_16BIT; // 0x8

	// Methods

	// RVA: 0x1E1EF80 Offset: 0x1E1AF80 VA: 0x1E1EF80
	public static bool Approximately(float a, float b) { }

	// RVA: 0x1E1EFA8 Offset: 0x1E1AFA8 VA: 0x1E1EFA8
	public static int Mod(int a, int b) { }

	// RVA: 0x1E1EFBC Offset: 0x1E1AFBC VA: 0x1E1EFBC
	private static void .cctor() { }
}

// Namespace: TMPro
public enum TMP_VertexDataUpdateFlags // TypeDefIndex: 5304
{
	// Fields
	public int value__; // 0x0
	public const TMP_VertexDataUpdateFlags None = 0;
	public const TMP_VertexDataUpdateFlags Vertices = 1;
	public const TMP_VertexDataUpdateFlags Uv0 = 2;
	public const TMP_VertexDataUpdateFlags Uv2 = 4;
	public const TMP_VertexDataUpdateFlags Uv4 = 8;
	public const TMP_VertexDataUpdateFlags Colors32 = 16;
	public const TMP_VertexDataUpdateFlags All = 255;
}

// Namespace: TMPro
[Serializable]
public struct VertexGradient // TypeDefIndex: 5305
{
	// Fields
	public Color topLeft; // 0x0
	public Color topRight; // 0x10
	public Color bottomLeft; // 0x20
	public Color bottomRight; // 0x30

	// Methods

	// RVA: 0x1E1F028 Offset: 0x1E1B028 VA: 0x1E1F028
	public void .ctor(Color color) { }

	// RVA: 0x1E1F04C Offset: 0x1E1B04C VA: 0x1E1F04C
	public void .ctor(Color color0, Color color1, Color color2, Color color3) { }
}

// Namespace: TMPro
public struct TMP_PageInfo // TypeDefIndex: 5306
{
	// Fields
	public int firstCharacterIndex; // 0x0
	public int lastCharacterIndex; // 0x4
	public float ascender; // 0x8
	public float baseLine; // 0xC
	public float descender; // 0x10
}

// Namespace: TMPro
public struct TMP_LinkInfo // TypeDefIndex: 5307
{
	// Fields
	public TMP_Text textComponent; // 0x0
	public int hashCode; // 0x8
	public int linkIdFirstCharacterIndex; // 0xC
	public int linkIdLength; // 0x10
	public int linkTextfirstCharacterIndex; // 0x14
	public int linkTextLength; // 0x18
	internal char[] linkID; // 0x20

	// Methods

	// RVA: 0x1E1F070 Offset: 0x1E1B070 VA: 0x1E1F070
	internal void SetLinkID(char[] text, int startIndex, int length) { }

	// RVA: 0x1E1F164 Offset: 0x1E1B164 VA: 0x1E1F164
	public string GetLinkText() { }

	// RVA: 0x1E1F240 Offset: 0x1E1B240 VA: 0x1E1F240
	public string GetLink() { }

	// RVA: 0x1E1F244 Offset: 0x1E1B244 VA: 0x1E1F244
	public string GetLinkID() { }
}

// Namespace: TMPro
public struct TMP_WordInfo // TypeDefIndex: 5308
{
	// Fields
	public TMP_Text textComponent; // 0x0
	public int firstCharacterIndex; // 0x8
	public int lastCharacterIndex; // 0xC
	public int characterCount; // 0x10

	// Methods

	// RVA: 0x1E1F2E0 Offset: 0x1E1B2E0 VA: 0x1E1F2E0
	public string GetWord() { }
}

// Namespace: TMPro
public struct TMP_SpriteInfo // TypeDefIndex: 5309
{
	// Fields
	public int spriteIndex; // 0x0
	public int characterIndex; // 0x4
	public int vertexIndex; // 0x8
}

// Namespace: TMPro
public struct Extents // TypeDefIndex: 5310
{
	// Fields
	internal static Extents zero; // 0x0
	internal static Extents uninitialized; // 0x10
	public Vector2 min; // 0x0
	public Vector2 max; // 0x8

	// Methods

	// RVA: 0x1E1F3B8 Offset: 0x1E1B3B8 VA: 0x1E1F3B8
	public void .ctor(Vector2 min, Vector2 max) { }

	// RVA: 0x1E1F3C4 Offset: 0x1E1B3C4 VA: 0x1E1F3C4 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E1F5EC Offset: 0x1E1B5EC VA: 0x1E1F5EC
	private static void .cctor() { }
}

// Namespace: TMPro
[Serializable]
public struct Mesh_Extents // TypeDefIndex: 5311
{
	// Fields
	public Vector2 min; // 0x0
	public Vector2 max; // 0x8

	// Methods

	// RVA: 0x1E1F680 Offset: 0x1E1B680 VA: 0x1E1F680
	public void .ctor(Vector2 min, Vector2 max) { }

	// RVA: 0x1E1F68C Offset: 0x1E1B68C VA: 0x1E1F68C Slot: 3
	public override string ToString() { }
}

// Namespace: TMPro
internal struct WordWrapState // TypeDefIndex: 5312
{
	// Fields
	public int previous_WordBreak; // 0x0
	public int total_CharacterCount; // 0x4
	public int visible_CharacterCount; // 0x8
	public int visibleSpaceCount; // 0xC
	public int visible_SpriteCount; // 0x10
	public int visible_LinkCount; // 0x14
	public int firstCharacterIndex; // 0x18
	public int firstVisibleCharacterIndex; // 0x1C
	public int lastCharacterIndex; // 0x20
	public int lastVisibleCharIndex; // 0x24
	public int lineNumber; // 0x28
	public float maxCapHeight; // 0x2C
	public float maxAscender; // 0x30
	public float maxDescender; // 0x34
	public float startOfLineAscender; // 0x38
	public float maxLineAscender; // 0x3C
	public float maxLineDescender; // 0x40
	public float pageAscender; // 0x44
	public HorizontalAlignmentOptions horizontalAlignment; // 0x48
	public float marginLeft; // 0x4C
	public float marginRight; // 0x50
	public float xAdvance; // 0x54
	public float preferredWidth; // 0x58
	public float preferredHeight; // 0x5C
	public float renderedWidth; // 0x60
	public float renderedHeight; // 0x64
	public float previousLineScale; // 0x68
	public int wordCount; // 0x6C
	public FontStyles fontStyle; // 0x70
	public int italicAngle; // 0x74
	public float fontScaleMultiplier; // 0x78
	public float currentFontSize; // 0x7C
	public float baselineOffset; // 0x80
	public float lineOffset; // 0x84
	public bool isDrivenLineSpacing; // 0x88
	public int lastBaseGlyphIndex; // 0x8C
	public float cSpace; // 0x90
	public float mSpace; // 0x94
	public TMP_TextInfo textInfo; // 0x98
	public TMP_LineInfo lineInfo; // 0xA0
	public Color32 vertexColor; // 0x100
	public Color32 underlineColor; // 0x104
	public Color32 strikethroughColor; // 0x108
	public HighlightState highlightState; // 0x10C
	public TMP_FontStyleStack basicStyleStack; // 0x120
	public TMP_TextProcessingStack<int> italicAngleStack; // 0x130
	public TMP_TextProcessingStack<Color32> colorStack; // 0x150
	public TMP_TextProcessingStack<Color32> underlineColorStack; // 0x170
	public TMP_TextProcessingStack<Color32> strikethroughColorStack; // 0x190
	public TMP_TextProcessingStack<Color32> highlightColorStack; // 0x1B0
	public TMP_TextProcessingStack<HighlightState> highlightStateStack; // 0x1D0
	public TMP_TextProcessingStack<TMP_ColorGradient> colorGradientStack; // 0x200
	public TMP_TextProcessingStack<float> sizeStack; // 0x228
	public TMP_TextProcessingStack<float> indentStack; // 0x248
	public TMP_TextProcessingStack<FontWeight> fontWeightStack; // 0x268
	public TMP_TextProcessingStack<int> styleStack; // 0x288
	public TMP_TextProcessingStack<float> baselineStack; // 0x2A8
	public TMP_TextProcessingStack<int> actionStack; // 0x2C8
	public TMP_TextProcessingStack<MaterialReference> materialReferenceStack; // 0x2E8
	public TMP_TextProcessingStack<HorizontalAlignmentOptions> lineJustificationStack; // 0x340
	public int spriteAnimationID; // 0x360
	public TMP_FontAsset currentFontAsset; // 0x368
	public TMP_SpriteAsset currentSpriteAsset; // 0x370
	public Material currentMaterial; // 0x378
	public int currentMaterialIndex; // 0x380
	public Extents meshExtents; // 0x384
	public bool tagNoParsing; // 0x394
	public bool isNonBreakingSpace; // 0x395
	public Quaternion fxRotation; // 0x398
	public Vector3 fxScale; // 0x3A8
}

// Namespace: TMPro
internal struct TagAttribute // TypeDefIndex: 5313
{
	// Fields
	public int startIndex; // 0x0
	public int length; // 0x4
	public int hashCode; // 0x8
}

// Namespace: TMPro
internal struct RichTextTagAttribute // TypeDefIndex: 5314
{
	// Fields
	public int nameHashCode; // 0x0
	public int valueHashCode; // 0x4
	public TagValueType valueType; // 0x8
	public int valueStartIndex; // 0xC
	public int valueLength; // 0x10
	public TagUnitType unitType; // 0x14
	private static readonly RichTextTagAttribute k_Default; // 0x0

	// Properties
	public static RichTextTagAttribute Default { get; }

	// Methods

	// RVA: 0x1E1F8B4 Offset: 0x1E1B8B4 VA: 0x1E1F8B4
	public static RichTextTagAttribute get_Default() { }

	// RVA: 0x1E1F91C Offset: 0x1E1B91C VA: 0x1E1F91C
	private static void .cctor() { }
}

// Namespace: TMPro
public enum TextContainerAnchors // TypeDefIndex: 5315
{
	// Fields
	public int value__; // 0x0
	public const TextContainerAnchors TopLeft = 0;
	public const TextContainerAnchors Top = 1;
	public const TextContainerAnchors TopRight = 2;
	public const TextContainerAnchors Left = 3;
	public const TextContainerAnchors Middle = 4;
	public const TextContainerAnchors Right = 5;
	public const TextContainerAnchors BottomLeft = 6;
	public const TextContainerAnchors Bottom = 7;
	public const TextContainerAnchors BottomRight = 8;
	public const TextContainerAnchors Custom = 9;
}

// Namespace: TMPro
[RequireComponent(typeof(RectTransform))]
public class TextContainer : UIBehaviour // TypeDefIndex: 5316
{
	// Fields
	private bool m_hasChanged; // 0x20
	[SerializeField]
	private Vector2 m_pivot; // 0x24
	[SerializeField]
	private TextContainerAnchors m_anchorPosition; // 0x2C
	[SerializeField]
	private Rect m_rect; // 0x30
	private bool m_isDefaultWidth; // 0x40
	private bool m_isDefaultHeight; // 0x41
	private bool m_isAutoFitting; // 0x42
	private Vector3[] m_corners; // 0x48
	private Vector3[] m_worldCorners; // 0x50
	[SerializeField]
	private Vector4 m_margins; // 0x58
	private RectTransform m_rectTransform; // 0x68
	private static Vector2 k_defaultSize; // 0x0
	private TextMeshPro m_textMeshPro; // 0x70

	// Properties
	public bool hasChanged { get; set; }
	public Vector2 pivot { get; set; }
	public TextContainerAnchors anchorPosition { get; set; }
	public Rect rect { get; set; }
	public Vector2 size { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public bool isDefaultWidth { get; }
	public bool isDefaultHeight { get; }
	public bool isAutoFitting { get; set; }
	public Vector3[] corners { get; }
	public Vector3[] worldCorners { get; }
	public Vector4 margins { get; set; }
	public RectTransform rectTransform { get; }
	public TextMeshPro textMeshPro { get; }

	// Methods

	// RVA: 0x1E1F968 Offset: 0x1E1B968 VA: 0x1E1F968
	public bool get_hasChanged() { }

	// RVA: 0x1E1F970 Offset: 0x1E1B970 VA: 0x1E1F970
	public void set_hasChanged(bool value) { }

	// RVA: 0x1E1F978 Offset: 0x1E1B978 VA: 0x1E1F978
	public Vector2 get_pivot() { }

	// RVA: 0x1E1F980 Offset: 0x1E1B980 VA: 0x1E1F980
	public void set_pivot(Vector2 value) { }

	// RVA: 0x1E1FBDC Offset: 0x1E1BBDC VA: 0x1E1FBDC
	public TextContainerAnchors get_anchorPosition() { }

	// RVA: 0x1E1FBE4 Offset: 0x1E1BBE4 VA: 0x1E1FBE4
	public void set_anchorPosition(TextContainerAnchors value) { }

	// RVA: 0x1E1FC94 Offset: 0x1E1BC94 VA: 0x1E1FC94
	public Rect get_rect() { }

	// RVA: 0x1E1FCA0 Offset: 0x1E1BCA0 VA: 0x1E1FCA0
	public void set_rect(Rect value) { }

	// RVA: 0x1E1FCEC Offset: 0x1E1BCEC VA: 0x1E1FCEC
	public Vector2 get_size() { }

	// RVA: 0x1E1FCF4 Offset: 0x1E1BCF4 VA: 0x1E1FCF4
	public void set_size(Vector2 value) { }

	// RVA: 0x1E1FD3C Offset: 0x1E1BD3C VA: 0x1E1FD3C
	public float get_width() { }

	// RVA: 0x1E1FD44 Offset: 0x1E1BD44 VA: 0x1E1FD44
	public void set_width(float value) { }

	// RVA: 0x1E1FD58 Offset: 0x1E1BD58 VA: 0x1E1FD58
	public float get_height() { }

	// RVA: 0x1E1FD60 Offset: 0x1E1BD60 VA: 0x1E1FD60
	public void set_height(float value) { }

	// RVA: 0x1E1FD74 Offset: 0x1E1BD74 VA: 0x1E1FD74
	public bool get_isDefaultWidth() { }

	// RVA: 0x1E1FD7C Offset: 0x1E1BD7C VA: 0x1E1FD7C
	public bool get_isDefaultHeight() { }

	// RVA: 0x1E1FD84 Offset: 0x1E1BD84 VA: 0x1E1FD84
	public bool get_isAutoFitting() { }

	// RVA: 0x1E1FD8C Offset: 0x1E1BD8C VA: 0x1E1FD8C
	public void set_isAutoFitting(bool value) { }

	// RVA: 0x1E1FD94 Offset: 0x1E1BD94 VA: 0x1E1FD94
	public Vector3[] get_corners() { }

	// RVA: 0x1E1FD9C Offset: 0x1E1BD9C VA: 0x1E1FD9C
	public Vector3[] get_worldCorners() { }

	// RVA: 0x1E1FDA4 Offset: 0x1E1BDA4 VA: 0x1E1FDA4
	public Vector4 get_margins() { }

	// RVA: 0x1E1FDB0 Offset: 0x1E1BDB0 VA: 0x1E1FDB0
	public void set_margins(Vector4 value) { }

	// RVA: 0x1E1FE0C Offset: 0x1E1BE0C VA: 0x1E1FE0C
	public RectTransform get_rectTransform() { }

	// RVA: 0x1E1FEAC Offset: 0x1E1BEAC VA: 0x1E1FEAC
	public TextMeshPro get_textMeshPro() { }

	// RVA: 0x1E1FF4C Offset: 0x1E1BF4C VA: 0x1E1FF4C Slot: 4
	protected override void Awake() { }

	// RVA: 0x1E20014 Offset: 0x1E1C014 VA: 0x1E20014 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1E20018 Offset: 0x1E1C018 VA: 0x1E20018 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1E1FACC Offset: 0x1E1BACC VA: 0x1E1FACC
	private void OnContainerChanged() { }

	// RVA: 0x1E20170 Offset: 0x1E1C170 VA: 0x1E20170 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1E1FD34 Offset: 0x1E1BD34 VA: 0x1E1FD34
	private void SetRect(Vector2 size) { }

	// RVA: 0x1E2001C Offset: 0x1E1C01C VA: 0x1E2001C
	private void UpdateCorners() { }

	// RVA: 0x1E1FC1C Offset: 0x1E1BC1C VA: 0x1E1FC1C
	private Vector2 GetPivot(TextContainerAnchors anchor) { }

	// RVA: 0x1E1F9D4 Offset: 0x1E1B9D4 VA: 0x1E1F9D4
	private TextContainerAnchors GetAnchorPosition(Vector2 pivot) { }

	// RVA: 0x1E202D4 Offset: 0x1E1C2D4 VA: 0x1E202D4
	public void .ctor() { }

	// RVA: 0x1E2035C Offset: 0x1E1C35C VA: 0x1E2035C
	private static void .cctor() { }
}

// Namespace: TMPro
[DisallowMultipleComponent]
[RequireComponent(typeof(MeshRenderer))]
[AddComponentMenu("Mesh/TextMeshPro - Text")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/index.html")]
public class TextMeshPro : TMP_Text, ILayoutElement // TypeDefIndex: 5317
{
	// Fields
	[SerializeField]
	internal int _SortingLayer; // 0x6E8
	[SerializeField]
	internal int _SortingLayerID; // 0x6EC
	[SerializeField]
	internal int _SortingOrder; // 0x6F0
	[CompilerGenerated]
	private Action<TMP_TextInfo> OnPreRenderText; // 0x6F8
	[SerializeField]
	private bool m_hasFontAssetChanged; // 0x700
	private float m_previousLossyScaleY; // 0x704
	[SerializeField]
	private Renderer m_renderer; // 0x708
	private MeshFilter m_meshFilter; // 0x710
	private bool m_isFirstAllocation; // 0x718
	private int m_max_characters; // 0x71C
	private int m_max_numberOfLines; // 0x720
	private TMP_SubMesh[] m_subTextObjects; // 0x728
	[SerializeField]
	private MaskingTypes m_maskType; // 0x730
	private Matrix4x4 m_EnvMapMatrix; // 0x734
	private Vector3[] m_RectTransformCorners; // 0x778
	private bool m_isRegisteredForEvents; // 0x780
	private static ProfilerMarker k_GenerateTextMarker; // 0x0
	private static ProfilerMarker k_SetArraySizesMarker; // 0x8
	private static ProfilerMarker k_GenerateTextPhaseIMarker; // 0x10
	private static ProfilerMarker k_ParseMarkupTextMarker; // 0x18
	private static ProfilerMarker k_CharacterLookupMarker; // 0x20
	private static ProfilerMarker k_HandleGPOSFeaturesMarker; // 0x28
	private static ProfilerMarker k_CalculateVerticesPositionMarker; // 0x30
	private static ProfilerMarker k_ComputeTextMetricsMarker; // 0x38
	private static ProfilerMarker k_HandleVisibleCharacterMarker; // 0x40
	private static ProfilerMarker k_HandleWhiteSpacesMarker; // 0x48
	private static ProfilerMarker k_HandleHorizontalLineBreakingMarker; // 0x50
	private static ProfilerMarker k_HandleVerticalLineBreakingMarker; // 0x58
	private static ProfilerMarker k_SaveGlyphVertexDataMarker; // 0x60
	private static ProfilerMarker k_ComputeCharacterAdvanceMarker; // 0x68
	private static ProfilerMarker k_HandleCarriageReturnMarker; // 0x70
	private static ProfilerMarker k_HandleLineTerminationMarker; // 0x78
	private static ProfilerMarker k_SavePageInfoMarker; // 0x80
	private static ProfilerMarker k_SaveTextExtentMarker; // 0x88
	private static ProfilerMarker k_SaveProcessingStatesMarker; // 0x90
	private static ProfilerMarker k_GenerateTextPhaseIIMarker; // 0x98
	private static ProfilerMarker k_GenerateTextPhaseIIIMarker; // 0xA0
	private Dictionary<int, int> materialIndexPairs; // 0x788

	// Properties
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	public override bool autoSizeTextContainer { get; set; }
	[Obsolete("The TextContainer is now obsolete. Use the RectTransform instead.")]
	public TextContainer textContainer { get; }
	public Transform transform { get; }
	public Renderer renderer { get; }
	public override Mesh mesh { get; }
	public MeshFilter meshFilter { get; }
	public MaskingTypes maskType { get; set; }

	// Methods

	// RVA: 0x1E203AC Offset: 0x1E1C3AC VA: 0x1E203AC
	public int get_sortingLayerID() { }

	// RVA: 0x1E204E0 Offset: 0x1E1C4E0 VA: 0x1E204E0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x1E206A0 Offset: 0x1E1C6A0 VA: 0x1E206A0
	public int get_sortingOrder() { }

	// RVA: 0x1E20734 Offset: 0x1E1C734 VA: 0x1E20734
	public void set_sortingOrder(int value) { }

	// RVA: 0x1E208F4 Offset: 0x1E1C8F4 VA: 0x1E208F4 Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x1E208FC Offset: 0x1E1C8FC VA: 0x1E208FC Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x1E20998 Offset: 0x1E1C998 VA: 0x1E20998
	public TextContainer get_textContainer() { }

	// RVA: 0x1E209A0 Offset: 0x1E1C9A0 VA: 0x1E209A0
	public Transform get_transform() { }

	// RVA: 0x1E20440 Offset: 0x1E1C440 VA: 0x1E20440
	public Renderer get_renderer() { }

	// RVA: 0x1E20A40 Offset: 0x1E1CA40 VA: 0x1E20A40 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x1E20B00 Offset: 0x1E1CB00 VA: 0x1E20B00
	public MeshFilter get_meshFilter() { }

	// RVA: 0x1E20C24 Offset: 0x1E1CC24 VA: 0x1E20C24
	public MaskingTypes get_maskType() { }

	// RVA: 0x1E20C2C Offset: 0x1E1CC2C VA: 0x1E20C2C
	public void set_maskType(MaskingTypes value) { }

	// RVA: 0x1E20D7C Offset: 0x1E1CD7C VA: 0x1E20D7C
	public void SetMask(MaskingTypes type, Vector4 maskCoords) { }

	// RVA: 0x1E20E64 Offset: 0x1E1CE64 VA: 0x1E20E64
	public void SetMask(MaskingTypes type, Vector4 maskCoords, float softnessX, float softnessY) { }

	// RVA: 0x1E20FB4 Offset: 0x1E1CFB4 VA: 0x1E20FB4 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x1E21060 Offset: 0x1E1D060 VA: 0x1E21060 Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x1E21130 Offset: 0x1E1D130 VA: 0x1E21130 Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x1E21140 Offset: 0x1E1D140 VA: 0x1E21140 Slot: 26
	public override void SetAllDirty() { }

	// RVA: 0x1E21184 Offset: 0x1E1D184 VA: 0x1E21184 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1E214B0 Offset: 0x1E1D4B0 VA: 0x1E214B0 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x1E215E4 Offset: 0x1E1D5E4 VA: 0x1E215E4 Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x1E216E4 Offset: 0x1E1D6E4 VA: 0x1E216E4 Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x1E216F4 Offset: 0x1E1D6F4 VA: 0x1E216F4 Slot: 118
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x1E21760 Offset: 0x1E1D760 VA: 0x1E21760 Slot: 130
	public override void ClearMesh(bool updateMesh) { }

	[CompilerGenerated]
	// RVA: 0x1E21820 Offset: 0x1E1D820 VA: 0x1E21820 Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x1E218D0 Offset: 0x1E1D8D0 VA: 0x1E218D0 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x1E21980 Offset: 0x1E1D980 VA: 0x1E21980 Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x1E21998 Offset: 0x1E1D998 VA: 0x1E21998 Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x1E21B3C Offset: 0x1E1DB3C VA: 0x1E21B3C Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x1E21D10 Offset: 0x1E1DD10 VA: 0x1E21D10
	public void UpdateFontAsset() { }

	// RVA: 0x1E21D20 Offset: 0x1E1DD20 VA: 0x1E21D20 Slot: 133
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1E21D24 Offset: 0x1E1DD24 VA: 0x1E21D24 Slot: 134
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x1E21D28 Offset: 0x1E1DD28 VA: 0x1E21D28 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1E22054 Offset: 0x1E1E054 VA: 0x1E22054 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1E2214C Offset: 0x1E1E14C VA: 0x1E2214C Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1E221F0 Offset: 0x1E1E1F0 VA: 0x1E221F0 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1E222B4 Offset: 0x1E1E2B4 VA: 0x1E222B4 Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x1E22888 Offset: 0x1E1E888 VA: 0x1E22888
	private void ValidateEnvMapProperty() { }

	// RVA: 0x1E229B4 Offset: 0x1E1E9B4 VA: 0x1E229B4
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x1E20C34 Offset: 0x1E1CC34 VA: 0x1E20C34
	private void SetMask(MaskingTypes maskType) { }

	// RVA: 0x1E20DC4 Offset: 0x1E1CDC4 VA: 0x1E20DC4
	private void SetMaskCoordinates(Vector4 coords) { }

	// RVA: 0x1E20EC4 Offset: 0x1E1CEC4 VA: 0x1E20EC4
	private void SetMaskCoordinates(Vector4 coords, float softX, float softY) { }

	// RVA: 0x1E22BD0 Offset: 0x1E1EBD0 VA: 0x1E22BD0
	private void EnableMasking() { }

	// RVA: 0x1E22D48 Offset: 0x1E1ED48 VA: 0x1E22D48
	private void DisableMasking() { }

	// RVA: 0x1E22CC8 Offset: 0x1E1ECC8 VA: 0x1E22CC8
	private void UpdateMask() { }

	// RVA: 0x1E22F08 Offset: 0x1E1EF08 VA: 0x1E22F08 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x1E23028 Offset: 0x1E1F028 VA: 0x1E23028 Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x1E23204 Offset: 0x1E1F204 VA: 0x1E23204 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x1E23248 Offset: 0x1E1F248 VA: 0x1E23248 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x1E23400 Offset: 0x1E1F400 VA: 0x1E23400 Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x1E237B0 Offset: 0x1E1F7B0 VA: 0x1E237B0 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x1E23904 Offset: 0x1E1F904 VA: 0x1E23904 Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x1E23A38 Offset: 0x1E1FA38 VA: 0x1E23A38 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x1E22E3C Offset: 0x1E1EE3C VA: 0x1E22E3C
	private void CreateMaterialInstance() { }

	// RVA: 0x1E23B6C Offset: 0x1E1FB6C VA: 0x1E23B6C Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x1E23BA0 Offset: 0x1E1FBA0 VA: 0x1E23BA0 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x1E23E60 Offset: 0x1E1FE60 VA: 0x1E23E60
	private void SetPerspectiveCorrection() { }

	// RVA: 0x1E23EEC Offset: 0x1E1FEEC VA: 0x1E23EEC Slot: 114
	internal override int SetArraySizes(TMP_Text.TextProcessingElement[] textProcessingArray) { }

	// RVA: 0x1E26420 Offset: 0x1E22420 VA: 0x1E26420 Slot: 119
	public override void ComputeMarginSize() { }

	// RVA: 0x1E26514 Offset: 0x1E22514 VA: 0x1E26514 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1E26530 Offset: 0x1E22530 VA: 0x1E26530 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1E26560 Offset: 0x1E22560 VA: 0x1E26560 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1E266B4 Offset: 0x1E226B4 VA: 0x1E266B4 Slot: 132
	internal override void InternalUpdate() { }

	// RVA: 0x1E2126C Offset: 0x1E1D26C VA: 0x1E2126C
	private void OnPreRenderObject() { }

	// RVA: 0x1E0895C Offset: 0x1E0495C VA: 0x1E0895C Slot: 142
	protected virtual void GenerateTextMesh() { }

	// RVA: 0x1E26A08 Offset: 0x1E22A08 VA: 0x1E26A08 Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x1E26AAC Offset: 0x1E22AAC VA: 0x1E26AAC
	private void SetMeshFilters(bool state) { }

	// RVA: 0x1E26CA0 Offset: 0x1E22CA0 VA: 0x1E26CA0 Slot: 127
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x1E268D0 Offset: 0x1E228D0 VA: 0x1E268D0
	protected void SetActiveSubTextObjectRenderers(bool state) { }

	// RVA: 0x1E26DBC Offset: 0x1E22DBC VA: 0x1E26DBC Slot: 128
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x1E20594 Offset: 0x1E1C594 VA: 0x1E20594
	internal void UpdateSubMeshSortingLayerID(int id) { }

	// RVA: 0x1E207E8 Offset: 0x1E1C7E8 VA: 0x1E207E8
	internal void UpdateSubMeshSortingOrder(int order) { }

	// RVA: 0x1E26E98 Offset: 0x1E22E98 VA: 0x1E26E98 Slot: 116
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x1E2675C Offset: 0x1E2275C VA: 0x1E2675C
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x1E27060 Offset: 0x1E23060 VA: 0x1E27060
	public void .ctor() { }

	// RVA: 0x1E2718C Offset: 0x1E2318C VA: 0x1E2718C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TextMeshProUGUI.<DelayedGraphicRebuild>d__18 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5318
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TextMeshProUGUI <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1E2F5D0 Offset: 0x1E2B5D0 VA: 0x1E2F5D0
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1E2F5F8 Offset: 0x1E2B5F8 VA: 0x1E2F5F8 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1E2F5FC Offset: 0x1E2B5FC VA: 0x1E2F5FC Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1E2F6D0 Offset: 0x1E2B6D0 VA: 0x1E2F6D0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1E2F6D8 Offset: 0x1E2B6D8 VA: 0x1E2F6D8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1E2F710 Offset: 0x1E2B710 VA: 0x1E2F710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TextMeshProUGUI.<DelayedMaterialRebuild>d__19 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 5319
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public TextMeshProUGUI <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1E2F718 Offset: 0x1E2B718 VA: 0x1E2F718
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1E2F740 Offset: 0x1E2B740 VA: 0x1E2F740 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1E2F744 Offset: 0x1E2B744 VA: 0x1E2F744 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1E2F820 Offset: 0x1E2B820 VA: 0x1E2F820 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1E2F828 Offset: 0x1E2B828 VA: 0x1E2F828 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1E2F860 Offset: 0x1E2B860 VA: 0x1E2F860 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: TMPro
[DisallowMultipleComponent]
[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(CanvasRenderer))]
[AddComponentMenu("UI/TextMeshPro - Text (UI)", 11)]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.ugui@2.0/manual/TextMeshPro/index.html")]
public class TextMeshProUGUI : TMP_Text, ILayoutElement // TypeDefIndex: 5320
{
	// Fields
	private bool m_isRebuildingLayout; // 0x6E8
	private Coroutine m_DelayedGraphicRebuild; // 0x6F0
	private Coroutine m_DelayedMaterialRebuild; // 0x6F8
	private bool m_ShouldUpdateCulling; // 0x700
	private Rect m_ClipRect; // 0x704
	private bool m_ValidRect; // 0x714
	[CompilerGenerated]
	private Action<TMP_TextInfo> OnPreRenderText; // 0x718
	[SerializeField]
	private bool m_hasFontAssetChanged; // 0x720
	protected TMP_SubMeshUI[] m_subTextObjects; // 0x728
	private float m_previousLossyScaleY; // 0x730
	private Vector3[] m_RectTransformCorners; // 0x738
	private CanvasRenderer m_canvasRenderer; // 0x740
	private Canvas m_canvas; // 0x748
	private float m_CanvasScaleFactor; // 0x750
	private bool m_isFirstAllocation; // 0x754
	private int m_max_characters; // 0x758
	[SerializeField]
	private Material m_baseMaterial; // 0x760
	private bool m_isScrollRegionSet; // 0x768
	[SerializeField]
	private Vector4 m_maskOffset; // 0x76C
	private Matrix4x4 m_EnvMapMatrix; // 0x77C
	private bool m_isRegisteredForEvents; // 0x7BC
	private static ProfilerMarker k_GenerateTextMarker; // 0x0
	private static ProfilerMarker k_SetArraySizesMarker; // 0x8
	private static ProfilerMarker k_GenerateTextPhaseIMarker; // 0x10
	private static ProfilerMarker k_ParseMarkupTextMarker; // 0x18
	private static ProfilerMarker k_CharacterLookupMarker; // 0x20
	private static ProfilerMarker k_HandleGPOSFeaturesMarker; // 0x28
	private static ProfilerMarker k_CalculateVerticesPositionMarker; // 0x30
	private static ProfilerMarker k_ComputeTextMetricsMarker; // 0x38
	private static ProfilerMarker k_HandleVisibleCharacterMarker; // 0x40
	private static ProfilerMarker k_HandleWhiteSpacesMarker; // 0x48
	private static ProfilerMarker k_HandleHorizontalLineBreakingMarker; // 0x50
	private static ProfilerMarker k_HandleVerticalLineBreakingMarker; // 0x58
	private static ProfilerMarker k_SaveGlyphVertexDataMarker; // 0x60
	private static ProfilerMarker k_ComputeCharacterAdvanceMarker; // 0x68
	private static ProfilerMarker k_HandleCarriageReturnMarker; // 0x70
	private static ProfilerMarker k_HandleLineTerminationMarker; // 0x78
	private static ProfilerMarker k_SavePageInfoMarker; // 0x80
	private static ProfilerMarker k_SaveTextExtentMarker; // 0x88
	private static ProfilerMarker k_SaveProcessingStatesMarker; // 0x90
	private static ProfilerMarker k_GenerateTextPhaseIIMarker; // 0x98
	private static ProfilerMarker k_GenerateTextPhaseIIIMarker; // 0xA0
	private Dictionary<int, int> materialIndexPairs; // 0x7C0

	// Properties
	public override Material materialForRendering { get; }
	public override bool autoSizeTextContainer { get; set; }
	public override Mesh mesh { get; }
	public CanvasRenderer canvasRenderer { get; }
	public Vector4 maskOffset { get; set; }

	// Methods

	// RVA: 0x1E276D0 Offset: 0x1E236D0 VA: 0x1E276D0 Slot: 34
	public override Material get_materialForRendering() { }

	// RVA: 0x1E27730 Offset: 0x1E23730 VA: 0x1E27730 Slot: 75
	public override bool get_autoSizeTextContainer() { }

	// RVA: 0x1E27738 Offset: 0x1E23738 VA: 0x1E27738 Slot: 76
	public override void set_autoSizeTextContainer(bool value) { }

	// RVA: 0x1E277D8 Offset: 0x1E237D8 VA: 0x1E277D8 Slot: 77
	public override Mesh get_mesh() { }

	// RVA: 0x1E277E0 Offset: 0x1E237E0 VA: 0x1E277E0
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x1E27880 Offset: 0x1E23880 VA: 0x1E27880 Slot: 133
	public void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1E27884 Offset: 0x1E23884 VA: 0x1E27884 Slot: 134
	public void CalculateLayoutInputVertical() { }

	// RVA: 0x1E27888 Offset: 0x1E23888 VA: 0x1E27888 Slot: 28
	public override void SetVerticesDirty() { }

	// RVA: 0x1E2796C Offset: 0x1E2396C VA: 0x1E2796C Slot: 27
	public override void SetLayoutDirty() { }

	// RVA: 0x1E27A5C Offset: 0x1E23A5C VA: 0x1E27A5C Slot: 29
	public override void SetMaterialDirty() { }

	// RVA: 0x1E27B48 Offset: 0x1E23B48 VA: 0x1E27B48 Slot: 26
	public override void SetAllDirty() { }

	[IteratorStateMachine(typeof(TextMeshProUGUI.<DelayedGraphicRebuild>d__18))]
	// RVA: 0x1E27B8C Offset: 0x1E23B8C VA: 0x1E27B8C
	private IEnumerator DelayedGraphicRebuild() { }

	[IteratorStateMachine(typeof(TextMeshProUGUI.<DelayedMaterialRebuild>d__19))]
	// RVA: 0x1E27C00 Offset: 0x1E23C00 VA: 0x1E27C00
	private IEnumerator DelayedMaterialRebuild() { }

	// RVA: 0x1E27C74 Offset: 0x1E23C74 VA: 0x1E27C74 Slot: 37
	public override void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1E27FD8 Offset: 0x1E23FD8 VA: 0x1E27FD8
	private void UpdateSubObjectPivot() { }

	// RVA: 0x1E280B4 Offset: 0x1E240B4 VA: 0x1E280B4 Slot: 58
	public override Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1E281C4 Offset: 0x1E241C4 VA: 0x1E281C4 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x1E282B0 Offset: 0x1E242B0 VA: 0x1E282B0
	public Vector4 get_maskOffset() { }

	// RVA: 0x1E282C4 Offset: 0x1E242C4 VA: 0x1E282C4
	public void set_maskOffset(Vector4 value) { }

	// RVA: 0x1E28610 Offset: 0x1E24610 VA: 0x1E28610 Slot: 63
	public override void RecalculateClipping() { }

	// RVA: 0x1E28618 Offset: 0x1E24618 VA: 0x1E28618 Slot: 59
	public override void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x1E28860 Offset: 0x1E24860 VA: 0x1E28860 Slot: 102
	internal override void UpdateCulling() { }

	// RVA: 0x1E28A6C Offset: 0x1E24A6C VA: 0x1E28A6C Slot: 111
	public override void UpdateMeshPadding() { }

	// RVA: 0x1E28B6C Offset: 0x1E24B6C VA: 0x1E28B6C Slot: 112
	protected override void InternalCrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x1E28C40 Offset: 0x1E24C40 VA: 0x1E28C40 Slot: 113
	protected override void InternalCrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x1E28CE4 Offset: 0x1E24CE4 VA: 0x1E28CE4 Slot: 106
	public override void ForceMeshUpdate(bool ignoreActiveState = False, bool forceTextReparsing = False) { }

	// RVA: 0x1E28D98 Offset: 0x1E24D98 VA: 0x1E28D98 Slot: 118
	public override TMP_TextInfo GetTextInfo(string text) { }

	// RVA: 0x1E28E8C Offset: 0x1E24E8C VA: 0x1E28E8C Slot: 129
	public override void ClearMesh() { }

	[CompilerGenerated]
	// RVA: 0x1E28F84 Offset: 0x1E24F84 VA: 0x1E28F84 Slot: 78
	public override void add_OnPreRenderText(Action<TMP_TextInfo> value) { }

	[CompilerGenerated]
	// RVA: 0x1E29034 Offset: 0x1E25034 VA: 0x1E29034 Slot: 79
	public override void remove_OnPreRenderText(Action<TMP_TextInfo> value) { }

	// RVA: 0x1E290E4 Offset: 0x1E250E4 VA: 0x1E290E4 Slot: 107
	public override void UpdateGeometry(Mesh mesh, int index) { }

	// RVA: 0x1E2915C Offset: 0x1E2515C VA: 0x1E2915C Slot: 108
	public override void UpdateVertexData(TMP_VertexDataUpdateFlags flags) { }

	// RVA: 0x1E29344 Offset: 0x1E25344 VA: 0x1E29344 Slot: 109
	public override void UpdateVertexData() { }

	// RVA: 0x1E2955C Offset: 0x1E2555C VA: 0x1E2955C
	public void UpdateFontAsset() { }

	// RVA: 0x1E2956C Offset: 0x1E2556C VA: 0x1E2956C Slot: 4
	protected override void Awake() { }

	// RVA: 0x1E2986C Offset: 0x1E2586C VA: 0x1E2986C Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1E29B08 Offset: 0x1E25B08 VA: 0x1E29B08 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1E29CA8 Offset: 0x1E25CA8 VA: 0x1E29CA8 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1E29E10 Offset: 0x1E25E10 VA: 0x1E29E10 Slot: 89
	protected override void LoadFontAsset() { }

	// RVA: 0x1E299A4 Offset: 0x1E259A4 VA: 0x1E299A4
	private Canvas GetCanvas() { }

	// RVA: 0x1E2A3C0 Offset: 0x1E263C0 VA: 0x1E2A3C0
	private void ValidateEnvMapProperty() { }

	// RVA: 0x1E2A4EC Offset: 0x1E264EC VA: 0x1E2A4EC
	private void UpdateEnvMapMatrix() { }

	// RVA: 0x1E2A708 Offset: 0x1E26708 VA: 0x1E2A708
	private void EnableMasking() { }

	// RVA: 0x1E2A8C4 Offset: 0x1E268C4 VA: 0x1E2A8C4
	private void DisableMasking() { }

	// RVA: 0x1E282F0 Offset: 0x1E242F0 VA: 0x1E282F0
	private void UpdateMask() { }

	// RVA: 0x1E2A8C8 Offset: 0x1E268C8 VA: 0x1E2A8C8 Slot: 91
	protected override Material GetMaterial(Material mat) { }

	// RVA: 0x1E2AA1C Offset: 0x1E26A1C VA: 0x1E2AA1C Slot: 95
	protected override Material[] GetMaterials(Material[] mats) { }

	// RVA: 0x1E2AC00 Offset: 0x1E26C00 VA: 0x1E2AC00 Slot: 90
	protected override void SetSharedMaterial(Material mat) { }

	// RVA: 0x1E2AC44 Offset: 0x1E26C44 VA: 0x1E2AC44 Slot: 93
	protected override Material[] GetSharedMaterials() { }

	// RVA: 0x1E2ADFC Offset: 0x1E26DFC VA: 0x1E2ADFC Slot: 94
	protected override void SetSharedMaterials(Material[] materials) { }

	// RVA: 0x1E2B238 Offset: 0x1E27238 VA: 0x1E2B238 Slot: 99
	protected override void SetOutlineThickness(float thickness) { }

	// RVA: 0x1E2B408 Offset: 0x1E27408 VA: 0x1E2B408 Slot: 97
	protected override void SetFaceColor(Color32 color) { }

	// RVA: 0x1E2B548 Offset: 0x1E27548 VA: 0x1E2B548 Slot: 98
	protected override void SetOutlineColor(Color32 color) { }

	// RVA: 0x1E2B688 Offset: 0x1E27688 VA: 0x1E2B688 Slot: 100
	protected override void SetShaderDepth() { }

	// RVA: 0x1E2B734 Offset: 0x1E27734 VA: 0x1E2B734 Slot: 101
	protected override void SetCulling() { }

	// RVA: 0x1E2BA28 Offset: 0x1E27A28 VA: 0x1E2BA28
	private void SetPerspectiveCorrection() { }

	// RVA: 0x1E2BAB4 Offset: 0x1E27AB4 VA: 0x1E2BAB4
	private void SetMeshArrays(int size) { }

	// RVA: 0x1E2BB60 Offset: 0x1E27B60 VA: 0x1E2BB60 Slot: 114
	internal override int SetArraySizes(TMP_Text.TextProcessingElement[] textProcessingArray) { }

	// RVA: 0x1E2E1C4 Offset: 0x1E2A1C4 VA: 0x1E2E1C4 Slot: 119
	public override void ComputeMarginSize() { }

	// RVA: 0x1E2E2B8 Offset: 0x1E2A2B8 VA: 0x1E2E2B8 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1E2E2F0 Offset: 0x1E2A2F0 VA: 0x1E2E2F0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1E2E418 Offset: 0x1E2A418 VA: 0x1E2E418 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1E2E468 Offset: 0x1E2A468 VA: 0x1E2E468 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1E2E6A0 Offset: 0x1E2A6A0 VA: 0x1E2E6A0 Slot: 132
	internal override void InternalUpdate() { }

	// RVA: 0x1E27D5C Offset: 0x1E23D5C VA: 0x1E27D5C
	private void OnPreRenderCanvas() { }

	// RVA: 0x1E10810 Offset: 0x1E0C810 VA: 0x1E10810 Slot: 142
	protected virtual void GenerateTextMesh() { }

	// RVA: 0x1E2E944 Offset: 0x1E2A944 VA: 0x1E2E944 Slot: 105
	protected override Vector3[] GetTextContainerLocalCorners() { }

	// RVA: 0x1E2E9E8 Offset: 0x1E2A9E8 VA: 0x1E2E9E8 Slot: 127
	protected override void SetActiveSubMeshes(bool state) { }

	// RVA: 0x1E2EB04 Offset: 0x1E2AB04 VA: 0x1E2EB04 Slot: 128
	protected override void DestroySubMeshObjects() { }

	// RVA: 0x1E2EBE0 Offset: 0x1E2ABE0 VA: 0x1E2EBE0 Slot: 116
	protected override Bounds GetCompoundBounds() { }

	// RVA: 0x1E2EDA8 Offset: 0x1E2ADA8 VA: 0x1E2EDA8 Slot: 117
	internal override Rect GetCanvasSpaceClippingRect() { }

	// RVA: 0x1E2E748 Offset: 0x1E2A748 VA: 0x1E2E748
	private void UpdateSDFScale(float scaleDelta) { }

	// RVA: 0x1E2EF68 Offset: 0x1E2AF68 VA: 0x1E2EF68
	public void .ctor() { }

	// RVA: 0x1E2F08C Offset: 0x1E2B08C VA: 0x1E2F08C
	private static void .cctor() { }
}
