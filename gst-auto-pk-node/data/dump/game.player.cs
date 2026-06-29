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

// Namespace: game.player
public static class Chat // TypeDefIndex: 2531
{
	// Fields
	public static readonly Dictionary<int, string> channelIcon; // 0x0
	public static readonly Dictionary<int, string> channelIconResource; // 0x8
	public static readonly Dictionary<int, string> channelField; // 0x10
	public static readonly Dictionary<int, string> channelFieldResource; // 0x18
	public const string font = "fmf";
	public const string materialName = "fmmn";
	public static readonly Dictionary<int, string> channelMaterial; // 0x20
	public static readonly Dictionary<Chat.ItemData.Color, string> itemMaterial; // 0x28
	public static readonly Dictionary<string, string> emoji2pic; // 0x30
	public static readonly Dictionary<string, string> pic2emoji; // 0x38
	public static readonly Dictionary<int, List<string>> channelTextRemove; // 0x40
	public static readonly Chat.ItemData item; // 0x48
	public static readonly Chat.PrivateData privat; // 0x50

	// Methods

	// RVA: 0xFEA8B8 Offset: 0xFE68B8 VA: 0xFEA8B8
	public static string[] GetSendData(string message) { }

	// RVA: 0xFEAAE8 Offset: 0xFE6AE8 VA: 0xFEAAE8
	public static void SendToServer(int channel, string message) { }

	// RVA: 0xFEB4A0 Offset: 0xFE74A0 VA: 0xFEB4A0
	public static string GetItemName(Item item, int itemType, bool withMaterial) { }

	// RVA: 0xFEB3FC Offset: 0xFE73FC VA: 0xFEB3FC
	public static void ClearItem() { }

	// RVA: 0xFEB6F0 Offset: 0xFE76F0 VA: 0xFEB6F0
	public static void ClearPrivate() { }

	// RVA: 0xFEB774 Offset: 0xFE7774 VA: 0xFEB774
	public static string SetItem(Item item, string checkexisting, string autoreply) { }

	// RVA: 0xFEBA24 Offset: 0xFE7A24 VA: 0xFEBA24
	public static void SetPrivate(string receiveName, string receiveCid) { }

	// RVA: 0xFEBAB8 Offset: 0xFE7AB8 VA: 0xFEBAB8
	public static bool IsPrivateChat() { }

	// RVA: 0xFEBB2C Offset: 0xFE7B2C VA: 0xFEBB2C
	public static string ConvertCurrentSimpleToEmbedText(string simple) { }

	// RVA: 0xFEBBE8 Offset: 0xFE7BE8 VA: 0xFEBBE8
	public static string GetOutputText(string message, ChatMessage chat) { }

	// RVA: 0xFEBFA8 Offset: 0xFE7FA8 VA: 0xFEBFA8
	public static string GetValidInputSize(string message) { }

	// RVA: 0xFEC16C Offset: 0xFE816C VA: 0xFEC16C
	public static string GetValidInputText(int channel, string message) { }

	// RVA: 0xFEC428 Offset: 0xFE8428 VA: 0xFEC428
	public static string GetAllEmojiSprite() { }

	// RVA: 0xFEC710 Offset: 0xFE8710 VA: 0xFEC710
	public static string GetPic(int picid) { }

	// RVA: 0xFEC7FC Offset: 0xFE87FC VA: 0xFEC7FC
	public static string GetTextMeshPro(int channel, int size, string text) { }

	// RVA: 0xFEC9F4 Offset: 0xFE89F4 VA: 0xFEC9F4
	public static string ToTextMeshPro(int channel, string senderName, string message) { }

	// RVA: 0xFEC690 Offset: 0xFE8690 VA: 0xFEC690
	public static string ToTextMeshPro(ChatMessage message) { }

	// RVA: 0xFECF58 Offset: 0xFE8F58 VA: 0xFECF58
	private static void .cctor() { }
}

// Namespace: 
private class Skill.AddSkillDamage // TypeDefIndex: 2532
{
	// Fields
	public Dictionary<int, int> send; // 0x10
	public int receive; // 0x18

	// Methods

	// RVA: 0xE63D50 Offset: 0xE5FD50 VA: 0xE63D50
	public void .ctor() { }
}

// Namespace: game.player
public static class Skill // TypeDefIndex: 2533
{
	// Fields
	private static readonly Dictionary<string, bool> magicType; // 0x0
	private static readonly Dictionary<int, Skill.AddSkillDamage> addSkillDamage; // 0x8

	// Methods

	// RVA: 0xE635E8 Offset: 0xE5F5E8 VA: 0xE635E8
	public static void RemoveSkillAddDamage(int skillid) { }

	// RVA: 0xE63678 Offset: 0xE5F678 VA: 0xE63678
	public static void CheckAddSkillDamage(Skill skill) { }

