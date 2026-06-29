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

// Namespace: game.objects
public static class Cache // TypeDefIndex: 2037
{
	// Fields
	public static Table table; // 0x0
	public static Dictionary<int, int> dataIdToRowIndex; // 0x8

	// Methods

	// RVA: 0xF819A0 Offset: 0xF7D9A0 VA: 0xF819A0
	public static bool Initialize(Action<string> logfunc) { }

	// RVA: 0xF81B9C Offset: 0xF7DB9C VA: 0xF81B9C
	private static void .cctor() { }
}

// Namespace: game.objects
public class Texture : Active // TypeDefIndex: 2038
{
	// Methods

	// RVA: 0xF81C70 Offset: 0xF7DC70 VA: 0xF81C70
	public void .ctor() { }

	// RVA: 0xF81C94 Offset: 0xF7DC94 VA: 0xF81C94
	public void Initialize() { }

	// RVA: 0xF81E54 Offset: 0xF7DE54 VA: 0xF81E54
	public void Release() { }

	// RVA: 0xF81FE0 Offset: 0xF7DFE0 VA: 0xF81FE0
	public void SetBreathing(bool isBreathing) { }

	// RVA: 0xF81FE8 Offset: 0xF7DFE8 VA: 0xF81FE8
	public void SetVisibled(bool isVisibled) { }
}

// Namespace: 
public static class Definition.Type // TypeDefIndex: 2039
{
	// Fields
	public const int unidentified = 0;
	public const int mapDefault = 1;
	public const int money = 2;
	public const int magicscript = 3;
	public const int meleeweapon = 4;
	public const int rangeweapon = 5;
	public const int armor = 6;
	public const int ring = 7;
	public const int amulet = 8;
	public const int boots = 9;
	public const int belt = 10;
	public const int helm = 11;
	public const int cuff = 12;
	public const int pendant = 13;
	public const int potion = 14;
}

// Namespace: 
public static class Definition.Kind // TypeDefIndex: 2040
{
	// Fields
	public const string Prop = "Prop";
	public const string Box = "Box";
	public const string Item = "Item";
	public const string Body = "Body";
	public const string Money = "Money";
	public const string RandSound = "RandSound";
	public const string LoopSound = "LoopSound";
	public const string Obstacle = "Obstacle";
}

// Namespace: 
public enum Definition.HeaderIndexer // TypeDefIndex: 2041
{
	// Fields
	public int value__; // 0x0
	public const Definition.HeaderIndexer Name = 0;
	public const Definition.HeaderIndexer DataID = 1;
	public const Definition.HeaderIndexer Kind = 2;
	public const Definition.HeaderIndexer ScriptName = 3;
	public const Definition.HeaderIndexer ImageName = 4;
	public const Definition.HeaderIndexer SoundName = 5;
	public const Definition.HeaderIndexer LifeTime = 6;
	public const Definition.HeaderIndexer Layer = 7;
	public const Definition.HeaderIndexer Height = 8;
	public const Definition.HeaderIndexer SkillKind = 9;
	public const Definition.HeaderIndexer SkillCamp = 10;
	public const Definition.HeaderIndexer SkillRange = 11;
	public const Definition.HeaderIndexer SkillCastTime = 12;
	public const Definition.HeaderIndexer SkillID = 13;
	public const Definition.HeaderIndexer SkillLevel = 14;
	public const Definition.HeaderIndexer LightRadius = 15;
	public const Definition.HeaderIndexer LightRed = 16;
	public const Definition.HeaderIndexer LightGreen = 17;
	public const Definition.HeaderIndexer LightBlue = 18;
	public const Definition.HeaderIndexer LightAlpha = 19;
	public const Definition.HeaderIndexer LightReflectType = 20;
	public const Definition.HeaderIndexer ImageTotalFrame = 21;
	public const Definition.HeaderIndexer ImageCurFrame = 22;
	public const Definition.HeaderIndexer ImageTotalDir = 23;
	public const Definition.HeaderIndexer ImageCurDir = 24;
	public const Definition.HeaderIndexer ImageInterval = 25;
	public const Definition.HeaderIndexer ImageCgXpos = 26;
	public const Definition.HeaderIndexer ImageCgYpos = 27;
	public const Definition.HeaderIndexer Bar0 = 28;
	public const Definition.HeaderIndexer Bar1 = 29;
	public const Definition.HeaderIndexer Bar2 = 30;
	public const Definition.HeaderIndexer Bar3 = 31;
	public const Definition.HeaderIndexer Bar4 = 32;
	public const Definition.HeaderIndexer Bar5 = 33;
	public const Definition.HeaderIndexer Bar6 = 34;
	public const Definition.HeaderIndexer Bar7 = 35;
	public const Definition.HeaderIndexer Bar8 = 36;
	public const Definition.HeaderIndexer Bar9 = 37;
	public const Definition.HeaderIndexer Bar10 = 38;
	public const Definition.HeaderIndexer Bar11 = 39;
	public const Definition.HeaderIndexer Bar12 = 40;
	public const Definition.HeaderIndexer Bar13 = 41;
	public const Definition.HeaderIndexer Bar14 = 42;
	public const Definition.HeaderIndexer ImageDropName = 43;
	public const Definition.HeaderIndexer ImageDropTotalFrame = 44;
	public const Definition.HeaderIndexer ImageDropCurFrame = 45;
	public const Definition.HeaderIndexer ImageDropTotalDir = 46;
	public const Definition.HeaderIndexer ImageDropCurDir = 47;
	public const Definition.HeaderIndexer ImageDropInterval = 48;
	public const Definition.HeaderIndexer ImageDropCgXpos = 49;
	public const Definition.HeaderIndexer ImageDropCgYpos = 50;
	public const Definition.HeaderIndexer IsUnseen = 51;
	public const Definition.HeaderIndexer ObstacleKind = 52;
	public const Definition.HeaderIndexer LoopAnimation = 53;
}

