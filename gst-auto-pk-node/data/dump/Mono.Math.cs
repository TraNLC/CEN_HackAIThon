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

// Namespace: Mono.Math
internal class BigInteger // TypeDefIndex: 85
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	// RVA: 0x173150C Offset: 0x172D50C VA: 0x173150C
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x173158C Offset: 0x172D58C VA: 0x173158C
	public void .ctor(BigInteger bi) { }

	// RVA: 0x1731674 Offset: 0x172D674 VA: 0x1731674
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x172C71C Offset: 0x172871C VA: 0x172C71C
	public void .ctor(byte[] inData) { }

	// RVA: 0x17317B8 Offset: 0x172D7B8 VA: 0x17317B8
	public void .ctor(uint ui) { }

	// RVA: 0x172BE4C Offset: 0x1727E4C VA: 0x172BE4C
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x172C1EC Offset: 0x17281EC VA: 0x172C1EC
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x172C290 Offset: 0x1728290 VA: 0x172C290
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x172BF10 Offset: 0x1727F10 VA: 0x172BF10
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x172C3FC Offset: 0x17283FC VA: 0x172C3FC
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1730440 Offset: 0x172C440 VA: 0x1730440
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x172BFC4 Offset: 0x1727FC4 VA: 0x172BFC4
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1730314 Offset: 0x172C314 VA: 0x1730314
	public static BigInteger op_Multiply(BigInteger bi, int i) { }

	// RVA: 0x173223C Offset: 0x172E23C VA: 0x173223C
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1732410 Offset: 0x172E410 VA: 0x1732410
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1732584 Offset: 0x172E584 VA: 0x1732584
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1732630 Offset: 0x172E630 VA: 0x1732630
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x172FF68 Offset: 0x172BF68 VA: 0x172FF68
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x1732790 Offset: 0x172E790 VA: 0x1732790
	public void Randomize(RandomNumberGenerator rng) { }

	// RVA: 0x172FFC4 Offset: 0x172BFC4 VA: 0x172FFC4
	public void Randomize() { }

	// RVA: 0x172C16C Offset: 0x172816C VA: 0x172C16C
	public int BitCount() { }

	// RVA: 0x1730404 Offset: 0x172C404 VA: 0x1730404
	public bool TestBit(uint bitNum) { }

	// RVA: 0x1732910 Offset: 0x172E910 VA: 0x1732910
	public bool TestBit(int bitNum) { }

	// RVA: 0x17329A4 Offset: 0x172E9A4 VA: 0x17329A4
	public void SetBit(uint bitNum) { }

	// RVA: 0x17329AC Offset: 0x172E9AC VA: 0x17329AC
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1732A20 Offset: 0x172EA20 VA: 0x1732A20
	public int LowestSetBit() { }

	// RVA: 0x172CE54 Offset: 0x1728E54 VA: 0x172CE54
	public byte[] GetBytes() { }

	// RVA: 0x1730020 Offset: 0x172C020 VA: 0x1730020
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	// RVA: 0x173086C Offset: 0x172C86C VA: 0x173086C
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x172C564 Offset: 0x1728564 VA: 0x172C564
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x172BF14 Offset: 0x1727F14 VA: 0x172BF14
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1732A9C Offset: 0x172EA9C VA: 0x1732A9C
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x172C1D8 Offset: 0x17281D8 VA: 0x172C1D8
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x173008C Offset: 0x172C08C VA: 0x173008C
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1730468 Offset: 0x172C468 VA: 0x1730468
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1732AB4 Offset: 0x172EAB4 VA: 0x1732AB4
	public string ToString(uint radix) { }

	// RVA: 0x1732B0C Offset: 0x172EB0C VA: 0x1732B0C
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x173175C Offset: 0x172D75C VA: 0x173175C
	private void Normalize() { }

	// RVA: 0x172CA78 Offset: 0x1728A78 VA: 0x172CA78
	public void Clear() { }

	// RVA: 0x1732DEC Offset: 0x172EDEC VA: 0x1732DEC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1732E40 Offset: 0x172EE40 VA: 0x1732E40 Slot: 3
	public override string ToString() { }

	// RVA: 0x1732E48 Offset: 0x172EE48 VA: 0x1732E48 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x172C3F8 Offset: 0x17283F8 VA: 0x172C3F8
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x172C950 Offset: 0x1728950 VA: 0x172C950
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x173016C Offset: 0x172C16C VA: 0x173016C
	public bool IsProbablePrime() { }

	// RVA: 0x172BEA4 Offset: 0x1727EA4 VA: 0x172BEA4
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x17337A8 Offset: 0x172F7A8 VA: 0x17337A8
	public void Incr2() { }

	// RVA: 0x1733844 Offset: 0x172F844 VA: 0x1733844
	private static void .cctor() { }
}

// Namespace: Mono.Math
public class BigInteger // TypeDefIndex: 7583
{
	// Fields
	private uint length; // 0x10
	private uint[] data; // 0x18
	internal static readonly uint[] smallPrimes; // 0x0
	private static RandomNumberGenerator rng; // 0x8

	// Properties
	private static RandomNumberGenerator Rng { get; }

	// Methods

	[CLSCompliant(False)]
	// RVA: 0x1711B44 Offset: 0x170DB44 VA: 0x1711B44
	public void .ctor(BigInteger.Sign sign, uint len) { }

	// RVA: 0x1711BC4 Offset: 0x170DBC4 VA: 0x1711BC4
	public void .ctor(BigInteger bi) { }

	[CLSCompliant(False)]
	// RVA: 0x1711CAC Offset: 0x170DCAC VA: 0x1711CAC
	public void .ctor(BigInteger bi, uint len) { }

