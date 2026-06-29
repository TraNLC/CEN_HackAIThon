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

// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/AudioResource.h")]
public abstract class AudioResource : Object // TypeDefIndex: 8058
{
	// Methods

	// RVA: 0x1E48CAC Offset: 0x1E44CAC VA: 0x1E48CAC
	protected internal void .ctor() { }
}

// Namespace: UnityEngine.Audio
[RequiredByNativeCode]
[StaticAccessor("AudioClipPlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioClipPlayable.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioClipPlayable.bindings.h")]
public struct AudioClipPlayable : IEquatable<AudioClipPlayable> // TypeDefIndex: 8059
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x1E49C58 Offset: 0x1E45C58 VA: 0x1E49C58 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x1E49C64 Offset: 0x1E45C64 VA: 0x1E49C64 Slot: 4
	public bool Equals(AudioClipPlayable other) { }
}

// Namespace: UnityEngine.Audio
[ExcludeFromObjectFactory]
[NativeHeader("Modules/Audio/Public/AudioMixer.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixer.bindings.h")]
[ExcludeFromPreset]
public class AudioMixer : Object // TypeDefIndex: 8060
{
	// Methods

	[NativeMethod]
	// RVA: 0x1E49CDC Offset: 0x1E45CDC VA: 0x1E49CDC
	public bool SetFloat(string name, float value) { }

	// RVA: 0x1E49E98 Offset: 0x1E45E98 VA: 0x1E49E98
	private static bool SetFloat_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, float value) { }
}

// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/AudioMixerGroup.h")]
public class AudioMixerGroup : Object // TypeDefIndex: 8061
{
	// Properties
	[NativeProperty]
	public AudioMixer audioMixer { get; }

	// Methods

	// RVA: 0x1E49EEC Offset: 0x1E45EEC VA: 0x1E49EEC
	internal void .ctor() { }

	// RVA: 0x1E49F44 Offset: 0x1E45F44 VA: 0x1E49F44
	public AudioMixer get_audioMixer() { }

	// RVA: 0x1E49FD8 Offset: 0x1E45FD8 VA: 0x1E49FD8
	private static IntPtr get_audioMixer_Injected(IntPtr _unity_self) { }
}

// Namespace: UnityEngine.Audio
[RequiredByNativeCode]
[StaticAccessor("AudioMixerPlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioMixerPlayable.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioMixerPlayable.bindings.h")]
public struct AudioMixerPlayable : IEquatable<AudioMixerPlayable> // TypeDefIndex: 8062
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x1E4A014 Offset: 0x1E46014 VA: 0x1E4A014 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x1E4A020 Offset: 0x1E46020 VA: 0x1E4A020 Slot: 4
	public bool Equals(AudioMixerPlayable other) { }
}

// Namespace: UnityEngine.Audio
[NativeHeader("Modules/Audio/Public/AudioMixerSnapshot.h")]
public class AudioMixerSnapshot : Object // TypeDefIndex: 8063
{}

// Namespace: UnityEngine.Audio
[RequiredByNativeCode]
[StaticAccessor("AudioPlayableOutputBindings", 2)]
[NativeHeader("Modules/Audio/Public/AudioSource.h")]
[NativeHeader("Modules/Audio/Public/Director/AudioPlayableOutput.h")]
[NativeHeader("Modules/Audio/Public/ScriptBindings/AudioPlayableOutput.bindings.h")]
public struct AudioPlayableOutput // TypeDefIndex: 8064
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
}

// Namespace: 
internal class <Module> // TypeDefIndex: 8065
{}
