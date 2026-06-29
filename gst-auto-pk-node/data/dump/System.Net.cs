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

// Namespace: System.Net
internal class ContextAwareResult : LazyAsyncResult // TypeDefIndex: 4118
{
	// Fields
	private ExecutionContext _context; // 0x40
	private object _lock; // 0x48
	private ContextAwareResult.StateFlags _flags; // 0x50

	// Methods

	// RVA: 0x1D62E40 Offset: 0x1D5EE40 VA: 0x1D62E40
	private void SafeCaptureIdentity() { }

	// RVA: 0x1D62E44 Offset: 0x1D5EE44 VA: 0x1D62E44
	private void CleanupInternal() { }

	// RVA: 0x1D62E48 Offset: 0x1D5EE48 VA: 0x1D62E48
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1D62E50 Offset: 0x1D5EE50 VA: 0x1D62E50
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1D62EA0 Offset: 0x1D5EEA0 VA: 0x1D62EA0
	internal void .ctor(bool captureIdentity, bool forceCaptureContext, bool threadSafeContextCopy, object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1D62F18 Offset: 0x1D5EF18 VA: 0x1D62F18
	internal object StartPostingAsyncOp() { }

	// RVA: 0x1D62F20 Offset: 0x1D5EF20 VA: 0x1D62F20
	internal object StartPostingAsyncOp(bool lockCapture) { }

	// RVA: 0x1D630F0 Offset: 0x1D5F0F0 VA: 0x1D630F0
	internal bool FinishPostingAsyncOp() { }

	// RVA: 0x1D6351C Offset: 0x1D5F51C VA: 0x1D6351C Slot: 9
	protected override void Cleanup() { }

	// RVA: 0x1D63130 Offset: 0x1D5F130 VA: 0x1D63130
	private bool CaptureOrComplete(ref ExecutionContext cachedContext, bool returnContext) { }

	// RVA: 0x1D637E0 Offset: 0x1D5F7E0 VA: 0x1D637E0 Slot: 8
	protected override void Complete(IntPtr userToken) { }

	// RVA: 0x1D63AAC Offset: 0x1D5FAAC VA: 0x1D63AAC
	private void CompleteCallback() { }
}

// Namespace: System.Net
internal static class HttpStatusDescription // TypeDefIndex: 4119
{
	// Methods

	// RVA: 0x1D63C48 Offset: 0x1D5FC48 VA: 0x1D63C48
	internal static string Get(HttpStatusCode code) { }

	// RVA: 0x1D63C4C Offset: 0x1D5FC4C VA: 0x1D63C4C
	internal static string Get(int code) { }
}

// Namespace: System.Net
internal static class HttpValidationHelpers // TypeDefIndex: 4120
{
	// Fields
	private static readonly char[] s_httpTrimCharacters; // 0x0

	// Methods

	// RVA: 0x1D643A4 Offset: 0x1D603A4 VA: 0x1D643A4
	public static bool IsInvalidMethodOrHeaderString(string stringValue) { }

	// RVA: 0x1D644B8 Offset: 0x1D604B8 VA: 0x1D644B8
	private static void .cctor() { }
}

// Namespace: 
public class NetEventSource.Keywords // TypeDefIndex: 4121
{
	// Fields
	public const EventKeywords Default = 1;
	public const EventKeywords Debug = 2;
	public const EventKeywords EnterExit = 4;
}

// Namespace: System.Net
internal sealed class NetEventSource : EventSource // TypeDefIndex: 4122
{
	// Fields
	public static readonly NetEventSource Log; // 0x0

	// Properties
	public static bool IsEnabled { get; }

	// Methods

