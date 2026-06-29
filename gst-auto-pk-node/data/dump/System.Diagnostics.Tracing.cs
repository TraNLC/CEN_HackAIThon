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

// Namespace: System.Diagnostics.Tracing
public enum EventLevel // TypeDefIndex: 1378
{
	// Fields
	public int value__; // 0x0
	public const EventLevel LogAlways = 0;
	public const EventLevel Critical = 1;
	public const EventLevel Error = 2;
	public const EventLevel Warning = 3;
	public const EventLevel Informational = 4;
	public const EventLevel Verbose = 5;
}

// Namespace: System.Diagnostics.Tracing
[Flags]
public enum EventKeywords // TypeDefIndex: 1379
{
	// Fields
	public long value__; // 0x0
	public const EventKeywords None = 0;
	public const EventKeywords All = -1;
	public const EventKeywords MicrosoftTelemetry = 562949953421312;
	public const EventKeywords WdiContext = 562949953421312;
	public const EventKeywords WdiDiagnostic = 1125899906842624;
	public const EventKeywords Sqm = 2251799813685248;
	public const EventKeywords AuditFailure = 4503599627370496;
	public const EventKeywords AuditSuccess = 9007199254740992;
	public const EventKeywords CorrelationHint = 4503599627370496;
	public const EventKeywords EventLogClassic = 36028797018963968;
}

// Namespace: System.Diagnostics.Tracing
[Usage(64)]
public sealed class EventAttribute : Attribute // TypeDefIndex: 1380
{
	// Fields
	[CompilerGenerated]
	private int <EventId>k__BackingField; // 0x10
	[CompilerGenerated]
	private EventLevel <Level>k__BackingField; // 0x14
	[CompilerGenerated]
	private EventKeywords <Keywords>k__BackingField; // 0x18
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x20

	// Properties
	private int EventId { set; }
	public EventLevel Level { set; }
	public EventKeywords Keywords { set; }
	public string Message { set; }

	// Methods

	// RVA: 0x1841D3C Offset: 0x183DD3C VA: 0x1841D3C
	public void .ctor(int eventId) { }

	[CompilerGenerated]
	// RVA: 0x1841D64 Offset: 0x183DD64 VA: 0x1841D64
	private void set_EventId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1841D6C Offset: 0x183DD6C VA: 0x1841D6C
	public void set_Level(EventLevel value) { }

	[CompilerGenerated]
	// RVA: 0x1841D74 Offset: 0x183DD74 VA: 0x1841D74
	public void set_Keywords(EventKeywords value) { }

	[CompilerGenerated]
	// RVA: 0x1841D7C Offset: 0x183DD7C VA: 0x1841D7C
	public void set_Message(string value) { }
}

// Namespace: 
protected internal struct EventSource.EventData // TypeDefIndex: 1381
{
	// Fields
	[CompilerGenerated]
	private IntPtr <DataPointer>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <Size>k__BackingField; // 0x8
	[CompilerGenerated]
	private int <Reserved>k__BackingField; // 0xC

	// Properties
	public IntPtr DataPointer { set; }
	public int Size { set; }
	internal int Reserved { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18425B8 Offset: 0x183E5B8 VA: 0x18425B8
	public void set_DataPointer(IntPtr value) { }

	[CompilerGenerated]
	// RVA: 0x18425C0 Offset: 0x183E5C0 VA: 0x18425C0
	public void set_Size(int value) { }

	[CompilerGenerated]
	// RVA: 0x18425C8 Offset: 0x183E5C8 VA: 0x18425C8
	internal void set_Reserved(int value) { }
}

// Namespace: System.Diagnostics.Tracing
public class EventSource : IDisposable // TypeDefIndex: 1382
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10

	// Properties
	private string Name { set; }

	// Methods

	// RVA: 0x1841D84 Offset: 0x183DD84 VA: 0x1841D84
	protected void .ctor() { }

	// RVA: 0x1841DC8 Offset: 0x183DDC8 VA: 0x1841DC8
	public void .ctor(string eventSourceName) { }

	// RVA: 0x1841DF8 Offset: 0x183DDF8 VA: 0x1841DF8
	internal void .ctor(Guid eventSourceGuid, string eventSourceName) { }

	// RVA: 0x1841E28 Offset: 0x183DE28 VA: 0x1841E28 Slot: 1
	protected override void Finalize() { }

	[CompilerGenerated]
	// RVA: 0x1841EB8 Offset: 0x183DEB8 VA: 0x1841EB8
	private void set_Name(string value) { }

	// RVA: 0x1841EC0 Offset: 0x183DEC0 VA: 0x1841EC0
	public bool IsEnabled() { }

	// RVA: 0x1841EC8 Offset: 0x183DEC8 VA: 0x1841EC8
	public bool IsEnabled(EventLevel level, EventKeywords keywords) { }

	// RVA: 0x1841ED0 Offset: 0x183DED0 VA: 0x1841ED0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1841F3C Offset: 0x183DF3C VA: 0x1841F3C Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x1841F40 Offset: 0x183DF40 VA: 0x1841F40
	protected void WriteEvent(int eventId, int arg1) { }

	// RVA: 0x1842000 Offset: 0x183E000 VA: 0x1842000
	protected void WriteEvent(int eventId, string arg1) { }

	// RVA: 0x1842094 Offset: 0x183E094 VA: 0x1842094
	protected void WriteEvent(int eventId, int arg1, int arg2) { }

	// RVA: 0x184219C Offset: 0x183E19C VA: 0x184219C
	protected void WriteEvent(int eventId, int arg1, int arg2, int arg3) { }

	// RVA: 0x18422F8 Offset: 0x183E2F8 VA: 0x18422F8
	protected void WriteEvent(int eventId, long arg1) { }

	// RVA: 0x18423B4 Offset: 0x183E3B4 VA: 0x18423B4
	protected void WriteEvent(int eventId, long arg1, string arg2) { }

	// RVA: 0x1841FFC Offset: 0x183DFFC VA: 0x1841FFC
	protected void WriteEvent(int eventId, object[] args) { }

	// RVA: 0x18424A8 Offset: 0x183E4A8 VA: 0x18424A8
	protected void WriteEvent(int eventId, string arg1, string arg2, string arg3) { }

	[CLSCompliant(False)]
	// RVA: 0x18425B4 Offset: 0x183E5B4 VA: 0x18425B4
	protected void WriteEventCore(int eventId, int eventDataCount, EventSource.EventData* data) { }
}

// Namespace: System.Diagnostics.Tracing
[Usage(4)]
public sealed class EventSourceAttribute : Attribute // TypeDefIndex: 1383
{
	// Fields
	[CompilerGenerated]
	private string <Guid>k__BackingField; // 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x18

	// Properties
	public string Guid { set; }
	public string Name { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18425D0 Offset: 0x183E5D0 VA: 0x18425D0
	public void set_Guid(string value) { }

	[CompilerGenerated]
	// RVA: 0x18425D8 Offset: 0x183E5D8 VA: 0x18425D8
	public void set_Name(string value) { }

	// RVA: 0x18425E0 Offset: 0x183E5E0 VA: 0x18425E0
	public void .ctor() { }
}

// Namespace: System.Diagnostics.Tracing
[Usage(64)]
public sealed class NonEventAttribute : Attribute // TypeDefIndex: 1384
{
	// Methods

	// RVA: 0x18425E8 Offset: 0x183E5E8 VA: 0x18425E8
	public void .ctor() { }
}
