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

// Namespace: game.ui.rightHotkey
public class ButtonAutoplay : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler // TypeDefIndex: 2866
{
	// Fields
	[SerializeField]
	private Button autoplayButton; // 0x20
	[SerializeField]
	private GameObject autoplayTextName; // 0x28
	[SerializeField]
	private TextMeshProUGUI autoplayTextmesh; // 0x30
	[SerializeField]
	private GameObject autoplayImageLoading; // 0x38
	[SerializeField]
	private GameObject profilePannel; // 0x40
	[SerializeField]
	private Button profileButton; // 0x48
	[SerializeField]
	private GameObject profileList; // 0x50
	[SerializeField]
	private GameObject profileTemplateGo; // 0x58
	private ButtonAutoplay.ProfileTemplate profileTemplate; // 0x60
	private long pointerDownStart; // 0x68
	private bool needOnOpenRerenderProfiles; // 0x70
	private bool needOnOpenReloadProfiles; // 0x71
	private bool needOnOpenReloadCreateProfileWhenEmpty; // 0x72

	// Methods

	// RVA: 0xEF107C Offset: 0xEED07C VA: 0xEF107C
	private void Start() { }

	// RVA: 0xEF13DC Offset: 0xEED3DC VA: 0xEF13DC
	private void Update() { }

	// RVA: 0xEF1C08 Offset: 0xEEDC08 VA: 0xEF1C08 Slot: 6
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0xEF1D58 Offset: 0xEEDD58 VA: 0xEF1D58 Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xEF1D74 Offset: 0xEEDD74 VA: 0xEF1D74 Slot: 5
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xEF1D7C Offset: 0xEEDD7C VA: 0xEF1D7C
	public void SetOnOpenRerenderProfiles(bool enabled) { }

	// RVA: 0xEF1D84 Offset: 0xEEDD84 VA: 0xEF1D84
	public void SetOnOpenReloadProfiles(bool enabled, bool createProfileWhenEmpty) { }

	// RVA: 0xEF1480 Offset: 0xEED480 VA: 0xEF1480
	public void OpenProfile() { }

	// RVA: 0xEF1E40 Offset: 0xEEDE40 VA: 0xEF1E40
	public void OnSelectProfile(string profileGuid) { }

	// RVA: 0xEF1F4C Offset: 0xEEDF4C VA: 0xEF1F4C
	public bool EnableAutoplay(bool enabled, bool resetMovingPoint = True) { }

	// RVA: 0xEF2090 Offset: 0xEEE090 VA: 0xEF2090
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEF2098 Offset: 0xEEE098 VA: 0xEF2098
	private void <Start>b__14_0() { }

	[CompilerGenerated]
	// RVA: 0xEF20B4 Offset: 0xEEE0B4 VA: 0xEF20B4
	private void <OpenProfile>b__21_0() { }

	[CompilerGenerated]
	// RVA: 0xEF22E8 Offset: 0xEEE2E8 VA: 0xEF22E8
	private void <OpenProfile>b__21_1() { }
}

// Namespace: game.ui.rightHotkey
public class ButtonItem : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler // TypeDefIndex: 2867
{
	// Fields
	private bool isPointerDown; // 0x20
	private long pointerDownStart; // 0x28
	public Action onTouch; // 0x30

	// Methods

	// RVA: 0xEF23E8 Offset: 0xEEE3E8 VA: 0xEF23E8
	private void Update() { }

	// RVA: 0xEF243C Offset: 0xEEE43C VA: 0xEF243C
	private void OnDisable() { }

	// RVA: 0xEF2444 Offset: 0xEEE444 VA: 0xEF2444 Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xEF2484 Offset: 0xEEE484 VA: 0xEF2484 Slot: 5
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xEF248C Offset: 0xEEE48C VA: 0xEF248C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class BUttonNotifyAttention.<>c // TypeDefIndex: 2868
{
	// Fields
	public static readonly BUttonNotifyAttention.<>c <>9; // 0x0
	public static UnityAction <>9__4_0; // 0x8

	// Methods

	// RVA: 0xEF268C Offset: 0xEEE68C VA: 0xEF268C
	private static void .cctor() { }

	// RVA: 0xEF26F4 Offset: 0xEEE6F4 VA: 0xEF26F4
	public void .ctor() { }

	// RVA: 0xEF26FC Offset: 0xEEE6FC VA: 0xEF26FC
	internal void <Start>b__4_0() { }
}

// Namespace: game.ui.rightHotkey
public class BUttonNotifyAttention : MonoBehaviour // TypeDefIndex: 2869
{
	// Fields
	[SerializeField]
	private Image icon; // 0x20
	[SerializeField]
	private Button button; // 0x28
	private float nextAttentionDelta; // 0x30