// Namespace: game.objects
public class Definition // TypeDefIndex: 2042
{
	// Methods

	// RVA: 0xF82014 Offset: 0xF7E014 VA: 0xF82014
	public void .ctor() { }
}

// Namespace: game.objects
public class ObjectBase // TypeDefIndex: 2043
{
	// Fields
	public string Name; // 0x10
	public int DataID; // 0x18
	public string Kind; // 0x20
	public string ScriptName; // 0x28
	public string ImageName; // 0x30
	public string SoundName; // 0x38
	public int LifeTime; // 0x40
	public int Layer; // 0x44
	public int Height; // 0x48
	public string SkillKind; // 0x50
	public int SkillCamp; // 0x58
	public int SkillRange; // 0x5C
	public int SkillCastTime; // 0x60
	public int SkillID; // 0x64
	public int SkillLevel; // 0x68
	public int LightRadius; // 0x6C
	public int LightRed; // 0x70
	public int LightGreen; // 0x74
	public int LightBlue; // 0x78
	public int LightAlpha; // 0x7C
	public int LightReflectType; // 0x80
	public int ImageTotalFrame; // 0x84
	public int ImageCurFrame; // 0x88
	public int ImageTotalDir; // 0x8C
	public int ImageCurDir; // 0x90
	public int ImageInterval; // 0x94
	public int ImageCgXpos; // 0x98
	public int ImageCgYpos; // 0x9C
	public int Bar0; // 0xA0
	public int Bar1; // 0xA4
	public int Bar2; // 0xA8
	public int Bar3; // 0xAC
	public int Bar4; // 0xB0
	public int Bar5; // 0xB4
	public int Bar6; // 0xB8
	public int Bar7; // 0xBC
	public int Bar8; // 0xC0
	public int Bar9; // 0xC4
	public int Bar10; // 0xC8
	public int Bar11; // 0xCC
	public int Bar12; // 0xD0
	public int Bar13; // 0xD4
	public int Bar14; // 0xD8
	public string ImageDropName; // 0xE0
	public int ImageDropTotalFrame; // 0xE8
	public int ImageDropCurFrame; // 0xEC
	public int ImageDropTotalDir; // 0xF0
	public int ImageDropCurDir; // 0xF4
	public int ImageDropInterval; // 0xF8
	public int ImageDropCgXpos; // 0xFC
	public int ImageDropCgYpos; // 0x100
	public int IsUnseen; // 0x104
	public int ObstacleKind; // 0x108
	public int LoopAnimation; // 0x10C

	// Methods

	// RVA: 0xF80D34 Offset: 0xF7CD34 VA: 0xF80D34
	public void Initialize(int dataId) { }

	// RVA: 0xF8201C Offset: 0xF7E01C VA: 0xF8201C
	public void .ctor() { }
}

// Namespace: game.objects
public class ObjectDataField : ObjectBase // TypeDefIndex: 2044
{
	// Fields
	protected string guid; // 0x110
	public readonly Texture texture; // 0x118
	public Attachment attachment; // 0x120
	public Package package; // 0x128
	public int type; // 0x130
	protected int remainingLifeFrame; // 0x134
	protected int remainingDropFrame; // 0x138
	protected int remainingOwnerFrame; // 0x13C
	public int mapId; // 0x140
	public readonly Position mapPos; // 0x148
	public int direction; // 0x150
	protected int currentLifeFrame; // 0x154
	protected string name; // 0x158
	protected int nameColor; // 0x160

	// Methods

	// RVA: 0xF80C48 Offset: 0xF7CC48 VA: 0xF80C48
	public void .ctor() { }
}

// Namespace: game.objects
public class Attachment // TypeDefIndex: 2045
{
	// Methods

	// RVA: 0xF820E8 Offset: 0xF7E0E8 VA: 0xF820E8
	public void .ctor() { }
}

// Namespace: game.objects
public class Package // TypeDefIndex: 2046
{
	// Methods

	// RVA: 0xF820F0 Offset: 0xF7E0F0 VA: 0xF820F0
	public void .ctor() { }
}
