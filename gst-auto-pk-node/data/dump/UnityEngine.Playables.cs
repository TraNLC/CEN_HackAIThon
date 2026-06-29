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

// Namespace: UnityEngine.Playables
public struct FrameData // TypeDefIndex: 7098
{
	// Fields
	internal ulong m_FrameID; // 0x0
	internal double m_DeltaTime; // 0x8
	internal float m_Weight; // 0x10
	internal float m_EffectiveWeight; // 0x14
	internal double m_EffectiveParentDelay; // 0x18
	internal float m_EffectiveParentSpeed; // 0x20
	internal float m_EffectiveSpeed; // 0x24
	internal FrameData.Flags m_Flags; // 0x28
	internal PlayableOutput m_Output; // 0x30
}

// Namespace: UnityEngine.Playables
public interface INotification // TypeDefIndex: 7099
{}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
public interface INotificationReceiver // TypeDefIndex: 7100
{
	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnNotify(Playable origin, INotification notification, object context);
}

// Namespace: UnityEngine.Playables
public interface IPlayableBehaviour // TypeDefIndex: 7101
{
	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnGraphStart(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnGraphStop(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPlayableCreate(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnPlayableDestroy(Playable playable);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 4
	public abstract void OnBehaviourPlay(Playable playable, FrameData info);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 5
	public abstract void OnBehaviourPause(Playable playable, FrameData info);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void PrepareFrame(Playable playable, FrameData info);

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void ProcessFrame(Playable playable, FrameData info, object playerData);
}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
public struct Playable : IEquatable<Playable> // TypeDefIndex: 7102
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly Playable m_NullPlayable; // 0x0

	// Properties
	public static Playable Null { get; }

	// Methods

	// RVA: 0x1E7F80C Offset: 0x1E7B80C VA: 0x1E7F80C
	public static Playable get_Null() { }

	[VisibleToOtherModules]
	// RVA: 0x1E7F864 Offset: 0x1E7B864 VA: 0x1E7F864
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1E7F86C Offset: 0x1E7B86C VA: 0x1E7F86C Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x1E7F878 Offset: 0x1E7B878 VA: 0x1E7F878 Slot: 4
	public bool Equals(Playable other) { }

	// RVA: 0x1E7F988 Offset: 0x1E7B988 VA: 0x1E7F988
	private static void .cctor() { }
}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
[AssetFileNameExtension("playable", new[] {  })]
[Serializable]
public abstract class PlayableAsset : ScriptableObject // TypeDefIndex: 7103
{
	// Properties
	public virtual double duration { get; }
	public virtual IEnumerable<PlayableBinding> outputs { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Playable CreatePlayable(PlayableGraph graph, GameObject owner);

	// RVA: 0x1E7FA50 Offset: 0x1E7BA50 VA: 0x1E7FA50 Slot: 5
	public virtual double get_duration() { }

	// RVA: 0x1E7FAA8 Offset: 0x1E7BAA8 VA: 0x1E7FAA8 Slot: 6
	public virtual IEnumerable<PlayableBinding> get_outputs() { }

	[RequiredByNativeCode]
	// RVA: 0x1E7FB00 Offset: 0x1E7BB00 VA: 0x1E7FB00
	internal static void Internal_CreatePlayable(PlayableAsset asset, PlayableGraph graph, GameObject go, IntPtr ptr) { }

	[RequiredByNativeCode]
	// RVA: 0x1E7FBD8 Offset: 0x1E7BBD8 VA: 0x1E7FBD8
	internal static void Internal_GetPlayableAssetDuration(PlayableAsset asset, IntPtr ptrToDouble) { }

	// RVA: 0x1E7FC00 Offset: 0x1E7BC00 VA: 0x1E7FC00
	protected void .ctor() { }
}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
[Serializable]
public abstract class PlayableBehaviour : IPlayableBehaviour, ICloneable // TypeDefIndex: 7104
{
	// Methods

	// RVA: 0x1E7FC08 Offset: 0x1E7BC08 VA: 0x1E7FC08
	public void .ctor() { }

	// RVA: 0x1E7FC10 Offset: 0x1E7BC10 VA: 0x1E7FC10 Slot: 13
	public virtual void OnGraphStart(Playable playable) { }

	// RVA: 0x1E7FC14 Offset: 0x1E7BC14 VA: 0x1E7FC14 Slot: 14
	public virtual void OnGraphStop(Playable playable) { }

	// RVA: 0x1E7FC18 Offset: 0x1E7BC18 VA: 0x1E7FC18 Slot: 15
	public virtual void OnPlayableCreate(Playable playable) { }

	// RVA: 0x1E7FC1C Offset: 0x1E7BC1C VA: 0x1E7FC1C Slot: 16
	public virtual void OnPlayableDestroy(Playable playable) { }

	// RVA: 0x1E7FC20 Offset: 0x1E7BC20 VA: 0x1E7FC20 Slot: 17
	public virtual void OnBehaviourPlay(Playable playable, FrameData info) { }

	// RVA: 0x1E7FC24 Offset: 0x1E7BC24 VA: 0x1E7FC24 Slot: 18
	public virtual void OnBehaviourPause(Playable playable, FrameData info) { }

	// RVA: 0x1E7FC28 Offset: 0x1E7BC28 VA: 0x1E7FC28 Slot: 19
	public virtual void PrepareFrame(Playable playable, FrameData info) { }

	// RVA: 0x1E7FC2C Offset: 0x1E7BC2C VA: 0x1E7FC2C Slot: 20
	public virtual void ProcessFrame(Playable playable, FrameData info, object playerData) { }

	// RVA: 0x1E7FC30 Offset: 0x1E7BC30 VA: 0x1E7FC30 Slot: 21
	public virtual object Clone() { }
}

// Namespace: 
[VisibleToOtherModules]
internal sealed class PlayableBinding.CreateOutputMethod : MulticastDelegate // TypeDefIndex: 7105
{
	// Methods

	// RVA: 0x1E7FCC0 Offset: 0x1E7BCC0 VA: 0x1E7FCC0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E7FD60 Offset: 0x1E7BD60 VA: 0x1E7FD60 Slot: 12
	public virtual PlayableOutput Invoke(PlayableGraph graph, string name) { }
}

// Namespace: UnityEngine.Playables
public struct PlayableBinding // TypeDefIndex: 7106
{
	// Fields
	private string m_StreamName; // 0x0
	private Object m_SourceObject; // 0x8
	private Type m_SourceBindingType; // 0x10
	private PlayableBinding.CreateOutputMethod m_CreateOutputMethod; // 0x18
	public static readonly PlayableBinding[] None; // 0x0
	public static readonly double DefaultDuration; // 0x8

	// Methods

	// RVA: 0x1E7FC38 Offset: 0x1E7BC38 VA: 0x1E7FC38
	private static void .cctor() { }
}

// Namespace: UnityEngine.Playables
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Export/Director/PlayableGraph.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[UsedByNativeCode]
public struct PlayableGraph // TypeDefIndex: 7107
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
}

// Namespace: UnityEngine.Playables
[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
public struct PlayableHandle : IEquatable<PlayableHandle> // TypeDefIndex: 7108
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableHandle m_Null; // 0x0

	// Properties
	public static PlayableHandle Null { get; }

	// Methods

	[VisibleToOtherModules]
	// RVA: -1 Offset: -1
	internal bool IsPlayableOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x113B834 Offset: 0x1137834 VA: 0x113B834
	|-PlayableHandle.IsPlayableOfType<AnimationLayerMixerPlayable>
	|
	|-RVA: 0x113B8D8 Offset: 0x11378D8 VA: 0x113B8D8
	|-PlayableHandle.IsPlayableOfType<AnimationMixerPlayable>
	|
	|-RVA: 0x113B97C Offset: 0x113797C VA: 0x113B97C
	|-PlayableHandle.IsPlayableOfType<AnimationMotionXToDeltaPlayable>
	|
	|-RVA: 0x113BA20 Offset: 0x1137A20 VA: 0x113BA20
	|-PlayableHandle.IsPlayableOfType<AnimationOffsetPlayable>
	|
	|-RVA: 0x113BAC4 Offset: 0x1137AC4 VA: 0x113BAC4
	|-PlayableHandle.IsPlayableOfType<AnimationPosePlayable>
	|
	|-RVA: 0x113BB68 Offset: 0x1137B68 VA: 0x113BB68
	|-PlayableHandle.IsPlayableOfType<AnimationRemoveScalePlayable>
	|
	|-RVA: 0x113BC0C Offset: 0x1137C0C VA: 0x113BC0C
	|-PlayableHandle.IsPlayableOfType<AnimationScriptPlayable>
	|
	|-RVA: 0x113BCB0 Offset: 0x1137CB0 VA: 0x113BCB0
	|-PlayableHandle.IsPlayableOfType<AnimatorControllerPlayable>
	|
	|-RVA: 0x113BD54 Offset: 0x1137D54 VA: 0x113BD54
	|-PlayableHandle.IsPlayableOfType<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E7F9F8 Offset: 0x1E7B9F8 VA: 0x1E7F9F8
	public static PlayableHandle get_Null() { }

	// RVA: 0x1E7F910 Offset: 0x1E7B910 VA: 0x1E7F910
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x1E7FD84 Offset: 0x1E7BD84 VA: 0x1E7FD84 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1E7FE30 Offset: 0x1E7BE30 VA: 0x1E7FE30 Slot: 4
	public bool Equals(PlayableHandle other) { }

	// RVA: 0x1E7FEA0 Offset: 0x1E7BEA0 VA: 0x1E7FEA0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E7FD74 Offset: 0x1E7BD74 VA: 0x1E7FD74
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	[VisibleToOtherModules]
	// RVA: 0x1E7FED4 Offset: 0x1E7BED4 VA: 0x1E7FED4
	internal bool IsValid() { }

	[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = True, ThrowsException = True)]
	[VisibleToOtherModules]
	// RVA: 0x1E7FF10 Offset: 0x1E7BF10 VA: 0x1E7FF10
	internal Type GetPlayableType() { }

	// RVA: 0x1E7FF4C Offset: 0x1E7BF4C VA: 0x1E7FF4C
	private static void .cctor() { }
}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
public struct PlayableOutput : IEquatable<PlayableOutput> // TypeDefIndex: 7109
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
	private static readonly PlayableOutput m_NullPlayableOutput; // 0x0

