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

// Namespace: UnityEngine
public enum SpriteDrawMode // TypeDefIndex: 6657
{
	// Fields
	public int value__; // 0x0
	public const SpriteDrawMode Simple = 0;
	public const SpriteDrawMode Sliced = 1;
	public const SpriteDrawMode Tiled = 2;
}

// Namespace: UnityEngine
[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
[RequireComponent(typeof(Transform))]
public sealed class SpriteRenderer : Renderer // TypeDefIndex: 6658
{
	// Fields
	private UnityEvent<SpriteRenderer> m_SpriteChangeEvent; // 0x18

	// Properties
	public Sprite sprite { get; set; }
	public SpriteDrawMode drawMode { set; }
	public Vector2 size { set; }
	public Color color { get; set; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E4B38C Offset: 0x1E4738C VA: 0x1E4B38C
	private void InvokeSpriteChanged() { }

	// RVA: 0x1E4B590 Offset: 0x1E47590 VA: 0x1E4B590
	public Sprite get_sprite() { }

	// RVA: 0x1E4B660 Offset: 0x1E47660 VA: 0x1E4B660
	public void set_sprite(Sprite value) { }

	// RVA: 0x1E4B758 Offset: 0x1E47758 VA: 0x1E4B758
	public void set_drawMode(SpriteDrawMode value) { }

	// RVA: 0x1E4B81C Offset: 0x1E4781C VA: 0x1E4B81C
	public void set_size(Vector2 value) { }

	// RVA: 0x1E4B8E4 Offset: 0x1E478E4 VA: 0x1E4B8E4
	public Color get_color() { }

	// RVA: 0x1E4B9BC Offset: 0x1E479BC VA: 0x1E4B9BC
	public void set_color(Color value) { }

	// RVA: 0x1E4BA90 Offset: 0x1E47A90 VA: 0x1E4BA90
	public void .ctor() { }

	// RVA: 0x1E4B624 Offset: 0x1E47624 VA: 0x1E4B624
	private static IntPtr get_sprite_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4B714 Offset: 0x1E47714 VA: 0x1E4B714
	private static void set_sprite_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x1E4B7D8 Offset: 0x1E477D8 VA: 0x1E4B7D8
	private static void set_drawMode_Injected(IntPtr _unity_self, SpriteDrawMode value) { }

	// RVA: 0x1E4B8A0 Offset: 0x1E478A0 VA: 0x1E4B8A0
	private static void set_size_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x1E4B978 Offset: 0x1E47978 VA: 0x1E4B978
	private static void get_color_Injected(IntPtr _unity_self, out Color ret) { }

	// RVA: 0x1E4BA4C Offset: 0x1E47A4C VA: 0x1E4BA4C
	private static void set_color_Injected(IntPtr _unity_self, in Color value) { }
}

// Namespace: UnityEngine
public enum SpriteMeshType // TypeDefIndex: 6659
{
	// Fields
	public int value__; // 0x0
	public const SpriteMeshType FullRect = 0;
	public const SpriteMeshType Tight = 1;
}

// Namespace: UnityEngine
[Serializable]
public struct SecondarySpriteTexture // TypeDefIndex: 6660
{
	// Fields
	public string name; // 0x0
	public Texture2D texture; // 0x8
}

// Namespace: UnityEngine
[NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[NativeHeader("Runtime/Graphics/SpriteUtility.h")]
[NativeType("Runtime/Graphics/SpriteFrame.h")]
[ExcludeFromPreset]
public sealed class Sprite : Object // TypeDefIndex: 6661
{
	// Properties
	public Bounds bounds { get; }
	public Rect rect { get; }
	public Vector4 border { get; }
	public Texture2D texture { get; }
	public float pixelsPerUnit { get; }
	public Texture2D associatedAlphaSplitTexture { get; }
	public Vector2 pivot { get; }
	public bool packed { get; }
	public Rect textureRect { get; }
	public Vector2[] vertices { get; }
	public ushort[] triangles { get; }
	public Vector2[] uv { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E4BAA0 Offset: 0x1E47AA0 VA: 0x1E4BAA0
	private void .ctor() { }

	// RVA: 0x1E4BAF8 Offset: 0x1E47AF8 VA: 0x1E4BAF8
	internal int GetPacked() { }

	// RVA: 0x1E4BBAC Offset: 0x1E47BAC VA: 0x1E4BBAC
	internal Rect GetTextureRect() { }

	// RVA: 0x1E4BC84 Offset: 0x1E47C84 VA: 0x1E4BC84
	internal Vector4 GetInnerUVs() { }

	// RVA: 0x1E4BD5C Offset: 0x1E47D5C VA: 0x1E4BD5C
	internal Vector4 GetOuterUVs() { }

	// RVA: 0x1E4BE34 Offset: 0x1E47E34 VA: 0x1E4BE34
	internal Vector4 GetPadding() { }

	[FreeFunction("SpritesBindings::CreateSprite", ThrowsException = True)]
	// RVA: 0x1E4BF0C Offset: 0x1E47F0C VA: 0x1E4BF0C
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	// RVA: 0x1E4C0AC Offset: 0x1E480AC VA: 0x1E4C0AC
	public Bounds get_bounds() { }

	// RVA: 0x1E4C194 Offset: 0x1E48194 VA: 0x1E4C194
	public Rect get_rect() { }

	// RVA: 0x1E4C26C Offset: 0x1E4826C VA: 0x1E4C26C
	public Vector4 get_border() { }

	// RVA: 0x1E4C344 Offset: 0x1E48344 VA: 0x1E4C344
	public Texture2D get_texture() { }

	[NativeMethod("GetPixelsToUnits")]
	// RVA: 0x1E4C414 Offset: 0x1E48414 VA: 0x1E4C414
	public float get_pixelsPerUnit() { }

	[NativeMethod("GetAlphaTexture")]
	// RVA: 0x1E4C4C8 Offset: 0x1E484C8 VA: 0x1E4C4C8
	public Texture2D get_associatedAlphaSplitTexture() { }

	[NativeMethod("GetPivotInPixels")]
	// RVA: 0x1E4C598 Offset: 0x1E48598 VA: 0x1E4C598
	public Vector2 get_pivot() { }

	// RVA: 0x1E4C664 Offset: 0x1E48664 VA: 0x1E4C664
	public bool get_packed() { }

	// RVA: 0x1E4C67C Offset: 0x1E4867C VA: 0x1E4C67C
	public Rect get_textureRect() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = True)]
	// RVA: 0x1E4C680 Offset: 0x1E48680 VA: 0x1E4C680
	public Vector2[] get_vertices() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = True)]
	// RVA: 0x1E4C734 Offset: 0x1E48734 VA: 0x1E4C734
	public ushort[] get_triangles() { }

	[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = True)]
	// RVA: 0x1E4C7E8 Offset: 0x1E487E8 VA: 0x1E4C7E8
	public Vector2[] get_uv() { }

	// RVA: 0x1E4C89C Offset: 0x1E4889C VA: 0x1E4C89C
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	// RVA: 0x1E4C8AC Offset: 0x1E488AC VA: 0x1E4C8AC
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTextures) { }

	// RVA: 0x1E4CD00 Offset: 0x1E48D00 VA: 0x1E4CD00
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	// RVA: 0x1E4CD14 Offset: 0x1E48D14 VA: 0x1E4CD14
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	// RVA: 0x1E4CDFC Offset: 0x1E48DFC VA: 0x1E4CDFC
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	// RVA: 0x1E4CE04 Offset: 0x1E48E04 VA: 0x1E4CE04
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	// RVA: 0x1E4CE10 Offset: 0x1E48E10 VA: 0x1E4CE10
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	// RVA: 0x1E4BB70 Offset: 0x1E47B70 VA: 0x1E4BB70
	private static int GetPacked_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4BC40 Offset: 0x1E47C40 VA: 0x1E4BC40
	private static void GetTextureRect_Injected(IntPtr _unity_self, out Rect ret) { }

	// RVA: 0x1E4BD18 Offset: 0x1E47D18 VA: 0x1E4BD18
	private static void GetInnerUVs_Injected(IntPtr _unity_self, out Vector4 ret) { }

	// RVA: 0x1E4BDF0 Offset: 0x1E47DF0 VA: 0x1E4BDF0
	private static void GetOuterUVs_Injected(IntPtr _unity_self, out Vector4 ret) { }

	// RVA: 0x1E4BEC8 Offset: 0x1E47EC8 VA: 0x1E4BEC8
	private static void GetPadding_Injected(IntPtr _unity_self, out Vector4 ret) { }

	// RVA: 0x1E4C010 Offset: 0x1E48010 VA: 0x1E4C010
	private static IntPtr CreateSprite_Injected(IntPtr texture, in Rect rect, in Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, in Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	// RVA: 0x1E4C150 Offset: 0x1E48150 VA: 0x1E4C150
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	// RVA: 0x1E4C228 Offset: 0x1E48228 VA: 0x1E4C228
	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	// RVA: 0x1E4C300 Offset: 0x1E48300 VA: 0x1E4C300
	private static void get_border_Injected(IntPtr _unity_self, out Vector4 ret) { }

	// RVA: 0x1E4C3D8 Offset: 0x1E483D8 VA: 0x1E4C3D8
	private static IntPtr get_texture_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4C48C Offset: 0x1E4848C VA: 0x1E4C48C
	private static float get_pixelsPerUnit_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4C55C Offset: 0x1E4855C VA: 0x1E4C55C
	private static IntPtr get_associatedAlphaSplitTexture_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4C620 Offset: 0x1E48620 VA: 0x1E4C620
	private static void get_pivot_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x1E4C6F8 Offset: 0x1E486F8 VA: 0x1E4C6F8
	private static Vector2[] get_vertices_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4C7AC Offset: 0x1E487AC VA: 0x1E4C7AC
	private static ushort[] get_triangles_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4C860 Offset: 0x1E48860 VA: 0x1E4C860
	private static Vector2[] get_uv_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/BaseClasses/TagManager.h")]
public struct SortingLayer // TypeDefIndex: 6662
{
	// Fields
	private int m_Id; // 0x0

	// Methods

	[FreeFunction("GetTagManager().GetSortingLayerValueFromUniqueID")]
	// RVA: 0x1E4CE24 Offset: 0x1E48E24 VA: 0x1E4CE24
	public static int GetLayerValueFromID(int id) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public struct Keyframe // TypeDefIndex: 6663
{
	// Fields
	private float m_Time; // 0x0
	private float m_Value; // 0x4
	private float m_InTangent; // 0x8
	private float m_OutTangent; // 0xC
	private int m_WeightedMode; // 0x10
	private float m_InWeight; // 0x14
	private float m_OutWeight; // 0x18
}

// Namespace: 
internal static class AnimationCurve.BindingsMarshaller // TypeDefIndex: 6664
{
	// Methods

	// RVA: 0x1E4D394 Offset: 0x1E49394 VA: 0x1E4D394
	public static IntPtr ConvertToNative(AnimationCurve animationCurve) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Runtime/Math/AnimationCurve.bindings.h")]
[DefaultMember("Item")]
public class AnimationCurve : IEquatable<AnimationCurve> // TypeDefIndex: 6665
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.ParticleSystemModule" })]
	internal IntPtr m_Ptr; // 0x10
	private bool m_RequiresNativeCleanup; // 0x18

	// Methods

	[FreeFunction("AnimationCurveBindings::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x1E4CE60 Offset: 0x1E48E60 VA: 0x1E4CE60
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunction("AnimationCurveBindings::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x1E4CE9C Offset: 0x1E48E9C VA: 0x1E4CE9C
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunction("AnimationCurveBindings::Internal_Equals", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x1E4CFA4 Offset: 0x1E48FA4 VA: 0x1E4CFA4
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x1E4D040 Offset: 0x1E49040 VA: 0x1E4D040 Slot: 1
	protected override void Finalize() { }

	[FreeFunction("AnimationCurveBindings::GetHashCode", HasExplicitThis = True, IsThreadSafe = True)]
	// RVA: 0x1E4D0FC Offset: 0x1E490FC VA: 0x1E4D0FC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E4D188 Offset: 0x1E49188 VA: 0x1E4D188
	public void .ctor(Keyframe[] keys) { }

	[RequiredByNativeCode]
	// RVA: 0x1E4D1C0 Offset: 0x1E491C0 VA: 0x1E4D1C0
	public void .ctor() { }

	[VisibleToOtherModules(new[] { "UnityEngine.ParticleSystemModule" })]
	// RVA: 0x1E4D1EC Offset: 0x1E491EC VA: 0x1E4D1EC
	internal void .ctor(IntPtr ptr, bool ownMemory) { }

	// RVA: 0x1E4D21C Offset: 0x1E4921C VA: 0x1E4D21C Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1E4D31C Offset: 0x1E4931C VA: 0x1E4D31C Slot: 4
	public bool Equals(AnimationCurve other) { }

	// RVA: 0x1E4CF68 Offset: 0x1E48F68 VA: 0x1E4CF68
	private static IntPtr Internal_Create_Injected(ref ManagedSpanWrapper keys) { }

	// RVA: 0x1E4CFFC Offset: 0x1E48FFC VA: 0x1E4CFFC
	private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other) { }

	// RVA: 0x1E4D14C Offset: 0x1E4914C VA: 0x1E4D14C
	private static int GetHashCode_Injected(IntPtr _unity_self) { }
}

// Namespace: 
public sealed class Application.LowMemoryCallback : MulticastDelegate // TypeDefIndex: 6666
{
	// Methods

	// RVA: 0x1E4E47C Offset: 0x1E4A47C VA: 0x1E4E47C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E4E518 Offset: 0x1E4A518 VA: 0x1E4E518 Slot: 12
	public virtual void Invoke() { }
}

// Namespace: 
public sealed class Application.MemoryUsageChangedCallback : MulticastDelegate // TypeDefIndex: 6667
{
	// Methods

	// RVA: 0x1E4E52C Offset: 0x1E4A52C VA: 0x1E4E52C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E4E5DC Offset: 0x1E4A5DC VA: 0x1E4E5DC Slot: 12
	public virtual void Invoke(in ApplicationMemoryUsageChange usage) { }
}

// Namespace: 
public sealed class Application.LogCallback : MulticastDelegate // TypeDefIndex: 6668
{
	// Methods

	// RVA: 0x1E4E5F0 Offset: 0x1E4A5F0 VA: 0x1E4E5F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E4E6A4 Offset: 0x1E4A6A4 VA: 0x1E4E6A4 Slot: 12
	public virtual void Invoke(string condition, string stackTrace, LogType type) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
[NativeHeader("Runtime/Utilities/URLUtility.h")]
[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
[NativeHeader("Runtime/Logging/LogSystem.h")]
[NativeHeader("Runtime/Utilities/Argv.h")]
[NativeHeader("Runtime/Input/TargetFrameRate.h")]
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Network/NetworkUtility.h")]
[NativeHeader("Runtime/Application/AdsIdHandler.h")]
[NativeHeader("Runtime/Application/ApplicationInfo.h")]
[NativeHeader("Runtime/Misc/Player.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Misc/BuildSettings.h")]
public class Application // TypeDefIndex: 6669
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Application.LowMemoryCallback lowMemory; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Application.MemoryUsageChangedCallback memoryUsageChanged; // 0x8
	private static Application.LogCallback s_LogCallbackHandler; // 0x10
	private static Application.LogCallback s_LogCallbackHandlerThreaded; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<bool> focusChanged; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<string> deepLinkActivated; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Func<bool> wantsToQuit; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action quitting; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action unloading; // 0x40
	private static CancellationTokenSource s_currentCancellationTokenSource; // 0x48

	// Properties
	public static bool isPlaying { get; }
	public static bool isBatchMode { get; }
	public static string streamingAssetsPath { get; }
	public static string persistentDataPath { get; }
	public static int targetFrameRate { get; set; }
	public static RuntimePlatform platform { get; }
	public static bool isEditor { get; }

	// Methods

	[FreeFunction("IsWorldPlaying")]
	// RVA: 0x1E4D3A8 Offset: 0x1E493A8 VA: 0x1E4D3A8
	public static bool get_isPlaying() { }

	[FreeFunction("::IsBatchmode")]
	// RVA: 0x1E4D3D0 Offset: 0x1E493D0 VA: 0x1E4D3D0
	public static bool get_isBatchMode() { }

	[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = True)]
	// RVA: 0x1E4D3F8 Offset: 0x1E493F8 VA: 0x1E4D3F8
	public static string get_streamingAssetsPath() { }

	[FreeFunction("GetPersistentDataPathApplicationSpecific")]
	// RVA: 0x1E4D530 Offset: 0x1E49530 VA: 0x1E4D530
	public static string get_persistentDataPath() { }

	[FreeFunction("OpenURL")]
	// RVA: 0x1E4D668 Offset: 0x1E49668 VA: 0x1E4D668
	public static void OpenURL(string url) { }

	[FreeFunction("GetTargetFrameRate")]
	// RVA: 0x1E4D830 Offset: 0x1E49830 VA: 0x1E4D830
	public static int get_targetFrameRate() { }

	[FreeFunction("SetTargetFrameRate")]
	// RVA: 0x1E4D858 Offset: 0x1E49858 VA: 0x1E4D858
	public static void set_targetFrameRate(int value) { }

	[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = True)]
	// RVA: 0x1E4D894 Offset: 0x1E49894 VA: 0x1E4D894
	public static RuntimePlatform get_platform() { }

	[RequiredByNativeCode]
	// RVA: 0x1E4D8BC Offset: 0x1E498BC VA: 0x1E4D8BC
	internal static void CallLowMemory(ApplicationMemoryUsage usage) { }

	[RequiredByNativeCode]
	// RVA: 0x1E4D9F4 Offset: 0x1E499F4 VA: 0x1E4D9F4
	internal static bool HasLogCallback() { }

	[RequiredByNativeCode]
	// RVA: 0x1E4DA78 Offset: 0x1E49A78 VA: 0x1E4DA78
	private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread) { }

	[RequiredByNativeCode]
	// RVA: 0x1E4DB60 Offset: 0x1E49B60 VA: 0x1E4DB60
	private static bool Internal_ApplicationWantsToQuit() { }

	[RequiredByNativeCode]
	// RVA: 0x1E4DE58 Offset: 0x1E49E58 VA: 0x1E4DE58
	private static void Internal_InitializeExitCancellationToken() { }

	[RequiredByNativeCode]
	// RVA: 0x1E4DF38 Offset: 0x1E49F38 VA: 0x1E4DF38
	private static void Internal_RaiseExitCancellationToken() { }

	[RequiredByNativeCode]
	// RVA: 0x1E4DFA4 Offset: 0x1E49FA4 VA: 0x1E4DFA4
	private static void Internal_ApplicationQuit() { }

	[RequiredByNativeCode]
	// RVA: 0x1E4E038 Offset: 0x1E4A038 VA: 0x1E4E038
	private static void Internal_ApplicationUnload() { }

	[RequiredByNativeCode]
	// RVA: 0x1E4E0CC Offset: 0x1E4A0CC VA: 0x1E4E0CC
	internal static void InvokeOnBeforeRender() { }

	[RequiredByNativeCode]
	// RVA: 0x1E4E2C8 Offset: 0x1E4A2C8 VA: 0x1E4E2C8
	internal static void InvokeFocusChanged(bool focus) { }

	[RequiredByNativeCode]
	// RVA: 0x1E4E364 Offset: 0x1E4A364 VA: 0x1E4E364
	internal static void InvokeDeepLinkActivated(string url) { }

	// RVA: 0x1E4E400 Offset: 0x1E4A400 VA: 0x1E4E400
	public static bool get_isEditor() { }

	// RVA: 0x1E4E408 Offset: 0x1E4A408 VA: 0x1E4E408
	private static void .cctor() { }

	// RVA: 0x1E4D4F4 Offset: 0x1E494F4 VA: 0x1E4D4F4
	private static void get_streamingAssetsPath_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x1E4D62C Offset: 0x1E4962C VA: 0x1E4D62C
	private static void get_persistentDataPath_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x1E4D7F4 Offset: 0x1E497F4 VA: 0x1E4D7F4
	private static void OpenURL_Injected(ref ManagedSpanWrapper url) { }
}

// Namespace: UnityEngine
public enum ApplicationMemoryUsage // TypeDefIndex: 6670
{
	// Fields
	public int value__; // 0x0
	public const ApplicationMemoryUsage Unknown = 0;
	public const ApplicationMemoryUsage Low = 1;
	public const ApplicationMemoryUsage Medium = 2;
	public const ApplicationMemoryUsage High = 3;
	public const ApplicationMemoryUsage Critical = 4;
}

// Namespace: UnityEngine
public struct ApplicationMemoryUsageChange // TypeDefIndex: 6671
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private ApplicationMemoryUsage <memoryUsage>k__BackingField; // 0x0

	// Properties
	private ApplicationMemoryUsage memoryUsage { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E4E6B8 Offset: 0x1E4A6B8 VA: 0x1E4E6B8
	private void set_memoryUsage(ApplicationMemoryUsage value) { }

	// RVA: 0x1E4D9EC Offset: 0x1E499EC VA: 0x1E4D9EC
	public void .ctor(ApplicationMemoryUsage usage) { }
}

// Namespace: UnityEngine
public enum SendMessageOptions // TypeDefIndex: 6672
{
	// Fields
	public int value__; // 0x0
	public const SendMessageOptions RequireReceiver = 0;
	public const SendMessageOptions DontRequireReceiver = 1;
}

// Namespace: UnityEngine
public enum Space // TypeDefIndex: 6673
{
	// Fields
	public int value__; // 0x0
	public const Space World = 0;
	public const Space Self = 1;
}

// Namespace: UnityEngine
public enum RuntimePlatform // TypeDefIndex: 6674
{
	// Fields
	public int value__; // 0x0
	public const RuntimePlatform OSXEditor = 0;
	public const RuntimePlatform OSXPlayer = 1;
	public const RuntimePlatform WindowsPlayer = 2;
	[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", True)]
	public const RuntimePlatform OSXWebPlayer = 3;
	[Obsolete("Dashboard widget on Mac OS X export is no longer supported in Unity 5.4+.", True)]
	public const RuntimePlatform OSXDashboardPlayer = 4;
	[Obsolete("WebPlayer export is no longer supported in Unity 5.4+.", True)]
	public const RuntimePlatform WindowsWebPlayer = 5;
	public const RuntimePlatform WindowsEditor = 7;
	public const RuntimePlatform IPhonePlayer = 8;
	[Obsolete("Xbox360 export is no longer supported in Unity 5.5+.")]
	public const RuntimePlatform XBOX360 = 10;
	[Obsolete("PS3 export is no longer supported in Unity >=5.5.")]
	public const RuntimePlatform PS3 = 9;
	public const RuntimePlatform Android = 11;
	[Obsolete("NaCl export is no longer supported in Unity 5.0+.")]
	public const RuntimePlatform NaCl = 12;
	[Obsolete("FlashPlayer export is no longer supported in Unity 5.0+.")]
	public const RuntimePlatform FlashPlayer = 15;
	public const RuntimePlatform LinuxPlayer = 13;
	public const RuntimePlatform LinuxEditor = 16;
	public const RuntimePlatform WebGLPlayer = 17;
	[Obsolete("Use WSAPlayerX86 instead")]
	public const RuntimePlatform MetroPlayerX86 = 18;
	public const RuntimePlatform WSAPlayerX86 = 18;
	[Obsolete("Use WSAPlayerX64 instead")]
	public const RuntimePlatform MetroPlayerX64 = 19;
	public const RuntimePlatform WSAPlayerX64 = 19;
	[Obsolete("Use WSAPlayerARM instead")]
	public const RuntimePlatform MetroPlayerARM = 20;
	public const RuntimePlatform WSAPlayerARM = 20;
	[Obsolete("Windows Phone 8 was removed in 5.3")]
	public const RuntimePlatform WP8Player = 21;
	[Obsolete("BlackBerryPlayer export is no longer supported in Unity 5.4+.")]
	public const RuntimePlatform BlackBerryPlayer = 22;
	[Obsolete("TizenPlayer export is no longer supported in Unity 2017.3+.")]
	public const RuntimePlatform TizenPlayer = 23;
	[Obsolete("PSP2 is no longer supported as of Unity 2018.3")]
	public const RuntimePlatform PSP2 = 24;
	public const RuntimePlatform PS4 = 25;
	[Obsolete("PSM export is no longer supported in Unity >= 5.3")]
	public const RuntimePlatform PSM = 26;
	public const RuntimePlatform XboxOne = 27;
	[Obsolete("SamsungTVPlayer export is no longer supported in Unity 2017.3+.")]
	public const RuntimePlatform SamsungTVPlayer = 28;
	[Obsolete("Wii U is no longer supported in Unity 2018.1+.")]
	public const RuntimePlatform WiiU = 30;
	public const RuntimePlatform tvOS = 31;
	public const RuntimePlatform Switch = 32;
	[Obsolete("Lumin is no longer supported in Unity 2022.2")]
	public const RuntimePlatform Lumin = 33;
	[Obsolete("Stadia is no longer supported in Unity 2023.1")]
	public const RuntimePlatform Stadia = 34;
	[Obsolete("CloudRendering is deprecated, please use LinuxHeadlessSimulation (UnityUpgradable) -> LinuxHeadlessSimulation", False)]
	public const RuntimePlatform CloudRendering = -1;
	public const RuntimePlatform LinuxHeadlessSimulation = 35;
	[Obsolete("GameCoreScarlett is deprecated, please use GameCoreXboxSeries (UnityUpgradable) -> GameCoreXboxSeries", False)]
	public const RuntimePlatform GameCoreScarlett = -1;
	public const RuntimePlatform GameCoreXboxSeries = 36;
	public const RuntimePlatform GameCoreXboxOne = 37;
	public const RuntimePlatform PS5 = 38;
	public const RuntimePlatform EmbeddedLinuxArm64 = 39;
	[Obsolete("32-bit embedded platforms are no longer supported")]
	public const RuntimePlatform EmbeddedLinuxArm32 = 40;
	public const RuntimePlatform EmbeddedLinuxX64 = 41;
	[Obsolete("32-bit embedded platforms are no longer supported")]
	public const RuntimePlatform EmbeddedLinuxX86 = 42;
	public const RuntimePlatform LinuxServer = 43;
	public const RuntimePlatform WindowsServer = 44;
	public const RuntimePlatform OSXServer = 45;
	[Obsolete("32-bit embedded platforms are no longer supported")]
	public const RuntimePlatform QNXArm32 = 46;
	public const RuntimePlatform QNXArm64 = 47;
	public const RuntimePlatform QNXX64 = 48;
	[Obsolete("32-bit embedded platforms are no longer supported")]
	public const RuntimePlatform QNXX86 = 49;
	public const RuntimePlatform VisionOS = 50;
	public const RuntimePlatform Switch2 = 51;
	[EditorBrowsable(1)]
	[Obsolete]
	public const RuntimePlatform KeplerArm64 = 52;
	[EditorBrowsable(1)]
	[Obsolete]
	public const RuntimePlatform KeplerX64 = 53;
}

// Namespace: UnityEngine
public enum LogType // TypeDefIndex: 6675
{
	// Fields
	public int value__; // 0x0
	public const LogType Error = 0;
	public const LogType Assert = 1;
	public const LogType Warning = 2;
	public const LogType Log = 3;
	public const LogType Exception = 4;
}

// Namespace: UnityEngine
public enum LogOption // TypeDefIndex: 6676
{
	// Fields
	public int value__; // 0x0
	public const LogOption None = 0;
	public const LogOption NoStacktrace = 1;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Bootstrap/BootConfig.bindings.h")]
internal class BootConfigData // TypeDefIndex: 6677
{
	// Fields
	private IntPtr m_Ptr; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E4E6C0 Offset: 0x1E4A6C0 VA: 0x1E4E6C0
	private static BootConfigData WrapBootConfigData(IntPtr nativeHandle) { }

	// RVA: 0x1E4E718 Offset: 0x1E4A718 VA: 0x1E4E718
	private void .ctor(IntPtr nativeHandle) { }
}

// Namespace: UnityEngine
[ExcludeFromDocs]
[RequiredByNativeCode(GenerateProxy = True)]
[Serializable]
internal class BatchRendererGroupRuntimeAnalytic : AnalyticsEventBase // TypeDefIndex: 6678
{
	// Fields
	private int brgRuntimeStatus; // 0x2C

	// Methods

	// RVA: 0x1E4E78C Offset: 0x1E4A78C VA: 0x1E4E78C
	private void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x1E4E800 Offset: 0x1E4A800 VA: 0x1E4E800
	public static BatchRendererGroupRuntimeAnalytic CreateBatchRendererGroupRuntimeAnalytic() { }
}

// Namespace: 
public enum Camera.MonoOrStereoscopicEye // TypeDefIndex: 6679
{
	// Fields
	public int value__; // 0x0
	public const Camera.MonoOrStereoscopicEye Left = 0;
	public const Camera.MonoOrStereoscopicEye Right = 1;
	public const Camera.MonoOrStereoscopicEye Mono = 2;
}

// Namespace: 
public sealed class Camera.CameraCallback : MulticastDelegate // TypeDefIndex: 6680
{
	// Methods

	// RVA: 0x1E4F9E4 Offset: 0x1E4B9E4 VA: 0x1E4F9E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E4FA94 Offset: 0x1E4BA94 VA: 0x1E4FA94 Slot: 12
	public virtual void Invoke(Camera cam) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[UsedByNativeCode]
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Camera/RenderManager.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
public sealed class Camera : Behaviour // TypeDefIndex: 6681
{
	// Fields
	public const float kMinAperture = 0.7;
	public const float kMaxAperture = 32;
	public const int kMinBladeCount = 3;
	public const int kMaxBladeCount = 11;
	internal uint m_NonSerializedVersion; // 0x18
	public static Camera.CameraCallback onPreCull; // 0x0
	public static Camera.CameraCallback onPreRender; // 0x8
	public static Camera.CameraCallback onPostRender; // 0x10

	// Properties
	[NativeProperty("Near")]
	public float nearClipPlane { get; }
	[NativeProperty("Far")]
	public float farClipPlane { get; }
	public float orthographicSize { get; set; }
	public float depth { get; }
	public float aspect { get; }
	public int cullingMask { get; }
	public int eventMask { get; }
	public CameraClearFlags clearFlags { get; }
	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect { get; }
	public RenderTexture targetTexture { get; }
	public int targetDisplay { get; }
	public static Camera main { get; }
	public static Camera current { get; }
	private static Camera currentInternal { get; }
	public static int allCamerasCount { get; }

	// Methods

	// RVA: 0x1E4E850 Offset: 0x1E4A850 VA: 0x1E4E850
	public void .ctor() { }

	// RVA: 0x1E4E858 Offset: 0x1E4A858 VA: 0x1E4E858
	public float get_nearClipPlane() { }

	// RVA: 0x1E4E90C Offset: 0x1E4A90C VA: 0x1E4E90C
	public float get_farClipPlane() { }

	// RVA: 0x1E4E9C0 Offset: 0x1E4A9C0 VA: 0x1E4E9C0
	public float get_orthographicSize() { }

	// RVA: 0x1E4EA74 Offset: 0x1E4AA74 VA: 0x1E4EA74
	public void set_orthographicSize(float value) { }

	// RVA: 0x1E4EB48 Offset: 0x1E4AB48 VA: 0x1E4EB48
	public float get_depth() { }

	// RVA: 0x1E4EBFC Offset: 0x1E4ABFC VA: 0x1E4EBFC
	public float get_aspect() { }

	// RVA: 0x1E4ECB0 Offset: 0x1E4ACB0 VA: 0x1E4ECB0
	public int get_cullingMask() { }

	// RVA: 0x1E4ED64 Offset: 0x1E4AD64 VA: 0x1E4ED64
	public int get_eventMask() { }

	// RVA: 0x1E4EE18 Offset: 0x1E4AE18 VA: 0x1E4EE18
	public CameraClearFlags get_clearFlags() { }

	// RVA: 0x1E4EECC Offset: 0x1E4AECC VA: 0x1E4EECC
	public Rect get_pixelRect() { }

	// RVA: 0x1E4EFA4 Offset: 0x1E4AFA4 VA: 0x1E4EFA4
	public RenderTexture get_targetTexture() { }

	// RVA: 0x1E4F074 Offset: 0x1E4B074 VA: 0x1E4F074
	public int get_targetDisplay() { }

	// RVA: 0x1E4F128 Offset: 0x1E4B128 VA: 0x1E4F128
	public Vector3 WorldToScreenPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x1E4F230 Offset: 0x1E4B230 VA: 0x1E4F230
	public Vector3 ScreenToWorldPoint(Vector3 position, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x1E4F338 Offset: 0x1E4B338 VA: 0x1E4F338
	public Vector3 WorldToScreenPoint(Vector3 position) { }

	// RVA: 0x1E4F340 Offset: 0x1E4B340 VA: 0x1E4F340
	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	// RVA: 0x1E4F348 Offset: 0x1E4B348 VA: 0x1E4F348
	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	// RVA: 0x1E4F440 Offset: 0x1E4B440 VA: 0x1E4F440
	private Ray ScreenPointToRay(Vector2 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x1E4F554 Offset: 0x1E4B554 VA: 0x1E4F554
	public Ray ScreenPointToRay(Vector3 pos, Camera.MonoOrStereoscopicEye eye) { }

	// RVA: 0x1E4F584 Offset: 0x1E4B584 VA: 0x1E4F584
	public Ray ScreenPointToRay(Vector3 pos) { }

	[FreeFunction("FindMainCamera")]
	// RVA: 0x1E4F5B8 Offset: 0x1E4B5B8 VA: 0x1E4F5B8
	public static Camera get_main() { }

	// RVA: 0x1E4F640 Offset: 0x1E4B640 VA: 0x1E4F640
	public static Camera get_current() { }

	[FreeFunction("GetCurrentCameraPPtr")]
	// RVA: 0x1E4F644 Offset: 0x1E4B644 VA: 0x1E4F644
	private static Camera get_currentInternal() { }

	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	// RVA: 0x1E4F6CC Offset: 0x1E4B6CC VA: 0x1E4F6CC
	private static int GetAllCamerasCount() { }

	[FreeFunction("CameraScripting::GetAllCameras")]
	// RVA: 0x1E4F6F4 Offset: 0x1E4B6F4 VA: 0x1E4F6F4
	private static int GetAllCamerasImpl([Out] Camera[] cam) { }

	// RVA: 0x1E4F7A8 Offset: 0x1E4B7A8 VA: 0x1E4F7A8
	public static int get_allCamerasCount() { }

	// RVA: 0x1E4F7D0 Offset: 0x1E4B7D0 VA: 0x1E4F7D0
	public static int GetAllCameras(Camera[] cameras) { }

	[RequiredByNativeCode]
	// RVA: 0x1E4F884 Offset: 0x1E4B884 VA: 0x1E4F884
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCode]
	// RVA: 0x1E4F8F0 Offset: 0x1E4B8F0 VA: 0x1E4F8F0
	private static void FireOnPreRender(Camera cam) { }

	[RequiredByNativeCode]
	// RVA: 0x1E4F95C Offset: 0x1E4B95C VA: 0x1E4F95C
	private static void FireOnPostRender(Camera cam) { }

	[RequiredByNativeCode]
	// RVA: 0x1E4F9C8 Offset: 0x1E4B9C8 VA: 0x1E4F9C8
	private static void BumpNonSerializedVersion(Camera cam) { }

	// RVA: 0x1E4E8D0 Offset: 0x1E4A8D0 VA: 0x1E4E8D0
	private static float get_nearClipPlane_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4E984 Offset: 0x1E4A984 VA: 0x1E4E984
	private static float get_farClipPlane_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4EA38 Offset: 0x1E4AA38 VA: 0x1E4EA38
	private static float get_orthographicSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4EAFC Offset: 0x1E4AAFC VA: 0x1E4EAFC
	private static void set_orthographicSize_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1E4EBC0 Offset: 0x1E4ABC0 VA: 0x1E4EBC0
	private static float get_depth_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4EC74 Offset: 0x1E4AC74 VA: 0x1E4EC74
	private static float get_aspect_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4ED28 Offset: 0x1E4AD28 VA: 0x1E4ED28
	private static int get_cullingMask_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4EDDC Offset: 0x1E4ADDC VA: 0x1E4EDDC
	private static int get_eventMask_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4EE90 Offset: 0x1E4AE90 VA: 0x1E4EE90
	private static CameraClearFlags get_clearFlags_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4EF60 Offset: 0x1E4AF60 VA: 0x1E4EF60
	private static void get_pixelRect_Injected(IntPtr _unity_self, out Rect ret) { }

	// RVA: 0x1E4F038 Offset: 0x1E4B038 VA: 0x1E4F038
	private static IntPtr get_targetTexture_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4F0EC Offset: 0x1E4B0EC VA: 0x1E4F0EC
	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4F1D4 Offset: 0x1E4B1D4 VA: 0x1E4F1D4
	private static void WorldToScreenPoint_Injected(IntPtr _unity_self, in Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x1E4F2DC Offset: 0x1E4B2DC VA: 0x1E4F2DC
	private static void ScreenToWorldPoint_Injected(IntPtr _unity_self, in Vector3 position, Camera.MonoOrStereoscopicEye eye, out Vector3 ret) { }

	// RVA: 0x1E4F3EC Offset: 0x1E4B3EC VA: 0x1E4F3EC
	private static void ScreenToViewportPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	// RVA: 0x1E4F4F8 Offset: 0x1E4B4F8 VA: 0x1E4F4F8
	private static void ScreenPointToRay_Injected(IntPtr _unity_self, in Vector2 pos, Camera.MonoOrStereoscopicEye eye, out Ray ret) { }

	// RVA: 0x1E4F618 Offset: 0x1E4B618 VA: 0x1E4F618
	private static IntPtr get_main_Injected() { }

	// RVA: 0x1E4F6A4 Offset: 0x1E4B6A4 VA: 0x1E4F6A4
	private static IntPtr get_currentInternal_Injected() { }

	// RVA: 0x1E4F76C Offset: 0x1E4B76C VA: 0x1E4F76C
	private static int GetAllCamerasImpl_Injected([Out] Camera[] cam) { }
}

// Namespace: UnityEngine
public struct CullingGroupEvent // TypeDefIndex: 6682
{
	// Fields
	private int m_Index; // 0x0
	private byte m_PrevState; // 0x4
	private byte m_ThisState; // 0x5
}

// Namespace: 
public sealed class CullingGroup.StateChanged : MulticastDelegate // TypeDefIndex: 6683
{
	// Methods

	// RVA: 0x1E4FB04 Offset: 0x1E4BB04 VA: 0x1E4FB04
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E4FBA4 Offset: 0x1E4BBA4 VA: 0x1E4FBA4 Slot: 12
	public virtual void Invoke(CullingGroupEvent sphere) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
public class CullingGroup // TypeDefIndex: 6684
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private CullingGroup.StateChanged m_OnStateChanged; // 0x18

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E4FAA8 Offset: 0x1E4BAA8 VA: 0x1E4FAA8
	private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count) { }
}

// Namespace: 
public enum ReflectionProbe.ReflectionProbeEvent // TypeDefIndex: 6685
{
	// Fields
	public int value__; // 0x0
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeAdded = 0;
	public const ReflectionProbe.ReflectionProbeEvent ReflectionProbeRemoved = 1;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
public sealed class ReflectionProbe : Behaviour // TypeDefIndex: 6686
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged; // 0x0
	private static Dictionary<int, Action<Texture>> registeredDefaultReflectionSetActions; // 0x8
	private static List<Action<Texture>> registeredDefaultReflectionTextureActions; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E4FBB8 Offset: 0x1E4BBB8 VA: 0x1E4FBB8
	private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent) { }

	[RequiredByNativeCode]
	// RVA: 0x1E4FC48 Offset: 0x1E4BC48 VA: 0x1E4FC48
	private static void CallSetDefaultReflection(Texture defaultReflectionCubemap) { }

	// RVA: 0x1E4FDB8 Offset: 0x1E4BDB8 VA: 0x1E4FDB8
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
internal sealed class DebugLogHandler : ILogHandler // TypeDefIndex: 6687
{
	// Methods

	[ThreadAndSerializationSafe]
	// RVA: 0x1E4FEA0 Offset: 0x1E4BEA0 VA: 0x1E4FEA0
	internal static void Internal_Log(LogType level, LogOption options, string msg, Object obj) { }

	[ThreadAndSerializationSafe]
	// RVA: 0x1E500B0 Offset: 0x1E4C0B0 VA: 0x1E500B0
	internal static void Internal_LogException(Exception ex, Object obj) { }

	// RVA: 0x1E50180 Offset: 0x1E4C180 VA: 0x1E50180 Slot: 4
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }

	// RVA: 0x1E501BC Offset: 0x1E4C1BC VA: 0x1E501BC Slot: 5
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x1E50218 Offset: 0x1E4C218 VA: 0x1E50218
	public void .ctor() { }

	// RVA: 0x1E50054 Offset: 0x1E4C054 VA: 0x1E50054
	private static void Internal_Log_Injected(LogType level, LogOption options, ref ManagedSpanWrapper msg, IntPtr obj) { }

	// RVA: 0x1E5013C Offset: 0x1E4C13C VA: 0x1E5013C
	private static void Internal_LogException_Injected(Exception ex, IntPtr obj) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Diagnostics/IntegrityCheck.h")]
[NativeHeader("Runtime/Diagnostics/Validation.h")]
[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
public class Debug // TypeDefIndex: 6688
{
	// Fields
	internal static readonly ILogger s_DefaultLogger; // 0x0
	internal static ILogger s_Logger; // 0x8

	// Properties
	public static ILogger unityLogger { get; }

	// Methods

	// RVA: 0x1E50220 Offset: 0x1E4C220 VA: 0x1E50220
	public static ILogger get_unityLogger() { }

	[ThreadSafe]
	// RVA: 0x1E50278 Offset: 0x1E4C278 VA: 0x1E50278
	public static int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder) { }

	// RVA: 0x1E5047C Offset: 0x1E4C47C VA: 0x1E5047C
	public static void Log(object message) { }

	// RVA: 0x1E50584 Offset: 0x1E4C584 VA: 0x1E50584
	public static void Log(object message, Object context) { }

	// RVA: 0x1E5069C Offset: 0x1E4C69C VA: 0x1E5069C
	public static void LogFormat(string format, object[] args) { }

	// RVA: 0x1E507B4 Offset: 0x1E4C7B4 VA: 0x1E507B4
	public static void LogError(object message) { }

	// RVA: 0x1E508BC Offset: 0x1E4C8BC VA: 0x1E508BC
	public static void LogError(object message, Object context) { }

	// RVA: 0x1E509D4 Offset: 0x1E4C9D4 VA: 0x1E509D4
	public static void LogErrorFormat(Object context, string format, object[] args) { }

	// RVA: 0x1E4DD50 Offset: 0x1E49D50 VA: 0x1E4DD50
	public static void LogException(Exception exception) { }

	// RVA: 0x1E4B47C Offset: 0x1E4747C VA: 0x1E4B47C
	public static void LogException(Exception exception, Object context) { }

	// RVA: 0x1E50AF0 Offset: 0x1E4CAF0 VA: 0x1E50AF0
	public static void LogWarning(object message) { }

	// RVA: 0x1E50BF8 Offset: 0x1E4CBF8 VA: 0x1E50BF8
	public static void LogWarning(object message, Object context) { }

	// RVA: 0x1E50D10 Offset: 0x1E4CD10 VA: 0x1E50D10
	public static void LogWarningFormat(Object context, string format, object[] args) { }

	[Conditional("UNITY_ASSERTIONS")]
	// RVA: 0x1E50E2C Offset: 0x1E4CE2C VA: 0x1E50E2C
	public static void Assert(bool condition) { }

	[RequiredByNativeCode]
	// RVA: 0x1E50F5C Offset: 0x1E4CF5C VA: 0x1E50F5C
	internal static bool CallOverridenDebugHandler(Exception exception, Object obj) { }

	[RequiredByNativeCode]
	// RVA: 0x1E5128C Offset: 0x1E4D28C VA: 0x1E5128C
	internal static bool IsLoggingEnabled() { }

	// RVA: 0x1E514B0 Offset: 0x1E4D4B0 VA: 0x1E514B0
	private static void .cctor() { }

	// RVA: 0x1E50428 Offset: 0x1E4C428 VA: 0x1E50428
	private static int ExtractStackTraceNoAlloc_Injected(byte* buffer, int bufferMax, ref ManagedSpanWrapper projectFolder) { }
}

// Namespace: UnityEngine
[PreventReadOnlyInstanceModification]
[NativeHeader("Runtime/Graphics/LightingSettings.h")]
public sealed class LightingSettings : Object // TypeDefIndex: 6689
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E5161C Offset: 0x1E4D61C VA: 0x1E5161C
	internal void LightingSettingsDontStripMe() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Geometry/Intersection.h")]
[NativeHeader("Runtime/Geometry/Ray.h")]
[NativeType(Header = "Runtime/Geometry/AABB.h")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/Geometry/AABB.h")]
[NativeClass("AABB")]
public struct Bounds : IEquatable<Bounds>, IFormattable // TypeDefIndex: 6690
{
	// Fields
	private Vector3 m_Center; // 0x0
	[NativeName("m_Extent")]
	private Vector3 m_Extents; // 0xC

	// Properties
	public Vector3 center { get; set; }
	public Vector3 size { get; set; }
	public Vector3 extents { get; set; }
	public Vector3 min { get; }
	public Vector3 max { get; }

	// Methods

	// RVA: 0x1E51620 Offset: 0x1E4D620 VA: 0x1E51620
	public void .ctor(Vector3 center, Vector3 size) { }

	// RVA: 0x1E51648 Offset: 0x1E4D648 VA: 0x1E51648 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E51710 Offset: 0x1E4D710 VA: 0x1E51710 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1E517D8 Offset: 0x1E4D7D8 VA: 0x1E517D8 Slot: 4
	public bool Equals(Bounds other) { }

	// RVA: 0x1E5182C Offset: 0x1E4D82C VA: 0x1E5182C
	public Vector3 get_center() { }

	// RVA: 0x1E51838 Offset: 0x1E4D838 VA: 0x1E51838
	public void set_center(Vector3 value) { }

	// RVA: 0x1E51844 Offset: 0x1E4D844 VA: 0x1E51844
	public Vector3 get_size() { }

	// RVA: 0x1E5185C Offset: 0x1E4D85C VA: 0x1E5185C
	public void set_size(Vector3 value) { }

	// RVA: 0x1E5187C Offset: 0x1E4D87C VA: 0x1E5187C
	public Vector3 get_extents() { }

	// RVA: 0x1E51888 Offset: 0x1E4D888 VA: 0x1E51888
	public void set_extents(Vector3 value) { }

	// RVA: 0x1E51894 Offset: 0x1E4D894 VA: 0x1E51894
	public Vector3 get_min() { }

	// RVA: 0x1E518B4 Offset: 0x1E4D8B4 VA: 0x1E518B4
	public Vector3 get_max() { }

	// RVA: 0x1E518D4 Offset: 0x1E4D8D4 VA: 0x1E518D4
	public static bool op_Equality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x1E51948 Offset: 0x1E4D948 VA: 0x1E51948
	public static bool op_Inequality(Bounds lhs, Bounds rhs) { }

	// RVA: 0x1E519C0 Offset: 0x1E4D9C0 VA: 0x1E519C0
	public void SetMinMax(Vector3 min, Vector3 max) { }

	// RVA: 0x1E519F8 Offset: 0x1E4D9F8 VA: 0x1E519F8
	public void Encapsulate(Vector3 point) { }

	// RVA: 0x1E51A70 Offset: 0x1E4DA70 VA: 0x1E51A70 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E51A80 Offset: 0x1E4DA80 VA: 0x1E51A80 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct Plane : IFormattable // TypeDefIndex: 6691
{
	// Fields
	private Vector3 m_Normal; // 0x0
	private float m_Distance; // 0xC

	// Properties
	public Vector3 normal { get; }

	// Methods

	// RVA: 0x1E51C20 Offset: 0x1E4DC20 VA: 0x1E51C20
	public Vector3 get_normal() { }

	// RVA: 0x1E51C2C Offset: 0x1E4DC2C VA: 0x1E51C2C
	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x1E51D3C Offset: 0x1E4DD3C VA: 0x1E51D3C
	public bool Raycast(Ray ray, out float enter) { }

	// RVA: 0x1E51E3C Offset: 0x1E4DE3C VA: 0x1E51E3C Slot: 3
	public override string ToString() { }

	// RVA: 0x1E51E4C Offset: 0x1E4DE4C VA: 0x1E51E4C Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine
public struct Ray : IFormattable // TypeDefIndex: 6692
{
	// Fields
	private Vector3 m_Origin; // 0x0
	private Vector3 m_Direction; // 0xC

	// Properties
	public Vector3 origin { get; }
	public Vector3 direction { get; }

	// Methods

	// RVA: 0x1E51FEC Offset: 0x1E4DFEC VA: 0x1E51FEC
	public void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x1E520E4 Offset: 0x1E4E0E4 VA: 0x1E520E4
	public Vector3 get_origin() { }

	// RVA: 0x1E520F0 Offset: 0x1E4E0F0 VA: 0x1E520F0
	public Vector3 get_direction() { }

	// RVA: 0x1E520FC Offset: 0x1E4E0FC VA: 0x1E520FC
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x1E52124 Offset: 0x1E4E124 VA: 0x1E52124 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E52134 Offset: 0x1E4E134 VA: 0x1E52134 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine
public struct Ray2D : IFormattable // TypeDefIndex: 6693
{
	// Fields
	private Vector2 m_Origin; // 0x0
	private Vector2 m_Direction; // 0x8

	// Methods

	// RVA: 0x1E522D4 Offset: 0x1E4E2D4 VA: 0x1E522D4 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E522E4 Offset: 0x1E4E2E4 VA: 0x1E522E4 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: UnityEngine
[NativeClass("Rectf", "template<typename T> class RectT; typedef RectT<float> Rectf;")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/Math/Rect.h")]
public struct Rect : IEquatable<Rect>, IFormattable // TypeDefIndex: 6694
{
	// Fields
	[NativeName("x")]
	private float m_XMin; // 0x0
	[NativeName("y")]
	private float m_YMin; // 0x4
	[NativeName("width")]
	private float m_Width; // 0x8
	[NativeName("height")]
	private float m_Height; // 0xC

	// Properties
	public static Rect zero { get; }
	public float x { get; set; }
	public float y { get; set; }
	public Vector2 position { get; }
	public Vector2 center { get; }
	public Vector2 min { get; }
	public Vector2 max { get; }
	public float width { get; set; }
	public float height { get; set; }
	public Vector2 size { get; }
	public float xMin { get; set; }
	public float yMin { get; set; }
	public float xMax { get; set; }
	public float yMax { get; set; }

	// Methods

	// RVA: 0x1E52484 Offset: 0x1E4E484 VA: 0x1E52484
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x1E52490 Offset: 0x1E4E490 VA: 0x1E52490
	public void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x1E5249C Offset: 0x1E4E49C VA: 0x1E5249C
	public static Rect get_zero() { }

	// RVA: 0x1E524B0 Offset: 0x1E4E4B0 VA: 0x1E524B0
	public float get_x() { }

	// RVA: 0x1E524B8 Offset: 0x1E4E4B8 VA: 0x1E524B8
	public void set_x(float value) { }

	// RVA: 0x1E524C0 Offset: 0x1E4E4C0 VA: 0x1E524C0
	public float get_y() { }

	// RVA: 0x1E524C8 Offset: 0x1E4E4C8 VA: 0x1E524C8
	public void set_y(float value) { }

	// RVA: 0x1E524D0 Offset: 0x1E4E4D0 VA: 0x1E524D0
	public Vector2 get_position() { }

	// RVA: 0x1E524D8 Offset: 0x1E4E4D8 VA: 0x1E524D8
	public Vector2 get_center() { }

	// RVA: 0x1E524F0 Offset: 0x1E4E4F0 VA: 0x1E524F0
	public Vector2 get_min() { }

	// RVA: 0x1E524F8 Offset: 0x1E4E4F8 VA: 0x1E524F8
	public Vector2 get_max() { }

	// RVA: 0x1E52508 Offset: 0x1E4E508 VA: 0x1E52508
	public float get_width() { }

	// RVA: 0x1E52510 Offset: 0x1E4E510 VA: 0x1E52510
	public void set_width(float value) { }

	// RVA: 0x1E52518 Offset: 0x1E4E518 VA: 0x1E52518
	public float get_height() { }

	// RVA: 0x1E52520 Offset: 0x1E4E520 VA: 0x1E52520
	public void set_height(float value) { }

	// RVA: 0x1E52528 Offset: 0x1E4E528 VA: 0x1E52528
	public Vector2 get_size() { }

	// RVA: 0x1E52530 Offset: 0x1E4E530 VA: 0x1E52530
	public float get_xMin() { }

	// RVA: 0x1E52538 Offset: 0x1E4E538 VA: 0x1E52538
	public void set_xMin(float value) { }

	// RVA: 0x1E52554 Offset: 0x1E4E554 VA: 0x1E52554
	public float get_yMin() { }

	// RVA: 0x1E5255C Offset: 0x1E4E55C VA: 0x1E5255C
	public void set_yMin(float value) { }

	// RVA: 0x1E52578 Offset: 0x1E4E578 VA: 0x1E52578
	public float get_xMax() { }

	// RVA: 0x1E52588 Offset: 0x1E4E588 VA: 0x1E52588
	public void set_xMax(float value) { }

	// RVA: 0x1E52598 Offset: 0x1E4E598 VA: 0x1E52598
	public float get_yMax() { }

	// RVA: 0x1E525A8 Offset: 0x1E4E5A8 VA: 0x1E525A8
	public void set_yMax(float value) { }

	// RVA: 0x1E525B8 Offset: 0x1E4E5B8 VA: 0x1E525B8
	public bool Contains(Vector3 point) { }

	// RVA: 0x1E525FC Offset: 0x1E4E5FC VA: 0x1E525FC
	private static Rect OrderMinMax(Rect rect) { }

	// RVA: 0x1E52628 Offset: 0x1E4E628 VA: 0x1E52628
	public bool Overlaps(Rect other) { }

	// RVA: 0x1E52674 Offset: 0x1E4E674 VA: 0x1E52674
	public bool Overlaps(Rect other, bool allowInverse) { }

	// RVA: 0x1E52704 Offset: 0x1E4E704 VA: 0x1E52704
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x1E5272C Offset: 0x1E4E72C VA: 0x1E5272C
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x1E52754 Offset: 0x1E4E754 VA: 0x1E52754 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E527DC Offset: 0x1E4E7DC VA: 0x1E527DC Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1E528C8 Offset: 0x1E4E8C8 VA: 0x1E528C8 Slot: 4
	public bool Equals(Rect other) { }

	// RVA: 0x1E52968 Offset: 0x1E4E968 VA: 0x1E52968 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E52974 Offset: 0x1E4E974 VA: 0x1E52974 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: 
internal static class RectOffset.BindingsMarshaller // TypeDefIndex: 6695
{
	// Methods

	// RVA: 0x1E53444 Offset: 0x1E4F444 VA: 0x1E53444
	public static IntPtr ConvertToNative(RectOffset rectOffset) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/IMGUI/GUIStyle.h")]
[Serializable]
public class RectOffset : IFormattable // TypeDefIndex: 6696
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	internal IntPtr m_Ptr; // 0x10
	private readonly object m_SourceStyle; // 0x18

	// Properties
	[NativeProperty("left", False, 1)]
	public int left { get; }
	[NativeProperty("right", False, 1)]
	public int right { get; }
	[NativeProperty("top", False, 1)]
	public int top { get; }
	[NativeProperty("bottom", False, 1)]
	public int bottom { get; }
	public int horizontal { get; }
	public int vertical { get; }

	// Methods

	// RVA: 0x1E52BDC Offset: 0x1E4EBDC VA: 0x1E52BDC
	public void .ctor() { }

	[VisibleToOtherModules(new[] { "UnityEngine.IMGUIModule" })]
	// RVA: 0x1E52C48 Offset: 0x1E4EC48 VA: 0x1E52C48
	internal void .ctor(object sourceStyle, IntPtr source) { }

	// RVA: 0x1E52C84 Offset: 0x1E4EC84 VA: 0x1E52C84 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1E52D98 Offset: 0x1E4ED98 VA: 0x1E52D98 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E52DA8 Offset: 0x1E4EDA8 VA: 0x1E52DA8 Slot: 4
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1E52D4C Offset: 0x1E4ED4C VA: 0x1E52D4C
	private void Destroy() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x1E52C20 Offset: 0x1E4EC20 VA: 0x1E52C20
	private static IntPtr InternalCreate() { }

	[ThreadAndSerializationSafe]
	// RVA: 0x1E53134 Offset: 0x1E4F134 VA: 0x1E53134
	private static void InternalDestroy(IntPtr ptr) { }

	// RVA: 0x1E52FF4 Offset: 0x1E4EFF4 VA: 0x1E52FF4
	public int get_left() { }

	// RVA: 0x1E53044 Offset: 0x1E4F044 VA: 0x1E53044
	public int get_right() { }

	// RVA: 0x1E53094 Offset: 0x1E4F094 VA: 0x1E53094
	public int get_top() { }

	// RVA: 0x1E530E4 Offset: 0x1E4F0E4 VA: 0x1E530E4
	public int get_bottom() { }

	// RVA: 0x1E53260 Offset: 0x1E4F260 VA: 0x1E53260
	public int get_horizontal() { }

	// RVA: 0x1E532EC Offset: 0x1E4F2EC VA: 0x1E532EC
	public int get_vertical() { }

	// RVA: 0x1E53378 Offset: 0x1E4F378 VA: 0x1E53378
	public Rect Remove(Rect rect) { }

	// RVA: 0x1E53170 Offset: 0x1E4F170 VA: 0x1E53170
	private static int get_left_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E531AC Offset: 0x1E4F1AC VA: 0x1E531AC
	private static int get_right_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E531E8 Offset: 0x1E4F1E8 VA: 0x1E531E8
	private static int get_top_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E53224 Offset: 0x1E4F224 VA: 0x1E53224
	private static int get_bottom_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E532B0 Offset: 0x1E4F2B0 VA: 0x1E532B0
	private static int get_horizontal_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E5333C Offset: 0x1E4F33C VA: 0x1E5333C
	private static int get_vertical_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E533F0 Offset: 0x1E4F3F0 VA: 0x1E533F0
	private static void Remove_Injected(IntPtr _unity_self, in Rect rect, out Rect ret) { }
}

// Namespace: 
private struct BeforeRenderHelper.OrderBlock // TypeDefIndex: 6697
{
	// Fields
	internal int order; // 0x0
	internal UnityAction callback; // 0x8
}

// Namespace: UnityEngine
internal static class BeforeRenderHelper // TypeDefIndex: 6698
{
	// Fields
	private static List<BeforeRenderHelper.OrderBlock> s_OrderBlocks; // 0x0

	// Methods

	// RVA: 0x1E4E118 Offset: 0x1E4A118 VA: 0x1E4E118
	public static void Invoke() { }

	// RVA: 0x1E53458 Offset: 0x1E4F458 VA: 0x1E53458
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/CustomRenderTextureManager.h")]
public static class CustomRenderTextureManager // TypeDefIndex: 6699
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<CustomRenderTexture> textureLoaded; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<CustomRenderTexture> textureUnloaded; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E534F0 Offset: 0x1E4F4F0 VA: 0x1E534F0
	private static void InvokeOnTextureLoaded_Internal(CustomRenderTexture source) { }

	[RequiredByNativeCode]
	// RVA: 0x1E5355C Offset: 0x1E4F55C VA: 0x1E5355C
	private static void InvokeOnTextureUnloaded_Internal(CustomRenderTexture source) { }
}

// Namespace: 
public sealed class Display.DisplaysUpdatedDelegate : MulticastDelegate // TypeDefIndex: 6700
{
	// Methods

	// RVA: 0x1E53E0C Offset: 0x1E4FE0C VA: 0x1E53E0C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E53EA8 Offset: 0x1E4FEA8 VA: 0x1E53EA8 Slot: 12
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/DisplayManager.h")]
[UsedByNativeCode]
public class Display // TypeDefIndex: 6701
{
	// Fields
	internal IntPtr nativeDisplay; // 0x10
	public static Display[] displays; // 0x0
	private static Display _mainDisplay; // 0x8
	private static int m_ActiveEditorGameViewTarget; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Display.DisplaysUpdatedDelegate onDisplaysUpdated; // 0x18

	// Properties
	public int renderingWidth { get; }
	public int renderingHeight { get; }
	public int systemWidth { get; }
	public int systemHeight { get; }
	public static Display main { get; }

	// Methods

	// RVA: 0x1E535C8 Offset: 0x1E4F5C8 VA: 0x1E535C8
	internal void .ctor() { }

	// RVA: 0x1E53604 Offset: 0x1E4F604 VA: 0x1E53604
	internal void .ctor(IntPtr nativeDisplay) { }

	// RVA: 0x1E5362C Offset: 0x1E4F62C VA: 0x1E5362C
	public int get_renderingWidth() { }

	// RVA: 0x1E53714 Offset: 0x1E4F714 VA: 0x1E53714
	public int get_renderingHeight() { }

	// RVA: 0x1E537A8 Offset: 0x1E4F7A8 VA: 0x1E537A8
	public int get_systemWidth() { }

	// RVA: 0x1E53890 Offset: 0x1E4F890 VA: 0x1E53890
	public int get_systemHeight() { }

	// RVA: 0x1E53924 Offset: 0x1E4F924 VA: 0x1E53924
	public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates) { }

	// RVA: 0x1E53A40 Offset: 0x1E4FA40 VA: 0x1E53A40
	public static Display get_main() { }

	[RequiredByNativeCode]
	// RVA: 0x1E53A98 Offset: 0x1E4FA98 VA: 0x1E53A98
	internal static void RecreateDisplayList(IntPtr[] nativeDisplay) { }

	[RequiredByNativeCode]
	// RVA: 0x1E53C3C Offset: 0x1E4FC3C VA: 0x1E53C3C
	internal static void FireDisplaysUpdated() { }

	[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
	// RVA: 0x1E5383C Offset: 0x1E4F83C VA: 0x1E5383C
	private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunction("UnityDisplayManager_DisplayRenderingResolution")]
	// RVA: 0x1E536C0 Offset: 0x1E4F6C0 VA: 0x1E536C0
	private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h) { }

	[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
	// RVA: 0x1E539E4 Offset: 0x1E4F9E4 VA: 0x1E539E4
	private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry) { }

	// RVA: 0x1E53CD0 Offset: 0x1E4FCD0 VA: 0x1E53CD0
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeType("Runtime/Graphics/RefreshRate.h")]
public struct RefreshRate : IEquatable<RefreshRate>, IComparable<RefreshRate> // TypeDefIndex: 6702
{
	// Fields
	public uint numerator; // 0x0
	public uint denominator; // 0x4

	// Properties
	public double value { get; }

	// Methods

	// RVA: 0x1E53EBC Offset: 0x1E4FEBC VA: 0x1E53EBC
	public double get_value() { }

	// RVA: 0x1E53ED0 Offset: 0x1E4FED0 VA: 0x1E53ED0 Slot: 4
	public bool Equals(RefreshRate other) { }

	// RVA: 0x1E53F0C Offset: 0x1E4FF0C VA: 0x1E53F0C Slot: 5
	public int CompareTo(RefreshRate other) { }

	// RVA: 0x1E53F5C Offset: 0x1E4FF5C VA: 0x1E53F5C Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine
[StaticAccessor("GetScreenManager()", 0)]
[NativeHeader("Runtime/Graphics/WindowLayout.h")]
[NativeHeader("Runtime/Graphics/ScreenManager.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
public sealed class Screen // TypeDefIndex: 6703
{
	// Properties
	public static int width { get; }
	public static int height { get; }
	public static float dpi { get; }
	public static ScreenOrientation orientation { get; }
	[NativeProperty("ScreenTimeout")]
	public static int sleepTimeout { set; }
	public static bool fullScreen { get; }
	public static Rect safeArea { get; }

	// Methods

	[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
	// RVA: 0x1E53FF8 Offset: 0x1E4FFF8 VA: 0x1E53FF8
	public static int get_width() { }

	[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
	// RVA: 0x1E54020 Offset: 0x1E50020 VA: 0x1E54020
	public static int get_height() { }

	[NativeName("GetDPI")]
	// RVA: 0x1E54048 Offset: 0x1E50048 VA: 0x1E54048
	public static float get_dpi() { }

	// RVA: 0x1E54070 Offset: 0x1E50070 VA: 0x1E54070
	private static ScreenOrientation GetScreenOrientation() { }

	// RVA: 0x1E54098 Offset: 0x1E50098 VA: 0x1E54098
	public static ScreenOrientation get_orientation() { }

	// RVA: 0x1E540C0 Offset: 0x1E500C0 VA: 0x1E540C0
	public static void set_sleepTimeout(int value) { }

	[NativeName("IsFullscreen")]
	// RVA: 0x1E540FC Offset: 0x1E500FC VA: 0x1E540FC
	public static bool get_fullScreen() { }

	// RVA: 0x1E54124 Offset: 0x1E50124 VA: 0x1E54124
	public static Rect get_safeArea() { }

	// RVA: 0x1E5416C Offset: 0x1E5016C VA: 0x1E5416C
	private static void get_safeArea_Injected(out Rect ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/CopyTexture.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
public class Graphics // TypeDefIndex: 6704
{
	// Fields
	internal static readonly int kMaxDrawMeshInstanceCount; // 0x0
	internal static Dictionary<int, RenderInstancedDataLayout> s_RenderInstancedDataLayouts; // 0x8

	// Methods

	[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount", IsThreadSafe = True)]
	// RVA: 0x1E541A8 Offset: 0x1E501A8 VA: 0x1E541A8
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[FreeFunction("GraphicsScripting::BlitMaterial")]
	// RVA: 0x1E541D0 Offset: 0x1E501D0 VA: 0x1E541D0
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	// RVA: 0x1E54394 Offset: 0x1E50394 VA: 0x1E54394
	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	// RVA: 0x1E54414 Offset: 0x1E50414 VA: 0x1E54414
	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	// RVA: 0x1E54484 Offset: 0x1E50484 VA: 0x1E54484
	private static void .cctor() { }

	// RVA: 0x1E54328 Offset: 0x1E50328 VA: 0x1E54328
	private static void Internal_BlitMaterial5_Injected(IntPtr source, IntPtr dest, IntPtr mat, int pass, bool setRT) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/LightmapSettings.h")]
[StaticAccessor("GetLightmapSettings()")]
public sealed class LightmapSettings : Object // TypeDefIndex: 6705
{}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Graphics/Graphics.bindings.h")]
public sealed class LightProbes : Object // TypeDefIndex: 6706
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action lightProbesUpdated; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action tetrahedralizationCompleted; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action needsRetetrahedralization; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E54544 Offset: 0x1E50544 VA: 0x1E54544
	private static void Internal_CallLightProbesUpdatedFunction() { }

	[RequiredByNativeCode]
	// RVA: 0x1E545A8 Offset: 0x1E505A8 VA: 0x1E545A8
	private static void Internal_CallTetrahedralizationCompletedFunction() { }

	[RequiredByNativeCode]
	// RVA: 0x1E5460C Offset: 0x1E5060C VA: 0x1E5460C
	private static void Internal_CallNeedsRetetrahedralizationFunction() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public struct Resolution // TypeDefIndex: 6707
{
	// Fields
	private int m_Width; // 0x0
	private int m_Height; // 0x4
	private RefreshRate m_RefreshRate; // 0x8

	// Methods

	// RVA: 0x1E54670 Offset: 0x1E50670 VA: 0x1E54670 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine
[IsReadOnly]
internal struct RenderInstancedDataLayout // TypeDefIndex: 6708
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly int <size>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <offsetObjectToWorld>k__BackingField; // 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <offsetPrevObjectToWorld>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <offsetRenderingLayerMask>k__BackingField; // 0xC
}

// Namespace: UnityEngine
[StaticAccessor("GetQualitySettings()", 0)]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/QualitySettings.h")]
public sealed class QualitySettings : Object // TypeDefIndex: 6709
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<int, int> activeQualityLevelChanged; // 0x0

	// Properties
	public static ColorSpace activeColorSpace { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E54808 Offset: 0x1E50808 VA: 0x1E54808
	internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel) { }

	[NativeName("GetColorSpace")]
	[StaticAccessor("GetPlayerSettings()", 0)]
	// RVA: 0x1E54888 Offset: 0x1E50888 VA: 0x1E54888
	public static ColorSpace get_activeColorSpace() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/LineRenderer.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
public sealed class LineRenderer : Renderer // TypeDefIndex: 6710
{
	// Properties
	public float startWidth { set; }
	public float endWidth { set; }
	public bool useWorldSpace { set; }
	public Color startColor { set; }
	public Color endColor { set; }
	[NativeProperty("PositionsCount")]
	public int positionCount { set; }

	// Methods

	// RVA: 0x1E548B0 Offset: 0x1E508B0 VA: 0x1E548B0
	public void set_startWidth(float value) { }

	// RVA: 0x1E54984 Offset: 0x1E50984 VA: 0x1E54984
	public void set_endWidth(float value) { }

	// RVA: 0x1E54A58 Offset: 0x1E50A58 VA: 0x1E54A58
	public void set_useWorldSpace(bool value) { }

	// RVA: 0x1E54B1C Offset: 0x1E50B1C VA: 0x1E54B1C
	public void set_startColor(Color value) { }

	// RVA: 0x1E54BF0 Offset: 0x1E50BF0 VA: 0x1E54BF0
	public void set_endColor(Color value) { }

	// RVA: 0x1E54CC4 Offset: 0x1E50CC4 VA: 0x1E54CC4
	public void set_positionCount(int value) { }

	[FreeFunction(Name = "LineRendererScripting::SetPositions", HasExplicitThis = True)]
	// RVA: 0x1E54D88 Offset: 0x1E50D88 VA: 0x1E54D88
	public void SetPositions(Vector3[] positions) { }

	// RVA: 0x1E54EF0 Offset: 0x1E50EF0 VA: 0x1E54EF0
	public void .ctor() { }

	// RVA: 0x1E54938 Offset: 0x1E50938 VA: 0x1E54938
	private static void set_startWidth_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1E54A0C Offset: 0x1E50A0C VA: 0x1E54A0C
	private static void set_endWidth_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1E54AD8 Offset: 0x1E50AD8 VA: 0x1E54AD8
	private static void set_useWorldSpace_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1E54BAC Offset: 0x1E50BAC VA: 0x1E54BAC
	private static void set_startColor_Injected(IntPtr _unity_self, in Color value) { }

	// RVA: 0x1E54C80 Offset: 0x1E50C80 VA: 0x1E54C80
	private static void set_endColor_Injected(IntPtr _unity_self, in Color value) { }

	// RVA: 0x1E54D44 Offset: 0x1E50D44 VA: 0x1E54D44
	private static void set_positionCount_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1E54EAC Offset: 0x1E50EAC VA: 0x1E54EAC
	private static void SetPositions_Injected(IntPtr _unity_self, ref ManagedSpanWrapper positions) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/Renderer.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[RequireComponent(typeof(Transform))]
public class Renderer : Component // TypeDefIndex: 6711
{
	// Properties
	public bool enabled { get; set; }
	public ShadowCastingMode shadowCastingMode { set; }
	public bool receiveShadows { set; }
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }
	internal int sortingGroupID { get; }
	internal int sortingGroupOrder { get; }
	public Material material { get; }
	public Material sharedMaterial { get; set; }

	// Methods

	[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = True)]
	// RVA: 0x1E54EF8 Offset: 0x1E50EF8 VA: 0x1E54EF8
	private Material GetMaterial() { }

	[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = True)]
	// RVA: 0x1E54FC8 Offset: 0x1E50FC8 VA: 0x1E54FC8
	private Material GetSharedMaterial() { }

	[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = True)]
	// RVA: 0x1E55098 Offset: 0x1E51098 VA: 0x1E55098
	private void SetMaterial(Material m) { }

	// RVA: 0x1E55190 Offset: 0x1E51190 VA: 0x1E55190
	public bool get_enabled() { }

	// RVA: 0x1E55244 Offset: 0x1E51244 VA: 0x1E55244
	public void set_enabled(bool value) { }

	// RVA: 0x1E55308 Offset: 0x1E51308 VA: 0x1E55308
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x1E553CC Offset: 0x1E513CC VA: 0x1E553CC
	public void set_receiveShadows(bool value) { }

	// RVA: 0x1E55490 Offset: 0x1E51490 VA: 0x1E55490
	public int get_sortingLayerID() { }

	// RVA: 0x1E55544 Offset: 0x1E51544 VA: 0x1E55544
	public void set_sortingLayerID(int value) { }

	// RVA: 0x1E55608 Offset: 0x1E51608 VA: 0x1E55608
	public int get_sortingOrder() { }

	// RVA: 0x1E556BC Offset: 0x1E516BC VA: 0x1E556BC
	public void set_sortingOrder(int value) { }

	// RVA: 0x1E55780 Offset: 0x1E51780 VA: 0x1E55780
	internal int get_sortingGroupID() { }

	// RVA: 0x1E55834 Offset: 0x1E51834 VA: 0x1E55834
	internal int get_sortingGroupOrder() { }

	// RVA: 0x1E558E8 Offset: 0x1E518E8 VA: 0x1E558E8
	public Material get_material() { }

	// RVA: 0x1E558EC Offset: 0x1E518EC VA: 0x1E558EC
	public Material get_sharedMaterial() { }

	// RVA: 0x1E558F0 Offset: 0x1E518F0 VA: 0x1E558F0
	public void set_sharedMaterial(Material value) { }

	// RVA: 0x1E4BA98 Offset: 0x1E47A98 VA: 0x1E4BA98
	public void .ctor() { }

	// RVA: 0x1E54F8C Offset: 0x1E50F8C VA: 0x1E54F8C
	private static IntPtr GetMaterial_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E5505C Offset: 0x1E5105C VA: 0x1E5505C
	private static IntPtr GetSharedMaterial_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E5514C Offset: 0x1E5114C VA: 0x1E5514C
	private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr m) { }

	// RVA: 0x1E55208 Offset: 0x1E51208 VA: 0x1E55208
	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E552C4 Offset: 0x1E512C4 VA: 0x1E552C4
	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1E55388 Offset: 0x1E51388 VA: 0x1E55388
	private static void set_shadowCastingMode_Injected(IntPtr _unity_self, ShadowCastingMode value) { }

	// RVA: 0x1E5544C Offset: 0x1E5144C VA: 0x1E5544C
	private static void set_receiveShadows_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1E55508 Offset: 0x1E51508 VA: 0x1E55508
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E555C4 Offset: 0x1E515C4 VA: 0x1E555C4
	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1E55680 Offset: 0x1E51680 VA: 0x1E55680
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E5573C Offset: 0x1E5173C VA: 0x1E5573C
	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1E557F8 Offset: 0x1E517F8 VA: 0x1E557F8
	private static int get_sortingGroupID_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E558AC Offset: 0x1E518AC VA: 0x1E558AC
	private static int get_sortingGroupOrder_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[StaticAccessor("GetRenderSettings()", 0)]
[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
[NativeHeader("Runtime/Camera/RenderSettings.h")]
public sealed class RenderSettings : Object // TypeDefIndex: 6712
{}

// Namespace: UnityEngine
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
[NativeHeader("Runtime/Shaders/GpuPrograms/ShaderVariantCollection.h")]
[NativeHeader("Runtime/Shaders/ShaderNameRegistry.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Misc/ResourceManager.h")]
public sealed class Shader : Object // TypeDefIndex: 6713
{
	// Properties
	public static string globalRenderPipeline { set; }

	// Methods

	// RVA: 0x1E558F4 Offset: 0x1E518F4 VA: 0x1E558F4
	public static Shader Find(string name) { }

	// RVA: 0x1E55960 Offset: 0x1E51960 VA: 0x1E55960
	public static void set_globalRenderPipeline(string value) { }

	[FreeFunction("ShaderScripting::TagToID")]
	// RVA: 0x1E55B04 Offset: 0x1E51B04 VA: 0x1E55B04
	internal static int TagToID(string name) { }

	[FreeFunction(Name = "ShaderScripting::PropertyToID", IsThreadSafe = True)]
	// RVA: 0x1E55CB0 Offset: 0x1E51CB0 VA: 0x1E55CB0
	public static int PropertyToID(string name) { }

	// RVA: 0x1E55AC8 Offset: 0x1E51AC8 VA: 0x1E55AC8
	private static void set_globalRenderPipeline_Injected(ref ManagedSpanWrapper value) { }

	// RVA: 0x1E55C74 Offset: 0x1E51C74 VA: 0x1E55C74
	private static int TagToID_Injected(ref ManagedSpanWrapper name) { }

	// RVA: 0x1E55E20 Offset: 0x1E51E20 VA: 0x1E55E20
	private static int PropertyToID_Injected(ref ManagedSpanWrapper name) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[NativeHeader("Runtime/Shaders/Material.h")]
public class Material : Object // TypeDefIndex: 6714
{
	// Fields
	private static readonly int k_ColorId; // 0x0
	private static readonly int k_MainTexId; // 0x4

	// Properties
	public Shader shader { get; set; }
	public Texture mainTexture { get; }
	public string[] shaderKeywords { get; set; }

	// Methods

	[FreeFunction("MaterialScripting::CreateWithShader")]
	// RVA: 0x1E55E5C Offset: 0x1E51E5C VA: 0x1E55E5C
	private static void CreateWithShader(Material self, Shader shader) { }

	[FreeFunction("MaterialScripting::CreateWithMaterial")]
	// RVA: 0x1E55F7C Offset: 0x1E51F7C VA: 0x1E55F7C
	private static void CreateWithMaterial(Material self, Material source) { }

	[FreeFunction("MaterialScripting::CreateWithString")]
	// RVA: 0x1E5609C Offset: 0x1E5209C VA: 0x1E5609C
	private static void CreateWithString(Material self) { }

	// RVA: 0x1E560D8 Offset: 0x1E520D8 VA: 0x1E560D8
	public void .ctor(Shader shader) { }

	[RequiredByNativeCode]
	// RVA: 0x1E5616C Offset: 0x1E5216C VA: 0x1E5616C
	public void .ctor(Material source) { }

	[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", False)]
	[EditorBrowsable(1)]
	// RVA: 0x1E56200 Offset: 0x1E52200 VA: 0x1E56200
	public void .ctor(string contents) { }

	// RVA: 0x1E562A4 Offset: 0x1E522A4 VA: 0x1E562A4
	public Shader get_shader() { }

	// RVA: 0x1E56398 Offset: 0x1E52398 VA: 0x1E56398
	public void set_shader(Shader value) { }

	// RVA: 0x1E564B4 Offset: 0x1E524B4 VA: 0x1E564B4
	public Texture get_mainTexture() { }

	[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
	// RVA: 0x1E56528 Offset: 0x1E52528 VA: 0x1E56528
	private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag) { }

	[NativeName("HasPropertyFromScript")]
	// RVA: 0x1E5661C Offset: 0x1E5261C VA: 0x1E5661C
	public bool HasProperty(int nameID) { }

	// RVA: 0x1E5670C Offset: 0x1E5270C VA: 0x1E5670C
	public bool HasProperty(string name) { }

	[NativeName("HasFloatFromScript")]
	// RVA: 0x1E5672C Offset: 0x1E5272C VA: 0x1E5672C
	private bool HasFloatImpl(int name) { }

	// RVA: 0x1E5681C Offset: 0x1E5281C VA: 0x1E5681C
	public bool HasFloat(int nameID) { }

	// RVA: 0x1E56820 Offset: 0x1E52820 VA: 0x1E56820
	public void EnableKeyword(string keyword) { }

	// RVA: 0x1E56A24 Offset: 0x1E52A24 VA: 0x1E56A24
	public void DisableKeyword(string keyword) { }

	[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = True)]
	// RVA: 0x1E56C28 Offset: 0x1E52C28 VA: 0x1E56C28
	public void CopyPropertiesFromMaterial(Material mat) { }

	[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = True)]
	// RVA: 0x1E56D44 Offset: 0x1E52D44 VA: 0x1E56D44
	private string[] GetShaderKeywords() { }

	[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = True)]
	// RVA: 0x1E56E1C Offset: 0x1E52E1C VA: 0x1E56E1C
	private void SetShaderKeywords(string[] names) { }

	// RVA: 0x1E56F0C Offset: 0x1E52F0C VA: 0x1E56F0C
	public string[] get_shaderKeywords() { }

	// RVA: 0x1E56F10 Offset: 0x1E52F10 VA: 0x1E56F10
	public void set_shaderKeywords(string[] value) { }

	// RVA: 0x1E56F14 Offset: 0x1E52F14 VA: 0x1E56F14
	public int ComputeCRC() { }

	[NativeName("SetFloatFromScript")]
	// RVA: 0x1E56FEC Offset: 0x1E52FEC VA: 0x1E56FEC
	private void SetFloatImpl(int name, float value) { }

	[NativeName("SetColorFromScript")]
	// RVA: 0x1E570FC Offset: 0x1E530FC VA: 0x1E570FC
	private void SetColorImpl(int name, Color value) { }

	[NativeName("SetMatrixFromScript")]
	// RVA: 0x1E57214 Offset: 0x1E53214 VA: 0x1E57214
	private void SetMatrixImpl(int name, Matrix4x4 value) { }

	[NativeName("SetTextureFromScript")]
	// RVA: 0x1E5731C Offset: 0x1E5331C VA: 0x1E5731C
	private void SetTextureImpl(int name, Texture value) { }

	[NativeName("GetFloatFromScript")]
	// RVA: 0x1E57450 Offset: 0x1E53450 VA: 0x1E57450
	private float GetFloatImpl(int name) { }

	[NativeName("GetColorFromScript")]
	// RVA: 0x1E57540 Offset: 0x1E53540 VA: 0x1E57540
	private Color GetColorImpl(int name) { }

	[NativeName("GetTextureFromScript")]
	// RVA: 0x1E5765C Offset: 0x1E5365C VA: 0x1E5765C
	private Texture GetTextureImpl(int name) { }

	// RVA: 0x1E57768 Offset: 0x1E53768 VA: 0x1E57768
	public void SetFloat(string name, float value) { }

	// RVA: 0x1E57798 Offset: 0x1E53798 VA: 0x1E57798
	public void SetFloat(int nameID, float value) { }

	// RVA: 0x1E5779C Offset: 0x1E5379C VA: 0x1E5779C
	public void SetColor(int nameID, Color value) { }

	// RVA: 0x1E577A0 Offset: 0x1E537A0 VA: 0x1E577A0
	public void SetVector(int nameID, Vector4 value) { }

	// RVA: 0x1E577A4 Offset: 0x1E537A4 VA: 0x1E577A4
	public void SetMatrix(int nameID, Matrix4x4 value) { }

	// RVA: 0x1E577D0 Offset: 0x1E537D0 VA: 0x1E577D0
	public void SetTexture(int nameID, Texture value) { }

	// RVA: 0x1E577D4 Offset: 0x1E537D4 VA: 0x1E577D4
	public float GetFloat(string name) { }

	// RVA: 0x1E577F4 Offset: 0x1E537F4 VA: 0x1E577F4
	public float GetFloat(int nameID) { }

	// RVA: 0x1E577F8 Offset: 0x1E537F8 VA: 0x1E577F8
	public Color GetColor(int nameID) { }

	// RVA: 0x1E577FC Offset: 0x1E537FC VA: 0x1E577FC
	public Vector4 GetVector(int nameID) { }

	// RVA: 0x1E565D4 Offset: 0x1E525D4 VA: 0x1E565D4
	public Texture GetTexture(int nameID) { }

	// RVA: 0x1E57800 Offset: 0x1E53800 VA: 0x1E57800
	private static void .cctor() { }

	// RVA: 0x1E55F38 Offset: 0x1E51F38 VA: 0x1E55F38
	private static void CreateWithShader_Injected(Material self, IntPtr shader) { }

	// RVA: 0x1E56058 Offset: 0x1E52058 VA: 0x1E56058
	private static void CreateWithMaterial_Injected(Material self, IntPtr source) { }

	// RVA: 0x1E5635C Offset: 0x1E5235C VA: 0x1E5635C
	private static IntPtr get_shader_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E56470 Offset: 0x1E52470 VA: 0x1E56470
	private static void set_shader_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x1E565D8 Offset: 0x1E525D8 VA: 0x1E565D8
	private static int GetFirstPropertyNameIdByAttribute_Injected(IntPtr _unity_self, ShaderPropertyFlags attributeFlag) { }

	// RVA: 0x1E566C8 Offset: 0x1E526C8 VA: 0x1E566C8
	private static bool HasProperty_Injected(IntPtr _unity_self, int nameID) { }

	// RVA: 0x1E567D8 Offset: 0x1E527D8 VA: 0x1E567D8
	private static bool HasFloatImpl_Injected(IntPtr _unity_self, int name) { }

	// RVA: 0x1E569E0 Offset: 0x1E529E0 VA: 0x1E569E0
	private static void EnableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	// RVA: 0x1E56BE4 Offset: 0x1E52BE4 VA: 0x1E56BE4
	private static void DisableKeyword_Injected(IntPtr _unity_self, ref ManagedSpanWrapper keyword) { }

	// RVA: 0x1E56D00 Offset: 0x1E52D00 VA: 0x1E56D00
	private static void CopyPropertiesFromMaterial_Injected(IntPtr _unity_self, IntPtr mat) { }

	// RVA: 0x1E56DE0 Offset: 0x1E52DE0 VA: 0x1E56DE0
	private static string[] GetShaderKeywords_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E56EC8 Offset: 0x1E52EC8 VA: 0x1E56EC8
	private static void SetShaderKeywords_Injected(IntPtr _unity_self, string[] names) { }

	// RVA: 0x1E56FB0 Offset: 0x1E52FB0 VA: 0x1E56FB0
	private static int ComputeCRC_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E570A8 Offset: 0x1E530A8 VA: 0x1E570A8
	private static void SetFloatImpl_Injected(IntPtr _unity_self, int name, float value) { }

	// RVA: 0x1E571C0 Offset: 0x1E531C0 VA: 0x1E571C0
	private static void SetColorImpl_Injected(IntPtr _unity_self, int name, in Color value) { }

	// RVA: 0x1E572C8 Offset: 0x1E532C8 VA: 0x1E572C8
	private static void SetMatrixImpl_Injected(IntPtr _unity_self, int name, in Matrix4x4 value) { }

	// RVA: 0x1E573FC Offset: 0x1E533FC VA: 0x1E573FC
	private static void SetTextureImpl_Injected(IntPtr _unity_self, int name, IntPtr value) { }

	// RVA: 0x1E574FC Offset: 0x1E534FC VA: 0x1E574FC
	private static float GetFloatImpl_Injected(IntPtr _unity_self, int name) { }

	// RVA: 0x1E57608 Offset: 0x1E53608 VA: 0x1E57608
	private static void GetColorImpl_Injected(IntPtr _unity_self, int name, out Color ret) { }

	// RVA: 0x1E57724 Offset: 0x1E53724 VA: 0x1E57724
	private static IntPtr GetTextureImpl_Injected(IntPtr _unity_self, int name) { }
}

// Namespace: UnityEngine
[NativeClass("GfxBufferID")]
[IsReadOnly]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
public struct GraphicsBufferHandle : IEquatable<GraphicsBufferHandle> // TypeDefIndex: 6715
{
	// Fields
	public readonly uint value; // 0x0

	// Methods

	// RVA: 0x1E57898 Offset: 0x1E53898 VA: 0x1E57898 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E578A0 Offset: 0x1E538A0 VA: 0x1E578A0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E57918 Offset: 0x1E53918 VA: 0x1E57918 Slot: 4
	public bool Equals(GraphicsBufferHandle other) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/SharedLightData.h")]
public struct LightBakingOutput // TypeDefIndex: 6716
{
	// Fields
	public int probeOcclusionLightIndex; // 0x0
	public int occlusionMaskChannel; // 0x4
	[NativeName("lightmapBakeMode.lightmapBakeType")]
	public LightmapBakeType lightmapBakeType; // 0x8
	[NativeName("lightmapBakeMode.mixedLightingMode")]
	public MixedLightingMode mixedLightingMode; // 0xC
	public bool isBaked; // 0x10
}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Camera/Light.h")]
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
public sealed class Light : Behaviour // TypeDefIndex: 6717
{
	// Properties
	[NativeProperty("LightType")]
	public LightType type { get; }
	public float spotAngle { get; }
	public Color color { get; }
	public float colorTemperature { get; }
	public bool useColorTemperature { get; }
	public float intensity { get; }
	public float bounceIntensity { get; }
	public float range { get; }
	public float dilatedRange { get; }
	public LightBakingOutput bakingOutput { get; }
	public LightShadows shadows { get; }
	public float cookieSize { get; }
	public Texture cookie { get; }

	// Methods

	// RVA: 0x1E57928 Offset: 0x1E53928 VA: 0x1E57928
	public LightType get_type() { }

	// RVA: 0x1E579DC Offset: 0x1E539DC VA: 0x1E579DC
	public float get_spotAngle() { }

	// RVA: 0x1E57A90 Offset: 0x1E53A90 VA: 0x1E57A90
	public Color get_color() { }

	// RVA: 0x1E57B68 Offset: 0x1E53B68 VA: 0x1E57B68
	public float get_colorTemperature() { }

	// RVA: 0x1E57C1C Offset: 0x1E53C1C VA: 0x1E57C1C
	public bool get_useColorTemperature() { }

	// RVA: 0x1E57CD0 Offset: 0x1E53CD0 VA: 0x1E57CD0
	public float get_intensity() { }

	// RVA: 0x1E57D84 Offset: 0x1E53D84 VA: 0x1E57D84
	public float get_bounceIntensity() { }

	// RVA: 0x1E57E38 Offset: 0x1E53E38 VA: 0x1E57E38
	public float get_range() { }

	// RVA: 0x1E57EEC Offset: 0x1E53EEC VA: 0x1E57EEC
	public float get_dilatedRange() { }

	// RVA: 0x1E57FA0 Offset: 0x1E53FA0 VA: 0x1E57FA0
	public LightBakingOutput get_bakingOutput() { }

	[NativeMethod("GetShadowType")]
	// RVA: 0x1E58088 Offset: 0x1E54088 VA: 0x1E58088
	public LightShadows get_shadows() { }

	// RVA: 0x1E5813C Offset: 0x1E5413C VA: 0x1E5813C
	public float get_cookieSize() { }

	// RVA: 0x1E581F0 Offset: 0x1E541F0 VA: 0x1E581F0
	public Texture get_cookie() { }

	// RVA: 0x1E579A0 Offset: 0x1E539A0 VA: 0x1E579A0
	private static LightType get_type_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E57A54 Offset: 0x1E53A54 VA: 0x1E57A54
	private static float get_spotAngle_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E57B24 Offset: 0x1E53B24 VA: 0x1E57B24
	private static void get_color_Injected(IntPtr _unity_self, out Color ret) { }

	// RVA: 0x1E57BE0 Offset: 0x1E53BE0 VA: 0x1E57BE0
	private static float get_colorTemperature_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E57C94 Offset: 0x1E53C94 VA: 0x1E57C94
	private static bool get_useColorTemperature_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E57D48 Offset: 0x1E53D48 VA: 0x1E57D48
	private static float get_intensity_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E57DFC Offset: 0x1E53DFC VA: 0x1E57DFC
	private static float get_bounceIntensity_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E57EB0 Offset: 0x1E53EB0 VA: 0x1E57EB0
	private static float get_range_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E57F64 Offset: 0x1E53F64 VA: 0x1E57F64
	private static float get_dilatedRange_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E58044 Offset: 0x1E54044 VA: 0x1E58044
	private static void get_bakingOutput_Injected(IntPtr _unity_self, out LightBakingOutput ret) { }

	// RVA: 0x1E58100 Offset: 0x1E54100 VA: 0x1E58100
	private static LightShadows get_shadows_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E581B4 Offset: 0x1E541B4 VA: 0x1E581B4
	private static float get_cookieSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E58284 Offset: 0x1E54284 VA: 0x1E58284
	private static IntPtr get_cookie_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform))]
[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
public sealed class MeshFilter : Component // TypeDefIndex: 6718
{
	// Properties
	public Mesh sharedMesh { set; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E582C0 Offset: 0x1E542C0 VA: 0x1E582C0
	private void DontStripMeshFilter() { }

	// RVA: 0x1E582C4 Offset: 0x1E542C4 VA: 0x1E582C4
	public void set_sharedMesh(Mesh value) { }

	// RVA: 0x1E583BC Offset: 0x1E543BC VA: 0x1E583BC
	public void .ctor() { }

	// RVA: 0x1E58378 Offset: 0x1E54378 VA: 0x1E58378
	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }
}

// Namespace: UnityEngine
public enum LightType // TypeDefIndex: 6719
{
	// Fields
	public int value__; // 0x0
	public const LightType Spot = 0;
	public const LightType Directional = 1;
	public const LightType Point = 2;
	[Obsolete("Enum member LightType.Area has been deprecated. Use LightType.Rectangle instead (UnityUpgradable) -> Rectangle", True)]
	public const LightType Area = 3;
	public const LightType Rectangle = 3;
	public const LightType Disc = 4;
	public const LightType Pyramid = 5;
	public const LightType Box = 6;
	public const LightType Tube = 7;
}

// Namespace: UnityEngine
public enum LightShadows // TypeDefIndex: 6720
{
	// Fields
	public int value__; // 0x0
	public const LightShadows None = 0;
	public const LightShadows Hard = 1;
	public const LightShadows Soft = 2;
}

// Namespace: UnityEngine
[Flags]
public enum LightmapBakeType // TypeDefIndex: 6721
{
	// Fields
	public int value__; // 0x0
	public const LightmapBakeType Realtime = 4;
	public const LightmapBakeType Baked = 2;
	public const LightmapBakeType Mixed = 1;
}

// Namespace: UnityEngine
public enum MixedLightingMode // TypeDefIndex: 6722
{
	// Fields
	public int value__; // 0x0
	public const MixedLightingMode IndirectOnly = 0;
	public const MixedLightingMode Shadowmask = 2;
	public const MixedLightingMode Subtractive = 1;
}

// Namespace: UnityEngine
public enum CameraClearFlags // TypeDefIndex: 6723
{
	// Fields
	public int value__; // 0x0
	public const CameraClearFlags Skybox = 1;
	public const CameraClearFlags Color = 2;
	public const CameraClearFlags SolidColor = 2;
	public const CameraClearFlags Depth = 3;
	public const CameraClearFlags Nothing = 4;
}

// Namespace: UnityEngine
public enum MeshTopology // TypeDefIndex: 6724
{
	// Fields
	public int value__; // 0x0
	public const MeshTopology Triangles = 0;
	public const MeshTopology Quads = 2;
	public const MeshTopology Lines = 3;
	public const MeshTopology LineStrip = 4;
	public const MeshTopology Points = 5;
}

// Namespace: UnityEngine
public enum ColorSpace // TypeDefIndex: 6725
{
	// Fields
	public int value__; // 0x0
	public const ColorSpace Uninitialized = -1;
	public const ColorSpace Gamma = 0;
	public const ColorSpace Linear = 1;
}

// Namespace: UnityEngine
public enum ScreenOrientation // TypeDefIndex: 6726
{
	// Fields
	public int value__; // 0x0
	public const ScreenOrientation Portrait = 1;
	public const ScreenOrientation PortraitUpsideDown = 2;
	public const ScreenOrientation LandscapeLeft = 3;
	public const ScreenOrientation LandscapeRight = 4;
	public const ScreenOrientation AutoRotation = 5;
	[Obsolete("Enum member Unknown has been deprecated.", False)]
	public const ScreenOrientation Unknown = 0;
	[Obsolete("Use LandscapeLeft instead (UnityUpgradable) -> LandscapeLeft", True)]
	public const ScreenOrientation Landscape = 3;
}

// Namespace: UnityEngine
public enum FilterMode // TypeDefIndex: 6727
{
	// Fields
	public int value__; // 0x0
	public const FilterMode Point = 0;
	public const FilterMode Bilinear = 1;
	public const FilterMode Trilinear = 2;
}

// Namespace: UnityEngine
public enum TextureWrapMode // TypeDefIndex: 6728
{
	// Fields
	public int value__; // 0x0
	public const TextureWrapMode Repeat = 0;
	public const TextureWrapMode Clamp = 1;
	public const TextureWrapMode Mirror = 2;
	public const TextureWrapMode MirrorOnce = 3;
}

// Namespace: UnityEngine
public enum TextureFormat // TypeDefIndex: 6729
{
	// Fields
	public int value__; // 0x0
	public const TextureFormat Alpha8 = 1;
	public const TextureFormat ARGB4444 = 2;
	public const TextureFormat RGB24 = 3;
	public const TextureFormat RGBA32 = 4;
	public const TextureFormat ARGB32 = 5;
	public const TextureFormat RGB565 = 7;
	public const TextureFormat R16 = 9;
	public const TextureFormat DXT1 = 10;
	public const TextureFormat DXT5 = 12;
	public const TextureFormat RGBA4444 = 13;
	public const TextureFormat BGRA32 = 14;
	public const TextureFormat RHalf = 15;
	public const TextureFormat RGHalf = 16;
	public const TextureFormat RGBAHalf = 17;
	public const TextureFormat RFloat = 18;
	public const TextureFormat RGFloat = 19;
	public const TextureFormat RGBAFloat = 20;
	public const TextureFormat YUY2 = 21;
	public const TextureFormat RGB9e5Float = 22;
	public const TextureFormat BC4 = 26;
	public const TextureFormat BC5 = 27;
	public const TextureFormat BC6H = 24;
	public const TextureFormat BC7 = 25;
	public const TextureFormat DXT1Crunched = 28;
	public const TextureFormat DXT5Crunched = 29;
	public const TextureFormat PVRTC_RGB2 = 30;
	public const TextureFormat PVRTC_RGBA2 = 31;
	public const TextureFormat PVRTC_RGB4 = 32;
	public const TextureFormat PVRTC_RGBA4 = 33;
	public const TextureFormat ETC_RGB4 = 34;
	public const TextureFormat EAC_R = 41;
	public const TextureFormat EAC_R_SIGNED = 42;
	public const TextureFormat EAC_RG = 43;
	public const TextureFormat EAC_RG_SIGNED = 44;
	public const TextureFormat ETC2_RGB = 45;
	public const TextureFormat ETC2_RGBA1 = 46;
	public const TextureFormat ETC2_RGBA8 = 47;
	public const TextureFormat ASTC_4x4 = 48;
	public const TextureFormat ASTC_5x5 = 49;
	public const TextureFormat ASTC_6x6 = 50;
	public const TextureFormat ASTC_8x8 = 51;
	public const TextureFormat ASTC_10x10 = 52;
	public const TextureFormat ASTC_12x12 = 53;
	public const TextureFormat RG16 = 62;
	public const TextureFormat R8 = 63;
	public const TextureFormat ETC_RGB4Crunched = 64;
	public const TextureFormat ETC2_RGBA8Crunched = 65;
	public const TextureFormat ASTC_HDR_4x4 = 66;
	public const TextureFormat ASTC_HDR_5x5 = 67;
	public const TextureFormat ASTC_HDR_6x6 = 68;
	public const TextureFormat ASTC_HDR_8x8 = 69;
	public const TextureFormat ASTC_HDR_10x10 = 70;
	public const TextureFormat ASTC_HDR_12x12 = 71;
	public const TextureFormat RG32 = 72;
	public const TextureFormat RGB48 = 73;
	public const TextureFormat RGBA64 = 74;
	public const TextureFormat R8_SIGNED = 75;
	public const TextureFormat RG16_SIGNED = 76;
	public const TextureFormat RGB24_SIGNED = 77;
	public const TextureFormat RGBA32_SIGNED = 78;
	public const TextureFormat R16_SIGNED = 79;
	public const TextureFormat RG32_SIGNED = 80;
	public const TextureFormat RGB48_SIGNED = 81;
	public const TextureFormat RGBA64_SIGNED = 82;
}

// Namespace: UnityEngine
internal enum TextureColorSpace // TypeDefIndex: 6730
{
	// Fields
	public int value__; // 0x0
	public const TextureColorSpace Linear = 0;
	public const TextureColorSpace sRGB = 1;
}

// Namespace: UnityEngine
public enum RenderTextureFormat // TypeDefIndex: 6731
{
	// Fields
	public int value__; // 0x0
	public const RenderTextureFormat ARGB32 = 0;
	public const RenderTextureFormat Depth = 1;
	public const RenderTextureFormat ARGBHalf = 2;
	public const RenderTextureFormat Shadowmap = 3;
	public const RenderTextureFormat RGB565 = 4;
	public const RenderTextureFormat ARGB4444 = 5;
	public const RenderTextureFormat ARGB1555 = 6;
	public const RenderTextureFormat Default = 7;
	public const RenderTextureFormat ARGB2101010 = 8;
	public const RenderTextureFormat DefaultHDR = 9;
	public const RenderTextureFormat ARGB64 = 10;
	public const RenderTextureFormat ARGBFloat = 11;
	public const RenderTextureFormat RGFloat = 12;
	public const RenderTextureFormat RGHalf = 13;
	public const RenderTextureFormat RFloat = 14;
	public const RenderTextureFormat RHalf = 15;
	public const RenderTextureFormat R8 = 16;
	public const RenderTextureFormat ARGBInt = 17;
	public const RenderTextureFormat RGInt = 18;
	public const RenderTextureFormat RInt = 19;
	public const RenderTextureFormat BGRA32 = 20;
	public const RenderTextureFormat RGB111110Float = 22;
	public const RenderTextureFormat RG32 = 23;
	public const RenderTextureFormat RGBAUShort = 24;
	public const RenderTextureFormat RG16 = 25;
	public const RenderTextureFormat BGRA10101010_XR = 26;
	public const RenderTextureFormat BGR101010_XR = 27;
	public const RenderTextureFormat R16 = 28;
}

// Namespace: UnityEngine
public enum VRTextureUsage // TypeDefIndex: 6732
{
	// Fields
	public int value__; // 0x0
	public const VRTextureUsage None = 0;
	public const VRTextureUsage OneEye = 1;
	public const VRTextureUsage TwoEyes = 2;
	public const VRTextureUsage DeviceSpecific = 3;
}

// Namespace: UnityEngine
[Flags]
public enum RenderTextureCreationFlags // TypeDefIndex: 6733
{
	// Fields
	public int value__; // 0x0
	public const RenderTextureCreationFlags MipMap = 1;
	public const RenderTextureCreationFlags AutoGenerateMips = 2;
	public const RenderTextureCreationFlags SRGB = 4;
	public const RenderTextureCreationFlags EyeTexture = 8;
	public const RenderTextureCreationFlags EnableRandomWrite = 16;
	public const RenderTextureCreationFlags CreatedFromScript = 32;
	public const RenderTextureCreationFlags AllowVerticalFlip = 128;
	public const RenderTextureCreationFlags NoResolvedColorSurface = 256;
	public const RenderTextureCreationFlags DynamicallyScalable = 1024;
	public const RenderTextureCreationFlags BindMS = 2048;
	public const RenderTextureCreationFlags DynamicallyScalableExplicit = 131072;
}

// Namespace: UnityEngine
public enum RenderTextureReadWrite // TypeDefIndex: 6734
{
	// Fields
	public int value__; // 0x0
	public const RenderTextureReadWrite Default = 0;
	public const RenderTextureReadWrite Linear = 1;
	public const RenderTextureReadWrite sRGB = 2;
}

// Namespace: UnityEngine
[Flags]
public enum RenderTextureMemoryless // TypeDefIndex: 6735
{
	// Fields
	public int value__; // 0x0
	public const RenderTextureMemoryless None = 0;
	public const RenderTextureMemoryless Color = 1;
	public const RenderTextureMemoryless Depth = 2;
	public const RenderTextureMemoryless MSAA = 4;
}

// Namespace: UnityEngine
[Flags]
public enum LightmapsMode // TypeDefIndex: 6736
{
	// Fields
	public int value__; // 0x0
	public const LightmapsMode NonDirectional = 0;
	public const LightmapsMode CombinedDirectional = 1;
}

// Namespace: UnityEngine
public enum MotionVectorGenerationMode // TypeDefIndex: 6737
{
	// Fields
	public int value__; // 0x0
	public const MotionVectorGenerationMode Camera = 0;
	public const MotionVectorGenerationMode Object = 1;
	public const MotionVectorGenerationMode ForceNoMotion = 2;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Mesh/SkinnedMeshRenderer.h")]
[RequiredByNativeCode]
public class SkinnedMeshRenderer : Renderer // TypeDefIndex: 6738
{}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Mesh/MeshRenderer.h")]
public class MeshRenderer : Renderer // TypeDefIndex: 6739
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E583C4 Offset: 0x1E543C4 VA: 0x1E583C4
	private void DontStripMeshRenderer() { }

	// RVA: 0x1E583C8 Offset: 0x1E543C8 VA: 0x1E583C8
	public void .ctor() { }
}

// Namespace: UnityEngine
public enum LODFadeMode // TypeDefIndex: 6740
{
	// Fields
	public int value__; // 0x0
	public const LODFadeMode None = 0;
	public const LODFadeMode CrossFade = 1;
	public const LODFadeMode SpeedTree = 2;
}

// Namespace: 
[StaticAccessor("MeshDataBindings", 2)]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
public struct Mesh.MeshData // TypeDefIndex: 6741
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal IntPtr m_Ptr; // 0x0
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[ExcludeFromPreset]
public sealed class Mesh : Object // TypeDefIndex: 6742
{
	// Properties
	internal bool canAccess { get; }
	public int vertexCount { get; }
	public int subMeshCount { get; }
	public Bounds bounds { get; set; }
	public Vector3[] vertices { get; set; }
	public Vector3[] normals { get; set; }
	public Vector4[] tangents { get; set; }
	public Vector2[] uv2 { set; }
	public Color32[] colors32 { get; set; }
	public int[] triangles { set; }

	// Methods

	[FreeFunction("MeshScripting::CreateMesh")]
	// RVA: 0x1E583D0 Offset: 0x1E543D0 VA: 0x1E583D0
	private static void Internal_Create(Mesh mono) { }

	[RequiredByNativeCode]
	// RVA: 0x1E5840C Offset: 0x1E5440C VA: 0x1E5840C
	public void .ctor() { }

	[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = True)]
	// RVA: 0x1E5848C Offset: 0x1E5448C VA: 0x1E5848C
	private int[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x1E58650 Offset: 0x1E54650 VA: 0x1E58650
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = True)]
	// RVA: 0x1E587C4 Offset: 0x1E547C4 VA: 0x1E587C4
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = True)]
	// RVA: 0x1E58888 Offset: 0x1E54888 VA: 0x1E58888
	public bool HasVertexAttribute(VertexAttribute attr) { }

	[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = True)]
	// RVA: 0x1E5894C Offset: 0x1E5494C VA: 0x1E5894C
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = True)]
	// RVA: 0x1E58AC0 Offset: 0x1E54AC0 VA: 0x1E58AC0
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = True)]
	// RVA: 0x1E58BB4 Offset: 0x1E54BB4 VA: 0x1E58BB4
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	[NativeMethod("CanAccessFromScript")]
	// RVA: 0x1E58CC8 Offset: 0x1E54CC8 VA: 0x1E58CC8
	internal bool get_canAccess() { }

	[NativeMethod("GetVertexCount")]
	// RVA: 0x1E58D7C Offset: 0x1E54D7C VA: 0x1E58D7C
	public int get_vertexCount() { }

	[NativeMethod(Name = "GetSubMeshCount")]
	// RVA: 0x1E58E30 Offset: 0x1E54E30 VA: 0x1E58E30
	public int get_subMeshCount() { }

	// RVA: 0x1E58EE4 Offset: 0x1E54EE4 VA: 0x1E58EE4
	public Bounds get_bounds() { }

	// RVA: 0x1E58FCC Offset: 0x1E54FCC VA: 0x1E58FCC
	public void set_bounds(Bounds value) { }

	[NativeMethod("Clear")]
	// RVA: 0x1E59090 Offset: 0x1E55090 VA: 0x1E59090
	private void ClearImpl(bool keepVertexLayout) { }

	[NativeMethod("RecalculateBounds")]
	// RVA: 0x1E59154 Offset: 0x1E55154 VA: 0x1E59154
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	[NativeMethod("MarkDynamic")]
	// RVA: 0x1E59218 Offset: 0x1E55218 VA: 0x1E59218
	private void MarkDynamicImpl() { }

	// RVA: 0x1E592CC Offset: 0x1E552CC VA: 0x1E592CC
	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	// RVA: 0x1E59340 Offset: 0x1E55340 VA: 0x1E59340
	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113553C Offset: 0x113153C VA: 0x113553C
	|-Mesh.GetAllocArrayFromChannel<Color32>
	|
	|-RVA: 0x113563C Offset: 0x113163C VA: 0x113563C
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|
	|-RVA: 0x113573C Offset: 0x113173C VA: 0x113573C
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	|
	|-RVA: 0x113583C Offset: 0x113183C VA: 0x113583C
	|-Mesh.GetAllocArrayFromChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113543C Offset: 0x113143C VA: 0x113543C
	|-Mesh.GetAllocArrayFromChannel<Vector3>
	|
	|-RVA: 0x1135490 Offset: 0x1131490 VA: 0x1135490
	|-Mesh.GetAllocArrayFromChannel<Vector4>
	|
	|-RVA: 0x11354E4 Offset: 0x11314E4 VA: 0x11354E4
	|-Mesh.GetAllocArrayFromChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E593DC Offset: 0x1E553DC VA: 0x1E593DC
	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136048 Offset: 0x1132048 VA: 0x1136048
	|-Mesh.SetArrayForChannel<Color32>
	|
	|-RVA: 0x11360C4 Offset: 0x11320C4 VA: 0x11360C4
	|-Mesh.SetArrayForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SetArrayForChannel<T>(VertexAttribute channel, T[] values, MeshUpdateFlags flags = 0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1135E58 Offset: 0x1131E58 VA: 0x1135E58
	|-Mesh.SetArrayForChannel<Vector2>
	|
	|-RVA: 0x1135ED4 Offset: 0x1131ED4 VA: 0x1135ED4
	|-Mesh.SetArrayForChannel<Vector3>
	|
	|-RVA: 0x1135F50 Offset: 0x1131F50 VA: 0x1135F50
	|-Mesh.SetArrayForChannel<Vector4>
	|
	|-RVA: 0x1135FCC Offset: 0x1131FCC VA: 0x1135FCC
	|-Mesh.SetArrayForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136410 Offset: 0x1132410 VA: 0x1136410
	|-Mesh.SetListForChannel<Color32>
	|
	|-RVA: 0x1136514 Offset: 0x1132514 VA: 0x1136514
	|-Mesh.SetListForChannel<Vector4>
	|
	|-RVA: 0x1136618 Offset: 0x1132618 VA: 0x1136618
	|-Mesh.SetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1136140 Offset: 0x1132140 VA: 0x1136140
	|-Mesh.SetListForChannel<Vector3>
	|
	|-RVA: 0x1136244 Offset: 0x1132244 VA: 0x1136244
	|-Mesh.SetListForChannel<Vector4>
	|
	|-RVA: 0x1136348 Offset: 0x1132348 VA: 0x1136348
	|-Mesh.SetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113593C Offset: 0x113193C VA: 0x113593C
	|-Mesh.GetListForChannel<Vector4>
	|
	|-RVA: 0x11359A8 Offset: 0x11319A8 VA: 0x11359A8
	|-Mesh.GetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1135A18 Offset: 0x1131A18 VA: 0x1135A18
	|-Mesh.GetListForChannel<Vector4>
	|
	|-RVA: 0x1135B2C Offset: 0x1131B2C VA: 0x1135B2C
	|-Mesh.GetListForChannel<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E59608 Offset: 0x1E55608 VA: 0x1E59608
	public Vector3[] get_vertices() { }

	// RVA: 0x1E59654 Offset: 0x1E55654 VA: 0x1E59654
	public void set_vertices(Vector3[] value) { }

	// RVA: 0x1E596B4 Offset: 0x1E556B4 VA: 0x1E596B4
	public Vector3[] get_normals() { }

	// RVA: 0x1E59700 Offset: 0x1E55700 VA: 0x1E59700
	public void set_normals(Vector3[] value) { }

	// RVA: 0x1E59760 Offset: 0x1E55760 VA: 0x1E59760
	public Vector4[] get_tangents() { }

	// RVA: 0x1E597AC Offset: 0x1E557AC VA: 0x1E597AC
	public void set_tangents(Vector4[] value) { }

	// RVA: 0x1E5980C Offset: 0x1E5580C VA: 0x1E5980C
	public void set_uv2(Vector2[] value) { }

	// RVA: 0x1E5986C Offset: 0x1E5586C VA: 0x1E5986C
	public Color32[] get_colors32() { }

	// RVA: 0x1E598C0 Offset: 0x1E558C0 VA: 0x1E598C0
	public void set_colors32(Color32[] value) { }

	// RVA: 0x1E59928 Offset: 0x1E55928 VA: 0x1E59928
	public void SetVertices(List<Vector3> inVertices) { }

	[ExcludeFromDocs]
	// RVA: 0x1E59994 Offset: 0x1E55994 VA: 0x1E59994
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	// RVA: 0x1E5999C Offset: 0x1E5599C VA: 0x1E5999C
	public void SetVertices(List<Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x1E59A18 Offset: 0x1E55A18 VA: 0x1E59A18
	public void SetNormals(List<Vector3> inNormals) { }

	[ExcludeFromDocs]
	// RVA: 0x1E59A84 Offset: 0x1E55A84 VA: 0x1E59A84
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	// RVA: 0x1E59A8C Offset: 0x1E55A8C VA: 0x1E59A8C
	public void SetNormals(List<Vector3> inNormals, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x1E59B08 Offset: 0x1E55B08 VA: 0x1E59B08
	public void SetTangents(List<Vector4> inTangents) { }

	[ExcludeFromDocs]
	// RVA: 0x1E59B74 Offset: 0x1E55B74 VA: 0x1E59B74
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	// RVA: 0x1E59B7C Offset: 0x1E55B7C VA: 0x1E59B7C
	public void SetTangents(List<Vector4> inTangents, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x1E59BF8 Offset: 0x1E55BF8 VA: 0x1E59BF8
	public void SetColors(List<Color32> inColors) { }

	[ExcludeFromDocs]
	// RVA: 0x1E59C64 Offset: 0x1E55C64 VA: 0x1E59C64
	public void SetColors(List<Color32> inColors, int start, int length) { }

	// RVA: 0x1E59C6C Offset: 0x1E55C6C VA: 0x1E59C6C
	public void SetColors(List<Color32> inColors, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11366D8 Offset: 0x11326D8 VA: 0x11366D8
	|-Mesh.SetUvsImpl<Vector4>
	|
	|-RVA: 0x11367E4 Offset: 0x11327E4 VA: 0x11367E4
	|-Mesh.SetUvsImpl<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E59D00 Offset: 0x1E55D00 VA: 0x1E59D00
	public void SetUVs(int channel, List<Vector4> uvs) { }

	[ExcludeFromDocs]
	// RVA: 0x1E59D74 Offset: 0x1E55D74 VA: 0x1E59D74
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	// RVA: 0x1E59D7C Offset: 0x1E55D7C VA: 0x1E59D7C
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: 0x1E59E08 Offset: 0x1E55E08 VA: 0x1E59E08
	private void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, MeshUpdateFlags flags) { }

	// RVA: 0x1E59F10 Offset: 0x1E55F10 VA: 0x1E59F10
	public void SetUVs(int channel, Vector4[] uvs) { }

	[ExcludeFromDocs]
	// RVA: 0x1E59F58 Offset: 0x1E55F58 VA: 0x1E59F58
	public void SetUVs(int channel, Vector4[] uvs, int start, int length) { }

	// RVA: 0x1E59F70 Offset: 0x1E55F70 VA: 0x1E59F70
	public void SetUVs(int channel, Vector4[] uvs, int start, int length, MeshUpdateFlags flags) { }

	// RVA: -1 Offset: -1
	private void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1135C34 Offset: 0x1131C34 VA: 0x1135C34
	|-Mesh.GetUVsImpl<Vector4>
	|
	|-RVA: 0x1135D44 Offset: 0x1131D44 VA: 0x1135D44
	|-Mesh.GetUVsImpl<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E59F88 Offset: 0x1E55F88 VA: 0x1E59F88
	public void GetUVs(int channel, List<Vector4> uvs) { }

	// RVA: 0x1E59FEC Offset: 0x1E55FEC VA: 0x1E59FEC
	private void PrintErrorCantAccessIndices() { }

	// RVA: 0x1E5A084 Offset: 0x1E56084 VA: 0x1E5A084
	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	// RVA: 0x1E5A184 Offset: 0x1E56184 VA: 0x1E5A184
	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	// RVA: 0x1E5A18C Offset: 0x1E5618C VA: 0x1E5A18C
	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	// RVA: 0x1E5A194 Offset: 0x1E56194 VA: 0x1E5A194
	public void set_triangles(int[] value) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5A2B8 Offset: 0x1E562B8 VA: 0x1E5A2B8
	public int[] GetIndices(int submesh) { }

	// RVA: 0x1E5A2C0 Offset: 0x1E562C0 VA: 0x1E5A2C0
	public int[] GetIndices(int submesh, bool applyBaseVertex) { }

	// RVA: 0x1E5A348 Offset: 0x1E56348 VA: 0x1E5A348
	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	// RVA: 0x1E5A238 Offset: 0x1E56238 VA: 0x1E5A238
	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5A4E4 Offset: 0x1E564E4 VA: 0x1E5A4E4
	public void SetTriangles(List<int> triangles, int submesh) { }

	// RVA: 0x1E5A4F0 Offset: 0x1E564F0 VA: 0x1E5A4F0
	public void SetTriangles(List<int> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	// RVA: 0x1E5A578 Offset: 0x1E56578 VA: 0x1E5A578
	public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = True, int baseVertex = 0) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5A69C Offset: 0x1E5669C VA: 0x1E5A69C
	public void Clear() { }

	[ExcludeFromDocs]
	// RVA: 0x1E5A6A4 Offset: 0x1E566A4 VA: 0x1E5A6A4
	public void RecalculateBounds() { }

	// RVA: 0x1E5A6AC Offset: 0x1E566AC VA: 0x1E5A6AC
	public void RecalculateBounds(MeshUpdateFlags flags) { }

	// RVA: 0x1E5A760 Offset: 0x1E56760 VA: 0x1E5A760
	public void MarkDynamic() { }

	// RVA: 0x1E585F4 Offset: 0x1E545F4 VA: 0x1E585F4
	private static void GetIndicesImpl_Injected(IntPtr _unity_self, int submesh, bool applyBaseVertex, out BlittableArrayWrapper ret) { }

	// RVA: 0x1E58728 Offset: 0x1E54728 VA: 0x1E58728
	private static void SetIndicesImpl_Injected(IntPtr _unity_self, int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	// RVA: 0x1E58844 Offset: 0x1E54844 VA: 0x1E58844
	private static void PrintErrorCantAccessChannel_Injected(IntPtr _unity_self, VertexAttribute ch) { }

	// RVA: 0x1E58908 Offset: 0x1E54908 VA: 0x1E58908
	private static bool HasVertexAttribute_Injected(IntPtr _unity_self, VertexAttribute attr) { }

	// RVA: 0x1E58A24 Offset: 0x1E54A24 VA: 0x1E58A24
	private static void SetArrayForChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	// RVA: 0x1E58B58 Offset: 0x1E54B58 VA: 0x1E58B58
	private static Array GetAllocArrayFromChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	// RVA: 0x1E58C5C Offset: 0x1E54C5C VA: 0x1E58C5C
	private static void GetArrayFromChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	// RVA: 0x1E58D40 Offset: 0x1E54D40 VA: 0x1E58D40
	private static bool get_canAccess_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E58DF4 Offset: 0x1E54DF4 VA: 0x1E58DF4
	private static int get_vertexCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E58EA8 Offset: 0x1E54EA8 VA: 0x1E58EA8
	private static int get_subMeshCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E58F88 Offset: 0x1E54F88 VA: 0x1E58F88
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	// RVA: 0x1E5904C Offset: 0x1E5504C VA: 0x1E5904C
	private static void set_bounds_Injected(IntPtr _unity_self, in Bounds value) { }

	// RVA: 0x1E59110 Offset: 0x1E55110 VA: 0x1E59110
	private static void ClearImpl_Injected(IntPtr _unity_self, bool keepVertexLayout) { }

	// RVA: 0x1E591D4 Offset: 0x1E551D4 VA: 0x1E591D4
	private static void RecalculateBoundsImpl_Injected(IntPtr _unity_self, MeshUpdateFlags flags) { }

	// RVA: 0x1E59290 Offset: 0x1E55290 VA: 0x1E59290
	private static void MarkDynamicImpl_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Texture.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
public class Texture : Object // TypeDefIndex: 6743
{
	// Fields
	public static readonly int GenerateAllMips; // 0x0

	// Properties
	public virtual int width { get; set; }
	public virtual int height { get; set; }
	public virtual bool isReadable { get; }
	public TextureWrapMode wrapMode { get; }
	public FilterMode filterMode { set; }
	public Vector2 texelSize { get; }

	// Methods

	// RVA: 0x1E5A784 Offset: 0x1E56784 VA: 0x1E5A784
	protected void .ctor() { }

	[ThreadSafe]
	// RVA: 0x1E5A7DC Offset: 0x1E567DC VA: 0x1E5A7DC
	private int GetDataWidth() { }

	[ThreadSafe]
	// RVA: 0x1E5A8B4 Offset: 0x1E568B4 VA: 0x1E5A8B4
	private int GetDataHeight() { }

	// RVA: 0x1E5A98C Offset: 0x1E5698C VA: 0x1E5A98C Slot: 4
	public virtual int get_width() { }

	// RVA: 0x1E5A990 Offset: 0x1E56990 VA: 0x1E5A990 Slot: 5
	public virtual void set_width(int value) { }

	// RVA: 0x1E5A9C8 Offset: 0x1E569C8 VA: 0x1E5A9C8 Slot: 6
	public virtual int get_height() { }

	// RVA: 0x1E5A9CC Offset: 0x1E569CC VA: 0x1E5A9CC Slot: 7
	public virtual void set_height(int value) { }

	// RVA: 0x1E5AA04 Offset: 0x1E56A04 VA: 0x1E5AA04 Slot: 8
	public virtual bool get_isReadable() { }

	[NativeName("GetWrapModeU")]
	// RVA: 0x1E5AADC Offset: 0x1E56ADC VA: 0x1E5AADC
	public TextureWrapMode get_wrapMode() { }

	// RVA: 0x1E5ABB4 Offset: 0x1E56BB4 VA: 0x1E5ABB4
	public void set_filterMode(FilterMode value) { }

	[NativeName("GetTexelSize")]
	// RVA: 0x1E5ACA4 Offset: 0x1E56CA4 VA: 0x1E5ACA4
	public Vector2 get_texelSize() { }

	// RVA: 0x1E5AD9C Offset: 0x1E56D9C VA: 0x1E5AD9C
	internal TextureColorSpace GetTextureColorSpace(bool linear) { }

	// RVA: 0x1E5ADA8 Offset: 0x1E56DA8 VA: 0x1E5ADA8
	internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format) { }

	// RVA: 0x1E5AE08 Offset: 0x1E56E08 VA: 0x1E5AE08
	internal bool ValidateFormat(TextureFormat format) { }

	// RVA: 0x1E5AFC8 Offset: 0x1E56FC8 VA: 0x1E5AFC8
	internal bool ValidateFormat(GraphicsFormat format, GraphicsFormatUsage usage) { }

	// RVA: 0x1E5B100 Offset: 0x1E57100 VA: 0x1E5B100
	internal UnityException CreateNonReadableException(Texture t) { }

	// RVA: 0x1E5B1A0 Offset: 0x1E571A0 VA: 0x1E5B1A0
	private static void .cctor() { }

	// RVA: 0x1E5A878 Offset: 0x1E56878 VA: 0x1E5A878
	private static int GetDataWidth_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E5A950 Offset: 0x1E56950 VA: 0x1E5A950
	private static int GetDataHeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E5AAA0 Offset: 0x1E56AA0 VA: 0x1E5AAA0
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E5AB78 Offset: 0x1E56B78 VA: 0x1E5AB78
	private static TextureWrapMode get_wrapMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E5AC60 Offset: 0x1E56C60 VA: 0x1E5AC60
	private static void set_filterMode_Injected(IntPtr _unity_self, FilterMode value) { }

	// RVA: 0x1E5AD58 Offset: 0x1E56D58 VA: 0x1E5AD58
	private static void get_texelSize_Injected(IntPtr _unity_self, out Vector2 ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Texture2D.h")]
[UsedByNativeCode]
[HelpURL("texture-type-default")]
[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
public sealed class Texture2D : Texture // TypeDefIndex: 6744
{
	// Fields
	internal const int streamingMipmapsPriorityMin = -128;
	internal const int streamingMipmapsPriorityMax = 127;

	// Properties
	public TextureFormat format { get; }
	[StaticAccessor("builtintex", 2)]
	public static Texture2D whiteTexture { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeName("GetTextureFormat")]
	// RVA: 0x1E5B1EC Offset: 0x1E571EC VA: 0x1E5B1EC
	public TextureFormat get_format() { }

	// RVA: 0x1E5B2A0 Offset: 0x1E572A0 VA: 0x1E5B2A0
	public static Texture2D get_whiteTexture() { }

	[FreeFunction("Texture2DScripting::CreateEmpty")]
	// RVA: 0x1E5B328 Offset: 0x1E57328 VA: 0x1E5B328
	private static bool Internal_CreateEmptyImpl(Texture2D mono) { }

	[FreeFunction("Texture2DScripting::Create")]
	// RVA: 0x1E5B364 Offset: 0x1E57364 VA: 0x1E5B364
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x1E5B5F0 Offset: 0x1E575F0 VA: 0x1E5B5F0
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x1E5B664 Offset: 0x1E57664 VA: 0x1E5B664 Slot: 8
	public override bool get_isReadable() { }

	[NativeName("Apply")]
	// RVA: 0x1E5B718 Offset: 0x1E57718 VA: 0x1E5B718
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeName("Reinitialize")]
	// RVA: 0x1E5B7FC Offset: 0x1E577FC VA: 0x1E5B7FC
	private bool ReinitializeImpl(int width, int height) { }

	[NativeName("SetPixel")]
	// RVA: 0x1E5B8E0 Offset: 0x1E578E0 VA: 0x1E5B8E0
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	[NativeName("GetPixelBilinear")]
	// RVA: 0x1E5BA14 Offset: 0x1E57A14 VA: 0x1E5BA14
	private Color GetPixelBilinearImpl(int image, int mip, float u, float v) { }

	[FreeFunction(Name = "Texture2DScripting::ReinitializeWithTextureFormat", HasExplicitThis = True)]
	// RVA: 0x1E5BB4C Offset: 0x1E57B4C VA: 0x1E5BB4C
	private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = True)]
	// RVA: 0x1E5BC60 Offset: 0x1E57C60 VA: 0x1E5BC60
	private bool LoadRawTextureDataImpl(IntPtr data, ulong size) { }

	[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = True)]
	// RVA: 0x1E5BD44 Offset: 0x1E57D44 VA: 0x1E5BD44
	private bool LoadRawTextureDataImplArray(byte[] data) { }

	[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x1E5BE88 Offset: 0x1E57E88 VA: 0x1E5BE88
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	// RVA: 0x1E5BFE8 Offset: 0x1E57FE8 VA: 0x1E5BFE8
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x1E5C0C4 Offset: 0x1E580C4 VA: 0x1E5C0C4
	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	// RVA: 0x1E5C268 Offset: 0x1E58268 VA: 0x1E5C268
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x1E5C31C Offset: 0x1E5831C VA: 0x1E5C31C
	public void .ctor(int width, int height) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5C460 Offset: 0x1E58460 VA: 0x1E5C460
	public void SetPixel(int x, int y, Color color) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5C4FC Offset: 0x1E584FC VA: 0x1E5C4FC
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x1E5C564 Offset: 0x1E58564 VA: 0x1E5C564
	public void LoadRawTextureData(IntPtr data, int size) { }

	// RVA: 0x1E5C678 Offset: 0x1E58678 VA: 0x1E5C678
	public void LoadRawTextureData(byte[] data) { }

	// RVA: 0x1E5C77C Offset: 0x1E5877C VA: 0x1E5C77C
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5C7E0 Offset: 0x1E587E0 VA: 0x1E5C7E0
	public void Apply() { }

	// RVA: 0x1E5C7EC Offset: 0x1E587EC VA: 0x1E5C7EC
	public bool Reinitialize(int width, int height) { }

	// RVA: 0x1E5C850 Offset: 0x1E58850 VA: 0x1E5C850
	public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap) { }

	// RVA: 0x1E5C854 Offset: 0x1E58854 VA: 0x1E5C854
	public void SetPixels32(Color32[] colors, int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5C858 Offset: 0x1E58858 VA: 0x1E5C858
	public void SetPixels32(Color32[] colors) { }

	// RVA: 0x1E5B264 Offset: 0x1E57264 VA: 0x1E5B264
	private static TextureFormat get_format_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E5B300 Offset: 0x1E57300 VA: 0x1E5B300
	private static IntPtr get_whiteTexture_Injected() { }

	// RVA: 0x1E5B548 Offset: 0x1E57548 VA: 0x1E5B548
	private static bool Internal_CreateImpl_Injected(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, bool ignoreMipmapLimit, ref ManagedSpanWrapper mipmapLimitGroupName) { }

	// RVA: 0x1E5B6DC Offset: 0x1E576DC VA: 0x1E5B6DC
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E5B7A8 Offset: 0x1E577A8 VA: 0x1E5B7A8
	private static void ApplyImpl_Injected(IntPtr _unity_self, bool updateMipmaps, bool makeNoLongerReadable) { }

	// RVA: 0x1E5B88C Offset: 0x1E5788C VA: 0x1E5B88C
	private static bool ReinitializeImpl_Injected(IntPtr _unity_self, int width, int height) { }

	// RVA: 0x1E5B9A0 Offset: 0x1E579A0 VA: 0x1E5B9A0
	private static void SetPixelImpl_Injected(IntPtr _unity_self, int image, int mip, int x, int y, in Color color) { }

	// RVA: 0x1E5BAD8 Offset: 0x1E57AD8 VA: 0x1E5BAD8
	private static void GetPixelBilinearImpl_Injected(IntPtr _unity_self, int image, int mip, float u, float v, out Color ret) { }

	// RVA: 0x1E5BBF4 Offset: 0x1E57BF4 VA: 0x1E5BBF4
	private static bool ReinitializeWithTextureFormatImpl_Injected(IntPtr _unity_self, int width, int height, TextureFormat textureFormat, bool hasMipMap) { }

	// RVA: 0x1E5BCF0 Offset: 0x1E57CF0 VA: 0x1E5BCF0
	private static bool LoadRawTextureDataImpl_Injected(IntPtr _unity_self, IntPtr data, ulong size) { }

	// RVA: 0x1E5BE44 Offset: 0x1E57E44 VA: 0x1E5BE44
	private static bool LoadRawTextureDataImplArray_Injected(IntPtr _unity_self, ref ManagedSpanWrapper data) { }

	// RVA: 0x1E5BF94 Offset: 0x1E57F94 VA: 0x1E5BF94
	private static void SetAllPixels32_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colors, int miplevel) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/CubemapTexture.h")]
[ExcludeFromPreset]
public sealed class Cubemap : Texture // TypeDefIndex: 6745
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	[FreeFunction("CubemapScripting::Create")]
	// RVA: 0x1E5C860 Offset: 0x1E58860 VA: 0x1E5C860
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x1E5C8E4 Offset: 0x1E588E4 VA: 0x1E5C8E4
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x1E5C9B8 Offset: 0x1E589B8 VA: 0x1E5C9B8 Slot: 8
	public override bool get_isReadable() { }

	// RVA: 0x1E5CA6C Offset: 0x1E58A6C VA: 0x1E5CA6C
	internal bool ValidateFormat(TextureFormat format, int width) { }

	// RVA: 0x1E5CB3C Offset: 0x1E58B3C VA: 0x1E5CB3C
	internal bool ValidateFormat(GraphicsFormat format, int width) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5CC64 Offset: 0x1E58C64 VA: 0x1E5CC64
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5CD28 Offset: 0x1E58D28 VA: 0x1E5CD28
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	// RVA: 0x1E5CCA0 Offset: 0x1E58CA0 VA: 0x1E5CCA0
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5CD74 Offset: 0x1E58D74 VA: 0x1E5CD74
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x1E5CEA4 Offset: 0x1E58EA4 VA: 0x1E5CEA4
	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	// RVA: 0x1E5D000 Offset: 0x1E59000 VA: 0x1E5D000
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x1E5D090 Offset: 0x1E59090 VA: 0x1E5D090
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x1E5D12C Offset: 0x1E5912C VA: 0x1E5D12C
	public void .ctor(int width, TextureFormat format, int mipCount) { }

	// RVA: 0x1E5D138 Offset: 0x1E59138 VA: 0x1E5D138
	public void .ctor(int width, TextureFormat format, int mipCount, bool createUninitialized) { }

	// RVA: 0x1E5CE50 Offset: 0x1E58E50 VA: 0x1E5CE50
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x1E5CA30 Offset: 0x1E58A30 VA: 0x1E5CA30
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Texture3D.h")]
public sealed class Texture3D : Texture // TypeDefIndex: 6746
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x1E5D144 Offset: 0x1E59144 VA: 0x1E5D144 Slot: 8
	public override bool get_isReadable() { }

	[FreeFunction("Texture3DScripting::Create")]
	// RVA: 0x1E5D1F8 Offset: 0x1E591F8 VA: 0x1E5D1F8
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x1E5D294 Offset: 0x1E59294 VA: 0x1E5D294
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5D388 Offset: 0x1E59388 VA: 0x1E5D388
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5D47C Offset: 0x1E5947C VA: 0x1E5D47C
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	// RVA: 0x1E5D3DC Offset: 0x1E593DC VA: 0x1E5D3DC
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5D4E0 Offset: 0x1E594E0 VA: 0x1E5D4E0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5D620 Offset: 0x1E59620 VA: 0x1E5D620
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x1E5D640 Offset: 0x1E59640 VA: 0x1E5D640
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x1E5D65C Offset: 0x1E5965C VA: 0x1E5D65C
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5D7C0 Offset: 0x1E597C0 VA: 0x1E5D7C0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x1E5D874 Offset: 0x1E59874 VA: 0x1E5D874
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x1E5D934 Offset: 0x1E59934 VA: 0x1E5D934
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x1E5D5CC Offset: 0x1E595CC VA: 0x1E5D5CC
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x1E5D1BC Offset: 0x1E591BC VA: 0x1E5D1BC
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Texture2DArray.h")]
public sealed class Texture2DArray : Texture // TypeDefIndex: 6747
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x1E5D9F4 Offset: 0x1E599F4 VA: 0x1E5D9F4 Slot: 8
	public override bool get_isReadable() { }

	[FreeFunction("Texture2DArrayScripting::Create")]
	// RVA: 0x1E5DAA8 Offset: 0x1E59AA8 VA: 0x1E5DAA8
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x1E5DD34 Offset: 0x1E59D34 VA: 0x1E5DD34
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x1E5DDA8 Offset: 0x1E59DA8 VA: 0x1E5DDA8
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x1E5DE84 Offset: 0x1E59E84 VA: 0x1E5DE84
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5DFB8 Offset: 0x1E59FB8 VA: 0x1E5DFB8
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5E0BC Offset: 0x1E5A0BC VA: 0x1E5E0BC
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5E14C Offset: 0x1E5A14C VA: 0x1E5E14C
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	[RequiredByNativeCode]
	// RVA: 0x1E5E00C Offset: 0x1E5A00C VA: 0x1E5E00C
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5E130 Offset: 0x1E5A130 VA: 0x1E5E130
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5E1C0 Offset: 0x1E5A1C0 VA: 0x1E5E1C0
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	// RVA: 0x1E5E32C Offset: 0x1E5A32C VA: 0x1E5E32C
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized, MipmapLimitDescriptor mipmapLimitDescriptor) { }

	// RVA: 0x1E5E4D4 Offset: 0x1E5A4D4 VA: 0x1E5E4D4
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x1E5E4F0 Offset: 0x1E5A4F0 VA: 0x1E5E4F0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x1E5E510 Offset: 0x1E5A510 VA: 0x1E5E510
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	// RVA: 0x1E5E5D8 Offset: 0x1E5A5D8 VA: 0x1E5E5D8
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5E69C Offset: 0x1E5A69C VA: 0x1E5E69C
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x1E5E2D8 Offset: 0x1E5A2D8 VA: 0x1E5E2D8
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x1E5DA6C Offset: 0x1E59A6C VA: 0x1E5DA6C
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E5DC8C Offset: 0x1E59C8C VA: 0x1E5DC8C
	private static bool Internal_CreateImpl_Injected(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, bool ignoreMipmapLimit, ref ManagedSpanWrapper mipmapLimitGroupName) { }
}

// Namespace: UnityEngine
[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/CubemapArrayTexture.h")]
public sealed class CubemapArray : Texture // TypeDefIndex: 6748
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x1E5E754 Offset: 0x1E5A754 VA: 0x1E5E754 Slot: 8
	public override bool get_isReadable() { }

	[FreeFunction("CubemapArrayScripting::Create")]
	// RVA: 0x1E5E808 Offset: 0x1E5A808 VA: 0x1E5E808
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x1E5E88C Offset: 0x1E5A88C VA: 0x1E5E88C
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5E960 Offset: 0x1E5A960 VA: 0x1E5E960
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5EA3C Offset: 0x1E5AA3C VA: 0x1E5EA3C
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[RequiredByNativeCode]
	// RVA: 0x1E5E9AC Offset: 0x1E5A9AC VA: 0x1E5E9AC
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5EA90 Offset: 0x1E5AA90 VA: 0x1E5EA90
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x1E5EBD0 Offset: 0x1E5ABD0 VA: 0x1E5EBD0
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x1E5ED3C Offset: 0x1E5AD3C VA: 0x1E5ED3C
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x1E5ED44 Offset: 0x1E5AD44 VA: 0x1E5ED44
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5EDF4 Offset: 0x1E5ADF4 VA: 0x1E5EDF4
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x1E5EE98 Offset: 0x1E5AE98 VA: 0x1E5EE98
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x1E5EB7C Offset: 0x1E5AB7C VA: 0x1E5EB7C
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }

	// RVA: 0x1E5E7CC Offset: 0x1E5A7CC VA: 0x1E5E7CC
	private static bool get_isReadable_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[UsedByNativeCode]
public class RenderTexture : Texture // TypeDefIndex: 6749
{
	// Properties
	public override int width { get; set; }
	public override int height { get; set; }
	public GraphicsFormat graphicsFormat { set; }
	public GraphicsFormat depthStencilFormat { set; }
	public RenderTextureDescriptor descriptor { get; }

	// Methods

	// RVA: 0x1E5EF38 Offset: 0x1E5AF38 VA: 0x1E5EF38 Slot: 4
	public override int get_width() { }

	// RVA: 0x1E5EFEC Offset: 0x1E5AFEC VA: 0x1E5EFEC Slot: 5
	public override void set_width(int value) { }

	// RVA: 0x1E5F0B0 Offset: 0x1E5B0B0 VA: 0x1E5F0B0 Slot: 6
	public override int get_height() { }

	// RVA: 0x1E5F164 Offset: 0x1E5B164 VA: 0x1E5F164 Slot: 7
	public override void set_height(int value) { }

	[NativeName("SetColorFormat")]
	// RVA: 0x1E5F228 Offset: 0x1E5B228 VA: 0x1E5F228
	private void SetColorFormat(GraphicsFormat format) { }

	// RVA: 0x1E5F2EC Offset: 0x1E5B2EC VA: 0x1E5F2EC
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x1E5F2F0 Offset: 0x1E5B2F0 VA: 0x1E5F2F0
	public void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x1E5F3B4 Offset: 0x1E5B3B4 VA: 0x1E5F3B4
	private void SetMipMapCount(int count) { }

	// RVA: 0x1E5F478 Offset: 0x1E5B478 VA: 0x1E5F478
	internal void SetShadowSamplingMode(ShadowSamplingMode samplingMode) { }

	// RVA: 0x1E5F53C Offset: 0x1E5B53C VA: 0x1E5F53C
	internal void SetSRGBReadWrite(bool srgb) { }

	[FreeFunction("RenderTextureScripting::Create")]
	// RVA: 0x1E5F600 Offset: 0x1E5B600 VA: 0x1E5F600
	private static void Internal_Create(RenderTexture rt) { }

	[NativeName("SetRenderTextureDescFromScript")]
	// RVA: 0x1E5F63C Offset: 0x1E5B63C VA: 0x1E5F63C
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[NativeName("GetRenderTextureDesc")]
	// RVA: 0x1E5F700 Offset: 0x1E5B700 VA: 0x1E5F700
	private RenderTextureDescriptor GetDescriptor() { }

	[RequiredByNativeCode]
	// RVA: 0x1E5F7F8 Offset: 0x1E5B7F8 VA: 0x1E5F7F8
	protected internal void .ctor() { }

	// RVA: 0x1E5F84C Offset: 0x1E5B84C VA: 0x1E5F84C
	public void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x1E5FCD4 Offset: 0x1E5BCD4 VA: 0x1E5FCD4
	public void .ctor(RenderTexture textureToCopy) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5FE74 Offset: 0x1E5BE74 VA: 0x1E5FE74
	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x1E60180 Offset: 0x1E5C180 VA: 0x1E60180
	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x1E60210 Offset: 0x1E5C210 VA: 0x1E60210
	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x1E5FFEC Offset: 0x1E5BFEC VA: 0x1E5FFEC
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x1E603A8 Offset: 0x1E5C3A8 VA: 0x1E603A8
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	// RVA: 0x1E60438 Offset: 0x1E5C438 VA: 0x1E60438
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	// RVA: 0x1E60650 Offset: 0x1E5C650 VA: 0x1E60650
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x1E60780 Offset: 0x1E5C780 VA: 0x1E60780
	public void .ctor(int width, int height, int depth) { }

	[ExcludeFromDocs]
	// RVA: 0x1E606E0 Offset: 0x1E5C6E0 VA: 0x1E606E0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x1E604E0 Offset: 0x1E5C4E0 VA: 0x1E604E0
	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	// RVA: 0x1E603A0 Offset: 0x1E5C3A0 VA: 0x1E603A0
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	// RVA: 0x1E608DC Offset: 0x1E5C8DC VA: 0x1E608DC
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format, bool disableFallback = False) { }

	// RVA: 0x1E60AFC Offset: 0x1E5CAFC VA: 0x1E60AFC
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	// RVA: 0x1E60928 Offset: 0x1E5C928 VA: 0x1E60928
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	// RVA: 0x1E5FE38 Offset: 0x1E5BE38 VA: 0x1E5FE38
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x1E5F90C Offset: 0x1E5B90C VA: 0x1E5F90C
	private static void ValidateRenderTextureDesc(ref RenderTextureDescriptor desc) { }

	// RVA: 0x1E5FFA8 Offset: 0x1E5BFA8 VA: 0x1E5FFA8
	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	// RVA: 0x1E5FFC4 Offset: 0x1E5BFC4 VA: 0x1E5FFC4
	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	// RVA: 0x1E60918 Offset: 0x1E5C918 VA: 0x1E60918
	internal static ShadowSamplingMode GetShadowSamplingModeForFormat(RenderTextureFormat format) { }

	// RVA: 0x1E60170 Offset: 0x1E5C170 VA: 0x1E60170
	internal static ShadowSamplingMode GetShadowSamplingModeForFormat(DefaultFormat format) { }

	// RVA: 0x1E60A40 Offset: 0x1E5CA40 VA: 0x1E60A40
	internal static void WarnAboutFallbackTo16BitsDepth(RenderTextureFormat format) { }

	// RVA: 0x1E60788 Offset: 0x1E5C788 VA: 0x1E60788
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x1E5EFB0 Offset: 0x1E5AFB0 VA: 0x1E5EFB0
	private static int get_width_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E5F06C Offset: 0x1E5B06C VA: 0x1E5F06C
	private static void set_width_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1E5F128 Offset: 0x1E5B128 VA: 0x1E5F128
	private static int get_height_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E5F1E4 Offset: 0x1E5B1E4 VA: 0x1E5F1E4
	private static void set_height_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1E5F2A8 Offset: 0x1E5B2A8 VA: 0x1E5F2A8
	private static void SetColorFormat_Injected(IntPtr _unity_self, GraphicsFormat format) { }

	// RVA: 0x1E5F370 Offset: 0x1E5B370 VA: 0x1E5F370
	private static void set_depthStencilFormat_Injected(IntPtr _unity_self, GraphicsFormat value) { }

	// RVA: 0x1E5F434 Offset: 0x1E5B434 VA: 0x1E5F434
	private static void SetMipMapCount_Injected(IntPtr _unity_self, int count) { }

	// RVA: 0x1E5F4F8 Offset: 0x1E5B4F8 VA: 0x1E5F4F8
	private static void SetShadowSamplingMode_Injected(IntPtr _unity_self, ShadowSamplingMode samplingMode) { }

	// RVA: 0x1E5F5BC Offset: 0x1E5B5BC VA: 0x1E5F5BC
	private static void SetSRGBReadWrite_Injected(IntPtr _unity_self, bool srgb) { }

	// RVA: 0x1E5F6BC Offset: 0x1E5B6BC VA: 0x1E5F6BC
	private static void SetRenderTextureDescriptor_Injected(IntPtr _unity_self, in RenderTextureDescriptor desc) { }

	// RVA: 0x1E5F7B4 Offset: 0x1E5B7B4 VA: 0x1E5F7B4
	private static void GetDescriptor_Injected(IntPtr _unity_self, out RenderTextureDescriptor ret) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/CustomRenderTexture.h")]
public sealed class CustomRenderTexture : RenderTexture // TypeDefIndex: 6750
{}

// Namespace: UnityEngine
public struct RenderTextureDescriptor // TypeDefIndex: 6751
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <width>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <height>k__BackingField; // 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <msaaSamples>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <volumeDepth>k__BackingField; // 0xC
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <mipCount>k__BackingField; // 0x10
	private GraphicsFormat _graphicsFormat; // 0x14
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private GraphicsFormat <stencilFormat>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private GraphicsFormat <depthStencilFormat>k__BackingField; // 0x1C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private TextureDimension <dimension>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; // 0x24
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VRTextureUsage <vrUsage>k__BackingField; // 0x28
	private RenderTextureCreationFlags _flags; // 0x2C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private RenderTextureMemoryless <memoryless>k__BackingField; // 0x30

	// Properties
	public int width { get; }
	public int height { get; }
	public int msaaSamples { get; }
	public int volumeDepth { get; }
	public GraphicsFormat graphicsFormat { get; }
	public GraphicsFormat depthStencilFormat { get; set; }
	public RenderTextureFormat colorFormat { get; }
	public TextureDimension dimension { get; }
	public ShadowSamplingMode shadowSamplingMode { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x1E60B8C Offset: 0x1E5CB8C VA: 0x1E60B8C
	public int get_width() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x1E60B94 Offset: 0x1E5CB94 VA: 0x1E60B94
	public int get_height() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x1E60B9C Offset: 0x1E5CB9C VA: 0x1E60B9C
	public int get_msaaSamples() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1E60BA4 Offset: 0x1E5CBA4 VA: 0x1E60BA4
	public int get_volumeDepth() { }

	// RVA: 0x1E60B08 Offset: 0x1E5CB08 VA: 0x1E60B08
	public GraphicsFormat get_graphicsFormat() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1E60BAC Offset: 0x1E5CBAC VA: 0x1E60BAC
	public GraphicsFormat get_depthStencilFormat() { }

	[CompilerGenerated]
	// RVA: 0x1E60BB4 Offset: 0x1E5CBB4 VA: 0x1E60BB4
	public void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x1E60B10 Offset: 0x1E5CB10 VA: 0x1E60B10
	public RenderTextureFormat get_colorFormat() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x1E60BBC Offset: 0x1E5CBBC VA: 0x1E60BBC
	public TextureDimension get_dimension() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x1E60BC4 Offset: 0x1E5CBC4 VA: 0x1E60BC4
	public ShadowSamplingMode get_shadowSamplingMode() { }
}

// Namespace: UnityEngine
public struct MipmapLimitDescriptor // TypeDefIndex: 6752
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly bool <useMipmapLimit>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <groupName>k__BackingField; // 0x8

	// Properties
	public bool useMipmapLimit { get; }
	public string groupName { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1E60BCC Offset: 0x1E5CBCC VA: 0x1E60BCC
	public bool get_useMipmapLimit() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1E60BD4 Offset: 0x1E5CBD4 VA: 0x1E60BD4
	public string get_groupName() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Utilities/Hash128.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Export/Hashing/Hash128.bindings.h")]
[Serializable]
public struct Hash128 : IComparable, IComparable<Hash128>, IEquatable<Hash128> // TypeDefIndex: 6753
{
	// Fields
	internal ulong u64_0; // 0x0
	internal ulong u64_1; // 0x8

	// Methods

	// RVA: 0x1E4B164 Offset: 0x1E47164 VA: 0x1E4B164
	public void .ctor(ulong u64_0, ulong u64_1) { }

	// RVA: 0x1E60BDC Offset: 0x1E5CBDC VA: 0x1E60BDC Slot: 5
	public int CompareTo(Hash128 rhs) { }

	// RVA: 0x1E60C68 Offset: 0x1E5CC68 VA: 0x1E60C68 Slot: 3
	public override string ToString() { }

	[FreeFunction("Hash128ToString", IsThreadSafe = True)]
	// RVA: 0x1E60C74 Offset: 0x1E5CC74 VA: 0x1E60C74
	private static string Hash128ToStringImpl(Hash128 hash) { }

	// RVA: 0x1E60D88 Offset: 0x1E5CD88 VA: 0x1E60D88 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E60E14 Offset: 0x1E5CE14 VA: 0x1E60E14 Slot: 6
	public bool Equals(Hash128 obj) { }

	// RVA: 0x1E60E28 Offset: 0x1E5CE28 VA: 0x1E60E28 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E60E5C Offset: 0x1E5CE5C VA: 0x1E60E5C Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0x1E60E04 Offset: 0x1E5CE04 VA: 0x1E60E04
	public static bool op_Equality(Hash128 hash1, Hash128 hash2) { }

	// RVA: 0x1E60C28 Offset: 0x1E5CC28 VA: 0x1E60C28
	public static bool op_LessThan(Hash128 x, Hash128 y) { }

	// RVA: 0x1E60C40 Offset: 0x1E5CC40 VA: 0x1E60C40
	public static bool op_GreaterThan(Hash128 x, Hash128 y) { }

	// RVA: 0x1E60D44 Offset: 0x1E5CD44 VA: 0x1E60D44
	private static void Hash128ToStringImpl_Injected(in Hash128 hash, out ManagedSpanWrapper ret) { }
}

// Namespace: UnityEngine
public enum CursorLockMode // TypeDefIndex: 6754
{
	// Fields
	public int value__; // 0x0
	public const CursorLockMode None = 0;
	public const CursorLockMode Locked = 1;
	public const CursorLockMode Confined = 2;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Input/Cursor.bindings.h")]
public class Cursor // TypeDefIndex: 6755
{
	// Properties
	public static CursorLockMode lockState { get; }

	// Methods

	// RVA: 0x1E60F10 Offset: 0x1E5CF10 VA: 0x1E60F10
	public static CursorLockMode get_lockState() { }
}

// Namespace: UnityEngine
public enum KeyCode // TypeDefIndex: 6756
{
	// Fields
	public int value__; // 0x0
	public const KeyCode None = 0;
	public const KeyCode Backspace = 8;
	public const KeyCode Delete = 127;
	public const KeyCode Tab = 9;
	public const KeyCode Clear = 12;
	public const KeyCode Return = 13;
	public const KeyCode Pause = 19;
	public const KeyCode Escape = 27;
	public const KeyCode Space = 32;
	public const KeyCode Keypad0 = 256;
	public const KeyCode Keypad1 = 257;
	public const KeyCode Keypad2 = 258;
	public const KeyCode Keypad3 = 259;
	public const KeyCode Keypad4 = 260;
	public const KeyCode Keypad5 = 261;
	public const KeyCode Keypad6 = 262;
	public const KeyCode Keypad7 = 263;
	public const KeyCode Keypad8 = 264;
	public const KeyCode Keypad9 = 265;
	public const KeyCode KeypadPeriod = 266;
	public const KeyCode KeypadDivide = 267;
	public const KeyCode KeypadMultiply = 268;
	public const KeyCode KeypadMinus = 269;
	public const KeyCode KeypadPlus = 270;
	public const KeyCode KeypadEnter = 271;
	public const KeyCode KeypadEquals = 272;
	public const KeyCode UpArrow = 273;
	public const KeyCode DownArrow = 274;
	public const KeyCode RightArrow = 275;
	public const KeyCode LeftArrow = 276;
	public const KeyCode Insert = 277;
	public const KeyCode Home = 278;
	public const KeyCode End = 279;
	public const KeyCode PageUp = 280;
	public const KeyCode PageDown = 281;
	public const KeyCode F1 = 282;
	public const KeyCode F2 = 283;
	public const KeyCode F3 = 284;
	public const KeyCode F4 = 285;
	public const KeyCode F5 = 286;
	public const KeyCode F6 = 287;
	public const KeyCode F7 = 288;
	public const KeyCode F8 = 289;
	public const KeyCode F9 = 290;
	public const KeyCode F10 = 291;
	public const KeyCode F11 = 292;
	public const KeyCode F12 = 293;
	public const KeyCode F13 = 294;
	public const KeyCode F14 = 295;
	public const KeyCode F15 = 296;
	public const KeyCode Alpha0 = 48;
	public const KeyCode Alpha1 = 49;
	public const KeyCode Alpha2 = 50;
	public const KeyCode Alpha3 = 51;
	public const KeyCode Alpha4 = 52;
	public const KeyCode Alpha5 = 53;
	public const KeyCode Alpha6 = 54;
	public const KeyCode Alpha7 = 55;
	public const KeyCode Alpha8 = 56;
	public const KeyCode Alpha9 = 57;
	public const KeyCode Exclaim = 33;
	public const KeyCode DoubleQuote = 34;
	public const KeyCode Hash = 35;
	public const KeyCode Dollar = 36;
	public const KeyCode Percent = 37;
	public const KeyCode Ampersand = 38;
	public const KeyCode Quote = 39;
	public const KeyCode LeftParen = 40;
	public const KeyCode RightParen = 41;
	public const KeyCode Asterisk = 42;
	public const KeyCode Plus = 43;
	public const KeyCode Comma = 44;
	public const KeyCode Minus = 45;
	public const KeyCode Period = 46;
	public const KeyCode Slash = 47;
	public const KeyCode Colon = 58;
	public const KeyCode Semicolon = 59;
	public const KeyCode Less = 60;
	public const KeyCode Equals = 61;
	public const KeyCode Greater = 62;
	public const KeyCode Question = 63;
	public const KeyCode At = 64;
	public const KeyCode LeftBracket = 91;
	public const KeyCode Backslash = 92;
	public const KeyCode RightBracket = 93;
	public const KeyCode Caret = 94;
	public const KeyCode Underscore = 95;
	public const KeyCode BackQuote = 96;
	public const KeyCode A = 97;
	public const KeyCode B = 98;
	public const KeyCode C = 99;
	public const KeyCode D = 100;
	public const KeyCode E = 101;
	public const KeyCode F = 102;
	public const KeyCode G = 103;
	public const KeyCode H = 104;
	public const KeyCode I = 105;
	public const KeyCode J = 106;
	public const KeyCode K = 107;
	public const KeyCode L = 108;
	public const KeyCode M = 109;
	public const KeyCode N = 110;
	public const KeyCode O = 111;
	public const KeyCode P = 112;
	public const KeyCode Q = 113;
	public const KeyCode R = 114;
	public const KeyCode S = 115;
	public const KeyCode T = 116;
	public const KeyCode U = 117;
	public const KeyCode V = 118;
	public const KeyCode W = 119;
	public const KeyCode X = 120;
	public const KeyCode Y = 121;
	public const KeyCode Z = 122;
	public const KeyCode LeftCurlyBracket = 123;
	public const KeyCode Pipe = 124;
	public const KeyCode RightCurlyBracket = 125;
	public const KeyCode Tilde = 126;
	public const KeyCode Numlock = 300;
	public const KeyCode CapsLock = 301;
	public const KeyCode ScrollLock = 302;
	public const KeyCode RightShift = 303;
	public const KeyCode LeftShift = 304;
	public const KeyCode RightControl = 305;
	public const KeyCode LeftControl = 306;
	public const KeyCode RightAlt = 307;
	public const KeyCode LeftAlt = 308;
	public const KeyCode LeftMeta = 310;
	public const KeyCode LeftCommand = 310;
	public const KeyCode LeftApple = 310;
	public const KeyCode LeftWindows = 311;
	public const KeyCode RightMeta = 309;
	public const KeyCode RightCommand = 309;
	public const KeyCode RightApple = 309;
	public const KeyCode RightWindows = 312;
	public const KeyCode AltGr = 313;
	public const KeyCode Help = 315;
	public const KeyCode Print = 316;
	public const KeyCode SysReq = 317;
	public const KeyCode Break = 318;
	public const KeyCode Menu = 319;
	public const KeyCode WheelUp = 321;
	public const KeyCode WheelDown = 322;
	public const KeyCode F16 = 670;
	public const KeyCode F17 = 671;
	public const KeyCode F18 = 672;
	public const KeyCode F19 = 673;
	public const KeyCode F20 = 674;
	public const KeyCode F21 = 675;
	public const KeyCode F22 = 676;
	public const KeyCode F23 = 677;
	public const KeyCode F24 = 678;
	public const KeyCode Mouse0 = 323;
	public const KeyCode Mouse1 = 324;
	public const KeyCode Mouse2 = 325;
	public const KeyCode Mouse3 = 326;
	public const KeyCode Mouse4 = 327;
	public const KeyCode Mouse5 = 328;
	public const KeyCode Mouse6 = 329;
	public const KeyCode JoystickButton0 = 330;
	public const KeyCode JoystickButton1 = 331;
	public const KeyCode JoystickButton2 = 332;
	public const KeyCode JoystickButton3 = 333;
	public const KeyCode JoystickButton4 = 334;
	public const KeyCode JoystickButton5 = 335;
	public const KeyCode JoystickButton6 = 336;
	public const KeyCode JoystickButton7 = 337;
	public const KeyCode JoystickButton8 = 338;
	public const KeyCode JoystickButton9 = 339;
	public const KeyCode JoystickButton10 = 340;
	public const KeyCode JoystickButton11 = 341;
	public const KeyCode JoystickButton12 = 342;
	public const KeyCode JoystickButton13 = 343;
	public const KeyCode JoystickButton14 = 344;
	public const KeyCode JoystickButton15 = 345;
	public const KeyCode JoystickButton16 = 346;
	public const KeyCode JoystickButton17 = 347;
	public const KeyCode JoystickButton18 = 348;
	public const KeyCode JoystickButton19 = 349;
	public const KeyCode Joystick1Button0 = 350;
	public const KeyCode Joystick1Button1 = 351;
	public const KeyCode Joystick1Button2 = 352;
	public const KeyCode Joystick1Button3 = 353;
	public const KeyCode Joystick1Button4 = 354;
	public const KeyCode Joystick1Button5 = 355;
	public const KeyCode Joystick1Button6 = 356;
	public const KeyCode Joystick1Button7 = 357;
	public const KeyCode Joystick1Button8 = 358;
	public const KeyCode Joystick1Button9 = 359;
	public const KeyCode Joystick1Button10 = 360;
	public const KeyCode Joystick1Button11 = 361;
	public const KeyCode Joystick1Button12 = 362;
	public const KeyCode Joystick1Button13 = 363;
	public const KeyCode Joystick1Button14 = 364;
	public const KeyCode Joystick1Button15 = 365;
	public const KeyCode Joystick1Button16 = 366;
	public const KeyCode Joystick1Button17 = 367;
	public const KeyCode Joystick1Button18 = 368;
	public const KeyCode Joystick1Button19 = 369;
	public const KeyCode Joystick2Button0 = 370;
	public const KeyCode Joystick2Button1 = 371;
	public const KeyCode Joystick2Button2 = 372;
	public const KeyCode Joystick2Button3 = 373;
	public const KeyCode Joystick2Button4 = 374;
	public const KeyCode Joystick2Button5 = 375;
	public const KeyCode Joystick2Button6 = 376;
	public const KeyCode Joystick2Button7 = 377;
	public const KeyCode Joystick2Button8 = 378;
	public const KeyCode Joystick2Button9 = 379;
	public const KeyCode Joystick2Button10 = 380;
	public const KeyCode Joystick2Button11 = 381;
	public const KeyCode Joystick2Button12 = 382;
	public const KeyCode Joystick2Button13 = 383;
	public const KeyCode Joystick2Button14 = 384;
	public const KeyCode Joystick2Button15 = 385;
	public const KeyCode Joystick2Button16 = 386;
	public const KeyCode Joystick2Button17 = 387;
	public const KeyCode Joystick2Button18 = 388;
	public const KeyCode Joystick2Button19 = 389;
	public const KeyCode Joystick3Button0 = 390;
	public const KeyCode Joystick3Button1 = 391;
	public const KeyCode Joystick3Button2 = 392;
	public const KeyCode Joystick3Button3 = 393;
	public const KeyCode Joystick3Button4 = 394;
	public const KeyCode Joystick3Button5 = 395;
	public const KeyCode Joystick3Button6 = 396;
	public const KeyCode Joystick3Button7 = 397;
	public const KeyCode Joystick3Button8 = 398;
	public const KeyCode Joystick3Button9 = 399;
	public const KeyCode Joystick3Button10 = 400;
	public const KeyCode Joystick3Button11 = 401;
	public const KeyCode Joystick3Button12 = 402;
	public const KeyCode Joystick3Button13 = 403;
	public const KeyCode Joystick3Button14 = 404;
	public const KeyCode Joystick3Button15 = 405;
	public const KeyCode Joystick3Button16 = 406;
	public const KeyCode Joystick3Button17 = 407;
	public const KeyCode Joystick3Button18 = 408;
	public const KeyCode Joystick3Button19 = 409;
	public const KeyCode Joystick4Button0 = 410;
	public const KeyCode Joystick4Button1 = 411;
	public const KeyCode Joystick4Button2 = 412;
	public const KeyCode Joystick4Button3 = 413;
	public const KeyCode Joystick4Button4 = 414;
	public const KeyCode Joystick4Button5 = 415;
	public const KeyCode Joystick4Button6 = 416;
	public const KeyCode Joystick4Button7 = 417;
	public const KeyCode Joystick4Button8 = 418;
	public const KeyCode Joystick4Button9 = 419;
	public const KeyCode Joystick4Button10 = 420;
	public const KeyCode Joystick4Button11 = 421;
	public const KeyCode Joystick4Button12 = 422;
	public const KeyCode Joystick4Button13 = 423;
	public const KeyCode Joystick4Button14 = 424;
	public const KeyCode Joystick4Button15 = 425;
	public const KeyCode Joystick4Button16 = 426;
	public const KeyCode Joystick4Button17 = 427;
	public const KeyCode Joystick4Button18 = 428;
	public const KeyCode Joystick4Button19 = 429;
	public const KeyCode Joystick5Button0 = 430;
	public const KeyCode Joystick5Button1 = 431;
	public const KeyCode Joystick5Button2 = 432;
	public const KeyCode Joystick5Button3 = 433;
	public const KeyCode Joystick5Button4 = 434;
	public const KeyCode Joystick5Button5 = 435;
	public const KeyCode Joystick5Button6 = 436;
	public const KeyCode Joystick5Button7 = 437;
	public const KeyCode Joystick5Button8 = 438;
	public const KeyCode Joystick5Button9 = 439;
	public const KeyCode Joystick5Button10 = 440;
	public const KeyCode Joystick5Button11 = 441;
	public const KeyCode Joystick5Button12 = 442;
	public const KeyCode Joystick5Button13 = 443;
	public const KeyCode Joystick5Button14 = 444;
	public const KeyCode Joystick5Button15 = 445;
	public const KeyCode Joystick5Button16 = 446;
	public const KeyCode Joystick5Button17 = 447;
	public const KeyCode Joystick5Button18 = 448;
	public const KeyCode Joystick5Button19 = 449;
	public const KeyCode Joystick6Button0 = 450;
	public const KeyCode Joystick6Button1 = 451;
	public const KeyCode Joystick6Button2 = 452;
	public const KeyCode Joystick6Button3 = 453;
	public const KeyCode Joystick6Button4 = 454;
	public const KeyCode Joystick6Button5 = 455;
	public const KeyCode Joystick6Button6 = 456;
	public const KeyCode Joystick6Button7 = 457;
	public const KeyCode Joystick6Button8 = 458;
	public const KeyCode Joystick6Button9 = 459;
	public const KeyCode Joystick6Button10 = 460;
	public const KeyCode Joystick6Button11 = 461;
	public const KeyCode Joystick6Button12 = 462;
	public const KeyCode Joystick6Button13 = 463;
	public const KeyCode Joystick6Button14 = 464;
	public const KeyCode Joystick6Button15 = 465;
	public const KeyCode Joystick6Button16 = 466;
	public const KeyCode Joystick6Button17 = 467;
	public const KeyCode Joystick6Button18 = 468;
	public const KeyCode Joystick6Button19 = 469;
	public const KeyCode Joystick7Button0 = 470;
	public const KeyCode Joystick7Button1 = 471;
	public const KeyCode Joystick7Button2 = 472;
	public const KeyCode Joystick7Button3 = 473;
	public const KeyCode Joystick7Button4 = 474;
	public const KeyCode Joystick7Button5 = 475;
	public const KeyCode Joystick7Button6 = 476;
	public const KeyCode Joystick7Button7 = 477;
	public const KeyCode Joystick7Button8 = 478;
	public const KeyCode Joystick7Button9 = 479;
	public const KeyCode Joystick7Button10 = 480;
	public const KeyCode Joystick7Button11 = 481;
	public const KeyCode Joystick7Button12 = 482;
	public const KeyCode Joystick7Button13 = 483;
	public const KeyCode Joystick7Button14 = 484;
	public const KeyCode Joystick7Button15 = 485;
	public const KeyCode Joystick7Button16 = 486;
	public const KeyCode Joystick7Button17 = 487;
	public const KeyCode Joystick7Button18 = 488;
	public const KeyCode Joystick7Button19 = 489;
	public const KeyCode Joystick8Button0 = 490;
	public const KeyCode Joystick8Button1 = 491;
	public const KeyCode Joystick8Button2 = 492;
	public const KeyCode Joystick8Button3 = 493;
	public const KeyCode Joystick8Button4 = 494;
	public const KeyCode Joystick8Button5 = 495;
	public const KeyCode Joystick8Button6 = 496;
	public const KeyCode Joystick8Button7 = 497;
	public const KeyCode Joystick8Button8 = 498;
	public const KeyCode Joystick8Button9 = 499;
	public const KeyCode Joystick8Button10 = 500;
	public const KeyCode Joystick8Button11 = 501;
	public const KeyCode Joystick8Button12 = 502;
	public const KeyCode Joystick8Button13 = 503;
	public const KeyCode Joystick8Button14 = 504;
	public const KeyCode Joystick8Button15 = 505;
	public const KeyCode Joystick8Button16 = 506;
	public const KeyCode Joystick8Button17 = 507;
	public const KeyCode Joystick8Button18 = 508;
	public const KeyCode Joystick8Button19 = 509;
}

// Namespace: UnityEngine
public interface ILogHandler // TypeDefIndex: 6757
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void LogFormat(LogType logType, Object context, string format, object[] args);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void LogException(Exception exception, Object context);
}

// Namespace: UnityEngine
public interface ILogger : ILogHandler // TypeDefIndex: 6758
{
	// Properties
	public abstract ILogHandler logHandler { get; }
	public abstract bool logEnabled { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract ILogHandler get_logHandler();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_logEnabled();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void Log(LogType logType, object message);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Log(LogType logType, object message, Object context);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void LogError(string tag, object message);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void LogFormat(LogType logType, string format, object[] args);
}

// Namespace: UnityEngine
public class Logger : ILogger, ILogHandler // TypeDefIndex: 6759
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ILogHandler <logHandler>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <logEnabled>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private LogType <filterLogType>k__BackingField; // 0x1C

	// Properties
	public ILogHandler logHandler { get; set; }
	public bool logEnabled { get; set; }
	public LogType filterLogType { get; set; }

	// Methods

	// RVA: 0x1E515D8 Offset: 0x1E4D5D8 VA: 0x1E515D8
	public void .ctor(ILogHandler logHandler) { }

	[CompilerGenerated]
	// RVA: 0x1E60F38 Offset: 0x1E5CF38 VA: 0x1E60F38 Slot: 4
	public ILogHandler get_logHandler() { }

	[CompilerGenerated]
	// RVA: 0x1E60F40 Offset: 0x1E5CF40 VA: 0x1E60F40 Slot: 12
	public void set_logHandler(ILogHandler value) { }

	[CompilerGenerated]
	// RVA: 0x1E60F48 Offset: 0x1E5CF48 VA: 0x1E60F48 Slot: 5
	public bool get_logEnabled() { }

	[CompilerGenerated]
	// RVA: 0x1E60F50 Offset: 0x1E5CF50 VA: 0x1E60F50 Slot: 13
	public void set_logEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1E60F58 Offset: 0x1E5CF58 VA: 0x1E60F58 Slot: 14
	public LogType get_filterLogType() { }

	[CompilerGenerated]
	// RVA: 0x1E60F60 Offset: 0x1E5CF60 VA: 0x1E60F60 Slot: 15
	public void set_filterLogType(LogType value) { }

	// RVA: 0x1E60F68 Offset: 0x1E5CF68 VA: 0x1E60F68 Slot: 16
	public bool IsLogTypeAllowed(LogType logType) { }

	// RVA: 0x1E60F9C Offset: 0x1E5CF9C VA: 0x1E60F9C
	private static string GetString(object message) { }

	// RVA: 0x1E610BC Offset: 0x1E5D0BC VA: 0x1E610BC Slot: 6
	public void Log(LogType logType, object message) { }

	// RVA: 0x1E6123C Offset: 0x1E5D23C VA: 0x1E6123C Slot: 7
	public void Log(LogType logType, object message, Object context) { }

	// RVA: 0x1E613C0 Offset: 0x1E5D3C0 VA: 0x1E613C0 Slot: 8
	public void LogError(string tag, object message) { }

	// RVA: 0x1E61568 Offset: 0x1E5D568 VA: 0x1E61568 Slot: 11
	public void LogException(Exception exception, Object context) { }

	// RVA: 0x1E6163C Offset: 0x1E5D63C VA: 0x1E6163C Slot: 9
	public void LogFormat(LogType logType, string format, object[] args) { }

	// RVA: 0x1E61734 Offset: 0x1E5D734 VA: 0x1E61734 Slot: 10
	public void LogFormat(LogType logType, Object context, string format, object[] args) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Logging/UnityLogWriter.bindings.h")]
internal class UnityLogWriter : TextWriter // TypeDefIndex: 6760
{
	// Properties
	public override Encoding Encoding { get; }

	// Methods

	[ThreadAndSerializationSafe]
	// RVA: 0x1E6183C Offset: 0x1E5D83C VA: 0x1E6183C
	public static void WriteStringToUnityLog(string s) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x1E61848 Offset: 0x1E5D848 VA: 0x1E61848
	private static void WriteStringToUnityLogImpl(string s) { }

	// RVA: 0x1E619EC Offset: 0x1E5D9EC VA: 0x1E619EC
	public static void Init() { }

	// RVA: 0x1E61B00 Offset: 0x1E5DB00 VA: 0x1E61B00 Slot: 11
	public override Encoding get_Encoding() { }

	// RVA: 0x1E61B08 Offset: 0x1E5DB08 VA: 0x1E61B08 Slot: 13
	public override void Write(char value) { }

	// RVA: 0x1E61B44 Offset: 0x1E5DB44 VA: 0x1E61B44 Slot: 16
	public override void Write(string s) { }

	// RVA: 0x1E61B54 Offset: 0x1E5DB54 VA: 0x1E61B54 Slot: 15
	public override void Write(char[] buffer, int index, int count) { }

	// RVA: 0x1E61AA8 Offset: 0x1E5DAA8 VA: 0x1E61AA8
	public void .ctor() { }

	// RVA: 0x1E619B0 Offset: 0x1E5D9B0 VA: 0x1E619B0
	private static void WriteStringToUnityLogImpl_Injected(ref ManagedSpanWrapper s) { }
}

// Namespace: UnityEngine
[DefaultMember("Item")]
[NativeHeader("Runtime/Math/Color.h")]
[NativeClass("ColorRGBAf")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct Color : IEquatable<Color>, IFormattable // TypeDefIndex: 6761
{
	// Fields
	public float r; // 0x0
	public float g; // 0x4
	public float b; // 0x8
	public float a; // 0xC

	// Properties
	public static Color red { get; }
	public static Color green { get; }
	public static Color blue { get; }
	public static Color white { get; }
	public static Color black { get; }
	public static Color yellow { get; }
	public static Color cyan { get; }
	public static Color magenta { get; }
	public static Color gray { get; }
	public static Color clear { get; }
	public Color linear { get; }
	public float maxColorComponent { get; }

	// Methods

	// RVA: 0x1E61B6C Offset: 0x1E5DB6C VA: 0x1E61B6C
	public void .ctor(float r, float g, float b, float a) { }

	// RVA: 0x1E61B78 Offset: 0x1E5DB78 VA: 0x1E61B78
	public void .ctor(float r, float g, float b) { }

	// RVA: 0x1E61B8C Offset: 0x1E5DB8C VA: 0x1E61B8C Slot: 3
	public override string ToString() { }

	// RVA: 0x1E61B9C Offset: 0x1E5DB9C VA: 0x1E61B9C Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1E61DD4 Offset: 0x1E5DDD4 VA: 0x1E61DD4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E61E50 Offset: 0x1E5DE50 VA: 0x1E61E50 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1E61F24 Offset: 0x1E5DF24 VA: 0x1E61F24 Slot: 4
	public bool Equals(Color other) { }

	// RVA: 0x1E61FA4 Offset: 0x1E5DFA4 VA: 0x1E61FA4
	public static Color op_Addition(Color a, Color b) { }

	// RVA: 0x1E61FB8 Offset: 0x1E5DFB8 VA: 0x1E61FB8
	public static Color op_Multiply(Color a, Color b) { }

	// RVA: 0x1E61FCC Offset: 0x1E5DFCC VA: 0x1E61FCC
	public static Color op_Multiply(Color a, float b) { }

	// RVA: 0x1E61FE0 Offset: 0x1E5DFE0 VA: 0x1E61FE0
	public static Color op_Division(Color a, float b) { }

	// RVA: 0x1E61FF4 Offset: 0x1E5DFF4 VA: 0x1E61FF4
	public static bool op_Equality(Color lhs, Color rhs) { }

	// RVA: 0x1E62034 Offset: 0x1E5E034 VA: 0x1E62034
	public static Color Lerp(Color a, Color b, float t) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1E62084 Offset: 0x1E5E084 VA: 0x1E62084
	internal Color RGBMultiplied(float multiplier) { }

	// RVA: 0x1E620A0 Offset: 0x1E5E0A0 VA: 0x1E620A0
	public static Color get_red() { }

	// RVA: 0x1E620B4 Offset: 0x1E5E0B4 VA: 0x1E620B4
	public static Color get_green() { }

	// RVA: 0x1E620C8 Offset: 0x1E5E0C8 VA: 0x1E620C8
	public static Color get_blue() { }

	// RVA: 0x1E620DC Offset: 0x1E5E0DC VA: 0x1E620DC
	public static Color get_white() { }

	// RVA: 0x1E620F0 Offset: 0x1E5E0F0 VA: 0x1E620F0
	public static Color get_black() { }

	// RVA: 0x1E62104 Offset: 0x1E5E104 VA: 0x1E62104
	public static Color get_yellow() { }

	// RVA: 0x1E62120 Offset: 0x1E5E120 VA: 0x1E62120
	public static Color get_cyan() { }

	// RVA: 0x1E62134 Offset: 0x1E5E134 VA: 0x1E62134
	public static Color get_magenta() { }

	// RVA: 0x1E62148 Offset: 0x1E5E148 VA: 0x1E62148
	public static Color get_gray() { }

	// RVA: 0x1E6215C Offset: 0x1E5E15C VA: 0x1E6215C
	public static Color get_clear() { }

	// RVA: 0x1E62170 Offset: 0x1E5E170 VA: 0x1E62170
	public Color get_linear() { }

	// RVA: 0x1E621CC Offset: 0x1E5E1CC VA: 0x1E621CC
	public float get_maxColorComponent() { }

	// RVA: 0x1E621E8 Offset: 0x1E5E1E8 VA: 0x1E621E8
	public static Vector4 op_Implicit(Color c) { }

	// RVA: 0x1E621EC Offset: 0x1E5E1EC VA: 0x1E621EC
	public static Color op_Implicit(Vector4 v) { }
}

// Namespace: UnityEngine
[DefaultMember("Item")]
[UsedByNativeCode]
public struct Color32 : IEquatable<Color32>, IFormattable // TypeDefIndex: 6762
{
	// Fields
	[Ignore(DoesNotContributeToSize = True)]
	private int rgba; // 0x0
	public byte r; // 0x0
	public byte g; // 0x1
	public byte b; // 0x2
	public byte a; // 0x3

	// Methods

	// RVA: 0x1E621F0 Offset: 0x1E5E1F0 VA: 0x1E621F0
	public void .ctor(byte r, byte g, byte b, byte a) { }

	// RVA: 0x1E62208 Offset: 0x1E5E208 VA: 0x1E62208
	public static Color32 op_Implicit(Color c) { }

	// RVA: 0x1E624F8 Offset: 0x1E5E4F8 VA: 0x1E624F8
	public static Color op_Implicit(Color32 c) { }

	// RVA: 0x1E62534 Offset: 0x1E5E534 VA: 0x1E62534 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E6253C Offset: 0x1E5E53C VA: 0x1E6253C Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1E625B4 Offset: 0x1E5E5B4 VA: 0x1E625B4 Slot: 4
	public bool Equals(Color32 other) { }

	// RVA: 0x1E625C4 Offset: 0x1E5E5C4 VA: 0x1E625C4 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E625D4 Offset: 0x1E5E5D4 VA: 0x1E625D4 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}

// Namespace: 
internal static class Gradient.BindingsMarshaller // TypeDefIndex: 6763
{
	// Methods

	// RVA: 0x1E62BB8 Offset: 0x1E5EBB8 VA: 0x1E62BB8
	public static IntPtr ConvertToNative(Gradient graident) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
public class Gradient : IEquatable<Gradient> // TypeDefIndex: 6764
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.ParticleSystemModule" })]
	internal IntPtr m_Ptr; // 0x10
	private bool m_RequiresNativeCleanup; // 0x18

	// Methods

	[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = True)]
	// RVA: 0x1E627E0 Offset: 0x1E5E7E0 VA: 0x1E627E0
	private static IntPtr Init() { }

	[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x1E62808 Offset: 0x1E5E808 VA: 0x1E62808
	private void Cleanup() { }

	[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x1E62894 Offset: 0x1E5E894 VA: 0x1E62894
	private bool Internal_Equals(IntPtr other) { }

	[RequiredByNativeCode]
	// RVA: 0x1E62930 Offset: 0x1E5E930 VA: 0x1E62930
	public void .ctor() { }

	[VisibleToOtherModules(new[] { "UnityEngine.ParticleSystemModule" })]
	// RVA: 0x1E6297C Offset: 0x1E5E97C VA: 0x1E6297C
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1E629A8 Offset: 0x1E5E9A8 VA: 0x1E629A8 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1E62A34 Offset: 0x1E5EA34 VA: 0x1E62A34 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1E62B34 Offset: 0x1E5EB34 VA: 0x1E62B34 Slot: 4
	public bool Equals(Gradient other) { }

	// RVA: 0x1E62BAC Offset: 0x1E5EBAC VA: 0x1E62BAC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E62858 Offset: 0x1E5E858 VA: 0x1E62858
	private static void Cleanup_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E628EC Offset: 0x1E5E8EC VA: 0x1E628EC
	private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other) { }
}

// Namespace: UnityEngine
[NativeClass("Matrix4x4f")]
[DefaultMember("Item")]
[NativeType(Header = "Runtime/Math/Matrix4x4.h")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Il2CppEagerStaticClassConstruction]
public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable // TypeDefIndex: 6765
{
	// Fields
	[NativeName("m_Data[0]")]
	public float m00; // 0x0
	[NativeName("m_Data[1]")]
	public float m10; // 0x4
	[NativeName("m_Data[2]")]
	public float m20; // 0x8
	[NativeName("m_Data[3]")]
	public float m30; // 0xC
	[NativeName("m_Data[4]")]
	public float m01; // 0x10
	[NativeName("m_Data[5]")]
	public float m11; // 0x14
	[NativeName("m_Data[6]")]
	public float m21; // 0x18
	[NativeName("m_Data[7]")]
	public float m31; // 0x1C
	[NativeName("m_Data[8]")]
	public float m02; // 0x20
	[NativeName("m_Data[9]")]
	public float m12; // 0x24
	[NativeName("m_Data[10]")]
	public float m22; // 0x28
	[NativeName("m_Data[11]")]
	public float m32; // 0x2C
	[NativeName("m_Data[12]")]
	public float m03; // 0x30
	[NativeName("m_Data[13]")]
	public float m13; // 0x34
	[NativeName("m_Data[14]")]
	public float m23; // 0x38
	[NativeName("m_Data[15]")]
	public float m33; // 0x3C
	private static readonly Matrix4x4 zeroMatrix; // 0x0
	private static readonly Matrix4x4 identityMatrix; // 0x40

	// Methods

	[FreeFunction("MatrixScripting::TRS", IsThreadSafe = True)]
	// RVA: 0x1E62BCC Offset: 0x1E5EBCC VA: 0x1E62BCC
	public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s) { }

	// RVA: 0x1E62CB8 Offset: 0x1E5ECB8 VA: 0x1E62CB8
	public void .ctor(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3) { }

	// RVA: 0x1E62CD4 Offset: 0x1E5ECD4 VA: 0x1E62CD4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E62F44 Offset: 0x1E5EF44 VA: 0x1E62F44 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1E6303C Offset: 0x1E5F03C VA: 0x1E6303C Slot: 4
	public bool Equals(Matrix4x4 other) { }

	// RVA: 0x1E62E74 Offset: 0x1E5EE74 VA: 0x1E62E74
	public Vector4 GetColumn(int index) { }

	// RVA: 0x1E630D8 Offset: 0x1E5F0D8 VA: 0x1E630D8
	public Vector3 MultiplyPoint(Vector3 point) { }

	// RVA: 0x1E63164 Offset: 0x1E5F164 VA: 0x1E63164
	public Vector3 MultiplyPoint3x4(Vector3 point) { }

	// RVA: 0x1E631BC Offset: 0x1E5F1BC VA: 0x1E631BC
	public static Matrix4x4 Rotate(Quaternion q) { }

	// RVA: 0x1E63254 Offset: 0x1E5F254 VA: 0x1E63254 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E63264 Offset: 0x1E5F264 VA: 0x1E63264 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1E6382C Offset: 0x1E5F82C VA: 0x1E6382C
	private static void .cctor() { }

	// RVA: 0x1E62C5C Offset: 0x1E5EC5C VA: 0x1E62C5C
	private static void TRS_Injected(in Vector3 pos, in Quaternion q, in Vector3 s, out Matrix4x4 ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Math/Vector3.h")]
[NativeHeader("Runtime/Math/MathScripting.h")]
[NativeType(Header = "Runtime/Math/Vector3.h")]
[DefaultMember("Item")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[Il2CppEagerStaticClassConstruction]
[NativeClass("Vector3f")]
public struct Vector3 : IEquatable<Vector3>, IFormattable // TypeDefIndex: 6766
{
	// Fields
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	private static readonly Vector3 zeroVector; // 0x0
	private static readonly Vector3 oneVector; // 0xC
	private static readonly Vector3 upVector; // 0x18
	private static readonly Vector3 downVector; // 0x24
	private static readonly Vector3 leftVector; // 0x30
	private static readonly Vector3 rightVector; // 0x3C
	private static readonly Vector3 forwardVector; // 0x48
	private static readonly Vector3 backVector; // 0x54
	private static readonly Vector3 positiveInfinityVector; // 0x60
	private static readonly Vector3 negativeInfinityVector; // 0x6C

	// Properties
	public float Item { get; set; }
	public Vector3 normalized { get; }
	public float sqrMagnitude { get; }
	public static Vector3 zero { get; }
	public static Vector3 one { get; }
	public static Vector3 forward { get; }
	public static Vector3 back { get; }
	public static Vector3 up { get; }
	public static Vector3 down { get; }
	public static Vector3 left { get; }
	public static Vector3 right { get; }

	// Methods

	// RVA: 0x1E638AC Offset: 0x1E5F8AC VA: 0x1E638AC
	public static Vector3 Lerp(Vector3 a, Vector3 b, float t) { }

	// RVA: 0x1E638EC Offset: 0x1E5F8EC VA: 0x1E638EC
	public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta) { }

	// RVA: 0x1E63A00 Offset: 0x1E5FA00 VA: 0x1E63A00
	public float get_Item(int index) { }

	// RVA: 0x1E63A74 Offset: 0x1E5FA74 VA: 0x1E63A74
	public void set_Item(int index, float value) { }

	// RVA: 0x1E63AE8 Offset: 0x1E5FAE8 VA: 0x1E63AE8
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x1E63AF4 Offset: 0x1E5FAF4 VA: 0x1E63AF4
	public void .ctor(float x, float y) { }

	// RVA: 0x1E63B00 Offset: 0x1E5FB00 VA: 0x1E63B00
	public static Vector3 Cross(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x1E63B28 Offset: 0x1E5FB28 VA: 0x1E63B28 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E63B70 Offset: 0x1E5FB70 VA: 0x1E63B70 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1E63C08 Offset: 0x1E5FC08 VA: 0x1E63C08 Slot: 4
	public bool Equals(Vector3 other) { }

	// RVA: 0x1E63C38 Offset: 0x1E5FC38 VA: 0x1E63C38
	public static Vector3 Normalize(Vector3 value) { }

	// RVA: 0x1E63D08 Offset: 0x1E5FD08 VA: 0x1E63D08
	public Vector3 get_normalized() { }

	// RVA: 0x1E63DD4 Offset: 0x1E5FDD4 VA: 0x1E63DD4
	public static float Dot(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x1E63DEC Offset: 0x1E5FDEC VA: 0x1E63DEC
	public static float Magnitude(Vector3 vector) { }

	// RVA: 0x1E63E6C Offset: 0x1E5FE6C VA: 0x1E63E6C
	public float get_sqrMagnitude() { }

	// RVA: 0x1E63E8C Offset: 0x1E5FE8C VA: 0x1E63E8C
	public static Vector3 Min(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x1E63EA8 Offset: 0x1E5FEA8 VA: 0x1E63EA8
	public static Vector3 Max(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x1E63EC4 Offset: 0x1E5FEC4 VA: 0x1E63EC4
	public static Vector3 get_zero() { }

	// RVA: 0x1E63F10 Offset: 0x1E5FF10 VA: 0x1E63F10
	public static Vector3 get_one() { }

	// RVA: 0x1E63F5C Offset: 0x1E5FF5C VA: 0x1E63F5C
	public static Vector3 get_forward() { }

	// RVA: 0x1E63FA8 Offset: 0x1E5FFA8 VA: 0x1E63FA8
	public static Vector3 get_back() { }

	// RVA: 0x1E63FF4 Offset: 0x1E5FFF4 VA: 0x1E63FF4
	public static Vector3 get_up() { }

	// RVA: 0x1E64040 Offset: 0x1E60040 VA: 0x1E64040
	public static Vector3 get_down() { }

	// RVA: 0x1E6408C Offset: 0x1E6008C VA: 0x1E6408C
	public static Vector3 get_left() { }

	// RVA: 0x1E640D8 Offset: 0x1E600D8 VA: 0x1E640D8
	public static Vector3 get_right() { }

	// RVA: 0x1E64124 Offset: 0x1E60124 VA: 0x1E64124
	public static Vector3 op_Addition(Vector3 a, Vector3 b) { }

	// RVA: 0x1E64134 Offset: 0x1E60134 VA: 0x1E64134
	public static Vector3 op_Subtraction(Vector3 a, Vector3 b) { }

	// RVA: 0x1E64144 Offset: 0x1E60144 VA: 0x1E64144
	public static Vector3 op_UnaryNegation(Vector3 a) { }

	// RVA: 0x1E64154 Offset: 0x1E60154 VA: 0x1E64154
	public static Vector3 op_Multiply(Vector3 a, float d) { }

	// RVA: 0x1E64164 Offset: 0x1E60164 VA: 0x1E64164
	public static Vector3 op_Multiply(float d, Vector3 a) { }

	// RVA: 0x1E64178 Offset: 0x1E60178 VA: 0x1E64178
	public static Vector3 op_Division(Vector3 a, float d) { }

	// RVA: 0x1E64188 Offset: 0x1E60188 VA: 0x1E64188
	public static bool op_Equality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x1E641BC Offset: 0x1E601BC VA: 0x1E641BC
	public static bool op_Inequality(Vector3 lhs, Vector3 rhs) { }

	// RVA: 0x1E641F0 Offset: 0x1E601F0 VA: 0x1E641F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E64200 Offset: 0x1E60200 VA: 0x1E64200 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1E643EC Offset: 0x1E603EC VA: 0x1E643EC
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeType(Header = "Runtime/Math/Quaternion.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Math/MathScripting.h")]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct Quaternion : IEquatable<Quaternion>, IFormattable // TypeDefIndex: 6767
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Quaternion identityQuaternion; // 0x0
	public const float kEpsilon = 1E-06;

	// Properties
	public static Quaternion identity { get; }

	// Methods

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x1E660C8 Offset: 0x1E620C8 VA: 0x1E660C8
	public static Quaternion Inverse(Quaternion rotation) { }

	[FreeFunction("EulerToQuaternion", IsThreadSafe = True)]
	// RVA: 0x1E66160 Offset: 0x1E62160 VA: 0x1E66160
	private static Quaternion Internal_FromEulerRad(Vector3 euler) { }

	// RVA: 0x1E661F8 Offset: 0x1E621F8 VA: 0x1E661F8
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x1E66204 Offset: 0x1E62204 VA: 0x1E66204
	public static Quaternion get_identity() { }

	// RVA: 0x1E66250 Offset: 0x1E62250 VA: 0x1E66250
	public static Quaternion op_Multiply(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x1E662C4 Offset: 0x1E622C4 VA: 0x1E662C4
	public static Vector3 op_Multiply(Quaternion rotation, Vector3 point) { }

	// RVA: 0x1E66368 Offset: 0x1E62368 VA: 0x1E66368
	private static bool IsEqualUsingDot(float dot) { }

	// RVA: 0x1E6637C Offset: 0x1E6237C VA: 0x1E6637C
	public static bool op_Equality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x1E663AC Offset: 0x1E623AC VA: 0x1E663AC
	public static bool op_Inequality(Quaternion lhs, Quaternion rhs) { }

	// RVA: 0x1E663DC Offset: 0x1E623DC VA: 0x1E663DC
	public static float Dot(Quaternion a, Quaternion b) { }

	// RVA: 0x1E663FC Offset: 0x1E623FC VA: 0x1E663FC
	public static Quaternion Euler(float x, float y, float z) { }

	// RVA: 0x1E66414 Offset: 0x1E62414 VA: 0x1E66414
	public static Quaternion Euler(Vector3 euler) { }

	// RVA: 0x1E6642C Offset: 0x1E6242C VA: 0x1E6642C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E66490 Offset: 0x1E62490 VA: 0x1E66490 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1E66564 Offset: 0x1E62564 VA: 0x1E66564 Slot: 4
	public bool Equals(Quaternion other) { }

	// RVA: 0x1E665E4 Offset: 0x1E625E4 VA: 0x1E665E4 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E665F4 Offset: 0x1E625F4 VA: 0x1E665F4 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1E6682C Offset: 0x1E6282C VA: 0x1E6682C
	private static void .cctor() { }

	// RVA: 0x1E6611C Offset: 0x1E6211C VA: 0x1E6611C
	private static void Inverse_Injected(in Quaternion rotation, out Quaternion ret) { }

	// RVA: 0x1E661B4 Offset: 0x1E621B4 VA: 0x1E661B4
	private static void Internal_FromEulerRad_Injected(in Vector3 euler, out Quaternion ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Math/FloatConversion.h")]
[NativeHeader("Runtime/Math/ColorSpaceConversion.h")]
[NativeHeader("Runtime/Math/PerlinNoise.h")]
[Il2CppEagerStaticClassConstruction]
public struct Mathf // TypeDefIndex: 6768
{
	// Fields
	public static readonly float Epsilon; // 0x0

	// Methods

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x1E6687C Offset: 0x1E6287C VA: 0x1E6687C
	public static float GammaToLinearSpace(float value) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x1E668B4 Offset: 0x1E628B4 VA: 0x1E668B4
	public static Color CorrelatedColorTemperatureToRGB(float kelvin) { }

	// RVA: 0x1E66958 Offset: 0x1E62958 VA: 0x1E66958
	public static float Sin(float f) { }

	// RVA: 0x1E669BC Offset: 0x1E629BC VA: 0x1E669BC
	public static float Cos(float f) { }

	// RVA: 0x1E66A20 Offset: 0x1E62A20 VA: 0x1E66A20
	public static float Tan(float f) { }

	// RVA: 0x1E66A84 Offset: 0x1E62A84 VA: 0x1E66A84
	public static float Atan(float f) { }

	// RVA: 0x1E66AE8 Offset: 0x1E62AE8 VA: 0x1E66AE8
	public static float Sqrt(float f) { }

	// RVA: 0x1E66B44 Offset: 0x1E62B44 VA: 0x1E66B44
	public static float Abs(float f) { }

	// RVA: 0x1E66BA0 Offset: 0x1E62BA0 VA: 0x1E66BA0
	public static int Abs(int value) { }

	// RVA: 0x1E66BF8 Offset: 0x1E62BF8 VA: 0x1E66BF8
	public static float Min(float a, float b) { }

	// RVA: 0x1E66C04 Offset: 0x1E62C04 VA: 0x1E66C04
	public static int Min(int a, int b) { }

	// RVA: 0x1E66C10 Offset: 0x1E62C10 VA: 0x1E66C10
	public static float Max(float a, float b) { }

	// RVA: 0x1E66C1C Offset: 0x1E62C1C VA: 0x1E66C1C
	public static int Max(int a, int b) { }

	// RVA: 0x1E66C28 Offset: 0x1E62C28 VA: 0x1E66C28
	public static float Pow(float f, float p) { }

	// RVA: 0x1E66C98 Offset: 0x1E62C98 VA: 0x1E66C98
	public static float Log(float f, float p) { }

	// RVA: 0x1E66D08 Offset: 0x1E62D08 VA: 0x1E66D08
	public static float Ceil(float f) { }

	// RVA: 0x1E66D64 Offset: 0x1E62D64 VA: 0x1E66D64
	public static float Floor(float f) { }

	// RVA: 0x1E66DC0 Offset: 0x1E62DC0 VA: 0x1E66DC0
	public static float Round(float f) { }

	// RVA: 0x1E66E88 Offset: 0x1E62E88 VA: 0x1E66E88
	public static int CeilToInt(float f) { }

	// RVA: 0x1E66EFC Offset: 0x1E62EFC VA: 0x1E66EFC
	public static int FloorToInt(float f) { }

	// RVA: 0x1E66F70 Offset: 0x1E62F70 VA: 0x1E66F70
	public static int RoundToInt(float f) { }

	// RVA: 0x1E6704C Offset: 0x1E6304C VA: 0x1E6704C
	public static float Sign(float f) { }

	// RVA: 0x1E67060 Offset: 0x1E63060 VA: 0x1E67060
	public static float Clamp(float value, float min, float max) { }

	// RVA: 0x1E67074 Offset: 0x1E63074 VA: 0x1E67074
	public static int Clamp(int value, int min, int max) { }

	// RVA: 0x1E67088 Offset: 0x1E63088 VA: 0x1E67088
	public static float Clamp01(float value) { }

	// RVA: 0x1E670A4 Offset: 0x1E630A4 VA: 0x1E670A4
	public static float Lerp(float a, float b, float t) { }

	// RVA: 0x1E670CC Offset: 0x1E630CC VA: 0x1E670CC
	public static bool Approximately(float a, float b) { }

	// RVA: 0x1E6715C Offset: 0x1E6315C VA: 0x1E6715C
	public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) { }

	// RVA: 0x1E6722C Offset: 0x1E6322C VA: 0x1E6722C
	public static float Repeat(float t, float length) { }

	// RVA: 0x1E67254 Offset: 0x1E63254 VA: 0x1E67254
	public static float InverseLerp(float a, float b, float value) { }

	// RVA: 0x1E6728C Offset: 0x1E6328C VA: 0x1E6728C
	public static int NextPowerOfTwo(int value) { }

	// RVA: 0x1E672AC Offset: 0x1E632AC VA: 0x1E672AC
	public static bool IsPowerOfTwo(int value) { }

	// RVA: 0x1E672BC Offset: 0x1E632BC VA: 0x1E672BC
	private static void .cctor() { }

	// RVA: 0x1E6690C Offset: 0x1E6290C VA: 0x1E6690C
	private static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret) { }
}

// Namespace: UnityEngine
[NativeClass("Vector2f")]
[Il2CppEagerStaticClassConstruction]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[DefaultMember("Item")]
public struct Vector2 : IEquatable<Vector2>, IFormattable // TypeDefIndex: 6769
{
	// Fields
	public float x; // 0x0
	public float y; // 0x4
	private static readonly Vector2 zeroVector; // 0x0
	private static readonly Vector2 oneVector; // 0x8
	private static readonly Vector2 upVector; // 0x10
	private static readonly Vector2 downVector; // 0x18
	private static readonly Vector2 leftVector; // 0x20
	private static readonly Vector2 rightVector; // 0x28
	private static readonly Vector2 positiveInfinityVector; // 0x30
	private static readonly Vector2 negativeInfinityVector; // 0x38
	public const float kEpsilon = 1E-05;
	public const float kEpsilonNormalSqrt = 1E-15;

	// Properties
	public float Item { get; set; }
	public Vector2 normalized { get; }
	public float magnitude { get; }
	public float sqrMagnitude { get; }
	public static Vector2 zero { get; }
	public static Vector2 one { get; }
	public static Vector2 up { get; }
	public static Vector2 right { get; }

	// Methods

	// RVA: 0x1E67374 Offset: 0x1E63374 VA: 0x1E67374
	public float get_Item(int index) { }

	// RVA: 0x1E673D8 Offset: 0x1E633D8 VA: 0x1E673D8
	public void set_Item(int index, float value) { }

	// RVA: 0x1E6743C Offset: 0x1E6343C VA: 0x1E6743C
	public void .ctor(float x, float y) { }

	// RVA: 0x1E67444 Offset: 0x1E63444 VA: 0x1E67444
	public static Vector2 MoveTowards(Vector2 current, Vector2 target, float maxDistanceDelta) { }

	// RVA: 0x1E67510 Offset: 0x1E63510 VA: 0x1E67510
	public static Vector2 Scale(Vector2 a, Vector2 b) { }

	// RVA: 0x1E6751C Offset: 0x1E6351C VA: 0x1E6751C
	public void Normalize() { }

	// RVA: 0x1E675DC Offset: 0x1E635DC VA: 0x1E675DC
	public Vector2 get_normalized() { }

	// RVA: 0x1E6768C Offset: 0x1E6368C VA: 0x1E6768C Slot: 3
	public override string ToString() { }

	// RVA: 0x1E6769C Offset: 0x1E6369C VA: 0x1E6769C Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1E6783C Offset: 0x1E6383C VA: 0x1E6783C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E67870 Offset: 0x1E63870 VA: 0x1E67870 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1E678F8 Offset: 0x1E638F8 VA: 0x1E678F8 Slot: 4
	public bool Equals(Vector2 other) { }

	// RVA: 0x1E6791C Offset: 0x1E6391C VA: 0x1E6791C
	public static float Dot(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x1E6792C Offset: 0x1E6392C VA: 0x1E6792C
	public float get_magnitude() { }

	// RVA: 0x1E67994 Offset: 0x1E63994 VA: 0x1E67994
	public float get_sqrMagnitude() { }

	// RVA: 0x1E679A4 Offset: 0x1E639A4 VA: 0x1E679A4
	public static float Angle(Vector2 from, Vector2 to) { }

	// RVA: 0x1E67A9C Offset: 0x1E63A9C VA: 0x1E67A9C
	public static float SignedAngle(Vector2 from, Vector2 to) { }

	// RVA: 0x1E67BA4 Offset: 0x1E63BA4 VA: 0x1E67BA4
	public static float Distance(Vector2 a, Vector2 b) { }

	// RVA: 0x1E67C28 Offset: 0x1E63C28 VA: 0x1E67C28
	public static Vector2 op_Addition(Vector2 a, Vector2 b) { }

	// RVA: 0x1E67C34 Offset: 0x1E63C34 VA: 0x1E67C34
	public static Vector2 op_Subtraction(Vector2 a, Vector2 b) { }

	// RVA: 0x1E67C40 Offset: 0x1E63C40 VA: 0x1E67C40
	public static Vector2 op_Multiply(Vector2 a, Vector2 b) { }

	// RVA: 0x1E67C4C Offset: 0x1E63C4C VA: 0x1E67C4C
	public static Vector2 op_Division(Vector2 a, Vector2 b) { }

	// RVA: 0x1E67C58 Offset: 0x1E63C58 VA: 0x1E67C58
	public static Vector2 op_Multiply(Vector2 a, float d) { }

	// RVA: 0x1E67C64 Offset: 0x1E63C64 VA: 0x1E67C64
	public static Vector2 op_Division(Vector2 a, float d) { }

	// RVA: 0x1E67C70 Offset: 0x1E63C70 VA: 0x1E67C70
	public static bool op_Equality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x1E67C98 Offset: 0x1E63C98 VA: 0x1E67C98
	public static bool op_Inequality(Vector2 lhs, Vector2 rhs) { }

	// RVA: 0x1E67CC0 Offset: 0x1E63CC0 VA: 0x1E67CC0
	public static Vector2 op_Implicit(Vector3 v) { }

	// RVA: 0x1E67CC4 Offset: 0x1E63CC4 VA: 0x1E67CC4
	public static Vector3 op_Implicit(Vector2 v) { }

	// RVA: 0x1E67CCC Offset: 0x1E63CCC VA: 0x1E67CCC
	public static Vector2 get_zero() { }

	// RVA: 0x1E67D14 Offset: 0x1E63D14 VA: 0x1E67D14
	public static Vector2 get_one() { }

	// RVA: 0x1E67D5C Offset: 0x1E63D5C VA: 0x1E67D5C
	public static Vector2 get_up() { }

	// RVA: 0x1E67DA4 Offset: 0x1E63DA4 VA: 0x1E67DA4
	public static Vector2 get_right() { }

	// RVA: 0x1E67DEC Offset: 0x1E63DEC VA: 0x1E67DEC
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeType("Runtime/Math/Vector2Int.h")]
[UsedByNativeCode]
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
public struct Vector2Int : IEquatable<Vector2Int>, IFormattable // TypeDefIndex: 6770
{
	// Fields
	private int m_X; // 0x0
	private int m_Y; // 0x4
	private static readonly Vector2Int s_Zero; // 0x0
	private static readonly Vector2Int s_One; // 0x8
	private static readonly Vector2Int s_Up; // 0x10
	private static readonly Vector2Int s_Down; // 0x18
	private static readonly Vector2Int s_Left; // 0x20
	private static readonly Vector2Int s_Right; // 0x28

	// Properties
	public int x { get; set; }
	public int y { get; set; }

	// Methods

	// RVA: 0x1E67EA0 Offset: 0x1E63EA0 VA: 0x1E67EA0
	public int get_x() { }

	// RVA: 0x1E67EA8 Offset: 0x1E63EA8 VA: 0x1E67EA8
	public void set_x(int value) { }

	// RVA: 0x1E67EB0 Offset: 0x1E63EB0 VA: 0x1E67EB0
	public int get_y() { }

	// RVA: 0x1E67EB8 Offset: 0x1E63EB8 VA: 0x1E67EB8
	public void set_y(int value) { }

	// RVA: 0x1E67EC0 Offset: 0x1E63EC0 VA: 0x1E67EC0
	public void .ctor(int x, int y) { }

	// RVA: 0x1E67EC8 Offset: 0x1E63EC8 VA: 0x1E67EC8
	public static Vector2 op_Implicit(Vector2Int v) { }

	// RVA: 0x1E67ED8 Offset: 0x1E63ED8 VA: 0x1E67ED8 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1E67F60 Offset: 0x1E63F60 VA: 0x1E67F60 Slot: 4
	public bool Equals(Vector2Int other) { }

	// RVA: 0x1E67F88 Offset: 0x1E63F88 VA: 0x1E67F88 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E67FAC Offset: 0x1E63FAC VA: 0x1E67FAC Slot: 3
	public override string ToString() { }

	// RVA: 0x1E67FBC Offset: 0x1E63FBC VA: 0x1E67FBC Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1E68150 Offset: 0x1E64150 VA: 0x1E68150
	private static void .cctor() { }
}

// Namespace: UnityEngine
[DefaultMember("Item")]
[Il2CppEagerStaticClassConstruction]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/Math/Vector4.h")]
[NativeClass("Vector4f")]
public struct Vector4 : IEquatable<Vector4>, IFormattable // TypeDefIndex: 6771
{
	// Fields
	public const float kEpsilon = 1E-05;
	public float x; // 0x0
	public float y; // 0x4
	public float z; // 0x8
	public float w; // 0xC
	private static readonly Vector4 zeroVector; // 0x0
	private static readonly Vector4 oneVector; // 0x10
	private static readonly Vector4 positiveInfinityVector; // 0x20
	private static readonly Vector4 negativeInfinityVector; // 0x30

	// Properties
	public float Item { get; set; }
	public float sqrMagnitude { get; }
	public static Vector4 zero { get; }

	// Methods

	// RVA: 0x1E681D8 Offset: 0x1E641D8 VA: 0x1E681D8
	public float get_Item(int index) { }

	// RVA: 0x1E68264 Offset: 0x1E64264 VA: 0x1E68264
	public void set_Item(int index, float value) { }

	// RVA: 0x1E682F0 Offset: 0x1E642F0 VA: 0x1E682F0
	public void .ctor(float x, float y, float z, float w) { }

	// RVA: 0x1E682FC Offset: 0x1E642FC VA: 0x1E682FC
	public void .ctor(float x, float y) { }

	// RVA: 0x1E68308 Offset: 0x1E64308 VA: 0x1E68308 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E6836C Offset: 0x1E6436C VA: 0x1E6836C Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1E68414 Offset: 0x1E64414 VA: 0x1E68414 Slot: 4
	public bool Equals(Vector4 other) { }

	// RVA: 0x1E68450 Offset: 0x1E64450 VA: 0x1E68450
	public static float Dot(Vector4 a, Vector4 b) { }

	// RVA: 0x1E68470 Offset: 0x1E64470 VA: 0x1E68470
	public float get_sqrMagnitude() { }

	// RVA: 0x1E68494 Offset: 0x1E64494 VA: 0x1E68494
	public static Vector4 get_zero() { }

	// RVA: 0x1E684E0 Offset: 0x1E644E0 VA: 0x1E684E0
	public static Vector4 op_Multiply(Vector4 a, float d) { }

	// RVA: 0x1E684F4 Offset: 0x1E644F4 VA: 0x1E684F4
	public static Vector4 op_Division(Vector4 a, float d) { }

	// RVA: 0x1E68508 Offset: 0x1E64508 VA: 0x1E68508
	public static bool op_Equality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x1E68548 Offset: 0x1E64548 VA: 0x1E68548
	public static bool op_Inequality(Vector4 lhs, Vector4 rhs) { }

	// RVA: 0x1E68588 Offset: 0x1E64588 VA: 0x1E68588
	public static Vector4 op_Implicit(Vector3 v) { }

	// RVA: 0x1E68590 Offset: 0x1E64590 VA: 0x1E68590
	public static Vector3 op_Implicit(Vector4 v) { }

	// RVA: 0x1E68594 Offset: 0x1E64594 VA: 0x1E68594
	public static Vector4 op_Implicit(Vector2 v) { }

	// RVA: 0x1E685A0 Offset: 0x1E645A0 VA: 0x1E685A0
	public static Vector2 op_Implicit(Vector4 v) { }

	// RVA: 0x1E685A4 Offset: 0x1E645A4 VA: 0x1E685A4 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E685B4 Offset: 0x1E645B4 VA: 0x1E685B4 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x1E687EC Offset: 0x1E647EC VA: 0x1E687EC
	private static void .cctor() { }
}

// Namespace: UnityEngine
internal struct TypeDispatchData : IDisposable // TypeDefIndex: 6772
{
	// Fields
	public Object[] changed; // 0x0
	public NativeArray<int> changedID; // 0x8
	public NativeArray<int> destroyedID; // 0x18

	// Methods

	// RVA: 0x1E68860 Offset: 0x1E64860 VA: 0x1E68860 Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine
internal struct TransformDispatchData : IDisposable // TypeDefIndex: 6773
{
	// Fields
	public NativeArray<int> transformedID; // 0x0
	public NativeArray<int> parentID; // 0x10
	public NativeArray<Matrix4x4> localToWorldMatrices; // 0x20
	public NativeArray<Vector3> positions; // 0x30
	public NativeArray<Quaternion> rotations; // 0x40
	public NativeArray<Vector3> scales; // 0x50

	// Methods

	// RVA: 0x1E688C8 Offset: 0x1E648C8 VA: 0x1E688C8 Slot: 4
	public void Dispose() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ObjectDispatcher.<>c // TypeDefIndex: 6774
{
	// Fields
	public static readonly ObjectDispatcher.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1E68AD4 Offset: 0x1E64AD4 VA: 0x1E68AD4
	private static void .cctor() { }

	// RVA: 0x1E68B3C Offset: 0x1E64B3C VA: 0x1E68B3C
	public void .ctor() { }

	// RVA: 0x1E68B44 Offset: 0x1E64B44 VA: 0x1E68B44
	internal void <.cctor>b__64_0(Object[] changed, IntPtr changedID, IntPtr destroyedID, int changedCount, int destroyedCount, Action<TypeDispatchData> callback) { }

	// RVA: 0x1E68C4C Offset: 0x1E64C4C VA: 0x1E68C4C
	internal void <.cctor>b__64_1(IntPtr transformed, IntPtr parents, IntPtr localToWorldMatrices, IntPtr positions, IntPtr rotations, IntPtr scales, int count, Action<TransformDispatchData> callback) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[StaticAccessor("GetObjectDispatcher()", 0)]
[NativeHeader("Runtime/Misc/ObjectDispatcher.h")]
internal sealed class ObjectDispatcher // TypeDefIndex: 6775
{
	// Fields
	private IntPtr m_Ptr; // 0x10
	private static Action<Object[], IntPtr, IntPtr, int, int, Action<TypeDispatchData>> s_TypeDispatch; // 0x0
	private static Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, Action<TransformDispatchData>> s_TransformDispatch; // 0x8

	// Methods

	// RVA: 0x1E68998 Offset: 0x1E64998 VA: 0x1E68998
	private static void .cctor() { }
}

// Namespace: UnityEngine
internal interface IPlayerEditorConnectionNative // TypeDefIndex: 6776
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DisconnectAll();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SendMessage(Guid messageId, byte[] data, int playerId);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool TrySendMessage(Guid messageId, byte[] data, int playerId);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Poll();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void RegisterInternal(Guid messageId);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void UnregisterInternal(Guid messageId);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool IsConnected();
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/PlayerConnection/PlayerConnectionInternal.bindings.h")]
internal class PlayerConnectionInternal : IPlayerEditorConnectionNative // TypeDefIndex: 6777
{
	// Methods

	// RVA: 0x1E68DFC Offset: 0x1E64DFC VA: 0x1E68DFC Slot: 6
	private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x1E690C0 Offset: 0x1E650C0 VA: 0x1E690C0 Slot: 7
	private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x1E69394 Offset: 0x1E65394 VA: 0x1E69394 Slot: 8
	private void UnityEngine.IPlayerEditorConnectionNative.Poll() { }

	// RVA: 0x1E693E4 Offset: 0x1E653E4 VA: 0x1E693E4 Slot: 9
	private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId) { }

	// RVA: 0x1E69580 Offset: 0x1E65580 VA: 0x1E69580 Slot: 10
	private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId) { }

	// RVA: 0x1E6971C Offset: 0x1E6571C VA: 0x1E6971C Slot: 4
	private void UnityEngine.IPlayerEditorConnectionNative.Initialize() { }

	// RVA: 0x1E6976C Offset: 0x1E6576C VA: 0x1E6976C Slot: 11
	private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected() { }

	// RVA: 0x1E697BC Offset: 0x1E657BC VA: 0x1E697BC Slot: 5
	private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll() { }

	[FreeFunction("PlayerConnection_Bindings::IsConnected")]
	// RVA: 0x1E69794 Offset: 0x1E65794 VA: 0x1E69794
	private static bool IsConnected() { }

	[FreeFunction("PlayerConnection_Bindings::Initialize")]
	// RVA: 0x1E69744 Offset: 0x1E65744 VA: 0x1E69744
	private static void Initialize() { }

	[FreeFunction("PlayerConnection_Bindings::RegisterInternal")]
	// RVA: 0x1E69440 Offset: 0x1E65440 VA: 0x1E69440
	private static void RegisterInternal(string messageId) { }

	[FreeFunction("PlayerConnection_Bindings::UnregisterInternal")]
	// RVA: 0x1E695DC Offset: 0x1E655DC VA: 0x1E695DC
	private static void UnregisterInternal(string messageId) { }

	[FreeFunction("PlayerConnection_Bindings::SendMessage")]
	// RVA: 0x1E68EFC Offset: 0x1E64EFC VA: 0x1E68EFC
	private static void SendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunction("PlayerConnection_Bindings::TrySendMessage")]
	// RVA: 0x1E691C4 Offset: 0x1E651C4 VA: 0x1E691C4
	private static bool TrySendMessage(string messageId, byte[] data, int playerId) { }

	[FreeFunction("PlayerConnection_Bindings::PollInternal")]
	// RVA: 0x1E693BC Offset: 0x1E653BC VA: 0x1E693BC
	private static void PollInternal() { }

	[FreeFunction("PlayerConnection_Bindings::DisconnectAll")]
	// RVA: 0x1E697E4 Offset: 0x1E657E4 VA: 0x1E697E4
	private static void DisconnectAll() { }

	// RVA: 0x1E69938 Offset: 0x1E65938 VA: 0x1E69938
	public void .ctor() { }

	// RVA: 0x1E69818 Offset: 0x1E65818 VA: 0x1E69818
	private static void RegisterInternal_Injected(ref ManagedSpanWrapper messageId) { }

	// RVA: 0x1E69854 Offset: 0x1E65854 VA: 0x1E69854
	private static void UnregisterInternal_Injected(ref ManagedSpanWrapper messageId) { }

	// RVA: 0x1E69890 Offset: 0x1E65890 VA: 0x1E69890
	private static void SendMessage_Injected(ref ManagedSpanWrapper messageId, ref ManagedSpanWrapper data, int playerId) { }

	// RVA: 0x1E698E4 Offset: 0x1E658E4 VA: 0x1E698E4
	private static bool TrySendMessage_Injected(ref ManagedSpanWrapper messageId, ref ManagedSpanWrapper data, int playerId) { }
}

// Namespace: UnityEngine
[Usage(384, Inherited = True, AllowMultiple = False)]
[UsedByNativeCode]
public abstract class PropertyAttribute : Attribute // TypeDefIndex: 6778
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly bool <applyToCollection>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1E69940 Offset: 0x1E65940 VA: 0x1E69940
	protected void .ctor() { }

	// RVA: 0x1E6995C Offset: 0x1E6595C VA: 0x1E6995C
	protected void .ctor(bool applyToCollection) { }
}

// Namespace: UnityEngine
[Usage(32767, Inherited = True, AllowMultiple = False)]
public class TooltipAttribute : PropertyAttribute // TypeDefIndex: 6779
{
	// Fields
	public readonly string tooltip; // 0x18

	// Methods

	// RVA: 0x1E69984 Offset: 0x1E65984 VA: 0x1E69984
	public void .ctor(string tooltip) { }
}

// Namespace: UnityEngine
[Usage(256, Inherited = True, AllowMultiple = True)]
public class SpaceAttribute : PropertyAttribute // TypeDefIndex: 6780
{
	// Fields
	public readonly float height; // 0x14

	// Methods

	// RVA: 0x1E699B8 Offset: 0x1E659B8 VA: 0x1E699B8
	public void .ctor() { }

	// RVA: 0x1E699E0 Offset: 0x1E659E0 VA: 0x1E699E0
	public void .ctor(float height) { }
}

// Namespace: UnityEngine
[Usage(384, Inherited = True, AllowMultiple = False)]
public sealed class RangeAttribute : PropertyAttribute // TypeDefIndex: 6781
{
	// Fields
	public readonly float min; // 0x14
	public readonly float max; // 0x18

	// Methods

	// RVA: 0x1E69A10 Offset: 0x1E65A10 VA: 0x1E69A10
	public void .ctor(float min, float max) { }
}

// Namespace: UnityEngine
[Usage(384, Inherited = True, AllowMultiple = False)]
public sealed class MultilineAttribute : PropertyAttribute // TypeDefIndex: 6782
{
	// Fields
	public readonly int lines; // 0x14

	// Methods

	// RVA: 0x1E69A40 Offset: 0x1E65A40 VA: 0x1E69A40
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(384, Inherited = True, AllowMultiple = False)]
public sealed class TextAreaAttribute : PropertyAttribute // TypeDefIndex: 6783
{
	// Fields
	public readonly int minLines; // 0x14
	public readonly int maxLines; // 0x18

	// Methods

	// RVA: 0x1E69A64 Offset: 0x1E65A64 VA: 0x1E69A64
	public void .ctor(int minLines, int maxLines) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
public static class Random // TypeDefIndex: 6784
{
	// Methods

	// RVA: 0x1E69A94 Offset: 0x1E65A94 VA: 0x1E69A94
	public static int Range(int minInclusive, int maxExclusive) { }

	[FreeFunction]
	// RVA: 0x1E69AD8 Offset: 0x1E65AD8 VA: 0x1E69AD8
	private static int RandomRangeInt(int minInclusive, int maxExclusive) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public class ResourceRequest : AsyncOperation // TypeDefIndex: 6785
{
	// Fields
	internal string m_Path; // 0x20
	internal Type m_Type; // 0x28
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
internal static class ResourcesAPIInternal // TypeDefIndex: 6786
{
	// Methods

	[TypeInferenceRule(2)]
	[FreeFunction("Resources_Bindings::FindObjectsOfTypeAll")]
	// RVA: 0x1E69B1C Offset: 0x1E65B1C VA: 0x1E69B1C
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	[FreeFunction("GetShaderNameRegistry().FindShader")]
	// RVA: 0x1E69B58 Offset: 0x1E65B58 VA: 0x1E69B58
	public static Shader FindShaderByName(string name) { }

	[FreeFunction("Resources_Bindings::Load")]
	[NativeThrows]
	[TypeInferenceRule(1)]
	// RVA: 0x1E69D68 Offset: 0x1E65D68 VA: 0x1E69D68
	public static Object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x1E69D2C Offset: 0x1E65D2C VA: 0x1E69D2C
	private static IntPtr FindShaderByName_Injected(ref ManagedSpanWrapper name) { }

	// RVA: 0x1E69F98 Offset: 0x1E65F98 VA: 0x1E69F98
	private static IntPtr Load_Injected(ref ManagedSpanWrapper path, Type systemTypeInstance) { }
}

// Namespace: UnityEngine
public class ResourcesAPI // TypeDefIndex: 6787
{
	// Fields
	private static ResourcesAPI s_DefaultAPI; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static ResourcesAPI <overrideAPI>k__BackingField; // 0x8

	// Properties
	internal static ResourcesAPI ActiveAPI { get; }
	public static ResourcesAPI overrideAPI { get; }

	// Methods

	// RVA: 0x1E69FDC Offset: 0x1E65FDC VA: 0x1E69FDC
	internal static ResourcesAPI get_ActiveAPI() { }

	[CompilerGenerated]
	// RVA: 0x1E6A084 Offset: 0x1E66084 VA: 0x1E6A084
	public static ResourcesAPI get_overrideAPI() { }

	// RVA: 0x1E6A0DC Offset: 0x1E660DC VA: 0x1E6A0DC
	protected internal void .ctor() { }

	// RVA: 0x1E6A0E4 Offset: 0x1E660E4 VA: 0x1E6A0E4 Slot: 4
	protected internal virtual Object[] FindObjectsOfTypeAll(Type systemTypeInstance) { }

	// RVA: 0x1E6A120 Offset: 0x1E66120 VA: 0x1E6A120 Slot: 5
	protected internal virtual Shader FindShaderByName(string name) { }

	// RVA: 0x1E6A128 Offset: 0x1E66128 VA: 0x1E6A128 Slot: 6
	protected internal virtual Object Load(string path, Type systemTypeInstance) { }

	// RVA: 0x1E6A134 Offset: 0x1E66134 VA: 0x1E6A134
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Resources/Resources.bindings.h")]
[NativeHeader("Runtime/Misc/ResourceManagerUtility.h")]
public sealed class Resources // TypeDefIndex: 6788
{
	// Methods

	// RVA: 0x1E6A19C Offset: 0x1E6619C VA: 0x1E6A19C
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	// RVA: 0x1E6A204 Offset: 0x1E66204 VA: 0x1E6A204
	public static Object Load(string path) { }

	// RVA: -1 Offset: -1
	public static T Load<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114297C Offset: 0x113E97C VA: 0x114297C
	|-Resources.Load<object>
	*/

	// RVA: 0x1E6A274 Offset: 0x1E66274 VA: 0x1E6A274
	public static Object Load(string path, Type systemTypeInstance) { }

	[FreeFunction("GetScriptingBuiltinResource", ThrowsException = True)]
	[TypeInferenceRule(0)]
	// RVA: 0x1E6A2EC Offset: 0x1E662EC VA: 0x1E6A2EC
	public static Object GetBuiltinResource(Type type, string path) { }

	// RVA: -1 Offset: -1
	public static T GetBuiltinResource<T>(string path) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11428D0 Offset: 0x113E8D0 VA: 0x11428D0
	|-Resources.GetBuiltinResource<object>
	*/

	[FreeFunction("Resources_Bindings::UnloadUnusedAssets")]
	// RVA: 0x1E6A510 Offset: 0x1E66510 VA: 0x1E6A510
	public static AsyncOperation UnloadUnusedAssets() { }

	// RVA: 0x1E6A4CC Offset: 0x1E664CC VA: 0x1E6A4CC
	private static IntPtr GetBuiltinResource_Injected(Type type, ref ManagedSpanWrapper path) { }

	// RVA: 0x1E6A548 Offset: 0x1E66548 VA: 0x1E6A548
	private static IntPtr UnloadUnusedAssets_Injected() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Runtime/GameCode/AsyncInstantiate/AsyncInstantiateOperation.h")]
public class AsyncInstantiateOperation : AsyncOperation // TypeDefIndex: 6789
{
	// Fields
	internal static CancellationTokenSource s_GlobalCancellation; // 0x0
	internal Object[] m_Result; // 0x20
	private CancellationToken m_CancellationToken; // 0x28

	// Methods

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x1E6A5C8 Offset: 0x1E665C8 VA: 0x1E6A5C8
	private bool IsCancellationRequested() { }

	// RVA: 0x1E6A620 Offset: 0x1E66620 VA: 0x1E6A620 Slot: 4
	internal virtual Object[] CreateResultArray(int size) { }

	// RVA: 0x1E6A68C Offset: 0x1E6668C VA: 0x1E6A68C
	private static void .cctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
internal class AsyncInstantiateOperationHelper // TypeDefIndex: 6790
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E6A708 Offset: 0x1E66708 VA: 0x1E6A708
	public static Object[] CreateAsyncInstantiateOperationResultArray(AsyncInstantiateOperation op, int size) { }
}

// Namespace: 
internal static class AsyncOperation.BindingsMarshaller // TypeDefIndex: 6791
{
	// Methods

	// RVA: 0x1E6A570 Offset: 0x1E66570 VA: 0x1E6A570
	public static AsyncOperation ConvertToManaged(IntPtr ptr) { }

	// RVA: 0x1E6A9CC Offset: 0x1E669CC VA: 0x1E6A9CC
	public static IntPtr ConvertToNative(AsyncOperation asyncOperation) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
[NativeHeader("Runtime/Misc/AsyncOperation.h")]
[RequiredByNativeCode]
public class AsyncOperation : YieldInstruction // TypeDefIndex: 6792
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.AssetBundleModule" })]
	internal IntPtr m_Ptr; // 0x10
	private Action<AsyncOperation> m_completeCallback; // 0x18

	// Properties
	public bool isDone { get; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	[StaticAccessor("AsyncOperationBindings", 2)]
	// RVA: 0x1E6A720 Offset: 0x1E66720 VA: 0x1E6A720
	private static void InternalDestroy(IntPtr ptr) { }

	[StaticAccessor("AsyncOperationBindings", 2)]
	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x1E6A75C Offset: 0x1E6675C VA: 0x1E6A75C
	private static void InternalSetManagedObject(IntPtr ptr, AsyncOperation self) { }

	// RVA: 0x1E6A7A0 Offset: 0x1E667A0 VA: 0x1E6A7A0
	protected void .ctor(IntPtr ptr) { }

	[NativeMethod("IsDone")]
	// RVA: 0x1E6A800 Offset: 0x1E66800 VA: 0x1E6A800
	public bool get_isDone() { }

	// RVA: 0x1E6A8CC Offset: 0x1E668CC VA: 0x1E6A8CC Slot: 1
	protected override void Finalize() { }

	[RequiredByNativeCode]
	// RVA: 0x1E6A97C Offset: 0x1E6697C VA: 0x1E6A97C
	internal void InvokeCompletionEvent() { }

	// RVA: 0x1E6A890 Offset: 0x1E66890 VA: 0x1E6A890
	private static bool get_isDone_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
internal class AttributeHelperEngine // TypeDefIndex: 6793
{
	// Fields
	public static DisallowMultipleComponent[] _disallowMultipleComponentArray; // 0x0
	public static ExecuteInEditMode[] _executeInEditModeArray; // 0x8
	public static RequireComponent[] _requireComponentArray; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E6A9E0 Offset: 0x1E669E0 VA: 0x1E6A9E0
	private static Type GetParentTypeDisallowingMultipleInclusion(Type type) { }

	[RequiredByNativeCode]
	// RVA: 0x1E6AB08 Offset: 0x1E66B08 VA: 0x1E6AB08
	private static Type[] GetRequiredComponents(Type klass) { }

	// RVA: 0x1E6B010 Offset: 0x1E67010 VA: 0x1E6B010
	private static int GetExecuteMode(Type klass) { }

	[RequiredByNativeCode]
	// RVA: 0x1E6B110 Offset: 0x1E67110 VA: 0x1E6B110
	private static int CheckIsEditorScript(Type klass) { }

	[RequiredByNativeCode]
	// RVA: 0x1E6B214 Offset: 0x1E67214 VA: 0x1E6B214
	private static int GetDefaultExecutionOrderFor(Type klass) { }

	// RVA: -1 Offset: -1
	private static T GetCustomAttributeOfType<T>(Type klass) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EC5F0 Offset: 0x10E85F0 VA: 0x10EC5F0
	|-AttributeHelperEngine.GetCustomAttributeOfType<object>
	*/

	// RVA: 0x1E6B294 Offset: 0x1E67294 VA: 0x1E6B294
	private static void .cctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Usage(4, Inherited = False)]
public sealed class DisallowMultipleComponent : Attribute // TypeDefIndex: 6794
{
	// Methods

	// RVA: 0x1E6B380 Offset: 0x1E67380 VA: 0x1E6B380
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(4, AllowMultiple = True)]
[RequiredByNativeCode]
public sealed class RequireComponent : Attribute // TypeDefIndex: 6795
{
	// Fields
	public Type m_Type0; // 0x10
	public Type m_Type1; // 0x18
	public Type m_Type2; // 0x20

	// Methods

	// RVA: 0x1E6B388 Offset: 0x1E67388 VA: 0x1E6B388
	public void .ctor(Type requiredComponent) { }
}

// Namespace: UnityEngine
public sealed class AddComponentMenu : Attribute // TypeDefIndex: 6796
{
	// Fields
	private string m_AddComponentMenu; // 0x10
	private int m_Ordering; // 0x18

	// Methods

	// RVA: 0x1E6B3B8 Offset: 0x1E673B8 VA: 0x1E6B3B8
	public void .ctor(string menuName) { }

	// RVA: 0x1E6B3F0 Offset: 0x1E673F0 VA: 0x1E6B3F0
	public void .ctor(string menuName, int order) { }
}

// Namespace: UnityEngine
[Usage(4, AllowMultiple = False, Inherited = False)]
public sealed class CreateAssetMenuAttribute : Attribute // TypeDefIndex: 6797
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <menuName>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <fileName>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <order>k__BackingField; // 0x20

	// Properties
	public string menuName { set; }
	public string fileName { set; }
	public int order { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E6B42C Offset: 0x1E6742C VA: 0x1E6B42C
	public void set_menuName(string value) { }

	[CompilerGenerated]
	// RVA: 0x1E6B434 Offset: 0x1E67434 VA: 0x1E6B434
	public void set_fileName(string value) { }

	[CompilerGenerated]
	// RVA: 0x1E6B43C Offset: 0x1E6743C VA: 0x1E6B43C
	public void set_order(int value) { }

	// RVA: 0x1E6B444 Offset: 0x1E67444 VA: 0x1E6B444
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Usage(64, AllowMultiple = True)]
public sealed class ContextMenu : Attribute // TypeDefIndex: 6798
{}

// Namespace: UnityEngine
[UsedByNativeCode]
public sealed class ExecuteInEditMode : Attribute // TypeDefIndex: 6799
{
	// Methods

	// RVA: 0x1E6B44C Offset: 0x1E6744C VA: 0x1E6B44C
	public void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public sealed class ExecuteAlways : Attribute // TypeDefIndex: 6800
{
	// Methods

	// RVA: 0x1E6B454 Offset: 0x1E67454 VA: 0x1E6B454
	public void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public sealed class HideInInspector : Attribute // TypeDefIndex: 6801
{
	// Methods

	// RVA: 0x1E6B45C Offset: 0x1E6745C VA: 0x1E6B45C
	public void .ctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[Usage(64)]
public sealed class HideInCallstackAttribute : Attribute // TypeDefIndex: 6802
{}

// Namespace: UnityEngine
[UsedByNativeCode]
[Usage(4, AllowMultiple = False)]
public class HelpURLAttribute : Attribute // TypeDefIndex: 6803
{
	// Fields
	internal readonly string m_Url; // 0x10
	internal readonly bool m_Dispatcher; // 0x18
	internal readonly string m_DispatchingFieldName; // 0x20

	// Methods

	// RVA: 0x1E6B464 Offset: 0x1E67464 VA: 0x1E6B464
	public void .ctor(string url) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[Usage(4)]
public class DefaultExecutionOrder : Attribute // TypeDefIndex: 6804
{
	// Fields
	private int m_Order; // 0x10

	// Properties
	public int order { get; }

	// Methods

	// RVA: 0x1E6B28C Offset: 0x1E6728C VA: 0x1E6B28C
	public int get_order() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Usage(1)]
public class AssemblyIsEditorAssembly : Attribute // TypeDefIndex: 6805
{}

// Namespace: UnityEngine
[Usage(4, Inherited = False)]
[UsedByNativeCode]
public class ExcludeFromPresetAttribute : Attribute // TypeDefIndex: 6806
{
	// Methods

	// RVA: 0x1E6B4E0 Offset: 0x1E674E0 VA: 0x1E6B4E0
	public void .ctor() { }
}

// Namespace: 
internal enum Awaitable.AwaiterCompletionThreadAffinity // TypeDefIndex: 6807
{
	// Fields
	public int value__; // 0x0
	public const Awaitable.AwaiterCompletionThreadAffinity None = 0;
	public const Awaitable.AwaiterCompletionThreadAffinity MainThread = 1;
	public const Awaitable.AwaiterCompletionThreadAffinity BackgroundThread = 2;
}

// Namespace: 
private interface Awaitable.AwaitableAsyncMethodBuilder.IStateMachineBox : IDisposable // TypeDefIndex: 6808
{}

// Namespace: 
[ExcludeFromDocs]
public struct Awaitable.AwaitableAsyncMethodBuilder // TypeDefIndex: 6809
{
	// Fields
	private Awaitable.AwaitableAsyncMethodBuilder.IStateMachineBox _stateMachineBox; // 0x0
	private Awaitable _resultingCoroutine; // 0x8
}

// Namespace: 
private struct Awaitable.AwaitableAndFrameIndex // TypeDefIndex: 6810
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Awaitable <Awaitable>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <FrameIndex>k__BackingField; // 0x8

	// Properties
	public Awaitable Awaitable { get; }
	public int FrameIndex { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x1E6CDB4 Offset: 0x1E68DB4 VA: 0x1E6CDB4
	public Awaitable get_Awaitable() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1E6CDBC Offset: 0x1E68DBC VA: 0x1E6CDBC
	public int get_FrameIndex() { }
}

// Namespace: 
private class Awaitable.DoubleBufferedAwaitableList // TypeDefIndex: 6811
{
	// Fields
	private List<Awaitable.AwaitableAndFrameIndex> _awaitables; // 0x10
	private List<Awaitable.AwaitableAndFrameIndex> _scratch; // 0x18

	// Methods

	// RVA: 0x1E6B928 Offset: 0x1E67928 VA: 0x1E6B928
	public void SwapAndComplete() { }

	// RVA: 0x1E6B858 Offset: 0x1E67858 VA: 0x1E6B858
	public void Clear() { }

	// RVA: 0x1E6CD08 Offset: 0x1E68D08 VA: 0x1E6CD08
	public void .ctor() { }
}

// Namespace: 
[IsReadOnly]
private struct Awaitable.AwaitableHandle // TypeDefIndex: 6812
{
	// Fields
	private readonly IntPtr _handle; // 0x0
	public static Awaitable.AwaitableHandle ManagedHandle; // 0x0
	public static Awaitable.AwaitableHandle NullHandle; // 0x8

	// Properties
	public bool IsNull { get; }
	public bool IsManaged { get; }

	// Methods

	// RVA: 0x1E6C538 Offset: 0x1E68538 VA: 0x1E6C538
	public bool get_IsNull() { }

	// RVA: 0x1E6C4D0 Offset: 0x1E684D0 VA: 0x1E6C4D0
	public bool get_IsManaged() { }

	// RVA: 0x1E6CDEC Offset: 0x1E68DEC VA: 0x1E6CDEC
	public void .ctor(IntPtr handle) { }

	// RVA: 0x1E6CDF4 Offset: 0x1E68DF4 VA: 0x1E6CDF4
	public static IntPtr op_Implicit(Awaitable.AwaitableHandle handle) { }

	// RVA: 0x1E6CDF8 Offset: 0x1E68DF8 VA: 0x1E6CDF8
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Awaitable.<>c // TypeDefIndex: 6813
{
	// Fields
	public static readonly Awaitable.<>c <>9; // 0x0
	public static Func<Awaitable> <>9__76_1; // 0x8

	// Methods

	// RVA: 0x1E6CE58 Offset: 0x1E68E58 VA: 0x1E6CE58
	private static void .cctor() { }

	// RVA: 0x1E6CEC0 Offset: 0x1E68EC0 VA: 0x1E6CEC0
	public void .ctor() { }

	// RVA: 0x1E6CEC8 Offset: 0x1E68EC8 VA: 0x1E6CEC8
	internal ObjectPool<Awaitable> <.cctor>b__76_0() { }

	// RVA: 0x1E6D004 Offset: 0x1E69004 VA: 0x1E6D004
	internal Awaitable <.cctor>b__76_1() { }
}

// Namespace: UnityEngine
[AsyncMethodBuilder(typeof(Awaitable.AwaitableAsyncMethodBuilder))]
[NativeHeader("Runtime/Mono/AsyncOperationAwaitable.h")]
[NativeHeader("Runtime/Mono/Awaitable.h")]
[NativeHeader("Runtime/Mono/DelayedCallAwaitable.h")]
public class Awaitable : IEnumerator // TypeDefIndex: 6814
{
	// Fields
	private static bool _nextFrameAndEndOfFrameWiredUp; // 0x0
	private static CancellationTokenRegistration _nextFrameAndEndOfFrameWiredUpCTRegistration; // 0x8
	private static readonly Awaitable.DoubleBufferedAwaitableList _nextFrameAwaitables; // 0x20
	private static readonly Awaitable.DoubleBufferedAwaitableList _endOfFrameAwaitables; // 0x28
	private static SynchronizationContext _synchronizationContext; // 0x30
	private static int _mainThreadId; // 0x38
	private SpinLock _spinLock; // 0x10
	private static readonly ThreadLocal<ObjectPool<Awaitable>> _pool; // 0x40
	private Awaitable.AwaitableHandle _handle; // 0x18
	private ExceptionDispatchInfo _exceptionToRethrow; // 0x20
	private bool _managedAwaitableDone; // 0x28
	private Awaitable.AwaiterCompletionThreadAffinity _completionThreadAffinity; // 0x2C
	private Action _continuation; // 0x30
	private Nullable<CancellationTokenRegistration> _cancelTokenRegistration; // 0x38
	private Awaitable.DoubleBufferedAwaitableList _managedCompletionQueue; // 0x58

	// Properties
	private bool IsCompletedNoLock { get; }
	public bool IsCompleted { get; }
	internal bool IsDettachedOrCompleted { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x1E6B4E8 Offset: 0x1E674E8 VA: 0x1E6B4E8
	private void SetExceptionFromNative(Exception ex) { }

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x1E6B624 Offset: 0x1E67624 VA: 0x1E6B624
	private void RunContinuation() { }

	[FreeFunction("Scripting::Awaitables::Release", IsThreadSafe = True)]
	// RVA: 0x1E6B768 Offset: 0x1E67768 VA: 0x1E6B768
	private static void ReleaseNativeAwaitable(IntPtr nativeAwaitable) { }

	[FreeFunction("Scripting::Awaitables::IsCompleted", IsThreadSafe = True)]
	// RVA: 0x1E6B7A4 Offset: 0x1E677A4 VA: 0x1E6B7A4
	private static int IsNativeAwaitableCompleted(IntPtr nativeAwaitable) { }

	[RequiredByNativeCode]
	// RVA: 0x1E6B7E0 Offset: 0x1E677E0 VA: 0x1E6B7E0
	private static void OnDelayedCallManagerCleared() { }

	[RequiredByNativeCode]
	// RVA: 0x1E6B8C8 Offset: 0x1E678C8 VA: 0x1E6B8C8
	private static void OnUpdate() { }

	[RequiredByNativeCode]
	// RVA: 0x1E6BC28 Offset: 0x1E67C28 VA: 0x1E6BC28
	private static void OnEndOfFrame() { }

	// RVA: 0x1E6BC88 Offset: 0x1E67C88 VA: 0x1E6BC88
	internal static void SetSynchronizationContext(UnitySynchronizationContext synchronizationContext) { }

	// RVA: 0x1E6BD04 Offset: 0x1E67D04 VA: 0x1E6BD04
	private void .ctor() { }

	// RVA: 0x1E6BD10 Offset: 0x1E67D10 VA: 0x1E6BD10
	private static bool MatchCompletionThreadAffinity(Awaitable.AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity) { }

	// RVA: 0x1E6BDF8 Offset: 0x1E67DF8 VA: 0x1E6BDF8
	private void RunOrScheduleContinuation(Awaitable.AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity, Action continuation) { }

	// RVA: 0x1E6BF5C Offset: 0x1E67F5C VA: 0x1E6BF5C
	private static void DoRunContinuationOnSynchonizationContext(object continuation) { }

	// RVA: 0x1E6BFC8 Offset: 0x1E67FC8 VA: 0x1E6BFC8
	internal void RaiseManagedCompletion() { }

	// RVA: 0x1E6C130 Offset: 0x1E68130 VA: 0x1E6C130
	internal void PropagateExceptionAndRelease() { }

	// RVA: 0x1E6C548 Offset: 0x1E68548 VA: 0x1E6C548
	private bool get_IsCompletedNoLock() { }

	// RVA: 0x1E6C6DC Offset: 0x1E686DC VA: 0x1E6C6DC
	public bool get_IsCompleted() { }

	// RVA: 0x1E6C804 Offset: 0x1E68804 VA: 0x1E6C804
	internal bool get_IsDettachedOrCompleted() { }

	// RVA: 0x1E6CA9C Offset: 0x1E68A9C VA: 0x1E6CA9C
	private Awaitable.AwaitableHandle CheckPointerValidity() { }

	// RVA: 0x1E6CB40 Offset: 0x1E68B40 VA: 0x1E6CB40 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1E6CB74 Offset: 0x1E68B74 VA: 0x1E6CB74 Slot: 6
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1E6CB78 Offset: 0x1E68B78 VA: 0x1E6CB78 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1E6CB80 Offset: 0x1E68B80 VA: 0x1E6CB80
	private static void .cctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
public class Behaviour : Component // TypeDefIndex: 6815
{
	// Properties
	[RequiredByNativeCode]
	[NativeProperty]
	public bool enabled { get; set; }
	[NativeProperty]
	public bool isActiveAndEnabled { get; }

	// Methods

	// RVA: 0x1E6D05C Offset: 0x1E6905C VA: 0x1E6D05C
	public bool get_enabled() { }

	// RVA: 0x1E6D108 Offset: 0x1E69108 VA: 0x1E6D108
	public void set_enabled(bool value) { }

	[NativeMethod("IsAddedToManager")]
	// RVA: 0x1E6D1C4 Offset: 0x1E691C4 VA: 0x1E6D1C4
	public bool get_isActiveAndEnabled() { }

	// RVA: 0x1E6D270 Offset: 0x1E69270 VA: 0x1E6D270
	public void .ctor() { }

	// RVA: 0x1E6D0CC Offset: 0x1E690CC VA: 0x1E6D0CC
	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E6D180 Offset: 0x1E69180 VA: 0x1E6D180
	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1E6D234 Offset: 0x1E69234 VA: 0x1E6D234
	private static bool get_isActiveAndEnabled_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
internal struct CastHelper<T> // TypeDefIndex: 6816
{
	// Fields
	public T t; // 0x0
	public IntPtr onePointerFurtherThanT; // 0x0
}

// Namespace: UnityEngine
internal static class ClassLibraryInitializer // TypeDefIndex: 6817
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E6D2CC Offset: 0x1E692CC VA: 0x1E6D2CC
	private static void Init() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Mono/AssemblyFullName.h")]
[RequiredByNativeCode(GenerateProxy = True)]
internal struct AssemblyVersion // TypeDefIndex: 6818
{
	// Fields
	public ushort major; // 0x0
	public ushort minor; // 0x2
	public ushort build; // 0x4
	public ushort revision; // 0x6

	// Methods

	// RVA: 0x1E6D2D4 Offset: 0x1E692D4 VA: 0x1E6D2D4
	public static bool op_Equality(AssemblyVersion lhs, AssemblyVersion rhs) { }

	// RVA: 0x1E6D2E0 Offset: 0x1E692E0 VA: 0x1E6D2E0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E6D4B0 Offset: 0x1E694B0 VA: 0x1E6D4B0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1E6D558 Offset: 0x1E69558 VA: 0x1E6D558 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Mono/AssemblyFullName.h")]
[RequiredByNativeCode(GenerateProxy = True)]
internal struct AssemblyFullName // TypeDefIndex: 6819
{
	// Fields
	[NativeName("name")]
	public string Name; // 0x0
	[NativeName("version")]
	public AssemblyVersion Version; // 0x8
	[NativeName("publicKeyToken")]
	public string PublicKeyToken; // 0x10
	[NativeName("culture")]
	public string Culture; // 0x18

	// Methods

	// RVA: 0x1E6D5E8 Offset: 0x1E695E8 VA: 0x1E6D5E8 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1E6D6AC Offset: 0x1E696AC VA: 0x1E6D6AC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E6D734 Offset: 0x1E69734 VA: 0x1E6D734 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeClass("Unity::Component")]
[NativeHeader("Runtime/Export/Scripting/Component.bindings.h")]
public class Component : Object // TypeDefIndex: 6820
{
	// Properties
	public Transform transform { get; }
	public GameObject gameObject { get; }

	// Methods

	[FreeFunction("GetTransform", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x1E6D904 Offset: 0x1E69904 VA: 0x1E6D904
	public Transform get_transform() { }

	[FreeFunction("GetGameObject", HasExplicitThis = True)]
	// RVA: 0x1E6D9CC Offset: 0x1E699CC VA: 0x1E6D9CC
	public GameObject get_gameObject() { }

	[TypeInferenceRule(0)]
	// RVA: 0x1E6DA94 Offset: 0x1E69A94 VA: 0x1E6DA94
	public Component GetComponent(Type type) { }

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x1E6DB50 Offset: 0x1E69B50 VA: 0x1E6DB50
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F282C Offset: 0x10EE82C VA: 0x10F282C
	|-Component.GetComponent<object>
	|
	|-RVA: 0x10F28AC Offset: 0x10EE8AC VA: 0x10F28AC
	|-Component.GetComponent<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	// RVA: 0x1E6DC2C Offset: 0x1E69C2C VA: 0x1E6DC2C
	public bool TryGetComponent(Type type, out Component component) { }

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F3248 Offset: 0x10EF248 VA: 0x10F3248
	|-Component.TryGetComponent<object>
	|
	|-RVA: 0x10F3298 Offset: 0x10EF298 VA: 0x10F3298
	|-Component.TryGetComponent<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	// RVA: 0x1E6DCE4 Offset: 0x1E69CE4 VA: 0x1E6DCE4
	public Component GetComponentInChildren(Type t, bool includeInactive) { }

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F2A08 Offset: 0x10EEA08 VA: 0x10F2A08
	|-Component.GetComponentInChildren<object>
	|
	|-RVA: 0x10F2ABC Offset: 0x10EEABC VA: 0x10F2ABC
	|-Component.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> result) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F2FA0 Offset: 0x10EEFA0 VA: 0x10F2FA0
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0x10F3000 Offset: 0x10EF000 VA: 0x10F3000
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F2F14 Offset: 0x10EEF14 VA: 0x10F2F14
	|-Component.GetComponentsInChildren<object>
	|
	|-RVA: 0x10F2F58 Offset: 0x10EEF58 VA: 0x10F2F58
	|-Component.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	// RVA: 0x1E6DDB8 Offset: 0x1E69DB8 VA: 0x1E6DDB8
	public Component GetComponentInParent(Type t, bool includeInactive) { }

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F2BD8 Offset: 0x10EEBD8 VA: 0x10F2BD8
	|-Component.GetComponentInParent<object>
	|
	|-RVA: 0x10F2C8C Offset: 0x10EEC8C VA: 0x10F2C8C
	|-Component.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F30E0 Offset: 0x10EF0E0 VA: 0x10F30E0
	|-Component.GetComponentsInParent<object>
	|
	|-RVA: 0x10F3130 Offset: 0x10EF130 VA: 0x10F3130
	|-Component.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F3184 Offset: 0x10EF184 VA: 0x10F3184
	|-Component.GetComponentsInParent<object>
	|
	|-RVA: 0x10F31E4 Offset: 0x10EF1E4 VA: 0x10F31E4
	|-Component.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F3064 Offset: 0x10EF064 VA: 0x10F3064
	|-Component.GetComponentsInParent<object>
	|
	|-RVA: 0x10F30A0 Offset: 0x10EF0A0 VA: 0x10F30A0
	|-Component.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction(HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x1E6DE8C Offset: 0x1E69E8C VA: 0x1E6DE8C
	private void GetComponentsForListInternal(Type searchType, object resultList) { }

	// RVA: 0x1E6DF68 Offset: 0x1E69F68 VA: 0x1E6DF68
	public void GetComponents(Type type, List<Component> results) { }

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F2E3C Offset: 0x10EEE3C VA: 0x10F2E3C
	|-Component.GetComponents<object>
	|
	|-RVA: 0x10F2EA8 Offset: 0x10EEEA8 VA: 0x10F2EA8
	|-Component.GetComponents<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F2DA8 Offset: 0x10EEDA8 VA: 0x10F2DA8
	|-Component.GetComponents<object>
	|
	|-RVA: 0x10F2DF0 Offset: 0x10EEDF0 VA: 0x10F2DF0
	|-Component.GetComponents<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E6D274 Offset: 0x1E69274 VA: 0x1E6D274
	public void .ctor() { }

	// RVA: 0x1E6D990 Offset: 0x1E69990 VA: 0x1E6D990
	private static IntPtr get_transform_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E6DA58 Offset: 0x1E69A58 VA: 0x1E6DA58
	private static IntPtr get_gameObject_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E6DBD8 Offset: 0x1E69BD8 VA: 0x1E6DBD8
	private static void GetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x1E6DF14 Offset: 0x1E69F14 VA: 0x1E6DF14
	private static void GetComponentsForListInternal_Injected(IntPtr _unity_self, Type searchType, object resultList) { }
}

// Namespace: 
internal static class Coroutine.BindingsMarshaller // TypeDefIndex: 6821
{
	// Methods

	// RVA: 0x1E6E068 Offset: 0x1E6A068 VA: 0x1E6E068
	public static IntPtr ConvertToNative(Coroutine coroutine) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Mono/Coroutine.h")]
[RequiredByNativeCode]
public sealed class Coroutine : YieldInstruction // TypeDefIndex: 6822
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x1E6DF74 Offset: 0x1E69F74 VA: 0x1E6DF74
	private void .ctor() { }

	// RVA: 0x1E6DF7C Offset: 0x1E69F7C VA: 0x1E6DF7C Slot: 1
	protected override void Finalize() { }

	[FreeFunction("Coroutine::CleanupCoroutineGC", True)]
	// RVA: 0x1E6E02C Offset: 0x1E6A02C VA: 0x1E6E02C
	private static void ReleaseCoroutine(IntPtr ptr) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
internal class SetupCoroutine // TypeDefIndex: 6823
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E6E07C Offset: 0x1E6A07C VA: 0x1E6E07C
	public static void InvokeMoveNext(IEnumerator enumerator, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	// RVA: 0x1E6E198 Offset: 0x1E6A198 VA: 0x1E6E198
	public static object InvokeMember(object behaviour, string name, object variable) { }
}

// Namespace: UnityEngine
public abstract class CustomYieldInstruction : IEnumerator // TypeDefIndex: 6824
{
	// Properties
	public abstract bool keepWaiting { get; }
	public object Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_keepWaiting();

	// RVA: 0x1E6E298 Offset: 0x1E6A298 VA: 0x1E6E298 Slot: 5
	public object get_Current() { }

	// RVA: 0x1E6E2A0 Offset: 0x1E6A2A0 VA: 0x1E6E2A0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1E6E2AC Offset: 0x1E6A2AC VA: 0x1E6E2AC Slot: 8
	public virtual void Reset() { }

	// RVA: 0x1E6E2B0 Offset: 0x1E6A2B0 VA: 0x1E6E2B0
	protected void .ctor() { }
}

// Namespace: UnityEngine
[Usage(4)]
[UsedByNativeCode]
public class ExcludeFromObjectFactoryAttribute : Attribute // TypeDefIndex: 6825
{
	// Methods

	// RVA: 0x1E6E2B8 Offset: 0x1E6A2B8 VA: 0x1E6E2B8
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(1028, Inherited = True)]
[RequiredByNativeCode]
[VisibleToOtherModules(new[] { "UnityEditor.UIBuilderModule" })]
internal sealed class ExtensionOfNativeClassAttribute : Attribute // TypeDefIndex: 6826
{
	// Methods

	// RVA: 0x1E6E2C0 Offset: 0x1E6A2C0 VA: 0x1E6E2C0
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[ExcludeFromObjectFactory]
[NativeClass(null)]
internal class FailedToLoadScriptObject : Object // TypeDefIndex: 6827
{}

// Namespace: UnityEngine
[ExcludeFromPreset]
[UsedByNativeCode]
[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
public sealed class GameObject : Object // TypeDefIndex: 6828
{
	// Properties
	public Transform transform { get; }
	public int layer { get; set; }
	[Obsolete("GameObject.active is obsolete. Use GameObject.SetActive(), GameObject.activeSelf or GameObject.activeInHierarchy.")]
	public bool active { get; }
	public bool activeSelf { get; }
	public bool activeInHierarchy { get; }
	public GameObject gameObject { get; }

	// Methods

	// RVA: -1 Offset: -1
	public T GetComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11166C0 Offset: 0x11126C0 VA: 0x11166C0
	|-GameObject.GetComponent<object>
	|
	|-RVA: 0x1116740 Offset: 0x1112740 VA: 0x1116740
	|-GameObject.GetComponent<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x1E6DAB4 Offset: 0x1E69AB4 VA: 0x1E6DAB4
	public Component GetComponent(Type type) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x1E6E30C Offset: 0x1E6A30C VA: 0x1E6E30C
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(0)]
	// RVA: 0x1E6DD14 Offset: 0x1E69D14 VA: 0x1E6DD14
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111689C Offset: 0x111289C VA: 0x111689C
	|-GameObject.GetComponentInChildren<object>
	|
	|-RVA: 0x11168D8 Offset: 0x11128D8 VA: 0x11168D8
	|-GameObject.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInChildren<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1116998 Offset: 0x1112998 VA: 0x1116998
	|-GameObject.GetComponentInChildren<object>
	|
	|-RVA: 0x1116A58 Offset: 0x1112A58 VA: 0x1116A58
	|-GameObject.GetComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	[TypeInferenceRule(0)]
	[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x1E6DDE8 Offset: 0x1E69DE8 VA: 0x1E6DDE8
	public Component GetComponentInParent(Type type, bool includeInactive) { }

	[ExcludeFromDocs]
	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1116B78 Offset: 0x1112B78 VA: 0x1116B78
	|-GameObject.GetComponentInParent<object>
	|
	|-RVA: 0x1116BB4 Offset: 0x1112BB4 VA: 0x1116BB4
	|-GameObject.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T GetComponentInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1116C74 Offset: 0x1112C74 VA: 0x1116C74
	|-GameObject.GetComponentInParent<object>
	|
	|-RVA: 0x1116D34 Offset: 0x1112D34 VA: 0x1116D34
	|-GameObject.GetComponentInParent<__Il2CppFullySharedGenericType>
	*/

	[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x1E6E490 Offset: 0x1E6A490 VA: 0x1E6E490
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: -1 Offset: -1
	public T[] GetComponents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1116E54 Offset: 0x1112E54 VA: 0x1116E54
	|-GameObject.GetComponents<object>
	|
	|-RVA: 0x1116F18 Offset: 0x1112F18 VA: 0x1116F18
	|-GameObject.GetComponents<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponents<T>(List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1116FDC Offset: 0x1112FDC VA: 0x1116FDC
	|-GameObject.GetComponents<object>
	|
	|-RVA: 0x1117058 Offset: 0x1113058 VA: 0x1117058
	|-GameObject.GetComponents<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInChildren<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11170D4 Offset: 0x11130D4 VA: 0x11170D4
	|-GameObject.GetComponentsInChildren<object>
	|
	|-RVA: 0x111715C Offset: 0x111315C VA: 0x111715C
	|-GameObject.GetComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void GetComponentsInParent<T>(bool includeInactive, List<T> results) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1117384 Offset: 0x1113384 VA: 0x1117384
	|-GameObject.GetComponentsInParent<object>
	|
	|-RVA: 0x111740C Offset: 0x111340C VA: 0x111740C
	|-GameObject.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public T[] GetComponentsInParent<T>(bool includeInactive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11171E4 Offset: 0x11131E4 VA: 0x11171E4
	|-GameObject.GetComponentsInParent<object>
	|
	|-RVA: 0x11172B4 Offset: 0x11132B4 VA: 0x11172B4
	|-GameObject.GetComponentsInParent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public bool TryGetComponent<T>(out T component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1117494 Offset: 0x1113494 VA: 0x1117494
	|-GameObject.TryGetComponent<object>
	|
	|-RVA: 0x1117530 Offset: 0x1113530 VA: 0x1117530
	|-GameObject.TryGetComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E6DC5C Offset: 0x1E69C5C VA: 0x1E6DC5C
	public bool TryGetComponent(Type type, out Component component) { }

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(0)]
	// RVA: 0x1E6E5CC Offset: 0x1E6A5CC VA: 0x1E6E5CC
	internal Component TryGetComponentInternal(Type type) { }

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x1E6E71C Offset: 0x1E6A71C VA: 0x1E6E71C
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = True)]
	// RVA: 0x1E6E7F8 Offset: 0x1E6A7F8 VA: 0x1E6E7F8
	private Component Internal_AddComponentWithType(Type componentType) { }

	[TypeInferenceRule(0)]
	// RVA: 0x1E6E8D8 Offset: 0x1E6A8D8 VA: 0x1E6E8D8
	public Component AddComponent(Type componentType) { }

	// RVA: -1 Offset: -1
	public T AddComponent<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1116630 Offset: 0x1112630 VA: 0x1116630
	|-GameObject.AddComponent<object>
	*/

	[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
	// RVA: 0x1E6E8DC Offset: 0x1E6A8DC VA: 0x1E6E8DC
	public Transform get_transform() { }

	// RVA: 0x1E6E9A4 Offset: 0x1E6A9A4 VA: 0x1E6E9A4
	public int get_layer() { }

	// RVA: 0x1E6EA50 Offset: 0x1E6AA50 VA: 0x1E6EA50
	public void set_layer(int value) { }

	[NativeMethod(Name = "IsActive")]
	// RVA: 0x1E6EB0C Offset: 0x1E6AB0C VA: 0x1E6EB0C
	public bool get_active() { }

	[NativeMethod(Name = "SetSelfActive")]
	// RVA: 0x1E6EBB8 Offset: 0x1E6ABB8 VA: 0x1E6EBB8
	public void SetActive(bool value) { }

	[NativeMethod(Name = "IsSelfActive")]
	// RVA: 0x1E6EC74 Offset: 0x1E6AC74 VA: 0x1E6EC74
	public bool get_activeSelf() { }

	[NativeMethod(Name = "IsActive")]
	// RVA: 0x1E6ED20 Offset: 0x1E6AD20 VA: 0x1E6ED20
	public bool get_activeInHierarchy() { }

	[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = True)]
	// RVA: 0x1E6EDCC Offset: 0x1E6ADCC VA: 0x1E6EDCC
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	// RVA: 0x1E6EFB0 Offset: 0x1E6AFB0 VA: 0x1E6EFB0
	public void .ctor(string name) { }

	// RVA: 0x1E6F168 Offset: 0x1E6B168 VA: 0x1E6F168
	public void .ctor() { }

	// RVA: 0x1E6F1CC Offset: 0x1E6B1CC VA: 0x1E6F1CC
	public void .ctor(string name, Type[] components) { }

	[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
	// RVA: 0x1E6F020 Offset: 0x1E6B020 VA: 0x1E6F020
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	[FreeFunction(Name = "GameObjectBindings::Find")]
	// RVA: 0x1E6F2D0 Offset: 0x1E6B2D0 VA: 0x1E6F2D0
	public static GameObject Find(string name) { }

	// RVA: 0x1E6F4E0 Offset: 0x1E6B4E0 VA: 0x1E6F4E0
	public GameObject get_gameObject() { }

	// RVA: 0x1E6E2C8 Offset: 0x1E6A2C8 VA: 0x1E6E2C8
	private static IntPtr GetComponent_Injected(IntPtr _unity_self, Type type) { }

	// RVA: 0x1E6E394 Offset: 0x1E6A394 VA: 0x1E6E394
	private static void GetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x1E6E3E8 Offset: 0x1E6A3E8 VA: 0x1E6E3E8
	private static IntPtr GetComponentInChildren_Injected(IntPtr _unity_self, Type type, bool includeInactive) { }

	// RVA: 0x1E6E43C Offset: 0x1E6A43C VA: 0x1E6E43C
	private static IntPtr GetComponentInParent_Injected(IntPtr _unity_self, Type type, bool includeInactive) { }

	// RVA: 0x1E6E548 Offset: 0x1E6A548 VA: 0x1E6E548
	private static Array GetComponentsInternal_Injected(IntPtr _unity_self, Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	// RVA: 0x1E6E6D8 Offset: 0x1E6A6D8 VA: 0x1E6E6D8
	private static IntPtr TryGetComponentInternal_Injected(IntPtr _unity_self, Type type) { }

	// RVA: 0x1E6E7A4 Offset: 0x1E6A7A4 VA: 0x1E6E7A4
	private static void TryGetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	// RVA: 0x1E6E894 Offset: 0x1E6A894 VA: 0x1E6E894
	private static IntPtr Internal_AddComponentWithType_Injected(IntPtr _unity_self, Type componentType) { }

	// RVA: 0x1E6E968 Offset: 0x1E6A968 VA: 0x1E6E968
	private static IntPtr get_transform_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E6EA14 Offset: 0x1E6AA14 VA: 0x1E6EA14
	private static int get_layer_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E6EAC8 Offset: 0x1E6AAC8 VA: 0x1E6EAC8
	private static void set_layer_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1E6EB7C Offset: 0x1E6AB7C VA: 0x1E6EB7C
	private static bool get_active_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E6EC30 Offset: 0x1E6AC30 VA: 0x1E6EC30
	private static void SetActive_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1E6ECE4 Offset: 0x1E6ACE4 VA: 0x1E6ECE4
	private static bool get_activeSelf_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E6ED90 Offset: 0x1E6AD90 VA: 0x1E6ED90
	private static bool get_activeInHierarchy_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E6EF54 Offset: 0x1E6AF54 VA: 0x1E6EF54
	private static void SendMessage_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object value, SendMessageOptions options) { }

	// RVA: 0x1E6F28C Offset: 0x1E6B28C VA: 0x1E6F28C
	private static void Internal_CreateGameObject_Injected(GameObject self, ref ManagedSpanWrapper name) { }

	// RVA: 0x1E6F4A4 Offset: 0x1E6B4A4 VA: 0x1E6F4A4
	private static IntPtr Find_Injected(ref ManagedSpanWrapper name) { }
}

// Namespace: UnityEngine
[NativeClass("BitField", "struct BitField;")]
[NativeHeader("Runtime/BaseClasses/BitField.h")]
[NativeHeader("Runtime/BaseClasses/TagManager.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct LayerMask // TypeDefIndex: 6829
{
	// Fields
	[NativeName("m_Bits")]
	private int m_Mask; // 0x0

	// Methods

	// RVA: 0x1E6F4E4 Offset: 0x1E6B4E4 VA: 0x1E6F4E4
	public static int op_Implicit(LayerMask mask) { }

	// RVA: 0x1E6F4E8 Offset: 0x1E6B4E8 VA: 0x1E6F4E8
	public static LayerMask op_Implicit(int intVal) { }
}

// Namespace: UnityEngine
[Serializable]
public struct LazyLoadReference<T> // TypeDefIndex: 6830
{
	// Fields
	[SerializeField]
	private int m_InstanceID; // 0x0
}

// Namespace: UnityEngine
internal static class ManagedStreamHelpers // TypeDefIndex: 6831
{
	// Methods

	// RVA: 0x1E6F4EC Offset: 0x1E6B4EC VA: 0x1E6F4EC
	internal static void ValidateLoadFromStream(Stream stream) { }

	[RequiredByNativeCode]
	// RVA: 0x1E6F5F0 Offset: 0x1E6B5F0 VA: 0x1E6F5F0
	internal static void ManagedStreamRead(byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	// RVA: 0x1E6F6C4 Offset: 0x1E6B6C4 VA: 0x1E6F6C4
	internal static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	// RVA: 0x1E6F790 Offset: 0x1E6B790 VA: 0x1E6F790
	internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Scripting/DelayedCallUtility.h")]
[ExtensionOfNativeClass]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[RequiredByNativeCode]
public class MonoBehaviour : Behaviour // TypeDefIndex: 6832
{
	// Fields
	private CancellationTokenSource m_CancellationTokenSource; // 0x18

	// Properties
	public CancellationToken destroyCancellationToken { get; }
	public bool useGUILayout { get; set; }
	public bool didStart { get; }
	public bool didAwake { get; }

	// Methods

	// RVA: 0x1E6F83C Offset: 0x1E6B83C VA: 0x1E6F83C
	public CancellationToken get_destroyCancellationToken() { }

	[RequiredByNativeCode]
	// RVA: 0x1E6FA88 Offset: 0x1E6BA88 VA: 0x1E6FA88
	private void RaiseCancellation() { }

	// RVA: 0x1E6FA9C Offset: 0x1E6BA9C VA: 0x1E6FA9C
	public bool IsInvoking() { }

	// RVA: 0x1E6FB24 Offset: 0x1E6BB24 VA: 0x1E6FB24
	public void CancelInvoke() { }

	// RVA: 0x1E6FBAC Offset: 0x1E6BBAC VA: 0x1E6FBAC
	public void Invoke(string methodName, float time) { }

	// RVA: 0x1E6FD5C Offset: 0x1E6BD5C VA: 0x1E6FD5C
	public void InvokeRepeating(string methodName, float time, float repeatRate) { }

	// RVA: 0x1E6FE38 Offset: 0x1E6BE38 VA: 0x1E6FE38
	public void CancelInvoke(string methodName) { }

	// RVA: 0x1E6FFCC Offset: 0x1E6BFCC VA: 0x1E6FFCC
	public bool IsInvoking(string methodName) { }

	[ExcludeFromDocs]
	// RVA: 0x1E7016C Offset: 0x1E6C16C VA: 0x1E7016C
	public Coroutine StartCoroutine(string methodName) { }

	// RVA: 0x1E70174 Offset: 0x1E6C174 VA: 0x1E70174
	public Coroutine StartCoroutine(string methodName, object value) { }

	// RVA: 0x1E70444 Offset: 0x1E6C444 VA: 0x1E70444
	public Coroutine StartCoroutine(IEnumerator routine) { }

	[Obsolete("StartCoroutine_Auto has been deprecated. Use StartCoroutine instead (UnityUpgradable) -> StartCoroutine([mscorlib] System.Collections.IEnumerator)", False)]
	// RVA: 0x1E70568 Offset: 0x1E6C568 VA: 0x1E70568
	public Coroutine StartCoroutine_Auto(IEnumerator routine) { }

	// RVA: 0x1E7056C Offset: 0x1E6C56C VA: 0x1E7056C
	public void StopCoroutine(IEnumerator routine) { }

	// RVA: 0x1E70690 Offset: 0x1E6C690 VA: 0x1E70690
	public void StopCoroutine(Coroutine routine) { }

	// RVA: 0x1E707BC Offset: 0x1E6C7BC VA: 0x1E707BC
	public void StopCoroutine(string methodName) { }

	// RVA: 0x1E7096C Offset: 0x1E6C96C VA: 0x1E7096C
	public void StopAllCoroutines() { }

	// RVA: 0x1E70A18 Offset: 0x1E6CA18 VA: 0x1E70A18
	public bool get_useGUILayout() { }

	// RVA: 0x1E70AC4 Offset: 0x1E6CAC4 VA: 0x1E70AC4
	public void set_useGUILayout(bool value) { }

	// RVA: 0x1E70B80 Offset: 0x1E6CB80 VA: 0x1E70B80
	public bool get_didStart() { }

	// RVA: 0x1E70C2C Offset: 0x1E6CC2C VA: 0x1E70C2C
	public bool get_didAwake() { }

	// RVA: 0x1E70CD8 Offset: 0x1E6CCD8 VA: 0x1E70CD8
	public static void print(object message) { }

	[FreeFunction("CancelInvoke")]
	// RVA: 0x1E6FB28 Offset: 0x1E6BB28 VA: 0x1E6FB28
	private static void Internal_CancelInvokeAll(MonoBehaviour self) { }

	[FreeFunction("IsInvoking")]
	// RVA: 0x1E6FAA0 Offset: 0x1E6BAA0 VA: 0x1E6FAA0
	private static bool Internal_IsInvokingAll(MonoBehaviour self) { }

	[FreeFunction]
	// RVA: 0x1E6FBB4 Offset: 0x1E6BBB4 VA: 0x1E6FBB4
	private static void InvokeDelayed(MonoBehaviour self, string methodName, float time, float repeatRate) { }

	[FreeFunction]
	// RVA: 0x1E6FE3C Offset: 0x1E6BE3C VA: 0x1E6FE3C
	private static void CancelInvoke(MonoBehaviour self, string methodName) { }

	[FreeFunction]
	// RVA: 0x1E6FFD0 Offset: 0x1E6BFD0 VA: 0x1E6FFD0
	private static bool IsInvoking(MonoBehaviour self, string methodName) { }

	[FreeFunction]
	// RVA: 0x1E70238 Offset: 0x1E6C238 VA: 0x1E70238
	private static bool IsObjectMonoBehaviour(Object obj) { }

	// RVA: 0x1E702BC Offset: 0x1E6C2BC VA: 0x1E702BC
	private Coroutine StartCoroutineManaged(string methodName, object value) { }

	// RVA: 0x1E704F0 Offset: 0x1E6C4F0 VA: 0x1E704F0
	private Coroutine StartCoroutineManaged2(IEnumerator enumerator) { }

	// RVA: 0x1E7073C Offset: 0x1E6C73C VA: 0x1E7073C
	private void StopCoroutineManaged(Coroutine routine) { }

	// RVA: 0x1E70618 Offset: 0x1E6C618 VA: 0x1E70618
	private void StopCoroutineFromEnumeratorManaged(IEnumerator routine) { }

	// RVA: 0x1E70FE8 Offset: 0x1E6CFE8 VA: 0x1E70FE8
	internal string GetScriptClassName() { }

	// RVA: 0x1E6FA18 Offset: 0x1E6BA18 VA: 0x1E6FA18
	private void OnCancellationTokenCreated() { }

	// RVA: 0x1E71188 Offset: 0x1E6D188 VA: 0x1E71188
	public void .ctor() { }

	// RVA: 0x1E70928 Offset: 0x1E6C928 VA: 0x1E70928
	private static void StopCoroutine_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName) { }

	// RVA: 0x1E709DC Offset: 0x1E6C9DC VA: 0x1E709DC
	private static void StopAllCoroutines_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E70A88 Offset: 0x1E6CA88 VA: 0x1E70A88
	private static bool get_useGUILayout_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E70B3C Offset: 0x1E6CB3C VA: 0x1E70B3C
	private static void set_useGUILayout_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1E70BF0 Offset: 0x1E6CBF0 VA: 0x1E70BF0
	private static bool get_didStart_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E70C9C Offset: 0x1E6CC9C VA: 0x1E70C9C
	private static bool get_didAwake_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E70D30 Offset: 0x1E6CD30 VA: 0x1E70D30
	private static void Internal_CancelInvokeAll_Injected(IntPtr self) { }

	// RVA: 0x1E70D6C Offset: 0x1E6CD6C VA: 0x1E70D6C
	private static bool Internal_IsInvokingAll_Injected(IntPtr self) { }

	// RVA: 0x1E70DA8 Offset: 0x1E6CDA8 VA: 0x1E70DA8
	private static void InvokeDelayed_Injected(IntPtr self, ref ManagedSpanWrapper methodName, float time, float repeatRate) { }

	// RVA: 0x1E70E04 Offset: 0x1E6CE04 VA: 0x1E70E04
	private static void CancelInvoke_Injected(IntPtr self, ref ManagedSpanWrapper methodName) { }

	// RVA: 0x1E70E48 Offset: 0x1E6CE48 VA: 0x1E70E48
	private static bool IsInvoking_Injected(IntPtr self, ref ManagedSpanWrapper methodName) { }

	// RVA: 0x1E70E8C Offset: 0x1E6CE8C VA: 0x1E70E8C
	private static bool IsObjectMonoBehaviour_Injected(IntPtr obj) { }

	// RVA: 0x1E70EC8 Offset: 0x1E6CEC8 VA: 0x1E70EC8
	private static Coroutine StartCoroutineManaged_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object value) { }

	// RVA: 0x1E70F1C Offset: 0x1E6CF1C VA: 0x1E70F1C
	private static Coroutine StartCoroutineManaged2_Injected(IntPtr _unity_self, IEnumerator enumerator) { }

	// RVA: 0x1E70F60 Offset: 0x1E6CF60 VA: 0x1E70F60
	private static void StopCoroutineManaged_Injected(IntPtr _unity_self, IntPtr routine) { }

	// RVA: 0x1E70FA4 Offset: 0x1E6CFA4 VA: 0x1E70FA4
	private static void StopCoroutineFromEnumeratorManaged_Injected(IntPtr _unity_self, IEnumerator routine) { }

	// RVA: 0x1E71108 Offset: 0x1E6D108 VA: 0x1E71108
	private static void GetScriptClassName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x1E7114C Offset: 0x1E6D14C VA: 0x1E7114C
	private static void OnCancellationTokenCreated_Injected(IntPtr _unity_self) { }
}

// Namespace: 
private class NoAllocHelpers.ListPrivateFieldAccess<T> // TypeDefIndex: 6833
{
	// Fields
	internal T[] _items; // 0x0
	internal int _size; // 0x0
	internal int _version; // 0x0
}

// Namespace: UnityEngine
internal static class NoAllocHelpers // TypeDefIndex: 6834
{
	// Methods

	// RVA: -1 Offset: -1
	public static void EnsureListElemCount<T>(List<T> list, int count) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113707C Offset: 0x113307C VA: 0x113707C
	|-NoAllocHelpers.EnsureListElemCount<Vector4>
	|
	|-RVA: 0x1137188 Offset: 0x1133188 VA: 0x1137188
	|-NoAllocHelpers.EnsureListElemCount<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E7118C Offset: 0x1E6D18C VA: 0x1E7118C
	public static int SafeLength(Array values) { }

	// RVA: -1 Offset: -1
	public static int SafeLength<T>(List<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1137784 Offset: 0x1133784 VA: 0x1137784
	|-NoAllocHelpers.SafeLength<Color32>
	|
	|-RVA: 0x11377B8 Offset: 0x11337B8 VA: 0x11377B8
	|-NoAllocHelpers.SafeLength<int>
	|
	|-RVA: 0x11377EC Offset: 0x11337EC VA: 0x11377EC
	|-NoAllocHelpers.SafeLength<Vector3>
	|
	|-RVA: 0x1137820 Offset: 0x1133820 VA: 0x1137820
	|-NoAllocHelpers.SafeLength<Vector4>
	|
	|-RVA: 0x1137854 Offset: 0x1133854 VA: 0x1137854
	|-NoAllocHelpers.SafeLength<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static T[] ExtractArrayFromList<T>(List<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11372E0 Offset: 0x11332E0 VA: 0x11372E0
	|-NoAllocHelpers.ExtractArrayFromList<Color32>
	|
	|-RVA: 0x1137338 Offset: 0x1133338 VA: 0x1137338
	|-NoAllocHelpers.ExtractArrayFromList<int>
	|
	|-RVA: 0x1137390 Offset: 0x1133390 VA: 0x1137390
	|-NoAllocHelpers.ExtractArrayFromList<RaycastHit2D>
	|
	|-RVA: 0x11373E8 Offset: 0x11333E8 VA: 0x11373E8
	|-NoAllocHelpers.ExtractArrayFromList<Vector3>
	|
	|-RVA: 0x1137440 Offset: 0x1133440 VA: 0x1137440
	|-NoAllocHelpers.ExtractArrayFromList<Vector4>
	|
	|-RVA: 0x1137498 Offset: 0x1133498 VA: 0x1137498
	|-NoAllocHelpers.ExtractArrayFromList<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void ResetListContents<T>(List<T> list, ReadOnlySpan<T> span) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11374F4 Offset: 0x11334F4 VA: 0x11374F4
	|-NoAllocHelpers.ResetListContents<RaycastHit2D>
	|
	|-RVA: 0x1137578 Offset: 0x1133578 VA: 0x1137578
	|-NoAllocHelpers.ResetListContents<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void ResetListSize<T>(List<T> list, int size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1137614 Offset: 0x1133614 VA: 0x1137614
	|-NoAllocHelpers.ResetListSize<RaycastHit2D>
	|
	|-RVA: 0x11376C8 Offset: 0x11336C8 VA: 0x11376C8
	|-NoAllocHelpers.ResetListSize<__Il2CppFullySharedGenericStructType>
	*/
}

// Namespace: UnityEngine
public struct RangeInt // TypeDefIndex: 6835
{
	// Fields
	public int start; // 0x0
	public int length; // 0x4

	// Properties
	public int end { get; }

	// Methods

	// RVA: 0x1E7119C Offset: 0x1E6D19C VA: 0x1E7119C
	public int get_end() { }

	// RVA: 0x1E711A8 Offset: 0x1E6D1A8 VA: 0x1E711A8
	public void .ctor(int start, int length) { }
}

// Namespace: UnityEngine
public enum RuntimeInitializeLoadType // TypeDefIndex: 6836
{
	// Fields
	public int value__; // 0x0
	public const RuntimeInitializeLoadType AfterSceneLoad = 0;
	public const RuntimeInitializeLoadType BeforeSceneLoad = 1;
	public const RuntimeInitializeLoadType AfterAssembliesLoaded = 2;
	public const RuntimeInitializeLoadType BeforeSplashScreen = 3;
	public const RuntimeInitializeLoadType SubsystemRegistration = 4;
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Usage(64, AllowMultiple = False)]
public class RuntimeInitializeOnLoadMethodAttribute : PreserveAttribute // TypeDefIndex: 6837
{
	// Fields
	private RuntimeInitializeLoadType m_LoadType; // 0x10

	// Properties
	private RuntimeInitializeLoadType loadType { set; }

	// Methods

	// RVA: 0x1E711B0 Offset: 0x1E6D1B0 VA: 0x1E711B0
	public void .ctor(RuntimeInitializeLoadType loadType) { }

	// RVA: 0x1E711E0 Offset: 0x1E6D1E0 VA: 0x1E711E0
	private void set_loadType(RuntimeInitializeLoadType value) { }
}

// Namespace: UnityEngine
[ExtensionOfNativeClass]
[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
[NativeClass(null)]
[RequiredByNativeCode]
public class ScriptableObject : Object // TypeDefIndex: 6838
{
	// Methods

	// RVA: 0x1E711E8 Offset: 0x1E6D1E8 VA: 0x1E711E8
	public void .ctor() { }

	// RVA: 0x1E712A4 Offset: 0x1E6D2A4 VA: 0x1E712A4
	public static ScriptableObject CreateInstance(Type type) { }

	// RVA: -1 Offset: -1
	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114846C Offset: 0x114446C VA: 0x114846C
	|-ScriptableObject.CreateInstance<object>
	*/

	[NativeMethod(IsThreadSafe = True, ThrowsException = True)]
	// RVA: 0x1E71268 Offset: 0x1E6D268 VA: 0x1E71268
	private static void CreateScriptableObject(ScriptableObject self) { }

	[NativeMethod(Name = "Scripting::CreateScriptableObjectWithType", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x1E712AC Offset: 0x1E6D2AC VA: 0x1E712AC
	internal static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset) { }

	// RVA: 0x1E71328 Offset: 0x1E6D328 VA: 0x1E71328
	private static IntPtr CreateScriptableObjectInstanceFromType_Injected(Type type, bool applyDefaultsAndReset) { }
}

// Namespace: 
private struct ScriptingUtility.TestClass // TypeDefIndex: 6839
{
	// Fields
	public int value; // 0x0
}

// Namespace: UnityEngine
internal class ScriptingUtility // TypeDefIndex: 6840
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E7136C Offset: 0x1E6D36C VA: 0x1E7136C
	private static bool IsManagedCodeWorking() { }

	[RequiredByNativeCode]
	// RVA: 0x1E71374 Offset: 0x1E6D374 VA: 0x1E71374
	private static void SetupCallbacks(IntPtr p) { }
}

// Namespace: UnityEngine
[Usage(4, Inherited = True, AllowMultiple = False)]
public class SelectionBaseAttribute : Attribute // TypeDefIndex: 6841
{
	// Methods

	// RVA: 0x1E71378 Offset: 0x1E6D378 VA: 0x1E71378
	public void .ctor() { }
}

// Namespace: UnityEngine
public static class StackTraceUtility // TypeDefIndex: 6842
{
	// Fields
	private static string projectFolder; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E71380 Offset: 0x1E6D380 VA: 0x1E71380
	internal static void SetProjectFolder(string folder) { }

	[RequiredByNativeCode]
	// RVA: 0x1E71484 Offset: 0x1E6D484 VA: 0x1E71484
	public static string ExtractStackTrace() { }

	[RequiredByNativeCode]
	// RVA: 0x1E71D30 Offset: 0x1E6DD30 VA: 0x1E71D30
	internal static void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace) { }

	// RVA: 0x1E715E0 Offset: 0x1E6D5E0 VA: 0x1E715E0
	internal static string ExtractFormattedStackTrace(StackTrace stackFrames) { }

	// RVA: 0x1E720A8 Offset: 0x1E6E0A8 VA: 0x1E720A8
	private static void .cctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Serializable]
public class UnityException : Exception // TypeDefIndex: 6843
{
	// Methods

	// RVA: 0x1E72110 Offset: 0x1E6E110 VA: 0x1E72110
	public void .ctor() { }

	// RVA: 0x1E6FDC0 Offset: 0x1E6BDC0 VA: 0x1E6FDC0
	public void .ctor(string message) { }

	// RVA: 0x1E72190 Offset: 0x1E6E190 VA: 0x1E72190
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: UnityEngine
[Serializable]
public class MissingReferenceException : Exception // TypeDefIndex: 6844
{
	// Methods

	// RVA: 0x1E72210 Offset: 0x1E6E210 VA: 0x1E72210
	public void .ctor() { }

	// RVA: 0x1E6F9A0 Offset: 0x1E6B9A0 VA: 0x1E6F9A0
	public void .ctor(string message) { }

	// RVA: 0x1E72290 Offset: 0x1E6E290 VA: 0x1E72290
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: 
internal enum TextAsset.CreateOptions // TypeDefIndex: 6845
{
	// Fields
	public int value__; // 0x0
	public const TextAsset.CreateOptions None = 0;
	public const TextAsset.CreateOptions CreateNativeObject = 1;
}

// Namespace: 
private static class TextAsset.EncodingUtility // TypeDefIndex: 6846
{
	// Fields
	internal static readonly KeyValuePair<byte[], Encoding>[] encodingLookup; // 0x0
	internal static readonly Encoding targetEncoding; // 0x8

	// Methods

	// RVA: 0x1E7289C Offset: 0x1E6E89C VA: 0x1E7289C
	private static void .cctor() { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Scripting/TextAsset.h")]
public class TextAsset : Object // TypeDefIndex: 6847
{
	// Properties
	public byte[] bytes { get; }
	public string text { get; }

	// Methods

	// RVA: 0x1E72310 Offset: 0x1E6E310 VA: 0x1E72310
	public byte[] get_bytes() { }

	// RVA: 0x1E723BC Offset: 0x1E6E3BC VA: 0x1E723BC
	private static void Internal_CreateInstance(TextAsset self, string text) { }

	// RVA: 0x1E72548 Offset: 0x1E6E548 VA: 0x1E72548
	public string get_text() { }

	// RVA: 0x1E72800 Offset: 0x1E6E800 VA: 0x1E72800 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E72804 Offset: 0x1E6E804 VA: 0x1E72804
	public void .ctor() { }

	// RVA: 0x1E72810 Offset: 0x1E6E810 VA: 0x1E72810
	internal void .ctor(TextAsset.CreateOptions options, string text) { }

	// RVA: 0x1E72584 Offset: 0x1E6E584 VA: 0x1E72584
	internal static string DecodeString(byte[] bytes) { }

	// RVA: 0x1E72380 Offset: 0x1E6E380 VA: 0x1E72380
	private static byte[] get_bytes_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E72504 Offset: 0x1E6E504 VA: 0x1E72504
	private static void Internal_CreateInstance_Injected(TextAsset self, ref ManagedSpanWrapper text) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public class TrackedReference // TypeDefIndex: 6848
{
	// Fields
	[VisibleToOtherModules(new[] { "UnityEngine.AnimationModule" })]
	internal IntPtr m_Ptr; // 0x10
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class UnhandledExceptionHandler.<>c // TypeDefIndex: 6849
{
	// Fields
	public static readonly UnhandledExceptionHandler.<>c <>9; // 0x0
	public static UnhandledExceptionEventHandler <>9__0_0; // 0x8

	// Methods

	// RVA: 0x1E72D68 Offset: 0x1E6ED68 VA: 0x1E72D68
	private static void .cctor() { }

	// RVA: 0x1E72DD0 Offset: 0x1E6EDD0 VA: 0x1E72DD0
	public void .ctor() { }

	// RVA: 0x1E72DD8 Offset: 0x1E6EDD8 VA: 0x1E72DD8
	internal void <RegisterUECatcher>b__0_0(object sender, UnhandledExceptionEventArgs e) { }
}

// Namespace: UnityEngine
[NativeHeader("PlatformDependent/iPhonePlayer/IOSScriptBindings.h")]
internal sealed class UnhandledExceptionHandler // TypeDefIndex: 6850
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E72C6C Offset: 0x1E6EC6C VA: 0x1E72C6C
	private static void RegisterUECatcher() { }
}

// Namespace: UnityEngine
[Flags]
public enum HideFlags // TypeDefIndex: 6851
{
	// Fields
	public int value__; // 0x0
	public const HideFlags None = 0;
	public const HideFlags HideInHierarchy = 1;
	public const HideFlags HideInInspector = 2;
	public const HideFlags DontSaveInEditor = 4;
	public const HideFlags NotEditable = 8;
	public const HideFlags DontSaveInBuild = 16;
	public const HideFlags DontUnloadUnusedAsset = 32;
	public const HideFlags DontSave = 52;
	public const HideFlags HideAndDontSave = 61;
}

// Namespace: 
[VisibleToOtherModules]
internal static class Object.MarshalledUnityObject // TypeDefIndex: 6852
{
	// Methods

	// RVA: -1 Offset: -1
	public static IntPtr Marshal<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x104D254 Offset: 0x1049254 VA: 0x104D254
	|-Object.MarshalledUnityObject.Marshal<object>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr MarshalNotNull<T>(T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x104D288 Offset: 0x1049288 VA: 0x104D288
	|-Object.MarshalledUnityObject.MarshalNotNull<object>
	*/

	// RVA: 0x1E74480 Offset: 0x1E70480 VA: 0x1E74480
	public static void TryThrowEditorNullExceptionObject(Object unityObj, string paramterName) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode(GenerateProxy = True)]
[NativeHeader("Runtime/GameCode/CloneObject.h")]
[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
[NativeHeader("Runtime/SceneManager/SceneManager.h")]
public class Object // TypeDefIndex: 6853
{
	// Fields
	private const int kInstanceID_None = 0;
	private IntPtr m_CachedPtr; // 0x10
	internal static readonly int OffsetOfInstanceIDInCPlusPlusObject; // 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null.";
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";

	// Properties
	public string name { get; set; }
	public HideFlags hideFlags { get; set; }

	// Methods

	// RVA: 0x1E72E8C Offset: 0x1E6EE8C VA: 0x1E72E8C
	public int GetInstanceID() { }

	// RVA: 0x1E72F04 Offset: 0x1E6EF04 VA: 0x1E72F04 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E72F0C Offset: 0x1E6EF0C VA: 0x1E72F0C Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1E730B0 Offset: 0x1E6F0B0 VA: 0x1E730B0
	public static bool op_Implicit(Object exists) { }

	// RVA: 0x1E73008 Offset: 0x1E6F008 VA: 0x1E73008
	private static bool CompareBaseObjects(Object lhs, Object rhs) { }

	// RVA: 0x1E73114 Offset: 0x1E6F114 VA: 0x1E73114
	private static bool IsNativeObjectAlive(Object o) { }

	// RVA: 0x1E73130 Offset: 0x1E6F130 VA: 0x1E73130
	private IntPtr GetCachedPtr() { }

	// RVA: 0x1E73138 Offset: 0x1E6F138 VA: 0x1E73138
	public string get_name() { }

	// RVA: 0x1E73280 Offset: 0x1E6F280 VA: 0x1E73280
	public void set_name(string value) { }

	[TypeInferenceRule(3)]
	// RVA: 0x1E73414 Offset: 0x1E6F414 VA: 0x1E73414
	public static Object Instantiate(Object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRule(3)]
	// RVA: 0x1E736F8 Offset: 0x1E6F6F8 VA: 0x1E736F8
	public static Object Instantiate(Object original) { }

	[TypeInferenceRule(3)]
	// RVA: 0x1E7388C Offset: 0x1E6F88C VA: 0x1E7388C
	public static Object Instantiate(Object original, Transform parent, bool instantiateInWorldSpace) { }

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11378A8 Offset: 0x11338A8 VA: 0x11378A8
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1137A9C Offset: 0x1133A9C VA: 0x1137A9C
	|-Object.Instantiate<object>
	*/

	// RVA: -1 Offset: -1
	public static T Instantiate<T>(T original, Transform parent, bool worldPositionStays) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11379D8 Offset: 0x11339D8 VA: 0x11379D8
	|-Object.Instantiate<object>
	*/

	[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x1E73AC0 Offset: 0x1E6FAC0 VA: 0x1E73AC0
	public static void Destroy(Object obj, float t) { }

	[ExcludeFromDocs]
	// RVA: 0x1E73BBC Offset: 0x1E6FBBC VA: 0x1E73BBC
	public static void Destroy(Object obj) { }

	[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x1E73C14 Offset: 0x1E6FC14 VA: 0x1E73C14
	public static void DestroyImmediate(Object obj, bool allowDestroyingAssets) { }

	[ExcludeFromDocs]
	// RVA: 0x1E73D08 Offset: 0x1E6FD08 VA: 0x1E73D08
	public static void DestroyImmediate(Object obj) { }

	[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = True)]
	// RVA: 0x1E73D60 Offset: 0x1E6FD60 VA: 0x1E73D60
	public static void DontDestroyOnLoad(Object target) { }

	// RVA: 0x1E73E44 Offset: 0x1E6FE44 VA: 0x1E73E44
	public HideFlags get_hideFlags() { }

	// RVA: 0x1E73F14 Offset: 0x1E6FF14 VA: 0x1E73F14
	public void set_hideFlags(HideFlags value) { }

	// RVA: 0x1E735C4 Offset: 0x1E6F5C4 VA: 0x1E735C4
	private static void CheckNullArgument(object arg, string message) { }

	// RVA: 0x1E73FF4 Offset: 0x1E6FFF4 VA: 0x1E73FF4 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E6F93C Offset: 0x1E6B93C VA: 0x1E6F93C
	public static bool op_Equality(Object x, Object y) { }

	// RVA: 0x1E6E668 Offset: 0x1E6A668 VA: 0x1E6E668
	public static bool op_Inequality(Object x, Object y) { }

	[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = True, IsThreadSafe = True)]
	// RVA: 0x1E74174 Offset: 0x1E70174 VA: 0x1E74174
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[NativeMethod(Name = "CloneObject", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x1E737C8 Offset: 0x1E6F7C8 VA: 0x1E737C8
	private static Object Internal_CloneSingle(Object data) { }

	[FreeFunction("CloneObject")]
	// RVA: 0x1E739B4 Offset: 0x1E6F9B4 VA: 0x1E739B4
	private static Object Internal_CloneSingleWithParent(Object data, Transform parent, bool worldPositionStays) { }

	[FreeFunction("InstantiateObject")]
	// RVA: 0x1E73610 Offset: 0x1E6F610 VA: 0x1E73610
	private static Object Internal_InstantiateSingle(Object data, Vector3 pos, Quaternion rot) { }

	[FreeFunction("UnityEngineObjectBindings::ToString")]
	// RVA: 0x1E74048 Offset: 0x1E70048 VA: 0x1E74048
	private static string ToString(Object obj) { }

	[FreeFunction("UnityEngineObjectBindings::GetName", HasExplicitThis = True)]
	// RVA: 0x1E7313C Offset: 0x1E6F13C VA: 0x1E7313C
	private string GetName() { }

	[FreeFunction("UnityEngineObjectBindings::SetName", HasExplicitThis = True)]
	// RVA: 0x1E73284 Offset: 0x1E6F284 VA: 0x1E73284
	private void SetName(string name) { }

	[VisibleToOtherModules]
	[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
	// RVA: 0x1E7434C Offset: 0x1E7034C VA: 0x1E7434C
	internal static Object FindObjectFromInstanceID(int instanceID) { }

	// RVA: 0x1E6DF6C Offset: 0x1E69F6C VA: 0x1E6DF6C
	public void .ctor() { }

	// RVA: 0x1E74418 Offset: 0x1E70418 VA: 0x1E74418
	private static void .cctor() { }

	// RVA: 0x1E73B70 Offset: 0x1E6FB70 VA: 0x1E73B70
	private static void Destroy_Injected(IntPtr obj, float t) { }

	// RVA: 0x1E73CC4 Offset: 0x1E6FCC4 VA: 0x1E73CC4
	private static void DestroyImmediate_Injected(IntPtr obj, bool allowDestroyingAssets) { }

	// RVA: 0x1E73E08 Offset: 0x1E6FE08 VA: 0x1E73E08
	private static void DontDestroyOnLoad_Injected(IntPtr target) { }

	// RVA: 0x1E73ED8 Offset: 0x1E6FED8 VA: 0x1E73ED8
	private static HideFlags get_hideFlags_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E73FB0 Offset: 0x1E6FFB0 VA: 0x1E73FB0
	private static void set_hideFlags_Injected(IntPtr _unity_self, HideFlags value) { }

	// RVA: 0x1E7419C Offset: 0x1E7019C VA: 0x1E7419C
	private static IntPtr Internal_CloneSingle_Injected(IntPtr data) { }

	// RVA: 0x1E741D8 Offset: 0x1E701D8 VA: 0x1E741D8
	private static IntPtr Internal_CloneSingleWithParent_Injected(IntPtr data, IntPtr parent, bool worldPositionStays) { }

	// RVA: 0x1E7422C Offset: 0x1E7022C VA: 0x1E7422C
	private static IntPtr Internal_InstantiateSingle_Injected(IntPtr data, in Vector3 pos, in Quaternion rot) { }

	// RVA: 0x1E74280 Offset: 0x1E70280 VA: 0x1E74280
	private static void ToString_Injected(IntPtr obj, out ManagedSpanWrapper ret) { }

	// RVA: 0x1E742C4 Offset: 0x1E702C4 VA: 0x1E742C4
	private static void GetName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x1E74308 Offset: 0x1E70308 VA: 0x1E74308
	private static void SetName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	// RVA: 0x1E743DC Offset: 0x1E703DC VA: 0x1E743DC
	private static IntPtr FindObjectFromInstanceID_Injected(int instanceID) { }
}

// Namespace: 
private struct UnitySynchronizationContext.WorkRequest // TypeDefIndex: 6854
{
	// Fields
	private readonly SendOrPostCallback m_DelagateCallback; // 0x0
	private readonly object m_DelagateState; // 0x8
	private readonly ManualResetEvent m_WaitHandle; // 0x10

	// Methods

	// RVA: 0x1E74918 Offset: 0x1E70918 VA: 0x1E74918
	public void .ctor(SendOrPostCallback callback, object state, ManualResetEvent waitHandle) { }

	// RVA: 0x1E74D4C Offset: 0x1E70D4C VA: 0x1E74D4C
	public void Invoke() { }
}

// Namespace: UnityEngine
internal sealed class UnitySynchronizationContext : SynchronizationContext // TypeDefIndex: 6855
{
	// Fields
	private readonly List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue; // 0x18
	private readonly List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork; // 0x20
	private readonly int m_MainThreadID; // 0x28
	private int m_TrackedCount; // 0x2C

	// Properties
	internal int MainThreadId { get; }

	// Methods

	// RVA: 0x1E74484 Offset: 0x1E70484 VA: 0x1E74484
	internal int get_MainThreadId() { }

	// RVA: 0x1E7448C Offset: 0x1E7048C VA: 0x1E7448C
	private void .ctor(int mainThreadID) { }

	// RVA: 0x1E74550 Offset: 0x1E70550 VA: 0x1E74550
	private void .ctor(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID) { }

	// RVA: 0x1E74608 Offset: 0x1E70608 VA: 0x1E74608 Slot: 4
	public override void Send(SendOrPostCallback callback, object state) { }

	// RVA: 0x1E7495C Offset: 0x1E7095C VA: 0x1E7495C Slot: 6
	public override void OperationStarted() { }

	// RVA: 0x1E74968 Offset: 0x1E70968 VA: 0x1E74968 Slot: 7
	public override void OperationCompleted() { }

	// RVA: 0x1E74974 Offset: 0x1E70974 VA: 0x1E74974 Slot: 5
	public override void Post(SendOrPostCallback callback, object state) { }

	// RVA: 0x1E74B14 Offset: 0x1E70B14 VA: 0x1E74B14 Slot: 9
	public override SynchronizationContext CreateCopy() { }

	// RVA: 0x1E74B78 Offset: 0x1E70B78 VA: 0x1E74B78
	public void Exec() { }

	// RVA: 0x1E74E18 Offset: 0x1E70E18 VA: 0x1E74E18
	private bool HasPendingTasks() { }

	[RequiredByNativeCode]
	// RVA: 0x1E74E78 Offset: 0x1E70E78 VA: 0x1E74E78
	private static void InitializeSynchronizationContext() { }

	[RequiredByNativeCode]
	// RVA: 0x1E74F1C Offset: 0x1E70F1C VA: 0x1E74F1C
	private static void ExecuteTasks() { }

	[RequiredByNativeCode]
	// RVA: 0x1E74F74 Offset: 0x1E70F74 VA: 0x1E74F74
	private static bool ExecutePendingTasks(long millisecondsTimeout) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public sealed class WaitForEndOfFrame : YieldInstruction // TypeDefIndex: 6856
{
	// Methods

	// RVA: 0x1E75060 Offset: 0x1E71060 VA: 0x1E75060
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public sealed class WaitForFixedUpdate : YieldInstruction // TypeDefIndex: 6857
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
public sealed class WaitForSeconds : YieldInstruction // TypeDefIndex: 6858
{
	// Fields
	internal float m_Seconds; // 0x10
}

// Namespace: UnityEngine
public class WaitForSecondsRealtime : CustomYieldInstruction // TypeDefIndex: 6859
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private float <waitTime>k__BackingField; // 0x10
	private float m_WaitUntilTime; // 0x14

	// Properties
	public float waitTime { get; set; }
	public override bool keepWaiting { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E75068 Offset: 0x1E71068 VA: 0x1E75068
	public float get_waitTime() { }

	[CompilerGenerated]
	// RVA: 0x1E75070 Offset: 0x1E71070 VA: 0x1E75070
	public void set_waitTime(float value) { }

	// RVA: 0x1E75078 Offset: 0x1E71078 VA: 0x1E75078 Slot: 7
	public override bool get_keepWaiting() { }

	// RVA: 0x1E7513C Offset: 0x1E7113C VA: 0x1E7513C
	public void .ctor(float time) { }

	// RVA: 0x1E7516C Offset: 0x1E7116C VA: 0x1E7516C Slot: 8
	public override void Reset() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
public class YieldInstruction // TypeDefIndex: 6860
{
	// Methods

	// RVA: 0x1E6A7F8 Offset: 0x1E667F8 VA: 0x1E6A7F8
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public sealed class SerializeField : Attribute // TypeDefIndex: 6861
{
	// Methods

	// RVA: 0x1E75178 Offset: 0x1E71178 VA: 0x1E75178
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(256)]
[RequiredByNativeCode]
public sealed class SerializeReference : Attribute // TypeDefIndex: 6862
{
	// Methods

	[ExcludeFromDocs]
	// RVA: 0x1E75180 Offset: 0x1E71180 VA: 0x1E75180
	public void .ctor() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Usage(4)]
public sealed class PreferBinarySerialization : Attribute // TypeDefIndex: 6863
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
public interface ISerializationCallbackReceiver // TypeDefIndex: 6864
{
	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnBeforeSerialize();

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnAfterDeserialize();
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Shaders/RayTracing/RayTracingAccelerationStructure.h")]
[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
public sealed class ComputeShader : Object // TypeDefIndex: 6865
{
	// Methods

	[RequiredByNativeCode]
	[NativeMethod(Name = "ComputeShaderScripting::FindKernel", HasExplicitThis = True, IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x1E75188 Offset: 0x1E71188 VA: 0x1E75188
	public int FindKernel(string name) { }

	// RVA: 0x1E75300 Offset: 0x1E71300 VA: 0x1E75300
	private static int FindKernel_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }
}

// Namespace: UnityEngine
internal class LowerResBlitTexture : Object // TypeDefIndex: 6866
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E75344 Offset: 0x1E71344 VA: 0x1E75344
	internal void LowerResBlitTextureDontStripMe() { }
}

// Namespace: UnityEngine
internal class PreloadData : Object // TypeDefIndex: 6867
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E75348 Offset: 0x1E71348 VA: 0x1E75348
	internal void PreloadDataDontStripMe() { }
}

// Namespace: UnityEngine
public enum OperatingSystemFamily // TypeDefIndex: 6868
{
	// Fields
	public int value__; // 0x0
	public const OperatingSystemFamily Other = 0;
	public const OperatingSystemFamily MacOSX = 1;
	public const OperatingSystemFamily Windows = 2;
	public const OperatingSystemFamily Linux = 3;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
[NativeHeader("Runtime/Misc/SystemInfoMemory.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
public sealed class SystemInfo // TypeDefIndex: 6869
{
	// Properties
	public static string operatingSystem { get; }
	public static OperatingSystemFamily operatingSystemFamily { get; }
	public static string deviceModel { get; }

	// Methods

	// RVA: 0x1E7534C Offset: 0x1E7134C VA: 0x1E7534C
	public static string get_operatingSystem() { }

	// RVA: 0x1E75410 Offset: 0x1E71410 VA: 0x1E75410
	public static OperatingSystemFamily get_operatingSystemFamily() { }

	// RVA: 0x1E75460 Offset: 0x1E71460 VA: 0x1E75460
	public static string get_deviceModel() { }

	// RVA: 0x1E75524 Offset: 0x1E71524 VA: 0x1E75524
	private static bool IsValidEnumValue(Enum value) { }

	// RVA: 0x1E75578 Offset: 0x1E71578 VA: 0x1E75578
	public static bool SupportsTextureFormat(TextureFormat format) { }

	[FreeFunction("systeminfo::GetOperatingSystem")]
	// RVA: 0x1E75350 Offset: 0x1E71350 VA: 0x1E75350
	private static string GetOperatingSystem() { }

	[FreeFunction("systeminfo::GetOperatingSystemFamily")]
	// RVA: 0x1E75438 Offset: 0x1E71438 VA: 0x1E75438
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunction("systeminfo::GetDeviceModel")]
	// RVA: 0x1E75464 Offset: 0x1E71464 VA: 0x1E75464
	private static string GetDeviceModel() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
	// RVA: 0x1E7564C Offset: 0x1E7164C VA: 0x1E7564C
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
	// RVA: 0x1E75700 Offset: 0x1E71700 VA: 0x1E75700
	public static bool IsFormatSupported(GraphicsFormat format, GraphicsFormatUsage usage) { }

	[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
	// RVA: 0x1E75744 Offset: 0x1E71744 VA: 0x1E75744
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, GraphicsFormatUsage usage) { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
	// RVA: 0x1E75788 Offset: 0x1E71788 VA: 0x1E75788
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

	// RVA: 0x1E75688 Offset: 0x1E71688 VA: 0x1E75688
	private static void GetOperatingSystem_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x1E756C4 Offset: 0x1E716C4 VA: 0x1E756C4
	private static void GetDeviceModel_Injected(out ManagedSpanWrapper ret) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/TimeManager.h")]
[StaticAccessor("GetTimeManager()", 0)]
public class Time // TypeDefIndex: 6870
{
	// Properties
	[NativeProperty("TimeSinceSceneLoad")]
	public static float timeSinceLevelLoad { get; }
	public static float deltaTime { get; }
	public static float unscaledTime { get; }
	public static float unscaledDeltaTime { get; }
	public static float smoothDeltaTime { get; }
	public static int frameCount { get; }
	[NativeProperty("Realtime")]
	public static float realtimeSinceStartup { get; }

	// Methods

	// RVA: 0x1E757C4 Offset: 0x1E717C4 VA: 0x1E757C4
	public static float get_timeSinceLevelLoad() { }

	// RVA: 0x1E757EC Offset: 0x1E717EC VA: 0x1E757EC
	public static float get_deltaTime() { }

	// RVA: 0x1E75814 Offset: 0x1E71814 VA: 0x1E75814
	public static float get_unscaledTime() { }

	// RVA: 0x1E7583C Offset: 0x1E7183C VA: 0x1E7583C
	public static float get_unscaledDeltaTime() { }

	// RVA: 0x1E75864 Offset: 0x1E71864 VA: 0x1E75864
	public static float get_smoothDeltaTime() { }

	// RVA: 0x1E6CDC4 Offset: 0x1E68DC4 VA: 0x1E6CDC4
	public static int get_frameCount() { }

	// RVA: 0x1E75114 Offset: 0x1E71114 VA: 0x1E75114
	public static float get_realtimeSinceStartup() { }
}

// Namespace: UnityEngine
internal struct TouchScreenKeyboard_InternalConstructorHelperArguments // TypeDefIndex: 6871
{
	// Fields
	public uint keyboardType; // 0x0
	public uint autocorrection; // 0x4
	public uint multiline; // 0x8
	public uint secure; // 0xC
	public uint alert; // 0x10
	public int characterLimit; // 0x14
}

// Namespace: 
public enum TouchScreenKeyboard.Status // TypeDefIndex: 6872
{
	// Fields
	public int value__; // 0x0
	public const TouchScreenKeyboard.Status Visible = 0;
	public const TouchScreenKeyboard.Status Done = 1;
	public const TouchScreenKeyboard.Status Canceled = 2;
	public const TouchScreenKeyboard.Status LostFocus = 3;
}

// Namespace: 
internal static class TouchScreenKeyboard.BindingsMarshaller // TypeDefIndex: 6873
{
	// Methods

	// RVA: 0x1E76818 Offset: 0x1E72818 VA: 0x1E76818
	public static IntPtr ConvertToNative(TouchScreenKeyboard touchScreenKeyboard) { }
}

// Namespace: UnityEngine
[NativeConditional("ENABLE_ONSCREEN_KEYBOARD")]
[NativeHeader("Runtime/Input/KeyboardOnScreen.h")]
[NativeHeader("Runtime/Export/TouchScreenKeyboard/TouchScreenKeyboard.bindings.h")]
public class TouchScreenKeyboard // TypeDefIndex: 6874
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static bool <disableInPlaceEditing>k__BackingField; // 0x0

	// Properties
	public static bool isSupported { get; }
	internal static bool disableInPlaceEditing { get; }
	public static bool isInPlaceEditingAllowed { get; }
	public string text { get; set; }
	public static bool hideInput { set; }
	public bool active { get; set; }
	public TouchScreenKeyboard.Status status { get; }
	public int characterLimit { set; }
	public bool canGetSelection { get; }
	public bool canSetSelection { get; }
	public RangeInt selection { get; set; }

	// Methods

	[FreeFunction("TouchScreenKeyboard_Destroy", IsThreadSafe = True)]
	// RVA: 0x1E7588C Offset: 0x1E7188C VA: 0x1E7588C
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x1E758C8 Offset: 0x1E718C8 VA: 0x1E758C8
	private void Destroy() { }

	// RVA: 0x1E7595C Offset: 0x1E7195C VA: 0x1E7595C Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1E759E0 Offset: 0x1E719E0 VA: 0x1E759E0
	public void .ctor(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[FreeFunction("TouchScreenKeyboard_InternalConstructorHelper")]
	// RVA: 0x1E75B24 Offset: 0x1E71B24 VA: 0x1E75B24
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, string text, string textPlaceholder) { }

	// RVA: 0x1E75D74 Offset: 0x1E71D74 VA: 0x1E75D74
	public static bool get_isSupported() { }

	[CompilerGenerated]
	// RVA: 0x1E75E3C Offset: 0x1E71E3C VA: 0x1E75E3C
	internal static bool get_disableInPlaceEditing() { }

	// RVA: 0x1E75E84 Offset: 0x1E71E84 VA: 0x1E75E84
	public static bool get_isInPlaceEditingAllowed() { }

	// RVA: 0x1E75EF0 Offset: 0x1E71EF0 VA: 0x1E75EF0
	private static bool IsInPlaceEditingAllowed() { }

	// RVA: 0x1E75F18 Offset: 0x1E71F18 VA: 0x1E75F18
	public static TouchScreenKeyboard Open(string text, TouchScreenKeyboardType keyboardType, bool autocorrection, bool multiline, bool secure, bool alert, string textPlaceholder, int characterLimit) { }

	[NativeName("GetText")]
	// RVA: 0x1E75FD0 Offset: 0x1E71FD0 VA: 0x1E75FD0
	public string get_text() { }

	[NativeName("SetText")]
	// RVA: 0x1E7610C Offset: 0x1E7210C VA: 0x1E7610C
	public void set_text(string value) { }

	[NativeName("SetInputHidden")]
	// RVA: 0x1E762B0 Offset: 0x1E722B0 VA: 0x1E762B0
	public static void set_hideInput(bool value) { }

	[NativeName("IsActive")]
	// RVA: 0x1E762EC Offset: 0x1E722EC VA: 0x1E762EC
	public bool get_active() { }

	[NativeName("SetActive")]
	// RVA: 0x1E76374 Offset: 0x1E72374 VA: 0x1E76374
	public void set_active(bool value) { }

	[NativeName("GetKeyboardStatus")]
	// RVA: 0x1E7640C Offset: 0x1E7240C VA: 0x1E7640C
	public TouchScreenKeyboard.Status get_status() { }

	[NativeName("SetCharacterLimit")]
	// RVA: 0x1E76494 Offset: 0x1E72494 VA: 0x1E76494
	public void set_characterLimit(int value) { }

	[NativeName("CanGetSelection")]
	// RVA: 0x1E7652C Offset: 0x1E7252C VA: 0x1E7652C
	public bool get_canGetSelection() { }

	[NativeName("CanSetSelection")]
	// RVA: 0x1E765B4 Offset: 0x1E725B4 VA: 0x1E765B4
	public bool get_canSetSelection() { }

	// RVA: 0x1E7663C Offset: 0x1E7263C VA: 0x1E7663C
	public RangeInt get_selection() { }

	// RVA: 0x1E766CC Offset: 0x1E726CC VA: 0x1E766CC
	public void set_selection(RangeInt value) { }

	// RVA: 0x1E76688 Offset: 0x1E72688 VA: 0x1E76688
	private static void GetSelection(out int start, out int length) { }

	// RVA: 0x1E767D4 Offset: 0x1E727D4 VA: 0x1E767D4
	private static void SetSelection(int start, int length) { }

	// RVA: 0x1E75D20 Offset: 0x1E71D20 VA: 0x1E75D20
	private static IntPtr TouchScreenKeyboard_InternalConstructorHelper_Injected(ref TouchScreenKeyboard_InternalConstructorHelperArguments arguments, ref ManagedSpanWrapper text, ref ManagedSpanWrapper textPlaceholder) { }

	// RVA: 0x1E760C8 Offset: 0x1E720C8 VA: 0x1E760C8
	private static void get_text_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x1E7626C Offset: 0x1E7226C VA: 0x1E7626C
	private static void set_text_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	// RVA: 0x1E76338 Offset: 0x1E72338 VA: 0x1E76338
	private static bool get_active_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E763C8 Offset: 0x1E723C8 VA: 0x1E763C8
	private static void set_active_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1E76458 Offset: 0x1E72458 VA: 0x1E76458
	private static TouchScreenKeyboard.Status get_status_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E764E8 Offset: 0x1E724E8 VA: 0x1E764E8
	private static void set_characterLimit_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1E76578 Offset: 0x1E72578 VA: 0x1E76578
	private static bool get_canGetSelection_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E76600 Offset: 0x1E72600 VA: 0x1E76600
	private static bool get_canSetSelection_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
public enum TouchScreenKeyboardType // TypeDefIndex: 6875
{
	// Fields
	public int value__; // 0x0
	public const TouchScreenKeyboardType Default = 0;
	public const TouchScreenKeyboardType ASCIICapable = 1;
	public const TouchScreenKeyboardType NumbersAndPunctuation = 2;
	public const TouchScreenKeyboardType URL = 3;
	public const TouchScreenKeyboardType NumberPad = 4;
	public const TouchScreenKeyboardType PhonePad = 5;
	public const TouchScreenKeyboardType NamePhonePad = 6;
	public const TouchScreenKeyboardType EmailAddress = 7;
	[Obsolete("Wii U is no longer supported as of Unity 2018.1.")]
	public const TouchScreenKeyboardType NintendoNetworkAccount = 8;
	public const TouchScreenKeyboardType Social = 9;
	public const TouchScreenKeyboardType Search = 10;
	public const TouchScreenKeyboardType DecimalPad = 11;
	public const TouchScreenKeyboardType OneTimeCode = 12;
}

// Namespace: UnityEngine
[Flags]
public enum DrivenTransformProperties // TypeDefIndex: 6876
{
	// Fields
	public int value__; // 0x0
	public const DrivenTransformProperties None = 0;
	public const DrivenTransformProperties All = -1;
	public const DrivenTransformProperties AnchoredPositionX = 2;
	public const DrivenTransformProperties AnchoredPositionY = 4;
	public const DrivenTransformProperties AnchoredPositionZ = 8;
	public const DrivenTransformProperties Rotation = 16;
	public const DrivenTransformProperties ScaleX = 32;
	public const DrivenTransformProperties ScaleY = 64;
	public const DrivenTransformProperties ScaleZ = 128;
	public const DrivenTransformProperties AnchorMinX = 256;
	public const DrivenTransformProperties AnchorMinY = 512;
	public const DrivenTransformProperties AnchorMaxX = 1024;
	public const DrivenTransformProperties AnchorMaxY = 2048;
	public const DrivenTransformProperties SizeDeltaX = 4096;
	public const DrivenTransformProperties SizeDeltaY = 8192;
	public const DrivenTransformProperties PivotX = 16384;
	public const DrivenTransformProperties PivotY = 32768;
	public const DrivenTransformProperties AnchoredPosition = 6;
	public const DrivenTransformProperties AnchoredPosition3D = 14;
	public const DrivenTransformProperties Scale = 224;
	public const DrivenTransformProperties AnchorMin = 768;
	public const DrivenTransformProperties AnchorMax = 3072;
	public const DrivenTransformProperties Anchors = 3840;
	public const DrivenTransformProperties SizeDelta = 12288;
	public const DrivenTransformProperties Pivot = 49152;
}

// Namespace: UnityEngine
public struct DrivenRectTransformTracker // TypeDefIndex: 6877
{
	// Methods

	// RVA: 0x1E7682C Offset: 0x1E7282C VA: 0x1E7682C
	public void Add(Object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties) { }

	// RVA: 0x1E76830 Offset: 0x1E72830 VA: 0x1E76830
	public void Clear() { }
}

// Namespace: 
public enum RectTransform.Axis // TypeDefIndex: 6878
{
	// Fields
	public int value__; // 0x0
	public const RectTransform.Axis Horizontal = 0;
	public const RectTransform.Axis Vertical = 1;
}

// Namespace: 
public sealed class RectTransform.ReapplyDrivenProperties : MulticastDelegate // TypeDefIndex: 6879
{
	// Methods

	// RVA: 0x1E77A88 Offset: 0x1E73A88 VA: 0x1E77A88
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E77B38 Offset: 0x1E73B38 VA: 0x1E77B38 Slot: 12
	public virtual void Invoke(RectTransform driven) { }
}

// Namespace: UnityEngine
[NativeClass("UI::RectTransform")]
[NativeHeader("Runtime/Transform/RectTransform.h")]
public sealed class RectTransform : Transform // TypeDefIndex: 6880
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static RectTransform.ReapplyDrivenProperties reapplyDrivenProperties; // 0x0

	// Properties
	public Rect rect { get; }
	public Vector2 anchorMin { get; set; }
	public Vector2 anchorMax { get; set; }
	public Vector2 anchoredPosition { get; set; }
	public Vector2 sizeDelta { get; set; }
	public Vector2 pivot { get; set; }
	public Vector2 offsetMin { get; set; }
	public Vector2 offsetMax { get; set; }
	public bool sendChildDimensionsChange { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E76834 Offset: 0x1E72834 VA: 0x1E76834
	public static void add_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	[CompilerGenerated]
	// RVA: 0x1E768EC Offset: 0x1E728EC VA: 0x1E768EC
	public static void remove_reapplyDrivenProperties(RectTransform.ReapplyDrivenProperties value) { }

	// RVA: 0x1E769A4 Offset: 0x1E729A4 VA: 0x1E769A4
	public Rect get_rect() { }

	// RVA: 0x1E76A74 Offset: 0x1E72A74 VA: 0x1E76A74
	public Vector2 get_anchorMin() { }

	// RVA: 0x1E76B38 Offset: 0x1E72B38 VA: 0x1E76B38
	public void set_anchorMin(Vector2 value) { }

	// RVA: 0x1E76BF8 Offset: 0x1E72BF8 VA: 0x1E76BF8
	public Vector2 get_anchorMax() { }

	// RVA: 0x1E76CBC Offset: 0x1E72CBC VA: 0x1E76CBC
	public void set_anchorMax(Vector2 value) { }

	// RVA: 0x1E76D7C Offset: 0x1E72D7C VA: 0x1E76D7C
	public Vector2 get_anchoredPosition() { }

	// RVA: 0x1E76E40 Offset: 0x1E72E40 VA: 0x1E76E40
	public void set_anchoredPosition(Vector2 value) { }

	// RVA: 0x1E76F00 Offset: 0x1E72F00 VA: 0x1E76F00
	public Vector2 get_sizeDelta() { }

	// RVA: 0x1E76FC4 Offset: 0x1E72FC4 VA: 0x1E76FC4
	public void set_sizeDelta(Vector2 value) { }

	// RVA: 0x1E77084 Offset: 0x1E73084 VA: 0x1E77084
	public Vector2 get_pivot() { }

	// RVA: 0x1E77148 Offset: 0x1E73148 VA: 0x1E77148
	public void set_pivot(Vector2 value) { }

	// RVA: 0x1E77208 Offset: 0x1E73208 VA: 0x1E77208
	public Vector2 get_offsetMin() { }

	// RVA: 0x1E7725C Offset: 0x1E7325C VA: 0x1E7725C
	public void set_offsetMin(Vector2 value) { }

	// RVA: 0x1E77350 Offset: 0x1E73350 VA: 0x1E77350
	public Vector2 get_offsetMax() { }

	// RVA: 0x1E773F0 Offset: 0x1E733F0 VA: 0x1E773F0
	public void set_offsetMax(Vector2 value) { }

	// RVA: 0x1E774EC Offset: 0x1E734EC VA: 0x1E774EC
	public void set_sendChildDimensionsChange(bool value) { }

	// RVA: 0x1E775A8 Offset: 0x1E735A8 VA: 0x1E775A8
	public void GetLocalCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x1E77688 Offset: 0x1E73688 VA: 0x1E77688
	public void GetWorldCorners(Vector3[] fourCornersArray) { }

	// RVA: 0x1E77830 Offset: 0x1E73830 VA: 0x1E77830
	public void SetSizeWithCurrentAnchors(RectTransform.Axis axis, float size) { }

	[RequiredByNativeCode]
	// RVA: 0x1E77A10 Offset: 0x1E73A10 VA: 0x1E77A10
	internal static void SendReapplyDrivenProperties(RectTransform driven) { }

	// RVA: 0x1E7792C Offset: 0x1E7392C VA: 0x1E7792C
	private Vector2 GetParentSize() { }

	// RVA: 0x1E77A80 Offset: 0x1E73A80 VA: 0x1E77A80
	public void .ctor() { }

	// RVA: 0x1E76A30 Offset: 0x1E72A30 VA: 0x1E76A30
	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	// RVA: 0x1E76AF4 Offset: 0x1E72AF4 VA: 0x1E76AF4
	private static void get_anchorMin_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x1E76BB4 Offset: 0x1E72BB4 VA: 0x1E76BB4
	private static void set_anchorMin_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x1E76C78 Offset: 0x1E72C78 VA: 0x1E76C78
	private static void get_anchorMax_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x1E76D38 Offset: 0x1E72D38 VA: 0x1E76D38
	private static void set_anchorMax_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x1E76DFC Offset: 0x1E72DFC VA: 0x1E76DFC
	private static void get_anchoredPosition_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x1E76EBC Offset: 0x1E72EBC VA: 0x1E76EBC
	private static void set_anchoredPosition_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x1E76F80 Offset: 0x1E72F80 VA: 0x1E76F80
	private static void get_sizeDelta_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x1E77040 Offset: 0x1E73040 VA: 0x1E77040
	private static void set_sizeDelta_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x1E77104 Offset: 0x1E73104 VA: 0x1E77104
	private static void get_pivot_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x1E771C4 Offset: 0x1E731C4 VA: 0x1E771C4
	private static void set_pivot_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x1E77564 Offset: 0x1E73564 VA: 0x1E77564
	private static void set_sendChildDimensionsChange_Injected(IntPtr _unity_self, bool value) { }
}

// Namespace: 
private class Transform.Enumerator : IEnumerator // TypeDefIndex: 6881
{
	// Fields
	private Transform outer; // 0x10
	private int currentIndex; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x1E796AC Offset: 0x1E756AC VA: 0x1E796AC
	internal void .ctor(Transform outer) { }

	// RVA: 0x1E797C4 Offset: 0x1E757C4 VA: 0x1E797C4 Slot: 5
	public object get_Current() { }

	// RVA: 0x1E797E0 Offset: 0x1E757E0 VA: 0x1E797E0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1E79814 Offset: 0x1E75814 VA: 0x1E79814 Slot: 6
	public void Reset() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Configuration/UnityConfigure.h")]
[NativeHeader("Runtime/Transform/Transform.h")]
[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
public class Transform : Component, IEnumerable // TypeDefIndex: 6882
{
	// Properties
	public Vector3 position { get; set; }
	public Vector3 localPosition { get; set; }
	public Vector3 forward { get; }
	public Quaternion rotation { get; set; }
	public Quaternion localRotation { get; set; }
	public Vector3 localScale { get; set; }
	public Transform parent { get; set; }
	internal Transform parentInternal { get; set; }
	public Matrix4x4 worldToLocalMatrix { get; }
	public Matrix4x4 localToWorldMatrix { get; }
	public int childCount { get; }
	public Vector3 lossyScale { get; }
	[NativeProperty("HasChangedDeprecated")]
	public bool hasChanged { set; }

	// Methods

	// RVA: 0x1E77A84 Offset: 0x1E73A84 VA: 0x1E77A84
	protected void .ctor() { }

	// RVA: 0x1E77B4C Offset: 0x1E73B4C VA: 0x1E77B4C
	public Vector3 get_position() { }

	// RVA: 0x1E77C20 Offset: 0x1E73C20 VA: 0x1E77C20
	public void set_position(Vector3 value) { }

	// RVA: 0x1E77CEC Offset: 0x1E73CEC VA: 0x1E77CEC
	public Vector3 get_localPosition() { }

	// RVA: 0x1E77DC0 Offset: 0x1E73DC0 VA: 0x1E77DC0
	public void set_localPosition(Vector3 value) { }

	// RVA: 0x1E77E8C Offset: 0x1E73E8C VA: 0x1E77E8C
	public Vector3 get_forward() { }

	// RVA: 0x1E77F04 Offset: 0x1E73F04 VA: 0x1E77F04
	public Quaternion get_rotation() { }

	// RVA: 0x1E77FD4 Offset: 0x1E73FD4 VA: 0x1E77FD4
	public void set_rotation(Quaternion value) { }

	// RVA: 0x1E780A0 Offset: 0x1E740A0 VA: 0x1E780A0
	public Quaternion get_localRotation() { }

	// RVA: 0x1E78170 Offset: 0x1E74170 VA: 0x1E78170
	public void set_localRotation(Quaternion value) { }

	// RVA: 0x1E7823C Offset: 0x1E7423C VA: 0x1E7823C
	public Vector3 get_localScale() { }

	// RVA: 0x1E78310 Offset: 0x1E74310 VA: 0x1E78310
	public void set_localScale(Vector3 value) { }

	// RVA: 0x1E77A7C Offset: 0x1E73A7C VA: 0x1E77A7C
	public Transform get_parent() { }

	// RVA: 0x1E783E0 Offset: 0x1E743E0 VA: 0x1E783E0
	public void set_parent(Transform value) { }

	// RVA: 0x1E783DC Offset: 0x1E743DC VA: 0x1E783DC
	internal Transform get_parentInternal() { }

	// RVA: 0x1E7848C Offset: 0x1E7448C VA: 0x1E7848C
	internal void set_parentInternal(Transform value) { }

	// RVA: 0x1E78494 Offset: 0x1E74494 VA: 0x1E78494
	private Transform GetParent() { }

	// RVA: 0x1E78520 Offset: 0x1E74520 VA: 0x1E78520
	public void SetParent(Transform p) { }

	[FreeFunction("SetParent", HasExplicitThis = True)]
	// RVA: 0x1E78564 Offset: 0x1E74564 VA: 0x1E78564
	public void SetParent(Transform parent, bool worldPositionStays) { }

	// RVA: 0x1E7866C Offset: 0x1E7466C VA: 0x1E7866C
	public Matrix4x4 get_worldToLocalMatrix() { }

	// RVA: 0x1E77790 Offset: 0x1E73790 VA: 0x1E77790
	public Matrix4x4 get_localToWorldMatrix() { }

	// RVA: 0x1E78794 Offset: 0x1E74794 VA: 0x1E78794
	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	// RVA: 0x1E7887C Offset: 0x1E7487C VA: 0x1E7887C
	public void Translate(Vector3 translation, Space relativeTo) { }

	// RVA: 0x1E789A0 Offset: 0x1E749A0 VA: 0x1E789A0
	public void Translate(Vector3 translation) { }

	// RVA: 0x1E789A8 Offset: 0x1E749A8 VA: 0x1E789A8
	public void Rotate(Vector3 eulers, Space relativeTo) { }

	// RVA: 0x1E78C28 Offset: 0x1E74C28 VA: 0x1E78C28
	public void Rotate(float xAngle, float yAngle, float zAngle) { }

	// RVA: 0x1E78904 Offset: 0x1E74904 VA: 0x1E78904
	public Vector3 TransformDirection(Vector3 direction) { }

	// RVA: 0x1E78C84 Offset: 0x1E74C84 VA: 0x1E78C84
	public Vector3 TransformPoint(Vector3 position) { }

	// RVA: 0x1E78D74 Offset: 0x1E74D74 VA: 0x1E78D74
	public Vector3 InverseTransformPoint(Vector3 position) { }

	[NativeMethod("GetChildrenCount")]
	// RVA: 0x1E78E64 Offset: 0x1E74E64 VA: 0x1E78E64
	public int get_childCount() { }

	// RVA: 0x1E78F10 Offset: 0x1E74F10 VA: 0x1E78F10
	public void SetAsFirstSibling() { }

	// RVA: 0x1E78FBC Offset: 0x1E74FBC VA: 0x1E78FBC
	public void SetAsLastSibling() { }

	// RVA: 0x1E79068 Offset: 0x1E75068 VA: 0x1E79068
	public void SetSiblingIndex(int index) { }

	[FreeFunction(HasExplicitThis = True)]
	// RVA: 0x1E79124 Offset: 0x1E75124 VA: 0x1E79124
	private Transform FindRelativeTransformWithPath(string path, bool isActiveOnly) { }

	// RVA: 0x1E79370 Offset: 0x1E75370 VA: 0x1E79370
	public Transform Find(string n) { }

	[NativeMethod("GetWorldScaleLossy")]
	// RVA: 0x1E793C8 Offset: 0x1E753C8 VA: 0x1E793C8
	public Vector3 get_lossyScale() { }

	[FreeFunction("Internal_IsChildOrSameTransform", HasExplicitThis = True)]
	// RVA: 0x1E7949C Offset: 0x1E7549C VA: 0x1E7949C
	public bool IsChildOf(Transform parent) { }

	// RVA: 0x1E79580 Offset: 0x1E75580 VA: 0x1E79580
	public void set_hasChanged(bool value) { }

	// RVA: 0x1E7963C Offset: 0x1E7563C VA: 0x1E7963C Slot: 4
	public IEnumerator GetEnumerator() { }

	[FreeFunction("GetChild", HasExplicitThis = True)]
	[NativeThrows]
	// RVA: 0x1E796E4 Offset: 0x1E756E4 VA: 0x1E796E4
	public Transform GetChild(int index) { }

	// RVA: 0x1E77BDC Offset: 0x1E73BDC VA: 0x1E77BDC
	private static void get_position_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x1E77CA8 Offset: 0x1E73CA8 VA: 0x1E77CA8
	private static void set_position_Injected(IntPtr _unity_self, in Vector3 value) { }

	// RVA: 0x1E77D7C Offset: 0x1E73D7C VA: 0x1E77D7C
	private static void get_localPosition_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x1E77E48 Offset: 0x1E73E48 VA: 0x1E77E48
	private static void set_localPosition_Injected(IntPtr _unity_self, in Vector3 value) { }

	// RVA: 0x1E77F90 Offset: 0x1E73F90 VA: 0x1E77F90
	private static void get_rotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	// RVA: 0x1E7805C Offset: 0x1E7405C VA: 0x1E7805C
	private static void set_rotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	// RVA: 0x1E7812C Offset: 0x1E7412C VA: 0x1E7812C
	private static void get_localRotation_Injected(IntPtr _unity_self, out Quaternion ret) { }

	// RVA: 0x1E781F8 Offset: 0x1E741F8 VA: 0x1E781F8
	private static void set_localRotation_Injected(IntPtr _unity_self, in Quaternion value) { }

	// RVA: 0x1E782CC Offset: 0x1E742CC VA: 0x1E782CC
	private static void get_localScale_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x1E78398 Offset: 0x1E74398 VA: 0x1E78398
	private static void set_localScale_Injected(IntPtr _unity_self, in Vector3 value) { }

	// RVA: 0x1E78528 Offset: 0x1E74528 VA: 0x1E78528
	private static IntPtr GetParent_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E78618 Offset: 0x1E74618 VA: 0x1E78618
	private static void SetParent_Injected(IntPtr _unity_self, IntPtr parent, bool worldPositionStays) { }

	// RVA: 0x1E7870C Offset: 0x1E7470C VA: 0x1E7870C
	private static void get_worldToLocalMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	// RVA: 0x1E78750 Offset: 0x1E74750 VA: 0x1E78750
	private static void get_localToWorldMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	// RVA: 0x1E78828 Offset: 0x1E74828 VA: 0x1E78828
	private static void SetPositionAndRotation_Injected(IntPtr _unity_self, in Vector3 position, in Quaternion rotation) { }

	// RVA: 0x1E78C30 Offset: 0x1E74C30 VA: 0x1E78C30
	private static void TransformDirection_Injected(IntPtr _unity_self, in Vector3 direction, out Vector3 ret) { }

	// RVA: 0x1E78D20 Offset: 0x1E74D20 VA: 0x1E78D20
	private static void TransformPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	// RVA: 0x1E78E10 Offset: 0x1E74E10 VA: 0x1E78E10
	private static void InverseTransformPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	// RVA: 0x1E78ED4 Offset: 0x1E74ED4 VA: 0x1E78ED4
	private static int get_childCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E78F80 Offset: 0x1E74F80 VA: 0x1E78F80
	private static void SetAsFirstSibling_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E7902C Offset: 0x1E7502C VA: 0x1E7902C
	private static void SetAsLastSibling_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E790E0 Offset: 0x1E750E0 VA: 0x1E790E0
	private static void SetSiblingIndex_Injected(IntPtr _unity_self, int index) { }

	// RVA: 0x1E7931C Offset: 0x1E7531C VA: 0x1E7931C
	private static IntPtr FindRelativeTransformWithPath_Injected(IntPtr _unity_self, ref ManagedSpanWrapper path, bool isActiveOnly) { }

	// RVA: 0x1E79458 Offset: 0x1E75458 VA: 0x1E79458
	private static void get_lossyScale_Injected(IntPtr _unity_self, out Vector3 ret) { }

	// RVA: 0x1E7953C Offset: 0x1E7553C VA: 0x1E7953C
	private static bool IsChildOf_Injected(IntPtr _unity_self, IntPtr parent) { }

	// RVA: 0x1E795F8 Offset: 0x1E755F8 VA: 0x1E795F8
	private static void set_hasChanged_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1E79780 Offset: 0x1E75780 VA: 0x1E79780
	private static IntPtr GetChild_Injected(IntPtr _unity_self, int index) { }
}

// Namespace: UnityEngine
[NativeType(1, "ScriptingJvalue")]
public struct jvalue // TypeDefIndex: 7601
{
	// Fields
	public bool z; // 0x0
	public sbyte b; // 0x0
	public char c; // 0x0
	public short s; // 0x0
	public int i; // 0x0
	public long j; // 0x0
	public float f; // 0x0
	public double d; // 0x0
	public IntPtr l; // 0x0
}

// Namespace: UnityEngine
[NativeType(1, "ScriptingJNINativeMethod")]
public struct JNINativeMethod // TypeDefIndex: 7602
{
	// Fields
	public string name; // 0x0
	public string signature; // 0x8
	public IntPtr fnPtr; // 0x10
}

// Namespace: UnityEngine
[NativeConditional("PLATFORM_ANDROID")]
[StaticAccessor("AndroidJNIBindingsHelpers", 2)]
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[UsedByNativeCode]
public static class AndroidJNIHelper // TypeDefIndex: 7603
{
	// Properties
	public static bool debug { get; set; }

	// Methods

	// RVA: 0x1E2FC30 Offset: 0x1E2BC30 VA: 0x1E2FC30
	public static bool get_debug() { }

	// RVA: 0x1E2FC58 Offset: 0x1E2BC58 VA: 0x1E2FC58
	public static void set_debug(bool value) { }

	// RVA: 0x1E2FC94 Offset: 0x1E2BC94 VA: 0x1E2FC94
	public static IntPtr GetConstructorID(IntPtr javaClass) { }

	// RVA: 0x1E2FCDC Offset: 0x1E2BCDC VA: 0x1E2FCDC
	public static IntPtr GetConstructorID(IntPtr javaClass, string signature) { }

	// RVA: 0x1E2FF2C Offset: 0x1E2BF2C VA: 0x1E2FF2C
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName) { }

	// RVA: 0x1E30004 Offset: 0x1E2C004 VA: 0x1E30004
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature) { }

	// RVA: 0x1E2FF88 Offset: 0x1E2BF88 VA: 0x1E2FF88
	public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x1E30224 Offset: 0x1E2C224 VA: 0x1E30224
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName) { }

	// RVA: 0x1E302FC Offset: 0x1E2C2FC VA: 0x1E302FC
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature) { }

	// RVA: 0x1E30280 Offset: 0x1E2C280 VA: 0x1E30280
	public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x1E305AC Offset: 0x1E2C5AC VA: 0x1E305AC
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	// RVA: 0x1E30658 Offset: 0x1E2C658 VA: 0x1E30658
	public static IntPtr CreateJavaProxy(AndroidJavaProxy proxy) { }

	// RVA: 0x1E30850 Offset: 0x1E2C850 VA: 0x1E30850
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: 0x1E31558 Offset: 0x1E2D558 VA: 0x1E31558
	public static jvalue[] CreateJNIArgArray(object[] args) { }

	// RVA: 0x1E31B20 Offset: 0x1E2DB20 VA: 0x1E31B20
	public static void CreateJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x1E31C4C Offset: 0x1E2DC4C VA: 0x1E31C4C
	public static void DeleteJNIArgArray(object[] args, jvalue[] jniArgs) { }

	// RVA: 0x1E31E48 Offset: 0x1E2DE48 VA: 0x1E31E48
	public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x1E31EB4 Offset: 0x1E2DEB4 VA: 0x1E31EB4
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x1E31F84 Offset: 0x1E2DF84 VA: 0x1E31F84
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: 0x1E32084 Offset: 0x1E2E084 VA: 0x1E32084
	public static string GetSignature(object obj) { }

	// RVA: 0x1E32DE8 Offset: 0x1E2EDE8 VA: 0x1E32DE8
	public static string GetSignature(object[] args) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100B0A0 Offset: 0x10070A0 VA: 0x100B0A0
	|-AndroidJNIHelper.ConvertFromJNIArray<bool>
	|
	|-RVA: 0x100B104 Offset: 0x1007104 VA: 0x100B104
	|-AndroidJNIHelper.ConvertFromJNIArray<char>
	|
	|-RVA: 0x100B168 Offset: 0x1007168 VA: 0x100B168
	|-AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x100B1CC Offset: 0x10071CC VA: 0x100B1CC
	|-AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x100B230 Offset: 0x1007230 VA: 0x100B230
	|-AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x100B294 Offset: 0x1007294 VA: 0x100B294
	|-AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x100B2F8 Offset: 0x10072F8 VA: 0x100B2F8
	|-AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x100B35C Offset: 0x100735C VA: 0x100B35C
	|-AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x100B3C0 Offset: 0x10073C0 VA: 0x100B3C0
	|-AndroidJNIHelper.ConvertFromJNIArray<float>
	|
	|-RVA: 0x100B424 Offset: 0x1007424 VA: 0x100B424
	|-AndroidJNIHelper.ConvertFromJNIArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100B614 Offset: 0x1007614 VA: 0x100B614
	|-AndroidJNIHelper.GetMethodID<bool>
	|
	|-RVA: 0x100B698 Offset: 0x1007698 VA: 0x100B698
	|-AndroidJNIHelper.GetMethodID<char>
	|
	|-RVA: 0x100B71C Offset: 0x100771C VA: 0x100B71C
	|-AndroidJNIHelper.GetMethodID<double>
	|
	|-RVA: 0x100B7A0 Offset: 0x10077A0 VA: 0x100B7A0
	|-AndroidJNIHelper.GetMethodID<short>
	|
	|-RVA: 0x100B824 Offset: 0x1007824 VA: 0x100B824
	|-AndroidJNIHelper.GetMethodID<int>
	|
	|-RVA: 0x100B8A8 Offset: 0x10078A8 VA: 0x100B8A8
	|-AndroidJNIHelper.GetMethodID<long>
	|
	|-RVA: 0x100B92C Offset: 0x100792C VA: 0x100B92C
	|-AndroidJNIHelper.GetMethodID<object>
	|
	|-RVA: 0x100B9B0 Offset: 0x10079B0 VA: 0x100B9B0
	|-AndroidJNIHelper.GetMethodID<sbyte>
	|
	|-RVA: 0x100BA34 Offset: 0x1007A34 VA: 0x100BA34
	|-AndroidJNIHelper.GetMethodID<float>
	|
	|-RVA: 0x100BAB8 Offset: 0x1007AB8 VA: 0x100BAB8
	|-AndroidJNIHelper.GetMethodID<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100B518 Offset: 0x1007518 VA: 0x100B518
	|-AndroidJNIHelper.GetFieldID<object>
	|
	|-RVA: 0x100B594 Offset: 0x1007594 VA: 0x100B594
	|-AndroidJNIHelper.GetFieldID<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100BB40 Offset: 0x1007B40 VA: 0x100BB40
	|-AndroidJNIHelper.GetSignature<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E32F94 Offset: 0x1E2EF94 VA: 0x1E32F94
	private static IntPtr Box(jvalue val, string boxedClass, string signature) { }

	// RVA: 0x1E33214 Offset: 0x1E2F214 VA: 0x1E33214
	public static IntPtr Box(sbyte value) { }

	// RVA: 0x1E3327C Offset: 0x1E2F27C VA: 0x1E3327C
	public static IntPtr Box(short value) { }

	// RVA: 0x1E332E4 Offset: 0x1E2F2E4 VA: 0x1E332E4
	public static IntPtr Box(int value) { }

	// RVA: 0x1E3334C Offset: 0x1E2F34C VA: 0x1E3334C
	public static IntPtr Box(long value) { }

	// RVA: 0x1E333B4 Offset: 0x1E2F3B4 VA: 0x1E333B4
	public static IntPtr Box(float value) { }

	// RVA: 0x1E3341C Offset: 0x1E2F41C VA: 0x1E3341C
	public static IntPtr Box(double value) { }

	// RVA: 0x1E33484 Offset: 0x1E2F484 VA: 0x1E33484
	public static IntPtr Box(char value) { }

	// RVA: 0x1E334EC Offset: 0x1E2F4EC VA: 0x1E334EC
	public static IntPtr Box(bool value) { }

	// RVA: 0x1E33554 Offset: 0x1E2F554 VA: 0x1E33554
	private static IntPtr GetUnboxMethod(IntPtr obj, string methodName, string signature) { }

	// RVA: 0x1E33738 Offset: 0x1E2F738 VA: 0x1E33738
	public static void Unbox(IntPtr obj, out sbyte value) { }

	// RVA: 0x1E33830 Offset: 0x1E2F830 VA: 0x1E33830
	public static void Unbox(IntPtr obj, out short value) { }

	// RVA: 0x1E33928 Offset: 0x1E2F928 VA: 0x1E33928
	public static void Unbox(IntPtr obj, out int value) { }

	// RVA: 0x1E33A20 Offset: 0x1E2FA20 VA: 0x1E33A20
	public static void Unbox(IntPtr obj, out long value) { }

	// RVA: 0x1E33B18 Offset: 0x1E2FB18 VA: 0x1E33B18
	public static void Unbox(IntPtr obj, out float value) { }

	// RVA: 0x1E33C1C Offset: 0x1E2FC1C VA: 0x1E33C1C
	public static void Unbox(IntPtr obj, out double value) { }

	// RVA: 0x1E33D20 Offset: 0x1E2FD20 VA: 0x1E33D20
	public static void Unbox(IntPtr obj, out char value) { }

	// RVA: 0x1E33E18 Offset: 0x1E2FE18 VA: 0x1E33E18
	public static void Unbox(IntPtr obj, out bool value) { }
}

// Namespace: 
private struct AndroidJNI.JStringBinding : IDisposable // TypeDefIndex: 7604
{
	// Fields
	private IntPtr javaString; // 0x0
	private IntPtr chars; // 0x8
	private int length; // 0x10
	private bool ownsRef; // 0x14

	// Methods

	// RVA: 0x1E35CF4 Offset: 0x1E31CF4 VA: 0x1E35CF4 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E3AE38 Offset: 0x1E36E38 VA: 0x1E3AE38 Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/AndroidJNI/Public/AndroidJNIBindingsHelpers.h")]
[StaticAccessor("AndroidJNIBindingsHelpers", 2)]
[NativeConditional("PLATFORM_ANDROID")]
public static class AndroidJNI // TypeDefIndex: 7605
{
	// Methods

	[ThreadSafe]
	// RVA: 0x1E33F14 Offset: 0x1E2FF14 VA: 0x1E33F14
	private static void ReleaseStringChars(AndroidJNI.JStringBinding str) { }

	[StaticAccessor("jni", 2)]
	[ThreadSafe]
	// RVA: 0x1E33F8C Offset: 0x1E2FF8C VA: 0x1E33F8C
	public static IntPtr GetJavaVM() { }

	[ThreadSafe]
	// RVA: 0x1E33FB4 Offset: 0x1E2FFB4 VA: 0x1E33FB4
	public static int AttachCurrentThread() { }

	[ThreadSafe]
	// RVA: 0x1E33FDC Offset: 0x1E2FFDC VA: 0x1E33FDC
	public static int DetachCurrentThread() { }

	[RequiredByNativeCode]
	// RVA: 0x1E34004 Offset: 0x1E30004 VA: 0x1E34004
	private static void InvokeAction(Action action) { }

	[ThreadSafe]
	// RVA: 0x1E34024 Offset: 0x1E30024 VA: 0x1E34024
	public static void InvokeAttached(Action action) { }

	[ThreadSafe]
	// RVA: 0x1E34060 Offset: 0x1E30060 VA: 0x1E34060
	public static int GetVersion() { }

	[ThreadSafe]
	// RVA: 0x1E34088 Offset: 0x1E30088 VA: 0x1E34088
	public static IntPtr FindClass(string name) { }

	[ThreadSafe]
	// RVA: 0x1E34234 Offset: 0x1E30234 VA: 0x1E34234
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	[ThreadSafe]
	// RVA: 0x1E34270 Offset: 0x1E30270 VA: 0x1E34270
	public static IntPtr FromReflectedField(IntPtr refField) { }

	[ThreadSafe]
	// RVA: 0x1E342AC Offset: 0x1E302AC VA: 0x1E342AC
	public static IntPtr ToReflectedMethod(IntPtr clazz, IntPtr methodID, bool isStatic) { }

	[ThreadSafe]
	// RVA: 0x1E34300 Offset: 0x1E30300 VA: 0x1E34300
	public static IntPtr ToReflectedField(IntPtr clazz, IntPtr fieldID, bool isStatic) { }

	[ThreadSafe]
	// RVA: 0x1E34354 Offset: 0x1E30354 VA: 0x1E34354
	public static IntPtr GetSuperclass(IntPtr clazz) { }

	[ThreadSafe]
	// RVA: 0x1E34390 Offset: 0x1E30390 VA: 0x1E34390
	public static bool IsAssignableFrom(IntPtr clazz1, IntPtr clazz2) { }

	[ThreadSafe]
	// RVA: 0x1E343D4 Offset: 0x1E303D4 VA: 0x1E343D4
	public static int Throw(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x1E34410 Offset: 0x1E30410 VA: 0x1E34410
	public static int ThrowNew(IntPtr clazz, string message) { }

	[ThreadSafe]
	// RVA: 0x1E345CC Offset: 0x1E305CC VA: 0x1E345CC
	public static IntPtr ExceptionOccurred() { }

	[ThreadSafe]
	// RVA: 0x1E345F4 Offset: 0x1E305F4 VA: 0x1E345F4
	public static void ExceptionDescribe() { }

	[ThreadSafe]
	// RVA: 0x1E3461C Offset: 0x1E3061C VA: 0x1E3461C
	public static void ExceptionClear() { }

	[ThreadSafe]
	// RVA: 0x1E34644 Offset: 0x1E30644 VA: 0x1E34644
	public static void FatalError(string message) { }

	[ThreadSafe]
	// RVA: 0x1E347E8 Offset: 0x1E307E8 VA: 0x1E347E8
	public static int PushLocalFrame(int capacity) { }

	[ThreadSafe]
	// RVA: 0x1E34824 Offset: 0x1E30824 VA: 0x1E34824
	public static IntPtr PopLocalFrame(IntPtr ptr) { }

	[ThreadSafe]
	// RVA: 0x1E34860 Offset: 0x1E30860 VA: 0x1E34860
	public static IntPtr NewGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x1E3489C Offset: 0x1E3089C VA: 0x1E3489C
	public static void DeleteGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x1E348D8 Offset: 0x1E308D8 VA: 0x1E348D8
	internal static void QueueDeleteGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x1E34914 Offset: 0x1E30914 VA: 0x1E34914
	internal static uint GetQueueGlobalRefsCount() { }

	[ThreadSafe]
	// RVA: 0x1E3493C Offset: 0x1E3093C VA: 0x1E3493C
	internal static void CleanQueueGlobalRefs() { }

	[ThreadSafe]
	// RVA: 0x1E34964 Offset: 0x1E30964 VA: 0x1E34964
	public static IntPtr NewWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x1E349A0 Offset: 0x1E309A0 VA: 0x1E349A0
	public static void DeleteWeakGlobalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x1E349DC Offset: 0x1E309DC VA: 0x1E349DC
	public static IntPtr NewLocalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x1E34A18 Offset: 0x1E30A18 VA: 0x1E34A18
	public static void DeleteLocalRef(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x1E34A54 Offset: 0x1E30A54 VA: 0x1E34A54
	public static bool IsSameObject(IntPtr obj1, IntPtr obj2) { }

	[ThreadSafe]
	// RVA: 0x1E34A98 Offset: 0x1E30A98 VA: 0x1E34A98
	public static int EnsureLocalCapacity(int capacity) { }

	[ThreadSafe]
	// RVA: 0x1E34AD4 Offset: 0x1E30AD4 VA: 0x1E34AD4
	public static IntPtr AllocObject(IntPtr clazz) { }

	// RVA: 0x1E34B10 Offset: 0x1E30B10 VA: 0x1E34B10
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E34B78 Offset: 0x1E30B78 VA: 0x1E34B78
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E34C10 Offset: 0x1E30C10 VA: 0x1E34C10
	public static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x1E34C64 Offset: 0x1E30C64 VA: 0x1E34C64
	public static IntPtr GetObjectClass(IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x1E34CA0 Offset: 0x1E30CA0 VA: 0x1E34CA0
	public static bool IsInstanceOf(IntPtr obj, IntPtr clazz) { }

	[ThreadSafe]
	// RVA: 0x1E34CE4 Offset: 0x1E30CE4 VA: 0x1E34CE4
	public static IntPtr GetMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	// RVA: 0x1E34F80 Offset: 0x1E30F80 VA: 0x1E34F80
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	// RVA: 0x1E3521C Offset: 0x1E3121C VA: 0x1E3521C
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	[ThreadSafe]
	// RVA: 0x1E354B8 Offset: 0x1E314B8 VA: 0x1E354B8
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1E35754 Offset: 0x1E31754 VA: 0x1E35754
	public static IntPtr NewString(string chars) { }

	[ThreadSafe]
	// RVA: 0x1E35758 Offset: 0x1E31758 VA: 0x1E35758
	private static IntPtr NewStringFromStr(string chars) { }

	[ThreadSafe]
	// RVA: 0x1E35904 Offset: 0x1E31904 VA: 0x1E35904
	public static IntPtr NewString(char[] chars) { }

	[ThreadSafe]
	// RVA: 0x1E35A0C Offset: 0x1E31A0C VA: 0x1E35A0C
	public static IntPtr NewStringUTF(string bytes) { }

	// RVA: 0x1E35BB8 Offset: 0x1E31BB8 VA: 0x1E35BB8
	public static string GetStringChars(IntPtr str) { }

	[ThreadSafe]
	// RVA: 0x1E35C8C Offset: 0x1E31C8C VA: 0x1E35C8C
	private static AndroidJNI.JStringBinding GetStringCharsInternal(IntPtr str) { }

	[ThreadSafe]
	// RVA: 0x1E35D90 Offset: 0x1E31D90 VA: 0x1E35D90
	public static int GetStringLength(IntPtr str) { }

	[ThreadSafe]
	// RVA: 0x1E35DCC Offset: 0x1E31DCC VA: 0x1E35DCC
	public static int GetStringUTFLength(IntPtr str) { }

	[ThreadSafe]
	// RVA: 0x1E35E08 Offset: 0x1E31E08 VA: 0x1E35E08
	public static string GetStringUTFChars(IntPtr str) { }

	// RVA: 0x1E35F18 Offset: 0x1E31F18 VA: 0x1E35F18
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E35F80 Offset: 0x1E31F80 VA: 0x1E35F80
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E35FF4 Offset: 0x1E31FF4 VA: 0x1E35FF4
	public static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x1E360E0 Offset: 0x1E320E0 VA: 0x1E360E0
	private static AndroidJNI.JStringBinding CallStringMethodUnsafeInternal(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E361BC Offset: 0x1E321BC VA: 0x1E361BC
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E36224 Offset: 0x1E32224 VA: 0x1E36224
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E362BC Offset: 0x1E322BC VA: 0x1E362BC
	public static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E36310 Offset: 0x1E32310 VA: 0x1E36310
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E36378 Offset: 0x1E32378 VA: 0x1E36378
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E36410 Offset: 0x1E32410 VA: 0x1E36410
	public static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E36464 Offset: 0x1E32464 VA: 0x1E36464
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E364CC Offset: 0x1E324CC VA: 0x1E364CC
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E36568 Offset: 0x1E32568 VA: 0x1E36568
	public static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E365BC Offset: 0x1E325BC VA: 0x1E365BC
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E36624 Offset: 0x1E32624 VA: 0x1E36624
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E366BC Offset: 0x1E326BC VA: 0x1E366BC
	public static short CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	[Obsolete("AndroidJNI.CallByteMethod is obsolete. Use AndroidJNI.CallSByteMethod method instead")]
	// RVA: 0x1E36710 Offset: 0x1E32710 VA: 0x1E36710
	public static byte CallByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E36714 Offset: 0x1E32714 VA: 0x1E36714
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E3677C Offset: 0x1E3277C VA: 0x1E3677C
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E36814 Offset: 0x1E32814 VA: 0x1E36814
	public static sbyte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E36868 Offset: 0x1E32868 VA: 0x1E36868
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E368D0 Offset: 0x1E328D0 VA: 0x1E368D0
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E36968 Offset: 0x1E32968 VA: 0x1E36968
	public static char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E369BC Offset: 0x1E329BC VA: 0x1E369BC
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E36A24 Offset: 0x1E32A24 VA: 0x1E36A24
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E36ABC Offset: 0x1E32ABC VA: 0x1E36ABC
	public static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E36B10 Offset: 0x1E32B10 VA: 0x1E36B10
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E36B78 Offset: 0x1E32B78 VA: 0x1E36B78
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E36C10 Offset: 0x1E32C10 VA: 0x1E36C10
	public static double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E36C64 Offset: 0x1E32C64 VA: 0x1E36C64
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E36CCC Offset: 0x1E32CCC VA: 0x1E36CCC
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E36D64 Offset: 0x1E32D64 VA: 0x1E36D64
	public static long CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E36DB8 Offset: 0x1E32DB8 VA: 0x1E36DB8
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E36E20 Offset: 0x1E32E20 VA: 0x1E36E20
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E36EB8 Offset: 0x1E32EB8 VA: 0x1E36EB8
	public static void CallVoidMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E36F0C Offset: 0x1E32F0C VA: 0x1E36F0C
	public static string GetStringField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E36FE8 Offset: 0x1E32FE8 VA: 0x1E36FE8
	private static AndroidJNI.JStringBinding GetStringFieldInternal(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E370AC Offset: 0x1E330AC VA: 0x1E370AC
	public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E370F0 Offset: 0x1E330F0 VA: 0x1E370F0
	public static bool GetBooleanField(IntPtr obj, IntPtr fieldID) { }

	[Obsolete("AndroidJNI.GetByteField is obsolete. Use AndroidJNI.GetSByteField method instead")]
	// RVA: 0x1E37134 Offset: 0x1E33134 VA: 0x1E37134
	public static byte GetByteField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E37178 Offset: 0x1E33178 VA: 0x1E37178
	public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E371BC Offset: 0x1E331BC VA: 0x1E371BC
	public static char GetCharField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E37200 Offset: 0x1E33200 VA: 0x1E37200
	public static short GetShortField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E37244 Offset: 0x1E33244 VA: 0x1E37244
	public static int GetIntField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E37288 Offset: 0x1E33288 VA: 0x1E37288
	public static long GetLongField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E372CC Offset: 0x1E332CC VA: 0x1E372CC
	public static float GetFloatField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E37310 Offset: 0x1E33310 VA: 0x1E37310
	public static double GetDoubleField(IntPtr obj, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E37354 Offset: 0x1E33354 VA: 0x1E37354
	public static void SetStringField(IntPtr obj, IntPtr fieldID, string val) { }

	[ThreadSafe]
	// RVA: 0x1E37528 Offset: 0x1E33528 VA: 0x1E37528
	public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val) { }

	[ThreadSafe]
	// RVA: 0x1E3757C Offset: 0x1E3357C VA: 0x1E3757C
	public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val) { }

	[Obsolete("AndroidJNI.SetByteField is obsolete. Use AndroidJNI.SetSByteField method instead")]
	// RVA: 0x1E375D0 Offset: 0x1E335D0 VA: 0x1E375D0
	public static void SetByteField(IntPtr obj, IntPtr fieldID, byte val) { }

	[ThreadSafe]
	// RVA: 0x1E37624 Offset: 0x1E33624 VA: 0x1E37624
	public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val) { }

	[ThreadSafe]
	// RVA: 0x1E37678 Offset: 0x1E33678 VA: 0x1E37678
	public static void SetCharField(IntPtr obj, IntPtr fieldID, char val) { }

	[ThreadSafe]
	// RVA: 0x1E376CC Offset: 0x1E336CC VA: 0x1E376CC
	public static void SetShortField(IntPtr obj, IntPtr fieldID, short val) { }

	[ThreadSafe]
	// RVA: 0x1E37720 Offset: 0x1E33720 VA: 0x1E37720
	public static void SetIntField(IntPtr obj, IntPtr fieldID, int val) { }

	[ThreadSafe]
	// RVA: 0x1E37774 Offset: 0x1E33774 VA: 0x1E37774
	public static void SetLongField(IntPtr obj, IntPtr fieldID, long val) { }

	[ThreadSafe]
	// RVA: 0x1E377C8 Offset: 0x1E337C8 VA: 0x1E377C8
	public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val) { }

	[ThreadSafe]
	// RVA: 0x1E3781C Offset: 0x1E3381C VA: 0x1E3781C
	public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val) { }

	// RVA: 0x1E37870 Offset: 0x1E33870 VA: 0x1E37870
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E378D8 Offset: 0x1E338D8 VA: 0x1E378D8
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3794C Offset: 0x1E3394C VA: 0x1E3794C
	public static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[ThreadSafe]
	// RVA: 0x1E37A38 Offset: 0x1E33A38 VA: 0x1E37A38
	private static AndroidJNI.JStringBinding CallStaticStringMethodUnsafeInternal(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E37B14 Offset: 0x1E33B14 VA: 0x1E37B14
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E37B7C Offset: 0x1E33B7C VA: 0x1E37B7C
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E37C14 Offset: 0x1E33C14 VA: 0x1E37C14
	public static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E37C68 Offset: 0x1E33C68 VA: 0x1E37C68
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E37CD0 Offset: 0x1E33CD0 VA: 0x1E37CD0
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E37D68 Offset: 0x1E33D68 VA: 0x1E37D68
	public static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E37DBC Offset: 0x1E33DBC VA: 0x1E37DBC
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E37E24 Offset: 0x1E33E24 VA: 0x1E37E24
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E37EC0 Offset: 0x1E33EC0 VA: 0x1E37EC0
	public static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E37F14 Offset: 0x1E33F14 VA: 0x1E37F14
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E37F7C Offset: 0x1E33F7C VA: 0x1E37F7C
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E38014 Offset: 0x1E34014 VA: 0x1E38014
	public static short CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	[Obsolete("AndroidJNI.CallStaticByteMethod is obsolete. Use AndroidJNI.CallStaticSByteMethod method instead")]
	// RVA: 0x1E38068 Offset: 0x1E34068 VA: 0x1E38068
	public static byte CallStaticByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E3806C Offset: 0x1E3406C VA: 0x1E3806C
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E380D4 Offset: 0x1E340D4 VA: 0x1E380D4
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E3816C Offset: 0x1E3416C VA: 0x1E3816C
	public static sbyte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E381C0 Offset: 0x1E341C0 VA: 0x1E381C0
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E38228 Offset: 0x1E34228 VA: 0x1E38228
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E382C0 Offset: 0x1E342C0 VA: 0x1E382C0
	public static char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E38314 Offset: 0x1E34314 VA: 0x1E38314
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E3837C Offset: 0x1E3437C VA: 0x1E3837C
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E38414 Offset: 0x1E34414 VA: 0x1E38414
	public static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E38468 Offset: 0x1E34468 VA: 0x1E38468
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E384D0 Offset: 0x1E344D0 VA: 0x1E384D0
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E38568 Offset: 0x1E34568 VA: 0x1E38568
	public static double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E385BC Offset: 0x1E345BC VA: 0x1E385BC
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E38624 Offset: 0x1E34624 VA: 0x1E38624
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E386BC Offset: 0x1E346BC VA: 0x1E386BC
	public static long CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E38710 Offset: 0x1E34710 VA: 0x1E38710
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E38778 Offset: 0x1E34778 VA: 0x1E38778
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	[ThreadSafe]
	// RVA: 0x1E38810 Offset: 0x1E34810 VA: 0x1E38810
	public static void CallStaticVoidMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args) { }

	// RVA: 0x1E38864 Offset: 0x1E34864 VA: 0x1E38864
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E38940 Offset: 0x1E34940 VA: 0x1E38940
	private static AndroidJNI.JStringBinding GetStaticStringFieldInternal(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E38A04 Offset: 0x1E34A04 VA: 0x1E38A04
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E38A48 Offset: 0x1E34A48 VA: 0x1E38A48
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	[Obsolete("AndroidJNI.GetStaticByteField is obsolete. Use AndroidJNI.GetStaticSByteField method instead")]
	// RVA: 0x1E38A8C Offset: 0x1E34A8C VA: 0x1E38A8C
	public static byte GetStaticByteField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E38AD0 Offset: 0x1E34AD0 VA: 0x1E38AD0
	public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E38B14 Offset: 0x1E34B14 VA: 0x1E38B14
	public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E38B58 Offset: 0x1E34B58 VA: 0x1E38B58
	public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E38B9C Offset: 0x1E34B9C VA: 0x1E38B9C
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E38BE0 Offset: 0x1E34BE0 VA: 0x1E38BE0
	public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E38C24 Offset: 0x1E34C24 VA: 0x1E38C24
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E38C68 Offset: 0x1E34C68 VA: 0x1E38C68
	public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	[ThreadSafe]
	// RVA: 0x1E38CAC Offset: 0x1E34CAC VA: 0x1E38CAC
	public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val) { }

	[ThreadSafe]
	// RVA: 0x1E38E80 Offset: 0x1E34E80 VA: 0x1E38E80
	public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val) { }

	[ThreadSafe]
	// RVA: 0x1E38ED4 Offset: 0x1E34ED4 VA: 0x1E38ED4
	public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val) { }

	[Obsolete("AndroidJNI.SetStaticByteField is obsolete. Use AndroidJNI.SetStaticSByteField method instead")]
	// RVA: 0x1E38F28 Offset: 0x1E34F28 VA: 0x1E38F28
	public static void SetStaticByteField(IntPtr clazz, IntPtr fieldID, byte val) { }

	[ThreadSafe]
	// RVA: 0x1E38F7C Offset: 0x1E34F7C VA: 0x1E38F7C
	public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val) { }

	[ThreadSafe]
	// RVA: 0x1E38FD0 Offset: 0x1E34FD0 VA: 0x1E38FD0
	public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val) { }

	[ThreadSafe]
	// RVA: 0x1E39024 Offset: 0x1E35024 VA: 0x1E39024
	public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val) { }

	[ThreadSafe]
	// RVA: 0x1E39078 Offset: 0x1E35078 VA: 0x1E39078
	public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val) { }

	[ThreadSafe]
	// RVA: 0x1E390CC Offset: 0x1E350CC VA: 0x1E390CC
	public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val) { }

	[ThreadSafe]
	// RVA: 0x1E39120 Offset: 0x1E35120 VA: 0x1E39120
	public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val) { }

	[ThreadSafe]
	// RVA: 0x1E39174 Offset: 0x1E35174 VA: 0x1E39174
	public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val) { }

	[ThreadSafe]
	// RVA: 0x1E391C8 Offset: 0x1E351C8 VA: 0x1E391C8
	private static IntPtr ConvertToBooleanArray(bool[] array) { }

	// RVA: 0x1E392D0 Offset: 0x1E352D0 VA: 0x1E392D0
	public static IntPtr ToBooleanArray(bool[] array) { }

	[Obsolete("AndroidJNI.ToByteArray is obsolete. Use AndroidJNI.ToSByteArray method instead")]
	[ThreadSafe]
	// RVA: 0x1E392DC Offset: 0x1E352DC VA: 0x1E392DC
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x1E393E4 Offset: 0x1E353E4 VA: 0x1E393E4
	public static IntPtr ToSByteArray(sbyte[] array) { }

	[ThreadSafe]
	// RVA: 0x1E39438 Offset: 0x1E35438 VA: 0x1E39438
	public static IntPtr ToSByteArray(sbyte* array, int length) { }

	// RVA: 0x1E3947C Offset: 0x1E3547C VA: 0x1E3947C
	public static IntPtr ToCharArray(char[] array) { }

	[ThreadSafe]
	// RVA: 0x1E394D0 Offset: 0x1E354D0 VA: 0x1E394D0
	public static IntPtr ToCharArray(char* array, int length) { }

	// RVA: 0x1E39514 Offset: 0x1E35514 VA: 0x1E39514
	public static IntPtr ToShortArray(short[] array) { }

	[ThreadSafe]
	// RVA: 0x1E39568 Offset: 0x1E35568 VA: 0x1E39568
	public static IntPtr ToShortArray(short* array, int length) { }

	// RVA: 0x1E395AC Offset: 0x1E355AC VA: 0x1E395AC
	public static IntPtr ToIntArray(int[] array) { }

	[ThreadSafe]
	// RVA: 0x1E39600 Offset: 0x1E35600 VA: 0x1E39600
	public static IntPtr ToIntArray(int* array, int length) { }

	// RVA: 0x1E39644 Offset: 0x1E35644 VA: 0x1E39644
	public static IntPtr ToLongArray(long[] array) { }

	[ThreadSafe]
	// RVA: 0x1E39698 Offset: 0x1E35698 VA: 0x1E39698
	public static IntPtr ToLongArray(long* array, int length) { }

	// RVA: 0x1E396DC Offset: 0x1E356DC VA: 0x1E396DC
	public static IntPtr ToFloatArray(float[] array) { }

	[ThreadSafe]
	// RVA: 0x1E39730 Offset: 0x1E35730 VA: 0x1E39730
	public static IntPtr ToFloatArray(float* array, int length) { }

	// RVA: 0x1E39774 Offset: 0x1E35774 VA: 0x1E39774
	public static IntPtr ToDoubleArray(double[] array) { }

	[ThreadSafe]
	// RVA: 0x1E397C8 Offset: 0x1E357C8 VA: 0x1E397C8
	public static IntPtr ToDoubleArray(double* array, int length) { }

	[ThreadSafe]
	// RVA: 0x1E3980C Offset: 0x1E3580C VA: 0x1E3980C
	public static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass) { }

	// RVA: 0x1E39860 Offset: 0x1E35860 VA: 0x1E39860
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr arrayClass) { }

	// RVA: 0x1E398C4 Offset: 0x1E358C4 VA: 0x1E398C4
	public static IntPtr ToObjectArray(IntPtr[] array) { }

	[ThreadSafe]
	// RVA: 0x1E398CC Offset: 0x1E358CC VA: 0x1E398CC
	public static bool[] FromBooleanArray(IntPtr array) { }

	[Obsolete("AndroidJNI.FromByteArray is obsolete. Use AndroidJNI.FromSByteArray method instead")]
	[ThreadSafe]
	// RVA: 0x1E39A28 Offset: 0x1E35A28 VA: 0x1E39A28
	public static byte[] FromByteArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x1E39B84 Offset: 0x1E35B84 VA: 0x1E39B84
	public static sbyte[] FromSByteArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x1E39BC0 Offset: 0x1E35BC0 VA: 0x1E39BC0
	public static char[] FromCharArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x1E39BFC Offset: 0x1E35BFC VA: 0x1E39BFC
	public static short[] FromShortArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x1E39C38 Offset: 0x1E35C38 VA: 0x1E39C38
	public static int[] FromIntArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x1E39C74 Offset: 0x1E35C74 VA: 0x1E39C74
	public static long[] FromLongArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x1E39CB0 Offset: 0x1E35CB0 VA: 0x1E39CB0
	public static float[] FromFloatArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x1E39CEC Offset: 0x1E35CEC VA: 0x1E39CEC
	public static double[] FromDoubleArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x1E39D28 Offset: 0x1E35D28 VA: 0x1E39D28
	public static IntPtr[] FromObjectArray(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x1E39E84 Offset: 0x1E35E84 VA: 0x1E39E84
	public static int GetArrayLength(IntPtr array) { }

	[ThreadSafe]
	// RVA: 0x1E39EC0 Offset: 0x1E35EC0 VA: 0x1E39EC0
	public static IntPtr NewBooleanArray(int size) { }

	[Obsolete("AndroidJNI.NewByteArray is obsolete. Use AndroidJNI.NewSByteArray method instead")]
	// RVA: 0x1E39EFC Offset: 0x1E35EFC VA: 0x1E39EFC
	public static IntPtr NewByteArray(int size) { }

	[ThreadSafe]
	// RVA: 0x1E39F38 Offset: 0x1E35F38 VA: 0x1E39F38
	public static IntPtr NewSByteArray(int size) { }

	[ThreadSafe]
	// RVA: 0x1E39F74 Offset: 0x1E35F74 VA: 0x1E39F74
	public static IntPtr NewCharArray(int size) { }

	[ThreadSafe]
	// RVA: 0x1E39FB0 Offset: 0x1E35FB0 VA: 0x1E39FB0
	public static IntPtr NewShortArray(int size) { }

	[ThreadSafe]
	// RVA: 0x1E39FEC Offset: 0x1E35FEC VA: 0x1E39FEC
	public static IntPtr NewIntArray(int size) { }

	[ThreadSafe]
	// RVA: 0x1E3A028 Offset: 0x1E36028 VA: 0x1E3A028
	public static IntPtr NewLongArray(int size) { }

	[ThreadSafe]
	// RVA: 0x1E3A064 Offset: 0x1E36064 VA: 0x1E3A064
	public static IntPtr NewFloatArray(int size) { }

	[ThreadSafe]
	// RVA: 0x1E3A0A0 Offset: 0x1E360A0 VA: 0x1E3A0A0
	public static IntPtr NewDoubleArray(int size) { }

	[ThreadSafe]
	// RVA: 0x1E3A0DC Offset: 0x1E360DC VA: 0x1E3A0DC
	public static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x1E3A130 Offset: 0x1E36130 VA: 0x1E3A130
	public static bool GetBooleanArrayElement(IntPtr array, int index) { }

	[Obsolete("AndroidJNI.GetByteArrayElement is obsolete. Use AndroidJNI.GetSByteArrayElement method instead")]
	// RVA: 0x1E3A174 Offset: 0x1E36174 VA: 0x1E3A174
	public static byte GetByteArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x1E3A1B8 Offset: 0x1E361B8 VA: 0x1E3A1B8
	public static sbyte GetSByteArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x1E3A1FC Offset: 0x1E361FC VA: 0x1E3A1FC
	public static char GetCharArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x1E3A240 Offset: 0x1E36240 VA: 0x1E3A240
	public static short GetShortArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x1E3A284 Offset: 0x1E36284 VA: 0x1E3A284
	public static int GetIntArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x1E3A2C8 Offset: 0x1E362C8 VA: 0x1E3A2C8
	public static long GetLongArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x1E3A30C Offset: 0x1E3630C VA: 0x1E3A30C
	public static float GetFloatArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x1E3A350 Offset: 0x1E36350 VA: 0x1E3A350
	public static double GetDoubleArrayElement(IntPtr array, int index) { }

	[ThreadSafe]
	// RVA: 0x1E3A394 Offset: 0x1E36394 VA: 0x1E3A394
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	[Obsolete("AndroidJNI.SetBooleanArrayElement(IntPtr, int, byte) is obsolete. Use AndroidJNI.SetBooleanArrayElement(IntPtr, int, bool) method instead")]
	// RVA: 0x1E3A3D8 Offset: 0x1E363D8 VA: 0x1E3A3D8
	public static void SetBooleanArrayElement(IntPtr array, int index, byte val) { }

	[ThreadSafe]
	// RVA: 0x1E3A430 Offset: 0x1E36430 VA: 0x1E3A430
	public static void SetBooleanArrayElement(IntPtr array, int index, bool val) { }

	[Obsolete("AndroidJNI.SetByteArrayElement is obsolete. Use AndroidJNI.SetSByteArrayElement method instead")]
	// RVA: 0x1E3A484 Offset: 0x1E36484 VA: 0x1E3A484
	public static void SetByteArrayElement(IntPtr array, int index, sbyte val) { }

	[ThreadSafe]
	// RVA: 0x1E3A4D8 Offset: 0x1E364D8 VA: 0x1E3A4D8
	public static void SetSByteArrayElement(IntPtr array, int index, sbyte val) { }

	[ThreadSafe]
	// RVA: 0x1E3A52C Offset: 0x1E3652C VA: 0x1E3A52C
	public static void SetCharArrayElement(IntPtr array, int index, char val) { }

	[ThreadSafe]
	// RVA: 0x1E3A580 Offset: 0x1E36580 VA: 0x1E3A580
	public static void SetShortArrayElement(IntPtr array, int index, short val) { }

	[ThreadSafe]
	// RVA: 0x1E3A5D4 Offset: 0x1E365D4 VA: 0x1E3A5D4
	public static void SetIntArrayElement(IntPtr array, int index, int val) { }

	[ThreadSafe]
	// RVA: 0x1E3A628 Offset: 0x1E36628 VA: 0x1E3A628
	public static void SetLongArrayElement(IntPtr array, int index, long val) { }

	[ThreadSafe]
	// RVA: 0x1E3A67C Offset: 0x1E3667C VA: 0x1E3A67C
	public static void SetFloatArrayElement(IntPtr array, int index, float val) { }

	[ThreadSafe]
	// RVA: 0x1E3A6D0 Offset: 0x1E366D0 VA: 0x1E3A6D0
	public static void SetDoubleArrayElement(IntPtr array, int index, double val) { }

	[ThreadSafe]
	// RVA: 0x1E3A724 Offset: 0x1E36724 VA: 0x1E3A724
	public static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj) { }

	[ThreadSafe]
	// RVA: 0x1E3A778 Offset: 0x1E36778 VA: 0x1E3A778
	public static IntPtr NewDirectByteBuffer(byte* buffer, long capacity) { }

	// RVA: 0x1E3A7BC Offset: 0x1E367BC VA: 0x1E3A7BC
	public static IntPtr NewDirectByteBuffer(NativeArray<byte> buffer) { }

	// RVA: 0x1E3A814 Offset: 0x1E36814 VA: 0x1E3A814
	public static IntPtr NewDirectByteBuffer(NativeArray<sbyte> buffer) { }

	// RVA: -1 Offset: -1
	private static IntPtr NewDirectByteBufferFromNativeArray<T>(NativeArray<T> buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100AF1C Offset: 0x1006F1C VA: 0x100AF1C
	|-AndroidJNI.NewDirectByteBufferFromNativeArray<byte>
	|
	|-RVA: 0x100AF8C Offset: 0x1006F8C VA: 0x100AF8C
	|-AndroidJNI.NewDirectByteBufferFromNativeArray<sbyte>
	|
	|-RVA: 0x100AFFC Offset: 0x1006FFC VA: 0x100AFFC
	|-AndroidJNI.NewDirectByteBufferFromNativeArray<__Il2CppFullySharedGenericStructType>
	*/

	[ThreadSafe]
	// RVA: 0x1E3A86C Offset: 0x1E3686C VA: 0x1E3A86C
	public static sbyte* GetDirectBufferAddress(IntPtr buffer) { }

	[ThreadSafe]
	// RVA: 0x1E3A8A8 Offset: 0x1E368A8 VA: 0x1E3A8A8
	public static long GetDirectBufferCapacity(IntPtr buffer) { }

	// RVA: -1 Offset: -1
	private static NativeArray<T> GetDirectBuffer<T>(IntPtr buffer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100ABF4 Offset: 0x1006BF4 VA: 0x100ABF4
	|-AndroidJNI.GetDirectBuffer<byte>
	|
	|-RVA: 0x100AD00 Offset: 0x1006D00 VA: 0x100AD00
	|-AndroidJNI.GetDirectBuffer<sbyte>
	|
	|-RVA: 0x100AE0C Offset: 0x1006E0C VA: 0x100AE0C
	|-AndroidJNI.GetDirectBuffer<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x1E3A8E4 Offset: 0x1E368E4 VA: 0x1E3A8E4
	public static NativeArray<byte> GetDirectByteBuffer(IntPtr buffer) { }

	// RVA: 0x1E3A92C Offset: 0x1E3692C VA: 0x1E3A92C
	public static NativeArray<sbyte> GetDirectSByteBuffer(IntPtr buffer) { }

	// RVA: 0x1E3A974 Offset: 0x1E36974 VA: 0x1E3A974
	public static int RegisterNatives(IntPtr clazz, JNINativeMethod[] methods) { }

	[ThreadSafe]
	// RVA: 0x1E3AAA8 Offset: 0x1E36AA8 VA: 0x1E3AAA8
	private static IntPtr RegisterNativesAllocate(int length) { }

	[ThreadSafe]
	// RVA: 0x1E3AAE4 Offset: 0x1E36AE4 VA: 0x1E3AAE4
	private static void RegisterNativesSet(IntPtr natives, int idx, string name, string signature, IntPtr fnPtr) { }

	[ThreadSafe]
	// RVA: 0x1E3AD3C Offset: 0x1E36D3C VA: 0x1E3AD3C
	private static int RegisterNativesAndFree(IntPtr clazz, IntPtr natives, int n) { }

	[ThreadSafe]
	// RVA: 0x1E3ADFC Offset: 0x1E36DFC VA: 0x1E3ADFC
	public static int UnregisterNatives(IntPtr clazz) { }

	// RVA: 0x1E33F50 Offset: 0x1E2FF50 VA: 0x1E33F50
	private static void ReleaseStringChars_Injected(in AndroidJNI.JStringBinding str) { }

	// RVA: 0x1E341F8 Offset: 0x1E301F8 VA: 0x1E341F8
	private static IntPtr FindClass_Injected(ref ManagedSpanWrapper name) { }

	// RVA: 0x1E34588 Offset: 0x1E30588 VA: 0x1E34588
	private static int ThrowNew_Injected(IntPtr clazz, ref ManagedSpanWrapper message) { }

	// RVA: 0x1E347AC Offset: 0x1E307AC VA: 0x1E347AC
	private static void FatalError_Injected(ref ManagedSpanWrapper message) { }

	// RVA: 0x1E34F2C Offset: 0x1E30F2C VA: 0x1E34F2C
	private static IntPtr GetMethodID_Injected(IntPtr clazz, ref ManagedSpanWrapper name, ref ManagedSpanWrapper sig) { }

	// RVA: 0x1E351C8 Offset: 0x1E311C8 VA: 0x1E351C8
	private static IntPtr GetFieldID_Injected(IntPtr clazz, ref ManagedSpanWrapper name, ref ManagedSpanWrapper sig) { }

	// RVA: 0x1E35464 Offset: 0x1E31464 VA: 0x1E35464
	private static IntPtr GetStaticMethodID_Injected(IntPtr clazz, ref ManagedSpanWrapper name, ref ManagedSpanWrapper sig) { }

	// RVA: 0x1E35700 Offset: 0x1E31700 VA: 0x1E35700
	private static IntPtr GetStaticFieldID_Injected(IntPtr clazz, ref ManagedSpanWrapper name, ref ManagedSpanWrapper sig) { }

	// RVA: 0x1E358C8 Offset: 0x1E318C8 VA: 0x1E358C8
	private static IntPtr NewStringFromStr_Injected(ref ManagedSpanWrapper chars) { }

	// RVA: 0x1E359D0 Offset: 0x1E319D0 VA: 0x1E359D0
	private static IntPtr NewString_Injected(ref ManagedSpanWrapper chars) { }

	// RVA: 0x1E35B7C Offset: 0x1E31B7C VA: 0x1E35B7C
	private static IntPtr NewStringUTF_Injected(ref ManagedSpanWrapper bytes) { }

	// RVA: 0x1E35D4C Offset: 0x1E31D4C VA: 0x1E35D4C
	private static void GetStringCharsInternal_Injected(IntPtr str, out AndroidJNI.JStringBinding ret) { }

	// RVA: 0x1E35ED4 Offset: 0x1E31ED4 VA: 0x1E35ED4
	private static void GetStringUTFChars_Injected(IntPtr str, out ManagedSpanWrapper ret) { }

	// RVA: 0x1E36160 Offset: 0x1E32160 VA: 0x1E36160
	private static void CallStringMethodUnsafeInternal_Injected(IntPtr obj, IntPtr methodID, jvalue* args, out AndroidJNI.JStringBinding ret) { }

	// RVA: 0x1E37058 Offset: 0x1E33058 VA: 0x1E37058
	private static void GetStringFieldInternal_Injected(IntPtr obj, IntPtr fieldID, out AndroidJNI.JStringBinding ret) { }

	// RVA: 0x1E374D4 Offset: 0x1E334D4 VA: 0x1E374D4
	private static void SetStringField_Injected(IntPtr obj, IntPtr fieldID, ref ManagedSpanWrapper val) { }

	// RVA: 0x1E37AB8 Offset: 0x1E33AB8 VA: 0x1E37AB8
	private static void CallStaticStringMethodUnsafeInternal_Injected(IntPtr clazz, IntPtr methodID, jvalue* args, out AndroidJNI.JStringBinding ret) { }

	// RVA: 0x1E389B0 Offset: 0x1E349B0 VA: 0x1E389B0
	private static void GetStaticStringFieldInternal_Injected(IntPtr clazz, IntPtr fieldID, out AndroidJNI.JStringBinding ret) { }

	// RVA: 0x1E38E2C Offset: 0x1E34E2C VA: 0x1E38E2C
	private static void SetStaticStringField_Injected(IntPtr clazz, IntPtr fieldID, ref ManagedSpanWrapper val) { }

	// RVA: 0x1E39294 Offset: 0x1E35294 VA: 0x1E39294
	private static IntPtr ConvertToBooleanArray_Injected(ref ManagedSpanWrapper array) { }

	// RVA: 0x1E393A8 Offset: 0x1E353A8 VA: 0x1E393A8
	private static IntPtr ToByteArray_Injected(ref ManagedSpanWrapper array) { }

	// RVA: 0x1E399E4 Offset: 0x1E359E4 VA: 0x1E399E4
	private static void FromBooleanArray_Injected(IntPtr array, out BlittableArrayWrapper ret) { }

	// RVA: 0x1E39B40 Offset: 0x1E35B40 VA: 0x1E39B40
	private static void FromByteArray_Injected(IntPtr array, out BlittableArrayWrapper ret) { }

	// RVA: 0x1E39E40 Offset: 0x1E35E40 VA: 0x1E39E40
	private static void FromObjectArray_Injected(IntPtr array, out BlittableArrayWrapper ret) { }

	// RVA: 0x1E3AD90 Offset: 0x1E36D90 VA: 0x1E3AD90
	private static void RegisterNativesSet_Injected(IntPtr natives, int idx, ref ManagedSpanWrapper name, ref ManagedSpanWrapper signature, IntPtr fnPtr) { }
}

// Namespace: UnityEngine
internal class AndroidJNISafe // TypeDefIndex: 7606
{
	// Methods

	// RVA: 0x1E3AE90 Offset: 0x1E36E90 VA: 0x1E3AE90
	public static void CheckException() { }

	// RVA: 0x1E3B128 Offset: 0x1E37128 VA: 0x1E3B128
	public static void QueueDeleteGlobalRef(IntPtr globalref) { }

	// RVA: 0x1E3B16C Offset: 0x1E3716C VA: 0x1E3B16C
	public static void DeleteWeakGlobalRef(IntPtr globalref) { }

	// RVA: 0x1E3B1B0 Offset: 0x1E371B0 VA: 0x1E3B1B0
	public static void DeleteLocalRef(IntPtr localref) { }

	// RVA: 0x1E3B1F4 Offset: 0x1E371F4 VA: 0x1E3B1F4
	public static IntPtr NewString(string chars) { }

	// RVA: 0x1E3B264 Offset: 0x1E37264 VA: 0x1E3B264
	public static string GetStringChars(IntPtr str) { }

	// RVA: 0x1E33628 Offset: 0x1E2F628 VA: 0x1E33628
	public static IntPtr GetObjectClass(IntPtr ptr) { }

	// RVA: 0x1E33134 Offset: 0x1E2F134 VA: 0x1E33134
	public static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1E336C8 Offset: 0x1E2F6C8 VA: 0x1E336C8
	public static IntPtr GetMethodID(IntPtr obj, string name, string sig) { }

	// RVA: 0x1E3B2D4 Offset: 0x1E372D4 VA: 0x1E3B2D4
	public static IntPtr GetFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1E3B344 Offset: 0x1E37344 VA: 0x1E3B344
	public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig) { }

	// RVA: 0x1E3B3B4 Offset: 0x1E373B4 VA: 0x1E3B3B4
	public static IntPtr FromReflectedMethod(IntPtr refMethod) { }

	// RVA: 0x1E330C4 Offset: 0x1E2F0C4 VA: 0x1E330C4
	public static IntPtr FindClass(string name) { }

	// RVA: 0x1E3B454 Offset: 0x1E37454 VA: 0x1E3B454
	public static void PushLocalFrame(int capacity) { }

	// RVA: 0x1E3B4A4 Offset: 0x1E374A4 VA: 0x1E3B4A4
	public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3B514 Offset: 0x1E37514 VA: 0x1E3B514
	public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val) { }

	// RVA: 0x1E3B5D4 Offset: 0x1E375D4 VA: 0x1E3B5D4
	public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val) { }

	// RVA: 0x1E3B644 Offset: 0x1E37644 VA: 0x1E3B644
	public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val) { }

	// RVA: 0x1E3B704 Offset: 0x1E37704 VA: 0x1E3B704
	public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val) { }

	// RVA: 0x1E3B7C4 Offset: 0x1E377C4 VA: 0x1E3B7C4
	public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val) { }

	// RVA: 0x1E3B884 Offset: 0x1E37884 VA: 0x1E3B884
	public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val) { }

	// RVA: 0x1E3B944 Offset: 0x1E37944 VA: 0x1E3B944
	public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val) { }

	// RVA: 0x1E3BA04 Offset: 0x1E37A04 VA: 0x1E3BA04
	public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val) { }

	// RVA: 0x1E3BAC4 Offset: 0x1E37AC4 VA: 0x1E3BAC4
	public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val) { }

	// RVA: 0x1E3BB84 Offset: 0x1E37B84 VA: 0x1E3BB84
	public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val) { }

	// RVA: 0x1E3BC44 Offset: 0x1E37C44 VA: 0x1E3BC44
	public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1E3BCEC Offset: 0x1E37CEC VA: 0x1E3BCEC
	public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1E3BD5C Offset: 0x1E37D5C VA: 0x1E3BD5C
	public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1E3BE04 Offset: 0x1E37E04 VA: 0x1E3BE04
	public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1E3BEB8 Offset: 0x1E37EB8 VA: 0x1E3BEB8
	public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1E3BF6C Offset: 0x1E37F6C VA: 0x1E3BF6C
	public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1E3C014 Offset: 0x1E38014 VA: 0x1E3C014
	public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1E3C0BC Offset: 0x1E380BC VA: 0x1E3C0BC
	public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1E3C164 Offset: 0x1E38164 VA: 0x1E3C164
	public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1E3C20C Offset: 0x1E3820C VA: 0x1E3C20C
	public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID) { }

	// RVA: 0x1E3C2B4 Offset: 0x1E382B4 VA: 0x1E3C2B4
	public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3C324 Offset: 0x1E38324 VA: 0x1E3C324
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E331A4 Offset: 0x1E2F1A4 VA: 0x1E331A4
	public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3C38C Offset: 0x1E3838C VA: 0x1E3C38C
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E3C3F4 Offset: 0x1E383F4 VA: 0x1E3C3F4
	public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3C4A4 Offset: 0x1E384A4 VA: 0x1E3C4A4
	public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3C514 Offset: 0x1E38514 VA: 0x1E3C514
	public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3C590 Offset: 0x1E38590 VA: 0x1E3C590
	public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3C60C Offset: 0x1E3860C VA: 0x1E3C60C
	public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3C67C Offset: 0x1E3867C VA: 0x1E3C67C
	public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3C6EC Offset: 0x1E386EC VA: 0x1E3C6EC
	public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3C75C Offset: 0x1E3875C VA: 0x1E3C75C
	public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3C7CC Offset: 0x1E387CC VA: 0x1E3C7CC
	public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3C83C Offset: 0x1E3883C VA: 0x1E3C83C
	public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val) { }

	// RVA: 0x1E3C8FC Offset: 0x1E388FC VA: 0x1E3C8FC
	public static void SetStringField(IntPtr obj, IntPtr fieldID, string val) { }

	// RVA: 0x1E3C96C Offset: 0x1E3896C VA: 0x1E3C96C
	public static void SetCharField(IntPtr obj, IntPtr fieldID, char val) { }

	// RVA: 0x1E3CA2C Offset: 0x1E38A2C VA: 0x1E3CA2C
	public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val) { }

	// RVA: 0x1E3CAEC Offset: 0x1E38AEC VA: 0x1E3CAEC
	public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val) { }

	// RVA: 0x1E3CBAC Offset: 0x1E38BAC VA: 0x1E3CBAC
	public static void SetLongField(IntPtr obj, IntPtr fieldID, long val) { }

	// RVA: 0x1E3CC6C Offset: 0x1E38C6C VA: 0x1E3CC6C
	public static void SetShortField(IntPtr obj, IntPtr fieldID, short val) { }

	// RVA: 0x1E3CD2C Offset: 0x1E38D2C VA: 0x1E3CD2C
	public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val) { }

	// RVA: 0x1E3CDEC Offset: 0x1E38DEC VA: 0x1E3CDEC
	public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val) { }

	// RVA: 0x1E3CEAC Offset: 0x1E38EAC VA: 0x1E3CEAC
	public static void SetIntField(IntPtr obj, IntPtr fieldID, int val) { }

	// RVA: 0x1E3CF6C Offset: 0x1E38F6C VA: 0x1E3CF6C
	public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x1E3D014 Offset: 0x1E39014 VA: 0x1E3D014
	public static string GetStringField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x1E3D084 Offset: 0x1E39084 VA: 0x1E3D084
	public static char GetCharField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x1E3D12C Offset: 0x1E3912C VA: 0x1E3D12C
	public static double GetDoubleField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x1E3D1E0 Offset: 0x1E391E0 VA: 0x1E3D1E0
	public static float GetFloatField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x1E3D294 Offset: 0x1E39294 VA: 0x1E3D294
	public static long GetLongField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x1E3D33C Offset: 0x1E3933C VA: 0x1E3D33C
	public static short GetShortField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x1E3D3E4 Offset: 0x1E393E4 VA: 0x1E3D3E4
	public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x1E3D48C Offset: 0x1E3948C VA: 0x1E3D48C
	public static bool GetBooleanField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x1E3D534 Offset: 0x1E39534 VA: 0x1E3D534
	public static int GetIntField(IntPtr obj, IntPtr fieldID) { }

	// RVA: 0x1E3D5DC Offset: 0x1E395DC VA: 0x1E3D5DC
	public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3D64C Offset: 0x1E3964C VA: 0x1E3D64C
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, jvalue[] args) { }

	// RVA: 0x1E3D6B4 Offset: 0x1E396B4 VA: 0x1E3D6B4
	public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3D724 Offset: 0x1E39724 VA: 0x1E3D724
	public static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E33DA8 Offset: 0x1E2FDA8 VA: 0x1E33DA8
	public static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E33CA4 Offset: 0x1E2FCA4 VA: 0x1E33CA4
	public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E33BA0 Offset: 0x1E2FBA0 VA: 0x1E33BA0
	public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E33AA8 Offset: 0x1E2FAA8 VA: 0x1E33AA8
	public static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E338B8 Offset: 0x1E2F8B8 VA: 0x1E338B8
	public static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E337C0 Offset: 0x1E2F7C0 VA: 0x1E337C0
	public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E33EA4 Offset: 0x1E2FEA4 VA: 0x1E33EA4
	public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E339B0 Offset: 0x1E2F9B0 VA: 0x1E339B0
	public static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args) { }

	// RVA: 0x1E3D7D4 Offset: 0x1E397D4 VA: 0x1E3D7D4
	public static char[] FromCharArray(IntPtr array) { }

	// RVA: 0x1E3D874 Offset: 0x1E39874 VA: 0x1E3D874
	public static double[] FromDoubleArray(IntPtr array) { }

	// RVA: 0x1E3D914 Offset: 0x1E39914 VA: 0x1E3D914
	public static float[] FromFloatArray(IntPtr array) { }

	// RVA: 0x1E3D9B4 Offset: 0x1E399B4 VA: 0x1E3D9B4
	public static long[] FromLongArray(IntPtr array) { }

	// RVA: 0x1E3DA54 Offset: 0x1E39A54 VA: 0x1E3DA54
	public static short[] FromShortArray(IntPtr array) { }

	// RVA: 0x1E3DAF4 Offset: 0x1E39AF4 VA: 0x1E3DAF4
	public static byte[] FromByteArray(IntPtr array) { }

	// RVA: 0x1E3DB64 Offset: 0x1E39B64 VA: 0x1E3DB64
	public static sbyte[] FromSByteArray(IntPtr array) { }

	// RVA: 0x1E3DC04 Offset: 0x1E39C04 VA: 0x1E3DC04
	public static bool[] FromBooleanArray(IntPtr array) { }

	// RVA: 0x1E3DC74 Offset: 0x1E39C74 VA: 0x1E3DC74
	public static int[] FromIntArray(IntPtr array) { }

	// RVA: 0x1E3DD14 Offset: 0x1E39D14 VA: 0x1E3DD14
	public static IntPtr ToObjectArray(IntPtr[] array, IntPtr type) { }

	// RVA: 0x1E3DD84 Offset: 0x1E39D84 VA: 0x1E3DD84
	public static IntPtr ToCharArray(char[] array) { }

	// RVA: 0x1E3DDF4 Offset: 0x1E39DF4 VA: 0x1E3DDF4
	public static IntPtr ToDoubleArray(double[] array) { }

	// RVA: 0x1E3DE64 Offset: 0x1E39E64 VA: 0x1E3DE64
	public static IntPtr ToFloatArray(float[] array) { }

	// RVA: 0x1E3DED4 Offset: 0x1E39ED4 VA: 0x1E3DED4
	public static IntPtr ToLongArray(long[] array) { }

	// RVA: 0x1E3DF44 Offset: 0x1E39F44 VA: 0x1E3DF44
	public static IntPtr ToShortArray(short[] array) { }

	// RVA: 0x1E3DFB4 Offset: 0x1E39FB4 VA: 0x1E3DFB4
	public static IntPtr ToByteArray(byte[] array) { }

	// RVA: 0x1E3E024 Offset: 0x1E3A024 VA: 0x1E3E024
	public static IntPtr ToSByteArray(sbyte[] array) { }

	// RVA: 0x1E3E094 Offset: 0x1E3A094 VA: 0x1E3E094
	public static IntPtr ToBooleanArray(bool[] array) { }

	// RVA: 0x1E3E110 Offset: 0x1E3A110 VA: 0x1E3E110
	public static IntPtr ToIntArray(int[] array) { }

	// RVA: 0x1E3E180 Offset: 0x1E3A180 VA: 0x1E3E180
	public static IntPtr GetObjectArrayElement(IntPtr array, int index) { }

	// RVA: 0x1E3E228 Offset: 0x1E3A228 VA: 0x1E3E228
	public static int GetArrayLength(IntPtr array) { }
}

// Namespace: UnityEngine
public sealed class AndroidJavaRunnable : MulticastDelegate // TypeDefIndex: 7607
{
	// Methods

	// RVA: 0x1E3E2C8 Offset: 0x1E3A2C8 VA: 0x1E3E2C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E3E364 Offset: 0x1E3A364 VA: 0x1E3E364 Slot: 12
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
public sealed class AndroidJavaException : Exception // TypeDefIndex: 7608
{
	// Fields
	private string mJavaStackTrace; // 0x90

	// Properties
	public override string StackTrace { get; }

	// Methods

	// RVA: 0x1E3B0AC Offset: 0x1E370AC VA: 0x1E3B0AC
	internal void .ctor(string message, string javaStackTrace) { }

	// RVA: 0x1E3E378 Offset: 0x1E3A378 VA: 0x1E3E378 Slot: 8
	public override string get_StackTrace() { }
}

// Namespace: UnityEngine
internal class GlobalJavaObjectRef // TypeDefIndex: 7609
{
	// Fields
	private bool m_disposed; // 0x10
	protected IntPtr m_jobject; // 0x18

	// Methods

	// RVA: 0x1E3E39C Offset: 0x1E3A39C VA: 0x1E3E39C
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x1E3E3FC Offset: 0x1E3A3FC VA: 0x1E3E3FC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1E3E4DC Offset: 0x1E3A4DC VA: 0x1E3E4DC
	public static IntPtr op_Implicit(GlobalJavaObjectRef obj) { }

	// RVA: 0x1E3E480 Offset: 0x1E3A480 VA: 0x1E3E480
	public void Dispose() { }
}

// Namespace: UnityEngine
internal class AndroidJavaRunnableProxy : AndroidJavaProxy // TypeDefIndex: 7610
{
	// Fields
	private AndroidJavaRunnable mRunnable; // 0x20

	// Methods

	// RVA: 0x1E3E4F0 Offset: 0x1E3A4F0 VA: 0x1E3E4F0
	public void .ctor(AndroidJavaRunnable runnable) { }

	// RVA: 0x1E3E600 Offset: 0x1E3A600 VA: 0x1E3E600
	public void run() { }

	// RVA: 0x1E3E620 Offset: 0x1E3A620 VA: 0x1E3E620 Slot: 6
	public override IntPtr Invoke(string methodName, IntPtr javaArgs) { }
}

// Namespace: UnityEngine
public class AndroidJavaProxy // TypeDefIndex: 7611
{
	// Fields
	public readonly AndroidJavaClass javaInterface; // 0x10
	internal IntPtr proxyObject; // 0x18
	private static readonly GlobalJavaObjectRef s_JavaLangSystemClass; // 0x0
	private static readonly IntPtr s_HashCodeMethodID; // 0x8

	// Methods

	// RVA: 0x1E3E578 Offset: 0x1E3A578 VA: 0x1E3E578
	public void .ctor(string javaInterface) { }

	// RVA: 0x1E3EA98 Offset: 0x1E3AA98 VA: 0x1E3EA98
	public void .ctor(AndroidJavaClass javaInterface) { }

	// RVA: 0x1E3EACC Offset: 0x1E3AACC VA: 0x1E3EACC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1E3EB84 Offset: 0x1E3AB84 VA: 0x1E3EB84 Slot: 4
	public virtual AndroidJavaObject Invoke(string methodName, object[] args) { }

	// RVA: 0x1E400C8 Offset: 0x1E3C0C8 VA: 0x1E400C8 Slot: 5
	public virtual AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) { }

	// RVA: 0x1E3E6D0 Offset: 0x1E3A6D0 VA: 0x1E3E6D0 Slot: 6
	public virtual IntPtr Invoke(string methodName, IntPtr javaArgs) { }

	// RVA: 0x1E40DC0 Offset: 0x1E3CDC0 VA: 0x1E40DC0 Slot: 7
	public virtual bool equals(AndroidJavaObject obj) { }

	// RVA: 0x1E40E18 Offset: 0x1E3CE18 VA: 0x1E40E18 Slot: 8
	public virtual int hashCode() { }

	// RVA: 0x1E40FD0 Offset: 0x1E3CFD0 VA: 0x1E40FD0 Slot: 9
	public virtual string toString() { }

	// RVA: 0x1E41034 Offset: 0x1E3D034 VA: 0x1E41034
	internal AndroidJavaObject GetProxyObject() { }

	// RVA: 0x1E40F14 Offset: 0x1E3CF14 VA: 0x1E40F14
	internal IntPtr GetRawProxy() { }

	// RVA: 0x1E41044 Offset: 0x1E3D044 VA: 0x1E41044
	private static void .cctor() { }
}

// Namespace: UnityEngine
public class AndroidJavaObject : IDisposable // TypeDefIndex: 7612
{
	// Fields
	private static bool enableDebugPrints; // 0x0
	internal GlobalJavaObjectRef m_jobject; // 0x10
	internal GlobalJavaObjectRef m_jclass; // 0x18

	// Methods

	// RVA: 0x1E4114C Offset: 0x1E3D14C VA: 0x1E4114C
	public void .ctor(string className, string[] args) { }

	// RVA: 0x1E4132C Offset: 0x1E3D32C VA: 0x1E4132C
	public void .ctor(string className, AndroidJavaObject[] args) { }

	// RVA: 0x1E413EC Offset: 0x1E3D3EC VA: 0x1E413EC
	public void .ctor(string className, AndroidJavaClass[] args) { }

	// RVA: 0x1E414AC Offset: 0x1E3D4AC VA: 0x1E414AC
	public void .ctor(string className, AndroidJavaProxy[] args) { }

	// RVA: 0x1E4156C Offset: 0x1E3D56C VA: 0x1E4156C
	public void .ctor(string className, AndroidJavaRunnable[] args) { }

	// RVA: 0x1E4162C Offset: 0x1E3D62C VA: 0x1E4162C
	public void .ctor(string className, object[] args) { }

	// RVA: 0x1E3FF94 Offset: 0x1E3BF94 VA: 0x1E3FF94
	public void .ctor(IntPtr jobject) { }

	// RVA: 0x1E41660 Offset: 0x1E3D660 VA: 0x1E41660
	public void .ctor(IntPtr clazz, IntPtr constructorID, object[] args) { }

	// RVA: 0x1E40C40 Offset: 0x1E3CC40 VA: 0x1E40C40 Slot: 4
	public void Dispose() { }

	// RVA: -1 Offset: -1
	public void Call<T>(string methodName, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100C0D0 Offset: 0x10080D0 VA: 0x100C0D0
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Call<T>(IntPtr methodID, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100C018 Offset: 0x1008018 VA: 0x100C018
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E41934 Offset: 0x1E3D934 VA: 0x1E41934
	public void Call(string methodName, object[] args) { }

	// RVA: 0x1E41978 Offset: 0x1E3D978 VA: 0x1E41978
	public void Call(IntPtr methodID, object[] args) { }

	// RVA: -1 Offset: -1
	public void CallStatic<T>(string methodName, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100C788 Offset: 0x1008788 VA: 0x100C788
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void CallStatic<T>(IntPtr methodID, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100C6D0 Offset: 0x10086D0 VA: 0x100C6D0
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E41BA4 Offset: 0x1E3DBA4 VA: 0x1E41BA4
	public void CallStatic(string methodName, object[] args) { }

	// RVA: 0x1E41BE8 Offset: 0x1E3DBE8 VA: 0x1E41BE8
	public void CallStatic(IntPtr methodID, object[] args) { }

	// RVA: -1 Offset: -1
	public FieldType Get<FieldType>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D658 Offset: 0x1009658 VA: 0x100D658
	|-AndroidJavaObject.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public FieldType Get<FieldType>(IntPtr fieldID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D594 Offset: 0x1009594 VA: 0x100D594
	|-AndroidJavaObject.Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Set<FieldType>(string fieldName, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D9B8 Offset: 0x10099B8 VA: 0x100D9B8
	|-AndroidJavaObject.Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void Set<FieldType>(IntPtr fieldID, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D8D4 Offset: 0x10098D4 VA: 0x100D8D4
	|-AndroidJavaObject.Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public FieldType GetStatic<FieldType>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D714 Offset: 0x1009714 VA: 0x100D714
	|-AndroidJavaObject.GetStatic<object>
	|
	|-RVA: 0x100D818 Offset: 0x1009818 VA: 0x100D818
	|-AndroidJavaObject.GetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public FieldType GetStatic<FieldType>(IntPtr fieldID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D754 Offset: 0x1009754 VA: 0x100D754
	|-AndroidJavaObject.GetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStatic<FieldType>(string fieldName, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100DB78 Offset: 0x1009B78 VA: 0x100DB78
	|-AndroidJavaObject.SetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void SetStatic<FieldType>(IntPtr fieldID, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100DA94 Offset: 0x1009A94 VA: 0x100DA94
	|-AndroidJavaObject.SetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E40DA8 Offset: 0x1E3CDA8 VA: 0x1E40DA8
	public IntPtr GetRawObject() { }

	// RVA: 0x1E41E2C Offset: 0x1E3DE2C VA: 0x1E41E2C
	public IntPtr GetRawClass() { }

	// RVA: 0x1E41E5C Offset: 0x1E3DE5C VA: 0x1E41E5C
	public AndroidJavaObject CloneReference() { }

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType, T>(string methodName, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100C310 Offset: 0x1008310 VA: 0x100C310
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType, T>(IntPtr methodID, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100C188 Offset: 0x1008188 VA: 0x100C188
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100BBA8 Offset: 0x1007BA8 VA: 0x100BBA8
	|-AndroidJavaObject.Call<bool>
	|
	|-RVA: 0x100BBF8 Offset: 0x1007BF8 VA: 0x100BBF8
	|-AndroidJavaObject.Call<char>
	|
	|-RVA: 0x100BC48 Offset: 0x1007C48 VA: 0x100BC48
	|-AndroidJavaObject.Call<double>
	|
	|-RVA: 0x100BC98 Offset: 0x1007C98 VA: 0x100BC98
	|-AndroidJavaObject.Call<short>
	|
	|-RVA: 0x100BCE8 Offset: 0x1007CE8 VA: 0x100BCE8
	|-AndroidJavaObject.Call<int>
	|
	|-RVA: 0x100BD38 Offset: 0x1007D38 VA: 0x100BD38
	|-AndroidJavaObject.Call<long>
	|
	|-RVA: 0x100BD88 Offset: 0x1007D88 VA: 0x100BD88
	|-AndroidJavaObject.Call<object>
	|
	|-RVA: 0x100BDD8 Offset: 0x1007DD8 VA: 0x100BDD8
	|-AndroidJavaObject.Call<sbyte>
	|
	|-RVA: 0x100BE28 Offset: 0x1007E28 VA: 0x100BE28
	|-AndroidJavaObject.Call<float>
	|
	|-RVA: 0x100BF4C Offset: 0x1007F4C VA: 0x100BF4C
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType Call<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100BE78 Offset: 0x1007E78 VA: 0x100BE78
	|-AndroidJavaObject.Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType, T>(string methodName, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100C9C8 Offset: 0x10089C8 VA: 0x100C9C8
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType, T>(IntPtr methodID, T[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100C840 Offset: 0x1008840 VA: 0x100C840
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100C490 Offset: 0x1008490 VA: 0x100C490
	|-AndroidJavaObject.CallStatic<int>
	|
	|-RVA: 0x100C4E0 Offset: 0x10084E0 VA: 0x100C4E0
	|-AndroidJavaObject.CallStatic<object>
	|
	|-RVA: 0x100C604 Offset: 0x1008604 VA: 0x100C604
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public ReturnType CallStatic<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100C530 Offset: 0x1008530 VA: 0x100C530
	|-AndroidJavaObject.CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E4208C Offset: 0x1E3E08C VA: 0x1E4208C
	protected void DebugPrint(string msg) { }

	// RVA: 0x1E42114 Offset: 0x1E3E114 VA: 0x1E42114
	protected void DebugPrint(string call, string methodName, string signature, object[] args) { }

	// RVA: 0x1E41214 Offset: 0x1E3D214 VA: 0x1E41214
	private void _AndroidJavaObject(string className, object[] args) { }

	// RVA: 0x1E416F8 Offset: 0x1E3D6F8 VA: 0x1E416F8
	private void _AndroidJavaObject(IntPtr constructorID, object[] args) { }

	// RVA: 0x1E4120C Offset: 0x1E3D20C VA: 0x1E4120C
	internal void .ctor() { }

	// RVA: 0x1E4241C Offset: 0x1E3E41C VA: 0x1E4241C Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1E424AC Offset: 0x1E3E4AC VA: 0x1E424AC Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1E41938 Offset: 0x1E3D938 VA: 0x1E41938
	protected void _Call(string methodName, object[] args) { }

	// RVA: 0x1E4197C Offset: 0x1E3D97C VA: 0x1E4197C
	protected void _Call(IntPtr methodID, object[] args) { }

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100EBDC Offset: 0x100ABDC VA: 0x100EBDC
	|-AndroidJavaObject._Call<bool>
	|
	|-RVA: 0x100FBD0 Offset: 0x100BBD0 VA: 0x100FBD0
	|-AndroidJavaObject._Call<char>
	|
	|-RVA: 0x1010BD4 Offset: 0x100CBD4 VA: 0x1010BD4
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x1011BC8 Offset: 0x100DBC8 VA: 0x1011BC8
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x1012BBC Offset: 0x100EBBC VA: 0x1012BBC
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x1013BB4 Offset: 0x100FBB4 VA: 0x1013BB4
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x1014AE4 Offset: 0x1010AE4 VA: 0x1014AE4
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x1015AD8 Offset: 0x1011AD8 VA: 0x1015AD8
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x1016ADC Offset: 0x1012ADC VA: 0x1016ADC
	|-AndroidJavaObject._Call<float>
	|
	|-RVA: 0x1017C98 Offset: 0x1013C98 VA: 0x1017C98
	|-AndroidJavaObject._Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _Call<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100DC54 Offset: 0x1009C54 VA: 0x100DC54
	|-AndroidJavaObject._Call<bool>
	|
	|-RVA: 0x100EC50 Offset: 0x100AC50 VA: 0x100EC50
	|-AndroidJavaObject._Call<char>
	|
	|-RVA: 0x100FC44 Offset: 0x100BC44 VA: 0x100FC44
	|-AndroidJavaObject._Call<double>
	|
	|-RVA: 0x1010C48 Offset: 0x100CC48 VA: 0x1010C48
	|-AndroidJavaObject._Call<short>
	|
	|-RVA: 0x1011C3C Offset: 0x100DC3C VA: 0x1011C3C
	|-AndroidJavaObject._Call<int>
	|
	|-RVA: 0x1012C30 Offset: 0x100EC30 VA: 0x1012C30
	|-AndroidJavaObject._Call<long>
	|
	|-RVA: 0x1013C28 Offset: 0x100FC28 VA: 0x1013C28
	|-AndroidJavaObject._Call<object>
	|
	|-RVA: 0x1014B58 Offset: 0x1010B58 VA: 0x1014B58
	|-AndroidJavaObject._Call<sbyte>
	|
	|-RVA: 0x1015B4C Offset: 0x1011B4C VA: 0x1015B4C
	|-AndroidJavaObject._Call<float>
	|
	|-RVA: 0x1016B50 Offset: 0x1012B50 VA: 0x1016B50
	|-AndroidJavaObject._Call<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected FieldType _Get<FieldType>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x101B794 Offset: 0x1017794 VA: 0x101B794
	|-AndroidJavaObject._Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected FieldType _Get<FieldType>(IntPtr fieldID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x101ADBC Offset: 0x1016DBC VA: 0x101ADBC
	|-AndroidJavaObject._Get<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void _Set<FieldType>(string fieldName, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x101D95C Offset: 0x101995C VA: 0x101D95C
	|-AndroidJavaObject._Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void _Set<FieldType>(IntPtr fieldID, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x101CBD8 Offset: 0x1018BD8 VA: 0x101CBD8
	|-AndroidJavaObject._Set<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E41BA8 Offset: 0x1E3DBA8 VA: 0x1E41BA8
	protected void _CallStatic(string methodName, object[] args) { }

	// RVA: 0x1E41BEC Offset: 0x1E3DBEC VA: 0x1E41BEC
	protected void _CallStatic(IntPtr methodID, object[] args) { }

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(string methodName, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1018D1C Offset: 0x1014D1C VA: 0x1018D1C
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x1019C4C Offset: 0x1015C4C VA: 0x1019C4C
	|-AndroidJavaObject._CallStatic<object>
	|
	|-RVA: 0x101ACB8 Offset: 0x1016CB8 VA: 0x101ACB8
	|-AndroidJavaObject._CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected ReturnType _CallStatic<ReturnType>(IntPtr methodID, object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1017D9C Offset: 0x1013D9C VA: 0x1017D9C
	|-AndroidJavaObject._CallStatic<int>
	|
	|-RVA: 0x1018D90 Offset: 0x1014D90 VA: 0x1018D90
	|-AndroidJavaObject._CallStatic<object>
	|
	|-RVA: 0x1019CC0 Offset: 0x1015CC0 VA: 0x1019CC0
	|-AndroidJavaObject._CallStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected FieldType _GetStatic<FieldType>(string fieldName) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x101C0A8 Offset: 0x10180A8 VA: 0x101C0A8
	|-AndroidJavaObject._GetStatic<object>
	|
	|-RVA: 0x101CAE0 Offset: 0x1018AE0 VA: 0x101CAE0
	|-AndroidJavaObject._GetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected FieldType _GetStatic<FieldType>(IntPtr fieldID) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x101B88C Offset: 0x101788C VA: 0x101B88C
	|-AndroidJavaObject._GetStatic<object>
	|
	|-RVA: 0x101C108 Offset: 0x1018108 VA: 0x101C108
	|-AndroidJavaObject._GetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void _SetStatic<FieldType>(string fieldName, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x101E7F8 Offset: 0x101A7F8 VA: 0x101E7F8
	|-AndroidJavaObject._SetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	protected void _SetStatic<FieldType>(IntPtr fieldID, FieldType val) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x101DA74 Offset: 0x1019A74 VA: 0x101DA74
	|-AndroidJavaObject._SetStatic<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E40CAC Offset: 0x1E3CCAC VA: 0x1E40CAC
	internal static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject) { }

	// RVA: 0x1E42508 Offset: 0x1E3E508 VA: 0x1E42508
	internal static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass) { }

	// RVA: -1 Offset: -1
	internal static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(IntPtr jobject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100D2B8 Offset: 0x10092B8 VA: 0x100D2B8
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<object>
	|
	|-RVA: 0x100D37C Offset: 0x100937C VA: 0x100D37C
	|-AndroidJavaObject.FromJavaArrayDeleteLocalRef<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static ReturnType FromJavaArray<ReturnType>(IntPtr jobject) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x100CB48 Offset: 0x1008B48 VA: 0x100CB48
	|-AndroidJavaObject.FromJavaArray<bool>
	|
	|-RVA: 0x100CC04 Offset: 0x1008C04 VA: 0x100CC04
	|-AndroidJavaObject.FromJavaArray<char>
	|
	|-RVA: 0x100CCB8 Offset: 0x1008CB8 VA: 0x100CCB8
	|-AndroidJavaObject.FromJavaArray<double>
	|
	|-RVA: 0x100CD68 Offset: 0x1008D68 VA: 0x100CD68
	|-AndroidJavaObject.FromJavaArray<short>
	|
	|-RVA: 0x100CE1C Offset: 0x1008E1C VA: 0x100CE1C
	|-AndroidJavaObject.FromJavaArray<int>
	|
	|-RVA: 0x100CED0 Offset: 0x1008ED0 VA: 0x100CED0
	|-AndroidJavaObject.FromJavaArray<long>
	|
	|-RVA: 0x100CF80 Offset: 0x1008F80 VA: 0x100CF80
	|-AndroidJavaObject.FromJavaArray<object>
	|
	|-RVA: 0x100CFD0 Offset: 0x1008FD0 VA: 0x100CFD0
	|-AndroidJavaObject.FromJavaArray<sbyte>
	|
	|-RVA: 0x100D084 Offset: 0x1009084 VA: 0x100D084
	|-AndroidJavaObject.FromJavaArray<float>
	|
	|-RVA: 0x100D134 Offset: 0x1009134 VA: 0x100D134
	|-AndroidJavaObject.FromJavaArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E41E14 Offset: 0x1E3DE14 VA: 0x1E41E14
	protected IntPtr _GetRawObject() { }

	// RVA: 0x1E41E44 Offset: 0x1E3DE44 VA: 0x1E41E44
	protected IntPtr _GetRawClass() { }
}

// Namespace: UnityEngine
public class AndroidJavaClass : AndroidJavaObject // TypeDefIndex: 7613
{
	// Methods

	// RVA: 0x1E3EA6C Offset: 0x1E3AA6C VA: 0x1E3EA6C
	public void .ctor(string className) { }

	// RVA: 0x1E42604 Offset: 0x1E3E604 VA: 0x1E42604
	private void _AndroidJavaClass(string className) { }

	// RVA: 0x1E41FC0 Offset: 0x1E3DFC0 VA: 0x1E41FC0
	internal void .ctor(IntPtr jclass) { }
}

// Namespace: UnityEngine
internal class AndroidReflection // TypeDefIndex: 7614
{
	// Fields
	private static readonly GlobalJavaObjectRef s_ReflectionHelperClass; // 0x0
	private static readonly IntPtr s_ReflectionHelperGetConstructorID; // 0x8
	private static readonly IntPtr s_ReflectionHelperGetMethodID; // 0x10
	private static readonly IntPtr s_ReflectionHelperGetFieldID; // 0x18
	private static readonly IntPtr s_ReflectionHelperGetFieldSignature; // 0x20
	private static readonly IntPtr s_ReflectionHelperNewProxyInstance; // 0x28
	private static readonly IntPtr s_ReflectionHelperCeateInvocationError; // 0x30
	private static readonly IntPtr s_FieldGetDeclaringClass; // 0x38

	// Methods

	// RVA: 0x1E42710 Offset: 0x1E3E710 VA: 0x1E42710
	public static bool IsPrimitive(Type t) { }

	// RVA: 0x1E42724 Offset: 0x1E3E724 VA: 0x1E42724
	public static bool IsAssignableFrom(Type t, Type from) { }

	// RVA: 0x1E42740 Offset: 0x1E3E740 VA: 0x1E42740
	private static IntPtr GetStaticMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x1E42814 Offset: 0x1E3E814 VA: 0x1E42814
	private static IntPtr GetMethodID(string clazz, string methodName, string signature) { }

	// RVA: 0x1E428E8 Offset: 0x1E3E8E8 VA: 0x1E428E8
	public static IntPtr GetConstructorMember(IntPtr jclass, string signature) { }

	// RVA: 0x1E42A94 Offset: 0x1E3EA94 VA: 0x1E42A94
	public static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x1E42C50 Offset: 0x1E3EC50 VA: 0x1E42C50
	public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x1E42E0C Offset: 0x1E3EE0C VA: 0x1E42E0C
	public static IntPtr GetFieldClass(IntPtr field) { }

	// RVA: 0x1E42E70 Offset: 0x1E3EE70 VA: 0x1E42E70
	public static string GetFieldSignature(IntPtr field) { }

	// RVA: 0x1E42F18 Offset: 0x1E3EF18 VA: 0x1E42F18
	public static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze) { }

	// RVA: 0x1E3FEA4 Offset: 0x1E3BEA4 VA: 0x1E3FEA4
	internal static IntPtr CreateInvocationError(Exception ex, bool methodNotFound) { }

	// RVA: 0x1E42FFC Offset: 0x1E3EFFC VA: 0x1E42FFC
	private static void .cctor() { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
internal sealed class _AndroidJNIHelper // TypeDefIndex: 7615
{
	// Fields
	private static int FRAME_SIZE_FOR_ARRAYS; // 0x0

	// Methods

	// RVA: 0x1E307C8 Offset: 0x1E2C7C8 VA: 0x1E307C8
	public static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy) { }

	// RVA: 0x1E30600 Offset: 0x1E2C600 VA: 0x1E30600
	public static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable) { }

	[RequiredByNativeCode]
	// RVA: 0x1E432C8 Offset: 0x1E3F2C8 VA: 0x1E432C8
	public static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs) { }

	// RVA: 0x1E31614 Offset: 0x1E2D614 VA: 0x1E31614
	public static void CreateJNIArgArray(object[] args, Span<jvalue> ret) { }

	// RVA: 0x1E433B0 Offset: 0x1E3F3B0 VA: 0x1E433B0
	public static object UnboxArray(AndroidJavaObject obj) { }

	// RVA: 0x1E40270 Offset: 0x1E3C270 VA: 0x1E40270
	public static object Unbox(AndroidJavaObject obj) { }

	// RVA: 0x1E3F5A8 Offset: 0x1E3B5A8 VA: 0x1E3F5A8
	public static AndroidJavaObject Box(object obj) { }

	// RVA: 0x1E31CDC Offset: 0x1E2DCDC VA: 0x1E31CDC
	public static void DeleteJNIArgArray(object[] args, Span<jvalue> jniArgs) { }

	// RVA: 0x1E308A4 Offset: 0x1E2C8A4 VA: 0x1E308A4
	public static IntPtr ConvertToJNIArray(Array array) { }

	// RVA: -1 Offset: -1
	public static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10451A0 Offset: 0x10411A0 VA: 0x10451A0
	|-_AndroidJNIHelper.ConvertFromJNIArray<bool>
	|
	|-RVA: 0x1045B30 Offset: 0x1041B30 VA: 0x1045B30
	|-_AndroidJNIHelper.ConvertFromJNIArray<char>
	|
	|-RVA: 0x10464B4 Offset: 0x10424B4 VA: 0x10464B4
	|-_AndroidJNIHelper.ConvertFromJNIArray<double>
	|
	|-RVA: 0x1046E34 Offset: 0x1042E34 VA: 0x1046E34
	|-_AndroidJNIHelper.ConvertFromJNIArray<short>
	|
	|-RVA: 0x10477B8 Offset: 0x10437B8 VA: 0x10477B8
	|-_AndroidJNIHelper.ConvertFromJNIArray<int>
	|
	|-RVA: 0x104813C Offset: 0x104413C VA: 0x104813C
	|-_AndroidJNIHelper.ConvertFromJNIArray<long>
	|
	|-RVA: 0x1048AC0 Offset: 0x1044AC0 VA: 0x1048AC0
	|-_AndroidJNIHelper.ConvertFromJNIArray<object>
	|
	|-RVA: 0x1049460 Offset: 0x1045460 VA: 0x1049460
	|-_AndroidJNIHelper.ConvertFromJNIArray<sbyte>
	|
	|-RVA: 0x1049DE4 Offset: 0x1045DE4 VA: 0x1049DE4
	|-_AndroidJNIHelper.ConvertFromJNIArray<float>
	|
	|-RVA: 0x104A764 Offset: 0x1046764 VA: 0x104A764
	|-_AndroidJNIHelper.ConvertFromJNIArray<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E31F18 Offset: 0x1E2DF18 VA: 0x1E31F18
	public static IntPtr GetConstructorID(IntPtr jclass, object[] args) { }

	// RVA: 0x1E32000 Offset: 0x1E2E000 VA: 0x1E32000
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, object[] args, bool isStatic) { }

	// RVA: -1 Offset: -1
	public static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, object[] args, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x104B3DC Offset: 0x10473DC VA: 0x104B3DC
	|-_AndroidJNIHelper.GetMethodID<bool>
	|
	|-RVA: 0x104B46C Offset: 0x104746C VA: 0x104B46C
	|-_AndroidJNIHelper.GetMethodID<char>
	|
	|-RVA: 0x104B4FC Offset: 0x10474FC VA: 0x104B4FC
	|-_AndroidJNIHelper.GetMethodID<double>
	|
	|-RVA: 0x104B58C Offset: 0x104758C VA: 0x104B58C
	|-_AndroidJNIHelper.GetMethodID<short>
	|
	|-RVA: 0x104B61C Offset: 0x104761C VA: 0x104B61C
	|-_AndroidJNIHelper.GetMethodID<int>
	|
	|-RVA: 0x104B6AC Offset: 0x10476AC VA: 0x104B6AC
	|-_AndroidJNIHelper.GetMethodID<long>
	|
	|-RVA: 0x104B73C Offset: 0x104773C VA: 0x104B73C
	|-_AndroidJNIHelper.GetMethodID<object>
	|
	|-RVA: 0x104B7CC Offset: 0x10477CC VA: 0x104B7CC
	|-_AndroidJNIHelper.GetMethodID<sbyte>
	|
	|-RVA: 0x104B85C Offset: 0x104785C VA: 0x104B85C
	|-_AndroidJNIHelper.GetMethodID<float>
	|
	|-RVA: 0x104B8EC Offset: 0x10478EC VA: 0x104B8EC
	|-_AndroidJNIHelper.GetMethodID<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static IntPtr GetFieldID<ReturnType>(IntPtr jclass, string fieldName, bool isStatic) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x104B264 Offset: 0x1047264 VA: 0x104B264
	|-_AndroidJNIHelper.GetFieldID<object>
	|
	|-RVA: 0x104B320 Offset: 0x1047320 VA: 0x104B320
	|-_AndroidJNIHelper.GetFieldID<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E2FD40 Offset: 0x1E2BD40 VA: 0x1E2FD40
	public static IntPtr GetConstructorID(IntPtr jclass, string signature) { }

	// RVA: 0x1E3000C Offset: 0x1E2C00C VA: 0x1E3000C
	public static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x1E43BB8 Offset: 0x1E3FBB8 VA: 0x1E43BB8
	private static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic) { }

	// RVA: 0x1E30304 Offset: 0x1E2C304 VA: 0x1E30304
	public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic) { }

	// RVA: 0x1E320D8 Offset: 0x1E2E0D8 VA: 0x1E320D8
	public static string GetSignature(object obj) { }

	// RVA: 0x1E32E3C Offset: 0x1E2EE3C VA: 0x1E32E3C
	public static string GetSignature(object[] args) { }

	// RVA: -1 Offset: -1
	public static string GetSignature<ReturnType>(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x104B980 Offset: 0x1047980 VA: 0x104B980
	|-_AndroidJNIHelper.GetSignature<bool>
	|
	|-RVA: 0x104BB98 Offset: 0x1047B98 VA: 0x104BB98
	|-_AndroidJNIHelper.GetSignature<char>
	|
	|-RVA: 0x104BDB0 Offset: 0x1047DB0 VA: 0x104BDB0
	|-_AndroidJNIHelper.GetSignature<double>
	|
	|-RVA: 0x104BFC8 Offset: 0x1047FC8 VA: 0x104BFC8
	|-_AndroidJNIHelper.GetSignature<short>
	|
	|-RVA: 0x104C1E0 Offset: 0x10481E0 VA: 0x104C1E0
	|-_AndroidJNIHelper.GetSignature<int>
	|
	|-RVA: 0x104C3F8 Offset: 0x10483F8 VA: 0x104C3F8
	|-_AndroidJNIHelper.GetSignature<long>
	|
	|-RVA: 0x104C610 Offset: 0x1048610 VA: 0x104C610
	|-_AndroidJNIHelper.GetSignature<object>
	|
	|-RVA: 0x104C828 Offset: 0x1048828 VA: 0x104C828
	|-_AndroidJNIHelper.GetSignature<sbyte>
	|
	|-RVA: 0x104CA40 Offset: 0x1048A40 VA: 0x104CA40
	|-_AndroidJNIHelper.GetSignature<float>
	|
	|-RVA: 0x104CC58 Offset: 0x1048C58 VA: 0x104CC58
	|-_AndroidJNIHelper.GetSignature<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E43C4C Offset: 0x1E3FC4C VA: 0x1E43C4C
	public void .ctor() { }

	// RVA: 0x1E43C54 Offset: 0x1E3FC54 VA: 0x1E43C54
	private static void .cctor() { }
}

// Namespace: UnityEngine
[StaticAccessor("GUIEvent", 2)]
[NativeHeader("Modules/IMGUI/Event.bindings.h")]
public sealed class Event // TypeDefIndex: 7741
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal const float scrollWheelDeltaPerTick = 3;
	internal static bool ignoreGuiDepth; // 0x0
	private static Event s_Current; // 0x8
	private static Event s_MasterEvent; // 0x10

	// Properties
	[NativeProperty("type", False, 1)]
	public EventType rawType { get; }
	[NativeProperty("mousePosition", False, 1)]
	public Vector2 mousePosition { get; }
	[NativeProperty("delta", False, 1)]
	public Vector2 delta { get; }
	[NativeProperty("button", False, 1)]
	public int button { get; }
	[NativeProperty("modifiers", False, 1)]
	public EventModifiers modifiers { get; }
	[NativeProperty("character", False, 1)]
	public char character { get; }
	[NativeProperty("keycode", False, 1)]
	private KeyCode Internal_keyCode { get; }
	public KeyCode keyCode { get; }
	[NativeProperty("displayIndex", False, 1)]
	public int displayIndex { set; }
	public EventType type { get; }
	public string commandName { get; }
	public static Event current { get; }
	public bool isKey { get; }
	public bool isMouse { get; }
	public bool isScrollWheel { get; }

	// Methods

	// RVA: 0x1E88DF8 Offset: 0x1E84DF8 VA: 0x1E88DF8
	public EventType get_rawType() { }

	// RVA: 0x1E88E84 Offset: 0x1E84E84 VA: 0x1E88E84
	public Vector2 get_mousePosition() { }

	// RVA: 0x1E88F28 Offset: 0x1E84F28 VA: 0x1E88F28
	public Vector2 get_delta() { }

	// RVA: 0x1E88FCC Offset: 0x1E84FCC VA: 0x1E88FCC
	public int get_button() { }

	// RVA: 0x1E89058 Offset: 0x1E85058 VA: 0x1E89058
	public EventModifiers get_modifiers() { }

	// RVA: 0x1E890E4 Offset: 0x1E850E4 VA: 0x1E890E4
	public char get_character() { }

	// RVA: 0x1E89170 Offset: 0x1E85170 VA: 0x1E89170
	private KeyCode get_Internal_keyCode() { }

	// RVA: 0x1E891FC Offset: 0x1E851FC VA: 0x1E891FC
	public KeyCode get_keyCode() { }

	// RVA: 0x1E892D0 Offset: 0x1E852D0 VA: 0x1E892D0
	public void set_displayIndex(int value) { }

	[FreeFunction("GUIEvent::GetType", HasExplicitThis = True)]
	// RVA: 0x1E8936C Offset: 0x1E8536C VA: 0x1E8936C
	public EventType get_type() { }

	[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = True)]
	// RVA: 0x1E893F8 Offset: 0x1E853F8 VA: 0x1E893F8
	public string get_commandName() { }

	[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x1E8953C Offset: 0x1E8553C VA: 0x1E8953C
	private static IntPtr Internal_Create(int displayIndex) { }

	[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x1E89578 Offset: 0x1E85578 VA: 0x1E89578
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunction("GUIEvent::CopyFromPtr", IsThreadSafe = True, HasExplicitThis = True)]
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1E895B4 Offset: 0x1E855B4 VA: 0x1E895B4
	internal void CopyFromPtr(IntPtr ptr) { }

	// RVA: 0x1E89650 Offset: 0x1E85650 VA: 0x1E89650
	public static bool PopEvent(Event outEvent) { }

	// RVA: 0x1E89728 Offset: 0x1E85728 VA: 0x1E89728
	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[RequiredByNativeCode]
	// RVA: 0x1E89764 Offset: 0x1E85764 VA: 0x1E89764
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	// RVA: 0x1E89894 Offset: 0x1E85894 VA: 0x1E89894
	public void .ctor() { }

	// RVA: 0x1E89844 Offset: 0x1E85844 VA: 0x1E89844
	public void .ctor(int displayIndex) { }

	// RVA: 0x1E898E0 Offset: 0x1E858E0 VA: 0x1E898E0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1E8999C Offset: 0x1E8599C VA: 0x1E8999C
	public static Event get_current() { }

	// RVA: 0x1E899E4 Offset: 0x1E859E4 VA: 0x1E899E4
	public bool get_isKey() { }

	// RVA: 0x1E8927C Offset: 0x1E8527C VA: 0x1E8927C
	public bool get_isMouse() { }

	// RVA: 0x1E892B8 Offset: 0x1E852B8 VA: 0x1E892B8
	public bool get_isScrollWheel() { }

	// RVA: 0x1E89A00 Offset: 0x1E85A00 VA: 0x1E89A00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E89AB0 Offset: 0x1E85AB0 VA: 0x1E89AB0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E89C58 Offset: 0x1E85C58 VA: 0x1E89C58 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E88E48 Offset: 0x1E84E48 VA: 0x1E88E48
	private static EventType get_rawType_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E88EE4 Offset: 0x1E84EE4 VA: 0x1E88EE4
	private static void get_mousePosition_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x1E88F88 Offset: 0x1E84F88 VA: 0x1E88F88
	private static void get_delta_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x1E8901C Offset: 0x1E8501C VA: 0x1E8901C
	private static int get_button_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E890A8 Offset: 0x1E850A8 VA: 0x1E890A8
	private static EventModifiers get_modifiers_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E89134 Offset: 0x1E85134 VA: 0x1E89134
	private static char get_character_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E891C0 Offset: 0x1E851C0 VA: 0x1E891C0
	private static KeyCode get_Internal_keyCode_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E89328 Offset: 0x1E85328 VA: 0x1E89328
	private static void set_displayIndex_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1E893BC Offset: 0x1E853BC VA: 0x1E893BC
	private static EventType get_type_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E894F8 Offset: 0x1E854F8 VA: 0x1E894F8
	private static void get_commandName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x1E8960C Offset: 0x1E8560C VA: 0x1E8960C
	private static void CopyFromPtr_Injected(IntPtr _unity_self, IntPtr ptr) { }

	// RVA: 0x1E896EC Offset: 0x1E856EC VA: 0x1E896EC
	private static bool PopEvent_Injected(IntPtr outEvent) { }
}

// Namespace: UnityEngine
public enum EventType // TypeDefIndex: 7742
{
	// Fields
	public int value__; // 0x0
	public const EventType MouseDown = 0;
	public const EventType MouseUp = 1;
	public const EventType MouseMove = 2;
	public const EventType MouseDrag = 3;
	public const EventType KeyDown = 4;
	public const EventType KeyUp = 5;
	public const EventType ScrollWheel = 6;
	public const EventType Repaint = 7;
	public const EventType Layout = 8;
	public const EventType DragUpdated = 9;
	public const EventType DragPerform = 10;
	public const EventType DragExited = 15;
	public const EventType Ignore = 11;
	public const EventType Used = 12;
	public const EventType ValidateCommand = 13;
	public const EventType ExecuteCommand = 14;
	public const EventType ContextClick = 16;
	public const EventType MouseEnterWindow = 20;
	public const EventType MouseLeaveWindow = 21;
	public const EventType TouchDown = 30;
	public const EventType TouchUp = 31;
	public const EventType TouchMove = 32;
	public const EventType TouchEnter = 33;
	public const EventType TouchLeave = 34;
	public const EventType TouchStationary = 35;
	[Obsolete("Use MouseDown instead (UnityUpgradable) -> MouseDown", True)]
	[EditorBrowsable(1)]
	public const EventType mouseDown = 0;
	[Obsolete("Use MouseUp instead (UnityUpgradable) -> MouseUp", True)]
	[EditorBrowsable(1)]
	public const EventType mouseUp = 1;
	[Obsolete("Use MouseMove instead (UnityUpgradable) -> MouseMove", True)]
	[EditorBrowsable(1)]
	public const EventType mouseMove = 2;
	[EditorBrowsable(1)]
	[Obsolete("Use MouseDrag instead (UnityUpgradable) -> MouseDrag", True)]
	public const EventType mouseDrag = 3;
	[Obsolete("Use KeyDown instead (UnityUpgradable) -> KeyDown", True)]
	[EditorBrowsable(1)]
	public const EventType keyDown = 4;
	[Obsolete("Use KeyUp instead (UnityUpgradable) -> KeyUp", True)]
	[EditorBrowsable(1)]
	public const EventType keyUp = 5;
	[Obsolete("Use ScrollWheel instead (UnityUpgradable) -> ScrollWheel", True)]
	[EditorBrowsable(1)]
	public const EventType scrollWheel = 6;
	[Obsolete("Use Repaint instead (UnityUpgradable) -> Repaint", True)]
	[EditorBrowsable(1)]
	public const EventType repaint = 7;
	[EditorBrowsable(1)]
	[Obsolete("Use Layout instead (UnityUpgradable) -> Layout", True)]
	public const EventType layout = 8;
	[EditorBrowsable(1)]
	[Obsolete("Use DragUpdated instead (UnityUpgradable) -> DragUpdated", True)]
	public const EventType dragUpdated = 9;
	[Obsolete("Use DragPerform instead (UnityUpgradable) -> DragPerform", True)]
	[EditorBrowsable(1)]
	public const EventType dragPerform = 10;
	[EditorBrowsable(1)]
	[Obsolete("Use Ignore instead (UnityUpgradable) -> Ignore", True)]
	public const EventType ignore = 11;
	[EditorBrowsable(1)]
	[Obsolete("Use Used instead (UnityUpgradable) -> Used", True)]
	public const EventType used = 12;
}

// Namespace: UnityEngine
[Flags]
public enum EventModifiers // TypeDefIndex: 7743
{
	// Fields
	public int value__; // 0x0
	public const EventModifiers None = 0;
	public const EventModifiers Shift = 1;
	public const EventModifiers Control = 2;
	public const EventModifiers Alt = 4;
	public const EventModifiers Command = 8;
	public const EventModifiers Numeric = 16;
	public const EventModifiers CapsLock = 32;
	public const EventModifiers FunctionKey = 64;
}

// Namespace: 
public sealed class GUI.WindowFunction : MulticastDelegate // TypeDefIndex: 7744
{
	// Methods

	// RVA: 0x1E8B580 Offset: 0x1E87580 VA: 0x1E8B580
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E8B620 Offset: 0x1E87620 VA: 0x1E8B620 Slot: 12
	public virtual void Invoke(int id) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
[NativeHeader("Modules/IMGUI/GUI.bindings.h")]
public class GUI // TypeDefIndex: 7745
{
	// Fields
	private static int s_HotTextField; // 0x0
	private static readonly int s_BoxHash; // 0x4
	private static readonly int s_ButonHash; // 0x8
	private static readonly int s_RepeatButtonHash; // 0xC
	private static readonly int s_ToggleHash; // 0x10
	private static readonly int s_ButtonGridHash; // 0x14
	private static readonly int s_SliderHash; // 0x18
	private static readonly int s_BeginGroupHash; // 0x1C
	private static readonly int s_ScrollviewHash; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static DateTime <nextScrollStepTime>k__BackingField; // 0x28
	private static GUISkin s_Skin; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static GenericStack <scrollViewStates>k__BackingField; // 0x38

	// Properties
	public static bool changed { set; }
	internal static DateTime nextScrollStepTime { set; }
	public static GUISkin skin { get; set; }
	internal static GenericStack scrollViewStates { get; }

	// Methods

	// RVA: 0x1E8A324 Offset: 0x1E86324 VA: 0x1E8A324
	public static void set_changed(bool value) { }

	// RVA: 0x1E8A360 Offset: 0x1E86360 VA: 0x1E8A360
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1E8A618 Offset: 0x1E86618 VA: 0x1E8A618
	internal static void set_nextScrollStepTime(DateTime value) { }

	// RVA: 0x1E8A674 Offset: 0x1E86674 VA: 0x1E8A674
	public static void set_skin(GUISkin value) { }

	// RVA: 0x1E8A87C Offset: 0x1E8687C VA: 0x1E8A87C
	public static GUISkin get_skin() { }

	// RVA: 0x1E8A7AC Offset: 0x1E867AC VA: 0x1E8A7AC
	internal static void DoSetSkin(GUISkin newSkin) { }

	[CompilerGenerated]
	// RVA: 0x1E8AA5C Offset: 0x1E86A5C VA: 0x1E8AA5C
	internal static GenericStack get_scrollViewStates() { }

	[RequiredByNativeCode]
	// RVA: 0x1E8AAB4 Offset: 0x1E86AB4 VA: 0x1E8AAB4
	internal static void CallWindowDelegate(GUI.WindowFunction func, int id, int instanceID, GUISkin _skin, int forceRect, float width, float height, GUIStyle style) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Modules/IMGUI/GUIContent.h")]
[Serializable]
public class GUIContent // TypeDefIndex: 7746
{
	// Fields
	[SerializeField]
	private string m_Text; // 0x10
	[SerializeField]
	private Texture m_Image; // 0x18
	[SerializeField]
	private string m_Tooltip; // 0x20
	[SerializeField]
	private string m_TextWithWhitespace; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Action OnTextChanged; // 0x30
	private static readonly GUIContent s_Text; // 0x0
	private static readonly GUIContent s_Image; // 0x8
	private static readonly GUIContent s_TextImage; // 0x10
	internal static string k_ZeroWidthSpace; // 0x18
	public static GUIContent none; // 0x20

	// Properties
	public string text { get; set; }
	internal string textWithWhitespace { get; set; }
	public Texture image { set; }
	public string tooltip { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E8B634 Offset: 0x1E87634 VA: 0x1E8B634
	internal void add_OnTextChanged(Action value) { }

	[CompilerGenerated]
	// RVA: 0x1E8B6D0 Offset: 0x1E876D0 VA: 0x1E8B6D0
	internal void remove_OnTextChanged(Action value) { }

	// RVA: 0x1E8B76C Offset: 0x1E8776C VA: 0x1E8B76C
	public string get_text() { }

	// RVA: 0x1E8B774 Offset: 0x1E87774 VA: 0x1E8B774
	public void set_text(string value) { }

	// RVA: 0x1E8B860 Offset: 0x1E87860 VA: 0x1E8B860
	internal string get_textWithWhitespace() { }

	// RVA: 0x1E8B7E0 Offset: 0x1E877E0 VA: 0x1E8B7E0
	internal void set_textWithWhitespace(string value) { }

	// RVA: 0x1E8B8D0 Offset: 0x1E878D0 VA: 0x1E8B8D0
	internal void SetTextWithoutNotify(string value) { }

	// RVA: 0x1E8B8FC Offset: 0x1E878FC VA: 0x1E8B8FC
	public void set_image(Texture value) { }

	// RVA: 0x1E8B904 Offset: 0x1E87904 VA: 0x1E8B904
	public string get_tooltip() { }

	// RVA: 0x1E8B90C Offset: 0x1E8790C VA: 0x1E8B90C
	public void set_tooltip(string value) { }

	// RVA: 0x1E8B914 Offset: 0x1E87914 VA: 0x1E8B914
	public void .ctor() { }

	// RVA: 0x1E8B980 Offset: 0x1E87980 VA: 0x1E8B980
	public void .ctor(string text) { }

	// RVA: 0x1E8B99C Offset: 0x1E8799C VA: 0x1E8B99C
	public void .ctor(string text, Texture image, string tooltip) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1E8BA54 Offset: 0x1E87A54 VA: 0x1E8BA54
	internal static void ClearStaticCache() { }

	// RVA: 0x1E8BBB4 Offset: 0x1E87BB4 VA: 0x1E8BBB4 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E8BBD4 Offset: 0x1E87BD4 VA: 0x1E8BBD4
	private static void .cctor() { }
}

// Namespace: UnityEngine
public class GUILayout // TypeDefIndex: 7747
{
	// Methods

	// RVA: 0x1E8AEB4 Offset: 0x1E86EB4 VA: 0x1E8AEB4
	public static GUILayoutOption Width(float width) { }

	// RVA: 0x1E8AF50 Offset: 0x1E86F50 VA: 0x1E8AF50
	public static GUILayoutOption Height(float height) { }
}

// Namespace: 
internal enum GUILayoutOption.Type // TypeDefIndex: 7748
{
	// Fields
	public int value__; // 0x0
	public const GUILayoutOption.Type fixedWidth = 0;
	public const GUILayoutOption.Type fixedHeight = 1;
	public const GUILayoutOption.Type minWidth = 2;
	public const GUILayoutOption.Type maxWidth = 3;
	public const GUILayoutOption.Type minHeight = 4;
	public const GUILayoutOption.Type maxHeight = 5;
	public const GUILayoutOption.Type stretchWidth = 6;
	public const GUILayoutOption.Type stretchHeight = 7;
	public const GUILayoutOption.Type alignStart = 8;
	public const GUILayoutOption.Type alignMiddle = 9;
	public const GUILayoutOption.Type alignEnd = 10;
	public const GUILayoutOption.Type alignJustify = 11;
	public const GUILayoutOption.Type equalSize = 12;
	public const GUILayoutOption.Type spacing = 13;
}

// Namespace: UnityEngine
public sealed class GUILayoutOption // TypeDefIndex: 7749
{
	// Fields
	internal GUILayoutOption.Type type; // 0x10
	internal object value; // 0x18

	// Methods

	// RVA: 0x1E8BD04 Offset: 0x1E87D04 VA: 0x1E8BD04
	internal void .ctor(GUILayoutOption.Type type, object value) { }
}

// Namespace: 
[DebuggerDisplay("id={id}, groups={layoutGroups.Count}")]
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal sealed class GUILayoutUtility.LayoutCache // TypeDefIndex: 7750
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <id>k__BackingField; // 0x10
	public GUILayoutGroup topLevel; // 0x18
	internal GenericStack layoutGroups; // 0x20
	internal GUILayoutGroup windows; // 0x28

	// Properties
	private int id { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E8CB54 Offset: 0x1E88B54 VA: 0x1E8CB54
	private void set_id(int value) { }

	// RVA: 0x1E8BF98 Offset: 0x1E87F98 VA: 0x1E8BF98
	public void .ctor(int instanceID = -1) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUILayoutUtility.bindings.h")]
public class GUILayoutUtility // TypeDefIndex: 7751
{
	// Fields
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredLayouts; // 0x0
	private static readonly Dictionary<int, GUILayoutUtility.LayoutCache> s_StoredWindows; // 0x8
	internal static GUILayoutUtility.LayoutCache current; // 0x10
	internal static readonly Rect kDummyRect; // 0x18

	// Methods

	// RVA: 0x1E8BD3C Offset: 0x1E87D3C VA: 0x1E8BD3C
	private static Rect Internal_GetWindowRect(int windowID) { }

	// RVA: 0x1E8BE10 Offset: 0x1E87E10 VA: 0x1E8BE10
	private static void Internal_MoveWindow(int windowID, Rect r) { }

	// RVA: 0x1E8BEE0 Offset: 0x1E87EE0 VA: 0x1E8BEE0
	internal static GUILayoutUtility.LayoutCache GetLayoutCache(int instanceID, bool isWindow) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1E8AD4C Offset: 0x1E86D4C VA: 0x1E8AD4C
	internal static GUILayoutUtility.LayoutCache SelectIDList(int instanceID, bool isWindow) { }

	// RVA: 0x1E8C098 Offset: 0x1E88098 VA: 0x1E8C098
	internal static void RemoveSelectedIdList(int instanceID, bool isWindow) { }

	// RVA: 0x1E8C17C Offset: 0x1E8817C VA: 0x1E8C17C
	internal static void Begin(int instanceID) { }

	// RVA: 0x1E8AFF0 Offset: 0x1E86FF0 VA: 0x1E8AFF0
	internal static void BeginWindow(int windowID, GUIStyle style, GUILayoutOption[] options) { }

	// RVA: 0x1E8B348 Offset: 0x1E87348 VA: 0x1E8B348
	internal static void Layout() { }

	// RVA: 0x1E8C828 Offset: 0x1E88828 VA: 0x1E8C828
	internal static void LayoutFromEditorWindow() { }

	// RVA: 0x1E8C500 Offset: 0x1E88500 VA: 0x1E8C500
	internal static void LayoutFreeGroup(GUILayoutGroup toplevel) { }

	// RVA: 0x1E8C6B0 Offset: 0x1E886B0 VA: 0x1E8C6B0
	private static void LayoutSingleGroup(GUILayoutGroup i) { }

	// RVA: 0x1E8CA40 Offset: 0x1E88A40 VA: 0x1E8CA40
	private static void .cctor() { }

	// RVA: 0x1E8BDCC Offset: 0x1E87DCC VA: 0x1E8BDCC
	private static void Internal_GetWindowRect_Injected(int windowID, out Rect ret) { }

	// RVA: 0x1E8BE9C Offset: 0x1E87E9C VA: 0x1E8BE9C
	private static void Internal_MoveWindow_Injected(int windowID, in Rect r) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
[Serializable]
public sealed class GUISettings // TypeDefIndex: 7752
{
	// Fields
	[SerializeField]
	private bool m_DoubleClickSelectsWord; // 0x10
	[SerializeField]
	private bool m_TripleClickSelectsLine; // 0x11
	[SerializeField]
	private Color m_CursorColor; // 0x14
	[SerializeField]
	private float m_CursorFlashSpeed; // 0x24
	[SerializeField]
	private Color m_SelectionColor; // 0x28

	// Methods

	// RVA: 0x1E8CB5C Offset: 0x1E88B5C VA: 0x1E8CB5C
	public void .ctor() { }
}

// Namespace: 
internal sealed class GUISkin.SkinChangedDelegate : MulticastDelegate // TypeDefIndex: 7753
{
	// Methods

	// RVA: 0x1E8E7C0 Offset: 0x1E8A7C0 VA: 0x1E8E7C0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E8E85C Offset: 0x1E8A85C VA: 0x1E8E85C Slot: 12
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[ExecuteInEditMode]
[RequiredByNativeCode]
[AssetFileNameExtension("guiskin", new[] {  })]
[Serializable]
public sealed class GUISkin : ScriptableObject // TypeDefIndex: 7754
{
	// Fields
	[SerializeField]
	private Font m_Font; // 0x18
	[SerializeField]
	private GUIStyle m_box; // 0x20
	[SerializeField]
	private GUIStyle m_button; // 0x28
	[SerializeField]
	private GUIStyle m_toggle; // 0x30
	[SerializeField]
	private GUIStyle m_label; // 0x38
	[SerializeField]
	private GUIStyle m_textField; // 0x40
	[SerializeField]
	private GUIStyle m_textArea; // 0x48
	[SerializeField]
	private GUIStyle m_window; // 0x50
	[SerializeField]
	private GUIStyle m_horizontalSlider; // 0x58
	[SerializeField]
	private GUIStyle m_horizontalSliderThumb; // 0x60
	private GUIStyle m_horizontalSliderThumbExtent; // 0x68
	[SerializeField]
	private GUIStyle m_verticalSlider; // 0x70
	[SerializeField]
	private GUIStyle m_verticalSliderThumb; // 0x78
	private GUIStyle m_verticalSliderThumbExtent; // 0x80
	private GUIStyle m_SliderMixed; // 0x88
	[SerializeField]
	private GUIStyle m_horizontalScrollbar; // 0x90
	[SerializeField]
	private GUIStyle m_horizontalScrollbarThumb; // 0x98
	[SerializeField]
	private GUIStyle m_horizontalScrollbarLeftButton; // 0xA0
	[SerializeField]
	private GUIStyle m_horizontalScrollbarRightButton; // 0xA8
	[SerializeField]
	private GUIStyle m_verticalScrollbar; // 0xB0
	[SerializeField]
	private GUIStyle m_verticalScrollbarThumb; // 0xB8
	[SerializeField]
	private GUIStyle m_verticalScrollbarUpButton; // 0xC0
	[SerializeField]
	private GUIStyle m_verticalScrollbarDownButton; // 0xC8
	[SerializeField]
	private GUIStyle m_ScrollView; // 0xD0
	[SerializeField]
	internal GUIStyle[] m_CustomStyles; // 0xD8
	[SerializeField]
	private GUISettings m_Settings; // 0xE0
	internal static GUIStyle ms_Error; // 0x0
	private Dictionary<string, GUIStyle> m_Styles; // 0xE8
	internal static GUISkin.SkinChangedDelegate m_SkinChanged; // 0x8
	internal static GUISkin current; // 0x10

	// Properties
	public Font font { get; set; }
	public GUIStyle box { get; set; }
	public GUIStyle label { get; set; }
	public GUIStyle textField { get; set; }
	public GUIStyle textArea { get; set; }
	public GUIStyle button { get; set; }
	public GUIStyle toggle { get; set; }
	public GUIStyle window { get; set; }
	public GUIStyle horizontalSlider { get; set; }
	public GUIStyle horizontalSliderThumb { get; set; }
	internal GUIStyle horizontalSliderThumbExtent { get; set; }
	internal GUIStyle sliderMixed { get; set; }
	public GUIStyle verticalSlider { get; set; }
	public GUIStyle verticalSliderThumb { get; set; }
	internal GUIStyle verticalSliderThumbExtent { get; set; }
	public GUIStyle horizontalScrollbar { get; set; }
	public GUIStyle horizontalScrollbarThumb { get; set; }
	public GUIStyle horizontalScrollbarLeftButton { get; set; }
	public GUIStyle horizontalScrollbarRightButton { get; set; }
	public GUIStyle verticalScrollbar { get; set; }
	public GUIStyle verticalScrollbarThumb { get; set; }
	public GUIStyle verticalScrollbarUpButton { get; set; }
	public GUIStyle verticalScrollbarDownButton { get; set; }
	public GUIStyle scrollView { get; set; }
	public GUIStyle[] customStyles { get; set; }
	public GUISettings settings { get; }
	internal static GUIStyle error { get; }

	// Methods

	// RVA: 0x1E8CB88 Offset: 0x1E88B88 VA: 0x1E8CB88
	public void .ctor() { }

	// RVA: 0x1E8CC60 Offset: 0x1E88C60 VA: 0x1E8CC60
	internal void OnEnable() { }

	// RVA: 0x1E8CCE0 Offset: 0x1E88CE0 VA: 0x1E8CCE0
	internal static void CleanupRoots() { }

	// RVA: 0x1E8CD48 Offset: 0x1E88D48 VA: 0x1E8CD48
	public Font get_font() { }

	// RVA: 0x1E8CD50 Offset: 0x1E88D50 VA: 0x1E8CD50
	public void set_font(Font value) { }

	// RVA: 0x1E8CEC8 Offset: 0x1E88EC8 VA: 0x1E8CEC8
	public GUIStyle get_box() { }

	// RVA: 0x1E8CED0 Offset: 0x1E88ED0 VA: 0x1E8CED0
	public void set_box(GUIStyle value) { }

	// RVA: 0x1E8CEEC Offset: 0x1E88EEC VA: 0x1E8CEEC
	public GUIStyle get_label() { }

	// RVA: 0x1E8CEF4 Offset: 0x1E88EF4 VA: 0x1E8CEF4
	public void set_label(GUIStyle value) { }

	// RVA: 0x1E8CF10 Offset: 0x1E88F10 VA: 0x1E8CF10
	public GUIStyle get_textField() { }

	// RVA: 0x1E8CF18 Offset: 0x1E88F18 VA: 0x1E8CF18
	public void set_textField(GUIStyle value) { }

	// RVA: 0x1E8CF34 Offset: 0x1E88F34 VA: 0x1E8CF34
	public GUIStyle get_textArea() { }

	// RVA: 0x1E8CF3C Offset: 0x1E88F3C VA: 0x1E8CF3C
	public void set_textArea(GUIStyle value) { }

	// RVA: 0x1E8CF58 Offset: 0x1E88F58 VA: 0x1E8CF58
	public GUIStyle get_button() { }

	// RVA: 0x1E8CF60 Offset: 0x1E88F60 VA: 0x1E8CF60
	public void set_button(GUIStyle value) { }

	// RVA: 0x1E8CF7C Offset: 0x1E88F7C VA: 0x1E8CF7C
	public GUIStyle get_toggle() { }

	// RVA: 0x1E8CF84 Offset: 0x1E88F84 VA: 0x1E8CF84
	public void set_toggle(GUIStyle value) { }

	// RVA: 0x1E8CFA0 Offset: 0x1E88FA0 VA: 0x1E8CFA0
	public GUIStyle get_window() { }

	// RVA: 0x1E8CFA8 Offset: 0x1E88FA8 VA: 0x1E8CFA8
	public void set_window(GUIStyle value) { }

	// RVA: 0x1E8CFC4 Offset: 0x1E88FC4 VA: 0x1E8CFC4
	public GUIStyle get_horizontalSlider() { }

	// RVA: 0x1E8CFCC Offset: 0x1E88FCC VA: 0x1E8CFCC
	public void set_horizontalSlider(GUIStyle value) { }

	// RVA: 0x1E8CFE8 Offset: 0x1E88FE8 VA: 0x1E8CFE8
	public GUIStyle get_horizontalSliderThumb() { }

	// RVA: 0x1E8CFF0 Offset: 0x1E88FF0 VA: 0x1E8CFF0
	public void set_horizontalSliderThumb(GUIStyle value) { }

	// RVA: 0x1E8D00C Offset: 0x1E8900C VA: 0x1E8D00C
	internal GUIStyle get_horizontalSliderThumbExtent() { }

	// RVA: 0x1E8D014 Offset: 0x1E89014 VA: 0x1E8D014
	internal void set_horizontalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1E8D030 Offset: 0x1E89030 VA: 0x1E8D030
	internal GUIStyle get_sliderMixed() { }

	// RVA: 0x1E8D038 Offset: 0x1E89038 VA: 0x1E8D038
	internal void set_sliderMixed(GUIStyle value) { }

	// RVA: 0x1E8D054 Offset: 0x1E89054 VA: 0x1E8D054
	public GUIStyle get_verticalSlider() { }

	// RVA: 0x1E8D05C Offset: 0x1E8905C VA: 0x1E8D05C
	public void set_verticalSlider(GUIStyle value) { }

	// RVA: 0x1E8D078 Offset: 0x1E89078 VA: 0x1E8D078
	public GUIStyle get_verticalSliderThumb() { }

	// RVA: 0x1E8D080 Offset: 0x1E89080 VA: 0x1E8D080
	public void set_verticalSliderThumb(GUIStyle value) { }

	// RVA: 0x1E8D09C Offset: 0x1E8909C VA: 0x1E8D09C
	internal GUIStyle get_verticalSliderThumbExtent() { }

	// RVA: 0x1E8D0A4 Offset: 0x1E890A4 VA: 0x1E8D0A4
	internal void set_verticalSliderThumbExtent(GUIStyle value) { }

	// RVA: 0x1E8D0C0 Offset: 0x1E890C0 VA: 0x1E8D0C0
	public GUIStyle get_horizontalScrollbar() { }

	// RVA: 0x1E8D0C8 Offset: 0x1E890C8 VA: 0x1E8D0C8
	public void set_horizontalScrollbar(GUIStyle value) { }

	// RVA: 0x1E8D0E4 Offset: 0x1E890E4 VA: 0x1E8D0E4
	public GUIStyle get_horizontalScrollbarThumb() { }

	// RVA: 0x1E8D0EC Offset: 0x1E890EC VA: 0x1E8D0EC
	public void set_horizontalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x1E8D108 Offset: 0x1E89108 VA: 0x1E8D108
	public GUIStyle get_horizontalScrollbarLeftButton() { }

	// RVA: 0x1E8D110 Offset: 0x1E89110 VA: 0x1E8D110
	public void set_horizontalScrollbarLeftButton(GUIStyle value) { }

	// RVA: 0x1E8D12C Offset: 0x1E8912C VA: 0x1E8D12C
	public GUIStyle get_horizontalScrollbarRightButton() { }

	// RVA: 0x1E8D134 Offset: 0x1E89134 VA: 0x1E8D134
	public void set_horizontalScrollbarRightButton(GUIStyle value) { }

	// RVA: 0x1E8D150 Offset: 0x1E89150 VA: 0x1E8D150
	public GUIStyle get_verticalScrollbar() { }

	// RVA: 0x1E8D158 Offset: 0x1E89158 VA: 0x1E8D158
	public void set_verticalScrollbar(GUIStyle value) { }

	// RVA: 0x1E8D174 Offset: 0x1E89174 VA: 0x1E8D174
	public GUIStyle get_verticalScrollbarThumb() { }

	// RVA: 0x1E8D17C Offset: 0x1E8917C VA: 0x1E8D17C
	public void set_verticalScrollbarThumb(GUIStyle value) { }

	// RVA: 0x1E8D198 Offset: 0x1E89198 VA: 0x1E8D198
	public GUIStyle get_verticalScrollbarUpButton() { }

	// RVA: 0x1E8D1A0 Offset: 0x1E891A0 VA: 0x1E8D1A0
	public void set_verticalScrollbarUpButton(GUIStyle value) { }

	// RVA: 0x1E8D1BC Offset: 0x1E891BC VA: 0x1E8D1BC
	public GUIStyle get_verticalScrollbarDownButton() { }

	// RVA: 0x1E8D1C4 Offset: 0x1E891C4 VA: 0x1E8D1C4
	public void set_verticalScrollbarDownButton(GUIStyle value) { }

	// RVA: 0x1E8D1E0 Offset: 0x1E891E0 VA: 0x1E8D1E0
	public GUIStyle get_scrollView() { }

	// RVA: 0x1E8D1E8 Offset: 0x1E891E8 VA: 0x1E8D1E8
	public void set_scrollView(GUIStyle value) { }

	// RVA: 0x1E8D204 Offset: 0x1E89204 VA: 0x1E8D204
	public GUIStyle[] get_customStyles() { }

	// RVA: 0x1E8D20C Offset: 0x1E8920C VA: 0x1E8D20C
	public void set_customStyles(GUIStyle[] value) { }

	// RVA: 0x1E8D228 Offset: 0x1E89228 VA: 0x1E8D228
	public GUISettings get_settings() { }

	// RVA: 0x1E8D230 Offset: 0x1E89230 VA: 0x1E8D230
	internal static GUIStyle get_error() { }

	// RVA: 0x1E8CC64 Offset: 0x1E88C64 VA: 0x1E8CC64
	internal void Apply() { }

	// RVA: 0x1E8D3C4 Offset: 0x1E893C4 VA: 0x1E8D3C4
	private void BuildStyleCache() { }

	// RVA: 0x1E8E42C Offset: 0x1E8A42C VA: 0x1E8E42C
	public GUIStyle GetStyle(string styleName) { }

	// RVA: 0x1E8E678 Offset: 0x1E8A678 VA: 0x1E8E678
	public GUIStyle FindStyle(string styleName) { }

	// RVA: 0x1E8A9A4 Offset: 0x1E869A4 VA: 0x1E8A9A4
	internal void MakeCurrent() { }

	// RVA: 0x1E8E700 Offset: 0x1E8A700 VA: 0x1E8E700
	public IEnumerator GetEnumerator() { }
}

// Namespace: 
internal static class GUIStyleState.BindingsMarshaller // TypeDefIndex: 7755
{
	// Methods

	// RVA: 0x1E8EAF0 Offset: 0x1E8AAF0 VA: 0x1E8EAF0
	public static IntPtr ConvertToNative(GUIStyleState guiStyleState) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[Serializable]
public sealed class GUIStyleState // TypeDefIndex: 7756
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private readonly GUIStyle m_SourceStyle; // 0x18

	// Properties
	[NativeProperty("textColor", False, 1)]
	public Color textColor { set; }

	// Methods

	// RVA: 0x1E8E3C4 Offset: 0x1E8A3C4 VA: 0x1E8E3C4
	public void set_textColor(Color value) { }

	[FreeFunction(Name = "GUIStyleState_Bindings::Init", IsThreadSafe = True)]
	// RVA: 0x1E8E8B4 Offset: 0x1E8A8B4 VA: 0x1E8E8B4
	private static IntPtr Init() { }

	[FreeFunction(Name = "GUIStyleState_Bindings::Cleanup", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x1E8E8DC Offset: 0x1E8A8DC VA: 0x1E8E8DC
	private void Cleanup() { }

	// RVA: 0x1E8E968 Offset: 0x1E8A968 VA: 0x1E8E968
	public void .ctor() { }

	// RVA: 0x1E8E9AC Offset: 0x1E8A9AC VA: 0x1E8E9AC
	private void .ctor(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x1E8E9E8 Offset: 0x1E8A9E8 VA: 0x1E8E9E8
	internal static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source) { }

	// RVA: 0x1E8EA60 Offset: 0x1E8AA60 VA: 0x1E8EA60 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1E8E870 Offset: 0x1E8A870 VA: 0x1E8E870
	private static void set_textColor_Injected(IntPtr _unity_self, in Color value) { }

	// RVA: 0x1E8E92C Offset: 0x1E8A92C VA: 0x1E8E92C
	private static void Cleanup_Injected(IntPtr _unity_self) { }
}

// Namespace: 
internal static class GUIStyle.BindingsMarshaller // TypeDefIndex: 7757
{
	// Methods

	// RVA: 0x1E90C10 Offset: 0x1E8CC10 VA: 0x1E90C10
	public static IntPtr ConvertToNative(GUIStyle guiStyle) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUIStyle.bindings.h")]
[RequiredByNativeCode]
[NativeHeader("IMGUIScriptingClasses.h")]
[Serializable]
public sealed class GUIStyle // TypeDefIndex: 7758
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private GUIStyleState m_Normal; // 0x18
	private GUIStyleState m_Hover; // 0x20
	private GUIStyleState m_Active; // 0x28
	private GUIStyleState m_Focused; // 0x30
	private GUIStyleState m_OnNormal; // 0x38
	private GUIStyleState m_OnHover; // 0x40
	private GUIStyleState m_OnActive; // 0x48
	private GUIStyleState m_OnFocused; // 0x50
	private RectOffset m_Border; // 0x58
	private RectOffset m_Padding; // 0x60
	private RectOffset m_Margin; // 0x68
	private RectOffset m_Overflow; // 0x70
	private string m_Name; // 0x78
	internal static bool showKeyboardFocus; // 0x0
	private static GUIStyle s_None; // 0x8

	// Properties
	[NativeProperty("Name", False, 0)]
	internal string rawName { get; set; }
	[NativeProperty("Font", False, 0)]
	public Font font { get; }
	[NativeProperty("m_ImagePosition", False, 1)]
	public ImagePosition imagePosition { get; }
	[NativeProperty("m_Alignment", False, 1)]
	public TextAnchor alignment { get; }
	[NativeProperty("m_WordWrap", False, 1)]
	public bool wordWrap { get; }
	[NativeProperty("m_Clipping", False, 1)]
	public TextClipping clipping { get; }
	[NativeProperty("m_FixedWidth", False, 1)]
	public float fixedWidth { get; }
	[NativeProperty("m_FixedHeight", False, 1)]
	public float fixedHeight { get; }
	[NativeProperty("m_StretchWidth", False, 1)]
	public bool stretchWidth { get; }
	[NativeProperty("m_StretchHeight", False, 1)]
	public bool stretchHeight { get; set; }
	[NativeProperty("m_FontSize", False, 1)]
	public int fontSize { get; }
	[NativeProperty("m_FontStyle", False, 1)]
	public FontStyle fontStyle { get; }
	[NativeProperty("m_RichText", False, 1)]
	public bool richText { get; }
	[NativeProperty("m_ClipOffset", False, 1)]
	internal Vector2 Internal_clipOffset { get; }
	public string name { get; set; }
	public GUIStyleState normal { get; }
	public RectOffset margin { get; }
	public RectOffset padding { get; }
	public float lineHeight { get; }
	public static GUIStyle none { get; }

	// Methods

	// RVA: 0x1E8EB04 Offset: 0x1E8AB04 VA: 0x1E8EB04
	internal string get_rawName() { }

	// RVA: 0x1E8EC8C Offset: 0x1E8AC8C VA: 0x1E8EC8C
	internal void set_rawName(string value) { }

	// RVA: 0x1E8EE84 Offset: 0x1E8AE84 VA: 0x1E8EE84
	public Font get_font() { }

	// RVA: 0x1E8EF6C Offset: 0x1E8AF6C VA: 0x1E8EF6C
	public ImagePosition get_imagePosition() { }

	// RVA: 0x1E8F038 Offset: 0x1E8B038 VA: 0x1E8F038
	public TextAnchor get_alignment() { }

	// RVA: 0x1E8F104 Offset: 0x1E8B104 VA: 0x1E8F104
	public bool get_wordWrap() { }

	// RVA: 0x1E8F1D0 Offset: 0x1E8B1D0 VA: 0x1E8F1D0
	public TextClipping get_clipping() { }

	// RVA: 0x1E8F29C Offset: 0x1E8B29C VA: 0x1E8F29C
	public float get_fixedWidth() { }

	// RVA: 0x1E8F368 Offset: 0x1E8B368 VA: 0x1E8F368
	public float get_fixedHeight() { }

	// RVA: 0x1E8F434 Offset: 0x1E8B434 VA: 0x1E8F434
	public bool get_stretchWidth() { }

	// RVA: 0x1E8F500 Offset: 0x1E8B500 VA: 0x1E8F500
	public bool get_stretchHeight() { }

	// RVA: 0x1E8E2D4 Offset: 0x1E8A2D4 VA: 0x1E8E2D4
	public void set_stretchHeight(bool value) { }

	// RVA: 0x1E8F610 Offset: 0x1E8B610 VA: 0x1E8F610
	public int get_fontSize() { }

	// RVA: 0x1E8F6DC Offset: 0x1E8B6DC VA: 0x1E8F6DC
	public FontStyle get_fontStyle() { }

	// RVA: 0x1E8F7A8 Offset: 0x1E8B7A8 VA: 0x1E8F7A8
	public bool get_richText() { }

	// RVA: 0x1E8F874 Offset: 0x1E8B874 VA: 0x1E8F874
	internal Vector2 get_Internal_clipOffset() { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Create", IsThreadSafe = True)]
	// RVA: 0x1E8F960 Offset: 0x1E8B960 VA: 0x1E8F960
	private static IntPtr Internal_Create(GUIStyle self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_Destroy", IsThreadSafe = True)]
	// RVA: 0x1E8F99C Offset: 0x1E8B99C VA: 0x1E8F99C
	private static void Internal_Destroy(IntPtr self) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetStyleStatePtr", IsThreadSafe = True, HasExplicitThis = True)]
	// RVA: 0x1E8F9D8 Offset: 0x1E8B9D8 VA: 0x1E8F9D8
	private IntPtr GetStyleStatePtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::GetRectOffsetPtr", HasExplicitThis = True)]
	// RVA: 0x1E8FABC Offset: 0x1E8BABC VA: 0x1E8FABC
	private IntPtr GetRectOffsetPtr(int idx) { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_GetTextRectOffset", HasExplicitThis = True)]
	// RVA: 0x1E8FBA0 Offset: 0x1E8BBA0 VA: 0x1E8FBA0
	internal Vector2 Internal_GetTextRectOffset(Rect screenRect, GUIContent content, Vector2 textSize) { }

	[FreeFunction(Name = "GUIStyle::SetDefaultFont")]
	// RVA: 0x1E8CE28 Offset: 0x1E88E28 VA: 0x1E8CE28
	internal static void SetDefaultFont(Font font) { }

	[FreeFunction(Name = "GUIStyle::GetDefaultFont")]
	// RVA: 0x1E8FD14 Offset: 0x1E8BD14 VA: 0x1E8FD14
	internal static Font GetDefaultFont() { }

	[FreeFunction(Name = "GUIStyle_Bindings::Internal_DestroyTextGenerator")]
	// RVA: 0x1E8FDC0 Offset: 0x1E8BDC0 VA: 0x1E8FDC0
	internal static void Internal_DestroyTextGenerator(int meshInfoId) { }

	// RVA: 0x1E8D310 Offset: 0x1E89310 VA: 0x1E8D310
	public void .ctor() { }

	// RVA: 0x1E8FDFC Offset: 0x1E8BDFC VA: 0x1E8FDFC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1E8E294 Offset: 0x1E8A294 VA: 0x1E8E294
	public string get_name() { }

	// RVA: 0x1E8D398 Offset: 0x1E89398 VA: 0x1E8D398
	public void set_name(string value) { }

	// RVA: 0x1E8E374 Offset: 0x1E8A374 VA: 0x1E8E374
	public GUIStyleState get_normal() { }

	// RVA: 0x1E8FEF4 Offset: 0x1E8BEF4 VA: 0x1E8FEF4
	public RectOffset get_margin() { }

	// RVA: 0x1E8FF8C Offset: 0x1E8BF8C VA: 0x1E8FF8C
	public RectOffset get_padding() { }

	// RVA: 0x1E90024 Offset: 0x1E8C024 VA: 0x1E90024
	public float get_lineHeight() { }

	// RVA: 0x1E8B2B8 Offset: 0x1E872B8 VA: 0x1E8B2B8
	public static GUIStyle get_none() { }

	// RVA: 0x1E901FC Offset: 0x1E8C1FC VA: 0x1E901FC
	public Vector2 GetCursorPixelPosition(Rect position, GUIContent content, int cursorStringIndex) { }

	// RVA: 0x1E904D8 Offset: 0x1E8C4D8 VA: 0x1E904D8
	internal Vector2 GetPreferredSize(string content, Rect rect) { }

	// RVA: 0x1E905D4 Offset: 0x1E8C5D4 VA: 0x1E905D4 Slot: 3
	public override string ToString() { }

	[RequiredByNativeCode]
	// RVA: 0x1E90698 Offset: 0x1E8C698 VA: 0x1E90698
	internal static void GetMeshInfo(GUIStyle style, Color color, string content, Rect rect, ref MeshInfoBindings[] meshInfos, ref Vector2 dimensions, ref int generationId) { }

	[RequiredByNativeCode]
	// RVA: 0x1E90A84 Offset: 0x1E8CA84 VA: 0x1E90A84
	internal static void GetDimensions(GUIStyle style, Color color, string content, Rect rect, ref Vector2 dimensions) { }

	[RequiredByNativeCode]
	// RVA: 0x1E90AB4 Offset: 0x1E8CAB4 VA: 0x1E90AB4
	internal static void GetLineHeight(GUIStyle style, ref float lineHeight) { }

	[RequiredByNativeCode]
	// RVA: 0x1E90AD4 Offset: 0x1E8CAD4 VA: 0x1E90AD4
	internal static void EmptyManagedCache() { }

	// RVA: 0x1E90BC4 Offset: 0x1E8CBC4 VA: 0x1E90BC4
	private static void .cctor() { }

	// RVA: 0x1E8EC48 Offset: 0x1E8AC48 VA: 0x1E8EC48
	private static void get_rawName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x1E8EE40 Offset: 0x1E8AE40 VA: 0x1E8EE40
	private static void set_rawName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	// RVA: 0x1E8EF30 Offset: 0x1E8AF30 VA: 0x1E8EF30
	private static IntPtr get_font_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E8EFFC Offset: 0x1E8AFFC VA: 0x1E8EFFC
	private static ImagePosition get_imagePosition_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E8F0C8 Offset: 0x1E8B0C8 VA: 0x1E8F0C8
	private static TextAnchor get_alignment_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E8F194 Offset: 0x1E8B194 VA: 0x1E8F194
	private static bool get_wordWrap_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E8F260 Offset: 0x1E8B260 VA: 0x1E8F260
	private static TextClipping get_clipping_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E8F32C Offset: 0x1E8B32C VA: 0x1E8F32C
	private static float get_fixedWidth_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E8F3F8 Offset: 0x1E8B3F8 VA: 0x1E8F3F8
	private static float get_fixedHeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E8F4C4 Offset: 0x1E8B4C4 VA: 0x1E8F4C4
	private static bool get_stretchWidth_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E8F590 Offset: 0x1E8B590 VA: 0x1E8F590
	private static bool get_stretchHeight_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E8F5CC Offset: 0x1E8B5CC VA: 0x1E8F5CC
	private static void set_stretchHeight_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1E8F6A0 Offset: 0x1E8B6A0 VA: 0x1E8F6A0
	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E8F76C Offset: 0x1E8B76C VA: 0x1E8F76C
	private static FontStyle get_fontStyle_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E8F838 Offset: 0x1E8B838 VA: 0x1E8F838
	private static bool get_richText_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E8F91C Offset: 0x1E8B91C VA: 0x1E8F91C
	private static void get_Internal_clipOffset_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x1E8FA78 Offset: 0x1E8BA78 VA: 0x1E8FA78
	private static IntPtr GetStyleStatePtr_Injected(IntPtr _unity_self, int idx) { }

	// RVA: 0x1E8FB5C Offset: 0x1E8BB5C VA: 0x1E8FB5C
	private static IntPtr GetRectOffsetPtr_Injected(IntPtr _unity_self, int idx) { }

	// RVA: 0x1E8FC6C Offset: 0x1E8BC6C VA: 0x1E8FC6C
	private static void Internal_GetTextRectOffset_Injected(IntPtr _unity_self, in Rect screenRect, GUIContent content, in Vector2 textSize, out Vector2 ret) { }

	// RVA: 0x1E8FCD8 Offset: 0x1E8BCD8 VA: 0x1E8FCD8
	private static void SetDefaultFont_Injected(IntPtr font) { }

	// RVA: 0x1E8FD98 Offset: 0x1E8BD98 VA: 0x1E8FD98
	private static IntPtr GetDefaultFont_Injected() { }
}

// Namespace: UnityEngine
public enum ImagePosition // TypeDefIndex: 7759
{
	// Fields
	public int value__; // 0x0
	public const ImagePosition ImageLeft = 0;
	public const ImagePosition ImageAbove = 1;
	public const ImagePosition ImageOnly = 2;
	public const ImagePosition TextOnly = 3;
}

// Namespace: UnityEngine
public enum TextClipping // TypeDefIndex: 7760
{
	// Fields
	public int value__; // 0x0
	public const TextClipping Overflow = 0;
	public const TextClipping Clip = 1;
	public const TextClipping Ellipsis = 2;
}

// Namespace: UnityEngine
[Usage(64)]
public class GUITargetAttribute : Attribute // TypeDefIndex: 7761
{
	// Fields
	internal int displayMask; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E90C24 Offset: 0x1E8CC24 VA: 0x1E90C24
	private static int GetGUITargetAttrValue(Type klass, string methodName) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputManager.h")]
[NativeHeader("Runtime/Input/InputBindings.h")]
[NativeHeader("Runtime/Camera/RenderLayers/GUITexture.h")]
[NativeHeader("Modules/IMGUI/GUIManager.h")]
[NativeHeader("Modules/IMGUI/GUIUtility.h")]
[NativeHeader("Runtime/Utilities/CopyPaste.h")]
public class GUIUtility // TypeDefIndex: 7762
{
	// Fields
	internal static int s_ControlCount; // 0x0
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static int s_SkinMode; // 0x4
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static int s_OriginalID; // 0x8
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static Action takeCapture; // 0x10
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static Action releaseCapture; // 0x18
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static Func<int, IntPtr, bool> processEvent; // 0x20
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static Func<Exception, bool> endContainerGUIFromException; // 0x28
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal static Action guiChanged; // 0x30
	internal static Action<EventType, KeyCode, EventModifiers> beforeEventProcessed; // 0x38
	private static Event m_Event; // 0x40
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static bool <guiIsExiting>k__BackingField; // 0x48

	// Properties
	[NativeProperty("GetGUIState().m_PixelsPerPoint", True, 1)]
	internal static float pixelsPerPoint { get; }
	[NativeProperty("GetGUIState().m_OnGUIDepth", True, 1)]
	internal static int guiDepth { get; }
	public static string systemCopyBuffer { get; set; }
	internal static bool guiIsExiting { set; }

	// Methods

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1E8C4D8 Offset: 0x1E884D8 VA: 0x1E8C4D8
	internal static float get_pixelsPerPoint() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1E90DB4 Offset: 0x1E8CDB4 VA: 0x1E90DB4
	internal static int get_guiDepth() { }

	[FreeFunction("GetCopyBuffer")]
	// RVA: 0x1E90DDC Offset: 0x1E8CDDC VA: 0x1E90DDC
	public static string get_systemCopyBuffer() { }

	[FreeFunction("SetCopyBuffer")]
	// RVA: 0x1E90F14 Offset: 0x1E8CF14 VA: 0x1E90F14
	public static void set_systemCopyBuffer(string value) { }

	// RVA: 0x1E910DC Offset: 0x1E8D0DC VA: 0x1E910DC
	private static object Internal_GetDefaultSkin(int skinMode) { }

	// RVA: 0x1E91118 Offset: 0x1E8D118 VA: 0x1E91118
	private static void Internal_ExitGUI() { }

	[RequiredByNativeCode]
	// RVA: 0x1E91140 Offset: 0x1E8D140 VA: 0x1E91140
	private static void MarkGUIChanged() { }

	[CompilerGenerated]
	// RVA: 0x1E911B4 Offset: 0x1E8D1B4 VA: 0x1E911B4
	internal static void set_guiIsExiting(bool value) { }

	[RequiredByNativeCode]
	// RVA: 0x1E91214 Offset: 0x1E8D214 VA: 0x1E91214
	internal static void TakeCapture() { }

	[RequiredByNativeCode]
	// RVA: 0x1E91288 Offset: 0x1E8D288 VA: 0x1E91288
	internal static void RemoveCapture() { }

	// RVA: 0x1E8A8FC Offset: 0x1E868FC VA: 0x1E8A8FC
	internal static GUISkin GetDefaultSkin() { }

	[RequiredByNativeCode]
	// RVA: 0x1E912FC Offset: 0x1E8D2FC VA: 0x1E912FC
	internal static void ProcessEvent(int instanceID, IntPtr nativeEventPtr, out bool result) { }

	[RequiredByNativeCode]
	// RVA: 0x1E914F0 Offset: 0x1E8D4F0 VA: 0x1E914F0
	internal static void BeginGUI(int skinMode, int instanceID, int useGUILayout) { }

	[RequiredByNativeCode]
	// RVA: 0x1E916C8 Offset: 0x1E8D6C8 VA: 0x1E916C8
	internal static void DestroyGUI(int instanceID) { }

	[RequiredByNativeCode]
	// RVA: 0x1E91720 Offset: 0x1E8D720 VA: 0x1E91720
	internal static void EndGUI(int layoutType) { }

	[RequiredByNativeCode]
	// RVA: 0x1E918F4 Offset: 0x1E8D8F4 VA: 0x1E918F4
	internal static bool EndGUIFromException(Exception exception) { }

	[RequiredByNativeCode]
	// RVA: 0x1E919BC Offset: 0x1E8D9BC VA: 0x1E919BC
	internal static bool EndContainerGUIFromException(Exception exception) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1E9159C Offset: 0x1E8D59C VA: 0x1E9159C
	internal static void ResetGlobalState() { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1E91A5C Offset: 0x1E8DA5C VA: 0x1E91A5C
	internal static bool IsExitGUIException(Exception exception) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	// RVA: 0x1E91968 Offset: 0x1E8D968 VA: 0x1E91968
	internal static bool ShouldRethrowException(Exception exception) { }

	// RVA: 0x1E8A6F0 Offset: 0x1E866F0 VA: 0x1E8A6F0
	internal static void CheckOnGUI() { }

	// RVA: 0x1E91AE0 Offset: 0x1E8DAE0 VA: 0x1E91AE0
	private static void .cctor() { }

	// RVA: 0x1E90ED8 Offset: 0x1E8CED8 VA: 0x1E90ED8
	private static void get_systemCopyBuffer_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x1E910A0 Offset: 0x1E8D0A0 VA: 0x1E910A0
	private static void set_systemCopyBuffer_Injected(ref ManagedSpanWrapper value) { }
}

// Namespace: UnityEngine
public sealed class ExitGUIException : Exception // TypeDefIndex: 7763
{}

// Namespace: 
internal class IMGUITextHandle.TextHandleTuple // TypeDefIndex: 7764
{
	// Fields
	public float lastTimeUsed; // 0x10
	public int hashCode; // 0x14

	// Methods

	// RVA: 0x1E924E0 Offset: 0x1E8E4E0 VA: 0x1E924E0
	public void .ctor(float lastTimeUsed, int hashCode) { }
}

// Namespace: UnityEngine
internal class IMGUITextHandle : TextHandle // TypeDefIndex: 7765
{
	// Fields
	internal LinkedListNode<IMGUITextHandle.TextHandleTuple> tuple; // 0xB0
	private static Dictionary<int, IMGUITextHandle> textHandles; // 0x0
	private static LinkedList<IMGUITextHandle.TextHandleTuple> textHandlesTuple; // 0x8
	private static float lastCleanupTime; // 0x10
	private static int newHandlesSinceCleanup; // 0x14
	internal bool isCachedOnNative; // 0xB8

	// Methods

	// RVA: 0x1E90B20 Offset: 0x1E8CB20 VA: 0x1E90B20
	internal static void EmptyManagedCache() { }

	// RVA: 0x1E903AC Offset: 0x1E8C3AC VA: 0x1E903AC
	internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor) { }

	// RVA: 0x1E9095C Offset: 0x1E8C95C VA: 0x1E9095C
	internal static IMGUITextHandle GetTextHandle(GUIStyle style, Rect position, string content, Color32 textColor, ref bool isCached) { }

	// RVA: 0x1E92244 Offset: 0x1E8E244 VA: 0x1E92244
	private static bool ShouldCleanup(float currentTime, float lastTime, float cleanupThreshold) { }

	// RVA: 0x1E9225C Offset: 0x1E8E25C VA: 0x1E9225C
	private static void ClearUnusedTextHandles() { }

	// RVA: 0x1E91ED8 Offset: 0x1E8DED8 VA: 0x1E91ED8
	private static IMGUITextHandle GetTextHandle(TextGenerationSettings settings, bool isCalledFromNative, ref bool isCached) { }

	// RVA: 0x1E900FC Offset: 0x1E8C0FC VA: 0x1E900FC
	internal static float GetLineHeight(GUIStyle style) { }

	// RVA: 0x1E905CC Offset: 0x1E8C5CC VA: 0x1E905CC
	internal Vector2 GetPreferredSize() { }

	// RVA: 0x1E91B5C Offset: 0x1E8DB5C VA: 0x1E91B5C
	private static void ConvertGUIStyleToGenerationSettings(TextGenerationSettings settings, GUIStyle style, Color textColor, string text, Rect rect) { }

	// RVA: 0x1E925DC Offset: 0x1E8E5DC VA: 0x1E925DC
	private static TextOverflowMode LegacyClippingToNewOverflow(TextClipping clipping) { }

	// RVA: 0x1E92484 Offset: 0x1E8E484 VA: 0x1E92484
	public void .ctor() { }

	// RVA: 0x1E925F4 Offset: 0x1E8E5F4 VA: 0x1E925F4
	private static void .cctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal class GUILayoutEntry // TypeDefIndex: 7766
{
	// Fields
	public float minWidth; // 0x10
	public float maxWidth; // 0x14
	public float minHeight; // 0x18
	public float maxHeight; // 0x1C
	public Rect rect; // 0x20
	public int stretchWidth; // 0x30
	public int stretchHeight; // 0x34
	public bool consideredForMargin; // 0x38
	private GUIStyle m_Style; // 0x40
	internal static Rect kDummyRect; // 0x0
	protected static int indent; // 0x10

	// Properties
	public GUIStyle style { get; set; }
	public virtual int marginLeft { get; }
	public virtual int marginRight { get; }
	public virtual int marginTop { get; }
	public virtual int marginBottom { get; }
	public int marginHorizontal { get; }
	public int marginVertical { get; }

	// Methods

	// RVA: 0x1E926F4 Offset: 0x1E8E6F4 VA: 0x1E926F4
	public GUIStyle get_style() { }

	// RVA: 0x1E8C4A4 Offset: 0x1E884A4 VA: 0x1E8C4A4
	public void set_style(GUIStyle value) { }

	// RVA: 0x1E926FC Offset: 0x1E8E6FC VA: 0x1E926FC Slot: 4
	public virtual int get_marginLeft() { }

	// RVA: 0x1E92720 Offset: 0x1E8E720 VA: 0x1E92720 Slot: 5
	public virtual int get_marginRight() { }

	// RVA: 0x1E92744 Offset: 0x1E8E744 VA: 0x1E92744 Slot: 6
	public virtual int get_marginTop() { }

	// RVA: 0x1E92768 Offset: 0x1E8E768 VA: 0x1E92768 Slot: 7
	public virtual int get_marginBottom() { }

	// RVA: 0x1E9278C Offset: 0x1E8E78C VA: 0x1E9278C
	public int get_marginHorizontal() { }

	// RVA: 0x1E927C8 Offset: 0x1E8E7C8 VA: 0x1E927C8
	public int get_marginVertical() { }

	// RVA: 0x1E92804 Offset: 0x1E8E804 VA: 0x1E92804
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x1E928F4 Offset: 0x1E8E8F4 VA: 0x1E928F4 Slot: 8
	public virtual void CalcWidth() { }

	// RVA: 0x1E928F8 Offset: 0x1E8E8F8 VA: 0x1E928F8 Slot: 9
	public virtual void CalcHeight() { }

	// RVA: 0x1E928FC Offset: 0x1E8E8FC VA: 0x1E928FC Slot: 10
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x1E92908 Offset: 0x1E8E908 VA: 0x1E92908 Slot: 11
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x1E92914 Offset: 0x1E8E914 VA: 0x1E92914 Slot: 12
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x1E92998 Offset: 0x1E8E998 VA: 0x1E92998 Slot: 13
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x1E92C64 Offset: 0x1E8EC64 VA: 0x1E92C64 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E931CC Offset: 0x1E8F1CC VA: 0x1E931CC
	private static void .cctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule", "UnityEditor.CoreModule" })]
internal class GUILayoutGroup : GUILayoutEntry // TypeDefIndex: 7767
{
	// Fields
	public List<GUILayoutEntry> entries; // 0x48
	public bool isVertical; // 0x50
	public bool resetCoords; // 0x51
	public float spacing; // 0x54
	public bool sameSize; // 0x58
	public bool isWindow; // 0x59
	public int windowID; // 0x5C
	private int m_Cursor; // 0x60
	protected int m_StretchableCountX; // 0x64
	protected int m_StretchableCountY; // 0x68
	protected bool m_UserSpecifiedWidth; // 0x6C
	protected bool m_UserSpecifiedHeight; // 0x6D
	protected float m_ChildMinWidth; // 0x70
	protected float m_ChildMaxWidth; // 0x74
	protected float m_ChildMinHeight; // 0x78
	protected float m_ChildMaxHeight; // 0x7C
	protected int m_MarginLeft; // 0x80
	protected int m_MarginRight; // 0x84
	protected int m_MarginTop; // 0x88
	protected int m_MarginBottom; // 0x8C
	private static readonly GUILayoutEntry none; // 0x0

	// Properties
	public override int marginLeft { get; }
	public override int marginRight { get; }
	public override int marginTop { get; }
	public override int marginBottom { get; }

	// Methods

	// RVA: 0x1E93228 Offset: 0x1E8F228 VA: 0x1E93228 Slot: 4
	public override int get_marginLeft() { }

	// RVA: 0x1E93230 Offset: 0x1E8F230 VA: 0x1E93230 Slot: 5
	public override int get_marginRight() { }

	// RVA: 0x1E93238 Offset: 0x1E8F238 VA: 0x1E93238 Slot: 6
	public override int get_marginTop() { }

	// RVA: 0x1E93240 Offset: 0x1E8F240 VA: 0x1E93240 Slot: 7
	public override int get_marginBottom() { }

	// RVA: 0x1E8C388 Offset: 0x1E88388 VA: 0x1E8C388
	public void .ctor() { }

	// RVA: 0x1E93248 Offset: 0x1E8F248 VA: 0x1E93248 Slot: 13
	public override void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x1E93340 Offset: 0x1E8F340 VA: 0x1E93340 Slot: 12
	protected override void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x1E8CA38 Offset: 0x1E88A38 VA: 0x1E8CA38
	public void ResetCursor() { }

	// RVA: 0x1E933B4 Offset: 0x1E8F3B4 VA: 0x1E933B4 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x1E939D0 Offset: 0x1E8F9D0 VA: 0x1E939D0 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x1E941D8 Offset: 0x1E901D8 VA: 0x1E941D8 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x1E94744 Offset: 0x1E90744 VA: 0x1E94744 Slot: 11
	public override void SetVertical(float y, float height) { }

	// RVA: 0x1E94F5C Offset: 0x1E90F5C VA: 0x1E94F5C Slot: 3
	public override string ToString() { }

	// RVA: 0x1E95304 Offset: 0x1E91304 VA: 0x1E95304
	private static void .cctor() { }
}

// Namespace: UnityEngine
internal sealed class GUIScrollGroup : GUILayoutGroup // TypeDefIndex: 7768
{
	// Fields
	public float calcMinWidth; // 0x90
	public float calcMaxWidth; // 0x94
	public float calcMinHeight; // 0x98
	public float calcMaxHeight; // 0x9C
	public float clientWidth; // 0xA0
	public float clientHeight; // 0xA4
	public bool allowHorizontalScroll; // 0xA8
	public bool allowVerticalScroll; // 0xA9
	public bool needsHorizontalScrollbar; // 0xAA
	public bool needsVerticalScrollbar; // 0xAB
	public GUIStyle horizontalScrollbar; // 0xB0
	public GUIStyle verticalScrollbar; // 0xB8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E953D8 Offset: 0x1E913D8 VA: 0x1E953D8
	public void .ctor() { }

	// RVA: 0x1E95434 Offset: 0x1E91434 VA: 0x1E95434 Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x1E954A8 Offset: 0x1E914A8 VA: 0x1E954A8 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x1E95578 Offset: 0x1E91578 VA: 0x1E95578 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x1E95640 Offset: 0x1E91640 VA: 0x1E95640 Slot: 11
	public override void SetVertical(float y, float height) { }
}

// Namespace: UnityEngine
internal class RuntimeTextSettings : TextSettings // TypeDefIndex: 7769
{
	// Fields
	private static RuntimeTextSettings s_DefaultTextSettings; // 0x0
	private static List<FontAsset> s_FallbackOSFontAssetIMGUIInternal; // 0x8

	// Properties
	internal static RuntimeTextSettings defaultTextSettings { get; }

	// Methods

	// RVA: 0x1E92518 Offset: 0x1E8E518 VA: 0x1E92518
	internal static RuntimeTextSettings get_defaultTextSettings() { }

	// RVA: 0x1E95794 Offset: 0x1E91794 VA: 0x1E95794 Slot: 4
	internal override List<FontAsset> GetStaticFallbackOSFontAsset() { }

	// RVA: 0x1E957DC Offset: 0x1E917DC VA: 0x1E957DC Slot: 5
	internal override void SetStaticFallbackOSFontAsset(List<FontAsset> fontAssets) { }

	// RVA: 0x1E9582C Offset: 0x1E9182C VA: 0x1E9582C
	public void .ctor() { }
}

// Namespace: UnityEngine
internal class ScrollViewState // TypeDefIndex: 7770
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E95834 Offset: 0x1E91834 VA: 0x1E95834
	public void .ctor() { }
}

// Namespace: UnityEngine
internal class SliderState // TypeDefIndex: 7771
{
	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E9583C Offset: 0x1E9183C VA: 0x1E9583C
	public void .ctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
internal class TextEditingUtilities // TypeDefIndex: 7772
{
	// Fields
	private TextSelectingUtilities m_TextSelectingUtility; // 0x10
	internal TextHandle textHandle; // 0x18
	private int m_CursorIndexSavedState; // 0x20
	internal Action OnTextChanged; // 0x28
	public bool multiline; // 0x30
	private string m_Text; // 0x38

	// Properties
	public string text { get; }

	// Methods

	// RVA: 0x1E95844 Offset: 0x1E91844 VA: 0x1E95844
	public string get_text() { }

	// RVA: 0x1E9584C Offset: 0x1E9184C VA: 0x1E9584C
	internal void SetTextWithoutNotify(string value) { }

	// RVA: 0x1E95854 Offset: 0x1E91854 VA: 0x1E95854
	public void .ctor(TextSelectingUtilities selectingUtilities, TextHandle textHandle, string text) { }
}

// Namespace: 
public enum TextEditor.DblClickSnapping // TypeDefIndex: 7773
{
	// Fields
	public byte value__; // 0x0
	public const TextEditor.DblClickSnapping WORDS = 0;
	public const TextEditor.DblClickSnapping PARAGRAPHS = 1;
}

// Namespace: UnityEngine
public class TextEditor // TypeDefIndex: 7774
{
	// Fields
	private readonly GUIContent m_Content; // 0x10
	private TextSelectingUtilities m_TextSelecting; // 0x18
	internal TextEditingUtilities m_TextEditing; // 0x20
	internal IMGUITextHandle m_TextHandle; // 0x28
	public TouchScreenKeyboard keyboardOnScreen; // 0x30
	public int controlID; // 0x38
	public GUIStyle style; // 0x40
	[Obsolete("'hasHorizontalCursorPos' has been deprecated. Changes to this member will not be observed. Use 'hasHorizontalCursor' instead.", True)]
	public bool hasHorizontalCursorPos; // 0x48
	public bool isPasswordField; // 0x49
	public Vector2 scrollOffset; // 0x4C
	private string m_TextWithWhitespace; // 0x58
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Rect <position>k__BackingField; // 0x60
	public Vector2 graphicalCursorPos; // 0x70
	private Vector2 lastCursorPos; // 0x78
	private Vector2 previousContentSize; // 0x80

	// Properties
	public bool showCursor { get; }
	public string text { get; set; }
	internal string textWithWhitespace { get; set; }
	public Rect position { get; }

	// Methods

	// RVA: 0x1E958C0 Offset: 0x1E918C0 VA: 0x1E958C0
	public bool get_showCursor() { }

	// RVA: 0x1E958D8 Offset: 0x1E918D8 VA: 0x1E958D8
	public string get_text() { }

	// RVA: 0x1E958F0 Offset: 0x1E918F0 VA: 0x1E958F0
	public void set_text(string value) { }

	// RVA: 0x1E95B78 Offset: 0x1E91B78 VA: 0x1E95B78
	internal string get_textWithWhitespace() { }

	// RVA: 0x1E959C0 Offset: 0x1E919C0 VA: 0x1E959C0
	internal void set_textWithWhitespace(string value) { }

	[CompilerGenerated]
	// RVA: 0x1E95BE8 Offset: 0x1E91BE8 VA: 0x1E95BE8
	public Rect get_position() { }

	[RequiredByNativeCode]
	// RVA: 0x1E95BF4 Offset: 0x1E91BF4 VA: 0x1E95BF4
	public void .ctor() { }

	// RVA: 0x1E96084 Offset: 0x1E92084 VA: 0x1E96084
	private void OnTextChangedHandle() { }

	// RVA: 0x1E960E8 Offset: 0x1E920E8 VA: 0x1E960E8
	private void OnContentTextChangedHandle() { }

	// RVA: 0x1E95A40 Offset: 0x1E91A40 VA: 0x1E95A40
	internal void UpdateTextHandle() { }

	[VisibleToOtherModules]
	// RVA: 0x1E9611C Offset: 0x1E9211C VA: 0x1E9611C
	internal void UpdateScrollOffset() { }

	// RVA: 0x1E964F4 Offset: 0x1E924F4 VA: 0x1E964F4 Slot: 4
	internal virtual void OnCursorIndexChange() { }

	// RVA: 0x1E964F8 Offset: 0x1E924F8 VA: 0x1E964F8 Slot: 5
	internal virtual void OnSelectIndexChange() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule" })]
internal class TextSelectingUtilities // TypeDefIndex: 7775
{
	// Fields
	public TextEditor.DblClickSnapping dblClickSnap; // 0x10
	public int iAltCursorPos; // 0x14
	public bool hasHorizontalCursorPos; // 0x18
	private bool m_bJustSelected; // 0x19
	private bool m_MouseDragSelectsWholeWords; // 0x1A
	private int m_DblClickInitPosStart; // 0x1C
	private int m_DblClickInitPosEnd; // 0x20
	public TextHandle textHandle; // 0x28
	private bool m_RevealCursor; // 0x30
	private int m_CursorIndex; // 0x34
	internal int m_SelectIndex; // 0x38
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal Action OnCursorIndexChange; // 0x40
	[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule" })]
	internal Action OnSelectIndexChange; // 0x48

	// Properties
	public bool revealCursor { get; }
	internal int cursorIndexNoValidation { get; }

	// Methods

	// RVA: 0x1E964FC Offset: 0x1E924FC VA: 0x1E964FC
	public bool get_revealCursor() { }

	// RVA: 0x1E964EC Offset: 0x1E924EC VA: 0x1E964EC
	internal int get_cursorIndexNoValidation() { }

	// RVA: 0x1E96034 Offset: 0x1E92034 VA: 0x1E96034
	public void .ctor(TextHandle textHandle) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 7776
{}

// Namespace: UnityEngine
public class WWWForm // TypeDefIndex: 7951
{
	// Fields
	private static byte[] dDash; // 0x0
	private static byte[] crlf; // 0x8
	private static byte[] contentTypeHeader; // 0x10
	private static byte[] dispositionHeader; // 0x18
	private static byte[] endQuote; // 0x20
	private static byte[] fileNameField; // 0x28
	private static byte[] ampersand; // 0x30
	private static byte[] equal; // 0x38

	// Properties
	internal static Encoding DefaultEncoding { get; }

	// Methods

	// RVA: 0x1F23D5C Offset: 0x1F1FD5C VA: 0x1F23D5C
	internal static Encoding get_DefaultEncoding() { }

	// RVA: 0x1F23D64 Offset: 0x1F1FD64 VA: 0x1F23D64
	private static void .cctor() { }
}

// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UnityWebRequestWWWModule" })]
internal class WWWTranscoder // TypeDefIndex: 7952
{
	// Fields
	private static byte[] ucHexChars; // 0x0
	private static byte[] lcHexChars; // 0x8
	private static byte urlEscapeChar; // 0x10
	private static byte[] urlSpace; // 0x18
	private static byte[] dataSpace; // 0x20
	private static byte[] urlForbidden; // 0x28
	private static byte qpEscapeChar; // 0x30
	private static byte[] qpSpace; // 0x38
	private static byte[] qpForbidden; // 0x40

	// Methods

	// RVA: 0x1F23FFC Offset: 0x1F1FFFC VA: 0x1F23FFC
	private static byte Hex2Byte(byte[] b, int offset) { }

	// RVA: 0x1F23C5C Offset: 0x1F1FC5C VA: 0x1F23C5C
	public static byte[] URLDecode(byte[] toEncode) { }

	// RVA: 0x1F2438C Offset: 0x1F2038C VA: 0x1F2438C
	private static bool ByteSubArrayEquals(byte[] array, int index, byte[] comperand) { }

	// RVA: 0x1F240B8 Offset: 0x1F200B8 VA: 0x1F240B8
	public static byte[] Decode(byte[] input, byte escapeChar, byte[] space) { }

	// RVA: 0x1F24414 Offset: 0x1F20414 VA: 0x1F24414
	private static void .cctor() { }
}

// Namespace: 
internal static class CertificateHandler.BindingsMarshaller // TypeDefIndex: 7953
{
	// Methods

	// RVA: 0x1F24870 Offset: 0x1F20870 VA: 0x1F24870
	public static IntPtr ConvertToNative(CertificateHandler handler) { }
}

// Namespace: UnityEngine
public interface ICanvasRaycastFilter // TypeDefIndex: 7969
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera);
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/CanvasGroup.h")]
[NativeClass("UI::CanvasGroup")]
public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter // TypeDefIndex: 7970
{
	// Properties
	[NativeProperty("Alpha", False, 0)]
	public float alpha { get; set; }
	[NativeProperty("Interactable", False, 0)]
	public bool interactable { get; }
	[NativeProperty("BlocksRaycasts", False, 0)]
	public bool blocksRaycasts { get; }
	[NativeProperty("IgnoreParentGroups", False, 0)]
	public bool ignoreParentGroups { get; set; }

	// Methods

	// RVA: 0x1EECF20 Offset: 0x1EE8F20 VA: 0x1EECF20
	public float get_alpha() { }

	// RVA: 0x1EECFD4 Offset: 0x1EE8FD4 VA: 0x1EECFD4
	public void set_alpha(float value) { }

	// RVA: 0x1EED0A8 Offset: 0x1EE90A8 VA: 0x1EED0A8
	public bool get_interactable() { }

	// RVA: 0x1EED15C Offset: 0x1EE915C VA: 0x1EED15C
	public bool get_blocksRaycasts() { }

	// RVA: 0x1EED210 Offset: 0x1EE9210 VA: 0x1EED210
	public bool get_ignoreParentGroups() { }

	// RVA: 0x1EED2C4 Offset: 0x1EE92C4 VA: 0x1EED2C4
	public void set_ignoreParentGroups(bool value) { }

	// RVA: 0x1EED388 Offset: 0x1EE9388 VA: 0x1EED388 Slot: 4
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x1EED38C Offset: 0x1EE938C VA: 0x1EED38C
	public void .ctor() { }

	// RVA: 0x1EECF98 Offset: 0x1EE8F98 VA: 0x1EECF98
	private static float get_alpha_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EED05C Offset: 0x1EE905C VA: 0x1EED05C
	private static void set_alpha_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1EED120 Offset: 0x1EE9120 VA: 0x1EED120
	private static bool get_interactable_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EED1D4 Offset: 0x1EE91D4 VA: 0x1EED1D4
	private static bool get_blocksRaycasts_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EED288 Offset: 0x1EE9288 VA: 0x1EED288
	private static bool get_ignoreParentGroups_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EED344 Offset: 0x1EE9344 VA: 0x1EED344
	private static void set_ignoreParentGroups_Injected(IntPtr _unity_self, bool value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/CanvasRenderer.h")]
[NativeClass("UI::CanvasRenderer")]
public sealed class CanvasRenderer : Component // TypeDefIndex: 7971
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <isMask>k__BackingField; // 0x18

	// Properties
	public bool hasPopInstruction { set; }
	public int materialCount { get; set; }
	public int popMaterialCount { set; }
	public int absoluteDepth { get; }
	public bool hasMoved { get; }
	public bool cullTransparentMesh { get; set; }
	[NativeProperty("ShouldCull", False, 0)]
	public bool cull { get; set; }
	public Vector2 clippingSoftness { set; }

	// Methods

	// RVA: 0x1EED394 Offset: 0x1EE9394 VA: 0x1EED394
	public void set_hasPopInstruction(bool value) { }

	// RVA: 0x1EED458 Offset: 0x1EE9458 VA: 0x1EED458
	public int get_materialCount() { }

	// RVA: 0x1EED50C Offset: 0x1EE950C VA: 0x1EED50C
	public void set_materialCount(int value) { }

	// RVA: 0x1EED5D0 Offset: 0x1EE95D0 VA: 0x1EED5D0
	public void set_popMaterialCount(int value) { }

	// RVA: 0x1EED694 Offset: 0x1EE9694 VA: 0x1EED694
	public int get_absoluteDepth() { }

	// RVA: 0x1EED748 Offset: 0x1EE9748 VA: 0x1EED748
	public bool get_hasMoved() { }

	// RVA: 0x1EED7FC Offset: 0x1EE97FC VA: 0x1EED7FC
	public bool get_cullTransparentMesh() { }

	// RVA: 0x1EED8B0 Offset: 0x1EE98B0 VA: 0x1EED8B0
	public void set_cullTransparentMesh(bool value) { }

	// RVA: 0x1EED974 Offset: 0x1EE9974 VA: 0x1EED974
	public bool get_cull() { }

	// RVA: 0x1EEDA28 Offset: 0x1EE9A28 VA: 0x1EEDA28
	public void set_cull(bool value) { }

	// RVA: 0x1EEDAEC Offset: 0x1EE9AEC VA: 0x1EEDAEC
	public void SetColor(Color color) { }

	// RVA: 0x1EEDBC0 Offset: 0x1EE9BC0 VA: 0x1EEDBC0
	public Color GetColor() { }

	// RVA: 0x1EEDC98 Offset: 0x1EE9C98 VA: 0x1EEDC98
	public void EnableRectClipping(Rect rect) { }

	// RVA: 0x1EEDD6C Offset: 0x1EE9D6C VA: 0x1EEDD6C
	public void set_clippingSoftness(Vector2 value) { }

	// RVA: 0x1EEDE34 Offset: 0x1EE9E34 VA: 0x1EEDE34
	public void DisableRectClipping() { }

	// RVA: 0x1EEDEE8 Offset: 0x1EE9EE8 VA: 0x1EEDEE8
	public void SetMaterial(Material material, int index) { }

	// RVA: 0x1EEDFF8 Offset: 0x1EE9FF8 VA: 0x1EEDFF8
	public Material GetMaterial(int index) { }

	// RVA: 0x1EEE0E0 Offset: 0x1EEA0E0 VA: 0x1EEE0E0
	public void SetPopMaterial(Material material, int index) { }

	// RVA: 0x1EEE1F0 Offset: 0x1EEA1F0 VA: 0x1EEE1F0
	public void SetTexture(Texture texture) { }

	// RVA: 0x1EEE2E8 Offset: 0x1EEA2E8 VA: 0x1EEE2E8
	public void SetAlphaTexture(Texture texture) { }

	// RVA: 0x1EEE3E0 Offset: 0x1EEA3E0 VA: 0x1EEE3E0
	public void SetMesh(Mesh mesh) { }

	// RVA: 0x1EEE4D8 Offset: 0x1EEA4D8 VA: 0x1EEE4D8
	public void Clear() { }

	// RVA: 0x1EEE58C Offset: 0x1EEA58C VA: 0x1EEE58C
	public void SetMaterial(Material material, Texture texture) { }

	// RVA: 0x1EEE630 Offset: 0x1EEA630 VA: 0x1EEE630
	public Material GetMaterial() { }

	// RVA: 0x1EEE638 Offset: 0x1EEA638 VA: 0x1EEE638
	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x1EEE7E8 Offset: 0x1EEA7E8 VA: 0x1EEE7E8
	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<int> indices) { }

	// RVA: 0x1EEE920 Offset: 0x1EEA920 VA: 0x1EEE920
	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x1EEE7A4 Offset: 0x1EEA7A4 VA: 0x1EEE7A4
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x1EEE708 Offset: 0x1EEA708 VA: 0x1EEE708
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

	[StaticAccessor("UI", 2)]
	// RVA: 0x1EEE884 Offset: 0x1EEA884 VA: 0x1EEE884
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	// RVA: 0x1EEE9BC Offset: 0x1EEA9BC VA: 0x1EEE9BC
	public void .ctor() { }

	// RVA: 0x1EED414 Offset: 0x1EE9414 VA: 0x1EED414
	private static void set_hasPopInstruction_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1EED4D0 Offset: 0x1EE94D0 VA: 0x1EED4D0
	private static int get_materialCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EED58C Offset: 0x1EE958C VA: 0x1EED58C
	private static void set_materialCount_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1EED650 Offset: 0x1EE9650 VA: 0x1EED650
	private static void set_popMaterialCount_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1EED70C Offset: 0x1EE970C VA: 0x1EED70C
	private static int get_absoluteDepth_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EED7C0 Offset: 0x1EE97C0 VA: 0x1EED7C0
	private static bool get_hasMoved_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EED874 Offset: 0x1EE9874 VA: 0x1EED874
	private static bool get_cullTransparentMesh_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EED930 Offset: 0x1EE9930 VA: 0x1EED930
	private static void set_cullTransparentMesh_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1EED9EC Offset: 0x1EE99EC VA: 0x1EED9EC
	private static bool get_cull_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EEDAA8 Offset: 0x1EE9AA8 VA: 0x1EEDAA8
	private static void set_cull_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1EEDB7C Offset: 0x1EE9B7C VA: 0x1EEDB7C
	private static void SetColor_Injected(IntPtr _unity_self, in Color color) { }

	// RVA: 0x1EEDC54 Offset: 0x1EE9C54 VA: 0x1EEDC54
	private static void GetColor_Injected(IntPtr _unity_self, out Color ret) { }

	// RVA: 0x1EEDD28 Offset: 0x1EE9D28 VA: 0x1EEDD28
	private static void EnableRectClipping_Injected(IntPtr _unity_self, in Rect rect) { }

	// RVA: 0x1EEDDF0 Offset: 0x1EE9DF0 VA: 0x1EEDDF0
	private static void set_clippingSoftness_Injected(IntPtr _unity_self, in Vector2 value) { }

	// RVA: 0x1EEDEAC Offset: 0x1EE9EAC VA: 0x1EEDEAC
	private static void DisableRectClipping_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EEDFA4 Offset: 0x1EE9FA4 VA: 0x1EEDFA4
	private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr material, int index) { }

	// RVA: 0x1EEE09C Offset: 0x1EEA09C VA: 0x1EEE09C
	private static IntPtr GetMaterial_Injected(IntPtr _unity_self, int index) { }

	// RVA: 0x1EEE19C Offset: 0x1EEA19C VA: 0x1EEE19C
	private static void SetPopMaterial_Injected(IntPtr _unity_self, IntPtr material, int index) { }

	// RVA: 0x1EEE2A4 Offset: 0x1EEA2A4 VA: 0x1EEE2A4
	private static void SetTexture_Injected(IntPtr _unity_self, IntPtr texture) { }

	// RVA: 0x1EEE39C Offset: 0x1EEA39C VA: 0x1EEE39C
	private static void SetAlphaTexture_Injected(IntPtr _unity_self, IntPtr texture) { }

	// RVA: 0x1EEE494 Offset: 0x1EEA494 VA: 0x1EEE494
	private static void SetMesh_Injected(IntPtr _unity_self, IntPtr mesh) { }

	// RVA: 0x1EEE550 Offset: 0x1EEA550 VA: 0x1EEE550
	private static void Clear_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/Canvas.h")]
[StaticAccessor("UI", 2)]
[NativeHeader("Runtime/Transform/RectTransform.h")]
[NativeHeader("Modules/UI/RectTransformUtil.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
public sealed class RectTransformUtility // TypeDefIndex: 7972
{
	// Fields
	private static readonly Vector3[] s_Corners; // 0x0

	// Methods

	// RVA: 0x1EEE9C4 Offset: 0x1EEA9C4 VA: 0x1EEE9C4
	public static Vector2 PixelAdjustPoint(Vector2 point, Transform elementTransform, Canvas canvas) { }

	// RVA: 0x1EEEB1C Offset: 0x1EEAB1C VA: 0x1EEEB1C
	public static Rect PixelAdjustRect(RectTransform rectTransform, Canvas canvas) { }

	// RVA: 0x1EEEC68 Offset: 0x1EEAC68 VA: 0x1EEEC68
	private static bool PointInRectangle(Vector2 screenPoint, RectTransform rect, Camera cam, Vector4 offset) { }

	// RVA: 0x1EEEDC4 Offset: 0x1EEADC4 VA: 0x1EEEDC4
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam) { }

	// RVA: 0x1EEEE98 Offset: 0x1EEAE98 VA: 0x1EEEE98
	public static bool RectangleContainsScreenPoint(RectTransform rect, Vector2 screenPoint, Camera cam, Vector4 offset) { }

	// RVA: 0x1EEEF44 Offset: 0x1EEAF44 VA: 0x1EEEF44
	public static bool ScreenPointToWorldPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector3 worldPoint) { }

	// RVA: 0x1EEF530 Offset: 0x1EEB530 VA: 0x1EEF530
	public static bool ScreenPointToLocalPointInRectangle(RectTransform rect, Vector2 screenPoint, Camera cam, out Vector2 localPoint) { }

	// RVA: 0x1EEF35C Offset: 0x1EEB35C VA: 0x1EEF35C
	public static Ray ScreenPointToRay(Camera cam, Vector2 screenPos) { }

	// RVA: 0x1EEF62C Offset: 0x1EEB62C VA: 0x1EEF62C
	public static Vector2 WorldToScreenPoint(Camera cam, Vector3 worldPoint) { }

	// RVA: 0x1EEF6DC Offset: 0x1EEB6DC VA: 0x1EEF6DC
	public static void FlipLayoutOnAxis(RectTransform rect, int axis, bool keepPositioning, bool recursive) { }

	// RVA: 0x1EEF9D0 Offset: 0x1EEB9D0 VA: 0x1EEF9D0
	public static void FlipLayoutAxes(RectTransform rect, bool keepPositioning, bool recursive) { }

	// RVA: 0x1EEFC2C Offset: 0x1EEBC2C VA: 0x1EEFC2C
	private static Vector2 GetTransposed(Vector2 input) { }

	// RVA: 0x1EEFC3C Offset: 0x1EEBC3C VA: 0x1EEFC3C
	private static void .cctor() { }

	// RVA: 0x1EEEAC0 Offset: 0x1EEAAC0 VA: 0x1EEEAC0
	private static void PixelAdjustPoint_Injected(in Vector2 point, IntPtr elementTransform, IntPtr canvas, out Vector2 ret) { }

	// RVA: 0x1EEEC14 Offset: 0x1EEAC14 VA: 0x1EEEC14
	private static void PixelAdjustRect_Injected(IntPtr rectTransform, IntPtr canvas, out Rect ret) { }

	// RVA: 0x1EEED68 Offset: 0x1EEAD68 VA: 0x1EEED68
	private static bool PointInRectangle_Injected(in Vector2 screenPoint, IntPtr rect, IntPtr cam, in Vector4 offset) { }
}

// Namespace: UnityEngine
public enum RenderMode // TypeDefIndex: 7973
{
	// Fields
	public int value__; // 0x0
	public const RenderMode ScreenSpaceOverlay = 0;
	public const RenderMode ScreenSpaceCamera = 1;
	public const RenderMode WorldSpace = 2;
}

// Namespace: UnityEngine
[Flags]
public enum AdditionalCanvasShaderChannels // TypeDefIndex: 7974
{
	// Fields
	public int value__; // 0x0
	public const AdditionalCanvasShaderChannels None = 0;
	public const AdditionalCanvasShaderChannels TexCoord1 = 1;
	public const AdditionalCanvasShaderChannels TexCoord2 = 2;
	public const AdditionalCanvasShaderChannels TexCoord3 = 4;
	public const AdditionalCanvasShaderChannels Normal = 8;
	public const AdditionalCanvasShaderChannels Tangent = 16;
}

// Namespace: 
public sealed class Canvas.WillRenderCanvases : MulticastDelegate // TypeDefIndex: 7975
{
	// Methods

	// RVA: 0x1EF128C Offset: 0x1EED28C VA: 0x1EF128C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1EF1328 Offset: 0x1EED328 VA: 0x1EF1328 Slot: 12
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeHeader("Modules/UI/UIStructs.h")]
[RequireComponent(typeof(RectTransform))]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeClass("UI::Canvas")]
public sealed class Canvas : Behaviour // TypeDefIndex: 7976
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Canvas.WillRenderCanvases preWillRenderCanvases; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Canvas.WillRenderCanvases willRenderCanvases; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<int> <externBeginRenderOverlays>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<int, int> <externRenderOverlaysBefore>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<int> <externEndRenderOverlays>k__BackingField; // 0x20

	// Properties
	public RenderMode renderMode { get; }
	public bool isRootCanvas { get; }
	public float scaleFactor { get; set; }
	public float referencePixelsPerUnit { get; set; }
	public bool pixelPerfect { get; }
	public int renderOrder { get; }
	public bool overrideSorting { get; set; }
	public int sortingOrder { get; set; }
	public int targetDisplay { get; }
	public int sortingLayerID { get; set; }
	public AdditionalCanvasShaderChannels additionalShaderChannels { get; set; }
	public Canvas rootCanvas { get; }
	public Vector2 renderingDisplaySize { get; }
	internal static Action<int> externBeginRenderOverlays { get; }
	internal static Action<int, int> externRenderOverlaysBefore { get; }
	internal static Action<int> externEndRenderOverlays { get; }
	[NativeProperty("Camera", False, 0)]
	public Camera worldCamera { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1EEFCB0 Offset: 0x1EEBCB0 VA: 0x1EEFCB0
	public static void add_preWillRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x1EEFD68 Offset: 0x1EEBD68 VA: 0x1EEFD68
	public static void remove_preWillRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x1EEFE20 Offset: 0x1EEBE20 VA: 0x1EEFE20
	public static void add_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	[CompilerGenerated]
	// RVA: 0x1EEFEDC Offset: 0x1EEBEDC VA: 0x1EEFEDC
	public static void remove_willRenderCanvases(Canvas.WillRenderCanvases value) { }

	// RVA: 0x1EEFF98 Offset: 0x1EEBF98 VA: 0x1EEFF98
	public RenderMode get_renderMode() { }

	// RVA: 0x1EF004C Offset: 0x1EEC04C VA: 0x1EF004C
	public bool get_isRootCanvas() { }

	// RVA: 0x1EF0100 Offset: 0x1EEC100 VA: 0x1EF0100
	public float get_scaleFactor() { }

	// RVA: 0x1EF01B4 Offset: 0x1EEC1B4 VA: 0x1EF01B4
	public void set_scaleFactor(float value) { }

	// RVA: 0x1EF0288 Offset: 0x1EEC288 VA: 0x1EF0288
	public float get_referencePixelsPerUnit() { }

	// RVA: 0x1EF033C Offset: 0x1EEC33C VA: 0x1EF033C
	public void set_referencePixelsPerUnit(float value) { }

	// RVA: 0x1EF0410 Offset: 0x1EEC410 VA: 0x1EF0410
	public bool get_pixelPerfect() { }

	// RVA: 0x1EF04C4 Offset: 0x1EEC4C4 VA: 0x1EF04C4
	public int get_renderOrder() { }

	// RVA: 0x1EF0578 Offset: 0x1EEC578 VA: 0x1EF0578
	public bool get_overrideSorting() { }

	// RVA: 0x1EF062C Offset: 0x1EEC62C VA: 0x1EF062C
	public void set_overrideSorting(bool value) { }

	// RVA: 0x1EF06F0 Offset: 0x1EEC6F0 VA: 0x1EF06F0
	public int get_sortingOrder() { }

	// RVA: 0x1EF07A4 Offset: 0x1EEC7A4 VA: 0x1EF07A4
	public void set_sortingOrder(int value) { }

	// RVA: 0x1EF0868 Offset: 0x1EEC868 VA: 0x1EF0868
	public int get_targetDisplay() { }

	// RVA: 0x1EF091C Offset: 0x1EEC91C VA: 0x1EF091C
	public int get_sortingLayerID() { }

	// RVA: 0x1EF09D0 Offset: 0x1EEC9D0 VA: 0x1EF09D0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x1EF0A94 Offset: 0x1EECA94 VA: 0x1EF0A94
	public AdditionalCanvasShaderChannels get_additionalShaderChannels() { }

	// RVA: 0x1EF0B48 Offset: 0x1EECB48 VA: 0x1EF0B48
	public void set_additionalShaderChannels(AdditionalCanvasShaderChannels value) { }

	// RVA: 0x1EF0C0C Offset: 0x1EECC0C VA: 0x1EF0C0C
	public Canvas get_rootCanvas() { }

	// RVA: 0x1EF0CDC Offset: 0x1EECCDC VA: 0x1EF0CDC
	public Vector2 get_renderingDisplaySize() { }

	[CompilerGenerated]
	// RVA: 0x1EF0DA8 Offset: 0x1EECDA8 VA: 0x1EF0DA8
	internal static Action<int> get_externBeginRenderOverlays() { }

	[CompilerGenerated]
	// RVA: 0x1EF0DF0 Offset: 0x1EECDF0 VA: 0x1EF0DF0
	internal static Action<int, int> get_externRenderOverlaysBefore() { }

	[CompilerGenerated]
	// RVA: 0x1EF0E38 Offset: 0x1EECE38 VA: 0x1EF0E38
	internal static Action<int> get_externEndRenderOverlays() { }

	// RVA: 0x1EF0E80 Offset: 0x1EECE80 VA: 0x1EF0E80
	public Camera get_worldCamera() { }

	[FreeFunction("UI::GetDefaultUIMaterial")]
	// RVA: 0x1EF0F50 Offset: 0x1EECF50 VA: 0x1EF0F50
	public static Material GetDefaultCanvasMaterial() { }

	[FreeFunction("UI::GetETC1SupportedCanvasMaterial")]
	// RVA: 0x1EF0FD8 Offset: 0x1EECFD8 VA: 0x1EF0FD8
	public static Material GetETC1SupportedCanvasMaterial() { }

	// RVA: 0x1EF1060 Offset: 0x1EED060 VA: 0x1EF1060
	public static void ForceUpdateCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x1EF1070 Offset: 0x1EED070 VA: 0x1EF1070
	private static void SendPreWillRenderCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x1EF10D4 Offset: 0x1EED0D4 VA: 0x1EF10D4
	private static void SendWillRenderCanvases() { }

	[RequiredByNativeCode]
	// RVA: 0x1EF1138 Offset: 0x1EED138 VA: 0x1EF1138
	private static void BeginRenderExtraOverlays(int displayIndex) { }

	[RequiredByNativeCode]
	// RVA: 0x1EF11A4 Offset: 0x1EED1A4 VA: 0x1EF11A4
	private static void RenderExtraOverlaysBefore(int displayIndex, int sortingOrder) { }

	[RequiredByNativeCode]
	// RVA: 0x1EF1218 Offset: 0x1EED218 VA: 0x1EF1218
	private static void EndRenderExtraOverlays(int displayIndex) { }

	// RVA: 0x1EF1284 Offset: 0x1EED284 VA: 0x1EF1284
	public void .ctor() { }

	// RVA: 0x1EF0010 Offset: 0x1EEC010 VA: 0x1EF0010
	private static RenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EF00C4 Offset: 0x1EEC0C4 VA: 0x1EF00C4
	private static bool get_isRootCanvas_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EF0178 Offset: 0x1EEC178 VA: 0x1EF0178
	private static float get_scaleFactor_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EF023C Offset: 0x1EEC23C VA: 0x1EF023C
	private static void set_scaleFactor_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1EF0300 Offset: 0x1EEC300 VA: 0x1EF0300
	private static float get_referencePixelsPerUnit_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EF03C4 Offset: 0x1EEC3C4 VA: 0x1EF03C4
	private static void set_referencePixelsPerUnit_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1EF0488 Offset: 0x1EEC488 VA: 0x1EF0488
	private static bool get_pixelPerfect_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EF053C Offset: 0x1EEC53C VA: 0x1EF053C
	private static int get_renderOrder_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EF05F0 Offset: 0x1EEC5F0 VA: 0x1EF05F0
	private static bool get_overrideSorting_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EF06AC Offset: 0x1EEC6AC VA: 0x1EF06AC
	private static void set_overrideSorting_Injected(IntPtr _unity_self, bool value) { }

	// RVA: 0x1EF0768 Offset: 0x1EEC768 VA: 0x1EF0768
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EF0824 Offset: 0x1EEC824 VA: 0x1EF0824
	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1EF08E0 Offset: 0x1EEC8E0 VA: 0x1EF08E0
	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EF0994 Offset: 0x1EEC994 VA: 0x1EF0994
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EF0A50 Offset: 0x1EECA50 VA: 0x1EF0A50
	private static void set_sortingLayerID_Injected(IntPtr _unity_self, int value) { }

	// RVA: 0x1EF0B0C Offset: 0x1EECB0C VA: 0x1EF0B0C
	private static AdditionalCanvasShaderChannels get_additionalShaderChannels_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EF0BC8 Offset: 0x1EECBC8 VA: 0x1EF0BC8
	private static void set_additionalShaderChannels_Injected(IntPtr _unity_self, AdditionalCanvasShaderChannels value) { }

	// RVA: 0x1EF0CA0 Offset: 0x1EECCA0 VA: 0x1EF0CA0
	private static IntPtr get_rootCanvas_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EF0D64 Offset: 0x1EECD64 VA: 0x1EF0D64
	private static void get_renderingDisplaySize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	// RVA: 0x1EF0F14 Offset: 0x1EECF14 VA: 0x1EF0F14
	private static IntPtr get_worldCamera_Injected(IntPtr _unity_self) { }

	// RVA: 0x1EF0FB0 Offset: 0x1EECFB0 VA: 0x1EF0FB0
	private static IntPtr GetDefaultCanvasMaterial_Injected() { }

	// RVA: 0x1EF1038 Offset: 0x1EED038 VA: 0x1EF1038
	private static IntPtr GetETC1SupportedCanvasMaterial_Injected() { }
}

// Namespace: 
public enum UISystemProfilerApi.SampleType // TypeDefIndex: 7977
{
	// Fields
	public int value__; // 0x0
	public const UISystemProfilerApi.SampleType Layout = 0;
	public const UISystemProfilerApi.SampleType Render = 1;
}

// Namespace: UnityEngine
[IgnoredByDeepProfiler]
[NativeHeader("Modules/UI/Canvas.h")]
[StaticAccessor("UI::SystemProfilerApi", 2)]
public static class UISystemProfilerApi // TypeDefIndex: 7978
{
	// Methods

	// RVA: 0x1EF133C Offset: 0x1EED33C VA: 0x1EF133C
	public static void BeginSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x1EF1378 Offset: 0x1EED378 VA: 0x1EF1378
	public static void EndSample(UISystemProfilerApi.SampleType type) { }

	// RVA: 0x1EF13B4 Offset: 0x1EED3B4 VA: 0x1EF13B4
	public static void AddMarker(string name, Object obj) { }

	// RVA: 0x1EF1550 Offset: 0x1EED550 VA: 0x1EF1550
	private static void AddMarker_Injected(ref ManagedSpanWrapper name, IntPtr obj) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 7979
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Usage(4, AllowMultiple = False)]
public sealed class SharedBetweenAnimatorsAttribute : Attribute // TypeDefIndex: 7980
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
public abstract class StateMachineBehaviour : ScriptableObject // TypeDefIndex: 7981
{
	// Methods

	// RVA: 0x1E45E6C Offset: 0x1E41E6C VA: 0x1E45E6C Slot: 4
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1E45E70 Offset: 0x1E41E70 VA: 0x1E45E70 Slot: 5
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1E45E74 Offset: 0x1E41E74 VA: 0x1E45E74 Slot: 6
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1E45E78 Offset: 0x1E41E78 VA: 0x1E45E78 Slot: 7
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1E45E7C Offset: 0x1E41E7C VA: 0x1E45E7C Slot: 8
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	// RVA: 0x1E45E80 Offset: 0x1E41E80 VA: 0x1E45E80 Slot: 9
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x1E45E84 Offset: 0x1E41E84 VA: 0x1E45E84 Slot: 10
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash) { }

	// RVA: 0x1E45E88 Offset: 0x1E41E88 VA: 0x1E45E88 Slot: 11
	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x1E45E8C Offset: 0x1E41E8C VA: 0x1E45E8C Slot: 12
	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x1E45E90 Offset: 0x1E41E90 VA: 0x1E45E90 Slot: 13
	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x1E45E94 Offset: 0x1E41E94 VA: 0x1E45E94 Slot: 14
	public virtual void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x1E45E98 Offset: 0x1E41E98 VA: 0x1E45E98 Slot: 15
	public virtual void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex, AnimatorControllerPlayable controller) { }

	// RVA: 0x1E45E9C Offset: 0x1E41E9C VA: 0x1E45E9C Slot: 16
	public virtual void OnStateMachineEnter(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x1E45EA0 Offset: 0x1E41EA0 VA: 0x1E45EA0 Slot: 17
	public virtual void OnStateMachineExit(Animator animator, int stateMachinePathHash, AnimatorControllerPlayable controller) { }

	// RVA: 0x1E45EA4 Offset: 0x1E41EA4 VA: 0x1E45EA4
	protected void .ctor() { }
}

// Namespace: UnityEngine
internal enum AnimationEventSource // TypeDefIndex: 7982
{
	// Fields
	public int value__; // 0x0
	public const AnimationEventSource NoSource = 0;
	public const AnimationEventSource Legacy = 1;
	public const AnimationEventSource Animator = 2;
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/Animation/AnimationState.h")]
public sealed class AnimationState : TrackedReference // TypeDefIndex: 7983
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Serializable]
internal struct AnimationEventBlittable : IDisposable // TypeDefIndex: 7984
{
	// Fields
	internal float m_Time; // 0x0
	internal IntPtr m_FunctionName; // 0x8
	internal IntPtr m_StringParameter; // 0x10
	internal IntPtr m_ObjectReferenceParameter; // 0x18
	internal float m_FloatParameter; // 0x20
	internal int m_IntParameter; // 0x24
	internal int m_MessageOptions; // 0x28
	internal AnimationEventSource m_Source; // 0x2C
	internal IntPtr m_StateSender; // 0x30
	internal AnimatorStateInfo m_AnimatorStateInfo; // 0x38
	internal AnimatorClipInfo m_AnimatorClipInfo; // 0x5C
	[ThreadStatic]
	private static GCHandlePool s_handlePool; // 0x80000000

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E45EAC Offset: 0x1E41EAC VA: 0x1E45EAC
	internal static AnimationEvent PointerToAnimationEvent(IntPtr animationEventBlittable) { }

	// RVA: 0x1E45EE0 Offset: 0x1E41EE0 VA: 0x1E45EE0
	internal static AnimationEvent ToAnimationEvent(AnimationEventBlittable animationEventBlittable) { }

	// RVA: 0x1E46210 Offset: 0x1E42210 VA: 0x1E46210 Slot: 4
	public void Dispose() { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[Serializable]
public sealed class AnimationEvent // TypeDefIndex: 7985
{
	// Fields
	internal float m_Time; // 0x10
	internal string m_FunctionName; // 0x18
	internal string m_StringParameter; // 0x20
	internal Object m_ObjectReferenceParameter; // 0x28
	internal float m_FloatParameter; // 0x30
	internal int m_IntParameter; // 0x34
	internal int m_MessageOptions; // 0x38
	internal AnimationEventSource m_Source; // 0x3C
	internal AnimationState m_StateSender; // 0x40
	internal AnimatorStateInfo m_AnimatorStateInfo; // 0x48
	internal AnimatorClipInfo m_AnimatorClipInfo; // 0x6C

	// Methods

	// RVA: 0x1E46180 Offset: 0x1E42180 VA: 0x1E46180
	public void .ctor() { }
}

// Namespace: UnityEngine
internal class GCHandlePool // TypeDefIndex: 7986
{
	// Fields
	private GCHandle[] m_handles; // 0x10
	private int m_current; // 0x18

	// Methods

	// RVA: 0x1E46314 Offset: 0x1E42314 VA: 0x1E46314
	public void .ctor() { }

	// RVA: 0x1E46378 Offset: 0x1E42378 VA: 0x1E46378
	public void Free(GCHandle h) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[UsedByNativeCode]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
public struct AnimatorClipInfo // TypeDefIndex: 7987
{
	// Fields
	private int m_ClipInstanceID; // 0x0
	private float m_Weight; // 0x4
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
public struct AnimatorStateInfo // TypeDefIndex: 7988
{
	// Fields
	private int m_Name; // 0x0
	private int m_Path; // 0x4
	private int m_FullPath; // 0x8
	private float m_NormalizedTime; // 0xC
	private float m_Length; // 0x10
	private float m_Speed; // 0x14
	private float m_SpeedMultiplier; // 0x18
	private int m_Tag; // 0x1C
	private int m_Loop; // 0x20
}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
public struct AnimatorTransitionInfo // TypeDefIndex: 7989
{
	// Fields
	[NativeName("fullPathHash")]
	private int m_FullPath; // 0x0
	[NativeName("userNameHash")]
	private int m_UserName; // 0x4
	[NativeName("nameHash")]
	private int m_Name; // 0x8
	[NativeName("hasFixedDuration")]
	private bool m_HasFixedDuration; // 0xC
	[NativeName("duration")]
	private float m_Duration; // 0x10
	[NativeName("normalizedTime")]
	private float m_NormalizedTime; // 0x14
	[NativeName("anyState")]
	private bool m_AnyState; // 0x18
	[NativeName("transitionType")]
	private int m_TransitionType; // 0x1C
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
public class Animator : Behaviour // TypeDefIndex: 7990
{
	// Properties
	public bool hasBoundPlayables { get; }

	// Methods

	// RVA: 0x1E46484 Offset: 0x1E42484 VA: 0x1E46484
	public void SetTrigger(string name) { }

	// RVA: 0x1E46624 Offset: 0x1E42624 VA: 0x1E46624
	public void ResetTrigger(string name) { }

	[NativeMethod("HasBoundPlayables")]
	// RVA: 0x1E467C4 Offset: 0x1E427C4 VA: 0x1E467C4
	public bool get_hasBoundPlayables() { }

	[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = True)]
	// RVA: 0x1E46488 Offset: 0x1E42488 VA: 0x1E46488
	private void SetTriggerString(string name) { }

	[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = True)]
	// RVA: 0x1E46628 Offset: 0x1E42628 VA: 0x1E46628
	private void ResetTriggerString(string name) { }

	// RVA: 0x1E4683C Offset: 0x1E4283C VA: 0x1E4683C
	private static bool get_hasBoundPlayables_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E46878 Offset: 0x1E42878 VA: 0x1E46878
	private static void SetTriggerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	// RVA: 0x1E468BC Offset: 0x1E428BC VA: 0x1E468BC
	private static void ResetTriggerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }
}

// Namespace: 
internal sealed class AnimatorOverrideController.OnOverrideControllerDirtyCallback : MulticastDelegate // TypeDefIndex: 7991
{
	// Methods

	// RVA: 0x1E46928 Offset: 0x1E42928 VA: 0x1E46928
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E469C4 Offset: 0x1E429C4 VA: 0x1E469C4 Slot: 12
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/AnimatorOverrideController.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animation.bindings.h")]
[UsedByNativeCode]
[DefaultMember("Item")]
[HelpURL("AnimatorOverrideController")]
public class AnimatorOverrideController : RuntimeAnimatorController // TypeDefIndex: 7992
{
	// Fields
	internal AnimatorOverrideController.OnOverrideControllerDirtyCallback OnOverrideControllerDirty; // 0x18

	// Methods

	[NativeConditional("UNITY_EDITOR")]
	[RequiredByNativeCode]
	// RVA: 0x1E46900 Offset: 0x1E42900 VA: 0x1E46900
	internal static void OnInvalidateOverrideController(AnimatorOverrideController controller) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/HumanDescription.h")]
[RequiredByNativeCode]
[NativeType(1, "MonoSkeletonBone")]
public struct SkeletonBone // TypeDefIndex: 7993
{
	// Fields
	[NativeName("m_Name")]
	public string name; // 0x0
	[NativeName("m_ParentName")]
	internal string parentName; // 0x8
	[NativeName("m_Position")]
	public Vector3 position; // 0x10
	[NativeName("m_Rotation")]
	public Quaternion rotation; // 0x1C
	[NativeName("m_Scale")]
	public Vector3 scale; // 0x2C
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/ScriptBindings/AvatarBuilder.bindings.h")]
[NativeHeader("Modules/Animation/HumanDescription.h")]
[NativeType(1, "MonoHumanLimit")]
public struct HumanLimit // TypeDefIndex: 7994
{
	// Fields
	private Vector3 m_Min; // 0x0
	private Vector3 m_Max; // 0xC
	private Vector3 m_Center; // 0x18
	private float m_AxisLength; // 0x24
	private int m_UseDefaultValues; // 0x28
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/HumanDescription.h")]
[RequiredByNativeCode]
[NativeType(1, "MonoHumanBone")]
public struct HumanBone // TypeDefIndex: 7995
{
	// Fields
	private string m_BoneName; // 0x0
	private string m_HumanName; // 0x8
	[NativeName("m_Limit")]
	public HumanLimit limit; // 0x10
}

// Namespace: UnityEngine
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
[UsedByNativeCode]
[ExcludeFromObjectFactory]
public class RuntimeAnimatorController : Object // TypeDefIndex: 7996
{}

// Namespace: UnityEngine
public enum FontStyle // TypeDefIndex: 8012
{
	// Fields
	public int value__; // 0x0
	public const FontStyle Normal = 0;
	public const FontStyle Bold = 1;
	public const FontStyle Italic = 2;
	public const FontStyle BoldAndItalic = 3;
}

// Namespace: UnityEngine
[Flags]
internal enum TextGenerationError // TypeDefIndex: 8013
{
	// Fields
	public int value__; // 0x0
	public const TextGenerationError None = 0;
	public const TextGenerationError CustomSizeOnNonDynamicFont = 1;
	public const TextGenerationError CustomStyleOnNonDynamicFont = 2;
	public const TextGenerationError NoFont = 4;
}

// Namespace: UnityEngine
public struct TextGenerationSettings // TypeDefIndex: 8014
{
	// Fields
	public Font font; // 0x0
	public Color color; // 0x8
	public int fontSize; // 0x18
	public float lineSpacing; // 0x1C
	public bool richText; // 0x20
	public float scaleFactor; // 0x24
	public FontStyle fontStyle; // 0x28
	public TextAnchor textAnchor; // 0x2C
	public bool alignByGeometry; // 0x30
	public bool resizeTextForBestFit; // 0x31
	public int resizeTextMinSize; // 0x34
	public int resizeTextMaxSize; // 0x38
	public bool updateBounds; // 0x3C
	public VerticalWrapMode verticalOverflow; // 0x40
	public HorizontalWrapMode horizontalOverflow; // 0x44
	public Vector2 generationExtents; // 0x48
	public Vector2 pivot; // 0x50
	public bool generateOutOfBounds; // 0x58

	// Methods

	// RVA: 0x1ED5964 Offset: 0x1ED1964 VA: 0x1ED5964
	private bool CompareColors(Color left, Color right) { }

	// RVA: 0x1ED5A9C Offset: 0x1ED1A9C VA: 0x1ED5A9C
	private bool CompareVector2(Vector2 left, Vector2 right) { }

	// RVA: 0x1ED5B64 Offset: 0x1ED1B64 VA: 0x1ED5B64
	public bool Equals(TextGenerationSettings other) { }
}

// Namespace: 
internal static class TextGenerator.BindingsMarshaller // TypeDefIndex: 8015
{
	// Methods

	// RVA: 0x1ED7224 Offset: 0x1ED3224 VA: 0x1ED7224
	public static IntPtr ConvertToNative(TextGenerator textGenerator) { }
}

// Namespace: UnityEngine
[UsedByNativeCode]
[NativeHeader("Modules/TextRendering/TextGenerator.h")]
public sealed class TextGenerator : IDisposable // TypeDefIndex: 8016
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private string m_LastString; // 0x18
	private TextGenerationSettings m_LastSettings; // 0x20
	private bool m_HasGenerated; // 0x80
	private TextGenerationError m_LastValid; // 0x84
	private readonly List<UIVertex> m_Verts; // 0x88
	private readonly List<UICharInfo> m_Characters; // 0x90
	private readonly List<UILineInfo> m_Lines; // 0x98
	private bool m_CachedVerts; // 0xA0
	private bool m_CachedCharacters; // 0xA1
	private bool m_CachedLines; // 0xA2

	// Properties
	public int characterCountVisible { get; }
	public IList<UIVertex> verts { get; }
	public IList<UICharInfo> characters { get; }
	public IList<UILineInfo> lines { get; }
	public Rect rectExtents { get; }
	public int characterCount { get; }
	public int lineCount { get; }

	// Methods

	// RVA: 0x1ED5D68 Offset: 0x1ED1D68 VA: 0x1ED5D68
	public void .ctor() { }

	// RVA: 0x1ED5D70 Offset: 0x1ED1D70 VA: 0x1ED5D70
	public void .ctor(int initialCapacity) { }

	// RVA: 0x1ED5F04 Offset: 0x1ED1F04 VA: 0x1ED5F04 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1ED6010 Offset: 0x1ED2010 VA: 0x1ED6010 Slot: 4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1ED6098 Offset: 0x1ED2098 VA: 0x1ED6098
	public int get_characterCountVisible() { }

	// RVA: 0x1ED60FC Offset: 0x1ED20FC VA: 0x1ED60FC
	private TextGenerationSettings ValidatedSettings(TextGenerationSettings settings) { }

	// RVA: 0x1ED6428 Offset: 0x1ED2428 VA: 0x1ED6428
	public void Invalidate() { }

	// RVA: 0x1ED6430 Offset: 0x1ED2430 VA: 0x1ED6430
	public void GetCharacters(List<UICharInfo> characters) { }

	// RVA: 0x1ED648C Offset: 0x1ED248C VA: 0x1ED648C
	public void GetLines(List<UILineInfo> lines) { }

	// RVA: 0x1ED64E8 Offset: 0x1ED24E8 VA: 0x1ED64E8
	public void GetVertices(List<UIVertex> vertices) { }

	// RVA: 0x1ED6544 Offset: 0x1ED2544 VA: 0x1ED6544
	public float GetPreferredWidth(string str, TextGenerationSettings settings) { }

	// RVA: 0x1ED665C Offset: 0x1ED265C VA: 0x1ED665C
	public float GetPreferredHeight(string str, TextGenerationSettings settings) { }

	// RVA: 0x1ED66B8 Offset: 0x1ED26B8 VA: 0x1ED66B8
	public bool PopulateWithErrors(string str, TextGenerationSettings settings, GameObject context) { }

	// RVA: 0x1ED65A4 Offset: 0x1ED25A4 VA: 0x1ED65A4
	public bool Populate(string str, TextGenerationSettings settings) { }

	// RVA: 0x1ED6884 Offset: 0x1ED2884 VA: 0x1ED6884
	private TextGenerationError PopulateWithError(string str, TextGenerationSettings settings) { }

	// RVA: 0x1ED6914 Offset: 0x1ED2914 VA: 0x1ED6914
	private TextGenerationError PopulateAlways(string str, TextGenerationSettings settings) { }

	// RVA: 0x1ED6BD8 Offset: 0x1ED2BD8 VA: 0x1ED6BD8
	public IList<UIVertex> get_verts() { }

	// RVA: 0x1ED6C08 Offset: 0x1ED2C08 VA: 0x1ED6C08
	public IList<UICharInfo> get_characters() { }

	// RVA: 0x1ED6C38 Offset: 0x1ED2C38 VA: 0x1ED6C38
	public IList<UILineInfo> get_lines() { }

	// RVA: 0x1ED65F0 Offset: 0x1ED25F0 VA: 0x1ED65F0
	public Rect get_rectExtents() { }

	// RVA: 0x1ED60AC Offset: 0x1ED20AC VA: 0x1ED60AC
	public int get_characterCount() { }

	// RVA: 0x1ED6CE8 Offset: 0x1ED2CE8 VA: 0x1ED6CE8
	public int get_lineCount() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x1ED5EDC Offset: 0x1ED1EDC VA: 0x1ED5EDC
	private static IntPtr Internal_Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x1ED605C Offset: 0x1ED205C VA: 0x1ED605C
	private static void Internal_Destroy(IntPtr ptr) { }

	// RVA: 0x1ED6D74 Offset: 0x1ED2D74 VA: 0x1ED6D74
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x1ED6A2C Offset: 0x1ED2A2C VA: 0x1ED6A2C
	internal bool Populate_Internal(string str, Font font, Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, VerticalWrapMode verticalOverFlow, HorizontalWrapMode horizontalOverflow, bool updateBounds, TextAnchor anchor, Vector2 extents, Vector2 pivot, bool generateOutOfBounds, bool alignByGeometry, out TextGenerationError error) { }

	[NativeThrows]
	// RVA: 0x1ED64EC Offset: 0x1ED24EC VA: 0x1ED64EC
	private void GetVerticesInternal(object vertices) { }

	[NativeThrows]
	// RVA: 0x1ED6434 Offset: 0x1ED2434 VA: 0x1ED6434
	private void GetCharactersInternal(object characters) { }

	[NativeThrows]
	// RVA: 0x1ED6490 Offset: 0x1ED2490 VA: 0x1ED6490
	private void GetLinesInternal(object lines) { }

	// RVA: 0x1ED6C68 Offset: 0x1ED2C68 VA: 0x1ED6C68
	private static void get_rectExtents_Injected(IntPtr _unity_self, out Rect ret) { }

	// RVA: 0x1ED6CAC Offset: 0x1ED2CAC VA: 0x1ED6CAC
	private static int get_characterCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x1ED6D38 Offset: 0x1ED2D38 VA: 0x1ED6D38
	private static int get_lineCount_Injected(IntPtr _unity_self) { }

	// RVA: 0x1ED7024 Offset: 0x1ED3024 VA: 0x1ED7024
	private static bool Populate_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper str, IntPtr font, in Color color, int fontSize, float scaleFactor, float lineSpacing, FontStyle style, bool richText, bool resizeTextForBestFit, int resizeTextMinSize, int resizeTextMaxSize, int verticalOverFlow, int horizontalOverflow, bool updateBounds, TextAnchor anchor, float extentsX, float extentsY, float pivotX, float pivotY, bool generateOutOfBounds, bool alignByGeometry, out uint error) { }

	// RVA: 0x1ED7158 Offset: 0x1ED3158 VA: 0x1ED7158
	private static void GetVerticesInternal_Injected(IntPtr _unity_self, object vertices) { }

	// RVA: 0x1ED719C Offset: 0x1ED319C VA: 0x1ED719C
	private static void GetCharactersInternal_Injected(IntPtr _unity_self, object characters) { }

	// RVA: 0x1ED71E0 Offset: 0x1ED31E0 VA: 0x1ED71E0
	private static void GetLinesInternal_Injected(IntPtr _unity_self, object lines) { }
}

// Namespace: UnityEngine
public enum TextAnchor // TypeDefIndex: 8017
{
	// Fields
	public int value__; // 0x0
	public const TextAnchor UpperLeft = 0;
	public const TextAnchor UpperCenter = 1;
	public const TextAnchor UpperRight = 2;
	public const TextAnchor MiddleLeft = 3;
	public const TextAnchor MiddleCenter = 4;
	public const TextAnchor MiddleRight = 5;
	public const TextAnchor LowerLeft = 6;
	public const TextAnchor LowerCenter = 7;
	public const TextAnchor LowerRight = 8;
}

// Namespace: UnityEngine
public enum HorizontalWrapMode // TypeDefIndex: 8018
{
	// Fields
	public int value__; // 0x0
	public const HorizontalWrapMode Wrap = 0;
	public const HorizontalWrapMode Overflow = 1;
}

// Namespace: UnityEngine
public enum VerticalWrapMode // TypeDefIndex: 8019
{
	// Fields
	public int value__; // 0x0
	public const VerticalWrapMode Truncate = 0;
	public const VerticalWrapMode Overflow = 1;
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct UICharInfo // TypeDefIndex: 8020
{
	// Fields
	public Vector2 cursorPos; // 0x0
	public float charWidth; // 0x8
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct UILineInfo // TypeDefIndex: 8021
{
	// Fields
	public int startCharIdx; // 0x0
	public int height; // 0x4
	public float topY; // 0x8
	public float leading; // 0xC
}

// Namespace: UnityEngine
[UsedByNativeCode]
public struct UIVertex // TypeDefIndex: 8022
{
	// Fields
	public Vector3 position; // 0x0
	public Vector3 normal; // 0xC
	public Vector4 tangent; // 0x18
	public Color32 color; // 0x28
	public Vector4 uv0; // 0x2C
	public Vector4 uv1; // 0x3C
	public Vector4 uv2; // 0x4C
	public Vector4 uv3; // 0x5C
	private static readonly Color32 s_DefaultColor; // 0x0
	private static readonly Vector4 s_DefaultTangent; // 0x4
	public static UIVertex simpleVert; // 0x14

	// Methods

	// RVA: 0x1ED7238 Offset: 0x1ED3238 VA: 0x1ED7238
	private static void .cctor() { }
}

// Namespace: 
public sealed class Font.FontTextureRebuildCallback : MulticastDelegate // TypeDefIndex: 8023
{
	// Methods

	// RVA: 0x1ED7AC0 Offset: 0x1ED3AC0 VA: 0x1ED7AC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1ED7B5C Offset: 0x1ED3B5C VA: 0x1ED7B5C Slot: 12
	public virtual void Invoke() { }
}

// Namespace: UnityEngine
[StaticAccessor("TextRenderingPrivate", 2)]
[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
[NativeHeader("Modules/TextRendering/Public/Font.h")]
[NativeClass("TextRendering::Font")]
public sealed class Font : Object // TypeDefIndex: 8024
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<Font> textureRebuilt; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Font.FontTextureRebuildCallback m_FontTextureRebuildCallback; // 0x18

	// Properties
	public Material material { get; }
	public bool dynamic { get; }
	public int fontSize { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1ED73A8 Offset: 0x1ED33A8 VA: 0x1ED73A8
	public static void add_textureRebuilt(Action<Font> value) { }

	[CompilerGenerated]
	// RVA: 0x1ED7474 Offset: 0x1ED3474 VA: 0x1ED7474
	public static void remove_textureRebuilt(Action<Font> value) { }

	// RVA: 0x1ED7540 Offset: 0x1ED3540 VA: 0x1ED7540
	public Material get_material() { }

	// RVA: 0x1ED63B0 Offset: 0x1ED23B0 VA: 0x1ED63B0
	public bool get_dynamic() { }

	// RVA: 0x1ED764C Offset: 0x1ED364C VA: 0x1ED764C
	public int get_fontSize() { }

	// RVA: 0x1ED7700 Offset: 0x1ED3700 VA: 0x1ED7700
	public void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x1ED78D4 Offset: 0x1ED38D4 VA: 0x1ED78D4
	internal static void InvokeTextureRebuilt_Internal(Font font) { }

	// RVA: 0x1ED7960 Offset: 0x1ED3960 VA: 0x1ED7960
	public bool HasCharacter(char c) { }

	// RVA: 0x1ED7968 Offset: 0x1ED3968 VA: 0x1ED7968
	private bool HasCharacter(int c) { }

	// RVA: 0x1ED7A2C Offset: 0x1ED3A2C VA: 0x1ED7A2C
	public static string[] GetPathsToOSFonts() { }

	[VisibleToOtherModules(new[] { "UnityEngine.TextCoreTextEngineModule" })]
	// RVA: 0x1ED7A54 Offset: 0x1ED3A54 VA: 0x1ED7A54
	internal static string[] GetOSFallbacks() { }

	// RVA: 0x1ED7764 Offset: 0x1ED3764 VA: 0x1ED7764
	private static void Internal_CreateFont(Font self, string name) { }

	// RVA: 0x1ED75D4 Offset: 0x1ED35D4 VA: 0x1ED75D4
	private static IntPtr get_material_Injected(IntPtr _unity_self) { }

	// RVA: 0x1ED7610 Offset: 0x1ED3610 VA: 0x1ED7610
	private static bool get_dynamic_Injected(IntPtr _unity_self) { }

	// RVA: 0x1ED76C4 Offset: 0x1ED36C4 VA: 0x1ED76C4
	private static int get_fontSize_Injected(IntPtr _unity_self) { }

	// RVA: 0x1ED79E8 Offset: 0x1ED39E8 VA: 0x1ED79E8
	private static bool HasCharacter_Injected(IntPtr _unity_self, int c) { }

	// RVA: 0x1ED7A7C Offset: 0x1ED3A7C VA: 0x1ED7A7C
	private static void Internal_CreateFont_Injected(Font self, ref ManagedSpanWrapper name) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 8025
{}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/PhysicsSceneHandle2D.h")]
public struct PhysicsScene2D : IEquatable<PhysicsScene2D> // TypeDefIndex: 8026
{
	// Fields
	private int m_Handle; // 0x0

	// Methods

	// RVA: 0x1E987DC Offset: 0x1E947DC VA: 0x1E987DC Slot: 3
	public override string ToString() { }

	// RVA: 0x1E988C0 Offset: 0x1E948C0 VA: 0x1E988C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E988C8 Offset: 0x1E948C8 VA: 0x1E988C8 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1E98940 Offset: 0x1E94940 VA: 0x1E98940 Slot: 4
	public bool Equals(PhysicsScene2D other) { }

	// RVA: 0x1E98950 Offset: 0x1E94950 VA: 0x1E98950
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask = -5) { }

	// RVA: 0x1E98B84 Offset: 0x1E94B84 VA: 0x1E98B84
	public RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	// RVA: 0x1E98BD0 Offset: 0x1E94BD0 VA: 0x1E98BD0
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x1E98D20 Offset: 0x1E94D20 VA: 0x1E98D20
	public int Raycast(Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("Raycast_Binding")]
	// RVA: 0x1E98AF0 Offset: 0x1E94AF0 VA: 0x1E98AF0
	private static RaycastHit2D Raycast_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter) { }

	[NativeMethod("RaycastArray_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x1E98C00 Offset: 0x1E94C00 VA: 0x1E98C00
	private static int RaycastArray_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("RaycastList_Binding")]
	// RVA: 0x1E98D50 Offset: 0x1E94D50 VA: 0x1E98D50
	private static int RaycastList_Internal(PhysicsScene2D physicsScene, Vector2 origin, Vector2 direction, float distance, ContactFilter2D contactFilter, List<RaycastHit2D> results) { }

	// RVA: 0x1E990C8 Offset: 0x1E950C8 VA: 0x1E990C8
	public int GetRayIntersection(Ray ray, float distance, RaycastHit2D[] results, int layerMask = -5) { }

	[NativeMethod("GetRayIntersectionArray_Binding")]
	[StaticAccessor("PhysicsQuery2D", 2)]
	// RVA: 0x1E990E4 Offset: 0x1E950E4 VA: 0x1E990E4
	private static int GetRayIntersectionArray_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask, RaycastHit2D[] results) { }

	// RVA: 0x1E98F54 Offset: 0x1E94F54 VA: 0x1E98F54
	private static void Raycast_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, out RaycastHit2D ret) { }

	// RVA: 0x1E98FD0 Offset: 0x1E94FD0 VA: 0x1E98FD0
	private static int RaycastArray_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, ref ManagedSpanWrapper results) { }

	// RVA: 0x1E9904C Offset: 0x1E9504C VA: 0x1E9904C
	private static int RaycastList_Internal_Injected(in PhysicsScene2D physicsScene, in Vector2 origin, in Vector2 direction, float distance, in ContactFilter2D contactFilter, ref BlittableListWrapper results) { }

	// RVA: 0x1E9920C Offset: 0x1E9520C VA: 0x1E9920C
	private static int GetRayIntersectionArray_Internal_Injected(in PhysicsScene2D physicsScene, in Vector3 origin, in Vector3 direction, float distance, int layerMask, ref ManagedSpanWrapper results) { }
}

// Namespace: UnityEngine
[StaticAccessor("GetPhysicsManager2D()", 1)]
[NativeHeader("Physics2DScriptingClasses.h")]
[NativeHeader("Modules/Physics2D/PhysicsManager2D.h")]
[NativeHeader("Physics2DScriptingClasses.h")]
public class Physics2D // TypeDefIndex: 8027
{
	// Fields
	private static List<Rigidbody2D> m_LastDisabledRigidbody2D; // 0x0

	// Properties
	public static PhysicsScene2D defaultPhysicsScene { get; }
	[StaticAccessor("GetPhysics2DSettings()")]
	public static bool queriesHitTriggers { get; }

	// Methods

	// RVA: 0x1E99288 Offset: 0x1E95288 VA: 0x1E99288
	public static PhysicsScene2D get_defaultPhysicsScene() { }

	// RVA: 0x1E99290 Offset: 0x1E95290 VA: 0x1E99290
	public static bool get_queriesHitTriggers() { }

	[ExcludeFromDocs]
	// RVA: 0x1E992B8 Offset: 0x1E952B8 VA: 0x1E992B8
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction) { }

	[ExcludeFromDocs]
	// RVA: 0x1E99398 Offset: 0x1E95398 VA: 0x1E99398
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	// RVA: 0x1E99478 Offset: 0x1E95478 VA: 0x1E99478
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask) { }

	[ExcludeFromDocs]
	// RVA: 0x1E99574 Offset: 0x1E95574 VA: 0x1E99574
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth) { }

	// RVA: 0x1E99670 Offset: 0x1E95670 VA: 0x1E99670
	public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth) { }

	[ExcludeFromDocs]
	// RVA: 0x1E99774 Offset: 0x1E95774 VA: 0x1E99774
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results) { }

	// RVA: 0x1E99830 Offset: 0x1E95830 VA: 0x1E99830
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, RaycastHit2D[] results, float distance) { }

	// RVA: 0x1E998F4 Offset: 0x1E958F4 VA: 0x1E998F4
	public static int Raycast(Vector2 origin, Vector2 direction, ContactFilter2D contactFilter, List<RaycastHit2D> results, float distance = ∞) { }

	[ExcludeFromDocs]
	// RVA: 0x1E999B8 Offset: 0x1E959B8 VA: 0x1E999B8
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray) { }

	[ExcludeFromDocs]
	// RVA: 0x1E99B8C Offset: 0x1E95B8C VA: 0x1E99B8C
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance) { }

	[RequiredByNativeCode]
	// RVA: 0x1E99C00 Offset: 0x1E95C00 VA: 0x1E99C00
	public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance, int layerMask = -5) { }

	[StaticAccessor("PhysicsQuery2D", 2)]
	[NativeMethod("GetRayIntersectionAll_Binding")]
	// RVA: 0x1E99A24 Offset: 0x1E95A24 VA: 0x1E99A24
	private static RaycastHit2D[] GetRayIntersectionAll_Internal(PhysicsScene2D physicsScene, Vector3 origin, Vector3 direction, float distance, int layerMask) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	// RVA: 0x1E99CFC Offset: 0x1E95CFC VA: 0x1E99CFC
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance, int layerMask = -5) { }

	[Obsolete("Physics2D.GetRayIntersectionNonAlloc is deprecated. Use Physics2D.GetRayIntersection instead.", False)]
	[EditorBrowsable(1)]
	[ExcludeFromDocs]
	// RVA: 0x1E99D84 Offset: 0x1E95D84 VA: 0x1E99D84
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results) { }

	[Obsolete("Physics2D.GetRayIntersectionNonAlloc is deprecated. Use Physics2D.GetRayIntersection instead.", False)]
	[EditorBrowsable(1)]
	[ExcludeFromDocs]
	// RVA: 0x1E99E00 Offset: 0x1E95E00 VA: 0x1E99E00
	public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance) { }

	// RVA: 0x1E99E84 Offset: 0x1E95E84 VA: 0x1E99E84
	private static void .cctor() { }

	// RVA: 0x1E99C80 Offset: 0x1E95C80 VA: 0x1E99C80
	private static void GetRayIntersectionAll_Internal_Injected(in PhysicsScene2D physicsScene, in Vector3 origin, in Vector3 direction, float distance, int layerMask, out BlittableArrayWrapper ret) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[NativeClass("ContactFilter", "struct ContactFilter;")]
[Serializable]
public struct ContactFilter2D // TypeDefIndex: 8028
{
	// Fields
	[NativeName("m_UseTriggers")]
	public bool useTriggers; // 0x0
	[NativeName("m_UseLayerMask")]
	public bool useLayerMask; // 0x1
	[NativeName("m_UseDepth")]
	public bool useDepth; // 0x2
	[NativeName("m_UseOutsideDepth")]
	public bool useOutsideDepth; // 0x3
	[NativeName("m_UseNormalAngle")]
	public bool useNormalAngle; // 0x4
	[NativeName("m_UseOutsideNormalAngle")]
	public bool useOutsideNormalAngle; // 0x5
	[NativeName("m_LayerMask")]
	public LayerMask layerMask; // 0x8
	[NativeName("m_MinDepth")]
	public float minDepth; // 0xC
	[NativeName("m_MaxDepth")]
	public float maxDepth; // 0x10
	[NativeName("m_MinNormalAngle")]
	public float minNormalAngle; // 0x14
	[NativeName("m_MaxNormalAngle")]
	public float maxNormalAngle; // 0x18

	// Methods

	// RVA: 0x1E99F1C Offset: 0x1E95F1C VA: 0x1E99F1C
	private void CheckConsistency() { }

	// RVA: 0x1E99F58 Offset: 0x1E95F58 VA: 0x1E99F58
	public void SetLayerMask(LayerMask layerMask) { }

	// RVA: 0x1E99F68 Offset: 0x1E95F68 VA: 0x1E99F68
	public void SetDepth(float minDepth, float maxDepth) { }

	// RVA: 0x1E989F4 Offset: 0x1E949F4 VA: 0x1E989F4
	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }
}

// Namespace: UnityEngine
[RequiredByNativeCode]
public class Collision2D // TypeDefIndex: 8029
{
	// Fields
	internal int m_Collider; // 0x10
	internal int m_OtherCollider; // 0x14
	internal int m_Rigidbody; // 0x18
	internal int m_OtherRigidbody; // 0x1C
	internal Vector2 m_RelativeVelocity; // 0x20
	internal int m_Enabled; // 0x28
	internal int m_ContactCount; // 0x2C
	internal ContactPoint2D[] m_ReusedContacts; // 0x30
	internal ContactPoint2D[] m_LegacyContacts; // 0x38
}

// Namespace: UnityEngine
[RequiredByNativeCode(Optional = False, GenerateProxy = True)]
[NativeClass("ScriptingContactPoint2D", "struct ScriptingContactPoint2D;")]
[NativeHeader("Modules/Physics2D/Public/PhysicsScripting2D.h")]
public struct ContactPoint2D // TypeDefIndex: 8030
{
	// Fields
	[NativeName("point")]
	private Vector2 m_Point; // 0x0
	[NativeName("normal")]
	private Vector2 m_Normal; // 0x8
	[NativeName("relativeVelocity")]
	private Vector2 m_RelativeVelocity; // 0x10
	[NativeName("friction")]
	private float m_Friction; // 0x18
	[NativeName("bounciness")]
	private float m_Bounciness; // 0x1C
	[NativeName("separation")]
	private float m_Separation; // 0x20
	[NativeName("normalImpulse")]
	private float m_NormalImpulse; // 0x24
	[NativeName("tangentImpulse")]
	private float m_TangentImpulse; // 0x28
	[NativeName("collider")]
	private int m_Collider; // 0x2C
	[NativeName("otherCollider")]
	private int m_OtherCollider; // 0x30
	[NativeName("rigidbody")]
	private int m_Rigidbody; // 0x34
	[NativeName("otherRigidbody")]
	private int m_OtherRigidbody; // 0x38
	[NativeName("enabled")]
	private int m_Enabled; // 0x3C
}

// Namespace: UnityEngine
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/Interfaces/IPhysics2D.h")]
[NativeClass("RaycastHit2D", "struct RaycastHit2D;")]
public struct RaycastHit2D // TypeDefIndex: 8031
{
	// Fields
	[NativeName("centroid")]
	private Vector2 m_Centroid; // 0x0
	[NativeName("point")]
	private Vector2 m_Point; // 0x8
	[NativeName("normal")]
	private Vector2 m_Normal; // 0x10
	[NativeName("distance")]
	private float m_Distance; // 0x18
	[NativeName("fraction")]
	private float m_Fraction; // 0x1C
	[NativeName("collider")]
	private int m_Collider; // 0x20

	// Properties
	public Vector2 point { get; }
	public Vector2 normal { get; }
	public float distance { get; }
	public Collider2D collider { get; }

	// Methods

	// RVA: 0x1E99FB0 Offset: 0x1E95FB0 VA: 0x1E99FB0
	public Vector2 get_point() { }

	// RVA: 0x1E99FB8 Offset: 0x1E95FB8 VA: 0x1E99FB8
	public Vector2 get_normal() { }

	// RVA: 0x1E99FC0 Offset: 0x1E95FC0 VA: 0x1E99FC0
	public float get_distance() { }

	// RVA: 0x1E99FC8 Offset: 0x1E95FC8 VA: 0x1E99FC8
	public Collider2D get_collider() { }
}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
public sealed class Rigidbody2D : Component // TypeDefIndex: 8032
{}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform))]
[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
[RequiredByNativeCode(Optional = True)]
public class Collider2D : Behaviour // TypeDefIndex: 8033
{
	// Properties
	public Vector2 offset { set; }

	// Methods

	// RVA: 0x1E9A074 Offset: 0x1E96074 VA: 0x1E9A074
	public void set_offset(Vector2 value) { }

	// RVA: 0x1E9A0F8 Offset: 0x1E960F8 VA: 0x1E9A0F8
	private static void set_offset_Injected(IntPtr _unity_self, in Vector2 value) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Physics2D/Public/BoxCollider2D.h")]
public sealed class BoxCollider2D : Collider2D // TypeDefIndex: 8034
{
	// Properties
	public Vector2 size { set; }

	// Methods

	// RVA: 0x1E9A13C Offset: 0x1E9613C VA: 0x1E9A13C
	public void set_size(Vector2 value) { }

	// RVA: 0x1E9A1C0 Offset: 0x1E961C0 VA: 0x1E9A1C0
	private static void set_size_Injected(IntPtr _unity_self, in Vector2 value) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 8035
{}

// Namespace: UnityEngine
public enum TouchPhase // TypeDefIndex: 8036
{
	// Fields
	public int value__; // 0x0
	public const TouchPhase Began = 0;
	public const TouchPhase Moved = 1;
	public const TouchPhase Stationary = 2;
	public const TouchPhase Ended = 3;
	public const TouchPhase Canceled = 4;
}

// Namespace: UnityEngine
public enum IMECompositionMode // TypeDefIndex: 8037
{
	// Fields
	public int value__; // 0x0
	public const IMECompositionMode Auto = 0;
	public const IMECompositionMode On = 1;
	public const IMECompositionMode Off = 2;
}

// Namespace: UnityEngine
public enum TouchType // TypeDefIndex: 8038
{
	// Fields
	public int value__; // 0x0
	public const TouchType Direct = 0;
	public const TouchType Indirect = 1;
	public const TouchType Stylus = 2;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputBindings.h")]
public struct Touch // TypeDefIndex: 8039
{
	// Fields
	private int m_FingerId; // 0x0
	private Vector2 m_Position; // 0x4
	private Vector2 m_RawPosition; // 0xC
	private Vector2 m_PositionDelta; // 0x14
	private float m_TimeDelta; // 0x1C
	private int m_TapCount; // 0x20
	private TouchPhase m_Phase; // 0x24
	private TouchType m_Type; // 0x28
	private float m_Pressure; // 0x2C
	private float m_maximumPossiblePressure; // 0x30
	private float m_Radius; // 0x34
	private float m_RadiusVariance; // 0x38
	private float m_AltitudeAngle; // 0x3C
	private float m_AzimuthAngle; // 0x40

	// Properties
	public int fingerId { get; }
	public Vector2 position { get; }
	public TouchPhase phase { get; }
	public float pressure { get; }
	public TouchType type { get; }
	public float altitudeAngle { get; }
	public float azimuthAngle { get; }
	public float radius { get; }
	public float radiusVariance { get; }

	// Methods

	// RVA: 0x1E96504 Offset: 0x1E92504 VA: 0x1E96504
	public int get_fingerId() { }

	// RVA: 0x1E9650C Offset: 0x1E9250C VA: 0x1E9650C
	public Vector2 get_position() { }

	// RVA: 0x1E96514 Offset: 0x1E92514 VA: 0x1E96514
	public TouchPhase get_phase() { }

	// RVA: 0x1E9651C Offset: 0x1E9251C VA: 0x1E9651C
	public float get_pressure() { }

	// RVA: 0x1E96524 Offset: 0x1E92524 VA: 0x1E96524
	public TouchType get_type() { }

	// RVA: 0x1E9652C Offset: 0x1E9252C VA: 0x1E9652C
	public float get_altitudeAngle() { }

	// RVA: 0x1E96534 Offset: 0x1E92534 VA: 0x1E96534
	public float get_azimuthAngle() { }

	// RVA: 0x1E9653C Offset: 0x1E9253C VA: 0x1E9653C
	public float get_radius() { }

	// RVA: 0x1E96544 Offset: 0x1E92544 VA: 0x1E96544
	public float get_radiusVariance() { }
}

// Namespace: UnityEngine
[Flags]
public enum PenStatus // TypeDefIndex: 8040
{
	// Fields
	public int value__; // 0x0
	public const PenStatus None = 0;
	public const PenStatus Contact = 1;
	public const PenStatus Barrel = 2;
	public const PenStatus Inverted = 4;
	public const PenStatus Eraser = 8;
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Camera/Camera.h")]
internal class CameraRaycastHelper // TypeDefIndex: 8041
{
	// Methods

	[FreeFunction("CameraScripting::RaycastTry")]
	// RVA: 0x1E9654C Offset: 0x1E9254C VA: 0x1E9654C
	internal static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask) { }

	[FreeFunction("CameraScripting::RaycastTry2D")]
	// RVA: 0x1E96670 Offset: 0x1E92670 VA: 0x1E96670
	internal static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask) { }

	// RVA: 0x1E9660C Offset: 0x1E9260C VA: 0x1E9660C
	private static IntPtr RaycastTry_Injected(IntPtr cam, in Ray ray, float distance, int layerMask) { }

	// RVA: 0x1E96730 Offset: 0x1E92730 VA: 0x1E96730
	private static IntPtr RaycastTry2D_Injected(IntPtr cam, in Ray ray, float distance, int layerMask) { }
}

// Namespace: UnityEngine
[NativeHeader("Runtime/Input/InputBindings.h")]
public class Input // TypeDefIndex: 8042
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static bool <simulateTouchEnabled>k__BackingField; // 0x0

	// Properties
	[NativeThrows]
	public static Vector3 mousePosition { get; }
	[NativeThrows]
	public static Vector2 mouseScrollDelta { get; }
	public static IMECompositionMode imeCompositionMode { get; set; }
	public static string compositionString { get; }
	public static Vector2 compositionCursorPos { get; set; }
	internal static bool simulateTouchEnabled { get; }
	public static bool mousePresent { get; }
	public static bool touchSupported { get; }
	public static int touchCount { get; }
	public static Touch[] touches { get; }

	// Methods

	// RVA: 0x1E96794 Offset: 0x1E92794 VA: 0x1E96794
	public static float GetAxisRaw(string axisName) { }

	// RVA: 0x1E96904 Offset: 0x1E92904 VA: 0x1E96904
	public static bool GetButtonDown(string buttonName) { }

	[NativeThrows]
	// RVA: 0x1E96A7C Offset: 0x1E92A7C VA: 0x1E96A7C
	private static bool GetKeyInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x1E96AB8 Offset: 0x1E92AB8 VA: 0x1E96AB8
	private static bool GetKeyDownInt(KeyCode key) { }

	[NativeThrows]
	// RVA: 0x1E96AF4 Offset: 0x1E92AF4 VA: 0x1E96AF4
	public static bool GetMouseButton(int button) { }

	[NativeThrows]
	// RVA: 0x1E96B30 Offset: 0x1E92B30 VA: 0x1E96B30
	public static bool GetMouseButtonDown(int button) { }

	[NativeThrows]
	// RVA: 0x1E96B6C Offset: 0x1E92B6C VA: 0x1E96B6C
	public static bool GetMouseButtonUp(int button) { }

	[NativeThrows]
	// RVA: 0x1E96BA8 Offset: 0x1E92BA8 VA: 0x1E96BA8
	public static Touch GetTouch(int index) { }

	// RVA: 0x1E96C5C Offset: 0x1E92C5C VA: 0x1E96C5C
	public static bool GetKey(KeyCode key) { }

	// RVA: 0x1E96C98 Offset: 0x1E92C98 VA: 0x1E96C98
	public static bool GetKeyDown(KeyCode key) { }

	// RVA: 0x1E96CD4 Offset: 0x1E92CD4 VA: 0x1E96CD4
	public static Vector3 get_mousePosition() { }

	// RVA: 0x1E96D5C Offset: 0x1E92D5C VA: 0x1E96D5C
	public static Vector2 get_mouseScrollDelta() { }

	// RVA: 0x1E96DDC Offset: 0x1E92DDC VA: 0x1E96DDC
	public static IMECompositionMode get_imeCompositionMode() { }

	// RVA: 0x1E96E04 Offset: 0x1E92E04 VA: 0x1E96E04
	public static void set_imeCompositionMode(IMECompositionMode value) { }

	// RVA: 0x1E96E40 Offset: 0x1E92E40 VA: 0x1E96E40
	public static string get_compositionString() { }

	// RVA: 0x1E96F40 Offset: 0x1E92F40 VA: 0x1E96F40
	public static Vector2 get_compositionCursorPos() { }

	// RVA: 0x1E96FC0 Offset: 0x1E92FC0 VA: 0x1E96FC0
	public static void set_compositionCursorPos(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0x1E9703C Offset: 0x1E9303C VA: 0x1E9703C
	internal static bool get_simulateTouchEnabled() { }

	[FreeFunction("GetMousePresent")]
	// RVA: 0x1E97084 Offset: 0x1E93084 VA: 0x1E97084
	private static bool GetMousePresentInternal() { }

	[FreeFunction("IsTouchSupported")]
	// RVA: 0x1E970AC Offset: 0x1E930AC VA: 0x1E970AC
	private static bool GetTouchSupportedInternal() { }

	// RVA: 0x1E970D4 Offset: 0x1E930D4 VA: 0x1E970D4
	public static bool get_mousePresent() { }

	// RVA: 0x1E97140 Offset: 0x1E93140 VA: 0x1E97140
	public static bool get_touchSupported() { }

	[FreeFunction("GetTouchCount")]
	// RVA: 0x1E971AC Offset: 0x1E931AC VA: 0x1E971AC
	public static int get_touchCount() { }

	// RVA: 0x1E971D4 Offset: 0x1E931D4 VA: 0x1E971D4
	public static Touch[] get_touches() { }

	// RVA: 0x1E97300 Offset: 0x1E93300 VA: 0x1E97300
	internal static bool CheckDisabled() { }

	// RVA: 0x1E96C18 Offset: 0x1E92C18 VA: 0x1E96C18
	private static void GetTouch_Injected(int index, out Touch ret) { }

	// RVA: 0x1E96D20 Offset: 0x1E92D20 VA: 0x1E96D20
	private static void get_mousePosition_Injected(out Vector3 ret) { }

	// RVA: 0x1E96DA0 Offset: 0x1E92DA0 VA: 0x1E96DA0
	private static void get_mouseScrollDelta_Injected(out Vector2 ret) { }

	// RVA: 0x1E96F04 Offset: 0x1E92F04 VA: 0x1E96F04
	private static void get_compositionString_Injected(out ManagedSpanWrapper ret) { }

	// RVA: 0x1E96F84 Offset: 0x1E92F84 VA: 0x1E96F84
	private static void get_compositionCursorPos_Injected(out Vector2 ret) { }

	// RVA: 0x1E97000 Offset: 0x1E93000 VA: 0x1E97000
	private static void set_compositionCursorPos_Injected(in Vector2 value) { }
}

// Namespace: 
private struct SendMouseEvents.HitInfo // TypeDefIndex: 8043
{
	// Fields
	public GameObject target; // 0x0
	public Camera camera; // 0x8

	// Methods

	// RVA: 0x1E983AC Offset: 0x1E943AC VA: 0x1E983AC
	public void SendMessage(string name) { }

	// RVA: 0x1E9830C Offset: 0x1E9430C VA: 0x1E9830C
	public static bool op_Implicit(SendMouseEvents.HitInfo exists) { }

	// RVA: 0x1E983CC Offset: 0x1E943CC VA: 0x1E983CC
	public static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs) { }
}

// Namespace: UnityEngine
internal class SendMouseEvents // TypeDefIndex: 8044
{
	// Fields
	private static bool s_MouseUsed; // 0x0
	private static readonly SendMouseEvents.HitInfo[] m_LastHit; // 0x8
	private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit; // 0x10
	private static readonly SendMouseEvents.HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20
	public static Func<KeyValuePair<int, Vector2>> s_GetMouseState; // 0x28
	private static Vector2 s_MousePosition; // 0x30
	private static bool s_MouseButtonPressedThisFrame; // 0x38
	private static bool s_MouseButtonIsPressed; // 0x39

	// Methods

	// RVA: 0x1E97328 Offset: 0x1E93328 VA: 0x1E97328
	private static void UpdateMouse() { }

	[RequiredByNativeCode]
	// RVA: 0x1E974E8 Offset: 0x1E934E8 VA: 0x1E974E8
	private static void SetMouseMoved() { }

	[RequiredByNativeCode]
	// RVA: 0x1E97544 Offset: 0x1E93544 VA: 0x1E97544
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x1E97EB0 Offset: 0x1E93EB0 VA: 0x1E97EB0
	private static void SendEvents(int i, SendMouseEvents.HitInfo hit) { }

	// RVA: 0x1E98480 Offset: 0x1E94480 VA: 0x1E98480
	private static void .cctor() { }
}

// Namespace: UnityEngine
[StaticAccessor("GetAudioManager()", 0)]
[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
public sealed class AudioSettings // TypeDefIndex: 8049
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action OnAudioSystemShuttingDown; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action OnAudioSystemStartedUp; // 0x10

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E48754 Offset: 0x1E44754 VA: 0x1E48754
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	[RequiredByNativeCode]
	// RVA: 0x1E487C0 Offset: 0x1E447C0 VA: 0x1E487C0
	internal static void InvokeOnAudioSystemShuttingDown() { }

	[RequiredByNativeCode]
	// RVA: 0x1E48824 Offset: 0x1E44824 VA: 0x1E48824
	internal static void InvokeOnAudioSystemStartedUp() { }

	// RVA: 0x1E48888 Offset: 0x1E44888 VA: 0x1E48888
	internal static bool StartAudioOutput() { }

	// RVA: 0x1E488B0 Offset: 0x1E448B0 VA: 0x1E488B0
	internal static bool StopAudioOutput() { }
}

// Namespace: 
public sealed class AudioClip.PCMReaderCallback : MulticastDelegate // TypeDefIndex: 8050
{
	// Methods

	// RVA: 0x1E48D3C Offset: 0x1E44D3C VA: 0x1E48D3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E48DEC Offset: 0x1E44DEC VA: 0x1E48DEC Slot: 12
	public virtual void Invoke(float[] data) { }
}

// Namespace: 
public sealed class AudioClip.PCMSetPositionCallback : MulticastDelegate // TypeDefIndex: 8051
{
	// Methods

	// RVA: 0x1E48E00 Offset: 0x1E44E00 VA: 0x1E48E00
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E48EA0 Offset: 0x1E44EA0 VA: 0x1E48EA0 Slot: 12
	public virtual void Invoke(int position) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
[StaticAccessor("AudioClipBindings", 2)]
public sealed class AudioClip : AudioResource // TypeDefIndex: 8052
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AudioClip.PCMReaderCallback m_PCMReaderCallback; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Methods

	// RVA: 0x1E48C7C Offset: 0x1E44C7C VA: 0x1E48C7C
	private void .ctor() { }

	[RequiredByNativeCode]
	// RVA: 0x1E48D04 Offset: 0x1E44D04 VA: 0x1E48D04
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	[RequiredByNativeCode]
	// RVA: 0x1E48D20 Offset: 0x1E44D20 VA: 0x1E48D20
	private void InvokePCMSetPositionCallback_Internal(int position) { }
}

// Namespace: UnityEngine
public class AudioBehaviour : Behaviour // TypeDefIndex: 8053
{
	// Methods

	// RVA: 0x1E48EB4 Offset: 0x1E44EB4 VA: 0x1E48EB4
	public void .ctor() { }
}

// Namespace: UnityEngine
[StaticAccessor("AudioListenerBindings", 2)]
[RequireComponent(typeof(Transform))]
public sealed class AudioListener : AudioBehaviour // TypeDefIndex: 8054
{}

// Namespace: UnityEngine
[RequireComponent(typeof(Transform))]
[StaticAccessor("AudioSourceBindings", 2)]
public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 8055
{
	// Properties
	public float volume { set; }
	public float pitch { get; set; }
	public AudioClip clip { set; }
	public AudioResource resource { set; }
	public AudioMixerGroup outputAudioMixerGroup { get; set; }
	public bool isPlaying { get; }
	public bool loop { set; }

	// Methods

	// RVA: 0x1E48EBC Offset: 0x1E44EBC VA: 0x1E48EBC
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x1E48FA0 Offset: 0x1E44FA0 VA: 0x1E48FA0
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x1E490A4 Offset: 0x1E450A4 VA: 0x1E490A4
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x1E49198 Offset: 0x1E45198 VA: 0x1E49198
	private void Play(double delay) { }

	// RVA: 0x1E4926C Offset: 0x1E4526C VA: 0x1E4926C
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x1E493EC Offset: 0x1E453EC VA: 0x1E493EC
	private void Stop(bool stopOneShots) { }

	// RVA: 0x1E494B0 Offset: 0x1E454B0 VA: 0x1E494B0
	public void set_volume(float value) { }

	// RVA: 0x1E49584 Offset: 0x1E45584 VA: 0x1E49584
	public float get_pitch() { }

	// RVA: 0x1E49588 Offset: 0x1E45588 VA: 0x1E49588
	public void set_pitch(float value) { }

	// RVA: 0x1E4958C Offset: 0x1E4558C VA: 0x1E4958C
	public void set_clip(AudioClip value) { }

	// RVA: 0x1E49590 Offset: 0x1E45590 VA: 0x1E49590
	public void set_resource(AudioResource value) { }

	// RVA: 0x1E49688 Offset: 0x1E45688 VA: 0x1E49688
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x1E49758 Offset: 0x1E45758 VA: 0x1E49758
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocs]
	// RVA: 0x1E49850 Offset: 0x1E45850 VA: 0x1E49850
	public void Play() { }

	// RVA: 0x1E49858 Offset: 0x1E45858 VA: 0x1E49858
	public void PlayDelayed(float delay) { }

	[ExcludeFromDocs]
	// RVA: 0x1E4987C Offset: 0x1E4587C VA: 0x1E4987C
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x1E49884 Offset: 0x1E45884 VA: 0x1E49884
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x1E49960 Offset: 0x1E45960 VA: 0x1E49960
	public void Stop() { }

	[NativeName("IsPlayingScripting")]
	// RVA: 0x1E49968 Offset: 0x1E45968 VA: 0x1E49968
	public bool get_isPlaying() { }

	// RVA: 0x1E49A1C Offset: 0x1E45A1C VA: 0x1E49A1C
	public void set_loop(bool value) { }

	// RVA: 0x1E49AE0 Offset: 0x1E45AE0 VA: 0x1E49AE0
	public void .ctor() { }

	// RVA: 0x1E48F64 Offset: 0x1E44F64 VA: 0x1E48F64
	private static float GetPitch_Injected(IntPtr source) { }

	// RVA: 0x1E49058 Offset: 0x1E45058 VA: 0x1E49058
	private static void SetPitch_Injected(IntPtr source, float pitch) { }

	// RVA: 0x1E49154 Offset: 0x1E45154 VA: 0x1E49154
	private static void PlayHelper_Injected(IntPtr source, ulong delay) { }

	// RVA: 0x1E49220 Offset: 0x1E45220 VA: 0x1E49220
	private static void Play_Injected(IntPtr _unity_self, double delay) { }

	// RVA: 0x1E49398 Offset: 0x1E45398 VA: 0x1E49398
	private static void PlayOneShotHelper_Injected(IntPtr source, IntPtr clip, float volumeScale) { }

	// RVA: 0x1E4946C Offset: 0x1E4546C VA: 0x1E4946C
	private static void Stop_Injected(IntPtr _unity_self, bool stopOneShots) { }

	// RVA: 0x1E49538 Offset: 0x1E45538 VA: 0x1E49538
	private static void set_volume_Injected(IntPtr _unity_self, float value) { }

	// RVA: 0x1E49644 Offset: 0x1E45644 VA: 0x1E49644
	private static void set_resource_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x1E4971C Offset: 0x1E4571C VA: 0x1E4971C
	private static IntPtr get_outputAudioMixerGroup_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E4980C Offset: 0x1E4580C VA: 0x1E4980C
	private static void set_outputAudioMixerGroup_Injected(IntPtr _unity_self, IntPtr value) { }

	// RVA: 0x1E499E0 Offset: 0x1E459E0 VA: 0x1E499E0
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E49A9C Offset: 0x1E45A9C VA: 0x1E49A9C
	private static void set_loop_Injected(IntPtr _unity_self, bool value) { }
}

// Namespace: 
public sealed class AudioSampleProvider.SampleFramesHandler : MulticastDelegate // TypeDefIndex: 8056
{
	// Methods

	// RVA: 0x1E49B38 Offset: 0x1E45B38 VA: 0x1E49B38
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E49C44 Offset: 0x1E45C44 VA: 0x1E49C44 Slot: 12
	public virtual void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(4, Inherited = False)]
internal sealed class AssetFileNameExtensionAttribute : Attribute // TypeDefIndex: 8066
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <preferredExtension>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly IEnumerable<string> <otherExtensions>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1E9D4FC Offset: 0x1E994FC VA: 0x1E9D4FC
	public void .ctor(string preferredExtension, string[] otherExtensions) { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
[Usage(64)]
internal class ThreadAndSerializationSafeAttribute : Attribute // TypeDefIndex: 8067
{
	// Methods

	// RVA: 0x1E9D540 Offset: 0x1E99540 VA: 0x1E9D540
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(2048, AllowMultiple = False)]
[VisibleToOtherModules]
internal class WritableAttribute : Attribute // TypeDefIndex: 8068
{
	// Methods

	// RVA: 0x1E9D548 Offset: 0x1E99548 VA: 0x1E9D548
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(1)]
[VisibleToOtherModules]
internal class UnityEngineModuleAssembly : Attribute // TypeDefIndex: 8069
{
	// Methods

	// RVA: 0x1E9D550 Offset: 0x1E99550 VA: 0x1E9D550
	public void .ctor() { }
}

// Namespace: UnityEngine
[Usage(12, Inherited = False)]
[VisibleToOtherModules]
internal sealed class NativeClassAttribute : Attribute // TypeDefIndex: 8070
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <QualifiedNativeName>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <Declaration>k__BackingField; // 0x18

	// Properties
	private string QualifiedNativeName { set; }
	private string Declaration { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E9D558 Offset: 0x1E99558 VA: 0x1E9D558
	private void set_QualifiedNativeName(string value) { }

	[CompilerGenerated]
	// RVA: 0x1E9D560 Offset: 0x1E99560 VA: 0x1E9D560
	private void set_Declaration(string value) { }

	// RVA: 0x1E9D568 Offset: 0x1E99568 VA: 0x1E9D568
	public void .ctor(string qualifiedCppName) { }

	// RVA: 0x1E9D5EC Offset: 0x1E995EC VA: 0x1E9D5EC
	public void .ctor(string qualifiedCppName, string declaration) { }
}

// Namespace: UnityEngine
[VisibleToOtherModules]
internal sealed class UnityString // TypeDefIndex: 8071
{
	// Methods

	// RVA: 0x1E9D630 Offset: 0x1E99630 VA: 0x1E9D630
	public static string Format(string fmt, object[] args) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromMemoryAsyncOperation.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromManagedStreamAsyncOperation.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
[NativeHeader("Runtime/Scripting/ScriptingExportUtility.h")]
[NativeHeader("Runtime/Scripting/ScriptingUtility.h")]
[NativeHeader("AssetBundleScriptingClasses.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleSaveAndLoadHelper.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleUtility.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetUtility.h")]
[ExcludeFromPreset]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromFileAsyncOperation.h")]
public class AssetBundle : Object // TypeDefIndex: 8094
{
	// Methods

	// RVA: 0x1E47DD8 Offset: 0x1E43DD8 VA: 0x1E47DD8
	private void .ctor() { }

	[FreeFunction("LoadFromFile")]
	// RVA: 0x1E47E30 Offset: 0x1E43E30 VA: 0x1E47E30
	internal static AssetBundle LoadFromFile_Internal(string path, uint crc, ulong offset) { }

	// RVA: 0x1E48090 Offset: 0x1E44090 VA: 0x1E48090
	public static AssetBundle LoadFromFile(string path) { }

	[FreeFunction("LoadFromMemory")]
	// RVA: 0x1E4809C Offset: 0x1E4409C VA: 0x1E4809C
	internal static AssetBundle LoadFromMemory_Internal(byte[] binary, uint crc) { }

	// RVA: 0x1E481D0 Offset: 0x1E441D0 VA: 0x1E481D0
	public static AssetBundle LoadFromMemory(byte[] binary) { }

	// RVA: 0x1E481D8 Offset: 0x1E441D8 VA: 0x1E481D8
	public Object LoadAsset(string name) { }

	// RVA: -1 Offset: -1
	public T LoadAsset<T>(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10E8CA8 Offset: 0x10E4CA8 VA: 0x10E8CA8
	|-AssetBundle.LoadAsset<object>
	*/

	[TypeInferenceRule(1)]
	// RVA: 0x1E48258 Offset: 0x1E44258 VA: 0x1E48258
	public Object LoadAsset(string name, Type type) { }

	[TypeInferenceRule(1)]
	[NativeMethod("LoadAsset_Internal")]
	[NativeThrows]
	// RVA: 0x1E48358 Offset: 0x1E44358 VA: 0x1E48358
	private Object LoadAsset_Internal(string name, Type type) { }

	[NativeMethod("Unload")]
	[NativeThrows]
	// RVA: 0x1E485D4 Offset: 0x1E445D4 VA: 0x1E485D4
	public void Unload(bool unloadAllLoadedObjects) { }

	// RVA: 0x1E4803C Offset: 0x1E4403C VA: 0x1E4803C
	private static IntPtr LoadFromFile_Internal_Injected(ref ManagedSpanWrapper path, uint crc, ulong offset) { }

	// RVA: 0x1E4818C Offset: 0x1E4418C VA: 0x1E4818C
	private static IntPtr LoadFromMemory_Internal_Injected(ref ManagedSpanWrapper binary, uint crc) { }

	// RVA: 0x1E48580 Offset: 0x1E44580 VA: 0x1E48580
	private static IntPtr LoadAsset_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, Type type) { }

	// RVA: 0x1E48654 Offset: 0x1E44654 VA: 0x1E48654
	private static void Unload_Injected(IntPtr _unity_self, bool unloadAllLoadedObjects) { }
}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromAsyncOperation.h")]
[RequiredByNativeCode]
public class AssetBundleCreateRequest : AsyncOperation // TypeDefIndex: 8095
{}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleRecompressOperation.h")]
[RequiredByNativeCode]
public class AssetBundleRecompressOperation : AsyncOperation // TypeDefIndex: 8096
{}

// Namespace: UnityEngine
[RequiredByNativeCode]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
public class AssetBundleRequest : ResourceRequest // TypeDefIndex: 8097
{}

// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleUnloadOperation.h")]
[RequiredByNativeCode]
public class AssetBundleUnloadOperation : AsyncOperation // TypeDefIndex: 8098
{}

// Namespace: 
internal class <Module> // TypeDefIndex: 8099
{}

// Namespace: UnityEngine
[Extension]
[NativeHeader("Modules/ImageConversion/ScriptBindings/ImageConversion.bindings.h")]
public static class ImageConversion // TypeDefIndex: 8100
{
	// Methods

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::EncodeToTGA", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x1E88764 Offset: 0x1E84764 VA: 0x1E88764
	public static byte[] EncodeToTGA(Texture2D tex) { }

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::EncodeToPNG", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x1E888EC Offset: 0x1E848EC VA: 0x1E888EC
	public static byte[] EncodeToPNG(Texture2D tex) { }

	[Extension]
	[NativeMethod(Name = "ImageConversionBindings::EncodeToJPG", IsFreeFunction = True, ThrowsException = True)]
	// RVA: 0x1E88A74 Offset: 0x1E84A74 VA: 0x1E88A74
	public static byte[] EncodeToJPG(Texture2D tex, int quality) { }

	[NativeMethod(Name = "ImageConversionBindings::LoadImage", IsFreeFunction = True)]
	[Extension]
	// RVA: 0x1E88C20 Offset: 0x1E84C20 VA: 0x1E88C20
	public static bool LoadImage(Texture2D tex, ReadOnlySpan<byte> data, bool markNonReadable) { }

	[Extension]
	// RVA: 0x1E88D9C Offset: 0x1E84D9C VA: 0x1E88D9C
	public static bool LoadImage(Texture2D tex, byte[] data) { }

	// RVA: 0x1E888A8 Offset: 0x1E848A8 VA: 0x1E888A8
	private static void EncodeToTGA_Injected(IntPtr tex, out BlittableArrayWrapper ret) { }

	// RVA: 0x1E88A30 Offset: 0x1E84A30 VA: 0x1E88A30
	private static void EncodeToPNG_Injected(IntPtr tex, out BlittableArrayWrapper ret) { }

	// RVA: 0x1E88BCC Offset: 0x1E84BCC VA: 0x1E88BCC
	private static void EncodeToJPG_Injected(IntPtr tex, int quality, out BlittableArrayWrapper ret) { }

	// RVA: 0x1E88D48 Offset: 0x1E84D48 VA: 0x1E88D48
	private static bool LoadImage_Injected(IntPtr tex, ref ManagedSpanWrapper data, bool markNonReadable) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 8101
{}

// Namespace: 
public sealed class NavMesh.OnNavMeshPreUpdate : MulticastDelegate // TypeDefIndex: 8102
{
	// Methods

	// RVA: 0x1E2FB80 Offset: 0x1E2BB80 VA: 0x1E2FB80
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E2FC1C Offset: 0x1E2BC1C VA: 0x1E2FC1C Slot: 12
	public virtual void Invoke() { }
}
