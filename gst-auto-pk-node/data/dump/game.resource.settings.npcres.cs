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

// Namespace: game.resource.settings.npcres
public class Controller // TypeDefIndex: 2250
{
	// Fields
	public readonly Position position; // 0x10
	public readonly State state; // 0x18
	public readonly Shape shape; // 0x20
	public readonly Identification identify; // 0x28
	public readonly Datafield data; // 0x30
	public readonly Controller.AnimateHandler animateHandler; // 0x38
	private readonly Controller.AnimateParams animateCurrently; // 0x40
	private readonly Controller.AnimateParams animateFuture; // 0x48
	private readonly Controller.PerformEachFrameC performEachFrame; // 0x50
	protected bool isSpecialNpc; // 0x58
	private bool isPauseAnimate; // 0x59
	public bool isNoTextures; // 0x5A
	private bool isIdentifierVisibled; // 0x5B
	private bool isWaitingForApplyTextures; // 0x5C
	public bool isStateVisibled; // 0x5D
	public bool isWaitingForApplyState; // 0x5E
	public int stateStatureCold; // 0x60
	public int stateStaturePoison; // 0x64
	public int stateStatureStun; // 0x68
	public int stateStatureHurt; // 0x6C
	public int stateStatureRandmove; // 0x70
	private float stateStatureStealthAlpha; // 0x74
	private bool isStealthing; // 0x78
	private Controller.Trail trail; // 0x80
	private Controller.JumpHeight jumpHeight; // 0x88
	public PlayerOther otherPlayerBehaviour; // 0x90
	public NpcController otherNpcBehaviour; // 0x98
	public Character character; // 0xA0
	private ushort onupdateCurrentFrameIndex; // 0xA8
	private ushort onupdateEndFrameIndex; // 0xAA
	private GameObject onupdateTrailCurrent; // 0xB0
	private float onupdateJumheightOffsetY; // 0xB8
	private Shape.PartFields onupdatePart; // 0xC0
	private Shape.PartFrame onupdateFrameData; // 0xC8
	private bool onupdateFrameIndexHasTaked; // 0xD0
	private bool onupdateFrameIndexHasCleared; // 0xD1
	private ushort onupdateFrameIndexTaked; // 0xD2

	// Methods

	// RVA: 0xFB41F4 Offset: 0xFB01F4 VA: 0xFB41F4
	protected void .ctor() { }

	// RVA: 0xFB4C54 Offset: 0xFB0C54 VA: 0xFB4C54
	protected void InitForSpecial(int headIndex = 19, int bodyIndex = 19, int weaponIndex = 1, int horseIndex = -1) { }

	// RVA: 0xFB4D00 Offset: 0xFB0D00 VA: 0xFB4D00
	protected void InitForNormal() { }

	// RVA: 0xFB4D78 Offset: 0xFB0D78 VA: 0xFB4D78
	protected void InitForNormal(int npcDeclareLine) { }

	// RVA: 0xFB4E00 Offset: 0xFB0E00 VA: 0xFB4E00
	public void Destroy() { }

	// RVA: 0xFB51E0 Offset: 0xFB11E0 VA: 0xFB51E0
	public void Activate() { }

	// RVA: 0xFB5384 Offset: 0xFB1384 VA: 0xFB5384
	private void Update_NoTextures() { }

	// RVA: 0xFB5624 Offset: 0xFB1624 VA: 0xFB5624
	private void Update_WithTextures() { }

	// RVA: 0xFB6994 Offset: 0xFB2994 VA: 0xFB6994
	public void Update() { }

	// RVA: 0xFB6EFC Offset: 0xFB2EFC VA: 0xFB6EFC
	public void SetStealth(int isStealth, bool isMainPlayer, bool isShowOff) { }

	// RVA: 0xFB745C Offset: 0xFB345C VA: 0xFB745C
	public void SetStealthingNow() { }

	// RVA: 0xFB7548 Offset: 0xFB3548 VA: 0xFB7548
	public bool IsStealthing() { }

	// RVA: 0xFB7550 Offset: 0xFB3550 VA: 0xFB7550
	public bool IsJumping() { }

	// RVA: 0xFB7568 Offset: 0xFB3568 VA: 0xFB7568
	public bool IsRiding() { }

	// RVA: 0xFB7588 Offset: 0xFB3588 VA: 0xFB7588
	public bool IsSpecialNpc() { }

	// RVA: 0xFB7590 Offset: 0xFB3590 VA: 0xFB7590
	public void SetDirection(int _direction) { }

	// RVA: 0xFB75D0 Offset: 0xFB35D0 VA: 0xFB75D0
	public string GetNpcResType() { }

	// RVA: 0xFB7614 Offset: 0xFB3614 VA: 0xFB7614
	public int GetDirection() { }

	// RVA: 0xFB7660 Offset: 0xFB3660 VA: 0xFB7660
	public bool IsActionFuturedAttacking() { }

	// RVA: 0xFB771C Offset: 0xFB371C VA: 0xFB771C
	public bool IsActionFuturedDieing() { }

	// RVA: 0xFB7774 Offset: 0xFB3774 VA: 0xFB7774
	public bool IsActionFuturedJumping() { }

	// RVA: 0xFB77CC Offset: 0xFB37CC VA: 0xFB77CC
	public bool IsActionFuturedWound() { }

	// RVA: 0xFB7824 Offset: 0xFB3824 VA: 0xFB7824
	public bool IsActionCurrentlyWound() { }

	// RVA: 0xFB787C Offset: 0xFB387C VA: 0xFB787C
	public void SetAction(string actionName) { }

	// RVA: 0xFB7894 Offset: 0xFB3894 VA: 0xFB7894
	public void SetAction(string actionName, Action onActionEnd) { }

	// RVA: 0xFB7914 Offset: 0xFB3914 VA: 0xFB7914
	public void ActionEndTemplateFightStand() { }

	// RVA: 0xFB7998 Offset: 0xFB3998 VA: 0xFB7998
	public void ActionEndTemplateRemoveOutWorld() { }

	// RVA: 0xFB79FC Offset: 0xFB39FC VA: 0xFB79FC
	public void ActionEndTemplateStopAnimation() { }

	// RVA: 0xFB7A08 Offset: 0xFB3A08 VA: 0xFB7A08
	public void ResetAnimateFrameCurrently() { }

	// RVA: 0xFB7978 Offset: 0xFB3978 VA: 0xFB7978
	public void SetAnimateInterval(float intervalOn18Fps) { }

	// RVA: 0xFB7A28 Offset: 0xFB3A28 VA: 0xFB7A28
	public void ActiveTrails(float lifeFrameOn18fps, bool randomFrame = False, float loopCreateTime = 0.04, float lifeTime = 0.5, float colorAlpha = 0.5) { }

	// RVA: 0xFB55BC Offset: 0xFB15BC VA: 0xFB55BC
	public void ResetNpcPate() { }

	// RVA: 0xFB7B34 Offset: 0xFB3B34 VA: 0xFB7B34
	public void SetStateVisibled(bool visibled) { }

	// RVA: 0xFB7B54 Offset: 0xFB3B54 VA: 0xFB7B54
	public void SetNoTextures(bool isNoTextures) { }

	// RVA: 0xFB7C38 Offset: 0xFB3C38 VA: 0xFB7C38
	public void SetIdentifierVisibled(bool visibled) { }

	// RVA: 0xFB7C58 Offset: 0xFB3C58 VA: 0xFB7C58
	public bool IsAffectedStandStill() { }

	// RVA: 0xFB7C88 Offset: 0xFB3C88 VA: 0xFB7C88
	public bool IsJoystickFollowing() { }

	// RVA: 0xFB7CA0 Offset: 0xFB3CA0 VA: 0xFB7CA0
	public void SetJoystickFollowing(bool isJoystickFollowing) { }

