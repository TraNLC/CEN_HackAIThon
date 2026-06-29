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

// Namespace: game.network
public class NetCoreManager : MonoBehaviour // TypeDefIndex: 2503
{
	// Fields
	public const int protocolVersion = 20260605;
	private const int manualLayoutVersion = 250926;
	private const int autoplayVersion = 251026;
	public static NetCoreManager instance; // 0x0
	private readonly Dictionary<MSCode, MsMessageHandlers> listMsMessageHandlers; // 0x20
	private readonly Dictionary<int, GsMessageHandlers> listGsMessageHandlers; // 0x28
	private readonly ConcurrentQueue<NetCoreManager.MessageData> networkMessageQueue; // 0x30
	[HideInInspector]
	public NetworkClient socket; // 0x38
	[HideInInspector]
	public NetCoreManager.ServiceType serviceType; // 0x40
	[HideInInspector]
	public Action<NetCoreManager> onConnected; // 0x48
	[HideInInspector]
	public Action<NetCoreManager, NetCoreManager.MessageData> onMasterMessage; // 0x50
	[HideInInspector]
	public Action<NetCoreManager, NetCoreManager.MessageData> onGameServerMessage; // 0x58
	[HideInInspector]
	public Action<NetCoreManager> onDisconnected; // 0x60
	[HideInInspector]
	public Action<NetCoreManager, byte[]> onStringData; // 0x68
	private Stopwatch stopwatchOnLoadGameWorldScene; // 0x70
	private PlayerLoginResponse worldMap; // 0x78

	// Methods

	// RVA: 0xFE2DD8 Offset: 0xFDEDD8 VA: 0xFE2DD8
	public static void Initialize() { }

	// RVA: 0xFE2F00 Offset: 0xFDEF00 VA: 0xFE2F00
	private void Start() { }

	// RVA: 0xFE32DC Offset: 0xFDF2DC VA: 0xFE32DC
	private void Update() { }

	// RVA: 0xFE3500 Offset: 0xFDF500 VA: 0xFE3500
	private void OnDestroy() { }

	// RVA: 0xFE356C Offset: 0xFDF56C VA: 0xFE356C
	public void Connect(string serverIp, int serverPort) { }

	// RVA: 0xFE3D64 Offset: 0xFDFD64 VA: 0xFE3D64
	public void Connect(NetCoreManager.ProxySelectType proxySelectType) { }

	// RVA: 0xFE3BCC Offset: 0xFDFBCC VA: 0xFE3BCC
	private void StopConnection() { }

	// RVA: 0xFE3C28 Offset: 0xFDFC28 VA: 0xFE3C28
	private void StartConnection() { }

	// RVA: 0xFE3760 Offset: 0xFDF760 VA: 0xFE3760
	public bool IsLocalIPAddress(string ip) { }

	// RVA: 0xFE3504 Offset: 0xFDF504 VA: 0xFE3504
	public void Close() { }

	// RVA: 0xFE4578 Offset: 0xFE0578 VA: 0xFE4578
	private void OnHandlePackage(int messageId, byte[] messageBuffer) { }

	// RVA: 0xFE2F04 Offset: 0xFDEF04 VA: 0xFE2F04
	private void LoadHandles() { }

	// RVA: 0xFE4288 Offset: 0xFE0288 VA: 0xFE4288
	public void Disconnect() { }

	// RVA: 0xFE478C Offset: 0xFE078C VA: 0xFE478C
	public void LoadWorldSceneCompleted() { }

	[IteratorStateMachine(typeof(NetCoreManager.<LoadWorldSceneStart>d__32))]
	// RVA: 0xFE4870 Offset: 0xFE0870 VA: 0xFE4870
	private IEnumerator LoadWorldSceneStart(Action onStart) { }

	// RVA: 0xFE4920 Offset: 0xFE0920 VA: 0xFE4920
	public void EnterGameWorld(MSUnityEntergameResponse entergameMessage, Action onStart) { }

	// RVA: 0xFE4A7C Offset: 0xFE0A7C VA: 0xFE4A7C
	public void EnterGameServer(EnterGameServer message) { }

	// RVA: 0xFE3474 Offset: 0xFDF474 VA: 0xFE3474
	private void OnMSMessage(NetCoreManager.MessageData message) { }

