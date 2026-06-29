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

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[Serializable]
public sealed class CallContext // TypeDefIndex: 886
{
	// Methods

	// RVA: 0x179EC34 Offset: 0x179AC34 VA: 0x179EC34
	private void .ctor() { }

	// RVA: 0x179EC3C Offset: 0x179AC3C VA: 0x179EC3C
	internal static object SetCurrentCallContext(LogicalCallContext ctx) { }

	// RVA: 0x179EC44 Offset: 0x179AC44 VA: 0x179EC44
	internal static LogicalCallContext SetLogicalCallContext(LogicalCallContext callCtx) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class IllogicalCallContext // TypeDefIndex: 887
{
	// Fields
	private Hashtable m_Datastore; // 0x10
	private object m_HostContext; // 0x18

	// Properties
	private Hashtable Datastore { get; }
	internal object HostContext { get; set; }
	internal bool HasUserData { get; }

	// Methods

	// RVA: 0x179EC9C Offset: 0x179AC9C VA: 0x179EC9C
	private Hashtable get_Datastore() { }

	// RVA: 0x179ED0C Offset: 0x179AD0C VA: 0x179ED0C
	internal object get_HostContext() { }

	// RVA: 0x179ED14 Offset: 0x179AD14 VA: 0x179ED14
	internal void set_HostContext(object value) { }

	// RVA: 0x179ED1C Offset: 0x179AD1C VA: 0x179ED1C
	internal bool get_HasUserData() { }

	// RVA: 0x179ED48 Offset: 0x179AD48 VA: 0x179ED48
	public IllogicalCallContext CreateCopy() { }

	// RVA: 0x179EF98 Offset: 0x179AF98 VA: 0x179EF98
	public void .ctor() { }
}

// Namespace: 
internal struct LogicalCallContext.Reader // TypeDefIndex: 888
{
	// Fields
	private LogicalCallContext m_ctx; // 0x0

	// Properties
	public bool IsNull { get; }
	public bool HasInfo { get; }

	// Methods

	// RVA: 0x17A050C Offset: 0x179C50C VA: 0x17A050C
	public void .ctor(LogicalCallContext ctx) { }

	// RVA: 0x17A0514 Offset: 0x179C514 VA: 0x17A0514
	public bool get_IsNull() { }

	// RVA: 0x17A0524 Offset: 0x179C524 VA: 0x17A0524
	public bool get_HasInfo() { }

	// RVA: 0x17A0534 Offset: 0x179C534 VA: 0x17A0534
	public LogicalCallContext Clone() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[Serializable]
public sealed class LogicalCallContext : ISerializable, ICloneable // TypeDefIndex: 889
{
	// Fields
	private static Type s_callContextType; // 0x0
	private Hashtable m_Datastore; // 0x10
	private CallContextRemotingData m_RemotingData; // 0x18
	private CallContextSecurityData m_SecurityData; // 0x20
	private object m_HostContext; // 0x28
	private bool m_IsCorrelationMgr; // 0x30

	// Properties
	public bool HasInfo { get; }
	private bool HasUserData { get; }
	private Hashtable Datastore { get; }

	// Methods

	// RVA: 0x179EFA0 Offset: 0x179AFA0 VA: 0x179EFA0
	internal void .ctor() { }

	// RVA: 0x179EFA8 Offset: 0x179AFA8 VA: 0x179EFA8
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x179F4F4 Offset: 0x179B4F4 VA: 0x179F4F4 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x179FA9C Offset: 0x179BA9C VA: 0x179FA9C Slot: 5
	public object Clone() { }

	// RVA: 0x17A01D8 Offset: 0x179C1D8 VA: 0x17A01D8
	internal void Merge(LogicalCallContext lc) { }

	// RVA: 0x17A03FC Offset: 0x179C3FC VA: 0x17A03FC
	public bool get_HasInfo() { }

	// RVA: 0x179FA70 Offset: 0x179BA70 VA: 0x179FA70
	private bool get_HasUserData() { }

	// RVA: 0x179F450 Offset: 0x179B450 VA: 0x179F450
	private Hashtable get_Datastore() { }

