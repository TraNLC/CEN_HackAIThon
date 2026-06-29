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

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/CertificateHandler/CertificateHandlerScript.h")]
public class CertificateHandler : IDisposable // TypeDefIndex: 7954
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	// RVA: 0x1F24694 Offset: 0x1F20694 VA: 0x1F24694
	private static IntPtr Create(CertificateHandler obj) { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x1F246D0 Offset: 0x1F206D0 VA: 0x1F246D0
	private void ReleaseFromScripting() { }

	// RVA: 0x1F2475C Offset: 0x1F2075C VA: 0x1F2475C
	protected void .ctor() { }

	// RVA: 0x1F247A8 Offset: 0x1F207A8 VA: 0x1F247A8 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1F2485C Offset: 0x1F2085C VA: 0x1F2485C Slot: 5
	protected virtual bool ValidateCertificate(byte[] certificateData) { }

	[RequiredByNativeCode]
	// RVA: 0x1F24864 Offset: 0x1F20864 VA: 0x1F24864
	internal bool ValidateCertificateNative(byte[] certificateData) { }

	// RVA: 0x1F2483C Offset: 0x1F2083C VA: 0x1F2483C Slot: 4
	public void Dispose() { }

	// RVA: 0x1F24720 Offset: 0x1F20720 VA: 0x1F24720
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }
}

// Namespace: 
internal static class DownloadHandler.BindingsMarshaller // TypeDefIndex: 7955
{
	// Methods

	// RVA: 0x1F251C8 Offset: 0x1F211C8 VA: 0x1F251C8
	public static IntPtr ConvertToNative(DownloadHandler handler) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandler.h")]
public class DownloadHandler : IDisposable // TypeDefIndex: 7956
{
	// Fields
	[VisibleToOtherModules]
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public string error { get; }
	public string text { get; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x1F24884 Offset: 0x1F20884 VA: 0x1F24884
	private void ReleaseFromScripting() { }

	[VisibleToOtherModules]
	// RVA: 0x1F24910 Offset: 0x1F20910 VA: 0x1F24910
	internal void .ctor() { }

	// RVA: 0x1F24918 Offset: 0x1F20918 VA: 0x1F24918 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1F249A4 Offset: 0x1F209A4 VA: 0x1F249A4 Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x1F249C4 Offset: 0x1F209C4 VA: 0x1F249C4
	public string get_error() { }

	// RVA: 0x1F249C8 Offset: 0x1F209C8 VA: 0x1F249C8
	private string GetErrorMsg() { }

	// RVA: 0x1F24B0C Offset: 0x1F20B0C VA: 0x1F24B0C
	public string get_text() { }

	// RVA: 0x1F24B18 Offset: 0x1F20B18 VA: 0x1F24B18 Slot: 6
	protected virtual NativeArray<byte> GetNativeData() { }

	// RVA: 0x1F24B24 Offset: 0x1F20B24 VA: 0x1F24B24 Slot: 7
	protected virtual string GetText() { }

	// RVA: 0x1F24BE4 Offset: 0x1F20BE4 VA: 0x1F24BE4
	private Encoding GetTextEncoder() { }

	// RVA: 0x1F24E34 Offset: 0x1F20E34 VA: 0x1F24E34
	private string GetContentType() { }

	[RequiredByNativeCode]
	// RVA: 0x1F24F78 Offset: 0x1F20F78 VA: 0x1F24F78 Slot: 8
	protected virtual bool ReceiveData(byte[] data, int dataLength) { }

	[RequiredByNativeCode]
	// RVA: 0x1F24F80 Offset: 0x1F20F80 VA: 0x1F24F80 Slot: 9
	protected virtual void ReceiveContentLengthHeader(ulong contentLength) { }

	[Obsolete("Use ReceiveContentLengthHeader")]
	// RVA: 0x1F24F8C Offset: 0x1F20F8C VA: 0x1F24F8C Slot: 10
	protected virtual void ReceiveContentLength(int contentLength) { }

	[RequiredByNativeCode]
	// RVA: 0x1F24F90 Offset: 0x1F20F90 VA: 0x1F24F90 Slot: 11
	protected virtual void CompleteContent() { }

	[RequiredByNativeCode]
	// RVA: 0x1F24F94 Offset: 0x1F20F94 VA: 0x1F24F94 Slot: 12
	protected virtual float GetProgress() { }

	[NativeThrows]
	[VisibleToOtherModules]
	// RVA: 0x1F24F9C Offset: 0x1F20F9C VA: 0x1F24F9C
	internal static byte* InternalGetByteArray(DownloadHandler dh, out int length) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UnityWebRequestAudioModule", "UnityEngine.UnityWebRequestTextureModule" })]
	// RVA: 0x1F25030 Offset: 0x1F21030 VA: 0x1F25030
	internal static NativeArray<byte> InternalGetNativeArray(DownloadHandler dh, ref NativeArray<byte> nativeArray) { }

	[VisibleToOtherModules(new[] { "UnityEngine.UnityWebRequestAudioModule", "UnityEngine.UnityWebRequestTextureModule" })]
	// RVA: 0x1F2511C Offset: 0x1F2111C VA: 0x1F2511C
	internal static void DisposeNativeArray(ref NativeArray<byte> data) { }

	// RVA: 0x1F25160 Offset: 0x1F21160 VA: 0x1F25160
	internal static void CreateNativeArrayForNativeData(ref NativeArray<byte> data, byte* bytes, int length) { }

	// RVA: 0x1F248D4 Offset: 0x1F208D4 VA: 0x1F248D4
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }

	// RVA: 0x1F24AC8 Offset: 0x1F20AC8 VA: 0x1F24AC8
	private static void GetErrorMsg_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x1F24F34 Offset: 0x1F20F34 VA: 0x1F24F34
	private static void GetContentType_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	// RVA: 0x1F24FEC Offset: 0x1F20FEC VA: 0x1F24FEC
	private static byte* InternalGetByteArray_Injected(IntPtr dh, out int length) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerBuffer.h")]
public sealed class DownloadHandlerBuffer : DownloadHandler // TypeDefIndex: 7957
{
	// Fields
	private NativeArray<byte> m_NativeData; // 0x18

	// Methods

	// RVA: 0x1F251DC Offset: 0x1F211DC VA: 0x1F251DC
	private static IntPtr Create(DownloadHandlerBuffer obj) { }

	// RVA: 0x1F25218 Offset: 0x1F21218 VA: 0x1F25218
	private void InternalCreateBuffer() { }

	// RVA: 0x1F2525C Offset: 0x1F2125C VA: 0x1F2525C
	public void .ctor() { }

	// RVA: 0x1F252A8 Offset: 0x1F212A8 VA: 0x1F252A8 Slot: 6
	protected override NativeArray<byte> GetNativeData() { }

	// RVA: 0x1F252B0 Offset: 0x1F212B0 VA: 0x1F252B0 Slot: 5
	public override void Dispose() { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/DownloadHandler/DownloadHandlerVFS.h")]
public sealed class DownloadHandlerFile : DownloadHandler // TypeDefIndex: 7958
{
	// Methods

	[NativeThrows]
	// RVA: 0x1F25308 Offset: 0x1F21308 VA: 0x1F25308
	private static IntPtr Create(DownloadHandlerFile obj, string path, bool append) { }

	// RVA: 0x1F254E4 Offset: 0x1F214E4 VA: 0x1F254E4
	private void InternalCreateVFS(string path, bool append) { }

	// RVA: 0x1F25580 Offset: 0x1F21580 VA: 0x1F25580
	public void .ctor(string path) { }

	// RVA: 0x1F255B0 Offset: 0x1F215B0 VA: 0x1F255B0 Slot: 6
	protected override NativeArray<byte> GetNativeData() { }

	// RVA: 0x1F255FC Offset: 0x1F215FC VA: 0x1F255FC Slot: 7
	protected override string GetText() { }

	// RVA: 0x1F25490 Offset: 0x1F21490 VA: 0x1F25490
	private static IntPtr Create_Injected(DownloadHandlerFile obj, ref ManagedSpanWrapper path, bool append) { }
}

// Namespace: 
internal static class UnityWebRequestAsyncOperation.BindingsMarshaller // TypeDefIndex: 7959
{
	// Methods

	// RVA: 0x1F25658 Offset: 0x1F21658 VA: 0x1F25658
	public static UnityWebRequestAsyncOperation ConvertToManaged(IntPtr ptr) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("UnityWebRequestScriptingClasses.h")]
[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequestAsyncOperation.h")]
[UsedByNativeCode]
public class UnityWebRequestAsyncOperation : AsyncOperation // TypeDefIndex: 7960
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private UnityWebRequest <webRequest>k__BackingField; // 0x20

	// Properties
	internal UnityWebRequest webRequest { set; }

	// Methods

	// RVA: 0x1F25648 Offset: 0x1F21648 VA: 0x1F25648
	private void .ctor(IntPtr ptr) { }

	[CompilerGenerated]
	// RVA: 0x1F25650 Offset: 0x1F21650 VA: 0x1F25650
	internal void set_webRequest(UnityWebRequest value) { }
}

// Namespace: 
internal enum UnityWebRequest.UnityWebRequestMethod // TypeDefIndex: 7961
{
	// Fields
	public int value__; // 0x0
	public const UnityWebRequest.UnityWebRequestMethod Get = 0;
	public const UnityWebRequest.UnityWebRequestMethod Post = 1;
	public const UnityWebRequest.UnityWebRequestMethod Put = 2;
	public const UnityWebRequest.UnityWebRequestMethod Head = 3;
	public const UnityWebRequest.UnityWebRequestMethod Custom = 4;
}

// Namespace: 
internal enum UnityWebRequest.UnityWebRequestError // TypeDefIndex: 7962
{
	// Fields
	public int value__; // 0x0
	public const UnityWebRequest.UnityWebRequestError OK = 0;
	public const UnityWebRequest.UnityWebRequestError OKCached = 1;
	public const UnityWebRequest.UnityWebRequestError Unknown = 2;
	public const UnityWebRequest.UnityWebRequestError SDKError = 3;
	public const UnityWebRequest.UnityWebRequestError UnsupportedProtocol = 4;
	public const UnityWebRequest.UnityWebRequestError MalformattedUrl = 5;
	public const UnityWebRequest.UnityWebRequestError CannotResolveProxy = 6;
	public const UnityWebRequest.UnityWebRequestError CannotResolveHost = 7;
	public const UnityWebRequest.UnityWebRequestError CannotConnectToHost = 8;
	public const UnityWebRequest.UnityWebRequestError AccessDenied = 9;
	public const UnityWebRequest.UnityWebRequestError GenericHttpError = 10;
	public const UnityWebRequest.UnityWebRequestError WriteError = 11;
	public const UnityWebRequest.UnityWebRequestError ReadError = 12;
	public const UnityWebRequest.UnityWebRequestError OutOfMemory = 13;
	public const UnityWebRequest.UnityWebRequestError Timeout = 14;
	public const UnityWebRequest.UnityWebRequestError HTTPPostError = 15;
	public const UnityWebRequest.UnityWebRequestError SSLCannotConnect = 16;
	public const UnityWebRequest.UnityWebRequestError Aborted = 17;
	public const UnityWebRequest.UnityWebRequestError TooManyRedirects = 18;
	public const UnityWebRequest.UnityWebRequestError ReceivedNoData = 19;
	public const UnityWebRequest.UnityWebRequestError SSLNotSupported = 20;
	public const UnityWebRequest.UnityWebRequestError FailedToSendData = 21;
	public const UnityWebRequest.UnityWebRequestError FailedToReceiveData = 22;
	public const UnityWebRequest.UnityWebRequestError SSLCertificateError = 23;
	public const UnityWebRequest.UnityWebRequestError SSLCipherNotAvailable = 24;
	public const UnityWebRequest.UnityWebRequestError SSLCACertError = 25;
	public const UnityWebRequest.UnityWebRequestError UnrecognizedContentEncoding = 26;
	public const UnityWebRequest.UnityWebRequestError LoginFailed = 27;
	public const UnityWebRequest.UnityWebRequestError SSLShutdownFailed = 28;
	public const UnityWebRequest.UnityWebRequestError RedirectLimitInvalid = 29;
	public const UnityWebRequest.UnityWebRequestError InvalidRedirect = 30;
	public const UnityWebRequest.UnityWebRequestError CannotModifyRequest = 31;
	public const UnityWebRequest.UnityWebRequestError HeaderNameContainsInvalidCharacters = 32;
	public const UnityWebRequest.UnityWebRequestError HeaderValueContainsInvalidCharacters = 33;
	public const UnityWebRequest.UnityWebRequestError CannotOverrideSystemHeaders = 34;
	public const UnityWebRequest.UnityWebRequestError AlreadySent = 35;
	public const UnityWebRequest.UnityWebRequestError InvalidMethod = 36;
	public const UnityWebRequest.UnityWebRequestError NotImplemented = 37;
	public const UnityWebRequest.UnityWebRequestError NoInternetConnection = 38;
	public const UnityWebRequest.UnityWebRequestError DataProcessingError = 39;
	public const UnityWebRequest.UnityWebRequestError InsecureConnectionNotAllowed = 40;
}

// Namespace: 
public enum UnityWebRequest.Result // TypeDefIndex: 7963
{
	// Fields
	public int value__; // 0x0
	public const UnityWebRequest.Result InProgress = 0;
	public const UnityWebRequest.Result Success = 1;
	public const UnityWebRequest.Result ConnectionError = 2;
	public const UnityWebRequest.Result ProtocolError = 3;
	public const UnityWebRequest.Result DataProcessingError = 4;
}

// Namespace: 
internal static class UnityWebRequest.BindingsMarshaller // TypeDefIndex: 7964
{
	// Methods

	// RVA: 0x1F26CE8 Offset: 0x1F22CE8 VA: 0x1F26CE8
	public static IntPtr ConvertToNative(UnityWebRequest unityWebRequest) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UnityWebRequest.h")]
public class UnityWebRequest : IDisposable // TypeDefIndex: 7965
{
	// Fields
	internal IntPtr m_Ptr; // 0x10
	internal DownloadHandler m_DownloadHandler; // 0x18
	internal UploadHandler m_UploadHandler; // 0x20
	internal CertificateHandler m_CertificateHandler; // 0x28
	internal Uri m_Uri; // 0x30
	public const string kHttpVerbGET = "GET";
	public const string kHttpVerbHEAD = "HEAD";
	public const string kHttpVerbPOST = "POST";
	public const string kHttpVerbPUT = "PUT";
	public const string kHttpVerbCREATE = "CREATE";
	public const string kHttpVerbDELETE = "DELETE";
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposeCertificateHandlerOnDispose>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposeDownloadHandlerOnDispose>k__BackingField; // 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposeUploadHandlerOnDispose>k__BackingField; // 0x3A

	// Properties
	public bool disposeCertificateHandlerOnDispose { get; set; }
	public bool disposeDownloadHandlerOnDispose { get; set; }
	public bool disposeUploadHandlerOnDispose { get; set; }
	public string method { set; }
	public string error { get; }
	public string url { set; }
	public long responseCode { get; }
	public bool isModifiable { get; }
	public bool isDone { get; }
	public UnityWebRequest.Result result { get; }
	public float downloadProgress { get; }
	public ulong downloadedBytes { get; }
	public UploadHandler uploadHandler { get; }
	public DownloadHandler downloadHandler { get; set; }
	public CertificateHandler certificateHandler { get; }

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	[NativeConditional("ENABLE_UNITYWEBREQUEST")]
	// RVA: 0x1F256B4 Offset: 0x1F216B4 VA: 0x1F256B4
	private static string GetWebErrorString(UnityWebRequest.UnityWebRequestError err) { }

	[VisibleToOtherModules]
	// RVA: 0x1F257C4 Offset: 0x1F217C4 VA: 0x1F257C4
	internal static string GetHTTPStatusString(long responseCode) { }

	[CompilerGenerated]
	// RVA: 0x1F258D4 Offset: 0x1F218D4 VA: 0x1F258D4
	public bool get_disposeCertificateHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x1F258DC Offset: 0x1F218DC VA: 0x1F258DC
	public void set_disposeCertificateHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F258E4 Offset: 0x1F218E4 VA: 0x1F258E4
	public bool get_disposeDownloadHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x1F258EC Offset: 0x1F218EC VA: 0x1F258EC
	public void set_disposeDownloadHandlerOnDispose(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1F258F4 Offset: 0x1F218F4 VA: 0x1F258F4
	public bool get_disposeUploadHandlerOnDispose() { }

	[CompilerGenerated]
	// RVA: 0x1F258FC Offset: 0x1F218FC VA: 0x1F258FC
	public void set_disposeUploadHandlerOnDispose(bool value) { }

	[NativeThrows]
	// RVA: 0x1F25904 Offset: 0x1F21904 VA: 0x1F25904
	internal static IntPtr Create() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x1F2592C Offset: 0x1F2192C VA: 0x1F2592C
	private void Release() { }

	// RVA: 0x1F259B8 Offset: 0x1F219B8 VA: 0x1F259B8
	internal void InternalDestroy() { }

	// RVA: 0x1F25A30 Offset: 0x1F21A30 VA: 0x1F25A30
	private void InternalSetDefaults() { }

	// RVA: 0x1F25A44 Offset: 0x1F21A44 VA: 0x1F25A44
	public void .ctor() { }

	// RVA: 0x1F25A98 Offset: 0x1F21A98 VA: 0x1F25A98
	public void .ctor(string url) { }

	// RVA: 0x1F25B80 Offset: 0x1F21B80 VA: 0x1F25B80
	public void .ctor(string url, string method) { }

	// RVA: 0x1F25D80 Offset: 0x1F21D80 VA: 0x1F25D80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1F25E78 Offset: 0x1F21E78 VA: 0x1F25E78 Slot: 4
	public void Dispose() { }

	// RVA: 0x1F25E0C Offset: 0x1F21E0C VA: 0x1F25E0C
	private void DisposeHandlers() { }

	[NativeThrows]
	// RVA: 0x1F25EF8 Offset: 0x1F21EF8 VA: 0x1F25EF8
	internal UnityWebRequestAsyncOperation BeginWebRequest() { }

	// RVA: 0x1F25F98 Offset: 0x1F21F98 VA: 0x1F25F98
	public UnityWebRequestAsyncOperation SendWebRequest() { }

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x1F259E0 Offset: 0x1F219E0 VA: 0x1F259E0
	public void Abort() { }

	// RVA: 0x1F2600C Offset: 0x1F2200C VA: 0x1F2600C
	private UnityWebRequest.UnityWebRequestError SetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x1F260A8 Offset: 0x1F220A8 VA: 0x1F260A8
	internal void InternalSetMethod(UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x1F261B4 Offset: 0x1F221B4 VA: 0x1F261B4
	private UnityWebRequest.UnityWebRequestError SetCustomMethod(string customMethodName) { }

	// RVA: 0x1F26394 Offset: 0x1F22394 VA: 0x1F26394
	internal void InternalSetCustomMethod(string customMethodName) { }

	// RVA: 0x1F25BF8 Offset: 0x1F21BF8 VA: 0x1F25BF8
	public void set_method(string value) { }

	// RVA: 0x1F26450 Offset: 0x1F22450 VA: 0x1F26450
	private UnityWebRequest.UnityWebRequestError GetError() { }

	// RVA: 0x1F264DC Offset: 0x1F224DC VA: 0x1F264DC
	public string get_error() { }

	// RVA: 0x1F25AF8 Offset: 0x1F21AF8 VA: 0x1F25AF8
	public void set_url(string value) { }

	// RVA: 0x1F266F8 Offset: 0x1F226F8 VA: 0x1F266F8
	private UnityWebRequest.UnityWebRequestError SetUrl(string url) { }

	// RVA: 0x1F2663C Offset: 0x1F2263C VA: 0x1F2663C
	private void InternalSetUrl(string url) { }

	// RVA: 0x1F265EC Offset: 0x1F225EC VA: 0x1F265EC
	public long get_responseCode() { }

	// RVA: 0x1F26914 Offset: 0x1F22914 VA: 0x1F26914
	private bool IsExecuting() { }

	[NativeMethod("IsModifiable")]
	// RVA: 0x1F26164 Offset: 0x1F22164 VA: 0x1F26164
	public bool get_isModifiable() { }

	// RVA: 0x1F269DC Offset: 0x1F229DC VA: 0x1F269DC
	public bool get_isDone() { }

	[NativeMethod("GetResult")]
	// RVA: 0x1F2659C Offset: 0x1F2259C VA: 0x1F2659C
	public UnityWebRequest.Result get_result() { }

	// RVA: 0x1F26A30 Offset: 0x1F22A30 VA: 0x1F26A30
	private float GetDownloadProgress() { }

	// RVA: 0x1F26ABC Offset: 0x1F22ABC VA: 0x1F26ABC
	public float get_downloadProgress() { }

	// RVA: 0x1F26AF0 Offset: 0x1F22AF0 VA: 0x1F26AF0
	public ulong get_downloadedBytes() { }

	// RVA: 0x1F25EE8 Offset: 0x1F21EE8 VA: 0x1F25EE8
	public UploadHandler get_uploadHandler() { }

	// RVA: 0x1F26B7C Offset: 0x1F22B7C VA: 0x1F26B7C
	private UnityWebRequest.UnityWebRequestError SetDownloadHandler(DownloadHandler dh) { }

	// RVA: 0x1F25EE0 Offset: 0x1F21EE0 VA: 0x1F25EE0
	public DownloadHandler get_downloadHandler() { }

	// RVA: 0x1F26C20 Offset: 0x1F22C20 VA: 0x1F26C20
	public void set_downloadHandler(DownloadHandler value) { }

	// RVA: 0x1F25EF0 Offset: 0x1F21EF0 VA: 0x1F25EF0
	public CertificateHandler get_certificateHandler() { }

	// RVA: 0x1F25780 Offset: 0x1F21780 VA: 0x1F25780
	private static void GetWebErrorString_Injected(UnityWebRequest.UnityWebRequestError err, out ManagedSpanWrapper ret) { }

	// RVA: 0x1F25890 Offset: 0x1F21890 VA: 0x1F25890
	private static void GetHTTPStatusString_Injected(long responseCode, out ManagedSpanWrapper ret) { }

	// RVA: 0x1F2597C Offset: 0x1F2197C VA: 0x1F2597C
	private static void Release_Injected(IntPtr _unity_self) { }

	// RVA: 0x1F25F5C Offset: 0x1F21F5C VA: 0x1F25F5C
	private static IntPtr BeginWebRequest_Injected(IntPtr _unity_self) { }

	// RVA: 0x1F25FD0 Offset: 0x1F21FD0 VA: 0x1F25FD0
	private static void Abort_Injected(IntPtr _unity_self) { }

	// RVA: 0x1F26064 Offset: 0x1F22064 VA: 0x1F26064
	private static UnityWebRequest.UnityWebRequestError SetMethod_Injected(IntPtr _unity_self, UnityWebRequest.UnityWebRequestMethod methodType) { }

	// RVA: 0x1F26350 Offset: 0x1F22350 VA: 0x1F26350
	private static UnityWebRequest.UnityWebRequestError SetCustomMethod_Injected(IntPtr _unity_self, ref ManagedSpanWrapper customMethodName) { }

	// RVA: 0x1F264A0 Offset: 0x1F224A0 VA: 0x1F264A0
	private static UnityWebRequest.UnityWebRequestError GetError_Injected(IntPtr _unity_self) { }

	// RVA: 0x1F26894 Offset: 0x1F22894 VA: 0x1F26894
	private static UnityWebRequest.UnityWebRequestError SetUrl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper url) { }

	// RVA: 0x1F268D8 Offset: 0x1F228D8 VA: 0x1F268D8
	private static long get_responseCode_Injected(IntPtr _unity_self) { }

	// RVA: 0x1F26964 Offset: 0x1F22964 VA: 0x1F26964
	private static bool IsExecuting_Injected(IntPtr _unity_self) { }

	// RVA: 0x1F269A0 Offset: 0x1F229A0 VA: 0x1F269A0
	private static bool get_isModifiable_Injected(IntPtr _unity_self) { }

	// RVA: 0x1F269F4 Offset: 0x1F229F4 VA: 0x1F269F4
	private static UnityWebRequest.Result get_result_Injected(IntPtr _unity_self) { }

	// RVA: 0x1F26A80 Offset: 0x1F22A80 VA: 0x1F26A80
	private static float GetDownloadProgress_Injected(IntPtr _unity_self) { }

	// RVA: 0x1F26B40 Offset: 0x1F22B40 VA: 0x1F26B40
	private static ulong get_downloadedBytes_Injected(IntPtr _unity_self) { }

	// RVA: 0x1F26BDC Offset: 0x1F22BDC VA: 0x1F26BDC
	private static UnityWebRequest.UnityWebRequestError SetDownloadHandler_Injected(IntPtr _unity_self, IntPtr dh) { }
}

// Namespace: 
internal static class UploadHandler.BindingsMarshaller // TypeDefIndex: 7966
{
	// Methods

	// RVA: 0x1F26E3C Offset: 0x1F22E3C VA: 0x1F26E3C
	public static IntPtr ConvertToNative(UploadHandler uploadHandler) { }
}

// Namespace: UnityEngine.Networking
[NativeHeader("Modules/UnityWebRequest/Public/UploadHandler/UploadHandler.h")]
public class UploadHandler : IDisposable // TypeDefIndex: 7967
{
	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Methods

	[NativeMethod(IsThreadSafe = True)]
	// RVA: 0x1F26CFC Offset: 0x1F22CFC VA: 0x1F26CFC
	private void ReleaseFromScripting() { }

	// RVA: 0x1F26D88 Offset: 0x1F22D88 VA: 0x1F26D88
	internal void .ctor() { }

	// RVA: 0x1F26D90 Offset: 0x1F22D90 VA: 0x1F26D90 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1F26E1C Offset: 0x1F22E1C VA: 0x1F26E1C Slot: 5
	public virtual void Dispose() { }

	// RVA: 0x1F26D4C Offset: 0x1F22D4C VA: 0x1F26D4C
	private static void ReleaseFromScripting_Injected(IntPtr _unity_self) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 7968
{}
