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

// Namespace: Mono.Http
internal class NtlmSession // TypeDefIndex: 3815
{
	// Fields
	private MessageBase message; // 0x10

	// Methods

	// RVA: 0x1A2A180 Offset: 0x1A26180 VA: 0x1A2A180
	public void .ctor() { }

	// RVA: 0x1A2A188 Offset: 0x1A26188 VA: 0x1A2A188
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class NtlmClient.<>c // TypeDefIndex: 3816
{
	// Fields
	public static readonly NtlmClient.<>c <>9; // 0x0
	public static ConditionalWeakTable.CreateValueCallback<HttpWebRequest, NtlmSession> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x1A2AA7C Offset: 0x1A26A7C VA: 0x1A2AA7C
	private static void .cctor() { }

	// RVA: 0x1A2AAE4 Offset: 0x1A26AE4 VA: 0x1A2AAE4
	public void .ctor() { }

	// RVA: 0x1A2AAEC Offset: 0x1A26AEC VA: 0x1A2AAEC
	internal NtlmSession <Authenticate>b__1_0(HttpWebRequest x) { }
}

// Namespace: Mono.Http
internal class NtlmClient : IAuthenticationModule // TypeDefIndex: 3817
{
	// Fields
	private static readonly ConditionalWeakTable<HttpWebRequest, NtlmSession> cache; // 0x0

	// Properties
	public string AuthenticationType { get; }

	// Methods

	// RVA: 0x1A2A620 Offset: 0x1A26620 VA: 0x1A2A620 Slot: 4
	public Authorization Authenticate(string challenge, WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1A2A994 Offset: 0x1A26994 VA: 0x1A2A994 Slot: 5
	public Authorization PreAuthenticate(WebRequest webRequest, ICredentials credentials) { }

	// RVA: 0x1A2A99C Offset: 0x1A2699C VA: 0x1A2A99C Slot: 6
	public string get_AuthenticationType() { }

	// RVA: 0x1A2A9DC Offset: 0x1A269DC VA: 0x1A2A9DC
	public void .ctor() { }

	// RVA: 0x1A2A9E4 Offset: 0x1A269E4 VA: 0x1A2A9E4
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class OidLookup.<>c // TypeDefIndex: 3818
{
	// Fields
	public static readonly OidLookup.<>c <>9; // 0x0

	// Methods

	// RVA: 0x1A2D1EC Offset: 0x1A291EC VA: 0x1A2D1EC
	private static void .cctor() { }

	// RVA: 0x1A2D254 Offset: 0x1A29254 VA: 0x1A2D254
	public void .ctor() { }

	// RVA: 0x1A2D25C Offset: 0x1A2925C VA: 0x1A2D25C
	internal string <.cctor>b__10_0(KeyValuePair<string, string> kvp) { }

	// RVA: 0x1A2D298 Offset: 0x1A29298 VA: 0x1A2D298
	internal string <.cctor>b__10_1(KeyValuePair<string, string> kvp) { }
}
