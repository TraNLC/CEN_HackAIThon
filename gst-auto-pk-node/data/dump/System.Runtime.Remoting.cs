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

// Namespace: System.Runtime.Remoting
[Serializable]
internal class ChannelInfo : IChannelInfo // TypeDefIndex: 795
{
	// Fields
	private object[] channelData; // 0x10

	// Properties
	public object[] ChannelData { get; }

	// Methods

	// RVA: 0x17801CC Offset: 0x177C1CC VA: 0x17801CC
	public void .ctor() { }

	// RVA: 0x1780708 Offset: 0x177C708 VA: 0x1780708
	public void .ctor(object remoteChannelData) { }

	// RVA: 0x17807C4 Offset: 0x177C7C4 VA: 0x17807C4 Slot: 4
	public object[] get_ChannelData() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class ActivatedClientTypeEntry : TypeEntry // TypeDefIndex: 796
{
	// Fields
	private string applicationUrl; // 0x20
	private Type obj_type; // 0x28

	// Properties
	public string ApplicationUrl { get; }
	public IContextAttribute[] ContextAttributes { get; }
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x17807CC Offset: 0x177C7CC VA: 0x17807CC
	public void .ctor(string typeName, string assemblyName, string appUrl) { }

	// RVA: 0x1780914 Offset: 0x177C914 VA: 0x1780914
	public string get_ApplicationUrl() { }

	// RVA: 0x178091C Offset: 0x177C91C VA: 0x178091C
	public IContextAttribute[] get_ContextAttributes() { }

	// RVA: 0x1780924 Offset: 0x177C924 VA: 0x1780924
	public Type get_ObjectType() { }