	// Methods

	[VisibleToOtherModules]
	// RVA: 0x1E7FF94 Offset: 0x1E7BF94 VA: 0x1E7FF94
	internal void .ctor(PlayableOutputHandle handle) { }

	// RVA: 0x1E7FF9C Offset: 0x1E7BF9C VA: 0x1E7FF9C Slot: 5
	public PlayableOutputHandle GetHandle() { }

	// RVA: 0x1E7FFA8 Offset: 0x1E7BFA8 VA: 0x1E7FFA8 Slot: 4
	public bool Equals(PlayableOutput other) { }

	// RVA: 0x1E800B8 Offset: 0x1E7C0B8 VA: 0x1E800B8
	private static void .cctor() { }
}

// Namespace: UnityEngine.Playables
[NativeHeader("Runtime/Export/Director/PlayableOutputHandle.bindings.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
public struct PlayableOutputHandle : IEquatable<PlayableOutputHandle> // TypeDefIndex: 7110
{
	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableOutputHandle m_Null; // 0x0

	// Properties
	public static PlayableOutputHandle Null { get; }

	// Methods

	// RVA: 0x1E80128 Offset: 0x1E7C128 VA: 0x1E80128
	public static PlayableOutputHandle get_Null() { }

	// RVA: 0x1E80180 Offset: 0x1E7C180 VA: 0x1E80180 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1E80040 Offset: 0x1E7C040 VA: 0x1E80040
	public static bool op_Equality(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x1E801C4 Offset: 0x1E7C1C4 VA: 0x1E801C4 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x1E80270 Offset: 0x1E7C270 VA: 0x1E80270 Slot: 4
	public bool Equals(PlayableOutputHandle other) { }

	// RVA: 0x1E801B4 Offset: 0x1E7C1B4 VA: 0x1E801B4
	internal static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs) { }

	// RVA: 0x1E802E0 Offset: 0x1E7C2E0 VA: 0x1E802E0
	private static void .cctor() { }
}

// Namespace: UnityEngine.Playables
[RequiredByNativeCode]
public struct ScriptPlayableOutput // TypeDefIndex: 7111
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
}
