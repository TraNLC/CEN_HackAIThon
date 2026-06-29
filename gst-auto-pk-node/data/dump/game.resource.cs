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

// Namespace: game.resource
public class Buffer // TypeDefIndex: 2173
{
	// Fields
	public byte[] data; // 0x10
	public int size; // 0x18

	// Methods

	// RVA: 0xFA13D0 Offset: 0xF9D3D0 VA: 0xFA13D0
	public void .ctor() { }

	// RVA: 0xFA1438 Offset: 0xF9D438 VA: 0xFA1438
	public void .ctor(int _size) { }

	// RVA: 0xFA14B0 Offset: 0xF9D4B0 VA: 0xFA14B0
	public static byte[] op_Implicit(Buffer _buffer) { }

	// RVA: 0xFA14C4 Offset: 0xF9D4C4 VA: 0xFA14C4
	public static Buffer op_Implicit(byte[] _data) { }

	// RVA: 0xFA153C Offset: 0xF9D53C VA: 0xFA153C
	public Buffer.Encoding GetEncoding() { }

	// RVA: 0xFA1828 Offset: 0xF9D828 VA: 0xFA1828
	public string GetString() { }
}

// Namespace: 
public struct Cache.Settings.Music // TypeDefIndex: 2174
{
	// Fields
	public static Dictionary<int, string> musicset; // 0x0
}

// Namespace: 
public struct Cache.Settings.NpcRes.Kind // TypeDefIndex: 2175
{
	// Fields
	public static Dictionary<string, string> mainManHeaderValueMapping; // 0x0
	public static Dictionary<string, string> mainLadyHeaderValueMapping; // 0x8
}

// Namespace: 
public struct Cache.Settings.NpcRes.Shadow // TypeDefIndex: 2176
{
	// Fields
	public static Dictionary<string, Structures.PartSprInfo> mainManAnimationMapping; // 0x0
	public static Dictionary<string, Structures.PartSprInfo> mainLadyAnimationMapping; // 0x8
}

// Namespace: 
public class Cache.Settings.NpcRes.NormalNpc.PartInfo // TypeDefIndex: 2177
{
	// Fields
	public Structures.PartSprInfo fullBody; // 0x10
	public Structures.PartSprInfo shadow; // 0x18

	// Methods

	// RVA: 0xFA1AEC Offset: 0xF9DAEC VA: 0xFA1AEC
	public void .ctor() { }
}

// Namespace: 
public struct Cache.Settings.NpcRes.NormalNpc // TypeDefIndex: 2178
{
	// Fields
	public static Dictionary<string, Dictionary<string, Cache.Settings.NpcRes.NormalNpc.PartInfo>> animationMapping; // 0x0
}

// Namespace: 
public struct Cache.Settings.NpcRes // TypeDefIndex: 2179
{
	// Fields
	public static Dictionary<string, Table> mainManTableMapping; // 0x0
	public static Dictionary<string, Table> mainLadyTableMapping; // 0x8
	public static Dictionary<string, Table> mainManPartPropertiesTableMapping; // 0x10
	public static Dictionary<string, Table> mainLadyPartPropertiesTableMapping; // 0x18
	public static Dictionary<string, Ini> mainManIniMapping; // 0x20
	public static Dictionary<string, Ini> mainLadyIniMapping; // 0x28
	public static SpriteLimit textures; // 0x30
}

// Namespace: 
public class Cache.Settings.Npcs.Settings // TypeDefIndex: 2180
{
	// Fields
	public string npcResType; // 0x10
	public int stature; // 0x18
	public int runSpeed; // 0x1C

	// Methods

	// RVA: 0xFA1AF4 Offset: 0xF9DAF4 VA: 0xFA1AF4
	public void .ctor() { }
}

// Namespace: 
public struct Cache.Settings.Npcs // TypeDefIndex: 2181
{
	// Fields
	public static Dictionary<int, Cache.Settings.Npcs.Settings> declareRowIndexMapping; // 0x0
}

// Namespace: 
public struct Cache.Settings.Skill // TypeDefIndex: 2182
{
	// Fields
	public static Table skillsTable; // 0x0
	public static Dictionary<int, int> skillsIdToRowIndexMapping; // 0x8
	public static Dictionary<int, Skill> skillsIdToDataMapping; // 0x10
	public static Table missilesTable; // 0x18
	public static Dictionary<int, int> missilesIdToRowIndexMapping; // 0x20
	public static Dictionary<int, Missile> missilesIdToDataMapping; // 0x28
	public static SpriteLimit textures; // 0x30
}

// Namespace: 
public struct Cache.Settings // TypeDefIndex: 2183
{}

// Namespace: 
public struct Cache.Map // TypeDefIndex: 2184
{
	// Fields
	public static SpriteLimitForMap textures; // 0x0
}

// Namespace: 
public struct Cache.SpriteOnlyImage // TypeDefIndex: 2185
{
	// Fields
	public static SpriteOnlyImage textures; // 0x0
}

