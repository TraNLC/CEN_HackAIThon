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

// Namespace: Mono.Security.X509.Extensions
public class AuthorityKeyIdentifierExtension : X509Extension // TypeDefIndex: 7541
{
	// Fields
	private byte[] aki; // 0x28

	// Properties
	public byte[] Identifier { get; }

	// Methods

	// RVA: 0x1704834 Offset: 0x1700834 VA: 0x1704834
	public void .ctor(X509Extension extension) { }

	// RVA: 0x1704838 Offset: 0x1700838 VA: 0x1704838 Slot: 4
	protected override void Decode() { }

	// RVA: 0x1704958 Offset: 0x1700958 VA: 0x1704958 Slot: 5
	protected override void Encode() { }

	// RVA: 0x1704AA0 Offset: 0x1700AA0 VA: 0x1704AA0
	public byte[] get_Identifier() { }

	// RVA: 0x1704B14 Offset: 0x1700B14 VA: 0x1704B14 Slot: 3
	public override string ToString() { }
}

// Namespace: Mono.Security.X509.Extensions
public class BasicConstraintsExtension : X509Extension // TypeDefIndex: 7542
{
	// Fields
	private bool cA; // 0x28
	private int pathLenConstraint; // 0x2C

	// Properties
	public bool CertificateAuthority { get; }

	// Methods

	// RVA: 0x1703000 Offset: 0x16FF000 VA: 0x1703000
	public void .ctor(X509Extension extension) { }

	// RVA: 0x1704C94 Offset: 0x1700C94 VA: 0x1704C94 Slot: 4
	protected override void Decode() { }

	// RVA: 0x1704DC8 Offset: 0x1700DC8 VA: 0x1704DC8 Slot: 5
	protected override void Encode() { }

	// RVA: 0x1704F24 Offset: 0x1700F24 VA: 0x1704F24
	public bool get_CertificateAuthority() { }

	// RVA: 0x1704F2C Offset: 0x1700F2C VA: 0x1704F2C Slot: 3
	public override string ToString() { }
}
