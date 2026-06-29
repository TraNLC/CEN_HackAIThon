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

// Namespace: game.ui.manualLayout
public class ManuaMovingSupporting : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler // TypeDefIndex: 2853
{
	// Fields
	private bool isPressing; // 0x20
	private Vector2 positionCached; // 0x24
	public Action<Vector2> onMove; // 0x30

	// Methods

	// RVA: 0xEEA194 Offset: 0xEE6194 VA: 0xEEA194 Slot: 4
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0xEEA1B8 Offset: 0xEE61B8 VA: 0xEEA1B8 Slot: 5
	public void OnDrag(PointerEventData eventData) { }

	// RVA: 0xEEA200 Offset: 0xEE6200 VA: 0xEEA200 Slot: 6
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0xEEA208 Offset: 0xEE6208 VA: 0xEEA208
	public void .ctor() { }
}

// Namespace: 
private enum Apply.HeaderIndexer // TypeDefIndex: 2854
{
	// Fields
	public int value__; // 0x0
	public const Apply.HeaderIndexer key = 0;
	public const Apply.HeaderIndexer positionX = 1;
	public const Apply.HeaderIndexer positionY = 2;
	public const Apply.HeaderIndexer scaleX = 3;
	public const Apply.HeaderIndexer scaleY = 4;
}

// Namespace: 
public class Apply.OptionFields // TypeDefIndex: 2855
{
	// Fields
	public bool chatHistorySeparated; // 0x10
	public bool teamListingSeparated; // 0x11

	// Methods

	// RVA: 0xEEA5B4 Offset: 0xEE65B4 VA: 0xEEA5B4
	public void .ctor() { }
}

// Namespace: game.ui.manualLayout
public static class Apply // TypeDefIndex: 2856
{
	// Methods

	// RVA: 0xEEA210 Offset: 0xEE6210 VA: 0xEEA210
	private static string GetAppliedPath() { }

	// RVA: 0xEEA288 Offset: 0xEE6288 VA: 0xEEA288
	private static string GetCachedPath() { }

	// RVA: 0xEEA300 Offset: 0xEE6300 VA: 0xEEA300
	public static string GetOriginPath() { }

	// RVA: 0xEEA378 Offset: 0xEE6378 VA: 0xEEA378
	public static string GetVersionPath() { }

	// RVA: 0xEEA3F0 Offset: 0xEE63F0 VA: 0xEEA3F0
	public static string GetOptionPath() { }

	// RVA: 0xEEA468 Offset: 0xEE6468 VA: 0xEEA468
	public static Apply.OptionFields OptionFieldsGet() { }

	// RVA: 0xEEA5BC Offset: 0xEE65BC VA: 0xEEA5BC
	public static void OptionFieldsSave() { }

	// RVA: 0xEEA724 Offset: 0xEE6724 VA: 0xEEA724
	public static void OptionFieldsLoad() { }

	// RVA: 0xEEAF1C Offset: 0xEE6F1C VA: 0xEEAF1C
	public static bool AppliedFileIsPresent() { }

	// RVA: 0xEEAF30 Offset: 0xEE6F30 VA: 0xEEAF30
	public static void AppliedLoad(string fullFilePath) { }

	// RVA: 0xEEC164 Offset: 0xEE8164 VA: 0xEEC164
	public static void AppliedSave() { }

	// RVA: 0xEEF0D0 Offset: 0xEEB0D0 VA: 0xEEF0D0
	public static void CachedSave() { }

	// RVA: 0xEEF134 Offset: 0xEEB134 VA: 0xEEF134
	public static bool CachedLoad() { }

	// RVA: 0xEEF18C Offset: 0xEEB18C VA: 0xEEF18C
	public static void CachedRemoveField(string keyToRemove) { }

	// RVA: 0xEEF2C0 Offset: 0xEEB2C0 VA: 0xEEF2C0
	public static void VersionSave() { }

	// RVA: 0xEEF34C Offset: 0xEEB34C VA: 0xEEF34C
	public static void OriginSave() { }

	// RVA: 0xEEF874 Offset: 0xEEB874 VA: 0xEEF874
	public static void OriginLoad() { }

	// RVA: 0xEEFFD4 Offset: 0xEEBFD4 VA: 0xEEFFD4
	public static void OriginRevert() { }

	// RVA: 0xEF01A8 Offset: 0xEEC1A8 VA: 0xEF01A8
	public static void OriginApplyTo(string key, GameObject go) { }
}

// Namespace: 
public class References.Data // TypeDefIndex: 2857
{
	// Fields
	public string name; // 0x10
	public string key; // 0x18
	public GameObject go; // 0x20
	public List<GameObject> activeEnableList; // 0x28
	public List<GameObject> activeDisableList; // 0x30
	public bool denyRemove; // 0x38
	public bool denyScale; // 0x39
	public bool denyDisplay; // 0x3A

	// Methods

	// RVA: 0xEF05EC Offset: 0xEEC5EC VA: 0xEF05EC
	public void .ctor() { }
}

// Namespace: game.ui.manualLayout
public static class References // TypeDefIndex: 2858
{
	// Fields
	private static References.Data settings; // 0x0
	private static List<References.Data> listing; // 0x8
	private static bool isUsing; // 0x10
	private static Dictionary<string, References.Data> mapping; // 0x18
	private static bool chatHistorySeparated; // 0x20
	private static bool teamListingSeparated; // 0x21

	// Methods

	// RVA: 0xEF0464 Offset: 0xEEC464 VA: 0xEF0464
	public static void Release() { }

	// RVA: 0xEF0554 Offset: 0xEEC554 VA: 0xEF0554
	public static bool IsUsing() { }

	// RVA: 0xEF059C Offset: 0xEEC59C VA: 0xEF059C
	public static void SetUsing(bool isUsing) { }

	// RVA: 0xEEBBC8 Offset: 0xEE7BC8 VA: 0xEEBBC8
	public static References.Data GetSetting() { }

	// RVA: 0xEEB9DC Offset: 0xEE79DC VA: 0xEEB9DC
	public static Dictionary<string, References.Data> GetMapping() { }

	// RVA: 0xEEC63C Offset: 0xEE863C VA: 0xEEC63C
	public static List<References.Data> GetListing() { }

	// RVA: 0xEEA74C Offset: 0xEE674C VA: 0xEEA74C
	public static void SetChatHistorySeparate(bool separated) { }

	// RVA: 0xEF0854 Offset: 0xEEC854 VA: 0xEF0854
	public static bool IsChatHistorySeparated() { }

	// RVA: 0xEEACD4 Offset: 0xEE6CD4 VA: 0xEEACD4
	public static void SetTeamListingSeparate(bool separated) { }

	// RVA: 0xEF089C Offset: 0xEEC89C VA: 0xEF089C
	public static bool IsTeamListingSeparated() { }

	// RVA: 0xEF0640 Offset: 0xEEC640 VA: 0xEF0640
	public static void CheckQuestTeamChatButtonTabGroup() { }
}
