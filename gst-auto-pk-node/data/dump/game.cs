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

// Namespace: game
public class Resource // TypeDefIndex: 2033
{
	// Fields
	private readonly string path; // 0x10
	public static readonly bool IsUnityClient; // 0x0
	public static readonly Encoding encoding1252; // 0x8

	// Methods

	// RVA: 0xF7FC7C Offset: 0xF7BC7C VA: 0xF7FC7C
	public void .ctor(string _path) { }

	// RVA: 0xF7FCAC Offset: 0xF7BCAC VA: 0xF7FCAC
	public static Resource op_Implicit(string _path) { }

	// RVA: 0xF7FD14 Offset: 0xF7BD14 VA: 0xF7FD14
	public static Resource Path(string path) { }

	// RVA: 0xF7FD7C Offset: 0xF7BD7C VA: 0xF7FD7C
	private ElementReference GetPackageElement() { }

	// RVA: 0xF7FE28 Offset: 0xF7BE28 VA: 0xF7FE28
	private Buffer GetBufferData() { }

	// RVA: 0xF80020 Offset: 0xF7C020 VA: 0xF80020
	private Table GetTableFile() { }

	// RVA: 0xF8008C Offset: 0xF7C08C VA: 0xF8008C
	private Ini GetIniFile() { }

	// RVA: 0xF800F8 Offset: 0xF7C0F8 VA: 0xF800F8
	private SPR.FrameCount GetSprFrameCount() { }

	// RVA: 0xF80154 Offset: 0xF7C154 VA: 0xF80154
	private SPR.Info GetSprInfo() { }

	// RVA: 0xF8020C Offset: 0xF7C20C VA: 0xF8020C
	private SPR.FrameInfo GetSprFrameInfo(ushort _frameIndex) { }

	// RVA: 0xF802BC Offset: 0xF7C2BC VA: 0xF802BC
	private SPR.TextureBuffer GetSprFrameRawTextureData(SPR.FrameInfo _frameInfo) { }

	// RVA: 0xF803D8 Offset: 0xF7C3D8 VA: 0xF803D8
	private SPR.TextureBuffer GetSprFrameRawTextureData(ushort _frameIndex) { }

	// RVA: 0xF803F4 Offset: 0xF7C3F4 VA: 0xF803F4
	private Texture2D GetSprFrameTexture2D(SPR.FrameInfo _frameInfo) { }

	// RVA: 0xF804A8 Offset: 0xF7C4A8 VA: 0xF804A8
	private Texture2D GetSprFrameTexture2D(ushort _frameIndex) { }

	// RVA: 0xF804C4 Offset: 0xF7C4C4 VA: 0xF804C4
	private Sprite GetSprFrameSprite(SPR.FrameInfo _frameInfo) { }

	// RVA: 0xF80524 Offset: 0xF7C524 VA: 0xF80524
	private Sprite GetSprFrameSprite(ushort _frameIndex) { }

	// RVA: 0xF80564 Offset: 0xF7C564 VA: 0xF80564
	private Sprite GetImageSprite() { }

	// RVA: -1 Offset: -1
	public Typename Get<Typename>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1141694 Offset: 0x113D694 VA: 0x1141694
	|-Resource.Get<object>
	|
	|-RVA: 0x1141A54 Offset: 0x113DA54 VA: 0x1141A54
	|-Resource.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Typename Get<Typename>(ushort _frameIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1141E48 Offset: 0x113DE48 VA: 0x1141E48
	|-Resource.Get<object>
	|
	|-RVA: 0x114232C Offset: 0x113E32C VA: 0x114232C
	|-Resource.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public Typename Get<Typename>(SPR.FrameInfo _frameInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11420E8 Offset: 0x113E0E8 VA: 0x11420E8
	|-Resource.Get<object>
	|
	|-RVA: 0x114262C Offset: 0x113E62C VA: 0x114262C
	|-Resource.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xF80648 Offset: 0xF7C648 VA: 0xF80648
	public static void SaveToFile(string fullpath, string data) { }

	// RVA: 0xF807EC Offset: 0xF7C7EC VA: 0xF807EC
	public static void SaveToFile(string fullpath, byte[] data) { }

	// RVA: 0xF806B8 Offset: 0xF7C6B8 VA: 0xF806B8
	public static void CreateDirectory(string fullpath) { }

	// RVA: 0xF75828 Offset: 0xF71828 VA: 0xF75828
	public static string ReplaceStringPath(string path) { }

	// RVA: 0xF8085C Offset: 0xF7C85C VA: 0xF8085C
	public static string RootPath() { }

	// RVA: 0xF80864 Offset: 0xF7C864 VA: 0xF80864
	private static void .cctor() { }
}

// Namespace: game
public class Skill : SkillCast // TypeDefIndex: 2034
{
	// Fields
	public static Skill Empty; // 0x0

	// Methods

	// RVA: 0xF808D0 Offset: 0xF7C8D0 VA: 0xF808D0
	public void .ctor() { }

	// RVA: 0xF808D8 Offset: 0xF7C8D8 VA: 0xF808D8
	public void .ctor(int id, int level) { }

	// RVA: 0xF80A24 Offset: 0xF7CA24 VA: 0xF80A24
	private static void .cctor() { }
}

// Namespace: game
public class Item : ItemGenerate // TypeDefIndex: 2035
{
	// Methods

	// RVA: 0xF80A8C Offset: 0xF7CA8C VA: 0xF80A8C
	public void .ctor() { }

	// RVA: 0xF80AB0 Offset: 0xF7CAB0 VA: 0xF80AB0
	public void .ctor(Item database) { }
}

// Namespace: game
public class Object : ObjectDataField // TypeDefIndex: 2036
{
	// Fields
	private static long CurrentObjectIndex; // 0x0

	// Methods

	// RVA: 0xF80AF0 Offset: 0xF7CAF0 VA: 0xF80AF0
	public void .ctor(int dataId, string objectName, int objectNameColor = 0) { }

	// RVA: 0xF816D4 Offset: 0xF7D6D4 VA: 0xF816D4
	public void .ctor(AddMapObject protocol) { }

	// RVA: 0xF81764 Offset: 0xF7D764 VA: 0xF81764
	public void SetObjectTypeItem(Item item) { }

	// RVA: 0xF817A0 Offset: 0xF7D7A0 VA: 0xF817A0
	public void SetObjectTypeMoney() { }

	// RVA: 0xF817AC Offset: 0xF7D7AC VA: 0xF817AC
	public bool Activate() { }

	// RVA: 0xF81958 Offset: 0xF7D958 VA: 0xF81958
	public string GetGuid() { }

	// RVA: 0xF81960 Offset: 0xF7D960 VA: 0xF81960
	public int GetMapId() { }

	// RVA: 0xF81968 Offset: 0xF7D968 VA: 0xF81968
	public Position GetMapPosition() { }

	// RVA: 0xF81970 Offset: 0xF7D970 VA: 0xF81970
	public int GetRemainingLifeFrame() { }

	// RVA: 0xF81978 Offset: 0xF7D978 VA: 0xF81978
	public int GetRemainingDropFrame() { }

	// RVA: 0xF81980 Offset: 0xF7D980 VA: 0xF81980
	public int GetRemainingOwnerFrame() { }

	// RVA: 0xF81988 Offset: 0xF7D988 VA: 0xF81988
	public int GetCurrentLifeFrame() { }

	// RVA: 0xF81990 Offset: 0xF7D990 VA: 0xF81990
	public string GetName() { }

	// RVA: 0xF81998 Offset: 0xF7D998 VA: 0xF81998
	public int GetNameColor() { }
}
