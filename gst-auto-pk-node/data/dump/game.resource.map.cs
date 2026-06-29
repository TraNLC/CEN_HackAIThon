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

// Namespace: game.resource.map
public struct Config // TypeDefIndex: 2352
{}

// Namespace: 
public struct Element.TextureType // TypeDefIndex: 2353
{
	// Fields
	public const int unidentified = 0;
	public const int groundNode = 1;
	public const int groundObject = 2;
	public const int buildingUnder = 3;
	public const int buildingAbove = 4;
	public const int tree = 5;
}

// Namespace: 
public struct Element.Texture // TypeDefIndex: 2354
{
	// Fields
	public int type; // 0x0
	public Position.Sequential.Origin originPosition; // 0x4
	public Position.Sequential.Node nodeAssetPosition; // 0xC
	public byte[] texturePathBuffer; // 0x18
	public ushort textureFrame; // 0x20
	public int order; // 0x24
}

// Namespace: 
public struct Element.ObstacleGridElement // TypeDefIndex: 2355
{
	// Fields
	public int[] element; // 0x0
}

// Namespace: 
public struct Element.Obstacle // TypeDefIndex: 2356
{
	// Fields
	public Element.ObstacleGridElement[] grid; // 0x0
	public Position.Sequential.Node nodeAssetPosition; // 0x8
}

// Namespace: game.resource.map
public class Element // TypeDefIndex: 2357
{
	// Fields
	public Element.Texture[] texture; // 0x10
	public Element.Obstacle[] obstacle; // 0x18

	// Methods

	// RVA: 0xFC86D4 Offset: 0xFC46D4 VA: 0xFC86D4
	public void .ctor() { }
}

// Namespace: 
public enum FPS18.Command.ID // TypeDefIndex: 2358
{
	// Fields
	public int value__; // 0x0
	public const FPS18.Command.ID unidentified = 0;
	public const FPS18.Command.ID release = 1;
	public const FPS18.Command.ID addNpc = 2;
	public const FPS18.Command.ID removeNpc = 3;
	public const FPS18.Command.ID addObject = 4;
	public const FPS18.Command.ID removeObject = 5;
	public const FPS18.Command.ID limitNpcRenderCount = 6;
	public const FPS18.Command.ID limitNpcRenderTypePlayer = 7;
	public const FPS18.Command.ID limitNpcRenderTypeNpc = 8;
	public const FPS18.Command.ID reset = 9;
}

// Namespace: 
public class FPS18.Command.Element // TypeDefIndex: 2359
{
	// Fields
	public FPS18.Command.ID commandID; // 0x10

	// Methods

	// RVA: 0xFCB044 Offset: 0xFC7044 VA: 0xFCB044
	public void .ctor(FPS18.Command.ID commandID) { }
}

// Namespace: 
public class FPS18.Command.Release : FPS18.Command.Element // TypeDefIndex: 2360
{
	// Fields
	public Action onReleased; // 0x18

	// Methods

	// RVA: 0xFC8AD0 Offset: 0xFC4AD0 VA: 0xFC8AD0
	public void .ctor() { }
}

// Namespace: 
public class FPS18.Command.AddNpc : FPS18.Command.Element // TypeDefIndex: 2361
{
	// Fields
	public Controller npcController; // 0x18

	// Methods

	// RVA: 0xFC8B94 Offset: 0xFC4B94 VA: 0xFC8B94
	public void .ctor(Controller npcController) { }
}

// Namespace: 
public class FPS18.Command.RemoveNpc : FPS18.Command.Element // TypeDefIndex: 2362
{
	// Fields
	public Controller npcontroller; // 0x18

	// Methods

	// RVA: 0xFC8C70 Offset: 0xFC4C70 VA: 0xFC8C70
	public void .ctor(Controller npcontroller) { }
}

// Namespace: 
public class FPS18.Command.AddObject : FPS18.Command.Element // TypeDefIndex: 2363
{
	// Fields
	public Object gameObject; // 0x18

	// Methods

	// RVA: 0xFC8D4C Offset: 0xFC4D4C VA: 0xFC8D4C
	public void .ctor(Object gameObject) { }
}

// Namespace: 
public class FPS18.Command.RemoveObject : FPS18.Command.Element // TypeDefIndex: 2364
{
	// Fields
	public string objectId; // 0x18

	// Methods

	// RVA: 0xFC8E28 Offset: 0xFC4E28 VA: 0xFC8E28
	public void .ctor(string objectId) { }
}

// Namespace: 
public class FPS18.Command.LimitNpcRenderCount : FPS18.Command.Element // TypeDefIndex: 2365
{
	// Fields
	public int limitCount; // 0x14

	// Methods

	// RVA: 0xFC8EF4 Offset: 0xFC4EF4 VA: 0xFC8EF4
	public void .ctor(int limitCount) { }
}

// Namespace: 
public class FPS18.Command.LimitNpcRenderTypePlayer : FPS18.Command.Element // TypeDefIndex: 2366
{
	// Fields
	public bool renderPlayer; // 0x14

	// Methods

	// RVA: 0xFC8FBC Offset: 0xFC4FBC VA: 0xFC8FBC
	public void .ctor(bool renderPlayer) { }
}

// Namespace: 
public class FPS18.Command.LimitNpcRenderTypeNpc : FPS18.Command.Element // TypeDefIndex: 2367
{
	// Fields
	public bool renderNpc; // 0x14

	// Methods

	// RVA: 0xFC9088 Offset: 0xFC5088 VA: 0xFC9088
	public void .ctor(bool renderPlayer) { }
}

// Namespace: 
public class FPS18.Command.Reset : FPS18.Command.Element // TypeDefIndex: 2368
{
	// Methods

	// RVA: 0xFC9140 Offset: 0xFC5140 VA: 0xFC9140
	public void .ctor() { }
}

// Namespace: 
public class FPS18.Command // TypeDefIndex: 2369
{
	// Methods

	// RVA: 0xFCB03C Offset: 0xFC703C VA: 0xFCB03C
	public void .ctor() { }
}

// Namespace: 
private class FPS18.LimitNpcRenderInfo // TypeDefIndex: 2370
{
	// Fields
	public int limitCount; // 0x10
	public bool renderPlayer; // 0x14
	public bool renderNpc; // 0x15

	// Methods

	// RVA: 0xFC8A04 Offset: 0xFC4A04 VA: 0xFC8A04
	public void .ctor() { }
}

// Namespace: 
private class FPS18.TimeoutData // TypeDefIndex: 2371
{
	// Fields
	public long frameLifeTime; // 0x10
	public Action action; // 0x18

	// Methods

	// RVA: 0xFC9238 Offset: 0xFC5238 VA: 0xFC9238
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FPS18.<>c // TypeDefIndex: 2372
{
	// Fields
	public static readonly FPS18.<>c <>9; // 0x0
	[TupleElementNames(new[] { "controller", "distance" })]
	public static Comparison<ValueTuple<Controller, double>> <>9__30_0; // 0x8

	// Methods

	// RVA: 0xFCB06C Offset: 0xFC706C VA: 0xFCB06C
	private static void .cctor() { }

	// RVA: 0xFCB0D4 Offset: 0xFC70D4 VA: 0xFCB0D4
	public void .ctor() { }

	// RVA: 0xFCB0DC Offset: 0xFC70DC VA: 0xFCB0DC
	internal int <Update_Npc>b__30_0(ValueTuple<Controller, double> pair1, ValueTuple<Controller, double> pair2) { }
}

// Namespace: game.resource.map
public class FPS18 // TypeDefIndex: 2373
{
	// Fields
	public static long looptimes; // 0x0
	private static readonly ConcurrentDictionary<FPS18.TimeoutData, bool> timeoutMapping; // 0x8
	private readonly Map map; // 0x10
	private readonly Thread mainThreadHandle; // 0x18
	private readonly FPS18.LimitNpcRenderInfo limitNpcRender; // 0x20
	private readonly ConcurrentQueue<FPS18.Command.Element> commandQueue; // 0x28
	private readonly Dictionary<Controller, bool> npcMapping; // 0x30
	private readonly Dictionary<string, Object> objectMapping; // 0x38
	private readonly List<string> updateMapObjectRemoveListing; // 0x40
	private readonly LiveTracking pingTracking; // 0x48
	private readonly List<Controller> updateNpc_controller; // 0x50
	[TupleElementNames(new[] { "controller", "distance" })]
	private readonly List<ValueTuple<Controller, double>> updateNpc_ascendingDistance; // 0x58
	public int updateNpc_npcRenderRemaining; // 0x60

	// Methods

	// RVA: 0xFC86DC Offset: 0xFC46DC VA: 0xFC86DC
	public void .ctor(Map map) { }

	// RVA: 0xFC8A14 Offset: 0xFC4A14 VA: 0xFC8A14
	public void Initialize() { }

	// RVA: 0xFC8A2C Offset: 0xFC4A2C VA: 0xFC8A2C
	public void Release(Action onReleased) { }

	// RVA: 0xFC8AF0 Offset: 0xFC4AF0 VA: 0xFC8AF0
	public void AddNpc(Controller npcController) { }

	// RVA: 0xFC8BCC Offset: 0xFC4BCC VA: 0xFC8BCC
	public void RemoveNpc(Controller npcController) { }

	// RVA: 0xFC8CA8 Offset: 0xFC4CA8 VA: 0xFC8CA8
	public void AddObject(Object gameObject) { }

	// RVA: 0xFC8D84 Offset: 0xFC4D84 VA: 0xFC8D84
	public void RemoveObject(string objectId) { }

	// RVA: 0xFC8E60 Offset: 0xFC4E60 VA: 0xFC8E60
	public void LimitNpcRenderCount(int limitCount) { }

	// RVA: 0xFC8F20 Offset: 0xFC4F20 VA: 0xFC8F20
	public void LimitNpcRenderTypePlayer(bool renderPlayer) { }

	// RVA: 0xFC8FEC Offset: 0xFC4FEC VA: 0xFC8FEC
	public void LimitNpcRenderTypeNpc(bool renderNpc) { }

	// RVA: 0xFC90B8 Offset: 0xFC50B8 VA: 0xFC90B8
	public void Reset() { }

	// RVA: 0xFC9160 Offset: 0xFC5160 VA: 0xFC9160
	public static void SetTimeout(int frame, Action action) { }

	// RVA: 0xFC9240 Offset: 0xFC5240 VA: 0xFC9240
	private void MainThread() { }

	// RVA: 0xFCAED0 Offset: 0xFC6ED0 VA: 0xFCAED0
	private void Update_EachSecond() { }

	// RVA: 0xFC9C9C Offset: 0xFC5C9C VA: 0xFC9C9C
	private void Update_Npc() { }

	// RVA: 0xFCA770 Offset: 0xFC6770 VA: 0xFCA770
	private void Update_Object() { }

	// RVA: 0xFCABD4 Offset: 0xFC6BD4 VA: 0xFCABD4
	private void Command_Release(FPS18.Command.Release command) { }

	// RVA: 0xFCAC74 Offset: 0xFC6C74 VA: 0xFCAC74
	private void Command_AddNpc(FPS18.Command.AddNpc command) { }

	// RVA: 0xFCACD4 Offset: 0xFC6CD4 VA: 0xFCACD4
	private void Command_RemoveNpc(FPS18.Command.RemoveNpc command) { }