	[NonEvent]
	// RVA: 0x1D64558 Offset: 0x1D60558 VA: 0x1D64558
	public static void Enter(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x1D64AEC Offset: 0x1D60AEC VA: 0x1D64AEC
	public static void Enter(object thisOrContextObject, object arg0, string memberName) { }

	[NonEvent]
	// RVA: 0x1D64F7C Offset: 0x1D60F7C VA: 0x1D64F7C
	public static void Enter(object thisOrContextObject, object arg0, object arg1, object arg2, string memberName) { }

	[Event(1, Level = 4, Keywords = 4)]
	// RVA: 0x1D64A70 Offset: 0x1D60A70 VA: 0x1D64A70
	private void Enter(string thisOrContextObject, string memberName, string parameters) { }

	[NonEvent]
	// RVA: 0x1D65098 Offset: 0x1D61098 VA: 0x1D65098
	public static void Exit(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x1D65204 Offset: 0x1D61204 VA: 0x1D65204
	public static void Exit(object thisOrContextObject, object arg0, string memberName) { }

	[Event(2, Level = 4, Keywords = 4)]
	// RVA: 0x1D65188 Offset: 0x1D61188 VA: 0x1D65188
	private void Exit(string thisOrContextObject, string memberName, string result) { }

	[NonEvent]
	// RVA: 0x1D63620 Offset: 0x1D5F620 VA: 0x1D63620
	public static void Info(object thisOrContextObject, FormattableString formattableString, string memberName) { }

	[NonEvent]
	// RVA: 0x1D63710 Offset: 0x1D5F710 VA: 0x1D63710
	public static void Info(object thisOrContextObject, object message, string memberName) { }

	[Event(4, Level = 4, Keywords = 1)]
	// RVA: 0x1D652D4 Offset: 0x1D612D4 VA: 0x1D652D4
	private void Info(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	// RVA: 0x1D65350 Offset: 0x1D61350 VA: 0x1D65350
	public static void Error(object thisOrContextObject, object message, string memberName) { }

	[Event(5, Level = 3, Keywords = 1)]
	// RVA: 0x1D65420 Offset: 0x1D61420 VA: 0x1D65420
	private void ErrorMessage(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	// RVA: 0x1D63020 Offset: 0x1D5F020 VA: 0x1D63020
	public static void Fail(object thisOrContextObject, object message, string memberName) { }

	[Event(6, Level = 1, Keywords = 2)]
	// RVA: 0x1D6549C Offset: 0x1D6149C VA: 0x1D6549C
	private void CriticalFailure(string thisOrContextObject, string memberName, string message) { }

	[NonEvent]
	// RVA: 0x1D65518 Offset: 0x1D61518 VA: 0x1D65518
	public static void Associate(object first, object second, string memberName) { }

	[Event(3, Level = 4, Keywords = 1, Message = "[{2}]<-->[{3}]")]
	// RVA: 0x1D655E8 Offset: 0x1D615E8 VA: 0x1D655E8
	private void Associate(string thisOrContextObject, string memberName, string first, string second) { }

	// RVA: 0x1D635BC Offset: 0x1D5F5BC VA: 0x1D635BC
	public static bool get_IsEnabled() { }

	[NonEvent]
	// RVA: 0x1D64648 Offset: 0x1D60648 VA: 0x1D64648
	public static string IdOf(object value) { }

	[NonEvent]
	// RVA: 0x1D6588C Offset: 0x1D6188C VA: 0x1D6588C
	public static int GetHashCode(object value) { }

	[NonEvent]
	// RVA: 0x1D64BD4 Offset: 0x1D60BD4 VA: 0x1D64BD4
	public static object Format(object value) { }

	[NonEvent]
	// RVA: 0x1D64734 Offset: 0x1D60734 VA: 0x1D64734
	private static string Format(FormattableString s) { }

	[NonEvent]
	// RVA: 0x1D65670 Offset: 0x1D61670 VA: 0x1D65670
	private void WriteEvent(int eventId, string arg1, string arg2, string arg3, string arg4) { }

	// RVA: 0x1D658A0 Offset: 0x1D618A0 VA: 0x1D658A0
	public void .ctor() { }

	// RVA: 0x1D658A8 Offset: 0x1D618A8 VA: 0x1D658A8
	private static void .cctor() { }
}

// Namespace: System.Net
internal static class TcpValidationHelpers // TypeDefIndex: 4123
{
	// Methods

	// RVA: 0x1D65910 Offset: 0x1D61910 VA: 0x1D65910
	public static bool ValidatePortNumber(int port) { }
}

// Namespace: System.Net
internal class TlsStream : NetworkStream // TypeDefIndex: 4124
{
	// Fields
	private SslStream _sslStream; // 0x48
	private string _host; // 0x50
	private X509CertificateCollection _clientCertificates; // 0x58

	// Methods

	// RVA: 0x1D6591C Offset: 0x1D6191C VA: 0x1D6591C
	public void .ctor(NetworkStream stream, Socket socket, string host, X509CertificateCollection clientCertificates) { }

	// RVA: 0x1D65A0C Offset: 0x1D61A0C VA: 0x1D65A0C
	public void AuthenticateAsClient() { }

	// RVA: 0x1D65B0C Offset: 0x1D61B0C VA: 0x1D65B0C
	public IAsyncResult BeginAuthenticateAsClient(AsyncCallback asyncCallback, object state) { }

	// RVA: 0x1D65C24 Offset: 0x1D61C24 VA: 0x1D65C24
	public void EndAuthenticateAsClient(IAsyncResult asyncResult) { }

	// RVA: 0x1D65C44 Offset: 0x1D61C44 VA: 0x1D65C44 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1D65C64 Offset: 0x1D61C64 VA: 0x1D65C64 Slot: 27
	public override void EndWrite(IAsyncResult result) { }

	// RVA: 0x1D65C84 Offset: 0x1D61C84 VA: 0x1D65C84 Slot: 35
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1D65CA4 Offset: 0x1D61CA4 VA: 0x1D65CA4 Slot: 32
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1D65CC4 Offset: 0x1D61CC4 VA: 0x1D65CC4 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x1D65CE4 Offset: 0x1D61CE4 VA: 0x1D65CE4 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1D65D04 Offset: 0x1D61D04 VA: 0x1D65D04 Slot: 19
	public override void Close() { }
}

// Namespace: System.Net
public enum HttpStatusCode // TypeDefIndex: 4125
{
	// Fields
	public int value__; // 0x0
	public const HttpStatusCode Continue = 100;
	public const HttpStatusCode SwitchingProtocols = 101;
	public const HttpStatusCode Processing = 102;
	public const HttpStatusCode EarlyHints = 103;
	public const HttpStatusCode OK = 200;
	public const HttpStatusCode Created = 201;
	public const HttpStatusCode Accepted = 202;
	public const HttpStatusCode NonAuthoritativeInformation = 203;
	public const HttpStatusCode NoContent = 204;
	public const HttpStatusCode ResetContent = 205;
	public const HttpStatusCode PartialContent = 206;
	public const HttpStatusCode MultiStatus = 207;
	public const HttpStatusCode AlreadyReported = 208;
	public const HttpStatusCode IMUsed = 226;
	public const HttpStatusCode MultipleChoices = 300;
	public const HttpStatusCode Ambiguous = 300;
	public const HttpStatusCode MovedPermanently = 301;
	public const HttpStatusCode Moved = 301;
	public const HttpStatusCode Found = 302;
	public const HttpStatusCode Redirect = 302;
	public const HttpStatusCode SeeOther = 303;
	public const HttpStatusCode RedirectMethod = 303;
	public const HttpStatusCode NotModified = 304;
	public const HttpStatusCode UseProxy = 305;
	public const HttpStatusCode Unused = 306;
	public const HttpStatusCode TemporaryRedirect = 307;
	public const HttpStatusCode RedirectKeepVerb = 307;
	public const HttpStatusCode PermanentRedirect = 308;
	public const HttpStatusCode BadRequest = 400;
	public const HttpStatusCode Unauthorized = 401;
	public const HttpStatusCode PaymentRequired = 402;
	public const HttpStatusCode Forbidden = 403;
	public const HttpStatusCode NotFound = 404;
	public const HttpStatusCode MethodNotAllowed = 405;
	public const HttpStatusCode NotAcceptable = 406;
	public const HttpStatusCode ProxyAuthenticationRequired = 407;
	public const HttpStatusCode RequestTimeout = 408;
	public const HttpStatusCode Conflict = 409;
	public const HttpStatusCode Gone = 410;
	public const HttpStatusCode LengthRequired = 411;
	public const HttpStatusCode PreconditionFailed = 412;
	public const HttpStatusCode RequestEntityTooLarge = 413;
	public const HttpStatusCode RequestUriTooLong = 414;
	public const HttpStatusCode UnsupportedMediaType = 415;
	public const HttpStatusCode RequestedRangeNotSatisfiable = 416;
	public const HttpStatusCode ExpectationFailed = 417;
	public const HttpStatusCode MisdirectedRequest = 421;
	public const HttpStatusCode UnprocessableEntity = 422;
	public const HttpStatusCode Locked = 423;
	public const HttpStatusCode FailedDependency = 424;
	public const HttpStatusCode UpgradeRequired = 426;
	public const HttpStatusCode PreconditionRequired = 428;
	public const HttpStatusCode TooManyRequests = 429;
	public const HttpStatusCode RequestHeaderFieldsTooLarge = 431;
	public const HttpStatusCode UnavailableForLegalReasons = 451;
	public const HttpStatusCode InternalServerError = 500;
	public const HttpStatusCode NotImplemented = 501;
	public const HttpStatusCode BadGateway = 502;
	public const HttpStatusCode ServiceUnavailable = 503;
	public const HttpStatusCode GatewayTimeout = 504;
	public const HttpStatusCode HttpVersionNotSupported = 505;
	public const HttpStatusCode VariantAlsoNegotiates = 506;
	public const HttpStatusCode InsufficientStorage = 507;
	public const HttpStatusCode LoopDetected = 508;
	public const HttpStatusCode NotExtended = 510;
	public const HttpStatusCode NetworkAuthenticationRequired = 511;
}

// Namespace: System.Net
public class HttpVersion // TypeDefIndex: 4126
{
	// Fields
	public static readonly Version Unknown; // 0x0
	public static readonly Version Version10; // 0x8
	public static readonly Version Version11; // 0x10
	public static readonly Version Version20; // 0x18

	// Methods

	// RVA: 0x1D65D38 Offset: 0x1D61D38 VA: 0x1D65D38
	private static void .cctor() { }
}

// Namespace: 
private sealed class IPAddress.ReadOnlyIPAddress : IPAddress // TypeDefIndex: 4127
{
	// Methods

	// RVA: 0x1D67330 Offset: 0x1D63330 VA: 0x1D67330
	public void .ctor(long newAddress) { }
}

// Namespace: System.Net
[Serializable]
public class IPAddress // TypeDefIndex: 4128
{
	// Fields
	public static readonly IPAddress Any; // 0x0
	public static readonly IPAddress Loopback; // 0x8
	public static readonly IPAddress Broadcast; // 0x10
	public static readonly IPAddress None; // 0x18
	internal const long LoopbackMask = 255;
	public static readonly IPAddress IPv6Any; // 0x20
	public static readonly IPAddress IPv6Loopback; // 0x28
	public static readonly IPAddress IPv6None; // 0x30
	private uint _addressOrScopeId; // 0x10
	private readonly ushort[] _numbers; // 0x18
	private string _toString; // 0x20
	private int _hashCode; // 0x28
	internal const int NumberOfLabels = 8;

	// Properties
	private bool IsIPv4 { get; }
	private bool IsIPv6 { get; }
	private uint PrivateAddress { get; set; }
	private uint PrivateScopeId { get; set; }
	public AddressFamily AddressFamily { get; }
	public long ScopeId { get; }

	// Methods

	// RVA: 0x1D65E4C Offset: 0x1D61E4C VA: 0x1D65E4C
	private bool get_IsIPv4() { }

	// RVA: 0x1D65E5C Offset: 0x1D61E5C VA: 0x1D65E5C
	private bool get_IsIPv6() { }

	// RVA: 0x1D65E6C Offset: 0x1D61E6C VA: 0x1D65E6C
	private uint get_PrivateAddress() { }

	// RVA: 0x1D65E74 Offset: 0x1D61E74 VA: 0x1D65E74
	private void set_PrivateAddress(uint value) { }

	// RVA: 0x1D65EA8 Offset: 0x1D61EA8 VA: 0x1D65EA8
	private uint get_PrivateScopeId() { }

	// RVA: 0x1D65EB0 Offset: 0x1D61EB0 VA: 0x1D65EB0
	private void set_PrivateScopeId(uint value) { }

	// RVA: 0x1D65EE4 Offset: 0x1D61EE4 VA: 0x1D65EE4
	public void .ctor(long newAddress) { }

	// RVA: 0x1D65F70 Offset: 0x1D61F70 VA: 0x1D65F70
	public void .ctor(byte[] address, long scopeid) { }

	// RVA: 0x1D66040 Offset: 0x1D62040 VA: 0x1D66040
	public void .ctor(ReadOnlySpan<byte> address, long scopeid) { }

	// RVA: 0x1D661C8 Offset: 0x1D621C8 VA: 0x1D661C8
	internal void .ctor(ushort* numbers, int numbersLength, uint scopeid) { }

	// RVA: 0x1D66294 Offset: 0x1D62294 VA: 0x1D66294
	private void .ctor(ushort[] numbers, uint scopeid) { }

	// RVA: 0x1D662E4 Offset: 0x1D622E4 VA: 0x1D662E4
	public static bool TryParse(string ipString, out IPAddress address) { }

	// RVA: 0x1D66544 Offset: 0x1D62544 VA: 0x1D66544
	public static IPAddress Parse(string ipString) { }

	// RVA: 0x1D665DC Offset: 0x1D625DC VA: 0x1D665DC
	public bool TryWriteBytes(Span<byte> destination, out int bytesWritten) { }

	// RVA: 0x1D666E8 Offset: 0x1D626E8 VA: 0x1D666E8
	private void WriteIPv6Bytes(Span<byte> destination) { }

	// RVA: 0x1D66774 Offset: 0x1D62774 VA: 0x1D66774
	private void WriteIPv4Bytes(Span<byte> destination) { }

	// RVA: 0x1D667C0 Offset: 0x1D627C0 VA: 0x1D667C0
	public byte[] GetAddressBytes() { }

	// RVA: 0x1D66908 Offset: 0x1D62908 VA: 0x1D66908
	public AddressFamily get_AddressFamily() { }

	// RVA: 0x1D66920 Offset: 0x1D62920 VA: 0x1D66920
	public long get_ScopeId() { }

	// RVA: 0x1D6696C Offset: 0x1D6296C VA: 0x1D6696C Slot: 3
	public override string ToString() { }

	// RVA: 0x1D66A90 Offset: 0x1D62A90 VA: 0x1D66A90
	public static bool IsLoopback(IPAddress address) { }

	// RVA: 0x1D66B60 Offset: 0x1D62B60 VA: 0x1D66B60
	internal bool Equals(object comparandObj, bool compareScopeId) { }

	// RVA: 0x1D66C88 Offset: 0x1D62C88 VA: 0x1D66C88 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1D66C90 Offset: 0x1D62C90 VA: 0x1D66C90 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D67080 Offset: 0x1D63080 VA: 0x1D67080
	public IPAddress MapToIPv6() { }

	// RVA: 0x1D65FF4 Offset: 0x1D61FF4 VA: 0x1D65FF4
	private static byte[] ThrowAddressNullException() { }

	// RVA: 0x1D67154 Offset: 0x1D63154 VA: 0x1D67154
	private static void .cctor() { }
}

// Namespace: System.Net
internal class IPAddressParser // TypeDefIndex: 4129
{
	// Methods

	// RVA: 0x1D66370 Offset: 0x1D62370 VA: 0x1D66370
	internal static IPAddress Parse(ReadOnlySpan<char> ipSpan, bool tryParse) { }

	// RVA: 0x1D66A30 Offset: 0x1D62A30 VA: 0x1D66A30
	internal static string IPv4AddressToString(uint address) { }

	// RVA: 0x1D67654 Offset: 0x1D63654 VA: 0x1D67654
	internal static void IPv4AddressToString(uint address, StringBuilder destination) { }

	// RVA: 0x1D675B8 Offset: 0x1D635B8 VA: 0x1D675B8
	private static int IPv4AddressToStringHelper(uint address, char* addressString) { }

	// RVA: 0x1D66A1C Offset: 0x1D62A1C VA: 0x1D66A1C
	internal static string IPv6AddressToString(ushort[] address, uint scopeId) { }

	// RVA: 0x1D6778C Offset: 0x1D6378C VA: 0x1D6778C
	internal static StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId) { }

	// RVA: 0x1D676D4 Offset: 0x1D636D4 VA: 0x1D676D4
	private static void FormatIPv4AddressNumber(int number, char* addressString, ref int offset) { }

	// RVA: 0x1D67508 Offset: 0x1D63508 VA: 0x1D67508
	public static bool Ipv4StringToAddress(ReadOnlySpan<char> ipSpan, out long address) { }

	// RVA: 0x1D67394 Offset: 0x1D63394 VA: 0x1D67394
	public static bool Ipv6StringToAddress(ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, out uint scope) { }

	// RVA: 0x1D678AC Offset: 0x1D638AC VA: 0x1D678AC
	private static void AppendSections(ushort[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	// RVA: 0x1D67A90 Offset: 0x1D63A90 VA: 0x1D67A90
	private static void AppendHex(ushort value, StringBuilder buffer) { }

	// RVA: 0x1D67A5C Offset: 0x1D63A5C VA: 0x1D67A5C
	private static uint ExtractIPv4Address(ushort[] address) { }

	// RVA: 0x1D67B30 Offset: 0x1D63B30 VA: 0x1D67B30
	private static ushort Reverse(ushort number) { }
}

// Namespace: System.Net
[Serializable]
public class IPEndPoint : EndPoint // TypeDefIndex: 4130
{
	// Fields
	public const int MinPort = 0;
	public const int MaxPort = 65535;
	private IPAddress _address; // 0x10
	private int _port; // 0x18
	internal const int AnyPort = 0;
	internal static IPEndPoint Any; // 0x0
	internal static IPEndPoint IPv6Any; // 0x8

	// Properties
	public override AddressFamily AddressFamily { get; }
	public IPAddress Address { get; }
	public int Port { get; }

	// Methods

	// RVA: 0x1D67B3C Offset: 0x1D63B3C VA: 0x1D67B3C Slot: 4
	public override AddressFamily get_AddressFamily() { }

	// RVA: 0x1D67B54 Offset: 0x1D63B54 VA: 0x1D67B54
	public void .ctor(IPAddress address, int port) { }

	// RVA: 0x1D67C24 Offset: 0x1D63C24 VA: 0x1D67C24
	public IPAddress get_Address() { }

	// RVA: 0x1D67C2C Offset: 0x1D63C2C VA: 0x1D67C2C
	public int get_Port() { }

	// RVA: 0x1D67C34 Offset: 0x1D63C34 VA: 0x1D67C34 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D67D04 Offset: 0x1D63D04 VA: 0x1D67D04 Slot: 5
	public override SocketAddress Serialize() { }

	// RVA: 0x1D67DC4 Offset: 0x1D63DC4 VA: 0x1D67DC4 Slot: 6
	public override EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x1D68080 Offset: 0x1D64080 VA: 0x1D68080 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1D6812C Offset: 0x1D6412C VA: 0x1D6812C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D6815C Offset: 0x1D6415C VA: 0x1D6815C
	private static void .cctor() { }
}

// Namespace: 
internal enum CommandStream.PipelineInstruction // TypeDefIndex: 4131
{
	// Fields
	public int value__; // 0x0
	public const CommandStream.PipelineInstruction Abort = 0;
	public const CommandStream.PipelineInstruction Advance = 1;
	public const CommandStream.PipelineInstruction Pause = 2;
	public const CommandStream.PipelineInstruction Reread = 3;
	public const CommandStream.PipelineInstruction GiveStream = 4;
}

// Namespace: 
[Flags]
internal enum CommandStream.PipelineEntryFlags // TypeDefIndex: 4132
{
	// Fields
	public int value__; // 0x0
	public const CommandStream.PipelineEntryFlags UserCommand = 1;
	public const CommandStream.PipelineEntryFlags GiveDataStream = 2;
	public const CommandStream.PipelineEntryFlags CreateDataConnection = 4;
	public const CommandStream.PipelineEntryFlags DontLogParameter = 8;
}

// Namespace: 
internal class CommandStream.PipelineEntry // TypeDefIndex: 4133
{
	// Fields
	internal string Command; // 0x10
	internal CommandStream.PipelineEntryFlags Flags; // 0x18

	// Methods

	// RVA: 0x1D6A538 Offset: 0x1D66538 VA: 0x1D6A538
	internal void .ctor(string command) { }

	// RVA: 0x1D6A568 Offset: 0x1D66568 VA: 0x1D6A568
	internal void .ctor(string command, CommandStream.PipelineEntryFlags flags) { }

	// RVA: 0x1D690EC Offset: 0x1D650EC VA: 0x1D690EC
	internal bool HasFlag(CommandStream.PipelineEntryFlags flags) { }
}

// Namespace: System.Net
internal class CommandStream : NetworkStreamWrapper // TypeDefIndex: 4134
{
	// Fields
	private static readonly AsyncCallback s_writeCallbackDelegate; // 0x0
	private static readonly AsyncCallback s_readCallbackDelegate; // 0x8
	private bool _recoverableFailure; // 0x38
	protected WebRequest _request; // 0x40
	protected bool _isAsync; // 0x48
	private bool _aborted; // 0x49
	protected CommandStream.PipelineEntry[] _commands; // 0x50
	protected int _index; // 0x58
	private bool _doRead; // 0x5C
	private bool _doSend; // 0x5D
	private ResponseDescription _currentResponseDescription; // 0x60
	protected string _abortReason; // 0x68
	private string _buffer; // 0x70
	private Encoding _encoding; // 0x78
	private Decoder _decoder; // 0x80

	// Properties
	internal bool RecoverableFailure { get; }
	protected Encoding Encoding { get; set; }

	// Methods

	// RVA: 0x1D68238 Offset: 0x1D64238 VA: 0x1D68238
	internal void .ctor(TcpClient client) { }

	// RVA: 0x1D68358 Offset: 0x1D64358 VA: 0x1D68358 Slot: 38
	internal virtual void Abort(Exception e) { }

	// RVA: 0x1D6857C Offset: 0x1D6457C VA: 0x1D6857C Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1D68618 Offset: 0x1D64618 VA: 0x1D68618
	protected void InvokeRequestCallback(object obj) { }

	// RVA: 0x1D68698 Offset: 0x1D64698 VA: 0x1D68698
	internal bool get_RecoverableFailure() { }

	// RVA: 0x1D686A0 Offset: 0x1D646A0 VA: 0x1D686A0
	protected void MarkAsRecoverableFailure() { }

	// RVA: 0x1D686B8 Offset: 0x1D646B8 VA: 0x1D686B8
	internal Stream SubmitRequest(WebRequest request, bool isAsync, bool readInitalResponseOnConnect) { }

	// RVA: 0x1D68CD4 Offset: 0x1D64CD4 VA: 0x1D68CD4 Slot: 39
	protected virtual void ClearState() { }

	// RVA: 0x1D68CE4 Offset: 0x1D64CE4 VA: 0x1D68CE4 Slot: 40
	protected virtual CommandStream.PipelineEntry[] BuildCommandsList(WebRequest request) { }

	// RVA: 0x1D68CEC Offset: 0x1D64CEC VA: 0x1D68CEC
	protected Exception GenerateException(string message, WebExceptionStatus status, Exception innerException) { }

	// RVA: 0x1D68D78 Offset: 0x1D64D78 VA: 0x1D68D78
	protected Exception GenerateException(FtpStatusCode code, string statusDescription, Exception innerException) { }

	// RVA: 0x1D68738 Offset: 0x1D64738 VA: 0x1D68738
	protected void InitCommandPipeline(WebRequest request, CommandStream.PipelineEntry[] commands, bool isAsync) { }

	// RVA: 0x1D69030 Offset: 0x1D65030 VA: 0x1D69030
	internal void CheckContinuePipeline() { }

	// RVA: 0x1D687B8 Offset: 0x1D647B8 VA: 0x1D687B8
	protected Stream ContinueCommandPipeline() { }

	// RVA: 0x1D690FC Offset: 0x1D650FC VA: 0x1D690FC
	private bool PostSendCommandProcessing(ref Stream stream) { }

	// RVA: 0x1D69560 Offset: 0x1D65560 VA: 0x1D69560
	private bool PostReadCommandProcessing(ref Stream stream) { }

	// RVA: 0x1D697B8 Offset: 0x1D657B8 VA: 0x1D697B8 Slot: 41
	protected virtual CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	// RVA: 0x1D697C0 Offset: 0x1D657C0 VA: 0x1D697C0
	private static void ReadCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1D6A068 Offset: 0x1D66068 VA: 0x1D6A068
	private static void WriteCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1D6A338 Offset: 0x1D66338 VA: 0x1D6A338
	protected Encoding get_Encoding() { }

	// RVA: 0x1D6A340 Offset: 0x1D66340 VA: 0x1D6A340
	protected void set_Encoding(Encoding value) { }

	// RVA: 0x1D6A390 Offset: 0x1D66390 VA: 0x1D6A390 Slot: 42
	protected virtual bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	// RVA: 0x1D69230 Offset: 0x1D65230 VA: 0x1D69230
	private ResponseDescription ReceiveCommandResponse() { }

	// RVA: 0x1D69ABC Offset: 0x1D65ABC VA: 0x1D69ABC
	private void ReceiveCommandResponseCallback(ReceiveState state, int bytesRead) { }

	// RVA: 0x1D6A454 Offset: 0x1D66454 VA: 0x1D6A454
	private static void .cctor() { }
}

// Namespace: System.Net
internal class ResponseDescription // TypeDefIndex: 4135
{
	// Fields
	internal bool Multiline; // 0x10
	internal int Status; // 0x14
	internal string StatusDescription; // 0x18
	internal StringBuilder StatusBuffer; // 0x20
	internal string StatusCodeString; // 0x28

	// Properties
	internal bool PositiveIntermediate { get; }
	internal bool PositiveCompletion { get; }
	internal bool TransientFailure { get; }
	internal bool PermanentFailure { get; }
	internal bool InvalidStatusCode { get; }

	// Methods

	// RVA: 0x1D6A5A4 Offset: 0x1D665A4 VA: 0x1D6A5A4
	internal bool get_PositiveIntermediate() { }

	// RVA: 0x1D6A5B8 Offset: 0x1D665B8 VA: 0x1D6A5B8
	internal bool get_PositiveCompletion() { }

	// RVA: 0x1D6A5CC Offset: 0x1D665CC VA: 0x1D6A5CC
	internal bool get_TransientFailure() { }

	// RVA: 0x1D6A5E0 Offset: 0x1D665E0 VA: 0x1D6A5E0
	internal bool get_PermanentFailure() { }

	// RVA: 0x1D6A5F4 Offset: 0x1D665F4 VA: 0x1D6A5F4
	internal bool get_InvalidStatusCode() { }

	// RVA: 0x1D6A608 Offset: 0x1D66608 VA: 0x1D6A608
	public void .ctor() { }
}

// Namespace: System.Net
internal class ReceiveState // TypeDefIndex: 4136
{
	// Fields
	internal ResponseDescription Resp; // 0x10
	internal int ValidThrough; // 0x18
	internal byte[] Buffer; // 0x20
	internal CommandStream Connection; // 0x28

	// Methods

	// RVA: 0x1D6A398 Offset: 0x1D66398 VA: 0x1D6A398
	internal void .ctor(CommandStream connection) { }
}

// Namespace: System.Net
internal enum FtpLoginState // TypeDefIndex: 4137
{
	// Fields
	public byte value__; // 0x0
	public const FtpLoginState NotLoggedIn = 0;
	public const FtpLoginState LoggedIn = 1;
	public const FtpLoginState LoggedInButNeedsRelogin = 2;
	public const FtpLoginState ReloginFailed = 3;
}

// Namespace: 
private enum FtpControlStream.GetPathOption // TypeDefIndex: 4138
{
	// Fields
	public int value__; // 0x0
	public const FtpControlStream.GetPathOption Normal = 0;
	public const FtpControlStream.GetPathOption AssumeFilename = 1;
	public const FtpControlStream.GetPathOption AssumeNoFilename = 2;
}

// Namespace: 
[CompilerGenerated]
private sealed class FtpControlStream.<>c__DisplayClass31_0 // TypeDefIndex: 4139
{
	// Fields
	public FtpControlStream <>4__this; // 0x10
	public TlsStream tlsStream; // 0x18

	// Methods

	// RVA: 0x1D6BF9C Offset: 0x1D67F9C VA: 0x1D6BF9C
	public void .ctor() { }

	// RVA: 0x1D6F1F0 Offset: 0x1D6B1F0 VA: 0x1D6F1F0
	internal void <PipelineCallback>b__0(IAsyncResult ar) { }
}

// Namespace: System.Net
internal class FtpControlStream : CommandStream // TypeDefIndex: 4140
{
	// Fields
	private Socket _dataSocket; // 0x88
	private IPEndPoint _passiveEndPoint; // 0x90
	private TlsStream _tlsStream; // 0x98
	private StringBuilder _bannerMessage; // 0xA0
	private StringBuilder _welcomeMessage; // 0xA8
	private StringBuilder _exitMessage; // 0xB0
	private WeakReference _credentials; // 0xB8
	private string _currentTypeSetting; // 0xC0
	private long _contentLength; // 0xC8
	private DateTime _lastModified; // 0xD0
	private bool _dataHandshakeStarted; // 0xD8
	private string _loginDirectory; // 0xE0
	private string _establishedServerDirectory; // 0xE8
	private string _requestedServerDirectory; // 0xF0
	private Uri _responseUri; // 0xF8
	private FtpLoginState _loginState; // 0x100
	internal FtpStatusCode StatusCode; // 0x104
	internal string StatusLine; // 0x108
	private static readonly AsyncCallback s_acceptCallbackDelegate; // 0x0
	private static readonly AsyncCallback s_connectCallbackDelegate; // 0x8
	private static readonly AsyncCallback s_SSLHandshakeCallback; // 0x10

	// Properties
	internal NetworkCredential Credentials { get; set; }
	internal long ContentLength { get; }
	internal DateTime LastModified { get; }
	internal Uri ResponseUri { get; }
	internal string BannerMessage { get; }
	internal string WelcomeMessage { get; }
	internal string ExitMessage { get; }

	// Methods

	// RVA: 0x1D6A67C Offset: 0x1D6667C VA: 0x1D6A67C
	internal NetworkCredential get_Credentials() { }

	// RVA: 0x1D6A724 Offset: 0x1D66724 VA: 0x1D6A724
	internal void set_Credentials(NetworkCredential value) { }

	// RVA: 0x1D6A7B0 Offset: 0x1D667B0 VA: 0x1D6A7B0
	internal void .ctor(TcpClient client) { }

	// RVA: 0x1D6A840 Offset: 0x1D66840 VA: 0x1D6A840
	internal void AbortConnect() { }

	// RVA: 0x1D6A8CC Offset: 0x1D668CC VA: 0x1D6A8CC
	private static void AcceptCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1D6ACDC Offset: 0x1D66CDC VA: 0x1D6ACDC
	private static void ConnectCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1D6AE8C Offset: 0x1D66E8C VA: 0x1D6AE8C
	private static void SSLHandshakeCallback(IAsyncResult asyncResult) { }

	// RVA: 0x1D6B03C Offset: 0x1D6703C VA: 0x1D6B03C
	private CommandStream.PipelineInstruction QueueOrCreateFtpDataStream(ref Stream stream) { }

	// RVA: 0x1D6B628 Offset: 0x1D67628 VA: 0x1D6B628 Slot: 39
	protected override void ClearState() { }

	// RVA: 0x1D6B6F8 Offset: 0x1D676F8 VA: 0x1D6B6F8 Slot: 41
	protected override CommandStream.PipelineInstruction PipelineCallback(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream) { }

	// RVA: 0x1D6D024 Offset: 0x1D69024 VA: 0x1D6D024 Slot: 40
	protected override CommandStream.PipelineEntry[] BuildCommandsList(WebRequest req) { }

	// RVA: 0x1D6BFA4 Offset: 0x1D67FA4 VA: 0x1D6BFA4
	private CommandStream.PipelineInstruction QueueOrCreateDataConection(CommandStream.PipelineEntry entry, ResponseDescription response, bool timeout, ref Stream stream, out bool isSocketReady) { }

	// RVA: 0x1D6E060 Offset: 0x1D6A060 VA: 0x1D6E060
	private static void GetPathInfo(FtpControlStream.GetPathOption pathOption, Uri uri, out string path, out string directory, out string filename) { }

	// RVA: 0x1D6EA40 Offset: 0x1D6AA40 VA: 0x1D6EA40
	private string FormatAddress(IPAddress address, int Port) { }

	// RVA: 0x1D6EB6C Offset: 0x1D6AB6C VA: 0x1D6EB6C
	private string FormatAddressV6(IPAddress address, int port) { }

	// RVA: 0x1D6EC7C Offset: 0x1D6AC7C VA: 0x1D6EC7C
	internal long get_ContentLength() { }

	// RVA: 0x1D6EC84 Offset: 0x1D6AC84 VA: 0x1D6EC84
	internal DateTime get_LastModified() { }

	// RVA: 0x1D6EC8C Offset: 0x1D6AC8C VA: 0x1D6EC8C
	internal Uri get_ResponseUri() { }

	// RVA: 0x1D6EC94 Offset: 0x1D6AC94 VA: 0x1D6EC94
	internal string get_BannerMessage() { }

	// RVA: 0x1D6ECAC Offset: 0x1D6ACAC VA: 0x1D6ECAC
	internal string get_WelcomeMessage() { }

	// RVA: 0x1D6ECC4 Offset: 0x1D6ACC4 VA: 0x1D6ECC4
	internal string get_ExitMessage() { }

	// RVA: 0x1D6CAC4 Offset: 0x1D68AC4 VA: 0x1D6CAC4
	private long GetContentLengthFrom213Response(string responseString) { }

	// RVA: 0x1D6CBF0 Offset: 0x1D68BF0 VA: 0x1D6CBF0
	private DateTime GetLastModifiedFrom213Response(string str) { }

	// RVA: 0x1D6C75C Offset: 0x1D6875C VA: 0x1D6C75C
	private void TryUpdateResponseUri(string str, FtpWebRequest request) { }

	// RVA: 0x1D6C664 Offset: 0x1D68664 VA: 0x1D6C664
	private void TryUpdateContentLength(string str) { }

	// RVA: 0x1D6CF94 Offset: 0x1D68F94 VA: 0x1D6CF94
	private string GetLoginDirectory(string str) { }

	// RVA: 0x1D6E5B8 Offset: 0x1D6A5B8 VA: 0x1D6E5B8
	private int GetPortV4(string responseString) { }

	// RVA: 0x1D6E78C Offset: 0x1D6A78C VA: 0x1D6E78C
	private int GetPortV6(string responseString) { }

	// RVA: 0x1D6E234 Offset: 0x1D6A234 VA: 0x1D6E234
	private void CreateFtpListenerSocket(FtpWebRequest request) { }

	// RVA: 0x1D6E3B8 Offset: 0x1D6A3B8 VA: 0x1D6E3B8
	private string GetPortCommandLine(FtpWebRequest request) { }

	// RVA: 0x1D6DF3C Offset: 0x1D69F3C VA: 0x1D6DF3C
	private string FormatFtpCommand(string command, string parameter) { }

	// RVA: 0x1D6E938 Offset: 0x1D6A938 VA: 0x1D6E938
	protected Socket CreateFtpDataSocket(FtpWebRequest request, Socket templateSocket) { }

	// RVA: 0x1D6ECDC Offset: 0x1D6ACDC VA: 0x1D6ECDC Slot: 42
	protected override bool CheckValid(ResponseDescription response, ref int validThrough, ref int completeLength) { }

	// RVA: 0x1D6B310 Offset: 0x1D67310 VA: 0x1D6B310
	private TriState IsFtpDataStreamWriteable() { }

	// RVA: 0x1D6F0C0 Offset: 0x1D6B0C0 VA: 0x1D6F0C0
	private static void .cctor() { }
}

// Namespace: System.Net
internal class FtpDataStream : Stream, ICloseEx // TypeDefIndex: 4141
{
	// Fields
	private FtpWebRequest _request; // 0x28
	private NetworkStream _networkStream; // 0x30
	private bool _writeable; // 0x38
	private bool _readable; // 0x39
	private bool _isFullyRead; // 0x3A
	private bool _closing; // 0x3B

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }

	// Methods

	// RVA: 0x1D6B394 Offset: 0x1D67394 VA: 0x1D6B394
	internal void .ctor(NetworkStream networkStream, FtpWebRequest request, TriState writeOnly) { }

	// RVA: 0x1D6F2E8 Offset: 0x1D6B2E8 VA: 0x1D6F2E8 Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1D6F45C Offset: 0x1D6B45C VA: 0x1D6F45C Slot: 38
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1D6F890 Offset: 0x1D6B890 VA: 0x1D6F890
	private void CheckError() { }

	// RVA: 0x1D6F8D0 Offset: 0x1D6B8D0 VA: 0x1D6F8D0 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1D6F8D8 Offset: 0x1D6B8D8 VA: 0x1D6F8D8 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1D6F8F4 Offset: 0x1D6B8F4 VA: 0x1D6F8F4 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1D6F8FC Offset: 0x1D6B8FC VA: 0x1D6F8FC Slot: 11
	public override long get_Length() { }

	// RVA: 0x1D6F918 Offset: 0x1D6B918 VA: 0x1D6F918 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1D6F934 Offset: 0x1D6B934 VA: 0x1D6F934 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1D6F954 Offset: 0x1D6B954 VA: 0x1D6F954 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1D6FA20 Offset: 0x1D6BA20 VA: 0x1D6FA20 Slot: 32
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1D6FB24 Offset: 0x1D6BB24 VA: 0x1D6FB24 Slot: 35
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1D6FBFC Offset: 0x1D6BBFC VA: 0x1D6FBFC
	private void AsyncReadCallback(IAsyncResult ar) { }

	// RVA: 0x1D6FF28 Offset: 0x1D6BF28 VA: 0x1D6FF28 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1D70178 Offset: 0x1D6C178 VA: 0x1D70178 Slot: 23
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x1D7030C Offset: 0x1D6C30C VA: 0x1D7030C Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1D70400 Offset: 0x1D6C400 VA: 0x1D70400 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1D70494 Offset: 0x1D6C494 VA: 0x1D70494 Slot: 21
	public override void Flush() { }

	// RVA: 0x1D704B4 Offset: 0x1D6C4B4 VA: 0x1D704B4 Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1D704D4 Offset: 0x1D6C4D4 VA: 0x1D704D4 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1D704F0 Offset: 0x1D6C4F0 VA: 0x1D704F0 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1D70510 Offset: 0x1D6C510 VA: 0x1D70510 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1D70530 Offset: 0x1D6C530 VA: 0x1D70530 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1D70550 Offset: 0x1D6C550 VA: 0x1D70550 Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1D70570 Offset: 0x1D6C570 VA: 0x1D70570
	internal void SetSocketTimeoutOption(int timeout) { }
}

// Namespace: System.Net
internal enum FtpOperation // TypeDefIndex: 4142
{
	// Fields
	public int value__; // 0x0
	public const FtpOperation DownloadFile = 0;
	public const FtpOperation ListDirectory = 1;
	public const FtpOperation ListDirectoryDetails = 2;
	public const FtpOperation UploadFile = 3;
	public const FtpOperation UploadFileUnique = 4;
	public const FtpOperation AppendFile = 5;
	public const FtpOperation DeleteFile = 6;
	public const FtpOperation GetDateTimestamp = 7;
	public const FtpOperation GetFileSize = 8;
	public const FtpOperation Rename = 9;
	public const FtpOperation MakeDirectory = 10;
	public const FtpOperation RemoveDirectory = 11;
	public const FtpOperation PrintWorkingDirectory = 12;
	public const FtpOperation Other = 13;
}

// Namespace: System.Net
[Flags]
internal enum FtpMethodFlags // TypeDefIndex: 4143
{
	// Fields
	public int value__; // 0x0
	public const FtpMethodFlags None = 0;
	public const FtpMethodFlags IsDownload = 1;
	public const FtpMethodFlags IsUpload = 2;
	public const FtpMethodFlags TakesParameter = 4;
	public const FtpMethodFlags MayTakeParameter = 8;
	public const FtpMethodFlags DoesNotTakeParameter = 16;
	public const FtpMethodFlags ParameterIsDirectory = 32;
	public const FtpMethodFlags ShouldParseForResponseUri = 64;
	public const FtpMethodFlags HasHttpCommand = 128;
	public const FtpMethodFlags MustChangeWorkingDirectoryToPath = 256;
}

// Namespace: System.Net
internal class FtpMethodInfo // TypeDefIndex: 4144
{
	// Fields
	internal string Method; // 0x10
	internal FtpOperation Operation; // 0x18
	internal FtpMethodFlags Flags; // 0x1C
	internal string HttpCommand; // 0x20
	private static readonly FtpMethodInfo[] s_knownMethodInfo; // 0x0

	// Properties
	internal bool IsCommandOnly { get; }
	internal bool IsUpload { get; }
	internal bool IsDownload { get; }
	internal bool ShouldParseForResponseUri { get; }

	// Methods

	// RVA: 0x1D705C0 Offset: 0x1D6C5C0 VA: 0x1D705C0
	internal void .ctor(string method, FtpOperation operation, FtpMethodFlags flags, string httpCommand) { }

	// RVA: 0x1D6E050 Offset: 0x1D6A050 VA: 0x1D6E050
	internal bool HasFlag(FtpMethodFlags flags) { }

	// RVA: 0x1D6E224 Offset: 0x1D6A224 VA: 0x1D6E224
	internal bool get_IsCommandOnly() { }

	// RVA: 0x1D6F0A8 Offset: 0x1D6B0A8 VA: 0x1D6F0A8
	internal bool get_IsUpload() { }

	// RVA: 0x1D6F0B4 Offset: 0x1D6B0B4 VA: 0x1D6F0B4
	internal bool get_IsDownload() { }

	// RVA: 0x1D6C750 Offset: 0x1D68750 VA: 0x1D6C750
	internal bool get_ShouldParseForResponseUri() { }

	// RVA: 0x1D70618 Offset: 0x1D6C618 VA: 0x1D70618
	internal static FtpMethodInfo GetMethodInfo(string method) { }

	// RVA: 0x1D70778 Offset: 0x1D6C778 VA: 0x1D70778
	private static void .cctor() { }
}

// Namespace: 
private enum FtpWebRequest.RequestStage // TypeDefIndex: 4145
{
	// Fields
	public int value__; // 0x0
	public const FtpWebRequest.RequestStage CheckForError = 0;
	public const FtpWebRequest.RequestStage RequestStarted = 1;
	public const FtpWebRequest.RequestStage WriteReady = 2;
	public const FtpWebRequest.RequestStage ReadReady = 3;
	public const FtpWebRequest.RequestStage ReleaseConnection = 4;
}

// Namespace: 
[CompilerGenerated]
private struct FtpWebRequest.<CreateConnectionAsync>d__86 : IAsyncStateMachine // TypeDefIndex: 4146
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public FtpWebRequest <>4__this; // 0x28
	private TcpClient <client>5__2; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x1D76888 Offset: 0x1D72888 VA: 0x1D76888 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1D76C00 Offset: 0x1D72C00 VA: 0x1D76C00 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class FtpWebRequest.<>c // TypeDefIndex: 4147
{
	// Fields
	public static readonly FtpWebRequest.<>c <>9; // 0x0
	public static Func<X509CertificateCollection> <>9__114_0; // 0x8

	// Methods

	// RVA: 0x1D76C0C Offset: 0x1D72C0C VA: 0x1D76C0C
	private static void .cctor() { }

	// RVA: 0x1D76C74 Offset: 0x1D72C74 VA: 0x1D76C74
	public void .ctor() { }

	// RVA: 0x1D76C7C Offset: 0x1D72C7C VA: 0x1D76C7C
	internal X509CertificateCollection <get_ClientCertificates>b__114_0() { }
}

// Namespace: System.Net
public sealed class FtpWebRequest : WebRequest // TypeDefIndex: 4148
{
	// Fields
	private object _syncObject; // 0x38
	private ICredentials _authInfo; // 0x40
	private readonly Uri _uri; // 0x48
	private FtpMethodInfo _methodInfo; // 0x50
	private string _renameTo; // 0x58
	private bool _getRequestStreamStarted; // 0x60
	private bool _getResponseStarted; // 0x61
	private DateTime _startTime; // 0x68
	private int _timeout; // 0x70
	private int _remainingTimeout; // 0x74
	private long _contentLength; // 0x78
	private long _contentOffset; // 0x80
	private X509CertificateCollection _clientCertificates; // 0x88
	private bool _passive; // 0x90
	private bool _binary; // 0x91
	private bool _async; // 0x92
	private bool _aborted; // 0x93
	private bool _timedOut; // 0x94
	private Exception _exception; // 0x98
	private TimerThread.Queue _timerQueue; // 0xA0
	private TimerThread.Callback _timerCallback; // 0xA8
	private bool _enableSsl; // 0xB0
	private FtpControlStream _connection; // 0xB8
	private Stream _stream; // 0xC0
	private FtpWebRequest.RequestStage _requestStage; // 0xC8
	private bool _onceFailed; // 0xCC
	private WebHeaderCollection _ftpRequestHeaders; // 0xD0
	private FtpWebResponse _ftpWebResponse; // 0xD8
	private int _readWriteTimeout; // 0xE0
	private ContextAwareResult _writeAsyncResult; // 0xE8
	private LazyAsyncResult _readAsyncResult; // 0xF0
	private LazyAsyncResult _requestCompleteAsyncResult; // 0xF8
	private static readonly NetworkCredential s_defaultFtpNetworkCredential; // 0x0
	private static readonly TimerThread.Queue s_DefaultTimerQueue; // 0x8

	// Properties
	internal FtpMethodInfo MethodInfo { get; }
	public override string Method { get; set; }
	public string RenameTo { get; }
	public override ICredentials Credentials { get; set; }
	public override Uri RequestUri { get; }
	public override int Timeout { get; }
	internal int RemainingTimeout { get; }
	public int ReadWriteTimeout { get; }
	public long ContentOffset { get; }
	public override long ContentLength { get; }
	public override IWebProxy Proxy { get; set; }
	internal bool Aborted { get; }
	private TimerThread.Queue TimerQueue { get; }
	public override RequestCachePolicy CachePolicy { set; }
	public bool UseBinary { get; }
	public bool UsePassive { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public bool EnableSsl { get; }
	public override WebHeaderCollection Headers { get; }
	public override bool UseDefaultCredentials { get; }
	private bool InUse { get; }

	// Methods

	// RVA: 0x1D70D6C Offset: 0x1D6CD6C VA: 0x1D70D6C
	internal FtpMethodInfo get_MethodInfo() { }

	// RVA: 0x1D70D74 Offset: 0x1D6CD74 VA: 0x1D70D74 Slot: 9
	public override string get_Method() { }

	// RVA: 0x1D70D8C Offset: 0x1D6CD8C VA: 0x1D70D8C Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x1D70F58 Offset: 0x1D6CF58 VA: 0x1D70F58
	public string get_RenameTo() { }

	// RVA: 0x1D70F60 Offset: 0x1D6CF60 VA: 0x1D70F60 Slot: 14
	public override ICredentials get_Credentials() { }

	// RVA: 0x1D70F68 Offset: 0x1D6CF68 VA: 0x1D70F68 Slot: 15
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1D710B4 Offset: 0x1D6D0B4 VA: 0x1D710B4 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x1D710BC Offset: 0x1D6D0BC VA: 0x1D710BC Slot: 19
	public override int get_Timeout() { }

	// RVA: 0x1D710C4 Offset: 0x1D6D0C4 VA: 0x1D710C4
	internal int get_RemainingTimeout() { }

	// RVA: 0x1D710CC Offset: 0x1D6D0CC VA: 0x1D710CC
	public int get_ReadWriteTimeout() { }

	// RVA: 0x1D710D4 Offset: 0x1D6D0D4 VA: 0x1D710D4
	public long get_ContentOffset() { }

	// RVA: 0x1D710DC Offset: 0x1D6D0DC VA: 0x1D710DC Slot: 13
	public override long get_ContentLength() { }

	// RVA: 0x1D710E4 Offset: 0x1D6D0E4 VA: 0x1D710E4 Slot: 17
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1D710EC Offset: 0x1D6D0EC VA: 0x1D710EC Slot: 18
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1D7114C Offset: 0x1D6D14C VA: 0x1D7114C
	internal bool get_Aborted() { }

	// RVA: 0x1D71154 Offset: 0x1D6D154 VA: 0x1D71154
	internal void .ctor(Uri uri) { }

	// RVA: 0x1D715B4 Offset: 0x1D6D5B4 VA: 0x1D715B4 Slot: 20
	public override WebResponse GetResponse() { }

	// RVA: 0x1D730A4 Offset: 0x1D6F0A4 VA: 0x1D730A4 Slot: 21
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1D7377C Offset: 0x1D6F77C VA: 0x1D7377C Slot: 22
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1D72230 Offset: 0x1D6E230 VA: 0x1D72230
	private void SubmitRequest(bool isAsync) { }

	// RVA: 0x1D743F8 Offset: 0x1D703F8 VA: 0x1D743F8
	private Exception TranslateConnectException(Exception e) { }

	[AsyncStateMachine(typeof(FtpWebRequest.<CreateConnectionAsync>d__86))]
	// RVA: 0x1D73B7C Offset: 0x1D6FB7C VA: 0x1D73B7C
	private void CreateConnectionAsync() { }

	// RVA: 0x1D73C24 Offset: 0x1D6FC24 VA: 0x1D73C24
	private FtpControlStream CreateConnection() { }

	// RVA: 0x1D73DD8 Offset: 0x1D6FDD8 VA: 0x1D73DD8
	private Stream TimedSubmitRequestHelper(bool isAsync) { }

	// RVA: 0x1D7456C Offset: 0x1D7056C VA: 0x1D7456C
	private void TimerCallback(TimerThread.Timer timer, int timeNoticed, object context) { }

	// RVA: 0x1D744F0 Offset: 0x1D704F0 VA: 0x1D744F0
	private TimerThread.Queue get_TimerQueue() { }

	// RVA: 0x1D741A4 Offset: 0x1D701A4 VA: 0x1D741A4
	private bool AttemptedRecovery(Exception e) { }

	// RVA: 0x1D72CE4 Offset: 0x1D6ECE4 VA: 0x1D72CE4
	private void SetException(Exception exception) { }

	// RVA: 0x1D71D78 Offset: 0x1D6DD78 VA: 0x1D71D78
	private void CheckError() { }

	// RVA: 0x1D68688 Offset: 0x1D64688 VA: 0x1D68688
	internal void RequestCallback(object obj) { }

	// RVA: 0x1D759D0 Offset: 0x1D719D0 VA: 0x1D759D0
	private void SyncRequestCallback(object obj) { }

	// RVA: 0x1D74FA0 Offset: 0x1D70FA0 VA: 0x1D74FA0
	private void AsyncRequestCallback(object obj) { }

	// RVA: 0x1D71E04 Offset: 0x1D6DE04 VA: 0x1D71E04
	private FtpWebRequest.RequestStage FinishRequestStage(FtpWebRequest.RequestStage stage) { }

	// RVA: 0x1D75DF4 Offset: 0x1D71DF4 VA: 0x1D75DF4 Slot: 24
	public override void Abort() { }

	// RVA: 0x1D76290 Offset: 0x1D72290 VA: 0x1D76290 Slot: 8
	public override void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x1D762F0 Offset: 0x1D722F0 VA: 0x1D762F0
	public bool get_UseBinary() { }

	// RVA: 0x1D762F8 Offset: 0x1D722F8 VA: 0x1D762F8
	public bool get_UsePassive() { }

	// RVA: 0x1D6B52C Offset: 0x1D6752C VA: 0x1D6B52C
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1D76300 Offset: 0x1D72300 VA: 0x1D76300
	public bool get_EnableSsl() { }

	// RVA: 0x1D76308 Offset: 0x1D72308 VA: 0x1D76308 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1D763D8 Offset: 0x1D723D8 VA: 0x1D763D8 Slot: 16
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1D70F38 Offset: 0x1D6CF38 VA: 0x1D70F38
	private bool get_InUse() { }

	// RVA: 0x1D727D0 Offset: 0x1D6E7D0 VA: 0x1D727D0
	private void EnsureFtpWebResponse(Exception exception) { }

	// RVA: 0x1D76690 Offset: 0x1D72690 VA: 0x1D76690
	internal void DataStreamClosed(CloseExState closeState) { }

	// RVA: 0x1D7670C Offset: 0x1D7270C VA: 0x1D7670C
	private static void .cctor() { }
}

// Namespace: System.Net
internal class FtpWebRequestCreator : IWebRequestCreate // TypeDefIndex: 4149
{
	// Methods

	// RVA: 0x1D76CD0 Offset: 0x1D72CD0 VA: 0x1D76CD0
	internal void .ctor() { }

	// RVA: 0x1D76CD8 Offset: 0x1D72CD8 VA: 0x1D76CD8 Slot: 4
	public WebRequest Create(Uri uri) { }
}

// Namespace: 
internal sealed class FtpWebResponse.EmptyStream : MemoryStream // TypeDefIndex: 4150
{
	// Methods

	// RVA: 0x1D76DA4 Offset: 0x1D72DA4 VA: 0x1D76DA4
	internal void .ctor() { }
}

// Namespace: System.Net
public class FtpWebResponse : WebResponse, IDisposable // TypeDefIndex: 4151
{
	// Fields
	internal Stream _responseStream; // 0x20
	private long _contentLength; // 0x28
	private Uri _responseUri; // 0x30
	private FtpStatusCode _statusCode; // 0x38
	private string _statusLine; // 0x40
	private WebHeaderCollection _ftpRequestHeaders; // 0x48
	private DateTime _lastModified; // 0x50
	private string _bannerMessage; // 0x58
	private string _welcomeMessage; // 0x60
	private string _exitMessage; // 0x68

	// Properties
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	public FtpStatusCode StatusCode { get; }

	// Methods

	// RVA: 0x1D76524 Offset: 0x1D72524 VA: 0x1D76524
	internal void .ctor(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage) { }

	// RVA: 0x1D74F68 Offset: 0x1D70F68 VA: 0x1D74F68
	internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage) { }

	// RVA: 0x1D76D38 Offset: 0x1D72D38 VA: 0x1D76D38 Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x1D7647C Offset: 0x1D7247C VA: 0x1D7647C
	internal void SetResponseStream(Stream stream) { }

	// RVA: 0x1D76E48 Offset: 0x1D72E48 VA: 0x1D76E48 Slot: 9
	public override void Close() { }

	// RVA: 0x1D76F3C Offset: 0x1D72F3C VA: 0x1D76F3C Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1D7705C Offset: 0x1D7305C VA: 0x1D7705C Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x1D77064 Offset: 0x1D73064 VA: 0x1D77064
	public FtpStatusCode get_StatusCode() { }
}

// Namespace: System.Net
internal class NetworkStreamWrapper : Stream // TypeDefIndex: 4152
{
	// Fields
	private TcpClient _client; // 0x28
	private NetworkStream _networkStream; // 0x30

	// Properties
	protected bool UsingSecureStream { get; }
	internal IPAddress ServerAddress { get; }
	internal Socket Socket { get; }
	internal NetworkStream NetworkStream { get; set; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1D682C0 Offset: 0x1D642C0 VA: 0x1D682C0
	internal void .ctor(TcpClient client) { }

	// RVA: 0x1D6B4B0 Offset: 0x1D674B0 VA: 0x1D6B4B0
	protected bool get_UsingSecureStream() { }

	// RVA: 0x1D6AC34 Offset: 0x1D66C34 VA: 0x1D6AC34
	internal IPAddress get_ServerAddress() { }

	// RVA: 0x1D6CAAC Offset: 0x1D68AAC VA: 0x1D6CAAC
	internal Socket get_Socket() { }

	// RVA: 0x1D7706C Offset: 0x1D7306C VA: 0x1D7706C
	internal NetworkStream get_NetworkStream() { }

	// RVA: 0x1D77074 Offset: 0x1D73074 VA: 0x1D77074
	internal void set_NetworkStream(NetworkStream value) { }

	// RVA: 0x1D7707C Offset: 0x1D7307C VA: 0x1D7707C Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1D77098 Offset: 0x1D73098 VA: 0x1D77098 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1D770B4 Offset: 0x1D730B4 VA: 0x1D770B4 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1D770D0 Offset: 0x1D730D0 VA: 0x1D770D0 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1D770EC Offset: 0x1D730EC VA: 0x1D770EC Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1D7710C Offset: 0x1D7310C VA: 0x1D7710C Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1D7712C Offset: 0x1D7312C VA: 0x1D7712C Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1D7714C Offset: 0x1D7314C VA: 0x1D7714C Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1D7716C Offset: 0x1D7316C VA: 0x1D7716C Slot: 11
	public override long get_Length() { }

	// RVA: 0x1D77188 Offset: 0x1D73188 VA: 0x1D77188 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1D771A4 Offset: 0x1D731A4 VA: 0x1D771A4 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1D771C4 Offset: 0x1D731C4 VA: 0x1D771C4 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1D771E4 Offset: 0x1D731E4 VA: 0x1D771E4 Slot: 32
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1D77204 Offset: 0x1D73204 VA: 0x1D77204 Slot: 35
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1D77224 Offset: 0x1D73224 VA: 0x1D77224 Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1D69A84 Offset: 0x1D65A84 VA: 0x1D69A84
	internal void CloseSocket() { }

	// RVA: 0x1D6854C Offset: 0x1D6454C VA: 0x1D6854C
	public void Close(int timeout) { }

	// RVA: 0x1D772C8 Offset: 0x1D732C8 VA: 0x1D772C8 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1D772E8 Offset: 0x1D732E8 VA: 0x1D772E8 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	// RVA: 0x1D77308 Offset: 0x1D73308 VA: 0x1D77308 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1D77328 Offset: 0x1D73328 VA: 0x1D77328 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1D77348 Offset: 0x1D73348 VA: 0x1D77348 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	// RVA: 0x1D77368 Offset: 0x1D73368 VA: 0x1D77368 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1D77388 Offset: 0x1D73388 VA: 0x1D77388 Slot: 21
	public override void Flush() { }

	// RVA: 0x1D773A8 Offset: 0x1D733A8 VA: 0x1D773A8 Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1D73D88 Offset: 0x1D6FD88 VA: 0x1D73D88
	internal void SetSocketTimeoutOption(int timeout) { }
}

// Namespace: System.Net
[Flags]
public enum SecurityProtocolType // TypeDefIndex: 4153
{
	// Fields
	public int value__; // 0x0
	public const SecurityProtocolType SystemDefault = 0;
	public const SecurityProtocolType Ssl3 = 48;
	public const SecurityProtocolType Tls = 192;
	public const SecurityProtocolType Tls11 = 768;
	public const SecurityProtocolType Tls12 = 3072;
	public const SecurityProtocolType Tls13 = 12288;
}

// Namespace: System.Net
public class Authorization // TypeDefIndex: 4154
{
	// Fields
	private string m_Message; // 0x10
	private bool m_Complete; // 0x18
	internal string ModuleAuthenticationType; // 0x20

	// Properties
	public string Message { get; }
	public bool Complete { get; }

	// Methods

	// RVA: 0x1D773C8 Offset: 0x1D733C8 VA: 0x1D773C8
	public void .ctor(string token) { }

	// RVA: 0x1D77474 Offset: 0x1D73474 VA: 0x1D77474
	public void .ctor(string token, bool finished) { }

	// RVA: 0x1D77510 Offset: 0x1D73510 VA: 0x1D77510
	public string get_Message() { }

	// RVA: 0x1D77518 Offset: 0x1D73518 VA: 0x1D77518
	public bool get_Complete() { }
}

// Namespace: System.Net
public class CredentialCache // TypeDefIndex: 4155
{
	// Properties
	public static ICredentials DefaultCredentials { get; }
	public static NetworkCredential DefaultNetworkCredentials { get; }

	// Methods

	// RVA: 0x1D77520 Offset: 0x1D73520 VA: 0x1D77520
	public static ICredentials get_DefaultCredentials() { }

	// RVA: 0x1D77578 Offset: 0x1D73578 VA: 0x1D77578
	public static NetworkCredential get_DefaultNetworkCredentials() { }
}

// Namespace: System.Net
internal class SystemNetworkCredential : NetworkCredential // TypeDefIndex: 4156
{
	// Fields
	internal static readonly SystemNetworkCredential defaultCredential; // 0x0

	// Methods

	// RVA: 0x1D775D0 Offset: 0x1D735D0 VA: 0x1D775D0
	private void .ctor() { }

	// RVA: 0x1D775F0 Offset: 0x1D735F0 VA: 0x1D775F0
	private static void .cctor() { }
}

// Namespace: System.Net
public class DnsEndPoint : EndPoint // TypeDefIndex: 4157
{
	// Fields
	private string m_Host; // 0x10
	private int m_Port; // 0x18

	// Properties
	public string Host { get; }
	public int Port { get; }

	// Methods

	// RVA: 0x1D77670 Offset: 0x1D73670 VA: 0x1D77670
	public string get_Host() { }

	// RVA: 0x1D77678 Offset: 0x1D73678 VA: 0x1D77678
	public int get_Port() { }
}

// Namespace: System.Net
[Serializable]
public abstract class EndPoint // TypeDefIndex: 4158
{
	// Properties
	public virtual AddressFamily AddressFamily { get; }

	// Methods

	// RVA: 0x1D77680 Offset: 0x1D73680 VA: 0x1D77680 Slot: 4
	public virtual AddressFamily get_AddressFamily() { }

	// RVA: 0x1D77724 Offset: 0x1D73724 VA: 0x1D77724 Slot: 5
	public virtual SocketAddress Serialize() { }

	// RVA: 0x1D777C8 Offset: 0x1D737C8 VA: 0x1D777C8 Slot: 6
	public virtual EndPoint Create(SocketAddress socketAddress) { }

	// RVA: 0x1D67C1C Offset: 0x1D63C1C VA: 0x1D67C1C
	protected void .ctor() { }
}

// Namespace: System.Net
public enum FtpStatusCode // TypeDefIndex: 4159
{
	// Fields
	public int value__; // 0x0
	public const FtpStatusCode Undefined = 0;
	public const FtpStatusCode RestartMarker = 110;
	public const FtpStatusCode ServiceTemporarilyNotAvailable = 120;
	public const FtpStatusCode DataAlreadyOpen = 125;
	public const FtpStatusCode OpeningData = 150;
	public const FtpStatusCode CommandOK = 200;
	public const FtpStatusCode CommandExtraneous = 202;
	public const FtpStatusCode DirectoryStatus = 212;
	public const FtpStatusCode FileStatus = 213;
	public const FtpStatusCode SystemType = 215;
	public const FtpStatusCode SendUserCommand = 220;
	public const FtpStatusCode ClosingControl = 221;
	public const FtpStatusCode ClosingData = 226;
	public const FtpStatusCode EnteringPassive = 227;
	public const FtpStatusCode LoggedInProceed = 230;
	public const FtpStatusCode ServerWantsSecureSession = 234;
	public const FtpStatusCode FileActionOK = 250;
	public const FtpStatusCode PathnameCreated = 257;
	public const FtpStatusCode SendPasswordCommand = 331;
	public const FtpStatusCode NeedLoginAccount = 332;
	public const FtpStatusCode FileCommandPending = 350;
	public const FtpStatusCode ServiceNotAvailable = 421;
	public const FtpStatusCode CantOpenData = 425;
	public const FtpStatusCode ConnectionClosed = 426;
	public const FtpStatusCode ActionNotTakenFileUnavailableOrBusy = 450;
	public const FtpStatusCode ActionAbortedLocalProcessingError = 451;
	public const FtpStatusCode ActionNotTakenInsufficientSpace = 452;
	public const FtpStatusCode CommandSyntaxError = 500;
	public const FtpStatusCode ArgumentSyntaxError = 501;
	public const FtpStatusCode CommandNotImplemented = 502;
	public const FtpStatusCode BadCommandSequence = 503;
	public const FtpStatusCode NotLoggedIn = 530;
	public const FtpStatusCode AccountNeeded = 532;
	public const FtpStatusCode ActionNotTakenFileUnavailable = 550;
	public const FtpStatusCode ActionAbortedUnknownPageType = 551;
	public const FtpStatusCode FileActionAborted = 552;
	public const FtpStatusCode ActionNotTakenFilenameNotAllowed = 553;
}

// Namespace: System.Net
public enum HttpRequestHeader // TypeDefIndex: 4160
{
	// Fields
	public int value__; // 0x0
	public const HttpRequestHeader CacheControl = 0;
	public const HttpRequestHeader Connection = 1;
	public const HttpRequestHeader Date = 2;
	public const HttpRequestHeader KeepAlive = 3;
	public const HttpRequestHeader Pragma = 4;
	public const HttpRequestHeader Trailer = 5;
	public const HttpRequestHeader TransferEncoding = 6;
	public const HttpRequestHeader Upgrade = 7;
	public const HttpRequestHeader Via = 8;
	public const HttpRequestHeader Warning = 9;
	public const HttpRequestHeader Allow = 10;
	public const HttpRequestHeader ContentLength = 11;
	public const HttpRequestHeader ContentType = 12;
	public const HttpRequestHeader ContentEncoding = 13;
	public const HttpRequestHeader ContentLanguage = 14;
	public const HttpRequestHeader ContentLocation = 15;
	public const HttpRequestHeader ContentMd5 = 16;
	public const HttpRequestHeader ContentRange = 17;
	public const HttpRequestHeader Expires = 18;
	public const HttpRequestHeader LastModified = 19;
	public const HttpRequestHeader Accept = 20;
	public const HttpRequestHeader AcceptCharset = 21;
	public const HttpRequestHeader AcceptEncoding = 22;
	public const HttpRequestHeader AcceptLanguage = 23;
	public const HttpRequestHeader Authorization = 24;
	public const HttpRequestHeader Cookie = 25;
	public const HttpRequestHeader Expect = 26;
	public const HttpRequestHeader From = 27;
	public const HttpRequestHeader Host = 28;
	public const HttpRequestHeader IfMatch = 29;
	public const HttpRequestHeader IfModifiedSince = 30;
	public const HttpRequestHeader IfNoneMatch = 31;
	public const HttpRequestHeader IfRange = 32;
	public const HttpRequestHeader IfUnmodifiedSince = 33;
	public const HttpRequestHeader MaxForwards = 34;
	public const HttpRequestHeader ProxyAuthorization = 35;
	public const HttpRequestHeader Referer = 36;
	public const HttpRequestHeader Range = 37;
	public const HttpRequestHeader Te = 38;
	public const HttpRequestHeader Translate = 39;
	public const HttpRequestHeader UserAgent = 40;
}

// Namespace: System.Net
public interface IAuthenticationModule // TypeDefIndex: 4161
{
	// Properties
	public abstract string AuthenticationType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Authorization PreAuthenticate(WebRequest request, ICredentials credentials);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_AuthenticationType();
}

// Namespace: System.Net
public interface ICertificatePolicy // TypeDefIndex: 4162
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CheckValidationResult(ServicePoint srvPoint, X509Certificate certificate, WebRequest request, int certificateProblem);
}

// Namespace: System.Net
public interface ICredentials // TypeDefIndex: 4163
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract NetworkCredential GetCredential(Uri uri, string authType);
}

// Namespace: System.Net
public class IPHostEntry // TypeDefIndex: 4164
{
	// Fields
	private string hostName; // 0x10
	private string[] aliases; // 0x18
	private IPAddress[] addressList; // 0x20
	internal bool isTrustedHost; // 0x28

	// Properties
	public string HostName { get; set; }
	public string[] Aliases { set; }
	public IPAddress[] AddressList { get; set; }

	// Methods

	// RVA: 0x1D777EC Offset: 0x1D737EC VA: 0x1D777EC
	public string get_HostName() { }

	// RVA: 0x1D777F4 Offset: 0x1D737F4 VA: 0x1D777F4
	public void set_HostName(string value) { }

	// RVA: 0x1D777FC Offset: 0x1D737FC VA: 0x1D777FC
	public void set_Aliases(string[] value) { }

	// RVA: 0x1D77804 Offset: 0x1D73804 VA: 0x1D77804
	public IPAddress[] get_AddressList() { }

	// RVA: 0x1D7780C Offset: 0x1D7380C VA: 0x1D7780C
	public void set_AddressList(IPAddress[] value) { }

	// RVA: 0x1D77814 Offset: 0x1D73814 VA: 0x1D77814
	public void .ctor() { }
}

// Namespace: System.Net
public interface IWebRequestCreate // TypeDefIndex: 4165
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract WebRequest Create(Uri uri);
}

// Namespace: System.Net
internal class InternalException : SystemException // TypeDefIndex: 4166
{
	// Methods

	// RVA: 0x1D690E4 Offset: 0x1D650E4 VA: 0x1D690E4
	internal void .ctor() { }
}

// Namespace: System.Net
internal static class NclUtilities // TypeDefIndex: 4167
{
	// Fields
	private static IPAddress[] _LocalAddresses; // 0x0
	private static object _LocalAddressesLock; // 0x8
	internal static string _LocalDomainName; // 0x10

	// Properties
	internal static IPAddress[] LocalAddresses { get; }
	private static object LocalAddressesLock { get; }

	// Methods

	// RVA: 0x1D77824 Offset: 0x1D73824 VA: 0x1D77824
	internal static bool IsFatal(Exception exception) { }

	// RVA: 0x1D778F4 Offset: 0x1D738F4 VA: 0x1D778F4
	internal static bool IsAddressLocal(IPAddress ipAddress) { }

	// RVA: 0x1D77E70 Offset: 0x1D73E70 VA: 0x1D77E70
	private static IPHostEntry GetLocalHost() { }

	// RVA: 0x1D77984 Offset: 0x1D73984 VA: 0x1D77984
	internal static IPAddress[] get_LocalAddresses() { }

	// RVA: 0x1D77E88 Offset: 0x1D73E88 VA: 0x1D77E88
	private static object get_LocalAddressesLock() { }
}

// Namespace: System.Net
internal static class ValidationHelper // TypeDefIndex: 4168
{
	// Fields
	public static string[] EmptyArray; // 0x0
	internal static readonly char[] InvalidMethodChars; // 0x8
	internal static readonly char[] InvalidParamChars; // 0x10

	// Methods

	// RVA: 0x1D77460 Offset: 0x1D73460 VA: 0x1D77460
	public static string MakeStringNull(string stringValue) { }

	// RVA: 0x1D77F24 Offset: 0x1D73F24 VA: 0x1D77F24
	public static bool IsBlankString(string stringValue) { }

	// RVA: 0x1D77F40 Offset: 0x1D73F40 VA: 0x1D77F40
	public static bool ValidateTcpPort(int port) { }

	// RVA: 0x1D77F4C Offset: 0x1D73F4C VA: 0x1D77F4C
	private static void .cctor() { }
}

// Namespace: System.Net
internal static class ExceptionHelper // TypeDefIndex: 4169
{
	// Properties
	internal static NotImplementedException MethodNotImplementedException { get; }
	internal static NotImplementedException PropertyNotImplementedException { get; }
	internal static WebException TimeoutException { get; }
	internal static NotSupportedException PropertyNotSupportedException { get; }
	internal static WebException RequestAbortedException { get; }

	// Methods

	// RVA: 0x1D77748 Offset: 0x1D73748 VA: 0x1D77748
	internal static NotImplementedException get_MethodNotImplementedException() { }

	// RVA: 0x1D776A4 Offset: 0x1D736A4 VA: 0x1D776A4
	internal static NotImplementedException get_PropertyNotImplementedException() { }

	// RVA: 0x1D71D8C Offset: 0x1D6DD8C VA: 0x1D71D8C
	internal static WebException get_TimeoutException() { }

	// RVA: 0x1D763FC Offset: 0x1D723FC VA: 0x1D763FC
	internal static NotSupportedException get_PropertyNotSupportedException() { }

	// RVA: 0x1D6E9B4 Offset: 0x1D6A9B4 VA: 0x1D6E9B4
	internal static WebException get_RequestAbortedException() { }
}

// Namespace: System.Net
internal class WebRequestPrefixElement // TypeDefIndex: 4170
{
	// Fields
	public string Prefix; // 0x10
	internal IWebRequestCreate creator; // 0x18
	internal Type creatorType; // 0x20

	// Properties
	public IWebRequestCreate Creator { get; set; }

	// Methods

	// RVA: 0x1D78128 Offset: 0x1D74128 VA: 0x1D78128
	public IWebRequestCreate get_Creator() { }

	// RVA: 0x1D7832C Offset: 0x1D7432C VA: 0x1D7832C
	public void set_Creator(IWebRequestCreate value) { }

	// RVA: 0x1D78334 Offset: 0x1D74334 VA: 0x1D78334
	public void .ctor(string P, IWebRequestCreate C) { }
}

// Namespace: System.Net
public sealed class HttpContinueDelegate : MulticastDelegate // TypeDefIndex: 4171
{
	// Methods

	// RVA: 0x1D78378 Offset: 0x1D74378 VA: 0x1D78378
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D78418 Offset: 0x1D74418 VA: 0x1D78418 Slot: 12
	public virtual void Invoke(int StatusCode, WebHeaderCollection httpHeaders) { }
}

// Namespace: System.Net
internal enum TriState // TypeDefIndex: 4172
{
	// Fields
	public int value__; // 0x0
	public const TriState Unspecified = -1;
	public const TriState False = 0;
	public const TriState True = 1;
}

// Namespace: System.Net
public class NetworkCredential : ICredentials // TypeDefIndex: 4173
{
	// Fields
	private string m_domain; // 0x10
	private string m_userName; // 0x18
	private SecureString m_password; // 0x20

	// Properties
	public string UserName { get; set; }
	public string Password { get; set; }
	public string Domain { get; set; }

	// Methods

	// RVA: 0x1D7159C Offset: 0x1D6D59C VA: 0x1D7159C
	public void .ctor(string userName, string password) { }

	// RVA: 0x1D76824 Offset: 0x1D72824 VA: 0x1D76824
	public void .ctor(string userName, string password, string domain) { }

	// RVA: 0x1D6E034 Offset: 0x1D6A034 VA: 0x1D6E034
	public string get_UserName() { }

	// RVA: 0x1D7842C Offset: 0x1D7442C VA: 0x1D7842C
	public void set_UserName(string value) { }

	// RVA: 0x1D6E044 Offset: 0x1D6A044 VA: 0x1D6E044
	public string get_Password() { }

	// RVA: 0x1D7844C Offset: 0x1D7444C VA: 0x1D7844C
	public void set_Password(string value) { }

	// RVA: 0x1D6E03C Offset: 0x1D6A03C VA: 0x1D6E03C
	public string get_Domain() { }

	// RVA: 0x1D78474 Offset: 0x1D74474 VA: 0x1D78474
	public void set_Domain(string value) { }

	// RVA: 0x1D784A0 Offset: 0x1D744A0 VA: 0x1D784A0
	internal string InternalGetUserName() { }

	// RVA: 0x1D78494 Offset: 0x1D74494 VA: 0x1D78494
	internal string InternalGetPassword() { }

	// RVA: 0x1D784A8 Offset: 0x1D744A8 VA: 0x1D784A8
	internal string InternalGetDomain() { }

	// RVA: 0x1D784B0 Offset: 0x1D744B0 VA: 0x1D784B0 Slot: 4
	public NetworkCredential GetCredential(Uri uri, string authType) { }
}

// Namespace: System.Net
[Serializable]
public class ProtocolViolationException : InvalidOperationException, ISerializable // TypeDefIndex: 4174
{
	// Methods

	// RVA: 0x1D784B4 Offset: 0x1D744B4 VA: 0x1D784B4
	public void .ctor() { }

	// RVA: 0x1D784BC Offset: 0x1D744BC VA: 0x1D784BC
	public void .ctor(string message) { }

	// RVA: 0x1D784C4 Offset: 0x1D744C4 VA: 0x1D784C4
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D784CC Offset: 0x1D744CC VA: 0x1D784CC Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D784D4 Offset: 0x1D744D4 VA: 0x1D784D4 Slot: 10
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Net
[DefaultMember("Item")]
public class SocketAddress // TypeDefIndex: 4175
{
	// Fields
	internal int m_Size; // 0x10
	internal byte[] m_Buffer; // 0x18
	private bool m_changed; // 0x20
	private int m_hash; // 0x24

	// Properties
	public AddressFamily Family { get; }
	public int Size { get; }
	public byte Item { get; }

	// Methods

	// RVA: 0x1D67FBC Offset: 0x1D63FBC VA: 0x1D67FBC
	public AddressFamily get_Family() { }

	// RVA: 0x1D784DC Offset: 0x1D744DC VA: 0x1D784DC
	public int get_Size() { }

	// RVA: 0x1D784E4 Offset: 0x1D744E4 VA: 0x1D784E4
	public byte get_Item(int offset) { }

	// RVA: 0x1D78558 Offset: 0x1D74558 VA: 0x1D78558
	public void .ctor(AddressFamily family, int size) { }

	// RVA: 0x1D78680 Offset: 0x1D74680 VA: 0x1D78680
	internal void .ctor(IPAddress ipAddress) { }

	// RVA: 0x1D67D68 Offset: 0x1D63D68 VA: 0x1D67D68
	internal void .ctor(IPAddress ipaddress, int port) { }

	// RVA: 0x1D78900 Offset: 0x1D74900 VA: 0x1D78900
	internal IPAddress GetIPAddress() { }

	// RVA: 0x1D67FEC Offset: 0x1D63FEC VA: 0x1D67FEC
	internal IPEndPoint GetIPEndPoint() { }

	// RVA: 0x1D78ADC Offset: 0x1D74ADC VA: 0x1D78ADC Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1D78BC0 Offset: 0x1D74BC0 VA: 0x1D78BC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D78D04 Offset: 0x1D74D04 VA: 0x1D78D04 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Net
[Serializable]
public class WebException : InvalidOperationException, ISerializable // TypeDefIndex: 4176
{
	// Fields
	private WebExceptionStatus m_Status; // 0x8C
	private WebResponse m_Response; // 0x90
	private WebExceptionInternalStatus m_InternalStatus; // 0x98

	// Properties
	public WebExceptionStatus Status { get; }
	public WebResponse Response { get; }

	// Methods

	// RVA: 0x1D78F94 Offset: 0x1D74F94 VA: 0x1D78F94
	public void .ctor() { }

	// RVA: 0x1D697A4 Offset: 0x1D657A4 VA: 0x1D697A4
	public void .ctor(string message) { }

	// RVA: 0x1D74F58 Offset: 0x1D70F58 VA: 0x1D74F58
	public void .ctor(string message, Exception innerException) { }

	// RVA: 0x1D6ACC8 Offset: 0x1D66CC8 VA: 0x1D6ACC8
	public void .ctor(string message, WebExceptionStatus status) { }

	// RVA: 0x1D78FA4 Offset: 0x1D74FA4 VA: 0x1D78FA4
	internal void .ctor(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) { }

	// RVA: 0x1D68D64 Offset: 0x1D64D64 VA: 0x1D68D64
	public void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x1D78FD8 Offset: 0x1D74FD8 VA: 0x1D78FD8
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) { }

	// RVA: 0x1D78FC0 Offset: 0x1D74FC0 VA: 0x1D78FC0
	internal void .ctor(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x1D790C0 Offset: 0x1D750C0 VA: 0x1D790C0
	internal void .ctor(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) { }

	// RVA: 0x1D791BC Offset: 0x1D751BC VA: 0x1D791BC
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D791CC Offset: 0x1D751CC VA: 0x1D791CC Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D791D8 Offset: 0x1D751D8 VA: 0x1D791D8 Slot: 10
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D791E0 Offset: 0x1D751E0 VA: 0x1D791E0
	public WebExceptionStatus get_Status() { }

	// RVA: 0x1D791E8 Offset: 0x1D751E8 VA: 0x1D791E8
	public WebResponse get_Response() { }
}

// Namespace: System.Net
internal enum WebExceptionInternalStatus // TypeDefIndex: 4177
{
	// Fields
	public int value__; // 0x0
	public const WebExceptionInternalStatus RequestFatal = 0;
	public const WebExceptionInternalStatus ServicePointFatal = 1;
	public const WebExceptionInternalStatus Recoverable = 2;
	public const WebExceptionInternalStatus Isolated = 3;
}

// Namespace: System.Net
public enum WebExceptionStatus // TypeDefIndex: 4178
{
	// Fields
	public int value__; // 0x0
	public const WebExceptionStatus Success = 0;
	public const WebExceptionStatus NameResolutionFailure = 1;
	public const WebExceptionStatus ConnectFailure = 2;
	public const WebExceptionStatus ReceiveFailure = 3;
	public const WebExceptionStatus SendFailure = 4;
	public const WebExceptionStatus PipelineFailure = 5;
	public const WebExceptionStatus RequestCanceled = 6;
	public const WebExceptionStatus ProtocolError = 7;
	public const WebExceptionStatus ConnectionClosed = 8;
	public const WebExceptionStatus TrustFailure = 9;
	public const WebExceptionStatus SecureChannelFailure = 10;
	public const WebExceptionStatus ServerProtocolViolation = 11;
	public const WebExceptionStatus KeepAliveFailure = 12;
	public const WebExceptionStatus Pending = 13;
	public const WebExceptionStatus Timeout = 14;
	public const WebExceptionStatus ProxyNameResolutionFailure = 15;
	public const WebExceptionStatus UnknownError = 16;
	public const WebExceptionStatus MessageLengthLimitExceeded = 17;
	public const WebExceptionStatus CacheEntryNotFound = 18;
	public const WebExceptionStatus RequestProhibitedByCachePolicy = 19;
	public const WebExceptionStatus RequestProhibitedByProxy = 20;
}

// Namespace: System.Net
internal static class WebExceptionMapping // TypeDefIndex: 4179
{
	// Fields
	private static readonly string[] s_Mapping; // 0x0

	// Methods

	// RVA: 0x1D791F0 Offset: 0x1D751F0 VA: 0x1D791F0
	internal static string GetWebStatusString(WebExceptionStatus status) { }

	// RVA: 0x1D7938C Offset: 0x1D7538C VA: 0x1D7938C
	private static void .cctor() { }
}

// Namespace: System.Net
internal enum WebHeaderCollectionType // TypeDefIndex: 4180
{
	// Fields
	public ushort value__; // 0x0
	public const WebHeaderCollectionType Unknown = 0;
	public const WebHeaderCollectionType WebRequest = 1;
	public const WebHeaderCollectionType WebResponse = 2;
	public const WebHeaderCollectionType HttpWebRequest = 3;
	public const WebHeaderCollectionType HttpWebResponse = 4;
	public const WebHeaderCollectionType HttpListenerRequest = 5;
	public const WebHeaderCollectionType HttpListenerResponse = 6;
	public const WebHeaderCollectionType FtpWebRequest = 7;
	public const WebHeaderCollectionType FtpWebResponse = 8;
	public const WebHeaderCollectionType FileWebRequest = 9;
	public const WebHeaderCollectionType FileWebResponse = 10;
}

// Namespace: 
private enum WebHeaderCollection.RfcChar // TypeDefIndex: 4181
{
	// Fields
	public byte value__; // 0x0
	public const WebHeaderCollection.RfcChar High = 0;
	public const WebHeaderCollection.RfcChar Reg = 1;
	public const WebHeaderCollection.RfcChar Ctl = 2;
	public const WebHeaderCollection.RfcChar CR = 3;
	public const WebHeaderCollection.RfcChar LF = 4;
	public const WebHeaderCollection.RfcChar WS = 5;
	public const WebHeaderCollection.RfcChar Colon = 6;
	public const WebHeaderCollection.RfcChar Delim = 7;
}

// Namespace: System.Net
[DefaultMember("Item")]
[ComVisible(True)]
[Serializable]
public class WebHeaderCollection : NameValueCollection, ISerializable // TypeDefIndex: 4182
{
	// Fields
	private static readonly HeaderInfoTable HInfo; // 0x0
	private string[] m_CommonHeaders; // 0x60
	private int m_NumCommonHeaders; // 0x68
	private static readonly string[] s_CommonHeaderNames; // 0x8
	private static readonly sbyte[] s_CommonHeaderHints; // 0x10
	private NameValueCollection m_InnerCollection; // 0x70
	private WebHeaderCollectionType m_Type; // 0x78
	private static readonly char[] HttpTrimCharacters; // 0x18
	private static WebHeaderCollection.RfcChar[] RfcCharMap; // 0x20

	// Properties
	private NameValueCollection InnerCollection { get; }
	private bool AllowHttpRequestHeader { get; }
	public override int Count { get; }

	// Methods

	// RVA: 0x1D79400 Offset: 0x1D75400 VA: 0x1D79400
	private void NormalizeCommonHeaders() { }

	// RVA: 0x1D79518 Offset: 0x1D75518 VA: 0x1D79518
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x1D795C0 Offset: 0x1D755C0 VA: 0x1D795C0
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x1D79744 Offset: 0x1D75744 VA: 0x1D79744
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x1D79788 Offset: 0x1D75788 VA: 0x1D79788
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x1D79880 Offset: 0x1D75880 VA: 0x1D79880
	internal void AddInternal(string name, string value) { }

	// RVA: 0x1D798D4 Offset: 0x1D758D4 VA: 0x1D798D4
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x1D79928 Offset: 0x1D75928 VA: 0x1D79928
	internal void RemoveInternal(string name) { }

	// RVA: 0x1D79984 Offset: 0x1D75984 VA: 0x1D79984
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x1D79CF0 Offset: 0x1D75CF0 VA: 0x1D79CF0
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x1D79D78 Offset: 0x1D75D78 VA: 0x1D79D78
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x1D79EE4 Offset: 0x1D75EE4 VA: 0x1D79EE4 Slot: 15
	public override void Add(string name, string value) { }

	// RVA: 0x1D7A094 Offset: 0x1D76094 VA: 0x1D7A094
	public void Add(string header) { }

	// RVA: 0x1D7A364 Offset: 0x1D76364 VA: 0x1D7A364 Slot: 18
	public override void Set(string name, string value) { }

	// RVA: 0x1D7A58C Offset: 0x1D7658C VA: 0x1D7A58C
	internal void SetInternal(string name, string value) { }

	// RVA: 0x1D7A7A8 Offset: 0x1D767A8 VA: 0x1D7A7A8 Slot: 19
	public override void Remove(string name) { }

	// RVA: 0x1D7A8E0 Offset: 0x1D768E0 VA: 0x1D7A8E0 Slot: 17
	public override string[] GetValues(string header) { }

	// RVA: 0x1D7AAE0 Offset: 0x1D76AE0 VA: 0x1D7AAE0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D7AB3C Offset: 0x1D76B3C VA: 0x1D7AB3C
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x1D76374 Offset: 0x1D72374 VA: 0x1D76374
	public void .ctor() { }

	// RVA: 0x1D7ADDC Offset: 0x1D76DDC VA: 0x1D7ADDC
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x1D7AED8 Offset: 0x1D76ED8 VA: 0x1D7AED8
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D7B0A4 Offset: 0x1D770A4 VA: 0x1D7B0A4 Slot: 12
	public override void OnDeserialization(object sender) { }

	// RVA: 0x1D7B0A8 Offset: 0x1D770A8 VA: 0x1D7B0A8 Slot: 11
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D7B228 Offset: 0x1D77228 VA: 0x1D7B228 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D7B234 Offset: 0x1D77234 VA: 0x1D7B234 Slot: 16
	public override string Get(string name) { }

	// RVA: 0x1D7B560 Offset: 0x1D77560 VA: 0x1D7B560 Slot: 13
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x1D7B5D4 Offset: 0x1D775D4 VA: 0x1D7B5D4 Slot: 14
	public override int get_Count() { }

	// RVA: 0x1D7B604 Offset: 0x1D77604 VA: 0x1D7B604 Slot: 20
	public override string Get(int index) { }

	// RVA: 0x1D7B644 Offset: 0x1D77644 VA: 0x1D7B644 Slot: 21
	public override string GetKey(int index) { }

	// RVA: 0x1D7B684 Offset: 0x1D77684 VA: 0x1D7B684
	private static void .cctor() { }
}

// Namespace: System.Net
internal class CaseInsensitiveAscii : IEqualityComparer, IComparer // TypeDefIndex: 4183
{
	// Fields
	internal static readonly CaseInsensitiveAscii StaticInstance; // 0x0
	internal static readonly byte[] AsciiToLower; // 0x8

	// Methods

	// RVA: 0x1D7BC40 Offset: 0x1D77C40 VA: 0x1D7BC40 Slot: 5
	public int GetHashCode(object myObject) { }

	// RVA: 0x1D7BD48 Offset: 0x1D77D48 VA: 0x1D7BD48 Slot: 6
	public int Compare(object firstObject, object secondObject) { }

	// RVA: 0x1D7BEC8 Offset: 0x1D77EC8 VA: 0x1D7BEC8
	private int FastGetHashCode(string myString) { }

	// RVA: 0x1D7BFB8 Offset: 0x1D77FB8 VA: 0x1D7BFB8 Slot: 4
	public bool Equals(object firstObject, object secondObject) { }

	// RVA: 0x1D7C13C Offset: 0x1D7813C VA: 0x1D7C13C
	public void .ctor() { }

	// RVA: 0x1D7C144 Offset: 0x1D78144 VA: 0x1D7C144
	private static void .cctor() { }
}

// Namespace: 
internal class WebRequest.DesignerWebRequestCreate : IWebRequestCreate // TypeDefIndex: 4184
{
	// Methods

	// RVA: 0x1D7D68C Offset: 0x1D7968C VA: 0x1D7D68C Slot: 4
	public WebRequest Create(Uri uri) { }

	// RVA: 0x1D7D590 Offset: 0x1D79590 VA: 0x1D7D590
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebRequest.<>c__DisplayClass79_0 // TypeDefIndex: 4185
{
	// Fields
	public WindowsIdentity currentUser; // 0x10
	public WebRequest <>4__this; // 0x18

	// Methods

	// RVA: 0x1D7D044 Offset: 0x1D79044 VA: 0x1D7D044
	public void .ctor() { }

	// RVA: 0x1D7D6E0 Offset: 0x1D796E0 VA: 0x1D7D6E0
	internal Task<WebResponse> <GetResponseAsync>b__1() { }
}

// Namespace: System.Net
[Serializable]
public abstract class WebRequest : MarshalByRefObject, ISerializable // TypeDefIndex: 4186
{
	// Fields
	private static ArrayList s_PrefixList; // 0x0
	private static object s_InternalSyncObject; // 0x8
	private static TimerThread.Queue s_DefaultTimerQueue; // 0x10
	private AuthenticationLevel m_AuthenticationLevel; // 0x18
	private TokenImpersonationLevel m_ImpersonationLevel; // 0x1C
	private RequestCachePolicy m_CachePolicy; // 0x20
	private RequestCacheProtocol m_CacheProtocol; // 0x28
	private RequestCacheBinding m_CacheBinding; // 0x30
	private static WebRequest.DesignerWebRequestCreate webRequestCreate; // 0x18
	private static IWebProxy s_DefaultWebProxy; // 0x20
	private static bool s_DefaultWebProxyInitialized; // 0x28

	// Properties
	private static object InternalSyncObject { get; }
	internal static ArrayList PrefixList { get; }
	public virtual RequestCachePolicy CachePolicy { set; }
	public virtual string Method { get; set; }
	public virtual Uri RequestUri { get; }
	public virtual WebHeaderCollection Headers { get; }
	public virtual long ContentLength { get; }
	public virtual ICredentials Credentials { get; set; }
	public virtual bool UseDefaultCredentials { get; }
	public virtual IWebProxy Proxy { get; set; }
	public virtual int Timeout { get; }
	internal RequestCacheProtocol CacheProtocol { get; set; }
	internal static IWebProxy InternalDefaultWebProxy { get; }

	// Methods

	// RVA: 0x1D7C20C Offset: 0x1D7820C VA: 0x1D7C20C
	private static object get_InternalSyncObject() { }

	// RVA: 0x1D7C2D8 Offset: 0x1D782D8 VA: 0x1D7C2D8
	private static WebRequest Create(Uri requestUri, bool useUriBase) { }

	// RVA: 0x1D7C70C Offset: 0x1D7870C VA: 0x1D7C70C
	public static WebRequest Create(string requestUriString) { }

	// RVA: 0x1D7C7DC Offset: 0x1D787DC VA: 0x1D7C7DC
	public static WebRequest Create(Uri requestUri) { }

	// RVA: 0x1D7C56C Offset: 0x1D7856C VA: 0x1D7C56C
	internal static ArrayList get_PrefixList() { }

	// RVA: 0x1D7C8B4 Offset: 0x1D788B4 VA: 0x1D7C8B4
	private static ArrayList PopulatePrefixList() { }

	// RVA: 0x1D71578 Offset: 0x1D6D578 VA: 0x1D71578
	protected void .ctor() { }

	// RVA: 0x1D7CAC4 Offset: 0x1D78AC4 VA: 0x1D7CAC4
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D7CACC Offset: 0x1D78ACC VA: 0x1D7CACC Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D7CAD8 Offset: 0x1D78AD8 VA: 0x1D7CAD8 Slot: 7
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D7CADC Offset: 0x1D78ADC VA: 0x1D7CADC Slot: 8
	public virtual void set_CachePolicy(RequestCachePolicy value) { }

	// RVA: 0x1D7CAE0 Offset: 0x1D78AE0 VA: 0x1D7CAE0
	private void InternalSetCachePolicy(RequestCachePolicy policy) { }

	// RVA: 0x1D7CBB0 Offset: 0x1D78BB0 VA: 0x1D7CBB0 Slot: 9
	public virtual string get_Method() { }

	// RVA: 0x1D7CBD4 Offset: 0x1D78BD4 VA: 0x1D7CBD4 Slot: 10
	public virtual void set_Method(string value) { }

	// RVA: 0x1D7CBF8 Offset: 0x1D78BF8 VA: 0x1D7CBF8 Slot: 11
	public virtual Uri get_RequestUri() { }

	// RVA: 0x1D7CC1C Offset: 0x1D78C1C VA: 0x1D7CC1C Slot: 12
	public virtual WebHeaderCollection get_Headers() { }

	// RVA: 0x1D7CC40 Offset: 0x1D78C40 VA: 0x1D7CC40 Slot: 13
	public virtual long get_ContentLength() { }

	// RVA: 0x1D7CC64 Offset: 0x1D78C64 VA: 0x1D7CC64 Slot: 14
	public virtual ICredentials get_Credentials() { }

	// RVA: 0x1D7CC88 Offset: 0x1D78C88 VA: 0x1D7CC88 Slot: 15
	public virtual void set_Credentials(ICredentials value) { }

	// RVA: 0x1D7CCAC Offset: 0x1D78CAC VA: 0x1D7CCAC Slot: 16
	public virtual bool get_UseDefaultCredentials() { }

	// RVA: 0x1D7CCD0 Offset: 0x1D78CD0 VA: 0x1D7CCD0 Slot: 17
	public virtual IWebProxy get_Proxy() { }

	// RVA: 0x1D7CCF4 Offset: 0x1D78CF4 VA: 0x1D7CCF4 Slot: 18
	public virtual void set_Proxy(IWebProxy value) { }

	// RVA: 0x1D7CD18 Offset: 0x1D78D18 VA: 0x1D7CD18 Slot: 19
	public virtual int get_Timeout() { }

	// RVA: 0x1D7CD3C Offset: 0x1D78D3C VA: 0x1D7CD3C Slot: 20
	public virtual WebResponse GetResponse() { }

	// RVA: 0x1D7CD60 Offset: 0x1D78D60 VA: 0x1D7CD60 Slot: 21
	public virtual IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1D7CD84 Offset: 0x1D78D84 VA: 0x1D7CD84 Slot: 22
	public virtual WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1D7CDA8 Offset: 0x1D78DA8 VA: 0x1D7CDA8 Slot: 23
	public virtual Task<WebResponse> GetResponseAsync() { }

	// RVA: 0x1D7D04C Offset: 0x1D7904C VA: 0x1D7D04C
	private WindowsIdentity SafeCaptureIdenity() { }

	// RVA: 0x1D7D09C Offset: 0x1D7909C VA: 0x1D7D09C Slot: 24
	public virtual void Abort() { }

	// RVA: 0x1D7D0C0 Offset: 0x1D790C0 VA: 0x1D7D0C0
	internal RequestCacheProtocol get_CacheProtocol() { }

	// RVA: 0x1D7D0C8 Offset: 0x1D790C8 VA: 0x1D7D0C8
	internal void set_CacheProtocol(RequestCacheProtocol value) { }

	// RVA: 0x1D7D0D0 Offset: 0x1D790D0 VA: 0x1D7D0D0
	internal static IWebProxy get_InternalDefaultWebProxy() { }

	// RVA: 0x1D7D2A4 Offset: 0x1D792A4 VA: 0x1D7D2A4
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x1D7D598 Offset: 0x1D79598 VA: 0x1D7D598
	private Task<WebResponse> <GetResponseAsync>b__79_0() { }
}

// Namespace: System.Net
[Serializable]
public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable // TypeDefIndex: 4187
{
	// Fields
	private bool m_IsFromCache; // 0x18

	// Properties
	public virtual bool IsFromCache { get; }
	public virtual Uri ResponseUri { get; }
	public virtual WebHeaderCollection Headers { get; }

	// Methods

	// RVA: 0x1D76D30 Offset: 0x1D72D30 VA: 0x1D76D30
	protected void .ctor() { }

	// RVA: 0x1D7D9C8 Offset: 0x1D799C8 VA: 0x1D7D9C8
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D7D9D0 Offset: 0x1D799D0 VA: 0x1D7D9D0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D7D9DC Offset: 0x1D799DC VA: 0x1D7D9DC Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D7D9E0 Offset: 0x1D799E0 VA: 0x1D7D9E0 Slot: 9
	public virtual void Close() { }

	// RVA: 0x1D7D9E4 Offset: 0x1D799E4 VA: 0x1D7D9E4 Slot: 7
	public void Dispose() { }

	// RVA: 0x1D7DA50 Offset: 0x1D79A50 VA: 0x1D7DA50 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1D7DADC Offset: 0x1D79ADC VA: 0x1D7DADC Slot: 11
	public virtual bool get_IsFromCache() { }

	// RVA: 0x1D7DAE4 Offset: 0x1D79AE4 VA: 0x1D7DAE4 Slot: 12
	public virtual Stream GetResponseStream() { }

	// RVA: 0x1D7DB08 Offset: 0x1D79B08 VA: 0x1D7DB08 Slot: 13
	public virtual Uri get_ResponseUri() { }

	// RVA: 0x1D7DB2C Offset: 0x1D79B2C VA: 0x1D7DB2C Slot: 14
	public virtual WebHeaderCollection get_Headers() { }
}

// Namespace: System.Net
internal class BufferOffsetSize // TypeDefIndex: 4188
{
	// Fields
	internal byte[] Buffer; // 0x10
	internal int Offset; // 0x18
	internal int Size; // 0x1C

	// Methods

	// RVA: 0x1D7DB50 Offset: 0x1D79B50 VA: 0x1D7DB50
	internal void .ctor(byte[] buffer, int offset, int size, bool copyBuffer) { }

	// RVA: 0x1D7DC08 Offset: 0x1D79C08 VA: 0x1D7DC08
	internal void .ctor(byte[] buffer, bool copyBuffer) { }
}

// Namespace: System.Net
internal sealed class HeaderParser : MulticastDelegate // TypeDefIndex: 4189
{
	// Methods

	// RVA: 0x1D7DC24 Offset: 0x1D79C24 VA: 0x1D7DC24
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D7DCD4 Offset: 0x1D79CD4 VA: 0x1D7DCD4 Slot: 12
	public virtual string[] Invoke(string value) { }
}

// Namespace: System.Net
internal class HeaderInfo // TypeDefIndex: 4190
{
	// Fields
	internal readonly bool IsRequestRestricted; // 0x10
	internal readonly bool IsResponseRestricted; // 0x11
	internal readonly HeaderParser Parser; // 0x18
	internal readonly string HeaderName; // 0x20
	internal readonly bool AllowMultiValues; // 0x28

	// Methods

	// RVA: 0x1D7DCE8 Offset: 0x1D79CE8 VA: 0x1D7DCE8
	internal void .ctor(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) { }
}

// Namespace: System.Net
[DefaultMember("Item")]
internal class HeaderInfoTable // TypeDefIndex: 4191
{
	// Fields
	private static Hashtable HeaderHashTable; // 0x0
	private static HeaderInfo UnknownHeaderInfo; // 0x8
	private static HeaderParser SingleParser; // 0x10
	private static HeaderParser MultiParser; // 0x18

	// Properties
	internal HeaderInfo Item { get; }

	// Methods

	// RVA: 0x1D7DD58 Offset: 0x1D79D58 VA: 0x1D7DD58
	private static string[] ParseSingleValue(string value) { }

	// RVA: 0x1D7DDD0 Offset: 0x1D79DD0 VA: 0x1D7DDD0
	private static string[] ParseMultiValue(string value) { }

	// RVA: 0x1D7DFD4 Offset: 0x1D79FD4 VA: 0x1D7DFD4
	private static void .cctor() { }

	// RVA: 0x1D79668 Offset: 0x1D75668 VA: 0x1D79668
	internal HeaderInfo get_Item(string name) { }

	// RVA: 0x1D7BC38 Offset: 0x1D77C38 VA: 0x1D7BC38
	public void .ctor() { }
}

// Namespace: System.Net
[Flags]
internal enum CloseExState // TypeDefIndex: 4192
{
	// Fields
	public int value__; // 0x0
	public const CloseExState Normal = 0;
	public const CloseExState Abort = 1;
	public const CloseExState Silent = 2;
}

// Namespace: System.Net
internal interface ICloseEx // TypeDefIndex: 4193
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void CloseEx(CloseExState closeState);
}

// Namespace: 
private class LazyAsyncResult.ThreadContext // TypeDefIndex: 4194
{
	// Fields
	internal int m_NestedIOCount; // 0x10

	// Methods

	// RVA: 0x1D7FB38 Offset: 0x1D7BB38 VA: 0x1D7FB38
	public void .ctor() { }
}

// Namespace: System.Net
internal class LazyAsyncResult : IAsyncResult // TypeDefIndex: 4195
{
	// Fields
	[ThreadStatic]
	private static LazyAsyncResult.ThreadContext t_ThreadContext; // 0x80000000
	private object m_AsyncObject; // 0x10
	private object m_AsyncState; // 0x18
	private AsyncCallback m_AsyncCallback; // 0x20
	private object m_Result; // 0x28
	private int m_IntCompleted; // 0x30
	private bool m_EndCalled; // 0x34
	private bool m_UserEvent; // 0x35
	private object m_Event; // 0x38

	// Properties
	private static LazyAsyncResult.ThreadContext CurrentThreadContext { get; }
	internal object AsyncObject { get; }
	public object AsyncState { get; }
	protected AsyncCallback AsyncCallback { get; }
	public WaitHandle AsyncWaitHandle { get; }
	public bool CompletedSynchronously { get; }
	public bool IsCompleted { get; }
	internal bool InternalPeekCompleted { get; }
	internal bool EndCalled { get; set; }

	// Methods

	// RVA: 0x1D7FAA4 Offset: 0x1D7BAA4 VA: 0x1D7FAA4
	private static LazyAsyncResult.ThreadContext get_CurrentThreadContext() { }

	// RVA: 0x1D700BC Offset: 0x1D6C0BC VA: 0x1D700BC
	internal void .ctor(object myObject, object myState, AsyncCallback myCallBack) { }

	// RVA: 0x1D7FB40 Offset: 0x1D7BB40 VA: 0x1D7FB40
	internal object get_AsyncObject() { }

	// RVA: 0x1D7FB48 Offset: 0x1D7BB48 VA: 0x1D7FB48 Slot: 6
	public object get_AsyncState() { }

	// RVA: 0x1D7FB50 Offset: 0x1D7BB50 VA: 0x1D7FB50
	protected AsyncCallback get_AsyncCallback() { }

	// RVA: 0x1D7FB58 Offset: 0x1D7BB58 VA: 0x1D7FB58 Slot: 5
	public WaitHandle get_AsyncWaitHandle() { }

	// RVA: 0x1D7FBFC Offset: 0x1D7BBFC VA: 0x1D7FBFC
	private bool LazilyCreateEvent(out ManualResetEvent waitHandle) { }

	// RVA: 0x1D7FDC0 Offset: 0x1D7BDC0 VA: 0x1D7FDC0 Slot: 7
	public bool get_CompletedSynchronously() { }

	// RVA: 0x1D6FEF8 Offset: 0x1D6BEF8 VA: 0x1D6FEF8 Slot: 4
	public bool get_IsCompleted() { }

	// RVA: 0x1D73760 Offset: 0x1D6F760 VA: 0x1D73760
	internal bool get_InternalPeekCompleted() { }

	// RVA: 0x1D7FDF0 Offset: 0x1D7BDF0 VA: 0x1D7FDF0
	internal bool get_EndCalled() { }

	// RVA: 0x1D7FDF8 Offset: 0x1D7BDF8 VA: 0x1D7FDF8
	internal void set_EndCalled(bool value) { }

	// RVA: 0x1D7FE00 Offset: 0x1D7BE00 VA: 0x1D7FE00
	protected void ProtectedInvokeCallback(object result, IntPtr userToken) { }

	// RVA: 0x1D6FEF0 Offset: 0x1D6BEF0 VA: 0x1D6FEF0
	internal void InvokeCallback(object result) { }

	// RVA: 0x1D73770 Offset: 0x1D6F770 VA: 0x1D73770
	internal void InvokeCallback() { }

	// RVA: 0x1D7FFF0 Offset: 0x1D7BFF0 VA: 0x1D7FFF0 Slot: 8
	protected virtual void Complete(IntPtr userToken) { }

	// RVA: 0x1D80178 Offset: 0x1D7C178 VA: 0x1D80178
	private void WorkerThreadComplete(object state) { }

	// RVA: 0x1D8021C Offset: 0x1D7C21C VA: 0x1D8021C Slot: 9
	protected virtual void Cleanup() { }

	// RVA: 0x1D70304 Offset: 0x1D6C304 VA: 0x1D70304
	internal object InternalWaitForCompletion() { }

	// RVA: 0x1D80220 Offset: 0x1D7C220 VA: 0x1D80220
	private object WaitForCompletion(bool snap) { }
}

// Namespace: System.Net
internal class NetRes // TypeDefIndex: 4196
{
	// Methods

	// RVA: 0x1D7806C Offset: 0x1D7406C VA: 0x1D7806C
	public static string GetWebStatusString(string Res, WebExceptionStatus Status) { }

	// RVA: 0x1D804F0 Offset: 0x1D7C4F0 VA: 0x1D804F0
	public static string GetWebStatusString(WebExceptionStatus Status) { }

	// RVA: 0x1D68E34 Offset: 0x1D64E34 VA: 0x1D68E34
	public static string GetWebStatusCodeString(FtpStatusCode statusCode, string statusDescription) { }
}

// Namespace: 
internal abstract class TimerThread.Queue // TypeDefIndex: 4197
{
	// Fields
	private readonly int m_DurationMilliseconds; // 0x10

	// Properties
	internal int Duration { get; }

	// Methods

	// RVA: 0x1D81280 Offset: 0x1D7D280 VA: 0x1D81280
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x1D812A8 Offset: 0x1D7D2A8 VA: 0x1D812A8
	internal int get_Duration() { }

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context);
}

// Namespace: 
internal abstract class TimerThread.Timer : IDisposable // TypeDefIndex: 4198
{
	// Fields
	private readonly int m_StartTimeMilliseconds; // 0x10
	private readonly int m_DurationMilliseconds; // 0x14

	// Properties
	internal int StartTime { get; }
	internal int Expiration { get; }
	internal abstract bool HasExpired { get; }

	// Methods

	// RVA: 0x1D812B0 Offset: 0x1D7D2B0 VA: 0x1D812B0
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x1D812E4 Offset: 0x1D7D2E4 VA: 0x1D812E4
	internal int get_StartTime() { }

	// RVA: 0x1D812EC Offset: 0x1D7D2EC VA: 0x1D812EC
	internal int get_Expiration() { }

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract bool Cancel();

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract bool get_HasExpired();

	// RVA: 0x1D812F8 Offset: 0x1D7D2F8 VA: 0x1D812F8 Slot: 4
	public void Dispose() { }
}

// Namespace: 
internal sealed class TimerThread.Callback : MulticastDelegate // TypeDefIndex: 4199
{
	// Methods

	// RVA: 0x1D81304 Offset: 0x1D7D304 VA: 0x1D81304
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D81410 Offset: 0x1D7D410 VA: 0x1D81410 Slot: 12
	public virtual void Invoke(TimerThread.Timer timer, int timeNoticed, object context) { }
}

// Namespace: 
private class TimerThread.TimerQueue : TimerThread.Queue // TypeDefIndex: 4200
{
	// Fields
	private IntPtr m_ThisHandle; // 0x18
	private readonly TimerThread.TimerNode m_Timers; // 0x20

	// Methods

	// RVA: 0x1D81424 Offset: 0x1D7D424 VA: 0x1D81424
	internal void .ctor(int durationMilliseconds) { }

	// RVA: 0x1D81514 Offset: 0x1D7D514 VA: 0x1D81514 Slot: 4
	internal override TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context) { }

	// RVA: 0x1D817B4 Offset: 0x1D7D7B4 VA: 0x1D817B4
	internal bool Fire(out int nextExpiration) { }
}

// Namespace: 
private class TimerThread.InfiniteTimerQueue : TimerThread.Queue // TypeDefIndex: 4201
{
	// Methods

	// RVA: 0x1D81C2C Offset: 0x1D7DC2C VA: 0x1D81C2C
	internal void .ctor() { }

	// RVA: 0x1D81C4C Offset: 0x1D7DC4C VA: 0x1D81C4C Slot: 4
	internal override TimerThread.Timer CreateTimer(TimerThread.Callback callback, object context) { }
}

// Namespace: 
private enum TimerThread.TimerNode.TimerState // TypeDefIndex: 4202
{
	// Fields
	public int value__; // 0x0
	public const TimerThread.TimerNode.TimerState Ready = 0;
	public const TimerThread.TimerNode.TimerState Fired = 1;
	public const TimerThread.TimerNode.TimerState Cancelled = 2;
	public const TimerThread.TimerNode.TimerState Sentinel = 3;
}

// Namespace: 
private class TimerThread.TimerNode : TimerThread.Timer // TypeDefIndex: 4203
{
	// Fields
	private TimerThread.TimerNode.TimerState m_TimerState; // 0x18
	private TimerThread.Callback m_Callback; // 0x20
	private object m_Context; // 0x28
	private object m_QueueLock; // 0x30
	private TimerThread.TimerNode next; // 0x38
	private TimerThread.TimerNode prev; // 0x40

	// Properties
	internal override bool HasExpired { get; }
	internal TimerThread.TimerNode Next { get; set; }
	internal TimerThread.TimerNode Prev { get; set; }

	// Methods

	// RVA: 0x1D81738 Offset: 0x1D7D738 VA: 0x1D81738
	internal void .ctor(TimerThread.Callback callback, object context, int durationMilliseconds, object queueLock) { }

	// RVA: 0x1D814E4 Offset: 0x1D7D4E4 VA: 0x1D814E4
	internal void .ctor() { }

	// RVA: 0x1D81CE4 Offset: 0x1D7DCE4 VA: 0x1D81CE4 Slot: 6
	internal override bool get_HasExpired() { }

	// RVA: 0x1D81CF4 Offset: 0x1D7DCF4 VA: 0x1D81CF4
	internal TimerThread.TimerNode get_Next() { }

	// RVA: 0x1D81CFC Offset: 0x1D7DCFC VA: 0x1D81CFC
	internal void set_Next(TimerThread.TimerNode value) { }

	// RVA: 0x1D81D04 Offset: 0x1D7DD04 VA: 0x1D81D04
	internal TimerThread.TimerNode get_Prev() { }

	// RVA: 0x1D81D0C Offset: 0x1D7DD0C VA: 0x1D81D0C
	internal void set_Prev(TimerThread.TimerNode value) { }

	// RVA: 0x1D81D14 Offset: 0x1D7DD14 VA: 0x1D81D14 Slot: 5
	internal override bool Cancel() { }

	// RVA: 0x1D81954 Offset: 0x1D7D954 VA: 0x1D81954
	internal bool Fire() { }
}

// Namespace: 
private class TimerThread.InfiniteTimer : TimerThread.Timer // TypeDefIndex: 4204
{
	// Fields
	private int cancelled; // 0x18

	// Properties
	internal override bool HasExpired { get; }

	// Methods

	// RVA: 0x1D81CB8 Offset: 0x1D7DCB8 VA: 0x1D81CB8
	internal void .ctor() { }

	// RVA: 0x1D81E88 Offset: 0x1D7DE88 VA: 0x1D81E88 Slot: 6
	internal override bool get_HasExpired() { }

	// RVA: 0x1D81E90 Offset: 0x1D7DE90 VA: 0x1D81E90 Slot: 5
	internal override bool Cancel() { }
}

// Namespace: System.Net
internal static class TimerThread // TypeDefIndex: 4205
{
	// Fields
	private static LinkedList<WeakReference> s_Queues; // 0x0
	private static LinkedList<WeakReference> s_NewQueues; // 0x8
	private static int s_ThreadState; // 0x10
	private static AutoResetEvent s_ThreadReadyEvent; // 0x18
	private static ManualResetEvent s_ThreadShutdownEvent; // 0x20
	private static WaitHandle[] s_ThreadEvents; // 0x28
	private static int s_CacheScanIteration; // 0x30
	private static Hashtable s_QueuesCache; // 0x38

	// Methods

	// RVA: 0x1D8054C Offset: 0x1D7C54C VA: 0x1D8054C
	private static void .cctor() { }

	// RVA: 0x1D7D360 Offset: 0x1D79360 VA: 0x1D7D360
	internal static TimerThread.Queue CreateQueue(int durationMilliseconds) { }

	// RVA: 0x1D74678 Offset: 0x1D70678 VA: 0x1D74678
	internal static TimerThread.Queue GetOrCreateQueue(int durationMilliseconds) { }

	// RVA: 0x1D80818 Offset: 0x1D7C818 VA: 0x1D80818
	private static void Prod() { }

	// RVA: 0x1D80928 Offset: 0x1D7C928 VA: 0x1D80928
	private static void ThreadProc() { }

	// RVA: 0x1D81140 Offset: 0x1D7D140 VA: 0x1D81140
	private static void StopTimerThread() { }

	// RVA: 0x1D8111C Offset: 0x1D7D11C VA: 0x1D8111C
	private static bool IsTickBetween(int start, int end, int comparand) { }

	// RVA: 0x1D811BC Offset: 0x1D7D1BC VA: 0x1D811BC
	private static void OnDomainUnload(object sender, EventArgs e) { }
}

// Namespace: System.Net
internal enum CookieVariant // TypeDefIndex: 4206
{
	// Fields
	public int value__; // 0x0
	public const CookieVariant Unknown = 0;
	public const CookieVariant Plain = 1;
	public const CookieVariant Rfc2109 = 2;
	public const CookieVariant Rfc2965 = 3;
	public const CookieVariant Default = 2;
}

// Namespace: System.Net
[Serializable]
public sealed class Cookie // TypeDefIndex: 4207
{
	// Fields
	internal static readonly char[] PortSplitDelimiters; // 0x0
	internal static readonly char[] Reserved2Name; // 0x8
	internal static readonly char[] Reserved2Value; // 0x10
	private static Comparer staticComparer; // 0x18
	private string m_comment; // 0x10
	private Uri m_commentUri; // 0x18
	private CookieVariant m_cookieVariant; // 0x20
	private bool m_discard; // 0x24
	private string m_domain; // 0x28
	private bool m_domain_implicit; // 0x30
	private DateTime m_expires; // 0x38
	private string m_name; // 0x40
	private string m_path; // 0x48
	private bool m_path_implicit; // 0x50
	private string m_port; // 0x58
	private bool m_port_implicit; // 0x60
	private int[] m_port_list; // 0x68
	private bool m_secure; // 0x70
	[OptionalField]
	private bool m_httpOnly; // 0x71
	private DateTime m_timeStamp; // 0x78
	private string m_value; // 0x80
	private int m_version; // 0x88
	private string m_domainKey; // 0x90
	internal bool IsQuotedVersion; // 0x98
	internal bool IsQuotedDomain; // 0x99

	// Properties
	public string Comment { get; set; }
	public Uri CommentUri { set; }
	public bool HttpOnly { set; }
	public bool Discard { set; }
	public string Domain { get; set; }
	private string _Domain { get; }
	public bool Expired { get; }
	public DateTime Expires { set; }
	public string Name { get; }
	public string Path { get; set; }
	private string _Path { get; }
	internal bool Plain { get; }
	public string Port { set; }
	internal int[] PortList { get; }
	private string _Port { get; }
	public bool Secure { get; set; }
	public string Value { get; set; }
	internal CookieVariant Variant { get; }
	internal string DomainKey { get; }
	public int Version { get; set; }
	private string _Version { get; }

	// Methods

	// RVA: 0x1D81EB4 Offset: 0x1D7DEB4 VA: 0x1D81EB4
	public void .ctor() { }

	// RVA: 0x1D81FF8 Offset: 0x1D7DFF8 VA: 0x1D81FF8
	public string get_Comment() { }

	// RVA: 0x1D82000 Offset: 0x1D7E000 VA: 0x1D82000
	public void set_Comment(string value) { }

	// RVA: 0x1D82020 Offset: 0x1D7E020 VA: 0x1D82020
	public void set_CommentUri(Uri value) { }

	// RVA: 0x1D82028 Offset: 0x1D7E028 VA: 0x1D82028
	public void set_HttpOnly(bool value) { }

	// RVA: 0x1D82030 Offset: 0x1D7E030 VA: 0x1D82030
	public void set_Discard(bool value) { }

	// RVA: 0x1D82038 Offset: 0x1D7E038 VA: 0x1D82038
	public string get_Domain() { }

	// RVA: 0x1D82040 Offset: 0x1D7E040 VA: 0x1D82040
	public void set_Domain(string value) { }

	// RVA: 0x1D8209C Offset: 0x1D7E09C VA: 0x1D8209C
	private string get__Domain() { }

	// RVA: 0x1D82174 Offset: 0x1D7E174 VA: 0x1D82174
	public bool get_Expired() { }

	// RVA: 0x1D82228 Offset: 0x1D7E228 VA: 0x1D82228
	public void set_Expires(DateTime value) { }

	// RVA: 0x1D82230 Offset: 0x1D7E230 VA: 0x1D82230
	public string get_Name() { }

	// RVA: 0x1D82238 Offset: 0x1D7E238 VA: 0x1D82238
	internal bool InternalSetName(string value) { }

	// RVA: 0x1D82348 Offset: 0x1D7E348 VA: 0x1D82348
	public string get_Path() { }

	// RVA: 0x1D82350 Offset: 0x1D7E350 VA: 0x1D82350
	public void set_Path(string value) { }

	// RVA: 0x1D82390 Offset: 0x1D7E390 VA: 0x1D82390
	private string get__Path() { }

	// RVA: 0x1D82164 Offset: 0x1D7E164 VA: 0x1D82164
	internal bool get_Plain() { }

	// RVA: 0x1D82420 Offset: 0x1D7E420 VA: 0x1D82420
	private static bool IsDomainEqualToHost(string domain, string host) { }

	// RVA: 0x1D82478 Offset: 0x1D7E478 VA: 0x1D82478
	internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow) { }

	// RVA: 0x1D82EC8 Offset: 0x1D7EEC8 VA: 0x1D82EC8
	private static bool DomainCharsTest(string name) { }

	// RVA: 0x1D82FFC Offset: 0x1D7EFFC VA: 0x1D82FFC
	public void set_Port(string value) { }

	// RVA: 0x1D8334C Offset: 0x1D7F34C VA: 0x1D8334C
	internal int[] get_PortList() { }

	// RVA: 0x1D83354 Offset: 0x1D7F354 VA: 0x1D83354
	private string get__Port() { }

	// RVA: 0x1D83418 Offset: 0x1D7F418 VA: 0x1D83418
	public bool get_Secure() { }

	// RVA: 0x1D83420 Offset: 0x1D7F420 VA: 0x1D83420
	public void set_Secure(bool value) { }

	// RVA: 0x1D83428 Offset: 0x1D7F428 VA: 0x1D83428
	public string get_Value() { }

	// RVA: 0x1D83430 Offset: 0x1D7F430 VA: 0x1D83430
	public void set_Value(string value) { }

	// RVA: 0x1D8345C Offset: 0x1D7F45C VA: 0x1D8345C
	internal CookieVariant get_Variant() { }

	// RVA: 0x1D83464 Offset: 0x1D7F464 VA: 0x1D83464
	internal string get_DomainKey() { }

	// RVA: 0x1D83480 Offset: 0x1D7F480 VA: 0x1D83480
	public int get_Version() { }

	// RVA: 0x1D83488 Offset: 0x1D7F488 VA: 0x1D83488
	public void set_Version(int value) { }

	// RVA: 0x1D834F8 Offset: 0x1D7F4F8 VA: 0x1D834F8
	private string get__Version() { }

	// RVA: 0x1D835F8 Offset: 0x1D7F5F8 VA: 0x1D835F8
	internal static IComparer GetComparer() { }

	// RVA: 0x1D83650 Offset: 0x1D7F650 VA: 0x1D83650 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x1D83720 Offset: 0x1D7F720 VA: 0x1D83720 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D8390C Offset: 0x1D7F90C VA: 0x1D8390C Slot: 3
	public override string ToString() { }

	// RVA: 0x1D83BB4 Offset: 0x1D7FBB4 VA: 0x1D83BB4
	private static void .cctor() { }
}

// Namespace: System.Net
internal enum CookieToken // TypeDefIndex: 4208
{
	// Fields
	public int value__; // 0x0
	public const CookieToken Nothing = 0;
	public const CookieToken NameValuePair = 1;
	public const CookieToken Attribute = 2;
	public const CookieToken EndToken = 3;
	public const CookieToken EndCookie = 4;
	public const CookieToken End = 5;
	public const CookieToken Equals = 6;
	public const CookieToken Comment = 7;
	public const CookieToken CommentUrl = 8;
	public const CookieToken CookieName = 9;
	public const CookieToken Discard = 10;
	public const CookieToken Domain = 11;
	public const CookieToken Expires = 12;
	public const CookieToken MaxAge = 13;
	public const CookieToken Path = 14;
	public const CookieToken Port = 15;
	public const CookieToken Secure = 16;
	public const CookieToken HttpOnly = 17;
	public const CookieToken Unknown = 18;
	public const CookieToken Version = 19;
}

// Namespace: 
private struct CookieTokenizer.RecognizedAttribute // TypeDefIndex: 4209
{
	// Fields
	private string m_name; // 0x0
	private CookieToken m_token; // 0x8

