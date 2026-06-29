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

// Namespace: game.scene.login
public class AccountLoginPopup : BaseMonoBehaviour // TypeDefIndex: 3013
{
	// Fields
	[SerializeField]
	private GameObject homeGo; // 0x20
	[SerializeField]
	private LoginManger loginManagerScript; // 0x28
	[SerializeField]
	private GameObject groupAccountButtonGO; // 0x30
	[SerializeField]
	private TMP_InputField tmpInputAccount; // 0x38
	[SerializeField]
	private TMP_InputField tmpInputPassword; // 0x40
	[SerializeField]
	private Button buttonLoginButton; // 0x48
	[SerializeField]
	private Button buttonBackButton; // 0x50

	// Methods

	// RVA: 0xF2D67C Offset: 0xF2967C VA: 0xF2D67C
	private void Start() { }

	// RVA: 0xF2D77C Offset: 0xF2977C VA: 0xF2D77C
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xF2DA88 Offset: 0xF29A88 VA: 0xF2DA88
	private void OnClickBackButton() { }

	// RVA: 0xF2DB20 Offset: 0xF29B20 VA: 0xF2DB20
	public void LoggedAccountListingSelected(string account, string password) { }

	// RVA: 0xF2E178 Offset: 0xF2A178 VA: 0xF2E178
	public void OnClickLoginButton(string inputAccount, string inputPassword) { }

	// RVA: 0xF2E708 Offset: 0xF2A708 VA: 0xF2E708
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF2E710 Offset: 0xF2A710 VA: 0xF2E710
	private void <Start>b__7_0() { }
}

// Namespace: 
public class LoginManger.ServerFramedTemplate // TypeDefIndex: 3014
{
	// Fields
	public GameObject go; // 0x10
	public TextMeshProUGUI textmeshRegionName; // 0x18
	public TextMeshProUGUI textmeshServerName; // 0x20
	public Button buttonChangeServer; // 0x28
	public TextMeshProUGUI textmeshChangeServer; // 0x30

	// Methods

	// RVA: 0xF520A8 Offset: 0xF4E0A8 VA: 0xF520A8
	public void .ctor(GameObject go) { }
}

// Namespace: 
public class LoginManger.OpenConnection // TypeDefIndex: 3015
{
	// Fields
	public string serverName; // 0x10
	public Action<int> action; // 0x18
	public Action onStart; // 0x20
	public Action onStop; // 0x28
	public int hiddenToRetryTimes; // 0x30
	public int totalTryTimes; // 0x34
	public int totalSecondsInSession; // 0x38
	public int currentTryTimes; // 0x3C
	public float currentSessionLeftTimne; // 0x40

	// Methods

	// RVA: 0xF522FC Offset: 0xF4E2FC VA: 0xF522FC
	public void .ctor() { }
}

// Namespace: 
private class LoginManger.LoggedAccountData // TypeDefIndex: 3016
{
	// Fields
	public string account; // 0x10
	public string password; // 0x18
	public bool isCurrently; // 0x20
	public GameObject fieldGo; // 0x28

	// Methods