	// RVA: 0xFB7CBC Offset: 0xFB3CBC VA: 0xFB7CBC
	public void Jump(Position targetPosition, int radius) { }

	// RVA: 0xFB80A4 Offset: 0xFB40A4 VA: 0xFB80A4
	public void RunWithTime(Position targetPosition, float maxframe18fps, float speed, Action onFinish) { }

	// RVA: 0xFB81AC Offset: 0xFB41AC VA: 0xFB81AC
	public void SetPlayerDestinatePassivity(int top, int left, float speed, Action<Vector2> onRun, int forceDirection = 0, bool checkAudio = False, bool dontSetAction = False) { }

	// RVA: 0xFB84AC Offset: 0xFB44AC VA: 0xFB84AC
	public void SetNpcDestinatePassivity(int top, int left, float speed) { }

	// RVA: 0xFB8680 Offset: 0xFB4680 VA: 0xFB8680
	public void SetPlayerOnScheduleDoneOnce(Action action) { }

	// RVA: 0xFB8700 Offset: 0xFB4700 VA: 0xFB8700
	public void SetNpcOnScheduleDoneOnce(Action action) { }

	// RVA: 0xFB8780 Offset: 0xFB4780 VA: 0xFB8780
	public bool IsRunPosScheduling() { }

	// RVA: 0xFB87E8 Offset: 0xFB47E8 VA: 0xFB87E8
	public void ClearRunPosSchedule() { }

	// RVA: 0xFB8854 Offset: 0xFB4854 VA: 0xFB8854
	public void SetMapPosition(Position _position) { }

	// RVA: 0xFB8880 Offset: 0xFB4880 VA: 0xFB8880
	public void SetMapPosition(int _top, int _left) { }

	// RVA: 0xFB89C8 Offset: 0xFB49C8 VA: 0xFB89C8
	public void SetMapPositionFloat(float _top, float _left) { }

	// RVA: 0xFB8B34 Offset: 0xFB4B34 VA: 0xFB8B34
	public Position GetMapPosition() { }

	// RVA: 0xFB8BA8 Offset: 0xFB4BA8 VA: 0xFB8BA8
	public Vector2 GetMapPositionFloat() { }

	// RVA: 0xFB8BC0 Offset: 0xFB4BC0 VA: 0xFB8BC0
	public Vector3 GetScenePosition() { }

	// RVA: 0xFB8BDC Offset: 0xFB4BDC VA: 0xFB8BDC
	public Vector3 GetCameraPosition() { }

	// RVA: 0xFB8BF8 Offset: 0xFB4BF8 VA: 0xFB8BF8
	public int GetOrderInMap() { }

	// RVA: 0xFB8C10 Offset: 0xFB4C10 VA: 0xFB8C10
	public void SetHealthMaximum(int max) { }

	// RVA: 0xFB8C28 Offset: 0xFB4C28 VA: 0xFB8C28
	public void SetHealthCurrently(int current) { }

	// RVA: 0xFB8C68 Offset: 0xFB4C68 VA: 0xFB8C68
	public int GetHealthCurrently() { }

	// RVA: 0xFB8C80 Offset: 0xFB4C80 VA: 0xFB8C80
	public int GetHealthMaximum() { }

	// RVA: 0xFB8C98 Offset: 0xFB4C98 VA: 0xFB8C98
	public int GetHealthPercent() { }

	// RVA: 0xFB8CD0 Offset: 0xFB4CD0 VA: 0xFB8CD0
	public int GetManaMaximum() { }

	// RVA: 0xFB8CE8 Offset: 0xFB4CE8 VA: 0xFB8CE8
	public int GetManaCurrently() { }

	// RVA: 0xFB8D00 Offset: 0xFB4D00 VA: 0xFB8D00
	public void SetName(string name) { }

	// RVA: 0xFB9004 Offset: 0xFB5004 VA: 0xFB9004
	public string GetName() { }

	// RVA: 0xFB901C Offset: 0xFB501C VA: 0xFB901C
	public void SetLevel(int level) { }

	// RVA: 0xFB9034 Offset: 0xFB5034 VA: 0xFB9034
	public int GetLevel() { }

	// RVA: 0xFB904C Offset: 0xFB504C VA: 0xFB904C
	public void SetNameColor(Color color) { }

	// RVA: 0xFB908C Offset: 0xFB508C VA: 0xFB908C
	public void SetSeries(int series) { }

	// RVA: 0xFB91EC Offset: 0xFB51EC VA: 0xFB91EC
	public int GetSeries() { }

	// RVA: 0xFB9204 Offset: 0xFB5204 VA: 0xFB9204
	public void SetTong(string tongName) { }

	// RVA: 0xFB9390 Offset: 0xFB5390 VA: 0xFB9390
	public void SetTitle(string title) { }

	// RVA: 0xFB959C Offset: 0xFB559C VA: 0xFB959C
	public string GetTitle() { }

	// RVA: 0xFB95B4 Offset: 0xFB55B4 VA: 0xFB95B4
	public void SetCamp(int camp) { }

	// RVA: 0xFB97B4 Offset: 0xFB57B4 VA: 0xFB97B4
	public void SetCampValue(int camp) { }

	// RVA: 0xFB97CC Offset: 0xFB57CC VA: 0xFB97CC
	public int GetCamp() { }

	// RVA: 0xFB97E4 Offset: 0xFB57E4 VA: 0xFB97E4
	public int GetCampCurrently() { }

	// RVA: 0xFB97FC Offset: 0xFB57FC VA: 0xFB97FC
	public void SetFightState(int fightState) { }

	// RVA: 0xFB9894 Offset: 0xFB5894 VA: 0xFB9894
	public int GetFightState() { }

	// RVA: 0xFB98AC Offset: 0xFB58AC VA: 0xFB98AC
	public void SetPkState(int pkstate) { }

	// RVA: 0xFB98D4 Offset: 0xFB58D4 VA: 0xFB98D4
	public int GetPkState() { }

	// RVA: 0xFB98EC Offset: 0xFB58EC VA: 0xFB98EC
	public void SetRunSpeed(int speed, bool isRiding) { }

	// RVA: 0xFB9978 Offset: 0xFB5978 VA: 0xFB9978
	public int GetRunSpeed() { }

	// RVA: 0xFB9990 Offset: 0xFB5990 VA: 0xFB9990
	public float GetRunInterval() { }

	// RVA: 0xFB99A8 Offset: 0xFB59A8 VA: 0xFB99A8
	public float CalculateAttackInterval(float speed) { }

	// RVA: 0xFB9A24 Offset: 0xFB5A24 VA: 0xFB9A24
	public void SetAttackSpeed(int speed) { }

	// RVA: 0xFB9A48 Offset: 0xFB5A48 VA: 0xFB9A48
	public float GetAttackInterval() { }

	// RVA: 0xFB9A60 Offset: 0xFB5A60 VA: 0xFB9A60
	public float CalculateCastInterval(float speed) { }

	// RVA: 0xFB9ADC Offset: 0xFB5ADC VA: 0xFB9ADC
	public void SetCastSpeed(int speed) { }

	// RVA: 0xFB9B00 Offset: 0xFB5B00 VA: 0xFB9B00
	public float GetCastInterval() { }

	// RVA: 0xFB9B18 Offset: 0xFB5B18 VA: 0xFB9B18
	public void SetCid(string cid) { }

	// RVA: 0xFB9B30 Offset: 0xFB5B30 VA: 0xFB9B30
	public string GetCid() { }

	// RVA: 0xFB9B48 Offset: 0xFB5B48 VA: 0xFB9B48
	public void SetIndex(int index) { }

	// RVA: 0xFB9B60 Offset: 0xFB5B60 VA: 0xFB9B60
	public int GetIndex() { }

	// RVA: 0xFB9B78 Offset: 0xFB5B78 VA: 0xFB9B78
	public void SetSalesmanTitle(string title) { }

