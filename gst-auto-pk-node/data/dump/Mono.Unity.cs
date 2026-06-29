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

// Namespace: Mono.Unity
internal static class CertHelper // TypeDefIndex: 3718
{
	// Methods

	// RVA: 0x1A1B470 Offset: 0x1A17470 VA: 0x1A1B470
	public static void AddCertificatesToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509CertificateCollection certificates, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1A1B610 Offset: 0x1A17610 VA: 0x1A1B610
	public static void AddCertificateToNativeChain(UnityTls.unitytls_x509list* nativeCertificateChain, X509Certificate certificate, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: Mono.Unity
internal static class Debug // TypeDefIndex: 3719
{
	// Methods

	// RVA: 0x1A1B87C Offset: 0x1A1787C VA: 0x1A1B87C
	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, string context, AlertDescription defaultAlert = 80) { }

	// RVA: 0x1A1B914 Offset: 0x1A17914 VA: 0x1A1B914
	public static void CheckAndThrow(UnityTls.unitytls_errorstate errorState, UnityTls.unitytls_x509verify_result verifyResult, string context, AlertDescription defaultAlert = 80) { }
}

// Namespace: 
public enum UnityTls.unitytls_error_code // TypeDefIndex: 3720
{
	// Fields
	public uint value__; // 0x0
	public const UnityTls.unitytls_error_code UNITYTLS_SUCCESS = 0;
	public const UnityTls.unitytls_error_code UNITYTLS_INVALID_ARGUMENT = 1;
	public const UnityTls.unitytls_error_code UNITYTLS_INVALID_FORMAT = 2;
	public const UnityTls.unitytls_error_code UNITYTLS_INVALID_PASSWORD = 3;
	public const UnityTls.unitytls_error_code UNITYTLS_INVALID_STATE = 4;
	public const UnityTls.unitytls_error_code UNITYTLS_BUFFER_OVERFLOW = 5;
	public const UnityTls.unitytls_error_code UNITYTLS_OUT_OF_MEMORY = 6;
	public const UnityTls.unitytls_error_code UNITYTLS_INTERNAL_ERROR = 7;
	public const UnityTls.unitytls_error_code UNITYTLS_NOT_SUPPORTED = 8;
	public const UnityTls.unitytls_error_code UNITYTLS_ENTROPY_SOURCE_FAILED = 9;
	public const UnityTls.unitytls_error_code UNITYTLS_STREAM_CLOSED = 10;
	public const UnityTls.unitytls_error_code UNITYTLS_DER_PARSE_ERROR = 11;
	public const UnityTls.unitytls_error_code UNITYTLS_KEY_PARSE_ERROR = 12;
	public const UnityTls.unitytls_error_code UNITYTLS_SSL_ERROR = 13;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_CUSTOM_ERROR_START = 1048576;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_WOULD_BLOCK = 1048577;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_WOULD_BLOCK_READ = 1048578;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_WOULD_BLOCK_WRITE = 1048579;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_READ_FAILED = 1048580;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_WRITE_FAILED = 1048581;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_UNKNOWN_ERROR = 1048582;
	public const UnityTls.unitytls_error_code UNITYTLS_SSL_NEEDS_VERIFY = 1048583;
	public const UnityTls.unitytls_error_code UNITYTLS_HANDSHAKE_STEP = 1048584;
	public const UnityTls.unitytls_error_code UNITYTLS_USER_CUSTOM_ERROR_END = 2097152;
}

// Namespace: 
public enum UnityTls.unitytls_log_level // TypeDefIndex: 3721
{
	// Fields
	public uint value__; // 0x0
	public const UnityTls.unitytls_log_level UNITYTLS_LOGLEVEL_MIN = 0;
	public const UnityTls.unitytls_log_level UNITYTLS_LOGLEVEL_FATAL = 0;
	public const UnityTls.unitytls_log_level UNITYTLS_LOGLEVEL_ERROR = 1;
	public const UnityTls.unitytls_log_level UNITYTLS_LOGLEVEL_WARN = 2;
	public const UnityTls.unitytls_log_level UNITYTLS_LOGLEVEL_INFO = 3;
	public const UnityTls.unitytls_log_level UNITYTLS_LOGLEVEL_DEBUG = 4;
	public const UnityTls.unitytls_log_level UNITYTLS_LOGLEVEL_TRACE = 5;
	public const UnityTls.unitytls_log_level UNITYTLS_LOGLEVEL_MAX = 5;
}

// Namespace: 
public struct UnityTls.unitytls_errorstate // TypeDefIndex: 3722
{
	// Fields
	private uint magic; // 0x0
	public UnityTls.unitytls_error_code code; // 0x4
	private ulong reserved; // 0x8
}

// Namespace: 
public struct UnityTls.unitytls_key // TypeDefIndex: 3723
{}

// Namespace: 
public struct UnityTls.unitytls_key_ref // TypeDefIndex: 3724
{
	// Fields
	public ulong handle; // 0x0
}

// Namespace: 
public struct UnityTls.unitytls_x509_ref // TypeDefIndex: 3725
{
	// Fields
	public ulong handle; // 0x0
}

// Namespace: 
public struct UnityTls.unitytls_x509list // TypeDefIndex: 3726
{}

// Namespace: 
public struct UnityTls.unitytls_x509list_ref // TypeDefIndex: 3727
{
	// Fields
	public ulong handle; // 0x0
}

// Namespace: 
[Flags]
public enum UnityTls.unitytls_x509verify_result // TypeDefIndex: 3728
{
	// Fields
	public uint value__; // 0x0
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_SUCCESS = 0;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_NOT_DONE = 2147483648;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FATAL_ERROR = 4294967295;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_EXPIRED = 1;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_REVOKED = 2;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_CN_MISMATCH = 4;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_NOT_TRUSTED = 8;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCRL_NOT_TRUSTED = 16;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCRL_EXPIRED = 32;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_MISSING = 64;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_SKIP_VERIFY = 128;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_OTHER = 256;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_FUTURE = 512;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCRL_FUTURE = 1024;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_KEY_USAGE = 2048;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_EXT_KEY_USAGE = 4096;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_NS_CERT_TYPE = 8192;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_BAD_MD = 16384;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_BAD_PK = 32768;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCERT_BAD_KEY = 65536;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCRL_BAD_MD = 131072;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCRL_BAD_PK = 262144;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_BADCRL_BAD_KEY = 524288;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR1 = 65536;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR2 = 131072;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR3 = 262144;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR4 = 524288;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR5 = 1048576;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR6 = 2097152;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR7 = 4194304;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_USER_ERROR8 = 8388608;
	public const UnityTls.unitytls_x509verify_result UNITYTLS_X509VERIFY_FLAG_UNKNOWN_ERROR = 134217728;
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_x509verify_callback : MulticastDelegate // TypeDefIndex: 3729
{
	// Methods

	// RVA: 0x1A1BA54 Offset: 0x1A17A54 VA: 0x1A1BA54
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1BB08 Offset: 0x1A17B08 VA: 0x1A1BB08 Slot: 12
	public virtual UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
public struct UnityTls.unitytls_tlsctx // TypeDefIndex: 3730
{}

// Namespace: 
public struct UnityTls.unitytls_x509name // TypeDefIndex: 3731
{}

// Namespace: 
public enum UnityTls.unitytls_ciphersuite // TypeDefIndex: 3732
{
	// Fields
	public uint value__; // 0x0
	public const UnityTls.unitytls_ciphersuite UNITYTLS_CIPHERSUITE_INVALID = 16777215;
}

// Namespace: 
public enum UnityTls.unitytls_protocol // TypeDefIndex: 3733
{
	// Fields
	public uint value__; // 0x0
	public const UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_0 = 0;
	public const UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_1 = 1;
	public const UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_TLS_1_2 = 2;
	public const UnityTls.unitytls_protocol UNITYTLS_PROTOCOL_INVALID = 3;
}

// Namespace: 
public struct UnityTls.unitytls_tlsctx_protocolrange // TypeDefIndex: 3734
{
	// Fields
	public UnityTls.unitytls_protocol min; // 0x0
	public UnityTls.unitytls_protocol max; // 0x4
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_tlsctx_write_callback : MulticastDelegate // TypeDefIndex: 3735
{
	// Methods

	// RVA: 0x1A1BB1C Offset: 0x1A17B1C VA: 0x1A1BB1C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1BBD0 Offset: 0x1A17BD0 VA: 0x1A1BBD0 Slot: 12
	public virtual IntPtr Invoke(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_tlsctx_read_callback : MulticastDelegate // TypeDefIndex: 3736
{
	// Methods

	// RVA: 0x1A1BBE4 Offset: 0x1A17BE4 VA: 0x1A1BBE4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1BC98 Offset: 0x1A17C98 VA: 0x1A1BC98 Slot: 12
	public virtual IntPtr Invoke(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_tlsctx_trace_callback : MulticastDelegate // TypeDefIndex: 3737
{
	// Methods

	// RVA: 0x1A1BCAC Offset: 0x1A17CAC VA: 0x1A1BCAC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1BD60 Offset: 0x1A17D60 VA: 0x1A1BD60 Slot: 12
	public virtual void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* traceMessage, IntPtr traceMessageLen) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_tlsctx_certificate_callback : MulticastDelegate // TypeDefIndex: 3738
{
	// Methods

	// RVA: 0x1A1BD74 Offset: 0x1A17D74 VA: 0x1A1BD74
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1BE28 Offset: 0x1A17E28 VA: 0x1A1BE28 Slot: 12
	public virtual void Invoke(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_tlsctx_x509verify_callback : MulticastDelegate // TypeDefIndex: 3739
{
	// Methods

	// RVA: 0x1A1BE48 Offset: 0x1A17E48 VA: 0x1A1BE48
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1BEFC Offset: 0x1A17EFC VA: 0x1A1BEFC Slot: 12
	public virtual UnityTls.unitytls_x509verify_result Invoke(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
public struct UnityTls.unitytls_tlsctx_callbacks // TypeDefIndex: 3740
{
	// Fields
	public UnityTls.unitytls_tlsctx_read_callback read; // 0x0
	public UnityTls.unitytls_tlsctx_write_callback write; // 0x8
	public void* data; // 0x10
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t : MulticastDelegate // TypeDefIndex: 3741
{
	// Methods

	// RVA: 0x1A1BF18 Offset: 0x1A17F18 VA: 0x1A1BF18
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1BFB4 Offset: 0x1A17FB4 VA: 0x1A1BFB4 Slot: 12
	public virtual UnityTls.unitytls_errorstate Invoke() { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t : MulticastDelegate // TypeDefIndex: 3742
{
	// Methods

	// RVA: 0x1A1BFC8 Offset: 0x1A17FC8 VA: 0x1A1BFC8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1C07C Offset: 0x1A1807C VA: 0x1A1C07C Slot: 12
	public virtual void Invoke(UnityTls.unitytls_errorstate* errorState, UnityTls.unitytls_error_code errorCode) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t : MulticastDelegate // TypeDefIndex: 3743
{
	// Methods

	// RVA: 0x1A1C090 Offset: 0x1A18090 VA: 0x1A1C090
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1C144 Offset: 0x1A18144 VA: 0x1A1C144 Slot: 12
	public virtual UnityTls.unitytls_key_ref Invoke(UnityTls.unitytls_key* key, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t : MulticastDelegate // TypeDefIndex: 3744
{
	// Methods

	// RVA: 0x1A1C158 Offset: 0x1A18158 VA: 0x1A1C158
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1C20C Offset: 0x1A1820C VA: 0x1A1C20C Slot: 12
	public virtual UnityTls.unitytls_key* Invoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t : MulticastDelegate // TypeDefIndex: 3745
{
	// Methods

	// RVA: 0x1A1C220 Offset: 0x1A18220 VA: 0x1A1C220
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1C2D4 Offset: 0x1A182D4 VA: 0x1A1C2D4 Slot: 12
	public virtual UnityTls.unitytls_key* Invoke(byte* buffer, IntPtr bufferLen, byte* password, IntPtr passwordLen, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_key_free_t : MulticastDelegate // TypeDefIndex: 3746
{
	// Methods

	// RVA: 0x1A1C2E8 Offset: 0x1A182E8 VA: 0x1A1C2E8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1C398 Offset: 0x1A18398 VA: 0x1A1C398 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_key* key) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t : MulticastDelegate // TypeDefIndex: 3747
{
	// Methods

	// RVA: 0x1A1C3AC Offset: 0x1A183AC VA: 0x1A1C3AC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1C44C Offset: 0x1A1844C VA: 0x1A1C44C Slot: 12
	public virtual IntPtr Invoke(UnityTls.unitytls_x509_ref cert, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t : MulticastDelegate // TypeDefIndex: 3748
{
	// Methods

	// RVA: 0x1A1C460 Offset: 0x1A18460 VA: 0x1A1C460
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1C514 Offset: 0x1A18514 VA: 0x1A1C514 Slot: 12
	public virtual UnityTls.unitytls_x509list_ref Invoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t : MulticastDelegate // TypeDefIndex: 3749
{
	// Methods

	// RVA: 0x1A1C528 Offset: 0x1A18528 VA: 0x1A1C528
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1C5C8 Offset: 0x1A185C8 VA: 0x1A1C5C8 Slot: 12
	public virtual UnityTls.unitytls_x509_ref Invoke(UnityTls.unitytls_x509list_ref list, IntPtr index, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_create_t : MulticastDelegate // TypeDefIndex: 3750
{
	// Methods

	// RVA: 0x1A1C5DC Offset: 0x1A185DC VA: 0x1A1C5DC
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1C68C Offset: 0x1A1868C VA: 0x1A1C68C Slot: 12
	public virtual UnityTls.unitytls_x509list* Invoke(UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_append_t : MulticastDelegate // TypeDefIndex: 3751
{
	// Methods

	// RVA: 0x1A1C6A0 Offset: 0x1A186A0 VA: 0x1A1C6A0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1C754 Offset: 0x1A18754 VA: 0x1A1C754 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_x509list* list, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t : MulticastDelegate // TypeDefIndex: 3752
{
	// Methods

	// RVA: 0x1A1C768 Offset: 0x1A18768 VA: 0x1A1C768
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1C81C Offset: 0x1A1881C VA: 0x1A1C81C Slot: 12
	public virtual void Invoke(UnityTls.unitytls_x509list* list, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509list_free_t : MulticastDelegate // TypeDefIndex: 3753
{
	// Methods

	// RVA: 0x1A1C830 Offset: 0x1A18830 VA: 0x1A1C830
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1C8E0 Offset: 0x1A188E0 VA: 0x1A1C8E0 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_x509list* list) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t : MulticastDelegate // TypeDefIndex: 3754
{
	// Methods

	// RVA: 0x1A1C8F4 Offset: 0x1A188F4 VA: 0x1A1C8F4
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1C994 Offset: 0x1A18994 VA: 0x1A1C994 Slot: 12
	public virtual UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t : MulticastDelegate // TypeDefIndex: 3755
{
	// Methods

	// RVA: 0x1A1C9A8 Offset: 0x1A189A8 VA: 0x1A1C9A8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1CA48 Offset: 0x1A18A48 VA: 0x1A1CA48 Slot: 12
	public virtual UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_x509list_ref trustCA, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t : MulticastDelegate // TypeDefIndex: 3756
{
	// Methods

	// RVA: 0x1A1CA60 Offset: 0x1A18A60 VA: 0x1A1CA60
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1CB00 Offset: 0x1A18B00 VA: 0x1A1CB00 Slot: 12
	public virtual UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, ulong certChain, ulong leafCertificateKey, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t : MulticastDelegate // TypeDefIndex: 3757
{
	// Methods

	// RVA: 0x1A1CB3C Offset: 0x1A18B3C VA: 0x1A1CB3C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1CBDC Offset: 0x1A18BDC VA: 0x1A1CBDC Slot: 12
	public virtual UnityTls.unitytls_tlsctx* Invoke(UnityTls.unitytls_tlsctx_protocolrange supportedProtocols, UnityTls.unitytls_tlsctx_callbacks callbacks, byte* cn, IntPtr cnLen, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t : MulticastDelegate // TypeDefIndex: 3758
{
	// Methods

	// RVA: 0x1A1CC18 Offset: 0x1A18C18 VA: 0x1A1CC18
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1CCCC Offset: 0x1A18CCC VA: 0x1A1CCCC Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_x509list_ref clientAuthCAList, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t : MulticastDelegate // TypeDefIndex: 3759
{
	// Methods

	// RVA: 0x1A1CCE0 Offset: 0x1A18CE0 VA: 0x1A1CCE0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1CD94 Offset: 0x1A18D94 VA: 0x1A1CD94 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_certificate_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t : MulticastDelegate // TypeDefIndex: 3760
{
	// Methods

	// RVA: 0x1A1CDA8 Offset: 0x1A18DA8 VA: 0x1A1CDA8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1CE5C Offset: 0x1A18E5C VA: 0x1A1CE5C Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_trace_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t : MulticastDelegate // TypeDefIndex: 3761
{
	// Methods

	// RVA: 0x1A1CE70 Offset: 0x1A18E70 VA: 0x1A1CE70
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1CF24 Offset: 0x1A18F24 VA: 0x1A1CF24 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_tlsctx_x509verify_callback cb, void* userData, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t : MulticastDelegate // TypeDefIndex: 3762
{
	// Methods

	// RVA: 0x1A1CF38 Offset: 0x1A18F38 VA: 0x1A1CF38
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1CFEC Offset: 0x1A18FEC VA: 0x1A1CFEC Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_ciphersuite* supportedCiphersuites, IntPtr supportedCiphersuitesLen, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t : MulticastDelegate // TypeDefIndex: 3763
{
	// Methods

	// RVA: 0x1A1D000 Offset: 0x1A19000 VA: 0x1A1D000
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1D0B4 Offset: 0x1A190B4 VA: 0x1A1D0B4 Slot: 12
	public virtual UnityTls.unitytls_ciphersuite Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t : MulticastDelegate // TypeDefIndex: 3764
{
	// Methods

	// RVA: 0x1A1D0C8 Offset: 0x1A190C8 VA: 0x1A1D0C8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1D17C Offset: 0x1A1917C VA: 0x1A1D17C Slot: 12
	public virtual UnityTls.unitytls_protocol Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t : MulticastDelegate // TypeDefIndex: 3765
{
	// Methods

	// RVA: 0x1A1D190 Offset: 0x1A19190 VA: 0x1A1D190
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1D244 Offset: 0x1A19244 VA: 0x1A1D244 Slot: 12
	public virtual UnityTls.unitytls_x509verify_result Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t : MulticastDelegate // TypeDefIndex: 3766
{
	// Methods

	// RVA: 0x1A1D258 Offset: 0x1A19258 VA: 0x1A1D258
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1D30C Offset: 0x1A1930C VA: 0x1A1D30C Slot: 12
	public virtual IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t : MulticastDelegate // TypeDefIndex: 3767
{
	// Methods

	// RVA: 0x1A1D320 Offset: 0x1A19320 VA: 0x1A1D320
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1D3D4 Offset: 0x1A193D4 VA: 0x1A1D3D4 Slot: 12
	public virtual IntPtr Invoke(UnityTls.unitytls_tlsctx* ctx, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t : MulticastDelegate // TypeDefIndex: 3768
{
	// Methods

	// RVA: 0x1A1D3E8 Offset: 0x1A193E8 VA: 0x1A1D3E8
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1D49C Offset: 0x1A1949C VA: 0x1A1D49C Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t : MulticastDelegate // TypeDefIndex: 3769
{
	// Methods

	// RVA: 0x1A1D4B0 Offset: 0x1A194B0 VA: 0x1A1D4B0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1D560 Offset: 0x1A19560 VA: 0x1A1D560 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t : MulticastDelegate // TypeDefIndex: 3770
{
	// Methods

	// RVA: 0x1A1D574 Offset: 0x1A19574 VA: 0x1A1D574
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1D628 Offset: 0x1A19628 VA: 0x1A1D628 Slot: 12
	public virtual void Invoke(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_x509verify_result_to_string_t : MulticastDelegate // TypeDefIndex: 3771
{
	// Methods

	// RVA: 0x1A1D63C Offset: 0x1A1963C VA: 0x1A1D63C
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1D6DC Offset: 0x1A196DC VA: 0x1A1D6DC Slot: 12
	public virtual char* Invoke(UnityTls.unitytls_x509verify_result v) { }
}

// Namespace: 
[UnmanagedFunctionPointer(2)]
public sealed class UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_level_t : MulticastDelegate // TypeDefIndex: 3772
{
	// Methods

	// RVA: 0x1A1D6F0 Offset: 0x1A196F0 VA: 0x1A1D6F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A1D7A4 Offset: 0x1A197A4 VA: 0x1A1D7A4 Slot: 12
	public virtual void Invoke(UnityTls.unitytls_tlsctx* ctx, UnityTls.unitytls_log_level level) { }
}

// Namespace: 
public class UnityTls.unitytls_interface_struct // TypeDefIndex: 3773
{
	// Fields
	public readonly ulong UNITYTLS_INVALID_HANDLE; // 0x10
	public readonly UnityTls.unitytls_tlsctx_protocolrange UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT; // 0x18
	public UnityTls.unitytls_interface_struct.unitytls_errorstate_create_t unitytls_errorstate_create; // 0x20
	public UnityTls.unitytls_interface_struct.unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error; // 0x28
	public UnityTls.unitytls_interface_struct.unitytls_key_get_ref_t unitytls_key_get_ref; // 0x30
	public UnityTls.unitytls_interface_struct.unitytls_key_parse_der_t unitytls_key_parse_der; // 0x38
	public UnityTls.unitytls_interface_struct.unitytls_key_parse_pem_t unitytls_key_parse_pem; // 0x40
	public UnityTls.unitytls_interface_struct.unitytls_key_free_t unitytls_key_free; // 0x48
	public UnityTls.unitytls_interface_struct.unitytls_x509_export_der_t unitytls_x509_export_der; // 0x50
	public UnityTls.unitytls_interface_struct.unitytls_x509list_get_ref_t unitytls_x509list_get_ref; // 0x58
	public UnityTls.unitytls_interface_struct.unitytls_x509list_get_x509_t unitytls_x509list_get_x509; // 0x60
	public UnityTls.unitytls_interface_struct.unitytls_x509list_create_t unitytls_x509list_create; // 0x68
	public UnityTls.unitytls_interface_struct.unitytls_x509list_append_t unitytls_x509list_append; // 0x70
	public UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_der; // 0x78
	public UnityTls.unitytls_interface_struct.unitytls_x509list_append_der_t unitytls_x509list_append_pem; // 0x80
	public UnityTls.unitytls_interface_struct.unitytls_x509list_free_t unitytls_x509list_free; // 0x88
	public UnityTls.unitytls_interface_struct.unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca; // 0x90
	public UnityTls.unitytls_interface_struct.unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca; // 0x98
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server; // 0xA0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client; // 0xA8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication; // 0xB0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback; // 0xB8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback; // 0xC0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback; // 0xC8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites; // 0xD0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite; // 0xD8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol; // 0xE0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake; // 0xE8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_read_t unitytls_tlsctx_read; // 0xF0
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_write_t unitytls_tlsctx_write; // 0xF8
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close; // 0x100
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_free_t unitytls_tlsctx_free; // 0x108
	public UnityTls.unitytls_interface_struct.unitytls_random_generate_bytes_t unitytls_random_generate_bytes; // 0x110
	public UnityTls.unitytls_interface_struct.unitytls_x509verify_result_to_string_t unitytls_x509verify_result_to_string; // 0x118
	public UnityTls.unitytls_interface_struct.unitytls_tlsctx_set_trace_level_t unitytls_tlsctx_set_trace_level; // 0x120

	// Methods

	// RVA: 0x1A1BF10 Offset: 0x1A17F10 VA: 0x1A1BF10
	public void .ctor() { }
}

// Namespace: Mono.Unity
internal static class UnityTls // TypeDefIndex: 3774
{
	// Fields
	private static UnityTls.unitytls_interface_struct marshalledInterface; // 0x0

	// Properties
	public static bool IsSupported { get; }
	public static UnityTls.unitytls_interface_struct NativeInterface { get; }

	// Methods

	// RVA: 0x1A1BA38 Offset: 0x1A17A38 VA: 0x1A1BA38
	private static IntPtr GetUnityTlsInterface() { }

	// RVA: 0x1A1BA3C Offset: 0x1A17A3C VA: 0x1A1BA3C
	public static bool get_IsSupported() { }

	// RVA: 0x1A1B7B8 Offset: 0x1A177B8 VA: 0x1A1B7B8
	public static UnityTls.unitytls_interface_struct get_NativeInterface() { }
}

// Namespace: Mono.Unity
internal class UnityTlsContext : MobileTlsContext // TypeDefIndex: 3775
{
	// Fields
	private UnityTls.unitytls_tlsctx* tlsContext; // 0x58
	private UnityTls.unitytls_x509list* requestedClientCertChain; // 0x60
	private UnityTls.unitytls_key* requestedClientKey; // 0x68
	private UnityTls.unitytls_tlsctx_read_callback readCallback; // 0x70
	private UnityTls.unitytls_tlsctx_write_callback writeCallback; // 0x78
	private UnityTls.unitytls_tlsctx_certificate_callback certificateCallback; // 0x80
	private UnityTls.unitytls_tlsctx_x509verify_callback verifyCallback; // 0x88
	private X509Certificate localClientCertificate; // 0x90
	private X509Certificate2 remoteCertificate; // 0x98
	private MonoTlsConnectionInfo connectioninfo; // 0xA0
	private bool isAuthenticated; // 0xA8
	private bool hasContext; // 0xA9
	private bool closedGraceful; // 0xAA
	private byte[] writeBuffer; // 0xB0
	private byte[] readBuffer; // 0xB8
	private GCHandle handle; // 0xC0
	private Exception lastException; // 0xC8

	// Properties
	public override bool IsAuthenticated { get; }
	internal override X509Certificate LocalClientCertificate { get; }
	public override X509Certificate2 RemoteCertificate { get; }

	// Methods

	// RVA: 0x1A1DBE0 Offset: 0x1A19BE0 VA: 0x1A1DBE0
	public void .ctor(MobileAuthenticatedStream parent, MonoSslAuthenticationOptions options) { }

	// RVA: 0x1A1E51C Offset: 0x1A1A51C VA: 0x1A1E51C
	private static void ExtractNativeKeyAndChainFromManagedCertificate(X509Certificate cert, UnityTls.unitytls_errorstate* errorState, out UnityTls.unitytls_x509list* nativeCertChain, out UnityTls.unitytls_key* nativeKey) { }

	// RVA: 0x1A1E85C Offset: 0x1A1A85C VA: 0x1A1E85C Slot: 5
	public override bool get_IsAuthenticated() { }

	// RVA: 0x1A1E864 Offset: 0x1A1A864 VA: 0x1A1E864 Slot: 9
	internal override X509Certificate get_LocalClientCertificate() { }

	// RVA: 0x1A1E86C Offset: 0x1A1A86C VA: 0x1A1E86C Slot: 10
	public override X509Certificate2 get_RemoteCertificate() { }

	// RVA: 0x1A1E874 Offset: 0x1A1A874 VA: 0x1A1E874 Slot: 11
	public override ValueTuple<int, bool> Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x1A1EA30 Offset: 0x1A1AA30 VA: 0x1A1EA30 Slot: 12
	public override ValueTuple<int, bool> Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x1A1EBE0 Offset: 0x1A1ABE0 VA: 0x1A1EBE0 Slot: 15
	public override void Renegotiate() { }

	// RVA: 0x1A1EC18 Offset: 0x1A1AC18 VA: 0x1A1EC18 Slot: 14
	public override bool PendingRenegotiation() { }

	// RVA: 0x1A1EC20 Offset: 0x1A1AC20 VA: 0x1A1EC20 Slot: 13
	public override void Shutdown() { }

	// RVA: 0x1A1ED30 Offset: 0x1A1AD30 VA: 0x1A1ED30 Slot: 16
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1A1EE28 Offset: 0x1A1AE28 VA: 0x1A1EE28 Slot: 6
	public override void StartHandshake() { }

	// RVA: 0x1A1EFA8 Offset: 0x1A1AFA8 VA: 0x1A1EFA8 Slot: 7
	public override bool ProcessHandshake() { }

	// RVA: 0x1A1F180 Offset: 0x1A1B180 VA: 0x1A1F180 Slot: 8
	public override void FinishHandshake() { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_write_callback))]
	// RVA: 0x1A1D7B8 Offset: 0x1A197B8 VA: 0x1A1D7B8
	private static IntPtr WriteCallback(void* userData, byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1A1F2DC Offset: 0x1A1B2DC VA: 0x1A1F2DC
	private IntPtr WriteCallback(byte* data, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_read_callback))]
	// RVA: 0x1A1D8C8 Offset: 0x1A198C8 VA: 0x1A1D8C8
	private static IntPtr ReadCallback(void* userData, byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1A1F71C Offset: 0x1A1B71C VA: 0x1A1F71C
	private IntPtr ReadCallback(byte* buffer, IntPtr bufferLen, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_x509verify_callback))]
	// RVA: 0x1A1D9D8 Offset: 0x1A199D8 VA: 0x1A1D9D8
	private static UnityTls.unitytls_x509verify_result VerifyCallback(void* userData, UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1A1FB40 Offset: 0x1A1BB40 VA: 0x1A1FB40
	private UnityTls.unitytls_x509verify_result VerifyCallback(UnityTls.unitytls_x509list_ref chain, UnityTls.unitytls_errorstate* errorState) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_tlsctx_certificate_callback))]
	// RVA: 0x1A1DAD0 Offset: 0x1A19AD0 VA: 0x1A1DAD0
	private static void CertificateCallback(void* userData, UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1A1FF64 Offset: 0x1A1BF64 VA: 0x1A1FF64
	private void CertificateCallback(UnityTls.unitytls_tlsctx* ctx, byte* cn, IntPtr cnLen, UnityTls.unitytls_x509name* caList, IntPtr caListLen, UnityTls.unitytls_x509list_ref* chain, UnityTls.unitytls_key_ref* key, UnityTls.unitytls_errorstate* errorState) { }
}

// Namespace: Mono.Unity
internal static class UnityTlsConversions // TypeDefIndex: 3776
{
	// Methods

	// RVA: 0x1A1E4B4 Offset: 0x1A1A4B4 VA: 0x1A1E4B4
	public static UnityTls.unitytls_protocol GetMinProtocol(SslProtocols protocols) { }

	// RVA: 0x1A1E4E4 Offset: 0x1A1A4E4 VA: 0x1A1E4E4
	public static UnityTls.unitytls_protocol GetMaxProtocol(SslProtocols protocols) { }

	// RVA: 0x1A1F2BC Offset: 0x1A1B2BC VA: 0x1A1F2BC
	public static TlsProtocols ConvertProtocolVersion(UnityTls.unitytls_protocol protocol) { }

	// RVA: 0x1A1B9E4 Offset: 0x1A179E4 VA: 0x1A1B9E4
	public static AlertDescription VerifyResultToAlertDescription(UnityTls.unitytls_x509verify_result verifyResult, AlertDescription defaultAlert = 80) { }

	// RVA: 0x1A207A0 Offset: 0x1A1C7A0 VA: 0x1A207A0
	public static SslPolicyErrors VerifyResultToPolicyErrror(UnityTls.unitytls_x509verify_result verifyResult) { }

	// RVA: 0x1A207D0 Offset: 0x1A1C7D0 VA: 0x1A207D0
	public static X509ChainStatusFlags VerifyResultToChainStatus(UnityTls.unitytls_x509verify_result verifyResult) { }
}

// Namespace: Mono.Unity
internal class UnityTlsProvider : MobileTlsProvider // TypeDefIndex: 3777
{
	// Properties
	public override string Name { get; }
	public override Guid ID { get; }
	public override bool SupportsSslStream { get; }
	public override bool SupportsMonoExtensions { get; }
	public override bool SupportsConnectionInfo { get; }
	internal override bool SupportsCleanShutdown { get; }
	public override SslProtocols SupportedProtocols { get; }

	// Methods

	// RVA: 0x1A20870 Offset: 0x1A1C870 VA: 0x1A20870 Slot: 5
	public override string get_Name() { }

	// RVA: 0x1A208B0 Offset: 0x1A1C8B0 VA: 0x1A208B0 Slot: 4
	public override Guid get_ID() { }

	// RVA: 0x1A20908 Offset: 0x1A1C908 VA: 0x1A20908 Slot: 6
	public override bool get_SupportsSslStream() { }

	// RVA: 0x1A20910 Offset: 0x1A1C910 VA: 0x1A20910 Slot: 8
	public override bool get_SupportsMonoExtensions() { }

	// RVA: 0x1A20918 Offset: 0x1A1C918 VA: 0x1A20918 Slot: 7
	public override bool get_SupportsConnectionInfo() { }

	// RVA: 0x1A20920 Offset: 0x1A1C920 VA: 0x1A20920 Slot: 10
	internal override bool get_SupportsCleanShutdown() { }

	// RVA: 0x1A20928 Offset: 0x1A1C928 VA: 0x1A20928 Slot: 9
	public override SslProtocols get_SupportedProtocols() { }

	// RVA: 0x1A20930 Offset: 0x1A1C930 VA: 0x1A20930 Slot: 11
	internal override MobileAuthenticatedStream CreateSslStream(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings) { }

	[MonoPInvokeCallback(typeof(UnityTls.unitytls_x509verify_callback))]
	// RVA: 0x1A2080C Offset: 0x1A1C80C VA: 0x1A2080C
	private static UnityTls.unitytls_x509verify_result x509verify_callback(void* userData, UnityTls.unitytls_x509_ref cert, UnityTls.unitytls_x509verify_result result, UnityTls.unitytls_errorstate* errorState) { }

	// RVA: 0x1A20A4C Offset: 0x1A1CA4C VA: 0x1A20A4C Slot: 12
	internal override bool ValidateCertificate(ChainValidationHelper validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref SslPolicyErrors errors, ref int status11) { }

	// RVA: 0x1A213DC Offset: 0x1A1D3DC VA: 0x1A213DC
	public void .ctor() { }
}

// Namespace: Mono.Unity
internal class UnityTlsStream : MobileAuthenticatedStream // TypeDefIndex: 3778
{
	// Methods

	// RVA: 0x1A209B8 Offset: 0x1A1C9B8 VA: 0x1A209B8
	public void .ctor(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MobileTlsProvider provider) { }

	// RVA: 0x1A2155C Offset: 0x1A1D55C VA: 0x1A2155C Slot: 42
	protected override MobileTlsContext CreateContext(MonoSslAuthenticationOptions options) { }
}

// Namespace: Mono.Unity
internal class X509ChainImplUnityTls : X509ChainImpl // TypeDefIndex: 3779
{
	// Fields
	private X509ChainElementCollection elements; // 0x10
	private UnityTls.unitytls_x509list* ownedList; // 0x18
	private UnityTls.unitytls_x509list_ref nativeCertificateChain; // 0x20
	private X509ChainPolicy policy; // 0x28
	private List<X509ChainStatus> chainStatusList; // 0x30
	private bool reverseOrder; // 0x38

	// Properties
	public override bool IsValid { get; }
	internal UnityTls.unitytls_x509list_ref NativeCertificateChain { get; }
	public override X509ChainElementCollection ChainElements { get; }
	public override X509ChainPolicy ChainPolicy { get; }

	// Methods

	// RVA: 0x1A1FEC8 Offset: 0x1A1BEC8 VA: 0x1A1FEC8
	internal void .ctor(UnityTls.unitytls_x509list_ref nativeCertificateChain, bool reverseOrder = False) { }

	// RVA: 0x1A21300 Offset: 0x1A1D300 VA: 0x1A21300
	internal void .ctor(UnityTls.unitytls_x509list* ownedList, UnityTls.unitytls_errorstate* errorState, bool reverseOrder = False) { }

	// RVA: 0x1A215C4 Offset: 0x1A1D5C4 VA: 0x1A215C4 Slot: 5
	public override bool get_IsValid() { }

	// RVA: 0x1A215EC Offset: 0x1A1D5EC VA: 0x1A215EC
	internal UnityTls.unitytls_x509list_ref get_NativeCertificateChain() { }

	// RVA: 0x1A215F4 Offset: 0x1A1D5F4 VA: 0x1A215F4 Slot: 6
	public override X509ChainElementCollection get_ChainElements() { }

	// RVA: 0x1A218EC Offset: 0x1A1D8EC VA: 0x1A218EC Slot: 9
	public override void AddStatus(X509ChainStatusFlags error) { }

	// RVA: 0x1A21A0C Offset: 0x1A1DA0C VA: 0x1A21A0C Slot: 7
	public override X509ChainPolicy get_ChainPolicy() { }

	// RVA: 0x1A21A14 Offset: 0x1A1DA14 VA: 0x1A21A14 Slot: 8
	public override bool Build(X509Certificate2 certificate) { }

	// RVA: 0x1A21A1C Offset: 0x1A1DA1C VA: 0x1A21A1C Slot: 10
	public override void Reset() { }

	// RVA: 0x1A21AA4 Offset: 0x1A1DAA4 VA: 0x1A21AA4 Slot: 11
	protected override void Dispose(bool disposing) { }
}
