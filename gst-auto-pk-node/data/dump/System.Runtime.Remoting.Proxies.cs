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

// Namespace: System.Runtime.Remoting.Proxies
[Usage(4)]
[ComVisible(True)]
public class ProxyAttribute : Attribute, IContextAttribute // TypeDefIndex: 829
{
	// Methods

	// RVA: 0x1792A9C Offset: 0x178EA9C VA: 0x1792A9C Slot: 9
	public virtual MarshalByRefObject CreateInstance(Type serverType) { }

	// RVA: 0x1792B90 Offset: 0x178EB90 VA: 0x1792B90 Slot: 10
	public virtual RealProxy CreateProxy(ObjRef objRef, Type serverType, object serverObject, Context serverContext) { }

	[ComVisible(True)]
	// RVA: 0x1792BEC Offset: 0x178EBEC VA: 0x1792BEC Slot: 7
	public void GetPropertiesForNewContext(IConstructionCallMessage msg) { }

	[ComVisible(True)]
	// RVA: 0x1792BF0 Offset: 0x178EBF0 VA: 0x1792BF0 Slot: 8
	public bool IsContextOK(Context ctx, IConstructionCallMessage msg) { }
}

// Namespace: System.Runtime.Remoting.Proxies
internal class TransparentProxy // TypeDefIndex: 830
{
	// Fields
	public RealProxy _rp; // 0x10
	private RuntimeRemoteClassHandle _class; // 0x18
	private bool _custom_type_info; // 0x20

	// Properties
	private bool IsContextBoundObject { get; }
	private Context TargetContext { get; }

	// Methods

	// RVA: 0x1792BF8 Offset: 0x178EBF8 VA: 0x1792BF8
	internal RuntimeType GetProxyType() { }

	// RVA: 0x1792CB8 Offset: 0x178ECB8 VA: 0x1792CB8
	private bool get_IsContextBoundObject() { }

	// RVA: 0x1792CD4 Offset: 0x178ECD4 VA: 0x1792CD4
	private Context get_TargetContext() { }

	// RVA: 0x1792CEC Offset: 0x178ECEC VA: 0x1792CEC
	private bool InCurrentContext() { }

	// RVA: 0x1792D2C Offset: 0x178ED2C VA: 0x1792D2C
	internal object LoadRemoteFieldNew(IntPtr classPtr, IntPtr fieldPtr) { }

	// RVA: 0x1793908 Offset: 0x178F908 VA: 0x1793908
	internal void StoreRemoteField(IntPtr classPtr, IntPtr fieldPtr, object arg) { }

	// RVA: 0x1793BE4 Offset: 0x178FBE4 VA: 0x1793BE4
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Proxies
[ComVisible(True)]
public abstract class RealProxy // TypeDefIndex: 831
{
	// Fields
	private Type class_to_proxy; // 0x10
	internal Context _targetContext; // 0x18
	internal MarshalByRefObject _server; // 0x20
	private int _targetDomainId; // 0x28
	internal string _targetUri; // 0x30
	internal Identity _objectIdentity; // 0x38
	private object _objTP; // 0x40
	private object _stubData; // 0x48

	// Properties
	internal Identity ObjectIdentity { get; set; }

	// Methods

	// RVA: 0x1793BEC Offset: 0x178FBEC VA: 0x1793BEC
	protected void .ctor() { }

	// RVA: 0x1793BFC Offset: 0x178FBFC VA: 0x1793BFC
	protected void .ctor(Type classToProxy) { }

	// RVA: 0x1793CEC Offset: 0x178FCEC VA: 0x1793CEC
	internal void .ctor(Type classToProxy, ClientIdentity identity) { }

	// RVA: 0x1793C04 Offset: 0x178FC04 VA: 0x1793C04
	protected void .ctor(Type classToProxy, IntPtr stub, object stubData) { }

	// RVA: 0x1793D1C Offset: 0x178FD1C VA: 0x1793D1C
	private static Type InternalGetProxyType(object transparentProxy) { }

	// RVA: 0x178D040 Offset: 0x1789040 VA: 0x178D040
	public Type GetProxiedType() { }

	// RVA: 0x1793D20 Offset: 0x178FD20 VA: 0x1793D20 Slot: 4
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1793D84 Offset: 0x178FD84 VA: 0x1793D84
	internal Identity get_ObjectIdentity() { }

	// RVA: 0x1793D8C Offset: 0x178FD8C VA: 0x1793D8C
	internal void set_ObjectIdentity(Identity value) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IMessage Invoke(IMessage msg);

	// RVA: 0x1792FF8 Offset: 0x178EFF8 VA: 0x1792FF8
	internal static object PrivateInvoke(RealProxy rp, IMessage msg, out Exception exc, out object[] out_args) { }

	// RVA: 0x1794568 Offset: 0x1790568 VA: 0x1794568 Slot: 6
	internal virtual object InternalGetTransparentProxy(string className) { }

	// RVA: 0x179456C Offset: 0x179056C VA: 0x179456C Slot: 7
	public virtual object GetTransparentProxy() { }

	// RVA: 0x17946E0 Offset: 0x17906E0 VA: 0x17946E0
	protected void AttachServer(MarshalByRefObject s) { }

	// RVA: 0x17946E8 Offset: 0x17906E8 VA: 0x17946E8
	internal void SetTargetDomain(int domainId) { }

	// RVA: 0x17946F0 Offset: 0x17906F0 VA: 0x17946F0
	internal object GetAppDomainTarget() { }

	// RVA: 0x1793E70 Offset: 0x178FE70 VA: 0x1793E70
	private static object[] ProcessResponse(IMethodReturnMessage mrm, MonoMethodMessage call) { }
}

// Namespace: System.Runtime.Remoting.Proxies
internal class RemotingProxy : RealProxy, IRemotingTypeInfo // TypeDefIndex: 832
{
	// Fields
	private static MethodInfo _cache_GetTypeMethod; // 0x0
	private static MethodInfo _cache_GetHashCodeMethod; // 0x8
	private IMessageSink _sink; // 0x50
	private bool _hasEnvoySink; // 0x58
	private ConstructionCall _ctorCall; // 0x60

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x178F094 Offset: 0x178B094 VA: 0x178F094
	internal void .ctor(Type type, ClientIdentity identity) { }

	// RVA: 0x178E5F4 Offset: 0x178A5F4 VA: 0x178E5F4
	internal void .ctor(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x1795160 Offset: 0x1791160 VA: 0x1795160 Slot: 5
	public override IMessage Invoke(IMessage request) { }

	// RVA: 0x17959E0 Offset: 0x17919E0 VA: 0x17959E0
	internal void AttachIdentity(Identity identity) { }

	// RVA: 0x1793D94 Offset: 0x178FD94 VA: 0x1793D94
	internal IMessage ActivateRemoteObject(IMethodMessage request) { }

	// RVA: 0x1795EA0 Offset: 0x1791EA0 VA: 0x1795EA0 Slot: 8
	public string get_TypeName() { }

	// RVA: 0x1795FD8 Offset: 0x1791FD8 VA: 0x1795FD8 Slot: 9
	public bool CanCastTo(Type fromType, object o) { }

	// RVA: 0x17961E4 Offset: 0x17921E4 VA: 0x17961E4 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17962F4 Offset: 0x17922F4 VA: 0x17962F4
	private static void .cctor() { }
}