	// RVA: 0xFB9D28 Offset: 0xFB5D28 VA: 0xFB9D28
	public void SetBubbleTalk(string mes) { }

	// RVA: 0xFB7FB4 Offset: 0xFB3FB4 VA: 0xFB7FB4
	public bool IsMySelf(Controller player) { }

	// RVA: 0xFB9ECC Offset: 0xFB5ECC VA: 0xFB9ECC
	private static int CheckRelationNpcNpc(Controller npc, Controller other) { }

	// RVA: 0xFB9F54 Offset: 0xFB5F54 VA: 0xFB9F54
	private static int CheckRelationNpcPlayer(Controller npc, Controller player) { }

	// RVA: 0xFB9F64 Offset: 0xFB5F64 VA: 0xFB9F64
	private static int CheckRelationPlayerNpc(Controller player, Controller npc) { }

	// RVA: 0xFB9FD8 Offset: 0xFB5FD8 VA: 0xFB9FD8
	private static int CheckRelationPlayerPlayer(Controller player, Controller other) { }

	// RVA: 0xFBA124 Offset: 0xFB6124 VA: 0xFBA124
	public int CheckRelation(Controller other) { }

	// RVA: 0xFB80B8 Offset: 0xFB40B8 VA: 0xFB80B8
	public void SetAllStateVisibility(bool visibled) { }

	// RVA: 0xFBA294 Offset: 0xFB6294 VA: 0xFBA294
	public bool HaveStateId(int stateId) { }

	// RVA: 0xFBA324 Offset: 0xFB6324 VA: 0xFBA324
	public void AddStateSetting(int stateId, int leftTime) { }

	// RVA: 0xFBA404 Offset: 0xFB6404 VA: 0xFBA404
	public void RemoveStateSetting(int stateId) { }

	// RVA: 0xFBA48C Offset: 0xFB648C VA: 0xFBA48C
	public void AddStateIdLoop(int stateid, int looptimes) { }

	// RVA: 0xFB7434 Offset: 0xFB3434 VA: 0xFB7434
	public void AddStateOnce(string sprPath, int looptimes = 1) { }

	// RVA: 0xFBA5B0 Offset: 0xFB65B0 VA: 0xFBA5B0
	public void AddStateReceivedCriticalDamage(int damage) { }

	// RVA: 0xFBA698 Offset: 0xFB6698 VA: 0xFBA698
	public void AddStateReceivedNormalDamage(int damage) { }

	// RVA: 0xFBA7BC Offset: 0xFB67BC VA: 0xFBA7BC
	public void AddStateReceivedAppendDamage(int damage) { }

	// RVA: 0xFBA7EC Offset: 0xFB67EC VA: 0xFBA7EC
	public void AddStateTextEXP(long exp) { }

	// RVA: 0xFBA8F4 Offset: 0xFB68F4 VA: 0xFBA8F4
	public void AddTextBounce(string data, int colorHex = 16777215, int form = 0, int iscritical = 0) { }

	// RVA: 0xFBAA34 Offset: 0xFB6A34 VA: 0xFBAA34
	public void AddStateTextHealth(int value) { }

	// RVA: 0xFBAB28 Offset: 0xFB6B28 VA: 0xFBAB28
	public void AddStateTextEvade() { }

	// RVA: 0xFBAC24 Offset: 0xFB6C24 VA: 0xFBAC24
	public void AddStateTextMiss() { }

	// RVA: 0xFBAD20 Offset: 0xFB6D20 VA: 0xFBAD20
	public void AddTextDefense() { }

	// RVA: 0xFBAE1C Offset: 0xFB6E1C VA: 0xFBAE1C
	public int SetStateStatureCold(int intervalOn18Fps) { }

	// RVA: 0xFBAE2C Offset: 0xFB6E2C VA: 0xFBAE2C
	public int SetStateStaturePoison(int intervalOn18Fps) { }

	// RVA: 0xFBAE3C Offset: 0xFB6E3C VA: 0xFBAE3C
	public int SetStateStatureStun(int intervalOn18Fps) { }

	// RVA: 0xFBAED0 Offset: 0xFB6ED0 VA: 0xFBAED0
	public int SetStateStatureHurt(int intervalOn18Fps) { }

	// RVA: 0xFBB138 Offset: 0xFB7138 VA: 0xFBB138
	public void SetStateStatureColor(Color color) { }

	// RVA: 0xFB71E8 Offset: 0xFB31E8 VA: 0xFB71E8
	public void SetStateStatureAlpha(float alpha) { }

	// RVA: 0xFBB340 Offset: 0xFB7340 VA: 0xFBB340
	public void SetStateStature(int data) { }

	// RVA: 0xFBB6D0 Offset: 0xFB76D0 VA: 0xFBB6D0
	public void ClearStateStature() { }

	// RVA: 0xFBB6D8 Offset: 0xFB76D8 VA: 0xFBB6D8
	public void ClearStateEffect(bool ignorePermanent = False) { }

	// RVA: 0xFBB818 Offset: 0xFB7818 VA: 0xFBB818
	public void StopAnimation(bool isStop) { }

	// RVA: 0xFB7448 Offset: 0xFB3448 VA: 0xFB7448
	public void PerformEachFrame(Action action) { }

	[CompilerGenerated]
	// RVA: 0xFBB878 Offset: 0xFB7878 VA: 0xFBB878
	private void <SetNoTextures>b__76_0() { }

	[CompilerGenerated]
	// RVA: 0xFBB884 Offset: 0xFB7884 VA: 0xFBB884
	private void <Jump>b__81_0() { }
}

// Namespace: game.resource.settings.npcres
public class Datafield // TypeDefIndex: 2251
{
	// Fields
	public string cid; // 0x10
	public int index; // 0x18
	public int fightState; // 0x1C
	public int pkState; // 0x20
	public int npcKind; // 0x24
	public int npcType; // 0x28
	public int runSpeed; // 0x2C
	public int series; // 0x30
	public float animateAttackInterval; // 0x34
	public float animateCastInterval; // 0x38
	public float animateRunInterval; // 0x3C
	public string name; // 0x40
	public MiniMap.PointColor minimapColorDot; // 0x48
	public bool isWalking; // 0x50
	public bool isJumping; // 0x51
	public bool isJoystickFollowing; // 0x52
	public int level; // 0x54
	public string privateFightCid; // 0x58
	public string specialTargetPlayerCid; // 0x60
	public bool isManSex; // 0x68
	public bool isSalesman; // 0x69

	// Methods

	// RVA: 0xFB4A18 Offset: 0xFB0A18 VA: 0xFB4A18
	public void .ctor() { }
}

// Namespace: 
public static class Identification.TextColor // TypeDefIndex: 2252
{
	// Fields
	public const string whiteCode = "#ffffff";
	public const string justiceCode = "#ffa85e";
	public const string evilCode = "#ff92ff";
	public const string balanceCode = "#55ff91";
	public const string freeCode = "#ff0000";
	public static readonly Color32 white; // 0x0
	public static readonly Color32 justice; // 0x4
	public static readonly Color32 evil; // 0x8
	public static readonly Color32 balance; // 0xC
	public static readonly Color32 free; // 0x10
	public static readonly Color32 npcType1; // 0x14
	public static readonly Color32 npcType2; // 0x18
	public static readonly Color32 titlePink; // 0x1C

	// Methods

	// RVA: 0xFBD8E8 Offset: 0xFB98E8 VA: 0xFBD8E8
	private static void .cctor() { }
}

// Namespace: 
public class Identification.NpcSeries // TypeDefIndex: 2253
{
	// Fields
	private static Sprite[] sprites; // 0x0
	private readonly GameObject parent; // 0x10
	private readonly RectTransform rectTransformComponent; // 0x18
	private readonly SpriteRenderer spriteRendererComponent; // 0x20

