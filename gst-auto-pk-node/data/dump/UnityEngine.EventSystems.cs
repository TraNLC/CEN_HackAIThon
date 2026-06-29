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

// Namespace: UnityEngine.EventSystems
public class AxisEventData : BaseEventData // TypeDefIndex: 7368
{
	// Fields
	[CompilerGenerated]
	private Vector2 <moveVector>k__BackingField; // 0x20
	[CompilerGenerated]
	private MoveDirection <moveDir>k__BackingField; // 0x28

	// Properties
	public Vector2 moveVector { get; set; }
	public MoveDirection moveDir { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F17354 Offset: 0x1F13354 VA: 0x1F17354
	public Vector2 get_moveVector() { }

	[CompilerGenerated]
	// RVA: 0x1F1735C Offset: 0x1F1335C VA: 0x1F1735C
	public void set_moveVector(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x1F17364 Offset: 0x1F13364 VA: 0x1F17364
	public MoveDirection get_moveDir() { }

	[CompilerGenerated]
	// RVA: 0x1F1736C Offset: 0x1F1336C VA: 0x1F1736C
	public void set_moveDir(MoveDirection value) { }

	// RVA: 0x1F17374 Offset: 0x1F13374 VA: 0x1F17374
	public void .ctor(EventSystem eventSystem) { }
}

// Namespace: UnityEngine.EventSystems
public abstract class AbstractEventData // TypeDefIndex: 7369
{
	// Fields
	protected bool m_Used; // 0x10

	// Properties
	public virtual bool used { get; }

	// Methods

	// RVA: 0x1F17418 Offset: 0x1F13418 VA: 0x1F17418 Slot: 4
	public virtual void Reset() { }

	// RVA: 0x1F17420 Offset: 0x1F13420 VA: 0x1F17420 Slot: 5
	public virtual void Use() { }

	// RVA: 0x1F1742C Offset: 0x1F1342C VA: 0x1F1742C Slot: 6
	public virtual bool get_used() { }

	// RVA: 0x1F17434 Offset: 0x1F13434 VA: 0x1F17434
	protected void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
public class BaseEventData : AbstractEventData // TypeDefIndex: 7370
{
	// Fields
	private readonly EventSystem m_EventSystem; // 0x18

	// Properties
	public BaseInputModule currentInputModule { get; }
	public GameObject selectedObject { get; set; }

	// Methods

	// RVA: 0x1F173E8 Offset: 0x1F133E8 VA: 0x1F173E8
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x1F1743C Offset: 0x1F1343C VA: 0x1F1743C
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x1F17454 Offset: 0x1F13454 VA: 0x1F17454
	public GameObject get_selectedObject() { }

	// RVA: 0x1F1746C Offset: 0x1F1346C VA: 0x1F1746C
	public void set_selectedObject(GameObject value) { }
}

// Namespace: 
public enum PointerEventData.InputButton // TypeDefIndex: 7371
{
	// Fields
	public int value__; // 0x0
	public const PointerEventData.InputButton Left = 0;
	public const PointerEventData.InputButton Right = 1;
	public const PointerEventData.InputButton Middle = 2;
}

// Namespace: 
public enum PointerEventData.FramePressState // TypeDefIndex: 7372
{
	// Fields
	public int value__; // 0x0
	public const PointerEventData.FramePressState Pressed = 0;
	public const PointerEventData.FramePressState Released = 1;
	public const PointerEventData.FramePressState PressedAndReleased = 2;
	public const PointerEventData.FramePressState NotChanged = 3;
}

// Namespace: UnityEngine.EventSystems
public class PointerEventData : BaseEventData // TypeDefIndex: 7373
{
	// Fields
	[CompilerGenerated]
	private GameObject <pointerEnter>k__BackingField; // 0x20
	private GameObject m_PointerPress; // 0x28
	[CompilerGenerated]
	private GameObject <lastPress>k__BackingField; // 0x30
	[CompilerGenerated]
	private GameObject <rawPointerPress>k__BackingField; // 0x38
	[CompilerGenerated]
	private GameObject <pointerDrag>k__BackingField; // 0x40
	[CompilerGenerated]
	private GameObject <pointerClick>k__BackingField; // 0x48
	[CompilerGenerated]
	private RaycastResult <pointerCurrentRaycast>k__BackingField; // 0x50
	[CompilerGenerated]
	private RaycastResult <pointerPressRaycast>k__BackingField; // 0xA0
	public List<GameObject> hovered; // 0xF0
	[CompilerGenerated]
	private bool <eligibleForClick>k__BackingField; // 0xF8
	[CompilerGenerated]
	private int <displayIndex>k__BackingField; // 0xFC
	[CompilerGenerated]
	private int <pointerId>k__BackingField; // 0x100
	[CompilerGenerated]
	private Vector2 <position>k__BackingField; // 0x104
	[CompilerGenerated]
	private Vector2 <delta>k__BackingField; // 0x10C
	[CompilerGenerated]
	private Vector2 <pressPosition>k__BackingField; // 0x114
	[CompilerGenerated]
	private Vector3 <worldPosition>k__BackingField; // 0x11C
	[CompilerGenerated]
	private Vector3 <worldNormal>k__BackingField; // 0x128
	[CompilerGenerated]
	private float <clickTime>k__BackingField; // 0x134
	[CompilerGenerated]
	private int <clickCount>k__BackingField; // 0x138
	[CompilerGenerated]
	private Vector2 <scrollDelta>k__BackingField; // 0x13C
	[CompilerGenerated]
	private bool <useDragThreshold>k__BackingField; // 0x144
	[CompilerGenerated]
	private bool <dragging>k__BackingField; // 0x145
	[CompilerGenerated]
	private PointerEventData.InputButton <button>k__BackingField; // 0x148
	[CompilerGenerated]
	private float <pressure>k__BackingField; // 0x14C
	[CompilerGenerated]
	private float <tangentialPressure>k__BackingField; // 0x150
	[CompilerGenerated]
	private float <altitudeAngle>k__BackingField; // 0x154
	[CompilerGenerated]
	private float <azimuthAngle>k__BackingField; // 0x158
	[CompilerGenerated]
	private float <twist>k__BackingField; // 0x15C
	[CompilerGenerated]
	private Vector2 <tilt>k__BackingField; // 0x160
	[CompilerGenerated]
	private PenStatus <penStatus>k__BackingField; // 0x168
	[CompilerGenerated]
	private Vector2 <radius>k__BackingField; // 0x16C
	[CompilerGenerated]
	private Vector2 <radiusVariance>k__BackingField; // 0x174
	[CompilerGenerated]
	private bool <fullyExited>k__BackingField; // 0x17C
	[CompilerGenerated]
	private bool <reentered>k__BackingField; // 0x17D

	// Properties
	public GameObject pointerEnter { get; set; }
	public GameObject lastPress { get; set; }
	public GameObject rawPointerPress { get; set; }
	public GameObject pointerDrag { get; set; }
	public GameObject pointerClick { get; set; }
	public RaycastResult pointerCurrentRaycast { get; set; }
	public RaycastResult pointerPressRaycast { get; set; }
	public bool eligibleForClick { get; set; }
	public int displayIndex { get; set; }
	public int pointerId { get; set; }
	public Vector2 position { get; set; }
	public Vector2 delta { get; set; }
	public Vector2 pressPosition { get; set; }
	[Obsolete("Use either pointerCurrentRaycast.worldPosition or pointerPressRaycast.worldPosition")]
	public Vector3 worldPosition { get; set; }
	[Obsolete("Use either pointerCurrentRaycast.worldNormal or pointerPressRaycast.worldNormal")]
	public Vector3 worldNormal { get; set; }
	public float clickTime { get; set; }
	public int clickCount { get; set; }
	public Vector2 scrollDelta { get; set; }
	public bool useDragThreshold { get; set; }
	public bool dragging { get; set; }
	public PointerEventData.InputButton button { get; set; }
	public float pressure { get; set; }
	public float tangentialPressure { get; set; }
	public float altitudeAngle { get; set; }
	public float azimuthAngle { get; set; }
	public float twist { get; set; }
	public Vector2 tilt { get; set; }
	public PenStatus penStatus { get; set; }
	public Vector2 radius { get; set; }
	public Vector2 radiusVariance { get; set; }
	public bool fullyExited { get; set; }
	public bool reentered { get; set; }
	public Camera enterEventCamera { get; }
	public Camera pressEventCamera { get; }
	public GameObject pointerPress { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F176BC Offset: 0x1F136BC VA: 0x1F176BC
	public GameObject get_pointerEnter() { }

	[CompilerGenerated]
	// RVA: 0x1F176C4 Offset: 0x1F136C4 VA: 0x1F176C4
	public void set_pointerEnter(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x1F176CC Offset: 0x1F136CC VA: 0x1F176CC
	public GameObject get_lastPress() { }

	[CompilerGenerated]
	// RVA: 0x1F176D4 Offset: 0x1F136D4 VA: 0x1F176D4
	private void set_lastPress(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x1F176DC Offset: 0x1F136DC VA: 0x1F176DC
	public GameObject get_rawPointerPress() { }

	[CompilerGenerated]
	// RVA: 0x1F176E4 Offset: 0x1F136E4 VA: 0x1F176E4
	public void set_rawPointerPress(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x1F176EC Offset: 0x1F136EC VA: 0x1F176EC
	public GameObject get_pointerDrag() { }

	[CompilerGenerated]
	// RVA: 0x1F176F4 Offset: 0x1F136F4 VA: 0x1F176F4
	public void set_pointerDrag(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x1F176FC Offset: 0x1F136FC VA: 0x1F176FC
	public GameObject get_pointerClick() { }

	[CompilerGenerated]
	// RVA: 0x1F17704 Offset: 0x1F13704 VA: 0x1F17704
	public void set_pointerClick(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x1F1770C Offset: 0x1F1370C VA: 0x1F1770C
	public RaycastResult get_pointerCurrentRaycast() { }

	[CompilerGenerated]
	// RVA: 0x1F1771C Offset: 0x1F1371C VA: 0x1F1771C
	public void set_pointerCurrentRaycast(RaycastResult value) { }

	[CompilerGenerated]
	// RVA: 0x1F17740 Offset: 0x1F13740 VA: 0x1F17740
	public RaycastResult get_pointerPressRaycast() { }

	[CompilerGenerated]
	// RVA: 0x1F17750 Offset: 0x1F13750 VA: 0x1F17750
	public void set_pointerPressRaycast(RaycastResult value) { }

	[CompilerGenerated]
	// RVA: 0x1F17774 Offset: 0x1F13774 VA: 0x1F17774
	public bool get_eligibleForClick() { }

	[CompilerGenerated]
	// RVA: 0x1F1777C Offset: 0x1F1377C VA: 0x1F1777C
	public void set_eligibleForClick(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F17784 Offset: 0x1F13784 VA: 0x1F17784
	public int get_displayIndex() { }

	[CompilerGenerated]
	// RVA: 0x1F1778C Offset: 0x1F1378C VA: 0x1F1778C
	public void set_displayIndex(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F17794 Offset: 0x1F13794 VA: 0x1F17794
	public int get_pointerId() { }

	[CompilerGenerated]
	// RVA: 0x1F1779C Offset: 0x1F1379C VA: 0x1F1779C
	public void set_pointerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F177A4 Offset: 0x1F137A4 VA: 0x1F177A4
	public Vector2 get_position() { }

	[CompilerGenerated]
	// RVA: 0x1F177B0 Offset: 0x1F137B0 VA: 0x1F177B0
	public void set_position(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x1F177BC Offset: 0x1F137BC VA: 0x1F177BC
	public Vector2 get_delta() { }

	[CompilerGenerated]
	// RVA: 0x1F177C8 Offset: 0x1F137C8 VA: 0x1F177C8
	public void set_delta(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x1F177D4 Offset: 0x1F137D4 VA: 0x1F177D4
	public Vector2 get_pressPosition() { }

	[CompilerGenerated]
	// RVA: 0x1F177E0 Offset: 0x1F137E0 VA: 0x1F177E0
	public void set_pressPosition(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x1F177EC Offset: 0x1F137EC VA: 0x1F177EC
	public Vector3 get_worldPosition() { }

	[CompilerGenerated]
	// RVA: 0x1F177FC Offset: 0x1F137FC VA: 0x1F177FC
	public void set_worldPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x1F1780C Offset: 0x1F1380C VA: 0x1F1780C
	public Vector3 get_worldNormal() { }

	[CompilerGenerated]
	// RVA: 0x1F1781C Offset: 0x1F1381C VA: 0x1F1781C
	public void set_worldNormal(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x1F1782C Offset: 0x1F1382C VA: 0x1F1782C
	public float get_clickTime() { }

	[CompilerGenerated]
	// RVA: 0x1F17834 Offset: 0x1F13834 VA: 0x1F17834
	public void set_clickTime(float value) { }

	[CompilerGenerated]
	// RVA: 0x1F1783C Offset: 0x1F1383C VA: 0x1F1783C
	public int get_clickCount() { }

	[CompilerGenerated]
	// RVA: 0x1F17844 Offset: 0x1F13844 VA: 0x1F17844
	public void set_clickCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F1784C Offset: 0x1F1384C VA: 0x1F1784C
	public Vector2 get_scrollDelta() { }

	[CompilerGenerated]
	// RVA: 0x1F17858 Offset: 0x1F13858 VA: 0x1F17858
	public void set_scrollDelta(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x1F17864 Offset: 0x1F13864 VA: 0x1F17864
	public bool get_useDragThreshold() { }

	[CompilerGenerated]
	// RVA: 0x1F1786C Offset: 0x1F1386C VA: 0x1F1786C
	public void set_useDragThreshold(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F17874 Offset: 0x1F13874 VA: 0x1F17874
	public bool get_dragging() { }

	[CompilerGenerated]
	// RVA: 0x1F1787C Offset: 0x1F1387C VA: 0x1F1787C
	public void set_dragging(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F17884 Offset: 0x1F13884 VA: 0x1F17884
	public PointerEventData.InputButton get_button() { }

	[CompilerGenerated]
	// RVA: 0x1F1788C Offset: 0x1F1388C VA: 0x1F1788C
	public void set_button(PointerEventData.InputButton value) { }

	[CompilerGenerated]
	// RVA: 0x1F17894 Offset: 0x1F13894 VA: 0x1F17894
	public float get_pressure() { }

	[CompilerGenerated]
	// RVA: 0x1F1789C Offset: 0x1F1389C VA: 0x1F1789C
	public void set_pressure(float value) { }

	[CompilerGenerated]
	// RVA: 0x1F178A4 Offset: 0x1F138A4 VA: 0x1F178A4
	public float get_tangentialPressure() { }

	[CompilerGenerated]
	// RVA: 0x1F178AC Offset: 0x1F138AC VA: 0x1F178AC
	public void set_tangentialPressure(float value) { }

	[CompilerGenerated]
	// RVA: 0x1F178B4 Offset: 0x1F138B4 VA: 0x1F178B4
	public float get_altitudeAngle() { }

	[CompilerGenerated]
	// RVA: 0x1F178BC Offset: 0x1F138BC VA: 0x1F178BC
	public void set_altitudeAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x1F178C4 Offset: 0x1F138C4 VA: 0x1F178C4
	public float get_azimuthAngle() { }

	[CompilerGenerated]
	// RVA: 0x1F178CC Offset: 0x1F138CC VA: 0x1F178CC
	public void set_azimuthAngle(float value) { }

	[CompilerGenerated]
	// RVA: 0x1F178D4 Offset: 0x1F138D4 VA: 0x1F178D4
	public float get_twist() { }

	[CompilerGenerated]
	// RVA: 0x1F178DC Offset: 0x1F138DC VA: 0x1F178DC
	public void set_twist(float value) { }

	[CompilerGenerated]
	// RVA: 0x1F178E4 Offset: 0x1F138E4 VA: 0x1F178E4
	public Vector2 get_tilt() { }

	[CompilerGenerated]
	// RVA: 0x1F178F0 Offset: 0x1F138F0 VA: 0x1F178F0
	public void set_tilt(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x1F178FC Offset: 0x1F138FC VA: 0x1F178FC
	public PenStatus get_penStatus() { }

	[CompilerGenerated]
	// RVA: 0x1F17904 Offset: 0x1F13904 VA: 0x1F17904
	public void set_penStatus(PenStatus value) { }

	[CompilerGenerated]
	// RVA: 0x1F1790C Offset: 0x1F1390C VA: 0x1F1790C
	public Vector2 get_radius() { }

	[CompilerGenerated]
	// RVA: 0x1F17918 Offset: 0x1F13918 VA: 0x1F17918
	public void set_radius(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x1F17924 Offset: 0x1F13924 VA: 0x1F17924
	public Vector2 get_radiusVariance() { }

	[CompilerGenerated]
	// RVA: 0x1F17930 Offset: 0x1F13930 VA: 0x1F17930
	public void set_radiusVariance(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x1F1793C Offset: 0x1F1393C VA: 0x1F1793C
	public bool get_fullyExited() { }

	[CompilerGenerated]
	// RVA: 0x1F17944 Offset: 0x1F13944 VA: 0x1F17944
	public void set_fullyExited(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F1794C Offset: 0x1F1394C VA: 0x1F1794C
	public bool get_reentered() { }

	[CompilerGenerated]
	// RVA: 0x1F17954 Offset: 0x1F13954 VA: 0x1F17954
	public void set_reentered(bool value) { }

	// RVA: 0x1F1795C Offset: 0x1F1395C VA: 0x1F1795C
	public void .ctor(EventSystem eventSystem) { }

	// RVA: 0x1F17AA4 Offset: 0x1F13AA4 VA: 0x1F17AA4
	public bool IsPointerMoving() { }

	// RVA: 0x1F17AC4 Offset: 0x1F13AC4 VA: 0x1F17AC4
	public bool IsScrolling() { }

	// RVA: 0x1F17AE4 Offset: 0x1F13AE4 VA: 0x1F17AE4
	public Camera get_enterEventCamera() { }

	// RVA: 0x1F17B74 Offset: 0x1F13B74 VA: 0x1F17B74
	public Camera get_pressEventCamera() { }

	// RVA: 0x1F17C04 Offset: 0x1F13C04 VA: 0x1F17C04
	public GameObject get_pointerPress() { }

	// RVA: 0x1F17C0C Offset: 0x1F13C0C VA: 0x1F17C0C
	public void set_pointerPress(GameObject value) { }

	// RVA: 0x1F17CB0 Offset: 0x1F13CB0 VA: 0x1F17CB0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.EventSystems
[Flags]
public enum EventHandle // TypeDefIndex: 7374
{
	// Fields
	public int value__; // 0x0
	public const EventHandle Unused = 0;
	public const EventHandle Used = 1;
}

// Namespace: UnityEngine.EventSystems
public interface IEventSystemHandler // TypeDefIndex: 7375
{}

// Namespace: UnityEngine.EventSystems
public interface IPointerMoveHandler : IEventSystemHandler // TypeDefIndex: 7376
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerMove(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerEnterHandler : IEventSystemHandler // TypeDefIndex: 7377
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerEnter(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerExitHandler : IEventSystemHandler // TypeDefIndex: 7378
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerExit(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerDownHandler : IEventSystemHandler // TypeDefIndex: 7379
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerDown(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerUpHandler : IEventSystemHandler // TypeDefIndex: 7380
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerUp(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IPointerClickHandler : IEventSystemHandler // TypeDefIndex: 7381
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnPointerClick(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IBeginDragHandler : IEventSystemHandler // TypeDefIndex: 7382
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnBeginDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IInitializePotentialDragHandler : IEventSystemHandler // TypeDefIndex: 7383
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnInitializePotentialDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IDragHandler : IEventSystemHandler // TypeDefIndex: 7384
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IEndDragHandler : IEventSystemHandler // TypeDefIndex: 7385
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnEndDrag(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IDropHandler : IEventSystemHandler // TypeDefIndex: 7386
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDrop(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IScrollHandler : IEventSystemHandler // TypeDefIndex: 7387
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnScroll(PointerEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IUpdateSelectedHandler : IEventSystemHandler // TypeDefIndex: 7388
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnUpdateSelected(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface ISelectHandler : IEventSystemHandler // TypeDefIndex: 7389
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSelect(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IDeselectHandler : IEventSystemHandler // TypeDefIndex: 7390
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnDeselect(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface IMoveHandler : IEventSystemHandler // TypeDefIndex: 7391
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnMove(AxisEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface ISubmitHandler : IEventSystemHandler // TypeDefIndex: 7392
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnSubmit(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
public interface ICancelHandler : IEventSystemHandler // TypeDefIndex: 7393
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnCancel(BaseEventData eventData);
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Event System")]
[DisallowMultipleComponent]
public class EventSystem : UIBehaviour // TypeDefIndex: 7394
{
	// Fields
	private List<BaseInputModule> m_SystemInputModules; // 0x20
	private BaseInputModule m_CurrentInputModule; // 0x28
	private static List<EventSystem> m_EventSystems; // 0x0
	[SerializeField]
	[FormerlySerializedAs("m_Selected")]
	private GameObject m_FirstSelected; // 0x30
	[SerializeField]
	private bool m_sendNavigationEvents; // 0x38
	[SerializeField]
	private int m_DragThreshold; // 0x3C
	private GameObject m_CurrentSelected; // 0x40
	private bool m_HasFocus; // 0x48
	private bool m_SelectionGuard; // 0x49
	private BaseEventData m_DummyData; // 0x50
	private static readonly Comparison<RaycastResult> s_RaycastComparer; // 0x8

	// Properties
	public static EventSystem current { get; set; }
	public bool sendNavigationEvents { get; set; }
	public int pixelDragThreshold { get; set; }
	public BaseInputModule currentInputModule { get; }
	public GameObject firstSelectedGameObject { get; set; }
	public GameObject currentSelectedGameObject { get; }
	[Obsolete("lastSelectedGameObject is no longer supported")]
	public GameObject lastSelectedGameObject { get; }
	public bool isFocused { get; }
	public bool alreadySelecting { get; }
	private BaseEventData baseEventDataCache { get; }

	// Methods

	// RVA: 0x1F18984 Offset: 0x1F14984 VA: 0x1F18984
	public static EventSystem get_current() { }

	// RVA: 0x1F18A48 Offset: 0x1F14A48 VA: 0x1F18A48
	public static void set_current(EventSystem value) { }

	// RVA: 0x1F18BDC Offset: 0x1F14BDC VA: 0x1F18BDC
	public bool get_sendNavigationEvents() { }

	// RVA: 0x1F18BE4 Offset: 0x1F14BE4 VA: 0x1F18BE4
	public void set_sendNavigationEvents(bool value) { }

	// RVA: 0x1F18BEC Offset: 0x1F14BEC VA: 0x1F18BEC
	public int get_pixelDragThreshold() { }

	// RVA: 0x1F18BF4 Offset: 0x1F14BF4 VA: 0x1F18BF4
	public void set_pixelDragThreshold(int value) { }

	// RVA: 0x1F18BFC Offset: 0x1F14BFC VA: 0x1F18BFC
	public BaseInputModule get_currentInputModule() { }

	// RVA: 0x1F18C04 Offset: 0x1F14C04 VA: 0x1F18C04
	public GameObject get_firstSelectedGameObject() { }

	// RVA: 0x1F18C0C Offset: 0x1F14C0C VA: 0x1F18C0C
	public void set_firstSelectedGameObject(GameObject value) { }

	// RVA: 0x1F18C14 Offset: 0x1F14C14 VA: 0x1F18C14
	public GameObject get_currentSelectedGameObject() { }

	// RVA: 0x1F18C1C Offset: 0x1F14C1C VA: 0x1F18C1C
	public GameObject get_lastSelectedGameObject() { }

	// RVA: 0x1F18C24 Offset: 0x1F14C24 VA: 0x1F18C24
	public bool get_isFocused() { }

	// RVA: 0x1F18C2C Offset: 0x1F14C2C VA: 0x1F18C2C
	protected void .ctor() { }

	// RVA: 0x1F18CD0 Offset: 0x1F14CD0 VA: 0x1F18CD0
	public void UpdateModules() { }

	// RVA: 0x1F18E14 Offset: 0x1F14E14 VA: 0x1F18E14
	public bool get_alreadySelecting() { }

	// RVA: 0x1F17484 Offset: 0x1F13484 VA: 0x1F17484
	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	// RVA: 0x1F18E1C Offset: 0x1F14E1C VA: 0x1F18E1C
	private BaseEventData get_baseEventDataCache() { }

	// RVA: 0x1F18EA0 Offset: 0x1F14EA0 VA: 0x1F18EA0
	public void SetSelectedGameObject(GameObject selected) { }

	// RVA: 0x1F18ECC Offset: 0x1F14ECC VA: 0x1F18ECC
	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	// RVA: 0x1F1937C Offset: 0x1F1537C VA: 0x1F1937C
	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	// RVA: 0x1F1956C Offset: 0x1F1556C VA: 0x1F1956C
	public bool IsPointerOverGameObject() { }

	// RVA: 0x1F19574 Offset: 0x1F15574 VA: 0x1F19574
	public bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x1F19618 Offset: 0x1F15618 VA: 0x1F19618
	public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = True, bool createPanelGameObjectsOnStart = True) { }

	// RVA: 0x1F1961C Offset: 0x1F1561C VA: 0x1F1961C Slot: 6
	protected override void Start() { }

	// RVA: 0x1F19624 Offset: 0x1F15624 VA: 0x1F19624 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1F196FC Offset: 0x1F156FC VA: 0x1F196FC Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1F197E8 Offset: 0x1F157E8 VA: 0x1F197E8
	private void TickModules() { }

	// RVA: 0x1F198E8 Offset: 0x1F158E8 VA: 0x1F198E8 Slot: 17
	protected virtual void OnApplicationFocus(bool hasFocus) { }

	// RVA: 0x1F198F8 Offset: 0x1F158F8 VA: 0x1F198F8 Slot: 18
	protected virtual void Update() { }

	// RVA: 0x1F19B60 Offset: 0x1F15B60 VA: 0x1F19B60
	private void ChangeEventModule(BaseInputModule module) { }

	// RVA: 0x1F19C70 Offset: 0x1F15C70 VA: 0x1F19C70 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F19DC8 Offset: 0x1F15DC8 VA: 0x1F19DC8
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
public class EventTrigger.TriggerEvent : UnityEvent<BaseEventData> // TypeDefIndex: 7395
{
	// Methods

	// RVA: 0x1F1A110 Offset: 0x1F16110 VA: 0x1F1A110
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class EventTrigger.Entry // TypeDefIndex: 7396
{
	// Fields
	public EventTriggerType eventID; // 0x10
	public EventTrigger.TriggerEvent callback; // 0x18

	// Methods

	// RVA: 0x1F1A158 Offset: 0x1F16158 VA: 0x1F1A158
	public void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Event Trigger")]
public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 7397
{
	// Fields
	[FormerlySerializedAs("delegates")]
	[SerializeField]
	private List<EventTrigger.Entry> m_Delegates; // 0x20

	// Properties
	[EditorBrowsable(1)]
	[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", True)]
	public List<EventTrigger.Entry> delegates { get; set; }
	public List<EventTrigger.Entry> triggers { get; set; }

	// Methods

	// RVA: 0x1F19EC0 Offset: 0x1F15EC0 VA: 0x1F19EC0
	public List<EventTrigger.Entry> get_delegates() { }

	// RVA: 0x1F19F48 Offset: 0x1F15F48 VA: 0x1F19F48
	public void set_delegates(List<EventTrigger.Entry> value) { }

	// RVA: 0x1F19F50 Offset: 0x1F15F50 VA: 0x1F19F50
	protected void .ctor() { }

	// RVA: 0x1F19EC4 Offset: 0x1F15EC4 VA: 0x1F19EC4
	public List<EventTrigger.Entry> get_triggers() { }

	// RVA: 0x1F19F58 Offset: 0x1F15F58 VA: 0x1F19F58
	public void set_triggers(List<EventTrigger.Entry> value) { }

	// RVA: 0x1F19F60 Offset: 0x1F15F60 VA: 0x1F19F60
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	// RVA: 0x1F1A044 Offset: 0x1F16044 VA: 0x1F1A044 Slot: 21
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x1F1A050 Offset: 0x1F16050 VA: 0x1F1A050 Slot: 22
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x1F1A05C Offset: 0x1F1605C VA: 0x1F1A05C Slot: 23
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1F1A068 Offset: 0x1F16068 VA: 0x1F1A068 Slot: 24
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x1F1A074 Offset: 0x1F16074 VA: 0x1F1A074 Slot: 25
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x1F1A080 Offset: 0x1F16080 VA: 0x1F1A080 Slot: 26
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x1F1A08C Offset: 0x1F1608C VA: 0x1F1A08C Slot: 27
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x1F1A098 Offset: 0x1F16098 VA: 0x1F1A098 Slot: 28
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x1F1A0A4 Offset: 0x1F160A4 VA: 0x1F1A0A4 Slot: 29
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x1F1A0B0 Offset: 0x1F160B0 VA: 0x1F1A0B0 Slot: 30
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x1F1A0BC Offset: 0x1F160BC VA: 0x1F1A0BC Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x1F1A0C8 Offset: 0x1F160C8 VA: 0x1F1A0C8 Slot: 32
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x1F1A0D4 Offset: 0x1F160D4 VA: 0x1F1A0D4 Slot: 33
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x1F1A0E0 Offset: 0x1F160E0 VA: 0x1F1A0E0 Slot: 34
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1F1A0EC Offset: 0x1F160EC VA: 0x1F1A0EC Slot: 35
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1F1A0F8 Offset: 0x1F160F8 VA: 0x1F1A0F8 Slot: 36
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x1F1A104 Offset: 0x1F16104 VA: 0x1F1A104 Slot: 37
	public virtual void OnCancel(BaseEventData eventData) { }
}

// Namespace: UnityEngine.EventSystems
public enum EventTriggerType // TypeDefIndex: 7398
{
	// Fields
	public int value__; // 0x0
	public const EventTriggerType PointerEnter = 0;
	public const EventTriggerType PointerExit = 1;
	public const EventTriggerType PointerDown = 2;
	public const EventTriggerType PointerUp = 3;
	public const EventTriggerType PointerClick = 4;
	public const EventTriggerType Drag = 5;
	public const EventTriggerType Drop = 6;
	public const EventTriggerType Scroll = 7;
	public const EventTriggerType UpdateSelected = 8;
	public const EventTriggerType Select = 9;
	public const EventTriggerType Deselect = 10;
	public const EventTriggerType Move = 11;
	public const EventTriggerType InitializePotentialDrag = 12;
	public const EventTriggerType BeginDrag = 13;
	public const EventTriggerType EndDrag = 14;
	public const EventTriggerType Submit = 15;
	public const EventTriggerType Cancel = 16;
}

// Namespace: 
public sealed class ExecuteEvents.EventFunction<T1> : MulticastDelegate // TypeDefIndex: 7399
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12516DC Offset: 0x124D6DC VA: 0x12516DC
	|-ExecuteEvents.EventFunction<object>..ctor
	|
	|-RVA: 0x1251830 Offset: 0x124D830 VA: 0x1251830
	|-ExecuteEvents.EventFunction<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T1 handler, BaseEventData eventData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12517E8 Offset: 0x124D7E8 VA: 0x12517E8
	|-ExecuteEvents.EventFunction<object>.Invoke
	|
	|-RVA: 0x1251940 Offset: 0x124D940 VA: 0x1251940
	|-ExecuteEvents.EventFunction<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public virtual IAsyncResult BeginInvoke(T1 handler, BaseEventData eventData, AsyncCallback callback, object object) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12517FC Offset: 0x124D7FC VA: 0x12517FC
	|-ExecuteEvents.EventFunction<object>.BeginInvoke
	|
	|-RVA: 0x1251954 Offset: 0x124D954 VA: 0x1251954
	|-ExecuteEvents.EventFunction<__Il2CppFullySharedGenericType>.BeginInvoke
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1251824 Offset: 0x124D824 VA: 0x1251824
	|-ExecuteEvents.EventFunction<object>.EndInvoke
	|
	|-RVA: 0x12519E0 Offset: 0x124D9E0 VA: 0x12519E0
	|-ExecuteEvents.EventFunction<__Il2CppFullySharedGenericType>.EndInvoke
	*/
}

// Namespace: UnityEngine.EventSystems
public static class ExecuteEvents // TypeDefIndex: 7400
{
	// Fields
	private static readonly ExecuteEvents.EventFunction<IPointerMoveHandler> s_PointerMoveHandler; // 0x0
	private static readonly ExecuteEvents.EventFunction<IPointerEnterHandler> s_PointerEnterHandler; // 0x8
	private static readonly ExecuteEvents.EventFunction<IPointerExitHandler> s_PointerExitHandler; // 0x10
	private static readonly ExecuteEvents.EventFunction<IPointerDownHandler> s_PointerDownHandler; // 0x18
	private static readonly ExecuteEvents.EventFunction<IPointerUpHandler> s_PointerUpHandler; // 0x20
	private static readonly ExecuteEvents.EventFunction<IPointerClickHandler> s_PointerClickHandler; // 0x28
	private static readonly ExecuteEvents.EventFunction<IInitializePotentialDragHandler> s_InitializePotentialDragHandler; // 0x30
	private static readonly ExecuteEvents.EventFunction<IBeginDragHandler> s_BeginDragHandler; // 0x38
	private static readonly ExecuteEvents.EventFunction<IDragHandler> s_DragHandler; // 0x40
	private static readonly ExecuteEvents.EventFunction<IEndDragHandler> s_EndDragHandler; // 0x48
	private static readonly ExecuteEvents.EventFunction<IDropHandler> s_DropHandler; // 0x50
	private static readonly ExecuteEvents.EventFunction<IScrollHandler> s_ScrollHandler; // 0x58
	private static readonly ExecuteEvents.EventFunction<IUpdateSelectedHandler> s_UpdateSelectedHandler; // 0x60
	private static readonly ExecuteEvents.EventFunction<ISelectHandler> s_SelectHandler; // 0x68
	private static readonly ExecuteEvents.EventFunction<IDeselectHandler> s_DeselectHandler; // 0x70
	private static readonly ExecuteEvents.EventFunction<IMoveHandler> s_MoveHandler; // 0x78
	private static readonly ExecuteEvents.EventFunction<ISubmitHandler> s_SubmitHandler; // 0x80
	private static readonly ExecuteEvents.EventFunction<ICancelHandler> s_CancelHandler; // 0x88
	private static readonly List<Transform> s_InternalTransformList; // 0x90

	// Properties
	public static ExecuteEvents.EventFunction<IPointerMoveHandler> pointerMoveHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> pointerEnterHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerExitHandler> pointerExitHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerDownHandler> pointerDownHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerUpHandler> pointerUpHandler { get; }
	public static ExecuteEvents.EventFunction<IPointerClickHandler> pointerClickHandler { get; }
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> initializePotentialDrag { get; }
	public static ExecuteEvents.EventFunction<IBeginDragHandler> beginDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDragHandler> dragHandler { get; }
	public static ExecuteEvents.EventFunction<IEndDragHandler> endDragHandler { get; }
	public static ExecuteEvents.EventFunction<IDropHandler> dropHandler { get; }
	public static ExecuteEvents.EventFunction<IScrollHandler> scrollHandler { get; }
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> updateSelectedHandler { get; }
	public static ExecuteEvents.EventFunction<ISelectHandler> selectHandler { get; }
	public static ExecuteEvents.EventFunction<IDeselectHandler> deselectHandler { get; }
	public static ExecuteEvents.EventFunction<IMoveHandler> moveHandler { get; }
	public static ExecuteEvents.EventFunction<ISubmitHandler> submitHandler { get; }
	public static ExecuteEvents.EventFunction<ICancelHandler> cancelHandler { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T ValidateEventData<T>(BaseEventData data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110E310 Offset: 0x110A310 VA: 0x110E310
	|-ExecuteEvents.ValidateEventData<object>
	*/

	// RVA: 0x1F1A1C8 Offset: 0x1F161C8 VA: 0x1F1A1C8
	private static void Execute(IPointerMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1A2BC Offset: 0x1F162BC VA: 0x1F1A2BC
	private static void Execute(IPointerEnterHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1A3B0 Offset: 0x1F163B0 VA: 0x1F1A3B0
	private static void Execute(IPointerExitHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1A4A4 Offset: 0x1F164A4 VA: 0x1F1A4A4
	private static void Execute(IPointerDownHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1A598 Offset: 0x1F16598 VA: 0x1F1A598
	private static void Execute(IPointerUpHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1A68C Offset: 0x1F1668C VA: 0x1F1A68C
	private static void Execute(IPointerClickHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1A780 Offset: 0x1F16780 VA: 0x1F1A780
	private static void Execute(IInitializePotentialDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1A874 Offset: 0x1F16874 VA: 0x1F1A874
	private static void Execute(IBeginDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1A968 Offset: 0x1F16968 VA: 0x1F1A968
	private static void Execute(IDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1AA5C Offset: 0x1F16A5C VA: 0x1F1AA5C
	private static void Execute(IEndDragHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1AB50 Offset: 0x1F16B50 VA: 0x1F1AB50
	private static void Execute(IDropHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1AC44 Offset: 0x1F16C44 VA: 0x1F1AC44
	private static void Execute(IScrollHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1AD38 Offset: 0x1F16D38 VA: 0x1F1AD38
	private static void Execute(IUpdateSelectedHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1ADDC Offset: 0x1F16DDC VA: 0x1F1ADDC
	private static void Execute(ISelectHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1AE80 Offset: 0x1F16E80 VA: 0x1F1AE80
	private static void Execute(IDeselectHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1AF24 Offset: 0x1F16F24 VA: 0x1F1AF24
	private static void Execute(IMoveHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1B018 Offset: 0x1F17018 VA: 0x1F1B018
	private static void Execute(ISubmitHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1B0BC Offset: 0x1F170BC VA: 0x1F1B0BC
	private static void Execute(ICancelHandler handler, BaseEventData eventData) { }

	// RVA: 0x1F1B160 Offset: 0x1F17160 VA: 0x1F1B160
	public static ExecuteEvents.EventFunction<IPointerMoveHandler> get_pointerMoveHandler() { }

	// RVA: 0x1F1B1B8 Offset: 0x1F171B8 VA: 0x1F1B1B8
	public static ExecuteEvents.EventFunction<IPointerEnterHandler> get_pointerEnterHandler() { }

	// RVA: 0x1F1B210 Offset: 0x1F17210 VA: 0x1F1B210
	public static ExecuteEvents.EventFunction<IPointerExitHandler> get_pointerExitHandler() { }

	// RVA: 0x1F1B268 Offset: 0x1F17268 VA: 0x1F1B268
	public static ExecuteEvents.EventFunction<IPointerDownHandler> get_pointerDownHandler() { }

	// RVA: 0x1F1B2C0 Offset: 0x1F172C0 VA: 0x1F1B2C0
	public static ExecuteEvents.EventFunction<IPointerUpHandler> get_pointerUpHandler() { }

	// RVA: 0x1F1B318 Offset: 0x1F17318 VA: 0x1F1B318
	public static ExecuteEvents.EventFunction<IPointerClickHandler> get_pointerClickHandler() { }

	// RVA: 0x1F1B370 Offset: 0x1F17370 VA: 0x1F1B370
	public static ExecuteEvents.EventFunction<IInitializePotentialDragHandler> get_initializePotentialDrag() { }

	// RVA: 0x1F1B3C8 Offset: 0x1F173C8 VA: 0x1F1B3C8
	public static ExecuteEvents.EventFunction<IBeginDragHandler> get_beginDragHandler() { }

	// RVA: 0x1F1B420 Offset: 0x1F17420 VA: 0x1F1B420
	public static ExecuteEvents.EventFunction<IDragHandler> get_dragHandler() { }

	// RVA: 0x1F1B478 Offset: 0x1F17478 VA: 0x1F1B478
	public static ExecuteEvents.EventFunction<IEndDragHandler> get_endDragHandler() { }

	// RVA: 0x1F1B4D0 Offset: 0x1F174D0 VA: 0x1F1B4D0
	public static ExecuteEvents.EventFunction<IDropHandler> get_dropHandler() { }

	// RVA: 0x1F1B528 Offset: 0x1F17528 VA: 0x1F1B528
	public static ExecuteEvents.EventFunction<IScrollHandler> get_scrollHandler() { }

	// RVA: 0x1F1B580 Offset: 0x1F17580 VA: 0x1F1B580
	public static ExecuteEvents.EventFunction<IUpdateSelectedHandler> get_updateSelectedHandler() { }

	// RVA: 0x1F1B5D8 Offset: 0x1F175D8 VA: 0x1F1B5D8
	public static ExecuteEvents.EventFunction<ISelectHandler> get_selectHandler() { }

	// RVA: 0x1F1B630 Offset: 0x1F17630 VA: 0x1F1B630
	public static ExecuteEvents.EventFunction<IDeselectHandler> get_deselectHandler() { }

	// RVA: 0x1F1B688 Offset: 0x1F17688 VA: 0x1F1B688
	public static ExecuteEvents.EventFunction<IMoveHandler> get_moveHandler() { }

	// RVA: 0x1F1B6E0 Offset: 0x1F176E0 VA: 0x1F1B6E0
	public static ExecuteEvents.EventFunction<ISubmitHandler> get_submitHandler() { }

	// RVA: 0x1F1B738 Offset: 0x1F17738 VA: 0x1F1B738
	public static ExecuteEvents.EventFunction<ICancelHandler> get_cancelHandler() { }

	// RVA: 0x1F1B790 Offset: 0x1F17790 VA: 0x1F1B790
	private static void GetEventChain(GameObject root, IList<Transform> eventChain) { }

	// RVA: -1 Offset: -1
	public static bool Execute<T>(GameObject target, BaseEventData eventData, ExecuteEvents.EventFunction<T> functor) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110CD28 Offset: 0x1108D28 VA: 0x110CD28
	|-ExecuteEvents.Execute<object>
	|
	|-RVA: 0x110D100 Offset: 0x1109100 VA: 0x110D100
	|-ExecuteEvents.Execute<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static GameObject ExecuteHierarchy<T>(GameObject root, BaseEventData eventData, ExecuteEvents.EventFunction<T> callbackFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110D61C Offset: 0x110961C VA: 0x110D61C
	|-ExecuteEvents.ExecuteHierarchy<object>
	|
	|-RVA: 0x110D774 Offset: 0x1109774 VA: 0x110D774
	|-ExecuteEvents.ExecuteHierarchy<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static bool ShouldSendToComponent<T>(Component component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110E108 Offset: 0x110A108 VA: 0x110E108
	|-ExecuteEvents.ShouldSendToComponent<object>
	|
	|-RVA: 0x110E20C Offset: 0x110A20C VA: 0x110E20C
	|-ExecuteEvents.ShouldSendToComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private static void GetEventList<T>(GameObject go, IList<IEventSystemHandler> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110DB2C Offset: 0x1109B2C VA: 0x110DB2C
	|-ExecuteEvents.GetEventList<object>
	|
	|-RVA: 0x110DE18 Offset: 0x1109E18 VA: 0x110DE18
	|-ExecuteEvents.GetEventList<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static bool CanHandleEvent<T>(GameObject go) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110CB3C Offset: 0x1108B3C VA: 0x110CB3C
	|-ExecuteEvents.CanHandleEvent<object>
	|
	|-RVA: 0x110CC30 Offset: 0x1108C30 VA: 0x110CC30
	|-ExecuteEvents.CanHandleEvent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static GameObject GetEventHandler<T>(GameObject root) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x110D8D0 Offset: 0x11098D0 VA: 0x110D8D0
	|-ExecuteEvents.GetEventHandler<object>
	|
	|-RVA: 0x110D9FC Offset: 0x11099FC VA: 0x110D9FC
	|-ExecuteEvents.GetEventHandler<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1F1B924 Offset: 0x1F17924 VA: 0x1F1B924
	private static void .cctor() { }
}

// Namespace: UnityEngine.EventSystems
public class BaseInput : UIBehaviour // TypeDefIndex: 7401
{
	// Properties
	public virtual string compositionString { get; }
	public virtual IMECompositionMode imeCompositionMode { get; set; }
	public virtual Vector2 compositionCursorPos { get; set; }
	public virtual bool mousePresent { get; }
	public virtual Vector2 mousePosition { get; }
	public virtual Vector2 mouseScrollDelta { get; }
	public virtual float mouseScrollDeltaPerTick { get; }
	public virtual bool touchSupported { get; }
	public virtual int touchCount { get; }

	// Methods

	// RVA: 0x1F1C008 Offset: 0x1F18008 VA: 0x1F1C008 Slot: 17
	public virtual string get_compositionString() { }

	// RVA: 0x1F1C010 Offset: 0x1F18010 VA: 0x1F1C010 Slot: 18
	public virtual IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x1F1C018 Offset: 0x1F18018 VA: 0x1F1C018 Slot: 19
	public virtual void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x1F1C024 Offset: 0x1F18024 VA: 0x1F1C024 Slot: 20
	public virtual Vector2 get_compositionCursorPos() { }

	// RVA: 0x1F1C02C Offset: 0x1F1802C VA: 0x1F1C02C Slot: 21
	public virtual void set_compositionCursorPos(Vector2 value) { }

	// RVA: 0x1F1C034 Offset: 0x1F18034 VA: 0x1F1C034 Slot: 22
	public virtual bool get_mousePresent() { }

	// RVA: 0x1F1C03C Offset: 0x1F1803C VA: 0x1F1C03C Slot: 23
	public virtual bool GetMouseButtonDown(int button) { }

	// RVA: 0x1F1C048 Offset: 0x1F18048 VA: 0x1F1C048 Slot: 24
	public virtual bool GetMouseButtonUp(int button) { }

	// RVA: 0x1F1C054 Offset: 0x1F18054 VA: 0x1F1C054 Slot: 25
	public virtual bool GetMouseButton(int button) { }

	// RVA: 0x1F1C060 Offset: 0x1F18060 VA: 0x1F1C060 Slot: 26
	public virtual Vector2 get_mousePosition() { }

	// RVA: 0x1F1C068 Offset: 0x1F18068 VA: 0x1F1C068 Slot: 27
	public virtual Vector2 get_mouseScrollDelta() { }

	// RVA: 0x1F1C070 Offset: 0x1F18070 VA: 0x1F1C070 Slot: 28
	public virtual float get_mouseScrollDeltaPerTick() { }

	// RVA: 0x1F1C078 Offset: 0x1F18078 VA: 0x1F1C078 Slot: 29
	public virtual bool get_touchSupported() { }

	// RVA: 0x1F1C080 Offset: 0x1F18080 VA: 0x1F1C080 Slot: 30
	public virtual int get_touchCount() { }

	// RVA: 0x1F1C088 Offset: 0x1F18088 VA: 0x1F1C088 Slot: 31
	public virtual Touch GetTouch(int index) { }

	// RVA: 0x1F1C0C0 Offset: 0x1F180C0 VA: 0x1F1C0C0 Slot: 32
	public virtual float GetAxisRaw(string axisName) { }

	// RVA: 0x1F1C0CC Offset: 0x1F180CC VA: 0x1F1C0CC Slot: 33
	public virtual bool GetButtonDown(string buttonName) { }

	// RVA: 0x1F1C0D8 Offset: 0x1F180D8 VA: 0x1F1C0D8
	public void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
[RequireComponent(typeof(EventSystem))]
public abstract class BaseInputModule : UIBehaviour // TypeDefIndex: 7402
{
	// Fields
	protected List<RaycastResult> m_RaycastResultCache; // 0x20
	[SerializeField]
	private bool m_SendPointerHoverToParent; // 0x28
	private AxisEventData m_AxisEventData; // 0x30
	private EventSystem m_EventSystem; // 0x38
	private BaseEventData m_BaseEventData; // 0x40
	protected BaseInput m_InputOverride; // 0x48
	private BaseInput m_DefaultInput; // 0x50

	// Properties
	protected internal bool sendPointerHoverToParent { get; set; }
	public BaseInput input { get; }
	public BaseInput inputOverride { get; set; }
	protected EventSystem eventSystem { get; }

	// Methods

	// RVA: 0x1F1C0E0 Offset: 0x1F180E0 VA: 0x1F1C0E0
	protected internal bool get_sendPointerHoverToParent() { }

	// RVA: 0x1F1C0E8 Offset: 0x1F180E8 VA: 0x1F1C0E8
	protected internal void set_sendPointerHoverToParent(bool value) { }

	// RVA: 0x1F1C0F0 Offset: 0x1F180F0 VA: 0x1F1C0F0
	public BaseInput get_input() { }

	// RVA: 0x1F1C314 Offset: 0x1F18314 VA: 0x1F1C314
	public BaseInput get_inputOverride() { }

	// RVA: 0x1F1C31C Offset: 0x1F1831C VA: 0x1F1C31C
	public void set_inputOverride(BaseInput value) { }

	// RVA: 0x1F1C324 Offset: 0x1F18324 VA: 0x1F1C324
	protected EventSystem get_eventSystem() { }

	// RVA: 0x1F1C32C Offset: 0x1F1832C VA: 0x1F1C32C Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1F1C394 Offset: 0x1F18394 VA: 0x1F1C394 Slot: 7
	protected override void OnDisable() { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Process();

	// RVA: 0x1F1C3A8 Offset: 0x1F183A8 VA: 0x1F1C3A8
	protected static RaycastResult FindFirstRaycast(List<RaycastResult> candidates) { }

	// RVA: 0x1F1C4BC Offset: 0x1F184BC VA: 0x1F1C4BC
	protected static MoveDirection DetermineMoveDirection(float x, float y) { }

	// RVA: 0x1F1C510 Offset: 0x1F18510 VA: 0x1F1C510
	protected static MoveDirection DetermineMoveDirection(float x, float y, float deadZone) { }

	// RVA: 0x1F1C560 Offset: 0x1F18560 VA: 0x1F1C560
	protected static GameObject FindCommonRoot(GameObject g1, GameObject g2) { }

	// RVA: 0x1F1C6D4 Offset: 0x1F186D4 VA: 0x1F1C6D4
	protected void HandlePointerExitAndEnter(PointerEventData currentPointerData, GameObject newEnterTarget) { }

	// RVA: 0x1F1D198 Offset: 0x1F19198 VA: 0x1F1D198 Slot: 18
	protected virtual AxisEventData GetAxisEventData(float x, float y, float moveDeadZone) { }

	// RVA: 0x1F1D2AC Offset: 0x1F192AC VA: 0x1F1D2AC Slot: 19
	protected virtual BaseEventData GetBaseEventData() { }

	// RVA: 0x1F1D354 Offset: 0x1F19354 VA: 0x1F1D354 Slot: 20
	public virtual bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x1F1D35C Offset: 0x1F1935C VA: 0x1F1D35C Slot: 21
	public virtual bool ShouldActivateModule() { }

	// RVA: 0x1F1D39C Offset: 0x1F1939C VA: 0x1F1D39C Slot: 22
	public virtual void DeactivateModule() { }

	// RVA: 0x1F1D3A0 Offset: 0x1F193A0 VA: 0x1F1D3A0 Slot: 23
	public virtual void ActivateModule() { }

	// RVA: 0x1F1D3A4 Offset: 0x1F193A4 VA: 0x1F1D3A4 Slot: 24
	public virtual void UpdateModule() { }

	// RVA: 0x1F1D3A8 Offset: 0x1F193A8 VA: 0x1F1D3A8 Slot: 25
	public virtual bool IsModuleSupported() { }

	// RVA: 0x1F1D3B0 Offset: 0x1F193B0 VA: 0x1F1D3B0 Slot: 26
	public virtual int ConvertUIToolkitPointerId(PointerEventData sourcePointerData) { }

	// RVA: 0x1F1D3B8 Offset: 0x1F193B8 VA: 0x1F1D3B8 Slot: 27
	public virtual Vector2 ConvertPointerEventScrollDeltaToTicks(Vector2 scrollDelta) { }

	// RVA: 0x1F1D3FC Offset: 0x1F193FC VA: 0x1F1D3FC
	protected void .ctor() { }
}

// Namespace: 
protected class PointerInputModule.ButtonState // TypeDefIndex: 7403
{
	// Fields
	private PointerEventData.InputButton m_Button; // 0x10
	private PointerInputModule.MouseButtonEventData m_EventData; // 0x18

	// Properties
	public PointerInputModule.MouseButtonEventData eventData { get; set; }
	public PointerEventData.InputButton button { get; set; }

	// Methods

	// RVA: 0x1F1E824 Offset: 0x1F1A824 VA: 0x1F1E824
	public PointerInputModule.MouseButtonEventData get_eventData() { }

	// RVA: 0x1F1E82C Offset: 0x1F1A82C VA: 0x1F1E82C
	public void set_eventData(PointerInputModule.MouseButtonEventData value) { }

	// RVA: 0x1F1E834 Offset: 0x1F1A834 VA: 0x1F1E834
	public PointerEventData.InputButton get_button() { }

	// RVA: 0x1F1E83C Offset: 0x1F1A83C VA: 0x1F1E83C
	public void set_button(PointerEventData.InputButton value) { }

	// RVA: 0x1F1E844 Offset: 0x1F1A844 VA: 0x1F1E844
	public void .ctor() { }
}

// Namespace: 
protected class PointerInputModule.MouseState // TypeDefIndex: 7404
{
	// Fields
	private List<PointerInputModule.ButtonState> m_TrackedButtons; // 0x10

	// Methods

	// RVA: 0x1F1E84C Offset: 0x1F1A84C VA: 0x1F1E84C
	public bool AnyPressesThisFrame() { }

	// RVA: 0x1F1E91C Offset: 0x1F1A91C VA: 0x1F1E91C
	public bool AnyReleasesThisFrame() { }

	// RVA: 0x1F1E9F4 Offset: 0x1F1A9F4 VA: 0x1F1E9F4
	public PointerInputModule.ButtonState GetButtonState(PointerEventData.InputButton button) { }

	// RVA: 0x1F1DDB4 Offset: 0x1F19DB4 VA: 0x1F1DDB4
	public void SetButtonState(PointerEventData.InputButton button, PointerEventData.FramePressState stateForMouseButton, PointerEventData data) { }

	// RVA: 0x1F1E79C Offset: 0x1F1A79C VA: 0x1F1E79C
	public void .ctor() { }
}

// Namespace: 
public class PointerInputModule.MouseButtonEventData // TypeDefIndex: 7405
{
	// Fields
	public PointerEventData.FramePressState buttonState; // 0x10
	public PointerEventData buttonData; // 0x18

	// Methods

	// RVA: 0x1F1E90C Offset: 0x1F1A90C VA: 0x1F1E90C
	public bool PressedThisFrame() { }

	// RVA: 0x1F1E9E0 Offset: 0x1F1A9E0 VA: 0x1F1E9E0
	public bool ReleasedThisFrame() { }

	// RVA: 0x1F1EB9C Offset: 0x1F1AB9C VA: 0x1F1EB9C
	public void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
public abstract class PointerInputModule : BaseInputModule // TypeDefIndex: 7406
{
	// Fields
	public const int kMouseLeftId = -1;
	public const int kMouseRightId = -2;
	public const int kMouseMiddleId = -3;
	public const int kFakeTouchesId = -4;
	protected Dictionary<int, PointerEventData> m_PointerData; // 0x58
	private readonly PointerInputModule.MouseState m_MouseState; // 0x60

	// Methods

	// RVA: 0x1F1D48C Offset: 0x1F1948C VA: 0x1F1D48C
	protected bool GetPointerData(int id, out PointerEventData data, bool create) { }

	// RVA: 0x1F1D584 Offset: 0x1F19584 VA: 0x1F1D584
	protected void RemovePointerData(PointerEventData data) { }

	// RVA: 0x1F1D5E0 Offset: 0x1F195E0 VA: 0x1F1D5E0
	protected PointerEventData GetTouchPointerEventData(Touch input, out bool pressed, out bool released) { }

	// RVA: 0x1F1D944 Offset: 0x1F19944 VA: 0x1F1D944
	protected void CopyFromTo(PointerEventData from, PointerEventData to) { }

	// RVA: 0x1F1DA00 Offset: 0x1F19A00 VA: 0x1F1DA00
	protected PointerEventData.FramePressState StateForMouseButton(int buttonId) { }

	// RVA: 0x1F1DA7C Offset: 0x1F19A7C VA: 0x1F1DA7C Slot: 28
	protected virtual PointerInputModule.MouseState GetMousePointerEventData() { }

	// RVA: 0x1F1DA90 Offset: 0x1F19A90 VA: 0x1F1DA90 Slot: 29
	protected virtual PointerInputModule.MouseState GetMousePointerEventData(int id) { }

	// RVA: 0x1F1DDF0 Offset: 0x1F19DF0 VA: 0x1F1DDF0
	protected PointerEventData GetLastPointerEventData(int id) { }

	// RVA: 0x1F1DE0C Offset: 0x1F19E0C VA: 0x1F1DE0C
	private static bool ShouldStartDrag(Vector2 pressPos, Vector2 currentPos, float threshold, bool useDragThreshold) { }

	// RVA: 0x1F1DE3C Offset: 0x1F19E3C VA: 0x1F1DE3C Slot: 30
	protected virtual void ProcessMove(PointerEventData pointerEvent) { }

	// RVA: 0x1F1DE80 Offset: 0x1F19E80 VA: 0x1F1DE80 Slot: 31
	protected virtual void ProcessDrag(PointerEventData pointerEvent) { }

	// RVA: 0x1F1E14C Offset: 0x1F1A14C VA: 0x1F1E14C Slot: 20
	public override bool IsPointerOverGameObject(int pointerId) { }

	// RVA: 0x1F1E1E8 Offset: 0x1F1A1E8 VA: 0x1F1E1E8
	protected void ClearSelection() { }

	// RVA: 0x1F1E394 Offset: 0x1F1A394 VA: 0x1F1E394 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F1E5F8 Offset: 0x1F1A5F8 VA: 0x1F1E5F8
	protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent) { }

	// RVA: 0x1F1E6E4 Offset: 0x1F1A6E4 VA: 0x1F1E6E4
	protected void .ctor() { }
}

// Namespace: 
[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
public enum StandaloneInputModule.InputMode // TypeDefIndex: 7407
{
	// Fields
	public int value__; // 0x0
	public const StandaloneInputModule.InputMode Mouse = 0;
	public const StandaloneInputModule.InputMode Buttons = 1;
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Standalone Input Module")]
public class StandaloneInputModule : PointerInputModule // TypeDefIndex: 7408
{
	// Fields
	private float m_PrevActionTime; // 0x68
	private Vector2 m_LastMoveVector; // 0x6C
	private int m_ConsecutiveMoveCount; // 0x74
	private Vector2 m_LastMousePosition; // 0x78
	private Vector2 m_MousePosition; // 0x80
	private GameObject m_CurrentFocusedGameObject; // 0x88
	private readonly Dictionary<int, PointerEventData> m_InputPointerEvents; // 0x90
	private const float doubleClickTime = 0.3;
	[SerializeField]
	private string m_HorizontalAxis; // 0x98
	[SerializeField]
	private string m_VerticalAxis; // 0xA0
	[SerializeField]
	private string m_SubmitButton; // 0xA8
	[SerializeField]
	private string m_CancelButton; // 0xB0
	[SerializeField]
	private float m_InputActionsPerSecond; // 0xB8
	[SerializeField]
	private float m_RepeatDelay; // 0xBC
	[SerializeField]
	[FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
	[HideInInspector]
	private bool m_ForceModuleActive; // 0xC0

	// Properties
	[Obsolete("Mode is no longer needed on input module as it handles both mouse and keyboard simultaneously.", False)]
	public StandaloneInputModule.InputMode inputMode { get; }
	[Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	public bool allowActivationOnMobileDevice { get; set; }
	[Obsolete("forceModuleActive has been deprecated. There is no need to force the module awake as StandaloneInputModule works for all platforms")]
	public bool forceModuleActive { get; set; }
	public float inputActionsPerSecond { get; set; }
	public float repeatDelay { get; set; }
	public string horizontalAxis { get; set; }
	public string verticalAxis { get; set; }
	public string submitButton { get; set; }
	public string cancelButton { get; set; }

	// Methods

	// RVA: 0x1F1EBA4 Offset: 0x1F1ABA4 VA: 0x1F1EBA4
	protected void .ctor() { }

	// RVA: 0x1F1ECD4 Offset: 0x1F1ACD4 VA: 0x1F1ECD4
	public StandaloneInputModule.InputMode get_inputMode() { }

	// RVA: 0x1F1ECDC Offset: 0x1F1ACDC VA: 0x1F1ECDC
	public bool get_allowActivationOnMobileDevice() { }

	// RVA: 0x1F1ECE4 Offset: 0x1F1ACE4 VA: 0x1F1ECE4
	public void set_allowActivationOnMobileDevice(bool value) { }

	// RVA: 0x1F1ECEC Offset: 0x1F1ACEC VA: 0x1F1ECEC
	public bool get_forceModuleActive() { }

	// RVA: 0x1F1ECF4 Offset: 0x1F1ACF4 VA: 0x1F1ECF4
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x1F1ECFC Offset: 0x1F1ACFC VA: 0x1F1ECFC
	public float get_inputActionsPerSecond() { }

	// RVA: 0x1F1ED04 Offset: 0x1F1AD04 VA: 0x1F1ED04
	public void set_inputActionsPerSecond(float value) { }

	// RVA: 0x1F1ED0C Offset: 0x1F1AD0C VA: 0x1F1ED0C
	public float get_repeatDelay() { }

	// RVA: 0x1F1ED14 Offset: 0x1F1AD14 VA: 0x1F1ED14
	public void set_repeatDelay(float value) { }

	// RVA: 0x1F1ED1C Offset: 0x1F1AD1C VA: 0x1F1ED1C
	public string get_horizontalAxis() { }

	// RVA: 0x1F1ED24 Offset: 0x1F1AD24 VA: 0x1F1ED24
	public void set_horizontalAxis(string value) { }

	// RVA: 0x1F1ED2C Offset: 0x1F1AD2C VA: 0x1F1ED2C
	public string get_verticalAxis() { }

	// RVA: 0x1F1ED34 Offset: 0x1F1AD34 VA: 0x1F1ED34
	public void set_verticalAxis(string value) { }

	// RVA: 0x1F1ED3C Offset: 0x1F1AD3C VA: 0x1F1ED3C
	public string get_submitButton() { }

	// RVA: 0x1F1ED44 Offset: 0x1F1AD44 VA: 0x1F1ED44
	public void set_submitButton(string value) { }

	// RVA: 0x1F1ED4C Offset: 0x1F1AD4C VA: 0x1F1ED4C
	public string get_cancelButton() { }

	// RVA: 0x1F1ED54 Offset: 0x1F1AD54 VA: 0x1F1ED54
	public void set_cancelButton(string value) { }

	// RVA: 0x1F1ED5C Offset: 0x1F1AD5C VA: 0x1F1ED5C
	private bool ShouldIgnoreEventsOnNoFocus() { }

	// RVA: 0x1F1ED64 Offset: 0x1F1AD64 VA: 0x1F1ED64 Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x1F1EDBC Offset: 0x1F1ADBC VA: 0x1F1EDBC
	private void ReleasePointerDrags() { }

	// RVA: 0x1F1F268 Offset: 0x1F1B268 VA: 0x1F1F268
	private void ReleaseMouse(PointerEventData pointerEvent, GameObject currentOverGo) { }

	// RVA: 0x1F1F628 Offset: 0x1F1B628 VA: 0x1F1F628 Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x1F1F854 Offset: 0x1F1B854 VA: 0x1F1F854 Slot: 23
	public override void ActivateModule() { }

	// RVA: 0x1F1F954 Offset: 0x1F1B954 VA: 0x1F1F954 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x1F1F958 Offset: 0x1F1B958 VA: 0x1F1F958 Slot: 17
	public override void Process() { }

	// RVA: 0x1F1FB44 Offset: 0x1F1BB44 VA: 0x1F1FB44
	private bool ProcessTouchEvents() { }

	// RVA: 0x1F20128 Offset: 0x1F1C128 VA: 0x1F20128
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x1F1FF14 Offset: 0x1F1BF14 VA: 0x1F1FF14
	protected bool SendSubmitEventToSelectedObject() { }

	// RVA: 0x1F20870 Offset: 0x1F1C870 VA: 0x1F20870
	private Vector2 GetRawMoveVector() { }

	// RVA: 0x1F1FCB0 Offset: 0x1F1BCB0 VA: 0x1F1FCB0
	protected bool SendMoveEventToSelectedObject() { }

	// RVA: 0x1F1FCA8 Offset: 0x1F1BCA8 VA: 0x1F1FCA8
	protected void ProcessMouseEvent() { }

	[Obsolete("This method is no longer checked, overriding it with return true does nothing!")]
	// RVA: 0x1F20C2C Offset: 0x1F1CC2C VA: 0x1F20C2C Slot: 32
	protected virtual bool ForceAutoSelect() { }

	// RVA: 0x1F2097C Offset: 0x1F1C97C VA: 0x1F2097C
	protected void ProcessMouseEvent(int id) { }

	// RVA: 0x1F1F9FC Offset: 0x1F1B9FC VA: 0x1F1F9FC
	protected bool SendUpdateEventToSelectedObject() { }

	// RVA: 0x1F20C34 Offset: 0x1F1CC34 VA: 0x1F20C34
	protected void ProcessMousePress(PointerInputModule.MouseButtonEventData data) { }

	// RVA: 0x1F21010 Offset: 0x1F1D010 VA: 0x1F21010
	protected GameObject GetCurrentFocusedGameObject() { }
}

// Namespace: UnityEngine.EventSystems
[Obsolete("TouchInputModule is no longer required as Touch input is now handled in StandaloneInputModule.")]
[AddComponentMenu("Event/Touch Input Module")]
public class TouchInputModule : PointerInputModule // TypeDefIndex: 7409
{
	// Fields
	private Vector2 m_LastMousePosition; // 0x68
	private Vector2 m_MousePosition; // 0x70
	private PointerEventData m_InputPointerEvent; // 0x78
	[SerializeField]
	[FormerlySerializedAs("m_AllowActivationOnStandalone")]
	private bool m_ForceModuleActive; // 0x80

	// Properties
	[Obsolete("allowActivationOnStandalone has been deprecated. Use forceModuleActive instead (UnityUpgradable) -> forceModuleActive")]
	public bool allowActivationOnStandalone { get; set; }
	public bool forceModuleActive { get; set; }

	// Methods

	// RVA: 0x1F21018 Offset: 0x1F1D018 VA: 0x1F21018
	protected void .ctor() { }

	// RVA: 0x1F2101C Offset: 0x1F1D01C VA: 0x1F2101C
	public bool get_allowActivationOnStandalone() { }

	// RVA: 0x1F21024 Offset: 0x1F1D024 VA: 0x1F21024
	public void set_allowActivationOnStandalone(bool value) { }

	// RVA: 0x1F2102C Offset: 0x1F1D02C VA: 0x1F2102C
	public bool get_forceModuleActive() { }

	// RVA: 0x1F21034 Offset: 0x1F1D034 VA: 0x1F21034
	public void set_forceModuleActive(bool value) { }

	// RVA: 0x1F2103C Offset: 0x1F1D03C VA: 0x1F2103C Slot: 24
	public override void UpdateModule() { }

	// RVA: 0x1F211A4 Offset: 0x1F1D1A4 VA: 0x1F211A4 Slot: 25
	public override bool IsModuleSupported() { }

	// RVA: 0x1F211DC Offset: 0x1F1D1DC VA: 0x1F211DC Slot: 21
	public override bool ShouldActivateModule() { }

	// RVA: 0x1F21288 Offset: 0x1F1D288 VA: 0x1F21288
	private bool UseFakeInput() { }

	// RVA: 0x1F212B8 Offset: 0x1F1D2B8 VA: 0x1F212B8 Slot: 17
	public override void Process() { }

	// RVA: 0x1F212E0 Offset: 0x1F1D2E0 VA: 0x1F212E0
	private void FakeTouches() { }

	// RVA: 0x1F2140C Offset: 0x1F1D40C VA: 0x1F2140C
	private void ProcessTouchEvents() { }

	// RVA: 0x1F21550 Offset: 0x1F1D550 VA: 0x1F21550
	protected void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released) { }

	// RVA: 0x1F21C74 Offset: 0x1F1DC74 VA: 0x1F21C74 Slot: 22
	public override void DeactivateModule() { }

	// RVA: 0x1F21C78 Offset: 0x1F1DC78 VA: 0x1F21C78 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.EventSystems
public enum MoveDirection // TypeDefIndex: 7410
{
	// Fields
	public int value__; // 0x0
	public const MoveDirection Left = 0;
	public const MoveDirection Up = 1;
	public const MoveDirection Right = 2;
	public const MoveDirection Down = 3;
	public const MoveDirection None = 4;
}

// Namespace: UnityEngine.EventSystems
public struct RaycastResult // TypeDefIndex: 7411
{
	// Fields
	private GameObject m_GameObject; // 0x0
	public BaseRaycaster module; // 0x8
	public float distance; // 0x10
	public float index; // 0x14
	public int depth; // 0x18
	public int sortingGroupID; // 0x1C
	public int sortingGroupOrder; // 0x20
	public int sortingLayer; // 0x24
	public int sortingOrder; // 0x28
	public Vector3 worldPosition; // 0x2C
	public Vector3 worldNormal; // 0x38
	public Vector2 screenPosition; // 0x44
	public int displayIndex; // 0x4C

	// Properties
	public GameObject gameObject { get; set; }
	public bool isValid { get; }

	// Methods

	// RVA: 0x1F21EB4 Offset: 0x1F1DEB4 VA: 0x1F21EB4
	public GameObject get_gameObject() { }

	// RVA: 0x1F21EBC Offset: 0x1F1DEBC VA: 0x1F21EBC
	public void set_gameObject(GameObject value) { }

	// RVA: 0x1F21EC4 Offset: 0x1F1DEC4 VA: 0x1F21EC4
	public bool get_isValid() { }

	// RVA: 0x1F21F5C Offset: 0x1F1DF5C VA: 0x1F21F5C
	public void Clear() { }

	// RVA: 0x1F183E0 Offset: 0x1F143E0 VA: 0x1F183E0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.EventSystems
public static class RaycasterManager // TypeDefIndex: 7412
{
	// Fields
	private static readonly List<BaseRaycaster> s_Raycasters; // 0x0

	// Methods

	// RVA: 0x1F22020 Offset: 0x1F1E020 VA: 0x1F22020
	internal static void AddRaycaster(BaseRaycaster baseRaycaster) { }

	// RVA: 0x1F22144 Offset: 0x1F1E144 VA: 0x1F22144
	public static List<BaseRaycaster> GetRaycasters() { }

	// RVA: 0x1F2219C Offset: 0x1F1E19C VA: 0x1F2219C
	internal static void RemoveRaycasters(BaseRaycaster baseRaycaster) { }

	// RVA: 0x1F2226C Offset: 0x1F1E26C VA: 0x1F2226C
	private static void .cctor() { }
}

// Namespace: UnityEngine.EventSystems
public abstract class BaseRaycaster : UIBehaviour // TypeDefIndex: 7413
{
	// Fields
	private BaseRaycaster m_RootRaycaster; // 0x20

	// Properties
	public abstract Camera eventCamera { get; }
	[Obsolete("Please use sortOrderPriority and renderOrderPriority", False)]
	public virtual int priority { get; }
	public virtual int sortOrderPriority { get; }
	public virtual int renderOrderPriority { get; }
	public BaseRaycaster rootRaycaster { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract Camera get_eventCamera();

	// RVA: 0x1F22304 Offset: 0x1F1E304 VA: 0x1F22304 Slot: 19
	public virtual int get_priority() { }

	// RVA: 0x1F2230C Offset: 0x1F1E30C VA: 0x1F2230C Slot: 20
	public virtual int get_sortOrderPriority() { }

	// RVA: 0x1F22314 Offset: 0x1F1E314 VA: 0x1F22314 Slot: 21
	public virtual int get_renderOrderPriority() { }

	// RVA: 0x1F192B8 Offset: 0x1F152B8 VA: 0x1F192B8
	public BaseRaycaster get_rootRaycaster() { }

	// RVA: 0x1F2231C Offset: 0x1F1E31C VA: 0x1F2231C Slot: 3
	public override string ToString() { }

	// RVA: 0x1F22568 Offset: 0x1F1E568 VA: 0x1F22568 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x1F225BC Offset: 0x1F1E5BC VA: 0x1F225BC Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x1F22610 Offset: 0x1F1E610 VA: 0x1F22610 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x1F22620 Offset: 0x1F1E620 VA: 0x1F22620 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x1F22630 Offset: 0x1F1E630 VA: 0x1F22630
	protected void .ctor() { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Physics 2D Raycaster")]
[RequireComponent(typeof(Camera))]
public class Physics2DRaycaster : PhysicsRaycaster // TypeDefIndex: 7414
{
	// Fields
	private RaycastHit2D[] m_Hits; // 0x40

	// Methods

	// RVA: 0x1F22638 Offset: 0x1F1E638 VA: 0x1F22638
	protected void .ctor() { }

	// RVA: 0x1F22690 Offset: 0x1F1E690 VA: 0x1F22690 Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }
}

// Namespace: UnityEngine.EventSystems
[AddComponentMenu("Event/Physics Raycaster")]
[RequireComponent(typeof(Camera))]
public class PhysicsRaycaster : BaseRaycaster // TypeDefIndex: 7415
{
	// Fields
	protected const int kNoEventMaskSet = -1;
	protected Camera m_EventCamera; // 0x28
	[SerializeField]
	protected LayerMask m_EventMask; // 0x30
	[SerializeField]
	protected int m_MaxRayIntersections; // 0x34
	protected int m_LastMaxRayIntersections; // 0x38

	// Properties
	public override Camera eventCamera { get; }
	public virtual int depth { get; }
	public int finalEventMask { get; }
	public LayerMask eventMask { get; set; }
	public int maxRayIntersections { get; set; }

	// Methods

	// RVA: 0x1F22664 Offset: 0x1F1E664 VA: 0x1F22664
	protected void .ctor() { }

	// RVA: 0x1F23134 Offset: 0x1F1F134 VA: 0x1F23134 Slot: 18
	public override Camera get_eventCamera() { }

	// RVA: 0x1F23218 Offset: 0x1F1F218 VA: 0x1F23218 Slot: 22
	public virtual int get_depth() { }

	// RVA: 0x1F23070 Offset: 0x1F1F070 VA: 0x1F23070
	public int get_finalEventMask() { }

	// RVA: 0x1F232DC Offset: 0x1F1F2DC VA: 0x1F232DC
	public LayerMask get_eventMask() { }

	// RVA: 0x1F232E4 Offset: 0x1F1F2E4 VA: 0x1F232E4
	public void set_eventMask(LayerMask value) { }

	// RVA: 0x1F232EC Offset: 0x1F1F2EC VA: 0x1F232EC
	public int get_maxRayIntersections() { }

	// RVA: 0x1F232F4 Offset: 0x1F1F2F4 VA: 0x1F232F4
	public void set_maxRayIntersections(int value) { }

	// RVA: 0x1F22D7C Offset: 0x1F1ED7C VA: 0x1F22D7C
	protected bool ComputeRayAndDistance(PointerEventData eventData, ref Ray ray, ref int eventDisplayIndex, ref float distanceToClipPlane) { }

	// RVA: 0x1F232FC Offset: 0x1F1F2FC VA: 0x1F232FC Slot: 17
	public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList) { }
}

// Namespace: UnityEngine.EventSystems
public abstract class UIBehaviour : MonoBehaviour // TypeDefIndex: 7416
{
	// Methods

	// RVA: 0x1F23300 Offset: 0x1F1F300 VA: 0x1F23300 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1F196F8 Offset: 0x1F156F8 VA: 0x1F196F8 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x1F19620 Offset: 0x1F15620 VA: 0x1F19620 Slot: 6
	protected virtual void Start() { }

	// RVA: 0x1F197E4 Offset: 0x1F157E4 VA: 0x1F197E4 Slot: 7
	protected virtual void OnDisable() { }

	// RVA: 0x1F23304 Offset: 0x1F1F304 VA: 0x1F23304 Slot: 8
	protected virtual void OnDestroy() { }

	// RVA: 0x1F23308 Offset: 0x1F1F308 VA: 0x1F23308 Slot: 9
	public virtual bool IsActive() { }

	// RVA: 0x1F23310 Offset: 0x1F1F310 VA: 0x1F23310 Slot: 10
	protected virtual void OnRectTransformDimensionsChange() { }

	// RVA: 0x1F23314 Offset: 0x1F1F314 VA: 0x1F23314 Slot: 11
	protected virtual void OnBeforeTransformParentChanged() { }

	// RVA: 0x1F2262C Offset: 0x1F1E62C VA: 0x1F2262C Slot: 12
	protected virtual void OnTransformParentChanged() { }

	// RVA: 0x1F23318 Offset: 0x1F1F318 VA: 0x1F23318 Slot: 13
	protected virtual void OnDidApplyAnimationProperties() { }

	// RVA: 0x1F2331C Offset: 0x1F1F31C VA: 0x1F2331C Slot: 14
	protected virtual void OnCanvasGroupChanged() { }

	// RVA: 0x1F2261C Offset: 0x1F1E61C VA: 0x1F2261C Slot: 15
	protected virtual void OnCanvasHierarchyChanged() { }

	// RVA: 0x1F23320 Offset: 0x1F1F320 VA: 0x1F23320 Slot: 16
	public bool IsDestroyed() { }

	// RVA: 0x1F18CC8 Offset: 0x1F14CC8 VA: 0x1F18CC8
	protected void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 // TypeDefIndex: 7417
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5252 // TypeDefIndex: 7418
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7876 // TypeDefIndex: 7419
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7420
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=12 1C3635C112D556F4C11A4FE6BDE6ED3F126C4B2B546811BDB64DE7BDED3A05CB /*Metadata offset 0x3EC5C0*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=5252 6313B8249AD2D089DB33EC021C0D297858C2B750A46BFD48F7215F86285EB9FD /*Metadata offset 0x3EC5D0*/; // 0xC
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=7876 9022A97D6839B34DDD7A65DF0997B86131435A461468FA01CFB837A4898A6BB3 /*Metadata offset 0x3EDA58*/; // 0x1490
}

// Namespace: 
internal class <Module> // TypeDefIndex: 7421
{}
