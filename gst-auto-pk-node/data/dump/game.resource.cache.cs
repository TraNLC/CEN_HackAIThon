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

// Namespace: game.resource.cache
public class SpriteLimit // TypeDefIndex: 2485
{
	// Fields
	private readonly long limitBytes; // 0x10
	private readonly Dictionary<int, SPR.MemoryHead> head; // 0x18
	private readonly Queue<int> headQueue; // 0x20
	private long headCurrentBytes; // 0x28
	private readonly Dictionary<int, SpriteLimit.Frame> frames; // 0x30
	private readonly Queue<int> frameQueue; // 0x38
	private long frameCurrentBytes; // 0x40

	// Methods

	// RVA: 0xFE1E24 Offset: 0xFDDE24 VA: 0xFE1E24
	public void .ctor(int limitBytes = 0, string name) { }

	// RVA: 0xFE1F88 Offset: 0xFDDF88 VA: 0xFE1F88
	private SPR.MemoryHead GetHead(string pathString, int pathInt) { }

	// RVA: 0xFE2188 Offset: 0xFDE188 VA: 0xFE2188
	public SpriteLimit.Frame GetFrame(string pathString, ushort frameindex) { }
}

// Namespace: 
public class SpriteLimitForMap.Frame // TypeDefIndex: 2486
{
	// Fields
	public int bufferSize; // 0x10
	public Sprite sprite; // 0x18
	public ushort width; // 0x20
	public ushort height; // 0x22

	// Methods

	// RVA: 0xFDFC34 Offset: 0xFDBC34 VA: 0xFDFC34
	public void .ctor() { }
}

// Namespace: game.resource.cache
public class SpriteLimitForMap // TypeDefIndex: 2487
{
	// Fields
	private readonly long limitBytes; // 0x10
	private readonly Dictionary<int, SPR.MemoryHead> head; // 0x18
	private readonly Queue<int> headQueue; // 0x20
	private long headCurrentBytes; // 0x28
	private readonly Queue<int> frameQueue; // 0x30
	private long frameCurrentBytes; // 0x38
	private readonly Dictionary<int, SpriteLimitForMap.Frame> frames; // 0x40

	// Methods

	// RVA: 0xFE2690 Offset: 0xFDE690 VA: 0xFE2690
	public void .ctor(int limitBytes = 0, string name) { }

	// RVA: 0xFDF1FC Offset: 0xFDB1FC VA: 0xFDF1FC
	public void Clear() { }

	// RVA: 0xFE2828 Offset: 0xFDE828 VA: 0xFE2828
	private SPR.MemoryHead GetHead(string pathString, int pathInt) { }

	// RVA: 0xFDF84C Offset: 0xFDB84C VA: 0xFDF84C
	public SpriteLimitForMap.Frame GetFrame(string pathString, ushort frameindex, int pathHash, int pathFrameHash) { }
}

// Namespace: game.resource.cache
internal class SpriteOnlyImage // TypeDefIndex: 2488
{
	// Fields
	private readonly Dictionary<int, Sprite> frames; // 0x10

	// Methods

	// RVA: 0xFE2A28 Offset: 0xFDEA28 VA: 0xFE2A28
	public void .ctor() { }

	// RVA: 0xFE2AB0 Offset: 0xFDEAB0 VA: 0xFE2AB0
	public Sprite GetFrame(string pathString, ushort frameindex) { }
}

// Namespace: 
public static class Package.Indexer.AddMapNpc // TypeDefIndex: 2489
{
	// Fields
	public const int messageId = 0;
	public const int npcUuid = 1;
	public const int templateId = 2;
	public const int kind = 3;
	public const int name = 4;
	public const int currentMapX = 5;
	public const int currentMapY = 6;
	public const int direction = 7;
	public const int series = 8;
	public const int healthPercent = 9;
	public const int camp = 10;
	public const int fightState = 11;
	public const int stateStature = 12;
	public const int type = 13;
	public const int destinateMapX = 14;
	public const int destinateMapY = 15;
	public const int _COUNT = 16;
}

// Namespace: 
public static class Package.Indexer.NpcReceiveDamage // TypeDefIndex: 2490
{
	// Fields
	public const int messageId = 0;
	public const int npcUuid = 1;
	public const int damage = 2;
	public const int healthPercent = 3;
	public const int statestature = 4;
}

// Namespace: 
public static class Package.Indexer.NpcStateStature // TypeDefIndex: 2491
{
	// Fields
	public const int messageId = 0;
	public const int npcUuid = 1;
	public const int stateStature = 2;
}

// Namespace: 
public static class Package.Indexer.NpcHealthPercent // TypeDefIndex: 2492
{
	// Fields
	public const int messageId = 0;
	public const int npcUuid = 1;
	public const int healthPercent = 2;
}

// Namespace: 
public static class Package.Indexer.NpcAddHealth // TypeDefIndex: 2493
{
	// Fields
	public const int id = 0;
	public const int nid = 1;
	public const int percent = 2;
	public const int health = 3;
	public const int stateStature = 4;
}

// Namespace: 
public class Package.Indexer // TypeDefIndex: 2494
{
	// Methods

	// RVA: 0xFE2DD0 Offset: 0xFDEDD0 VA: 0xFE2DD0
	public void .ctor() { }
}
