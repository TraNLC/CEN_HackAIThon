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

// Namespace: game.scene
public class CharManager : BaseMonoBehaviour // TypeDefIndex: 2998
{
	// Fields
	[SerializeField]
	public World world; // 0x20
	[SerializeField]
	private GameObject goPlayerSelect; // 0x28
	[SerializeField]
	private PlayerMainMapBackground goPlayerMainMapBackground; // 0x30
	[SerializeField]
	private PlayerMainSkillRadius goPlayerMainSkillRadius; // 0x38
	[SerializeField]
	private PlayerMainSkillDirection goPlayerMainSkillDirection; // 0x40
	[SerializeField]
	private PlayerMainSkillPositionArea goPlayerMainSkillPosition; // 0x48
	public static CharManager instance; // 0x0
	public readonly ConcurrentDictionary<string, NpcRes.Special> players; // 0x50
	public readonly Dictionary<string, NpcRes.Special> salesmans; // 0x58

	// Methods

	// RVA: 0xF23790 Offset: 0xF1F790 VA: 0xF23790
	public void Initialize() { }

	// RVA: 0xF23868 Offset: 0xF1F868 VA: 0xF23868
	public void InstantiatePlayerMainComponent(PlayerMain playerMain, NpcRes.Special mainPlayer) { }

	// RVA: 0xF23A50 Offset: 0xF1FA50 VA: 0xF23A50
	public void UnloadUnusedAssets() { }

	// RVA: 0xF23A58 Offset: 0xF1FA58 VA: 0xF23A58
	private void PlayerSyncFields(ReadOnlySpan<byte> data) { }

	// RVA: 0xF23B48 Offset: 0xF1FB48 VA: 0xF23B48
	private void PlayerSalesmanRemove(ReadOnlySpan<byte> data) { }

	// RVA: 0xF23C14 Offset: 0xF1FC14 VA: 0xF23C14
	private void PlayerSalesmanAdd(ReadOnlySpan<byte> data) { }

	// RVA: 0xF2435C Offset: 0xF2035C VA: 0xF2435C
	private void PlayerTextDefense(ReadOnlySpan<byte> data) { }

	// RVA: 0xF244FC Offset: 0xF204FC VA: 0xF244FC
	private void PlayerTextMiss(ReadOnlySpan<byte> data) { }

	// RVA: 0xF245A4 Offset: 0xF205A4 VA: 0xF245A4
	private void SelfDefense(ReadOnlySpan<byte> data) { }

	// RVA: 0xF24650 Offset: 0xF20650 VA: 0xF24650
	private void SelfEvade(ReadOnlySpan<byte> data) { }

	// RVA: 0xF246FC Offset: 0xF206FC VA: 0xF246FC
	private void PlayerMoveStop(ReadOnlySpan<byte> data) { }

	// RVA: 0xF24994 Offset: 0xF20994 VA: 0xF24994
	private void PlayerMoveStart(ReadOnlySpan<byte> data) { }

	// RVA: 0xF24ABC Offset: 0xF20ABC VA: 0xF24ABC
	private void DestroyAllMapDot(ReadOnlySpan<byte> data) { }

	// RVA: 0xF24AE0 Offset: 0xF20AE0 VA: 0xF24AE0
	private void AddMapDot(ReadOnlySpan<byte> data) { }

	// RVA: 0xF24ED0 Offset: 0xF20ED0 VA: 0xF24ED0
	public void PlayerStateEffectList(ReadOnlySpan<byte> data) { }

	// RVA: 0xF24FBC Offset: 0xF20FBC VA: 0xF24FBC
	public void SelfMinistateSkillRemove(ReadOnlySpan<byte> data) { }

	// RVA: 0xF25050 Offset: 0xF21050 VA: 0xF25050
	public void SelfStateEffectRemove(ReadOnlySpan<byte> data) { }

	// RVA: 0xF25148 Offset: 0xF21148 VA: 0xF25148
	public void PlayerStateEffectRemove(ReadOnlySpan<byte> data) { }