	// RVA: 0xFCAD30 Offset: 0xFC6D30 VA: 0xFCAD30
	private void Command_AddObject(FPS18.Command.AddObject command) { }

	// RVA: 0xFCAD94 Offset: 0xFC6D94 VA: 0xFCAD94
	private void Command_RemoveObject(FPS18.Command.RemoveObject command) { }

	// RVA: 0xFCADF0 Offset: 0xFC6DF0 VA: 0xFCADF0
	private void Command_LimitNpcRenderCount(FPS18.Command.LimitNpcRenderCount command) { }

	// RVA: 0xFCAE14 Offset: 0xFC6E14 VA: 0xFCAE14
	private void Command_LimitNpcRenderTypePlayer(FPS18.Command.LimitNpcRenderTypePlayer command) { }

	// RVA: 0xFCAE38 Offset: 0xFC6E38 VA: 0xFCAE38
	private void Command_LimitNpcRenderTypeNpc(FPS18.Command.LimitNpcRenderTypeNpc command) { }

	// RVA: 0xFCAE5C Offset: 0xFC6E5C VA: 0xFCAE5C
	private void Command_Reset(FPS18.Command.Reset command) { }

	// RVA: 0xFCAFA0 Offset: 0xFC6FA0 VA: 0xFCAFA0
	private static void .cctor() { }
}

// Namespace: 
public static class Layer.SortingGroup // TypeDefIndex: 2374
{
	// Fields
	public const short orderMapBackground = -32768;
	public const short orderMapGroundNode = -32767;
	public const short orderMapGroundObject = -32766;
	public const short orderBuildingAbove = 32765;
	public const short orderIdentification = 32766;
	public const short orderMainPlayerIdentify = 32767;
}

// Namespace: game.resource.map
public class Layer // TypeDefIndex: 2375
{
	// Fields
	public readonly GameObject hiddenTextures; // 0x10
	public readonly GameObject groundNode; // 0x18
	public readonly GameObject groundObject; // 0x20
	public readonly GameObject groundMixture; // 0x28
	public readonly GameObject skillMissile; // 0x30
	public readonly GameObject buildingAbove; // 0x38
	public readonly GameObject identification; // 0x40

	// Methods

	// RVA: 0xFCB108 Offset: 0xFC7108 VA: 0xFCB108
	public void .ctor(GameObject _parent) { }
}

// Namespace: 
private class MiniMap.PointObject // TypeDefIndex: 2376
{
	// Fields
	public GameObject goCurrent; // 0x10
	public RectTransform compRectTransform; // 0x18
	public Image compImage; // 0x20

	// Methods

	// RVA: 0xFCC278 Offset: 0xFC8278 VA: 0xFCC278
	public MiniMap.PointObject Clone(string name, GameObject parent) { }

	// RVA: 0xFCBAD4 Offset: 0xFC7AD4 VA: 0xFCBAD4
	public void .ctor() { }
}

// Namespace: 
public class MiniMap.PointColor // TypeDefIndex: 2377
{
	// Fields
	public int order; // 0x10
	public Sprite sprite; // 0x18

	// Methods

	// RVA: 0xFCDA88 Offset: 0xFC9A88 VA: 0xFCDA88
	public void .ctor(int order, Sprite sprite) { }
}

// Namespace: game.resource.map
public class MiniMap // TypeDefIndex: 2378
{
	// Fields
	private MiniMap userInterface; // 0x10
	private Controller mainPlayerController; // 0x18
	private readonly MiniMap.PointObject defaultPointObject; // 0x20
	public readonly GameObject go; // 0x28
	public readonly RectTransform compRect; // 0x30
	public readonly Image compImage; // 0x38
	public static readonly MiniMap.PointColor purpleDot; // 0x0
	public static readonly MiniMap.PointColor redDot; // 0x8
	public static readonly MiniMap.PointColor greenDot; // 0x10
	public static readonly MiniMap.PointColor yellowDot; // 0x18
	private readonly Dictionary<Controller, MiniMap.PointObject> specialNpcPoints; // 0x40
	private readonly Dictionary<Controller, MiniMap.PointObject> normalNpcPoints; // 0x48
	public float xRatio; // 0x50
	public float yRatio; // 0x54
	private readonly Dictionary<MiniMap.PointObject, bool> greenDotMapping; // 0x58
	private RectTransform pinPositionIconClone; // 0x60
	private RectTransform pinPositionLinerClone; // 0x68
	private long pinPositionNextUpdateTime; // 0x70

	// Methods

	// RVA: 0xFCB594 Offset: 0xFC7594 VA: 0xFCB594
	public static Sprite CreateDotColor(Color32 color32) { }

	// RVA: 0xFCB724 Offset: 0xFC7724 VA: 0xFCB724
	public void .ctor() { }

	// RVA: 0xFCBADC Offset: 0xFC7ADC VA: 0xFCBADC
	public void PinPositionStop() { }

	// RVA: 0xFCBC10 Offset: 0xFC7C10 VA: 0xFCBC10
	public void PinPositionStart(RectTransform pinRectToClone, RectTransform lineRectToClone, int xx, int yy) { }

	// RVA: 0xFCBDF8 Offset: 0xFC7DF8 VA: 0xFCBDF8
	private void PinPositionUpdate(MiniMap.PointObject pointObject) { }

	// RVA: 0xFCC25C Offset: 0xFC825C VA: 0xFCC25C
	private MiniMap.PointObject ClonePointObject(string name) { }

	// RVA: 0xFCC420 Offset: 0xFC8420 VA: 0xFCC420
	public void SetUI(MiniMap userInterface) { }

	// RVA: 0xFCC428 Offset: 0xFC8428 VA: 0xFCC428
	public void Initialize(Controller mainPlayerController) { }

	// RVA: 0xFCC430 Offset: 0xFC8430 VA: 0xFCC430
	public void Clear() { }

	// RVA: 0xFCC890 Offset: 0xFC8890 VA: 0xFCC890
	public Sprite GetSprite() { }

	// RVA: 0xFCC8A8 Offset: 0xFC88A8 VA: 0xFCC8A8
	public void ExportImage(string persistenPath) { }

	// RVA: 0xFCCAA8 Offset: 0xFC8AA8 VA: 0xFCCAA8
	public void Load(MapList.MapInfo mapInfo) { }

	// RVA: 0xFCCCB4 Offset: 0xFC8CB4 VA: 0xFCCCB4
	public void Reset(MapList.MapInfo mapInfo) { }

	// RVA: 0xFCCD64 Offset: 0xFC8D64 VA: 0xFCCD64
	private void SiblingProcess(MiniMap.PointObject pointObject, MiniMap.PointColor pointColor) { }

	// RVA: 0xFCCEFC Offset: 0xFC8EFC VA: 0xFCCEFC
	public void AddObject(Controller npcController) { }

	// RVA: 0xFCD0C8 Offset: 0xFC90C8 VA: 0xFCD0C8
	public void RemoveObject(Controller npcController) { }

	// RVA: 0xFCD1B4 Offset: 0xFC91B4 VA: 0xFCD1B4
	public void ResetMinimapPlayerDot() { }

	// RVA: 0xFCD43C Offset: 0xFC943C VA: 0xFCD43C
	public void ChangeColor(Controller controller, MiniMap.PointColor color) { }

	// RVA: 0xFCD568 Offset: 0xFC9568 VA: 0xFCD568
	public void SetMapPosition(Controller npcController, Position position) { }

	// RVA: 0xFCD7D0 Offset: 0xFC97D0 VA: 0xFCD7D0
	public void SetPlayerColorAlpha(Controller controller, int alphaPercent) { }

	// RVA: 0xFCD8E4 Offset: 0xFC98E4 VA: 0xFCD8E4
	private static void .cctor() { }
}

// Namespace: 
public enum Missile.Command.ID // TypeDefIndex: 2379
{
	// Fields
	public int value__; // 0x0
	public const Missile.Command.ID unidentified = 0;
	public const Missile.Command.ID release = 1;
	public const Missile.Command.ID addMissile = 2;
	public const Missile.Command.ID clear = 3;
}

// Namespace: 
public class Missile.Command.Element // TypeDefIndex: 2380
{
	// Fields
	public Missile.Command.ID commandID; // 0x10

	// Methods

	// RVA: 0xFCE798 Offset: 0xFCA798 VA: 0xFCE798
	public void .ctor(Missile.Command.ID commandID) { }
}

// Namespace: 
public class Missile.Command.Release : Missile.Command.Element // TypeDefIndex: 2381
{
	// Fields
	public Action onReleased; // 0x18

	// Methods

	// RVA: 0xFCDD34 Offset: 0xFC9D34 VA: 0xFCDD34
	public void .ctor() { }
}

// Namespace: 
public class Missile.Command.AddMissile : Missile.Command.Element // TypeDefIndex: 2382
{
	// Fields
	public List<Missile> missiles; // 0x18

	// Methods

	// RVA: 0xFCDE8C Offset: 0xFC9E8C VA: 0xFCDE8C
	public void .ctor(List<Missile> missiles) { }
}

// Namespace: 
public class Missile.Command.Clear : Missile.Command.Element // TypeDefIndex: 2383
{
	// Methods

	// RVA: 0xFCDF4C Offset: 0xFC9F4C VA: 0xFCDF4C
	public void .ctor() { }
}

// Namespace: 
public class Missile.Command // TypeDefIndex: 2384
{
	// Methods

	// RVA: 0xFCE790 Offset: 0xFCA790 VA: 0xFCE790
	public void .ctor() { }
}

// Namespace: game.resource.map
public class Missile // TypeDefIndex: 2385
{
	// Fields
	private readonly Thread mainThreadHandle; // 0x10
	private readonly ConcurrentQueue<Missile.Command.Element> commandQueue; // 0x18
	private readonly Dictionary<Missile, bool> missileMapping; // 0x20
	private readonly List<Missile> updateMissile_removeListing; // 0x28

	// Methods

	// RVA: 0xFCDAC0 Offset: 0xFC9AC0 VA: 0xFCDAC0
	public void .ctor() { }

	// RVA: 0xFCDC78 Offset: 0xFC9C78 VA: 0xFCDC78
	public void Initialize() { }

	// RVA: 0xFCDC90 Offset: 0xFC9C90 VA: 0xFCDC90
	public void Release(Action onReleased) { }

	// RVA: 0xFCDD54 Offset: 0xFC9D54 VA: 0xFCDD54
	public bool HaveMissileSlot() { }

	// RVA: 0xFCDDE8 Offset: 0xFC9DE8 VA: 0xFCDDE8
	public void AddMissile(List<Missile> missiles) { }

	// RVA: 0xFCDEC4 Offset: 0xFC9EC4 VA: 0xFCDEC4
	public void Clear() { }

	// RVA: 0xFCDF6C Offset: 0xFC9F6C VA: 0xFCDF6C
	private void MainThread() { }

	// RVA: 0xFCE13C Offset: 0xFCA13C VA: 0xFCE13C
	private void Update_Missile() { }

	// RVA: 0xFCE52C Offset: 0xFCA52C VA: 0xFCE52C
	private void Command_AddMissile(Missile.Command.AddMissile command) { }

