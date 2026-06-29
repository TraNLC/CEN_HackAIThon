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

// Namespace: UnityEngine.SceneManagement
[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
[Serializable]
public struct Scene // TypeDefIndex: 6925
{
	// Fields
	[HideInInspector]
	[SerializeField]
	private int m_Handle; // 0x0

	// Properties
	public int handle { get; }

	// Methods

	// RVA: 0x1E7C518 Offset: 0x1E78518 VA: 0x1E7C518
	public int get_handle() { }

	// RVA: 0x1E7C520 Offset: 0x1E78520 VA: 0x1E7C520 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E7C528 Offset: 0x1E78528 VA: 0x1E7C528 Slot: 0
	public override bool Equals(object other) { }
}

// Namespace: UnityEngine.SceneManagement
[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[StaticAccessor("SceneManagerBindings", 2)]
internal static class SceneManagerAPIInternal // TypeDefIndex: 6926
{
	// Methods

	[NativeThrows]
	// RVA: 0x1E7C5A0 Offset: 0x1E785A0 VA: 0x1E7C5A0
	public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x1E7C7A0 Offset: 0x1E787A0 VA: 0x1E7C7A0
	private static IntPtr LoadSceneAsyncNameIndexInternal_Injected(ref ManagedSpanWrapper sceneName, int sceneBuildIndex, in LoadSceneParameters parameters, bool mustCompleteNextFrame) { }
}

// Namespace: UnityEngine.SceneManagement
public class SceneManagerAPI // TypeDefIndex: 6927
{
	// Fields
	private static SceneManagerAPI s_DefaultAPI; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static SceneManagerAPI <overrideAPI>k__BackingField; // 0x8

	// Properties
	internal static SceneManagerAPI ActiveAPI { get; }
	public static SceneManagerAPI overrideAPI { get; }

	// Methods

	// RVA: 0x1E7C7FC Offset: 0x1E787FC VA: 0x1E7C7FC
	internal static SceneManagerAPI get_ActiveAPI() { }

	[CompilerGenerated]
	// RVA: 0x1E7C8A4 Offset: 0x1E788A4 VA: 0x1E7C8A4
	public static SceneManagerAPI get_overrideAPI() { }

	// RVA: 0x1E7C8FC Offset: 0x1E788FC VA: 0x1E7C8FC
	protected internal void .ctor() { }

	// RVA: 0x1E7C904 Offset: 0x1E78904 VA: 0x1E7C904 Slot: 4
	protected internal virtual AsyncOperation LoadSceneAsyncByNameOrIndex(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	// RVA: 0x1E7C918 Offset: 0x1E78918 VA: 0x1E7C918 Slot: 5
	protected internal virtual AsyncOperation LoadFirstScene(bool mustLoadAsync) { }

	// RVA: 0x1E7C920 Offset: 0x1E78920 VA: 0x1E7C920
	private static void .cctor() { }
}

// Namespace: UnityEngine.SceneManagement
[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
[RequiredByNativeCode]
public class SceneManager // TypeDefIndex: 6928
{
	// Fields
	internal static bool s_AllowLoadScene; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static UnityAction<Scene, LoadSceneMode> sceneLoaded; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static UnityAction<Scene> sceneUnloaded; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static UnityAction<Scene, Scene> activeSceneChanged; // 0x18

	// Properties
	public static int sceneCount { get; }

	// Methods

	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	[StaticAccessor("GetSceneManager()", 0)]
	[NativeMethod("GetSceneCount")]
	// RVA: 0x1E7C988 Offset: 0x1E78988 VA: 0x1E7C988
	public static int get_sceneCount() { }

	[StaticAccessor("SceneManagerBindings", 2)]
	[NativeThrows]
	// RVA: 0x1E7C9B0 Offset: 0x1E789B0 VA: 0x1E7C9B0
	public static Scene GetSceneAt(int index) { }

	// RVA: 0x1E7CA80 Offset: 0x1E78A80 VA: 0x1E7CA80
	private static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	[RequiredByNativeCode]
	// RVA: 0x1E7CB5C Offset: 0x1E78B5C VA: 0x1E7CB5C
	internal static AsyncOperation LoadFirstScene_Internal(bool async) { }

	// RVA: 0x1E7CBC4 Offset: 0x1E78BC4 VA: 0x1E7CBC4
	public static void LoadScene(string sceneName, LoadSceneMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x1E7CCC4 Offset: 0x1E78CC4 VA: 0x1E7CCC4
	public static void LoadScene(string sceneName) { }

	// RVA: 0x1E7CC30 Offset: 0x1E78C30 VA: 0x1E7CC30
	public static Scene LoadScene(string sceneName, LoadSceneParameters parameters) { }

	[RequiredByNativeCode]
	// RVA: 0x1E7CD1C Offset: 0x1E78D1C VA: 0x1E7CD1C
	private static void Internal_SceneLoaded(Scene scene, LoadSceneMode mode) { }

	[RequiredByNativeCode]
	// RVA: 0x1E7CDCC Offset: 0x1E78DCC VA: 0x1E7CDCC
	private static void Internal_SceneUnloaded(Scene scene) { }

	[RequiredByNativeCode]
	// RVA: 0x1E7CE68 Offset: 0x1E78E68 VA: 0x1E7CE68
	private static void Internal_ActiveSceneChanged(Scene previousActiveScene, Scene newActiveScene) { }

	// RVA: 0x1E7CF18 Offset: 0x1E78F18 VA: 0x1E7CF18
	private static void .cctor() { }

	// RVA: 0x1E7CA3C Offset: 0x1E78A3C VA: 0x1E7CA3C
	private static void GetSceneAt_Injected(int index, out Scene ret) { }
}

// Namespace: UnityEngine.SceneManagement
public enum LoadSceneMode // TypeDefIndex: 6929
{
	// Fields
	public int value__; // 0x0
	public const LoadSceneMode Single = 0;
	public const LoadSceneMode Additive = 1;
}

// Namespace: UnityEngine.SceneManagement
[Flags]
public enum LocalPhysicsMode // TypeDefIndex: 6930
{
	// Fields
	public int value__; // 0x0
	public const LocalPhysicsMode None = 0;
	public const LocalPhysicsMode Physics2D = 1;
	public const LocalPhysicsMode Physics3D = 2;
}

// Namespace: UnityEngine.SceneManagement
[Serializable]
public struct LoadSceneParameters // TypeDefIndex: 6931
{
	// Fields
	[SerializeField]
	private LoadSceneMode m_LoadSceneMode; // 0x0
	[SerializeField]
	private LocalPhysicsMode m_LocalPhysicsMode; // 0x4

	// Methods

	// RVA: 0x1E7CC28 Offset: 0x1E78C28 VA: 0x1E7CC28
	public void .ctor(LoadSceneMode mode) { }
}
