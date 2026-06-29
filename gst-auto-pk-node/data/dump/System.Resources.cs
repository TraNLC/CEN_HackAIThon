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

// Namespace: System.Resources
public interface IResourceReader : IEnumerable, IDisposable // TypeDefIndex: 1157
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IDictionaryEnumerator GetEnumerator();
}

// Namespace: System.Resources
[Serializable]
public class MissingManifestResourceException : SystemException // TypeDefIndex: 1158
{
	// Methods

	// RVA: 0x17D4A54 Offset: 0x17D0A54 VA: 0x17D4A54
	public void .ctor() { }

	// RVA: 0x17D4AB0 Offset: 0x17D0AB0 VA: 0x17D4AB0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }
}

// Namespace: System.Resources
[Usage(1, AllowMultiple = False)]
public sealed class NeutralResourcesLanguageAttribute : Attribute // TypeDefIndex: 1159
{
	// Fields
	[CompilerGenerated]
	private readonly string <CultureName>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly UltimateResourceFallbackLocation <Location>k__BackingField; // 0x18

	// Properties
	public string CultureName { get; }
	public UltimateResourceFallbackLocation Location { get; }

	// Methods

	// RVA: 0x17D4AB8 Offset: 0x17D0AB8 VA: 0x17D4AB8
	public void .ctor(string cultureName) { }

	[CompilerGenerated]
	// RVA: 0x17D4B3C Offset: 0x17D0B3C VA: 0x17D4B3C
	public string get_CultureName() { }

	[CompilerGenerated]
	// RVA: 0x17D4B44 Offset: 0x17D0B44 VA: 0x17D4B44
	public UltimateResourceFallbackLocation get_Location() { }
}

// Namespace: System.Resources
internal enum ResourceTypeCode // TypeDefIndex: 1160
{
	// Fields
	public int value__; // 0x0
	public const ResourceTypeCode Null = 0;
	public const ResourceTypeCode String = 1;
	public const ResourceTypeCode Boolean = 2;
	public const ResourceTypeCode Char = 3;
	public const ResourceTypeCode Byte = 4;
	public const ResourceTypeCode SByte = 5;
	public const ResourceTypeCode Int16 = 6;
	public const ResourceTypeCode UInt16 = 7;
	public const ResourceTypeCode Int32 = 8;
	public const ResourceTypeCode UInt32 = 9;
	public const ResourceTypeCode Int64 = 10;
	public const ResourceTypeCode UInt64 = 11;
	public const ResourceTypeCode Single = 12;
	public const ResourceTypeCode Double = 13;
	public const ResourceTypeCode Decimal = 14;
	public const ResourceTypeCode DateTime = 15;
	public const ResourceTypeCode TimeSpan = 16;
	public const ResourceTypeCode LastPrimitive = 16;
	public const ResourceTypeCode ByteArray = 32;
	public const ResourceTypeCode Stream = 33;
	public const ResourceTypeCode StartOfUserTypes = 64;
}

// Namespace: System.Resources
internal sealed class RuntimeResourceSet : ResourceSet, IEnumerable // TypeDefIndex: 1161
{
	// Fields
	internal const int Version = 2;
	private Dictionary<string, ResourceLocator> _resCache; // 0x28
	private ResourceReader _defaultReader; // 0x30
	private Dictionary<string, ResourceLocator> _caseInsensitiveTable; // 0x38
	private bool _haveReadFromReader; // 0x40

	// Methods

	// RVA: 0x17D4B4C Offset: 0x17D0B4C VA: 0x17D4B4C
	internal void .ctor(string fileName) { }

	// RVA: 0x17D4DEC Offset: 0x17D0DEC VA: 0x17D4DEC
	internal void .ctor(Stream stream) { }

	// RVA: 0x17D4F0C Offset: 0x17D0F0C VA: 0x17D4F0C Slot: 6
	protected override void Dispose(bool disposing) { }

	// RVA: 0x17D5168 Offset: 0x17D1168 VA: 0x17D5168 Slot: 7
	public override IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x17D5268 Offset: 0x17D1268 VA: 0x17D5268 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x17D516C Offset: 0x17D116C VA: 0x17D516C
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0x17D526C Offset: 0x17D126C VA: 0x17D526C Slot: 8
	public override string GetString(string key) { }

	// RVA: 0x17D5B5C Offset: 0x17D1B5C VA: 0x17D5B5C Slot: 9
	public override string GetString(string key, bool ignoreCase) { }