	// RVA: 0xFCE740 Offset: 0xFCA740 VA: 0xFCE740
	private void Command_Clear() { }
}

// Namespace: 
public enum Obstacle.Type // TypeDefIndex: 2386
{
	// Fields
	public int value__; // 0x0
	public const Obstacle.Type Empty = 0;
	public const Obstacle.Type Full = 1;
	public const Obstacle.Type LeftTop = 2;
	public const Obstacle.Type RightTop = 3;
	public const Obstacle.Type LeftBottom = 4;
	public const Obstacle.Type RightBottom = 5;
	public const Obstacle.Type TypeCount = 6;
}

// Namespace: 
public class Obstacle.Data // TypeDefIndex: 2387
{
	// Fields
	public readonly Element.Obstacle info; // 0x10

	// Methods

	// RVA: 0xFCE7C8 Offset: 0xFCA7C8 VA: 0xFCE7C8
	public void .ctor(Element.Obstacle info) { }
}

// Namespace: 
public class Obstacle.Grid // TypeDefIndex: 2388
{
	// Fields
	public const int textureSize = 128;
	public const int scaleDown = 4;
	public const int gridWidth = 8;
	public const int gridHeight = 4;
	public readonly Obstacle.Data data; // 0x10
	private Color32 pixelColor; // 0x18
	private Color32[] pixelBuffer; // 0x20

	// Methods

	// RVA: 0xFCE800 Offset: 0xFCA800 VA: 0xFCE800
	public void .ctor(Obstacle.Data data) { }

	// RVA: 0xFCE830 Offset: 0xFCA830 VA: 0xFCE830
	public void Initialize() { }

	// RVA: 0xFCE8A8 Offset: 0xFCA8A8 VA: 0xFCE8A8
	private void DrawPixel(int x, int y) { }

	// RVA: 0xFCE950 Offset: 0xFCA950 VA: 0xFCE950
	private void DrawLine(int x0, int y0, int x1, int y1) { }

	// RVA: 0xFCEA64 Offset: 0xFCAA64 VA: 0xFCEA64
	public void DrawGrid() { }

	// RVA: 0xFCECA0 Offset: 0xFCACA0 VA: 0xFCECA0
	public Texture2D CreateTexture2D() { }

	// RVA: 0xFCED2C Offset: 0xFCAD2C VA: 0xFCED2C
	public Sprite CreateSprite() { }

	// RVA: 0xFCED58 Offset: 0xFCAD58 VA: 0xFCED58
	public Position.Sequential.Node GetNodePosition() { }
}

// Namespace: 
public class Obstacle.Barrier // TypeDefIndex: 2389
{
	// Fields
	private readonly Dictionary<int, Dictionary<int, Obstacle.Data>> nodeObstacleData; // 0x10

	// Methods

	// RVA: 0xFCED70 Offset: 0xFCAD70 VA: 0xFCED70
	public void .ctor() { }

	// RVA: 0xFCEDF8 Offset: 0xFCADF8 VA: 0xFCEDF8
	public void AddNodeField(Obstacle.Data data) { }

	// RVA: 0xFCEFF8 Offset: 0xFCAFF8 VA: 0xFCEFF8
	public void RemoveNodeField(Position.Node node) { }

	// RVA: 0xFCF1B8 Offset: 0xFCB1B8 VA: 0xFCF1B8
	public PathFinding.Grid GetFindingGrid() { }

	// RVA: 0xFCFB4C Offset: 0xFCBB4C VA: 0xFCFB4C
	public bool IsNodeExisting(int nodex, int nodey) { }

	// RVA: 0xFCFCBC Offset: 0xFCBCBC VA: 0xFCFCBC
	public bool IsPositionExisting(int mapx, int mapy) { }

	// RVA: 0xFCFCE8 Offset: 0xFCBCE8 VA: 0xFCFCE8
	public long GetBarrier(float mapPositionX, float mapPositionY) { }

	// RVA: 0xFCFFF0 Offset: 0xFCBFF0 VA: 0xFCFFF0
	public bool HasBarrier(Position mapPosition) { }

	// RVA: 0xFD001C Offset: 0xFCC01C VA: 0xFD001C
	public void Clear() { }
}

// Namespace: game.resource.map
public class Obstacle // TypeDefIndex: 2390
{
	// Methods

	// RVA: 0xFCE7C0 Offset: 0xFCA7C0 VA: 0xFCE7C0
	public void .ctor() { }
}

// Namespace: game.resource.map
internal class Parse // TypeDefIndex: 2391
{
	// Methods

	// RVA: 0xFD025C Offset: 0xFCC25C VA: 0xFD025C
	public static Element NodeElements(string mapRootPath, Position.Sequential.Node[] nodeList, Config.Textures mapConfig) { }

	// RVA: 0xFD0568 Offset: 0xFCC568 VA: 0xFD0568
	public void .ctor() { }
}

// Namespace: 
public class PathFinding.Node // TypeDefIndex: 2392
{
	// Fields
	public int x; // 0x10
	public int y; // 0x14
	public bool walkable; // 0x18
	public int mapX; // 0x1C
	public int mapY; // 0x20

	// Methods

	// RVA: 0xFD14A0 Offset: 0xFCD4A0 VA: 0xFD14A0
	public void .ctor() { }
}

// Namespace: 
public class PathFinding.OpenNode // TypeDefIndex: 2393
{
	// Fields
	public readonly PathFinding.Node originNode; // 0x10
	public PathFinding.OpenNode parent; // 0x18
	public float g; // 0x20
	public float f; // 0x24
	public float h; // 0x28
	public bool opened; // 0x2C
	public bool closed; // 0x2D

	// Methods

	// RVA: 0xFD22D0 Offset: 0xFCE2D0 VA: 0xFD22D0
	public void .ctor(PathFinding.Node node) { }
}

// Namespace: 
public class PathFinding.Grid // TypeDefIndex: 2394
{
	// Fields
	public const int OBSTACLE_HORIZONTAL_WIDTH = 32;
	public const int OBSTACLE_HORIZONTAL_COUNT = 16;
	public const int OBSTACLE_VERTICAL_HEIGHT = 16;
	public const int OBSTACLE_VERTICAL_COUNT = 32;
	public int width; // 0x10
	public int height; // 0x14
	public readonly List<List<PathFinding.Node>> nodes; // 0x18
	public int areaNodeTop; // 0x20
	public int areaNodeLeft; // 0x24

	// Methods

	// RVA: 0xFCF2BC Offset: 0xFCB2BC VA: 0xFCF2BC
	public void .ctor(Dictionary<int, Dictionary<int, Obstacle.Data>> mapping) { }

	// RVA: 0xFD1CEC Offset: 0xFCDCEC VA: 0xFD1CEC
	public void .ctor(MapList.MapInfo mapInfo, List<Element.Obstacle> obstacleList) { }

	// RVA: 0xFD0C64 Offset: 0xFCCC64 VA: 0xFD0C64
	public bool IsInside(int x, int y) { }

	// RVA: 0xFD2300 Offset: 0xFCE300 VA: 0xFD2300
	public bool IsWalkableAt(int x, int y) { }

	// RVA: 0xFD0920 Offset: 0xFCC920 VA: 0xFD0920
	public PathFinding.Node GetNodeAt(int x, int y) { }

	// RVA: 0xFD23C8 Offset: 0xFCE3C8 VA: 0xFD23C8
	public List<PathFinding.Node> GetNeighbors(PathFinding.Node node) { }

	// RVA: 0xFD0C98 Offset: 0xFCCC98 VA: 0xFD0C98
	public bool TryGetWalkableNode(int x, int y, out int desx, out int desy) { }
}

// Namespace: 
public static class PathFinding.Finders.AStar // TypeDefIndex: 2395
{
	// Fields
	private static readonly float SQRT2; // 0x0

	// Methods

	// RVA: 0xFD2BC8 Offset: 0xFCEBC8 VA: 0xFD2BC8
	public static List<PathFinding.Node> Backtrace(PathFinding.OpenNode node) { }

	// RVA: 0xFD14B0 Offset: 0xFCD4B0 VA: 0xFD14B0
	public static List<PathFinding.Node> FindPath(PathFinding.Grid grid, int startX, int startY, int endX, int endY) { }

	// RVA: 0xFD2CDC Offset: 0xFCECDC VA: 0xFD2CDC
	private static void .cctor() { }
}

// Namespace: 
public class PathFinding.Finders // TypeDefIndex: 2396
{
	// Methods

	// RVA: 0xFD29E0 Offset: 0xFCE9E0 VA: 0xFD29E0
	private static PathFinding.OpenNode TrackingOpenNode(Dictionary<int, Dictionary<int, PathFinding.OpenNode>> mapping, PathFinding.Node node) { }

	// RVA: 0xFD2BC0 Offset: 0xFCEBC0 VA: 0xFD2BC0
	public void .ctor() { }
}

// Namespace: game.resource.map
public class PathFinding // TypeDefIndex: 2397
{
	// Fields
	public const int constObstacleHorizontalWidth = 32;
	public const int constObstacleHorizontalCount = 16;
	public const int constObstacleVerticalHeight = 16;
	public const int constObstacleVerticalCount = 32;
	private static readonly List<PathFinding.Node> EmptyPaths; // 0x0
	private MapList.MapInfo info; // 0x10
	private bool isObstacleLoaded; // 0x18
	private PathFinding.Grid grid; // 0x20

	// Methods

	// RVA: 0xFD0570 Offset: 0xFCC570 VA: 0xFD0570
	private static List<PathFinding.Node> FindDirectLineWithObstacle(PathFinding.Grid grid, int startNodeX, int startNodeY, int endNodeX, int endNodeY, int endMapX, int endMapY, int approach3D) { }

	// RVA: 0xFD0A34 Offset: 0xFCCA34 VA: 0xFD0A34
	private static int GetHeightIndexFromMapY(MapList.MapInfo info, int mapY) { }

	// RVA: 0xFD0A90 Offset: 0xFCCA90 VA: 0xFD0A90
	private static int GetWidthIndexFromMapX(MapList.MapInfo info, int mapX) { }

	// RVA: 0xFD0AEC Offset: 0xFCCAEC VA: 0xFD0AEC
	private static bool TryGetNodeIndex(PathFinding.Grid manualGrid, int startMapX, int startMapY, int endMapX, int endMapY, out ValueTuple<int, int, int, int> nodes) { }

	// RVA: 0xFD10BC Offset: 0xFCD0BC VA: 0xFD10BC
	public void .ctor(Map map) { }

	// RVA: 0xFD10C4 Offset: 0xFCD0C4 VA: 0xFD10C4
	public void Reset(MapList.MapInfo mapinfo) { }

	// RVA: 0xFD10EC Offset: 0xFCD0EC VA: 0xFD10EC
	public static List<PathFinding.Node> FindingPath(PathFinding.Grid manualGrid, int startMapX, int startMapY, int endMapX, int endMapY, int targetApproach3D) { }

	// RVA: 0xFD18BC Offset: 0xFCD8BC VA: 0xFD18BC
	public static List<PathFinding.Node> FindByManualGrid(PathFinding.Grid manualGrid, int startMapX, int startMapY, int endMapX, int endMapY, int targetApproach3D) { }

	// RVA: 0xFD1950 Offset: 0xFCD950 VA: 0xFD1950
	public List<PathFinding.Node> FindByFullMap(int startMapX, int startMapY, int endMapX, int endMapY, int targetApproach3D) { }

