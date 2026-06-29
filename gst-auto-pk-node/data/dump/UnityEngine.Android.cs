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

// Namespace: UnityEngine.Android
[StaticAccessor("AndroidApplication", 2)]
[NativeHeader("Modules/AndroidJNI/Public/AndroidApplication.bindings.h")]
public static class AndroidApplication // TypeDefIndex: 7616
{
	// Fields
	private static SynchronizationContext m_MainThreadSynchronizationContext; // 0x0
	private static AndroidConfiguration m_CurrentConfiguration; // 0x8
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<AndroidConfiguration> onConfigurationChanged; // 0x10

	// Properties
	internal static IntPtr UnityPlayerRaw { get; }

	// Methods

	[ThreadSafe]
	// RVA: 0x1E307A0 Offset: 0x1E2C7A0 VA: 0x1E307A0
	internal static IntPtr get_UnityPlayerRaw() { }

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x1E43CA0 Offset: 0x1E3FCA0 VA: 0x1E43CA0
	private static void AcquireMainThreadSynchronizationContext() { }

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x1E43D58 Offset: 0x1E3FD58 VA: 0x1E43D58
	private static void SetCurrentConfiguration(AndroidConfiguration config) { }

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x1E43DA8 Offset: 0x1E3FDA8 VA: 0x1E43DA8
	private static AndroidConfiguration GetCurrentConfiguration() { }

	[RequiredByNativeCode(GenerateProxy = True)]
	// RVA: 0x1E43DF0 Offset: 0x1E3FDF0 VA: 0x1E43DF0
	private static void DispatchConfigurationChanged(bool notifySubscribers) { }
}

// Namespace: UnityEngine.Android
public enum AndroidAssetPackStatus // TypeDefIndex: 7617
{
	// Fields
	public int value__; // 0x0
	public const AndroidAssetPackStatus Unknown = 0;
	public const AndroidAssetPackStatus Pending = 1;
	public const AndroidAssetPackStatus Downloading = 2;
	public const AndroidAssetPackStatus Transferring = 3;
	public const AndroidAssetPackStatus Completed = 4;
	public const AndroidAssetPackStatus Failed = 5;
	public const AndroidAssetPackStatus Canceled = 6;
	public const AndroidAssetPackStatus WaitingForWifi = 7;
	public const AndroidAssetPackStatus NotInstalled = 8;
}

// Namespace: UnityEngine.Android
public enum AndroidAssetPackError // TypeDefIndex: 7618
{
	// Fields
	public int value__; // 0x0
	public const AndroidAssetPackError NoError = 0;
	public const AndroidAssetPackError AppUnavailable = -1;
	public const AndroidAssetPackError PackUnavailable = -2;
	public const AndroidAssetPackError InvalidRequest = -3;
	public const AndroidAssetPackError DownloadNotFound = -4;
	public const AndroidAssetPackError ApiNotAvailable = -5;
	public const AndroidAssetPackError NetworkError = -6;
	public const AndroidAssetPackError AccessDenied = -7;
	public const AndroidAssetPackError InsufficientStorage = -10;
	public const AndroidAssetPackError PlayStoreNotFound = -11;
	public const AndroidAssetPackError NetworkUnrestricted = -12;
	public const AndroidAssetPackError AppNotOwned = -13;
	public const AndroidAssetPackError InternalError = -100;
}

// Namespace: UnityEngine.Android
public class AndroidAssetPackInfo // TypeDefIndex: 7619
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <name>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly AndroidAssetPackStatus <status>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ulong <size>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly ulong <bytesDownloaded>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly float <transferProgress>k__BackingField; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly AndroidAssetPackError <error>k__BackingField; // 0x34

	// Methods

	// RVA: 0x1E43E60 Offset: 0x1E3FE60 VA: 0x1E43E60
	internal void .ctor(string name, AndroidAssetPackStatus status, ulong size, ulong bytesDownloaded, float transferProgress, AndroidAssetPackError error) { }

	// RVA: 0x1E43ED0 Offset: 0x1E3FED0 VA: 0x1E43ED0
	internal static bool DownloadInProgress(AndroidAssetPackStatus status) { }
}

