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

// Namespace: System.Security
public interface IPermission : ISecurityEncodable // TypeDefIndex: 672
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Demand();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsSubsetOf(IPermission target);
}

// Namespace: System.Security
public interface ISecurityEncodable // TypeDefIndex: 673
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract SecurityElement ToXml();
}

// Namespace: System.Security
[Serializable]
public sealed class XmlSyntaxException : SystemException // TypeDefIndex: 674
{
	// Methods

	// RVA: 0x1755B04 Offset: 0x1751B04 VA: 0x1755B04
	public void .ctor() { }

	// RVA: 0x1755B0C Offset: 0x1751B0C VA: 0x1755B0C
	public void .ctor(int lineNumber) { }

	// RVA: 0x1755B14 Offset: 0x1751B14 VA: 0x1755B14
	public void .ctor(int lineNumber, string message) { }

	// RVA: 0x1755B1C Offset: 0x1751B1C VA: 0x1755B1C
	private void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Security
[Serializable]
internal sealed class SecurityDocument // TypeDefIndex: 675
{
	// Fields
	internal byte[] m_data; // 0x10

	// Methods

	// RVA: 0x1755B24 Offset: 0x1751B24 VA: 0x1755B24
	public void .ctor(int numData) { }

	// RVA: 0x1755B94 Offset: 0x1751B94 VA: 0x1755B94
	public void GuaranteeSize(int size) { }

	// RVA: 0x1755C4C Offset: 0x1751C4C VA: 0x1755C4C
	public void AddString(string str, ref int position) { }

	// RVA: 0x1755D98 Offset: 0x1751D98 VA: 0x1755D98
	public void AppendString(string str, ref int position) { }

	// RVA: 0x1755E24 Offset: 0x1751E24 VA: 0x1755E24
	public static int EncodedStringSize(string str) { }

	// RVA: 0x1755E40 Offset: 0x1751E40 VA: 0x1755E40
	public string GetString(ref int position, bool bCreate) { }

	// RVA: 0x1756394 Offset: 0x1752394 VA: 0x1756394
	public void AddToken(byte b, ref int position) { }

	// RVA: 0x17563F0 Offset: 0x17523F0 VA: 0x17563F0
	public SecurityElement GetRootElement() { }

	// RVA: 0x175640C Offset: 0x175240C VA: 0x175640C
	public SecurityElement GetElement(int position, bool bCreate) { }

	// RVA: 0x1756424 Offset: 0x1752424 VA: 0x1756424
	internal SecurityElement InternalGetElement(ref int position, bool bCreate) { }
}

// Namespace: System.Security
[MonoTODO("CAS support is experimental (and unsupported).")]
[ComVisible(True)]
[Serializable]
public abstract class CodeAccessPermission : IPermission, ISecurityEncodable // TypeDefIndex: 676
{
	// Methods

	// RVA: 0x17568A4 Offset: 0x17528A4 VA: 0x17568A4
	protected void .ctor() { }

	[Conditional("MONO_FEATURE_CAS")]
	// RVA: 0x17568AC Offset: 0x17528AC VA: 0x17568AC Slot: 7
	public void Demand() { }

	[ComVisible(False)]
	// RVA: 0x17569BC Offset: 0x17529BC VA: 0x17569BC Slot: 0
	public override bool Equals(object obj) { }

	[ComVisible(False)]
	// RVA: 0x1756AD4 Offset: 0x1752AD4 VA: 0x1756AD4 Slot: 2
	public override int GetHashCode() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract bool IsSubsetOf(IPermission target);

	// RVA: 0x1756ADC Offset: 0x1752ADC VA: 0x1756ADC Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract SecurityElement ToXml();

	// RVA: 0x1756B04 Offset: 0x1752B04 VA: 0x1756B04
	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

