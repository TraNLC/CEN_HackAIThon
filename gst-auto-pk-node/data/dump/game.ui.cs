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

// Namespace: game.ui
public class ActivitiesListPc : MonoBehaviour // TypeDefIndex: 2539
{
	// Fields
	[SerializeField]
	private Image framedImage; // 0x20
	[SerializeField]
	private Button closeButton; // 0x28
	[SerializeField]
	private GameObject goContentList; // 0x30
	[SerializeField]
	private GameObject goFieldTemplate; // 0x38
	[SerializeField]
	private ScrollRect scrollRect; // 0x40
	private readonly Queue<Action> onStartActions; // 0x48
	private bool isStarted; // 0x50
	private ActivitiesListPc.FieldTemplate fieldtemplate; // 0x58

	// Methods

	// RVA: 0xE6460C Offset: 0xE6060C VA: 0xE6460C
	private void Start() { }

	// RVA: 0xE64A04 Offset: 0xE60A04 VA: 0xE64A04
	private void Perform(Action action) { }

	// RVA: 0xE64A80 Offset: 0xE60A80 VA: 0xE64A80
	public void SetData(ActivitiesListData data) { }

	// RVA: 0xE65B8C Offset: 0xE61B8C VA: 0xE65B8C
	public void Open(ActivitiesListData data) { }

	// RVA: 0xE65C84 Offset: 0xE61C84 VA: 0xE65C84
	public void Close() { }

	// RVA: 0xE65CA8 Offset: 0xE61CA8 VA: 0xE65CA8
	public bool IsOpening() { }

	// RVA: 0xE65CC8 Offset: 0xE61CC8 VA: 0xE65CC8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE65D50 Offset: 0xE61D50 VA: 0xE65D50
	private void <Start>b__9_0() { }
}

// Namespace: game.ui
public class DenyMoving : MonoBehaviour // TypeDefIndex: 2540
{
	// Fields
	private readonly Dictionary<string, bool> mapping; // 0x20

	// Methods

	// RVA: 0xE65F04 Offset: 0xE61F04 VA: 0xE65F04
	public int GetReferCount() { }

	// RVA: 0xE65F54 Offset: 0xE61F54 VA: 0xE65F54
	public void Up(string key) { }

	// RVA: 0xE65FCC Offset: 0xE61FCC VA: 0xE65FCC
	public void Down(string key) { }

	// RVA: 0xE66078 Offset: 0xE62078 VA: 0xE66078
	public void .ctor() { }
}

// Namespace: 
private class DisconnectMessage.BlockingData // TypeDefIndex: 2541
{
	// Fields
	public Func<bool> func; // 0x10
	public string key; // 0x18

	// Methods

	// RVA: 0xE67BDC Offset: 0xE63BDC VA: 0xE67BDC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DisconnectMessage.<>c // TypeDefIndex: 2542
{
	// Fields
	public static readonly DisconnectMessage.<>c <>9; // 0x0
	public static Action<NetCoreManager> <>9__17_0; // 0x8
	public static Action <>9__17_1; // 0x10

	// Methods

	// RVA: 0xE68420 Offset: 0xE64420 VA: 0xE68420
	private static void .cctor() { }

	// RVA: 0xE68488 Offset: 0xE64488 VA: 0xE68488
	public void .ctor() { }

	// RVA: 0xE68490 Offset: 0xE64490 VA: 0xE68490
	internal void <OnEnterGame>b__17_0(NetCoreManager _) { }

	// RVA: 0xE68568 Offset: 0xE64568 VA: 0xE68568
	internal void <OnEnterGame>b__17_1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DisconnectMessage.<>c__DisplayClass17_0 // TypeDefIndex: 2543
{
	// Fields
	public Dictionary<string, NpcRes.Special> oldenPlayerController; // 0x10

	// Methods

	// RVA: 0xE67930 Offset: 0xE63930 VA: 0xE67930
	public void .ctor() { }

	// RVA: 0xE68674 Offset: 0xE64674 VA: 0xE68674
	internal void <OnEnterGame>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DisconnectMessage.<>c__DisplayClass17_1 // TypeDefIndex: 2544
{
	// Fields
	public Dictionary<string, NpcRes.Normal> oldenController; // 0x10

	// Methods

	// RVA: 0xE67938 Offset: 0xE63938 VA: 0xE67938
	public void .ctor() { }

	// RVA: 0xE687FC Offset: 0xE647FC VA: 0xE687FC
	internal void <OnEnterGame>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DisconnectMessage.<>c__DisplayClass17_2 // TypeDefIndex: 2545
{
	// Fields
	public Dictionary<string, Object> oldenObject; // 0x10

	// Methods

	// RVA: 0xE67940 Offset: 0xE63940 VA: 0xE67940
	public void .ctor() { }

	// RVA: 0xE68984 Offset: 0xE64984 VA: 0xE68984
	internal void <OnEnterGame>b__4() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DisconnectMessage.<>c__DisplayClass23_0 // TypeDefIndex: 2546
{
	// Fields
	public DisconnectMessage <>4__this; // 0x10
	public string key; // 0x18

	// Methods

	// RVA: 0xE67CBC Offset: 0xE63CBC VA: 0xE67CBC
	public void .ctor() { }

	// RVA: 0xE68B1C Offset: 0xE64B1C VA: 0xE68B1C
	internal bool <RemoveBlocking>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DisconnectMessage.<>c__DisplayClass24_0 // TypeDefIndex: 2547
{
	// Fields
	public long connectToMasterRemaining; // 0x10
	public DisconnectMessage <>4__this; // 0x18
	public MSUnityEntergameResponse entergameMessage; // 0x20
	public Action<NetCoreManager, NetCoreManager.MessageData> <>9__2; // 0x28

	// Methods

	// RVA: 0xE67EE0 Offset: 0xE63EE0 VA: 0xE67EE0
	public void .ctor() { }

	// RVA: 0xE68E24 Offset: 0xE64E24 VA: 0xE68E24
	internal bool <EnterGameWorld>b__0() { }

	// RVA: 0xE68F3C Offset: 0xE64F3C VA: 0xE68F3C
	internal void <EnterGameWorld>b__1(NetCoreManager net, NetCoreManager.MessageData message) { }

	// RVA: 0xE6925C Offset: 0xE6525C VA: 0xE6925C
	internal void <EnterGameWorld>b__2(NetCoreManager net, NetCoreManager.MessageData message2) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DisconnectMessage.<>c__DisplayClass24_1 // TypeDefIndex: 2548
{
	// Fields
	public PlayerLoginResponse response; // 0x10
	public long retry1; // 0x18
	public DisconnectMessage.<>c__DisplayClass24_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0xE694D8 Offset: 0xE654D8 VA: 0xE694D8
	public void .ctor() { }

	// RVA: 0xE694E0 Offset: 0xE654E0 VA: 0xE694E0
	internal bool <EnterGameWorld>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DisconnectMessage.<>c__DisplayClass25_0 // TypeDefIndex: 2549
{
	// Fields
	public long connectToMasterRemaining; // 0x10
	public DisconnectMessage <>4__this; // 0x18
	public string userName; // 0x20
	public string userpassword; // 0x28
	public Action<NetCoreManager, NetCoreManager.MessageData> <>9__3; // 0x30
	public Action<NetCoreManager, NetCoreManager.MessageData> <>9__2; // 0x38

	// Methods

	// RVA: 0xE681F8 Offset: 0xE641F8 VA: 0xE681F8
	public void .ctor() { }

	// RVA: 0xE69640 Offset: 0xE65640 VA: 0xE69640
	internal bool <Reconnect>b__0() { }

	// RVA: 0xE69758 Offset: 0xE65758 VA: 0xE69758
	internal void <Reconnect>b__1(NetCoreManager net, NetCoreManager.MessageData message) { }

	// RVA: 0xE69A68 Offset: 0xE65A68 VA: 0xE69A68
	internal void <Reconnect>b__2(NetCoreManager net, NetCoreManager.MessageData message2) { }

	// RVA: 0xE69DF4 Offset: 0xE65DF4 VA: 0xE69DF4
	internal void <Reconnect>b__3(NetCoreManager net, NetCoreManager.MessageData message3) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DisconnectMessage.<>c__DisplayClass25_1 // TypeDefIndex: 2550
{
	// Fields
	public MSUnityLoginResponse response; // 0x10
	public DisconnectMessage.<>c__DisplayClass25_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xE69DE4 Offset: 0xE65DE4 VA: 0xE69DE4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DisconnectMessage.<>c__DisplayClass25_2 // TypeDefIndex: 2551
{
	// Fields
	public long retry1; // 0x10
	public DisconnectMessage.<>c__DisplayClass25_1 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xE69DEC Offset: 0xE65DEC VA: 0xE69DEC
	public void .ctor() { }

	// RVA: 0xE6A12C Offset: 0xE6612C VA: 0xE6A12C
	internal bool <Reconnect>b__4() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DisconnectMessage.<>c__DisplayClass25_3 // TypeDefIndex: 2552
{
	// Fields
	public MSUnityEntergameResponse response; // 0x10
	public long retry2; // 0x18
	public DisconnectMessage.<>c__DisplayClass25_0 CS$<>8__locals3; // 0x20

	// Methods

	// RVA: 0xE6A124 Offset: 0xE66124 VA: 0xE6A124
	public void .ctor() { }

	// RVA: 0xE6A22C Offset: 0xE6622C VA: 0xE6A22C
	internal bool <Reconnect>b__5() { }
}

// Namespace: game.ui
public class DisconnectMessage : MonoBehaviour // TypeDefIndex: 2553
{
	// Fields
	[SerializeField]
	private GameObject denyRaycastGo; // 0x20
	[SerializeField]
	private Image framedImage; // 0x28
	[SerializeField]
	private TextMeshProUGUI contentText; // 0x30
	[SerializeField]
	private Button closeButton; // 0x38
	private int silentReconnectCount; // 0x40
	private int reconnectSecondsTimeout; // 0x44
	private bool isReconnectRandomType; // 0x48
	private bool nextOpenIsNoise; // 0x49
	private int currentReconnectTimes; // 0x4C
	private long nextActivateSeconds; // 0x50
	private int currentFreezeSeconds; // 0x58
	private List<DisconnectMessage.BlockingData> blockingSeconds; // 0x60
	private bool previousAutoIsRunning; // 0x68

	// Methods

	// RVA: 0xE66100 Offset: 0xE62100 VA: 0xE66100
	private void SetActive(bool enabled, bool visibled) { }

	// RVA: 0xE6616C Offset: 0xE6216C VA: 0xE6616C
	private void Start() { }

	// RVA: 0xE662E0 Offset: 0xE622E0 VA: 0xE662E0
	private void Update() { }

	// RVA: 0xE665A8 Offset: 0xE625A8 VA: 0xE665A8
	private void OnEnterGame(PlayerLoginResponse response) { }

	// RVA: 0xE67948 Offset: 0xE63948 VA: 0xE67948
	private void OnReconnect() { }

	// RVA: 0xE679E4 Offset: 0xE639E4 VA: 0xE679E4
	private void OnCountDown() { }

	// RVA: 0xE6624C Offset: 0xE6224C VA: 0xE6624C
	private void PrintText(string data) { }

	// RVA: 0xE67A80 Offset: 0xE63A80 VA: 0xE67A80
	private long GetNextFreeTime() { }

	// RVA: 0xE67AD4 Offset: 0xE63AD4 VA: 0xE67AD4
	private void AddBlocking(Func<bool> func, string key) { }

	// RVA: 0xE67BE4 Offset: 0xE63BE4 VA: 0xE67BE4
	private void RemoveBlocking(string key) { }

	// RVA: 0xE67CC4 Offset: 0xE63CC4 VA: 0xE67CC4
	private void EnterGameWorld(MSUnityEntergameResponse entergameMessage) { }

	// RVA: 0xE67EE8 Offset: 0xE63EE8 VA: 0xE67EE8
	private void Reconnect() { }

	// RVA: 0xE68200 Offset: 0xE64200 VA: 0xE68200
	public void SetNextOpenNoise(bool noise) { }

	// RVA: 0xE68208 Offset: 0xE64208 VA: 0xE68208
	public void Open() { }

	// RVA: 0xE68378 Offset: 0xE64378 VA: 0xE68378
	public void Close() { }

	// RVA: 0xE68410 Offset: 0xE64410 VA: 0xE68410
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GiveItem.<>c__DisplayClass27_0 // TypeDefIndex: 2554
{
	// Fields
	public float secondsRemaining; // 0x10
	public GiveItem <>4__this; // 0x18
	public RectTransform rect; // 0x20
	public Vector2 to; // 0x28
	public Action onFinish; // 0x30
	public float speedOnSeconds; // 0x38

	// Methods

	// RVA: 0xE6AB3C Offset: 0xE66B3C VA: 0xE6AB3C
	public void .ctor() { }

	// RVA: 0xE6B8C8 Offset: 0xE678C8 VA: 0xE6B8C8
	internal void <LeanMoveLocal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GiveItem.<>c__DisplayClass28_0 // TypeDefIndex: 2555
{
	// Fields
	public GiveItem <>4__this; // 0x10
	public GiveBoxOpen giveBoxOpen; // 0x18
	public Action<int, PlayerSelfBagarate.Cell> <>9__1; // 0x20
	public Action <>9__2; // 0x28

	// Methods

	// RVA: 0xE6ACBC Offset: 0xE66CBC VA: 0xE6ACBC
	public void .ctor() { }

	// RVA: 0xE6BA68 Offset: 0xE67A68 VA: 0xE6BA68
	internal void <ShowOpen>b__0() { }

	// RVA: 0xE6BD40 Offset: 0xE67D40 VA: 0xE6BD40
	internal void <ShowOpen>b__1(int _itemtabCellIndex, PlayerSelfBagarate.Cell _bagarateCell) { }

	// RVA: 0xE6BF9C Offset: 0xE67F9C VA: 0xE6BF9C
	internal void <ShowOpen>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GiveItem.<>c__DisplayClass28_1 // TypeDefIndex: 2556
{
	// Fields
	public PlayerSelfBagarate.Cell _bagarateCell; // 0x10
	public GiveItem.<>c__DisplayClass28_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xE6BF58 Offset: 0xE67F58 VA: 0xE6BF58
	public void .ctor() { }

	// RVA: 0xE6BFC8 Offset: 0xE67FC8 VA: 0xE6BFC8
	internal void <ShowOpen>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class GiveItem.<>c__DisplayClass36_0 // TypeDefIndex: 2557
{
	// Fields
	public GiveItem <>4__this; // 0x10
	public Item item; // 0x18
	public Action <>9__2; // 0x20
	public Action <>9__1; // 0x28

	// Methods

	// RVA: 0xE6B284 Offset: 0xE67284 VA: 0xE6B284
	public void .ctor() { }

	// RVA: 0xE6C20C Offset: 0xE6820C VA: 0xE6C20C
	internal void <AddItem>b__0() { }

	// RVA: 0xE6C46C Offset: 0xE6846C VA: 0xE6C46C
	internal void <AddItem>b__1() { }

	// RVA: 0xE6C628 Offset: 0xE68628 VA: 0xE6C628
	internal void <AddItem>b__2() { }
}

// Namespace: game.ui
public class GiveItem : MonoBehaviour // TypeDefIndex: 2558
{
	// Fields
	private const int OriginFramedWidth = 214;
	private const int OriginFramedHeight = 444;
	private const int OriginItemFramedWidth = 42;
	private const int OriginItemFramedHeight = 42;
	private const int OriginLineItemCount = 4;
	[SerializeField]
	private RectTransform backgroundRect; // 0x20
	[SerializeField]
	private Image backgroundImage; // 0x28
	[SerializeField]
	private TextMeshProUGUI titleTmp; // 0x30
	[SerializeField]
	private TextMeshProUGUI descriptionTmp; // 0x38
	[SerializeField]
	private RectTransform itemListingContent; // 0x40
	[SerializeField]
	private RectTransform itemTemplate; // 0x48
	[SerializeField]
	private Button confirmButton; // 0x50
	[SerializeField]
	private Button closeButton; // 0x58
	public const int MaximunStorageItemCount = 16;
	private float scaleRatio; // 0x60
	private Vector2 showoffVisiblePosition; // 0x64
	private Vector2 showoffHiddenPosition; // 0x6C
	private Queue<Action> onStartActions; // 0x78
	private bool isStarted; // 0x80
	private bool isOpening; // 0x81
	private PlayerSelfBagarate.Cell cellTemplate; // 0x88
	private List<PlayerSelfBagarate.Cell> cellListing; // 0x90
	private Dictionary<int, Item> itemListing; // 0x98
	private Action leanMoveLocalUpdating; // 0xA0

	// Methods

	// RVA: 0xE6A314 Offset: 0xE66314 VA: 0xE6A314
	private void Start() { }

	// RVA: 0xE6A89C Offset: 0xE6689C VA: 0xE6A89C
	private void Update() { }

	// RVA: 0xE6A8B8 Offset: 0xE668B8 VA: 0xE6A8B8
	private void Perform(Action action) { }

	// RVA: 0xE6A988 Offset: 0xE66988 VA: 0xE6A988
	private void LeanMoveLocal(RectTransform rect, Vector2 to, Action onFinish) { }

	// RVA: 0xE6AB44 Offset: 0xE66B44 VA: 0xE6AB44
	public void ShowOpen(bool enabled, GiveBoxOpen giveBoxOpen) { }

	// RVA: 0xE6ACC4 Offset: 0xE66CC4 VA: 0xE6ACC4
	public void ShowOff() { }

	// RVA: 0xE6ACD8 Offset: 0xE66CD8 VA: 0xE6ACD8
	public void ShowDirectly(bool enabled) { }

	// RVA: 0xE6AFFC Offset: 0xE66FFC VA: 0xE6AFFC
	public bool IsOpen() { }

	// RVA: 0xE6B004 Offset: 0xE67004 VA: 0xE6B004
	private void SetTitle(string title) { }

	// RVA: 0xE6B098 Offset: 0xE67098 VA: 0xE6B098
	private void SetDescription(string description) { }

	// RVA: 0xE6A634 Offset: 0xE66634 VA: 0xE6A634
	private List<PlayerSelfBagarate.Cell> CreateNewCellLine() { }

	// RVA: 0xE6B12C Offset: 0xE6712C VA: 0xE6B12C
	public bool ExistingItemIndex(int itemindex) { }

	// RVA: 0xE6B194 Offset: 0xE67194 VA: 0xE6B194
	public void AddItem(Item item) { }

	// RVA: 0xE6B28C Offset: 0xE6728C VA: 0xE6B28C
	public void RemoveItem(int itemindex) { }

	// RVA: 0xE6AE34 Offset: 0xE66E34 VA: 0xE6AE34
	public void ClearAllItem() { }

	// RVA: 0xE6B3E4 Offset: 0xE673E4 VA: 0xE6B3E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE6B3EC Offset: 0xE673EC VA: 0xE6B3EC
	private void <Start>b__24_0() { }

	[CompilerGenerated]
	// RVA: 0xE6B63C Offset: 0xE6763C VA: 0xE6B63C
	private void <Start>b__24_1() { }

	[CompilerGenerated]
	// RVA: 0xE6B894 Offset: 0xE67894 VA: 0xE6B894
	private void <ShowDirectly>b__30_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HomeSkillDirectionTargetList.FieldTemplate.<>c__DisplayClass10_0 // TypeDefIndex: 2559
{
	// Fields
	public Action onClick; // 0x10

	// Methods

	// RVA: 0xE6D640 Offset: 0xE69640 VA: 0xE6D640
	public void .ctor() { }

	// RVA: 0xE6D864 Offset: 0xE69864 VA: 0xE6D864
	internal void <Apply>b__0() { }
}

// Namespace: 
private class HomeSkillDirectionTargetList.FieldTemplate // TypeDefIndex: 2560
{
	// Fields
	public GameObject go; // 0x10
	public Image factionIconImage; // 0x18
	public TextMeshProUGUI levelTmp; // 0x20
	public TextMeshProUGUI nameTmp; // 0x28
	public Button button; // 0x30
	public string dataCid; // 0x38
	public int dataLevel; // 0x40
	public string dataName; // 0x48

	// Methods

	// RVA: 0xE6C9A8 Offset: 0xE689A8 VA: 0xE6C9A8
	public void .ctor(GameObject go) { }

	// RVA: 0xE6D354 Offset: 0xE69354 VA: 0xE6D354
	public HomeSkillDirectionTargetList.FieldTemplate Clone(GameObject parent) { }

	// RVA: 0xE6D42C Offset: 0xE6942C VA: 0xE6D42C
	public void Apply(Controller controller, Action onClick) { }

	// RVA: 0xE6D648 Offset: 0xE69648 VA: 0xE6D648
	public void SetTarget(bool isTargeted) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HomeSkillDirectionTargetList.<>c__DisplayClass15_0 // TypeDefIndex: 2561
{
	// Fields
	public HomeSkillDirectionTargetList <>4__this; // 0x10
	public Controller controller; // 0x18
	public Action onClick; // 0x20
	public string targetSelected; // 0x28

	// Methods

	// RVA: 0xE6CF3C Offset: 0xE68F3C VA: 0xE6CF3C
	public void .ctor() { }

	// RVA: 0xE6D8E4 Offset: 0xE698E4 VA: 0xE6D8E4
	internal void <AppendNpcontroller>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HomeSkillDirectionTargetList.<>c__DisplayClass15_1 // TypeDefIndex: 2562
{
	// Fields
	public HomeSkillDirectionTargetList.FieldTemplate field; // 0x10
	public HomeSkillDirectionTargetList.<>c__DisplayClass15_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xE6DBF8 Offset: 0xE69BF8 VA: 0xE6DBF8
	public void .ctor() { }

	// RVA: 0xE6DC00 Offset: 0xE69C00 VA: 0xE6DC00
	internal void <AppendNpcontroller>b__1() { }
}

// Namespace: game.ui
public class HomeSkillDirectionTargetList : MonoBehaviour // TypeDefIndex: 2563
{
	// Fields
	[SerializeField]
	private TextMeshProUGUI titleLabel; // 0x20
	[SerializeField]
	private Button titleButton; // 0x28
	[SerializeField]
	private GameObject fieldTemplateGo; // 0x30
	[SerializeField]
	private GameObject listingGo; // 0x38
	private bool isActive; // 0x40
	private readonly Queue<Action> onStartActions; // 0x48
	private bool isStarted; // 0x50
	private readonly List<HomeSkillDirectionTargetList.FieldTemplate> templatelisting; // 0x58
	private HomeSkillDirectionTargetList.FieldTemplate templateField; // 0x60

	// Methods

	// RVA: 0xE6C7B8 Offset: 0xE687B8 VA: 0xE6C7B8
	private void Start() { }

	// RVA: 0xE6CBD8 Offset: 0xE68BD8 VA: 0xE6CBD8
	public bool isOpening() { }

	// RVA: 0xE6CBE0 Offset: 0xE68BE0 VA: 0xE6CBE0
	private void Perform(Action action) { }

	// RVA: 0xE6CC5C Offset: 0xE68C5C VA: 0xE6CC5C
	public void SetActive(bool enabled, int delaySeconds = 2) { }

	// RVA: 0xE6CD88 Offset: 0xE68D88 VA: 0xE6CD88
	public void Clear() { }

	// RVA: 0xE6CE08 Offset: 0xE68E08 VA: 0xE6CE08
	public void AppendNpcontroller(Controller controller, string targetSelected, Action onClick) { }

	// RVA: 0xE6CF44 Offset: 0xE68F44 VA: 0xE6CF44
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE6D020 Offset: 0xE69020 VA: 0xE6D020
	private void <Start>b__10_0() { }

	[CompilerGenerated]
	// RVA: 0xE6D098 Offset: 0xE69098 VA: 0xE6D098
	private void <SetActive>b__13_0() { }

	[CompilerGenerated]
	// RVA: 0xE6D1CC Offset: 0xE691CC VA: 0xE6D1CC
	private void <SetActive>b__13_1() { }

	[CompilerGenerated]
	// RVA: 0xE6D1E8 Offset: 0xE691E8 VA: 0xE6D1E8
	private void <SetActive>b__13_2() { }

	[CompilerGenerated]
	// RVA: 0xE6D210 Offset: 0xE69210 VA: 0xE6D210
	private void <Clear>b__14_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HomeTouchTargetList.FieldTemplate.<>c__DisplayClass11_0 // TypeDefIndex: 2564
{
	// Fields
	public Action onClick; // 0x10

	// Methods

	// RVA: 0xE6F580 Offset: 0xE6B580 VA: 0xE6F580
	public void .ctor() { }

	// RVA: 0xE6F888 Offset: 0xE6B888 VA: 0xE6F888
	internal void <Apply>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HomeTouchTargetList.FieldTemplate.<>c__DisplayClass15_0 // TypeDefIndex: 2565
{
	// Fields
	public Action onChatClick; // 0x10
	public Action onStallClick; // 0x18

	// Methods

	// RVA: 0xE6F880 Offset: 0xE6B880 VA: 0xE6F880
	public void .ctor() { }

	// RVA: 0xE6F8A8 Offset: 0xE6B8A8 VA: 0xE6F8A8
	internal void <EnableForChatHistoryClick>b__0() { }

	// RVA: 0xE6F934 Offset: 0xE6B934 VA: 0xE6F934
	internal void <EnableForChatHistoryClick>b__1() { }
}

// Namespace: 
private class HomeTouchTargetList.FieldTemplate // TypeDefIndex: 2566
{
	// Fields
	public GameObject go; // 0x10
	public Image factionIconImage; // 0x18
	public TextMeshProUGUI levelTmp; // 0x20
	public TextMeshProUGUI nameTmp; // 0x28
	public Button button; // 0x30
	public ButtonJoystickNoRaycast buttonJoystickNoRaycast; // 0x38
	public string dataCid; // 0x40
	public int dataLevel; // 0x48
	public string dataName; // 0x50

	// Methods

	// RVA: 0xE6E0FC Offset: 0xE6A0FC VA: 0xE6E0FC
	public void .ctor(GameObject go) { }

	// RVA: 0xE6ED14 Offset: 0xE6AD14 VA: 0xE6ED14
	public HomeTouchTargetList.FieldTemplate Clone(GameObject parent) { }

	// RVA: 0xE6EDEC Offset: 0xE6ADEC VA: 0xE6EDEC
	public void Apply(Controller controller, Action onClick) { }

	// RVA: 0xE6F588 Offset: 0xE6B588 VA: 0xE6F588
	public void SetName(string name) { }

	// RVA: 0xE6EF40 Offset: 0xE6AF40 VA: 0xE6EF40
	public void SetFactionIcon(Sprite sprite) { }

	// RVA: 0xE6EF84 Offset: 0xE6AF84 VA: 0xE6EF84
	public void SetCamp(int camp) { }

	// RVA: 0xE6F590 Offset: 0xE6B590 VA: 0xE6F590
	public void EnableForChatHistoryClick(Action onChatClick, Action onStallClick) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HomeTouchTargetList.<>c__DisplayClass26_0 // TypeDefIndex: 2567
{
	// Fields
	public HomeTouchTargetList <>4__this; // 0x10
	public string name; // 0x18
	public string cid; // 0x20
	public UnityAction <>9__1; // 0x28
	public Action <>9__2; // 0x30
	public Action <>9__3; // 0x38

	// Methods

	// RVA: 0xE6E8DC Offset: 0xE6A8DC VA: 0xE6E8DC
	public void .ctor() { }

	// RVA: 0xE6F9C0 Offset: 0xE6B9C0 VA: 0xE6F9C0
	internal void <OpenByChatHistoryClick>b__0() { }

	// RVA: 0xE6FEA8 Offset: 0xE6BEA8 VA: 0xE6FEA8
	internal void <OpenByChatHistoryClick>b__1() { }

	// RVA: 0xE6FF18 Offset: 0xE6BF18 VA: 0xE6FF18
	internal void <OpenByChatHistoryClick>b__2() { }

	// RVA: 0xE6FF84 Offset: 0xE6BF84 VA: 0xE6FF84
	internal void <OpenByChatHistoryClick>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HomeTouchTargetList.<>c__DisplayClass27_0 // TypeDefIndex: 2568
{
	// Fields
	public HomeTouchTargetList <>4__this; // 0x10
	public Position targetPosition; // 0x18
	public bool autoPickObject; // 0x20

	// Methods

	// RVA: 0xE6E9E8 Offset: 0xE6A9E8 VA: 0xE6E9E8
	public void .ctor() { }

	// RVA: 0xE70050 Offset: 0xE6C050 VA: 0xE70050
	internal void <Open>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HomeTouchTargetList.<>c__DisplayClass27_1 // TypeDefIndex: 2569
{
	// Fields
	public KeyValuePair<string, Object> entry; // 0x10
	public HomeTouchTargetList.<>c__DisplayClass27_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0xE71178 Offset: 0xE6D178 VA: 0xE71178
	public void .ctor() { }

	// RVA: 0xE71180 Offset: 0xE6D180 VA: 0xE71180
	internal void <Open>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HomeTouchTargetList.<>c__DisplayClass28_0 // TypeDefIndex: 2570
{
	// Fields
	public HomeTouchTargetList <>4__this; // 0x10
	public Params.Owner entryOwner; // 0x18

	// Methods

	// RVA: 0xE6ED0C Offset: 0xE6AD0C VA: 0xE6ED0C
	public void .ctor() { }

	// RVA: 0xE711F0 Offset: 0xE6D1F0 VA: 0xE711F0
	internal void <RenderOwner>b__0() { }
}

// Namespace: game.ui
public class HomeTouchTargetList : MonoBehaviour // TypeDefIndex: 2571
{
	// Fields
	[SerializeField]
	private Image hidenIconSalesman; // 0x20
	[SerializeField]
	private Image hidenIconNpcDialog; // 0x28
	[SerializeField]
	private Image hidenIconNpcAttack; // 0x30
	[SerializeField]
	private Image hiddenIconChatPrivate; // 0x38
	[SerializeField]
	private Button closeButton; // 0x40
	[SerializeField]
	private TextMeshProUGUI closeTmp; // 0x48
	[SerializeField]
	private GameObject scrollingGo; // 0x50
	[SerializeField]
	private Button scrollingButton; // 0x58
	[SerializeField]
	private TextMeshProUGUI scrollingTmp; // 0x60
	[SerializeField]
	private GameObject fieldTemplateGo; // 0x68
	[SerializeField]
	private GameObject listingGo; // 0x70
	[SerializeField]
	private ScrollRect listingScrollRect; // 0x78
	private PlayerMain mainPlayer; // 0x80
	private readonly Queue<Action> onStartActions; // 0x88
	private bool isStarted; // 0x90
	private readonly List<HomeTouchTargetList.FieldTemplate> templatelisting; // 0x98
	private HomeTouchTargetList.FieldTemplate templateField; // 0xA0
	private bool isScrolling; // 0xA8
	private long autohideNextCheckTime; // 0xB0
	private Position autohideCentralPosition; // 0xB8
	private List<Params.Owner> scrollingTargetListRemaining; // 0xC0

	// Methods

	// RVA: 0xE6DDD4 Offset: 0xE69DD4 VA: 0xE6DDD4
	private void Start() { }

	// RVA: 0xE6E370 Offset: 0xE6A370 VA: 0xE6E370
	private void Update() { }

	// RVA: 0xE6E750 Offset: 0xE6A750 VA: 0xE6E750
	private void Perform(Action action) { }

	// RVA: 0xE6E7CC Offset: 0xE6A7CC VA: 0xE6E7CC
	public void SetMainPlayer(PlayerMain mainPlayer) { }

	// RVA: 0xE6E7D4 Offset: 0xE6A7D4 VA: 0xE6E7D4
	public void OpenByChatHistoryClick(string cid, string name) { }

	// RVA: 0xE6E8E4 Offset: 0xE6A8E4 VA: 0xE6E8E4
	public void Open(Position targetPosition, bool autoPickObject = True) { }

	// RVA: 0xE6E9F0 Offset: 0xE6A9F0 VA: 0xE6E9F0
	private void RenderOwner(Params.Owner entryOwner) { }

	// RVA: 0xE6F14C Offset: 0xE6B14C VA: 0xE6F14C
	public void SwitchScrolling() { }

	// RVA: 0xE6E570 Offset: 0xE6A570 VA: 0xE6E570
	public void Close() { }

	// RVA: 0xE6F434 Offset: 0xE6B434 VA: 0xE6F434
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE6F510 Offset: 0xE6B510 VA: 0xE6F510
	private void <Start>b__22_0() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HotkeyAssignment.<>c // TypeDefIndex: 2572
{
	// Fields
	public static readonly HotkeyAssignment.<>c <>9; // 0x0
	public static UnityAction <>9__10_4; // 0x8

	// Methods

	// RVA: 0xE72824 Offset: 0xE6E824 VA: 0xE72824
	private static void .cctor() { }

	// RVA: 0xE7288C Offset: 0xE6E88C VA: 0xE7288C
	public void .ctor() { }

	// RVA: 0xE72894 Offset: 0xE6E894 VA: 0xE72894
	internal void <Start>b__10_4() { }
}

// Namespace: game.ui
public class HotkeyAssignment : MonoBehaviour // TypeDefIndex: 2573
{
	// Fields
	[SerializeField]
	private Image framedImage; // 0x20
	[SerializeField]
	private Button Number1; // 0x28
	[SerializeField]
	private Button Number2; // 0x30
	[SerializeField]
	private Button Number3; // 0x38
	[SerializeField]
	private TextMeshProUGUI itemNameTmp; // 0x40
	[SerializeField]
	private TextMeshProUGUI closeButtonTmp; // 0x48
	[SerializeField]
	private TextMeshProUGUI clearButtonTmp; // 0x50
	[SerializeField]
	private Button closeButton; // 0x58
	[SerializeField]
	private Button clearButton; // 0x60
	private Item itemSelect; // 0x68

	// Methods

	// RVA: 0xE71390 Offset: 0xE6D390 VA: 0xE71390
	private void Start() { }

	// RVA: 0xE71650 Offset: 0xE6D650 VA: 0xE71650
	public void Open(Item item) { }

	// RVA: 0xE71770 Offset: 0xE6D770 VA: 0xE71770
	private void LoadHotKeyData(RepeatedField<int> data) { }

	// RVA: 0xE7206C Offset: 0xE6E06C VA: 0xE7206C
	private void RenderRemove(GameObject gameObject) { }

	// RVA: 0xE71B80 Offset: 0xE6DB80 VA: 0xE71B80
	private void RenderItem(GameObject gameObject, Item item) { }

	// RVA: 0xE72460 Offset: 0xE6E460 VA: 0xE72460
	public void ProtocolHotkeyItemList(HotkeyItemList message) { }

	// RVA: 0xE724B8 Offset: 0xE6E4B8 VA: 0xE724B8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE724C0 Offset: 0xE6E4C0 VA: 0xE724C0
	private void <Start>b__10_0() { }

	[CompilerGenerated]
	// RVA: 0xE725B0 Offset: 0xE6E5B0 VA: 0xE725B0
	private void <Start>b__10_1() { }

	[CompilerGenerated]
	// RVA: 0xE726A4 Offset: 0xE6E6A4 VA: 0xE726A4
	private void <Start>b__10_2() { }

	[CompilerGenerated]
	// RVA: 0xE72798 Offset: 0xE6E798 VA: 0xE72798
	private void <Start>b__10_3() { }
}

// Namespace: 
public enum ItemDetailPc.Button // TypeDefIndex: 2574
{
	// Fields
	public int value__; // 0x0
	public const ItemDetailPc.Button equip = 0;
	public const ItemDetailPc.Button use = 1;
	public const ItemDetailPc.Button sell = 2;
	public const ItemDetailPc.Button share = 3;
	public const ItemDetailPc.Button unequip = 4;
	public const ItemDetailPc.Button send = 5;
	public const ItemDetailPc.Button retrieve = 6;
	public const ItemDetailPc.Button trade = 7;
	public const ItemDetailPc.Button remove = 8;
	public const ItemDetailPc.Button throwAway = 9;
	public const ItemDetailPc.Button hotkey = 10;
	public const ItemDetailPc.Button unmerge = 11;
	public const ItemDetailPc.Button sendMessage = 12;
	public const ItemDetailPc.Button askPrice = 13;
	public const ItemDetailPc.Button buy = 14;
	public const ItemDetailPc.Button playerInfo = 15;
	public const ItemDetailPc.Button salestall = 16;
}

// Namespace: game.ui
public class ItemDetailPc : MonoBehaviour // TypeDefIndex: 2575
{
	// Fields
	[SerializeField]
	private GameObject denyRaycastGo; // 0x20
	[SerializeField]
	private Button denyRaycastButton; // 0x28
	[SerializeField]
	private ItemDetailPcViewport viewportSelf; // 0x30
	[SerializeField]
	private ItemDetailPcViewport viewportOther; // 0x38
	[SerializeField]
	private ItemDetailPcBuy buyDetails; // 0x40

	// Methods

	// RVA: 0xE72968 Offset: 0xE6E968 VA: 0xE72968
	private void Start() { }

	// RVA: 0xE6AF60 Offset: 0xE66F60 VA: 0xE6AF60
	public void Close() { }

	// RVA: 0xE729F8 Offset: 0xE6E9F8 VA: 0xE729F8
	public void OpenCompare(Item equip, Item compare, Dictionary<ItemDetailPc.Button, Action> buttons) { }

	// RVA: 0xE72DA8 Offset: 0xE6EDA8 VA: 0xE72DA8
	public void Open(Item item, int activeHiddenMagicCount, string activeHiddenDesc) { }

	// RVA: 0xE72DE4 Offset: 0xE6EDE4 VA: 0xE72DE4
	public void Open(PlayerSelfBagarate.Cell bagItem, Item equipItem) { }

	// RVA: 0xE6BF60 Offset: 0xE67F60 VA: 0xE6BF60
	public void Open(Item item, Dictionary<ItemDetailPc.Button, Action> buttons) { }

	// RVA: 0xE731D4 Offset: 0xE6F1D4 VA: 0xE731D4
	public void OpenWithAppendInfo(Item item, Dictionary<ItemDetailPc.Button, Action> buttonsCallback, string infoEndOfRequiredMagic) { }

	// RVA: 0xE73368 Offset: 0xE6F368 VA: 0xE73368
	public void OpenBuy(Item item, ShopData shopdata, int itemindex) { }

	// RVA: 0xE73D58 Offset: 0xE6FD58 VA: 0xE73D58
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE73D60 Offset: 0xE6FD60 VA: 0xE73D60
	private void <Start>b__5_0() { }

	[CompilerGenerated]
	// RVA: 0xE73DD0 Offset: 0xE6FDD0 VA: 0xE73DD0
	private void <OpenBuy>b__13_0() { }
}

// Namespace: game.ui
public class ItemDetailPcBuy : MonoBehaviour // TypeDefIndex: 2576
{
	// Fields
	[SerializeField]
	private Image framed; // 0x20
	[SerializeField]
	private TextMeshProUGUI itemName; // 0x28
	[SerializeField]
	private TextMeshProUGUI buyDes; // 0x30
	[SerializeField]
	private TMP_InputField quantityInput; // 0x38
	[SerializeField]
	private TextMeshProUGUI priceTmp; // 0x40
	[SerializeField]
	private Image priceIcon; // 0x48
	[SerializeField]
	private Button buttonAdd; // 0x50
	[SerializeField]
	private Button buttonMinus; // 0x58
	[SerializeField]
	private Button funcConfirmButton; // 0x60
	[SerializeField]
	private TextMeshProUGUI funcConfirmTmp; // 0x68
	[SerializeField]
	private Button funcCancelButton; // 0x70
	[SerializeField]
	private TextMeshProUGUI funcCancelTmp; // 0x78
	[SerializeField]
	private Button funcBuyMaxButton; // 0x80
	[SerializeField]
	private TextMeshProUGUI funcBuyMaxTmp; // 0x88
	[SerializeField]
	private Image numpadFramed; // 0x90
	[SerializeField]
	private Button numpadSpace; // 0x98
	[SerializeField]
	private Button numpadNum0; // 0xA0
	[SerializeField]
	private Button numpadNum1; // 0xA8
	[SerializeField]
	private Button numpadNum2; // 0xB0
	[SerializeField]
	private Button numpadNum3; // 0xB8
	[SerializeField]
	private Button numpadNum4; // 0xC0
	[SerializeField]
	private Button numpadNum5; // 0xC8
	[SerializeField]
	private Button numpadNum6; // 0xD0
	[SerializeField]
	private Button numpadNum7; // 0xD8
	[SerializeField]
	private Button numpadNum8; // 0xE0
	[SerializeField]
	private Button numpadNum9; // 0xE8
	[SerializeField]
	private Button numpadConfirm; // 0xF0
	[SerializeField]
	private Button numpadCancel; // 0xF8
	private Item item; // 0x100
	private ShopData shopdata; // 0x108
	private ShopItem shopitem; // 0x110
	private int shopItemIndex; // 0x118
	private Action onCancel; // 0x120
	private int quantityMaximum; // 0x128
	private int quantityCurrently; // 0x12C
	private float numpadPressEffectFloat; // 0x130
	private Button numpadPressEffectButton; // 0x138

	// Methods

	// RVA: 0xE73DD4 Offset: 0xE6FDD4 VA: 0xE73DD4
	private void Start() { }

	// RVA: 0xE74688 Offset: 0xE70688 VA: 0xE74688
	private void Update() { }

	// RVA: 0xE74768 Offset: 0xE70768 VA: 0xE74768
	private void NumpadOnClick(Button button, int numValue) { }

	// RVA: 0xE74BF8 Offset: 0xE70BF8 VA: 0xE74BF8
	private void SendBuyItem(int quantity) { }

	// RVA: 0xE74910 Offset: 0xE70910 VA: 0xE74910
	private void OnInputFieldQuantityValueChanged(string newValue, bool applyToInput = False) { }

	// RVA: 0xE735B0 Offset: 0xE6F5B0 VA: 0xE735B0
	public void Open(Item item, ShopData shopdata, int itemindex, Action onCancel) { }

	// RVA: 0xE74EF8 Offset: 0xE70EF8 VA: 0xE74EF8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE74F08 Offset: 0xE70F08 VA: 0xE74F08
	private void <Start>b__37_0(string _value) { }

	[CompilerGenerated]
	// RVA: 0xE74F10 Offset: 0xE70F10 VA: 0xE74F10
	private void <Start>b__37_1() { }

	[CompilerGenerated]
	// RVA: 0xE74FB0 Offset: 0xE70FB0 VA: 0xE74FB0
	private void <Start>b__37_2() { }

	[CompilerGenerated]
	// RVA: 0xE75050 Offset: 0xE71050 VA: 0xE75050
	private void <Start>b__37_3() { }

	[CompilerGenerated]
	// RVA: 0xE750EC Offset: 0xE710EC VA: 0xE750EC
	private void <Start>b__37_4() { }

	[CompilerGenerated]
	// RVA: 0xE750F4 Offset: 0xE710F4 VA: 0xE750F4
	private void <Start>b__37_5() { }

	[CompilerGenerated]
	// RVA: 0xE75120 Offset: 0xE71120 VA: 0xE75120
	private void <Start>b__37_6() { }

	[CompilerGenerated]
	// RVA: 0xE75144 Offset: 0xE71144 VA: 0xE75144
	private void <Start>b__37_7() { }

	[CompilerGenerated]
	// RVA: 0xE75168 Offset: 0xE71168 VA: 0xE75168
	private void <Start>b__37_8() { }

	[CompilerGenerated]
	// RVA: 0xE752BC Offset: 0xE712BC VA: 0xE752BC
	private void <Start>b__37_9() { }

	[CompilerGenerated]
	// RVA: 0xE752C8 Offset: 0xE712C8 VA: 0xE752C8
	private void <Start>b__37_10() { }

	[CompilerGenerated]
	// RVA: 0xE752D4 Offset: 0xE712D4 VA: 0xE752D4
	private void <Start>b__37_11() { }

	[CompilerGenerated]
	// RVA: 0xE752E0 Offset: 0xE712E0 VA: 0xE752E0
	private void <Start>b__37_12() { }

	[CompilerGenerated]
	// RVA: 0xE752EC Offset: 0xE712EC VA: 0xE752EC
	private void <Start>b__37_13() { }

	[CompilerGenerated]
	// RVA: 0xE752F8 Offset: 0xE712F8 VA: 0xE752F8
	private void <Start>b__37_14() { }

	[CompilerGenerated]
	// RVA: 0xE75304 Offset: 0xE71304 VA: 0xE75304
	private void <Start>b__37_15() { }

	[CompilerGenerated]
	// RVA: 0xE75310 Offset: 0xE71310 VA: 0xE75310
	private void <Start>b__37_16() { }

	[CompilerGenerated]
	// RVA: 0xE7531C Offset: 0xE7131C VA: 0xE7531C
	private void <Start>b__37_17() { }

	[CompilerGenerated]
	// RVA: 0xE75328 Offset: 0xE71328 VA: 0xE75328
	private void <Start>b__37_18() { }
}

// Namespace: game.ui
public class ItemDetailPcLayerFastUseForContains : MonoBehaviour // TypeDefIndex: 2577
{
	// Fields
	[SerializeField]
	private ItemDetailPc itemDetailPc; // 0x20
	[SerializeField]
	private Button buttonComp; // 0x28
	private float displayRemainingSeconds; // 0x30
	private Item latestItem; // 0x38
	private Dictionary<ItemDetailPc.Button, Action> latestButtons; // 0x40

	// Methods

	// RVA: 0xE75334 Offset: 0xE71334 VA: 0xE75334
	private void Start() { }

	// RVA: 0xE753C4 Offset: 0xE713C4 VA: 0xE753C4
	private void Update() { }

	// RVA: 0xE75420 Offset: 0xE71420 VA: 0xE75420
	public void Open(Item item, Dictionary<ItemDetailPc.Button, Action> buttons) { }

	// RVA: 0xE754CC Offset: 0xE714CC VA: 0xE754CC
	private void ClickPerform() { }

	// RVA: 0xE75D78 Offset: 0xE71D78 VA: 0xE75D78
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE75D80 Offset: 0xE71D80 VA: 0xE75D80
	private void <ClickPerform>b__8_0() { }

	[CompilerGenerated]
	// RVA: 0xE75E2C Offset: 0xE71E2C VA: 0xE75E2C
	private void <ClickPerform>b__8_1() { }
}

// Namespace: game.ui
public class ItemDetailPcLayerFastUseForInvoke : MonoBehaviour // TypeDefIndex: 2578
{
	// Fields
	[SerializeField]
	private ItemDetailPc itemDetailPc; // 0x20
	[SerializeField]
	private Button buttonComp; // 0x28
	private float displayRemainingSeconds; // 0x30
	private Item latestItem; // 0x38
	private Dictionary<ItemDetailPc.Button, Action> latestButtons; // 0x40

	// Methods

	// RVA: 0xE75ED8 Offset: 0xE71ED8 VA: 0xE75ED8
	private void Start() { }

	// RVA: 0xE75F68 Offset: 0xE71F68 VA: 0xE75F68
	private void Update() { }

	// RVA: 0xE75FC4 Offset: 0xE71FC4 VA: 0xE75FC4
	public void Open(Item item, Dictionary<ItemDetailPc.Button, Action> buttons) { }

	// RVA: 0xE76070 Offset: 0xE72070 VA: 0xE76070
	private void ClickPerform() { }

	// RVA: 0xE76130 Offset: 0xE72130 VA: 0xE76130
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ItemDetailPcViewport.<>c__DisplayClass52_0 // TypeDefIndex: 2579
{
	// Fields
	public Action _action; // 0x10
	public ItemDetailPcViewport <>4__this; // 0x18

	// Methods

	// RVA: 0xE7A1EC Offset: 0xE761EC VA: 0xE7A1EC
	public void .ctor() { }

	// RVA: 0xE7A1F4 Offset: 0xE761F4 VA: 0xE7A1F4
	internal void <SetupFunctions>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ItemDetailPcViewport.<>c__DisplayClass62_0 // TypeDefIndex: 2580
{
	// Fields
	public ItemDetailPcViewport <>4__this; // 0x10
	public PlayerSelfBagarate.Cell bagItem; // 0x18
	public string infoEndOfItemName; // 0x20
	public Dictionary<ItemDetailPc.Button, Action> buttons; // 0x28

	// Methods

	// RVA: 0xE7A28C Offset: 0xE7628C VA: 0xE7A28C
	public void .ctor() { }

	// RVA: 0xE7A294 Offset: 0xE76294 VA: 0xE7A294
	internal void <OpenForBagarate>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ItemDetailPcViewport.<>c__DisplayClass63_0 // TypeDefIndex: 2581
{
	// Fields
	public ItemDetailPcViewport <>4__this; // 0x10
	public int activeHiddenMagicCount; // 0x18
	public string activeHiddenDesc; // 0x20
	public Dictionary<ItemDetailPc.Button, Action> buttons; // 0x28

	// Methods

	// RVA: 0xE7A31C Offset: 0xE7631C VA: 0xE7A31C
	public void .ctor() { }

	// RVA: 0xE7A324 Offset: 0xE76324 VA: 0xE7A324
	internal void <Open>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ItemDetailPcViewport.<>c__DisplayClass64_0 // TypeDefIndex: 2582
{
	// Fields
	public ItemDetailPcViewport <>4__this; // 0x10
	public Dictionary<ItemDetailPc.Button, Action> buttons; // 0x18

	// Methods

	// RVA: 0xE7A3B8 Offset: 0xE763B8 VA: 0xE7A3B8
	public void .ctor() { }

	// RVA: 0xE7A3C0 Offset: 0xE763C0 VA: 0xE7A3C0
	internal void <Open>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ItemDetailPcViewport.<>c__DisplayClass66_0 // TypeDefIndex: 2583
{
	// Fields
	public ItemDetailPcViewport <>4__this; // 0x10
	public string infoEndOfRequiredMagic; // 0x18
	public Dictionary<ItemDetailPc.Button, Action> buttons; // 0x20

	// Methods

	// RVA: 0xE7A454 Offset: 0xE76454 VA: 0xE7A454
	public void .ctor() { }

	// RVA: 0xE7A45C Offset: 0xE7645C VA: 0xE7A45C
	internal void <OpenWithAppendInfo>b__0() { }
}

// Namespace: game.ui
public class ItemDetailPcViewport : MonoBehaviour // TypeDefIndex: 2584
{
	// Fields
	[SerializeField]
	private ItemDetailPc itemDetail; // 0x20
	[SerializeField]
	private ItemDetailPcLayerFastUseForContains fastUseContains; // 0x28
	[SerializeField]
	private ItemDetailPcLayerFastUseForInvoke fastUseInvoke; // 0x30
	[SerializeField]
	private Image linerTopImage; // 0x38
	[SerializeField]
	private Image linerBottomImage; // 0x40
	[SerializeField]
	private Button closeArea; // 0x48
	[SerializeField]
	private RectTransform viewportRect; // 0x50
	[SerializeField]
	private RectTransform thumbnailBackgroundRect; // 0x58
	[SerializeField]
	private Image thumbnailImage; // 0x60
	[SerializeField]
	private RectTransform thumbnailImageRect; // 0x68
	[SerializeField]
	private ScrollRect contentScrollRect; // 0x70
	[SerializeField]
	private TextMeshProUGUI contentDescriptionTmp; // 0x78
	[SerializeField]
	private float appendIfSourceBottomSize; // 0x80
	[SerializeField]
	private float appendElseSourceBottomSize; // 0x84
	[SerializeField]
	private GameObject buttonShowFuncsGo; // 0x88
	[SerializeField]
	private Button buttonShowFuncs; // 0x90
	[SerializeField]
	private GameObject buttonHideFuncsGo; // 0x98
	[SerializeField]
	private Button buttonHideFuncs; // 0xA0
	[SerializeField]
	private RectTransform functionsRect; // 0xA8
	[SerializeField]
	private GameObject funcBlackSpacingGo; // 0xB0
	[SerializeField]
	private Button funcPlayerInfoButton; // 0xB8
	[SerializeField]
	private Button funcSalestallButton; // 0xC0
	[SerializeField]
	private Button funcThrowButton; // 0xC8
	[SerializeField]
	private Button funcSellButton; // 0xD0
	[SerializeField]
	private Button funcBuyButton; // 0xD8
	[SerializeField]
	private Button funcUnequipButton; // 0xE0
	[SerializeField]
	private Button funcShareButton; // 0xE8
	[SerializeField]
	private Button funcRetrieveButton; // 0xF0
	[SerializeField]
	private Button funcSendButton; // 0xF8
	[SerializeField]
	private Button funcMessageButton; // 0x100
	[SerializeField]
	private Button funcAskButton; // 0x108
	[SerializeField]
	private Button funcTradeButton; // 0x110
	[SerializeField]
	private Button funcEquipButton; // 0x118
	[SerializeField]
	private Button funcHotkeyButton; // 0x120
	[SerializeField]
	private Button funcMegerButton; // 0x128
	[SerializeField]
	private Button funcUseButton; // 0x130
	private readonly Queue<Action> onStartActions; // 0x138
	private Dictionary<ItemDetailPc.Button, Button> functionMapping; // 0x140
	private bool isStarted; // 0x148
	private Item item; // 0x150
	private bool hasItemSource; // 0x158
	private bool lastDisplayFunctionIsDisplayed; // 0x159
	public static readonly string[] SeriesColorCode; // 0x0
	public static readonly string[] SeriesName; // 0x8
	private static readonly Vector2 thumbnailBackgroundSize120x120; // 0x10
	private static readonly Vector2 thumbnailBackgroundSize75x75; // 0x18
	private static readonly Vector2 thumbnailBackgroundSize120x75; // 0x20
	private static readonly Vector2 thumbnailBackgroundSize100x160; // 0x28
	private static readonly ItemImage.ThumbnailRectOffset thumbnailImageOffset; // 0x30
	private static readonly ItemImage.ThumbnailRectOffset thumbnailImageHelmSpec1; // 0x38
	private static bool thumbnailImageHelmResized; // 0x40

	// Methods

	// RVA: 0xE76138 Offset: 0xE72138 VA: 0xE76138
	private void Start() { }

	// RVA: 0xE76824 Offset: 0xE72824 VA: 0xE76824
	private void Perform(Action action) { }

	// RVA: 0xE768A0 Offset: 0xE728A0 VA: 0xE768A0
	public static string SetupInfo_RequiredDesc(Item item, string falseColor = "#ff3737") { }

	// RVA: 0xE76CE8 Offset: 0xE72CE8 VA: 0xE76CE8
	public static string SetupInfo_BasicDesc(Item item, bool usingDurabilityMaximum) { }

	// RVA: 0xE75978 Offset: 0xE71978 VA: 0xE75978
	public static bool IsPassedRequiredMagic(Attrib attribEntry) { }

	// RVA: 0xE76EB4 Offset: 0xE72EB4 VA: 0xE76EB4
	public static string SetupInfo_Source(Item item) { }

	// RVA: 0xE772A4 Offset: 0xE732A4 VA: 0xE772A4
	public static string SetupInfo_MagicDesc(Item item, int activeHiddenMagicCount = 0, string blueColor = "#6c6cff", string goldColor = "#feff00") { }

	// RVA: 0xE775C8 Offset: 0xE735C8 VA: 0xE775C8
	public static string GetSeriesColorCode(int seriesIndex) { }

	// RVA: 0xE77768 Offset: 0xE73768 VA: 0xE77768
	public void SetupFunctions(bool enabled, Dictionary<ItemDetailPc.Button, Action> buttons) { }

	// RVA: 0xE77E28 Offset: 0xE73E28 VA: 0xE77E28
	private void SetupInfo(int activeHiddenMagicCount = 0, string activeHiddenDesc, string infoEndOfItemName, string infoEndOfRequiredMagic, bool usingDurabilityMaximum = False) { }

	// RVA: 0xE786A4 Offset: 0xE746A4 VA: 0xE786A4
	private void SetUpSize() { }

	// RVA: 0xE72E4C Offset: 0xE6EE4C VA: 0xE72E4C
	public void OpenForBagarate(PlayerSelfBagarate.Cell bagItem) { }

	// RVA: 0xE72BC8 Offset: 0xE6EBC8 VA: 0xE72BC8
	public void Open(Item item, int activeHiddenMagicCount, string activeHiddenDesc) { }

	// RVA: 0xE72A7C Offset: 0xE6EA7C VA: 0xE72A7C
	public void Open(Item item, Dictionary<ItemDetailPc.Button, Action> buttons) { }

	// RVA: 0xE734D4 Offset: 0xE6F4D4 VA: 0xE734D4
	public void OpenForBuy(Item item) { }

	// RVA: 0xE73210 Offset: 0xE6F210 VA: 0xE73210
	public void OpenWithAppendInfo(Item item, Dictionary<ItemDetailPc.Button, Action> buttons, string infoEndOfRequiredMagic) { }

	// RVA: 0xE78A84 Offset: 0xE74A84 VA: 0xE78A84
	public void .ctor() { }

	// RVA: 0xE78B18 Offset: 0xE74B18 VA: 0xE78B18
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xE78EA8 Offset: 0xE74EA8 VA: 0xE78EA8
	private void <Start>b__42_0() { }

	[CompilerGenerated]
	// RVA: 0xE78F24 Offset: 0xE74F24 VA: 0xE78F24
	private void <Start>b__42_1() { }

	[CompilerGenerated]
	// RVA: 0xE78FA4 Offset: 0xE74FA4 VA: 0xE78FA4
	private void <Start>b__42_2() { }

	[CompilerGenerated]
	// RVA: 0xE79018 Offset: 0xE75018 VA: 0xE79018
	private void <SetupFunctions>b__52_1() { }

	[CompilerGenerated]
	// RVA: 0xE79314 Offset: 0xE75314 VA: 0xE79314
	private void <SetupFunctions>b__52_9() { }

	[CompilerGenerated]
	// RVA: 0xE793F8 Offset: 0xE753F8 VA: 0xE793F8
	private void <SetupFunctions>b__52_2() { }

	[CompilerGenerated]
	// RVA: 0xE79660 Offset: 0xE75660 VA: 0xE79660
	private void <SetupFunctions>b__52_10() { }

	[CompilerGenerated]
	// RVA: 0xE79748 Offset: 0xE75748 VA: 0xE79748
	private void <SetupFunctions>b__52_3() { }

	[CompilerGenerated]
	// RVA: 0xE79854 Offset: 0xE75854 VA: 0xE79854
	private void <SetupFunctions>b__52_11(string autoreply) { }

	[CompilerGenerated]
	// RVA: 0xE79964 Offset: 0xE75964 VA: 0xE79964
	private void <SetupFunctions>b__52_12(string autoreply) { }

	[CompilerGenerated]
	// RVA: 0xE799D4 Offset: 0xE759D4 VA: 0xE799D4
	private void <SetupFunctions>b__52_4() { }

	[CompilerGenerated]
	// RVA: 0xE79DBC Offset: 0xE75DBC VA: 0xE79DBC
	private void <SetupFunctions>b__52_13() { }

	[CompilerGenerated]
	// RVA: 0xE79E68 Offset: 0xE75E68 VA: 0xE79E68
	private void <SetupFunctions>b__52_14() { }

	[CompilerGenerated]
	// RVA: 0xE79F14 Offset: 0xE75F14 VA: 0xE79F14
	private void <SetupFunctions>b__52_5() { }

	[CompilerGenerated]
	// RVA: 0xE79F80 Offset: 0xE75F80 VA: 0xE79F80
	private void <SetupFunctions>b__52_6() { }

	[CompilerGenerated]
	// RVA: 0xE79FDC Offset: 0xE75FDC VA: 0xE79FDC
	private void <SetupFunctions>b__52_7() { }

	[CompilerGenerated]
	// RVA: 0xE7A038 Offset: 0xE76038 VA: 0xE7A038
	private void <SetupFunctions>b__52_8() { }

	[CompilerGenerated]
	// RVA: 0xE7A120 Offset: 0xE76120 VA: 0xE7A120
	private void <OpenForBuy>b__65_0() { }
}

// Namespace: game.ui
public class ButtonJoystickNoRaycast : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler // TypeDefIndex: 2585
{
	// Fields
	private bool joystickPointerDown; // 0x20
	[CompilerGenerated]
	private int <joystickOnMoving>k__BackingField; // 0x24

	// Properties
	public int joystickOnMoving { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xE7A4F0 Offset: 0xE764F0 VA: 0xE7A4F0
	public int get_joystickOnMoving() { }

	[CompilerGenerated]
	// RVA: 0xE7A4F8 Offset: 0xE764F8 VA: 0xE7A4F8
	private void set_joystickOnMoving(int value) { }

	// RVA: 0xE7A500 Offset: 0xE76500 VA: 0xE7A500 Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xE7A52C Offset: 0xE7652C VA: 0xE7A52C Slot: 5
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xE7A5F8 Offset: 0xE765F8 VA: 0xE7A5F8 Slot: 6
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xE7A688 Offset: 0xE76688 VA: 0xE7A688
	public void .ctor() { }
}

// Namespace: game.ui
public class ButtonJoystickSupporting : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler, IPointerClickHandler // TypeDefIndex: 2586
{
	// Fields
	private bool calledPointerDown; // 0x20
	private bool joystickPointerDown; // 0x21
	[CompilerGenerated]
	private int <joystickOnMoving>k__BackingField; // 0x24

	// Properties
	public int joystickOnMoving { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xE7A698 Offset: 0xE76698 VA: 0xE7A698
	public int get_joystickOnMoving() { }

	[CompilerGenerated]
	// RVA: 0xE7A6A0 Offset: 0xE766A0 VA: 0xE7A6A0
	private void set_joystickOnMoving(int value) { }

	// RVA: 0xE7A6A8 Offset: 0xE766A8 VA: 0xE7A6A8 Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xE7A6E8 Offset: 0xE766E8 VA: 0xE7A6E8 Slot: 5
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xE7A7B4 Offset: 0xE767B4 VA: 0xE7A7B4 Slot: 6
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xE7A848 Offset: 0xE76848 VA: 0xE7A848 Slot: 7
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0xE7AB7C Offset: 0xE76B7C VA: 0xE7AB7C
	public void .ctor() { }
}

// Namespace: game.ui
public class ShareItemAutoreplyPC : MonoBehaviour // TypeDefIndex: 2587
{
	// Fields
	[SerializeField]
	private Image framedImage; // 0x20
	[SerializeField]
	private TextMeshProUGUI receiveMessage; // 0x28
	[SerializeField]
	private TMP_InputField replyInput; // 0x30
	[SerializeField]
	private Button forcusMessageButton; // 0x38
	[SerializeField]
	private TextMeshProUGUI forcusMessageTmp; // 0x40
	[SerializeField]
	private Button seenLaterButton; // 0x48
	[SerializeField]
	private TextMeshProUGUI seenLaterTmp; // 0x50
	private Action<string> onForcusMessageAction; // 0x58
	private Action<string> onSeenLaterAction; // 0x60

	// Methods

	// RVA: 0xE7AB8C Offset: 0xE76B8C VA: 0xE7AB8C
	private void Start() { }

	// RVA: 0xE7AEA4 Offset: 0xE76EA4 VA: 0xE7AEA4
	public void Open(string itemName, Action<string> onForcusMessageAction, Action<string> onSeenLaterAction) { }

	// RVA: 0xE7AF84 Offset: 0xE76F84 VA: 0xE7AF84
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE7AF8C Offset: 0xE76F8C VA: 0xE7AF8C
	private void <Start>b__9_0() { }

	[CompilerGenerated]
	// RVA: 0xE7B040 Offset: 0xE77040 VA: 0xE7B040
	private void <Start>b__9_1() { }
}

// Namespace: game.ui
public class MinistateDescription : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler // TypeDefIndex: 2588
{
	// Fields
	private int joystickOnMoving; // 0x20

	// Methods

	// RVA: 0xE7B0F4 Offset: 0xE770F4 VA: 0xE7B0F4 Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xE7B188 Offset: 0xE77188 VA: 0xE7B188 Slot: 5
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xE7B214 Offset: 0xE77214 VA: 0xE7B214 Slot: 6
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xE7B2A0 Offset: 0xE772A0 VA: 0xE7B2A0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MinistateFramed.<>c__DisplayClass25_0 // TypeDefIndex: 2589
{
	// Fields
	public MinistateFramed <>4__this; // 0x10
	public int skillId; // 0x18
	public int lefttime; // 0x1C

	// Methods

	// RVA: 0xE7D750 Offset: 0xE79750 VA: 0xE7D750
	public void .ctor() { }

	// RVA: 0xE7F408 Offset: 0xE7B408 VA: 0xE7F408
	internal void <SetSkill>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MinistateFramed.<>c__DisplayClass25_1 // TypeDefIndex: 2590
{
	// Fields
	public MinistateIconSkill newState; // 0x10
	public MinistateFramed.<>c__DisplayClass25_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xE7F71C Offset: 0xE7B71C VA: 0xE7F71C
	public void .ctor() { }

	// RVA: 0xE7F754 Offset: 0xE7B754 VA: 0xE7F754
	internal void <SetSkill>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MinistateFramed.<>c__DisplayClass30_0 // TypeDefIndex: 2591
{
	// Fields
	public MagicScriptBase magicScriptBase; // 0x10
	public MinistateIconSkill newState; // 0x18
	public MinistateFramed <>4__this; // 0x20

	// Methods

	// RVA: 0xE7E96C Offset: 0xE7A96C VA: 0xE7E96C
	public void .ctor() { }

	// RVA: 0xE7FA30 Offset: 0xE7BA30 VA: 0xE7FA30
	internal void <SetItemMagicscript>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MinistateFramed.<>c__DisplayClass32_0 // TypeDefIndex: 2592
{
	// Fields
	public AddMinistateKey message; // 0x10
	public MinistateIconSkill newState; // 0x18
	public MinistateFramed <>4__this; // 0x20

	// Methods

	// RVA: 0xE7EE9C Offset: 0xE7AE9C VA: 0xE7EE9C
	public void .ctor() { }

	// RVA: 0xE7FC64 Offset: 0xE7BC64 VA: 0xE7FC64
	internal void <AddMinistateKey>b__0() { }
}

// Namespace: game.ui
public class MinistateFramed : MonoBehaviour // TypeDefIndex: 2593
{
	// Fields
	private static Vector2 staticPositionOrigin; // 0x0
	private static Vector2 staticPositionNoChatInput; // 0x8
	[SerializeField]
	private RectTransform rectTransform; // 0x20
	[SerializeField]
	private MinistateIconVisible iconVisible; // 0x28
	[SerializeField]
	private MinistateIconSkill iconSkillTemplate; // 0x30
	[SerializeField]
	private RectTransform descriptionRect; // 0x38
	[SerializeField]
	private TextMeshProUGUI descriptionText; // 0x40
	[SerializeField]
	private Button descriptionButton; // 0x48
	private readonly ConcurrentDictionary<int, MinistateIconSkill> skillMapping; // 0x50
	private readonly ConcurrentDictionary<int, MinistateIconSkill> itemMagicscriptMapping; // 0x58
	private readonly ConcurrentDictionary<string, MinistateIconSkill> keyMapping; // 0x60
	private readonly List<int> skillToRemove; // 0x68
	private readonly List<int> itemToRemove; // 0x70
	private readonly List<string> keyToRemove; // 0x78
	private bool isHidenCommanded; // 0x80
	private bool isDenyChangePingFpsPosition; // 0x81
	private readonly Queue<Action> onStartActions; // 0x88
	private bool isStarted; // 0x90

	// Methods

	// RVA: 0xE7B2B0 Offset: 0xE772B0 VA: 0xE7B2B0
	private void Awake() { }

	// RVA: 0xE7B2DC Offset: 0xE772DC VA: 0xE7B2DC
	private void Start() { }

	// RVA: 0xE7B434 Offset: 0xE77434 VA: 0xE7B434
	private void Perform(Action action) { }

	// RVA: 0xE7B4B0 Offset: 0xE774B0 VA: 0xE7B4B0
	public void Activate() { }

	// RVA: 0xE7C5D4 Offset: 0xE785D4 VA: 0xE7C5D4
	public void SetPositionOrigin() { }

	// RVA: 0xE7C74C Offset: 0xE7874C VA: 0xE7C74C
	public void SetPositionNoInputChat() { }

	// RVA: 0xE7C834 Offset: 0xE78834 VA: 0xE7C834
	private void HidenCommamded() { }

	// RVA: 0xE7D5E4 Offset: 0xE795E4 VA: 0xE7D5E4
	public void SetSkill(ReadOnlySpan<byte> data) { }

	// RVA: 0xE7D79C Offset: 0xE7979C VA: 0xE7D79C
	public void RemoveSkill(int skillid) { }

	// RVA: 0xE7D8F4 Offset: 0xE798F4 VA: 0xE7D8F4
	public void RemoveItemMagic(ReadOnlySpan<byte> data) { }

	// RVA: 0xE7DA7C Offset: 0xE79A7C VA: 0xE7DA7C
	public void Clear() { }

	// RVA: 0xE7E104 Offset: 0xE7A104 VA: 0xE7E104
	public void ClearOnDeath() { }

	// RVA: 0xE7E598 Offset: 0xE7A598 VA: 0xE7E598
	public void SetItemMagicscript(ReadOnlySpan<byte> data) { }

	// RVA: 0xE7E9F8 Offset: 0xE7A9F8 VA: 0xE7E9F8
	public bool IsExistingItemMagicscript(int particular) { }

	// RVA: 0xE7EA50 Offset: 0xE7AA50 VA: 0xE7EA50
	public void AddMinistateKey(AddMinistateKey message) { }

	// RVA: 0xE7EF2C Offset: 0xE7AF2C VA: 0xE7EF2C
	public void RemoveMinistateKey(RemoveMinistateKey message) { }

	// RVA: 0xE7F088 Offset: 0xE7B088 VA: 0xE7F088
	public void .ctor() { }

	// RVA: 0xE7F2A0 Offset: 0xE7B2A0 VA: 0xE7F2A0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xE7F304 Offset: 0xE7B304 VA: 0xE7F304
	private void <Start>b__19_0() { }

	[CompilerGenerated]
	// RVA: 0xE7F38C Offset: 0xE7B38C VA: 0xE7F38C
	private void <Start>b__19_1() { }
}

// Namespace: game.ui
public class MinistateIconSkill : MonoBehaviour // TypeDefIndex: 2594
{
	// Fields
	public const int maxTimeSeconds = 119304647;
	public const int maxReincarnationSeconds = 15;
	[SerializeField]
	private Image image; // 0x20
	[SerializeField]
	private TextMeshProUGUI label; // 0x28
	[SerializeField]
	private Button button; // 0x30
	[SerializeField]
	private ButtonJoystickSupporting ministateIconSkillImage; // 0x38
	[CompilerGenerated]
	private int <originLefttime>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <currentLefttime>k__BackingField; // 0x44
	[CompilerGenerated]
	private bool <releaseCommanded>k__BackingField; // 0x48
	public Action onClick; // 0x50
	public bool isKeepOnDeath; // 0x58

	// Properties
	public int originLefttime { get; set; }
	public int currentLefttime { get; set; }
	public bool releaseCommanded { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xE7FE74 Offset: 0xE7BE74 VA: 0xE7FE74
	public int get_originLefttime() { }

	[CompilerGenerated]
	// RVA: 0xE7FE7C Offset: 0xE7BE7C VA: 0xE7FE7C
	private void set_originLefttime(int value) { }

	[CompilerGenerated]
	// RVA: 0xE7FE84 Offset: 0xE7BE84 VA: 0xE7FE84
	public int get_currentLefttime() { }

	[CompilerGenerated]
	// RVA: 0xE7FE8C Offset: 0xE7BE8C VA: 0xE7FE8C
	private void set_currentLefttime(int value) { }

	[CompilerGenerated]
	// RVA: 0xE7FE94 Offset: 0xE7BE94 VA: 0xE7FE94
	public bool get_releaseCommanded() { }

	[CompilerGenerated]
	// RVA: 0xE7FE9C Offset: 0xE7BE9C VA: 0xE7FE9C
	private void set_releaseCommanded(bool value) { }

	// RVA: 0xE7FEA4 Offset: 0xE7BEA4 VA: 0xE7FEA4
	private void Start() { }

	// RVA: 0xE7F724 Offset: 0xE7B724 VA: 0xE7F724
	public void SetActiveLabel(bool enabled) { }

	// RVA: 0xE7D758 Offset: 0xE79758 VA: 0xE7D758
	public void SetLefttime(int lefttime) { }

	// RVA: 0xE7C444 Offset: 0xE78444 VA: 0xE7C444
	public bool LeftimeDown() { }

	// RVA: 0xE7FF34 Offset: 0xE7BF34 VA: 0xE7FF34
	public void SetLabel(int seconds) { }

	// RVA: 0xE7E974 Offset: 0xE7A974 VA: 0xE7E974
	public void SetIcon(string path) { }

	// RVA: 0xE7EEA4 Offset: 0xE7AEA4 VA: 0xE7EEA4
	public void SetIcon(string path, ushort frameIndex) { }

	// RVA: 0xE7C48C Offset: 0xE7848C VA: 0xE7C48C
	public bool Release() { }

	// RVA: 0xE80028 Offset: 0xE7C028 VA: 0xE80028
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE80030 Offset: 0xE7C030 VA: 0xE80030
	private void <Start>b__20_0() { }
}

// Namespace: game.ui
public class MinistateIconVisible : MonoBehaviour // TypeDefIndex: 2595
{
	// Fields
	private static Color hidenColor; // 0x0
	private static Color showoffImage; // 0x10
	private static Color showoffLabel; // 0x20
	[SerializeField]
	private Image image; // 0x20
	[SerializeField]
	private TextMeshProUGUI label; // 0x28
	[SerializeField]
	private Button button; // 0x30
	public Action onClick; // 0x38

	// Methods

	// RVA: 0xE800B0 Offset: 0xE7C0B0 VA: 0xE800B0
	private void Start() { }

	// RVA: 0xE7C530 Offset: 0xE78530 VA: 0xE7C530
	public void SetHiden() { }

	// RVA: 0xE7D540 Offset: 0xE79540 VA: 0xE7D540
	public void SetShowoff() { }

	// RVA: 0xE80178 Offset: 0xE7C178 VA: 0xE80178
	public void .ctor() { }

	// RVA: 0xE80180 Offset: 0xE7C180 VA: 0xE80180
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xE801F4 Offset: 0xE7C1F4 VA: 0xE801F4
	private void <Start>b__7_0() { }
}

// Namespace: 
private class NpcDialog10Pc.SelectTemplate // TypeDefIndex: 2596
{
	// Fields
	public GameObject go; // 0x10
	public TextMeshProUGUI tmp; // 0x18
	public Button button; // 0x20

	// Methods

	// RVA: 0xE8035C Offset: 0xE7C35C VA: 0xE8035C
	public void .ctor(GameObject go) { }

	// RVA: 0xE80B18 Offset: 0xE7CB18 VA: 0xE80B18
	public NpcDialog10Pc.SelectTemplate Clone(GameObject parent) { }

	// RVA: 0xE80BF0 Offset: 0xE7CBF0 VA: 0xE80BF0
	public void SetData(string text, UnityAction onClick) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcDialog10Pc.<>c__DisplayClass18_0 // TypeDefIndex: 2597
{
	// Fields
	public NpcTransferMessage message; // 0x10
	public NpcDialog10Pc <>4__this; // 0x18

	// Methods

	// RVA: 0xE80B08 Offset: 0xE7CB08 VA: 0xE80B08
	public void .ctor() { }

	// RVA: 0xE80CFC Offset: 0xE7CCFC VA: 0xE80CFC
	internal void <Open>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcDialog10Pc.<>c__DisplayClass18_1 // TypeDefIndex: 2598
{
	// Fields
	public NpcDialog10Pc.SelectTemplate field; // 0x10
	public int indexCoppied; // 0x18
	public NpcDialog10Pc.<>c__DisplayClass18_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0xE80FE8 Offset: 0xE7CFE8 VA: 0xE80FE8
	public void .ctor() { }

	// RVA: 0xE80FF0 Offset: 0xE7CFF0 VA: 0xE80FF0
	internal void <Open>b__1() { }

	// RVA: 0xE81058 Offset: 0xE7D058 VA: 0xE81058
	internal void <Open>b__2() { }
}

// Namespace: game.ui
public class NpcDialog10Pc : MonoBehaviour // TypeDefIndex: 2599
{
	// Fields
	[SerializeField]
	private Image framed; // 0x20
	[SerializeField]
	private Image thumbnailNpcImage; // 0x28
	[SerializeField]
	private Image thumbnailItemImage; // 0x30
	[SerializeField]
	private TextMeshProUGUI thumbnailNameTmp; // 0x38
	[SerializeField]
	private GameObject selectionTemplateGo; // 0x40
	[SerializeField]
	private ScrollRect layoutDescriptionScrollRect; // 0x48
	[SerializeField]
	private TextMeshProUGUI layoutDescriptionTmp; // 0x50
	[SerializeField]
	private GameObject layoutSelectionContentLeftGo; // 0x58
	[SerializeField]
	private GameObject layoutSelectionContentRightGo; // 0x60
	private Queue<Action> onStartActions; // 0x68
	private Queue<Action> onCloseActions; // 0x70
	private bool isStarted; // 0x78
	private NpcDialog10Pc.SelectTemplate selectTemplate; // 0x80

	// Methods

	// RVA: 0xE80210 Offset: 0xE7C210 VA: 0xE80210
	private void Start() { }

	// RVA: 0xE80480 Offset: 0xE7C480 VA: 0xE80480
	private void Perform(Action action) { }

	// RVA: 0xE80550 Offset: 0xE7C550 VA: 0xE80550
	private void OnClose(Action action) { }

	// RVA: 0xE805FC Offset: 0xE7C5FC VA: 0xE805FC
	public void Close(bool sound = True) { }

	// RVA: 0xE80744 Offset: 0xE7C744 VA: 0xE80744
	public void Open(NpcTransferMessage message) { }

	// RVA: 0xE80B10 Offset: 0xE7CB10 VA: 0xE80B10
	public void .ctor() { }
}

// Namespace: 
private class NpcDialogInfiPc.SelectTemplate // TypeDefIndex: 2600
{
	// Fields
	public GameObject go; // 0x10
	public TextMeshProUGUI tmp; // 0x18
	public Button button; // 0x20

	// Methods

	// RVA: 0xE812B8 Offset: 0xE7D2B8 VA: 0xE812B8
	public void .ctor(GameObject go) { }

	// RVA: 0xE81E1C Offset: 0xE7DE1C VA: 0xE81E1C
	public NpcDialogInfiPc.SelectTemplate Clone(GameObject parent) { }

	// RVA: 0xE81EF4 Offset: 0xE7DEF4 VA: 0xE81EF4
	public void SetData(string text, UnityAction onClick) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcDialogInfiPc.<>c__DisplayClass21_0 // TypeDefIndex: 2601
{
	// Fields
	public NpcDialogInfiPc <>4__this; // 0x10
	public NpcTransferMessage message; // 0x18

	// Methods

	// RVA: 0xE81A78 Offset: 0xE7DA78 VA: 0xE81A78
	public void .ctor() { }

	// RVA: 0xE82000 Offset: 0xE7E000 VA: 0xE82000
	internal void <Open>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcDialogInfiPc.<>c__DisplayClass21_1 // TypeDefIndex: 2602
{
	// Fields
	public NpcDialogInfiPc.SelectTemplate field; // 0x10
	public int indexCoppied; // 0x18
	public NpcDialogInfiPc.<>c__DisplayClass21_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0xE821E4 Offset: 0xE7E1E4 VA: 0xE821E4
	public void .ctor() { }

	// RVA: 0xE821EC Offset: 0xE7E1EC VA: 0xE821EC
	internal void <Open>b__1() { }

	// RVA: 0xE82254 Offset: 0xE7E254 VA: 0xE82254
	internal void <Open>b__2() { }
}

// Namespace: game.ui
public class NpcDialogInfiPc : MonoBehaviour // TypeDefIndex: 2603
{
	// Fields
	[SerializeField]
	private Image framed; // 0x20
	[SerializeField]
	private Image thumbnailNpcImage; // 0x28
	[SerializeField]
	private Image thumbnailItemImage; // 0x30
	[SerializeField]
	private TextMeshProUGUI thumbnailNameTmp; // 0x38
	[SerializeField]
	private Button thumbnailButton; // 0x40
	[SerializeField]
	private ScrollRect descriptionScrollRect; // 0x48
	[SerializeField]
	private TextMeshProUGUI descriptionTmp; // 0x50
	[SerializeField]
	private ScrollRect selectionScrollRect; // 0x58
	[SerializeField]
	private GameObject selectionTemplateGo; // 0x60
	[SerializeField]
	private GameObject selectionContentGo; // 0x68
	[SerializeField]
	private GridLayoutGroup selectionContentGrid; // 0x70
	private Queue<Action> onStartActions; // 0x78
	private Queue<Action> onCloseActions; // 0x80
	private bool isStarted; // 0x88
	private NpcDialogInfiPc.SelectTemplate selectTemplate; // 0x90
	private bool isVerticalSelectionLayout; // 0x98

	// Methods

	// RVA: 0xE81108 Offset: 0xE7D108 VA: 0xE81108
	private void Start() { }

	// RVA: 0xE813DC Offset: 0xE7D3DC VA: 0xE813DC
	private void Perform(Action action) { }

	// RVA: 0xE814AC Offset: 0xE7D4AC VA: 0xE814AC
	private void OnClose(Action action) { }

	// RVA: 0xE81558 Offset: 0xE7D558 VA: 0xE81558
	public void Close(bool sound = True) { }

	// RVA: 0xE816A0 Offset: 0xE7D6A0 VA: 0xE816A0
	public void Open(NpcTransferMessage message) { }

	// RVA: 0xE81A80 Offset: 0xE7DA80 VA: 0xE81A80
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE81A88 Offset: 0xE7DA88 VA: 0xE81A88
	private void <Start>b__16_0() { }
}

// Namespace: 
private class NpcDialogPc.SelectTemplate // TypeDefIndex: 2604
{
	// Fields
	public GameObject go; // 0x10
	public TextMeshProUGUI tmp; // 0x18
	public Button button; // 0x20

	// Methods

	// RVA: 0xE82450 Offset: 0xE7E450 VA: 0xE82450
	public void .ctor(GameObject go) { }

	// RVA: 0xE82DF4 Offset: 0xE7EDF4 VA: 0xE82DF4
	public NpcDialogPc.SelectTemplate Clone(GameObject parent) { }

	// RVA: 0xE82ECC Offset: 0xE7EECC VA: 0xE82ECC
	public void SetData(string text, UnityAction onClick) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcDialogPc.<>c__DisplayClass23_0 // TypeDefIndex: 2605
{
	// Fields
	public NpcTransferMessage message; // 0x10
	public NpcDialogPc <>4__this; // 0x18
	public UnityAction <>9__8; // 0x20

	// Methods

	// RVA: 0xE82DE4 Offset: 0xE7EDE4 VA: 0xE82DE4
	public void .ctor() { }

	// RVA: 0xE82FD8 Offset: 0xE7EFD8 VA: 0xE82FD8
	internal void <Open>b__0() { }

	// RVA: 0xE832CC Offset: 0xE7F2CC VA: 0xE832CC
	internal void <Open>b__1() { }

	// RVA: 0xE834B8 Offset: 0xE7F4B8 VA: 0xE834B8
	internal void <Open>b__2() { }

	// RVA: 0xE8363C Offset: 0xE7F63C VA: 0xE8363C
	internal void <Open>b__8() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcDialogPc.<>c__DisplayClass23_1 // TypeDefIndex: 2606
{
	// Fields
	public NpcDialogPc.SelectTemplate field; // 0x10
	public int indexCoppied; // 0x18
	public NpcDialogPc.<>c__DisplayClass23_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0xE832C4 Offset: 0xE7F2C4 VA: 0xE832C4
	public void .ctor() { }

	// RVA: 0xE83654 Offset: 0xE7F654 VA: 0xE83654
	internal void <Open>b__3() { }

	// RVA: 0xE836BC Offset: 0xE7F6BC VA: 0xE836BC
	internal void <Open>b__4() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcDialogPc.<>c__DisplayClass23_2 // TypeDefIndex: 2607
{
	// Fields
	public NpcDialogPc.SelectTemplate field; // 0x10
	public int indexCoppied; // 0x18
	public NpcDialogPc.<>c__DisplayClass23_0 CS$<>8__locals2; // 0x20

	// Methods

	// RVA: 0xE834B0 Offset: 0xE7F4B0 VA: 0xE834B0
	public void .ctor() { }

	// RVA: 0xE8376C Offset: 0xE7F76C VA: 0xE8376C
	internal void <Open>b__5() { }

	// RVA: 0xE837D4 Offset: 0xE7F7D4 VA: 0xE837D4
	internal void <Open>b__6() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcDialogPc.<>c__DisplayClass23_3 // TypeDefIndex: 2608
{
	// Fields
	public NpcDialogPc.SelectTemplate field; // 0x10

	// Methods

	// RVA: 0xE83634 Offset: 0xE7F634 VA: 0xE83634
	public void .ctor() { }

	// RVA: 0xE83884 Offset: 0xE7F884 VA: 0xE83884
	internal void <Open>b__7() { }
}

// Namespace: game.ui
public class NpcDialogPc : MonoBehaviour // TypeDefIndex: 2609
{
	// Fields
	[SerializeField]
	private Image framed6; // 0x20
	[SerializeField]
	private Image thumbnail6NpcImage; // 0x28
	[SerializeField]
	private Image thumbnail6ItemImage; // 0x30
	[SerializeField]
	private TextMeshProUGUI thumbnail6NameTmp; // 0x38
	[SerializeField]
	private GameObject selectionTemplateGo; // 0x40
	[SerializeField]
	private GameObject layout3Go; // 0x48
	[SerializeField]
	private ScrollRect layout3DescriptionScrollRect; // 0x50
	[SerializeField]
	private TextMeshProUGUI layout3DescriptionTmp; // 0x58
	[SerializeField]
	private GameObject layout3SelectionContentGo; // 0x60
	[SerializeField]
	private GameObject layout6Go; // 0x68
	[SerializeField]
	private ScrollRect layout6DescriptionScrollRect; // 0x70
	[SerializeField]
	private TextMeshProUGUI layout6DescriptionTmp; // 0x78
	[SerializeField]
	private GameObject layout6SelectionContentLeftGo; // 0x80
	[SerializeField]
	private GameObject layout6SelectionContentRightGo; // 0x88
	private Queue<Action> onStartActions; // 0x90
	private Queue<Action> onCloseActions; // 0x98
	private bool isStarted; // 0xA0
	private NpcDialogPc.SelectTemplate selectTemplate; // 0xA8

	// Methods

	// RVA: 0xE82304 Offset: 0xE7E304 VA: 0xE82304
	private void Start() { }

	// RVA: 0xE82574 Offset: 0xE7E574 VA: 0xE82574
	private void Perform(Action action) { }

	// RVA: 0xE82644 Offset: 0xE7E644 VA: 0xE82644
	private void OnClose(Action action) { }

	// RVA: 0xE826F0 Offset: 0xE7E6F0 VA: 0xE826F0
	public void Close(bool sound = True) { }

	// RVA: 0xE82838 Offset: 0xE7E838 VA: 0xE82838
	public void Open(NpcTransferMessage message) { }

	// RVA: 0xE82DEC Offset: 0xE7EDEC VA: 0xE82DEC
	public void .ctor() { }
}

// Namespace: 
private class NpcKnbShop.CategoryTemplate // TypeDefIndex: 2610
{
	// Fields
	public GameObject go; // 0x10
	public Image backgroundActive; // 0x18
	public Image backgroundUnActive; // 0x20
	public TextMeshProUGUI tmp; // 0x28
	public Button button; // 0x30

	// Methods

	// RVA: 0xE83C1C Offset: 0xE7FC1C VA: 0xE83C1C
	public void .ctor(GameObject go) { }

	// RVA: 0xE85158 Offset: 0xE81158 VA: 0xE85158
	public NpcKnbShop.CategoryTemplate Clone(Transform parent) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcKnbShop.<>c__DisplayClass26_0 // TypeDefIndex: 2611
{
	// Fields
	public float secondsRemaining; // 0x10
	public NpcKnbShop <>4__this; // 0x18
	public RectTransform rect; // 0x20
	public Vector2 to; // 0x28
	public Action onFinish; // 0x30
	public float speedOnSeconds; // 0x38

	// Methods

	// RVA: 0xE842C8 Offset: 0xE802C8 VA: 0xE842C8
	public void .ctor() { }

	// RVA: 0xE8575C Offset: 0xE8175C VA: 0xE8575C
	internal void <LeanMoveLocal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcKnbShop.<>c__DisplayClass27_0 // TypeDefIndex: 2612
{
	// Fields
	public NpcKnbShop <>4__this; // 0x10
	public ShopTypeTwo shopTypeTwo; // 0x18
	public Action <>9__1; // 0x20

	// Methods

	// RVA: 0xE84484 Offset: 0xE80484 VA: 0xE84484
	public void .ctor() { }

	// RVA: 0xE858FC Offset: 0xE818FC VA: 0xE858FC
	internal void <ShowOpen>b__0() { }

	// RVA: 0xE85E8C Offset: 0xE81E8C VA: 0xE85E8C
	internal void <ShowOpen>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcKnbShop.<>c__DisplayClass32_0 // TypeDefIndex: 2613
{
	// Fields
	public NpcKnbShop <>4__this; // 0x10
	public Item item; // 0x18
	public ShopData shopData; // 0x20
	public int shopItemIndex; // 0x28
	public Action <>9__1; // 0x30

	// Methods

	// RVA: 0xE849A4 Offset: 0xE809A4 VA: 0xE849A4
	public void .ctor() { }

	// RVA: 0xE85EB8 Offset: 0xE81EB8 VA: 0xE85EB8
	internal void <AddItem>b__0() { }

	// RVA: 0xE860E8 Offset: 0xE820E8 VA: 0xE860E8
	internal void <AddItem>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcKnbShop.<>c__DisplayClass37_0 // TypeDefIndex: 2614
{
	// Fields
	public ShopData entry; // 0x10
	public NpcKnbShop.CategoryTemplate menu; // 0x18
	public NpcKnbShop <>4__this; // 0x20

	// Methods

	// RVA: 0xE85150 Offset: 0xE81150 VA: 0xE85150
	public void .ctor() { }

	// RVA: 0xE861C8 Offset: 0xE821C8 VA: 0xE861C8
	internal void <SetMenu>b__0() { }
}

// Namespace: game.ui
public class NpcKnbShop : MonoBehaviour // TypeDefIndex: 2615
{
	// Fields
	private const int OriginFramedWidth = 278;
	private const int OriginFramedHeight = 430;
	private const int OriginItemFramedWidth = 42;
	private const int OriginItemFramedHeight = 42;
	private const int OriginLineItemCount = 4;
	[SerializeField]
	private RectTransform backgroundRect; // 0x20
	[SerializeField]
	private Image backgroundImage; // 0x28
	[SerializeField]
	private RectTransform itemListingContent; // 0x30
	[SerializeField]
	private RectTransform itemTemplate; // 0x38
	[SerializeField]
	private RectTransform categoryListingContent; // 0x40
	[SerializeField]
	private RectTransform categoryTemplate; // 0x48
	[SerializeField]
	private Button closeButton; // 0x50
	private float scaleRatio; // 0x58
	private Vector2 showoffVisiblePosition; // 0x5C
	private Vector2 showoffHiddenPosition; // 0x64
	private readonly Queue<Action> onStartActions; // 0x70
	private bool isStarted; // 0x78
	private bool isOpening; // 0x79
	private PlayerSelfBagarate.Cell cellTemplate; // 0x80
	private readonly List<PlayerSelfBagarate.Cell> cellListing; // 0x88
	private NpcKnbShop.CategoryTemplate categoryTemplateClass; // 0x90
	private readonly List<NpcKnbShop.CategoryTemplate> categoryListing; // 0x98
	private Action leanMoveLocalUpdating; // 0xA0

	// Methods

	// RVA: 0xE838EC Offset: 0xE7F8EC VA: 0xE838EC
	private void Start() { }

	// RVA: 0xE8407C Offset: 0xE8007C VA: 0xE8407C
	private void Update() { }

	// RVA: 0xE84098 Offset: 0xE80098 VA: 0xE84098
	private void Perform(Action action) { }

	// RVA: 0xE84114 Offset: 0xE80114 VA: 0xE84114
	private void LeanMoveLocal(RectTransform rect, Vector2 to, Action onFinish) { }

	// RVA: 0xE842D0 Offset: 0xE802D0 VA: 0xE842D0
	public void ShowOpen(bool enabled, ShopTypeTwo shopTypeTwo) { }

	// RVA: 0xE8448C Offset: 0xE8048C VA: 0xE8448C
	public void ShowOff() { }

	// RVA: 0xE844A0 Offset: 0xE804A0 VA: 0xE844A0
	public void ShowDirectly(bool enabled) { }

	// RVA: 0xE84880 Offset: 0xE80880 VA: 0xE84880
	public bool IsOpen() { }

	// RVA: 0xE83E4C Offset: 0xE7FE4C VA: 0xE83E4C
	private List<PlayerSelfBagarate.Cell> CreateNewCellLine() { }

	// RVA: 0xE84888 Offset: 0xE80888 VA: 0xE84888
	public void AddItem(Item item, ShopData shopData, int shopItemIndex) { }

	// RVA: 0xE849AC Offset: 0xE809AC VA: 0xE849AC
	public void RemoveItem(int itemindex) { }

	// RVA: 0xE845B4 Offset: 0xE805B4 VA: 0xE845B4
	public void ClearAllItem() { }

	// RVA: 0xE846E4 Offset: 0xE806E4 VA: 0xE846E4
	private void ClearAllMenu() { }

	// RVA: 0xE84B08 Offset: 0xE80B08 VA: 0xE84B08
	private void SetMenu(ShopTypeTwo shopTypeTwo) { }

	// RVA: 0xE85214 Offset: 0xE81214 VA: 0xE85214
	private void SetItem(ShopData shopdata) { }

	// RVA: 0xE85580 Offset: 0xE81580 VA: 0xE85580
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE856B0 Offset: 0xE816B0 VA: 0xE856B0
	private void <Start>b__23_0() { }

	[CompilerGenerated]
	// RVA: 0xE85728 Offset: 0xE81728 VA: 0xE85728
	private void <ShowDirectly>b__29_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcMoneyShop.<>c__DisplayClass22_0 // TypeDefIndex: 2616
{
	// Fields
	public float secondsRemaining; // 0x10
	public NpcMoneyShop <>4__this; // 0x18
	public RectTransform rect; // 0x20
	public Vector2 to; // 0x28
	public Action onFinish; // 0x30
	public float speedOnSeconds; // 0x38

	// Methods

	// RVA: 0xE86B08 Offset: 0xE82B08 VA: 0xE86B08
	public void .ctor() { }

	// RVA: 0xE87248 Offset: 0xE83248 VA: 0xE87248
	internal void <LeanMoveLocal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcMoneyShop.<>c__DisplayClass23_0 // TypeDefIndex: 2617
{
	// Fields
	public NpcMoneyShop <>4__this; // 0x10
	public ShopTypeOne shopTypeOne; // 0x18
	public Action <>9__1; // 0x20

	// Methods

	// RVA: 0xE86CEC Offset: 0xE82CEC VA: 0xE86CEC
	public void .ctor() { }

	// RVA: 0xE873E8 Offset: 0xE833E8 VA: 0xE873E8
	internal void <ShowOpen>b__0() { }

	// RVA: 0xE87A4C Offset: 0xE83A4C VA: 0xE87A4C
	internal void <ShowOpen>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcMoneyShop.<>c__DisplayClass28_0 // TypeDefIndex: 2618
{
	// Fields
	public NpcMoneyShop <>4__this; // 0x10
	public Item item; // 0x18
	public ShopTypeOne shopTypeOne; // 0x20
	public int shopItemIndex; // 0x28
	public Action <>9__1; // 0x30

	// Methods

	// RVA: 0xE86F5C Offset: 0xE82F5C VA: 0xE86F5C
	public void .ctor() { }

	// RVA: 0xE87A78 Offset: 0xE83A78 VA: 0xE87A78
	internal void <AddItem>b__0() { }

	// RVA: 0xE87CA8 Offset: 0xE83CA8 VA: 0xE87CA8
	internal void <AddItem>b__1() { }
}

// Namespace: game.ui
public class NpcMoneyShop : MonoBehaviour // TypeDefIndex: 2619
{
	// Fields
	private const int OriginFramedWidth = 214;
	private const int OriginFramedHeight = 430;
	private const int OriginItemFramedWidth = 42;
	private const int OriginItemFramedHeight = 42;
	private const int OriginLineItemCount = 4;
	[SerializeField]
	private RectTransform backgroundRect; // 0x20
	[SerializeField]
	private Image backgroundImage; // 0x28
	[SerializeField]
	private RectTransform itemListingContent; // 0x30
	[SerializeField]
	private RectTransform itemTemplate; // 0x38
	[SerializeField]
	private Button closeButton; // 0x40
	private float scaleRatio; // 0x48
	private Vector2 showoffVisiblePosition; // 0x4C
	private Vector2 showoffHiddenPosition; // 0x54
	private readonly Queue<Action> onStartActions; // 0x60
	private bool isStarted; // 0x68
	private bool isOpening; // 0x69
	private PlayerSelfBagarate.Cell cellTemplate; // 0x70
	private readonly List<PlayerSelfBagarate.Cell> cellListing; // 0x78
	private Action leanMoveLocalUpdating; // 0x80

	// Methods

	// RVA: 0xE863CC Offset: 0xE823CC VA: 0xE863CC
	private void Start() { }

	// RVA: 0xE868BC Offset: 0xE828BC VA: 0xE868BC
	private void Update() { }

	// RVA: 0xE868D8 Offset: 0xE828D8 VA: 0xE868D8
	private void Perform(Action action) { }

	// RVA: 0xE86954 Offset: 0xE82954 VA: 0xE86954
	private void LeanMoveLocal(RectTransform rect, Vector2 to, Action onFinish) { }

	// RVA: 0xE86B10 Offset: 0xE82B10 VA: 0xE86B10
	public void ShowOpen(bool enabled, ShopTypeOne shopTypeOne) { }

	// RVA: 0xE86CF4 Offset: 0xE82CF4 VA: 0xE86CF4
	public void ShowOff() { }

	// RVA: 0xE85D28 Offset: 0xE81D28 VA: 0xE85D28
	public void ShowDirectly(bool enabled) { }

	// RVA: 0xE86E38 Offset: 0xE82E38 VA: 0xE86E38
	public bool IsOpen() { }

	// RVA: 0xE8668C Offset: 0xE8268C VA: 0xE8668C
	private List<PlayerSelfBagarate.Cell> CreateNewCellLine() { }

	// RVA: 0xE86E40 Offset: 0xE82E40 VA: 0xE86E40
	public void AddItem(Item item, ShopTypeOne shopTypeOne, int shopItemIndex) { }

	// RVA: 0xE86F64 Offset: 0xE82F64 VA: 0xE86F64
	public void RemoveItem(int itemindex) { }

	// RVA: 0xE86D08 Offset: 0xE82D08 VA: 0xE86D08
	public void ClearAllItem() { }

	// RVA: 0xE870C0 Offset: 0xE830C0 VA: 0xE870C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE8719C Offset: 0xE8319C VA: 0xE8719C
	private void <Start>b__19_0() { }

	[CompilerGenerated]
	// RVA: 0xE87214 Offset: 0xE83214 VA: 0xE87214
	private void <ShowDirectly>b__25_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcPointShop.<>c__DisplayClass23_0 // TypeDefIndex: 2620
{
	// Fields
	public float secondsRemaining; // 0x10
	public NpcPointShop <>4__this; // 0x18
	public RectTransform rect; // 0x20
	public Vector2 to; // 0x28
	public Action onFinish; // 0x30
	public float speedOnSeconds; // 0x38

	// Methods

	// RVA: 0xE884D0 Offset: 0xE844D0 VA: 0xE884D0
	public void .ctor() { }

	// RVA: 0xE88E60 Offset: 0xE84E60 VA: 0xE88E60
	internal void <LeanMoveLocal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcPointShop.<>c__DisplayClass24_0 // TypeDefIndex: 2621
{
	// Fields
	public NpcPointShop <>4__this; // 0x10
	public ShopTypeThree shopTypeThree; // 0x18
	public Action <>9__1; // 0x20

	// Methods

	// RVA: 0xE8868C Offset: 0xE8468C VA: 0xE8868C
	public void .ctor() { }

	// RVA: 0xE89000 Offset: 0xE85000 VA: 0xE89000
	internal void <ShowOpen>b__0() { }

	// RVA: 0xE89664 Offset: 0xE85664 VA: 0xE89664
	internal void <ShowOpen>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcPointShop.<>c__DisplayClass29_0 // TypeDefIndex: 2622
{
	// Fields
	public NpcPointShop <>4__this; // 0x10
	public Item item; // 0x18
	public ShopTypeThree shopTypeOne; // 0x20
	public int shopItemIndex; // 0x28
	public Action <>9__1; // 0x30

	// Methods

	// RVA: 0xE88A60 Offset: 0xE84A60 VA: 0xE88A60
	public void .ctor() { }

	// RVA: 0xE89690 Offset: 0xE85690 VA: 0xE89690
	internal void <AddItem>b__0() { }

	// RVA: 0xE898C0 Offset: 0xE858C0 VA: 0xE898C0
	internal void <AddItem>b__1() { }
}

// Namespace: game.ui
public class NpcPointShop : MonoBehaviour // TypeDefIndex: 2623
{
	// Fields
	private const int OriginFramedWidth = 214;
	private const int OriginFramedHeight = 430;
	private const int OriginItemFramedWidth = 42;
	private const int OriginItemFramedHeight = 42;
	private const int OriginLineItemCount = 4;
	[SerializeField]
	private RectTransform backgroundRect; // 0x20
	[SerializeField]
	private Image backgroundImage; // 0x28
	[SerializeField]
	private RectTransform itemListingContent; // 0x30
	[SerializeField]
	private RectTransform itemTemplate; // 0x38
	[SerializeField]
	private TextMeshProUGUI leftPointTmp; // 0x40
	[SerializeField]
	private Button closeButton; // 0x48
	private float scaleRatio; // 0x50
	private Vector2 showoffVisiblePosition; // 0x54
	private Vector2 showoffHiddenPosition; // 0x5C
	private readonly Queue<Action> onStartActions; // 0x68
	private bool isStarted; // 0x70
	private bool isOpening; // 0x71
	private PlayerSelfBagarate.Cell cellTemplate; // 0x78
	private readonly List<PlayerSelfBagarate.Cell> cellListing; // 0x80
	private Action leanMoveLocalUpdating; // 0x88

	// Methods

	// RVA: 0xE87D94 Offset: 0xE83D94 VA: 0xE87D94
	private void Start() { }

	// RVA: 0xE88284 Offset: 0xE84284 VA: 0xE88284
	private void Update() { }

	// RVA: 0xE882A0 Offset: 0xE842A0 VA: 0xE882A0
	private void Perform(Action action) { }

	// RVA: 0xE8831C Offset: 0xE8431C VA: 0xE8831C
	private void LeanMoveLocal(RectTransform rect, Vector2 to, Action onFinish) { }

	// RVA: 0xE884D8 Offset: 0xE844D8 VA: 0xE884D8
	public void ShowOpen(bool enabled, ShopTypeThree shopTypeThree) { }

	// RVA: 0xE88694 Offset: 0xE84694 VA: 0xE88694
	public void ShowOff() { }

	// RVA: 0xE886A8 Offset: 0xE846A8 VA: 0xE886A8
	public void ShowDirectly(bool enabled) { }

	// RVA: 0xE8893C Offset: 0xE8493C VA: 0xE8893C
	public bool IsOpen() { }

	// RVA: 0xE88054 Offset: 0xE84054 VA: 0xE88054
	private List<PlayerSelfBagarate.Cell> CreateNewCellLine() { }

	// RVA: 0xE88944 Offset: 0xE84944 VA: 0xE88944
	public void AddItem(Item item, ShopTypeThree shopTypeOne, int shopItemIndex) { }

	// RVA: 0xE88A68 Offset: 0xE84A68 VA: 0xE88A68
	public void RemoveItem(int itemindex) { }

	// RVA: 0xE8880C Offset: 0xE8480C VA: 0xE8880C
	public void ClearAllItem() { }

	// RVA: 0xE88BC4 Offset: 0xE84BC4 VA: 0xE88BC4
	private void SetLeftPoint(long leftpoint, string pointname) { }

	// RVA: 0xE88CB4 Offset: 0xE84CB4 VA: 0xE88CB4
	public void ProtocolShopTypeThreeCurrentPoint(ShopTypeThreeCurrentPoint message) { }

	// RVA: 0xE88CD8 Offset: 0xE84CD8 VA: 0xE88CD8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE88DB4 Offset: 0xE84DB4 VA: 0xE88DB4
	private void <Start>b__20_0() { }

	[CompilerGenerated]
	// RVA: 0xE88E2C Offset: 0xE84E2C VA: 0xE88E2C
	private void <ShowDirectly>b__26_0() { }
}

// Namespace: 
private class PartyInvitePc.SelfMember // TypeDefIndex: 2624
{
	// Fields
	public GameObject go; // 0x10
	public TextMeshProUGUI label; // 0x18

	// Methods

	// RVA: 0xE89C94 Offset: 0xE85C94 VA: 0xE89C94
	public void .ctor(GameObject go) { }
}

// Namespace: 
private class PartyInvitePc.OtherPlayer // TypeDefIndex: 2625
{
	// Fields
	public GameObject go; // 0x10
	public GameObject backgroundGo; // 0x18
	public TextMeshProUGUI label; // 0x20
	public Button button; // 0x28
	public string cid; // 0x30
	public string name; // 0x38

	// Methods

	// RVA: 0xE89D14 Offset: 0xE85D14 VA: 0xE89D14
	public void .ctor(GameObject go) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PartyInvitePc.<>c // TypeDefIndex: 2626
{
	// Fields
	public static readonly PartyInvitePc.<>c <>9; // 0x0
	public static Comparison<KeyValuePair<double, Controller>> <>9__25_1; // 0x8

	// Methods

	// RVA: 0xE8BC2C Offset: 0xE87C2C VA: 0xE8BC2C
	private static void .cctor() { }

	// RVA: 0xE8BC94 Offset: 0xE87C94 VA: 0xE8BC94
	public void .ctor() { }

	// RVA: 0xE8BC9C Offset: 0xE87C9C VA: 0xE8BC9C
	internal int <ReListingOtherPlayer>b__25_1(KeyValuePair<double, Controller> a, KeyValuePair<double, Controller> b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PartyInvitePc.<>c__DisplayClass25_0 // TypeDefIndex: 2627
{
	// Fields
	public PartyInvitePc.OtherPlayer player; // 0x10
	public PartyInvitePc <>4__this; // 0x18

	// Methods

	// RVA: 0xE8BC24 Offset: 0xE87C24 VA: 0xE8BC24
	public void .ctor() { }

	// RVA: 0xE8BCF4 Offset: 0xE87CF4 VA: 0xE8BCF4
	internal void <ReListingOtherPlayer>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PartyInvitePc.<>c__DisplayClass26_0 // TypeDefIndex: 2628
{
	// Fields
	public string lowerName; // 0x10
	public PartyInvitePc <>4__this; // 0x18

	// Methods

	// RVA: 0xE8AB38 Offset: 0xE86B38 VA: 0xE8AB38
	public void .ctor() { }

	// RVA: 0xE8BF6C Offset: 0xE87F6C VA: 0xE8BF6C
	internal void <FindOtherPlayer>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PartyInvitePc.<>c__DisplayClass26_1 // TypeDefIndex: 2629
{
	// Fields
	public PartyInvitePc.OtherPlayer player; // 0x10
	public PartyInvitePc.<>c__DisplayClass26_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xE8C5D4 Offset: 0xE885D4 VA: 0xE8C5D4
	public void .ctor() { }

	// RVA: 0xE8C5DC Offset: 0xE885DC VA: 0xE8C5DC
	internal void <FindOtherPlayer>b__1() { }
}

// Namespace: game.ui
public class PartyInvitePc : MonoBehaviour // TypeDefIndex: 2630
{
	// Fields
	[SerializeField]
	private Image framedImage; // 0x20
	[SerializeField]
	private GameObject selfMemberContent; // 0x28
	[SerializeField]
	private GameObject selfMemberTemplate; // 0x30
	[SerializeField]
	private GameObject otherPlayerContent; // 0x38
	[SerializeField]
	private GameObject otherPlayerTemplate; // 0x40
	[SerializeField]
	private Button inviteButton; // 0x48
	[SerializeField]
	private TextMeshProUGUI leadLevelTmp; // 0x50
	[SerializeField]
	private TMP_InputField findInput; // 0x58
	[SerializeField]
	private Button closeButton; // 0x60
	private Queue<Action> onStartActions; // 0x68
	private bool isStarted; // 0x70
	private PartyInvitePc.SelfMember selfmember; // 0x78
	private PartyInvitePc.OtherPlayer otherplayer; // 0x80
	private List<PartyInvitePc.SelfMember> selfmemberListing; // 0x88
	private List<PartyInvitePc.OtherPlayer> otherplayerListing; // 0x90
	private string targetCid; // 0x98
	private string targetName; // 0xA0

	// Methods

	// RVA: 0xE899AC Offset: 0xE859AC VA: 0xE899AC
	private void Start() { }

	// RVA: 0xE89EA8 Offset: 0xE85EA8 VA: 0xE89EA8
	private void ApplyChildrenPCInput(Transform transform) { }

	// RVA: 0xE8A078 Offset: 0xE86078 VA: 0xE8A078
	private void Perform(Action action) { }

	// RVA: 0xE8A148 Offset: 0xE86148 VA: 0xE8A148
	private void Close() { }

	// RVA: 0xE8A47C Offset: 0xE8647C VA: 0xE8A47C
	public void Open() { }

	// RVA: 0xE8A4D8 Offset: 0xE864D8 VA: 0xE8A4D8
	private void ReListingSelfMember() { }

	// RVA: 0xE8A6C4 Offset: 0xE866C4 VA: 0xE8A6C4
	private void ReListingOtherPlayer() { }

	// RVA: 0xE8A8B0 Offset: 0xE868B0 VA: 0xE8A8B0
	private void FindOtherPlayer(string name) { }

	// RVA: 0xE8AB40 Offset: 0xE86B40 VA: 0xE8AB40
	public void OnSyncMember() { }

	// RVA: 0xE8AB78 Offset: 0xE86B78 VA: 0xE8AB78
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE8AB80 Offset: 0xE86B80 VA: 0xE8AB80
	private void <Start>b__17_0() { }

	[CompilerGenerated]
	// RVA: 0xE8ABF0 Offset: 0xE86BF0 VA: 0xE8ABF0
	private void <Start>b__17_1(string _value) { }

	[CompilerGenerated]
	// RVA: 0xE8ABF4 Offset: 0xE86BF4 VA: 0xE8ABF4
	private void <Start>b__17_2() { }

	[CompilerGenerated]
	// RVA: 0xE8AD58 Offset: 0xE86D58 VA: 0xE8AD58
	private void <ReListingSelfMember>b__24_0() { }

	[CompilerGenerated]
	// RVA: 0xE8B22C Offset: 0xE8722C VA: 0xE8B22C
	private void <ReListingOtherPlayer>b__25_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerOtherEquipment.<>c__DisplayClass51_0 // TypeDefIndex: 2631
{
	// Fields
	public float secondsRemaining; // 0x10
	public PlayerOtherEquipment <>4__this; // 0x18
	public RectTransform rect; // 0x20
	public Vector2 to; // 0x28
	public Action onFinish; // 0x30
	public float speedOnSeconds; // 0x38

	// Methods

	// RVA: 0xE8D610 Offset: 0xE89610 VA: 0xE8D610
	public void .ctor() { }

	// RVA: 0xE8EDC8 Offset: 0xE8ADC8 VA: 0xE8EDC8
	internal void <LeanMoveLocal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerOtherEquipment.<>c__DisplayClass65_0 // TypeDefIndex: 2632
{
	// Fields
	public PlayerOtherEquipment <>4__this; // 0x10
	public RepeatedField<Item> items; // 0x18

	// Methods

	// RVA: 0xE8D8F0 Offset: 0xE898F0 VA: 0xE8D8F0
	public void .ctor() { }

	// RVA: 0xE8EF6C Offset: 0xE8AF6C VA: 0xE8EF6C
	internal void <ApplyProperties>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerOtherEquipment.<>c__DisplayClass65_1 // TypeDefIndex: 2633
{
	// Fields
	public Item item; // 0x10

	// Methods

	// RVA: 0xE8F538 Offset: 0xE8B538 VA: 0xE8F538
	public void .ctor() { }

	// RVA: 0xE8F540 Offset: 0xE8B540 VA: 0xE8F540
	internal void <ApplyProperties>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerOtherEquipment.<>c__DisplayClass69_0 // TypeDefIndex: 2634
{
	// Fields
	public bool enabled; // 0x10
	public PlayerOtherEquipment <>4__this; // 0x18
	public Action <>9__1; // 0x20

	// Methods

	// RVA: 0xE8E180 Offset: 0xE8A180 VA: 0xE8E180
	public void .ctor() { }

	// RVA: 0xE8F638 Offset: 0xE8B638 VA: 0xE8F638
	internal void <ShowOpen>b__0() { }

	// RVA: 0xE8F750 Offset: 0xE8B750 VA: 0xE8F750
	internal void <ShowOpen>b__1() { }
}

// Namespace: game.ui
public class PlayerOtherEquipment : MonoBehaviour // TypeDefIndex: 2635
{
	// Fields
	private const int OriginFramedWidth = 205;
	private const int OriginFramedHeight = 448;
	[SerializeField]
	private RectTransform framedRect; // 0x20
	[SerializeField]
	private Image backgroundMaleImage; // 0x28
	[SerializeField]
	private Image backgroundFemaleImage; // 0x30
	[SerializeField]
	private TextMeshProUGUI propertiesName; // 0x38
	[SerializeField]
	private TextMeshProUGUI propertiesCid; // 0x40
	[SerializeField]
	private TextMeshProUGUI propertiesSeries; // 0x48
	[SerializeField]
	private TextMeshProUGUI propertiesLevel; // 0x50
	[SerializeField]
	private TextMeshProUGUI propertiesPk; // 0x58
	[SerializeField]
	private TextMeshProUGUI propertiesRank; // 0x60
	[SerializeField]
	private Image propertiesFactionIcon; // 0x68
	[SerializeField]
	private GameObject equipmentHelmGo; // 0x70
	[SerializeField]
	private GameObject equipmentAmuletGo; // 0x78
	[SerializeField]
	private GameObject equipmentWeaponGo; // 0x80
	[SerializeField]
	private GameObject equipmentArmorGo; // 0x88
	[SerializeField]
	private GameObject equipmentBeltGo; // 0x90
	[SerializeField]
	private GameObject equipmentCuffGo; // 0x98
	[SerializeField]
	private GameObject equipmentRingAboveGo; // 0xA0
	[SerializeField]
	private GameObject equipmentRingBelowGo; // 0xA8
	[SerializeField]
	private GameObject equipmentPendantGo; // 0xB0
	[SerializeField]
	private GameObject equipmentBootGo; // 0xB8
	[SerializeField]
	private GameObject equipmentHorseGo; // 0xC0
	[SerializeField]
	private Button functionsClose; // 0xC8
	[SerializeField]
	private Button functionsPrivateChat; // 0xD0
	[SerializeField]
	private TextMeshProUGUI functionsPrivateChatText; // 0xD8
	[SerializeField]
	private Button functionsInviteParty; // 0xE0
	[SerializeField]
	private TextMeshProUGUI functionsInvitePartyText; // 0xE8
	[SerializeField]
	private Button functionsJoinParty; // 0xF0
	[SerializeField]
	private TextMeshProUGUI functionsJoinPartyText; // 0xF8
	[SerializeField]
	private Button functionsJoinTong; // 0x100
	[SerializeField]
	private TextMeshProUGUI functionsJoinTongText; // 0x108
	[SerializeField]
	private Button functionsTrading; // 0x110
	[SerializeField]
	private TextMeshProUGUI functionsTradingText; // 0x118
	[SerializeField]
	private Button functionsPrivateFight; // 0x120
	[SerializeField]
	private TextMeshProUGUI functionsPrivateFightText; // 0x128
	[SerializeField]
	private Button functionsFriendly; // 0x130
	[SerializeField]
	private TextMeshProUGUI functionsFriendlyText; // 0x138
	[SerializeField]
	private Button functionsRunFollow; // 0x140
	[SerializeField]
	private TextMeshProUGUI functionsRunFollowText; // 0x148
	private float scaleRatio; // 0x150
	private Vector2 showoffVisiblePosition; // 0x154
	private Vector2 showoffHiddenPosition; // 0x15C
	private readonly Queue<Action> onStartActions; // 0x168
	private bool isStarted; // 0x170
	private string targetCid; // 0x178
	private string targetName; // 0x180
	private Action leanMoveLocalUpdating; // 0x188
	private readonly PlayerSelfProperties.EquipmentItem equipmentHelm; // 0x190
	private readonly PlayerSelfProperties.EquipmentItem equipmentAmulet; // 0x198
	private readonly PlayerSelfProperties.EquipmentItem equipmentWeapon; // 0x1A0
	private readonly PlayerSelfProperties.EquipmentItem equipmentArmor; // 0x1A8
	private readonly PlayerSelfProperties.EquipmentItem equipmentBelt; // 0x1B0
	private readonly PlayerSelfProperties.EquipmentItem equipmentCuff; // 0x1B8
	private readonly PlayerSelfProperties.EquipmentItem equipmentRingAbove; // 0x1C0
	private readonly PlayerSelfProperties.EquipmentItem equipmentRingBelow; // 0x1C8
	private readonly PlayerSelfProperties.EquipmentItem equipmentPendant; // 0x1D0
	private readonly PlayerSelfProperties.EquipmentItem equipmentBoot; // 0x1D8
	private readonly PlayerSelfProperties.EquipmentItem equipmentHorse; // 0x1E0
	private Dictionary<int, PlayerSelfProperties.EquipmentItem> equipPlace; // 0x1E8
	private string factionName; // 0x1F0
	private string seriesName; // 0x1F8

	// Methods

	// RVA: 0xE8C86C Offset: 0xE8886C VA: 0xE8C86C
	private void Start() { }

	// RVA: 0xE8D3C4 Offset: 0xE893C4 VA: 0xE8D3C4
	private void Update() { }

	// RVA: 0xE8D3E0 Offset: 0xE893E0 VA: 0xE8D3E0
	private void Perform(Action action) { }

	// RVA: 0xE8D45C Offset: 0xE8945C VA: 0xE8D45C
	private void LeanMoveLocal(RectTransform rect, Vector2 to, Action onFinish) { }

	// RVA: 0xE8D618 Offset: 0xE89618 VA: 0xE8D618
	public void ClearAllItem() { }

	// RVA: 0xE8D758 Offset: 0xE89758 VA: 0xE8D758
	public void ApplyProperties(OtherPlayerProperties properties, RepeatedField<Item> items) { }

	// RVA: 0xE8DF40 Offset: 0xE89F40 VA: 0xE8DF40
	private string ToTMP(string color, string content) { }

	// RVA: 0xE8D31C Offset: 0xE8931C VA: 0xE8D31C
	private string ToTMP(string content) { }

	// RVA: 0xE8DFF0 Offset: 0xE89FF0 VA: 0xE8DFF0
	public void ShowReopen() { }

	// RVA: 0xE8E090 Offset: 0xE8A090 VA: 0xE8E090
	public void ShowOpen(bool enabled) { }

	// RVA: 0xE8E188 Offset: 0xE8A188 VA: 0xE8E188
	public bool ShowOff() { }

	// RVA: 0xE8E1D0 Offset: 0xE8A1D0 VA: 0xE8E1D0
	public bool IsOpen() { }

	// RVA: 0xE8E1F0 Offset: 0xE8A1F0 VA: 0xE8E1F0
	public void RequestCid(string cid) { }

	// RVA: 0xE8DCE4 Offset: 0xE89CE4 VA: 0xE8DCE4
	public void SetFactionIcon(int factionId) { }

	// RVA: 0xE8D8F8 Offset: 0xE898F8 VA: 0xE8D8F8
	public void SetSex(int sexid) { }

	// RVA: 0xE8DA00 Offset: 0xE89A00 VA: 0xE8DA00
	public void SetCid(string cid) { }

	// RVA: 0xE8D988 Offset: 0xE89988 VA: 0xE8D988
	public void SetName(string name) { }

	// RVA: 0xE8DE90 Offset: 0xE89E90 VA: 0xE8DE90
	public void SetRank(int value) { }

	// RVA: 0xE8DC20 Offset: 0xE89C20 VA: 0xE8DC20
	public void SetLevel(int level) { }

	// RVA: 0xE8DE08 Offset: 0xE89E08 VA: 0xE8DE08
	public void SetPk(int value) { }

	// RVA: 0xE8DB2C Offset: 0xE89B2C VA: 0xE8DB2C
	public void SetSeries(int value) { }

	// RVA: 0xE8E298 Offset: 0xE8A298 VA: 0xE8E298
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE8E4F8 Offset: 0xE8A4F8 VA: 0xE8E4F8
	private void <Start>b__48_0() { }

	[CompilerGenerated]
	// RVA: 0xE8E56C Offset: 0xE8A56C VA: 0xE8E56C
	private void <Start>b__48_1() { }

	[CompilerGenerated]
	// RVA: 0xE8E630 Offset: 0xE8A630 VA: 0xE8E630
	private void <Start>b__48_2() { }

	[CompilerGenerated]
	// RVA: 0xE8E734 Offset: 0xE8A734 VA: 0xE8E734
	private void <Start>b__48_3() { }

	[CompilerGenerated]
	// RVA: 0xE8E838 Offset: 0xE8A838 VA: 0xE8E838
	private void <Start>b__48_4() { }

	[CompilerGenerated]
	// RVA: 0xE8E984 Offset: 0xE8A984 VA: 0xE8E984
	private void <Start>b__48_5() { }

	[CompilerGenerated]
	// RVA: 0xE8EA88 Offset: 0xE8AA88 VA: 0xE8EA88
	private void <Start>b__48_6() { }

	[CompilerGenerated]
	// RVA: 0xE8EB8C Offset: 0xE8AB8C VA: 0xE8EB8C
	private void <Start>b__48_7() { }

	[CompilerGenerated]
	// RVA: 0xE8EC90 Offset: 0xE8AC90 VA: 0xE8EC90
	private void <Start>b__48_8() { }

	[CompilerGenerated]
	// RVA: 0xE8ED64 Offset: 0xE8AD64 VA: 0xE8ED64
	private void <ShowReopen>b__68_0() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerOtherStall.<>c // TypeDefIndex: 2636
{
	// Fields
	public static readonly PlayerOtherStall.<>c <>9; // 0x0
	public static UnityAction <>9__22_1; // 0x8
	public static Action <>9__34_4; // 0x10

	// Methods

	// RVA: 0xE90CA0 Offset: 0xE8CCA0 VA: 0xE90CA0
	private static void .cctor() { }

	// RVA: 0xE90D08 Offset: 0xE8CD08 VA: 0xE90D08
	public void .ctor() { }

	// RVA: 0xE90D10 Offset: 0xE8CD10 VA: 0xE90D10
	internal void <Start>b__22_1() { }

	// RVA: 0xE90DF4 Offset: 0xE8CDF4 VA: 0xE90DF4
	internal void <AddItem>b__34_4() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerOtherStall.<>c__DisplayClass25_0 // TypeDefIndex: 2637
{
	// Fields
	public float secondsRemaining; // 0x10
	public PlayerOtherStall <>4__this; // 0x18
	public RectTransform rect; // 0x20
	public Vector2 to; // 0x28
	public Action onFinish; // 0x30
	public float speedOnSeconds; // 0x38

	// Methods

	// RVA: 0xE90DF8 Offset: 0xE8CDF8 VA: 0xE90DF8
	public void .ctor() { }

	// RVA: 0xE90E00 Offset: 0xE8CE00 VA: 0xE90E00
	internal void <LeanMoveLocal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerOtherStall.<>c__DisplayClass30_0 // TypeDefIndex: 2638
{
	// Fields
	public PlayerOtherStall <>4__this; // 0x10
	public string playername; // 0x18

	// Methods

	// RVA: 0xE90FA0 Offset: 0xE8CFA0 VA: 0xE90FA0
	public void .ctor() { }

	// RVA: 0xE90FA8 Offset: 0xE8CFA8 VA: 0xE90FA8
	internal void <ShowReopen>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerOtherStall.<>c__DisplayClass34_0 // TypeDefIndex: 2639
{
	// Fields
	public PlayerOtherStall <>4__this; // 0x10
	public Item item; // 0x18
	public int money; // 0x20
	public int knb; // 0x24
	public string appendEndOfRequiredMagic; // 0x28
	public Action <>9__3; // 0x30
	public Action <>9__2; // 0x38
	public Action <>9__1; // 0x40

	// Methods

	// RVA: 0xE91030 Offset: 0xE8D030 VA: 0xE91030
	public void .ctor() { }

	// RVA: 0xE91038 Offset: 0xE8D038 VA: 0xE91038
	internal void <AddItem>b__0() { }

	// RVA: 0xE916E4 Offset: 0xE8D6E4 VA: 0xE916E4
	internal void <AddItem>b__1() { }

	// RVA: 0xE918A8 Offset: 0xE8D8A8 VA: 0xE918A8
	internal void <AddItem>b__2() { }

	// RVA: 0xE91C60 Offset: 0xE8DC60 VA: 0xE91C60
	internal void <AddItem>b__3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerOtherStall.<>c__DisplayClass38_0 // TypeDefIndex: 2640
{
	// Fields
	public PlayerOtherStall <>4__this; // 0x10
	public PlayerStallOpenResponse message; // 0x18

	// Methods

	// RVA: 0xE91D48 Offset: 0xE8DD48 VA: 0xE91D48
	public void .ctor() { }

	// RVA: 0xE91D50 Offset: 0xE8DD50 VA: 0xE91D50
	internal void <ProtocolPlayerStallOpenResponse>b__0() { }
}

// Namespace: game.ui
public class PlayerOtherStall : MonoBehaviour // TypeDefIndex: 2641
{
	// Fields
	private const int OriginFramedWidth = 214;
	private const int OriginFramedHeight = 430;
	private const int OriginItemFramedWidth = 42;
	private const int OriginItemFramedHeight = 42;
	private const int static_lineItemCount = 4;
	[SerializeField]
	private RectTransform backgroundRect; // 0x20
	[SerializeField]
	private Image backgroundImage; // 0x28
	[SerializeField]
	private RectTransform itemListingContent; // 0x30
	[SerializeField]
	private RectTransform itemTemplate; // 0x38
	[SerializeField]
	private TextMeshProUGUI playernameTmp; // 0x40
	[SerializeField]
	private Button closeButton; // 0x48
	[SerializeField]
	private Button bagarateButton; // 0x50
	[SerializeField]
	private ScrollRect scrollRect; // 0x58
	private float scaleRatio; // 0x60
	private Vector2 showoffVisiblePosition; // 0x64
	private Vector2 showoffHiddenPosition; // 0x6C
	private readonly Queue<Action> onStartActions; // 0x78
	private bool isStarted; // 0x80
	private bool isOpening; // 0x81
	private PlayerSelfBagarate.Cell cellTemplate; // 0x88
	private readonly List<PlayerSelfBagarate.Cell> cellListing; // 0x90
	private Action leanMoveLocalUpdating; // 0x98
	private PlayerStallOpenResponse currentStall; // 0xA0

	// Methods

	// RVA: 0xE8F77C Offset: 0xE8B77C VA: 0xE8F77C
	private void Start() { }

	// RVA: 0xE8FDE8 Offset: 0xE8BDE8 VA: 0xE8FDE8
	private void Update() { }

	// RVA: 0xE8FE04 Offset: 0xE8BE04 VA: 0xE8FE04
	private void Perform(Action action) { }

	// RVA: 0xE8FE80 Offset: 0xE8BE80 VA: 0xE8FE80
	private void LeanMoveLocal(RectTransform rect, Vector2 to, Action onFinish) { }

	// RVA: 0xE90034 Offset: 0xE8C034 VA: 0xE90034
	public void ShowOpen(bool enabled) { }

	// RVA: 0xE900DC Offset: 0xE8C0DC VA: 0xE900DC
	public void ShowOff() { }

	// RVA: 0xE85BC4 Offset: 0xE81BC4 VA: 0xE85BC4
	public void ShowDirectly(bool enabled) { }

	// RVA: 0xE9021C Offset: 0xE8C21C VA: 0xE9021C
	public bool IsOpen() { }

	// RVA: 0xE90224 Offset: 0xE8C224 VA: 0xE90224
	public void ShowReopen(string stallId, string playername) { }

	// RVA: 0xE8FBB8 Offset: 0xE8BBB8 VA: 0xE8FBB8
	private List<PlayerSelfBagarate.Cell> CreateNewCellLine() { }

	// RVA: 0xE8FB24 Offset: 0xE8BB24 VA: 0xE8FB24
	private void SetPlayerName(string name) { }

	// RVA: 0xE900EC Offset: 0xE8C0EC VA: 0xE900EC
	public void ClearAllItem() { }

	// RVA: 0xE9039C Offset: 0xE8C39C VA: 0xE9039C
	public void AddItem(Item item, int money, int knb) { }

	// RVA: 0xE905E4 Offset: 0xE8C5E4 VA: 0xE905E4
	public void RemoveItem(int itemindex) { }

	// RVA: 0xE90740 Offset: 0xE8C740 VA: 0xE90740
	public void ProtocolPlayerStallBuyItemResponse(PlayerStallBuyItemResponse message) { }

	// RVA: 0xE907D0 Offset: 0xE8C7D0 VA: 0xE907D0
	public void ProtocolPlayerStallOpenResponse(PlayerStallOpenResponse message) { }

	// RVA: 0xE908C0 Offset: 0xE8C8C0 VA: 0xE908C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE9099C Offset: 0xE8C99C VA: 0xE9099C
	private void <Start>b__22_0() { }

	[CompilerGenerated]
	// RVA: 0xE90A10 Offset: 0xE8CA10 VA: 0xE90A10
	private void <ShowOpen>b__26_0() { }

	[CompilerGenerated]
	// RVA: 0xE90C48 Offset: 0xE8CC48 VA: 0xE90C48
	private void <ShowOpen>b__26_1() { }

	[CompilerGenerated]
	// RVA: 0xE90C6C Offset: 0xE8CC6C VA: 0xE90C6C
	private void <ShowDirectly>b__28_0() { }
}

// Namespace: 
public class PlayerSelfBagarate.Cell.ThumbnailStoredResize // TypeDefIndex: 2642
{
	// Fields
	public Vector2 offsetMin; // 0x10
	public Vector2 offsetMax; // 0x18
	public bool preserveAspect; // 0x20

	// Methods

	// RVA: 0xE9490C Offset: 0xE9090C VA: 0xE9490C
	public void .ctor() { }
}

// Namespace: 
public class PlayerSelfBagarate.Cell // TypeDefIndex: 2643
{
	// Fields
	public GameObject go; // 0x10
	public RectTransform rectTransform; // 0x18
	public Image framedImage; // 0x20
	public Image backgroundColor; // 0x28
	public ItemBorder itemBorder; // 0x30
	public Image thumbnailImage; // 0x38
	public RectTransform thumbnailRect; // 0x40
	public TextMeshProUGUI stack; // 0x48
	public Button button; // 0x50
	public TextMeshProUGUI seriesText; // 0x58
	public Item item; // 0x60
	public Action onClick; // 0x68
	public int itemSeriers; // 0x70
	public bool itemIsEquipment; // 0x74

	// Methods

	// RVA: 0xE925E0 Offset: 0xE8E5E0 VA: 0xE925E0
	public void .ctor(GameObject go) { }

	// RVA: 0xE93488 Offset: 0xE8F488 VA: 0xE93488
	public PlayerSelfBagarate.Cell Clone(GameObject parent) { }

	// RVA: 0xE9428C Offset: 0xE9028C VA: 0xE9428C
	public void Clear() { }

	// RVA: 0xE946A8 Offset: 0xE906A8 VA: 0xE946A8
	public void SetRequiredPassed(bool isPassed) { }

	// RVA: 0xE91238 Offset: 0xE8D238 VA: 0xE91238
	public void Apply(Item item) { }

	// RVA: 0xE94714 Offset: 0xE90714 VA: 0xE94714
	public void SetActiveSeries(bool enabled) { }

	[CompilerGenerated]
	// RVA: 0xE948F0 Offset: 0xE908F0 VA: 0xE948F0
	private void <Apply>b__19_0() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerSelfBagarate.<>c // TypeDefIndex: 2644
{
	// Fields
	public static readonly PlayerSelfBagarate.<>c <>9; // 0x0
	public static UnityAction <>9__30_1; // 0x8
	public static Action<string> <>9__30_6; // 0x10
	public static UnityAction <>9__30_2; // 0x18
	public static UnityAction <>9__30_3; // 0x20

	// Methods

	// RVA: 0xE94914 Offset: 0xE90914 VA: 0xE94914
	private static void .cctor() { }

	// RVA: 0xE9497C Offset: 0xE9097C VA: 0xE9497C
	public void .ctor() { }

	// RVA: 0xE94984 Offset: 0xE90984 VA: 0xE94984
	internal void <Start>b__30_1() { }

	// RVA: 0xE94A34 Offset: 0xE90A34 VA: 0xE94A34
	internal void <Start>b__30_2() { }

	// RVA: 0xE94C10 Offset: 0xE90C10 VA: 0xE94C10
	internal void <Start>b__30_6(string _value) { }

	// RVA: 0xE94D54 Offset: 0xE90D54 VA: 0xE94D54
	internal void <Start>b__30_3() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfBagarate.<>c__DisplayClass33_0 // TypeDefIndex: 2645
{
	// Fields
	public float secondsRemaining; // 0x10
	public PlayerSelfBagarate <>4__this; // 0x18
	public RectTransform rect; // 0x20
	public Vector2 to; // 0x28
	public Action onFinish; // 0x30
	public float speedOnSeconds; // 0x38

	// Methods

	// RVA: 0xE92D10 Offset: 0xE8ED10 VA: 0xE92D10
	public void .ctor() { }

	// RVA: 0xE94F08 Offset: 0xE90F08 VA: 0xE94F08
	internal void <LeanMoveLocal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfBagarate.<>c__DisplayClass35_0 // TypeDefIndex: 2646
{
	// Fields
	public bool enabled; // 0x10
	public PlayerSelfBagarate <>4__this; // 0x18
	public Action <>9__1; // 0x20

	// Methods

	// RVA: 0xE92E10 Offset: 0xE8EE10 VA: 0xE92E10
	public void .ctor() { }

	// RVA: 0xE950A8 Offset: 0xE910A8 VA: 0xE950A8
	internal void <ShowOpen>b__0() { }

	// RVA: 0xE951F4 Offset: 0xE911F4 VA: 0xE951F4
	internal void <ShowOpen>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfBagarate.<>c__DisplayClass43_0 // TypeDefIndex: 2647
{
	// Fields
	public PlayerSelfBagarate <>4__this; // 0x10
	public Item item; // 0x18

	// Methods

	// RVA: 0xE93634 Offset: 0xE8F634 VA: 0xE93634
	public void .ctor() { }

	// RVA: 0xE95220 Offset: 0xE91220 VA: 0xE95220
	internal void <AddNewItem>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfBagarate.<>c__DisplayClass44_0 // TypeDefIndex: 2648
{
	// Fields
	public PlayerSelfBagarate <>4__this; // 0x10
	public Item item; // 0x18

	// Methods

	// RVA: 0xE93710 Offset: 0xE8F710 VA: 0xE93710
	public void .ctor() { }

	// RVA: 0xE952D0 Offset: 0xE912D0 VA: 0xE952D0
	internal void <ReplaceItem>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfBagarate.<>c__DisplayClass45_0 // TypeDefIndex: 2649
{
	// Fields
	public PlayerSelfBagarate <>4__this; // 0x10
	public int cellindex; // 0x18
	public Item item; // 0x20

	// Methods

	// RVA: 0xE93718 Offset: 0xE8F718 VA: 0xE93718
	public void .ctor() { }

	// RVA: 0xE953BC Offset: 0xE913BC VA: 0xE953BC
	internal void <ApplyItem>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfBagarate.<>c__DisplayClass45_1 // TypeDefIndex: 2650
{
	// Fields
	public PlayerSelfBagarate.Cell bagarateCell; // 0x10
	public PlayerSelfBagarate.<>c__DisplayClass45_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xE95510 Offset: 0xE91510 VA: 0xE95510
	public void .ctor() { }

	// RVA: 0xE95518 Offset: 0xE91518 VA: 0xE95518
	internal void <ApplyItem>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfBagarate.<>c__DisplayClass47_0 // TypeDefIndex: 2651
{
	// Fields
	public int cellindex; // 0x10
	public PlayerSelfBagarate <>4__this; // 0x18

	// Methods

	// RVA: 0xE937A0 Offset: 0xE8F7A0 VA: 0xE937A0
	public void .ctor() { }

	// RVA: 0xE95850 Offset: 0xE91850 VA: 0xE95850
	internal void <ClearCell>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfBagarate.<>c__DisplayClass48_0 // TypeDefIndex: 2652
{
	// Fields
	public PlayerSelfBagarate <>4__this; // 0x10
	public int itemindex; // 0x18

	// Methods

	// RVA: 0xE93870 Offset: 0xE8F870 VA: 0xE93870
	public void .ctor() { }

	// RVA: 0xE958E4 Offset: 0xE918E4 VA: 0xE958E4
	internal void <ClearByItemIndex>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfBagarate.<>c__DisplayClass54_0 // TypeDefIndex: 2653
{
	// Fields
	public PlayerSelfBagarate <>4__this; // 0x10
	public bool enabled; // 0x18

	// Methods

	// RVA: 0xE93CF8 Offset: 0xE8FCF8 VA: 0xE93CF8
	public void .ctor() { }

	// RVA: 0xE959E0 Offset: 0xE919E0 VA: 0xE959E0
	internal void <SetActiveEquipmentSeries>b__0() { }
}

// Namespace: game.ui
public class PlayerSelfBagarate : MonoBehaviour // TypeDefIndex: 2654
{
	// Fields
	private const int OriginFramedWidth = 214;
	private const int OriginFramedHeight = 470;
	private const int OriginItemFramedWidth = 42;
	private const int OriginItemFramedHeight = 42;
	private const int static_lineItemCount = 4;
	private const int static_lineCountDefault = 7;
	private const int static_cellElementCountDefault = 28;
	[SerializeField]
	private RectTransform backgroundRect; // 0x20
	[SerializeField]
	private Image backgroundImage; // 0x28
	[SerializeField]
	private RectTransform itemListingContent; // 0x30
	[SerializeField]
	private RectTransform itemTemplate; // 0x38
	[SerializeField]
	private TextMeshProUGUI money; // 0x40
	[SerializeField]
	private TextMeshProUGUI knb; // 0x48
	[SerializeField]
	private TextMeshProUGUI itemCount; // 0x50
	[SerializeField]
	private Button sortButton; // 0x58
	[SerializeField]
	private Button tradeButton; // 0x60
	[SerializeField]
	private Button sendMoneyButton; // 0x68
	[SerializeField]
	private Button equipmentButton; // 0x70
	[SerializeField]
	private Button closeButton; // 0x78
	[SerializeField]
	private Button closeButton2; // 0x80
	private float scaleRatio; // 0x88
	private Vector2 showoffVisiblePosition; // 0x8C
	private Vector2 showoffHiddenPosition; // 0x94
	private readonly Queue<Action> onStartActions; // 0xA0
	private bool isStarted; // 0xA8
	private Action<int, PlayerSelfBagarate.Cell> onCellClickOption; // 0xB0
	private PlayerSelfBagarate.Cell cellTemplate; // 0xB8
	private readonly List<PlayerSelfBagarate.Cell> cellListing; // 0xC0
	private bool isItemSorted; // 0xC8
	private Action leanMoveLocalUpdating; // 0xD0
	private bool isOpening; // 0xD8

	// Methods

	// RVA: 0xE92068 Offset: 0xE8E068 VA: 0xE92068
	private void Start() { }

	// RVA: 0xE92AC4 Offset: 0xE8EAC4 VA: 0xE92AC4
	private void Update() { }

	// RVA: 0xE92AE0 Offset: 0xE8EAE0 VA: 0xE92AE0
	private void Perform(Action action) { }

	// RVA: 0xE92B5C Offset: 0xE8EB5C VA: 0xE92B5C
	private void LeanMoveLocal(RectTransform rect, Vector2 to, Action onFinish) { }

	// RVA: 0xE92D18 Offset: 0xE8ED18 VA: 0xE92D18
	public void ShowOpen(bool enabled) { }

	// RVA: 0xE90DB4 Offset: 0xE8CDB4 VA: 0xE90DB4
	public bool ShowOff() { }

	// RVA: 0xE92E18 Offset: 0xE8EE18 VA: 0xE92E18
	public void ShowDirectly(bool enabled) { }

	// RVA: 0xE92ED8 Offset: 0xE8EED8 VA: 0xE92ED8
	public bool IsOpenning() { }

	// RVA: 0xE92EE0 Offset: 0xE8EEE0 VA: 0xE92EE0
	public void SortItems() { }

	// RVA: 0xE92938 Offset: 0xE8E938 VA: 0xE92938
	private void CreateNewCellLine() { }

	// RVA: 0xE9330C Offset: 0xE8F30C VA: 0xE9330C
	private void ClearEmptyCellLine(int existingItemCount) { }

	// RVA: 0xE93560 Offset: 0xE8F560 VA: 0xE93560
	public void AddNewItem(Item item) { }

	// RVA: 0xE9363C Offset: 0xE8F63C VA: 0xE9363C
	public void ReplaceItem(Item item) { }

	// RVA: 0xE93228 Offset: 0xE8F228 VA: 0xE93228
	public void ApplyItem(Item item, int cellindex) { }

	// RVA: 0xE93720 Offset: 0xE8F720 VA: 0xE93720
	public void ClearAll() { }

	// RVA: 0xE93160 Offset: 0xE8F160 VA: 0xE93160
	public void ClearCell(int cellindex) { }

	// RVA: 0xE937A8 Offset: 0xE8F7A8 VA: 0xE937A8
	public void ClearByItemIndex(int itemindex) { }

	// RVA: 0xE93878 Offset: 0xE8F878 VA: 0xE93878
	public void EquipCheckRequiredAttribAllItem() { }

	// RVA: 0xE938F8 Offset: 0xE8F8F8 VA: 0xE938F8
	public void SetMoney(long value) { }

	// RVA: 0xE939D8 Offset: 0xE8F9D8 VA: 0xE939D8
	public void SetKnb(long value) { }

	// RVA: 0xE93AB8 Offset: 0xE8FAB8 VA: 0xE93AB8
	public void ResetStorageCount() { }

	// RVA: 0xE93C24 Offset: 0xE8FC24 VA: 0xE93C24
	public void SetOnClickOption(Action<int, PlayerSelfBagarate.Cell> action) { }

	// RVA: 0xE93C2C Offset: 0xE8FC2C VA: 0xE93C2C
	public void SetActiveEquipmentSeries(bool enabled) { }

	// RVA: 0xE93D00 Offset: 0xE8FD00 VA: 0xE93D00
	public void CheckPositionForStorageExtensionOpen() { }

	// RVA: 0xE93E78 Offset: 0xE8FE78 VA: 0xE93E78
	public void CheckPositionForStorageExtensionClose() { }

	// RVA: 0xE93EE4 Offset: 0xE8FEE4 VA: 0xE93EE4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE93FC0 Offset: 0xE8FFC0 VA: 0xE93FC0
	private void <Start>b__30_0() { }

	[CompilerGenerated]
	// RVA: 0xE9408C Offset: 0xE9008C VA: 0xE9408C
	private void <Start>b__30_4() { }

	[CompilerGenerated]
	// RVA: 0xE94100 Offset: 0xE90100 VA: 0xE94100
	private void <Start>b__30_5() { }

	[CompilerGenerated]
	// RVA: 0xE94124 Offset: 0xE90124 VA: 0xE94124
	private void <ShowDirectly>b__37_0() { }

	[CompilerGenerated]
	// RVA: 0xE94158 Offset: 0xE90158 VA: 0xE94158
	private void <ClearAll>b__46_0() { }

	[CompilerGenerated]
	// RVA: 0xE94370 Offset: 0xE90370 VA: 0xE94370
	private void <EquipCheckRequiredAttribAllItem>b__49_0() { }
}

// Namespace: 
private class PlayerSelfChoision.Template // TypeDefIndex: 2655
{
	// Fields
	public GameObject go; // 0x10
	public TextMeshProUGUI tmp; // 0x18
	public Button button; // 0x20

	// Methods

	// RVA: 0xE95B88 Offset: 0xE91B88 VA: 0xE95B88
	public void .ctor(GameObject go) { }

	// RVA: 0xE960D0 Offset: 0xE920D0 VA: 0xE960D0
	public PlayerSelfChoision.Template Clone(GameObject parent) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfChoision.<>c__DisplayClass11_0 // TypeDefIndex: 2656
{
	// Fields
	public PlayerSelfChoision <>4__this; // 0x10
	public string name; // 0x18
	public Action action; // 0x20
	public UnityAction <>9__2; // 0x28

	// Methods

	// RVA: 0xE960C0 Offset: 0xE920C0 VA: 0xE960C0
	public void .ctor() { }

	// RVA: 0xE961A8 Offset: 0xE921A8 VA: 0xE961A8
	internal void <AddSelection>b__0() { }

	// RVA: 0xE96388 Offset: 0xE92388 VA: 0xE96388
	internal void <AddSelection>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfChoision.<>c__DisplayClass11_1 // TypeDefIndex: 2657
{
	// Fields
	public PlayerSelfChoision.Template field; // 0x10

	// Methods

	// RVA: 0xE96380 Offset: 0xE92380 VA: 0xE96380
	public void .ctor() { }

	// RVA: 0xE963BC Offset: 0xE923BC VA: 0xE963BC
	internal void <AddSelection>b__1() { }
}

// Namespace: game.ui
public class PlayerSelfChoision : MonoBehaviour // TypeDefIndex: 2658
{
	// Fields
	[SerializeField]
	private GameObject contentGo; // 0x20
	[SerializeField]
	private GameObject fieldTemplateGo; // 0x28
	private Queue<Action> onStartActions; // 0x30
	private bool isStarted; // 0x38
	private Queue<Action> onCloseAction; // 0x40
	private PlayerSelfChoision.Template fieldTemplate; // 0x48

	// Methods

	// RVA: 0xE95A9C Offset: 0xE91A9C VA: 0xE95A9C
	private void Start() { }

	// RVA: 0xE95CAC Offset: 0xE91CAC VA: 0xE95CAC
	private void Perform(Action action) { }

	// RVA: 0xE95D7C Offset: 0xE91D7C VA: 0xE95D7C
	private void OnClose(Action action) { }

	// RVA: 0xE95E28 Offset: 0xE91E28 VA: 0xE95E28
	public void Close() { }

	// RVA: 0xE95F64 Offset: 0xE91F64 VA: 0xE95F64
	public void AddSelection(string name, Action action) { }

	// RVA: 0xE960C8 Offset: 0xE920C8 VA: 0xE960C8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerSelfEquipmentSeriers.<>c // TypeDefIndex: 2659
{
	// Fields
	public static readonly PlayerSelfEquipmentSeriers.<>c <>9; // 0x0
	public static UnityAction <>9__49_0; // 0x8

	// Methods

	// RVA: 0xE982DC Offset: 0xE942DC VA: 0xE982DC
	private static void .cctor() { }

	// RVA: 0xE98344 Offset: 0xE94344 VA: 0xE98344
	public void .ctor() { }

	// RVA: 0xE9834C Offset: 0xE9434C VA: 0xE9834C
	internal void <Start>b__49_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfEquipmentSeriers.<>c__DisplayClass52_0 // TypeDefIndex: 2660
{
	// Fields
	public float secondsRemaining; // 0x10
	public PlayerSelfEquipmentSeriers <>4__this; // 0x18
	public RectTransform rect; // 0x20
	public Vector2 to; // 0x28
	public Action onFinish; // 0x30
	public float speedOnSeconds; // 0x38

	// Methods

	// RVA: 0xE97314 Offset: 0xE93314 VA: 0xE97314
	public void .ctor() { }

	// RVA: 0xE98410 Offset: 0xE94410 VA: 0xE98410
	internal void <LeanMoveLocal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfEquipmentSeriers.<>c__DisplayClass54_0 // TypeDefIndex: 2661
{
	// Fields
	public PlayerSelfEquipmentSeriers <>4__this; // 0x10
	public int place; // 0x18
	public PlayerSelfProperties.EquipmentItem equipcell; // 0x20
	public UnityAction <>9__1; // 0x28

	// Methods

	// RVA: 0xE974A4 Offset: 0xE934A4 VA: 0xE974A4
	public void .ctor() { }

	// RVA: 0xE985B4 Offset: 0xE945B4 VA: 0xE985B4
	internal void <EquipItem>b__0() { }

	// RVA: 0xE989C0 Offset: 0xE949C0 VA: 0xE989C0
	internal void <EquipItem>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfEquipmentSeriers.<>c__DisplayClass56_0 // TypeDefIndex: 2662
{
	// Fields
	public PlayerSelfEquipmentSeriers <>4__this; // 0x10
	public int place; // 0x18

	// Methods

	// RVA: 0xE975F4 Offset: 0xE935F4 VA: 0xE975F4
	public void .ctor() { }

	// RVA: 0xE98F38 Offset: 0xE94F38 VA: 0xE98F38
	internal void <EquipClearPlace>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfEquipmentSeriers.<>c__DisplayClass57_0 // TypeDefIndex: 2663
{
	// Fields
	public PlayerSelfEquipmentSeriers <>4__this; // 0x10
	public int place; // 0x18
	public bool passed; // 0x1C

	// Methods

	// RVA: 0xE976D8 Offset: 0xE936D8 VA: 0xE976D8
	public void .ctor() { }

	// RVA: 0xE99014 Offset: 0xE95014 VA: 0xE99014
	internal void <SetRequiredPassed>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfEquipmentSeriers.<>c__DisplayClass62_0 // TypeDefIndex: 2664
{
	// Fields
	public bool enabled; // 0x10
	public PlayerSelfEquipmentSeriers <>4__this; // 0x18

	// Methods

	// RVA: 0xE97828 Offset: 0xE93828 VA: 0xE97828
	public void .ctor() { }

	// RVA: 0xE990FC Offset: 0xE950FC VA: 0xE990FC
	internal void <ShowDirectly>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfEquipmentSeriers.<>c__DisplayClass63_0 // TypeDefIndex: 2665
{
	// Fields
	public bool enabled; // 0x10
	public PlayerSelfEquipmentSeriers <>4__this; // 0x18
	public Action <>9__1; // 0x20

	// Methods

	// RVA: 0xE97920 Offset: 0xE93920 VA: 0xE97920
	public void .ctor() { }

	// RVA: 0xE99164 Offset: 0xE95164 VA: 0xE99164
	internal void <ShowOpen>b__0() { }

	// RVA: 0xE99288 Offset: 0xE95288 VA: 0xE99288
	internal void <ShowOpen>b__1() { }
}

// Namespace: game.ui
public class PlayerSelfEquipmentSeriers : MonoBehaviour // TypeDefIndex: 2666
{
	// Fields
	private const int OriginFramedWidth = 428;
	private const int OriginFramedHeight = 430;
	[SerializeField]
	private RectTransform framedRect; // 0x20
	[SerializeField]
	private Image backgroundImage; // 0x28
	[SerializeField]
	private TextMeshProUGUI propertiesDescription; // 0x30
	[SerializeField]
	private TextMeshProUGUI propertiesHelm; // 0x38
	[SerializeField]
	private TextMeshProUGUI propertiesAmulet; // 0x40
	[SerializeField]
	private TextMeshProUGUI propertiesWeapon; // 0x48
	[SerializeField]
	private TextMeshProUGUI propertiesArmor; // 0x50
	[SerializeField]
	private TextMeshProUGUI propertiesBelt; // 0x58
	[SerializeField]
	private TextMeshProUGUI propertiesCuff; // 0x60
	[SerializeField]
	private TextMeshProUGUI propertiesRingAbove; // 0x68
	[SerializeField]
	private TextMeshProUGUI propertiesRingBelow; // 0x70
	[SerializeField]
	private TextMeshProUGUI propertiesPendant; // 0x78
	[SerializeField]
	private TextMeshProUGUI propertiesBoot; // 0x80
	[SerializeField]
	private Button functionsBagarate; // 0x88
	[SerializeField]
	private Button functionsPropertiesButton; // 0x90
	[SerializeField]
	private Image functionsPropertiesImage; // 0x98
	[SerializeField]
	private TextMeshProUGUI functionsPropertiesText; // 0xA0
	[SerializeField]
	private Button functionsClose; // 0xA8
	[SerializeField]
	private GameObject equipmentHelmGo; // 0xB0
	[SerializeField]
	private GameObject equipmentAmuletGo; // 0xB8
	[SerializeField]
	private GameObject equipmentWeaponGo; // 0xC0
	[SerializeField]
	private GameObject equipmentArmorGo; // 0xC8
	[SerializeField]
	private GameObject equipmentBeltGo; // 0xD0
	[SerializeField]
	private GameObject equipmentCuffGo; // 0xD8
	[SerializeField]
	private GameObject equipmentRingAboveGo; // 0xE0
	[SerializeField]
	private GameObject equipmentRingBelowGo; // 0xE8
	[SerializeField]
	private GameObject equipmentPendantGo; // 0xF0
	[SerializeField]
	private GameObject equipmentBootGo; // 0xF8
	private float scaleRatio; // 0x100
	private Vector2 showoffVisiblePosition; // 0x104
	private Vector2 showoffHiddenPosition; // 0x10C
	private readonly Queue<Action> onStartActions; // 0x118
	private bool isStarted; // 0x120
	private Action leanMoveLocalUpdating; // 0x128
	private readonly PlayerSelfProperties.EquipmentItem equipmentHelm; // 0x130
	private readonly PlayerSelfProperties.EquipmentItem equipmentAmulet; // 0x138
	private readonly PlayerSelfProperties.EquipmentItem equipmentWeapon; // 0x140
	private readonly PlayerSelfProperties.EquipmentItem equipmentArmor; // 0x148
	private readonly PlayerSelfProperties.EquipmentItem equipmentBelt; // 0x150
	private readonly PlayerSelfProperties.EquipmentItem equipmentCuff; // 0x158
	private readonly PlayerSelfProperties.EquipmentItem equipmentRingAbove; // 0x160
	private readonly PlayerSelfProperties.EquipmentItem equipmentRingBelow; // 0x168
	private readonly PlayerSelfProperties.EquipmentItem equipmentPendant; // 0x170
	private readonly PlayerSelfProperties.EquipmentItem equipmentBoot; // 0x178
	private Dictionary<int, PlayerSelfProperties.EquipmentItem> equipPlace; // 0x180
	private Dictionary<int, TextMeshProUGUI> itemTypeNamePlace; // 0x188
	private PlayerSelfBagarate bagarateTabAsPc; // 0x190
	public static string[] static_seriesTmp; // 0x0

	// Methods

	// RVA: 0xE96424 Offset: 0xE92424 VA: 0xE96424
	private void Start() { }

	// RVA: 0xE970C8 Offset: 0xE930C8 VA: 0xE970C8
	private void Update() { }

	// RVA: 0xE970E4 Offset: 0xE930E4 VA: 0xE970E4
	private void Perform(Action action) { }

	// RVA: 0xE97160 Offset: 0xE93160 VA: 0xE97160
	private void LeanMoveLocal(RectTransform rect, Vector2 to, Action onFinish) { }

	// RVA: 0xE9731C Offset: 0xE9331C VA: 0xE9731C
	private PlayerSelfBagarate GetBagarateTab() { }

	// RVA: 0xE973C0 Offset: 0xE933C0 VA: 0xE973C0
	public void EquipItem(int place, PlayerSelfProperties.EquipmentItem equipcell) { }

	// RVA: 0xE974AC Offset: 0xE934AC VA: 0xE974AC
	public void EquipClearAll() { }

	// RVA: 0xE9752C Offset: 0xE9352C VA: 0xE9752C
	public void EquipClearPlace(int place) { }

	// RVA: 0xE975FC Offset: 0xE935FC VA: 0xE975FC
	public void SetRequiredPassed(int place, bool passed) { }

	// RVA: 0xE96DBC Offset: 0xE92DBC VA: 0xE96DBC
	private string ToTMP(string color, string content) { }

	// RVA: 0xE947D8 Offset: 0xE907D8 VA: 0xE947D8
	public static string ToSeriersTMP(int series) { }

	// RVA: 0xE976E0 Offset: 0xE936E0 VA: 0xE976E0
	public static string ToSeriersTMP(Item item) { }

	// RVA: 0xE97740 Offset: 0xE93740 VA: 0xE97740
	public void ShowDirectly(bool enabled) { }

	// RVA: 0xE97830 Offset: 0xE93830 VA: 0xE97830
	public void ShowOpen(bool enabled) { }

	// RVA: 0xE97928 Offset: 0xE93928 VA: 0xE97928
	public bool ShowOff() { }

	// RVA: 0xE97980 Offset: 0xE93980 VA: 0xE97980
	public bool IsOpen() { }

	// RVA: 0xE979A0 Offset: 0xE939A0 VA: 0xE979A0
	public void .ctor() { }

	// RVA: 0xE97CD0 Offset: 0xE93CD0 VA: 0xE97CD0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xE97E50 Offset: 0xE93E50 VA: 0xE97E50
	private void <Start>b__49_1() { }

	[CompilerGenerated]
	// RVA: 0xE97FA4 Offset: 0xE93FA4 VA: 0xE97FA4
	private void <Start>b__49_2() { }

	[CompilerGenerated]
	// RVA: 0xE98014 Offset: 0xE94014 VA: 0xE98014
	private void <EquipClearAll>b__55_0() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerSelfPropPoint.<>c // TypeDefIndex: 2667
{
	// Fields
	public static readonly PlayerSelfPropPoint.<>c <>9; // 0x0
	public static Action<string> <>9__12_5; // 0x8
	public static UnityAction <>9__12_1; // 0x10
	public static Action<string> <>9__12_6; // 0x18
	public static UnityAction <>9__12_2; // 0x20
	public static Action<string> <>9__12_7; // 0x28
	public static UnityAction <>9__12_3; // 0x30
	public static Action<string> <>9__12_8; // 0x38
	public static UnityAction <>9__12_4; // 0x40

	// Methods

	// RVA: 0xE9ABFC Offset: 0xE96BFC VA: 0xE9ABFC
	private static void .cctor() { }

	// RVA: 0xE9AC64 Offset: 0xE96C64 VA: 0xE9AC64
	public void .ctor() { }

	// RVA: 0xE9AC6C Offset: 0xE96C6C VA: 0xE9AC6C
	internal void <Start>b__12_1() { }

	// RVA: 0xE9AEA8 Offset: 0xE96EA8 VA: 0xE9AEA8
	internal void <Start>b__12_5(string _value) { }

	// RVA: 0xE9AFE4 Offset: 0xE96FE4 VA: 0xE9AFE4
	internal void <Start>b__12_2() { }

	// RVA: 0xE9B220 Offset: 0xE97220 VA: 0xE9B220
	internal void <Start>b__12_6(string _value) { }

	// RVA: 0xE9B35C Offset: 0xE9735C VA: 0xE9B35C
	internal void <Start>b__12_3() { }

	// RVA: 0xE9B598 Offset: 0xE97598 VA: 0xE9B598
	internal void <Start>b__12_7(string _value) { }

	// RVA: 0xE9B6D4 Offset: 0xE976D4 VA: 0xE9B6D4
	internal void <Start>b__12_4() { }

	// RVA: 0xE9B910 Offset: 0xE97910 VA: 0xE9B910
	internal void <Start>b__12_8(string _value) { }
}

// Namespace: game.ui
public class PlayerSelfPropPoint : MonoBehaviour // TypeDefIndex: 2668
{
	// Fields
	[SerializeField]
	private Image framedImage; // 0x20
	[SerializeField]
	private TextMeshProUGUI descriptionTmp; // 0x28
	[SerializeField]
	private TextMeshProUGUI leftPointTmp; // 0x30
	[SerializeField]
	private TextMeshProUGUI sucmanhTmp; // 0x38
	[SerializeField]
	private TextMeshProUGUI thanphapTmp; // 0x40
	[SerializeField]
	private TextMeshProUGUI sinhkhiTmp; // 0x48
	[SerializeField]
	private TextMeshProUGUI noicongTmp; // 0x50
	[SerializeField]
	private Button sucmanhButton; // 0x58
	[SerializeField]
	private Button thanphapButton; // 0x60
	[SerializeField]
	private Button sinhkhiButton; // 0x68
	[SerializeField]
	private Button noicongButton; // 0x70
	[SerializeField]
	private Button closeButton; // 0x78

	// Methods

	// RVA: 0xE992B4 Offset: 0xE952B4 VA: 0xE992B4
	private void Start() { }

	// RVA: 0xE99600 Offset: 0xE95600 VA: 0xE99600
	public void Open() { }

	// RVA: 0xE9A87C Offset: 0xE9687C VA: 0xE9A87C
	public void OnSync() { }

	// RVA: 0xE9AB70 Offset: 0xE96B70 VA: 0xE9AB70
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xE9AB78 Offset: 0xE96B78 VA: 0xE9AB78
	private void <Start>b__12_0() { }
}

// Namespace: 
public class PlayerSelfProperties.EquipmentItem // TypeDefIndex: 2669
{
	// Fields
	public GameObject go; // 0x10
	public Image backgroundColor; // 0x18
	public ItemBorder itemBorder; // 0x20
	public Image itemImage; // 0x28
	public RectTransform itemImageRect; // 0x30
	public Button cellButton; // 0x38
	public TextMeshProUGUI seriesText; // 0x40
	public string name; // 0x48
	public Item item; // 0x50

	// Methods

	// RVA: 0xE96E6C Offset: 0xE92E6C VA: 0xE96E6C
	public void SetGo(GameObject go) { }

	// RVA: 0xE9D1FC Offset: 0xE991FC VA: 0xE9D1FC
	public void SetGo(GameObject go, string name) { }

	// RVA: 0xE98288 Offset: 0xE94288 VA: 0xE98288
	public void Clear() { }

	// RVA: 0xEA0098 Offset: 0xE9C098 VA: 0xEA0098
	public void SetItem(Item item) { }

	// RVA: 0xE9882C Offset: 0xE9482C VA: 0xE9882C
	public void Apply(Item item, Sprite thumbnailSprite, bool usingRectBagarate = False) { }

	// RVA: 0xE99090 Offset: 0xE95090 VA: 0xE99090
	public void SetRequiredPassed(bool isPassed) { }

	// RVA: 0xE97C9C Offset: 0xE93C9C VA: 0xE97C9C
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerSelfProperties.<>c // TypeDefIndex: 2670
{
	// Fields
	public static readonly PlayerSelfProperties.<>c <>9; // 0x0
	public static UnityAction <>9__83_0; // 0x8
	public static UnityAction <>9__83_1; // 0x10
	public static UnityAction <>9__83_2; // 0x18
	public static UnityAction <>9__83_3; // 0x20
	public static UnityAction <>9__83_4; // 0x28
	public static UnityAction <>9__83_7; // 0x30
	public static UnityAction <>9__88_1; // 0x38
	public static UnityAction <>9__88_2; // 0x40

	// Methods

	// RVA: 0xEA00A0 Offset: 0xE9C0A0 VA: 0xEA00A0
	private static void .cctor() { }

	// RVA: 0xEA0108 Offset: 0xE9C108 VA: 0xEA0108
	public void .ctor() { }

	// RVA: 0xEA0110 Offset: 0xE9C110 VA: 0xEA0110
	internal void <Start>b__83_0() { }

	// RVA: 0xEA01A4 Offset: 0xE9C1A4 VA: 0xEA01A4
	internal void <Start>b__83_1() { }

	// RVA: 0xEA0274 Offset: 0xE9C274 VA: 0xEA0274
	internal void <Start>b__83_2() { }

	// RVA: 0xEA0344 Offset: 0xE9C344 VA: 0xEA0344
	internal void <Start>b__83_3() { }

	// RVA: 0xEA0398 Offset: 0xE9C398 VA: 0xEA0398
	internal void <Start>b__83_4() { }

	// RVA: 0xEA045C Offset: 0xE9C45C VA: 0xEA045C
	internal void <Start>b__83_7() { }

	// RVA: 0xEA0500 Offset: 0xE9C500 VA: 0xEA0500
	internal void <SetLockState>b__88_1() { }

	// RVA: 0xEA05A4 Offset: 0xE9C5A4 VA: 0xEA05A4
	internal void <SetLockState>b__88_2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfProperties.<>c__DisplayClass101_0 // TypeDefIndex: 2671
{
	// Fields
	public PlayerSelfProperties <>4__this; // 0x10
	public int place; // 0x18

	// Methods

	// RVA: 0xE9E25C Offset: 0xE9A25C VA: 0xE9E25C
	public void .ctor() { }

	// RVA: 0xEA0648 Offset: 0xE9C648 VA: 0xEA0648
	internal void <EquipClearPlace>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfProperties.<>c__DisplayClass105_0 // TypeDefIndex: 2672
{
	// Fields
	public bool enabled; // 0x10
	public PlayerSelfProperties <>4__this; // 0x18
	public Action <>9__1; // 0x20

	// Methods

	// RVA: 0xE9E45C Offset: 0xE9A45C VA: 0xE9E45C
	public void .ctor() { }

	// RVA: 0xEA0670 Offset: 0xE9C670 VA: 0xEA0670
	internal void <ShowOpen>b__0() { }

	// RVA: 0xEA07AC Offset: 0xE9C7AC VA: 0xEA07AC
	internal void <ShowOpen>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfProperties.<>c__DisplayClass86_0 // TypeDefIndex: 2673
{
	// Fields
	public float secondsRemaining; // 0x10
	public PlayerSelfProperties <>4__this; // 0x18
	public RectTransform rect; // 0x20
	public Vector2 to; // 0x28
	public Action onFinish; // 0x30
	public float speedOnSeconds; // 0x38

	// Methods

	// RVA: 0xE9D474 Offset: 0xE99474 VA: 0xE9D474
	public void .ctor() { }

	// RVA: 0xEA07D8 Offset: 0xE9C7D8 VA: 0xEA07D8
	internal void <LeanMoveLocal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfProperties.<>c__DisplayClass88_0 // TypeDefIndex: 2674
{
	// Fields
	public PlayerSelfProperties <>4__this; // 0x10
	public bool isLocked; // 0x18

	// Methods

	// RVA: 0xE9D548 Offset: 0xE99548 VA: 0xE9D548
	public void .ctor() { }

	// RVA: 0xEA097C Offset: 0xE9C97C VA: 0xEA097C
	internal void <SetLockState>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfProperties.<>c__DisplayClass99_0 // TypeDefIndex: 2675
{
	// Fields
	public PlayerSelfProperties.EquipmentItem _cell; // 0x10
	public Item item; // 0x18
	public PlayerSelfProperties <>4__this; // 0x20
	public int place; // 0x28
	public UnityAction <>9__1; // 0x30

	// Methods

	// RVA: 0xE9E06C Offset: 0xE9A06C VA: 0xE9E06C
	public void .ctor() { }

	// RVA: 0xEA0BF0 Offset: 0xE9CBF0 VA: 0xEA0BF0
	internal void <EquipItem>b__0() { }

	// RVA: 0xEA0D2C Offset: 0xE9CD2C VA: 0xEA0D2C
	internal void <EquipItem>b__1() { }
}

// Namespace: game.ui
public class PlayerSelfProperties : MonoBehaviour // TypeDefIndex: 2676
{
	// Fields
	private const int OriginFramedWidth = 428;
	private const int OriginFramedHeight = 430;
	[SerializeField]
	private RectTransform framedRect; // 0x20
	[SerializeField]
	private Image backgroundMaleImage; // 0x28
	[SerializeField]
	private Image backgroundFemaleImage; // 0x30
	[SerializeField]
	private TextMeshProUGUI propertiesName; // 0x38
	[SerializeField]
	private TextMeshProUGUI propertiesCid; // 0x40
	[SerializeField]
	private TextMeshProUGUI propertiesSeries; // 0x48
	[SerializeField]
	private TextMeshProUGUI propertiesLevel; // 0x50
	[SerializeField]
	private TextMeshProUGUI propertiesLucky; // 0x58
	[SerializeField]
	private TextMeshProUGUI propertiesPk; // 0x60
	[SerializeField]
	private TextMeshProUGUI propertiesRank; // 0x68
	[SerializeField]
	private Image propertiesFactionIcon; // 0x70
	[SerializeField]
	private TextMeshProUGUI propertiesHealth; // 0x78
	[SerializeField]
	private TextMeshProUGUI propertiesMana; // 0x80
	[SerializeField]
	private TextMeshProUGUI propertiesStamina; // 0x88
	[SerializeField]
	private TextMeshProUGUI propertiesOtherText; // 0x90
	[SerializeField]
	private Button propertiesOtherButton; // 0x98
	[SerializeField]
	private TextMeshProUGUI propertiesExp; // 0xA0
	[SerializeField]
	private TextMeshProUGUI propertiesPower; // 0xA8
	[SerializeField]
	private TextMeshProUGUI propertiesVitality; // 0xB0
	[SerializeField]
	private TextMeshProUGUI propertiesAgility; // 0xB8
	[SerializeField]
	private TextMeshProUGUI propertiesInside; // 0xC0
	[SerializeField]
	private TextMeshProUGUI propertiesHandstrengthLeft; // 0xC8
	[SerializeField]
	private Button propertiesHandstrengthLeftDetailsButton; // 0xD0
	[SerializeField]
	private TextMeshProUGUI propertiesHandstrengthRight; // 0xD8
	[SerializeField]
	private Button propertiesHandstrengthRightDetailsButton; // 0xE0
	[SerializeField]
	private TextMeshProUGUI propertiesAccuracy; // 0xE8
	[SerializeField]
	private TextMeshProUGUI propertiesEvade; // 0xF0
	[SerializeField]
	private TextMeshProUGUI propertiesRunSpeed; // 0xF8
	[SerializeField]
	private TextMeshProUGUI propertiesAttackSpeed; // 0x100
	[SerializeField]
	private TextMeshProUGUI propertiesLeftPropPoint; // 0x108
	[SerializeField]
	private Image propertiesLeftPropPointAddIcon1; // 0x110
	[SerializeField]
	private Image propertiesLeftPropPointAddIcon2; // 0x118
	[SerializeField]
	private Image propertiesLeftPropPointAddIcon3; // 0x120
	[SerializeField]
	private Image propertiesLeftPropPointAddIcon4; // 0x128
	[SerializeField]
	private RectTransform propertiesLeftPropPointAddIconGroup; // 0x130
	[SerializeField]
	private Button propertiesLeftPropPointAddButton; // 0x138
	[SerializeField]
	private TextMeshProUGUI propertiesPhongThu; // 0x140
	[SerializeField]
	private TextMeshProUGUI propertiesKhangHan; // 0x148
	[SerializeField]
	private TextMeshProUGUI propertiesKhangLoi; // 0x150
	[SerializeField]
	private TextMeshProUGUI propertiesKhangHoa; // 0x158
	[SerializeField]
	private TextMeshProUGUI propertiesKhangDoc; // 0x160
	[SerializeField]
	private GameObject equipmentHelmGo; // 0x168
	[SerializeField]
	private GameObject equipmentAmuletGo; // 0x170
	[SerializeField]
	private GameObject equipmentWeaponGo; // 0x178
	[SerializeField]
	private GameObject equipmentArmorGo; // 0x180
	[SerializeField]
	private GameObject equipmentBeltGo; // 0x188
	[SerializeField]
	private GameObject equipmentCuffGo; // 0x190
	[SerializeField]
	private GameObject equipmentRingAboveGo; // 0x198
	[SerializeField]
	private GameObject equipmentRingBelowGo; // 0x1A0
	[SerializeField]
	private GameObject equipmentPendantGo; // 0x1A8
	[SerializeField]
	private GameObject equipmentBootGo; // 0x1B0
	[SerializeField]
	private GameObject equipmentHorseGo; // 0x1B8
	[SerializeField]
	private Button functionsBagarate; // 0x1C0
	[SerializeField]
	private Button functionsEquipmentSeriresButton; // 0x1C8
	[SerializeField]
	private Image functionsEquipmentSeriresImage; // 0x1D0
	[SerializeField]
	private TextMeshProUGUI functionsEquipmentSeriresText; // 0x1D8
	[SerializeField]
	private Button functionsClose; // 0x1E0
	[SerializeField]
	private Button functionsLockButton; // 0x1E8
	[SerializeField]
	private Image functionsLockImage; // 0x1F0
	[SerializeField]
	private TextMeshProUGUI functionsLockTmp; // 0x1F8
	private float scaleRatio; // 0x200
	private Vector2 showoffVisiblePosition; // 0x204
	private Vector2 showoffHiddenPosition; // 0x20C
	private readonly Queue<Action> onStartActions; // 0x218
	private bool isStarted; // 0x220
	private Action leanMoveLocalUpdating; // 0x228
	private readonly PlayerSelfProperties.EquipmentItem equipmentHelm; // 0x230
	private readonly PlayerSelfProperties.EquipmentItem equipmentAmulet; // 0x238
	private readonly PlayerSelfProperties.EquipmentItem equipmentWeapon; // 0x240
	private readonly PlayerSelfProperties.EquipmentItem equipmentArmor; // 0x248
	private readonly PlayerSelfProperties.EquipmentItem equipmentBelt; // 0x250
	private readonly PlayerSelfProperties.EquipmentItem equipmentCuff; // 0x258
	private readonly PlayerSelfProperties.EquipmentItem equipmentRingAbove; // 0x260
	private readonly PlayerSelfProperties.EquipmentItem equipmentRingBelow; // 0x268
	private readonly PlayerSelfProperties.EquipmentItem equipmentPendant; // 0x270
	private readonly PlayerSelfProperties.EquipmentItem equipmentBoot; // 0x278
	private readonly PlayerSelfProperties.EquipmentItem equipmentHorse; // 0x280
	private readonly Dictionary<int, PlayerSelfProperties.EquipmentItem> equipPlace; // 0x288
	private readonly Dictionary<int, PlayerSelfProperties.EquipmentItem[]> itemDetailMagicRequired; // 0x290
	private readonly Suite suite; // 0x298
	private static readonly string[] magicRequiredSeriesColor; // 0x0
	private int currentSeries; // 0x2A0
	private int currentFaction; // 0x2A4

	// Methods

	// RVA: 0xE9BA4C Offset: 0xE97A4C VA: 0xE9BA4C
	private void .ctor() { }

	// RVA: 0xE9C654 Offset: 0xE98654 VA: 0xE9C654
	private void Start() { }

	// RVA: 0xE9D228 Offset: 0xE99228 VA: 0xE9D228
	private void Update() { }

	// RVA: 0xE9D244 Offset: 0xE99244 VA: 0xE9D244
	private void Perform(Action action) { }

	// RVA: 0xE9D2C0 Offset: 0xE992C0 VA: 0xE9D2C0
	private void LeanMoveLocal(RectTransform rect, Vector2 to, Action onFinish) { }

	// RVA: 0xE9D47C Offset: 0xE9947C VA: 0xE9D47C
	public void SetLockState(bool isLocked) { }

	// RVA: 0xE9D550 Offset: 0xE99550 VA: 0xE9D550
	public bool AnyGoldItemMappingEquipped(Dictionary<int, bool> goldindexShared) { }

	// RVA: 0xE9D714 Offset: 0xE99714 VA: 0xE9D714
	public bool IsGoldItemEquipped(int goldRowIndex) { }

	// RVA: 0xE9D898 Offset: 0xE99898 VA: 0xE9D898
	public void UnEquipByItemIndex(int itemindex) { }

	// RVA: 0xE956BC Offset: 0xE916BC VA: 0xE956BC
	public Item GetSimilarly(Item item) { }

	// RVA: 0xE9DB98 Offset: 0xE99B98 VA: 0xE9DB98
	public bool IsRangeWeapon() { }

	// RVA: 0xE9DC40 Offset: 0xE99C40 VA: 0xE9DC40
	public bool EquipmentExistingDurabilityDown(int reducedCount) { }

	// RVA: 0xE9DDB0 Offset: 0xE99DB0 VA: 0xE9DDB0
	public bool EquipmentHasDurabilityDown(int durabilityTriggered) { }

	// RVA: 0xE9DBBC Offset: 0xE99BBC VA: 0xE9DBBC
	public Item GetPlaceItem(int place) { }

	// RVA: 0xE98A20 Offset: 0xE94A20 VA: 0xE98A20
	public void EquipPlaceClick(int place) { }

	// RVA: 0xE9DF34 Offset: 0xE99F34 VA: 0xE9DF34
	public void EquipItem(Item item) { }

	// RVA: 0xE9E074 Offset: 0xE9A074 VA: 0xE9E074
	public void EquipClearAll() { }

	// RVA: 0xE9DA38 Offset: 0xE99A38 VA: 0xE9DA38
	public void EquipClearPlace(int place) { }

	// RVA: 0xE9E264 Offset: 0xE9A264 VA: 0xE9E264
	private PlayerSelfEquipmentSeriers GetSeriesTab() { }

	// RVA: 0xE9E2B8 Offset: 0xE9A2B8 VA: 0xE9E2B8
	public void EquipCheckRequiredAttribAllItem() { }

	// RVA: 0xE9D14C Offset: 0xE9914C VA: 0xE9D14C
	private string ToTMP(string color, string content) { }

	// RVA: 0xE9E36C Offset: 0xE9A36C VA: 0xE9E36C
	public void ShowOpen(bool enabled) { }

	// RVA: 0xE94E18 Offset: 0xE90E18 VA: 0xE94E18
	public bool ShowOff() { }

	// RVA: 0xE97EF8 Offset: 0xE93EF8 VA: 0xE97EF8
	public void ShowDirectly(bool enabled) { }

	// RVA: 0xE9E574 Offset: 0xE9A574 VA: 0xE9E574
	public bool IsOpen() { }

	// RVA: 0xE9E594 Offset: 0xE9A594 VA: 0xE9E594
	public void SetFaction(int factionId) { }

	// RVA: 0xE9E6F4 Offset: 0xE9A6F4 VA: 0xE9E6F4
	public void SetHealth(int value) { }

	// RVA: 0xE9E77C Offset: 0xE9A77C VA: 0xE9E77C
	public void SetMana(int value) { }

	// RVA: 0xE9E804 Offset: 0xE9A804 VA: 0xE9E804
	public void SetStamina(int value) { }

	// RVA: 0xE9E88C Offset: 0xE9A88C VA: 0xE9E88C
	public void SetSex(int sexid) { }

	// RVA: 0xE9E924 Offset: 0xE9A924 VA: 0xE9E924
	public void SetCid(string cid) { }

	// RVA: 0xE9E99C Offset: 0xE9A99C VA: 0xE9E99C
	public void SetName(string name) { }

	// RVA: 0xE9EA14 Offset: 0xE9AA14 VA: 0xE9EA14
	public void SetRank(int value) { }

	// RVA: 0xE9EAC4 Offset: 0xE9AAC4 VA: 0xE9EAC4
	public void SetExp(long value, long expOfLevel, float percent) { }

	// RVA: 0xE9EBA0 Offset: 0xE9ABA0 VA: 0xE9EBA0
	public void SetLevel(int level) { }

	// RVA: 0xE9EC30 Offset: 0xE9AC30 VA: 0xE9EC30
	public void SetLucky(int fortune) { }

	// RVA: 0xE9ED34 Offset: 0xE9AD34 VA: 0xE9ED34
	public void SetPk(int value) { }

	// RVA: 0xE9EDBC Offset: 0xE9ADBC VA: 0xE9EDBC
	public void SetSeries(int value) { }

	// RVA: 0xE9EF14 Offset: 0xE9AF14 VA: 0xE9EF14
	public void SetTiemNang(int value) { }

	// RVA: 0xE9EFE0 Offset: 0xE9AFE0 VA: 0xE9EFE0
	public void SetSucManh(int value) { }

	// RVA: 0xE9F070 Offset: 0xE9B070 VA: 0xE9F070
	public void SetSinhKhi(int value) { }

	// RVA: 0xE9F100 Offset: 0xE9B100 VA: 0xE9F100
	public void SetThanPhap(int value) { }

	// RVA: 0xE9F190 Offset: 0xE9B190 VA: 0xE9F190
	public void SetNoiCong(int value) { }

	// RVA: 0xE9F218 Offset: 0xE9B218 VA: 0xE9F218
	public void SetAttackSpeed(int outside, int inside) { }

	// RVA: 0xE9F2F8 Offset: 0xE9B2F8 VA: 0xE9F2F8
	public void SetRunSpeed(int value) { }

	// RVA: 0xE9F3C0 Offset: 0xE9B3C0 VA: 0xE9F3C0
	public void SetPropertiesDefendFields(ReadOnlySpan<byte> data) { }

	// RVA: 0xE9F840 Offset: 0xE9B840 VA: 0xE9F840
	public void SetPropertiesAttackFields(ReadOnlySpan<byte> data) { }

	// RVA: 0xE9FA7C Offset: 0xE9BA7C VA: 0xE9FA7C
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xE9FBFC Offset: 0xE9BBFC VA: 0xE9FBFC
	private void <Start>b__83_5() { }

	[CompilerGenerated]
	// RVA: 0xE9FCB4 Offset: 0xE9BCB4 VA: 0xE9FCB4
	private void <Start>b__83_6() { }

	[CompilerGenerated]
	// RVA: 0xE9FD24 Offset: 0xE9BD24 VA: 0xE9FD24
	private void <EquipClearAll>b__100_0() { }

	[CompilerGenerated]
	// RVA: 0xE9FD3C Offset: 0xE9BD3C VA: 0xE9FD3C
	private void <EquipCheckRequiredAttribAllItem>b__103_0() { }

	[CompilerGenerated]
	// RVA: 0xEA0060 Offset: 0xE9C060 VA: 0xEA0060
	private void <ShowDirectly>b__107_0() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerSelfPropertiesText.<>c // TypeDefIndex: 2677
{
	// Fields
	public static readonly PlayerSelfPropertiesText.<>c <>9; // 0x0
	public static UnityAction <>9__17_0; // 0x8

	// Methods

	// RVA: 0xEA17C0 Offset: 0xE9D7C0 VA: 0xEA17C0
	private static void .cctor() { }

	// RVA: 0xEA1828 Offset: 0xE9D828 VA: 0xEA1828
	public void .ctor() { }

	// RVA: 0xEA1830 Offset: 0xE9D830 VA: 0xEA1830
	internal void <Start>b__17_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfPropertiesText.<>c__DisplayClass20_0 // TypeDefIndex: 2678
{
	// Fields
	public float secondsRemaining; // 0x10
	public PlayerSelfPropertiesText <>4__this; // 0x18
	public RectTransform rect; // 0x20
	public Vector2 to; // 0x28
	public Action onFinish; // 0x30
	public float speedOnSeconds; // 0x38

	// Methods

	// RVA: 0xEA13F4 Offset: 0xE9D3F4 VA: 0xEA13F4
	public void .ctor() { }

	// RVA: 0xEA18F4 Offset: 0xE9D8F4 VA: 0xEA18F4
	internal void <LeanMoveLocal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfPropertiesText.<>c__DisplayClass22_0 // TypeDefIndex: 2679
{
	// Fields
	public bool enabled; // 0x10
	public PlayerSelfPropertiesText <>4__this; // 0x18

	// Methods

	// RVA: 0xEA14E4 Offset: 0xE9D4E4 VA: 0xEA14E4
	public void .ctor() { }

	// RVA: 0xEA1A94 Offset: 0xE9DA94 VA: 0xEA1A94
	internal void <ShowDirectly>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfPropertiesText.<>c__DisplayClass23_0 // TypeDefIndex: 2680
{
	// Fields
	public bool enabled; // 0x10
	public PlayerSelfPropertiesText <>4__this; // 0x18
	public Action <>9__1; // 0x20

	// Methods

	// RVA: 0xEA14EC Offset: 0xE9D4EC VA: 0xEA14EC
	public void .ctor() { }

	// RVA: 0xEA1B3C Offset: 0xE9DB3C VA: 0xEA1B3C
	internal void <ShowOpen>b__0() { }

	// RVA: 0xEA1C40 Offset: 0xE9DC40 VA: 0xEA1C40
	internal void <ShowOpen>b__1() { }
}

// Namespace: game.ui
public class PlayerSelfPropertiesText : MonoBehaviour // TypeDefIndex: 2681
{
	// Fields
	private const int OriginFramedWidth = 428;
	private const int OriginFramedHeight = 430;
	[SerializeField]
	private RectTransform framedRect; // 0x20
	[SerializeField]
	private Image backgroundImage; // 0x28
	[SerializeField]
	private Button functionsBagarate; // 0x30
	[SerializeField]
	private Button functionsPropertiesButton; // 0x38
	[SerializeField]
	private Image functionsPropertiesImage; // 0x40
	[SerializeField]
	private TextMeshProUGUI functionsPropertiesText; // 0x48
	[SerializeField]
	private Button functionsClose; // 0x50
	[SerializeField]
	private ScrollRect contentScrollRect; // 0x58
	[SerializeField]
	private TextMeshProUGUI contentText; // 0x60
	private float scaleRatio; // 0x68
	private Vector2 showoffVisiblePosition; // 0x6C
	private Vector2 showoffHiddenPosition; // 0x74
	private readonly Queue<Action> onStartActions; // 0x80
	private bool isStarted; // 0x88
	private Action leanMoveLocalUpdating; // 0x90

	// Methods

	// RVA: 0xEA0D48 Offset: 0xE9CD48 VA: 0xEA0D48
	private void Start() { }

	// RVA: 0xEA11A8 Offset: 0xE9D1A8 VA: 0xEA11A8
	private void Update() { }

	// RVA: 0xEA11C4 Offset: 0xE9D1C4 VA: 0xEA11C4
	private void Perform(Action action) { }

	// RVA: 0xEA1240 Offset: 0xE9D240 VA: 0xEA1240
	private void LeanMoveLocal(RectTransform rect, Vector2 to, Action onFinish) { }

	// RVA: 0xEA10F8 Offset: 0xE9D0F8 VA: 0xEA10F8
	private string ToTMP(string color, string content) { }

	// RVA: 0xEA13FC Offset: 0xE9D3FC VA: 0xEA13FC
	public void ShowDirectly(bool enabled) { }

	// RVA: 0xE9E484 Offset: 0xE9A484 VA: 0xE9E484
	public void ShowOpen(bool enabled) { }

	// RVA: 0xEA14F4 Offset: 0xE9D4F4 VA: 0xEA14F4
	public bool ShowOff() { }

	// RVA: 0xE9E464 Offset: 0xE9A464 VA: 0xE9E464
	public bool IsOpen() { }

	// RVA: 0xEA153C Offset: 0xE9D53C VA: 0xEA153C
	public void SetContentText(string data) { }

	// RVA: 0xEA1620 Offset: 0xE9D620 VA: 0xEA1620
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEA16A8 Offset: 0xE9D6A8 VA: 0xEA16A8
	private void <Start>b__17_1() { }

	[CompilerGenerated]
	// RVA: 0xEA1750 Offset: 0xE9D750 VA: 0xEA1750
	private void <Start>b__17_2() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerSelfSalesman.<>c // TypeDefIndex: 2682
{
	// Fields
	public static readonly PlayerSelfSalesman.<>c <>9; // 0x0
	public static UnityAction <>9__33_1; // 0x8
	public static Action <>9__33_7; // 0x10
	public static Action <>9__33_8; // 0x18
	public static UnityAction <>9__33_2; // 0x20
	public static Action<string> <>9__33_9; // 0x28
	public static Action <>9__33_10; // 0x30
	public static Action <>9__33_11; // 0x38
	public static UnityAction <>9__33_4; // 0x40
	public static UnityAction <>9__33_5; // 0x48
	public static UnityAction <>9__33_6; // 0x50
	public static Action <>9__37_5; // 0x58

	// Methods

	// RVA: 0xEA441C Offset: 0xEA041C VA: 0xEA441C
	private static void .cctor() { }

	// RVA: 0xEA4484 Offset: 0xEA0484 VA: 0xEA4484
	public void .ctor() { }

	// RVA: 0xEA448C Offset: 0xEA048C VA: 0xEA448C
	internal void <Start>b__33_1() { }

	// RVA: 0xEA4534 Offset: 0xEA0534 VA: 0xEA4534
	internal void <Start>b__33_2() { }

	// RVA: 0xEA4748 Offset: 0xEA0748 VA: 0xEA4748
	internal void <Start>b__33_7() { }

	// RVA: 0xEA47D8 Offset: 0xEA07D8 VA: 0xEA47D8
	internal void <Start>b__33_8() { }

	// RVA: 0xEA47DC Offset: 0xEA07DC VA: 0xEA47DC
	internal void <Start>b__33_9(string _title) { }

	// RVA: 0xEA48DC Offset: 0xEA08DC VA: 0xEA48DC
	internal void <Start>b__33_4() { }

	// RVA: 0xEA4AF0 Offset: 0xEA0AF0 VA: 0xEA4AF0
	internal void <Start>b__33_10() { }

	// RVA: 0xEA4B80 Offset: 0xEA0B80 VA: 0xEA4B80
	internal void <Start>b__33_11() { }

	// RVA: 0xEA4B84 Offset: 0xEA0B84 VA: 0xEA4B84
	internal void <Start>b__33_5() { }

	// RVA: 0xEA4C50 Offset: 0xEA0C50 VA: 0xEA4C50
	internal void <Start>b__33_6() { }

	// RVA: 0xEA4CB4 Offset: 0xEA0CB4 VA: 0xEA4CB4
	internal void <ShowOpen>b__37_5() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSalesman.<>c__DisplayClass36_0 // TypeDefIndex: 2683
{
	// Fields
	public float secondsRemaining; // 0x10
	public PlayerSelfSalesman <>4__this; // 0x18
	public RectTransform rect; // 0x20
	public Vector2 to; // 0x28
	public Action onFinish; // 0x30
	public float speedOnSeconds; // 0x38

	// Methods

	// RVA: 0xEA2778 Offset: 0xE9E778 VA: 0xEA2778
	public void .ctor() { }

	// RVA: 0xEA4CB8 Offset: 0xEA0CB8 VA: 0xEA4CB8
	internal void <LeanMoveLocal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSalesman.<>c__DisplayClass37_0 // TypeDefIndex: 2684
{
	// Fields
	public PlayerSelfBagarate.Cell _bagarateCell; // 0x10
	public PlayerSelfSalesman <>4__this; // 0x18
	public Action<long, long> <>9__4; // 0x20

	// Methods

	// RVA: 0xEA43BC Offset: 0xEA03BC VA: 0xEA43BC
	public void .ctor() { }

	// RVA: 0xEA4E58 Offset: 0xEA0E58 VA: 0xEA4E58
	internal void <ShowOpen>b__3() { }

	// RVA: 0xEA51C0 Offset: 0xEA11C0 VA: 0xEA51C0
	internal void <ShowOpen>b__4(long _2money, long _2knb) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSalesman.<>c__DisplayClass45_0 // TypeDefIndex: 2685
{
	// Fields
	public PlayerSelfSalesman <>4__this; // 0x10
	public Item item; // 0x18
	public string appendEndOfRequiredMagic; // 0x20
	public Action <>9__2; // 0x28
	public Action <>9__1; // 0x30

	// Methods

	// RVA: 0xEA3240 Offset: 0xE9F240 VA: 0xEA3240
	public void .ctor() { }

	// RVA: 0xEA5284 Offset: 0xEA1284 VA: 0xEA5284
	internal void <AddItem>b__0() { }

	// RVA: 0xEA5480 Offset: 0xEA1480 VA: 0xEA5480
	internal void <AddItem>b__1() { }

	// RVA: 0xEA5644 Offset: 0xEA1644 VA: 0xEA5644
	internal void <AddItem>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSalesman.<>c__DisplayClass48_0 // TypeDefIndex: 2686
{
	// Fields
	public PlayerSelfSalesman <>4__this; // 0x10
	public SalesmanGetStallDataResponse message; // 0x18

	// Methods

	// RVA: 0xEA34A4 Offset: 0xE9F4A4 VA: 0xEA34A4
	public void .ctor() { }

	// RVA: 0xEA5744 Offset: 0xEA1744 VA: 0xEA5744
	internal void <ProtocolSalesmanGetStallDataResponse>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSalesman.<>c__DisplayClass49_0 // TypeDefIndex: 2687
{
	// Fields
	public SalesmanAddItem message; // 0x10
	public PlayerSelfSalesman <>4__this; // 0x18

	// Methods

	// RVA: 0xEA3580 Offset: 0xE9F580 VA: 0xEA3580
	public void .ctor() { }

	// RVA: 0xEA5A80 Offset: 0xEA1A80 VA: 0xEA5A80
	internal void <ProtocolSalesmanAddItem>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSalesman.<>c__DisplayClass50_0 // TypeDefIndex: 2688
{
	// Fields
	public PlayerSelfSalesman <>4__this; // 0x10
	public SalesmanRemoveItem message; // 0x18

	// Methods

	// RVA: 0xEA365C Offset: 0xE9F65C VA: 0xEA365C
	public void .ctor() { }

	// RVA: 0xEA5C00 Offset: 0xEA1C00 VA: 0xEA5C00
	internal void <ProtocolSalesmanRemoveItem>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSalesman.<>c__DisplayClass51_0 // TypeDefIndex: 2689
{
	// Fields
	public PlayerSelfSalesman <>4__this; // 0x10
	public SalesmanSetTitleResponse message; // 0x18

	// Methods

	// RVA: 0xEA3738 Offset: 0xE9F738 VA: 0xEA3738
	public void .ctor() { }

	// RVA: 0xEA5CC0 Offset: 0xEA1CC0 VA: 0xEA5CC0
	internal void <ProtocolSalesmanSetTitleResponse>b__0() { }
}

// Namespace: game.ui
public class PlayerSelfSalesman : MonoBehaviour // TypeDefIndex: 2690
{
	// Fields
	private const int OriginFramedWidth = 214;
	private const int OriginFramedHeight = 485;
	private const int OriginItemFramedWidth = 42;
	private const int OriginItemFramedHeight = 42;
	private const int static_lineItemCount = 4;
	[SerializeField]
	private RectTransform backgroundRect; // 0x20
	[SerializeField]
	private Image backgroundImage; // 0x28
	[SerializeField]
	private RectTransform itemListingContent; // 0x30
	[SerializeField]
	private RectTransform itemTemplate; // 0x38
	[SerializeField]
	private Button shopPageButton; // 0x40
	[SerializeField]
	private Button titleButton; // 0x48
	[SerializeField]
	private TextMeshProUGUI titleTmp; // 0x50
	[SerializeField]
	private TextMeshProUGUI moneyTmp; // 0x58
	[SerializeField]
	private TextMeshProUGUI knbTmp; // 0x60
	[SerializeField]
	private Button takeMoneyButton; // 0x68
	[SerializeField]
	private GameObject openShopButtonGo; // 0x70
	[SerializeField]
	private Image openShopButtonImage; // 0x78
	[SerializeField]
	private Button openShopButton; // 0x80
	[SerializeField]
	private GameObject closeShopButtonGo; // 0x88
	[SerializeField]
	private Image closeShopButtonImage; // 0x90
	[SerializeField]
	private Button closeShopButton; // 0x98
	[SerializeField]
	private Button closeUiButton; // 0xA0
	private float scaleRatio; // 0xA8
	private Vector2 showoffVisiblePosition; // 0xAC
	private Vector2 showoffHiddenPosition; // 0xB4
	private readonly Queue<Action> onStartActions; // 0xC0
	private bool isStarted; // 0xC8
	private bool isOpening; // 0xC9
	private PlayerSelfBagarate.Cell cellTemplate; // 0xD0
	private readonly List<PlayerSelfBagarate.Cell> cellListing; // 0xD8
	private readonly Dictionary<int, Item> itemInBagarateInWaiting; // 0xE0
	private bool isStallOpening; // 0xE8
	private Action leanMoveLocalUpdating; // 0xF0

	// Methods

	// RVA: 0xEA1C6C Offset: 0xE9DC6C VA: 0xEA1C6C
	private void Start() { }

	// RVA: 0xEA252C Offset: 0xE9E52C VA: 0xEA252C
	private void Update() { }

	// RVA: 0xEA2548 Offset: 0xE9E548 VA: 0xEA2548
	private void Perform(Action action) { }

	// RVA: 0xEA25C4 Offset: 0xE9E5C4 VA: 0xEA25C4
	private void LeanMoveLocal(RectTransform rect, Vector2 to, Action onFinish) { }

	// RVA: 0xEA2780 Offset: 0xE9E780 VA: 0xEA2780
	public void ShowOpen(bool enabled) { }

	// RVA: 0xE94A24 Offset: 0xE90A24 VA: 0xE94A24
	public void ShowOff() { }

	// RVA: 0xEA2C28 Offset: 0xE9EC28 VA: 0xEA2C28
	public void ShowDirectly(bool enabled) { }

	// RVA: 0xEA2FF0 Offset: 0xE9EFF0 VA: 0xEA2FF0
	public bool IsOpen() { }

	// RVA: 0xEA2300 Offset: 0xE9E300 VA: 0xEA2300
	private List<PlayerSelfBagarate.Cell> CreateNewCellLine() { }

	// RVA: 0xEA29D4 Offset: 0xE9E9D4 VA: 0xEA29D4
	public void SetTitle(string title) { }

	// RVA: 0xEA2A68 Offset: 0xE9EA68 VA: 0xEA2A68
	public void SetMoney(long value) { }

	// RVA: 0xEA2B48 Offset: 0xE9EB48 VA: 0xEA2B48
	public void SetKnb(long value) { }

	// RVA: 0xEA2FF8 Offset: 0xE9EFF8 VA: 0xEA2FF8
	public void AddItem(Item item, int money, int knb) { }

	// RVA: 0xEA3248 Offset: 0xE9F248 VA: 0xEA3248
	public void RemoveItem(int itemindex) { }

	// RVA: 0xEA2D4C Offset: 0xE9ED4C VA: 0xEA2D4C
	public void ClearAllItem() { }

	// RVA: 0xEA33A0 Offset: 0xE9F3A0 VA: 0xEA33A0
	public void ProtocolSalesmanGetStallDataResponse(SalesmanGetStallDataResponse message) { }

	// RVA: 0xEA34AC Offset: 0xE9F4AC VA: 0xEA34AC
	public void ProtocolSalesmanAddItem(SalesmanAddItem message) { }

	// RVA: 0xEA3588 Offset: 0xE9F588 VA: 0xEA3588
	public void ProtocolSalesmanRemoveItem(SalesmanRemoveItem message) { }

	// RVA: 0xEA3664 Offset: 0xE9F664 VA: 0xEA3664
	public void ProtocolSalesmanSetTitleResponse(SalesmanSetTitleResponse message) { }

	// RVA: 0xEA3740 Offset: 0xE9F740 VA: 0xEA3740
	public void ProtocolSalesmanCloseStallResponse(SalesmanCloseStallResponse message) { }

	// RVA: 0xEA384C Offset: 0xE9F84C VA: 0xEA384C
	public void ProtocolSalesmanTakeMoneyResponse(SalesmanTakeMoneyResponse message) { }

	// RVA: 0xEA3884 Offset: 0xE9F884 VA: 0xEA3884
	public void ProtocolSalesmanOpenStallResponse(SalesmanOpenStallResponse message) { }

	// RVA: 0xEA3AA4 Offset: 0xE9FAA4 VA: 0xEA3AA4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEA3BD4 Offset: 0xE9FBD4 VA: 0xEA3BD4
	private void <Start>b__33_0() { }

	[CompilerGenerated]
	// RVA: 0xEA3C48 Offset: 0xE9FC48 VA: 0xEA3C48
	private void <Start>b__33_3() { }

	[CompilerGenerated]
	// RVA: 0xEA3E38 Offset: 0xE9FE38 VA: 0xEA3E38
	private void <ShowOpen>b__37_0() { }

	[CompilerGenerated]
	// RVA: 0xEA41A0 Offset: 0xEA01A0 VA: 0xEA41A0
	private void <ShowOpen>b__37_1(int _itemtabCellIndex, PlayerSelfBagarate.Cell _bagarateCell) { }

	[CompilerGenerated]
	// RVA: 0xEA43C4 Offset: 0xEA03C4 VA: 0xEA43C4
	private void <ShowOpen>b__37_2() { }

	[CompilerGenerated]
	// RVA: 0xEA43E8 Offset: 0xEA03E8 VA: 0xEA43E8
	private void <ShowDirectly>b__39_0() { }
}

// Namespace: game.ui
public class PlayerSelfSalesmanPricing : MonoBehaviour // TypeDefIndex: 2691
{
	// Fields
	[SerializeField]
	private TextMeshProUGUI itemTmp; // 0x20
	[SerializeField]
	private Button confirmButton; // 0x28
	[SerializeField]
	private Button cancelButton; // 0x30
	[SerializeField]
	private int textSize; // 0x38
	[SerializeField]
	private GameObject valueMoneySelectBackground; // 0x40
	[SerializeField]
	private TextMeshProUGUI valueMoneyText; // 0x48
	[SerializeField]
	private Button valueMoneyButton; // 0x50
	[SerializeField]
	private GameObject valueKnbSelectBackground; // 0x58
	[SerializeField]
	private TextMeshProUGUI valueKnbText; // 0x60
	[SerializeField]
	private Button valueKnbButton; // 0x68
	[SerializeField]
	private Button numpadButtonConfirm; // 0x70
	[SerializeField]
	private Button numpadButtonCancel; // 0x78
	[SerializeField]
	private Button numpadButtonSpace; // 0x80
	[SerializeField]
	private Button numpadButton0; // 0x88
	[SerializeField]
	private Button numpadButton1; // 0x90
	[SerializeField]
	private Button numpadButton2; // 0x98
	[SerializeField]
	private Button numpadButton3; // 0xA0
	[SerializeField]
	private Button numpadButton4; // 0xA8
	[SerializeField]
	private Button numpadButton5; // 0xB0
	[SerializeField]
	private Button numpadButton6; // 0xB8
	[SerializeField]
	private Button numpadButton7; // 0xC0
	[SerializeField]
	private Button numpadButton8; // 0xC8
	[SerializeField]
	private Button numpadButton9; // 0xD0
	private readonly Queue<Action> onStartActions; // 0xD8
	private bool isStarted; // 0xE0
	private Action<long, long> onConfirm; // 0xE8
	private Action onCancel; // 0xF0
	private long storageMoneyValue; // 0xF8
	private long storageKnbValue; // 0x100
	private bool IsCurrentSelectedMoney; // 0x108
	private float numpadPressEffectFloat; // 0x10C
	private Button numpadPressEffectButton; // 0x110

	// Methods

	// RVA: 0xEA5CE4 Offset: 0xEA1CE4 VA: 0xEA5CE4
	private void Start() { }

	// RVA: 0xEA6560 Offset: 0xEA2560 VA: 0xEA6560
	private void Update() { }

	// RVA: 0xEA62F0 Offset: 0xEA22F0 VA: 0xEA62F0
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xEA6640 Offset: 0xEA2640 VA: 0xEA6640
	private void Perform(Action action) { }

	// RVA: 0xEA66BC Offset: 0xEA26BC VA: 0xEA66BC
	private void ForcusInputMoney() { }

	// RVA: 0xEA66FC Offset: 0xEA26FC VA: 0xEA66FC
	private void ForcusInputKnb() { }

	// RVA: 0xEA6738 Offset: 0xEA2738 VA: 0xEA6738
	private void NumpadOnClick(Button button, int numValue) { }

	// RVA: 0xEA5094 Offset: 0xEA1094 VA: 0xEA5094
	public void Open(string itemname, Action<long, long> onConfirm, Action onCancel) { }

	// RVA: 0xEA6948 Offset: 0xEA2948 VA: 0xEA6948
	private void SetMoney(string value) { }

	// RVA: 0xEA6A24 Offset: 0xEA2A24 VA: 0xEA6A24
	private void SetKnb(string value) { }

	// RVA: 0xEA6B00 Offset: 0xEA2B00 VA: 0xEA6B00
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEA6B98 Offset: 0xEA2B98 VA: 0xEA6B98
	private void <Start>b__32_0() { }

	[CompilerGenerated]
	// RVA: 0xEA6C38 Offset: 0xEA2C38 VA: 0xEA6C38
	private void <Start>b__32_1() { }

	[CompilerGenerated]
	// RVA: 0xEA6CD4 Offset: 0xEA2CD4 VA: 0xEA6CD4
	private void <Start>b__32_2() { }

	[CompilerGenerated]
	// RVA: 0xEA6D44 Offset: 0xEA2D44 VA: 0xEA6D44
	private void <Start>b__32_3() { }

	[CompilerGenerated]
	// RVA: 0xEA6DB4 Offset: 0xEA2DB4 VA: 0xEA6DB4
	private void <Start>b__32_4() { }

	[CompilerGenerated]
	// RVA: 0xEA6DD8 Offset: 0xEA2DD8 VA: 0xEA6DD8
	private void <Start>b__32_5() { }

	[CompilerGenerated]
	// RVA: 0xEA6DFC Offset: 0xEA2DFC VA: 0xEA6DFC
	private void <Start>b__32_6() { }

	[CompilerGenerated]
	// RVA: 0xEA6F5C Offset: 0xEA2F5C VA: 0xEA6F5C
	private void <Start>b__32_7() { }

	[CompilerGenerated]
	// RVA: 0xEA6F68 Offset: 0xEA2F68 VA: 0xEA6F68
	private void <Start>b__32_8() { }

	[CompilerGenerated]
	// RVA: 0xEA6F74 Offset: 0xEA2F74 VA: 0xEA6F74
	private void <Start>b__32_9() { }

	[CompilerGenerated]
	// RVA: 0xEA6F80 Offset: 0xEA2F80 VA: 0xEA6F80
	private void <Start>b__32_10() { }

	[CompilerGenerated]
	// RVA: 0xEA6F8C Offset: 0xEA2F8C VA: 0xEA6F8C
	private void <Start>b__32_11() { }

	[CompilerGenerated]
	// RVA: 0xEA6F98 Offset: 0xEA2F98 VA: 0xEA6F98
	private void <Start>b__32_12() { }

	[CompilerGenerated]
	// RVA: 0xEA6FA4 Offset: 0xEA2FA4 VA: 0xEA6FA4
	private void <Start>b__32_13() { }

	[CompilerGenerated]
	// RVA: 0xEA6FB0 Offset: 0xEA2FB0 VA: 0xEA6FB0
	private void <Start>b__32_14() { }

	[CompilerGenerated]
	// RVA: 0xEA6FBC Offset: 0xEA2FBC VA: 0xEA6FBC
	private void <Start>b__32_15() { }

	[CompilerGenerated]
	// RVA: 0xEA6FC8 Offset: 0xEA2FC8 VA: 0xEA6FC8
	private void <Start>b__32_16() { }
}

// Namespace: 
public sealed class PlayerSelfSettings.CameraSliderCallback : MulticastDelegate // TypeDefIndex: 2692
{
	// Methods

	// RVA: 0xEAF4AC Offset: 0xEAB4AC VA: 0xEAF4AC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEAF54C Offset: 0xEAB54C VA: 0xEAF54C Slot: 12
	public virtual void Invoke(float value) { }

	// RVA: 0xEAF560 Offset: 0xEAB560 VA: 0xEAF560 Slot: 13
	public virtual IAsyncResult BeginInvoke(float value, AsyncCallback callback, object object) { }

	// RVA: 0xEAF5BC Offset: 0xEAB5BC VA: 0xEAF5BC Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class PlayerSelfSettings.FpsCallback : MulticastDelegate // TypeDefIndex: 2693
{
	// Methods

	// RVA: 0xEAF5C8 Offset: 0xEAB5C8 VA: 0xEAF5C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEAF668 Offset: 0xEAB668 VA: 0xEAF668 Slot: 12
	public virtual void Invoke(int value) { }

	// RVA: 0xEAF67C Offset: 0xEAB67C VA: 0xEAF67C Slot: 13
	public virtual IAsyncResult BeginInvoke(int value, AsyncCallback callback, object object) { }

	// RVA: 0xEAF6D8 Offset: 0xEAB6D8 VA: 0xEAF6D8 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class PlayerSelfSettings.MovingCallback : MulticastDelegate // TypeDefIndex: 2694
{
	// Methods

	// RVA: 0xEAF6E4 Offset: 0xEAB6E4 VA: 0xEAF6E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEAF794 Offset: 0xEAB794 VA: 0xEAF794 Slot: 12
	public virtual void Invoke(string name) { }

	// RVA: 0xEAF7A8 Offset: 0xEAB7A8 VA: 0xEAF7A8 Slot: 13
	public virtual IAsyncResult BeginInvoke(string name, AsyncCallback callback, object object) { }

	// RVA: 0xEAF7C8 Offset: 0xEAB7C8 VA: 0xEAF7C8 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class PlayerSelfSettings.MapChangeCallback : MulticastDelegate // TypeDefIndex: 2695
{
	// Methods

	// RVA: 0xEAF7D4 Offset: 0xEAB7D4 VA: 0xEAF7D4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEAF888 Offset: 0xEAB888 VA: 0xEAF888 Slot: 12
	public virtual void Invoke(string type, bool value) { }

	// RVA: 0xEAF89C Offset: 0xEAB89C VA: 0xEAF89C Slot: 13
	public virtual IAsyncResult BeginInvoke(string type, bool value, AsyncCallback callback, object object) { }

	// RVA: 0xEAF8FC Offset: 0xEAB8FC VA: 0xEAF8FC Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class PlayerSelfSettings.PlayerChangeCallback : MulticastDelegate // TypeDefIndex: 2696
{
	// Methods

	// RVA: 0xEAF908 Offset: 0xEAB908 VA: 0xEAF908
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEAF9BC Offset: 0xEAB9BC VA: 0xEAF9BC Slot: 12
	public virtual void Invoke(string type, bool value) { }

	// RVA: 0xEAF9D0 Offset: 0xEAB9D0 VA: 0xEAF9D0 Slot: 13
	public virtual IAsyncResult BeginInvoke(string type, bool value, AsyncCallback callback, object object) { }

	// RVA: 0xEAFA30 Offset: 0xEABA30 VA: 0xEAFA30 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class PlayerSelfSettings.VariationsChangeCallback : MulticastDelegate // TypeDefIndex: 2697
{
	// Methods

	// RVA: 0xEAFA3C Offset: 0xEABA3C VA: 0xEAFA3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEAFAF0 Offset: 0xEABAF0 VA: 0xEAFAF0 Slot: 12
	public virtual void Invoke(string type, bool value) { }

	// RVA: 0xEAFB04 Offset: 0xEABB04 VA: 0xEAFB04 Slot: 13
	public virtual IAsyncResult BeginInvoke(string type, bool value, AsyncCallback callback, object object) { }

	// RVA: 0xEAFB64 Offset: 0xEABB64 VA: 0xEAFB64 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class PlayerSelfSettings.RenderChangeCallback : MulticastDelegate // TypeDefIndex: 2698
{
	// Methods

	// RVA: 0xEAFB70 Offset: 0xEABB70 VA: 0xEAFB70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEAFC24 Offset: 0xEABC24 VA: 0xEAFC24 Slot: 12
	public virtual void Invoke(string type, bool value) { }

	// RVA: 0xEAFC38 Offset: 0xEABC38 VA: 0xEAFC38 Slot: 13
	public virtual IAsyncResult BeginInvoke(string type, bool value, AsyncCallback callback, object object) { }

	// RVA: 0xEAFC98 Offset: 0xEABC98 VA: 0xEAFC98 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class PlayerSelfSettings.RenderChangeNumberCallback : MulticastDelegate // TypeDefIndex: 2699
{
	// Methods

	// RVA: 0xEAFCA4 Offset: 0xEABCA4 VA: 0xEAFCA4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEAFD44 Offset: 0xEABD44 VA: 0xEAFD44 Slot: 12
	public virtual void Invoke(int value) { }

	// RVA: 0xEAFD58 Offset: 0xEABD58 VA: 0xEAFD58 Slot: 13
	public virtual IAsyncResult BeginInvoke(int value, AsyncCallback callback, object object) { }

	// RVA: 0xEAFDB4 Offset: 0xEABDB4 VA: 0xEAFDB4 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
public sealed class PlayerSelfSettings.VibrateVolumeChangeCallback : MulticastDelegate // TypeDefIndex: 2700
{
	// Methods

	// RVA: 0xEAFDC0 Offset: 0xEABDC0 VA: 0xEAFDC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xEAFE74 Offset: 0xEABE74 VA: 0xEAFE74 Slot: 12
	public virtual void Invoke(string type, bool value) { }

	// RVA: 0xEAFE88 Offset: 0xEABE88 VA: 0xEAFE88 Slot: 13
	public virtual IAsyncResult BeginInvoke(string type, bool value, AsyncCallback callback, object object) { }

	// RVA: 0xEAFEE8 Offset: 0xEABEE8 VA: 0xEAFEE8 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerSelfSettings.<>c // TypeDefIndex: 2701
{
	// Fields
	public static readonly PlayerSelfSettings.<>c <>9; // 0x0
	public static UnityAction<bool> <>9__91_0; // 0x8
	public static UnityAction<string> <>9__96_0; // 0x10
	public static UnityAction<string> <>9__96_1; // 0x18
	public static UnityAction<string> <>9__96_2; // 0x20
	public static UnityAction<string> <>9__96_3; // 0x28
	public static UnityAction<string> <>9__96_4; // 0x30
	public static UnityAction<string> <>9__96_5; // 0x38
	public static UnityAction<string> <>9__96_6; // 0x40
	public static UnityAction<string> <>9__96_7; // 0x48
	public static UnityAction<string> <>9__96_8; // 0x50
	public static UnityAction<string> <>9__96_9; // 0x58
	public static UnityAction<string> <>9__96_10; // 0x60
	public static UnityAction<string> <>9__96_11; // 0x68
	public static UnityAction<string> <>9__96_12; // 0x70
	public static UnityAction<string> <>9__96_13; // 0x78
	public static UnityAction<string> <>9__96_14; // 0x80
	public static UnityAction<string> <>9__96_15; // 0x88
	public static UnityAction<string> <>9__96_16; // 0x90
	public static UnityAction<bool> <>9__114_0; // 0x98
	public static UnityAction<bool> <>9__114_1; // 0xA0
	public static UnityAction<bool> <>9__114_2; // 0xA8
	public static UnityAction<bool> <>9__115_0; // 0xB0
	public static UnityAction<bool> <>9__115_1; // 0xB8
	public static UnityAction<bool> <>9__115_2; // 0xC0
	public static UnityAction<bool> <>9__115_3; // 0xC8
	public static UnityAction<bool> <>9__115_4; // 0xD0
	public static UnityAction<bool> <>9__116_0; // 0xD8
	public static UnityAction<bool> <>9__117_0; // 0xE0
	public static UnityAction<bool> <>9__117_1; // 0xE8
	public static UnityAction<bool> <>9__124_0; // 0xF0
	public static UnityAction<bool> <>9__124_1; // 0xF8
	public static UnityAction<bool> <>9__124_2; // 0x100
	public static UnityAction<bool> <>9__124_3; // 0x108
	public static UnityAction<bool> <>9__129_7; // 0x110
	public static UnityAction<bool> <>9__148_3; // 0x118

	// Methods

	// RVA: 0xEAFEF4 Offset: 0xEABEF4 VA: 0xEAFEF4
	private static void .cctor() { }

	// RVA: 0xEAFF5C Offset: 0xEABF5C VA: 0xEAFF5C
	public void .ctor() { }

	// RVA: 0xEAFF64 Offset: 0xEABF64 VA: 0xEAFF64
	internal void <ApplyChildrenPCStyle>b__91_0(bool isOn) { }

	// RVA: 0xEAFFC8 Offset: 0xEABFC8 VA: 0xEAFFC8
	internal void <OpenFont>b__96_0(string number) { }

	// RVA: 0xEB0088 Offset: 0xEAC088 VA: 0xEB0088
	internal void <OpenFont>b__96_1(string number) { }

	// RVA: 0xEB0148 Offset: 0xEAC148 VA: 0xEB0148
	internal void <OpenFont>b__96_2(string number) { }

	// RVA: 0xEB0260 Offset: 0xEAC260 VA: 0xEB0260
	internal void <OpenFont>b__96_3(string number) { }

	// RVA: 0xEB0304 Offset: 0xEAC304 VA: 0xEB0304
	internal void <OpenFont>b__96_4(string number) { }

	// RVA: 0xEB03C4 Offset: 0xEAC3C4 VA: 0xEB03C4
	internal void <OpenFont>b__96_5(string number) { }

	// RVA: 0xEB0468 Offset: 0xEAC468 VA: 0xEB0468
	internal void <OpenFont>b__96_6(string number) { }

	// RVA: 0xEB050C Offset: 0xEAC50C VA: 0xEB050C
	internal void <OpenFont>b__96_7(string number) { }

	// RVA: 0xEB05B0 Offset: 0xEAC5B0 VA: 0xEB05B0
	internal void <OpenFont>b__96_8(string number) { }

	// RVA: 0xEB0654 Offset: 0xEAC654 VA: 0xEB0654
	internal void <OpenFont>b__96_9(string number) { }

	// RVA: 0xEB06F8 Offset: 0xEAC6F8 VA: 0xEB06F8
	internal void <OpenFont>b__96_10(string number) { }

	// RVA: 0xEB079C Offset: 0xEAC79C VA: 0xEB079C
	internal void <OpenFont>b__96_11(string number) { }

	// RVA: 0xEB0840 Offset: 0xEAC840 VA: 0xEB0840
	internal void <OpenFont>b__96_12(string number) { }

	// RVA: 0xEB08E4 Offset: 0xEAC8E4 VA: 0xEB08E4
	internal void <OpenFont>b__96_13(string number) { }

	// RVA: 0xEB0988 Offset: 0xEAC988 VA: 0xEB0988
	internal void <OpenFont>b__96_14(string number) { }

	// RVA: 0xEB0A2C Offset: 0xEACA2C VA: 0xEB0A2C
	internal void <OpenFont>b__96_15(string number) { }

	// RVA: 0xEB0AD0 Offset: 0xEACAD0 VA: 0xEB0AD0
	internal void <OpenFont>b__96_16(string number) { }

	// RVA: 0xEB0B74 Offset: 0xEACB74 VA: 0xEB0B74
	internal void <SetupItemBoderStyle>b__114_0(bool isOn) { }

	// RVA: 0xEB0BF8 Offset: 0xEACBF8 VA: 0xEB0BF8
	internal void <SetupItemBoderStyle>b__114_1(bool isOn) { }

	// RVA: 0xEB0C7C Offset: 0xEACC7C VA: 0xEB0C7C
	internal void <SetupItemBoderStyle>b__114_2(bool isOn) { }

	// RVA: 0xEB0D00 Offset: 0xEACD00 VA: 0xEB0D00
	internal void <SetupViewItemStyle>b__115_0(bool isOn) { }

	// RVA: 0xEB0D80 Offset: 0xEACD80 VA: 0xEB0D80
	internal void <SetupViewItemStyle>b__115_1(bool isOn) { }

	// RVA: 0xEB0E04 Offset: 0xEACE04 VA: 0xEB0E04
	internal void <SetupViewItemStyle>b__115_2(bool isOn) { }

	// RVA: 0xEB0E88 Offset: 0xEACE88 VA: 0xEB0E88
	internal void <SetupViewItemStyle>b__115_3(bool isOn) { }

	// RVA: 0xEB0F3C Offset: 0xEACF3C VA: 0xEB0F3C
	internal void <SetupViewItemStyle>b__115_4(bool isOn) { }

	// RVA: 0xEB0FF0 Offset: 0xEACFF0 VA: 0xEB0FF0
	internal void <SetUpSafety>b__116_0(bool isOn) { }

	// RVA: 0xEB1078 Offset: 0xEAD078 VA: 0xEB1078
	internal void <SetupChatHistory>b__117_0(bool isOn) { }

	// RVA: 0xEB1144 Offset: 0xEAD144 VA: 0xEB1144
	internal void <SetupChatHistory>b__117_1(bool isOn) { }

	// RVA: 0xEB122C Offset: 0xEAD22C VA: 0xEB122C
	internal void <SetupSkillGroup>b__124_0(bool isOn) { }

	// RVA: 0xEB12B4 Offset: 0xEAD2B4 VA: 0xEB12B4
	internal void <SetupSkillGroup>b__124_1(bool isOn) { }

	// RVA: 0xEB133C Offset: 0xEAD33C VA: 0xEB133C
	internal void <SetupSkillGroup>b__124_2(bool isOn) { }

	// RVA: 0xEB13C4 Offset: 0xEAD3C4 VA: 0xEB13C4
	internal void <SetupSkillGroup>b__124_3(bool isOn) { }

	// RVA: 0xEB144C Offset: 0xEAD44C VA: 0xEB144C
	internal void <SetUpMapChange>b__129_7(bool isOn) { }

	// RVA: 0xEB1548 Offset: 0xEAD548 VA: 0xEB1548
	internal void <SetUpRenderChange>b__148_3(bool isOn) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSettings.<>c__DisplayClass158_0 // TypeDefIndex: 2702
{
	// Fields
	public PlayerSelfSettings <>4__this; // 0x10
	public TrainoffCheckResponse message; // 0x18
	public ProfileData runningProfile; // 0x20

	// Methods

	// RVA: 0xEAD248 Offset: 0xEA9248 VA: 0xEAD248
	public void .ctor() { }

	// RVA: 0xEB15D0 Offset: 0xEAD5D0 VA: 0xEB15D0
	internal void <ProtocolTrainoffCheckResponse>b__0() { }
}

// Namespace: game.ui
public class PlayerSelfSettings : MonoBehaviour // TypeDefIndex: 2703
{
	// Fields
	[SerializeField]
	private RectTransform backgroundRect; // 0x20
	[SerializeField]
	private Button buttonOption; // 0x28
	[SerializeField]
	private Button buttonFont; // 0x30
	[SerializeField]
	private Button buttonAuto; // 0x38
	[SerializeField]
	private Button buttonUyThac; // 0x40
	[SerializeField]
	private Button buttonLogout; // 0x48
	[SerializeField]
	private Button buttonClose; // 0x50
	[SerializeField]
	private GameObject tableOption; // 0x58
	[SerializeField]
	private GameObject tableFont; // 0x60
	[SerializeField]
	private GameObject tableUyThacGo; // 0x68
	[SerializeField]
	private TextMeshProUGUI optionNoteDescriptionTmp; // 0x70
	[SerializeField]
	private Slider soundBackgroundSlider; // 0x78
	[SerializeField]
	private TextMeshProUGUI soundBackgroundVolumeTmp; // 0x80
	[SerializeField]
	private Slider soundEffectSlider; // 0x88
	[SerializeField]
	private TextMeshProUGUI soundEffectVolumeTmp; // 0x90
	[SerializeField]
	private Slider cameraSlider; // 0x98
	[SerializeField]
	private TextMeshProUGUI cameraValueTmp; // 0xA0
	[SerializeField]
	private Toggle fps18Toggle; // 0xA8
	[SerializeField]
	private Toggle fps24Toggle; // 0xB0
	[SerializeField]
	private Toggle fps30Toggle; // 0xB8
	[SerializeField]
	private Toggle fps45Toggle; // 0xC0
	[SerializeField]
	private Toggle fps60Toggle; // 0xC8
	[SerializeField]
	private Toggle fps120Toggle; // 0xD0
	[SerializeField]
	private Toggle uiAsPcTogle; // 0xD8
	[SerializeField]
	private Toggle uiAsMobileTogle; // 0xE0
	[SerializeField]
	private Toggle itemdetailByUiStyleTogle; // 0xE8
	[SerializeField]
	private Toggle itemdetailByMobileTogle; // 0xF0
	[SerializeField]
	private Toggle itemdetailByPCTogle; // 0xF8
	[SerializeField]
	private Toggle itemdetailComparingTogle; // 0x100
	[SerializeField]
	private Toggle itemdetailSaveDisplayFuncsTogle; // 0x108
	[SerializeField]
	private Toggle itemBorderByUiStyleTogle; // 0x110
	[SerializeField]
	private Toggle itemBorderByMobileTogle; // 0x118
	[SerializeField]
	private Toggle itemBorderByPCTogle; // 0x120
	[SerializeField]
	private Toggle safetyOpenAskConfirm; // 0x128
	[SerializeField]
	private Toggle openChatHistoryChannel; // 0x130
	[SerializeField]
	private Button uiLayoutDefaultButton; // 0x138
	[SerializeField]
	private Button uiLayoutManualButton; // 0x140
	[SerializeField]
	private Button uiLayoutFactoryButton; // 0x148
	[SerializeField]
	private Toggle uiHotkeySkillKeepOnFightState; // 0x150
	[SerializeField]
	private Toggle movingAsPcToggle; // 0x158
	[SerializeField]
	private Toggle movingAsMobileToggle; // 0x160
	[SerializeField]
	private Toggle skilldirAllowTargetManualToggle; // 0x168
	[SerializeField]
	private Toggle skillDisplaySelfEvadeToggle; // 0x170
	[SerializeField]
	private Toggle skillDisplayPlayerEvadeToggle; // 0x178
	[SerializeField]
	private Toggle skillDisplaySkillSimilarToggle; // 0x180
	[SerializeField]
	private Toggle mapBackgroundToggle; // 0x188
	[SerializeField]
	private Toggle mapGroundNodeToggle; // 0x190
	[SerializeField]
	private Toggle mapGroundObjectToggle; // 0x198
	[SerializeField]
	private Toggle mapBuildingToggle; // 0x1A0
	[SerializeField]
	private Toggle mapTreeToggle; // 0x1A8
	[SerializeField]
	private Toggle mapObstacleGridToggle; // 0x1B0
	[SerializeField]
	private Toggle mapTrapToggle; // 0x1B8
	[SerializeField]
	private Toggle mapFindingPathToggle; // 0x1C0
	[SerializeField]
	private Toggle idenTitleToggle; // 0x1C8
	[SerializeField]
	private Toggle idenTongToggle; // 0x1D0
	[SerializeField]
	private Toggle idenNameToggle; // 0x1D8
	[SerializeField]
	private Toggle idenHealthToggle; // 0x1E0
	[SerializeField]
	private Toggle idenDroppingName; // 0x1E8
	[SerializeField]
	private Toggle idenPosToggle; // 0x1F0
	[SerializeField]
	private Toggle vibrateLowToggle; // 0x1F8
	[SerializeField]
	private Toggle vibrateMediumToggle; // 0x200
	[SerializeField]
	private Toggle vibrateHightToggle; // 0x208
	[SerializeField]
	private Toggle vibrateReceiveDamageToggle; // 0x210
	[SerializeField]
	private Toggle vibrateHitTargetToggle; // 0x218
	[SerializeField]
	private Toggle vibrateCastToggle; // 0x220
	[SerializeField]
	private TMP_InputField aroundInput; // 0x228
	[SerializeField]
	private Toggle aroundPlayerToggle; // 0x230
	[SerializeField]
	private Toggle aroundCreepToggle; // 0x238
	[SerializeField]
	private Toggle aroundPlayerSimilarToggle; // 0x240
	[SerializeField]
	private Button uythacStartButton; // 0x248
	[SerializeField]
	private TextMeshProUGUI uythacStartTmp; // 0x250
	[SerializeField]
	private TextMeshProUGUI uythacDescriptionTmp; // 0x258
	[SerializeField]
	private TMP_InputField fontInputPlayerName; // 0x260
	[SerializeField]
	private TMP_InputField fontInputPlayerSalesman; // 0x268
	[SerializeField]
	private TMP_InputField fontInputPlayerHealthBar; // 0x270
	[SerializeField]
	private TMP_InputField fontInputItemInfo; // 0x278
	[SerializeField]
	private TMP_InputField fontInputItemOnMap; // 0x280
	[SerializeField]
	private TMP_InputField fontInputChatHistory; // 0x288
	[SerializeField]
	private TMP_InputField fontInputQuestTitle; // 0x290
	[SerializeField]
	private TMP_InputField fontInputQuestContent; // 0x298
	[SerializeField]
	private TMP_InputField fontInputHomeScreenTopLevel; // 0x2A0
	[SerializeField]
	private TMP_InputField fontInputHomeScreenTopRank; // 0x2A8
	[SerializeField]
	private TMP_InputField fontInputHomeScreenTopHealth; // 0x2B0
	[SerializeField]
	private TMP_InputField fontInputHomeScreenTopMana; // 0x2B8
	[SerializeField]
	private TMP_InputField fontInputHomeScreenTopStamina; // 0x2C0
	[SerializeField]
	private TMP_InputField fontInputHomeScreenTopExp; // 0x2C8
	[SerializeField]
	private TMP_InputField fontInputNpcDialog; // 0x2D0
	[SerializeField]
	private TMP_InputField fontInputTalk2Player; // 0x2D8
	[SerializeField]
	private TMP_InputField fontInputLocalNews; // 0x2E0
	private bool fontHasInitialized; // 0x2E8
	[CompilerGenerated]
	private PlayerSelfSettings.CameraSliderCallback OnCameraSlider; // 0x2F0
	[CompilerGenerated]
	private PlayerSelfSettings.FpsCallback OnFpsChange; // 0x2F8
	public Action<int> onUserInterfaceStyleChanged; // 0x300
	[CompilerGenerated]
	private PlayerSelfSettings.MovingCallback OnMovingChange; // 0x308
	[CompilerGenerated]
	private PlayerSelfSettings.MapChangeCallback OnMapChange; // 0x310
	[CompilerGenerated]
	private PlayerSelfSettings.PlayerChangeCallback OnPlayerChange; // 0x318
	[CompilerGenerated]
	private PlayerSelfSettings.VariationsChangeCallback OnVariationsChange; // 0x320
	[CompilerGenerated]
	private PlayerSelfSettings.RenderChangeCallback OnRenderChange; // 0x328
	[CompilerGenerated]
	private PlayerSelfSettings.RenderChangeNumberCallback OnRenderChangeNumber; // 0x330
	[CompilerGenerated]
	private PlayerSelfSettings.VibrateVolumeChangeCallback OnVibrateVolumeChange; // 0x338

	// Methods

	// RVA: 0xEA6FD4 Offset: 0xEA2FD4 VA: 0xEA6FD4
	private void Start() { }

	// RVA: 0xEAA2E0 Offset: 0xEA62E0 VA: 0xEAA2E0
	private void ApplyChildrenPCInput(Transform transform) { }

	// RVA: 0xEA9DF8 Offset: 0xEA5DF8 VA: 0xEA9DF8
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xEAA5EC Offset: 0xEA65EC VA: 0xEAA5EC
	private void SetPannelActivate(GameObject go) { }

	// RVA: 0xEAA904 Offset: 0xEA6904 VA: 0xEAA904
	private void SetButtonActivate(Button button) { }

	// RVA: 0xEAAD20 Offset: 0xEA6D20 VA: 0xEAAD20
	public void OpenOptions() { }

	// RVA: 0xEAAD7C Offset: 0xEA6D7C VA: 0xEAAD7C
	public void OpenFont() { }

	// RVA: 0xEABD54 Offset: 0xEA7D54 VA: 0xEABD54
	public void OpenUyThac() { }

	// RVA: 0xEAA4B0 Offset: 0xEA64B0 VA: 0xEAA4B0
	private void SetTmp(TextMeshProUGUI tmp, string text, string color) { }

	// RVA: 0xEA73BC Offset: 0xEA33BC VA: 0xEA73BC
	private void SetupSoundBackground() { }

	// RVA: 0xEA7528 Offset: 0xEA3528 VA: 0xEA7528
	private void SetupSoundEffect() { }

	[CompilerGenerated]
	// RVA: 0xEABEA0 Offset: 0xEA7EA0 VA: 0xEABEA0
	public void add_OnCameraSlider(PlayerSelfSettings.CameraSliderCallback value) { }

	[CompilerGenerated]
	// RVA: 0xEABF3C Offset: 0xEA7F3C VA: 0xEABF3C
	public void remove_OnCameraSlider(PlayerSelfSettings.CameraSliderCallback value) { }

	// RVA: 0xEA7694 Offset: 0xEA3694 VA: 0xEA7694
	private void SetUpCamera() { }

	[CompilerGenerated]
	// RVA: 0xEABFD8 Offset: 0xEA7FD8 VA: 0xEABFD8
	public void add_OnFpsChange(PlayerSelfSettings.FpsCallback value) { }

	[CompilerGenerated]
	// RVA: 0xEAC074 Offset: 0xEA8074 VA: 0xEAC074
	public void remove_OnFpsChange(PlayerSelfSettings.FpsCallback value) { }

	// RVA: 0xEA788C Offset: 0xEA388C VA: 0xEA788C
	public void SetUpFps() { }

	// RVA: 0xEA7C1C Offset: 0xEA3C1C VA: 0xEA7C1C
	public void SetupUserInterfaceStyle() { }

	// RVA: 0xEAC110 Offset: 0xEA8110 VA: 0xEAC110
	private void OnChangeUiStyle() { }

	// RVA: 0xEA81E8 Offset: 0xEA41E8 VA: 0xEA81E8
	private void SetupItemBoderStyle() { }

	// RVA: 0xEA7D70 Offset: 0xEA3D70 VA: 0xEA7D70
	private void SetupViewItemStyle() { }

	// RVA: 0xEA84B4 Offset: 0xEA44B4 VA: 0xEA84B4
	private void SetUpSafety() { }

	// RVA: 0xEA860C Offset: 0xEA460C VA: 0xEA860C
	private void SetupChatHistory() { }

	// RVA: 0xEA882C Offset: 0xEA482C VA: 0xEA882C
	private void SetupUiLayout() { }

	[CompilerGenerated]
	// RVA: 0xEAC194 Offset: 0xEA8194 VA: 0xEAC194
	public void add_OnMovingChange(PlayerSelfSettings.MovingCallback value) { }

	[CompilerGenerated]
	// RVA: 0xEAC230 Offset: 0xEA8230 VA: 0xEAC230
	public void remove_OnMovingChange(PlayerSelfSettings.MovingCallback value) { }

	// RVA: 0xEA8964 Offset: 0xEA4964 VA: 0xEA8964
	public void SetupMoving() { }

	// RVA: 0xEA8AB8 Offset: 0xEA4AB8 VA: 0xEA8AB8
	private void SetupSkillGroup() { }

	[CompilerGenerated]
	// RVA: 0xEAC2CC Offset: 0xEA82CC VA: 0xEAC2CC
	public void add_OnMapChange(PlayerSelfSettings.MapChangeCallback value) { }

	[CompilerGenerated]
	// RVA: 0xEAC368 Offset: 0xEA8368 VA: 0xEAC368
	public void remove_OnMapChange(PlayerSelfSettings.MapChangeCallback value) { }

	// RVA: 0xEA8E60 Offset: 0xEA4E60 VA: 0xEA8E60
	public void SetUpMapChange() { }

	[CompilerGenerated]
	// RVA: 0xEAC404 Offset: 0xEA8404 VA: 0xEAC404
	public void add_OnPlayerChange(PlayerSelfSettings.PlayerChangeCallback value) { }

	[CompilerGenerated]
	// RVA: 0xEAC4A0 Offset: 0xEA84A0 VA: 0xEAC4A0
	public void remove_OnPlayerChange(PlayerSelfSettings.PlayerChangeCallback value) { }

	// RVA: 0xEA9344 Offset: 0xEA5344 VA: 0xEA9344
	public void SetUpPlayerChange() { }

	[CompilerGenerated]
	// RVA: 0xEAC53C Offset: 0xEA853C VA: 0xEAC53C
	public void add_OnVariationsChange(PlayerSelfSettings.VariationsChangeCallback value) { }

	[CompilerGenerated]
	// RVA: 0xEAC5D8 Offset: 0xEA85D8 VA: 0xEAC5D8
	public void remove_OnVariationsChange(PlayerSelfSettings.VariationsChangeCallback value) { }

	// RVA: 0xEA96E4 Offset: 0xEA56E4 VA: 0xEA96E4
	public void SetUpVariationsChange() { }

	[CompilerGenerated]
	// RVA: 0xEAC674 Offset: 0xEA8674 VA: 0xEAC674
	public void add_OnRenderChange(PlayerSelfSettings.RenderChangeCallback value) { }

	[CompilerGenerated]
	// RVA: 0xEAC710 Offset: 0xEA8710 VA: 0xEAC710
	public void remove_OnRenderChange(PlayerSelfSettings.RenderChangeCallback value) { }

	[CompilerGenerated]
	// RVA: 0xEAC7AC Offset: 0xEA87AC VA: 0xEAC7AC
	public void add_OnRenderChangeNumber(PlayerSelfSettings.RenderChangeNumberCallback value) { }

	[CompilerGenerated]
	// RVA: 0xEAC848 Offset: 0xEA8848 VA: 0xEAC848
	public void remove_OnRenderChangeNumber(PlayerSelfSettings.RenderChangeNumberCallback value) { }

	// RVA: 0xEA98EC Offset: 0xEA58EC VA: 0xEA98EC
	public void SetUpRenderChange() { }

	[CompilerGenerated]
	// RVA: 0xEAC8E4 Offset: 0xEA88E4 VA: 0xEAC8E4
	public void add_OnVibrateVolumeChange(PlayerSelfSettings.VibrateVolumeChangeCallback value) { }

	[CompilerGenerated]
	// RVA: 0xEAC980 Offset: 0xEA8980 VA: 0xEAC980
	public void remove_OnVibrateVolumeChange(PlayerSelfSettings.VibrateVolumeChangeCallback value) { }

	// RVA: 0xEA9C38 Offset: 0xEA5C38 VA: 0xEA9C38
	public void SetupVibrateVolumeChange() { }

	// RVA: 0xEACA1C Offset: 0xEA8A1C VA: 0xEACA1C
	public void SetVibrateVolumeChange(string type, bool value) { }

	// RVA: 0xEACBE8 Offset: 0xEA8BE8 VA: 0xEACBE8
	public void SetVariationsSetting(string type, bool value) { }

	// RVA: 0xEACDB0 Offset: 0xEA8DB0 VA: 0xEACDB0
	public void SetRenderSetting(string type, bool value) { }

	// RVA: 0xEACF00 Offset: 0xEA8F00 VA: 0xEACF00
	public void SetNumberNpcRender(int number) { }

	// RVA: 0xEACFAC Offset: 0xEA8FAC VA: 0xEACFAC
	public void ProtocolTrainoffCheckResponse(TrainoffCheckResponse message) { }

	// RVA: 0xEAD250 Offset: 0xEA9250 VA: 0xEAD250
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEAD258 Offset: 0xEA9258 VA: 0xEAD258
	private void <Start>b__89_0() { }

	[CompilerGenerated]
	// RVA: 0xEAD2DC Offset: 0xEA92DC VA: 0xEAD2DC
	private void <Start>b__89_1() { }

	[CompilerGenerated]
	// RVA: 0xEAD34C Offset: 0xEA934C VA: 0xEAD34C
	private void <Start>b__89_2() { }

	[CompilerGenerated]
	// RVA: 0xEAD3BC Offset: 0xEA93BC VA: 0xEAD3BC
	private void <Start>b__89_3() { }

	[CompilerGenerated]
	// RVA: 0xEAD42C Offset: 0xEA942C VA: 0xEAD42C
	private void <Start>b__89_4() { }

	[CompilerGenerated]
	// RVA: 0xEAD4C0 Offset: 0xEA94C0 VA: 0xEAD4C0
	private void <Start>b__89_5() { }

	[CompilerGenerated]
	// RVA: 0xEAD578 Offset: 0xEA9578 VA: 0xEAD578
	private void <SetupSoundBackground>b__99_0(float value) { }

	[CompilerGenerated]
	// RVA: 0xEAD6BC Offset: 0xEA96BC VA: 0xEAD6BC
	private void <SetupSoundEffect>b__100_0(float value) { }

	[CompilerGenerated]
	// RVA: 0xEAD800 Offset: 0xEA9800 VA: 0xEAD800
	private void <SetUpCamera>b__105_0(float value) { }

	[CompilerGenerated]
	// RVA: 0xEAD91C Offset: 0xEA991C VA: 0xEAD91C
	private void <SetUpFps>b__110_0(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAD9CC Offset: 0xEA99CC VA: 0xEAD9CC
	private void <SetUpFps>b__110_1(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEADA7C Offset: 0xEA9A7C VA: 0xEADA7C
	private void <SetUpFps>b__110_2(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEADB2C Offset: 0xEA9B2C VA: 0xEADB2C
	private void <SetUpFps>b__110_3(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEADBDC Offset: 0xEA9BDC VA: 0xEADBDC
	private void <SetUpFps>b__110_4(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEADC8C Offset: 0xEA9C8C VA: 0xEADC8C
	private void <SetUpFps>b__110_5(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEADD3C Offset: 0xEA9D3C VA: 0xEADD3C
	private void <SetupUserInterfaceStyle>b__112_0(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEADDEC Offset: 0xEA9DEC VA: 0xEADDEC
	private void <SetupUserInterfaceStyle>b__112_1(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEADE9C Offset: 0xEA9E9C VA: 0xEADE9C
	private void <SetupUiLayout>b__118_0() { }

	[CompilerGenerated]
	// RVA: 0xEADF7C Offset: 0xEA9F7C VA: 0xEADF7C
	private void <SetupUiLayout>b__118_3() { }

	[CompilerGenerated]
	// RVA: 0xEADFA8 Offset: 0xEA9FA8 VA: 0xEADFA8
	private void <SetupUiLayout>b__118_1() { }

	[CompilerGenerated]
	// RVA: 0xEAE088 Offset: 0xEAA088 VA: 0xEAE088
	private void <SetupUiLayout>b__118_4() { }

	[CompilerGenerated]
	// RVA: 0xEAE144 Offset: 0xEAA144 VA: 0xEAE144
	private void <SetupUiLayout>b__118_2() { }

	[CompilerGenerated]
	// RVA: 0xEAE224 Offset: 0xEAA224 VA: 0xEAE224
	private void <SetupUiLayout>b__118_5() { }

	[CompilerGenerated]
	// RVA: 0xEAE2A0 Offset: 0xEAA2A0 VA: 0xEAE2A0
	private void <SetupMoving>b__123_0(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAE364 Offset: 0xEAA364 VA: 0xEAE364
	private void <SetupMoving>b__123_1(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAE428 Offset: 0xEAA428 VA: 0xEAE428
	private void <SetUpMapChange>b__129_0(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAE4EC Offset: 0xEAA4EC VA: 0xEAE4EC
	private void <SetUpMapChange>b__129_1(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAE5B0 Offset: 0xEAA5B0 VA: 0xEAE5B0
	private void <SetUpMapChange>b__129_2(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAE674 Offset: 0xEAA674 VA: 0xEAE674
	private void <SetUpMapChange>b__129_3(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAE738 Offset: 0xEAA738 VA: 0xEAE738
	private void <SetUpMapChange>b__129_4(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAE7FC Offset: 0xEAA7FC VA: 0xEAE7FC
	private void <SetUpMapChange>b__129_5(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAE8C0 Offset: 0xEAA8C0 VA: 0xEAE8C0
	private void <SetUpMapChange>b__129_6(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAE924 Offset: 0xEAA924 VA: 0xEAE924
	private void <SetUpPlayerChange>b__134_0(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAE9E8 Offset: 0xEAA9E8 VA: 0xEAE9E8
	private void <SetUpPlayerChange>b__134_1(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAEAAC Offset: 0xEAAAAC VA: 0xEAEAAC
	private void <SetUpPlayerChange>b__134_2(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAEB70 Offset: 0xEAAB70 VA: 0xEAEB70
	private void <SetUpPlayerChange>b__134_3(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAEC34 Offset: 0xEAAC34 VA: 0xEAEC34
	private void <SetUpPlayerChange>b__134_4(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAECF8 Offset: 0xEAACF8 VA: 0xEAECF8
	private void <SetUpPlayerChange>b__134_5(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAEDBC Offset: 0xEAADBC VA: 0xEAEDBC
	private void <SetUpVariationsChange>b__139_0(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAEE80 Offset: 0xEAAE80 VA: 0xEAEE80
	private void <SetUpVariationsChange>b__139_1(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAEF44 Offset: 0xEAAF44 VA: 0xEAEF44
	private void <SetUpVariationsChange>b__139_2(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAF008 Offset: 0xEAB008 VA: 0xEAF008
	private void <SetUpRenderChange>b__148_0(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAF0CC Offset: 0xEAB0CC VA: 0xEAF0CC
	private void <SetUpRenderChange>b__148_1(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAF190 Offset: 0xEAB190 VA: 0xEAF190
	private void <SetUpRenderChange>b__148_2(string number) { }

	[CompilerGenerated]
	// RVA: 0xEAF254 Offset: 0xEAB254 VA: 0xEAF254
	private void <SetupVibrateVolumeChange>b__153_0(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAF31C Offset: 0xEAB31C VA: 0xEAF31C
	private void <SetupVibrateVolumeChange>b__153_1(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEAF3E4 Offset: 0xEAB3E4 VA: 0xEAF3E4
	private void <SetupVibrateVolumeChange>b__153_2(bool isOn) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSkill.Cell.<>c__DisplayClass9_0 // TypeDefIndex: 2704
{
	// Fields
	public Action onclick; // 0x10

	// Methods

	// RVA: 0xEB5F28 Offset: 0xEB1F28 VA: 0xEB5F28
	public void .ctor() { }

	// RVA: 0xEB5F30 Offset: 0xEB1F30 VA: 0xEB5F30
	internal void <Apply>b__0() { }
}

// Namespace: 
private class PlayerSelfSkill.Cell // TypeDefIndex: 2705
{
	// Fields
	public GameObject go; // 0x10
	public RectTransform rectTransform; // 0x18
	public Image framedImage; // 0x20
	public Image thumbnailImage; // 0x28
	public TextMeshProUGUI pointTmp; // 0x30
	public Button button; // 0x38
	public Skill appskill; // 0x40

	// Methods

	// RVA: 0xEB1E04 Offset: 0xEADE04 VA: 0xEB1E04
	public void .ctor(GameObject go) { }

	// RVA: 0xEB2818 Offset: 0xEAE818 VA: 0xEB2818
	public PlayerSelfSkill.Cell Clone(GameObject parent) { }

	// RVA: 0xEB5868 Offset: 0xEB1868 VA: 0xEB5868
	public void Apply(Skill appskill, Action onclick) { }

	// RVA: 0xEB4B80 Offset: 0xEB0B80 VA: 0xEB4B80
	public void SetPoint(Skill appskill) { }

	// RVA: 0xEB5A58 Offset: 0xEB1A58 VA: 0xEB5A58
	public void Clear() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerSelfSkill.<>c // TypeDefIndex: 2706
{
	// Fields
	public static readonly PlayerSelfSkill.<>c <>9; // 0x0
	public static Comparison<KeyValuePair<Skill, int>> <>9__59_1; // 0x8

	// Methods

	// RVA: 0xEB5F50 Offset: 0xEB1F50 VA: 0xEB5F50
	private static void .cctor() { }

	// RVA: 0xEB5FB8 Offset: 0xEB1FB8 VA: 0xEB5FB8
	public void .ctor() { }

	// RVA: 0xEB5FC0 Offset: 0xEB1FC0 VA: 0xEB5FC0
	internal int <OnOpen>b__59_1(KeyValuePair<Skill, int> a, KeyValuePair<Skill, int> b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSkill.<>c__DisplayClass50_0 // TypeDefIndex: 2707
{
	// Fields
	public float secondsRemaining; // 0x10
	public PlayerSelfSkill <>4__this; // 0x18
	public RectTransform rect; // 0x20
	public Vector2 to; // 0x28
	public Action onFinish; // 0x30
	public float speedOnSeconds; // 0x38

	// Methods

	// RVA: 0xEB2268 Offset: 0xEAE268 VA: 0xEB2268
	public void .ctor() { }

	// RVA: 0xEB6018 Offset: 0xEB2018 VA: 0xEB6018
	internal void <LeanMoveLocal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSkill.<>c__DisplayClass51_0 // TypeDefIndex: 2708
{
	// Fields
	public bool enabled; // 0x10
	public PlayerSelfSkill <>4__this; // 0x18
	public Action <>9__1; // 0x20

	// Methods

	// RVA: 0xEB2360 Offset: 0xEAE360 VA: 0xEB2360
	public void .ctor() { }

	// RVA: 0xEB61BC Offset: 0xEB21BC VA: 0xEB61BC
	internal void <ShowOpen>b__0() { }

	// RVA: 0xEB62E4 Offset: 0xEB22E4 VA: 0xEB62E4
	internal void <ShowOpen>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSkill.<>c__DisplayClass57_0 // TypeDefIndex: 2709
{
	// Fields
	public PlayerSelfSkill <>4__this; // 0x10
	public int point; // 0x18

	// Methods

	// RVA: 0xEB29B8 Offset: 0xEAE9B8 VA: 0xEB29B8
	public void .ctor() { }

	// RVA: 0xEB6320 Offset: 0xEB2320 VA: 0xEB6320
	internal void <SetLeftPoint>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSkill.<>c__DisplayClass59_0 // TypeDefIndex: 2710
{
	// Fields
	public KeyValuePair<Skill, int> entry; // 0x10
	public PlayerSelfSkill.Cell cell; // 0x20
	public PlayerSelfSkill <>4__this; // 0x28

	// Methods

	// RVA: 0xEB5860 Offset: 0xEB1860 VA: 0xEB5860
	public void .ctor() { }

	// RVA: 0xEB6414 Offset: 0xEB2414 VA: 0xEB6414
	internal void <OnOpen>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSkill.<>c__DisplayClass60_0 // TypeDefIndex: 2711
{
	// Fields
	public PlayerSelfSkill <>4__this; // 0x10
	public PlayerSelfSkill.Cell cell; // 0x18
	public Skill appskill; // 0x20
	public Skill settingskill; // 0x28

	// Methods

	// RVA: 0xEB38A8 Offset: 0xEAF8A8 VA: 0xEB38A8
	public void .ctor() { }

	// RVA: 0xEB649C Offset: 0xEB249C VA: 0xEB649C
	internal void <OpenSkillDetails>b__0() { }

	// RVA: 0xEB64C0 Offset: 0xEB24C0 VA: 0xEB64C0
	internal void <OpenSkillDetails>b__1() { }

	// RVA: 0xEB64E4 Offset: 0xEB24E4 VA: 0xEB64E4
	internal void <OpenSkillDetails>b__2() { }

	// RVA: 0xEB6508 Offset: 0xEB2508 VA: 0xEB6508
	internal void <OpenSkillDetails>b__3() { }

	// RVA: 0xEB652C Offset: 0xEB252C VA: 0xEB652C
	internal void <OpenSkillDetails>b__4() { }

	// RVA: 0xEB6550 Offset: 0xEB2550 VA: 0xEB6550
	internal void <OpenSkillDetails>b__5() { }

	// RVA: 0xEB6574 Offset: 0xEB2574 VA: 0xEB6574
	internal void <OpenSkillDetails>b__6() { }

	// RVA: 0xEB6598 Offset: 0xEB2598 VA: 0xEB6598
	internal void <OpenSkillDetails>b__7() { }

	// RVA: 0xEB65BC Offset: 0xEB25BC VA: 0xEB65BC
	internal void <OpenSkillDetails>b__8() { }

	// RVA: 0xEB65E0 Offset: 0xEB25E0 VA: 0xEB65E0
	internal void <OpenSkillDetails>b__9() { }

	// RVA: 0xEB6604 Offset: 0xEB2604 VA: 0xEB6604
	internal void <OpenSkillDetails>b__10() { }

	// RVA: 0xEB6628 Offset: 0xEB2628 VA: 0xEB6628
	internal void <OpenSkillDetails>b__11() { }

	// RVA: 0xEB6644 Offset: 0xEB2644 VA: 0xEB6644
	internal void <OpenSkillDetails>b__12() { }

	// RVA: 0xEB6660 Offset: 0xEB2660 VA: 0xEB6660
	internal void <OpenSkillDetails>b__13() { }

	// RVA: 0xEB670C Offset: 0xEB270C VA: 0xEB670C
	internal void <OpenSkillDetails>b__14() { }

	// RVA: 0xEB67BC Offset: 0xEB27BC VA: 0xEB67BC
	internal void <OpenSkillDetails>b__15() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSkill.<>c__DisplayClass67_0 // TypeDefIndex: 2712
{
	// Fields
	public PlayerSelfSkill <>4__this; // 0x10
	public Skill appskill; // 0x18

	// Methods

	// RVA: 0xEB4E8C Offset: 0xEB0E8C VA: 0xEB4E8C
	public void .ctor() { }

	// RVA: 0xEB67E0 Offset: 0xEB27E0 VA: 0xEB67E0
	internal void <OnSyncSkill>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSkill.<>c__DisplayClass67_1 // TypeDefIndex: 2713
{
	// Fields
	public PlayerSelfSkill.Cell cell; // 0x10
	public PlayerSelfSkill.<>c__DisplayClass67_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xEB6A64 Offset: 0xEB2A64 VA: 0xEB6A64
	public void .ctor() { }

	// RVA: 0xEB6A6C Offset: 0xEB2A6C VA: 0xEB6A6C
	internal void <OnSyncSkill>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSkill.<>c__DisplayClass68_0 // TypeDefIndex: 2714
{
	// Fields
	public PlayerSelfSkill.Cell cell; // 0x10
	public PlayerSelfSkill <>4__this; // 0x18

	// Methods

	// RVA: 0xEB5F10 Offset: 0xEB1F10 VA: 0xEB5F10
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSkill.<>c__DisplayClass68_1 // TypeDefIndex: 2715
{
	// Fields
	public Skill appskill; // 0x10
	public PlayerSelfSkill.<>c__DisplayClass68_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xEB5F18 Offset: 0xEB1F18 VA: 0xEB5F18
	public void .ctor() { }

	// RVA: 0xEB6AF0 Offset: 0xEB2AF0 VA: 0xEB6AF0
	internal void <ResetWeaponType>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSkill.<>c__DisplayClass68_2 // TypeDefIndex: 2716
{
	// Fields
	public Skill appskill; // 0x10
	public PlayerSelfSkill.<>c__DisplayClass68_0 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xEB5F20 Offset: 0xEB1F20 VA: 0xEB5F20
	public void .ctor() { }

	// RVA: 0xEB6B74 Offset: 0xEB2B74 VA: 0xEB6B74
	internal void <ResetWeaponType>b__2() { }
}

// Namespace: game.ui
public class PlayerSelfSkill : MonoBehaviour // TypeDefIndex: 2717
{
	// Fields
	private const int OriginFramedWidth = 206;
	private const int OriginFramedHeight = 376;
	private const int OriginItemFramedWidth = 38;
	private const int OriginItemFramedHeight = 49;
	private const int OriginLineItemCount = 5;
	[SerializeField]
	private RectTransform backgroundRect; // 0x20
	[SerializeField]
	private Image backgroundImage; // 0x28
	[SerializeField]
	private RectTransform itemListingContent; // 0x30
	[SerializeField]
	private RectTransform itemTemplate; // 0x38
	[SerializeField]
	private TextMeshProUGUI leftpointTmp; // 0x40
	[SerializeField]
	private Button closeButton; // 0x48
	[SerializeField]
	private Button infoCloseArea; // 0x50
	[SerializeField]
	private RectTransform infoRect; // 0x58
	[SerializeField]
	private ContentSizeFitter infoSizeFitterComp; // 0x60
	[SerializeField]
	private ScrollRect infoScrollRect; // 0x68
	[SerializeField]
	private Button infoCloseButton; // 0x70
	[SerializeField]
	private Image infoThumbnail; // 0x78
	[SerializeField]
	private TextMeshProUGUI infoSkillName; // 0x80
	[SerializeField]
	private TextMeshProUGUI infoSkillLevel; // 0x88
	[SerializeField]
	private SkillDetailsHandstrengthButton infoHandstrengthButton; // 0x90
	[SerializeField]
	private TextMeshProUGUI infoDescription; // 0x98
	[SerializeField]
	private GameObject infoHotkeyAttackGo; // 0xA0
	[SerializeField]
	private Button infoHotkeyAttack1; // 0xA8
	[SerializeField]
	private Button infoHotkeyAttack2; // 0xB0
	[SerializeField]
	private Button infoHotkeyAttack3; // 0xB8
	[SerializeField]
	private Button infoHotkeyAttack4; // 0xC0
	[SerializeField]
	private Button infoHotkeyAttack5; // 0xC8
	[SerializeField]
	private Button infoHotkeyAttack6; // 0xD0
	[SerializeField]
	private Button infoHotkeyAttack7; // 0xD8
	[SerializeField]
	private Button infoHotkeyAttack8; // 0xE0
	[SerializeField]
	private Button infoHotkeyAttack9; // 0xE8
	[SerializeField]
	private Button infoHotkeyAttack10; // 0xF0
	[SerializeField]
	private GameObject infoHotkeyAuraGo; // 0xF8
	[SerializeField]
	private Button infoHotkeyAura1; // 0x100
	[SerializeField]
	private Button infoButtonUnused; // 0x108
	[SerializeField]
	private TextMeshProUGUI infoButtonUnusedTmp; // 0x110
	[SerializeField]
	private Button infoButtonLevelup; // 0x118
	[SerializeField]
	private TextMeshProUGUI infoButtonLevelupTmp; // 0x120
	private float scaleRatio; // 0x128
	private Vector2 showoffVisiblePosition; // 0x12C
	private Vector2 showoffHiddenPosition; // 0x134
	private readonly Queue<Action> onStartActions; // 0x140
	private bool isStarted; // 0x148
	private PlayerSelfSkill.Cell cellTemplate; // 0x150
	private List<PlayerSelfSkill.Cell> cellListing; // 0x158
	private Action leanMoveLocalUpdating; // 0x160

	// Methods

	// RVA: 0xEB19E4 Offset: 0xEAD9E4 VA: 0xEB19E4
	private void Start() { }

	// RVA: 0xEB2014 Offset: 0xEAE014 VA: 0xEB2014
	private void Update() { }

	// RVA: 0xEB2030 Offset: 0xEAE030 VA: 0xEB2030
	private void OnDestroy() { }

	// RVA: 0xEB2038 Offset: 0xEAE038 VA: 0xEB2038
	private void Perform(Action action) { }

	// RVA: 0xEB20B4 Offset: 0xEAE0B4 VA: 0xEB20B4
	private void LeanMoveLocal(RectTransform rect, Vector2 to, Action onFinish) { }

	// RVA: 0xEB2270 Offset: 0xEAE270 VA: 0xEB2270
	public void ShowOpen(bool enabled) { }

	// RVA: 0xEB2368 Offset: 0xEAE368 VA: 0xEB2368
	public bool ShowOff() { }

	// RVA: 0xEB23B0 Offset: 0xEAE3B0 VA: 0xEB23B0
	public void ShowDirectly(bool enabled) { }

	// RVA: 0xEB260C Offset: 0xEAE60C VA: 0xEB260C
	public bool IsOpen() { }

	// RVA: 0xEB262C Offset: 0xEAE62C VA: 0xEB262C
	private void CreateNewCellLine() { }

	// RVA: 0xEB28F0 Offset: 0xEAE8F0 VA: 0xEB28F0
	public void SetLeftPoint(int point) { }

	// RVA: 0xEB2460 Offset: 0xEAE460 VA: 0xEB2460
	private void Clear() { }

	// RVA: 0xEB29C0 Offset: 0xEAE9C0 VA: 0xEB29C0
	private void OnOpen() { }

	// RVA: 0xEB2A40 Offset: 0xEAEA40 VA: 0xEB2A40
	private void OpenSkillDetails(Skill appskill, PlayerSelfSkill.Cell cell) { }

	// RVA: 0xEB38B0 Offset: 0xEAF8B0 VA: 0xEB38B0
	private void SetInfoDetailString(string text) { }

	// RVA: 0xEB3A90 Offset: 0xEAFA90 VA: 0xEB3A90
	private void UnUsedSkill(PlayerSelfSkill.Cell cell, Skill appskill, Skill settingskill) { }

	// RVA: 0xEB3C48 Offset: 0xEAFC48 VA: 0xEB3C48
	private void UseSkill(PlayerSelfSkill.Cell cell, Skill appskill, Skill settingskill, int hotkeyIndex) { }

	// RVA: 0xEB40F0 Offset: 0xEB00F0 VA: 0xEB40F0
	private void UpLevelSkill(PlayerSelfSkill.Cell cell, Skill appskill, Skill settingskill) { }

	// RVA: 0xEB3BF8 Offset: 0xEAFBF8 VA: 0xEB3BF8
	private void CloseSkillDetails() { }

	// RVA: 0xEB4D3C Offset: 0xEB0D3C VA: 0xEB4D3C
	public void RemoveSkill(int skillid) { }

	// RVA: 0xEB4D84 Offset: 0xEB0D84 VA: 0xEB4D84
	public void OnSyncSkill(Skill appskill) { }

	// RVA: 0xEB4E94 Offset: 0xEB0E94 VA: 0xEB4E94
	public void ResetWeaponType() { }

	// RVA: 0xEB4F38 Offset: 0xEB0F38 VA: 0xEB4F38
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEB4FC0 Offset: 0xEB0FC0 VA: 0xEB4FC0
	private void <Start>b__46_0() { }

	[CompilerGenerated]
	// RVA: 0xEB5034 Offset: 0xEB1034 VA: 0xEB5034
	private void <Start>b__46_1() { }

	[CompilerGenerated]
	// RVA: 0xEB50A4 Offset: 0xEB10A4 VA: 0xEB50A4
	private void <Start>b__46_2() { }

	[CompilerGenerated]
	// RVA: 0xEB5114 Offset: 0xEB1114 VA: 0xEB5114
	private void <ShowDirectly>b__53_0() { }

	[CompilerGenerated]
	// RVA: 0xEB514C Offset: 0xEB114C VA: 0xEB514C
	private void <OnOpen>b__59_0() { }

	[CompilerGenerated]
	// RVA: 0xEB5ADC Offset: 0xEB1ADC VA: 0xEB5ADC
	private void <ResetWeaponType>b__68_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfSkillDirection.<>c__DisplayClass23_0 // TypeDefIndex: 2718
{
	// Fields
	public PlayerSelfSkillDirection <>4__this; // 0x10
	public GameObject hiddenParent; // 0x18
	public Skill settingskill; // 0x20
	public int hotkeyIndex; // 0x28
	public Sprite thumbnail; // 0x30

	// Methods

	// RVA: 0xEB76F4 Offset: 0xEB36F4 VA: 0xEB76F4
	public void .ctor() { }

	// RVA: 0xEB79CC Offset: 0xEB39CC VA: 0xEB79CC
	internal void <Open>b__0() { }
}

// Namespace: game.ui
public class PlayerSelfSkillDirection : MonoBehaviour // TypeDefIndex: 2719
{
	// Fields
	[SerializeField]
	private List<Image> imageList; // 0x20
	[SerializeField]
	private List<TextMeshProUGUI> tmpList; // 0x28
	[SerializeField]
	private List<Toggle> toggleList; // 0x30
	[SerializeField]
	private RectTransform backgroundRect; // 0x38
	[SerializeField]
	private Toggle dirLinerToggle; // 0x40
	[SerializeField]
	private Toggle dirPositionToggle; // 0x48
	[SerializeField]
	private Toggle dirMovingToggle; // 0x50
	[SerializeField]
	private Toggle controlTouchToggle; // 0x58
	[SerializeField]
	private Toggle controlClickToggle; // 0x60
	[SerializeField]
	private Toggle targetAutoToggle; // 0x68
	[SerializeField]
	private Toggle targetSemiAutoToggle; // 0x70
	[SerializeField]
	private Toggle targetNoneToggle; // 0x78
	[SerializeField]
	private Image finishSkillIcon; // 0x80
	[SerializeField]
	private TextMeshProUGUI finishDescriptionTmp; // 0x88
	[SerializeField]
	private Toggle finishShowDirectionImageToggle; // 0x90
	[SerializeField]
	private Button finishSaveButton; // 0x98
	private GameObject hiddenParent; // 0xA0
	private Queue<Action> onStartActions; // 0xA8
	private bool isStarted; // 0xB0
	private RightHotkey.Skill.Direction.Properties hotkeyProperties; // 0xB8

	// Methods

	// RVA: 0xEB6BF8 Offset: 0xEB2BF8 VA: 0xEB6BF8
	private void Start() { }

	// RVA: 0xEB7624 Offset: 0xEB3624 VA: 0xEB7624
	private void Perform(Action action) { }

	// RVA: 0xEB7534 Offset: 0xEB3534 VA: 0xEB7534
	private void SetTmp(TextMeshProUGUI tmp, string text, string color) { }

	// RVA: 0xEB3FC8 Offset: 0xEAFFC8 VA: 0xEB3FC8
	public void Open(Skill settingskill, int hotkeyIndex, Sprite thumbnail, GameObject hiddenParent) { }

	// RVA: 0xEB76FC Offset: 0xEB36FC VA: 0xEB76FC
	public void Save() { }

	// RVA: 0xEB77D0 Offset: 0xEB37D0 VA: 0xEB77D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEB77D8 Offset: 0xEB37D8 VA: 0xEB77D8
	private void <Start>b__20_0() { }

	[CompilerGenerated]
	// RVA: 0xEB78DC Offset: 0xEB38DC VA: 0xEB78DC
	private void <Start>b__20_1(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEB78F4 Offset: 0xEB38F4 VA: 0xEB78F4
	private void <Start>b__20_2(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEB7910 Offset: 0xEB3910 VA: 0xEB7910
	private void <Start>b__20_3(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEB792C Offset: 0xEB392C VA: 0xEB792C
	private void <Start>b__20_4(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEB7944 Offset: 0xEB3944 VA: 0xEB7944
	private void <Start>b__20_5(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEB7960 Offset: 0xEB3960 VA: 0xEB7960
	private void <Start>b__20_6(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEB7978 Offset: 0xEB3978 VA: 0xEB7978
	private void <Start>b__20_7(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEB7994 Offset: 0xEB3994 VA: 0xEB7994
	private void <Start>b__20_8(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEB79B0 Offset: 0xEB39B0 VA: 0xEB79B0
	private void <Start>b__20_9(bool isOn) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfStorage.Cell.<>c__DisplayClass14_0 // TypeDefIndex: 2720
{
	// Fields
	public Item item; // 0x10

	// Methods

	// RVA: 0xEBA598 Offset: 0xEB6598 VA: 0xEBA598
	public void .ctor() { }

	// RVA: 0xEBA5A0 Offset: 0xEB65A0 VA: 0xEBA5A0
	internal void <Apply>b__0() { }
}

// Namespace: 
public class PlayerSelfStorage.Cell // TypeDefIndex: 2721
{
	// Fields
	public GameObject go; // 0x10
	public RectTransform rectTransform; // 0x18
	public Image framedImage; // 0x20
	public Image backgroundColor; // 0x28
	public ItemBorder itemBorder; // 0x30
	public Image thumbnailImage; // 0x38
	public RectTransform thumbnailRect; // 0x40
	public TextMeshProUGUI stack; // 0x48
	public Button button; // 0x50
	public Item item; // 0x58

	// Methods

	// RVA: 0xEB8320 Offset: 0xEB4320 VA: 0xEB8320
	public void .ctor(GameObject go) { }

	// RVA: 0xEB93D8 Offset: 0xEB53D8 VA: 0xEB93D8
	public PlayerSelfStorage.Cell Clone(GameObject parent) { }

	// RVA: 0xEB9FBC Offset: 0xEB5FBC VA: 0xEB9FBC
	public void Clear() { }

	// RVA: 0xEBA070 Offset: 0xEB6070 VA: 0xEBA070
	public void SetRequiredPassed(bool isPassed) { }

	// RVA: 0xEBA0DC Offset: 0xEB60DC VA: 0xEBA0DC
	public void Apply(Item item) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerSelfStorage.<>c // TypeDefIndex: 2722
{
	// Fields
	public static readonly PlayerSelfStorage.<>c <>9; // 0x0
	public static UnityAction <>9__29_0; // 0x8
	public static UnityAction <>9__29_1; // 0x10
	public static UnityAction <>9__29_2; // 0x18
	public static Action<string> <>9__29_5; // 0x20
	public static UnityAction <>9__29_3; // 0x28

	// Methods

	// RVA: 0xEBA684 Offset: 0xEB6684 VA: 0xEBA684
	private static void .cctor() { }

	// RVA: 0xEBA6EC Offset: 0xEB66EC VA: 0xEBA6EC
	public void .ctor() { }

	// RVA: 0xEBA6F4 Offset: 0xEB66F4 VA: 0xEBA6F4
	internal void <Start>b__29_0() { }

	// RVA: 0xEBA7A4 Offset: 0xEB67A4 VA: 0xEBA7A4
	internal void <Start>b__29_1() { }

	// RVA: 0xEBA848 Offset: 0xEB6848 VA: 0xEBA848
	internal void <Start>b__29_2() { }

	// RVA: 0xEBA8EC Offset: 0xEB68EC VA: 0xEBA8EC
	internal void <Start>b__29_3() { }

	// RVA: 0xEBAA94 Offset: 0xEB6A94 VA: 0xEBAA94
	internal void <Start>b__29_5(string _value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfStorage.<>c__DisplayClass32_0 // TypeDefIndex: 2723
{
	// Fields
	public float secondsRemaining; // 0x10
	public PlayerSelfStorage <>4__this; // 0x18
	public RectTransform rect; // 0x20
	public Vector2 to; // 0x28
	public Action onFinish; // 0x30
	public float speedOnSeconds; // 0x38

	// Methods

	// RVA: 0xEB89FC Offset: 0xEB49FC VA: 0xEB89FC
	public void .ctor() { }

	// RVA: 0xEBABDC Offset: 0xEB6BDC VA: 0xEBABDC
	internal void <LeanMoveLocal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfStorage.<>c__DisplayClass38_0 // TypeDefIndex: 2724
{
	// Fields
	public PlayerSelfStorage <>4__this; // 0x10
	public bool isLocked; // 0x18

	// Methods

	// RVA: 0xEB8FD8 Offset: 0xEB4FD8 VA: 0xEB8FD8
	public void .ctor() { }

	// RVA: 0xEBAD7C Offset: 0xEB6D7C VA: 0xEBAD7C
	internal void <SetLockState>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfStorage.<>c__DisplayClass39_0 // TypeDefIndex: 2725
{
	// Fields
	public int storageLocaltion; // 0x10

	// Methods

	// RVA: 0xEB8FE0 Offset: 0xEB4FE0 VA: 0xEB8FE0
	public void .ctor() { }

	// RVA: 0xEBADE4 Offset: 0xEB6DE4 VA: 0xEBADE4
	internal void <SetItemForBagarateOnClickOption>b__0(int itemtabCellIndex, PlayerSelfBagarate.Cell cell) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfStorage.<>c__DisplayClass39_1 // TypeDefIndex: 2726
{
	// Fields
	public PlayerSelfBagarate.Cell cell; // 0x10
	public PlayerSelfStorage.<>c__DisplayClass39_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xEBAFEC Offset: 0xEB6FEC VA: 0xEBAFEC
	public void .ctor() { }

	// RVA: 0xEBAFF4 Offset: 0xEB6FF4 VA: 0xEBAFF4
	internal void <SetItemForBagarateOnClickOption>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfStorage.<>c__DisplayClass43_0 // TypeDefIndex: 2727
{
	// Fields
	public PlayerSelfStorage <>4__this; // 0x10
	public int cellindex; // 0x18
	public Item item; // 0x20

	// Methods

	// RVA: 0xEB94B0 Offset: 0xEB54B0 VA: 0xEB94B0
	public void .ctor() { }

	// RVA: 0xEBB0F8 Offset: 0xEB70F8 VA: 0xEBB0F8
	internal void <ApplyItem>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfStorage.<>c__DisplayClass44_0 // TypeDefIndex: 2728
{
	// Fields
	public PlayerSelfStorage <>4__this; // 0x10
	public Item item; // 0x18

	// Methods

	// RVA: 0xEB958C Offset: 0xEB558C VA: 0xEB958C
	public void .ctor() { }

	// RVA: 0xEBB188 Offset: 0xEB7188 VA: 0xEBB188
	internal void <ReplaceItem>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfStorage.<>c__DisplayClass45_0 // TypeDefIndex: 2729
{
	// Fields
	public PlayerSelfStorage <>4__this; // 0x10
	public Item item; // 0x18

	// Methods

	// RVA: 0xEB9668 Offset: 0xEB5668 VA: 0xEB9668
	public void .ctor() { }

	// RVA: 0xEBB2E8 Offset: 0xEB72E8 VA: 0xEBB2E8
	internal void <AddItem>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfStorage.<>c__DisplayClass46_0 // TypeDefIndex: 2730
{
	// Fields
	public PlayerSelfStorage <>4__this; // 0x10
	public int itemindex; // 0x18

	// Methods

	// RVA: 0xEB9754 Offset: 0xEB5754 VA: 0xEB9754
	public void .ctor() { }

	// RVA: 0xEBB48C Offset: 0xEB748C VA: 0xEBB48C
	internal void <ClearByItemIndex>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfStorage.<>c__DisplayClass47_0 // TypeDefIndex: 2731
{
	// Fields
	public int cellindex; // 0x10
	public PlayerSelfStorage <>4__this; // 0x18

	// Methods

	// RVA: 0xEB9824 Offset: 0xEB5824 VA: 0xEB9824
	public void .ctor() { }

	// RVA: 0xEBB5F0 Offset: 0xEB75F0 VA: 0xEBB5F0
	internal void <ClearCell>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfStorage.<>c__DisplayClass49_0 // TypeDefIndex: 2732
{
	// Fields
	public PlayerSelfStorage <>4__this; // 0x10
	public long value; // 0x18

	// Methods

	// RVA: 0xEB98F4 Offset: 0xEB58F4 VA: 0xEB98F4
	public void .ctor() { }

	// RVA: 0xEBB678 Offset: 0xEB7678 VA: 0xEBB678
	internal void <SetMoney>b__0() { }
}

// Namespace: game.ui
public class PlayerSelfStorage : MonoBehaviour // TypeDefIndex: 2733
{
	// Fields
	public const int OriginFramedWidth = 214;
	private const int OriginFramedHeight = 454;
	private const int OriginItemFramedWidth = 42;
	private const int OriginItemFramedHeight = 42;
	private const int static_lineItemCount = 4;
	private const int static_lineCountDefault = 7;
	private const int static_cellElementCountDefault = 28;
	[SerializeField]
	private RectTransform backgroundRect; // 0x20
	[SerializeField]
	private Image backgroundImage; // 0x28
	[SerializeField]
	private RectTransform itemListingContent; // 0x30
	[SerializeField]
	private RectTransform itemTemplate; // 0x38
	[SerializeField]
	private TextMeshProUGUI money; // 0x40
	[SerializeField]
	private TextMeshProUGUI itemCount; // 0x48
	[SerializeField]
	private Button sortButton; // 0x50
	[SerializeField]
	private Button extensionButton; // 0x58
	[SerializeField]
	private Button lockButton; // 0x60
	[SerializeField]
	private Button sendMoneyButton; // 0x68
	[SerializeField]
	private Button closeButton; // 0x70
	[SerializeField]
	private Button lockedButton; // 0x78
	[SerializeField]
	private Image lockedImage; // 0x80
	private float scaleRatio; // 0x88
	private Vector2 showoffVisiblePosition; // 0x8C
	private Vector2 showoffHiddenPosition; // 0x94
	private readonly Queue<Action> onStartActions; // 0xA0
	private bool isStarted; // 0xA8
	private bool isOpening; // 0xA9
	private PlayerSelfStorage.Cell cellTemplate; // 0xB0
	private readonly List<PlayerSelfStorage.Cell> cellListing; // 0xB8
	private Action leanMoveLocalUpdating; // 0xC0

	// Methods

	// RVA: 0xEB7DA0 Offset: 0xEB3DA0 VA: 0xEB7DA0
	private void Start() { }

	// RVA: 0xEB87B0 Offset: 0xEB47B0 VA: 0xEB87B0
	private void Update() { }

	// RVA: 0xEB87CC Offset: 0xEB47CC VA: 0xEB87CC
	private void Perform(Action action) { }

	// RVA: 0xEB8848 Offset: 0xEB4848 VA: 0xEB8848
	private void LeanMoveLocal(RectTransform rect, Vector2 to, Action onFinish) { }

	// RVA: 0xEB8A04 Offset: 0xEB4A04 VA: 0xEB8A04
	public void ShowOpen(bool enabled) { }

	// RVA: 0xEB8B2C Offset: 0xEB4B2C VA: 0xEB8B2C
	public void ShowOff() { }

	// RVA: 0xEB8B3C Offset: 0xEB4B3C VA: 0xEB8B3C
	public void ShowDirectly(bool enabled) { }

	// RVA: 0xEB8F04 Offset: 0xEB4F04 VA: 0xEB8F04
	public bool IsOpen() { }

	// RVA: 0xEB8F0C Offset: 0xEB4F0C VA: 0xEB8F0C
	public void SetLockState(bool isLocked) { }

	// RVA: 0xEB8E08 Offset: 0xEB4E08 VA: 0xEB8E08
	public void SetItemForBagarateOnClickOption(int storageLocaltion) { }

	// RVA: 0xEB8FE8 Offset: 0xEB4FE8 VA: 0xEB8FE8
	public void SortItems(bool flag) { }

	// RVA: 0xEB8624 Offset: 0xEB4624 VA: 0xEB8624
	private void CreateNewCellLine() { }

	// RVA: 0xEB925C Offset: 0xEB525C VA: 0xEB925C
	private void ClearEmptyCellLine(int existingItemCount) { }

	// RVA: 0xEB9178 Offset: 0xEB5178 VA: 0xEB9178
	public void ApplyItem(int cellindex, Item item) { }

	// RVA: 0xEB94B8 Offset: 0xEB54B8 VA: 0xEB94B8
	public void ReplaceItem(Item item) { }

	// RVA: 0xEB9594 Offset: 0xEB5594 VA: 0xEB9594
	public void AddItem(Item item) { }

	// RVA: 0xEB9670 Offset: 0xEB5670 VA: 0xEB9670
	public void ClearByItemIndex(int itemindex) { }

	// RVA: 0xEB975C Offset: 0xEB575C VA: 0xEB975C
	public void ClearCell(int cellindex) { }

	// RVA: 0xEB90F8 Offset: 0xEB50F8 VA: 0xEB90F8
	public void ClearAll() { }

	// RVA: 0xEB982C Offset: 0xEB582C VA: 0xEB982C
	public void SetMoney(long value) { }

	// RVA: 0xEB98FC Offset: 0xEB58FC VA: 0xEB98FC
	public void ResetStorageCount() { }

	// RVA: 0xEB9B50 Offset: 0xEB5B50 VA: 0xEB9B50
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEB9C2C Offset: 0xEB5C2C VA: 0xEB9C2C
	private void <Start>b__29_4() { }

	[CompilerGenerated]
	// RVA: 0xEB9CA0 Offset: 0xEB5CA0 VA: 0xEB9CA0
	private void <ShowOpen>b__33_0() { }

	[CompilerGenerated]
	// RVA: 0xEB9E28 Offset: 0xEB5E28 VA: 0xEB9E28
	private void <ShowOpen>b__33_1() { }

	[CompilerGenerated]
	// RVA: 0xEB9E54 Offset: 0xEB5E54 VA: 0xEB9E54
	private void <ShowDirectly>b__35_0() { }

	[CompilerGenerated]
	// RVA: 0xEB9E88 Offset: 0xEB5E88 VA: 0xEB9E88
	private void <ClearAll>b__48_0() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerSelfStorageExtension.<>c // TypeDefIndex: 2734
{
	// Fields
	public static readonly PlayerSelfStorageExtension.<>c <>9; // 0x0
	public static Action <>9__35_1; // 0x8

	// Methods

	// RVA: 0xEBD960 Offset: 0xEB9960 VA: 0xEBD960
	private static void .cctor() { }

	// RVA: 0xEBD9C8 Offset: 0xEB99C8 VA: 0xEBD9C8
	public void .ctor() { }

	// RVA: 0xEBD9D0 Offset: 0xEB99D0 VA: 0xEBD9D0
	internal void <ShowOpen>b__35_1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfStorageExtension.<>c__DisplayClass34_0 // TypeDefIndex: 2735
{
	// Fields
	public float secondsRemaining; // 0x10
	public PlayerSelfStorageExtension <>4__this; // 0x18
	public RectTransform rect; // 0x20
	public Vector2 to; // 0x28
	public Action onFinish; // 0x30
	public float speedOnSeconds; // 0x38

	// Methods

	// RVA: 0xEBDA2C Offset: 0xEB9A2C VA: 0xEBDA2C
	public void .ctor() { }

	// RVA: 0xEBDA34 Offset: 0xEB9A34 VA: 0xEBDA34
	internal void <LeanMoveLocal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfStorageExtension.<>c__DisplayClass41_0 // TypeDefIndex: 2736
{
	// Fields
	public PlayerSelfStorageExtension <>4__this; // 0x10
	public int itemindex; // 0x18

	// Methods

	// RVA: 0xEBDBD4 Offset: 0xEB9BD4 VA: 0xEBDBD4
	public void .ctor() { }

	// RVA: 0xEBDBDC Offset: 0xEB9BDC VA: 0xEBDBDC
	internal void <ClearByItemIndex>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfStorageExtension.<>c__DisplayClass44_0 // TypeDefIndex: 2737
{
	// Fields
	public PlayerSelfStorageExtension <>4__this; // 0x10
	public int cellindex; // 0x18
	public Item item; // 0x20

	// Methods

	// RVA: 0xEBDD48 Offset: 0xEB9D48 VA: 0xEBDD48
	public void .ctor() { }

	// RVA: 0xEBDD50 Offset: 0xEB9D50 VA: 0xEBDD50
	internal void <ApplyItem>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerSelfStorageExtension.<>c__DisplayClass45_0 // TypeDefIndex: 2738
{
	// Fields
	public PlayerSelfStorageExtension <>4__this; // 0x10
	public Item item; // 0x18

	// Methods

	// RVA: 0xEBDDE8 Offset: 0xEB9DE8 VA: 0xEBDDE8
	public void .ctor() { }

	// RVA: 0xEBDDF0 Offset: 0xEB9DF0 VA: 0xEBDDF0
	internal void <AddItem>b__0() { }
}

// Namespace: game.ui
public class PlayerSelfStorageExtension : MonoBehaviour // TypeDefIndex: 2739
{
	// Fields
	public const int OriginFramedWidth = 214;
	private const int OriginFramedHeight = 454;
	private const int OriginItemFramedWidth = 42;
	private const int OriginItemFramedHeight = 42;
	private const int static_lineItemCount = 4;
	private const int static_lineCountDefault = 7;
	private const int static_cellElementCountDefault = 28;
	[SerializeField]
	private RectTransform backgroundRect; // 0x20
	[SerializeField]
	private Image backgroundImage; // 0x28
	[SerializeField]
	private RectTransform itemListingContent; // 0x30
	[SerializeField]
	private RectTransform itemTemplate; // 0x38
	[SerializeField]
	private TextMeshProUGUI itemCount; // 0x40
	[SerializeField]
	private TextMeshProUGUI store1Label; // 0x48
	[SerializeField]
	private TextMeshProUGUI store2Label; // 0x50
	[SerializeField]
	private TextMeshProUGUI store3Label; // 0x58
	[SerializeField]
	private TextMeshProUGUI store4Label; // 0x60
	[SerializeField]
	private Button store1Button; // 0x68
	[SerializeField]
	private Button store2Button; // 0x70
	[SerializeField]
	private Button store3Button; // 0x78
	[SerializeField]
	private Button store4Button; // 0x80
	[SerializeField]
	private Button closeButton; // 0x88
	private float scaleRatio; // 0x90
	private Vector2 showoffVisiblePosition; // 0x94
	private Vector2 showoffHiddenPosition; // 0x9C
	private readonly Queue<Action> onStartActions; // 0xA8
	private bool isStarted; // 0xB0
	private bool isOpening; // 0xB1
	private PlayerSelfStorage.Cell cellTemplate; // 0xB8
	private readonly List<PlayerSelfStorage.Cell> cellListing; // 0xC0
	private Action leanMoveLocalUpdating; // 0xC8
	public int currentStorageExtendNum; // 0xD0

	// Methods

	// RVA: 0xEBB760 Offset: 0xEB7760 VA: 0xEBB760
	private void Start() { }

	// RVA: 0xEBC258 Offset: 0xEB8258 VA: 0xEBC258
	private void Update() { }

	// RVA: 0xEBC274 Offset: 0xEB8274 VA: 0xEBC274
	private void Perform(Action action) { }

	// RVA: 0xEBC2F0 Offset: 0xEB82F0 VA: 0xEBC2F0
	private void LeanMoveLocal(RectTransform rect, Vector2 to, Action onFinish) { }

	// RVA: 0xEBC4A4 Offset: 0xEB84A4 VA: 0xEBC4A4
	public void ShowOpen(bool enabled) { }

	// RVA: 0xEBA794 Offset: 0xEB6794 VA: 0xEBA794
	public void ShowOff() { }

	// RVA: 0xEB8CC0 Offset: 0xEB4CC0 VA: 0xEB8CC0
	public void ShowDirectly(bool enabled) { }

	// RVA: 0xEBC5A8 Offset: 0xEB85A8 VA: 0xEBC5A8
	public bool IsOpen() { }

	// RVA: 0xEBC5B0 Offset: 0xEB85B0 VA: 0xEBC5B0
	public void SortItems(bool flag) { }

	// RVA: 0xEBC6C0 Offset: 0xEB86C0 VA: 0xEBC6C0
	public void ClearAll() { }

	// RVA: 0xEBC9A0 Offset: 0xEB89A0 VA: 0xEBC9A0
	public void ClearByItemIndex(int itemindex) { }

	// RVA: 0xEBCA84 Offset: 0xEB8A84 VA: 0xEBCA84
	public void ResetStorageCount() { }

	// RVA: 0xEBBE34 Offset: 0xEB7E34 VA: 0xEBBE34
	private void SetStoreActive(int num) { }

	// RVA: 0xEBC740 Offset: 0xEB8740 VA: 0xEBC740
	public void ApplyItem(int cellindex, Item item) { }

	// RVA: 0xEBD0DC Offset: 0xEB90DC VA: 0xEBD0DC
	public void AddItem(Item item) { }

	// RVA: 0xEBC54C Offset: 0xEB854C VA: 0xEBC54C
	private void SetStoreUnactive() { }

	// RVA: 0xEBCCF4 Offset: 0xEB8CF4 VA: 0xEBCCF4
	private void SetStoreNumLabel(int storageExtend) { }

	// RVA: 0xEBBD24 Offset: 0xEB7D24 VA: 0xEBBD24
	private void SetItemCountLabel(int current, int maximum) { }

	// RVA: 0xEBD1E4 Offset: 0xEB91E4 VA: 0xEBD1E4
	public RectTransform GetRectTransform() { }

	// RVA: 0xEBD1EC Offset: 0xEB91EC VA: 0xEBD1EC
	public float GetScaleRatio() { }

	// RVA: 0xEBBB98 Offset: 0xEB7B98 VA: 0xEBBB98
	private void CreateNewCellLine() { }

	// RVA: 0xEBC824 Offset: 0xEB8824 VA: 0xEBC824
	private void ClearEmptyCellLine(int existingItemCount) { }

	// RVA: 0xEBD1F4 Offset: 0xEB91F4 VA: 0xEBD1F4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEBD2D0 Offset: 0xEB92D0 VA: 0xEBD2D0
	private void <Start>b__31_0() { }

	[CompilerGenerated]
	// RVA: 0xEBD344 Offset: 0xEB9344 VA: 0xEBD344
	private void <Start>b__31_1() { }

	[CompilerGenerated]
	// RVA: 0xEBD3B8 Offset: 0xEB93B8 VA: 0xEBD3B8
	private void <Start>b__31_2() { }

	[CompilerGenerated]
	// RVA: 0xEBD42C Offset: 0xEB942C VA: 0xEBD42C
	private void <Start>b__31_3() { }

	[CompilerGenerated]
	// RVA: 0xEBD4A0 Offset: 0xEB94A0 VA: 0xEBD4A0
	private void <Start>b__31_4() { }

	[CompilerGenerated]
	// RVA: 0xEBD550 Offset: 0xEB9550 VA: 0xEBD550
	private void <ShowOpen>b__35_0() { }

	[CompilerGenerated]
	// RVA: 0xEBD720 Offset: 0xEB9720 VA: 0xEBD720
	private void <ShowOpen>b__35_2() { }

	[CompilerGenerated]
	// RVA: 0xEBD79C Offset: 0xEB979C VA: 0xEBD79C
	private void <ShowDirectly>b__37_0() { }

	[CompilerGenerated]
	// RVA: 0xEBD82C Offset: 0xEB982C VA: 0xEBD82C
	private void <ClearAll>b__40_0() { }
}

// Namespace: 
private class PlayerTalk.FieldData // TypeDefIndex: 2740
{
	// Fields
	public GameObject go; // 0x10
	public TextMeshProUGUI text; // 0x18
	public float remaningTime; // 0x20

	// Methods

	// RVA: 0xEBE7AC Offset: 0xEBA7AC VA: 0xEBE7AC
	public void .ctor() { }
}

// Namespace: game.ui
public class PlayerTalk : MonoBehaviour // TypeDefIndex: 2741
{
	// Fields
	[SerializeField]
	private GameObject SystemItem; // 0x20
	[SerializeField]
	private GameObject ListSystem; // 0x28
	private bool hasStarted; // 0x30
	private Queue<string> chatmessageOnStarted; // 0x38
	private readonly List<PlayerTalk.FieldData> listing; // 0x40
	private bool IsUseSoundEffect; // 0x48
	private bool IsHidenMessage; // 0x49

	// Methods

	// RVA: 0xEBDFA4 Offset: 0xEB9FA4 VA: 0xEBDFA4
	private void Start() { }

	// RVA: 0xEBE08C Offset: 0xEBA08C VA: 0xEBE08C
	private void Update() { }

	// RVA: 0xEBE3E8 Offset: 0xEBA3E8 VA: 0xEBE3E8
	public void SetEnableSoundEffect(bool enabled) { }

	// RVA: 0xEBE3F0 Offset: 0xEBA3F0 VA: 0xEBE3F0
	public void SetDisplayMessage(bool displayed) { }

	// RVA: 0xEBE3FC Offset: 0xEBA3FC VA: 0xEBE3FC
	public void AddMessage(string message) { }

	// RVA: 0xEBE7B4 Offset: 0xEBA7B4 VA: 0xEBE7B4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEBE890 Offset: 0xEBA890 VA: 0xEBE890
	private void <Start>b__8_0() { }

	[CompilerGenerated]
	// RVA: 0xEBE94C Offset: 0xEBA94C VA: 0xEBE94C
	private void <Start>b__8_2() { }

	[CompilerGenerated]
	// RVA: 0xEBE9D4 Offset: 0xEBA9D4 VA: 0xEBE9D4
	private void <Start>b__8_1() { }

	[CompilerGenerated]
	// RVA: 0xEBEA90 Offset: 0xEBAA90 VA: 0xEBEA90
	private void <Start>b__8_3() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class PlayerTradePc.<>c // TypeDefIndex: 2742
{
	// Fields
	public static readonly PlayerTradePc.<>c <>9; // 0x0
	public static Action<string> <>9__38_4; // 0x8
	public static UnityAction <>9__38_3; // 0x10

	// Methods

	// RVA: 0xEC1670 Offset: 0xEBD670 VA: 0xEC1670
	private static void .cctor() { }

	// RVA: 0xEC16D8 Offset: 0xEBD6D8 VA: 0xEC16D8
	public void .ctor() { }

	// RVA: 0xEC16E0 Offset: 0xEBD6E0 VA: 0xEC16E0
	internal void <Start>b__38_3() { }

	// RVA: 0xEC1884 Offset: 0xEBD884 VA: 0xEC1884
	internal void <Start>b__38_4(string _value) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerTradePc.<>c__DisplayClass44_0 // TypeDefIndex: 2743
{
	// Fields
	public KeyValuePair<int, Item> entry; // 0x10
	public Action <>9__2; // 0x20

	// Methods

	// RVA: 0xEC1668 Offset: 0xEBD668 VA: 0xEC1668
	public void .ctor() { }

	// RVA: 0xEC1930 Offset: 0xEBD930 VA: 0xEC1930
	internal void <Open>b__1() { }

	// RVA: 0xEC1AFC Offset: 0xEBDAFC VA: 0xEC1AFC
	internal void <Open>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerTradePc.<>c__DisplayClass46_0 // TypeDefIndex: 2744
{
	// Fields
	public Item item; // 0x10
	public Action <>9__1; // 0x18
	public Action <>9__0; // 0x20

	// Methods

	// RVA: 0xEBFF68 Offset: 0xEBBF68 VA: 0xEBFF68
	public void .ctor() { }

	// RVA: 0xEC1BE4 Offset: 0xEBDBE4 VA: 0xEC1BE4
	internal void <ProtocolTradeProcessSendItemToRemove>b__0() { }

	// RVA: 0xEC1DA4 Offset: 0xEBDDA4 VA: 0xEC1DA4
	internal void <ProtocolTradeProcessSendItemToRemove>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerTradePc.<>c__DisplayClass47_0 // TypeDefIndex: 2745
{
	// Fields
	public Item item; // 0x10

	// Methods

	// RVA: 0xEC0254 Offset: 0xEBC254 VA: 0xEC0254
	public void .ctor() { }

	// RVA: 0xEC1E80 Offset: 0xEBDE80 VA: 0xEC1E80
	internal void <ProtocolTradeProcessSendItemToAdd>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerTradePc.<>c__DisplayClass48_0 // TypeDefIndex: 2746
{
	// Fields
	public Item itemrefund; // 0x10
	public Action <>9__1; // 0x18

	// Methods

	// RVA: 0xEC0610 Offset: 0xEBC610 VA: 0xEC0610
	public void .ctor() { }

	// RVA: 0xEC1FA4 Offset: 0xEBDFA4 VA: 0xEC1FA4
	internal void <ProtocolTradeProcessRefundItemSource>b__0() { }

	// RVA: 0xEC2164 Offset: 0xEBE164 VA: 0xEC2164
	internal void <ProtocolTradeProcessRefundItemSource>b__1() { }
}

// Namespace: game.ui
public class PlayerTradePc : MonoBehaviour // TypeDefIndex: 2747
{
	// Fields
	private const int OriginFramedWidth = 428;
	private const int OriginFramedHeight = 376;
	private const int OriginItemFramedWidth = 42;
	private const int OriginItemFramedHeight = 42;
	private const int OriginBagarateLineItemCount = 4;
	private const int OriginGiveLineItemCount = 5;
	[SerializeField]
	private RectTransform backgroundRect; // 0x20
	[SerializeField]
	private Image backgroundImage; // 0x28
	[SerializeField]
	private RectTransform selfBagarateListingContent; // 0x30
	[SerializeField]
	private RectTransform selfBagarateTemplateGo; // 0x38
	[SerializeField]
	private RectTransform selfGiveListingContent; // 0x40
	[SerializeField]
	private RectTransform selfGiveTemplateGo; // 0x48
	[SerializeField]
	private GameObject selfInfoBackgroundGo; // 0x50
	[SerializeField]
	private TextMeshProUGUI selfInfoTmp; // 0x58
	[SerializeField]
	private TextMeshProUGUI selfGiveMoneyTmp; // 0x60
	[SerializeField]
	private TextMeshProUGUI selfCurrentMoneyTmp; // 0x68
	[SerializeField]
	private RectTransform otherGiveListingContent; // 0x70
	[SerializeField]
	private RectTransform otherGiveTemplateGo; // 0x78
	[SerializeField]
	private GameObject otherInfoBackgroundGo; // 0x80
	[SerializeField]
	private TextMeshProUGUI otherInfoTmp; // 0x88
	[SerializeField]
	private TextMeshProUGUI otherGiveMoneyTmp; // 0x90
	[SerializeField]
	private Button funcSendMoneyButton; // 0x98
	[SerializeField]
	private Button funcAgreeButton; // 0xA0
	[SerializeField]
	private GameObject funcAgreeLockedGo; // 0xA8
	[SerializeField]
	private Button funcConfirmButton; // 0xB0
	[SerializeField]
	private GameObject funcConfirmLockedGo; // 0xB8
	[SerializeField]
	private Button funcCancelButton; // 0xC0
	private float scaleRatio; // 0xC8
	private Queue<Action> onStartActions; // 0xD0
	private bool isStarted; // 0xD8
	private PlayerSelfBagarate.Cell selfBagarateItemTemplate; // 0xE0
	private PlayerSelfBagarate.Cell selfGiveItemTemplate; // 0xE8
	private PlayerSelfBagarate.Cell otherGiveItemTemplate; // 0xF0
	private List<PlayerSelfBagarate.Cell> selfBagarateCellListing; // 0xF8
	private List<PlayerSelfBagarate.Cell> selfGiveCellListing; // 0x100
	private List<PlayerSelfBagarate.Cell> otherGiveCellListing; // 0x108
	private TradeStart tradestart; // 0x110
	private long timestampToAllowConfirm; // 0x118

	// Methods

	// RVA: 0xEBEA9C Offset: 0xEBAA9C VA: 0xEBEA9C
	private void Start() { }

	// RVA: 0xEBF528 Offset: 0xEBB528 VA: 0xEBF528
	private void Perform(Action action) { }

	// RVA: 0xEBF060 Offset: 0xEBB060 VA: 0xEBF060
	private void CreateNewBagarateCellLine() { }

	// RVA: 0xEBF1F0 Offset: 0xEBB1F0 VA: 0xEBF1F0
	private void CreateNewSelfGiveCellLine() { }

	// RVA: 0xEBF38C Offset: 0xEBB38C VA: 0xEBF38C
	private void CreateNewOtherGiveCellLine() { }

	// RVA: 0xEBF5F8 Offset: 0xEBB5F8 VA: 0xEBF5F8
	private void Close(bool sendClose = False) { }

	// RVA: 0xEBF744 Offset: 0xEBB744 VA: 0xEBF744
	public void Open(TradeStart message) { }

	// RVA: 0xEBFAC0 Offset: 0xEBBAC0 VA: 0xEBFAC0
	public void ProtocolTradeTargetDisconnect() { }

	// RVA: 0xEBFB64 Offset: 0xEBBB64 VA: 0xEBFB64
	public void ProtocolTradeProcessSendItemToRemove(TradeProcessSendItemToRemove message) { }

	// RVA: 0xEBFF70 Offset: 0xEBBF70 VA: 0xEBFF70
	public void ProtocolTradeProcessSendItemToAdd(TradeProcessSendItemToAdd message) { }

	// RVA: 0xEC025C Offset: 0xEBC25C VA: 0xEC025C
	public void ProtocolTradeProcessRefundItemSource(TradeProcessRefundItemSource message) { }

	// RVA: 0xEC0618 Offset: 0xEBC618 VA: 0xEC0618
	public void ProtocolTradeProcessRefundItemDestinate(TradeProcessRefundItemDestinate message) { }

	// RVA: 0xEC0840 Offset: 0xEBC840 VA: 0xEC0840
	public void ProtocolTradeProcessSendCashToRemove(TradeProcessSendCashToRemove message) { }

	// RVA: 0xEC09E0 Offset: 0xEBC9E0 VA: 0xEC09E0
	public void ProtocolTradeProcessSendCashToAdd(TradeProcessSendCashToAdd message) { }

	// RVA: 0xEC0AE4 Offset: 0xEBCAE4 VA: 0xEC0AE4
	public void ProtocolTradeFinishCancel() { }

	// RVA: 0xEC0B20 Offset: 0xEBCB20 VA: 0xEC0B20
	public void ProtocolTradeFinishLock() { }

	// RVA: 0xEC0B9C Offset: 0xEBCB9C VA: 0xEC0B9C
	public void ProtocolTradeFinishConfirm() { }

	// RVA: 0xEC0BA4 Offset: 0xEBCBA4 VA: 0xEC0BA4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEC0BAC Offset: 0xEBCBAC VA: 0xEC0BAC
	private void <Start>b__38_0() { }

	[CompilerGenerated]
	// RVA: 0xEC0BB4 Offset: 0xEBCBB4 VA: 0xEC0BB4
	private void <Start>b__38_1() { }

	[CompilerGenerated]
	// RVA: 0xEC0D00 Offset: 0xEBCD00 VA: 0xEC0D00
	private void <Start>b__38_2() { }

	[CompilerGenerated]
	// RVA: 0xEC0E94 Offset: 0xEBCE94 VA: 0xEC0E94
	private void <Close>b__43_0() { }

	[CompilerGenerated]
	// RVA: 0xEC124C Offset: 0xEBD24C VA: 0xEC124C
	private void <Open>b__44_0() { }
}

// Namespace: game.ui
public class PartyActionUi : MonoBehaviour // TypeDefIndex: 2748
{
	// Fields
	[SerializeField]
	private TextMeshProUGUI tmproInfo; // 0x20
	[SerializeField]
	private TextMeshProUGUI tmproLeave; // 0x28
	[SerializeField]
	private TextMeshProUGUI tmproKick; // 0x30
	[SerializeField]
	private TextMeshProUGUI tmproToLead; // 0x38
	[SerializeField]
	private TextMeshProUGUI tmproClose; // 0x40

	// Methods

	// RVA: 0xEC2240 Offset: 0xEBE240 VA: 0xEC2240
	private void Start() { }

	// RVA: 0xEC24A0 Offset: 0xEBE4A0 VA: 0xEC24A0
	public void .ctor() { }
}

// Namespace: 
public enum QuestTeamChat.TabIndex // TypeDefIndex: 2749
{
	// Fields
	public int value__; // 0x0
	public const QuestTeamChat.TabIndex unidentified = 0;
	public const QuestTeamChat.TabIndex quest = 1;
	public const QuestTeamChat.TabIndex party = 2;
	public const QuestTeamChat.TabIndex chat = 3;
}

// Namespace: game.ui
public class QuestTeamChat : MonoBehaviour // TypeDefIndex: 2750
{
	// Fields
	[SerializeField]
	public Image minimizeIcon; // 0x20
	[SerializeField]
	private Button minimizeButton; // 0x28
	[SerializeField]
	private Image questIcon; // 0x30
	[SerializeField]
	private Button questButton; // 0x38
	[SerializeField]
	private Image partyIcon; // 0x40
	[SerializeField]
	private Button partyButton; // 0x48
	[SerializeField]
	public RectTransform teamButtonGroupRect; // 0x50
	[SerializeField]
	public RectTransform chatButtonGroupRect; // 0x58
	[SerializeField]
	private Image chatHistoryIcon; // 0x60
	[SerializeField]
	private Button chatButton; // 0x68
	[SerializeField]
	public RectTransform contentRect; // 0x70
	[SerializeField]
	public Quest questContent; // 0x78
	[SerializeField]
	private RectTransform questContentRect; // 0x80
	[SerializeField]
	public Party teamContent; // 0x88
	[SerializeField]
	public Chat chatContent; // 0x90
	[SerializeField]
	private RectTransform chatContentRect; // 0x98
	[SerializeField]
	private ScrollRect chatContentScroll; // 0xA0
	[SerializeField]
	private GameObject UIPanel; // 0xA8
	[SerializeField]
	private GameObject ChatButtonViewMode; // 0xB0
	[SerializeField]
	private GameObject ChatButtonScrollMode; // 0xB8
	[SerializeField]
	private ResizeButton resizeButton; // 0xC0
	[SerializeField]
	public RectTransform leftMenuBar; // 0xC8
	[SerializeField]
	private Image leftSideBarImage; // 0xD0
	[SerializeField]
	private Image leftSideBarResizeImage; // 0xD8
	private RectTransform scrollFrameRect; // 0xE0
	private RectTransform scrollButtonRect; // 0xE8
	private bool isOpen; // 0xF0
	private QuestTeamChat.TabIndex positionTab; // 0xF4
	private bool chatHistoryScrollMode; // 0xF8
	private bool chatHistoryScrollButtonUp; // 0xF9

	// Methods

	// RVA: 0xEC24A8 Offset: 0xEBE4A8 VA: 0xEC24A8
	private void Awake() { }

	// RVA: 0xEC2570 Offset: 0xEBE570 VA: 0xEC2570
	private void Start() { }

	// RVA: 0xEC2B0C Offset: 0xEBEB0C VA: 0xEC2B0C
	private void Update() { }

	// RVA: 0xEC2C88 Offset: 0xEBEC88 VA: 0xEC2C88
	public void QuestLimit(QuestLimit quest) { }

	// RVA: 0xEC2D6C Offset: 0xEBED6C VA: 0xEC2D6C
	public void ChatHistorySwitch() { }

	// RVA: 0xEC2E90 Offset: 0xEBEE90 VA: 0xEC2E90
	public void SetHistoryTab(int channel) { }

	// RVA: 0xEC2EA8 Offset: 0xEBEEA8 VA: 0xEC2EA8
	public void QuestFocus() { }

	// RVA: 0xEC2EE0 Offset: 0xEBEEE0 VA: 0xEC2EE0
	private void HighlightIcon(Image icon) { }

	// RVA: 0xEC2828 Offset: 0xEBE828 VA: 0xEC2828
	public void OpenTabContent(QuestTeamChat.TabIndex positionTab, bool soundeffect = True) { }

	// RVA: 0xEC30BC Offset: 0xEBF0BC VA: 0xEC30BC
	private void RotateImage() { }

	// RVA: 0xEC27C0 Offset: 0xEBE7C0 VA: 0xEC27C0
	public void SetActive(bool enabled) { }

	// RVA: 0xEC2CF0 Offset: 0xEBECF0 VA: 0xEC2CF0
	private void ChangeUI() { }

	// RVA: 0xEC3114 Offset: 0xEBF114 VA: 0xEC3114
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEC311C Offset: 0xEBF11C VA: 0xEC311C
	private void <Start>b__32_0() { }

	[CompilerGenerated]
	// RVA: 0xEC3128 Offset: 0xEBF128 VA: 0xEC3128
	private void <Start>b__32_1() { }

	[CompilerGenerated]
	// RVA: 0xEC3134 Offset: 0xEBF134 VA: 0xEC3134
	private void <Start>b__32_2(PointerEventData eventData) { }
}

// Namespace: 
private class RightHotkey.Item // TypeDefIndex: 2751
{
	// Fields
	public Item item; // 0x10
	public GameObject empty; // 0x18
	public GameObject background; // 0x20
	public TextMeshProUGUI label; // 0x28
	public Image icon; // 0x30
	public ButtonItem button; // 0x38

	// Methods

	// RVA: 0xEC3AAC Offset: 0xEBFAAC VA: 0xEC3AAC
	public void .ctor() { }
}

// Namespace: 
public static class RightHotkey.Skill.Direction.Definition // TypeDefIndex: 2752
{
	// Fields
	public const int unusedHotkeyIndex = 0;
	public const int attackHotkeyStart = 1;
	public const int attackHotkeyEnd = 10;
	public const int auraHotkeyIndex = 11;
	public const int jumpHotkeyIndex = 12;
}

// Namespace: 
public enum RightHotkey.Skill.Direction.Properties.DirFunc // TypeDefIndex: 2753
{
	// Fields
	public int value__; // 0x0
	public const RightHotkey.Skill.Direction.Properties.DirFunc liner = 0;
	public const RightHotkey.Skill.Direction.Properties.DirFunc position = 1;
	public const RightHotkey.Skill.Direction.Properties.DirFunc moving = 2;
}

// Namespace: 
public enum RightHotkey.Skill.Direction.Properties.Control // TypeDefIndex: 2754
{
	// Fields
	public int value__; // 0x0
	public const RightHotkey.Skill.Direction.Properties.Control touch = 0;
	public const RightHotkey.Skill.Direction.Properties.Control click = 1;
}

// Namespace: 
public enum RightHotkey.Skill.Direction.Properties.Target // TypeDefIndex: 2755
{
	// Fields
	public int value__; // 0x0
	public const RightHotkey.Skill.Direction.Properties.Target auto = 0;
	public const RightHotkey.Skill.Direction.Properties.Target semiAuto = 1;
	public const RightHotkey.Skill.Direction.Properties.Target none = 2;
}

// Namespace: 
public class RightHotkey.Skill.Direction.Properties // TypeDefIndex: 2756
{
	// Fields
	public int hotkeyId; // 0x10
	public int skillId; // 0x14
	public RightHotkey.Skill.Direction.Properties.DirFunc dirFunc; // 0x18
	public RightHotkey.Skill.Direction.Properties.Control control; // 0x1C
	public RightHotkey.Skill.Direction.Properties.Target target; // 0x20
	public int showDirImage; // 0x24

	// Methods

	// RVA: 0xEC6218 Offset: 0xEC2218 VA: 0xEC6218
	public void Parse(int data) { }

	// RVA: 0xEC6164 Offset: 0xEC2164 VA: 0xEC6164
	public int ToInteger() { }

	// RVA: 0xEC6320 Offset: 0xEC2320 VA: 0xEC6320
	public void .ctor() { }
}

// Namespace: 
public class RightHotkey.Skill.Direction // TypeDefIndex: 2757
{
	// Methods

	// RVA: 0xEC6210 Offset: 0xEC2210 VA: 0xEC6210
	public void .ctor() { }
}

// Namespace: 
public class RightHotkey.Skill.Data // TypeDefIndex: 2758
{
	// Fields
	public int areaPage; // 0x10
	public bool allowToHide; // 0x14
	public GameObject gameObject; // 0x18
	public Image icon; // 0x20
	public ButtonSkill button; // 0x28
	public RightHotkey.Skill.Direction.Properties directionProperties; // 0x30

	// Methods

	// RVA: 0xEC4CA0 Offset: 0xEC0CA0 VA: 0xEC4CA0
	public void Clear() { }

	// RVA: 0xEC3ABC Offset: 0xEBFABC VA: 0xEC3ABC
	public void .ctor() { }
}

// Namespace: 
public class RightHotkey.Skill // TypeDefIndex: 2759
{
	// Fields
	public int currentpage; // 0x10
	public Dictionary<int, RightHotkey.Skill.Data> assignment; // 0x18

	// Methods

	// RVA: 0xEC3AB4 Offset: 0xEBFAB4 VA: 0xEC3AB4
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class RightHotkey.<>c // TypeDefIndex: 2760
{
	// Fields
	public static readonly RightHotkey.<>c <>9; // 0x0
	public static UnityAction <>9__75_0; // 0x8
	public static UnityAction <>9__75_1; // 0x10
	public static UnityAction <>9__75_2; // 0x18

	// Methods

	// RVA: 0xEC6328 Offset: 0xEC2328 VA: 0xEC6328
	private static void .cctor() { }

	// RVA: 0xEC6390 Offset: 0xEC2390 VA: 0xEC6390
	public void .ctor() { }

	// RVA: 0xEC6398 Offset: 0xEC2398 VA: 0xEC6398
	internal void <Start>b__75_0() { }

	// RVA: 0xEC6438 Offset: 0xEC2438 VA: 0xEC6438
	internal void <Start>b__75_1() { }

	// RVA: 0xEC6500 Offset: 0xEC2500 VA: 0xEC6500
	internal void <Start>b__75_2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RightHotkey.<>c__DisplayClass81_0 // TypeDefIndex: 2761
{
	// Fields
	public int fieldData; // 0x10
	public RightHotkey <>4__this; // 0x18
	public bool resetPingPosition; // 0x20

	// Methods

	// RVA: 0xEC49C8 Offset: 0xEC09C8 VA: 0xEC49C8
	public void .ctor() { }

	// RVA: 0xEC65BC Offset: 0xEC25BC VA: 0xEC65BC
	internal void <SkillOnSyncField>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RightHotkey.<>c__DisplayClass82_0 // TypeDefIndex: 2762
{
	// Fields
	public RightHotkey <>4__this; // 0x10
	public HotkeySkillList message; // 0x18

	// Methods

	// RVA: 0xEC4AA4 Offset: 0xEC0AA4 VA: 0xEC4AA4
	public void .ctor() { }

	// RVA: 0xEC6B60 Offset: 0xEC2B60 VA: 0xEC6B60
	internal void <SkillOnSyncList>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RightHotkey.<>c__DisplayClass86_0 // TypeDefIndex: 2763
{
	// Fields
	public Item item; // 0x10

	// Methods

	// RVA: 0xEC53A0 Offset: 0xEC13A0 VA: 0xEC53A0
	public void .ctor() { }

	// RVA: 0xEC6EFC Offset: 0xEC2EFC VA: 0xEC6EFC
	internal void <ItemSetup>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class RightHotkey.<>c__DisplayClass92_0 // TypeDefIndex: 2764
{
	// Fields
	public RightHotkey <>4__this; // 0x10
	public int fightstate; // 0x18

	// Methods

	// RVA: 0xEC5C28 Offset: 0xEC1C28 VA: 0xEC5C28
	public void .ctor() { }

	// RVA: 0xEC6F68 Offset: 0xEC2F68 VA: 0xEC6F68
	internal void <SetFightState>b__0() { }
}

// Namespace: game.ui
public class RightHotkey : MonoBehaviour // TypeDefIndex: 2765
{
	// Fields
	[SerializeField]
	public RectTransform groupItem; // 0x20
	[SerializeField]
	public RectTransform groupPopup; // 0x28
	[SerializeField]
	public RectTransform groupNotify; // 0x30
	[SerializeField]
	public RectTransform groupPresent; // 0x38
	[SerializeField]
	public RectTransform groupSkill; // 0x40
	[SerializeField]
	private GameObject item1Empty; // 0x48
	[SerializeField]
	private GameObject item1Background; // 0x50
	[SerializeField]
	private TextMeshProUGUI item1Label; // 0x58
	[SerializeField]
	private Image item1Icon; // 0x60
	[SerializeField]
	public ButtonItem item1Button; // 0x68
	[SerializeField]
	private GameObject item2Empty; // 0x70
	[SerializeField]
	private GameObject item2Background; // 0x78
	[SerializeField]
	private TextMeshProUGUI item2Label; // 0x80
	[SerializeField]
	private Image item2Icon; // 0x88
	[SerializeField]
	public ButtonItem item2Button; // 0x90
	[SerializeField]
	private GameObject item3Empty; // 0x98
	[SerializeField]
	private GameObject item3Background; // 0xA0
	[SerializeField]
	private TextMeshProUGUI item3Label; // 0xA8
	[SerializeField]
	private Image item3Icon; // 0xB0
	[SerializeField]
	public ButtonItem item3Button; // 0xB8
	[SerializeField]
	public Button itemHorseButton; // 0xC0
	[SerializeField]
	public Button popupSwitchButton; // 0xC8
	[SerializeField]
	public Button popupBagarateButton; // 0xD0
	[SerializeField]
	public ButtonPkStatus popupPkStatusButton; // 0xD8
	[SerializeField]
	public Button popupEquipmentButton; // 0xE0
	[SerializeField]
	public Button popupSettingButton; // 0xE8
	[SerializeField]
	public BUttonNotifyAttention notifyAttentionButton; // 0xF0
	[SerializeField]
	public PingFps ping; // 0xF8
	[SerializeField]
	public Button presentSwitchButton; // 0x100
	[SerializeField]
	public ButtonAutoplay presentAutoButton; // 0x108
	[SerializeField]
	public Button presentPickupButton; // 0x110
	[SerializeField]
	private GameObject skill1Gameobject; // 0x118
	[SerializeField]
	private Image skill1Icon; // 0x120
	[SerializeField]
	public ButtonSkill skill1Button; // 0x128
	[SerializeField]
	private GameObject skill2Gameobject; // 0x130
	[SerializeField]
	private Image skill2Icon; // 0x138
	[SerializeField]
	public ButtonSkill skill2Button; // 0x140
	[SerializeField]
	private GameObject skill3Gameobject; // 0x148
	[SerializeField]
	private Image skill3Icon; // 0x150
	[SerializeField]
	public ButtonSkill skill3Button; // 0x158
	[SerializeField]
	private GameObject skill4Gameobject; // 0x160
	[SerializeField]
	private Image skill4Icon; // 0x168
	[SerializeField]
	public ButtonSkill skill4Button; // 0x170
	[SerializeField]
	private GameObject skill5Gameobject; // 0x178
	[SerializeField]
	private Image skill5Icon; // 0x180
	[SerializeField]
	public ButtonSkill skill5Button; // 0x188
	[SerializeField]
	private GameObject skill6Gameobject; // 0x190
	[SerializeField]
	private Image skill6Icon; // 0x198
	[SerializeField]
	public ButtonSkill skill6Button; // 0x1A0
	[SerializeField]
	private GameObject skill7Gameobject; // 0x1A8
	[SerializeField]
	private Image skill7Icon; // 0x1B0
	[SerializeField]
	public ButtonSkill skill7Button; // 0x1B8
	[SerializeField]
	private GameObject skill8Gameobject; // 0x1C0
	[SerializeField]
	private Image skill8Icon; // 0x1C8
	[SerializeField]
	public ButtonSkill skill8Button; // 0x1D0
	[SerializeField]
	private GameObject skill9Gameobject; // 0x1D8
	[SerializeField]
	private Image skill9Icon; // 0x1E0
	[SerializeField]
	public ButtonSkill skill9Button; // 0x1E8
	[SerializeField]
	private GameObject skill10Gameobject; // 0x1F0
	[SerializeField]
	private Image skill10Icon; // 0x1F8
	[SerializeField]
	public ButtonSkill skill10Button; // 0x200
	[SerializeField]
	private GameObject skillJumGameobject; // 0x208
	[SerializeField]
	private Image skillJumIcon; // 0x210
	[SerializeField]
	public ButtonSkill skillJumButton; // 0x218
	[SerializeField]
	private GameObject skillAuraGameobject; // 0x220
	[SerializeField]
	private Image skillAuraIcon; // 0x228
	[SerializeField]
	public ButtonSkill skillAuraButton; // 0x230
	private Dictionary<int, RightHotkey.Item> items; // 0x238
	private RightHotkey.Skill skills; // 0x240
	public int fightState; // 0x248
	private Queue<Action> onStartActions; // 0x250
	private bool isStarted; // 0x258

	// Methods

	// RVA: 0xEC3278 Offset: 0xEBF278 VA: 0xEC3278
	private void Awake() { }

	// RVA: 0xEC3DE0 Offset: 0xEBFDE0 VA: 0xEC3DE0
	private void Start() { }

	// RVA: 0xEC421C Offset: 0xEC021C VA: 0xEC421C
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xEC4354 Offset: 0xEC0354 VA: 0xEC4354
	private void Perform(Action action) { }

	// RVA: 0xEC3AC4 Offset: 0xEBFAC4 VA: 0xEC3AC4
	private void OnClickPresentSwitch() { }

	// RVA: 0xEC4428 Offset: 0xEC0428 VA: 0xEC4428
	private void OnClickPopupSwitch() { }

	// RVA: 0xEC4784 Offset: 0xEC0784 VA: 0xEC4784
	public bool SkillHasUsed(int skillId) { }

	// RVA: 0xEC48EC Offset: 0xEC08EC VA: 0xEC48EC
	public void SkillOnSyncField(int fieldData, bool resetPingPosition = True) { }

	// RVA: 0xEC49D0 Offset: 0xEC09D0 VA: 0xEC49D0
	public void SkillOnSyncList(HotkeySkillList message) { }

	// RVA: 0xEC4AAC Offset: 0xEC0AAC VA: 0xEC4AAC
	public void SkillRemoveSkillId(int skillid) { }

	// RVA: 0xEC4D14 Offset: 0xEC0D14 VA: 0xEC4D14
	public void SkillDisplayButtonBySkillExisting() { }

	// RVA: 0xEC4EDC Offset: 0xEC0EDC VA: 0xEC4EDC
	public void SkillClear() { }

	// RVA: 0xEC5020 Offset: 0xEC1020 VA: 0xEC5020
	private void ItemSetup(RightHotkey.Item hotkey, Item item) { }

	// RVA: 0xEC53A8 Offset: 0xEC13A8 VA: 0xEC53A8
	public void ItemOnRemove(int itemindex) { }

	// RVA: 0xEC5580 Offset: 0xEC1580 VA: 0xEC5580
	public void ItemOnSync(Item item) { }

	// RVA: 0xEC58C8 Offset: 0xEC18C8 VA: 0xEC58C8
	public void ItemSyncList(HotkeyItemList message) { }

	// RVA: 0xEC5A2C Offset: 0xEC1A2C VA: 0xEC5A2C
	public void ItemClear() { }

	// RVA: 0xEC4618 Offset: 0xEC0618 VA: 0xEC4618
	public void ResetPingPosition() { }

	// RVA: 0xEC5B60 Offset: 0xEC1B60 VA: 0xEC5B60
	public void SetFightState(int fightstate) { }

	// RVA: 0xEC5C30 Offset: 0xEC1C30 VA: 0xEC5C30
	public void SwitchForFigting(bool isFighting) { }

	// RVA: 0xEC5DD8 Offset: 0xEC1DD8 VA: 0xEC5DD8
	public void SetupPosition() { }

	// RVA: 0xEC5EE8 Offset: 0xEC1EE8 VA: 0xEC5EE8
	public void SetPk(int pk) { }

	// RVA: 0xEC5F00 Offset: 0xEC1F00 VA: 0xEC5F00
	public void ResetWeaponType() { }

	// RVA: 0xEC6198 Offset: 0xEC2198 VA: 0xEC6198
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEC61A0 Offset: 0xEC21A0 VA: 0xEC61A0
	private void <Start>b__75_3() { }
}

// Namespace: 
private class TongPc.OtherTongField // TypeDefIndex: 2766
{
	// Fields
	public GameObject go; // 0x10
	public TextMeshProUGUI tmp; // 0x18
	public Button button; // 0x20
	public GameObject activeBackground; // 0x28
	public int tongid; // 0x30
	public string tongname; // 0x38
	public bool hasRequested; // 0x40

	// Methods

	// RVA: 0xEC7D44 Offset: 0xEC3D44 VA: 0xEC7D44
	public void .ctor(GameObject go) { }

	// RVA: 0xECA568 Offset: 0xEC6568 VA: 0xECA568
	public TongPc.OtherTongField Clone(GameObject parent) { }
}

// Namespace: 
private class TongPc.MemberField // TypeDefIndex: 2767
{
	// Fields
	public GameObject go; // 0x10
	public TextMeshProUGUI rankTmp; // 0x18
	public TextMeshProUGUI nameTmp; // 0x20
	public TextMeshProUGUI posTmp; // 0x28
	public Button button; // 0x30
	public GameObject activeBackground; // 0x38
	public string cid; // 0x40
	public int rank; // 0x48
	public string name; // 0x50
	public string figure; // 0x58
	public string color; // 0x60

	// Methods

	// RVA: 0xEC7EE0 Offset: 0xEC3EE0 VA: 0xEC7EE0
	public void .ctor(GameObject go) { }

	// RVA: 0xECA640 Offset: 0xEC6640 VA: 0xECA640
	public TongPc.MemberField Clone(GameObject parent) { }

	// RVA: 0xECA718 Offset: 0xEC6718 VA: 0xECA718
	public void SetString(int rank, string name, string pos, string color) { }
}

// Namespace: 
private class TongPc.RequestingField // TypeDefIndex: 2768
{
	// Fields
	public GameObject go; // 0x10
	public TextMeshProUGUI nameTmp; // 0x18
	public TextMeshProUGUI levelTmp; // 0x20
	public TextMeshProUGUI facTmp; // 0x28
	public Button infoButton; // 0x30
	public Button okButton; // 0x38
	public Button koButton; // 0x40

	// Methods

	// RVA: 0xEC815C Offset: 0xEC415C VA: 0xEC815C
	public void .ctor(GameObject go) { }

	// RVA: 0xEC9450 Offset: 0xEC5450 VA: 0xEC9450
	public TongPc.RequestingField Clone(GameObject parent) { }

	// RVA: 0xEC9528 Offset: 0xEC5528 VA: 0xEC9528
	public void SetString(string name, int level, string fac) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TongPc.<>c // TypeDefIndex: 2769
{
	// Fields
	public static readonly TongPc.<>c <>9; // 0x0
	public static UnityAction <>9__53_3; // 0x8
	public static UnityAction <>9__53_4; // 0x10
	public static UnityAction <>9__53_5; // 0x18
	public static UnityAction <>9__53_6; // 0x20
	public static UnityAction <>9__53_7; // 0x28
	public static UnityAction <>9__53_15; // 0x30

	// Methods

	// RVA: 0xECA9E0 Offset: 0xEC69E0 VA: 0xECA9E0
	private static void .cctor() { }

	// RVA: 0xECAA48 Offset: 0xEC6A48 VA: 0xECAA48
	public void .ctor() { }

	// RVA: 0xECAA50 Offset: 0xEC6A50 VA: 0xECAA50
	internal void <Start>b__53_3() { }

	// RVA: 0xECAAE4 Offset: 0xEC6AE4 VA: 0xECAAE4
	internal void <Start>b__53_4() { }

	// RVA: 0xECAB78 Offset: 0xEC6B78 VA: 0xECAB78
	internal void <Start>b__53_5() { }

	// RVA: 0xECAC0C Offset: 0xEC6C0C VA: 0xECAC0C
	internal void <Start>b__53_6() { }

	// RVA: 0xECACD0 Offset: 0xEC6CD0 VA: 0xECACD0
	internal void <Start>b__53_7() { }

	// RVA: 0xECAD64 Offset: 0xEC6D64 VA: 0xECAD64
	internal void <Start>b__53_15() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TongPc.<>c__DisplayClass58_0 // TypeDefIndex: 2770
{
	// Fields
	public TextMeshProUGUI tmp; // 0x10
	public string text; // 0x18

	// Methods

	// RVA: 0xEC85FC Offset: 0xEC45FC VA: 0xEC85FC
	public void .ctor() { }

	// RVA: 0xECAE28 Offset: 0xEC6E28 VA: 0xECAE28
	internal void <SetInfoTmp>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TongPc.<>c__DisplayClass67_0 // TypeDefIndex: 2771
{
	// Fields
	public TongRequestField message; // 0x10
	public TongPc <>4__this; // 0x18
	public TongPc.RequestingField field; // 0x20

	// Methods

	// RVA: 0xEC9448 Offset: 0xEC5448 VA: 0xEC9448
	public void .ctor() { }

	// RVA: 0xECAEB4 Offset: 0xEC6EB4 VA: 0xECAEB4
	internal void <ProtocolTongRequestField>b__0() { }

	// RVA: 0xECAFA0 Offset: 0xEC6FA0 VA: 0xECAFA0
	internal void <ProtocolTongRequestField>b__1() { }

	// RVA: 0xECB0F8 Offset: 0xEC70F8 VA: 0xECB0F8
	internal void <ProtocolTongRequestField>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TongPc.<>c__DisplayClass68_0 // TypeDefIndex: 2772
{
	// Fields
	public TongPc <>4__this; // 0x10
	public TongMember message; // 0x18

	// Methods

	// RVA: 0xEC976C Offset: 0xEC576C VA: 0xEC976C
	public void .ctor() { }

	// RVA: 0xECB250 Offset: 0xEC7250 VA: 0xECB250
	internal void <ProtocolTongMember>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TongPc.<>c__DisplayClass68_1 // TypeDefIndex: 2773
{
	// Fields
	public TongPc.MemberField memfield; // 0x10
	public TongPc.<>c__DisplayClass68_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xECB4C0 Offset: 0xEC74C0 VA: 0xECB4C0
	public void .ctor() { }

	// RVA: 0xECB4C8 Offset: 0xEC74C8 VA: 0xECB4C8
	internal void <ProtocolTongMember>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TongPc.<>c__DisplayClass71_0 // TypeDefIndex: 2774
{
	// Fields
	public TongPc <>4__this; // 0x10
	public TongTongField message; // 0x18

	// Methods

	// RVA: 0xEC9A24 Offset: 0xEC5A24 VA: 0xEC9A24
	public void .ctor() { }

	// RVA: 0xECB5B0 Offset: 0xEC75B0 VA: 0xECB5B0
	internal void <ProtocolTongTongField>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TongPc.<>c__DisplayClass71_1 // TypeDefIndex: 2775
{
	// Fields
	public TongPc.OtherTongField field; // 0x10
	public TongPc.<>c__DisplayClass71_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xECB7EC Offset: 0xEC77EC VA: 0xECB7EC
	public void .ctor() { }

	// RVA: 0xECB7F4 Offset: 0xEC77F4 VA: 0xECB7F4
	internal void <ProtocolTongTongField>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TongPc.<>c__DisplayClass71_2 // TypeDefIndex: 2776
{
	// Fields
	public TongPc.MemberField memfield; // 0x10
	public TongPc.<>c__DisplayClass71_1 CS$<>8__locals2; // 0x18

	// Methods

	// RVA: 0xECC228 Offset: 0xEC8228 VA: 0xECC228
	public void .ctor() { }

	// RVA: 0xECC238 Offset: 0xEC8238 VA: 0xECC238
	internal void <ProtocolTongTongField>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TongPc.<>c__DisplayClass71_3 // TypeDefIndex: 2777
{
	// Fields
	public TongPc.MemberField directorField; // 0x10
	public TongPc.<>c__DisplayClass71_2 CS$<>8__locals3; // 0x18

	// Methods

	// RVA: 0xECC230 Offset: 0xEC8230 VA: 0xECC230
	public void .ctor() { }

	// RVA: 0xECC318 Offset: 0xEC8318 VA: 0xECC318
	internal void <ProtocolTongTongField>b__3() { }
}

// Namespace: game.ui
public class TongPc : MonoBehaviour // TypeDefIndex: 2778
{
	// Fields
	[SerializeField]
	private List<Image> imageList; // 0x20
	[SerializeField]
	private List<TextMeshProUGUI> tmpList; // 0x28
	[SerializeField]
	private RectTransform prefabRect; // 0x30
	[SerializeField]
	private RectTransform framedRect; // 0x38
	[SerializeField]
	private GameObject otherTongGo; // 0x40
	[SerializeField]
	private Button otherTongClose; // 0x48
	[SerializeField]
	private GameObject otherTongFieldTemplateGo; // 0x50
	[SerializeField]
	private GameObject otherTongFieldContent; // 0x58
	[SerializeField]
	private GameObject memberTemplateGo; // 0x60
	[SerializeField]
	private GameObject memberContentGo; // 0x68
	[SerializeField]
	private Button menuTinTuc; // 0x70
	[SerializeField]
	private Button menuChieuMo; // 0x78
	[SerializeField]
	private Button menuChucNang; // 0x80
	[SerializeField]
	private Button menuJoinTong; // 0x88
	[SerializeField]
	private Button menuOtherTong; // 0x90
	[SerializeField]
	private Button menuCloseButton; // 0x98
	[SerializeField]
	private GameObject infoGo; // 0xA0
	[SerializeField]
	private TextMeshProUGUI infoTongNameTmp; // 0xA8
	[SerializeField]
	private TextMeshProUGUI infoTongMasterTmp; // 0xB0
	[SerializeField]
	private TextMeshProUGUI infoCampTmp; // 0xB8
	[SerializeField]
	private TextMeshProUGUI infoLevelTmp; // 0xC0
	[SerializeField]
	private TextMeshProUGUI infoMemberTmp; // 0xC8
	[SerializeField]
	private TextMeshProUGUI infoNganQuyTmp; // 0xD0
	[SerializeField]
	private GameObject requestingGo; // 0xD8
	[SerializeField]
	private TextMeshProUGUI requestingNoteTmp; // 0xE0
	[SerializeField]
	private Button requestingNoteEditButton; // 0xE8
	[SerializeField]
	private GameObject requestingContentGo; // 0xF0
	[SerializeField]
	private GameObject requestingFieldTemplateGo; // 0xF8
	[SerializeField]
	private GameObject funcsGo; // 0x100
	[SerializeField]
	private TextMeshProUGUI funcsTongNganquyTmp; // 0x108
	[SerializeField]
	private Button funcsTongNganquyRutButton; // 0x110
	[SerializeField]
	private Button funcsTongNganquyPhatButton; // 0x118
	[SerializeField]
	private Button funcsSelfNganquyGuiButton; // 0x120
	[SerializeField]
	private TextMeshProUGUI funcsSelfNganquyTmp; // 0x128
	[SerializeField]
	private Button funcsTongBangHoiButton; // 0x130
	[SerializeField]
	private Button funcsTongPhePhaiButton; // 0x138
	[SerializeField]
	private Button funcsTongTrangBiButton; // 0x140
	[SerializeField]
	private Button funcsTongDoiTenButton; // 0x148
	[SerializeField]
	private Button funcsTongChucVuButton; // 0x150
	[SerializeField]
	private Button funcsTongKickKhoiBangButton; // 0x158
	[SerializeField]
	private Button funcsSelfRoiBangButton; // 0x160
	private float scaleRatio; // 0x168
	private Queue<Action> onStartActions; // 0x170
	private bool isStarted; // 0x178
	private TongPc.OtherTongField otherTongFieldTemplate; // 0x180
	private List<TongPc.OtherTongField> otherTongListing; // 0x188
	private TongPc.OtherTongField otherTongLastFieldSelected; // 0x190
	private TongPc.MemberField memberFieldTemplate; // 0x198
	private List<TongPc.MemberField> memberListing; // 0x1A0
	private TongPc.MemberField memberLastFieldSelected; // 0x1A8
	private TongPc.RequestingField requestingFieldTemplate; // 0x1B0
	private List<TongPc.RequestingField> requestingListing; // 0x1B8
	private bool hasRequestMemberRequestingList; // 0x1C0

	// Methods

	// RVA: 0xEC70F0 Offset: 0xEC30F0 VA: 0xEC70F0
	private void Start() { }

	// RVA: 0xEC844C Offset: 0xEC444C VA: 0xEC844C
	private void Perform(Action action) { }

	// RVA: 0xEC851C Offset: 0xEC451C VA: 0xEC851C
	private void SetInfoTmp(TextMeshProUGUI tmp, string text) { }

	// RVA: 0xEC8604 Offset: 0xEC4604 VA: 0xEC8604
	private void ClearMemberListing() { }

	// RVA: 0xEC87C0 Offset: 0xEC47C0 VA: 0xEC87C0
	private void ClearOtherTongListing() { }

	// RVA: 0xEC897C Offset: 0xEC497C VA: 0xEC897C
	private void ClearRequestingListing() { }

	// RVA: 0xEC8B2C Offset: 0xEC4B2C VA: 0xEC8B2C
	public void Close() { }

	// RVA: 0xEC8BC8 Offset: 0xEC4BC8 VA: 0xEC8BC8
	public void Open() { }

	// RVA: 0xEC9044 Offset: 0xEC5044 VA: 0xEC9044
	public bool IsOpen() { }

	// RVA: 0xEC9064 Offset: 0xEC5064 VA: 0xEC9064
	public static string GetTongCampAsString(int camp) { }

	// RVA: 0xEC90E8 Offset: 0xEC50E8 VA: 0xEC90E8
	public static string GetTongFigure(int value) { }

	// RVA: 0xEC9178 Offset: 0xEC5178 VA: 0xEC9178
	public void ProtocolTongRequestField(TongRequestField message) { }

	// RVA: 0xEC966C Offset: 0xEC566C VA: 0xEC966C
	public void ProtocolTongMember(TongMember message) { }

	// RVA: 0xEC9774 Offset: 0xEC5774 VA: 0xEC9774
	public void ProtocolTongOverview(TongOverview message) { }

	// RVA: 0xEC98EC Offset: 0xEC58EC VA: 0xEC98EC
	public void ProtocolCloseTongUI() { }

	// RVA: 0xEC9924 Offset: 0xEC5924 VA: 0xEC9924
	public void ProtocolTongTongField(TongTongField message) { }

	// RVA: 0xEC9A2C Offset: 0xEC5A2C VA: 0xEC9A2C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEC9A34 Offset: 0xEC5A34 VA: 0xEC9A34
	private void <Start>b__53_0() { }

	[CompilerGenerated]
	// RVA: 0xEC9AD8 Offset: 0xEC5AD8 VA: 0xEC9AD8
	private void <Start>b__53_1() { }

	[CompilerGenerated]
	// RVA: 0xEC9C44 Offset: 0xEC5C44 VA: 0xEC9C44
	private void <Start>b__53_2() { }

	[CompilerGenerated]
	// RVA: 0xEC9CE8 Offset: 0xEC5CE8 VA: 0xEC9CE8
	private void <Start>b__53_8() { }

	[CompilerGenerated]
	// RVA: 0xEC9DE0 Offset: 0xEC5DE0 VA: 0xEC9DE0
	private void <Start>b__53_9() { }

	[CompilerGenerated]
	// RVA: 0xEC9ED8 Offset: 0xEC5ED8 VA: 0xEC9ED8
	private void <Start>b__53_10() { }

	[CompilerGenerated]
	// RVA: 0xEC9FD0 Offset: 0xEC5FD0 VA: 0xEC9FD0
	private void <Start>b__53_11() { }

	[CompilerGenerated]
	// RVA: 0xECA0C8 Offset: 0xEC60C8 VA: 0xECA0C8
	private void <Start>b__53_12() { }

	[CompilerGenerated]
	// RVA: 0xECA198 Offset: 0xEC6198 VA: 0xECA198
	private void <Start>b__53_13() { }

	[CompilerGenerated]
	// RVA: 0xECA38C Offset: 0xEC638C VA: 0xECA38C
	private void <Start>b__53_14() { }

	[CompilerGenerated]
	// RVA: 0xECA4E4 Offset: 0xEC64E4 VA: 0xECA4E4
	private void <Start>b__53_16() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TopHealth.<>c // TypeDefIndex: 2779
{
	// Fields
	public static readonly TopHealth.<>c <>9; // 0x0
	public static UnityAction <>9__17_0; // 0x8

	// Methods

	// RVA: 0xECCDFC Offset: 0xEC8DFC VA: 0xECCDFC
	private static void .cctor() { }

	// RVA: 0xECCE64 Offset: 0xEC8E64 VA: 0xECCE64
	public void .ctor() { }

	// RVA: 0xECCE6C Offset: 0xEC8E6C VA: 0xECCE6C
	internal void <Start>b__17_0() { }
}

// Namespace: game.ui
public class TopHealth : MonoBehaviour // TypeDefIndex: 2780
{
	// Fields
	[SerializeField]
	private TextMeshProUGUI levelLabel; // 0x20
	[SerializeField]
	private Slider healthSlider; // 0x28
	[SerializeField]
	private TextMeshProUGUI healthLabel; // 0x30
	[SerializeField]
	private Slider manaSlider; // 0x38
	[SerializeField]
	private TextMeshProUGUI manaLabel; // 0x40
	[SerializeField]
	private Slider staminaSlider; // 0x48
	[SerializeField]
	private TextMeshProUGUI staminaLabel; // 0x50
	[SerializeField]
	private Slider ExperienceSlider; // 0x58
	[SerializeField]
	private TextMeshProUGUI ExperienceLabel; // 0x60
	[SerializeField]
	private TextMeshProUGUI rankLabel; // 0x68
	[SerializeField]
	private Button rankButton; // 0x70
	[SerializeField]
	private Image healthManaStaminaFramed; // 0x78
	[SerializeField]
	private Image healthFillImage; // 0x80
	[SerializeField]
	private Image manaFillImage; // 0x88
	[SerializeField]
	private Image staminaFillImage; // 0x90
	[SerializeField]
	private Image ExperienceFillImage; // 0x98
	[SerializeField]
	private Button equipPropertiesButton; // 0xA0
	public static int previousLevelValue; // 0x0
	private static long previousLevelExp; // 0x8

	// Methods

	// RVA: 0xECC408 Offset: 0xEC8408 VA: 0xECC408
	private void Start() { }

	// RVA: 0xECC638 Offset: 0xEC8638 VA: 0xECC638
	public void SetLevel(int level) { }

	// RVA: 0xECC724 Offset: 0xEC8724 VA: 0xECC724
	public void SetStanima(int current, int max) { }

	// RVA: 0xECC858 Offset: 0xEC8858 VA: 0xECC858
	public void SetHealth(int current, int max) { }

	// RVA: 0xECC98C Offset: 0xEC898C VA: 0xECC98C
	public void SetMana(int current, int max) { }

	// RVA: 0xECCAC0 Offset: 0xEC8AC0 VA: 0xECCAC0
	public void SetExp(long current, int level) { }

	// RVA: 0xECCCE4 Offset: 0xEC8CE4 VA: 0xECCCE4
	public void SetRank(int rank) { }

	// RVA: 0xECCDF4 Offset: 0xEC8DF4 VA: 0xECCDF4
	public void .ctor() { }
}

// Namespace: 
public class UiContextDescription.FuncTemplate // TypeDefIndex: 2781
{
	// Fields
	public GameObject goCurrent; // 0x10
	public Button button; // 0x18
	public GameObject goLabel; // 0x20
	public TextMeshProUGUI tmproLabel; // 0x28

	// Methods

	// RVA: 0xECD050 Offset: 0xEC9050 VA: 0xECD050
	public void .ctor(GameObject go) { }

	// RVA: 0xECF8B8 Offset: 0xECB8B8 VA: 0xECF8B8
	public UiContextDescription.FuncTemplate Clone() { }
}

// Namespace: 
public class UiContextDescription.ContentPage.ContentObject // TypeDefIndex: 2782
{
	// Fields
	public GameObject go; // 0x10
	public TextMeshProUGUI tmpui; // 0x18

	// Methods

	// RVA: 0xECF97C Offset: 0xECB97C VA: 0xECF97C
	public void .ctor(GameObject go) { }
}

// Namespace: 
public class UiContextDescription.ContentPage.MagicItemImageObject // TypeDefIndex: 2783
{
	// Fields
	public GameObject go; // 0x10
	public Image image; // 0x18
	public TextMeshProUGUI tmpui; // 0x20

	// Methods

	// RVA: 0xECF9FC Offset: 0xECB9FC VA: 0xECF9FC
	public void .ctor(GameObject go) { }
}

// Namespace: 
public class UiContextDescription.ContentPage // TypeDefIndex: 2784
{
	// Fields
	public GameObject go; // 0x10
	public GameObject line; // 0x18
	public ScrollRect scrollRect; // 0x20
	public RectTransform viewportRect; // 0x28
	public GameObject contentGo; // 0x30
	public GameObject textTemplate; // 0x38
	public GameObject magicitemTemplate; // 0x40
	public List<UiContextDescription.ContentPage.ContentObject> contentObjects; // 0x48
	public List<UiContextDescription.ContentPage.MagicItemImageObject> magicItemImageObjects; // 0x50

	// Methods

	// RVA: 0xECE520 Offset: 0xECA520 VA: 0xECE520
	public void .ctor(GameObject go, GameObject line) { }

	// RVA: 0xECF294 Offset: 0xECB294 VA: 0xECF294
	public void AppendText(string text) { }

	// RVA: 0xECEB14 Offset: 0xECAB14 VA: 0xECEB14
	public void AppendItemMagic(int particular, bool displayParticular, bool displayName, string describe) { }

	// RVA: 0xECEED4 Offset: 0xECAED4 VA: 0xECEED4
	public void AppendItemGold(int goldindex, bool displayGoldIndex, bool displayName, string describe) { }

	// RVA: 0xECE81C Offset: 0xECA81C VA: 0xECE81C
	public void ClearContent() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UiContextDescription.<>c__DisplayClass27_0 // TypeDefIndex: 2785
{
	// Fields
	public UiContextDescription <>4__this; // 0x10
	public ContextDescription contextDescription; // 0x18
	public UnityAction <>9__1; // 0x20

	// Methods

	// RVA: 0xECF7A8 Offset: 0xECB7A8 VA: 0xECF7A8
	public void .ctor() { }

	// RVA: 0xECFB0C Offset: 0xECBB0C VA: 0xECFB0C
	internal void <Open>b__0() { }

	// RVA: 0xED01B0 Offset: 0xECC1B0 VA: 0xED01B0
	internal void <Open>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class UiContextDescription.<>c__DisplayClass27_1 // TypeDefIndex: 2786
{
	// Fields
	public int _indexCoppied; // 0x10
	public UiContextDescription.<>c__DisplayClass27_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xED01A8 Offset: 0xECC1A8 VA: 0xED01A8
	public void .ctor() { }

	// RVA: 0xED022C Offset: 0xECC22C VA: 0xED022C
	internal void <Open>b__2() { }
}

// Namespace: game.ui
public class UiContextDescription : MonoBehaviour // TypeDefIndex: 2787
{
	// Fields
	[SerializeField]
	private Image imageBackground; // 0x20
	[SerializeField]
	private RectTransform titleRect; // 0x28
	[SerializeField]
	private TextMeshProUGUI titleText; // 0x30
	[SerializeField]
	private GameObject goFuncTemplate; // 0x38
	[SerializeField]
	private GameObject goFuncList; // 0x40
	[SerializeField]
	private float fadeTimeSeconds; // 0x48
	[SerializeField]
	private float fadeAlphaMaximum; // 0x4C
	[SerializeField]
	private RectTransform rectBackground; // 0x50
	[SerializeField]
	private RectTransform rectFramed; // 0x58
	[SerializeField]
	private RectTransform rectViewport; // 0x60
	[SerializeField]
	private RectTransform rectContentPage; // 0x68
	[SerializeField]
	private GameObject scrollviewTemplate; // 0x70
	[SerializeField]
	private GameObject pagelineTemplate; // 0x78
	private Color fadeColorStart; // 0x80
	private Color fadeColorEnd; // 0x90
	private float fadeColorCurrentTime; // 0xA0
	private UiContextDescription.FuncTemplate funcTemplate; // 0xA8
	private readonly Queue<Action> onstartedQueue; // 0xB0
	private readonly List<UiContextDescription.ContentPage> contentPages; // 0xB8
	private float previousViewportRectOffsetMaxY; // 0xC0

	// Methods

	// RVA: 0xECCF34 Offset: 0xEC8F34 VA: 0xECCF34
	private void Start() { }

	// RVA: 0xECD208 Offset: 0xEC9208 VA: 0xECD208
	private void Update() { }

	// RVA: 0xECD2A0 Offset: 0xEC92A0 VA: 0xECD2A0
	private void SetTitle(string title) { }

	// RVA: 0xECD408 Offset: 0xEC9408 VA: 0xECD408
	private void SetContent(RepeatedField<string> pages, bool titleIsEmpty) { }

	// RVA: 0xECF494 Offset: 0xECB494 VA: 0xECF494
	public void Close() { }

	// RVA: 0xECF618 Offset: 0xECB618 VA: 0xECF618
	public void Open(ContextDescription contextDescription) { }

	// RVA: 0xECF7B0 Offset: 0xECB7B0 VA: 0xECF7B0
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MiniMapZoomPC.<>c // TypeDefIndex: 2788
{
	// Fields
	public static readonly MiniMapZoomPC.<>c <>9; // 0x0
	public static Action <>9__62_0; // 0x8
	public static Action<bool> <>9__74_0; // 0x10

	// Methods

	// RVA: 0xED3644 Offset: 0xECF644 VA: 0xED3644
	private static void .cctor() { }

	// RVA: 0xED36AC Offset: 0xECF6AC VA: 0xED36AC
	public void .ctor() { }

	// RVA: 0xED36B4 Offset: 0xECF6B4 VA: 0xED36B4
	internal void <PinPositionStart>b__62_0() { }

	// RVA: 0xED3720 Offset: 0xECF720 VA: 0xED3720
	internal void <AddObject>b__74_0(bool _enabled) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MiniMapZoomPC.<>c__DisplayClass62_0 // TypeDefIndex: 2789
{
	// Fields
	public MiniMapZoomPC <>4__this; // 0x10
	public int left; // 0x18
	public int top; // 0x1C

	// Methods

	// RVA: 0xED3724 Offset: 0xECF724 VA: 0xED3724
	public void .ctor() { }

	// RVA: 0xED372C Offset: 0xECF72C VA: 0xED372C
	internal void <PinPositionStart>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MiniMapZoomPC.<>c__DisplayClass63_0 // TypeDefIndex: 2790
{
	// Fields
	public MiniMapZoomPC <>4__this; // 0x10
	public int xx; // 0x18
	public int yy; // 0x1C

	// Methods

	// RVA: 0xED3A64 Offset: 0xECFA64 VA: 0xED3A64
	public void .ctor() { }

	// RVA: 0xED3A6C Offset: 0xECFA6C VA: 0xED3A6C
	internal void <PinPositionInput>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MiniMapZoomPC.<>c__DisplayClass68_0 // TypeDefIndex: 2791
{
	// Fields
	public MiniMapZoomPC <>4__this; // 0x10
	public MapList.MapInfo mapinfo; // 0x18
	public Sprite sprite; // 0x20

	// Methods

	// RVA: 0xED3C6C Offset: 0xECFC6C VA: 0xED3C6C
	public void .ctor() { }

	// RVA: 0xED3C74 Offset: 0xECFC74 VA: 0xED3C74
	internal void <Open>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MiniMapZoomPC.<>c__DisplayClass69_0 // TypeDefIndex: 2792
{
	// Fields
	public MapDialogNpcListResponse response; // 0x10
	public MiniMapZoomPC <>4__this; // 0x18

	// Methods

	// RVA: 0xED3E80 Offset: 0xECFE80 VA: 0xED3E80
	public void .ctor() { }

	// RVA: 0xED3E88 Offset: 0xECFE88 VA: 0xED3E88
	internal void <SetUpDialogNpcList>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MiniMapZoomPC.<>c__DisplayClass71_0 // TypeDefIndex: 2793
{
	// Fields
	public MapDialogNpc npcEntry; // 0x10

	// Methods

	// RVA: 0xED4878 Offset: 0xED0878 VA: 0xED4878
	public void .ctor() { }

	// RVA: 0xED4880 Offset: 0xED0880 VA: 0xED4880
	internal bool <ZoomToNpc>b__0(NpcInMap _npcInMap) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class MiniMapZoomPC.<>c__DisplayClass73_0 // TypeDefIndex: 2794
{
	// Fields
	public MiniMapZoomPC <>4__this; // 0x10
	public MapDialogNpc npcEntry; // 0x18

	// Methods

	// RVA: 0xED48EC Offset: 0xED08EC VA: 0xED48EC
	public void .ctor() { }

	// RVA: 0xED48F4 Offset: 0xED08F4 VA: 0xED48F4
	internal void <AddNpcButton>b__0() { }
}

// Namespace: game.ui
public class MiniMapZoomPC : MonoBehaviour // TypeDefIndex: 2795
{
	// Fields
	[SerializeField]
	private GameObject ListNpcFormMap; // 0x20
	[SerializeField]
	private GameObject ListNpcFormMapUI; // 0x28
	[SerializeField]
	private GameObject ButtonNpc; // 0x30
	[SerializeField]
	private GameObject BtnNpcActive; // 0x38
	[SerializeField]
	private GameObject ButtonGuild; // 0x40
	[SerializeField]
	private GameObject ToggeOnOffNpc; // 0x48
	[SerializeField]
	private GameObject Background; // 0x50
	[SerializeField]
	private GameObject MapImage; // 0x58
	[SerializeField]
	private Slider mapSlider; // 0x60
	[SerializeField]
	private GameObject viewPortmap; // 0x68
	[SerializeField]
	private NpcInMap npcInMap; // 0x70
	[SerializeField]
	public ScrollRect scrollRect; // 0x78
	[SerializeField]
	private Button compTongButton; // 0x80
	[SerializeField]
	private Button compSelfRevertMapButton; // 0x88
	[SerializeField]
	private Image topImage; // 0x90
	[SerializeField]
	private TextMeshProUGUI topTitle; // 0x98
	[SerializeField]
	private Button closeButton; // 0xA0
	[SerializeField]
	private Button closeArea; // 0xA8
	[SerializeField]
	private Image zoomHandleImage; // 0xB0
	[SerializeField]
	private Image buttonNpcImage; // 0xB8
	[SerializeField]
	private TextMeshProUGUI buttonNpcTmp; // 0xC0
	[SerializeField]
	private Image buttonNpcSwitchImage; // 0xC8
	[SerializeField]
	private TextMeshProUGUI buttonNpcSwitchEnableTmp; // 0xD0
	[SerializeField]
	private TextMeshProUGUI buttonNpcSwitchDisableTmp; // 0xD8
	[SerializeField]
	private Image buttonRevertMapImage; // 0xE0
	[SerializeField]
	private TextMeshProUGUI buttonRevertMapTmp; // 0xE8
	[SerializeField]
	private Image buttonTongImage; // 0xF0
	[SerializeField]
	private TextMeshProUGUI buttonTongTmp; // 0xF8
	[SerializeField]
	private Image buttonCloseImage; // 0x100
	[SerializeField]
	private TextMeshProUGUI buttonCloseTmp; // 0x108
	[SerializeField]
	private TextMeshProUGUI currentPositionTmp; // 0x110
	[SerializeField]
	private RectTransform pinIconRect; // 0x118
	[SerializeField]
	private RectTransform linerImageRect; // 0x120
	[SerializeField]
	private MinimapImageEvent minimapImageEvent; // 0x128
	[SerializeField]
	private Button positionButton; // 0x130
	private float initialFingersDistance; // 0x138
	private Vector3 initialScale; // 0x13C
	private float xRatio; // 0x148
	private float yRatio; // 0x14C
	private MapDialogNpcListResponse npcDialogList; // 0x150
	private List<NpcInMap> npcInMapListing; // 0x158
	private NpcInMap mainPlayerInMap; // 0x160
	private RectTransform mainplayerRect; // 0x168
	private MapList.MapInfo mapinfo; // 0x170
	private Sprite mapsprite; // 0x178
	private Image comMapImage; // 0x180
	private RectTransform viewportRectTransform; // 0x188
	private RectTransform mapImageRectTransform; // 0x190
	private bool startedState; // 0x198
	private Queue<Action> startedAction; // 0x1A0
	private Queue<Action> startedAction2; // 0x1A8
	private RectTransform pinPositionIconClone; // 0x1B0
	private RectTransform pinPositionLinerClone; // 0x1B8
	private long pinPositionNextUpdateTime; // 0x1C0
	public int findingPathDebugWidth; // 0x1C8
	public int findingPathDebugHeight; // 0x1CC

	// Methods

	// RVA: 0xED031C Offset: 0xECC31C VA: 0xED031C
	private void Start() { }

	// RVA: 0xED0B10 Offset: 0xECCB10 VA: 0xED0B10
	private void Update() { }

	// RVA: 0xED13D4 Offset: 0xECD3D4 VA: 0xED13D4
	private void Perform(Action action) { }

	// RVA: 0xED14A4 Offset: 0xECD4A4 VA: 0xED14A4
	private void Perform2(Action action) { }

	// RVA: 0xED1574 Offset: 0xECD574 VA: 0xED1574
	public MapDialogNpcListResponse GetNpcDialogList() { }

	// RVA: 0xED157C Offset: 0xECD57C VA: 0xED157C
	public void PinPositionStop() { }

	// RVA: 0xED1780 Offset: 0xECD780 VA: 0xED1780
	private void PinPositionStart(int left, int top) { }

	// RVA: 0xED19A0 Offset: 0xECD9A0 VA: 0xED19A0
	public void PinPositionInput(int xx, int yy) { }

	// RVA: 0xED0E4C Offset: 0xECCE4C VA: 0xED0E4C
	private void PinPositionUpdate() { }

	// RVA: 0xED1A80 Offset: 0xECDA80 VA: 0xED1A80
	private void ChangeShowNameNpc(bool isOn) { }

	// RVA: 0xED1BFC Offset: 0xECDBFC VA: 0xED1BFC
	public void Clear() { }

	// RVA: 0xED1DB0 Offset: 0xECDDB0 VA: 0xED1DB0
	public void Close() { }

	// RVA: 0xED1DD4 Offset: 0xECDDD4 VA: 0xED1DD4
	public void Open(MapList.MapInfo mapinfo, Sprite sprite) { }

	// RVA: 0xED1EE0 Offset: 0xECDEE0 VA: 0xED1EE0
	public void SetUpDialogNpcList(MapDialogNpcListResponse response) { }

	// RVA: 0xED1FD0 Offset: 0xECDFD0 VA: 0xED1FD0
	public void SetupMapImage(MapList.MapInfo newMapInfo) { }

	// RVA: 0xED2314 Offset: 0xECE314 VA: 0xED2314
	public void ZoomToNpc(MapDialogNpc npcEntry) { }

	// RVA: 0xED25CC Offset: 0xECE5CC VA: 0xED25CC
	public void ZoomToPlayer() { }

	// RVA: 0xED2710 Offset: 0xECE710 VA: 0xED2710
	public void AddNpcButton(MapDialogNpc npcEntry) { }

	// RVA: 0xED2884 Offset: 0xECE884 VA: 0xED2884
	public void AddObject(MapDialogNpc npcEntry) { }

	// RVA: 0xED2AAC Offset: 0xECEAAC VA: 0xED2AAC
	public void AddMainPlayer() { }

	// RVA: 0xED2CAC Offset: 0xECECAC VA: 0xED2CAC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xED2D3C Offset: 0xECED3C VA: 0xED2D3C
	private void <Start>b__54_0(PointerEventData _pointerData) { }

	[CompilerGenerated]
	// RVA: 0xED2F60 Offset: 0xECEF60 VA: 0xED2F60
	private void <Start>b__54_1() { }

	[CompilerGenerated]
	// RVA: 0xED3158 Offset: 0xECF158 VA: 0xED3158
	private void <Start>b__54_8(string _input) { }

	[CompilerGenerated]
	// RVA: 0xED32DC Offset: 0xECF2DC VA: 0xED32DC
	private void <Start>b__54_2() { }

	[CompilerGenerated]
	// RVA: 0xED334C Offset: 0xECF34C VA: 0xED334C
	private void <Start>b__54_3() { }

	[CompilerGenerated]
	// RVA: 0xED33BC Offset: 0xECF3BC VA: 0xED33BC
	private void <Start>b__54_4() { }

	[CompilerGenerated]
	// RVA: 0xED344C Offset: 0xECF44C VA: 0xED344C
	private void <Start>b__54_5(float value) { }

	[CompilerGenerated]
	// RVA: 0xED3504 Offset: 0xECF504 VA: 0xED3504
	private void <Start>b__54_6() { }

	[CompilerGenerated]
	// RVA: 0xED35A4 Offset: 0xECF5A4 VA: 0xED35A4
	private void <Start>b__54_7() { }
}

// Namespace: 
private enum WorldRankPc.CategoryIndex // TypeDefIndex: 2796
{
	// Fields
	public int value__; // 0x0
	public const WorldRankPc.CategoryIndex ThieuLamLevel = 0;
	public const WorldRankPc.CategoryIndex ThienVuongLevel = 1;
	public const WorldRankPc.CategoryIndex DuongMonLevel = 2;
	public const WorldRankPc.CategoryIndex NguDocLevel = 3;
	public const WorldRankPc.CategoryIndex NgaMiLevel = 4;
	public const WorldRankPc.CategoryIndex ThuyYenLevel = 5;
	public const WorldRankPc.CategoryIndex CaiBangLevel = 6;
	public const WorldRankPc.CategoryIndex ThienNhanLevel = 7;
	public const WorldRankPc.CategoryIndex VoDangLevel = 8;
	public const WorldRankPc.CategoryIndex ConLonLevel = 9;
	public const WorldRankPc.CategoryIndex worldLevel = 10;
	public const WorldRankPc.CategoryIndex worldMoney = 11;
}

// Namespace: 
private class WorldRankPc.CategoryData // TypeDefIndex: 2797
{
	// Fields
	public WorldRankPc.CategoryTemplate categoryTemplate; // 0x10
	public GameObject categoryGo; // 0x18
	public GameObject contentGo; // 0x20
	public GameObject fieldTemplate; // 0x28
	public WorldRankPc.fieldTemplate fieldTemplateClass; // 0x30
	public List<WorldRankPc.fieldTemplate> rankListing; // 0x38
	public List<RankPlayerMoneyResponseField> rankMoneyList; // 0x40
	public List<RankPlayerLevelResponseField> rankLevelList; // 0x48

	// Methods

	// RVA: 0xED642C Offset: 0xED242C VA: 0xED642C
	public void DestroyUnityFields() { }

	// RVA: 0xED7068 Offset: 0xED3068 VA: 0xED7068
	public void RenderLevelField(RankPlayerLevelResponseField message) { }

	// RVA: 0xED6C78 Offset: 0xED2C78 VA: 0xED6C78
	public void RerenderLevelList() { }

	// RVA: 0xED7434 Offset: 0xED3434 VA: 0xED7434
	public void RenderMoneyField(RankPlayerMoneyResponseField message) { }

	// RVA: 0xED6D98 Offset: 0xED2D98 VA: 0xED6D98
	public void RerenderMoneyList() { }

	// RVA: 0xED5ADC Offset: 0xED1ADC VA: 0xED5ADC
	public void .ctor() { }
}

// Namespace: 
private class WorldRankPc.CategoryTemplate // TypeDefIndex: 2798
{
	// Fields
	public GameObject go; // 0x10
	public Image backgroundActive; // 0x18
	public Image backgroundUnActive; // 0x20
	public TextMeshProUGUI tmp; // 0x28
	public Button button; // 0x30

	// Methods

	// RVA: 0xED5AE4 Offset: 0xED1AE4 VA: 0xED5AE4
	public void .ctor(GameObject go) { }
}

// Namespace: 
private class WorldRankPc.fieldTemplate // TypeDefIndex: 2799
{
	// Fields
	public GameObject go; // 0x10
	public TextMeshProUGUI rankTmp; // 0x18
	public TextMeshProUGUI nameTmp; // 0x20
	public TextMeshProUGUI levelTmp; // 0x28
	public TextMeshProUGUI expTmp; // 0x30

	// Methods

	// RVA: 0xED5D54 Offset: 0xED1D54 VA: 0xED5D54
	public void .ctor(GameObject go) { }

	// RVA: 0xED78E4 Offset: 0xED38E4 VA: 0xED78E4
	public WorldRankPc.fieldTemplate Clone(Transform parent) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WorldRankPc.<>c__DisplayClass44_0 // TypeDefIndex: 2800
{
	// Fields
	public KeyValuePair<WorldRankPc.CategoryIndex, WorldRankPc.CategoryData> entry; // 0x10
	public WorldRankPc <>4__this; // 0x20

	// Methods

	// RVA: 0xED5FEC Offset: 0xED1FEC VA: 0xED5FEC
	public void .ctor() { }

	// RVA: 0xED79A0 Offset: 0xED39A0 VA: 0xED79A0
	internal void <Start>b__1() { }
}

// Namespace: game.ui
public class WorldRankPc : MonoBehaviour // TypeDefIndex: 2801
{
	// Fields
	[SerializeField]
	private Image framedImage; // 0x20
	[SerializeField]
	private GameObject categoryLevelGo; // 0x28
	[SerializeField]
	private GameObject levelRankContentGo; // 0x30
	[SerializeField]
	private GameObject levelRankFieldTemplate; // 0x38
	[SerializeField]
	private Button closeButton; // 0x40
	[SerializeField]
	private GameObject categoryMoneyGo; // 0x48
	[SerializeField]
	private GameObject categoryThieuLamGo; // 0x50
	[SerializeField]
	private GameObject categoryThienVuongGo; // 0x58
	[SerializeField]
	private GameObject categoryDuongMonGo; // 0x60
	[SerializeField]
	private GameObject categoryNguDocGo; // 0x68
	[SerializeField]
	private GameObject categoryNgaMiGo; // 0x70
	[SerializeField]
	private GameObject categoryThuyYenGo; // 0x78
	[SerializeField]
	private GameObject categoryCaiBangGo; // 0x80
	[SerializeField]
	private GameObject categoryThienNhanGo; // 0x88
	[SerializeField]
	private GameObject categoryVoDangGo; // 0x90
	[SerializeField]
	private GameObject categoryConLonGo; // 0x98
	[SerializeField]
	private GameObject moneyRankContentGo; // 0xA0
	[SerializeField]
	private GameObject ThieuLamRankContentGo; // 0xA8
	[SerializeField]
	private GameObject ThienVuongRankContentGo; // 0xB0
	[SerializeField]
	private GameObject DuongMonRankContentGo; // 0xB8
	[SerializeField]
	private GameObject NguDocRankContentGo; // 0xC0
	[SerializeField]
	private GameObject NgaMiRankContentGo; // 0xC8
	[SerializeField]
	private GameObject ThuyYenRankContentGo; // 0xD0
	[SerializeField]
	private GameObject CaiBangRankContentGo; // 0xD8
	[SerializeField]
	private GameObject ThienNhanRankContentGo; // 0xE0
	[SerializeField]
	private GameObject VoDangRankContentGo; // 0xE8
	[SerializeField]
	private GameObject ConLonRankContentGo; // 0xF0
	[SerializeField]
	private GameObject moneyRankFieldTemplate; // 0xF8
	[SerializeField]
	private GameObject ThieuLamRankFieldTemplate; // 0x100
	[SerializeField]
	private GameObject ThienVuongRankFieldTemplate; // 0x108
	[SerializeField]
	private GameObject DuongMonRankFieldTemplate; // 0x110
	[SerializeField]
	private GameObject NguDocRankFieldTemplate; // 0x118
	[SerializeField]
	private GameObject NgaMiRankFieldTemplate; // 0x120
	[SerializeField]
	private GameObject ThuyYenRankFieldTemplate; // 0x128
	[SerializeField]
	private GameObject CaiBangRankFieldTemplate; // 0x130
	[SerializeField]
	private GameObject ThienNhanRankFieldTemplate; // 0x138
	[SerializeField]
	private GameObject VoDangRankFieldTemplate; // 0x140
	[SerializeField]
	private GameObject ConLonRankFieldTemplate; // 0x148
	private Queue<Action> onStartActions; // 0x150
	private bool hasStarted; // 0x158
	private readonly Dictionary<WorldRankPc.CategoryIndex, WorldRankPc.CategoryData> categories; // 0x160
	private bool isWaitingForClear; // 0x168

	// Methods

	// RVA: 0xED4B0C Offset: 0xED0B0C VA: 0xED4B0C
	private void Start() { }

	// RVA: 0xED5FF4 Offset: 0xED1FF4 VA: 0xED5FF4
	private void Perform(Action action) { }

	// RVA: 0xED60C4 Offset: 0xED20C4 VA: 0xED60C4
	public void Open() { }

	// RVA: 0xED615C Offset: 0xED215C VA: 0xED615C
	public void Close() { }

	// RVA: 0xED65E8 Offset: 0xED25E8 VA: 0xED65E8
	private void OpenCategory(WorldRankPc.CategoryIndex categoryIndex) { }

	// RVA: 0xED6F10 Offset: 0xED2F10 VA: 0xED6F10
	public bool IsOpen() { }

	// RVA: 0xED6F30 Offset: 0xED2F30 VA: 0xED6F30
	public void ProtocolRankPlayerFactionResponseField(RankPlayerFactionResponseField message) { }

	// RVA: 0xED735C Offset: 0xED335C VA: 0xED735C
	public void ProtocolRankPlayerMoneyResponseField(RankPlayerMoneyResponseField message) { }

	// RVA: 0xED770C Offset: 0xED370C VA: 0xED770C
	public void ProtocolRankPlayerLevelResponseField(RankPlayerLevelResponseField message) { }

	// RVA: 0xED77E4 Offset: 0xED37E4 VA: 0xED77E4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xED786C Offset: 0xED386C VA: 0xED786C
	private void <Start>b__44_0() { }

	[CompilerGenerated]
	// RVA: 0xED78DC Offset: 0xED38DC VA: 0xED78DC
	private void <Open>b__48_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AwardSelection.<>c__DisplayClass28_0 // TypeDefIndex: 2802
{
	// Fields
	public AwardSelection <>4__this; // 0x10
	public AwardSelectionAsk message; // 0x18

	// Methods

	// RVA: 0xED8094 Offset: 0xED4094 VA: 0xED8094
	public void .ctor() { }

	// RVA: 0xED8370 Offset: 0xED4370 VA: 0xED8370
	internal void <Open>b__0() { }
}

// Namespace: game.ui
public class AwardSelection : MonoBehaviour // TypeDefIndex: 2803
{
	// Fields
	[SerializeField]
	private GameObject hiddenIconGo; // 0x20
	[SerializeField]
	private Image hiddenIconBlueItem; // 0x28
	[SerializeField]
	private Image hiddenIconExp; // 0x30
	[SerializeField]
	private Image hiddenIconGoldItem; // 0x38
	[SerializeField]
	private Image hiddenIconKhoangThach; // 0x40
	[SerializeField]
	private Image hiddenIconMagicState; // 0x48
	[SerializeField]
	private Image hiddenIconMatTich; // 0x50
	[SerializeField]
	private Image hiddenIconMoney; // 0x58
	[SerializeField]
	private Image hiddenIconPinkItem; // 0x60
	[SerializeField]
	private Image hiddenIconPotion; // 0x68
	[SerializeField]
	private Image hiddenIconRandomAll; // 0x70
	[SerializeField]
	private Image hiddenIconRandomMagicItem; // 0x78
	[SerializeField]
	private Image hiddenIconOtherItem; // 0x80
	[SerializeField]
	private TextMeshProUGUI descriptionTmp; // 0x88
	[SerializeField]
	private Image selection0Image; // 0x90
	[SerializeField]
	private Image selection1Image; // 0x98
	[SerializeField]
	private Image selection2Image; // 0xA0
	[SerializeField]
	private Button selection0Button; // 0xA8
	[SerializeField]
	private Button selection1Button; // 0xB0
	[SerializeField]
	private Button selection2Button; // 0xB8
	private Queue<Action> onStartActions; // 0xC0
	private bool isStarted; // 0xC8
	private Dictionary<int, Image> iconMapping; // 0xD0
	private int currentAskingId; // 0xD8

	// Methods

	// RVA: 0xED7A24 Offset: 0xED3A24 VA: 0xED7A24
	private void Start() { }

	// RVA: 0xED7D3C Offset: 0xED3D3C VA: 0xED7D3C
	private void ApplyChildrenStyle(Transform transform) { }

	// RVA: 0xED7E74 Offset: 0xED3E74 VA: 0xED7E74
	private void Perform(Action action) { }

	// RVA: 0xED7F44 Offset: 0xED3F44 VA: 0xED7F44
	public void Close() { }

	// RVA: 0xED7F68 Offset: 0xED3F68 VA: 0xED7F68
	public void Open(AwardSelectionAsk message) { }

	// RVA: 0xED809C Offset: 0xED409C VA: 0xED809C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xED80A4 Offset: 0xED40A4 VA: 0xED80A4
	private void <Start>b__24_0() { }

	[CompilerGenerated]
	// RVA: 0xED8190 Offset: 0xED4190 VA: 0xED8190
	private void <Start>b__24_1() { }

	[CompilerGenerated]
	// RVA: 0xED8280 Offset: 0xED4280 VA: 0xED8280
	private void <Start>b__24_2() { }
}

// Namespace: game.ui
public class EnvelopItem : MonoBehaviour // TypeDefIndex: 2804
{
	// Fields
	public GameObject goReceived; // 0x20
	public GameObject goOpenned; // 0x28
	public Image compImageOpen; // 0x30
	public Button compButtonOpen; // 0x38
	public TextMeshProUGUI tmproReceiveTitle; // 0x40
	public TextMeshProUGUI tmproTitle; // 0x48
	public GameObject goContentList; // 0x50
	public GameObject goAwardTemplate; // 0x58
	public TextMeshProUGUI tmproContent; // 0x60
	public Button compButtonClose; // 0x68
	public TextMeshProUGUI tmproClose; // 0x70
	[CompilerGenerated]
	private bool <IsOpenned>k__BackingField; // 0x78

	// Properties
	public bool IsOpenned { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xED8548 Offset: 0xED4548 VA: 0xED8548
	public bool get_IsOpenned() { }

	[CompilerGenerated]
	// RVA: 0xED8550 Offset: 0xED4550 VA: 0xED8550
	private void set_IsOpenned(bool value) { }

	// RVA: 0xED8558 Offset: 0xED4558 VA: 0xED8558
	public void SetupDisplayFields() { }

	// RVA: 0xED8740 Offset: 0xED4740 VA: 0xED8740
	public void SetTitle(string title) { }

	// RVA: 0xED886C Offset: 0xED486C VA: 0xED886C
	public void SetContent(RepeatedField<string> itemlist, string content) { }

	// RVA: 0xED9174 Offset: 0xED5174 VA: 0xED9174
	public EnvelopItem Clone() { }

	// RVA: 0xED9218 Offset: 0xED5218 VA: 0xED9218
	public void .ctor() { }
}

// Namespace: 
public class EnvelopListing.ItemData // TypeDefIndex: 2805
{
	// Fields
	public EnvelopersAdd message; // 0x10
	public EnvelopItem gameobject; // 0x18

	// Methods

	// RVA: 0xED9A04 Offset: 0xED5A04 VA: 0xED9A04
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EnvelopListing.<>c__DisplayClass11_0 // TypeDefIndex: 2806
{
	// Fields
	public EnvelopListing.ItemData entry; // 0x10
	public EnvelopListing <>4__this; // 0x18

	// Methods

	// RVA: 0xED97E4 Offset: 0xED57E4 VA: 0xED97E4
	public void .ctor() { }

	// RVA: 0xED9A0C Offset: 0xED5A0C VA: 0xED9A0C
	internal void <Openned>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EnvelopListing.<>c__DisplayClass12_0 // TypeDefIndex: 2807
{
	// Fields
	public EnvelopListing <>4__this; // 0x10
	public EnvelopersAdd message; // 0x18

	// Methods

	// RVA: 0xED9920 Offset: 0xED5920 VA: 0xED9920
	public void .ctor() { }

	// RVA: 0xED9AF4 Offset: 0xED5AF4 VA: 0xED9AF4
	internal void <Add>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class EnvelopListing.<>c__DisplayClass12_1 // TypeDefIndex: 2808
{
	// Fields
	public EnvelopItem newEnvelop; // 0x10
	public EnvelopListing.<>c__DisplayClass12_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xED9E94 Offset: 0xED5E94 VA: 0xED9E94
	public void .ctor() { }

	// RVA: 0xED9E9C Offset: 0xED5E9C VA: 0xED9E9C
	internal void <Add>b__1() { }
}

// Namespace: game.ui
public class EnvelopListing : MonoBehaviour // TypeDefIndex: 2809
{
	// Fields
	public GameObject goListing; // 0x20
	public EnvelopItem itemTemplate; // 0x28
	public List<EnvelopListing.ItemData> listing; // 0x30
	private bool hasBeenStarted; // 0x38
	private Queue<Action> onStartedQueue; // 0x40
	private float totalDeltaTime; // 0x48
	private bool animate; // 0x4C

	// Methods

	// RVA: 0xED9220 Offset: 0xED5220 VA: 0xED9220
	private void Start() { }

	// RVA: 0xED92E0 Offset: 0xED52E0 VA: 0xED92E0
	private void Update() { }

	// RVA: 0xED94AC Offset: 0xED54AC VA: 0xED94AC
	private void LeanScale(Transform transform, Vector2 to, float time, Action onFinish) { }

	// RVA: 0xED94EC Offset: 0xED54EC VA: 0xED94EC
	public void Openned(EnvelopersOpenned message) { }

	// RVA: 0xED97EC Offset: 0xED57EC VA: 0xED97EC
	public void Add(EnvelopersAdd message) { }

	// RVA: 0xED9928 Offset: 0xED5928 VA: 0xED9928
	public void .ctor() { }
}

// Namespace: 
public class FriendlyList.FieldTemplate // TypeDefIndex: 2810
{
	// Fields
	public GameObject go; // 0x10
	public TextMeshProUGUI tmpName; // 0x18
	public Button button; // 0x20
	public FriendlyListingField data; // 0x28

	// Methods

	// RVA: 0xEDA880 Offset: 0xED6880 VA: 0xEDA880
	public void .ctor(GameObject go) { }

	// RVA: 0xEDC640 Offset: 0xED8640 VA: 0xEDC640
	public FriendlyList.FieldTemplate Clone(GameObject parent) { }

	// RVA: 0xEDC718 Offset: 0xED8718 VA: 0xEDC718
	public void SetData(FriendlyListingField data) { }

	// RVA: 0xEDC290 Offset: 0xED8290 VA: 0xEDC290
	public void SetNormal() { }

	// RVA: 0xEDC720 Offset: 0xED8720 VA: 0xEDC720
	public void SetActive() { }
}

// Namespace: 
public enum FriendlyList.ListTypeIndexer // TypeDefIndex: 2811
{
	// Fields
	public int value__; // 0x0
	public const FriendlyList.ListTypeIndexer unidentified = 0;
	public const FriendlyList.ListTypeIndexer friendship = 1;
	public const FriendlyList.ListTypeIndexer killer = 2;
	public const FriendlyList.ListTypeIndexer black = 3;
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendlyList.<>c__DisplayClass38_0 // TypeDefIndex: 2812
{
	// Fields
	public float secondsRemaining; // 0x10
	public FriendlyList <>4__this; // 0x18
	public RectTransform rect; // 0x20
	public Vector2 to; // 0x28
	public Action onFinish; // 0x30
	public float speedOnSeconds; // 0x38

	// Methods

	// RVA: 0xEDAC44 Offset: 0xED6C44 VA: 0xEDAC44
	public void .ctor() { }

	// RVA: 0xEDC7EC Offset: 0xED87EC VA: 0xEDC7EC
	internal void <LeanMoveLocal>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendlyList.<>c__DisplayClass39_0 // TypeDefIndex: 2813
{
	// Fields
	public bool enabled; // 0x10
	public FriendlyList <>4__this; // 0x18
	public Action <>9__1; // 0x20

	// Methods

	// RVA: 0xEDAD5C Offset: 0xED6D5C VA: 0xEDAD5C
	public void .ctor() { }

	// RVA: 0xEDC990 Offset: 0xED8990 VA: 0xEDC990
	internal void <ShowOpen>b__0() { }

	// RVA: 0xEDCA94 Offset: 0xED8A94 VA: 0xEDCA94
	internal void <ShowOpen>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendlyList.<>c__DisplayClass45_0 // TypeDefIndex: 2814
{
	// Fields
	public FriendlyList <>4__this; // 0x10
	public FriendlyList.FieldTemplate field; // 0x18

	// Methods

	// RVA: 0xEDAF4C Offset: 0xED6F4C VA: 0xEDAF4C
	public void .ctor() { }

	// RVA: 0xEDCAA8 Offset: 0xED8AA8 VA: 0xEDCAA8
	internal void <RemoveField>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendlyList.<>c__DisplayClass51_0 // TypeDefIndex: 2815
{
	// Fields
	public FriendlyList <>4__this; // 0x10
	public FriendlyListingResponse message; // 0x18

	// Methods

	// RVA: 0xEDB904 Offset: 0xED7904 VA: 0xEDB904
	public void .ctor() { }

	// RVA: 0xEDCB98 Offset: 0xED8B98 VA: 0xEDCB98
	internal void <ProtocolFriendlyListingResponse>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendlyList.<>c__DisplayClass51_1 // TypeDefIndex: 2816
{
	// Fields
	public FriendlyListingField entry; // 0x10
	public FriendlyList.FieldTemplate newfield; // 0x18
	public FriendlyList.<>c__DisplayClass51_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0xEDD09C Offset: 0xED909C VA: 0xEDD09C
	public void .ctor() { }

	// RVA: 0xEDD0A4 Offset: 0xED90A4 VA: 0xEDD0A4
	internal void <ProtocolFriendlyListingResponse>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendlyList.<>c__DisplayClass52_0 // TypeDefIndex: 2817
{
	// Fields
	public FriendlyList <>4__this; // 0x10
	public FriendlyAddNotify message; // 0x18

	// Methods

	// RVA: 0xEDB90C Offset: 0xED790C VA: 0xEDB90C
	public void .ctor() { }

	// RVA: 0xEDD1D0 Offset: 0xED91D0 VA: 0xEDD1D0
	internal void <ProtocolFriendlyAddNotify>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class FriendlyList.<>c__DisplayClass52_1 // TypeDefIndex: 2818
{
	// Fields
	public FriendlyList.FieldTemplate newfield; // 0x10
	public FriendlyListingField newData; // 0x18
	public FriendlyList.<>c__DisplayClass52_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0xEDD474 Offset: 0xED9474 VA: 0xEDD474
	public void .ctor() { }

	// RVA: 0xEDD47C Offset: 0xED947C VA: 0xEDD47C
	internal void <ProtocolFriendlyAddNotify>b__1() { }
}

// Namespace: game.ui
public class FriendlyList : MonoBehaviour // TypeDefIndex: 2819
{
	// Fields
	private const int OriginFramedWidth = 125;
	private const int OriginFramedHeight = 359;
	[SerializeField]
	private List<Image> imageList; // 0x20
	[SerializeField]
	private List<TextMeshProUGUI> tmpList; // 0x28
	[SerializeField]
	private RectTransform framedRect; // 0x30
	[SerializeField]
	private GameObject fieldTemplateGo; // 0x38
	[SerializeField]
	private GameObject fieldListingGo; // 0x40
	[SerializeField]
	private Button closeButton; // 0x48
	[SerializeField]
	private Button tabNormalButtonFriend; // 0x50
	[SerializeField]
	private Button tabNormalButtonFamily; // 0x58
	[SerializeField]
	private Button tabNormalButtonKiller; // 0x60
	[SerializeField]
	private Button tabNormalButtonBlack; // 0x68
	[SerializeField]
	private Image tabActiveImageFriend; // 0x70
	[SerializeField]
	private Image tabActiveImageFamily; // 0x78
	[SerializeField]
	private Image tabActiveImageKiller; // 0x80
	[SerializeField]
	private Image tabActiveImageBlack; // 0x88
	[SerializeField]
	private GameObject targetFuncsGo; // 0x90
	[SerializeField]
	private TextMeshProUGUI targetTmpName; // 0x98
	[SerializeField]
	private Button targetFuncInfo; // 0xA0
	[SerializeField]
	private Button targetFuncMessage; // 0xA8
	[SerializeField]
	private Button targetFuncInviteTeam; // 0xB0
	[SerializeField]
	private Button targetFuncJoinTeam; // 0xB8
	[SerializeField]
	private Button targetFuncRemove; // 0xC0
	[SerializeField]
	private Button targetFuncClose; // 0xC8
	private float scaleRatio; // 0xD0
	private Vector2 showoffVisiblePosition; // 0xD4
	private Vector2 showoffHiddenPosition; // 0xDC
	private Queue<Action> onStartActions; // 0xE8
	private bool isStarted; // 0xF0
	private bool isOpening; // 0xF1
	private FriendlyList.FieldTemplate fieldTemplate; // 0xF8
	private List<FriendlyList.FieldTemplate> fieldListing; // 0x100
	private FriendlyListingField targetSelected; // 0x108
	private FriendlyList.FieldTemplate currentFieldSelected; // 0x110
	private Action leanMoveLocalUpdating; // 0x118

	// Methods

	// RVA: 0xED9FCC Offset: 0xED5FCC VA: 0xED9FCC
	private void Start() { }

	// RVA: 0xEDA9A4 Offset: 0xED69A4 VA: 0xEDA9A4
	private void Update() { }

	// RVA: 0xEDA9C0 Offset: 0xED69C0 VA: 0xEDA9C0
	private void Perform(Action action) { }

	// RVA: 0xEDAA90 Offset: 0xED6A90 VA: 0xEDAA90
	private void LeanMoveLocal(RectTransform rect, Vector2 to, Action onFinish) { }

	// RVA: 0xEDAC4C Offset: 0xED6C4C VA: 0xEDAC4C
	public void ShowOpen(bool enabled) { }

	// RVA: 0xEDAD64 Offset: 0xED6D64 VA: 0xEDAD64
	public bool ShowOff() { }

	// RVA: 0xEDAD88 Offset: 0xED6D88 VA: 0xEDAD88
	public void ShowDirectly(bool enabled) { }

	// RVA: 0xEDAE70 Offset: 0xED6E70 VA: 0xEDAE70
	public bool IsOpen() { }

	// RVA: 0xEDA790 Offset: 0xED6790 VA: 0xEDA790
	private void SetTmp(TextMeshProUGUI tmp, string text, string color) { }

	// RVA: 0xEDAE78 Offset: 0xED6E78 VA: 0xEDAE78
	public void RemoveField(FriendlyList.FieldTemplate field) { }

	// RVA: 0xEDAF54 Offset: 0xED6F54 VA: 0xEDAF54
	public void Clear() { }

	// RVA: 0xEDAE40 Offset: 0xED6E40 VA: 0xEDAE40
	public void Close() { }

	// RVA: 0xEDAFD4 Offset: 0xED6FD4 VA: 0xEDAFD4
	public void ApplyTable(FriendlyList.ListTypeIndexer type) { }

	// RVA: 0xEDB594 Offset: 0xED7594 VA: 0xEDB594
	public void ProtocolFriendlyAddResponse(FriendlyAddResponse message) { }

	// RVA: 0xEDB7FC Offset: 0xED77FC VA: 0xEDB7FC
	public void ProtocolFriendlyListingResponse(FriendlyListingResponse message) { }

	// RVA: 0xEDB6FC Offset: 0xED76FC VA: 0xEDB6FC
	public void ProtocolFriendlyAddNotify(FriendlyAddNotify message) { }

	// RVA: 0xEDB914 Offset: 0xED7914 VA: 0xEDB914
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEDB91C Offset: 0xED791C VA: 0xEDB91C
	private void <Start>b__35_0() { }

	[CompilerGenerated]
	// RVA: 0xEDB990 Offset: 0xED7990 VA: 0xEDB990
	private void <Start>b__35_1() { }

	[CompilerGenerated]
	// RVA: 0xEDBA04 Offset: 0xED7A04 VA: 0xEDBA04
	private void <Start>b__35_2() { }

	[CompilerGenerated]
	// RVA: 0xEDBA78 Offset: 0xED7A78 VA: 0xEDBA78
	private void <Start>b__35_3() { }

	[CompilerGenerated]
	// RVA: 0xEDBAE8 Offset: 0xED7AE8 VA: 0xEDBAE8
	private void <Start>b__35_4() { }

	[CompilerGenerated]
	// RVA: 0xEDBBE0 Offset: 0xED7BE0 VA: 0xEDBBE0
	private void <Start>b__35_5() { }

	[CompilerGenerated]
	// RVA: 0xEDBC90 Offset: 0xED7C90 VA: 0xEDBC90
	private void <Start>b__35_6() { }

	[CompilerGenerated]
	// RVA: 0xEDBD88 Offset: 0xED7D88 VA: 0xEDBD88
	private void <Start>b__35_7() { }

	[CompilerGenerated]
	// RVA: 0xEDBE80 Offset: 0xED7E80 VA: 0xEDBE80
	private void <Start>b__35_8() { }

	[CompilerGenerated]
	// RVA: 0xEDC130 Offset: 0xED8130 VA: 0xEDC130
	private void <Start>b__35_10() { }

	[CompilerGenerated]
	// RVA: 0xEDC1EC Offset: 0xED81EC VA: 0xEDC1EC
	private void <Start>b__35_9() { }

	[CompilerGenerated]
	// RVA: 0xEDC42C Offset: 0xED842C VA: 0xEDC42C
	private void <ShowDirectly>b__41_0() { }

	[CompilerGenerated]
	// RVA: 0xEDC460 Offset: 0xED8460 VA: 0xEDC460
	private void <Clear>b__46_0() { }
}

// Namespace: game.ui
public class ItemBorder : MonoBehaviour // TypeDefIndex: 2820
{
	// Fields
	[SerializeField]
	private RectTransform rectTransform; // 0x20
	[SerializeField]
	private Image imageLevel1; // 0x28
	[SerializeField]
	private Image imageLevel2; // 0x30
	[SerializeField]
	private Image imageLevel3; // 0x38
	private const float tpf18 = 0.05555555;
	private float freezeRemaining; // 0x40
	private ItemBorderPc borderPc; // 0x48
	private ItemBorderMobile borderMobile; // 0x50
	private bool styleCurrentlyIsPc; // 0x58
	private bool styleCurrentlyIsMobile; // 0x59

	// Methods

	// RVA: 0xEDD5A8 Offset: 0xED95A8 VA: 0xEDD5A8
	private void Start() { }

	// RVA: 0xEDD618 Offset: 0xED9618 VA: 0xEDD618
	private void Update() { }

	// RVA: 0xEDED74 Offset: 0xEDAD74 VA: 0xEDED74
	private void OnDisable() { }

	// RVA: 0xEDED78 Offset: 0xEDAD78 VA: 0xEDED78
	public void Clear() { }

	// RVA: 0xEDEDC8 Offset: 0xEDADC8 VA: 0xEDEDC8
	public void SetActive(bool enabled) { }

	// RVA: 0xEDEE14 Offset: 0xEDAE14 VA: 0xEDEE14
	public void .ctor() { }
}

// Namespace: game.ui
public class ItemBorderMobile // TypeDefIndex: 2821
{
	// Fields
	private RectTransform rectTransform; // 0x10
	private Image imageLevel1; // 0x18
	private Image imageLevel2; // 0x20
	private Image imageLevel3; // 0x28
	private static Sprite spriteSheetSprite; // 0x0
	private static int spriteSheetFrameCount; // 0x8
	private static Dictionary<int, Sprite> spriteSheetFrames; // 0x10
	private const int spriteSheetFrameWidth = 128;
	private const int spriteSheetFrameHeight = 128;
	private int currentFrame; // 0x30

	// Methods

	// RVA: 0xEDDF24 Offset: 0xED9F24 VA: 0xEDDF24
	public void Release() { }

	// RVA: 0xEDEDC0 Offset: 0xEDADC0 VA: 0xEDEDC0
	public void Clear() { }

	// RVA: 0xEDD974 Offset: 0xED9974 VA: 0xEDD974
	public void .ctor(RectTransform rectTransform, Image imageLevel1, Image imageLevel2, Image imageLevel3) { }

	// RVA: 0xEDDCF8 Offset: 0xED9CF8 VA: 0xEDDCF8
	public void Update() { }
}

// Namespace: 
private struct ItemBorderPc.GoldenPosition // TypeDefIndex: 2822
{
	// Fields
	public Vector2Int[] pos; // 0x0
}

// Namespace: game.ui
public class ItemBorderPc // TypeDefIndex: 2823
{
	// Fields
	private RectTransform rectTransform; // 0x10
	private Image imageLevel1; // 0x18
	private Image imageLevel2; // 0x20
	private Image imageLevel3; // 0x28
	private static readonly Color colorClear; // 0x0
	private int level2CurrentTime; // 0x30
	private int level3Line1Index; // 0x34
	private int level3Line2Index; // 0x38
	private Texture2D level3Texture2D; // 0x40
	private ItemBorderPc.GoldenPosition[] level3GoldenPosition; // 0x48
	private int level3GoldenLength; // 0x50

	// Methods

	// RVA: 0xEDD814 Offset: 0xED9814 VA: 0xEDD814
	public void Release() { }

	// RVA: 0xEDEDC4 Offset: 0xEDADC4 VA: 0xEDEDC4
	public void Clear() { }

	// RVA: 0xEDE160 Offset: 0xEDA160 VA: 0xEDE160
	public void .ctor(RectTransform rectTransform, Image imageLevel1, Image imageLevel2, Image imageLevel3) { }

	// RVA: 0xEDEE1C Offset: 0xEDAE1C VA: 0xEDEE1C
	private void RenderGoldenLine(int indexInGoldenVector, Color color) { }

	// RVA: 0xEDEBC4 Offset: 0xEDABC4 VA: 0xEDEBC4
	public void Update() { }

	// RVA: 0xEDEF78 Offset: 0xEDAF78 VA: 0xEDEF78
	private static void .cctor() { }
}

// Namespace: game.ui
public class LocalNews : MonoBehaviour // TypeDefIndex: 2824
{
	// Fields
	[SerializeField]
	private GameObject btn; // 0x20
	[SerializeField]
	private GameObject Text; // 0x28
	[SerializeField]
	private GameObject Pannel; // 0x30
	private GameObject CurentObject; // 0x38
	private List<string> strings; // 0x40

	// Methods

	// RVA: 0xEDEFC0 Offset: 0xEDAFC0 VA: 0xEDEFC0
	public void AddMessage(string text, int time) { }

	// RVA: 0xEDF0B4 Offset: 0xEDB0B4 VA: 0xEDF0B4
	private void Update() { }

	// RVA: 0xEDF3A8 Offset: 0xEDB3A8 VA: 0xEDF3A8
	public void .ctor() { }
}

// Namespace: 
private class ManualLayout.FieldTemplate // TypeDefIndex: 2825
{
	// Fields
	public GameObject go; // 0x10
	public TextMeshProUGUI label; // 0x18
	public Button button; // 0x20

	// Methods

	// RVA: 0xEDF940 Offset: 0xEDB940 VA: 0xEDF940
	public void .ctor(GameObject go) { }

	// RVA: 0xEE065C Offset: 0xEDC65C VA: 0xEE065C
	public ManualLayout.FieldTemplate Clone(GameObject parent) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ManualLayout.InjectTemplate.<>c__DisplayClass4_0 // TypeDefIndex: 2826
{
	// Fields
	public Action onScaleClick; // 0x10
	public Action onRemoveClick; // 0x18

	// Methods

	// RVA: 0xEE0918 Offset: 0xEDC918 VA: 0xEE0918
	public void .ctor() { }

	// RVA: 0xEE0920 Offset: 0xEDC920 VA: 0xEE0920
	internal void <SetParent>b__0() { }

	// RVA: 0xEE0940 Offset: 0xEDC940 VA: 0xEE0940
	internal void <SetParent>b__1() { }
}

// Namespace: 
private class ManualLayout.InjectTemplate // TypeDefIndex: 2827
{
	// Fields
	public GameObject go; // 0x10
	public Button scaleButton; // 0x18
	public Button removeButton; // 0x20

	// Methods

	// RVA: 0xEDFA78 Offset: 0xEDBA78 VA: 0xEDFA78
	public void .ctor(GameObject go) { }

	// RVA: 0xEE0734 Offset: 0xEDC734 VA: 0xEE0734
	public void SetParent(GameObject go, Action onScaleClick, Action onRemoveClick) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ManualLayout.<>c__DisplayClass24_0 // TypeDefIndex: 2828
{
	// Fields
	public ManualLayout <>4__this; // 0x10
	public bool cachedLoaded; // 0x18
	public Action<Vector2> <>9__1; // 0x20

	// Methods

	// RVA: 0xEE0240 Offset: 0xEDC240 VA: 0xEE0240
	public void .ctor() { }

	// RVA: 0xEE0960 Offset: 0xEDC960 VA: 0xEE0960
	internal void <Open>b__0() { }

	// RVA: 0xEE0F84 Offset: 0xEDCF84 VA: 0xEE0F84
	internal void <Open>b__1(Vector2 differencePosition) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ManualLayout.<>c__DisplayClass24_1 // TypeDefIndex: 2829
{
	// Fields
	public References.Data entry; // 0x10
	public ManualLayout.<>c__DisplayClass24_0 CS$<>8__locals1; // 0x18
	public Action<string> <>9__7; // 0x20
	public Action <>9__5; // 0x28
	public Action<string> <>9__8; // 0x30
	public Action <>9__6; // 0x38
	public Action <>9__3; // 0x40
	public Action <>9__4; // 0x48

	// Methods

	// RVA: 0xEE0F7C Offset: 0xEDCF7C VA: 0xEE0F7C
	public void .ctor() { }

	// RVA: 0xEE10AC Offset: 0xEDD0AC VA: 0xEE10AC
	internal void <Open>b__2() { }

	// RVA: 0xEE1314 Offset: 0xEDD314 VA: 0xEE1314
	internal void <Open>b__3() { }

	// RVA: 0xEE14A0 Offset: 0xEDD4A0 VA: 0xEE14A0
	internal void <Open>b__5() { }

	// RVA: 0xEE1890 Offset: 0xEDD890 VA: 0xEE1890
	internal void <Open>b__7(string _input) { }

	// RVA: 0xEE1A4C Offset: 0xEDDA4C VA: 0xEE1A4C
	internal void <Open>b__6() { }

	// RVA: 0xEE1B78 Offset: 0xEDDB78 VA: 0xEE1B78
	internal void <Open>b__8(string _input) { }

	// RVA: 0xEE1D34 Offset: 0xEDDD34 VA: 0xEE1D34
	internal void <Open>b__4() { }
}

// Namespace: game.ui
public class ManualLayout : MonoBehaviour // TypeDefIndex: 2830
{
	// Fields
	[SerializeField]
	private Button funcButtonSave; // 0x20
	[SerializeField]
	private Button funcButtonClose; // 0x28
	[SerializeField]
	private Button funcButtonCancel; // 0x30
	[SerializeField]
	private Button funcCloseArea; // 0x38
	[SerializeField]
	private GameObject fieldTemplateGo; // 0x40
	[SerializeField]
	private GameObject fieldListingContent; // 0x48
	[SerializeField]
	private GameObject injectTemplateGo; // 0x50
	[SerializeField]
	private ManuaMovingSupporting injectMovingSupporting; // 0x58
	[SerializeField]
	private Toggle optionSeparateChatHistory; // 0x60
	[SerializeField]
	private Toggle optionSeparateTeamListing; // 0x68
	private Queue<Action> onStartActions; // 0x70
	private bool isStarted; // 0x78
	private ManualLayout.FieldTemplate fieldTemplate; // 0x80
	private bool isListingComponents; // 0x88
	private ManualLayout.InjectTemplate injectTemplate; // 0x90
	private bool preopenIsUiManualed; // 0x98

	// Methods

	// RVA: 0xEDF430 Offset: 0xEDB430 VA: 0xEDF430
	private void Start() { }

	// RVA: 0xEDF7B4 Offset: 0xEDB7B4 VA: 0xEDF7B4
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xEDFCD4 Offset: 0xEDBCD4 VA: 0xEDFCD4
	private void Perform(Action action) { }

	// RVA: 0xEDFBE4 Offset: 0xEDBBE4 VA: 0xEDFBE4
	private void SetTmp(TextMeshProUGUI tmp, string text, string color) { }

	// RVA: 0xEDFDA4 Offset: 0xEDBDA4 VA: 0xEDFDA4
	private void ClearAllComponents() { }

	// RVA: 0xEE0048 Offset: 0xEDC048 VA: 0xEE0048
	public bool IsListingComponents() { }

	// RVA: 0xEE0050 Offset: 0xEDC050 VA: 0xEE0050
	public void Open(bool saveLastTypeUsed) { }

	// RVA: 0xEE0248 Offset: 0xEDC248 VA: 0xEE0248
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEE0250 Offset: 0xEDC250 VA: 0xEE0250
	private void <Start>b__16_0() { }

	[CompilerGenerated]
	// RVA: 0xEE02D4 Offset: 0xEDC2D4 VA: 0xEE02D4
	private void <Start>b__16_1() { }

	[CompilerGenerated]
	// RVA: 0xEE0374 Offset: 0xEDC374 VA: 0xEE0374
	private void <Start>b__16_2() { }

	[CompilerGenerated]
	// RVA: 0xEE0464 Offset: 0xEDC464 VA: 0xEE0464
	private void <Start>b__16_3() { }

	[CompilerGenerated]
	// RVA: 0xEE0534 Offset: 0xEDC534 VA: 0xEE0534
	private void <Start>b__16_4(bool isOn) { }

	[CompilerGenerated]
	// RVA: 0xEE05C8 Offset: 0xEDC5C8 VA: 0xEE05C8
	private void <Start>b__16_5(bool isOn) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class MiniMap.<>c // TypeDefIndex: 2831
{
	// Fields
	public static readonly MiniMap.<>c <>9; // 0x0
	public static Action<string> <>9__14_2; // 0x8
	public static UnityAction <>9__14_0; // 0x10

	// Methods

	// RVA: 0xEE2764 Offset: 0xEDE764 VA: 0xEE2764
	private static void .cctor() { }

	// RVA: 0xEE27CC Offset: 0xEDE7CC VA: 0xEE27CC
	public void .ctor() { }

	// RVA: 0xEE27D4 Offset: 0xEDE7D4 VA: 0xEE27D4
	internal void <Start>b__14_0() { }

	// RVA: 0xEE2A28 Offset: 0xEDEA28 VA: 0xEE2A28
	internal void <Start>b__14_2(string _input) { }
}

// Namespace: game.ui
public class MiniMap : MonoBehaviour // TypeDefIndex: 2832
{
	// Fields
	[SerializeField]
	public RectTransform framedRect; // 0x20
	[SerializeField]
	private GameObject scalerGo; // 0x28
	[SerializeField]
	private RectTransform scalerRect; // 0x30
	[SerializeField]
	private Button scalerButton; // 0x38
	[SerializeField]
	private TextMeshProUGUI mapNameTmp; // 0x40
	[SerializeField]
	private TextMeshProUGUI mapPosTmp; // 0x48
	[SerializeField]
	private Button mapPosButton; // 0x50
	[SerializeField]
	private RectTransform nospriteFramed; // 0x58
	[SerializeField]
	private TextMeshProUGUI nospriteTmp; // 0x60
	private MiniMap miniMapHandle; // 0x68
	private MapList.MapInfo mapInfo; // 0x70
	private long nextUpdatePositionLabelTime; // 0x78
	private bool hasStarted; // 0x80
	private Action onStartedCallback; // 0x88
	private float limitLeftX; // 0x90
	private float limitRightX; // 0x94
	private float limitTopY; // 0x98
	private float limitBottomY; // 0x9C

	// Methods

	// RVA: 0xEE1DB8 Offset: 0xEDDDB8 VA: 0xEE1DB8
	private void Start() { }

	// RVA: 0xEE1F74 Offset: 0xEDDF74 VA: 0xEE1F74
	private void ApplyAnchor() { }

	// RVA: 0xEE1FCC Offset: 0xEDDFCC VA: 0xEE1FCC
	private void ApplyGridable(float horizontalStart, float horizontalEnd, float verticalStart, float verticalEnd) { }

	// RVA: 0xEE20CC Offset: 0xEDE0CC VA: 0xEE20CC
	public void SetStartedCallback(Action action) { }

	// RVA: 0xEE20FC Offset: 0xEDE0FC VA: 0xEE20FC
	public Sprite GetSprite() { }

	// RVA: 0xEE2110 Offset: 0xEDE110 VA: 0xEE2110
	public void SetActivate(bool enabled) { }

	// RVA: 0xEE2170 Offset: 0xEDE170 VA: 0xEE2170
	public void SetMapInfo(MapList.MapInfo mapInfo) { }

	// RVA: 0xEE225C Offset: 0xEDE25C VA: 0xEE225C
	public void SetHandle(MiniMap miniMapHandle) { }

	// RVA: 0xEE22E8 Offset: 0xEDE2E8 VA: 0xEE22E8
	public void SetMapPositionFloat(float top, float left) { }

	// RVA: 0xEE25B0 Offset: 0xEDE5B0 VA: 0xEE25B0
	public void SetMapName(string name) { }

	// RVA: 0xEE2644 Offset: 0xEDE644 VA: 0xEE2644
	public void SetNoSpriteMapName(string name) { }

	// RVA: 0xEE26D8 Offset: 0xEDE6D8 VA: 0xEE26D8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEE26E0 Offset: 0xEDE6E0 VA: 0xEE26E0
	private void <Start>b__14_1() { }
}

// Namespace: 
private class NotificationPc.TemplateClass // TypeDefIndex: 2833
{
	// Fields
	public GameObject go; // 0x10
	public GameObject selectionGo; // 0x18
	public GameObject agreeGo; // 0x20
	public GameObject cancelGo; // 0x28
	public TextMeshProUGUI descriptionTmp; // 0x30
	public TextMeshProUGUI agreeTmp; // 0x38
	public TextMeshProUGUI cancelTmp; // 0x40
	public Button agreeButton; // 0x48
	public Button cancelButton; // 0x50

	// Methods

	// RVA: 0xEE2EFC Offset: 0xEDEEFC VA: 0xEE2EFC
	public void .ctor(GameObject go) { }

	// RVA: 0xEE3F14 Offset: 0xEDFF14 VA: 0xEE3F14
	public NotificationPc.TemplateClass Clone(GameObject parent) { }

	// RVA: 0xEE4004 Offset: 0xEE0004 VA: 0xEE4004
	public void SetDescription(string description) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NotificationPc.<>c__DisplayClass20_0 // TypeDefIndex: 2834
{
	// Fields
	public NotificationPc <>4__this; // 0x10
	public FriendlyAddNotify message; // 0x18

	// Methods

	// RVA: 0xEE36A0 Offset: 0xEDF6A0 VA: 0xEE36A0
	public void .ctor() { }

	// RVA: 0xEE4098 Offset: 0xEE0098 VA: 0xEE4098
	internal void <ProtocolFriendlyAddNotify>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NotificationPc.<>c__DisplayClass20_1 // TypeDefIndex: 2835
{
	// Fields
	public NotificationPc.TemplateClass template; // 0x10
	public NotificationPc.<>c__DisplayClass20_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xEE42C8 Offset: 0xEE02C8 VA: 0xEE42C8
	public void .ctor() { }

	// RVA: 0xEE42D0 Offset: 0xEE02D0 VA: 0xEE42D0
	internal void <ProtocolFriendlyAddNotify>b__1() { }

	// RVA: 0xEE44D0 Offset: 0xEE04D0 VA: 0xEE44D0
	internal void <ProtocolFriendlyAddNotify>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NotificationPc.<>c__DisplayClass21_0 // TypeDefIndex: 2836
{
	// Fields
	public NotificationPc <>4__this; // 0x10
	public PartyInvite message; // 0x18

	// Methods

	// RVA: 0xEE386C Offset: 0xEDF86C VA: 0xEE386C
	public void .ctor() { }

	// RVA: 0xEE477C Offset: 0xEE077C VA: 0xEE477C
	internal void <ProtocolPartyInvite>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NotificationPc.<>c__DisplayClass21_1 // TypeDefIndex: 2837
{
	// Fields
	public NotificationPc.TemplateClass template; // 0x10
	public NotificationPc.<>c__DisplayClass21_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xEE494C Offset: 0xEE094C VA: 0xEE494C
	public void .ctor() { }

	// RVA: 0xEE4954 Offset: 0xEE0954 VA: 0xEE4954
	internal void <ProtocolPartyInvite>b__1() { }

	// RVA: 0xEE4BD8 Offset: 0xEE0BD8 VA: 0xEE4BD8
	internal void <ProtocolPartyInvite>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NotificationPc.<>c__DisplayClass22_0 // TypeDefIndex: 2838
{
	// Fields
	public NotificationPc <>4__this; // 0x10
	public PartyRequest message; // 0x18

	// Methods

	// RVA: 0xEE39C8 Offset: 0xEDF9C8 VA: 0xEE39C8
	public void .ctor() { }

	// RVA: 0xEE4E5C Offset: 0xEE0E5C VA: 0xEE4E5C
	internal void <ProtocolPartyRequest>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NotificationPc.<>c__DisplayClass22_1 // TypeDefIndex: 2839
{
	// Fields
	public NotificationPc.TemplateClass template; // 0x10
	public NotificationPc.<>c__DisplayClass22_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xEE5024 Offset: 0xEE1024 VA: 0xEE5024
	public void .ctor() { }

	// RVA: 0xEE502C Offset: 0xEE102C VA: 0xEE502C
	internal void <ProtocolPartyRequest>b__1() { }

	// RVA: 0xEE5228 Offset: 0xEE1228 VA: 0xEE5228
	internal void <ProtocolPartyRequest>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NotificationPc.<>c__DisplayClass23_0 // TypeDefIndex: 2840
{
	// Fields
	public NotificationPc <>4__this; // 0x10
	public TongRequestField message; // 0x18

	// Methods

	// RVA: 0xEE3B24 Offset: 0xEDFB24 VA: 0xEE3B24
	public void .ctor() { }

	// RVA: 0xEE5424 Offset: 0xEE1424 VA: 0xEE5424
	internal void <ProtocolTongRequest>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NotificationPc.<>c__DisplayClass23_1 // TypeDefIndex: 2841
{
	// Fields
	public NotificationPc.TemplateClass template; // 0x10
	public NotificationPc.<>c__DisplayClass23_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xEE55EC Offset: 0xEE15EC VA: 0xEE55EC
	public void .ctor() { }

	// RVA: 0xEE55F4 Offset: 0xEE15F4 VA: 0xEE55F4
	internal void <ProtocolTongRequest>b__1() { }

	// RVA: 0xEE57F0 Offset: 0xEE17F0 VA: 0xEE57F0
	internal void <ProtocolTongRequest>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NotificationPc.<>c__DisplayClass24_0 // TypeDefIndex: 2842
{
	// Fields
	public NotificationPc <>4__this; // 0x10
	public TradeInviteToCli message; // 0x18

	// Methods

	// RVA: 0xEE3C80 Offset: 0xEDFC80 VA: 0xEE3C80
	public void .ctor() { }

	// RVA: 0xEE59EC Offset: 0xEE19EC VA: 0xEE59EC
	internal void <ProtocolTradeRequest>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NotificationPc.<>c__DisplayClass24_1 // TypeDefIndex: 2843
{
	// Fields
	public NotificationPc.TemplateClass template; // 0x10
	public NotificationPc.<>c__DisplayClass24_0 CS$<>8__locals1; // 0x18

	// Methods

	// RVA: 0xEE5BB4 Offset: 0xEE1BB4 VA: 0xEE5BB4
	public void .ctor() { }

	// RVA: 0xEE5BBC Offset: 0xEE1BBC VA: 0xEE5BBC
	internal void <ProtocolTradeRequest>b__1() { }

	// RVA: 0xEE5D98 Offset: 0xEE1D98 VA: 0xEE5D98
	internal void <ProtocolTradeRequest>b__2() { }
}

// Namespace: game.ui
public class NotificationPc : MonoBehaviour // TypeDefIndex: 2844
{
	// Fields
	[SerializeField]
	private Image framedImage; // 0x20
	[SerializeField]
	private GameObject contentGo; // 0x28
	[SerializeField]
	private Button clearButton; // 0x30
	[SerializeField]
	private Button closeButton; // 0x38
	[SerializeField]
	private GameObject partyTemplateGo; // 0x40
	[SerializeField]
	private GameObject tongTemplateGo; // 0x48
	[SerializeField]
	private GameObject tradeTemplateGo; // 0x50
	[SerializeField]
	private GameObject friendlyTemplateGo; // 0x58
	private Queue<Action> onStartActions; // 0x60
	private bool isStarted; // 0x68
	private NotificationPc.TemplateClass partyTemplate; // 0x70
	private NotificationPc.TemplateClass tongTemplate; // 0x78
	private NotificationPc.TemplateClass tradeTemplate; // 0x80
	private NotificationPc.TemplateClass friendlyTemplate; // 0x88
	private List<NotificationPc.TemplateClass> listing; // 0x90

	// Methods

	// RVA: 0xEE2C08 Offset: 0xEDEC08 VA: 0xEE2C08
	private void Start() { }

	// RVA: 0xEE3300 Offset: 0xEDF300 VA: 0xEE3300
	private void Perform(Action action) { }

	// RVA: 0xEE33D0 Offset: 0xEDF3D0 VA: 0xEE33D0
	public void Open() { }

	// RVA: 0xEE33F4 Offset: 0xEDF3F4 VA: 0xEE33F4
	private void ListingAdd(NotificationPc.TemplateClass template) { }

	// RVA: 0xEE354C Offset: 0xEDF54C VA: 0xEE354C
	public void ProtocolFriendlyAddNotify(FriendlyAddNotify message) { }

	// RVA: 0xEE36A8 Offset: 0xEDF6A8 VA: 0xEE36A8
	public void ProtocolPartyInvite(PartyInvite message) { }

	// RVA: 0xEE3874 Offset: 0xEDF874 VA: 0xEE3874
	public void ProtocolPartyRequest(PartyRequest message) { }

	// RVA: 0xEE39D0 Offset: 0xEDF9D0 VA: 0xEE39D0
	public void ProtocolTongRequest(TongRequestField message) { }

	// RVA: 0xEE3B2C Offset: 0xEDFB2C VA: 0xEE3B2C
	public void ProtocolTradeRequest(TradeInviteToCli message) { }

	// RVA: 0xEE3C88 Offset: 0xEDFC88 VA: 0xEE3C88
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEE3C90 Offset: 0xEDFC90 VA: 0xEE3C90
	private void <Start>b__15_0() { }

	[CompilerGenerated]
	// RVA: 0xEE3D14 Offset: 0xEDFD14 VA: 0xEE3D14
	private void <Start>b__15_1() { }
}

// Namespace: game.ui
public class StandardConfirmPc : MonoBehaviour // TypeDefIndex: 2845
{
	// Fields
	[SerializeField]
	private Image framedImage; // 0x20
	[SerializeField]
	private TextMeshProUGUI titleTmp; // 0x28
	[SerializeField]
	private TextMeshProUGUI descriptionTmp; // 0x30
	[SerializeField]
	private Button confirmButton; // 0x38
	[SerializeField]
	private Button cancelButton; // 0x40
	private Action onConfirm; // 0x48
	private Action onCancel; // 0x50

	// Methods

	// RVA: 0xEE5FF8 Offset: 0xEE1FF8 VA: 0xEE5FF8
	private void Start() { }

	// RVA: 0xEDBFAC Offset: 0xED7FAC VA: 0xEDBFAC
	public void Open(string title, string notes, Action onConfirm, Action onCancel) { }

	// RVA: 0xEE6108 Offset: 0xEE2108 VA: 0xEE6108
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEE6110 Offset: 0xEE2110 VA: 0xEE6110
	private void <Start>b__7_0() { }

	[CompilerGenerated]
	// RVA: 0xEE61B8 Offset: 0xEE21B8 VA: 0xEE61B8
	private void <Start>b__7_1() { }
}

// Namespace: game.ui
public class StandardInputPc : MonoBehaviour // TypeDefIndex: 2846
{
	// Fields
	[SerializeField]
	private TextMeshProUGUI titleTmp; // 0x20
	[SerializeField]
	private TMP_InputField input; // 0x28
	[SerializeField]
	private TextMeshProUGUI placeHolder; // 0x30
	[SerializeField]
	private Button confirmButton; // 0x38
	[SerializeField]
	private Button cancelButton; // 0x40
	[SerializeField]
	private GameObject numpadGo; // 0x48
	[SerializeField]
	private Button numpadButtonConfirm; // 0x50
	[SerializeField]
	private Button numpadButtonCancel; // 0x58
	[SerializeField]
	private Button numpadButtonClear; // 0x60
	[SerializeField]
	private Button numpadButtonSpace; // 0x68
	[SerializeField]
	private Button numpadButton0; // 0x70
	[SerializeField]
	private Button numpadButton1; // 0x78
	[SerializeField]
	private Button numpadButton2; // 0x80
	[SerializeField]
	private Button numpadButton3; // 0x88
	[SerializeField]
	private Button numpadButton4; // 0x90
	[SerializeField]
	private Button numpadButton5; // 0x98
	[SerializeField]
	private Button numpadButton6; // 0xA0
	[SerializeField]
	private Button numpadButton7; // 0xA8
	[SerializeField]
	private Button numpadButton8; // 0xB0
	[SerializeField]
	private Button numpadButton9; // 0xB8
	private Action<string> onConfirm; // 0xC0
	private Action onCancel; // 0xC8
	private float numpadPressEffectFloat; // 0xD0
	private Button numpadPressEffectButton; // 0xD8
	private int requiredMinLength; // 0xE0
	private int requiredMaxLength; // 0xE4

	// Methods

	// RVA: 0xEE6260 Offset: 0xEE2260 VA: 0xEE6260
	private void Start() { }

	// RVA: 0xEE6A3C Offset: 0xEE2A3C VA: 0xEE6A3C
	private void Update() { }

	// RVA: 0xEE6B20 Offset: 0xEE2B20 VA: 0xEE6B20
	private void NumpadPressEffect(Button button, string value) { }

	// RVA: 0xEE67CC Offset: 0xEE27CC VA: 0xEE67CC
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xEE15CC Offset: 0xEDD5CC VA: 0xEE15CC
	public void Open(string title, string placeholder, bool openNumpad, int requiredMinLength, int requiredMaxLength, Action<string> onConfirm, Action onCancel, string defaultInput) { }

	// RVA: 0xEE6C88 Offset: 0xEE2C88 VA: 0xEE6C88
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEE6C98 Offset: 0xEE2C98 VA: 0xEE6C98
	private void <Start>b__26_0() { }

	[CompilerGenerated]
	// RVA: 0xEE6EBC Offset: 0xEE2EBC VA: 0xEE6EBC
	private void <Start>b__26_1() { }

	[CompilerGenerated]
	// RVA: 0xEE6F80 Offset: 0xEE2F80 VA: 0xEE6F80
	private void <Start>b__26_2() { }

	[CompilerGenerated]
	// RVA: 0xEE70D8 Offset: 0xEE30D8 VA: 0xEE70D8
	private void <Start>b__26_3() { }

	[CompilerGenerated]
	// RVA: 0xEE7124 Offset: 0xEE3124 VA: 0xEE7124
	private void <Start>b__26_4() { }

	[CompilerGenerated]
	// RVA: 0xEE7170 Offset: 0xEE3170 VA: 0xEE7170
	private void <Start>b__26_5() { }

	[CompilerGenerated]
	// RVA: 0xEE71BC Offset: 0xEE31BC VA: 0xEE71BC
	private void <Start>b__26_6() { }

	[CompilerGenerated]
	// RVA: 0xEE7208 Offset: 0xEE3208 VA: 0xEE7208
	private void <Start>b__26_7() { }

	[CompilerGenerated]
	// RVA: 0xEE7254 Offset: 0xEE3254 VA: 0xEE7254
	private void <Start>b__26_8() { }

	[CompilerGenerated]
	// RVA: 0xEE72A0 Offset: 0xEE32A0 VA: 0xEE72A0
	private void <Start>b__26_9() { }

	[CompilerGenerated]
	// RVA: 0xEE72EC Offset: 0xEE32EC VA: 0xEE72EC
	private void <Start>b__26_10() { }

	[CompilerGenerated]
	// RVA: 0xEE7338 Offset: 0xEE3338 VA: 0xEE7338
	private void <Start>b__26_11() { }

	[CompilerGenerated]
	// RVA: 0xEE7384 Offset: 0xEE3384 VA: 0xEE7384
	private void <Start>b__26_12() { }

	[CompilerGenerated]
	// RVA: 0xEE73D0 Offset: 0xEE33D0 VA: 0xEE73D0
	private void <Start>b__26_13() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class TopRightButtons.<>c // TypeDefIndex: 2847
{
	// Fields
	public static readonly TopRightButtons.<>c <>9; // 0x0
	public static UnityAction <>9__9_1; // 0x8
	public static UnityAction <>9__9_2; // 0x10
	public static UnityAction <>9__9_3; // 0x18
	public static UnityAction <>9__9_4; // 0x20
	public static UnityAction <>9__9_5; // 0x28

	// Methods

	// RVA: 0xEE7A3C Offset: 0xEE3A3C VA: 0xEE7A3C
	private static void .cctor() { }

	// RVA: 0xEE7AA4 Offset: 0xEE3AA4 VA: 0xEE7AA4
	public void .ctor() { }

	// RVA: 0xEE7AAC Offset: 0xEE3AAC VA: 0xEE7AAC
	internal void <Start>b__9_1() { }

	// RVA: 0xEE7BA4 Offset: 0xEE3BA4 VA: 0xEE7BA4
	internal void <Start>b__9_2() { }

	// RVA: 0xEE7C98 Offset: 0xEE3C98 VA: 0xEE7C98
	internal void <Start>b__9_3() { }

	// RVA: 0xEE7DC4 Offset: 0xEE3DC4 VA: 0xEE7DC4
	internal void <Start>b__9_4() { }

	// RVA: 0xEE7E8C Offset: 0xEE3E8C VA: 0xEE7E8C
	internal void <Start>b__9_5() { }
}

// Namespace: game.ui
public class TopRightButtons : MonoBehaviour // TypeDefIndex: 2848
{
	// Fields
	[SerializeField]
	public GameObject functionIconsGroup; // 0x20
	[SerializeField]
	public Button minimizeButton; // 0x28
	[SerializeField]
	public Image minimizeIcon; // 0x30
	[SerializeField]
	public Button buttonShopKnb; // 0x38
	[SerializeField]
	public Button buttonActivities; // 0x40
	[SerializeField]
	public Button buttonAutoConfig; // 0x48
	[SerializeField]
	public Button buttonSkillList; // 0x50
	[SerializeField]
	public Button buttonBangHoi; // 0x58
	private bool IsOpen; // 0x60

	// Methods

	// RVA: 0xEE741C Offset: 0xEE341C VA: 0xEE741C
	private void Start() { }

	// RVA: 0xEE7878 Offset: 0xEE3878 VA: 0xEE7878
	private void ApplyChildrenPCStyle(Transform transform) { }

	// RVA: 0xEE7800 Offset: 0xEE3800 VA: 0xEE7800
	private void ChangeUI(bool enabled) { }

	// RVA: 0xEE79B0 Offset: 0xEE39B0 VA: 0xEE79B0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEE79C0 Offset: 0xEE39C0 VA: 0xEE79C0
	private void <Start>b__9_0() { }
}

// Namespace: game.ui
public class UnMergeItemPc : MonoBehaviour // TypeDefIndex: 2849
{
	// Fields
	[SerializeField]
	private Image framedImage; // 0x20
	[SerializeField]
	private TextMeshProUGUI unName; // 0x28
	[SerializeField]
	private GameObject unItem; // 0x30
	[SerializeField]
	private Button unMinusButton; // 0x38
	[SerializeField]
	private Button unAddButton; // 0x40
	[SerializeField]
	private TextMeshProUGUI unInput; // 0x48
	[SerializeField]
	private Button unConfirmButton; // 0x50
	[SerializeField]
	private Button unCancelButton; // 0x58
	[SerializeField]
	private TextMeshProUGUI merDes; // 0x60
	[SerializeField]
	private Transform merItemContent; // 0x68
	[SerializeField]
	private GameObject merItemTemplateGo; // 0x70
	[SerializeField]
	private Button merButtonConfirm; // 0x78
	[SerializeField]
	private Image numpadFramed; // 0x80
	[SerializeField]
	private Button numpadButtonConfirm; // 0x88
	[SerializeField]
	private Button numpadButtonCancel; // 0x90
	[SerializeField]
	private Button numpadButtonSpace; // 0x98
	[SerializeField]
	private Button numpadButton0; // 0xA0
	[SerializeField]
	private Button numpadButton1; // 0xA8
	[SerializeField]
	private Button numpadButton2; // 0xB0
	[SerializeField]
	private Button numpadButton3; // 0xB8
	[SerializeField]
	private Button numpadButton4; // 0xC0
	[SerializeField]
	private Button numpadButton5; // 0xC8
	[SerializeField]
	private Button numpadButton6; // 0xD0
	[SerializeField]
	private Button numpadButton7; // 0xD8
	[SerializeField]
	private Button numpadButton8; // 0xE0
	[SerializeField]
	private Button numpadButton9; // 0xE8
	private Item item; // 0xF0
	private int quantityMaximun; // 0xF8
	private int quantityCurrently; // 0xFC
	private List<GameObject> merItemListingGo; // 0x100
	private float numpadPressEffectFloat; // 0x108
	private Button numpadPressEffectButton; // 0x110
	private string firstSetupDes; // 0x118

	// Methods

	// RVA: 0xEE7F94 Offset: 0xEE3F94 VA: 0xEE7F94
	private void Start() { }

	// RVA: 0xEE85EC Offset: 0xEE45EC VA: 0xEE85EC
	private void Update() { }

	// RVA: 0xEE86CC Offset: 0xEE46CC VA: 0xEE86CC
	private void NumpadPressEffect(Button button, string value) { }

	// RVA: 0xEE8924 Offset: 0xEE4924 VA: 0xEE8924
	private void Clear() { }

	// RVA: 0xEE8AC0 Offset: 0xEE4AC0 VA: 0xEE8AC0
	public void Open(Item item) { }

	// RVA: 0xEE9414 Offset: 0xEE5414 VA: 0xEE9414
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEE9424 Offset: 0xEE5424 VA: 0xEE9424
	private void <Start>b__32_0() { }

	[CompilerGenerated]
	// RVA: 0xEE950C Offset: 0xEE550C VA: 0xEE950C
	private void <Start>b__32_1() { }

	[CompilerGenerated]
	// RVA: 0xEE95F4 Offset: 0xEE55F4 VA: 0xEE95F4
	private void <Start>b__32_2() { }

	[CompilerGenerated]
	// RVA: 0xEE9718 Offset: 0xEE5718 VA: 0xEE9718
	private void <Start>b__32_3() { }

	[CompilerGenerated]
	// RVA: 0xEE97A4 Offset: 0xEE57A4 VA: 0xEE97A4
	private void <Start>b__32_4() { }

	[CompilerGenerated]
	// RVA: 0xEE98AC Offset: 0xEE58AC VA: 0xEE98AC
	private void <Start>b__32_5() { }

	[CompilerGenerated]
	// RVA: 0xEE98F8 Offset: 0xEE58F8 VA: 0xEE98F8
	private void <Start>b__32_6() { }

	[CompilerGenerated]
	// RVA: 0xEE9944 Offset: 0xEE5944 VA: 0xEE9944
	private void <Start>b__32_7() { }

	[CompilerGenerated]
	// RVA: 0xEE9990 Offset: 0xEE5990 VA: 0xEE9990
	private void <Start>b__32_8() { }

	[CompilerGenerated]
	// RVA: 0xEE99DC Offset: 0xEE59DC VA: 0xEE99DC
	private void <Start>b__32_9() { }

	[CompilerGenerated]
	// RVA: 0xEE9A28 Offset: 0xEE5A28 VA: 0xEE9A28
	private void <Start>b__32_10() { }

	[CompilerGenerated]
	// RVA: 0xEE9A74 Offset: 0xEE5A74 VA: 0xEE9A74
	private void <Start>b__32_11() { }

	[CompilerGenerated]
	// RVA: 0xEE9AC0 Offset: 0xEE5AC0 VA: 0xEE9AC0
	private void <Start>b__32_12() { }

	[CompilerGenerated]
	// RVA: 0xEE9B0C Offset: 0xEE5B0C VA: 0xEE9B0C
	private void <Start>b__32_13() { }

	[CompilerGenerated]
	// RVA: 0xEE9B58 Offset: 0xEE5B58 VA: 0xEE9B58
	private void <Start>b__32_14() { }

	[CompilerGenerated]
	// RVA: 0xEE9BA4 Offset: 0xEE5BA4 VA: 0xEE9BA4
	private void <Start>b__32_15() { }
}

// Namespace: game.ui
public class MessageBox : MonoBehaviour // TypeDefIndex: 2850
{
	// Fields
	[SerializeField]
	private Image framedImage; // 0x20
	[SerializeField]
	private TextMeshProUGUI contentText; // 0x28
	[SerializeField]
	private Button closeButton; // 0x30
	private bool onCloseLoadSceneDownload; // 0x38
	private GameObject backGo; // 0x40
	private Action onClose; // 0x48

	// Methods

	// RVA: 0xEE9BF0 Offset: 0xEE5BF0 VA: 0xEE9BF0
	private void Start() { }

	// RVA: 0xEE9CA8 Offset: 0xEE5CA8 VA: 0xEE9CA8
	public void OnClose() { }

	// RVA: 0xEE9E08 Offset: 0xEE5E08 VA: 0xEE9E08
	public void SetMessage(string mes, GameObject backgo, Action onStart, Action onClose) { }

	// RVA: 0xEE9F48 Offset: 0xEE5F48 VA: 0xEE9F48
	public void SetTitle(string title) { }

	// RVA: 0xEE9F4C Offset: 0xEE5F4C VA: 0xEE9F4C
	public void SetLoadSceneDownloadOnClose(string text) { }

	// RVA: 0xEE9F58 Offset: 0xEE5F58 VA: 0xEE9F58
	public void .ctor() { }
}

// Namespace: game.ui
public class SimpleLoading : MonoBehaviour // TypeDefIndex: 2851
{
	// Fields
	[SerializeField]
	private RectTransform rectComponent; // 0x20
	public float rotateSpeed; // 0x28

	// Methods

	// RVA: 0xEE9F60 Offset: 0xEE5F60 VA: 0xEE9F60
	private void Update() { }

	// RVA: 0xEE9FA0 Offset: 0xEE5FA0 VA: 0xEE9FA0
	public void .ctor() { }
}

// Namespace: game.ui
public class UIHelpers // TypeDefIndex: 2852
{
	// Methods

	// RVA: 0xEE9FB0 Offset: 0xEE5FB0 VA: 0xEE9FB0
	public static GameObject BringPrefabToScene(string prefab) { }

	// RVA: 0xEEA02C Offset: 0xEE602C VA: 0xEEA02C
	public static GameObject RessourcesLoadPrefab(string prefab) { }

	// RVA: 0xEEA0B4 Offset: 0xEE60B4 VA: 0xEEA0B4
	public static GameObject BringPrefabToScene(string prefab, float x, float y) { }

	// RVA: 0xEEA128 Offset: 0xEE6128 VA: 0xEEA128
	public static MessageBox BringMessageBox() { }

	// RVA: 0xEEA18C Offset: 0xEE618C VA: 0xEEA18C
	public void .ctor() { }
}
