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

// Namespace: game.objects.texture
public class Active : Updating // TypeDefIndex: 2047
{
	// Methods

	// RVA: 0xF81850 Offset: 0xF7D850 VA: 0xF81850
	public void Activate(Object gameobject) { }

	// RVA: 0xF81C90 Offset: 0xF7DC90 VA: 0xF81C90
	public void .ctor() { }
}

// Namespace: game.objects.texture
public class Appearance // TypeDefIndex: 2048
{
	// Fields
	public GameObject goCurrent; // 0x10
	public GameObject goTexture; // 0x18
	public SpriteRenderer comSpriteRenderer; // 0x20
	public RectTransform comRectTransform; // 0x28
	public SortingGroup comSortingGroup; // 0x30

	// Methods

	// RVA: 0xF81CA8 Offset: 0xF7DCA8 VA: 0xF81CA8
	public void Initialize() { }

	// RVA: 0xF81E7C Offset: 0xF7DE7C VA: 0xF81E7C
	public void Release() { }

	// RVA: 0xF82274 Offset: 0xF7E274 VA: 0xF82274
	public void .ctor() { }
}

// Namespace: game.objects.texture
public class Data // TypeDefIndex: 2049
{
	// Fields
	protected Texture texture; // 0x10
	public Action<Texture> onFirstUpdate; // 0x18
	public readonly Identification identification; // 0x20
	public readonly Appearance appearance; // 0x28
	public string sprPath; // 0x30
	public ushort sprFrame; // 0x38
	public Position positionMap; // 0x40
	public Vector3 positionScene; // 0x48
	public int positionOrderInMap; // 0x54
	public int updateRemaining; // 0x58
	public bool updateBreathing; // 0x5C
	public bool isVisibled; // 0x5D
	public bool isWaitingForApplyVisibled; // 0x5E

	// Methods

	// RVA: 0xF8227C Offset: 0xF7E27C VA: 0xF8227C
	public void .ctor() { }
}

// Namespace: 
private class Identification.TextObject // TypeDefIndex: 2050
{
	// Fields
	public static Color colorWhite; // 0x0
	public static Color colorBlue; // 0x10
	public static Color colorYellow; // 0x20
	private readonly GameObject current; // 0x10
	private readonly MeshRenderer meshRendererComponent; // 0x18
	private readonly TextMeshPro textMeshProComponent; // 0x20
	private readonly RectTransform rectTransformComponent; // 0x28

	// Methods

	// RVA: 0xF8261C Offset: 0xF7E61C VA: 0xF8261C
	public void .ctor(string objectName) { }

	// RVA: 0xF829CC Offset: 0xF7E9CC VA: 0xF829CC
	public GameObject GetAppearance() { }

	// RVA: 0xF82994 Offset: 0xF7E994 VA: 0xF82994
	public void SetAnchoredPositionY(float yy) { }

	// RVA: 0xF828B0 Offset: 0xF7E8B0 VA: 0xF828B0
	public void SetTextColor(Color color) { }

	// RVA: 0xF82808 Offset: 0xF7E808 VA: 0xF82808
	public void SetText(string text) { }

	// RVA: 0xF829D4 Offset: 0xF7E9D4 VA: 0xF829D4
	public string GetText() { }

	// RVA: 0xF829B4 Offset: 0xF7E9B4 VA: 0xF829B4
	public Vector2 GetSize() { }

	// RVA: 0xF829F4 Offset: 0xF7E9F4 VA: 0xF829F4
	public void SetActive(bool active) { }

	// RVA: 0xF82A10 Offset: 0xF7EA10 VA: 0xF82A10
	public bool IsActive() { }

	// RVA: 0xF82920 Offset: 0xF7E920 VA: 0xF82920
	public void Release() { }

	// RVA: 0xF82A28 Offset: 0xF7EA28 VA: 0xF82A28
	private static void .cctor() { }
}

// Namespace: game.objects.texture
public class Identification // TypeDefIndex: 2051
{
	// Fields
	public readonly GameObject current; // 0x10
	private Identification.TextObject nameShape; // 0x18
	private float offsetY; // 0x20
	private int updateRemaining; // 0x24
	private string nameCache; // 0x28
	private int nameColorCache; // 0x30
	private Vector3 scenePositionCache; // 0x34

	// Methods

	// RVA: 0xF82384 Offset: 0xF7E384 VA: 0xF82384
	public void .ctor() { }

	// RVA: 0xF82440 Offset: 0xF7E440 VA: 0xF82440
	public void Update() { }

	// RVA: 0xF81F64 Offset: 0xF7DF64 VA: 0xF81F64
	public void Release() { }

	// RVA: 0xF828D0 Offset: 0xF7E8D0 VA: 0xF828D0
	private float UpdateLayout() { }

	// RVA: 0xF821D4 Offset: 0xF7E1D4 VA: 0xF821D4
	public void SetScenePosition(Vector3 position) { }

	// RVA: 0xF82204 Offset: 0xF7E204 VA: 0xF82204
	public void SetName(string name) { }

	// RVA: 0xF82250 Offset: 0xF7E250 VA: 0xF82250
	public void SetNameColor(int colorType) { }
}

// Namespace: game.objects.texture
public class Updating : Data // TypeDefIndex: 2052
{
	// Fields
	private bool hasCallFirstUpdate; // 0x5F

	// Methods

	// RVA: 0xF82A9C Offset: 0xF7EA9C VA: 0xF82A9C
	public bool Update() { }

	// RVA: 0xF820F8 Offset: 0xF7E0F8 VA: 0xF820F8
	public void Apply(string sprPath, int sprFrame, int mapX, int mapY) { }

	// RVA: 0xF82270 Offset: 0xF7E270 VA: 0xF82270
	public void .ctor() { }
}
