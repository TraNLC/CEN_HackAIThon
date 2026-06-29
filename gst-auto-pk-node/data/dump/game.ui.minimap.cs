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

// Namespace: game.ui.minimap
public class ButtonNpc : MonoBehaviour // TypeDefIndex: 2860
{
	// Fields
	[SerializeField]
	private TextMeshProUGUI NpcName; // 0x20
	private Action onclick; // 0x28

	// Methods

	// RVA: 0xEF0910 Offset: 0xEEC910 VA: 0xEF0910
	private void Start() { }

	// RVA: 0xEF09C8 Offset: 0xEEC9C8 VA: 0xEF09C8
	public void SetUpData(MapDialogNpc npcEntry, Action onclick) { }

	// RVA: 0xEF0A74 Offset: 0xEECA74 VA: 0xEF0A74
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEF0A7C Offset: 0xEECA7C VA: 0xEF0A7C
	private void <Start>b__2_0() { }
}

// Namespace: game.ui.minimap
public enum UIMapType // TypeDefIndex: 2861
{
	// Fields
	public int value__; // 0x0
	public const UIMapType NPC = 0;
	public const UIMapType Player = 1;
	public const UIMapType Party = 2;
}

// Namespace: game.ui.minimap
public class NpcInMap : MonoBehaviour // TypeDefIndex: 2862
{
	// Fields
	[SerializeField]
	private TextMeshProUGUI npcNameObj; // 0x20
	[SerializeField]
	public RectTransform rectTransform; // 0x28
	[SerializeField]
	private Button button; // 0x30
	private MapDialogNpc npcEntry; // 0x38
	private Action<bool> onclick; // 0x40

	// Methods

	// RVA: 0xEF0B08 Offset: 0xEECB08 VA: 0xEF0B08
	public int GetMapX() { }

	// RVA: 0xEF0B20 Offset: 0xEECB20 VA: 0xEF0B20
	public int GetMapY() { }

	// RVA: 0xEF0B38 Offset: 0xEECB38 VA: 0xEF0B38
	private void Start() { }

	// RVA: 0xEF0BC8 Offset: 0xEECBC8 VA: 0xEF0BC8
	public void AddNpc(MapDialogNpc npcEntry, UIMapType mapType, Action<bool> onclick) { }

	// RVA: 0xEF0CA4 Offset: 0xEECCA4 VA: 0xEF0CA4
	public void ShowNameNpc(bool isActive) { }

	// RVA: 0xEF0DEC Offset: 0xEECDEC VA: 0xEF0DEC
	public bool ShowoffNpcName() { }

	// RVA: 0xEF0E54 Offset: 0xEECE54 VA: 0xEF0E54
	public void AddPlayer(string name, UIMapType mapType) { }

	// RVA: 0xEF0CD4 Offset: 0xEECCD4 VA: 0xEF0CD4
	private void MapColor(UIMapType mapType) { }

	// RVA: 0xEF0F20 Offset: 0xEECF20 VA: 0xEF0F20
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xEF0F28 Offset: 0xEECF28 VA: 0xEF0F28
	private void <Start>b__7_0() { }
}
