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

// Namespace: game.world
public class PlayerMainMapBackground : MonoBehaviour // TypeDefIndex: 2523
{
	// Fields
	[SerializeField]
	private SpriteRenderer spriteRenderer; // 0x20
	private string currentImagePath; // 0x28

	// Methods

	// RVA: 0xFE9674 Offset: 0xFE5674 VA: 0xFE9674
	public void DeleteBackgroundImage() { }

	// RVA: 0xFE9774 Offset: 0xFE5774 VA: 0xFE9774
	public void ScaleBackgroundImage(Camera camera) { }

	// RVA: 0xFE98DC Offset: 0xFE58DC VA: 0xFE98DC
	public void SetBackgroundImage(string imagepath, Camera camera) { }

	// RVA: 0xFE9B00 Offset: 0xFE5B00 VA: 0xFE9B00
	public void .ctor() { }
}

// Namespace: game.world
public class PlayerMainSkillDirection : MonoBehaviour // TypeDefIndex: 2524
{
	// Fields
	[SerializeField]
	private SpriteRenderer spriteRenderer; // 0x20
	[SerializeField]
	private float lifeDeltaTime; // 0x28
	[SerializeField]
	private float maxImageHeight; // 0x2C
	private int radius; // 0x30
	private float originSpriteWidth; // 0x34
	private float originSpriteHeight; // 0x38
	private float length; // 0x3C
	private float angle; // 0x40
	private float width; // 0x44
	private float height; // 0x48
	private float currentLifeDeltaTime; // 0x4C
	[CompilerGenerated]
	private bool <isOpening>k__BackingField; // 0x50
	[CompilerGenerated]
	private float <cos>k__BackingField; // 0x54
	[CompilerGenerated]
	private float <sin>k__BackingField; // 0x58
	[CompilerGenerated]
	private int <directionIndex64>k__BackingField; // 0x5C

