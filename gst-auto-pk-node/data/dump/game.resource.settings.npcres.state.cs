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

// Namespace: game.resource.settings.npcres.state
public class StateOnce // TypeDefIndex: 2277
{
	// Fields
	private string sprPath; // 0x10
	private ushort sprFrameCurrently; // 0x18
	private bool sprIsEnded; // 0x1A
	private bool isActive; // 0x1B
	private int looptimes; // 0x1C
	private float npcPateOffsetY; // 0x20
	private int updateRemaining; // 0x24
	private int destroyRemaning; // 0x28
	private bool hasInitialized; // 0x2C
	private GameObject goCurrent; // 0x30
	private SpriteRenderer comSpriteRenderer; // 0x38
	private RectTransform comRectTransform; // 0x40

	// Methods

	// RVA: 0xFC1B30 Offset: 0xFBDB30 VA: 0xFC1B30
	public void .ctor() { }

	// RVA: 0xFC27C4 Offset: 0xFBE7C4 VA: 0xFC27C4
	public bool IsActive() { }

	// RVA: 0xFC1B78 Offset: 0xFBDB78 VA: 0xFC1B78
	public void SetVisibility(bool visibled) { }

	// RVA: 0xFC1D0C Offset: 0xFBDD0C VA: 0xFC1D0C
	public void SetSpecialSpr(string sprPath, int looptimes = 1) { }

	// RVA: 0xFC27CC Offset: 0xFBE7CC VA: 0xFC27CC
	public void SetNpcPate(float bodyOffset) { }

	// RVA: 0xFC27D4 Offset: 0xFBE7D4 VA: 0xFC27D4
	public bool HasInitialized() { }

	// RVA: 0xFC23D4 Offset: 0xFBE3D4 VA: 0xFC23D4
	public void Initialize(GameObject parent) { }

	// RVA: 0xFC1F14 Offset: 0xFBDF14 VA: 0xFC1F14
	public bool CalcNextFrame() { }

	// RVA: 0xFC1F38 Offset: 0xFBDF38 VA: 0xFC1F38
	public bool CheckEnd() { }

	// RVA: 0xFC1F74 Offset: 0xFBDF74 VA: 0xFC1F74
	public void Release() { }

	// RVA: 0xFC2620 Offset: 0xFBE620 VA: 0xFC2620
	public void Destroy() { }

	// RVA: 0xFC2574 Offset: 0xFBE574 VA: 0xFC2574
	public void Update() { }
}

// Namespace: game.resource.settings.npcres.state
public class StateSetting // TypeDefIndex: 2278
{
	// Fields
	private State setting; // 0x10
	private int leftTime; // 0x18
	private bool isActive; // 0x1C
	private short order; // 0x1E
	private float npcPateBodyOffsetY; // 0x20
	private float npcPateHeadOffsetY; // 0x24
	private int updateRemaining; // 0x28
	private bool destroyCommandded; // 0x2C
	private float currentFrame; // 0x30
	private GameObject goCurrent; // 0x38
	private SpriteRenderer comSpriteRenderer; // 0x40
	private RectTransform comRectTransform; // 0x48
	private Vector2 anchoredOffset; // 0x50

	// Methods

	// RVA: 0xFC26D0 Offset: 0xFBE6D0 VA: 0xFC26D0
	public bool IsPermanent() { }

	// RVA: 0xFC1B60 Offset: 0xFBDB60 VA: 0xFC1B60
	public void SetVisibility(bool visibled) { }

	// RVA: 0xFC1CB0 Offset: 0xFBDCB0 VA: 0xFC1CB0
	public void SetData(State setting, int leftTime) { }

	// RVA: 0xFC1B48 Offset: 0xFBDB48 VA: 0xFC1B48
	public int GetStateId() { }

	// RVA: 0xFC27DC Offset: 0xFBE7DC VA: 0xFC27DC
	public void SetLeftTime(int leftTime) { }

	// RVA: 0xFC27E4 Offset: 0xFBE7E4 VA: 0xFC27E4
	public void SetOrderLayer(short order) { }

	// RVA: 0xFC1DE8 Offset: 0xFBDDE8 VA: 0xFC1DE8
	public void SetNpcPate(float bodyOffset, float headOffset) { }

	// RVA: 0xFC27EC Offset: 0xFBE7EC VA: 0xFC27EC
	public bool IsActive() { }