	// RVA: 0xE63DD8 Offset: 0xE5FDD8 VA: 0xE63DD8
	public static int GetAddSkillDamage(int skillId) { }

	// RVA: 0xE63E84 Offset: 0xE5FE84 VA: 0xE63E84
	private static void .cctor() { }
}

// Namespace: 
public static class Package.AddMapPlayerIndexer // TypeDefIndex: 2534
{
	// Fields
	public const int HEADER = 0;
	public const int Cid = 1;
	public const int Name = 2;
	public const int Sex = 3;
	public const int Sect = 4;
	public const int TongIdentify = 5;
	public const int Series = 6;
	public const int TeamId = 7;
	public const int Level = 8;
	public const int MaxLife = 9;
	public const int MaxInner = 10;
	public const int FightMode = 11;
	public const int ArmorRes = 12;
	public const int WeaponRes = 13;
	public const int HelmRes = 14;
	public const int HorseRes = 15;
	public const int MapX = 16;
	public const int MapY = 17;
	public const int CurLife = 18;
	public const int CurInner = 19;
	public const int PkStatus = 20;
	public const int Pkvalue = 21;
	public const int TongIndex = 22;
	public const int CampCurrently = 23;
	public const int RunSpeed = 24;
	public const int Action = 25;
	public const int Direction = 26;
	public const int AttackSpeed = 27;
	public const int CastSpeed = 28;
	public const int StateStature = 29;
	public const int TitleCurrently = 30;
	public const int _COUNT = 31;
}

// Namespace: game.player
public class Package // TypeDefIndex: 2535
{
	// Fields
	public const byte separatorByte = 124;

	// Methods

	// RVA: 0xE64090 Offset: 0xE60090 VA: 0xE64090
	public static void ParseVoid(ReadOnlySpan<byte> inData, out ReadOnlySpan<byte> outData) { }

	// RVA: 0xE64150 Offset: 0xE60150 VA: 0xE64150
	public static int ParseInt(ReadOnlySpan<byte> inData, out ReadOnlySpan<byte> outData) { }

	// RVA: 0xE642F4 Offset: 0xE602F4 VA: 0xE642F4
	public static long ParseLong(ReadOnlySpan<byte> inData, out ReadOnlySpan<byte> outData) { }

	// RVA: 0xE6449C Offset: 0xE6049C VA: 0xE6449C
	public static string ParseString(ReadOnlySpan<byte> inData, out ReadOnlySpan<byte> outData) { }

	// RVA: 0xE64604 Offset: 0xE60604 VA: 0xE64604
	public void .ctor() { }
}

// Namespace: 
private class ActivitiesListPc.FieldTemplate // TypeDefIndex: 2536
{
	// Fields
	public GameObject go; // 0x10
	public Image imageCurrently; // 0x18
	public TextMeshProUGUI tmproCurrentlyTime; // 0x20
	public TextMeshProUGUI tmproDataTitle; // 0x28
	public TextMeshProUGUI tmproDataDesc; // 0x30
	public int triggerTime; // 0x38

	// Methods

	// RVA: 0xE6477C Offset: 0xE6077C VA: 0xE6477C
	public void .ctor(GameObject go) { }

	// RVA: 0xE65AE4 Offset: 0xE61AE4 VA: 0xE65AE4
	public ActivitiesListPc.FieldTemplate Clone() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ActivitiesListPc.<>c // TypeDefIndex: 2537
{
	// Fields
	public static readonly ActivitiesListPc.<>c <>9; // 0x0
	public static Comparison<ActivitiesListField> <>9__11_0; // 0x8
	public static Comparison<ActivitiesListPc.FieldTemplate> <>9__11_1; // 0x10

	// Methods

	// RVA: 0xE65DC0 Offset: 0xE61DC0 VA: 0xE65DC0
	private static void .cctor() { }

	// RVA: 0xE65E28 Offset: 0xE61E28 VA: 0xE65E28
	public void .ctor() { }

	// RVA: 0xE65E30 Offset: 0xE61E30 VA: 0xE65E30
	internal int <SetData>b__11_0(ActivitiesListField a, ActivitiesListField b) { }

	// RVA: 0xE65E64 Offset: 0xE61E64 VA: 0xE65E64
	internal int <SetData>b__11_1(ActivitiesListPc.FieldTemplate a, ActivitiesListPc.FieldTemplate b) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class ActivitiesListPc.<>c__DisplayClass12_0 // TypeDefIndex: 2538
{
	// Fields
	public ActivitiesListPc <>4__this; // 0x10
	public ActivitiesListData data; // 0x18

	// Methods

	// RVA: 0xE65C7C Offset: 0xE61C7C VA: 0xE65C7C
	public void .ctor() { }

	// RVA: 0xE65E8C Offset: 0xE61E8C VA: 0xE65E8C
	internal void <Open>b__0() { }
}