	// RVA: 0xF251BC Offset: 0xF211BC VA: 0xF251BC
	public void PlayerStateEffectAdd(ReadOnlySpan<byte> data) { }

	// RVA: 0xF25234 Offset: 0xF21234 VA: 0xF25234
	public void RemoveMapPlayer(ReadOnlySpan<byte> data) { }

	// RVA: 0xF2533C Offset: 0xF2133C VA: 0xF2533C
	public void MinimapResetPlayerDot() { }

	// RVA: 0xF25360 Offset: 0xF21360 VA: 0xF25360
	public void PlayStateIdFunc(PlayStateId message) { }

	// RVA: 0xF25394 Offset: 0xF21394 VA: 0xF25394
	public void PlayStateSprFunc(PlayStateSpr message) { }

	// RVA: 0xF253CC Offset: 0xF213CC VA: 0xF253CC
	public void AllMagicAttribResponseFunc(AllMagicAttribResponse message) { }

	// RVA: 0xF25808 Offset: 0xF21808 VA: 0xF25808
	public void PlayerDeath(ReadOnlySpan<byte> data) { }

	// RVA: 0xF25C28 Offset: 0xF21C28 VA: 0xF25C28
	private void PlayerTeleport(ReadOnlySpan<byte> data) { }

	// RVA: 0xF25DA4 Offset: 0xF21DA4 VA: 0xF25DA4
	public void EnterMap() { }

	// RVA: 0xF25E18 Offset: 0xF21E18 VA: 0xF25E18
	public void CheckCamera(Controller npc, float top, float left) { }

	// RVA: 0xF25FD0 Offset: 0xF21FD0 VA: 0xF25FD0
	public void CastSkill(int id, int level, Params.Cast castParams, bool isNoAction = False) { }

	// RVA: 0xF25FF8 Offset: 0xF21FF8 VA: 0xF25FF8
	public void CastSkill(int id, int level, Controller launcher, Controller target) { }

	// RVA: 0xF2601C Offset: 0xF2201C VA: 0xF2601C
	public void CastSkill(int id, int level, Controller launcher, Position target) { }

	// RVA: 0xF26040 Offset: 0xF22040 VA: 0xF26040
	private void AddMapPlayer(ReadOnlySpan<byte> data) { }

	// RVA: 0xF24404 Offset: 0xF20404 VA: 0xF24404
	public NpcRes.Special GetSpecialPlayer(string cid) { }

	// RVA: 0xF267F8 Offset: 0xF227F8 VA: 0xF267F8
	public bool HasBarrier(Position position) { }

	// RVA: 0xF26834 Offset: 0xF22834 VA: 0xF26834
	public void CheckAllPlayerRelation(Controller source) { }

