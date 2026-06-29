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

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public class Context // TypeDefIndex: 841
{
	// Fields
	private int domain_id; // 0x10
	private int context_id; // 0x14
	private UIntPtr static_data; // 0x18
	private UIntPtr data; // 0x20
	[ContextStatic]
	private static object[] local_slots; // 0x0
	private static IMessageSink default_server_context_sink; // 0x8
	private IMessageSink server_context_sink_chain; // 0x28
	private IMessageSink client_context_sink_chain; // 0x30
	private List<IContextProperty> context_properties; // 0x38
	private static int global_count; // 0x10
	private LocalDataStoreHolder _localDataStore; // 0x40
	private static LocalDataStoreMgr _localDataStoreMgr; // 0x18
	private static DynamicPropertyCollection global_dynamic_properties; // 0x20
	private DynamicPropertyCollection context_dynamic_properties; // 0x48
	private ContextCallbackObject callback_object; // 0x50

	// Properties
	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }

	// Methods

	// RVA: 0x1797BBC Offset: 0x1793BBC VA: 0x1797BBC
	private static void RegisterContext(Context ctx) { }

	// RVA: 0x1797BC0 Offset: 0x1793BC0 VA: 0x1797BC0
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x1797BC4 Offset: 0x1793BC4 VA: 0x1797BC4
	public void .ctor() { }

	// RVA: 0x1797C50 Offset: 0x1793C50 VA: 0x1797C50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x178F990 Offset: 0x178B990 VA: 0x178F990
	public static Context get_DefaultContext() { }

	// RVA: 0x1797D20 Offset: 0x1793D20 VA: 0x1797D20 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x1797D28 Offset: 0x1793D28 VA: 0x1797D28 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x1797D9C Offset: 0x1793D9C VA: 0x1797D9C
	internal bool get_IsDefaultContext() { }

	// RVA: 0x1797DAC Offset: 0x1793DAC VA: 0x1797DAC
	internal bool get_NeedsContextSink() { }

	// RVA: 0x1797E8C Offset: 0x1793E8C VA: 0x1797E8C
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x17983A8 Offset: 0x17943A8 VA: 0x17983A8
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1797F04 Offset: 0x1793F04 VA: 0x1797F04
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1798590 Offset: 0x1794590 VA: 0x1798590
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1798690 Offset: 0x1794690 VA: 0x1798690
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x1798734 Offset: 0x1794734 VA: 0x1798734
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x17987B8 Offset: 0x17947B8 VA: 0x17987B8
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x179571C Offset: 0x179171C VA: 0x179571C
	internal bool get_HasExitSinks() { }

	// RVA: 0x17987F8 Offset: 0x17947F8 VA: 0x17987F8 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x17989B8 Offset: 0x17949B8 VA: 0x17989B8 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x1798B6C Offset: 0x1794B6C VA: 0x1798B6C Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x1798D0C Offset: 0x1794D0C VA: 0x1798D0C Slot: 3
	public override string ToString() { }

	// RVA: 0x1798D68 Offset: 0x1794D68 VA: 0x1798D68
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x17957D4 Offset: 0x17917D4 VA: 0x17957D4
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x17911D0 Offset: 0x178D1D0 VA: 0x17911D0
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x1790B5C Offset: 0x178CB5C VA: 0x1790B5C
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x1798F4C Offset: 0x1794F4C VA: 0x1798F4C
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x1798F54 Offset: 0x1794F54 VA: 0x1798F54
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x1799714 Offset: 0x1795714 VA: 0x1799714
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x17998A8 Offset: 0x17958A8 VA: 0x17998A8
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x1799A24 Offset: 0x1795A24 VA: 0x1799A24
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x1799A88 Offset: 0x1795A88 VA: 0x1799A88
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1799AF4 Offset: 0x1795AF4 VA: 0x1799AF4
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x1799B60 Offset: 0x1795B60 VA: 0x1799B60
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1799BCC Offset: 0x1795BCC VA: 0x1799BCC
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1799BFC Offset: 0x1795BFC VA: 0x1799BFC
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1799C3C Offset: 0x1795C3C VA: 0x1799C3C
	private static void .cctor() { }
}

