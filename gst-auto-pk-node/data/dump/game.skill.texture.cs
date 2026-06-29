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

// Namespace: game.skill.texture
public class Active : Vanish // TypeDefIndex: 2157
{
	// Methods

	// RVA: 0xF9FA50 Offset: 0xF9BA50 VA: 0xF9FA50
	public void Activate(Missile missile) { }

	// RVA: 0xF9FFBC Offset: 0xF9BFBC VA: 0xF9FFBC
	public void .ctor() { }
}

// Namespace: game.skill.texture
public class Appearance // TypeDefIndex: 2158
{
	// Fields
	public GameObject goCurrent; // 0x10
	public GameObject goTexture; // 0x18
	public SpriteRenderer comSpriteRenderer; // 0x20
	public RectTransform comRectTransform; // 0x28

	// Methods

	// RVA: 0xF9FFC4 Offset: 0xF9BFC4 VA: 0xF9FFC4
	public void Initialize(Transform parent) { }

	// RVA: 0xFA0154 Offset: 0xF9C154 VA: 0xFA0154
	public void Release() { }

	// RVA: 0xFA01F4 Offset: 0xF9C1F4 VA: 0xFA01F4
	public void .ctor() { }
}

// Namespace: game.skill.texture
public class Cache // TypeDefIndex: 2159
{
	// Methods

	// RVA: 0xFA01FC Offset: 0xF9C1FC VA: 0xFA01FC
	public static SpriteLimit.Frame GetSprFrame(string sprPath, ushort frameIndex) { }

	// RVA: 0xFA0268 Offset: 0xF9C268 VA: 0xFA0268
	public void .ctor() { }
}

// Namespace: 
public class Data.Spr // TypeDefIndex: 2160
{
	// Fields
	public string path; // 0x10
	public ushort frame; // 0x18

	// Methods

	// RVA: 0xFA03B8 Offset: 0xF9C3B8 VA: 0xFA03B8
	public void .ctor() { }
}

// Namespace: 
public class Data.Position // TypeDefIndex: 2161
{
	// Fields
	public Position map; // 0x10
	public Vector3 scene; // 0x18

	// Methods

	// RVA: 0xFA03EC Offset: 0xF9C3EC VA: 0xFA03EC
	public void .ctor() { }
}

// Namespace: 
public class Data.Update // TypeDefIndex: 2162
{
	// Fields
	public int remaning; // 0x10
	public bool breathing; // 0x14

	// Methods

	// RVA: 0xFA0458 Offset: 0xF9C458 VA: 0xFA0458
	public void .ctor() { }
}

// Namespace: game.skill.texture
public class Data // TypeDefIndex: 2163
{
	// Fields
	public Appearance appearance; // 0x10
	public Data.Spr spr; // 0x18
	public Data.Position position; // 0x20
	public Data.Update update; // 0x28
	public int sortingOrder; // 0x30

	// Methods

	// RVA: 0xFA0270 Offset: 0xF9C270 VA: 0xFA0270
	public void .ctor() { }
}

// Namespace: 
private class Updating.SoundData // TypeDefIndex: 2164
{
	// Fields
	public string filename; // 0x10
	public int distance; // 0x18

	// Methods

	// RVA: 0xFA0A60 Offset: 0xF9CA60 VA: 0xFA0A60
	public void .ctor() { }
}

// Namespace: game.skill.texture
public class Updating : Data // TypeDefIndex: 2165
{
	// Fields
	private static readonly ConcurrentQueue<Updating.SoundData> missileSoundQueue; // 0x0
	private static readonly Dictionary<string, long> missileSoundEffectTiming; // 0x8
	private static long currentSecondsTime; // 0x10
	private static long currentPlayingCount; // 0x18

	// Methods

	// RVA: 0xFA0468 Offset: 0xF9C468 VA: 0xFA0468
	public bool Update() { }

	// RVA: 0xF9FB60 Offset: 0xF9BB60 VA: 0xF9FB60
	public void Apply(string sprPath, int sprFrame, int mapX, int mapY) { }

	// RVA: 0xFA0584 Offset: 0xF9C584 VA: 0xFA0584
	public static void ActivateSoundEffect() { }

	// RVA: 0xFA0658 Offset: 0xF9C658 VA: 0xFA0658
	public static void PlaySoundEffect(string filename, Controller npcontroller) { }

	// RVA: 0xF9EAF0 Offset: 0xF9AAF0 VA: 0xF9EAF0
	public void PlaySoundEffect(int status, Data missileData) { }

	// RVA: 0xFA0A68 Offset: 0xF9CA68 VA: 0xFA0A68
	public void .ctor() { }

	// RVA: 0xFA0A6C Offset: 0xF9CA6C VA: 0xFA0A6C
	private static void .cctor() { }
}
