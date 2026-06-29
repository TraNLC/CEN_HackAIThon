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

// Namespace: Mono.Math.Prime
internal enum ConfidenceFactor // TypeDefIndex: 86
{
	// Fields
	public int value__; // 0x0
	public const ConfidenceFactor ExtraLow = 0;
	public const ConfidenceFactor Low = 1;
	public const ConfidenceFactor Medium = 2;
	public const ConfidenceFactor High = 3;
	public const ConfidenceFactor ExtraHigh = 4;
	public const ConfidenceFactor Provable = 5;
}

// Namespace: Mono.Math.Prime
internal sealed class PrimalityTest : MulticastDelegate // TypeDefIndex: 87
{
	// Methods

	// RVA: 0x17344D8 Offset: 0x17304D8 VA: 0x17344D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17345E4 Offset: 0x17305E4 VA: 0x17345E4 Slot: 12
	public virtual bool Invoke(BigInteger bi, ConfidenceFactor confidence) { }
}

// Namespace: Mono.Math.Prime
internal sealed class PrimalityTests // TypeDefIndex: 88
{
	// Methods

	// RVA: 0x17345F8 Offset: 0x17305F8 VA: 0x17345F8
	private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) { }

	// RVA: 0x1733754 Offset: 0x172F754 VA: 0x1733754
	public static bool Test(BigInteger n, ConfidenceFactor confidence) { }

	// RVA: 0x1734974 Offset: 0x1730974 VA: 0x1734974
	public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence) { }

	// RVA: 0x17347A0 Offset: 0x17307A0 VA: 0x17347A0
	public static bool SmallPrimeSppTest(BigInteger bi, ConfidenceFactor confidence) { }
}

// Namespace: Mono.Math.Prime
public enum ConfidenceFactor // TypeDefIndex: 7584
{
	// Fields
	public int value__; // 0x0
	public const ConfidenceFactor ExtraLow = 0;
	public const ConfidenceFactor Low = 1;
	public const ConfidenceFactor Medium = 2;
	public const ConfidenceFactor High = 3;
	public const ConfidenceFactor ExtraHigh = 4;
	public const ConfidenceFactor Provable = 5;
}

// Namespace: Mono.Math.Prime
public sealed class PrimalityTest : MulticastDelegate // TypeDefIndex: 7585
{
	// Methods

	// RVA: 0x1714990 Offset: 0x1710990 VA: 0x1714990
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1714A9C Offset: 0x1710A9C VA: 0x1714A9C Slot: 12
	public virtual bool Invoke(BigInteger bi, ConfidenceFactor confidence) { }
}

// Namespace: Mono.Math.Prime
public sealed class PrimalityTests // TypeDefIndex: 7586
{
	// Methods

	// RVA: 0x1714AB0 Offset: 0x1710AB0 VA: 0x1714AB0
	private static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence) { }

	// RVA: 0x1714C58 Offset: 0x1710C58 VA: 0x1714C58
	public static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence) { }
}
