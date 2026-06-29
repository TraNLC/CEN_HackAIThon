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

// Namespace: game.npc
public class Package // TypeDefIndex: 2495
{
	// Methods

	// RVA: 0xFE2DC8 Offset: 0xFDEDC8 VA: 0xFE2DC8
	public void .ctor() { }
}

// Namespace: 
public enum NetCoreManager.ServiceType // TypeDefIndex: 2496
{
	// Fields
	public int value__; // 0x0
	public const NetCoreManager.ServiceType MasterService = 0;
	public const NetCoreManager.ServiceType GameService = 1;
}

// Namespace: 
public class NetCoreManager.MessageData // TypeDefIndex: 2497
{
	// Fields
	public readonly int id; // 0x10
	public readonly byte[] buffer; // 0x18

	// Methods

	// RVA: 0xFE461C Offset: 0xFE061C VA: 0xFE461C
	public void .ctor(int messageId, byte[] messageBuffer) { }
}

// Namespace: 
public enum NetCoreManager.ProxySelectType // TypeDefIndex: 2498
{
	// Fields
	public int value__; // 0x0
	public const NetCoreManager.ProxySelectType unidentified = 0;
	public const NetCoreManager.ProxySelectType keepCurrently = 1;
	public const NetCoreManager.ProxySelectType nextProxy = 2;
	public const NetCoreManager.ProxySelectType randomOther = 3;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class NetCoreManager.<>c // TypeDefIndex: 2499
{
	// Fields
	public static readonly NetCoreManager.<>c <>9; // 0x0
	public static Action<NetCoreManager> <>9__33_2; // 0x8
	public static Action<NetCoreManager> <>9__34_1; // 0x10

	// Methods

	// RVA: 0xFE4FE0 Offset: 0xFE0FE0 VA: 0xFE4FE0
	private static void .cctor() { }

	// RVA: 0xFE5048 Offset: 0xFE1048 VA: 0xFE5048
	public void .ctor() { }

	// RVA: 0xFE5050 Offset: 0xFE1050 VA: 0xFE5050
	internal void <EnterGameWorld>b__33_2(NetCoreManager _) { }

	// RVA: 0xFE5128 Offset: 0xFE1128 VA: 0xFE5128
	internal void <EnterGameServer>b__34_1(NetCoreManager _) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NetCoreManager.<>c__DisplayClass33_0 // TypeDefIndex: 2500
{
	// Fields
	public NetCoreManager <>4__this; // 0x10
	public Action onStart; // 0x18
	public MSUnityEntergameResponse entergameMessage; // 0x20
	public Action<NetCoreManager, NetCoreManager.MessageData> <>9__1; // 0x28

	// Methods

	// RVA: 0xFE4A74 Offset: 0xFE0A74 VA: 0xFE4A74
	public void .ctor() { }

	// RVA: 0xFE5200 Offset: 0xFE1200 VA: 0xFE5200
	internal void <EnterGameWorld>b__0(NetCoreManager net, NetCoreManager.MessageData message) { }

	// RVA: 0xFE58FC Offset: 0xFE18FC VA: 0xFE58FC
	internal void <EnterGameWorld>b__1(NetCoreManager net, NetCoreManager.MessageData message2) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NetCoreManager.<>c__DisplayClass34_0 // TypeDefIndex: 2501
{
	// Fields
	public NetCoreManager <>4__this; // 0x10
	public EnterGameServer message; // 0x18

	// Methods

	// RVA: 0xFE4B98 Offset: 0xFE0B98 VA: 0xFE4B98
	public void .ctor() { }

	// RVA: 0xFE5B6C Offset: 0xFE1B6C VA: 0xFE5B6C
	internal void <EnterGameServer>b__0(NetCoreManager net) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class NetCoreManager.<LoadWorldSceneStart>d__32 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 2502
{
	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public Action onStart; // 0x20
	public NetCoreManager <>4__this; // 0x28

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0xFE48F8 Offset: 0xFE08F8 VA: 0xFE48F8
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0xFE5D24 Offset: 0xFE1D24 VA: 0xFE5D24 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0xFE5D28 Offset: 0xFE1D28 VA: 0xFE5D28 Slot: 6
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0xFE5E3C Offset: 0xFE1E3C VA: 0xFE5E3C Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0xFE5E44 Offset: 0xFE1E44 VA: 0xFE5E44 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0xFE5E7C Offset: 0xFE1E7C VA: 0xFE5E7C Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
}
