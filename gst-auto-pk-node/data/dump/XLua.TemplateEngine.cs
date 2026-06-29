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

// Namespace: XLua.TemplateEngine
public enum TokenType // TypeDefIndex: 1882
{
	// Fields
	public int value__; // 0x0
	public const TokenType Code = 0;
	public const TokenType Eval = 1;
	public const TokenType Text = 2;
}

// Namespace: XLua.TemplateEngine
public class Chunk // TypeDefIndex: 1883
{
	// Fields
	[CompilerGenerated]
	private TokenType <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Text>k__BackingField; // 0x18

	// Properties
	public TokenType Type { get; set; }
	public string Text { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xF6ABF8 Offset: 0xF66BF8 VA: 0xF6ABF8
	public TokenType get_Type() { }

	[CompilerGenerated]
	// RVA: 0xF6AC00 Offset: 0xF66C00 VA: 0xF6AC00
	private void set_Type(TokenType value) { }

	[CompilerGenerated]
	// RVA: 0xF6AC08 Offset: 0xF66C08 VA: 0xF6AC08
	public string get_Text() { }

	[CompilerGenerated]
	// RVA: 0xF6AC10 Offset: 0xF66C10 VA: 0xF6AC10
	private void set_Text(string value) { }

	// RVA: 0xF6AC18 Offset: 0xF66C18 VA: 0xF6AC18
	public void .ctor(TokenType type, string text) { }
}

// Namespace: XLua.TemplateEngine
internal class TemplateFormatException : Exception // TypeDefIndex: 1884
{
	// Methods

	// RVA: 0xF6AC50 Offset: 0xF66C50 VA: 0xF6AC50
	public void .ctor(string message) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Parser.<>c // TypeDefIndex: 1885
{
	// Fields
	public static readonly Parser.<>c <>9; // 0x0
	public static Func<Capture, <>f__AnonymousType0<TokenType, string, int>> <>9__7_0; // 0x8
	public static Func<Capture, <>f__AnonymousType0<TokenType, string, int>> <>9__7_1; // 0x10
	public static Func<Capture, <>f__AnonymousType0<TokenType, string, int>> <>9__7_2; // 0x18
	public static Func<<>f__AnonymousType0<TokenType, string, int>, int> <>9__7_3; // 0x20
	public static Func<<>f__AnonymousType0<TokenType, string, int>, Chunk> <>9__7_4; // 0x28

	// Methods

	// RVA: 0xF6BA60 Offset: 0xF67A60 VA: 0xF6BA60
	private static void .cctor() { }

	// RVA: 0xF6BAC8 Offset: 0xF67AC8 VA: 0xF6BAC8
	public void .ctor() { }

	// RVA: 0xF6BAD0 Offset: 0xF67AD0 VA: 0xF6BAD0
	internal <>f__AnonymousType0<TokenType, string, int> <Parse>b__7_0(Capture p) { }

	// RVA: 0xF6BB68 Offset: 0xF67B68 VA: 0xF6BB68
	internal <>f__AnonymousType0<TokenType, string, int> <Parse>b__7_1(Capture p) { }

	// RVA: 0xF6BC3C Offset: 0xF67C3C VA: 0xF6BC3C
	internal <>f__AnonymousType0<TokenType, string, int> <Parse>b__7_2(Capture p) { }

	// RVA: 0xF6BCD4 Offset: 0xF67CD4 VA: 0xF6BCD4
	internal int <Parse>b__7_3(<>f__AnonymousType0<TokenType, string, int> p) { }

	// RVA: 0xF6BD18 Offset: 0xF67D18 VA: 0xF6BD18
	internal Chunk <Parse>b__7_4(<>f__AnonymousType0<TokenType, string, int> m) { }
}

// Namespace: XLua.TemplateEngine
public class Parser // TypeDefIndex: 1886
{
	// Fields
	[CompilerGenerated]
	private static string <RegexString>k__BackingField; // 0x0

	// Properties
	public static string RegexString { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xF6ACA8 Offset: 0xF66CA8 VA: 0xF6ACA8
	public static string get_RegexString() { }

	[CompilerGenerated]
	// RVA: 0xF6AD00 Offset: 0xF66D00 VA: 0xF6AD00
	private static void set_RegexString(string value) { }

	// RVA: 0xF6AD68 Offset: 0xF66D68 VA: 0xF6AD68
	private static void .cctor() { }

	// RVA: 0xF6B110 Offset: 0xF67110 VA: 0xF6B110
	private static string EscapeString(string input) { }

	// RVA: 0xF6ADD4 Offset: 0xF66DD4 VA: 0xF6ADD4
	private static string GetRegexString() { }

	// RVA: 0xF6B3D4 Offset: 0xF673D4 VA: 0xF6B3D4
	public static List<Chunk> Parse(string snippet) { }

	// RVA: 0xF6BA58 Offset: 0xF67A58 VA: 0xF6BA58
	public void .ctor() { }
}

// Namespace: XLua.TemplateEngine
public class LuaTemplate // TypeDefIndex: 1887
{
	// Fields
	private static lua_CSFunction templateCompileFunction; // 0x0
	private static lua_CSFunction templateExecuteFunction; // 0x8

	// Methods

	// RVA: 0xF6BFE4 Offset: 0xF67FE4 VA: 0xF6BFE4
	public static string ComposeCode(List<Chunk> chunks) { }

	// RVA: 0xF6C2B0 Offset: 0xF682B0 VA: 0xF6C2B0
	public static LuaFunction Compile(LuaEnv luaenv, string snippet) { }

	// RVA: 0xF6C378 Offset: 0xF68378 VA: 0xF6C378
	public static string Execute(LuaFunction compiledTemplate, LuaTable parameters) { }

	// RVA: 0xF6C458 Offset: 0xF68458 VA: 0xF6C458
	public static string Execute(LuaFunction compiledTemplate) { }

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	// RVA: 0xF6BDAC Offset: 0xF67DAC VA: 0xF6BDAC
	public static int Compile(IntPtr L) { }

	[MonoPInvokeCallback(typeof(lua_CSFunction))]
	// RVA: 0xF6BF40 Offset: 0xF67F40 VA: 0xF6BF40
	public static int Execute(IntPtr L) { }

	// RVA: 0xF6C618 Offset: 0xF68618 VA: 0xF6C618
	public static void OpenLib(IntPtr L) { }

	// RVA: 0xF6C814 Offset: 0xF68814 VA: 0xF6C814
	public void .ctor() { }

	// RVA: 0xF6C81C Offset: 0xF6881C VA: 0xF6C81C
	private static void .cctor() { }
}
