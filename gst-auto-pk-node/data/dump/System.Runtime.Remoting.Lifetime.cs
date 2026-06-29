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

// Namespace: System.Runtime.Remoting.Lifetime
[ComVisible(True)]
public interface ILease // TypeDefIndex: 833
{
	// Properties
	public abstract TimeSpan CurrentLeaseTime { get; }
	public abstract LeaseState CurrentState { get; }
	public abstract TimeSpan RenewOnCallTime { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TimeSpan get_CurrentLeaseTime();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract LeaseState get_CurrentState();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract TimeSpan get_RenewOnCallTime();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract TimeSpan Renew(TimeSpan renewalTime);
}

// Namespace: System.Runtime.Remoting.Lifetime
[ComVisible(True)]
public interface ISponsor // TypeDefIndex: 834
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract TimeSpan Renewal(ILease lease);
}

// Namespace: 
private sealed class Lease.RenewalDelegate : MulticastDelegate // TypeDefIndex: 835
{
	// Methods

	// RVA: 0x1796A50 Offset: 0x1792A50 VA: 0x1796A50
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1796D94 Offset: 0x1792D94 VA: 0x1796D94 Slot: 12
	public virtual TimeSpan Invoke(ILease lease) { }

	// RVA: 0x1796B58 Offset: 0x1792B58 VA: 0x1796B58 Slot: 13
	public virtual IAsyncResult BeginInvoke(ILease lease, AsyncCallback callback, object object) { }

	// RVA: 0x1796D6C Offset: 0x1792D6C VA: 0x1796D6C Slot: 14
	public virtual TimeSpan EndInvoke(IAsyncResult result) { }
}

// Namespace: System.Runtime.Remoting.Lifetime
internal class Lease : MarshalByRefObject, ILease // TypeDefIndex: 836
{
	// Fields
	private DateTime _leaseExpireTime; // 0x18
	private LeaseState _currentState; // 0x20
	private TimeSpan _initialLeaseTime; // 0x28
	private TimeSpan _renewOnCallTime; // 0x30
	private TimeSpan _sponsorshipTimeout; // 0x38
	private ArrayList _sponsors; // 0x40
	private Queue _renewingSponsors; // 0x48
	private Lease.RenewalDelegate _renewalDelegate; // 0x50

	// Properties
	public TimeSpan CurrentLeaseTime { get; }
	public LeaseState CurrentState { get; }
	public TimeSpan RenewOnCallTime { get; }

	// Methods

	// RVA: 0x1790734 Offset: 0x178C734 VA: 0x1790734
	public void .ctor() { }

	// RVA: 0x17963E4 Offset: 0x17923E4 VA: 0x17963E4 Slot: 6
	public TimeSpan get_CurrentLeaseTime() { }

	// RVA: 0x179644C Offset: 0x179244C VA: 0x179644C Slot: 7
	public LeaseState get_CurrentState() { }

	// RVA: 0x1796454 Offset: 0x1792454 VA: 0x1796454
	public void Activate() { }

	// RVA: 0x1796460 Offset: 0x1792460 VA: 0x1796460 Slot: 8
	public TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x1796468 Offset: 0x1792468 VA: 0x1796468 Slot: 9
	public TimeSpan Renew(TimeSpan renewalTime) { }

	// RVA: 0x17964F4 Offset: 0x17924F4 VA: 0x17964F4 Slot: 10
	public void Unregister(ISponsor obj) { }

	// RVA: 0x179663C Offset: 0x179263C VA: 0x179663C
	internal void UpdateState() { }

	// RVA: 0x17967E4 Offset: 0x17927E4 VA: 0x17967E4
	private void CheckNextSponsor() { }

	// RVA: 0x1796B78 Offset: 0x1792B78 VA: 0x1796B78
	private void ProcessSponsorResponse(object state, bool timedOut) { }
}

// Namespace: System.Runtime.Remoting.Lifetime
internal class LeaseManager // TypeDefIndex: 837
{
	// Fields
	private ArrayList _objects; // 0x10
	private Timer _timer; // 0x18

	// Methods

	// RVA: 0x1796DA8 Offset: 0x1792DA8 VA: 0x1796DA8
	public void SetPollTime(TimeSpan timeSpan) { }

