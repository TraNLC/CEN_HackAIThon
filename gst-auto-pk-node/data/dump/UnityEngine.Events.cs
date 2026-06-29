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

// Namespace: UnityEngine.Events
[Serializable]
public enum PersistentListenerMode // TypeDefIndex: 6884
{
	// Fields
	public int value__; // 0x0
	public const PersistentListenerMode EventDefined = 0;
	public const PersistentListenerMode Void = 1;
	public const PersistentListenerMode Object = 2;
	public const PersistentListenerMode Int = 3;
	public const PersistentListenerMode Float = 4;
	public const PersistentListenerMode String = 5;
	public const PersistentListenerMode Bool = 6;
}

// Namespace: UnityEngine.Events
internal class UnityEventTools // TypeDefIndex: 6885
{
	// Methods

	// RVA: 0x1E79CA8 Offset: 0x1E75CA8 VA: 0x1E79CA8
	internal static string TidyAssemblyTypeName(string assemblyTypeName) { }
}

// Namespace: UnityEngine.Events
[Serializable]
internal class ArgumentCache : ISerializationCallbackReceiver // TypeDefIndex: 6886
{
	// Fields
	[FormerlySerializedAs("objectArgument")]
	[SerializeField]
	private Object m_ObjectArgument; // 0x10
	[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
	[SerializeField]
	private string m_ObjectArgumentAssemblyTypeName; // 0x18
	[FormerlySerializedAs("intArgument")]
	[SerializeField]
	private int m_IntArgument; // 0x20
	[SerializeField]
	[FormerlySerializedAs("floatArgument")]
	private float m_FloatArgument; // 0x24
	[FormerlySerializedAs("stringArgument")]
	[SerializeField]
	private string m_StringArgument; // 0x28
	[SerializeField]
	private bool m_BoolArgument; // 0x30

	// Properties
	public Object unityObjectArgument { get; }
	public string unityObjectArgumentAssemblyTypeName { get; }
	public int intArgument { get; }
	public float floatArgument { get; }
	public string stringArgument { get; }
	public bool boolArgument { get; }

	// Methods

	// RVA: 0x1E79ED4 Offset: 0x1E75ED4 VA: 0x1E79ED4
	public Object get_unityObjectArgument() { }

	// RVA: 0x1E79EDC Offset: 0x1E75EDC VA: 0x1E79EDC
	public string get_unityObjectArgumentAssemblyTypeName() { }

	// RVA: 0x1E79EE4 Offset: 0x1E75EE4 VA: 0x1E79EE4
	public int get_intArgument() { }

	// RVA: 0x1E79EEC Offset: 0x1E75EEC VA: 0x1E79EEC
	public float get_floatArgument() { }

	// RVA: 0x1E79EF4 Offset: 0x1E75EF4 VA: 0x1E79EF4
	public string get_stringArgument() { }

	// RVA: 0x1E79EFC Offset: 0x1E75EFC VA: 0x1E79EFC
	public bool get_boolArgument() { }

	// RVA: 0x1E79F04 Offset: 0x1E75F04 VA: 0x1E79F04 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x1E79F28 Offset: 0x1E75F28 VA: 0x1E79F28 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x1E79F4C Offset: 0x1E75F4C VA: 0x1E79F4C
	public void .ctor() { }
}

// Namespace: UnityEngine.Events
internal abstract class BaseInvokableCall // TypeDefIndex: 6887
{
	// Methods

	// RVA: 0x1E79F54 Offset: 0x1E75F54 VA: 0x1E79F54
	protected void .ctor() { }

	// RVA: 0x1E79F5C Offset: 0x1E75F5C VA: 0x1E79F5C
	protected void .ctor(object target, MethodInfo function) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Invoke(object[] args);

	// RVA: -1 Offset: -1
	protected static void ThrowOnInvalidArg<T>(object arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10EC6C0 Offset: 0x10E86C0 VA: 0x10EC6C0
	|-BaseInvokableCall.ThrowOnInvalidArg<bool>
	|
	|-RVA: 0x10EC804 Offset: 0x10E8804 VA: 0x10EC804
	|-BaseInvokableCall.ThrowOnInvalidArg<Color>
	|
	|-RVA: 0x10EC948 Offset: 0x10E8948 VA: 0x10EC948
	|-BaseInvokableCall.ThrowOnInvalidArg<int>
	|
	|-RVA: 0x10ECA8C Offset: 0x10E8A8C VA: 0x10ECA8C
	|-BaseInvokableCall.ThrowOnInvalidArg<Int32Enum>
	|
	|-RVA: 0x10ECBD0 Offset: 0x10E8BD0 VA: 0x10ECBD0
	|-BaseInvokableCall.ThrowOnInvalidArg<object>
	|
	|-RVA: 0x10ECD14 Offset: 0x10E8D14 VA: 0x10ECD14
	|-BaseInvokableCall.ThrowOnInvalidArg<float>
	|
	|-RVA: 0x10ECE58 Offset: 0x10E8E58 VA: 0x10ECE58
	|-BaseInvokableCall.ThrowOnInvalidArg<Vector2>
	|
	|-RVA: 0x10ECF9C Offset: 0x10E8F9C VA: 0x10ECF9C
	|-BaseInvokableCall.ThrowOnInvalidArg<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1E7A050 Offset: 0x1E76050 VA: 0x1E7A050
	protected static bool AllowInvoke(Delegate delegate) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Find(object targetObj, MethodInfo method);
}

// Namespace: UnityEngine.Events
internal class InvokableCall : BaseInvokableCall // TypeDefIndex: 6888
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UnityAction Delegate; // 0x10

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E7A0F0 Offset: 0x1E760F0 VA: 0x1E7A0F0
	private void add_Delegate(UnityAction value) { }

