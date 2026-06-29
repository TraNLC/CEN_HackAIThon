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

// Namespace: UnityEngine.Experimental.Rendering
[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
internal class BuiltinRuntimeReflectionSystem : IScriptableRuntimeReflectionSystem, IDisposable // TypeDefIndex: 7209
{
	// Methods

	// RVA: 0x1E87608 Offset: 0x1E83608 VA: 0x1E87608 Slot: 4
	public bool TickRealtimeProbes() { }

	// RVA: 0x1E87658 Offset: 0x1E83658 VA: 0x1E87658 Slot: 5
	public void Dispose() { }

	// RVA: 0x1E8765C Offset: 0x1E8365C VA: 0x1E8765C
	private void Dispose(bool disposing) { }

	[StaticAccessor("GetReflectionProbes()", Type = 0)]
	// RVA: 0x1E87630 Offset: 0x1E83630 VA: 0x1E87630
	private static bool BuiltinUpdate() { }

	[RequiredByNativeCode]
	// RVA: 0x1E87660 Offset: 0x1E83660 VA: 0x1E87660
	private static BuiltinRuntimeReflectionSystem Internal_BuiltinRuntimeReflectionSystem_New() { }

	// RVA: 0x1E876B4 Offset: 0x1E836B4 VA: 0x1E876B4
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering
public interface IScriptableRuntimeReflectionSystem : IDisposable // TypeDefIndex: 7210
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool TickRealtimeProbes();
}

// Namespace: UnityEngine.Experimental.Rendering
[NativeHeader("Runtime/Camera/ScriptableRuntimeReflectionSystem.h")]
[RequiredByNativeCode]
public static class ScriptableRuntimeReflectionSystemSettings // TypeDefIndex: 7211
{
	// Fields
	private static ScriptableRuntimeReflectionSystemWrapper s_Instance; // 0x0

	// Properties
	private static IScriptableRuntimeReflectionSystem Internal_ScriptableRuntimeReflectionSystemSettings_system { set; }
	private static ScriptableRuntimeReflectionSystemWrapper Internal_ScriptableRuntimeReflectionSystemSettings_instance { get; }

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E876BC Offset: 0x1E836BC VA: 0x1E876BC
	private static void set_Internal_ScriptableRuntimeReflectionSystemSettings_system(IScriptableRuntimeReflectionSystem value) { }

	[RequiredByNativeCode]
	// RVA: 0x1E87808 Offset: 0x1E83808 VA: 0x1E87808
	private static ScriptableRuntimeReflectionSystemWrapper get_Internal_ScriptableRuntimeReflectionSystemSettings_instance() { }

	[RuntimeInitializeOnLoadMethod(0)]
	[StaticAccessor("ScriptableRuntimeReflectionSystem", 2)]
	// RVA: 0x1E87860 Offset: 0x1E83860 VA: 0x1E87860
	private static void ScriptingDirtyReflectionSystemInstance() { }

	// RVA: 0x1E87888 Offset: 0x1E83888 VA: 0x1E87888
	private static void .cctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering
[RequiredByNativeCode]
internal class ScriptableRuntimeReflectionSystemWrapper // TypeDefIndex: 7212
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private IScriptableRuntimeReflectionSystem <implementation>k__BackingField; // 0x10

	// Properties
	internal IScriptableRuntimeReflectionSystem implementation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E8790C Offset: 0x1E8390C VA: 0x1E8790C
	internal IScriptableRuntimeReflectionSystem get_implementation() { }

	[CompilerGenerated]
	// RVA: 0x1E87914 Offset: 0x1E83914 VA: 0x1E87914
	internal void set_implementation(IScriptableRuntimeReflectionSystem value) { }

	[RequiredByNativeCode]
	// RVA: 0x1E8791C Offset: 0x1E8391C VA: 0x1E8791C
	private void Internal_ScriptableRuntimeReflectionSystemWrapper_TickRealtimeProbes(out bool result) { }

	// RVA: 0x1E87904 Offset: 0x1E83904 VA: 0x1E87904
	public void .ctor() { }
}

// Namespace: UnityEngine.Experimental.Rendering
[Flags]
public enum TextureCreationFlags // TypeDefIndex: 7213
{
	// Fields
	public int value__; // 0x0
	public const TextureCreationFlags None = 0;
	public const TextureCreationFlags MipChain = 1;
	public const TextureCreationFlags DontInitializePixels = 4;
	public const TextureCreationFlags Crunch = 64;
	public const TextureCreationFlags DontUploadUponCreate = 1024;
	[ExcludeFromDocs]
	[Obsolete("IgnoreMipmapLimit flag is no longer used since this is now the default behavior for all Texture shapes. Please provide mipmap limit information using a MipmapLimitDescriptor argument.", False)]
	public const TextureCreationFlags IgnoreMipmapLimit = 2048;
}

// Namespace: UnityEngine.Experimental.Rendering
[Flags]
public enum GraphicsFormatUsage // TypeDefIndex: 7214
{
	// Fields
	public int value__; // 0x0
	public const GraphicsFormatUsage None = 0;
	public const GraphicsFormatUsage Sample = 1;
	public const GraphicsFormatUsage Linear = 2;
	public const GraphicsFormatUsage Sparse = 4;
	public const GraphicsFormatUsage Render = 16;
	public const GraphicsFormatUsage Blend = 32;
	public const GraphicsFormatUsage GetPixels = 64;
	public const GraphicsFormatUsage SetPixels = 128;
	public const GraphicsFormatUsage SetPixels32 = 256;
	public const GraphicsFormatUsage ReadPixels = 512;
	public const GraphicsFormatUsage LoadStore = 1024;
	public const GraphicsFormatUsage MSAA2x = 2048;
	public const GraphicsFormatUsage MSAA4x = 4096;
	public const GraphicsFormatUsage MSAA8x = 8192;
	public const GraphicsFormatUsage StencilSampling = 65536;
}

// Namespace: UnityEngine.Experimental.Rendering
public enum DefaultFormat // TypeDefIndex: 7215
{
	// Fields
	public int value__; // 0x0
	public const DefaultFormat LDR = 0;
	public const DefaultFormat HDR = 1;
	public const DefaultFormat DepthStencil = 2;
	public const DefaultFormat Shadow = 3;
	public const DefaultFormat Video = 4;
}

// Namespace: UnityEngine.Experimental.Rendering
public enum GraphicsFormat // TypeDefIndex: 7216
{
	// Fields
	public int value__; // 0x0
	public const GraphicsFormat None = 0;
	public const GraphicsFormat R8_SRGB = 1;
	public const GraphicsFormat R8G8_SRGB = 2;
	public const GraphicsFormat R8G8B8_SRGB = 3;
	public const GraphicsFormat R8G8B8A8_SRGB = 4;
	public const GraphicsFormat R8_UNorm = 5;
	public const GraphicsFormat R8G8_UNorm = 6;
	public const GraphicsFormat R8G8B8_UNorm = 7;
	public const GraphicsFormat R8G8B8A8_UNorm = 8;
	public const GraphicsFormat R8_SNorm = 9;
	public const GraphicsFormat R8G8_SNorm = 10;
	public const GraphicsFormat R8G8B8_SNorm = 11;
	public const GraphicsFormat R8G8B8A8_SNorm = 12;
	public const GraphicsFormat R8_UInt = 13;
	public const GraphicsFormat R8G8_UInt = 14;
	public const GraphicsFormat R8G8B8_UInt = 15;
	public const GraphicsFormat R8G8B8A8_UInt = 16;
	public const GraphicsFormat R8_SInt = 17;
	public const GraphicsFormat R8G8_SInt = 18;
	public const GraphicsFormat R8G8B8_SInt = 19;
	public const GraphicsFormat R8G8B8A8_SInt = 20;
	public const GraphicsFormat R16_UNorm = 21;
	public const GraphicsFormat R16G16_UNorm = 22;
	public const GraphicsFormat R16G16B16_UNorm = 23;
	public const GraphicsFormat R16G16B16A16_UNorm = 24;
	public const GraphicsFormat R16_SNorm = 25;
	public const GraphicsFormat R16G16_SNorm = 26;
	public const GraphicsFormat R16G16B16_SNorm = 27;
	public const GraphicsFormat R16G16B16A16_SNorm = 28;
	public const GraphicsFormat R16_UInt = 29;
	public const GraphicsFormat R16G16_UInt = 30;
	public const GraphicsFormat R16G16B16_UInt = 31;
	public const GraphicsFormat R16G16B16A16_UInt = 32;
	public const GraphicsFormat R16_SInt = 33;
	public const GraphicsFormat R16G16_SInt = 34;
	public const GraphicsFormat R16G16B16_SInt = 35;
	public const GraphicsFormat R16G16B16A16_SInt = 36;
	public const GraphicsFormat R32_UInt = 37;
	public const GraphicsFormat R32G32_UInt = 38;
	public const GraphicsFormat R32G32B32_UInt = 39;
	public const GraphicsFormat R32G32B32A32_UInt = 40;
	public const GraphicsFormat R32_SInt = 41;
	public const GraphicsFormat R32G32_SInt = 42;
	public const GraphicsFormat R32G32B32_SInt = 43;
	public const GraphicsFormat R32G32B32A32_SInt = 44;
	public const GraphicsFormat R16_SFloat = 45;
	public const GraphicsFormat R16G16_SFloat = 46;
	public const GraphicsFormat R16G16B16_SFloat = 47;
	public const GraphicsFormat R16G16B16A16_SFloat = 48;
	public const GraphicsFormat R32_SFloat = 49;
	public const GraphicsFormat R32G32_SFloat = 50;
	public const GraphicsFormat R32G32B32_SFloat = 51;
	public const GraphicsFormat R32G32B32A32_SFloat = 52;
	public const GraphicsFormat B8G8R8_SRGB = 56;
	public const GraphicsFormat B8G8R8A8_SRGB = 57;
	public const GraphicsFormat B8G8R8_UNorm = 58;
	public const GraphicsFormat B8G8R8A8_UNorm = 59;
	public const GraphicsFormat B8G8R8_SNorm = 60;
	public const GraphicsFormat B8G8R8A8_SNorm = 61;
	public const GraphicsFormat B8G8R8_UInt = 62;
	public const GraphicsFormat B8G8R8A8_UInt = 63;
	public const GraphicsFormat B8G8R8_SInt = 64;
	public const GraphicsFormat B8G8R8A8_SInt = 65;
	public const GraphicsFormat R4G4B4A4_UNormPack16 = 66;
	public const GraphicsFormat B4G4R4A4_UNormPack16 = 67;
	public const GraphicsFormat R5G6B5_UNormPack16 = 68;
	public const GraphicsFormat B5G6R5_UNormPack16 = 69;
	public const GraphicsFormat R5G5B5A1_UNormPack16 = 70;
	public const GraphicsFormat B5G5R5A1_UNormPack16 = 71;
	public const GraphicsFormat A1R5G5B5_UNormPack16 = 72;
	public const GraphicsFormat E5B9G9R9_UFloatPack32 = 73;
	public const GraphicsFormat B10G11R11_UFloatPack32 = 74;
	public const GraphicsFormat A2B10G10R10_UNormPack32 = 75;
	public const GraphicsFormat A2B10G10R10_UIntPack32 = 76;
	public const GraphicsFormat A2B10G10R10_SIntPack32 = 77;
	public const GraphicsFormat A2R10G10B10_UNormPack32 = 78;
	public const GraphicsFormat A2R10G10B10_UIntPack32 = 79;
	public const GraphicsFormat A2R10G10B10_SIntPack32 = 80;
	public const GraphicsFormat A2R10G10B10_XRSRGBPack32 = 81;
	public const GraphicsFormat A2R10G10B10_XRUNormPack32 = 82;
	public const GraphicsFormat R10G10B10_XRSRGBPack32 = 83;
	public const GraphicsFormat R10G10B10_XRUNormPack32 = 84;
	public const GraphicsFormat A10R10G10B10_XRSRGBPack32 = 85;
	public const GraphicsFormat A10R10G10B10_XRUNormPack32 = 86;
	public const GraphicsFormat D16_UNorm = 90;
	public const GraphicsFormat D24_UNorm = 91;
	public const GraphicsFormat D24_UNorm_S8_UInt = 92;
	public const GraphicsFormat D32_SFloat = 93;
	public const GraphicsFormat D32_SFloat_S8_UInt = 94;
	public const GraphicsFormat S8_UInt = 95;
	[EditorBrowsable(1)]
	[Obsolete("Enum member GraphicsFormat.RGB_DXT1_SRGB has been deprecated. Use GraphicsFormat.RGBA_DXT1_SRGB instead (UnityUpgradable) -> RGBA_DXT1_SRGB", True)]
	public const GraphicsFormat RGB_DXT1_SRGB = 96;
	public const GraphicsFormat RGBA_DXT1_SRGB = 96;
	[Obsolete("Enum member GraphicsFormat.RGB_DXT1_UNorm has been deprecated. Use GraphicsFormat.RGBA_DXT1_UNorm instead (UnityUpgradable) -> RGBA_DXT1_UNorm", True)]
	[EditorBrowsable(1)]
	public const GraphicsFormat RGB_DXT1_UNorm = 97;
	public const GraphicsFormat RGBA_DXT1_UNorm = 97;
	public const GraphicsFormat RGBA_DXT3_SRGB = 98;
	public const GraphicsFormat RGBA_DXT3_UNorm = 99;
	public const GraphicsFormat RGBA_DXT5_SRGB = 100;
	public const GraphicsFormat RGBA_DXT5_UNorm = 101;
	public const GraphicsFormat R_BC4_UNorm = 102;
	public const GraphicsFormat R_BC4_SNorm = 103;
	public const GraphicsFormat RG_BC5_UNorm = 104;
	public const GraphicsFormat RG_BC5_SNorm = 105;
	public const GraphicsFormat RGB_BC6H_UFloat = 106;
	public const GraphicsFormat RGB_BC6H_SFloat = 107;
	public const GraphicsFormat RGBA_BC7_SRGB = 108;
	public const GraphicsFormat RGBA_BC7_UNorm = 109;
	public const GraphicsFormat RGB_PVRTC_2Bpp_SRGB = 110;
	public const GraphicsFormat RGB_PVRTC_2Bpp_UNorm = 111;
	public const GraphicsFormat RGB_PVRTC_4Bpp_SRGB = 112;
	public const GraphicsFormat RGB_PVRTC_4Bpp_UNorm = 113;
	public const GraphicsFormat RGBA_PVRTC_2Bpp_SRGB = 114;
	public const GraphicsFormat RGBA_PVRTC_2Bpp_UNorm = 115;
	public const GraphicsFormat RGBA_PVRTC_4Bpp_SRGB = 116;
	public const GraphicsFormat RGBA_PVRTC_4Bpp_UNorm = 117;
	public const GraphicsFormat RGB_ETC_UNorm = 118;
	public const GraphicsFormat RGB_ETC2_SRGB = 119;
	public const GraphicsFormat RGB_ETC2_UNorm = 120;
	public const GraphicsFormat RGB_A1_ETC2_SRGB = 121;
	public const GraphicsFormat RGB_A1_ETC2_UNorm = 122;
	public const GraphicsFormat RGBA_ETC2_SRGB = 123;
	public const GraphicsFormat RGBA_ETC2_UNorm = 124;
	public const GraphicsFormat R_EAC_UNorm = 125;
	public const GraphicsFormat R_EAC_SNorm = 126;
	public const GraphicsFormat RG_EAC_UNorm = 127;
	public const GraphicsFormat RG_EAC_SNorm = 128;
	public const GraphicsFormat RGBA_ASTC4X4_SRGB = 129;
	public const GraphicsFormat RGBA_ASTC4X4_UNorm = 130;
	public const GraphicsFormat RGBA_ASTC5X5_SRGB = 131;
	public const GraphicsFormat RGBA_ASTC5X5_UNorm = 132;
	public const GraphicsFormat RGBA_ASTC6X6_SRGB = 133;
	public const GraphicsFormat RGBA_ASTC6X6_UNorm = 134;
	public const GraphicsFormat RGBA_ASTC8X8_SRGB = 135;
	public const GraphicsFormat RGBA_ASTC8X8_UNorm = 136;
	public const GraphicsFormat RGBA_ASTC10X10_SRGB = 137;
	public const GraphicsFormat RGBA_ASTC10X10_UNorm = 138;
	public const GraphicsFormat RGBA_ASTC12X12_SRGB = 139;
	public const GraphicsFormat RGBA_ASTC12X12_UNorm = 140;
	public const GraphicsFormat YUV2 = 141;
	[EditorBrowsable(1)]
	[Obsolete("Enum member GraphicsFormat.DepthAuto is obsolete. Use GraphicsFormat.None as a color format to indicate depth only rendering and DefaultFormat to get the default depth buffer format.", True)]
	public const GraphicsFormat DepthAuto = 142;
	[Obsolete("Enum member GraphicsFormat.ShadowAuto is obsolete. Use GraphicsFormat.None as a color format to indicate depth only rendering, DefaultFormat to get the default shadow buffer format and ShadowSamplingMode.CompareDepths to enable shadowmap sampling.", True)]
	[EditorBrowsable(1)]
	public const GraphicsFormat ShadowAuto = 143;
	[EditorBrowsable(1)]
	[Obsolete("Enum member GraphicsFormat.VideoAuto is obsolete. Use DefaultFormat instead.", True)]
	public const GraphicsFormat VideoAuto = 144;
	public const GraphicsFormat RGBA_ASTC4X4_UFloat = 145;
	public const GraphicsFormat RGBA_ASTC5X5_UFloat = 146;
	public const GraphicsFormat RGBA_ASTC6X6_UFloat = 147;
	public const GraphicsFormat RGBA_ASTC8X8_UFloat = 148;
	public const GraphicsFormat RGBA_ASTC10X10_UFloat = 149;
	public const GraphicsFormat RGBA_ASTC12X12_UFloat = 150;
	public const GraphicsFormat D16_UNorm_S8_UInt = 151;
}

// Namespace: UnityEngine.Experimental.Rendering
[NativeHeader("Runtime/Graphics/Format.h")]
[NativeHeader("Runtime/Graphics/TextureFormat.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
public class GraphicsFormatUtility // TypeDefIndex: 7217
{
	// Fields
	private static readonly GraphicsFormat[] tableNoStencil; // 0x0
	private static readonly GraphicsFormat[] tableStencil; // 0x8

	// Methods

	// RVA: 0x1E879DC Offset: 0x1E839DC VA: 0x1E879DC
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x1E87A60 Offset: 0x1E83A60 VA: 0x1E87A60
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x1E87AA4 Offset: 0x1E83AA4 VA: 0x1E87AA4
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[FreeFunction(IsThreadSafe = False)]
	// RVA: 0x1E87B28 Offset: 0x1E83B28 VA: 0x1E87B28
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x1E87B6C Offset: 0x1E83B6C VA: 0x1E87B6C
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x1E87BF4 Offset: 0x1E83BF4 VA: 0x1E87BF4
	private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits) { }

	// RVA: 0x1E87C30 Offset: 0x1E83C30 VA: 0x1E87C30
	public static GraphicsFormat GetDepthStencilFormat(int depthBits) { }

	// RVA: 0x1E87CA4 Offset: 0x1E83CA4 VA: 0x1E87CA4
	public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x1E87EAC Offset: 0x1E83EAC VA: 0x1E87EAC
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x1E87EE8 Offset: 0x1E83EE8 VA: 0x1E87EE8
	public static RenderTextureFormat GetRenderTextureFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x1E87F24 Offset: 0x1E83F24 VA: 0x1E87F24
	private static bool IsCompressedFormat_Native_TextureFormat(TextureFormat format) { }

	// RVA: 0x1E87F60 Offset: 0x1E83F60 VA: 0x1E87F60
	public static bool IsCompressedFormat(TextureFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x1E87FD4 Offset: 0x1E83FD4 VA: 0x1E87FD4
	private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage) { }

	// RVA: 0x1E88018 Offset: 0x1E84018 VA: 0x1E88018
	internal static bool CanDecompressFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x1E88090 Offset: 0x1E84090 VA: 0x1E88090
	public static bool IsDepthStencilFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x1E880CC Offset: 0x1E840CC VA: 0x1E880CC
	public static bool IsPVRTCFormat(GraphicsFormat format) { }

	[FreeFunction("IsCompressedCrunchTextureFormat", IsThreadSafe = True)]
	// RVA: 0x1E88108 Offset: 0x1E84108 VA: 0x1E88108
	public static bool IsCrunchFormat(TextureFormat format) { }

	// RVA: 0x1E88144 Offset: 0x1E84144 VA: 0x1E88144
	private static void .cctor() { }
}