// Namespace: UnityEngine.Android
public class AndroidAssetPackState // TypeDefIndex: 7620
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly string <name>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly AndroidAssetPackStatus <status>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly AndroidAssetPackError <error>k__BackingField; // 0x1C

	// Methods

	// RVA: 0x1E43EEC Offset: 0x1E3FEEC VA: 0x1E43EEC
	internal void .ctor(string name, AndroidAssetPackStatus status, AndroidAssetPackError error) { }
}

// Namespace: UnityEngine.Android
public class AndroidAssetPackUseMobileDataRequestResult // TypeDefIndex: 7621
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly bool <allowed>k__BackingField; // 0x10

	// Methods

	// RVA: 0x1E43F34 Offset: 0x1E3FF34 VA: 0x1E43F34
	internal void .ctor(bool allowed) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class AndroidAssetPacks.AssetPackManagerDownloadStatusCallback.<>c // TypeDefIndex: 7622
{
	// Fields
	public static readonly AndroidAssetPacks.AssetPackManagerDownloadStatusCallback.<>c <>9; // 0x0
	public static Func<string, string> <>9__2_0; // 0x8
	public static Func<string, AndroidAssetPackStatus> <>9__2_1; // 0x10

	// Methods

	// RVA: 0x1E44794 Offset: 0x1E40794 VA: 0x1E44794
	private static void .cctor() { }

	// RVA: 0x1E447FC Offset: 0x1E407FC VA: 0x1E447FC
	public void .ctor() { }

	// RVA: 0x1E44804 Offset: 0x1E40804 VA: 0x1E44804
	internal string <.ctor>b__2_0(string ap) { }

	// RVA: 0x1E4480C Offset: 0x1E4080C VA: 0x1E4480C
	internal AndroidAssetPackStatus <.ctor>b__2_1(string ap) { }
}

// Namespace: 
private class AndroidAssetPacks.AssetPackManagerDownloadStatusCallback : AndroidJavaProxy // TypeDefIndex: 7623
{
	// Fields
	private Action<AndroidAssetPackInfo> m_Callback; // 0x20
	private Dictionary<string, AndroidAssetPackStatus> m_AssetPacks; // 0x28

	// Methods

	// RVA: 0x1E442D8 Offset: 0x1E402D8 VA: 0x1E442D8
	public void .ctor(Action<AndroidAssetPackInfo> callback, string[] assetPacks) { }

	[Preserve]
	// RVA: 0x1E444D8 Offset: 0x1E404D8 VA: 0x1E444D8
	private void onStatusUpdate(string assetPackName, int assetPackStatus, long assetPackSize, long assetPackBytesDownloaded, int assetPackTransferProgress, int assetPackErrorCode) { }
}

// Namespace: 
private class AndroidAssetPacks.AssetPackManagerMobileDataConfirmationCallback : AndroidJavaProxy // TypeDefIndex: 7624
{
	// Fields
	private Action<AndroidAssetPackUseMobileDataRequestResult> m_Callback; // 0x20

	// Methods

	// RVA: 0x1E44814 Offset: 0x1E40814 VA: 0x1E44814
	public void .ctor(Action<AndroidAssetPackUseMobileDataRequestResult> callback) { }

	[Preserve]
	// RVA: 0x1E4489C Offset: 0x1E4089C VA: 0x1E4489C
	private void onMobileDataConfirmationResult(bool allowed) { }
}

// Namespace: 
private class AndroidAssetPacks.AssetPackManagerStatusQueryCallback : AndroidJavaProxy // TypeDefIndex: 7625
{
	// Fields
	private Action<ulong, AndroidAssetPackState[]> m_Callback; // 0x20
	private List<string> m_AssetPackNames; // 0x28
	private List<AndroidAssetPackState> m_States; // 0x30
	private long m_Size; // 0x38

	// Methods

	// RVA: 0x1E44920 Offset: 0x1E40920 VA: 0x1E44920
	public void .ctor(Action<ulong, AndroidAssetPackState[]> callback, string[] assetPacks) { }

	[Preserve]
	// RVA: 0x1E44A38 Offset: 0x1E40A38 VA: 0x1E44A38
	private void onStatusResult(long totalBytes, string[] assetPackNames, int[] assetPackStatuses, int[] assetPackErrorCodes) { }
}

// Namespace: UnityEngine.Android
[NativeHeader("Modules/AndroidJNI/Public/AndroidAssetPacksBindingsHelpers.h")]
[StaticAccessor("AndroidAssetPacksBindingsHelpers", 2)]
public static class AndroidAssetPacks // TypeDefIndex: 7626
{
	// Fields
	private static AndroidJavaObject s_JavaPlayAssetDeliveryWrapper; // 0x0
	private static bool s_ApiMissing; // 0x8

