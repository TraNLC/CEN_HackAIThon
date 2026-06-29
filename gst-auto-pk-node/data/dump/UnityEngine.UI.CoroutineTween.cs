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

// Namespace: UnityEngine.UI.CoroutineTween
internal interface ITweenValue // TypeDefIndex: 7360
{
	// Properties
	public abstract bool ignoreTimeScale { get; }
	public abstract float duration { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void TweenValue(float floatPercentage);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_ignoreTimeScale();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract float get_duration();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool ValidTarget();
}

// Namespace: 
public enum ColorTween.ColorTweenMode // TypeDefIndex: 7361
{
	// Fields
	public int value__; // 0x0
	public const ColorTween.ColorTweenMode All = 0;
	public const ColorTween.ColorTweenMode RGB = 1;
	public const ColorTween.ColorTweenMode Alpha = 2;
}

// Namespace: 
public class ColorTween.ColorTweenCallback : UnityEvent<Color> // TypeDefIndex: 7362
{
	// Methods

	// RVA: 0x1F17130 Offset: 0x1F13130 VA: 0x1F17130
	public void .ctor() { }
}

// Namespace: UnityEngine.UI.CoroutineTween
internal struct ColorTween : ITweenValue // TypeDefIndex: 7363
{
	// Fields
	private ColorTween.ColorTweenCallback m_Target; // 0x0
	private Color m_StartColor; // 0x8
	private Color m_TargetColor; // 0x18
	private ColorTween.ColorTweenMode m_TweenMode; // 0x28
	private float m_Duration; // 0x2C
	private bool m_IgnoreTimeScale; // 0x30

	// Properties
	public Color startColor { get; set; }
	public Color targetColor { get; set; }
	public ColorTween.ColorTweenMode tweenMode { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x1F16F54 Offset: 0x1F12F54 VA: 0x1F16F54
	public Color get_startColor() { }

	// RVA: 0x1F16F60 Offset: 0x1F12F60 VA: 0x1F16F60
	public void set_startColor(Color value) { }

	// RVA: 0x1F16F6C Offset: 0x1F12F6C VA: 0x1F16F6C
	public Color get_targetColor() { }

	// RVA: 0x1F16F78 Offset: 0x1F12F78 VA: 0x1F16F78
	public void set_targetColor(Color value) { }

	// RVA: 0x1F16F84 Offset: 0x1F12F84 VA: 0x1F16F84
	public ColorTween.ColorTweenMode get_tweenMode() { }

	// RVA: 0x1F16F8C Offset: 0x1F12F8C VA: 0x1F16F8C
	public void set_tweenMode(ColorTween.ColorTweenMode value) { }

	// RVA: 0x1F16F94 Offset: 0x1F12F94 VA: 0x1F16F94 Slot: 6
	public float get_duration() { }

	// RVA: 0x1F16F9C Offset: 0x1F12F9C VA: 0x1F16F9C
	public void set_duration(float value) { }

	// RVA: 0x1F16FA4 Offset: 0x1F12FA4 VA: 0x1F16FA4 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x1F16FAC Offset: 0x1F12FAC VA: 0x1F16FAC
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x1F16FB4 Offset: 0x1F12FB4 VA: 0x1F16FB4 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x1F1709C Offset: 0x1F1309C VA: 0x1F1709C
	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	// RVA: 0x1F17178 Offset: 0x1F13178 VA: 0x1F17178
	public bool GetIgnoreTimescale() { }

	// RVA: 0x1F17180 Offset: 0x1F13180 VA: 0x1F17180
	public float GetDuration() { }

	// RVA: 0x1F1708C Offset: 0x1F1308C VA: 0x1F1708C Slot: 7
	public bool ValidTarget() { }
}

// Namespace: 
public class FloatTween.FloatTweenCallback : UnityEvent<float> // TypeDefIndex: 7364
{
	// Methods