	// RVA: 0x17D5B90 Offset: 0x17D1B90 VA: 0x17D5B90 Slot: 10
	public override object GetObject(string key) { }

	// RVA: 0x17D5B9C Offset: 0x17D1B9C VA: 0x17D5B9C Slot: 11
	public override object GetObject(string key, bool ignoreCase) { }

	// RVA: 0x17D52A4 Offset: 0x17D12A4 VA: 0x17D52A4
	private object GetObject(string key, bool ignoreCase, bool isString) { }

	// RVA: 0x17D6390 Offset: 0x17D2390 VA: 0x17D6390
	private object ResolveResourceLocator(ResourceLocator resLocation, string key, Dictionary<string, ResourceLocator> copyOfCache, bool keyInWrongCase) { }
}

// Namespace: System.Resources
[Usage(1, AllowMultiple = False)]
public sealed class SatelliteContractVersionAttribute : Attribute // TypeDefIndex: 1162
{
	// Fields
	[CompilerGenerated]
	private readonly string <Version>k__BackingField; // 0x10

	// Methods

	// RVA: 0x17D6524 Offset: 0x17D2524 VA: 0x17D6524
	public void .ctor(string version) { }
}

// Namespace: System.Resources
public enum UltimateResourceFallbackLocation // TypeDefIndex: 1163
{
	// Fields
	public int value__; // 0x0
	public const UltimateResourceFallbackLocation MainAssembly = 0;
	public const UltimateResourceFallbackLocation Satellite = 1;
}

// Namespace: System.Resources
internal sealed class FastResourceComparer : IComparer, IEqualityComparer, IComparer<string>, IEqualityComparer<string> // TypeDefIndex: 1164
{
	// Fields
	internal static readonly FastResourceComparer Default; // 0x0

	// Methods

	// RVA: 0x17D65A0 Offset: 0x17D25A0 VA: 0x17D65A0 Slot: 6
	public int GetHashCode(object key) { }

	// RVA: 0x17D668C Offset: 0x17D268C VA: 0x17D668C Slot: 9
	public int GetHashCode(string key) { }

	// RVA: 0x17D6620 Offset: 0x17D2620 VA: 0x17D6620
	internal static int HashFunction(string key) { }

	// RVA: 0x17D66E0 Offset: 0x17D26E0 VA: 0x17D66E0 Slot: 4
	public int Compare(object a, object b) { }

	// RVA: 0x17D674C Offset: 0x17D274C VA: 0x17D674C Slot: 7
	public int Compare(string a, string b) { }

	// RVA: 0x17D675C Offset: 0x17D275C VA: 0x17D675C Slot: 8
	public bool Equals(string a, string b) { }

	// RVA: 0x17D676C Offset: 0x17D276C VA: 0x17D676C Slot: 5
	public bool Equals(object a, object b) { }

	// RVA: 0x17D67D8 Offset: 0x17D27D8 VA: 0x17D67D8
	public static int CompareOrdinal(string a, byte[] bytes, int bCharLength) { }

	// RVA: 0x17D6888 Offset: 0x17D2888 VA: 0x17D6888
	public static int CompareOrdinal(byte[] bytes, int aCharLength, string b) { }

	// RVA: 0x17D68FC Offset: 0x17D28FC VA: 0x17D68FC
	internal static int CompareOrdinal(byte* a, int byteLen, string b) { }

	// RVA: 0x17D6984 Offset: 0x17D2984 VA: 0x17D6984
	public void .ctor() { }

	// RVA: 0x17D698C Offset: 0x17D298C VA: 0x17D698C
	private static void .cctor() { }
}

// Namespace: System.Resources
internal class FileBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 1165
{
	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x17D69F4 Offset: 0x17D29F4 VA: 0x17D69F4
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }
}

// Namespace: System.Resources
internal interface IResourceGroveler // TypeDefIndex: 1166
{}

// Namespace: System.Resources
internal class ManifestBasedResourceGroveler : IResourceGroveler // TypeDefIndex: 1167
{
	// Fields
	private ResourceManager.ResourceManagerMediator _mediator; // 0x10

	// Methods

	// RVA: 0x17D6A24 Offset: 0x17D2A24 VA: 0x17D6A24
	public void .ctor(ResourceManager.ResourceManagerMediator mediator) { }

