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

// Namespace: game.ui.autoplay
public class UnityAutoplay : MonoBehaviour // TypeDefIndex: 2879
{
	// Fields
	[SerializeField]
	public GameObject framedGo; // 0x20
	[SerializeField]
	public UnityPositionEditing positionEditing; // 0x28
	[SerializeField]
	public UnityProfileDefaultList profileDefault; // 0x30
	[SerializeField]
	public UnityProfileManualList profileManual; // 0x38
	[SerializeField]
	public UnityConfig config; // 0x40
	[SerializeField]
	public UnityConfigHeader headerAttack; // 0x48
	[SerializeField]
	public UnityConfigHeader headerMoving; // 0x50
	[SerializeField]
	public UnityConfigHeader headerRecover; // 0x58
	[SerializeField]
	public UnityConfigHeader headerSupport; // 0x60
	[SerializeField]
	public UnityConfigHeader headerPickup; // 0x68
	[SerializeField]
	public UnityConfigHeader headerTeam; // 0x70
	[SerializeField]
	public UnityConfigHeader headerEntrusting; // 0x78
	[SerializeField]
	public UnityConfigAttack tabAttack; // 0x80
	[SerializeField]
	public UnityConfigMoving tabMoving; // 0x88
	[SerializeField]
	public UnityConfigRecover tabRecover; // 0x90
	[SerializeField]
	public UnityConfigSupport tabSupport; // 0x98
	[SerializeField]
	public UnityConfigPickup tabPickup; // 0xA0
	[SerializeField]
	public UnityConfigTeam tabTeam; // 0xA8
	[SerializeField]
	public Button funcButtonClose; // 0xB0
	[SerializeField]
	public Button funcButtonStart; // 0xB8
	[SerializeField]
	public Button funcButtonStop; // 0xC0
	private Queue<Action> onStartActions; // 0xC8
	private bool isStarted; // 0xD0
	private ProfileData selectedProfile; // 0xD8
	private bool needOnOpenRerenderProfiles; // 0xE0
	private bool needOnOpenReloadProfiles; // 0xE1
	private bool needOnOpenReloadCreateProfileWhenEmpty; // 0xE2

	// Methods

	// RVA: 0xEF4DBC Offset: 0xEF0DBC VA: 0xEF4DBC
	private void Start() { }

	// RVA: 0xEF5FE4 Offset: 0xEF1FE4 VA: 0xEF5FE4
	private void OnDestroy() { }

	// RVA: 0xEF6028 Offset: 0xEF2028 VA: 0xEF6028
	private void Perform(Action action) { }

	// RVA: 0xEF2160 Offset: 0xEEE160 VA: 0xEF2160
	public void Open() { }

	// RVA: 0xEE7D5C Offset: 0xEE3D5C VA: 0xEE7D5C
	public bool Showoff() { }

	// RVA: 0xEF60F8 Offset: 0xEF20F8 VA: 0xEF60F8
	public void SetOnOpenRerenderProfiles(bool enabled) { }

	// RVA: 0xEF6174 Offset: 0xEF2174 VA: 0xEF6174
	public void SetOnOpenReloadProfiles(bool enabled, bool createProfileWhenEmpty) { }

	// RVA: 0xEF59A0 Offset: 0xEF19A0 VA: 0xEF59A0
	private void RerenderProfile() { }

	// RVA: 0xEF62D4 Offset: 0xEF22D4 VA: 0xEF62D4
	public static void ApplyTmpro(TextMeshProUGUI tmpro, string text) { }

	// RVA: 0xEF57D0 Offset: 0xEF17D0 VA: 0xEF57D0
	private void ApplyChildrenPCInput(Transform transform) { }

	// RVA: 0xEF5400 Offset: 0xEF1400 VA: 0xEF5400
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xEF5FE8 Offset: 0xEF1FE8 VA: 0xEF5FE8
	public void ClearProfileList() { }

	// RVA: 0xEF5B8C Offset: 0xEF1B8C VA: 0xEF5B8C
	public void ChooseTab(UnityConfigHeader tabHeader) { }

	// RVA: 0xEF6410 Offset: 0xEF2410 VA: 0xEF6410
	public void SetDefaultProfile(ProfileIdentify identify) { }

	// RVA: 0xEF6568 Offset: 0xEF2568 VA: 0xEF6568
	public void CreateProfile(string name) { }

	// RVA: 0xEF6664 Offset: 0xEF2664 VA: 0xEF6664
	public void DeleteProfile(ProfileIdentify identify) { }

	// RVA: 0xEF6200 Offset: 0xEF2200 VA: 0xEF6200
	public void ApplyProfile(ProfileData profile) { }

	// RVA: 0xEF7584 Offset: 0xEF3584 VA: 0xEF7584
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEF758C Offset: 0xEF358C VA: 0xEF758C
	private void <Open>b__30_0() { }

