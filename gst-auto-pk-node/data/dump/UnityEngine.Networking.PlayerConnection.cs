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

// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
public class MessageEventArgs // TypeDefIndex: 7086
{
	// Fields
	public int playerId; // 0x10
	public byte[] data; // 0x18

	// Methods

	// RVA: 0x1E7D1E8 Offset: 0x1E791E8 VA: 0x1E7D1E8
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerConnection.<>c__DisplayClass12_0 // TypeDefIndex: 7087
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x1E7D72C Offset: 0x1E7972C VA: 0x1E7D72C
	public void .ctor() { }

	// RVA: 0x1E7E990 Offset: 0x1E7A990 VA: 0x1E7E990
	internal bool <Register>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerConnection.<>c__DisplayClass13_0 // TypeDefIndex: 7088
{
	// Fields
	public Guid messageId; // 0x10

	// Methods

	// RVA: 0x1E7DA9C Offset: 0x1E79A9C VA: 0x1E7DA9C
	public void .ctor() { }

	// RVA: 0x1E7E9BC Offset: 0x1E7A9BC VA: 0x1E7E9BC
	internal bool <Unregister>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class PlayerConnection.<>c__DisplayClass20_0 // TypeDefIndex: 7089
{
	// Fields
	public bool msgReceived; // 0x10

	// Methods

	// RVA: 0x1E7E34C Offset: 0x1E7A34C VA: 0x1E7E34C
	public void .ctor() { }

	// RVA: 0x1E7E9E8 Offset: 0x1E7A9E8 VA: 0x1E7E9E8
	internal void <BlockUntilRecvMsg>b__0(MessageEventArgs args) { }
}

// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
public class PlayerConnection : ScriptableObject // TypeDefIndex: 7090
{
	// Fields
	internal static IPlayerEditorConnectionNative connectionNative; // 0x0
	[SerializeField]
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18
	[SerializeField]
	private List<int> m_connectedPlayers; // 0x20
	private bool m_IsInitilized; // 0x28
	private static PlayerConnection s_Instance; // 0x8

	// Properties
	public static PlayerConnection instance { get; }
	public bool isConnected { get; }

	// Methods

	// RVA: 0x1E7D1F0 Offset: 0x1E791F0 VA: 0x1E7D1F0
	public static PlayerConnection get_instance() { }

	// RVA: 0x1E7D31C Offset: 0x1E7931C VA: 0x1E7D31C
	public bool get_isConnected() { }

	// RVA: 0x1E7D284 Offset: 0x1E79284 VA: 0x1E7D284
	private static PlayerConnection CreateInstance() { }

	// RVA: 0x1E7D430 Offset: 0x1E79430 VA: 0x1E7D430
	public void OnEnable() { }

	// RVA: 0x1E7D3B8 Offset: 0x1E793B8 VA: 0x1E7D3B8
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0x1E7D4F0 Offset: 0x1E794F0 VA: 0x1E7D4F0 Slot: 4
	public void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x1E7D8F8 Offset: 0x1E798F8 VA: 0x1E7D8F8 Slot: 5
	public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x1E7DBD0 Offset: 0x1E79BD0 VA: 0x1E7DBD0 Slot: 6
	public void RegisterConnection(UnityAction<int> callback) { }

	// RVA: 0x1E7DD4C Offset: 0x1E79D4C VA: 0x1E7DD4C Slot: 7
	public void RegisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x1E7DDAC Offset: 0x1E79DAC VA: 0x1E7DDAC Slot: 8
	public void UnregisterConnection(UnityAction<int> callback) { }

	// RVA: 0x1E7DE0C Offset: 0x1E79E0C VA: 0x1E7DE0C Slot: 9
	public void UnregisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x1E7DE6C Offset: 0x1E79E6C VA: 0x1E7DE6C Slot: 10
	public void Send(Guid messageId, byte[] data) { }

	// RVA: 0x1E7DFC4 Offset: 0x1E79FC4 VA: 0x1E7DFC4 Slot: 11
	public bool TrySend(Guid messageId, byte[] data) { }

	// RVA: 0x1E7E11C Offset: 0x1E7A11C VA: 0x1E7E11C
	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	// RVA: 0x1E7E354 Offset: 0x1E7A354 VA: 0x1E7E354 Slot: 12
	public void DisconnectAll() { }

	[RequiredByNativeCode]
	// RVA: 0x1E7E3F0 Offset: 0x1E7A3F0 VA: 0x1E7E3F0
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) { }

	[RequiredByNativeCode]
	// RVA: 0x1E7E688 Offset: 0x1E7A688 VA: 0x1E7E688
	private static void ConnectedCallbackInternal(int playerId) { }

	[RequiredByNativeCode]
	// RVA: 0x1E7E760 Offset: 0x1E7A760 VA: 0x1E7E760
	private static void DisconnectedCallback(int playerId) { }

	// RVA: 0x1E7E7F4 Offset: 0x1E7A7F4 VA: 0x1E7E7F4
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class PlayerEditorConnectionEvents.MessageEvent : UnityEvent<MessageEventArgs> // TypeDefIndex: 7091
{
	// Methods

	// RVA: 0x1E7F5A4 Offset: 0x1E7B5A4 VA: 0x1E7F5A4
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class PlayerEditorConnectionEvents.ConnectionChangeEvent : UnityEvent<int> // TypeDefIndex: 7092
{
	// Methods

	// RVA: 0x1E7F5EC Offset: 0x1E7B5EC VA: 0x1E7F5EC
	public void .ctor() { }
}

// Namespace: 
[Serializable]
public class PlayerEditorConnectionEvents.MessageTypeSubscribers // TypeDefIndex: 7093
{
	// Fields
	[SerializeField]
	private string m_messageTypeId; // 0x10
	public int subscriberCount; // 0x18
	public PlayerEditorConnectionEvents.MessageEvent messageCallback; // 0x20

	// Properties
	public Guid MessageTypeId { get; set; }

	// Methods

	// RVA: 0x1E7F634 Offset: 0x1E7B634 VA: 0x1E7F634
	public Guid get_MessageTypeId() { }

	// RVA: 0x1E7F660 Offset: 0x1E7B660 VA: 0x1E7F660
	public void set_MessageTypeId(Guid value) { }

	// RVA: 0x1E7F698 Offset: 0x1E7B698 VA: 0x1E7F698
	public void .ctor() { }
}

// Namespace: UnityEngine.Networking.PlayerConnection
[Serializable]
internal class PlayerEditorConnectionEvents // TypeDefIndex: 7094
{
	// Fields
	[SerializeField]
	private List<PlayerEditorConnectionEvents.MessageTypeSubscribers> m_MessageTypeSubscribers; // 0x10
	private Dictionary<Guid, PlayerEditorConnectionEvents.MessageTypeSubscribers> m_SubscriberLookup; // 0x18
	[SerializeField]
	public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent; // 0x20
	[SerializeField]
	public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent; // 0x28

	// Properties
	public IReadOnlyList<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers { get; }

	// Methods

	// RVA: 0x1E7E9F4 Offset: 0x1E7A9F4 VA: 0x1E7E9F4
	public IReadOnlyList<PlayerEditorConnectionEvents.MessageTypeSubscribers> get_messageTypeSubscribers() { }

	// RVA: 0x1E7E9FC Offset: 0x1E7A9FC VA: 0x1E7E9FC
	private void BuildLookup() { }

	// RVA: 0x1E7E508 Offset: 0x1E7A508 VA: 0x1E7E508
	public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x1E7D734 Offset: 0x1E79734 VA: 0x1E7D734
	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	// RVA: 0x1E7DAA4 Offset: 0x1E79AA4 VA: 0x1E7DAA4
	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x1E7E8AC Offset: 0x1E7A8AC VA: 0x1E7E8AC
	public void .ctor() { }
}