	// Methods

	// RVA: 0xEF2494 Offset: 0xEEE494 VA: 0xEF2494
	private void Awake() { }

	// RVA: 0xEF24B8 Offset: 0xEEE4B8 VA: 0xEF24B8
	private void Start() { }

	// RVA: 0xEF25B0 Offset: 0xEEE5B0 VA: 0xEF25B0
	private void Update() { }

	// RVA: 0xEF263C Offset: 0xEEE63C VA: 0xEF263C
	public void Begin() { }

	// RVA: 0xEF2660 Offset: 0xEEE660 VA: 0xEF2660
	public void End() { }

	// RVA: 0xEF2684 Offset: 0xEEE684 VA: 0xEF2684
	public void .ctor() { }
}

// Namespace: game.ui.rightHotkey
public class ButtonPkStatus : MonoBehaviour // TypeDefIndex: 2870
{
	// Fields
	[SerializeField]
	private Button button; // 0x20
	[SerializeField]
	private Image iconImage; // 0x28
	[SerializeField]
	private RectTransform selectionRect; // 0x30
	[SerializeField]
	private Button selectionTrainButton; // 0x38
	[SerializeField]
	private Image selectionTrainIcon; // 0x40
	[SerializeField]
	private TextMeshProUGUI selectionTrainText; // 0x48
	[SerializeField]
	private Button selectionFightButton; // 0x50
	[SerializeField]
	private Image selectionFightIcon; // 0x58
	[SerializeField]
	private TextMeshProUGUI selectionFightText; // 0x60
	[SerializeField]
	private Button selectionKillerButton; // 0x68
	[SerializeField]
	private Image selectionKillerIcon; // 0x70
	[SerializeField]
	private TextMeshProUGUI selectionKillerText; // 0x78
	[SerializeField]
	private Button selectionCloseButton; // 0x80
	[SerializeField]
	private TextMeshProUGUI selectionCloseText; // 0x88

	// Methods

	// RVA: 0xEF2794 Offset: 0xEEE794 VA: 0xEF2794
	private void Awake() { }

	// RVA: 0xEF27C0 Offset: 0xEEE7C0 VA: 0xEF27C0
	private void Start() { }

	// RVA: 0xEF2B60 Offset: 0xEEEB60 VA: 0xEF2B60
	public void SetPk(int pk) { }

	// RVA: 0xEF2BCC Offset: 0xEEEBCC VA: 0xEF2BCC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEF2BD4 Offset: 0xEEEBD4 VA: 0xEF2BD4
	private void <Start>b__15_0() { }

	[CompilerGenerated]
	// RVA: 0xEF2C88 Offset: 0xEEEC88 VA: 0xEF2C88
	private void <Start>b__15_1() { }

	[CompilerGenerated]
	// RVA: 0xEF2D78 Offset: 0xEEED78 VA: 0xEF2D78
	private void <Start>b__15_2() { }

	[CompilerGenerated]
	// RVA: 0xEF2E6C Offset: 0xEEEE6C VA: 0xEF2E6C
	private void <Start>b__15_3() { }

