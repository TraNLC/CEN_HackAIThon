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

// Namespace: game.scene.world
public class PlayerOtherSalesmanTitle : MonoBehaviour // TypeDefIndex: 3009
{
	// Fields
	private static PlayerOtherSalesmanTitle originPrefabGo; // 0x0
	private static Sprite background; // 0x8
	private static Sprite titleLeft; // 0x10
	private static Sprite titleRight; // 0x18
	[SerializeField]
	private SpriteRenderer goBgLeft; // 0x20
	[SerializeField]
	private SpriteRenderer goBgRight; // 0x28
	[SerializeField]
	private SpriteRenderer goBgCentral; // 0x30
	[SerializeField]
	private TextMeshPro goTitle; // 0x38
	[SerializeField]
	private RectTransform rectTransformComponent; // 0x40
	[SerializeField]
	private RectTransform goBgLeftRectTransformComponent; // 0x48
	[SerializeField]
	private RectTransform goBgRightRectTransformComponent; // 0x50
	[SerializeField]
	private RectTransform goBgCentralRectTransformComponent; // 0x58
	[SerializeField]
	private RectTransform goTitleRectTransformComponent; // 0x60

	// Methods

	// RVA: 0xF2CD38 Offset: 0xF28D38 VA: 0xF2CD38
	public static PlayerOtherSalesmanTitle CreateNew(Transform parent) { }

	// RVA: 0xF2CEDC Offset: 0xF28EDC VA: 0xF2CEDC
	public static Sprite GetBackgroundSprite() { }

	// RVA: 0xF2D028 Offset: 0xF29028 VA: 0xF2D028
	public static Sprite GetTitleLeftSprite() { }

	// RVA: 0xF2D174 Offset: 0xF29174 VA: 0xF2D174
	public static Sprite GetTitleRightSprite() { }

	// RVA: 0xF2D2C0 Offset: 0xF292C0 VA: 0xF2D2C0
	private void Start() { }

	// RVA: 0xF2D32C Offset: 0xF2932C VA: 0xF2D32C
	public float GetHeight() { }

	// RVA: 0xF2D36C Offset: 0xF2936C VA: 0xF2D36C
	public void SetAnchoredPositionY(float yy) { }

	// RVA: 0xF2D394 Offset: 0xF29394 VA: 0xF2D394
	public void SetText(string text) { }

	// RVA: 0xF2D590 Offset: 0xF29590 VA: 0xF2D590
	public void .ctor() { }
}

// Namespace: game.scene.world
[RequireComponent(typeof(Camera))]
public class NightLightEffect : MonoBehaviour // TypeDefIndex: 3010
{
	// Fields
	[SerializeField]
	private Material nightLightMaterial; // 0x20

	// Methods

	// RVA: 0xF2D598 Offset: 0xF29598 VA: 0xF2D598
	private void OnRenderImage(RenderTexture src, RenderTexture dest) { }

	// RVA: 0xF2D60C Offset: 0xF2960C VA: 0xF2D60C
	public void .ctor() { }
}

// Namespace: game.scene.world
public class Camera // TypeDefIndex: 3011
{
	// Fields
	private readonly Camera mainCamera; // 0x10

	// Methods

	// RVA: 0xF2A8AC Offset: 0xF268AC VA: 0xF2A8AC
	public void .ctor(Camera mainCamera) { }

	// RVA: 0xF2D614 Offset: 0xF29614 VA: 0xF2D614
	public void SetMapPosition(Position _position) { }

	// RVA: 0xF2C5EC Offset: 0xF285EC VA: 0xF2C5EC
	public void SetPosition(Vector3 _position) { }

	// RVA: 0xF2BF0C Offset: 0xF27F0C VA: 0xF2BF0C
	public void SetOrthographicSize(float _size) { }

	// RVA: 0xF2D664 Offset: 0xF29664 VA: 0xF2D664
	public float GetOrthographicSize() { }

	// RVA: 0xF2BF24 Offset: 0xF27F24 VA: 0xF2BF24
	public Vector2 GetCameraRadius() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class AccountLoginPopup.<>c__DisplayClass11_0 // TypeDefIndex: 3012
{
	// Fields
	public AccountLoginPopup <>4__this; // 0x10
	public string inputAccount; // 0x18
	public string inputPassword; // 0x20
	public Action<NetCoreManager, NetCoreManager.MessageData> <>9__4; // 0x28
	public Action<NetCoreManager, NetCoreManager.MessageData> <>9__3; // 0x30

	// Methods

	// RVA: 0xF2E5BC Offset: 0xF2A5BC VA: 0xF2E5BC
	public void .ctor() { }

	// RVA: 0xF2E798 Offset: 0xF2A798 VA: 0xF2E798
	internal void <OnClickLoginButton>b__0(int _actionCalledTimes) { }

	// RVA: 0xF2E8F0 Offset: 0xF2A8F0 VA: 0xF2E8F0
	internal void <OnClickLoginButton>b__3(NetCoreManager net, NetCoreManager.MessageData message) { }

	// RVA: 0xF2EC00 Offset: 0xF2AC00 VA: 0xF2EC00
	internal void <OnClickLoginButton>b__4(NetCoreManager net, NetCoreManager.MessageData message2) { }

	// RVA: 0xF2EE70 Offset: 0xF2AE70 VA: 0xF2EE70
	internal void <OnClickLoginButton>b__1() { }

	// RVA: 0xF2EE9C Offset: 0xF2AE9C VA: 0xF2EE9C
	internal void <OnClickLoginButton>b__2() { }
}
