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

// Namespace: game.resource.packageIni
internal class ElementReference // TypeDefIndex: 2290
{
	// Fields
	public uint id; // 0x10
	public int packageIndex; // 0x14
	public int index; // 0x18
	public int cacheIndex; // 0x1C
	public int offset; // 0x20
	public int size; // 0x24

	// Methods

	// RVA: 0xFC72DC Offset: 0xFC32DC VA: 0xFC72DC
	public void .ctor() { }
}

// Namespace: 
public class Handler.ElementStatusList // TypeDefIndex: 2291
{
	// Fields
	public int total; // 0x10
	public int failured; // 0x14
	public List<string> listing; // 0x18

	// Methods

	// RVA: 0xFC76B0 Offset: 0xFC36B0 VA: 0xFC76B0
	public void .ctor() { }
}

// Namespace: game.resource.packageIni
internal class Handler // TypeDefIndex: 2292
{
	// Methods

	// RVA: 0xFC72E4 Offset: 0xFC32E4 VA: 0xFC72E4
	public static IntPtr CreateHandler(string _rootDirectoryPath) { }

	// RVA: 0xFC73A4 Offset: 0xFC33A4 VA: 0xFC73A4
	public static IntPtr ReleaseHandler(IntPtr _handler) { }

	// RVA: 0xFC7424 Offset: 0xFC3424 VA: 0xFC7424
	public static int GetPackageElementCount(IntPtr _handler) { }

	// RVA: 0xFC74A4 Offset: 0xFC34A4 VA: 0xFC74A4
	public static Handler.ElementStatusList GetElementStatusList(IntPtr _handler) { }

	// RVA: 0xFC7834 Offset: 0xFC3834 VA: 0xFC7834
	public void .ctor() { }
}

// Namespace: game.resource.packageIni
internal class PluginApi // TypeDefIndex: 2293
{
	// Fields
	private const string libraryName = "il4i3n";

	// Methods

	// RVA: 0xFC72F8 Offset: 0xFC32F8 VA: 0xFC72F8
	public static extern IntPtr ue(string _z, int _x, int _c) { }

	// RVA: 0xFC73A8 Offset: 0xFC33A8 VA: 0xFC73A8
	public static extern IntPtr a0ff(IntPtr _x) { }

	// RVA: 0xFC7428 Offset: 0xFC3428 VA: 0xFC7428
	public static extern int o2(IntPtr _x) { }

	// RVA: 0xFC7738 Offset: 0xFC3738 VA: 0xFC7738
	public static extern void j4(IntPtr _x, int _c, StringBuilder _v, int _b, StringBuilder _n, int _m) { }

	// RVA: 0xFC783C Offset: 0xFC383C VA: 0xFC783C
	public static extern void ff00(IntPtr pointer) { }

	// RVA: 0xFC78B8 Offset: 0xFC38B8 VA: 0xFC78B8
	public static extern void lo(IntPtr _x, string _v, ref uint _b, ref int _n, ref int _m, ref int _l, ref int _k, ref int _j) { }

	// RVA: 0xFC7998 Offset: 0xFC3998 VA: 0xFC7998
	public static extern void a7(IntPtr _x, uint _b, int _n, int _m, int _l, int _k, int _j, IntPtr _h) { }

	// RVA: 0xFC7A64 Offset: 0xFC3A64 VA: 0xFC7A64
	public static extern ushort ff11(IntPtr _x, string _n) { }

	// RVA: 0xFC7B04 Offset: 0xFC3B04 VA: 0xFC7B04
	public static extern void af(IntPtr _x, string _m, ref ushort _l, ref ushort _k, ref ushort _j, ref ushort _h, ref ushort _g, ref ushort _f, ref ushort _d, ref ushort _s) { }

	// RVA: 0xFC7BF4 Offset: 0xFC3BF4 VA: 0xFC7BF4
	public static extern void c2(IntPtr _x, string _l, int _k, ref ushort _j, ref ushort _h, ref ushort _g, ref ushort _f) { }