	[CompilerGenerated]
	// RVA: 0xEF2F60 Offset: 0xEEEF60 VA: 0xEF2F60
	private void <Start>b__15_4() { }
}

// Namespace: game.ui.rightHotkey
public class ButtonSkill : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler // TypeDefIndex: 2871
{
	// Fields
	[SerializeField]
	private RectTransform dirPositionAreaRect; // 0x20
	[SerializeField]
	private Image compassImage; // 0x28
	[SerializeField]
	private Image iconImage; // 0x30
	[SerializeField]
	private GameObject watermarkBackground; // 0x38
	[SerializeField]
	private TextMeshProUGUI watermarkLabel; // 0x40
	[SerializeField]
	private float dragLinerRadius; // 0x48
	[SerializeField]
	private float dragPositionRadius; // 0x4C
	private bool isPressing; // 0x50
	private int fightstate; // 0x54
	private long countdownMiliseconds; // 0x58
	private Vector2 positionOriginIconImage; // 0x60
	private Vector2 positionPointerDown; // 0x68
	private static Color colorPressed; // 0x0
	private static Color colorNormal; // 0x10
	public RightHotkey.Skill.Direction.Properties directionProperties; // 0x70
	private bool hasFirstFindTargetList; // 0x78
	private float delayTouchAttackDeltaTime; // 0x7C
	private long delayTouchAttackNextFrame; // 0x80

	// Methods

	// RVA: 0xEF2FE8 Offset: 0xEEEFE8 VA: 0xEF2FE8
	private void Start() { }

	// RVA: 0xEF3034 Offset: 0xEEF034 VA: 0xEF3034
	private void Update() { }

	// RVA: 0xEF3418 Offset: 0xEEF418 VA: 0xEF3418
	public void SetCountdown(float seconds) { }

	// RVA: 0xEF34A4 Offset: 0xEEF4A4 VA: 0xEF34A4
	public void SetFightState(int fightstate) { }

	// RVA: 0xEF34F8 Offset: 0xEEF4F8 VA: 0xEF34F8
	private bool CastSkill(Skill _gameskill) { }

	// RVA: 0xEF31D0 Offset: 0xEEF1D0 VA: 0xEF31D0
	private void Attack() { }

	// RVA: 0xEF36CC Offset: 0xEEF6CC VA: 0xEF36CC Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xEF399C Offset: 0xEEF99C VA: 0xEF399C Slot: 5
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xEF4104 Offset: 0xEF0104 VA: 0xEF4104 Slot: 6
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xEF42C4 Offset: 0xEF02C4 VA: 0xEF42C4
	public void .ctor() { }

	// RVA: 0xEF42D8 Offset: 0xEF02D8 VA: 0xEF42D8
	private static void .cctor() { }
}

// Namespace: game.ui.rightHotkey
public class PingFps : MonoBehaviour // TypeDefIndex: 2872
{
	// Fields
	[SerializeField]
	private RectTransform rectTransform; // 0x20
	[SerializeField]
	private TextMeshProUGUI pingTmpro; // 0x28
	[SerializeField]
	private TextMeshProUGUI fpsTmpro; // 0x30
	[SerializeField]
	private Vector2 position0; // 0x38
	[SerializeField]
	private Vector2 position1; // 0x40
	[SerializeField]
	private Vector2 position2; // 0x48
	[SerializeField]
	private Vector2 position3; // 0x50
	private int fpsCurrentCount; // 0x58
	private int fpsPreviousValue; // 0x5C
	private string pingPreviousData; // 0x60

	// Methods

	// RVA: 0xEF4338 Offset: 0xEF0338 VA: 0xEF4338
	private void Awake() { }

	// RVA: 0xEF43A0 Offset: 0xEF03A0 VA: 0xEF43A0
	private void Start() { }

	// RVA: 0xEF44B0 Offset: 0xEF04B0 VA: 0xEF44B0
	private void Update() { }

	// RVA: 0xEF43A8 Offset: 0xEF03A8 VA: 0xEF43A8
	public void SetDisplayPing(long ms) { }

	// RVA: 0xEF4660 Offset: 0xEF0660 VA: 0xEF4660
	public void SetPositionNoFightState() { }

	// RVA: 0xEF4680 Offset: 0xEF0680 VA: 0xEF4680
	public void SetPositionWithPresent() { }

	// RVA: 0xEF46A0 Offset: 0xEF06A0 VA: 0xEF46A0
	public void SetPositionWithAura() { }

	// RVA: 0xEF46C0 Offset: 0xEF06C0 VA: 0xEF46C0
	public void SetPositionWithJum() { }

	// RVA: 0xEF46E0 Offset: 0xEF06E0 VA: 0xEF46E0
	public void .ctor() { }
}