	// Methods

	// RVA: 0xFBD998 Offset: 0xFB9998 VA: 0xFBD998
	public static Sprite GetSprite(int series) { }

	// RVA: 0xFBCA50 Offset: 0xFB8A50 VA: 0xFBCA50
	public void .ctor(string objectName) { }

	// RVA: 0xFBDC18 Offset: 0xFB9C18 VA: 0xFBDC18
	public GameObject GetAppearance() { }

	// RVA: 0xFBCB5C Offset: 0xFB8B5C VA: 0xFBCB5C
	public void SetSeries(int series) { }

	// RVA: 0xFBDC20 Offset: 0xFB9C20 VA: 0xFBDC20
	public int GetWidth() { }

	// RVA: 0xFBDC28 Offset: 0xFB9C28 VA: 0xFBDC28
	public int GetHeight() { }

	// RVA: 0xFBDC30 Offset: 0xFB9C30 VA: 0xFBDC30
	public void SetActive(bool active) { }

	// RVA: 0xFBDC4C Offset: 0xFB9C4C VA: 0xFBDC4C
	public bool IsActive() { }

	// RVA: 0xFBBFBC Offset: 0xFB7FBC VA: 0xFBBFBC
	public void SetAnchoredPosition(float xx, float yy) { }

	// RVA: 0xFBBB6C Offset: 0xFB7B6C VA: 0xFBBB6C
	public void Destroy() { }
}

// Namespace: 
public class Identification.NpcLife // TypeDefIndex: 2254
{
	// Fields
	public const int lineWidth = 60;
	public const float originPositionX = 30;
	public static int lineHeight; // 0x0
	public static float lineHeightForScene; // 0x4
	public static Sprite backgroundLine; // 0x8
	public static Sprite greenLine; // 0x10
	public static Sprite yellowLine; // 0x18
	public static Sprite redLine; // 0x20
	public static Sprite mediumVioletRed; // 0x28
	public static Sprite orangeLine; // 0x30
	private readonly GameObject current; // 0x10
	private readonly RectTransform rectTransformComponent; // 0x18
	private readonly GameObject backgroundObject; // 0x20
	private readonly SpriteRenderer backgroundSpriteRendererComponent; // 0x28
	private readonly GameObject currentLifeObject; // 0x30
	private readonly RectTransform currentLifeRectTransformComponent; // 0x38
	private readonly SpriteRenderer currentLifeSpriteRendererComponent; // 0x40
	private readonly Identification identification; // 0x48
	private float currentScale; // 0x50
	private Sprite forcerColor; // 0x58

	// Methods

	// RVA: 0xFBDC64 Offset: 0xFB9C64 VA: 0xFBDC64
	private static Texture2D GetTextureByColor(Color32 color32) { }

	// RVA: 0xFBDDC8 Offset: 0xFB9DC8 VA: 0xFBDDC8
	public static void GenerateStaticSprite(float lineHeight) { }

	// RVA: 0xFBCCF4 Offset: 0xFB8CF4 VA: 0xFBCCF4
	public void .ctor(Identification identification, string objectName) { }

	// RVA: 0xFBE07C Offset: 0xFBA07C VA: 0xFBE07C
	public GameObject GetAppearance() { }

	// RVA: 0xFBCFCC Offset: 0xFB8FCC VA: 0xFBCFCC
	public void SetActive(bool active) { }

	// RVA: 0xFBE084 Offset: 0xFBA084 VA: 0xFBE084
	public bool IsActive() { }

	// RVA: 0xFBD17C Offset: 0xFB917C VA: 0xFBD17C
	public void SetPercent(float scale) { }

	// RVA: 0xFBD0C0 Offset: 0xFB90C0 VA: 0xFBD0C0
	public void ForcerColor(Sprite sprite) { }

	// RVA: 0xFBBF64 Offset: 0xFB7F64 VA: 0xFBBF64
	public void SetAnchoredPositionY(float yy) { }

	// RVA: 0xFBBBD4 Offset: 0xFB7BD4 VA: 0xFBBBD4
	public void Destroy() { }

	// RVA: 0xFBE09C Offset: 0xFBA09C VA: 0xFBE09C
	private static void .cctor() { }
}

// Namespace: 
private class Identification.TextObject // TypeDefIndex: 2255
{
	// Fields
	private readonly GameObject current; // 0x10
	private readonly MeshRenderer meshRendererComponent; // 0x18
	private readonly TextMeshPro textMeshProComponent; // 0x20
	public readonly RectTransform rectTransformComponent; // 0x28

	// Methods

	// RVA: 0xFBC6DC Offset: 0xFB86DC VA: 0xFBC6DC
	public void .ctor(string objectName) { }

	// RVA: 0xFBE354 Offset: 0xFBA354 VA: 0xFBE354
	public GameObject GetAppearance() { }

	// RVA: 0xFBBF84 Offset: 0xFB7F84 VA: 0xFBBF84
	public void SetAnchoredPositionY(float yy) { }

	// RVA: 0xFBC1C8 Offset: 0xFB81C8 VA: 0xFBC1C8
	public void SetTextColor(Color color) { }

	// RVA: 0xFBC924 Offset: 0xFB8924 VA: 0xFBC924
	public void SetText(string text, bool updateWidthSize = False) { }

	// RVA: 0xFBE35C Offset: 0xFBA35C VA: 0xFBE35C
	public string GetText() { }

	// RVA: 0xFBBFA4 Offset: 0xFB7FA4 VA: 0xFBBFA4
	public Vector2 GetSize() { }

	// RVA: 0xFBE37C Offset: 0xFBA37C VA: 0xFBE37C
	public void SetActive(bool active) { }

	// RVA: 0xFBE398 Offset: 0xFBA398 VA: 0xFBE398
	public bool IsActive() { }

	// RVA: 0xFBBAF8 Offset: 0xFB7AF8 VA: 0xFBBAF8
	public void Destroy() { }
}

// Namespace: 
private class Identification.TalkAppendName // TypeDefIndex: 2256
{
	// Fields
	private readonly Identification identification; // 0x10
	private bool originPosOnMapActive; // 0x18
	private bool originTitleOnMapActive; // 0x19
	private bool originTongOnMapActive; // 0x1A
	private bool originNameOnMapActive; // 0x1B
	private bool originHealthOnMapActive; // 0x1C
	public string message; // 0x20

	// Methods

	// RVA: 0xFBC27C Offset: 0xFB827C VA: 0xFBC27C
	public void .ctor(Identification identification) { }

	// RVA: 0xFBC2B8 Offset: 0xFB82B8 VA: 0xFBC2B8
	public void SetText(string text) { }

	// RVA: 0xFBC1F0 Offset: 0xFB81F0 VA: 0xFBC1F0
	public void Destroy() { }
}

// Namespace: game.resource.settings.npcres
public class Identification // TypeDefIndex: 2257
{
	// Fields
	private State state; // 0x10
	public readonly GameObject current; // 0x18
	private float offsetY; // 0x20
	private float offsetYForCamera; // 0x24
	private string salesmanTitleValue; // 0x28
	private string mapPosValue; // 0x30
	private string titleValue; // 0x38
	private string tongNameValue; // 0x40
	private string nameValue; // 0x48
	private int campValue; // 0x50
	private int seriesValue; // 0x54
	private int healthCurrent; // 0x58
	private int healthMax; // 0x5C
	private int pkStatus; // 0x60
	private Sprite healthForcerColor; // 0x68
	private bool mapPosOnMapActive; // 0x70
	private bool titleOnMapActive; // 0x71
	private bool tongOnMapActive; // 0x72
	private bool nameOnMapActive; // 0x73
	private bool healthOnMapActive; // 0x74
	private Identification.TalkAppendName talkAppendName; // 0x78
	private PlayerOtherSalesmanTitle salesmanTitleShape; // 0x80
	private Identification.TextObject mapPosShape; // 0x88
	private Identification.TextObject titleShape; // 0x90
	private Identification.TextObject tongShape; // 0x98
	private Identification.TextObject nameShape; // 0xA0
	private Identification.NpcSeries seriesShape; // 0xA8
	private Identification.NpcLife healthShape; // 0xB0

