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

// Namespace: game.resource.settings.npcres.special
public class Animate // TypeDefIndex: 2283
{
	// Fields
	public static readonly Dictionary<string, Structures.PartAnimation> Empty; // 0x0
	private readonly Identification identification; // 0x10
	public string characterType; // 0x18
	public int direction; // 0x20
	public bool riding; // 0x24
	private string action; // 0x28
	private string animation; // 0x30
	public readonly Animate.PartGroupRowIndex partGroupRowIndex; // 0x38
	public readonly Dictionary<string, Structures.PartAnimation> partAnimations; // 0x40

	// Methods

	// RVA: 0xFC32F0 Offset: 0xFBF2F0 VA: 0xFC32F0
	public void .ctor(Identification identification, int headIndex = 19, int bodyIndex = 19, int weaponIndex = 1, int horseIndex = -1) { }

	// RVA: 0xFC355C Offset: 0xFBF55C VA: 0xFC355C
	private Dictionary<string, Structures.PartAnimation> ResetAllPartAnimationAuto() { }

	// RVA: 0xFC3B1C Offset: 0xFBFB1C VA: 0xFC3B1C
	private Dictionary<string, Structures.PartAnimation> ResetAllPartAnimationManual(string newAnimation) { }

	// RVA: 0xFC34B4 Offset: 0xFBF4B4 VA: 0xFC34B4
	public int GetNpcPate() { }

	// RVA: 0xFC3CC0 Offset: 0xFBFCC0 VA: 0xFC3CC0
	public Dictionary<string, Structures.PartAnimation> SetCharacterType(string _type) { }

	// RVA: 0xFC3D58 Offset: 0xFBFD58 VA: 0xFC3D58
	public Dictionary<string, Structures.PartAnimation> SetAction(string _action) { }

	// RVA: 0xFC3E98 Offset: 0xFBFE98 VA: 0xFC3E98
	public Dictionary<string, Structures.PartAnimation> SetDirection(int _direction) { }

	// RVA: 0xFC3F18 Offset: 0xFBFF18 VA: 0xFC3F18
	public Dictionary<string, Structures.PartAnimation> SetRiding(bool _riding) { }

	// RVA: 0xFC3FEC Offset: 0xFBFFEC VA: 0xFC3FEC
	public Dictionary<string, Structures.PartAnimation> SetHeadRes(int _headResId) { }

	// RVA: 0xFC422C Offset: 0xFC022C VA: 0xFC422C
	public Dictionary<string, Structures.PartAnimation> SetHeadItemLine(int _line) { }

	// RVA: 0xFC42A0 Offset: 0xFC02A0 VA: 0xFC42A0
	public Dictionary<string, Structures.PartAnimation> SetBodyRes(int resId) { }

	// RVA: 0xFC44E0 Offset: 0xFC04E0 VA: 0xFC44E0
	public Dictionary<string, Structures.PartAnimation> SetBodyItemLine(int _line) { }

	// RVA: 0xFC4554 Offset: 0xFC0554 VA: 0xFC4554
	public Dictionary<string, Structures.PartAnimation> SetWeaponRes(int resId) { }

	// RVA: 0xFC47D8 Offset: 0xFC07D8 VA: 0xFC47D8
	public Dictionary<string, Structures.PartAnimation> SetWeaponItemLine(int _line) { }

	// RVA: 0xFC484C Offset: 0xFC084C VA: 0xFC484C
	public Dictionary<string, Structures.PartAnimation> SetHorseRes(int _horseResId) { }

	// RVA: 0xFC4AB0 Offset: 0xFC0AB0 VA: 0xFC4AB0
	public Dictionary<string, Structures.PartAnimation> SetHorseItemLine(int _line) { }

	// RVA: 0xFC4B24 Offset: 0xFC0B24 VA: 0xFC4B24
	public Dictionary<string, Structures.PartAnimation> SetHeadItemDefault() { }

	// RVA: 0xFC4B2C Offset: 0xFC0B2C VA: 0xFC4B2C
	public Dictionary<string, Structures.PartAnimation> SetBodyItemDefault() { }

	// RVA: 0xFC4B34 Offset: 0xFC0B34 VA: 0xFC4B34
	public Dictionary<string, Structures.PartAnimation> SetHandItemDefault() { }