	// RVA: 0xFD2238 Offset: 0xFCE238 VA: 0xFD2238
	private static void .cctor() { }
}

// Namespace: 
public enum Position.Command // TypeDefIndex: 2398
{
	// Fields
	public int value__; // 0x0
	public const Position.Command Continue = 0;
	public const Position.Command Break = 1;
}

// Namespace: 
public struct Position.Sequential.Grid // TypeDefIndex: 2399
{
	// Fields
	public int gridTop; // 0x0
	public int gridLeft; // 0x4

	// Methods

	// RVA: 0xFD3CEC Offset: 0xFCFCEC VA: 0xFD3CEC
	public void .ctor(int top, int left) { }

	// RVA: 0xFD3CF4 Offset: 0xFCFCF4 VA: 0xFD3CF4
	public Position.Grid ToPosition() { }
}

// Namespace: 
public struct Position.Sequential.Node // TypeDefIndex: 2400
{
	// Fields
	public int nodeTop; // 0x0
	public int nodeLeft; // 0x4

	// Methods

	// RVA: 0xFD1CE4 Offset: 0xFCDCE4 VA: 0xFD1CE4
	public void .ctor(int top, int left) { }

	// RVA: 0xFD3D88 Offset: 0xFCFD88 VA: 0xFD3D88
	public Position.Node ToPosition() { }
}

// Namespace: 
public struct Position.Sequential.Origin // TypeDefIndex: 2401
{
	// Fields
	public int top; // 0x0
	public int left; // 0x4

	// Methods

	// RVA: 0xFD3E1C Offset: 0xFCFE1C VA: 0xFD3E1C
	public void .ctor(int top, int left) { }

	// RVA: 0xFD3E24 Offset: 0xFCFE24 VA: 0xFD3E24
	public Position ToPosition() { }
}

// Namespace: 
public class Position.Sequential // TypeDefIndex: 2402
{
	// Methods

	// RVA: 0xFD3CE4 Offset: 0xFCFCE4 VA: 0xFD3CE4
	public void .ctor() { }
}

// Namespace: 
public class Position.Cell // TypeDefIndex: 2403
{
	// Fields
	public int cellTop; // 0x10
	public int cellLeft; // 0x14

	// Properties
	public int cellX { get; set; }
	public int cellY { get; set; }

	// Methods

	// RVA: 0xFD3E8C Offset: 0xFCFE8C VA: 0xFD3E8C
	public int get_cellX() { }

	// RVA: 0xFD3E94 Offset: 0xFCFE94 VA: 0xFD3E94
	public void set_cellX(int value) { }

	// RVA: 0xFD3E9C Offset: 0xFCFE9C VA: 0xFD3E9C
	public int get_cellY() { }

	// RVA: 0xFD3EA4 Offset: 0xFCFEA4 VA: 0xFD3EA4
	public void set_cellY(int value) { }

	// RVA: 0xFD2EB4 Offset: 0xFCEEB4 VA: 0xFD2EB4
	public void .ctor() { }

	// RVA: 0xFD3EAC Offset: 0xFCFEAC VA: 0xFD3EAC
	public void .ctor(int _top, int _left) { }

	// RVA: 0xFD3ED8 Offset: 0xFCFED8 VA: 0xFD3ED8
	public Position.Node GetNode() { }
}

// Namespace: 
public class Position.Grid // TypeDefIndex: 2404
{
	// Fields
	public int gridTop; // 0x10
	public int gridLeft; // 0x14
	private Position.Node _node; // 0x18

	// Methods

	// RVA: 0xFD2F4C Offset: 0xFCEF4C VA: 0xFD2F4C
	public void .ctor() { }

	// RVA: 0xFD3D5C Offset: 0xFCFD5C VA: 0xFD3D5C
	public void .ctor(int _top, int _left) { }

	// RVA: 0xFD3F44 Offset: 0xFCFF44 VA: 0xFD3F44
	public Position.Node GetReferenceNode() { }
}

// Namespace: 
public class Position.Node // TypeDefIndex: 2405
{
	// Fields
	public int nodeTop; // 0x10
	public int nodeLeft; // 0x14

	// Methods

	// RVA: 0xFD2FE4 Offset: 0xFCEFE4 VA: 0xFD2FE4
	public void .ctor() { }

	// RVA: 0xFD3DF0 Offset: 0xFCFDF0 VA: 0xFD3DF0
	public void .ctor(int _top, int _left) { }

	// RVA: 0xFD3FF0 Offset: 0xFCFFF0 VA: 0xFD3FF0
	public Position.Sequential.Node ToSequential() { }

	// RVA: 0xFD3FF8 Offset: 0xFCFFF8 VA: 0xFD3FF8
	public Position.Cell GetCell() { }
}

// Namespace: game.resource.map
public class Position // TypeDefIndex: 2406
{
	// Fields
	public int top; // 0x10
	public int left; // 0x14
	private const float quantize8DirectionBandwidth = 0.25;
	private const float quantize8DirectionX1 = 1;
	private const float quantize8DirectionX2 = 0.65;
	private const float quantize8DirectionY1 = 0.35;
	private const float quantize8DirectionY2 = 0.7;
	private static readonly List<Vector2> quantize8DirectionTrigger; // 0x0

	// Properties
	public int x { get; set; }
	public int y { get; set; }
	public static Position Zero { get; }

	// Methods

	// RVA: 0xFD2D50 Offset: 0xFCED50 VA: 0xFD2D50
	public int get_x() { }

	// RVA: 0xFD2D58 Offset: 0xFCED58 VA: 0xFD2D58
	public void set_x(int value) { }

	// RVA: 0xFD2D60 Offset: 0xFCED60 VA: 0xFD2D60
	public int get_y() { }

	// RVA: 0xFD2D68 Offset: 0xFCED68 VA: 0xFD2D68
	public void set_y(int value) { }

	// RVA: 0xFD2D70 Offset: 0xFCED70 VA: 0xFD2D70
	public void .ctor() { }

	// RVA: 0xFD2D78 Offset: 0xFCED78 VA: 0xFD2D78
	public void .ctor(Vector3 position) { }

	// RVA: 0xFD2DCC Offset: 0xFCEDCC VA: 0xFD2DCC
	public void .ctor(int _top, int _left) { }

	// RVA: 0xFD2DF8 Offset: 0xFCEDF8 VA: 0xFD2DF8
	public void .ctor(Position _position) { }

	// RVA: 0xFD2E2C Offset: 0xFCEE2C VA: 0xFD2E2C
	public Position.Cell GetCell() { }

	// RVA: 0xFD2EBC Offset: 0xFCEEBC VA: 0xFD2EBC
	public Position.Grid GetGrid() { }

	// RVA: 0xFD2F54 Offset: 0xFCEF54 VA: 0xFD2F54
	public Position.Node GetNode() { }

	// RVA: 0xFD2FEC Offset: 0xFCEFEC VA: 0xFD2FEC
	public Vector3 GetCameraPosition(int z = -10) { }

	// RVA: 0xFD300C Offset: 0xFCF00C VA: 0xFD300C
	public static double GetDistanceFlat(int currentX, int currentY, int targetX, int targetY) { }

	// RVA: 0xFD3090 Offset: 0xFCF090 VA: 0xFD3090
	public double GetDistanceFlat(Position target) { }

	// RVA: 0xFD09A8 Offset: 0xFCC9A8 VA: 0xFD09A8
	public static int GetDistance3D(int currentX, int currentY, int targetX, int targetY) { }

	// RVA: 0xFD310C Offset: 0xFCF10C VA: 0xFD310C
	public int GetDistance3D(Position target) { }

	// RVA: 0xFD3188 Offset: 0xFCF188 VA: 0xFD3188
	public Position GetDestinateByDirectionIndex64(int direction, int radius) { }

	// RVA: 0xFD324C Offset: 0xFCF24C VA: 0xFD324C
	public Position GetDestinateByDirection8(int direction, int radius) { }

	// RVA: 0xFD32C4 Offset: 0xFCF2C4 VA: 0xFD32C4
	public Position GetDestinateByPosition(Position target, int radius) { }

	// RVA: 0xFD3360 Offset: 0xFCF360 VA: 0xFD3360
	public static float GetRatio3D(float currentX, float currentY, float targetX, float targetY, float valueInFlat) { }

	// RVA: 0xFD34BC Offset: 0xFCF4BC VA: 0xFD34BC
	public float GetRatio3D(float targetX, float targetY, float valueInFlat) { }

	// RVA: 0xFD3540 Offset: 0xFCF540 VA: 0xFD3540
	public int GetDirection8(int targetTop, int targetLeft) { }

	// RVA: 0xFD35C8 Offset: 0xFCF5C8 VA: 0xFD35C8
	public int GetDirection8(Position targetPosition) { }

	// RVA: 0xFD35E0 Offset: 0xFCF5E0 VA: 0xFD35E0
	public int GetDir3DIndex64(Position target) { }

	// RVA: 0xFD3660 Offset: 0xFCF660 VA: 0xFD3660
	public bool IsInVisibility(Position.Cell target) { }

	// RVA: 0xFD36D0 Offset: 0xFCF6D0 VA: 0xFD36D0
	public bool IsInVisibility(Position target) { }

	// RVA: 0xFD36F8 Offset: 0xFCF6F8 VA: 0xFD36F8
	public static Vector2 Quantize8DirectionAxis(Vector2 input) { }

	// RVA: 0xFD38B0 Offset: 0xFCF8B0 VA: 0xFD38B0
	public static Position get_Zero() { }

	// RVA: 0xFD3908 Offset: 0xFCF908 VA: 0xFD3908
	private static void .cctor() { }
}

// Namespace: 
public enum Preparing.Command.ID // TypeDefIndex: 2407
{
	// Fields
	public int value__; // 0x0
	public const Preparing.Command.ID unidentified = 0;
	public const Preparing.Command.ID central = 1;
	public const Preparing.Command.ID reset = 2;
	public const Preparing.Command.ID release = 3;
	public const Preparing.Command.ID addNpc = 4;
	public const Preparing.Command.ID hideNpc = 5;
	public const Preparing.Command.ID removeNpc = 6;
	public const Preparing.Command.ID enableCache = 7;
	public const Preparing.Command.ID fps = 8;
	public const Preparing.Command.ID nodeObstacle = 9;
	public const Preparing.Command.ID nodeTrap = 10;
	public const Preparing.Command.ID textureConfig = 11;
	public const Preparing.Command.ID addGameObject = 12;
	public const Preparing.Command.ID removeGameObject = 13;
	public const Preparing.Command.ID PerformAction = 14;
}

// Namespace: 
public class Preparing.Command.Element // TypeDefIndex: 2408
{
	// Fields
	public Preparing.Command.ID commandID; // 0x10

	// Methods

	// RVA: 0xFD78E0 Offset: 0xFD38E0 VA: 0xFD78E0
	public void .ctor(Preparing.Command.ID _commandId) { }
}

// Namespace: 
public class Preparing.Command.Central : Preparing.Command.Element // TypeDefIndex: 2409
{
	// Fields
	public Position originPosition; // 0x18

	// Methods

