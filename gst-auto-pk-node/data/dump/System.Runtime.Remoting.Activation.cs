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

// Namespace: System.Runtime.Remoting.Activation
internal class ActivationServices // TypeDefIndex: 872
{
	// Fields
	private static IActivator _constructionActivator; // 0x0

	// Properties
	private static IActivator ConstructionActivator { get; }

	// Methods

	// RVA: 0x179CF2C Offset: 0x1798F2C VA: 0x179CF2C
	private static IActivator get_ConstructionActivator() { }

	// RVA: 0x1795C70 Offset: 0x1791C70 VA: 0x1795C70
	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	// RVA: 0x179CFD0 Offset: 0x1798FD0 VA: 0x179CFD0
	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

	// RVA: 0x179481C Offset: 0x179081C VA: 0x179481C
	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x179D214 Offset: 0x1799214 VA: 0x179D214
	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	// RVA: 0x179D3C4 Offset: 0x17993C4 VA: 0x179D3C4
	public static object CreateProxyForType(Type type) { }

	// RVA: 0x179D3C0 Offset: 0x17993C0 VA: 0x179D3C0
	public static object AllocateUninitializedClassInstance(Type type) { }

	// RVA: 0x1783BA0 Offset: 0x177FBA0 VA: 0x1783BA0
	public static void EnableProxyActivation(Type type, bool enable) { }
}

// Namespace: System.Runtime.Remoting.Activation
internal class AppDomainLevelActivator : IActivator // TypeDefIndex: 873
{
	// Fields
	private string _activationUrl; // 0x10
	private IActivator _next; // 0x18

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x179D1A0 Offset: 0x17991A0 VA: 0x179D1A0
	public void .ctor(string activationUrl, IActivator next) { }

	// RVA: 0x179D4F0 Offset: 0x17994F0 VA: 0x179D4F0 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x179D4F8 Offset: 0x17994F8 VA: 0x179D4F8 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }
}

// Namespace: System.Runtime.Remoting.Activation
[Serializable]
internal class ConstructionLevelActivator : IActivator // TypeDefIndex: 874
{
	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x179D9A8 Offset: 0x17999A8 VA: 0x179D9A8 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x179D9B0 Offset: 0x17999B0 VA: 0x179D9B0 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	// RVA: 0x179CFC8 Offset: 0x1798FC8 VA: 0x179CFC8
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Activation
[Serializable]
internal class ContextLevelActivator : IActivator // TypeDefIndex: 875
{
	// Fields
	private IActivator m_NextActivator; // 0x10

	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x179D1E4 Offset: 0x17991E4 VA: 0x179D1E4
	public void .ctor(IActivator next) { }

	// RVA: 0x179DAA0 Offset: 0x1799AA0 VA: 0x179DAA0 Slot: 4
	public IActivator get_NextActivator() { }

	// RVA: 0x179DAA8 Offset: 0x1799AA8 VA: 0x179DAA8 Slot: 5
	public IConstructionReturnMessage Activate(IConstructionCallMessage ctorCall) { }
}

// Namespace: System.Runtime.Remoting.Activation
[ComVisible(True)]
public interface IActivator // TypeDefIndex: 876
{
	// Properties
	public abstract IActivator NextActivator { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IActivator get_NextActivator();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IConstructionReturnMessage Activate(IConstructionCallMessage msg);
}

// Namespace: System.Runtime.Remoting.Activation
[ComVisible(True)]
public interface IConstructionCallMessage : IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 877
{
	// Properties
	public abstract Type ActivationType { get; }
	public abstract string ActivationTypeName { get; }
	public abstract IActivator Activator { get; set; }
	public abstract object[] CallSiteActivationAttributes { get; }
	public abstract IList ContextProperties { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Type get_ActivationType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_ActivationTypeName();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IActivator get_Activator();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Activator(IActivator value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract object[] get_CallSiteActivationAttributes();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IList get_ContextProperties();
}

// Namespace: System.Runtime.Remoting.Activation
[ComVisible(True)]
public interface IConstructionReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage // TypeDefIndex: 878
{}

// Namespace: System.Runtime.Remoting.Activation
internal class RemoteActivationAttribute : Attribute, IContextAttribute // TypeDefIndex: 879
{
	// Fields
	private IList _contextProperties; // 0x10

	// Methods

	// RVA: 0x179DDCC Offset: 0x1799DCC VA: 0x179DDCC
	public void .ctor(IList contextProperties) { }

	// RVA: 0x179DDFC Offset: 0x1799DFC VA: 0x179DDFC Slot: 8
	public bool IsContextOK(Context ctx, IConstructionCallMessage ctor) { }

	// RVA: 0x179DE04 Offset: 0x1799E04 VA: 0x179DE04 Slot: 7
	public void GetPropertiesForNewContext(IConstructionCallMessage ctor) { }
}

// Namespace: System.Runtime.Remoting.Activation
internal class RemoteActivator : MarshalByRefObject, IActivator // TypeDefIndex: 880
{
	// Properties
	public IActivator NextActivator { get; }

	// Methods

	// RVA: 0x179E1B4 Offset: 0x179A1B4 VA: 0x179E1B4 Slot: 7
	public IConstructionReturnMessage Activate(IConstructionCallMessage msg) { }

	// RVA: 0x179E64C Offset: 0x179A64C VA: 0x179E64C Slot: 6
	public IActivator get_NextActivator() { }
}
