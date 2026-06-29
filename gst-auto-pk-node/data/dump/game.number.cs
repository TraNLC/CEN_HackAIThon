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

// Namespace: game.number
public class Parse // TypeDefIndex: 2168
{
	// Methods

	// RVA: 0xFA0BC0 Offset: 0xF9CBC0 VA: 0xFA0BC0
	public static ushort Ushort(string data, ushort defaultly = 0) { }

	// RVA: 0xFA0BF4 Offset: 0xF9CBF4 VA: 0xFA0BF4
	public static int Int(string data, int defaultly = 0) { }

	// RVA: 0xFA0C28 Offset: 0xF9CC28 VA: 0xFA0C28
	public static long Long(string data, long defaultly = 0) { }

	// RVA: 0xFA0C5C Offset: 0xF9CC5C VA: 0xFA0C5C
	public static float Float(string data, float defaultly = 0) { }

	// RVA: 0xFA0D74 Offset: 0xF9CD74 VA: 0xFA0D74
	public static string ToCashHuman(long value) { }

	// RVA: 0xFA0E7C Offset: 0xF9CE7C VA: 0xFA0E7C
	public static string ToCashHumanBigger(long value) { }

	// RVA: 0xFA0FD8 Offset: 0xF9CFD8 VA: 0xFA0FD8
	public static string ToNumberHuman(long value) { }

	// RVA: 0xFA106C Offset: 0xF9D06C VA: 0xFA106C
	public static string ToStringHuman(long value) { }

	// RVA: 0xFA116C Offset: 0xF9D16C VA: 0xFA116C
	public static string ToTimeHuman(long seconds) { }

	// RVA: 0xFA1318 Offset: 0xF9D318 VA: 0xFA1318
	public void .ctor() { }
}

// Namespace: game.number
public static class Time // TypeDefIndex: 2169
{
	// Methods

	// RVA: 0xFA0980 Offset: 0xF9C980 VA: 0xFA0980
	public static long Stamp() { }

	// RVA: 0xFA09F0 Offset: 0xF9C9F0 VA: 0xFA09F0
	public static long StampSeconds() { }
}

// Namespace: game.number
public class Direction : Direction // TypeDefIndex: 2170
{
	// Methods

	// RVA: 0xFA1320 Offset: 0xF9D320 VA: 0xFA1320
	public void .ctor() { }
}

// Namespace: game.number
public class Random : Random // TypeDefIndex: 2171
{
	// Methods

	// RVA: 0xFA1378 Offset: 0xF9D378 VA: 0xFA1378
	public void .ctor() { }
}

// Namespace: 
public class Buffer.Encoding // TypeDefIndex: 2172
{
	// Fields
	public Encoding encoding; // 0x10
	public int byteOrderMarks; // 0x18

	// Methods

	// RVA: 0xFA17EC Offset: 0xF9D7EC VA: 0xFA17EC
	public void .ctor(Encoding encoding, int byteOrderMarks) { }
}
