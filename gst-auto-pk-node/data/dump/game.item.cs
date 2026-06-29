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

// Namespace: game.item
public class GoldEquipBase : EquipBase // TypeDefIndex: 2060
{
	// Fields
	public ushort magic0; // 0x144
	public ushort magic1; // 0x146
	public ushort magic2; // 0x148
	public ushort magic3; // 0x14A
	public ushort magic4; // 0x14C
	public ushort magic5; // 0x14E
	public ushort idSet; // 0x150
	public readonly List<int> magicIndexList; // 0x158
	public static readonly GoldEquipBase Empty; // 0x0

	// Methods

	// RVA: 0xF87800 Offset: 0xF83800 VA: 0xF87800
	public bool IsEmpty() { }

	// RVA: 0xF87818 Offset: 0xF83818 VA: 0xF87818
	public void .ctor() { }

	// RVA: 0xF87AF4 Offset: 0xF83AF4 VA: 0xF87AF4
	private static void .cctor() { }
}

// Namespace: game.item
public class GoldMagicBase // TypeDefIndex: 2061
{
	// Fields
	public string type; // 0x10
	public int value1Min; // 0x18
	public int value1Max; // 0x1C
	public int value2Min; // 0x20
	public int value2Max; // 0x24
	public int value3Min; // 0x28
	public int value3Max; // 0x2C
	public static readonly GoldMagicBase Empty; // 0x0

	// Methods

	// RVA: 0xF87B58 Offset: 0xF83B58 VA: 0xF87B58
	public bool IsEmpty() { }

	// RVA: 0xF87B64 Offset: 0xF83B64 VA: 0xF87B64
	public void .ctor() { }

	// RVA: 0xF87B98 Offset: 0xF83B98 VA: 0xF87B98
	private static void .cctor() { }
}

// Namespace: game.item
public class GoldResBase // TypeDefIndex: 2062
{
	// Fields
	public int equipRowIndex; // 0x10
	public int resId; // 0x14

	// Methods

	// RVA: 0xF87C20 Offset: 0xF83C20 VA: 0xF87C20
	public void .ctor() { }
}

// Namespace: game.item
public class MagicScriptBase // TypeDefIndex: 2063
{
	// Fields
	public int rowindex; // 0x10
	public string name; // 0x18
	public int particular; // 0x20
	public string image; // 0x28
	public int objectId; // 0x30
	public int price; // 0x34
	public int stack; // 0x38
	public int getdesc; // 0x3C
	public string script; // 0x40
	public string intro; // 0x48
	public static readonly MagicScriptBase Empty; // 0x0

	// Methods

	// RVA: 0xF87C30 Offset: 0xF83C30 VA: 0xF87C30
	public bool IsEmpty() { }

	// RVA: 0xF87C40 Offset: 0xF83C40 VA: 0xF87C40
	public void .ctor() { }

	// RVA: 0xF87CC4 Offset: 0xF83CC4 VA: 0xF87CC4
	private static void .cctor() { }
}

// Namespace: game.item
public class MagicAttribBase // TypeDefIndex: 2064
{
	// Fields
	public string name; // 0x10
	public int pos; // 0x18
	public int series; // 0x1C
	public int level; // 0x20
	public string propKind; // 0x28
	public int value0Min; // 0x30
	public int value0Max; // 0x34
	public int value1Min; // 0x38
	public int value1Max; // 0x3C
	public int value2Min; // 0x40
	public int value2Max; // 0x44
	public string intro; // 0x48
	public Dictionary<int, int> droprate; // 0x50

	// Methods

	// RVA: 0xF87D28 Offset: 0xF83D28 VA: 0xF87D28
	public int GetDropRate(int detail) { }

	// RVA: 0xF87DA0 Offset: 0xF83DA0 VA: 0xF87DA0
	public List<int> GetCacheKeyList() { }

	// RVA: 0xF8831C Offset: 0xF8431C VA: 0xF8831C
	public void .ctor() { }
}

// Namespace: game.item
public class EquipBase // TypeDefIndex: 2065
{
	// Fields
	public int rowIndex; // 0x10
	public string name; // 0x18
	public int genre; // 0x20
	public int detail; // 0x24
	public int particular; // 0x28
	public string imagePath; // 0x30
	public int objIdx; // 0x38
	public int width; // 0x3C
	public int height; // 0x40
	public string intro; // 0x48
	public int series; // 0x50
	public int price; // 0x54
	public int level; // 0x58
	public int stack; // 0x5C
	public string propBasic0Type; // 0x60
	public int propBasic0Min; // 0x68
	public int propBasic0Max; // 0x6C
	public string propBasic1Type; // 0x70
	public int propBasic1Min; // 0x78
	public int propBasic1Max; // 0x7C
	public string propBasic2Type; // 0x80
	public int propBasic2Min; // 0x88
	public int propBasic2Max; // 0x8C
	public string propBasic3Type; // 0x90
	public int propBasic3Min; // 0x98
	public int propBasic3Max; // 0x9C
	public string propBasic4Type; // 0xA0
	public int propBasic4Min; // 0xA8
	public int propBasic4Max; // 0xAC
	public string propBasic5Type; // 0xB0
	public int propBasic5Min; // 0xB8
	public int propBasic5Max; // 0xBC
	public string propBasic6Type; // 0xC0
	public int propBasic6Min; // 0xC8
	public int propBasic6Max; // 0xCC
	public string requirement0Type; // 0xD0
	public int requirement0Para; // 0xD8
	public string requirement1Type; // 0xE0
	public int requirement1Para; // 0xE8
	public string requirement2Type; // 0xF0
	public int requirement2Para; // 0xF8
	public string requirement3Type; // 0x100
	public int requirement3Para; // 0x108
	public string requirement4Type; // 0x110
	public int requirement4Para; // 0x118
	public string requirement5Type; // 0x120
	public int requirement5Para; // 0x128
	public static readonly EquipBase Empty; // 0x0
	public readonly List<Attrib> basicAttrib; // 0x130
	public readonly List<Attrib> requiredAttrib; // 0x138
	public int originDurability; // 0x140

