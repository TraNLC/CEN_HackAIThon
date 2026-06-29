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

// Namespace: game.item.cache
public static class GoldEquip // TypeDefIndex: 2101
{
	// Fields
	private static readonly Dictionary<int, GoldEquipBase> storage; // 0x0
	private static readonly Dictionary<ushort, List<ushort>> goldSetAllItem; // 0x8
	private static readonly Dictionary<ushort, List<GoldEquip.SetElementInfo>> goldSetElement; // 0x10

	// Methods

	// RVA: 0xF8BF04 Offset: 0xF87F04 VA: 0xF8BF04
	public static GoldEquipBase Get(int index) { }

	// RVA: 0xF90504 Offset: 0xF8C504 VA: 0xF90504
	public static List<GoldEquip.SetElementInfo> GetSetItemList(ushort idSet) { }

	// RVA: 0xF91D08 Offset: 0xF8DD08 VA: 0xF91D08
	public static bool Initialize(Action<string> logfunc) { }

	// RVA: 0xF9326C Offset: 0xF8F26C VA: 0xF9326C
	private static void .cctor() { }
}

// Namespace: game.item.cache
public static class GoldMagic // TypeDefIndex: 2102
{
	// Fields
	public static readonly Dictionary<int, GoldMagicBase> storage; // 0x0

	// Methods

	// RVA: 0xF8D728 Offset: 0xF89728 VA: 0xF8D728
	public static GoldMagicBase Get(int index) { }

	// RVA: 0xF933B4 Offset: 0xF8F3B4 VA: 0xF933B4
	public static bool Initialize(Action<string> logfunc) { }

	// RVA: 0xF93690 Offset: 0xF8F690 VA: 0xF93690
	private static void .cctor() { }
}

// Namespace: game.item.cache
public static class GoldRes // TypeDefIndex: 2103
{
	// Fields
	public static readonly Dictionary<int, GoldResBase> storage; // 0x0

	// Methods

	// RVA: 0xF93728 Offset: 0xF8F728 VA: 0xF93728
	public static int GetByRow(int goldEquipRowIndex) { }

	// RVA: 0xF937D4 Offset: 0xF8F7D4 VA: 0xF937D4
	public static bool Initialize(Action<string> logfunc) { }

	// RVA: 0xF93A24 Offset: 0xF8FA24 VA: 0xF93A24
	private static void .cctor() { }
}

// Namespace: game.item.cache
public static class MagicAttrib // TypeDefIndex: 2104
{
	// Fields
	public static readonly Dictionary<int, List<List<MagicAttribBase>>> storage; // 0x0
	private static readonly List<List<MagicAttribBase>> Empty; // 0x8

	// Methods

	// RVA: 0xF93ABC Offset: 0xF8FABC VA: 0xF93ABC
	public static List<List<MagicAttribBase>> Get(int detail, int series, int position) { }

	// RVA: 0xF93B98 Offset: 0xF8FB98 VA: 0xF93B98
	public static bool Initialize(Action<string> logfunc) { }

	// RVA: 0xF9469C Offset: 0xF9069C VA: 0xF9469C
	private static void .cctor() { }
}

// Namespace: game.item.cache
public class MagicScript // TypeDefIndex: 2105
{
	// Fields
	public static readonly Dictionary<int, MagicScriptBase> storage; // 0x0

	// Methods

	// RVA: 0xF8BFD0 Offset: 0xF87FD0 VA: 0xF8BFD0
	public static MagicScriptBase Get(int particular) { }

	// RVA: 0xF9478C Offset: 0xF9078C VA: 0xF9478C
	public static bool Initialize(Action<string> logfunc) { }

	// RVA: 0xF94C14 Offset: 0xF90C14 VA: 0xF94C14
	public void .ctor() { }

	// RVA: 0xF94C1C Offset: 0xF90C1C VA: 0xF94C1C
	private static void .cctor() { }
}

// Namespace: game.item.cache
[NullableContext(1)]
[Nullable(0)]
public static class MaskEquip // TypeDefIndex: 2106
{
	// Fields
	public static readonly Dictionary<int, EquipBase> storage; // 0x0

	// Methods

	// RVA: 0xF8BD14 Offset: 0xF87D14 VA: 0xF8BD14
	public static EquipBase Get(int g, int d, int p) { }

	// RVA: 0xF94CB4 Offset: 0xF90CB4 VA: 0xF94CB4
	public static bool Initialize(Action<string> logfunc) { }

	// RVA: 0xF95E84 Offset: 0xF91E84 VA: 0xF95E84
	private static void .cctor() { }
}

// Namespace: game.item.cache
[NullableContext(1)]
[Nullable(0)]
public static class NormalEquip // TypeDefIndex: 2107
{
	// Fields
	public static readonly Dictionary<int, EquipBase> storage; // 0x0

	// Methods

	// RVA: 0xF8BE08 Offset: 0xF87E08 VA: 0xF8BE08
	public static EquipBase Get(int g, int d, int p, int l) { }

	// RVA: 0xF95F1C Offset: 0xF91F1C VA: 0xF95F1C
	public static bool Initialize(Action<string> logfunc) { }

	// RVA: 0xF974DC Offset: 0xF934DC VA: 0xF974DC
	private static void .cctor() { }
}

// Namespace: game.item.cache
public static class NormalRes // TypeDefIndex: 2108
{
	// Fields
	public static readonly Dictionary<int, Dictionary<int, int>> storage; // 0x0

	// Methods

	// RVA: 0xF97574 Offset: 0xF93574 VA: 0xF97574
	public static int Line(int partId, int declareLine) { }

	// RVA: 0xF9765C Offset: 0xF9365C VA: 0xF9765C
	public static int ArmorLine(int declareLine) { }

	// RVA: 0xF976B4 Offset: 0xF936B4 VA: 0xF976B4
	public static int HelmLine(int declareLine) { }

	// RVA: 0xF9770C Offset: 0xF9370C VA: 0xF9770C
	public static int HorseLine(int declareLine) { }

	// RVA: 0xF97764 Offset: 0xF93764 VA: 0xF97764
	public static int MeleWeaponLine(int declareLine) { }

	// RVA: 0xF977BC Offset: 0xF937BC VA: 0xF977BC
	public static int RangeWeaponLine(int declareLine) { }

	// RVA: 0xF97814 Offset: 0xF93814 VA: 0xF97814
	public static bool Initialize(Action<string> logfunc) { }

	// RVA: 0xF97E8C Offset: 0xF93E8C VA: 0xF97E8C
	private static void .cctor() { }
}