	[CompilerGenerated]
	// RVA: 0xEF7604 Offset: 0xEF3604 VA: 0xEF7604
	private void <ChooseTab>b__39_0(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEF7644 Offset: 0xEF3644 VA: 0xEF7644
	private void <ChooseTab>b__39_1(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEF7684 Offset: 0xEF3684 VA: 0xEF7684
	private void <ChooseTab>b__39_2(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEF76A0 Offset: 0xEF36A0 VA: 0xEF76A0
	private void <ChooseTab>b__39_3(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEF76BC Offset: 0xEF36BC VA: 0xEF76BC
	private void <ChooseTab>b__39_4(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEF76D8 Offset: 0xEF36D8 VA: 0xEF76D8
	private void <ChooseTab>b__39_5(bool enable) { }
}

// Namespace: game.ui.autoplay
public class UnityConfig : MonoBehaviour // TypeDefIndex: 2880
{
	// Fields
	[SerializeField]
	public GameObject underground; // 0x20
	private string guidCurrently; // 0x28

	// Methods

	// RVA: 0xEF655C Offset: 0xEF255C VA: 0xEF655C
	public bool IsCurrently(string guid) { }

	// RVA: 0xEF6364 Offset: 0xEF2364 VA: 0xEF6364
	public void SetActive(bool active) { }

	// RVA: 0xEF6750 Offset: 0xEF2750 VA: 0xEF6750
	public void ApplyProfile(ProfileData profile) { }

	// RVA: 0xEF7D6C Offset: 0xEF3D6C VA: 0xEF7D6C
	public void .ctor() { }
}

// Namespace: game.ui.autoplay
public class UnityConfigAttack : MonoBehaviour // TypeDefIndex: 2881
{
	// Fields
	[SerializeField]
	public Toggle tuDanhB; // 0x20
	[SerializeField]
	public Toggle tiepCanB; // 0x28
	[SerializeField]
	public TMP_InputField tiepCanV; // 0x30
	[SerializeField]
	public Toggle mucTieuGanNhatB; // 0x38
	[SerializeField]
	public Toggle mucTieuTypeB; // 0x40
	[SerializeField]
	public TMP_Dropdown mucTieuTypeV; // 0x48
	[SerializeField]
	public Toggle lenNguaKhiDiChuyenB; // 0x50
	[SerializeField]
	public Toggle tranhBossVang; // 0x58
	[SerializeField]
	public Toggle kyNangChinhB; // 0x60
	[SerializeField]
	public TMP_InputField kyNangChinhV; // 0x68
	[SerializeField]
	public UnityConfigAttackSkill kyNangChinhSkill; // 0x70
	[SerializeField]
	public Toggle kyNangPhuB; // 0x78
	[SerializeField]
	public TMP_InputField kyNangPhuV; // 0x80
	[SerializeField]
	public UnityConfigAttackSkill kyNangPhuSkill; // 0x88
	[SerializeField]
	public Toggle kyNangHoTro1B; // 0x90
	[SerializeField]
	public UnityConfigAttackSkill kyNangHoTro1Skill; // 0x98
	[SerializeField]
	public Toggle kyNangHoTro2B; // 0xA0
	[SerializeField]
	public UnityConfigAttackSkill kyNangHoTro2Skill; // 0xA8
	[SerializeField]
	public Toggle kyNangHoTro3B; // 0xB0
	[SerializeField]
	public UnityConfigAttackSkill kyNangHoTro3Skill; // 0xB8
	[SerializeField]
	public Toggle vongSangLuanChuyen1B; // 0xC0
	[SerializeField]
	public UnityConfigAttackSkill vongSangLuanChuyen1SkillId; // 0xC8
	[SerializeField]
	public TMP_InputField vongSangLuanChuyen1DelayTime; // 0xD0
	[SerializeField]
	public Toggle vongSangLuanChuyen2B; // 0xD8
	[SerializeField]
	public UnityConfigAttackSkill vongSangLuanChuyen2SkillId; // 0xE0
	[SerializeField]
	public TMP_InputField vongSangLuanChuyen2DelayTime; // 0xE8
	[SerializeField]
	public UnityConfigAttackSkillList skillList; // 0xF0
	private ProfileData profile; // 0xF8

	// Methods

	// RVA: 0xEF7DA0 Offset: 0xEF3DA0 VA: 0xEF7DA0
	private void Start() { }

	// RVA: 0xEF8670 Offset: 0xEF4670 VA: 0xEF8670
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xEF761C Offset: 0xEF361C VA: 0xEF761C
	public void SetActive(bool active) { }

	// RVA: 0xEF8840 Offset: 0xEF4840 VA: 0xEF8840
	private void SaveProfile(object _) { }

	// RVA: 0xEF88B8 Offset: 0xEF48B8 VA: 0xEF88B8
	public void RefreshSkillAttackList() { }

	// RVA: 0xEF8EF4 Offset: 0xEF4EF4 VA: 0xEF8EF4
	public void RefreshSkillSupportList() { }

	// RVA: 0xEF903C Offset: 0xEF503C VA: 0xEF903C
	public void RefreshSkillAuraList() { }

	// RVA: 0xEF67A8 Offset: 0xEF27A8 VA: 0xEF67A8
	public void ApplyProfile(ProfileData profile) { }

	// RVA: 0xEF9300 Offset: 0xEF5300 VA: 0xEF9300
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEF9308 Offset: 0xEF5308 VA: 0xEF9308
	private void <Start>b__28_0(bool ticked) { }

	[CompilerGenerated]
	// RVA: 0xEF935C Offset: 0xEF535C VA: 0xEF935C
	private void <Start>b__28_1(bool ticked) { }

	[CompilerGenerated]
	// RVA: 0xEF93B0 Offset: 0xEF53B0 VA: 0xEF93B0
	private void <Start>b__28_2(string value) { }

	[CompilerGenerated]
	// RVA: 0xEF9414 Offset: 0xEF5414 VA: 0xEF9414
	private void <Start>b__28_3(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEF9468 Offset: 0xEF5468 VA: 0xEF9468
	private void <Start>b__28_4(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEF94BC Offset: 0xEF54BC VA: 0xEF94BC
	private void <Start>b__28_5(int value) { }

	[CompilerGenerated]
	// RVA: 0xEF950C Offset: 0xEF550C VA: 0xEF950C
	private void <Start>b__28_6(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEF9560 Offset: 0xEF5560 VA: 0xEF9560
	private void <Start>b__28_7(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEF95B4 Offset: 0xEF55B4 VA: 0xEF95B4
	private void <Start>b__28_8(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEF96B0 Offset: 0xEF56B0 VA: 0xEF96B0
	private void <Start>b__28_9(string value) { }

	[CompilerGenerated]
	// RVA: 0xEF97BC Offset: 0xEF57BC VA: 0xEF97BC
	private void <Start>b__28_10() { }

	[CompilerGenerated]
	// RVA: 0xEF988C Offset: 0xEF588C VA: 0xEF988C
	private void <Start>b__28_26(Skill skill) { }

	[CompilerGenerated]
	// RVA: 0xEF999C Offset: 0xEF599C VA: 0xEF999C
	private void <Start>b__28_11(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEF9A98 Offset: 0xEF5A98 VA: 0xEF9A98
	private void <Start>b__28_12(string value) { }

	[CompilerGenerated]
	// RVA: 0xEF9BA4 Offset: 0xEF5BA4 VA: 0xEF9BA4
	private void <Start>b__28_13() { }

	[CompilerGenerated]
	// RVA: 0xEF9C4C Offset: 0xEF5C4C VA: 0xEF9C4C
	private void <Start>b__28_27(Skill skill) { }

	[CompilerGenerated]
	// RVA: 0xEF9D5C Offset: 0xEF5D5C VA: 0xEF9D5C
	private void <Start>b__28_14(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEF9E58 Offset: 0xEF5E58 VA: 0xEF9E58
	private void <Start>b__28_15() { }

	[CompilerGenerated]
	// RVA: 0xEF9F00 Offset: 0xEF5F00 VA: 0xEF9F00
	private void <Start>b__28_28(Skill skill) { }

	[CompilerGenerated]
	// RVA: 0xEFA010 Offset: 0xEF6010 VA: 0xEFA010
	private void <Start>b__28_16(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEFA10C Offset: 0xEF610C VA: 0xEFA10C
	private void <Start>b__28_17() { }

	[CompilerGenerated]
	// RVA: 0xEFA1B4 Offset: 0xEF61B4 VA: 0xEFA1B4
	private void <Start>b__28_29(Skill skill) { }

	[CompilerGenerated]
	// RVA: 0xEFA2C4 Offset: 0xEF62C4 VA: 0xEFA2C4
	private void <Start>b__28_18(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEFA3C0 Offset: 0xEF63C0 VA: 0xEFA3C0
	private void <Start>b__28_19() { }

	[CompilerGenerated]
	// RVA: 0xEFA468 Offset: 0xEF6468 VA: 0xEFA468
	private void <Start>b__28_30(Skill skill) { }

	[CompilerGenerated]
	// RVA: 0xEFA578 Offset: 0xEF6578 VA: 0xEFA578
	private void <Start>b__28_20(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEFA5CC Offset: 0xEF65CC VA: 0xEFA5CC
	private void <Start>b__28_21(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFA630 Offset: 0xEF6630 VA: 0xEFA630
	private void <Start>b__28_22() { }

	[CompilerGenerated]
	// RVA: 0xEFA6D8 Offset: 0xEF66D8 VA: 0xEFA6D8
	private void <Start>b__28_31(Skill skill) { }

	[CompilerGenerated]
	// RVA: 0xEFA740 Offset: 0xEF6740 VA: 0xEFA740
	private void <Start>b__28_23(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEFA794 Offset: 0xEF6794 VA: 0xEFA794
	private void <Start>b__28_24(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFA7F8 Offset: 0xEF67F8 VA: 0xEFA7F8
	private void <Start>b__28_25() { }

	[CompilerGenerated]
	// RVA: 0xEFA8A0 Offset: 0xEF68A0 VA: 0xEFA8A0
	private void <Start>b__28_32(Skill skill) { }
}

// Namespace: game.ui.autoplay
public class UnityConfigAttackSkill : MonoBehaviour // TypeDefIndex: 2882
{
	// Fields
	[SerializeField]
	public GameObject frameSkill; // 0x20
	[SerializeField]
	public GameObject frameSelect; // 0x28
	[SerializeField]
	public Image skillIcon; // 0x30
	[SerializeField]
	public TextMeshProUGUI skillName; // 0x38
	[SerializeField]
	public TextMeshProUGUI skillLevel; // 0x40
	[SerializeField]
	public Button selectButton; // 0x48
	private int skillId; // 0x50
	private Action onClick; // 0x58

	// Methods

	// RVA: 0xEFA908 Offset: 0xEF6908 VA: 0xEFA908
	private void Start() { }

	// RVA: 0xEFA998 Offset: 0xEF6998 VA: 0xEFA998
	public void SetCallback(Action onClick) { }

	// RVA: 0xEFA9A0 Offset: 0xEF69A0 VA: 0xEFA9A0
	public int GetSkillId() { }

	// RVA: 0xEF9184 Offset: 0xEF5184 VA: 0xEF9184
	public void SetSkill(Skill skill) { }

	// RVA: 0xEFA9A8 Offset: 0xEF69A8 VA: 0xEFA9A8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEFA9B0 Offset: 0xEF69B0 VA: 0xEFA9B0
	private void <Start>b__8_0() { }
}

// Namespace: 
public class UnityConfigAttackSkillList.Template // TypeDefIndex: 2883
{
	// Fields
	public readonly GameObject goCurrent; // 0x10
	public readonly Button button; // 0x18
	public readonly Image icon; // 0x20
	public readonly TextMeshProUGUI skillName; // 0x28
	public readonly TextMeshProUGUI skillLevel; // 0x30
	public Skill skill; // 0x38

	// Methods

	// RVA: 0xEFAAD8 Offset: 0xEF6AD8 VA: 0xEFAAD8
	public void .ctor(GameObject go) { }

	// RVA: 0xEFAD3C Offset: 0xEF6D3C VA: 0xEFAD3C
	public UnityConfigAttackSkillList.Template Clone() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityConfigAttackSkillList.<>c__DisplayClass11_0 // TypeDefIndex: 2884
{
	// Fields
	public UnityConfigAttackSkillList <>4__this; // 0x10
	public UnityConfigAttackSkillList.Template template; // 0x18

	// Methods

	// RVA: 0xEFAD34 Offset: 0xEF6D34 VA: 0xEFAD34
	public void .ctor() { }

	// RVA: 0xEFAE90 Offset: 0xEF6E90 VA: 0xEFAE90
	internal void <AddSkill>b__0() { }
}

// Namespace: game.ui.autoplay
public class UnityConfigAttackSkillList : MonoBehaviour // TypeDefIndex: 2885
{
	// Fields
	[SerializeField]
	public Button compButton; // 0x20
	[SerializeField]
	public GameObject goList; // 0x28
	[SerializeField]
	public GameObject goTemplate; // 0x30
	private UnityConfigAttackSkillList.Template fieldTemplate; // 0x38
	private Dictionary<int, UnityConfigAttackSkillList.Template> fieldList; // 0x40
	private Action<Skill> callbackOnSelect; // 0x48

	// Methods

	// RVA: 0xEFA9CC Offset: 0xEF69CC VA: 0xEFA9CC
	private void Start() { }

	// RVA: 0xEF9864 Offset: 0xEF5864 VA: 0xEF9864
	public void SetActive(bool active) { }

	// RVA: 0xEFACCC Offset: 0xEF6CCC VA: 0xEFACCC
	private void OnSelect(UnityConfigAttackSkillList.Template template) { }

	// RVA: 0xEFAD2C Offset: 0xEF6D2C VA: 0xEFAD2C
	public void SetCallback(Action<Skill> action) { }

	// RVA: 0xEF8BA0 Offset: 0xEF4BA0 VA: 0xEF8BA0
	public void AddSkill(Skill skill) { }

	// RVA: 0xEF8A00 Offset: 0xEF4A00 VA: 0xEF8A00
	public void RemoveAllSkill() { }

	// RVA: 0xEFADE4 Offset: 0xEF6DE4 VA: 0xEFADE4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEFAE6C Offset: 0xEF6E6C VA: 0xEFAE6C
	private void <Start>b__7_0() { }
}

// Namespace: game.ui.autoplay
public class UnityConfigHeader : MonoBehaviour // TypeDefIndex: 2886
{
	// Fields
	[SerializeField]
	private Button compButton; // 0x20
	[SerializeField]
	private GameObject goActive; // 0x28
	[SerializeField]
	private GameObject goNormal; // 0x30
	private Action<bool> onClick; // 0x38
	private bool isActivated; // 0x40

	// Methods

	// RVA: 0xEFAEAC Offset: 0xEF6EAC VA: 0xEFAEAC
	private void Start() { }

	// RVA: 0xEFAF3C Offset: 0xEF6F3C VA: 0xEFAF3C
	public void SetCallback(Action<bool> action) { }

	// RVA: 0xEF63B0 Offset: 0xEF23B0 VA: 0xEF63B0
	public void SetActivate(bool activate) { }

	// RVA: 0xEFAF44 Offset: 0xEF6F44 VA: 0xEFAF44
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEFAF4C Offset: 0xEF6F4C VA: 0xEFAF4C
	private void <Start>b__5_0() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UnityConfigMoving.<>c // TypeDefIndex: 2887
{
	// Fields
	public static readonly UnityConfigMoving.<>c <>9; // 0x0
	public static Comparison<KeyValuePair<double, NpcRes.Special>> <>9__59_0; // 0x8

	// Methods

	// RVA: 0xEFDE74 Offset: 0xEF9E74 VA: 0xEFDE74
	private static void .cctor() { }

	// RVA: 0xEFDEDC Offset: 0xEF9EDC VA: 0xEFDEDC
	public void .ctor() { }

	// RVA: 0xEFDEE4 Offset: 0xEF9EE4 VA: 0xEFDEE4
	internal int <ShowPlayerList>b__59_0(KeyValuePair<double, NpcRes.Special> a, KeyValuePair<double, NpcRes.Special> b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityConfigMoving.<>c__DisplayClass61_0 // TypeDefIndex: 2888
{
	// Fields
	public KeyValuePair<int, Toggle> entry; // 0x10
	public UnityConfigMoving <>4__this; // 0x20

	// Methods

	// RVA: 0xEFDF3C Offset: 0xEF9F3C VA: 0xEFDF3C
	public void .ctor() { }

	// RVA: 0xEFDF44 Offset: 0xEF9F44 VA: 0xEFDF44
	internal void <SetRoundedType>b__0(bool _) { }
}

// Namespace: game.ui.autoplay
public class UnityConfigMoving : MonoBehaviour // TypeDefIndex: 2889
{
	// Fields
	[SerializeField]
	private UnityAutoplay unityAutoplay; // 0x20
	[SerializeField]
	private Toggle roundedFree; // 0x28
	[SerializeField]
	private Toggle roundedFollow; // 0x30
	[SerializeField]
	private Button followPlayerButton; // 0x38
	[SerializeField]
	private TextMeshProUGUI followPlayerName; // 0x40
	[SerializeField]
	private Image followPlayerIcon; // 0x48
	[SerializeField]
	private TMP_InputField followDistance; // 0x50
	[SerializeField]
	private UnityConfigMovingPlayerList followPlayerList; // 0x58
	[SerializeField]
	private Toggle roundedPoint; // 0x60
	[SerializeField]
	private TMP_InputField pointDistance; // 0x68
	[SerializeField]
	private Toggle roundedRandomPosition; // 0x70
	[SerializeField]
	private Toggle roundedListingPosition; // 0x78
	[SerializeField]
	private Button listingPositionEditButton; // 0x80
	[SerializeField]
	private Toggle roundedMixFollowAndPositionList; // 0x88
	[SerializeField]
	private Toggle thodiaphu_sinhLucThapB; // 0x90
	[SerializeField]
	private TMP_InputField thodiaphu_sinhLucThapV; // 0x98
	[SerializeField]
	private Toggle thodiaphu_noiLucThapB; // 0xA0
	[SerializeField]
	private TMP_InputField thodiaphu_noiLucThapV; // 0xA8
	[SerializeField]
	private Toggle thodiaphu_hetBinhSinhLucB; // 0xB0
	[SerializeField]
	private Toggle thodiaphu_hetBinhNoiLucB; // 0xB8
	[SerializeField]
	private Toggle thodiaphu_tienLonB; // 0xC0
	[SerializeField]
	private TMP_InputField thodiaphu_tienLonV; // 0xC8
	[SerializeField]
	private Toggle thodiaphu_hanhTrangHetB; // 0xD0
	[SerializeField]
	private TMP_InputField thodiaphu_hanhTrangHetV; // 0xD8
	[SerializeField]
	private Toggle thodiaphu_doBenTrangBiThapB; // 0xE0
	[SerializeField]
	private TMP_InputField thodiaphu_doBenTrangBiThapV; // 0xE8
	[SerializeField]
	private Toggle thodiaphu_biCuuSatDoSatB; // 0xF0
	[SerializeField]
	private Toggle bandoluuruong_rutTienB; // 0xF8
	[SerializeField]
	private TMP_InputField bandoluuruong_rutTienV; // 0x100
	[SerializeField]
	private Toggle bandoluuruong_muaThuoc1B; // 0x108
	[SerializeField]
	private TMP_Dropdown bandoluuruong_muaThuoc1Select; // 0x110
	[SerializeField]
	private TMP_InputField bandoluuruong_muaThuoc1Total; // 0x118
	[SerializeField]
	private Toggle bandoluuruong_muaThuoc2B; // 0x120
	[SerializeField]
	private TMP_Dropdown bandoluuruong_muaThuoc2Select; // 0x128
	[SerializeField]
	private TMP_InputField bandoluuruong_muaThuoc2Total; // 0x130
	[SerializeField]
	private Toggle bandoluuruong_muaThuoc3B; // 0x138
	[SerializeField]
	private TMP_Dropdown bandoluuruong_muaThuoc3Select; // 0x140
	[SerializeField]
	private TMP_InputField bandoluuruong_muaThuoc3Total; // 0x148
	[SerializeField]
	private Toggle bandoluuruong_muaThoDiaPhuB; // 0x150
	[SerializeField]
	private TMP_InputField bandoluuruong_muaThuoDiaPhuTotal; // 0x158
	[SerializeField]
	private Toggle bandoluuruong_suaDoTrangBiDangMacB; // 0x160
	[SerializeField]
	private Toggle bandoluuruong_chuyenTienVaoRuongB; // 0x168
	[SerializeField]
	private TMP_InputField bandoluuruong_chuyenTienVaoRuongKeep; // 0x170
	[SerializeField]
	private Toggle trolaidiemcu_thanhthiTroLaiDiemCuBool; // 0x178
	[SerializeField]
	private TMP_InputField trolaidiemcu_thanhthiTroLaiDiemCuNpc; // 0x180
	[SerializeField]
	private TMP_InputField trolaidiemcu_thanhthiTroLaiDiemCuSel; // 0x188
	[SerializeField]
	private Toggle trolaidiemcu_thanhthiMacCaoQuatBool; // 0x190
	[SerializeField]
	private TMP_InputField trolaidiemcu_thanhthiMacCaoQuatNpc; // 0x198
	[SerializeField]
	private TMP_InputField trolaidiemcu_thanhthiMacCaoQuatSel; // 0x1A0
	[SerializeField]
	private Toggle trolaidiemcu_tuychinhNpcBool; // 0x1A8
	[SerializeField]
	private TMP_InputField trolaidiemcu_tuychinhNpcNpc; // 0x1B0
	[SerializeField]
	private TMP_InputField trolaidiemcu_tuychinhNpcSel; // 0x1B8
	[SerializeField]
	private Toggle trolaidiemcu_tuychinhThanHanhPhuBool; // 0x1C0
	[SerializeField]
	private TMP_InputField trolaidiemcu_tuychinhThanHanhPhuSel; // 0x1C8
	private ProfileData profile; // 0x1D0

	// Methods

	// RVA: 0xEFAF8C Offset: 0xEF6F8C VA: 0xEFAF8C
	private void Start() { }

	// RVA: 0xEFC088 Offset: 0xEF8088 VA: 0xEFC088
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xEFC258 Offset: 0xEF8258 VA: 0xEFC258
	private void SelectFollowPlayer(string cid, string name, int faction) { }

	// RVA: 0xEFC3C0 Offset: 0xEF83C0 VA: 0xEFC3C0
	private void ShowPositionEditing() { }

	// RVA: 0xEFC4D0 Offset: 0xEF84D0 VA: 0xEFC4D0
	private void ShowPlayerList() { }

	// RVA: 0xEFC348 Offset: 0xEF8348 VA: 0xEFC348
	private void SaveProfile(object _) { }

	// RVA: 0xEFCAC0 Offset: 0xEF8AC0 VA: 0xEFCAC0
	public void SetRoundedType(int type, bool saveProfile = True) { }

	// RVA: 0xEF6EEC Offset: 0xEF2EEC VA: 0xEF6EEC
	public void ApplyProfile(ProfileData profile) { }

	// RVA: 0xEF765C Offset: 0xEF365C VA: 0xEF765C
	public void SetActive(bool enable) { }

	// RVA: 0xEFD044 Offset: 0xEF9044 VA: 0xEFD044
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEFD04C Offset: 0xEF904C VA: 0xEFD04C
	private void <Start>b__55_0(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD058 Offset: 0xEF9058 VA: 0xEFD058
	private void <Start>b__55_1(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD064 Offset: 0xEF9064 VA: 0xEFD064
	private void <Start>b__55_2(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD070 Offset: 0xEF9070 VA: 0xEFD070
	private void <Start>b__55_3(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD07C Offset: 0xEF907C VA: 0xEFD07C
	private void <Start>b__55_4(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD088 Offset: 0xEF9088 VA: 0xEFD088
	private void <Start>b__55_5(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD094 Offset: 0xEF9094 VA: 0xEFD094
	private void <Start>b__55_6(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFD0F8 Offset: 0xEF90F8 VA: 0xEFD0F8
	private void <Start>b__55_7(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFD15C Offset: 0xEF915C VA: 0xEFD15C
	private void <Start>b__55_8(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD1B0 Offset: 0xEF91B0 VA: 0xEFD1B0
	private void <Start>b__55_9(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFD214 Offset: 0xEF9214 VA: 0xEFD214
	private void <Start>b__55_10(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD268 Offset: 0xEF9268 VA: 0xEFD268
	private void <Start>b__55_11(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFD2CC Offset: 0xEF92CC VA: 0xEFD2CC
	private void <Start>b__55_12(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD320 Offset: 0xEF9320 VA: 0xEFD320
	private void <Start>b__55_13(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD374 Offset: 0xEF9374 VA: 0xEFD374
	private void <Start>b__55_14(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD3C8 Offset: 0xEF93C8 VA: 0xEFD3C8
	private void <Start>b__55_15(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFD42C Offset: 0xEF942C VA: 0xEFD42C
	private void <Start>b__55_16(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD480 Offset: 0xEF9480 VA: 0xEFD480
	private void <Start>b__55_17(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFD4E4 Offset: 0xEF94E4 VA: 0xEFD4E4
	private void <Start>b__55_18(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEFD538 Offset: 0xEF9538 VA: 0xEFD538
	private void <Start>b__55_19(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFD59C Offset: 0xEF959C VA: 0xEFD59C
	private void <Start>b__55_20(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD5F0 Offset: 0xEF95F0 VA: 0xEFD5F0
	private void <Start>b__55_21(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD644 Offset: 0xEF9644 VA: 0xEFD644
	private void <Start>b__55_22(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFD6A8 Offset: 0xEF96A8 VA: 0xEFD6A8
	private void <Start>b__55_23(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD6FC Offset: 0xEF96FC VA: 0xEFD6FC
	private void <Start>b__55_24(int value) { }

	[CompilerGenerated]
	// RVA: 0xEFD74C Offset: 0xEF974C VA: 0xEFD74C
	private void <Start>b__55_25(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFD7B0 Offset: 0xEF97B0 VA: 0xEFD7B0
	private void <Start>b__55_26(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD804 Offset: 0xEF9804 VA: 0xEFD804
	private void <Start>b__55_27(int value) { }

	[CompilerGenerated]
	// RVA: 0xEFD854 Offset: 0xEF9854 VA: 0xEFD854
	private void <Start>b__55_28(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFD8B8 Offset: 0xEF98B8 VA: 0xEFD8B8
	private void <Start>b__55_29(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFD90C Offset: 0xEF990C VA: 0xEFD90C
	private void <Start>b__55_30(int value) { }

	[CompilerGenerated]
	// RVA: 0xEFD95C Offset: 0xEF995C VA: 0xEFD95C
	private void <Start>b__55_31(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFD9C0 Offset: 0xEF99C0 VA: 0xEFD9C0
	private void <Start>b__55_32(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFDA14 Offset: 0xEF9A14 VA: 0xEFDA14
	private void <Start>b__55_33(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFDA78 Offset: 0xEF9A78 VA: 0xEFDA78
	private void <Start>b__55_34(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEFDACC Offset: 0xEF9ACC VA: 0xEFDACC
	private void <Start>b__55_35(bool enable) { }

	[CompilerGenerated]
	// RVA: 0xEFDB20 Offset: 0xEF9B20 VA: 0xEFDB20
	private void <Start>b__55_36(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFDB84 Offset: 0xEF9B84 VA: 0xEFDB84
	private void <Start>b__55_37(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEFDBD8 Offset: 0xEF9BD8 VA: 0xEFDBD8
	private void <Start>b__55_38(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFDC08 Offset: 0xEF9C08 VA: 0xEFDC08
	private void <Start>b__55_39(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFDC38 Offset: 0xEF9C38 VA: 0xEFDC38
	private void <Start>b__55_40(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEFDC8C Offset: 0xEF9C8C VA: 0xEFDC8C
	private void <Start>b__55_41(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFDCBC Offset: 0xEF9CBC VA: 0xEFDCBC
	private void <Start>b__55_42(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFDCEC Offset: 0xEF9CEC VA: 0xEFDCEC
	private void <Start>b__55_43(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEFDD40 Offset: 0xEF9D40 VA: 0xEFDD40
	private void <Start>b__55_44(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFDD70 Offset: 0xEF9D70 VA: 0xEFDD70
	private void <Start>b__55_45(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFDDA0 Offset: 0xEF9DA0 VA: 0xEFDDA0
	private void <Start>b__55_46(bool value) { }

	[CompilerGenerated]
	// RVA: 0xEFDDF4 Offset: 0xEF9DF4 VA: 0xEFDDF4
	private void <Start>b__55_47(string value) { }

	[CompilerGenerated]
	// RVA: 0xEFDE24 Offset: 0xEF9E24 VA: 0xEFDE24
	private void <ShowPositionEditing>b__58_0(List<Position> _newListing, int _newPointRadius) { }
}

// Namespace: 
public class UnityConfigMovingPlayerList.Template // TypeDefIndex: 2890
{
	// Fields
	public GameObject goCurrent; // 0x10
	public Button compButton; // 0x18
	public Image compIcon; // 0x20
	public TextMeshProUGUI compName; // 0x28
	public TextMeshProUGUI compLevel; // 0x30
	public string cid; // 0x38
	public string name; // 0x40
	public int faction; // 0x48

	// Methods

	// RVA: 0xEFE090 Offset: 0xEFA090 VA: 0xEFE090
	public void .ctor(GameObject go) { }

	// RVA: 0xEFE7F4 Offset: 0xEFA7F4 VA: 0xEFE7F4
	public UnityConfigMovingPlayerList.Template Clone() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityConfigMovingPlayerList.<>c__DisplayClass10_0 // TypeDefIndex: 2891
{
	// Fields
	public UnityConfigMovingPlayerList <>4__this; // 0x10
	public UnityConfigMovingPlayerList.Template field; // 0x18

	// Methods

	// RVA: 0xEFE7EC Offset: 0xEFA7EC VA: 0xEFE7EC
	public void .ctor() { }

	// RVA: 0xEFE954 Offset: 0xEFA954 VA: 0xEFE954
	internal void <AddPlayer>b__0() { }
}

// Namespace: game.ui.autoplay
public class UnityConfigMovingPlayerList : MonoBehaviour // TypeDefIndex: 2892
{
	// Fields
	[SerializeField]
	private GameObject goTemplate; // 0x20
	[SerializeField]
	private GameObject goContent; // 0x28
	[SerializeField]
	private Button compButton; // 0x30
	private UnityConfigMovingPlayerList.Template template; // 0x38
	private readonly List<UnityConfigMovingPlayerList.Template> fieldList; // 0x40
	private Action<string, string, int> onFieldSelect; // 0x48

	// Methods

	// RVA: 0xEFDF94 Offset: 0xEF9F94 VA: 0xEFDF94
	public void Start() { }

	// RVA: 0xEFE2BC Offset: 0xEFA2BC VA: 0xEFE2BC
	public void SetCallback(Action<string, string, int> onFieldSelect) { }

	// RVA: 0xEFE2C4 Offset: 0xEFA2C4 VA: 0xEFE2C4
	public void RemoveAllPlayer() { }

	// RVA: 0xEFE460 Offset: 0xEFA460 VA: 0xEFE460
	public void AddPlayer(Controller controller) { }

	// RVA: 0xEFE89C Offset: 0xEFA89C VA: 0xEFE89C
	public void SetActive(bool enable) { }

	// RVA: 0xEFE8C4 Offset: 0xEFA8C4 VA: 0xEFE8C4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEFE94C Offset: 0xEFA94C VA: 0xEFE94C
	private void <Start>b__7_0() { }
}

// Namespace: 
private class UnityConfigPickup.MagicRequiredTemplate // TypeDefIndex: 2893
{
	// Fields
	public GameObject go; // 0x10
	public Image background; // 0x18
	public TextMeshProUGUI name; // 0x20
	public TMP_InputField input; // 0x28
	public TextMeshProUGUI unit; // 0x30

	// Methods

	// RVA: 0xEFF2BC Offset: 0xEFB2BC VA: 0xEFF2BC
	public void .ctor(GameObject go) { }

	// RVA: 0xEFFBF4 Offset: 0xEFBBF4 VA: 0xEFFBF4
	public UnityConfigPickup.MagicRequiredTemplate Clone(Transform parent) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UnityConfigPickup.<>c // TypeDefIndex: 2894
{
	// Fields
	public static readonly UnityConfigPickup.<>c <>9; // 0x0
	public static Comparison<KeyValuePair<string, int>> <>9__30_0; // 0x8

	// Methods

	// RVA: 0xF00B34 Offset: 0xEFCB34 VA: 0xF00B34
	private static void .cctor() { }

	// RVA: 0xF00B9C Offset: 0xEFCB9C VA: 0xF00B9C
	public void .ctor() { }

	// RVA: 0xF00BA4 Offset: 0xEFCBA4 VA: 0xF00BA4
	internal int <CreateAllMagicRequiredField>b__30_0(KeyValuePair<string, int> a, KeyValuePair<string, int> b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityConfigPickup.<>c__DisplayClass32_0 // TypeDefIndex: 2895
{
	// Fields
	public KeyValuePair<string, UnityConfigPickup.MagicRequiredTemplate> fieldEntry; // 0x10
	public UnityConfigPickup <>4__this; // 0x20

	// Methods

	// RVA: 0xF002B4 Offset: 0xEFC2B4 VA: 0xF002B4
	public void .ctor() { }

	// RVA: 0xF00BFC Offset: 0xEFCBFC VA: 0xF00BFC
	internal void <ApplyProfile>b__0(string value) { }
}

// Namespace: game.ui.autoplay
public class UnityConfigPickup : MonoBehaviour // TypeDefIndex: 2896
{
	// Fields
	[SerializeField]
	private Toggle pickupControlPick; // 0x20
	[SerializeField]
	private Toggle pickupControlFilter; // 0x28
	[SerializeField]
	private Toggle pickupControlPriority; // 0x30
	[SerializeField]
	private Toggle pickupControlNewItemToStorage; // 0x38
	[SerializeField]
	private Toggle pickupPickMoney; // 0x40
	[SerializeField]
	private Toggle pickupPickMagicscript; // 0x48
	[SerializeField]
	private Toggle pickupPickPotion; // 0x50
	[SerializeField]
	private Toggle pickupPickRangeweapon; // 0x58
	[SerializeField]
	private Toggle pickupPickMeleweapon; // 0x60
	[SerializeField]
	private Toggle pickupPickArmor; // 0x68
	[SerializeField]
	private Toggle pickupPickRing; // 0x70
	[SerializeField]
	private Toggle pickupPickAmulet; // 0x78
	[SerializeField]
	private Toggle pickupPickBoots; // 0x80
	[SerializeField]
	private Toggle pickupPickBelt; // 0x88
	[SerializeField]
	private Toggle pickupPickHelm; // 0x90
	[SerializeField]
	private Toggle pickupPickCuff; // 0x98
	[SerializeField]
	private Toggle pickupPickPendant; // 0xA0
	[SerializeField]
	private Toggle pickupFilterThrow; // 0xA8
	[SerializeField]
	private Toggle pickupFilterSell; // 0xB0
	[SerializeField]
	private Toggle pickupKeepJewelry; // 0xB8
	[SerializeField]
	private GameObject pickupFilterMagicRequiredTemplateGo; // 0xC0
	[SerializeField]
	private GameObject requiredFieldListingGo; // 0xC8
	private ProfileData profile; // 0xD0
	private UnityConfigPickup.MagicRequiredTemplate magicRequiredTemplate; // 0xD8
	private Dictionary<string, UnityConfigPickup.MagicRequiredTemplate> magicRequiredMapping; // 0xE0

	// Methods

	// RVA: 0xEFE9A4 Offset: 0xEFA9A4 VA: 0xEFE9A4
	private void Start() { }

	// RVA: 0xEFF23C Offset: 0xEFB23C VA: 0xEFF23C
	private UnityConfigPickup.MagicRequiredTemplate GetMagicRequiredTemplate() { }

	// RVA: 0xEFF06C Offset: 0xEFB06C VA: 0xEFF06C
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xEFF490 Offset: 0xEFB490 VA: 0xEFF490
	private void SaveProfile(object _) { }

	// RVA: 0xEFF508 Offset: 0xEFB508 VA: 0xEFF508
	private void CreateAllMagicRequiredField() { }

	// RVA: 0xEFFCB0 Offset: 0xEFBCB0 VA: 0xEFFCB0
	public void SetActive(bool enable) { }

	// RVA: 0xEFFCD8 Offset: 0xEFBCD8 VA: 0xEFFCD8
	public void ApplyProfile(ProfileData profile) { }

	// RVA: 0xF002BC Offset: 0xEFC2BC VA: 0xF002BC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF002C4 Offset: 0xEFC2C4 VA: 0xF002C4
	private void <Start>b__25_0(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF00318 Offset: 0xEFC318 VA: 0xF00318
	private void <Start>b__25_1(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF00480 Offset: 0xEFC480 VA: 0xF00480
	private void <Start>b__25_20() { }

	[CompilerGenerated]
	// RVA: 0xF004E8 Offset: 0xEFC4E8 VA: 0xF004E8
	private void <Start>b__25_21() { }

	[CompilerGenerated]
	// RVA: 0xF0054C Offset: 0xEFC54C VA: 0xF0054C
	private void <Start>b__25_2(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF005A0 Offset: 0xEFC5A0 VA: 0xF005A0
	private void <Start>b__25_3(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF005F4 Offset: 0xEFC5F4 VA: 0xF005F4
	private void <Start>b__25_4(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF00648 Offset: 0xEFC648 VA: 0xF00648
	private void <Start>b__25_5(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF0069C Offset: 0xEFC69C VA: 0xF0069C
	private void <Start>b__25_6(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF006F0 Offset: 0xEFC6F0 VA: 0xF006F0
	private void <Start>b__25_7(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF00744 Offset: 0xEFC744 VA: 0xF00744
	private void <Start>b__25_8(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF00798 Offset: 0xEFC798 VA: 0xF00798
	private void <Start>b__25_9(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF007EC Offset: 0xEFC7EC VA: 0xF007EC
	private void <Start>b__25_10(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF00840 Offset: 0xEFC840 VA: 0xF00840
	private void <Start>b__25_11(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF00894 Offset: 0xEFC894 VA: 0xF00894
	private void <Start>b__25_12(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF008E8 Offset: 0xEFC8E8 VA: 0xF008E8
	private void <Start>b__25_13(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF0093C Offset: 0xEFC93C VA: 0xF0093C
	private void <Start>b__25_14(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF00990 Offset: 0xEFC990 VA: 0xF00990
	private void <Start>b__25_15(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF009E4 Offset: 0xEFC9E4 VA: 0xF009E4
	private void <Start>b__25_16(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF00A38 Offset: 0xEFCA38 VA: 0xF00A38
	private void <Start>b__25_17(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF00A8C Offset: 0xEFCA8C VA: 0xF00A8C
	private void <Start>b__25_18(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF00AE0 Offset: 0xEFCAE0 VA: 0xF00AE0
	private void <Start>b__25_19(bool value) { }
}

// Namespace: game.ui.autoplay
public class UnityConfigRecover : MonoBehaviour // TypeDefIndex: 2897
{
	// Fields
	[SerializeField]
	private Toggle health1Toggle; // 0x20
	[SerializeField]
	private TMP_InputField health1TriggerValue; // 0x28
	[SerializeField]
	private TMP_InputField health1TaskDelay; // 0x30
	[SerializeField]
	private Toggle health2Toggle; // 0x38
	[SerializeField]
	private TMP_InputField health2TriggerValue; // 0x40
	[SerializeField]
	private TMP_InputField health2TaskDelay; // 0x48
	[SerializeField]
	private Toggle mana1Toggle; // 0x50
	[SerializeField]
	private TMP_InputField mana1TriggerValue; // 0x58
	[SerializeField]
	private TMP_InputField mana1TaskDelay; // 0x60
	[SerializeField]
	private Toggle mana2Toggle; // 0x68
	[SerializeField]
	private TMP_InputField mana2TriggerValue; // 0x70
	[SerializeField]
	private TMP_InputField mana2TaskDelay; // 0x78
	[SerializeField]
	private Toggle vatphamhieuung_tienThaoLoB; // 0x80
	[SerializeField]
	private Toggle vatphamhieuung_thienSonBaoLoB; // 0x88
	[SerializeField]
	private Toggle vatphamhieuung_queHoaTuuB; // 0x90
	[SerializeField]
	private Toggle ngamyFight_tuHanPhoDoB; // 0x98
	[SerializeField]
	private TMP_InputField ngamyFight_tuHanPhoDoPercent; // 0xA0
	[SerializeField]
	private TMP_InputField ngamyFight_tuHanPhoDoDelay; // 0xA8
	[SerializeField]
	private Toggle ngamyFight_tuHanPhoDoTeamB; // 0xB0
	private ProfileData profile; // 0xB8

	// Methods

	// RVA: 0xF00D68 Offset: 0xEFCD68 VA: 0xF00D68
	private void Start() { }

	// RVA: 0xF013FC Offset: 0xEFD3FC VA: 0xF013FC
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xF015CC Offset: 0xEFD5CC VA: 0xF015CC
	public void SetActive(bool enable) { }

	// RVA: 0xF015F4 Offset: 0xEFD5F4 VA: 0xF015F4
	private void SaveProfile(object _) { }

	// RVA: 0xF0166C Offset: 0xEFD66C VA: 0xF0166C
	public void ApplyProfile(ProfileData profile) { }

	// RVA: 0xF01950 Offset: 0xEFD950 VA: 0xF01950
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF01958 Offset: 0xEFD958 VA: 0xF01958
	private void <Start>b__20_0(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF019AC Offset: 0xEFD9AC VA: 0xF019AC
	private void <Start>b__20_1(string value) { }

	[CompilerGenerated]
	// RVA: 0xF01A10 Offset: 0xEFDA10 VA: 0xF01A10
	private void <Start>b__20_2(string value) { }

	[CompilerGenerated]
	// RVA: 0xF01A74 Offset: 0xEFDA74 VA: 0xF01A74
	private void <Start>b__20_3(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF01AC8 Offset: 0xEFDAC8 VA: 0xF01AC8
	private void <Start>b__20_4(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF01B1C Offset: 0xEFDB1C VA: 0xF01B1C
	private void <Start>b__20_5(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF01B70 Offset: 0xEFDB70 VA: 0xF01B70
	private void <Start>b__20_6(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF01BC4 Offset: 0xEFDBC4 VA: 0xF01BC4
	private void <Start>b__20_7(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF01C18 Offset: 0xEFDC18 VA: 0xF01C18
	private void <Start>b__20_8(string value) { }

	[CompilerGenerated]
	// RVA: 0xF01C7C Offset: 0xEFDC7C VA: 0xF01C7C
	private void <Start>b__20_9(string value) { }

	[CompilerGenerated]
	// RVA: 0xF01CE0 Offset: 0xEFDCE0 VA: 0xF01CE0
	private void <Start>b__20_10(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF01D34 Offset: 0xEFDD34 VA: 0xF01D34
	private void <Start>b__20_11(string value) { }

	[CompilerGenerated]
	// RVA: 0xF01D98 Offset: 0xEFDD98 VA: 0xF01D98
	private void <Start>b__20_12(string value) { }

	[CompilerGenerated]
	// RVA: 0xF01DFC Offset: 0xEFDDFC VA: 0xF01DFC
	private void <Start>b__20_13(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF01E50 Offset: 0xEFDE50 VA: 0xF01E50
	private void <Start>b__20_14(string value) { }

	[CompilerGenerated]
	// RVA: 0xF01EB4 Offset: 0xEFDEB4 VA: 0xF01EB4
	private void <Start>b__20_15(string value) { }

	[CompilerGenerated]
	// RVA: 0xF01F18 Offset: 0xEFDF18 VA: 0xF01F18
	private void <Start>b__20_16(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF01F6C Offset: 0xEFDF6C VA: 0xF01F6C
	private void <Start>b__20_17(string value) { }

	[CompilerGenerated]
	// RVA: 0xF01FD0 Offset: 0xEFDFD0 VA: 0xF01FD0
	private void <Start>b__20_18(string value) { }
}

// Namespace: game.ui.autoplay
public class UnityConfigSupport : MonoBehaviour // TypeDefIndex: 2898
{
	// Fields
	public GameObject chatDescription; // 0x20
	public Button chatButtonSnap; // 0x28
	public TextMeshProUGUI chatSnappedInput; // 0x30
	public TextMeshProUGUI chatSnappedReply; // 0x38
	public Toggle chatToggleEnabled; // 0x40
	public Toggle chatNearToggle; // 0x48
	public TMP_InputField chatNearInput; // 0x50
	public Toggle chatWorldToggle; // 0x58
	public TMP_InputField chatWorldInput; // 0x60
	public Toggle chatCityToggle; // 0x68
	public TMP_InputField chatCityInput; // 0x70
	private ProfileData profile; // 0x78

	// Methods

	// RVA: 0xF02034 Offset: 0xEFE034 VA: 0xF02034
	private void Start() { }

	// RVA: 0xF0236C Offset: 0xEFE36C VA: 0xF0236C
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xF0253C Offset: 0xEFE53C VA: 0xF0253C
	public void SetActive(bool enable) { }

	// RVA: 0xF02564 Offset: 0xEFE564 VA: 0xF02564
	private void SaveProfile(object _) { }

	// RVA: 0xF025DC Offset: 0xEFE5DC VA: 0xF025DC
	public void ApplyProfile(ProfileData profile) { }

	// RVA: 0xF027C8 Offset: 0xEFE7C8 VA: 0xF027C8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF027D0 Offset: 0xEFE7D0 VA: 0xF027D0
	private void <Start>b__12_0() { }

	[CompilerGenerated]
	// RVA: 0xF028BC Offset: 0xEFE8BC VA: 0xF028BC
	private void <Start>b__12_1(bool ticked) { }

	[CompilerGenerated]
	// RVA: 0xF02910 Offset: 0xEFE910 VA: 0xF02910
	private void <Start>b__12_2(bool ticked) { }

	[CompilerGenerated]
	// RVA: 0xF02964 Offset: 0xEFE964 VA: 0xF02964
	private void <Start>b__12_3(string value) { }

	[CompilerGenerated]
	// RVA: 0xF029C8 Offset: 0xEFE9C8 VA: 0xF029C8
	private void <Start>b__12_4(bool ticked) { }

	[CompilerGenerated]
	// RVA: 0xF02A1C Offset: 0xEFEA1C VA: 0xF02A1C
	private void <Start>b__12_5(string value) { }

	[CompilerGenerated]
	// RVA: 0xF02A80 Offset: 0xEFEA80 VA: 0xF02A80
	private void <Start>b__12_6(bool ticked) { }

	[CompilerGenerated]
	// RVA: 0xF02AD4 Offset: 0xEFEAD4 VA: 0xF02AD4
	private void <Start>b__12_7(string value) { }
}

// Namespace: game.ui.autoplay
public class UnityConfigTeam : MonoBehaviour // TypeDefIndex: 2899
{
	// Fields
	[SerializeField]
	private Toggle teamControlOn; // 0x20
	[SerializeField]
	private Toggle teamControlAwayCaptain; // 0x28
	[SerializeField]
	private Toggle teamCreatePublic; // 0x30
	[SerializeField]
	private Toggle teamCreatePrivate; // 0x38
	[SerializeField]
	private Toggle teamRequestAll; // 0x40
	[SerializeField]
	private Toggle teamRequestCid; // 0x48
	[SerializeField]
	private TMP_InputField teamCidListingAddInput; // 0x50
	[SerializeField]
	private Button teamCidListingAddButton; // 0x58
	[SerializeField]
	private Button teamCidListingClearButton; // 0x60
	[SerializeField]
	private TextMeshProUGUI teamCidListingContentTmp; // 0x68
	private ProfileData profile; // 0x70

	// Methods

	// RVA: 0xF02B38 Offset: 0xEFEB38 VA: 0xF02B38
	private void Start() { }

	// RVA: 0xF02E40 Offset: 0xEFEE40 VA: 0xF02E40
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xF03010 Offset: 0xEFF010 VA: 0xF03010
	private void SaveProfile(object _) { }

	// RVA: 0xF03088 Offset: 0xEFF088 VA: 0xF03088
	public void SetActive(bool enable) { }

	// RVA: 0xF030B0 Offset: 0xEFF0B0 VA: 0xF030B0
	public void ApplyProfile(ProfileData profile) { }

	// RVA: 0xF031BC Offset: 0xEFF1BC VA: 0xF031BC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF031C4 Offset: 0xEFF1C4 VA: 0xF031C4
	private void <Start>b__11_0(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF03218 Offset: 0xEFF218 VA: 0xF03218
	private void <Start>b__11_1(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF0326C Offset: 0xEFF26C VA: 0xF0326C
	private void <Start>b__11_2(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF032C0 Offset: 0xEFF2C0 VA: 0xF032C0
	private void <Start>b__11_3(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF03314 Offset: 0xEFF314 VA: 0xF03314
	private void <Start>b__11_4(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF03368 Offset: 0xEFF368 VA: 0xF03368
	private void <Start>b__11_5(bool value) { }

	[CompilerGenerated]
	// RVA: 0xF033BC Offset: 0xEFF3BC VA: 0xF033BC
	private void <Start>b__11_6() { }

	[CompilerGenerated]
	// RVA: 0xF03478 Offset: 0xEFF478 VA: 0xF03478
	private void <Start>b__11_7() { }
}

// Namespace: 
private class UnityPositionEditing.FieldTemplate // TypeDefIndex: 2900
{
	// Fields
	public GameObject go; // 0x10
	public TextMeshProUGUI positionTmp; // 0x18
	public Button gotoButton; // 0x20
	public TextMeshProUGUI gotoTmp; // 0x28
	public Button removeButton; // 0x30
	public Position position; // 0x38

	// Methods

	// RVA: 0xF043C4 Offset: 0xF003C4 VA: 0xF043C4
	public static UnityPositionEditing.FieldTemplate Clone(GameObject go, GameObject parent) { }

	// RVA: 0xF04C84 Offset: 0xF00C84 VA: 0xF04C84
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityPositionEditing.<>c__DisplayClass28_0 // TypeDefIndex: 2901
{
	// Fields
	public UnityPositionEditing.FieldTemplate field; // 0x10
	public UnityPositionEditing <>4__this; // 0x18

	// Methods

	// RVA: 0xF043BC Offset: 0xF003BC VA: 0xF043BC
	public void .ctor() { }

	// RVA: 0xF04C8C Offset: 0xF00C8C VA: 0xF04C8C
	internal void <AddPosition>b__0() { }

	// RVA: 0xF04D54 Offset: 0xF00D54 VA: 0xF04D54
	internal void <AddPosition>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityPositionEditing.<>c__DisplayClass29_0 // TypeDefIndex: 2902
{
	// Fields
	public UnityPositionEditing <>4__this; // 0x10
	public ConcurrentDictionary<int, Position> currentListing; // 0x18

	// Methods

	// RVA: 0xF04810 Offset: 0xF00810 VA: 0xF04810
	public void .ctor() { }

	// RVA: 0xF04DCC Offset: 0xF00DCC VA: 0xF04DCC
	internal void <Open>b__0() { }
}

// Namespace: game.ui.autoplay
public class UnityPositionEditing : MonoBehaviour // TypeDefIndex: 2903
{
	// Fields
	[SerializeField]
	private UnityAutoplay unityAutoplay; // 0x20
	[SerializeField]
	private Button buttonClose; // 0x28
	[SerializeField]
	private Button currentPositionAddButton; // 0x30
	[SerializeField]
	private TextMeshProUGUI currentPositionTmp; // 0x38
	[SerializeField]
	private GameObject fieldTemplate; // 0x40
	[SerializeField]
	private GameObject listingContent; // 0x48
	[SerializeField]
	private ScrollRect listingScrollRect; // 0x50
	[SerializeField]
	private TMP_InputField pointRadiusInput; // 0x58
	private Queue<Action> onStartActions; // 0x60
	private bool isStarted; // 0x68
	private long lastFps18Frame; // 0x70
	private bool isScrollBottomWaiting; // 0x78
	private const int pointRectangleWidth = 40;
	private const int pointAreaMinWidth = 20;
	private static readonly Color pointPositionColor; // 0x0
	private static readonly Color pointAreaColor; // 0x10
	private List<UnityPositionEditing.FieldTemplate> fieldListing; // 0x80
	private Action<List<Position>, int> onFinish; // 0x88
	private int pointRadius; // 0x90

	// Methods

	// RVA: 0xF034E8 Offset: 0xEFF4E8 VA: 0xF034E8
	private void Start() { }

	// RVA: 0xF038BC Offset: 0xEFF8BC VA: 0xF038BC
	private void Update() { }

	// RVA: 0xF036EC Offset: 0xEFF6EC VA: 0xF036EC
	private void ApplyChildrenPCInput(Transform transform) { }

	// RVA: 0xF03A5C Offset: 0xEFFA5C VA: 0xF03A5C
	private void Perform(Action action) { }

	// RVA: 0xF03B2C Offset: 0xEFFB2C VA: 0xF03B2C
	private void Clear() { }

	// RVA: 0xF03CEC Offset: 0xEFFCEC VA: 0xF03CEC
	private void RenderPoint(UnityPositionEditing.FieldTemplate field) { }

	// RVA: 0xF03E38 Offset: 0xEFFE38 VA: 0xF03E38
	private void RerenderMapDot() { }

	// RVA: 0xF03FB0 Offset: 0xEFFFB0 VA: 0xF03FB0
	private void RemovePosition(UnityPositionEditing.FieldTemplate field) { }

	// RVA: 0xF04058 Offset: 0xF00058 VA: 0xF04058
	private void AddPosition(Position position) { }

	// RVA: 0xF046A4 Offset: 0xF006A4 VA: 0xF046A4
	public void Open(ConcurrentDictionary<int, Position> currentListing, int pointRadius, Action<List<Position>, int> onFinish) { }

	// RVA: 0xF04818 Offset: 0xF00818 VA: 0xF04818
	public void Close() { }

	// RVA: 0xF04AB8 Offset: 0xF00AB8 VA: 0xF04AB8
	private void AddCurrentPosition() { }

	// RVA: 0xF04BDC Offset: 0xF00BDC VA: 0xF04BDC
	public void .ctor() { }

	// RVA: 0xF04BEC Offset: 0xF00BEC VA: 0xF04BEC
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xF04C50 Offset: 0xF00C50 VA: 0xF04C50
	private void <Start>b__12_0(string value) { }
}

// Namespace: game.ui.autoplay
public class UnityProfileDefaultField : MonoBehaviour // TypeDefIndex: 2904
{
	// Fields
	[SerializeField]
	public GameObject normalGo; // 0x20
	[SerializeField]
	public TextMeshProUGUI normalName; // 0x28
	[SerializeField]
	public GameObject activeGo; // 0x30
	[SerializeField]
	public TextMeshProUGUI activeName; // 0x38
	[SerializeField]
	public Button button; // 0x40

	// Methods

	// RVA: 0xF04E7C Offset: 0xF00E7C VA: 0xF04E7C
	public void SetActive(bool active) { }

	// RVA: 0xF04EA4 Offset: 0xF00EA4 VA: 0xF04EA4
	public void SetName(string name) { }

	// RVA: 0xF04ED8 Offset: 0xF00ED8 VA: 0xF04ED8
	public void SetState(bool activate) { }

	// RVA: 0xF04F34 Offset: 0xF00F34 VA: 0xF04F34
	public UnityProfileDefaultField Clone(string name) { }

	// RVA: 0xF04FF8 Offset: 0xF00FF8 VA: 0xF04FF8
	public void .ctor() { }
}

// Namespace: game.ui.autoplay
public class UnityProfileDefaultList : MonoBehaviour // TypeDefIndex: 2905
{
	// Fields
	[SerializeField]
	public UnityProfileDefaultField fieldTemplate; // 0x20
	private UnityProfileDefaultField fieldCurrently; // 0x28
	private ProfileIdentify profileCurrently; // 0x30
	private Action<ProfileIdentify> onSelectCallback; // 0x38

	// Methods

	// RVA: 0xF05000 Offset: 0xF01000 VA: 0xF05000
	private void Start() { }

	// RVA: 0xF05018 Offset: 0xF01018 VA: 0xF05018
	public string GetCurrentGuid() { }

	// RVA: 0xF05040 Offset: 0xF01040 VA: 0xF05040
	public void Clear() { }

	// RVA: 0xF05108 Offset: 0xF01108 VA: 0xF05108
	public bool IsCurrently(string guid) { }

	// RVA: 0xF05124 Offset: 0xF01124 VA: 0xF05124
	public void SetDefaultField(ProfileIdentify profileData) { }

	// RVA: 0xF052AC Offset: 0xF012AC VA: 0xF052AC
	public void SetCallback(Action<ProfileIdentify> onselect) { }

	// RVA: 0xF052B4 Offset: 0xF012B4 VA: 0xF052B4
	public void UnSelect() { }

	// RVA: 0xF05338 Offset: 0xF01338 VA: 0xF05338
	public void Select() { }

	// RVA: 0xF053BC Offset: 0xF013BC VA: 0xF053BC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF053C4 Offset: 0xF013C4 VA: 0xF053C4
	private void <SetDefaultField>b__8_0() { }
}

// Namespace: game.ui.autoplay
public class UnityProfileManualCreate : MonoBehaviour // TypeDefIndex: 2906
{
	// Fields
	[SerializeField]
	public TMP_InputField nameInput; // 0x20
	[SerializeField]
	public Button button; // 0x28
	private Action<string> onCreate; // 0x30

	// Methods

	// RVA: 0xF05458 Offset: 0xF01458 VA: 0xF05458
	private void Start() { }

	// RVA: 0xF054E8 Offset: 0xF014E8 VA: 0xF054E8
	public void SetOnCreate(Action<string> onCreate) { }

	// RVA: 0xF054F0 Offset: 0xF014F0 VA: 0xF054F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF054F8 Offset: 0xF014F8 VA: 0xF054F8
	private void <Start>b__3_0() { }
}

// Namespace: game.ui.autoplay
public class UnityProfileManualField : MonoBehaviour // TypeDefIndex: 2907
{
	// Fields
	[SerializeField]
	public GameObject normalGo; // 0x20
	[SerializeField]
	public TextMeshProUGUI normalName; // 0x28
	[SerializeField]
	public Button normalDeleteButton; // 0x30
	[SerializeField]
	public Button normalSetDefaultButton; // 0x38
	[SerializeField]
	public GameObject activeGo; // 0x40
	[SerializeField]
	public TextMeshProUGUI activeName; // 0x48
	[SerializeField]
	public Button activeDeleteButton; // 0x50
	[SerializeField]
	public Button activeSetDefaultButton; // 0x58
	[SerializeField]
	public Button selectButton; // 0x60
	private ProfileIdentify profileData; // 0x68
	private Action<ProfileIdentify> onSelect; // 0x70
	private Action<ProfileIdentify> onDelete; // 0x78
	private Action<ProfileIdentify> onSetDefault; // 0x80

	// Methods

	// RVA: 0xF05550 Offset: 0xF01550 VA: 0xF05550
	public void SetActive(bool active) { }

	// RVA: 0xF05578 Offset: 0xF01578 VA: 0xF05578
	public void SetName(string name) { }

	// RVA: 0xF055AC Offset: 0xF015AC VA: 0xF055AC
	public void SetState(bool activate) { }

	// RVA: 0xF05608 Offset: 0xF01608 VA: 0xF05608
	public void SetAction(Action<ProfileIdentify> onSelect, Action<ProfileIdentify> onDelete, Action<ProfileIdentify> onSetDefault) { }

	// RVA: 0xF05898 Offset: 0xF01898 VA: 0xF05898
	public UnityProfileManualField Clone(ProfileIdentify profileData) { }

	// RVA: 0xF05970 Offset: 0xF01970 VA: 0xF05970
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF05978 Offset: 0xF01978 VA: 0xF05978
	private void <SetAction>b__16_0() { }

	[CompilerGenerated]
	// RVA: 0xF05998 Offset: 0xF01998 VA: 0xF05998
	private void <SetAction>b__16_1() { }

	[CompilerGenerated]
	// RVA: 0xF059B8 Offset: 0xF019B8 VA: 0xF059B8
	private void <SetAction>b__16_2() { }

	[CompilerGenerated]
	// RVA: 0xF059D8 Offset: 0xF019D8 VA: 0xF059D8
	private void <SetAction>b__16_3() { }

	[CompilerGenerated]
	// RVA: 0xF059F8 Offset: 0xF019F8 VA: 0xF059F8
	private void <SetAction>b__16_4() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UnityProfileManualList.<>c__DisplayClass12_0 // TypeDefIndex: 2908
{
	// Fields
	public UnityProfileManualList <>4__this; // 0x10
	public UnityProfileManualField field; // 0x18

	// Methods

	// RVA: 0xF05EE8 Offset: 0xF01EE8 VA: 0xF05EE8
	public void .ctor() { }

	// RVA: 0xF06528 Offset: 0xF02528 VA: 0xF06528
	internal void <Add>b__0(ProfileIdentify profile) { }

	// RVA: 0xF06590 Offset: 0xF02590 VA: 0xF06590
	internal void <Add>b__1(ProfileIdentify profile) { }
}

// Namespace: game.ui.autoplay
public class UnityProfileManualList : MonoBehaviour // TypeDefIndex: 2909
{
	// Fields
	[SerializeField]
	public UnityProfileManualField fieldTemplate; // 0x20
	[SerializeField]
	public UnityProfileManualCreate create; // 0x28
	[SerializeField]
	public TextMeshProUGUI descriptionTitle; // 0x30
	[SerializeField]
	private Button removeOtherProfilesButton; // 0x38
	private Action<ProfileIdentify> onSelect; // 0x40
	private Action<ProfileIdentify> onDelete; // 0x48
	private Action<ProfileIdentify> onSetDefault; // 0x50
	private Action<string> onCreate; // 0x58
	private Dictionary<string, UnityProfileManualField> fieldList; // 0x60

	// Methods

	// RVA: 0xF05A18 Offset: 0xF01A18 VA: 0xF05A18
	private void Start() { }

	// RVA: 0xF05B1C Offset: 0xF01B1C VA: 0xF05B1C
	public void RefreshTitle() { }

	// RVA: 0xF05C70 Offset: 0xF01C70 VA: 0xF05C70
	public void SetCallback(Action<ProfileIdentify> onSelect, Action<ProfileIdentify> onDelete, Action<ProfileIdentify> onSetDefault, Action<string> onCreate) { }

	// RVA: 0xF05CD0 Offset: 0xF01CD0 VA: 0xF05CD0
	public void Add(ProfileIdentify profile) { }

	// RVA: 0xF05EF0 Offset: 0xF01EF0 VA: 0xF05EF0
	private void Delete(ProfileIdentify profile) { }

	// RVA: 0xF05FDC Offset: 0xF01FDC VA: 0xF05FDC
	public void Clear() { }

	// RVA: 0xF0617C Offset: 0xF0217C VA: 0xF0617C
	public void UnselectAll() { }

	// RVA: 0xF062BC Offset: 0xF022BC VA: 0xF062BC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF06344 Offset: 0xF02344 VA: 0xF06344
	private void <Start>b__9_0(string name) { }

	[CompilerGenerated]
	// RVA: 0xF06394 Offset: 0xF02394 VA: 0xF06394
	private void <Start>b__9_1() { }

	[CompilerGenerated]
	// RVA: 0xF06474 Offset: 0xF02474 VA: 0xF06474
	private void <Start>b__9_2() { }
}

// Namespace: game.ui.autoplay
public class BlockingCommand // TypeDefIndex: 2910
{
	// Fields
	private readonly Main main; // 0x10
	private List<Func<bool>> commands; // 0x18

	// Methods

	// RVA: 0xF065E0 Offset: 0xF025E0 VA: 0xF065E0
	public void .ctor(Main main) { }

	// RVA: 0xF06610 Offset: 0xF02610 VA: 0xF06610
	public void Release() { }

	// RVA: 0xF0661C Offset: 0xF0261C VA: 0xF0661C
	public void AddCommand(Func<bool> func) { }

	// RVA: 0xF0671C Offset: 0xF0271C VA: 0xF0671C
	public bool Activate() { }
}

// Namespace: 
public class FuncSkillAttack.Data // TypeDefIndex: 2911
{
	// Fields
	public bool isValid; // 0x10
	public int skillid; // 0x14
	public int attackRadius; // 0x18
	public int castMaxTimes; // 0x1C
	public int castCurrentTimes; // 0x20

	// Methods

	// RVA: 0xF06BD0 Offset: 0xF02BD0 VA: 0xF06BD0
	public void .ctor() { }
}

// Namespace: game.ui.autoplay
public class FuncSkillAttack // TypeDefIndex: 2912
{
	// Fields
	private readonly FuncSkillAttack.Data kyNangChinh; // 0x10
	private readonly FuncSkillAttack.Data kyNangPhu; // 0x18
	public bool kyNangPhuCurrently; // 0x20

	// Methods

	// RVA: 0xF067E8 Offset: 0xF027E8 VA: 0xF067E8
	public void Clear() { }

	// RVA: 0xF06814 Offset: 0xF02814 VA: 0xF06814
	public void ResetKyNangChinh(ProfileData profile, PlayerMain mainPlayer) { }

	// RVA: 0xF06944 Offset: 0xF02944 VA: 0xF06944
	public void ResetKyNangPhu(ProfileData profile, PlayerMain mainPlayer) { }

	// RVA: 0xF06A74 Offset: 0xF02A74 VA: 0xF06A74
	private FuncSkillAttack.Data CurrentKyNangChinh() { }

	// RVA: 0xF06AD4 Offset: 0xF02AD4 VA: 0xF06AD4
	private FuncSkillAttack.Data CurrentKyNangPhu() { }

	// RVA: 0xF06B30 Offset: 0xF02B30 VA: 0xF06B30
	public FuncSkillAttack.Data Current() { }

	// RVA: 0xF06B40 Offset: 0xF02B40 VA: 0xF06B40
	public void .ctor() { }
}

// Namespace: 
public class FuncSkillSupport.Data // TypeDefIndex: 2913
{
	// Fields
	public bool isValid; // 0x10
	public int skillid; // 0x14
	public int attackRadius; // 0x18
	public bool isSelfBuff; // 0x1C
	public int stateSpecialId; // 0x20

	// Methods

	// RVA: 0xF0719C Offset: 0xF0319C VA: 0xF0719C
	public void .ctor() { }
}

// Namespace: game.ui.autoplay
public class FuncSkillSupport // TypeDefIndex: 2914
{
	// Fields
	private readonly FuncSkillSupport.Data hotro1; // 0x10
	private readonly FuncSkillSupport.Data hotro2; // 0x18
	private readonly FuncSkillSupport.Data hotro3; // 0x20

	// Methods

	// RVA: 0xF06BD8 Offset: 0xF02BD8 VA: 0xF06BD8
	public void Clear() { }

	// RVA: 0xF06BDC Offset: 0xF02BDC VA: 0xF06BDC
	public void ResetHoTro1(ProfileData profile, PlayerMain mainPlayer) { }

	// RVA: 0xF06CFC Offset: 0xF02CFC VA: 0xF06CFC
	public void ResetHoTro2(ProfileData profile, PlayerMain mainPlayer) { }

	// RVA: 0xF06E1C Offset: 0xF02E1C VA: 0xF06E1C
	public void ResetHoTro3(ProfileData profile, PlayerMain mainPlayer) { }

	// RVA: 0xF06F3C Offset: 0xF02F3C VA: 0xF06F3C
	public FuncSkillSupport.Data CurrentBuffSelf(ProfileData profile, PlayerMain mainPlayer) { }

	// RVA: 0xF07018 Offset: 0xF03018 VA: 0xF07018
	public FuncSkillSupport.Data CurrentBuffSpell(ProfileData profile, PlayerMain mainPlayer, Controller target) { }

	// RVA: 0xF070E8 Offset: 0xF030E8 VA: 0xF070E8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NgaMyFight.<>c__DisplayClass5_0 // TypeDefIndex: 2915
{
	// Fields
	public NpcRes.Special _target; // 0x10
	public NgaMyFight <>4__this; // 0x18
	public Action <>9__3; // 0x20

	// Methods

	// RVA: 0xF07838 Offset: 0xF03838 VA: 0xF07838
	public void .ctor() { }

	// RVA: 0xF07894 Offset: 0xF03894 VA: 0xF07894
	internal void <Activate>b__1() { }

	// RVA: 0xF07950 Offset: 0xF03950 VA: 0xF07950
	internal void <Activate>b__3() { }

	// RVA: 0xF079B4 Offset: 0xF039B4 VA: 0xF079B4
	internal void <Activate>b__2() { }
}

// Namespace: game.ui.autoplay
public class NgaMyFight // TypeDefIndex: 2916
{
	// Fields
	private readonly Main main; // 0x10
	private long nextTuHanPhoDoTime; // 0x18
	private Dictionary<int, bool> ignorePosition; // 0x20

	// Methods

	// RVA: 0xF071A4 Offset: 0xF031A4 VA: 0xF071A4
	public void .ctor(Main main) { }

	// RVA: 0xF071D4 Offset: 0xF031D4 VA: 0xF071D4
	public void Release() { }

	// RVA: 0xF07234 Offset: 0xF03234 VA: 0xF07234
	public bool Activate(long looptimes) { }

	[CompilerGenerated]
	// RVA: 0xF07840 Offset: 0xF03840 VA: 0xF07840
	private void <Activate>b__5_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Pickup.<>c__DisplayClass12_0 // TypeDefIndex: 2917
{
	// Fields
	public Pickup <>4__this; // 0x10
	public Object target; // 0x18

	// Methods

	// RVA: 0xF08840 Offset: 0xF04840 VA: 0xF08840
	public void .ctor() { }

	// RVA: 0xF09ECC Offset: 0xF05ECC VA: 0xF09ECC
	internal void <FollowObjectTarget>b__0() { }

	// RVA: 0xF09F48 Offset: 0xF05F48 VA: 0xF09F48
	internal void <FollowObjectTarget>b__1() { }

	// RVA: 0xF0A02C Offset: 0xF0602C VA: 0xF0A02C
	internal void <FollowObjectTarget>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Pickup.<>c__DisplayClass15_0 // TypeDefIndex: 2918
{
	// Fields
	public Pickup <>4__this; // 0x10
	public int blockingLastObjectCount; // 0x18
	public int blockingType; // 0x1C
	public int blockingRemaining; // 0x20

	// Methods

	// RVA: 0xF08F84 Offset: 0xF04F84 VA: 0xF08F84
	public void .ctor() { }

	// RVA: 0xF0A054 Offset: 0xF06054 VA: 0xF0A054
	internal bool <CatchIgnoreItemOnThrow>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Pickup.<>c__DisplayClass17_0 // TypeDefIndex: 2919
{
	// Fields
	public int delayTimes; // 0x10
	public Pickup <>4__this; // 0x18

	// Methods

	// RVA: 0xF09DD0 Offset: 0xF05DD0 VA: 0xF09DD0
	public void .ctor() { }

	// RVA: 0xF0A3C0 Offset: 0xF063C0 VA: 0xF0A3C0
	internal bool <SafeAreaFiltering>b__4() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Pickup.<>c__DisplayClass19_0 // TypeDefIndex: 2920
{
	// Fields
	public int delayTimes; // 0x10
	public Pickup <>4__this; // 0x18
	public Func<bool> <>9__2; // 0x20

	// Methods

	// RVA: 0xF09EC4 Offset: 0xF05EC4 VA: 0xF09EC4
	public void .ctor() { }

	// RVA: 0xF0A4E8 Offset: 0xF064E8 VA: 0xF0A4E8
	internal bool <SafeAreaMoveEquipToStorage>b__1() { }

	// RVA: 0xF0A6E0 Offset: 0xF066E0 VA: 0xF0A6E0
	internal bool <SafeAreaMoveEquipToStorage>b__2() { }
}

// Namespace: game.ui.autoplay
public class Pickup // TypeDefIndex: 2921
{
	// Fields
	private readonly Main main; // 0x10
	private string currentObjectSelected; // 0x18
	private Dictionary<string, long> ignoreMapping; // 0x20
	private int filteringLastItemCount; // 0x28
	private bool isFirstTownportalChecked; // 0x2C

	// Methods

	// RVA: 0xF07AAC Offset: 0xF03AAC VA: 0xF07AAC
	public void .ctor(Main main) { }

	// RVA: 0xF07ADC Offset: 0xF03ADC VA: 0xF07ADC
	public void Initialize() { }

	// RVA: 0xF07B6C Offset: 0xF03B6C VA: 0xF07B6C
	public void ClearForFightMode() { }

	// RVA: 0xF07BE8 Offset: 0xF03BE8 VA: 0xF07BE8
	public void Release() { }

	// RVA: 0xF07C84 Offset: 0xF03C84 VA: 0xF07C84
	private bool IgnoreIsExisting(string key) { }

	// RVA: 0xF07D48 Offset: 0xF03D48 VA: 0xF07D48
	private void IgnoreAdd(string key, int seconds) { }

	// RVA: 0xF07E24 Offset: 0xF03E24 VA: 0xF07E24
	public bool FightPicking(long looptimes) { }

	// RVA: 0xF08654 Offset: 0xF04654 VA: 0xF08654
	private void FollowObjectTarget(Object target) { }

	// RVA: 0xF08848 Offset: 0xF04848 VA: 0xF08848
	private static bool CheckItemIsJewelry(Item item) { }

	// RVA: 0xF0886C Offset: 0xF0486C VA: 0xF0886C
	public bool FightFiltering() { }

	// RVA: 0xF08E94 Offset: 0xF04E94 VA: 0xF08E94
	private void CatchIgnoreItemOnThrow(int itemDetail) { }

	// RVA: 0xF08F8C Offset: 0xF04F8C VA: 0xF08F8C
	private Item FilterFindItem() { }

	// RVA: 0xF094D8 Offset: 0xF054D8 VA: 0xF094D8
	private bool SafeAreaFiltering() { }

	// RVA: 0xF09708 Offset: 0xF05708 VA: 0xF09708
	private Item MoveToStorageFindItem() { }

	// RVA: 0xF099A4 Offset: 0xF059A4 VA: 0xF099A4
	private bool SafeAreaMoveEquipToStorage() { }

	// RVA: 0xF09B14 Offset: 0xF05B14 VA: 0xF09B14
	public bool ActivateSafeArea() { }

	[CompilerGenerated]
	// RVA: 0xF09B58 Offset: 0xF05B58 VA: 0xF09B58
	private void <SafeAreaFiltering>b__17_0() { }

	[CompilerGenerated]
	// RVA: 0xF09BFC Offset: 0xF05BFC VA: 0xF09BFC
	private bool <SafeAreaFiltering>b__17_2() { }

	[CompilerGenerated]
	// RVA: 0xF09C44 Offset: 0xF05C44 VA: 0xF09C44
	private void <SafeAreaFiltering>b__17_1(string npcName, int mapX, int mapY) { }

	[CompilerGenerated]
	// RVA: 0xF09CFC Offset: 0xF05CFC VA: 0xF09CFC
	private void <SafeAreaFiltering>b__17_3() { }

	[CompilerGenerated]
	// RVA: 0xF09DD8 Offset: 0xF05DD8 VA: 0xF09DD8
	private void <SafeAreaMoveEquipToStorage>b__19_0(string npcname, int mapx, int mapy) { }
}

// Namespace: 
public class ProfileBase.ItemInfo // TypeDefIndex: 2922
{
	// Fields
	public int g; // 0x10
	public int d; // 0x14
	public int p; // 0x18
	public string name; // 0x20

	// Methods

	// RVA: 0xF0EBB8 Offset: 0xF0ABB8 VA: 0xF0EBB8
	public void .ctor(int g, int d, int p, string name) { }
}

// Namespace: 
public class ProfileBase.Attack.MucTieuTypeV // TypeDefIndex: 2923
{
	// Fields
	public const int ChiDanhQuai = 0;
	public const int UuTienQuai = 1;
	public const int UuTienNguoi = 2;
	public const int ChiDanhNguoi = 3;

	// Methods

	// RVA: 0xF0EC04 Offset: 0xF0AC04 VA: 0xF0EC04
	public void .ctor() { }
}

// Namespace: 
public class ProfileBase.Attack // TypeDefIndex: 2924
{
	// Fields
	public bool tuDanhB; // 0x10
	public bool tiepCanB; // 0x11
	public int tiepCanV; // 0x14
	public bool mucTieuGanNhatB; // 0x18
	public bool mucTieuTypeB; // 0x19
	public int mucTieuTypeV; // 0x1C
	public bool lenNguaKhiDiChuyenB; // 0x20
	public bool tranhBossVang; // 0x21
	public bool kyNangChinhB; // 0x22
	public int kyNangChinhV; // 0x24
	public int kyNangChinhSkillId; // 0x28
	public bool kyNangPhuB; // 0x2C
	public int kyNangPhuV; // 0x30
	public int kyNangPhuSkillId; // 0x34
	public bool kyNangHoTro1B; // 0x38
	public int kyNangHoTro1SkillId; // 0x3C
	public bool kyNangHoTro2B; // 0x40
	public int kyNangHoTro2SkillId; // 0x44
	public bool kyNangHoTro3B; // 0x48
	public int kyNangHoTro3SkillId; // 0x4C

	// Methods

	// RVA: 0xF0E8AC Offset: 0xF0A8AC VA: 0xF0E8AC
	public void .ctor() { }
}

// Namespace: 
public class ProfileBase.Moving.RoundedType // TypeDefIndex: 2925
{
	// Fields
	public const int Free = 1;
	public const int Follow = 2;
	public const int Point = 3;
	public const int RandomPosition = 4;
	public const int ListingPosition = 5;
	public const int MixFollowAndPositionList = 6;

	// Methods

	// RVA: 0xF0ED1C Offset: 0xF0AD1C VA: 0xF0ED1C
	public void .ctor() { }
}

// Namespace: 
public class ProfileBase.Moving // TypeDefIndex: 2926
{
	// Fields
	public int kieuDiChuyen; // 0x10
	public string theoSauCid; // 0x18
	public string theoSauTen; // 0x20
	public int theoSauFaction; // 0x28
	public int theoSauKhoangCach; // 0x2C
	public int quanhDiemBanKinh; // 0x30
	public readonly Position quanhDiemToaDo; // 0x38
	public int danhSachToaDoBanKinhDiem; // 0x40
	public readonly ConcurrentDictionary<int, Position> danhSachToaDoListing; // 0x48

	// Methods

	// RVA: 0xF0E34C Offset: 0xF0A34C VA: 0xF0E34C
	public void QuanhDiemToaDoApply(string data) { }

	// RVA: 0xF0EC0C Offset: 0xF0AC0C VA: 0xF0EC0C
	public void QuanhDiemToaDoApply(Position position) { }

	// RVA: 0xF0C16C Offset: 0xF0816C VA: 0xF0C16C
	public string QuanhDiemToaDoGetData() { }

	// RVA: 0xF0E404 Offset: 0xF0A404 VA: 0xF0E404
	public void DanhSachToaDoApply(string data) { }

	// RVA: 0xF0EC30 Offset: 0xF0AC30 VA: 0xF0EC30
	public void DanhSachToaDoApply(List<Position> listing) { }

	// RVA: 0xF0C230 Offset: 0xF08230 VA: 0xF0C230
	public string DanhSachToaDoGetData() { }

	// RVA: 0xF0E8B4 Offset: 0xF0A8B4 VA: 0xF0E8B4
	public void .ctor() { }
}

// Namespace: 
public class ProfileBase.Recover.PotionType // TypeDefIndex: 2927
{
	// Fields
	public const int health = 1;
	public const int mana = 2;
	public const int healthMana = 3;
	public const int detox = 4;

	// Methods

	// RVA: 0xF0FBCC Offset: 0xF0BBCC VA: 0xF0FBCC
	public void .ctor() { }
}

// Namespace: 
public class ProfileBase.Recover.PotionInfo : ProfileBase.ItemInfo // TypeDefIndex: 2928
{
	// Fields
	public int type; // 0x28

	// Methods

	// RVA: 0xF0FB6C Offset: 0xF0BB6C VA: 0xF0FB6C
	public void .ctor(int g, int d, int p, string name, int type) { }
}

// Namespace: 
public class ProfileBase.Recover // TypeDefIndex: 2929
{
	// Fields
	public static List<ProfileBase.Recover.PotionInfo> potionList; // 0x0
	public bool hoiSinhLuc1B; // 0x10
	public int hoiSinhLuc1NhoHon; // 0x14
	public int hoiSinhLuc1Delay; // 0x18
	public bool hoiSinhLuc2B; // 0x1C
	public int hoiSinhLuc2NhoHon; // 0x20
	public int hoiSinhLuc2Delay; // 0x24
	public bool hoiNoiLuc1B; // 0x28
	public int hoiNoiLuc1NhoHon; // 0x2C
	public int hoiNoiLuc1Delay; // 0x30
	public bool hoiNoiLuc2B; // 0x34
	public int hoiNoiLuc2NhoHon; // 0x38
	public int hoiNoiLuc2Delay; // 0x3C

	// Methods

	// RVA: 0xF0E9C8 Offset: 0xF0A9C8 VA: 0xF0E9C8
	public void .ctor() { }

	// RVA: 0xF0ED24 Offset: 0xF0AD24 VA: 0xF0ED24
	private static void .cctor() { }
}

// Namespace: 
public class ProfileBase.Support // TypeDefIndex: 2930
{
	// Fields
	public bool raoKenhChat; // 0x10
	public string raoTinNhan; // 0x18
	public string raoVatPham; // 0x20
	public string raoReply; // 0x28
	public bool raoPhucanB; // 0x30
	public int raoPhucanV; // 0x34
	public bool raoThegioiB; // 0x38
	public int raoThegioiV; // 0x3C
	public bool raoThanhthiB; // 0x40
	public int raoThanhthiV; // 0x44

	// Methods

	// RVA: 0xF0E9E8 Offset: 0xF0A9E8 VA: 0xF0E9E8
	public void .ctor() { }
}

// Namespace: 
public class ProfileBase.VongSangLuanChuyen // TypeDefIndex: 2931
{
	// Fields
	public bool vongSangLuanChuyen1B; // 0x10
	public int vongSangLuanChuyen1SkillId; // 0x14
	public int vongSangLuanChuyen1DelayTime; // 0x18
	public bool vongSangLuanChuyen2B; // 0x1C
	public int vongSangLuanChuyen2SkillId; // 0x20
	public int vongSangLuanChuyen2DelayTime; // 0x24

	// Methods

	// RVA: 0xF0EA6C Offset: 0xF0AA6C VA: 0xF0EA6C
	public void .ctor() { }
}

// Namespace: 
public class ProfileBase.ThoDiaPhu // TypeDefIndex: 2932
{
	// Fields
	public bool thodiaphu_sinhLucThapB; // 0x10
	public int thodiaphu_sinhLucThapV; // 0x14
	public bool thodiaphu_noiLucThapB; // 0x18
	public int thodiaphu_noiLucThapV; // 0x1C
	public bool thodiaphu_hetBinhSinhLucB; // 0x20
	public bool thodiaphu_hetBinhNoiLucB; // 0x21
	public bool thodiaphu_tienLonB; // 0x22
	public int thodiaphu_tienLonV; // 0x24
	public bool thodiaphu_hanhTrangHetB; // 0x28
	public int thodiaphu_hanhTrangHetV; // 0x2C
	public bool thodiaphu_doBenTrangBiThapB; // 0x30
	public int thodiaphu_doBenTrangBiThapV; // 0x34
	public bool thodiaphu_biCuuSatDoSatB; // 0x38

	// Methods

	// RVA: 0xF0EA80 Offset: 0xF0AA80 VA: 0xF0EA80
	public void .ctor() { }
}

// Namespace: 
public class ProfileBase.BanDoLuuRuong // TypeDefIndex: 2933
{
	// Fields
	public bool bandoluuruong_rutTienB; // 0x10
	public int bandoluuruong_rutTienV; // 0x14
	public bool bandoluuruong_muaThuoc1B; // 0x18
	public int bandoluuruong_muaThuoc1Select; // 0x1C
	public int bandoluuruong_muaThuoc1Total; // 0x20
	public bool bandoluuruong_muaThuoc2B; // 0x24
	public int bandoluuruong_muaThuoc2Select; // 0x28
	public int bandoluuruong_muaThuoc2Total; // 0x2C
	public bool bandoluuruong_muaThuoc3B; // 0x30
	public int bandoluuruong_muaThuoc3Select; // 0x34
	public int bandoluuruong_muaThuoc3Total; // 0x38
	public bool bandoluuruong_muaThoDiaPhuB; // 0x3C
	public int bandoluuruong_muaThoDiaPhuTotal; // 0x40
	public bool bandoluuruong_suaDoTrangBiDangMacB; // 0x44
	public bool bandoluuruong_chuyenTienVaoRuongB; // 0x45
	public int bandoluuruong_chuyenTienVaoRuongKeep; // 0x48

	// Methods

	// RVA: 0xF0EAA0 Offset: 0xF0AAA0 VA: 0xF0EAA0
	public void .ctor() { }
}

// Namespace: 
public class ProfileBase.TroLaiDiemCu // TypeDefIndex: 2934
{
	// Fields
	public bool trolaidiemcu_thanhthiTroLaiDiemCuBool; // 0x10
	public string trolaidiemcu_thanhthiTroLaiDiemCuNpc; // 0x18
	public string trolaidiemcu_thanhthiTroLaiDiemCuSel; // 0x20
	public bool trolaidiemcu_thanhthiMacCaoQuatBool; // 0x28
	public string trolaidiemcu_thanhthiMacCaoQuatNpc; // 0x30
	public string trolaidiemcu_thanhthiMacCaoQuatSel; // 0x38
	public bool trolaidiemcu_tuychinhNpcBool; // 0x40
	public string trolaidiemcu_tuychinhNpcNpc; // 0x48
	public string trolaidiemcu_tuychinhNpcSel; // 0x50
	public bool trolaidiemcu_tuychinhThanHanhPhuBool; // 0x58
	public string trolaidiemcu_tuychinhThanHanhPhuSel; // 0x60

	// Methods

	// RVA: 0xF0EAB0 Offset: 0xF0AAB0 VA: 0xF0EAB0
	public void .ctor() { }
}

// Namespace: 
public class ProfileBase.VatPhamHieuUng // TypeDefIndex: 2935
{
	// Fields
	public static readonly ProfileBase.ItemInfo itemTienThaoLo; // 0x0
	public static readonly ProfileBase.ItemInfo itemThienSonBaoLo; // 0x8
	public static readonly ProfileBase.ItemInfo itemQueHoaTuu; // 0x10
	public bool vatphamhieuung_tienThaoLoB; // 0x10
	public bool vatphamhieuung_thienSonBaoLoB; // 0x11
	public bool vatphamhieuung_queHoaTuuB; // 0x12

	// Methods

	// RVA: 0xF0FBD4 Offset: 0xF0BBD4 VA: 0xF0FBD4
	public void .ctor() { }

	// RVA: 0xF0FBDC Offset: 0xF0BBDC VA: 0xF0FBDC
	private static void .cctor() { }
}

// Namespace: 
public class ProfileBase.NgaMyFight // TypeDefIndex: 2936
{
	// Fields
	public const int skillid_TuHanPhoDo = 93;
	public bool ngamyFight_tuHanPhoDoB; // 0x10
	public int ngamyFight_tuHanPhoDoPercent; // 0x14
	public int ngamyFight_tuHanPhoDoDelay; // 0x18
	public bool ngamyFight_tuHanPhoDoTeamB; // 0x1C

	// Methods

	// RVA: 0xF0FD24 Offset: 0xF0BD24 VA: 0xF0FD24
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ProfileBase.Pickup.<>c // TypeDefIndex: 2937
{
	// Fields
	public static readonly ProfileBase.Pickup.<>c <>9; // 0x0
	public static Comparison<int[]> <>9__24_0; // 0x8

	// Methods

	// RVA: 0xF10D4C Offset: 0xF0CD4C VA: 0xF10D4C
	private static void .cctor() { }

	// RVA: 0xF10DB4 Offset: 0xF0CDB4 VA: 0xF10DB4
	public void .ctor() { }

	// RVA: 0xF10DBC Offset: 0xF0CDBC VA: 0xF10DBC
	internal int <ApplyFilterData>b__24_0(int[] a, int[] b) { }
}

// Namespace: 
public class ProfileBase.Pickup // TypeDefIndex: 2938
{
	// Fields
	public static readonly Dictionary<string, int> magicMapping; // 0x0
	public bool pickupControlPick; // 0x10
	public bool pickupControlFilter; // 0x11
	public bool pickupControlPriority; // 0x12
	public bool pickupControlNewItemToStorage; // 0x13
	public bool pickupPickMoney; // 0x14
	public bool pickupPickMagicscript; // 0x15
	public bool pickupPickPotion; // 0x16
	public bool pickupPickRangeweapon; // 0x17
	public bool pickupPickMeleweapon; // 0x18
	public bool pickupPickArmor; // 0x19
	public bool pickupPickRing; // 0x1A
	public bool pickupPickAmulet; // 0x1B
	public bool pickupPickBoots; // 0x1C
	public bool pickupPickBelt; // 0x1D
	public bool pickupPickHelm; // 0x1E
	public bool pickupPickCuff; // 0x1F
	public bool pickupPickPendant; // 0x20
	public bool pickupFilterThrow; // 0x21
	public bool pickupFilterSell; // 0x22
	public bool pickupKeepJewelry; // 0x23
	public string pickupFilterData; // 0x28
	public readonly Dictionary<string, int> filterValueMapping; // 0x30

	// Methods

	// RVA: 0xF0FD38 Offset: 0xF0BD38 VA: 0xF0FD38
	public void SetFilterData(string data) { }

	// RVA: 0xF0FFB0 Offset: 0xF0BFB0 VA: 0xF0FFB0
	public void ApplyFilterData() { }

	// RVA: 0xF10530 Offset: 0xF0C530 VA: 0xF10530
	public void .ctor() { }

	// RVA: 0xF105F0 Offset: 0xF0C5F0 VA: 0xF105F0
	private static void .cctor() { }
}

// Namespace: 
public class ProfileBase.Team // TypeDefIndex: 2939
{
	// Fields
	public bool teamControlOn; // 0x10
	public bool teamControlAwayCaptain; // 0x11
	public bool teamCreatePublic; // 0x12
	public bool teamCreatePrivate; // 0x13
	public bool teamRequestAll; // 0x14
	public bool teamRequestCid; // 0x15
	public string teamRequestCidListingData; // 0x18
	public readonly Dictionary<string, bool> teamRequestCidListingMapping; // 0x20

	// Methods

	// RVA: 0xF10DF8 Offset: 0xF0CDF8 VA: 0xF10DF8
	public void SetCidListData(string data) { }

	// RVA: 0xF10EE8 Offset: 0xF0CEE8 VA: 0xF10EE8
	public void AddCidToList(string cid) { }

	// RVA: 0xF10FB8 Offset: 0xF0CFB8 VA: 0xF10FB8
	public void .ctor() { }
}

// Namespace: game.ui.autoplay
public class ProfileBase : ProfileIdentify // TypeDefIndex: 2940
{
	// Fields
	public ProfileBase.Attack attack; // 0x30
	public ProfileBase.Moving moving; // 0x38
	public ProfileBase.Recover recover; // 0x40
	public ProfileBase.Support support; // 0x48
	public ProfileBase.VongSangLuanChuyen vongSangLuanChuyen; // 0x50
	public ProfileBase.ThoDiaPhu thoDiaPhu; // 0x58
	public ProfileBase.BanDoLuuRuong banDoLuuRuong; // 0x60
	public ProfileBase.TroLaiDiemCu troLaiDiemCu; // 0x68
	public ProfileBase.VatPhamHieuUng vatPhamHieuUng; // 0x70
	public ProfileBase.NgaMyFight ngaMyFight; // 0x78
	public ProfileBase.Pickup pickup; // 0x80
	public ProfileBase.Team team; // 0x88

	// Methods

	// RVA: 0xF0A72C Offset: 0xF0672C VA: 0xF0A72C
	public string ToDataString() { }

	// RVA: -1 Offset: -1
	public Typename ParseSplitted<Typename>(string[] splitted, object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113BDF8 Offset: 0x1137DF8 VA: 0x113BDF8
	|-ProfileBase.ParseSplitted<int>
	|
	|-RVA: 0x113C040 Offset: 0x1138040 VA: 0x113C040
	|-ProfileBase.ParseSplitted<object>
	|
	|-RVA: 0x113C25C Offset: 0x113825C VA: 0x113C25C
	|-ProfileBase.ParseSplitted<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xF0C3F4 Offset: 0xF083F4 VA: 0xF0C3F4
	public void ParseFromString(string[] splitted) { }

	// RVA: 0xF0E580 Offset: 0xF0A580 VA: 0xF0E580
	public void .ctor() { }
}

// Namespace: game.ui.autoplay
public class ProfileData : ProfileLinker // TypeDefIndex: 2941
{
	// Methods

	// RVA: 0xF1106C Offset: 0xF0D06C VA: 0xF1106C
	public void .ctor() { }
}

// Namespace: game.ui.autoplay
public class ProfileIdentify // TypeDefIndex: 2942
{
	// Fields
	public string guid; // 0x10
	public string player; // 0x18
	public string name; // 0x20
	public bool isDefault; // 0x28
	public int version; // 0x2C

	// Methods

	// RVA: 0xF1107C Offset: 0xF0D07C VA: 0xF1107C
	public void .ctor() { }
}

// Namespace: game.ui.autoplay
public enum ProfileKey // TypeDefIndex: 2943
{
	// Fields
	public int value__; // 0x0
	public const ProfileKey guid = 0;
	public const ProfileKey player = 1;
	public const ProfileKey name = 2;
	public const ProfileKey isDefault = 3;
	public const ProfileKey version = 4;
	public const ProfileKey tuDanhB = 5;
	public const ProfileKey tiepCanB = 6;
	public const ProfileKey tiepCanV = 7;
	public const ProfileKey mucTieuGanNhatB = 8;
	public const ProfileKey mucTieuTypeB = 9;
	public const ProfileKey mucTieuTypeV = 10;
	public const ProfileKey lenNguaKhiDiChuyenB = 11;
	public const ProfileKey tranhBossVang = 12;
	public const ProfileKey kyNangChinhB = 13;
	public const ProfileKey kyNangChinhV = 14;
	public const ProfileKey kyNangChinhSkillId = 15;
	public const ProfileKey kyNangPhuB = 16;
	public const ProfileKey kyNangPhuV = 17;
	public const ProfileKey kyNangPhuSkillId = 18;
	public const ProfileKey kyNangHoTro1B = 19;
	public const ProfileKey kyNangHoTro1SkillId = 20;
	public const ProfileKey kyNangHoTro2B = 21;
	public const ProfileKey kyNangHoTro2SkillId = 22;
	public const ProfileKey kyNangHoTro3B = 23;
	public const ProfileKey kyNangHoTro3SkillId = 24;
	public const ProfileKey kieuDiChuyen = 25;
	public const ProfileKey theoSauCid = 26;
	public const ProfileKey theoSauTen = 27;
	public const ProfileKey theoSauFaction = 28;
	public const ProfileKey theoSauKhoangCach = 29;
	public const ProfileKey quanhDiemBanKinh = 30;
	public const ProfileKey hoiSinhLuc1B = 31;
	public const ProfileKey hoiSinhLuc1NhoHon = 32;
	public const ProfileKey hoiSinhLuc1Delay = 33;
	public const ProfileKey hoiSinhLuc2B = 34;
	public const ProfileKey hoiSinhLuc2NhoHon = 35;
	public const ProfileKey hoiSinhLuc2Delay = 36;
	public const ProfileKey hoiNoiLuc1B = 37;
	public const ProfileKey hoiNoiLuc1NhoHon = 38;
	public const ProfileKey hoiNoiLuc1Delay = 39;
	public const ProfileKey hoiNoiLuc2B = 40;
	public const ProfileKey hoiNoiLuc2NhoHon = 41;
	public const ProfileKey hoiNoiLuc2Delay = 42;
	public const ProfileKey raoKenhChat = 43;
	public const ProfileKey raoTinNhan = 44;
	public const ProfileKey raoVatPham = 45;
	public const ProfileKey raoReply = 46;
	public const ProfileKey raoPhucanB = 47;
	public const ProfileKey raoPhucanV = 48;
	public const ProfileKey raoThegioiB = 49;
	public const ProfileKey raoThegioiV = 50;
	public const ProfileKey raoThanhthiB = 51;
	public const ProfileKey raoThanhthiV = 52;
	public const ProfileKey vongSangLuanChuyen1B = 53;
	public const ProfileKey vongSangLuanChuyen1SkillId = 54;
	public const ProfileKey vongSangLuanChuyen1DelayTime = 55;
	public const ProfileKey vongSangLuanChuyen2B = 56;
	public const ProfileKey vongSangLuanChuyen2SkillId = 57;
	public const ProfileKey vongSangLuanChuyen2DelayTime = 58;
	public const ProfileKey thodiaphu_sinhLucThapB = 59;
	public const ProfileKey thodiaphu_sinhLucThapV = 60;
	public const ProfileKey thodiaphu_noiLucThapB = 61;
	public const ProfileKey thodiaphu_noiLucThapV = 62;
	public const ProfileKey thodiaphu_hetBinhSinhLucB = 63;
	public const ProfileKey thodiaphu_hetBinhNoiLucB = 64;
	public const ProfileKey thodiaphu_tienLonB = 65;
	public const ProfileKey thodiaphu_tienLonV = 66;
	public const ProfileKey thodiaphu_hanhTrangHetB = 67;
	public const ProfileKey thodiaphu_hanhTrangHetV = 68;
	public const ProfileKey thodiaphu_doBenTrangBiThapB = 69;
	public const ProfileKey thodiaphu_doBenTrangBiThapV = 70;
	public const ProfileKey thodiaphu_biCuuSatDoSatB = 71;
	public const ProfileKey bandoluuruong_rutTienB = 72;
	public const ProfileKey bandoluuruong_rutTienV = 73;
	public const ProfileKey bandoluuruong_muaThuoc1B = 74;
	public const ProfileKey bandoluuruong_muaThuoc1Select = 75;
	public const ProfileKey bandoluuruong_muaThuoc1Total = 76;
	public const ProfileKey bandoluuruong_muaThuoc2B = 77;
	public const ProfileKey bandoluuruong_muaThuoc2Select = 78;
	public const ProfileKey bandoluuruong_muaThuoc2Total = 79;
	public const ProfileKey bandoluuruong_muaThuoc3B = 80;
	public const ProfileKey bandoluuruong_muaThuoc3Select = 81;
	public const ProfileKey bandoluuruong_muaThuoc3Total = 82;
	public const ProfileKey bandoluuruong_muaThoDiaPhuB = 83;
	public const ProfileKey bandoluuruong_muaThoDiaPhuTotal = 84;
	public const ProfileKey bandoluuruong_suaDoTrangBiDangMacB = 85;
	public const ProfileKey bandoluuruong_chuyenTienVaoRuongB = 86;
	public const ProfileKey bandoluuruong_chuyenTienVaoRuongKeep = 87;
	public const ProfileKey trolaidiemcu_thanhthiTroLaiDiemCuBool = 88;
	public const ProfileKey trolaidiemcu_thanhthiTroLaiDiemCuNpc = 89;
	public const ProfileKey trolaidiemcu_thanhthiTroLaiDiemCuSel = 90;
	public const ProfileKey trolaidiemcu_thanhthiMacCaoQuatBool = 91;
	public const ProfileKey trolaidiemcu_thanhthiMacCaoQuatNpc = 92;
	public const ProfileKey trolaidiemcu_thanhthiMacCaoQuatSel = 93;
	public const ProfileKey trolaidiemcu_tuychinhNpcBool = 94;
	public const ProfileKey trolaidiemcu_tuychinhNpcNpc = 95;
	public const ProfileKey trolaidiemcu_tuychinhNpcSel = 96;
	public const ProfileKey trolaidiemcu_tuychinhThanHanhPhuBool = 97;
	public const ProfileKey trolaidiemcu_tuychinhThanHanhPhuSel = 98;
	public const ProfileKey vatphamhieuung_tienThaoLoB = 99;
	public const ProfileKey vatphamhieuung_thienSonBaoLoB = 100;
	public const ProfileKey vatphamhieuung_queHoaTuuB = 101;
	public const ProfileKey ngamyFight_tuHanPhoDoB = 102;
	public const ProfileKey ngamyFight_tuHanPhoDoPercent = 103;
	public const ProfileKey ngamyFight_tuHanPhoDoDelay = 104;
	public const ProfileKey ngamyFight_tuHanPhoDoTeamB = 105;
	public const ProfileKey pickupControlPick = 106;
	public const ProfileKey pickupControlFilter = 107;
	public const ProfileKey pickupControlPriority = 108;
	public const ProfileKey pickupControlNewItemToStorage = 109;
	public const ProfileKey pickupPickMoney = 110;
	public const ProfileKey pickupPickMagicscript = 111;
	public const ProfileKey pickupPickRangeweapon = 112;
	public const ProfileKey pickupPickMeleweapon = 113;
	public const ProfileKey pickupPickArmor = 114;
	public const ProfileKey pickupPickRing = 115;
	public const ProfileKey pickupPickAmulet = 116;
	public const ProfileKey pickupPickBoots = 117;
	public const ProfileKey pickupPickBelt = 118;
	public const ProfileKey pickupPickHelm = 119;
	public const ProfileKey pickupPickCuff = 120;
	public const ProfileKey pickupPickPendant = 121;
	public const ProfileKey pickupFilterThrow = 122;
	public const ProfileKey pickupFilterSell = 123;
	public const ProfileKey pickupFilterData = 124;
	public const ProfileKey teamControlOn = 125;
	public const ProfileKey teamControlAwayCaptain = 126;
	public const ProfileKey teamCreatePublic = 127;
	public const ProfileKey teamCreatePrivate = 128;
	public const ProfileKey teamRequestAll = 129;
	public const ProfileKey teamRequestCid = 130;
	public const ProfileKey teamRequestCidListing = 131;
	public const ProfileKey dichuyen_danhSachToaDo = 132;
	public const ProfileKey dichuyen_danhSachToaDoBanKinhDiem = 133;
	public const ProfileKey pickupKeepJewelry = 134;
	public const ProfileKey dichuyen_quanhDiemToaDo = 135;
	public const ProfileKey pickupPickPotion = 136;
	public const ProfileKey __CountAutoplay = 137;
}

// Namespace: 
private class SafeArea.PrivateClassGotoNpcField // TypeDefIndex: 2944
{
	// Fields
	public int originNameIndex; // 0x10
	public int distance; // 0x14
	public MapDialogNpc mapDialogNpc; // 0x18

	// Methods

	// RVA: 0xF120A0 Offset: 0xF0E0A0 VA: 0xF120A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class SafeArea.<>c // TypeDefIndex: 2945
{
	// Fields
	public static readonly SafeArea.<>c <>9; // 0x0
	public static Comparison<SafeArea.PrivateClassGotoNpcField> <>9__8_0; // 0x8

	// Methods

	// RVA: 0xF13920 Offset: 0xF0F920 VA: 0xF13920
	private static void .cctor() { }

	// RVA: 0xF13988 Offset: 0xF0F988 VA: 0xF13988
	public void .ctor() { }

	// RVA: 0xF13990 Offset: 0xF0F990 VA: 0xF13990
	internal int <GoToNpc>b__8_0(SafeArea.PrivateClassGotoNpcField a, SafeArea.PrivateClassGotoNpcField b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SafeArea.<>c__DisplayClass10_0 // TypeDefIndex: 2946
{
	// Fields
	public SafeArea <>4__this; // 0x10
	public long sendToStorage; // 0x18
	public long sendToBagarate; // 0x20

	// Methods

	// RVA: 0xF12578 Offset: 0xF0E578 VA: 0xF12578
	public void .ctor() { }

	// RVA: 0xF139B8 Offset: 0xF0F9B8 VA: 0xF139B8
	internal void <CheckBagarateMoney>b__0(string npcname, int mapx, int mapy) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SafeArea.<>c__DisplayClass10_1 // TypeDefIndex: 2947
{
	// Fields
	public int delayTimes; // 0x10
	public SafeArea.<>c__DisplayClass10_0 CS$<>8__locals1; // 0x18
	public Func<bool> <>9__2; // 0x20

	// Methods

	// RVA: 0xF13AB8 Offset: 0xF0FAB8 VA: 0xF13AB8
	public void .ctor() { }

	// RVA: 0xF13AC0 Offset: 0xF0FAC0 VA: 0xF13AC0
	internal bool <CheckBagarateMoney>b__1() { }

	// RVA: 0xF13C54 Offset: 0xF0FC54 VA: 0xF13C54
	internal bool <CheckBagarateMoney>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SafeArea.<>c__DisplayClass11_0 // TypeDefIndex: 2948
{
	// Fields
	public string[] entry; // 0x10
	public SafeArea <>4__this; // 0x18

	// Methods

	// RVA: 0xF12C30 Offset: 0xF0EC30 VA: 0xF12C30
	public void .ctor() { }

	// RVA: 0xF13CA8 Offset: 0xF0FCA8 VA: 0xF13CA8
	internal void <CheckReturnTrainMap>b__0(string npcname, int mapx, int mapy) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SafeArea.<>c__DisplayClass5_0 // TypeDefIndex: 2949
{
	// Fields
	public SafeArea <>4__this; // 0x10
	public long needCount; // 0x18

	// Methods

	// RVA: 0xF112A4 Offset: 0xF0D2A4 VA: 0xF112A4
	public void .ctor() { }

	// RVA: 0xF13CF0 Offset: 0xF0FCF0 VA: 0xF13CF0
	internal void <FirstMoneyCheck>b__0(string npcname, int mapx, int mapy) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SafeArea.<>c__DisplayClass5_1 // TypeDefIndex: 2950
{
	// Fields
	public int delayTimes; // 0x10
	public SafeArea.<>c__DisplayClass5_0 CS$<>8__locals1; // 0x18
	public Func<bool> <>9__2; // 0x20

	// Methods

	// RVA: 0xF13DF0 Offset: 0xF0FDF0 VA: 0xF13DF0
	public void .ctor() { }

	// RVA: 0xF13DF8 Offset: 0xF0FDF8 VA: 0xF13DF8
	internal bool <FirstMoneyCheck>b__1() { }

	// RVA: 0xF13F98 Offset: 0xF0FF98 VA: 0xF13F98
	internal bool <FirstMoneyCheck>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SafeArea.<>c__DisplayClass6_0 // TypeDefIndex: 2951
{
	// Fields
	public SafeArea <>4__this; // 0x10
	public long requestMoneyFromStorage; // 0x18
	public int g; // 0x20
	public int d; // 0x24
	public int p; // 0x28
	public int itemTotal; // 0x2C
	public ShopItem shopitem; // 0x30
	public int potionStackMaximum; // 0x38
	public ShopTypeOne shopTypeOne; // 0x40
	public int shopItemIndex; // 0x48
	public int delayTimes; // 0x4C
	public Func<bool> <>9__4; // 0x50

	// Methods

	// RVA: 0xF12010 Offset: 0xF0E010 VA: 0xF12010
	public void .ctor() { }

	// RVA: 0xF13FEC Offset: 0xF0FFEC VA: 0xF13FEC
	internal void <BuyItem>b__0(string npcname, int mapx, int mapy) { }

	// RVA: 0xF140F4 Offset: 0xF100F4 VA: 0xF140F4
	internal bool <BuyItem>b__1() { }

	// RVA: 0xF1437C Offset: 0xF1037C VA: 0xF1437C
	internal bool <BuyItem>b__4() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SafeArea.<>c__DisplayClass6_1 // TypeDefIndex: 2952
{
	// Fields
	public int delayTimes; // 0x10
	public SafeArea.<>c__DisplayClass6_0 CS$<>8__locals1; // 0x18
	public Func<bool> <>9__3; // 0x20

	// Methods

	// RVA: 0xF140EC Offset: 0xF100EC VA: 0xF140EC
	public void .ctor() { }

	// RVA: 0xF143C8 Offset: 0xF103C8 VA: 0xF143C8
	internal bool <BuyItem>b__2() { }

	// RVA: 0xF14508 Offset: 0xF10508 VA: 0xF14508
	internal bool <BuyItem>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SafeArea.<>c__DisplayClass8_0 // TypeDefIndex: 2953
{
	// Fields
	public Action<string, int, int> onFinish; // 0x10
	public string[] npcNameToFind; // 0x18
	public SafeArea.PrivateClassGotoNpcField targetNpc; // 0x20
	public SafeArea <>4__this; // 0x28

	// Methods

	// RVA: 0xF1208C Offset: 0xF0E08C VA: 0xF1208C
	public void .ctor() { }

	// RVA: 0xF1455C Offset: 0xF1055C VA: 0xF1455C
	internal void <GoToNpc>b__1() { }

	// RVA: 0xF145C0 Offset: 0xF105C0 VA: 0xF145C0
	internal void <GoToNpc>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SafeArea.<>c__DisplayClass8_1 // TypeDefIndex: 2954
{
	// Fields
	public int remainingFreeze; // 0x10

	// Methods

	// RVA: 0xF12094 Offset: 0xF0E094 VA: 0xF12094
	public void .ctor() { }

	// RVA: 0xF1487C Offset: 0xF1087C VA: 0xF1487C
	internal bool <GoToNpc>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SafeArea.<>c__DisplayClass9_0 // TypeDefIndex: 2955
{
	// Fields
	public SafeArea <>4__this; // 0x10
	public string selection; // 0x18
	public int g; // 0x20
	public int d; // 0x24
	public int p; // 0x28
	public int buyRequiredCount; // 0x2C
	public int count; // 0x30
	public int potionStackMaximum; // 0x34
	public Func<bool> <>9__2; // 0x38
	public Action <>9__1; // 0x40

	// Methods

	// RVA: 0xF123C0 Offset: 0xF0E3C0 VA: 0xF123C0
	public void .ctor() { }

	// RVA: 0xF14894 Offset: 0xF10894 VA: 0xF14894
	internal void <CheckBagarateItemQuantities>b__0(string _npcName, int mapX, int mapY) { }

	// RVA: 0xF14964 Offset: 0xF10964 VA: 0xF14964
	internal void <CheckBagarateItemQuantities>b__1() { }

	// RVA: 0xF14A20 Offset: 0xF10A20 VA: 0xF14A20
	internal bool <CheckBagarateItemQuantities>b__2() { }
}

// Namespace: game.ui.autoplay
public class SafeArea // TypeDefIndex: 2956
{
	// Fields
	private readonly Main main; // 0x10
	private bool hasOnceTimeBagarateMoneyChecked; // 0x18
	private bool hasOnceTimeRepairEquippedDurability; // 0x19

	// Methods

	// RVA: 0xF110D0 Offset: 0xF0D0D0 VA: 0xF110D0
	public void .ctor(Main main) { }

	// RVA: 0xF11100 Offset: 0xF0D100 VA: 0xF11100
	public void Release() { }

	// RVA: 0xF11108 Offset: 0xF0D108 VA: 0xF11108
	private bool FirstMoneyCheck() { }

	// RVA: 0xF11AD4 Offset: 0xF0DAD4 VA: 0xF11AD4
	private void BuyItem(int g, int d, int p, ShopTypeOne shopTypeOne, int buyCount, int itemTotal, int potionStackMaximum) { }

	// RVA: 0xF112AC Offset: 0xF0D2AC VA: 0xF112AC
	public bool GoToNpc(string[] npcNameToFind, Action<string, int, int> onFinish) { }

	// RVA: 0xF12250 Offset: 0xF0E250 VA: 0xF12250
	private bool CheckBagarateItemQuantities(int g, int d, int p, string[] npcnames, string selection, int count, int potionStackMaximum) { }

	// RVA: 0xF123C8 Offset: 0xF0E3C8 VA: 0xF123C8
	private bool CheckBagarateMoney() { }

	// RVA: 0xF12580 Offset: 0xF0E580 VA: 0xF12580
	private bool CheckReturnTrainMap() { }

	// RVA: 0xF12CE4 Offset: 0xF0ECE4 VA: 0xF12CE4
	private bool CheckAllEquipmentDurability() { }

	// RVA: 0xF12E4C Offset: 0xF0EE4C VA: 0xF12E4C
	public void Activate() { }

	[CompilerGenerated]
	// RVA: 0xF137F0 Offset: 0xF0F7F0 VA: 0xF137F0
	private void <CheckAllEquipmentDurability>b__12_0(string npcname, int mapx, int mapy) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class SaySelection.<>c__DisplayClass9_0 // TypeDefIndex: 2957
{
	// Fields
	public int remainingFreeze; // 0x10
	public SaySelection <>4__this; // 0x18

	// Methods

	// RVA: 0xF14D18 Offset: 0xF10D18 VA: 0xF14D18
	public void .ctor() { }

	// RVA: 0xF14E08 Offset: 0xF10E08 VA: 0xF14E08
	internal bool <Activate>b__0() { }
}

// Namespace: game.ui.autoplay
public class SaySelection // TypeDefIndex: 2958
{
	// Fields
	private readonly Main main; // 0x10
	private string npcid; // 0x18
	private int itemIndex; // 0x20
	private string[] selectionLiner; // 0x28
	private int selectionIndex; // 0x30
	private bool isSayDialogRequested; // 0x34
	private Action onFinish; // 0x38

	// Methods

	// RVA: 0xF14A78 Offset: 0xF10A78 VA: 0xF14A78
	public void .ctor(Main main) { }

	// RVA: 0xF14AA8 Offset: 0xF10AA8 VA: 0xF14AA8
	public void Release() { }

	// RVA: 0xF14AEC Offset: 0xF10AEC VA: 0xF14AEC
	public bool Activate() { }

	// RVA: 0xF14D20 Offset: 0xF10D20 VA: 0xF14D20
	private void SetSelectionParams(string selection) { }

	// RVA: 0xF13860 Offset: 0xF0F860 VA: 0xF13860
	public void SetNpcSaySel(string npcname, string selection, Action onFinish) { }

	// RVA: 0xF12C38 Offset: 0xF0EC38 VA: 0xF12C38
	public void SetItemSaySel(int g, int d, int p, string selection, Action onFinish) { }
}

// Namespace: game.ui.autoplay
public class Main // TypeDefIndex: 2959
{
	// Fields
	public readonly PlayerMain player; // 0x10
	public readonly Thread thread; // 0x18
	public readonly ThreadAttack threadAttack; // 0x20
	public readonly ThreadMoving threadMoving; // 0x28
	public readonly ThreadRecover threadRecover; // 0x30
	public readonly ThreadSupport threadSupport; // 0x38
	public readonly VongSangLuanChuyen vongSangLuanChuyen; // 0x40
	public readonly Townportal townportal; // 0x48
	public readonly SafeArea safeArea; // 0x50
	public readonly SaySelection saySelection; // 0x58
	public readonly BlockingCommand blockingCommand; // 0x60
	public readonly VatPhamHieuUngFight vatPhamHieuUngFight; // 0x68
	public readonly NgaMyFight ngaMyFight; // 0x70
	public readonly Pickup pickup; // 0x78
	public readonly Team team; // 0x80
	public ProfileData profileCurrently; // 0x88

	// Methods

	// RVA: 0xF14F38 Offset: 0xF10F38 VA: 0xF14F38
	public void .ctor(PlayerMain player) { }

	// RVA: 0xF15728 Offset: 0xF11728 VA: 0xF15728
	public void Initialize() { }

	// RVA: 0xF15784 Offset: 0xF11784 VA: 0xF15784
	public void Release() { }

	// RVA: 0xF15A3C Offset: 0xF11A3C VA: 0xF15A3C
	public void ClearOnFightMode(int freezeTime = 18) { }

	// RVA: 0xF12018 Offset: 0xF0E018 VA: 0xF12018
	public void Talk(string message) { }

	// RVA: 0xF1209C Offset: 0xF0E09C VA: 0xF1209C
	public void Print(string message) { }
}

// Namespace: 
public class ThreadAttack.IgnoreTargetSkill // TypeDefIndex: 2960
{
	// Fields
	public string cid; // 0x10
	public int health; // 0x18
	public int attackTimes; // 0x1C
	public long looptimes; // 0x20

	// Methods

	// RVA: 0xF15C14 Offset: 0xF11C14 VA: 0xF15C14
	public void Clear() { }

	// RVA: 0xF15A84 Offset: 0xF11A84 VA: 0xF15A84
	public void .ctor() { }
}

// Namespace: 
public class ThreadAttack.IgnoreTargetPosition // TypeDefIndex: 2961
{
	// Fields
	public long looptimes; // 0x10

	// Methods

	// RVA: 0xF17AAC Offset: 0xF13AAC VA: 0xF17AAC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ThreadAttack.<>c // TypeDefIndex: 2962
{
	// Fields
	public static readonly ThreadAttack.<>c <>9; // 0x0
	public static Comparison<KeyValuePair<int, Controller>> <>9__22_0; // 0x8

	// Methods

	// RVA: 0xF17AB4 Offset: 0xF13AB4 VA: 0xF17AB4
	private static void .cctor() { }

	// RVA: 0xF17B1C Offset: 0xF13B1C VA: 0xF17B1C
	public void .ctor() { }

	// RVA: 0xF17B24 Offset: 0xF13B24 VA: 0xF17B24
	internal int <FindTarget>b__22_0(KeyValuePair<int, Controller> a, KeyValuePair<int, Controller> b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ThreadAttack.<>c__DisplayClass23_0 // TypeDefIndex: 2963
{
	// Fields
	public Position point; // 0x10
	public ThreadAttack <>4__this; // 0x18

	// Methods

	// RVA: 0xF17864 Offset: 0xF13864 VA: 0xF17864
	public void .ctor() { }

	// RVA: 0xF17B7C Offset: 0xF13B7C VA: 0xF17B7C
	internal void <GotoTargetWithOnRunCheck>b__5() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ThreadAttack.<>c__DisplayClass26_0 // TypeDefIndex: 2964
{
	// Fields
	public ThreadAttack <>4__this; // 0x10
	public FuncSkillSupport.Data support; // 0x18

	// Methods

	// RVA: 0xF17248 Offset: 0xF13248 VA: 0xF17248
	public void .ctor() { }

	// RVA: 0xF17BFC Offset: 0xF13BFC VA: 0xF17BFC
	internal void <CastSkillToSelf>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ThreadAttack.<>c__DisplayClass27_0 // TypeDefIndex: 2965
{
	// Fields
	public ThreadAttack <>4__this; // 0x10
	public FuncSkillSupport.Data support; // 0x18
	public long looptimes; // 0x20

	// Methods

	// RVA: 0xF174D8 Offset: 0xF134D8 VA: 0xF174D8
	public void .ctor() { }

	// RVA: 0xF17C34 Offset: 0xF13C34 VA: 0xF17C34
	internal void <CastSkillToTarget>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ThreadAttack.<>c__DisplayClass27_1 // TypeDefIndex: 2966
{
	// Fields
	public FuncSkillAttack.Data attack; // 0x10
	public ThreadAttack.<>c__DisplayClass27_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xF174E0 Offset: 0xF134E0 VA: 0xF174E0
	public void .ctor() { }

	// RVA: 0xF17C6C Offset: 0xF13C6C VA: 0xF17C6C
	internal void <CastSkillToTarget>b__1() { }
}

// Namespace: game.ui.autoplay
public class ThreadAttack // TypeDefIndex: 2967
{
	// Fields
	private readonly Main main; // 0x10
	private readonly FuncSkillAttack skillAttack; // 0x18
	private readonly FuncSkillSupport skillSupport; // 0x20
	private readonly ThreadAttack.IgnoreTargetSkill ignoreTargetSkill; // 0x28
	private readonly Dictionary<string, ThreadAttack.IgnoreTargetPosition> ignoreTargetPosition; // 0x30
	public long lastFindTargetTime; // 0x38
	private Dictionary<int, bool> ignorePosition; // 0x40
	public Controller target; // 0x48
	public Controller lastTargetController; // 0x50

	// Methods

	// RVA: 0xF15388 Offset: 0xF11388 VA: 0xF15388
	public void .ctor(Main main) { }

	// RVA: 0xF15754 Offset: 0xF11754 VA: 0xF15754
	public void Initialize() { }

	// RVA: 0xF15B94 Offset: 0xF11B94 VA: 0xF15B94
	public void Clear() { }

	// RVA: 0xF15874 Offset: 0xF11874 VA: 0xF15874
	public void Release() { }

	// RVA: 0xF15AB8 Offset: 0xF11AB8 VA: 0xF15AB8
	public void ResetKyNangChinh() { }

	// RVA: 0xF15AE4 Offset: 0xF11AE4 VA: 0xF15AE4
	public void ResetKyNangPhu() { }

	// RVA: 0xF15B10 Offset: 0xF11B10 VA: 0xF15B10
	public void ResetHoTro1() { }

	// RVA: 0xF15B3C Offset: 0xF11B3C VA: 0xF15B3C
	public void ResetHoTro2() { }

	// RVA: 0xF15B68 Offset: 0xF11B68 VA: 0xF15B68
	public void ResetHoTro3() { }

	// RVA: 0xF15C48 Offset: 0xF11C48 VA: 0xF15C48
	public bool CheckOrangeBoss() { }

	// RVA: 0xF16044 Offset: 0xF12044 VA: 0xF16044
	public void CheckTarget() { }

	// RVA: 0xF1615C Offset: 0xF1215C VA: 0xF1615C
	public void FindTarget(long looptimes) { }

	// RVA: 0xF16E84 Offset: 0xF12E84 VA: 0xF16E84
	private bool GotoTargetWithOnRunCheck(int approachRadius) { }

	// RVA: 0xF170BC Offset: 0xF130BC VA: 0xF170BC
	public bool GotoTargetByApproach(long looptimes) { }

	// RVA: 0xF17108 Offset: 0xF13108 VA: 0xF17108
	public bool GotoTargetBySkillRadius(int skillRadius) { }

	// RVA: 0xF17124 Offset: 0xF13124 VA: 0xF17124
	public bool CastSkillToSelf(long looptimes) { }

	// RVA: 0xF17250 Offset: 0xF13250 VA: 0xF17250
	public bool CastSkillToTarget(long looptimes) { }

	// RVA: 0xF174E8 Offset: 0xF134E8 VA: 0xF174E8
	public void CheckIgnoreSkill(long looptimes) { }

	[CompilerGenerated]
	// RVA: 0xF17618 Offset: 0xF13618 VA: 0xF17618
	private void <GotoTargetWithOnRunCheck>b__23_0(int _vectorPathCount) { }

	[CompilerGenerated]
	// RVA: 0xF1786C Offset: 0xF1386C VA: 0xF1786C
	private void <GotoTargetWithOnRunCheck>b__23_2() { }

	[CompilerGenerated]
	// RVA: 0xF178F0 Offset: 0xF138F0 VA: 0xF178F0
	private void <GotoTargetWithOnRunCheck>b__23_3() { }

	[CompilerGenerated]
	// RVA: 0xF17950 Offset: 0xF13950 VA: 0xF17950
	private void <GotoTargetWithOnRunCheck>b__23_4() { }

	[CompilerGenerated]
	// RVA: 0xF179C0 Offset: 0xF139C0 VA: 0xF179C0
	private void <GotoTargetWithOnRunCheck>b__23_1() { }
}

// Namespace: game.ui.autoplay
public class Thread : ThreadUnity // TypeDefIndex: 2968
{
	// Fields
	public const int FPS = 18;
	public const int Tpf = 55;
	public const int DefaultDistanceMaximun = 2048;
	public const int DefaultIgnoreAttackTimes = 10;
	public const int DefaultFollowDistance = 250;
	public readonly Main main; // 0x20
	public long loopTimes; // 0x28
	private long fps1NextTime; // 0x30
	private bool fps1Now; // 0x38
	private long fps6NextTime; // 0x40
	private bool fps6Now; // 0x48
	private bool clearForFightMode; // 0x49
	private int freezeRemaining; // 0x4C

	// Methods

	// RVA: 0xF1533C Offset: 0xF1133C VA: 0xF1533C
	public void .ctor(Main main) { }

	// RVA: 0xF15858 Offset: 0xF11858 VA: 0xF15858
	public void Release() { }

	// RVA: 0xF17D18 Offset: 0xF13D18 VA: 0xF17D18
	private void CalcRoutine(long loopTimes) { }

	// RVA: 0xF17D64 Offset: 0xF13D64 VA: 0xF17D64
	private void ActiveSafeArea(long loopTimes) { }

	// RVA: 0xF18574 Offset: 0xF14574 VA: 0xF18574
	private void ActiveFight(long loopTimes) { }

	// RVA: 0xF15A68 Offset: 0xF11A68 VA: 0xF15A68
	public void ClearForFightMode(int freezeTime) { }

	// RVA: 0xF1942C Offset: 0xF1542C VA: 0xF1942C
	public void Activate(long loopTimes) { }

	[CompilerGenerated]
	// RVA: 0xF195D0 Offset: 0xF155D0 VA: 0xF195D0
	private void <ActiveFight>b__17_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ThreadMoving.<>c__DisplayClass31_0 // TypeDefIndex: 2969
{
	// Fields
	public ThreadMoving <>4__this; // 0x10
	public Position targetPosition; // 0x18
	public Action <>9__1; // 0x20
	public Action <>9__2; // 0x28

	// Methods

	// RVA: 0xF1A31C Offset: 0xF1631C VA: 0xF1A31C
	public void .ctor() { }

	// RVA: 0xF1A464 Offset: 0xF16464 VA: 0xF1A464
	internal void <GotoDymanicActive>b__0() { }

	// RVA: 0xF1A5A8 Offset: 0xF165A8 VA: 0xF1A5A8
	internal void <GotoDymanicActive>b__1() { }

	// RVA: 0xF1A5D8 Offset: 0xF165D8 VA: 0xF1A5D8
	internal void <GotoDymanicActive>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ThreadMoving.<>c__DisplayClass35_0 // TypeDefIndex: 2970
{
	// Fields
	public ThreadMoving <>4__this; // 0x10
	public int targetX; // 0x18
	public int targetY; // 0x1C
	public int approach; // 0x20
	public Action onFinish; // 0x28
	public Action onFailured; // 0x30
	public Action <>9__1; // 0x38
	public Action <>9__2; // 0x40

	// Methods

	// RVA: 0xF1A32C Offset: 0xF1632C VA: 0xF1A32C
	public void .ctor() { }

	// RVA: 0xF1A608 Offset: 0xF16608 VA: 0xF1A608
	internal void <GotoStaticTarget>b__0() { }

	// RVA: 0xF1A744 Offset: 0xF16744 VA: 0xF1A744
	internal void <GotoStaticTarget>b__1() { }

	// RVA: 0xF1A774 Offset: 0xF16774 VA: 0xF1A774
	internal void <GotoStaticTarget>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ThreadMoving.<>c__DisplayClass36_0 // TypeDefIndex: 2971
{
	// Fields
	public ThreadMoving <>4__this; // 0x10
	public Position randomPosition; // 0x18

	// Methods

	// RVA: 0xF1A334 Offset: 0xF16334 VA: 0xF1A334
	public void .ctor() { }

	// RVA: 0xF1A7A4 Offset: 0xF167A4 VA: 0xF1A7A4
	internal void <EscapeArea>b__0() { }
}

// Namespace: game.ui.autoplay
public class ThreadMoving // TypeDefIndex: 2972
{
	// Fields
	private readonly Main main; // 0x10
	private readonly PointRadius pointRadiusRenderer; // 0x18
	public int pointRadius; // 0x20
	public Position followPosition; // 0x28
	private long randomposition_attackLastFindTime; // 0x30
	public bool gotoStaticTargetIsRunning; // 0x38
	public bool gotoDynamicTargetIsRunning; // 0x39
	public Controller gotoDynamicFindTargetFunc; // 0x40
	private Action gotoDynamicOnFinish; // 0x48
	private Action gotoDynamicOnRun; // 0x50
	private Action gotoDynamicOnFailured; // 0x58
	public int gotoDynamicApproach; // 0x60
	private int gotoDynamicRemainingFreeze; // 0x64
	public Position gotoDynamicPreviousTargetPosition; // 0x68
	private Dictionary<int, bool> followIgnorePosition; // 0x70
	private Dictionary<int, bool> escapeIgnorePosition; // 0x78
	public ushort listingPositionIndex; // 0x80

	// Methods

	// RVA: 0xF154FC Offset: 0xF114FC VA: 0xF154FC
	public void .ctor(Main main) { }

	// RVA: 0xF19614 Offset: 0xF15614 VA: 0xF19614
	private void ReleasePoint() { }

	// RVA: 0xF15918 Offset: 0xF11918 VA: 0xF15918
	public void Release() { }

	// RVA: 0xF1856C Offset: 0xF1456C VA: 0xF1856C
	public void ClearForJoystick() { }

	// RVA: 0xF195CC Offset: 0xF155CC VA: 0xF195CC
	public void ClearForTownportal() { }

	// RVA: 0xF196C4 Offset: 0xF156C4 VA: 0xF196C4
	private bool Follow() { }

	// RVA: 0xF19878 Offset: 0xF15878 VA: 0xF19878
	private bool Point() { }

	// RVA: 0xF19C0C Offset: 0xF15C0C VA: 0xF19C0C
	private bool RandomPosition() { }

	// RVA: 0xF19D90 Offset: 0xF15D90 VA: 0xF19D90
	private bool ListingPositionFightGotoNextPoint() { }

	// RVA: 0xF19F1C Offset: 0xF15F1C VA: 0xF19F1C
	private bool ListingPositionFight() { }

	// RVA: 0xF1A054 Offset: 0xF16054 VA: 0xF1A054
	private bool MixFollowAndPositionList() { }

	// RVA: 0xF178E8 Offset: 0xF138E8 VA: 0xF178E8
	public void GotoDynamicStop() { }

	// RVA: 0xF1703C Offset: 0xF1303C VA: 0xF1703C
	public void GotoDymanicTarget(Controller findTarget, int approach, Action onFinish, Action onFailured) { }

	// RVA: 0xF1A1A0 Offset: 0xF161A0 VA: 0xF1A1A0
	public void GotoDynamicTargetSetOnRun(Action onRun) { }

	// RVA: 0xF1A1A8 Offset: 0xF161A8 VA: 0xF1A1A8
	private bool GotoDymanicActive() { }

	// RVA: 0xF1850C Offset: 0xF1450C VA: 0xF1850C
	public bool ActivateSafeArea() { }

	// RVA: 0xF19344 Offset: 0xF15344 VA: 0xF19344
	public bool ActivateFight() { }

	// RVA: 0xF1A324 Offset: 0xF16324 VA: 0xF1A324
	public void GotoStaticStop() { }

	// RVA: 0xF120A8 Offset: 0xF0E0A8 VA: 0xF120A8
	public void GotoStaticTarget(int targetX, int targetY, int approach, Action onFinish, Action onFailured) { }

	// RVA: 0xF146BC Offset: 0xF106BC VA: 0xF146BC
	public void EscapeArea(int radius = 250, Action onFinish) { }

	[CompilerGenerated]
	// RVA: 0xF1A33C Offset: 0xF1633C VA: 0xF1A33C
	private void <Point>b__23_0() { }

	[CompilerGenerated]
	// RVA: 0xF1A3D0 Offset: 0xF163D0 VA: 0xF1A3D0
	private void <RandomPosition>b__24_0() { }

	[CompilerGenerated]
	// RVA: 0xF1A3DC Offset: 0xF163DC VA: 0xF1A3DC
	private void <ListingPositionFightGotoNextPoint>b__25_0() { }

	[CompilerGenerated]
	// RVA: 0xF1A458 Offset: 0xF16458 VA: 0xF1A458
	private void <ListingPositionFightGotoNextPoint>b__25_1() { }
}

// Namespace: game.ui.autoplay
public class ThreadRecover // TypeDefIndex: 2973
{
	// Fields
	private readonly Main main; // 0x10
	private long nextHealthLevel1; // 0x18
	private long nextHealthLevel2; // 0x20
	private long nextManaLevel1; // 0x28
	private long nextManaLevel2; // 0x30

	// Methods

	// RVA: 0xF1558C Offset: 0xF1158C VA: 0xF1558C
	public void .ctor(Main main) { }

	// RVA: 0xF159B8 Offset: 0xF119B8 VA: 0xF159B8
	public void Release() { }

	// RVA: 0xF1A870 Offset: 0xF16870 VA: 0xF1A870
	private void UseHealthItem() { }

	// RVA: 0xF1AAB0 Offset: 0xF16AB0 VA: 0xF1AAB0
	private void UseManaItem() { }

	// RVA: 0xF1ACF0 Offset: 0xF16CF0 VA: 0xF1ACF0
	private void HealthLevel1(long looptimes) { }

	// RVA: 0xF1ADAC Offset: 0xF16DAC VA: 0xF1ADAC
	private void HealthLevel2(long looptimes) { }

	// RVA: 0xF1AE68 Offset: 0xF16E68 VA: 0xF1AE68
	private void ManaLevel1(long looptimes) { }

	// RVA: 0xF1AF24 Offset: 0xF16F24 VA: 0xF1AF24
	private void ManaLevel2(long looptimes) { }

	// RVA: 0xF17F6C Offset: 0xF13F6C VA: 0xF17F6C
	public void CheckRecover(long looptimes) { }
}

// Namespace: game.ui.autoplay
public class ThreadSupport // TypeDefIndex: 2974
{
	// Fields
	private readonly Main main; // 0x10
	private long chatNextRaoPhuCan; // 0x18
	private long chatNextRaoTheGioi; // 0x20
	private long chatNextRaoThanhThi; // 0x28

	// Methods

	// RVA: 0xF155BC Offset: 0xF115BC VA: 0xF155BC
	public void .ctor(Main main) { }

	// RVA: 0xF159C8 Offset: 0xF119C8 VA: 0xF159C8
	public void Release() { }

	// RVA: 0xF18044 Offset: 0xF14044 VA: 0xF18044
	public void CheckChat(long looptimes) { }
}

// Namespace: game.ui.autoplay
public class Team // TypeDefIndex: 2975
{
	// Fields
	private readonly Main main; // 0x10
	private readonly Dictionary<string, long> partySentNextTime; // 0x18

	// Methods

	// RVA: 0xF1568C Offset: 0xF1168C VA: 0xF1568C
	public void .ctor(Main main) { }

	// RVA: 0xF159EC Offset: 0xF119EC VA: 0xF159EC
	public void Release() { }

	// RVA: 0xF1AFE0 Offset: 0xF16FE0 VA: 0xF1AFE0
	private void OtherTeamAll() { }

	// RVA: 0xF1B9C4 Offset: 0xF179C4 VA: 0xF1B9C4
	private void OtherTeamListing() { }

	// RVA: 0xF1BE8C Offset: 0xF17E8C VA: 0xF1BE8C
	private void OtherTeam() { }

	// RVA: 0xF1B3EC Offset: 0xF173EC VA: 0xF1B3EC
	private void MyTeamAll() { }

	// RVA: 0xF1BEC4 Offset: 0xF17EC4 VA: 0xF1BEC4
	private void MyTeamListing() { }

	// RVA: 0xF1C2DC Offset: 0xF182DC VA: 0xF1C2DC
	private void MyTeam() { }

	// RVA: 0xF192FC Offset: 0xF152FC VA: 0xF192FC
	public void Activate() { }
}

// Namespace: game.ui.autoplay
public class Townportal // TypeDefIndex: 2976
{
	// Fields
	private readonly Main main; // 0x10
	private int rank1RemainingTime; // 0x18
	private int rank2RemainingTime; // 0x1C
	private int rank3RemainingTime; // 0x20
	private int rank4RemainingTime; // 0x24

	// Methods

	// RVA: 0xF1562C Offset: 0xF1162C VA: 0xF1562C
	public void .ctor(Main main) { }

	// RVA: 0xF189AC Offset: 0xF149AC VA: 0xF189AC
	public void Activate() { }
}

// Namespace: game.ui.autoplay
public class VatPhamHieuUngFight // TypeDefIndex: 2977
{
	// Fields
	private readonly Main main; // 0x10
	private int remainingFreezeTienThaoLo; // 0x18
	private int remainingFreezeThienSonBaoLo; // 0x1C
	private int remainingFreezeQueHoaTuu; // 0x20

	// Methods

	// RVA: 0xF1565C Offset: 0xF1165C VA: 0xF1565C
	public void .ctor(Main main) { }

	// RVA: 0xF159E0 Offset: 0xF119E0 VA: 0xF159E0
	public void Release() { }

	// RVA: 0xF18F10 Offset: 0xF14F10 VA: 0xF18F10
	public void Activate(long looptime) { }
}

// Namespace: game.ui.autoplay
public class VongSangLuanChuyen // TypeDefIndex: 2978
{
	// Fields
	private readonly Main main; // 0x10
	private int remaningTime; // 0x18
	private bool isStarted; // 0x1C

	// Methods

	// RVA: 0xF155FC Offset: 0xF115FC VA: 0xF155FC
	public void .ctor(Main main) { }

	// RVA: 0xF18430 Offset: 0xF14430 VA: 0xF18430
	public void Activate(long looptime) { }

	// RVA: 0xF159DC Offset: 0xF119DC VA: 0xF159DC
	public void Release() { }
}

// Namespace: game.ui.autoplay
public class MainUnity : Main // TypeDefIndex: 2979
{
	// Fields
	private bool hasInitialized; // 0x90
	public Dictionary<string, ProfileData> profileMapping; // 0x98

	// Methods

	// RVA: 0xF1C438 Offset: 0xF18438 VA: 0xF1C438
	public void .ctor(PlayerMain player) { }

	// RVA: 0xF1C43C Offset: 0xF1843C VA: 0xF1C43C
	public void InitializeForNull() { }

	// RVA: 0xF1C4CC Offset: 0xF184CC VA: 0xF1C4CC
	public void InitializeForce(bool createProfileWhenEmpty) { }

	// RVA: 0xF1C4D4 Offset: 0xF184D4 VA: 0xF1C4D4
	public bool Initialize(bool createProfileWhenEmpty) { }

	// RVA: 0xF1D780 Offset: 0xF19780 VA: 0xF1D780
	public void Release() { }

	// RVA: 0xF1D80C Offset: 0xF1980C VA: 0xF1D80C
	public void ResetWeaponType(bool isRangeWeapon) { }

	// RVA: 0xF1D6DC Offset: 0xF196DC VA: 0xF1D6DC
	public void SetDefaultProfile(string guid) { }

	// RVA: 0xF1D914 Offset: 0xF19914 VA: 0xF1D914
	public void NewProfile(ProfileData profile) { }

	// RVA: 0xF1D97C Offset: 0xF1997C VA: 0xF1D97C
	public void SaveProfile(ProfileData profile) { }

	// RVA: 0xF1DA6C Offset: 0xF19A6C VA: 0xF1DA6C
	public void DeleteProfile(string guid) { }

	// RVA: 0xF1DC30 Offset: 0xF19C30 VA: 0xF1DC30
	public ProfileData GetProfile(string guid) { }

	// RVA: 0xF1DCA8 Offset: 0xF19CA8 VA: 0xF1DCA8
	private void ResetMovingPoint() { }

	// RVA: 0xF1DD5C Offset: 0xF19D5C VA: 0xF1DD5C
	public bool Start(bool resetMovingPoint = True) { }

	// RVA: 0xF1D8F4 Offset: 0xF198F4 VA: 0xF1D8F4
	public bool IsRunning() { }

	// RVA: 0xF1DF8C Offset: 0xF19F8C VA: 0xF1DF8C
	public void Stop() { }

	// RVA: 0xF1E070 Offset: 0xF1A070 VA: 0xF1E070
	public bool Switch() { }
}

// Namespace: game.ui.autoplay
public class ProfileLinker : ProfileBase // TypeDefIndex: 2980
{
	// Methods

	// RVA: 0xF11074 Offset: 0xF0D074 VA: 0xF11074
	public void .ctor() { }
}

// Namespace: game.ui.autoplay
public class ThreadUnity // TypeDefIndex: 2981
{
	// Fields
	private readonly Main main; // 0x10
	private Thread handle; // 0x18

	// Methods

	// RVA: 0xF17CE8 Offset: 0xF13CE8 VA: 0xF17CE8
	public void .ctor(Main main) { }

	// RVA: 0xF1E0A8 Offset: 0xF1A0A8 VA: 0xF1E0A8
	private void Main() { }

	// RVA: 0xF1DE90 Offset: 0xF19E90 VA: 0xF1DE90
	public void Start() { }

	// RVA: 0xF1DFA0 Offset: 0xF19FA0 VA: 0xF1DFA0
	public void Stop() { }

	// RVA: 0xF1DF7C Offset: 0xF19F7C VA: 0xF1DF7C
	public bool IsRunning() { }
}

// Namespace: game.ui.autoplay
public static class Creator // TypeDefIndex: 2982
{
	// Methods

	// RVA: 0xF1E218 Offset: 0xF1A218 VA: 0xF1E218
	public static ProfileData CreateNew(string name) { }

	// RVA: 0xF1CB84 Offset: 0xF18B84 VA: 0xF1CB84
	public static ProfileData CreateTrainProfile() { }

	// RVA: 0xF1D08C Offset: 0xF1908C VA: 0xF1D08C
	public static ProfileData CreatePkProfile() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FuncSkillList.<>c // TypeDefIndex: 2983
{
	// Fields
	public static readonly FuncSkillList.<>c <>9; // 0x0
	public static Comparison<Skill> <>9__0_0; // 0x8
	public static Comparison<Skill> <>9__1_0; // 0x10
	public static Comparison<Skill> <>9__2_0; // 0x18
	public static Comparison<Skill> <>9__3_0; // 0x20
	public static Comparison<Skill> <>9__4_0; // 0x28

	// Methods

	// RVA: 0xF1F7DC Offset: 0xF1B7DC VA: 0xF1F7DC
	private static void .cctor() { }

	// RVA: 0xF1F844 Offset: 0xF1B844 VA: 0xF1F844
	public void .ctor() { }

	// RVA: 0xF1F84C Offset: 0xF1B84C VA: 0xF1F84C
	internal int <GetSkillAttackType>b__0_0(Skill a, Skill b) { }

	// RVA: 0xF1F874 Offset: 0xF1B874 VA: 0xF1F874
	internal int <GetSkillSpellType>b__1_0(Skill a, Skill b) { }

	// RVA: 0xF1F89C Offset: 0xF1B89C VA: 0xF1F89C
	internal int <GetSkillBuffSelfStateType>b__2_0(Skill a, Skill b) { }

	// RVA: 0xF1F8C4 Offset: 0xF1B8C4 VA: 0xF1F8C4
	internal int <GetSkillSupportType>b__3_0(Skill a, Skill b) { }

	// RVA: 0xF1F8EC Offset: 0xF1B8EC VA: 0xF1F8EC
	internal int <GetSkillAuraType>b__4_0(Skill a, Skill b) { }
}

// Namespace: game.ui.autoplay
public static class FuncSkillList // TypeDefIndex: 2984
{
	// Methods

	// RVA: 0xF1E250 Offset: 0xF1A250 VA: 0xF1E250
	public static List<Skill> GetSkillAttackType() { }

	// RVA: 0xF1ECB4 Offset: 0xF1ACB4 VA: 0xF1ECB4
	public static List<Skill> GetSkillSpellType() { }

	// RVA: 0xF1E780 Offset: 0xF1A780 VA: 0xF1E780
	public static List<Skill> GetSkillBuffSelfStateType() { }

	// RVA: 0xF1F1DC Offset: 0xF1B1DC VA: 0xF1F1DC
	public static List<Skill> GetSkillSupportType() { }

	// RVA: 0xF1F358 Offset: 0xF1B358 VA: 0xF1F358
	public static List<Skill> GetSkillAuraType() { }
}

// Namespace: game.ui.autoplay
public static class Storage // TypeDefIndex: 2985
{
	// Fields
	[CompilerGenerated]
	private static int <ProfileCount>k__BackingField; // 0x0

	// Properties
	public static int ProfileCount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xF1F914 Offset: 0xF1B914 VA: 0xF1F914
	public static int get_ProfileCount() { }

	[CompilerGenerated]
	// RVA: 0xF1F95C Offset: 0xF1B95C VA: 0xF1F95C
	private static void set_ProfileCount(int value) { }

	// RVA: 0xF1F9A8 Offset: 0xF1B9A8 VA: 0xF1F9A8
	public static string GetDirectoryPath() { }

	// RVA: 0xF1D570 Offset: 0xF19570 VA: 0xF1D570
	public static void SaveProfile(ProfileData profile) { }

	// RVA: 0xF1FA5C Offset: 0xF1BA5C VA: 0xF1FA5C
	public static ProfileData GetProfileWithFullPath(string fullpath) { }

	// RVA: 0xF1DAFC Offset: 0xF19AFC VA: 0xF1DAFC
	public static void DeleteProfile(string guid) { }

	// RVA: 0xF1C798 Offset: 0xF18798 VA: 0xF1C798
	public static Dictionary<string, ProfileData> GetAllProfiles(string playerCid) { }

	// RVA: 0xF1FB24 Offset: 0xF1BB24 VA: 0xF1FB24
	public static void RemoveAllOtherProfiles(string cidSelf) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PointRadius.<>c__DisplayClass2_0 // TypeDefIndex: 2986
{
	// Fields
	public PointRadius <>4__this; // 0x10
	public Vector3 vector; // 0x18
	public float radius; // 0x24
	public Main main; // 0x28

	// Methods

	// RVA: 0xF1FD90 Offset: 0xF1BD90 VA: 0xF1FD90
	public void .ctor() { }

	// RVA: 0xF1FE24 Offset: 0xF1BE24 VA: 0xF1FE24
	internal void <AnchoragePoint>b__0() { }
}