	// Methods

	// RVA: 0xF8780C Offset: 0xF8380C VA: 0xF8780C
	public bool IsEmpty() { }

	// RVA: 0xF878C0 Offset: 0xF838C0 VA: 0xF878C0
	public void .ctor() { }

	// RVA: 0xF883F4 Offset: 0xF843F4 VA: 0xF883F4
	private static void .cctor() { }
}

// Namespace: game.item
public static class Cache // TypeDefIndex: 2066
{
	// Methods

	// RVA: 0xF88458 Offset: 0xF84458 VA: 0xF88458
	public static bool Initialize(Action<string> logfunc) { }
}

// Namespace: 
public class ItemImage.ThumbnailRectOffset // TypeDefIndex: 2067
{
	// Fields
	public Vector2 offsetMin; // 0x10
	public Vector2 offsetMax; // 0x18
	public bool preserveAspect; // 0x20

	// Methods

	// RVA: 0xF893C8 Offset: 0xF853C8 VA: 0xF893C8
	public void .ctor() { }
}

// Namespace: game.item
public class ItemImage : ItemMagic // TypeDefIndex: 2068
{
	// Fields
	public static Sprite itemThumbnailUnidentifiedSprite; // 0x0
	private static readonly ItemImage.ThumbnailRectOffset static_thumbnailBagarate1; // 0x8
	private static readonly ItemImage.ThumbnailRectOffset static_thumbnailBagarate2; // 0x10
	private static readonly ItemImage.ThumbnailRectOffset static_thumbnailBagarate3; // 0x18
	private static readonly ItemImage.ThumbnailRectOffset static_thumbnailBagarate4; // 0x20
	private static readonly ItemImage.ThumbnailRectOffset static_thumbnailBagarate5; // 0x28
	private static readonly ItemImage.ThumbnailRectOffset static_thumbnailBagarate6; // 0x30
	private static readonly ItemImage.ThumbnailRectOffset static_thumbnailEquipment1; // 0x38
	private static readonly ItemImage.ThumbnailRectOffset static_thumbnailEquipment2; // 0x40
	private static readonly ItemImage.ThumbnailRectOffset static_thumbnailEquipment3; // 0x48
	private static readonly ItemImage.ThumbnailRectOffset static_thumbnailEquipment4; // 0x50
	private static readonly ItemImage.ThumbnailRectOffset static_thumbnailEquipment5; // 0x58
	public static readonly Color static_thumbnailBackgroundColor_green; // 0x60
	public static readonly Color static_thumbnailBackgroundColor_red; // 0x70

	// Methods

	// RVA: 0xF8862C Offset: 0xF8462C VA: 0xF8862C
	public int[] GetThumbnailStoredWidthHeight() { }

	// RVA: 0xF886EC Offset: 0xF846EC VA: 0xF886EC
	public Sprite GetThumbnailSprite() { }

	// RVA: 0xF88958 Offset: 0xF84958 VA: 0xF88958
	public void ApplyThumbnailBagarateRect(RectTransform thumbnailRect, Image thumbnailImage) { }

	// RVA: 0xF88D54 Offset: 0xF84D54 VA: 0xF88D54
	public void ApplyThumbnailEquipmentRect(RectTransform thumbnailRect, Image thumbnailImage) { }

	// RVA: 0xF88FD0 Offset: 0xF84FD0 VA: 0xF88FD0
	public static void ApplyThumbnailBackgroundColor(Image thumbnailImage, bool isPassed) { }

	// RVA: 0xF89098 Offset: 0xF85098 VA: 0xF89098
	public void .ctor() { }