	// RVA: 0x1796E98 Offset: 0x1792E98 VA: 0x1796E98
	public void TrackLifetime(ServerIdentity identity) { }

	// RVA: 0x1796FCC Offset: 0x1792FCC VA: 0x1796FCC
	public void StartManager() { }

	// RVA: 0x1797128 Offset: 0x1793128 VA: 0x1797128
	public void StopManager() { }

	// RVA: 0x1797158 Offset: 0x1793158 VA: 0x1797158
	public void ManageLeases(object state) { }

	// RVA: 0x17973AC Offset: 0x17933AC VA: 0x17973AC
	public void .ctor() { }
}

// Namespace: System.Runtime.Remoting.Lifetime
internal class LeaseSink : IMessageSink // TypeDefIndex: 838
{
	// Fields
	private IMessageSink _nextSink; // 0x10

	// Methods

	// RVA: 0x1797418 Offset: 0x1793418 VA: 0x1797418
	public void .ctor(IMessageSink nextSink) { }

	// RVA: 0x1797448 Offset: 0x1793448 VA: 0x1797448 Slot: 4
	public IMessage SyncProcessMessage(IMessage msg) { }

	// RVA: 0x1797784 Offset: 0x1793784 VA: 0x1797784 Slot: 5
	public IMessageCtrl AsyncProcessMessage(IMessage msg, IMessageSink replySink) { }

	// RVA: 0x17974F8 Offset: 0x17934F8 VA: 0x17974F8
	private void RenewLease(IMessage msg) { }
}

// Namespace: System.Runtime.Remoting.Lifetime
[ComVisible(True)]
[Serializable]
public enum LeaseState // TypeDefIndex: 839
{
	// Fields
	public int value__; // 0x0
	public const LeaseState Null = 0;
	public const LeaseState Initial = 1;
	public const LeaseState Active = 2;
	public const LeaseState Renewing = 3;
	public const LeaseState Expired = 4;
}

// Namespace: System.Runtime.Remoting.Lifetime
[ComVisible(True)]
public sealed class LifetimeServices // TypeDefIndex: 840
{
	// Fields
	private static TimeSpan _leaseManagerPollTime; // 0x0
	private static TimeSpan _leaseTime; // 0x8
	private static TimeSpan _renewOnCallTime; // 0x10
	private static TimeSpan _sponsorshipTimeout; // 0x18
	private static LeaseManager _leaseManager; // 0x20

	// Properties
	public static TimeSpan LeaseManagerPollTime { get; set; }
	public static TimeSpan LeaseTime { get; set; }
	public static TimeSpan RenewOnCallTime { get; set; }
	public static TimeSpan SponsorshipTimeout { get; set; }

	// Methods

	// RVA: 0x1797848 Offset: 0x1793848 VA: 0x1797848
	private static void .cctor() { }

	// RVA: 0x1797948 Offset: 0x1793948 VA: 0x1797948
	public static TimeSpan get_LeaseManagerPollTime() { }

	// RVA: 0x178A660 Offset: 0x1786660 VA: 0x178A660
	public static void set_LeaseManagerPollTime(TimeSpan value) { }

	// RVA: 0x17979A0 Offset: 0x17939A0 VA: 0x17979A0
	public static TimeSpan get_LeaseTime() { }

	// RVA: 0x17979F8 Offset: 0x17939F8 VA: 0x17979F8
	public static void set_LeaseTime(TimeSpan value) { }

	// RVA: 0x1797A54 Offset: 0x1793A54 VA: 0x1797A54
	public static TimeSpan get_RenewOnCallTime() { }

	// RVA: 0x1797AAC Offset: 0x1793AAC VA: 0x1797AAC
	public static void set_RenewOnCallTime(TimeSpan value) { }

	// RVA: 0x1797B08 Offset: 0x1793B08 VA: 0x1797B08
	public static TimeSpan get_SponsorshipTimeout() { }

	// RVA: 0x1797B60 Offset: 0x1793B60 VA: 0x1797B60
	public static void set_SponsorshipTimeout(TimeSpan value) { }

	// RVA: 0x179088C Offset: 0x178C88C VA: 0x179088C
	internal static void TrackLifetime(ServerIdentity identity) { }
}