	// RVA: 0xFE33E8 Offset: 0xFDF3E8 VA: 0xFE33E8
	private void OnGSMessage(NetCoreManager.MessageData message) { }

	// RVA: 0xFE4BA0 Offset: 0xFE0BA0 VA: 0xFE4BA0
	public static int GetCoreVersion() { }

	// RVA: 0xFE4BAC Offset: 0xFE0BAC VA: 0xFE4BAC
	public static int GetManualLayoutVersion() { }

	// RVA: 0xFE4BB8 Offset: 0xFE0BB8 VA: 0xFE4BB8
	public static int GetAutoplayVersion() { }

	// RVA: 0xFE4BC4 Offset: 0xFE0BC4 VA: 0xFE4BC4
	private void OnConnected() { }

	// RVA: 0xFE4BE4 Offset: 0xFE0BE4 VA: 0xFE4BE4
	private void OnDisconnected() { }

	// RVA: 0xFE4CFC Offset: 0xFE0CFC VA: 0xFE4CFC
	public void SetWorldMap(PlayerLoginResponse data) { }

	// RVA: 0xFE4D04 Offset: 0xFE0D04 VA: 0xFE4D04
	public PlayerLoginResponse GetWorldMap() { }

	// RVA: 0xFE4D0C Offset: 0xFE0D0C VA: 0xFE4D0C
	public void SendMSMessage(MSCode id, IMessage message) { }

	// RVA: 0xFE4D6C Offset: 0xFE0D6C VA: 0xFE4D6C
	public void SendGSMessage(Id id, byte[] message) { }

	// RVA: 0xFE4DCC Offset: 0xFE0DCC VA: 0xFE4DCC
	public void SendGSMessage(Id id, IMessage message) { }

	// RVA: 0xFE4E00 Offset: 0xFE0E00 VA: 0xFE4E00
	public void SendGSMessage(Id id) { }

	// RVA: 0xFE4E58 Offset: 0xFE0E58 VA: 0xFE4E58
	public void SendGSMessage(string stringData) { }

	// RVA: 0xFE4EB0 Offset: 0xFE0EB0 VA: 0xFE4EB0
	public void .ctor() { }
}

// Namespace: game.network
[NullableContext(1)]
[Nullable(0)]
public class Network32BitClient : TcpClient // TypeDefIndex: 2504
{
	// Fields
	private const ushort headerPacketByteCount = 6;
	private const ushort headerPacketMessageByteCount = 4;
	private const ushort headerPacketIdByteCount = 2;
	private readonly byte[] headerBuffered; // 0xB8
	private long headerLengthReaded; // 0xC0
	private long headerLengthRemaining; // 0xC8
	private uint messageLength; // 0xD0
	private ushort messageId; // 0xD4
	private long messageLengthReaded; // 0xD8
	private long messageLengthRemaining; // 0xE0
	private byte[] messageBuffer; // 0xE8

	// Methods

	// RVA: 0xFE5E84 Offset: 0xFE1E84 VA: 0xFE5E84
	public void .ctor(string address, int port) { }

	// RVA: 0xFE60F0 Offset: 0xFE20F0 VA: 0xFE60F0 Slot: 26
	protected override void OnReceived(byte[] buffer, long offset, long size) { }

	// RVA: 0xFE6290 Offset: 0xFE2290 VA: 0xFE6290 Slot: 31
	protected virtual void MessageReceived(ushort messageId, byte[] messageBuffer) { }

	// RVA: 0xFE5F88 Offset: 0xFE1F88 VA: 0xFE5F88
	public static IPAddress ResolveIPAddress(string hostDomain) { }

	// RVA: 0xFE6294 Offset: 0xFE2294 VA: 0xFE6294
	public static byte[] GetByteToSend(ushort id, byte[] byteMessage) { }

	// RVA: 0xFE6350 Offset: 0xFE2350 VA: 0xFE6350
	public static byte[] GetByteToSend(ushort id, IMessage message) { }

	// RVA: 0xFE641C Offset: 0xFE241C VA: 0xFE641C
	public static byte[] GetByteToSend(string message) { }

	// RVA: 0xFE64F8 Offset: 0xFE24F8 VA: 0xFE64F8
	public static byte[] GetByteToSend(ushort id) { }

	// RVA: 0xFE4DA0 Offset: 0xFE0DA0 VA: 0xFE4DA0
	public void SendToServer(ushort id, byte[] message) { }