	// Methods

	// RVA: 0xFB4910 Offset: 0xFB0910 VA: 0xFB4910
	public void .ctor() { }

	// RVA: 0xFBBAF0 Offset: 0xFB7AF0 VA: 0xFBBAF0
	public void InitSelfState(State state) { }

	// RVA: 0xFB5050 Offset: 0xFB1050 VA: 0xFB5050
	public void Destroy() { }

	// RVA: 0xFBBC60 Offset: 0xFB7C60 VA: 0xFBBC60
	public float UpdateLayout(bool updateNpcPate = False) { }

	// RVA: 0xFB7B10 Offset: 0xFB3B10 VA: 0xFB7B10
	public void SetNpcPate(int value) { }

	// RVA: 0xFBC078 Offset: 0xFB8078 VA: 0xFBC078
	public void SetNpcPateOffsetY(int value) { }

	// RVA: 0xFB6988 Offset: 0xFB2988 VA: 0xFB6988
	public void SetNpcOffsetY(float valueFloat) { }

	// RVA: 0xFBC098 Offset: 0xFB8098 VA: 0xFBC098
	public float GetNpcPateForCamera() { }

	// RVA: 0xFBC0A0 Offset: 0xFB80A0 VA: 0xFBC0A0
	public void SetScenePosition(Vector3 position) { }

	// RVA: 0xFBC0F0 Offset: 0xFB80F0 VA: 0xFBC0F0
	public void SetOrderInMapLayer(int order) { }

	// RVA: 0xFBC1C0 Offset: 0xFB81C0 VA: 0xFBC1C0
	public void SetCampValue(int camp) { }

	// RVA: 0xFB95C8 Offset: 0xFB55C8 VA: 0xFB95C8
	public void SetCamp(int camp) { }

	// RVA: 0xFBC1E8 Offset: 0xFB81E8 VA: 0xFBC1E8
	public int GetCamp() { }

	// RVA: 0xFB9D3C Offset: 0xFB5D3C VA: 0xFB9D3C
	public void SetBubbleTalk(string mes) { }

	// RVA: 0xFB9B8C Offset: 0xFB5B8C VA: 0xFB9B8C
	public void SetSalesmanTitle(string title) { }

	// RVA: 0xFBC4D0 Offset: 0xFB84D0 VA: 0xFBC4D0
	public void SetMapPos(string mapPos) { }

	// RVA: 0xFBCA40 Offset: 0xFB8A40 VA: 0xFBCA40
	public string GetTitle() { }

	// RVA: 0xFB93A4 Offset: 0xFB53A4 VA: 0xFB93A4
	public void SetTitle(string title) { }

	// RVA: 0xFB9218 Offset: 0xFB5218 VA: 0xFB9218
	public void SetTong(string name) { }

	// RVA: 0xFBCA48 Offset: 0xFB8A48 VA: 0xFBCA48
	public string GetName() { }

	// RVA: 0xFB8D3C Offset: 0xFB4D3C VA: 0xFB8D3C
	public void SetName(string name) { }

	// RVA: 0xFB9060 Offset: 0xFB5060 VA: 0xFB9060
	public void SetNameColor(Color color) { }

	// RVA: 0xFB90B0 Offset: 0xFB50B0 VA: 0xFB90B0
	public void SetSeries(int series) { }

	// RVA: 0xFBCB88 Offset: 0xFB8B88 VA: 0xFBCB88
	private void SetHealthScale(float scale) { }

	// RVA: 0xFB8CBC Offset: 0xFB4CBC VA: 0xFB8CBC
	public int GetHealthPercent() { }

	// RVA: 0xFBD344 Offset: 0xFB9344 VA: 0xFBD344
	public void SetHealthMaximum(int max) { }

	// RVA: 0xFBD34C Offset: 0xFB934C VA: 0xFBD34C
	public int GetHealthMaximum() { }

	// RVA: 0xFB8C50 Offset: 0xFB4C50 VA: 0xFB8C50
	public void SetHealthCurrently(int current) { }

	// RVA: 0xFBD354 Offset: 0xFB9354 VA: 0xFBD354
	public void SetHealthForcerColorRed() { }

	// RVA: 0xFBD3D4 Offset: 0xFB93D4 VA: 0xFBD3D4
	public void SetHealthForcerColorOrange() { }

	// RVA: 0xFBD454 Offset: 0xFB9454 VA: 0xFBD454
	public void SetHealthForcerColorViolet() { }

	// RVA: 0xFBD4D4 Offset: 0xFB94D4 VA: 0xFBD4D4
	public void SetHealthForcerColorNull() { }

	// RVA: 0xFBD508 Offset: 0xFB9508 VA: 0xFBD508
	public int GetHealthCurrently() { }

	// RVA: 0xFBD510 Offset: 0xFB9510 VA: 0xFBD510
	public void SetPkState(int pkstate) { }

	// RVA: 0xFBD518 Offset: 0xFB9518 VA: 0xFBD518
	public bool IsMapPosOnMapActive() { }

	// RVA: 0xFBD520 Offset: 0xFB9520 VA: 0xFBD520
	public void SetMapPosOnMapConfig(bool active) { }

	// RVA: 0xFBD528 Offset: 0xFB9528 VA: 0xFBD528
	public void SetMapPosOnMapApply(bool active) { }

	// RVA: 0xFBD5C4 Offset: 0xFB95C4 VA: 0xFBD5C4
	public void SetTitleOnMapConfig(bool active) { }

	// RVA: 0xFBD5CC Offset: 0xFB95CC VA: 0xFBD5CC
	public void SetTitleOnMapApply(bool active) { }

	// RVA: 0xFBD668 Offset: 0xFB9668 VA: 0xFBD668
	public void SetTongOnMapConfig(bool active) { }

	// RVA: 0xFBD670 Offset: 0xFB9670 VA: 0xFBD670
	public void SetTongOnMapApply(bool active) { }

	// RVA: 0xFBD70C Offset: 0xFB970C VA: 0xFBD70C
	public void SetNameOnMapConfig(bool active) { }

	// RVA: 0xFBD714 Offset: 0xFB9714 VA: 0xFBD714
	public void SetNameOnMapApply(bool active) { }

	// RVA: 0xFBD7D0 Offset: 0xFB97D0 VA: 0xFBD7D0
	public void SetHealthOnMapConfig(bool active) { }

	// RVA: 0xFBD7D8 Offset: 0xFB97D8 VA: 0xFBD7D8
	public void SetHealthOnMapApply(bool active) { }

	[CompilerGenerated]
	// RVA: 0xFBD850 Offset: 0xFB9850 VA: 0xFBD850
	private void <SetBubbleTalk>b__46_0() { }

	[CompilerGenerated]
	// RVA: 0xFBD8E0 Offset: 0xFB98E0 VA: 0xFBD8E0
	private void <SetBubbleTalk>b__46_1() { }
}

// Namespace: game.resource.settings.npcres
internal class Initialize // TypeDefIndex: 2258
{
	// Methods

	// RVA: 0xFBE3B0 Offset: 0xFBA3B0 VA: 0xFBE3B0
	public void .ctor() { }

	// RVA: 0xFBE724 Offset: 0xFBA724 VA: 0xFBE724
	private static Dictionary<string, string> GetSpecialCharacterMapping(Table _kindTable, string _characterName) { }