	// RVA: 0x1F172FC Offset: 0x1F132FC VA: 0x1F172FC
	public void .ctor() { }
}

// Namespace: UnityEngine.UI.CoroutineTween
internal struct FloatTween : ITweenValue // TypeDefIndex: 7365
{
	// Fields
	private FloatTween.FloatTweenCallback m_Target; // 0x0
	private float m_StartValue; // 0x8
	private float m_TargetValue; // 0xC
	private float m_Duration; // 0x10
	private bool m_IgnoreTimeScale; // 0x14

	// Properties
	public float startValue { get; set; }
	public float targetValue { get; set; }
	public float duration { get; set; }
	public bool ignoreTimeScale { get; set; }

	// Methods

	// RVA: 0x1F17188 Offset: 0x1F13188 VA: 0x1F17188
	public float get_startValue() { }

	// RVA: 0x1F17190 Offset: 0x1F13190 VA: 0x1F17190
	public void set_startValue(float value) { }

	// RVA: 0x1F17198 Offset: 0x1F13198 VA: 0x1F17198
	public float get_targetValue() { }

	// RVA: 0x1F171A0 Offset: 0x1F131A0 VA: 0x1F171A0
	public void set_targetValue(float value) { }

	// RVA: 0x1F171A8 Offset: 0x1F131A8 VA: 0x1F171A8 Slot: 6
	public float get_duration() { }

	// RVA: 0x1F171B0 Offset: 0x1F131B0 VA: 0x1F171B0
	public void set_duration(float value) { }

	// RVA: 0x1F171B8 Offset: 0x1F131B8 VA: 0x1F171B8 Slot: 5
	public bool get_ignoreTimeScale() { }

	// RVA: 0x1F171C0 Offset: 0x1F131C0 VA: 0x1F171C0
	public void set_ignoreTimeScale(bool value) { }

	// RVA: 0x1F171C8 Offset: 0x1F131C8 VA: 0x1F171C8 Slot: 4
	public void TweenValue(float floatPercentage) { }

	// RVA: 0x1F17268 Offset: 0x1F13268 VA: 0x1F17268
	public void AddOnChangedCallback(UnityAction<float> callback) { }

	// RVA: 0x1F17344 Offset: 0x1F13344 VA: 0x1F17344
	public bool GetIgnoreTimescale() { }

	// RVA: 0x1F1734C Offset: 0x1F1334C VA: 0x1F1734C
	public float GetDuration() { }