	// RVA: 0x1756BB0 Offset: 0x1752BB0 VA: 0x1756BB0 Slot: 4
	private void System.Security.IPermission.Demand() { }
}

// Namespace: System.Security
[ComVisible(True)]
[Serializable]
public sealed class NamedPermissionSet : PermissionSet // TypeDefIndex: 677
{
	// Fields
	private string name; // 0x30
	private string description; // 0x38

	// Properties
	public string Name { get; set; }

	// Methods

	// RVA: 0x1756BB4 Offset: 0x1752BB4 VA: 0x1756BB4
	internal void .ctor() { }

	// RVA: 0x1756C74 Offset: 0x1752C74 VA: 0x1756C74
	public void .ctor(string name, PermissionState state) { }

	// RVA: 0x1756DC4 Offset: 0x1752DC4 VA: 0x1756DC4
	public void .ctor(string name) { }

	// RVA: 0x1756DCC Offset: 0x1752DCC VA: 0x1756DCC
	public string get_Name() { }

	// RVA: 0x1756D24 Offset: 0x1752D24 VA: 0x1756D24
	public void set_Name(string value) { }

	// RVA: 0x1756DD4 Offset: 0x1752DD4 VA: 0x1756DD4 Slot: 13
	public override SecurityElement ToXml() { }

	[ComVisible(False)]
	// RVA: 0x1757290 Offset: 0x1753290 VA: 0x1757290 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisible(False)]
	// RVA: 0x17574A8 Offset: 0x17534A8 VA: 0x17574A8 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: System.Security
[MonoTODO("CAS support is experimental (and unsupported).")]
[ComVisible(True)]
[Serializable]
public class PermissionSet : ISecurityEncodable, ICollection, IEnumerable, IDeserializationCallback // TypeDefIndex: 678
{
	// Fields
	private static object[] psUnrestricted; // 0x0
	private PermissionState state; // 0x10
	private ArrayList list; // 0x18
	private bool _declsec; // 0x20
	private bool[] _ignored; // 0x28
	private static object[] action; // 0x8

	// Properties
	public virtual int Count { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }

	// Methods

	// RVA: 0x1756C08 Offset: 0x1752C08 VA: 0x1756C08
	internal void .ctor() { }

	// RVA: 0x1756CF4 Offset: 0x1752CF4 VA: 0x1756CF4
	public void .ctor(PermissionState state) { }

	// RVA: 0x17568E0 Offset: 0x17528E0 VA: 0x17568E0
	internal void .ctor(IPermission perm) { }

	// RVA: 0x1757524 Offset: 0x1753524 VA: 0x1757524 Slot: 11
	public virtual void CopyTo(Array array, int index) { }

	// RVA: 0x175768C Offset: 0x175368C VA: 0x175768C Slot: 12
	public void Demand() { }

	// RVA: 0x175692C Offset: 0x175292C VA: 0x175692C
	internal void CasOnlyDemand(int skip) { }

	// RVA: 0x1757C38 Offset: 0x1753C38 VA: 0x1757C38 Slot: 9
	public IEnumerator GetEnumerator() { }

	// RVA: 0x17578C4 Offset: 0x17538C4 VA: 0x17578C4
	public bool IsEmpty() { }

	// RVA: 0x1757C28 Offset: 0x1753C28 VA: 0x1757C28
	public bool IsUnrestricted() { }

	// RVA: 0x1757C58 Offset: 0x1753C58 VA: 0x1757C58 Slot: 3
	public override string ToString() { }

	// RVA: 0x1756E6C Offset: 0x1752E6C VA: 0x1756E6C Slot: 13
	public virtual SecurityElement ToXml() { }

	// RVA: 0x1757C84 Offset: 0x1753C84 VA: 0x1757C84 Slot: 14
	public virtual int get_Count() { }

	// RVA: 0x1757CA4 Offset: 0x1753CA4 VA: 0x1757CA4 Slot: 15
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x1757CC4 Offset: 0x1753CC4 VA: 0x1757CC4 Slot: 16
	public virtual object get_SyncRoot() { }