// Namespace: 
private class DynamicPropertyCollection.DynamicPropertyReg // TypeDefIndex: 842
{
	// Fields
	public IDynamicProperty Property; // 0x10
	public IDynamicMessageSink Sink; // 0x18

	// Methods

	// RVA: 0x1799E14 Offset: 0x1795E14 VA: 0x1799E14
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Contexts
internal class DynamicPropertyCollection // TypeDefIndex: 843
{
	// Fields
	private ArrayList _properties; // 0x10

	// Properties
	public bool HasProperties { get; }

	// Methods

	// RVA: 0x1780C3C Offset: 0x177CC3C VA: 0x1780C3C
	public bool get_HasProperties() { }

	// RVA: 0x1798094 Offset: 0x1794094 VA: 0x1798094
	public bool RegisterDynamicProperty(IDynamicProperty prop) { }

	// RVA: 0x1798420 Offset: 0x1794420 VA: 0x1798420
	public bool UnregisterDynamicProperty(string name) { }

	// RVA: 0x1780CF0 Offset: 0x177CCF0 VA: 0x1780CF0
	public void NotifyMessage(bool start, IMessage msg, bool client_site, bool async) { }

	// RVA: 0x1799CB0 Offset: 0x1795CB0 VA: 0x1799CB0
	private int FindProperty(string name) { }

	// RVA: 0x1780B90 Offset: 0x177CB90 VA: 0x1780B90
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Contexts
internal class ContextCallbackObject : ContextBoundObject // TypeDefIndex: 844
{
	// Methods

	// RVA: 0x17998A4 Offset: 0x17958A4 VA: 0x17998A4
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x179989C Offset: 0x179589C VA: 0x179989C
	public void .ctor() { }
}

// Namespace: 
private class CrossContextChannel.ContextRestoreSink : IMessageSink // TypeDefIndex: 845
{
	// Fields
	private IMessageSink _next; // 0x10
	private Context _context; // 0x18
	private IMessage _call; // 0x20

	// Methods

	// RVA: 0x179A5A4 Offset: 0x17965A4 VA: 0x179A5A4
	public void .ctor(IMessageSink next, Context context, IMessage call) { }

	// RVA: 0x179A60C Offset: 0x179660C VA: 0x179A60C Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x179A8AC Offset: 0x17968AC VA: 0x179A8AC Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Contexts
internal class CrossContextChannel : IMessageSink // TypeDefIndex: 846
{
	// Methods

	// RVA: 0x1799E1C Offset: 0x1795E1C VA: 0x1799E1C Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x179A1D8 Offset: 0x17961D8 VA: 0x179A1D8 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x179A604 Offset: 0x1796604 VA: 0x179A604
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public sealed class CrossContextDelegate : MulticastDelegate // TypeDefIndex: 847
{
	// Methods

	// RVA: 0x179A8E4 Offset: 0x17968E4 VA: 0x179A8E4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x179A980 Offset: 0x1796980 VA: 0x179A980 Slot: 12
	public virtual void Invoke() { }
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContextAttribute // TypeDefIndex: 848
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void GetPropertiesForNewContext(IConstructionCallMessage msg);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsContextOK(Context ctx, IConstructionCallMessage msg);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContextProperty // TypeDefIndex: 849
{
	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void Freeze(Context newContext);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsNewContextOK(Context newCtx);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeClientContextSink // TypeDefIndex: 850
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetClientContextSink(IMessageSink nextSink);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeDynamicSink // TypeDefIndex: 851
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IDynamicMessageSink GetDynamicSink();
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeEnvoySink // TypeDefIndex: 852
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetEnvoySink(MarshalByRefObject obj, IMessageSink nextSink);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeObjectSink // TypeDefIndex: 853
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetObjectSink(MarshalByRefObject obj, IMessageSink nextSink);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IContributeServerContextSink // TypeDefIndex: 854
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink GetServerContextSink(IMessageSink nextSink);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IDynamicMessageSink // TypeDefIndex: 855
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void ProcessMessageFinish(IMessage replyMsg, bool bCliSide, bool bAsync);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void ProcessMessageStart(IMessage reqMsg, bool bCliSide, bool bAsync);
}

// Namespace: System.Runtime.Remoting.Contexts
[ComVisible(True)]
public interface IDynamicProperty // TypeDefIndex: 856
{
	// Properties
	public abstract string Name { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();
}
