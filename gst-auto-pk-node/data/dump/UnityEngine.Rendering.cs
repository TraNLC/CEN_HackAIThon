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

// Namespace: UnityEngine.Rendering
[NativeType(Header = "Runtime/2D/Sorting/SortingGroup.h")]
[RequireComponent(typeof(Transform))]
public sealed class SortingGroup : Behaviour // TypeDefIndex: 7118
{
	// Properties
	[StaticAccessor("SortingGroup", 2)]
	internal static int invalidSortingGroupID { get; }
	public int sortingLayerID { get; }
	public int sortingOrder { get; set; }

	// Methods

	// RVA: 0x1E80638 Offset: 0x1E7C638 VA: 0x1E80638
	internal static int get_invalidSortingGroupID() { }

	[StaticAccessor("SortingGroup", 2)]
	// RVA: 0x1E80660 Offset: 0x1E7C660 VA: 0x1E80660
	internal static SortingGroup GetSortingGroupByIndex(int index) { }

	// RVA: 0x1E80708 Offset: 0x1E7C708 VA: 0x1E80708
	public int get_sortingLayerID() { }

	// RVA: 0x1E807BC Offset: 0x1E7C7BC VA: 0x1E807BC
	public int get_sortingOrder() { }

	// RVA: 0x1E80870 Offset: 0x1E7C870 VA: 0x1E80870
	public void set_sortingOrder(int value) { }

	// RVA: 0x1E80934 Offset: 0x1E7C934 VA: 0x1E80934
	public void .ctor() { }

	// RVA: 0x1E806CC Offset: 0x1E7C6CC VA: 0x1E806CC
	private static IntPtr GetSortingGroupByIndex_Injected(int index) { }

	// RVA: 0x1E80780 Offset: 0x1E7C780 VA: 0x1E80780
	private static int get_sortingLayerID_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E80834 Offset: 0x1E7C834 VA: 0x1E80834
	private static int get_sortingOrder_Injected(IntPtr _unity_self) { }