	// RVA: 0xF890A0 Offset: 0xF850A0 VA: 0xF890A0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ItemSorter.<>c // TypeDefIndex: 2069
{
	// Fields
	public static readonly ItemSorter.<>c <>9; // 0x0
	public static Comparison<Item> <>9__0_0; // 0x8
	public static Comparison<Item> <>9__0_1; // 0x10
	public static Comparison<Item> <>9__0_2; // 0x18
	public static Comparison<Item> <>9__0_3; // 0x20
	public static Comparison<Item> <>9__0_4; // 0x28
	public static Comparison<Item> <>9__0_5; // 0x30
	public static Comparison<Item> <>9__0_6; // 0x38
	public static Comparison<Item> <>9__0_7; // 0x40
	public static Comparison<Item> <>9__0_8; // 0x48
	public static Comparison<Item> <>9__0_9; // 0x50
	public static Comparison<Item> <>9__0_10; // 0x58
	public static Comparison<Item> <>9__0_11; // 0x60

	// Methods

	// RVA: 0xF8A270 Offset: 0xF86270 VA: 0xF8A270
	private static void .cctor() { }

	// RVA: 0xF8A2D8 Offset: 0xF862D8 VA: 0xF8A2D8
	public void .ctor() { }

	// RVA: 0xF8A2E0 Offset: 0xF862E0 VA: 0xF8A2E0
	internal int <SortToList>b__0_0(Item a, Item b) { }

	// RVA: 0xF8A314 Offset: 0xF86314 VA: 0xF8A314
	internal int <SortToList>b__0_1(Item a, Item b) { }

	// RVA: 0xF8A348 Offset: 0xF86348 VA: 0xF8A348
	internal int <SortToList>b__0_2(Item a, Item b) { }

	// RVA: 0xF8A37C Offset: 0xF8637C VA: 0xF8A37C
	internal int <SortToList>b__0_3(Item a, Item b) { }

	// RVA: 0xF8A3B0 Offset: 0xF863B0 VA: 0xF8A3B0
	internal int <SortToList>b__0_4(Item a, Item b) { }

	// RVA: 0xF8A3E4 Offset: 0xF863E4 VA: 0xF8A3E4
	internal int <SortToList>b__0_5(Item a, Item b) { }

	// RVA: 0xF8A418 Offset: 0xF86418 VA: 0xF8A418
	internal int <SortToList>b__0_6(Item a, Item b) { }

	// RVA: 0xF8A44C Offset: 0xF8644C VA: 0xF8A44C
	internal int <SortToList>b__0_7(Item a, Item b) { }

	// RVA: 0xF8A480 Offset: 0xF86480 VA: 0xF8A480
	internal int <SortToList>b__0_8(Item a, Item b) { }

	// RVA: 0xF8A4B4 Offset: 0xF864B4 VA: 0xF8A4B4
	internal int <SortToList>b__0_9(Item a, Item b) { }

	// RVA: 0xF8A4E8 Offset: 0xF864E8 VA: 0xF8A4E8
	internal int <SortToList>b__0_10(Item a, Item b) { }

	// RVA: 0xF8A51C Offset: 0xF8651C VA: 0xF8A51C
	internal int <SortToList>b__0_11(Item a, Item b) { }
}

// Namespace: game.item
public static class ItemSorter // TypeDefIndex: 2070
{
	// Methods

	// RVA: 0xF893D0 Offset: 0xF853D0 VA: 0xF893D0
	public static List<Item> SortToList(ConcurrentDictionary<int, Item> items, int location, bool isDecrease) { }
}

// Namespace: 
public static class Definition.LockState // TypeDefIndex: 2071
{
	// Fields
	public const int unidentified = 0;
	public const int lockTemporary = 1;
	public const int lockForever = 2;
}

// Namespace: 
public static class Definition.Type // TypeDefIndex: 2072
{
	// Fields
	public const int unidentified = 0;
	public const int normalEquip = 1;
	public const int goldEquip = 2;
	public const int magicScript = 3;
}

// Namespace: 
public static class Definition.Genre // TypeDefIndex: 2073
{
	// Fields
	public const int equip = 0;
	public const int medicine = 1;
	public const int mine = 2;
	public const int materials = 3;
	public const int task = 4;
	public const int townportal = 5;
	public const int magicscript = 6;
}

// Namespace: 
public static class Definition.Detail // TypeDefIndex: 2074
{
	// Fields
	public const int meleeweapon = 0;
	public const int rangeweapon = 1;
	public const int armor = 2;
	public const int ring = 3;
	public const int amulet = 4;
	public const int boots = 5;
	public const int belt = 6;
	public const int helm = 7;
	public const int cuff = 8;
	public const int pendant = 9;
	public const int horse = 10;
	public const int mask = 11;
}

// Namespace: 
public static class Definition.Series // TypeDefIndex: 2075
{
	// Fields
	public const int unidentified = -1;
	public const int metal = 0;
	public const int wood = 1;
	public const int water = 2;
	public const int fire = 3;
	public const int earth = 4;
}

// Namespace: 
public static class Definition.Place // TypeDefIndex: 2076
{
	// Fields
	public const int unidentified = 0;
	public const int weapon = 1;
	public const int armor = 2;
	public const int ring_above = 3;
	public const int ring_below = 4;
	public const int amulet = 5;
	public const int boots = 6;
	public const int belt = 7;
	public const int helm = 8;
	public const int cuff = 9;
	public const int pendant = 10;
	public const int horse = 11;
	public const int mask = 12;
}

// Namespace: 
public static class Definition.Location // TypeDefIndex: 2077
{
	// Fields
	public const int unidentified = 0;
	public const int equip = 1;
	public const int bagarate = 2;
	public const int storageBase = 3;
	public const int storageExtend1 = 4;
	public const int storageExtend2 = 5;
	public const int storageExtend3 = 6;
	public const int storageExtend4 = 7;
}

// Namespace: 
public class Definition.Path.NormalResData // TypeDefIndex: 2078
{
	// Fields
	public readonly int id; // 0x10
	public readonly string path; // 0x18

	// Methods

	// RVA: 0xF8AE3C Offset: 0xF86E3C VA: 0xF8AE3C
	public void .ctor(int id, string path) { }
}

// Namespace: 
public static class Definition.Path // TypeDefIndex: 2079
{
	// Fields
	public const string directoryPath = "\\settings\\item\\";
	public const string amulet = "\\settings\\item\\amulet.txt";
	public const string armor = "\\settings\\item\\armor.txt";
	public const string belt = "\\settings\\item\\belt.txt";
	public const string boot = "\\settings\\item\\boot.txt";
	public const string cuff = "\\settings\\item\\cuff.txt";
	public const string helm = "\\settings\\item\\helm.txt";
	public const string horse = "\\settings\\item\\horse.txt";
	public const string meleeweapon = "\\settings\\item\\meleeweapon.txt";
	public const string pendant = "\\settings\\item\\pendant.txt";
	public const string rangeweapon = "\\settings\\item\\rangeweapon.txt";
	public const string ring = "\\settings\\item\\ring.txt";
	public const string armorres = "\\settings\\item\\armorres.txt";
	public const string helmres = "\\settings\\item\\helmres.txt";
	public const string horseres = "\\settings\\item\\horseres.txt";
	public const string meleeres = "\\settings\\item\\meleeres.txt";
	public const string rangeres = "\\settings\\item\\rangeres.txt";
	public const string magicattrib = "\\settings\\item\\magicattrib.txt";
	public const string goldEquip = "\\settings\\item\\goldequip.txt";
	public const string goldEquipRes = "\\settings\\item\\goldequipres.txt";
	public const string magicattrib_ge = "\\settings\\item\\magicattrib_ge.txt";
	public const string magicScript = "\\settings\\item\\magicscript.txt";
	public const string mask = "\\settings\\item\\mask.txt";