	// Properties
	internal CookieToken Token { get; }

	// Methods

	// RVA: 0x1D849A8 Offset: 0x1D809A8 VA: 0x1D849A8
	internal void .ctor(string name, CookieToken token) { }

	// RVA: 0x1D849D0 Offset: 0x1D809D0 VA: 0x1D849D0
	internal CookieToken get_Token() { }

	// RVA: 0x1D843D4 Offset: 0x1D803D4 VA: 0x1D843D4
	internal bool IsEqualTo(string value) { }
}

// Namespace: System.Net
internal class CookieTokenizer // TypeDefIndex: 4210
{
	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x1D83D28 Offset: 0x1D7FD28 VA: 0x1D83D28
	internal void .ctor(string tokenStream) { }

	// RVA: 0x1D83D68 Offset: 0x1D7FD68 VA: 0x1D83D68
	internal bool get_EndOfCookie() { }

	// RVA: 0x1D83D70 Offset: 0x1D7FD70 VA: 0x1D83D70
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x1D83D78 Offset: 0x1D7FD78 VA: 0x1D83D78
	internal bool get_Eof() { }

	// RVA: 0x1D83D88 Offset: 0x1D7FD88 VA: 0x1D83D88
	internal string get_Name() { }

	// RVA: 0x1D83D90 Offset: 0x1D7FD90 VA: 0x1D83D90
	internal void set_Name(string value) { }