	// RVA: 0x17D6A54 Offset: 0x17D2A54 VA: 0x17D6A54
	internal static CultureInfo GetNeutralResourcesLanguage(Assembly a, ref UltimateResourceFallbackLocation fallbackLocation) { }

	// RVA: 0x17D6D9C Offset: 0x17D2D9C VA: 0x17D6D9C
	private static bool GetNeutralResourcesLanguageAttribute(Assembly assembly, ref string cultureName, ref short fallbackLocation) { }
}

// Namespace: 
internal class ResourceManager.CultureNameResourceSetPair // TypeDefIndex: 1168
{
	// Methods

	// RVA: 0x17D703C Offset: 0x17D303C VA: 0x17D703C
	public void .ctor() { }
}

// Namespace: 
internal class ResourceManager.ResourceManagerMediator // TypeDefIndex: 1169
{
	// Fields
	private ResourceManager _rm; // 0x10

	// Methods

	// RVA: 0x17D7044 Offset: 0x17D3044 VA: 0x17D7044
	internal void .ctor(ResourceManager rm) { }
}

// Namespace: System.Resources
[ComVisible(True)]
[Serializable]
public class ResourceManager // TypeDefIndex: 1170
{
	// Fields
	[Obsolete("call InternalGetResourceSet instead")]
	protected Hashtable ResourceSets; // 0x10
	private Dictionary<string, ResourceSet> _resourceSets; // 0x18
	protected Assembly MainAssembly; // 0x20
	private CultureInfo _neutralResourcesCulture; // 0x28
	private ResourceManager.CultureNameResourceSetPair _lastUsedResourceCache; // 0x30
	private bool UseManifest; // 0x38
	[OptionalField(VersionAdded = 1)]
	private bool UseSatelliteAssem; // 0x39
	[OptionalField]
	private UltimateResourceFallbackLocation _fallbackLoc; // 0x3C
	[OptionalField(VersionAdded = 1)]
	private Assembly _callingAssembly; // 0x40
	[OptionalField(VersionAdded = 4)]
	private RuntimeAssembly m_callingAssembly; // 0x48
	private IResourceGroveler resourceGroveler; // 0x50
	public static readonly int MagicNumber; // 0x0
	public static readonly int HeaderVersionNumber; // 0x4
	private static readonly Type _minResourceSet; // 0x8
	internal static readonly string ResReaderTypeName; // 0x10
	internal static readonly string ResSetTypeName; // 0x18
	internal static readonly string MscorlibName; // 0x20
	internal static readonly int DEBUG; // 0x28

	// Methods

	// RVA: 0x17D6E20 Offset: 0x17D2E20 VA: 0x17D6E20
	private void Init() { }

	// RVA: 0x17D6F50 Offset: 0x17D2F50 VA: 0x17D6F50
	protected void .ctor() { }

	[OnDeserializing]
	// RVA: 0x17D70C0 Offset: 0x17D30C0 VA: 0x17D70C0
	private void OnDeserializing(StreamingContext ctx) { }

	[OnDeserialized]
	// RVA: 0x17D70F8 Offset: 0x17D30F8 VA: 0x17D70F8
	private void OnDeserialized(StreamingContext ctx) { }

	[OnSerializing]
	// RVA: 0x17D7328 Offset: 0x17D3328 VA: 0x17D7328
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x17D73A0 Offset: 0x17D33A0 VA: 0x17D73A0
	internal static bool CompareNames(string asmTypeName1, string typeName2, AssemblyName asmName2) { }

	// RVA: 0x17D75DC Offset: 0x17D35DC VA: 0x17D75DC
	private static void .cctor() { }
}

// Namespace: System.Resources
internal struct ResourceLocator // TypeDefIndex: 1171
{
	// Fields
	internal object _value; // 0x0
	internal int _dataPos; // 0x8

	// Properties
	internal int DataPosition { get; }
	internal object Value { get; set; }

	// Methods

	// RVA: 0x17D6210 Offset: 0x17D2210 VA: 0x17D6210
	internal void .ctor(int dataPos, object value) { }

	// RVA: 0x17D7770 Offset: 0x17D3770 VA: 0x17D7770
	internal int get_DataPosition() { }

	// RVA: 0x17D7778 Offset: 0x17D3778 VA: 0x17D7778
	internal object get_Value() { }

	// RVA: 0x17D7780 Offset: 0x17D3780 VA: 0x17D7780
	internal void set_Value(object value) { }