	// RVA: 0xFD46C0 Offset: 0xFD06C0 VA: 0xFD46C0
	public void .ctor(Position originPosition) { }
}

// Namespace: 
public class Preparing.Command.Reset : Preparing.Command.Element // TypeDefIndex: 2410
{
	// Fields
	public Config.Textures newMapConfig; // 0x14
	public MapList.MapInfo newMapInfo; // 0x30
	public bool clearMapTextures; // 0x38
	public bool clearSpecialNpc; // 0x39
	public bool clearNormalNpc; // 0x3A

	// Methods

	// RVA: 0xFD47FC Offset: 0xFD07FC VA: 0xFD47FC
	public void .ctor(Config.Textures newMapConfig, MapList.MapInfo newMapInfo, bool clearMapTextures = True, bool clearSpecialNpc = True, bool clearNormalNpc = True) { }
}

// Namespace: 
public class Preparing.Command.Release : Preparing.Command.Element // TypeDefIndex: 2411
{
	// Fields
	public Action onReleased; // 0x18

	// Methods

	// RVA: 0xFD4920 Offset: 0xFD0920 VA: 0xFD4920
	public void .ctor() { }
}

// Namespace: 
public class Preparing.Command.AddNpc : Preparing.Command.Element // TypeDefIndex: 2412
{
	// Fields
	public Controller special; // 0x18
	public Controller normal; // 0x20

	// Methods

	// RVA: 0xFD49E8 Offset: 0xFD09E8 VA: 0xFD49E8
	public void .ctor(Controller special, Controller normal) { }
}

// Namespace: 
public class Preparing.Command.HideNpc : Preparing.Command.Element // TypeDefIndex: 2413
{
	// Fields
	public Controller special; // 0x18
	public Controller normal; // 0x20

	// Methods

	// RVA: 0xFD4ADC Offset: 0xFD0ADC VA: 0xFD4ADC
	public void .ctor(Controller special, Controller normal) { }
}

// Namespace: 
public class Preparing.Command.RemoveNpc : Preparing.Command.Element // TypeDefIndex: 2414
{
	// Fields
	public Controller special; // 0x18
	public Controller normal; // 0x20

	// Methods

	// RVA: 0xFD4BD0 Offset: 0xFD0BD0 VA: 0xFD4BD0
	public void .ctor(Controller special, Controller normal) { }
}

// Namespace: 
public class Preparing.Command.EnableCache : Preparing.Command.Element // TypeDefIndex: 2415
{
	// Fields
	public bool groundNode; // 0x14
	public bool groundObject; // 0x15
	public bool tree; // 0x16
	public bool buildingUnder; // 0x17
	public bool buildingAbove; // 0x18

	// Methods

	// RVA: 0xFD4EB0 Offset: 0xFD0EB0 VA: 0xFD4EB0
	public void .ctor(bool groundNode, bool groundObject, bool tree, bool buildingUnder, bool buildingAbove) { }
}

// Namespace: 
public class Preparing.Command.FPS : Preparing.Command.Element // TypeDefIndex: 2416
{
	// Fields
	public int fps; // 0x14

	// Methods

	// RVA: 0xFD4FA4 Offset: 0xFD0FA4 VA: 0xFD4FA4
	public void .ctor(int fps) { }
}

// Namespace: 
public class Preparing.Command.NodeObstacleAdd : Preparing.Command.Element // TypeDefIndex: 2417
{
	// Fields
	public Element.Obstacle[] obstacle; // 0x18

	// Methods

	// RVA: 0xFD43F8 Offset: 0xFD03F8 VA: 0xFD43F8
	public void .ctor(Element.Obstacle[] obstacle) { }
}

// Namespace: 
public class Preparing.Command.NodeTrapAdd : Preparing.Command.Element // TypeDefIndex: 2418
{
	// Fields
	public MapRegionTrap data; // 0x18

	// Methods

	// RVA: 0xFD44D4 Offset: 0xFD04D4 VA: 0xFD44D4
	public void .ctor(MapRegionTrap data) { }
}

// Namespace: 
public class Preparing.Command.TextureConfig : Preparing.Command.Element // TypeDefIndex: 2419
{
	// Fields
	public Config.Textures mapconfig; // 0x14
	public MapList.MapInfo mapinfo; // 0x30
	public bool clearMaptextures; // 0x38
	public bool clearSpecialNpc; // 0x39
	public bool clearNormalNpc; // 0x3A

	// Methods

	// RVA: 0xFD50DC Offset: 0xFD10DC VA: 0xFD50DC
	public void .ctor(Config.Textures mapconfig, MapList.MapInfo mapinfo, bool clearMaptextures = True, bool clearSpecialNpc = False, bool clearNormalNpc = False) { }
}

// Namespace: 
public class Preparing.Command.AddGameObject : Preparing.Command.Element // TypeDefIndex: 2420
{
	// Fields
	public Object gameobject; // 0x18

	// Methods

	// RVA: 0xFD4CC0 Offset: 0xFD0CC0 VA: 0xFD4CC0
	public void .ctor(Object gameobject) { }
}

// Namespace: 
public class Preparing.Command.RemoveGameObject : Preparing.Command.Element // TypeDefIndex: 2421
{
	// Fields
	public Object gameObject; // 0x18

	// Methods

	// RVA: 0xFD4D9C Offset: 0xFD0D9C VA: 0xFD4D9C
	public void .ctor(Object gameObject) { }
}

// Namespace: 
public class Preparing.Command.PerformAction : Preparing.Command.Element // TypeDefIndex: 2422
{
	// Fields
	public readonly Action action; // 0x18

	// Methods

	// RVA: 0xFD520C Offset: 0xFD120C VA: 0xFD520C
	public void .ctor(Action action) { }
}

// Namespace: 
public class Preparing.Command // TypeDefIndex: 2423
{
	// Methods

	// RVA: 0xFD78D8 Offset: 0xFD38D8 VA: 0xFD78D8
	public void .ctor() { }
}

// Namespace: game.resource.map
internal class Preparing // TypeDefIndex: 2424
{
	// Fields
	private readonly Thread mainThreadHandle; // 0x10
	private readonly Queue<Element> nodeElementsQueue; // 0x18
	private readonly ConcurrentQueue<Preparing.Command.Element> commandQueue; // 0x20
	private Textures textureThread; // 0x28
	private Config.Textures textureConfig; // 0x30
	private MapList.MapInfo mapInfo; // 0x50
	private Obstacle.Barrier obstacleBarrier; // 0x58
	private Position.Grid currentGridPosition; // 0x60
	private Position currentOriginPosition; // 0x68
	private readonly Dictionary<int, Dictionary<int, Dictionary<int, Dictionary<int, List<Element.Texture>>>>> cacheGridTextures; // 0x70

	// Methods

	// RVA: 0xFD4080 Offset: 0xFD0080 VA: 0xFD4080
	public void .ctor() { }

	// RVA: 0xFD4238 Offset: 0xFD0238 VA: 0xFD4238
	public void Initialize(Config.Textures _textureConfig, MapList.MapInfo _mapInfo, Textures _texutureThread, Obstacle.Barrier _obstacleBarrier) { }

	// RVA: 0xFD4354 Offset: 0xFD0354 VA: 0xFD4354
	public void PushNodeObstacle(Element.Obstacle[] obstacles) { }

	// RVA: 0xFD4430 Offset: 0xFD0430 VA: 0xFD4430
	public void PushNodeTrap(MapRegionTrap data) { }

	// RVA: 0xFD450C Offset: 0xFD050C VA: 0xFD450C
	public void PushNodeElements(Element _nodeElements) { }

	// RVA: 0xFD461C Offset: 0xFD061C VA: 0xFD461C
	public void SetCentral(Position _originPosition) { }

	// RVA: 0xFD46F8 Offset: 0xFD06F8 VA: 0xFD46F8
	public void Reset(Config.Textures _mapConfig, MapList.MapInfo _mapInfo, bool clearMaptextures = True, bool clearSpecialNpc = True, bool clearNormalNpc = False) { }

	// RVA: 0xFD487C Offset: 0xFD087C VA: 0xFD487C
	public void Release(Action onReleased) { }

	// RVA: 0xFD4940 Offset: 0xFD0940 VA: 0xFD4940
	public void AddDynamicNpc(Controller npc) { }

	// RVA: 0xFD4A34 Offset: 0xFD0A34 VA: 0xFD4A34
	public void HideNpc(Controller npc) { }

	// RVA: 0xFD4B28 Offset: 0xFD0B28 VA: 0xFD4B28
	public void RemoveNpc(Controller npc) { }

	// RVA: 0xFD4C1C Offset: 0xFD0C1C VA: 0xFD4C1C
	public void AddGameObject(Object gameobject) { }

	// RVA: 0xFD4CF8 Offset: 0xFD0CF8 VA: 0xFD4CF8
	public void RemoveGameObject(Object gameObject) { }

	// RVA: 0xFD4DD4 Offset: 0xFD0DD4 VA: 0xFD4DD4
	public void EnableCache(bool groundNode, bool groundObject, bool tree, bool buildingUnder, bool buildingAbove) { }

	// RVA: 0xFD4F10 Offset: 0xFD0F10 VA: 0xFD4F10
	public void SetFPS(int fps) { }

	// RVA: 0xFD4FD0 Offset: 0xFD0FD0 VA: 0xFD4FD0
	public void TextureConfig(Config.Textures mapconfig, MapList.MapInfo mapinfo, bool clearMaptextures = True, bool clearSpecialNpc = False, bool clearNormalNpc = False) { }

	// RVA: 0xFD5168 Offset: 0xFD1168 VA: 0xFD5168
	public void PerformAction(Action action) { }

	// RVA: 0xFD5244 Offset: 0xFD1244 VA: 0xFD5244
	private void MainThread() { }

	// RVA: 0xFD5978 Offset: 0xFD1978 VA: 0xFD5978
	private void MainThread_Central(Preparing.Command.Central _command) { }

	// RVA: 0xFD5780 Offset: 0xFD1780 VA: 0xFD5780
	private void MainThread_Reset(Preparing.Command.Reset _command) { }

	// RVA: 0xFD6F4C Offset: 0xFD2F4C VA: 0xFD6F4C
	private void MainThread_AddNpc(Preparing.Command.AddNpc _command) { }

	// RVA: 0xFD7130 Offset: 0xFD3130 VA: 0xFD7130
	private void MainThread_HideNpc(Preparing.Command.HideNpc _command) { }

	// RVA: 0xFD7214 Offset: 0xFD3214 VA: 0xFD7214
	private void MainThread_RemoveNpc(Preparing.Command.RemoveNpc command) { }

	// RVA: 0xFD72F8 Offset: 0xFD32F8 VA: 0xFD72F8
	private void MainThread_EnableCache(Preparing.Command.EnableCache _command) { }

	// RVA: 0xFD73C4 Offset: 0xFD33C4 VA: 0xFD73C4
	private void MainThread_FPS(Preparing.Command.FPS _command) { }

	// RVA: 0xFD7440 Offset: 0xFD3440 VA: 0xFD7440
	private void MainThread_NodeObstacleAdd(Element.Obstacle[] obstacle) { }

	// RVA: 0xFD7600 Offset: 0xFD3600 VA: 0xFD7600
	private void MainThread_NodeTrapAdd(MapRegionTrap data) { }

