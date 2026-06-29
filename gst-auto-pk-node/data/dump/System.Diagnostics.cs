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

// Namespace: System.Diagnostics
[Usage(68, AllowMultiple = True)]
[Serializable]
public sealed class ConditionalAttribute : Attribute // TypeDefIndex: 1362
{
	// Fields
	[CompilerGenerated]
	private readonly string <ConditionString>k__BackingField; // 0x10

	// Methods

	// RVA: 0x184015C Offset: 0x183C15C VA: 0x184015C
	public void .ctor(string conditionString) { }
}

// Namespace: System.Diagnostics
[Usage(108, Inherited = False)]
internal sealed class StackTraceHiddenAttribute : Attribute // TypeDefIndex: 1363
{
	// Methods

	// RVA: 0x184018C Offset: 0x183C18C VA: 0x184018C
	public void .ctor() { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[Usage(108, Inherited = False)]
[Serializable]
public sealed class DebuggerStepThroughAttribute : Attribute // TypeDefIndex: 1364
{
	// Methods

	// RVA: 0x1840194 Offset: 0x183C194 VA: 0x1840194
	public void .ctor() { }
}

// Namespace: System.Diagnostics
[Usage(224, Inherited = False)]
[ComVisible(True)]
[Serializable]
public sealed class DebuggerHiddenAttribute : Attribute // TypeDefIndex: 1365
{
	// Methods

	// RVA: 0x184019C Offset: 0x183C19C VA: 0x184019C
	public void .ctor() { }
}

// Namespace: System.Diagnostics
[Usage(236, Inherited = False)]
[ComVisible(True)]
[Serializable]
public sealed class DebuggerNonUserCodeAttribute : Attribute // TypeDefIndex: 1366
{
	// Methods

	// RVA: 0x18401A4 Offset: 0x183C1A4 VA: 0x18401A4
	public void .ctor() { }
}

// Namespace: 
[ComVisible(True)]
[Flags]
public enum DebuggableAttribute.DebuggingModes // TypeDefIndex: 1367
{
	// Fields
	public int value__; // 0x0
	public const DebuggableAttribute.DebuggingModes None = 0;
	public const DebuggableAttribute.DebuggingModes Default = 1;
	public const DebuggableAttribute.DebuggingModes DisableOptimizations = 256;
	public const DebuggableAttribute.DebuggingModes IgnoreSymbolStoreSequencePoints = 2;
	public const DebuggableAttribute.DebuggingModes EnableEditAndContinue = 4;
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[Usage(3, AllowMultiple = False)]
public sealed class DebuggableAttribute : Attribute // TypeDefIndex: 1368
{
	// Fields
	private DebuggableAttribute.DebuggingModes m_debuggingModes; // 0x10

	// Methods

	// RVA: 0x18401AC Offset: 0x183C1AC VA: 0x18401AC
	public void .ctor(DebuggableAttribute.DebuggingModes modes) { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
public enum DebuggerBrowsableState // TypeDefIndex: 1369
{
	// Fields
	public int value__; // 0x0
	public const DebuggerBrowsableState Never = 0;
	public const DebuggerBrowsableState Collapsed = 2;
	public const DebuggerBrowsableState RootHidden = 3;
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[Usage(384, AllowMultiple = False)]
public sealed class DebuggerBrowsableAttribute : Attribute // TypeDefIndex: 1370
{
	// Fields
	private DebuggerBrowsableState state; // 0x10

	// Methods

	// RVA: 0x18401D4 Offset: 0x183C1D4 VA: 0x18401D4
	public void .ctor(DebuggerBrowsableState state) { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[Usage(13, AllowMultiple = True)]
public sealed class DebuggerTypeProxyAttribute : Attribute // TypeDefIndex: 1371
{
	// Fields
	private string typeName; // 0x10

	// Methods

	// RVA: 0x184024C Offset: 0x183C24C VA: 0x184024C
	public void .ctor(Type type) { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
[Usage(4509, AllowMultiple = True)]
public sealed class DebuggerDisplayAttribute : Attribute // TypeDefIndex: 1372
{
	// Fields
	private string name; // 0x10
	private string value; // 0x18
	private string type; // 0x20

	// Properties
	public string Name { set; }
	public string Type { set; }

	// Methods

	// RVA: 0x184030C Offset: 0x183C30C VA: 0x184030C
	public void .ctor(string value) { }

	// RVA: 0x184039C Offset: 0x183C39C VA: 0x184039C
	public void set_Name(string value) { }

	// RVA: 0x18403A4 Offset: 0x183C3A4 VA: 0x18403A4
	public void set_Type(string value) { }
}

// Namespace: System.Diagnostics
[ComVisible(True)]
public sealed class Debugger // TypeDefIndex: 1373
{
	// Fields
	public static readonly string DefaultCategory; // 0x0

	// Methods

	// RVA: 0x18403AC Offset: 0x183C3AC VA: 0x18403AC
	public static void NotifyOfCrossThreadDependency() { }

	// RVA: 0x18403B0 Offset: 0x183C3B0 VA: 0x18403B0
	private static void .cctor() { }
}

// Namespace: System.Diagnostics
[MonoTODO("Serialized objects are not compatible with MS.NET")]
[ComVisible(True)]
[Serializable]
public class StackFrame // TypeDefIndex: 1374
{
	// Fields
	public const int OFFSET_UNKNOWN = -1;
	private int ilOffset; // 0x10
	private int nativeOffset; // 0x14
	private long methodAddress; // 0x18
	private uint methodIndex; // 0x20
	private MethodBase methodBase; // 0x28
	private string fileName; // 0x30
	private int lineNumber; // 0x38
	private int columnNumber; // 0x3C
	private string internalMethodName; // 0x40

	// Methods

	// RVA: 0x1840418 Offset: 0x183C418 VA: 0x1840418
	private static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column) { }

	// RVA: 0x184041C Offset: 0x183C41C VA: 0x184041C
	public void .ctor() { }

	// RVA: 0x1840468 Offset: 0x183C468 VA: 0x1840468
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x18404C4 Offset: 0x183C4C4 VA: 0x18404C4 Slot: 4
	public virtual int GetFileLineNumber() { }

	// RVA: 0x18404CC Offset: 0x183C4CC VA: 0x18404CC Slot: 5
	public virtual string GetFileName() { }

	// RVA: 0x18404D4 Offset: 0x183C4D4 VA: 0x18404D4
	internal string GetSecureFileName() { }

	// RVA: 0x18405A8 Offset: 0x183C5A8 VA: 0x18405A8 Slot: 6
	public virtual int GetILOffset() { }

	// RVA: 0x18405B0 Offset: 0x183C5B0 VA: 0x18405B0 Slot: 7
	public virtual MethodBase GetMethod() { }

	// RVA: 0x18405B8 Offset: 0x183C5B8 VA: 0x18405B8 Slot: 8
	public virtual int GetNativeOffset() { }

	// RVA: 0x18405C0 Offset: 0x183C5C0 VA: 0x18405C0
	internal long GetMethodAddress() { }

	// RVA: 0x18405C8 Offset: 0x183C5C8 VA: 0x18405C8
	internal uint GetMethodIndex() { }

	// RVA: 0x18405D0 Offset: 0x183C5D0 VA: 0x18405D0
	internal string GetInternalMethodName() { }

	// RVA: 0x18405D8 Offset: 0x183C5D8 VA: 0x18405D8 Slot: 3
	public override string ToString() { }
}

// Namespace: 
internal enum StackTrace.TraceFormat // TypeDefIndex: 1375
{
	// Fields
	public int value__; // 0x0
	public const StackTrace.TraceFormat Normal = 0;
	public const StackTrace.TraceFormat TrailingNewLine = 1;
	public const StackTrace.TraceFormat NoResourceLookup = 2;
}

// Namespace: System.Diagnostics
[MonoTODO("Serialized objects are not compatible with .NET")]
[ComVisible(True)]
[Serializable]
public class StackTrace // TypeDefIndex: 1376
{
	// Fields
	private StackFrame[] frames; // 0x10
	private readonly StackTrace[] captured_traces; // 0x18
	private bool debug_info; // 0x20
	private static bool isAotidSet; // 0x0
	private static string aotid; // 0x8

	// Properties
	public virtual int FrameCount { get; }

	// Methods

	// RVA: 0x184080C Offset: 0x183C80C VA: 0x184080C
	public void .ctor() { }

	// RVA: 0x1840A44 Offset: 0x183CA44 VA: 0x1840A44
	public void .ctor(bool fNeedFileInfo) { }

	// RVA: 0x1840A74 Offset: 0x183CA74 VA: 0x1840A74
	public void .ctor(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x1840830 Offset: 0x183C830 VA: 0x1840830
	private void init_frames(int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x1840AA8 Offset: 0x183CAA8 VA: 0x1840AA8
	private static StackFrame[] get_trace(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x1840AAC Offset: 0x183CAAC VA: 0x1840AAC
	public void .ctor(Exception e, bool fNeedFileInfo) { }

	// RVA: 0x1840AB8 Offset: 0x183CAB8 VA: 0x1840AB8
	public void .ctor(Exception e, int skipFrames, bool fNeedFileInfo) { }

	// RVA: 0x1840BB0 Offset: 0x183CBB0 VA: 0x1840BB0 Slot: 4
	public virtual int get_FrameCount() { }

	// RVA: 0x1840BC8 Offset: 0x183CBC8 VA: 0x1840BC8 Slot: 5
	public virtual StackFrame GetFrame(int index) { }

	// RVA: 0x1840C28 Offset: 0x183CC28 VA: 0x1840C28
	private static string GetAotId() { }

	// RVA: 0x1840CF8 Offset: 0x183CCF8 VA: 0x1840CF8
	private bool AddFrames(StringBuilder sb, bool separator, out bool isAsync) { }

	// RVA: 0x1841178 Offset: 0x183D178 VA: 0x1841178
	private void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi, bool needsNewLine, out bool skipped, out bool isAsync) { }

	// RVA: 0x18417A0 Offset: 0x183D7A0 VA: 0x18417A0
	private static void ConvertAsyncStateMachineMethod(ref MethodBase method, ref Type declaringType) { }

	// RVA: 0x1841BD0 Offset: 0x183DBD0 VA: 0x1841BD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1841D30 Offset: 0x183DD30 VA: 0x1841D30
	internal string ToString(StackTrace.TraceFormat traceFormat) { }
}

// Namespace: System.Diagnostics
[SwitchLevel(typeof(bool))]
public class BooleanSwitch : Switch // TypeDefIndex: 3894
{
	// Methods

	// RVA: 0x1D1505C Offset: 0x1D1105C VA: 0x1D1505C
	public void .ctor(string displayName, string description) { }
}

// Namespace: System.Diagnostics
public abstract class Switch // TypeDefIndex: 3895
{
	// Fields
	private readonly string description; // 0x10
	private readonly string displayName; // 0x18
	private string switchValueString; // 0x20
	private string defaultValue; // 0x28
	private static List<WeakReference> switches; // 0x0
	private static int s_LastCollectionCount; // 0x8

	// Methods

	// RVA: 0x1D150C8 Offset: 0x1D110C8 VA: 0x1D150C8
	protected void .ctor(string displayName, string description) { }

	// RVA: 0x1D15128 Offset: 0x1D11128 VA: 0x1D15128
	protected void .ctor(string displayName, string description, string defaultSwitchValue) { }

	// RVA: 0x1D15390 Offset: 0x1D11390 VA: 0x1D15390
	private static void _pruneCachedSwitches() { }

	// RVA: 0x1D1585C Offset: 0x1D1185C VA: 0x1D1585C
	private static void .cctor() { }
}

// Namespace: System.Diagnostics
[Usage(4)]
public sealed class SwitchLevelAttribute : Attribute // TypeDefIndex: 3896
{
	// Fields
	private Type type; // 0x10

	// Properties
	public Type SwitchLevelType { set; }

	// Methods

	// RVA: 0x1D158F4 Offset: 0x1D118F4 VA: 0x1D158F4
	public void .ctor(Type switchLevelType) { }

	// RVA: 0x1D15920 Offset: 0x1D11920 VA: 0x1D15920
	public void set_SwitchLevelType(Type value) { }
}

// Namespace: System.Diagnostics
public enum TraceLevel // TypeDefIndex: 3897
{
	// Fields
	public int value__; // 0x0
	public const TraceLevel Off = 0;
	public const TraceLevel Error = 1;
	public const TraceLevel Warning = 2;
	public const TraceLevel Info = 3;
	public const TraceLevel Verbose = 4;
}

// Namespace: System.Diagnostics
[SwitchLevel(typeof(TraceLevel))]
public class TraceSwitch : Switch // TypeDefIndex: 3898
{
	// Methods

	// RVA: 0x1D159C0 Offset: 0x1D119C0 VA: 0x1D159C0
	public void .ctor(string displayName, string description) { }
}

// Namespace: System.Diagnostics
public class Stopwatch // TypeDefIndex: 3899
{
	// Fields
	public static readonly long Frequency; // 0x0
	public static readonly bool IsHighResolution; // 0x8
	private long elapsed; // 0x10
	private long started; // 0x18
	private bool is_running; // 0x20

	// Properties
	public TimeSpan Elapsed { get; }
	public long ElapsedMilliseconds { get; }
	public long ElapsedTicks { get; }

	// Methods

	// RVA: 0x1D15A2C Offset: 0x1D11A2C VA: 0x1D15A2C
	public static long GetTimestamp() { }

	// RVA: 0x1D15A30 Offset: 0x1D11A30 VA: 0x1D15A30
	public static Stopwatch StartNew() { }

	// RVA: 0x1D15A94 Offset: 0x1D11A94 VA: 0x1D15A94
	public void .ctor() { }

	// RVA: 0x1D15B04 Offset: 0x1D11B04 VA: 0x1D15B04
	public TimeSpan get_Elapsed() { }

	// RVA: 0x1D15C6C Offset: 0x1D11C6C VA: 0x1D15C6C
	public long get_ElapsedMilliseconds() { }

	// RVA: 0x1D15BFC Offset: 0x1D11BFC VA: 0x1D15BFC
	public long get_ElapsedTicks() { }

	// RVA: 0x1D15A9C Offset: 0x1D11A9C VA: 0x1D15A9C
	public void Start() { }

	// RVA: 0x1D15DB0 Offset: 0x1D11DB0 VA: 0x1D15DB0
	public void Stop() { }

	// RVA: 0x1D15E28 Offset: 0x1D11E28 VA: 0x1D15E28
	public void Restart() { }

	// RVA: 0x1D15E88 Offset: 0x1D11E88 VA: 0x1D15E88
	private static void .cctor() { }
}

// Namespace: System.Diagnostics
[Obsolete("This class has been deprecated.  http://go.microsoft.com/fwlink/?linkid=14202")]
public class DiagnosticsConfigurationHandler : IConfigurationSectionHandler // TypeDefIndex: 4407
{
	// Methods

	// RVA: 0x1CF0798 Offset: 0x1CEC798 VA: 0x1CF0798
	public void .ctor() { }

	// RVA: 0x1CF07D0 Offset: 0x1CEC7D0 VA: 0x1CF07D0 Slot: 4
	public virtual object Create(object parent, object configContext, XmlNode section) { }
}