	// RVA: 0x17D6204 Offset: 0x17D2204 VA: 0x17D6204
	internal static bool CanCache(ResourceTypeCode value) { }
}

// Namespace: 
internal sealed class ResourceReader.ResourceEnumerator : IDictionaryEnumerator, IEnumerator // TypeDefIndex: 1172
{
	// Fields
	private ResourceReader _reader; // 0x10
	private bool _currentIsValid; // 0x18
	private int _currentName; // 0x1C
	private int _dataPosition; // 0x20

	// Properties
	public object Key { get; }
	public object Current { get; }
	internal int DataPosition { get; }
	public DictionaryEntry Entry { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x17D7CB4 Offset: 0x17D3CB4 VA: 0x17D7CB4
	internal void .ctor(ResourceReader reader) { }

	// RVA: 0x17D6348 Offset: 0x17D2348 VA: 0x17D6348 Slot: 7
	public bool MoveNext() { }

	// RVA: 0x17D6298 Offset: 0x17D2298 VA: 0x17D6298 Slot: 4
	public object get_Key() { }

	// RVA: 0x17DA564 Offset: 0x17D6564 VA: 0x17DA564 Slot: 8
	public object get_Current() { }

	// RVA: 0x17DA8FC Offset: 0x17D68FC VA: 0x17DA8FC
	internal int get_DataPosition() { }

	// RVA: 0x17DA5C8 Offset: 0x17D65C8 VA: 0x17DA5C8 Slot: 6
	public DictionaryEntry get_Entry() { }

	// RVA: 0x17DA904 Offset: 0x17D6904 VA: 0x17DA904 Slot: 5
	public object get_Value() { }

	// RVA: 0x17DA9AC Offset: 0x17D69AC VA: 0x17DA9AC Slot: 9
	public void Reset() { }
}

// Namespace: System.Resources
[ComVisible(True)]
public sealed class ResourceReader : IResourceReader, IEnumerable, IDisposable // TypeDefIndex: 1173
{
	// Fields
	private BinaryReader _store; // 0x10
	internal Dictionary<string, ResourceLocator> _resCache; // 0x18
	private long _nameSectionOffset; // 0x20
	private long _dataSectionOffset; // 0x28
	private int[] _nameHashes; // 0x30
	private int* _nameHashesPtr; // 0x38
	private int[] _namePositions; // 0x40
	private int* _namePositionsPtr; // 0x48
	private RuntimeType[] _typeTable; // 0x50
	private int[] _typeNamePositions; // 0x58
	private BinaryFormatter _objFormatter; // 0x60
	private int _numResources; // 0x68
	private UnmanagedMemoryStream _ums; // 0x70
	private int _version; // 0x78

	// Methods

	// RVA: 0x17D4CAC Offset: 0x17D0CAC VA: 0x17D4CAC
	internal void .ctor(Stream stream, Dictionary<string, ResourceLocator> resCache) { }

	// RVA: 0x17D507C Offset: 0x17D107C VA: 0x17D507C Slot: 4
	public void Close() { }

	// RVA: 0x17D79C4 Offset: 0x17D39C4 VA: 0x17D79C4 Slot: 7
	public void Dispose() { }

	// RVA: 0x17D791C Offset: 0x17D391C VA: 0x17D791C
	private void Dispose(bool disposing) { }

	// RVA: 0x17D79CC Offset: 0x17D39CC VA: 0x17D79CC
	internal static int ReadUnalignedI4(int* p) { }

	// RVA: 0x17D79D4 Offset: 0x17D39D4 VA: 0x17D79D4
	private void SkipString() { }

	// RVA: 0x17D7A84 Offset: 0x17D3A84 VA: 0x17D7A84
	private int GetNameHash(int index) { }

	// RVA: 0x17D7AC8 Offset: 0x17D3AC8 VA: 0x17D7AC8
	private int GetNamePosition(int index) { }

	// RVA: 0x17D7BE0 Offset: 0x17D3BE0 VA: 0x17D7BE0 Slot: 6
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x17D7BE4 Offset: 0x17D3BE4 VA: 0x17D7BE4 Slot: 5
	public IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x17D6220 Offset: 0x17D2220 VA: 0x17D6220
	internal ResourceReader.ResourceEnumerator GetEnumeratorInternal() { }

	// RVA: 0x17D5BA4 Offset: 0x17D1BA4 VA: 0x17D5BA4
	internal int FindPosForResource(string name) { }