	[CompilerGenerated]
	// RVA: 0x1E7A18C Offset: 0x1E7618C VA: 0x1E7A18C
	private void remove_Delegate(UnityAction value) { }

	// RVA: 0x1E7A228 Offset: 0x1E76228 VA: 0x1E7A228
	public void .ctor(object target, MethodInfo theFunction) { }

	// RVA: 0x1E7A2FC Offset: 0x1E762FC VA: 0x1E7A2FC
	public void .ctor(UnityAction action) { }

	// RVA: 0x1E7A328 Offset: 0x1E76328 VA: 0x1E7A328 Slot: 4
	public override void Invoke(object[] args) { }

	// RVA: 0x1E7A364 Offset: 0x1E76364 VA: 0x1E7A364
	public void Invoke() { }

	// RVA: 0x1E7A3A0 Offset: 0x1E763A0 VA: 0x1E7A3A0 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1> : BaseInvokableCall // TypeDefIndex: 6889
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UnityAction<T1> Delegate; // 0x0

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void add_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CC130 Offset: 0x12C8130 VA: 0x12CC130
	|-InvokableCall<bool>.add_Delegate
	|
	|-RVA: 0x12CC554 Offset: 0x12C8554 VA: 0x12CC554
	|-InvokableCall<Color>.add_Delegate
	|
	|-RVA: 0x12CC9A0 Offset: 0x12C89A0 VA: 0x12CC9A0
	|-InvokableCall<int>.add_Delegate
	|
	|-RVA: 0x12CCDC4 Offset: 0x12C8DC4 VA: 0x12CCDC4
	|-InvokableCall<Int32Enum>.add_Delegate
	|
	|-RVA: 0x12CD1E8 Offset: 0x12C91E8 VA: 0x12CD1E8
	|-InvokableCall<object>.add_Delegate
	|
	|-RVA: 0x12CD608 Offset: 0x12C9608 VA: 0x12CD608
	|-InvokableCall<float>.add_Delegate
	|
	|-RVA: 0x12CDA2C Offset: 0x12C9A2C VA: 0x12CDA2C
	|-InvokableCall<Vector2>.add_Delegate
	|
	|-RVA: 0x12CDE58 Offset: 0x12C9E58 VA: 0x12CDE58
	|-InvokableCall<__Il2CppFullySharedGenericType>.add_Delegate
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	protected void remove_Delegate(UnityAction<T1> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CC1E0 Offset: 0x12C81E0 VA: 0x12CC1E0
	|-InvokableCall<bool>.remove_Delegate
	|
	|-RVA: 0x12CC604 Offset: 0x12C8604 VA: 0x12CC604
	|-InvokableCall<Color>.remove_Delegate
	|
	|-RVA: 0x12CCA50 Offset: 0x12C8A50 VA: 0x12CCA50
	|-InvokableCall<int>.remove_Delegate
	|
	|-RVA: 0x12CCE74 Offset: 0x12C8E74 VA: 0x12CCE74
	|-InvokableCall<Int32Enum>.remove_Delegate
	|
	|-RVA: 0x12CD298 Offset: 0x12C9298 VA: 0x12CD298
	|-InvokableCall<object>.remove_Delegate
	|
	|-RVA: 0x12CD6B8 Offset: 0x12C96B8 VA: 0x12CD6B8
	|-InvokableCall<float>.remove_Delegate
	|
	|-RVA: 0x12CDADC Offset: 0x12C9ADC VA: 0x12CDADC
	|-InvokableCall<Vector2>.remove_Delegate
	|
	|-RVA: 0x12CDF08 Offset: 0x12C9F08 VA: 0x12CDF08
	|-InvokableCall<__Il2CppFullySharedGenericType>.remove_Delegate
	*/

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CC290 Offset: 0x12C8290 VA: 0x12CC290
	|-InvokableCall<bool>..ctor
	|
	|-RVA: 0x12CC6B4 Offset: 0x12C86B4 VA: 0x12CC6B4
	|-InvokableCall<Color>..ctor
	|
	|-RVA: 0x12CCB00 Offset: 0x12C8B00 VA: 0x12CCB00
	|-InvokableCall<int>..ctor
	|
	|-RVA: 0x12CCF24 Offset: 0x12C8F24 VA: 0x12CCF24
	|-InvokableCall<Int32Enum>..ctor
	|
	|-RVA: 0x12CD348 Offset: 0x12C9348 VA: 0x12CD348
	|-InvokableCall<object>..ctor
	|
	|-RVA: 0x12CD768 Offset: 0x12C9768 VA: 0x12CD768
	|-InvokableCall<float>..ctor
	|
	|-RVA: 0x12CDB8C Offset: 0x12C9B8C VA: 0x12CDB8C
	|-InvokableCall<Vector2>..ctor
	|
	|-RVA: 0x12CDFB8 Offset: 0x12C9FB8 VA: 0x12CDFB8
	|-InvokableCall<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(UnityAction<T1> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CC364 Offset: 0x12C8364 VA: 0x12CC364
	|-InvokableCall<bool>..ctor
	|
	|-RVA: 0x12CC788 Offset: 0x12C8788 VA: 0x12CC788
	|-InvokableCall<Color>..ctor
	|
	|-RVA: 0x12CCBD4 Offset: 0x12C8BD4 VA: 0x12CCBD4
	|-InvokableCall<int>..ctor
	|
	|-RVA: 0x12CCFF8 Offset: 0x12C8FF8 VA: 0x12CCFF8
	|-InvokableCall<Int32Enum>..ctor
	|
	|-RVA: 0x12CD41C Offset: 0x12C941C VA: 0x12CD41C
	|-InvokableCall<object>..ctor
	|
	|-RVA: 0x12CD83C Offset: 0x12C983C VA: 0x12CD83C
	|-InvokableCall<float>..ctor
	|
	|-RVA: 0x12CDC60 Offset: 0x12C9C60 VA: 0x12CDC60
	|-InvokableCall<Vector2>..ctor
	|
	|-RVA: 0x12CE0A4 Offset: 0x12CA0A4 VA: 0x12CE0A4
	|-InvokableCall<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CC3A0 Offset: 0x12C83A0 VA: 0x12CC3A0
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x12CC7C4 Offset: 0x12C87C4 VA: 0x12CC7C4
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x12CCC10 Offset: 0x12C8C10 VA: 0x12CCC10
	|-InvokableCall<int>.Invoke
	|
	|-RVA: 0x12CD034 Offset: 0x12C9034 VA: 0x12CD034
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x12CD458 Offset: 0x12C9458 VA: 0x12CD458
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x12CD878 Offset: 0x12C9878 VA: 0x12CD878
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x12CDC9C Offset: 0x12C9C9C VA: 0x12CDC9C
	|-InvokableCall<Vector2>.Invoke
	|
	|-RVA: 0x12CE0E4 Offset: 0x12CA0E4 VA: 0x12CE0E4
	|-InvokableCall<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public virtual void Invoke(T1 args0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CC4B4 Offset: 0x12C84B4 VA: 0x12CC4B4
	|-InvokableCall<bool>.Invoke
	|
	|-RVA: 0x12CC8DC Offset: 0x12C88DC VA: 0x12CC8DC
	|-InvokableCall<Color>.Invoke
	|
	|-RVA: 0x12CCD24 Offset: 0x12C8D24 VA: 0x12CCD24
	|-InvokableCall<int>.Invoke
	|
	|-RVA: 0x12CD148 Offset: 0x12C9148 VA: 0x12CD148
	|-InvokableCall<Int32Enum>.Invoke
	|
	|-RVA: 0x12CD568 Offset: 0x12C9568 VA: 0x12CD568
	|-InvokableCall<object>.Invoke
	|
	|-RVA: 0x12CD98C Offset: 0x12C998C VA: 0x12CD98C
	|-InvokableCall<float>.Invoke
	|
	|-RVA: 0x12CDDB0 Offset: 0x12C9DB0 VA: 0x12CDDB0
	|-InvokableCall<Vector2>.Invoke
	|
	|-RVA: 0x12CE280 Offset: 0x12CA280 VA: 0x12CE280
	|-InvokableCall<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CC508 Offset: 0x12C8508 VA: 0x12CC508
	|-InvokableCall<bool>.Find
	|
	|-RVA: 0x12CC954 Offset: 0x12C8954 VA: 0x12CC954
	|-InvokableCall<Color>.Find
	|
	|-RVA: 0x12CCD78 Offset: 0x12C8D78 VA: 0x12CCD78
	|-InvokableCall<int>.Find
	|
	|-RVA: 0x12CD19C Offset: 0x12C919C VA: 0x12CD19C
	|-InvokableCall<Int32Enum>.Find
	|
	|-RVA: 0x12CD5BC Offset: 0x12C95BC VA: 0x12CD5BC
	|-InvokableCall<object>.Find
	|
	|-RVA: 0x12CD9E0 Offset: 0x12C99E0 VA: 0x12CD9E0
	|-InvokableCall<float>.Find
	|
	|-RVA: 0x12CDE0C Offset: 0x12C9E0C VA: 0x12CDE0C
	|-InvokableCall<Vector2>.Find
	|
	|-RVA: 0x12CE388 Offset: 0x12CA388 VA: 0x12CE388
	|-InvokableCall<__Il2CppFullySharedGenericType>.Find
	*/
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1, T2> : BaseInvokableCall // TypeDefIndex: 6890
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UnityAction<T1, T2> Delegate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CE3D4 Offset: 0x12CA3D4 VA: 0x12CE3D4
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CE4E8 Offset: 0x12CA4E8 VA: 0x12CE4E8
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CE724 Offset: 0x12CA724 VA: 0x12CE724
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Find
	*/
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1, T2, T3> : BaseInvokableCall // TypeDefIndex: 6891
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private UnityAction<T1, T2, T3> Delegate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CE770 Offset: 0x12CA770 VA: 0x12CE770
	|-InvokableCall<object, int, int>..ctor
	|
	|-RVA: 0x12CEB5C Offset: 0x12CAB5C VA: 0x12CEB5C
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CE884 Offset: 0x12CA884 VA: 0x12CE884
	|-InvokableCall<object, int, int>.Invoke
	|
	|-RVA: 0x12CEC70 Offset: 0x12CAC70 VA: 0x12CEC70
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T1 args0, T2 args1, T3 args2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CEAA0 Offset: 0x12CAAA0 VA: 0x12CEAA0
	|-InvokableCall<object, int, int>.Invoke
	|
	|-RVA: 0x12CEF44 Offset: 0x12CAF44 VA: 0x12CEF44
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CEB10 Offset: 0x12CAB10 VA: 0x12CEB10
	|-InvokableCall<object, int, int>.Find
	|
	|-RVA: 0x12CF100 Offset: 0x12CB100 VA: 0x12CF100
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Find
	*/
}

// Namespace: UnityEngine.Events
internal class InvokableCall<T1, T2, T3, T4> : BaseInvokableCall // TypeDefIndex: 6892
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private UnityAction<T1, T2, T3, T4> Delegate; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CF14C Offset: 0x12CB14C VA: 0x12CF14C
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CF260 Offset: 0x12CB260 VA: 0x12CF260
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public override bool Find(object targetObj, MethodInfo method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12CF5D0 Offset: 0x12CB5D0 VA: 0x12CF5D0
	|-InvokableCall<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Find
	*/
}

// Namespace: UnityEngine.Events
internal class CachedInvokableCall<T> : InvokableCall<T> // TypeDefIndex: 6893
{
	// Fields
	private readonly T m_Arg1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Object target, MethodInfo theFunction, T argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DF350 Offset: 0x14DB350 VA: 0x14DF350
	|-CachedInvokableCall<bool>..ctor
	|
	|-RVA: 0x14DF3A8 Offset: 0x14DB3A8 VA: 0x14DF3A8
	|-CachedInvokableCall<int>..ctor
	|
	|-RVA: 0x14DF400 Offset: 0x14DB400 VA: 0x14DF400
	|-CachedInvokableCall<object>..ctor
	|
	|-RVA: 0x14DF460 Offset: 0x14DB460 VA: 0x14DF460
	|-CachedInvokableCall<float>..ctor
	|
	|-RVA: 0x14DF4B8 Offset: 0x14DB4B8 VA: 0x14DF4B8
	|-CachedInvokableCall<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DF380 Offset: 0x14DB380 VA: 0x14DF380
	|-CachedInvokableCall<bool>.Invoke
	|
	|-RVA: 0x14DF3D8 Offset: 0x14DB3D8 VA: 0x14DF3D8
	|-CachedInvokableCall<int>.Invoke
	|
	|-RVA: 0x14DF438 Offset: 0x14DB438 VA: 0x14DF438
	|-CachedInvokableCall<object>.Invoke
	|
	|-RVA: 0x14DF490 Offset: 0x14DB490 VA: 0x14DF490
	|-CachedInvokableCall<float>.Invoke
	|
	|-RVA: 0x14DF588 Offset: 0x14DB588 VA: 0x14DF588
	|-CachedInvokableCall<__Il2CppFullySharedGenericType>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void Invoke(T arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14DF394 Offset: 0x14DB394 VA: 0x14DF394
	|-CachedInvokableCall<bool>.Invoke
	|
	|-RVA: 0x14DF3EC Offset: 0x14DB3EC VA: 0x14DF3EC
	|-CachedInvokableCall<int>.Invoke
	|
	|-RVA: 0x14DF44C Offset: 0x14DB44C VA: 0x14DF44C
	|-CachedInvokableCall<object>.Invoke
	|
	|-RVA: 0x14DF4A4 Offset: 0x14DB4A4 VA: 0x14DF4A4
	|-CachedInvokableCall<float>.Invoke
	|
	|-RVA: 0x14DF66C Offset: 0x14DB66C VA: 0x14DF66C
	|-CachedInvokableCall<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
public enum UnityEventCallState // TypeDefIndex: 6894
{
	// Fields
	public int value__; // 0x0
	public const UnityEventCallState Off = 0;
	public const UnityEventCallState EditorAndRuntime = 1;
	public const UnityEventCallState RuntimeOnly = 2;
}

// Namespace: UnityEngine.Events
[Serializable]
internal class PersistentCall : ISerializationCallbackReceiver // TypeDefIndex: 6895
{
	// Fields
	[SerializeField]
	[FormerlySerializedAs("instance")]
	private Object m_Target; // 0x10
	[SerializeField]
	private string m_TargetAssemblyTypeName; // 0x18
	[FormerlySerializedAs("methodName")]
	[SerializeField]
	private string m_MethodName; // 0x20
	[SerializeField]
	[FormerlySerializedAs("mode")]
	private PersistentListenerMode m_Mode; // 0x28
	[SerializeField]
	[FormerlySerializedAs("arguments")]
	private ArgumentCache m_Arguments; // 0x30
	[SerializeField]
	[FormerlySerializedAs("m_Enabled")]
	[FormerlySerializedAs("enabled")]
	private UnityEventCallState m_CallState; // 0x38

	// Properties
	public Object target { get; }
	public string targetAssemblyTypeName { get; }
	public string methodName { get; }
	public PersistentListenerMode mode { get; }
	public ArgumentCache arguments { get; }

	// Methods

	// RVA: 0x1E7A3EC Offset: 0x1E763EC VA: 0x1E7A3EC
	public Object get_target() { }

	// RVA: 0x1E7A3F4 Offset: 0x1E763F4 VA: 0x1E7A3F4
	public string get_targetAssemblyTypeName() { }

	// RVA: 0x1E7A4AC Offset: 0x1E764AC VA: 0x1E7A4AC
	public string get_methodName() { }

	// RVA: 0x1E7A4B4 Offset: 0x1E764B4 VA: 0x1E7A4B4
	public PersistentListenerMode get_mode() { }

	// RVA: 0x1E7A4BC Offset: 0x1E764BC VA: 0x1E7A4BC
	public ArgumentCache get_arguments() { }

	// RVA: 0x1E7A4C4 Offset: 0x1E764C4 VA: 0x1E7A4C4
	public bool IsValid() { }

	// RVA: 0x1E7A500 Offset: 0x1E76500 VA: 0x1E7A500
	public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent) { }

	// RVA: 0x1E7A9C8 Offset: 0x1E769C8 VA: 0x1E7A9C8
	private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments) { }

	// RVA: 0x1E7AE3C Offset: 0x1E76E3C VA: 0x1E7AE3C Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x1E7AE60 Offset: 0x1E76E60 VA: 0x1E7AE60 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x1E7AE84 Offset: 0x1E76E84 VA: 0x1E7AE84
	public void .ctor() { }
}

// Namespace: UnityEngine.Events
[Serializable]
internal class PersistentCallGroup // TypeDefIndex: 6896
{
	// Fields
	[FormerlySerializedAs("m_Listeners")]
	[SerializeField]
	private List<PersistentCall> m_Calls; // 0x10

	// Methods

	// RVA: 0x1E7AEFC Offset: 0x1E76EFC VA: 0x1E7AEFC
	public void .ctor() { }

	// RVA: 0x1E7AF84 Offset: 0x1E76F84 VA: 0x1E7AF84
	public void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase) { }
}

// Namespace: UnityEngine.Events
internal class InvokableCallList // TypeDefIndex: 6897
{
	// Fields
	private readonly List<BaseInvokableCall> m_PersistentCalls; // 0x10
	private readonly List<BaseInvokableCall> m_RuntimeCalls; // 0x18
	private List<BaseInvokableCall> m_ExecutingCalls; // 0x20
	private bool m_NeedsUpdate; // 0x28

	// Methods

	// RVA: 0x1E7B0F8 Offset: 0x1E770F8 VA: 0x1E7B0F8
	public void AddPersistentInvokableCall(BaseInvokableCall call) { }

	// RVA: 0x1E7B1AC Offset: 0x1E771AC VA: 0x1E7B1AC
	public void AddListener(BaseInvokableCall call) { }

	// RVA: 0x1E7B260 Offset: 0x1E77260 VA: 0x1E7B260
	public void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x1E7B4DC Offset: 0x1E774DC VA: 0x1E7B4DC
	public void Clear() { }

	// RVA: 0x1E7B5A4 Offset: 0x1E775A4 VA: 0x1E7B5A4
	public void ClearPersistent() { }

	// RVA: 0x1E7B66C Offset: 0x1E7766C VA: 0x1E7B66C
	public List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x1E7B720 Offset: 0x1E77720 VA: 0x1E7B720
	public void .ctor() { }
}

// Namespace: UnityEngine.Events
[UsedByNativeCode]
[Serializable]
public abstract class UnityEventBase : ISerializationCallbackReceiver // TypeDefIndex: 6898
{
	// Fields
	private InvokableCallList m_Calls; // 0x10
	[FormerlySerializedAs("m_PersistentListeners")]
	[SerializeField]
	private PersistentCallGroup m_PersistentCalls; // 0x18
	private bool m_CallsDirty; // 0x20

	// Methods

	// RVA: 0x1E7B7F8 Offset: 0x1E777F8 VA: 0x1E7B7F8
	protected void .ctor() { }

	// RVA: 0x1E7B8A4 Offset: 0x1E778A4 VA: 0x1E7B8A4 Slot: 4
	private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	// RVA: 0x1E7B8D0 Offset: 0x1E778D0 VA: 0x1E7B8D0 Slot: 5
	private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract MethodInfo FindMethod_Impl(string name, Type targetObjType);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract BaseInvokableCall GetDelegate(object target, MethodInfo theFunction);

	// RVA: 0x1E7A808 Offset: 0x1E76808 VA: 0x1E7A808
	internal MethodInfo FindMethod(PersistentCall call) { }

	// RVA: 0x1E7B8D4 Offset: 0x1E778D4 VA: 0x1E7B8D4
	internal MethodInfo FindMethod(string name, Type listenerType, PersistentListenerMode mode, Type argumentType) { }

	// RVA: 0x1E7B8A8 Offset: 0x1E778A8 VA: 0x1E7B8A8
	private void DirtyPersistentCalls() { }

	// RVA: 0x1E7BD38 Offset: 0x1E77D38 VA: 0x1E7BD38
	private void RebuildPersistentCallsIfNeeded() { }

	// RVA: 0x1E7BD6C Offset: 0x1E77D6C VA: 0x1E7BD6C
	internal void AddCall(BaseInvokableCall call) { }

	// RVA: 0x1E7BD80 Offset: 0x1E77D80 VA: 0x1E7BD80
	protected void RemoveListener(object targetObj, MethodInfo method) { }

	// RVA: 0x1E7BD94 Offset: 0x1E77D94 VA: 0x1E7BD94
	public void RemoveAllListeners() { }

	// RVA: 0x1E7BDA8 Offset: 0x1E77DA8 VA: 0x1E7BDA8
	internal List<BaseInvokableCall> PrepareInvoke() { }

	// RVA: 0x1E7BDC8 Offset: 0x1E77DC8 VA: 0x1E7BDC8 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E7BB88 Offset: 0x1E77B88 VA: 0x1E7BB88
	public static MethodInfo GetValidMethodInfo(Type objectType, string functionName, Type[] argumentTypes) { }
}

// Namespace: UnityEngine.Events
public sealed class UnityAction : MulticastDelegate // TypeDefIndex: 6899
{
	// Methods

	// RVA: 0x1E7BE4C Offset: 0x1E77E4C VA: 0x1E7BE4C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1E7BEE8 Offset: 0x1E77EE8 VA: 0x1E7BEE8 Slot: 12
	public virtual void Invoke() { }
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent : UnityEventBase // TypeDefIndex: 6900
{
	// Fields
	private object[] m_InvokeArray; // 0x28

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x1E7BEFC Offset: 0x1E77EFC VA: 0x1E7BEFC
	public void .ctor() { }

	// RVA: 0x1E7BF1C Offset: 0x1E77F1C VA: 0x1E7BF1C
	public void AddListener(UnityAction call) { }

	// RVA: 0x1E7BFAC Offset: 0x1E77FAC VA: 0x1E7BFAC Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }

	// RVA: 0x1E7C010 Offset: 0x1E78010 VA: 0x1E7C010 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }

	// RVA: 0x1E7BF48 Offset: 0x1E77F48 VA: 0x1E7BF48
	private static BaseInvokableCall GetDelegate(UnityAction action) { }

	// RVA: 0x1E7C078 Offset: 0x1E78078 VA: 0x1E7C078
	public void Invoke() { }
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0> : MulticastDelegate // TypeDefIndex: 6901
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1494650 Offset: 0x1490650 VA: 0x1494650
	|-UnityAction<bool>..ctor
	|
	|-RVA: 0x1494704 Offset: 0x1490704 VA: 0x1494704
	|-UnityAction<Color>..ctor
	|
	|-RVA: 0x14947B8 Offset: 0x14907B8 VA: 0x14947B8
	|-UnityAction<int>..ctor
	|
	|-RVA: 0x149486C Offset: 0x149086C VA: 0x149486C
	|-UnityAction<Int32Enum>..ctor
	|
	|-RVA: 0x1494920 Offset: 0x1490920 VA: 0x1494920
	|-UnityAction<object>..ctor
	|
	|-RVA: 0x1494A3C Offset: 0x1490A3C VA: 0x1494A3C
	|-UnityAction<Scene>..ctor
	|
	|-RVA: 0x1494AF4 Offset: 0x1490AF4 VA: 0x1494AF4
	|-UnityAction<float>..ctor
	|
	|-RVA: 0x1494BA8 Offset: 0x1490BA8 VA: 0x1494BA8
	|-UnityAction<Vector2>..ctor
	|
	|-RVA: 0x1494C5C Offset: 0x1490C5C VA: 0x1494C5C
	|-UnityAction<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14946F0 Offset: 0x14906F0 VA: 0x14946F0
	|-UnityAction<bool>.Invoke
	|
	|-RVA: 0x14947A4 Offset: 0x14907A4 VA: 0x14947A4
	|-UnityAction<Color>.Invoke
	|
	|-RVA: 0x1494858 Offset: 0x1490858 VA: 0x1494858
	|-UnityAction<int>.Invoke
	|
	|-RVA: 0x149490C Offset: 0x149090C VA: 0x149490C
	|-UnityAction<Int32Enum>.Invoke
	|
	|-RVA: 0x1494A28 Offset: 0x1490A28 VA: 0x1494A28
	|-UnityAction<object>.Invoke
	|
	|-RVA: 0x1494ADC Offset: 0x1490ADC VA: 0x1494ADC
	|-UnityAction<Scene>.Invoke
	|
	|-RVA: 0x1494B94 Offset: 0x1490B94 VA: 0x1494B94
	|-UnityAction<float>.Invoke
	|
	|-RVA: 0x1494C48 Offset: 0x1490C48 VA: 0x1494C48
	|-UnityAction<Vector2>.Invoke
	|
	|-RVA: 0x1494D68 Offset: 0x1490D68 VA: 0x1494D68
	|-UnityAction<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0> : UnityEventBase // TypeDefIndex: 6902
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x149537C Offset: 0x149137C VA: 0x149537C
	|-UnityEvent<bool>..ctor
	|
	|-RVA: 0x1495864 Offset: 0x1491864 VA: 0x1495864
	|-UnityEvent<Color>..ctor
	|
	|-RVA: 0x1495D6C Offset: 0x1491D6C VA: 0x1495D6C
	|-UnityEvent<int>..ctor
	|
	|-RVA: 0x1496248 Offset: 0x1492248 VA: 0x1496248
	|-UnityEvent<Int32Enum>..ctor
	|
	|-RVA: 0x1496724 Offset: 0x1492724 VA: 0x1496724
	|-UnityEvent<object>..ctor
	|
	|-RVA: 0x1496BDC Offset: 0x1492BDC VA: 0x1496BDC
	|-UnityEvent<float>..ctor
	|
	|-RVA: 0x14970C0 Offset: 0x14930C0 VA: 0x14970C0
	|-UnityEvent<Vector2>..ctor
	|
	|-RVA: 0x14975A4 Offset: 0x14935A4 VA: 0x14975A4
	|-UnityEvent<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void AddListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14953A0 Offset: 0x14913A0 VA: 0x14953A0
	|-UnityEvent<bool>.AddListener
	|
	|-RVA: 0x1495888 Offset: 0x1491888 VA: 0x1495888
	|-UnityEvent<Color>.AddListener
	|
	|-RVA: 0x1495D90 Offset: 0x1491D90 VA: 0x1495D90
	|-UnityEvent<int>.AddListener
	|
	|-RVA: 0x149626C Offset: 0x149226C VA: 0x149626C
	|-UnityEvent<Int32Enum>.AddListener
	|
	|-RVA: 0x1496748 Offset: 0x1492748 VA: 0x1496748
	|-UnityEvent<object>.AddListener
	|
	|-RVA: 0x1496C00 Offset: 0x1492C00 VA: 0x1496C00
	|-UnityEvent<float>.AddListener
	|
	|-RVA: 0x14970E4 Offset: 0x14930E4 VA: 0x14970E4
	|-UnityEvent<Vector2>.AddListener
	|
	|-RVA: 0x14975C8 Offset: 0x14935C8 VA: 0x14975C8
	|-UnityEvent<__Il2CppFullySharedGenericType>.AddListener
	*/

	// RVA: -1 Offset: -1
	public void RemoveListener(UnityAction<T0> call) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14953DC Offset: 0x14913DC VA: 0x14953DC
	|-UnityEvent<bool>.RemoveListener
	|
	|-RVA: 0x14958C4 Offset: 0x14918C4 VA: 0x14958C4
	|-UnityEvent<Color>.RemoveListener
	|
	|-RVA: 0x1495DCC Offset: 0x1491DCC VA: 0x1495DCC
	|-UnityEvent<int>.RemoveListener
	|
	|-RVA: 0x14962A8 Offset: 0x14922A8 VA: 0x14962A8
	|-UnityEvent<Int32Enum>.RemoveListener
	|
	|-RVA: 0x1496784 Offset: 0x1492784 VA: 0x1496784
	|-UnityEvent<object>.RemoveListener
	|
	|-RVA: 0x1496C3C Offset: 0x1492C3C VA: 0x1496C3C
	|-UnityEvent<float>.RemoveListener
	|
	|-RVA: 0x1497120 Offset: 0x1493120 VA: 0x1497120
	|-UnityEvent<Vector2>.RemoveListener
	|
	|-RVA: 0x1497608 Offset: 0x1493608 VA: 0x1497608
	|-UnityEvent<__Il2CppFullySharedGenericType>.RemoveListener
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1495420 Offset: 0x1491420 VA: 0x1495420
	|-UnityEvent<bool>.FindMethod_Impl
	|
	|-RVA: 0x1495908 Offset: 0x1491908 VA: 0x1495908
	|-UnityEvent<Color>.FindMethod_Impl
	|
	|-RVA: 0x1495E10 Offset: 0x1491E10 VA: 0x1495E10
	|-UnityEvent<int>.FindMethod_Impl
	|
	|-RVA: 0x14962EC Offset: 0x14922EC VA: 0x14962EC
	|-UnityEvent<Int32Enum>.FindMethod_Impl
	|
	|-RVA: 0x14967C8 Offset: 0x14927C8 VA: 0x14967C8
	|-UnityEvent<object>.FindMethod_Impl
	|
	|-RVA: 0x1496C80 Offset: 0x1492C80 VA: 0x1496C80
	|-UnityEvent<float>.FindMethod_Impl
	|
	|-RVA: 0x1497164 Offset: 0x1493164 VA: 0x1497164
	|-UnityEvent<Vector2>.FindMethod_Impl
	|
	|-RVA: 0x149764C Offset: 0x149364C VA: 0x149764C
	|-UnityEvent<__Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1495510 Offset: 0x1491510 VA: 0x1495510
	|-UnityEvent<bool>.GetDelegate
	|
	|-RVA: 0x14959F8 Offset: 0x14919F8 VA: 0x14959F8
	|-UnityEvent<Color>.GetDelegate
	|
	|-RVA: 0x1495F00 Offset: 0x1491F00 VA: 0x1495F00
	|-UnityEvent<int>.GetDelegate
	|
	|-RVA: 0x14963DC Offset: 0x14923DC VA: 0x14963DC
	|-UnityEvent<Int32Enum>.GetDelegate
	|
	|-RVA: 0x14968B8 Offset: 0x14928B8 VA: 0x14968B8
	|-UnityEvent<object>.GetDelegate
	|
	|-RVA: 0x1496D70 Offset: 0x1492D70 VA: 0x1496D70
	|-UnityEvent<float>.GetDelegate
	|
	|-RVA: 0x1497254 Offset: 0x1493254 VA: 0x1497254
	|-UnityEvent<Vector2>.GetDelegate
	|
	|-RVA: 0x149773C Offset: 0x149373C VA: 0x149773C
	|-UnityEvent<__Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	private static BaseInvokableCall GetDelegate(UnityAction<T0> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1495570 Offset: 0x1491570 VA: 0x1495570
	|-UnityEvent<bool>.GetDelegate
	|
	|-RVA: 0x1495A58 Offset: 0x1491A58 VA: 0x1495A58
	|-UnityEvent<Color>.GetDelegate
	|
	|-RVA: 0x1495F60 Offset: 0x1491F60 VA: 0x1495F60
	|-UnityEvent<int>.GetDelegate
	|
	|-RVA: 0x149643C Offset: 0x149243C VA: 0x149643C
	|-UnityEvent<Int32Enum>.GetDelegate
	|
	|-RVA: 0x1496918 Offset: 0x1492918 VA: 0x1496918
	|-UnityEvent<object>.GetDelegate
	|
	|-RVA: 0x1496DD0 Offset: 0x1492DD0 VA: 0x1496DD0
	|-UnityEvent<float>.GetDelegate
	|
	|-RVA: 0x14972B4 Offset: 0x14932B4 VA: 0x14972B4
	|-UnityEvent<Vector2>.GetDelegate
	|
	|-RVA: 0x14977A0 Offset: 0x14937A0 VA: 0x14977A0
	|-UnityEvent<__Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14955FC Offset: 0x14915FC VA: 0x14955FC
	|-UnityEvent<bool>.Invoke
	|
	|-RVA: 0x1495AE4 Offset: 0x1491AE4 VA: 0x1495AE4
	|-UnityEvent<Color>.Invoke
	|
	|-RVA: 0x1495FEC Offset: 0x1491FEC VA: 0x1495FEC
	|-UnityEvent<int>.Invoke
	|
	|-RVA: 0x14964C8 Offset: 0x14924C8 VA: 0x14964C8
	|-UnityEvent<Int32Enum>.Invoke
	|
	|-RVA: 0x14969A4 Offset: 0x14929A4 VA: 0x14969A4
	|-UnityEvent<object>.Invoke
	|
	|-RVA: 0x1496E5C Offset: 0x1492E5C VA: 0x1496E5C
	|-UnityEvent<float>.Invoke
	|
	|-RVA: 0x1497340 Offset: 0x1493340 VA: 0x1497340
	|-UnityEvent<Vector2>.Invoke
	|
	|-RVA: 0x1497858 Offset: 0x1493858 VA: 0x1497858
	|-UnityEvent<__Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1> : MulticastDelegate // TypeDefIndex: 6903
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1494D7C Offset: 0x1490D7C VA: 0x1494D7C
	|-UnityAction<Scene, Int32Enum>..ctor
	|
	|-RVA: 0x1494E34 Offset: 0x1490E34 VA: 0x1494E34
	|-UnityAction<Scene, Scene>..ctor
	|
	|-RVA: 0x1494EF0 Offset: 0x1490EF0 VA: 0x1494EF0
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1494E1C Offset: 0x1490E1C VA: 0x1494E1C
	|-UnityAction<Scene, Int32Enum>.Invoke
	|
	|-RVA: 0x1494ED4 Offset: 0x1490ED4 VA: 0x1494ED4
	|-UnityAction<Scene, Scene>.Invoke
	|
	|-RVA: 0x1495000 Offset: 0x1491000 VA: 0x1495000
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1> : UnityEventBase // TypeDefIndex: 6904
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1497BBC Offset: 0x1493BBC VA: 0x1497BBC
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1497BE0 Offset: 0x1493BE0 VA: 0x1497BE0
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1497D1C Offset: 0x1493D1C VA: 0x1497D1C
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2> : MulticastDelegate // TypeDefIndex: 6905
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1495014 Offset: 0x1491014 VA: 0x1495014
	|-UnityAction<object, int, int>..ctor
	|
	|-RVA: 0x1495134 Offset: 0x1491134 VA: 0x1495134
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1495120 Offset: 0x1491120 VA: 0x1495120
	|-UnityAction<object, int, int>.Invoke
	|
	|-RVA: 0x1495244 Offset: 0x1491244 VA: 0x1495244
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1, T2> : UnityEventBase // TypeDefIndex: 6906
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1497D80 Offset: 0x1493D80 VA: 0x1497D80
	|-UnityEvent<object, int, int>..ctor
	|
	|-RVA: 0x1498294 Offset: 0x1494294 VA: 0x1498294
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1497DA4 Offset: 0x1493DA4 VA: 0x1497DA4
	|-UnityEvent<object, int, int>.FindMethod_Impl
	|
	|-RVA: 0x14982B8 Offset: 0x14942B8 VA: 0x14982B8
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1497F2C Offset: 0x1493F2C VA: 0x1497F2C
	|-UnityEvent<object, int, int>.GetDelegate
	|
	|-RVA: 0x1498440 Offset: 0x1494440 VA: 0x1498440
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/

	// RVA: -1 Offset: -1
	public void Invoke(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1497F8C Offset: 0x1493F8C VA: 0x1497F8C
	|-UnityEvent<object, int, int>.Invoke
	|
	|-RVA: 0x14984A4 Offset: 0x14944A4 VA: 0x14984A4
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
public sealed class UnityAction<T0, T1, T2, T3> : MulticastDelegate // TypeDefIndex: 6907
{
	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(object object, IntPtr method) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1495258 Offset: 0x1491258 VA: 0x1495258
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public virtual void Invoke(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1495368 Offset: 0x1491368 VA: 0x1495368
	|-UnityAction<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Invoke
	*/
}

// Namespace: UnityEngine.Events
[Serializable]
public class UnityEvent<T0, T1, T2, T3> : UnityEventBase // TypeDefIndex: 6908
{
	// Fields
	private object[] m_InvokeArray; // 0x0

	// Methods

	[RequiredByNativeCode]
	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14989D4 Offset: 0x14949D4 VA: 0x14989D4
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14989F8 Offset: 0x14949F8 VA: 0x14989F8
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.FindMethod_Impl
	*/

	// RVA: -1 Offset: -1 Slot: 7
	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1498BCC Offset: 0x1494BCC VA: 0x1498BCC
	|-UnityEvent<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetDelegate
	*/
}