	// RVA: 0x1D83D98 Offset: 0x1D7FD98 VA: 0x1D83D98
	internal bool get_Quoted() { }

	// RVA: 0x1D83DA0 Offset: 0x1D7FDA0 VA: 0x1D83DA0
	internal void set_Quoted(bool value) { }

	// RVA: 0x1D83DA8 Offset: 0x1D7FDA8 VA: 0x1D83DA8
	internal CookieToken get_Token() { }

	// RVA: 0x1D83DB0 Offset: 0x1D7FDB0 VA: 0x1D83DB0
	internal void set_Token(CookieToken value) { }

	// RVA: 0x1D83DB8 Offset: 0x1D7FDB8 VA: 0x1D83DB8
	internal string get_Value() { }

	// RVA: 0x1D83DC0 Offset: 0x1D7FDC0 VA: 0x1D83DC0
	internal void set_Value(string value) { }

	// RVA: 0x1D83DC8 Offset: 0x1D7FDC8 VA: 0x1D83DC8
	internal string Extract() { }

	// RVA: 0x1D83E24 Offset: 0x1D7FE24 VA: 0x1D83E24
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x1D84090 Offset: 0x1D80090 VA: 0x1D84090
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x1D841C4 Offset: 0x1D801C4 VA: 0x1D841C4
	internal void Reset() { }

	// RVA: 0x1D84220 Offset: 0x1D80220 VA: 0x1D84220
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x1D843F8 Offset: 0x1D803F8 VA: 0x1D843F8
	private static void .cctor() { }
}

// Namespace: System.Net
internal class CookieParser // TypeDefIndex: 4211
{
	// Fields
	private CookieTokenizer m_tokenizer; // 0x10

	// Methods

	// RVA: 0x1D849D8 Offset: 0x1D809D8 VA: 0x1D849D8
	internal void .ctor(string cookieString) { }

	// RVA: 0x1D84A50 Offset: 0x1D80A50 VA: 0x1D84A50
	internal Cookie Get() { }

	// RVA: 0x1D82F64 Offset: 0x1D7EF64 VA: 0x1D82F64
	internal static string CheckQuoted(string value) { }
}

// Namespace: System.Net
internal class Comparer : IComparer // TypeDefIndex: 4212
{
	// Methods

	// RVA: 0x1D84FE4 Offset: 0x1D80FE4 VA: 0x1D84FE4 Slot: 4
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x1D83D20 Offset: 0x1D7FD20 VA: 0x1D83D20
	public void .ctor() { }
}

// Namespace: 
internal enum CookieCollection.Stamp // TypeDefIndex: 4213
{
	// Fields
	public int value__; // 0x0
	public const CookieCollection.Stamp Check = 0;
	public const CookieCollection.Stamp Set = 1;
	public const CookieCollection.Stamp SetToUnused = 2;
	public const CookieCollection.Stamp SetToMaxUsed = 3;
}

// Namespace: 
private class CookieCollection.CookieCollectionEnumerator : IEnumerator // TypeDefIndex: 4214
{
	// Fields
	private CookieCollection m_cookies; // 0x10
	private int m_count; // 0x18
	private int m_index; // 0x1C
	private int m_version; // 0x20

	// Properties
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1D85F84 Offset: 0x1D81F84 VA: 0x1D85F84
	internal void .ctor(CookieCollection cookies) { }

	// RVA: 0x1D85FEC Offset: 0x1D81FEC VA: 0x1D85FEC Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1D86090 Offset: 0x1D82090 VA: 0x1D86090 Slot: 4
	private bool System.Collections.IEnumerator.MoveNext() { }

	// RVA: 0x1D8612C Offset: 0x1D8212C VA: 0x1D8612C Slot: 6
	private void System.Collections.IEnumerator.Reset() { }
}

// Namespace: System.Net
[DefaultMember("Item")]
[Serializable]
public class CookieCollection : ICollection, IEnumerable // TypeDefIndex: 4215
{
	// Fields
	internal int m_version; // 0x10
	private ArrayList m_list; // 0x18
	private DateTime m_TimeStamp; // 0x20
	private bool m_has_other_versions; // 0x28
	[OptionalField]
	private bool m_IsReadOnly; // 0x29

	// Properties
	public Cookie Item { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	internal bool IsOtherVersionSeen { get; }

	// Methods

	// RVA: 0x1D850C8 Offset: 0x1D810C8 VA: 0x1D850C8
	public void .ctor() { }

	// RVA: 0x1D8517C Offset: 0x1D8117C VA: 0x1D8517C
	public Cookie get_Item(int index) { }

	// RVA: 0x1D85264 Offset: 0x1D81264 VA: 0x1D85264
	public void Add(Cookie cookie) { }

	// RVA: 0x1D856A0 Offset: 0x1D816A0 VA: 0x1D856A0
	public void Add(CookieCollection cookies) { }

	// RVA: 0x1D859BC Offset: 0x1D819BC VA: 0x1D859BC Slot: 5
	public int get_Count() { }

	// RVA: 0x1D859DC Offset: 0x1D819DC VA: 0x1D859DC Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x1D859E4 Offset: 0x1D819E4 VA: 0x1D859E4 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1D859E8 Offset: 0x1D819E8 VA: 0x1D859E8 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1D85A08 Offset: 0x1D81A08 VA: 0x1D85A08
	internal DateTime TimeStamp(CookieCollection.Stamp how) { }

	// RVA: 0x1D85AD8 Offset: 0x1D81AD8 VA: 0x1D85AD8
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x1D85AE0 Offset: 0x1D81AE0 VA: 0x1D85AE0
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x1D85324 Offset: 0x1D81324 VA: 0x1D85324
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x1D85F64 Offset: 0x1D81F64 VA: 0x1D85F64
	internal void RemoveAt(int idx) { }

	// RVA: 0x1D85964 Offset: 0x1D81964 VA: 0x1D85964 Slot: 8
	public IEnumerator GetEnumerator() { }
}

// Namespace: System.Net
internal struct HeaderVariantInfo // TypeDefIndex: 4216
{
	// Fields
	private string m_name; // 0x0
	private CookieVariant m_variant; // 0x8

	// Properties
	internal string Name { get; }
	internal CookieVariant Variant { get; }

	// Methods

	// RVA: 0x1D86138 Offset: 0x1D82138 VA: 0x1D86138
	internal void .ctor(string name, CookieVariant variant) { }

	// RVA: 0x1D86160 Offset: 0x1D82160 VA: 0x1D86160
	internal string get_Name() { }

	// RVA: 0x1D86168 Offset: 0x1D82168 VA: 0x1D86168
	internal CookieVariant get_Variant() { }
}

// Namespace: System.Net
[Serializable]
public class CookieContainer // TypeDefIndex: 4217
{
	// Fields
	private static readonly HeaderVariantInfo[] HeaderInfo; // 0x0
	private Hashtable m_domainTable; // 0x10
	private int m_maxCookieSize; // 0x18
	private int m_maxCookies; // 0x1C
	private int m_maxCookiesPerDomain; // 0x20
	private int m_count; // 0x24
	private string m_fqdnMyDomain; // 0x28

	// Methods

	// RVA: 0x1D86170 Offset: 0x1D82170 VA: 0x1D86170
	public void .ctor() { }

	// RVA: 0x1D86280 Offset: 0x1D82280 VA: 0x1D86280
	private void AddRemoveDomain(string key, PathList value) { }

	// RVA: 0x1D863AC Offset: 0x1D823AC VA: 0x1D863AC
	internal void Add(Cookie cookie, bool throwOnError) { }

	// RVA: 0x1D871D4 Offset: 0x1D831D4 VA: 0x1D871D4
	private bool AgeCookies(string domain) { }

	// RVA: 0x1D885A0 Offset: 0x1D845A0 VA: 0x1D885A0
	private int ExpireCollection(CookieCollection cc) { }

	// RVA: 0x1D8873C Offset: 0x1D8473C VA: 0x1D8873C
	internal bool IsLocalDomain(string host) { }

	// RVA: 0x1D889DC Offset: 0x1D849DC VA: 0x1D889DC
	internal CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow) { }

	// RVA: 0x1D89080 Offset: 0x1D85080 VA: 0x1D89080
	internal CookieCollection InternalGetCookies(Uri uri) { }

	// RVA: 0x1D8952C Offset: 0x1D8552C VA: 0x1D8952C
	private void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie) { }

	// RVA: 0x1D89CE8 Offset: 0x1D85CE8 VA: 0x1D89CE8
	private void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly) { }

	// RVA: 0x1D89EE8 Offset: 0x1D85EE8 VA: 0x1D89EE8
	public string GetCookieHeader(Uri uri) { }

	// RVA: 0x1D89FB4 Offset: 0x1D85FB4 VA: 0x1D89FB4
	internal string GetCookieHeader(Uri uri, out string optCookie2) { }

	// RVA: 0x1D8A338 Offset: 0x1D86338 VA: 0x1D8A338
	private static void .cctor() { }
}

// Namespace: 
[Serializable]
private class PathList.PathListComparer : IComparer // TypeDefIndex: 4218
{
	// Fields
	internal static readonly PathList.PathListComparer StaticInstance; // 0x0

	// Methods

	// RVA: 0x1D8A460 Offset: 0x1D86460 VA: 0x1D8A460 Slot: 4
	private int System.Collections.IComparer.Compare(object ol, object or) { }

	// RVA: 0x1D8A5BC Offset: 0x1D865BC VA: 0x1D8A5BC
	public void .ctor() { }

	// RVA: 0x1D8A5C4 Offset: 0x1D865C4 VA: 0x1D8A5C4
	private static void .cctor() { }
}

// Namespace: System.Net
[DefaultMember("Item")]
[Serializable]
internal class PathList // TypeDefIndex: 4219
{
	// Fields
	private SortedList m_list; // 0x10

	// Properties
	public int Count { get; }
	public ICollection Values { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x1D86BD0 Offset: 0x1D82BD0 VA: 0x1D86BD0
	public void .ctor() { }

	// RVA: 0x1D8871C Offset: 0x1D8471C VA: 0x1D8871C
	public int get_Count() { }

	// RVA: 0x1D86C7C Offset: 0x1D82C7C VA: 0x1D86C7C
	public int GetCookiesCount() { }

	// RVA: 0x1D88580 Offset: 0x1D84580 VA: 0x1D88580
	public ICollection get_Values() { }

	// RVA: 0x1D870B0 Offset: 0x1D830B0 VA: 0x1D870B0
	public object get_Item(string s) { }

	// RVA: 0x1D870D0 Offset: 0x1D830D0 VA: 0x1D870D0
	public void set_Item(string s, object value) { }

	// RVA: 0x1D89CC8 Offset: 0x1D85CC8 VA: 0x1D89CC8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x1D87090 Offset: 0x1D83090 VA: 0x1D87090
	public object get_SyncRoot() { }
}

// Namespace: System.Net
[Serializable]
public class CookieException : FormatException, ISerializable // TypeDefIndex: 4220
{
	// Methods

	// RVA: 0x1D8A62C Offset: 0x1D8662C VA: 0x1D8A62C
	public void .ctor() { }

	// RVA: 0x1D82EC0 Offset: 0x1D7EEC0 VA: 0x1D82EC0
	internal void .ctor(string message) { }

	// RVA: 0x1D88578 Offset: 0x1D84578 VA: 0x1D88578
	internal void .ctor(string message, Exception inner) { }

	// RVA: 0x1D8A634 Offset: 0x1D86634 VA: 0x1D8A634
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D8A63C Offset: 0x1D8663C VA: 0x1D8A63C Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D8A644 Offset: 0x1D86644 VA: 0x1D8A644 Slot: 10
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }
}

// Namespace: System.Net
[Serializable]
public class FileWebRequest : WebRequest, ISerializable // TypeDefIndex: 4221
{
	// Fields
	private static WaitCallback s_GetRequestStreamCallback; // 0x0
	private static WaitCallback s_GetResponseCallback; // 0x8
	private string m_connectionGroupName; // 0x38
	private long m_contentLength; // 0x40
	private ICredentials m_credentials; // 0x48
	private FileAccess m_fileAccess; // 0x50
	private WebHeaderCollection m_headers; // 0x58
	private string m_method; // 0x60
	private IWebProxy m_proxy; // 0x68
	private ManualResetEvent m_readerEvent; // 0x70
	private bool m_readPending; // 0x78
	private WebResponse m_response; // 0x80
	private Stream m_stream; // 0x88
	private bool m_syncHint; // 0x90
	private int m_timeout; // 0x94
	private Uri m_uri; // 0x98
	private bool m_writePending; // 0xA0
	private bool m_writing; // 0xA1
	private LazyAsyncResult m_WriteAResult; // 0xA8
	private LazyAsyncResult m_ReadAResult; // 0xB0
	private int m_Aborted; // 0xB8

	// Properties
	internal bool Aborted { get; }
	public override long ContentLength { get; }
	public override ICredentials Credentials { get; set; }
	public override WebHeaderCollection Headers { get; }
	public override string Method { get; set; }
	public override IWebProxy Proxy { get; set; }
	public override int Timeout { get; }
	public override Uri RequestUri { get; }
	public override bool UseDefaultCredentials { get; }

	// Methods

