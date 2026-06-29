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

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public sealed class ChannelServices // TypeDefIndex: 857
{
	// Fields
	private static ArrayList registeredChannels; // 0x0
	private static ArrayList delayedClientChannels; // 0x8
	private static CrossContextChannel _crossContextSink; // 0x10
	internal static string CrossContextUrl; // 0x18
	private static IList oldStartModeTypes; // 0x20

	// Properties
	internal static CrossContextChannel CrossContextChannel { get; }

	// Methods

	// RVA: 0x179A994 Offset: 0x1796994 VA: 0x179A994
	internal static CrossContextChannel get_CrossContextChannel() { }

	// RVA: 0x178F108 Offset: 0x178B108 VA: 0x178F108
	internal static IMessageSink CreateClientChannelSinkChain(string url, object remoteChannelData, out string objectUri) { }

	// RVA: 0x179A9EC Offset: 0x17969EC VA: 0x179A9EC
	internal static IMessageSink CreateClientChannelSinkChain(IChannelSender sender, string url, object[] channelDataArray, out string objectUri) { }

	[Obsolete("Use RegisterChannel(IChannel,Boolean)")]
	// RVA: 0x179AC14 Offset: 0x1796C14 VA: 0x179AC14
	public static void RegisterChannel(IChannel chnl) { }

	// RVA: 0x179AC6C Offset: 0x1796C6C VA: 0x179AC6C
	public static void RegisterChannel(IChannel chnl, bool ensureSecurity) { }

	// RVA: 0x1785F50 Offset: 0x1781F50 VA: 0x1785F50
	internal static void RegisterChannelConfig(ChannelData channel) { }

	// RVA: 0x179B47C Offset: 0x179747C VA: 0x179B47C
	private static object CreateProvider(ProviderData prov) { }

	// RVA: 0x179B780 Offset: 0x1797780 VA: 0x179B780
	public static IMessage SyncDispatchMessage(IMessage msg) { }

	// RVA: 0x179B828 Offset: 0x1797828 VA: 0x179B828
	private static ReturnMessage CheckIncomingMessage(IMessage msg) { }

	// RVA: 0x179BAC4 Offset: 0x1797AC4 VA: 0x179BAC4
	internal static IMessage CheckReturnMessage(IMessage callMsg, IMessage retMsg) { }

	// RVA: 0x179BC88 Offset: 0x1797C88 VA: 0x179BC88
	private static bool IsLocalCall(IMessage callMsg) { }

	// RVA: 0x1780238 Offset: 0x177C238 VA: 0x1780238
	internal static object[] GetCurrentChannelInfo() { }

	// RVA: 0x179BC90 Offset: 0x1797C90 VA: 0x179BC90
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting.Channels
[Serializable]
internal class CrossAppDomainData // TypeDefIndex: 858
{
	// Fields
	private object _ContextID; // 0x10
	private int _DomainID; // 0x18
	private string _processGuid; // 0x20

	// Properties
	internal int DomainID { get; }
	internal string ProcessID { get; }

	// Methods

	// RVA: 0x1781D14 Offset: 0x177DD14 VA: 0x1781D14
	internal void .ctor(int domainId) { }

	// RVA: 0x179BE4C Offset: 0x1797E4C VA: 0x179BE4C
	internal int get_DomainID() { }

	// RVA: 0x179BE54 Offset: 0x1797E54 VA: 0x179BE54
	internal string get_ProcessID() { }
}

// Namespace: System.Runtime.Remoting.Channels
[Serializable]
internal class CrossAppDomainChannel : IChannel, IChannelSender, IChannelReceiver // TypeDefIndex: 859
{
	// Fields
	private static object s_lock; // 0x0

	// Properties
	public virtual string ChannelName { get; }
	public virtual int ChannelPriority { get; }
	public virtual object ChannelData { get; }

	// Methods

	// RVA: 0x178FFF8 Offset: 0x178BFF8 VA: 0x178FFF8
	internal static void RegisterCrossAppDomainChannel() { }

	// RVA: 0x179BE64 Offset: 0x1797E64 VA: 0x179BE64 Slot: 9
	public virtual string get_ChannelName() { }

	// RVA: 0x179BEA4 Offset: 0x1797EA4 VA: 0x179BEA4 Slot: 10
	public virtual int get_ChannelPriority() { }

	// RVA: 0x179BEAC Offset: 0x1797EAC VA: 0x179BEAC Slot: 11
	public virtual object get_ChannelData() { }

	// RVA: 0x179BF10 Offset: 0x1797F10 VA: 0x179BF10 Slot: 12
	public virtual void StartListening(object data) { }

	// RVA: 0x179BF14 Offset: 0x1797F14 VA: 0x179BF14 Slot: 13
	public virtual IMessageSink CreateMessageSink(string url, object data, out string uri) { }

	// RVA: 0x179BE5C Offset: 0x1797E5C VA: 0x179BE5C
	public void .ctor() { }

	// RVA: 0x179C324 Offset: 0x1798324 VA: 0x179C324
	private static void .cctor() { }
}

// Namespace: 
private struct CrossAppDomainSink.ProcessMessageRes // TypeDefIndex: 860
{
	// Fields
	public byte[] arrResponse; // 0x0
	public CADMethodReturnMessage cadMrm; // 0x8
}

// Namespace: System.Runtime.Remoting.Channels
[MonoTODO("Handle domain unloading?")]
internal class CrossAppDomainSink : IMessageSink // TypeDefIndex: 861
{
	// Fields
	private static Hashtable s_sinks; // 0x0
	private static MethodInfo processMessageMethod; // 0x8
	private int _domainID; // 0x10

	// Properties
	internal int TargetDomainId { get; }

	// Methods

	// RVA: 0x179C3A0 Offset: 0x17983A0 VA: 0x179C3A0
	internal void .ctor(int domainID) { }

	// RVA: 0x179C098 Offset: 0x1798098 VA: 0x179C098
	internal static CrossAppDomainSink GetSink(int domainID) { }

	// RVA: 0x179C3C8 Offset: 0x17983C8 VA: 0x179C3C8
	internal int get_TargetDomainId() { }

	// RVA: 0x179C3D0 Offset: 0x17983D0 VA: 0x179C3D0
	private static CrossAppDomainSink.ProcessMessageRes ProcessMessageInDomain(byte[] arrRequest, CADMethodCallMessage cadMsg) { }

	// RVA: 0x179C62C Offset: 0x179862C VA: 0x179C62C Slot: 6
	public virtual IMessage SyncProcessMessage(IMessage msgRequest) { }

	// RVA: 0x179CAEC Offset: 0x1798AEC VA: 0x179CAEC Slot: 7
	public virtual IMessageCtrl AsyncProcessMessage(IMessage reqMsg, IMessageSink replySink) { }

	// RVA: 0x179CBF8 Offset: 0x1798BF8 VA: 0x179CBF8
	public void SendAsyncMessage(object data) { }

	// RVA: 0x179CD04 Offset: 0x1798D04 VA: 0x179CD04
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x179CE08 Offset: 0x1798E08 VA: 0x179CE08
	private void <AsyncProcessMessage>b__10_0(object data) { }
}

// Namespace: System.Runtime.Remoting.Channels
internal class CADSerializer // TypeDefIndex: 862
{
	// Methods

	// RVA: 0x179CAB4 Offset: 0x1798AB4 VA: 0x179CAB4
	internal static IMessage DeserializeMessage(MemoryStream mem, IMethodCallMessage msg) { }

	// RVA: 0x179C534 Offset: 0x1798534 VA: 0x179C534
	internal static MemoryStream SerializeMessage(IMessage msg) { }

	// RVA: 0x1781DC0 Offset: 0x177DDC0 VA: 0x1781DC0
	internal static object DeserializeObjectSafe(byte[] mem) { }

	// RVA: 0x1781ED0 Offset: 0x177DED0 VA: 0x1781ED0
	internal static MemoryStream SerializeObject(object obj) { }

	// RVA: 0x179CE88 Offset: 0x1798E88 VA: 0x179CE88
	internal static object DeserializeObject(MemoryStream mem) { }
}

// Namespace: System.Runtime.Remoting.Channels
internal class AsyncRequest // TypeDefIndex: 863
{
	// Fields
	internal IMessageSink ReplySink; // 0x10
	internal IMessage MsgRequest; // 0x18

	// Methods

	// RVA: 0x179CBB4 Offset: 0x1798BB4 VA: 0x179CBB4
	public void .ctor(IMessage msgRequest, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IChannel // TypeDefIndex: 864
{
	// Properties
	public abstract string ChannelName { get; }
	public abstract int ChannelPriority { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_ChannelName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_ChannelPriority();
}

// Namespace: System.Runtime.Remoting.Channels
[DefaultMember("Item")]
[ComVisible(True)]
public interface IChannelDataStore // TypeDefIndex: 865
{}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IChannelReceiver : IChannel // TypeDefIndex: 866
{
	// Properties
	public abstract object ChannelData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object get_ChannelData();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void StartListening(object data);
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IChannelSender : IChannel // TypeDefIndex: 867
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI);
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IClientChannelSinkProvider // TypeDefIndex: 868
{
	// Properties
	public abstract IClientChannelSinkProvider Next { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_Next(IClientChannelSinkProvider value);
}

// Namespace: System.Runtime.Remoting.Channels
public interface ISecurableChannel // TypeDefIndex: 869
{
	// Properties
	public abstract bool IsSecured { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_IsSecured(bool value);
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public interface IServerChannelSinkProvider // TypeDefIndex: 870
{
	// Properties
	public abstract IServerChannelSinkProvider Next { set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void set_Next(IServerChannelSinkProvider value);
}

// Namespace: System.Runtime.Remoting.Channels
[ComVisible(True)]
public class SinkProviderData // TypeDefIndex: 871
{
	// Fields
	private string sinkName; // 0x10
	private ArrayList children; // 0x18
	private Hashtable properties; // 0x20

	// Properties
	public IList Children { get; }
	public IDictionary Properties { get; }

	// Methods

	// RVA: 0x178A1CC Offset: 0x17861CC VA: 0x178A1CC
	public void .ctor(string name) { }

	// RVA: 0x179CF1C Offset: 0x1798F1C VA: 0x179CF1C
	public IList get_Children() { }

	// RVA: 0x179CF24 Offset: 0x1798F24 VA: 0x179CF24
	public IDictionary get_Properties() { }
}