	// Methods

	// RVA: 0x1E43F5C Offset: 0x1E3FF5C VA: 0x1E43F5C
	private static AndroidJavaObject GetAssetPackManager() { }
}

// Namespace: UnityEngine.Android
[StaticAccessor("GameStateHelper::Get()", 0)]
[NativeHeader("Modules/AndroidJNI/Public/GameStateHelper.h")]
public static class AndroidGame // TypeDefIndex: 7627
{
	// Methods

	// RVA: 0x1E44758 Offset: 0x1E40758 VA: 0x1E44758
	internal static void StopLoading(int label) { }
}

// Namespace: UnityEngine.Android
public enum AndroidColorModeHdr // TypeDefIndex: 7628
{
	// Fields
	public int value__; // 0x0
	public const AndroidColorModeHdr Undefined = 0;
	public const AndroidColorModeHdr No = 4;
	public const AndroidColorModeHdr Yes = 8;
}

// Namespace: UnityEngine.Android
public enum AndroidColorModeWideColorGamut // TypeDefIndex: 7629
{
	// Fields
	public int value__; // 0x0
	public const AndroidColorModeWideColorGamut Undefined = 0;
	public const AndroidColorModeWideColorGamut No = 1;
	public const AndroidColorModeWideColorGamut Yes = 2;
}

// Namespace: UnityEngine.Android
public class AndroidLocale // TypeDefIndex: 7630
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <country>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <language>k__BackingField; // 0x18

	// Properties
	public string country { get; }
	public string language { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E44DB8 Offset: 0x1E40DB8 VA: 0x1E44DB8
	public string get_country() { }

	[CompilerGenerated]
	// RVA: 0x1E44DC0 Offset: 0x1E40DC0 VA: 0x1E44DC0
	public string get_language() { }

	// RVA: 0x1E44DC8 Offset: 0x1E40DC8 VA: 0x1E44DC8
	internal void .ctor(string _country, string _language) { }
}

