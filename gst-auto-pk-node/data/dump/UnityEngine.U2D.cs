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

// Namespace: UnityEngine.U2D
[RequiredByNativeCode]
[MovedFrom("UnityEngine.Experimental.U2D")]
[NativeHeader("Runtime/2D/Common/SpriteDataMarshalling.h")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[NativeType(1, "ScriptingSpriteBone")]
[Serializable]
public struct SpriteBone // TypeDefIndex: 7221
{
	// Fields
	[NativeName("name")]
	[SerializeField]
	private string m_Name; // 0x0
	[SerializeField]
	[NativeName("guid")]
	private string m_Guid; // 0x8
	[NativeName("position")]
	[SerializeField]
	private Vector3 m_Position; // 0x10
	[SerializeField]
	[NativeName("rotation")]
	private Quaternion m_Rotation; // 0x1C
	[NativeName("length")]
	[SerializeField]
	private float m_Length; // 0x2C
	[SerializeField]
	[NativeName("parentId")]
	private int m_ParentId; // 0x30
	[NativeName("color")]
	[SerializeField]
	private Color32 m_Color; // 0x34
}

// Namespace: UnityEngine.U2D
[StaticAccessor("GetSpriteAtlasManager()", 0)]
[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlasManager.h")]
[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
public class SpriteAtlasManager // TypeDefIndex: 7222
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<string, Action<SpriteAtlas>> atlasRequested; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<SpriteAtlas> atlasRegistered; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E882C4 Offset: 0x1E842C4 VA: 0x1E882C4
	private static bool RequestAtlas(string tag) { }

	[CompilerGenerated]
	// RVA: 0x1E88378 Offset: 0x1E84378 VA: 0x1E88378
	public static void add_atlasRegistered(Action<SpriteAtlas> value) { }

	[CompilerGenerated]
	// RVA: 0x1E88448 Offset: 0x1E84448 VA: 0x1E88448
	public static void remove_atlasRegistered(Action<SpriteAtlas> value) { }

	[RequiredByNativeCode]
	// RVA: 0x1E88518 Offset: 0x1E84518 VA: 0x1E88518
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	// RVA: 0x1E88584 Offset: 0x1E84584 VA: 0x1E88584
	internal static void Register(SpriteAtlas spriteAtlas) { }

	// RVA: 0x1E88600 Offset: 0x1E84600 VA: 0x1E88600
	private static void Register_Injected(IntPtr spriteAtlas) { }
}

// Namespace: UnityEngine.U2D
[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeType(Header = "Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
public class SpriteAtlas : Object // TypeDefIndex: 7223
{
	// Methods

	// RVA: 0x1E8863C Offset: 0x1E8463C VA: 0x1E8863C
	public bool CanBindTo(Sprite sprite) { }

	// RVA: 0x1E88720 Offset: 0x1E84720 VA: 0x1E88720
	private static bool CanBindTo_Injected(IntPtr _unity_self, IntPtr sprite) { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 7224
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7225
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 39D974909C7E64675317DD1A8583B8D8DE92E68B180532FADD22B482AD93DC83 /*Metadata offset 0x3EC458*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 C77A066B9EC0272B121AD30CBAEDA4AD20F986D49CC6D0007EBF45888D8B09BF /*Metadata offset 0x3EC470*/; // 0x14
}

// Namespace: 
internal class <Module> // TypeDefIndex: 7226
{}

// Namespace: 
private struct UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData // TypeDefIndex: 7227
{
	// Fields
	public byte[] FilePathsData; // 0x0
	public byte[] TypesData; // 0x8
	public int TotalTypes; // 0x10
	public int TotalFiles; // 0x14
	public bool IsEditorOnly; // 0x18
}

// Namespace: 
[CompilerGenerated]
[EditorBrowsable(1)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 // TypeDefIndex: 7228
{
	// Methods

	// RVA: 0x1ED7BF8 Offset: 0x1ED3BF8 VA: 0x1ED7BF8
	private static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get() { }

	// RVA: 0x1ED7CEC Offset: 0x1ED3CEC VA: 0x1ED7CEC
	public void .ctor() { }
}

// Namespace: UnityEngine.U2D
[MovedFrom("UnityEngine.Experimental.U2D")]
[NativeType(Header = "Modules/SpriteShape/Public/SpriteShapeRenderer.h")]
public class SpriteShapeRenderer : Renderer // TypeDefIndex: 8105
{}

// Namespace: 
internal class <Module> // TypeDefIndex: 8106
{}