	// RVA: 0xFC4B3C Offset: 0xFC0B3C VA: 0xFC4B3C
	public Dictionary<string, Structures.PartAnimation> SetHorseItemDefault() { }

	// RVA: 0xFC4B5C Offset: 0xFC0B5C VA: 0xFC4B5C
	private static void .cctor() { }
}

// Namespace: game.resource.settings.npcres.special
internal class Getters // TypeDefIndex: 2284
{
	// Methods

	// RVA: 0xFC4BF4 Offset: 0xFC0BF4 VA: 0xFC4BF4
	public static List<string> PartGroup(Dictionary<string, Table> _tableHeaderMapping, string _partMember) { }

	// RVA: 0xFC4E44 Offset: 0xFC0E44 VA: 0xFC4E44
	public static List<string> PartGroup(string _specialType, string _partMember) { }

	// RVA: 0xFC4FA4 Offset: 0xFC0FA4 VA: 0xFC4FA4
	public static string AnimationName(Dictionary<string, Table> _tableMapping, bool _riding, string _weaponAction, int _rowIndex) { }

	// RVA: 0xFC3718 Offset: 0xFBF718 VA: 0xFC3718
	public static string AnimationName(string _specialType, bool _riding, string _weaponAction, int _rowIndex) { }

	// RVA: 0xFC50CC Offset: 0xFC10CC VA: 0xFC50CC
	public static int PartOrder(Dictionary<string, Ini> _iniMapping, string _partName, string _animationName, int _direction) { }

	// RVA: 0xFC5754 Offset: 0xFC1754 VA: 0xFC5754
	public static int PartOrder(string _specialType, string _partName, string _animationName, int _direction) { }

	// RVA: 0xFC5800 Offset: 0xFC1800 VA: 0xFC5800
	public static Structures.PartSprInfo PartSprInfo(Dictionary<string, Table> _tableMapping, Dictionary<string, string> _headerMapping, Dictionary<string, Table> _propertiesMapping, string _partName, string _animationName, int _rowIndex) { }

	// RVA: 0xFC5C64 Offset: 0xFC1C64 VA: 0xFC5C64
	public static Structures.PartSprInfo PartSprInfo(string _specialType, string _partName, string _animationName, int _rowIndex) { }

	// RVA: 0xFC5D78 Offset: 0xFC1D78 VA: 0xFC5D78
	public static Structures.PartAnimation PartAnimation(string _specialType, string _animationName, string _partName, int _direction, int _rowIndex) { }

	// RVA: 0xFC396C Offset: 0xFBF96C VA: 0xFC396C
	public static Structures.PartAnimation ShadowAnimation(string _specialType, string _animationName, int _direction) { }

	// RVA: 0xFC37D0 Offset: 0xFBF7D0 VA: 0xFC37D0
	public static void PartGroupAnimation(Dictionary<string, Structures.PartAnimation> result, string _specialType, string _animationName, string _partName, int _direction, int _rowIndex) { }

	// RVA: 0xFC5E98 Offset: 0xFC1E98 VA: 0xFC5E98
	public void .ctor() { }
}

// Namespace: game.resource.settings.npcres.special
internal class Part // TypeDefIndex: 2285
{
	// Methods

	// RVA: 0xFC5EA0 Offset: 0xFC1EA0 VA: 0xFC5EA0
	public static List<string> AllPartList() { }

	// RVA: 0xFC6434 Offset: 0xFC2434 VA: 0xFC6434
	public static List<string> AllTabFileList() { }

	// RVA: 0xFC6624 Offset: 0xFC2624 VA: 0xFC6624
	public static List<string> AllIniFileList() { }

	// RVA: 0xFC54A8 Offset: 0xFC14A8 VA: 0xFC54A8
	public static Dictionary<int, string> AllPartId() { }

	// RVA: 0xFC6714 Offset: 0xFC2714 VA: 0xFC6714
	public void .ctor() { }
}

// Namespace: game.resource.settings.npcres.special
internal class Validation // TypeDefIndex: 2286
{
	// Methods

	// RVA: 0xFC4F0C Offset: 0xFC0F0C VA: 0xFC4F0C
	public static bool IsMainMan(string _characterName) { }

	// RVA: 0xFC4F58 Offset: 0xFC0F58 VA: 0xFC4F58
	public static bool IsMainLady(string _characterName) { }

	// RVA: 0xFC671C Offset: 0xFC271C VA: 0xFC671C
	public void .ctor() { }
}