// Namespace: UnityEngine.Android
[NativeAsStruct]
[NativeType(Header = "Modules/AndroidJNI/Public/AndroidConfiguration.bindings.h")]
[RequiredByNativeCode]
public sealed class AndroidConfiguration // TypeDefIndex: 7631
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <colorMode>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <densityDpi>k__BackingField; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private float <fontScale>k__BackingField; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <fontWeightAdjustment>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AndroidKeyboard <keyboard>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AndroidHardwareKeyboardHidden <hardKeyboardHidden>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AndroidKeyboardHidden <keyboardHidden>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <mobileCountryCode>k__BackingField; // 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <mobileNetworkCode>k__BackingField; // 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AndroidNavigation <navigation>k__BackingField; // 0x34
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private AndroidNavigationHidden <navigationHidden>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AndroidOrientation <orientation>k__BackingField; // 0x3C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <screenHeightDp>k__BackingField; // 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <screenWidthDp>k__BackingField; // 0x44
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <smallestScreenWidthDp>k__BackingField; // 0x48
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <screenLayout>k__BackingField; // 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private AndroidTouchScreen <touchScreen>k__BackingField; // 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <uiMode>k__BackingField; // 0x54
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <primaryLocaleCountry>k__BackingField; // 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private string <primaryLocaleLanguage>k__BackingField; // 0x60

	// Properties
	private int colorMode { get; }
	public int densityDpi { get; }
	public float fontScale { get; }
	public int fontWeightAdjustment { get; }
	public AndroidKeyboard keyboard { get; }
	public AndroidHardwareKeyboardHidden hardKeyboardHidden { get; }
	public AndroidKeyboardHidden keyboardHidden { get; }
	public int mobileCountryCode { get; }
	public int mobileNetworkCode { get; }
	public AndroidNavigation navigation { get; }
	public AndroidNavigationHidden navigationHidden { get; }
	public AndroidOrientation orientation { get; }
	public int screenHeightDp { get; }
	public int screenWidthDp { get; }
	public int smallestScreenWidthDp { get; }
	private int screenLayout { get; }
	public AndroidTouchScreen touchScreen { get; }
	private int uiMode { get; }
	private string primaryLocaleCountry { get; }
	private string primaryLocaleLanguage { get; }
	public AndroidLocale[] locales { get; }
	public AndroidColorModeHdr colorModeHdr { get; }
	public AndroidColorModeWideColorGamut colorModeWideColorGamut { get; }
	public AndroidScreenLayoutDirection screenLayoutDirection { get; }
	public AndroidScreenLayoutLong screenLayoutLong { get; }
	public AndroidScreenLayoutRound screenLayoutRound { get; }
	public AndroidScreenLayoutSize screenLayoutSize { get; }
	public AndroidUIModeNight uiModeNight { get; }
	public AndroidUIModeType uiModeType { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E44E0C Offset: 0x1E40E0C VA: 0x1E44E0C
	private int get_colorMode() { }

	[CompilerGenerated]
	// RVA: 0x1E44E14 Offset: 0x1E40E14 VA: 0x1E44E14
	public int get_densityDpi() { }

	[CompilerGenerated]
	// RVA: 0x1E44E1C Offset: 0x1E40E1C VA: 0x1E44E1C
	public float get_fontScale() { }

	[CompilerGenerated]
	// RVA: 0x1E44E24 Offset: 0x1E40E24 VA: 0x1E44E24
	public int get_fontWeightAdjustment() { }

	[CompilerGenerated]
	// RVA: 0x1E44E2C Offset: 0x1E40E2C VA: 0x1E44E2C
	public AndroidKeyboard get_keyboard() { }

	[CompilerGenerated]
	// RVA: 0x1E44E34 Offset: 0x1E40E34 VA: 0x1E44E34
	public AndroidHardwareKeyboardHidden get_hardKeyboardHidden() { }

	[CompilerGenerated]
	// RVA: 0x1E44E3C Offset: 0x1E40E3C VA: 0x1E44E3C
	public AndroidKeyboardHidden get_keyboardHidden() { }

	[CompilerGenerated]
	// RVA: 0x1E44E44 Offset: 0x1E40E44 VA: 0x1E44E44
	public int get_mobileCountryCode() { }

	[CompilerGenerated]
	// RVA: 0x1E44E4C Offset: 0x1E40E4C VA: 0x1E44E4C
	public int get_mobileNetworkCode() { }

	[CompilerGenerated]
	// RVA: 0x1E44E54 Offset: 0x1E40E54 VA: 0x1E44E54
	public AndroidNavigation get_navigation() { }

	[CompilerGenerated]
	// RVA: 0x1E44E5C Offset: 0x1E40E5C VA: 0x1E44E5C
	public AndroidNavigationHidden get_navigationHidden() { }

	[CompilerGenerated]
	// RVA: 0x1E44E64 Offset: 0x1E40E64 VA: 0x1E44E64
	public AndroidOrientation get_orientation() { }

	[CompilerGenerated]
	// RVA: 0x1E44E6C Offset: 0x1E40E6C VA: 0x1E44E6C
	public int get_screenHeightDp() { }

	[CompilerGenerated]
	// RVA: 0x1E44E74 Offset: 0x1E40E74 VA: 0x1E44E74
	public int get_screenWidthDp() { }

	[CompilerGenerated]
	// RVA: 0x1E44E7C Offset: 0x1E40E7C VA: 0x1E44E7C
	public int get_smallestScreenWidthDp() { }

	[CompilerGenerated]
	// RVA: 0x1E44E84 Offset: 0x1E40E84 VA: 0x1E44E84
	private int get_screenLayout() { }

	[CompilerGenerated]
	// RVA: 0x1E44E8C Offset: 0x1E40E8C VA: 0x1E44E8C
	public AndroidTouchScreen get_touchScreen() { }

	[CompilerGenerated]
	// RVA: 0x1E44E94 Offset: 0x1E40E94 VA: 0x1E44E94
	private int get_uiMode() { }

	[CompilerGenerated]
	// RVA: 0x1E44E9C Offset: 0x1E40E9C VA: 0x1E44E9C
	private string get_primaryLocaleCountry() { }

	[CompilerGenerated]
	// RVA: 0x1E44EA4 Offset: 0x1E40EA4 VA: 0x1E44EA4
	private string get_primaryLocaleLanguage() { }

	// RVA: 0x1E44EAC Offset: 0x1E40EAC VA: 0x1E44EAC
	public AndroidLocale[] get_locales() { }

	// RVA: 0x1E44FAC Offset: 0x1E40FAC VA: 0x1E44FAC
	public AndroidColorModeHdr get_colorModeHdr() { }

	// RVA: 0x1E44FB8 Offset: 0x1E40FB8 VA: 0x1E44FB8
	public AndroidColorModeWideColorGamut get_colorModeWideColorGamut() { }

	// RVA: 0x1E44FC4 Offset: 0x1E40FC4 VA: 0x1E44FC4
	public AndroidScreenLayoutDirection get_screenLayoutDirection() { }

	// RVA: 0x1E44FD0 Offset: 0x1E40FD0 VA: 0x1E44FD0
	public AndroidScreenLayoutLong get_screenLayoutLong() { }

	// RVA: 0x1E44FDC Offset: 0x1E40FDC VA: 0x1E44FDC
	public AndroidScreenLayoutRound get_screenLayoutRound() { }

	// RVA: 0x1E44FE8 Offset: 0x1E40FE8 VA: 0x1E44FE8
	public AndroidScreenLayoutSize get_screenLayoutSize() { }

	// RVA: 0x1E44FF4 Offset: 0x1E40FF4 VA: 0x1E44FF4
	public AndroidUIModeNight get_uiModeNight() { }

	// RVA: 0x1E45000 Offset: 0x1E41000 VA: 0x1E45000
	public AndroidUIModeType get_uiModeType() { }

	[Preserve]
	// RVA: 0x1E4500C Offset: 0x1E4100C VA: 0x1E4500C Slot: 3
	public override string ToString() { }
}