	// RVA: 0x17D7CF8 Offset: 0x17D3CF8 VA: 0x17D7CF8
	private bool CompareStringEqualsName(string name) { }

	// RVA: 0x17D7EEC Offset: 0x17D3EEC VA: 0x17D7EEC
	private string AllocateStringForNameIndex(int index, out int dataOffset) { }

	// RVA: 0x17D8640 Offset: 0x17D4640 VA: 0x17D8640
	private object GetValueForNameIndex(int index) { }

	// RVA: 0x17D5F40 Offset: 0x17D1F40 VA: 0x17D5F40
	internal string LoadString(int pos) { }

	// RVA: 0x17D8E50 Offset: 0x17D4E50 VA: 0x17D8E50
	internal object LoadObject(int pos) { }

	// RVA: 0x17D61B4 Offset: 0x17D21B4 VA: 0x17D61B4
	internal object LoadObject(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x17D88CC Offset: 0x17D48CC VA: 0x17D88CC
	internal object LoadObjectV1(int pos) { }

	// RVA: 0x17D8E7C Offset: 0x17D4E7C VA: 0x17D8E7C
	private object _LoadObjectV1(int pos) { }

	// RVA: 0x17D89C4 Offset: 0x17D49C4 VA: 0x17D89C4
	internal object LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x17D975C Offset: 0x17D575C VA: 0x17D975C
	private object _LoadObjectV2(int pos, out ResourceTypeCode typeCode) { }

	// RVA: 0x17D95C0 Offset: 0x17D55C0 VA: 0x17D95C0
	private object DeserializeObject(int typeIndex) { }

	// RVA: 0x17D7788 Offset: 0x17D3788 VA: 0x17D7788
	private void ReadResources() { }

	// RVA: 0x17D9EA8 Offset: 0x17D5EA8 VA: 0x17D9EA8
	private void _ReadResources() { }

	// RVA: 0x17D8ABC Offset: 0x17D4ABC VA: 0x17D8ABC
	private RuntimeType FindType(int typeIndex) { }
}

// Namespace: System.Resources
[ComVisible(True)]
[Serializable]
public class ResourceSet : IDisposable, IEnumerable // TypeDefIndex: 1174
{
	// Fields
	protected IResourceReader Reader; // 0x10
	protected Hashtable Table; // 0x18
	private Hashtable _caseInsensitiveTable; // 0x20

	// Methods

	// RVA: 0x17DAA30 Offset: 0x17D6A30 VA: 0x17DAA30
	protected void .ctor() { }

	// RVA: 0x17D4CA4 Offset: 0x17D0CA4 VA: 0x17D4CA4
	internal void .ctor(bool junk) { }

	// RVA: 0x17DAA4C Offset: 0x17D6A4C VA: 0x17DAA4C
	private void CommonInit() { }

	// RVA: 0x17D5084 Offset: 0x17D1084 VA: 0x17D5084 Slot: 6
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x17DAAAC Offset: 0x17D6AAC VA: 0x17DAAAC Slot: 4
	public void Dispose() { }

	[ComVisible(False)]
	// RVA: 0x17DAABC Offset: 0x17D6ABC VA: 0x17DAABC Slot: 7
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x17DAB34 Offset: 0x17D6B34 VA: 0x17DAB34 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x17DAAC0 Offset: 0x17D6AC0 VA: 0x17DAAC0
	private IDictionaryEnumerator GetEnumeratorHelper() { }

	// RVA: 0x17DAB38 Offset: 0x17D6B38 VA: 0x17DAB38 Slot: 8
	public virtual string GetString(string name) { }

	// RVA: 0x17DAD34 Offset: 0x17D6D34 VA: 0x17DAD34 Slot: 9
	public virtual string GetString(string name, bool ignoreCase) { }

	// RVA: 0x17DB1E0 Offset: 0x17D71E0 VA: 0x17DB1E0 Slot: 10
	public virtual object GetObject(string name) { }

	// RVA: 0x17DB1E4 Offset: 0x17D71E4 VA: 0x17DB1E4 Slot: 11
	public virtual object GetObject(string name, bool ignoreCase) { }

	// RVA: 0x17DAC6C Offset: 0x17D6C6C VA: 0x17DAC6C
	private object GetObjectInternal(string name) { }

	// RVA: 0x17DAF08 Offset: 0x17D6F08 VA: 0x17DAF08
	private object GetCaseInsensitiveObjectInternal(string name) { }
}
