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

// Namespace: UnityEngine.Internal
[Usage(18432)]
[Serializable]
public class DefaultValueAttribute : Attribute // TypeDefIndex: 7095
{
	// Fields
	private object DefaultValue; // 0x10

	// Properties
	public object Value { get; }

	// Methods

	// RVA: 0x1E7F704 Offset: 0x1E7B704 VA: 0x1E7F704
	public void .ctor(string value) { }

	// RVA: 0x1E7F734 Offset: 0x1E7B734 VA: 0x1E7F734
	public object get_Value() { }

	// RVA: 0x1E7F73C Offset: 0x1E7B73C VA: 0x1E7F73C Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1E7F7E0 Offset: 0x1E7B7E0 VA: 0x1E7F7E0 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: UnityEngine.Internal
[Serializable]
public class ExcludeFromDocsAttribute : Attribute // TypeDefIndex: 7096
{
	// Methods

	// RVA: 0x1E7F804 Offset: 0x1E7B804 VA: 0x1E7F804
	public void .ctor() { }
}

// Namespace: 
[Flags]
internal enum FrameData.Flags // TypeDefIndex: 7097
{
	// Fields
	public int value__; // 0x0
	public const FrameData.Flags Evaluate = 1;
	public const FrameData.Flags SeekOccured = 2;
	public const FrameData.Flags Loop = 4;
	public const FrameData.Flags Hold = 8;
	public const FrameData.Flags EffectivePlayStateDelayed = 16;
	public const FrameData.Flags EffectivePlayStatePlaying = 32;
}

// Namespace: UnityEngine.Internal
[NativeHeader("Runtime/Input/InputBindings.h")]
internal static class InputUnsafeUtility // TypeDefIndex: 8045
{
	// Methods

	[NativeThrows]
	// RVA: 0x1E98544 Offset: 0x1E94544 VA: 0x1E98544
	internal static bool GetKeyString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x1E98588 Offset: 0x1E94588 VA: 0x1E98588
	internal static bool GetKeyUpString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x1E985CC Offset: 0x1E945CC VA: 0x1E985CC
	internal static bool GetKeyDownString__Unmanaged(byte* name, int nameLen) { }

	[NativeThrows]
	// RVA: 0x1E98610 Offset: 0x1E94610 VA: 0x1E98610
	internal static float GetAxis__Unmanaged(byte* axisName, int axisNameLen) { }

	[NativeThrows]
	// RVA: 0x1E96798 Offset: 0x1E92798 VA: 0x1E96798
	internal static float GetAxisRaw(string axisName) { }

	[NativeThrows]
	// RVA: 0x1E98690 Offset: 0x1E94690 VA: 0x1E98690
	internal static float GetAxisRaw__Unmanaged(byte* axisName, int axisNameLen) { }

	[NativeThrows]
	// RVA: 0x1E986D4 Offset: 0x1E946D4 VA: 0x1E986D4
	internal static bool GetButton__Unmanaged(byte* buttonName, int buttonNameLen) { }

	[NativeThrows]
	// RVA: 0x1E96908 Offset: 0x1E92908 VA: 0x1E96908
	internal static bool GetButtonDown(string buttonName) { }

	[NativeThrows]
	// RVA: 0x1E98754 Offset: 0x1E94754 VA: 0x1E98754
	internal static byte GetButtonDown__Unmanaged(byte* buttonName, int buttonNameLen) { }

	[NativeThrows]
	// RVA: 0x1E98798 Offset: 0x1E94798 VA: 0x1E98798
	internal static bool GetButtonUp__Unmanaged(byte* buttonName, int buttonNameLen) { }

	// RVA: 0x1E98654 Offset: 0x1E94654 VA: 0x1E98654
	private static float GetAxisRaw_Injected(ref ManagedSpanWrapper axisName) { }

	// RVA: 0x1E98718 Offset: 0x1E94718 VA: 0x1E98718
	private static bool GetButtonDown_Injected(ref ManagedSpanWrapper buttonName) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 8046
{}

// Namespace: 
public sealed class AudioSettings.AudioConfigurationChangeHandler : MulticastDelegate // TypeDefIndex: 8047
{
	// Methods

	// RVA: 0x1E488D8 Offset: 0x1E448D8 VA: 0x1E488D8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E48978 Offset: 0x1E44978 VA: 0x1E48978 Slot: 12
	public virtual void Invoke(bool deviceWasChanged) { }
}

// Namespace: 
public static class AudioSettings.Mobile // TypeDefIndex: 8048
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static bool <muteState>k__BackingField; // 0x0
	private static bool _stopAudioOutputOnMute; // 0x1
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<bool> OnMuteStateChanged; // 0x8

	// Properties
	public static bool muteState { get; set; }
	public static bool stopAudioOutputOnMute { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E4898C Offset: 0x1E4498C VA: 0x1E4898C
	public static bool get_muteState() { }

	[CompilerGenerated]
	// RVA: 0x1E489D4 Offset: 0x1E449D4 VA: 0x1E489D4
	private static void set_muteState(bool value) { }

	// RVA: 0x1E48A24 Offset: 0x1E44A24 VA: 0x1E48A24
	public static bool get_stopAudioOutputOnMute() { }

	[RequiredByNativeCode]
	// RVA: 0x1E48A6C Offset: 0x1E44A6C VA: 0x1E48A6C
	internal static void InvokeOnMuteStateChanged(bool mute) { }

	[RequiredByNativeCode]
	// RVA: 0x1E48C34 Offset: 0x1E44C34 VA: 0x1E48C34
	internal static bool InvokeIsStopAudioOutputOnMuteEnabled() { }

	// RVA: 0x1E48C0C Offset: 0x1E44C0C VA: 0x1E48C0C
	public static void StartAudioOutput() { }

	// RVA: 0x1E48BE4 Offset: 0x1E44BE4 VA: 0x1E48BE4
	public static void StopAudioOutput() { }
}
