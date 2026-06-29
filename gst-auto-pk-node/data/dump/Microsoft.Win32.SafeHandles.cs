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

// Namespace: Microsoft.Win32.SafeHandles
internal static class SafeHandleCache<T> // TypeDefIndex: 92
{
	// Fields
	private static T s_invalidHandle; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal static bool IsCachedInvalidHandle(SafeHandle handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1455928 Offset: 0x1451928 VA: 0x1455928
	|-SafeHandleCache<object>.IsCachedInvalidHandle
	*/
}

// Namespace: Microsoft.Win32.SafeHandles
internal sealed class SafePasswordHandle : SafeHandle // TypeDefIndex: 93
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x1735070 Offset: 0x1731070 VA: 0x1735070
	private IntPtr CreateHandle(string password) { }

	// RVA: 0x17350C8 Offset: 0x17310C8 VA: 0x17350C8
	private void FreeHandle() { }

	// RVA: 0x1735124 Offset: 0x1731124 VA: 0x1735124
	public void .ctor(string password) { }

	// RVA: 0x1735160 Offset: 0x1731160 VA: 0x1735160 Slot: 7
	protected override bool ReleaseHandle() { }

	// RVA: 0x1735198 Offset: 0x1731198 VA: 0x1735198 Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1735208 Offset: 0x1731208 VA: 0x1735208 Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x173522C Offset: 0x173122C VA: 0x173522C
	internal string Mono_DangerousGetString() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 94
{
	// Methods

	// RVA: 0x1735288 Offset: 0x1731288 VA: 0x1735288
	public void .ctor(IntPtr preexistingHandle, bool ownsHandle) { }

	// RVA: 0x17352C4 Offset: 0x17312C4 VA: 0x17352C4 Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid // TypeDefIndex: 95
{
	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x1735340 Offset: 0x1731340 VA: 0x1735340
	public void .ctor(IntPtr existingHandle, bool ownsHandle) { }

	// RVA: 0x173536C Offset: 0x173136C VA: 0x173536C Slot: 7
	protected override bool ReleaseHandle() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public abstract class SafeHandleZeroOrMinusOneIsInvalid : SafeHandle // TypeDefIndex: 96
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x17352B4 Offset: 0x17312B4 VA: 0x17352B4
	protected void .ctor(bool ownsHandle) { }

	// RVA: 0x1735388 Offset: 0x1731388 VA: 0x1735388 Slot: 5
	public override bool get_IsInvalid() { }
}

// Namespace: Microsoft.Win32.SafeHandles
public abstract class SafeHandleMinusOneIsInvalid : SafeHandle // TypeDefIndex: 97
{
	// Properties
	public override bool IsInvalid { get; }

	// Methods

	[ReliabilityContract(3, 1)]
	// RVA: 0x17353DC Offset: 0x17313DC VA: 0x17353DC
	protected void .ctor(bool ownsHandle) { }

	// RVA: 0x1735420 Offset: 0x1731420 VA: 0x1735420 Slot: 5
	public override bool get_IsInvalid() { }
}