	// Methods

	// RVA: 0xF8A558 Offset: 0xF86558 VA: 0xF8A558
	public static List<string> EquipmentList() { }

	// RVA: 0xF8AA80 Offset: 0xF86A80 VA: 0xF8AA80
	public static List<Definition.Path.NormalResData> NormalResList() { }
}

// Namespace: 
public enum Definition.HeaderIndexer.EquipmentBase // TypeDefIndex: 2080
{
	// Fields
	public int value__; // 0x0
	public const Definition.HeaderIndexer.EquipmentBase name = 0;
	public const Definition.HeaderIndexer.EquipmentBase genre = 1;
	public const Definition.HeaderIndexer.EquipmentBase detail = 2;
	public const Definition.HeaderIndexer.EquipmentBase particular = 3;
	public const Definition.HeaderIndexer.EquipmentBase imagePath = 4;
	public const Definition.HeaderIndexer.EquipmentBase objIdx = 5;
	public const Definition.HeaderIndexer.EquipmentBase width = 6;
	public const Definition.HeaderIndexer.EquipmentBase height = 7;
	public const Definition.HeaderIndexer.EquipmentBase intro = 8;
	public const Definition.HeaderIndexer.EquipmentBase series = 9;
	public const Definition.HeaderIndexer.EquipmentBase price = 10;
	public const Definition.HeaderIndexer.EquipmentBase level = 11;
	public const Definition.HeaderIndexer.EquipmentBase stack = 12;
	public const Definition.HeaderIndexer.EquipmentBase propBasic0Type = 13;
	public const Definition.HeaderIndexer.EquipmentBase propBasic0Min = 14;
	public const Definition.HeaderIndexer.EquipmentBase propBasic0Max = 15;
	public const Definition.HeaderIndexer.EquipmentBase propBasic1Type = 16;
	public const Definition.HeaderIndexer.EquipmentBase propBasic1Min = 17;
	public const Definition.HeaderIndexer.EquipmentBase propBasic1Max = 18;
	public const Definition.HeaderIndexer.EquipmentBase propBasic2Type = 19;
	public const Definition.HeaderIndexer.EquipmentBase propBasic2Min = 20;
	public const Definition.HeaderIndexer.EquipmentBase propBasic2Max = 21;
	public const Definition.HeaderIndexer.EquipmentBase propBasic3Type = 22;
	public const Definition.HeaderIndexer.EquipmentBase propBasic3Min = 23;
	public const Definition.HeaderIndexer.EquipmentBase propBasic3Max = 24;
	public const Definition.HeaderIndexer.EquipmentBase propBasic4Type = 25;
	public const Definition.HeaderIndexer.EquipmentBase propBasic4Min = 26;
	public const Definition.HeaderIndexer.EquipmentBase propBasic4Max = 27;
	public const Definition.HeaderIndexer.EquipmentBase propBasic5Type = 28;
	public const Definition.HeaderIndexer.EquipmentBase propBasic5Min = 29;
	public const Definition.HeaderIndexer.EquipmentBase propBasic5Max = 30;
	public const Definition.HeaderIndexer.EquipmentBase propBasic6Type = 31;
	public const Definition.HeaderIndexer.EquipmentBase propBasic6Min = 32;
	public const Definition.HeaderIndexer.EquipmentBase propBasic6Max = 33;
	public const Definition.HeaderIndexer.EquipmentBase requirement0Type = 34;
	public const Definition.HeaderIndexer.EquipmentBase requirement0Para = 35;
	public const Definition.HeaderIndexer.EquipmentBase requirement1Type = 36;
	public const Definition.HeaderIndexer.EquipmentBase requirement1Para = 37;
	public const Definition.HeaderIndexer.EquipmentBase requirement2Type = 38;
	public const Definition.HeaderIndexer.EquipmentBase requirement2Para = 39;
	public const Definition.HeaderIndexer.EquipmentBase requirement3Type = 40;
	public const Definition.HeaderIndexer.EquipmentBase requirement3Para = 41;
	public const Definition.HeaderIndexer.EquipmentBase requirement4Type = 42;
	public const Definition.HeaderIndexer.EquipmentBase requirement4Para = 43;
	public const Definition.HeaderIndexer.EquipmentBase requirement5Type = 44;
	public const Definition.HeaderIndexer.EquipmentBase requirement5Para = 45;
}

// Namespace: 
public enum Definition.HeaderIndexer.GoldEquipBase // TypeDefIndex: 2081
{
	// Fields
	public int value__; // 0x0
	public const Definition.HeaderIndexer.GoldEquipBase magic0 = 46;
	public const Definition.HeaderIndexer.GoldEquipBase magic1 = 47;
	public const Definition.HeaderIndexer.GoldEquipBase magic2 = 48;
	public const Definition.HeaderIndexer.GoldEquipBase magic3 = 49;
	public const Definition.HeaderIndexer.GoldEquipBase magic4 = 50;
	public const Definition.HeaderIndexer.GoldEquipBase magic5 = 51;
	public const Definition.HeaderIndexer.GoldEquipBase idSet = 52;
}

// Namespace: 
public enum Definition.HeaderIndexer.GoldMagicBase // TypeDefIndex: 2082
{
	// Fields
	public int value__; // 0x0
	public const Definition.HeaderIndexer.GoldMagicBase name = 0;
	public const Definition.HeaderIndexer.GoldMagicBase prefix = 1;
	public const Definition.HeaderIndexer.GoldMagicBase series = 2;
	public const Definition.HeaderIndexer.GoldMagicBase faction = 3;
	public const Definition.HeaderIndexer.GoldMagicBase type = 4;
	public const Definition.HeaderIndexer.GoldMagicBase value1Min = 5;
	public const Definition.HeaderIndexer.GoldMagicBase value1Max = 6;
	public const Definition.HeaderIndexer.GoldMagicBase value2Min = 7;
	public const Definition.HeaderIndexer.GoldMagicBase value2Max = 8;
	public const Definition.HeaderIndexer.GoldMagicBase value3Min = 9;
	public const Definition.HeaderIndexer.GoldMagicBase value3Max = 10;
	public const Definition.HeaderIndexer.GoldMagicBase intro = 11;
}

// Namespace: 
public enum Definition.HeaderIndexer.MagicScriptBase // TypeDefIndex: 2083
{
	// Fields
	public int value__; // 0x0
	public const Definition.HeaderIndexer.MagicScriptBase name = 0;
	public const Definition.HeaderIndexer.MagicScriptBase particular = 1;
	public const Definition.HeaderIndexer.MagicScriptBase image = 2;
	public const Definition.HeaderIndexer.MagicScriptBase objectId = 3;
	public const Definition.HeaderIndexer.MagicScriptBase price = 4;
	public const Definition.HeaderIndexer.MagicScriptBase stack = 5;
	public const Definition.HeaderIndexer.MagicScriptBase getdesc = 6;
	public const Definition.HeaderIndexer.MagicScriptBase script = 7;
	public const Definition.HeaderIndexer.MagicScriptBase intro = 8;
}

// Namespace: 
public enum Definition.HeaderIndexer.MagicAttribBase // TypeDefIndex: 2084
{
	// Fields
	public int value__; // 0x0
	public const Definition.HeaderIndexer.MagicAttribBase name = 0;
	public const Definition.HeaderIndexer.MagicAttribBase pos = 1;
	public const Definition.HeaderIndexer.MagicAttribBase series = 2;
	public const Definition.HeaderIndexer.MagicAttribBase level = 3;
	public const Definition.HeaderIndexer.MagicAttribBase propKind = 4;
	public const Definition.HeaderIndexer.MagicAttribBase value0Min = 5;
	public const Definition.HeaderIndexer.MagicAttribBase value0Max = 6;
	public const Definition.HeaderIndexer.MagicAttribBase value1Min = 7;
	public const Definition.HeaderIndexer.MagicAttribBase value1Max = 8;
	public const Definition.HeaderIndexer.MagicAttribBase value2Min = 9;
	public const Definition.HeaderIndexer.MagicAttribBase value2Max = 10;
	public const Definition.HeaderIndexer.MagicAttribBase intro = 11;
	public const Definition.HeaderIndexer.MagicAttribBase dropRate0VuKhi = 12;
	public const Definition.HeaderIndexer.MagicAttribBase dropRate1AmKhi = 13;
	public const Definition.HeaderIndexer.MagicAttribBase dropRate2Ao = 14;
	public const Definition.HeaderIndexer.MagicAttribBase dropRate3Nhan = 15;
	public const Definition.HeaderIndexer.MagicAttribBase dropRate4DayChuyen = 16;
	public const Definition.HeaderIndexer.MagicAttribBase dropRate5Giay = 17;
	public const Definition.HeaderIndexer.MagicAttribBase dropRate6Dai = 18;
	public const Definition.HeaderIndexer.MagicAttribBase dropRate7Non = 19;
	public const Definition.HeaderIndexer.MagicAttribBase dropRate8BaoTay = 20;
	public const Definition.HeaderIndexer.MagicAttribBase dropRate9DayChuyen = 21;
	public const Definition.HeaderIndexer.MagicAttribBase dropRate10Ngua = 22;
}

// Namespace: 
public enum Definition.HeaderIndexer.GoldEquipRes // TypeDefIndex: 2085
{
	// Fields
	public int value__; // 0x0
	public const Definition.HeaderIndexer.GoldEquipRes equipRowIndex = 0;
	public const Definition.HeaderIndexer.GoldEquipRes resId = 1;
}

// Namespace: 
public enum Definition.HeaderIndexer.NormalEquipRes // TypeDefIndex: 2086
{
	// Fields
	public int value__; // 0x0
	public const Definition.HeaderIndexer.NormalEquipRes declarationLine = 0;
	public const Definition.HeaderIndexer.NormalEquipRes npcResLine = 1;
	public const Definition.HeaderIndexer.NormalEquipRes _count = 2;
}

// Namespace: 
public static class Definition.HeaderIndexer // TypeDefIndex: 2087
{}

// Namespace: game.item
public class Definition // TypeDefIndex: 2088
{
	// Methods

