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

// Namespace: System.Security.Cryptography
public class CryptoStream : Stream, IDisposable // TypeDefIndex: 703
{
	// Fields
	private readonly Stream _stream; // 0x28
	private readonly ICryptoTransform _transform; // 0x30
	private readonly CryptoStreamMode _transformMode; // 0x38
	private byte[] _inputBuffer; // 0x40
	private int _inputBufferIndex; // 0x48
	private int _inputBlockSize; // 0x4C
	private byte[] _outputBuffer; // 0x50
	private int _outputBufferIndex; // 0x58
	private int _outputBlockSize; // 0x5C
	private bool _canRead; // 0x60
	private bool _canWrite; // 0x61
	private bool _finalBlockTransformed; // 0x62
	private SemaphoreSlim _lazyAsyncActiveSemaphore; // 0x68
	private readonly bool _leaveOpen; // 0x70

	// Properties
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }
	public bool HasFlushedFinalBlock { get; }
	private SemaphoreSlim AsyncActiveSemaphore { get; }

	// Methods

	// RVA: 0x175C0DC Offset: 0x17580DC VA: 0x175C0DC
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode) { }

	// RVA: 0x175C0E4 Offset: 0x17580E4 VA: 0x175C0E4
	public void .ctor(Stream stream, ICryptoTransform transform, CryptoStreamMode mode, bool leaveOpen) { }

	// RVA: 0x175C444 Offset: 0x1758444 VA: 0x175C444 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x175C44C Offset: 0x175844C VA: 0x175C44C Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x175C454 Offset: 0x1758454 VA: 0x175C454 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x175C45C Offset: 0x175845C VA: 0x175C45C Slot: 11
	public override long get_Length() { }

	// RVA: 0x175C4A8 Offset: 0x17584A8 VA: 0x175C4A8 Slot: 12
	public override long get_Position() { }

	// RVA: 0x175C4F4 Offset: 0x17584F4 VA: 0x175C4F4 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x175C540 Offset: 0x1758540 VA: 0x175C540
	public bool get_HasFlushedFinalBlock() { }

	// RVA: 0x175C548 Offset: 0x1758548 VA: 0x175C548
	public void FlushFinalBlock() { }

	// RVA: 0x175C770 Offset: 0x1758770 VA: 0x175C770 Slot: 21
	public override void Flush() { }

	// RVA: 0x175C774 Offset: 0x1758774 VA: 0x175C774 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x175C7C0 Offset: 0x17587C0 VA: 0x175C7C0 Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x175C80C Offset: 0x175880C VA: 0x175C80C Slot: 24
	public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x175CAF0 Offset: 0x1758AF0 VA: 0x175CAF0 Slot: 22
	public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x175CBA4 Offset: 0x1758BA4 VA: 0x175CBA4 Slot: 23
	public override int EndRead(IAsyncResult asyncResult) { }

	[AsyncStateMachine(typeof(CryptoStream.<ReadAsyncInternal>d__37))]
	// RVA: 0x175C98C Offset: 0x175898C VA: 0x175C98C
	private Task<int> ReadAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x175CBEC Offset: 0x1758BEC VA: 0x175CBEC Slot: 34
	public override int ReadByte() { }

	// RVA: 0x175CC68 Offset: 0x1758C68 VA: 0x175CC68 Slot: 37
	public override void WriteByte(byte value) { }

	// RVA: 0x175CCBC Offset: 0x1758CBC VA: 0x175CCBC Slot: 32
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x175C854 Offset: 0x1758854 VA: 0x175C854
	private void CheckReadArguments(byte[] buffer, int offset, int count) { }

	[AsyncStateMachine(typeof(CryptoStream.<ReadAsyncCore>d__42))]
	// RVA: 0x175CD80 Offset: 0x1758D80 VA: 0x175CD80
	private Task<int> ReadAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	// RVA: 0x175CEF4 Offset: 0x1758EF4 VA: 0x175CEF4 Slot: 28
	public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x175D1A0 Offset: 0x17591A0 VA: 0x175D1A0 Slot: 26
	public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state) { }

	// RVA: 0x175D254 Offset: 0x1759254 VA: 0x175D254 Slot: 27
	public override void EndWrite(IAsyncResult asyncResult) { }

	[AsyncStateMachine(typeof(CryptoStream.<WriteAsyncInternal>d__46))]
	// RVA: 0x175D074 Offset: 0x1759074 VA: 0x175D074
	private Task WriteAsyncInternal(byte[] buffer, int offset, int count, CancellationToken cancellationToken) { }

	// RVA: 0x175D260 Offset: 0x1759260 VA: 0x175D260 Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }

	// RVA: 0x175CF3C Offset: 0x1758F3C VA: 0x175CF3C
	private void CheckWriteArguments(byte[] buffer, int offset, int count) { }

	[AsyncStateMachine(typeof(CryptoStream.<WriteAsyncCore>d__49))]
	// RVA: 0x175D2D0 Offset: 0x17592D0 VA: 0x175D2D0
	private Task WriteAsyncCore(byte[] buffer, int offset, int count, CancellationToken cancellationToken, bool useAsync) { }

	// RVA: 0x175D40C Offset: 0x175940C VA: 0x175D40C
	public void Clear() { }

	// RVA: 0x175D41C Offset: 0x175941C VA: 0x175D41C Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x175C2D0 Offset: 0x17582D0 VA: 0x175C2D0
	private void InitializeBuffer() { }

	// RVA: 0x175D4C0 Offset: 0x17594C0 VA: 0x175D4C0
	private SemaphoreSlim get_AsyncActiveSemaphore() { }
}

// Namespace: System.Security.Cryptography
public enum CryptoStreamMode // TypeDefIndex: 704
{
	// Fields
	public int value__; // 0x0
	public const CryptoStreamMode Read = 0;
	public const CryptoStreamMode Write = 1;
}

// Namespace: System.Security.Cryptography
public static class CryptographicOperations // TypeDefIndex: 705
{
	// Methods

	// RVA: 0x175EBB4 Offset: 0x175ABB4 VA: 0x175EBB4
	public static void ZeroMemory(Span<byte> buffer) { }
}

// Namespace: System.Security.Cryptography
public abstract class HashAlgorithm : IDisposable, ICryptoTransform // TypeDefIndex: 706
{
	// Fields
	private bool _disposed; // 0x10
	protected int HashSizeValue; // 0x14
	protected internal byte[] HashValue; // 0x18
	protected int State; // 0x20

