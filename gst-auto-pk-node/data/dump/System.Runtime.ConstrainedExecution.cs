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

// Namespace: System.Runtime.ConstrainedExecution
public enum Cer // TypeDefIndex: 1088
{
	// Fields
	public int value__; // 0x0
	public const Cer None = 0;
	public const Cer MayFail = 1;
	public const Cer Success = 2;
}

// Namespace: System.Runtime.ConstrainedExecution
public enum Consistency // TypeDefIndex: 1089
{
	// Fields
	public int value__; // 0x0
	public const Consistency MayCorruptProcess = 0;
	public const Consistency MayCorruptAppDomain = 1;
	public const Consistency MayCorruptInstance = 2;
	public const Consistency WillNotCorruptState = 3;
}

// Namespace: System.Runtime.ConstrainedExecution
[Usage(1133, Inherited = False)]
public sealed class ReliabilityContractAttribute : Attribute // TypeDefIndex: 1090
{
	// Fields
	[CompilerGenerated]
	private readonly Consistency <ConsistencyGuarantee>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Cer <Cer>k__BackingField; // 0x14

	// Methods

	// RVA: 0x17D1E14 Offset: 0x17CDE14 VA: 0x17D1E14
	public void .ctor(Consistency consistencyGuarantee, Cer cer) { }
}

// Namespace: System.Runtime.ConstrainedExecution
[Usage(96, Inherited = False)]
public sealed class PrePrepareMethodAttribute : Attribute // TypeDefIndex: 1091
{
	// Methods

	// RVA: 0x17D1E40 Offset: 0x17CDE40 VA: 0x17D1E40
	public void .ctor() { }
}

// Namespace: System.Runtime.ConstrainedExecution
public abstract class CriticalFinalizerObject // TypeDefIndex: 1092
{
	// Methods

	// RVA: 0x17CFBE0 Offset: 0x17CBBE0 VA: 0x17CFBE0
	protected void .ctor() { }

	// RVA: 0x17D1E48 Offset: 0x17CDE48 VA: 0x17D1E48 Slot: 1
	protected override void Finalize() { }
}