	// RVA: 0x1D8A64C Offset: 0x1D8664C VA: 0x1D8A64C
	internal void .ctor(Uri uri) { }

	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x1D8A7D4 Offset: 0x1D867D4 VA: 0x1D8A7D4
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D8AC00 Offset: 0x1D86C00 VA: 0x1D8AC00 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D8AC0C Offset: 0x1D86C0C VA: 0x1D8AC0C Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D8AEA8 Offset: 0x1D86EA8 VA: 0x1D8AEA8
	internal bool get_Aborted() { }

	// RVA: 0x1D8AEB8 Offset: 0x1D86EB8 VA: 0x1D8AEB8 Slot: 13
	public override long get_ContentLength() { }

	// RVA: 0x1D8AEC0 Offset: 0x1D86EC0 VA: 0x1D8AEC0 Slot: 14
	public override ICredentials get_Credentials() { }

	// RVA: 0x1D8AEC8 Offset: 0x1D86EC8 VA: 0x1D8AEC8 Slot: 15
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1D8AED0 Offset: 0x1D86ED0 VA: 0x1D8AED0 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1D8AED8 Offset: 0x1D86ED8 VA: 0x1D8AED8 Slot: 9
	public override string get_Method() { }

	// RVA: 0x1D8AEE0 Offset: 0x1D86EE0 VA: 0x1D8AEE0 Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x1D8AFBC Offset: 0x1D86FBC VA: 0x1D8AFBC Slot: 17
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1D8AFC4 Offset: 0x1D86FC4 VA: 0x1D8AFC4 Slot: 18
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1D8AFCC Offset: 0x1D86FCC VA: 0x1D8AFCC Slot: 19
	public override int get_Timeout() { }

	// RVA: 0x1D8AFD4 Offset: 0x1D86FD4 VA: 0x1D8AFD4 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x1D8AFDC Offset: 0x1D86FDC VA: 0x1D8AFDC Slot: 21
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1D8B2D8 Offset: 0x1D872D8 VA: 0x1D8B2D8 Slot: 22
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1D8B598 Offset: 0x1D87598 VA: 0x1D8B598 Slot: 20
	public override WebResponse GetResponse() { }

	// RVA: 0x1D8B8EC Offset: 0x1D878EC VA: 0x1D8B8EC
	private static void GetRequestStreamCallback(object state) { }

	// RVA: 0x1D8BBB0 Offset: 0x1D87BB0 VA: 0x1D8BBB0
	private static void GetResponseCallback(object state) { }

	// RVA: 0x1D8C20C Offset: 0x1D8820C VA: 0x1D8C20C
	internal void UnblockReader() { }

	// RVA: 0x1D8C2EC Offset: 0x1D882EC VA: 0x1D8C2EC Slot: 16
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1D8C314 Offset: 0x1D88314 VA: 0x1D8C314 Slot: 24
	public override void Abort() { }

	// RVA: 0x1D8C670 Offset: 0x1D88670 VA: 0x1D8C670
	private static void .cctor() { }
}

// Namespace: System.Net
internal class FileWebRequestCreator : IWebRequestCreate // TypeDefIndex: 4222
{
	// Methods

	// RVA: 0x1D8C754 Offset: 0x1D88754 VA: 0x1D8C754
	internal void .ctor() { }

	// RVA: 0x1D8C75C Offset: 0x1D8875C VA: 0x1D8C75C Slot: 4
	public WebRequest Create(Uri uri) { }
}

// Namespace: System.Net
internal sealed class FileWebStream : FileStream, ICloseEx // TypeDefIndex: 4223
{
	// Fields
	private FileWebRequest m_request; // 0x70

	// Methods

	// RVA: 0x1D8BB0C Offset: 0x1D87B0C VA: 0x1D8BB0C
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing) { }

	// RVA: 0x1D8C7B4 Offset: 0x1D887B4 VA: 0x1D8C7B4
	public void .ctor(FileWebRequest request, string path, FileMode mode, FileAccess access, FileShare sharing, int length, bool async) { }

	// RVA: 0x1D8C870 Offset: 0x1D88870 VA: 0x1D8C870 Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1D8C91C Offset: 0x1D8891C VA: 0x1D8C91C Slot: 40
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1D8C958 Offset: 0x1D88958 VA: 0x1D8C958 Slot: 32
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1D8CAA0 Offset: 0x1D88AA0 VA: 0x1D8CAA0 Slot: 35
	public override void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1D8CB68 Offset: 0x1D88B68 VA: 0x1D8CB68 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1D8CC48 Offset: 0x1D88C48 VA: 0x1D8CC48 Slot: 23
	public override int EndRead(IAsyncResult ar) { }

	// RVA: 0x1D8CCE8 Offset: 0x1D88CE8 VA: 0x1D8CCE8 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int size, AsyncCallback callback, object state) { }

	// RVA: 0x1D8CDC8 Offset: 0x1D88DC8 VA: 0x1D8CDC8 Slot: 27
	public override void EndWrite(IAsyncResult ar) { }

	// RVA: 0x1D8CA20 Offset: 0x1D88A20 VA: 0x1D8CA20
	private void CheckError() { }
}

// Namespace: System.Net
[Serializable]
public class FileWebResponse : WebResponse, ISerializable, ICloseEx // TypeDefIndex: 4224
{
	// Fields
	private bool m_closed; // 0x19
	private long m_contentLength; // 0x20
	private FileAccess m_fileAccess; // 0x28
	private WebHeaderCollection m_headers; // 0x30
	private Stream m_stream; // 0x38
	private Uri m_uri; // 0x40

	// Properties
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }

	// Methods

	// RVA: 0x1D8BEFC Offset: 0x1D87EFC VA: 0x1D8BEFC
	internal void .ctor(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint) { }

	[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x1D8CE68 Offset: 0x1D88E68 VA: 0x1D8CE68
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D8D0E0 Offset: 0x1D890E0 VA: 0x1D8D0E0 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D8D0EC Offset: 0x1D890EC VA: 0x1D8D0EC Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D8D298 Offset: 0x1D89298 VA: 0x1D8D298 Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1D8D324 Offset: 0x1D89324 VA: 0x1D8D324 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x1D8D2B0 Offset: 0x1D892B0 VA: 0x1D8D2B0
	private void CheckDisposed() { }

	// RVA: 0x1D8D33C Offset: 0x1D8933C VA: 0x1D8D33C Slot: 9
	public override void Close() { }

	// RVA: 0x1D8D3D4 Offset: 0x1D893D4 VA: 0x1D8D3D4 Slot: 15
	private void System.Net.ICloseEx.CloseEx(CloseExState closeState) { }

	// RVA: 0x1D8D544 Offset: 0x1D89544 VA: 0x1D8D544 Slot: 12
	public override Stream GetResponseStream() { }
}

// Namespace: System.Net
public interface IWebProxy // TypeDefIndex: 4225
{
	// Properties
	public abstract ICredentials Credentials { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Uri GetProxy(Uri destination);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsBypassed(Uri host);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ICredentials get_Credentials();
}

// Namespace: System.Net
[Serializable]
public class WebProxy : IWebProxy, ISerializable // TypeDefIndex: 4226
{
	// Fields
	private bool _UseRegistry; // 0x10
	private bool _BypassOnLocal; // 0x11
	private bool m_EnableAutoproxy; // 0x12
	private Uri _ProxyAddress; // 0x18
	private ArrayList _BypassList; // 0x20
	private ICredentials _Credentials; // 0x28
	private Regex[] _RegExBypassList; // 0x30
	private Hashtable _ProxyHostAddresses; // 0x38
	private AutoWebProxyScriptEngine m_ScriptEngine; // 0x40

	// Properties
	public ICredentials Credentials { get; }
	public bool UseDefaultCredentials { get; set; }
	internal AutoWebProxyScriptEngine ScriptEngine { get; }

	// Methods

	// RVA: 0x1D8D598 Offset: 0x1D89598 VA: 0x1D8D598
	public void .ctor() { }

	// RVA: 0x1D8D5AC Offset: 0x1D895AC VA: 0x1D8D5AC
	public void .ctor(Uri Address, bool BypassOnLocal, string[] BypassList, ICredentials Credentials) { }

	// RVA: 0x1D8D8D4 Offset: 0x1D898D4 VA: 0x1D8D8D4 Slot: 6
	public ICredentials get_Credentials() { }

	// RVA: 0x1D8D8DC Offset: 0x1D898DC VA: 0x1D8D8DC
	public bool get_UseDefaultCredentials() { }

	// RVA: 0x1D8D958 Offset: 0x1D89958 VA: 0x1D8D958
	public void set_UseDefaultCredentials(bool value) { }

	// RVA: 0x1D8D9D0 Offset: 0x1D899D0 VA: 0x1D8D9D0 Slot: 4
	public Uri GetProxy(Uri destination) { }

	// RVA: 0x1D8D680 Offset: 0x1D89680 VA: 0x1D8D680
	private void UpdateRegExList(bool canThrow) { }

	// RVA: 0x1D8DC94 Offset: 0x1D89C94 VA: 0x1D8DC94
	private bool IsMatchInBypassList(Uri input) { }

	// RVA: 0x1D8DE2C Offset: 0x1D89E2C VA: 0x1D8DE2C
	private bool IsLocal(Uri host) { }

	// RVA: 0x1D8DF88 Offset: 0x1D89F88 VA: 0x1D8DF88
	private bool IsLocalInProxyHash(Uri host) { }

	// RVA: 0x1D8E078 Offset: 0x1D8A078 VA: 0x1D8E078 Slot: 5
	public bool IsBypassed(Uri host) { }

	// RVA: 0x1D8DBCC Offset: 0x1D89BCC VA: 0x1D8DBCC
	private bool IsBypassedManual(Uri host) { }

	// RVA: 0x1D8E1B4 Offset: 0x1D8A1B4 VA: 0x1D8E1B4
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D8E540 Offset: 0x1D8A540 VA: 0x1D8E540 Slot: 7
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D8E54C Offset: 0x1D8A54C VA: 0x1D8E54C Slot: 8
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D8E670 Offset: 0x1D8A670 VA: 0x1D8E670
	internal AutoWebProxyScriptEngine get_ScriptEngine() { }

	// RVA: 0x1D8E678 Offset: 0x1D8A678 VA: 0x1D8E678
	public static IWebProxy CreateDefaultProxy() { }

	// RVA: 0x1D8E6D8 Offset: 0x1D8A6D8 VA: 0x1D8E6D8
	internal void .ctor(bool enableAutoproxy) { }

	// RVA: 0x1D8E534 Offset: 0x1D8A534 VA: 0x1D8E534
	internal void UnsafeUpdateFromRegistry() { }

	// RVA: 0x1D8DB4C Offset: 0x1D89B4C VA: 0x1D8DB4C
	private bool GetProxyAuto(Uri destination, out Uri proxyUri) { }

	// RVA: 0x1D8E148 Offset: 0x1D8A148 VA: 0x1D8E148
	private bool IsBypassedAuto(Uri destination, out bool isBypassed) { }

	// RVA: 0x1D8E728 Offset: 0x1D8A728 VA: 0x1D8E728
	private static bool AreAllBypassed(IEnumerable<string> proxies, bool checkFirstOnly) { }

	// RVA: 0x1D8E9F4 Offset: 0x1D8A9F4 VA: 0x1D8E9F4
	private static Uri ProxyUri(string proxyName) { }
}

// Namespace: System.Net
internal class AutoWebProxyScriptEngine // TypeDefIndex: 4227
{
	// Methods

	// RVA: 0x1D8E708 Offset: 0x1D8A708 VA: 0x1D8E708
	public bool GetProxies(Uri destination, out IList<string> proxyList) { }

	// RVA: 0x1D8EA90 Offset: 0x1D8AA90 VA: 0x1D8EA90
	public bool GetProxies(Uri destination, out IList<string> proxyList, ref int syncStatus) { }
}

// Namespace: 
internal static class UnsafeNclNativeMethods.HttpApi.HTTP_REQUEST_HEADER_ID // TypeDefIndex: 4228
{
	// Fields
	private static string[] m_Strings; // 0x0

	// Methods

	// RVA: 0x1D8F140 Offset: 0x1D8B140 VA: 0x1D8F140
	internal static string ToString(int position) { }

	// RVA: 0x1D8F1BC Offset: 0x1D8B1BC VA: 0x1D8F1BC
	private static void .cctor() { }
}

// Namespace: 
internal static class UnsafeNclNativeMethods.HttpApi // TypeDefIndex: 4229
{
	// Fields
	private static string[] m_Strings; // 0x0

	// Methods

	// RVA: 0x1D8EAB0 Offset: 0x1D8AAB0 VA: 0x1D8EAB0
	private static void .cctor() { }
}

// Namespace: 
internal static class UnsafeNclNativeMethods.SecureStringHelper // TypeDefIndex: 4230
{
	// Methods

	// RVA: 0x1D8FA5C Offset: 0x1D8BA5C VA: 0x1D8FA5C
	internal static string CreateString(SecureString secureString) { }

	// RVA: 0x1D8FB94 Offset: 0x1D8BB94 VA: 0x1D8FB94
	internal static SecureString CreateSecureString(string plainString) { }
}

// Namespace: System.Net
internal static class UnsafeNclNativeMethods // TypeDefIndex: 4231
{}

// Namespace: System.Net
internal static class Logging // TypeDefIndex: 4232
{
	// Properties
	internal static bool On { get; }

	// Methods

	// RVA: 0x1D81E80 Offset: 0x1D7DE80 VA: 0x1D81E80
	internal static bool get_On() { }
}

// Namespace: 
private class ServerCertValidationCallback.CallbackContext // TypeDefIndex: 4233
{
	// Fields
	internal readonly object request; // 0x10
	internal readonly X509Certificate certificate; // 0x18
	internal readonly X509Chain chain; // 0x20
	internal readonly SslPolicyErrors sslPolicyErrors; // 0x28
	internal bool result; // 0x2C

	// Methods

	// RVA: 0x1D8FEE0 Offset: 0x1D8BEE0 VA: 0x1D8FEE0
	internal void .ctor(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}

// Namespace: System.Net
internal class ServerCertValidationCallback // TypeDefIndex: 4234
{
	// Fields
	private readonly RemoteCertificateValidationCallback m_ValidationCallback; // 0x10
	private readonly ExecutionContext m_Context; // 0x18

	// Properties
	internal RemoteCertificateValidationCallback ValidationCallback { get; }

	// Methods

	// RVA: 0x1D8FC30 Offset: 0x1D8BC30 VA: 0x1D8FC30
	internal void .ctor(RemoteCertificateValidationCallback validationCallback) { }

	// RVA: 0x1D8FCBC Offset: 0x1D8BCBC VA: 0x1D8FCBC
	internal RemoteCertificateValidationCallback get_ValidationCallback() { }

	// RVA: 0x1D8FCC4 Offset: 0x1D8BCC4 VA: 0x1D8FCC4
	internal void Callback(object state) { }

	// RVA: 0x1D8FD70 Offset: 0x1D8BD70 VA: 0x1D8FD70
	internal bool Invoke(object request, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { }
}

// Namespace: System.Net
public class AuthenticationManager // TypeDefIndex: 4235
{
	// Fields
	private static ArrayList modules; // 0x0
	private static object locker; // 0x8
	private static ICredentialPolicy credential_policy; // 0x10

	// Methods

	// RVA: 0x1D8FF4C Offset: 0x1D8BF4C VA: 0x1D8FF4C
	private static void EnsureModules() { }

	// RVA: 0x1D901E0 Offset: 0x1D8C1E0 VA: 0x1D901E0
	public static Authorization Authenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x1D902E0 Offset: 0x1D8C2E0 VA: 0x1D902E0
	private static Authorization DoAuthenticate(string challenge, WebRequest request, ICredentials credentials) { }

	// RVA: 0x1D90764 Offset: 0x1D8C764 VA: 0x1D90764
	public static Authorization PreAuthenticate(WebRequest request, ICredentials credentials) { }

	// RVA: 0x1D90C3C Offset: 0x1D8CC3C VA: 0x1D90C3C
	private static void .cctor() { }
}

// Namespace: System.Net
internal class BasicClient : IAuthenticationModule // TypeDefIndex: 4236
{
	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1D90CC4 Offset: 0x1D8CCC4 VA: 0x1D90CC4 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1D91080 Offset: 0x1D8D080 VA: 0x1D91080
	private static byte[] GetBytes(string str) { }

	// RVA: 0x1D90D70 Offset: 0x1D8CD70 VA: 0x1D90D70
	private static Authorization InternalAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1D9112C Offset: 0x1D8D12C VA: 0x1D9112C Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1D91138 Offset: 0x1D8D138 VA: 0x1D91138 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x1D901D8 Offset: 0x1D8C1D8 VA: 0x1D901D8
	public void .ctor() { }
}

// Namespace: System.Net
public sealed class BindIPEndPoint : MulticastDelegate // TypeDefIndex: 4237
{
	// Methods

	// RVA: 0x1D91178 Offset: 0x1D8D178 VA: 0x1D91178
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D91284 Offset: 0x1D8D284 VA: 0x1D91284 Slot: 12
	public virtual IPEndPoint Invoke(ServicePoint servicePoint, IPEndPoint remoteEndPoint, int retryCount) { }
}

// Namespace: 
[CompilerGenerated]
private struct BufferedReadStream.<ProcessReadAsync>d__2 : IAsyncStateMachine // TypeDefIndex: 4238
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public BufferedReadStream <>4__this; // 0x28
	public int size; // 0x30
	public byte[] buffer; // 0x38
	public int offset; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48

	// Methods

	// RVA: 0x1D914C0 Offset: 0x1D8D4C0 VA: 0x1D914C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1D91818 Offset: 0x1D8D818 VA: 0x1D91818 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class BufferedReadStream : WebReadStream // TypeDefIndex: 4239
{
	// Fields
	private readonly BufferOffsetSize readBuffer; // 0x40

	// Methods

	// RVA: 0x1D91298 Offset: 0x1D8D298 VA: 0x1D91298
	public void .ctor(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer) { }

	[AsyncStateMachine(typeof(BufferedReadStream.<ProcessReadAsync>d__2))]
	// RVA: 0x1D912C8 Offset: 0x1D8D2C8 VA: 0x1D912C8 Slot: 38
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1D91430 Offset: 0x1D8D430 VA: 0x1D91430
	internal bool TryReadFromBuffer(byte[] buffer, int offset, int size, out int result) { }
}

// Namespace: 
internal enum ContentDecodeStream.Mode // TypeDefIndex: 4240
{
	// Fields
	public int value__; // 0x0
	public const ContentDecodeStream.Mode GZip = 0;
	public const ContentDecodeStream.Mode Deflate = 1;
}

// Namespace: System.Net
internal class ContentDecodeStream : WebReadStream // TypeDefIndex: 4241
{
	// Fields
	[CompilerGenerated]
	private readonly Stream <OriginalInnerStream>k__BackingField; // 0x40

	// Properties
	private Stream OriginalInnerStream { get; }

	// Methods

	// RVA: 0x1D91894 Offset: 0x1D8D894 VA: 0x1D91894
	public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, ContentDecodeStream.Mode mode) { }

	[CompilerGenerated]
	// RVA: 0x1D919AC Offset: 0x1D8D9AC VA: 0x1D919AC
	private Stream get_OriginalInnerStream() { }

	// RVA: 0x1D9197C Offset: 0x1D8D97C VA: 0x1D9197C
	private void .ctor(WebOperation operation, Stream decodeStream, Stream originalInnerStream) { }

	// RVA: 0x1D919B4 Offset: 0x1D8D9B4 VA: 0x1D919B4 Slot: 38
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1D919D4 Offset: 0x1D8D9D4 VA: 0x1D919D4 Slot: 39
	internal override Task FinishReading(CancellationToken cancellationToken) { }
}

// Namespace: System.Net
[Flags]
public enum DecompressionMethods // TypeDefIndex: 4242
{
	// Fields
	public int value__; // 0x0
	public const DecompressionMethods None = 0;
	public const DecompressionMethods GZip = 1;
	public const DecompressionMethods Deflate = 2;
}

// Namespace: System.Net
internal class DefaultCertificatePolicy // TypeDefIndex: 4243
{}

// Namespace: System.Net
internal class DigestHeaderParser // TypeDefIndex: 4244
{
	// Fields
	private string header; // 0x10
	private int length; // 0x18
	private int pos; // 0x1C
	private static string[] keywords; // 0x0
	private string[] values; // 0x20

	// Properties
	public string Realm { get; }
	public string Opaque { get; }
	public string Nonce { get; }
	public string Algorithm { get; }
	public string QOP { get; }

	// Methods

	// RVA: 0x1D91AC4 Offset: 0x1D8DAC4 VA: 0x1D91AC4
	public void .ctor(string header) { }

	// RVA: 0x1D91B8C Offset: 0x1D8DB8C VA: 0x1D91B8C
	public string get_Realm() { }

	// RVA: 0x1D91BB4 Offset: 0x1D8DBB4 VA: 0x1D91BB4
	public string get_Opaque() { }

	// RVA: 0x1D91BE0 Offset: 0x1D8DBE0 VA: 0x1D91BE0
	public string get_Nonce() { }

	// RVA: 0x1D91C0C Offset: 0x1D8DC0C VA: 0x1D91C0C
	public string get_Algorithm() { }

	// RVA: 0x1D91C38 Offset: 0x1D8DC38 VA: 0x1D91C38
	public string get_QOP() { }

	// RVA: 0x1D91C64 Offset: 0x1D8DC64 VA: 0x1D91C64
	public bool Parse() { }

	// RVA: 0x1D91FDC Offset: 0x1D8DFDC VA: 0x1D91FDC
	private void SkipWhitespace() { }

	// RVA: 0x1D9205C Offset: 0x1D8E05C VA: 0x1D9205C
	private string GetKey() { }

	// RVA: 0x1D91E0C Offset: 0x1D8DE0C VA: 0x1D91E0C
	private bool GetKeywordAndValue(out string key, out string value) { }

	// RVA: 0x1D920EC Offset: 0x1D8E0EC VA: 0x1D920EC
	private static void .cctor() { }
}

// Namespace: System.Net
internal class DigestSession // TypeDefIndex: 4245
{
	// Fields
	private static RandomNumberGenerator rng; // 0x0
	private DateTime lastUse; // 0x10
	private int _nc; // 0x18
	private HashAlgorithm hash; // 0x20
	private DigestHeaderParser parser; // 0x28
	private string _cnonce; // 0x30

	// Properties
	public string Algorithm { get; }
	public string Realm { get; }
	public string Nonce { get; }
	public string Opaque { get; }
	public string QOP { get; }
	public string CNonce { get; }
	public DateTime LastUse { get; }

	// Methods

	// RVA: 0x1D9226C Offset: 0x1D8E26C VA: 0x1D9226C
	private static void .cctor() { }

	// RVA: 0x1D922C8 Offset: 0x1D8E2C8 VA: 0x1D922C8
	public void .ctor() { }

	// RVA: 0x1D92338 Offset: 0x1D8E338 VA: 0x1D92338
	public string get_Algorithm() { }

	// RVA: 0x1D9234C Offset: 0x1D8E34C VA: 0x1D9234C
	public string get_Realm() { }

	// RVA: 0x1D92360 Offset: 0x1D8E360 VA: 0x1D92360
	public string get_Nonce() { }

	// RVA: 0x1D92374 Offset: 0x1D8E374 VA: 0x1D92374
	public string get_Opaque() { }

	// RVA: 0x1D92388 Offset: 0x1D8E388 VA: 0x1D92388
	public string get_QOP() { }

	// RVA: 0x1D9239C Offset: 0x1D8E39C VA: 0x1D9239C
	public string get_CNonce() { }

	// RVA: 0x1D9249C Offset: 0x1D8E49C VA: 0x1D9249C
	public bool Parse(string challenge) { }

	// RVA: 0x1D92594 Offset: 0x1D8E594 VA: 0x1D92594
	private string HashToHexString(string toBeHashed) { }

	// RVA: 0x1D926E8 Offset: 0x1D8E6E8 VA: 0x1D926E8
	private string HA1(string username, string password) { }

	// RVA: 0x1D9280C Offset: 0x1D8E80C VA: 0x1D9280C
	private string HA2(HttpWebRequest webRequest) { }

	// RVA: 0x1D928DC Offset: 0x1D8E8DC VA: 0x1D928DC
	private string Response(string username, string password, HttpWebRequest webRequest) { }

	// RVA: 0x1D92A3C Offset: 0x1D8EA3C VA: 0x1D92A3C
	public Authorization Authenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1D93000 Offset: 0x1D8F000 VA: 0x1D93000
	public DateTime get_LastUse() { }
}

// Namespace: System.Net
internal class DigestClient : IAuthenticationModule // TypeDefIndex: 4246
{
	// Fields
	private static readonly Hashtable cache; // 0x0

	// Properties
	private static Hashtable Cache { get; }
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1D93008 Offset: 0x1D8F008 VA: 0x1D93008
	private static Hashtable get_Cache() { }

	// RVA: 0x1D93174 Offset: 0x1D8F174 VA: 0x1D93174
	private static void CheckExpired(int count) { }

	// RVA: 0x1D93948 Offset: 0x1D8F948 VA: 0x1D93948 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1D93BD4 Offset: 0x1D8FBD4 VA: 0x1D93BD4 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1D93D44 Offset: 0x1D8FD44 VA: 0x1D93D44 Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x1D901D0 Offset: 0x1D8C1D0 VA: 0x1D901D0
	public void .ctor() { }

	// RVA: 0x1D93D84 Offset: 0x1D8FD84 VA: 0x1D93D84
	private static void .cctor() { }
}

// Namespace: 
private sealed class Dns.GetHostAddressesCallback : MulticastDelegate // TypeDefIndex: 4247
{
	// Methods

	// RVA: 0x1D93F94 Offset: 0x1D8FF94 VA: 0x1D93F94
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1D94C30 Offset: 0x1D90C30 VA: 0x1D94C30 Slot: 12
	public virtual IPAddress[] Invoke(string hostName) { }

	// RVA: 0x1D94044 Offset: 0x1D90044 VA: 0x1D94044 Slot: 13
	public virtual IAsyncResult BeginInvoke(string hostName, AsyncCallback callback, object object) { }

	// RVA: 0x1D9416C Offset: 0x1D9016C VA: 0x1D9416C Slot: 14
	public virtual IPAddress[] EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Net
public static class Dns // TypeDefIndex: 4248
{
	// Methods

	// RVA: 0x1D93E0C Offset: 0x1D8FE0C VA: 0x1D93E0C
	public static IAsyncResult BeginGetHostAddresses(string hostNameOrAddress, AsyncCallback requestCallback, object state) { }

	// RVA: 0x1D94064 Offset: 0x1D90064 VA: 0x1D94064
	public static IPAddress[] EndGetHostAddresses(IAsyncResult asyncResult) { }

	// RVA: 0x1D94178 Offset: 0x1D90178 VA: 0x1D94178
	private static bool GetHostByName_icall(string host, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x1D9417C Offset: 0x1D9017C VA: 0x1D9417C
	private static bool GetHostByAddr_icall(string addr, out string h_name, out string[] h_aliases, out string[] h_addr_list, int hint) { }

	// RVA: 0x1D94180 Offset: 0x1D90180 VA: 0x1D94180
	private static bool GetHostName_icall(out string h_name) { }

	// RVA: 0x1D94184 Offset: 0x1D90184 VA: 0x1D94184
	private static void Error_11001(string hostName) { }

	// RVA: 0x1D941E8 Offset: 0x1D901E8 VA: 0x1D941E8
	private static IPHostEntry hostent_to_IPHostEntry(string originalHostName, string h_name, string[] h_aliases, string[] h_addrlist) { }

	// RVA: 0x1D94528 Offset: 0x1D90528 VA: 0x1D94528
	private static IPHostEntry GetHostByAddressFromString(string address, bool parse) { }

	// RVA: 0x1D94654 Offset: 0x1D90654 VA: 0x1D94654
	public static IPHostEntry GetHostEntry(string hostNameOrAddress) { }

	// RVA: 0x1D947C0 Offset: 0x1D907C0 VA: 0x1D947C0
	public static IPHostEntry GetHostEntry(IPAddress address) { }

	// RVA: 0x1D94910 Offset: 0x1D90910 VA: 0x1D94910
	public static IPAddress[] GetHostAddresses(string hostNameOrAddress) { }

	[Obsolete("Use GetHostEntry instead")]
	// RVA: 0x1D94828 Offset: 0x1D90828 VA: 0x1D94828
	public static IPHostEntry GetHostByName(string hostName) { }

	// RVA: 0x1D94AF0 Offset: 0x1D90AF0 VA: 0x1D94AF0
	public static string GetHostName() { }

	// RVA: 0x1D94B14 Offset: 0x1D90B14 VA: 0x1D94B14
	public static Task<IPAddress[]> GetHostAddressesAsync(string hostNameOrAddress) { }
}

// Namespace: 
[CompilerGenerated]
private struct FixedSizeReadStream.<ProcessReadAsync>d__5 : IAsyncStateMachine // TypeDefIndex: 4249
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public FixedSizeReadStream <>4__this; // 0x28
	public int size; // 0x30
	public byte[] buffer; // 0x38
	public int offset; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48

	// Methods

	// RVA: 0x1D94DDC Offset: 0x1D90DDC VA: 0x1D94DDC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1D95120 Offset: 0x1D91120 VA: 0x1D95120 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class FixedSizeReadStream : WebReadStream // TypeDefIndex: 4250
{
	// Fields
	[CompilerGenerated]
	private readonly long <ContentLength>k__BackingField; // 0x40
	private long position; // 0x48

	// Properties
	public long ContentLength { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D94C44 Offset: 0x1D90C44 VA: 0x1D94C44
	public long get_ContentLength() { }

	// RVA: 0x1D94C4C Offset: 0x1D90C4C VA: 0x1D94C4C
	public void .ctor(WebOperation operation, Stream innerStream, long contentLength) { }

	[AsyncStateMachine(typeof(FixedSizeReadStream.<ProcessReadAsync>d__5))]
	// RVA: 0x1D94C74 Offset: 0x1D90C74 VA: 0x1D94C74 Slot: 38
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }
}

// Namespace: System.Net
internal class HttpRequestCreator : IWebRequestCreate // TypeDefIndex: 4251
{
	// Methods

	// RVA: 0x1D9519C Offset: 0x1D9119C VA: 0x1D9519C
	internal void .ctor() { }

	// RVA: 0x1D951A4 Offset: 0x1D911A4 VA: 0x1D951A4 Slot: 4
	public WebRequest Create(Uri uri) { }
}

// Namespace: 
private enum HttpWebRequest.NtlmAuthState // TypeDefIndex: 4252
{
	// Fields
	public int value__; // 0x0
	public const HttpWebRequest.NtlmAuthState None = 0;
	public const HttpWebRequest.NtlmAuthState Challenge = 1;
	public const HttpWebRequest.NtlmAuthState Response = 2;
}

// Namespace: 
private struct HttpWebRequest.AuthorizationState // TypeDefIndex: 4253
{
	// Fields
	private readonly HttpWebRequest request; // 0x0
	private readonly bool isProxy; // 0x8
	private bool isCompleted; // 0x9
	private HttpWebRequest.NtlmAuthState ntlm_auth_state; // 0xC

	// Properties
	public bool IsCompleted { get; }
	public HttpWebRequest.NtlmAuthState NtlmAuthState { get; }
	public bool IsNtlmAuthenticated { get; }

	// Methods

	// RVA: 0x1D98CC0 Offset: 0x1D94CC0 VA: 0x1D98CC0
	public bool get_IsCompleted() { }

	// RVA: 0x1D98CC8 Offset: 0x1D94CC8 VA: 0x1D98CC8
	public HttpWebRequest.NtlmAuthState get_NtlmAuthState() { }

	// RVA: 0x1D98CD0 Offset: 0x1D94CD0 VA: 0x1D98CD0
	public bool get_IsNtlmAuthenticated() { }

	// RVA: 0x1D95658 Offset: 0x1D91658 VA: 0x1D95658
	public void .ctor(HttpWebRequest request, bool isProxy) { }

	// RVA: 0x1D98140 Offset: 0x1D94140 VA: 0x1D98140
	public bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x1D98AEC Offset: 0x1D94AEC VA: 0x1D98AEC
	public void Reset() { }

	// RVA: 0x1D98CF0 Offset: 0x1D94CF0 VA: 0x1D98CF0 Slot: 3
	public override string ToString() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class HttpWebRequest.<>c__241<T> // TypeDefIndex: 4254
{
	// Fields
	public static readonly HttpWebRequest.<>c__241<T> <>9; // 0x0
	public static Func<Task<T>, Nullable<int>> <>9__241_0; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1153D44 Offset: 0x114FD44 VA: 0x1153D44
	|-HttpWebRequest.<>c__241<int>..cctor
	|
	|-RVA: 0x1153EA8 Offset: 0x114FEA8 VA: 0x1153EA8
	|-HttpWebRequest.<>c__241<object>..cctor
	|
	|-RVA: 0x115400C Offset: 0x115000C VA: 0x115400C
	|-HttpWebRequest.<>c__241<__Il2CppFullySharedGenericType>..cctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1153E1C Offset: 0x114FE1C VA: 0x1153E1C
	|-HttpWebRequest.<>c__241<int>..ctor
	|
	|-RVA: 0x1153F80 Offset: 0x114FF80 VA: 0x1153F80
	|-HttpWebRequest.<>c__241<object>..ctor
	|
	|-RVA: 0x1154118 Offset: 0x1150118 VA: 0x1154118
	|-HttpWebRequest.<>c__241<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal Nullable<int> <RunWithTimeoutWorker>b__241_0(Task<T> t) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1153E24 Offset: 0x114FE24 VA: 0x1153E24
	|-HttpWebRequest.<>c__241<int>.<RunWithTimeoutWorker>b__241_0
	|
	|-RVA: 0x1153F88 Offset: 0x114FF88 VA: 0x1153F88
	|-HttpWebRequest.<>c__241<object>.<RunWithTimeoutWorker>b__241_0
	|
	|-RVA: 0x1154120 Offset: 0x1150120 VA: 0x1154120
	|-HttpWebRequest.<>c__241<__Il2CppFullySharedGenericType>.<RunWithTimeoutWorker>b__241_0
	*/
}

// Namespace: 
[CompilerGenerated]
private struct HttpWebRequest.<RunWithTimeoutWorker>d__241<T> : IAsyncStateMachine // TypeDefIndex: 4255
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<T> <>t__builder; // 0x0
	public Task<T> workerTask; // 0x0
	public int timeout; // 0x0
	public CancellationTokenSource cts; // 0x0
	public Action abort; // 0x0
	public Func<bool> aborted; // 0x0
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x116947C Offset: 0x116547C VA: 0x116947C
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<int>.MoveNext
	|
	|-RVA: 0x1169D50 Offset: 0x1165D50 VA: 0x1169D50
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<object>.MoveNext
	|
	|-RVA: 0x116A624 Offset: 0x1166624 VA: 0x116A624
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1169CCC Offset: 0x1165CCC VA: 0x1169CCC
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<int>.SetStateMachine
	|
	|-RVA: 0x116A5A0 Offset: 0x11665A0 VA: 0x116A5A0
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<object>.SetStateMachine
	|
	|-RVA: 0x116B164 Offset: 0x1167164 VA: 0x116B164
	|-HttpWebRequest.<RunWithTimeoutWorker>d__241<__Il2CppFullySharedGenericType>.SetStateMachine
	*/
}

// Namespace: 
[CompilerGenerated]
private struct HttpWebRequest.<MyGetResponseAsync>d__243 : IAsyncStateMachine // TypeDefIndex: 4256
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<HttpWebResponse> <>t__builder; // 0x8
	public HttpWebRequest <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private WebCompletionSource <completion>5__2; // 0x30
	private WebOperation <operation>5__3; // 0x38
	private WebException <throwMe>5__4; // 0x40
	private HttpWebResponse <response>5__5; // 0x48
	private WebResponseStream <stream>5__6; // 0x50
	private bool <redirect>5__7; // 0x58
	private bool <mustReadAll>5__8; // 0x59
	private WebOperation <ntlm>5__9; // 0x60
	private BufferOffsetSize <writeBuffer>5__10; // 0x68
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebRequestStream> <>u__1; // 0x70
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x80
	private TaskAwaiter<WebResponseStream> <>u__3; // 0x90
	[TupleElementNames(new[] { "response", "redirect", "mustReadAll", "writeBuffer", "ntlm" })]
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> <>u__4; // 0x98