	[MonoTODO("may not be required")]
	// RVA: 0x1757CC8 Offset: 0x1753CC8 VA: 0x1757CC8 Slot: 10
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[ComVisible(False)]
	// RVA: 0x1757314 Offset: 0x1753314 VA: 0x1757314 Slot: 0
	public override bool Equals(object obj) { }

	[ComVisible(False)]
	// RVA: 0x17574E0 Offset: 0x17534E0 VA: 0x17574E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1757CCC Offset: 0x1753CCC VA: 0x1757CCC
	private static void .cctor() { }
}

// Namespace: System.Security
[MonoTODO("work in progress - encryption is missing")]
public sealed class SecureString : IDisposable // TypeDefIndex: 679
{
	// Fields
	private int length; // 0x10
	private bool disposed; // 0x14
	private byte[] data; // 0x18

	// Properties
	public int Length { get; }

	// Methods

	// RVA: 0x1757E4C Offset: 0x1753E4C VA: 0x1757E4C
	public void .ctor() { }

	[CLSCompliant(False)]
	// RVA: 0x175800C Offset: 0x175400C VA: 0x175800C
	public void .ctor(char* value, int length) { }

	// RVA: 0x1758148 Offset: 0x1754148 VA: 0x1758148
	public int get_Length() { }

	// RVA: 0x17581A4 Offset: 0x17541A4 VA: 0x17581A4 Slot: 4
	public void Dispose() { }

	// RVA: 0x1758144 Offset: 0x1754144 VA: 0x1758144
	private void Encrypt() { }

	// RVA: 0x17581F4 Offset: 0x17541F4 VA: 0x17581F4
	private void Decrypt() { }

	// RVA: 0x1757E70 Offset: 0x1753E70 VA: 0x1757E70
	private void Alloc(int length, bool realloc) { }

	// RVA: 0x17581F8 Offset: 0x17541F8 VA: 0x17581F8
	internal byte[] GetBuffer() { }
}

// Namespace: System.Security
internal enum SecurityElementType // TypeDefIndex: 680
{
	// Fields
	public int value__; // 0x0
	public const SecurityElementType Regular = 0;
	public const SecurityElementType Format = 1;
	public const SecurityElementType Comment = 2;
}

// Namespace: 
internal class SecurityElement.SecurityAttribute // TypeDefIndex: 681
{
	// Fields
	private string _name; // 0x10
	private string _value; // 0x18

	// Properties
	public string Name { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x1758A98 Offset: 0x1754A98 VA: 0x1758A98
	public void .ctor(string name, string value) { }

	// RVA: 0x1759ADC Offset: 0x1755ADC VA: 0x1759ADC
	public string get_Name() { }

	// RVA: 0x1759AE4 Offset: 0x1755AE4 VA: 0x1759AE4
	public string get_Value() { }
}

// Namespace: System.Security
[ComVisible(True)]
[Serializable]
public sealed class SecurityElement // TypeDefIndex: 682
{
	// Fields
	private string text; // 0x10
	private string tag; // 0x18
	private ArrayList attributes; // 0x20
	private ArrayList children; // 0x28
	private static readonly char[] invalid_tag_chars; // 0x0
	private static readonly char[] invalid_text_chars; // 0x8
	private static readonly char[] invalid_attr_name_chars; // 0x10
	private static readonly char[] invalid_attr_value_chars; // 0x18
	private static readonly char[] invalid_chars; // 0x20

	// Properties
	public ArrayList Children { get; }
	public string Tag { get; }
	public string Text { set; }
	internal string m_strText { set; }

	// Methods

	// RVA: 0x1756620 Offset: 0x1752620 VA: 0x1756620
	public void .ctor(string tag) { }

	// RVA: 0x17582A8 Offset: 0x17542A8 VA: 0x17582A8
	public void .ctor(string tag, string text) { }

