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

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(2048, Inherited = False)]
public sealed class MaybeNullWhenAttribute : Attribute // TypeDefIndex: 1385
{
	// Fields
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x18425F0 Offset: 0x183E5F0 VA: 0x18425F0
	public void .ctor(bool returnValue) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(2048, Inherited = False)]
public sealed class NotNullWhenAttribute : Attribute // TypeDefIndex: 1386
{
	// Fields
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1842618 Offset: 0x183E618 VA: 0x1842618
	public void .ctor(bool returnValue) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(64, Inherited = False)]
public sealed class DoesNotReturnAttribute : Attribute // TypeDefIndex: 1387
{
	// Methods

	// RVA: 0x1842640 Offset: 0x183E640 VA: 0x1842640
	public void .ctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(749, Inherited = False, AllowMultiple = False)]
public sealed class ExcludeFromCodeCoverageAttribute : Attribute // TypeDefIndex: 3900
{
	// Methods

	// RVA: 0x1D15EE0 Offset: 0x1D11EE0 VA: 0x1D15EE0
	public void .ctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(10688, AllowMultiple = True)]
internal sealed class NotNullAttribute : Attribute // TypeDefIndex: 5986
{
	// Methods

	// RVA: 0x1920548 Offset: 0x191C548 VA: 0x1920548
	public void .ctor() { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(2048, AllowMultiple = False)]
internal sealed class NotNullWhenAttribute : Attribute // TypeDefIndex: 5987
{
	// Fields
	[CompilerGenerated]
	private readonly bool <ReturnValue>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1920550 Offset: 0x191C550 VA: 0x1920550
	public void .ctor(bool returnValue) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(28108, Inherited = False)]
internal sealed class DynamicallyAccessedMembersAttribute : Attribute // TypeDefIndex: 6290
{
	// Fields
	[CompilerGenerated]
	private readonly DynamicallyAccessedMemberTypes <MemberTypes>k__BackingField; // 0x10

	// Methods

	// RVA: 0x15CD880 Offset: 0x15C9880 VA: 0x15CD880
	public void .ctor(DynamicallyAccessedMemberTypes memberTypes) { }
}

// Namespace: System.Diagnostics.CodeAnalysis
[Flags]
internal enum DynamicallyAccessedMemberTypes // TypeDefIndex: 6291
{
	// Fields
	public int value__; // 0x0
	public const DynamicallyAccessedMemberTypes None = 0;
	public const DynamicallyAccessedMemberTypes PublicParameterlessConstructor = 1;
	public const DynamicallyAccessedMemberTypes PublicConstructors = 3;
	public const DynamicallyAccessedMemberTypes NonPublicConstructors = 4;
	public const DynamicallyAccessedMemberTypes PublicMethods = 8;
	public const DynamicallyAccessedMemberTypes NonPublicMethods = 16;
	public const DynamicallyAccessedMemberTypes PublicFields = 32;
	public const DynamicallyAccessedMemberTypes NonPublicFields = 64;
	public const DynamicallyAccessedMemberTypes PublicNestedTypes = 128;
	public const DynamicallyAccessedMemberTypes NonPublicNestedTypes = 256;
	public const DynamicallyAccessedMemberTypes PublicProperties = 512;
	public const DynamicallyAccessedMemberTypes NonPublicProperties = 1024;
	public const DynamicallyAccessedMemberTypes PublicEvents = 2048;
	public const DynamicallyAccessedMemberTypes NonPublicEvents = 4096;
	public const DynamicallyAccessedMemberTypes Interfaces = 8192;
	public const DynamicallyAccessedMemberTypes All = -1;
}

// Namespace: System.Diagnostics.CodeAnalysis
[Usage(32767, Inherited = False, AllowMultiple = True)]
internal sealed class UnconditionalSuppressMessageAttribute : Attribute // TypeDefIndex: 6292
{
	// Fields
	[CompilerGenerated]
	private readonly string <Category>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <CheckId>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Justification>k__BackingField; // 0x20

	// Properties
	public string Justification { set; }

	// Methods

	// RVA: 0x15CD8A8 Offset: 0x15C98A8 VA: 0x15CD8A8
	public void .ctor(string category, string checkId) { }

	[CompilerGenerated]
	// RVA: 0x15CD8EC Offset: 0x15C98EC VA: 0x15CD8EC
	public void set_Justification(string value) { }
}

// Namespace: 
private sealed class ByteString.ByteStringDebugView // TypeDefIndex: 6293
{}