	// RVA: 0xF8A550 Offset: 0xF86550 VA: 0xF8A550
	public void .ctor() { }
}

// Namespace: game.item
public class ItemBasic : ItemDatabase // TypeDefIndex: 2089
{
	// Methods

	// RVA: 0xF8AE74 Offset: 0xF86E74 VA: 0xF8AE74
	public int GetItemType() { }

	// RVA: 0xF8AE7C Offset: 0xF86E7C VA: 0xF8AE7C
	public int GetRowIndex() { }

	// RVA: 0xF8AED0 Offset: 0xF86ED0 VA: 0xF8AED0
	public int GetGenre() { }

	// RVA: 0xF8AED8 Offset: 0xF86ED8 VA: 0xF8AED8
	public int GetDetail() { }

	// RVA: 0xF8AEE0 Offset: 0xF86EE0 VA: 0xF8AEE0
	public int GetParticular() { }

	// RVA: 0xF8AEE8 Offset: 0xF86EE8 VA: 0xF8AEE8
	public int GetLevel() { }

	// RVA: 0xF8AEF0 Offset: 0xF86EF0 VA: 0xF8AEF0
	public int GetSeries() { }

	// RVA: 0xF8AEF8 Offset: 0xF86EF8 VA: 0xF8AEF8
	public string GetName() { }