// Namespace: game.resource
internal struct Cache // TypeDefIndex: 2186
{
	// Fields
	public static IntPtr resourcePackageHandler; // 0x0

	// Methods

	// RVA: 0xFA186C Offset: 0xF9D86C VA: 0xFA186C
	public static void Initialize() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DataController.<>c // TypeDefIndex: 2187
{
	// Fields
	public static readonly DataController.<>c <>9; // 0x0
	public static Comparison<KeyValuePair<string, int>> <>9__17_0; // 0x8

	// Methods

	// RVA: 0xFA449C Offset: 0xFA049C VA: 0xFA449C
	private static void .cctor() { }

	// RVA: 0xFA4504 Offset: 0xFA0504 VA: 0xFA4504
	public void .ctor() { }

	// RVA: 0xFA450C Offset: 0xFA050C VA: 0xFA450C
	internal int <DeleteEmptyDirectories>b__17_0(KeyValuePair<string, int> pair1, KeyValuePair<string, int> pair2) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class DataController.<DownloadUpdate>d__21 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2188
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public bool randomHosting; // 0x20
	public DataController <>4__this; // 0x28
	private string <localStoragePath>5__2; // 0x30
	private Dictionary.Enumerator<string, long> <>7__wrap2; // 0x38
	private KeyValuePair<string, long> <updateDownload>5__4; // 0x60
	private string <saveToPath>5__5; // 0x70

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xFA3C38 Offset: 0xF9FC38 VA: 0xFA3C38
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0xFA4564 Offset: 0xFA0564 VA: 0xFA4564 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xFA4580 Offset: 0xFA0580 VA: 0xFA4580 Slot: 6
	private bool MoveNext() { }

	// RVA: 0xFA4DBC Offset: 0xFA0DBC VA: 0xFA4DBC
	private void <>m__Finally1() { }

	[DebuggerHidden]
	// RVA: 0xFA4E0C Offset: 0xFA0E0C VA: 0xFA4E0C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0xFA4E14 Offset: 0xFA0E14 VA: 0xFA4E14 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0xFA4E4C Offset: 0xFA0E4C VA: 0xFA4E4C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}

// Namespace: game.resource
internal class DataController // TypeDefIndex: 2189
{
	// Fields
	private UnityWebRequest updateDownloadWebRequest; // 0x10
	private int updateDownloadElementCount; // 0x18
	private int updateDownloadElementIndex; // 0x1C
	private bool updateIsCompleted; // 0x20
	private readonly Stopwatch stopwatch; // 0x28
	private ulong downloadByteTotal; // 0x30
	private ulong downloadByteCurrent; // 0x38
	private ulong downloadByteCurrentTemp; // 0x40
	private Action isExitCommanding; // 0x48
	private bool isExited; // 0x50
	private string error; // 0x58
	private string hostingSelected; // 0x60
	private readonly Dictionary<string, long> updateDownloadList; // 0x68

	// Methods

	// RVA: 0xFA1AFC Offset: 0xF9DAFC VA: 0xFA1AFC
	private static string ValidPathSeparator(string _originPath) { }

	// RVA: 0xFA1B68 Offset: 0xF9DB68 VA: 0xFA1B68
	public static Dictionary<string, long[]> GetAllFilesInRootDirectory(string _rootDirectoryPath) { }

	// RVA: 0xFA1F80 Offset: 0xF9DF80 VA: 0xFA1F80
	private int GetDirectoryCountInPath(string path) { }

	// RVA: 0xFA203C Offset: 0xF9E03C VA: 0xFA203C
	private Dictionary<string, int> GetAllDirectoriesInRootPath(string rootDirectoryPath) { }

	// RVA: 0xFA230C Offset: 0xF9E30C VA: 0xFA230C
	private void DeleteEmptyDirectories(string rootDirectoryPath) { }

	// RVA: 0xFA25E0 Offset: 0xF9E5E0 VA: 0xFA25E0
	private List<string> GetHostingList() { }

	// RVA: 0xFA299C Offset: 0xF9E99C VA: 0xFA299C
	public void DownloadResourceFileNavigation() { }

	// RVA: 0xFA2E74 Offset: 0xF9EE74 VA: 0xFA2E74
	public bool IsNeedForUpdate() { }

	[IteratorStateMachine(typeof(DataController.<DownloadUpdate>d__21))]
	// RVA: 0xFA3BB8 Offset: 0xF9FBB8 VA: 0xFA3BB8
	public IEnumerator DownloadUpdate(bool randomHosting) { }

	// RVA: 0xFA3C60 Offset: 0xF9FC60 VA: 0xFA3C60
	public string GetError() { }

	// RVA: 0xFA3C68 Offset: 0xF9FC68 VA: 0xFA3C68
	public string GetCurrentDownloadCapacity() { }

	// RVA: 0xFA3DA4 Offset: 0xF9FDA4 VA: 0xFA3DA4
	public double GetCurrentDownloadSpeedMBs() { }

	// RVA: 0xFA3E60 Offset: 0xF9FE60 VA: 0xFA3E60
	public float GetCurentProgress() { }

	// RVA: 0xFA3EA4 Offset: 0xF9FEA4 VA: 0xFA3EA4
	public float GetTotalProgress() { }

	// RVA: 0xFA3ED0 Offset: 0xF9FED0 VA: 0xFA3ED0
	public ulong GetTotalBytesRequired() { }

	// RVA: 0xFA3ED8 Offset: 0xF9FED8 VA: 0xFA3ED8
	public string GetTotalBytesHuman(string colorCode) { }

	// RVA: 0xFA4304 Offset: 0xFA0304 VA: 0xFA4304
	public bool IsCompleted() { }

	// RVA: 0xFA430C Offset: 0xFA030C VA: 0xFA430C
	public bool IsFilesDownloaded() { }

	// RVA: 0xFA431C Offset: 0xFA031C VA: 0xFA431C
	public void Kill(Action onExisted, string source) { }

	// RVA: 0xFA43A4 Offset: 0xFA03A4 VA: 0xFA43A4
	public void .ctor() { }
}

// Namespace: game.resource
public class Ini // TypeDefIndex: 2190
{
	// Fields
	private readonly Dictionary<string, Dictionary<string, string>> mapping; // 0x10

	// Methods

	// RVA: 0xFA4E54 Offset: 0xFA0E54 VA: 0xFA4E54
	public void .ctor(Buffer _buffer) { }

	// RVA: 0xFA5298 Offset: 0xFA1298 VA: 0xFA5298
	public void .ctor(string data) { }

	// RVA: 0xFA4EFC Offset: 0xFA0EFC VA: 0xFA4EFC
	private void Initialize(string _literalData) { }

	// RVA: 0xFA5330 Offset: 0xFA1330 VA: 0xFA5330
	private void AddSection(string _name) { }

	// RVA: 0xFA53EC Offset: 0xFA13EC VA: 0xFA53EC
	private void AddPair(string _sectionName, string[] _pairVector) { }

	// RVA: 0xFA5558 Offset: 0xFA1558 VA: 0xFA5558
	private string GetString(string _sectionName, string _key) { }

	// RVA: 0xFA5650 Offset: 0xFA1650 VA: 0xFA5650
	private int GetInt(string _sectionName, string _key, int _default = -1) { }

	// RVA: 0xFA5754 Offset: 0xFA1754 VA: 0xFA5754
	public Dictionary<string, Dictionary<string, string>> GetMappingData() { }

	// RVA: 0xFA575C Offset: 0xFA175C VA: 0xFA575C
	public bool IsEmpty() { }

	// RVA: 0xFA57B8 Offset: 0xFA17B8 VA: 0xFA57B8
	public bool IsNotEmpty() { }

	// RVA: -1 Offset: -1
	public Typename Get<Typename>(string _section, string _key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111A000 Offset: 0x1116000 VA: 0x111A000
	|-Ini.Get<int>
	|
	|-RVA: 0x111A180 Offset: 0x1116180 VA: 0x111A180
	|-Ini.Get<object>
	|
	|-RVA: 0x111A2F8 Offset: 0x11162F8 VA: 0x111A2F8
	|-Ini.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Typename Get<Typename>(string _section, string _key, Typename _default) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111A4D8 Offset: 0x11164D8 VA: 0x111A4D8
	|-Ini.Get<int>
	|
	|-RVA: 0x111A648 Offset: 0x1116648 VA: 0x111A648
	|-Ini.Get<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
public class LocalResourceMapping.Element // TypeDefIndex: 2191
{
	// Fields
	public string type; // 0x10
	public string targetRelativePath; // 0x18
	public string localAbsolutePath; // 0x20

	// Methods

	// RVA: 0xFA5E90 Offset: 0xFA1E90 VA: 0xFA5E90
	public void .ctor() { }
}

// Namespace: game.resource
public static class LocalResourceMapping // TypeDefIndex: 2192
{
	// Methods

	// RVA: 0xFA5814 Offset: 0xFA1814 VA: 0xFA5814
	public static bool IsLocalMapped() { }

	// RVA: 0xFA5894 Offset: 0xFA1894 VA: 0xFA5894
	public static List<LocalResourceMapping.Element> GetElementListing() { }

	// RVA: 0xFA5EFC Offset: 0xFA1EFC VA: 0xFA5EFC
	public static void Start() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Map.<>c // TypeDefIndex: 2193
{
	// Fields
	public static readonly Map.<>c <>9; // 0x0
	public static Action<string> <>9__53_0; // 0x8
	public static Action<string, byte[]> <>9__54_0; // 0x10
	public static Action<string, byte[]> <>9__55_0; // 0x18

	// Methods

	// RVA: 0xFAA2F0 Offset: 0xFA62F0 VA: 0xFAA2F0
	private static void .cctor() { }

	// RVA: 0xFAA358 Offset: 0xFA6358 VA: 0xFAA358
	public void .ctor() { }

	// RVA: 0xFAA360 Offset: 0xFA6360 VA: 0xFAA360
	internal void <SaveAllMapDirectories>b__53_0(string fullpath) { }

	// RVA: 0xFAA494 Offset: 0xFA6494 VA: 0xFAA494
	internal void <SaveAllMapSprFiles>b__54_0(string fullpath, byte[] data) { }

	// RVA: 0xFAA5E0 Offset: 0xFA65E0 VA: 0xFAA5E0
	internal void <SaveAllMapRegionFiles>b__55_0(string fullpath, byte[] data) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class Map.<>c__DisplayClass15_0 // TypeDefIndex: 2194
{
	// Fields
	public Map <>4__this; // 0x10
	public Action onReleased; // 0x18
	public Action <>9__2; // 0x20
	public Action <>9__1; // 0x28

	// Methods

	// RVA: 0xFA6F04 Offset: 0xFA2F04 VA: 0xFA6F04
	public void .ctor() { }

	// RVA: 0xFAA72C Offset: 0xFA672C VA: 0xFAA72C
	internal void <Release>b__0() { }

	// RVA: 0xFAA7E0 Offset: 0xFA67E0 VA: 0xFAA7E0
	internal void <Release>b__1() { }

	// RVA: 0xFAA894 Offset: 0xFA6894 VA: 0xFAA894
	internal void <Release>b__2() { }
}

// Namespace: game.resource
public class Map // TypeDefIndex: 2195
{
	// Fields
	public MapList.MapInfo info; // 0x10
	private Config.Textures textureConfig; // 0x18
	private Config.Identification identifyConfig; // 0x34
	public readonly Controller mainPlayer; // 0x40
	private readonly GameObject appearance; // 0x48
	public readonly Layer layer; // 0x50
	private readonly Preparing preparingCommand; // 0x58
	private readonly Textures textureCommand; // 0x60
	private readonly Missile missileCommand; // 0x68
	private readonly MiniMap miniMap; // 0x70
	private readonly Obstacle.Barrier obstacleBarrier; // 0x78
	private readonly FPS18 fps18; // 0x80
	private readonly Region region; // 0x88
	private readonly PathFinding pathFinding; // 0x90

	// Methods

	// RVA: 0xFA6960 Offset: 0xFA2960 VA: 0xFA6960
	public void .ctor(Controller mainPlayer) { }

	// RVA: 0xFA6E24 Offset: 0xFA2E24 VA: 0xFA6E24
	public void Release(Action onReleased) { }

	// RVA: 0xFA6F0C Offset: 0xFA2F0C VA: 0xFA6F0C
	public void Update() { }

	// RVA: 0xFA6F24 Offset: 0xFA2F24 VA: 0xFA6F24
	public List<PathFinding.Node> FindPath(int startMapX, int startMapY, int endMapX, int endMapY, int targetApproach3D) { }

	// RVA: 0xFA7040 Offset: 0xFA3040 VA: 0xFA7040
	public Region GetRegion() { }

	// RVA: 0xFA7048 Offset: 0xFA3048 VA: 0xFA7048
	public bool SetMapId(int _mapId) { }

	// RVA: 0xFA7940 Offset: 0xFA3940 VA: 0xFA7940
	public void PerformAction(Action action) { }

	// RVA: 0xFA7958 Offset: 0xFA3958 VA: 0xFA7958
	public void SetTextureConfig(Config.Textures _mapConfig, bool clearMaptextures = True, bool clearSpecialNpc = False, bool clearNormalNpc = False) { }

	// RVA: 0xFA79D8 Offset: 0xFA39D8 VA: 0xFA79D8
	public Config.Textures GetTextureConfig() { }

	// RVA: 0xFA79EC Offset: 0xFA39EC VA: 0xFA79EC
	public void SetIdentifyConfig(Config.Identification identification) { }

	// RVA: 0xFA7A18 Offset: 0xFA3A18 VA: 0xFA7A18
	public Config.Identification GetIdentifyConfig() { }

	// RVA: 0xFA7A28 Offset: 0xFA3A28 VA: 0xFA7A28
	public void SetPosition(int top, int left) { }

	// RVA: 0xFA7AAC Offset: 0xFA3AAC VA: 0xFA7AAC
	public void EnableCache(bool groundNode, bool groundObject = False, bool tree = False, bool buildingUnder = False, bool buildingAbove = False) { }

	// RVA: 0xFA7AD8 Offset: 0xFA3AD8 VA: 0xFA7AD8
	public MiniMap GetMiniMap() { }

	// RVA: 0xFA7AE0 Offset: 0xFA3AE0 VA: 0xFA7AE0
	public void SetFPS(int fps) { }

	// RVA: 0xFA7AF8 Offset: 0xFA3AF8 VA: 0xFA7AF8
	public void PushNodeObstacle(Element.Obstacle[] obstacles) { }

	// RVA: 0xFA7B10 Offset: 0xFA3B10 VA: 0xFA7B10
	public void PushNodeTrap(MapRegionTrap data) { }

	// RVA: 0xFA7B28 Offset: 0xFA3B28 VA: 0xFA7B28
	public void SetLimitNpcRenderCount(int limitCount) { }

	// RVA: 0xFA7B40 Offset: 0xFA3B40 VA: 0xFA7B40
	public void SetLimitNpcRenderTypePlayer(bool renderPlayer) { }

	// RVA: 0xFA7B5C Offset: 0xFA3B5C VA: 0xFA7B5C
	public void SetLimitNpcRenderTypeNpc(bool renderNpc) { }

	// RVA: 0xFA7B78 Offset: 0xFA3B78 VA: 0xFA7B78
	public void AddMainPlayer(Controller npcontroller) { }

	// RVA: 0xFA7B90 Offset: 0xFA3B90 VA: 0xFA7B90
	public void AddDynamicNpc(Controller npcController) { }

	// RVA: 0xFA7BD0 Offset: 0xFA3BD0 VA: 0xFA7BD0
	public void HideNpc(Controller npcController) { }

	// RVA: 0xFA7C10 Offset: 0xFA3C10 VA: 0xFA7C10
	public void RemoveNpc(Controller npcController) { }

	// RVA: 0xFA7C50 Offset: 0xFA3C50 VA: 0xFA7C50
	public bool HasBarrier(Position mapPosition) { }

	// RVA: 0xFA7C68 Offset: 0xFA3C68 VA: 0xFA7C68
	public bool HasBarrier(float top, float left) { }

	// RVA: 0xFA7C9C Offset: 0xFA3C9C VA: 0xFA7C9C
	public void CastSkill(Skill skill, Params.Cast castParams, bool isNoAction = False) { }

	// RVA: 0xFA80F0 Offset: 0xFA40F0 VA: 0xFA80F0
	public void CastSkill(int id, int level, Params.Cast castParams, bool isNoAction = False) { }

	// RVA: 0xFA817C Offset: 0xFA417C VA: 0xFA817C
	public void CastSkill(int id, int level, Controller launcher, Controller target) { }

	// RVA: 0xFA820C Offset: 0xFA420C VA: 0xFA820C
	public void CastSkill(int id, int level, Controller launcher, Position target) { }

	// RVA: 0xFA829C Offset: 0xFA429C VA: 0xFA829C
	public void CastSkill(int id, int level, Params.Cast castParams, Params.Options options) { }

	// RVA: 0xFA848C Offset: 0xFA448C VA: 0xFA848C
	public void AddObject(Object gameobject) { }

	// RVA: 0xFA84CC Offset: 0xFA44CC VA: 0xFA84CC
	public void RemoveObject(Object gameObject) { }

	// RVA: 0xFA8510 Offset: 0xFA4510 VA: 0xFA8510
	public void AddToMixture(GameObject go) { }

	// RVA: 0xFA8528 Offset: 0xFA4528 VA: 0xFA8528
	public void ChangeMiniMap(Controller controller, MiniMap.PointColor sprite) { }

	// RVA: 0xFA8540 Offset: 0xFA4540 VA: 0xFA8540
	public void ResetMiniMapPlayerDot() { }

	// RVA: 0xFA8558 Offset: 0xFA4558 VA: 0xFA8558
	public void AddDot(int mapx, int mapy, Color color, int width = 5, int height = 5, int layer = 7, int order = 0) { }

	// RVA: 0xFA8570 Offset: 0xFA4570 VA: 0xFA8570
	public void DestroyAllDot() { }

	// RVA: 0xFA8588 Offset: 0xFA4588 VA: 0xFA8588
	public void SetMinimapDotAlpha(Controller controller, int alphaPercent) { }

	// RVA: 0xFA85A0 Offset: 0xFA45A0 VA: 0xFA85A0
	public void SaveAllMapDirectories(string directoryPath) { }

	// RVA: 0xFA8F64 Offset: 0xFA4F64 VA: 0xFA8F64
	public void SaveAllMapSprFiles(string directoryPath) { }

	// RVA: 0xFA9BA8 Offset: 0xFA5BA8 VA: 0xFA9BA8
	public void SaveAllMapRegionFiles(string directoryPath) { }
}

// Namespace: game.resource
internal class PackageIni // TypeDefIndex: 2196
{
	// Fields
	[CompilerGenerated]
	private static bool <IsReady>k__BackingField; // 0x0

	// Properties
	public static bool IsReady { get; set; }

	// Methods

	// RVA: 0xFAA8B0 Offset: 0xFA68B0 VA: 0xFAA8B0
	public static int GetResourceVersion() { }

	[CompilerGenerated]
	// RVA: 0xFAA96C Offset: 0xFA696C VA: 0xFAA96C
	public static bool get_IsReady() { }

	[CompilerGenerated]
	// RVA: 0xFAA9B4 Offset: 0xFA69B4 VA: 0xFAA9B4
	private static void set_IsReady(bool value) { }

	// RVA: 0xFAAA04 Offset: 0xFA6A04 VA: 0xFAAA04
	public static bool Initialize() { }

	// RVA: 0xFAAC2C Offset: 0xFA6C2C VA: 0xFAAC2C
	public static void Release() { }

	// RVA: 0xFAACE8 Offset: 0xFA6CE8 VA: 0xFAACE8
	public void .ctor() { }
}

// Namespace: game.resource
public class Script // TypeDefIndex: 2197
{
	// Fields
	public LuaEnv luaenv; // 0x10

	// Methods

	[LuaCallCSharp(0)]
	// RVA: 0xFAACF0 Offset: 0xFA6CF0 VA: 0xFAACF0
	private static byte[] CustomLoaderFunction(ref string moduleName) { }

	// RVA: 0xFAAE28 Offset: 0xFA6E28 VA: 0xFAAE28
	public void .ctor() { }

	// RVA: 0xFAAF04 Offset: 0xFA6F04 VA: 0xFAAF04
	public void .ctor(string scriptPath) { }

	// RVA: 0xFAB058 Offset: 0xFA7058 VA: 0xFAB058
	private void Load(string scriptPath) { }

	// RVA: 0xFAB0D8 Offset: 0xFA70D8 VA: 0xFAB0D8
	public void Release() { }

	// RVA: 0xFAB0E4 Offset: 0xFA70E4 VA: 0xFAB0E4
	public void DoString(string content, string chunk) { }

	// RVA: -1 Offset: -1
	public Typename CallFunction<Typename>(string functionName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11481E4 Offset: 0x11441E4 VA: 0x11481E4
	|-Script.CallFunction<object>
	|
	|-RVA: 0x11482C8 Offset: 0x11442C8 VA: 0x11482C8
	|-Script.CallFunction<__Il2CppFullySharedGenericType>
	*/
}

// Namespace: 
public static class SettingValues.Definition // TypeDefIndex: 2198
{
	// Fields
	public const int OFF = 0;
	public const int ON = 1;
	public const int UiStyleByParent = 0;
	public const int UiStyleAsMobile = 1;
	public const int UiStyleAsPC = 2;
}

// Namespace: game.resource
public static class SettingValues // TypeDefIndex: 2199
{
	// Fields
	public static string filename; // 0x0
	private static string fullFilePath; // 0x8
	public static int sound_music; // 0x10
	public static int sound_effect; // 0x14
	public static int viewport_visibility; // 0x18
	public static int fps_frame; // 0x1C
	public static int userinterface_style; // 0x20
	public static int viewitem_style; // 0x24
	public static int viewitem_open_comparing_for_pc; // 0x28
	public static int viewitem_save_display_functions_for_pc; // 0x2C
	public static int item_border_style; // 0x30
	public static int userinterface_open_ask_confirm_framed; // 0x34
	public static int userinterface_open_chat_history_selection; // 0x38
	public static int hotkey_skill_keep_on_fightstate; // 0x3C
	public static int moving_type; // 0x40
	public static int skill_direction_allow_target_manual; // 0x44
	public static bool skill_display_self_evade; // 0x48
	public static bool skill_display_player_evade; // 0x49
	public static bool skill_display_similar_image; // 0x4A
	public static int map_background; // 0x4C
	public static int map_ground_node; // 0x50
	public static int map_ground_object; // 0x54
	public static int map_building; // 0x58
	public static int map_tree; // 0x5C
	public static int map_obstacle_grid; // 0x60
	public static int map_finding_path; // 0x64
	public static int identify_title; // 0x68
	public static int identify_tong; // 0x6C
	public static int identify_name; // 0x70
	public static int identify_health; // 0x74
	public static int identify_dropping_name; // 0x78
	public static int identify_position; // 0x7C
	public static int vibrate_level; // 0x80
	public static int vibrate_on_receive_damage; // 0x84
	public static int vibrate_on_skill_collide; // 0x88
	public static int vibrate_on_cast; // 0x8C
	public static int visibility_max_player; // 0x90
	public static int visibility_display_player; // 0x94
	public static int visibility_display_npc; // 0x98
	public static bool visibility_player_similar; // 0x9C
	public static int font_playerName; // 0xA0
	public static float font_playerName_float; // 0xA4
	public static int font_playerSalesman; // 0xA8
	public static float font_playerSalesman_float; // 0xAC
	public static int font_playerHealthBar; // 0xB0
	public static int font_playerHealthBar_scene; // 0xB4
	public static int font_itemDetails; // 0xB8
	public static int font_itemOnMap; // 0xBC
	public static float font_itemOnMap_float; // 0xC0
	public static int font_chatHistory; // 0xC4
	public static int font_questTitle; // 0xC8
	public static int font_questContent; // 0xCC
	public static int font_homeScreenTopLevel; // 0xD0
	public static int font_homeScreenTopRank; // 0xD4
	public static int font_homeScreenTopHealth; // 0xD8
	public static int font_homeScreenTopMana; // 0xDC
	public static int font_homeScreenTopStamina; // 0xE0
	public static int font_homeScreenTopExp; // 0xE4
	public static int font_npcDialog; // 0xE8
	public static int font_talk2Player; // 0xEC
	public static int font_localNews; // 0xF0

	// Methods

	// RVA: 0xFAB100 Offset: 0xFA7100 VA: 0xFAB100
	public static void Save(object obj) { }

	// RVA: 0xFAC74C Offset: 0xFA874C VA: 0xFAC74C
	public static void Initialize() { }

	// RVA: 0xFAD7FC Offset: 0xFA97FC VA: 0xFAD7FC
	public static bool UserInterfaceAsMobile() { }

	// RVA: 0xFAD85C Offset: 0xFA985C VA: 0xFAD85C
	public static bool UserInterfaceAsPC() { }

	// RVA: 0xFAD8B4 Offset: 0xFA98B4 VA: 0xFAD8B4
	public static bool ViewItemAsPC() { }

	// RVA: 0xFAD964 Offset: 0xFA9964 VA: 0xFAD964
	public static bool ViewItemAsPcOpenComparing() { }

	// RVA: 0xFAD9C4 Offset: 0xFA99C4 VA: 0xFAD9C4
	public static bool ViewItemAsPcSaveDisplayFuncs() { }

	// RVA: 0xFADA24 Offset: 0xFA9A24 VA: 0xFADA24
	private static void .cctor() { }
}

// Namespace: game.resource
public class Split // TypeDefIndex: 2200
{
	// Fields
	private readonly char spliter; // 0x10
	private string[] rowListing; // 0x18
	private int rowTotal; // 0x20

	// Methods

	// RVA: 0xFADB60 Offset: 0xFA9B60 VA: 0xFADB60
	public void .ctor(string data, char spliter = '\xa') { }
}

// Namespace: 
public class SPR.MemoryHead // TypeDefIndex: 2201
{
	// Fields
	public uint id; // 0x10
	public int packIndex; // 0x14
	public int elementIndex; // 0x18
	public IntPtr bufferPointer; // 0x20
	public int bufferSize; // 0x28

	// Methods

	// RVA: 0xFADBD4 Offset: 0xFA9BD4 VA: 0xFADBD4
	public void .ctor() { }
}

// Namespace: 
public class SPR.MemoryFrame // TypeDefIndex: 2202
{
	// Fields
	public ushort sprCenterX; // 0x10
	public ushort sprCenterY; // 0x12
	public ushort sprWidth; // 0x14
	public ushort frameWidth; // 0x16
	public ushort frameHeight; // 0x18
	public ushort frameOffsetX; // 0x1A
	public ushort frameOffsetY; // 0x1C
	public IntPtr bufferPointer; // 0x20
	public int bufferSize; // 0x28

	// Methods

	// RVA: 0xFADBDC Offset: 0xFA9BDC VA: 0xFADBDC
	public void .ctor() { }
}

// Namespace: 
public class SPR.Info // TypeDefIndex: 2203
{
	// Fields
	public ushort width; // 0x10
	public ushort height; // 0x12
	public ushort centerX; // 0x14
	public ushort centerY; // 0x16
	public ushort frameCount; // 0x18
	public ushort colorCount; // 0x1A
	public ushort directionCount; // 0x1C
	public ushort interval; // 0x1E

	// Methods

	// RVA: 0xFADBE4 Offset: 0xFA9BE4 VA: 0xFADBE4
	public void .ctor() { }
}

// Namespace: 
public class SPR.FrameInfo // TypeDefIndex: 2204
{
	// Fields
	public ushort frameIndex; // 0x10
	public ushort width; // 0x12
	public ushort height; // 0x14
	public ushort offsetX; // 0x16
	public ushort offsetY; // 0x18

	// Methods

	// RVA: 0xFADBEC Offset: 0xFA9BEC VA: 0xFADBEC
	public void .ctor() { }
}

// Namespace: 
public class SPR.FrameCount // TypeDefIndex: 2205
{
	// Fields
	private ushort value; // 0x10

	// Methods

	// RVA: 0xFADBF4 Offset: 0xFA9BF4 VA: 0xFADBF4
	public static ushort op_Implicit(SPR.FrameCount _sprFrameCount) { }

	// RVA: 0xFADC08 Offset: 0xFA9C08 VA: 0xFADC08
	public static SPR.FrameCount op_Implicit(ushort _value) { }

	// RVA: 0xFADC6C Offset: 0xFA9C6C VA: 0xFADC6C
	public void .ctor() { }
}

// Namespace: 
public class SPR.TextureBuffer // TypeDefIndex: 2206
{
	// Fields
	private byte[] buffer; // 0x10

	// Methods

	// RVA: 0xFADC74 Offset: 0xFA9C74 VA: 0xFADC74
	public void .ctor() { }

	// RVA: 0xFADC7C Offset: 0xFA9C7C VA: 0xFADC7C
	public void .ctor(int _length) { }

	// RVA: 0xFADCF8 Offset: 0xFA9CF8 VA: 0xFADCF8
	public static byte[] op_Implicit(SPR.TextureBuffer _textureBuffer) { }

	// RVA: 0xFADD0C Offset: 0xFA9D0C VA: 0xFADD0C
	public static SPR.TextureBuffer op_Implicit(byte[] _buffer) { }

	// RVA: 0xFADD7C Offset: 0xFA9D7C VA: 0xFADD7C
	public void Clear() { }

	// RVA: 0xFADD88 Offset: 0xFA9D88 VA: 0xFADD88
	public int Length() { }
}

// Namespace: game.resource
public class SPR // TypeDefIndex: 2207
{
	// Fields
	public const ushort firstFrame = 0;
	public const ushort FPS = 18;

	// Methods

	// RVA: 0xFADBCC Offset: 0xFA9BCC VA: 0xFADBCC
	public void .ctor() { }
}

// Namespace: game.resource
public class Table // TypeDefIndex: 2208
{
	// Fields
	private int rowTotal; // 0x10
	private string[] rowLiteralVector; // 0x18
	private Dictionary<int, Dictionary<int, string>> rowKeyCacheValue; // 0x20
	private Dictionary<string, int> headerKeyIndex; // 0x28
	private Dictionary<int, string> headerIndexKey; // 0x30
	private readonly Buffer.Encoding encoding; // 0x38

	// Properties
	public int HeaderCount { get; }
	public int RowCount { get; }

	// Methods

	// RVA: 0xFADDA0 Offset: 0xFA9DA0 VA: 0xFADDA0
	public void .ctor() { }

	// RVA: 0xFA5CAC Offset: 0xFA1CAC VA: 0xFA5CAC
	public void .ctor(Buffer _buffer) { }

	// RVA: 0xFA28E4 Offset: 0xF9E8E4 VA: 0xFA28E4
	public void .ctor(string data) { }

	// RVA: 0xFADFC8 Offset: 0xFA9FC8 VA: 0xFADFC8
	private void Initialize(string _literalData) { }

	// RVA: 0xFAE2E4 Offset: 0xFAA2E4 VA: 0xFAE2E4
	private static string RemoveSpecialSymbol(string _string) { }

	// RVA: 0xFAE39C Offset: 0xFAA39C VA: 0xFAE39C
	private Dictionary<int, string> GetRowData(int _rowIndex) { }

	// RVA: 0xFAE6BC Offset: 0xFAA6BC VA: 0xFAE6BC
	private string GetString(int _headerIndex, int _rowIndex) { }

	// RVA: 0xFAE790 Offset: 0xFAA790 VA: 0xFAE790
	private string GetString(string _headerKey, int _rowIndex) { }

	// RVA: 0xFAE82C Offset: 0xFAA82C VA: 0xFAE82C
	public Buffer.Encoding GetEncoding() { }

	// RVA: 0xFAE834 Offset: 0xFAA834 VA: 0xFAE834
	public int get_HeaderCount() { }

	// RVA: 0xFAE884 Offset: 0xFAA884 VA: 0xFAE884
	public int get_RowCount() { }

	// RVA: 0xFA298C Offset: 0xF9E98C VA: 0xFA298C
	public bool IsEmpty() { }

	// RVA: 0xFAE88C Offset: 0xFAA88C VA: 0xFAE88C
	public bool IsNotEmpty() { }

	// RVA: 0xFAE89C Offset: 0xFAA89C VA: 0xFAE89C
	public int FindRowIndex(string _headerKey, string _data) { }

	// RVA: 0xFAE90C Offset: 0xFAA90C VA: 0xFAE90C
	public List<string> GetHeaderKeyList() { }

	// RVA: 0xFAEAF4 Offset: 0xFAAAF4 VA: 0xFAEAF4
	public Dictionary<string, int> GetHeaderKeyIndexPair() { }

	// RVA: 0xFAEAFC Offset: 0xFAAAFC VA: 0xFAEAFC
	public string GetHeaderKey(int _headerIndex) { }

	// RVA: -1 Offset: -1
	public Typename Get<Typename>(string _headerKey, int _rowIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1035684 Offset: 0x1031684 VA: 0x1035684
	|-Table.Get<object>
	|
	|-RVA: 0x1035DA8 Offset: 0x1031DA8 VA: 0x1035DA8
	|-Table.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Typename Get<Typename>(int _columnIndex, int _rowIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114E7A0 Offset: 0x114A7A0 VA: 0x114E7A0
	|-Table.Get<int>
	|
	|-RVA: 0x114EA34 Offset: 0x114AA34 VA: 0x114EA34
	|-Table.Get<long>
	|
	|-RVA: 0x114ECC8 Offset: 0x114ACC8 VA: 0x114ECC8
	|-Table.Get<object>
	|
	|-RVA: 0x1035814 Offset: 0x1031814 VA: 0x1035814
	|-Table.Get<ushort>
	|
	|-RVA: 0x1035AA8 Offset: 0x1031AA8 VA: 0x1035AA8
	|-Table.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Typename Get<Typename>(int _columnIndex, int _rowIndex, Typename _default) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1035FC0 Offset: 0x1031FC0 VA: 0x1035FC0
	|-Table.Get<int>
	|
	|-RVA: 0x1036174 Offset: 0x1032174 VA: 0x1036174
	|-Table.Get<__Il2CppFullySharedGenericType>
	*/
}