	// RVA: 0x1F17258 Offset: 0x1F13258 VA: 0x1F17258 Slot: 7
	public bool ValidTarget() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TweenRunner.<Start>d__2<T> : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 7366
{
	// Fields
	private int <>1__state; // 0x0
	private object <>2__current; // 0x0
	public T tweenInfo; // 0x0
	private float <elapsedTime>5__2; // 0x0

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116E048 Offset: 0x116A048 VA: 0x116E048
	|-TweenRunner.<Start>d__2<ColorTween>..ctor
	|
	|-RVA: 0x116E338 Offset: 0x116A338 VA: 0x116E338
	|-TweenRunner.<Start>d__2<FloatTween>..ctor
	|
	|-RVA: 0x116EBB4 Offset: 0x116ABB4 VA: 0x116EBB4
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116E070 Offset: 0x116A070 VA: 0x116E070
	|-TweenRunner.<Start>d__2<ColorTween>.System.IDisposable.Dispose
	|
	|-RVA: 0x116E360 Offset: 0x116A360 VA: 0x116E360
	|-TweenRunner.<Start>d__2<FloatTween>.System.IDisposable.Dispose
	|
	|-RVA: 0x116EBF4 Offset: 0x116ABF4 VA: 0x116EBF4
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116E074 Offset: 0x116A074 VA: 0x116E074
	|-TweenRunner.<Start>d__2<ColorTween>.MoveNext
	|
	|-RVA: 0x116E364 Offset: 0x116A364 VA: 0x116E364
	|-TweenRunner.<Start>d__2<FloatTween>.MoveNext
	|
	|-RVA: 0x116EBF8 Offset: 0x116ABF8 VA: 0x116EBF8
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116E17C Offset: 0x116A17C VA: 0x116E17C
	|-TweenRunner.<Start>d__2<ColorTween>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	|
	|-RVA: 0x116E46C Offset: 0x116A46C VA: 0x116E46C
	|-TweenRunner.<Start>d__2<FloatTween>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	|
	|-RVA: 0x116F234 Offset: 0x116B234 VA: 0x116F234
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerator<System.Object>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116E184 Offset: 0x116A184 VA: 0x116E184
	|-TweenRunner.<Start>d__2<ColorTween>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x116E474 Offset: 0x116A474 VA: 0x116E474
	|-TweenRunner.<Start>d__2<FloatTween>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x116F25C Offset: 0x116B25C VA: 0x116F25C
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116E1B8 Offset: 0x116A1B8 VA: 0x116E1B8
	|-TweenRunner.<Start>d__2<ColorTween>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x116E4A8 Offset: 0x116A4A8 VA: 0x116E4A8
	|-TweenRunner.<Start>d__2<FloatTween>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x116F290 Offset: 0x116B290 VA: 0x116F290
	|-TweenRunner.<Start>d__2<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: UnityEngine.UI.CoroutineTween
internal class TweenRunner<T> // TypeDefIndex: 7367
{
	// Fields
	protected MonoBehaviour m_CoroutineContainer; // 0x0
	protected IEnumerator m_Tween; // 0x0

	// Methods

	[IteratorStateMachine(typeof(TweenRunner.<Start>d__2<T>))]
	// RVA: -1 Offset: -1
	private static IEnumerator Start(T tweenInfo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149188C Offset: 0x148D88C VA: 0x149188C
	|-TweenRunner<ColorTween>.Start
	|
	|-RVA: 0x1491B08 Offset: 0x148DB08 VA: 0x1491B08
	|-TweenRunner<FloatTween>.Start
	|
	|-RVA: 0x1491D74 Offset: 0x148DD74 VA: 0x1491D74
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.Start
	*/

	// RVA: -1 Offset: -1
	public void Init(MonoBehaviour coroutineContainer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1491944 Offset: 0x148D944 VA: 0x1491944
	|-TweenRunner<ColorTween>.Init
	|
	|-RVA: 0x1491BB8 Offset: 0x148DBB8 VA: 0x1491BB8
	|-TweenRunner<FloatTween>.Init
	|
	|-RVA: 0x1491F0C Offset: 0x148DF0C VA: 0x1491F0C
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.Init
	*/

	// RVA: -1 Offset: -1
	public void StartTween(T info) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149194C Offset: 0x148D94C VA: 0x149194C
	|-TweenRunner<ColorTween>.StartTween
	|
	|-RVA: 0x1491BC0 Offset: 0x148DBC0 VA: 0x1491BC0
	|-TweenRunner<FloatTween>.StartTween
	|
	|-RVA: 0x1491F14 Offset: 0x148DF14 VA: 0x1491F14
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.StartTween
	*/

	// RVA: -1 Offset: -1
	public void StopTween() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1491AC0 Offset: 0x148DAC0 VA: 0x1491AC0
	|-TweenRunner<ColorTween>.StopTween
	|
	|-RVA: 0x1491D2C Offset: 0x148DD2C VA: 0x1491D2C
	|-TweenRunner<FloatTween>.StopTween
	|
	|-RVA: 0x1492194 Offset: 0x148E194 VA: 0x1492194
	|-TweenRunner<__Il2CppFullySharedGenericStructType>.StopTween
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1491B00 Offset: 0x148DB00 VA: 0x1491B00
	|-TweenRunner<ColorTween>..ctor
	|
	|-RVA: 0x1491D6C Offset: 0x148DD6C VA: 0x1491D6C
	|-TweenRunner<FloatTween>..ctor
	|
	|-RVA: 0x14921D4 Offset: 0x148E1D4 VA: 0x14921D4
	|-TweenRunner<__Il2CppFullySharedGenericStructType>..ctor
	*/
}