	// RVA: 0xFE4D40 Offset: 0xFE0D40 VA: 0xFE4D40
	public void SendToServer(ushort id, IMessage message) { }

	// RVA: 0xFE4E88 Offset: 0xFE0E88 VA: 0xFE4E88
	public void SendToServer(string message) { }

	// RVA: 0xFE4E30 Offset: 0xFE0E30 VA: 0xFE4E30
	public void SendToServer(ushort id) { }

	// RVA: 0xFE6590 Offset: 0xFE2590 VA: 0xFE6590
	public string GetIpAddress() { }

	// RVA: 0xFE66BC Offset: 0xFE26BC VA: 0xFE66BC
	public int GetPortNum() { }
}

// Namespace: game.network
public class NetworkClient : Network32BitClient // TypeDefIndex: 2505
{
	// Fields
	[CompilerGenerated]
	private Action OnConnectedEvent; // 0xF0
	[CompilerGenerated]
	private Action OnDisconnectedEvent; // 0xF8
	[CompilerGenerated]
	private Action<int, byte[]> OnHandlePackage; // 0x100

	// Methods

	[CompilerGenerated]
	// RVA: 0xFE4440 Offset: 0xFE0440 VA: 0xFE4440
	public void add_OnConnectedEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0xFE4654 Offset: 0xFE0654 VA: 0xFE4654
	public void remove_OnConnectedEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0xFE44DC Offset: 0xFE04DC VA: 0xFE44DC
	public void add_OnDisconnectedEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0xFE46F0 Offset: 0xFE06F0 VA: 0xFE46F0
	public void remove_OnDisconnectedEvent(Action value) { }

	[CompilerGenerated]
	// RVA: 0xFE4390 Offset: 0xFE0390 VA: 0xFE4390
	public void add_OnHandlePackage(Action<int, byte[]> value) { }

	[CompilerGenerated]
	// RVA: 0xFE67C4 Offset: 0xFE27C4 VA: 0xFE67C4
	public void remove_OnHandlePackage(Action<int, byte[]> value) { }

	// RVA: 0xFE3C24 Offset: 0xFDFC24 VA: 0xFE3C24
	public void .ctor(string address, int port) { }

	// RVA: 0xFE6874 Offset: 0xFE2874 VA: 0xFE6874 Slot: 31
	protected override void MessageReceived(ushort messageId, byte[] messageBuffer) { }

	// RVA: 0xFE6894 Offset: 0xFE2894 VA: 0xFE6894 Slot: 23
	protected override void OnConnected() { }

	// RVA: 0xFE68B0 Offset: 0xFE28B0 VA: 0xFE68B0 Slot: 25
	protected override void OnDisconnected() { }
}

// Namespace: game.network
public class LiveTracking // TypeDefIndex: 2506
{
	// Fields
	public static LiveOptions liveOptions; // 0x0
	private static int overGsvMessageMilliseconds; // 0x8
	private static long gameserverMessagePreviousTimestamp; // 0x10
	private static long gameserverMessageLastTimestamp; // 0x18

	// Methods

	// RVA: 0xFE68CC Offset: 0xFE28CC VA: 0xFE68CC
	public static void SetLiveOptions(LiveOptions liveOptions) { }

	// RVA: 0xFE695C Offset: 0xFE295C VA: 0xFE695C
	public static void GameServerMessage() { }

	// RVA: 0xFE4CA4 Offset: 0xFE0CA4 VA: 0xFE4CA4
	public static void Clear() { }

	// RVA: 0xFE69CC Offset: 0xFE29CC VA: 0xFE69CC
	public void Activate() { }

	// RVA: 0xFE6BC8 Offset: 0xFE2BC8 VA: 0xFE6BC8
	public void .ctor() { }

	// RVA: 0xFE6BD0 Offset: 0xFE2BD0 VA: 0xFE6BD0
	private static void .cctor() { }
}

// Namespace: 
public enum Definition.Figure // TypeDefIndex: 2507
{
	// Fields
	public int value__; // 0x0
	public const Definition.Figure Unidentified = 0;
	public const Definition.Figure Master = 1;
	public const Definition.Figure Director = 2;
	public const Definition.Figure captain = 3;
	public const Definition.Figure member = 4;
}