	// RVA: 0xF8AF5C Offset: 0xF86F5C VA: 0xF8AF5C
	public int GetPrice() { }

	// RVA: 0xF8AFBC Offset: 0xF86FBC VA: 0xF8AFBC
	public EquipBase GetNormalEquip() { }

	// RVA: 0xF8AFD8 Offset: 0xF86FD8 VA: 0xF8AFD8
	public GoldEquipBase GetGoldEquip() { }

	// RVA: 0xF8AFE0 Offset: 0xF86FE0 VA: 0xF8AFE0
	public MagicScriptBase GetMagicScript() { }

	// RVA: 0xF8AFE8 Offset: 0xF86FE8 VA: 0xF8AFE8
	public bool IsEquipment() { }

	// RVA: 0xF8B030 Offset: 0xF87030 VA: 0xF8B030
	public int GetItemEquipPlace() { }

	// RVA: 0xF8B038 Offset: 0xF87038 VA: 0xF8B038
	public void SetItemLocation(int equip) { }

	// RVA: 0xF8B040 Offset: 0xF87040 VA: 0xF8B040
	public int GetItemLocation() { }

	// RVA: 0xF8B048 Offset: 0xF87048 VA: 0xF8B048
	public void AddStack(int count = 1) { }

	// RVA: 0xF8B058 Offset: 0xF87058 VA: 0xF8B058
	public void SetStack(int count) { }

	// RVA: 0xF8B060 Offset: 0xF87060 VA: 0xF8B060
	public void SetEquipPlace(int equipPlace) { }

	// RVA: 0xF8B068 Offset: 0xF87068 VA: 0xF8B068
	public string GetSourceCid() { }

	// RVA: 0xF8B070 Offset: 0xF87070 VA: 0xF8B070
	public string GetSourceName() { }

	// RVA: 0xF8B078 Offset: 0xF87078 VA: 0xF8B078
	public long GetScriptParamLongValue() { }

	// RVA: 0xF8B080 Offset: 0xF87080 VA: 0xF8B080
	public void SetScriptParamLongValue(long value) { }

	// RVA: 0xF8B088 Offset: 0xF87088 VA: 0xF8B088
	public bool IsSameGdp(Item other) { }

	// RVA: 0xF8B0D0 Offset: 0xF870D0 VA: 0xF8B0D0
	public bool IsSameGdp(int g, int d, int p) { }

	// RVA: 0xF8B100 Offset: 0xF87100 VA: 0xF8B100
	public bool IsSameGdpls(Item other) { }

	// RVA: 0xF8B154 Offset: 0xF87154 VA: 0xF8B154
	public bool IsSameGdpls(int g, int d, int p, int l, int s) { }

	// RVA: 0xF8B19C Offset: 0xF8719C VA: 0xF8B19C
	public int GetDurabilityCurrently() { }

	// RVA: 0xF8B1A4 Offset: 0xF871A4 VA: 0xF8B1A4
	public void SetDurability(int value) { }

	// RVA: 0xF8B1AC Offset: 0xF871AC VA: 0xF8B1AC
	public int GetDurabilityMaximum() { }

	// RVA: 0xF8B1EC Offset: 0xF871EC VA: 0xF8B1EC
	public void .ctor() { }
}

// Namespace: game.item
public class ItemDatabase : ItemDatafield // TypeDefIndex: 2090
{
	// Methods

	// RVA: 0xF8B1F4 Offset: 0xF871F4 VA: 0xF8B1F4
	public int GetIndex() { }

	// RVA: 0xF8B1FC Offset: 0xF871FC VA: 0xF8B1FC
	public void SetIndex(int index) { }

	// RVA: 0xF8B204 Offset: 0xF87204 VA: 0xF8B204
	protected void SetAppItem(Item appItem) { }

	// RVA: 0xF8C09C Offset: 0xF8809C VA: 0xF8C09C
	public Item GetAppItem() { }

	// RVA: 0xF8B1F0 Offset: 0xF871F0 VA: 0xF8B1F0
	public void .ctor() { }
}

// Namespace: game.item
[NullableContext(1)]
[Nullable(0)]
public class ItemDescription : ItemImage // TypeDefIndex: 2091
{
	// Fields
	[Nullable(2)]
	private string intro; // 0xA0
	[Nullable(2)]
	private string basicDesc; // 0xA8
	[Nullable(new[] { 2, 1 })]
	private List<string> magicDesc; // 0xB0

	// Methods

	// RVA: 0xF8C640 Offset: 0xF88640 VA: 0xF8C640
	public static string GetRichText(string origin) { }

	// RVA: 0xF8C6E8 Offset: 0xF886E8 VA: 0xF8C6E8
	public string GetBasicDesc() { }