	// RVA: 0x1E808F0 Offset: 0x1E7C8F0 VA: 0x1E808F0
	private static void set_sortingOrder_Injected(IntPtr _unity_self, int value) { }
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Graphics/Texture.h")]
[NativeHeader("Runtime/Graphics/AsyncGPUReadbackManaged.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
public struct AsyncGPUReadbackRequest // TypeDefIndex: 7119
{
	// Fields
	internal IntPtr m_Ptr; // 0x0
	internal int m_Version; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E8093C Offset: 0x1E7C93C VA: 0x1E8093C
	private static void InvokeCallback(Action<AsyncGPUReadbackRequest> callback, AsyncGPUReadbackRequest obj) { }
}

// Namespace: UnityEngine.Rendering
public enum IndexFormat // TypeDefIndex: 7120
{
	// Fields
	public int value__; // 0x0
	public const IndexFormat UInt16 = 0;
	public const IndexFormat UInt32 = 1;
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum MeshUpdateFlags // TypeDefIndex: 7121
{
	// Fields
	public int value__; // 0x0
	public const MeshUpdateFlags Default = 0;
	public const MeshUpdateFlags DontValidateIndices = 1;
	public const MeshUpdateFlags DontResetBoneBounds = 2;
	public const MeshUpdateFlags DontNotifyMeshUsers = 4;
	public const MeshUpdateFlags DontRecalculateBounds = 8;
}

// Namespace: UnityEngine.Rendering
public enum VertexAttributeFormat // TypeDefIndex: 7122
{
	// Fields
	public int value__; // 0x0
	public const VertexAttributeFormat Float32 = 0;
	public const VertexAttributeFormat Float16 = 1;
	public const VertexAttributeFormat UNorm8 = 2;
	public const VertexAttributeFormat SNorm8 = 3;
	public const VertexAttributeFormat UNorm16 = 4;
	public const VertexAttributeFormat SNorm16 = 5;
	public const VertexAttributeFormat UInt8 = 6;
	public const VertexAttributeFormat SInt8 = 7;
	public const VertexAttributeFormat UInt16 = 8;
	public const VertexAttributeFormat SInt16 = 9;
	public const VertexAttributeFormat UInt32 = 10;
	public const VertexAttributeFormat SInt32 = 11;
}

// Namespace: UnityEngine.Rendering
[MovedFrom("UnityEngine.Experimental.Rendering")]
public enum VertexAttribute // TypeDefIndex: 7123
{
	// Fields
	public int value__; // 0x0
	public const VertexAttribute Position = 0;
	public const VertexAttribute Normal = 1;
	public const VertexAttribute Tangent = 2;
	public const VertexAttribute Color = 3;
	public const VertexAttribute TexCoord0 = 4;
	public const VertexAttribute TexCoord1 = 5;
	public const VertexAttribute TexCoord2 = 6;
	public const VertexAttribute TexCoord3 = 7;
	public const VertexAttribute TexCoord4 = 8;
	public const VertexAttribute TexCoord5 = 9;
	public const VertexAttribute TexCoord6 = 10;
	public const VertexAttribute TexCoord7 = 11;
	public const VertexAttribute BlendWeight = 12;
	public const VertexAttribute BlendIndices = 13;
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
public enum CompareFunction // TypeDefIndex: 7124
{
	// Fields
	public int value__; // 0x0
	public const CompareFunction Disabled = 0;
	public const CompareFunction Never = 1;
	public const CompareFunction Less = 2;
	public const CompareFunction Equal = 3;
	public const CompareFunction LessEqual = 4;
	public const CompareFunction Greater = 5;
	public const CompareFunction NotEqual = 6;
	public const CompareFunction GreaterEqual = 7;
	public const CompareFunction Always = 8;
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum ColorWriteMask // TypeDefIndex: 7125
{
	// Fields
	public int value__; // 0x0
	public const ColorWriteMask Alpha = 1;
	public const ColorWriteMask Blue = 2;
	public const ColorWriteMask Green = 4;
	public const ColorWriteMask Red = 8;
	public const ColorWriteMask All = 15;
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
public enum StencilOp // TypeDefIndex: 7126
{
	// Fields
	public int value__; // 0x0
	public const StencilOp Keep = 0;
	public const StencilOp Zero = 1;
	public const StencilOp Replace = 2;
	public const StencilOp IncrementSaturate = 3;
	public const StencilOp DecrementSaturate = 4;
	public const StencilOp Invert = 5;
	public const StencilOp IncrementWrap = 6;
	public const StencilOp DecrementWrap = 7;
}

// Namespace: UnityEngine.Rendering
public enum ShadowCastingMode // TypeDefIndex: 7127
{
	// Fields
	public int value__; // 0x0
	public const ShadowCastingMode Off = 0;
	public const ShadowCastingMode On = 1;
	public const ShadowCastingMode TwoSided = 2;
	public const ShadowCastingMode ShadowsOnly = 3;
}

// Namespace: UnityEngine.Rendering
public struct SubMeshDescriptor // TypeDefIndex: 7128
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private Bounds <bounds>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private MeshTopology <topology>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <indexStart>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <indexCount>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <baseVertex>k__BackingField; // 0x24
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <firstVertex>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <vertexCount>k__BackingField; // 0x2C

	// Properties
	public Bounds bounds { get; }
	public MeshTopology topology { get; }
	public int indexStart { get; }
	public int indexCount { get; }
	public int baseVertex { get; }
	public int firstVertex { get; }
	public int vertexCount { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1E8095C Offset: 0x1E7C95C VA: 0x1E8095C
	public Bounds get_bounds() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1E80970 Offset: 0x1E7C970 VA: 0x1E80970
	public MeshTopology get_topology() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1E80978 Offset: 0x1E7C978 VA: 0x1E80978
	public int get_indexStart() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1E80980 Offset: 0x1E7C980 VA: 0x1E80980
	public int get_indexCount() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1E80988 Offset: 0x1E7C988 VA: 0x1E80988
	public int get_baseVertex() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x1E80990 Offset: 0x1E7C990 VA: 0x1E80990
	public int get_firstVertex() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x1E80998 Offset: 0x1E7C998 VA: 0x1E80998
	public int get_vertexCount() { }

	// RVA: 0x1E809A0 Offset: 0x1E7C9A0 VA: 0x1E809A0 Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.Rendering
public enum ShadowSamplingMode // TypeDefIndex: 7129
{
	// Fields
	public int value__; // 0x0
	public const ShadowSamplingMode CompareDepths = 0;
	public const ShadowSamplingMode RawDepth = 1;
	public const ShadowSamplingMode None = 2;
}

// Namespace: UnityEngine.Rendering
public enum TextureDimension // TypeDefIndex: 7130
{
	// Fields
	public int value__; // 0x0
	public const TextureDimension Unknown = -1;
	public const TextureDimension None = 0;
	public const TextureDimension Any = 1;
	public const TextureDimension Tex2D = 2;
	public const TextureDimension Tex3D = 3;
	public const TextureDimension Cube = 4;
	public const TextureDimension Tex2DArray = 5;
	public const TextureDimension CubeArray = 6;
}

// Namespace: UnityEngine.Rendering
[StaticAccessor("GetGraphicsSettings()", 0)]
[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
public sealed class GraphicsSettings : Object // TypeDefIndex: 7131
{
	// Fields
	private static Lazy<RenderPipelineGlobalSettings> s_CurrentRenderPipelineGlobalSettings; // 0x0

	// Properties
	public static bool lightsUseLinearIntensity { get; }
	[NativeName("CurrentRenderPipeline")]
	private static ScriptableObject INTERNAL_currentRenderPipeline { get; }
	public static RenderPipelineAsset currentRenderPipeline { get; }

	// Methods

	[NativeName("GetSettingsForRenderPipeline")]
	// RVA: 0x1E80C84 Offset: 0x1E7CC84 VA: 0x1E80C84
	private static Object Internal_GetSettingsForRenderPipeline(string renderpipelineName) { }

	// RVA: 0x1E80EE4 Offset: 0x1E7CEE4 VA: 0x1E80EE4
	private static RenderPipelineGlobalSettings Internal_GetCurrentRenderPipelineGlobalSettings() { }

	// RVA: 0x1E810D0 Offset: 0x1E7D0D0 VA: 0x1E810D0
	public static bool get_lightsUseLinearIntensity() { }

	// RVA: 0x1E810F8 Offset: 0x1E7D0F8 VA: 0x1E810F8
	private static ScriptableObject get_INTERNAL_currentRenderPipeline() { }

	// RVA: 0x1E80FEC Offset: 0x1E7CFEC VA: 0x1E80FEC
	public static RenderPipelineAsset get_currentRenderPipeline() { }

	[VisibleToOtherModules]
	[RequiredByNativeCode]
	// RVA: 0x1E811A4 Offset: 0x1E7D1A4 VA: 0x1E811A4
	internal static Shader GetDefaultShader(DefaultShaderType type) { }

	[RequiredByNativeCode]
	[VisibleToOtherModules]
	// RVA: 0x1E81404 Offset: 0x1E7D404 VA: 0x1E81404
	internal static Material GetDefaultMaterial(DefaultMaterialType type) { }

	// RVA: 0x1E81648 Offset: 0x1E7D648 VA: 0x1E81648
	private static void .cctor() { }

	// RVA: 0x1E80EA8 Offset: 0x1E7CEA8 VA: 0x1E80EA8
	private static IntPtr Internal_GetSettingsForRenderPipeline_Injected(ref ManagedSpanWrapper renderpipelineName) { }

	// RVA: 0x1E8117C Offset: 0x1E7D17C VA: 0x1E8117C
	private static IntPtr get_INTERNAL_currentRenderPipeline_Injected() { }
}

// Namespace: UnityEngine.Rendering
[VisibleToOtherModules]
internal enum DefaultMaterialType // TypeDefIndex: 7132
{
	// Fields
	public int value__; // 0x0
	public const DefaultMaterialType Default = 0;
	public const DefaultMaterialType Particle = 1;
	public const DefaultMaterialType Line = 2;
	public const DefaultMaterialType Terrain = 3;
	public const DefaultMaterialType Sprite = 4;
	public const DefaultMaterialType SpriteMask = 5;
	public const DefaultMaterialType UGUI = 6;
	public const DefaultMaterialType UGUI_Overdraw = 7;
	public const DefaultMaterialType UGUI_ETC1Supported = 8;
}

// Namespace: UnityEngine.Rendering
[VisibleToOtherModules]
internal enum DefaultShaderType // TypeDefIndex: 7133
{
	// Fields
	public int value__; // 0x0
	public const DefaultShaderType Default = 0;
	public const DefaultShaderType AutodeskInteractive = 1;
	public const DefaultShaderType AutodeskInteractiveTransparent = 2;
	public const DefaultShaderType AutodeskInteractiveMasked = 3;
	public const DefaultShaderType TerrainDetailLit = 4;
	public const DefaultShaderType TerrainDetailGrass = 5;
	public const DefaultShaderType TerrainDetailGrassBillboard = 6;
	public const DefaultShaderType SpeedTree7 = 7;
	public const DefaultShaderType SpeedTree8 = 8;
	public const DefaultShaderType SpeedTree9 = 9;
}

// Namespace: UnityEngine.Rendering
public interface IRenderPipelineGraphicsSettings // TypeDefIndex: 7134
{}

// Namespace: UnityEngine.Rendering
[RequiredByNativeCode]
public class OnDemandRendering // TypeDefIndex: 7135
{
	// Fields
	private static int m_RenderFrameInterval; // 0x0

	// Properties
	public static int renderFrameInterval { get; }

	// Methods

	// RVA: 0x1E81730 Offset: 0x1E7D730 VA: 0x1E81730
	public static int get_renderFrameInterval() { }

	[RequiredByNativeCode]
	// RVA: 0x1E81788 Offset: 0x1E7D788 VA: 0x1E81788
	internal static void GetRenderFrameInterval(out int frameInterval) { }

	// RVA: 0x1E817E0 Offset: 0x1E7D7E0 VA: 0x1E817E0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public struct LightShadowCasterCullingInfo // TypeDefIndex: 7136
{
	// Fields
	public RangeInt splitRange; // 0x0
	public BatchCullingProjectionType projectionType; // 0x8
	public ushort splitExclusionMask; // 0xC
}

// Namespace: UnityEngine.Rendering
public class InvalidImportException : Exception // TypeDefIndex: 7137
{}

// Namespace: UnityEngine.Rendering
public struct LODParameters : IEquatable<LODParameters> // TypeDefIndex: 7138
{
	// Fields
	private int m_IsOrthographic; // 0x0
	private Vector3 m_CameraPosition; // 0x4
	private float m_FieldOfView; // 0x10
	private float m_OrthoSize; // 0x14
	private int m_CameraPixelHeight; // 0x18

	// Methods

	// RVA: 0x1E8182C Offset: 0x1E7D82C VA: 0x1E8182C Slot: 4
	public bool Equals(LODParameters other) { }

	// RVA: 0x1E818D0 Offset: 0x1E7D8D0 VA: 0x1E818D0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E81960 Offset: 0x1E7D960 VA: 0x1E81960 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipeline // TypeDefIndex: 7139
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x10

	// Properties
	public bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void ProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11413A0 Offset: 0x113D3A0 VA: 0x11413A0
	|-RenderPipeline.ProcessRenderRequests<object>
	|
	|-RVA: 0x11413A4 Offset: 0x113D3A4 VA: 0x11413A4
	|-RenderPipeline.ProcessRenderRequests<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E819F4 Offset: 0x1E7D9F4 VA: 0x1E819F4 Slot: 6
	protected virtual void Render(ScriptableRenderContext context, List<Camera> cameras) { }

	// RVA: 0x1E81A6C Offset: 0x1E7DA6C VA: 0x1E81A6C
	internal void InternalRender(ScriptableRenderContext context, List<Camera> cameras) { }

	// RVA: -1 Offset: -1
	internal void InternalProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x114117C Offset: 0x113D17C VA: 0x114117C
	|-RenderPipeline.InternalProcessRenderRequests<object>
	|
	|-RVA: 0x1141240 Offset: 0x113D240 VA: 0x1141240
	|-RenderPipeline.InternalProcessRenderRequests<__Il2CppFullySharedGenericType>
	*/

	[CompilerGenerated]
	// RVA: 0x1E81AE4 Offset: 0x1E7DAE4 VA: 0x1E81AE4
	public bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x1E81AEC Offset: 0x1E7DAEC VA: 0x1E81AEC
	private void set_disposed(bool value) { }

	// RVA: 0x1E81AF4 Offset: 0x1E7DAF4 VA: 0x1E81AF4
	internal void Dispose() { }

	// RVA: 0x1E81B6C Offset: 0x1E7DB6C VA: 0x1E81B6C Slot: 7
	protected virtual void Dispose(bool disposing) { }
}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipelineAsset : ScriptableObject // TypeDefIndex: 7140
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly bool <requiresCompatibleRenderPipelineGlobalSettings>k__BackingField; // 0x18

	// Properties
	public virtual Material defaultMaterial { get; }
	public virtual Shader autodeskInteractiveShader { get; }
	public virtual Shader autodeskInteractiveTransparentShader { get; }
	public virtual Shader autodeskInteractiveMaskedShader { get; }
	public virtual Shader terrainDetailLitShader { get; }
	public virtual Shader terrainDetailGrassShader { get; }
	public virtual Shader terrainDetailGrassBillboardShader { get; }
	public virtual Material defaultParticleMaterial { get; }
	public virtual Material defaultLineMaterial { get; }
	public virtual Material defaultTerrainMaterial { get; }
	public virtual Material defaultUIMaterial { get; }
	public virtual Material defaultUIOverdrawMaterial { get; }
	public virtual Material defaultUIETC1SupportedMaterial { get; }
	public virtual Material default2DMaterial { get; }
	public virtual Material default2DMaskMaterial { get; }
	public virtual Shader defaultShader { get; }
	public virtual Shader defaultSpeedTree7Shader { get; }
	public virtual Shader defaultSpeedTree8Shader { get; }
	public virtual Shader defaultSpeedTree9Shader { get; }
	public virtual string renderPipelineShaderTag { get; }
	public virtual Type pipelineType { get; }
	internal string pipelineTypeFullName { get; }
	protected internal virtual bool requiresCompatibleRenderPipelineGlobalSettings { get; }
	[Obsolete("This property is obsolete. Use pipelineType instead. #from(23.2)", False)]
	protected internal virtual Type renderPipelineType { get; }
	[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(23.3)", False)]
	public virtual string[] renderingLayerMaskNames { get; }
	[Obsolete("This property is obsolete. Use RenderingLayerMask API and Tags & Layers project settings instead. #from(23.3)", False)]
	public virtual string[] prefixedRenderingLayerMaskNames { get; }

	// Methods

	// RVA: 0x1E81B70 Offset: 0x1E7DB70 VA: 0x1E81B70
	internal RenderPipeline InternalCreatePipeline() { }

	// RVA: 0x1E81C4C Offset: 0x1E7DC4C VA: 0x1E81C4C Slot: 4
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x1E81C54 Offset: 0x1E7DC54 VA: 0x1E81C54 Slot: 5
	public virtual Shader get_autodeskInteractiveShader() { }

	// RVA: 0x1E81C5C Offset: 0x1E7DC5C VA: 0x1E81C5C Slot: 6
	public virtual Shader get_autodeskInteractiveTransparentShader() { }

	// RVA: 0x1E81C64 Offset: 0x1E7DC64 VA: 0x1E81C64 Slot: 7
	public virtual Shader get_autodeskInteractiveMaskedShader() { }

	// RVA: 0x1E81C6C Offset: 0x1E7DC6C VA: 0x1E81C6C Slot: 8
	public virtual Shader get_terrainDetailLitShader() { }

	// RVA: 0x1E81C74 Offset: 0x1E7DC74 VA: 0x1E81C74 Slot: 9
	public virtual Shader get_terrainDetailGrassShader() { }

	// RVA: 0x1E81C7C Offset: 0x1E7DC7C VA: 0x1E81C7C Slot: 10
	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	// RVA: 0x1E81C84 Offset: 0x1E7DC84 VA: 0x1E81C84 Slot: 11
	public virtual Material get_defaultParticleMaterial() { }

	// RVA: 0x1E81C8C Offset: 0x1E7DC8C VA: 0x1E81C8C Slot: 12
	public virtual Material get_defaultLineMaterial() { }

	// RVA: 0x1E81C94 Offset: 0x1E7DC94 VA: 0x1E81C94 Slot: 13
	public virtual Material get_defaultTerrainMaterial() { }

	// RVA: 0x1E81C9C Offset: 0x1E7DC9C VA: 0x1E81C9C Slot: 14
	public virtual Material get_defaultUIMaterial() { }

	// RVA: 0x1E81CA4 Offset: 0x1E7DCA4 VA: 0x1E81CA4 Slot: 15
	public virtual Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0x1E81CAC Offset: 0x1E7DCAC VA: 0x1E81CAC Slot: 16
	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0x1E81CB4 Offset: 0x1E7DCB4 VA: 0x1E81CB4 Slot: 17
	public virtual Material get_default2DMaterial() { }

	// RVA: 0x1E81CBC Offset: 0x1E7DCBC VA: 0x1E81CBC Slot: 18
	public virtual Material get_default2DMaskMaterial() { }

	// RVA: 0x1E81CC4 Offset: 0x1E7DCC4 VA: 0x1E81CC4 Slot: 19
	public virtual Shader get_defaultShader() { }

	// RVA: 0x1E81CCC Offset: 0x1E7DCCC VA: 0x1E81CCC Slot: 20
	public virtual Shader get_defaultSpeedTree7Shader() { }

	// RVA: 0x1E81CD4 Offset: 0x1E7DCD4 VA: 0x1E81CD4 Slot: 21
	public virtual Shader get_defaultSpeedTree8Shader() { }

	// RVA: 0x1E81CDC Offset: 0x1E7DCDC VA: 0x1E81CDC Slot: 22
	public virtual Shader get_defaultSpeedTree9Shader() { }

	// RVA: 0x1E81CE4 Offset: 0x1E7DCE4 VA: 0x1E81CE4 Slot: 23
	public virtual string get_renderPipelineShaderTag() { }

	// RVA: -1 Offset: -1 Slot: 24
	protected abstract RenderPipeline CreatePipeline();

	// RVA: 0x1E81D64 Offset: 0x1E7DD64 VA: 0x1E81D64 Slot: 25
	public virtual Type get_pipelineType() { }

	// RVA: 0x1E81088 Offset: 0x1E7D088 VA: 0x1E81088
	internal string get_pipelineTypeFullName() { }

	// RVA: 0x1E81DD4 Offset: 0x1E7DDD4 VA: 0x1E81DD4 Slot: 26
	protected virtual void EnsureGlobalSettings() { }

	// RVA: 0x1E81DD8 Offset: 0x1E7DDD8 VA: 0x1E81DD8 Slot: 27
	protected virtual void OnValidate() { }

	// RVA: 0x1E81EE4 Offset: 0x1E7DEE4 VA: 0x1E81EE4 Slot: 28
	protected virtual void OnDisable() { }

	[CompilerGenerated]
	// RVA: 0x1E820E4 Offset: 0x1E7E0E4 VA: 0x1E820E4 Slot: 29
	protected internal virtual bool get_requiresCompatibleRenderPipelineGlobalSettings() { }

	// RVA: 0x1E820EC Offset: 0x1E7E0EC VA: 0x1E820EC Slot: 30
	protected internal virtual Type get_renderPipelineType() { }

	// RVA: 0x1E8215C Offset: 0x1E7E15C VA: 0x1E8215C Slot: 31
	public virtual string[] get_renderingLayerMaskNames() { }

	// RVA: 0x1E82164 Offset: 0x1E7E164 VA: 0x1E82164 Slot: 32
	public virtual string[] get_prefixedRenderingLayerMaskNames() { }

	// RVA: 0x1E8216C Offset: 0x1E7E16C VA: 0x1E8216C
	protected void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public abstract class RenderPipelineGlobalSettings : ScriptableObject, ISerializationCallbackReceiver // TypeDefIndex: 7141
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Dictionary<Type, int> <settingsMap>k__BackingField; // 0x18

	// Properties
	protected virtual List<IRenderPipelineGraphicsSettings> settingsList { get; }
	private Dictionary<Type, int> settingsMap { get; }

	// Methods

	// RVA: 0x1E82178 Offset: 0x1E7E178 VA: 0x1E82178 Slot: 6
	protected virtual List<IRenderPipelineGraphicsSettings> get_settingsList() { }

	[CompilerGenerated]
	// RVA: 0x1E823AC Offset: 0x1E7E3AC VA: 0x1E823AC
	private Dictionary<Type, int> get_settingsMap() { }

	// RVA: 0x1E823B4 Offset: 0x1E7E3B4 VA: 0x1E823B4
	private void RecreateSettingsMap() { }

	// RVA: 0x1E824DC Offset: 0x1E7E4DC VA: 0x1E824DC
	protected internal bool TryGet(Type type, out IRenderPipelineGraphicsSettings settings) { }

	// RVA: -1 Offset: -1
	protected internal bool TryGetFirstSettingsImplementingInterface<TSettingsInterfaceType>(out TSettingsInterfaceType settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1141568 Offset: 0x113D568 VA: 0x1141568
	|-RenderPipelineGlobalSettings.TryGetFirstSettingsImplementingInterface<object>
	*/

	// RVA: -1 Offset: -1
	protected internal bool GetSettingsImplementingInterface<TSettingsInterfaceType>(out List<TSettingsInterfaceType> settings) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11413A8 Offset: 0x113D3A8 VA: 0x11413A8
	|-RenderPipelineGlobalSettings.GetSettingsImplementingInterface<object>
	*/

	// RVA: 0x1E825CC Offset: 0x1E7E5CC VA: 0x1E825CC
	protected internal bool Contains(Type type) { }

	// RVA: 0x1E82644 Offset: 0x1E7E644 VA: 0x1E82644 Slot: 7
	public virtual void OnBeforeSerialize() { }

	// RVA: 0x1E82648 Offset: 0x1E7E648 VA: 0x1E82648 Slot: 8
	public virtual void OnAfterDeserialize() { }

	// RVA: 0x1E8264C Offset: 0x1E7E64C VA: 0x1E8264C
	protected void .ctor() { }
}

// Namespace: UnityEngine.Rendering
public static class RenderPipelineManager // TypeDefIndex: 7142
{
	// Fields
	private static bool s_CleanUpPipeline; // 0x0
	private static string s_CurrentPipelineType; // 0x8
	private static RenderPipelineAsset s_CurrentPipelineAsset; // 0x10
	private static RenderPipeline s_CurrentPipeline; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action activeRenderPipelineTypeChanged; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action activeRenderPipelineCreated; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action activeRenderPipelineDisposed; // 0x38

	// Properties
	public static RenderPipeline currentPipeline { get; set; }
	private static bool isCurrentPipelineValid { get; }

	// Methods

	// RVA: 0x1E826D4 Offset: 0x1E7E6D4 VA: 0x1E826D4
	public static RenderPipeline get_currentPipeline() { }

	// RVA: 0x1E8272C Offset: 0x1E7E72C VA: 0x1E8272C
	private static void set_currentPipeline(RenderPipeline value) { }

	[RequiredByNativeCode]
	// RVA: 0x1E827E4 Offset: 0x1E7E7E4 VA: 0x1E827E4
	internal static void OnActiveRenderPipelineTypeChanged() { }

	[RequiredByNativeCode]
	// RVA: 0x1E82858 Offset: 0x1E7E858 VA: 0x1E82858
	internal static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to) { }

	[RequiredByNativeCode]
	// RVA: 0x1E82964 Offset: 0x1E7E964 VA: 0x1E82964
	internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) { }

	[RequiredByNativeCode]
	// RVA: 0x1E81E2C Offset: 0x1E7DE2C VA: 0x1E81E2C
	internal static void RecreateCurrentPipeline(RenderPipelineAsset pipelineAsset) { }

	[RequiredByNativeCode]
	// RVA: 0x1E81F30 Offset: 0x1E7DF30 VA: 0x1E81F30
	internal static void CleanupRenderPipeline() { }

	[RequiredByNativeCode]
	// RVA: 0x1E82B08 Offset: 0x1E7EB08 VA: 0x1E82B08
	private static string GetCurrentPipelineAssetType() { }

	[RequiredByNativeCode]
	// RVA: 0x1E82B60 Offset: 0x1E7EB60 VA: 0x1E82B60
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipelineAsset, IntPtr loopPtr, Object renderRequest) { }

	// RVA: 0x1E82E5C Offset: 0x1E7EE5C VA: 0x1E82E5C
	internal static bool TryPrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x1E82A00 Offset: 0x1E7EA00 VA: 0x1E82A00
	private static bool get_isCurrentPipelineValid() { }

	// RVA: 0x1E83064 Offset: 0x1E7F064 VA: 0x1E83064
	private static bool IsPipelineRequireCreation() { }

	// RVA: 0x1E831B0 Offset: 0x1E7F1B0 VA: 0x1E831B0
	private static void .cctor() { }
}

// Namespace: 
private struct ScriptableRenderContext.CullShadowCastersContext // TypeDefIndex: 7143
{
	// Fields
	public IntPtr cullResults; // 0x0
	public ShadowSplitData* splitBuffer; // 0x8
	public int splitBufferLength; // 0x10
	public LightShadowCasterCullingInfo* perLightInfos; // 0x18
	public int perLightInfoCount; // 0x20
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Modules/UI/CanvasManager.h")]
[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext> // TypeDefIndex: 7144
{
	// Fields
	private static readonly ShaderTagId kRenderTypeTag; // 0x0
	private IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x1E83228 Offset: 0x1E7F228 VA: 0x1E83228
	private void GetCameras_Internal(Type listType, object resultList) { }

	// RVA: 0x1E82F90 Offset: 0x1E7EF90 VA: 0x1E82F90
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1E82F98 Offset: 0x1E7EF98 VA: 0x1E82F98
	internal void GetCameras(List<Camera> results) { }

	// RVA: 0x1E8327C Offset: 0x1E7F27C VA: 0x1E8327C Slot: 4
	public bool Equals(ScriptableRenderContext other) { }

	// RVA: 0x1E832C0 Offset: 0x1E7F2C0 VA: 0x1E832C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E83390 Offset: 0x1E7F390 VA: 0x1E83390 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E83398 Offset: 0x1E7F398 VA: 0x1E83398
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public struct ShaderTagId : IEquatable<ShaderTagId> // TypeDefIndex: 7145
{
	// Fields
	private int m_Id; // 0x0

	// Methods

	// RVA: 0x1E83400 Offset: 0x1E7F400 VA: 0x1E83400
	public void .ctor(string name) { }

	// RVA: 0x1E83420 Offset: 0x1E7F420 VA: 0x1E83420 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E83498 Offset: 0x1E7F498 VA: 0x1E83498 Slot: 4
	public bool Equals(ShaderTagId other) { }

	// RVA: 0x1E834A8 Offset: 0x1E7F4A8 VA: 0x1E834A8 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
[UnsafeValueType]
[CompilerGenerated]
public struct ShadowSplitData.<m_CullingPlanes>e__FixedBuffer // TypeDefIndex: 7146
{
	// Fields
	public byte FixedElementField; // 0x0
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
public struct ShadowSplitData : IEquatable<ShadowSplitData> // TypeDefIndex: 7147
{
	// Fields
	public static readonly int maximumCullingPlaneCount; // 0x0
	private int m_CullingPlaneCount; // 0x0
	[FixedBuffer(typeof(byte), 160)]
	internal ShadowSplitData.<m_CullingPlanes>e__FixedBuffer m_CullingPlanes; // 0x4
	private Vector4 m_CullingSphere; // 0xA4
	private float m_ShadowCascadeBlendCullingFactor; // 0xB4
	private float m_CullingNearPlane; // 0xB8
	private Matrix4x4 m_CullingMatrix; // 0xBC

	// Properties
	public int cullingPlaneCount { get; }

	// Methods

	// RVA: 0x1E834C8 Offset: 0x1E7F4C8 VA: 0x1E834C8
	public int get_cullingPlaneCount() { }

	// RVA: 0x1E834D0 Offset: 0x1E7F4D0 VA: 0x1E834D0
	public Plane GetCullingPlane(int index) { }

	// RVA: 0x1E83618 Offset: 0x1E7F618 VA: 0x1E83618 Slot: 4
	public bool Equals(ShadowSplitData other) { }

	// RVA: 0x1E8378C Offset: 0x1E7F78C VA: 0x1E8378C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E83888 Offset: 0x1E7F888 VA: 0x1E83888 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E83904 Offset: 0x1E7F904 VA: 0x1E83904
	private static void .cctor() { }
}

// Namespace: 
[Flags]
public enum SupportedRenderingFeatures.ReflectionProbeModes // TypeDefIndex: 7148
{
	// Fields
	public int value__; // 0x0
	public const SupportedRenderingFeatures.ReflectionProbeModes None = 0;
	public const SupportedRenderingFeatures.ReflectionProbeModes Rotation = 1;
}

// Namespace: 
[Flags]
public enum SupportedRenderingFeatures.LightmapMixedBakeModes // TypeDefIndex: 7149
{
	// Fields
	public int value__; // 0x0
	public const SupportedRenderingFeatures.LightmapMixedBakeModes None = 0;
	public const SupportedRenderingFeatures.LightmapMixedBakeModes IndirectOnly = 1;
	public const SupportedRenderingFeatures.LightmapMixedBakeModes Subtractive = 2;
	public const SupportedRenderingFeatures.LightmapMixedBakeModes Shadowmask = 4;
}

// Namespace: UnityEngine.Rendering
public class SupportedRenderingFeatures // TypeDefIndex: 7150
{
	// Fields
	private static SupportedRenderingFeatures s_Active; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private SupportedRenderingFeatures.ReflectionProbeModes <reflectionProbeModes>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private SupportedRenderingFeatures.LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField; // 0x14
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private SupportedRenderingFeatures.LightmapMixedBakeModes <mixedLightingModes>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private LightmapBakeType <lightmapBakeTypes>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private LightmapsMode <lightmapsModes>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <enlightenLightmapper>k__BackingField; // 0x24
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <enlighten>k__BackingField; // 0x25
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <skyOcclusion>k__BackingField; // 0x26
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <lightProbeProxyVolumes>k__BackingField; // 0x27
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <motionVectors>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <receiveShadows>k__BackingField; // 0x29
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <reflectionProbes>k__BackingField; // 0x2A
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <reflectionProbesBlendDistance>k__BackingField; // 0x2B
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <rendererPriority>k__BackingField; // 0x2C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <rendersUIOverlay>k__BackingField; // 0x2D
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesEnvironmentLighting>k__BackingField; // 0x2E
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesFog>k__BackingField; // 0x2F
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesRealtimeReflectionProbes>k__BackingField; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesOtherLightingSettings>k__BackingField; // 0x31
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <editableMaterialRenderQueue>k__BackingField; // 0x32
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesLODBias>k__BackingField; // 0x33
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesMaximumLODLevel>k__BackingField; // 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesEnableLODCrossFade>k__BackingField; // 0x35
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <rendererProbes>k__BackingField; // 0x36
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <particleSystemInstancing>k__BackingField; // 0x37
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <ambientProbeBaking>k__BackingField; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <defaultReflectionProbeBaking>k__BackingField; // 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesShadowmask>k__BackingField; // 0x3A
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesLightProbeSystem>k__BackingField; // 0x3B
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <supportsHDR>k__BackingField; // 0x3C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <supportsClouds>k__BackingField; // 0x3D
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <overridesLightProbeSystemWarningMessage>k__BackingField; // 0x40

	// Properties
	public static SupportedRenderingFeatures active { get; set; }
	public SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes { get; }
	public SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes { get; }
	public LightmapBakeType lightmapBakeTypes { get; }
	public LightmapsMode lightmapsModes { get; }
	public bool enlighten { get; }
	public bool rendersUIOverlay { get; }
	public bool ambientProbeBaking { get; }
	public bool defaultReflectionProbeBaking { get; }
	public bool overridesLightProbeSystem { get; }

	// Methods

	// RVA: 0x1E83950 Offset: 0x1E7F950 VA: 0x1E83950
	public static SupportedRenderingFeatures get_active() { }

	// RVA: 0x1E82AA0 Offset: 0x1E7EAA0 VA: 0x1E82AA0
	public static void set_active(SupportedRenderingFeatures value) { }

	[CompilerGenerated]
	// RVA: 0x1E83AA0 Offset: 0x1E7FAA0 VA: 0x1E83AA0
	public SupportedRenderingFeatures.LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	[CompilerGenerated]
	// RVA: 0x1E83AA8 Offset: 0x1E7FAA8 VA: 0x1E83AA8
	public SupportedRenderingFeatures.LightmapMixedBakeModes get_mixedLightingModes() { }

	[CompilerGenerated]
	// RVA: 0x1E83AB0 Offset: 0x1E7FAB0 VA: 0x1E83AB0
	public LightmapBakeType get_lightmapBakeTypes() { }

	[CompilerGenerated]
	// RVA: 0x1E83AB8 Offset: 0x1E7FAB8 VA: 0x1E83AB8
	public LightmapsMode get_lightmapsModes() { }

	[CompilerGenerated]
	// RVA: 0x1E83AC0 Offset: 0x1E7FAC0 VA: 0x1E83AC0
	public bool get_enlighten() { }

	[CompilerGenerated]
	// RVA: 0x1E83AC8 Offset: 0x1E7FAC8 VA: 0x1E83AC8
	public bool get_rendersUIOverlay() { }

	[CompilerGenerated]
	// RVA: 0x1E83AD0 Offset: 0x1E7FAD0 VA: 0x1E83AD0
	public bool get_ambientProbeBaking() { }

	[CompilerGenerated]
	// RVA: 0x1E83AD8 Offset: 0x1E7FAD8 VA: 0x1E83AD8
	public bool get_defaultReflectionProbeBaking() { }

	[CompilerGenerated]
	// RVA: 0x1E83AE0 Offset: 0x1E7FAE0 VA: 0x1E83AE0
	public bool get_overridesLightProbeSystem() { }

	[RequiredByNativeCode]
	// RVA: 0x1E83AE8 Offset: 0x1E7FAE8 VA: 0x1E83AE8
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	// RVA: 0x1E83C1C Offset: 0x1E7FC1C VA: 0x1E83C1C
	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	[RequiredByNativeCode]
	// RVA: 0x1E83C88 Offset: 0x1E7FC88 VA: 0x1E83C88
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	// RVA: 0x1E83D90 Offset: 0x1E7FD90 VA: 0x1E83D90
	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	[RequiredByNativeCode]
	// RVA: 0x1E83DFC Offset: 0x1E7FDFC VA: 0x1E83DFC
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x1E83EEC Offset: 0x1E7FEEC VA: 0x1E83EEC
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x1E83F78 Offset: 0x1E7FF78 VA: 0x1E83F78
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x1E83FA0 Offset: 0x1E7FFA0 VA: 0x1E83FA0
	internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x1E84018 Offset: 0x1E80018 VA: 0x1E84018
	internal static void IsAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x1E84090 Offset: 0x1E80090 VA: 0x1E84090
	internal static void IsDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x1E84108 Offset: 0x1E80108 VA: 0x1E84108
	internal static void OverridesLightProbeSystem(IntPtr overridesPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x1E84180 Offset: 0x1E80180 VA: 0x1E84180
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	// RVA: 0x1E83A00 Offset: 0x1E7FA00 VA: 0x1E83A00
	public void .ctor() { }

	// RVA: 0x1E8419C Offset: 0x1E8019C VA: 0x1E8419C
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[NativeClass("BatchID")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
public struct BatchID : IEquatable<BatchID> // TypeDefIndex: 7151
{
	// Fields
	public static readonly BatchID Null; // 0x0
	public uint value; // 0x0

	// Methods

	// RVA: 0x1E84200 Offset: 0x1E80200 VA: 0x1E84200 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E84208 Offset: 0x1E80208 VA: 0x1E84208 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E842B0 Offset: 0x1E802B0 VA: 0x1E842B0 Slot: 4
	public bool Equals(BatchID other) { }

	// RVA: 0x1E842C0 Offset: 0x1E802C0 VA: 0x1E842C0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[NativeClass("BatchMaterialID")]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct BatchMaterialID : IEquatable<BatchMaterialID> // TypeDefIndex: 7152
{
	// Fields
	public static readonly BatchMaterialID Null; // 0x0
	public uint value; // 0x0

	// Methods

	// RVA: 0x1E84308 Offset: 0x1E80308 VA: 0x1E84308 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E84310 Offset: 0x1E80310 VA: 0x1E84310 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E843B8 Offset: 0x1E803B8 VA: 0x1E843B8 Slot: 4
	public bool Equals(BatchMaterialID other) { }

	// RVA: 0x1E843C8 Offset: 0x1E803C8 VA: 0x1E843C8
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[NativeClass("BatchMeshID")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct BatchMeshID : IEquatable<BatchMeshID> // TypeDefIndex: 7153
{
	// Fields
	public static readonly BatchMeshID Null; // 0x0
	public uint value; // 0x0

	// Methods

	// RVA: 0x1E84410 Offset: 0x1E80410 VA: 0x1E84410 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E84418 Offset: 0x1E80418 VA: 0x1E84418 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E844C0 Offset: 0x1E804C0 VA: 0x1E844C0 Slot: 4
	public bool Equals(BatchMeshID other) { }

	// RVA: 0x1E844D0 Offset: 0x1E804D0 VA: 0x1E844D0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
public enum BatchDrawCommandType // TypeDefIndex: 7154
{
	// Fields
	public int value__; // 0x0
	public const BatchDrawCommandType Direct = 0;
	public const BatchDrawCommandType Indirect = 1;
	public const BatchDrawCommandType Procedural = 2;
	public const BatchDrawCommandType ProceduralIndirect = 3;
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum BatchDrawCommandFlags // TypeDefIndex: 7155
{
	// Fields
	public int value__; // 0x0
	public const BatchDrawCommandFlags None = 0;
	public const BatchDrawCommandFlags FlipWinding = 1;
	public const BatchDrawCommandFlags HasMotion = 2;
	public const BatchDrawCommandFlags IsLightMapped = 4;
	public const BatchDrawCommandFlags HasSortingPosition = 8;
	public const BatchDrawCommandFlags LODCrossFadeKeyword = 16;
	public const BatchDrawCommandFlags LODCrossFadeValuePacked = 32;
	public const BatchDrawCommandFlags LODCrossFade = 48;
	public const BatchDrawCommandFlags UseLegacyLightmapsKeyword = 64;
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum BatchCullingFlags // TypeDefIndex: 7156
{
	// Fields
	public int value__; // 0x0
	public const BatchCullingFlags None = 0;
	public const BatchCullingFlags CullLightmappedShadowCasters = 1;
}

// Namespace: UnityEngine.Rendering
public enum BatchCullingViewType // TypeDefIndex: 7157
{
	// Fields
	public int value__; // 0x0
	public const BatchCullingViewType Unknown = 0;
	public const BatchCullingViewType Camera = 1;
	public const BatchCullingViewType Light = 2;
	public const BatchCullingViewType Picking = 3;
	public const BatchCullingViewType SelectionOutline = 4;
	public const BatchCullingViewType Filtering = 5;
}

// Namespace: UnityEngine.Rendering
public enum BatchCullingProjectionType // TypeDefIndex: 7158
{
	// Fields
	public int value__; // 0x0
	public const BatchCullingProjectionType Unknown = 0;
	public const BatchCullingProjectionType Perspective = 1;
	public const BatchCullingProjectionType Orthographic = 2;
}

// Namespace: UnityEngine.Rendering
public struct BatchPackedCullingViewID : IEquatable<BatchPackedCullingViewID> // TypeDefIndex: 7159
{
	// Fields
	internal ulong handle; // 0x0

	// Methods

	// RVA: 0x1E84518 Offset: 0x1E80518 VA: 0x1E84518 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E84520 Offset: 0x1E80520 VA: 0x1E84520 Slot: 4
	public bool Equals(BatchPackedCullingViewID other) { }

	// RVA: 0x1E84530 Offset: 0x1E80530 VA: 0x1E84530 Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: UnityEngine.Rendering
public struct BatchDrawCommand // TypeDefIndex: 7160
{
	// Fields
	public BatchDrawCommandFlags flags; // 0x0
	public BatchID batchID; // 0x4
	public BatchMaterialID materialID; // 0x8
	public ushort splitVisibilityMask; // 0xC
	public ushort lightmapIndex; // 0xE
	public int sortingPosition; // 0x10
	public uint visibleOffset; // 0x14
	public uint visibleCount; // 0x18
	public BatchMeshID meshID; // 0x1C
	public ushort submeshIndex; // 0x20
	private ushort unusedPadding2; // 0x22
}

// Namespace: UnityEngine.Rendering
public struct BatchDrawCommandIndirect // TypeDefIndex: 7161
{
	// Fields
	public BatchDrawCommandFlags flags; // 0x0
	public BatchID batchID; // 0x4
	public BatchMaterialID materialID; // 0x8
	public ushort splitVisibilityMask; // 0xC
	public ushort lightmapIndex; // 0xE
	public int sortingPosition; // 0x10
	public uint visibleOffset; // 0x14
	public BatchMeshID meshID; // 0x18
	public MeshTopology topology; // 0x1C
	public GraphicsBufferHandle visibleInstancesBufferHandle; // 0x20
	public uint visibleInstancesBufferWindowOffset; // 0x24
	public uint visibleInstancesBufferWindowSizeBytes; // 0x28
	public GraphicsBufferHandle indirectArgsBufferHandle; // 0x2C
	public uint indirectArgsBufferOffset; // 0x30
}

// Namespace: UnityEngine.Rendering
public struct BatchDrawCommandProcedural // TypeDefIndex: 7162
{
	// Fields
	public BatchDrawCommandFlags flags; // 0x0
	public BatchID batchID; // 0x4
	public BatchMaterialID materialID; // 0x8
	public ushort splitVisibilityMask; // 0xC
	public ushort lightmapIndex; // 0xE
	public int sortingPosition; // 0x10
	public uint visibleOffset; // 0x14
	public uint visibleCount; // 0x18
	public MeshTopology topology; // 0x1C
	public GraphicsBufferHandle indexBufferHandle; // 0x20
	public uint baseVertex; // 0x24
	public uint indexOffsetBytes; // 0x28
	public uint elementCount; // 0x2C
}

// Namespace: UnityEngine.Rendering
public struct BatchDrawCommandProceduralIndirect // TypeDefIndex: 7163
{
	// Fields
	public BatchDrawCommandFlags flags; // 0x0
	public BatchID batchID; // 0x4
	public BatchMaterialID materialID; // 0x8
	public ushort splitVisibilityMask; // 0xC
	public ushort lightmapIndex; // 0xE
	public int sortingPosition; // 0x10
	public uint visibleOffset; // 0x14
	public MeshTopology topology; // 0x18
	public GraphicsBufferHandle indexBufferHandle; // 0x1C
	public GraphicsBufferHandle visibleInstancesBufferHandle; // 0x20
	public uint visibleInstancesBufferWindowOffset; // 0x24
	public uint visibleInstancesBufferWindowSizeBytes; // 0x28
	public GraphicsBufferHandle indirectArgsBufferHandle; // 0x2C
	public uint indirectArgsBufferOffset; // 0x30
}

// Namespace: UnityEngine.Rendering
public struct BatchFilterSettings // TypeDefIndex: 7164
{
	// Fields
	public uint renderingLayerMask; // 0x0
	public int rendererPriority; // 0x4
	private ulong m_sceneCullingMask; // 0x8
	public byte layer; // 0x10
	private byte m_batchLayer; // 0x11
	private byte m_motionMode; // 0x12
	private byte m_shadowMode; // 0x13
	private byte m_receiveShadows; // 0x14
	private byte m_staticShadowCaster; // 0x15
	private byte m_allDepthSorted; // 0x16
	private byte m_isSceneCullingMaskSet; // 0x17
}

// Namespace: UnityEngine.Rendering
public struct BatchDrawRange // TypeDefIndex: 7165
{
	// Fields
	public BatchDrawCommandType drawCommandsType; // 0x0
	public uint drawCommandsBegin; // 0x4
	public uint drawCommandsCount; // 0x8
	public BatchFilterSettings filterSettings; // 0x10
}

// Namespace: UnityEngine.Rendering
public struct BatchCullingOutputDrawCommands // TypeDefIndex: 7166
{
	// Fields
	public BatchDrawCommand* drawCommands; // 0x0
	public BatchDrawCommandIndirect* indirectDrawCommands; // 0x8
	public BatchDrawCommandProcedural* proceduralDrawCommands; // 0x10
	public BatchDrawCommandProceduralIndirect* proceduralIndirectDrawCommands; // 0x18
	public int* visibleInstances; // 0x20
	public BatchDrawRange* drawRanges; // 0x28
	public float* instanceSortingPositions; // 0x30
	public int* drawCommandPickingInstanceIDs; // 0x38
	public int drawCommandCount; // 0x40
	public int indirectDrawCommandCount; // 0x44
	public int proceduralDrawCommandCount; // 0x48
	public int proceduralIndirectDrawCommandCount; // 0x4C
	public int visibleInstanceCount; // 0x50
	public int drawRangeCount; // 0x54
	public int instanceSortingPositionFloatCount; // 0x58
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[UsedByNativeCode]
public struct CullingSplit // TypeDefIndex: 7167
{
	// Fields
	public Vector3 sphereCenter; // 0x0
	public float sphereRadius; // 0xC
	public int cullingPlaneOffset; // 0x10
	public int cullingPlaneCount; // 0x14
	public float cascadeBlendCullingFactor; // 0x18
	public float nearPlane; // 0x1C
	public Matrix4x4 cullingMatrix; // 0x20
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
public struct BatchCullingContext // TypeDefIndex: 7168
{
	// Fields
	public readonly NativeArray<Plane> cullingPlanes; // 0x0
	public readonly NativeArray<CullingSplit> cullingSplits; // 0x10
	public readonly LODParameters lodParameters; // 0x20
	public readonly Matrix4x4 localToWorldMatrix; // 0x3C
	public readonly BatchCullingViewType viewType; // 0x7C
	public readonly BatchCullingProjectionType projectionType; // 0x80
	public readonly BatchCullingFlags cullingFlags; // 0x84
	public readonly BatchPackedCullingViewID viewID; // 0x88
	public readonly uint cullingLayerMask; // 0x90
	public readonly ulong sceneCullingMask; // 0x98
	public readonly ushort splitExclusionMask; // 0xA0
	[Obsolete("BatchCullingContext.isOrthographic is deprecated. Use BatchCullingContext.projectionType instead.")]
	public readonly byte isOrthographic; // 0xA2
	public readonly int receiverPlaneOffset; // 0xA4
	public readonly int receiverPlaneCount; // 0xA8
	internal readonly IntPtr occlusionBuffer; // 0xB0

	// Methods

	// RVA: 0x1E845A8 Offset: 0x1E805A8 VA: 0x1E845A8
	internal void .ctor(NativeArray<Plane> inCullingPlanes, NativeArray<CullingSplit> inCullingSplits, LODParameters inLodParameters, Matrix4x4 inLocalToWorldMatrix, BatchCullingViewType inViewType, BatchCullingProjectionType inProjectionType, BatchCullingFlags inBatchCullingFlags, ulong inViewID, uint inCullingLayerMask, ulong inSceneCullingMask, byte inExclusionSplitMask, int inReceiverPlaneOffset, int inReceiverPlaneCount, IntPtr inOcclusionBuffer) { }
}

// Namespace: UnityEngine.Rendering
public struct BatchCullingOutput // TypeDefIndex: 7169
{
	// Fields
	public NativeArray<BatchCullingOutputDrawCommands> drawCommands; // 0x0
	public NativeArray<IntPtr> customCullingResult; // 0x10
}

// Namespace: UnityEngine.Rendering
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[UsedByNativeCode]
internal struct BatchRendererCullingOutput // TypeDefIndex: 7170
{
	// Fields
	public JobHandle cullingJobsFence; // 0x0
	public Matrix4x4 localToWorldMatrix; // 0x10
	public Plane* cullingPlanes; // 0x50
	public int cullingPlaneCount; // 0x58
	public int receiverPlaneOffset; // 0x5C
	public int receiverPlaneCount; // 0x60
	public CullingSplit* cullingSplits; // 0x68
	public int cullingSplitCount; // 0x70
	public BatchCullingViewType viewType; // 0x74
	public BatchCullingProjectionType projectionType; // 0x78
	public BatchCullingFlags cullingFlags; // 0x7C
	public ulong viewID; // 0x80
	public uint cullingLayerMask; // 0x88
	public byte splitExclusionMask; // 0x8C
	public ulong sceneCullingMask; // 0x90
	public BatchCullingOutputDrawCommands* drawCommands; // 0x98
	public uint brgId; // 0xA0
	public IntPtr occlusionBuffer; // 0xA8
	public IntPtr customCullingResult; // 0xB0
}

// Namespace: 
public sealed class BatchRendererGroup.OnPerformCulling : MulticastDelegate // TypeDefIndex: 7171
{
	// Methods

	// RVA: 0x1E8494C Offset: 0x1E8094C VA: 0x1E8494C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E84A58 Offset: 0x1E80A58 VA: 0x1E84A58 Slot: 12
	public virtual JobHandle Invoke(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext, BatchCullingOutput cullingOutput, IntPtr userContext) { }
}

// Namespace: 
public sealed class BatchRendererGroup.OnFinishedCulling : MulticastDelegate // TypeDefIndex: 7172
{
	// Methods

	// RVA: 0x1E84AD0 Offset: 0x1E80AD0 VA: 0x1E84AD0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E84B70 Offset: 0x1E80B70 VA: 0x1E84B70 Slot: 12
	public virtual void Invoke(IntPtr customCullingResult) { }
}

// Namespace: UnityEngine.Rendering
[RequiredByNativeCode]
[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
[NativeHeader("Runtime/Math/Matrix4x4.h")]
public class BatchRendererGroup // TypeDefIndex: 7173
{
	// Fields
	private IntPtr m_GroupHandle; // 0x10
	private BatchRendererGroup.OnPerformCulling m_PerformCulling; // 0x18
	private BatchRendererGroup.OnFinishedCulling m_FinishedCulling; // 0x20

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E84634 Offset: 0x1E80634 VA: 0x1E84634
	private static void InvokeOnPerformCulling(BatchRendererGroup group, ref BatchRendererCullingOutput context, ref LODParameters lodParameters, IntPtr userContext) { }

	[RequiredByNativeCode]
	// RVA: 0x1E84884 Offset: 0x1E80884 VA: 0x1E84884
	private static void InvokeOnFinishedCulling(BatchRendererGroup group, IntPtr customCullingResult) { }
}

// Namespace: UnityEngine.Rendering
internal sealed class GPUDrivenLODGroupDataCallback : MulticastDelegate // TypeDefIndex: 7174
{
	// Methods

	// RVA: 0x1E84B84 Offset: 0x1E80B84 VA: 0x1E84B84
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E84C34 Offset: 0x1E80C34 VA: 0x1E84C34 Slot: 12
	public virtual void Invoke(in GPUDrivenLODGroupData lodGroupData) { }
}

// Namespace: UnityEngine.Rendering
internal sealed class GPUDrivenLODGroupDataNativeCallback : MulticastDelegate // TypeDefIndex: 7175
{
	// Methods

	// RVA: 0x1E84C48 Offset: 0x1E80C48 VA: 0x1E84C48
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E84CFC Offset: 0x1E80CFC VA: 0x1E84CFC Slot: 12
	public virtual void Invoke(in GPUDrivenLODGroupDataNative lodGroupDataNative, GPUDrivenLODGroupDataCallback callback) { }
}

// Namespace: UnityEngine.Rendering
internal sealed class GPUDrivenRendererDataCallback : MulticastDelegate // TypeDefIndex: 7176
{
	// Methods

	// RVA: 0x1E84D10 Offset: 0x1E80D10 VA: 0x1E84D10
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E84DC4 Offset: 0x1E80DC4 VA: 0x1E84DC4 Slot: 12
	public virtual void Invoke(in GPUDrivenRendererGroupData rendererData, IList<Mesh> meshes, IList<Material> materials) { }
}

// Namespace: UnityEngine.Rendering
internal sealed class GPUDrivenRendererDataNativeCallback : MulticastDelegate // TypeDefIndex: 7177
{
	// Methods

	// RVA: 0x1E84DD8 Offset: 0x1E80DD8 VA: 0x1E84DD8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E84E8C Offset: 0x1E80E8C VA: 0x1E84E8C Slot: 12
	public virtual void Invoke(in GPUDrivenRendererGroupDataNative rendererDataNative, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback callback) { }
}

// Namespace: UnityEngine.Rendering
[RequiredByNativeCode]
internal static class GPUDrivenCallbacks // TypeDefIndex: 7178
{
	// Methods

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x1E84EA0 Offset: 0x1E80EA0 VA: 0x1E84EA0
	public static void InvokeGPUDrivenLODGroupDataNativeCallback(GPUDrivenLODGroupDataNativeCallback callback, in GPUDrivenLODGroupDataNative lodGroupDataNative, GPUDrivenLODGroupDataCallback target) { }

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x1E84EC0 Offset: 0x1E80EC0 VA: 0x1E84EC0
	public static void InvokeGPUDrivenRendererDataNativeCallback(GPUDrivenRendererDataNativeCallback callback, in GPUDrivenRendererGroupDataNative rendererDataNative, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback target) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class GPUDrivenProcessor.<>c // TypeDefIndex: 7179
{
	// Fields
	public static readonly GPUDrivenProcessor.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1E85014 Offset: 0x1E81014 VA: 0x1E85014
	private static void .cctor() { }

	// RVA: 0x1E8507C Offset: 0x1E8107C VA: 0x1E8507C
	public void .ctor() { }

	// RVA: 0x1E85084 Offset: 0x1E81084 VA: 0x1E85084
	internal void <.cctor>b__34_0(in GPUDrivenRendererGroupDataNative nativeData, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback callback) { }

	// RVA: 0x1E8563C Offset: 0x1E8163C VA: 0x1E8563C
	internal void <.cctor>b__34_1(in GPUDrivenLODGroupDataNative nativeData, GPUDrivenLODGroupDataCallback callback) { }
}

// Namespace: UnityEngine.Rendering
[RequiredByNativeCode]
[NativeHeader("Runtime/Camera/GPUDrivenProcessor.h")]
internal class GPUDrivenProcessor // TypeDefIndex: 7180
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	private static GPUDrivenRendererDataNativeCallback s_NativeRendererCallback; // 0x0
	private static GPUDrivenLODGroupDataNativeCallback s_NativeLODGroupCallback; // 0x8

	// Methods

	// RVA: 0x1E84EE0 Offset: 0x1E80EE0 VA: 0x1E84EE0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
internal struct GPUDrivenRendererEditorData // TypeDefIndex: 7181
{
	// Fields
	public ulong sceneCullingMask; // 0x0
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
internal struct GPUDrivenRendererGroupDataNative // TypeDefIndex: 7182
{
	// Fields
	public int* rendererGroupID; // 0x0
	public Bounds* localBounds; // 0x8
	public Vector4* lightmapScaleOffset; // 0x10
	public int* gameObjectLayer; // 0x18
	public uint* renderingLayerMask; // 0x20
	public int* lodGroupID; // 0x28
	public MotionVectorGenerationMode* motionVecGenMode; // 0x30
	public GPUDrivenPackedRendererData* packedRendererData; // 0x38
	public int* rendererPriority; // 0x40
	public int* meshIndex; // 0x48
	public short* subMeshStartIndex; // 0x50
	public int* materialsOffset; // 0x58
	public short* materialsCount; // 0x60
	public int* instancesOffset; // 0x68
	public int* instancesCount; // 0x70
	public GPUDrivenRendererEditorData* editorData; // 0x78
	public int rendererGroupCount; // 0x80
	public int* invalidRendererGroupID; // 0x88
	public int invalidRendererGroupIDCount; // 0x90
	public Matrix4x4* localToWorldMatrix; // 0x98
	public Matrix4x4* prevLocalToWorldMatrix; // 0xA0
	public int* rendererGroupIndex; // 0xA8
	public int instanceCount; // 0xB0
	public int* meshID; // 0xB8
	public short* subMeshCount; // 0xC0
	public int* subMeshDescOffset; // 0xC8
	public int meshCount; // 0xD0
	public SubMeshDescriptor* subMeshDesc; // 0xD8
	public int subMeshDescCount; // 0xE0
	public int* materialIndex; // 0xE8
	public int materialIndexCount; // 0xF0
	public int* materialID; // 0xF8
	public GPUDrivenPackedMaterialData* packedMaterialData; // 0x100
	public int* materialFilterFlags; // 0x108
	public int materialCount; // 0x110
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
internal struct GPUDrivenLODGroupDataNative // TypeDefIndex: 7183
{
	// Fields
	public int* lodGroupID; // 0x0
	public int* lodOffset; // 0x8
	public int* lodCount; // 0x10
	public LODFadeMode* fadeMode; // 0x18
	public Vector3* worldSpaceReferencePoint; // 0x20
	public float* worldSpaceSize; // 0x28
	public short* renderersCount; // 0x30
	public bool* lastLODIsBillboard; // 0x38
	public byte* forceLODMask; // 0x40
	public int lodGroupCount; // 0x48
	public int* invalidLODGroupID; // 0x50
	public int invalidLODGroupCount; // 0x58
	public short* lodRenderersCount; // 0x60
	public float* lodScreenRelativeTransitionHeight; // 0x68
	public float* lodFadeTransitionWidth; // 0x70
	public int lodDataCount; // 0x78
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
internal struct GPUDrivenPackedRendererData // TypeDefIndex: 7184
{
	// Fields
	private uint data; // 0x0

	// Methods

	// RVA: 0x1E85918 Offset: 0x1E81918 VA: 0x1E85918
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
[UsedByNativeCode]
internal struct GPUDrivenPackedMaterialData // TypeDefIndex: 7185
{
	// Fields
	private uint data; // 0x0

	// Methods

	// RVA: 0x1E85920 Offset: 0x1E81920 VA: 0x1E85920
	public void .ctor() { }
}

// Namespace: UnityEngine.Rendering
internal struct GPUDrivenRendererGroupData // TypeDefIndex: 7186
{
	// Fields
	public NativeArray<int> rendererGroupID; // 0x0
	public NativeArray<Bounds> localBounds; // 0x10
	public NativeArray<Vector4> lightmapScaleOffset; // 0x20
	public NativeArray<int> gameObjectLayer; // 0x30
	public NativeArray<uint> renderingLayerMask; // 0x40
	public NativeArray<int> lodGroupID; // 0x50
	public NativeArray<int> lightmapIndex; // 0x60
	public NativeArray<GPUDrivenPackedRendererData> packedRendererData; // 0x70
	public NativeArray<int> rendererPriority; // 0x80
	public NativeArray<int> meshIndex; // 0x90
	public NativeArray<short> subMeshStartIndex; // 0xA0
	public NativeArray<int> materialsOffset; // 0xB0
	public NativeArray<short> materialsCount; // 0xC0
	public NativeArray<int> instancesOffset; // 0xD0
	public NativeArray<int> instancesCount; // 0xE0
	public NativeArray<GPUDrivenRendererEditorData> editorData; // 0xF0
	public NativeArray<int> invalidRendererGroupID; // 0x100
	public NativeArray<Matrix4x4> localToWorldMatrix; // 0x110
	public NativeArray<Matrix4x4> prevLocalToWorldMatrix; // 0x120
	public NativeArray<int> rendererGroupIndex; // 0x130
	public NativeArray<int> meshID; // 0x140
	public NativeArray<short> subMeshCount; // 0x150
	public NativeArray<int> subMeshDescOffset; // 0x160
	public NativeArray<SubMeshDescriptor> subMeshDesc; // 0x170
	public NativeArray<int> materialIndex; // 0x180
	public NativeArray<int> materialID; // 0x190
	public NativeArray<GPUDrivenPackedMaterialData> packedMaterialData; // 0x1A0
	public NativeArray<int> materialFilterFlags; // 0x1B0
}

// Namespace: UnityEngine.Rendering
internal struct GPUDrivenLODGroupData // TypeDefIndex: 7187
{
	// Fields
	public NativeArray<int> lodGroupID; // 0x0
	public NativeArray<int> lodOffset; // 0x10
	public NativeArray<int> lodCount; // 0x20
	public NativeArray<LODFadeMode> fadeMode; // 0x30
	public NativeArray<Vector3> worldSpaceReferencePoint; // 0x40
	public NativeArray<float> worldSpaceSize; // 0x50
	public NativeArray<short> renderersCount; // 0x60
	public NativeArray<bool> lastLODIsBillboard; // 0x70
	public NativeArray<byte> forceLODMask; // 0x80
	public NativeArray<int> invalidLODGroupID; // 0x90
	public NativeArray<short> lodRenderersCount; // 0xA0
	public NativeArray<float> lodScreenRelativeTransitionHeight; // 0xB0
	public NativeArray<float> lodFadeTransitionWidth; // 0xC0
}

// Namespace: UnityEngine.Rendering
[Flags]
public enum ShaderPropertyFlags // TypeDefIndex: 7188
{
	// Fields
	public int value__; // 0x0
	public const ShaderPropertyFlags None = 0;
	public const ShaderPropertyFlags HideInInspector = 1;
	public const ShaderPropertyFlags PerRendererData = 2;
	public const ShaderPropertyFlags NoScaleOffset = 4;
	public const ShaderPropertyFlags Normal = 8;
	public const ShaderPropertyFlags HDR = 16;
	public const ShaderPropertyFlags Gamma = 32;
	public const ShaderPropertyFlags NonModifiableTextureData = 64;
	public const ShaderPropertyFlags MainTexture = 128;
	public const ShaderPropertyFlags MainColor = 256;
}
