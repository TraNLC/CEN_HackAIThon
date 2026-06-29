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

// Namespace: Mono.Math.Prime.Generator
internal abstract class PrimeGeneratorBase // TypeDefIndex: 89
{
	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x1734C14 Offset: 0x1730C14 VA: 0x1734C14 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x1734C1C Offset: 0x1730C1C VA: 0x1734C1C Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x1734C88 Offset: 0x1730C88 VA: 0x1734C88 Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x1734C90 Offset: 0x1730C90 VA: 0x1734C90
	protected void .ctor() { }
}

// Namespace: Mono.Math.Prime.Generator
internal class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 90
{
	// Methods

	// RVA: 0x1734C98 Offset: 0x1730C98 VA: 0x1734C98 Slot: 8
	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0x1734D0C Offset: 0x1730D0C VA: 0x1734D0C Slot: 7
	public override BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0x1734D1C Offset: 0x1730D1C VA: 0x1734D1C Slot: 9
	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0x1735000 Offset: 0x1731000 VA: 0x1735000 Slot: 10
	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0x17337A0 Offset: 0x172F7A0 VA: 0x17337A0
	public void .ctor() { }
}

// Namespace: Mono.Math.Prime.Generator
public abstract class PrimeGeneratorBase // TypeDefIndex: 7587
{
	// Properties
	public virtual ConfidenceFactor Confidence { get; }
	public virtual PrimalityTest PrimalityTest { get; }
	public virtual int TrialDivisionBounds { get; }

	// Methods

	// RVA: 0x1714EF8 Offset: 0x1710EF8 VA: 0x1714EF8 Slot: 4
	public virtual ConfidenceFactor get_Confidence() { }

	// RVA: 0x1714F00 Offset: 0x1710F00 VA: 0x1714F00 Slot: 5
	public virtual PrimalityTest get_PrimalityTest() { }

	// RVA: 0x1714F6C Offset: 0x1710F6C VA: 0x1714F6C Slot: 6
	public virtual int get_TrialDivisionBounds() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract BigInteger GenerateNewPrime(int bits);

	// RVA: 0x1714F74 Offset: 0x1710F74 VA: 0x1714F74
	protected void .ctor() { }
}

// Namespace: Mono.Math.Prime.Generator
public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase // TypeDefIndex: 7588
{
	// Methods

	// RVA: 0x1714F7C Offset: 0x1710F7C VA: 0x1714F7C Slot: 8
	protected virtual BigInteger GenerateSearchBase(int bits, object context) { }

	// RVA: 0x1714FF0 Offset: 0x1710FF0 VA: 0x1714FF0 Slot: 7
	public override BigInteger GenerateNewPrime(int bits) { }

	// RVA: 0x1715000 Offset: 0x1711000 VA: 0x1715000 Slot: 9
	public virtual BigInteger GenerateNewPrime(int bits, object context) { }

	// RVA: 0x17152E4 Offset: 0x17112E4 VA: 0x17152E4 Slot: 10
	protected virtual bool IsPrimeAcceptable(BigInteger bi, object context) { }

	// RVA: 0x1713C58 Offset: 0x170FC58 VA: 0x1713C58
	public void .ctor() { }
}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 // TypeDefIndex: 7589
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 // TypeDefIndex: 7590
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 // TypeDefIndex: 7591
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18 // TypeDefIndex: 7592
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 // TypeDefIndex: 7593
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 // TypeDefIndex: 7594
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 // TypeDefIndex: 7595
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 // TypeDefIndex: 7596
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 // TypeDefIndex: 7597
{}

// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 // TypeDefIndex: 7598
{}

