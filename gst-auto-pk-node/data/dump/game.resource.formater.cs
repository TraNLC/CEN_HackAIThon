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

// Namespace: game.resource.formater
public class Direction // TypeDefIndex: 2471
{
	// Fields
	private static readonly int[] sinTable; // 0x0
	private static readonly int[] cosTable; // 0x8

	// Methods

	// RVA: 0xFE0760 Offset: 0xFDC760 VA: 0xFE0760
	public static int DirCos(int directionIndex64) { }

	// RVA: 0xFE07EC Offset: 0xFDC7EC VA: 0xFE07EC
	public static int DirSin(int ndirectionIndex64ir) { }

	// RVA: 0xFE0878 Offset: 0xFDC878 VA: 0xFE0878
	private static int GetDirIndex64(int differenceX, int differenceY) { }

	// RVA: 0xFE0948 Offset: 0xFDC948 VA: 0xFE0948
	public static int GetDirFlatIndex64(int currentX, int currentY, int targetX, int targetY) { }

	// RVA: 0xFE09BC Offset: 0xFDC9BC VA: 0xFE09BC
	public static int GetDir3DIndex64(int currentX, int currentY, int targetX, int targetY) { }

	// RVA: 0xFE0A34 Offset: 0xFDCA34 VA: 0xFE0A34
	public static int GetDir3DValue8(int currentX, int currentY, int targetX, int targetY) { }

	// RVA: 0xFE0ACC Offset: 0xFDCACC VA: 0xFE0ACC
	public static int ConvertIndex64VerticalBottomToIndex64HorizonRight(int dirIndex64) { }

	// RVA: 0xFE0AE0 Offset: 0xFDCAE0 VA: 0xFE0AE0
	public static int ConvertIndex8ToIndex64(int nDir) { }

	// RVA: 0xFE0AC0 Offset: 0xFDCAC0 VA: 0xFE0AC0
	public static int ConvertIndex64ToIndex8(int nDir) { }

	// RVA: 0xFE0AE8 Offset: 0xFDCAE8 VA: 0xFE0AE8
	public static int ConvertIndex64ToAnotherIndexRange(int currentDirIndex64, int anotherCount = 64) { }

	// RVA: 0xFE0AF4 Offset: 0xFDCAF4 VA: 0xFE0AF4
	public static int ConvertCurrentIndexToIndex64(int currentIndex, int currentCount = 64) { }

	// RVA: 0xFE0B00 Offset: 0xFDCB00 VA: 0xFE0B00
	public void .ctor() { }

	// RVA: 0xFE0B08 Offset: 0xFDCB08 VA: 0xFE0B08
	private static void .cctor() { }
}

// Namespace: game.resource.formater
public class Parse // TypeDefIndex: 2472
{
	// Methods

	// RVA: 0xFE0BEC Offset: 0xFDCBEC VA: 0xFE0BEC
	public static int Int(string data, int defaultly = 0) { }

	// RVA: 0xFE0C20 Offset: 0xFDCC20 VA: 0xFE0C20
	public static long Long(string data, long defaultly = 0) { }

	// RVA: 0xFE0C54 Offset: 0xFDCC54 VA: 0xFE0C54
	public void .ctor() { }
}

// Namespace: game.resource.formater
public class Random // TypeDefIndex: 2473
{
	// Fields
	private static int randomSeed; // 0x0
	private static int performanceSeed; // 0x4

	// Methods

	// RVA: 0xFE0C5C Offset: 0xFDCC5C VA: 0xFE0C5C
	public static int Index(int count) { }

	// RVA: 0xFE0DA8 Offset: 0xFDCDA8 VA: 0xFE0DA8
	public static int Range(int nMin, int nMax) { }

	// RVA: 0xFE0E14 Offset: 0xFDCE14 VA: 0xFE0E14
	public static bool Percent(int nPercent) { }

	// RVA: 0xFE0E74 Offset: 0xFDCE74 VA: 0xFE0E74
	public static int Int() { }

	// RVA: 0xFE0EC4 Offset: 0xFDCEC4 VA: 0xFE0EC4
	private static int PerformanceRandomSeed() { }

	// RVA: 0xFE0F30 Offset: 0xFDCF30 VA: 0xFE0F30
	public static int PerformanceIndex(int count) { }

	// RVA: 0xFE0F98 Offset: 0xFDCF98 VA: 0xFE0F98
	public static bool PerformancePercent(int currentPercent) { }

	// RVA: 0xFE100C Offset: 0xFDD00C VA: 0xFE100C
	public static int PerformanceRange(int min, int max) { }

	// RVA: 0xFE1078 Offset: 0xFDD078 VA: 0xFE1078
	public void .ctor() { }

	// RVA: 0xFE1080 Offset: 0xFDD080 VA: 0xFE1080
	private static void .cctor() { }
}

// Namespace: game.resource.formater
public static class Time // TypeDefIndex: 2474
{
	// Methods

	// RVA: 0xFE10E4 Offset: 0xFDD0E4 VA: 0xFE10E4
	public static long Stamp() { }
}

// Namespace: game.resource.formater
internal class Byte1252 // TypeDefIndex: 2475
{
	// Methods

	// RVA: 0xFE1154 Offset: 0xFDD154 VA: 0xFE1154
	public static string TCVN3(byte[] data) { }

	// RVA: 0xFE11C8 Offset: 0xFDD1C8 VA: 0xFE11C8
	public void .ctor() { }
}

// Namespace: game.resource.formater
internal class TCVN3 // TypeDefIndex: 2476
{
	// Fields
	private static readonly int[] convertTable; // 0x0

	// Methods

	// RVA: 0xFE11D0 Offset: 0xFDD1D0 VA: 0xFE11D0
	public static string UTF8(string _tcvn3) { }

	// RVA: 0xFE12C0 Offset: 0xFDD2C0 VA: 0xFE12C0
	public void .ctor() { }

	// RVA: 0xFE12C8 Offset: 0xFDD2C8 VA: 0xFE12C8
	private static void .cctor() { }
}
