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

// Namespace: UnityEngine.UI
[Serializable]
public class AnimationTriggers // TypeDefIndex: 7229
{
	// Fields
	private const string kDefaultNormalAnimName = "Normal";
	private const string kDefaultHighlightedAnimName = "Highlighted";
	private const string kDefaultPressedAnimName = "Pressed";
	private const string kDefaultSelectedAnimName = "Selected";
	private const string kDefaultDisabledAnimName = "Disabled";
	[FormerlySerializedAs("normalTrigger")]
	[SerializeField]
	private string m_NormalTrigger; // 0x10
	[FormerlySerializedAs("highlightedTrigger")]
	[SerializeField]
	private string m_HighlightedTrigger; // 0x18
	[FormerlySerializedAs("pressedTrigger")]
	[SerializeField]
	private string m_PressedTrigger; // 0x20
	[FormerlySerializedAs("m_HighlightedTrigger")]
	[SerializeField]
	private string m_SelectedTrigger; // 0x28
	[FormerlySerializedAs("disabledTrigger")]
	[SerializeField]
	private string m_DisabledTrigger; // 0x30

	// Properties
	public string normalTrigger { get; set; }
	public string highlightedTrigger { get; set; }
	public string pressedTrigger { get; set; }
	public string selectedTrigger { get; set; }
	public string disabledTrigger { get; set; }

	// Methods

	// RVA: 0x1ED7CF4 Offset: 0x1ED3CF4 VA: 0x1ED7CF4
	public string get_normalTrigger() { }

	// RVA: 0x1ED7CFC Offset: 0x1ED3CFC VA: 0x1ED7CFC
	public void set_normalTrigger(string value) { }

	// RVA: 0x1ED7D04 Offset: 0x1ED3D04 VA: 0x1ED7D04
	public string get_highlightedTrigger() { }

	// RVA: 0x1ED7D0C Offset: 0x1ED3D0C VA: 0x1ED7D0C
	public void set_highlightedTrigger(string value) { }

	// RVA: 0x1ED7D14 Offset: 0x1ED3D14 VA: 0x1ED7D14
	public string get_pressedTrigger() { }

	// RVA: 0x1ED7D1C Offset: 0x1ED3D1C VA: 0x1ED7D1C
	public void set_pressedTrigger(string value) { }

	// RVA: 0x1ED7D24 Offset: 0x1ED3D24 VA: 0x1ED7D24
	public string get_selectedTrigger() { }

	// RVA: 0x1ED7D2C Offset: 0x1ED3D2C VA: 0x1ED7D2C
	public void set_selectedTrigger(string value) { }

	// RVA: 0x1ED7D34 Offset: 0x1ED3D34 VA: 0x1ED7D34
	public string get_disabledTrigger() { }

	// RVA: 0x1ED7D3C Offset: 0x1ED3D3C VA: 0x1ED7D3C
	public void set_disabledTrigger(string value) { }

	// RVA: 0x1ED7D44 Offset: 0x1ED3D44 VA: 0x1ED7D44
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class Button.ButtonClickedEvent : UnityEvent // TypeDefIndex: 7230
{
	// Methods

	// RVA: 0x1ED7ED4 Offset: 0x1ED3ED4 VA: 0x1ED7ED4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Button.<OnFinishSubmit>d__9 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7231
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Button <>4__this; // 0x20
	private float <fadeTime>5__2; // 0x28
	private float <elapsedTime>5__3; // 0x2C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1ED808C Offset: 0x1ED408C VA: 0x1ED808C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1ED80B4 Offset: 0x1ED40B4 VA: 0x1ED80B4 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1ED80B8 Offset: 0x1ED40B8 VA: 0x1ED80B8 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1ED81B8 Offset: 0x1ED41B8 VA: 0x1ED81B8 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1ED81C0 Offset: 0x1ED41C0 VA: 0x1ED81C0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1ED81F8 Offset: 0x1ED41F8 VA: 0x1ED81F8 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Button", 30)]
public class Button : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler // TypeDefIndex: 7232
{
	// Fields
	[FormerlySerializedAs("onClick")]
	[SerializeField]
	private Button.ButtonClickedEvent m_OnClick; // 0x100

	// Properties
	public Button.ButtonClickedEvent onClick { get; set; }

	// Methods

	// RVA: 0x1ED7E3C Offset: 0x1ED3E3C VA: 0x1ED7E3C
	protected void .ctor() { }

	// RVA: 0x1ED7EDC Offset: 0x1ED3EDC VA: 0x1ED7EDC
	public Button.ButtonClickedEvent get_onClick() { }

	// RVA: 0x1ED7EE4 Offset: 0x1ED3EE4 VA: 0x1ED7EE4
	public void set_onClick(Button.ButtonClickedEvent value) { }

	// RVA: 0x1ED7EF4 Offset: 0x1ED3EF4 VA: 0x1ED7EF4
	private void Press() { }

	// RVA: 0x1ED7F8C Offset: 0x1ED3F8C VA: 0x1ED7F8C Slot: 41
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1ED7FA8 Offset: 0x1ED3FA8 VA: 0x1ED7FA8 Slot: 42
	public virtual void OnSubmit(BaseEventData eventData) { }

	[IteratorStateMachine(typeof(Button.<OnFinishSubmit>d__9))]
	// RVA: 0x1ED8020 Offset: 0x1ED4020 VA: 0x1ED8020
	private IEnumerator OnFinishSubmit() { }
}

// Namespace: UnityEngine.UI
public enum CanvasUpdate // TypeDefIndex: 7233
{
	// Fields
	public int value__; // 0x0
	public const CanvasUpdate Prelayout = 0;
	public const CanvasUpdate Layout = 1;
	public const CanvasUpdate PostLayout = 2;
	public const CanvasUpdate PreRender = 3;
	public const CanvasUpdate LatePreRender = 4;
	public const CanvasUpdate MaxUpdateValue = 5;
}

// Namespace: UnityEngine.UI
public interface ICanvasElement // TypeDefIndex: 7234
{
	// Properties
	public abstract Transform transform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Rebuild(CanvasUpdate executing);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Transform get_transform();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void LayoutComplete();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GraphicUpdateComplete();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsDestroyed();
}

// Namespace: UnityEngine.UI
public class CanvasUpdateRegistry // TypeDefIndex: 7235
{
	// Fields
	private static CanvasUpdateRegistry s_Instance; // 0x0
	private bool m_PerformingLayoutUpdate; // 0x10
	private bool m_PerformingGraphicUpdate; // 0x11
	private string[] m_CanvasUpdateProfilerStrings; // 0x18
	private const string m_CullingUpdateProfilerString = "ClipperRegistry.Cull";
	private readonly IndexedSet<ICanvasElement> m_LayoutRebuildQueue; // 0x20
	private readonly IndexedSet<ICanvasElement> m_GraphicRebuildQueue; // 0x28
	private static readonly Comparison<ICanvasElement> s_SortLayoutFunction; // 0x8

	// Properties
	public static CanvasUpdateRegistry instance { get; }

	// Methods

	// RVA: 0x1ED8200 Offset: 0x1ED4200 VA: 0x1ED8200
	protected void .ctor() { }

	// RVA: 0x1ED8440 Offset: 0x1ED4440 VA: 0x1ED8440
	public static CanvasUpdateRegistry get_instance() { }

	// RVA: 0x1ED84F0 Offset: 0x1ED44F0 VA: 0x1ED84F0
	private bool ObjectValidForUpdate(ICanvasElement element) { }

	// RVA: 0x1ED85C0 Offset: 0x1ED45C0 VA: 0x1ED85C0
	private void CleanInvalidItems() { }

	// RVA: 0x1ED8890 Offset: 0x1ED4890 VA: 0x1ED8890
	private void PerformUpdate() { }

	// RVA: 0x1ED8FC0 Offset: 0x1ED4FC0 VA: 0x1ED8FC0
	private static int ParentCount(Transform child) { }

	// RVA: 0x1ED907C Offset: 0x1ED507C VA: 0x1ED907C
	private static int SortLayoutList(ICanvasElement x, ICanvasElement y) { }

	// RVA: 0x1ED91D4 Offset: 0x1ED51D4 VA: 0x1ED91D4
	public static void RegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1ED92CC Offset: 0x1ED52CC VA: 0x1ED92CC
	public static bool TryRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1ED9234 Offset: 0x1ED5234 VA: 0x1ED9234
	private bool InternalRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1ED932C Offset: 0x1ED532C VA: 0x1ED932C
	public static void RegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1ED945C Offset: 0x1ED545C VA: 0x1ED945C
	public static bool TryRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1ED938C Offset: 0x1ED538C VA: 0x1ED938C
	private bool InternalRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1ED94BC Offset: 0x1ED54BC VA: 0x1ED94BC
	public static void UnRegisterCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x1ED97F4 Offset: 0x1ED57F4 VA: 0x1ED97F4
	public static void DisableCanvasElementForRebuild(ICanvasElement element) { }

	// RVA: 0x1ED952C Offset: 0x1ED552C VA: 0x1ED952C
	private void InternalUnRegisterCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1ED9690 Offset: 0x1ED5690 VA: 0x1ED9690
	private void InternalUnRegisterCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1ED9864 Offset: 0x1ED5864 VA: 0x1ED9864
	private void InternalDisableCanvasElementForLayoutRebuild(ICanvasElement element) { }

	// RVA: 0x1ED99C8 Offset: 0x1ED59C8 VA: 0x1ED99C8
	private void InternalDisableCanvasElementForGraphicRebuild(ICanvasElement element) { }

	// RVA: 0x1ED9B2C Offset: 0x1ED5B2C VA: 0x1ED9B2C
	public static bool IsRebuildingLayout() { }

	// RVA: 0x1ED9B88 Offset: 0x1ED5B88 VA: 0x1ED9B88
	public static bool IsRebuildingGraphics() { }

	// RVA: 0x1ED9BE4 Offset: 0x1ED5BE4 VA: 0x1ED9BE4
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Serializable]
public struct ColorBlock : IEquatable<ColorBlock> // TypeDefIndex: 7236
{
	// Fields
	[FormerlySerializedAs("normalColor")]
	[SerializeField]
	private Color m_NormalColor; // 0x0
	[FormerlySerializedAs("highlightedColor")]
	[SerializeField]
	private Color m_HighlightedColor; // 0x10
	[FormerlySerializedAs("pressedColor")]
	[SerializeField]
	private Color m_PressedColor; // 0x20
	[FormerlySerializedAs("m_HighlightedColor")]
	[SerializeField]
	private Color m_SelectedColor; // 0x30
	[FormerlySerializedAs("disabledColor")]
	[SerializeField]
	private Color m_DisabledColor; // 0x40
	[Range(1, 5)]
	[SerializeField]
	private float m_ColorMultiplier; // 0x50
	[FormerlySerializedAs("fadeDuration")]
	[SerializeField]
	private float m_FadeDuration; // 0x54
	public static ColorBlock defaultColorBlock; // 0x0

	// Properties
	public Color normalColor { get; set; }
	public Color highlightedColor { get; set; }
	public Color pressedColor { get; set; }
	public Color selectedColor { get; set; }
	public Color disabledColor { get; set; }
	public float colorMultiplier { get; set; }
	public float fadeDuration { get; set; }

	// Methods

	// RVA: 0x1ED9C7C Offset: 0x1ED5C7C VA: 0x1ED9C7C
	public Color get_normalColor() { }

	// RVA: 0x1ED9C88 Offset: 0x1ED5C88 VA: 0x1ED9C88
	public void set_normalColor(Color value) { }

	// RVA: 0x1ED9C94 Offset: 0x1ED5C94 VA: 0x1ED9C94
	public Color get_highlightedColor() { }

	// RVA: 0x1ED9CA0 Offset: 0x1ED5CA0 VA: 0x1ED9CA0
	public void set_highlightedColor(Color value) { }

	// RVA: 0x1ED9CAC Offset: 0x1ED5CAC VA: 0x1ED9CAC
	public Color get_pressedColor() { }

	// RVA: 0x1ED9CB8 Offset: 0x1ED5CB8 VA: 0x1ED9CB8
	public void set_pressedColor(Color value) { }

	// RVA: 0x1ED9CC4 Offset: 0x1ED5CC4 VA: 0x1ED9CC4
	public Color get_selectedColor() { }

	// RVA: 0x1ED9CD0 Offset: 0x1ED5CD0 VA: 0x1ED9CD0
	public void set_selectedColor(Color value) { }

	// RVA: 0x1ED9CDC Offset: 0x1ED5CDC VA: 0x1ED9CDC
	public Color get_disabledColor() { }

	// RVA: 0x1ED9CE8 Offset: 0x1ED5CE8 VA: 0x1ED9CE8
	public void set_disabledColor(Color value) { }

	// RVA: 0x1ED9CF4 Offset: 0x1ED5CF4 VA: 0x1ED9CF4
	public float get_colorMultiplier() { }

	// RVA: 0x1ED9CFC Offset: 0x1ED5CFC VA: 0x1ED9CFC
	public void set_colorMultiplier(float value) { }

	// RVA: 0x1ED9D04 Offset: 0x1ED5D04 VA: 0x1ED9D04
	public float get_fadeDuration() { }

	// RVA: 0x1ED9D0C Offset: 0x1ED5D0C VA: 0x1ED9D0C
	public void set_fadeDuration(float value) { }

	// RVA: 0x1ED9D14 Offset: 0x1ED5D14 VA: 0x1ED9D14
	private static void .cctor() { }

	// RVA: 0x1ED9D8C Offset: 0x1ED5D8C VA: 0x1ED9D8C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1ED9E4C Offset: 0x1ED5E4C VA: 0x1ED9E4C Slot: 4
	public bool Equals(ColorBlock other) { }

	// RVA: 0x1EDA044 Offset: 0x1ED6044 VA: 0x1EDA044
	public static bool op_Equality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x1EDA0C8 Offset: 0x1ED60C8 VA: 0x1EDA0C8
	public static bool op_Inequality(ColorBlock point1, ColorBlock point2) { }

	// RVA: 0x1EDA150 Offset: 0x1ED6150 VA: 0x1EDA150 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.UI
public class ClipperRegistry // TypeDefIndex: 7237
{
	// Fields
	private static ClipperRegistry s_Instance; // 0x0
	private readonly IndexedSet<IClipper> m_Clippers; // 0x10

	// Properties
	public static ClipperRegistry instance { get; }

	// Methods

	// RVA: 0x1EDA1BC Offset: 0x1ED61BC VA: 0x1EDA1BC
	protected void .ctor() { }

	// RVA: 0x1ED8E30 Offset: 0x1ED4E30 VA: 0x1ED8E30
	public static ClipperRegistry get_instance() { }

	// RVA: 0x1ED8EB4 Offset: 0x1ED4EB4 VA: 0x1ED8EB4
	public void Cull() { }

	// RVA: 0x1EDA244 Offset: 0x1ED6244 VA: 0x1EDA244
	public static void Register(IClipper c) { }

	// RVA: 0x1EDA2B4 Offset: 0x1ED62B4 VA: 0x1EDA2B4
	public static void Unregister(IClipper c) { }

	// RVA: 0x1EDA310 Offset: 0x1ED6310 VA: 0x1EDA310
	public static void Disable(IClipper c) { }
}

// Namespace: UnityEngine.UI
public static class Clipping // TypeDefIndex: 7238
{
	// Methods

	// RVA: 0x1EDA36C Offset: 0x1ED636C VA: 0x1EDA36C
	public static Rect FindCullAndClipWorldRect(List<RectMask2D> rectMaskParents, out bool validRect) { }
}

// Namespace: UnityEngine.UI
public interface IClipper // TypeDefIndex: 7239
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void PerformClipping();
}

// Namespace: UnityEngine.UI
public interface IClippable // TypeDefIndex: 7240
{
	// Properties
	public abstract GameObject gameObject { get; }
	public abstract RectTransform rectTransform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject get_gameObject();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RecalculateClipping();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract RectTransform get_rectTransform();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Cull(Rect clipRect, bool validRect);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetClipRect(Rect value, bool validRect);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetClipSoftness(Vector2 clipSoftness);
}

// Namespace: UnityEngine.UI
internal class RectangularVertexClipper // TypeDefIndex: 7241
{
	// Fields
	private readonly Vector3[] m_WorldCorners; // 0x10
	private readonly Vector3[] m_CanvasCorners; // 0x18

	// Methods

	// RVA: 0x1EDA520 Offset: 0x1ED6520 VA: 0x1EDA520
	public Rect GetCanvasRect(RectTransform t, Canvas c) { }

	// RVA: 0x1EDA678 Offset: 0x1ED6678 VA: 0x1EDA678
	public void .ctor() { }
}

// Namespace: 
public interface DefaultControls.IFactoryControls // TypeDefIndex: 7242
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract GameObject CreateGameObject(string name, Type[] components);
}

// Namespace: 
private class DefaultControls.DefaultRuntimeFactory : DefaultControls.IFactoryControls // TypeDefIndex: 7243
{
	// Fields
	public static DefaultControls.IFactoryControls Default; // 0x0

	// Methods

	// RVA: 0x1EDF21C Offset: 0x1EDB21C VA: 0x1EDF21C Slot: 4
	public GameObject CreateGameObject(string name, Type[] components) { }

	// RVA: 0x1EDF288 Offset: 0x1EDB288 VA: 0x1EDF288
	public void .ctor() { }

	// RVA: 0x1EDF290 Offset: 0x1EDB290 VA: 0x1EDF290
	private static void .cctor() { }
}

// Namespace: 
public struct DefaultControls.Resources // TypeDefIndex: 7244
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

// Namespace: UnityEngine.UI
public static class DefaultControls // TypeDefIndex: 7245
{
	// Fields
	private static DefaultControls.IFactoryControls m_CurrentFactory; // 0x0
	private const float kWidth = 160;
	private const float kThickHeight = 30;
	private const float kThinHeight = 20;
	private static Vector2 s_ThickElementSize; // 0x8
	private static Vector2 s_ThinElementSize; // 0x10
	private static Vector2 s_ImageElementSize; // 0x18
	private static Color s_DefaultSelectableColor; // 0x20
	private static Color s_PanelColor; // 0x30
	private static Color s_TextColor; // 0x40

	// Properties
	public static DefaultControls.IFactoryControls factory { get; }

	// Methods

	// RVA: 0x1EDA6F8 Offset: 0x1ED66F8 VA: 0x1EDA6F8
	public static DefaultControls.IFactoryControls get_factory() { }

	// RVA: 0x1EDA750 Offset: 0x1ED6750 VA: 0x1EDA750
	private static GameObject CreateUIElementRoot(string name, Vector2 size, Type[] components) { }

	// RVA: 0x1EDA8B0 Offset: 0x1ED68B0 VA: 0x1EDA8B0
	private static GameObject CreateUIObject(string name, GameObject parent, Type[] components) { }

	// RVA: 0x1EDAAD8 Offset: 0x1ED6AD8 VA: 0x1EDAAD8
	private static void SetDefaultTextValues(Text lbl) { }

	// RVA: 0x1EDABB4 Offset: 0x1ED6BB4 VA: 0x1EDABB4
	private static void SetDefaultColorTransitionValues(Selectable slider) { }

	// RVA: 0x1EDA9D8 Offset: 0x1ED69D8 VA: 0x1EDA9D8
	private static void SetParentAndAlign(GameObject child, GameObject parent) { }

	// RVA: 0x1EDAC14 Offset: 0x1ED6C14 VA: 0x1EDAC14
	private static void SetLayerRecursively(GameObject go, int layer) { }

	// RVA: 0x1EDACF8 Offset: 0x1ED6CF8 VA: 0x1EDACF8
	public static GameObject CreatePanel(DefaultControls.Resources resources) { }

	// RVA: 0x1EDB300 Offset: 0x1ED7300 VA: 0x1EDB300
	public static GameObject CreateButton(DefaultControls.Resources resources) { }

	// RVA: 0x1EDB70C Offset: 0x1ED770C VA: 0x1EDB70C
	public static GameObject CreateText(DefaultControls.Resources resources) { }

	// RVA: 0x1EDB8A4 Offset: 0x1ED78A4 VA: 0x1EDB8A4
	public static GameObject CreateImage(DefaultControls.Resources resources) { }

	// RVA: 0x1EDB9D8 Offset: 0x1ED79D8 VA: 0x1EDB9D8
	public static GameObject CreateRawImage(DefaultControls.Resources resources) { }

	// RVA: 0x1EDBB0C Offset: 0x1ED7B0C VA: 0x1EDBB0C
	public static GameObject CreateSlider(DefaultControls.Resources resources) { }

	// RVA: 0x1EDC204 Offset: 0x1ED8204 VA: 0x1EDC204
	public static GameObject CreateScrollbar(DefaultControls.Resources resources) { }

	// RVA: 0x1EDC6AC Offset: 0x1ED86AC VA: 0x1EDC6AC
	public static GameObject CreateToggle(DefaultControls.Resources resources) { }

	// RVA: 0x1EDCC50 Offset: 0x1ED8C50 VA: 0x1EDCC50
	public static GameObject CreateInputField(DefaultControls.Resources resources) { }

	// RVA: 0x1EDD298 Offset: 0x1ED9298 VA: 0x1EDD298
	public static GameObject CreateDropdown(DefaultControls.Resources resources) { }

	// RVA: 0x1EDE81C Offset: 0x1EDA81C VA: 0x1EDE81C
	public static GameObject CreateScrollView(DefaultControls.Resources resources) { }

	// RVA: 0x1EDF138 Offset: 0x1EDB138 VA: 0x1EDF138
	private static void .cctor() { }
}

// Namespace: 
protected internal class Dropdown.DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler // TypeDefIndex: 7246
{
	// Fields
	[SerializeField]
	private Text m_Text; // 0x20
	[SerializeField]
	private Image m_Image; // 0x28
	[SerializeField]
	private RectTransform m_RectTransform; // 0x30
	[SerializeField]
	private Toggle m_Toggle; // 0x38

	// Properties
	public Text text { get; set; }
	public Image image { get; set; }
	public RectTransform rectTransform { get; set; }
	public Toggle toggle { get; set; }

	// Methods

	// RVA: 0x1EE2114 Offset: 0x1EDE114 VA: 0x1EE2114
	public Text get_text() { }

	// RVA: 0x1EE211C Offset: 0x1EDE11C VA: 0x1EE211C
	public void set_text(Text value) { }

	// RVA: 0x1EE2124 Offset: 0x1EDE124 VA: 0x1EE2124
	public Image get_image() { }

	// RVA: 0x1EE212C Offset: 0x1EDE12C VA: 0x1EE212C
	public void set_image(Image value) { }

	// RVA: 0x1EE2134 Offset: 0x1EDE134 VA: 0x1EE2134
	public RectTransform get_rectTransform() { }

	// RVA: 0x1EE213C Offset: 0x1EDE13C VA: 0x1EE213C
	public void set_rectTransform(RectTransform value) { }

	// RVA: 0x1EE2144 Offset: 0x1EDE144 VA: 0x1EE2144
	public Toggle get_toggle() { }

	// RVA: 0x1EE214C Offset: 0x1EDE14C VA: 0x1EE214C
	public void set_toggle(Toggle value) { }

	// RVA: 0x1EE2154 Offset: 0x1EDE154 VA: 0x1EE2154 Slot: 6
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1EE21D0 Offset: 0x1EDE1D0 VA: 0x1EE21D0 Slot: 7
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1EE227C Offset: 0x1EDE27C VA: 0x1EE227C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class Dropdown.OptionData // TypeDefIndex: 7247
{
	// Fields
	[SerializeField]
	private string m_Text; // 0x10
	[SerializeField]
	private Sprite m_Image; // 0x18

	// Properties
	public string text { get; set; }
	public Sprite image { get; set; }

	// Methods

	// RVA: 0x1EE2284 Offset: 0x1EDE284 VA: 0x1EE2284
	public string get_text() { }

	// RVA: 0x1EE228C Offset: 0x1EDE28C VA: 0x1EE228C
	public void set_text(string value) { }

	// RVA: 0x1EE2294 Offset: 0x1EDE294 VA: 0x1EE2294
	public Sprite get_image() { }

	// RVA: 0x1EE229C Offset: 0x1EDE29C VA: 0x1EE229C
	public void set_image(Sprite value) { }

	// RVA: 0x1EDE628 Offset: 0x1EDA628 VA: 0x1EDE628
	public void .ctor() { }

	// RVA: 0x1EDFC9C Offset: 0x1EDBC9C VA: 0x1EDFC9C
	public void .ctor(string text) { }

	// RVA: 0x1EDFE34 Offset: 0x1EDBE34 VA: 0x1EDFE34
	public void .ctor(Sprite image) { }

	// RVA: 0x1EE22A4 Offset: 0x1EDE2A4 VA: 0x1EE22A4
	public void .ctor(string text, Sprite image) { }
}

// Namespace: 
[Serializable]
public class Dropdown.OptionDataList // TypeDefIndex: 7248
{
	// Fields
	[SerializeField]
	private List<Dropdown.OptionData> m_Options; // 0x10

	// Properties
	public List<Dropdown.OptionData> options { get; set; }

	// Methods

