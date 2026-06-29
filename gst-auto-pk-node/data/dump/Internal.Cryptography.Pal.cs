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

// Namespace: Internal.Cryptography.Pal
internal enum GeneralNameType // TypeDefIndex: 3820
{
	// Fields
	public int value__; // 0x0
	public const GeneralNameType OtherName = 0;
	public const GeneralNameType Rfc822Name = 1;
	public const GeneralNameType Email = 1;
	public const GeneralNameType DnsName = 2;
	public const GeneralNameType X400Address = 3;
	public const GeneralNameType DirectoryName = 4;
	public const GeneralNameType EdiPartyName = 5;
	public const GeneralNameType UniformResourceIdentifier = 6;
	public const GeneralNameType IPAddress = 7;
	public const GeneralNameType RegisteredId = 8;
}

// Namespace: 
internal struct CertificateData.AlgorithmIdentifier // TypeDefIndex: 3821
{
	// Fields
	internal string AlgorithmId; // 0x0
	internal byte[] Parameters; // 0x8
}

// Namespace: 
[CompilerGenerated]
private sealed class CertificateData.<ReadReverseRdns>d__21 : IEnumerable<KeyValuePair<string, string>>, IEnumerable, IEnumerator<KeyValuePair<string, string>>, IDisposable, IEnumerator // TypeDefIndex: 3822
{
	// Fields
	private int <>1__state; // 0x10
	private KeyValuePair<string, string> <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x28
	private X500DistinguishedName name; // 0x30
	public X500DistinguishedName <>3__name; // 0x38
	private Stack<DerSequenceReader> <rdnReaders>5__2; // 0x40
	private DerSequenceReader <rdnReader>5__3; // 0x48

	// Properties
	private KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x1A2E738 Offset: 0x1A2A738 VA: 0x1A2E738
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x1A2E76C Offset: 0x1A2A76C VA: 0x1A2E76C Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1A2E770 Offset: 0x1A2A770 VA: 0x1A2E770 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x1A2EA3C Offset: 0x1A2AA3C VA: 0x1A2EA3C Slot: 6
	private KeyValuePair<string, string> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.String>>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A2EA48 Offset: 0x1A2AA48 VA: 0x1A2EA48 Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x1A2EA80 Offset: 0x1A2AA80 VA: 0x1A2EA80 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x1A2EADC Offset: 0x1A2AADC VA: 0x1A2EADC Slot: 4
	private IEnumerator<KeyValuePair<string, string>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.String>>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x1A2EB80 Offset: 0x1A2AB80 VA: 0x1A2EB80 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: Internal.Cryptography.Pal
internal struct CertificateData // TypeDefIndex: 3823
{
	// Fields
	internal byte[] RawData; // 0x0
	internal byte[] SubjectPublicKeyInfo; // 0x8
	internal int Version; // 0x10
	internal byte[] SerialNumber; // 0x18
	internal CertificateData.AlgorithmIdentifier TbsSignature; // 0x20
	internal X500DistinguishedName Issuer; // 0x30
	internal DateTime NotBefore; // 0x38
	internal DateTime NotAfter; // 0x40
	internal X500DistinguishedName Subject; // 0x48
	internal CertificateData.AlgorithmIdentifier PublicKeyAlgorithm; // 0x50
	internal byte[] PublicKey; // 0x60
	internal byte[] IssuerUniqueId; // 0x68
	internal byte[] SubjectUniqueId; // 0x70
	internal List<X509Extension> Extensions; // 0x78
	internal CertificateData.AlgorithmIdentifier SignatureAlgorithm; // 0x80
	internal byte[] SignatureValue; // 0x90

	// Methods

	// RVA: 0x1A2D2D4 Offset: 0x1A292D4 VA: 0x1A2D2D4
	internal void .ctor(byte[] rawData) { }

	// RVA: 0x1A2DADC Offset: 0x1A29ADC VA: 0x1A2DADC
	public string GetNameInfo(X509NameType nameType, bool forIssuer) { }

	// RVA: 0x1A2E10C Offset: 0x1A2A10C VA: 0x1A2E10C
	private static string GetSimpleNameInfo(X500DistinguishedName name) { }

	// RVA: 0x1A2E4FC Offset: 0x1A2A4FC VA: 0x1A2E4FC
	private static string FindAltNameMatch(byte[] extensionBytes, GeneralNameType matchType, string otherOid) { }

	[IteratorStateMachine(typeof(CertificateData.<ReadReverseRdns>d__21))]
	// RVA: 0x1A2E6B8 Offset: 0x1A2A6B8 VA: 0x1A2E6B8
	private static IEnumerable<KeyValuePair<string, string>> ReadReverseRdns(X500DistinguishedName name) { }
}