	// Methods

	// RVA: 0x1D98DDC Offset: 0x1D94DDC VA: 0x1D98DDC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1D99EAC Offset: 0x1D95EAC VA: 0x1D99EAC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpWebRequest.<GetResponseFromData>d__244 : IAsyncStateMachine // TypeDefIndex: 4257
{
	// Fields
	public int <>1__state; // 0x0
	[TupleElementNames(new[] { "response", "redirect", "mustReadAll", "writeBuffer", "ntlm" })]
	public AsyncTaskMethodBuilder<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> <>t__builder; // 0x8
	public HttpWebRequest <>4__this; // 0x20
	public WebResponseStream stream; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private HttpWebResponse <response>5__2; // 0x38
	private WebException <throwMe>5__3; // 0x40
	private bool <redirect>5__4; // 0x48
	private bool <mustReadAll>5__5; // 0x49
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<BufferOffsetSize> <>u__2; // 0x60

	// Methods

	// RVA: 0x1D99F28 Offset: 0x1D95F28 VA: 0x1D99F28 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1D9AC20 Offset: 0x1D96C20 VA: 0x1D9AC20 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct HttpWebRequest.<<GetRewriteHandler>b__271_0>d : IAsyncStateMachine // TypeDefIndex: 4258
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<BufferOffsetSize> <>t__builder; // 0x8
	public HttpWebRequest <>4__this; // 0x20
	private MemoryStream <ms>5__2; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1D9AC9C Offset: 0x1D96C9C VA: 0x1D9AC9C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1D9B104 Offset: 0x1D97104 VA: 0x1D9B104 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
[Serializable]
public class HttpWebRequest : WebRequest, ISerializable // TypeDefIndex: 4259
{
	// Fields
	private Uri requestUri; // 0x38
	private Uri actualUri; // 0x40
	private bool hostChanged; // 0x48
	private bool allowAutoRedirect; // 0x49
	private bool allowBuffering; // 0x4A
	private X509CertificateCollection certificates; // 0x50
	private string connectionGroup; // 0x58
	private bool haveContentLength; // 0x60
	private long contentLength; // 0x68
	private HttpContinueDelegate continueDelegate; // 0x70
	private CookieContainer cookieContainer; // 0x78
	private ICredentials credentials; // 0x80
	private bool haveResponse; // 0x88
	private bool requestSent; // 0x89
	private WebHeaderCollection webHeaders; // 0x90
	private bool keepAlive; // 0x98
	private int maxAutoRedirect; // 0x9C
	private string mediaType; // 0xA0
	private string method; // 0xA8
	private string initialMethod; // 0xB0
	private bool pipelined; // 0xB8
	private bool preAuthenticate; // 0xB9
	private bool usedPreAuth; // 0xBA
	private Version version; // 0xC0
	private bool force_version; // 0xC8
	private Version actualVersion; // 0xD0
	private IWebProxy proxy; // 0xD8
	private bool sendChunked; // 0xE0
	private ServicePoint servicePoint; // 0xE8
	private int timeout; // 0xF0
	private int continueTimeout; // 0xF4
	private WebRequestStream writeStream; // 0xF8
	private HttpWebResponse webResponse; // 0x100
	private WebCompletionSource responseTask; // 0x108
	private WebOperation currentOperation; // 0x110
	private int aborted; // 0x118
	private bool gotRequestStream; // 0x11C
	private int redirects; // 0x120
	private bool expectContinue; // 0x124
	private bool getResponseCalled; // 0x125
	private object locker; // 0x128
	private bool finished_reading; // 0x130
	private DecompressionMethods auto_decomp; // 0x134
	private static int defaultMaxResponseHeadersLength; // 0x0
	private static int defaultMaximumErrorResponseLength; // 0x4
	private static RequestCachePolicy defaultCachePolicy; // 0x8
	private int readWriteTimeout; // 0x138
	private MobileTlsProvider tlsProvider; // 0x140
	private MonoTlsSettings tlsSettings; // 0x148
	private ServerCertValidationCallback certValidationCallback; // 0x150
	private bool hostHasPort; // 0x158
	private Uri hostUri; // 0x160
	private HttpWebRequest.AuthorizationState auth_state; // 0x168
	private HttpWebRequest.AuthorizationState proxy_auth_state; // 0x178
	internal Func<Stream, Task> ResendContentFactory; // 0x188
	[CompilerGenerated]
	private bool <ThrowOnError>k__BackingField; // 0x190
	private bool unsafe_auth_blah; // 0x191

	// Properties
	public Uri Address { get; }
	public virtual bool AllowWriteStreamBuffering { get; }
	public DecompressionMethods AutomaticDecompression { get; }
	internal bool InternalAllowBuffering { get; }
	private bool MethodWithBuffer { get; }
	internal MobileTlsProvider TlsProvider { get; }
	internal MonoTlsSettings TlsSettings { get; }
	public X509CertificateCollection ClientCertificates { get; }
	public override long ContentLength { get; }
	internal long InternalContentLength { set; }
	internal bool ThrowOnError { get; set; }
	public override ICredentials Credentials { get; set; }
	[MonoTODO]
	public static int DefaultMaximumErrorResponseLength { get; }
	public override WebHeaderCollection Headers { get; }
	public string Host { get; }
	public bool KeepAlive { get; }
	public int ReadWriteTimeout { get; }
	public override string Method { get; set; }
	public Version ProtocolVersion { get; }
	public override IWebProxy Proxy { get; set; }
	public override Uri RequestUri { get; }
	public bool SendChunked { get; }
	public ServicePoint ServicePoint { get; }
	internal ServicePoint ServicePointNoLock { get; }
	public override int Timeout { get; }
	public string TransferEncoding { get; }
	public override bool UseDefaultCredentials { get; }
	public bool UnsafeAuthenticatedConnectionSharing { get; }
	internal bool ExpectContinue { get; set; }
	internal Uri AuthUri { get; }
	internal bool ProxyQuery { get; }
	internal ServerCertValidationCallback ServerCertValidationCallback { get; }
	public RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; }
	internal bool FinishedReading { set; }
	internal bool Aborted { get; }

	// Methods

	// RVA: 0x1D953F8 Offset: 0x1D913F8 VA: 0x1D953F8
	private static void .cctor() { }

	// RVA: 0x1D951FC Offset: 0x1D911FC VA: 0x1D951FC
	public void .ctor(Uri uri) { }

	[Obsolete("Serialization is obsoleted for this type.  http://go.microsoft.com/fwlink/?linkid=14202")]
	// RVA: 0x1D954F4 Offset: 0x1D914F4 VA: 0x1D954F4
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D95480 Offset: 0x1D91480 VA: 0x1D95480
	private void ResetAuthorization() { }

	// RVA: 0x1D95688 Offset: 0x1D91688 VA: 0x1D95688
	public Uri get_Address() { }

	// RVA: 0x1D95690 Offset: 0x1D91690 VA: 0x1D95690 Slot: 25
	public virtual bool get_AllowWriteStreamBuffering() { }

	// RVA: 0x1D95698 Offset: 0x1D91698 VA: 0x1D95698
	public DecompressionMethods get_AutomaticDecompression() { }

	// RVA: 0x1D956A0 Offset: 0x1D916A0 VA: 0x1D956A0
	internal bool get_InternalAllowBuffering() { }

	// RVA: 0x1D956B4 Offset: 0x1D916B4 VA: 0x1D956B4
	private bool get_MethodWithBuffer() { }

	// RVA: 0x1D957B0 Offset: 0x1D917B0 VA: 0x1D957B0
	internal MobileTlsProvider get_TlsProvider() { }

	// RVA: 0x1D957B8 Offset: 0x1D917B8 VA: 0x1D957B8
	internal MonoTlsSettings get_TlsSettings() { }

	// RVA: 0x1D957C0 Offset: 0x1D917C0 VA: 0x1D957C0
	public X509CertificateCollection get_ClientCertificates() { }

	// RVA: 0x1D95830 Offset: 0x1D91830 VA: 0x1D95830 Slot: 13
	public override long get_ContentLength() { }

	// RVA: 0x1D95838 Offset: 0x1D91838 VA: 0x1D95838
	internal void set_InternalContentLength(long value) { }

	[CompilerGenerated]
	// RVA: 0x1D95840 Offset: 0x1D91840 VA: 0x1D95840
	internal bool get_ThrowOnError() { }

	[CompilerGenerated]
	// RVA: 0x1D95848 Offset: 0x1D91848 VA: 0x1D95848
	internal void set_ThrowOnError(bool value) { }

	// RVA: 0x1D95850 Offset: 0x1D91850 VA: 0x1D95850 Slot: 14
	public override ICredentials get_Credentials() { }

	// RVA: 0x1D95858 Offset: 0x1D91858 VA: 0x1D95858 Slot: 15
	public override void set_Credentials(ICredentials value) { }

	// RVA: 0x1D95860 Offset: 0x1D91860 VA: 0x1D95860
	public static int get_DefaultMaximumErrorResponseLength() { }

	// RVA: 0x1D958B8 Offset: 0x1D918B8 VA: 0x1D958B8 Slot: 12
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1D958C0 Offset: 0x1D918C0 VA: 0x1D958C0
	public string get_Host() { }

	// RVA: 0x1D959D4 Offset: 0x1D919D4 VA: 0x1D959D4
	public bool get_KeepAlive() { }

	// RVA: 0x1D959DC Offset: 0x1D919DC VA: 0x1D959DC
	public int get_ReadWriteTimeout() { }

	// RVA: 0x1D959E4 Offset: 0x1D919E4 VA: 0x1D959E4 Slot: 9
	public override string get_Method() { }

	// RVA: 0x1D959EC Offset: 0x1D919EC VA: 0x1D959EC Slot: 10
	public override void set_Method(string value) { }

	// RVA: 0x1D95C38 Offset: 0x1D91C38 VA: 0x1D95C38
	public Version get_ProtocolVersion() { }

	// RVA: 0x1D95C40 Offset: 0x1D91C40 VA: 0x1D95C40 Slot: 17
	public override IWebProxy get_Proxy() { }

	// RVA: 0x1D95C48 Offset: 0x1D91C48 VA: 0x1D95C48 Slot: 18
	public override void set_Proxy(IWebProxy value) { }

	// RVA: 0x1D95E24 Offset: 0x1D91E24 VA: 0x1D95E24 Slot: 11
	public override Uri get_RequestUri() { }

	// RVA: 0x1D95E2C Offset: 0x1D91E2C VA: 0x1D95E2C
	public bool get_SendChunked() { }

	// RVA: 0x1D95E34 Offset: 0x1D91E34 VA: 0x1D95E34
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1D95E38 Offset: 0x1D91E38 VA: 0x1D95E38
	internal ServicePoint get_ServicePointNoLock() { }

	// RVA: 0x1D95E40 Offset: 0x1D91E40 VA: 0x1D95E40 Slot: 19
	public override int get_Timeout() { }

	// RVA: 0x1D95E48 Offset: 0x1D91E48 VA: 0x1D95E48
	public string get_TransferEncoding() { }

	// RVA: 0x1D95E9C Offset: 0x1D91E9C VA: 0x1D95E9C Slot: 16
	public override bool get_UseDefaultCredentials() { }

	// RVA: 0x1D95F14 Offset: 0x1D91F14 VA: 0x1D95F14
	public bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x1D95F1C Offset: 0x1D91F1C VA: 0x1D95F1C
	internal bool get_ExpectContinue() { }

	// RVA: 0x1D95F24 Offset: 0x1D91F24 VA: 0x1D95F24
	internal void set_ExpectContinue(bool value) { }

	// RVA: 0x1D95F2C Offset: 0x1D91F2C VA: 0x1D95F2C
	internal Uri get_AuthUri() { }

	// RVA: 0x1D95F34 Offset: 0x1D91F34 VA: 0x1D95F34
	internal bool get_ProxyQuery() { }

	// RVA: 0x1D95F64 Offset: 0x1D91F64 VA: 0x1D95F64
	internal ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x1D95F6C Offset: 0x1D91F6C VA: 0x1D95F6C
	public RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x1D95CE4 Offset: 0x1D91CE4 VA: 0x1D95CE4
	internal ServicePoint GetServicePoint() { }

	// RVA: 0x1D95F84 Offset: 0x1D91F84 VA: 0x1D95F84
	private WebOperation SendRequest(bool redirecting, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1
	internal static Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func, int timeout, Action abort, Func<bool> aborted, CancellationToken cancellationToken) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1119928 Offset: 0x1115928 VA: 0x1119928
	|-HttpWebRequest.RunWithTimeout<int>
	|
	|-RVA: 0x1119A20 Offset: 0x1115A20 VA: 0x1119A20
	|-HttpWebRequest.RunWithTimeout<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(HttpWebRequest.<RunWithTimeoutWorker>d__241<T>))]
	// RVA: -1 Offset: -1
	private static Task<T> RunWithTimeoutWorker<T>(Task<T> workerTask, int timeout, Action abort, Func<bool> aborted, CancellationTokenSource cts) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1119B40 Offset: 0x1115B40 VA: 0x1119B40
	|-HttpWebRequest.RunWithTimeoutWorker<int>
	|
	|-RVA: 0x1119C70 Offset: 0x1115C70 VA: 0x1119C70
	|-HttpWebRequest.RunWithTimeoutWorker<object>
	|
	|-RVA: 0x1119DA0 Offset: 0x1115DA0 VA: 0x1119DA0
	|-HttpWebRequest.RunWithTimeoutWorker<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private Task<T> RunWithTimeout<T>(Func<CancellationToken, Task<T>> func) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1119660 Offset: 0x1115660 VA: 0x1119660
	|-HttpWebRequest.RunWithTimeout<object>
	|
	|-RVA: 0x11197B0 Offset: 0x11157B0 VA: 0x11197B0
	|-HttpWebRequest.RunWithTimeout<__Il2CppFullySharedGenericType>
	*/

	[AsyncStateMachine(typeof(HttpWebRequest.<MyGetResponseAsync>d__243))]
	// RVA: 0x1D961BC Offset: 0x1D921BC VA: 0x1D961BC
	private Task<HttpWebResponse> MyGetResponseAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(HttpWebRequest.<GetResponseFromData>d__244))]
	// RVA: 0x1D962EC Offset: 0x1D922EC VA: 0x1D962EC
	private Task<ValueTuple<HttpWebResponse, bool, bool, BufferOffsetSize, WebOperation>> GetResponseFromData(WebResponseStream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1D9643C Offset: 0x1D9243C VA: 0x1D9643C
	internal static Exception FlattenException(Exception e) { }

	// RVA: 0x1D964F8 Offset: 0x1D924F8 VA: 0x1D964F8
	private WebException GetWebException(Exception e) { }

	// RVA: 0x1D965A4 Offset: 0x1D925A4 VA: 0x1D965A4
	private static WebException GetWebException(Exception e, bool aborted) { }

	// RVA: 0x1D96744 Offset: 0x1D92744 VA: 0x1D96744
	internal static WebException CreateRequestAbortedException() { }

	// RVA: 0x1D96800 Offset: 0x1D92800 VA: 0x1D96800 Slot: 21
	public override IAsyncResult BeginGetResponse(AsyncCallback callback, object state) { }

	// RVA: 0x1D96970 Offset: 0x1D92970 VA: 0x1D96970 Slot: 22
	public override WebResponse EndGetResponse(IAsyncResult asyncResult) { }

	// RVA: 0x1D96A90 Offset: 0x1D92A90 VA: 0x1D96A90 Slot: 20
	public override WebResponse GetResponse() { }

	// RVA: 0x1D96B90 Offset: 0x1D92B90 VA: 0x1D96B90
	internal void set_FinishedReading(bool value) { }

	// RVA: 0x1D9657C Offset: 0x1D9257C VA: 0x1D9657C
	internal bool get_Aborted() { }

	// RVA: 0x1D96B98 Offset: 0x1D92B98 VA: 0x1D96B98 Slot: 24
	public override void Abort() { }

	// RVA: 0x1D96CB4 Offset: 0x1D92CB4 VA: 0x1D96CB4 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D96CEC Offset: 0x1D92CEC VA: 0x1D96CEC Slot: 7
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D95C8C Offset: 0x1D91C8C VA: 0x1D95C8C
	private void CheckRequestStarted() { }

	// RVA: 0x1D96D24 Offset: 0x1D92D24 VA: 0x1D96D24
	internal void DoContinueDelegate(int statusCode, WebHeaderCollection headers) { }

	// RVA: 0x1D96D40 Offset: 0x1D92D40 VA: 0x1D96D40
	private void RewriteRedirectToGet() { }

	// RVA: 0x1D96DC4 Offset: 0x1D92DC4 VA: 0x1D96DC4
	private bool Redirect(HttpStatusCode code, WebResponse response) { }

	// RVA: 0x1D97308 Offset: 0x1D93308 VA: 0x1D97308
	private string GetHeaders() { }

	// RVA: 0x1D97954 Offset: 0x1D93954 VA: 0x1D97954
	private void DoPreAuthenticate() { }

	// RVA: 0x1D97B50 Offset: 0x1D93B50 VA: 0x1D97B50
	internal byte[] GetRequestHeaders() { }

	// RVA: 0x1D97E90 Offset: 0x1D93E90 VA: 0x1D97E90
	private ValueTuple<WebOperation, bool> HandleNtlmAuth(WebResponseStream stream, HttpWebResponse response, BufferOffsetSize writeBuffer, CancellationToken cancellationToken) { }

	// RVA: 0x1D98128 Offset: 0x1D94128 VA: 0x1D98128
	private bool CheckAuthorization(WebResponse response, HttpStatusCode code) { }

	// RVA: 0x1D9845C Offset: 0x1D9445C VA: 0x1D9845C
	private ValueTuple<Task<BufferOffsetSize>, WebException> GetRewriteHandler(HttpWebResponse response, bool redirect) { }

	// RVA: 0x1D98654 Offset: 0x1D94654 VA: 0x1D98654
	private ValueTuple<bool, bool, Task<BufferOffsetSize>, WebException> CheckFinalStatus(HttpWebResponse response) { }

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private bool <RunWithTimeout>b__242_0<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1119650 Offset: 0x1115650 VA: 0x1119650
	|-HttpWebRequest.<RunWithTimeout>b__242_0<object>
	|
	|-RVA: 0x1119658 Offset: 0x1115658 VA: 0x1119658
	|-HttpWebRequest.<RunWithTimeout>b__242_0<__Il2CppFullySharedGenericType>
	*/

	[CompilerGenerated]
	[AsyncStateMachine(typeof(HttpWebRequest.<<GetRewriteHandler>b__271_0>d))]
	// RVA: 0x1D98B70 Offset: 0x1D94B70 VA: 0x1D98B70
	private Task<BufferOffsetSize> <GetRewriteHandler>b__271_0() { }

	[EditorBrowsable(1)]
	[Obsolete("This API supports the .NET Framework infrastructure and is not intended to be used directly from your code.", True)]
	// RVA: 0x1D98C88 Offset: 0x1D94C88 VA: 0x1D98C88
	public void .ctor() { }
}

// Namespace: System.Net
[Serializable]
public class HttpWebResponse : WebResponse, ISerializable, IDisposable // TypeDefIndex: 4260
{
	// Fields
	private Uri uri; // 0x20
	private WebHeaderCollection webHeaders; // 0x28
	private CookieCollection cookieCollection; // 0x30
	private string method; // 0x38
	private Version version; // 0x40
	private HttpStatusCode statusCode; // 0x48
	private string statusDescription; // 0x50
	private long contentLength; // 0x58
	private string contentType; // 0x60
	private CookieContainer cookie_container; // 0x68
	private bool disposed; // 0x70
	private Stream stream; // 0x78

	// Properties
	public override WebHeaderCollection Headers { get; }
	public override Uri ResponseUri { get; }
	public virtual HttpStatusCode StatusCode { get; }
	public virtual string StatusDescription { get; }

	// Methods

	// RVA: 0x1D9B180 Offset: 0x1D97180 VA: 0x1D9B180
	public void .ctor() { }

	// RVA: 0x1D9B188 Offset: 0x1D97188 VA: 0x1D9B188
	internal void .ctor(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers) { }

	// RVA: 0x1D9A7C8 Offset: 0x1D967C8 VA: 0x1D9A7C8
	internal void .ctor(Uri uri, string method, WebResponseStream stream, CookieContainer container) { }

	[Obsolete("Serialization is obsoleted for this type", False)]
	// RVA: 0x1D9B49C Offset: 0x1D9749C VA: 0x1D9B49C
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D9B89C Offset: 0x1D9789C VA: 0x1D9B89C Slot: 14
	public override WebHeaderCollection get_Headers() { }

	// RVA: 0x1D9B8A4 Offset: 0x1D978A4 VA: 0x1D9B8A4 Slot: 13
	public override Uri get_ResponseUri() { }

	// RVA: 0x1D9B930 Offset: 0x1D97930 VA: 0x1D9B930 Slot: 15
	public virtual HttpStatusCode get_StatusCode() { }

	// RVA: 0x1D9B938 Offset: 0x1D97938 VA: 0x1D9B938 Slot: 16
	public virtual string get_StatusDescription() { }

	// RVA: 0x1D9B950 Offset: 0x1D97950 VA: 0x1D9B950 Slot: 12
	public override Stream GetResponseStream() { }

	// RVA: 0x1D9B9F4 Offset: 0x1D979F4 VA: 0x1D9B9F4 Slot: 6
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D9BA00 Offset: 0x1D97A00 VA: 0x1D9BA00 Slot: 8
	protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x1D9BBC0 Offset: 0x1D97BC0 VA: 0x1D9BBC0 Slot: 9
	public override void Close() { }

	// RVA: 0x1D9BBF0 Offset: 0x1D97BF0 VA: 0x1D9BBF0 Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1D9BC00 Offset: 0x1D97C00 VA: 0x1D9BC00 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1D9B8BC Offset: 0x1D978BC VA: 0x1D9B8BC
	private void CheckDisposed() { }

	// RVA: 0x1D9B274 Offset: 0x1D97274 VA: 0x1D9B274
	private void FillCookies() { }
}

// Namespace: System.Net
public interface ICredentialPolicy // TypeDefIndex: 4261
{}

// Namespace: 
private enum MonoChunkParser.State // TypeDefIndex: 4262
{
	// Fields
	public int value__; // 0x0
	public const MonoChunkParser.State None = 0;
	public const MonoChunkParser.State PartialSize = 1;
	public const MonoChunkParser.State Body = 2;
	public const MonoChunkParser.State BodyFinished = 3;
	public const MonoChunkParser.State Trailer = 4;
}

// Namespace: 
private class MonoChunkParser.Chunk // TypeDefIndex: 4263
{
	// Fields
	public byte[] Bytes; // 0x10
	public int Offset; // 0x18

	// Methods

	// RVA: 0x1D9CAE8 Offset: 0x1D98AE8 VA: 0x1D9CAE8
	public void .ctor(byte[] chunk) { }

	// RVA: 0x1D9BFFC Offset: 0x1D97FFC VA: 0x1D9BFFC
	public int Read(byte[] buffer, int offset, int size) { }
}

// Namespace: System.Net
internal class MonoChunkParser // TypeDefIndex: 4264
{
	// Fields
	private WebHeaderCollection headers; // 0x10
	private int chunkSize; // 0x18
	private int chunkRead; // 0x1C
	private int totalWritten; // 0x20
	private MonoChunkParser.State state; // 0x24
	private StringBuilder saved; // 0x28
	private bool sawCR; // 0x30
	private bool gotit; // 0x31
	private int trailerState; // 0x34
	private ArrayList chunks; // 0x38

	// Properties
	public bool WantMore { get; }
	public bool DataAvailable { get; }
	public int ChunkLeft { get; }

	// Methods

	// RVA: 0x1D9BC14 Offset: 0x1D97C14 VA: 0x1D9BC14
	public void .ctor(WebHeaderCollection headers) { }

	// RVA: 0x1D9BCE4 Offset: 0x1D97CE4 VA: 0x1D9BCE4
	public int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1D9BCE8 Offset: 0x1D97CE8 VA: 0x1D9BCE8
	private int ReadFromChunks(byte[] buffer, int offset, int size) { }

	// RVA: 0x1D9C05C Offset: 0x1D9805C VA: 0x1D9C05C
	public void Write(byte[] buffer, int offset, int size) { }

