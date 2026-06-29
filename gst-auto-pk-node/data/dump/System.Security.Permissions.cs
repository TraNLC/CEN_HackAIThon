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

// Namespace: System.Security.Permissions
public enum PermissionState // TypeDefIndex: 696
{
	// Fields
	public int value__; // 0x0
	public const PermissionState None = 0;
	public const PermissionState Unrestricted = 1;
}

// Namespace: System.Security.Permissions
[ComVisible(True)]
[Obsolete("CAS support is not available with Silverlight applications.")]
[Serializable]
public enum SecurityAction // TypeDefIndex: 697
{
	// Fields
	public int value__; // 0x0
	public const SecurityAction Demand = 2;
	public const SecurityAction Assert = 3;
	[Obsolete("This requests should not be used")]
	public const SecurityAction Deny = 4;
	public const SecurityAction PermitOnly = 5;
	public const SecurityAction LinkDemand = 6;
	public const SecurityAction InheritanceDemand = 7;
	[Obsolete("This requests should not be used")]
	public const SecurityAction RequestMinimum = 8;
	[Obsolete("This requests should not be used")]
	public const SecurityAction RequestOptional = 9;
	[Obsolete("This requests should not be used")]
	public const SecurityAction RequestRefuse = 10;
}

// Namespace: 
[CompilerGenerated]
private struct CryptoStream.<ReadAsyncInternal>d__37 : IAsyncStateMachine // TypeDefIndex: 698
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public CryptoStream <>4__this; // 0x20
	public byte[] buffer; // 0x28
	public int offset; // 0x30
	public int count; // 0x34
	public CancellationToken cancellationToken; // 0x38
	private SemaphoreSlim <semaphore>5__2; // 0x40
	private ForceAsyncAwaiter <>u__1; // 0x48
	private TaskAwaiter<int> <>u__2; // 0x50

	// Methods

	// RVA: 0x175D5B8 Offset: 0x17595B8 VA: 0x175D5B8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x175DA8C Offset: 0x1759A8C VA: 0x175DA8C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CryptoStream.<ReadAsyncCore>d__42 : IAsyncStateMachine // TypeDefIndex: 699
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public int count; // 0x20
	public int offset; // 0x24
	public CryptoStream <>4__this; // 0x28
	public byte[] buffer; // 0x30
	public bool useAsync; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private int <bytesToDeliver>5__2; // 0x48
	private int <currentOutputIndex>5__3; // 0x4C
	private int <numWholeBlocksInBytes>5__4; // 0x50
	private byte[] <tempInputBuffer>5__5; // 0x58
	private byte[] <tempOutputBuffer>5__6; // 0x60
	private ValueTaskAwaiter<int> <>u__1; // 0x68

	// Methods

	// RVA: 0x175DB08 Offset: 0x1759B08 VA: 0x175DB08 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x175EC1C Offset: 0x175AC1C VA: 0x175EC1C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CryptoStream.<WriteAsyncInternal>d__46 : IAsyncStateMachine // TypeDefIndex: 700
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public CryptoStream <>4__this; // 0x20
	public byte[] buffer; // 0x28
	public int offset; // 0x30
	public int count; // 0x34
	public CancellationToken cancellationToken; // 0x38
	private SemaphoreSlim <semaphore>5__2; // 0x40
	private ForceAsyncAwaiter <>u__1; // 0x48
	private TaskAwaiter <>u__2; // 0x50

	// Methods

	// RVA: 0x175EC98 Offset: 0x175AC98 VA: 0x175EC98 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x175F0DC Offset: 0x175B0DC VA: 0x175F0DC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct CryptoStream.<WriteAsyncCore>d__49 : IAsyncStateMachine // TypeDefIndex: 701
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public int count; // 0x20
	public int offset; // 0x24
	public CryptoStream <>4__this; // 0x28
	public byte[] buffer; // 0x30
	public bool useAsync; // 0x38
	public CancellationToken cancellationToken; // 0x40
	private int <bytesToWrite>5__2; // 0x48
	private int <currentInputIndex>5__3; // 0x4C
	private int <numOutputBytes>5__4; // 0x50
	private ValueTaskAwaiter <>u__1; // 0x58
	private int <numWholeBlocksInBytes>5__5; // 0x68
	private byte[] <tempOutputBuffer>5__6; // 0x70

	// Methods

	// RVA: 0x175F144 Offset: 0x175B144 VA: 0x175F144 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x175FF84 Offset: 0x175BF84 VA: 0x175FF84 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class CryptoStream.<>c // TypeDefIndex: 702
{
	// Fields
	public static readonly CryptoStream.<>c <>9; // 0x0
	public static Func<SemaphoreSlim> <>9__54_0; // 0x8

	// Methods

	// RVA: 0x175FFEC Offset: 0x175BFEC VA: 0x175FFEC
	private static void .cctor() { }

	// RVA: 0x1760054 Offset: 0x175C054 VA: 0x1760054
	public void .ctor() { }

	// RVA: 0x176005C Offset: 0x175C05C VA: 0x176005C
	internal SemaphoreSlim <get_AsyncActiveSemaphore>b__54_0() { }
}
