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

// Namespace: System.Security.Principal
public interface IIdentity // TypeDefIndex: 784
{
	// Properties
	public abstract string Name { get; }
	public abstract string AuthenticationType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_AuthenticationType();
}

// Namespace: System.Security.Principal
public interface IPrincipal // TypeDefIndex: 785
{}

// Namespace: System.Security.Principal
public enum TokenImpersonationLevel // TypeDefIndex: 786
{
	// Fields
	public int value__; // 0x0
	public const TokenImpersonationLevel None = 0;
	public const TokenImpersonationLevel Anonymous = 1;
	public const TokenImpersonationLevel Identification = 2;
	public const TokenImpersonationLevel Impersonation = 3;
	public const TokenImpersonationLevel Delegation = 4;
}

// Namespace: System.Security.Principal
[ComVisible(True)]
[Serializable]
public enum WindowsAccountType // TypeDefIndex: 787
{
	// Fields
	public int value__; // 0x0
	public const WindowsAccountType Normal = 0;
	public const WindowsAccountType Guest = 1;
	public const WindowsAccountType System = 2;
	public const WindowsAccountType Anonymous = 3;
}

// Namespace: System.Security.Principal
[ComVisible(True)]
[Serializable]
public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable // TypeDefIndex: 788
{
	// Fields
	private IntPtr _token; // 0x78
	private string _type; // 0x80
	private WindowsAccountType _account; // 0x88
	private bool _authenticated; // 0x8C
	private string _name; // 0x90
	private SerializationInfo _info; // 0x98
	private static IntPtr invalidWindows; // 0x0

	// Properties
	public sealed override string AuthenticationType { get; }
	public override string Name { get; }

	// Methods

	// RVA: 0x177BF64 Offset: 0x1777F64 VA: 0x177BF64
	public void .ctor(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated) { }

	// RVA: 0x177C114 Offset: 0x1778114 VA: 0x177C114
	public void .ctor(SerializationInfo info, StreamingContext context) { }

	[ComVisible(False)]
	// RVA: 0x177C144 Offset: 0x1778144 VA: 0x177C144 Slot: 14
	public void Dispose() { }

	// RVA: 0x177C14C Offset: 0x177814C VA: 0x177C14C
	public static WindowsIdentity GetCurrent() { }

	// RVA: 0x177C1CC Offset: 0x17781CC VA: 0x177C1CC Slot: 15
	public virtual WindowsImpersonationContext Impersonate() { }

	// RVA: 0x177C2B0 Offset: 0x17782B0 VA: 0x177C2B0 Slot: 6
	public sealed override string get_AuthenticationType() { }

	// RVA: 0x177C2B8 Offset: 0x17782B8 VA: 0x177C2B8 Slot: 8
	public override string get_Name() { }

	// RVA: 0x177C338 Offset: 0x1778338 VA: 0x177C338 Slot: 12
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x177C61C Offset: 0x177861C VA: 0x177C61C Slot: 13
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x177BFCC Offset: 0x1777FCC VA: 0x177BFCC
	private void SetToken(IntPtr token) { }

	// RVA: 0x177C1C8 Offset: 0x17781C8 VA: 0x177C1C8
	internal static IntPtr GetCurrentToken() { }

	// RVA: 0x177C334 Offset: 0x1778334 VA: 0x177C334
	private static string GetTokenName(IntPtr token) { }

	// RVA: 0x177C778 Offset: 0x1778778 VA: 0x177C778
	private static void .cctor() { }
}

// Namespace: System.Security.Principal
[ComVisible(True)]
public class WindowsImpersonationContext : IDisposable // TypeDefIndex: 789
{
	// Fields
	private IntPtr _token; // 0x10
	private bool undo; // 0x18

	// Methods

	// RVA: 0x177C228 Offset: 0x1778228 VA: 0x177C228
	internal void .ctor(IntPtr token) { }

	[ComVisible(False)]
	// RVA: 0x177C7C8 Offset: 0x17787C8 VA: 0x177C7C8 Slot: 4
	public void Dispose() { }

	// RVA: 0x177C7D8 Offset: 0x17787D8 VA: 0x177C7D8
	public void Undo() { }

	// RVA: 0x177C89C Offset: 0x177889C VA: 0x177C89C
	private static bool CloseToken(IntPtr token) { }

	// RVA: 0x177C7C0 Offset: 0x17787C0 VA: 0x177C7C0
	private static IntPtr DuplicateToken(IntPtr token) { }

	// RVA: 0x177C7C4 Offset: 0x17787C4 VA: 0x177C7C4
	private static bool SetCurrentToken(IntPtr token) { }

	// RVA: 0x177C898 Offset: 0x1778898 VA: 0x177C898
	private static bool RevertToSelf() { }
}