	// RVA: 0xFD7708 Offset: 0xFD3708 VA: 0xFD7708
	private void MainThread_TextureConfig(Preparing.Command.TextureConfig command) { }
}

// Namespace: 
public class Region.Cell // TypeDefIndex: 2425
{
	// Fields
	public readonly ConcurrentDictionary<Controller, bool> player; // 0x10
	public readonly ConcurrentDictionary<Controller, bool> npc; // 0x18

	// Methods

	// RVA: 0xFD7AA0 Offset: 0xFD3AA0 VA: 0xFD7AA0
	public void .ctor() { }
}

// Namespace: game.resource.map
public class Region // TypeDefIndex: 2426
{
	// Fields
	private Region.Cell[] cell; // 0x10
	private int horizonCount; // 0x18
	private int verticalCount; // 0x1C
	private int horizonLeft; // 0x20
	private int horizonRight; // 0x24
	private int verticalTop; // 0x28
	private int verticalBottom; // 0x2C

	// Methods

	// RVA: 0xFD7908 Offset: 0xFD3908 VA: 0xFD7908
	public void .ctor() { }

	// RVA: 0xFD7910 Offset: 0xFD3910 VA: 0xFD7910
	public void Initialize() { }

	// RVA: 0xFD7914 Offset: 0xFD3914 VA: 0xFD7914
	public void Reset(MapList.MapInfo mapInfo) { }

	// RVA: 0xFD7B4C Offset: 0xFD3B4C VA: 0xFD7B4C
	public Region.Cell GetCell(int cellX, int cellY) { }

	// RVA: 0xFD7BBC Offset: 0xFD3BBC VA: 0xFD7BBC
	public Region.Cell GetCell(Position.Cell cell) { }

	// RVA: 0xFD7BD4 Offset: 0xFD3BD4 VA: 0xFD7BD4
	public Controller AddNpc(Controller npc) { }

	// RVA: 0xFD7C7C Offset: 0xFD3C7C VA: 0xFD7C7C
	public bool RemoveNpc(Controller npc) { }

	// RVA: 0xFD7D14 Offset: 0xFD3D14 VA: 0xFD7D14
	public void UpdateNpc(Controller npc) { }

	// RVA: 0xFD7E40 Offset: 0xFD3E40 VA: 0xFD7E40
	public Controller AddPlayer(Controller player) { }

	// RVA: 0xFD7EE8 Offset: 0xFD3EE8 VA: 0xFD7EE8
	public bool RemovePlayer(Controller player) { }

	// RVA: 0xFD7F80 Offset: 0xFD3F80 VA: 0xFD7F80
	public void UpdatePlayer(Controller player) { }
}

// Namespace: game.resource.map
[IsReadOnly]
internal struct Static // TypeDefIndex: 2427
{
	// Fields
	public const int nodeMapDimension = 512;
	public const int gridMapDimension = 64;
	public const int obstacleGridWidth = 32;
	public const int obstacleGridHeight = 16;
}

// Namespace: 
private struct Surface.GridAreaCorners // TypeDefIndex: 2428
{
	// Fields
	public Position.Grid topLeft; // 0x0
	public Position.Grid topRight; // 0x8
	public Position.Grid bottomLeft; // 0x10
	public Position.Grid bottomRight; // 0x18
}

// Namespace: 
private struct Surface.NodeAreaCorners // TypeDefIndex: 2429
{
	// Fields
	public Position.Node topLeft; // 0x0
	public Position.Node topRight; // 0x8
	public Position.Node bottomLeft; // 0x10
	public Position.Node bottomRight; // 0x18
}

// Namespace: 
public struct Surface.GridChanged // TypeDefIndex: 2430
{
	// Fields
	public Dictionary<int, Dictionary<int, Position.Grid>> newGridPositions; // 0x0
	public Dictionary<int, Dictionary<int, Position.Grid>> removeGridPositions; // 0x8
}

// Namespace: 
public struct Surface.NodeChanged // TypeDefIndex: 2431
{
	// Fields
	public Dictionary<int, Dictionary<int, Position.Node>> newNodePositions; // 0x0
	public Dictionary<int, Dictionary<int, Position.Node>> removeNodePositions; // 0x8
}

// Namespace: 
public struct Surface.NodeGridChanged // TypeDefIndex: 2432
{
	// Fields
	public Surface.GridChanged grid; // 0x0
	public Surface.NodeChanged node; // 0x10
}

// Namespace: game.resource.map
internal class Surface // TypeDefIndex: 2433
{
	// Methods

	// RVA: 0xFD80B4 Offset: 0xFD40B4 VA: 0xFD80B4
	private static Surface.GridAreaCorners GridCorners(Position _originPosition, int _radiusHorizontalVisibility, int _radiusVerticalVisibility) { }

	// RVA: 0xFD822C Offset: 0xFD422C VA: 0xFD822C
	private static Surface.NodeAreaCorners NodeCorners(Position _originPosition, int _radiusHorizontalVisibility, int _radiusVerticalVisibility) { }

	// RVA: 0xFD83A4 Offset: 0xFD43A4 VA: 0xFD83A4
	private static Surface.GridChanged UpdateGrid(Position _oldOriginPosition, Position _newOriginPosition, int _radiusHorizontalVisibility, int _radiusVerticalVisibility) { }

	// RVA: 0xFD87AC Offset: 0xFD47AC VA: 0xFD87AC
	private static Surface.NodeChanged UpdateNode(Position _oldOriginPosition, Position _newOriginPosition, int _radiusHorizontalVisibility, int _radiusVerticalVisibility) { }

	// RVA: 0xFD784C Offset: 0xFD384C VA: 0xFD784C
	public static Surface.NodeGridChanged Update(Position _oldOriginPosition, Position _newOriginPosition, int _radiusHorizontalVisibility, int _radiusVerticalVisibility) { }

	// RVA: 0xFD8BB4 Offset: 0xFD4BB4 VA: 0xFD8BB4
	public void .ctor() { }
}

// Namespace: 
public enum Textures.Command.ID // TypeDefIndex: 2434
{
	// Fields
	public int value__; // 0x0
	public const Textures.Command.ID unidentified = 0;
	public const Textures.Command.ID nodeElements = 1;
	public const Textures.Command.ID addNewTexture = 2;
	public const Textures.Command.ID removeGrid = 3;
	public const Textures.Command.ID reset = 4;
	public const Textures.Command.ID addSpecialNpc = 5;
	public const Textures.Command.ID hideSpecialNpc = 6;
	public const Textures.Command.ID removeSpecialNpc = 7;
	public const Textures.Command.ID addNormalNpc = 8;
	public const Textures.Command.ID hideNormalNpc = 9;
	public const Textures.Command.ID removeNormalNpc = 10;
	public const Textures.Command.ID enableCache = 11;
	public const Textures.Command.ID fps = 12;
	public const Textures.Command.ID addObstacleGrid = 13;
	public const Textures.Command.ID removeNode = 14;
	public const Textures.Command.ID identification = 15;
	public const Textures.Command.ID castMissile = 16;
	public const Textures.Command.ID addTrap = 17;
	public const Textures.Command.ID addObject = 18;
	public const Textures.Command.ID removeObject = 19;
	public const Textures.Command.ID addToMixture = 20;
	public const Textures.Command.ID changeMinimapDot = 21;
	public const Textures.Command.ID resetMinimapPlayerDot = 22;
	public const Textures.Command.ID addDot = 23;
	public const Textures.Command.ID destroyAllDot = 24;
	public const Textures.Command.ID setMinimapDotAlpha = 25;
	public const Textures.Command.ID performAction = 26;
}

// Namespace: 
public class Textures.Command.Element // TypeDefIndex: 2435
{
	// Fields
	public Textures.Command.ID commandID; // 0x10

	// Methods

	// RVA: 0xFDED6C Offset: 0xFDAD6C VA: 0xFDED6C
	public void .ctor(Textures.Command.ID _commandId) { }
}

// Namespace: 
public class Textures.Command.NodeElements : Textures.Command.Element // TypeDefIndex: 2436
{
	// Fields
	public string mapRootPath; // 0x18
	public Position.Sequential.Node[] nodeList; // 0x20
	public Config.Textures mapConfig; // 0x28

	// Methods

	// RVA: 0xFDED94 Offset: 0xFDAD94 VA: 0xFDED94
	public void .ctor(string _mapRootPath, Position.Sequential.Node[] _nodeList, Config.Textures _mapConfig) { }
}

// Namespace: 
public class Textures.Command.AddNewTexture : Textures.Command.Element // TypeDefIndex: 2437
{
	// Fields
	public int elementType; // 0x14
	public Position.Sequential.Origin originPosition; // 0x18
	public string texturePath; // 0x20
	public ushort textureFrame; // 0x28
	public int order; // 0x2C
	public Position.Grid gridAssetPosition; // 0x30
	public int texturePathHash; // 0x38
	public int texturePathFrameHash; // 0x3C

	// Methods

	// RVA: 0xFDEE04 Offset: 0xFDAE04 VA: 0xFDEE04
	public void .ctor(Element.Texture elementTexture, Position.Grid gridPosition, int orderNumber) { }
}

// Namespace: 
public class Textures.Command.RemoveGrid : Textures.Command.Element // TypeDefIndex: 2438
{
	// Fields
	public Position.Grid gridPosition; // 0x18

	// Methods

	// RVA: 0xFDEF10 Offset: 0xFDAF10 VA: 0xFDEF10
	public void .ctor(Position.Grid gridPosition) { }
}

// Namespace: 
public class Textures.Command.Reset : Textures.Command.Element // TypeDefIndex: 2439
{
	// Fields
	public MapList.MapInfo mapInfo; // 0x18
	public bool clearMapTextures; // 0x20
	public bool clearSpecialNpc; // 0x21
	public bool clearNormalNpc; // 0x22

	// Methods

	// RVA: 0xFD97CC Offset: 0xFD57CC VA: 0xFD97CC
	public void .ctor(MapList.MapInfo mapInfo, bool clearMapTextures, bool clearSpecialNpc, bool clearNormalNpc) { }
}

// Namespace: 
public class Textures.Command.AddSpecialNpc : Textures.Command.Element // TypeDefIndex: 2440
{
	// Fields
	public Controller specialNpc; // 0x18

	// Methods

	// RVA: 0xFDEF48 Offset: 0xFDAF48 VA: 0xFDEF48
	public void .ctor(Controller _specialNpc) { }
}

// Namespace: 
public class Textures.Command.HideSpecialNpc : Textures.Command.Element // TypeDefIndex: 2441
{
	// Fields
	public Controller specialNpc; // 0x18

	// Methods

	// RVA: 0xFDEF80 Offset: 0xFDAF80 VA: 0xFDEF80
	public void .ctor(Controller _specialNpc) { }
}

// Namespace: 
public class Textures.Command.RemoveSpecialNpc : Textures.Command.Element // TypeDefIndex: 2442
{
	// Fields
	public Controller specialNpc; // 0x18

	// Methods

	// RVA: 0xFDEFB8 Offset: 0xFDAFB8 VA: 0xFDEFB8
	public void .ctor(Controller _specialNpc) { }
}

// Namespace: 
public class Textures.Command.AddNormalNpc : Textures.Command.Element // TypeDefIndex: 2443
{
	// Fields
	public Controller normalNpc; // 0x18

	// Methods