	// RVA: 0xF52330 Offset: 0xF4E330 VA: 0xF52330
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LoginManger.<>c // TypeDefIndex: 3017
{
	// Fields
	public static readonly LoginManger.<>c <>9; // 0x0
	public static UnityAction <>9__75_0; // 0x8
	public static Action <>9__87_0; // 0x10
	public static Action <>9__87_1; // 0x18
	public static Action <>9__88_0; // 0x20
	public static Action <>9__88_1; // 0x28

	// Methods

	// RVA: 0xF52338 Offset: 0xF4E338 VA: 0xF52338
	private static void .cctor() { }

	// RVA: 0xF523A0 Offset: 0xF4E3A0 VA: 0xF523A0
	public void .ctor() { }

	// RVA: 0xF523A8 Offset: 0xF4E3A8 VA: 0xF523A8
	internal void <LoggedAccountListingAssignField>b__75_0() { }

	// RVA: 0xF5240C Offset: 0xF4E40C VA: 0xF5240C
	internal void <OpenNotifi>b__87_0() { }

	// RVA: 0xF52410 Offset: 0xF4E410 VA: 0xF52410
	internal void <OpenNotifi>b__87_1() { }

	// RVA: 0xF52414 Offset: 0xF4E414 VA: 0xF52414
	internal void <OpenPolicy>b__88_0() { }

	// RVA: 0xF52418 Offset: 0xF4E418 VA: 0xF52418
	internal void <OpenPolicy>b__88_1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LoginManger.<>c__DisplayClass75_0 // TypeDefIndex: 3018
{
	// Fields
	public LoginManger <>4__this; // 0x10
	public LoginManger.LoggedAccountData entry; // 0x18

	// Methods

	// RVA: 0xF5241C Offset: 0xF4E41C VA: 0xF5241C
	public void .ctor() { }

	// RVA: 0xF52424 Offset: 0xF4E424 VA: 0xF52424
	internal void <LoggedAccountListingAssignField>b__1() { }

	// RVA: 0xF524D0 Offset: 0xF4E4D0 VA: 0xF524D0
	internal void <LoggedAccountListingAssignField>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LoginManger.<>c__DisplayClass83_0 // TypeDefIndex: 3019
{
	// Fields
	public LoginManger <>4__this; // 0x10
	public bool configRequiringPhone; // 0x18
	public bool configRequiringBirthday; // 0x19
	public bool configRequiringLegalName; // 0x1A
	public Action<string> actionOpenRegisterForm; // 0x20
	public bool configRequiringPhoneCache; // 0x28
	public Action actionOpenAccountHome; // 0x30
	public bool configRequiringTerms; // 0x38
	public Action actionPhoneConfirm; // 0x40
	public Action <>9__5; // 0x48
	public Action<string> <>9__13; // 0x50
	public Action <>9__11; // 0x58
	public Action<string> <>9__9; // 0x60
	public Action<string> <>9__6; // 0x68
	public Action <>9__7; // 0x70
	public Action <>9__14; // 0x78
	public Action <>9__15; // 0x80

	// Methods

	// RVA: 0xF52564 Offset: 0xF4E564 VA: 0xF52564
	public void .ctor() { }

	// RVA: 0xF5256C Offset: 0xF4E56C VA: 0xF5256C
	internal void <RegisterStart>b__5() { }

	// RVA: 0xF52584 Offset: 0xF4E584 VA: 0xF52584
	internal void <RegisterStart>b__0() { }

	// RVA: 0xF5259C Offset: 0xF4E59C VA: 0xF5259C
	internal void <RegisterStart>b__1() { }

	// RVA: 0xF525E4 Offset: 0xF4E5E4 VA: 0xF525E4
	internal void <RegisterStart>b__2(string phonenum) { }

	// RVA: 0xF526A4 Offset: 0xF4E6A4 VA: 0xF526A4
	internal void <RegisterStart>b__3() { }

	// RVA: 0xF52848 Offset: 0xF4E848 VA: 0xF52848
	internal void <RegisterStart>b__6(string phone) { }

	// RVA: 0xF52BBC Offset: 0xF4EBBC VA: 0xF52BBC
	internal void <RegisterStart>b__13(string _message) { }

	// RVA: 0xF52C7C Offset: 0xF4EC7C VA: 0xF52C7C
	internal void <RegisterStart>b__11() { }

	// RVA: 0xF52CFC Offset: 0xF4ECFC VA: 0xF52CFC
	internal void <RegisterStart>b__9(string _message) { }

	// RVA: 0xF52D60 Offset: 0xF4ED60 VA: 0xF52D60
	internal void <RegisterStart>b__7() { }

	// RVA: 0xF52DE0 Offset: 0xF4EDE0 VA: 0xF52DE0
	internal void <RegisterStart>b__4() { }

	// RVA: 0xF5303C Offset: 0xF4F03C VA: 0xF5303C
	internal void <RegisterStart>b__14() { }

	// RVA: 0xF5305C Offset: 0xF4F05C VA: 0xF5305C
	internal void <RegisterStart>b__15() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LoginManger.<>c__DisplayClass83_1 // TypeDefIndex: 3020
{
	// Fields
	public string phone; // 0x10
	public LoginManger.<>c__DisplayClass83_0 CS$<>8__locals1; // 0x18
	public Action <>9__12; // 0x20
	public Action<string> <>9__10; // 0x28

	// Methods

	// RVA: 0xF52B94 Offset: 0xF4EB94 VA: 0xF52B94
	public void .ctor() { }

	// RVA: 0xF5307C Offset: 0xF4F07C VA: 0xF5307C
	internal void <RegisterStart>b__8() { }

	// RVA: 0xF532D0 Offset: 0xF4F2D0 VA: 0xF532D0
	internal void <RegisterStart>b__10(string otp) { }

	// RVA: 0xF53400 Offset: 0xF4F400 VA: 0xF53400
	internal void <RegisterStart>b__12() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LoginManger.<>c__DisplayClass90_0 // TypeDefIndex: 3021
{
	// Fields
	public LoginManger <>4__this; // 0x10
	public string userName; // 0x18
	public string userpassword; // 0x20
	public Action <>9__4; // 0x28
	public Action<NetCoreManager, NetCoreManager.MessageData> <>9__3; // 0x30
	public Action<NetCoreManager, NetCoreManager.MessageData> <>9__2; // 0x38
	public Action<NetCoreManager, NetCoreManager.MessageData> <>9__1; // 0x40

	// Methods

	// RVA: 0xF53540 Offset: 0xF4F540 VA: 0xF53540
	public void .ctor() { }

	// RVA: 0xF53548 Offset: 0xF4F548 VA: 0xF53548
	internal void <OpenGame>b__0(int _actionCalledTimes) { }

	// RVA: 0xF536A0 Offset: 0xF4F6A0 VA: 0xF536A0
	internal void <OpenGame>b__1(NetCoreManager net, NetCoreManager.MessageData message) { }

	// RVA: 0xF539B0 Offset: 0xF4F9B0 VA: 0xF539B0
	internal void <OpenGame>b__2(NetCoreManager net, NetCoreManager.MessageData message2) { }

	// RVA: 0xF53C9C Offset: 0xF4FC9C VA: 0xF53C9C
	internal void <OpenGame>b__3(NetCoreManager net, NetCoreManager.MessageData message3) { }

	// RVA: 0xF54370 Offset: 0xF50370 VA: 0xF54370
	internal void <OpenGame>b__4() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LoginManger.<>c__DisplayClass90_1 // TypeDefIndex: 3022
{
	// Fields
	public string appstoreLink; // 0x10

	// Methods

	// RVA: 0xF54368 Offset: 0xF50368 VA: 0xF54368
	public void .ctor() { }

	// RVA: 0xF54420 Offset: 0xF50420 VA: 0xF54420
	internal void <OpenGame>b__5() { }
}

// Namespace: game.scene.login
public class LoginManger : BaseMonoBehaviour // TypeDefIndex: 3023
{
	// Fields
	[SerializeField]
	private List<Image> imageList; // 0x20
	[SerializeField]
	private List<TextMeshProUGUI> tmpList; // 0x28
	[SerializeField]
	private GameObject homeGo; // 0x30
	[SerializeField]
	private AccountLoginPopup loginForm; // 0x38
	[SerializeField]
	private TextMeshProUGUI loginFormServerNameTmp; // 0x40
	[SerializeField]
	private Button loginFormServerNameButton; // 0x48
	[SerializeField]
	private RegisterController registerForm; // 0x50
	[SerializeField]
	private TextMeshProUGUI registerFormServerNameTmp; // 0x58
	[SerializeField]
	private Button registerFormServerNameButton; // 0x60
	[SerializeField]
	private GameObject pannelButton; // 0x68
	[SerializeField]
	private GameObject panelUI; // 0x70
	[SerializeField]
	private RegionServerList ServerList; // 0x78
	[SerializeField]
	private Button buttonLogout; // 0x80
	[SerializeField]
	private Button buttonPolicy; // 0x88
	[SerializeField]
	private Button buttonNotify; // 0x90
	[SerializeField]
	private Button buttonUpdateResource; // 0x98
	[SerializeField]
	private Button buttonEntergame; // 0xA0
	[SerializeField]
	private Button logo18Button; // 0xA8
	[SerializeField]
	private Image logo18Framed; // 0xB0
	[SerializeField]
	private Button logo18FramedButton; // 0xB8
	[SerializeField]
	private TextMeshProUGUI logo18textmesh; // 0xC0
	[SerializeField]
	private TextMeshProUGUI logo18Content; // 0xC8
	[SerializeField]
	private Toggle togglePolicy; // 0xD0
	[SerializeField]
	private Button policyOnAgreeButton; // 0xD8
	[SerializeField]
	private GameObject loadingLayer; // 0xE0
	[SerializeField]
	private Image loadingFramed; // 0xE8
	[SerializeField]
	private TextMeshProUGUI loadingLabel; // 0xF0
	[SerializeField]
	private GameObject ServerFramed; // 0xF8
	[SerializeField]
	private Image imageUpdateRes; // 0x100
	[SerializeField]
	private Image imageEntergame; // 0x108
	[SerializeField]
	private TextMeshProUGUI labelTextmeshLogout; // 0x110
	[SerializeField]
	private TextMeshProUGUI labelTextmeshPolicy; // 0x118
	[SerializeField]
	private TextMeshProUGUI labelTextmeshNotify; // 0x120
	[SerializeField]
	private TextMeshProUGUI labelTextmeshAgreePolicyReaded; // 0x128
	[SerializeField]
	private TextMeshProUGUI labelTextmeshAgreePolicyName; // 0x130
	[SerializeField]
	private TextMeshProUGUI labelTextmeshUpdateResource; // 0x138
	[SerializeField]
	private TextMeshProUGUI labelTextmeshEntergame; // 0x140
	[SerializeField]
	private GameObject connectingLayer; // 0x148
	[SerializeField]
	private TextMeshProUGUI connectingText; // 0x150
	[SerializeField]
	private Button connectingCloseButton; // 0x158
	[SerializeField]
	private Image accountButtonLoginImage; // 0x160
	[SerializeField]
	private Image accountButtonRegisterImage; // 0x168
	[SerializeField]
	private Image accountButtonBackImage; // 0x170
	[SerializeField]
	private Button accountButtonLoginButton; // 0x178
	[SerializeField]
	private Button accountButtonRegisterButton; // 0x180
	[SerializeField]
	private Button accountButtonBackButton; // 0x188
	[SerializeField]
	private Image accountButtonChangeServerImage; // 0x190
	[SerializeField]
	private LoginTermsAndNews termsAndNews; // 0x198
	[SerializeField]
	private RegisterEnterPhone registerEnterPhone; // 0x1A0
	[SerializeField]
	private RegisterEnterOtp registerEnterOtp; // 0x1A8
	[SerializeField]
	private GameObject accountListingContentGo; // 0x1B0
	[SerializeField]
	private GameObject accountListingTemplateGo; // 0x1B8
	private LoginManger.ServerFramedTemplate serverFramedTemplate; // 0x1C0
	private Queue<Action> performInMainThread; // 0x1C8
	private Sprite entergameBackgroundSprite; // 0x1D0
	private LoginManger.OpenConnection openConnection; // 0x1D8
	private MSUnityRegisterFields registerConfigFields; // 0x1E0
	private Dictionary<string, bool> registerPhoneConfirmed; // 0x1E8
	private bool loginQueueWaiting; // 0x1F0
	private string loginQueueMessage; // 0x1F8
	private float loginQueueTime; // 0x200
	private Action connectingCloseButtonAction; // 0x208
	private readonly List<LoginManger.LoggedAccountData> loggedAccountListing; // 0x210
	public static string loggedAccountCurrentlyUser; // 0x0
	public static string loggedAccountCurrentlyPass; // 0x8

	// Methods

	// RVA: 0xF2EEC8 Offset: 0xF2AEC8 VA: 0xF2EEC8
	private void Start() { }

	// RVA: 0xF30814 Offset: 0xF2C814 VA: 0xF30814
	private void Update() { }

	// RVA: 0xF30D74 Offset: 0xF2CD74 VA: 0xF30D74
	private void OnDestroy() { }

	// RVA: 0xF30E28 Offset: 0xF2CE28 VA: 0xF30E28
	private void SetLoginQueueMessage(bool active, string message, Action onclose) { }

	// RVA: 0xF30CB0 Offset: 0xF2CCB0 VA: 0xF30CB0
	private void SetConnectingMessage(string message, Action onclose) { }

	// RVA: 0xF2E5C4 Offset: 0xF2A5C4 VA: 0xF2E5C4
	public void StartConnection(int totalTryTimes, int totalSecondsInSession, Action<int> action, Action onstart, Action onstop, int hiddenToRetryTimes = 0) { }

	// RVA: 0xF2EDFC Offset: 0xF2ADFC VA: 0xF2EDFC
	public void StopConnection() { }

	// RVA: 0xF30E84 Offset: 0xF2CE84 VA: 0xF30E84
	private void LoggedAccountListingAssignField(LoginManger.LoggedAccountData entry) { }

	// RVA: 0xF2DB48 Offset: 0xF29B48 VA: 0xF2DB48
	public void LoggedAccountListingAdd(string account, string password) { }

	// RVA: 0xF312C8 Offset: 0xF2D2C8 VA: 0xF312C8
	private void LoggedAccountListingRemove(string account) { }

	// RVA: 0xF3032C Offset: 0xF2C32C VA: 0xF3032C
	private void LoggedAccountListingLoad() { }

	// RVA: 0xF2DF18 Offset: 0xF29F18 VA: 0xF2DF18
	public void LoggedAccountListingSave() { }

	// RVA: 0xF31798 Offset: 0xF2D798 VA: 0xF31798
	public void Perform(Action action) { }

	// RVA: 0xF317F0 Offset: 0xF2D7F0 VA: 0xF317F0
	public void OpenUpdateResourceScene() { }

	// RVA: 0xF318B4 Offset: 0xF2D8B4 VA: 0xF318B4
	public void LoginScreen() { }

	// RVA: 0xF31964 Offset: 0xF2D964 VA: 0xF31964
	private void RegisterStart() { }

	// RVA: 0xF321DC Offset: 0xF2E1DC VA: 0xF321DC
	private void RegisterScreen() { }

	// RVA: 0xF323F4 Offset: 0xF2E3F4 VA: 0xF323F4
	public void PlayNowScreen() { }

	// RVA: 0xF3242C Offset: 0xF2E42C VA: 0xF3242C
	public void LogOut() { }

	// RVA: 0xF324D0 Offset: 0xF2E4D0 VA: 0xF324D0
	public void OpenNotifi() { }

	// RVA: 0xF32654 Offset: 0xF2E654 VA: 0xF32654
	public void OpenPolicy() { }

	// RVA: 0xF327D8 Offset: 0xF2E7D8 VA: 0xF327D8
	public void OpenBackgroundEntergame() { }

	// RVA: 0xF32958 Offset: 0xF2E958 VA: 0xF32958
	public void OpenGame() { }

	// RVA: 0xF32C34 Offset: 0xF2EC34 VA: 0xF32C34
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF32D48 Offset: 0xF2ED48 VA: 0xF32D48
	private void <Start>b__64_0() { }

	[CompilerGenerated]
	// RVA: 0xF32D4C Offset: 0xF2ED4C VA: 0xF32D4C
	private void <Start>b__64_1() { }

	[CompilerGenerated]
	// RVA: 0xF32D50 Offset: 0xF2ED50 VA: 0xF32D50
	private void <Start>b__64_2() { }

	[CompilerGenerated]
	// RVA: 0xF32D54 Offset: 0xF2ED54 VA: 0xF32D54
	private void <Start>b__64_3() { }

	[CompilerGenerated]
	// RVA: 0xF32D58 Offset: 0xF2ED58 VA: 0xF32D58
	private void <Start>b__64_4() { }

	[CompilerGenerated]
	// RVA: 0xF32D5C Offset: 0xF2ED5C VA: 0xF32D5C
	private void <Start>b__64_5() { }

	[CompilerGenerated]
	// RVA: 0xF32D78 Offset: 0xF2ED78 VA: 0xF32D78
	private void <Start>b__64_6() { }

	[CompilerGenerated]
	// RVA: 0xF32DE8 Offset: 0xF2EDE8 VA: 0xF32DE8
	private void <Start>b__64_7() { }

	[CompilerGenerated]
	// RVA: 0xF32E58 Offset: 0xF2EE58 VA: 0xF32E58
	private void <Start>b__64_8() { }

	[CompilerGenerated]
	// RVA: 0xF32F0C Offset: 0xF2EF0C VA: 0xF32F0C
	private void <Start>b__64_9() { }

	[CompilerGenerated]
	// RVA: 0xF32FC0 Offset: 0xF2EFC0 VA: 0xF32FC0
	private void <Start>b__64_10() { }

	[CompilerGenerated]
	// RVA: 0xF32FE4 Offset: 0xF2EFE4 VA: 0xF32FE4
	private void <Start>b__64_11(string regionname, string servername) { }

	[CompilerGenerated]
	// RVA: 0xF33268 Offset: 0xF2F268 VA: 0xF33268
	private void <Start>b__64_14() { }

	[CompilerGenerated]
	// RVA: 0xF332F8 Offset: 0xF2F2F8 VA: 0xF332F8
	private void <Start>b__64_12() { }

	[CompilerGenerated]
	// RVA: 0xF33334 Offset: 0xF2F334 VA: 0xF33334
	private void <Start>b__64_13() { }

	[CompilerGenerated]
	// RVA: 0xF333E0 Offset: 0xF2F3E0 VA: 0xF333E0
	private void <Start>b__64_15() { }

	[CompilerGenerated]
	// RVA: 0xF333E4 Offset: 0xF2F3E4 VA: 0xF333E4
	private void <LoggedAccountListingAdd>b__76_0() { }

	[CompilerGenerated]
	// RVA: 0xF333E8 Offset: 0xF2F3E8 VA: 0xF333E8
	private void <LoggedAccountListingRemove>b__77_0() { }

	[CompilerGenerated]
	// RVA: 0xF334C0 Offset: 0xF2F4C0 VA: 0xF334C0
	private void <LoggedAccountListingLoad>b__78_0() { }

	[CompilerGenerated]
	// RVA: 0xF33598 Offset: 0xF2F598 VA: 0xF33598
	private void <LoggedAccountListingLoad>b__78_1() { }

	[CompilerGenerated]
	// RVA: 0xF3359C Offset: 0xF2F59C VA: 0xF3359C
	private void <RegisterScreen>b__84_0() { }

	[CompilerGenerated]
	// RVA: 0xF335A0 Offset: 0xF2F5A0 VA: 0xF335A0
	private void <RegisterScreen>b__84_1(int _actionCalledTimes) { }

	[CompilerGenerated]
	// RVA: 0xF336DC Offset: 0xF2F6DC VA: 0xF336DC
	private void <RegisterScreen>b__84_3(NetCoreManager net, NetCoreManager.MessageData message) { }

	[CompilerGenerated]
	// RVA: 0xF3397C Offset: 0xF2F97C VA: 0xF3397C
	private void <RegisterScreen>b__84_4(NetCoreManager net, NetCoreManager.MessageData message2) { }

	[CompilerGenerated]
	// RVA: 0xF33ABC Offset: 0xF2FABC VA: 0xF33ABC
	private void <RegisterScreen>b__84_2() { }
}

// Namespace: game.scene.login
public class LoginTermsAndNews : MonoBehaviour // TypeDefIndex: 3024
{
	// Fields
	[SerializeField]
	private Image framed; // 0x20
	[SerializeField]
	private Button buttonTerms; // 0x28
	[SerializeField]
	private Button buttonNews; // 0x30
	[SerializeField]
	private Button buttonConfirm; // 0x38
	[SerializeField]
	private Button buttonCancel; // 0x40
	[SerializeField]
	private GameObject termScrollviewGo; // 0x48
	[SerializeField]
	private GameObject newsScrollviewGo; // 0x50
	[SerializeField]
	private TextMeshProUGUI termContentText; // 0x58
	[SerializeField]
	private TextMeshProUGUI newsContentText; // 0x60
	private Action onconfirm; // 0x68
	private Action oncancel; // 0x70
	private GameObject backgo; // 0x78

	// Methods

	// RVA: 0xF5447C Offset: 0xF5047C VA: 0xF5447C
	private void Start() { }

	// RVA: 0xF52F18 Offset: 0xF4EF18 VA: 0xF52F18
	public void OpenViewTerms(Action onConfirm, Action onCancel, GameObject backgo) { }

	// RVA: 0xF546EC Offset: 0xF506EC VA: 0xF546EC
	public void OpenViewNews(Action onConfirm, Action onCancel, GameObject backgo) { }

	// RVA: 0xF54810 Offset: 0xF50810 VA: 0xF54810
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF54818 Offset: 0xF50818 VA: 0xF54818
	private void <Start>b__12_0() { }

	[CompilerGenerated]
	// RVA: 0xF548A8 Offset: 0xF508A8 VA: 0xF548A8
	private void <Start>b__12_1() { }

	[CompilerGenerated]
	// RVA: 0xF54938 Offset: 0xF50938 VA: 0xF54938
	private void <Start>b__12_2() { }

	[CompilerGenerated]
	// RVA: 0xF549F4 Offset: 0xF509F4 VA: 0xF549F4
	private void <Start>b__12_3() { }
}

// Namespace: 
private enum RegionServerSelected.TableHeaderIndexer // TypeDefIndex: 3025
{
	// Fields
	public int value__; // 0x0
	public const RegionServerSelected.TableHeaderIndexer currently = 0;
	public const RegionServerSelected.TableHeaderIndexer region = 1;
	public const RegionServerSelected.TableHeaderIndexer server = 2;
	public const RegionServerSelected.TableHeaderIndexer proxy = 3;
}

// Namespace: game.scene.login
public static class RegionServerSelected // TypeDefIndex: 3026
{
	// Fields
	[CompilerGenerated]
	private static string <data>k__BackingField; // 0x0

	// Properties
	public static string data { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xF54AB0 Offset: 0xF50AB0 VA: 0xF54AB0
	public static string get_data() { }

	[CompilerGenerated]
	// RVA: 0xF54B08 Offset: 0xF50B08 VA: 0xF54B08
	private static void set_data(string value) { }

	// RVA: 0xF54B70 Offset: 0xF50B70 VA: 0xF54B70
	public static bool IsServerSelected() { }

	// RVA: 0xF54C08 Offset: 0xF50C08 VA: 0xF54C08
	public static bool IsServerData(string data) { }

	// RVA: 0xF54CD8 Offset: 0xF50CD8 VA: 0xF54CD8
	public static string GetRegionName() { }

	// RVA: 0xF54DF4 Offset: 0xF50DF4 VA: 0xF54DF4
	public static string GetServerName() { }

	// RVA: 0xF54F10 Offset: 0xF50F10 VA: 0xF54F10
	public static int GetProxyCount() { }

	// RVA: 0xF55020 Offset: 0xF51020 VA: 0xF55020
	public static int GetTryConnectionCount() { }

	// RVA: 0xF5507C Offset: 0xF5107C VA: 0xF5507C
	public static bool LoadFile() { }

	// RVA: 0xF55328 Offset: 0xF51328 VA: 0xF55328
	private static int SaveFile(string newRegion, string newServer, int newProxy = -1) { }

	// RVA: 0xF55AAC Offset: 0xF51AAC VA: 0xF55AAC
	public static void DeleteFile() { }

	// RVA: 0xF55B88 Offset: 0xF51B88 VA: 0xF55B88
	public static void SaveRegion(string regiondata, string serverdata) { }

	// RVA: 0xF55D30 Offset: 0xF51D30 VA: 0xF55D30
	public static void SaveProxyIndex(int index) { }

	// RVA: 0xF55EB8 Offset: 0xF51EB8 VA: 0xF55EB8
	private static void .cctor() { }
}

// Namespace: game.scene.login
public static class RegisterConfirmPhone // TypeDefIndex: 3027
{
	// Methods

	// RVA: 0xF52B9C Offset: 0xF4EB9C VA: 0xF52B9C
	public static void OnPhoneSubmit(string phone, Action onSuccess, Action<string> onFail) { }

	// RVA: 0xF533E0 Offset: 0xF4F3E0 VA: 0xF533E0
	public static void OnOtpSubmit(string otp, Action onSuccess, Action<string> onFail) { }
}

// Namespace: game.scene.login
public class RegisterController : BaseMonoBehaviour // TypeDefIndex: 3028
{
	// Fields
	[SerializeField]
	private Image framed; // 0x20
	[SerializeField]
	private GameObject panelHome; // 0x28
	[SerializeField]
	private TMP_InputField inputUsername; // 0x30
	[SerializeField]
	private TMP_InputField inputPassWord1; // 0x38
	[SerializeField]
	private TMP_InputField inputPassWord2; // 0x40
	[SerializeField]
	private GameObject legalNameGo; // 0x48
	[SerializeField]
	private TMP_InputField inputLegalName; // 0x50
	[SerializeField]
	private GameObject birthdayGo; // 0x58
	[SerializeField]
	private TMP_InputField inputBirthday; // 0x60
	[SerializeField]
	private LoginManger loginManagerScript; // 0x68
	[SerializeField]
	private Button registerButtonConfirm; // 0x70
	[SerializeField]
	private Button registerButtonBackButton; // 0x78
	private string userNameData; // 0x80
	private string passwordData; // 0x88
	private string passwordConfirm; // 0x90
	private bool phoneRequired; // 0x98
	private string phonenum; // 0xA0
	private bool birthdayRequired; // 0xA8
	private string birthdayData; // 0xB0
	private bool legalNameRequired; // 0xB8
	private string legalNameData; // 0xC0

	// Methods

	// RVA: 0xF55F1C Offset: 0xF51F1C VA: 0xF55F1C
	private void Start() { }

	// RVA: 0xF5604C Offset: 0xF5204C VA: 0xF5604C
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xF56358 Offset: 0xF52358 VA: 0xF56358
	public void SetActive(bool enabled) { }

	// RVA: 0xF52618 Offset: 0xF4E618 VA: 0xF52618
	public void Open(bool phoneRequired, string phonenum, bool birthdayRequired, bool legalNameRequired) { }

	// RVA: 0xF56380 Offset: 0xF52380 VA: 0xF56380
	private void Validate() { }

	// RVA: 0xF56A90 Offset: 0xF52A90 VA: 0xF56A90
	private void Cancel() { }

	// RVA: 0xF56888 Offset: 0xF52888 VA: 0xF56888
	private void Register() { }

	// RVA: 0xF56B30 Offset: 0xF52B30 VA: 0xF56B30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF56BE4 Offset: 0xF52BE4 VA: 0xF56BE4
	private void <Register>b__27_0(int _actionCalledTimes) { }

	[CompilerGenerated]
	// RVA: 0xF56D3C Offset: 0xF52D3C VA: 0xF56D3C
	private void <Register>b__27_3(NetCoreManager net, NetCoreManager.MessageData message) { }

	[CompilerGenerated]
	// RVA: 0xF57240 Offset: 0xF53240 VA: 0xF57240
	private void <Register>b__27_4(NetCoreManager net, NetCoreManager.MessageData message2) { }

	[CompilerGenerated]
	// RVA: 0xF574A0 Offset: 0xF534A0 VA: 0xF574A0
	private void <Register>b__27_1() { }

	[CompilerGenerated]
	// RVA: 0xF574C4 Offset: 0xF534C4 VA: 0xF574C4
	private void <Register>b__27_2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RegisterEnterOtp.<>c__DisplayClass12_0 // TypeDefIndex: 3029
{
	// Fields
	public RegisterEnterOtp <>4__this; // 0x10
	public string phoneNumber; // 0x18

	// Methods

	// RVA: 0xF57A4C Offset: 0xF53A4C VA: 0xF57A4C
	public void .ctor() { }

	// RVA: 0xF57AF8 Offset: 0xF53AF8 VA: 0xF57AF8
	internal void <Open>b__0() { }
}

// Namespace: game.scene.login
public class RegisterEnterOtp : MonoBehaviour // TypeDefIndex: 3030
{
	// Fields
	[SerializeField]
	private Button confirmButton; // 0x20
	[SerializeField]
	private Button cancelButton; // 0x28
	[SerializeField]
	private TextMeshProUGUI descriptionTmp; // 0x30
	[SerializeField]
	private TMP_InputField inputTmpro; // 0x38
	private string descriptionText; // 0x40
	private Queue<Action> onStartActions; // 0x48
	private bool isStarted; // 0x50
	private Action<string> onConfirm; // 0x58
	private Action onCancel; // 0x60

	// Methods

	// RVA: 0xF574E8 Offset: 0xF534E8 VA: 0xF574E8
	private void Start() { }

	// RVA: 0xF5797C Offset: 0xF5397C VA: 0xF5797C
	private void Perform(Action action) { }

	// RVA: 0xF57670 Offset: 0xF53670 VA: 0xF57670
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xF531B0 Offset: 0xF4F1B0 VA: 0xF531B0
	public void Open(string phoneNumber, Action<string> onSubmit, Action onCancel) { }

	// RVA: 0xF57A54 Offset: 0xF53A54 VA: 0xF57A54
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF57A5C Offset: 0xF53A5C VA: 0xF57A5C
	private void <Start>b__9_0() { }

	[CompilerGenerated]
	// RVA: 0xF57AB0 Offset: 0xF53AB0 VA: 0xF57AB0
	private void <Start>b__9_1() { }
}

// Namespace: game.scene.login
public class RegisterEnterPhone : MonoBehaviour // TypeDefIndex: 3031
{
	// Fields
	[SerializeField]
	private Button confirmButton; // 0x20
	[SerializeField]
	private Button cancelButton; // 0x28
	[SerializeField]
	private TMP_InputField inputTmpro; // 0x30
	private Action<string> onConfirm; // 0x38
	private Action onCancel; // 0x40

	// Methods

	// RVA: 0xF57BA4 Offset: 0xF53BA4 VA: 0xF57BA4
	private void Start() { }

	// RVA: 0xF57CA4 Offset: 0xF53CA4 VA: 0xF57CA4
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xF527F8 Offset: 0xF4E7F8 VA: 0xF527F8
	public void Open(Action<string> onSubmit, Action onCancel) { }

	// RVA: 0xF57FB0 Offset: 0xF53FB0 VA: 0xF57FB0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF57FB8 Offset: 0xF53FB8 VA: 0xF57FB8
	private void <Start>b__5_0() { }

	[CompilerGenerated]
	// RVA: 0xF58000 Offset: 0xF54000 VA: 0xF58000
	private void <Start>b__5_1() { }
}

// Namespace: 
public enum SafeArea.SimDevice // TypeDefIndex: 3032
{
	// Fields
	public int value__; // 0x0
	public const SafeArea.SimDevice None = 0;
	public const SafeArea.SimDevice iPhoneX = 1;
	public const SafeArea.SimDevice iPhoneXsMax = 2;
	public const SafeArea.SimDevice Pixel3XL_LSL = 3;
	public const SafeArea.SimDevice Pixel3XL_LSR = 4;
}
