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

// Namespace: game.resource.dataController
internal class Config // TypeDefIndex: 2477
{
	// Fields
	private static string persistentDataPath; // 0x0
	private static string localStogareFullPath; // 0x8

	// Methods

	// RVA: 0xFE1368 Offset: 0xFDD368 VA: 0xFE1368
	public static string GetPersistentDataPath() { }

	// RVA: 0xFE1408 Offset: 0xFDD408 VA: 0xFE1408
	public static string GetLocalStogareFullPath() { }

	// RVA: 0xFE14CC Offset: 0xFDD4CC VA: 0xFE14CC
	public static List<string> GetHostingControlationAddressDefault() { }

	// RVA: 0xFE1700 Offset: 0xFDD700 VA: 0xFE1700
	public void .ctor() { }
}

// Namespace: game.resource.dataController
internal enum ListElement // TypeDefIndex: 2478
{
	// Fields
	public int value__; // 0x0
	public const ListElement path = 0;
	public const ListElement filesize = 1;
	public const ListElement filemtime = 2;
}

// Namespace: game.resource.dataController
public class Model // TypeDefIndex: 2479
{
	// Fields
	[CompilerGenerated]
	private List<List<FileList>> <FileList>k__BackingField; // 0x10

	// Properties
	[JsonProperty("file.list")]
	public List<List<FileList>> FileList { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xFE1708 Offset: 0xFDD708 VA: 0xFE1708
	public List<List<FileList>> get_FileList() { }

	[CompilerGenerated]
	// RVA: 0xFE1710 Offset: 0xFDD710 VA: 0xFE1710
	public void set_FileList(List<List<FileList>> value) { }

	// RVA: 0xFE1718 Offset: 0xFDD718 VA: 0xFE1718
	public static Model FromJson(string json) { }

	// RVA: 0xFE17BC Offset: 0xFDD7BC VA: 0xFE17BC
	public void .ctor() { }
}

// Namespace: game.resource.dataController
public struct FileList // TypeDefIndex: 2480
{
	// Fields
	public long Integer; // 0x0
	public string String; // 0x8

	// Methods

	// RVA: 0xFE17C4 Offset: 0xFDD7C4 VA: 0xFE17C4
	public static FileList op_Implicit(long Integer) { }

	// RVA: 0xFE17CC Offset: 0xFDD7CC VA: 0xFE17CC
	public static FileList op_Implicit(string String) { }
}

// Namespace: game.resource.dataController
[Extension]
public static class Serialize // TypeDefIndex: 2481
{
	// Methods

	[Extension]
	// RVA: 0xFE17F8 Offset: 0xFDD7F8 VA: 0xFE17F8
	public static string ToJson(Model self) { }
}

// Namespace: game.resource.dataController
internal static class Converter // TypeDefIndex: 2482
{
	// Fields
	public static readonly JsonSerializerSettings Settings; // 0x0

	// Methods

	// RVA: 0xFE1888 Offset: 0xFDD888 VA: 0xFE1888
	private static void .cctor() { }
}

// Namespace: game.resource.dataController
internal class FileListConverter : JsonConverter // TypeDefIndex: 2483
{
	// Fields
	public static readonly FileListConverter Singleton; // 0x0

	// Methods

	// RVA: 0xFE1A7C Offset: 0xFDDA7C VA: 0xFE1A7C Slot: 6
	public override bool CanConvert(Type t) { }

	// RVA: 0xFE1B48 Offset: 0xFDDB48 VA: 0xFE1B48 Slot: 5
	public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer) { }

	// RVA: 0xFE1C90 Offset: 0xFDDC90 VA: 0xFE1C90 Slot: 4
	public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer) { }

	// RVA: 0xFE1DB4 Offset: 0xFDDDB4 VA: 0xFE1DB4
	public void .ctor() { }

	// RVA: 0xFE1DBC Offset: 0xFDDDBC VA: 0xFE1DBC
	private static void .cctor() { }
}

// Namespace: 
public class SpriteLimit.Frame // TypeDefIndex: 2484
{
	// Fields
	public int bufferSize; // 0x10
	public Sprite sprite; // 0x18
	public Vector2 sizeDelta; // 0x20
	public Vector2 anchoredPosition; // 0x28

	// Methods

	// RVA: 0xFE2688 Offset: 0xFDE688 VA: 0xFE2688
	public void .ctor() { }
}