	// RVA: 0xFC7CCC Offset: 0xFC3CCC VA: 0xFC7CCC
	public static extern void d1(IntPtr _x, string _k, int _j, IntPtr _h) { }

	// RVA: 0xFC7D7C Offset: 0xFC3D7C VA: 0xFC7D7C
	public static extern IntPtr aff0(IntPtr _x, string sprPath, ref uint out_id, ref int out_packIndex, ref int out_elementIndex, ref int out_buffer_size) { }

	// RVA: 0xFC7E4C Offset: 0xFC3E4C VA: 0xFC7E4C
	public static extern IntPtr b1f0(IntPtr _x, int packIndex, int elementIndex, IntPtr header, ushort frameIndex, ref ushort out_spr_centerX, ref ushort out_spr_centerY, ref ushort out_spr_width, ref ushort out_width, ref ushort out_height, ref ushort out_offsetX, ref ushort out_offsetY, ref int out_buffer_size) { }

	// RVA: 0xFC7F48 Offset: 0xFC3F48 VA: 0xFC7F48
	public static extern IntPtr f2(IntPtr _x, string _j, IntPtr _h, int _g, ref Config.Textures _f, ref int _d, ref int _s) { }

	// RVA: 0xFC8028 Offset: 0xFC4028 VA: 0xFC8028
	public static extern void bb(IntPtr _h, ref Config.Textures _g, [Out] Element.Texture[] _f, [Out] Element.Obstacle[] _d) { }

	// RVA: 0xFC8200 Offset: 0xFC4200 VA: 0xFC8200
	public void .ctor() { }
}

// Namespace: 
public struct CreatePlayer.CharacterSeries.Metal // TypeDefIndex: 2294
{
	// Fields
	public const string manStandBy = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_金_男_2.spr";
	public const string manShowoff = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_金_男_1.spr";
	public const string manStandByActive = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_金_男_0.spr";
}

// Namespace: 
public struct CreatePlayer.CharacterSeries.Wood // TypeDefIndex: 2295
{
	// Fields
	public const string manStandBy = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_木_男_2.spr";
	public const string manShowoff = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_木_男_1.spr";
	public const string manStandByActive = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_木_男_0.spr";
	public const string girlStandBy = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_木_女_2.spr";
	public const string girlShowoff = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_木_女_1.spr";
	public const string girlStandByActive = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_木_女_0.spr";
}

// Namespace: 
public struct CreatePlayer.CharacterSeries.Water // TypeDefIndex: 2296
{
	// Fields
	public const string girlStandBy = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_水_女_2.spr";
	public const string girlShowoff = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_水_女_1.spr";
	public const string girlStandByActive = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_水_女_0.spr";
}

// Namespace: 
public struct CreatePlayer.CharacterSeries.Fire // TypeDefIndex: 2297
{
	// Fields
	public const string manStandBy = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_火_男_2.spr";
	public const string manShowoff = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_火_男_1.spr";
	public const string manStandByActive = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_火_男_0.spr";
	public const string girlStandBy = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_火_女_2.spr";
	public const string girlShowoff = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_火_女_1.spr";
	public const string girlStandByActive = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_火_女_0.spr";
}

// Namespace: 
public struct CreatePlayer.CharacterSeries.Earth // TypeDefIndex: 2298
{
	// Fields
	public const string manStandBy = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_土_男_2.spr";
	public const string manShowoff = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_土_男_1.spr";
	public const string manStandByActive = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_土_男_0.spr";
	public const string girlStandBy = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_土_女_2.spr";
	public const string girlShowoff = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_土_女_1.spr";
	public const string girlStandByActive = "\\Spr\\Ui3\\登入界面\\选存档人物\\角色_土_女_0.spr";
}

// Namespace: 
public struct CreatePlayer.CharacterSeries // TypeDefIndex: 2299
{
	// Methods

	// RVA: 0xFC8208 Offset: 0xFC4208 VA: 0xFC8208
	public static string GetPath(int _series, int _gender, int _effect) { }
}