	// RVA: 0xF26B70 Offset: 0xF22B70 VA: 0xF26B70
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF26C4C Offset: 0xF22C4C VA: 0xF26C4C
	private void <Initialize>b__9_0(NetCoreManager net, byte[] data) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcManager.<>c__DisplayClass19_0 // TypeDefIndex: 2999
{
	// Fields
	public NpcRes.Normal controller; // 0x10

	// Methods

	// RVA: 0xF29548 Offset: 0xF25548 VA: 0xF29548
	public void .ctor() { }

	// RVA: 0xF297D4 Offset: 0xF257D4 VA: 0xF297D4
	internal void <NpcMoving>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcManager.<>c__DisplayClass20_0 // TypeDefIndex: 3000
{
	// Fields
	public NpcRes.Normal normalNpc; // 0x10
	public string name; // 0x18
	public string npcUid; // 0x20
	public NpcManager <>4__this; // 0x28

	// Methods

	// RVA: 0xF29550 Offset: 0xF25550 VA: 0xF29550
	public void .ctor() { }

	// RVA: 0xF29828 Offset: 0xF25828 VA: 0xF29828
	internal void <AddMapNpc>b__0() { }

	// RVA: 0xF29848 Offset: 0xF25848 VA: 0xF29848
	internal void <AddMapNpc>b__1() { }

	// RVA: 0xF29870 Offset: 0xF25870 VA: 0xF29870
	internal void <AddMapNpc>b__2() { }

	// RVA: 0xF298F0 Offset: 0xF258F0 VA: 0xF298F0
	internal void <AddMapNpc>b__3() { }

	// RVA: 0xF29A60 Offset: 0xF25A60 VA: 0xF29A60
	internal void <AddMapNpc>b__8() { }

	// RVA: 0xF29B08 Offset: 0xF25B08 VA: 0xF29B08
	internal void <AddMapNpc>b__9() { }

	// RVA: 0xF29BB0 Offset: 0xF25BB0 VA: 0xF29BB0
	internal void <AddMapNpc>b__10() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcManager.<>c__DisplayClass20_1 // TypeDefIndex: 3001
{
	// Fields
	public int requestSeries; // 0x10
	public int requestHealthPercent; // 0x14
	public int requestCamp; // 0x18
	public int requestStateStature; // 0x1C
	public NpcManager.<>c__DisplayClass20_0 CS$<>8__locals1; // 0x20

	// Methods

	// RVA: 0xF29558 Offset: 0xF25558 VA: 0xF29558
	public void .ctor() { }

	// RVA: 0xF29C04 Offset: 0xF25C04 VA: 0xF29C04
	internal void <AddMapNpc>b__4() { }

	// RVA: 0xF29C30 Offset: 0xF25C30 VA: 0xF29C30
	internal void <AddMapNpc>b__5() { }

	// RVA: 0xF29C5C Offset: 0xF25C5C VA: 0xF29C5C
	internal void <AddMapNpc>b__6() { }

	// RVA: 0xF29C88 Offset: 0xF25C88 VA: 0xF29C88
	internal void <AddMapNpc>b__7() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NpcManager.<>c__DisplayClass23_0 // TypeDefIndex: 3002
{
	// Fields
	public Object mapObject; // 0x10
	public AddMapObject addMapObject; // 0x18

	// Methods

	// RVA: 0xF296F0 Offset: 0xF256F0 VA: 0xF296F0
	public void .ctor() { }

	// RVA: 0xF29CB4 Offset: 0xF25CB4 VA: 0xF29CB4
	internal void <AddMapObject>b__0(Texture texture) { }
}

// Namespace: game.scene
public class NpcManager : BaseMonoBehaviour // TypeDefIndex: 3003
{
	// Fields
	[SerializeField]
	public World world; // 0x20
	[SerializeField]
	private GameObject goNpcSelect; // 0x28
	public static NpcManager instance; // 0x0
	public readonly ConcurrentDictionary<string, NpcRes.Normal> npcs; // 0x30
	public readonly ConcurrentDictionary<string, Object> objects; // 0x38

	// Methods

	// RVA: 0xF289DC Offset: 0xF249DC VA: 0xF289DC
	public void Initialize() { }

	// RVA: 0xF289E0 Offset: 0xF249E0 VA: 0xF289E0
	public void NpcDebugFunc(NpcDebug npcDebug) { }

	// RVA: 0xF289E4 Offset: 0xF249E4 VA: 0xF289E4
	private Controller FindPlayerByCid(string cid) { }

	// RVA: 0xF28A3C Offset: 0xF24A3C VA: 0xF28A3C
	public Controller FindNpcByNid(string nid) { }

	// RVA: 0xF27468 Offset: 0xF23468 VA: 0xF27468
	public void NpcStateEffectList(ReadOnlySpan<byte> data) { }

	// RVA: 0xF273A0 Offset: 0xF233A0 VA: 0xF273A0
	public void NpcStateEffectRemove(ReadOnlySpan<byte> data) { }

	// RVA: 0xF272D4 Offset: 0xF232D4 VA: 0xF272D4
	public void NpcStateEffectAdd(ReadOnlySpan<byte> data) { }

	// RVA: 0xF28338 Offset: 0xF24338 VA: 0xF28338
	public void NpcStateStature(ReadOnlySpan<byte> data) { }

	// RVA: 0xF28AB4 Offset: 0xF24AB4 VA: 0xF28AB4
	public void EnterMap() { }

	// RVA: 0xF28400 Offset: 0xF24400 VA: 0xF28400
	public void NpcHealthPercent(ReadOnlySpan<byte> data) { }

	// RVA: 0xF27598 Offset: 0xF23598 VA: 0xF27598
	public void NpcAddHealth(ReadOnlySpan<byte> data) { }

	// RVA: 0xF281B4 Offset: 0xF241B4 VA: 0xF281B4
	public void NpcReceiveDamage(ReadOnlySpan<byte> data) { }

	// RVA: 0xF28D00 Offset: 0xF24D00 VA: 0xF28D00
	public void CastSkillFunc(CastSkill message) { }

	// RVA: 0xF29090 Offset: 0xF25090 VA: 0xF29090
	public void MapRegionObstacle(MapRegionObstacle mapNodeObstacle) { }

	// RVA: 0xF28034 Offset: 0xF24034 VA: 0xF28034
	public void NpcMoving(ReadOnlySpan<byte> data) { }

	// RVA: 0xF277B8 Offset: 0xF237B8 VA: 0xF277B8
	public void AddMapNpc(ReadOnlySpan<byte> data) { }

	// RVA: 0xF28B28 Offset: 0xF24B28 VA: 0xF28B28
	public void DeathNpc(string id) { }

	// RVA: 0xF27F3C Offset: 0xF23F3C VA: 0xF27F3C
	public void RemoveNpc(ReadOnlySpan<byte> data) { }

	// RVA: 0xF29578 Offset: 0xF25578 VA: 0xF29578
	public void AddMapObject(AddMapObject addMapObject) { }

	// RVA: 0xF27704 Offset: 0xF23704 VA: 0xF27704
	public void RemoveMapObject(ReadOnlySpan<byte> data) { }

	// RVA: 0xF296F8 Offset: 0xF256F8 VA: 0xF296F8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class World.<>c // TypeDefIndex: 3004
{
	// Fields
	public static readonly World.<>c <>9; // 0x0
	public static Action <>9__15_0; // 0x8

	// Methods

	// RVA: 0xF2CA68 Offset: 0xF28A68 VA: 0xF2CA68
	private static void .cctor() { }

	// RVA: 0xF2CAD0 Offset: 0xF28AD0 VA: 0xF2CAD0
	public void .ctor() { }

	// RVA: 0xF2CAD8 Offset: 0xF28AD8 VA: 0xF2CAD8
	internal void <Release>b__15_0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class World.<>c__DisplayClass18_0 // TypeDefIndex: 3005
{
	// Fields
	public string typeName; // 0x10

	// Methods

	// RVA: 0xF2BFD4 Offset: 0xF27FD4 VA: 0xF2BFD4
	public void .ctor() { }

	// RVA: 0xF2CB54 Offset: 0xF28B54 VA: 0xF2CB54
	internal void <SetMovingTypeName>b__0() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class World.<>c__DisplayClass40_0 // TypeDefIndex: 3006
{
	// Fields
	public Action onFinish; // 0x10
	public World <>4__this; // 0x18
	public int top; // 0x20
	public int left; // 0x24

	// Methods

	// RVA: 0xF2C5E4 Offset: 0xF285E4 VA: 0xF2C5E4
	public void .ctor() { }

	// RVA: 0xF2CBC8 Offset: 0xF28BC8 VA: 0xF2CBC8
	internal void <EnterMap>b__0() { }

	// RVA: 0xF2CC34 Offset: 0xF28C34 VA: 0xF2CC34
	internal void <EnterMap>b__1() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class World.<>c__DisplayClass41_0 // TypeDefIndex: 3007
{
	// Fields
	public Action onFinish; // 0x10
	public World <>4__this; // 0x18
	public int top; // 0x20
	public int left; // 0x24

	// Methods

	// RVA: 0xF2C7C0 Offset: 0xF287C0 VA: 0xF2C7C0
	public void .ctor() { }

	// RVA: 0xF2CCCC Offset: 0xF28CCC VA: 0xF2CCCC
	internal void <TeleportSynchronous>b__0() { }
}

// Namespace: game.scene
public class World : MonoBehaviour // TypeDefIndex: 3008
{
	// Fields
	[SerializeField]
	public CharManager charManager; // 0x20
	[SerializeField]
	public NpcManager npcManager; // 0x28
	[SerializeField]
	public MainCanvas mainCanvas; // 0x30
	[SerializeField]
	public PopUpCanvas popupCanvas; // 0x38
	[HideInInspector]
	public PlayerMain playerMain; // 0x40
	public Camera mainCamera; // 0x48
	public NpcRes.Special mainPlayer; // 0x50
	public Map map; // 0x58
	private long runingLastSendMessageFrame; // 0x60
	private bool runingMainPlayerAction; // 0x68
	private float runingLatestSpeed; // 0x6C

	// Methods

	// RVA: 0xF29F8C Offset: 0xF25F8C VA: 0xF29F8C
	private void Start() { }

	// RVA: 0xF2B3B8 Offset: 0xF273B8 VA: 0xF2B3B8
	private void Update() { }

	// RVA: 0xF2BDD8 Offset: 0xF27DD8 VA: 0xF2BDD8
	private void OnDestroy() { }

	// RVA: 0xF2B3DC Offset: 0xF273DC VA: 0xF2B3DC
	private void Update_ServeMove() { }

	// RVA: 0xF2BE1C Offset: 0xF27E1C VA: 0xF2BE1C
	public void Release(string source) { }

	// RVA: 0xF2A8DC Offset: 0xF268DC VA: 0xF2A8DC
	public void SetCameraSize(float size) { }

	// RVA: 0xF2AA94 Offset: 0xF26A94 VA: 0xF2AA94
	public void SetFPS(int fps) { }

	// RVA: 0xF2AB1C Offset: 0xF26B1C VA: 0xF2AB1C
	public void SetMovingTypeName(string typeName) { }

	// RVA: 0xF2AF30 Offset: 0xF26F30 VA: 0xF2AF30
	public void SetLimitNpcRenderCount(int limitCount, bool updateUi = True) { }

	// RVA: 0xF2AFBC Offset: 0xF26FBC VA: 0xF2AFBC
	public void SetLimitNpcRenderTypePlayer(bool renderPlayer, bool updateUi = True) { }

	// RVA: 0xF2B058 Offset: 0xF27058 VA: 0xF2B058
	public void SetLimitNpcRenderTypeNpc(bool renderNpc, bool updateUi = True) { }

	// RVA: 0xF2AC80 Offset: 0xF26C80 VA: 0xF2AC80
	public void SetVibrateLevel(Vibration.Level level, bool updateUi = True) { }

	// RVA: 0xF2AD14 Offset: 0xF26D14 VA: 0xF2AD14
	public void SetVibrateEnableOnReceiveDamage(bool enabled, bool updateUi = True) { }

	// RVA: 0xF2ADC8 Offset: 0xF26DC8 VA: 0xF2ADC8
	public void SetVibrateEnableOnCollideSkill(bool enabled, bool updateUi = True) { }

	// RVA: 0xF2AE7C Offset: 0xF26E7C VA: 0xF2AE7C
	public void SetVibrateEnableOnCastSkill(bool enabled, bool updateUi = True) { }

	// RVA: 0xF2BFDC Offset: 0xF27FDC VA: 0xF2BFDC
	public void SetMapBackgroundEnabled(bool enabled) { }

	// RVA: 0xF2C0D0 Offset: 0xF280D0 VA: 0xF2C0D0
	public void SetMapGroundNodeEnabled(bool enabled) { }

	// RVA: 0xF2C120 Offset: 0xF28120 VA: 0xF2C120
	public void SetMapGroundObjectEnabled(bool enabled) { }

	// RVA: 0xF2C17C Offset: 0xF2817C VA: 0xF2C17C
	public void SetMapTreeEnabled(bool enabled) { }

	// RVA: 0xF2C1D0 Offset: 0xF281D0 VA: 0xF2C1D0
	public void SetMapBuildingEnabled(bool enabled) { }

	// RVA: 0xF2C220 Offset: 0xF28220 VA: 0xF2C220
	public void SetMapObstacleGridEnabled(bool enabled) { }

	// RVA: 0xF2C270 Offset: 0xF28270 VA: 0xF2C270
	public void SetMapTrapGridEnable(bool enabled) { }

	// RVA: 0xF2C354 Offset: 0xF28354 VA: 0xF2C354
	public void SetIdentifyNpcTitleEnabled(bool enabled) { }

	// RVA: 0xF2C384 Offset: 0xF28384 VA: 0xF2C384
	public void SetIdentifyNpcTongEnabled(bool enabled) { }

	// RVA: 0xF2C3BC Offset: 0xF283BC VA: 0xF2C3BC
	public void SetIdentifyNpcNameEnabled(bool enabled) { }

	// RVA: 0xF2C3F4 Offset: 0xF283F4 VA: 0xF2C3F4
	public void SetIdentifyNpcLifeEnabled(bool enabled) { }

	// RVA: 0xF2C42C Offset: 0xF2842C VA: 0xF2C42C
	public void SetIdentifyDroppingName(bool enabled) { }

	// RVA: 0xF2C460 Offset: 0xF28460 VA: 0xF2C460
	public void SetIdentifyNpcMapPos(bool enabled) { }

	// RVA: 0xF2C498 Offset: 0xF28498 VA: 0xF2C498
	public void OnLogoutButtonClick(string source) { }

	// RVA: 0xF2B0F4 Offset: 0xF270F4 VA: 0xF2B0F4
	public void EnterMap(int mapId, int top, int left, Action onFinish) { }

	// RVA: 0xF2C63C Offset: 0xF2863C VA: 0xF2C63C
	public void TeleportSynchronous(int top, int left, Action onFinish) { }

	// RVA: 0xF25EEC Offset: 0xF21EEC VA: 0xF25EEC
	public void TeleportImmediate(float top, float left) { }

	// RVA: 0xF2C7C8 Offset: 0xF287C8 VA: 0xF2C7C8
	public void AddMapMixture(GameObject go) { }

	// RVA: 0xF24344 Offset: 0xF20344 VA: 0xF24344
	public void AddDynamicNpc(NpcRes.Special specialNpc) { }

	// RVA: 0xF29560 Offset: 0xF25560 VA: 0xF29560
	public void AddDynamicNpc(NpcRes.Normal normalNpc) { }

	// RVA: 0xF23BFC Offset: 0xF1FBFC VA: 0xF23BFC
	public void RemoveNpc(Controller npc) { }

	// RVA: 0xF2681C Offset: 0xF2281C VA: 0xF2681C
	public bool HasBarrier(Position position) { }

	// RVA: 0xF2C7E0 Offset: 0xF287E0 VA: 0xF2C7E0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xF2C7E8 Offset: 0xF287E8 VA: 0xF2C7E8
	private void <Start>b__11_0() { }

	[CompilerGenerated]
	// RVA: 0xF2C964 Offset: 0xF28964 VA: 0xF2C964
	private void <SetCameraSize>b__16_0() { }

	[CompilerGenerated]
	// RVA: 0xF2C9D8 Offset: 0xF289D8 VA: 0xF2C9D8
	private void <SetMapBackgroundEnabled>b__26_0() { }
}
