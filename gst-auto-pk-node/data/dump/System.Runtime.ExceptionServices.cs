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

// Namespace: System.Runtime.ExceptionServices
public class FirstChanceExceptionEventArgs : EventArgs // TypeDefIndex: 1085
{}

// Namespace: System.Runtime.ExceptionServices
[Usage(64, AllowMultiple = False, Inherited = False)]
public sealed class HandleProcessCorruptedStateExceptionsAttribute : Attribute // TypeDefIndex: 1086
{
	// Methods

	// RVA: 0x17D1CA4 Offset: 0x17CDCA4 VA: 0x17D1CA4
	public void .ctor() { }
}

// Namespace: System.Runtime.ExceptionServices
public sealed class ExceptionDispatchInfo // TypeDefIndex: 1087
{
	// Fields
	private Exception m_Exception; // 0x10
	private object m_stackTrace; // 0x18

	// Properties
	internal object BinaryStackTraceArray { get; }
	public Exception SourceException { get; }

	// Methods

	// RVA: 0x17D1CAC Offset: 0x17CDCAC VA: 0x17D1CAC
	private void .ctor(Exception exception) { }

	// RVA: 0x17D1DF0 Offset: 0x17CDDF0 VA: 0x17D1DF0
	internal object get_BinaryStackTraceArray() { }

	// RVA: 0x17D1878 Offset: 0x17CD878 VA: 0x17D1878
	public static ExceptionDispatchInfo Capture(Exception source) { }

	// RVA: 0x17D1DF8 Offset: 0x17CDDF8 VA: 0x17D1DF8
	public Exception get_SourceException() { }

	[StackTraceHidden]
	// RVA: 0x17D1938 Offset: 0x17CD938 VA: 0x17D1938
	public void Throw() { }

	[StackTraceHidden]
	// RVA: 0x17D1E00 Offset: 0x17CDE00 VA: 0x17D1E00
	public static void Throw(Exception source) { }
}