// Namespace: UnityEngine.Android
public enum AndroidHardwareKeyboardHidden // TypeDefIndex: 7632
{
	// Fields
	public int value__; // 0x0
	public const AndroidHardwareKeyboardHidden Undefined = 0;
	public const AndroidHardwareKeyboardHidden No = 1;
	public const AndroidHardwareKeyboardHidden Yes = 2;
}

// Namespace: UnityEngine.Android
public enum AndroidKeyboard // TypeDefIndex: 7633
{
	// Fields
	public int value__; // 0x0
	public const AndroidKeyboard Undefined = 0;
	public const AndroidKeyboard NoKeys = 1;
	public const AndroidKeyboard Qwerty = 2;
	public const AndroidKeyboard _12Key = 3;
}

// Namespace: UnityEngine.Android
public enum AndroidKeyboardHidden // TypeDefIndex: 7634
{
	// Fields
	public int value__; // 0x0
	public const AndroidKeyboardHidden Undefined = 0;
	public const AndroidKeyboardHidden No = 1;
	public const AndroidKeyboardHidden Yes = 2;
}

// Namespace: UnityEngine.Android
public enum AndroidNavigation // TypeDefIndex: 7635
{
	// Fields
	public int value__; // 0x0
	public const AndroidNavigation Undefined = 0;
	public const AndroidNavigation NoNav = 1;
	public const AndroidNavigation Dpad = 2;
	public const AndroidNavigation TrackBall = 3;
	public const AndroidNavigation Wheel = 4;
}

// Namespace: UnityEngine.Android
public enum AndroidNavigationHidden // TypeDefIndex: 7636
{
	// Fields
	public int value__; // 0x0
	public const AndroidNavigationHidden Undefined = 0;
	public const AndroidNavigationHidden No = 1;
	public const AndroidNavigationHidden Yes = 2;
}

// Namespace: UnityEngine.Android
public enum AndroidOrientation // TypeDefIndex: 7637
{
	// Fields
	public int value__; // 0x0
	public const AndroidOrientation Undefined = 0;
	public const AndroidOrientation Portrait = 1;
	public const AndroidOrientation Landscape = 2;
}

// Namespace: UnityEngine.Android
public enum AndroidScreenLayoutDirection // TypeDefIndex: 7638
{
	// Fields
	public int value__; // 0x0
	public const AndroidScreenLayoutDirection LTR = 64;
	public const AndroidScreenLayoutDirection RTL = 128;
}

// Namespace: UnityEngine.Android
public enum AndroidScreenLayoutLong // TypeDefIndex: 7639
{
	// Fields
	public int value__; // 0x0
	public const AndroidScreenLayoutLong Undefined = 0;
	public const AndroidScreenLayoutLong No = 16;
	public const AndroidScreenLayoutLong Yes = 32;
}