	// RVA: 0x1EE22E8 Offset: 0x1EDE2E8 VA: 0x1EE22E8
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x1EE22F0 Offset: 0x1EDE2F0 VA: 0x1EE22F0
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x1EDF624 Offset: 0x1EDB624 VA: 0x1EDF624
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class Dropdown.DropdownEvent : UnityEvent<int> // TypeDefIndex: 7249
{
	// Methods

	// RVA: 0x1EDF6AC Offset: 0x1EDB6AC VA: 0x1EDF6AC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Dropdown.<>c__DisplayClass63_0 // TypeDefIndex: 7250
{
	// Fields
	public Dropdown.DropdownItem item; // 0x10
	public Dropdown <>4__this; // 0x18

	// Methods

	// RVA: 0x1EE12C8 Offset: 0x1EDD2C8 VA: 0x1EE12C8
	public void .ctor() { }

	// RVA: 0x1EE22F8 Offset: 0x1EDE2F8 VA: 0x1EE22F8
	internal void <Show>b__0(bool x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Dropdown.<DelayedDestroyDropdownList>d__75 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7251
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public float delay; // 0x20
	public Dropdown <>4__this; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1EE1F3C Offset: 0x1EDDF3C VA: 0x1EE1F3C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1EE231C Offset: 0x1EDE31C VA: 0x1EE231C Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1EE2320 Offset: 0x1EDE320 VA: 0x1EE2320 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1EE23D8 Offset: 0x1EDE3D8 VA: 0x1EE23D8 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1EE23E0 Offset: 0x1EDE3E0 VA: 0x1EE23E0 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1EE2418 Offset: 0x1EDE418 VA: 0x1EE2418 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Legacy/Dropdown", 102)]
[RequireComponent(typeof(RectTransform))]
public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 7252
{
	// Fields
	[SerializeField]
	private RectTransform m_Template; // 0x100
	[SerializeField]
	private Text m_CaptionText; // 0x108
	[SerializeField]
	private Image m_CaptionImage; // 0x110
	[Space]
	[SerializeField]
	private Text m_ItemText; // 0x118
	[SerializeField]
	private Image m_ItemImage; // 0x120
	[Space]
	[SerializeField]
	private int m_Value; // 0x128
	[Space]
	[SerializeField]
	private Dropdown.OptionDataList m_Options; // 0x130
	[Space]
	[SerializeField]
	private Dropdown.DropdownEvent m_OnValueChanged; // 0x138
	[SerializeField]
	private float m_AlphaFadeSpeed; // 0x140
	private GameObject m_Dropdown; // 0x148
	private GameObject m_Blocker; // 0x150
	private List<Dropdown.DropdownItem> m_Items; // 0x158
	private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x160
	private bool validTemplate; // 0x168
	private const int kHighSortingLayer = 30000;
	private static Dropdown.OptionData s_NoOptionData; // 0x0

	// Properties
	public RectTransform template { get; set; }
	public Text captionText { get; set; }
	public Image captionImage { get; set; }
	public Text itemText { get; set; }
	public Image itemImage { get; set; }
	public List<Dropdown.OptionData> options { get; set; }
	public Dropdown.DropdownEvent onValueChanged { get; set; }
	public float alphaFadeSpeed { get; set; }
	public int value { get; set; }

	// Methods

	// RVA: 0x1EDF2F8 Offset: 0x1EDB2F8 VA: 0x1EDF2F8
	public RectTransform get_template() { }

	// RVA: 0x1EDE5B0 Offset: 0x1EDA5B0 VA: 0x1EDE5B0
	public void set_template(RectTransform value) { }

	// RVA: 0x1EDF300 Offset: 0x1EDB300 VA: 0x1EDF300
	public Text get_captionText() { }

	// RVA: 0x1EDE5D0 Offset: 0x1EDA5D0 VA: 0x1EDE5D0
	public void set_captionText(Text value) { }

	// RVA: 0x1EDF308 Offset: 0x1EDB308 VA: 0x1EDF308
	public Image get_captionImage() { }

	// RVA: 0x1EDF310 Offset: 0x1EDB310 VA: 0x1EDF310
	public void set_captionImage(Image value) { }

	// RVA: 0x1EDF330 Offset: 0x1EDB330 VA: 0x1EDF330
	public Text get_itemText() { }

	// RVA: 0x1EDE5F0 Offset: 0x1EDA5F0 VA: 0x1EDE5F0
	public void set_itemText(Text value) { }

	// RVA: 0x1EDF338 Offset: 0x1EDB338 VA: 0x1EDF338
	public Image get_itemImage() { }

	// RVA: 0x1EDF340 Offset: 0x1EDB340 VA: 0x1EDF340
	public void set_itemImage(Image value) { }

	// RVA: 0x1EDE610 Offset: 0x1EDA610 VA: 0x1EDE610
	public List<Dropdown.OptionData> get_options() { }

	// RVA: 0x1EDF360 Offset: 0x1EDB360 VA: 0x1EDF360
	public void set_options(List<Dropdown.OptionData> value) { }

	// RVA: 0x1EDF388 Offset: 0x1EDB388 VA: 0x1EDF388
	public Dropdown.DropdownEvent get_onValueChanged() { }

	// RVA: 0x1EDF390 Offset: 0x1EDB390 VA: 0x1EDF390
	public void set_onValueChanged(Dropdown.DropdownEvent value) { }

	// RVA: 0x1EDF3A0 Offset: 0x1EDB3A0 VA: 0x1EDF3A0
	public float get_alphaFadeSpeed() { }

	// RVA: 0x1EDF3A8 Offset: 0x1EDB3A8 VA: 0x1EDF3A8
	public void set_alphaFadeSpeed(float value) { }

	// RVA: 0x1EDF3B0 Offset: 0x1EDB3B0 VA: 0x1EDF3B0
	public int get_value() { }

	// RVA: 0x1EDF3B8 Offset: 0x1EDB3B8 VA: 0x1EDF3B8
	public void set_value(int value) { }

	// RVA: 0x1EDF4F4 Offset: 0x1EDB4F4 VA: 0x1EDF4F4
	public void SetValueWithoutNotify(int input) { }

	// RVA: 0x1EDF3C0 Offset: 0x1EDB3C0 VA: 0x1EDF3C0
	private void Set(int value, bool sendCallback = True) { }

	// RVA: 0x1EDF4FC Offset: 0x1EDB4FC VA: 0x1EDF4FC
	protected void .ctor() { }

	// RVA: 0x1EDF6F4 Offset: 0x1EDB6F4 VA: 0x1EDF6F4 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1EDF7F0 Offset: 0x1EDB7F0 VA: 0x1EDF7F0 Slot: 6
	protected override void Start() { }

	// RVA: 0x1EDF8A4 Offset: 0x1EDB8A4 VA: 0x1EDF8A4 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1EDE630 Offset: 0x1EDA630 VA: 0x1EDE630
	public void RefreshShownValue() { }

	// RVA: 0x1EDFACC Offset: 0x1EDBACC VA: 0x1EDFACC
	public void AddOptions(List<Dropdown.OptionData> options) { }

	// RVA: 0x1EDFB34 Offset: 0x1EDBB34 VA: 0x1EDFB34
	public void AddOptions(List<string> options) { }

	// RVA: 0x1EDFCCC Offset: 0x1EDBCCC VA: 0x1EDFCCC
	public void AddOptions(List<Sprite> options) { }

	// RVA: 0x1EDFE64 Offset: 0x1EDBE64 VA: 0x1EDFE64
	public void ClearOptions() { }

	// RVA: 0x1EDFEDC Offset: 0x1EDBEDC VA: 0x1EDFEDC
	private void SetupTemplate(Canvas rootCanvas) { }

	// RVA: -1 Offset: -1
	private static T GetOrAddComponent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10FA864 Offset: 0x10F6864 VA: 0x10FA864
	|-Dropdown.GetOrAddComponent<object>
	*/

	// RVA: 0x1EE05AC Offset: 0x1EDC5AC VA: 0x1EE05AC Slot: 42
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1EE11B8 Offset: 0x1EDD1B8 VA: 0x1EE11B8 Slot: 43
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1EE11BC Offset: 0x1EDD1BC VA: 0x1EE11BC Slot: 44
	public virtual void OnCancel(BaseEventData eventData) { }

	// RVA: 0x1EE05B0 Offset: 0x1EDC5B0 VA: 0x1EE05B0
	public void Show() { }

	// RVA: 0x1EE16D0 Offset: 0x1EDD6D0 VA: 0x1EE16D0 Slot: 45
	protected virtual GameObject CreateBlocker(Canvas rootCanvas) { }

	// RVA: 0x1EE1C00 Offset: 0x1EDDC00 VA: 0x1EE1C00 Slot: 46
	protected virtual void DestroyBlocker(GameObject blocker) { }

	// RVA: 0x1EE1C58 Offset: 0x1EDDC58 VA: 0x1EE1C58 Slot: 47
	protected virtual GameObject CreateDropdownList(GameObject template) { }

	// RVA: 0x1EE1CC4 Offset: 0x1EDDCC4 VA: 0x1EE1CC4 Slot: 48
	protected virtual void DestroyDropdownList(GameObject dropdownList) { }

	// RVA: 0x1EE1D1C Offset: 0x1EDDD1C VA: 0x1EE1D1C Slot: 49
	protected virtual Dropdown.DropdownItem CreateItem(Dropdown.DropdownItem itemTemplate) { }

	// RVA: 0x1EE1D88 Offset: 0x1EDDD88 VA: 0x1EE1D88 Slot: 50
	protected virtual void DestroyItem(Dropdown.DropdownItem item) { }

	// RVA: 0x1EE12D0 Offset: 0x1EDD2D0 VA: 0x1EE12D0
	private Dropdown.DropdownItem AddItem(Dropdown.OptionData data, bool selected, Dropdown.DropdownItem itemTemplate, List<Dropdown.DropdownItem> items) { }

	// RVA: 0x1EE1D8C Offset: 0x1EDDD8C VA: 0x1EE1D8C
	private void AlphaFadeList(float duration, float alpha) { }

	// RVA: 0x1EE15C0 Offset: 0x1EDD5C0 VA: 0x1EE15C0
	private void AlphaFadeList(float duration, float start, float end) { }

	// RVA: 0x1EE1E0C Offset: 0x1EDDE0C VA: 0x1EE1E0C
	private void SetAlpha(float alpha) { }

	// RVA: 0x1EE11C0 Offset: 0x1EDD1C0 VA: 0x1EE11C0
	public void Hide() { }

	[IteratorStateMachine(typeof(Dropdown.<DelayedDestroyDropdownList>d__75))]
	// RVA: 0x1EE1EC0 Offset: 0x1EDDEC0 VA: 0x1EE1EC0
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	// RVA: 0x1EDF944 Offset: 0x1EDB944 VA: 0x1EDF944
	private void ImmediateDestroyDropdownList() { }

	// RVA: 0x1EE1F64 Offset: 0x1EDDF64 VA: 0x1EE1F64
	private void OnSelectItem(Toggle toggle) { }

	// RVA: 0x1EE2098 Offset: 0x1EDE098 VA: 0x1EE2098
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Serializable]
public class FontData : ISerializationCallbackReceiver // TypeDefIndex: 7253
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("font")]
	private Font m_Font; // 0x10
	[SerializeField]
	[FormerlySerializedAs("fontSize")]
	private int m_FontSize; // 0x18
	[SerializeField]
	[FormerlySerializedAs("fontStyle")]
	private FontStyle m_FontStyle; // 0x1C
	[SerializeField]
	private bool m_BestFit; // 0x20
	[SerializeField]
	private int m_MinSize; // 0x24
	[SerializeField]
	private int m_MaxSize; // 0x28
	[SerializeField]
	[FormerlySerializedAs("alignment")]
	private TextAnchor m_Alignment; // 0x2C
	[SerializeField]
	private bool m_AlignByGeometry; // 0x30
	[SerializeField]
	[FormerlySerializedAs("richText")]
	private bool m_RichText; // 0x31
	[SerializeField]
	private HorizontalWrapMode m_HorizontalOverflow; // 0x34
	[SerializeField]
	private VerticalWrapMode m_VerticalOverflow; // 0x38
	[SerializeField]
	private float m_LineSpacing; // 0x3C

	// Properties
	public static FontData defaultFontData { get; }
	public Font font { get; set; }
	public int fontSize { get; set; }
	public FontStyle fontStyle { get; set; }
	public bool bestFit { get; set; }
	public int minSize { get; set; }
	public int maxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public bool richText { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }

	// Methods

	// RVA: 0x1EE2420 Offset: 0x1EDE420 VA: 0x1EE2420
	public static FontData get_defaultFontData() { }

	// RVA: 0x1EE24B8 Offset: 0x1EDE4B8 VA: 0x1EE24B8
	public Font get_font() { }

	// RVA: 0x1EE24C0 Offset: 0x1EDE4C0 VA: 0x1EE24C0
	public void set_font(Font value) { }

	// RVA: 0x1EE24C8 Offset: 0x1EDE4C8 VA: 0x1EE24C8
	public int get_fontSize() { }

	// RVA: 0x1EE24D0 Offset: 0x1EDE4D0 VA: 0x1EE24D0
	public void set_fontSize(int value) { }

	// RVA: 0x1EE24D8 Offset: 0x1EDE4D8 VA: 0x1EE24D8
	public FontStyle get_fontStyle() { }

	// RVA: 0x1EE24E0 Offset: 0x1EDE4E0 VA: 0x1EE24E0
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x1EE24E8 Offset: 0x1EDE4E8 VA: 0x1EE24E8
	public bool get_bestFit() { }

	// RVA: 0x1EE24F0 Offset: 0x1EDE4F0 VA: 0x1EE24F0
	public void set_bestFit(bool value) { }

	// RVA: 0x1EE24F8 Offset: 0x1EDE4F8 VA: 0x1EE24F8
	public int get_minSize() { }

	// RVA: 0x1EE2500 Offset: 0x1EDE500 VA: 0x1EE2500
	public void set_minSize(int value) { }

	// RVA: 0x1EE2508 Offset: 0x1EDE508 VA: 0x1EE2508
	public int get_maxSize() { }

	// RVA: 0x1EE2510 Offset: 0x1EDE510 VA: 0x1EE2510
	public void set_maxSize(int value) { }

	// RVA: 0x1EE2518 Offset: 0x1EDE518 VA: 0x1EE2518
	public TextAnchor get_alignment() { }

	// RVA: 0x1EE2520 Offset: 0x1EDE520 VA: 0x1EE2520
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x1EE2528 Offset: 0x1EDE528 VA: 0x1EE2528
	public bool get_alignByGeometry() { }

	// RVA: 0x1EE2530 Offset: 0x1EDE530 VA: 0x1EE2530
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x1EE2538 Offset: 0x1EDE538 VA: 0x1EE2538
	public bool get_richText() { }

	// RVA: 0x1EE2540 Offset: 0x1EDE540 VA: 0x1EE2540
	public void set_richText(bool value) { }

	// RVA: 0x1EE2548 Offset: 0x1EDE548 VA: 0x1EE2548
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x1EE2550 Offset: 0x1EDE550 VA: 0x1EE2550
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x1EE2558 Offset: 0x1EDE558 VA: 0x1EE2558
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x1EE2560 Offset: 0x1EDE560 VA: 0x1EE2560
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x1EE2568 Offset: 0x1EDE568 VA: 0x1EE2568
	public float get_lineSpacing() { }

	// RVA: 0x1EE2570 Offset: 0x1EDE570 VA: 0x1EE2570
	public void set_lineSpacing(float value) { }

	// RVA: 0x1EE2578 Offset: 0x1EDE578 VA: 0x1EE2578 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x1EE257C Offset: 0x1EDE57C VA: 0x1EE257C Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: 0x1EE24B0 Offset: 0x1EDE4B0 VA: 0x1EE24B0
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
public static class FontUpdateTracker // TypeDefIndex: 7254
{
	// Fields
	private static Dictionary<Font, HashSet<Text>> m_Tracked; // 0x0

	// Methods

	// RVA: 0x1EE25BC Offset: 0x1EDE5BC VA: 0x1EE25BC
	public static void TrackText(Text t) { }

	// RVA: 0x1EE2804 Offset: 0x1EDE804 VA: 0x1EE2804
	private static void RebuildForFont(Font f) { }

	// RVA: 0x1EE2A20 Offset: 0x1EDEA20 VA: 0x1EE2A20
	public static void UntrackText(Text t) { }

	// RVA: 0x1EE2C28 Offset: 0x1EDEC28 VA: 0x1EE2C28
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[DisallowMultipleComponent]
[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 7255
{
	// Fields
	protected static Material s_DefaultUI; // 0x0
	protected static Texture2D s_WhiteTexture; // 0x8
	[FormerlySerializedAs("m_Mat")]
	[SerializeField]
	protected Material m_Material; // 0x20
	[SerializeField]
	private Color m_Color; // 0x28
	protected bool m_SkipLayoutUpdate; // 0x38
	protected bool m_SkipMaterialUpdate; // 0x39
	[SerializeField]
	private bool m_RaycastTarget; // 0x3A
	private bool m_RaycastTargetCache; // 0x3B
	[SerializeField]
	private Vector4 m_RaycastPadding; // 0x3C
	private RectTransform m_RectTransform; // 0x50
	private CanvasRenderer m_CanvasRenderer; // 0x58
	private Canvas m_Canvas; // 0x60
	private bool m_VertsDirty; // 0x68
	private bool m_MaterialDirty; // 0x69
	protected UnityAction m_OnDirtyLayoutCallback; // 0x70
	protected UnityAction m_OnDirtyVertsCallback; // 0x78
	protected UnityAction m_OnDirtyMaterialCallback; // 0x80
	protected static Mesh s_Mesh; // 0x10
	private static readonly VertexHelper s_VertexHelper; // 0x18
	protected Mesh m_CachedMesh; // 0x88
	protected Vector2[] m_CachedUvs; // 0x90
	private readonly TweenRunner<ColorTween> m_ColorTweenRunner; // 0x98
	[CompilerGenerated]
	private bool <useLegacyMeshGeneration>k__BackingField; // 0xA0

	// Properties
	public static Material defaultGraphicMaterial { get; }
	public virtual Color color { get; set; }
	public virtual bool raycastTarget { get; set; }
	public Vector4 raycastPadding { get; set; }
	protected bool useLegacyMeshGeneration { get; set; }
	public int depth { get; }
	public RectTransform rectTransform { get; }
	public Canvas canvas { get; }
	public CanvasRenderer canvasRenderer { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Material material { get; set; }
	public virtual Material materialForRendering { get; }
	public virtual Texture mainTexture { get; }
	protected static Mesh workerMesh { get; }

	// Methods

	// RVA: 0x1EE2CC0 Offset: 0x1EDECC0 VA: 0x1EE2CC0
	public static Material get_defaultGraphicMaterial() { }

	// RVA: 0x1EE2DAC Offset: 0x1EDEDAC VA: 0x1EE2DAC Slot: 22
	public virtual Color get_color() { }

	// RVA: 0x1EE2DB8 Offset: 0x1EDEDB8 VA: 0x1EE2DB8 Slot: 23
	public virtual void set_color(Color value) { }

	// RVA: 0x1EE2DF0 Offset: 0x1EDEDF0 VA: 0x1EE2DF0 Slot: 24
	public virtual bool get_raycastTarget() { }

	// RVA: 0x1EE2DF8 Offset: 0x1EDEDF8 VA: 0x1EE2DF8 Slot: 25
	public virtual void set_raycastTarget(bool value) { }

	// RVA: 0x1EE32B0 Offset: 0x1EDF2B0 VA: 0x1EE32B0
	public Vector4 get_raycastPadding() { }

	// RVA: 0x1EE32BC Offset: 0x1EDF2BC VA: 0x1EE32BC
	public void set_raycastPadding(Vector4 value) { }

	[CompilerGenerated]
	// RVA: 0x1EE32C8 Offset: 0x1EDF2C8 VA: 0x1EE32C8
	protected bool get_useLegacyMeshGeneration() { }

	[CompilerGenerated]
	// RVA: 0x1EE32D0 Offset: 0x1EDF2D0 VA: 0x1EE32D0
	protected void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x1EE32D8 Offset: 0x1EDF2D8 VA: 0x1EE32D8
	protected void .ctor() { }

	// RVA: 0x1EE33A4 Offset: 0x1EDF3A4 VA: 0x1EE33A4 Slot: 26
	public virtual void SetAllDirty() { }

	// RVA: 0x1EE34EC Offset: 0x1EDF4EC VA: 0x1EE34EC Slot: 27
	public virtual void SetLayoutDirty() { }

	// RVA: 0x1EE35F8 Offset: 0x1EDF5F8 VA: 0x1EE35F8 Slot: 28
	public virtual void SetVerticesDirty() { }

	// RVA: 0x1EE368C Offset: 0x1EDF68C VA: 0x1EE368C Slot: 29
	public virtual void SetMaterialDirty() { }

	// RVA: 0x1EE3414 Offset: 0x1EDF414 VA: 0x1EE3414
	public void SetRaycastDirty() { }

	// RVA: 0x1EE3720 Offset: 0x1EDF720 VA: 0x1EE3720 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1EE37CC Offset: 0x1EDF7CC VA: 0x1EE37CC Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x1EE3A18 Offset: 0x1EDFA18 VA: 0x1EE3A18 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1EE3E50 Offset: 0x1EDFE50 VA: 0x1EE3E50
	public int get_depth() { }

	// RVA: 0x1EE358C Offset: 0x1EDF58C VA: 0x1EE358C Slot: 30
	public RectTransform get_rectTransform() { }

	// RVA: 0x1EE2ED4 Offset: 0x1EDEED4 VA: 0x1EE2ED4
	public Canvas get_canvas() { }

	// RVA: 0x1EE3AD8 Offset: 0x1EDFAD8 VA: 0x1EE3AD8
	private void CacheCanvas() { }

	// RVA: 0x1EE3E6C Offset: 0x1EDFE6C VA: 0x1EE3E6C
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x1EE3F20 Offset: 0x1EDFF20 VA: 0x1EE3F20 Slot: 31
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x1EE3F6C Offset: 0x1EDFF6C VA: 0x1EE3F6C Slot: 32
	public virtual Material get_material() { }

	// RVA: 0x1EE3FF4 Offset: 0x1EDFFF4 VA: 0x1EE3FF4 Slot: 33
	public virtual void set_material(Material value) { }

	// RVA: 0x1EE409C Offset: 0x1EE009C VA: 0x1EE409C Slot: 34
	public virtual Material get_materialForRendering() { }

	// RVA: 0x1EE4260 Offset: 0x1EE0260 VA: 0x1EE4260 Slot: 35
	public virtual Texture get_mainTexture() { }

	// RVA: 0x1EE42B8 Offset: 0x1EE02B8 VA: 0x1EE42B8 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1EE43F0 Offset: 0x1EE03F0 VA: 0x1EE43F0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1EE46B8 Offset: 0x1EE06B8 VA: 0x1EE46B8 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1EE47CC Offset: 0x1EE07CC VA: 0x1EE47CC Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1EE4910 Offset: 0x1EE0910 VA: 0x1EE4910 Slot: 36
	public virtual void OnCullingChanged() { }

	// RVA: 0x1EE499C Offset: 0x1EE099C VA: 0x1EE499C Slot: 37
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1EE4A80 Offset: 0x1EE0A80 VA: 0x1EE4A80 Slot: 38
	public virtual void LayoutComplete() { }

	// RVA: 0x1EE4A84 Offset: 0x1EE0A84 VA: 0x1EE4A84 Slot: 39
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1EE4A88 Offset: 0x1EE0A88 VA: 0x1EE4A88 Slot: 40
	protected virtual void UpdateMaterial() { }

	// RVA: 0x1EE4B40 Offset: 0x1EE0B40 VA: 0x1EE4B40 Slot: 41
	protected virtual void UpdateGeometry() { }

	// RVA: 0x1EE4EAC Offset: 0x1EE0EAC VA: 0x1EE4EAC
	private void DoMeshGeneration() { }

	// RVA: 0x1EE4B50 Offset: 0x1EE0B50 VA: 0x1EE4B50
	private void DoLegacyMeshGeneration() { }

	// RVA: 0x1EE523C Offset: 0x1EE123C VA: 0x1EE523C
	protected static Mesh get_workerMesh() { }

	[EditorBrowsable(1)]
	[Obsolete("Use OnPopulateMesh instead.", True)]
	// RVA: 0x1EE536C Offset: 0x1EE136C VA: 0x1EE536C Slot: 42
	protected virtual void OnFillVBO(List<UIVertex> vbo) { }

	[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", False)]
	// RVA: 0x1EE5370 Offset: 0x1EE1370 VA: 0x1EE5370 Slot: 43
	protected virtual void OnPopulateMesh(Mesh m) { }

	// RVA: 0x1EE5408 Offset: 0x1EE1408 VA: 0x1EE5408 Slot: 44
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1EE5690 Offset: 0x1EE1690 VA: 0x1EE5690 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1EE56A0 Offset: 0x1EE16A0 VA: 0x1EE56A0 Slot: 45
	public virtual void SetNativeSize() { }

	// RVA: 0x1EE56A4 Offset: 0x1EE16A4 VA: 0x1EE56A4 Slot: 46
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1EE56AC Offset: 0x1EE16AC VA: 0x1EE56AC
	protected bool Raycast(Vector2 sp, Camera eventCamera, bool ignoreMasks) { }

	// RVA: 0x1EE5C4C Offset: 0x1EE1C4C VA: 0x1EE5C4C
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x1EE5564 Offset: 0x1EE1564 VA: 0x1EE5564
	public Rect GetPixelAdjustedRect() { }

	// RVA: 0x1EE5D8C Offset: 0x1EE1D8C VA: 0x1EE5D8C Slot: 47
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x1EE5DA0 Offset: 0x1EE1DA0 VA: 0x1EE5DA0 Slot: 48
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x1EE6014 Offset: 0x1EE2014 VA: 0x1EE6014
	private static Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x1EE6028 Offset: 0x1EE2028 VA: 0x1EE6028 Slot: 49
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x1EE60C4 Offset: 0x1EE20C4 VA: 0x1EE60C4
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x1EE6154 Offset: 0x1EE2154 VA: 0x1EE6154
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x1EE61E4 Offset: 0x1EE21E4 VA: 0x1EE61E4
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x1EE6274 Offset: 0x1EE2274 VA: 0x1EE6274
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x1EE6304 Offset: 0x1EE2304 VA: 0x1EE6304
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x1EE6394 Offset: 0x1EE2394 VA: 0x1EE6394
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x1EE6424 Offset: 0x1EE2424 VA: 0x1EE6424
	private static void .cctor() { }

	// RVA: 0x1EE64C8 Offset: 0x1EE24C8 VA: 0x1EE64C8 Slot: 18
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: 
public enum GraphicRaycaster.BlockingObjects // TypeDefIndex: 7256
{
	// Fields
	public int value__; // 0x0
	public const GraphicRaycaster.BlockingObjects None = 0;
	public const GraphicRaycaster.BlockingObjects TwoD = 1;
	public const GraphicRaycaster.BlockingObjects ThreeD = 2;
	public const GraphicRaycaster.BlockingObjects All = 3;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GraphicRaycaster.<>c // TypeDefIndex: 7257
{
	// Fields
	public static readonly GraphicRaycaster.<>c <>9; // 0x0
	public static Comparison<Graphic> <>9__27_0; // 0x8

	// Methods

	// RVA: 0x1EE7900 Offset: 0x1EE3900 VA: 0x1EE7900
	private static void .cctor() { }

	// RVA: 0x1EE7968 Offset: 0x1EE3968 VA: 0x1EE7968
	public void .ctor() { }

	// RVA: 0x1EE7970 Offset: 0x1EE3970 VA: 0x1EE7970
	internal int <Raycast>b__27_0(Graphic g1, Graphic g2) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Event/Graphic Raycaster")]
[RequireComponent(typeof(Canvas))]
public class GraphicRaycaster : BaseRaycaster // TypeDefIndex: 7258
{
	// Fields
	protected const int kNoEventMaskSet = -1;
	[FormerlySerializedAs("ignoreReversedGraphics")]
	[SerializeField]
	private bool m_IgnoreReversedGraphics; // 0x28
	[FormerlySerializedAs("blockingObjects")]
	[SerializeField]
	private GraphicRaycaster.BlockingObjects m_BlockingObjects; // 0x2C
	[SerializeField]
	protected LayerMask m_BlockingMask; // 0x30
	private Canvas m_Canvas; // 0x38
	private List<Graphic> m_RaycastResults; // 0x40
	private static readonly List<Graphic> s_SortedGraphics; // 0x0

	// Properties
	public override int sortOrderPriority { get; }
	public override int renderOrderPriority { get; }
	public bool ignoreReversedGraphics { get; set; }
	public GraphicRaycaster.BlockingObjects blockingObjects { get; set; }
	public LayerMask blockingMask { get; set; }
	private Canvas canvas { get; }
	public override Camera eventCamera { get; }

	// Methods

	// RVA: 0x1EE64D0 Offset: 0x1EE24D0 VA: 0x1EE64D0 Slot: 20
	public override int get_sortOrderPriority() { }

	// RVA: 0x1EE65B8 Offset: 0x1EE25B8 VA: 0x1EE65B8 Slot: 21
	public override int get_renderOrderPriority() { }

	// RVA: 0x1EE660C Offset: 0x1EE260C VA: 0x1EE660C
	public bool get_ignoreReversedGraphics() { }

	// RVA: 0x1EE6614 Offset: 0x1EE2614 VA: 0x1EE6614
	public void set_ignoreReversedGraphics(bool value) { }

	// RVA: 0x1EE661C Offset: 0x1EE261C VA: 0x1EE661C
	public GraphicRaycaster.BlockingObjects get_blockingObjects() { }

	// RVA: 0x1EE6624 Offset: 0x1EE2624 VA: 0x1EE6624
	public void set_blockingObjects(GraphicRaycaster.BlockingObjects value) { }

	// RVA: 0x1EE662C Offset: 0x1EE262C VA: 0x1EE662C
	public LayerMask get_blockingMask() { }

	// RVA: 0x1EE6634 Offset: 0x1EE2634 VA: 0x1EE6634
	public void set_blockingMask(LayerMask value) { }

	// RVA: 0x1EE663C Offset: 0x1EE263C VA: 0x1EE663C
	protected void .ctor() { }

	// RVA: 0x1EE6518 Offset: 0x1EE2518 VA: 0x1EE6518
	private Canvas get_canvas() { }

	// RVA: 0x1EE66E0 Offset: 0x1EE26E0 VA: 0x1EE66E0 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }

	// RVA: 0x1EE77A0 Offset: 0x1EE37A0 VA: 0x1EE77A0 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x1EE7200 Offset: 0x1EE3200 VA: 0x1EE7200
	private static void Raycast(Canvas canvas, Camera eventCamera, Vector2 pointerPosition, IList<Graphic> foundGraphics, List<Graphic> results) { }

	// RVA: 0x1EE7868 Offset: 0x1EE3868 VA: 0x1EE7868
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
public class GraphicRegistry // TypeDefIndex: 7259
{
	// Fields
	private static GraphicRegistry s_Instance; // 0x0
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_Graphics; // 0x10
	private readonly Dictionary<Canvas, IndexedSet<Graphic>> m_RaycastableGraphics; // 0x18
	private static readonly List<Graphic> s_EmptyList; // 0x8

	// Properties
	public static GraphicRegistry instance { get; }

	// Methods

	// RVA: 0x1EE79BC Offset: 0x1EE39BC VA: 0x1EE79BC
	protected void .ctor() { }

	// RVA: 0x1EE7B7C Offset: 0x1EE3B7C VA: 0x1EE7B7C
	public static GraphicRegistry get_instance() { }

	// RVA: 0x1EE3C64 Offset: 0x1EDFC64 VA: 0x1EE3C64
	public static void RegisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1EE30C4 Offset: 0x1EDF0C4 VA: 0x1EE30C4
	public static void RegisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1EE3874 Offset: 0x1EDF874 VA: 0x1EE3874
	public static void UnregisterGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1EE2F48 Offset: 0x1EDEF48 VA: 0x1EE2F48
	public static void UnregisterRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1EE4538 Offset: 0x1EE0538 VA: 0x1EE4538
	public static void DisableGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1EE7C2C Offset: 0x1EE3C2C VA: 0x1EE7C2C
	public static void DisableRaycastGraphicForCanvas(Canvas c, Graphic graphic) { }

	// RVA: 0x1EE7DAC Offset: 0x1EE3DAC VA: 0x1EE7DAC
	public static IList<Graphic> GetGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x1EE7144 Offset: 0x1EE3144 VA: 0x1EE7144
	public static IList<Graphic> GetRaycastableGraphicsForCanvas(Canvas canvas) { }

	// RVA: 0x1EE7E68 Offset: 0x1EE3E68 VA: 0x1EE7E68
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Obsolete("Not supported anymore")]
internal interface IGraphicEnabledDisabled // TypeDefIndex: 7260
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSiblingGraphicEnabledDisabled();
}

// Namespace: UnityEngine.UI
[EditorBrowsable(1)]
[Obsolete("Not supported anymore.", True)]
public interface IMask // TypeDefIndex: 7261
{
	// Properties
	public abstract RectTransform rectTransform { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Enabled();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract RectTransform get_rectTransform();
}

// Namespace: UnityEngine.UI
public interface IMaskable // TypeDefIndex: 7262
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RecalculateMasking();
}

// Namespace: 
public enum Image.Type // TypeDefIndex: 7263
{
	// Fields
	public int value__; // 0x0
	public const Image.Type Simple = 0;
	public const Image.Type Sliced = 1;
	public const Image.Type Tiled = 2;
	public const Image.Type Filled = 3;
}

// Namespace: 
public enum Image.FillMethod // TypeDefIndex: 7264
{
	// Fields
	public int value__; // 0x0
	public const Image.FillMethod Horizontal = 0;
	public const Image.FillMethod Vertical = 1;
	public const Image.FillMethod Radial90 = 2;
	public const Image.FillMethod Radial180 = 3;
	public const Image.FillMethod Radial360 = 4;
}

// Namespace: 
public enum Image.OriginHorizontal // TypeDefIndex: 7265
{
	// Fields
	public int value__; // 0x0
	public const Image.OriginHorizontal Left = 0;
	public const Image.OriginHorizontal Right = 1;
}

// Namespace: 
public enum Image.OriginVertical // TypeDefIndex: 7266
{
	// Fields
	public int value__; // 0x0
	public const Image.OriginVertical Bottom = 0;
	public const Image.OriginVertical Top = 1;
}

// Namespace: 
public enum Image.Origin90 // TypeDefIndex: 7267
{
	// Fields
	public int value__; // 0x0
	public const Image.Origin90 BottomLeft = 0;
	public const Image.Origin90 TopLeft = 1;
	public const Image.Origin90 TopRight = 2;
	public const Image.Origin90 BottomRight = 3;
}

// Namespace: 
public enum Image.Origin180 // TypeDefIndex: 7268
{
	// Fields
	public int value__; // 0x0
	public const Image.Origin180 Bottom = 0;
	public const Image.Origin180 Left = 1;
	public const Image.Origin180 Top = 2;
	public const Image.Origin180 Right = 3;
}

// Namespace: 
public enum Image.Origin360 // TypeDefIndex: 7269
{
	// Fields
	public int value__; // 0x0
	public const Image.Origin360 Bottom = 0;
	public const Image.Origin360 Right = 1;
	public const Image.Origin360 Top = 2;
	public const Image.Origin360 Left = 3;
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(CanvasRenderer))]
[AddComponentMenu("UI/Image", 11)]
public class Image : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter // TypeDefIndex: 7270
{
	// Fields
	protected static Material s_ETC1DefaultUI; // 0x0
	[FormerlySerializedAs("m_Frame")]
	[SerializeField]
	private Sprite m_Sprite; // 0xD8
	private Sprite m_OverrideSprite; // 0xE0
	[SerializeField]
	private Image.Type m_Type; // 0xE8
	[SerializeField]
	private bool m_PreserveAspect; // 0xEC
	[SerializeField]
	private bool m_FillCenter; // 0xED
	[SerializeField]
	private Image.FillMethod m_FillMethod; // 0xF0
	[Range(0, 1)]
	[SerializeField]
	private float m_FillAmount; // 0xF4
	[SerializeField]
	private bool m_FillClockwise; // 0xF8
	[SerializeField]
	private int m_FillOrigin; // 0xFC
	private float m_AlphaHitTestMinimumThreshold; // 0x100
	private bool m_Tracked; // 0x104
	[SerializeField]
	private bool m_UseSpriteMesh; // 0x105
	[SerializeField]
	private float m_PixelsPerUnitMultiplier; // 0x108
	private float m_CachedReferencePixelsPerUnit; // 0x10C
	private static readonly Vector2[] s_VertScratch; // 0x8
	private static readonly Vector2[] s_UVScratch; // 0x10
	private static readonly Vector3[] s_Xy; // 0x18
	private static readonly Vector3[] s_Uv; // 0x20
	private static List<Image> m_TrackedTexturelessImages; // 0x28
	private static bool s_Initialized; // 0x30

	// Properties
	public Sprite sprite { get; set; }
	public Sprite overrideSprite { get; set; }
	private Sprite activeSprite { get; }
	public Image.Type type { get; set; }
	public bool preserveAspect { get; set; }
	public bool fillCenter { get; set; }
	public Image.FillMethod fillMethod { get; set; }
	public float fillAmount { get; set; }
	public bool fillClockwise { get; set; }
	public int fillOrigin { get; set; }
	[Obsolete("eventAlphaThreshold has been deprecated. Use eventMinimumAlphaThreshold instead (UnityUpgradable) -> alphaHitTestMinimumThreshold")]
	public float eventAlphaThreshold { get; set; }
	public float alphaHitTestMinimumThreshold { get; set; }
	public bool useSpriteMesh { get; set; }
	public static Material defaultETC1GraphicMaterial { get; }
	public override Texture mainTexture { get; }
	public bool hasBorder { get; }
	public float pixelsPerUnitMultiplier { get; set; }
	public float pixelsPerUnit { get; }
	protected float multipliedPixelsPerUnit { get; }
	public override Material material { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x1EE7EF8 Offset: 0x1EE3EF8 VA: 0x1EE7EF8
	public Sprite get_sprite() { }

	// RVA: 0x1EDAFB4 Offset: 0x1ED6FB4 VA: 0x1EDAFB4
	public void set_sprite(Sprite value) { }

	// RVA: 0x1EE807C Offset: 0x1EE407C VA: 0x1EE807C
	public void DisableSpriteOptimizations() { }

	// RVA: 0x1EE8084 Offset: 0x1EE4084 VA: 0x1EE8084
	public Sprite get_overrideSprite() { }

	// RVA: 0x1EE8100 Offset: 0x1EE4100 VA: 0x1EE8100
	public void set_overrideSprite(Sprite value) { }

	// RVA: 0x1EE8088 Offset: 0x1EE4088 VA: 0x1EE8088
	private Sprite get_activeSprite() { }

	// RVA: 0x1EE8188 Offset: 0x1EE4188 VA: 0x1EE8188
	public Image.Type get_type() { }

	// RVA: 0x1EDB280 Offset: 0x1ED7280 VA: 0x1EDB280
	public void set_type(Image.Type value) { }

	// RVA: 0x1EE8190 Offset: 0x1EE4190 VA: 0x1EE8190
	public bool get_preserveAspect() { }

	// RVA: 0x1EE8198 Offset: 0x1EE4198 VA: 0x1EE8198
	public void set_preserveAspect(bool value) { }

	// RVA: 0x1EE8218 Offset: 0x1EE4218 VA: 0x1EE8218
	public bool get_fillCenter() { }

	// RVA: 0x1EE8220 Offset: 0x1EE4220 VA: 0x1EE8220
	public void set_fillCenter(bool value) { }

	// RVA: 0x1EE82A0 Offset: 0x1EE42A0 VA: 0x1EE82A0
	public Image.FillMethod get_fillMethod() { }

	// RVA: 0x1EE82A8 Offset: 0x1EE42A8 VA: 0x1EE82A8
	public void set_fillMethod(Image.FillMethod value) { }

	// RVA: 0x1EE8320 Offset: 0x1EE4320 VA: 0x1EE8320
	public float get_fillAmount() { }

	// RVA: 0x1EE8328 Offset: 0x1EE4328 VA: 0x1EE8328
	public void set_fillAmount(float value) { }

	// RVA: 0x1EE83BC Offset: 0x1EE43BC VA: 0x1EE83BC
	public bool get_fillClockwise() { }

	// RVA: 0x1EE83C4 Offset: 0x1EE43C4 VA: 0x1EE83C4
	public void set_fillClockwise(bool value) { }

	// RVA: 0x1EE8444 Offset: 0x1EE4444 VA: 0x1EE8444
	public int get_fillOrigin() { }

	// RVA: 0x1EE844C Offset: 0x1EE444C VA: 0x1EE844C
	public void set_fillOrigin(int value) { }

	// RVA: 0x1EE84CC Offset: 0x1EE44CC VA: 0x1EE84CC
	public float get_eventAlphaThreshold() { }

	// RVA: 0x1EE84DC Offset: 0x1EE44DC VA: 0x1EE84DC
	public void set_eventAlphaThreshold(float value) { }

	// RVA: 0x1EE8628 Offset: 0x1EE4628 VA: 0x1EE8628
	public float get_alphaHitTestMinimumThreshold() { }

	// RVA: 0x1EE84E8 Offset: 0x1EE44E8 VA: 0x1EE84E8
	public void set_alphaHitTestMinimumThreshold(float value) { }

	// RVA: 0x1EE8630 Offset: 0x1EE4630 VA: 0x1EE8630
	public bool get_useSpriteMesh() { }

	// RVA: 0x1EE8638 Offset: 0x1EE4638 VA: 0x1EE8638
	public void set_useSpriteMesh(bool value) { }

	// RVA: 0x1EE86B8 Offset: 0x1EE46B8 VA: 0x1EE86B8
	protected void .ctor() { }

	// RVA: 0x1EE86F8 Offset: 0x1EE46F8 VA: 0x1EE86F8
	public static Material get_defaultETC1GraphicMaterial() { }

	// RVA: 0x1EE87E4 Offset: 0x1EE47E4 VA: 0x1EE87E4 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x1EE895C Offset: 0x1EE495C VA: 0x1EE895C
	public bool get_hasBorder() { }

	// RVA: 0x1EE8A14 Offset: 0x1EE4A14 VA: 0x1EE8A14
	public float get_pixelsPerUnitMultiplier() { }

	// RVA: 0x1EE8A1C Offset: 0x1EE4A1C VA: 0x1EE8A1C
	public void set_pixelsPerUnitMultiplier(float value) { }

	// RVA: 0x1EE8A40 Offset: 0x1EE4A40 VA: 0x1EE8A40
	public float get_pixelsPerUnit() { }

	// RVA: 0x1EE8B34 Offset: 0x1EE4B34 VA: 0x1EE8B34
	protected float get_multipliedPixelsPerUnit() { }

	// RVA: 0x1EE8B50 Offset: 0x1EE4B50 VA: 0x1EE8B50 Slot: 32
	public override Material get_material() { }

	// RVA: 0x1EE8C7C Offset: 0x1EE4C7C VA: 0x1EE8C7C Slot: 33
	public override void set_material(Material value) { }

	// RVA: 0x1EE8C80 Offset: 0x1EE4C80 VA: 0x1EE8C80 Slot: 77
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x1EE8C84 Offset: 0x1EE4C84 VA: 0x1EE8C84 Slot: 78
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x1EE8CD8 Offset: 0x1EE4CD8 VA: 0x1EE8CD8
	private void PreserveSpriteAspectRatio(ref Rect rect, Vector2 spriteSize) { }

	// RVA: 0x1EE8D74 Offset: 0x1EE4D74 VA: 0x1EE8D74
	private Vector4 GetDrawingDimensions(bool shouldPreserveAspect) { }

	// RVA: 0x1EE912C Offset: 0x1EE512C VA: 0x1EE912C Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x1EE926C Offset: 0x1EE526C VA: 0x1EE926C Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x1EE7F90 Offset: 0x1EE3F90 VA: 0x1EE7F90
	private void TrackSprite() { }

	// RVA: 0x1EEB698 Offset: 0x1EE7698 VA: 0x1EEB698 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1EEB6B4 Offset: 0x1EE76B4 VA: 0x1EEB6B4 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1EEB7A8 Offset: 0x1EE77A8 VA: 0x1EEB7A8 Slot: 40
	protected override void UpdateMaterial() { }

	// RVA: 0x1EEB89C Offset: 0x1EE789C VA: 0x1EEB89C Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1EE93B4 Offset: 0x1EE53B4 VA: 0x1EE93B4
	private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x1EE9660 Offset: 0x1EE5660 VA: 0x1EE9660
	private void GenerateSprite(VertexHelper vh, bool lPreserveAspect) { }

	// RVA: 0x1EE9948 Offset: 0x1EE5948 VA: 0x1EE9948
	private void GenerateSlicedSprite(VertexHelper toFill) { }

	// RVA: 0x1EE9EFC Offset: 0x1EE5EFC VA: 0x1EE9EFC
	private void GenerateTiledSprite(VertexHelper toFill) { }

	// RVA: 0x1EEBC74 Offset: 0x1EE7C74 VA: 0x1EEBC74
	private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs) { }

	// RVA: 0x1EEBB28 Offset: 0x1EE7B28 VA: 0x1EEBB28
	private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax) { }

	// RVA: 0x1EEB9A4 Offset: 0x1EE79A4 VA: 0x1EEB9A4
	private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect) { }

	// RVA: 0x1EEAC50 Offset: 0x1EE6C50 VA: 0x1EEAC50
	private void GenerateFilledSprite(VertexHelper toFill, bool preserveAspect) { }

	// RVA: 0x1EEBD50 Offset: 0x1EE7D50 VA: 0x1EEBD50
	private static bool RadialCut(Vector3[] xy, Vector3[] uv, float fill, bool invert, int corner) { }

	// RVA: 0x1EEBE80 Offset: 0x1EE7E80 VA: 0x1EEBE80
	private static void RadialCut(Vector3[] xy, float cos, float sin, bool invert, int corner) { }

	// RVA: 0x1EEC270 Offset: 0x1EE8270 VA: 0x1EEC270 Slot: 79
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1EEC274 Offset: 0x1EE8274 VA: 0x1EEC274 Slot: 80
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1EEC278 Offset: 0x1EE8278 VA: 0x1EEC278 Slot: 81
	public virtual float get_minWidth() { }

	// RVA: 0x1EEC280 Offset: 0x1EE8280 VA: 0x1EEC280 Slot: 82
	public virtual float get_preferredWidth() { }

	// RVA: 0x1EEC348 Offset: 0x1EE8348 VA: 0x1EEC348 Slot: 83
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1EEC350 Offset: 0x1EE8350 VA: 0x1EEC350 Slot: 84
	public virtual float get_minHeight() { }

	// RVA: 0x1EEC358 Offset: 0x1EE8358 VA: 0x1EEC358 Slot: 85
	public virtual float get_preferredHeight() { }

	// RVA: 0x1EEC420 Offset: 0x1EE8420 VA: 0x1EEC420 Slot: 86
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1EEC428 Offset: 0x1EE8428 VA: 0x1EEC428 Slot: 87
	public virtual int get_layoutPriority() { }

	// RVA: 0x1EEC430 Offset: 0x1EE8430 VA: 0x1EEC430 Slot: 88
	public virtual bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera) { }

	// RVA: 0x1EEC7DC Offset: 0x1EE87DC VA: 0x1EEC7DC
	private Vector2 MapCoordinate(Vector2 local, Rect rect) { }

	// RVA: 0x1EECA6C Offset: 0x1EE8A6C VA: 0x1EECA6C
	private static void RebuildImage(SpriteAtlas spriteAtlas) { }

	// RVA: 0x1EEB538 Offset: 0x1EE7538 VA: 0x1EEB538
	private static void TrackImage(Image g) { }

	// RVA: 0x1EEB728 Offset: 0x1EE7728 VA: 0x1EEB728
	private static void UnTrackImage(Image g) { }

	// RVA: 0x1EECC0C Offset: 0x1EE8C0C VA: 0x1EECC0C Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1EECC44 Offset: 0x1EE8C44 VA: 0x1EECC44
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1EE7F00 Offset: 0x1EE3F00 VA: 0x1EE7F00
	private void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0() { }

	[CompilerGenerated]
	// RVA: 0x1EECDB0 Offset: 0x1EE8DB0 VA: 0x1EECDB0
	private bool <set_sprite>g__SpriteSupportsAlphaHitTest|11_1() { }
}

// Namespace: 
public enum InputField.ContentType // TypeDefIndex: 7271
{
	// Fields
	public int value__; // 0x0
	public const InputField.ContentType Standard = 0;
	public const InputField.ContentType Autocorrected = 1;
	public const InputField.ContentType IntegerNumber = 2;
	public const InputField.ContentType DecimalNumber = 3;
	public const InputField.ContentType Alphanumeric = 4;
	public const InputField.ContentType Name = 5;
	public const InputField.ContentType EmailAddress = 6;
	public const InputField.ContentType Password = 7;
	public const InputField.ContentType Pin = 8;
	public const InputField.ContentType Custom = 9;
}

// Namespace: 
public enum InputField.InputType // TypeDefIndex: 7272
{
	// Fields
	public int value__; // 0x0
	public const InputField.InputType Standard = 0;
	public const InputField.InputType AutoCorrect = 1;
	public const InputField.InputType Password = 2;
}

// Namespace: 
public enum InputField.CharacterValidation // TypeDefIndex: 7273
{
	// Fields
	public int value__; // 0x0
	public const InputField.CharacterValidation None = 0;
	public const InputField.CharacterValidation Integer = 1;
	public const InputField.CharacterValidation Decimal = 2;
	public const InputField.CharacterValidation Alphanumeric = 3;
	public const InputField.CharacterValidation Name = 4;
	public const InputField.CharacterValidation EmailAddress = 5;
}

// Namespace: 
public enum InputField.LineType // TypeDefIndex: 7274
{
	// Fields
	public int value__; // 0x0
	public const InputField.LineType SingleLine = 0;
	public const InputField.LineType MultiLineSubmit = 1;
	public const InputField.LineType MultiLineNewline = 2;
}

// Namespace: 
public sealed class InputField.OnValidateInput : MulticastDelegate // TypeDefIndex: 7275
{
	// Methods

	// RVA: 0x1EF202C Offset: 0x1EEE02C VA: 0x1EF202C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EFAEE8 Offset: 0x1EF6EE8 VA: 0x1EFAEE8 Slot: 12
	public virtual char Invoke(string text, int charIndex, char addedChar) { }

	// RVA: 0x1EFAEFC Offset: 0x1EF6EFC VA: 0x1EFAEFC Slot: 13
	public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object) { }

	// RVA: 0x1EFAF80 Offset: 0x1EF6F80 VA: 0x1EFAF80 Slot: 14
	public virtual char EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[Serializable]
public class InputField.SubmitEvent : UnityEvent<string> // TypeDefIndex: 7276
{
	// Methods

	// RVA: 0x1EF1904 Offset: 0x1EED904 VA: 0x1EF1904
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class InputField.EndEditEvent : UnityEvent<string> // TypeDefIndex: 7277
{
	// Methods

	// RVA: 0x1EF194C Offset: 0x1EED94C VA: 0x1EF194C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class InputField.OnChangeEvent : UnityEvent<string> // TypeDefIndex: 7278
{
	// Methods

	// RVA: 0x1EF1994 Offset: 0x1EED994 VA: 0x1EF1994
	public void .ctor() { }
}

// Namespace: 
protected enum InputField.EditState // TypeDefIndex: 7279
{
	// Fields
	public int value__; // 0x0
	public const InputField.EditState Continue = 0;
	public const InputField.EditState Finish = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class InputField.<CaretBlink>d__172 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7280
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public InputField <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1EF3C60 Offset: 0x1EEFC60 VA: 0x1EF3C60
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1EFAFA8 Offset: 0x1EF6FA8 VA: 0x1EFAFA8 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1EFAFAC Offset: 0x1EF6FAC VA: 0x1EFAFAC Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1EFB0D0 Offset: 0x1EF70D0 VA: 0x1EFB0D0 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1EFB0D8 Offset: 0x1EF70D8 VA: 0x1EFB0D8 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1EFB110 Offset: 0x1EF7110 VA: 0x1EFB110 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InputField.<MouseDragOutsideRect>d__196 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7281
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public PointerEventData eventData; // 0x20
	public InputField <>4__this; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1EF6690 Offset: 0x1EF2690 VA: 0x1EF6690
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1EFB118 Offset: 0x1EF7118 VA: 0x1EFB118 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1EFB11C Offset: 0x1EF711C VA: 0x1EFB11C Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1EFB3A4 Offset: 0x1EF73A4 VA: 0x1EFB3A4 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1EFB3AC Offset: 0x1EF73AC VA: 0x1EFB3AC Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1EFB3E4 Offset: 0x1EF73E4 VA: 0x1EFB3E4 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Legacy/Input Field", 103)]
public class InputField : Selectable, IUpdateSelectedHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement // TypeDefIndex: 7282
{
	// Fields
	protected TouchScreenKeyboard m_Keyboard; // 0x100
	private static readonly char[] kSeparators; // 0x0
	private static bool s_IsQuestDeviceEvaluated; // 0x8
	private static bool s_IsQuestDevice; // 0x9
	[SerializeField]
	[FormerlySerializedAs("text")]
	protected Text m_TextComponent; // 0x108
	[SerializeField]
	protected Graphic m_Placeholder; // 0x110
	[SerializeField]
	private InputField.ContentType m_ContentType; // 0x118
	[FormerlySerializedAs("inputType")]
	[SerializeField]
	private InputField.InputType m_InputType; // 0x11C
	[FormerlySerializedAs("asteriskChar")]
	[SerializeField]
	private char m_AsteriskChar; // 0x120
	[FormerlySerializedAs("keyboardType")]
	[SerializeField]
	private TouchScreenKeyboardType m_KeyboardType; // 0x124
	[SerializeField]
	private InputField.LineType m_LineType; // 0x128
	[FormerlySerializedAs("hideMobileInput")]
	[SerializeField]
	private bool m_HideMobileInput; // 0x12C
	[FormerlySerializedAs("validation")]
	[SerializeField]
	private InputField.CharacterValidation m_CharacterValidation; // 0x130
	[FormerlySerializedAs("characterLimit")]
	[SerializeField]
	private int m_CharacterLimit; // 0x134
	[FormerlySerializedAs("onSubmit")]
	[FormerlySerializedAs("m_OnSubmit")]
	[FormerlySerializedAs("m_EndEdit")]
	[FormerlySerializedAs("m_OnEndEdit")]
	[SerializeField]
	private InputField.SubmitEvent m_OnSubmit; // 0x138
	[SerializeField]
	private InputField.EndEditEvent m_OnDidEndEdit; // 0x140
	[FormerlySerializedAs("onValueChange")]
	[FormerlySerializedAs("m_OnValueChange")]
	[SerializeField]
	private InputField.OnChangeEvent m_OnValueChanged; // 0x148
	[FormerlySerializedAs("onValidateInput")]
	[SerializeField]
	private InputField.OnValidateInput m_OnValidateInput; // 0x150
	[FormerlySerializedAs("selectionColor")]
	[SerializeField]
	private Color m_CaretColor; // 0x158
	[SerializeField]
	private bool m_CustomCaretColor; // 0x168
	[SerializeField]
	private Color m_SelectionColor; // 0x16C
	[SerializeField]
	[Multiline]
	[FormerlySerializedAs("mValue")]
	protected string m_Text; // 0x180
	[SerializeField]
	[Range(0, 4)]
	private float m_CaretBlinkRate; // 0x188
	[SerializeField]
	[Range(1, 5)]
	private int m_CaretWidth; // 0x18C
	[SerializeField]
	private bool m_ReadOnly; // 0x190
	[SerializeField]
	private bool m_ShouldActivateOnSelect; // 0x191
	protected int m_CaretPosition; // 0x194
	protected int m_CaretSelectPosition; // 0x198
	private RectTransform caretRectTrans; // 0x1A0
	protected UIVertex[] m_CursorVerts; // 0x1A8
	private TextGenerator m_InputTextCache; // 0x1B0
	private CanvasRenderer m_CachedInputRenderer; // 0x1B8
	private bool m_PreventFontCallback; // 0x1C0
	protected Mesh m_Mesh; // 0x1C8
	private bool m_AllowInput; // 0x1D0
	private bool m_ShouldActivateNextUpdate; // 0x1D1
	private bool m_UpdateDrag; // 0x1D2
	private bool m_DragPositionOutOfBounds; // 0x1D3
	private const float kHScrollSpeed = 0.05;
	private const float kVScrollSpeed = 0.1;
	protected bool m_CaretVisible; // 0x1D4
	private Coroutine m_BlinkCoroutine; // 0x1D8
	private float m_BlinkStartTime; // 0x1E0
	protected int m_DrawStart; // 0x1E4
	protected int m_DrawEnd; // 0x1E8
	private Coroutine m_DragCoroutine; // 0x1F0
	private string m_OriginalText; // 0x1F8
	private bool m_WasCanceled; // 0x200
	private bool m_HasDoneFocusTransition; // 0x201
	private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x208
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x210
	private bool m_IsCompositionActive; // 0x211
	private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~";
	private const string kOculusQuestDeviceModel = "Oculus Quest";
	private Event m_ProcessingEvent; // 0x218
	private const int k_MaxTextLength = 16382;

	// Properties
	private BaseInput input { get; }
	private string compositionString { get; }
	protected Mesh mesh { get; }
	protected TextGenerator cachedInputTextGenerator { get; }
	public bool shouldHideMobileInput { get; set; }
	public virtual bool shouldActivateOnSelect { get; set; }
	public string text { get; set; }
	public bool isFocused { get; }
	public float caretBlinkRate { get; set; }
	public int caretWidth { get; set; }
	public Text textComponent { get; set; }
	public Graphic placeholder { get; set; }
	public Color caretColor { get; set; }
	public bool customCaretColor { get; set; }
	public Color selectionColor { get; set; }
	public InputField.EndEditEvent onEndEdit { get; set; }
	public InputField.SubmitEvent onSubmit { get; set; }
	[Obsolete("onValueChange has been renamed to onValueChanged")]
	public InputField.OnChangeEvent onValueChange { get; set; }
	public InputField.OnChangeEvent onValueChanged { get; set; }
	public InputField.OnValidateInput onValidateInput { get; set; }
	public int characterLimit { get; set; }
	public InputField.ContentType contentType { get; set; }
	public InputField.LineType lineType { get; set; }
	public InputField.InputType inputType { get; set; }
	public TouchScreenKeyboard touchScreenKeyboard { get; }
	public TouchScreenKeyboardType keyboardType { get; set; }
	public InputField.CharacterValidation characterValidation { get; set; }
	public bool readOnly { get; set; }
	public bool multiLine { get; }
	public char asteriskChar { get; set; }
	public bool wasCanceled { get; }
	protected int caretPositionInternal { get; set; }
	protected int caretSelectPositionInternal { get; set; }
	private bool hasSelection { get; }
	public int caretPosition { get; set; }
	public int selectionAnchorPosition { get; set; }
	public int selectionFocusPosition { get; set; }
	private static string clipboard { get; set; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x1EF1594 Offset: 0x1EED594 VA: 0x1EF1594
	private BaseInput get_input() { }

	// RVA: 0x1EF16A4 Offset: 0x1EED6A4 VA: 0x1EF16A4
	private string get_compositionString() { }

	// RVA: 0x1EF1738 Offset: 0x1EED738 VA: 0x1EF1738
	protected void .ctor() { }

	// RVA: 0x1EF1A80 Offset: 0x1EEDA80 VA: 0x1EF1A80
	protected Mesh get_mesh() { }

	// RVA: 0x1EF1B24 Offset: 0x1EEDB24 VA: 0x1EF1B24
	protected TextGenerator get_cachedInputTextGenerator() { }

	// RVA: 0x1EF1B94 Offset: 0x1EEDB94 VA: 0x1EF1B94
	public void set_shouldHideMobileInput(bool value) { }

	// RVA: 0x1EF1BEC Offset: 0x1EEDBEC VA: 0x1EF1BEC
	public bool get_shouldHideMobileInput() { }

	// RVA: 0x1EF1C74 Offset: 0x1EEDC74 VA: 0x1EF1C74 Slot: 59
	public virtual void set_shouldActivateOnSelect(bool value) { }

	// RVA: 0x1EF1C7C Offset: 0x1EEDC7C VA: 0x1EF1C7C Slot: 60
	public virtual bool get_shouldActivateOnSelect() { }

	// RVA: 0x1EF1CEC Offset: 0x1EEDCEC VA: 0x1EF1CEC
	public string get_text() { }

	// RVA: 0x1EF1CF4 Offset: 0x1EEDCF4 VA: 0x1EF1CF4
	public void set_text(string value) { }

	// RVA: 0x1EF2024 Offset: 0x1EEE024 VA: 0x1EF2024
	public void SetTextWithoutNotify(string input) { }

	// RVA: 0x1EF1CFC Offset: 0x1EEDCFC VA: 0x1EF1CFC
	private void SetText(string value, bool sendCallback = True) { }

	// RVA: 0x1EF2564 Offset: 0x1EEE564 VA: 0x1EF2564
	public bool get_isFocused() { }

	// RVA: 0x1EF256C Offset: 0x1EEE56C VA: 0x1EF256C
	public float get_caretBlinkRate() { }

	// RVA: 0x1EF2574 Offset: 0x1EEE574 VA: 0x1EF2574
	public void set_caretBlinkRate(float value) { }

	// RVA: 0x1EF2650 Offset: 0x1EEE650 VA: 0x1EF2650
	public int get_caretWidth() { }

	// RVA: 0x1EF2658 Offset: 0x1EEE658 VA: 0x1EF2658
	public void set_caretWidth(int value) { }

	// RVA: 0x1EF2724 Offset: 0x1EEE724 VA: 0x1EF2724
	public Text get_textComponent() { }

	// RVA: 0x1EF272C Offset: 0x1EEE72C VA: 0x1EF272C
	public void set_textComponent(Text value) { }

	// RVA: 0x1EF29AC Offset: 0x1EEE9AC VA: 0x1EF29AC
	public Graphic get_placeholder() { }

	// RVA: 0x1EF29B4 Offset: 0x1EEE9B4 VA: 0x1EF29B4
	public void set_placeholder(Graphic value) { }

	// RVA: 0x1EF2A0C Offset: 0x1EEEA0C VA: 0x1EF2A0C
	public Color get_caretColor() { }

	// RVA: 0x1EF2A50 Offset: 0x1EEEA50 VA: 0x1EF2A50
	public void set_caretColor(Color value) { }

	// RVA: 0x1EF2A7C Offset: 0x1EEEA7C VA: 0x1EF2A7C
	public bool get_customCaretColor() { }

	// RVA: 0x1EF2A84 Offset: 0x1EEEA84 VA: 0x1EF2A84
	public void set_customCaretColor(bool value) { }

	// RVA: 0x1EF2AA0 Offset: 0x1EEEAA0 VA: 0x1EF2AA0
	public Color get_selectionColor() { }

	// RVA: 0x1EF2AB4 Offset: 0x1EEEAB4 VA: 0x1EF2AB4
	public void set_selectionColor(Color value) { }

	// RVA: 0x1EF2AE0 Offset: 0x1EEEAE0 VA: 0x1EF2AE0
	public InputField.EndEditEvent get_onEndEdit() { }

	// RVA: 0x1EF2AE8 Offset: 0x1EEEAE8 VA: 0x1EF2AE8
	public void set_onEndEdit(InputField.EndEditEvent value) { }

	// RVA: 0x1EF2B40 Offset: 0x1EEEB40 VA: 0x1EF2B40
	public InputField.SubmitEvent get_onSubmit() { }

	// RVA: 0x1EF2B48 Offset: 0x1EEEB48 VA: 0x1EF2B48
	public void set_onSubmit(InputField.SubmitEvent value) { }

	// RVA: 0x1EF2BA0 Offset: 0x1EEEBA0 VA: 0x1EF2BA0
	public InputField.OnChangeEvent get_onValueChange() { }

	// RVA: 0x1EF2BA8 Offset: 0x1EEEBA8 VA: 0x1EF2BA8
	public void set_onValueChange(InputField.OnChangeEvent value) { }

	// RVA: 0x1EF2C04 Offset: 0x1EEEC04 VA: 0x1EF2C04
	public InputField.OnChangeEvent get_onValueChanged() { }

	// RVA: 0x1EF2BAC Offset: 0x1EEEBAC VA: 0x1EF2BAC
	public void set_onValueChanged(InputField.OnChangeEvent value) { }

	// RVA: 0x1EF2C0C Offset: 0x1EEEC0C VA: 0x1EF2C0C
	public InputField.OnValidateInput get_onValidateInput() { }

	// RVA: 0x1EF2C14 Offset: 0x1EEEC14 VA: 0x1EF2C14
	public void set_onValidateInput(InputField.OnValidateInput value) { }

	// RVA: 0x1EF2C6C Offset: 0x1EEEC6C VA: 0x1EF2C6C
	public int get_characterLimit() { }

	// RVA: 0x1EF2C74 Offset: 0x1EEEC74 VA: 0x1EF2C74
	public void set_characterLimit(int value) { }

	// RVA: 0x1EF2D30 Offset: 0x1EEED30 VA: 0x1EF2D30
	public InputField.ContentType get_contentType() { }

	// RVA: 0x1EF2D38 Offset: 0x1EEED38 VA: 0x1EF2D38
	public void set_contentType(InputField.ContentType value) { }

	// RVA: 0x1EF2EB4 Offset: 0x1EEEEB4 VA: 0x1EF2EB4
	public InputField.LineType get_lineType() { }

	// RVA: 0x1EF2EBC Offset: 0x1EEEEBC VA: 0x1EF2EBC
	public void set_lineType(InputField.LineType value) { }

	// RVA: 0x1EF2FE4 Offset: 0x1EEEFE4 VA: 0x1EF2FE4
	public InputField.InputType get_inputType() { }

	// RVA: 0x1EF2FEC Offset: 0x1EEEFEC VA: 0x1EF2FEC
	public void set_inputType(InputField.InputType value) { }

	// RVA: 0x1EF3088 Offset: 0x1EEF088 VA: 0x1EF3088
	public TouchScreenKeyboard get_touchScreenKeyboard() { }

	// RVA: 0x1EF3090 Offset: 0x1EEF090 VA: 0x1EF3090
	public TouchScreenKeyboardType get_keyboardType() { }

	// RVA: 0x1EF3098 Offset: 0x1EEF098 VA: 0x1EF3098
	public void set_keyboardType(TouchScreenKeyboardType value) { }

	// RVA: 0x1EF311C Offset: 0x1EEF11C VA: 0x1EF311C
	public InputField.CharacterValidation get_characterValidation() { }

	// RVA: 0x1EF3124 Offset: 0x1EEF124 VA: 0x1EF3124
	public void set_characterValidation(InputField.CharacterValidation value) { }

	// RVA: 0x1EF31A8 Offset: 0x1EEF1A8 VA: 0x1EF31A8
	public bool get_readOnly() { }

	// RVA: 0x1EF31B0 Offset: 0x1EEF1B0 VA: 0x1EF31B0
	public void set_readOnly(bool value) { }

	// RVA: 0x1EF31B8 Offset: 0x1EEF1B8 VA: 0x1EF31B8
	public bool get_multiLine() { }

	// RVA: 0x1EF31CC Offset: 0x1EEF1CC VA: 0x1EF31CC
	public char get_asteriskChar() { }

	// RVA: 0x1EF31D4 Offset: 0x1EEF1D4 VA: 0x1EF31D4
	public void set_asteriskChar(char value) { }

	// RVA: 0x1EF3248 Offset: 0x1EEF248 VA: 0x1EF3248
	public bool get_wasCanceled() { }

	// RVA: 0x1EF3250 Offset: 0x1EEF250 VA: 0x1EF3250
	protected void ClampPos(ref int pos) { }

	// RVA: 0x1EF3284 Offset: 0x1EEF284 VA: 0x1EF3284
	protected int get_caretPositionInternal() { }

	// RVA: 0x1EF32A8 Offset: 0x1EEF2A8 VA: 0x1EF32A8
	protected void set_caretPositionInternal(int value) { }

	// RVA: 0x1EF32DC Offset: 0x1EEF2DC VA: 0x1EF32DC
	protected int get_caretSelectPositionInternal() { }

	// RVA: 0x1EF3300 Offset: 0x1EEF300 VA: 0x1EF3300
	protected void set_caretSelectPositionInternal(int value) { }

	// RVA: 0x1EF3334 Offset: 0x1EEF334 VA: 0x1EF3334
	private bool get_hasSelection() { }

	// RVA: 0x1EF3364 Offset: 0x1EEF364 VA: 0x1EF3364
	public int get_caretPosition() { }

	// RVA: 0x1EF3388 Offset: 0x1EEF388 VA: 0x1EF3388
	public void set_caretPosition(int value) { }

	// RVA: 0x1EF3460 Offset: 0x1EEF460 VA: 0x1EF3460
	public int get_selectionAnchorPosition() { }

	// RVA: 0x1EF33B0 Offset: 0x1EEF3B0 VA: 0x1EF33B0
	public void set_selectionAnchorPosition(int value) { }

	// RVA: 0x1EF3484 Offset: 0x1EEF484 VA: 0x1EF3484
	public int get_selectionFocusPosition() { }

	// RVA: 0x1EF3408 Offset: 0x1EEF408 VA: 0x1EF3408
	public void set_selectionFocusPosition(int value) { }

	// RVA: 0x1EF34A8 Offset: 0x1EEF4A8 VA: 0x1EF34A8 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1EF3568 Offset: 0x1EEF568 VA: 0x1EF3568 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1EF37C8 Offset: 0x1EEF7C8 VA: 0x1EF37C8 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1EF3B90 Offset: 0x1EEFB90 VA: 0x1EF3B90 Slot: 8
	protected override void OnDestroy() { }

	[IteratorStateMachine(typeof(InputField.<CaretBlink>d__172))]
	// RVA: 0x1EF3BF4 Offset: 0x1EEFBF4 VA: 0x1EF3BF4
	private IEnumerator CaretBlink() { }

	// RVA: 0x1EF3C88 Offset: 0x1EEFC88 VA: 0x1EF3C88
	private void SetCaretVisible() { }

	// RVA: 0x1EF25F0 Offset: 0x1EEE5F0 VA: 0x1EF25F0
	private void SetCaretActive() { }

	// RVA: 0x1EF3CBC Offset: 0x1EEFCBC VA: 0x1EF3CBC
	private void UpdateCaretMaterial() { }

	// RVA: 0x1EF3DCC Offset: 0x1EEFDCC VA: 0x1EF3DCC
	protected void OnFocus() { }

	// RVA: 0x1EF3DD0 Offset: 0x1EEFDD0 VA: 0x1EF3DD0
	protected void SelectAll() { }

	// RVA: 0x1EF3E08 Offset: 0x1EEFE08 VA: 0x1EF3E08
	public void MoveTextEnd(bool shift) { }

	// RVA: 0x1EF3E68 Offset: 0x1EEFE68 VA: 0x1EF3E68
	public void MoveTextStart(bool shift) { }

	// RVA: 0x1EF3EE4 Offset: 0x1EEFEE4 VA: 0x1EF3EE4
	private static string get_clipboard() { }

	// RVA: 0x1EF3F34 Offset: 0x1EEFF34 VA: 0x1EF3F34
	private static void set_clipboard(string value) { }

	// RVA: 0x1EF3F8C Offset: 0x1EEFF8C VA: 0x1EF3F8C
	private bool TouchScreenKeyboardShouldBeUsed() { }

	// RVA: 0x1EF4044 Offset: 0x1EF0044 VA: 0x1EF4044
	private bool InPlaceEditing() { }

	// RVA: 0x1EF4074 Offset: 0x1EF0074 VA: 0x1EF4074
	private bool InPlaceEditingChanged() { }

	// RVA: 0x1EF40F4 Offset: 0x1EF00F4 VA: 0x1EF40F4
	private RangeInt GetInternalSelection() { }

	// RVA: 0x1EF41A8 Offset: 0x1EF01A8 VA: 0x1EF41A8
	private void UpdateKeyboardCaret() { }

	// RVA: 0x1EF4270 Offset: 0x1EF0270 VA: 0x1EF4270
	private void UpdateCaretFromKeyboard() { }

	// RVA: 0x1EF4368 Offset: 0x1EF0368 VA: 0x1EF4368 Slot: 61
	protected virtual void LateUpdate() { }

	[Obsolete("This function is no longer used. Please use RectTransformUtility.ScreenPointToLocalPointInRectangle() instead.")]
	// RVA: 0x1EF5964 Offset: 0x1EF1964 VA: 0x1EF5964
	public Vector2 ScreenToLocal(Vector2 screen) { }

	// RVA: 0x1EF5D08 Offset: 0x1EF1D08 VA: 0x1EF5D08
	private int GetUnclampedCharacterLineFromPosition(Vector2 pos, TextGenerator generator) { }

	// RVA: 0x1EF5F18 Offset: 0x1EF1F18 VA: 0x1EF5F18
	protected int GetCharacterIndexFromPosition(Vector2 pos) { }

	// RVA: 0x1EF6310 Offset: 0x1EF2310 VA: 0x1EF6310
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1EF63E8 Offset: 0x1EF23E8 VA: 0x1EF63E8 Slot: 62
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1EF6408 Offset: 0x1EF2408 VA: 0x1EF6408 Slot: 63
	public virtual void OnDrag(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(InputField.<MouseDragOutsideRect>d__196))]
	// RVA: 0x1EF6608 Offset: 0x1EF2608 VA: 0x1EF6608
	private IEnumerator MouseDragOutsideRect(PointerEventData eventData) { }

	// RVA: 0x1EF66B8 Offset: 0x1EF26B8 VA: 0x1EF66B8 Slot: 64
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1EF66D4 Offset: 0x1EF26D4 VA: 0x1EF66D4 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1EF68DC Offset: 0x1EF28DC VA: 0x1EF68DC
	protected InputField.EditState KeyPressed(Event evt) { }

	// RVA: 0x1EF740C Offset: 0x1EF340C VA: 0x1EF740C
	private bool IsValidChar(char c) { }

	// RVA: 0x1EF747C Offset: 0x1EF347C VA: 0x1EF747C
	public void ProcessEvent(Event e) { }

	// RVA: 0x1EF7480 Offset: 0x1EF3480 VA: 0x1EF7480 Slot: 65
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x1EF6EB8 Offset: 0x1EF2EB8 VA: 0x1EF6EB8
	private string GetSelectedString() { }

	// RVA: 0x1EF7608 Offset: 0x1EF3608 VA: 0x1EF7608
	private int FindtNextWordBegin() { }

	// RVA: 0x1EF72B4 Offset: 0x1EF32B4 VA: 0x1EF72B4
	private void MoveRight(bool shift, bool ctrl) { }

	// RVA: 0x1EF76C4 Offset: 0x1EF36C4 VA: 0x1EF76C4
	private int FindtPrevWordBegin() { }

	// RVA: 0x1EF716C Offset: 0x1EF316C VA: 0x1EF716C
	private void MoveLeft(bool shift, bool ctrl) { }

	// RVA: 0x1EF7764 Offset: 0x1EF3764 VA: 0x1EF7764
	private int DetermineCharacterLine(int charPos, TextGenerator generator) { }

	// RVA: 0x1EF7874 Offset: 0x1EF3874 VA: 0x1EF7874
	private int LineUpCharacterPosition(int originalPos, bool goToFirstChar) { }

	// RVA: 0x1EF7BCC Offset: 0x1EF3BCC VA: 0x1EF7BCC
	private int LineDownCharacterPosition(int originalPos, bool goToLastChar) { }

	// RVA: 0x1EF7404 Offset: 0x1EF3404 VA: 0x1EF7404
	private void MoveDown(bool shift) { }

	// RVA: 0x1EF7E80 Offset: 0x1EF3E80 VA: 0x1EF7E80
	private void MoveDown(bool shift, bool goToLastChar) { }

	// RVA: 0x1EF73FC Offset: 0x1EF33FC VA: 0x1EF73FC
	private void MoveUp(bool shift) { }

	// RVA: 0x1EF7FE0 Offset: 0x1EF3FE0 VA: 0x1EF7FE0
	private void MoveUp(bool shift, bool goToFirstChar) { }

	// RVA: 0x1EF6F5C Offset: 0x1EF2F5C VA: 0x1EF6F5C
	private void Delete() { }

	// RVA: 0x1EF6E08 Offset: 0x1EF2E08 VA: 0x1EF6E08
	private void ForwardSpace() { }

	// RVA: 0x1EF6CEC Offset: 0x1EF2CEC VA: 0x1EF6CEC
	private void Backspace() { }

	// RVA: 0x1EF8158 Offset: 0x1EF4158 VA: 0x1EF8158
	private void Insert(char c) { }

	// RVA: 0x1EF7124 Offset: 0x1EF3124 VA: 0x1EF7124
	private void UpdateTouchKeyboardFromEditChanges() { }

	// RVA: 0x1EF594C Offset: 0x1EF194C VA: 0x1EF594C
	private void SendOnValueChangedAndUpdateLabel() { }

	// RVA: 0x1EF20E0 Offset: 0x1EEE0E0 VA: 0x1EF20E0
	private void SendOnValueChanged() { }

	// RVA: 0x1EF8268 Offset: 0x1EF4268 VA: 0x1EF8268
	protected void SendOnEndEdit() { }

	// RVA: 0x1EF51CC Offset: 0x1EF11CC VA: 0x1EF51CC
	protected void SendOnSubmit() { }

	// RVA: 0x1EF82E8 Offset: 0x1EF42E8 VA: 0x1EF82E8 Slot: 66
	protected virtual void Append(string input) { }

	// RVA: 0x1EF83A4 Offset: 0x1EF43A4 VA: 0x1EF83A4 Slot: 67
	protected virtual void Append(char input) { }

	// RVA: 0x1EF2160 Offset: 0x1EEE160 VA: 0x1EF2160
	protected void UpdateLabel() { }

	// RVA: 0x1EF914C Offset: 0x1EF514C VA: 0x1EF914C
	private bool IsSelectionVisible() { }

	// RVA: 0x1EF91B8 Offset: 0x1EF51B8 VA: 0x1EF91B8
	private static int GetLineStartPosition(TextGenerator gen, int line) { }

	// RVA: 0x1EF61AC Offset: 0x1EF21AC VA: 0x1EF61AC
	private static int GetLineEndPosition(TextGenerator gen, int line) { }

	// RVA: 0x1EF8608 Offset: 0x1EF4608 VA: 0x1EF8608
	private void SetDrawRangeToContainCaretPosition(int caretPos) { }

	// RVA: 0x1EF9308 Offset: 0x1EF5308 VA: 0x1EF9308
	public void ForceLabelUpdate() { }

	// RVA: 0x1EF26CC Offset: 0x1EEE6CC VA: 0x1EF26CC
	private void MarkGeometryAsDirty() { }

	// RVA: 0x1EF930C Offset: 0x1EF530C VA: 0x1EF930C Slot: 68
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x1EF9760 Offset: 0x1EF5760 VA: 0x1EF9760 Slot: 69
	public virtual void LayoutComplete() { }

	// RVA: 0x1EF9764 Offset: 0x1EF5764 VA: 0x1EF9764 Slot: 70
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1EF931C Offset: 0x1EF531C VA: 0x1EF931C
	private void UpdateGeometry() { }

	// RVA: 0x1EF4CCC Offset: 0x1EF0CCC VA: 0x1EF4CCC
	private void AssignPositioningIfNeeded() { }

	// RVA: 0x1EF9768 Offset: 0x1EF5768 VA: 0x1EF9768
	private void OnFillVBO(Mesh vbo) { }

	// RVA: 0x1EF99A0 Offset: 0x1EF59A0 VA: 0x1EF99A0
	private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x1EFA7E8 Offset: 0x1EF67E8 VA: 0x1EFA7E8
	private void CreateCursorVerts() { }

	// RVA: 0x1EFA0B4 Offset: 0x1EF60B4 VA: 0x1EFA0B4
	private void GenerateHighlight(VertexHelper vbo, Vector2 roundingOffset) { }

	// RVA: 0x1EF524C Offset: 0x1EF124C VA: 0x1EF524C
	protected char Validate(string text, int pos, char ch) { }

	// RVA: 0x1EFA92C Offset: 0x1EF692C VA: 0x1EFA92C
	public void ActivateInputField() { }

	// RVA: 0x1EF4990 Offset: 0x1EF0990 VA: 0x1EF4990
	private void ActivateInputFieldInternal() { }

	// RVA: 0x1EFAA4C Offset: 0x1EF6A4C VA: 0x1EFAA4C Slot: 36
	public override void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1EFAA88 Offset: 0x1EF6A88 VA: 0x1EFAA88 Slot: 71
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1EF3A08 Offset: 0x1EEFA08 VA: 0x1EF3A08
	public void DeactivateInputField() { }

	// RVA: 0x1EFAAA4 Offset: 0x1EF6AA4 VA: 0x1EFAAA4 Slot: 37
	public override void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1EFAB08 Offset: 0x1EF6B08 VA: 0x1EFAB08 Slot: 72
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1EF2DAC Offset: 0x1EEEDAC VA: 0x1EF2DAC
	private void EnforceContentType() { }

	// RVA: 0x1EF19DC Offset: 0x1EED9DC VA: 0x1EF19DC
	private void EnforceTextHOverflow() { }

	// RVA: 0x1EF2F7C Offset: 0x1EEEF7C VA: 0x1EF2F7C
	private void SetToCustomIfContentTypeIsNot(InputField.ContentType[] allowedContentTypes) { }

	// RVA: 0x1EF3070 Offset: 0x1EEF070 VA: 0x1EF3070
	private void SetToCustom() { }

	// RVA: 0x1EFAB50 Offset: 0x1EF6B50 VA: 0x1EFAB50 Slot: 26
	protected override void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x1EFAB7C Offset: 0x1EF6B7C VA: 0x1EFAB7C Slot: 73
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1EFAB80 Offset: 0x1EF6B80 VA: 0x1EFAB80 Slot: 74
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1EFAB84 Offset: 0x1EF6B84 VA: 0x1EFAB84 Slot: 75
	public virtual float get_minWidth() { }

	// RVA: 0x1EFAB8C Offset: 0x1EF6B8C VA: 0x1EFAB8C Slot: 76
	public virtual float get_preferredWidth() { }

	// RVA: 0x1EFACD8 Offset: 0x1EF6CD8 VA: 0x1EFACD8 Slot: 77
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1EFACE0 Offset: 0x1EF6CE0 VA: 0x1EFACE0 Slot: 78
	public virtual float get_minHeight() { }

	// RVA: 0x1EFACE8 Offset: 0x1EF6CE8 VA: 0x1EFACE8 Slot: 79
	public virtual float get_preferredHeight() { }

	// RVA: 0x1EFAE20 Offset: 0x1EF6E20 VA: 0x1EFAE20 Slot: 80
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1EFAE28 Offset: 0x1EF6E28 VA: 0x1EFAE28 Slot: 81
	public virtual int get_layoutPriority() { }

	// RVA: 0x1EFAE30 Offset: 0x1EF6E30 VA: 0x1EFAE30
	private static void .cctor() { }

	// RVA: 0x1EFAEE0 Offset: 0x1EF6EE0 VA: 0x1EFAEE0 Slot: 46
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: 
public enum AspectRatioFitter.AspectMode // TypeDefIndex: 7283
{
	// Fields
	public int value__; // 0x0
	public const AspectRatioFitter.AspectMode None = 0;
	public const AspectRatioFitter.AspectMode WidthControlsHeight = 1;
	public const AspectRatioFitter.AspectMode HeightControlsWidth = 2;
	public const AspectRatioFitter.AspectMode FitInParent = 3;
	public const AspectRatioFitter.AspectMode EnvelopeParent = 4;
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Aspect Ratio Fitter", 142)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
public class AspectRatioFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 7284
{
	// Fields
	[SerializeField]
	private AspectRatioFitter.AspectMode m_AspectMode; // 0x20
	[SerializeField]
	private float m_AspectRatio; // 0x24
	private RectTransform m_Rect; // 0x28
	private bool m_DelayedSetDirty; // 0x30
	private bool m_DoesParentExist; // 0x31
	private DrivenRectTransformTracker m_Tracker; // 0x32

	// Properties
	public AspectRatioFitter.AspectMode aspectMode { get; set; }
	public float aspectRatio { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x1EFB3EC Offset: 0x1EF73EC VA: 0x1EFB3EC
	public AspectRatioFitter.AspectMode get_aspectMode() { }

	// RVA: 0x1EFB3F4 Offset: 0x1EF73F4 VA: 0x1EFB3F4
	public void set_aspectMode(AspectRatioFitter.AspectMode value) { }

	// RVA: 0x1EFB46C Offset: 0x1EF746C VA: 0x1EFB46C
	public float get_aspectRatio() { }

	// RVA: 0x1EFB474 Offset: 0x1EF7474 VA: 0x1EFB474
	public void set_aspectRatio(float value) { }

	// RVA: 0x1EFB4E8 Offset: 0x1EF74E8 VA: 0x1EFB4E8
	private RectTransform get_rectTransform() { }

	// RVA: 0x1EFB588 Offset: 0x1EF7588 VA: 0x1EFB588
	protected void .ctor() { }

	// RVA: 0x1EFB598 Offset: 0x1EF7598 VA: 0x1EFB598 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1EFB630 Offset: 0x1EF7630 VA: 0x1EFB630 Slot: 6
	protected override void Start() { }

	// RVA: 0x1EFB774 Offset: 0x1EF7774 VA: 0x1EFB774 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1EFBBE4 Offset: 0x1EF7BE4 VA: 0x1EFBBE4 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1EFBC7C Offset: 0x1EF7C7C VA: 0x1EFBC7C Slot: 19
	protected virtual void Update() { }

	// RVA: 0x1EFBC90 Offset: 0x1EF7C90 VA: 0x1EFBC90 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1EFBC94 Offset: 0x1EF7C94 VA: 0x1EFBC94
	private void UpdateRect() { }

	// RVA: 0x1EFBFDC Offset: 0x1EF7FDC VA: 0x1EFBFDC
	private float GetSizeDeltaToProduceSize(float size, int axis) { }

	// RVA: 0x1EFBEE4 Offset: 0x1EF7EE4 VA: 0x1EFBEE4
	private Vector2 GetParentSize() { }

	// RVA: 0x1EFC0D0 Offset: 0x1EF80D0 VA: 0x1EFC0D0 Slot: 20
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x1EFC0D4 Offset: 0x1EF80D4 VA: 0x1EFC0D4 Slot: 21
	public virtual void SetLayoutVertical() { }

	// RVA: 0x1EFB468 Offset: 0x1EF7468 VA: 0x1EFB468
	protected void SetDirty() { }

	// RVA: 0x1EFB680 Offset: 0x1EF7680 VA: 0x1EFB680
	public bool IsComponentValidOnObject() { }

	// RVA: 0x1EFB74C Offset: 0x1EF774C VA: 0x1EFB74C
	public bool IsAspectModeValid() { }

	// RVA: 0x1EFC0D8 Offset: 0x1EF80D8 VA: 0x1EFC0D8
	private bool DoesParentExists() { }
}

// Namespace: 
public enum CanvasScaler.ScaleMode // TypeDefIndex: 7285
{
	// Fields
	public int value__; // 0x0
	public const CanvasScaler.ScaleMode ConstantPixelSize = 0;
	public const CanvasScaler.ScaleMode ScaleWithScreenSize = 1;
	public const CanvasScaler.ScaleMode ConstantPhysicalSize = 2;
}

// Namespace: 
public enum CanvasScaler.ScreenMatchMode // TypeDefIndex: 7286
{
	// Fields
	public int value__; // 0x0
	public const CanvasScaler.ScreenMatchMode MatchWidthOrHeight = 0;
	public const CanvasScaler.ScreenMatchMode Expand = 1;
	public const CanvasScaler.ScreenMatchMode Shrink = 2;
}

// Namespace: 
public enum CanvasScaler.Unit // TypeDefIndex: 7287
{
	// Fields
	public int value__; // 0x0
	public const CanvasScaler.Unit Centimeters = 0;
	public const CanvasScaler.Unit Millimeters = 1;
	public const CanvasScaler.Unit Inches = 2;
	public const CanvasScaler.Unit Points = 3;
	public const CanvasScaler.Unit Picas = 4;
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(Canvas))]
[ExecuteAlways]
[AddComponentMenu("Layout/Canvas Scaler", 101)]
[DisallowMultipleComponent]
public class CanvasScaler : UIBehaviour // TypeDefIndex: 7288
{
	// Fields
	[Tooltip("Determines how UI elements in the Canvas are scaled.")]
	[SerializeField]
	private CanvasScaler.ScaleMode m_UiScaleMode; // 0x20
	[Tooltip("If a sprite has this 'Pixels Per Unit' setting, then one pixel in the sprite will cover one unit in the UI.")]
	[SerializeField]
	protected float m_ReferencePixelsPerUnit; // 0x24
	[Tooltip("Scales all UI elements in the Canvas by this factor.")]
	[SerializeField]
	protected float m_ScaleFactor; // 0x28
	[Tooltip("The resolution the UI layout is designed for. If the screen resolution is larger, the UI will be scaled up, and if it's smaller, the UI will be scaled down. This is done in accordance with the Screen Match Mode.")]
	[SerializeField]
	protected Vector2 m_ReferenceResolution; // 0x2C
	[Tooltip("A mode used to scale the canvas area if the aspect ratio of the current resolution doesn't fit the reference resolution.")]
	[SerializeField]
	protected CanvasScaler.ScreenMatchMode m_ScreenMatchMode; // 0x34
	[Tooltip("Determines if the scaling is using the width or height as reference, or a mix in between.")]
	[Range(0, 1)]
	[SerializeField]
	protected float m_MatchWidthOrHeight; // 0x38
	private const float kLogBase = 2;
	[Tooltip("The physical unit to specify positions and sizes in.")]
	[SerializeField]
	protected CanvasScaler.Unit m_PhysicalUnit; // 0x3C
	[Tooltip("The DPI to assume if the screen DPI is not known.")]
	[SerializeField]
	protected float m_FallbackScreenDPI; // 0x40
	[Tooltip("The pixels per inch to use for sprites that have a 'Pixels Per Unit' setting that matches the 'Reference Pixels Per Unit' setting.")]
	[SerializeField]
	protected float m_DefaultSpriteDPI; // 0x44
	[Tooltip("The amount of pixels per unit to use for dynamically created bitmaps in the UI, such as Text.")]
	[SerializeField]
	protected float m_DynamicPixelsPerUnit; // 0x48
	private Canvas m_Canvas; // 0x50
	private float m_PrevScaleFactor; // 0x58
	private float m_PrevReferencePixelsPerUnit; // 0x5C
	[SerializeField]
	protected bool m_PresetInfoIsWorld; // 0x60

	// Properties
	public CanvasScaler.ScaleMode uiScaleMode { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public float scaleFactor { get; set; }
	public Vector2 referenceResolution { get; set; }
	public CanvasScaler.ScreenMatchMode screenMatchMode { get; set; }
	public float matchWidthOrHeight { get; set; }
	public CanvasScaler.Unit physicalUnit { get; set; }
	public float fallbackScreenDPI { get; set; }
	public float defaultSpriteDPI { get; set; }
	public float dynamicPixelsPerUnit { get; set; }

	// Methods

	// RVA: 0x1EFC0E0 Offset: 0x1EF80E0 VA: 0x1EFC0E0
	public CanvasScaler.ScaleMode get_uiScaleMode() { }

	// RVA: 0x1EFC0E8 Offset: 0x1EF80E8 VA: 0x1EFC0E8
	public void set_uiScaleMode(CanvasScaler.ScaleMode value) { }

	// RVA: 0x1EFC0F0 Offset: 0x1EF80F0 VA: 0x1EFC0F0
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x1EFC0F8 Offset: 0x1EF80F8 VA: 0x1EFC0F8
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x1EFC100 Offset: 0x1EF8100 VA: 0x1EFC100
	public float get_scaleFactor() { }

	// RVA: 0x1EFC108 Offset: 0x1EF8108 VA: 0x1EFC108
	public void set_scaleFactor(float value) { }

	// RVA: 0x1EFC120 Offset: 0x1EF8120 VA: 0x1EFC120
	public Vector2 get_referenceResolution() { }

	// RVA: 0x1EFC128 Offset: 0x1EF8128 VA: 0x1EFC128
	public void set_referenceResolution(Vector2 value) { }

	// RVA: 0x1EFC194 Offset: 0x1EF8194 VA: 0x1EFC194
	public CanvasScaler.ScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x1EFC19C Offset: 0x1EF819C VA: 0x1EFC19C
	public void set_screenMatchMode(CanvasScaler.ScreenMatchMode value) { }

	// RVA: 0x1EFC1A4 Offset: 0x1EF81A4 VA: 0x1EFC1A4
	public float get_matchWidthOrHeight() { }

	// RVA: 0x1EFC1AC Offset: 0x1EF81AC VA: 0x1EFC1AC
	public void set_matchWidthOrHeight(float value) { }

	// RVA: 0x1EFC1B4 Offset: 0x1EF81B4 VA: 0x1EFC1B4
	public CanvasScaler.Unit get_physicalUnit() { }

	// RVA: 0x1EFC1BC Offset: 0x1EF81BC VA: 0x1EFC1BC
	public void set_physicalUnit(CanvasScaler.Unit value) { }

	// RVA: 0x1EFC1C4 Offset: 0x1EF81C4 VA: 0x1EFC1C4
	public float get_fallbackScreenDPI() { }

	// RVA: 0x1EFC1CC Offset: 0x1EF81CC VA: 0x1EFC1CC
	public void set_fallbackScreenDPI(float value) { }

	// RVA: 0x1EFC1D4 Offset: 0x1EF81D4 VA: 0x1EFC1D4
	public float get_defaultSpriteDPI() { }

	// RVA: 0x1EFC1DC Offset: 0x1EF81DC VA: 0x1EFC1DC
	public void set_defaultSpriteDPI(float value) { }

	// RVA: 0x1EFC1F0 Offset: 0x1EF81F0 VA: 0x1EFC1F0
	public float get_dynamicPixelsPerUnit() { }

	// RVA: 0x1EFC1F8 Offset: 0x1EF81F8 VA: 0x1EFC1F8
	public void set_dynamicPixelsPerUnit(float value) { }

	// RVA: 0x1EFC200 Offset: 0x1EF8200 VA: 0x1EFC200
	protected void .ctor() { }

	// RVA: 0x1EFC248 Offset: 0x1EF8248 VA: 0x1EFC248 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1EFC318 Offset: 0x1EF8318 VA: 0x1EFC318
	private void Canvas_preWillRenderCanvases() { }

	// RVA: 0x1EFC328 Offset: 0x1EF8328 VA: 0x1EFC328 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1EFC460 Offset: 0x1EF8460 VA: 0x1EFC460 Slot: 17
	protected virtual void Handle() { }

	// RVA: 0x1EFC564 Offset: 0x1EF8564 VA: 0x1EFC564 Slot: 18
	protected virtual void HandleWorldCanvas() { }

	// RVA: 0x1EFC584 Offset: 0x1EF8584 VA: 0x1EFC584 Slot: 19
	protected virtual void HandleConstantPixelSize() { }

	// RVA: 0x1EFC5A4 Offset: 0x1EF85A4 VA: 0x1EFC5A4 Slot: 20
	protected virtual void HandleScaleWithScreenSize() { }

	// RVA: 0x1EFC7DC Offset: 0x1EF87DC VA: 0x1EFC7DC Slot: 21
	protected virtual void HandleConstantPhysicalSize() { }

	// RVA: 0x1EFC3D0 Offset: 0x1EF83D0 VA: 0x1EFC3D0
	protected void SetScaleFactor(float scaleFactor) { }

	// RVA: 0x1EFC420 Offset: 0x1EF8420 VA: 0x1EFC420
	protected void SetReferencePixelsPerUnit(float referencePixelsPerUnit) { }
}

// Namespace: 
public enum ContentSizeFitter.FitMode // TypeDefIndex: 7289
{
	// Fields
	public int value__; // 0x0
	public const ContentSizeFitter.FitMode Unconstrained = 0;
	public const ContentSizeFitter.FitMode MinSize = 1;
	public const ContentSizeFitter.FitMode PreferredSize = 2;
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Content Size Fitter", 141)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class ContentSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController // TypeDefIndex: 7290
{
	// Fields
	[SerializeField]
	protected ContentSizeFitter.FitMode m_HorizontalFit; // 0x20
	[SerializeField]
	protected ContentSizeFitter.FitMode m_VerticalFit; // 0x24
	private RectTransform m_Rect; // 0x28
	private DrivenRectTransformTracker m_Tracker; // 0x30

	// Properties
	public ContentSizeFitter.FitMode horizontalFit { get; set; }
	public ContentSizeFitter.FitMode verticalFit { get; set; }
	private RectTransform rectTransform { get; }

	// Methods

	// RVA: 0x1EFC844 Offset: 0x1EF8844 VA: 0x1EFC844
	public ContentSizeFitter.FitMode get_horizontalFit() { }

	// RVA: 0x1EFC84C Offset: 0x1EF884C VA: 0x1EFC84C
	public void set_horizontalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x1EFC944 Offset: 0x1EF8944 VA: 0x1EFC944
	public ContentSizeFitter.FitMode get_verticalFit() { }

	// RVA: 0x1EFC94C Offset: 0x1EF894C VA: 0x1EFC94C
	public void set_verticalFit(ContentSizeFitter.FitMode value) { }

	// RVA: 0x1EFC9C0 Offset: 0x1EF89C0 VA: 0x1EFC9C0
	private RectTransform get_rectTransform() { }

	// RVA: 0x1EFCA60 Offset: 0x1EF8A60 VA: 0x1EFCA60
	protected void .ctor() { }

	// RVA: 0x1EFCA68 Offset: 0x1EF8A68 VA: 0x1EFCA68 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1EFCA84 Offset: 0x1EF8A84 VA: 0x1EFCA84 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1EFCB00 Offset: 0x1EF8B00 VA: 0x1EFCB00 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1EFCB04 Offset: 0x1EF8B04 VA: 0x1EFCB04
	private void HandleSelfFittingAlongAxis(int axis) { }

	// RVA: 0x1EFCBF0 Offset: 0x1EF8BF0 VA: 0x1EFCBF0 Slot: 19
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x1EFCC14 Offset: 0x1EF8C14 VA: 0x1EFCC14 Slot: 20
	public virtual void SetLayoutVertical() { }

	// RVA: 0x1EFC8C0 Offset: 0x1EF88C0 VA: 0x1EFC8C0
	protected void SetDirty() { }
}

// Namespace: 
public enum GridLayoutGroup.Corner // TypeDefIndex: 7291
{
	// Fields
	public int value__; // 0x0
	public const GridLayoutGroup.Corner UpperLeft = 0;
	public const GridLayoutGroup.Corner UpperRight = 1;
	public const GridLayoutGroup.Corner LowerLeft = 2;
	public const GridLayoutGroup.Corner LowerRight = 3;
}

// Namespace: 
public enum GridLayoutGroup.Axis // TypeDefIndex: 7292
{
	// Fields
	public int value__; // 0x0
	public const GridLayoutGroup.Axis Horizontal = 0;
	public const GridLayoutGroup.Axis Vertical = 1;
}

// Namespace: 
public enum GridLayoutGroup.Constraint // TypeDefIndex: 7293
{
	// Fields
	public int value__; // 0x0
	public const GridLayoutGroup.Constraint Flexible = 0;
	public const GridLayoutGroup.Constraint FixedColumnCount = 1;
	public const GridLayoutGroup.Constraint FixedRowCount = 2;
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Grid Layout Group", 152)]
public class GridLayoutGroup : LayoutGroup // TypeDefIndex: 7294
{
	// Fields
	[SerializeField]
	protected GridLayoutGroup.Corner m_StartCorner; // 0x60
	[SerializeField]
	protected GridLayoutGroup.Axis m_StartAxis; // 0x64
	[SerializeField]
	protected Vector2 m_CellSize; // 0x68
	[SerializeField]
	protected Vector2 m_Spacing; // 0x70
	[SerializeField]
	protected GridLayoutGroup.Constraint m_Constraint; // 0x78
	[SerializeField]
	protected int m_ConstraintCount; // 0x7C

	// Properties
	public GridLayoutGroup.Corner startCorner { get; set; }
	public GridLayoutGroup.Axis startAxis { get; set; }
	public Vector2 cellSize { get; set; }
	public Vector2 spacing { get; set; }
	public GridLayoutGroup.Constraint constraint { get; set; }
	public int constraintCount { get; set; }

	// Methods

	// RVA: 0x1EFCC1C Offset: 0x1EF8C1C VA: 0x1EFCC1C
	public GridLayoutGroup.Corner get_startCorner() { }

	// RVA: 0x1EFCC24 Offset: 0x1EF8C24 VA: 0x1EFCC24
	public void set_startCorner(GridLayoutGroup.Corner value) { }

	// RVA: 0x1EFCC80 Offset: 0x1EF8C80 VA: 0x1EFCC80
	public GridLayoutGroup.Axis get_startAxis() { }

	// RVA: 0x1EFCC88 Offset: 0x1EF8C88 VA: 0x1EFCC88
	public void set_startAxis(GridLayoutGroup.Axis value) { }

	// RVA: 0x1EFCCE4 Offset: 0x1EF8CE4 VA: 0x1EFCCE4
	public Vector2 get_cellSize() { }

	// RVA: 0x1EFCCEC Offset: 0x1EF8CEC VA: 0x1EFCCEC
	public void set_cellSize(Vector2 value) { }

	// RVA: 0x1EFCD50 Offset: 0x1EF8D50 VA: 0x1EFCD50
	public Vector2 get_spacing() { }

	// RVA: 0x1EFCD58 Offset: 0x1EF8D58 VA: 0x1EFCD58
	public void set_spacing(Vector2 value) { }

	// RVA: 0x1EFCDBC Offset: 0x1EF8DBC VA: 0x1EFCDBC
	public GridLayoutGroup.Constraint get_constraint() { }

	// RVA: 0x1EFCDC4 Offset: 0x1EF8DC4 VA: 0x1EFCDC4
	public void set_constraint(GridLayoutGroup.Constraint value) { }

	// RVA: 0x1EFCE20 Offset: 0x1EF8E20 VA: 0x1EFCE20
	public int get_constraintCount() { }

	// RVA: 0x1EFCE28 Offset: 0x1EF8E28 VA: 0x1EFCE28
	public void set_constraintCount(int value) { }

	// RVA: 0x1EFCE88 Offset: 0x1EF8E88 VA: 0x1EFCE88
	protected void .ctor() { }

	// RVA: 0x1EFD04C Offset: 0x1EF904C VA: 0x1EFD04C Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1EFD640 Offset: 0x1EF9640 VA: 0x1EFD640 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x1EFD8F4 Offset: 0x1EF98F4 VA: 0x1EFD8F4 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x1EFE050 Offset: 0x1EFA050 VA: 0x1EFE050 Slot: 38
	public override void SetLayoutVertical() { }

	// RVA: 0x1EFD8FC Offset: 0x1EF98FC VA: 0x1EFD8FC
	private void SetCellsAlongAxis(int axis) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Horizontal Layout Group", 150)]
public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 7295
{
	// Methods

	// RVA: 0x1EFE258 Offset: 0x1EFA258 VA: 0x1EFE258
	protected void .ctor() { }

	// RVA: 0x1EFE270 Offset: 0x1EFA270 VA: 0x1EFE270 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1EFE530 Offset: 0x1EFA530 VA: 0x1EFE530 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x1EFE53C Offset: 0x1EFA53C VA: 0x1EFE53C Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x1EFEB94 Offset: 0x1EFAB94 VA: 0x1EFEB94 Slot: 38
	public override void SetLayoutVertical() { }
}

// Namespace: UnityEngine.UI
[ExecuteAlways]
public abstract class HorizontalOrVerticalLayoutGroup : LayoutGroup // TypeDefIndex: 7296
{
	// Fields
	[SerializeField]
	protected float m_Spacing; // 0x60
	[SerializeField]
	protected bool m_ChildForceExpandWidth; // 0x64
	[SerializeField]
	protected bool m_ChildForceExpandHeight; // 0x65
	[SerializeField]
	protected bool m_ChildControlWidth; // 0x66
	[SerializeField]
	protected bool m_ChildControlHeight; // 0x67
	[SerializeField]
	protected bool m_ChildScaleWidth; // 0x68
	[SerializeField]
	protected bool m_ChildScaleHeight; // 0x69
	[SerializeField]
	protected bool m_ReverseArrangement; // 0x6A

	// Properties
	public float spacing { get; set; }
	public bool childForceExpandWidth { get; set; }
	public bool childForceExpandHeight { get; set; }
	public bool childControlWidth { get; set; }
	public bool childControlHeight { get; set; }
	public bool childScaleWidth { get; set; }
	public bool childScaleHeight { get; set; }
	public bool reverseArrangement { get; set; }

	// Methods

	// RVA: 0x1EFEBA0 Offset: 0x1EFABA0 VA: 0x1EFEBA0
	public float get_spacing() { }

	// RVA: 0x1EFEBA8 Offset: 0x1EFABA8 VA: 0x1EFEBA8
	public void set_spacing(float value) { }

	// RVA: 0x1EFEC04 Offset: 0x1EFAC04 VA: 0x1EFEC04
	public bool get_childForceExpandWidth() { }

	// RVA: 0x1EFEC0C Offset: 0x1EFAC0C VA: 0x1EFEC0C
	public void set_childForceExpandWidth(bool value) { }

	// RVA: 0x1EFEC68 Offset: 0x1EFAC68 VA: 0x1EFEC68
	public bool get_childForceExpandHeight() { }

	// RVA: 0x1EFEC70 Offset: 0x1EFAC70 VA: 0x1EFEC70
	public void set_childForceExpandHeight(bool value) { }

	// RVA: 0x1EFECCC Offset: 0x1EFACCC VA: 0x1EFECCC
	public bool get_childControlWidth() { }

	// RVA: 0x1EFECD4 Offset: 0x1EFACD4 VA: 0x1EFECD4
	public void set_childControlWidth(bool value) { }

	// RVA: 0x1EFED30 Offset: 0x1EFAD30 VA: 0x1EFED30
	public bool get_childControlHeight() { }

	// RVA: 0x1EFED38 Offset: 0x1EFAD38 VA: 0x1EFED38
	public void set_childControlHeight(bool value) { }

	// RVA: 0x1EFED94 Offset: 0x1EFAD94 VA: 0x1EFED94
	public bool get_childScaleWidth() { }

	// RVA: 0x1EFED9C Offset: 0x1EFAD9C VA: 0x1EFED9C
	public void set_childScaleWidth(bool value) { }

	// RVA: 0x1EFEDF8 Offset: 0x1EFADF8 VA: 0x1EFEDF8
	public bool get_childScaleHeight() { }

	// RVA: 0x1EFEE00 Offset: 0x1EFAE00 VA: 0x1EFEE00
	public void set_childScaleHeight(bool value) { }

	// RVA: 0x1EFEE5C Offset: 0x1EFAE5C VA: 0x1EFEE5C
	public bool get_reverseArrangement() { }

	// RVA: 0x1EFEE64 Offset: 0x1EFAE64 VA: 0x1EFEE64
	public void set_reverseArrangement(bool value) { }

	// RVA: 0x1EFE290 Offset: 0x1EFA290 VA: 0x1EFE290
	protected void CalcAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x1EFE548 Offset: 0x1EFA548 VA: 0x1EFE548
	protected void SetChildrenAlongAxis(int axis, bool isVertical) { }

	// RVA: 0x1EFEEC0 Offset: 0x1EFAEC0 VA: 0x1EFEEC0
	private void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible) { }

	// RVA: 0x1EFE264 Offset: 0x1EFA264 VA: 0x1EFE264
	protected void .ctor() { }
}

// Namespace: UnityEngine.UI
public interface ILayoutElement // TypeDefIndex: 7297
{
	// Properties
	public abstract float minWidth { get; }
	public abstract float preferredWidth { get; }
	public abstract float flexibleWidth { get; }
	public abstract float minHeight { get; }
	public abstract float preferredHeight { get; }
	public abstract float flexibleHeight { get; }
	public abstract int layoutPriority { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CalculateLayoutInputHorizontal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void CalculateLayoutInputVertical();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_minWidth();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract float get_preferredWidth();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract float get_flexibleWidth();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract float get_minHeight();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_preferredHeight();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract float get_flexibleHeight();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_layoutPriority();
}

// Namespace: UnityEngine.UI
public interface ILayoutController // TypeDefIndex: 7298
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void SetLayoutVertical();
}

// Namespace: UnityEngine.UI
public interface ILayoutGroup : ILayoutController // TypeDefIndex: 7299
{}

// Namespace: UnityEngine.UI
public interface ILayoutSelfController : ILayoutController // TypeDefIndex: 7300
{}

// Namespace: UnityEngine.UI
public interface ILayoutIgnorer // TypeDefIndex: 7301
{
	// Properties
	public abstract bool ignoreLayout { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_ignoreLayout();
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Layout Element", 140)]
[RequireComponent(typeof(RectTransform))]
[ExecuteAlways]
public class LayoutElement : UIBehaviour, ILayoutElement, ILayoutIgnorer // TypeDefIndex: 7302
{
	// Fields
	[SerializeField]
	private bool m_IgnoreLayout; // 0x20
	[SerializeField]
	private float m_MinWidth; // 0x24
	[SerializeField]
	private float m_MinHeight; // 0x28
	[SerializeField]
	private float m_PreferredWidth; // 0x2C
	[SerializeField]
	private float m_PreferredHeight; // 0x30
	[SerializeField]
	private float m_FlexibleWidth; // 0x34
	[SerializeField]
	private float m_FlexibleHeight; // 0x38
	[SerializeField]
	private int m_LayoutPriority; // 0x3C

	// Properties
	public virtual bool ignoreLayout { get; set; }
	public virtual float minWidth { get; set; }
	public virtual float minHeight { get; set; }
	public virtual float preferredWidth { get; set; }
	public virtual float preferredHeight { get; set; }
	public virtual float flexibleWidth { get; set; }
	public virtual float flexibleHeight { get; set; }
	public virtual int layoutPriority { get; set; }

	// Methods

	// RVA: 0x1EFF5C8 Offset: 0x1EFB5C8 VA: 0x1EFF5C8 Slot: 27
	public virtual bool get_ignoreLayout() { }

	// RVA: 0x1EFF5D0 Offset: 0x1EFB5D0 VA: 0x1EFF5D0 Slot: 28
	public virtual void set_ignoreLayout(bool value) { }

	// RVA: 0x1EFF6FC Offset: 0x1EFB6FC VA: 0x1EFF6FC Slot: 29
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1EFF700 Offset: 0x1EFB700 VA: 0x1EFF700 Slot: 30
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1EFF704 Offset: 0x1EFB704 VA: 0x1EFF704 Slot: 31
	public virtual float get_minWidth() { }

	// RVA: 0x1EFF70C Offset: 0x1EFB70C VA: 0x1EFF70C Slot: 32
	public virtual void set_minWidth(float value) { }

	// RVA: 0x1EFF780 Offset: 0x1EFB780 VA: 0x1EFF780 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x1EFF788 Offset: 0x1EFB788 VA: 0x1EFF788 Slot: 34
	public virtual void set_minHeight(float value) { }

	// RVA: 0x1EFF7FC Offset: 0x1EFB7FC VA: 0x1EFF7FC Slot: 35
	public virtual float get_preferredWidth() { }

	// RVA: 0x1EFF804 Offset: 0x1EFB804 VA: 0x1EFF804 Slot: 36
	public virtual void set_preferredWidth(float value) { }

	// RVA: 0x1EFF878 Offset: 0x1EFB878 VA: 0x1EFF878 Slot: 37
	public virtual float get_preferredHeight() { }

	// RVA: 0x1EFF880 Offset: 0x1EFB880 VA: 0x1EFF880 Slot: 38
	public virtual void set_preferredHeight(float value) { }

	// RVA: 0x1EFF8F4 Offset: 0x1EFB8F4 VA: 0x1EFF8F4 Slot: 39
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1EFF8FC Offset: 0x1EFB8FC VA: 0x1EFF8FC Slot: 40
	public virtual void set_flexibleWidth(float value) { }

	// RVA: 0x1EFF970 Offset: 0x1EFB970 VA: 0x1EFF970 Slot: 41
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1EFF978 Offset: 0x1EFB978 VA: 0x1EFF978 Slot: 42
	public virtual void set_flexibleHeight(float value) { }

	// RVA: 0x1EFF9EC Offset: 0x1EFB9EC VA: 0x1EFF9EC Slot: 43
	public virtual int get_layoutPriority() { }

	// RVA: 0x1EFF9F4 Offset: 0x1EFB9F4 VA: 0x1EFF9F4 Slot: 44
	public virtual void set_layoutPriority(int value) { }

	// RVA: 0x1EFFA68 Offset: 0x1EFBA68 VA: 0x1EFFA68
	protected void .ctor() { }

	// RVA: 0x1EFFA88 Offset: 0x1EFBA88 VA: 0x1EFFA88 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1EFFAA4 Offset: 0x1EFBAA4 VA: 0x1EFFAA4 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1EFFAA8 Offset: 0x1EFBAA8 VA: 0x1EFFAA8 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1EFFAC4 Offset: 0x1EFBAC4 VA: 0x1EFFAC4 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1EFFAC8 Offset: 0x1EFBAC8 VA: 0x1EFFAC8 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x1EFF644 Offset: 0x1EFB644 VA: 0x1EFF644
	protected void SetDirty() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LayoutGroup.<DelayedSetDirty>d__57 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7303
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public RectTransform rectTransform; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1F0005C Offset: 0x1EFC05C VA: 0x1F0005C
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1F00084 Offset: 0x1EFC084 VA: 0x1F00084 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1F00088 Offset: 0x1EFC088 VA: 0x1F00088 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1F00128 Offset: 0x1EFC128 VA: 0x1F00128 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1F00130 Offset: 0x1EFC130 VA: 0x1F00130 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1F00168 Offset: 0x1EFC168 VA: 0x1F00168 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.UI
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public abstract class LayoutGroup : UIBehaviour, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 7304
{
	// Fields
	[SerializeField]
	protected RectOffset m_Padding; // 0x20
	[SerializeField]
	protected TextAnchor m_ChildAlignment; // 0x28
	private RectTransform m_Rect; // 0x30
	protected DrivenRectTransformTracker m_Tracker; // 0x38
	private Vector2 m_TotalMinSize; // 0x3C
	private Vector2 m_TotalPreferredSize; // 0x44
	private Vector2 m_TotalFlexibleSize; // 0x4C
	private List<RectTransform> m_RectChildren; // 0x58

	// Properties
	public RectOffset padding { get; set; }
	public TextAnchor childAlignment { get; set; }
	protected RectTransform rectTransform { get; }
	protected List<RectTransform> rectChildren { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }
	private bool isRootLayoutGroup { get; }

	// Methods

	// RVA: 0x1EFFACC Offset: 0x1EFBACC VA: 0x1EFFACC
	public RectOffset get_padding() { }

	// RVA: 0x1EFFAD4 Offset: 0x1EFBAD4 VA: 0x1EFFAD4
	public void set_padding(RectOffset value) { }

	// RVA: 0x1EFFB30 Offset: 0x1EFBB30 VA: 0x1EFFB30
	public TextAnchor get_childAlignment() { }

	// RVA: 0x1EFFB38 Offset: 0x1EFBB38 VA: 0x1EFFB38
	public void set_childAlignment(TextAnchor value) { }

	// RVA: 0x1EFD854 Offset: 0x1EF9854 VA: 0x1EFD854
	protected RectTransform get_rectTransform() { }

	// RVA: 0x1EFFB94 Offset: 0x1EFBB94 VA: 0x1EFFB94
	protected List<RectTransform> get_rectChildren() { }

	// RVA: 0x1EFD20C Offset: 0x1EF920C VA: 0x1EFD20C Slot: 28
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: -1 Offset: -1 Slot: 29
	public abstract void CalculateLayoutInputVertical();

	// RVA: 0x1EFFB9C Offset: 0x1EFBB9C VA: 0x1EFFB9C Slot: 30
	public virtual float get_minWidth() { }

	// RVA: 0x1EFFBA4 Offset: 0x1EFBBA4 VA: 0x1EFFBA4 Slot: 31
	public virtual float get_preferredWidth() { }

	// RVA: 0x1EFFBAC Offset: 0x1EFBBAC VA: 0x1EFFBAC Slot: 32
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1EFFBB4 Offset: 0x1EFBBB4 VA: 0x1EFFBB4 Slot: 33
	public virtual float get_minHeight() { }

	// RVA: 0x1EFFBBC Offset: 0x1EFBBBC VA: 0x1EFFBBC Slot: 34
	public virtual float get_preferredHeight() { }

	// RVA: 0x1EFFBC4 Offset: 0x1EFBBC4 VA: 0x1EFFBC4 Slot: 35
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1EFFBCC Offset: 0x1EFBBCC VA: 0x1EFFBCC Slot: 36
	public virtual int get_layoutPriority() { }

	// RVA: -1 Offset: -1 Slot: 37
	public abstract void SetLayoutHorizontal();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract void SetLayoutVertical();

	// RVA: 0x1EFCEF0 Offset: 0x1EF8EF0 VA: 0x1EFCEF0
	protected void .ctor() { }

	// RVA: 0x1EFFBD4 Offset: 0x1EFBBD4 VA: 0x1EFFBD4 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1EFFCE0 Offset: 0x1EFBCE0 VA: 0x1EFFCE0 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1EFFD78 Offset: 0x1EFBD78 VA: 0x1EFFD78 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1EFF550 Offset: 0x1EFB550 VA: 0x1EFF550
	protected float GetTotalMinSize(int axis) { }

	// RVA: 0x1EFF478 Offset: 0x1EFB478 VA: 0x1EFF478
	protected float GetTotalPreferredSize(int axis) { }

	// RVA: 0x1EFF4E4 Offset: 0x1EFB4E4 VA: 0x1EFF4E4
	protected float GetTotalFlexibleSize(int axis) { }

	// RVA: 0x1EFE058 Offset: 0x1EFA058 VA: 0x1EFE058
	protected float GetStartOffset(int axis, float requiredSpaceWithoutPadding) { }

	// RVA: 0x1EFEFDC Offset: 0x1EFAFDC VA: 0x1EFEFDC
	protected float GetAlignmentOnAxis(int axis) { }

	// RVA: 0x1EFD5C4 Offset: 0x1EF95C4 VA: 0x1EFD5C4
	protected void SetLayoutInputForAxis(float totalMin, float totalPreferred, float totalFlexible, int axis) { }

	// RVA: 0x1EFFD7C Offset: 0x1EFBD7C VA: 0x1EFFD7C
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos) { }

	// RVA: 0x1EFF254 Offset: 0x1EFB254 VA: 0x1EFF254
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float scaleFactor) { }

	// RVA: 0x1EFE1A8 Offset: 0x1EFA1A8 VA: 0x1EFE1A8
	protected void SetChildAlongAxis(RectTransform rect, int axis, float pos, float size) { }

	// RVA: 0x1EFF014 Offset: 0x1EFB014 VA: 0x1EFF014
	protected void SetChildAlongAxisWithScale(RectTransform rect, int axis, float pos, float size, float scaleFactor) { }

	// RVA: 0x1EFFE24 Offset: 0x1EFBE24 VA: 0x1EFFE24
	private bool get_isRootLayoutGroup() { }

	// RVA: 0x1EFFF50 Offset: 0x1EFBF50 VA: 0x1EFFF50 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1EFFF80 Offset: 0x1EFBF80 VA: 0x1EFFF80 Slot: 39
	protected virtual void OnTransformChildrenChanged() { }

	// RVA: 0x1EFFF84 Offset: 0x1EFBF84 VA: 0x1EFFF84 Slot: 40
	protected virtual void OnChildRectTransformDimensionsChange() { }

	// RVA: -1 Offset: -1
	protected void SetProperty<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111D230 Offset: 0x1119230 VA: 0x111D230
	|-LayoutGroup.SetProperty<bool>
	|
	|-RVA: 0x111D2D0 Offset: 0x11192D0 VA: 0x111D2D0
	|-LayoutGroup.SetProperty<int>
	|
	|-RVA: 0x111D348 Offset: 0x1119348 VA: 0x111D348
	|-LayoutGroup.SetProperty<Int32Enum>
	|
	|-RVA: 0x111D3F8 Offset: 0x11193F8 VA: 0x111D3F8
	|-LayoutGroup.SetProperty<object>
	|
	|-RVA: 0x111D464 Offset: 0x1119464 VA: 0x111D464
	|-LayoutGroup.SetProperty<float>
	|
	|-RVA: 0x111D4DC Offset: 0x11194DC VA: 0x111D4DC
	|-LayoutGroup.SetProperty<Vector2>
	|
	|-RVA: 0x111D5BC Offset: 0x11195BC VA: 0x111D5BC
	|-LayoutGroup.SetProperty<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1EFFC0C Offset: 0x1EFBC0C VA: 0x1EFFC0C
	protected void SetDirty() { }

	[IteratorStateMachine(typeof(LayoutGroup.<DelayedSetDirty>d__57))]
	// RVA: 0x1EFFFF0 Offset: 0x1EFBFF0 VA: 0x1EFFFF0
	private IEnumerator DelayedSetDirty(RectTransform rectTransform) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LayoutRebuilder.<>c // TypeDefIndex: 7305
{
	// Fields
	public static readonly LayoutRebuilder.<>c <>9; // 0x0
	public static Predicate<Component> <>9__10_0; // 0x8
	public static UnityAction<Component> <>9__12_0; // 0x10
	public static UnityAction<Component> <>9__12_1; // 0x18
	public static UnityAction<Component> <>9__12_2; // 0x20
	public static UnityAction<Component> <>9__12_3; // 0x28

	// Methods

	// RVA: 0x1F0140C Offset: 0x1EFD40C VA: 0x1F0140C
	private static void .cctor() { }

	// RVA: 0x1F01474 Offset: 0x1EFD474 VA: 0x1F01474
	public void .ctor() { }

	// RVA: 0x1F0147C Offset: 0x1EFD47C VA: 0x1F0147C
	internal LayoutRebuilder <.cctor>b__5_0() { }

	// RVA: 0x1F014D0 Offset: 0x1EFD4D0 VA: 0x1F014D0
	internal void <.cctor>b__5_1(LayoutRebuilder x) { }

	// RVA: 0x1F014FC Offset: 0x1EFD4FC VA: 0x1F014FC
	internal bool <StripDisabledBehavioursFromList>b__10_0(Component e) { }

	// RVA: 0x1F01588 Offset: 0x1EFD588 VA: 0x1F01588
	internal void <Rebuild>b__12_0(Component e) { }

	// RVA: 0x1F01644 Offset: 0x1EFD644 VA: 0x1F01644
	internal void <Rebuild>b__12_1(Component e) { }

	// RVA: 0x1F01700 Offset: 0x1EFD700 VA: 0x1F01700
	internal void <Rebuild>b__12_2(Component e) { }

	// RVA: 0x1F017C0 Offset: 0x1EFD7C0 VA: 0x1F017C0
	internal void <Rebuild>b__12_3(Component e) { }
}

// Namespace: UnityEngine.UI
public class LayoutRebuilder : ICanvasElement // TypeDefIndex: 7306
{
	// Fields
	private RectTransform m_ToRebuild; // 0x10
	private int m_CachedHashFromTransform; // 0x18
	private static ObjectPool<LayoutRebuilder> s_Rebuilders; // 0x0

	// Properties
	public Transform transform { get; }

	// Methods

	// RVA: 0x1F00170 Offset: 0x1EFC170 VA: 0x1F00170
	private void Initialize(RectTransform controller) { }

	// RVA: 0x1F001B0 Offset: 0x1EFC1B0 VA: 0x1F001B0
	private void Clear() { }

	// RVA: 0x1F001D4 Offset: 0x1EFC1D4 VA: 0x1F001D4
	private static void .cctor() { }

	// RVA: 0x1F003C0 Offset: 0x1EFC3C0 VA: 0x1F003C0
	private static void ReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x1F00414 Offset: 0x1EFC414 VA: 0x1F00414 Slot: 5
	public Transform get_transform() { }

	// RVA: 0x1F0041C Offset: 0x1EFC41C VA: 0x1F0041C Slot: 8
	public bool IsDestroyed() { }

	// RVA: 0x1F0047C Offset: 0x1EFC47C VA: 0x1F0047C
	private static void StripDisabledBehavioursFromList(List<Component> components) { }

	// RVA: 0x1F0057C Offset: 0x1EFC57C VA: 0x1F0057C
	public static void ForceRebuildLayoutImmediate(RectTransform layoutRoot) { }

	// RVA: 0x1F00644 Offset: 0x1EFC644 VA: 0x1F00644 Slot: 4
	public void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1F00BD4 Offset: 0x1EFCBD4 VA: 0x1F00BD4
	private void PerformLayoutControl(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x1F00910 Offset: 0x1EFC910 VA: 0x1F00910
	private void PerformLayoutCalculation(RectTransform rect, UnityAction<Component> action) { }

	// RVA: 0x1EFB7F0 Offset: 0x1EF77F0 VA: 0x1EFB7F0
	public static void MarkLayoutForRebuild(RectTransform rect) { }

	// RVA: 0x1F00F90 Offset: 0x1EFCF90 VA: 0x1F00F90
	private static bool ValidController(RectTransform layoutRoot, List<Component> comps) { }

	// RVA: 0x1F01178 Offset: 0x1EFD178 VA: 0x1F01178
	private static void MarkLayoutRootForRebuild(RectTransform controller) { }

	// RVA: 0x1F012BC Offset: 0x1EFD2BC VA: 0x1F012BC Slot: 6
	public void LayoutComplete() { }

	// RVA: 0x1F0133C Offset: 0x1EFD33C VA: 0x1F0133C Slot: 7
	public void GraphicUpdateComplete() { }

	// RVA: 0x1F01340 Offset: 0x1EFD340 VA: 0x1F01340 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1F01348 Offset: 0x1EFD348 VA: 0x1F01348 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F01398 Offset: 0x1EFD398 VA: 0x1F01398 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F01404 Offset: 0x1EFD404 VA: 0x1F01404
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LayoutUtility.<>c // TypeDefIndex: 7307
{
	// Fields
	public static readonly LayoutUtility.<>c <>9; // 0x0
	public static Func<ILayoutElement, float> <>9__3_0; // 0x8
	public static Func<ILayoutElement, float> <>9__4_0; // 0x10
	public static Func<ILayoutElement, float> <>9__4_1; // 0x18
	public static Func<ILayoutElement, float> <>9__5_0; // 0x20
	public static Func<ILayoutElement, float> <>9__6_0; // 0x28
	public static Func<ILayoutElement, float> <>9__7_0; // 0x30
	public static Func<ILayoutElement, float> <>9__7_1; // 0x38
	public static Func<ILayoutElement, float> <>9__8_0; // 0x40

	// Methods

	// RVA: 0x1F022B8 Offset: 0x1EFE2B8 VA: 0x1F022B8
	private static void .cctor() { }

	// RVA: 0x1F02320 Offset: 0x1EFE320 VA: 0x1F02320
	public void .ctor() { }

	// RVA: 0x1F02328 Offset: 0x1EFE328 VA: 0x1F02328
	internal float <GetMinWidth>b__3_0(ILayoutElement e) { }

	// RVA: 0x1F023C8 Offset: 0x1EFE3C8 VA: 0x1F023C8
	internal float <GetPreferredWidth>b__4_0(ILayoutElement e) { }

	// RVA: 0x1F02468 Offset: 0x1EFE468 VA: 0x1F02468
	internal float <GetPreferredWidth>b__4_1(ILayoutElement e) { }

	// RVA: 0x1F02508 Offset: 0x1EFE508 VA: 0x1F02508
	internal float <GetFlexibleWidth>b__5_0(ILayoutElement e) { }

	// RVA: 0x1F025A8 Offset: 0x1EFE5A8 VA: 0x1F025A8
	internal float <GetMinHeight>b__6_0(ILayoutElement e) { }

	// RVA: 0x1F02648 Offset: 0x1EFE648 VA: 0x1F02648
	internal float <GetPreferredHeight>b__7_0(ILayoutElement e) { }

	// RVA: 0x1F026E8 Offset: 0x1EFE6E8 VA: 0x1F026E8
	internal float <GetPreferredHeight>b__7_1(ILayoutElement e) { }

	// RVA: 0x1F02788 Offset: 0x1EFE788 VA: 0x1F02788
	internal float <GetFlexibleHeight>b__8_0(ILayoutElement e) { }
}

// Namespace: UnityEngine.UI
public static class LayoutUtility // TypeDefIndex: 7308
{
	// Methods

	// RVA: 0x1EFCBD8 Offset: 0x1EF8BD8 VA: 0x1EFCBD8
	public static float GetMinSize(RectTransform rect, int axis) { }

	// RVA: 0x1EFCBE4 Offset: 0x1EF8BE4 VA: 0x1EFCBE4
	public static float GetPreferredSize(RectTransform rect, int axis) { }

	// RVA: 0x1EFF5BC Offset: 0x1EFB5BC VA: 0x1EFF5BC
	public static float GetFlexibleSize(RectTransform rect, int axis) { }

	// RVA: 0x1F01970 Offset: 0x1EFD970 VA: 0x1F01970
	public static float GetMinWidth(RectTransform rect) { }

	// RVA: 0x1F01C08 Offset: 0x1EFDC08 VA: 0x1F01C08
	public static float GetPreferredWidth(RectTransform rect) { }

	// RVA: 0x1F01EA0 Offset: 0x1EFDEA0 VA: 0x1F01EA0
	public static float GetFlexibleWidth(RectTransform rect) { }

	// RVA: 0x1F01880 Offset: 0x1EFD880 VA: 0x1F01880
	public static float GetMinHeight(RectTransform rect) { }

	// RVA: 0x1F01A60 Offset: 0x1EFDA60 VA: 0x1F01A60
	public static float GetPreferredHeight(RectTransform rect) { }

	// RVA: 0x1F01DB0 Offset: 0x1EFDDB0 VA: 0x1F01DB0
	public static float GetFlexibleHeight(RectTransform rect) { }

	// RVA: 0x1F01F90 Offset: 0x1EFDF90 VA: 0x1F01F90
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue) { }

	// RVA: 0x1F01FA4 Offset: 0x1EFDFA4 VA: 0x1F01FA4
	public static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("Layout/Vertical Layout Group", 151)]
public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup // TypeDefIndex: 7309
{
	// Methods

	// RVA: 0x1F02828 Offset: 0x1EFE828 VA: 0x1F02828
	protected void .ctor() { }

	// RVA: 0x1F02834 Offset: 0x1EFE834 VA: 0x1F02834 Slot: 28
	public override void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1F02854 Offset: 0x1EFE854 VA: 0x1F02854 Slot: 29
	public override void CalculateLayoutInputVertical() { }

	// RVA: 0x1F02860 Offset: 0x1EFE860 VA: 0x1F02860 Slot: 37
	public override void SetLayoutHorizontal() { }

	// RVA: 0x1F0286C Offset: 0x1EFE86C VA: 0x1F0286C Slot: 38
	public override void SetLayoutVertical() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Mask", 13)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[DisallowMultipleComponent]
public class Mask : UIBehaviour, ICanvasRaycastFilter, IMaterialModifier // TypeDefIndex: 7310
{
	// Fields
	private RectTransform m_RectTransform; // 0x20
	[SerializeField]
	private bool m_ShowMaskGraphic; // 0x28
	private Graphic m_Graphic; // 0x30
	private Material m_MaskMaterial; // 0x38
	private Material m_UnmaskMaterial; // 0x40

	// Properties
	public RectTransform rectTransform { get; }
	public bool showMaskGraphic { get; set; }
	public Graphic graphic { get; }

	// Methods

	// RVA: 0x1F02878 Offset: 0x1EFE878 VA: 0x1F02878
	public RectTransform get_rectTransform() { }

	// RVA: 0x1F028E8 Offset: 0x1EFE8E8 VA: 0x1F028E8
	public bool get_showMaskGraphic() { }

	// RVA: 0x1F028F0 Offset: 0x1EFE8F0 VA: 0x1F028F0
	public void set_showMaskGraphic(bool value) { }

	// RVA: 0x1F029A0 Offset: 0x1EFE9A0 VA: 0x1F029A0
	public Graphic get_graphic() { }

	// RVA: 0x1F02A10 Offset: 0x1EFEA10 VA: 0x1F02A10
	protected void .ctor() { }

	// RVA: 0x1F02A20 Offset: 0x1EFEA20 VA: 0x1F02A20 Slot: 19
	public virtual bool MaskEnabled() { }

	[Obsolete("Not used anymore.")]
	// RVA: 0x1F02AB0 Offset: 0x1EFEAB0 VA: 0x1F02AB0 Slot: 20
	public virtual void OnSiblingGraphicEnabledDisabled() { }

	// RVA: 0x1F02AB4 Offset: 0x1EFEAB4 VA: 0x1F02AB4 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1F02E80 Offset: 0x1EFEE80 VA: 0x1F02E80 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1F03064 Offset: 0x1EFF064 VA: 0x1F03064 Slot: 21
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1F03110 Offset: 0x1EFF110 VA: 0x1F03110 Slot: 22
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }
}

// Namespace: UnityEngine.UI
public class MaskUtilities // TypeDefIndex: 7311
{
	// Methods

	// RVA: 0x1F0380C Offset: 0x1EFF80C VA: 0x1F0380C
	public static void Notify2DMaskStateChanged(Component mask) { }

	// RVA: 0x1F02C28 Offset: 0x1EFEC28 VA: 0x1F02C28
	public static void NotifyStencilStateChanged(Component mask) { }

	// RVA: 0x1F033E4 Offset: 0x1EFF3E4 VA: 0x1F033E4
	public static Transform FindRootSortOverrideCanvas(Transform start) { }

	// RVA: 0x1F03584 Offset: 0x1EFF584 VA: 0x1F03584
	public static int GetStencilDepth(Transform transform, Transform stopAfter) { }

	// RVA: 0x1F03A68 Offset: 0x1EFFA68 VA: 0x1F03A68
	public static bool IsDescendantOrSelf(Transform father, Transform child) { }

	// RVA: 0x1F03BC0 Offset: 0x1EFFBC0 VA: 0x1F03BC0
	public static RectMask2D GetRectMaskForClippable(IClippable clippable) { }

	// RVA: 0x1F03FE0 Offset: 0x1EFFFE0 VA: 0x1F03FE0
	public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks) { }

	// RVA: 0x1F0434C Offset: 0x1F0034C VA: 0x1F0434C
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class MaskableGraphic.CullStateChangedEvent : UnityEvent<bool> // TypeDefIndex: 7312
{
	// Methods

	// RVA: 0x1F04D78 Offset: 0x1F00D78 VA: 0x1F04D78
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
public abstract class MaskableGraphic : Graphic, IClippable, IMaskable, IMaterialModifier // TypeDefIndex: 7313
{
	// Fields
	protected bool m_ShouldRecalculateStencil; // 0xA1
	protected Material m_MaskMaterial; // 0xA8
	private RectMask2D m_ParentMask; // 0xB0
	[SerializeField]
	private bool m_Maskable; // 0xB8
	private bool m_IsMaskingGraphic; // 0xB9
	[EditorBrowsable(1)]
	[Obsolete("Not used anymore.", True)]
	protected bool m_IncludeForMasking; // 0xBA
	[SerializeField]
	private MaskableGraphic.CullStateChangedEvent m_OnCullStateChanged; // 0xC0
	[EditorBrowsable(1)]
	[Obsolete("Not used anymore", True)]
	protected bool m_ShouldRecalculate; // 0xC8
	protected int m_StencilValue; // 0xCC
	private readonly Vector3[] m_Corners; // 0xD0

	// Properties
	public MaskableGraphic.CullStateChangedEvent onCullStateChanged { get; set; }
	public bool maskable { get; set; }
	public bool isMaskingGraphic { get; set; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x1F04354 Offset: 0x1F00354 VA: 0x1F04354
	public MaskableGraphic.CullStateChangedEvent get_onCullStateChanged() { }

	// RVA: 0x1F0435C Offset: 0x1F0035C VA: 0x1F0435C
	public void set_onCullStateChanged(MaskableGraphic.CullStateChangedEvent value) { }

	// RVA: 0x1F04364 Offset: 0x1F00364 VA: 0x1F04364
	public bool get_maskable() { }

	// RVA: 0x1F0436C Offset: 0x1F0036C VA: 0x1F0436C
	public void set_maskable(bool value) { }

	// RVA: 0x1F0439C Offset: 0x1F0039C VA: 0x1F0439C
	public bool get_isMaskingGraphic() { }

	// RVA: 0x1F02C10 Offset: 0x1EFEC10 VA: 0x1F02C10
	public void set_isMaskingGraphic(bool value) { }

	// RVA: 0x1F043A4 Offset: 0x1F003A4 VA: 0x1F043A4 Slot: 58
	public virtual Material GetModifiedMaterial(Material baseMaterial) { }

	// RVA: 0x1F044B4 Offset: 0x1F004B4 VA: 0x1F044B4 Slot: 59
	public virtual void Cull(Rect clipRect, bool validRect) { }

	// RVA: 0x1F0471C Offset: 0x1F0071C VA: 0x1F0471C
	private void UpdateCull(bool cull) { }

	// RVA: 0x1F047FC Offset: 0x1F007FC VA: 0x1F047FC Slot: 60
	public virtual void SetClipRect(Rect clipRect, bool validRect) { }

	// RVA: 0x1F0486C Offset: 0x1F0086C VA: 0x1F0486C Slot: 61
	public virtual void SetClipSoftness(Vector2 clipSoftness) { }

	// RVA: 0x1F048A4 Offset: 0x1F008A4 VA: 0x1F048A4 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1F04A54 Offset: 0x1F00A54 VA: 0x1F04A54 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1F04B10 Offset: 0x1F00B10 VA: 0x1F04B10 Slot: 12
	protected override void OnTransformParentChanged() { }

	[EditorBrowsable(1)]
	[Obsolete("Not used anymore.", True)]
	// RVA: 0x1F04B60 Offset: 0x1F00B60 VA: 0x1F04B60 Slot: 62
	public virtual void ParentMaskStateChanged() { }

	// RVA: 0x1F04B64 Offset: 0x1F00B64 VA: 0x1F04B64 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1F04578 Offset: 0x1F00578 VA: 0x1F04578
	private Rect get_rootCanvasRect() { }

	// RVA: 0x1F048F4 Offset: 0x1F008F4 VA: 0x1F048F4
	private void UpdateClipParent() { }

	// RVA: 0x1F04BB4 Offset: 0x1F00BB4 VA: 0x1F04BB4 Slot: 63
	public virtual void RecalculateClipping() { }

	// RVA: 0x1F04BB8 Offset: 0x1F00BB8 VA: 0x1F04BB8 Slot: 64
	public virtual void RecalculateMasking() { }

	// RVA: 0x1F04C44 Offset: 0x1F00C44 VA: 0x1F04C44 Slot: 46
	public override bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1F04C58 Offset: 0x1F00C58 VA: 0x1F04C58
	protected void .ctor() { }

	// RVA: 0x1F04D30 Offset: 0x1F00D30 VA: 0x1F04D30 Slot: 50
	private GameObject UnityEngine.UI.IClippable.get_gameObject() { }
}

// Namespace: UnityEngine.UI
public interface IMaterialModifier // TypeDefIndex: 7314
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Material GetModifiedMaterial(Material baseMaterial);
}

// Namespace: UnityEngine.UI
internal static class Misc // TypeDefIndex: 7315
{
	// Methods

	// RVA: 0x1F04DC0 Offset: 0x1F00DC0 VA: 0x1F04DC0
	public static void Destroy(Object obj) { }

	// RVA: 0x1F04EE4 Offset: 0x1F00EE4 VA: 0x1F04EE4
	public static void DestroyImmediate(Object obj) { }
}

// Namespace: UnityEngine.UI
internal static class MultipleDisplayUtilities // TypeDefIndex: 7316
{
	// Methods

	// RVA: 0x1F04FBC Offset: 0x1F00FBC VA: 0x1F04FBC
	public static bool GetRelativeMousePositionForDrag(PointerEventData eventData, ref Vector2 position) { }

	// RVA: 0x1F054A4 Offset: 0x1F014A4 VA: 0x1F054A4
	internal static Vector3 GetRelativeMousePositionForRaycast(PointerEventData eventData) { }

	// RVA: 0x1F05028 Offset: 0x1F01028 VA: 0x1F05028
	public static Vector3 RelativeMouseAtScaled(Vector2 position, int displayIndex) { }
}

// Namespace: 
[Flags]
public enum Navigation.Mode // TypeDefIndex: 7317
{
	// Fields
	public int value__; // 0x0
	public const Navigation.Mode None = 0;
	public const Navigation.Mode Horizontal = 1;
	public const Navigation.Mode Vertical = 2;
	public const Navigation.Mode Automatic = 3;
	public const Navigation.Mode Explicit = 4;
}

// Namespace: UnityEngine.UI
[Serializable]
public struct Navigation : IEquatable<Navigation> // TypeDefIndex: 7318
{
	// Fields
	[SerializeField]
	private Navigation.Mode m_Mode; // 0x0
	[Tooltip("Enables navigation to wrap around from last to first or first to last element. Does not work for automatic grid navigation")]
	[SerializeField]
	private bool m_WrapAround; // 0x4
	[SerializeField]
	private Selectable m_SelectOnUp; // 0x8
	[SerializeField]
	private Selectable m_SelectOnDown; // 0x10
	[SerializeField]
	private Selectable m_SelectOnLeft; // 0x18
	[SerializeField]
	private Selectable m_SelectOnRight; // 0x20

	// Properties
	public Navigation.Mode mode { get; set; }
	public bool wrapAround { get; set; }
	public Selectable selectOnUp { get; set; }
	public Selectable selectOnDown { get; set; }
	public Selectable selectOnLeft { get; set; }
	public Selectable selectOnRight { get; set; }
	public static Navigation defaultNavigation { get; }

	// Methods

	// RVA: 0x1F0556C Offset: 0x1F0156C VA: 0x1F0556C
	public Navigation.Mode get_mode() { }

	// RVA: 0x1F05574 Offset: 0x1F01574 VA: 0x1F05574
	public void set_mode(Navigation.Mode value) { }

	// RVA: 0x1F0557C Offset: 0x1F0157C VA: 0x1F0557C
	public bool get_wrapAround() { }

	// RVA: 0x1F05584 Offset: 0x1F01584 VA: 0x1F05584
	public void set_wrapAround(bool value) { }

	// RVA: 0x1F0558C Offset: 0x1F0158C VA: 0x1F0558C
	public Selectable get_selectOnUp() { }

	// RVA: 0x1F05594 Offset: 0x1F01594 VA: 0x1F05594
	public void set_selectOnUp(Selectable value) { }

	// RVA: 0x1F0559C Offset: 0x1F0159C VA: 0x1F0559C
	public Selectable get_selectOnDown() { }

	// RVA: 0x1F055A4 Offset: 0x1F015A4 VA: 0x1F055A4
	public void set_selectOnDown(Selectable value) { }

	// RVA: 0x1F055AC Offset: 0x1F015AC VA: 0x1F055AC
	public Selectable get_selectOnLeft() { }

	// RVA: 0x1F055B4 Offset: 0x1F015B4 VA: 0x1F055B4
	public void set_selectOnLeft(Selectable value) { }

	// RVA: 0x1F055BC Offset: 0x1F015BC VA: 0x1F055BC
	public Selectable get_selectOnRight() { }

	// RVA: 0x1F055C4 Offset: 0x1F015C4 VA: 0x1F055C4
	public void set_selectOnRight(Selectable value) { }

	// RVA: 0x1F055CC Offset: 0x1F015CC VA: 0x1F055CC
	public static Navigation get_defaultNavigation() { }

	// RVA: 0x1F055E8 Offset: 0x1F015E8 VA: 0x1F055E8 Slot: 4
	public bool Equals(Navigation other) { }
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(CanvasRenderer))]
[AddComponentMenu("UI/Raw Image", 12)]
public class RawImage : MaskableGraphic // TypeDefIndex: 7319
{
	// Fields
	[FormerlySerializedAs("m_Tex")]
	[SerializeField]
	private Texture m_Texture; // 0xD8
	[SerializeField]
	private Rect m_UVRect; // 0xE0

	// Properties
	public override Texture mainTexture { get; }
	public Texture texture { get; set; }
	public Rect uvRect { get; set; }

	// Methods

	// RVA: 0x1F05700 Offset: 0x1F01700 VA: 0x1F05700
	protected void .ctor() { }

	// RVA: 0x1F05728 Offset: 0x1F01728 VA: 0x1F05728 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x1F058CC Offset: 0x1F018CC VA: 0x1F058CC
	public Texture get_texture() { }

	// RVA: 0x1F058D4 Offset: 0x1F018D4 VA: 0x1F058D4
	public void set_texture(Texture value) { }

	// RVA: 0x1F05990 Offset: 0x1F01990 VA: 0x1F05990
	public Rect get_uvRect() { }

	// RVA: 0x1F0599C Offset: 0x1F0199C VA: 0x1F0599C
	public void set_uvRect(Rect value) { }

	// RVA: 0x1F059E8 Offset: 0x1F019E8 VA: 0x1F059E8 Slot: 45
	public override void SetNativeSize() { }

	// RVA: 0x1F05C98 Offset: 0x1F01C98 VA: 0x1F05C98 Slot: 44
	protected override void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0x1F06294 Offset: 0x1F02294 VA: 0x1F06294 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Rect Mask 2D", 14)]
[ExecuteAlways]
[DisallowMultipleComponent]
[RequireComponent(typeof(RectTransform))]
public class RectMask2D : UIBehaviour, IClipper, ICanvasRaycastFilter // TypeDefIndex: 7320
{
	// Fields
	private readonly RectangularVertexClipper m_VertexClipper; // 0x20
	private RectTransform m_RectTransform; // 0x28
	private HashSet<MaskableGraphic> m_MaskableTargets; // 0x30
	private HashSet<IClippable> m_ClipTargets; // 0x38
	private bool m_ShouldRecalculateClipRects; // 0x40
	private List<RectMask2D> m_Clippers; // 0x48
	private Rect m_LastClipRectCanvasSpace; // 0x50
	private bool m_ForceClip; // 0x60
	[SerializeField]
	private Vector4 m_Padding; // 0x64
	[SerializeField]
	private Vector2Int m_Softness; // 0x74
	private Canvas m_Canvas; // 0x80
	private Vector3[] m_Corners; // 0x88

	// Properties
	public Vector4 padding { get; set; }
	public Vector2Int softness { get; set; }
	internal Canvas Canvas { get; }
	public Rect canvasRect { get; }
	public RectTransform rectTransform { get; }
	private Rect rootCanvasRect { get; }

	// Methods

	// RVA: 0x1F062D0 Offset: 0x1F022D0 VA: 0x1F062D0
	public Vector4 get_padding() { }

	// RVA: 0x1F062DC Offset: 0x1F022DC VA: 0x1F062DC
	public void set_padding(Vector4 value) { }

	// RVA: 0x1F062EC Offset: 0x1F022EC VA: 0x1F062EC
	public Vector2Int get_softness() { }

	// RVA: 0x1F062F4 Offset: 0x1F022F4 VA: 0x1F062F4
	public void set_softness(Vector2Int value) { }

	// RVA: 0x1F06314 Offset: 0x1F02314 VA: 0x1F06314
	internal Canvas get_Canvas() { }

	// RVA: 0x1F0648C Offset: 0x1F0248C VA: 0x1F0648C
	public Rect get_canvasRect() { }

	// RVA: 0x1F064D0 Offset: 0x1F024D0 VA: 0x1F064D0
	public RectTransform get_rectTransform() { }

	// RVA: 0x1F06540 Offset: 0x1F02540 VA: 0x1F06540
	protected void .ctor() { }

	// RVA: 0x1F066E0 Offset: 0x1F026E0 VA: 0x1F066E0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1F06714 Offset: 0x1F02714 VA: 0x1F06714 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1F067E4 Offset: 0x1F027E4 VA: 0x1F067E4 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1F06804 Offset: 0x1F02804 VA: 0x1F06804 Slot: 19
	public virtual bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1F068E0 Offset: 0x1F028E0 VA: 0x1F068E0
	private Rect get_rootCanvasRect() { }

	// RVA: 0x1F069DC Offset: 0x1F029DC VA: 0x1F069DC Slot: 20
	public virtual void PerformClipping() { }

	// RVA: 0x1F07194 Offset: 0x1F03194 VA: 0x1F07194 Slot: 21
	public virtual void UpdateClipSoftness() { }

	// RVA: 0x1F07478 Offset: 0x1F03478 VA: 0x1F07478
	public void AddClippable(IClippable clippable) { }

	// RVA: 0x1F0758C Offset: 0x1F0358C VA: 0x1F0758C
	public void RemoveClippable(IClippable clippable) { }

	// RVA: 0x1F0772C Offset: 0x1F0372C VA: 0x1F0772C Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1F0775C Offset: 0x1F0375C VA: 0x1F0775C Slot: 15
	protected override void OnCanvasHierarchyChanged() { }
}

// Namespace: 
public enum ScrollRect.MovementType // TypeDefIndex: 7321
{
	// Fields
	public int value__; // 0x0
	public const ScrollRect.MovementType Unrestricted = 0;
	public const ScrollRect.MovementType Elastic = 1;
	public const ScrollRect.MovementType Clamped = 2;
}

// Namespace: 
public enum ScrollRect.ScrollbarVisibility // TypeDefIndex: 7322
{
	// Fields
	public int value__; // 0x0
	public const ScrollRect.ScrollbarVisibility Permanent = 0;
	public const ScrollRect.ScrollbarVisibility AutoHide = 1;
	public const ScrollRect.ScrollbarVisibility AutoHideAndExpandViewport = 2;
}

// Namespace: 
[Serializable]
public class ScrollRect.ScrollRectEvent : UnityEvent<Vector2> // TypeDefIndex: 7323
{
	// Methods

	// RVA: 0x1F07FE4 Offset: 0x1F03FE4 VA: 0x1F07FE4
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Scroll Rect", 37)]
[SelectionBase]
[ExecuteAlways]
[DisallowMultipleComponent]
[RequireComponent(typeof(RectTransform))]
public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 7324
{
	// Fields
	[SerializeField]
	private RectTransform m_Content; // 0x20
	[SerializeField]
	private bool m_Horizontal; // 0x28
	[SerializeField]
	private bool m_Vertical; // 0x29
	[SerializeField]
	private ScrollRect.MovementType m_MovementType; // 0x2C
	[SerializeField]
	private float m_Elasticity; // 0x30
	[SerializeField]
	private bool m_Inertia; // 0x34
	[SerializeField]
	private float m_DecelerationRate; // 0x38
	[SerializeField]
	private float m_ScrollSensitivity; // 0x3C
	[SerializeField]
	private RectTransform m_Viewport; // 0x40
	[SerializeField]
	private Scrollbar m_HorizontalScrollbar; // 0x48
	[SerializeField]
	private Scrollbar m_VerticalScrollbar; // 0x50
	[SerializeField]
	private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility; // 0x58
	[SerializeField]
	private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility; // 0x5C
	[SerializeField]
	private float m_HorizontalScrollbarSpacing; // 0x60
	[SerializeField]
	private float m_VerticalScrollbarSpacing; // 0x64
	[SerializeField]
	private ScrollRect.ScrollRectEvent m_OnValueChanged; // 0x68
	private Vector2 m_PointerStartLocalCursor; // 0x70
	protected Vector2 m_ContentStartPosition; // 0x78
	private RectTransform m_ViewRect; // 0x80
	protected Bounds m_ContentBounds; // 0x88
	private Bounds m_ViewBounds; // 0xA0
	private Vector2 m_Velocity; // 0xB8
	private bool m_Dragging; // 0xC0
	private bool m_Scrolling; // 0xC1
	private Vector2 m_PrevPosition; // 0xC4
	private Bounds m_PrevContentBounds; // 0xCC
	private Bounds m_PrevViewBounds; // 0xE4
	private bool m_HasRebuiltLayout; // 0xFC
	private bool m_HSliderExpand; // 0xFD
	private bool m_VSliderExpand; // 0xFE
	private float m_HSliderHeight; // 0x100
	private float m_VSliderWidth; // 0x104
	private RectTransform m_Rect; // 0x108
	private RectTransform m_HorizontalScrollbarRect; // 0x110
	private RectTransform m_VerticalScrollbarRect; // 0x118
	private DrivenRectTransformTracker m_Tracker; // 0x120
	private readonly Vector3[] m_Corners; // 0x128

	// Properties
	public RectTransform content { get; set; }
	public bool horizontal { get; set; }
	public bool vertical { get; set; }
	public ScrollRect.MovementType movementType { get; set; }
	public float elasticity { get; set; }
	public bool inertia { get; set; }
	public float decelerationRate { get; set; }
	public float scrollSensitivity { get; set; }
	public RectTransform viewport { get; set; }
	public Scrollbar horizontalScrollbar { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
	public ScrollRect.ScrollbarVisibility verticalScrollbarVisibility { get; set; }
	public float horizontalScrollbarSpacing { get; set; }
	public float verticalScrollbarSpacing { get; set; }
	public ScrollRect.ScrollRectEvent onValueChanged { get; set; }
	protected RectTransform viewRect { get; }
	public Vector2 velocity { get; set; }
	private RectTransform rectTransform { get; }
	public Vector2 normalizedPosition { get; set; }
	public float horizontalNormalizedPosition { get; set; }
	public float verticalNormalizedPosition { get; set; }
	private bool hScrollingNeeded { get; }
	private bool vScrollingNeeded { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x1F0778C Offset: 0x1F0378C VA: 0x1F0778C
	public RectTransform get_content() { }

	// RVA: 0x1F07794 Offset: 0x1F03794 VA: 0x1F07794
	public void set_content(RectTransform value) { }

	// RVA: 0x1F0779C Offset: 0x1F0379C VA: 0x1F0779C
	public bool get_horizontal() { }

	// RVA: 0x1F077A4 Offset: 0x1F037A4 VA: 0x1F077A4
	public void set_horizontal(bool value) { }

	// RVA: 0x1F077AC Offset: 0x1F037AC VA: 0x1F077AC
	public bool get_vertical() { }

	// RVA: 0x1F077B4 Offset: 0x1F037B4 VA: 0x1F077B4
	public void set_vertical(bool value) { }

	// RVA: 0x1F077BC Offset: 0x1F037BC VA: 0x1F077BC
	public ScrollRect.MovementType get_movementType() { }

	// RVA: 0x1F077C4 Offset: 0x1F037C4 VA: 0x1F077C4
	public void set_movementType(ScrollRect.MovementType value) { }

	// RVA: 0x1F077CC Offset: 0x1F037CC VA: 0x1F077CC
	public float get_elasticity() { }

	// RVA: 0x1F077D4 Offset: 0x1F037D4 VA: 0x1F077D4
	public void set_elasticity(float value) { }

	// RVA: 0x1F077DC Offset: 0x1F037DC VA: 0x1F077DC
	public bool get_inertia() { }

	// RVA: 0x1F077E4 Offset: 0x1F037E4 VA: 0x1F077E4
	public void set_inertia(bool value) { }

	// RVA: 0x1F077EC Offset: 0x1F037EC VA: 0x1F077EC
	public float get_decelerationRate() { }

	// RVA: 0x1F077F4 Offset: 0x1F037F4 VA: 0x1F077F4
	public void set_decelerationRate(float value) { }

	// RVA: 0x1F077FC Offset: 0x1F037FC VA: 0x1F077FC
	public float get_scrollSensitivity() { }

	// RVA: 0x1F07804 Offset: 0x1F03804 VA: 0x1F07804
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x1F0780C Offset: 0x1F0380C VA: 0x1F0780C
	public RectTransform get_viewport() { }

	// RVA: 0x1F07814 Offset: 0x1F03814 VA: 0x1F07814
	public void set_viewport(RectTransform value) { }

	// RVA: 0x1F078F8 Offset: 0x1F038F8 VA: 0x1F078F8
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x1F07900 Offset: 0x1F03900 VA: 0x1F07900
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x1F07A98 Offset: 0x1F03A98 VA: 0x1F07A98
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x1F07AA0 Offset: 0x1F03AA0 VA: 0x1F07AA0
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x1F07C38 Offset: 0x1F03C38 VA: 0x1F07C38
	public ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x1F07C40 Offset: 0x1F03C40 VA: 0x1F07C40
	public void set_horizontalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x1F07C48 Offset: 0x1F03C48 VA: 0x1F07C48
	public ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x1F07C50 Offset: 0x1F03C50 VA: 0x1F07C50
	public void set_verticalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x1F07C58 Offset: 0x1F03C58 VA: 0x1F07C58
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x1F07C60 Offset: 0x1F03C60 VA: 0x1F07C60
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x1F07CF0 Offset: 0x1F03CF0 VA: 0x1F07CF0
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x1F07CF8 Offset: 0x1F03CF8 VA: 0x1F07CF8
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x1F07D00 Offset: 0x1F03D00 VA: 0x1F07D00
	public ScrollRect.ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x1F07D08 Offset: 0x1F03D08 VA: 0x1F07D08
	public void set_onValueChanged(ScrollRect.ScrollRectEvent value) { }

	// RVA: 0x1F07D10 Offset: 0x1F03D10 VA: 0x1F07D10
	protected RectTransform get_viewRect() { }

	// RVA: 0x1F07E20 Offset: 0x1F03E20 VA: 0x1F07E20
	public Vector2 get_velocity() { }

	// RVA: 0x1F07E28 Offset: 0x1F03E28 VA: 0x1F07E28
	public void set_velocity(Vector2 value) { }

	// RVA: 0x1F07E30 Offset: 0x1F03E30 VA: 0x1F07E30
	private RectTransform get_rectTransform() { }

	// RVA: 0x1F07ECC Offset: 0x1F03ECC VA: 0x1F07ECC
	protected void .ctor() { }

	// RVA: 0x1F0802C Offset: 0x1F0402C VA: 0x1F0802C Slot: 38
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1F089D0 Offset: 0x1F049D0 VA: 0x1F089D0 Slot: 39
	public virtual void LayoutComplete() { }

	// RVA: 0x1F089D4 Offset: 0x1F049D4 VA: 0x1F089D4 Slot: 40
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1F080B4 Offset: 0x1F040B4 VA: 0x1F080B4
	private void UpdateCachedData() { }

	// RVA: 0x1F089D8 Offset: 0x1F049D8 VA: 0x1F089D8 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1F08B94 Offset: 0x1F04B94 VA: 0x1F08B94 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1F08DC4 Offset: 0x1F04DC4 VA: 0x1F08DC4 Slot: 9
	public override bool IsActive() { }

	// RVA: 0x1F08E44 Offset: 0x1F04E44 VA: 0x1F08E44
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x1F08EB8 Offset: 0x1F04EB8 VA: 0x1F08EB8 Slot: 41
	public virtual void StopMovement() { }

	// RVA: 0x1F08F08 Offset: 0x1F04F08 VA: 0x1F08F08 Slot: 42
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x1F090A8 Offset: 0x1F050A8 VA: 0x1F090A8 Slot: 43
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1F09108 Offset: 0x1F05108 VA: 0x1F09108 Slot: 44
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1F09234 Offset: 0x1F05234 VA: 0x1F09234 Slot: 45
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1F09254 Offset: 0x1F05254 VA: 0x1F09254 Slot: 46
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1F09488 Offset: 0x1F05488 VA: 0x1F09488 Slot: 47
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x1F0953C Offset: 0x1F0553C VA: 0x1F0953C Slot: 48
	protected virtual void LateUpdate() { }

	// RVA: 0x1F088F8 Offset: 0x1F048F8 VA: 0x1F088F8
	protected void UpdatePrevData() { }

	// RVA: 0x1F08770 Offset: 0x1F04770 VA: 0x1F08770
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x1F09AEC Offset: 0x1F05AEC VA: 0x1F09AEC
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x1F09DDC Offset: 0x1F05DDC VA: 0x1F09DDC
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x1F09BE4 Offset: 0x1F05BE4 VA: 0x1F09BE4
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x1F09E24 Offset: 0x1F05E24 VA: 0x1F09E24
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x1F09CE4 Offset: 0x1F05CE4 VA: 0x1F09CE4
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x1F09E38 Offset: 0x1F05E38 VA: 0x1F09E38
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x1F09E4C Offset: 0x1F05E4C VA: 0x1F09E4C
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x1F09E98 Offset: 0x1F05E98 VA: 0x1F09E98
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x1F09EE4 Offset: 0x1F05EE4 VA: 0x1F09EE4 Slot: 49
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x1F09450 Offset: 0x1F05450 VA: 0x1F09450
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x1F0A18C Offset: 0x1F0618C VA: 0x1F0A18C Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1F0A190 Offset: 0x1F06190 VA: 0x1F0A190
	private bool get_hScrollingNeeded() { }

	// RVA: 0x1F0A218 Offset: 0x1F06218 VA: 0x1F0A218
	private bool get_vScrollingNeeded() { }

	// RVA: 0x1F0A2A0 Offset: 0x1F062A0 VA: 0x1F0A2A0 Slot: 50
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1F0A2A4 Offset: 0x1F062A4 VA: 0x1F0A2A4 Slot: 51
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1F0A2A8 Offset: 0x1F062A8 VA: 0x1F0A2A8 Slot: 52
	public virtual float get_minWidth() { }

	// RVA: 0x1F0A2B0 Offset: 0x1F062B0 VA: 0x1F0A2B0 Slot: 53
	public virtual float get_preferredWidth() { }

	// RVA: 0x1F0A2B8 Offset: 0x1F062B8 VA: 0x1F0A2B8 Slot: 54
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1F0A2C0 Offset: 0x1F062C0 VA: 0x1F0A2C0 Slot: 55
	public virtual float get_minHeight() { }

	// RVA: 0x1F0A2C8 Offset: 0x1F062C8 VA: 0x1F0A2C8 Slot: 56
	public virtual float get_preferredHeight() { }

	// RVA: 0x1F0A2D0 Offset: 0x1F062D0 VA: 0x1F0A2D0 Slot: 57
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1F0A2D8 Offset: 0x1F062D8 VA: 0x1F0A2D8 Slot: 58
	public virtual int get_layoutPriority() { }

	// RVA: 0x1F0A2E0 Offset: 0x1F062E0 VA: 0x1F0A2E0 Slot: 59
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x1F0A8C0 Offset: 0x1F068C0 VA: 0x1F0A8C0 Slot: 60
	public virtual void SetLayoutVertical() { }

	// RVA: 0x1F09B1C Offset: 0x1F05B1C VA: 0x1F09B1C
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x1F0ABD4 Offset: 0x1F06BD4 VA: 0x1F0ABD4
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x1F0A974 Offset: 0x1F06974 VA: 0x1F0A974
	private void UpdateScrollbarLayout() { }

	// RVA: 0x1F0840C Offset: 0x1F0440C VA: 0x1F0840C
	protected void UpdateBounds() { }

	// RVA: 0x1F0ACF4 Offset: 0x1F06CF4 VA: 0x1F0ACF4
	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	// RVA: 0x1F0A7C0 Offset: 0x1F067C0 VA: 0x1F0A7C0
	private Bounds GetBounds() { }

	// RVA: 0x1F0AD70 Offset: 0x1F06D70 VA: 0x1F0AD70
	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x1F09078 Offset: 0x1F05078 VA: 0x1F09078
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x1F0AEC4 Offset: 0x1F06EC4 VA: 0x1F0AEC4
	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta) { }

	// RVA: 0x1F07C68 Offset: 0x1F03C68 VA: 0x1F07C68
	protected void SetDirty() { }

	// RVA: 0x1F07830 Offset: 0x1F03830 VA: 0x1F07830
	protected void SetDirtyCaching() { }

	// RVA: 0x1F0B008 Offset: 0x1F07008 VA: 0x1F0B008 Slot: 23
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: 
public enum Scrollbar.Direction // TypeDefIndex: 7325
{
	// Fields
	public int value__; // 0x0
	public const Scrollbar.Direction LeftToRight = 0;
	public const Scrollbar.Direction RightToLeft = 1;
	public const Scrollbar.Direction BottomToTop = 2;
	public const Scrollbar.Direction TopToBottom = 3;
}

// Namespace: 
[Serializable]
public class Scrollbar.ScrollEvent : UnityEvent<float> // TypeDefIndex: 7326
{
	// Methods

	// RVA: 0x1F0B488 Offset: 0x1F07488 VA: 0x1F0B488
	public void .ctor() { }
}

// Namespace: 
private enum Scrollbar.Axis // TypeDefIndex: 7327
{
	// Fields
	public int value__; // 0x0
	public const Scrollbar.Axis Horizontal = 0;
	public const Scrollbar.Axis Vertical = 1;
}

// Namespace: 
[CompilerGenerated]
private sealed class Scrollbar.<ClickRepeat>d__59 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7328
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Scrollbar <>4__this; // 0x20
	public Vector2 screenPosition; // 0x28
	public Camera camera; // 0x30

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1F0C580 Offset: 0x1F08580 VA: 0x1F0C580
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1F0CE50 Offset: 0x1F08E50 VA: 0x1F0CE50 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1F0CE54 Offset: 0x1F08E54 VA: 0x1F0CE54 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1F0CF70 Offset: 0x1F08F70 VA: 0x1F0CF70 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1F0CF78 Offset: 0x1F08F78 VA: 0x1F0CF78 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1F0CFB0 Offset: 0x1F08FB0 VA: 0x1F0CFB0 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Scrollbar", 36)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 7329
{
	// Fields
	[SerializeField]
	private RectTransform m_HandleRect; // 0x100
	[SerializeField]
	private Scrollbar.Direction m_Direction; // 0x108
	[Range(0, 1)]
	[SerializeField]
	private float m_Value; // 0x10C
	[Range(0, 1)]
	[SerializeField]
	private float m_Size; // 0x110
	[Range(0, 11)]
	[SerializeField]
	private int m_NumberOfSteps; // 0x114
	[Space(6)]
	[SerializeField]
	private Scrollbar.ScrollEvent m_OnValueChanged; // 0x118
	private RectTransform m_ContainerRect; // 0x120
	private Vector2 m_Offset; // 0x128
	private DrivenRectTransformTracker m_Tracker; // 0x130
	private Coroutine m_PointerDownRepeat; // 0x138
	private bool isPointerDownAndNotDragging; // 0x140
	private bool m_DelayedUpdateVisuals; // 0x141

	// Properties
	public RectTransform handleRect { get; set; }
	public Scrollbar.Direction direction { get; set; }
	public float value { get; set; }
	public float size { get; set; }
	public int numberOfSteps { get; set; }
	public Scrollbar.ScrollEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Scrollbar.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x1F0B010 Offset: 0x1F07010 VA: 0x1F0B010
	public RectTransform get_handleRect() { }

	// RVA: 0x1F0B018 Offset: 0x1F07018 VA: 0x1F0B018
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x1F0B340 Offset: 0x1F07340 VA: 0x1F0B340
	public Scrollbar.Direction get_direction() { }

	// RVA: 0x1F0B348 Offset: 0x1F07348 VA: 0x1F0B348
	public void set_direction(Scrollbar.Direction value) { }

	// RVA: 0x1F0B3BC Offset: 0x1F073BC VA: 0x1F0B3BC
	protected void .ctor() { }

	// RVA: 0x1F0B60C Offset: 0x1F0760C VA: 0x1F0B60C
	public float get_value() { }

	// RVA: 0x1F09CDC Offset: 0x1F05CDC VA: 0x1F09CDC
	public void set_value(float value) { }

	// RVA: 0x1F0B778 Offset: 0x1F07778 VA: 0x1F0B778 Slot: 47
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x1F0B780 Offset: 0x1F07780 VA: 0x1F0B780
	public float get_size() { }

	// RVA: 0x1F09B5C Offset: 0x1F05B5C VA: 0x1F09B5C
	public void set_size(float value) { }

	// RVA: 0x1F0B788 Offset: 0x1F07788 VA: 0x1F0B788
	public int get_numberOfSteps() { }

	// RVA: 0x1F0B790 Offset: 0x1F07790 VA: 0x1F0B790
	public void set_numberOfSteps(int value) { }

	// RVA: 0x1F0B814 Offset: 0x1F07814 VA: 0x1F0B814
	public Scrollbar.ScrollEvent get_onValueChanged() { }

	// RVA: 0x1F0B81C Offset: 0x1F0781C VA: 0x1F0B81C
	public void set_onValueChanged(Scrollbar.ScrollEvent value) { }

	// RVA: 0x1F0B82C Offset: 0x1F0782C VA: 0x1F0B82C
	private float get_stepSize() { }

	// RVA: 0x1F0B858 Offset: 0x1F07858 VA: 0x1F0B858 Slot: 48
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1F0B85C Offset: 0x1F0785C VA: 0x1F0B85C Slot: 49
	public virtual void LayoutComplete() { }

	// RVA: 0x1F0B860 Offset: 0x1F07860 VA: 0x1F0B860 Slot: 50
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1F0B864 Offset: 0x1F07864 VA: 0x1F0B864 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1F0BB64 Offset: 0x1F07B64 VA: 0x1F0BB64 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1F0BCB8 Offset: 0x1F07CB8 VA: 0x1F0BCB8 Slot: 51
	protected virtual void Update() { }

	// RVA: 0x1F0B094 Offset: 0x1F07094 VA: 0x1F0B094
	private void UpdateCachedReferences() { }

	// RVA: 0x1F0B6B4 Offset: 0x1F076B4 VA: 0x1F0B6B4
	private void Set(float input, bool sendCallback = True) { }

	// RVA: 0x1F0BCCC Offset: 0x1F07CCC VA: 0x1F0BCCC Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1F0BD04 Offset: 0x1F07D04 VA: 0x1F0BD04
	private Scrollbar.Axis get_axis() { }

	// RVA: 0x1F0BD14 Offset: 0x1F07D14 VA: 0x1F0BD14
	private bool get_reverseValue() { }

	// RVA: 0x1F0B184 Offset: 0x1F07184 VA: 0x1F0B184
	private void UpdateVisuals() { }

	// RVA: 0x1F0BD28 Offset: 0x1F07D28 VA: 0x1F0BD28
	private void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x1F0BE3C Offset: 0x1F07E3C VA: 0x1F0BE3C
	private void UpdateDrag(RectTransform containerRect, Vector2 position, Camera camera) { }

	// RVA: 0x1F0BFC4 Offset: 0x1F07FC4 VA: 0x1F0BFC4
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x1F0C034 Offset: 0x1F08034 VA: 0x1F0C034
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1F0C098 Offset: 0x1F08098 VA: 0x1F0C098 Slot: 52
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1F0C24C Offset: 0x1F0824C VA: 0x1F0C24C Slot: 53
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1F0C2DC Offset: 0x1F082DC VA: 0x1F0C2DC Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1F0C540 Offset: 0x1F08540 VA: 0x1F0C540
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(Scrollbar.<ClickRepeat>d__59))]
	// RVA: 0x1F0C4A4 Offset: 0x1F084A4 VA: 0x1F0C4A4
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	// RVA: 0x1F0C5A8 Offset: 0x1F085A8 VA: 0x1F0C5A8 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1F0C5E0 Offset: 0x1F085E0 VA: 0x1F0C5E0 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x1F0C8BC Offset: 0x1F088BC VA: 0x1F0C8BC Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x1F0C9B8 Offset: 0x1F089B8 VA: 0x1F0C9B8 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x1F0CAB4 Offset: 0x1F08AB4 VA: 0x1F0CAB4 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x1F0CBB0 Offset: 0x1F08BB0 VA: 0x1F0CBB0 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x1F0CCAC Offset: 0x1F08CAC VA: 0x1F0CCAC Slot: 54
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1F0CCC0 Offset: 0x1F08CC0 VA: 0x1F0CCC0
	public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts) { }

	// RVA: 0x1F0CE48 Offset: 0x1F08E48 VA: 0x1F0CE48 Slot: 43
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: 
public enum Selectable.Transition // TypeDefIndex: 7330
{
	// Fields
	public int value__; // 0x0
	public const Selectable.Transition None = 0;
	public const Selectable.Transition ColorTint = 1;
	public const Selectable.Transition SpriteSwap = 2;
	public const Selectable.Transition Animation = 3;
}

// Namespace: 
protected enum Selectable.SelectionState // TypeDefIndex: 7331
{
	// Fields
	public int value__; // 0x0
	public const Selectable.SelectionState Normal = 0;
	public const Selectable.SelectionState Highlighted = 1;
	public const Selectable.SelectionState Pressed = 2;
	public const Selectable.SelectionState Selected = 3;
	public const Selectable.SelectionState Disabled = 4;
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Selectable", 35)]
[ExecuteAlways]
[SelectionBase]
[DisallowMultipleComponent]
public class Selectable : UIBehaviour, IMoveHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler // TypeDefIndex: 7332
{
	// Fields
	protected static Selectable[] s_Selectables; // 0x0
	protected static int s_SelectableCount; // 0x8
	private bool m_EnableCalled; // 0x20
	[FormerlySerializedAs("navigation")]
	[SerializeField]
	private Navigation m_Navigation; // 0x28
	[FormerlySerializedAs("transition")]
	[SerializeField]
	private Selectable.Transition m_Transition; // 0x50
	[FormerlySerializedAs("colors")]
	[SerializeField]
	private ColorBlock m_Colors; // 0x54
	[FormerlySerializedAs("spriteState")]
	[SerializeField]
	private SpriteState m_SpriteState; // 0xB0
	[FormerlySerializedAs("animationTriggers")]
	[SerializeField]
	private AnimationTriggers m_AnimationTriggers; // 0xD0
	[Tooltip("Can the Selectable be interacted with?")]
	[SerializeField]
	private bool m_Interactable; // 0xD8
	[FormerlySerializedAs("highlightGraphic")]
	[FormerlySerializedAs("m_HighlightGraphic")]
	[SerializeField]
	private Graphic m_TargetGraphic; // 0xE0
	private bool m_GroupsAllowInteraction; // 0xE8
	protected int m_CurrentIndex; // 0xEC
	[CompilerGenerated]
	private bool <isPointerInside>k__BackingField; // 0xF0
	[CompilerGenerated]
	private bool <isPointerDown>k__BackingField; // 0xF1
	[CompilerGenerated]
	private bool <hasSelection>k__BackingField; // 0xF2
	private readonly List<CanvasGroup> m_CanvasGroupCache; // 0xF8

	// Properties
	public static Selectable[] allSelectablesArray { get; }
	public static int allSelectableCount { get; }
	[Obsolete("Replaced with allSelectablesArray to have better performance when disabling a element", False)]
	public static List<Selectable> allSelectables { get; }
	public Navigation navigation { get; set; }
	public Selectable.Transition transition { get; set; }
	public ColorBlock colors { get; set; }
	public SpriteState spriteState { get; set; }
	public AnimationTriggers animationTriggers { get; set; }
	public Graphic targetGraphic { get; set; }
	public bool interactable { get; set; }
	private bool isPointerInside { get; set; }
	private bool isPointerDown { get; set; }
	private bool hasSelection { get; set; }
	public Image image { get; set; }
	public Animator animator { get; }
	protected Selectable.SelectionState currentSelectionState { get; }

	// Methods

	// RVA: 0x1F0CFB8 Offset: 0x1F08FB8 VA: 0x1F0CFB8
	public static Selectable[] get_allSelectablesArray() { }

	// RVA: 0x1F0D054 Offset: 0x1F09054 VA: 0x1F0D054
	public static int get_allSelectableCount() { }

	// RVA: 0x1F0D0AC Offset: 0x1F090AC VA: 0x1F0D0AC
	public static List<Selectable> get_allSelectables() { }

	// RVA: 0x1F0D148 Offset: 0x1F09148 VA: 0x1F0D148
	public static int AllSelectablesNoAlloc(Selectable[] selectables) { }

	// RVA: 0x1F0D204 Offset: 0x1F09204 VA: 0x1F0D204
	public Navigation get_navigation() { }

	// RVA: 0x1F0D21C Offset: 0x1F0921C VA: 0x1F0D21C
	public void set_navigation(Navigation value) { }

	// RVA: 0x1F0D300 Offset: 0x1F09300 VA: 0x1F0D300
	public Selectable.Transition get_transition() { }

	// RVA: 0x1F0D308 Offset: 0x1F09308 VA: 0x1F0D308
	public void set_transition(Selectable.Transition value) { }

	// RVA: 0x1F0D37C Offset: 0x1F0937C VA: 0x1F0D37C
	public ColorBlock get_colors() { }

	// RVA: 0x1F0D38C Offset: 0x1F0938C VA: 0x1F0D38C
	public void set_colors(ColorBlock value) { }

	// RVA: 0x1F0D40C Offset: 0x1F0940C VA: 0x1F0D40C
	public SpriteState get_spriteState() { }

	// RVA: 0x1F0D418 Offset: 0x1F09418 VA: 0x1F0D418
	public void set_spriteState(SpriteState value) { }

	// RVA: 0x1F0D490 Offset: 0x1F09490 VA: 0x1F0D490
	public AnimationTriggers get_animationTriggers() { }

	// RVA: 0x1F0D498 Offset: 0x1F09498 VA: 0x1F0D498
	public void set_animationTriggers(AnimationTriggers value) { }

	// RVA: 0x1F0D50C Offset: 0x1F0950C VA: 0x1F0D50C
	public Graphic get_targetGraphic() { }

	// RVA: 0x1F0D514 Offset: 0x1F09514 VA: 0x1F0D514
	public void set_targetGraphic(Graphic value) { }

	// RVA: 0x1F0D588 Offset: 0x1F09588 VA: 0x1F0D588
	public bool get_interactable() { }

	// RVA: 0x1F0D590 Offset: 0x1F09590 VA: 0x1F0D590
	public void set_interactable(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F0D6FC Offset: 0x1F096FC VA: 0x1F0D6FC
	private bool get_isPointerInside() { }

	[CompilerGenerated]
	// RVA: 0x1F0D704 Offset: 0x1F09704 VA: 0x1F0D704
	private void set_isPointerInside(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F0D70C Offset: 0x1F0970C VA: 0x1F0D70C
	private bool get_isPointerDown() { }

	[CompilerGenerated]
	// RVA: 0x1F0D714 Offset: 0x1F09714 VA: 0x1F0D714
	private void set_isPointerDown(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F0D71C Offset: 0x1F0971C VA: 0x1F0D71C
	private bool get_hasSelection() { }

	[CompilerGenerated]
	// RVA: 0x1F0D724 Offset: 0x1F09724 VA: 0x1F0D724
	private void set_hasSelection(bool value) { }

	// RVA: 0x1F0B4D0 Offset: 0x1F074D0 VA: 0x1F0B4D0
	protected void .ctor() { }

	// RVA: 0x1F0D72C Offset: 0x1F0972C VA: 0x1F0D72C
	public Image get_image() { }

	// RVA: 0x1F0D7A8 Offset: 0x1F097A8 VA: 0x1F0D7A8
	public void set_image(Image value) { }

	// RVA: 0x1F0D7B0 Offset: 0x1F097B0 VA: 0x1F0D7B0
	public Animator get_animator() { }

	// RVA: 0x1F0D7F8 Offset: 0x1F097F8 VA: 0x1F0D7F8 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1F0D89C Offset: 0x1F0989C VA: 0x1F0D89C Slot: 14
	protected override void OnCanvasGroupChanged() { }

	// RVA: 0x1F0D8D0 Offset: 0x1F098D0 VA: 0x1F0D8D0
	private bool ParentGroupAllowsInteraction() { }

	// RVA: 0x1F0DA48 Offset: 0x1F09A48 VA: 0x1F0DA48 Slot: 24
	public virtual bool IsInteractable() { }

	// RVA: 0x1F0DA68 Offset: 0x1F09A68 VA: 0x1F0DA68 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1F0B894 Offset: 0x1F07894 VA: 0x1F0B894 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1F0DABC Offset: 0x1F09ABC VA: 0x1F0DABC Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1F0D29C Offset: 0x1F0929C VA: 0x1F0D29C
	private void OnSetProperty() { }

	// RVA: 0x1F0BB84 Offset: 0x1F07B84 VA: 0x1F0BB84 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1F0DAE4 Offset: 0x1F09AE4 VA: 0x1F0DAE4
	private void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x1F0DA6C Offset: 0x1F09A6C VA: 0x1F0DA6C
	protected Selectable.SelectionState get_currentSelectionState() { }

	// RVA: 0x1F0DB8C Offset: 0x1F09B8C VA: 0x1F0DB8C Slot: 25
	protected virtual void InstantClearState() { }

	// RVA: 0x1F0DF2C Offset: 0x1F09F2C VA: 0x1F0DF2C Slot: 26
	protected virtual void DoStateTransition(Selectable.SelectionState state, bool instant) { }

	// RVA: 0x1F0E19C Offset: 0x1F0A19C VA: 0x1F0E19C
	public Selectable FindSelectable(Vector3 dir) { }

	// RVA: 0x1F0E638 Offset: 0x1F0A638 VA: 0x1F0E638
	private static Vector3 GetPointOnRectEdge(RectTransform rect, Vector2 dir) { }

	// RVA: 0x1F0E7B8 Offset: 0x1F0A7B8 VA: 0x1F0E7B8
	private void Navigate(AxisEventData eventData, Selectable sel) { }

	// RVA: 0x1F0C8E0 Offset: 0x1F088E0 VA: 0x1F0C8E0 Slot: 27
	public virtual Selectable FindSelectableOnLeft() { }

	// RVA: 0x1F0C9DC Offset: 0x1F089DC VA: 0x1F0C9DC Slot: 28
	public virtual Selectable FindSelectableOnRight() { }

	// RVA: 0x1F0CAD8 Offset: 0x1F08AD8 VA: 0x1F0CAD8 Slot: 29
	public virtual Selectable FindSelectableOnUp() { }

	// RVA: 0x1F0CBD4 Offset: 0x1F08BD4 VA: 0x1F0CBD4 Slot: 30
	public virtual Selectable FindSelectableOnDown() { }

	// RVA: 0x1F0C824 Offset: 0x1F08824 VA: 0x1F0C824 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x1F0DBEC Offset: 0x1F09BEC VA: 0x1F0DBEC
	private void StartColorTween(Color targetColor, bool instant) { }

	// RVA: 0x1F0DCFC Offset: 0x1F09CFC VA: 0x1F0DCFC
	private void DoSpriteSwap(Sprite newSprite) { }

	// RVA: 0x1F0DDA4 Offset: 0x1F09DA4 VA: 0x1F0DDA4
	private void TriggerAnimation(string triggername) { }

	// RVA: 0x1F0E870 Offset: 0x1F0A870 VA: 0x1F0E870
	protected bool IsHighlighted() { }

	// RVA: 0x1F0DB40 Offset: 0x1F09B40 VA: 0x1F0DB40
	protected bool IsPressed() { }

	// RVA: 0x1F0E8CC Offset: 0x1F0A8CC VA: 0x1F0E8CC
	private void EvaluateAndTransitionToSelectionState() { }

	// RVA: 0x1F0C374 Offset: 0x1F08374 VA: 0x1F0C374 Slot: 32
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1F0C5C0 Offset: 0x1F085C0 VA: 0x1F0C5C0 Slot: 33
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1F0E964 Offset: 0x1F0A964 VA: 0x1F0E964 Slot: 34
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1F0E970 Offset: 0x1F0A970 VA: 0x1F0E970 Slot: 35
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x1F0E978 Offset: 0x1F0A978 VA: 0x1F0E978 Slot: 36
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1F0E984 Offset: 0x1F0A984 VA: 0x1F0E984 Slot: 37
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1F0E98C Offset: 0x1F0A98C VA: 0x1F0E98C Slot: 38
	public virtual void Select() { }

	// RVA: 0x1F0EA90 Offset: 0x1F0AA90 VA: 0x1F0EA90
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
internal static class SetPropertyUtility // TypeDefIndex: 7333
{
	// Methods

	// RVA: 0x1F0EB14 Offset: 0x1F0AB14 VA: 0x1F0EB14
	public static bool SetColor(ref Color currentValue, Color newValue) { }

	// RVA: -1 Offset: -1
	public static bool SetStruct<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1148E9C Offset: 0x1144E9C VA: 0x1148E9C
	|-SetPropertyUtility.SetStruct<bool>
	|
	|-RVA: 0x1148F08 Offset: 0x1144F08 VA: 0x1148F08
	|-SetPropertyUtility.SetStruct<char>
	|
	|-RVA: 0x1148F70 Offset: 0x1144F70 VA: 0x1148F70
	|-SetPropertyUtility.SetStruct<ColorBlock>
	|
	|-RVA: 0x1149024 Offset: 0x1145024 VA: 0x1149024
	|-SetPropertyUtility.SetStruct<int>
	|
	|-RVA: 0x114908C Offset: 0x114508C VA: 0x114908C
	|-SetPropertyUtility.SetStruct<Int32Enum>
	|
	|-RVA: 0x11490F4 Offset: 0x11450F4 VA: 0x11490F4
	|-SetPropertyUtility.SetStruct<Navigation>
	|
	|-RVA: 0x11491A4 Offset: 0x11451A4 VA: 0x11491A4
	|-SetPropertyUtility.SetStruct<float>
	|
	|-RVA: 0x1149214 Offset: 0x1145214 VA: 0x1149214
	|-SetPropertyUtility.SetStruct<SpriteState>
	|
	|-RVA: 0x11492AC Offset: 0x11452AC VA: 0x11492AC
	|-SetPropertyUtility.SetStruct<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static bool SetClass<T>(ref T currentValue, T newValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1148E40 Offset: 0x1144E40 VA: 0x1148E40
	|-SetPropertyUtility.SetClass<object>
	*/
}

// Namespace: 
public enum Slider.Direction // TypeDefIndex: 7334
{
	// Fields
	public int value__; // 0x0
	public const Slider.Direction LeftToRight = 0;
	public const Slider.Direction RightToLeft = 1;
	public const Slider.Direction BottomToTop = 2;
	public const Slider.Direction TopToBottom = 3;
}

// Namespace: 
[Serializable]
public class Slider.SliderEvent : UnityEvent<float> // TypeDefIndex: 7335
{
	// Methods

	// RVA: 0x1F0F7A4 Offset: 0x1F0B7A4 VA: 0x1F0F7A4
	public void .ctor() { }
}

// Namespace: 
private enum Slider.Axis // TypeDefIndex: 7336
{
	// Fields
	public int value__; // 0x0
	public const Slider.Axis Horizontal = 0;
	public const Slider.Axis Vertical = 1;
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Slider", 34)]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 7337
{
	// Fields
	[SerializeField]
	private RectTransform m_FillRect; // 0x100
	[SerializeField]
	private RectTransform m_HandleRect; // 0x108
	[Space]
	[SerializeField]
	private Slider.Direction m_Direction; // 0x110
	[SerializeField]
	private float m_MinValue; // 0x114
	[SerializeField]
	private float m_MaxValue; // 0x118
	[SerializeField]
	private bool m_WholeNumbers; // 0x11C
	[SerializeField]
	protected float m_Value; // 0x120
	[Space]
	[SerializeField]
	private Slider.SliderEvent m_OnValueChanged; // 0x128
	private Image m_FillImage; // 0x130
	private Transform m_FillTransform; // 0x138
	private RectTransform m_FillContainerRect; // 0x140
	private Transform m_HandleTransform; // 0x148
	private RectTransform m_HandleContainerRect; // 0x150
	private Vector2 m_Offset; // 0x158
	private DrivenRectTransformTracker m_Tracker; // 0x160
	private bool m_DelayedUpdateVisuals; // 0x161

	// Properties
	public RectTransform fillRect { get; set; }
	public RectTransform handleRect { get; set; }
	public Slider.Direction direction { get; set; }
	public float minValue { get; set; }
	public float maxValue { get; set; }
	public bool wholeNumbers { get; set; }
	public virtual float value { get; set; }
	public float normalizedValue { get; set; }
	public Slider.SliderEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Slider.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x1F0EB60 Offset: 0x1F0AB60 VA: 0x1F0EB60
	public RectTransform get_fillRect() { }

	// RVA: 0x1F0EB68 Offset: 0x1F0AB68 VA: 0x1F0EB68
	public void set_fillRect(RectTransform value) { }

	// RVA: 0x1F0F1E0 Offset: 0x1F0B1E0 VA: 0x1F0F1E0
	public RectTransform get_handleRect() { }

	// RVA: 0x1F0F1E8 Offset: 0x1F0B1E8 VA: 0x1F0F1E8
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x1F0F264 Offset: 0x1F0B264 VA: 0x1F0F264
	public Slider.Direction get_direction() { }

	// RVA: 0x1F0F26C Offset: 0x1F0B26C VA: 0x1F0F26C
	public void set_direction(Slider.Direction value) { }

	// RVA: 0x1F0F2E0 Offset: 0x1F0B2E0 VA: 0x1F0F2E0
	public float get_minValue() { }

	// RVA: 0x1F0F2E8 Offset: 0x1F0B2E8 VA: 0x1F0F2E8
	public void set_minValue(float value) { }

	// RVA: 0x1F0F378 Offset: 0x1F0B378 VA: 0x1F0F378
	public float get_maxValue() { }

	// RVA: 0x1F0F380 Offset: 0x1F0B380 VA: 0x1F0F380
	public void set_maxValue(float value) { }

	// RVA: 0x1F0F410 Offset: 0x1F0B410 VA: 0x1F0F410
	public bool get_wholeNumbers() { }

	// RVA: 0x1F0F418 Offset: 0x1F0B418 VA: 0x1F0F418
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x1F0F4A8 Offset: 0x1F0B4A8 VA: 0x1F0F4A8 Slot: 46
	public virtual float get_value() { }

	// RVA: 0x1F0F548 Offset: 0x1F0B548 VA: 0x1F0F548 Slot: 47
	public virtual void set_value(float value) { }

	// RVA: 0x1F0F55C Offset: 0x1F0B55C VA: 0x1F0F55C Slot: 48
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x1F0F570 Offset: 0x1F0B570 VA: 0x1F0F570
	public float get_normalizedValue() { }

	// RVA: 0x1F0F65C Offset: 0x1F0B65C VA: 0x1F0F65C
	public void set_normalizedValue(float value) { }

	// RVA: 0x1F0F698 Offset: 0x1F0B698 VA: 0x1F0F698
	public Slider.SliderEvent get_onValueChanged() { }

	// RVA: 0x1F0F6A0 Offset: 0x1F0B6A0 VA: 0x1F0F6A0
	public void set_onValueChanged(Slider.SliderEvent value) { }

	// RVA: 0x1F0F6B0 Offset: 0x1F0B6B0 VA: 0x1F0F6B0
	private float get_stepSize() { }

	// RVA: 0x1F0F6DC Offset: 0x1F0B6DC VA: 0x1F0F6DC
	protected void .ctor() { }

	// RVA: 0x1F0F7EC Offset: 0x1F0B7EC VA: 0x1F0F7EC Slot: 49
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1F0F7F0 Offset: 0x1F0B7F0 VA: 0x1F0F7F0 Slot: 50
	public virtual void LayoutComplete() { }

	// RVA: 0x1F0F7F4 Offset: 0x1F0B7F4 VA: 0x1F0F7F4 Slot: 51
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1F0F7F8 Offset: 0x1F0B7F8 VA: 0x1F0F7F8 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1F0F834 Offset: 0x1F0B834 VA: 0x1F0F834 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1F0F854 Offset: 0x1F0B854 VA: 0x1F0F854 Slot: 52
	protected virtual void Update() { }

	// RVA: 0x1F0F890 Offset: 0x1F0B890 VA: 0x1F0F890 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1F0EBE4 Offset: 0x1F0ABE4 VA: 0x1F0EBE4
	private void UpdateCachedReferences() { }

	// RVA: 0x1F0FA64 Offset: 0x1F0BA64 VA: 0x1F0FA64
	private float ClampValue(float input) { }

	// RVA: 0x1F0FB3C Offset: 0x1F0BB3C VA: 0x1F0FB3C Slot: 53
	protected virtual void Set(float input, bool sendCallback = True) { }

	// RVA: 0x1F0FC00 Offset: 0x1F0BC00 VA: 0x1F0FC00 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x1F0FB2C Offset: 0x1F0BB2C VA: 0x1F0FB2C
	private Slider.Axis get_axis() { }

	// RVA: 0x1F0FB18 Offset: 0x1F0BB18 VA: 0x1F0FB18
	private bool get_reverseValue() { }

	// RVA: 0x1F0EF00 Offset: 0x1F0AF00 VA: 0x1F0EF00
	private void UpdateVisuals() { }

	// RVA: 0x1F0FC38 Offset: 0x1F0BC38 VA: 0x1F0FC38
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x1F0FE38 Offset: 0x1F0BE38 VA: 0x1F0FE38
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x1F0FE9C Offset: 0x1F0BE9C VA: 0x1F0FE9C Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1F10064 Offset: 0x1F0C064 VA: 0x1F10064 Slot: 54
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1F100B4 Offset: 0x1F0C0B4 VA: 0x1F100B4 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x1F102FC Offset: 0x1F0C2FC VA: 0x1F102FC Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x1F10320 Offset: 0x1F0C320 VA: 0x1F10320 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x1F10344 Offset: 0x1F0C344 VA: 0x1F10344 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x1F10368 Offset: 0x1F0C368 VA: 0x1F10368 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x1F1038C Offset: 0x1F0C38C VA: 0x1F1038C Slot: 55
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1F103A0 Offset: 0x1F0C3A0 VA: 0x1F103A0
	public void SetDirection(Slider.Direction direction, bool includeRectLayouts) { }

	// RVA: 0x1F10528 Offset: 0x1F0C528 VA: 0x1F10528 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: UnityEngine.UI
[Serializable]
public struct SpriteState : IEquatable<SpriteState> // TypeDefIndex: 7338
{
	// Fields
	[SerializeField]
	private Sprite m_HighlightedSprite; // 0x0
	[SerializeField]
	private Sprite m_PressedSprite; // 0x8
	[FormerlySerializedAs("m_HighlightedSprite")]
	[SerializeField]
	private Sprite m_SelectedSprite; // 0x10
	[SerializeField]
	private Sprite m_DisabledSprite; // 0x18

	// Properties
	public Sprite highlightedSprite { get; set; }
	public Sprite pressedSprite { get; set; }
	public Sprite selectedSprite { get; set; }
	public Sprite disabledSprite { get; set; }

	// Methods

	// RVA: 0x1F10530 Offset: 0x1F0C530 VA: 0x1F10530
	public Sprite get_highlightedSprite() { }

	// RVA: 0x1F10538 Offset: 0x1F0C538 VA: 0x1F10538
	public void set_highlightedSprite(Sprite value) { }

	// RVA: 0x1F10540 Offset: 0x1F0C540 VA: 0x1F10540
	public Sprite get_pressedSprite() { }

	// RVA: 0x1F10548 Offset: 0x1F0C548 VA: 0x1F10548
	public void set_pressedSprite(Sprite value) { }

	// RVA: 0x1F10550 Offset: 0x1F0C550 VA: 0x1F10550
	public Sprite get_selectedSprite() { }

	// RVA: 0x1F10558 Offset: 0x1F0C558 VA: 0x1F10558
	public void set_selectedSprite(Sprite value) { }

	// RVA: 0x1F10560 Offset: 0x1F0C560 VA: 0x1F10560
	public Sprite get_disabledSprite() { }

	// RVA: 0x1F10568 Offset: 0x1F0C568 VA: 0x1F10568
	public void set_disabledSprite(Sprite value) { }

	// RVA: 0x1F10570 Offset: 0x1F0C570 VA: 0x1F10570 Slot: 4
	public bool Equals(SpriteState other) { }
}

// Namespace: 
private class StencilMaterial.MatEntry // TypeDefIndex: 7339
{
	// Fields
	public Material baseMat; // 0x10
	public Material customMat; // 0x18
	public int count; // 0x20
	public int stencilId; // 0x24
	public StencilOp operation; // 0x28
	public CompareFunction compareFunction; // 0x2C
	public int readMask; // 0x30
	public int writeMask; // 0x34
	public bool useAlphaClip; // 0x38
	public ColorWriteMask colorMask; // 0x3C

	// Methods

	// RVA: 0x1F11078 Offset: 0x1F0D078 VA: 0x1F11078
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
public static class StencilMaterial // TypeDefIndex: 7340
{
	// Fields
	private static List<StencilMaterial.MatEntry> m_List; // 0x0

	// Methods

	[EditorBrowsable(1)]
	[Obsolete("Use Material.Add instead.", True)]
	// RVA: 0x1F10678 Offset: 0x1F0C678 VA: 0x1F10678
	public static Material Add(Material baseMat, int stencilID) { }

	// RVA: 0x1F10680 Offset: 0x1F0C680 VA: 0x1F10680
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask) { }

	// RVA: 0x1F10FD0 Offset: 0x1F0CFD0 VA: 0x1F10FD0
	private static void LogWarningWhenNotInBatchmode(string warning, Object context) { }

	// RVA: 0x1F1070C Offset: 0x1F0C70C VA: 0x1F1070C
	public static Material Add(Material baseMat, int stencilID, StencilOp operation, CompareFunction compareFunction, ColorWriteMask colorWriteMask, int readMask, int writeMask) { }

	// RVA: 0x1F11088 Offset: 0x1F0D088 VA: 0x1F11088
	public static void Remove(Material customMat) { }

	// RVA: 0x1F11254 Offset: 0x1F0D254 VA: 0x1F11254
	public static void ClearAll() { }

	// RVA: 0x1F113A0 Offset: 0x1F0D3A0 VA: 0x1F113A0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[RequireComponent(typeof(CanvasRenderer))]
[AddComponentMenu("UI/Legacy/Text", 100)]
public class Text : MaskableGraphic, ILayoutElement // TypeDefIndex: 7341
{
	// Fields
	[SerializeField]
	private FontData m_FontData; // 0xD8
	[TextArea(3, 10)]
	[SerializeField]
	protected string m_Text; // 0xE0
	private TextGenerator m_TextCache; // 0xE8
	private TextGenerator m_TextCacheForLayout; // 0xF0
	protected static Material s_DefaultText; // 0x0
	protected bool m_DisableFontTextureRebuiltCallback; // 0xF8
	private readonly UIVertex[] m_TempVerts; // 0x100

	// Properties
	public TextGenerator cachedTextGenerator { get; }
	public TextGenerator cachedTextGeneratorForLayout { get; }
	public override Texture mainTexture { get; }
	public Font font { get; set; }
	public virtual string text { get; set; }
	public bool supportRichText { get; set; }
	public bool resizeTextForBestFit { get; set; }
	public int resizeTextMinSize { get; set; }
	public int resizeTextMaxSize { get; set; }
	public TextAnchor alignment { get; set; }
	public bool alignByGeometry { get; set; }
	public int fontSize { get; set; }
	public HorizontalWrapMode horizontalOverflow { get; set; }
	public VerticalWrapMode verticalOverflow { get; set; }
	public float lineSpacing { get; set; }
	public FontStyle fontStyle { get; set; }
	public float pixelsPerUnit { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x1F11438 Offset: 0x1F0D438 VA: 0x1F11438
	protected void .ctor() { }

	// RVA: 0x1F114DC Offset: 0x1F0D4DC VA: 0x1F114DC
	public TextGenerator get_cachedTextGenerator() { }

	// RVA: 0x1F11574 Offset: 0x1F0D574 VA: 0x1F11574
	public TextGenerator get_cachedTextGeneratorForLayout() { }

	// RVA: 0x1F115E4 Offset: 0x1F0D5E4 VA: 0x1F115E4 Slot: 35
	public override Texture get_mainTexture() { }

	// RVA: 0x1F117A4 Offset: 0x1F0D7A4 VA: 0x1F117A4
	public void FontTextureChanged() { }

	// RVA: 0x1F1178C Offset: 0x1F0D78C VA: 0x1F1178C
	public Font get_font() { }

	// RVA: 0x1F118B8 Offset: 0x1F0D8B8 VA: 0x1F118B8
	public void set_font(Font value) { }

	// RVA: 0x1F119D4 Offset: 0x1F0D9D4 VA: 0x1F119D4 Slot: 74
	public virtual string get_text() { }

	// RVA: 0x1F119DC Offset: 0x1F0D9DC VA: 0x1F119DC Slot: 75
	public virtual void set_text(string value) { }

	// RVA: 0x1F11AC0 Offset: 0x1F0DAC0 VA: 0x1F11AC0
	public bool get_supportRichText() { }

	// RVA: 0x1F11AD8 Offset: 0x1F0DAD8 VA: 0x1F11AD8
	public void set_supportRichText(bool value) { }

	// RVA: 0x1F11B38 Offset: 0x1F0DB38 VA: 0x1F11B38
	public bool get_resizeTextForBestFit() { }

	// RVA: 0x1F11B50 Offset: 0x1F0DB50 VA: 0x1F11B50
	public void set_resizeTextForBestFit(bool value) { }

	// RVA: 0x1F11BB0 Offset: 0x1F0DBB0 VA: 0x1F11BB0
	public int get_resizeTextMinSize() { }

	// RVA: 0x1F11BC8 Offset: 0x1F0DBC8 VA: 0x1F11BC8
	public void set_resizeTextMinSize(int value) { }

	// RVA: 0x1F11C1C Offset: 0x1F0DC1C VA: 0x1F11C1C
	public int get_resizeTextMaxSize() { }

	// RVA: 0x1F11C34 Offset: 0x1F0DC34 VA: 0x1F11C34
	public void set_resizeTextMaxSize(int value) { }

	// RVA: 0x1F11C88 Offset: 0x1F0DC88 VA: 0x1F11C88
	public TextAnchor get_alignment() { }

	// RVA: 0x1F11CA0 Offset: 0x1F0DCA0 VA: 0x1F11CA0
	public void set_alignment(TextAnchor value) { }

	// RVA: 0x1F11CF4 Offset: 0x1F0DCF4 VA: 0x1F11CF4
	public bool get_alignByGeometry() { }

	// RVA: 0x1F11D0C Offset: 0x1F0DD0C VA: 0x1F11D0C
	public void set_alignByGeometry(bool value) { }

	// RVA: 0x1F11D4C Offset: 0x1F0DD4C VA: 0x1F11D4C
	public int get_fontSize() { }

	// RVA: 0x1F11D64 Offset: 0x1F0DD64 VA: 0x1F11D64
	public void set_fontSize(int value) { }

	// RVA: 0x1F11DB8 Offset: 0x1F0DDB8 VA: 0x1F11DB8
	public HorizontalWrapMode get_horizontalOverflow() { }

	// RVA: 0x1F11DD0 Offset: 0x1F0DDD0 VA: 0x1F11DD0
	public void set_horizontalOverflow(HorizontalWrapMode value) { }

	// RVA: 0x1F11E24 Offset: 0x1F0DE24 VA: 0x1F11E24
	public VerticalWrapMode get_verticalOverflow() { }

	// RVA: 0x1F11E3C Offset: 0x1F0DE3C VA: 0x1F11E3C
	public void set_verticalOverflow(VerticalWrapMode value) { }

	// RVA: 0x1F11E90 Offset: 0x1F0DE90 VA: 0x1F11E90
	public float get_lineSpacing() { }

	// RVA: 0x1F11EA8 Offset: 0x1F0DEA8 VA: 0x1F11EA8
	public void set_lineSpacing(float value) { }

	// RVA: 0x1F11EFC Offset: 0x1F0DEFC VA: 0x1F11EFC
	public FontStyle get_fontStyle() { }

	// RVA: 0x1F11F14 Offset: 0x1F0DF14 VA: 0x1F11F14
	public void set_fontStyle(FontStyle value) { }

	// RVA: 0x1F11F68 Offset: 0x1F0DF68 VA: 0x1F11F68
	public float get_pixelsPerUnit() { }

	// RVA: 0x1F120B0 Offset: 0x1F0E0B0 VA: 0x1F120B0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1F1212C Offset: 0x1F0E12C VA: 0x1F1212C Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1F12190 Offset: 0x1F0E190 VA: 0x1F12190 Slot: 41
	protected override void UpdateGeometry() { }

	// RVA: 0x1F12218 Offset: 0x1F0E218 VA: 0x1F12218
	internal void AssignDefaultFont() { }

	// RVA: 0x1F12288 Offset: 0x1F0E288 VA: 0x1F12288
	internal void AssignDefaultFontIfNecessary() { }

	// RVA: 0x1F12344 Offset: 0x1F0E344 VA: 0x1F12344
	public TextGenerationSettings GetGenerationSettings(Vector2 extents) { }

	// RVA: 0x1F124D8 Offset: 0x1F0E4D8 VA: 0x1F124D8
	public static Vector2 GetTextAnchorPivot(TextAnchor anchor) { }

	// RVA: 0x1F12544 Offset: 0x1F0E544 VA: 0x1F12544 Slot: 44
	protected override void OnPopulateMesh(VertexHelper toFill) { }

	// RVA: 0x1F12BC4 Offset: 0x1F0EBC4 VA: 0x1F12BC4 Slot: 76
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x1F12BC8 Offset: 0x1F0EBC8 VA: 0x1F12BC8 Slot: 77
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0x1F12BCC Offset: 0x1F0EBCC VA: 0x1F12BCC Slot: 78
	public virtual float get_minWidth() { }

	// RVA: 0x1F12BD4 Offset: 0x1F0EBD4 VA: 0x1F12BD4 Slot: 79
	public virtual float get_preferredWidth() { }

	// RVA: 0x1F12C98 Offset: 0x1F0EC98 VA: 0x1F12C98 Slot: 80
	public virtual float get_flexibleWidth() { }

	// RVA: 0x1F12CA0 Offset: 0x1F0ECA0 VA: 0x1F12CA0 Slot: 81
	public virtual float get_minHeight() { }

	// RVA: 0x1F12CA8 Offset: 0x1F0ECA8 VA: 0x1F12CA8 Slot: 82
	public virtual float get_preferredHeight() { }

	// RVA: 0x1F12D38 Offset: 0x1F0ED38 VA: 0x1F12D38 Slot: 83
	public virtual float get_flexibleHeight() { }

	// RVA: 0x1F12D40 Offset: 0x1F0ED40 VA: 0x1F12D40 Slot: 84
	public virtual int get_layoutPriority() { }
}

// Namespace: 
public enum Toggle.ToggleTransition // TypeDefIndex: 7342
{
	// Fields
	public int value__; // 0x0
	public const Toggle.ToggleTransition None = 0;
	public const Toggle.ToggleTransition Fade = 1;
}

// Namespace: 
[Serializable]
public class Toggle.ToggleEvent : UnityEvent<bool> // TypeDefIndex: 7343
{
	// Methods

	// RVA: 0x1F13014 Offset: 0x1F0F014 VA: 0x1F13014
	public void .ctor() { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Toggle", 30)]
[RequireComponent(typeof(RectTransform))]
public class Toggle : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICanvasElement // TypeDefIndex: 7344
{
	// Fields
	public Toggle.ToggleTransition toggleTransition; // 0x100
	public Graphic graphic; // 0x108
	[SerializeField]
	private ToggleGroup m_Group; // 0x110
	public Toggle.ToggleEvent onValueChanged; // 0x118
	[Tooltip("Is the toggle currently on or off?")]
	[SerializeField]
	private bool m_IsOn; // 0x120

	// Properties
	public ToggleGroup group { get; set; }
	public bool isOn { get; set; }

	// Methods

	// RVA: 0x1F12D48 Offset: 0x1F0ED48 VA: 0x1F12D48
	public ToggleGroup get_group() { }

	// RVA: 0x1F12D50 Offset: 0x1F0ED50 VA: 0x1F12D50
	public void set_group(ToggleGroup value) { }

	// RVA: 0x1F12F7C Offset: 0x1F0EF7C VA: 0x1F12F7C
	protected void .ctor() { }

	// RVA: 0x1F1305C Offset: 0x1F0F05C VA: 0x1F1305C Slot: 46
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x1F13060 Offset: 0x1F0F060 VA: 0x1F13060 Slot: 47
	public virtual void LayoutComplete() { }

	// RVA: 0x1F13064 Offset: 0x1F0F064 VA: 0x1F13064 Slot: 48
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x1F13068 Offset: 0x1F0F068 VA: 0x1F13068 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x1F1349C Offset: 0x1F0F49C VA: 0x1F1349C Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1F134C8 Offset: 0x1F0F4C8 VA: 0x1F134C8 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1F134E8 Offset: 0x1F0F4E8 VA: 0x1F134E8 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1F12D70 Offset: 0x1F0ED70 VA: 0x1F12D70
	private void SetToggleGroup(ToggleGroup newGroup, bool setMemberValue) { }

	// RVA: 0x1F13A20 Offset: 0x1F0FA20 VA: 0x1F13A20
	public bool get_isOn() { }

	// RVA: 0x1F13A28 Offset: 0x1F0FA28 VA: 0x1F13A28
	public void set_isOn(bool value) { }

	// RVA: 0x1F13A30 Offset: 0x1F0FA30 VA: 0x1F13A30
	public void SetIsOnWithoutNotify(bool value) { }

	// RVA: 0x1F1360C Offset: 0x1F0F60C VA: 0x1F1360C
	private void Set(bool value, bool sendCallback = True) { }

	// RVA: 0x1F12EB8 Offset: 0x1F0EEB8 VA: 0x1F12EB8
	private void PlayEffect(bool instant) { }

	// RVA: 0x1F13B78 Offset: 0x1F0FB78 VA: 0x1F13B78 Slot: 6
	protected override void Start() { }

	// RVA: 0x1F13B80 Offset: 0x1F0FB80 VA: 0x1F13B80
	private void InternalToggle() { }

	// RVA: 0x1F13BD4 Offset: 0x1F0FBD4 VA: 0x1F13BD4 Slot: 49
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1F13BF0 Offset: 0x1F0FBF0 VA: 0x1F13BF0 Slot: 50
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1F13BF4 Offset: 0x1F0FBF4 VA: 0x1F13BF4 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ToggleGroup.<>c // TypeDefIndex: 7345
{
	// Fields
	public static readonly ToggleGroup.<>c <>9; // 0x0
	public static Predicate<Toggle> <>9__13_0; // 0x8
	public static Func<Toggle, bool> <>9__14_0; // 0x10

	// Methods

	// RVA: 0x1F14090 Offset: 0x1F10090 VA: 0x1F14090
	private static void .cctor() { }

	// RVA: 0x1F140F8 Offset: 0x1F100F8 VA: 0x1F140F8
	public void .ctor() { }

	// RVA: 0x1F14100 Offset: 0x1F10100 VA: 0x1F14100
	internal bool <AnyTogglesOn>b__13_0(Toggle x) { }

	// RVA: 0x1F14114 Offset: 0x1F10114 VA: 0x1F14114
	internal bool <ActiveToggles>b__14_0(Toggle x) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Toggle Group", 31)]
[DisallowMultipleComponent]
public class ToggleGroup : UIBehaviour // TypeDefIndex: 7346
{
	// Fields
	[SerializeField]
	private bool m_AllowSwitchOff; // 0x20
	protected List<Toggle> m_Toggles; // 0x28

	// Properties
	public bool allowSwitchOff { get; set; }

	// Methods

	// RVA: 0x1F13BFC Offset: 0x1F0FBFC VA: 0x1F13BFC
	public bool get_allowSwitchOff() { }

	// RVA: 0x1F13C04 Offset: 0x1F0FC04 VA: 0x1F13C04
	public void set_allowSwitchOff(bool value) { }

	// RVA: 0x1F13C0C Offset: 0x1F0FC0C VA: 0x1F13C0C
	protected void .ctor() { }

	// RVA: 0x1F13C94 Offset: 0x1F0FC94 VA: 0x1F13C94 Slot: 6
	protected override void Start() { }

	// RVA: 0x1F13CB0 Offset: 0x1F0FCB0 VA: 0x1F13CB0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1F13CCC Offset: 0x1F0FCCC VA: 0x1F13CCC
	private void ValidateToggleIsInGroup(Toggle toggle) { }

	// RVA: 0x1F138F4 Offset: 0x1F0F8F4 VA: 0x1F138F4
	public void NotifyToggleOn(Toggle toggle, bool sendCallback = True) { }

	// RVA: 0x1F13780 Offset: 0x1F0F780 VA: 0x1F13780
	public void UnregisterToggle(Toggle toggle) { }

	// RVA: 0x1F13810 Offset: 0x1F0F810 VA: 0x1F13810
	public void RegisterToggle(Toggle toggle) { }

	// RVA: 0x1F130E8 Offset: 0x1F0F0E8 VA: 0x1F130E8
	public void EnsureValidState() { }

	// RVA: 0x1F13A38 Offset: 0x1F0FA38 VA: 0x1F13A38
	public bool AnyTogglesOn() { }

	// RVA: 0x1F13E14 Offset: 0x1F0FE14 VA: 0x1F13E14
	public IEnumerable<Toggle> ActiveToggles() { }

	// RVA: 0x1F13F10 Offset: 0x1F0FF10 VA: 0x1F13F10
	public Toggle GetFirstActiveToggle() { }

	// RVA: 0x1F13F98 Offset: 0x1F0FF98 VA: 0x1F13F98
	public void SetAllTogglesOff(bool sendCallback = True) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.Raycast2DCallback : MulticastDelegate // TypeDefIndex: 7347
{
	// Methods

	// RVA: 0x1F148C4 Offset: 0x1F108C4 VA: 0x1F148C4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F14964 Offset: 0x1F10964 VA: 0x1F14964 Slot: 12
	public virtual RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i) { }

	// RVA: 0x1F14978 Offset: 0x1F10978 VA: 0x1F14978 Slot: 13
	public virtual IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1F14A54 Offset: 0x1F10A54 VA: 0x1F14A54 Slot: 14
	public virtual RaycastHit2D EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.GetRayIntersectionAllCallback : MulticastDelegate // TypeDefIndex: 7348
{
	// Methods

	// RVA: 0x1F14A8C Offset: 0x1F10A8C VA: 0x1F14A8C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F14B2C Offset: 0x1F10B2C VA: 0x1F14B2C Slot: 12
	public virtual RaycastHit2D[] Invoke(Ray r, float f, int i) { }

	// RVA: 0x1F14B68 Offset: 0x1F10B68 VA: 0x1F14B68 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1F14C30 Offset: 0x1F10C30 VA: 0x1F14C30 Slot: 14
	public virtual RaycastHit2D[] EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback : MulticastDelegate // TypeDefIndex: 7349
{
	// Methods

	// RVA: 0x1F14C3C Offset: 0x1F10C3C VA: 0x1F14C3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1F14CDC Offset: 0x1F10CDC VA: 0x1F14CDC Slot: 12
	public virtual int Invoke(Ray r, RaycastHit2D[] results, float f, int i) { }

	// RVA: 0x1F14D18 Offset: 0x1F10D18 VA: 0x1F14D18 Slot: 13
	public virtual IAsyncResult BeginInvoke(Ray r, RaycastHit2D[] results, float f, int i, AsyncCallback callback, object object) { }

	// RVA: 0x1F14DE4 Offset: 0x1F10DE4 VA: 0x1F14DE4 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }
}

// Namespace: UnityEngine.UI
internal class ReflectionMethodsCache // TypeDefIndex: 7350
{
	// Fields
	public ReflectionMethodsCache.Raycast2DCallback raycast2D; // 0x10
	public ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll; // 0x18
	public ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc; // 0x20
	private static ReflectionMethodsCache s_ReflectionMethodsCache; // 0x0

	// Properties
	public static ReflectionMethodsCache Singleton { get; }

	// Methods

	// RVA: 0x1F14128 Offset: 0x1F10128 VA: 0x1F14128
	public void .ctor() { }

	// RVA: 0x1F14840 Offset: 0x1F10840 VA: 0x1F14840
	public static ReflectionMethodsCache get_Singleton() { }
}

// Namespace: UnityEngine.UI
public class VertexHelper : IDisposable // TypeDefIndex: 7351
{
	// Fields
	private List<Vector3> m_Positions; // 0x10
	private List<Color32> m_Colors; // 0x18
	private List<Vector4> m_Uv0S; // 0x20
	private List<Vector4> m_Uv1S; // 0x28
	private List<Vector4> m_Uv2S; // 0x30
	private List<Vector4> m_Uv3S; // 0x38
	private List<Vector3> m_Normals; // 0x40
	private List<Vector4> m_Tangents; // 0x48
	private List<int> m_Indices; // 0x50
	private static readonly Vector4 s_DefaultTangent; // 0x0
	private static readonly Vector3 s_DefaultNormal; // 0x10
	private bool m_ListsInitalized; // 0x58

	// Properties
	public int currentVertCount { get; }
	public int currentIndexCount { get; }

	// Methods

	// RVA: 0x1F14E0C Offset: 0x1F10E0C VA: 0x1F14E0C
	public void .ctor() { }

	// RVA: 0x1F14E14 Offset: 0x1F10E14 VA: 0x1F14E14
	public void .ctor(Mesh m) { }

	// RVA: 0x1F15050 Offset: 0x1F11050 VA: 0x1F15050
	private void InitializeListIfRequired() { }

	// RVA: 0x1F15244 Offset: 0x1F11244 VA: 0x1F15244 Slot: 4
	public void Dispose() { }

	// RVA: 0x1F05ED8 Offset: 0x1F01ED8 VA: 0x1F05ED8
	public void Clear() { }

	// RVA: 0x1F154AC Offset: 0x1F114AC VA: 0x1F154AC
	public int get_currentVertCount() { }

	// RVA: 0x1F154F8 Offset: 0x1F114F8 VA: 0x1F154F8
	public int get_currentIndexCount() { }

	// RVA: 0x1F15544 Offset: 0x1F11544 VA: 0x1F15544
	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	// RVA: 0x1F156A4 Offset: 0x1F116A4 VA: 0x1F156A4
	public void SetUIVertex(UIVertex vertex, int i) { }

	// RVA: 0x1F15800 Offset: 0x1F11800 VA: 0x1F15800
	public void FillMesh(Mesh mesh) { }

	// RVA: 0x1F15960 Offset: 0x1F11960 VA: 0x1F15960
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x1F15DC8 Offset: 0x1F11DC8 VA: 0x1F15DC8
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) { }

	// RVA: 0x1F05FF4 Offset: 0x1F01FF4 VA: 0x1F05FF4
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0) { }

	// RVA: 0x1F15EE0 Offset: 0x1F11EE0 VA: 0x1F15EE0
	public void AddVert(UIVertex v) { }

	// RVA: 0x1F06124 Offset: 0x1F02124 VA: 0x1F06124
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	// RVA: 0x1F12AB8 Offset: 0x1F0EAB8 VA: 0x1F12AB8
	public void AddUIVertexQuad(UIVertex[] verts) { }

	// RVA: 0x1F15F74 Offset: 0x1F11F74 VA: 0x1F15F74
	public void AddUIVertexStream(List<UIVertex> verts, List<int> indices) { }

	// RVA: 0x1F16020 Offset: 0x1F12020 VA: 0x1F16020
	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	// RVA: 0x1F16070 Offset: 0x1F12070 VA: 0x1F16070
	public void GetUIVertexStream(List<UIVertex> stream) { }

	// RVA: 0x1F160C0 Offset: 0x1F120C0 VA: 0x1F160C0
	private static void .cctor() { }
}

// Namespace: UnityEngine.UI
[Obsolete("Use BaseMeshEffect instead", True)]
public abstract class BaseVertexEffect // TypeDefIndex: 7352
{
	// Methods

	[EditorBrowsable(1)]
	[Obsolete("Use BaseMeshEffect.ModifyMeshes instead", True)]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ModifyVertices(List<UIVertex> vertices);

	// RVA: 0x1F16158 Offset: 0x1F12158 VA: 0x1F16158
	protected void .ctor() { }
}

// Namespace: UnityEngine.UI
[ExecuteAlways]
public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier // TypeDefIndex: 7353
{
	// Fields
	private Graphic m_Graphic; // 0x20

	// Properties
	protected Graphic graphic { get; }

	// Methods

	// RVA: 0x1F16160 Offset: 0x1F12160 VA: 0x1F16160
	protected Graphic get_graphic() { }

	// RVA: 0x1F16200 Offset: 0x1F12200 VA: 0x1F16200 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1F162A8 Offset: 0x1F122A8 VA: 0x1F162A8 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1F16344 Offset: 0x1F12344 VA: 0x1F16344 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x1F163E0 Offset: 0x1F123E0 VA: 0x1F163E0 Slot: 19
	public virtual void ModifyMesh(Mesh mesh) { }

	// RVA: -1 Offset: -1 Slot: 20
	public abstract void ModifyMesh(VertexHelper vh);

	// RVA: 0x1F16550 Offset: 0x1F12550 VA: 0x1F16550
	protected void .ctor() { }
}

// Namespace: UnityEngine.UI
[EditorBrowsable(1)]
[Obsolete("Use IMeshModifier instead", True)]
public interface IVertexModifier // TypeDefIndex: 7354
{
	// Methods

	[EditorBrowsable(1)]
	[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts)  instead", True)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ModifyVertices(List<UIVertex> verts);
}

// Namespace: UnityEngine.UI
public interface IMeshModifier // TypeDefIndex: 7355
{
	// Methods

	[Obsolete("use IMeshModifier.ModifyMesh (VertexHelper verts) instead", False)]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ModifyMesh(Mesh mesh);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ModifyMesh(VertexHelper verts);
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Effects/Outline", 81)]
public class Outline : Shadow // TypeDefIndex: 7356
{
	// Methods

	// RVA: 0x1F16558 Offset: 0x1F12558 VA: 0x1F16558
	protected void .ctor() { }

	// RVA: 0x1F165A8 Offset: 0x1F125A8 VA: 0x1F165A8 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Effects/Position As UV1", 82)]
public class PositionAsUV1 : BaseMeshEffect // TypeDefIndex: 7357
{
	// Methods

	// RVA: 0x1F16AD0 Offset: 0x1F12AD0 VA: 0x1F16AD0
	protected void .ctor() { }

	// RVA: 0x1F16AD8 Offset: 0x1F12AD8 VA: 0x1F16AD8 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }
}

// Namespace: UnityEngine.UI
[AddComponentMenu("UI/Effects/Shadow", 80)]
public class Shadow : BaseMeshEffect // TypeDefIndex: 7358
{
	// Fields
	[SerializeField]
	private Color m_EffectColor; // 0x28
	[SerializeField]
	private Vector2 m_EffectDistance; // 0x38
	[SerializeField]
	private bool m_UseGraphicAlpha; // 0x40
	private const float kMaxEffectDistance = 600;

	// Properties
	public Color effectColor { get; set; }
	public Vector2 effectDistance { get; set; }
	public bool useGraphicAlpha { get; set; }

	// Methods

	// RVA: 0x1F16580 Offset: 0x1F12580 VA: 0x1F16580
	protected void .ctor() { }

	// RVA: 0x1F16BA8 Offset: 0x1F12BA8 VA: 0x1F16BA8
	public Color get_effectColor() { }

	// RVA: 0x1F16BB4 Offset: 0x1F12BB4 VA: 0x1F16BB4
	public void set_effectColor(Color value) { }

	// RVA: 0x1F16C80 Offset: 0x1F12C80 VA: 0x1F16C80
	public Vector2 get_effectDistance() { }

	// RVA: 0x1F16C88 Offset: 0x1F12C88 VA: 0x1F16C88
	public void set_effectDistance(Vector2 value) { }

	// RVA: 0x1F16D80 Offset: 0x1F12D80 VA: 0x1F16D80
	public bool get_useGraphicAlpha() { }

	// RVA: 0x1F16D88 Offset: 0x1F12D88 VA: 0x1F16D88
	public void set_useGraphicAlpha(bool value) { }

	// RVA: 0x1F167D8 Offset: 0x1F127D8 VA: 0x1F167D8
	protected void ApplyShadowZeroAlloc(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x1F16E38 Offset: 0x1F12E38 VA: 0x1F16E38
	protected void ApplyShadow(List<UIVertex> verts, Color32 color, int start, int end, float x, float y) { }

	// RVA: 0x1F16E40 Offset: 0x1F12E40 VA: 0x1F16E40 Slot: 20
	public override void ModifyMesh(VertexHelper vh) { }
}