	// RVA: 0x178092C Offset: 0x177C92C VA: 0x178092C Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class ActivatedServiceTypeEntry : TypeEntry // TypeDefIndex: 797
{
	// Fields
	private Type obj_type; // 0x20

	// Properties
	public Type ObjectType { get; }

	// Methods

	// RVA: 0x1780940 Offset: 0x177C940 VA: 0x1780940
	public void .ctor(string typeName, string assemblyName) { }

	// RVA: 0x1780A5C Offset: 0x177CA5C VA: 0x1780A5C
	public Type get_ObjectType() { }

	// RVA: 0x1780A64 Offset: 0x177CA64 VA: 0x1780A64 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public enum CustomErrorsModes // TypeDefIndex: 798
{
	// Fields
	public int value__; // 0x0
	public const CustomErrorsModes On = 0;
	public const CustomErrorsModes Off = 1;
	public const CustomErrorsModes RemoteOnly = 2;
}

// Namespace: System.Runtime.Remoting
[Serializable]
internal class EnvoyInfo : IEnvoyInfo // TypeDefIndex: 799
{
	// Fields
	private IMessageSink envoySinks; // 0x10

	// Properties
	public IMessageSink EnvoySinks { get; }

	// Methods

	// RVA: 0x1780A74 Offset: 0x177CA74 VA: 0x1780A74
	public void .ctor(IMessageSink sinks) { }

	// RVA: 0x1780AA4 Offset: 0x177CAA4 VA: 0x1780AA4 Slot: 4
	public IMessageSink get_EnvoySinks() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public interface IChannelInfo // TypeDefIndex: 800
{
	// Properties
	public abstract object[] ChannelData { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract object[] get_ChannelData();
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public interface IEnvoyInfo // TypeDefIndex: 801
{
	// Properties
	public abstract IMessageSink EnvoySinks { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IMessageSink get_EnvoySinks();
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public interface IRemotingTypeInfo // TypeDefIndex: 802
{
	// Properties
	public abstract string TypeName { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_TypeName();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanCastTo(Type fromType, object o);
}

// Namespace: System.Runtime.Remoting
internal abstract class Identity // TypeDefIndex: 803
{
	// Fields
	protected string _objectUri; // 0x10
	protected IMessageSink _channelSink; // 0x18
	protected IMessageSink _envoySink; // 0x20
	private DynamicPropertyCollection _clientDynamicProperties; // 0x28
	private DynamicPropertyCollection _serverDynamicProperties; // 0x30
	protected ObjRef _objRef; // 0x38
	private bool _disposed; // 0x40

	// Properties
	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }

	// Methods

	// RVA: 0x1780AAC Offset: 0x177CAAC VA: 0x1780AAC
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType);

	// RVA: 0x1780ADC Offset: 0x177CADC VA: 0x1780ADC
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x1780AE4 Offset: 0x177CAE4 VA: 0x1780AE4
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x1780AEC Offset: 0x177CAEC VA: 0x1780AEC
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x1780AF4 Offset: 0x177CAF4 VA: 0x1780AF4
	public string get_ObjectUri() { }

	// RVA: 0x1780AFC Offset: 0x177CAFC VA: 0x1780AFC
	public void set_ObjectUri(string value) { }

	// RVA: 0x1780B04 Offset: 0x177CB04 VA: 0x1780B04
	public bool get_IsConnected() { }

	// RVA: 0x1780B14 Offset: 0x177CB14 VA: 0x1780B14
	public bool get_Disposed() { }

	// RVA: 0x1780B1C Offset: 0x177CB1C VA: 0x1780B1C
	public void set_Disposed(bool value) { }

	// RVA: 0x1780B24 Offset: 0x177CB24 VA: 0x1780B24
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x1780BFC Offset: 0x177CBFC VA: 0x1780BFC
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x1780C6C Offset: 0x177CC6C VA: 0x1780C6C
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x17812CC Offset: 0x177D2CC VA: 0x17812CC
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }
}

// Namespace: System.Runtime.Remoting
internal class ClientIdentity : Identity // TypeDefIndex: 804
{
	// Fields
	private WeakReference _proxyReference; // 0x48

	// Properties
	public MarshalByRefObject ClientProxy { get; set; }
	public string TargetUri { get; }

	// Methods

	// RVA: 0x1781350 Offset: 0x177D350 VA: 0x1781350
	public void .ctor(string objectUri, ObjRef objRef) { }

	// RVA: 0x1781480 Offset: 0x177D480 VA: 0x1781480
	public MarshalByRefObject get_ClientProxy() { }

	// RVA: 0x1781508 Offset: 0x177D508 VA: 0x1781508
	public void set_ClientProxy(MarshalByRefObject value) { }

	// RVA: 0x1781578 Offset: 0x177D578 VA: 0x1781578 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x1781580 Offset: 0x177D580 VA: 0x1781580
	public string get_TargetUri() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class InternalRemotingServices // TypeDefIndex: 805
{
	// Fields
	private static Hashtable _soapAttributes; // 0x0

	// Methods

	// RVA: 0x178159C Offset: 0x177D59C VA: 0x178159C
	public static SoapAttribute GetCachedSoapAttribute(object reflectionObject) { }

	// RVA: 0x1781AA4 Offset: 0x177DAA4 VA: 0x1781AA4
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
[Serializable]
public class ObjRef : IObjectReference, ISerializable // TypeDefIndex: 806
{
	// Fields
	private IChannelInfo channel_info; // 0x10
	private string uri; // 0x18
	private IRemotingTypeInfo typeInfo; // 0x20
	private IEnvoyInfo envoyInfo; // 0x28
	private int flags; // 0x30
	private Type _serverType; // 0x38
	private static int MarshalledObjectRef; // 0x0
	private static int WellKnowObjectRef; // 0x4

	// Properties
	internal bool IsReferenceToWellKnow { get; }
	public virtual IChannelInfo ChannelInfo { get; }
	public virtual IEnvoyInfo EnvoyInfo { get; set; }
	public virtual IRemotingTypeInfo TypeInfo { get; set; }
	public virtual string URI { get; set; }
	internal Type ServerType { get; }

	// Methods

	// RVA: 0x1781B20 Offset: 0x177DB20 VA: 0x1781B20
	public void .ctor() { }

	// RVA: 0x1781B98 Offset: 0x177DB98 VA: 0x1781B98
	internal void .ctor(string uri, IChannelInfo cinfo) { }

	// RVA: 0x1781BDC Offset: 0x177DBDC VA: 0x1781BDC
	internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo) { }

	// RVA: 0x1781E5C Offset: 0x177DE5C VA: 0x1781E5C
	internal byte[] SerializeType() { }

	// RVA: 0x1781FC8 Offset: 0x177DFC8 VA: 0x1781FC8
	internal void .ctor(Type type, string url, object remoteChannelData) { }

	// RVA: 0x17824FC Offset: 0x177E4FC VA: 0x17824FC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1782A7C Offset: 0x177EA7C VA: 0x1782A7C
	internal bool get_IsReferenceToWellKnow() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1782AE4 Offset: 0x177EAE4 VA: 0x1782AE4 Slot: 6
	public virtual IChannelInfo get_ChannelInfo() { }

	// RVA: 0x1782AEC Offset: 0x177EAEC VA: 0x1782AEC Slot: 7
	public virtual IEnvoyInfo get_EnvoyInfo() { }

	// RVA: 0x1782AF4 Offset: 0x177EAF4 VA: 0x1782AF4 Slot: 8
	public virtual void set_EnvoyInfo(IEnvoyInfo value) { }

	// RVA: 0x1782AFC Offset: 0x177EAFC VA: 0x1782AFC Slot: 9
	public virtual IRemotingTypeInfo get_TypeInfo() { }

	// RVA: 0x1782B04 Offset: 0x177EB04 VA: 0x1782B04 Slot: 10
	public virtual void set_TypeInfo(IRemotingTypeInfo value) { }

	// RVA: 0x1782B0C Offset: 0x177EB0C VA: 0x1782B0C Slot: 11
	public virtual string get_URI() { }

	// RVA: 0x1782B14 Offset: 0x177EB14 VA: 0x1782B14 Slot: 12
	public virtual void set_URI(string value) { }

	// RVA: 0x1782B1C Offset: 0x177EB1C VA: 0x1782B1C Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1782CE8 Offset: 0x177ECE8 VA: 0x1782CE8 Slot: 14
	public virtual object GetRealObject(StreamingContext context) { }

	// RVA: 0x1781B3C Offset: 0x177DB3C VA: 0x1781B3C
	internal void UpdateChannelInfo() { }

	// RVA: 0x1782DE4 Offset: 0x177EDE4 VA: 0x1782DE4
	internal Type get_ServerType() { }

	// RVA: 0x1782F28 Offset: 0x177EF28 VA: 0x1782F28
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public static class RemotingConfiguration // TypeDefIndex: 807
{
	// Fields
	private static string applicationID; // 0x0
	private static string applicationName; // 0x8
	private static string processGuid; // 0x10
	private static bool defaultConfigRead; // 0x18
	private static bool defaultDelayedConfigRead; // 0x19
	private static CustomErrorsModes _errorMode; // 0x1C
	private static Hashtable wellKnownClientEntries; // 0x20
	private static Hashtable activatedClientEntries; // 0x28
	private static Hashtable wellKnownServiceEntries; // 0x30
	private static Hashtable activatedServiceEntries; // 0x38
	private static Hashtable channelTemplates; // 0x40
	private static Hashtable clientProviderTemplates; // 0x48
	private static Hashtable serverProviderTemplates; // 0x50

	// Properties
	public static string ApplicationName { get; set; }
	public static string ProcessId { get; }

	// Methods

	// RVA: 0x1782F78 Offset: 0x177EF78 VA: 0x1782F78
	public static string get_ApplicationName() { }

	// RVA: 0x1782FD0 Offset: 0x177EFD0 VA: 0x1782FD0
	public static void set_ApplicationName(string value) { }

	// RVA: 0x1783030 Offset: 0x177F030 VA: 0x1783030
	public static string get_ProcessId() { }

	// RVA: 0x17830DC Offset: 0x177F0DC VA: 0x17830DC
	internal static void LoadDefaultDelayedChannels() { }

	// RVA: 0x17834A8 Offset: 0x177F4A8 VA: 0x17834A8
	public static bool IsActivationAllowed(Type svrType) { }

	// RVA: 0x17835F0 Offset: 0x177F5F0 VA: 0x17835F0
	public static ActivatedClientTypeEntry IsRemotelyActivatedClientType(Type svrType) { }

	// RVA: 0x1783788 Offset: 0x177F788 VA: 0x1783788
	public static WellKnownClientTypeEntry IsWellKnownClientType(Type svrType) { }

	// RVA: 0x1783920 Offset: 0x177F920 VA: 0x1783920
	public static void RegisterActivatedClientType(ActivatedClientTypeEntry entry) { }

	// RVA: 0x1783BA4 Offset: 0x177FBA4 VA: 0x1783BA4
	public static void RegisterActivatedServiceType(ActivatedServiceTypeEntry entry) { }

	// RVA: 0x1783CEC Offset: 0x177FCEC VA: 0x1783CEC
	public static void RegisterWellKnownClientType(WellKnownClientTypeEntry entry) { }

	// RVA: 0x1783F6C Offset: 0x177FF6C VA: 0x1783F6C
	public static void RegisterWellKnownServiceType(WellKnownServiceTypeEntry entry) { }

	// RVA: 0x17841EC Offset: 0x17801EC VA: 0x17841EC
	internal static void RegisterChannelTemplate(ChannelData channel) { }

	// RVA: 0x1784268 Offset: 0x1780268 VA: 0x1784268
	internal static void RegisterClientProviderTemplate(ProviderData prov) { }

	// RVA: 0x17842E4 Offset: 0x17802E4 VA: 0x17842E4
	internal static void RegisterServerProviderTemplate(ProviderData prov) { }

	// RVA: 0x1784360 Offset: 0x1780360 VA: 0x1784360
	internal static void RegisterChannels(ArrayList channels, bool onlyDelayed) { }

	// RVA: 0x1786BD8 Offset: 0x1782BD8 VA: 0x1786BD8
	internal static void RegisterTypes(ArrayList types) { }

	// RVA: 0x17870C4 Offset: 0x17830C4 VA: 0x17870C4
	public static bool CustomErrorsEnabled(bool isLocalRequest) { }

	// RVA: 0x178715C Offset: 0x178315C VA: 0x178715C
	internal static void SetCustomErrorsMode(string mode) { }

	// RVA: 0x1787390 Offset: 0x1783390 VA: 0x1787390
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting
internal class ConfigHandler : SmallXmlParser.IContentHandler // TypeDefIndex: 808
{
	// Fields
	private ArrayList typeEntries; // 0x10
	private ArrayList channelInstances; // 0x18
	private ChannelData currentChannel; // 0x20
	private Stack currentProviderData; // 0x28
	private string currentClientUrl; // 0x30
	private string appName; // 0x38
	private string currentXmlPath; // 0x40
	private bool onlyDelayedChannels; // 0x48

	// Methods

	// RVA: 0x17833DC Offset: 0x177F3DC VA: 0x17833DC
	public void .ctor(bool onlyDelayedChannels) { }

	// RVA: 0x178754C Offset: 0x178354C VA: 0x178754C
	private void ValidatePath(string element, string[] paths) { }

	// RVA: 0x1787628 Offset: 0x1783628 VA: 0x1787628
	private bool CheckPath(string path) { }

	// RVA: 0x1787708 Offset: 0x1783708 VA: 0x1787708 Slot: 4
	public void OnStartParsing(SmallXmlParser parser) { }

	// RVA: 0x178770C Offset: 0x178370C VA: 0x178770C Slot: 8
	public void OnProcessingInstruction(string name, string text) { }

	// RVA: 0x1787710 Offset: 0x1783710 VA: 0x1787710 Slot: 10
	public void OnIgnorableWhitespace(string s) { }

	// RVA: 0x1787714 Offset: 0x1783714 VA: 0x1787714 Slot: 6
	public void OnStartElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x17878D4 Offset: 0x17838D4 VA: 0x17878D4
	public void ParseElement(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x178A134 Offset: 0x1786134 VA: 0x178A134 Slot: 7
	public void OnEndElement(string name) { }

	// RVA: 0x17887C8 Offset: 0x17847C8 VA: 0x17887C8
	private void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1788B24 Offset: 0x1784B24 VA: 0x1788B24
	private void ReadLifetine(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x178A28C Offset: 0x178628C VA: 0x178A28C
	private TimeSpan ParseTime(string s) { }

	// RVA: 0x1789074 Offset: 0x1785074 VA: 0x1789074
	private void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0x1789438 Offset: 0x1785438 VA: 0x1789438
	private ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate) { }

	// RVA: 0x1789B14 Offset: 0x1785B14 VA: 0x1789B14
	private void ReadClientActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1789C58 Offset: 0x1785C58 VA: 0x1789C58
	private void ReadServiceActivated(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x178983C Offset: 0x178583C VA: 0x178983C
	private void ReadClientWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1789930 Offset: 0x1785930 VA: 0x1789930
	private void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x1789D24 Offset: 0x1785D24 VA: 0x1789D24
	private void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement) { }

	// RVA: 0x1789EC8 Offset: 0x1785EC8 VA: 0x1789EC8
	private void ReadPreload(SmallXmlParser.IAttrList attrs) { }

	// RVA: 0x178A884 Offset: 0x1786884 VA: 0x178A884
	private string GetNotNull(SmallXmlParser.IAttrList attrs, string name) { }

	// RVA: 0x178A9B4 Offset: 0x17869B4 VA: 0x178A9B4
	private string ExtractAssembly(ref string type) { }

	// RVA: 0x178B5C4 Offset: 0x17875C4 VA: 0x178B5C4 Slot: 9
	public void OnChars(string ch) { }

	// RVA: 0x178B5C8 Offset: 0x17875C8 VA: 0x178B5C8 Slot: 5
	public void OnEndParsing(SmallXmlParser parser) { }
}

// Namespace: System.Runtime.Remoting
internal class ChannelData // TypeDefIndex: 809
{
	// Fields
	internal string Ref; // 0x10
	internal string Type; // 0x18
	internal string Id; // 0x20
	internal string DelayLoadAsClientChannel; // 0x28
	private ArrayList _serverProviders; // 0x30
	private ArrayList _clientProviders; // 0x38
	private Hashtable _customProperties; // 0x40

	// Properties
	internal ArrayList ServerProviders { get; }
	public ArrayList ClientProviders { get; }
	public Hashtable CustomProperties { get; }

	// Methods

	// RVA: 0x17857C0 Offset: 0x17817C0 VA: 0x17857C0
	internal ArrayList get_ServerProviders() { }

	// RVA: 0x1785EE0 Offset: 0x1781EE0 VA: 0x1785EE0
	public ArrayList get_ClientProviders() { }

	// RVA: 0x178A7A4 Offset: 0x17867A4 VA: 0x178A7A4
	public Hashtable get_CustomProperties() { }

	// RVA: 0x1784F18 Offset: 0x1780F18 VA: 0x1784F18
	public void CopyFrom(ChannelData other) { }

	// RVA: 0x178A6D4 Offset: 0x17866D4 VA: 0x178A6D4
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting
internal class ProviderData // TypeDefIndex: 810
{
	// Fields
	internal string Ref; // 0x10
	internal string Type; // 0x18
	internal string Id; // 0x20
	internal Hashtable CustomProperties; // 0x28
	internal IList CustomData; // 0x30

	// Methods

	// RVA: 0x1785830 Offset: 0x1781830 VA: 0x1785830
	public void CopyFrom(ProviderData other) { }

	// RVA: 0x178A818 Offset: 0x1786818 VA: 0x178A818
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting
internal class FormatterData : ProviderData // TypeDefIndex: 811
{
	// Methods

	// RVA: 0x178A814 Offset: 0x1786814 VA: 0x178A814
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
[Serializable]
public class RemotingException : SystemException // TypeDefIndex: 812
{
	// Methods

	// RVA: 0x178B6C4 Offset: 0x17876C4 VA: 0x178B6C4
	public void .ctor() { }

	// RVA: 0x178090C Offset: 0x177C90C VA: 0x178090C
	public void .ctor(string message) { }

	// RVA: 0x178B6CC Offset: 0x17876CC VA: 0x178B6CC
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x17887C0 Offset: 0x17847C0 VA: 0x17887C0
	public void .ctor(string message, Exception InnerException) { }
}

// Namespace: 
[Serializable]
private class RemotingServices.CACD // TypeDefIndex: 813
{
	// Fields
	public object d; // 0x10
	public object c; // 0x18

	// Methods

	// RVA: 0x178FC30 Offset: 0x178BC30 VA: 0x178FC30
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public static class RemotingServices // TypeDefIndex: 814
{
	// Fields
	private static Hashtable uri_hash; // 0x0
	private static BinaryFormatter _serializationFormatter; // 0x8
	private static BinaryFormatter _deserializationFormatter; // 0x10
	private static string app_id; // 0x18
	private static readonly object app_id_lock; // 0x20
	private static int next_id; // 0x28
	private static readonly MethodInfo FieldSetterMethod; // 0x30
	private static readonly MethodInfo FieldGetterMethod; // 0x38

	// Methods

	// RVA: 0x178B6D4 Offset: 0x17876D4 VA: 0x178B6D4
	private static void .cctor() { }

	// RVA: 0x178B9F0 Offset: 0x17879F0 VA: 0x178B9F0
	internal static object InternalExecute(MethodBase method, object obj, object[] parameters, out object[] out_args) { }

	// RVA: 0x178B9F4 Offset: 0x17879F4 VA: 0x178B9F4
	internal static MethodBase GetVirtualMethod(Type type, MethodBase method) { }

	// RVA: 0x178B9F8 Offset: 0x17879F8 VA: 0x178B9F8
	public static bool IsTransparentProxy(object proxy) { }

	// RVA: 0x178BA30 Offset: 0x1787A30 VA: 0x178BA30
	internal static IMethodReturnMessage InternalExecuteMessage(MarshalByRefObject target, IMethodCallMessage reqMsg) { }

	[ComVisible(True)]
	// RVA: 0x178C448 Offset: 0x1788448 VA: 0x178C448
	public static object Connect(Type classToProxy, string url) { }

	[ComVisible(True)]
	// RVA: 0x178C550 Offset: 0x1788550 VA: 0x178C550
	public static object Connect(Type classToProxy, string url, object data) { }

	// RVA: 0x178C5F0 Offset: 0x17885F0 VA: 0x178C5F0
	public static Type GetServerTypeForUri(string URI) { }

	// RVA: 0x1782D8C Offset: 0x177ED8C VA: 0x1782D8C
	public static object Unmarshal(ObjRef objectRef) { }

	// RVA: 0x178C8F0 Offset: 0x17888F0 VA: 0x178C8F0
	public static object Unmarshal(ObjRef objectRef, bool fRefine) { }

	// RVA: 0x178CF48 Offset: 0x1788F48 VA: 0x178CF48
	public static ObjRef Marshal(MarshalByRefObject Obj) { }

	// RVA: 0x178CF8C Offset: 0x1788F8C VA: 0x178CF8C
	public static ObjRef Marshal(MarshalByRefObject Obj, string ObjURI, Type RequestedType) { }

	// RVA: 0x178D0E0 Offset: 0x17890E0 VA: 0x178D0E0
	private static string NewUri() { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x178CFF8 Offset: 0x1788FF8 VA: 0x178CFF8
	public static RealProxy GetRealProxy(object proxy) { }

	// RVA: 0x178DB94 Offset: 0x1789B94 VA: 0x178DB94
	public static MethodBase GetMethodBaseFromMethodMessage(IMethodMessage msg) { }

	// RVA: 0x178DE70 Offset: 0x1789E70 VA: 0x178DE70
	internal static MethodBase GetMethodBaseFromName(Type type, string methodName, Type[] signature) { }

	// RVA: 0x178E044 Offset: 0x178A044 VA: 0x178E044
	private static MethodBase FindInterfaceMethod(Type type, string methodName, Type[] signature) { }

	// RVA: 0x178E188 Offset: 0x178A188 VA: 0x178E188
	public static void GetObjectData(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x178E268 Offset: 0x178A268 VA: 0x178E268
	public static bool IsOneWay(MethodBase method) { }

	// RVA: 0x178E2EC Offset: 0x178A2EC VA: 0x178E2EC
	internal static object CreateClientProxy(ActivatedClientTypeEntry entry, object[] activationAttributes) { }

	// RVA: 0x178E3E8 Offset: 0x178A3E8 VA: 0x178E3E8
	internal static object CreateClientProxy(Type objectType, string url, object[] activationAttributes) { }

	// RVA: 0x178E648 Offset: 0x178A648 VA: 0x178E648
	internal static object CreateClientProxy(WellKnownClientTypeEntry entry) { }

	// RVA: 0x178E6B0 Offset: 0x178A6B0 VA: 0x178E6B0
	internal static object CreateClientProxyForContextBound(Type type, object[] activationAttributes) { }

	// RVA: 0x178C698 Offset: 0x1788698 VA: 0x178C698
	internal static Identity GetIdentityForUri(string uri) { }

	// RVA: 0x178E898 Offset: 0x178A898 VA: 0x178E898
	private static string RemoveAppNameFromUri(string uri) { }

	// RVA: 0x178E98C Offset: 0x178A98C VA: 0x178E98C
	internal static ClientIdentity GetOrCreateClientIdentity(ObjRef objRef, Type proxyType, out object clientProxy) { }

	// RVA: 0x178E518 Offset: 0x178A518 VA: 0x178E518
	private static IMessageSink GetClientChannelSinkChain(string url, object channelData, out string objectUri) { }

	// RVA: 0x178F8A8 Offset: 0x178B8A8 VA: 0x178F8A8
	internal static ClientActivatedIdentity CreateContextBoundObjectIdentity(Type objectType) { }

	// RVA: 0x178DAD8 Offset: 0x1789AD8 VA: 0x178DAD8
	internal static ClientActivatedIdentity CreateClientActivatedServerIdentity(MarshalByRefObject realObject, Type objectType, string objectUri) { }

	// RVA: 0x17840F8 Offset: 0x17800F8 VA: 0x17840F8
	internal static ServerIdentity CreateWellKnownServerIdentity(Type objectType, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x178D414 Offset: 0x1789414 VA: 0x178D414
	private static void RegisterServerIdentity(ServerIdentity identity) { }

	// RVA: 0x178CE54 Offset: 0x1788E54 VA: 0x178CE54
	internal static object GetProxyForRemoteObject(ObjRef objref, Type classToProxy) { }

	// RVA: 0x178C4DC Offset: 0x17884DC VA: 0x178C4DC
	internal static object GetRemoteObject(ObjRef objRef, Type proxyType) { }

	// RVA: 0x178FA14 Offset: 0x178BA14 VA: 0x178FA14
	internal static byte[] SerializeCallData(object obj) { }

	// RVA: 0x178FC38 Offset: 0x178BC38 VA: 0x178FC38
	internal static object DeserializeCallData(byte[] array) { }

	// RVA: 0x178FE84 Offset: 0x178BE84 VA: 0x178FE84
	internal static byte[] SerializeExceptionData(Exception ex) { }

	// RVA: 0x178B9A4 Offset: 0x17879A4 VA: 0x178B9A4
	private static void RegisterInternalChannels() { }

	// RVA: 0x178EE8C Offset: 0x178AE8C VA: 0x178EE8C
	internal static void DisposeIdentity(Identity ident) { }

	// RVA: 0x1790134 Offset: 0x178C134 VA: 0x1790134
	internal static Identity GetMessageTargetIdentity(IMessage msg) { }

	// RVA: 0x1790480 Offset: 0x178C480 VA: 0x1790480
	internal static void SetMessageTargetIdentity(IMessage msg, Identity ident) { }

	// RVA: 0x1790594 Offset: 0x178C594 VA: 0x1790594
	internal static bool UpdateOutArgObject(ParameterInfo pi, object local, object remote) { }

	// RVA: 0x178E820 Offset: 0x178A820 VA: 0x178E820
	private static string GetNormalizedUri(string uri) { }
}

// Namespace: System.Runtime.Remoting
internal abstract class ServerIdentity : Identity // TypeDefIndex: 815
{
	// Fields
	protected Type _objectType; // 0x48
	protected MarshalByRefObject _serverObject; // 0x50
	protected IMessageSink _serverSink; // 0x58
	protected Context _context; // 0x60
	protected Lease _lease; // 0x68

	// Properties
	public Type ObjectType { get; }
	public Lease Lease { get; }
	public Context Context { get; set; }

	// Methods

	// RVA: 0x17906CC Offset: 0x178C6CC VA: 0x17906CC
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x179072C Offset: 0x178C72C VA: 0x179072C
	public Type get_ObjectType() { }

	// RVA: 0x178D61C Offset: 0x178961C VA: 0x178D61C
	public void StartTrackingLifetime(ILease lease) { }

	// RVA: 0x17908F4 Offset: 0x178C8F4 VA: 0x17908F4 Slot: 5
	public virtual void OnLifetimeExpired() { }

	// RVA: 0x17909A0 Offset: 0x178C9A0 VA: 0x17909A0 Slot: 4
	public override ObjRef CreateObjRef(Type requestedType) { }

	// RVA: 0x178F998 Offset: 0x178B998 VA: 0x178F998
	public void AttachServerObject(MarshalByRefObject serverObject, Context context) { }

	// RVA: 0x1790D54 Offset: 0x178CD54 VA: 0x1790D54
	public Lease get_Lease() { }

	// RVA: 0x1790D5C Offset: 0x178CD5C VA: 0x1790D5C
	public Context get_Context() { }

	// RVA: 0x1790D64 Offset: 0x178CD64 VA: 0x1790D64
	public void set_Context(Context value) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract IMessage SyncObjectProcessMessage(IMessage msg);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink);

	// RVA: 0x17908F8 Offset: 0x178C8F8 VA: 0x17908F8
	protected void DisposeServerObject() { }
}

// Namespace: System.Runtime.Remoting
internal class ClientActivatedIdentity : ServerIdentity // TypeDefIndex: 816
{
	// Fields
	private MarshalByRefObject _targetThis; // 0x70

	// Methods

	// RVA: 0x178F984 Offset: 0x178B984 VA: 0x178F984
	public void .ctor(string objectUri, Type objectType) { }

	// RVA: 0x1791070 Offset: 0x178D070 VA: 0x1791070
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x1791078 Offset: 0x178D078 VA: 0x1791078
	public void SetClientProxy(MarshalByRefObject obj) { }

	// RVA: 0x1791080 Offset: 0x178D080 VA: 0x1791080 Slot: 5
	public override void OnLifetimeExpired() { }

	// RVA: 0x17910DC Offset: 0x178D0DC VA: 0x17910DC Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x179138C Offset: 0x178D38C VA: 0x179138C Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting
internal class SingletonIdentity : ServerIdentity // TypeDefIndex: 817
{
	// Methods

	// RVA: 0x178FA10 Offset: 0x178BA10 VA: 0x178FA10
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x179148C Offset: 0x178D48C VA: 0x179148C
	public MarshalByRefObject GetServerObject() { }

	// RVA: 0x1791624 Offset: 0x178D624 VA: 0x1791624 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x179170C Offset: 0x178D70C VA: 0x179170C Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting
internal class SingleCallIdentity : ServerIdentity // TypeDefIndex: 818
{
	// Methods

	// RVA: 0x178FA0C Offset: 0x178BA0C VA: 0x178FA0C
	public void .ctor(string objectUri, Context context, Type objectType) { }

	// RVA: 0x1791800 Offset: 0x178D800 VA: 0x1791800 Slot: 6
	public override IMessage SyncObjectProcessMessage(IMessage msg) { }

	// RVA: 0x1791A20 Offset: 0x178DA20 VA: 0x1791A20 Slot: 7
	public override IMessageCtrl AsyncObjectProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: System.Runtime.Remoting
internal class DisposerReplySink : IMessageSink // TypeDefIndex: 819
{
	// Fields
	private IMessageSink _next; // 0x10
	private IDisposable _disposable; // 0x18

	// Methods

	// RVA: 0x1791BD8 Offset: 0x178DBD8 VA: 0x1791BD8
	public void .ctor(IMessageSink next, IDisposable disposable) { }

	// RVA: 0x1791C1C Offset: 0x178DC1C VA: 0x1791C1C Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1791D38 Offset: 0x178DD38 VA: 0x1791D38 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }
}

// Namespace: 
private class SoapServices.TypeInfo // TypeDefIndex: 820
{
	// Fields
	public Hashtable Attributes; // 0x10
	public Hashtable Elements; // 0x18

	// Methods

	// RVA: 0x1792508 Offset: 0x178E508 VA: 0x1792508
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class SoapServices // TypeDefIndex: 821
{
	// Fields
	private static Hashtable _xmlTypes; // 0x0
	private static Hashtable _xmlElements; // 0x8
	private static Hashtable _soapActions; // 0x10
	private static Hashtable _soapActionsMethods; // 0x18
	private static Hashtable _typeInfos; // 0x20

	// Properties
	public static string XmlNsForClrTypeWithAssembly { get; }
	public static string XmlNsForClrTypeWithNs { get; }
	public static string XmlNsForClrTypeWithNsAndAssembly { get; }

	// Methods

	// RVA: 0x1791D70 Offset: 0x178DD70 VA: 0x1791D70
	public static string get_XmlNsForClrTypeWithAssembly() { }

	// RVA: 0x1791DB0 Offset: 0x178DDB0 VA: 0x1791DB0
	public static string get_XmlNsForClrTypeWithNs() { }

	// RVA: 0x1791DF0 Offset: 0x178DDF0 VA: 0x1791DF0
	public static string get_XmlNsForClrTypeWithNsAndAssembly() { }

	// RVA: 0x1791E30 Offset: 0x178DE30 VA: 0x1791E30
	public static string CodeXmlNamespaceForClrTypeNamespace(string typeNamespace, string assemblyName) { }

	// RVA: 0x17920A0 Offset: 0x178E0A0 VA: 0x17920A0
	private static string GetNameKey(string name, string namspace) { }

	// RVA: 0x1792108 Offset: 0x178E108 VA: 0x1792108
	private static string GetAssemblyName(MethodBase mb) { }

	// RVA: 0x17921F8 Offset: 0x178E1F8 VA: 0x17921F8
	public static bool GetXmlElementForInteropType(Type type, out string xmlElement, out string xmlNamespace) { }

	// RVA: 0x17922F4 Offset: 0x178E2F4 VA: 0x17922F4
	public static string GetXmlNamespaceForMethodCall(MethodBase mb) { }

	// RVA: 0x1792388 Offset: 0x178E388 VA: 0x1792388
	public static string GetXmlNamespaceForMethodResponse(MethodBase mb) { }

	// RVA: 0x179241C Offset: 0x178E41C VA: 0x179241C
	public static bool GetXmlTypeForInteropType(Type type, out string xmlType, out string xmlTypeNamespace) { }

	// RVA: 0x178B508 Offset: 0x1787508 VA: 0x178B508
	public static void PreLoad(Assembly assembly) { }

	// RVA: 0x178B02C Offset: 0x178702C VA: 0x178B02C
	public static void PreLoad(Type type) { }

	// RVA: 0x178AD04 Offset: 0x1786D04 VA: 0x178AD04
	public static void RegisterInteropXmlElement(string xmlElement, string xmlNamespace, Type type) { }

	// RVA: 0x178AE98 Offset: 0x1786E98 VA: 0x178AE98
	public static void RegisterInteropXmlType(string xmlType, string xmlTypeNamespace, Type type) { }

	// RVA: 0x1791FBC Offset: 0x178DFBC VA: 0x1791FBC
	private static string EncodeNs(string ns) { }

	// RVA: 0x1792510 Offset: 0x178E510 VA: 0x1792510
	private static void .cctor() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class TypeEntry // TypeDefIndex: 822
{
	// Fields
	private string assembly_name; // 0x10
	private string type_name; // 0x18

	// Properties
	public string AssemblyName { get; set; }
	public string TypeName { get; set; }

	// Methods

	// RVA: 0x1780904 Offset: 0x177C904 VA: 0x1780904
	protected void .ctor() { }

	// RVA: 0x179262C Offset: 0x178E62C VA: 0x179262C
	public string get_AssemblyName() { }

	// RVA: 0x1792634 Offset: 0x178E634 VA: 0x1792634
	public void set_AssemblyName(string value) { }

	// RVA: 0x179263C Offset: 0x178E63C VA: 0x179263C
	public string get_TypeName() { }

	// RVA: 0x1792644 Offset: 0x178E644 VA: 0x1792644
	public void set_TypeName(string value) { }
}

// Namespace: System.Runtime.Remoting
[Serializable]
internal class TypeInfo : IRemotingTypeInfo // TypeDefIndex: 823
{
	// Fields
	private string serverType; // 0x10
	private string[] serverHierarchy; // 0x18
	private string[] interfacesImplemented; // 0x20

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x17820DC Offset: 0x177E0DC VA: 0x17820DC
	public void .ctor(Type type) { }

	// RVA: 0x179264C Offset: 0x178E64C VA: 0x179264C Slot: 4
	public string get_TypeName() { }

	// RVA: 0x1792654 Offset: 0x178E654 VA: 0x1792654 Slot: 5
	public bool CanCastTo(Type fromType, object o) { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class WellKnownClientTypeEntry : TypeEntry // TypeDefIndex: 824
{
	// Fields
	private Type obj_type; // 0x20
	private string obj_url; // 0x28
	private string app_url; // 0x30

	// Properties
	public string ApplicationUrl { get; }
	public Type ObjectType { get; }
	public string ObjectUrl { get; }

	// Methods

	// RVA: 0x178AA80 Offset: 0x1786A80 VA: 0x178AA80
	public void .ctor(string typeName, string assemblyName, string objectUrl) { }

	// RVA: 0x17928A8 Offset: 0x178E8A8 VA: 0x17928A8
	public string get_ApplicationUrl() { }

	// RVA: 0x17928B0 Offset: 0x178E8B0 VA: 0x17928B0
	public Type get_ObjectType() { }

	// RVA: 0x17928B8 Offset: 0x178E8B8 VA: 0x17928B8
	public string get_ObjectUrl() { }

	// RVA: 0x17928C0 Offset: 0x178E8C0 VA: 0x17928C0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
[Serializable]
public enum WellKnownObjectMode // TypeDefIndex: 825
{
	// Fields
	public int value__; // 0x0
	public const WellKnownObjectMode Singleton = 1;
	public const WellKnownObjectMode SingleCall = 2;
}

// Namespace: System.Runtime.Remoting
[ComVisible(True)]
public class WellKnownServiceTypeEntry : TypeEntry // TypeDefIndex: 826
{
	// Fields
	private Type obj_type; // 0x20
	private string obj_uri; // 0x28
	private WellKnownObjectMode obj_mode; // 0x30

	// Properties
	public WellKnownObjectMode Mode { get; }
	public Type ObjectType { get; }
	public string ObjectUri { get; }

	// Methods

	// RVA: 0x178ABB8 Offset: 0x1786BB8 VA: 0x178ABB8
	public void .ctor(string typeName, string assemblyName, string objectUri, WellKnownObjectMode mode) { }

	// RVA: 0x17928E4 Offset: 0x178E8E4 VA: 0x17928E4
	public WellKnownObjectMode get_Mode() { }

	// RVA: 0x17928EC Offset: 0x178E8EC VA: 0x17928EC
	public Type get_ObjectType() { }

	// RVA: 0x17928F4 Offset: 0x178E8F4 VA: 0x17928F4
	public string get_ObjectUri() { }

	// RVA: 0x17928FC Offset: 0x178E8FC VA: 0x17928FC Slot: 3
	public override string ToString() { }
}