	// RVA: 0xFBE938 Offset: 0xFBA938 VA: 0xFBE938
	private static Dictionary<string, Table> GetSpecialCharacterTable(Dictionary<string, string> _headerMapping) { }

	// RVA: 0xFBEF60 Offset: 0xFBAF60 VA: 0xFBEF60
	private static Dictionary<string, Ini> GetSpecialCharacterIni(Dictionary<string, string> _headerMapping) { }

	// RVA: 0xFBEC28 Offset: 0xFBAC28 VA: 0xFBEC28
	private static Dictionary<string, Table> GetSpecialPartPropertiesTable(Dictionary<string, string> _headerMapping) { }

	// RVA: 0xFBF250 Offset: 0xFBB250 VA: 0xFBF250
	private static Dictionary<string, Structures.PartSprInfo> GetSpecialShadowAnimationMapping(Table _kindTable, Table _shadowTable, string _specialName) { }

	// RVA: 0xFBF600 Offset: 0xFBB600 VA: 0xFBF600
	private static Dictionary<string, Dictionary<string, Cache.Settings.NpcRes.NormalNpc.PartInfo>> GetNormalNpcMapping(Table _kindTable) { }
}

// Namespace: 
private enum NpcSoundEffect.HeaderIndexer // TypeDefIndex: 2259
{
	// Fields
	public int value__; // 0x0
	public const NpcSoundEffect.HeaderIndexer NpcList = 0;
	public const NpcSoundEffect.HeaderIndexer FightStand = 1;
	public const NpcSoundEffect.HeaderIndexer NormalStand1 = 2;
	public const NpcSoundEffect.HeaderIndexer NormalStand2 = 3;
	public const NpcSoundEffect.HeaderIndexer FightWalk = 4;
	public const NpcSoundEffect.HeaderIndexer NormalWalk = 5;
	public const NpcSoundEffect.HeaderIndexer FightRun = 6;
	public const NpcSoundEffect.HeaderIndexer NormalRun = 7;
	public const NpcSoundEffect.HeaderIndexer Wound = 8;
	public const NpcSoundEffect.HeaderIndexer Die = 9;
	public const NpcSoundEffect.HeaderIndexer Attack1 = 10;
	public const NpcSoundEffect.HeaderIndexer Attack2 = 11;
	public const NpcSoundEffect.HeaderIndexer Magic = 12;
	public const NpcSoundEffect.HeaderIndexer SitDown = 13;
	public const NpcSoundEffect.HeaderIndexer JunpFly = 14;
}

// Namespace: 
public class NpcSoundEffect.Data // TypeDefIndex: 2260
{
	// Fields
	public string Die; // 0x10
	public string Attack1; // 0x18

	// Methods

	// RVA: 0xFC04C8 Offset: 0xFBC4C8 VA: 0xFC04C8
	public void .ctor() { }
}

// Namespace: game.resource.settings.npcres
public static class NpcSoundEffect // TypeDefIndex: 2261
{
	// Fields
	private static readonly NpcSoundEffect.Data Empty; // 0x0
	private static Table table; // 0x8
	private static readonly Dictionary<string, int> rowIndexMapping; // 0x10
	private static readonly Dictionary<string, NpcSoundEffect.Data> dataMapping; // 0x18

	// Methods

	// RVA: 0xFC00A4 Offset: 0xFBC0A4 VA: 0xFC00A4
	public static void Initialize() { }

	// RVA: 0xFC0274 Offset: 0xFBC274 VA: 0xFC0274
	public static NpcSoundEffect.Data GetData(string npcTemplate) { }

	// RVA: 0xFC051C Offset: 0xFBC51C VA: 0xFC051C
	private static void .cctor() { }
}

// Namespace: 
private class Position.RunWithTimeData // TypeDefIndex: 2262
{
	// Fields
	public readonly Vector2 target; // 0x10
	public readonly float maxFrame18Fps; // 0x18
	public readonly float speed; // 0x1C
	public readonly Action onFinished; // 0x20
	public int currentFrame; // 0x28

	// Methods

	// RVA: 0xFC0FE0 Offset: 0xFBCFE0 VA: 0xFC0FE0
	public void .ctor(Position target, float maxFrame18Fps, float speed, Action onFinished) { }
}

// Namespace: game.resource.settings.npcres
public class Position // TypeDefIndex: 2263
{
	// Fields
	private Vector2 playerRunPosPassivity; // 0x10
	private float playerRunCheckSpeed; // 0x18
	private float runScheduleSpeed; // 0x1C
	private Vector2 npcRunPosPassivity; // 0x20
	private readonly Position mapPosition; // 0x28
	private Vector2 mapPositionFloat; // 0x30
	private Vector3 scenePosition; // 0x38
	private Vector3 cameraPosition; // 0x44
	private int orderInMap; // 0x50
	private Action<Vector2> onScheduleRun; // 0x58
	private Action playerOnScheduleDoneOnce; // 0x60
	private Action npcOnScheduleDoneOnce; // 0x68
	private Position.RunWithTimeData runWithTime; // 0x70
	private Controller controller; // 0x78
	private Identification identify; // 0x80
	private bool isUsingCamera; // 0x88
	public Position.Cell mapRegionCell; // 0x90

	// Methods

	// RVA: 0xFB44CC Offset: 0xFB04CC VA: 0xFB44CC
	public void .ctor() { }

	// RVA: 0xFB4BF4 Offset: 0xFB0BF4 VA: 0xFB4BF4
	public void InitReference(Identification identification, Controller controller) { }

	// RVA: 0xFC0658 Offset: 0xFBC658 VA: 0xFC0658
	public int GetDistance3D(Position position) { }

	// RVA: 0xFC0670 Offset: 0xFBC670 VA: 0xFC0670
	public int GetDistance3D(Controller controller) { }

	// RVA: 0xFC069C Offset: 0xFBC69C VA: 0xFC069C
	public int GetDistance3D(int targetX, int targetY) { }

	// RVA: 0xFC0720 Offset: 0xFBC720 VA: 0xFC0720
	public double GetDistanceFlat(Controller controller) { }

	// RVA: 0xFC074C Offset: 0xFBC74C VA: 0xFC074C
	public double GetDistanceFlat(int targetX, int targetY) { }

	// RVA: 0xFC07D0 Offset: 0xFBC7D0 VA: 0xFC07D0
	public void SetUsingCamera(bool used) { }

	// RVA: 0xFC07D8 Offset: 0xFBC7D8 VA: 0xFC07D8
	private void RunToDestinationWithTime() { }

	// RVA: 0xFC0AE0 Offset: 0xFBCAE0 VA: 0xFC0AE0
	private void PlayerRunToDestinationPassivity() { }

	// RVA: 0xFC0E58 Offset: 0xFBCE58 VA: 0xFC0E58
	private void NpcRunToDestinationPassivity() { }

	// RVA: 0xFB6AA8 Offset: 0xFB2AA8 VA: 0xFB6AA8
	public void Update() { }

	// RVA: 0xFB80D0 Offset: 0xFB40D0 VA: 0xFB80D0
	public void RunWithTime(Position targetPosition, float maxframe18fps, float speed, Action onFinish) { }

	// RVA: 0xFB81C8 Offset: 0xFB41C8 VA: 0xFB81C8
	public void SetPlayerDestinatePassivity(int top, int left, float speed, Action<Vector2> onRun, int forceDirection = 0, bool checkRunSpeed = False, bool dontSetAction = False) { }

	// RVA: 0xFB84C0 Offset: 0xFB44C0 VA: 0xFB84C0
	public void SetNpcDestinatePassivity(int top, int left, float speed) { }

	// RVA: 0xFB8694 Offset: 0xFB4694 VA: 0xFB8694
	public void SetPlayerOnScheduleDoneOnce(Action action) { }

	// RVA: 0xFB8714 Offset: 0xFB4714 VA: 0xFB8714
	public void SetNpcOnScheduleDoneOnce(Action action) { }