	// RVA: 0x1D9C07C Offset: 0x1D9807C VA: 0x1D9C07C
	private void InternalWrite(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1D9C9B8 Offset: 0x1D989B8 VA: 0x1D9C9B8
	public bool get_WantMore() { }

	// RVA: 0x1D9C9DC Offset: 0x1D989DC VA: 0x1D9C9DC
	public bool get_DataAvailable() { }

	// RVA: 0x1D9CADC Offset: 0x1D98ADC VA: 0x1D9CADC
	public int get_ChunkLeft() { }

	// RVA: 0x1D9C4B0 Offset: 0x1D984B0 VA: 0x1D9C4B0
	private MonoChunkParser.State ReadBody(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1D9C1B8 Offset: 0x1D981B8 VA: 0x1D9C1B8
	private MonoChunkParser.State GetChunkSize(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1D9CB68 Offset: 0x1D98B68 VA: 0x1D9CB68
	private static string RemoveChunkExtension(string input) { }

	// RVA: 0x1D9C5F0 Offset: 0x1D985F0 VA: 0x1D9C5F0
	private MonoChunkParser.State ReadCRLF(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1D9C6F0 Offset: 0x1D986F0 VA: 0x1D9C6F0
	private MonoChunkParser.State ReadTrailer(byte[] buffer, ref int offset, int size) { }

	// RVA: 0x1D9CB18 Offset: 0x1D98B18 VA: 0x1D9CB18
	private static void ThrowProtocolViolation(string message) { }
}

// Namespace: 
[CompilerGenerated]
private struct MonoChunkStream.<ProcessReadAsync>d__7 : IAsyncStateMachine // TypeDefIndex: 4265
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public MonoChunkStream <>4__this; // 0x28
	public byte[] buffer; // 0x30
	public int offset; // 0x38
	public int size; // 0x3C
	private byte[] <moreBytes>5__2; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48

	// Methods

	// RVA: 0x1D9D09C Offset: 0x1D9909C VA: 0x1D9D09C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1D9D4F8 Offset: 0x1D994F8 VA: 0x1D9D4F8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct MonoChunkStream.<FinishReading>d__8 : IAsyncStateMachine // TypeDefIndex: 4266
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public MonoChunkStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30
	private byte[] <buffer>5__2; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__2; // 0x48

	// Methods

	// RVA: 0x1D9D574 Offset: 0x1D99574 VA: 0x1D9D574 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1D9DA1C Offset: 0x1D99A1C VA: 0x1D9DA1C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class MonoChunkStream : WebReadStream // TypeDefIndex: 4267
{
	// Fields
	[CompilerGenerated]
	private readonly WebHeaderCollection <Headers>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly MonoChunkParser <Decoder>k__BackingField; // 0x48

	// Properties
	protected MonoChunkParser Decoder { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D9CBB0 Offset: 0x1D98BB0 VA: 0x1D9CBB0
	protected MonoChunkParser get_Decoder() { }

	// RVA: 0x1D9CBB8 Offset: 0x1D98BB8 VA: 0x1D9CBB8
	public void .ctor(WebOperation operation, Stream innerStream, WebHeaderCollection headers) { }

	[AsyncStateMachine(typeof(MonoChunkStream.<ProcessReadAsync>d__7))]
	// RVA: 0x1D9CCDC Offset: 0x1D98CDC VA: 0x1D9CCDC Slot: 38
	protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(MonoChunkStream.<FinishReading>d__8))]
	// RVA: 0x1D9CE40 Offset: 0x1D98E40 VA: 0x1D9CE40 Slot: 39
	internal override Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x1D9CF3C Offset: 0x1D98F3C VA: 0x1D9CF3C
	private static void ThrowExpectingChunkTrailer() { }

	[CompilerGenerated]
	[DebuggerHidden]
	// RVA: 0x1D9CF94 Offset: 0x1D98F94 VA: 0x1D9CF94
	private Task <>n__0(CancellationToken cancellationToken) { }
}

// Namespace: System.Net
internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 4268
{
	// Fields
	private IAuthenticationModule authObject; // 0x10

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1D9DA84 Offset: 0x1D99A84 VA: 0x1D9DA84
	public void .ctor() { }

	// RVA: 0x1D9DAF0 Offset: 0x1D99AF0 VA: 0x1D9DAF0 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1D9DBC0 Offset: 0x1D99BC0 VA: 0x1D9DBC0 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1D9DBC8 Offset: 0x1D99BC8 VA: 0x1D9DBC8 Slot: 6
	public string get_AuthenticationType() { }
}

// Namespace: System.Net
public class ServicePoint // TypeDefIndex: 4269
{
	// Fields
	private readonly Uri uri; // 0x10
	private DateTime lastDnsResolve; // 0x18
	private Version protocolVersion; // 0x20
	private IPHostEntry host; // 0x28
	private bool usesProxy; // 0x30
	private bool sendContinue; // 0x31
	private bool useConnect; // 0x32
	private object hostE; // 0x38
	private bool useNagle; // 0x40
	private BindIPEndPoint endPointCallback; // 0x48
	private bool tcp_keepalive; // 0x50
	private int tcp_keepalive_time; // 0x54
	private int tcp_keepalive_interval; // 0x58
	private bool disposed; // 0x5C
	private int connectionLeaseTimeout; // 0x60
	private int receiveBufferSize; // 0x64
	[CompilerGenerated]
	private readonly ServicePointManager.SPKey <Key>k__BackingField; // 0x68
	[CompilerGenerated]
	private ServicePointScheduler <Scheduler>k__BackingField; // 0x70
	private int connectionLimit; // 0x78
	private int maxIdleTime; // 0x7C
	private object m_ServerCertificateOrBytes; // 0x80
	private object m_ClientCertificateOrBytes; // 0x88

	// Properties
	internal ServicePointManager.SPKey Key { get; }
	private ServicePointScheduler Scheduler { get; set; }
	public Uri Address { get; }
	public int ConnectionLimit { get; }
	public virtual Version ProtocolVersion { get; }
	public bool Expect100Continue { set; }
	public bool UseNagleAlgorithm { get; set; }
	internal bool SendContinue { get; set; }
	internal bool UsesProxy { get; set; }
	internal bool UseConnect { get; set; }
	private bool HasTimedOut { get; }
	internal IPHostEntry HostEntry { get; }

	// Methods

	// RVA: 0x1D9DC08 Offset: 0x1D99C08 VA: 0x1D9DC08
	internal void .ctor(ServicePointManager.SPKey key, Uri uri, int connectionLimit, int maxIdleTime) { }

	[CompilerGenerated]
	// RVA: 0x1D9DF14 Offset: 0x1D99F14 VA: 0x1D9DF14
	internal ServicePointManager.SPKey get_Key() { }

	[CompilerGenerated]
	// RVA: 0x1D9DF1C Offset: 0x1D99F1C VA: 0x1D9DF1C
	private ServicePointScheduler get_Scheduler() { }

	[CompilerGenerated]
	// RVA: 0x1D9DF24 Offset: 0x1D99F24 VA: 0x1D9DF24
	private void set_Scheduler(ServicePointScheduler value) { }

	// RVA: 0x1D9DF2C Offset: 0x1D99F2C VA: 0x1D9DF2C
	public Uri get_Address() { }

	// RVA: 0x1D9DF34 Offset: 0x1D99F34 VA: 0x1D9DF34
	public int get_ConnectionLimit() { }

	// RVA: 0x1D9DF3C Offset: 0x1D99F3C VA: 0x1D9DF3C Slot: 4
	public virtual Version get_ProtocolVersion() { }

	// RVA: 0x1D9DF44 Offset: 0x1D99F44 VA: 0x1D9DF44
	public void set_Expect100Continue(bool value) { }

	// RVA: 0x1D9DF4C Offset: 0x1D99F4C VA: 0x1D9DF4C
	public bool get_UseNagleAlgorithm() { }

	// RVA: 0x1D9DF54 Offset: 0x1D99F54 VA: 0x1D9DF54
	public void set_UseNagleAlgorithm(bool value) { }

	// RVA: 0x1D9DF5C Offset: 0x1D99F5C VA: 0x1D9DF5C
	internal bool get_SendContinue() { }

	// RVA: 0x1D9DFF8 Offset: 0x1D99FF8 VA: 0x1D9DFF8
	internal void set_SendContinue(bool value) { }

	// RVA: 0x1D9E000 Offset: 0x1D9A000 VA: 0x1D9E000
	public void SetTcpKeepAlive(bool enabled, int keepAliveTime, int keepAliveInterval) { }

	// RVA: 0x1D9E0B0 Offset: 0x1D9A0B0 VA: 0x1D9E0B0
	internal void KeepAliveSetup(Socket socket) { }

	// RVA: 0x1D9E164 Offset: 0x1D9A164 VA: 0x1D9E164
	private static void PutBytes(byte[] bytes, uint v, int offset) { }

	// RVA: 0x1D9E1E4 Offset: 0x1D9A1E4 VA: 0x1D9E1E4
	internal bool get_UsesProxy() { }

	// RVA: 0x1D9E1EC Offset: 0x1D9A1EC VA: 0x1D9E1EC
	internal void set_UsesProxy(bool value) { }

	// RVA: 0x1D9E1F4 Offset: 0x1D9A1F4 VA: 0x1D9E1F4
	internal bool get_UseConnect() { }

	// RVA: 0x1D9E1FC Offset: 0x1D9A1FC VA: 0x1D9E1FC
	internal void set_UseConnect(bool value) { }

	// RVA: 0x1D9E204 Offset: 0x1D9A204 VA: 0x1D9E204
	private bool get_HasTimedOut() { }

	// RVA: 0x1D9E330 Offset: 0x1D9A330 VA: 0x1D9E330
	internal IPHostEntry get_HostEntry() { }

	// RVA: 0x1D9E6FC Offset: 0x1D9A6FC VA: 0x1D9E6FC
	internal void SetVersion(Version version) { }

	// RVA: 0x1D9E704 Offset: 0x1D9A704 VA: 0x1D9E704
	internal void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x1D9E968 Offset: 0x1D9A968 VA: 0x1D9E968
	internal void FreeServicePoint() { }

	// RVA: 0x1D9E97C Offset: 0x1D9A97C VA: 0x1D9E97C
	internal void UpdateServerCertificate(X509Certificate certificate) { }

	// RVA: 0x1D9E9B8 Offset: 0x1D9A9B8 VA: 0x1D9E9B8
	internal void UpdateClientCertificate(X509Certificate certificate) { }

	// RVA: 0x1D9E9F4 Offset: 0x1D9A9F4 VA: 0x1D9E9F4
	internal bool CallEndPointDelegate(Socket sock, IPEndPoint remote) { }
}

// Namespace: 
internal class ServicePointManager.SPKey // TypeDefIndex: 4270
{
	// Fields
	private Uri uri; // 0x10
	private Uri proxy; // 0x18
	private bool use_connect; // 0x20

	// Properties
	public bool UsesProxy { get; }

	// Methods

	// RVA: 0x1D9F4F4 Offset: 0x1D9B4F4 VA: 0x1D9F4F4
	public void .ctor(Uri uri, Uri proxy, bool use_connect) { }

	// RVA: 0x1D9F5E4 Offset: 0x1D9B5E4 VA: 0x1D9F5E4
	public bool get_UsesProxy() { }

	// RVA: 0x1D9F644 Offset: 0x1D9B644 VA: 0x1D9F644 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1D9F70C Offset: 0x1D9B70C VA: 0x1D9F70C Slot: 0
	public override bool Equals(object obj) { }
}

// Namespace: System.Net
public class ServicePointManager // TypeDefIndex: 4271
{
	// Fields
	private static ConcurrentDictionary<ServicePointManager.SPKey, ServicePoint> servicePoints; // 0x0
	private static ICertificatePolicy policy; // 0x8
	private static int defaultConnectionLimit; // 0x10
	private static int maxServicePointIdleTime; // 0x14
	private static int maxServicePoints; // 0x18
	private static int dnsRefreshTimeout; // 0x1C
	private static bool _checkCRL; // 0x20
	private static SecurityProtocolType _securityProtocol; // 0x24
	private static bool expectContinue; // 0x28
	private static bool useNagle; // 0x29
	private static ServerCertValidationCallback server_cert_cb; // 0x30
	private static bool tcp_keepalive; // 0x38
	private static int tcp_keepalive_time; // 0x3C
	private static int tcp_keepalive_interval; // 0x40

	// Properties
	[MonoTODO("CRL checks not implemented")]
	public static bool CheckCertificateRevocationList { get; }
	public static int DnsRefreshTimeout { get; }
	public static SecurityProtocolType SecurityProtocol { get; }
	internal static ServerCertValidationCallback ServerCertValidationCallback { get; }
	public static RemoteCertificateValidationCallback ServerCertificateValidationCallback { get; }

	// Methods

	// RVA: 0x1D9EB98 Offset: 0x1D9AB98 VA: 0x1D9EB98
	private static void .cctor() { }

	// RVA: 0x1D9EC58 Offset: 0x1D9AC58 VA: 0x1D9EC58
	internal static ICertificatePolicy GetLegacyCertificatePolicy() { }

	// RVA: 0x1D9ECB0 Offset: 0x1D9ACB0 VA: 0x1D9ECB0
	public static bool get_CheckCertificateRevocationList() { }

	// RVA: 0x1D9ED08 Offset: 0x1D9AD08 VA: 0x1D9ED08
	public static int get_DnsRefreshTimeout() { }

	// RVA: 0x1D9ED60 Offset: 0x1D9AD60 VA: 0x1D9ED60
	public static SecurityProtocolType get_SecurityProtocol() { }

	// RVA: 0x1D9EDB8 Offset: 0x1D9ADB8 VA: 0x1D9EDB8
	internal static ServerCertValidationCallback get_ServerCertValidationCallback() { }

	// RVA: 0x1D9EE10 Offset: 0x1D9AE10 VA: 0x1D9EE10
	public static RemoteCertificateValidationCallback get_ServerCertificateValidationCallback() { }

	// RVA: 0x1D9EE98 Offset: 0x1D9AE98 VA: 0x1D9EE98
	public static ServicePoint FindServicePoint(Uri address, IWebProxy proxy) { }

	// RVA: 0x1D9F54C Offset: 0x1D9B54C VA: 0x1D9F54C
	internal static void RemoveServicePoint(ServicePoint sp) { }
}

// Namespace: 
private class ServicePointScheduler.ConnectionGroup // TypeDefIndex: 4272
{
	// Fields
	[CompilerGenerated]
	private readonly ServicePointScheduler <Scheduler>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x18
	private static int nextId; // 0x0
	public readonly int ID; // 0x20
	private LinkedList<WebConnection> connections; // 0x28
	private LinkedList<WebOperation> queue; // 0x30

	// Properties
	public ServicePointScheduler Scheduler { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1DA111C Offset: 0x1D9D11C VA: 0x1DA111C
	public ServicePointScheduler get_Scheduler() { }

	// RVA: 0x1D9F8C4 Offset: 0x1D9B8C4 VA: 0x1D9F8C4
	public void .ctor(ServicePointScheduler scheduler, string name) { }

	// RVA: 0x1D9FFBC Offset: 0x1D9BFBC VA: 0x1D9FFBC
	public bool IsEmpty() { }

	// RVA: 0x1DA06DC Offset: 0x1D9C6DC VA: 0x1DA06DC
	public void RemoveConnection(WebConnection connection) { }

	// RVA: 0x1DA0830 Offset: 0x1D9C830 VA: 0x1DA0830
	public void Cleanup() { }

	// RVA: 0x1DA0F74 Offset: 0x1D9CF74 VA: 0x1DA0F74
	public void EnqueueOperation(WebOperation operation) { }

	// RVA: 0x1DA0AF8 Offset: 0x1D9CAF8 VA: 0x1DA0AF8
	public WebOperation GetNextOperation() { }

	// RVA: 0x1DA118C Offset: 0x1D9D18C VA: 0x1DA118C
	public WebConnection FindIdleConnection(WebOperation operation) { }

	// RVA: 0x1DA091C Offset: 0x1D9C91C VA: 0x1DA091C
	public ValueTuple<WebConnection, bool> CreateOrReuseConnection(WebOperation operation, bool force) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class ServicePointScheduler.AsyncManualResetEvent.<>c // TypeDefIndex: 4273
{
	// Fields
	public static readonly ServicePointScheduler.AsyncManualResetEvent.<>c <>9; // 0x0
	public static Func<object, bool> <>9__4_0; // 0x8

	// Methods

	// RVA: 0x1DA1B58 Offset: 0x1D9DB58 VA: 0x1DA1B58
	private static void .cctor() { }

	// RVA: 0x1DA1BC0 Offset: 0x1D9DBC0 VA: 0x1DA1BC0
	public void .ctor() { }

	// RVA: 0x1DA1BC8 Offset: 0x1D9DBC8 VA: 0x1DA1BC8
	internal bool <Set>b__4_0(object s) { }
}

// Namespace: 
private class ServicePointScheduler.AsyncManualResetEvent // TypeDefIndex: 4274
{
	// Fields
	private TaskCompletionSource<bool> m_tcs; // 0x10

	// Methods

	// RVA: 0x1DA1B04 Offset: 0x1D9DB04 VA: 0x1DA1B04
	public Task<bool> WaitAsync(int millisecondTimeout) { }

	// RVA: 0x1D9FAC0 Offset: 0x1D9BAC0 VA: 0x1D9FAC0
	public void Set() { }

	// RVA: 0x1DA01AC Offset: 0x1D9C1AC VA: 0x1DA01AC
	public void Reset() { }

	// RVA: 0x1D9F818 Offset: 0x1D9B818 VA: 0x1D9F818
	public void .ctor(bool state) { }
}

// Namespace: 
[CompilerGenerated]
private struct ServicePointScheduler.<RunScheduler>d__32 : IAsyncStateMachine // TypeDefIndex: 4275
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public ServicePointScheduler <>4__this; // 0x20
	private ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>[] <operationArray>5__2; // 0x28
	private ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>[] <idleArray>5__3; // 0x30
	private List<Task> <taskList>5__4; // 0x38
	private Task<bool> <schedulerTask>5__5; // 0x40
	private bool <finalCleanup>5__6; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x50

	// Methods

	// RVA: 0x1DA1C64 Offset: 0x1D9DC64 VA: 0x1DA1C64 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DA2854 Offset: 0x1D9E854 VA: 0x1DA2854 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct ServicePointScheduler.<WaitAsync>d__46 : IAsyncStateMachine // TypeDefIndex: 4276
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public int millisecondTimeout; // 0x20
	public Task workerTask; // 0x28
	private CancellationTokenSource <cts>5__2; // 0x30
	private Task <timeoutTask>5__3; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x40

	// Methods

	// RVA: 0x1DA28BC Offset: 0x1D9E8BC VA: 0x1DA28BC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DA2DF8 Offset: 0x1D9EDF8 VA: 0x1DA2DF8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class ServicePointScheduler // TypeDefIndex: 4277
{
	// Fields
	[CompilerGenerated]
	private ServicePoint <ServicePoint>k__BackingField; // 0x10
	private int running; // 0x18
	private int maxIdleTime; // 0x1C
	private ServicePointScheduler.AsyncManualResetEvent schedulerEvent; // 0x20
	private ServicePointScheduler.ConnectionGroup defaultGroup; // 0x28
	private Dictionary<string, ServicePointScheduler.ConnectionGroup> groups; // 0x30
	private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebOperation>> operations; // 0x38
	private LinkedList<ValueTuple<ServicePointScheduler.ConnectionGroup, WebConnection, Task>> idleConnections; // 0x40
	private int currentConnections; // 0x48
	private int connectionLimit; // 0x4C
	private DateTime idleSince; // 0x50
	private static int nextId; // 0x0
	public readonly int ID; // 0x58

	// Properties
	private ServicePoint ServicePoint { get; set; }
	public int MaxIdleTime { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D9F800 Offset: 0x1D9B800 VA: 0x1D9F800
	private ServicePoint get_ServicePoint() { }

	[CompilerGenerated]
	// RVA: 0x1D9F808 Offset: 0x1D9B808 VA: 0x1D9F808
	private void set_ServicePoint(ServicePoint value) { }

	// RVA: 0x1D9F810 Offset: 0x1D9B810 VA: 0x1D9F810
	public int get_MaxIdleTime() { }

	// RVA: 0x1D9DD10 Offset: 0x1D99D10 VA: 0x1D9DD10
	public void .ctor(ServicePoint servicePoint, int connectionLimit, int maxIdleTime) { }

	// RVA: 0x1D9F9FC Offset: 0x1D9B9FC VA: 0x1D9F9FC
	public void Run() { }

	[AsyncStateMachine(typeof(ServicePointScheduler.<RunScheduler>d__32))]
	// RVA: 0x1D9FCF4 Offset: 0x1D9BCF4 VA: 0x1D9FCF4
	private Task RunScheduler() { }

	// RVA: 0x1D9FDDC Offset: 0x1D9BDDC VA: 0x1D9FDDC
	private void Cleanup() { }

	// RVA: 0x1DA0030 Offset: 0x1D9C030 VA: 0x1DA0030
	private void RunSchedulerIteration() { }

	// RVA: 0x1DA0348 Offset: 0x1D9C348 VA: 0x1DA0348
	private bool OperationCompleted(ServicePointScheduler.ConnectionGroup group, WebOperation operation) { }

	// RVA: 0x1DA0AC0 Offset: 0x1D9CAC0 VA: 0x1DA0AC0
	private void CloseIdleConnection(ServicePointScheduler.ConnectionGroup group, WebConnection connection) { }

	// RVA: 0x1DA0268 Offset: 0x1D9C268 VA: 0x1DA0268
	private bool SchedulerIteration(ServicePointScheduler.ConnectionGroup group) { }

	// RVA: 0x1DA0BE0 Offset: 0x1D9CBE0 VA: 0x1DA0BE0
	private void RemoveOperation(WebOperation operation) { }

	// RVA: 0x1DA0764 Offset: 0x1D9C764 VA: 0x1DA0764
	private void RemoveIdleConnection(WebConnection connection) { }

	// RVA: 0x1DA0CAC Offset: 0x1D9CCAC VA: 0x1DA0CAC
	private void FinalCleanup() { }

	// RVA: 0x1D9E87C Offset: 0x1D9A87C VA: 0x1D9E87C
	public void SendRequest(WebOperation operation, string groupName) { }

	// RVA: 0x1DA0D74 Offset: 0x1D9CD74 VA: 0x1DA0D74
	private ServicePointScheduler.ConnectionGroup GetConnectionGroup(string name) { }

	// RVA: 0x1DA0FCC Offset: 0x1D9CFCC VA: 0x1DA0FCC
	private void OnConnectionCreated(WebConnection connection) { }

	// RVA: 0x1DA0FD8 Offset: 0x1D9CFD8 VA: 0x1DA0FD8
	private void OnConnectionClosed(WebConnection connection) { }

	[AsyncStateMachine(typeof(ServicePointScheduler.<WaitAsync>d__46))]
	// RVA: 0x1DA0FF4 Offset: 0x1D9CFF4 VA: 0x1DA0FF4
	public static Task<bool> WaitAsync(Task workerTask, int millisecondTimeout) { }

	[CompilerGenerated]
	// RVA: 0x1DA1118 Offset: 0x1D9D118 VA: 0x1DA1118
	private Task <Run>b__31_0() { }
}

// Namespace: 
internal enum WebCompletionSource.Status<T> // TypeDefIndex: 4278
{
	// Fields
	public int value__; // 0x0
	public const WebCompletionSource.Status<T> Running = 0;
	public const WebCompletionSource.Status<T> Completed = 1;
	public const WebCompletionSource.Status<T> Canceled = 2;
	public const WebCompletionSource.Status<T> Faulted = 3;
}

// Namespace: 
internal class WebCompletionSource.Result<T> // TypeDefIndex: 4279
{
	// Fields
	[CompilerGenerated]
	private readonly WebCompletionSource.Status<T> <Status>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly ExceptionDispatchInfo <Error>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly T <Argument>k__BackingField; // 0x0

	// Properties
	public WebCompletionSource.Status<T> Status { get; }
	public bool Success { get; }
	public ExceptionDispatchInfo Error { get; }
	public T Argument { get; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public WebCompletionSource.Status<T> get_Status() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1454F90 Offset: 0x1450F90 VA: 0x1454F90
	|-WebCompletionSource.Result<ValueTuple<bool, object>>.get_Status
	|
	|-RVA: 0x1455034 Offset: 0x1451034 VA: 0x1455034
	|-WebCompletionSource.Result<object>.get_Status
	|
	|-RVA: 0x14550CC Offset: 0x14510CC VA: 0x14550CC
	|-WebCompletionSource.Result<__Il2CppFullySharedGenericType>.get_Status
	*/

	// RVA: -1 Offset: -1
	public bool get_Success() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1454F98 Offset: 0x1450F98 VA: 0x1454F98
	|-WebCompletionSource.Result<ValueTuple<bool, object>>.get_Success
	|
	|-RVA: 0x145503C Offset: 0x145103C VA: 0x145503C
	|-WebCompletionSource.Result<object>.get_Success
	|
	|-RVA: 0x14550F0 Offset: 0x14510F0 VA: 0x14550F0
	|-WebCompletionSource.Result<__Il2CppFullySharedGenericType>.get_Success
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public ExceptionDispatchInfo get_Error() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1454FA8 Offset: 0x1450FA8 VA: 0x1454FA8
	|-WebCompletionSource.Result<ValueTuple<bool, object>>.get_Error
	|
	|-RVA: 0x145504C Offset: 0x145104C VA: 0x145504C
	|-WebCompletionSource.Result<object>.get_Error
	|
	|-RVA: 0x1455118 Offset: 0x1451118 VA: 0x1455118
	|-WebCompletionSource.Result<__Il2CppFullySharedGenericType>.get_Error
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public T get_Argument() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1454FB0 Offset: 0x1450FB0 VA: 0x1454FB0
	|-WebCompletionSource.Result<ValueTuple<bool, object>>.get_Argument
	|
	|-RVA: 0x1455054 Offset: 0x1451054 VA: 0x1455054
	|-WebCompletionSource.Result<object>.get_Argument
	|
	|-RVA: 0x1455140 Offset: 0x1451140 VA: 0x1455140
	|-WebCompletionSource.Result<__Il2CppFullySharedGenericType>.get_Argument
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1454FBC Offset: 0x1450FBC VA: 0x1454FBC
	|-WebCompletionSource.Result<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x145505C Offset: 0x145105C VA: 0x145505C
	|-WebCompletionSource.Result<object>..ctor
	|
	|-RVA: 0x1455184 Offset: 0x1451184 VA: 0x1455184
	|-WebCompletionSource.Result<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(WebCompletionSource.Status<T> state, ExceptionDispatchInfo error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1454FFC Offset: 0x1450FFC VA: 0x1454FFC
	|-WebCompletionSource.Result<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x1455094 Offset: 0x1451094 VA: 0x1455094
	|-WebCompletionSource.Result<object>..ctor
	|
	|-RVA: 0x1455270 Offset: 0x1451270 VA: 0x1455270
	|-WebCompletionSource.Result<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
[CompilerGenerated]
private struct WebCompletionSource.<WaitForCompletion>d__15<T> : IAsyncStateMachine // TypeDefIndex: 4280
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<T> <>t__builder; // 0x0
	public WebCompletionSource<T> <>4__this; // 0x0
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebCompletionSource.Result<T>> <>u__1; // 0x0

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11712C8 Offset: 0x116D2C8 VA: 0x11712C8
	|-WebCompletionSource.<WaitForCompletion>d__15<ValueTuple<bool, object>>.MoveNext
	|
	|-RVA: 0x1171718 Offset: 0x116D718 VA: 0x1171718
	|-WebCompletionSource.<WaitForCompletion>d__15<object>.MoveNext
	|
	|-RVA: 0x1171B64 Offset: 0x116DB64 VA: 0x1171B64
	|-WebCompletionSource.<WaitForCompletion>d__15<__Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1171694 Offset: 0x116D694 VA: 0x1171694
	|-WebCompletionSource.<WaitForCompletion>d__15<ValueTuple<bool, object>>.SetStateMachine
	|
	|-RVA: 0x1171AE0 Offset: 0x116DAE0 VA: 0x1171AE0
	|-WebCompletionSource.<WaitForCompletion>d__15<object>.SetStateMachine
	|
	|-RVA: 0x11722C8 Offset: 0x116E2C8 VA: 0x11722C8
	|-WebCompletionSource.<WaitForCompletion>d__15<__Il2CppFullySharedGenericType>.SetStateMachine
	*/
}

// Namespace: System.Net
internal class WebCompletionSource<T> // TypeDefIndex: 4281
{
	// Fields
	private TaskCompletionSource<WebCompletionSource.Result<T>> completion; // 0x0
	private WebCompletionSource.Result<T> currentResult; // 0x0

	// Properties
	internal WebCompletionSource.Result<T> CurrentResult { get; }
	internal Task Task { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(bool runAsync = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153D9C4 Offset: 0x15399C4 VA: 0x153D9C4
	|-WebCompletionSource<ValueTuple<bool, object>>..ctor
	|
	|-RVA: 0x153DF00 Offset: 0x1539F00 VA: 0x153DF00
	|-WebCompletionSource<object>..ctor
	|
	|-RVA: 0x153E434 Offset: 0x153A434 VA: 0x153E434
	|-WebCompletionSource<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	internal WebCompletionSource.Result<T> get_CurrentResult() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153DA44 Offset: 0x1539A44 VA: 0x153DA44
	|-WebCompletionSource<ValueTuple<bool, object>>.get_CurrentResult
	|
	|-RVA: 0x153DF80 Offset: 0x1539F80 VA: 0x153DF80
	|-WebCompletionSource<object>.get_CurrentResult
	|
	|-RVA: 0x153E4B8 Offset: 0x153A4B8 VA: 0x153E4B8
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.get_CurrentResult
	*/

	// RVA: -1 Offset: -1
	internal Task get_Task() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153DA4C Offset: 0x1539A4C VA: 0x153DA4C
	|-WebCompletionSource<ValueTuple<bool, object>>.get_Task
	|
	|-RVA: 0x153DF88 Offset: 0x1539F88 VA: 0x153DF88
	|-WebCompletionSource<object>.get_Task
	|
	|-RVA: 0x153E4C0 Offset: 0x153A4C0 VA: 0x153E4C0
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.get_Task
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCompleted(T argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153DA64 Offset: 0x1539A64 VA: 0x153DA64
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCompleted
	|
	|-RVA: 0x153DFA0 Offset: 0x1539FA0 VA: 0x153DFA0
	|-WebCompletionSource<object>.TrySetCompleted
	|
	|-RVA: 0x153E4E4 Offset: 0x153A4E4 VA: 0x153E4E4
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153DB1C Offset: 0x1539B1C VA: 0x153DB1C
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCompleted
	|
	|-RVA: 0x153E050 Offset: 0x153A050 VA: 0x153E050
	|-WebCompletionSource<object>.TrySetCompleted
	|
	|-RVA: 0x153E638 Offset: 0x153A638 VA: 0x153E638
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCompleted
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153DBC0 Offset: 0x1539BC0 VA: 0x153DBC0
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCanceled
	|
	|-RVA: 0x153E0F4 Offset: 0x153A0F4 VA: 0x153E0F4
	|-WebCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0x153E700 Offset: 0x153A700 VA: 0x153E700
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetCanceled(OperationCanceledException error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153DC34 Offset: 0x1539C34 VA: 0x153DC34
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetCanceled
	|
	|-RVA: 0x153E168 Offset: 0x153A168 VA: 0x153E168
	|-WebCompletionSource<object>.TrySetCanceled
	|
	|-RVA: 0x153E778 Offset: 0x153A778 VA: 0x153E778
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetCanceled
	*/

	// RVA: -1 Offset: -1
	public bool TrySetException(Exception error) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153DCF4 Offset: 0x1539CF4 VA: 0x153DCF4
	|-WebCompletionSource<ValueTuple<bool, object>>.TrySetException
	|
	|-RVA: 0x153E228 Offset: 0x153A228 VA: 0x153E228
	|-WebCompletionSource<object>.TrySetException
	|
	|-RVA: 0x153E858 Offset: 0x153A858 VA: 0x153E858
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.TrySetException
	*/

	// RVA: -1 Offset: -1
	public void ThrowOnError() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153DDB4 Offset: 0x1539DB4 VA: 0x153DDB4
	|-WebCompletionSource<ValueTuple<bool, object>>.ThrowOnError
	|
	|-RVA: 0x153E2E8 Offset: 0x153A2E8 VA: 0x153E2E8
	|-WebCompletionSource<object>.ThrowOnError
	|
	|-RVA: 0x153E938 Offset: 0x153A938 VA: 0x153E938
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.ThrowOnError
	*/

	[AsyncStateMachine(typeof(WebCompletionSource.<WaitForCompletion>d__15<T>))]
	// RVA: -1 Offset: -1
	public Task<T> WaitForCompletion() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x153DE2C Offset: 0x1539E2C VA: 0x153DE2C
	|-WebCompletionSource<ValueTuple<bool, object>>.WaitForCompletion
	|
	|-RVA: 0x153E360 Offset: 0x153A360 VA: 0x153E360
	|-WebCompletionSource<object>.WaitForCompletion
	|
	|-RVA: 0x153E9F0 Offset: 0x153A9F0 VA: 0x153E9F0
	|-WebCompletionSource<__Il2CppFullySharedGenericType>.WaitForCompletion
	*/
}

// Namespace: System.Net
internal class WebCompletionSource : WebCompletionSource<object> // TypeDefIndex: 4282
{
	// Methods

	// RVA: 0x1DA2E74 Offset: 0x1D9EE74 VA: 0x1DA2E74
	public void .ctor() { }
}

// Namespace: System.Net
internal enum ReadState // TypeDefIndex: 4283
{
	// Fields
	public int value__; // 0x0
	public const ReadState None = 0;
	public const ReadState Status = 1;
	public const ReadState Headers = 2;
	public const ReadState Content = 3;
	public const ReadState Aborted = 4;
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class WebConnection.<>c // TypeDefIndex: 4284
{
	// Fields
	public static readonly WebConnection.<>c <>9; // 0x0
	public static Func<IPEndPoint, AsyncCallback, object, IAsyncResult> <>9__16_0; // 0x8
	public static Action<IAsyncResult> <>9__16_1; // 0x10

	// Methods

	// RVA: 0x1DA4220 Offset: 0x1DA0220 VA: 0x1DA4220
	private static void .cctor() { }

	// RVA: 0x1DA4288 Offset: 0x1DA0288 VA: 0x1DA4288
	public void .ctor() { }

	// RVA: 0x1DA4290 Offset: 0x1DA0290 VA: 0x1DA4290
	internal IAsyncResult <Connect>b__16_0(IPEndPoint targetEndPoint, AsyncCallback callback, object state) { }

	// RVA: 0x1DA4330 Offset: 0x1DA0330 VA: 0x1DA4330
	internal void <Connect>b__16_1(IAsyncResult asyncResult) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebConnection.<Connect>d__16 : IAsyncStateMachine // TypeDefIndex: 4285
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebConnection <>4__this; // 0x20
	public WebOperation operation; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private Exception <connectException>5__2; // 0x38
	private IPAddress[] <>7__wrap2; // 0x40
	private int <>7__wrap3; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x50

	// Methods

	// RVA: 0x1DA4424 Offset: 0x1DA0424 VA: 0x1DA4424 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DA4E50 Offset: 0x1DA0E50 VA: 0x1DA4E50 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebConnection.<CreateStream>d__18 : IAsyncStateMachine // TypeDefIndex: 4286
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public WebConnection <>4__this; // 0x20
	public WebOperation operation; // 0x28
	public bool reused; // 0x30
	public CancellationToken cancellationToken; // 0x38
	private NetworkStream <stream>5__2; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Stream> <>u__2; // 0x58

	// Methods

	// RVA: 0x1DA4EB8 Offset: 0x1DA0EB8 VA: 0x1DA4EB8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DA5750 Offset: 0x1DA1750 VA: 0x1DA5750 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebConnection.<InitConnection>d__19 : IAsyncStateMachine // TypeDefIndex: 4287
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<WebRequestStream> <>t__builder; // 0x8
	public WebOperation operation; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public WebConnection <>4__this; // 0x30
	private bool <reused>5__2; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<bool> <>u__2; // 0x50

	// Methods

	// RVA: 0x1DA57CC Offset: 0x1DA17CC VA: 0x1DA57CC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DA5F54 Offset: 0x1DA1F54 VA: 0x1DA5F54 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class WebConnection : IDisposable // TypeDefIndex: 4288
{
	// Fields
	private NetworkCredential ntlm_credentials; // 0x10
	private bool ntlm_authenticated; // 0x18
	private bool unsafe_sharing; // 0x19
	private Stream networkStream; // 0x20
	private Socket socket; // 0x28
	private MonoTlsStream monoTlsStream; // 0x30
	private WebConnectionTunnel tunnel; // 0x38
	private int disposed; // 0x40
	[CompilerGenerated]
	private readonly ServicePoint <ServicePoint>k__BackingField; // 0x48
	private DateTime idleSince; // 0x50
	private WebOperation currentOperation; // 0x58

	// Properties
	public ServicePoint ServicePoint { get; }
	public bool Closed { get; }
	public DateTime IdleSince { get; }
	internal bool NtlmAuthenticated { get; set; }
	internal NetworkCredential NtlmCredential { get; set; }
	internal bool UnsafeAuthenticatedConnectionSharing { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1DA2EC0 Offset: 0x1D9EEC0 VA: 0x1DA2EC0
	public ServicePoint get_ServicePoint() { }

	// RVA: 0x1DA1AD4 Offset: 0x1D9DAD4 VA: 0x1DA1AD4
	public void .ctor(ServicePoint sPoint) { }

	// RVA: 0x1DA2EC8 Offset: 0x1D9EEC8 VA: 0x1DA2EC8
	private bool CanReuse() { }

	// RVA: 0x1DA2EF8 Offset: 0x1D9EEF8 VA: 0x1DA2EF8
	private bool CheckReusable() { }

	[AsyncStateMachine(typeof(WebConnection.<Connect>d__16))]
	// RVA: 0x1DA2F94 Offset: 0x1D9EF94 VA: 0x1DA2F94
	private Task Connect(WebOperation operation, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebConnection.<CreateStream>d__18))]
	// RVA: 0x1DA30AC Offset: 0x1D9F0AC VA: 0x1DA30AC
	private Task<bool> CreateStream(WebOperation operation, bool reused, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebConnection.<InitConnection>d__19))]
	// RVA: 0x1DA3208 Offset: 0x1D9F208 VA: 0x1DA3208
	internal Task<WebRequestStream> InitConnection(WebOperation operation, CancellationToken cancellationToken) { }

	// RVA: 0x1DA3354 Offset: 0x1D9F354 VA: 0x1DA3354
	internal static WebException GetException(WebExceptionStatus status, Exception error) { }

	// RVA: 0x1DA34D0 Offset: 0x1D9F4D0 VA: 0x1DA34D0
	internal static bool ReadLine(byte[] buffer, ref int start, int max, ref string output) { }

	// RVA: 0x1DA1490 Offset: 0x1D9D490 VA: 0x1DA1490
	internal bool CanReuseConnection(WebOperation operation) { }

	// RVA: 0x1DA36B0 Offset: 0x1D9F6B0 VA: 0x1DA36B0
	private bool PrepareSharingNtlm(WebOperation operation) { }

	// RVA: 0x1DA39C0 Offset: 0x1D9F9C0 VA: 0x1DA39C0
	private void Reset() { }

	// RVA: 0x1DA3AC0 Offset: 0x1D9FAC0 VA: 0x1DA3AC0
	private void Close(bool reset) { }

	// RVA: 0x1DA3B8C Offset: 0x1D9FB8C VA: 0x1DA3B8C
	private void CloseSocket() { }

	// RVA: 0x1DA112C Offset: 0x1D9D12C VA: 0x1DA112C
	public bool get_Closed() { }

	// RVA: 0x1DA3E78 Offset: 0x1D9FE78 VA: 0x1DA3E78
	public DateTime get_IdleSince() { }

	// RVA: 0x1DA18D0 Offset: 0x1D9D8D0 VA: 0x1DA18D0
	public bool StartOperation(WebOperation operation, bool reused) { }

	// RVA: 0x1DA0568 Offset: 0x1D9C568 VA: 0x1DA0568
	public bool Continue(WebOperation next) { }

	// RVA: 0x1DA41B8 Offset: 0x1DA01B8 VA: 0x1DA41B8
	private void Dispose(bool disposing) { }

	// RVA: 0x1DA1124 Offset: 0x1D9D124 VA: 0x1DA1124 Slot: 4
	public void Dispose() { }

	// RVA: 0x1DA3A98 Offset: 0x1D9FA98 VA: 0x1DA3A98
	private void ResetNtlm() { }

	// RVA: 0x1DA41F0 Offset: 0x1DA01F0 VA: 0x1DA41F0
	internal bool get_NtlmAuthenticated() { }

	// RVA: 0x1DA41F8 Offset: 0x1DA01F8 VA: 0x1DA41F8
	internal void set_NtlmAuthenticated(bool value) { }

	// RVA: 0x1DA4200 Offset: 0x1DA0200 VA: 0x1DA4200
	internal NetworkCredential get_NtlmCredential() { }

	// RVA: 0x1DA4208 Offset: 0x1DA0208 VA: 0x1DA4208
	internal void set_NtlmCredential(NetworkCredential value) { }

	// RVA: 0x1DA4210 Offset: 0x1DA0210 VA: 0x1DA4210
	internal bool get_UnsafeAuthenticatedConnectionSharing() { }

	// RVA: 0x1DA4218 Offset: 0x1DA0218 VA: 0x1DA4218
	internal void set_UnsafeAuthenticatedConnectionSharing(bool value) { }
}

// Namespace: System.Net
internal abstract class WebConnectionStream : Stream // TypeDefIndex: 4289
{
	// Fields
	protected bool closed; // 0x28
	private bool disposed; // 0x29
	private object locker; // 0x30
	private int read_timeout; // 0x38
	private int write_timeout; // 0x3C
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly WebConnection <Connection>k__BackingField; // 0x48
	[CompilerGenerated]
	private readonly WebOperation <Operation>k__BackingField; // 0x50

	// Properties
	internal HttpWebRequest Request { get; }
	internal WebConnection Connection { get; }
	internal WebOperation Operation { get; }
	internal ServicePoint ServicePoint { get; }
	public override bool CanTimeout { get; }
	public override int ReadTimeout { get; set; }
	public override int WriteTimeout { get; set; }
	public override bool CanSeek { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1DA5FD0 Offset: 0x1DA1FD0 VA: 0x1DA5FD0
	protected void .ctor(WebConnection cnc, WebOperation operation) { }

	[CompilerGenerated]
	// RVA: 0x1DA60C8 Offset: 0x1DA20C8 VA: 0x1DA60C8
	internal HttpWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x1DA60D0 Offset: 0x1DA20D0 VA: 0x1DA60D0
	internal WebConnection get_Connection() { }

	[CompilerGenerated]
	// RVA: 0x1DA60D8 Offset: 0x1DA20D8 VA: 0x1DA60D8
	internal WebOperation get_Operation() { }

	// RVA: 0x1DA60E0 Offset: 0x1DA20E0 VA: 0x1DA60E0
	internal ServicePoint get_ServicePoint() { }

	// RVA: 0x1DA60F8 Offset: 0x1DA20F8 VA: 0x1DA60F8 Slot: 9
	public override bool get_CanTimeout() { }

	// RVA: 0x1DA6100 Offset: 0x1DA2100 VA: 0x1DA6100 Slot: 14
	public override int get_ReadTimeout() { }

	// RVA: 0x1DA6108 Offset: 0x1DA2108 VA: 0x1DA6108 Slot: 15
	public override void set_ReadTimeout(int value) { }

	// RVA: 0x1DA6164 Offset: 0x1DA2164 VA: 0x1DA6164 Slot: 16
	public override int get_WriteTimeout() { }

	// RVA: 0x1DA616C Offset: 0x1DA216C VA: 0x1DA616C Slot: 17
	public override void set_WriteTimeout(int value) { }

	// RVA: 0x1DA61C8 Offset: 0x1DA21C8 VA: 0x1DA61C8
	protected Exception GetException(Exception e) { }

	// RVA: -1 Offset: -1 Slot: 38
	protected abstract bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result);

	// RVA: 0x1DA6330 Offset: 0x1DA2330 VA: 0x1DA6330 Slot: 32
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1DA6640 Offset: 0x1DA2640 VA: 0x1DA6640 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x1DA6800 Offset: 0x1DA2800 VA: 0x1DA6800 Slot: 23
	public override int EndRead(IAsyncResult r) { }

	// RVA: 0x1DA6920 Offset: 0x1DA2920 VA: 0x1DA6920 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cb, object state) { }

	// RVA: 0x1DA6AE0 Offset: 0x1DA2AE0 VA: 0x1DA6AE0 Slot: 27
	public override void EndWrite(IAsyncResult r) { }

	// RVA: 0x1DA6BD4 Offset: 0x1DA2BD4 VA: 0x1DA6BD4 Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1DA6DBC Offset: 0x1DA2DBC VA: 0x1DA6DBC Slot: 21
	public override void Flush() { }

	// RVA: 0x1DA6DC0 Offset: 0x1DA2DC0 VA: 0x1DA6DC0
	internal void InternalClose() { }

	// RVA: -1 Offset: -1 Slot: 39
	protected abstract void Close_internal(ref bool disposed);

	// RVA: 0x1DA6DCC Offset: 0x1DA2DCC VA: 0x1DA6DCC Slot: 19
	public override void Close() { }

	// RVA: 0x1DA6DE0 Offset: 0x1DA2DE0 VA: 0x1DA6DE0 Slot: 30
	public override long Seek(long a, SeekOrigin b) { }

	// RVA: 0x1DA6E2C Offset: 0x1DA2E2C VA: 0x1DA6E2C Slot: 31
	public override void SetLength(long a) { }

	// RVA: 0x1DA6E78 Offset: 0x1DA2E78 VA: 0x1DA6E78 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1DA6E80 Offset: 0x1DA2E80 VA: 0x1DA6E80 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1DA6ECC Offset: 0x1DA2ECC VA: 0x1DA6ECC Slot: 12
	public override long get_Position() { }

	// RVA: 0x1DA6F18 Offset: 0x1DA2F18 VA: 0x1DA6F18 Slot: 13
	public override void set_Position(long value) { }
}

// Namespace: 
private enum WebConnectionTunnel.NtlmAuthState // TypeDefIndex: 4290
{
	// Fields
	public int value__; // 0x0
	public const WebConnectionTunnel.NtlmAuthState None = 0;
	public const WebConnectionTunnel.NtlmAuthState Challenge = 1;
	public const WebConnectionTunnel.NtlmAuthState Response = 2;
}

// Namespace: 
[CompilerGenerated]
private struct WebConnectionTunnel.<Initialize>d__42 : IAsyncStateMachine // TypeDefIndex: 4291
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebConnectionTunnel <>4__this; // 0x20
	public Stream stream; // 0x28
	public CancellationToken cancellationToken; // 0x30
	private bool <have_auth>5__2; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<ValueTuple<WebHeaderCollection, byte[], int>> <>u__2; // 0x50

	// Methods

	// RVA: 0x1DA71CC Offset: 0x1DA31CC VA: 0x1DA71CC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DA7F30 Offset: 0x1DA3F30 VA: 0x1DA7F30 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebConnectionTunnel.<ReadHeaders>d__43 : IAsyncStateMachine // TypeDefIndex: 4292
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<ValueTuple<WebHeaderCollection, byte[], int>> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public Stream stream; // 0x28
	public WebConnectionTunnel <>4__this; // 0x30
	private byte[] <retBuffer>5__2; // 0x38
	private int <status>5__3; // 0x40
	private byte[] <buffer>5__4; // 0x48
	private MemoryStream <ms>5__5; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x58

	// Methods

	// RVA: 0x1DA7F98 Offset: 0x1DA3F98 VA: 0x1DA7F98 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DA88B0 Offset: 0x1DA48B0 VA: 0x1DA88B0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class WebConnectionTunnel // TypeDefIndex: 4293
{
	// Fields
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Uri <ConnectUri>k__BackingField; // 0x18
	private HttpWebRequest connectRequest; // 0x20
	private WebConnectionTunnel.NtlmAuthState ntlmAuthState; // 0x28
	[CompilerGenerated]
	private bool <Success>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <CloseConnection>k__BackingField; // 0x2D
	[CompilerGenerated]
	private int <StatusCode>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <StatusDescription>k__BackingField; // 0x38
	[CompilerGenerated]
	private string[] <Challenge>k__BackingField; // 0x40
	[CompilerGenerated]
	private WebHeaderCollection <Headers>k__BackingField; // 0x48
	[CompilerGenerated]
	private Version <ProxyVersion>k__BackingField; // 0x50
	[CompilerGenerated]
	private byte[] <Data>k__BackingField; // 0x58

	// Properties
	public HttpWebRequest Request { get; }
	public Uri ConnectUri { get; }
	public bool Success { get; set; }
	public bool CloseConnection { get; set; }
	public int StatusCode { get; set; }
	private string StatusDescription { set; }
	public string[] Challenge { get; set; }
	public WebHeaderCollection Headers { get; set; }
	public Version ProxyVersion { get; set; }
	public byte[] Data { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1DA6F64 Offset: 0x1DA2F64 VA: 0x1DA6F64
	public HttpWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x1DA6F6C Offset: 0x1DA2F6C VA: 0x1DA6F6C
	public Uri get_ConnectUri() { }

	// RVA: 0x1DA55F4 Offset: 0x1DA15F4 VA: 0x1DA55F4
	public void .ctor(HttpWebRequest request, Uri connectUri) { }

	[CompilerGenerated]
	// RVA: 0x1DA6F74 Offset: 0x1DA2F74 VA: 0x1DA6F74
	public bool get_Success() { }

	[CompilerGenerated]
	// RVA: 0x1DA6F7C Offset: 0x1DA2F7C VA: 0x1DA6F7C
	private void set_Success(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1DA6F84 Offset: 0x1DA2F84 VA: 0x1DA6F84
	public bool get_CloseConnection() { }

	[CompilerGenerated]
	// RVA: 0x1DA6F8C Offset: 0x1DA2F8C VA: 0x1DA6F8C
	private void set_CloseConnection(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1DA6F94 Offset: 0x1DA2F94 VA: 0x1DA6F94
	public int get_StatusCode() { }

	[CompilerGenerated]
	// RVA: 0x1DA6F9C Offset: 0x1DA2F9C VA: 0x1DA6F9C
	private void set_StatusCode(int value) { }

	[CompilerGenerated]
	// RVA: 0x1DA6FA4 Offset: 0x1DA2FA4 VA: 0x1DA6FA4
	private void set_StatusDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x1DA6FAC Offset: 0x1DA2FAC VA: 0x1DA6FAC
	public string[] get_Challenge() { }

	[CompilerGenerated]
	// RVA: 0x1DA6FB4 Offset: 0x1DA2FB4 VA: 0x1DA6FB4
	private void set_Challenge(string[] value) { }

	[CompilerGenerated]
	// RVA: 0x1DA6FBC Offset: 0x1DA2FBC VA: 0x1DA6FBC
	public WebHeaderCollection get_Headers() { }

	[CompilerGenerated]
	// RVA: 0x1DA6FC4 Offset: 0x1DA2FC4 VA: 0x1DA6FC4
	private void set_Headers(WebHeaderCollection value) { }

	[CompilerGenerated]
	// RVA: 0x1DA6FCC Offset: 0x1DA2FCC VA: 0x1DA6FCC
	public Version get_ProxyVersion() { }

	[CompilerGenerated]
	// RVA: 0x1DA6FD4 Offset: 0x1DA2FD4 VA: 0x1DA6FD4
	private void set_ProxyVersion(Version value) { }

	[CompilerGenerated]
	// RVA: 0x1DA6FDC Offset: 0x1DA2FDC VA: 0x1DA6FDC
	public byte[] get_Data() { }

	[CompilerGenerated]
	// RVA: 0x1DA6FE4 Offset: 0x1DA2FE4 VA: 0x1DA6FE4
	private void set_Data(byte[] value) { }

	[AsyncStateMachine(typeof(WebConnectionTunnel.<Initialize>d__42))]
	// RVA: 0x1DA5638 Offset: 0x1DA1638 VA: 0x1DA5638
	internal Task Initialize(Stream stream, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebConnectionTunnel.<ReadHeaders>d__43))]
	// RVA: 0x1DA6FEC Offset: 0x1DA2FEC VA: 0x1DA6FEC
	private Task<ValueTuple<WebHeaderCollection, byte[], int>> ReadHeaders(Stream stream, CancellationToken cancellationToken) { }

	// RVA: 0x1DA713C Offset: 0x1DA313C VA: 0x1DA713C
	private void FlushContents(Stream stream, int contentLength) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebOperation.<Run>d__58 : IAsyncStateMachine // TypeDefIndex: 4294
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public WebOperation <>4__this; // 0x28
	private WebRequestStream <requestStream>5__2; // 0x30
	private WebResponseStream <stream>5__3; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<WebRequestStream> <>u__1; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x50

	// Methods

	// RVA: 0x1DA9520 Offset: 0x1DA5520 VA: 0x1DA9520 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DA9DE0 Offset: 0x1DA5DE0 VA: 0x1DA9DE0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class WebOperation // TypeDefIndex: 4295
{
	// Fields
	[CompilerGenerated]
	private readonly HttpWebRequest <Request>k__BackingField; // 0x10
	[CompilerGenerated]
	private WebConnection <Connection>k__BackingField; // 0x18
	[CompilerGenerated]
	private ServicePoint <ServicePoint>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly BufferOffsetSize <WriteBuffer>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly bool <IsNtlmChallenge>k__BackingField; // 0x30
	private CancellationTokenSource cts; // 0x38
	private WebCompletionSource<WebRequestStream> requestTask; // 0x40
	private WebCompletionSource<WebRequestStream> requestWrittenTask; // 0x48
	private WebCompletionSource<WebResponseStream> responseTask; // 0x50
	private WebCompletionSource<ValueTuple<bool, WebOperation>> finishedTask; // 0x58
	private WebRequestStream writeStream; // 0x60
	private WebResponseStream responseStream; // 0x68
	private ExceptionDispatchInfo disposedInfo; // 0x70
	private ExceptionDispatchInfo closedInfo; // 0x78
	private WebOperation priorityRequest; // 0x80
	private int requestSent; // 0x88
	private int finished; // 0x8C

	// Properties
	public HttpWebRequest Request { get; }
	public WebConnection Connection { get; set; }
	public ServicePoint ServicePoint { get; set; }
	public BufferOffsetSize WriteBuffer { get; }
	public bool IsNtlmChallenge { get; }
	public bool Aborted { get; }
	public bool Closed { get; }
	public WebRequestStream WriteStream { get; }
	internal WebCompletionSource<ValueTuple<bool, WebOperation>> Finished { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1DA892C Offset: 0x1DA492C VA: 0x1DA892C
	public HttpWebRequest get_Request() { }

	[CompilerGenerated]
	// RVA: 0x1DA8934 Offset: 0x1DA4934 VA: 0x1DA8934
	public WebConnection get_Connection() { }

	[CompilerGenerated]
	// RVA: 0x1DA893C Offset: 0x1DA493C VA: 0x1DA893C
	private void set_Connection(WebConnection value) { }

	[CompilerGenerated]
	// RVA: 0x1DA8944 Offset: 0x1DA4944 VA: 0x1DA8944
	public ServicePoint get_ServicePoint() { }

	[CompilerGenerated]
	// RVA: 0x1DA894C Offset: 0x1DA494C VA: 0x1DA894C
	private void set_ServicePoint(ServicePoint value) { }

	[CompilerGenerated]
	// RVA: 0x1DA8954 Offset: 0x1DA4954 VA: 0x1DA8954
	public BufferOffsetSize get_WriteBuffer() { }

	[CompilerGenerated]
	// RVA: 0x1DA895C Offset: 0x1DA495C VA: 0x1DA895C
	public bool get_IsNtlmChallenge() { }

	// RVA: 0x1DA8964 Offset: 0x1DA4964 VA: 0x1DA8964
	public void .ctor(HttpWebRequest request, BufferOffsetSize writeBuffer, bool isNtlmChallenge, CancellationToken cancellationToken) { }

	// RVA: 0x1DA113C Offset: 0x1D9D13C VA: 0x1DA113C
	public bool get_Aborted() { }

	// RVA: 0x1DA8B4C Offset: 0x1DA4B4C VA: 0x1DA8B4C
	public bool get_Closed() { }

	// RVA: 0x1DA8B78 Offset: 0x1DA4B78 VA: 0x1DA8B78
	public void Abort() { }

	// RVA: 0x1DA8D68 Offset: 0x1DA4D68 VA: 0x1DA8D68
	public void Close() { }

	// RVA: 0x1DA8CA0 Offset: 0x1DA4CA0 VA: 0x1DA8CA0
	private void SetCanceled() { }

	// RVA: 0x1DA905C Offset: 0x1DA505C VA: 0x1DA905C
	private void SetError(Exception error) { }

	// RVA: 0x1DA8BB8 Offset: 0x1DA4BB8 VA: 0x1DA8BB8
	private ValueTuple<ExceptionDispatchInfo, bool> SetDisposed(ref ExceptionDispatchInfo field) { }

	// RVA: 0x1DA9100 Offset: 0x1DA5100 VA: 0x1DA9100
	internal ExceptionDispatchInfo CheckDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x1DA91E0 Offset: 0x1DA51E0 VA: 0x1DA91E0
	internal void ThrowIfDisposed() { }

	// RVA: 0x1DA4DD0 Offset: 0x1DA0DD0 VA: 0x1DA4DD0
	internal void ThrowIfDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x1DA65E0 Offset: 0x1DA25E0 VA: 0x1DA65E0
	internal void ThrowIfClosedOrDisposed() { }

	// RVA: 0x1DA5D4C Offset: 0x1DA1D4C VA: 0x1DA5D4C
	internal void ThrowIfClosedOrDisposed(CancellationToken cancellationToken) { }

	// RVA: 0x1DA9188 Offset: 0x1DA5188 VA: 0x1DA9188
	private ExceptionDispatchInfo CheckThrowDisposed(bool throwIt, ref ExceptionDispatchInfo field) { }

	// RVA: 0x1DA3E80 Offset: 0x1D9FE80 VA: 0x1DA3E80
	internal void RegisterRequest(ServicePoint servicePoint, WebConnection connection) { }

	// RVA: 0x1DA9240 Offset: 0x1DA5240 VA: 0x1DA9240
	public void SetPriorityRequest(WebOperation operation) { }

	// RVA: 0x1DA93C0 Offset: 0x1DA53C0 VA: 0x1DA93C0
	internal Task<WebRequestStream> GetRequestStreamInternal() { }

	// RVA: 0x1DA9410 Offset: 0x1DA5410 VA: 0x1DA9410
	public WebRequestStream get_WriteStream() { }

	// RVA: 0x1DA9428 Offset: 0x1DA5428 VA: 0x1DA9428
	public Task<WebResponseStream> GetResponseStream() { }

	// RVA: 0x1DA9478 Offset: 0x1DA5478 VA: 0x1DA9478
	internal WebCompletionSource<ValueTuple<bool, WebOperation>> get_Finished() { }

	[AsyncStateMachine(typeof(WebOperation.<Run>d__58))]
	// RVA: 0x1DA4110 Offset: 0x1DA0110 VA: 0x1DA4110
	internal void Run() { }

	// RVA: 0x1DA9480 Offset: 0x1DA5480 VA: 0x1DA9480
	internal void CompleteRequestWritten(WebRequestStream stream, Exception error) { }

	// RVA: 0x1DA8E14 Offset: 0x1DA4E14 VA: 0x1DA8E14
	internal void Finish(bool ok, Exception error) { }

	[CompilerGenerated]
	// RVA: 0x1DA9500 Offset: 0x1DA5500 VA: 0x1DA9500
	private void <RegisterRequest>b__48_0() { }
}

// Namespace: 
[CompilerGenerated]
private struct WebReadStream.<ReadAsync>d__28 : IAsyncStateMachine // TypeDefIndex: 4296
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public WebReadStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public byte[] buffer; // 0x30
	public int offset; // 0x38
	public int size; // 0x3C
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x50

	// Methods

	// RVA: 0x1DAA7E8 Offset: 0x1DA67E8 VA: 0x1DAA7E8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DAADAC Offset: 0x1DA6DAC VA: 0x1DAADAC Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal abstract class WebReadStream : Stream // TypeDefIndex: 4297
{
	// Fields
	[CompilerGenerated]
	private readonly WebOperation <Operation>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly Stream <InnerStream>k__BackingField; // 0x30
	private bool disposed; // 0x38

	// Properties
	public WebOperation Operation { get; }
	protected Stream InnerStream { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public override bool CanSeek { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1DA9DEC Offset: 0x1DA5DEC VA: 0x1DA9DEC
	public WebOperation get_Operation() { }

	[CompilerGenerated]
	// RVA: 0x1DA9DF4 Offset: 0x1DA5DF4 VA: 0x1DA9DF4
	protected Stream get_InnerStream() { }

	// RVA: 0x1D9CC54 Offset: 0x1D98C54 VA: 0x1D9CC54
	public void .ctor(WebOperation operation, Stream innerStream) { }

	// RVA: 0x1DA9DFC Offset: 0x1DA5DFC VA: 0x1DA9DFC Slot: 11
	public override long get_Length() { }

	// RVA: 0x1DA9E34 Offset: 0x1DA5E34 VA: 0x1DA9E34 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1DA9E6C Offset: 0x1DA5E6C VA: 0x1DA9E6C Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1DA9EA4 Offset: 0x1DA5EA4 VA: 0x1DA9EA4 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1DA9EAC Offset: 0x1DA5EAC VA: 0x1DA9EAC Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1DA9EB4 Offset: 0x1DA5EB4 VA: 0x1DA9EB4 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1DA9EBC Offset: 0x1DA5EBC VA: 0x1DA9EBC Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1DA9EF4 Offset: 0x1DA5EF4 VA: 0x1DA9EF4 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x1DA9F2C Offset: 0x1DA5F2C VA: 0x1DA9F2C Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1DA9F64 Offset: 0x1DA5F64 VA: 0x1DA9F64 Slot: 21
	public override void Flush() { }

	// RVA: 0x1DA9F9C Offset: 0x1DA5F9C VA: 0x1DA9F9C
	protected Exception GetException(Exception e) { }

	// RVA: 0x1DAA104 Offset: 0x1DA6104 VA: 0x1DAA104 Slot: 32
	public override int Read(byte[] buffer, int offset, int size) { }

	// RVA: 0x1DAA35C Offset: 0x1DA635C VA: 0x1DAA35C Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state) { }

	// RVA: 0x1DAA51C Offset: 0x1DA651C VA: 0x1DAA51C Slot: 23
	public override int EndRead(IAsyncResult r) { }

	[AsyncStateMachine(typeof(WebReadStream.<ReadAsync>d__28))]
	// RVA: 0x1DAA63C Offset: 0x1DA663C VA: 0x1DAA63C Slot: 24
	public sealed override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: -1 Offset: -1 Slot: 38
	protected abstract Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken);

	// RVA: 0x1D9CF98 Offset: 0x1D98F98 VA: 0x1D9CF98 Slot: 39
	internal virtual Task FinishReading(CancellationToken cancellationToken) { }

	// RVA: 0x1DAA79C Offset: 0x1DA679C VA: 0x1DAA79C Slot: 20
	protected override void Dispose(bool disposing) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<FinishWriting>d__31 : IAsyncStateMachine // TypeDefIndex: 4298
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1DABCD0 Offset: 0x1DA7CD0 VA: 0x1DABCD0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DAC03C Offset: 0x1DA803C VA: 0x1DAC03C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<WriteAsyncInner>d__33 : IAsyncStateMachine // TypeDefIndex: 4299
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	public byte[] buffer; // 0x28
	public int offset; // 0x30
	public int size; // 0x34
	public CancellationToken cancellationToken; // 0x38
	public WebCompletionSource completion; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48
	private TaskAwaiter <>u__2; // 0x58

	// Methods

	// RVA: 0x1DAC0A4 Offset: 0x1DA80A4 VA: 0x1DAC0A4 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DAC62C Offset: 0x1DA862C VA: 0x1DAC62C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<ProcessWrite>d__34 : IAsyncStateMachine // TypeDefIndex: 4300
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public int size; // 0x30
	public byte[] buffer; // 0x38
	public int offset; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x48

	// Methods

	// RVA: 0x1DAC694 Offset: 0x1DA8694 VA: 0x1DAC694 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DACC80 Offset: 0x1DA8C80 VA: 0x1DACC80 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<Initialize>d__36 : IAsyncStateMachine // TypeDefIndex: 4301
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30
	private TaskAwaiter <>u__2; // 0x40

	// Methods

	// RVA: 0x1DACCE8 Offset: 0x1DA8CE8 VA: 0x1DACCE8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DAD088 Offset: 0x1DA9088 VA: 0x1DAD088 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<SetHeadersAsync>d__37 : IAsyncStateMachine // TypeDefIndex: 4302
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public bool setInternalLength; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0x1DAD0F0 Offset: 0x1DA90F0 VA: 0x1DAD0F0 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DAD82C Offset: 0x1DA982C VA: 0x1DAD82C Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<WriteRequestAsync>d__38 : IAsyncStateMachine // TypeDefIndex: 4303
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private BufferOffsetSize <buffer>5__2; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x38
	private TaskAwaiter <>u__2; // 0x48

	// Methods

	// RVA: 0x1DAD894 Offset: 0x1DA9894 VA: 0x1DAD894 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DADE30 Offset: 0x1DA9E30 VA: 0x1DADE30 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<WriteChunkTrailer_inner>d__39 : IAsyncStateMachine // TypeDefIndex: 4304
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0x1DADE98 Offset: 0x1DA9E98 VA: 0x1DADE98 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DAE144 Offset: 0x1DAA144 VA: 0x1DAE144 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebRequestStream.<WriteChunkTrailer>d__40 : IAsyncStateMachine // TypeDefIndex: 4305
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebRequestStream <>4__this; // 0x20
	private CancellationTokenSource <cts>5__2; // 0x28
	private Task <timeoutTask>5__3; // 0x30
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x38
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2; // 0x48

	// Methods

	// RVA: 0x1DAE1AC Offset: 0x1DAA1AC VA: 0x1DAE1AC Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1DAE9C0 Offset: 0x1DAA9C0 VA: 0x1DAE9C0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class WebRequestStream : WebConnectionStream // TypeDefIndex: 4306
{
	// Fields
	private static byte[] crlf; // 0x0
	private MemoryStream writeBuffer; // 0x58
	private bool requestWritten; // 0x60
	private bool allowBuffering; // 0x61
	private bool sendChunked; // 0x62
	private WebCompletionSource pendingWrite; // 0x68
	private long totalWritten; // 0x70
	private byte[] headers; // 0x78
	private bool headersSent; // 0x80
	private int completeRequestWritten; // 0x84
	private int chunkTrailerWritten; // 0x88
	[CompilerGenerated]
	private readonly Stream <InnerStream>k__BackingField; // 0x90
	[CompilerGenerated]
	private readonly bool <KeepAlive>k__BackingField; // 0x98

	// Properties
	internal Stream InnerStream { get; }
	public bool KeepAlive { get; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	internal bool HasWriteBuffer { get; }
	internal int WriteBufferLength { get; }

	// Methods

	// RVA: 0x1DA5DD4 Offset: 0x1DA1DD4 VA: 0x1DA5DD4
	public void .ctor(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel) { }

	[CompilerGenerated]
	// RVA: 0x1DAAE28 Offset: 0x1DA6E28 VA: 0x1DAAE28
	internal Stream get_InnerStream() { }

	[CompilerGenerated]
	// RVA: 0x1DAAE30 Offset: 0x1DA6E30 VA: 0x1DAAE30
	public bool get_KeepAlive() { }

	// RVA: 0x1DAAE38 Offset: 0x1DA6E38 VA: 0x1DAAE38 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1DAAE40 Offset: 0x1DA6E40 VA: 0x1DAAE40 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1DAAE48 Offset: 0x1DA6E48 VA: 0x1DAAE48
	internal bool get_HasWriteBuffer() { }

	// RVA: 0x1DAAE78 Offset: 0x1DA6E78 VA: 0x1DAAE78
	internal int get_WriteBufferLength() { }

	// RVA: 0x1DAAEBC Offset: 0x1DA6EBC VA: 0x1DAAEBC
	internal BufferOffsetSize GetWriteBuffer() { }

	[AsyncStateMachine(typeof(WebRequestStream.<FinishWriting>d__31))]
	// RVA: 0x1DAAF94 Offset: 0x1DA6F94 VA: 0x1DAAF94
	private Task FinishWriting(CancellationToken cancellationToken) { }

	// RVA: 0x1DAB08C Offset: 0x1DA708C VA: 0x1DAB08C Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteAsyncInner>d__33))]
	// RVA: 0x1DAB2E8 Offset: 0x1DA72E8 VA: 0x1DAB2E8
	private Task WriteAsyncInner(byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<ProcessWrite>d__34))]
	// RVA: 0x1DAB428 Offset: 0x1DA7428 VA: 0x1DAB428
	private Task ProcessWrite(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1DAB558 Offset: 0x1DA7558 VA: 0x1DAB558
	private void CheckWriteOverflow(long contentLength, long totalWritten, long size) { }

	[AsyncStateMachine(typeof(WebRequestStream.<Initialize>d__36))]
	// RVA: 0x1DA9B60 Offset: 0x1DA5B60 VA: 0x1DA9B60
	internal Task Initialize(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<SetHeadersAsync>d__37))]
	// RVA: 0x1DAB5EC Offset: 0x1DA75EC VA: 0x1DAB5EC
	private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteRequestAsync>d__38))]
	// RVA: 0x1DAB6F8 Offset: 0x1DA76F8 VA: 0x1DAB6F8
	internal Task WriteRequestAsync(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteChunkTrailer_inner>d__39))]
	// RVA: 0x1DAB7F0 Offset: 0x1DA77F0 VA: 0x1DAB7F0
	private Task WriteChunkTrailer_inner(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebRequestStream.<WriteChunkTrailer>d__40))]
	// RVA: 0x1DAB8E8 Offset: 0x1DA78E8 VA: 0x1DAB8E8
	private Task WriteChunkTrailer() { }

	// RVA: 0x1D9AC14 Offset: 0x1D96C14 VA: 0x1D9AC14
	internal void KillBuffer() { }

	// RVA: 0x1DAB9D0 Offset: 0x1DA79D0 VA: 0x1DAB9D0 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1DABA80 Offset: 0x1DA7A80 VA: 0x1DABA80 Slot: 38
	protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result) { }

	// RVA: 0x1DABAB8 Offset: 0x1DA7AB8 VA: 0x1DABAB8 Slot: 39
	protected override void Close_internal(ref bool disposed) { }

	// RVA: 0x1DABC30 Offset: 0x1DA7C30 VA: 0x1DABC30
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private struct WebResponseStream.<ReadAsync>d__40 : IAsyncStateMachine // TypeDefIndex: 4307
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<int> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public byte[] buffer; // 0x28
	public int offset; // 0x30
	public int count; // 0x34
	public WebResponseStream <>4__this; // 0x38
	private WebCompletionSource <completion>5__2; // 0x40
	private int <nbytes>5__3; // 0x48
	private Exception <throwMe>5__4; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object> <>u__1; // 0x58
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__2; // 0x68

	// Methods

	// RVA: 0x1CD6E8C Offset: 0x1CD2E8C VA: 0x1CD6E8C Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CD78D4 Offset: 0x1CD38D4 VA: 0x1CD78D4 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class WebResponseStream.<>c__DisplayClass41_0 // TypeDefIndex: 4308
{
	// Fields
	public WebResponseStream <>4__this; // 0x10
	public byte[] buffer; // 0x18
	public int offset; // 0x20
	public int size; // 0x24

	// Methods

	// RVA: 0x1CD7950 Offset: 0x1CD3950 VA: 0x1CD7950
	public void .ctor() { }

	// RVA: 0x1CD7958 Offset: 0x1CD3958 VA: 0x1CD7958
	internal Task<int> <ProcessRead>b__0(CancellationToken ct) { }

	// RVA: 0x1CD7994 Offset: 0x1CD3994 VA: 0x1CD7994
	internal void <ProcessRead>b__1() { }

	// RVA: 0x1CD79D4 Offset: 0x1CD39D4 VA: 0x1CD79D4
	internal bool <ProcessRead>b__2() { }
}

// Namespace: 
[CompilerGenerated]
private struct WebResponseStream.<ReadAllAsyncInner>d__47 : IAsyncStateMachine // TypeDefIndex: 4309
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<byte[]> <>t__builder; // 0x8
	public CancellationToken cancellationToken; // 0x20
	public WebResponseStream <>4__this; // 0x28
	private long <maximumSize>5__2; // 0x30
	private MemoryStream <ms>5__3; // 0x38
	private byte[] <buffer>5__4; // 0x40
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x48

	// Methods

	// RVA: 0x1CD79F8 Offset: 0x1CD39F8 VA: 0x1CD79F8 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CD8014 Offset: 0x1CD4014 VA: 0x1CD8014 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebResponseStream.<ReadAllAsync>d__48 : IAsyncStateMachine // TypeDefIndex: 4310
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebResponseStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	public bool resending; // 0x30
	private WebCompletionSource <completion>5__2; // 0x38
	private CancellationTokenSource <timeoutCts>5__3; // 0x40
	private Task <timeoutTask>5__4; // 0x48
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<Task> <>u__1; // 0x50
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<byte[]> <>u__2; // 0x60

	// Methods

	// RVA: 0x1CD8090 Offset: 0x1CD4090 VA: 0x1CD8090 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CD8BF8 Offset: 0x1CD4BF8 VA: 0x1CD8BF8 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: 
[CompilerGenerated]
private struct WebResponseStream.<InitReadAsync>d__52 : IAsyncStateMachine // TypeDefIndex: 4311
{
	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public WebResponseStream <>4__this; // 0x20
	public CancellationToken cancellationToken; // 0x28
	private BufferOffsetSize <buffer>5__2; // 0x30
	private ReadState <state>5__3; // 0x38
	private int <position>5__4; // 0x3C
	private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<int> <>u__1; // 0x40

	// Methods

	// RVA: 0x1CD8C60 Offset: 0x1CD4C60 VA: 0x1CD8C60 Slot: 4
	private void MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1CD9418 Offset: 0x1CD5418 VA: 0x1CD9418 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
}

// Namespace: System.Net
internal class WebResponseStream : WebConnectionStream // TypeDefIndex: 4312
{
	// Fields
	private WebReadStream innerStream; // 0x58
	private bool nextReadCalled; // 0x60
	private bool bufferedEntireContent; // 0x61
	private WebCompletionSource pendingRead; // 0x68
	private object locker; // 0x70
	private int nestedRead; // 0x78
	private bool read_eof; // 0x7C
	[CompilerGenerated]
	private readonly WebRequestStream <RequestStream>k__BackingField; // 0x80
	[CompilerGenerated]
	private WebHeaderCollection <Headers>k__BackingField; // 0x88
	[CompilerGenerated]
	private HttpStatusCode <StatusCode>k__BackingField; // 0x90
	[CompilerGenerated]
	private string <StatusDescription>k__BackingField; // 0x98
	[CompilerGenerated]
	private Version <Version>k__BackingField; // 0xA0
	[CompilerGenerated]
	private bool <KeepAlive>k__BackingField; // 0xA8
	[CompilerGenerated]
	private bool <ChunkedRead>k__BackingField; // 0xA9

	// Properties
	public WebRequestStream RequestStream { get; }
	public WebHeaderCollection Headers { get; set; }
	public HttpStatusCode StatusCode { get; set; }
	public string StatusDescription { get; set; }
	public Version Version { get; set; }
	public bool KeepAlive { get; set; }
	public override bool CanRead { get; }
	public override bool CanWrite { get; }
	private bool ChunkedRead { get; set; }
	private bool ExpectContent { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1DAEA28 Offset: 0x1DAAA28 VA: 0x1DAEA28
	public WebRequestStream get_RequestStream() { }

	[CompilerGenerated]
	// RVA: 0x1DAEA30 Offset: 0x1DAAA30 VA: 0x1DAEA30
	public WebHeaderCollection get_Headers() { }

	[CompilerGenerated]
	// RVA: 0x1DAEA38 Offset: 0x1DAAA38 VA: 0x1DAEA38
	private void set_Headers(WebHeaderCollection value) { }

	[CompilerGenerated]
	// RVA: 0x1DAEA40 Offset: 0x1DAAA40 VA: 0x1DAEA40
	public HttpStatusCode get_StatusCode() { }

	[CompilerGenerated]
	// RVA: 0x1DAEA48 Offset: 0x1DAAA48 VA: 0x1DAEA48
	private void set_StatusCode(HttpStatusCode value) { }

	[CompilerGenerated]
	// RVA: 0x1DAEA50 Offset: 0x1DAAA50 VA: 0x1DAEA50
	public string get_StatusDescription() { }

	[CompilerGenerated]
	// RVA: 0x1DAEA58 Offset: 0x1DAAA58 VA: 0x1DAEA58
	private void set_StatusDescription(string value) { }

	[CompilerGenerated]
	// RVA: 0x1DAEA60 Offset: 0x1DAAA60 VA: 0x1DAEA60
	public Version get_Version() { }

	[CompilerGenerated]
	// RVA: 0x1DAEA68 Offset: 0x1DAAA68 VA: 0x1DAEA68
	private void set_Version(Version value) { }

	[CompilerGenerated]
	// RVA: 0x1DAEA70 Offset: 0x1DAAA70 VA: 0x1DAEA70
	public bool get_KeepAlive() { }

	[CompilerGenerated]
	// RVA: 0x1DAEA78 Offset: 0x1DAAA78 VA: 0x1DAEA78
	private void set_KeepAlive(bool value) { }

	// RVA: 0x1DA9C58 Offset: 0x1DA5C58 VA: 0x1DA9C58
	public void .ctor(WebRequestStream request) { }

	// RVA: 0x1DAEA80 Offset: 0x1DAAA80 VA: 0x1DAEA80 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1DAEA88 Offset: 0x1DAAA88 VA: 0x1DAEA88 Slot: 10
	public override bool get_CanWrite() { }

	[CompilerGenerated]
	// RVA: 0x1DAEA90 Offset: 0x1DAAA90 VA: 0x1DAEA90
	private bool get_ChunkedRead() { }

	[CompilerGenerated]
	// RVA: 0x1DAEA98 Offset: 0x1DAAA98 VA: 0x1DAEA98
	private void set_ChunkedRead(bool value) { }

	[AsyncStateMachine(typeof(WebResponseStream.<ReadAsync>d__40))]
	// RVA: 0x1DAEAA0 Offset: 0x1DAAAA0 VA: 0x1DAEAA0 Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1DAEC04 Offset: 0x1DAAC04 VA: 0x1DAEC04
	private Task<int> ProcessRead(byte[] buffer, int offset, int size, CancellationToken cancellationToken) { }

	// RVA: 0x1DAEEBC Offset: 0x1DAAEBC VA: 0x1DAEEBC Slot: 38
	protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result) { }

	// RVA: 0x1DAEF88 Offset: 0x1DAAF88 VA: 0x1DAEF88
	private bool get_ExpectContent() { }

	// RVA: 0x1DAF014 Offset: 0x1DAB014 VA: 0x1DAF014
	private void Initialize(BufferOffsetSize buffer) { }

	[AsyncStateMachine(typeof(WebResponseStream.<ReadAllAsyncInner>d__47))]
	// RVA: 0x1DAF560 Offset: 0x1DAB560 VA: 0x1DAF560
	private Task<byte[]> ReadAllAsyncInner(CancellationToken cancellationToken) { }

	[AsyncStateMachine(typeof(WebResponseStream.<ReadAllAsync>d__48))]
	// RVA: 0x1D9AB04 Offset: 0x1D96B04 VA: 0x1D9AB04
	internal Task ReadAllAsync(bool resending, CancellationToken cancellationToken) { }

	// RVA: 0x1DAF694 Offset: 0x1DAB694 VA: 0x1DAF694 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x1DAF730 Offset: 0x1DAB730 VA: 0x1DAF730 Slot: 39
	protected override void Close_internal(ref bool disposed) { }

	// RVA: 0x1DAF7D0 Offset: 0x1DAB7D0 VA: 0x1DAF7D0
	private WebException GetReadException(WebExceptionStatus status, Exception error, string where) { }

	[AsyncStateMachine(typeof(WebResponseStream.<InitReadAsync>d__52))]
	// RVA: 0x1DA9CE8 Offset: 0x1DA5CE8 VA: 0x1DA9CE8
	internal Task InitReadAsync(CancellationToken cancellationToken) { }

	// RVA: 0x1DAFA5C Offset: 0x1DABA5C VA: 0x1DAFA5C
	private bool GetResponse(BufferOffsetSize buffer, ref int pos, ref ReadState state) { }
}