	// Properties
	public bool isOpening { get; set; }
	public float cos { get; set; }
	public float sin { get; set; }
	public int directionIndex64 { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xFE9D60 Offset: 0xFE5D60 VA: 0xFE9D60
	public bool get_isOpening() { }

	[CompilerGenerated]
	// RVA: 0xFE9D68 Offset: 0xFE5D68 VA: 0xFE9D68
	private void set_isOpening(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFE9D70 Offset: 0xFE5D70 VA: 0xFE9D70
	public float get_cos() { }

	[CompilerGenerated]
	// RVA: 0xFE9D78 Offset: 0xFE5D78 VA: 0xFE9D78
	private void set_cos(float value) { }

	[CompilerGenerated]
	// RVA: 0xFE9D80 Offset: 0xFE5D80 VA: 0xFE9D80
	public float get_sin() { }

	[CompilerGenerated]
	// RVA: 0xFE9D88 Offset: 0xFE5D88 VA: 0xFE9D88
	private void set_sin(float value) { }

	[CompilerGenerated]
	// RVA: 0xFE9D90 Offset: 0xFE5D90 VA: 0xFE9D90
	public int get_directionIndex64() { }

	[CompilerGenerated]
	// RVA: 0xFE9D98 Offset: 0xFE5D98 VA: 0xFE9D98
	private void set_directionIndex64(int value) { }

	// RVA: 0xFE9DA0 Offset: 0xFE5DA0 VA: 0xFE9DA0
	private void Awake() { }

	// RVA: 0xFE9E2C Offset: 0xFE5E2C VA: 0xFE9E2C
	private void Update() { }

	// RVA: 0xFE9E90 Offset: 0xFE5E90 VA: 0xFE9E90
	public void SetRadius(int radius) { }

	// RVA: 0xFE9E98 Offset: 0xFE5E98 VA: 0xFE9E98
	public void SetDirection(int direction, int showDirImage) { }

	// RVA: 0xFEA198 Offset: 0xFE6198 VA: 0xFEA198
	public void Clear() { }

	// RVA: 0xFEA234 Offset: 0xFE6234 VA: 0xFEA234
	public void .ctor() { }
}

// Namespace: game.world
public class PlayerMainSkillPositionArea : MonoBehaviour // TypeDefIndex: 2525
{
	// Fields
	[SerializeField]
	private SpriteRenderer spriteRenderer; // 0x20
	[SerializeField]
	private float lifeDeltaTime; // 0x28
	private int radius; // 0x2C
	private float currentLifeDeltaTime; // 0x30
	[CompilerGenerated]
	private bool <isOpening>k__BackingField; // 0x34
	[CompilerGenerated]
	private float <distanceRatio>k__BackingField; // 0x38
	[CompilerGenerated]
	private float <cos>k__BackingField; // 0x3C
	[CompilerGenerated]
	private float <sin>k__BackingField; // 0x40
	[CompilerGenerated]
	private float <cosRatio>k__BackingField; // 0x44
	[CompilerGenerated]
	private float <sinRatio>k__BackingField; // 0x48

	// Properties
	public bool isOpening { get; set; }
	public float distanceRatio { get; set; }
	public float cos { get; set; }
	public float sin { get; set; }
	public float cosRatio { get; set; }
	public float sinRatio { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xFEA268 Offset: 0xFE6268 VA: 0xFEA268
	public bool get_isOpening() { }

	[CompilerGenerated]
	// RVA: 0xFEA270 Offset: 0xFE6270 VA: 0xFEA270
	private void set_isOpening(bool value) { }

	[CompilerGenerated]
	// RVA: 0xFEA278 Offset: 0xFE6278 VA: 0xFEA278
	public float get_distanceRatio() { }

	[CompilerGenerated]
	// RVA: 0xFEA280 Offset: 0xFE6280 VA: 0xFEA280
	private void set_distanceRatio(float value) { }

	[CompilerGenerated]
	// RVA: 0xFEA288 Offset: 0xFE6288 VA: 0xFEA288
	public float get_cos() { }

	[CompilerGenerated]
	// RVA: 0xFEA290 Offset: 0xFE6290 VA: 0xFEA290
	private void set_cos(float value) { }

	[CompilerGenerated]
	// RVA: 0xFEA298 Offset: 0xFE6298 VA: 0xFEA298
	public float get_sin() { }

	[CompilerGenerated]
	// RVA: 0xFEA2A0 Offset: 0xFE62A0 VA: 0xFEA2A0
	private void set_sin(float value) { }

	[CompilerGenerated]
	// RVA: 0xFEA2A8 Offset: 0xFE62A8 VA: 0xFEA2A8
	public float get_cosRatio() { }

	[CompilerGenerated]
	// RVA: 0xFEA2B0 Offset: 0xFE62B0 VA: 0xFEA2B0
	private void set_cosRatio(float value) { }

	[CompilerGenerated]
	// RVA: 0xFEA2B8 Offset: 0xFE62B8 VA: 0xFEA2B8
	public float get_sinRatio() { }

	[CompilerGenerated]
	// RVA: 0xFEA2C0 Offset: 0xFE62C0 VA: 0xFEA2C0
	private void set_sinRatio(float value) { }

	// RVA: 0xFEA2C8 Offset: 0xFE62C8 VA: 0xFEA2C8
	private void Start() { }

	// RVA: 0xFEA300 Offset: 0xFE6300 VA: 0xFEA300
	private void Update() { }

	// RVA: 0xFEA364 Offset: 0xFE6364 VA: 0xFEA364
	public void SetRadius(int radius) { }

	// RVA: 0xFEA36C Offset: 0xFE636C VA: 0xFEA36C
	public void SetTarget(float distanceCurrently, float distanceMaximum, int directionIndex64, int showDirImage) { }

	// RVA: 0xFEA4D4 Offset: 0xFE64D4 VA: 0xFEA4D4
	public void Clear() { }

	// RVA: 0xFEA570 Offset: 0xFE6570 VA: 0xFEA570
	public void .ctor() { }
}

// Namespace: game.world
public class PlayerMainSkillRadius : MonoBehaviour // TypeDefIndex: 2526
{
	// Fields
	[SerializeField]
	private LineRenderer lineRenderer; // 0x20
	private static readonly Color circleColor; // 0x0
	private float elapsedTime; // 0x28
	private float delay; // 0x2C
	private int radiusOnCanvas; // 0x30
	private float radiusOnMap; // 0x34

	// Methods

	// RVA: 0xFEA584 Offset: 0xFE6584 VA: 0xFEA584
	private void Start() { }

	// RVA: 0xFEA5F0 Offset: 0xFE65F0 VA: 0xFEA5F0
	private void Update() { }

	// RVA: 0xFEA654 Offset: 0xFE6654 VA: 0xFEA654
	public void DrawCircle(int radiusOnCanvas) { }

	// RVA: 0xFEA858 Offset: 0xFE6858 VA: 0xFEA858
	public void .ctor() { }

	// RVA: 0xFEA868 Offset: 0xFE6868 VA: 0xFEA868
	private static void .cctor() { }
}

// Namespace: 
public static class Chat.Channel // TypeDefIndex: 2527
{
	// Fields
	public const int Unidentified = 0;
	public const int Near = 1;
	public const int Team = 2;
	public const int Tong = 3;
	public const int City = 4;
	public const int World = 5;
	public const int System = 6;
	public const int PrivateReceive = 7;
	public const int PrivateSend = 8;
}

// Namespace: 
public enum Chat.ItemData.Color // TypeDefIndex: 2528
{
	// Fields
	public int value__; // 0x0
	public const Chat.ItemData.Color White = 0;
	public const Chat.ItemData.Color Blue = 1;
	public const Chat.ItemData.Color Gold = 2;
}

// Namespace: 
public class Chat.ItemData // TypeDefIndex: 2529
{
	// Fields
	public int id; // 0x10
	public int type; // 0x14
	public string name; // 0x18
	public string colorMaterial; // 0x20
	public string autoreply; // 0x28

	// Methods

	// RVA: 0xE635D8 Offset: 0xE5F5D8 VA: 0xE635D8
	public void .ctor() { }
}

// Namespace: 
public class Chat.PrivateData // TypeDefIndex: 2530
{
	// Fields
	public string receiveName; // 0x10
	public string receiveCid; // 0x18

	// Methods

	// RVA: 0xE635E0 Offset: 0xE5F5E0 VA: 0xE635E0
	public void .ctor() { }
}