	// RVA: 0xFB87BC Offset: 0xFB47BC VA: 0xFB87BC
	public bool IsRunPosScheduling() { }

	// RVA: 0xFB87FC Offset: 0xFB47FC VA: 0xFB87FC
	public void ClearRunPosSchedule() { }

	// RVA: 0xFB89DC Offset: 0xFB49DC VA: 0xFB89DC
	public void SetMapPositionFloat(float _top, float _left) { }

	// RVA: 0xFB8894 Offset: 0xFB4894 VA: 0xFB8894
	public void SetMapPosition(int _top, int _left) { }

	// RVA: 0xFB8868 Offset: 0xFB4868 VA: 0xFB8868
	public void SetMapPosition(Position _mapPosition) { }

	// RVA: 0xFB8B48 Offset: 0xFB4B48 VA: 0xFB8B48
	public Position GetMapPosition() { }

	// RVA: 0xFC1040 Offset: 0xFBD040 VA: 0xFC1040
	public Position GetReferencePosition() { }

	// RVA: 0xFB8074 Offset: 0xFB4074 VA: 0xFB8074
	public int GetMapPositionX() { }

	// RVA: 0xFB808C Offset: 0xFB408C VA: 0xFB808C
	public int GetMapPositionY() { }

	// RVA: 0xFC1048 Offset: 0xFBD048 VA: 0xFC1048
	public Vector2 GetMapPositionFloat() { }

	// RVA: 0xFC1050 Offset: 0xFBD050 VA: 0xFC1050
	public float GetMapPositionFloatX() { }

	// RVA: 0xFC1058 Offset: 0xFBD058 VA: 0xFC1058
	public float GetMapPositionFloatY() { }

	// RVA: 0xFC1060 Offset: 0xFBD060 VA: 0xFC1060
	public Vector3 GetScenePosition() { }

	// RVA: 0xFC106C Offset: 0xFBD06C VA: 0xFC106C
	public Vector3 GetCameraPosition() { }

	// RVA: 0xFC1078 Offset: 0xFBD078 VA: 0xFC1078
	public int GetOrderInMap() { }
}

// Namespace: 
public enum ServeMove.State // TypeDefIndex: 2264
{
	// Fields
	public int value__; // 0x0
	public const ServeMove.State stop = 0;
	public const ServeMove.State origin = 1;
	public const ServeMove.State edited = 2;
}

// Namespace: 
public class ServeMove.Result // TypeDefIndex: 2265
{
	// Fields
	public ServeMove.State state; // 0x10
	public Position position; // 0x18

	// Methods

	// RVA: 0xFC168C Offset: 0xFBD68C VA: 0xFC168C
	public void .ctor(ServeMove.State state, Position position) { }

	// RVA: 0xFC1664 Offset: 0xFBD664 VA: 0xFC1664
	public void .ctor(ServeMove.State state) { }
}

// Namespace: game.resource.settings.npcres
public class ServeMove // TypeDefIndex: 2266
{
	// Fields
	private static bool ptoe; // 0x0
	private static int isLeftSide; // 0x4

	// Methods

	// RVA: 0xFC1080 Offset: 0xFBD080 VA: 0xFC1080
	public static void PTOE(bool enable) { }

	// RVA: 0xFC10E0 Offset: 0xFBD0E0 VA: 0xFC10E0
	private static bool TestBarrier(Map map, Position current, Position pos, int dir, int speed) { }

	// RVA: 0xFC11F8 Offset: 0xFBD1F8 VA: 0xFC11F8
	private static bool HasBarrierInLine(Map map, float currentX, float currentY, float targetX, float targetY) { }

	// RVA: 0xFC1348 Offset: 0xFBD348 VA: 0xFC1348
	public static ServeMove.Result Get(Map map, Position currentPosition, Vector2 expectedPosition, int dir8, int runSpeed) { }

	// RVA: 0xFC16C4 Offset: 0xFBD6C4 VA: 0xFC16C4
	public void .ctor() { }

	// RVA: 0xFC16CC Offset: 0xFBD6CC VA: 0xFC16CC
	private static void .cctor() { }
}

// Namespace: 
public class Shape.Appearance // TypeDefIndex: 2267
{
	// Fields
	public readonly GameObject current; // 0x10
	public readonly GameObject stateGo; // 0x18
	public readonly SortingGroup sortingGroup; // 0x20

	// Methods

	// RVA: 0xFC172C Offset: 0xFBD72C VA: 0xFC172C
	public void .ctor() { }

	// RVA: 0xFC1874 Offset: 0xFBD874 VA: 0xFC1874
	public static GameObject op_Implicit(Shape.Appearance _appearance) { }
}

// Namespace: 
public class Shape.PartFields // TypeDefIndex: 2268
{
	// Fields
	public GameObject current; // 0x10
	public RectTransform comRectTransform; // 0x18
	public SpriteRenderer comSpriteRenderer; // 0x20
	public bool isValid; // 0x28

	// Methods

	// RVA: 0xFC171C Offset: 0xFBD71C VA: 0xFC171C
	public void .ctor() { }
}

// Namespace: 
public class Shape.PartFrame // TypeDefIndex: 2269
{
	// Fields
	public SpriteLimit.Frame sprFrame; // 0x10

	// Methods

	// RVA: 0xFC1724 Offset: 0xFBD724 VA: 0xFC1724
	public void .ctor() { }
}

// Namespace: game.resource.settings.npcres
public class Shape // TypeDefIndex: 2270
{
	// Fields
	public readonly Shape.Appearance appearance; // 0x10
	private readonly Dictionary<string, Shape.PartFields> partFields; // 0x18
	private readonly Dictionary<string, Dictionary<int, Shape.PartFrame>> partFrame; // 0x20

	// Methods

	// RVA: 0xFB6D50 Offset: 0xFB2D50 VA: 0xFB6D50
	public void ReleasePartFields() { }

	// RVA: 0xFB4E28 Offset: 0xFB0E28 VA: 0xFB4E28
	public void Destroy() { }

	// RVA: 0xFB6480 Offset: 0xFB2480 VA: 0xFB6480
	public Shape.PartFields GetPartFields(string partName) { }

	// RVA: 0xFB669C Offset: 0xFB269C VA: 0xFB669C
	public Shape.PartFrame GetPartFrame(string _partName, ushort _frameIndex, Structures.PartAnimation _partAnimation) { }

	// RVA: 0xFB68C0 Offset: 0xFB28C0 VA: 0xFB68C0
	public void InValidPart(string _partName) { }

	// RVA: 0xFB60D0 Offset: 0xFB20D0 VA: 0xFB60D0
	public void InValidPartList(Dictionary<string, Structures.PartAnimation> _partList) { }

	// RVA: 0xFB4800 Offset: 0xFB0800 VA: 0xFB4800
	public void .ctor() { }
}

// Namespace: 
public class SkillList.NPCSKILL // TypeDefIndex: 2271
{
	// Fields
	public int SkillId; // 0x10
	public int SkillLevel; // 0x14
	public int MaxTimes; // 0x18
	public int RemainTimes; // 0x1C
	public int NextCastTime; // 0x20
	public int CurrentSkillLevel; // 0x24
	public int AddPoint; // 0x28
	public int EnChance; // 0x2C

	// Methods

	// RVA: 0xFC1B20 Offset: 0xFBDB20 VA: 0xFC1B20
	public void .ctor() { }
}

// Namespace: game.resource.settings.npcres
public class SkillList // TypeDefIndex: 2272
{
	// Fields
	public const int MAX_NPCSKILL = 80;
	public SkillList.NPCSKILL[] m_Skills; // 0x10

	// Methods

	// RVA: 0xFC1888 Offset: 0xFBD888 VA: 0xFC1888
	public void .ctor() { }