	// Properties
	public virtual int HashSize { get; }
	public virtual byte[] Hash { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	public virtual bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x17600B8 Offset: 0x175C0B8 VA: 0x17600B8
	protected void .ctor() { }

	// RVA: 0x17600C0 Offset: 0x175C0C0 VA: 0x17600C0
	public static HashAlgorithm Create(string hashName) { }

	// RVA: 0x1760140 Offset: 0x175C140 VA: 0x1760140 Slot: 10
	public virtual int get_HashSize() { }

	// RVA: 0x1760148 Offset: 0x175C148 VA: 0x1760148 Slot: 11
	public virtual byte[] get_Hash() { }

	// RVA: 0x176027C Offset: 0x175C27C VA: 0x176027C
	public byte[] ComputeHash(byte[] buffer) { }

	// RVA: 0x17603DC Offset: 0x175C3DC VA: 0x17603DC
	public byte[] ComputeHash(byte[] buffer, int offset, int count) { }

	// RVA: 0x1760320 Offset: 0x175C320 VA: 0x1760320
	private byte[] CaptureHashCodeAndReinitialize() { }

	// RVA: 0x176053C Offset: 0x175C53C VA: 0x176053C Slot: 4
	public void Dispose() { }

	// RVA: 0x17605A8 Offset: 0x175C5A8 VA: 0x17605A8
	public void Clear() { }

	// RVA: 0x176063C Offset: 0x175C63C VA: 0x176063C Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x176064C Offset: 0x175C64C VA: 0x176064C Slot: 13
	public virtual int get_InputBlockSize() { }

	// RVA: 0x1760654 Offset: 0x175C654 VA: 0x1760654 Slot: 14
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x176065C Offset: 0x175C65C VA: 0x176065C Slot: 15
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x1760664 Offset: 0x175C664 VA: 0x1760664 Slot: 8
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1760844 Offset: 0x175C844 VA: 0x1760844 Slot: 9
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1760700 Offset: 0x175C700 VA: 0x1760700
	private void ValidateTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract byte[] HashFinal();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void Initialize();
}

// Namespace: System.Security.Cryptography
[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
public abstract class Aes : SymmetricAlgorithm // TypeDefIndex: 707
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Methods

	// RVA: 0x176098C Offset: 0x175C98C VA: 0x176098C
	protected void .ctor() { }

	// RVA: 0x1760A30 Offset: 0x175CA30 VA: 0x1760A30
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class AsymmetricAlgorithm : IDisposable // TypeDefIndex: 708
{
	// Fields
	protected int KeySizeValue; // 0x10
	protected KeySizes[] LegalKeySizesValue; // 0x18

	// Properties
	public virtual int KeySize { get; set; }

	// Methods

	// RVA: 0x1760BB4 Offset: 0x175CBB4 VA: 0x1760BB4
	protected void .ctor() { }

	// RVA: 0x1760BBC Offset: 0x175CBBC VA: 0x1760BBC Slot: 4
	public void Dispose() { }

	// RVA: 0x1760BC0 Offset: 0x175CBC0 VA: 0x1760BC0
	public void Clear() { }

	// RVA: 0x1760C2C Offset: 0x175CC2C VA: 0x1760C2C Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1760C30 Offset: 0x175CC30 VA: 0x1760C30 Slot: 6
	public virtual int get_KeySize() { }

	// RVA: 0x1760C38 Offset: 0x175CC38 VA: 0x1760C38 Slot: 7
	public virtual void set_KeySize(int value) { }

	// RVA: 0x1760D48 Offset: 0x175CD48 VA: 0x1760D48 Slot: 8
	public virtual void FromXmlString(string xmlString) { }

	// RVA: 0x1760D80 Offset: 0x175CD80 VA: 0x1760D80 Slot: 9
	public virtual string ToXmlString(bool includePrivateParameters) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class AsymmetricSignatureDeformatter // TypeDefIndex: 709
{
	// Methods

	// RVA: 0x1760DB8 Offset: 0x175CDB8 VA: 0x1760DB8
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetKey(AsymmetricAlgorithm key);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetHashAlgorithm(string strName);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class AsymmetricSignatureFormatter // TypeDefIndex: 710
{
	// Methods

	// RVA: 0x1760DC0 Offset: 0x175CDC0 VA: 0x1760DC0
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public enum CipherMode // TypeDefIndex: 711
{
	// Fields
	public int value__; // 0x0
	public const CipherMode CBC = 1;
	public const CipherMode ECB = 2;
	public const CipherMode OFB = 3;
	public const CipherMode CFB = 4;
	public const CipherMode CTS = 5;
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public enum PaddingMode // TypeDefIndex: 712
{
	// Fields
	public int value__; // 0x0
	public const PaddingMode None = 1;
	public const PaddingMode PKCS7 = 2;
	public const PaddingMode Zeros = 3;
	public const PaddingMode ANSIX923 = 4;
	public const PaddingMode ISO10126 = 5;
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class KeySizes // TypeDefIndex: 713
{
	// Fields
	private int m_minSize; // 0x10
	private int m_maxSize; // 0x14
	private int m_skipSize; // 0x18

	// Properties
	public int MinSize { get; }
	public int MaxSize { get; }
	public int SkipSize { get; }

	// Methods

	// RVA: 0x1760DC8 Offset: 0x175CDC8 VA: 0x1760DC8
	public int get_MinSize() { }

	// RVA: 0x1760DD0 Offset: 0x175CDD0 VA: 0x1760DD0
	public int get_MaxSize() { }

	// RVA: 0x1760DD8 Offset: 0x175CDD8 VA: 0x1760DD8
	public int get_SkipSize() { }

	// RVA: 0x1760B78 Offset: 0x175CB78 VA: 0x1760B78
	public void .ctor(int minSize, int maxSize, int skipSize) { }

	// RVA: 0x1760DE0 Offset: 0x175CDE0 VA: 0x1760DE0
	internal bool IsLegal(int keySize) { }

	// RVA: 0x1760E24 Offset: 0x175CE24 VA: 0x1760E24
	internal static bool IsLegalKeySize(KeySizes[] legalKeys, int size) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public class CryptographicException : SystemException // TypeDefIndex: 714
{
	// Methods

	// RVA: 0x1760EB8 Offset: 0x175CEB8 VA: 0x1760EB8
	public void .ctor() { }

	// RVA: 0x1760D20 Offset: 0x175CD20 VA: 0x1760D20
	public void .ctor(string message) { }

	// RVA: 0x1760F24 Offset: 0x175CF24 VA: 0x1760F24
	public void .ctor(string format, string insert) { }

	// RVA: 0x1760FBC Offset: 0x175CFBC VA: 0x1760FBC
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x1760FE4 Offset: 0x175CFE4 VA: 0x1760FE4
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public class CryptographicUnexpectedOperationException : CryptographicException // TypeDefIndex: 715
{
	// Methods

	// RVA: 0x1760FEC Offset: 0x175CFEC VA: 0x1760FEC
	public void .ctor() { }

	// RVA: 0x1760234 Offset: 0x175C234 VA: 0x1760234
	public void .ctor(string message) { }

	// RVA: 0x1761010 Offset: 0x175D010 VA: 0x1761010
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Flags]
[Serializable]
public enum CspProviderFlags // TypeDefIndex: 716
{
	// Fields
	public int value__; // 0x0
	public const CspProviderFlags NoFlags = 0;
	public const CspProviderFlags UseMachineKeyStore = 1;
	public const CspProviderFlags UseDefaultKeyContainer = 2;
	public const CspProviderFlags UseNonExportableKey = 4;
	public const CspProviderFlags UseExistingKey = 8;
	public const CspProviderFlags UseArchivableKey = 16;
	public const CspProviderFlags UseUserProtectedKey = 32;
	public const CspProviderFlags NoPrompt = 64;
	public const CspProviderFlags CreateEphemeralKey = 128;
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class CspParameters // TypeDefIndex: 717
{
	// Fields
	public int ProviderType; // 0x10
	public string ProviderName; // 0x18
	public string KeyContainerName; // 0x20
	public int KeyNumber; // 0x28
	private int m_flags; // 0x2C

	// Properties
	public CspProviderFlags Flags { get; set; }

	// Methods

	// RVA: 0x1761018 Offset: 0x175D018 VA: 0x1761018
	public CspProviderFlags get_Flags() { }

	// RVA: 0x1761020 Offset: 0x175D020 VA: 0x1761020
	public void set_Flags(CspProviderFlags value) { }

	// RVA: 0x17610FC Offset: 0x175D0FC VA: 0x17610FC
	public void .ctor() { }

	// RVA: 0x1761118 Offset: 0x175D118 VA: 0x1761118
	public void .ctor(int dwTypeIn) { }

	// RVA: 0x1761110 Offset: 0x175D110 VA: 0x1761110
	public void .ctor(int dwTypeIn, string strProviderNameIn, string strContainerNameIn) { }

	// RVA: 0x1761128 Offset: 0x175D128 VA: 0x1761128
	internal void .ctor(int providerType, string providerName, string keyContainerName, CspProviderFlags flags) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class DES : SymmetricAlgorithm // TypeDefIndex: 718
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x1761194 Offset: 0x175D194 VA: 0x1761194
	protected void .ctor() { }

	// RVA: 0x176122C Offset: 0x175D22C VA: 0x176122C Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1761650 Offset: 0x175D650 VA: 0x1761650 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1761874 Offset: 0x175D874 VA: 0x1761874
	public static DES Create() { }

	// RVA: 0x1761314 Offset: 0x175D314 VA: 0x1761314
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x1761444 Offset: 0x175D444 VA: 0x1761444
	public static bool IsSemiWeakKey(byte[] rgbKey) { }

	// RVA: 0x1761984 Offset: 0x175D984 VA: 0x1761984
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x17619A4 Offset: 0x175D9A4 VA: 0x17619A4
	private static ulong QuadWordFromBigEndian(byte[] block) { }

	// RVA: 0x1761A3C Offset: 0x175DA3C VA: 0x1761A3C
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class DESCryptoServiceProvider : DES // TypeDefIndex: 719
{
	// Methods

	// RVA: 0x17618C4 Offset: 0x175D8C4 VA: 0x17618C4
	public void .ctor() { }

	// RVA: 0x1761B7C Offset: 0x175DB7C VA: 0x1761B7C Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1761CAC Offset: 0x175DCAC VA: 0x1761CAC Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1761DDC Offset: 0x175DDDC VA: 0x1761DDC Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x1761EC0 Offset: 0x175DEC0 VA: 0x1761EC0 Slot: 25
	public override void GenerateIV() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public struct DSAParameters // TypeDefIndex: 720
{
	// Fields
	public byte[] P; // 0x0
	public byte[] Q; // 0x8
	public byte[] G; // 0x10
	public byte[] Y; // 0x18
	public byte[] J; // 0x20
	public byte[] X; // 0x28
	public byte[] Seed; // 0x30
	public int Counter; // 0x38
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class DSA : AsymmetricAlgorithm // TypeDefIndex: 721
{
	// Methods

	// RVA: 0x1761F38 Offset: 0x175DF38 VA: 0x1761F38
	protected void .ctor() { }

	// RVA: 0x1761F40 Offset: 0x175DF40 VA: 0x1761F40
	public static DSA Create() { }

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool VerifySignature(byte[] rgbHash, byte[] rgbSignature);

	// RVA: 0x1761F94 Offset: 0x175DF94 VA: 0x1761F94 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x176261C Offset: 0x175E61C VA: 0x176261C Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract DSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(DSAParameters parameters);
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class DSASignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 722
{
	// Fields
	private DSA _dsaKey; // 0x10
	private string _oid; // 0x18

	// Methods

	// RVA: 0x1762E08 Offset: 0x175EE08 VA: 0x1762E08
	public void .ctor() { }

	// RVA: 0x1762E90 Offset: 0x175EE90 VA: 0x1762E90
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x1762F8C Offset: 0x175EF8C VA: 0x1762F8C Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x1763080 Offset: 0x175F080 VA: 0x1763080 Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x1763148 Offset: 0x175F148 VA: 0x1763148 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class DSASignatureFormatter : AsymmetricSignatureFormatter // TypeDefIndex: 723
{
	// Fields
	private string _oid; // 0x10

	// Methods

	// RVA: 0x176322C Offset: 0x175F22C VA: 0x176322C
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class HMAC : KeyedHashAlgorithm // TypeDefIndex: 724
{
	// Fields
	private int blockSizeValue; // 0x30
	internal string m_hashName; // 0x38
	internal HashAlgorithm m_hash1; // 0x40
	internal HashAlgorithm m_hash2; // 0x48
	private byte[] m_inner; // 0x50
	private byte[] m_outer; // 0x58
	private bool m_hashing; // 0x60

	// Properties
	protected int BlockSizeValue { get; set; }
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x17632B4 Offset: 0x175F2B4 VA: 0x17632B4
	protected int get_BlockSizeValue() { }

	// RVA: 0x17632BC Offset: 0x175F2BC VA: 0x17632BC
	protected void set_BlockSizeValue(int value) { }

	// RVA: 0x17632C4 Offset: 0x175F2C4 VA: 0x17632C4
	private void UpdateIOPadBuffers() { }

	// RVA: 0x1763450 Offset: 0x175F450 VA: 0x1763450
	internal void InitializeKey(byte[] key) { }

	// RVA: 0x1763570 Offset: 0x175F570 VA: 0x1763570 Slot: 19
	public override byte[] get_Key() { }

	// RVA: 0x17635E8 Offset: 0x175F5E8 VA: 0x17635E8 Slot: 20
	public override void set_Key(byte[] value) { }

	// RVA: 0x176364C Offset: 0x175F64C VA: 0x176364C
	public static HMAC Create() { }

	// RVA: 0x17636DC Offset: 0x175F6DC VA: 0x17636DC Slot: 18
	public override void Initialize() { }

	// RVA: 0x1763724 Offset: 0x175F724 VA: 0x1763724 Slot: 16
	protected override void HashCore(byte[] rgb, int ib, int cb) { }

	// RVA: 0x17637AC Offset: 0x175F7AC VA: 0x17637AC Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x17638F0 Offset: 0x175F8F0 VA: 0x17638F0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1763A90 Offset: 0x175FA90 VA: 0x1763A90
	protected void .ctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACMD5 : HMAC // TypeDefIndex: 725
{
	// Methods

	// RVA: 0x1763AA8 Offset: 0x175FAA8 VA: 0x1763AA8
	public void .ctor() { }

	// RVA: 0x1763ACC Offset: 0x175FACC VA: 0x1763ACC
	public void .ctor(byte[] key) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACRIPEMD160 : HMAC // TypeDefIndex: 726
{
	// Methods

	// RVA: 0x1763BA8 Offset: 0x175FBA8 VA: 0x1763BA8
	public void .ctor() { }

	// RVA: 0x1763BCC Offset: 0x175FBCC VA: 0x1763BCC
	public void .ctor(byte[] key) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACSHA1 : HMAC // TypeDefIndex: 727
{
	// Methods

	// RVA: 0x17636B4 Offset: 0x175F6B4 VA: 0x17636B4
	public void .ctor() { }

	// RVA: 0x1763DE0 Offset: 0x175FDE0 VA: 0x1763DE0
	public void .ctor(byte[] key) { }

	// RVA: 0x1763DE8 Offset: 0x175FDE8 VA: 0x1763DE8
	public void .ctor(byte[] key, bool useManagedSha1) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACSHA256 : HMAC // TypeDefIndex: 728
{
	// Methods

	// RVA: 0x1763FFC Offset: 0x175FFFC VA: 0x1763FFC
	public void .ctor() { }

	// RVA: 0x1764020 Offset: 0x1760020 VA: 0x1764020
	public void .ctor(byte[] key) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACSHA384 : HMAC // TypeDefIndex: 729
{
	// Fields
	private bool m_useLegacyBlockSize; // 0x61

	// Properties
	private int BlockSize { get; }

	// Methods

	// RVA: 0x1764234 Offset: 0x1760234 VA: 0x1764234
	public void .ctor() { }

	// RVA: 0x1764258 Offset: 0x1760258 VA: 0x1764258
	public void .ctor(byte[] key) { }

	// RVA: 0x1764490 Offset: 0x1760490 VA: 0x1764490
	private int get_BlockSize() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACSHA512 : HMAC // TypeDefIndex: 730
{
	// Fields
	private bool m_useLegacyBlockSize; // 0x61

	// Properties
	private int BlockSize { get; }

	// Methods

	// RVA: 0x17644A8 Offset: 0x17604A8 VA: 0x17644A8
	public void .ctor() { }

	// RVA: 0x17644CC Offset: 0x17604CC VA: 0x17644CC
	public void .ctor(byte[] key) { }

	// RVA: 0x17645CC Offset: 0x17605CC VA: 0x17645CC
	private int get_BlockSize() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public interface ICryptoTransform : IDisposable // TypeDefIndex: 731
{
	// Properties
	public abstract int InputBlockSize { get; }
	public abstract int OutputBlockSize { get; }
	public abstract bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_InputBlockSize();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_OutputBlockSize();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_CanTransformMultipleBlocks();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class KeyedHashAlgorithm : HashAlgorithm // TypeDefIndex: 732
{
	// Fields
	protected byte[] KeyValue; // 0x28

	// Properties
	public virtual byte[] Key { get; set; }

	// Methods

	// RVA: 0x1763AA0 Offset: 0x175FAA0 VA: 0x1763AA0
	protected void .ctor() { }

	// RVA: 0x1763A38 Offset: 0x175FA38 VA: 0x1763A38 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17645E4 Offset: 0x17605E4 VA: 0x17645E4 Slot: 19
	public virtual byte[] get_Key() { }

	// RVA: 0x176465C Offset: 0x176065C VA: 0x176465C Slot: 20
	public virtual void set_Key(byte[] value) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class MACTripleDES : KeyedHashAlgorithm // TypeDefIndex: 733
{
	// Fields
	private ICryptoTransform m_encryptor; // 0x30
	private CryptoStream _cs; // 0x38
	private TailStream _ts; // 0x40
	private int m_bytesPerBlock; // 0x48
	private TripleDES des; // 0x50

	// Methods

	// RVA: 0x1764764 Offset: 0x1760764 VA: 0x1764764
	public void .ctor() { }

	// RVA: 0x17648C8 Offset: 0x17608C8 VA: 0x17648C8 Slot: 18
	public override void Initialize() { }

	// RVA: 0x17648D4 Offset: 0x17608D4 VA: 0x17648D4 Slot: 16
	protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }

	// RVA: 0x1764AF0 Offset: 0x1760AF0 VA: 0x1764AF0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1764CCC Offset: 0x1760CCC VA: 0x1764CCC Slot: 12
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Security.Cryptography
internal sealed class TailStream : Stream // TypeDefIndex: 734
{
	// Fields
	private byte[] _Buffer; // 0x28
	private int _BufferSize; // 0x30
	private int _BufferIndex; // 0x34
	private bool _BufferFull; // 0x38

	// Properties
	public byte[] Buffer { get; }
	public override bool CanRead { get; }
	public override bool CanSeek { get; }
	public override bool CanWrite { get; }
	public override long Length { get; }
	public override long Position { get; set; }

	// Methods

	// RVA: 0x1764A54 Offset: 0x1760A54 VA: 0x1764A54
	public void .ctor(int bufferSize) { }

	// RVA: 0x1764DB4 Offset: 0x1760DB4 VA: 0x1764DB4
	public void Clear() { }

	// RVA: 0x1764DC4 Offset: 0x1760DC4 VA: 0x1764DC4 Slot: 20
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1764C54 Offset: 0x1760C54 VA: 0x1764C54
	public byte[] get_Buffer() { }

	// RVA: 0x1764E88 Offset: 0x1760E88 VA: 0x1764E88 Slot: 7
	public override bool get_CanRead() { }

	// RVA: 0x1764E90 Offset: 0x1760E90 VA: 0x1764E90 Slot: 8
	public override bool get_CanSeek() { }

	// RVA: 0x1764E98 Offset: 0x1760E98 VA: 0x1764E98 Slot: 10
	public override bool get_CanWrite() { }

	// RVA: 0x1764EA8 Offset: 0x1760EA8 VA: 0x1764EA8 Slot: 11
	public override long get_Length() { }

	// RVA: 0x1764F00 Offset: 0x1760F00 VA: 0x1764F00 Slot: 12
	public override long get_Position() { }

	// RVA: 0x1764F58 Offset: 0x1760F58 VA: 0x1764F58 Slot: 13
	public override void set_Position(long value) { }

	// RVA: 0x1764FB0 Offset: 0x1760FB0 VA: 0x1764FB0 Slot: 21
	public override void Flush() { }

	// RVA: 0x1764FB4 Offset: 0x1760FB4 VA: 0x1764FB4 Slot: 30
	public override long Seek(long offset, SeekOrigin origin) { }

	// RVA: 0x176500C Offset: 0x176100C VA: 0x176500C Slot: 31
	public override void SetLength(long value) { }

	// RVA: 0x1765064 Offset: 0x1761064 VA: 0x1765064 Slot: 32
	public override int Read(byte[] buffer, int offset, int count) { }

	// RVA: 0x17650BC Offset: 0x17610BC VA: 0x17650BC Slot: 35
	public override void Write(byte[] buffer, int offset, int count) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class MD5 : HashAlgorithm // TypeDefIndex: 735
{
	// Methods

	// RVA: 0x176522C Offset: 0x176122C VA: 0x176522C
	protected void .ctor() { }

	// RVA: 0x176524C Offset: 0x176124C VA: 0x176524C
	public static MD5 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class RandomNumberGenerator : IDisposable // TypeDefIndex: 736
{
	// Methods

	// RVA: 0x17652A0 Offset: 0x17612A0 VA: 0x17652A0
	protected void .ctor() { }

	// RVA: 0x17652A8 Offset: 0x17612A8 VA: 0x17652A8
	public static RandomNumberGenerator Create() { }

	// RVA: 0x17652FC Offset: 0x17612FC VA: 0x17652FC Slot: 4
	public void Dispose() { }

	// RVA: 0x1765368 Offset: 0x1761368 VA: 0x1765368 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void GetBytes(byte[] data);
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class RC2 : SymmetricAlgorithm // TypeDefIndex: 737
{
	// Fields
	protected int EffectiveKeySizeValue; // 0x44
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public virtual int EffectiveKeySize { get; }
	public override int KeySize { get; set; }

	// Methods

	// RVA: 0x176536C Offset: 0x176136C VA: 0x176536C
	protected void .ctor() { }

	// RVA: 0x1765404 Offset: 0x1761404 VA: 0x1765404 Slot: 26
	public virtual int get_EffectiveKeySize() { }

	// RVA: 0x1765420 Offset: 0x1761420 VA: 0x1765420 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x1765428 Offset: 0x1761428 VA: 0x1765428 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x1765494 Offset: 0x1761494 VA: 0x1765494
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RC2CryptoServiceProvider : RC2 // TypeDefIndex: 738
{
	// Fields
	private bool m_use40bitSalt; // 0x48
	private static KeySizes[] s_legalKeySizes; // 0x0

	// Properties
	public override int EffectiveKeySize { get; }

	// Methods

	// RVA: 0x17655D4 Offset: 0x17615D4 VA: 0x17655D4
	public void .ctor() { }

	// RVA: 0x1765740 Offset: 0x1761740 VA: 0x1765740 Slot: 26
	public override int get_EffectiveKeySize() { }

	// RVA: 0x1765748 Offset: 0x1761748 VA: 0x1765748 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1765810 Offset: 0x1761810 VA: 0x1765810 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x17658D8 Offset: 0x17618D8 VA: 0x17658D8 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x1765960 Offset: 0x1761960 VA: 0x1765960 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x17659D8 Offset: 0x17619D8 VA: 0x17659D8
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class Rijndael : SymmetricAlgorithm // TypeDefIndex: 739
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Methods

	// RVA: 0x1765AAC Offset: 0x1761AAC VA: 0x1765AAC
	protected void .ctor() { }

	// RVA: 0x1765B44 Offset: 0x1761B44 VA: 0x1765B44
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RijndaelManaged : Rijndael // TypeDefIndex: 740
{
	// Methods

	// RVA: 0x1765C84 Offset: 0x1761C84 VA: 0x1765C84
	public void .ctor() { }

	// RVA: 0x1765D5C Offset: 0x1761D5C VA: 0x1765D5C Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1765E64 Offset: 0x1761E64 VA: 0x1765E64 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1765E78 Offset: 0x1761E78 VA: 0x1765E78 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x1765EB0 Offset: 0x1761EB0 VA: 0x1765EB0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1765D70 Offset: 0x1761D70 VA: 0x1765D70
	private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }
}

// Namespace: System.Security.Cryptography
[Serializable]
internal enum RijndaelManagedTransformMode // TypeDefIndex: 741
{
	// Fields
	public int value__; // 0x0
	public const RijndaelManagedTransformMode Encrypt = 0;
	public const RijndaelManagedTransformMode Decrypt = 1;
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable // TypeDefIndex: 742
{
	// Fields
	private CipherMode m_cipherMode; // 0x10
	private PaddingMode m_paddingValue; // 0x14
	private RijndaelManagedTransformMode m_transformMode; // 0x18
	private int m_blockSizeBits; // 0x1C
	private int m_blockSizeBytes; // 0x20
	private int m_inputBlockSize; // 0x24
	private int m_outputBlockSize; // 0x28
	private int[] m_encryptKeyExpansion; // 0x30
	private int[] m_decryptKeyExpansion; // 0x38
	private int m_Nr; // 0x40
	private int m_Nb; // 0x44
	private int m_Nk; // 0x48
	private int[] m_encryptindex; // 0x50
	private int[] m_decryptindex; // 0x58
	private int[] m_IV; // 0x60
	private int[] m_lastBlockBuffer; // 0x68
	private byte[] m_depadBuffer; // 0x70
	private byte[] m_shiftRegister; // 0x78
	private static readonly byte[] s_Sbox; // 0x0
	private static readonly int[] s_Rcon; // 0x8
	private static readonly int[] s_T; // 0x10
	private static readonly int[] s_TF; // 0x18
	private static readonly int[] s_iT; // 0x20
	private static readonly int[] s_iTF; // 0x28

	// Properties
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }
	public bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x1765EE8 Offset: 0x1761EE8 VA: 0x1765EE8
	internal void .ctor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	// RVA: 0x1766AD0 Offset: 0x1762AD0 VA: 0x1766AD0 Slot: 9
	public void Dispose() { }

	// RVA: 0x1766AD8 Offset: 0x1762AD8 VA: 0x1766AD8
	private void Dispose(bool disposing) { }

	// RVA: 0x1766C00 Offset: 0x1762C00 VA: 0x1766C00 Slot: 4
	public int get_InputBlockSize() { }

	// RVA: 0x1766C08 Offset: 0x1762C08 VA: 0x1766C08 Slot: 5
	public int get_OutputBlockSize() { }

	// RVA: 0x1766C10 Offset: 0x1762C10 VA: 0x1766C10 Slot: 6
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x1766C18 Offset: 0x1762C18 VA: 0x1766C18 Slot: 7
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x176863C Offset: 0x176463C VA: 0x176863C Slot: 8
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1768908 Offset: 0x1764908 VA: 0x1768908
	public void Reset() { }

	// RVA: 0x1766EE8 Offset: 0x1762EE8 VA: 0x1766EE8
	private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x1767B20 Offset: 0x1763B20 VA: 0x1767B20
	private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x176898C Offset: 0x176498C VA: 0x176898C
	private void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp) { }

	// RVA: 0x1768B5C Offset: 0x1764B5C VA: 0x1768B5C
	private void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp) { }

	// RVA: 0x176654C Offset: 0x176254C VA: 0x176654C
	private void GenerateKeyExpansion(byte[] rgbKey) { }

	// RVA: 0x1768E2C Offset: 0x1764E2C VA: 0x1768E2C
	private static int rot1(int val) { }

	// RVA: 0x1768E24 Offset: 0x1764E24 VA: 0x1768E24
	private static int rot2(int val) { }

	// RVA: 0x1768D34 Offset: 0x1764D34 VA: 0x1768D34
	private static int rot3(int val) { }

	// RVA: 0x1768D3C Offset: 0x1764D3C VA: 0x1768D3C
	private static int SubWord(int a) { }

	// RVA: 0x1768E00 Offset: 0x1764E00 VA: 0x1768E00
	private static int MulX(int x) { }

	// RVA: 0x1768E34 Offset: 0x1764E34 VA: 0x1768E34
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class RIPEMD160 : HashAlgorithm // TypeDefIndex: 743
{
	// Methods

	// RVA: 0x1769054 Offset: 0x1765054 VA: 0x1769054
	protected void .ctor() { }

	// RVA: 0x1769074 Offset: 0x1765074 VA: 0x1769074
	public static RIPEMD160 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class RIPEMD160Managed : RIPEMD160 // TypeDefIndex: 744
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateMD160; // 0x38
	private uint[] _blockDWords; // 0x40

	// Methods

	// RVA: 0x1763CA0 Offset: 0x175FCA0 VA: 0x1763CA0
	public void .ctor() { }

	// RVA: 0x1769148 Offset: 0x1765148 VA: 0x1769148 Slot: 18
	public override void Initialize() { }

	// RVA: 0x176918C Offset: 0x176518C VA: 0x176918C Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1769310 Offset: 0x1765310 VA: 0x1769310 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x17690C4 Offset: 0x17650C4 VA: 0x17690C4
	private void InitializeState() { }

	// RVA: 0x1769190 Offset: 0x1765190 VA: 0x1769190
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x1769314 Offset: 0x1765314 VA: 0x1769314
	private byte[] _EndHash() { }

	// RVA: 0x17694A4 Offset: 0x17654A4 VA: 0x17694A4
	private static void MDTransform(uint* blockDWords, uint* state, byte* block) { }

	// RVA: 0x176AB24 Offset: 0x1766B24 VA: 0x176AB24
	private static uint F(uint x, uint y, uint z) { }

	// RVA: 0x176AB30 Offset: 0x1766B30 VA: 0x176AB30
	private static uint G(uint x, uint y, uint z) { }

	// RVA: 0x176AB40 Offset: 0x1766B40 VA: 0x176AB40
	private static uint H(uint x, uint y, uint z) { }

	// RVA: 0x176AB4C Offset: 0x1766B4C VA: 0x176AB4C
	private static uint I(uint x, uint y, uint z) { }

	// RVA: 0x176AB5C Offset: 0x1766B5C VA: 0x176AB5C
	private static uint J(uint x, uint y, uint z) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
[Serializable]
public struct RSAParameters // TypeDefIndex: 745
{
	// Fields
	public byte[] Exponent; // 0x0
	public byte[] Modulus; // 0x8
	public byte[] P; // 0x10
	public byte[] Q; // 0x18
	public byte[] DP; // 0x20
	public byte[] DQ; // 0x28
	public byte[] InverseQ; // 0x30
	public byte[] D; // 0x38
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class RSA : AsymmetricAlgorithm // TypeDefIndex: 746
{
	// Methods

	// RVA: 0x176AB68 Offset: 0x1766B68 VA: 0x176AB68
	protected void .ctor() { }

	// RVA: 0x176AB70 Offset: 0x1766B70 VA: 0x176AB70
	public static RSA Create() { }

	// RVA: 0x176AC08 Offset: 0x1766C08 VA: 0x176AC08 Slot: 10
	public virtual byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x176AC60 Offset: 0x1766C60 VA: 0x176AC60 Slot: 8
	public override void FromXmlString(string xmlString) { }

	// RVA: 0x176B1F8 Offset: 0x17671F8 VA: 0x176B1F8 Slot: 9
	public override string ToXmlString(bool includePrivateParameters) { }

	// RVA: -1 Offset: -1 Slot: 11
	public abstract RSAParameters ExportParameters(bool includePrivateParameters);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void ImportParameters(RSAParameters parameters);
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 747
{
	// Fields
	private static CspProviderFlags s_UseMachineKeyStore; // 0x0
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private RSAManaged rsa; // 0x30

	// Properties
	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisible(False)]
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x176B620 Offset: 0x1767620 VA: 0x176B620
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x176ABDC Offset: 0x1766BDC VA: 0x176ABDC
	public void .ctor() { }

	// RVA: 0x176B6AC Offset: 0x17676AC VA: 0x176B6AC
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x176B674 Offset: 0x1767674 VA: 0x176B674
	public void .ctor(int dwKeySize) { }

	// RVA: 0x176B6B8 Offset: 0x17676B8 VA: 0x176B6B8
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x176B714 Offset: 0x1767714 VA: 0x176B714
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x176B95C Offset: 0x176795C VA: 0x176B95C
	private void Common(CspParameters p) { }

	// RVA: 0x176BA88 Offset: 0x1767A88 VA: 0x176BA88 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x176BB18 Offset: 0x1767B18 VA: 0x176BB18 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x176BB38 Offset: 0x1767B38 VA: 0x176BB38
	public bool get_PublicOnly() { }

	// RVA: 0x176BB50 Offset: 0x1767B50 VA: 0x176BB50 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x176BB6C Offset: 0x1767B6C VA: 0x176BB6C Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x176BCA4 Offset: 0x1767CA4 VA: 0x176BCA4 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x176BCE8 Offset: 0x1767CE8 VA: 0x176BCE8
	private HashAlgorithm GetHash(object halg) { }

	// RVA: 0x176BEF8 Offset: 0x1767EF8 VA: 0x176BEF8
	private HashAlgorithm GetHashFromString(string name) { }

	// RVA: 0x176C010 Offset: 0x1768010 VA: 0x176C010
	private string GetHashNameFromOID(string oid) { }

	// RVA: 0x176C1D4 Offset: 0x17681D4 VA: 0x176C1D4
	public bool VerifyData(byte[] buffer, object halg, byte[] signature) { }

	// RVA: 0x176C2E8 Offset: 0x17682E8 VA: 0x176C2E8
	public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature) { }

	// RVA: 0x176C408 Offset: 0x1768408 VA: 0x176C408 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x176C45C Offset: 0x176845C VA: 0x176C45C
	private void OnKeyGenerated(object sender, EventArgs e) { }

	[ComVisible(False)]
	// RVA: 0x176C4E0 Offset: 0x17684E0 VA: 0x176C4E0 Slot: 13
	public void ImportCspBlob(byte[] keyBlob) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SHA1 : HashAlgorithm // TypeDefIndex: 748
{
	// Methods

	// RVA: 0x176C7E4 Offset: 0x17687E4 VA: 0x176C7E4
	protected void .ctor() { }

	// RVA: 0x176C804 Offset: 0x1768804 VA: 0x176C804
	public static SHA1 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA1Managed : SHA1 // TypeDefIndex: 749
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA1; // 0x38
	private uint[] _expandedBuffer; // 0x40

	// Methods

	// RVA: 0x1763EBC Offset: 0x175FEBC VA: 0x1763EBC
	public void .ctor() { }

	// RVA: 0x176C8DC Offset: 0x17688DC VA: 0x176C8DC Slot: 18
	public override void Initialize() { }

	// RVA: 0x176C920 Offset: 0x1768920 VA: 0x176C920 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x176CAA4 Offset: 0x1768AA4 VA: 0x176CAA4 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x176C858 Offset: 0x1768858 VA: 0x176C858
	private void InitializeState() { }

	// RVA: 0x176C924 Offset: 0x1768924 VA: 0x176C924
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x176CAA8 Offset: 0x1768AA8 VA: 0x176CAA8
	private byte[] _EndHash() { }

	// RVA: 0x176CC38 Offset: 0x1768C38 VA: 0x176CC38
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x176D018 Offset: 0x1769018 VA: 0x176D018
	private static void SHAExpand(uint* x) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SHA256 : HashAlgorithm // TypeDefIndex: 750
{
	// Methods

	// RVA: 0x176D054 Offset: 0x1769054 VA: 0x176D054
	protected void .ctor() { }

	// RVA: 0x176D074 Offset: 0x1769074 VA: 0x176D074
	public static SHA256 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA256Managed : SHA256 // TypeDefIndex: 751
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA256; // 0x38
	private uint[] _W; // 0x40
	private static readonly uint[] _K; // 0x0

	// Methods

	// RVA: 0x17640F4 Offset: 0x17600F4 VA: 0x17640F4
	public void .ctor() { }

	// RVA: 0x176D184 Offset: 0x1769184 VA: 0x176D184 Slot: 18
	public override void Initialize() { }

	// RVA: 0x176D1C8 Offset: 0x17691C8 VA: 0x176D1C8 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x176D394 Offset: 0x1769394 VA: 0x176D394 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x176D0C4 Offset: 0x17690C4 VA: 0x176D0C4
	private void InitializeState() { }

	// RVA: 0x176D1CC Offset: 0x17691CC VA: 0x176D1CC
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x176D398 Offset: 0x1769398 VA: 0x176D398
	private byte[] _EndHash() { }

	// RVA: 0x176D528 Offset: 0x1769528 VA: 0x176D528
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x176DC40 Offset: 0x1769C40 VA: 0x176DC40
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x176DBC0 Offset: 0x1769BC0 VA: 0x176DBC0
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x176DC2C Offset: 0x1769C2C VA: 0x176DC2C
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x176DC48 Offset: 0x1769C48 VA: 0x176DC48
	private static uint sigma_0(uint x) { }

	// RVA: 0x176DCA4 Offset: 0x1769CA4 VA: 0x176DCA4
	private static uint sigma_1(uint x) { }

	// RVA: 0x176DBD0 Offset: 0x1769BD0 VA: 0x176DBD0
	private static uint Sigma_0(uint x) { }

	// RVA: 0x176DB64 Offset: 0x1769B64 VA: 0x176DB64
	private static uint Sigma_1(uint x) { }

	// RVA: 0x176DABC Offset: 0x1769ABC VA: 0x176DABC
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x176DD00 Offset: 0x1769D00 VA: 0x176DD00
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SHA384 : HashAlgorithm // TypeDefIndex: 752
{
	// Methods

	// RVA: 0x176DDA0 Offset: 0x1769DA0 VA: 0x176DDA0
	protected void .ctor() { }

	// RVA: 0x176DDC0 Offset: 0x1769DC0 VA: 0x176DDC0
	public static SHA384 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA384Managed : SHA384 // TypeDefIndex: 753
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA384; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x1764350 Offset: 0x1760350 VA: 0x1764350
	public void .ctor() { }

	// RVA: 0x176DF10 Offset: 0x1769F10 VA: 0x176DF10 Slot: 18
	public override void Initialize() { }

	// RVA: 0x176DF54 Offset: 0x1769F54 VA: 0x176DF54 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x176E11C Offset: 0x176A11C VA: 0x176E11C Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x176DE10 Offset: 0x1769E10 VA: 0x176DE10
	private void InitializeState() { }

	// RVA: 0x176DF58 Offset: 0x1769F58 VA: 0x176DF58
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x176E120 Offset: 0x176A120 VA: 0x176E120
	private byte[] _EndHash() { }

	// RVA: 0x176E2B0 Offset: 0x176A2B0 VA: 0x176E2B0
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x176E9B0 Offset: 0x176A9B0 VA: 0x176E9B0
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x176E930 Offset: 0x176A930 VA: 0x176E930
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x176E99C Offset: 0x176A99C VA: 0x176E99C
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x176E940 Offset: 0x176A940 VA: 0x176E940
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x176E8D4 Offset: 0x176A8D4 VA: 0x176E8D4
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x176E9B8 Offset: 0x176A9B8 VA: 0x176E9B8
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x176EA14 Offset: 0x176AA14 VA: 0x176EA14
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x176E82C Offset: 0x176A82C VA: 0x176E82C
	private static void SHA384Expand(ulong* x) { }

	// RVA: 0x176EA70 Offset: 0x176AA70 VA: 0x176EA70
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SHA512 : HashAlgorithm // TypeDefIndex: 754
{
	// Methods

	// RVA: 0x176EB10 Offset: 0x176AB10 VA: 0x176EB10
	protected void .ctor() { }

	// RVA: 0x176EB30 Offset: 0x176AB30 VA: 0x176EB30
	public static SHA512 Create() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA512Managed : SHA512 // TypeDefIndex: 755
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA512; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x176EB80 Offset: 0x176AB80 VA: 0x176EB80
	public void .ctor() { }

	// RVA: 0x176ED74 Offset: 0x176AD74 VA: 0x176ED74 Slot: 18
	public override void Initialize() { }

	// RVA: 0x176EDB8 Offset: 0x176ADB8 VA: 0x176EDB8 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x176EF80 Offset: 0x176AF80 VA: 0x176EF80 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x176EC74 Offset: 0x176AC74 VA: 0x176EC74
	private void InitializeState() { }

	// RVA: 0x176EDBC Offset: 0x176ADBC VA: 0x176EDBC
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x176EF84 Offset: 0x176AF84 VA: 0x176EF84
	private byte[] _EndHash() { }

	// RVA: 0x176F110 Offset: 0x176B110 VA: 0x176F110
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x176FA44 Offset: 0x176BA44 VA: 0x176FA44
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x176F9C4 Offset: 0x176B9C4 VA: 0x176F9C4
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x176FA30 Offset: 0x176BA30 VA: 0x176FA30
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x176F9D4 Offset: 0x176B9D4 VA: 0x176F9D4
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x176F968 Offset: 0x176B968 VA: 0x176F968
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x176FA4C Offset: 0x176BA4C VA: 0x176FA4C
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x176FAA8 Offset: 0x176BAA8 VA: 0x176FAA8
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x176F8C0 Offset: 0x176B8C0 VA: 0x176F8C0
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x176FB04 Offset: 0x176BB04 VA: 0x176FB04
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SignatureDescription // TypeDefIndex: 756
{
	// Fields
	private string _strKey; // 0x10
	private string _strDigest; // 0x18
	private string _strFormatter; // 0x20
	private string _strDeformatter; // 0x28

	// Properties
	public string KeyAlgorithm { set; }
	public string DigestAlgorithm { set; }
	public string FormatterAlgorithm { set; }
	public string DeformatterAlgorithm { set; }

	// Methods

	// RVA: 0x176FBA4 Offset: 0x176BBA4 VA: 0x176FBA4
	public void .ctor() { }

	// RVA: 0x176FBAC Offset: 0x176BBAC VA: 0x176FBAC
	public void set_KeyAlgorithm(string value) { }

	// RVA: 0x176FBB4 Offset: 0x176BBB4 VA: 0x176FBB4
	public void set_DigestAlgorithm(string value) { }

	// RVA: 0x176FBBC Offset: 0x176BBBC VA: 0x176FBBC
	public void set_FormatterAlgorithm(string value) { }

	// RVA: 0x176FBC4 Offset: 0x176BBC4 VA: 0x176FBC4
	public void set_DeformatterAlgorithm(string value) { }
}

// Namespace: System.Security.Cryptography
internal abstract class RSAPKCS1SignatureDescription : SignatureDescription // TypeDefIndex: 757
{
	// Fields
	private string _hashAlgorithm; // 0x30

	// Methods

	// RVA: 0x176FBCC Offset: 0x176BBCC VA: 0x176FBCC
	protected void .ctor(string hashAlgorithm, string digestAlgorithm) { }
}

// Namespace: System.Security.Cryptography
internal class RSAPKCS1SHA1SignatureDescription : RSAPKCS1SignatureDescription // TypeDefIndex: 758
{
	// Methods

	// RVA: 0x176FCA4 Offset: 0x176BCA4 VA: 0x176FCA4
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class RSAPKCS1SHA256SignatureDescription : RSAPKCS1SignatureDescription // TypeDefIndex: 759
{
	// Methods

	// RVA: 0x176FD0C Offset: 0x176BD0C VA: 0x176FD0C
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class RSAPKCS1SHA384SignatureDescription : RSAPKCS1SignatureDescription // TypeDefIndex: 760
{
	// Methods

	// RVA: 0x176FD74 Offset: 0x176BD74 VA: 0x176FD74
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class RSAPKCS1SHA512SignatureDescription : RSAPKCS1SignatureDescription // TypeDefIndex: 761
{
	// Methods

	// RVA: 0x176FDDC Offset: 0x176BDDC VA: 0x176FDDC
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class DSASignatureDescription : SignatureDescription // TypeDefIndex: 762
{
	// Methods

	// RVA: 0x176FE44 Offset: 0x176BE44 VA: 0x176FE44
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SymmetricAlgorithm : IDisposable // TypeDefIndex: 763
{
	// Fields
	protected int BlockSizeValue; // 0x10
	protected int FeedbackSizeValue; // 0x14
	protected byte[] IVValue; // 0x18
	protected byte[] KeyValue; // 0x20
	protected KeySizes[] LegalBlockSizesValue; // 0x28
	protected KeySizes[] LegalKeySizesValue; // 0x30
	protected int KeySizeValue; // 0x38
	protected CipherMode ModeValue; // 0x3C
	protected PaddingMode PaddingValue; // 0x40

	// Properties
	public virtual int BlockSize { get; set; }
	public virtual int FeedbackSize { get; }
	public virtual byte[] IV { get; set; }
	public virtual byte[] Key { get; set; }
	public virtual KeySizes[] LegalKeySizes { get; }
	public virtual int KeySize { get; set; }
	public virtual CipherMode Mode { get; set; }
	public virtual PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x176FF18 Offset: 0x176BF18 VA: 0x176FF18
	protected void .ctor() { }

	// RVA: 0x176FF3C Offset: 0x176BF3C VA: 0x176FF3C Slot: 4
	public void Dispose() { }

	// RVA: 0x176FFA8 Offset: 0x176BFA8 VA: 0x176FFA8
	public void Clear() { }

	// RVA: 0x177003C Offset: 0x176C03C VA: 0x177003C Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x17700B4 Offset: 0x176C0B4 VA: 0x17700B4 Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x17700BC Offset: 0x176C0BC VA: 0x17700BC Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x17701BC Offset: 0x176C1BC VA: 0x17701BC Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x17701C4 Offset: 0x176C1C4 VA: 0x17701C4 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x1770258 Offset: 0x176C258 VA: 0x1770258 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x17703B8 Offset: 0x176C3B8 VA: 0x17703B8 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x177044C Offset: 0x176C44C VA: 0x177044C Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x1770668 Offset: 0x176C668 VA: 0x1770668 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x17706E0 Offset: 0x176C6E0 VA: 0x17706E0 Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x17706E8 Offset: 0x176C6E8 VA: 0x17706E8 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0x177076C Offset: 0x176C76C VA: 0x177076C Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x1770774 Offset: 0x176C774 VA: 0x1770774 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x17707E0 Offset: 0x176C7E0 VA: 0x17707E0 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x17707E8 Offset: 0x176C7E8 VA: 0x17707E8 Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x17705C8 Offset: 0x176C5C8 VA: 0x17705C8
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x1770854 Offset: 0x176C854 VA: 0x1770854
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x177094C Offset: 0x176C94C VA: 0x177094C Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: 0x177099C Offset: 0x176C99C VA: 0x177099C Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV();
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class TripleDES : SymmetricAlgorithm // TypeDefIndex: 764
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x17709EC Offset: 0x176C9EC VA: 0x17709EC
	protected void .ctor() { }

	// RVA: 0x1770A90 Offset: 0x176CA90 VA: 0x1770A90 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1770C90 Offset: 0x176CC90 VA: 0x1770C90 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1770E8C Offset: 0x176CE8C VA: 0x1770E8C
	public static TripleDES Create() { }

	// RVA: 0x1770B58 Offset: 0x176CB58 VA: 0x1770B58
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x1771024 Offset: 0x176D024 VA: 0x1771024
	private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count) { }

	// RVA: 0x1770F3C Offset: 0x176CF3C VA: 0x1770F3C
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x17711B8 Offset: 0x176D1B8 VA: 0x17711B8
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class TripleDESCryptoServiceProvider : TripleDES // TypeDefIndex: 765
{
	// Methods

	// RVA: 0x1770EDC Offset: 0x176CEDC VA: 0x1770EDC
	public void .ctor() { }

	// RVA: 0x1771300 Offset: 0x176D300 VA: 0x1771300 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x177173C Offset: 0x176D73C VA: 0x177173C Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x1771844 Offset: 0x176D844 VA: 0x1771844 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x17719B8 Offset: 0x176D9B8 VA: 0x17719B8 Slot: 25
	public override void GenerateIV() { }
}

// Namespace: System.Security.Cryptography
internal static class Utils // TypeDefIndex: 766
{
	// Fields
	private static RNGCryptoServiceProvider _rng; // 0x0

	// Properties
	internal static RNGCryptoServiceProvider StaticRandomNumberGenerator { get; }

	// Methods

	// RVA: 0x1771910 Offset: 0x176D910 VA: 0x1771910
	internal static RNGCryptoServiceProvider get_StaticRandomNumberGenerator() { }

	// RVA: 0x1771AA0 Offset: 0x176DAA0 VA: 0x1771AA0
	internal static byte[] GenerateRandom(int keySize) { }

	// RVA: 0x17712F8 Offset: 0x176D2F8 VA: 0x17712F8
	internal static bool HasAlgorithm(int dwCalg, int dwKeySize) { }

	// RVA: 0x1771B10 Offset: 0x176DB10 VA: 0x1771B10
	internal static string DiscardWhiteSpaces(string inputBuffer) { }

	// RVA: 0x1771B28 Offset: 0x176DB28 VA: 0x1771B28
	internal static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1771CA4 Offset: 0x176DCA4 VA: 0x1771CA4
	internal static int ConvertByteArrayToInt(byte[] input) { }

	// RVA: 0x1771CFC Offset: 0x176DCFC VA: 0x1771CFC
	internal static byte[] ConvertIntToByteArray(int dwInput) { }

	// RVA: 0x1770F58 Offset: 0x176CF58 VA: 0x1770F58
	internal static byte[] FixupKeyParity(byte[] key) { }

	// RVA: 0x1771E14 Offset: 0x176DE14 VA: 0x1771E14
	internal static void DWORDFromLittleEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x1771E60 Offset: 0x176DE60 VA: 0x1771E60
	internal static void DWORDToLittleEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x1771F50 Offset: 0x176DF50 VA: 0x1771F50
	internal static void DWORDFromBigEndian(uint* x, int digits, byte* block) { }

	// RVA: 0x1771FA0 Offset: 0x176DFA0 VA: 0x1771FA0
	internal static void DWORDToBigEndian(byte[] block, uint[] x, int digits) { }

	// RVA: 0x176F840 Offset: 0x176B840 VA: 0x176F840
	internal static void QuadWordFromBigEndian(ulong* x, int digits, byte* block) { }

	// RVA: 0x176F688 Offset: 0x176B688 VA: 0x176F688
	internal static void QuadWordToBigEndian(byte[] block, ulong[] x, int digits) { }

	// RVA: 0x1772090 Offset: 0x176E090 VA: 0x1772090
	internal static bool _ProduceLegacyHmacValues() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class CryptoConfig // TypeDefIndex: 767
{
	// Fields
	private static readonly object lockObject; // 0x0
	private static Dictionary<string, Type> algorithms; // 0x8

	// Properties
	[MonoLimitation("nothing is FIPS certified so it never make sense to restrict to this (empty) subset")]
	public static bool AllowOnlyFipsAlgorithms { get; }

	// Methods

	// RVA: 0x17708F4 Offset: 0x176C8F4 VA: 0x17708F4
	public static object CreateFromName(string name) { }

	// RVA: 0x1772098 Offset: 0x176E098 VA: 0x1772098
	public static object CreateFromName(string name, object[] args) { }

	// RVA: 0x17740E4 Offset: 0x17700E4 VA: 0x17740E4
	public static string MapNameToOID(string name) { }

	// RVA: 0x17748B8 Offset: 0x17708B8 VA: 0x17748B8
	public static byte[] EncodeOID(string str) { }

	// RVA: 0x1774CB8 Offset: 0x1770CB8 VA: 0x1774CB8
	private static byte[] EncodeLongNumber(long x) { }

	// RVA: 0x176EC6C Offset: 0x176AC6C VA: 0x176EC6C
	public static bool get_AllowOnlyFipsAlgorithms() { }

	// RVA: 0x1774E14 Offset: 0x1770E14 VA: 0x1774E14
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
internal class DESTransform : SymmetricTransform // TypeDefIndex: 768
{
	// Fields
	internal static readonly int KEY_BIT_SIZE; // 0x0
	internal static readonly int KEY_BYTE_SIZE; // 0x4
	internal static readonly int BLOCK_BIT_SIZE; // 0x8
	internal static readonly int BLOCK_BYTE_SIZE; // 0xC
	private byte[] keySchedule; // 0x58
	private byte[] byteBuff; // 0x60
	private uint[] dwordBuff; // 0x68
	private static readonly uint[] spBoxes; // 0x10
	private static readonly byte[] PC1; // 0x18
	private static readonly byte[] leftRotTotal; // 0x20
	private static readonly byte[] PC2; // 0x28
	internal static readonly uint[] ipTab; // 0x30
	internal static readonly uint[] fpTab; // 0x38

	// Methods

	// RVA: 0x1774E90 Offset: 0x1770E90 VA: 0x1774E90
	internal void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x177552C Offset: 0x177152C VA: 0x177552C
	private uint CipherFunct(uint r, int n) { }

	// RVA: 0x1775758 Offset: 0x1771758 VA: 0x1775758
	internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap) { }

	// RVA: 0x1775A14 Offset: 0x1771A14 VA: 0x1775A14
	private static void BSwap(byte[] byteBuff) { }

	// RVA: 0x17751A4 Offset: 0x17711A4 VA: 0x17751A4
	internal void SetKey(byte[] key) { }

	// RVA: 0x1775A74 Offset: 0x1771A74 VA: 0x1775A74
	public void ProcessBlock(byte[] input, byte[] output) { }

	// RVA: 0x1775E10 Offset: 0x1771E10 VA: 0x1775E10 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x17750D4 Offset: 0x17710D4 VA: 0x17750D4
	internal static byte[] GetStrongKey() { }

	// RVA: 0x1775EB4 Offset: 0x1771EB4 VA: 0x1775EB4
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class DSACryptoServiceProvider : DSA // TypeDefIndex: 769
{
	// Fields
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private DSAManaged dsa; // 0x30
	private static bool useMachineKeyStore; // 0x0

	// Properties
	public override int KeySize { get; }
	[ComVisible(False)]
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x1773F74 Offset: 0x176FF74 VA: 0x1773F74
	public void .ctor() { }

	// RVA: 0x17760E0 Offset: 0x17720E0 VA: 0x17760E0
	public void .ctor(int dwKeySize) { }

	// RVA: 0x1776118 Offset: 0x1772118 VA: 0x1776118
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x1776368 Offset: 0x1772368 VA: 0x1776368 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17763F8 Offset: 0x17723F8 VA: 0x17763F8 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x1776414 Offset: 0x1772414 VA: 0x1776414
	public bool get_PublicOnly() { }

	// RVA: 0x177642C Offset: 0x177242C VA: 0x177642C Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x17764D8 Offset: 0x17724D8 VA: 0x17764D8 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x177651C Offset: 0x177251C VA: 0x177651C Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x1776538 Offset: 0x1772538 VA: 0x1776538 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x177658C Offset: 0x177258C VA: 0x177658C
	private void OnKeyGenerated(object sender, EventArgs e) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class MD5CryptoServiceProvider : MD5 // TypeDefIndex: 770
{
	// Fields
	private uint[] _H; // 0x28
	private uint[] buff; // 0x30
	private ulong count; // 0x38
	private byte[] _ProcessingBuffer; // 0x40
	private int _ProcessingBufferCount; // 0x48
	private static readonly uint[] K; // 0x0

	// Methods

	// RVA: 0x1773FA0 Offset: 0x176FFA0 VA: 0x1773FA0
	public void .ctor() { }

	// RVA: 0x1776610 Offset: 0x1772610 VA: 0x1776610 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17766A0 Offset: 0x17726A0 VA: 0x17766A0 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1776710 Offset: 0x1772710 VA: 0x1776710 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x1777480 Offset: 0x1773480 VA: 0x1777480 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x1777710 Offset: 0x1773710 VA: 0x1777710 Slot: 18
	public override void Initialize() { }

	// RVA: 0x1776810 Offset: 0x1772810 VA: 0x1776810
	private void ProcessBlock(byte[] inputBuffer, int inputOffset) { }

	// RVA: 0x1777558 Offset: 0x1773558 VA: 0x1777558
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1777784 Offset: 0x1773784 VA: 0x1777784
	internal void AddLength(ulong length, byte[] buffer, int position) { }

	// RVA: 0x1777874 Offset: 0x1773874 VA: 0x1777874
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
internal class RC2Transform : SymmetricTransform // TypeDefIndex: 771
{
	// Fields
	private ushort R0; // 0x58
	private ushort R1; // 0x5A
	private ushort R2; // 0x5C
	private ushort R3; // 0x5E
	private ushort[] K; // 0x60
	private int j; // 0x68
	private static readonly byte[] pitable; // 0x0

	// Methods

	// RVA: 0x1777914 Offset: 0x1773914 VA: 0x1777914
	public void .ctor(RC2 rc2Algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x1777E4C Offset: 0x1773E4C VA: 0x1777E4C Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x1778774 Offset: 0x1774774 VA: 0x1778774
	private static void .cctor() { }
}

// Namespace: System.Security.Cryptography
public sealed class RNGCryptoServiceProvider : RandomNumberGenerator // TypeDefIndex: 772
{
	// Fields
	private static object _lock; // 0x0
	private IntPtr _handle; // 0x10

	// Methods

	// RVA: 0x1778814 Offset: 0x1774814 VA: 0x1778814
	private static void .cctor() { }

	// RVA: 0x1771A2C Offset: 0x176DA2C VA: 0x1771A2C
	public void .ctor() { }

	// RVA: 0x17788AC Offset: 0x17748AC VA: 0x17788AC
	private void Check() { }

	// RVA: 0x17788A4 Offset: 0x17748A4 VA: 0x17788A4
	private static bool RngOpen() { }

	// RVA: 0x17788A8 Offset: 0x17748A8 VA: 0x17788A8
	private static IntPtr RngInitialize(byte* seed, IntPtr seed_length) { }

	// RVA: 0x1778910 Offset: 0x1774910 VA: 0x1778910
	private static IntPtr RngGetBytes(IntPtr handle, byte* data, IntPtr data_length) { }

	// RVA: 0x1778914 Offset: 0x1774914 VA: 0x1778914
	private static void RngClose(IntPtr handle) { }

	// RVA: 0x1778918 Offset: 0x1774918 VA: 0x1778918 Slot: 6
	public override void GetBytes(byte[] data) { }

	// RVA: 0x1778B38 Offset: 0x1774B38 VA: 0x1778B38 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1778C10 Offset: 0x1774C10 VA: 0x1778C10 Slot: 5
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class RSAPKCS1SignatureDeformatter : AsymmetricSignatureDeformatter // TypeDefIndex: 773
{
	// Fields
	private RSA rsa; // 0x10
	private string hashName; // 0x18

	// Methods

	// RVA: 0x177406C Offset: 0x177006C VA: 0x177406C
	public void .ctor() { }

	// RVA: 0x1778C18 Offset: 0x1774C18 VA: 0x1778C18
	public void .ctor(AsymmetricAlgorithm key) { }

	// RVA: 0x1778C4C Offset: 0x1774C4C VA: 0x1778C4C Slot: 5
	public override void SetHashAlgorithm(string strName) { }

	// RVA: 0x1778CA4 Offset: 0x1774CA4 VA: 0x1778CA4 Slot: 4
	public override void SetKey(AsymmetricAlgorithm key) { }

	// RVA: 0x1778D98 Offset: 0x1774D98 VA: 0x1778D98 Slot: 6
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class RSAPKCS1SignatureFormatter : AsymmetricSignatureFormatter // TypeDefIndex: 774
{
	// Methods

	// RVA: 0x1774074 Offset: 0x1770074 VA: 0x1774074
	public void .ctor() { }
}

// Namespace: System.Security.Cryptography
internal class SHA1Internal // TypeDefIndex: 775
{
	// Fields
	private uint[] _H; // 0x10
	private ulong count; // 0x18
	private byte[] _ProcessingBuffer; // 0x20
	private int _ProcessingBufferCount; // 0x28
	private uint[] buff; // 0x30

	// Methods

	// RVA: 0x1778EE8 Offset: 0x1774EE8 VA: 0x1778EE8
	public void .ctor() { }

	// RVA: 0x1779030 Offset: 0x1775030 VA: 0x1779030
	public void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x177962C Offset: 0x177562C VA: 0x177962C
	public byte[] HashFinal() { }

	// RVA: 0x1778FA8 Offset: 0x1774FA8 VA: 0x1778FA8
	public void Initialize() { }

	// RVA: 0x1779130 Offset: 0x1775130 VA: 0x1779130
	private void ProcessBlock(byte[] inputBuffer, uint inputOffset) { }

	// RVA: 0x17798D0 Offset: 0x17758D0 VA: 0x17798D0
	private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset) { }

	// RVA: 0x1779F70 Offset: 0x1775F70 VA: 0x1779F70
	private static void FillBuff(uint[] buff) { }

	// RVA: 0x1779708 Offset: 0x1775708 VA: 0x1779708
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x177A0F4 Offset: 0x17760F4 VA: 0x177A0F4
	internal void AddLength(ulong length, byte[] buffer, int position) { }
}

// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class SHA1CryptoServiceProvider : SHA1 // TypeDefIndex: 776
{
	// Fields
	private SHA1Internal sha; // 0x28

	// Methods

	// RVA: 0x177407C Offset: 0x177007C VA: 0x177407C
	public void .ctor() { }

	// RVA: 0x177A1E4 Offset: 0x17761E4 VA: 0x177A1E4 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x177A274 Offset: 0x1776274 VA: 0x177A274 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x177A27C Offset: 0x177627C VA: 0x177A27C Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x177A29C Offset: 0x177629C VA: 0x177A29C Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x177A2B8 Offset: 0x17762B8 VA: 0x177A2B8 Slot: 18
	public override void Initialize() { }
}

// Namespace: System.Security.Cryptography
internal class TripleDESTransform : SymmetricTransform // TypeDefIndex: 777
{
	// Fields
	private DESTransform E1; // 0x58
	private DESTransform D2; // 0x60
	private DESTransform E3; // 0x68
	private DESTransform D1; // 0x70
	private DESTransform E2; // 0x78
	private DESTransform D3; // 0x80

	// Methods

	// RVA: 0x1771408 Offset: 0x176D408 VA: 0x1771408
	public void .ctor(TripleDES algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x177A370 Offset: 0x1776370 VA: 0x177A370 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x177A2CC Offset: 0x17762CC VA: 0x177A2CC
	internal static byte[] GetStrongKey() { }
}

// Namespace: System.Security.Cryptography
internal static class CryptoConfigForwarder // TypeDefIndex: 778
{
	// Methods

	// RVA: 0x177A490 Offset: 0x1776490 VA: 0x177A490
	internal static object CreateFromName(string name) { }
}

// Namespace: System.Security.Cryptography
internal class DerSequenceReader // TypeDefIndex: 3905
{
	// Fields
	internal static DateTimeFormatInfo s_validityDateTimeFormatInfo; // 0x0
	private static Encoding s_utf8EncodingWithExceptionFallback; // 0x8
	private static Encoding s_latin1Encoding; // 0x10
	private readonly byte[] _data; // 0x10
	private readonly int _end; // 0x18
	private int _position; // 0x1C
	[CompilerGenerated]
	private int <ContentLength>k__BackingField; // 0x20

	// Properties
	private int ContentLength { set; }
	internal bool HasData { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1D15F50 Offset: 0x1D11F50 VA: 0x1D15F50
	private void set_ContentLength(int value) { }

	// RVA: 0x1D15F58 Offset: 0x1D11F58 VA: 0x1D15F58
	internal void .ctor(byte[] data) { }

	// RVA: 0x1D15F78 Offset: 0x1D11F78 VA: 0x1D15F78
	internal void .ctor(byte[] data, int offset, int length) { }

	// RVA: 0x1D15F8C Offset: 0x1D11F8C VA: 0x1D15F8C
	private void .ctor(DerSequenceReader.DerTag tagToEat, byte[] data, int offset, int length) { }

	// RVA: 0x1D16148 Offset: 0x1D12148 VA: 0x1D16148
	internal bool get_HasData() { }

	// RVA: 0x1D16158 Offset: 0x1D12158 VA: 0x1D16158
	internal byte PeekTag() { }

	// RVA: 0x1D161EC Offset: 0x1D121EC VA: 0x1D161EC
	internal void SkipValue() { }

	// RVA: 0x1D16240 Offset: 0x1D12240 VA: 0x1D16240
	internal byte[] ReadNextEncodedValue() { }

	// RVA: 0x1D16414 Offset: 0x1D12414 VA: 0x1D16414
	internal bool ReadBoolean() { }

	// RVA: 0x1D164DC Offset: 0x1D124DC VA: 0x1D164DC
	internal int ReadInteger() { }

	// RVA: 0x1D16590 Offset: 0x1D12590 VA: 0x1D16590
	internal byte[] ReadIntegerBytes() { }

	// RVA: 0x1D1665C Offset: 0x1D1265C VA: 0x1D1665C
	internal byte[] ReadBitString() { }

	// RVA: 0x1D167A0 Offset: 0x1D127A0 VA: 0x1D167A0
	internal byte[] ReadOctetString() { }

	// RVA: 0x1D167BC Offset: 0x1D127BC VA: 0x1D167BC
	internal string ReadOidAsString() { }

	// RVA: 0x1D16A7C Offset: 0x1D12A7C VA: 0x1D16A7C
	internal string ReadUtf8String() { }

	// RVA: 0x1D16B78 Offset: 0x1D12B78 VA: 0x1D16B78
	private DerSequenceReader ReadCollectionWithTag(DerSequenceReader.DerTag expected) { }

	// RVA: 0x1D16CD0 Offset: 0x1D12CD0 VA: 0x1D16CD0
	internal DerSequenceReader ReadSequence() { }

	// RVA: 0x1D16CD8 Offset: 0x1D12CD8 VA: 0x1D16CD8
	internal DerSequenceReader ReadSet() { }

	// RVA: 0x1D16CE0 Offset: 0x1D12CE0 VA: 0x1D16CE0
	internal string ReadPrintableString() { }

	// RVA: 0x1D16D60 Offset: 0x1D12D60 VA: 0x1D16D60
	internal string ReadIA5String() { }

	// RVA: 0x1D16DE0 Offset: 0x1D12DE0 VA: 0x1D16DE0
	internal string ReadT61String() { }

	// RVA: 0x1D170B8 Offset: 0x1D130B8 VA: 0x1D170B8
	internal DateTime ReadX509Date() { }

	// RVA: 0x1D17138 Offset: 0x1D13138 VA: 0x1D17138
	internal DateTime ReadUtcTime() { }

	// RVA: 0x1D17184 Offset: 0x1D13184 VA: 0x1D17184
	internal DateTime ReadGeneralizedTime() { }

	// RVA: 0x1D17410 Offset: 0x1D13410 VA: 0x1D17410
	internal string ReadBMPString() { }

	// RVA: 0x1D16AFC Offset: 0x1D12AFC VA: 0x1D16AFC
	private static string TrimTrailingNulls(string value) { }

	// RVA: 0x1D171D0 Offset: 0x1D131D0 VA: 0x1D171D0
	private DateTime ReadTime(DerSequenceReader.DerTag timeTag, string formatString) { }

	// RVA: 0x1D165AC Offset: 0x1D125AC VA: 0x1D165AC
	private byte[] ReadContentAsBytes() { }

	// RVA: 0x1D1608C Offset: 0x1D1208C VA: 0x1D1608C
	private void EatTag(DerSequenceReader.DerTag expected) { }

	// RVA: 0x1D16C38 Offset: 0x1D12C38 VA: 0x1D16C38
	private static void CheckTag(DerSequenceReader.DerTag expected, byte[] data, int position) { }

	// RVA: 0x1D1610C Offset: 0x1D1210C VA: 0x1D1610C
	private int EatLength() { }

	// RVA: 0x1D162F4 Offset: 0x1D122F4 VA: 0x1D162F4
	private static int ScanContentLength(byte[] data, int offset, int end, out int bytesConsumed) { }
}

// Namespace: System.Security.Cryptography
public sealed class Oid // TypeDefIndex: 3906
{
	// Fields
	private string _value; // 0x10
	private string _friendlyName; // 0x18
	private OidGroup _group; // 0x20

	// Properties
	public string Value { get; set; }
	public string FriendlyName { get; }

	// Methods

	// RVA: 0x1D1766C Offset: 0x1D1366C VA: 0x1D1766C
	public void .ctor() { }

	// RVA: 0x1D17674 Offset: 0x1D13674 VA: 0x1D17674
	public void .ctor(string oid) { }

	// RVA: 0x1D17708 Offset: 0x1D13708 VA: 0x1D17708
	public void .ctor(string value, string friendlyName) { }

	// RVA: 0x1D1774C Offset: 0x1D1374C VA: 0x1D1774C
	public void .ctor(Oid oid) { }

	// RVA: 0x1D177E4 Offset: 0x1D137E4 VA: 0x1D177E4
	public static Oid FromOidValue(string oidValue, OidGroup group) { }

	// RVA: 0x1D17968 Offset: 0x1D13968 VA: 0x1D17968
	public string get_Value() { }

	// RVA: 0x1D17970 Offset: 0x1D13970 VA: 0x1D17970
	public void set_Value(string value) { }

	// RVA: 0x1D17978 Offset: 0x1D13978 VA: 0x1D17978
	public string get_FriendlyName() { }

	// RVA: 0x1D17910 Offset: 0x1D13910 VA: 0x1D17910
	private void .ctor(string value, string friendlyName, OidGroup group) { }
}

// Namespace: System.Security.Cryptography
[DefaultMember("Item")]
public sealed class OidCollection : ICollection, IEnumerable // TypeDefIndex: 3907
{
	// Fields
	private readonly List<Oid> _list; // 0x10

	// Properties
	public Oid Item { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x1D17A10 Offset: 0x1D13A10 VA: 0x1D17A10
	public void .ctor() { }

	// RVA: 0x1D17A98 Offset: 0x1D13A98 VA: 0x1D17A98
	public int Add(Oid oid) { }

	// RVA: 0x1D17B54 Offset: 0x1D13B54 VA: 0x1D17B54
	public Oid get_Item(int index) { }

	// RVA: 0x1D17BAC Offset: 0x1D13BAC VA: 0x1D17BAC Slot: 5
	public int get_Count() { }

	// RVA: 0x1D17BF4 Offset: 0x1D13BF4 VA: 0x1D17BF4
	public OidEnumerator GetEnumerator() { }

	// RVA: 0x1D17CA0 Offset: 0x1D13CA0 VA: 0x1D17CA0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1D17CA4 Offset: 0x1D13CA4 VA: 0x1D17CA4 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x1D17E4C Offset: 0x1D13E4C VA: 0x1D17E4C Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x1D17E54 Offset: 0x1D13E54 VA: 0x1D17E54 Slot: 6
	public object get_SyncRoot() { }
}

// Namespace: System.Security.Cryptography
public sealed class OidEnumerator : IEnumerator // TypeDefIndex: 3908
{
	// Fields
	private readonly OidCollection _oids; // 0x10
	private int _current; // 0x18

	// Properties
	public Oid Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: 0x1D17C64 Offset: 0x1D13C64 VA: 0x1D17C64
	internal void .ctor(OidCollection oids) { }

	// RVA: 0x1D17E58 Offset: 0x1D13E58 VA: 0x1D17E58
	public Oid get_Current() { }

	// RVA: 0x1D17E74 Offset: 0x1D13E74 VA: 0x1D17E74 Slot: 5
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1D17E78 Offset: 0x1D13E78 VA: 0x1D17E78 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1D17EC4 Offset: 0x1D13EC4 VA: 0x1D17EC4 Slot: 6
	public void Reset() { }
}

// Namespace: System.Security.Cryptography
public enum OidGroup // TypeDefIndex: 3909
{
	// Fields
	public int value__; // 0x0
	public const OidGroup All = 0;
	public const OidGroup HashAlgorithm = 1;
	public const OidGroup EncryptionAlgorithm = 2;
	public const OidGroup PublicKeyAlgorithm = 3;
	public const OidGroup SignatureAlgorithm = 4;
	public const OidGroup Attribute = 5;
	public const OidGroup ExtensionOrAttribute = 6;
	public const OidGroup EnhancedKeyUsage = 7;
	public const OidGroup Policy = 8;
	public const OidGroup Template = 9;
	public const OidGroup KeyDerivationFunction = 10;
}

// Namespace: System.Security.Cryptography
internal enum AsnDecodeStatus // TypeDefIndex: 3910
{
	// Fields
	public int value__; // 0x0
	public const AsnDecodeStatus NotDecoded = -1;
	public const AsnDecodeStatus Ok = 0;
	public const AsnDecodeStatus BadAsn = 1;
	public const AsnDecodeStatus BadTag = 2;
	public const AsnDecodeStatus BadLength = 3;
	public const AsnDecodeStatus InformationNotAvailable = 4;
}

// Namespace: System.Security.Cryptography
public class AsnEncodedData // TypeDefIndex: 3911
{
	// Fields
	internal Oid _oid; // 0x10
	internal byte[] _raw; // 0x18

	// Properties
	public Oid Oid { get; set; }
	public byte[] RawData { get; set; }

	// Methods

	// RVA: 0x1D17ED0 Offset: 0x1D13ED0 VA: 0x1D17ED0
	protected void .ctor() { }

	// RVA: 0x1D17ED8 Offset: 0x1D13ED8 VA: 0x1D17ED8
	public void .ctor(string oid, byte[] rawData) { }

	// RVA: 0x1D18054 Offset: 0x1D14054 VA: 0x1D18054
	public void .ctor(Oid oid, byte[] rawData) { }

	// RVA: 0x1D18108 Offset: 0x1D14108 VA: 0x1D18108
	public void .ctor(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1D181DC Offset: 0x1D141DC VA: 0x1D181DC
	public Oid get_Oid() { }

	// RVA: 0x1D18090 Offset: 0x1D14090 VA: 0x1D18090
	public void set_Oid(Oid value) { }

	// RVA: 0x1D181E4 Offset: 0x1D141E4 VA: 0x1D181E4
	public byte[] get_RawData() { }

	// RVA: 0x1D17F60 Offset: 0x1D13F60 VA: 0x1D17F60
	public void set_RawData(byte[] value) { }

	// RVA: 0x1D181EC Offset: 0x1D141EC VA: 0x1D181EC Slot: 4
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x1D182BC Offset: 0x1D142BC VA: 0x1D182BC Slot: 5
	public virtual string Format(bool multiLine) { }

	// RVA: 0x1D18414 Offset: 0x1D14414 VA: 0x1D18414 Slot: 6
	internal virtual string ToString(bool multiLine) { }

	// RVA: 0x1D182FC Offset: 0x1D142FC VA: 0x1D182FC
	internal string Default(bool multiLine) { }

	// RVA: 0x1D185C4 Offset: 0x1D145C4 VA: 0x1D185C4
	internal string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x1D186C8 Offset: 0x1D146C8 VA: 0x1D186C8
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x1D187CC Offset: 0x1D147CC VA: 0x1D187CC
	internal string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x1D188D0 Offset: 0x1D148D0 VA: 0x1D188D0
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x1D189D4 Offset: 0x1D149D4 VA: 0x1D189D4
	internal string SubjectAltName(bool multiLine) { }

	// RVA: 0x1D18DA8 Offset: 0x1D14DA8 VA: 0x1D18DA8
	internal string NetscapeCertType(bool multiLine) { }
}

// Namespace: System.Security.Cryptography
public sealed class AesManaged : Aes // TypeDefIndex: 5350
{
	// Fields
	private RijndaelManaged m_rijndael; // 0x48

	// Properties
	public override int FeedbackSize { get; }
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x199F4A8 Offset: 0x199B4A8 VA: 0x199F4A8
	public void .ctor() { }

	// RVA: 0x199F618 Offset: 0x199B618 VA: 0x199F618 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x199F634 Offset: 0x199B634 VA: 0x199F634 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x199F650 Offset: 0x199B650 VA: 0x199F650 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x199F66C Offset: 0x199B66C VA: 0x199F66C Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x199F688 Offset: 0x199B688 VA: 0x199F688 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x199F6A4 Offset: 0x199B6A4 VA: 0x199F6A4 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x199F6C4 Offset: 0x199B6C4 VA: 0x199F6C4 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x199F6E4 Offset: 0x199B6E4 VA: 0x199F6E4 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x199F704 Offset: 0x199B704 VA: 0x199F704 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x199F784 Offset: 0x199B784 VA: 0x199F784 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x199F7A4 Offset: 0x199B7A4 VA: 0x199F7A4 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x199F7C4 Offset: 0x199B7C4 VA: 0x199F7C4 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x199F7E4 Offset: 0x199B7E4 VA: 0x199F7E4 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x199F924 Offset: 0x199B924 VA: 0x199F924 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x199F944 Offset: 0x199B944 VA: 0x199F944 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x199FA84 Offset: 0x199BA84 VA: 0x199FA84 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x199FBC0 Offset: 0x199BBC0 VA: 0x199FBC0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x199FBE0 Offset: 0x199BBE0 VA: 0x199FBE0 Slot: 24
	public override void GenerateKey() { }
}

// Namespace: System.Security.Cryptography
public sealed class AesCryptoServiceProvider : Aes // TypeDefIndex: 5351
{
	// Properties
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override int FeedbackSize { get; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x199FC00 Offset: 0x199BC00 VA: 0x199FC00
	public void .ctor() { }

	// RVA: 0x199FC64 Offset: 0x199BC64 VA: 0x199FC64 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x199FC90 Offset: 0x199BC90 VA: 0x199FC90 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x199FCBC Offset: 0x199BCBC VA: 0x199FCBC Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x19A0470 Offset: 0x199C470 VA: 0x19A0470 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x19A0560 Offset: 0x199C560 VA: 0x19A0560 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x19A0568 Offset: 0x199C568 VA: 0x19A0568 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x19A0570 Offset: 0x199C570 VA: 0x19A0570 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x19A0578 Offset: 0x199C578 VA: 0x19A0578 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x19A0580 Offset: 0x199C580 VA: 0x19A0580 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x19A0588 Offset: 0x199C588 VA: 0x19A0588 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x19A0590 Offset: 0x199C590 VA: 0x19A0590 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x19A0598 Offset: 0x199C598 VA: 0x19A0598 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x19A05A0 Offset: 0x199C5A0 VA: 0x19A05A0 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x19A05FC Offset: 0x199C5FC VA: 0x19A05FC Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x19A0604 Offset: 0x199C604 VA: 0x19A0604 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x19A060C Offset: 0x199C60C VA: 0x19A060C Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x19A065C Offset: 0x199C65C VA: 0x19A065C Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x19A06AC Offset: 0x199C6AC VA: 0x19A06AC Slot: 5
	protected override void Dispose(bool disposing) { }
}

// Namespace: System.Security.Cryptography
internal class AesTransform : SymmetricTransform // TypeDefIndex: 5352
{
	// Fields
	private uint[] expandedKey; // 0x58
	private int Nk; // 0x60
	private int Nr; // 0x64
	private static readonly uint[] Rcon; // 0x0
	private static readonly byte[] SBox; // 0x8
	private static readonly byte[] iSBox; // 0x10
	private static readonly uint[] T0; // 0x18
	private static readonly uint[] T1; // 0x20
	private static readonly uint[] T2; // 0x28
	private static readonly uint[] T3; // 0x30
	private static readonly uint[] iT0; // 0x38
	private static readonly uint[] iT1; // 0x40
	private static readonly uint[] iT2; // 0x48
	private static readonly uint[] iT3; // 0x50

	// Methods

	// RVA: 0x199FDAC Offset: 0x199BDAC VA: 0x199FDAC
	public void .ctor(Aes algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x19A0778 Offset: 0x199C778 VA: 0x19A0778 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x19A06B4 Offset: 0x199C6B4 VA: 0x19A06B4
	private uint SubByte(uint a) { }

	// RVA: 0x19A078C Offset: 0x199C78C VA: 0x19A078C
	private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x19A257C Offset: 0x199E57C VA: 0x19A257C
	private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x19A4358 Offset: 0x19A0358 VA: 0x19A4358
	private static void .cctor() { }
}