// Namespace: UnityEngine.Android
public enum AndroidScreenLayoutRound // TypeDefIndex: 7640
{
	// Fields
	public int value__; // 0x0
	public const AndroidScreenLayoutRound Undefined = 0;
	public const AndroidScreenLayoutRound No = 256;
	public const AndroidScreenLayoutRound Yes = 512;
}

// Namespace: UnityEngine.Android
public enum AndroidScreenLayoutSize // TypeDefIndex: 7641
{
	// Fields
	public int value__; // 0x0
	public const AndroidScreenLayoutSize Undefined = 0;
	public const AndroidScreenLayoutSize Small = 1;
	public const AndroidScreenLayoutSize Normal = 2;
	public const AndroidScreenLayoutSize Large = 3;
	public const AndroidScreenLayoutSize XLarge = 4;
}

// Namespace: UnityEngine.Android
public enum AndroidTouchScreen // TypeDefIndex: 7642
{
	// Fields
	public int value__; // 0x0
	public const AndroidTouchScreen Undefined = 0;
	public const AndroidTouchScreen NoTouch = 1;
	public const AndroidTouchScreen Finger = 3;
}

// Namespace: UnityEngine.Android
public enum AndroidUIModeNight // TypeDefIndex: 7643
{
	// Fields
	public int value__; // 0x0
	public const AndroidUIModeNight Undefined = 0;
	public const AndroidUIModeNight No = 16;
	public const AndroidUIModeNight Yes = 32;
}

// Namespace: UnityEngine.Android
public enum AndroidUIModeType // TypeDefIndex: 7644
{
	// Fields
	public int value__; // 0x0
	public const AndroidUIModeType Undefined = 0;
	public const AndroidUIModeType Normal = 1;
	public const AndroidUIModeType Desk = 2;
	public const AndroidUIModeType Car = 3;
	public const AndroidUIModeType Television = 4;
	public const AndroidUIModeType Appliance = 5;
	public const AndroidUIModeType Watch = 6;
	public const AndroidUIModeType VrHeadset = 7;
}

// Namespace: 
internal class <Module> // TypeDefIndex: 7645
{}

// Namespace: 
internal static class SR // TypeDefIndex: 7646
{
	// Methods

	// RVA: 0x1B21D90 Offset: 0x1B1DD90 VA: 0x1B21D90
	internal static string Format(string resourceFormat, object p1) { }
}

// Namespace: 
private sealed class TaskToApm.TaskWrapperAsyncResult : IAsyncResult // TypeDefIndex: 7647
{
	// Fields
	internal readonly Task Task; // 0x10
	private readonly object _state; // 0x18
	private readonly bool _completedSynchronously; // 0x20

	// Properties
	private object System.IAsyncResult.AsyncState { get; }
	private bool System.IAsyncResult.CompletedSynchronously { get; }
	private bool System.IAsyncResult.IsCompleted { get; }
	private WaitHandle System.IAsyncResult.AsyncWaitHandle { get; }

	// Methods

	// RVA: 0x1B21EEC Offset: 0x1B1DEEC VA: 0x1B21EEC
	internal void .ctor(Task task, object state, bool completedSynchronously) { }

	// RVA: 0x1B22140 Offset: 0x1B1E140 VA: 0x1B22140 Slot: 6
	private object System.IAsyncResult.get_AsyncState() { }

	// RVA: 0x1B22148 Offset: 0x1B1E148 VA: 0x1B22148 Slot: 7
	private bool System.IAsyncResult.get_CompletedSynchronously() { }

	// RVA: 0x1B22150 Offset: 0x1B1E150 VA: 0x1B22150 Slot: 4
	private bool System.IAsyncResult.get_IsCompleted() { }

	// RVA: 0x1B22168 Offset: 0x1B1E168 VA: 0x1B22168 Slot: 5
	private WaitHandle System.IAsyncResult.get_AsyncWaitHandle() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class TaskToApm.<>c__DisplayClass3_0 // TypeDefIndex: 7648
{
	// Fields
	public AsyncCallback callback; // 0x10
	public IAsyncResult asyncResult; // 0x18

	// Methods

	// RVA: 0x1B22138 Offset: 0x1B1E138 VA: 0x1B22138
	public void .ctor() { }

	// RVA: 0x1B2220C Offset: 0x1B1E20C VA: 0x1B2220C
	internal void <InvokeCallbackWhenTaskCompletes>b__0() { }
}