	// RVA: 0xFC2078 Offset: 0xFBE078 VA: 0xFC2078
	public void Initialize(GameObject parent) { }

	// RVA: 0xFC1B90 Offset: 0xFBDB90 VA: 0xFC1B90
	public void Deactive() { }

	// RVA: 0xFC1DF0 Offset: 0xFBDDF0 VA: 0xFC1DF0
	public void Activate() { }

	// RVA: 0xFC222C Offset: 0xFBE22C VA: 0xFC222C
	public void Update() { }

	// RVA: 0xFC1FAC Offset: 0xFBDFAC VA: 0xFC1FAC
	public void Destroy() { }

	// RVA: 0xFC1B28 Offset: 0xFBDB28 VA: 0xFC1B28
	public void .ctor() { }
}

// Namespace: 
public enum Text.FlyForm // TypeDefIndex: 2279
{
	// Fields
	public int value__; // 0x0
	public const Text.FlyForm criticalDamage = 0;
	public const Text.FlyForm normalDamageLeft = 1;
	public const Text.FlyForm normalDamageRight = 2;
}

// Namespace: 
private class Text.Info // TypeDefIndex: 2280
{
	// Fields
	public Text.FlyForm flyForm; // 0x10
	public string text; // 0x18
	public Color color; // 0x20
	public float fontMinSize; // 0x30
	public float fontMaxSize; // 0x34
	public int startTime; // 0x38
	public int endTime; // 0x3C
	public float growUpToTime; // 0x40
	public FontStyles fontStyles; // 0x44

	// Methods

	// RVA: 0xFC2CB8 Offset: 0xFBECB8 VA: 0xFC2CB8
	public void .ctor() { }
}

// Namespace: game.resource.settings.npcres.state
public class Text // TypeDefIndex: 2281
{
	// Fields
	private GameObject gameObject; // 0x10
	private MeshRenderer meshRendererComponent; // 0x18
	private TextMeshPro textMeshProComponent; // 0x20
	private RectTransform rectTransformComponent; // 0x28
	private SortingGroup comSortingGroup; // 0x30
	private bool isActive; // 0x38
	private readonly int stateIndex; // 0x3C
	private int updateRemaning; // 0x40
	private int destroyRemaning; // 0x44
	private int currentTime; // 0x48
	private float npcPateOffsetY; // 0x4C
	private float currentFontSize; // 0x50
	private Vector2 currentAnchored; // 0x54
	private Text.Info info; // 0x60

	// Methods

	// RVA: 0xFC2AE4 Offset: 0xFBEAE4 VA: 0xFC2AE4
	public void .ctor(int stateIndex) { }

	// RVA: 0xFC2B4C Offset: 0xFBEB4C VA: 0xFC2B4C
	public void SetActive(bool active) { }

	// RVA: 0xFC2B54 Offset: 0xFBEB54 VA: 0xFC2B54
	public bool IsActive() { }

	// RVA: 0xFC2B5C Offset: 0xFBEB5C VA: 0xFC2B5C
	public void SetVisibility(bool visibled) { }

	// RVA: 0xFC2B74 Offset: 0xFBEB74 VA: 0xFC2B74
	public void SetInfo(Text.FlyForm flyForm, string text, Color color, float fontMinSize, float fontMaxSize, int startTime, int growUpToTime, int endTime, FontStyles fontStyles) { }

	// RVA: 0xFC2CC0 Offset: 0xFBECC0 VA: 0xFC2CC0
	public void Initialize(GameObject parent) { }

	// RVA: 0xFC2FF0 Offset: 0xFBEFF0 VA: 0xFC2FF0
	public void Deactive() { }

	// RVA: 0xFC3008 Offset: 0xFBF008 VA: 0xFC3008
	public void Activate() { }

	// RVA: 0xFC3210 Offset: 0xFBF210 VA: 0xFC3210
	public void Update() { }

	// RVA: 0xFC3264 Offset: 0xFBF264 VA: 0xFC3264
	public void Destroy() { }
}

// Namespace: 
public class Animate.PartGroupRowIndex // TypeDefIndex: 2282
{
	// Fields
	public int head; // 0x10
	public int body; // 0x14
	public int weapon; // 0x18
	public int horse; // 0x1C

	// Methods

	// RVA: 0xFC34A4 Offset: 0xFBF4A4 VA: 0xFC34A4
	public void .ctor() { }
}