// Namespace: 
[CompilerGenerated]
internal sealed class <PrivateImplementationDetails> // TypeDefIndex: 7599
{
	// Fields
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 001D686DB504E20C792EAA07FE09224A45FF328E24A80072D04D16ABC5C2B5D2 /*Metadata offset 0x3F2868*/; // 0x0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3132 25E3E48132FBDBE9B7C0C6C54D7C10A5DE12A105AA3E5DE2A0DC808BF245B7A5 /*Metadata offset 0x3F28B0*/; // 0x40
	internal static readonly long 290C4A052C215D096172EB81AEE671FB3286E5C1DB5E73F96021FC09825DDB88 = 2676302836908902219; // 0xC80
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 32D0830B8EE1D49A66F395C8EA80E02BFC07C2A12A8EA8C8B484AF02108A1950 /*Metadata offset 0x3F3500*/; // 0xC88
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 35BF50EEF3270FD8CA09E66FC5B0481C5A151B14F6A634854E32F63633D49DCB /*Metadata offset 0x3F3508*/; // 0xC8B
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 3C0C410618682C4DF0474E034114CC8E562F05A512B521AC367571017BDFA75D /*Metadata offset 0x3F3510*/; // 0xC8E
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 44F5B1A2C48314502ACCBF186D1A2F9F7F176825898F32F1A2047B956194F174 /*Metadata offset 0x3F3518*/; // 0xC91
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=48 4800FBFC4566EB02D1727A4B1C949CCBC7535C216A0766564C199308631B5DD6 /*Metadata offset 0x3F3520*/; // 0xC94
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=20 533B8C444F951E83EFF7305E3807B66CE0005DE0A2D0A44873C130895A3BE6AA /*Metadata offset 0x3F3558*/; // 0xCC4
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=256 55D0BF716B334D123E0088CFB3F8E2FEA17AF5025BB527F95EEB09BA978EA329 /*Metadata offset 0x3F3570*/; // 0xCD8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 59BE5A634187B8A57216EFF5371A47732C05744B1C1A0A6382A6D5622C9FFDCE /*Metadata offset 0x3F3678*/; // 0xDD8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=32 5DF6E0E2761359D30A8275058E299FCC0381534545F55CF43E41983F5D4C9456 /*Metadata offset 0x3F3680*/; // 0xDDB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 5F8C6B3C66B972606D85E7651F67ADBD02E8316876884674E8328FA710747E5B /*Metadata offset 0x3F36A8*/; // 0xDFB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 60C6ED13AF98DBFEEDA8F8197FFFCC349BB04395CC81DF0D477CBC57BF5B398B /*Metadata offset 0x3F36B0*/; // 0xDFE
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=10 64B3E7D737AFF47D4C3BBD81D2D06D697DDD8EB60F29E13E4425D19D8BBCA1F7 /*Metadata offset 0x3F36C0*/; // 0xE08
	internal static readonly long 6772A9B8BF207A3CFE6EE68769D6985B69522183F24A2A3D41BC3B4602953426 = 22609615381091406; // 0xE18
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=9 684312AFB7719E57993D2826FFBAF7EA965614F20F91D999FB19B01E21AA62E6 /*Metadata offset 0x3F36E0*/; // 0xE20
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 6AA56C4BCD208911792AD24C7681FEFB93BED51903AFC54860C9BD37E41E5A31 /*Metadata offset 0x3F36F0*/; // 0xE29
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 796E63069E193A008CB4E85573AA1FE53C5F4E58B42A7F61FD0EEE1D89B5120B /*Metadata offset 0x3F3738*/; // 0xE69
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 7C8975E1E60A5C8337F28EDF8C33C3B180360B7279644A9BC1AF3C51E6220BF5 /*Metadata offset 0x3F3740*/; // 0xE6C
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 850D7367E4FB0766E2CBC3ACF5AB42B4E98348E58E5A789845D4FCCDB63D2AEE /*Metadata offset 0x3F3788*/; // 0xEAC
	internal static readonly long 992F16C986809AB68C7466CC3EC6F12B2506A962EA539753E5D84A2FB7FF8A24 = -1295888024253181014; // 0xEB0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 9A65C09A11757751BFED67A414E00B188DC4C7757FCB6CBD33A916DDE4A3D925 /*Metadata offset 0x3F37A0*/; // 0xEB8
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=18 9ACEFCC0C950280B64AB9E045E38C34ABF71EC70A0DC61B9C621C6BFB4F78047 /*Metadata offset 0x3F37A8*/; // 0xEBB
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 B1E34F4A11EE411B83415EF0B252A0B2BBCFCAC2E592865E09C12E4252C93A75 /*Metadata offset 0x3F37C0*/; // 0xECD
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 C92FAD7F348A682E7D5B7E74C76B5D019174EE7BC87545B25A1FDD49FBCC2D0B /*Metadata offset 0x3F37C8*/; // 0xED0
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 E17B8359E685992B0DE6242AAA24FCB7404173CBB7FF8646FF7D658139F41B5F /*Metadata offset 0x3F37D0*/; // 0xED3
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=64 F83B332BE4E6A5A4B1C56AAF6DB52657DA495E149870057D8590AB9D7A6167AD /*Metadata offset 0x3F37D8*/; // 0xED6
	internal static readonly <PrivateImplementationDetails>.__StaticArrayInitTypeSize=3 FB6D7301FFDCB5FBA5807A19B4F0606947897C1105240B6BBA815352DBBE2064 /*Metadata offset 0x3F3820*/; // 0xF16

	// Methods

	// RVA: 0x170B9EC Offset: 0x17079EC VA: 0x170B9EC
	internal static uint ComputeStringHash(string s) { }
}

// Namespace: 
internal class <Module> // TypeDefIndex: 7600
{}