	// RVA: 0xFDEFF0 Offset: 0xFDAFF0 VA: 0xFDEFF0
	public void .ctor(Controller normalNpc) { }
}

// Namespace: 
public class Textures.Command.HideNormalNpc : Textures.Command.Element // TypeDefIndex: 2444
{
	// Fields
	public Controller normalNpc; // 0x18

	// Methods

	// RVA: 0xFDF028 Offset: 0xFDB028 VA: 0xFDF028
	public void .ctor(Controller normalNpc) { }
}

// Namespace: 
public class Textures.Command.RemoveNormalNpc : Textures.Command.Element // TypeDefIndex: 2445
{
	// Fields
	public Controller normalNpc; // 0x18

	// Methods

	// RVA: 0xFDF060 Offset: 0xFDB060 VA: 0xFDF060
	public void .ctor(Controller normalNpc) { }
}

// Namespace: 
public class Textures.Command.EnableCache : Textures.Command.Element // TypeDefIndex: 2446
{
	// Fields
	public bool groundNode; // 0x14
	public bool groundObject; // 0x15
	public bool tree; // 0x16
	public bool buildingUnder; // 0x17
	public bool buildingAbove; // 0x18

	// Methods

	// RVA: 0xFDF098 Offset: 0xFDB098 VA: 0xFDF098
	public void .ctor(bool groundNode, bool groundObject, bool tree, bool buildingUnder, bool buildingAbove) { }
}

// Namespace: 
public class Textures.Command.FPS : Textures.Command.Element // TypeDefIndex: 2447
{
	// Fields
	public int fps; // 0x14

	// Methods

	// RVA: 0xFDF0F8 Offset: 0xFDB0F8 VA: 0xFDF0F8
	public void .ctor(int fps) { }
}

// Namespace: 
public class Textures.Command.AddObstacleGrid : Textures.Command.Element // TypeDefIndex: 2448
{
	// Fields
	public Obstacle.Grid obstacleGrid; // 0x18
	public Vector2 scenePosition; // 0x20

	// Methods

	// RVA: 0xFDF124 Offset: 0xFDB124 VA: 0xFDF124
	public void .ctor(Obstacle.Grid obstacleGrid, Vector2 scenePosition) { }
}

// Namespace: 
public class Textures.Command.RemoveNode : Textures.Command.Element // TypeDefIndex: 2449
{
	// Fields
	public Position.Node nodePosition; // 0x18

	// Methods

	// RVA: 0xFDF174 Offset: 0xFDB174 VA: 0xFDF174
	public void .ctor(Position.Node nodePosition) { }
}

// Namespace: 
public class Textures.Command.Identification : Textures.Command.Element // TypeDefIndex: 2450
{
	// Fields
	public Config.Identification identification; // 0x14

	// Methods

	// RVA: 0xFD9A18 Offset: 0xFD5A18 VA: 0xFD9A18
	public void .ctor(Config.Identification identification) { }
}

// Namespace: 
public class Textures.Command.CastMissile : Textures.Command.Element // TypeDefIndex: 2451
{
	// Fields
	public List<Missile> missiles; // 0x18

	// Methods

	// RVA: 0xFD9AF0 Offset: 0xFD5AF0 VA: 0xFD9AF0
	public void .ctor(List<Missile> missiles) { }
}

// Namespace: 
public class Textures.Command.AddTrap : Textures.Command.Element // TypeDefIndex: 2452
{
	// Fields
	public Trap.Grid trapGrid; // 0x18
	public Vector2 scenePosition; // 0x20

	// Methods

	// RVA: 0xFDF1AC Offset: 0xFDB1AC VA: 0xFDF1AC
	public void .ctor(Trap.Grid trapGrid, Vector2 scenePosition) { }
}

// Namespace: 
public class Textures.Command.AddObject : Textures.Command.Element // TypeDefIndex: 2453
{
	// Fields
	public Object gameObject; // 0x18

	// Methods

	// RVA: 0xFD9BCC Offset: 0xFD5BCC VA: 0xFD9BCC
	public void .ctor(Object gameObject) { }
}

// Namespace: 
public class Textures.Command.RemoveObject : Textures.Command.Element // TypeDefIndex: 2454
{
	// Fields
	public Object gameObject; // 0x18

	// Methods

	// RVA: 0xFD9CA8 Offset: 0xFD5CA8 VA: 0xFD9CA8
	public void .ctor(Object gameObject) { }
}

// Namespace: 
public class Textures.Command.AddToMixture : Textures.Command.Element // TypeDefIndex: 2455
{
	// Fields
	public GameObject go; // 0x18

	// Methods

	// RVA: 0xFD9D84 Offset: 0xFD5D84 VA: 0xFD9D84
	public void .ctor(GameObject go) { }
}

// Namespace: 
public class Textures.Command.ChangeMinimapDot : Textures.Command.Element // TypeDefIndex: 2456
{
	// Fields
	public Controller controller; // 0x18
	public MiniMap.PointColor sprite; // 0x20

	// Methods

	// RVA: 0xFD9E50 Offset: 0xFD5E50 VA: 0xFD9E50
	public void .ctor(Controller controller, MiniMap.PointColor sprite) { }
}

// Namespace: 
public class Textures.Command.ResetMinimapPlayerDot : Textures.Command.Element // TypeDefIndex: 2457
{
	// Methods

	// RVA: 0xFD9F24 Offset: 0xFD5F24 VA: 0xFD9F24
	public void .ctor() { }
}

// Namespace: 
public class Textures.Command.AddDot : Textures.Command.Element // TypeDefIndex: 2458
{
	// Fields
	public int mapx; // 0x14
	public int mapy; // 0x18
	public Color color; // 0x1C
	public int width; // 0x2C
	public int height; // 0x30
	public int layer; // 0x34
	public int order; // 0x38

	// Methods

	// RVA: 0xFDA040 Offset: 0xFD6040 VA: 0xFDA040
	public void .ctor(int mapx, int mapy, Color color, int width = 5, int height = 5, int layer = 7, int order = 0) { }
}

// Namespace: 
public class Textures.Command.DestroyAllDot : Textures.Command.Element // TypeDefIndex: 2459
{
	// Methods

	// RVA: 0xFDA15C Offset: 0xFD615C VA: 0xFDA15C
	public void .ctor() { }
}

// Namespace: 
public class Textures.Command.SetMinimapDotAlpha : Textures.Command.Element // TypeDefIndex: 2460
{
	// Fields
	public Controller controller; // 0x18
	public int alphaPercent; // 0x20

	// Methods

	// RVA: 0xFDA230 Offset: 0xFD6230 VA: 0xFDA230
	public void .ctor(Controller controller, int alphaPercent) { }
}

// Namespace: 
public class Textures.Command.PerformAction : Textures.Command.Element // TypeDefIndex: 2461
{
	// Fields
	public readonly Action action; // 0x18

	// Methods

	// RVA: 0xFDA320 Offset: 0xFD6320 VA: 0xFDA320
	public void .ctor(Action action) { }
}

// Namespace: 
public class Textures.Command // TypeDefIndex: 2462
{
	// Methods

	// RVA: 0xFDED64 Offset: 0xFDAD64 VA: 0xFDED64
	public void .ctor() { }
}

// Namespace: 
private class Textures.DotElement // TypeDefIndex: 2463
{
	// Fields
	public Texture2D texture; // 0x10
	public Sprite sprite; // 0x18
	public SpriteRenderer spriteRenderer; // 0x20
	public GameObject go; // 0x28

	// Methods

	// RVA: 0xFDEA00 Offset: 0xFDAA00 VA: 0xFDEA00
	public void .ctor() { }
}

// Namespace: 
private class Textures.GridElement // TypeDefIndex: 2464
{
	// Fields
	public GameObject current; // 0x10
	public SpriteRenderer compSpriteRenderer; // 0x18

	// Methods

	// RVA: 0xFDB718 Offset: 0xFD7718 VA: 0xFDB718
	public void .ctor() { }
}

// Namespace: 
private class Textures.SpriteCache // TypeDefIndex: 2465
{
	// Fields
	public bool groundNodeEnabled; // 0x10
	public bool groundObjectEnabled; // 0x11
	public bool treeEnabled; // 0x12
	public bool buildingUnderEnabled; // 0x13
	public bool buildingAboveEnabled; // 0x14

	// Methods

	// RVA: 0xFDC4BC Offset: 0xFD84BC VA: 0xFDC4BC
	public void Clear() { }

	// RVA: 0xFDB68C Offset: 0xFD768C VA: 0xFDB68C
	public SpriteLimitForMap.Frame GetGroundNode(string path, ushort frame, int pathHash, int pathFrameHash) { }

	// RVA: 0xFDB6A8 Offset: 0xFD76A8 VA: 0xFDB6A8
	public SpriteLimitForMap.Frame GetGroundObject(string path, ushort frame, int pathHash, int pathFrameHash) { }

	// RVA: 0xFDB6C4 Offset: 0xFD76C4 VA: 0xFDB6C4
	public SpriteLimitForMap.Frame GetTree(string path, ushort frame, int pathHash, int pathFrameHash) { }

	// RVA: 0xFDB6E0 Offset: 0xFD76E0 VA: 0xFDB6E0
	public SpriteLimitForMap.Frame GetBuildingUnder(string path, ushort frame, int pathHash, int pathFrameHash) { }

	// RVA: 0xFDB6FC Offset: 0xFD76FC VA: 0xFDB6FC
	public SpriteLimitForMap.Frame GetBuildingAbove(string path, ushort frame, int pathHash, int pathFrameHash) { }

	// RVA: 0xFDF580 Offset: 0xFDB580 VA: 0xFDF580
	public SpriteLimitForMap.Frame GetFrame(bool caching, string path, ushort frame, int pathHash, int pathFrameHash) { }

	// RVA: 0xFD9670 Offset: 0xFD5670 VA: 0xFD9670
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Textures.<>c__DisplayClass62_0 // TypeDefIndex: 2466
{
	// Fields
	public KeyValuePair<Controller, bool> index; // 0x10

	// Methods

	// RVA: 0xFDDAA8 Offset: 0xFD9AA8 VA: 0xFDDAA8
	public void .ctor() { }

	// RVA: 0xFDFC3C Offset: 0xFDBC3C VA: 0xFDFC3C
	internal void <Command_Identification>b__0() { }
}

// Namespace: game.resource.map
internal class Textures // TypeDefIndex: 2467
{
	// Fields
	private Config.Identification identifyConfig; // 0x10
	private Preparing preparingThread; // 0x18
	private Layer layers; // 0x20
	private MiniMap miniMap; // 0x28
	private Missile missileThread; // 0x30
	private Region region; // 0x38
	private readonly ConcurrentQueue<Textures.Command.Element> commandQueue; // 0x40
	private readonly Textures.SpriteCache spriteCache; // 0x48
	private readonly Dictionary<int, Dictionary<int, List<Textures.GridElement>>> ownedByGrid; // 0x50
	private readonly Dictionary<int, Dictionary<int, GameObject>> ownedByNode; // 0x58
	private readonly Dictionary<Controller, bool> specialNpcs; // 0x60
	private readonly Dictionary<Controller, bool> normalNpcs; // 0x68
	private readonly Dictionary<Missile, bool> missiles; // 0x70
	private readonly Dictionary<Object, bool> objects; // 0x78
	private int progressingMillisecondsInCycle; // 0x80
	private Dictionary<Textures.DotElement, bool> dotElements; // 0x88
	private readonly Stopwatch updateCommandStopwatch; // 0x90
	private readonly Dictionary<Textures.Command.ID, Action<Textures.Command.Element>> updateCommandFunctions; // 0x98
	private readonly List<Missile> updateMissile_removeListing; // 0xA0
	private readonly List<Object> updateObject_removeListing; // 0xA8