	// RVA: 0xF8C984 Offset: 0xF88984 VA: 0xF8C984
	public List<string> GetMagicDesc() { }

	// RVA: 0xF8CC38 Offset: 0xF88C38 VA: 0xF8CC38
	public string GetIntro() { }

	// RVA: 0xF8CCCC Offset: 0xF88CCC VA: 0xF8CCCC
	public void .ctor() { }
}

// Namespace: game.item
public class ItemMagic : ItemBasic // TypeDefIndex: 2092
{
	// Methods

	// RVA: 0xF8CD24 Offset: 0xF88D24 VA: 0xF8CD24
	public List<Attrib> GetMagicAttrib() { }

	// RVA: 0xF8C8E8 Offset: 0xF888E8 VA: 0xF8C8E8
	public List<Attrib> GetBasicAttrib() { }

	// RVA: 0xF8CD2C Offset: 0xF88D2C VA: 0xF8CD2C
	public List<Attrib> GetRequiredAttrib() { }

	// RVA: 0xF8CDC8 Offset: 0xF88DC8 VA: 0xF8CDC8
	public void .ctor() { }
}

// Namespace: game.item
public class ItemTimeUse : ItemDescription // TypeDefIndex: 2093
{
	// Fields
	private static readonly Dictionary<int, string> SecondsHumanPart; // 0x0

	// Methods

	// RVA: 0xF8CDCC Offset: 0xF88DCC VA: 0xF8CDCC
	public int GetStackCurrently() { }

	// RVA: 0xF8CDD4 Offset: 0xF88DD4 VA: 0xF8CDD4
	public int GetStackMaximun() { }

	// RVA: 0xF8CE00 Offset: 0xF88E00 VA: 0xF8CE00
	public bool CanStackWithOtherItem(Item other, int amount = 1) { }

	// RVA: 0xF8CF14 Offset: 0xF88F14 VA: 0xF8CF14
	public void SetExpirationToTimestampSeconds(long timestamp) { }

	// RVA: 0xF8CF1C Offset: 0xF88F1C VA: 0xF8CF1C
	public long GetExpirationToTimestampSeconds() { }

	// RVA: 0xF8CF24 Offset: 0xF88F24 VA: 0xF8CF24
	public static string GetLeftSecondsHuman(long toTimestamp) { }

	// RVA: 0xF8D1A0 Offset: 0xF891A0 VA: 0xF8D1A0
	public void SetLockstate(int lockstate) { }

	// RVA: 0xF8D1A8 Offset: 0xF891A8 VA: 0xF8D1A8
	public void SetLockToTimestampSeconds(long timestamp) { }

	// RVA: 0xF8D1B0 Offset: 0xF891B0 VA: 0xF8D1B0
	public int GetLockstate() { }

	// RVA: 0xF8D1B8 Offset: 0xF891B8 VA: 0xF8D1B8
	public long GetLockToTimestampSeconds() { }

	// RVA: 0xF8D1C0 Offset: 0xF891C0 VA: 0xF8D1C0
	public long GetCreateTimestampSeconds() { }

	// RVA: 0xF8D1C8 Offset: 0xF891C8 VA: 0xF8D1C8
	public void .ctor() { }

	// RVA: 0xF8D1CC Offset: 0xF891CC VA: 0xF8D1CC
	private static void .cctor() { }
}

// Namespace: game.item
[NullableContext(1)]
[Nullable(0)]
public class ItemDatafield // TypeDefIndex: 2094
{
	// Fields
	[Nullable(2)]
	protected Item self; // 0x10
	protected int type; // 0x18
	protected EquipBase normalequip; // 0x20
	protected GoldEquipBase goldequip; // 0x28
	protected MagicScriptBase magicscript; // 0x30
	protected List<Attrib> magicAttrib; // 0x38
	protected int index; // 0x40
	protected int genre; // 0x44
	protected int detail; // 0x48
	protected int particular; // 0x4C
	protected int level; // 0x50
	protected int series; // 0x54
	protected int stack; // 0x58
	protected int durability; // 0x5C
	protected int location; // 0x60
	protected int equipPlace; // 0x64
	protected long expirationToTimestampSeconds; // 0x68
	protected int lockstate; // 0x70
	protected long lockToTimestampSeconds; // 0x78
	protected string sourceCid; // 0x80
	protected string sourceName; // 0x88
	protected long createTimestampSeconds; // 0x90
	protected long scriptParamLongValue; // 0x98

	// Methods

	// RVA: 0xF8C4C0 Offset: 0xF884C0 VA: 0xF8C4C0
	public void .ctor() { }
}

// Namespace: game.item
public class ItemGenerate : ItemServerSetters // TypeDefIndex: 2095
{
	// Methods

	// RVA: 0xF8D32C Offset: 0xF8932C VA: 0xF8D32C
	public void GenerateBlueItem(int genre, int detail, int particular, int level, int series, int luckyPercent, int limitMagicLevel) { }

	// RVA: 0xF8D3D8 Offset: 0xF893D8 VA: 0xF8D3D8
	public void GenerateMagicScript(int particular) { }

	// RVA: 0xF8D450 Offset: 0xF89450 VA: 0xF8D450
	public void GenerateGoldItem(int index) { }

	// RVA: 0xF8D7F4 Offset: 0xF897F4 VA: 0xF8D7F4
	public void .ctor() { }
}

// Namespace: game.item
public class ItemServerSetters : ItemTimeUse // TypeDefIndex: 2096
{
	// Methods

