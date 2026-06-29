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

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum LightType // TypeDefIndex: 7189
{
	// Fields
	public byte value__; // 0x0
	public const LightType Directional = 0;
	public const LightType Point = 1;
	public const LightType Spot = 2;
	public const LightType Rectangle = 3;
	public const LightType Disc = 4;
	public const LightType SpotPyramidShape = 5;
	public const LightType SpotBoxShape = 6;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum LightMode // TypeDefIndex: 7190
{
	// Fields
	public byte value__; // 0x0
	public const LightMode Realtime = 0;
	public const LightMode Mixed = 1;
	public const LightMode Baked = 2;
	public const LightMode Unknown = 3;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum FalloffType // TypeDefIndex: 7191
{
	// Fields
	public byte value__; // 0x0
	public const FalloffType InverseSquared = 0;
	public const FalloffType InverseSquaredNoRangeAttenuation = 1;
	public const FalloffType Linear = 2;
	public const FalloffType Legacy = 3;
	public const FalloffType Undefined = 4;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public enum AngularFalloffType // TypeDefIndex: 7192
{
	// Fields
	public byte value__; // 0x0
	public const AngularFalloffType LUT = 0;
	public const AngularFalloffType AnalyticAndInnerAngle = 1;
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct LinearColor // TypeDefIndex: 7193
{
	// Fields
	private float m_red; // 0x0
	private float m_green; // 0x4
	private float m_blue; // 0x8
	private float m_intensity; // 0xC

	// Properties
	public float red { get; set; }
	public float green { get; set; }
	public float blue { get; set; }

	// Methods

	// RVA: 0x1E85928 Offset: 0x1E81928 VA: 0x1E85928
	public float get_red() { }

	// RVA: 0x1E85930 Offset: 0x1E81930 VA: 0x1E85930
	public void set_red(float value) { }

	// RVA: 0x1E859DC Offset: 0x1E819DC VA: 0x1E859DC
	public float get_green() { }

	// RVA: 0x1E859E4 Offset: 0x1E819E4 VA: 0x1E859E4
	public void set_green(float value) { }

	// RVA: 0x1E85A90 Offset: 0x1E81A90 VA: 0x1E85A90
	public float get_blue() { }

	// RVA: 0x1E85A98 Offset: 0x1E81A98 VA: 0x1E85A98
	public void set_blue(float value) { }

	// RVA: 0x1E85B44 Offset: 0x1E81B44 VA: 0x1E85B44
	public static LinearColor Convert(Color color, float intensity) { }

	// RVA: 0x1E85DF4 Offset: 0x1E81DF4 VA: 0x1E85DF4
	public static LinearColor Black() { }
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct DirectionalLight // TypeDefIndex: 7194
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float penumbraWidthRadian; // 0x44
	[Obsolete("Directional lights support cookies now. In order to position the cookie projection in the world, a position and full orientation are necessary. Use the position and orientation members instead of the direction parameter.", True)]
	public Vector3 direction; // 0x48
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct PointLight // TypeDefIndex: 7195
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float range; // 0x44
	public float sphereRadius; // 0x48
	public FalloffType falloff; // 0x4C
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct SpotLight // TypeDefIndex: 7196
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float range; // 0x44
	public float sphereRadius; // 0x48
	public float coneAngle; // 0x4C
	public float innerConeAngle; // 0x50
	public FalloffType falloff; // 0x54
	public AngularFalloffType angularFalloff; // 0x55
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct RectangleLight // TypeDefIndex: 7197
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float range; // 0x44
	public float width; // 0x48
	public float height; // 0x4C
	public FalloffType falloff; // 0x50
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct DiscLight // TypeDefIndex: 7198
{
	// Fields
	public int instanceID; // 0x0
	public bool shadow; // 0x4
	public LightMode mode; // 0x5
	public Vector3 position; // 0x8
	public Quaternion orientation; // 0x14
	public LinearColor color; // 0x24
	public LinearColor indirectColor; // 0x34
	public float range; // 0x44
	public float radius; // 0x48
	public FalloffType falloff; // 0x4C
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public struct Cookie // TypeDefIndex: 7199
{
	// Fields
	public int instanceID; // 0x0
	public float scale; // 0x4
	public Vector2 sizes; // 0x8
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
[UsedByNativeCode]
public struct LightDataGI // TypeDefIndex: 7200
{
	// Fields
	public int instanceID; // 0x0
	public int cookieID; // 0x4
	public float cookieScale; // 0x8
	public LinearColor color; // 0xC
	public LinearColor indirectColor; // 0x1C
	public Quaternion orientation; // 0x2C
	public Vector3 position; // 0x3C
	public float range; // 0x48
	public float coneAngle; // 0x4C
	public float innerConeAngle; // 0x50
	public float shape0; // 0x54
	public float shape1; // 0x58
	public LightType type; // 0x5C
	public LightMode mode; // 0x5D
	public byte shadow; // 0x5E
	public FalloffType falloff; // 0x5F

	// Methods

	// RVA: 0x1E85E08 Offset: 0x1E81E08 VA: 0x1E85E08
	public void Init(ref DirectionalLight light, ref Cookie cookie) { }

	// RVA: 0x1E85E78 Offset: 0x1E81E78 VA: 0x1E85E78
	public void Init(ref PointLight light, ref Cookie cookie) { }

	// RVA: 0x1E85EF0 Offset: 0x1E81EF0 VA: 0x1E85EF0
	public void Init(ref SpotLight light, ref Cookie cookie) { }

	// RVA: 0x1E85F6C Offset: 0x1E81F6C VA: 0x1E85F6C
	public void Init(ref RectangleLight light, ref Cookie cookie) { }

	// RVA: 0x1E85FE0 Offset: 0x1E81FE0 VA: 0x1E85FE0
	public void Init(ref DiscLight light, ref Cookie cookie) { }

	// RVA: 0x1E86058 Offset: 0x1E82058 VA: 0x1E86058
	public void InitNoBake(int lightInstanceID) { }
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class LightmapperUtils // TypeDefIndex: 7201
{
	// Methods

	// RVA: 0x1E86068 Offset: 0x1E82068 VA: 0x1E86068
	public static LightMode Extract(LightmapBakeType baketype) { }

	// RVA: 0x1E86080 Offset: 0x1E82080 VA: 0x1E86080
	public static LinearColor ExtractIndirect(Light l) { }

	// RVA: 0x1E860F8 Offset: 0x1E820F8 VA: 0x1E860F8
	public static float ExtractInnerCone(Light l) { }

	// RVA: 0x1E8614C Offset: 0x1E8214C VA: 0x1E8614C
	private static Color ExtractColorTemperature(Light l) { }

	// RVA: 0x1E8621C Offset: 0x1E8221C VA: 0x1E8621C
	private static void ApplyColorTemperature(Color cct, ref LinearColor lightColor) { }

	// RVA: 0x1E86264 Offset: 0x1E82264 VA: 0x1E86264
	public static void Extract(Light l, ref DirectionalLight dir) { }

	// RVA: 0x1E863F8 Offset: 0x1E823F8 VA: 0x1E863F8
	public static void Extract(Light l, ref PointLight point) { }

	// RVA: 0x1E865A4 Offset: 0x1E825A4 VA: 0x1E865A4
	public static void Extract(Light l, ref SpotLight spot) { }

	// RVA: 0x1E86778 Offset: 0x1E82778 VA: 0x1E86778
	public static void Extract(Light l, ref RectangleLight rect) { }

	// RVA: 0x1E86924 Offset: 0x1E82924 VA: 0x1E86924
	public static void Extract(Light l, ref DiscLight disc) { }

	// RVA: 0x1E86AD0 Offset: 0x1E82AD0 VA: 0x1E86AD0
	public static void Extract(Light l, out Cookie cookie) { }
}

// Namespace: 
public sealed class Lightmapping.RequestLightsDelegate : MulticastDelegate // TypeDefIndex: 7202
{
	// Methods

	// RVA: 0x1E86EF0 Offset: 0x1E82EF0 VA: 0x1E86EF0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E86FA4 Offset: 0x1E82FA4 VA: 0x1E86FA4 Slot: 12
	public virtual void Invoke(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class Lightmapping.<>c // TypeDefIndex: 7203
{
	// Fields
	public static readonly Lightmapping.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1E86FB8 Offset: 0x1E82FB8 VA: 0x1E86FB8
	private static void .cctor() { }

	// RVA: 0x1E87020 Offset: 0x1E83020 VA: 0x1E87020
	public void .ctor() { }

	// RVA: 0x1E87028 Offset: 0x1E83028 VA: 0x1E87028
	internal void <.cctor>b__7_0(Light[] requests, NativeArray<LightDataGI> lightsOutput) { }
}

// Namespace: UnityEngine.Experimental.GlobalIllumination
public static class Lightmapping // TypeDefIndex: 7204
{
	// Fields
	[RequiredByNativeCode]
	private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate; // 0x0
	[RequiredByNativeCode]
	private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E86C14 Offset: 0x1E82C14 VA: 0x1E86C14
	public static void SetDelegate(Lightmapping.RequestLightsDelegate del) { }

	[RequiredByNativeCode]
	// RVA: 0x1E86C90 Offset: 0x1E82C90 VA: 0x1E86C90
	public static Lightmapping.RequestLightsDelegate GetDelegate() { }

	[RequiredByNativeCode]
	// RVA: 0x1E86CE8 Offset: 0x1E82CE8 VA: 0x1E86CE8
	public static void ResetDelegate() { }

	[RequiredByNativeCode]
	// RVA: 0x1E86D44 Offset: 0x1E82D44 VA: 0x1E86D44
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	// RVA: 0x1E86E10 Offset: 0x1E82E10 VA: 0x1E86E10
	private static void .cctor() { }
}
