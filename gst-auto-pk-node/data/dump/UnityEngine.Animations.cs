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

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[Usage(256)]
public class DiscreteEvaluationAttribute : Attribute // TypeDefIndex: 7997
{}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[Usage(260)]
public class NotKeyableAttribute : Attribute // TypeDefIndex: 7998
{}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
[StaticAccessor("AnimationClipPlayableBindings", 2)]
[RequiredByNativeCode]
public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable> // TypeDefIndex: 7999
{
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x1E469D8 Offset: 0x1E429D8 VA: 0x1E469D8 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x1E469E4 Offset: 0x1E429E4 VA: 0x1E469E4 Slot: 4
	public bool Equals(AnimationClipPlayable other) { }
}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/Director/AnimationHumanStream.h")]
[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationHumanStream.bindings.h")]
public struct AnimationHumanStream // TypeDefIndex: 8000
{
	// Fields
	private IntPtr stream; // 0x0
}

// Namespace: UnityEngine.Animations
[StaticAccessor("AnimationLayerMixerPlayableBindings", 2)]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[RequiredByNativeCode]
public struct AnimationLayerMixerPlayable : IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 8001
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1E46A5C Offset: 0x1E42A5C VA: 0x1E46A5C
	internal void .ctor(PlayableHandle handle, bool singleLayerOptimization = True) { }

	// RVA: 0x1E46BEC Offset: 0x1E42BEC VA: 0x1E46BEC Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x1E46BF8 Offset: 0x1E42BF8 VA: 0x1E46BF8 Slot: 4
	public bool Equals(AnimationLayerMixerPlayable other) { }

	[NativeThrows]
	// RVA: 0x1E46BA8 Offset: 0x1E42BA8 VA: 0x1E46BA8
	private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value) { }

	// RVA: 0x1E46C94 Offset: 0x1E42C94 VA: 0x1E46C94
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[StaticAccessor("AnimationMixerPlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable> // TypeDefIndex: 8002
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1E46D34 Offset: 0x1E42D34 VA: 0x1E46D34
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1E46E24 Offset: 0x1E42E24 VA: 0x1E46E24 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x1E46E30 Offset: 0x1E42E30 VA: 0x1E46E30 Slot: 4
	public bool Equals(AnimationMixerPlayable other) { }

	// RVA: 0x1E46ECC Offset: 0x1E42ECC VA: 0x1E46ECC
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimationMotionXToDeltaPlayable.bindings.h")]
[StaticAccessor("AnimationMotionXToDeltaPlayableBindings", 2)]
[RequiredByNativeCode]
internal struct AnimationMotionXToDeltaPlayable : IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 8003
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1E46F68 Offset: 0x1E42F68 VA: 0x1E46F68
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x1E47058 Offset: 0x1E43058 VA: 0x1E47058 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x1E47064 Offset: 0x1E43064 VA: 0x1E47064 Slot: 4
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x1E47100 Offset: 0x1E43100 VA: 0x1E47100
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("AnimationOffsetPlayableBindings", 2)]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/Director/AnimationOffsetPlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationOffsetPlayable.bindings.h")]
internal struct AnimationOffsetPlayable : IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 8004
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1E4719C Offset: 0x1E4319C VA: 0x1E4719C
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1E4728C Offset: 0x1E4328C VA: 0x1E4728C Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x1E47298 Offset: 0x1E43298 VA: 0x1E47298 Slot: 4
	public bool Equals(AnimationOffsetPlayable other) { }

	// RVA: 0x1E4734C Offset: 0x1E4334C VA: 0x1E4734C
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[StaticAccessor("AnimationPlayableOutputBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayableOutput.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPlayableOutput.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimationPlayableOutput.h")]
[NativeHeader("Modules/Animation/Animator.h")]
public struct AnimationPlayableOutput // TypeDefIndex: 8005
{
	// Fields
	private PlayableOutputHandle m_Handle; // 0x0
}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[StaticAccessor("AnimationPosePlayableBindings", 2)]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Modules/Animation/Director/AnimationPosePlayable.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationPosePlayable.bindings.h")]
internal struct AnimationPosePlayable : IEquatable<AnimationPosePlayable> // TypeDefIndex: 8006
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationPosePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1E473E8 Offset: 0x1E433E8 VA: 0x1E473E8
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1E474D8 Offset: 0x1E434D8 VA: 0x1E474D8 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x1E474E4 Offset: 0x1E434E4 VA: 0x1E474E4 Slot: 4
	public bool Equals(AnimationPosePlayable other) { }

	// RVA: 0x1E47598 Offset: 0x1E43598 VA: 0x1E47598
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/ScriptBindings/AnimationRemoveScalePlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[StaticAccessor("AnimationRemoveScalePlayableBindings", 2)]
[RequiredByNativeCode]
[NativeHeader("Modules/Animation/Director/AnimationRemoveScalePlayable.h")]
internal struct AnimationRemoveScalePlayable : IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 8007
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1E47634 Offset: 0x1E43634 VA: 0x1E47634
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1E47724 Offset: 0x1E43724 VA: 0x1E47724 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x1E47730 Offset: 0x1E43730 VA: 0x1E47730 Slot: 4
	public bool Equals(AnimationRemoveScalePlayable other) { }

	// RVA: 0x1E477E4 Offset: 0x1E437E4 VA: 0x1E477E4
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[RequiredByNativeCode]
[StaticAccessor("AnimationScriptPlayableBindings", 2)]
[MovedFrom("UnityEngine.Experimental.Animations")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationScriptPlayable.bindings.h")]
[NativeHeader("Runtime/Director/Core/HPlayable.h")]
[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
public struct AnimationScriptPlayable : IEquatable<AnimationScriptPlayable> // TypeDefIndex: 8008
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1E47880 Offset: 0x1E43880 VA: 0x1E47880
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1E47970 Offset: 0x1E43970 VA: 0x1E47970 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x1E4797C Offset: 0x1E4397C VA: 0x1E4797C Slot: 4
	public bool Equals(AnimationScriptPlayable other) { }

	// RVA: 0x1E47A18 Offset: 0x1E43A18 VA: 0x1E47A18
	private static void .cctor() { }
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/Director/AnimationStream.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimationStream.bindings.h")]
[RequiredByNativeCode]
[MovedFrom("UnityEngine.Experimental.Animations")]
public struct AnimationStream // TypeDefIndex: 8009
{
	// Fields
	private uint m_AnimatorBindingsVersion; // 0x0
	private IntPtr constant; // 0x8
	private IntPtr input; // 0x10
	private IntPtr output; // 0x18
	private IntPtr workspace; // 0x20
	private IntPtr inputStreamAccessor; // 0x28
	private IntPtr animationHandleBinder; // 0x30
}

// Namespace: UnityEngine.Animations
[NativeHeader("Modules/Animation/AnimatorInfo.h")]
[RequiredByNativeCode]
[StaticAccessor("AnimatorControllerPlayableBindings", 2)]
[NativeHeader("Modules/Animation/RuntimeAnimatorController.h")]
[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerPlayable.bindings.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[NativeHeader("Modules/Animation/Director/AnimatorControllerPlayable.h")]
public struct AnimatorControllerPlayable : IEquatable<AnimatorControllerPlayable> // TypeDefIndex: 8010
{
	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimatorControllerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x1E47AB4 Offset: 0x1E43AB4 VA: 0x1E47AB4
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x1E47C94 Offset: 0x1E43C94 VA: 0x1E47C94 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x1E47B50 Offset: 0x1E43B50 VA: 0x1E47B50
	public void SetHandle(PlayableHandle handle) { }

	// RVA: 0x1E47CA0 Offset: 0x1E43CA0 VA: 0x1E47CA0 Slot: 4
	public bool Equals(AnimatorControllerPlayable other) { }

	// RVA: 0x1E47D3C Offset: 0x1E43D3C VA: 0x1E47D3C
	private static void .cctor() { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 8011
{}