	// RVA: 0x170DF3C Offset: 0x1709F3C VA: 0x170DF3C
	public void .ctor(byte[] inData) { }

	[CLSCompliant(False)]
	// RVA: 0x1711DF0 Offset: 0x170DDF0 VA: 0x1711DF0
	public void .ctor(uint ui) { }

	[CLSCompliant(False)]
	// RVA: 0x170D66C Offset: 0x170966C VA: 0x170D66C
	public static BigInteger op_Implicit(uint value) { }

	// RVA: 0x170DA0C Offset: 0x1709A0C VA: 0x170DA0C
	public static BigInteger op_Implicit(int value) { }

	// RVA: 0x170DAB0 Offset: 0x1709AB0 VA: 0x170DAB0
	public static BigInteger op_Subtraction(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliant(False)]
	// RVA: 0x170D730 Offset: 0x1709730 VA: 0x170D730
	public static uint op_Modulus(BigInteger bi, uint ui) { }

	// RVA: 0x170DC1C Offset: 0x1709C1C VA: 0x170DC1C
	public static BigInteger op_Modulus(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x171270C Offset: 0x170E70C VA: 0x171270C
	public static BigInteger op_Division(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x170D7E4 Offset: 0x17097E4 VA: 0x170D7E4
	public static BigInteger op_Multiply(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1712818 Offset: 0x170E818 VA: 0x1712818
	public static BigInteger op_LeftShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x17129EC Offset: 0x170E9EC VA: 0x17129EC
	public static BigInteger op_RightShift(BigInteger bi1, int shiftVal) { }

	// RVA: 0x1712B60 Offset: 0x170EB60 VA: 0x1712B60
	private static RandomNumberGenerator get_Rng() { }

	// RVA: 0x1712C0C Offset: 0x170EC0C VA: 0x1712C0C
	public static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng) { }

	// RVA: 0x1712D6C Offset: 0x170ED6C VA: 0x1712D6C
	public static BigInteger GenerateRandom(int bits) { }

	// RVA: 0x170D98C Offset: 0x170998C VA: 0x170D98C
	public int BitCount() { }

	// RVA: 0x1712DC8 Offset: 0x170EDC8 VA: 0x1712DC8
	public bool TestBit(int bitNum) { }

	[CLSCompliant(False)]
	// RVA: 0x1712E5C Offset: 0x170EE5C VA: 0x1712E5C
	public void SetBit(uint bitNum) { }

	[CLSCompliant(False)]
	// RVA: 0x1712E64 Offset: 0x170EE64 VA: 0x1712E64
	public void SetBit(uint bitNum, bool value) { }

	// RVA: 0x1712ED8 Offset: 0x170EED8 VA: 0x1712ED8
	public int LowestSetBit() { }

	// RVA: 0x170E674 Offset: 0x170A674 VA: 0x170E674
	public byte[] GetBytes() { }

	[CLSCompliant(False)]
	// RVA: 0x1711E80 Offset: 0x170DE80 VA: 0x1711E80
	public static bool op_Equality(BigInteger bi1, uint ui) { }

	[CLSCompliant(False)]
	// RVA: 0x1712F54 Offset: 0x170EF54 VA: 0x1712F54
	public static bool op_Inequality(BigInteger bi1, uint ui) { }

	// RVA: 0x170DD84 Offset: 0x1709D84 VA: 0x170DD84
	public static bool op_Equality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x170D734 Offset: 0x1709734 VA: 0x170D734
	public static bool op_Inequality(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1712FC0 Offset: 0x170EFC0 VA: 0x1712FC0
	public static bool op_GreaterThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x170D9F8 Offset: 0x17099F8 VA: 0x170D9F8
	public static bool op_LessThan(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1712FD8 Offset: 0x170EFD8 VA: 0x1712FD8
	public static bool op_GreaterThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	// RVA: 0x1712FF0 Offset: 0x170EFF0 VA: 0x1712FF0
	public static bool op_LessThanOrEqual(BigInteger bi1, BigInteger bi2) { }

	[CLSCompliant(False)]
	// RVA: 0x1713008 Offset: 0x170F008 VA: 0x1713008
	public string ToString(uint radix) { }

	[CLSCompliant(False)]
	// RVA: 0x1713060 Offset: 0x170F060 VA: 0x1713060
	public string ToString(uint radix, string characterSet) { }

	// RVA: 0x1711D94 Offset: 0x170DD94 VA: 0x1711D94
	private void Normalize() { }

	// RVA: 0x170E298 Offset: 0x170A298 VA: 0x170E298
	public void Clear() { }

	// RVA: 0x17132F0 Offset: 0x170F2F0 VA: 0x17132F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1713344 Offset: 0x170F344 VA: 0x1713344 Slot: 3
	public override string ToString() { }

	// RVA: 0x171334C Offset: 0x170F34C VA: 0x171334C Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x170DC18 Offset: 0x1709C18 VA: 0x170DC18
	public BigInteger ModInverse(BigInteger modulus) { }

	// RVA: 0x170E170 Offset: 0x170A170 VA: 0x170E170
	public BigInteger ModPow(BigInteger exp, BigInteger n) { }

	// RVA: 0x170D6C4 Offset: 0x17096C4 VA: 0x170D6C4
	public static BigInteger GeneratePseudoPrime(int bits) { }

	// RVA: 0x1713C60 Offset: 0x170FC60 VA: 0x1713C60
	public void Incr2() { }

	// RVA: 0x1713CFC Offset: 0x170FCFC VA: 0x1713CFC
	private static void .cctor() { }
}