	// RVA: 0x17A047C Offset: 0x179C47C VA: 0x17A047C
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class CallContextSecurityData : ICloneable // TypeDefIndex: 890
{
	// Fields
	private IPrincipal _principal; // 0x10

	// Properties
	internal bool HasInfo { get; }

	// Methods

	// RVA: 0x17A046C Offset: 0x179C46C VA: 0x17A046C
	internal bool get_HasInfo() { }

	// RVA: 0x17A0168 Offset: 0x179C168 VA: 0x17A0168 Slot: 4
	public object Clone() { }

	// RVA: 0x17A059C Offset: 0x179C59C VA: 0x17A059C
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class CallContextRemotingData : ICloneable // TypeDefIndex: 891
{
	// Fields
	private string _logicalCallID; // 0x10

	// Properties
	internal string LogicalCallID { get; set; }
	internal bool HasInfo { get; }

	// Methods

	// RVA: 0x17A05A4 Offset: 0x179C5A4 VA: 0x17A05A4
	internal string get_LogicalCallID() { }

	// RVA: 0x17A05AC Offset: 0x179C5AC VA: 0x17A05AC
	internal void set_LogicalCallID(string value) { }

	// RVA: 0x17A045C Offset: 0x179C45C VA: 0x17A045C
	internal bool get_HasInfo() { }

	// RVA: 0x17A00F8 Offset: 0x179C0F8 VA: 0x17A00F8 Slot: 4
	public object Clone() { }

	// RVA: 0x17A05B4 Offset: 0x179C5B4 VA: 0x17A05B4
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal enum ArgInfoType // TypeDefIndex: 892
{
	// Fields
	public byte value__; // 0x0
	public const ArgInfoType In = 0;
	public const ArgInfoType Out = 1;
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ArgInfo // TypeDefIndex: 893
{
	// Fields
	private int[] _paramMap; // 0x10
	private int _inoutArgCount; // 0x18
	private MethodBase _method; // 0x20

	// Methods

	// RVA: 0x17A05BC Offset: 0x179C5BC VA: 0x17A05BC
	public void .ctor(MethodBase method, ArgInfoType type) { }

	// RVA: 0x17A0790 Offset: 0x179C790 VA: 0x17A0790
	public object[] GetInOutArgs(object[] args) { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public class AsyncResult : IAsyncResult, IMessageSink, IThreadPoolWorkItem // TypeDefIndex: 894
{
	// Fields
	private object async_state; // 0x10
	private WaitHandle handle; // 0x18
	private object async_delegate; // 0x20
	private IntPtr data; // 0x28
	private object object_data; // 0x30
	private bool sync_completed; // 0x38
	private bool completed; // 0x39
	private bool endinvoke_called; // 0x3A
	private object async_callback; // 0x40
	private ExecutionContext current; // 0x48
	private ExecutionContext original; // 0x50
	private long add_time; // 0x58
	private MonoMethodMessage call_message; // 0x60
	private IMessageCtrl message_ctrl; // 0x68
	private IMessage reply_message; // 0x70
	private WaitCallback orig_cb; // 0x78

	// Properties
	public virtual object AsyncState { get; }
	public virtual WaitHandle AsyncWaitHandle { get; }
	public virtual bool CompletedSynchronously { get; }
	public virtual bool IsCompleted { get; }
	public bool EndInvokeCalled { get; set; }
	public virtual object AsyncDelegate { get; }
	public IMessageSink NextSink { get; }
	internal MonoMethodMessage CallMessage { get; set; }

	// Methods

	// RVA: 0x17A08A8 Offset: 0x179C8A8 VA: 0x17A08A8
	internal void .ctor() { }

	// RVA: 0x17A08B0 Offset: 0x179C8B0 VA: 0x17A08B0 Slot: 12
	public virtual object get_AsyncState() { }

	// RVA: 0x17A08B8 Offset: 0x179C8B8 VA: 0x17A08B8 Slot: 13
	public virtual WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x17A09E4 Offset: 0x179C9E4 VA: 0x17A09E4 Slot: 14
	public virtual bool get_CompletedSynchronously() { }

	// RVA: 0x17A09EC Offset: 0x179C9EC VA: 0x17A09EC Slot: 15
	public virtual bool get_IsCompleted() { }

	// RVA: 0x17A09F4 Offset: 0x179C9F4 VA: 0x17A09F4
	public bool get_EndInvokeCalled() { }

	// RVA: 0x17A09FC Offset: 0x179C9FC VA: 0x17A09FC
	public void set_EndInvokeCalled(bool value) { }

	// RVA: 0x17A0A04 Offset: 0x179CA04 VA: 0x17A0A04 Slot: 16
	public virtual object get_AsyncDelegate() { }

	// RVA: 0x17A0A0C Offset: 0x179CA0C VA: 0x17A0A0C Slot: 17
	public IMessageSink get_NextSink() { }

	// RVA: 0x17A0A14 Offset: 0x179CA14 VA: 0x17A0A14 Slot: 18
	public virtual IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x17A0A4C Offset: 0x179CA4C VA: 0x17A0A4C Slot: 19
	public virtual IMessage GetReplyMessage() { }

	// RVA: 0x17A0A54 Offset: 0x179CA54 VA: 0x17A0A54 Slot: 20
	public virtual void SetMessageCtrl(IMessageCtrl mc) { }

	// RVA: 0x17A0A5C Offset: 0x179CA5C VA: 0x17A0A5C
	internal void SetCompletedSynchronously(bool completed) { }

	// RVA: 0x17A0A64 Offset: 0x179CA64 VA: 0x17A0A64
	internal IMessage EndInvoke() { }

	// RVA: 0x17A0B80 Offset: 0x179CB80 VA: 0x17A0B80 Slot: 21
	public virtual IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x17A0D28 Offset: 0x179CD28 VA: 0x17A0D28
	internal MonoMethodMessage get_CallMessage() { }

	// RVA: 0x17A0D30 Offset: 0x179CD30 VA: 0x17A0D30
	internal void set_CallMessage(MonoMethodMessage value) { }

	// RVA: 0x17A0D38 Offset: 0x179CD38 VA: 0x17A0D38 Slot: 10
	private void System.Threading.IThreadPoolWorkItem.ExecuteWorkItem() { }

	// RVA: 0x17A0D40 Offset: 0x179CD40 VA: 0x17A0D40 Slot: 11
	private void System.Threading.IThreadPoolWorkItem.MarkAborted(ThreadAbortException tae) { }

	// RVA: 0x17A0D3C Offset: 0x179CD3C VA: 0x17A0D3C
	internal object Invoke() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class CADArgHolder // TypeDefIndex: 895
{
	// Fields
	public int index; // 0x10

	// Methods

	// RVA: 0x17A0D44 Offset: 0x179CD44 VA: 0x17A0D44
	public void .ctor(int i) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class CADObjRef // TypeDefIndex: 896
{
	// Fields
	internal ObjRef objref; // 0x10
	internal int SourceDomain; // 0x18
	internal byte[] TypeInfo; // 0x20

	// Methods

	// RVA: 0x17A0D6C Offset: 0x179CD6C VA: 0x17A0D6C
	public void .ctor(ObjRef o, int sourceDomain) { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class CADMethodRef // TypeDefIndex: 897
{
	// Fields
	private bool ctor; // 0x10
	private string typeName; // 0x18
	private string methodName; // 0x20
	private string[] param_names; // 0x28
	private string[] generic_arg_names; // 0x30

	// Methods

	// RVA: 0x17A0DCC Offset: 0x179CDCC VA: 0x17A0DCC
	private Type[] GetTypes(string[] typeArray) { }

	// RVA: 0x17A0F18 Offset: 0x179CF18 VA: 0x17A0F18
	public MethodBase Resolve() { }

	// RVA: 0x17A1378 Offset: 0x179D378 VA: 0x17A1378
	public void .ctor(IMethodMessage msg) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class CADMessageBase // TypeDefIndex: 898
{
	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x17A1644 Offset: 0x179D644 VA: 0x17A1644
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x17A16E0 Offset: 0x179D6E0 VA: 0x17A16E0
	internal MethodBase GetMethod() { }

	// RVA: 0x17A1764 Offset: 0x179D764 VA: 0x17A1764
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x17A1934 Offset: 0x179D934 VA: 0x17A1934
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x17A2190 Offset: 0x179E190 VA: 0x17A2190
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x17A22CC Offset: 0x179E2CC VA: 0x17A22CC
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x17A243C Offset: 0x179E43C VA: 0x17A243C
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x17A2604 Offset: 0x179E604 VA: 0x17A2604
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x17A2CD8 Offset: 0x179ECD8 VA: 0x17A2CD8
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x17A2DD4 Offset: 0x179EDD4 VA: 0x17A2DD4
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x17A2ED0 Offset: 0x179EED0 VA: 0x17A2ED0
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x17A3120 Offset: 0x179F120 VA: 0x17A3120
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class CADMethodCallMessage : CADMessageBase // TypeDefIndex: 899
{
	// Fields
	private string _uri; // 0x38

	// Properties
	internal string Uri { get; }
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x17A31A8 Offset: 0x179F1A8 VA: 0x17A31A8
	internal string get_Uri() { }

	// RVA: 0x17A31B0 Offset: 0x179F1B0 VA: 0x17A31B0
	internal static CADMethodCallMessage Create(IMessage callMsg) { }

	// RVA: 0x17A3238 Offset: 0x179F238 VA: 0x17A3238
	internal void .ctor(IMethodCallMessage callMsg) { }

	// RVA: 0x17A3450 Offset: 0x179F450 VA: 0x17A3450
	internal ArrayList GetArguments() { }

	// RVA: 0x17A3598 Offset: 0x179F598 VA: 0x17A3598
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x17A35A8 Offset: 0x179F5A8 VA: 0x17A35A8
	internal int get_PropertiesCount() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class CADMethodReturnMessage : CADMessageBase // TypeDefIndex: 900
{
	// Fields
	private object _returnValue; // 0x38
	private CADArgHolder _exception; // 0x40
	private Type[] _sig; // 0x48

	// Properties
	internal int PropertiesCount { get; }

	// Methods

	// RVA: 0x17A35B0 Offset: 0x179F5B0 VA: 0x17A35B0
	internal static CADMethodReturnMessage Create(IMessage callMsg) { }

	// RVA: 0x17A3638 Offset: 0x179F638 VA: 0x17A3638
	internal void .ctor(IMethodReturnMessage retMsg) { }

	// RVA: 0x17A39FC Offset: 0x179F9FC VA: 0x17A39FC
	internal ArrayList GetArguments() { }

	// RVA: 0x17A3B44 Offset: 0x179FB44 VA: 0x17A3B44
	internal object[] GetArgs(ArrayList args) { }

	// RVA: 0x17A3B54 Offset: 0x179FB54 VA: 0x17A3B54
	internal object GetReturnValue(ArrayList args) { }

	// RVA: 0x17A3B64 Offset: 0x179FB64 VA: 0x17A3B64
	internal Exception GetException(ArrayList args) { }

	// RVA: 0x17A3C08 Offset: 0x179FC08 VA: 0x17A3C08
	internal int get_PropertiesCount() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ClientContextTerminatorSink : IMessageSink // TypeDefIndex: 901
{
	// Fields
	private Context _context; // 0x10

	// Methods

	// RVA: 0x17A3C10 Offset: 0x179FC10 VA: 0x17A3C10
	public void .ctor(Context ctx) { }

	// RVA: 0x17A3C40 Offset: 0x179FC40 VA: 0x17A3C40 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x17A3E2C Offset: 0x179FE2C VA: 0x17A3E2C Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ClientContextReplySink : IMessageSink // TypeDefIndex: 902
{
	// Fields
	private IMessageSink _replySink; // 0x10
	private Context _context; // 0x18

	// Methods

	// RVA: 0x17A4070 Offset: 0x17A0070 VA: 0x17A4070
	public void .ctor(Context ctx, IMessageSink replySink) { }

	// RVA: 0x17A40B4 Offset: 0x17A00B4 VA: 0x17A40B4 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x17A41C0 Offset: 0x17A01C0 VA: 0x17A41C0 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Messaging
[CLSCompliant(False)]
[ComVisible(True)]
[Serializable]
public class ConstructionCall : MethodCall, IConstructionCallMessage, IMessage, IMethodCallMessage, IMethodMessage // TypeDefIndex: 903
{
	// Fields
	private IActivator _activator; // 0x68
	private object[] _activationAttributes; // 0x70
	private IList _contextProperties; // 0x78
	private Type _activationType; // 0x80
	private string _activationTypeName; // 0x88
	private bool _isContextOk; // 0x90
	private RemotingProxy _sourceProxy; // 0x98

	// Properties
	internal bool IsContextOk { get; set; }
	public Type ActivationType { get; }
	public string ActivationTypeName { get; }
	public IActivator Activator { get; set; }
	public object[] CallSiteActivationAttributes { get; }
	public IList ContextProperties { get; }
	public override IDictionary Properties { get; }
	internal RemotingProxy SourceProxy { get; set; }

	// Methods

	// RVA: 0x17A41F8 Offset: 0x17A01F8 VA: 0x17A41F8
	internal void .ctor(Type type) { }

	// RVA: 0x17A4268 Offset: 0x17A0268 VA: 0x17A4268
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17A4314 Offset: 0x17A0314 VA: 0x17A4314 Slot: 22
	internal override void InitDictionary() { }

	// RVA: 0x17A446C Offset: 0x17A046C VA: 0x17A446C
	internal bool get_IsContextOk() { }

	// RVA: 0x17A4474 Offset: 0x17A0474 VA: 0x17A4474
	internal void set_IsContextOk(bool value) { }

	// RVA: 0x17A447C Offset: 0x17A047C VA: 0x17A447C Slot: 24
	public Type get_ActivationType() { }

	// RVA: 0x17A4544 Offset: 0x17A0544 VA: 0x17A4544 Slot: 25
	public string get_ActivationTypeName() { }

	// RVA: 0x17A454C Offset: 0x17A054C VA: 0x17A454C Slot: 26
	public IActivator get_Activator() { }

	// RVA: 0x17A4554 Offset: 0x17A0554 VA: 0x17A4554 Slot: 27
	public void set_Activator(IActivator value) { }

	// RVA: 0x17A455C Offset: 0x17A055C VA: 0x17A455C Slot: 28
	public object[] get_CallSiteActivationAttributes() { }

	// RVA: 0x17A4564 Offset: 0x17A0564 VA: 0x17A4564
	internal void SetActivationAttributes(object[] attributes) { }

	// RVA: 0x17A456C Offset: 0x17A056C VA: 0x17A456C Slot: 29
	public IList get_ContextProperties() { }

	// RVA: 0x17A45DC Offset: 0x17A05DC VA: 0x17A45DC Slot: 19
	internal override void InitMethodProperty(string key, object value) { }

	// RVA: 0x17A4CD0 Offset: 0x17A0CD0 VA: 0x17A4CD0 Slot: 20
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17A5288 Offset: 0x17A1288 VA: 0x17A5288 Slot: 21
	public override IDictionary get_Properties() { }

	// RVA: 0x17A52E8 Offset: 0x17A12E8 VA: 0x17A52E8
	internal RemotingProxy get_SourceProxy() { }

	// RVA: 0x17A52F0 Offset: 0x17A12F0 VA: 0x17A52F0
	internal void set_SourceProxy(RemotingProxy value) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ConstructionCallDictionary : MessageDictionary // TypeDefIndex: 904
{
	// Fields
	public static string[] InternalKeys; // 0x0

	// Methods

	// RVA: 0x17A4394 Offset: 0x17A0394 VA: 0x17A4394
	public void .ctor(IConstructionCallMessage message) { }

	// RVA: 0x17A5328 Offset: 0x17A1328 VA: 0x17A5328 Slot: 19
	protected override object GetMethodProperty(string key) { }

	// RVA: 0x17A5C64 Offset: 0x17A1C64 VA: 0x17A5C64 Slot: 20
	protected override void SetMethodProperty(string key, object value) { }

	// RVA: 0x17A61A0 Offset: 0x17A21A0 VA: 0x17A61A0
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[CLSCompliant(False)]
[ComVisible(True)]
[Serializable]
public class ConstructionResponse : MethodResponse, IConstructionReturnMessage, IMethodReturnMessage, IMethodMessage, IMessage // TypeDefIndex: 905
{
	// Properties
	public override IDictionary Properties { get; }

	// Methods

	// RVA: 0x179E640 Offset: 0x179A640 VA: 0x179E640
	internal void .ctor(object resultObject, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x17A6568 Offset: 0x17A2568 VA: 0x17A6568
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x17A66AC Offset: 0x17A26AC VA: 0x17A66AC
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17A6738 Offset: 0x17A2738 VA: 0x17A6738 Slot: 22
	public override IDictionary get_Properties() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class EnvoyTerminatorSink : IMessageSink // TypeDefIndex: 906
{
	// Fields
	public static EnvoyTerminatorSink Instance; // 0x0

	// Methods

	// RVA: 0x17A67D0 Offset: 0x17A27D0 VA: 0x17A67D0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x17A6888 Offset: 0x17A2888 VA: 0x17A6888 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x17A694C Offset: 0x17A294C VA: 0x17A694C
	public void .ctor() { }

	// RVA: 0x17A6954 Offset: 0x17A2954 VA: 0x17A6954
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class ErrorMessage : IMethodCallMessage, IMethodMessage, IMessage // TypeDefIndex: 907
{
	// Fields
	private string _uri; // 0x10

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; }
	public LogicalCallContext LogicalCallContext { get; }

	// Methods

	// RVA: 0x17A69BC Offset: 0x17A29BC VA: 0x17A69BC
	public void .ctor() { }

	// RVA: 0x17A6A14 Offset: 0x17A2A14 VA: 0x17A6A14 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x17A6A1C Offset: 0x17A2A1C VA: 0x17A6A1C Slot: 5
	public object[] get_Args() { }

	// RVA: 0x17A6A24 Offset: 0x17A2A24 VA: 0x17A6A24 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x17A6A2C Offset: 0x17A2A2C VA: 0x17A6A2C Slot: 8
	public string get_MethodName() { }

	// RVA: 0x17A6A6C Offset: 0x17A2A6C VA: 0x17A6A6C Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x17A6A74 Offset: 0x17A2A74 VA: 0x17A6A74 Slot: 14
	public virtual IDictionary get_Properties() { }

	// RVA: 0x17A6A7C Offset: 0x17A2A7C VA: 0x17A6A7C Slot: 10
	public string get_TypeName() { }

	// RVA: 0x17A6ABC Offset: 0x17A2ABC VA: 0x17A6ABC Slot: 11
	public string get_Uri() { }

	// RVA: 0x17A6AC4 Offset: 0x17A2AC4 VA: 0x17A6AC4 Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x17A6ACC Offset: 0x17A2ACC VA: 0x17A6ACC Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[Serializable]
public class Header // TypeDefIndex: 908
{}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public sealed class HeaderHandler : MulticastDelegate // TypeDefIndex: 909
{
	// Methods

	// RVA: 0x17A6AD4 Offset: 0x17A2AD4 VA: 0x17A6AD4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x17A6BDC Offset: 0x17A2BDC VA: 0x17A6BDC Slot: 12
	public virtual object Invoke(Header[] headers) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal interface IInternalMessage // TypeDefIndex: 910
{
	// Properties
	public abstract Identity TargetIdentity { get; set; }
	public abstract string Uri { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Identity get_TargetIdentity();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_TargetIdentity(Identity value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_Uri();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_Uri(string value);
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMessage // TypeDefIndex: 911
{
	// Properties
	public abstract IDictionary Properties { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDictionary get_Properties();
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMessageCtrl // TypeDefIndex: 912
{}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMessageSink // TypeDefIndex: 913
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessage SyncProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink);
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMethodCallMessage : IMethodMessage, IMessage // TypeDefIndex: 914
{}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMethodMessage : IMessage // TypeDefIndex: 915
{
	// Properties
	public abstract int ArgCount { get; }
	public abstract object[] Args { get; }
	public abstract LogicalCallContext LogicalCallContext { get; }
	public abstract MethodBase MethodBase { get; }
	public abstract string MethodName { get; }
	public abstract object MethodSignature { get; }
	public abstract string TypeName { get; }
	public abstract string Uri { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_ArgCount();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] get_Args();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract LogicalCallContext get_LogicalCallContext();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract MethodBase get_MethodBase();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_MethodName();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract object get_MethodSignature();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_TypeName();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_Uri();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object GetArg(int argNum);
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public interface IMethodReturnMessage : IMethodMessage, IMessage // TypeDefIndex: 916
{
	// Properties
	public abstract Exception Exception { get; }
	public abstract object[] OutArgs { get; }
	public abstract object ReturnValue { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Exception get_Exception();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract object[] get_OutArgs();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract object get_ReturnValue();
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[CLSCompliant(False)]
[Serializable]
public class MethodCall : IMethodCallMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 917
{
	// Fields
	private string _uri; // 0x10
	private string _typeName; // 0x18
	private string _methodName; // 0x20
	private object[] _args; // 0x28
	private Type[] _methodSignature; // 0x30
	private MethodBase _methodBase; // 0x38
	private LogicalCallContext _callContext; // 0x40
	private Identity _targetIdentity; // 0x48
	private Type[] _genericArguments; // 0x50
	protected IDictionary ExternalProperties; // 0x58
	protected IDictionary InternalProperties; // 0x60

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	private Type[] GenericArguments { get; }

	// Methods

	// RVA: 0x17A426C Offset: 0x17A026C VA: 0x17A426C
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17A6CB8 Offset: 0x17A2CB8 VA: 0x17A6CB8
	internal void .ctor(CADMethodCallMessage msg) { }

	// RVA: 0x17A4260 Offset: 0x17A0260 VA: 0x17A4260
	internal void .ctor() { }

	// RVA: 0x17A6E0C Offset: 0x17A2E0C VA: 0x17A6E0C
	internal void CopyFrom(IMethodMessage call) { }

	// RVA: 0x17A4890 Offset: 0x17A0890 VA: 0x17A4890 Slot: 19
	internal virtual void InitMethodProperty(string key, object value) { }

	// RVA: 0x17A4E54 Offset: 0x17A0E54 VA: 0x17A4E54 Slot: 20
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17A71D8 Offset: 0x17A31D8 VA: 0x17A71D8 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x17A71F0 Offset: 0x17A31F0 VA: 0x17A71F0 Slot: 5
	public object[] get_Args() { }

	// RVA: 0x17A71F8 Offset: 0x17A31F8 VA: 0x17A71F8 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x17A7268 Offset: 0x17A3268 VA: 0x17A7268 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x17A7804 Offset: 0x17A3804 VA: 0x17A7804 Slot: 8
	public string get_MethodName() { }

	// RVA: 0x17A784C Offset: 0x17A384C VA: 0x17A784C Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x17A52B8 Offset: 0x17A12B8 VA: 0x17A52B8 Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x17A7994 Offset: 0x17A3994 VA: 0x17A7994 Slot: 22
	internal virtual void InitDictionary() { }

	// RVA: 0x17A7AA0 Offset: 0x17A3AA0 VA: 0x17A7AA0 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x17A7AFC Offset: 0x17A3AFC VA: 0x17A7AFC Slot: 11
	public string get_Uri() { }

	// RVA: 0x17A7B04 Offset: 0x17A3B04 VA: 0x17A7B04
	public void set_Uri(string value) { }

	// RVA: 0x17A7B0C Offset: 0x17A3B0C VA: 0x17A7B0C Slot: 17
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x17A7B14 Offset: 0x17A3B14 VA: 0x17A7B14 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x17A7B1C Offset: 0x17A3B1C VA: 0x17A7B1C Slot: 12
	public object GetArg(int argNum) { }

	// RVA: 0x17A7B4C Offset: 0x17A3B4C VA: 0x17A7B4C Slot: 23
	public virtual void Init() { }

	// RVA: 0x17A7298 Offset: 0x17A3298 VA: 0x17A7298
	public void ResolveMethod() { }

	// RVA: 0x17A7B50 Offset: 0x17A3B50 VA: 0x17A7B50
	private Type CastTo(string clientType, Type serverType) { }

	// RVA: 0x17A7D08 Offset: 0x17A3D08 VA: 0x17A7D08
	private static string GetTypeNameFromAssemblyQualifiedName(string aqname) { }

	// RVA: 0x17A7DB0 Offset: 0x17A3DB0 VA: 0x17A7DB0 Slot: 15
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x17A7DB8 Offset: 0x17A3DB8 VA: 0x17A7DB8 Slot: 16
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x17A7CB4 Offset: 0x17A3CB4 VA: 0x17A7CB4
	private Type[] get_GenericArguments() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class MCMDictionary : MessageDictionary // TypeDefIndex: 918
{
	// Fields
	public static string[] InternalKeys; // 0x0

	// Methods

	// RVA: 0x17A7A14 Offset: 0x17A3A14 VA: 0x17A7A14
	public void .ctor(IMethodMessage message) { }

	// RVA: 0x17A7DC0 Offset: 0x17A3DC0 VA: 0x17A7DC0
	private static void .cctor() { }
}

// Namespace: 
private class MessageDictionary.DictionaryEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 919
{
	// Fields
	private MessageDictionary _methodDictionary; // 0x10
	private IDictionaryEnumerator _hashtableEnum; // 0x18
	private int _posMethod; // 0x20

	// Properties
	public object Current { get; }
	public DictionaryEntry Entry { get; }
	public object Key { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x17A8C40 Offset: 0x17A4C40 VA: 0x17A8C40
	public void .ctor(MessageDictionary methodDictionary) { }

	// RVA: 0x17A8D94 Offset: 0x17A4D94 VA: 0x17A8D94 Slot: 8
	public object get_Current() { }

	// RVA: 0x17A8F60 Offset: 0x17A4F60 VA: 0x17A8F60 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x17A9120 Offset: 0x17A5120 VA: 0x17A9120 Slot: 9
	public void Reset() { }

	// RVA: 0x17A8DF8 Offset: 0x17A4DF8 VA: 0x17A8DF8 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x17A91CC Offset: 0x17A51CC VA: 0x17A91CC Slot: 4
	public object get_Key() { }

	// RVA: 0x17A91D0 Offset: 0x17A51D0 VA: 0x17A91D0 Slot: 5
	public object get_Value() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[DefaultMember("Item")]
[Serializable]
internal class MessageDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 920
{
	// Fields
	private IDictionary _internalProperties; // 0x10
	protected IMethodMessage _message; // 0x18
	private string[] _methodKeys; // 0x20
	private bool _ownProperties; // 0x28

	// Properties
	internal IDictionary InternalDictionary { get; }
	public string[] MethodKeys { set; }
	public bool IsReadOnly { get; }
	public object Item { get; set; }
	public ICollection Values { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x17A52F8 Offset: 0x17A12F8 VA: 0x17A52F8
	public void .ctor(IMethodMessage message) { }

	// RVA: 0x17A201C Offset: 0x179E01C VA: 0x17A201C
	internal bool HasUserData() { }

	// RVA: 0x17A2110 Offset: 0x179E110 VA: 0x17A2110
	internal IDictionary get_InternalDictionary() { }

	// RVA: 0x17A7F74 Offset: 0x17A3F74 VA: 0x17A7F74
	public void set_MethodKeys(string[] value) { }

	// RVA: 0x17A7F7C Offset: 0x17A3F7C VA: 0x17A7F7C Slot: 18
	protected virtual IDictionary AllocInternalProperties() { }

	// RVA: 0x17A4420 Offset: 0x17A0420 VA: 0x17A4420
	public IDictionary GetInternalProperties() { }

	// RVA: 0x17A7FDC Offset: 0x17A3FDC VA: 0x17A7FDC
	private bool IsOverridenKey(string key) { }

	// RVA: 0x17A8064 Offset: 0x17A4064 VA: 0x17A8064 Slot: 10
	public bool get_IsReadOnly() { }

	// RVA: 0x17A806C Offset: 0x17A406C VA: 0x17A806C Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x17A81A0 Offset: 0x17A41A0 VA: 0x17A81A0 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x17A56EC Offset: 0x17A16EC VA: 0x17A56EC Slot: 19
	protected virtual object GetMethodProperty(string key) { }

	// RVA: 0x17A5ECC Offset: 0x17A1ECC VA: 0x17A5ECC Slot: 20
	protected virtual void SetMethodProperty(string key, object value) { }

	// RVA: 0x17A8318 Offset: 0x17A4318 VA: 0x17A8318 Slot: 6
	public ICollection get_Values() { }

	// RVA: 0x17A81A4 Offset: 0x17A41A4 VA: 0x17A81A4 Slot: 8
	public void Add(object key, object value) { }

	// RVA: 0x17A8700 Offset: 0x17A4700 VA: 0x17A8700 Slot: 9
	public void Clear() { }

	// RVA: 0x17A87AC Offset: 0x17A47AC VA: 0x17A87AC Slot: 7
	public bool Contains(object key) { }

	// RVA: 0x17A88DC Offset: 0x17A48DC VA: 0x17A88DC Slot: 12
	public void Remove(object key) { }

	// RVA: 0x17A8A54 Offset: 0x17A4A54 VA: 0x17A8A54 Slot: 14
	public int get_Count() { }

	// RVA: 0x17A8B1C Offset: 0x17A4B1C VA: 0x17A8B1C Slot: 16
	public bool get_IsSynchronized() { }

	// RVA: 0x17A8B24 Offset: 0x17A4B24 VA: 0x17A8B24 Slot: 15
	public object get_SyncRoot() { }

	// RVA: 0x17A8B28 Offset: 0x17A4B28 VA: 0x17A8B28 Slot: 13
	public void CopyTo(Array array, int index) { }

	// RVA: 0x17A8BE8 Offset: 0x17A4BE8 VA: 0x17A8BE8 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x17A8D3C Offset: 0x17A4D3C VA: 0x17A8D3C Slot: 11
	public IDictionaryEnumerator GetEnumerator() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[CLSCompliant(False)]
[ComVisible(True)]
[Serializable]
public class MethodResponse : IMethodReturnMessage, IMethodMessage, IMessage, ISerializable, IInternalMessage // TypeDefIndex: 921
{
	// Fields
	private string _methodName; // 0x10
	private string _uri; // 0x18
	private string _typeName; // 0x20
	private MethodBase _methodBase; // 0x28
	private object _returnValue; // 0x30
	private Exception _exception; // 0x38
	private Type[] _methodSignature; // 0x40
	private ArgInfo _inArgInfo; // 0x48
	private object[] _args; // 0x50
	private object[] _outArgs; // 0x58
	private IMethodCallMessage _callMsg; // 0x60
	private LogicalCallContext _callContext; // 0x68
	private Identity _targetIdentity; // 0x70
	protected IDictionary ExternalProperties; // 0x78
	protected IDictionary InternalProperties; // 0x80

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public Exception Exception { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public object[] OutArgs { get; }
	public virtual IDictionary Properties { get; }
	public object ReturnValue { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x17A656C Offset: 0x17A256C VA: 0x17A656C
	internal void .ctor(Exception e, IMethodCallMessage msg) { }

	// RVA: 0x17A6458 Offset: 0x17A2458 VA: 0x17A6458
	internal void .ctor(object returnValue, object[] outArgs, LogicalCallContext callCtx, IMethodCallMessage msg) { }

	// RVA: 0x17A91E4 Offset: 0x17A51E4 VA: 0x17A91E4
	internal void .ctor(IMethodCallMessage msg, CADMethodReturnMessage retmsg) { }

	// RVA: 0x17A66B0 Offset: 0x17A26B0 VA: 0x17A66B0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17A9498 Offset: 0x17A5498 VA: 0x17A9498
	internal void InitMethodProperty(string key, object value) { }

	// RVA: 0x17A995C Offset: 0x17A595C VA: 0x17A995C Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x17A9974 Offset: 0x17A5974 VA: 0x17A9974 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x17A997C Offset: 0x17A597C VA: 0x17A997C Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x17A9984 Offset: 0x17A5984 VA: 0x17A9984 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x17A99F4 Offset: 0x17A59F4 VA: 0x17A99F4 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x17A9B10 Offset: 0x17A5B10 VA: 0x17A9B10 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x17A9CA8 Offset: 0x17A5CA8 VA: 0x17A9CA8 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x17A9DD0 Offset: 0x17A5DD0 VA: 0x17A9DD0 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x17A673C Offset: 0x17A273C VA: 0x17A673C Slot: 22
	public virtual IDictionary get_Properties() { }

	// RVA: 0x17A9FB8 Offset: 0x17A5FB8 VA: 0x17A9FB8 Slot: 6
	public object get_ReturnValue() { }

	// RVA: 0x17A9BDC Offset: 0x17A5BDC VA: 0x17A9BDC Slot: 13
	public string get_TypeName() { }

	// RVA: 0x17A9FC0 Offset: 0x17A5FC0 VA: 0x17A9FC0 Slot: 14
	public string get_Uri() { }

	// RVA: 0x17AA08C Offset: 0x17A608C VA: 0x17AA08C
	public void set_Uri(string value) { }

	// RVA: 0x17AA094 Offset: 0x17A6094 VA: 0x17AA094 Slot: 20
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x17AA098 Offset: 0x17A6098 VA: 0x17AA098 Slot: 21
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x17AA0A0 Offset: 0x17A60A0 VA: 0x17AA0A0 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x17AA0D0 Offset: 0x17A60D0 VA: 0x17AA0D0 Slot: 23
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17AA520 Offset: 0x17A6520 VA: 0x17AA520 Slot: 18
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x17AA528 Offset: 0x17A6528 VA: 0x17AA528 Slot: 19
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class MethodReturnDictionary : MessageDictionary // TypeDefIndex: 922
{
	// Fields
	public static string[] InternalReturnKeys; // 0x0
	public static string[] InternalExceptionKeys; // 0x8

	// Methods

	// RVA: 0x17A9EA0 Offset: 0x17A5EA0 VA: 0x17A9EA0
	public void .ctor(IMethodReturnMessage message) { }

	// RVA: 0x17AA530 Offset: 0x17A6530 VA: 0x17AA530
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[Serializable]
internal class MonoMethodMessage : IMethodCallMessage, IMethodMessage, IMessage, IMethodReturnMessage, IInternalMessage // TypeDefIndex: 923
{
	// Fields
	private RuntimeMethodInfo method; // 0x10
	private object[] args; // 0x18
	private string[] names; // 0x20
	private byte[] arg_types; // 0x28
	public LogicalCallContext ctx; // 0x30
	public object rval; // 0x38
	public Exception exc; // 0x40
	private AsyncResult asyncResult; // 0x48
	private CallType call_type; // 0x50
	private string uri; // 0x58
	private MCMDictionary properties; // 0x60
	private Identity identity; // 0x68
	private Type[] methodSignature; // 0x70

	// Properties
	public IDictionary Properties { get; }
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; set; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	public Exception Exception { get; }
	public int OutArgCount { get; }
	public object[] OutArgs { get; }
	public object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }
	public AsyncResult AsyncResult { get; }
	internal CallType CallType { get; }

	// Methods

	// RVA: 0x17AA760 Offset: 0x17A6760 VA: 0x17AA760
	internal void InitMessage(RuntimeMethodInfo method, object[] out_args) { }

	// RVA: 0x17AAA10 Offset: 0x17A6A10 VA: 0x17AAA10
	public void .ctor(MethodBase method, object[] out_args) { }

	// RVA: 0x17AAAE0 Offset: 0x17A6AE0 VA: 0x17AAAE0
	internal void .ctor(MethodInfo minfo, object[] in_args, object[] out_args) { }

	// RVA: 0x17AAC1C Offset: 0x17A6C1C VA: 0x17AAC1C
	private static MethodInfo GetMethodInfo(Type type, string methodName) { }

	// RVA: 0x17AACCC Offset: 0x17A6CCC VA: 0x17AACCC
	public void .ctor(Type type, string methodName, object[] in_args) { }

	// RVA: 0x17AAD04 Offset: 0x17A6D04 VA: 0x17AAD04 Slot: 13
	public IDictionary get_Properties() { }

	// RVA: 0x17AAD78 Offset: 0x17A6D78 VA: 0x17AAD78 Slot: 4
	public int get_ArgCount() { }

	// RVA: 0x17AAE2C Offset: 0x17A6E2C VA: 0x17AAE2C Slot: 5
	public object[] get_Args() { }

	// RVA: 0x17AAE34 Offset: 0x17A6E34 VA: 0x17AAE34 Slot: 6
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x17AAE3C Offset: 0x17A6E3C VA: 0x17AAE3C
	public void set_LogicalCallContext(LogicalCallContext value) { }

	// RVA: 0x17AAE44 Offset: 0x17A6E44 VA: 0x17AAE44 Slot: 7
	public MethodBase get_MethodBase() { }

	// RVA: 0x17AAE4C Offset: 0x17A6E4C VA: 0x17AAE4C Slot: 8
	public string get_MethodName() { }

	// RVA: 0x17AAEA0 Offset: 0x17A6EA0 VA: 0x17AAEA0 Slot: 9
	public object get_MethodSignature() { }

	// RVA: 0x17AAFD4 Offset: 0x17A6FD4 VA: 0x17AAFD4 Slot: 10
	public string get_TypeName() { }

	// RVA: 0x17AB03C Offset: 0x17A703C VA: 0x17AB03C Slot: 19
	public string get_Uri() { }

	// RVA: 0x17AB044 Offset: 0x17A7044 VA: 0x17AB044 Slot: 20
	public void set_Uri(string value) { }

	// RVA: 0x17AB04C Offset: 0x17A704C VA: 0x17AB04C Slot: 12
	public object GetArg(int arg_num) { }

	// RVA: 0x17AB07C Offset: 0x17A707C VA: 0x17AB07C Slot: 14
	public Exception get_Exception() { }

	// RVA: 0x17AB084 Offset: 0x17A7084 VA: 0x17AB084 Slot: 21
	public int get_OutArgCount() { }

	// RVA: 0x17AB0E8 Offset: 0x17A70E8 VA: 0x17AB0E8 Slot: 15
	public object[] get_OutArgs() { }

	// RVA: 0x17AB228 Offset: 0x17A7228 VA: 0x17AB228 Slot: 16
	public object get_ReturnValue() { }

	// RVA: 0x17AB230 Offset: 0x17A7230 VA: 0x17AB230 Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x17AB238 Offset: 0x17A7238 VA: 0x17AB238 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }

	// RVA: 0x17AB240 Offset: 0x17A7240 VA: 0x17AB240
	public AsyncResult get_AsyncResult() { }

	// RVA: 0x17AADB0 Offset: 0x17A6DB0 VA: 0x17AADB0
	internal CallType get_CallType() { }

	// RVA: 0x17AB248 Offset: 0x17A7248 VA: 0x17AB248
	public bool NeedsOutProcessing(out int outCount) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal enum CallType // TypeDefIndex: 924
{
	// Fields
	public int value__; // 0x0
	public const CallType Sync = 0;
	public const CallType BeginInvoke = 1;
	public const CallType EndInvoke = 2;
	public const CallType OneWay = 3;
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
[Usage(64)]
public class OneWayAttribute : Attribute // TypeDefIndex: 925
{}

// Namespace: System.Runtime.Remoting.Messaging
internal class RemotingSurrogate : ISerializationSurrogate // TypeDefIndex: 926
{
	// Methods

	// RVA: 0x17AB2D0 Offset: 0x17A72D0 VA: 0x17AB2D0 Slot: 6
	public virtual void GetObjectData(object obj, SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x17AB3E8 Offset: 0x17A73E8 VA: 0x17AB3E8 Slot: 7
	public virtual object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector) { }

	// RVA: 0x17AB420 Offset: 0x17A7420 VA: 0x17AB420
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ObjRefSurrogate : ISerializationSurrogate // TypeDefIndex: 927
{
	// Methods

	// RVA: 0x17AB428 Offset: 0x17A7428 VA: 0x17AB428 Slot: 6
	public virtual void GetObjectData(object obj, SerializationInfo si, StreamingContext sc) { }

	// RVA: 0x17AB5A0 Offset: 0x17A75A0 VA: 0x17AB5A0 Slot: 7
	public virtual object SetObjectData(object obj, SerializationInfo si, StreamingContext sc, ISurrogateSelector selector) { }

	// RVA: 0x17AB5EC Offset: 0x17A75EC VA: 0x17AB5EC
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public class RemotingSurrogateSelector : ISurrogateSelector // TypeDefIndex: 928
{
	// Fields
	private static Type s_cachedTypeObjRef; // 0x0
	private static ObjRefSurrogate _objRefSurrogate; // 0x8
	private static RemotingSurrogate _objRemotingSurrogate; // 0x10
	private ISurrogateSelector _next; // 0x10

	// Methods

	// RVA: 0x17AB5F4 Offset: 0x17A75F4 VA: 0x17AB5F4
	public void .ctor() { }

	// RVA: 0x17AB5FC Offset: 0x17A75FC VA: 0x17AB5FC Slot: 5
	public virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector ssout) { }

	// RVA: 0x17AB7BC Offset: 0x17A77BC VA: 0x17AB7BC
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
[ComVisible(True)]
public class ReturnMessage : IMethodReturnMessage, IMethodMessage, IMessage, IInternalMessage // TypeDefIndex: 929
{
	// Fields
	private object[] _outArgs; // 0x10
	private object[] _args; // 0x18
	private LogicalCallContext _callCtx; // 0x20
	private object _returnValue; // 0x28
	private string _uri; // 0x30
	private Exception _exception; // 0x38
	private MethodBase _methodBase; // 0x40
	private string _methodName; // 0x48
	private Type[] _methodSignature; // 0x50
	private string _typeName; // 0x58
	private MethodReturnDictionary _properties; // 0x60
	private Identity _targetIdentity; // 0x68
	private ArgInfo _inArgInfo; // 0x70

	// Properties
	public int ArgCount { get; }
	public object[] Args { get; }
	public LogicalCallContext LogicalCallContext { get; }
	public MethodBase MethodBase { get; }
	public string MethodName { get; }
	public object MethodSignature { get; }
	public virtual IDictionary Properties { get; }
	public string TypeName { get; }
	public string Uri { get; set; }
	private string System.Runtime.Remoting.Messaging.IInternalMessage.Uri { get; set; }
	public Exception Exception { get; }
	public object[] OutArgs { get; }
	public virtual object ReturnValue { get; }
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.TargetIdentity { get; set; }

	// Methods

	// RVA: 0x17AB8CC Offset: 0x17A78CC VA: 0x17AB8CC
	public void .ctor(object ret, object[] outArgs, int outArgsCount, LogicalCallContext callCtx, IMethodCallMessage mcm) { }

	// RVA: 0x17ABA94 Offset: 0x17A7A94 VA: 0x17ABA94
	public void .ctor(Exception e, IMethodCallMessage mcm) { }

	// RVA: 0x17ABC08 Offset: 0x17A7C08 VA: 0x17ABC08 Slot: 7
	public int get_ArgCount() { }

	// RVA: 0x17ABC20 Offset: 0x17A7C20 VA: 0x17ABC20 Slot: 8
	public object[] get_Args() { }

	// RVA: 0x17ABC28 Offset: 0x17A7C28 VA: 0x17ABC28 Slot: 9
	public LogicalCallContext get_LogicalCallContext() { }

	// RVA: 0x17ABC98 Offset: 0x17A7C98 VA: 0x17ABC98 Slot: 10
	public MethodBase get_MethodBase() { }

	// RVA: 0x17ABCA0 Offset: 0x17A7CA0 VA: 0x17ABCA0 Slot: 11
	public string get_MethodName() { }

	// RVA: 0x17ABD04 Offset: 0x17A7D04 VA: 0x17ABD04 Slot: 12
	public object get_MethodSignature() { }

	// RVA: 0x17ABE4C Offset: 0x17A7E4C VA: 0x17ABE4C Slot: 21
	public virtual IDictionary get_Properties() { }

	// RVA: 0x17ABEC0 Offset: 0x17A7EC0 VA: 0x17ABEC0 Slot: 13
	public string get_TypeName() { }

	// RVA: 0x17ABF38 Offset: 0x17A7F38 VA: 0x17ABF38 Slot: 14
	public string get_Uri() { }

	// RVA: 0x17ABF40 Offset: 0x17A7F40 VA: 0x17ABF40
	public void set_Uri(string value) { }

	// RVA: 0x17ABF48 Offset: 0x17A7F48 VA: 0x17ABF48 Slot: 19
	private string System.Runtime.Remoting.Messaging.IInternalMessage.get_Uri() { }

	// RVA: 0x17ABF50 Offset: 0x17A7F50 VA: 0x17ABF50 Slot: 20
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_Uri(string value) { }

	// RVA: 0x17ABF58 Offset: 0x17A7F58 VA: 0x17ABF58 Slot: 15
	public object GetArg(int argNum) { }

	// RVA: 0x17ABF88 Offset: 0x17A7F88 VA: 0x17ABF88 Slot: 4
	public Exception get_Exception() { }

	// RVA: 0x17ABF90 Offset: 0x17A7F90 VA: 0x17ABF90 Slot: 5
	public object[] get_OutArgs() { }

	// RVA: 0x17AC054 Offset: 0x17A8054 VA: 0x17AC054 Slot: 22
	public virtual object get_ReturnValue() { }

	// RVA: 0x17AC05C Offset: 0x17A805C VA: 0x17AC05C Slot: 17
	private Identity System.Runtime.Remoting.Messaging.IInternalMessage.get_TargetIdentity() { }

	// RVA: 0x17AC064 Offset: 0x17A8064 VA: 0x17AC064 Slot: 18
	private void System.Runtime.Remoting.Messaging.IInternalMessage.set_TargetIdentity(Identity value) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ServerContextTerminatorSink : IMessageSink // TypeDefIndex: 930
{
	// Methods

	// RVA: 0x17AC06C Offset: 0x17A806C VA: 0x17AC06C Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x17AC178 Offset: 0x17A8178 VA: 0x17AC178 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x17AC238 Offset: 0x17A8238 VA: 0x17AC238
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ServerObjectTerminatorSink : IMessageSink // TypeDefIndex: 931
{
	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x17AC240 Offset: 0x17A8240 VA: 0x17AC240
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x17AC270 Offset: 0x17A8270 VA: 0x17AC270 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x17AC3E4 Offset: 0x17A83E4 VA: 0x17AC3E4 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class ServerObjectReplySink : IMessageSink // TypeDefIndex: 932
{
	// Fields
	private IMessageSink _replySink; // 0x10
	private ServerIdentity _identity; // 0x18

	// Methods

	// RVA: 0x17AC5AC Offset: 0x17A85AC VA: 0x17AC5AC
	public void .ctor(ServerIdentity identity, IMessageSink replySink) { }

	// RVA: 0x17AC5F0 Offset: 0x17A85F0 VA: 0x17AC5F0 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x17AC6B8 Offset: 0x17A86B8 VA: 0x17AC6B8 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Messaging
internal class StackBuilderSink : IMessageSink // TypeDefIndex: 933
{
	// Fields
	private MarshalByRefObject _target; // 0x10
	private RealProxy _rp; // 0x18

	// Methods

	// RVA: 0x17AC6F0 Offset: 0x17A86F0 VA: 0x17AC6F0
	public void .ctor(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x17AC7B8 Offset: 0x17A87B8 VA: 0x17AC7B8 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x17ACC0C Offset: 0x17A8C0C VA: 0x17ACC0C Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x17ACD40 Offset: 0x17A8D40 VA: 0x17ACD40
	private void ExecuteAsyncMessage(object ob) { }

	// RVA: 0x17AC884 Offset: 0x17A8884 VA: 0x17AC884
	private void CheckParameters(IMessage msg) { }

	[CompilerGenerated]
	// RVA: 0x17ACF44 Offset: 0x17A8F44 VA: 0x17ACF44
	private void <AsyncProcessMessage>b__4_0(object data) { }
}
