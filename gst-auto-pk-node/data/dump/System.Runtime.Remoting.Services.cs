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

// Namespace: System.Runtime.Remoting.Services
[ComVisible(True)]
public interface ITrackingHandler // TypeDefIndex: 827
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void DisconnectedObject(object obj);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void MarshaledObject(object obj, ObjRef or);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UnmarshaledObject(object obj, ObjRef or);
}

// Namespace: System.Runtime.Remoting.Services
[ComVisible(True)]
public class TrackingServices // TypeDefIndex: 828
{
	// Fields
	private static ArrayList _handlers; // 0x0

	// Methods

	// RVA: 0x178D7C0 Offset: 0x17897C0 VA: 0x178D7C0
	internal static void NotifyMarshaledObject(object obj, ObjRef or) { }

	// RVA: 0x178CB3C Offset: 0x1788B3C VA: 0x178CB3C
	internal static void NotifyUnmarshaledObject(object obj, ObjRef or) { }

	// RVA: 0x1790D6C Offset: 0x178CD6C VA: 0x1790D6C
	internal static void NotifyDisconnectedObject(object obj) { }

	// RVA: 0x1792A20 Offset: 0x178EA20 VA: 0x1792A20
	private static void .cctor() { }
}