	// Methods

	// RVA: 0xFD8BBC Offset: 0xFD4BBC VA: 0xFD8BBC
	public void .ctor() { }

	// RVA: 0xFD9678 Offset: 0xFD5678 VA: 0xFD9678
	public void Initialize(Config.Identification identification, Preparing _preparingThread, Layer _layers, MiniMap _miniMap, Missile missileThread, Region region) { }

	// RVA: 0xFD96FC Offset: 0xFD56FC VA: 0xFD96FC
	public void Reset(MapList.MapInfo mapInfo, bool _clearMapTextures, bool _clearSpecialNpc, bool _clearNormalNpc) { }

	// RVA: 0xFD9828 Offset: 0xFD5828 VA: 0xFD9828
	public void PushParseNodes(Textures.Command.NodeElements _command) { }

	// RVA: 0xFD9880 Offset: 0xFD5880 VA: 0xFD9880
	public void PushCommand(Textures.Command.Element _command) { }

	// RVA: 0xFD98D8 Offset: 0xFD58D8 VA: 0xFD98D8
	public void PushVector(List<Textures.Command.Element> _vector) { }

	// RVA: 0xFD997C Offset: 0xFD597C VA: 0xFD997C
	public void SetIdentification(Config.Identification identification) { }

	// RVA: 0xFD9A4C Offset: 0xFD5A4C VA: 0xFD9A4C
	public void CastMissile(List<Missile> missiles) { }

	// RVA: 0xFD9B28 Offset: 0xFD5B28 VA: 0xFD9B28
	public void AddObject(Object gameObject) { }

	// RVA: 0xFD9C04 Offset: 0xFD5C04 VA: 0xFD9C04
	public void RemoveObject(Object gameObject) { }

	// RVA: 0xFD9CE0 Offset: 0xFD5CE0 VA: 0xFD9CE0
	public void AddToMixture(GameObject go) { }

	// RVA: 0xFD9DBC Offset: 0xFD5DBC VA: 0xFD9DBC
	public void ChangeMiniMap(Controller controller, MiniMap.PointColor sprite) { }

	// RVA: 0xFD9E9C Offset: 0xFD5E9C VA: 0xFD9E9C
	public void ResetMiniMapPlayerDot() { }

	// RVA: 0xFD9F44 Offset: 0xFD5F44 VA: 0xFD9F44
	public void AddDot(int mapx, int mapy, Color color, int width = 5, int height = 5, int layer = 7, int order = 0) { }

	// RVA: 0xFDA0D4 Offset: 0xFD60D4 VA: 0xFDA0D4
	public void DestroyAllDot() { }

	// RVA: 0xFDA17C Offset: 0xFD617C VA: 0xFDA17C
	public void SetMinimapDotAlpha(Controller controller, int alphaPercent) { }

	// RVA: 0xFDA27C Offset: 0xFD627C VA: 0xFDA27C
	public void PerformAction(Action action) { }

	// RVA: 0xFDA358 Offset: 0xFD6358 VA: 0xFDA358
	public void Update() { }

	// RVA: 0xFDA388 Offset: 0xFD6388 VA: 0xFDA388
	private void Update_Missiles() { }

	// RVA: 0xFDA774 Offset: 0xFD6774 VA: 0xFDA774
	private void Update_SpecialNpc() { }

	// RVA: 0xFDA9CC Offset: 0xFD69CC VA: 0xFDA9CC
	private void Update_NormalNpc() { }

	// RVA: 0xFDAC3C Offset: 0xFD6C3C VA: 0xFDAC3C
	private void Update_Object() { }

	// RVA: 0xFDAFF8 Offset: 0xFD6FF8 VA: 0xFDAFF8
	private void Update_MapCommands() { }

	// RVA: 0xFDB0E0 Offset: 0xFD70E0 VA: 0xFDB0E0
	private void Command_NodeElement(Textures.Command.Element command) { }

	// RVA: 0xFDB1A0 Offset: 0xFD71A0 VA: 0xFDB1A0
	private void Command_AddNewTexture(Textures.Command.Element command) { }

	// RVA: 0xFDB720 Offset: 0xFD7720 VA: 0xFDB720
	private void Command_RemoveGridDestroyGameObjects(List<Textures.GridElement> _gameObjects) { }

	// RVA: 0xFDB8BC Offset: 0xFD78BC VA: 0xFDB8BC
	private void Command_RemoveGrid(Textures.Command.Element command) { }

	// RVA: 0xFDBA4C Offset: 0xFD7A4C VA: 0xFDBA4C
	private void Command_Reset(Textures.Command.Element command) { }

	// RVA: 0xFDC50C Offset: 0xFD850C VA: 0xFDC50C
	private void Command_AddSpecialNpc(Textures.Command.Element command) { }

	// RVA: 0xFDC744 Offset: 0xFD8744 VA: 0xFDC744
	private void Command_HideSpecialNpc(Textures.Command.Element command) { }

	// RVA: 0xFDC8B4 Offset: 0xFD88B4 VA: 0xFDC8B4
	private void Command_RemoveSpecialNpc(Textures.Command.Element _command) { }

	// RVA: 0xFDC9A0 Offset: 0xFD89A0 VA: 0xFDC9A0
	private void Command_AddNormalNpc(Textures.Command.Element command) { }

	// RVA: 0xFDCB58 Offset: 0xFD8B58 VA: 0xFDCB58
	private void Command_HideNormalNpc(Textures.Command.Element command) { }

	// RVA: 0xFDCCC8 Offset: 0xFD8CC8 VA: 0xFDCCC8
	private void Command_RemoveNormalNpc(Textures.Command.Element _command) { }

	// RVA: 0xFDCDB4 Offset: 0xFD8DB4 VA: 0xFDCDB4
	private void Command_EnableCache(Textures.Command.Element command) { }

	// RVA: 0xFDCE4C Offset: 0xFD8E4C VA: 0xFDCE4C
	private void Command_FPS(Textures.Command.Element command) { }

	// RVA: 0xFDCF20 Offset: 0xFD8F20 VA: 0xFDCF20
	private void Command_AddObstacleGrid(Textures.Command.Element command) { }

	// RVA: 0xFDD280 Offset: 0xFD9280 VA: 0xFDD280
	private void Command_RemoveNode(Textures.Command.Element command) { }

	// RVA: 0xFDD40C Offset: 0xFD940C VA: 0xFDD40C
	private void Command_Identification(Textures.Command.Element command) { }

	// RVA: 0xFDDAB0 Offset: 0xFD9AB0 VA: 0xFDDAB0
	private void Command_CastMissiles(Textures.Command.Element command) { }

	// RVA: 0xFDDD88 Offset: 0xFD9D88 VA: 0xFDDD88
	private void Command_AddTrap(Textures.Command.Element _command) { }

	// RVA: 0xFDE144 Offset: 0xFDA144 VA: 0xFDE144
	private void Command_AddObject(Textures.Command.Element _command) { }

	// RVA: 0xFDE2E0 Offset: 0xFDA2E0 VA: 0xFDE2E0
	private void Command_RemoveObject(Textures.Command.Element _command) { }

	// RVA: 0xFDE39C Offset: 0xFDA39C VA: 0xFDE39C
	private void Command_AddToMixture(Textures.Command.Element _command) { }

	// RVA: 0xFDE458 Offset: 0xFDA458 VA: 0xFDE458
	private void Command_ChangeMinimapDot(Textures.Command.Element _command) { }

	// RVA: 0xFDE4E8 Offset: 0xFDA4E8 VA: 0xFDE4E8
	private void Command_ResetMinimapPlayerDot(Textures.Command.Element _command) { }

	// RVA: 0xFDE530 Offset: 0xFDA530 VA: 0xFDE530
	private void Command_AddDot(Textures.Command.Element _command) { }

	// RVA: 0xFDEA08 Offset: 0xFDAA08 VA: 0xFDEA08
	private void Command_DestroyAllDot(Textures.Command.Element _command) { }

	// RVA: 0xFDEBE8 Offset: 0xFDABE8 VA: 0xFDEBE8
	private void Command_SetMinimapDotAlpha(Textures.Command.Element _command) { }

	// RVA: 0xFDEC7C Offset: 0xFDAC7C VA: 0xFDEC7C
	private void Command_PerformAction(Textures.Command.Element _command) { }

	[CompilerGenerated]
	// RVA: 0xFDED0C Offset: 0xFDAD0C VA: 0xFDED0C
	private void <PushVector>b__27_0(Textures.Command.Element element) { }
}

// Namespace: 
public class Trap.Data // TypeDefIndex: 2468
{
	// Fields
	public Dictionary<int, Dictionary<int, bool>> grid; // 0x10
	public Position.Node node; // 0x18

	// Methods

	// RVA: 0xFDFC94 Offset: 0xFDBC94 VA: 0xFDFC94
	public void .ctor(MapRegionTrap data) { }
}

// Namespace: 
public class Trap.Grid // TypeDefIndex: 2469
{
	// Fields
	public const int textureSize = 128;
	public const int scaleDown = 4;
	public const int gridWidth = 8;
	public const int gridHeight = 4;
	public readonly Trap.Data data; // 0x10
	private Color32 pixelColor; // 0x18
	private Color32[] pixelBuffer; // 0x20

	// Methods

	// RVA: 0xFE0104 Offset: 0xFDC104 VA: 0xFE0104
	public void .ctor(Trap.Data data) { }

	// RVA: 0xFE0134 Offset: 0xFDC134 VA: 0xFE0134
	public void .ctor(MapRegionTrap data) { }

	// RVA: 0xFE01AC Offset: 0xFDC1AC VA: 0xFE01AC
	public void Initialize() { }

	// RVA: 0xFE020C Offset: 0xFDC20C VA: 0xFE020C
	private void DrawPixel(int x, int y) { }

	// RVA: 0xFE02B8 Offset: 0xFDC2B8 VA: 0xFE02B8
	private void DrawLine(int x0, int y0, int x1, int y1) { }

	// RVA: 0xFE03D0 Offset: 0xFDC3D0 VA: 0xFE03D0
	public void DrawGrid() { }

	// RVA: 0xFE06C4 Offset: 0xFDC6C4 VA: 0xFE06C4
	public Texture2D CreateTexture2D() { }

	// RVA: 0xFDE118 Offset: 0xFDA118 VA: 0xFDE118
	public Sprite CreateSprite() { }

	// RVA: 0xFE0750 Offset: 0xFDC750 VA: 0xFE0750
	public int GetTextureWidth() { }

	// RVA: 0xFE0758 Offset: 0xFDC758 VA: 0xFE0758
	public int GetTextureHeight() { }

	// RVA: 0xFDE100 Offset: 0xFDA100 VA: 0xFDE100
	public Position.Node GetNodePosition() { }
}

// Namespace: game.resource.map
public class Trap // TypeDefIndex: 2470
{
	// Methods

	// RVA: 0xFDFC8C Offset: 0xFDBC8C VA: 0xFDFC8C
	public void .ctor() { }
}