	// RVA: 0xF8D7F8 Offset: 0xF897F8 VA: 0xF8D7F8
	public void .ctor() { }
}

// Namespace: 
[Nullable(0)]
public class Suite.Element // TypeDefIndex: 2097
{
	// Fields
	private readonly Suite suite; // 0x10
	[Nullable(2)]
	public Item item; // 0x18
	public int previousVisibleMagic; // 0x20
	public int currentVisibleMagic; // 0x24
	public int previousHiddenMagic; // 0x28
	public int currentHiddenMagic; // 0x2C

	// Methods

	// RVA: 0xF8EC90 Offset: 0xF8AC90 VA: 0xF8EC90
	public void .ctor(Suite suite) { }

	// RVA: 0xF914BC Offset: 0xF8D4BC VA: 0xF914BC
	public Dictionary<string, Attrib> GetActivatedMagicMapping() { }

	// RVA: 0xF9186C Offset: 0xF8D86C VA: 0xF9186C
	public List<Attrib> GetActivatedMagicList() { }
}

// Namespace: 
[Nullable(0)]
public class Suite.DataUpdate // TypeDefIndex: 2098
{
	// Fields
	public List<Attrib> magicsActive; // 0x10
	public List<Attrib> magicsRemove; // 0x18
	public Dictionary<int, Item> changedList; // 0x20
	public static readonly Suite.DataUpdate Empty; // 0x0

	// Methods

	// RVA: 0xF90494 Offset: 0xF8C494 VA: 0xF90494
	public void AppendMagics(Suite.DataUpdate orther) { }

	// RVA: 0xF8F9AC Offset: 0xF8B9AC VA: 0xF8F9AC
	public void .ctor() { }

	// RVA: 0xF91BC8 Offset: 0xF8DBC8 VA: 0xF91BC8
	private static void .cctor() { }
}

// Namespace: game.item
[NullableContext(1)]
[Nullable(0)]
public class Suite // TypeDefIndex: 2099
{
	// Fields
	private readonly Suite.Element mainPerson; // 0x10
	private readonly Suite.Element weapon; // 0x18
	private readonly Suite.Element armor; // 0x20
	private readonly Suite.Element ring1; // 0x28
	private readonly Suite.Element ring2; // 0x30
	private readonly Suite.Element amulet; // 0x38
	private readonly Suite.Element boots; // 0x40
	private readonly Suite.Element belt; // 0x48
	private readonly Suite.Element helm; // 0x50
	private readonly Suite.Element cuff; // 0x58
	private readonly Suite.Element pendant; // 0x60
	private readonly Suite.Element horse; // 0x68
	private readonly Suite.Element mask; // 0x70
	private readonly Dictionary<int, Suite.Element> items; // 0x78
	private readonly Dictionary<int, Suite.Element[]> detailRequired; // 0x80
	private readonly Dictionary<int, Suite.Element[]> detailActivate; // 0x88
	private readonly Dictionary<int, int> seriesRequired; // 0x90
	private int goldSetHiddenMagic; // 0x98

	// Methods

	// RVA: 0xF8D84C Offset: 0xF8984C VA: 0xF8D84C
	public void .ctor() { }

	// RVA: 0xF8ECC0 Offset: 0xF8ACC0 VA: 0xF8ECC0
	public void SetMainPersonSeries(int mainPersonSeries) { }

	// RVA: 0xF8ED6C Offset: 0xF8AD6C VA: 0xF8ED6C
	public void Clear() { }

	// RVA: 0xF8EEC4 Offset: 0xF8AEC4 VA: 0xF8EEC4
	public Dictionary<int, Suite.Element> GetItemList() { }

	[NullableContext(2)]
	// RVA: 0xF8EECC Offset: 0xF8AECC VA: 0xF8EECC
	public Suite.Element GetPlace(int place) { }

	// RVA: 0xF8EF44 Offset: 0xF8AF44 VA: 0xF8EF44
	public bool IsPlaceEquipped(int place) { }

	// RVA: 0xF8EFD0 Offset: 0xF8AFD0 VA: 0xF8EFD0
	public bool AnyGoldItemMappingEquipped(Dictionary<int, bool> goldindexShared) { }

	// RVA: 0xF8F178 Offset: 0xF8B178 VA: 0xF8F178
	public bool GoldIndexItemHasEquipped(int goldindex) { }

	// RVA: 0xF8F2F4 Offset: 0xF8B2F4 VA: 0xF8F2F4
	private Suite.DataUpdate UpdateMagic() { }

	// RVA: 0xF8FAAC Offset: 0xF8BAAC VA: 0xF8FAAC
	public Suite.DataUpdate Use(Item item, int place) { }

	// RVA: 0xF909C8 Offset: 0xF8C9C8 VA: 0xF909C8
	public Suite.DataUpdate Use(Item item) { }

	// RVA: 0xF90D54 Offset: 0xF8CD54 VA: 0xF90D54
	private bool IsGoldSetCompleted() { }

	// RVA: 0xF8FF28 Offset: 0xF8BF28 VA: 0xF8FF28
	public Suite.DataUpdate Remove(int itemindex) { }

	// RVA: 0xF91334 Offset: 0xF8D334 VA: 0xF91334
	public int GetHiddenMagicActiveCount(int itemindex) { }

	// RVA: 0xF914A8 Offset: 0xF8D4A8 VA: 0xF914A8
	public int GetHiddenMagicActiveCount(Item item) { }
}

// Namespace: 
public class GoldEquip.SetElementInfo // TypeDefIndex: 2100
{
	// Fields
	public readonly Dictionary<int, bool> goldindexShared; // 0x10
	public readonly string name; // 0x18

	// Methods

	// RVA: 0xF91C2C Offset: 0xF8DC2C VA: 0xF91C2C
	public void .ctor(string name, int sharedGoldIndex) { }
}