	// RVA: 0xFC18EC Offset: 0xFBD8EC VA: 0xFC18EC
	public int FindSame(int nSkillID) { }

	// RVA: 0xFC1958 Offset: 0xFBD958 VA: 0xFC1958
	public int GetCurrentLevel(int nSkillID) { }

	// RVA: 0xFC19A8 Offset: 0xFBD9A8 VA: 0xFC19A8
	public void QeuipAddPoint(int nListIndex, int add) { }

	// RVA: 0xFC19E8 Offset: 0xFBD9E8 VA: 0xFC19E8
	public bool IncreaseLevel(int nIdx, int nLvl, bool Qeuip) { }

	// RVA: 0xFC1A48 Offset: 0xFBDA48 VA: 0xFC1A48
	public int GetSkillId(int nListIndex) { }

	// RVA: 0xFC1A94 Offset: 0xFBDA94 VA: 0xFC1A94
	public void AddEnChance(int nListIndex, int add) { }

	// RVA: 0xFC1AD4 Offset: 0xFBDAD4 VA: 0xFC1AD4
	public int GetCurrentLevelByIdx(int nListIdx) { }
}

// Namespace: game.resource.settings.npcres
public class State // TypeDefIndex: 2273
{
	// Fields
	public const int orderBack = -2;
	public const int orderFront = 20;
	public const int orderTextEffect = 21;
	public const int orderSpecialSpr = 22;
	private readonly StateSetting[] stateSetting; // 0x10
	private readonly StateOnce[] stateOnce; // 0x18
	private readonly Text[] text; // 0x20
	public Controller npcontroller; // 0x28
	private GameObject parentShape; // 0x30
	private GameObject parentIdentify; // 0x38
	private int currentTime; // 0x40
	private int totalDamageValue; // 0x44
	private int totalDamageNextTime; // 0x48
	private float nextUpdateTime; // 0x4C

	// Methods

	// RVA: 0xFB4544 Offset: 0xFB0544 VA: 0xFB4544
	public void .ctor() { }

	// RVA: 0xFC1B40 Offset: 0xFBDB40 VA: 0xFC1B40
	public void InitNpcontroller(Controller controller) { }

	// RVA: 0xFB4C24 Offset: 0xFB0C24 VA: 0xFB4C24
	public void InitSelfParentGo(GameObject parentShape, GameObject parentIdentify) { }

	// RVA: 0xFBA2A8 Offset: 0xFB62A8 VA: 0xFBA2A8
	public bool HaveStateId(int stateId) { }

	// RVA: 0xFBA180 Offset: 0xFB6180 VA: 0xFBA180
	public void SetAllStateVisibility(bool visibled) { }

	// RVA: 0xFBA418 Offset: 0xFB6418 VA: 0xFBA418
	public void RemoveStateSetting(int stateId) { }

	// RVA: 0xFC1B98 Offset: 0xFBDB98 VA: 0xFC1B98
	public void AddStateSetting(State setting, int leftTime) { }

	// RVA: 0xFBA4A0 Offset: 0xFB64A0 VA: 0xFBA4A0
	public void AddStateIdLoop(int stateid, int looptimes) { }

	// RVA: 0xFBA338 Offset: 0xFB6338 VA: 0xFBA338
	public void AddStateSetting(int stateId, int leftTime) { }

	// RVA: 0xFC1CE4 Offset: 0xFBDCE4 VA: 0xFC1CE4
	public void AddStateSetting(Skill skill, int leftTime) { }

	// RVA: 0xFC1D04 Offset: 0xFBDD04 VA: 0xFC1D04
	public void AddStateSetting(Skill skill) { }

	// RVA: 0xFBA530 Offset: 0xFB6530 VA: 0xFBA530
	public void AddStateOnce(string sprPath, int looptimes = 1) { }

	// RVA: 0xFC1D4C Offset: 0xFBDD4C VA: 0xFC1D4C
	public void AddTextState(Text.FlyForm flyForm, string text, Color color, float fontMinSize, float fontMaxSize, int startTime, int growUpToTime, int endTime, FontStyles fontStyles) { }

	// RVA: 0xFBA5C4 Offset: 0xFB65C4 VA: 0xFBA5C4
	public void AddTextStateCriticalDamage(int damage) { }

	// RVA: 0xFBA6AC Offset: 0xFB66AC VA: 0xFBA6AC
	public void AddTextStateNormalDamage(int damage) { }

	// RVA: 0xFBA7DC Offset: 0xFB67DC VA: 0xFBA7DC
	public void AppendTotalDamage(int damage) { }

	// RVA: 0xFBA800 Offset: 0xFB6800 VA: 0xFBA800
	public void AddTextStateEXP(long exp) { }

	// RVA: 0xFBA908 Offset: 0xFB6908 VA: 0xFBA908
	public void AddTextBounce(string data, int colorHex = 16777215, int form = 0, int iscritical = 0) { }

	// RVA: 0xFBAA48 Offset: 0xFB6A48 VA: 0xFBAA48
	public void AddTextStateHealth(int value) { }

	// RVA: 0xFBAB3C Offset: 0xFB6B3C VA: 0xFBAB3C
	public void AddTextEvade() { }

	// RVA: 0xFBAC38 Offset: 0xFB6C38 VA: 0xFBAC38
	public void AddTextMiss() { }

	// RVA: 0xFBAD34 Offset: 0xFB6D34 VA: 0xFBAD34
	public void AddTextDefense() { }

	// RVA: 0xFBBFD4 Offset: 0xFB7FD4 VA: 0xFBBFD4
	public void SetNpcPate(float bodyOffset, float headOffset) { }

	// RVA: 0xFB51F4 Offset: 0xFB11F4 VA: 0xFB51F4
	public void Activate() { }

	// RVA: 0xFB6B14 Offset: 0xFB2B14 VA: 0xFB6B14
	public void Update() { }

	// RVA: 0xFBB6F0 Offset: 0xFB76F0 VA: 0xFBB6F0
	public void Clear(bool ignorePermanent = False) { }
}

// Namespace: 
public class Structures.PartSprInfo // TypeDefIndex: 2274
{
	// Fields
	public string sprFullPath; // 0x10
	public ushort frameCount; // 0x18
	public int directionCount; // 0x1C
	public int intervalRatio; // 0x20
	public static Structures.PartSprInfo Empty; // 0x0

	// Methods

	// RVA: 0xFC009C Offset: 0xFBC09C VA: 0xFC009C
	public void .ctor() { }

	// RVA: 0xFC26EC Offset: 0xFBE6EC VA: 0xFC26EC
	private static void .cctor() { }
}

// Namespace: 
public class Structures.PartAnimation // TypeDefIndex: 2275
{
	// Fields
	public string sprPath; // 0x10
	public ushort frameBegin; // 0x18
	public ushort frameEnd; // 0x1A
	public int framePerDirection; // 0x1C
	public int layerOrder; // 0x20
	public static Structures.PartAnimation Empty; // 0x0

	// Methods

	// RVA: 0xFB6280 Offset: 0xFB2280 VA: 0xFB6280
	public ushort GetNextFrameRandom(Controller.AnimateParams animateParams, float frameRateOn18fps = 0) { }

	// RVA: 0xFB63B0 Offset: 0xFB23B0 VA: 0xFB63B0
	public ushort GetNextFrameIndex(Controller.AnimateParams animateParams) { }

	// RVA: 0xFC2754 Offset: 0xFBE754 VA: 0xFC2754
	public void .ctor() { }

	// RVA: 0xFC275C Offset: 0xFBE75C VA: 0xFC275C
	private static void .cctor() { }
}

// Namespace: game.resource.settings.npcres
public class Structures // TypeDefIndex: 2276
{
	// Methods

	// RVA: 0xFC26E4 Offset: 0xFBE6E4 VA: 0xFC26E4
	public void .ctor() { }
}