	// RVA: 0x1758570 Offset: 0x1754570 VA: 0x1758570
	public ArrayList get_Children() { }

	// RVA: 0x1758578 Offset: 0x1754578 VA: 0x1758578
	public string get_Tag() { }

	// RVA: 0x1758474 Offset: 0x1754474 VA: 0x1758474
	public void set_Text(string value) { }

	// RVA: 0x1756628 Offset: 0x1752628 VA: 0x1756628
	public void AddAttribute(string name, string value) { }

	// RVA: 0x17567CC Offset: 0x17527CC VA: 0x17567CC
	public void AddChild(SecurityElement child) { }

	// RVA: 0x1758C08 Offset: 0x1754C08 VA: 0x1758C08
	public static string Escape(string str) { }

	// RVA: 0x17585FC Offset: 0x17545FC VA: 0x17585FC
	private static string Unescape(string str) { }

	// RVA: 0x1758E10 Offset: 0x1754E10 VA: 0x1758E10
	public static bool IsValidAttributeName(string name) { }

	// RVA: 0x1758E8C Offset: 0x1754E8C VA: 0x1758E8C
	public static bool IsValidAttributeValue(string value) { }

	// RVA: 0x17583F8 Offset: 0x17543F8 VA: 0x17583F8
	public static bool IsValidTag(string tag) { }

	// RVA: 0x1758580 Offset: 0x1754580 VA: 0x1758580
	public static bool IsValidText(string text) { }

	// RVA: 0x1758F08 Offset: 0x1754F08 VA: 0x1758F08
	public SecurityElement SearchForChildByTag(string tag) { }

	// RVA: 0x175902C Offset: 0x175502C VA: 0x175902C Slot: 3
	public override string ToString() { }

	// RVA: 0x17590B4 Offset: 0x17550B4 VA: 0x17590B4
	private void ToXml(ref StringBuilder s, int level) { }

	// RVA: 0x17587CC Offset: 0x17547CC VA: 0x17587CC
	internal SecurityElement.SecurityAttribute GetAttribute(string name) { }

	// RVA: 0x17596E8 Offset: 0x17556E8 VA: 0x17596E8
	internal void set_m_strText(string value) { }

	// RVA: 0x17596F0 Offset: 0x17556F0 VA: 0x17596F0
	internal string SearchForTextOfLocalName(string strLocalName) { }

	// RVA: 0x1759930 Offset: 0x1755930 VA: 0x1759930
	private static void .cctor() { }
}

// Namespace: System.Security
[ComVisible(True)]
[Serializable]
public class SecurityException : SystemException // TypeDefIndex: 683
{
	// Fields
	private string permissionState; // 0x90

	// Methods

	// RVA: 0x1759AEC Offset: 0x1755AEC VA: 0x1759AEC
	public void .ctor() { }

	// RVA: 0x1759B54 Offset: 0x1755B54 VA: 0x1759B54
	public void .ctor(string message) { }

	// RVA: 0x1759B78 Offset: 0x1755B78 VA: 0x1759B78
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1759C98 Offset: 0x1755C98 VA: 0x1759C98
	public void .ctor(string message, Exception inner) { }

	// RVA: 0x1759CBC Offset: 0x1755CBC VA: 0x1759CBC Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1759DBC Offset: 0x1755DBC VA: 0x1759DBC Slot: 3
	public override string ToString() { }
}

// Namespace: System.Security
[ComVisible(True)]
public static class SecurityManager // TypeDefIndex: 684
{
	// Properties
	[Obsolete("The security manager cannot be turned off on MS runtime")]
	public static bool SecurityEnabled { get; }

	// Methods

	// RVA: 0x17568D8 Offset: 0x17528D8 VA: 0x17568D8
	public static bool get_SecurityEnabled() { }

	// RVA: 0x1759DC4 Offset: 0x1755DC4 VA: 0x1759DC4
	internal static void EnsureElevatedPermissions() { }
}
