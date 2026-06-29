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

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class AddInstruction : Instruction // TypeDefIndex: 5531
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D0F1C Offset: 0x19CCF1C VA: 0x19D0F1C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D0F24 Offset: 0x19CCF24 VA: 0x19D0F24 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D0F2C Offset: 0x19CCF2C VA: 0x19D0F2C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D0F6C Offset: 0x19CCF6C VA: 0x19D0F6C
	private void .ctor() { }

	// RVA: 0x19D0F74 Offset: 0x19CCF74 VA: 0x19D0F74
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class AddOvfInstruction.AddOvfInt16 : AddOvfInstruction // TypeDefIndex: 5532
{
	// Methods

	// RVA: 0x19D20A4 Offset: 0x19CE0A4 VA: 0x19D20A4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D2074 Offset: 0x19CE074 VA: 0x19D2074
	public void .ctor() { }
}

// Namespace: 
private sealed class AddOvfInstruction.AddOvfInt32 : AddOvfInstruction // TypeDefIndex: 5533
{
	// Methods

	// RVA: 0x19D22FC Offset: 0x19CE2FC VA: 0x19D22FC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D207C Offset: 0x19CE07C VA: 0x19D207C
	public void .ctor() { }
}

// Namespace: 
private sealed class AddOvfInstruction.AddOvfInt64 : AddOvfInstruction // TypeDefIndex: 5534
{
	// Methods

	// RVA: 0x19D251C Offset: 0x19CE51C VA: 0x19D251C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D2084 Offset: 0x19CE084 VA: 0x19D2084
	public void .ctor() { }
}

// Namespace: 
private sealed class AddOvfInstruction.AddOvfUInt16 : AddOvfInstruction // TypeDefIndex: 5535
{
	// Methods

	// RVA: 0x19D270C Offset: 0x19CE70C VA: 0x19D270C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D208C Offset: 0x19CE08C VA: 0x19D208C
	public void .ctor() { }
}

// Namespace: 
private sealed class AddOvfInstruction.AddOvfUInt32 : AddOvfInstruction // TypeDefIndex: 5536
{
	// Methods

	// RVA: 0x19D2964 Offset: 0x19CE964 VA: 0x19D2964 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D2094 Offset: 0x19CE094 VA: 0x19D2094
	public void .ctor() { }
}

// Namespace: 
private sealed class AddOvfInstruction.AddOvfUInt64 : AddOvfInstruction // TypeDefIndex: 5537
{
	// Methods

	// RVA: 0x19D2B3C Offset: 0x19CEB3C VA: 0x19D2B3C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D209C Offset: 0x19CE09C VA: 0x19D209C
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class AddOvfInstruction : Instruction // TypeDefIndex: 5538
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D1D44 Offset: 0x19CDD44 VA: 0x19D1D44 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D1D4C Offset: 0x19CDD4C VA: 0x19D1D4C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D1D54 Offset: 0x19CDD54 VA: 0x19D1D54 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D1D94 Offset: 0x19CDD94 VA: 0x19D1D94
	private void .ctor() { }

	// RVA: 0x19D1D9C Offset: 0x19CDD9C VA: 0x19D1D9C
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class AndInstruction.AndSByte : AndInstruction // TypeDefIndex: 5539
{
	// Methods

	// RVA: 0x19D31B4 Offset: 0x19CF1B4 VA: 0x19D31B4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D316C Offset: 0x19CF16C VA: 0x19D316C
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndInt16 : AndInstruction // TypeDefIndex: 5540
{
	// Methods

	// RVA: 0x19D3288 Offset: 0x19CF288 VA: 0x19D3288 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D3174 Offset: 0x19CF174 VA: 0x19D3174
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndInt32 : AndInstruction // TypeDefIndex: 5541
{
	// Methods

	// RVA: 0x19D335C Offset: 0x19CF35C VA: 0x19D335C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D317C Offset: 0x19CF17C VA: 0x19D317C
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndInt64 : AndInstruction // TypeDefIndex: 5542
{
	// Methods

	// RVA: 0x19D3430 Offset: 0x19CF430 VA: 0x19D3430 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D3184 Offset: 0x19CF184 VA: 0x19D3184
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndByte : AndInstruction // TypeDefIndex: 5543
{
	// Methods

	// RVA: 0x19D3514 Offset: 0x19CF514 VA: 0x19D3514 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D318C Offset: 0x19CF18C VA: 0x19D318C
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndUInt16 : AndInstruction // TypeDefIndex: 5544
{
	// Methods

	// RVA: 0x19D35E8 Offset: 0x19CF5E8 VA: 0x19D35E8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D3194 Offset: 0x19CF194 VA: 0x19D3194
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndUInt32 : AndInstruction // TypeDefIndex: 5545
{
	// Methods

	// RVA: 0x19D36BC Offset: 0x19CF6BC VA: 0x19D36BC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D319C Offset: 0x19CF19C VA: 0x19D319C
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndUInt64 : AndInstruction // TypeDefIndex: 5546
{
	// Methods

	// RVA: 0x19D37A0 Offset: 0x19CF7A0 VA: 0x19D37A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D31A4 Offset: 0x19CF1A4 VA: 0x19D31A4
	public void .ctor() { }
}

// Namespace: 
private sealed class AndInstruction.AndBoolean : AndInstruction // TypeDefIndex: 5547
{
	// Methods

	// RVA: 0x19D3884 Offset: 0x19CF884 VA: 0x19D3884 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D31AC Offset: 0x19CF1AC VA: 0x19D31AC
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class AndInstruction : Instruction // TypeDefIndex: 5548
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38
	private static Instruction s_Boolean; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D2D10 Offset: 0x19CED10 VA: 0x19D2D10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D2D18 Offset: 0x19CED18 VA: 0x19D2D18 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D2D20 Offset: 0x19CED20 VA: 0x19D2D20 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D2D60 Offset: 0x19CED60 VA: 0x19D2D60
	private void .ctor() { }

	// RVA: 0x19D2D68 Offset: 0x19CED68 VA: 0x19D2D68
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NewArrayInitInstruction : Instruction // TypeDefIndex: 5549
{
	// Fields
	private readonly Type _elementType; // 0x10
	private readonly int _elementCount; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D39D4 Offset: 0x19CF9D4 VA: 0x19D39D4
	internal void .ctor(Type elementType, int elementCount) { }

	// RVA: 0x19D3A10 Offset: 0x19CFA10 VA: 0x19D3A10 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D3A18 Offset: 0x19CFA18 VA: 0x19D3A18 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D3A20 Offset: 0x19CFA20 VA: 0x19D3A20 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D3A60 Offset: 0x19CFA60 VA: 0x19D3A60 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NewArrayInstruction : Instruction // TypeDefIndex: 5550
{
	// Fields
	private readonly Type _elementType; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D3AF0 Offset: 0x19CFAF0 VA: 0x19D3AF0
	internal void .ctor(Type elementType) { }

	// RVA: 0x19D3B20 Offset: 0x19CFB20 VA: 0x19D3B20 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D3B28 Offset: 0x19CFB28 VA: 0x19D3B28 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D3B30 Offset: 0x19CFB30 VA: 0x19D3B30 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D3B70 Offset: 0x19CFB70 VA: 0x19D3B70 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NewArrayBoundsInstruction : Instruction // TypeDefIndex: 5551
{
	// Fields
	private readonly Type _elementType; // 0x10
	private readonly int _rank; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D3D0C Offset: 0x19CFD0C VA: 0x19D3D0C
	internal void .ctor(Type elementType, int rank) { }

	// RVA: 0x19D3D48 Offset: 0x19CFD48 VA: 0x19D3D48 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D3D50 Offset: 0x19CFD50 VA: 0x19D3D50 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D3D58 Offset: 0x19CFD58 VA: 0x19D3D58 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D3D98 Offset: 0x19CFD98 VA: 0x19D3D98 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class GetArrayItemInstruction : Instruction // TypeDefIndex: 5552
{
	// Fields
	internal static readonly GetArrayItemInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D3EA4 Offset: 0x19CFEA4 VA: 0x19D3EA4
	private void .ctor() { }

	// RVA: 0x19D3EAC Offset: 0x19CFEAC VA: 0x19D3EAC Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D3EB4 Offset: 0x19CFEB4 VA: 0x19D3EB4 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D3EBC Offset: 0x19CFEBC VA: 0x19D3EBC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D3EFC Offset: 0x19CFEFC VA: 0x19D3EFC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D3F98 Offset: 0x19CFF98 VA: 0x19D3F98
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class SetArrayItemInstruction : Instruction // TypeDefIndex: 5553
{
	// Fields
	internal static readonly SetArrayItemInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D4000 Offset: 0x19D0000 VA: 0x19D4000
	private void .ctor() { }

	// RVA: 0x19D4008 Offset: 0x19D0008 VA: 0x19D4008 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D4010 Offset: 0x19D0010 VA: 0x19D4010 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D4050 Offset: 0x19D0050 VA: 0x19D4050 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D40F0 Offset: 0x19D00F0 VA: 0x19D40F0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ArrayLengthInstruction : Instruction // TypeDefIndex: 5554
{
	// Fields
	public static readonly ArrayLengthInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D4158 Offset: 0x19D0158 VA: 0x19D4158 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D4160 Offset: 0x19D0160 VA: 0x19D4160 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D4168 Offset: 0x19D0168 VA: 0x19D4168 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D41A8 Offset: 0x19D01A8 VA: 0x19D41A8
	private void .ctor() { }

	// RVA: 0x19D41B0 Offset: 0x19D01B0 VA: 0x19D41B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D422C Offset: 0x19D022C VA: 0x19D422C
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal static class ConvertHelper // TypeDefIndex: 5555
{
	// Methods

	// RVA: 0x19D3C00 Offset: 0x19CFC00 VA: 0x19D3C00
	public static int ToInt32NoNull(object val) { }
}

// Namespace: System.Linq.Expressions.Interpreter
[IsReadOnly]
internal struct RuntimeLabel // TypeDefIndex: 5556
{
	// Fields
	public readonly int Index; // 0x0
	public readonly int StackDepth; // 0x4
	public readonly int ContinuationStackDepth; // 0x8

	// Methods

	// RVA: 0x19D4294 Offset: 0x19D0294 VA: 0x19D4294
	public void .ctor(int index, int continuationStackDepth, int stackDepth) { }

	// RVA: 0x19D42A0 Offset: 0x19D02A0 VA: 0x19D42A0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class BranchLabel // TypeDefIndex: 5557
{
	// Fields
	private int _targetIndex; // 0x10
	private int _stackDepth; // 0x14
	private int _continuationStackDepth; // 0x18
	private List<int> _forwardBranchFixups; // 0x20
	[CompilerGenerated]
	private int <LabelIndex>k__BackingField; // 0x28

	// Properties
	internal int LabelIndex { get; set; }
	internal bool HasRuntimeLabel { get; }
	internal int TargetIndex { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19D4390 Offset: 0x19D0390 VA: 0x19D4390
	internal int get_LabelIndex() { }

	[CompilerGenerated]
	// RVA: 0x19D4398 Offset: 0x19D0398 VA: 0x19D4398
	internal void set_LabelIndex(int value) { }

	// RVA: 0x19D43A0 Offset: 0x19D03A0 VA: 0x19D43A0
	internal bool get_HasRuntimeLabel() { }

	// RVA: 0x19D43B4 Offset: 0x19D03B4 VA: 0x19D43B4
	internal int get_TargetIndex() { }

	// RVA: 0x19D43BC Offset: 0x19D03BC VA: 0x19D43BC
	internal RuntimeLabel ToRuntimeLabel() { }

	// RVA: 0x19D43CC Offset: 0x19D03CC VA: 0x19D43CC
	internal void Mark(InstructionList instructions) { }

	// RVA: 0x19D4568 Offset: 0x19D0568 VA: 0x19D4568
	internal void AddBranch(InstructionList instructions, int branchIndex) { }

	// RVA: 0x19D4540 Offset: 0x19D0540 VA: 0x19D4540
	internal void FixupBranch(InstructionList instructions, int branchIndex) { }

	// RVA: 0x19D469C Offset: 0x19D069C VA: 0x19D469C
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class CallInstruction : Instruction // TypeDefIndex: 5558
{
	// Properties
	public abstract int ArgumentCount { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public abstract int get_ArgumentCount();

	// RVA: 0x19D46B8 Offset: 0x19D06B8 VA: 0x19D46B8 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D46F8 Offset: 0x19D06F8 VA: 0x19D46F8
	public static CallInstruction Create(MethodInfo info) { }

	// RVA: 0x19D475C Offset: 0x19D075C VA: 0x19D475C
	public static CallInstruction Create(MethodInfo info, ParameterInfo[] parameters) { }

	// RVA: 0x19D48E0 Offset: 0x19D08E0 VA: 0x19D48E0
	private static CallInstruction GetArrayAccessor(MethodInfo info, int argumentCount) { }

	// RVA: 0x19D4DC4 Offset: 0x19D0DC4 VA: 0x19D4DC4
	public static void ArrayItemSetter1(Array array, int index0, object value) { }

	// RVA: 0x19D4DE4 Offset: 0x19D0DE4 VA: 0x19D4DE4
	public static void ArrayItemSetter2(Array array, int index0, int index1, object value) { }

	// RVA: 0x19D4E08 Offset: 0x19D0E08 VA: 0x19D4E08
	public static void ArrayItemSetter3(Array array, int index0, int index1, int index2, object value) { }

	// RVA: 0x19D4E30 Offset: 0x19D0E30 VA: 0x19D4E30 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D4E3C Offset: 0x19D0E3C VA: 0x19D4E3C
	protected static bool TryGetLightLambdaTarget(object instance, out LightLambda lightLambda) { }

	// RVA: 0x19D4F94 Offset: 0x19D0F94 VA: 0x19D4F94
	protected object InterpretLambdaInvoke(LightLambda targetLambda, object[] args) { }

	// RVA: 0x19D4FF8 Offset: 0x19D0FF8 VA: 0x19D4FF8
	protected void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class MethodInfoCallInstruction : CallInstruction // TypeDefIndex: 5559
{
	// Fields
	protected readonly MethodInfo _target; // 0x10
	protected readonly int _argumentCount; // 0x18

	// Properties
	public override int ArgumentCount { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x19D5000 Offset: 0x19D1000 VA: 0x19D5000 Slot: 11
	public override int get_ArgumentCount() { }

	// RVA: 0x19D4D88 Offset: 0x19D0D88 VA: 0x19D4D88
	internal void .ctor(MethodInfo target, int argumentCount) { }

	// RVA: 0x19D5008 Offset: 0x19D1008 VA: 0x19D5008 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D5080 Offset: 0x19D1080 VA: 0x19D5080 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D53A4 Offset: 0x19D13A4 VA: 0x19D53A4
	protected object[] GetArgs(InterpretedFrame frame, int first, int skip) { }

	// RVA: 0x19D5548 Offset: 0x19D1548 VA: 0x19D5548 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class ByRefMethodInfoCallInstruction : MethodInfoCallInstruction // TypeDefIndex: 5560
{
	// Fields
	private readonly ByRefUpdater[] _byrefArgs; // 0x20

	// Properties
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x19D55CC Offset: 0x19D15CC VA: 0x19D55CC
	internal void .ctor(MethodInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x19D5620 Offset: 0x19D1620 VA: 0x19D5620 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D5698 Offset: 0x19D1698 VA: 0x19D5698 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class OffsetInstruction : Instruction // TypeDefIndex: 5561
{
	// Fields
	protected int _offset; // 0x10

	// Properties
	public abstract Instruction[] Cache { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public abstract Instruction[] get_Cache();

	// RVA: 0x19D5B48 Offset: 0x19D1B48 VA: 0x19D5B48
	public Instruction Fixup(int offset) { }

	// RVA: 0x19D5BBC Offset: 0x19D1BBC VA: 0x19D5BBC Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x19D5C84 Offset: 0x19D1C84 VA: 0x19D5C84 Slot: 3
	public override string ToString() { }

	// RVA: 0x19D5D50 Offset: 0x19D1D50 VA: 0x19D5D50
	protected void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class BranchFalseInstruction : OffsetInstruction // TypeDefIndex: 5562
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x19D5D60 Offset: 0x19D1D60 VA: 0x19D5D60 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x19D5DF4 Offset: 0x19D1DF4 VA: 0x19D5DF4 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D5E34 Offset: 0x19D1E34 VA: 0x19D5E34 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D5E3C Offset: 0x19D1E3C VA: 0x19D5E3C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D5EA0 Offset: 0x19D1EA0 VA: 0x19D5EA0
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class BranchTrueInstruction : OffsetInstruction // TypeDefIndex: 5563
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x19D5EB0 Offset: 0x19D1EB0 VA: 0x19D5EB0 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x19D5F44 Offset: 0x19D1F44 VA: 0x19D5F44 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D5F84 Offset: 0x19D1F84 VA: 0x19D5F84 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D5F8C Offset: 0x19D1F8C VA: 0x19D5F8C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D5FF0 Offset: 0x19D1FF0 VA: 0x19D5FF0
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CoalescingBranchInstruction : OffsetInstruction // TypeDefIndex: 5564
{
	// Fields
	private static Instruction[] s_cache; // 0x0

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x19D6000 Offset: 0x19D2000 VA: 0x19D6000 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x19D6094 Offset: 0x19D2094 VA: 0x19D6094 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D60D4 Offset: 0x19D20D4 VA: 0x19D60D4 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D60DC Offset: 0x19D20DC VA: 0x19D60DC Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D60E4 Offset: 0x19D20E4 VA: 0x19D60E4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D6118 Offset: 0x19D2118 VA: 0x19D6118
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class BranchInstruction : OffsetInstruction // TypeDefIndex: 5565
{
	// Fields
	private static Instruction[][][] s_caches; // 0x0
	internal readonly bool _hasResult; // 0x14
	internal readonly bool _hasValue; // 0x15

	// Properties
	public override Instruction[] Cache { get; }
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x19D6128 Offset: 0x19D2128 VA: 0x19D6128 Slot: 11
	public override Instruction[] get_Cache() { }

	// RVA: 0x19D6380 Offset: 0x19D2380 VA: 0x19D6380
	internal void .ctor() { }

	// RVA: 0x19D63A4 Offset: 0x19D23A4 VA: 0x19D63A4
	public void .ctor(bool hasResult, bool hasValue) { }

	// RVA: 0x19D63DC Offset: 0x19D23DC VA: 0x19D63DC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D641C Offset: 0x19D241C VA: 0x19D641C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D6424 Offset: 0x19D2424 VA: 0x19D6424 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D642C Offset: 0x19D242C VA: 0x19D642C Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class IndexedBranchInstruction : Instruction // TypeDefIndex: 5566
{
	// Fields
	internal readonly int _labelIndex; // 0x10

	// Methods

	// RVA: 0x19D6434 Offset: 0x19D2434 VA: 0x19D6434
	public void .ctor(int labelIndex) { }

	// RVA: 0x19D645C Offset: 0x19D245C VA: 0x19D645C
	public RuntimeLabel GetLabel(InterpretedFrame frame) { }

	// RVA: 0x19D64A4 Offset: 0x19D24A4 VA: 0x19D64A4 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x19D6584 Offset: 0x19D2584 VA: 0x19D6584 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class GotoInstruction : IndexedBranchInstruction // TypeDefIndex: 5567
{
	// Fields
	private static readonly GotoInstruction[] s_cache; // 0x0
	private readonly bool _hasResult; // 0x14
	private readonly bool _hasValue; // 0x15
	private readonly bool _labelTargetGetsValue; // 0x16

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x19D6618 Offset: 0x19D2618 VA: 0x19D6618 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D6658 Offset: 0x19D2658 VA: 0x19D6658 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D6660 Offset: 0x19D2660 VA: 0x19D6660 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D6668 Offset: 0x19D2668 VA: 0x19D6668
	private void .ctor(int targetIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x19D66B0 Offset: 0x19D26B0 VA: 0x19D66B0
	internal static GotoInstruction Create(int labelIndex, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x19D6820 Offset: 0x19D2820 VA: 0x19D6820 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D68E8 Offset: 0x19D28E8 VA: 0x19D68E8
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterTryCatchFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 5568
{
	// Fields
	private readonly bool _hasFinally; // 0x14
	private TryCatchFinallyHandler _tryHandler; // 0x18

	// Properties
	internal TryCatchFinallyHandler Handler { get; }
	public override int ProducedContinuations { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D695C Offset: 0x19D295C VA: 0x19D695C
	internal void SetTryHandler(TryCatchFinallyHandler tryHandler) { }

	// RVA: 0x19D6964 Offset: 0x19D2964 VA: 0x19D6964
	internal TryCatchFinallyHandler get_Handler() { }

	// RVA: 0x19D696C Offset: 0x19D296C VA: 0x19D696C Slot: 7
	public override int get_ProducedContinuations() { }

	// RVA: 0x19D6974 Offset: 0x19D2974 VA: 0x19D6974
	private void .ctor(int targetIndex, bool hasFinally) { }

	// RVA: 0x19D69A4 Offset: 0x19D29A4 VA: 0x19D69A4
	internal static EnterTryCatchFinallyInstruction CreateTryFinally(int labelIndex) { }

	// RVA: 0x19D6A08 Offset: 0x19D2A08 VA: 0x19D6A08
	internal static EnterTryCatchFinallyInstruction CreateTryCatch() { }

	// RVA: 0x19D6A68 Offset: 0x19D2A68 VA: 0x19D6A68 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D6F78 Offset: 0x19D2F78 VA: 0x19D6F78 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D6FE4 Offset: 0x19D2FE4 VA: 0x19D6FE4 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterTryFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 5569
{
	// Fields
	private TryFaultHandler _tryHandler; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ProducedContinuations { get; }
	internal TryFaultHandler Handler { get; }

	// Methods

	// RVA: 0x19D7084 Offset: 0x19D3084 VA: 0x19D7084
	internal void .ctor(int targetIndex) { }

	// RVA: 0x19D70AC Offset: 0x19D30AC VA: 0x19D70AC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D70EC Offset: 0x19D30EC VA: 0x19D70EC Slot: 7
	public override int get_ProducedContinuations() { }

	// RVA: 0x19D70F4 Offset: 0x19D30F4 VA: 0x19D70F4
	internal TryFaultHandler get_Handler() { }

	// RVA: 0x19D70FC Offset: 0x19D30FC VA: 0x19D70FC
	internal void SetTryHandler(TryFaultHandler tryHandler) { }

	// RVA: 0x19D7104 Offset: 0x19D3104 VA: 0x19D7104 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterFinallyInstruction : IndexedBranchInstruction // TypeDefIndex: 5570
{
	// Fields
	private static readonly EnterFinallyInstruction[] s_cache; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }
	public override int ConsumedContinuations { get; }

	// Methods

	// RVA: 0x19D7304 Offset: 0x19D3304 VA: 0x19D7304
	private void .ctor(int labelIndex) { }

	// RVA: 0x19D732C Offset: 0x19D332C VA: 0x19D732C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D736C Offset: 0x19D336C VA: 0x19D736C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D7374 Offset: 0x19D3374 VA: 0x19D7374 Slot: 6
	public override int get_ConsumedContinuations() { }

	// RVA: 0x19D737C Offset: 0x19D337C VA: 0x19D737C
	internal static EnterFinallyInstruction Create(int labelIndex) { }

	// RVA: 0x19D7478 Offset: 0x19D3478 VA: 0x19D7478 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D74E4 Offset: 0x19D34E4 VA: 0x19D74E4
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveFinallyInstruction : Instruction // TypeDefIndex: 5571
{
	// Fields
	internal static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D7558 Offset: 0x19D3558 VA: 0x19D7558
	private void .ctor() { }

	// RVA: 0x19D7560 Offset: 0x19D3560 VA: 0x19D7560 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D7568 Offset: 0x19D3568 VA: 0x19D7568 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D75A8 Offset: 0x19D35A8 VA: 0x19D75A8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D75F0 Offset: 0x19D35F0 VA: 0x19D75F0
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterFaultInstruction : IndexedBranchInstruction // TypeDefIndex: 5572
{
	// Fields
	private static readonly EnterFaultInstruction[] s_cache; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x19D7658 Offset: 0x19D3658 VA: 0x19D7658
	private void .ctor(int labelIndex) { }

	// RVA: 0x19D7680 Offset: 0x19D3680 VA: 0x19D7680 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D76C0 Offset: 0x19D36C0 VA: 0x19D76C0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D76C8 Offset: 0x19D36C8 VA: 0x19D76C8
	internal static EnterFaultInstruction Create(int labelIndex) { }

	// RVA: 0x19D77C4 Offset: 0x19D37C4 VA: 0x19D77C4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D780C Offset: 0x19D380C VA: 0x19D780C
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveFaultInstruction : Instruction // TypeDefIndex: 5573
{
	// Fields
	internal static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ConsumedContinuations { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D7880 Offset: 0x19D3880 VA: 0x19D7880
	private void .ctor() { }

	// RVA: 0x19D7888 Offset: 0x19D3888 VA: 0x19D7888 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D7890 Offset: 0x19D3890 VA: 0x19D7890 Slot: 6
	public override int get_ConsumedContinuations() { }

	// RVA: 0x19D7898 Offset: 0x19D3898 VA: 0x19D7898 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D78D8 Offset: 0x19D38D8 VA: 0x19D78D8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D78FC Offset: 0x19D38FC VA: 0x19D78FC
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterExceptionFilterInstruction : Instruction // TypeDefIndex: 5574
{
	// Fields
	internal static readonly EnterExceptionFilterInstruction Instance; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x19D7964 Offset: 0x19D3964 VA: 0x19D7964
	private void .ctor() { }

	// RVA: 0x19D796C Offset: 0x19D396C VA: 0x19D796C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D79AC Offset: 0x19D39AC VA: 0x19D79AC Slot: 5
	public override int get_ProducedStack() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x19D79B4 Offset: 0x19D39B4 VA: 0x19D79B4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D79BC Offset: 0x19D39BC VA: 0x19D79BC
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveExceptionFilterInstruction : Instruction // TypeDefIndex: 5575
{
	// Fields
	internal static readonly LeaveExceptionFilterInstruction Instance; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x19D7A24 Offset: 0x19D3A24 VA: 0x19D7A24
	private void .ctor() { }

	// RVA: 0x19D7A2C Offset: 0x19D3A2C VA: 0x19D7A2C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D7A6C Offset: 0x19D3A6C VA: 0x19D7A6C Slot: 4
	public override int get_ConsumedStack() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x19D7A74 Offset: 0x19D3A74 VA: 0x19D7A74 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D7A7C Offset: 0x19D3A7C VA: 0x19D7A7C
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class EnterExceptionHandlerInstruction : Instruction // TypeDefIndex: 5576
{
	// Fields
	internal static readonly EnterExceptionHandlerInstruction Void; // 0x0
	internal static readonly EnterExceptionHandlerInstruction NonVoid; // 0x8
	private readonly bool _hasValue; // 0x10

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x19D7AE4 Offset: 0x19D3AE4 VA: 0x19D7AE4
	private void .ctor(bool hasValue) { }

	// RVA: 0x19D7B0C Offset: 0x19D3B0C VA: 0x19D7B0C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D7B4C Offset: 0x19D3B4C VA: 0x19D7B4C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D7B54 Offset: 0x19D3B54 VA: 0x19D7B54 Slot: 5
	public override int get_ProducedStack() { }

	[ExcludeFromCodeCoverage]
	// RVA: 0x19D7B5C Offset: 0x19D3B5C VA: 0x19D7B5C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D7B64 Offset: 0x19D3B64 VA: 0x19D7B64
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LeaveExceptionHandlerInstruction : IndexedBranchInstruction // TypeDefIndex: 5577
{
	// Fields
	private static readonly LeaveExceptionHandlerInstruction[] s_cache; // 0x0
	private readonly bool _hasValue; // 0x14

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x19D7C00 Offset: 0x19D3C00 VA: 0x19D7C00
	private void .ctor(int labelIndex, bool hasValue) { }

	// RVA: 0x19D7C30 Offset: 0x19D3C30 VA: 0x19D7C30 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D7C70 Offset: 0x19D3C70 VA: 0x19D7C70 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D7C78 Offset: 0x19D3C78 VA: 0x19D7C78 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D7C80 Offset: 0x19D3C80 VA: 0x19D7C80
	internal static LeaveExceptionHandlerInstruction Create(int labelIndex, bool hasValue) { }

	// RVA: 0x19D7DA4 Offset: 0x19D3DA4 VA: 0x19D7DA4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D7DC8 Offset: 0x19D3DC8 VA: 0x19D7DC8
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ThrowInstruction : Instruction // TypeDefIndex: 5578
{
	// Fields
	internal static readonly ThrowInstruction Throw; // 0x0
	internal static readonly ThrowInstruction VoidThrow; // 0x8
	internal static readonly ThrowInstruction Rethrow; // 0x10
	internal static readonly ThrowInstruction VoidRethrow; // 0x18
	private readonly bool _hasResult; // 0x10
	private readonly bool _rethrow; // 0x11

	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x19D7E3C Offset: 0x19D3E3C VA: 0x19D7E3C
	private void .ctor(bool hasResult, bool isRethrow) { }

	// RVA: 0x19D7E6C Offset: 0x19D3E6C VA: 0x19D7E6C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D7EAC Offset: 0x19D3EAC VA: 0x19D7EAC Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D7EB4 Offset: 0x19D3EB4 VA: 0x19D7EB4 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D7EBC Offset: 0x19D3EBC VA: 0x19D7EBC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D7F44 Offset: 0x19D3F44 VA: 0x19D7F44
	private static Exception WrapThrownObject(object thrown) { }

	// RVA: 0x19D7FE8 Offset: 0x19D3FE8 VA: 0x19D7FE8
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class IntSwitchInstruction<T> : Instruction // TypeDefIndex: 5579
{
	// Fields
	private readonly Dictionary<T, int> _cases; // 0x0

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(Dictionary<T, int> cases) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127F078 Offset: 0x127B078 VA: 0x127F078
	|-IntSwitchInstruction<int>..ctor
	|
	|-RVA: 0x127F1A4 Offset: 0x127B1A4 VA: 0x127F1A4
	|-IntSwitchInstruction<object>..ctor
	|
	|-RVA: 0x127F2D0 Offset: 0x127B2D0 VA: 0x127F2D0
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public override string get_InstructionName() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127F0A8 Offset: 0x127B0A8 VA: 0x127F0A8
	|-IntSwitchInstruction<int>.get_InstructionName
	|
	|-RVA: 0x127F1D4 Offset: 0x127B1D4 VA: 0x127F1D4
	|-IntSwitchInstruction<object>.get_InstructionName
	|
	|-RVA: 0x127F300 Offset: 0x127B300 VA: 0x127F300
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>.get_InstructionName
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override int get_ConsumedStack() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127F0E8 Offset: 0x127B0E8 VA: 0x127F0E8
	|-IntSwitchInstruction<int>.get_ConsumedStack
	|
	|-RVA: 0x127F214 Offset: 0x127B214 VA: 0x127F214
	|-IntSwitchInstruction<object>.get_ConsumedStack
	|
	|-RVA: 0x127F340 Offset: 0x127B340 VA: 0x127F340
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>.get_ConsumedStack
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public override int Run(InterpretedFrame frame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127F0F0 Offset: 0x127B0F0 VA: 0x127F0F0
	|-IntSwitchInstruction<int>.Run
	|
	|-RVA: 0x127F21C Offset: 0x127B21C VA: 0x127F21C
	|-IntSwitchInstruction<object>.Run
	|
	|-RVA: 0x127F348 Offset: 0x127B348 VA: 0x127F348
	|-IntSwitchInstruction<__Il2CppFullySharedGenericType>.Run
	*/
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StringSwitchInstruction : Instruction // TypeDefIndex: 5580
{
	// Fields
	private readonly Dictionary<string, int> _cases; // 0x10
	private readonly StrongBox<int> _nullCase; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x19D80E4 Offset: 0x19D40E4 VA: 0x19D80E4
	internal void .ctor(Dictionary<string, int> cases, StrongBox<int> nullCase) { }

	// RVA: 0x19D8128 Offset: 0x19D4128 VA: 0x19D8128 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D8168 Offset: 0x19D4168 VA: 0x19D8168 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D8170 Offset: 0x19D4170 VA: 0x19D8170 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementInt16 : DecrementInstruction // TypeDefIndex: 5581
{
	// Methods

	// RVA: 0x19D8674 Offset: 0x19D4674 VA: 0x19D8674 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D8634 Offset: 0x19D4634 VA: 0x19D8634
	public void .ctor() { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementInt32 : DecrementInstruction // TypeDefIndex: 5582
{
	// Methods

	// RVA: 0x19D86F0 Offset: 0x19D46F0 VA: 0x19D86F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D863C Offset: 0x19D463C VA: 0x19D863C
	public void .ctor() { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementInt64 : DecrementInstruction // TypeDefIndex: 5583
{
	// Methods

	// RVA: 0x19D876C Offset: 0x19D476C VA: 0x19D876C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D8644 Offset: 0x19D4644 VA: 0x19D8644
	public void .ctor() { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementUInt16 : DecrementInstruction // TypeDefIndex: 5584
{
	// Methods

	// RVA: 0x19D8800 Offset: 0x19D4800 VA: 0x19D8800 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D864C Offset: 0x19D464C VA: 0x19D864C
	public void .ctor() { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementUInt32 : DecrementInstruction // TypeDefIndex: 5585
{
	// Methods

	// RVA: 0x19D887C Offset: 0x19D487C VA: 0x19D887C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D8654 Offset: 0x19D4654 VA: 0x19D8654
	public void .ctor() { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementUInt64 : DecrementInstruction // TypeDefIndex: 5586
{
	// Methods

	// RVA: 0x19D8910 Offset: 0x19D4910 VA: 0x19D8910 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D865C Offset: 0x19D465C VA: 0x19D865C
	public void .ctor() { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementSingle : DecrementInstruction // TypeDefIndex: 5587
{
	// Methods

	// RVA: 0x19D89A4 Offset: 0x19D49A4 VA: 0x19D89A4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D8664 Offset: 0x19D4664 VA: 0x19D8664
	public void .ctor() { }
}

// Namespace: 
private sealed class DecrementInstruction.DecrementDouble : DecrementInstruction // TypeDefIndex: 5588
{
	// Methods

	// RVA: 0x19D8A38 Offset: 0x19D4A38 VA: 0x19D8A38 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D866C Offset: 0x19D466C VA: 0x19D866C
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class DecrementInstruction : Instruction // TypeDefIndex: 5589
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D8230 Offset: 0x19D4230 VA: 0x19D8230 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D8238 Offset: 0x19D4238 VA: 0x19D8238 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D8240 Offset: 0x19D4240 VA: 0x19D8240 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D8280 Offset: 0x19D4280 VA: 0x19D8280
	private void .ctor() { }

	// RVA: 0x19D8288 Offset: 0x19D4288 VA: 0x19D8288
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class DefaultValueInstruction : Instruction // TypeDefIndex: 5590
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D8ACC Offset: 0x19D4ACC VA: 0x19D8ACC
	internal void .ctor(Type type) { }

	// RVA: 0x19D8AFC Offset: 0x19D4AFC VA: 0x19D8AFC Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D8B04 Offset: 0x19D4B04 VA: 0x19D8B04 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D8B44 Offset: 0x19D4B44 VA: 0x19D8B44 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D8B7C Offset: 0x19D4B7C VA: 0x19D8B7C Slot: 3
	public override string ToString() { }
}

// Namespace: 
private sealed class DivInstruction.DivInt16 : DivInstruction // TypeDefIndex: 5591
{
	// Methods

	// RVA: 0x19D902C Offset: 0x19D502C VA: 0x19D902C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D8FEC Offset: 0x19D4FEC VA: 0x19D8FEC
	public void .ctor() { }
}

// Namespace: 
private sealed class DivInstruction.DivInt32 : DivInstruction // TypeDefIndex: 5592
{
	// Methods

	// RVA: 0x19D9168 Offset: 0x19D5168 VA: 0x19D9168 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D8FF4 Offset: 0x19D4FF4 VA: 0x19D8FF4
	public void .ctor() { }
}

// Namespace: 
private sealed class DivInstruction.DivInt64 : DivInstruction // TypeDefIndex: 5593
{
	// Methods

	// RVA: 0x19D9294 Offset: 0x19D5294 VA: 0x19D9294 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D8FFC Offset: 0x19D4FFC VA: 0x19D8FFC
	public void .ctor() { }
}

// Namespace: 
private sealed class DivInstruction.DivUInt16 : DivInstruction // TypeDefIndex: 5594
{
	// Methods

	// RVA: 0x19D93D0 Offset: 0x19D53D0 VA: 0x19D93D0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D9004 Offset: 0x19D5004 VA: 0x19D9004
	public void .ctor() { }
}

// Namespace: 
private sealed class DivInstruction.DivUInt32 : DivInstruction // TypeDefIndex: 5595
{
	// Methods

	// RVA: 0x19D950C Offset: 0x19D550C VA: 0x19D950C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D900C Offset: 0x19D500C VA: 0x19D900C
	public void .ctor() { }
}

// Namespace: 
private sealed class DivInstruction.DivUInt64 : DivInstruction // TypeDefIndex: 5596
{
	// Methods

	// RVA: 0x19D9648 Offset: 0x19D5648 VA: 0x19D9648 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D9014 Offset: 0x19D5014 VA: 0x19D9014
	public void .ctor() { }
}

// Namespace: 
private sealed class DivInstruction.DivSingle : DivInstruction // TypeDefIndex: 5597
{
	// Methods

	// RVA: 0x19D9784 Offset: 0x19D5784 VA: 0x19D9784 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D901C Offset: 0x19D501C VA: 0x19D901C
	public void .ctor() { }
}

// Namespace: 
private sealed class DivInstruction.DivDouble : DivInstruction // TypeDefIndex: 5598
{
	// Methods

	// RVA: 0x19D98C0 Offset: 0x19D58C0 VA: 0x19D98C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19D9024 Offset: 0x19D5024 VA: 0x19D9024
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class DivInstruction : Instruction // TypeDefIndex: 5599
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D8BE8 Offset: 0x19D4BE8 VA: 0x19D8BE8 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D8BF0 Offset: 0x19D4BF0 VA: 0x19D8BF0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D8BF8 Offset: 0x19D4BF8 VA: 0x19D8BF8 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D8C38 Offset: 0x19D4C38 VA: 0x19D8C38
	private void .ctor() { }

	// RVA: 0x19D8C40 Offset: 0x19D4C40 VA: 0x19D8C40
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class EqualInstruction.EqualBoolean : EqualInstruction // TypeDefIndex: 5600
{
	// Methods

	// RVA: 0x19DA354 Offset: 0x19D6354 VA: 0x19DA354 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA2EC Offset: 0x19D62EC VA: 0x19DA2EC
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualSByte : EqualInstruction // TypeDefIndex: 5601
{
	// Methods

	// RVA: 0x19DA414 Offset: 0x19D6414 VA: 0x19DA414 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA2F4 Offset: 0x19D62F4 VA: 0x19DA2F4
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualInt16 : EqualInstruction // TypeDefIndex: 5602
{
	// Methods

	// RVA: 0x19DA4D4 Offset: 0x19D64D4 VA: 0x19DA4D4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA2FC Offset: 0x19D62FC VA: 0x19DA2FC
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualChar : EqualInstruction // TypeDefIndex: 5603
{
	// Methods

	// RVA: 0x19DA594 Offset: 0x19D6594 VA: 0x19DA594 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA304 Offset: 0x19D6304 VA: 0x19DA304
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualInt32 : EqualInstruction // TypeDefIndex: 5604
{
	// Methods

	// RVA: 0x19DA654 Offset: 0x19D6654 VA: 0x19DA654 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA30C Offset: 0x19D630C VA: 0x19DA30C
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualInt64 : EqualInstruction // TypeDefIndex: 5605
{
	// Methods

	// RVA: 0x19DA714 Offset: 0x19D6714 VA: 0x19DA714 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA314 Offset: 0x19D6314 VA: 0x19DA314
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualByte : EqualInstruction // TypeDefIndex: 5606
{
	// Methods

	// RVA: 0x19DA7D4 Offset: 0x19D67D4 VA: 0x19DA7D4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA31C Offset: 0x19D631C VA: 0x19DA31C
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualUInt16 : EqualInstruction // TypeDefIndex: 5607
{
	// Methods

	// RVA: 0x19DA894 Offset: 0x19D6894 VA: 0x19DA894 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA324 Offset: 0x19D6324 VA: 0x19DA324
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualUInt32 : EqualInstruction // TypeDefIndex: 5608
{
	// Methods

	// RVA: 0x19DA954 Offset: 0x19D6954 VA: 0x19DA954 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA32C Offset: 0x19D632C VA: 0x19DA32C
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualUInt64 : EqualInstruction // TypeDefIndex: 5609
{
	// Methods

	// RVA: 0x19DAA14 Offset: 0x19D6A14 VA: 0x19DAA14 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA334 Offset: 0x19D6334 VA: 0x19DA334
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualSingle : EqualInstruction // TypeDefIndex: 5610
{
	// Methods

	// RVA: 0x19DAAD4 Offset: 0x19D6AD4 VA: 0x19DAAD4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA33C Offset: 0x19D633C VA: 0x19DA33C
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualDouble : EqualInstruction // TypeDefIndex: 5611
{
	// Methods

	// RVA: 0x19DAB9C Offset: 0x19D6B9C VA: 0x19DAB9C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA344 Offset: 0x19D6344 VA: 0x19DA344
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualReference : EqualInstruction // TypeDefIndex: 5612
{
	// Methods

	// RVA: 0x19DAC64 Offset: 0x19D6C64 VA: 0x19DAC64 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA34C Offset: 0x19D634C VA: 0x19DA34C
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualBooleanLiftedToNull : EqualInstruction // TypeDefIndex: 5613
{
	// Methods

	// RVA: 0x19DACB8 Offset: 0x19D6CB8 VA: 0x19DACB8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA28C Offset: 0x19D628C VA: 0x19DA28C
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualSByteLiftedToNull : EqualInstruction // TypeDefIndex: 5614
{
	// Methods

	// RVA: 0x19DAD80 Offset: 0x19D6D80 VA: 0x19DAD80 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA294 Offset: 0x19D6294 VA: 0x19DA294
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualInt16LiftedToNull : EqualInstruction // TypeDefIndex: 5615
{
	// Methods

	// RVA: 0x19DAE48 Offset: 0x19D6E48 VA: 0x19DAE48 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA29C Offset: 0x19D629C VA: 0x19DA29C
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualCharLiftedToNull : EqualInstruction // TypeDefIndex: 5616
{
	// Methods

	// RVA: 0x19DAF10 Offset: 0x19D6F10 VA: 0x19DAF10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA2A4 Offset: 0x19D62A4 VA: 0x19DA2A4
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualInt32LiftedToNull : EqualInstruction // TypeDefIndex: 5617
{
	// Methods

	// RVA: 0x19DAFD8 Offset: 0x19D6FD8 VA: 0x19DAFD8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA2AC Offset: 0x19D62AC VA: 0x19DA2AC
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualInt64LiftedToNull : EqualInstruction // TypeDefIndex: 5618
{
	// Methods

	// RVA: 0x19DB0A0 Offset: 0x19D70A0 VA: 0x19DB0A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA2B4 Offset: 0x19D62B4 VA: 0x19DA2B4
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualByteLiftedToNull : EqualInstruction // TypeDefIndex: 5619
{
	// Methods

	// RVA: 0x19DB168 Offset: 0x19D7168 VA: 0x19DB168 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA2BC Offset: 0x19D62BC VA: 0x19DA2BC
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualUInt16LiftedToNull : EqualInstruction // TypeDefIndex: 5620
{
	// Methods

	// RVA: 0x19DB230 Offset: 0x19D7230 VA: 0x19DB230 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA2C4 Offset: 0x19D62C4 VA: 0x19DA2C4
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualUInt32LiftedToNull : EqualInstruction // TypeDefIndex: 5621
{
	// Methods

	// RVA: 0x19DB2F8 Offset: 0x19D72F8 VA: 0x19DB2F8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA2CC Offset: 0x19D62CC VA: 0x19DA2CC
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualUInt64LiftedToNull : EqualInstruction // TypeDefIndex: 5622
{
	// Methods

	// RVA: 0x19DB3C0 Offset: 0x19D73C0 VA: 0x19DB3C0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA2D4 Offset: 0x19D62D4 VA: 0x19DA2D4
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualSingleLiftedToNull : EqualInstruction // TypeDefIndex: 5623
{
	// Methods

	// RVA: 0x19DB488 Offset: 0x19D7488 VA: 0x19DB488 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA2DC Offset: 0x19D62DC VA: 0x19DA2DC
	public void .ctor() { }
}

// Namespace: 
private sealed class EqualInstruction.EqualDoubleLiftedToNull : EqualInstruction // TypeDefIndex: 5624
{
	// Methods

	// RVA: 0x19DB558 Offset: 0x19D7558 VA: 0x19DB558 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DA2E4 Offset: 0x19D62E4 VA: 0x19DA2E4
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class EqualInstruction : Instruction // TypeDefIndex: 5625
{
	// Fields
	private static Instruction s_reference; // 0x0
	private static Instruction s_Boolean; // 0x8
	private static Instruction s_SByte; // 0x10
	private static Instruction s_Int16; // 0x18
	private static Instruction s_Char; // 0x20
	private static Instruction s_Int32; // 0x28
	private static Instruction s_Int64; // 0x30
	private static Instruction s_Byte; // 0x38
	private static Instruction s_UInt16; // 0x40
	private static Instruction s_UInt32; // 0x48
	private static Instruction s_UInt64; // 0x50
	private static Instruction s_Single; // 0x58
	private static Instruction s_Double; // 0x60
	private static Instruction s_BooleanLiftedToNull; // 0x68
	private static Instruction s_SByteLiftedToNull; // 0x70
	private static Instruction s_Int16LiftedToNull; // 0x78
	private static Instruction s_CharLiftedToNull; // 0x80
	private static Instruction s_Int32LiftedToNull; // 0x88
	private static Instruction s_Int64LiftedToNull; // 0x90
	private static Instruction s_ByteLiftedToNull; // 0x98
	private static Instruction s_UInt16LiftedToNull; // 0xA0
	private static Instruction s_UInt32LiftedToNull; // 0xA8
	private static Instruction s_UInt64LiftedToNull; // 0xB0
	private static Instruction s_SingleLiftedToNull; // 0xB8
	private static Instruction s_DoubleLiftedToNull; // 0xC0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19D99FC Offset: 0x19D59FC VA: 0x19D99FC Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19D9A04 Offset: 0x19D5A04 VA: 0x19D9A04 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19D9A0C Offset: 0x19D5A0C VA: 0x19D9A0C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19D9A4C Offset: 0x19D5A4C VA: 0x19D9A4C
	private void .ctor() { }

	// RVA: 0x19D9A54 Offset: 0x19D5A54 VA: 0x19D9A54
	public static Instruction Create(Type type, bool liftedToNull) { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrSByte : ExclusiveOrInstruction // TypeDefIndex: 5626
{
	// Methods

	// RVA: 0x19DBAA4 Offset: 0x19D7AA4 VA: 0x19DBAA4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DBA84 Offset: 0x19D7A84 VA: 0x19DBA84
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrInt16 : ExclusiveOrInstruction // TypeDefIndex: 5627
{
	// Methods

	// RVA: 0x19DBB78 Offset: 0x19D7B78 VA: 0x19DBB78 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DBA8C Offset: 0x19D7A8C VA: 0x19DBA8C
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrInt32 : ExclusiveOrInstruction // TypeDefIndex: 5628
{
	// Methods

	// RVA: 0x19DBC4C Offset: 0x19D7C4C VA: 0x19DBC4C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DBA94 Offset: 0x19D7A94 VA: 0x19DBA94
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrInt64 : ExclusiveOrInstruction // TypeDefIndex: 5629
{
	// Methods

	// RVA: 0x19DBD20 Offset: 0x19D7D20 VA: 0x19DBD20 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DBA9C Offset: 0x19D7A9C VA: 0x19DBA9C
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrByte : ExclusiveOrInstruction // TypeDefIndex: 5630
{
	// Methods

	// RVA: 0x19DBE04 Offset: 0x19D7E04 VA: 0x19DBE04 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DC00C Offset: 0x19D800C VA: 0x19DC00C
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrUInt16 : ExclusiveOrInstruction // TypeDefIndex: 5631
{
	// Methods

	// RVA: 0x19DC014 Offset: 0x19D8014 VA: 0x19DC014 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DC170 Offset: 0x19D8170 VA: 0x19DC170
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrUInt32 : ExclusiveOrInstruction // TypeDefIndex: 5632
{
	// Methods

	// RVA: 0x19DC178 Offset: 0x19D8178 VA: 0x19DC178 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DC250 Offset: 0x19D8250 VA: 0x19DC250
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrUInt64 : ExclusiveOrInstruction // TypeDefIndex: 5633
{
	// Methods

	// RVA: 0x19DC258 Offset: 0x19D8258 VA: 0x19DC258 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DC330 Offset: 0x19D8330 VA: 0x19DC330
	public void .ctor() { }
}

// Namespace: 
private sealed class ExclusiveOrInstruction.ExclusiveOrBoolean : ExclusiveOrInstruction // TypeDefIndex: 5634
{
	// Methods

	// RVA: 0x19DC338 Offset: 0x19D8338 VA: 0x19DC338 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DC4DC Offset: 0x19D84DC VA: 0x19DC4DC
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class ExclusiveOrInstruction : Instruction // TypeDefIndex: 5635
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38
	private static Instruction s_Boolean; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19DB628 Offset: 0x19D7628 VA: 0x19DB628 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19DB630 Offset: 0x19D7630 VA: 0x19DB630 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19DB638 Offset: 0x19D7638 VA: 0x19DB638 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19DB678 Offset: 0x19D7678 VA: 0x19DB678
	private void .ctor() { }

	// RVA: 0x19DB680 Offset: 0x19D7680 VA: 0x19DB680
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class FieldInstruction : Instruction // TypeDefIndex: 5636
{
	// Fields
	protected readonly FieldInfo _field; // 0x10

	// Methods

	// RVA: 0x19DC4E4 Offset: 0x19D84E4 VA: 0x19DC4E4
	public void .ctor(FieldInfo field) { }

	// RVA: 0x19DC51C Offset: 0x19D851C VA: 0x19DC51C Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadStaticFieldInstruction : FieldInstruction // TypeDefIndex: 5637
{
	// Properties
	public override string InstructionName { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x19DC5BC Offset: 0x19D85BC VA: 0x19DC5BC
	public void .ctor(FieldInfo field) { }

	// RVA: 0x19DC5EC Offset: 0x19D85EC VA: 0x19DC5EC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19DC62C Offset: 0x19D862C VA: 0x19DC62C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19DC634 Offset: 0x19D8634 VA: 0x19DC634 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadFieldInstruction : FieldInstruction // TypeDefIndex: 5638
{
	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x19DC678 Offset: 0x19D8678 VA: 0x19DC678
	public void .ctor(FieldInfo field) { }

	// RVA: 0x19DC6A8 Offset: 0x19D86A8 VA: 0x19DC6A8 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19DC6E8 Offset: 0x19D86E8 VA: 0x19DC6E8 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19DC6F0 Offset: 0x19D86F0 VA: 0x19DC6F0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19DC6F8 Offset: 0x19D86F8 VA: 0x19DC6F8 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StoreFieldInstruction : FieldInstruction // TypeDefIndex: 5639
{
	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x19DC764 Offset: 0x19D8764 VA: 0x19DC764
	public void .ctor(FieldInfo field) { }

	// RVA: 0x19DC794 Offset: 0x19D8794 VA: 0x19DC794 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19DC7D4 Offset: 0x19D87D4 VA: 0x19DC7D4 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19DC7DC Offset: 0x19D87DC VA: 0x19DC7DC Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StoreStaticFieldInstruction : FieldInstruction // TypeDefIndex: 5640
{
	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x19DC834 Offset: 0x19D8834 VA: 0x19DC834
	public void .ctor(FieldInfo field) { }

	// RVA: 0x19DC864 Offset: 0x19D8864 VA: 0x19DC864 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19DC8A4 Offset: 0x19D88A4 VA: 0x19DC8A4 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19DC8AC Offset: 0x19D88AC VA: 0x19DC8AC Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanSByte : GreaterThanInstruction // TypeDefIndex: 5641
{
	// Methods

	// RVA: 0x19DD4BC Offset: 0x19D94BC VA: 0x19DD4BC
	public void .ctor(object nullValue) { }

	// RVA: 0x19DD6CC Offset: 0x19D96CC VA: 0x19DD6CC Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanInt16 : GreaterThanInstruction // TypeDefIndex: 5642
{
	// Methods

	// RVA: 0x19DD4EC Offset: 0x19D94EC VA: 0x19DD4EC
	public void .ctor(object nullValue) { }

	// RVA: 0x19DD788 Offset: 0x19D9788 VA: 0x19DD788 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanChar : GreaterThanInstruction // TypeDefIndex: 5643
{
	// Methods

	// RVA: 0x19DD51C Offset: 0x19D951C VA: 0x19DD51C
	public void .ctor(object nullValue) { }

	// RVA: 0x19DD844 Offset: 0x19D9844 VA: 0x19DD844 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanInt32 : GreaterThanInstruction // TypeDefIndex: 5644
{
	// Methods

	// RVA: 0x19DD54C Offset: 0x19D954C VA: 0x19DD54C
	public void .ctor(object nullValue) { }

	// RVA: 0x19DD900 Offset: 0x19D9900 VA: 0x19DD900 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanInt64 : GreaterThanInstruction // TypeDefIndex: 5645
{
	// Methods

	// RVA: 0x19DD57C Offset: 0x19D957C VA: 0x19DD57C
	public void .ctor(object nullValue) { }

	// RVA: 0x19DD9BC Offset: 0x19D99BC VA: 0x19DD9BC Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanByte : GreaterThanInstruction // TypeDefIndex: 5646
{
	// Methods

	// RVA: 0x19DD5AC Offset: 0x19D95AC VA: 0x19DD5AC
	public void .ctor(object nullValue) { }

	// RVA: 0x19DDA78 Offset: 0x19D9A78 VA: 0x19DDA78 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanUInt16 : GreaterThanInstruction // TypeDefIndex: 5647
{
	// Methods

	// RVA: 0x19DD5DC Offset: 0x19D95DC VA: 0x19DD5DC
	public void .ctor(object nullValue) { }

	// RVA: 0x19DDB34 Offset: 0x19D9B34 VA: 0x19DDB34 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanUInt32 : GreaterThanInstruction // TypeDefIndex: 5648
{
	// Methods

	// RVA: 0x19DD60C Offset: 0x19D960C VA: 0x19DD60C
	public void .ctor(object nullValue) { }

	// RVA: 0x19DDBF0 Offset: 0x19D9BF0 VA: 0x19DDBF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanUInt64 : GreaterThanInstruction // TypeDefIndex: 5649
{
	// Methods

	// RVA: 0x19DD63C Offset: 0x19D963C VA: 0x19DD63C
	public void .ctor(object nullValue) { }

	// RVA: 0x19DDCAC Offset: 0x19D9CAC VA: 0x19DDCAC Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanSingle : GreaterThanInstruction // TypeDefIndex: 5650
{
	// Methods

	// RVA: 0x19DD66C Offset: 0x19D966C VA: 0x19DD66C
	public void .ctor(object nullValue) { }

	// RVA: 0x19DDD68 Offset: 0x19D9D68 VA: 0x19DDD68 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanInstruction.GreaterThanDouble : GreaterThanInstruction // TypeDefIndex: 5651
{
	// Methods

	// RVA: 0x19DD69C Offset: 0x19D969C VA: 0x19DD69C
	public void .ctor(object nullValue) { }

	// RVA: 0x19DDE2C Offset: 0x19D9E2C VA: 0x19DDE2C Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class GreaterThanInstruction : Instruction // TypeDefIndex: 5652
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19DC8EC Offset: 0x19D88EC VA: 0x19DC8EC Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19DC8F4 Offset: 0x19D88F4 VA: 0x19DC8F4 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19DC8FC Offset: 0x19D88FC VA: 0x19DC8FC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19DC93C Offset: 0x19D893C VA: 0x19DC93C
	private void .ctor(object nullValue) { }

	// RVA: 0x19DC96C Offset: 0x19D896C VA: 0x19DC96C
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualSByte : GreaterThanOrEqualInstruction // TypeDefIndex: 5653
{
	// Methods

	// RVA: 0x19DEAC0 Offset: 0x19DAAC0 VA: 0x19DEAC0
	public void .ctor(object nullValue) { }

	// RVA: 0x19DECD0 Offset: 0x19DACD0 VA: 0x19DECD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualInt16 : GreaterThanOrEqualInstruction // TypeDefIndex: 5654
{
	// Methods

	// RVA: 0x19DEAF0 Offset: 0x19DAAF0 VA: 0x19DEAF0
	public void .ctor(object nullValue) { }

	// RVA: 0x19DED8C Offset: 0x19DAD8C VA: 0x19DED8C Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualChar : GreaterThanOrEqualInstruction // TypeDefIndex: 5655
{
	// Methods

	// RVA: 0x19DEB20 Offset: 0x19DAB20 VA: 0x19DEB20
	public void .ctor(object nullValue) { }

	// RVA: 0x19DEE48 Offset: 0x19DAE48 VA: 0x19DEE48 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualInt32 : GreaterThanOrEqualInstruction // TypeDefIndex: 5656
{
	// Methods

	// RVA: 0x19DEB50 Offset: 0x19DAB50 VA: 0x19DEB50
	public void .ctor(object nullValue) { }

	// RVA: 0x19DEF04 Offset: 0x19DAF04 VA: 0x19DEF04 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualInt64 : GreaterThanOrEqualInstruction // TypeDefIndex: 5657
{
	// Methods

	// RVA: 0x19DEB80 Offset: 0x19DAB80 VA: 0x19DEB80
	public void .ctor(object nullValue) { }

	// RVA: 0x19DEFC0 Offset: 0x19DAFC0 VA: 0x19DEFC0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualByte : GreaterThanOrEqualInstruction // TypeDefIndex: 5658
{
	// Methods

	// RVA: 0x19DEBB0 Offset: 0x19DABB0 VA: 0x19DEBB0
	public void .ctor(object nullValue) { }

	// RVA: 0x19DF07C Offset: 0x19DB07C VA: 0x19DF07C Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt16 : GreaterThanOrEqualInstruction // TypeDefIndex: 5659
{
	// Methods

	// RVA: 0x19DEBE0 Offset: 0x19DABE0 VA: 0x19DEBE0
	public void .ctor(object nullValue) { }

	// RVA: 0x19DF138 Offset: 0x19DB138 VA: 0x19DF138 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt32 : GreaterThanOrEqualInstruction // TypeDefIndex: 5660
{
	// Methods

	// RVA: 0x19DEC10 Offset: 0x19DAC10 VA: 0x19DEC10
	public void .ctor(object nullValue) { }

	// RVA: 0x19DF1F4 Offset: 0x19DB1F4 VA: 0x19DF1F4 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualUInt64 : GreaterThanOrEqualInstruction // TypeDefIndex: 5661
{
	// Methods

	// RVA: 0x19DEC40 Offset: 0x19DAC40 VA: 0x19DEC40
	public void .ctor(object nullValue) { }

	// RVA: 0x19DF2B0 Offset: 0x19DB2B0 VA: 0x19DF2B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualSingle : GreaterThanOrEqualInstruction // TypeDefIndex: 5662
{
	// Methods

	// RVA: 0x19DEC70 Offset: 0x19DAC70 VA: 0x19DEC70
	public void .ctor(object nullValue) { }

	// RVA: 0x19DF36C Offset: 0x19DB36C VA: 0x19DF36C Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class GreaterThanOrEqualInstruction.GreaterThanOrEqualDouble : GreaterThanOrEqualInstruction // TypeDefIndex: 5663
{
	// Methods

	// RVA: 0x19DECA0 Offset: 0x19DACA0 VA: 0x19DECA0
	public void .ctor(object nullValue) { }

	// RVA: 0x19DF430 Offset: 0x19DB430 VA: 0x19DF430 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class GreaterThanOrEqualInstruction : Instruction // TypeDefIndex: 5664
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19DDEF0 Offset: 0x19D9EF0 VA: 0x19DDEF0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19DDEF8 Offset: 0x19D9EF8 VA: 0x19DDEF8 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19DDF00 Offset: 0x19D9F00 VA: 0x19DDF00 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19DDF40 Offset: 0x19D9F40 VA: 0x19DDF40
	private void .ctor(object nullValue) { }

	// RVA: 0x19DDF70 Offset: 0x19D9F70 VA: 0x19DDF70
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementInt16 : IncrementInstruction // TypeDefIndex: 5665
{
	// Methods

	// RVA: 0x19DF938 Offset: 0x19DB938 VA: 0x19DF938 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DF8F8 Offset: 0x19DB8F8 VA: 0x19DF8F8
	public void .ctor() { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementInt32 : IncrementInstruction // TypeDefIndex: 5666
{
	// Methods

	// RVA: 0x19DFA40 Offset: 0x19DBA40 VA: 0x19DFA40 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DF900 Offset: 0x19DB900 VA: 0x19DF900
	public void .ctor() { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementInt64 : IncrementInstruction // TypeDefIndex: 5667
{
	// Methods

	// RVA: 0x19DFB2C Offset: 0x19DBB2C VA: 0x19DFB2C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DF908 Offset: 0x19DB908 VA: 0x19DF908
	public void .ctor() { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementUInt16 : IncrementInstruction // TypeDefIndex: 5668
{
	// Methods

	// RVA: 0x19DFBB8 Offset: 0x19DBBB8 VA: 0x19DFBB8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DF910 Offset: 0x19DB910 VA: 0x19DF910
	public void .ctor() { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementUInt32 : IncrementInstruction // TypeDefIndex: 5669
{
	// Methods

	// RVA: 0x19DFC28 Offset: 0x19DBC28 VA: 0x19DFC28 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DF918 Offset: 0x19DB918 VA: 0x19DF918
	public void .ctor() { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementUInt64 : IncrementInstruction // TypeDefIndex: 5670
{
	// Methods

	// RVA: 0x19DFCB4 Offset: 0x19DBCB4 VA: 0x19DFCB4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DF920 Offset: 0x19DB920 VA: 0x19DF920
	public void .ctor() { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementSingle : IncrementInstruction // TypeDefIndex: 5671
{
	// Methods

	// RVA: 0x19DFD40 Offset: 0x19DBD40 VA: 0x19DFD40 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DF928 Offset: 0x19DB928 VA: 0x19DF928
	public void .ctor() { }
}

// Namespace: 
private sealed class IncrementInstruction.IncrementDouble : IncrementInstruction // TypeDefIndex: 5672
{
	// Methods

	// RVA: 0x19DFDCC Offset: 0x19DBDCC VA: 0x19DFDCC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19DF930 Offset: 0x19DB930 VA: 0x19DF930
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class IncrementInstruction : Instruction // TypeDefIndex: 5673
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19DF4F4 Offset: 0x19DB4F4 VA: 0x19DF4F4 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19DF4FC Offset: 0x19DB4FC VA: 0x19DF4FC Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19DF504 Offset: 0x19DB504 VA: 0x19DF504 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19DF544 Offset: 0x19DB544 VA: 0x19DF544
	private void .ctor() { }

	// RVA: 0x19DF54C Offset: 0x19DB54C VA: 0x19DF54C
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class Instruction // TypeDefIndex: 5674
{
	// Properties
	public virtual int ConsumedStack { get; }
	public virtual int ProducedStack { get; }
	public virtual int ConsumedContinuations { get; }
	public virtual int ProducedContinuations { get; }
	public int StackBalance { get; }
	public int ContinuationsBalance { get; }
	public abstract string InstructionName { get; }

	// Methods

	// RVA: 0x19DFE58 Offset: 0x19DBE58 VA: 0x19DFE58 Slot: 4
	public virtual int get_ConsumedStack() { }

	// RVA: 0x19DFE60 Offset: 0x19DBE60 VA: 0x19DFE60 Slot: 5
	public virtual int get_ProducedStack() { }

	// RVA: 0x19DFE68 Offset: 0x19DBE68 VA: 0x19DFE68 Slot: 6
	public virtual int get_ConsumedContinuations() { }

	// RVA: 0x19DFE70 Offset: 0x19DBE70 VA: 0x19DFE70 Slot: 7
	public virtual int get_ProducedContinuations() { }

	// RVA: 0x19DFE78 Offset: 0x19DBE78 VA: 0x19DFE78
	public int get_StackBalance() { }

	// RVA: 0x19DFEB4 Offset: 0x19DBEB4 VA: 0x19DFEB4
	public int get_ContinuationsBalance() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int Run(InterpretedFrame frame);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string get_InstructionName();

	// RVA: 0x19DFEF0 Offset: 0x19DBEF0 VA: 0x19DFEF0 Slot: 3
	public override string ToString() { }

	// RVA: 0x19DFF48 Offset: 0x19DBF48 VA: 0x19DFF48 Slot: 10
	public virtual string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x19DC754 Offset: 0x19D8754 VA: 0x19DC754
	protected static void NullCheck(object o) { }

	// RVA: 0x19DC514 Offset: 0x19D8514 VA: 0x19DC514
	protected void .ctor() { }
}

// Namespace: 
internal sealed class InstructionArray.DebugView // TypeDefIndex: 5675
{
	// Fields
	private readonly InstructionArray _array; // 0x10

	// Methods

	// RVA: 0x19DFFBC Offset: 0x19DBFBC VA: 0x19DFFBC
	public void .ctor(InstructionArray array) { }

	// RVA: 0x19E0074 Offset: 0x19DC074 VA: 0x19E0074
	public InstructionList.DebugView.InstructionView[] GetInstructionViews(bool includeDebugCookies = False) { }

	[CompilerGenerated]
	// RVA: 0x19E0710 Offset: 0x19DC710 VA: 0x19E0710
	private int <GetInstructionViews>b__4_0(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
[IsReadOnly]
[DebuggerTypeProxy(typeof(InstructionArray.DebugView))]
internal struct InstructionArray // TypeDefIndex: 5676
{
	// Fields
	internal readonly int MaxStackDepth; // 0x0
	internal readonly int MaxContinuationDepth; // 0x4
	internal readonly Instruction[] Instructions; // 0x8
	internal readonly object[] Objects; // 0x10
	internal readonly RuntimeLabel[] Labels; // 0x18
	internal readonly List<KeyValuePair<int, object>> DebugCookies; // 0x20

	// Methods

	// RVA: 0x19DFF54 Offset: 0x19DBF54 VA: 0x19DFF54
	internal void .ctor(int maxStackDepth, int maxContinuationDepth, Instruction[] instructions, object[] objects, RuntimeLabel[] labels, List<KeyValuePair<int, object>> debugCookies) { }
}

// Namespace: 
[IsReadOnly]
[DebuggerDisplay("{GetValue(),nq}", Name = "{GetName(),nq}", Type = "{GetDisplayType(), nq}")]
internal struct InstructionList.DebugView.InstructionView // TypeDefIndex: 5677
{
	// Fields
	private readonly int _index; // 0x0
	private readonly int _stackDepth; // 0x4
	private readonly int _continuationsDepth; // 0x8
	private readonly string _name; // 0x10
	private readonly Instruction _instruction; // 0x18

	// Methods

	// RVA: 0x19E6404 Offset: 0x19E2404 VA: 0x19E6404
	internal string GetValue() { }

	// RVA: 0x19E63B4 Offset: 0x19E23B4 VA: 0x19E63B4
	public void .ctor(Instruction instruction, string name, int index, int stackDepth, int continuationsDepth) { }
}

// Namespace: 
internal sealed class InstructionList.DebugView // TypeDefIndex: 5678
{
	// Methods

	// RVA: 0x19E0114 Offset: 0x19DC114 VA: 0x19E0114
	internal static InstructionList.DebugView.InstructionView[] GetInstructionViews(IReadOnlyList<Instruction> instructions, IReadOnlyList<object> objects, Func<int, int> labelIndexer, IReadOnlyList<KeyValuePair<int, object>> debugCookies) { }
}

// Namespace: System.Linq.Expressions.Interpreter
[DebuggerTypeProxy(typeof(InstructionList.DebugView))]
internal sealed class InstructionList // TypeDefIndex: 5679
{
	// Fields
	private readonly List<Instruction> _instructions; // 0x10
	private List<object> _objects; // 0x18
	private int _currentStackDepth; // 0x20
	private int _maxStackDepth; // 0x24
	private int _currentContinuationsDepth; // 0x28
	private int _maxContinuationDepth; // 0x2C
	private int _runtimeLabelCount; // 0x30
	private List<BranchLabel> _labels; // 0x38
	private List<KeyValuePair<int, object>> _debugCookies; // 0x40
	private static Instruction s_null; // 0x0
	private static Instruction s_true; // 0x8
	private static Instruction s_false; // 0x10
	private static Instruction[] s_Ints; // 0x18
	private static Instruction[] s_loadObjectCached; // 0x20
	private static Instruction[] s_loadLocal; // 0x28
	private static Instruction[] s_loadLocalBoxed; // 0x30
	private static Instruction[] s_loadLocalFromClosure; // 0x38
	private static Instruction[] s_loadLocalFromClosureBoxed; // 0x40
	private static Instruction[] s_assignLocal; // 0x48
	private static Instruction[] s_storeLocal; // 0x50
	private static Instruction[] s_assignLocalBoxed; // 0x58
	private static Instruction[] s_storeLocalBoxed; // 0x60
	private static Instruction[] s_assignLocalToClosure; // 0x68
	private static readonly Dictionary<FieldInfo, Instruction> s_loadFields; // 0x70
	private static readonly RuntimeLabel[] s_emptyRuntimeLabels; // 0x78

	// Properties
	public int Count { get; }
	public int CurrentStackDepth { get; }
	public int CurrentContinuationsDepth { get; }

	// Methods

	// RVA: 0x19E0744 Offset: 0x19DC744 VA: 0x19E0744
	public void Emit(Instruction instruction) { }

	// RVA: 0x19E07F8 Offset: 0x19DC7F8 VA: 0x19E07F8
	private void UpdateStackDepth(Instruction instruction) { }

	// RVA: 0x19E08A4 Offset: 0x19DC8A4 VA: 0x19E08A4
	public void UnEmit() { }

	// RVA: 0x19E09B4 Offset: 0x19DC9B4 VA: 0x19E09B4
	public int get_Count() { }

	// RVA: 0x19E09FC Offset: 0x19DC9FC VA: 0x19E09FC
	public int get_CurrentStackDepth() { }

	// RVA: 0x19E0A04 Offset: 0x19DCA04 VA: 0x19E0A04
	public int get_CurrentContinuationsDepth() { }

	// RVA: 0x19E0A0C Offset: 0x19DCA0C VA: 0x19E0A0C
	internal Instruction GetInstruction(int index) { }

	// RVA: 0x19E0A64 Offset: 0x19DCA64 VA: 0x19E0A64
	public InstructionArray ToArray() { }

	// RVA: 0x19E0D8C Offset: 0x19DCD8C VA: 0x19E0D8C
	public void EmitLoad(object value) { }

	// RVA: 0x19E12B8 Offset: 0x19DD2B8 VA: 0x19E12B8
	public void EmitLoad(bool value) { }

	// RVA: 0x19E0D94 Offset: 0x19DCD94 VA: 0x19E0D94
	public void EmitLoad(object value, Type type) { }

	// RVA: 0x19E143C Offset: 0x19DD43C VA: 0x19E143C
	public void EmitDup() { }

	// RVA: 0x19E149C Offset: 0x19DD49C VA: 0x19E149C
	public void EmitPop() { }

	// RVA: 0x19E14FC Offset: 0x19DD4FC VA: 0x19E14FC
	internal void SwitchToBoxed(int index, int instructionIndex) { }

	// RVA: 0x19E1620 Offset: 0x19DD620 VA: 0x19E1620
	public void EmitLoadLocal(int index) { }

	// RVA: 0x19E1800 Offset: 0x19DD800 VA: 0x19E1800
	public void EmitLoadLocalBoxed(int index) { }

	// RVA: 0x19E186C Offset: 0x19DD86C VA: 0x19E186C
	internal static Instruction LoadLocalBoxed(int index) { }

	// RVA: 0x19E1A3C Offset: 0x19DDA3C VA: 0x19E1A3C
	public void EmitLoadLocalFromClosure(int index) { }

	// RVA: 0x19E1C1C Offset: 0x19DDC1C VA: 0x19E1C1C
	public void EmitLoadLocalFromClosureBoxed(int index) { }

	// RVA: 0x19E1DFC Offset: 0x19DDDFC VA: 0x19E1DFC
	public void EmitAssignLocal(int index) { }

	// RVA: 0x19E1FDC Offset: 0x19DDFDC VA: 0x19E1FDC
	public void EmitStoreLocal(int index) { }

	// RVA: 0x19E21BC Offset: 0x19DE1BC VA: 0x19E21BC
	public void EmitAssignLocalBoxed(int index) { }

	// RVA: 0x19E2228 Offset: 0x19DE228 VA: 0x19E2228
	internal static Instruction AssignLocalBoxed(int index) { }

	// RVA: 0x19E23F8 Offset: 0x19DE3F8 VA: 0x19E23F8
	public void EmitStoreLocalBoxed(int index) { }

	// RVA: 0x19E2464 Offset: 0x19DE464 VA: 0x19E2464
	internal static Instruction StoreLocalBoxed(int index) { }

	// RVA: 0x19E2634 Offset: 0x19DE634 VA: 0x19E2634
	public void EmitAssignLocalToClosure(int index) { }

	// RVA: 0x19E2814 Offset: 0x19DE814 VA: 0x19E2814
	public void EmitStoreLocalToClosure(int index) { }

	// RVA: 0x19E282C Offset: 0x19DE82C VA: 0x19E282C
	public void EmitInitializeLocal(int index, Type type) { }

	// RVA: 0x19E2990 Offset: 0x19DE990 VA: 0x19E2990
	internal void EmitInitializeParameter(int index) { }

	// RVA: 0x19E29FC Offset: 0x19DE9FC VA: 0x19E29FC
	internal static Instruction Parameter(int index) { }

	// RVA: 0x19E2A58 Offset: 0x19DEA58 VA: 0x19E2A58
	internal static Instruction ParameterBox(int index) { }

	// RVA: 0x19E2934 Offset: 0x19DE934 VA: 0x19E2934
	internal static Instruction InitReference(int index) { }

	// RVA: 0x19E2AB4 Offset: 0x19DEAB4 VA: 0x19E2AB4
	internal static Instruction InitImmutableRefBox(int index) { }

	// RVA: 0x19E2B10 Offset: 0x19DEB10 VA: 0x19E2B10
	public void EmitNewRuntimeVariables(int count) { }

	// RVA: 0x19E2B7C Offset: 0x19DEB7C VA: 0x19E2B7C
	public void EmitGetArrayItem() { }

	// RVA: 0x19E2BDC Offset: 0x19DEBDC VA: 0x19E2BDC
	public void EmitSetArrayItem() { }

	// RVA: 0x19E2C3C Offset: 0x19DEC3C VA: 0x19E2C3C
	public void EmitNewArray(Type elementType) { }

	// RVA: 0x19E2CA8 Offset: 0x19DECA8 VA: 0x19E2CA8
	public void EmitNewArrayBounds(Type elementType, int rank) { }

	// RVA: 0x19E2D1C Offset: 0x19DED1C VA: 0x19E2D1C
	public void EmitNewArrayInit(Type elementType, int elementCount) { }

	// RVA: 0x19E2D90 Offset: 0x19DED90 VA: 0x19E2D90
	public void EmitAdd(Type type, bool checked) { }

	// RVA: 0x19E2DC8 Offset: 0x19DEDC8 VA: 0x19E2DC8
	public void EmitSub(Type type, bool checked) { }

	// RVA: 0x19E2E00 Offset: 0x19DEE00 VA: 0x19E2E00
	public void EmitMul(Type type, bool checked) { }

	// RVA: 0x19E2E38 Offset: 0x19DEE38 VA: 0x19E2E38
	public void EmitDiv(Type type) { }

	// RVA: 0x19E2E5C Offset: 0x19DEE5C VA: 0x19E2E5C
	public void EmitModulo(Type type) { }

	// RVA: 0x19E2E80 Offset: 0x19DEE80 VA: 0x19E2E80
	public void EmitExclusiveOr(Type type) { }

	// RVA: 0x19E2EA4 Offset: 0x19DEEA4 VA: 0x19E2EA4
	public void EmitAnd(Type type) { }

	// RVA: 0x19E2EC8 Offset: 0x19DEEC8 VA: 0x19E2EC8
	public void EmitOr(Type type) { }

	// RVA: 0x19E2EEC Offset: 0x19DEEEC VA: 0x19E2EEC
	public void EmitLeftShift(Type type) { }

	// RVA: 0x19E32B8 Offset: 0x19DF2B8 VA: 0x19E32B8
	public void EmitRightShift(Type type) { }

	// RVA: 0x19E32DC Offset: 0x19DF2DC VA: 0x19E32DC
	public void EmitEqual(Type type, bool liftedToNull = False) { }

	// RVA: 0x19E3304 Offset: 0x19DF304 VA: 0x19E3304
	public void EmitNotEqual(Type type, bool liftedToNull = False) { }

	// RVA: 0x19E332C Offset: 0x19DF32C VA: 0x19E332C
	public void EmitLessThan(Type type, bool liftedToNull) { }

	// RVA: 0x19E3EA0 Offset: 0x19DFEA0 VA: 0x19E3EA0
	public void EmitLessThanOrEqual(Type type, bool liftedToNull) { }

	// RVA: 0x19E4A14 Offset: 0x19E0A14 VA: 0x19E4A14
	public void EmitGreaterThan(Type type, bool liftedToNull) { }

	// RVA: 0x19E4A38 Offset: 0x19E0A38 VA: 0x19E4A38
	public void EmitGreaterThanOrEqual(Type type, bool liftedToNull) { }

	// RVA: 0x19E4A5C Offset: 0x19E0A5C VA: 0x19E4A5C
	public void EmitNumericConvertChecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x19E4AE0 Offset: 0x19E0AE0 VA: 0x19E4AE0
	public void EmitNumericConvertUnchecked(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x19E4B64 Offset: 0x19E0B64 VA: 0x19E4B64
	public void EmitConvertToUnderlying(TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x19E4BD8 Offset: 0x19E0BD8 VA: 0x19E4BD8
	public void EmitCast(Type toType) { }

	// RVA: 0x19E4BFC Offset: 0x19E0BFC VA: 0x19E4BFC
	public void EmitCastToEnum(Type toType) { }

	// RVA: 0x19E4C68 Offset: 0x19E0C68 VA: 0x19E4C68
	public void EmitCastReferenceToEnum(Type toType) { }

	// RVA: 0x19E4CD4 Offset: 0x19E0CD4 VA: 0x19E4CD4
	public void EmitNot(Type type) { }

	// RVA: 0x19E4CF8 Offset: 0x19E0CF8 VA: 0x19E4CF8
	public void EmitDefaultValue(Type type) { }

	// RVA: 0x19E4D64 Offset: 0x19E0D64 VA: 0x19E4D64
	public void EmitNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters) { }

	// RVA: 0x19E4DE0 Offset: 0x19E0DE0 VA: 0x19E4DE0
	public void EmitByRefNew(ConstructorInfo constructorInfo, ParameterInfo[] parameters, ByRefUpdater[] updaters) { }

	// RVA: 0x19E4E64 Offset: 0x19E0E64 VA: 0x19E4E64
	internal void EmitCreateDelegate(LightDelegateCreator creator) { }

	// RVA: 0x19E4ED0 Offset: 0x19E0ED0 VA: 0x19E4ED0
	public void EmitTypeEquals() { }

	// RVA: 0x19E4F30 Offset: 0x19E0F30 VA: 0x19E4F30
	public void EmitArrayLength() { }

	// RVA: 0x19E4F90 Offset: 0x19E0F90 VA: 0x19E4F90
	public void EmitNegate(Type type) { }

	// RVA: 0x19E4FB4 Offset: 0x19E0FB4 VA: 0x19E4FB4
	public void EmitNegateChecked(Type type) { }

	// RVA: 0x19E4FD8 Offset: 0x19E0FD8 VA: 0x19E4FD8
	public void EmitIncrement(Type type) { }

	// RVA: 0x19E4FF8 Offset: 0x19E0FF8 VA: 0x19E4FF8
	public void EmitDecrement(Type type) { }

	// RVA: 0x19E501C Offset: 0x19E101C VA: 0x19E501C
	public void EmitTypeIs(Type type) { }

	// RVA: 0x19E5088 Offset: 0x19E1088 VA: 0x19E5088
	public void EmitTypeAs(Type type) { }

	// RVA: 0x19E50F4 Offset: 0x19E10F4 VA: 0x19E50F4
	public void EmitLoadField(FieldInfo field) { }

	// RVA: 0x19E5110 Offset: 0x19E1110 VA: 0x19E5110
	private Instruction GetLoadField(FieldInfo field) { }

	// RVA: 0x19E5360 Offset: 0x19E1360 VA: 0x19E5360
	public void EmitStoreField(FieldInfo field) { }

	// RVA: 0x19E5408 Offset: 0x19E1408 VA: 0x19E5408
	public void EmitCall(MethodInfo method) { }

	// RVA: 0x19E5488 Offset: 0x19E1488 VA: 0x19E5488
	public void EmitCall(MethodInfo method, ParameterInfo[] parameters) { }

	// RVA: 0x19E54B0 Offset: 0x19E14B0 VA: 0x19E54B0
	public void EmitByRefCall(MethodInfo method, ParameterInfo[] parameters, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x19E5560 Offset: 0x19E1560 VA: 0x19E5560
	public void EmitNullableCall(MethodInfo method, ParameterInfo[] parameters) { }

	// RVA: 0x19E0B3C Offset: 0x19DCB3C VA: 0x19E0B3C
	private RuntimeLabel[] BuildRuntimeLabels() { }

	// RVA: 0x19E55B4 Offset: 0x19E15B4 VA: 0x19E55B4
	public BranchLabel MakeLabel() { }

	// RVA: 0x19E56DC Offset: 0x19E16DC VA: 0x19E56DC
	internal void FixupBranch(int branchIndex, int offset) { }

	// RVA: 0x19E57C0 Offset: 0x19E17C0 VA: 0x19E57C0
	private int EnsureLabelIndex(BranchLabel label) { }

	// RVA: 0x19E580C Offset: 0x19E180C VA: 0x19E580C
	public int MarkRuntimeLabel() { }

	// RVA: 0x19E5848 Offset: 0x19E1848 VA: 0x19E5848
	public void MarkLabel(BranchLabel label) { }

	// RVA: 0x19E5868 Offset: 0x19E1868 VA: 0x19E5868
	public void EmitGoto(BranchLabel label, bool hasResult, bool hasValue, bool labelTargetGetsValue) { }

	// RVA: 0x19E590C Offset: 0x19E190C VA: 0x19E590C
	private void EmitBranch(OffsetInstruction instruction, BranchLabel label) { }

	// RVA: 0x19E594C Offset: 0x19E194C VA: 0x19E594C
	public void EmitBranch(BranchLabel label) { }

	// RVA: 0x19E59B8 Offset: 0x19E19B8 VA: 0x19E59B8
	public void EmitBranch(BranchLabel label, bool hasResult, bool hasValue) { }

	// RVA: 0x19E5A3C Offset: 0x19E1A3C VA: 0x19E5A3C
	public void EmitCoalescingBranch(BranchLabel leftNotNull) { }

	// RVA: 0x19E5AA8 Offset: 0x19E1AA8 VA: 0x19E5AA8
	public void EmitBranchTrue(BranchLabel elseLabel) { }

	// RVA: 0x19E5B14 Offset: 0x19E1B14 VA: 0x19E5B14
	public void EmitBranchFalse(BranchLabel elseLabel) { }

	// RVA: 0x19E5B80 Offset: 0x19E1B80 VA: 0x19E5B80
	public void EmitThrow() { }

	// RVA: 0x19E5BE0 Offset: 0x19E1BE0 VA: 0x19E5BE0
	public void EmitThrowVoid() { }

	// RVA: 0x19E5C40 Offset: 0x19E1C40 VA: 0x19E5C40
	public void EmitRethrow() { }

	// RVA: 0x19E5CA0 Offset: 0x19E1CA0 VA: 0x19E5CA0
	public void EmitRethrowVoid() { }

	// RVA: 0x19E5D00 Offset: 0x19E1D00 VA: 0x19E5D00
	public void EmitEnterTryFinally(BranchLabel finallyStartLabel) { }

	// RVA: 0x19E5D24 Offset: 0x19E1D24 VA: 0x19E5D24
	public void EmitEnterTryCatch() { }

	// RVA: 0x19E5D44 Offset: 0x19E1D44 VA: 0x19E5D44
	public EnterTryFaultInstruction EmitEnterTryFault(BranchLabel tryEnd) { }

	// RVA: 0x19E5DCC Offset: 0x19E1DCC VA: 0x19E5DCC
	public void EmitEnterFinally(BranchLabel finallyStartLabel) { }

	// RVA: 0x19E5E50 Offset: 0x19E1E50 VA: 0x19E5E50
	public void EmitLeaveFinally() { }

	// RVA: 0x19E5EB0 Offset: 0x19E1EB0 VA: 0x19E5EB0
	public void EmitEnterFault(BranchLabel faultStartLabel) { }

	// RVA: 0x19E5F34 Offset: 0x19E1F34 VA: 0x19E5F34
	public void EmitLeaveFault() { }

	// RVA: 0x19E5F94 Offset: 0x19E1F94 VA: 0x19E5F94
	public void EmitEnterExceptionFilter() { }

	// RVA: 0x19E5FF4 Offset: 0x19E1FF4 VA: 0x19E5FF4
	public void EmitLeaveExceptionFilter() { }

	// RVA: 0x19E6054 Offset: 0x19E2054 VA: 0x19E6054
	public void EmitEnterExceptionHandlerNonVoid() { }

	// RVA: 0x19E60B4 Offset: 0x19E20B4 VA: 0x19E60B4
	public void EmitEnterExceptionHandlerVoid() { }

	// RVA: 0x19E6114 Offset: 0x19E2114 VA: 0x19E6114
	public void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel) { }

	// RVA: -1 Offset: -1
	public void EmitIntSwitch<T>(Dictionary<T, int> cases) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111A878 Offset: 0x1116878 VA: 0x111A878
	|-InstructionList.EmitIntSwitch<int>
	|
	|-RVA: 0x111A8E4 Offset: 0x11168E4 VA: 0x111A8E4
	|-InstructionList.EmitIntSwitch<object>
	|
	|-RVA: 0x111A950 Offset: 0x1116950 VA: 0x111A950
	|-InstructionList.EmitIntSwitch<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x19E61A0 Offset: 0x19E21A0 VA: 0x19E61A0
	public void EmitStringSwitch(Dictionary<string, int> cases, StrongBox<int> nullCase) { }

	// RVA: 0x19E6214 Offset: 0x19E2214 VA: 0x19E6214
	public void .ctor() { }

	// RVA: 0x19E629C Offset: 0x19E229C VA: 0x19E629C
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
private sealed class InterpretedFrame.<GetStackTraceDebugInfo>d__29 : IEnumerable<InterpretedFrameInfo>, IEnumerable, IEnumerator<InterpretedFrameInfo>, IDisposable, IEnumerator // TypeDefIndex: 5680
{
	// Fields
	private int <>1__state; // 0x10
	private InterpretedFrameInfo <>2__current; // 0x18
	private int <>l__initialThreadId; // 0x28
	public InterpretedFrame <>4__this; // 0x30
	private InterpretedFrame <frame>5__2; // 0x38

	// Properties
	private InterpretedFrameInfo System.Collections.Generic.IEnumerator<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: 0x19E68A8 Offset: 0x19E28A8 VA: 0x19E68A8
	public void .ctor(int <>1__state) { }

	[DebuggerHidden]
	// RVA: 0x19E70AC Offset: 0x19E30AC VA: 0x19E70AC Slot: 7
	private void System.IDisposable.Dispose() { }

	// RVA: 0x19E70B0 Offset: 0x19E30B0 VA: 0x19E70B0 Slot: 8
	private bool MoveNext() { }

	[DebuggerHidden]
	// RVA: 0x19E71D0 Offset: 0x19E31D0 VA: 0x19E71D0 Slot: 6
	private InterpretedFrameInfo System.Collections.Generic.IEnumerator<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19E71DC Offset: 0x19E31DC VA: 0x19E71DC Slot: 10
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHidden]
	// RVA: 0x19E7214 Offset: 0x19E3214 VA: 0x19E7214 Slot: 9
	private object System.Collections.IEnumerator.get_Current() { }

	[DebuggerHidden]
	// RVA: 0x19E7270 Offset: 0x19E3270 VA: 0x19E7270 Slot: 4
	private IEnumerator<InterpretedFrameInfo> System.Collections.Generic.IEnumerable<System.Linq.Expressions.Interpreter.InterpretedFrameInfo>.GetEnumerator() { }

	[DebuggerHidden]
	// RVA: 0x19E7314 Offset: 0x19E3314 VA: 0x19E7314 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class InterpretedFrame // TypeDefIndex: 5681
{
	// Fields
	[ThreadStatic]
	private static InterpretedFrame s_currentFrame; // 0x80000000
	internal readonly Interpreter Interpreter; // 0x10
	internal InterpretedFrame _parent; // 0x18
	private readonly int[] _continuations; // 0x20
	private int _continuationIndex; // 0x28
	private int _pendingContinuation; // 0x2C
	private object _pendingValue; // 0x30
	public readonly object[] Data; // 0x38
	public readonly IStrongBox[] Closure; // 0x40
	public int StackIndex; // 0x48
	public int InstructionIndex; // 0x4C

	// Properties
	public string Name { get; }
	public InterpretedFrame Parent { get; }

	// Methods

	// RVA: 0x19E640C Offset: 0x19E240C VA: 0x19E640C
	internal void .ctor(Interpreter interpreter, IStrongBox[] closure) { }

	// RVA: 0x19E6534 Offset: 0x19E2534 VA: 0x19E6534
	public DebugInfo GetDebugInfo(int instructionIndex) { }

	// RVA: 0x19E6684 Offset: 0x19E2684 VA: 0x19E6684
	public string get_Name() { }

	// RVA: 0x19DBF04 Offset: 0x19D7F04 VA: 0x19DBF04
	public void Push(object value) { }

	// RVA: 0x19DC400 Offset: 0x19D8400 VA: 0x19DC400
	public void Push(bool value) { }

	// RVA: 0x19DFAB0 Offset: 0x19DBAB0 VA: 0x19DFAB0
	public void Push(int value) { }

	// RVA: 0x19DBF74 Offset: 0x19D7F74 VA: 0x19DBF74
	public void Push(byte value) { }

	// RVA: 0x19E669C Offset: 0x19E269C VA: 0x19E669C
	public void Push(sbyte value) { }

	// RVA: 0x19DF9A8 Offset: 0x19DB9A8 VA: 0x19DF9A8
	public void Push(short value) { }

	// RVA: 0x19DC0D8 Offset: 0x19D80D8 VA: 0x19DC0D8
	public void Push(ushort value) { }

	// RVA: 0x19DBEC8 Offset: 0x19D7EC8 VA: 0x19DBEC8
	public object Pop() { }

	// RVA: 0x19E6734 Offset: 0x19E2734 VA: 0x19E6734
	internal void SetStackDepth(int depth) { }

	// RVA: 0x19E6754 Offset: 0x19E2754 VA: 0x19E6754
	public object Peek() { }

	// RVA: 0x19E678C Offset: 0x19E278C VA: 0x19E678C
	public void Dup() { }

	// RVA: 0x19E6820 Offset: 0x19E2820 VA: 0x19E6820
	public InterpretedFrame get_Parent() { }

	[IteratorStateMachine(typeof(InterpretedFrame.<GetStackTraceDebugInfo>d__29))]
	// RVA: 0x19E6828 Offset: 0x19E2828 VA: 0x19E6828
	public IEnumerable<InterpretedFrameInfo> GetStackTraceDebugInfo() { }

	// RVA: 0x19E68DC Offset: 0x19E28DC VA: 0x19E68DC
	internal void SaveTraceToException(Exception exception) { }

	// RVA: 0x19E6B20 Offset: 0x19E2B20 VA: 0x19E6B20
	internal InterpretedFrame Enter() { }

	// RVA: 0x19E6BA0 Offset: 0x19E2BA0 VA: 0x19E6BA0
	internal void Leave(InterpretedFrame prevFrame) { }

	// RVA: 0x19E6BF8 Offset: 0x19E2BF8 VA: 0x19E6BF8
	internal bool IsJumpHappened() { }

	// RVA: 0x19E6C08 Offset: 0x19E2C08 VA: 0x19E6C08
	public void RemoveContinuation() { }

	// RVA: 0x19E6C18 Offset: 0x19E2C18 VA: 0x19E6C18
	public void PushContinuation(int continuation) { }

	// RVA: 0x19E6C54 Offset: 0x19E2C54 VA: 0x19E6C54
	public int YieldToCurrentContinuation() { }

	// RVA: 0x19E6CD0 Offset: 0x19E2CD0 VA: 0x19E6CD0
	public int YieldToPendingContinuation() { }

	// RVA: 0x19E6E78 Offset: 0x19E2E78 VA: 0x19E6E78
	internal void PushPendingContinuation() { }

	// RVA: 0x19E6F00 Offset: 0x19E2F00 VA: 0x19E6F00
	internal void PopPendingContinuation() { }

	// RVA: 0x19E6F64 Offset: 0x19E2F64 VA: 0x19E6F64
	public int Goto(int labelIndex, object value, bool gotoExceptionHandler) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class Interpreter // TypeDefIndex: 5682
{
	// Fields
	internal static readonly object NoValue; // 0x0
	private readonly InstructionArray _instructions; // 0x10
	internal readonly object[] _objects; // 0x38
	internal readonly RuntimeLabel[] _labels; // 0x40
	internal readonly DebugInfo[] _debugInfos; // 0x48
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; // 0x50
	[CompilerGenerated]
	private readonly int <LocalCount>k__BackingField; // 0x58
	[CompilerGenerated]
	private readonly Dictionary<ParameterExpression, LocalVariable> <ClosureVariables>k__BackingField; // 0x60

	// Properties
	internal string Name { get; }
	internal int LocalCount { get; }
	internal int ClosureSize { get; }
	internal InstructionArray Instructions { get; }
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; }

	// Methods

	// RVA: 0x19E7318 Offset: 0x19E3318 VA: 0x19E7318
	internal void .ctor(string name, LocalVariables locals, InstructionArray instructions, DebugInfo[] debugInfos) { }

	[CompilerGenerated]
	// RVA: 0x19E73C8 Offset: 0x19E33C8 VA: 0x19E73C8
	internal string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x19E73D0 Offset: 0x19E33D0 VA: 0x19E73D0
	internal int get_LocalCount() { }

	// RVA: 0x19E73D8 Offset: 0x19E33D8 VA: 0x19E73D8
	internal int get_ClosureSize() { }

	// RVA: 0x19E7430 Offset: 0x19E3430 VA: 0x19E7430
	internal InstructionArray get_Instructions() { }

	[CompilerGenerated]
	// RVA: 0x19E7444 Offset: 0x19E3444 VA: 0x19E7444
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	// RVA: 0x19E744C Offset: 0x19E344C VA: 0x19E744C
	public void Run(InterpretedFrame frame) { }

	// RVA: 0x19E74C0 Offset: 0x19E34C0 VA: 0x19E74C0
	private static void .cctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LabelInfo.<>c // TypeDefIndex: 5683
{
	// Fields
	public static readonly LabelInfo.<>c <>9; // 0x0
	public static Func<LabelScopeInfo, LabelScopeInfo> <>9__9_0; // 0x8

	// Methods

	// RVA: 0x19E816C Offset: 0x19E416C VA: 0x19E816C
	private static void .cctor() { }

	// RVA: 0x19E81D4 Offset: 0x19E41D4 VA: 0x19E81D4
	public void .ctor() { }

	// RVA: 0x19E81DC Offset: 0x19E41DC VA: 0x19E81DC
	internal LabelScopeInfo <ValidateJump>b__9_0(LabelScopeInfo b) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LabelInfo // TypeDefIndex: 5684
{
	// Fields
	private readonly LabelTarget _node; // 0x10
	private BranchLabel _label; // 0x18
	private object _definitions; // 0x20
	private readonly List<LabelScopeInfo> _references; // 0x28
	private bool _acrossBlockJump; // 0x30

	// Properties
	private bool HasDefinitions { get; }
	private bool HasMultipleDefinitions { get; }

	// Methods

	// RVA: 0x19E753C Offset: 0x19E353C VA: 0x19E753C
	internal void .ctor(LabelTarget node) { }

	// RVA: 0x19E75D8 Offset: 0x19E35D8 VA: 0x19E75D8
	internal BranchLabel GetLabel(LightCompiler compiler) { }

	// RVA: 0x19E7630 Offset: 0x19E3630 VA: 0x19E7630
	internal void Reference(LabelScopeInfo block) { }

	// RVA: 0x19E798C Offset: 0x19E398C VA: 0x19E798C
	internal void Define(LabelScopeInfo block) { }

	// RVA: 0x19E7708 Offset: 0x19E3708 VA: 0x19E7708
	private void ValidateJump(LabelScopeInfo reference) { }

	// RVA: 0x19E80E0 Offset: 0x19E40E0 VA: 0x19E80E0
	internal void ValidateFinish() { }

	// RVA: 0x19E75F0 Offset: 0x19E35F0 VA: 0x19E75F0
	private void EnsureLabel(LightCompiler compiler) { }

	// RVA: 0x19E7E5C Offset: 0x19E3E5C VA: 0x19E7E5C
	private bool DefinedIn(LabelScopeInfo scope) { }

	// RVA: 0x19E76F8 Offset: 0x19E36F8 VA: 0x19E76F8
	private bool get_HasDefinitions() { }

	// RVA: 0x19E7F10 Offset: 0x19E3F10 VA: 0x19E7F10
	private LabelScopeInfo FirstDefinition() { }

	// RVA: 0x19E7BE8 Offset: 0x19E3BE8 VA: 0x19E7BE8
	private void AddDefinition(LabelScopeInfo scope) { }

	// RVA: 0x19E7DE0 Offset: 0x19E3DE0 VA: 0x19E7DE0
	private bool get_HasMultipleDefinitions() { }

	// RVA: -1 Offset: -1
	internal static T CommonNode<T>(T first, T second, Func<T, T> parent) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111C238 Offset: 0x1118238 VA: 0x111C238
	|-LabelInfo.CommonNode<object>
	*/
}

// Namespace: System.Linq.Expressions.Interpreter
internal enum LabelScopeKind // TypeDefIndex: 5685
{
	// Fields
	public int value__; // 0x0
	public const LabelScopeKind Statement = 0;
	public const LabelScopeKind Block = 1;
	public const LabelScopeKind Switch = 2;
	public const LabelScopeKind Lambda = 3;
	public const LabelScopeKind Try = 4;
	public const LabelScopeKind Catch = 5;
	public const LabelScopeKind Finally = 6;
	public const LabelScopeKind Filter = 7;
	public const LabelScopeKind Expression = 8;
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LabelScopeInfo // TypeDefIndex: 5686
{
	// Fields
	private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels; // 0x10
	internal readonly LabelScopeKind Kind; // 0x18
	internal readonly LabelScopeInfo Parent; // 0x20

	// Properties
	internal bool CanJumpInto { get; }

	// Methods

	// RVA: 0x19E81F0 Offset: 0x19E41F0 VA: 0x19E81F0
	internal void .ctor(LabelScopeInfo parent, LabelScopeKind kind) { }

	// RVA: 0x19E80D0 Offset: 0x19E40D0 VA: 0x19E80D0
	internal bool get_CanJumpInto() { }

	// RVA: 0x19E7B88 Offset: 0x19E3B88 VA: 0x19E7B88
	internal bool ContainsTarget(LabelTarget target) { }

	// RVA: 0x19E822C Offset: 0x19E422C VA: 0x19E822C
	internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info) { }

	// RVA: 0x19E7D24 Offset: 0x19E3D24 VA: 0x19E7D24
	internal void AddLabelInfo(LabelTarget target, LabelInfo info) { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftSByte : LeftShiftInstruction // TypeDefIndex: 5687
{
	// Methods

	// RVA: 0x19E834C Offset: 0x19E434C VA: 0x19E834C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19E830C Offset: 0x19E430C VA: 0x19E830C
	public void .ctor() { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftInt16 : LeftShiftInstruction // TypeDefIndex: 5688
{
	// Methods

	// RVA: 0x19E8400 Offset: 0x19E4400 VA: 0x19E8400 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19E8314 Offset: 0x19E4314 VA: 0x19E8314
	public void .ctor() { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftInt32 : LeftShiftInstruction // TypeDefIndex: 5689
{
	// Methods

	// RVA: 0x19E84B4 Offset: 0x19E44B4 VA: 0x19E84B4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19E831C Offset: 0x19E431C VA: 0x19E831C
	public void .ctor() { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftInt64 : LeftShiftInstruction // TypeDefIndex: 5690
{
	// Methods

	// RVA: 0x19E8568 Offset: 0x19E4568 VA: 0x19E8568 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19E8324 Offset: 0x19E4324 VA: 0x19E8324
	public void .ctor() { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftByte : LeftShiftInstruction // TypeDefIndex: 5691
{
	// Methods

	// RVA: 0x19E8634 Offset: 0x19E4634 VA: 0x19E8634 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19E832C Offset: 0x19E432C VA: 0x19E832C
	public void .ctor() { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftUInt16 : LeftShiftInstruction // TypeDefIndex: 5692
{
	// Methods

	// RVA: 0x19E86E8 Offset: 0x19E46E8 VA: 0x19E86E8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19E8334 Offset: 0x19E4334 VA: 0x19E8334
	public void .ctor() { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftUInt32 : LeftShiftInstruction // TypeDefIndex: 5693
{
	// Methods

	// RVA: 0x19E879C Offset: 0x19E479C VA: 0x19E879C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19E833C Offset: 0x19E433C VA: 0x19E833C
	public void .ctor() { }
}

// Namespace: 
private sealed class LeftShiftInstruction.LeftShiftUInt64 : LeftShiftInstruction // TypeDefIndex: 5694
{
	// Methods

	// RVA: 0x19E8868 Offset: 0x19E4868 VA: 0x19E8868 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19E8344 Offset: 0x19E4344 VA: 0x19E8344
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LeftShiftInstruction : Instruction // TypeDefIndex: 5695
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19E82B4 Offset: 0x19E42B4 VA: 0x19E82B4 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19E82BC Offset: 0x19E42BC VA: 0x19E82BC Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19E82C4 Offset: 0x19E42C4 VA: 0x19E82C4 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19E8304 Offset: 0x19E4304 VA: 0x19E8304
	private void .ctor() { }

	// RVA: 0x19E2F0C Offset: 0x19DEF0C VA: 0x19E2F0C
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanSByte : LessThanInstruction // TypeDefIndex: 5696
{
	// Methods

	// RVA: 0x19E89B4 Offset: 0x19E49B4 VA: 0x19E89B4
	public void .ctor(object nullValue) { }

	// RVA: 0x19E8BC4 Offset: 0x19E4BC4 VA: 0x19E8BC4 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanInt16 : LessThanInstruction // TypeDefIndex: 5697
{
	// Methods

	// RVA: 0x19E89E4 Offset: 0x19E49E4 VA: 0x19E89E4
	public void .ctor(object nullValue) { }

	// RVA: 0x19E8C80 Offset: 0x19E4C80 VA: 0x19E8C80 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanChar : LessThanInstruction // TypeDefIndex: 5698
{
	// Methods

	// RVA: 0x19E8A14 Offset: 0x19E4A14 VA: 0x19E8A14
	public void .ctor(object nullValue) { }

	// RVA: 0x19E8D3C Offset: 0x19E4D3C VA: 0x19E8D3C Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanInt32 : LessThanInstruction // TypeDefIndex: 5699
{
	// Methods

	// RVA: 0x19E8A44 Offset: 0x19E4A44 VA: 0x19E8A44
	public void .ctor(object nullValue) { }

	// RVA: 0x19E8DF8 Offset: 0x19E4DF8 VA: 0x19E8DF8 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanInt64 : LessThanInstruction // TypeDefIndex: 5700
{
	// Methods

	// RVA: 0x19E8A74 Offset: 0x19E4A74 VA: 0x19E8A74
	public void .ctor(object nullValue) { }

	// RVA: 0x19E8EB4 Offset: 0x19E4EB4 VA: 0x19E8EB4 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanByte : LessThanInstruction // TypeDefIndex: 5701
{
	// Methods

	// RVA: 0x19E8AA4 Offset: 0x19E4AA4 VA: 0x19E8AA4
	public void .ctor(object nullValue) { }

	// RVA: 0x19E8F70 Offset: 0x19E4F70 VA: 0x19E8F70 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanUInt16 : LessThanInstruction // TypeDefIndex: 5702
{
	// Methods

	// RVA: 0x19E8AD4 Offset: 0x19E4AD4 VA: 0x19E8AD4
	public void .ctor(object nullValue) { }

	// RVA: 0x19E902C Offset: 0x19E502C VA: 0x19E902C Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanUInt32 : LessThanInstruction // TypeDefIndex: 5703
{
	// Methods

	// RVA: 0x19E8B04 Offset: 0x19E4B04 VA: 0x19E8B04
	public void .ctor(object nullValue) { }

	// RVA: 0x19E90E8 Offset: 0x19E50E8 VA: 0x19E90E8 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanUInt64 : LessThanInstruction // TypeDefIndex: 5704
{
	// Methods

	// RVA: 0x19E8B34 Offset: 0x19E4B34 VA: 0x19E8B34
	public void .ctor(object nullValue) { }

	// RVA: 0x19E91A4 Offset: 0x19E51A4 VA: 0x19E91A4 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanSingle : LessThanInstruction // TypeDefIndex: 5705
{
	// Methods

	// RVA: 0x19E8B64 Offset: 0x19E4B64 VA: 0x19E8B64
	public void .ctor(object nullValue) { }

	// RVA: 0x19E9260 Offset: 0x19E5260 VA: 0x19E9260 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanInstruction.LessThanDouble : LessThanInstruction // TypeDefIndex: 5706
{
	// Methods

	// RVA: 0x19E8B94 Offset: 0x19E4B94 VA: 0x19E8B94
	public void .ctor(object nullValue) { }

	// RVA: 0x19E9324 Offset: 0x19E5324 VA: 0x19E9324 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LessThanInstruction : Instruction // TypeDefIndex: 5707
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19E8934 Offset: 0x19E4934 VA: 0x19E8934 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19E893C Offset: 0x19E493C VA: 0x19E893C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19E8944 Offset: 0x19E4944 VA: 0x19E8944 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19E8984 Offset: 0x19E4984 VA: 0x19E8984
	private void .ctor(object nullValue) { }

	// RVA: 0x19E3350 Offset: 0x19DF350 VA: 0x19E3350
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualSByte : LessThanOrEqualInstruction // TypeDefIndex: 5708
{
	// Methods

	// RVA: 0x19E9468 Offset: 0x19E5468 VA: 0x19E9468
	public void .ctor(object nullValue) { }

	// RVA: 0x19E9678 Offset: 0x19E5678 VA: 0x19E9678 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualInt16 : LessThanOrEqualInstruction // TypeDefIndex: 5709
{
	// Methods

	// RVA: 0x19E9498 Offset: 0x19E5498 VA: 0x19E9498
	public void .ctor(object nullValue) { }

	// RVA: 0x19E9734 Offset: 0x19E5734 VA: 0x19E9734 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualChar : LessThanOrEqualInstruction // TypeDefIndex: 5710
{
	// Methods

	// RVA: 0x19E94C8 Offset: 0x19E54C8 VA: 0x19E94C8
	public void .ctor(object nullValue) { }

	// RVA: 0x19E97F0 Offset: 0x19E57F0 VA: 0x19E97F0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualInt32 : LessThanOrEqualInstruction // TypeDefIndex: 5711
{
	// Methods

	// RVA: 0x19E94F8 Offset: 0x19E54F8 VA: 0x19E94F8
	public void .ctor(object nullValue) { }

	// RVA: 0x19E98AC Offset: 0x19E58AC VA: 0x19E98AC Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualInt64 : LessThanOrEqualInstruction // TypeDefIndex: 5712
{
	// Methods

	// RVA: 0x19E9528 Offset: 0x19E5528 VA: 0x19E9528
	public void .ctor(object nullValue) { }

	// RVA: 0x19E9968 Offset: 0x19E5968 VA: 0x19E9968 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualByte : LessThanOrEqualInstruction // TypeDefIndex: 5713
{
	// Methods

	// RVA: 0x19E9558 Offset: 0x19E5558 VA: 0x19E9558
	public void .ctor(object nullValue) { }

	// RVA: 0x19E9A24 Offset: 0x19E5A24 VA: 0x19E9A24 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualUInt16 : LessThanOrEqualInstruction // TypeDefIndex: 5714
{
	// Methods

	// RVA: 0x19E9588 Offset: 0x19E5588 VA: 0x19E9588
	public void .ctor(object nullValue) { }

	// RVA: 0x19E9AE0 Offset: 0x19E5AE0 VA: 0x19E9AE0 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualUInt32 : LessThanOrEqualInstruction // TypeDefIndex: 5715
{
	// Methods

	// RVA: 0x19E95B8 Offset: 0x19E55B8 VA: 0x19E95B8
	public void .ctor(object nullValue) { }

	// RVA: 0x19E9B9C Offset: 0x19E5B9C VA: 0x19E9B9C Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualUInt64 : LessThanOrEqualInstruction // TypeDefIndex: 5716
{
	// Methods

	// RVA: 0x19E95E8 Offset: 0x19E55E8 VA: 0x19E95E8
	public void .ctor(object nullValue) { }

	// RVA: 0x19E9C58 Offset: 0x19E5C58 VA: 0x19E9C58 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualSingle : LessThanOrEqualInstruction // TypeDefIndex: 5717
{
	// Methods

	// RVA: 0x19E9618 Offset: 0x19E5618 VA: 0x19E9618
	public void .ctor(object nullValue) { }

	// RVA: 0x19E9D14 Offset: 0x19E5D14 VA: 0x19E9D14 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class LessThanOrEqualInstruction.LessThanOrEqualDouble : LessThanOrEqualInstruction // TypeDefIndex: 5718
{
	// Methods

	// RVA: 0x19E9648 Offset: 0x19E5648 VA: 0x19E9648
	public void .ctor(object nullValue) { }

	// RVA: 0x19E9DD8 Offset: 0x19E5DD8 VA: 0x19E9DD8 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LessThanOrEqualInstruction : Instruction // TypeDefIndex: 5719
{
	// Fields
	private readonly object _nullValue; // 0x10
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Char; // 0x10
	private static Instruction s_Int32; // 0x18
	private static Instruction s_Int64; // 0x20
	private static Instruction s_Byte; // 0x28
	private static Instruction s_UInt16; // 0x30
	private static Instruction s_UInt32; // 0x38
	private static Instruction s_UInt64; // 0x40
	private static Instruction s_Single; // 0x48
	private static Instruction s_Double; // 0x50
	private static Instruction s_liftedToNullSByte; // 0x58
	private static Instruction s_liftedToNullInt16; // 0x60
	private static Instruction s_liftedToNullChar; // 0x68
	private static Instruction s_liftedToNullInt32; // 0x70
	private static Instruction s_liftedToNullInt64; // 0x78
	private static Instruction s_liftedToNullByte; // 0x80
	private static Instruction s_liftedToNullUInt16; // 0x88
	private static Instruction s_liftedToNullUInt32; // 0x90
	private static Instruction s_liftedToNullUInt64; // 0x98
	private static Instruction s_liftedToNullSingle; // 0xA0
	private static Instruction s_liftedToNullDouble; // 0xA8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19E93E8 Offset: 0x19E53E8 VA: 0x19E93E8 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19E93F0 Offset: 0x19E53F0 VA: 0x19E93F0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19E93F8 Offset: 0x19E53F8 VA: 0x19E93F8 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19E9438 Offset: 0x19E5438 VA: 0x19E9438
	private void .ctor(object nullValue) { }

	// RVA: 0x19E3EC4 Offset: 0x19DFEC4 VA: 0x19E3EC4
	public static Instruction Create(Type type, bool liftedToNull = False) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ExceptionFilter // TypeDefIndex: 5720
{
	// Fields
	public readonly int LabelIndex; // 0x10
	public readonly int StartIndex; // 0x14
	public readonly int EndIndex; // 0x18

	// Methods

	// RVA: 0x19E9E9C Offset: 0x19E5E9C VA: 0x19E9E9C
	internal void .ctor(int labelIndex, int start, int end) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ExceptionHandler // TypeDefIndex: 5721
{
	// Fields
	private readonly Type _exceptionType; // 0x10
	public readonly int LabelIndex; // 0x18
	public readonly int HandlerStartIndex; // 0x1C
	public readonly int HandlerEndIndex; // 0x20
	public readonly ExceptionFilter Filter; // 0x28

	// Methods

	// RVA: 0x19E9ED8 Offset: 0x19E5ED8 VA: 0x19E9ED8
	internal void .ctor(int labelIndex, int handlerStartIndex, int handlerEndIndex, Type exceptionType, ExceptionFilter filter) { }

	// RVA: 0x19E9F40 Offset: 0x19E5F40 VA: 0x19E9F40
	public bool Matches(Type exceptionType) { }

	// RVA: 0x19E9F60 Offset: 0x19E5F60 VA: 0x19E9F60 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TryCatchFinallyHandler // TypeDefIndex: 5722
{
	// Fields
	internal readonly int TryStartIndex; // 0x10
	internal readonly int TryEndIndex; // 0x14
	internal readonly int FinallyStartIndex; // 0x18
	internal readonly int FinallyEndIndex; // 0x1C
	internal readonly int GotoEndTargetIndex; // 0x20
	private readonly ExceptionHandler[] _handlers; // 0x28

	// Properties
	internal bool IsFinallyBlockExist { get; }
	internal ExceptionHandler[] Handlers { get; }
	internal bool IsCatchBlockExist { get; }

	// Methods

	// RVA: 0x19EA050 Offset: 0x19E6050 VA: 0x19EA050
	internal bool get_IsFinallyBlockExist() { }

	// RVA: 0x19EA064 Offset: 0x19E6064 VA: 0x19EA064
	internal ExceptionHandler[] get_Handlers() { }

	// RVA: 0x19EA06C Offset: 0x19E606C VA: 0x19EA06C
	internal bool get_IsCatchBlockExist() { }

	// RVA: 0x19EA07C Offset: 0x19E607C VA: 0x19EA07C
	internal void .ctor(int tryStart, int tryEnd, int gotoEndTargetIndex, ExceptionHandler[] handlers) { }

	// RVA: 0x19EA0D0 Offset: 0x19E60D0 VA: 0x19EA0D0
	internal void .ctor(int tryStart, int tryEnd, int gotoEndLabelIndex, int finallyStart, int finallyEnd, ExceptionHandler[] handlers) { }

	// RVA: 0x19EA130 Offset: 0x19E6130 VA: 0x19EA130
	internal bool HasHandler(InterpretedFrame frame, Exception exception, out ExceptionHandler handler, out object unwrappedException) { }

	// RVA: 0x19EA2A0 Offset: 0x19E62A0 VA: 0x19EA2A0
	private static bool FilterPasses(InterpretedFrame frame, ref object exception, ExceptionFilter filter) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TryFaultHandler // TypeDefIndex: 5723
{
	// Fields
	internal readonly int TryStartIndex; // 0x10
	internal readonly int TryEndIndex; // 0x14
	internal readonly int FinallyStartIndex; // 0x18
	internal readonly int FinallyEndIndex; // 0x1C

	// Methods

	// RVA: 0x19EA494 Offset: 0x19E6494 VA: 0x19EA494
	internal void .ctor(int tryStart, int tryEnd, int finallyStart, int finallyEnd) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class RethrowException : Exception // TypeDefIndex: 5724
{
	// Methods

	// RVA: 0x19EA4D4 Offset: 0x19E64D4 VA: 0x19EA4D4
	public void .ctor() { }
}

// Namespace: 
private class DebugInfo.DebugInfoComparer : IComparer<DebugInfo> // TypeDefIndex: 5725
{
	// Methods

	// RVA: 0x19EA810 Offset: 0x19E6810 VA: 0x19EA810 Slot: 4
	private int System.Collections.Generic.IComparer<System.Linq.Expressions.Interpreter.DebugInfo>.Compare(DebugInfo d1, DebugInfo d2) { }

	// RVA: 0x19EA808 Offset: 0x19E6808 VA: 0x19EA808
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class DebugInfo // TypeDefIndex: 5726
{
	// Fields
	public int StartLine; // 0x10
	public int EndLine; // 0x14
	public int Index; // 0x18
	public string FileName; // 0x20
	public bool IsClear; // 0x28
	private static readonly DebugInfo.DebugInfoComparer s_debugComparer; // 0x0

	// Methods

	// RVA: 0x19E65A0 Offset: 0x19E25A0 VA: 0x19E65A0
	public static DebugInfo GetMatchingDebugInfo(DebugInfo[] debugInfos, int index) { }

	// RVA: 0x19EA534 Offset: 0x19E6534 VA: 0x19EA534 Slot: 3
	public override string ToString() { }

	// RVA: 0x19EA52C Offset: 0x19E652C VA: 0x19EA52C
	public void .ctor() { }

	// RVA: 0x19EA78C Offset: 0x19E678C VA: 0x19EA78C
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
[IsReadOnly]
internal struct InterpretedFrameInfo // TypeDefIndex: 5727
{
	// Fields
	private readonly string _methodName; // 0x0
	private readonly DebugInfo _debugInfo; // 0x8

	// Methods

	// RVA: 0x19E71A0 Offset: 0x19E31A0 VA: 0x19E71A0
	public void .ctor(string methodName, DebugInfo info) { }

	// RVA: 0x19EA83C Offset: 0x19E683C VA: 0x19EA83C Slot: 3
	public override string ToString() { }
}

// Namespace: 
private sealed class LightCompiler.QuoteVisitor : ExpressionVisitor // TypeDefIndex: 5728
{
	// Fields
	private readonly Dictionary<ParameterExpression, int> _definedParameters; // 0x10
	public readonly HashSet<ParameterExpression> _hoistedParameters; // 0x18

	// Methods

	// RVA: 0x19F6E04 Offset: 0x19F2E04 VA: 0x19F6E04 Slot: 21
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: 0x19F6E90 Offset: 0x19F2E90 VA: 0x19F6E90 Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x19F7584 Offset: 0x19F3584 VA: 0x19F7584 Slot: 22
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x104CE70 Offset: 0x1048E70 VA: 0x104CE70
	|-LightCompiler.QuoteVisitor.VisitLambda<object>
	|
	|-RVA: 0x104D060 Offset: 0x1049060 VA: 0x104D060
	|-LightCompiler.QuoteVisitor.VisitLambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x19F6EF8 Offset: 0x19F2EF8 VA: 0x19F6EF8
	private void PushParameters(IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x19F723C Offset: 0x19F323C VA: 0x19F723C
	private void PopParameters(IEnumerable<ParameterExpression> parameters) { }

	// RVA: 0x19F76CC Offset: 0x19F36CC VA: 0x19F76CC
	public void .ctor() { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class LightCompiler.<>c // TypeDefIndex: 5729
{
	// Fields
	public static readonly LightCompiler.<>c <>9; // 0x0
	public static Func<Expression, bool> <>9__56_1; // 0x8
	public static Func<SwitchCase, bool> <>9__56_0; // 0x10
	public static Action<LightCompiler, Expression> <>9__101_0; // 0x18

	// Methods

	// RVA: 0x19F77A8 Offset: 0x19F37A8 VA: 0x19F77A8
	private static void .cctor() { }

	// RVA: 0x19F7810 Offset: 0x19F3810 VA: 0x19F7810
	public void .ctor() { }

	// RVA: 0x19F7818 Offset: 0x19F3818 VA: 0x19F7818
	internal bool <CompileSwitchExpression>b__56_0(SwitchCase c) { }

	// RVA: 0x19F791C Offset: 0x19F391C VA: 0x19F791C
	internal bool <CompileSwitchExpression>b__56_1(Expression t) { }

	// RVA: 0x19F7994 Offset: 0x19F3994 VA: 0x19F7994
	internal void <CompileNoLabelPush>b__101_0(LightCompiler this, Expression e) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LightCompiler // TypeDefIndex: 5730
{
	// Fields
	private readonly InstructionList _instructions; // 0x10
	private readonly LocalVariables _locals; // 0x18
	private readonly List<DebugInfo> _debugInfos; // 0x20
	private readonly HybridReferenceDictionary<LabelTarget, LabelInfo> _treeLabels; // 0x28
	private LabelScopeInfo _labelBlock; // 0x30
	private readonly Stack<ParameterExpression> _exceptionForRethrowStack; // 0x38
	private readonly LightCompiler _parent; // 0x40
	private readonly StackGuard _guard; // 0x48
	private static readonly LocalDefinition[] s_emptyLocals; // 0x0

	// Properties
	public InstructionList Instructions { get; }

	// Methods

	// RVA: 0x19EA8B4 Offset: 0x19E68B4 VA: 0x19EA8B4
	public void .ctor() { }

	// RVA: 0x19EAAE0 Offset: 0x19E6AE0 VA: 0x19EAAE0
	private void .ctor(LightCompiler parent) { }

	// RVA: 0x19EAB0C Offset: 0x19E6B0C VA: 0x19EAB0C
	public InstructionList get_Instructions() { }

	// RVA: 0x19EAB14 Offset: 0x19E6B14 VA: 0x19EAB14
	public LightDelegateCreator CompileTop(LambdaExpression node) { }

	// RVA: 0x19EAD34 Offset: 0x19E6D34 VA: 0x19EAD34
	private Interpreter MakeInterpreter(string lambdaName) { }

	// RVA: 0x19EB038 Offset: 0x19E7038 VA: 0x19EB038
	private void CompileConstantExpression(Expression expr) { }

	// RVA: 0x19EB0DC Offset: 0x19E70DC VA: 0x19EB0DC
	private void CompileDefaultExpression(Expression expr) { }

	// RVA: 0x19EB110 Offset: 0x19E7110 VA: 0x19EB110
	private void CompileDefaultExpression(Type type) { }

	// RVA: 0x19EB204 Offset: 0x19E7204 VA: 0x19EB204
	private LocalVariable EnsureAvailableForClosure(ParameterExpression expr) { }

	// RVA: 0x19EB324 Offset: 0x19E7324 VA: 0x19EB324
	private LocalVariable ResolveLocal(ParameterExpression variable) { }

	// RVA: 0x19EB378 Offset: 0x19E7378 VA: 0x19EB378
	private void CompileGetVariable(ParameterExpression variable) { }

	// RVA: 0x19EB438 Offset: 0x19E7438 VA: 0x19EB438
	private void EmitCopyValueType(Type valueType) { }

	// RVA: 0x19EB3B8 Offset: 0x19E73B8 VA: 0x19EB3B8
	private void LoadLocalNoValueTypeCopy(ParameterExpression variable) { }

	// RVA: 0x19EB4C0 Offset: 0x19E74C0 VA: 0x19EB4C0
	private bool MaybeMutableValueType(Type type) { }

	// RVA: 0x19EB51C Offset: 0x19E751C VA: 0x19EB51C
	private void CompileGetBoxedVariable(ParameterExpression variable) { }

	// RVA: 0x19EB574 Offset: 0x19E7574 VA: 0x19EB574
	private void CompileSetVariable(ParameterExpression variable, bool isVoid) { }

	// RVA: 0x19EB650 Offset: 0x19E7650 VA: 0x19EB650
	private void CompileParameterExpression(Expression expr) { }

	// RVA: 0x19EB6D4 Offset: 0x19E76D4 VA: 0x19EB6D4
	private void CompileBlockExpression(Expression expr, bool asVoid) { }

	// RVA: 0x19EB814 Offset: 0x19E7814 VA: 0x19EB814
	private LocalDefinition[] CompileBlockStart(BlockExpression node) { }

	// RVA: 0x19EBC78 Offset: 0x19E7C78 VA: 0x19EBC78
	private void CompileBlockEnd(LocalDefinition[] locals) { }

	// RVA: 0x19EBE68 Offset: 0x19E7E68 VA: 0x19EBE68
	private void CompileIndexExpression(Expression expr) { }

	// RVA: 0x19EBF3C Offset: 0x19E7F3C VA: 0x19EBF3C
	private void EmitIndexGet(IndexExpression index) { }

	// RVA: 0x19EC02C Offset: 0x19E802C VA: 0x19EC02C
	private void CompileIndexAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x19EC2C8 Offset: 0x19E82C8 VA: 0x19EC2C8
	private void CompileMemberAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x19EC390 Offset: 0x19E8390 VA: 0x19EC390
	private void CompileMemberAssignment(bool asVoid, MemberInfo refMember, Expression value, bool forBinding) { }

	// RVA: 0x19EC718 Offset: 0x19E8718 VA: 0x19EC718
	private void CompileVariableAssignment(BinaryExpression node, bool asVoid) { }

	// RVA: 0x19EC7C4 Offset: 0x19E87C4 VA: 0x19EC7C4
	private void CompileAssignBinaryExpression(Expression expr, bool asVoid) { }

	// RVA: 0x19EC910 Offset: 0x19E8910 VA: 0x19EC910
	private void CompileBinaryExpression(Expression expr) { }

	// RVA: 0x19ED7B0 Offset: 0x19E97B0 VA: 0x19ED7B0
	private void CompileEqual(Expression left, Expression right, bool liftedToNull) { }

	// RVA: 0x19ED820 Offset: 0x19E9820 VA: 0x19ED820
	private void CompileNotEqual(Expression left, Expression right, bool liftedToNull) { }

	// RVA: 0x19ED890 Offset: 0x19E9890 VA: 0x19ED890
	private void CompileComparison(BinaryExpression node) { }

	// RVA: 0x19ED5B8 Offset: 0x19E95B8 VA: 0x19ED5B8
	private void CompileArithmetic(ExpressionType nodeType, Expression left, Expression right) { }

	// RVA: 0x19EDA24 Offset: 0x19E9A24 VA: 0x19EDA24
	private void CompileConvertUnaryExpression(Expression expr) { }

	// RVA: 0x19EE9C4 Offset: 0x19EA9C4 VA: 0x19EE9C4
	private void CompileConvertToType(Type typeFrom, Type typeTo, bool isChecked, bool isLiftedToNull) { }

	// RVA: 0x19EEEFC Offset: 0x19EAEFC VA: 0x19EEEFC
	private void CompileNotExpression(UnaryExpression node) { }

	// RVA: 0x19EEF54 Offset: 0x19EAF54 VA: 0x19EEF54
	private void CompileUnaryExpression(Expression expr) { }

	// RVA: 0x19EF22C Offset: 0x19EB22C VA: 0x19EF22C
	private void EmitUnaryMethodCall(UnaryExpression node) { }

	// RVA: 0x19EF35C Offset: 0x19EB35C VA: 0x19EF35C
	private void EmitUnaryBoolCheck(UnaryExpression node) { }

	// RVA: 0x19EF500 Offset: 0x19EB500 VA: 0x19EF500
	private void CompileAndAlsoBinaryExpression(Expression expr) { }

	// RVA: 0x19EF6DC Offset: 0x19EB6DC VA: 0x19EF6DC
	private void CompileOrElseBinaryExpression(Expression expr) { }

	// RVA: 0x19EF588 Offset: 0x19EB588 VA: 0x19EF588
	private void CompileLogicalBinaryExpression(BinaryExpression b, bool andAlso) { }

	// RVA: 0x19EF764 Offset: 0x19EB764 VA: 0x19EF764
	private void CompileMethodLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	// RVA: 0x19EF8C8 Offset: 0x19EB8C8 VA: 0x19EF8C8
	private void CompileLiftedLogicalBinaryExpression(BinaryExpression node, bool andAlso) { }

	// RVA: 0x19EFFB0 Offset: 0x19EBFB0 VA: 0x19EFFB0
	private void CompileUnliftedLogicalBinaryExpression(BinaryExpression expr, bool andAlso) { }

	// RVA: 0x19F0098 Offset: 0x19EC098 VA: 0x19F0098
	private void CompileConditionalExpression(Expression expr, bool asVoid) { }

	// RVA: 0x19F02CC Offset: 0x19EC2CC VA: 0x19F02CC
	private void CompileLoopExpression(Expression expr) { }

	// RVA: 0x19F0580 Offset: 0x19EC580 VA: 0x19F0580
	private void CompileSwitchExpression(Expression expr) { }

	// RVA: -1 Offset: -1
	private void CompileIntSwitchExpression<T>(SwitchExpression node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111E19C Offset: 0x111A19C VA: 0x111E19C
	|-LightCompiler.CompileIntSwitchExpression<int>
	|
	|-RVA: 0x111E770 Offset: 0x111A770 VA: 0x111E770
	|-LightCompiler.CompileIntSwitchExpression<object>
	|
	|-RVA: 0x111ED4C Offset: 0x111AD4C VA: 0x111ED4C
	|-LightCompiler.CompileIntSwitchExpression<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x19F0EE0 Offset: 0x19ECEE0 VA: 0x19F0EE0
	private void CompileStringSwitchExpression(SwitchExpression node) { }

	// RVA: 0x19F1508 Offset: 0x19ED508 VA: 0x19F1508
	private void CompileLabelExpression(Expression expr) { }

	// RVA: 0x19F1688 Offset: 0x19ED688 VA: 0x19F1688
	private void CompileGotoExpression(Expression expr) { }

	// RVA: 0x19F045C Offset: 0x19EC45C VA: 0x19F045C
	private void PushLabelBlock(LabelScopeKind type) { }

	// RVA: 0x19F0564 Offset: 0x19EC564 VA: 0x19F0564
	private void PopLabelBlock(LabelScopeKind kind) { }

	// RVA: 0x19F186C Offset: 0x19ED86C VA: 0x19F186C
	private LabelInfo EnsureLabel(LabelTarget node) { }

	// RVA: 0x19F1838 Offset: 0x19ED838 VA: 0x19F1838
	private LabelInfo ReferenceLabel(LabelTarget node) { }

	// RVA: 0x19F04E0 Offset: 0x19EC4E0 VA: 0x19F04E0
	private LabelInfo DefineLabel(LabelTarget node) { }

	// RVA: 0x19F193C Offset: 0x19ED93C VA: 0x19F193C
	private bool TryPushLabelBlock(Expression node) { }

	// RVA: 0x19F1D74 Offset: 0x19EDD74 VA: 0x19F1D74
	private void DefineBlockLabels(Expression node) { }

	// RVA: 0x19F1EA8 Offset: 0x19EDEA8 VA: 0x19F1EA8
	private void CheckRethrow() { }

	// RVA: 0x19F1EFC Offset: 0x19EDEFC VA: 0x19F1EFC
	private void CompileThrowUnaryExpression(Expression expr, bool asVoid) { }

	// RVA: 0x19F2004 Offset: 0x19EE004 VA: 0x19F2004
	private void CompileTryExpression(Expression expr) { }

	// RVA: 0x19F2ABC Offset: 0x19EEABC VA: 0x19F2ABC
	private void CompileTryFaultExpression(TryExpression expr) { }

	// RVA: 0x19F2CD0 Offset: 0x19EECD0 VA: 0x19F2CD0
	private void CompileMethodCallExpression(Expression expr) { }

	// RVA: 0x19F2D6C Offset: 0x19EED6C VA: 0x19F2D6C
	private void CompileMethodCallExpression(Expression object, MethodInfo method, IArgumentProvider arguments) { }

	// RVA: 0x19F32DC Offset: 0x19EF2DC VA: 0x19F32DC
	private ByRefUpdater CompileArrayIndexAddress(Expression array, Expression index, int argumentIndex) { }

	// RVA: 0x19EBF34 Offset: 0x19E7F34 VA: 0x19EBF34
	private void EmitThisForMethodCall(Expression node) { }

	// RVA: 0x19F34DC Offset: 0x19EF4DC VA: 0x19F34DC
	private static bool ShouldWritebackNode(Expression node) { }

	// RVA: 0x19EE040 Offset: 0x19EA040 VA: 0x19EE040
	private ByRefUpdater CompileAddress(Expression node, int index) { }

	// RVA: 0x19F3660 Offset: 0x19EF660 VA: 0x19F3660
	private ByRefUpdater CompileMultiDimArrayAccess(Expression array, IArgumentProvider arguments, int index) { }

	// RVA: 0x19F3A68 Offset: 0x19EFA68 VA: 0x19F3A68
	private void CompileNewExpression(Expression expr) { }

	// RVA: 0x19F3E14 Offset: 0x19EFE14 VA: 0x19F3E14
	private void CompileMemberExpression(Expression expr) { }

	// RVA: 0x19F3EB4 Offset: 0x19EFEB4 VA: 0x19F3EB4
	private void CompileMember(Expression from, MemberInfo member, bool forBinding) { }

	// RVA: 0x19F423C Offset: 0x19F023C VA: 0x19F423C
	private void CompileNewArrayExpression(Expression expr) { }

	// RVA: 0x19F4594 Offset: 0x19F0594 VA: 0x19F4594
	private void CompileDebugInfoExpression(Expression expr) { }

	// RVA: 0x19F473C Offset: 0x19F073C VA: 0x19F473C
	private void CompileRuntimeVariablesExpression(Expression expr) { }

	// RVA: 0x19F4A14 Offset: 0x19F0A14 VA: 0x19F4A14
	private void CompileLambdaExpression(Expression expr) { }

	// RVA: 0x19F4C20 Offset: 0x19F0C20 VA: 0x19F4C20
	private void CompileCoalesceBinaryExpression(Expression expr) { }

	// RVA: 0x19F51D8 Offset: 0x19F11D8 VA: 0x19F51D8
	private void CompileInvocationExpression(Expression expr) { }

	// RVA: 0x19F5440 Offset: 0x19F1440 VA: 0x19F5440
	private void CompileListInitExpression(Expression expr) { }

	// RVA: 0x19F54BC Offset: 0x19F14BC VA: 0x19F54BC
	private void CompileListInit(ReadOnlyCollection<ElementInit> initializers) { }

	// RVA: 0x19F584C Offset: 0x19F184C VA: 0x19F584C
	private void CompileMemberInitExpression(Expression expr) { }

	// RVA: 0x19F58C8 Offset: 0x19F18C8 VA: 0x19F58C8
	private void CompileMemberInit(ReadOnlyCollection<MemberBinding> bindings) { }

	// RVA: 0x19F5D90 Offset: 0x19F1D90 VA: 0x19F5D90
	private static Type GetMemberType(MemberInfo member) { }

	// RVA: 0x19F5F18 Offset: 0x19F1F18 VA: 0x19F5F18
	private void CompileQuoteUnaryExpression(Expression expr) { }

	// RVA: 0x19F61C0 Offset: 0x19F21C0 VA: 0x19F61C0
	private void CompileUnboxUnaryExpression(Expression expr) { }

	// RVA: 0x19F62E4 Offset: 0x19F22E4 VA: 0x19F62E4
	private void CompileTypeEqualExpression(Expression expr) { }

	// RVA: 0x19EF310 Offset: 0x19EB310 VA: 0x19EF310
	private void CompileTypeAsExpression(UnaryExpression node) { }

	// RVA: 0x19F6494 Offset: 0x19F2494 VA: 0x19F6494
	private void CompileTypeIsExpression(Expression expr) { }

	// RVA: 0x19EBC6C Offset: 0x19E7C6C VA: 0x19EBC6C
	private void Compile(Expression expr, bool asVoid) { }

	// RVA: 0x19EBD14 Offset: 0x19E7D14 VA: 0x19EBD14
	private void CompileAsVoid(Expression expr) { }

	// RVA: 0x19F66A8 Offset: 0x19F26A8 VA: 0x19F66A8
	private void CompileNoLabelPush(Expression expr) { }

	// RVA: 0x19EACE4 Offset: 0x19E6CE4 VA: 0x19EACE4
	private void Compile(Expression expr) { }

	// RVA: 0x19F6D48 Offset: 0x19F2D48 VA: 0x19F6D48
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class ByRefUpdater // TypeDefIndex: 5731
{
	// Fields
	public readonly int ArgumentIndex; // 0x10

	// Methods

	// RVA: 0x19F79B0 Offset: 0x19F39B0 VA: 0x19F79B0
	public void .ctor(int argumentIndex) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Update(InterpretedFrame frame, object value);

	// RVA: 0x19F79D8 Offset: 0x19F39D8 VA: 0x19F79D8 Slot: 5
	public virtual void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ParameterByRefUpdater : ByRefUpdater // TypeDefIndex: 5732
{
	// Fields
	private readonly LocalVariable _parameter; // 0x18

	// Methods

	// RVA: 0x19F79DC Offset: 0x19F39DC VA: 0x19F79DC
	public void .ctor(LocalVariable parameter, int argumentIndex) { }

	// RVA: 0x19F7A14 Offset: 0x19F3A14 VA: 0x19F7A14 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ArrayByRefUpdater : ByRefUpdater // TypeDefIndex: 5733
{
	// Fields
	private readonly LocalDefinition _array; // 0x18
	private readonly LocalDefinition _index; // 0x28

	// Methods

	// RVA: 0x19F7C24 Offset: 0x19F3C24 VA: 0x19F7C24
	public void .ctor(LocalDefinition array, LocalDefinition index, int argumentIndex) { }

	// RVA: 0x19F7C90 Offset: 0x19F3C90 VA: 0x19F7C90 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x19F7D58 Offset: 0x19F3D58 VA: 0x19F7D58 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class FieldByRefUpdater : ByRefUpdater // TypeDefIndex: 5734
{
	// Fields
	private readonly Nullable<LocalDefinition> _object; // 0x18
	private readonly FieldInfo _field; // 0x30

	// Methods

	// RVA: 0x19F7EA8 Offset: 0x19F3EA8 VA: 0x19F7EA8
	public void .ctor(Nullable<LocalDefinition> obj, FieldInfo field, int argumentIndex) { }

	// RVA: 0x19F7F08 Offset: 0x19F3F08 VA: 0x19F7F08 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x19F7FA8 Offset: 0x19F3FA8 VA: 0x19F7FA8 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class PropertyByRefUpdater : ByRefUpdater // TypeDefIndex: 5735
{
	// Fields
	private readonly Nullable<LocalDefinition> _object; // 0x18
	private readonly PropertyInfo _property; // 0x30

	// Methods

	// RVA: 0x19F8040 Offset: 0x19F4040 VA: 0x19F8040
	public void .ctor(Nullable<LocalDefinition> obj, PropertyInfo property, int argumentIndex) { }

	// RVA: 0x19F80A0 Offset: 0x19F40A0 VA: 0x19F80A0 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x19F81FC Offset: 0x19F41FC VA: 0x19F81FC Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class IndexMethodByRefUpdater : ByRefUpdater // TypeDefIndex: 5736
{
	// Fields
	private readonly MethodInfo _indexer; // 0x18
	private readonly Nullable<LocalDefinition> _obj; // 0x20
	private readonly LocalDefinition[] _args; // 0x38

	// Methods

	// RVA: 0x19F8294 Offset: 0x19F4294 VA: 0x19F8294
	public void .ctor(Nullable<LocalDefinition> obj, LocalDefinition[] args, MethodInfo indexer, int argumentIndex) { }

	// RVA: 0x19F8308 Offset: 0x19F4308 VA: 0x19F8308 Slot: 4
	public override void Update(InterpretedFrame frame, object value) { }

	// RVA: 0x19F8584 Offset: 0x19F4584 VA: 0x19F8584 Slot: 5
	public override void UndefineTemps(InstructionList instructions, LocalVariables locals) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LightDelegateCreator // TypeDefIndex: 5737
{
	// Fields
	private readonly LambdaExpression _lambda; // 0x10
	[CompilerGenerated]
	private readonly Interpreter <Interpreter>k__BackingField; // 0x18

	// Properties
	internal Interpreter Interpreter { get; }

	// Methods

	// RVA: 0x19F8680 Offset: 0x19F4680 VA: 0x19F8680
	internal void .ctor(Interpreter interpreter, LambdaExpression lambda) { }

	[CompilerGenerated]
	// RVA: 0x19F86C4 Offset: 0x19F46C4 VA: 0x19F86C4
	internal Interpreter get_Interpreter() { }

	// RVA: 0x19F86CC Offset: 0x19F46CC VA: 0x19F86CC
	public Delegate CreateDelegate() { }

	// RVA: 0x19F86D4 Offset: 0x19F46D4 VA: 0x19F86D4
	internal Delegate CreateDelegate(IStrongBox[] closure) { }
}

// Namespace: 
private class LightLambda.DebugViewPrinter // TypeDefIndex: 5738
{
	// Fields
	private readonly Interpreter _interpreter; // 0x10
	private readonly Dictionary<int, int> _tryStart; // 0x18
	private readonly Dictionary<int, string> _handlerEnter; // 0x20
	private readonly Dictionary<int, int> _handlerExit; // 0x28
	private string _indent; // 0x30

	// Methods

	// RVA: 0x19F8A64 Offset: 0x19F4A64 VA: 0x19F8A64
	public void .ctor(Interpreter interpreter) { }

	// RVA: 0x19FA850 Offset: 0x19F6850 VA: 0x19FA850
	private void Analyze() { }

	// RVA: 0x19FAADC Offset: 0x19F6ADC VA: 0x19FAADC
	private void AddTryStart(int index) { }

	// RVA: 0x19FABAC Offset: 0x19F6BAC VA: 0x19FABAC
	private void AddHandlerExit(int index) { }

	// RVA: 0x19FAC50 Offset: 0x19F6C50 VA: 0x19FAC50
	private void Indent() { }

	// RVA: 0x19FAC90 Offset: 0x19F6C90 VA: 0x19FAC90
	private void Dedent() { }

	// RVA: 0x19FACD0 Offset: 0x19F6CD0 VA: 0x19FACD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x19FB1AC Offset: 0x19F71AC VA: 0x19FB1AC
	private void EmitExits(StringBuilder sb, int index) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class LightLambda.<>c__DisplayClass74_0 // TypeDefIndex: 5739
{
	// Fields
	public MethodInfo targetMethod; // 0x10
	public Type delegateType; // 0x18

	// Methods

	// RVA: 0x19F95B8 Offset: 0x19F55B8 VA: 0x19F95B8
	public void .ctor() { }

	// RVA: 0x19FB280 Offset: 0x19F7280 VA: 0x19FB280
	internal Delegate <MakeRunDelegateCtor>b__0(LightLambda lambda) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class LightLambda // TypeDefIndex: 5740
{
	// Fields
	private readonly IStrongBox[] _closure; // 0x10
	private readonly Interpreter _interpreter; // 0x18
	private static readonly CacheDict<Type, Func<LightLambda, Delegate>> _runCache; // 0x0
	private readonly LightDelegateCreator _delegateCreator; // 0x20

	// Properties
	internal string DebugView { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal TRet Run0<TRet>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11200E0 Offset: 0x111C0E0 VA: 0x11200E0
	|-LightLambda.Run0<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x19F8840 Offset: 0x19F4840 VA: 0x19F8840
	internal void RunVoid0() { }

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun0<TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F448 Offset: 0x111B448 VA: 0x111F448
	|-LightLambda.MakeRun0<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x19F897C Offset: 0x19F497C VA: 0x19F897C
	internal static Delegate MakeRunVoid0(LightLambda lambda) { }

	// RVA: -1 Offset: -1
	internal TRet Run1<T0, TRet>(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11202C4 Offset: 0x111C2C4 VA: 0x11202C4
	|-LightLambda.Run1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid1<T0>(T0 arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1126FD0 Offset: 0x1122FD0 VA: 0x1126FD0
	|-LightLambda.RunVoid1<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun1<T0, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F4B0 Offset: 0x111B4B0 VA: 0x111F4B0
	|-LightLambda.MakeRun1<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid1<T0>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111FAC8 Offset: 0x111BAC8 VA: 0x111FAC8
	|-LightLambda.MakeRunVoid1<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run2<T0, T1, TRet>(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112437C Offset: 0x112037C VA: 0x112437C
	|-LightLambda.Run2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid2<T0, T1>(T0 arg0, T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112AD38 Offset: 0x1126D38 VA: 0x112AD38
	|-LightLambda.RunVoid2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun2<T0, T1, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F788 Offset: 0x111B788 VA: 0x111F788
	|-LightLambda.MakeRun2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid2<T0, T1>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111FDA0 Offset: 0x111BDA0 VA: 0x111FDA0
	|-LightLambda.MakeRunVoid2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run3<T0, T1, T2, TRet>(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11246E8 Offset: 0x11206E8 VA: 0x11246E8
	|-LightLambda.Run3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid3<T0, T1, T2>(T0 arg0, T1 arg1, T2 arg2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112B02C Offset: 0x112702C VA: 0x112B02C
	|-LightLambda.RunVoid3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun3<T0, T1, T2, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F7F0 Offset: 0x111B7F0 VA: 0x111F7F0
	|-LightLambda.MakeRun3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid3<T0, T1, T2>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111FE08 Offset: 0x111BE08 VA: 0x111FE08
	|-LightLambda.MakeRunVoid3<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run4<T0, T1, T2, T3, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1124AEC Offset: 0x1120AEC VA: 0x1124AEC
	|-LightLambda.Run4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid4<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112B3B4 Offset: 0x11273B4 VA: 0x112B3B4
	|-LightLambda.RunVoid4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun4<T0, T1, T2, T3, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F858 Offset: 0x111B858 VA: 0x111F858
	|-LightLambda.MakeRun4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid4<T0, T1, T2, T3>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111FE70 Offset: 0x111BE70 VA: 0x111FE70
	|-LightLambda.MakeRunVoid4<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run5<T0, T1, T2, T3, T4, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1124F84 Offset: 0x1120F84 VA: 0x1124F84
	|-LightLambda.Run5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid5<T0, T1, T2, T3, T4>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112B7D4 Offset: 0x11277D4 VA: 0x112B7D4
	|-LightLambda.RunVoid5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun5<T0, T1, T2, T3, T4, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F8C0 Offset: 0x111B8C0 VA: 0x111F8C0
	|-LightLambda.MakeRun5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid5<T0, T1, T2, T3, T4>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111FED8 Offset: 0x111BED8 VA: 0x111FED8
	|-LightLambda.MakeRunVoid5<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run6<T0, T1, T2, T3, T4, T5, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11254B0 Offset: 0x11214B0 VA: 0x11254B0
	|-LightLambda.Run6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid6<T0, T1, T2, T3, T4, T5>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112BC90 Offset: 0x1127C90 VA: 0x112BC90
	|-LightLambda.RunVoid6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun6<T0, T1, T2, T3, T4, T5, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F928 Offset: 0x111B928 VA: 0x111F928
	|-LightLambda.MakeRun6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid6<T0, T1, T2, T3, T4, T5>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111FF40 Offset: 0x111BF40 VA: 0x111FF40
	|-LightLambda.MakeRunVoid6<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run7<T0, T1, T2, T3, T4, T5, T6, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1125A70 Offset: 0x1121A70 VA: 0x1125A70
	|-LightLambda.Run7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid7<T0, T1, T2, T3, T4, T5, T6>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112C1E0 Offset: 0x11281E0 VA: 0x112C1E0
	|-LightLambda.RunVoid7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun7<T0, T1, T2, T3, T4, T5, T6, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F990 Offset: 0x111B990 VA: 0x111F990
	|-LightLambda.MakeRun7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid7<T0, T1, T2, T3, T4, T5, T6>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111FFA8 Offset: 0x111BFA8 VA: 0x111FFA8
	|-LightLambda.MakeRunVoid7<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11260D8 Offset: 0x11220D8 VA: 0x11260D8
	|-LightLambda.Run8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112C7CC Offset: 0x11287CC VA: 0x112C7CC
	|-LightLambda.RunVoid8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun8<T0, T1, T2, T3, T4, T5, T6, T7, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F9F8 Offset: 0x111B9F8 VA: 0x111F9F8
	|-LightLambda.MakeRun8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid8<T0, T1, T2, T3, T4, T5, T6, T7>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1120010 Offset: 0x111C010 VA: 0x1120010
	|-LightLambda.MakeRunVoid8<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11267F8 Offset: 0x11227F8 VA: 0x11267F8
	|-LightLambda.Run9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112CE64 Offset: 0x1128E64 VA: 0x112CE64
	|-LightLambda.RunVoid9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun9<T0, T1, T2, T3, T4, T5, T6, T7, T8, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111FA60 Offset: 0x111BA60 VA: 0x111FA60
	|-LightLambda.MakeRun9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid9<T0, T1, T2, T3, T4, T5, T6, T7, T8>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1120078 Offset: 0x111C078 VA: 0x1120078
	|-LightLambda.MakeRunVoid9<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112058C Offset: 0x111C58C VA: 0x112058C
	|-LightLambda.Run10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1127208 Offset: 0x1123208 VA: 0x1127208
	|-LightLambda.RunVoid10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F518 Offset: 0x111B518 VA: 0x111F518
	|-LightLambda.MakeRun10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid10<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111FB30 Offset: 0x111BB30 VA: 0x111FB30
	|-LightLambda.MakeRunVoid10<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1120E20 Offset: 0x111CE20 VA: 0x1120E20
	|-LightLambda.Run11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1127A14 Offset: 0x1123A14 VA: 0x1127A14
	|-LightLambda.RunVoid11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F580 Offset: 0x111B580 VA: 0x111F580
	|-LightLambda.MakeRun11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid11<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111FB98 Offset: 0x111BB98 VA: 0x111FB98
	|-LightLambda.MakeRunVoid11<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112176C Offset: 0x111D76C VA: 0x112176C
	|-LightLambda.Run12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11282DC Offset: 0x11242DC VA: 0x11282DC
	|-LightLambda.RunVoid12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F5E8 Offset: 0x111B5E8 VA: 0x111F5E8
	|-LightLambda.MakeRun12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid12<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111FC00 Offset: 0x111BC00 VA: 0x111FC00
	|-LightLambda.MakeRunVoid12<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1122174 Offset: 0x111E174 VA: 0x1122174
	|-LightLambda.Run13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1128C5C Offset: 0x1124C5C VA: 0x1128C5C
	|-LightLambda.RunVoid13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F650 Offset: 0x111B650 VA: 0x111F650
	|-LightLambda.MakeRun13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid13<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111FC68 Offset: 0x111BC68 VA: 0x111FC68
	|-LightLambda.MakeRunVoid13<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1122C34 Offset: 0x111EC34 VA: 0x1122C34
	|-LightLambda.Run14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1129698 Offset: 0x1125698 VA: 0x1129698
	|-LightLambda.RunVoid14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F6B8 Offset: 0x111B6B8 VA: 0x111F6B8
	|-LightLambda.MakeRun14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid14<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111FCD0 Offset: 0x111BCD0 VA: 0x111FCD0
	|-LightLambda.MakeRunVoid14<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal TRet Run15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11237AC Offset: 0x111F7AC VA: 0x11237AC
	|-LightLambda.Run15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal void RunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112A18C Offset: 0x112618C VA: 0x112A18C
	|-LightLambda.RunVoid15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRun15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TRet>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111F720 Offset: 0x111B720 VA: 0x111F720
	|-LightLambda.MakeRun15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	internal static Delegate MakeRunVoid15<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(LightLambda lambda) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x111FD38 Offset: 0x111BD38 VA: 0x111FD38
	|-LightLambda.MakeRunVoid15<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x19F875C Offset: 0x19F475C VA: 0x19F875C
	internal void .ctor(LightDelegateCreator delegateCreator, IStrongBox[] closure) { }

	// RVA: 0x19F89F8 Offset: 0x19F49F8 VA: 0x19F89F8
	internal string get_DebugView() { }

	// RVA: 0x19F8BAC Offset: 0x19F4BAC VA: 0x19F8BAC
	private static Func<LightLambda, Delegate> GetRunDelegateCtor(Type delegateType) { }

	// RVA: 0x19F8D34 Offset: 0x19F4D34 VA: 0x19F8D34
	private static Func<LightLambda, Delegate> MakeRunDelegateCtor(Type delegateType) { }

	// RVA: 0x19F9C18 Offset: 0x19F5C18 VA: 0x19F9C18
	private Delegate CreateCustomDelegate(Type delegateType) { }

	// RVA: 0x19F87B8 Offset: 0x19F47B8 VA: 0x19F87B8
	internal Delegate MakeDelegate(Type delegateType) { }

	// RVA: 0x19F8918 Offset: 0x19F4918 VA: 0x19F8918
	private InterpretedFrame MakeFrame() { }

	// RVA: -1 Offset: -1
	internal void RunVoidRef2<T0, T1>(ref T0 arg0, ref T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x112D5B8 Offset: 0x11295B8 VA: 0x112D5B8
	|-LightLambda.RunVoidRef2<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x19FA4D8 Offset: 0x19F64D8 VA: 0x19FA4D8
	public object Run(object[] arguments) { }

	// RVA: 0x19FA64C Offset: 0x19F664C VA: 0x19FA64C
	public object RunVoid(object[] arguments) { }

	// RVA: 0x19FA7B4 Offset: 0x19F67B4 VA: 0x19FA7B4
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal interface IBoxableInstruction // TypeDefIndex: 5741
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Instruction BoxIfIndexMatches(int index);
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class LocalAccessInstruction : Instruction // TypeDefIndex: 5742
{
	// Fields
	internal readonly int _index; // 0x10

	// Methods

	// RVA: 0x19FB2AC Offset: 0x19F72AC VA: 0x19FB2AC
	protected void .ctor(int index) { }

	// RVA: 0x19FB2D4 Offset: 0x19F72D4 VA: 0x19FB2D4 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 5743
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FB4BC Offset: 0x19F74BC VA: 0x19FB4BC
	internal void .ctor(int index) { }

	// RVA: 0x19FB4E4 Offset: 0x19F74E4 VA: 0x19FB4E4 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19FB4EC Offset: 0x19F74EC VA: 0x19FB4EC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19FB52C Offset: 0x19F752C VA: 0x19FB52C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FB5BC Offset: 0x19F75BC VA: 0x19FB5BC Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 5744
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FB634 Offset: 0x19F7634 VA: 0x19FB634
	internal void .ctor(int index) { }

	// RVA: 0x19FB65C Offset: 0x19F765C VA: 0x19FB65C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19FB664 Offset: 0x19F7664 VA: 0x19FB664 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19FB6A4 Offset: 0x19F76A4 VA: 0x19FB6A4 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadLocalFromClosureInstruction : LocalAccessInstruction // TypeDefIndex: 5745
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FB808 Offset: 0x19F7808 VA: 0x19FB808
	internal void .ctor(int index) { }

	// RVA: 0x19FB830 Offset: 0x19F7830 VA: 0x19FB830 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19FB838 Offset: 0x19F7838 VA: 0x19FB838 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19FB878 Offset: 0x19F7878 VA: 0x19FB878 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadLocalFromClosureBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 5746
{
	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FB9A8 Offset: 0x19F79A8 VA: 0x19FB9A8
	internal void .ctor(int index) { }

	// RVA: 0x19FB9D0 Offset: 0x19F79D0 VA: 0x19FB9D0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19FB9D8 Offset: 0x19F79D8 VA: 0x19FB9D8 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19FBA18 Offset: 0x19F7A18 VA: 0x19FBA18 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class AssignLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 5747
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FBAB0 Offset: 0x19F7AB0 VA: 0x19FBAB0
	internal void .ctor(int index) { }

	// RVA: 0x19FBAD8 Offset: 0x19F7AD8 VA: 0x19FBAD8 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19FBAE0 Offset: 0x19F7AE0 VA: 0x19FBAE0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19FBAE8 Offset: 0x19F7AE8 VA: 0x19FBAE8 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19FBB28 Offset: 0x19F7B28 VA: 0x19FBB28 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FBBA8 Offset: 0x19F7BA8 VA: 0x19FBBA8 Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction // TypeDefIndex: 5748
{
	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FBC20 Offset: 0x19F7C20 VA: 0x19FBC20
	internal void .ctor(int index) { }

	// RVA: 0x19FBC48 Offset: 0x19F7C48 VA: 0x19FBC48 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19FBC50 Offset: 0x19F7C50 VA: 0x19FBC50 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19FBC90 Offset: 0x19F7C90 VA: 0x19FBC90 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FBD10 Offset: 0x19F7D10 VA: 0x19FBD10 Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class AssignLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 5749
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FBD88 Offset: 0x19F7D88 VA: 0x19FBD88
	internal void .ctor(int index) { }

	// RVA: 0x19FBDB0 Offset: 0x19F7DB0 VA: 0x19FBDB0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19FBDB8 Offset: 0x19F7DB8 VA: 0x19FBDB8 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19FBDC0 Offset: 0x19F7DC0 VA: 0x19FBDC0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19FBE00 Offset: 0x19F7E00 VA: 0x19FBE00 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class StoreLocalBoxedInstruction : LocalAccessInstruction // TypeDefIndex: 5750
{
	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FBF34 Offset: 0x19F7F34 VA: 0x19FBF34
	internal void .ctor(int index) { }

	// RVA: 0x19FBF5C Offset: 0x19F7F5C VA: 0x19FBF5C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19FBF64 Offset: 0x19F7F64 VA: 0x19FBF64 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19FBFA4 Offset: 0x19F7FA4 VA: 0x19FBFA4 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class AssignLocalToClosureInstruction : LocalAccessInstruction // TypeDefIndex: 5751
{
	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FC0E4 Offset: 0x19F80E4 VA: 0x19FC0E4
	internal void .ctor(int index) { }

	// RVA: 0x19FC10C Offset: 0x19F810C VA: 0x19FC10C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19FC114 Offset: 0x19F8114 VA: 0x19FC114 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19FC11C Offset: 0x19F811C VA: 0x19FC11C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19FC15C Offset: 0x19F815C VA: 0x19FC15C Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class ValueTypeCopyInstruction : Instruction // TypeDefIndex: 5752
{
	// Fields
	public static readonly ValueTypeCopyInstruction Instruction; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FC244 Offset: 0x19F8244 VA: 0x19FC244 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19FC24C Offset: 0x19F824C VA: 0x19FC24C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19FC254 Offset: 0x19F8254 VA: 0x19FC254 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19FC294 Offset: 0x19F8294 VA: 0x19FC294 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FC2D8 Offset: 0x19F82D8 VA: 0x19FC2D8
	public void .ctor() { }

	// RVA: 0x19FC2E0 Offset: 0x19F82E0 VA: 0x19FC2E0
	private static void .cctor() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.Reference : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 5753
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FC370 Offset: 0x19F8370 VA: 0x19FC370
	internal void .ctor(int index) { }

	// RVA: 0x19FC398 Offset: 0x19F8398 VA: 0x19FC398 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FC3DC Offset: 0x19F83DC VA: 0x19FC3DC Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }

	// RVA: 0x19FC454 Offset: 0x19F8454 VA: 0x19FC454 Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.ImmutableValue : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 5754
{
	// Fields
	private readonly object _defaultValue; // 0x18

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FC494 Offset: 0x19F8494 VA: 0x19FC494
	internal void .ctor(int index, object defaultValue) { }

	// RVA: 0x19FC4CC Offset: 0x19F84CC VA: 0x19FC4CC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FC540 Offset: 0x19F8540 VA: 0x19FC540 Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }

	// RVA: 0x19FC600 Offset: 0x19F8600 VA: 0x19FC600 Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.ImmutableBox : InitializeLocalInstruction // TypeDefIndex: 5755
{
	// Fields
	private readonly object _defaultValue; // 0x18

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FC5C8 Offset: 0x19F85C8 VA: 0x19FC5C8
	internal void .ctor(int index, object defaultValue) { }

	// RVA: 0x19FC640 Offset: 0x19F8640 VA: 0x19FC640 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FC718 Offset: 0x19F8718 VA: 0x19FC718 Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.ImmutableRefBox : InitializeLocalInstruction // TypeDefIndex: 5756
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FC758 Offset: 0x19F8758 VA: 0x19FC758
	internal void .ctor(int index) { }

	// RVA: 0x19FC780 Offset: 0x19F8780 VA: 0x19FC780 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FC850 Offset: 0x19F8850 VA: 0x19FC850 Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.ParameterBox : InitializeLocalInstruction // TypeDefIndex: 5757
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FC890 Offset: 0x19F8890 VA: 0x19FC890
	public void .ctor(int index) { }

	// RVA: 0x19FC8B8 Offset: 0x19F88B8 VA: 0x19FC8B8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FC9AC Offset: 0x19F89AC VA: 0x19FC9AC Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.Parameter : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 5758
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FC9EC Offset: 0x19F89EC VA: 0x19FC9EC
	internal void .ctor(int index) { }

	// RVA: 0x19FCA14 Offset: 0x19F8A14 VA: 0x19FCA14 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FCA1C Offset: 0x19F8A1C VA: 0x19FCA1C Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }

	// RVA: 0x19FCA94 Offset: 0x19F8A94 VA: 0x19FCA94 Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.MutableValue : InitializeLocalInstruction, IBoxableInstruction // TypeDefIndex: 5759
{
	// Fields
	private readonly Type _type; // 0x18

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FCAD4 Offset: 0x19F8AD4 VA: 0x19FCAD4
	internal void .ctor(int index, Type type) { }

	// RVA: 0x19FCB0C Offset: 0x19F8B0C VA: 0x19FCB0C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FCC30 Offset: 0x19F8C30 VA: 0x19FCC30 Slot: 11
	public Instruction BoxIfIndexMatches(int index) { }

	// RVA: 0x19FCCF0 Offset: 0x19F8CF0 VA: 0x19FCCF0 Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: 
internal sealed class InitializeLocalInstruction.MutableBox : InitializeLocalInstruction // TypeDefIndex: 5760
{
	// Fields
	private readonly Type _type; // 0x18

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FCCB8 Offset: 0x19F8CB8 VA: 0x19FCCB8
	internal void .ctor(int index, Type type) { }

	// RVA: 0x19FCD30 Offset: 0x19F8D30 VA: 0x19FCD30 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FCEB0 Offset: 0x19F8EB0 VA: 0x19FCEB0 Slot: 9
	public override string get_InstructionName() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class InitializeLocalInstruction : LocalAccessInstruction // TypeDefIndex: 5761
{
	// Methods

	// RVA: 0x19FC348 Offset: 0x19F8348 VA: 0x19FC348
	internal void .ctor(int index) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class RuntimeVariablesInstruction : Instruction // TypeDefIndex: 5762
{
	// Fields
	private readonly int _count; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FCEF0 Offset: 0x19F8EF0 VA: 0x19FCEF0
	public void .ctor(int count) { }

	// RVA: 0x19FCF18 Offset: 0x19F8F18 VA: 0x19FCF18 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19FCF20 Offset: 0x19F8F20 VA: 0x19FCF20 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19FCF28 Offset: 0x19F8F28 VA: 0x19FCF28 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19FCF68 Offset: 0x19F8F68 VA: 0x19FCF68 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LocalVariable // TypeDefIndex: 5763
{
	// Fields
	public readonly int Index; // 0x10
	private int _flags; // 0x14

	// Properties
	public bool IsBoxed { get; set; }
	public bool InClosure { get; }

	// Methods

	// RVA: 0x19F7C18 Offset: 0x19F3C18 VA: 0x19F7C18
	public bool get_IsBoxed() { }

	// RVA: 0x19FD124 Offset: 0x19F9124 VA: 0x19FD124
	public void set_IsBoxed(bool value) { }

	// RVA: 0x19F7C0C Offset: 0x19F3C0C VA: 0x19F7C0C
	public bool get_InClosure() { }

	// RVA: 0x19FD134 Offset: 0x19F9134 VA: 0x19FD134
	internal void .ctor(int index, bool closure) { }

	// RVA: 0x19FD16C Offset: 0x19F916C VA: 0x19FD16C Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
[IsReadOnly]
internal struct LocalDefinition // TypeDefIndex: 5764
{
	// Fields
	[CompilerGenerated]
	private readonly int <Index>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly ParameterExpression <Parameter>k__BackingField; // 0x8

	// Properties
	public int Index { get; }
	public ParameterExpression Parameter { get; }

	// Methods

	// RVA: 0x19FD260 Offset: 0x19F9260 VA: 0x19FD260
	internal void .ctor(int localIndex, ParameterExpression parameter) { }

	[CompilerGenerated]
	// RVA: 0x19FD270 Offset: 0x19F9270 VA: 0x19FD270
	public int get_Index() { }

	[CompilerGenerated]
	// RVA: 0x19FD278 Offset: 0x19F9278 VA: 0x19FD278
	public ParameterExpression get_Parameter() { }

	// RVA: 0x19FD280 Offset: 0x19F9280 VA: 0x19FD280 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x19FD308 Offset: 0x19F9308 VA: 0x19FD308 Slot: 2
	public override int GetHashCode() { }
}

// Namespace: 
private sealed class LocalVariables.VariableScope // TypeDefIndex: 5765
{
	// Fields
	public readonly int Start; // 0x10
	public int Stop; // 0x14
	public readonly LocalVariable Variable; // 0x18
	public readonly LocalVariables.VariableScope Parent; // 0x20
	public List<LocalVariables.VariableScope> ChildScopes; // 0x28

	// Methods

	// RVA: 0x19FD5D0 Offset: 0x19F95D0 VA: 0x19FD5D0
	public void .ctor(LocalVariable variable, int start, LocalVariables.VariableScope parent) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LocalVariables // TypeDefIndex: 5766
{
	// Fields
	private readonly HybridReferenceDictionary<ParameterExpression, LocalVariables.VariableScope> _variables; // 0x10
	private Dictionary<ParameterExpression, LocalVariable> _closureVariables; // 0x18
	private int _localCount; // 0x20
	private int _maxLocalCount; // 0x24

	// Properties
	public int LocalCount { get; }
	internal Dictionary<ParameterExpression, LocalVariable> ClosureVariables { get; }

	// Methods

	// RVA: 0x19FD354 Offset: 0x19F9354 VA: 0x19FD354
	public LocalDefinition DefineLocal(ParameterExpression variable, int start) { }

	// RVA: 0x19F7DD0 Offset: 0x19F3DD0 VA: 0x19F7DD0
	public void UndefineLocal(LocalDefinition definition, int end) { }

	// RVA: 0x19FD62C Offset: 0x19F962C VA: 0x19FD62C
	internal void Box(ParameterExpression variable, InstructionList instructions) { }

	// RVA: 0x19FD780 Offset: 0x19F9780 VA: 0x19FD780
	public int get_LocalCount() { }

	// RVA: 0x19FD788 Offset: 0x19F9788 VA: 0x19FD788
	public bool TryGetLocalOrClosure(ParameterExpression var, out LocalVariable local) { }

	// RVA: 0x19FD85C Offset: 0x19F985C VA: 0x19FD85C
	internal Dictionary<ParameterExpression, LocalVariable> get_ClosureVariables() { }

	// RVA: 0x19FD864 Offset: 0x19F9864 VA: 0x19FD864
	internal LocalVariable AddClosureVariable(ParameterExpression variable) { }

	// RVA: 0x19FD980 Offset: 0x19F9980 VA: 0x19FD980
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloInt16 : ModuloInstruction // TypeDefIndex: 5767
{
	// Methods

	// RVA: 0x19FDE4C Offset: 0x19F9E4C VA: 0x19FDE4C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FDE0C Offset: 0x19F9E0C VA: 0x19FDE0C
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloInt32 : ModuloInstruction // TypeDefIndex: 5768
{
	// Methods

	// RVA: 0x19FDF8C Offset: 0x19F9F8C VA: 0x19FDF8C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FDE14 Offset: 0x19F9E14 VA: 0x19FDE14
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloInt64 : ModuloInstruction // TypeDefIndex: 5769
{
	// Methods

	// RVA: 0x19FE1FC Offset: 0x19FA1FC VA: 0x19FE1FC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FDE1C Offset: 0x19F9E1C VA: 0x19FDE1C
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloUInt16 : ModuloInstruction // TypeDefIndex: 5770
{
	// Methods

	// RVA: 0x19FE33C Offset: 0x19FA33C VA: 0x19FE33C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FDE24 Offset: 0x19F9E24 VA: 0x19FDE24
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloUInt32 : ModuloInstruction // TypeDefIndex: 5771
{
	// Methods

	// RVA: 0x19FE47C Offset: 0x19FA47C VA: 0x19FE47C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FDE2C Offset: 0x19F9E2C VA: 0x19FDE2C
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloUInt64 : ModuloInstruction // TypeDefIndex: 5772
{
	// Methods

	// RVA: 0x19FE5BC Offset: 0x19FA5BC VA: 0x19FE5BC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FDE34 Offset: 0x19F9E34 VA: 0x19FDE34
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloSingle : ModuloInstruction // TypeDefIndex: 5773
{
	// Methods

	// RVA: 0x19FE6FC Offset: 0x19FA6FC VA: 0x19FE6FC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FDE3C Offset: 0x19F9E3C VA: 0x19FDE3C
	public void .ctor() { }
}

// Namespace: 
private sealed class ModuloInstruction.ModuloDouble : ModuloInstruction // TypeDefIndex: 5774
{
	// Methods

	// RVA: 0x19FE83C Offset: 0x19FA83C VA: 0x19FE83C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FDE44 Offset: 0x19F9E44 VA: 0x19FDE44
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class ModuloInstruction : Instruction // TypeDefIndex: 5775
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FDA08 Offset: 0x19F9A08 VA: 0x19FDA08 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19FDA10 Offset: 0x19F9A10 VA: 0x19FDA10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19FDA18 Offset: 0x19F9A18 VA: 0x19FDA18 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19FDA58 Offset: 0x19F9A58 VA: 0x19FDA58
	private void .ctor() { }

	// RVA: 0x19FDA60 Offset: 0x19F9A60 VA: 0x19FDA60
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class MulInstruction.MulInt16 : MulInstruction // TypeDefIndex: 5776
{
	// Methods

	// RVA: 0x19FEDC0 Offset: 0x19FADC0 VA: 0x19FEDC0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FED80 Offset: 0x19FAD80 VA: 0x19FED80
	public void .ctor() { }
}

// Namespace: 
private sealed class MulInstruction.MulInt32 : MulInstruction // TypeDefIndex: 5777
{
	// Methods

	// RVA: 0x19FEEFC Offset: 0x19FAEFC VA: 0x19FEEFC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FED88 Offset: 0x19FAD88 VA: 0x19FED88
	public void .ctor() { }
}

// Namespace: 
private sealed class MulInstruction.MulInt64 : MulInstruction // TypeDefIndex: 5778
{
	// Methods

	// RVA: 0x19FF024 Offset: 0x19FB024 VA: 0x19FF024 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FED90 Offset: 0x19FAD90 VA: 0x19FED90
	public void .ctor() { }
}

// Namespace: 
private sealed class MulInstruction.MulUInt16 : MulInstruction // TypeDefIndex: 5779
{
	// Methods

	// RVA: 0x19FF160 Offset: 0x19FB160 VA: 0x19FF160 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FED98 Offset: 0x19FAD98 VA: 0x19FED98
	public void .ctor() { }
}

// Namespace: 
private sealed class MulInstruction.MulUInt32 : MulInstruction // TypeDefIndex: 5780
{
	// Methods

	// RVA: 0x19FF29C Offset: 0x19FB29C VA: 0x19FF29C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FEDA0 Offset: 0x19FADA0 VA: 0x19FEDA0
	public void .ctor() { }
}

// Namespace: 
private sealed class MulInstruction.MulUInt64 : MulInstruction // TypeDefIndex: 5781
{
	// Methods

	// RVA: 0x19FF3D8 Offset: 0x19FB3D8 VA: 0x19FF3D8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FEDA8 Offset: 0x19FADA8 VA: 0x19FEDA8
	public void .ctor() { }
}

// Namespace: 
private sealed class MulInstruction.MulSingle : MulInstruction // TypeDefIndex: 5782
{
	// Methods

	// RVA: 0x19FF514 Offset: 0x19FB514 VA: 0x19FF514 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FEDB0 Offset: 0x19FADB0 VA: 0x19FEDB0
	public void .ctor() { }
}

// Namespace: 
private sealed class MulInstruction.MulDouble : MulInstruction // TypeDefIndex: 5783
{
	// Methods

	// RVA: 0x19FF650 Offset: 0x19FB650 VA: 0x19FF650 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FEDB8 Offset: 0x19FADB8 VA: 0x19FEDB8
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class MulInstruction : Instruction // TypeDefIndex: 5784
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FE97C Offset: 0x19FA97C VA: 0x19FE97C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19FE984 Offset: 0x19FA984 VA: 0x19FE984 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19FE98C Offset: 0x19FA98C VA: 0x19FE98C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19FE9CC Offset: 0x19FA9CC VA: 0x19FE9CC
	private void .ctor() { }

	// RVA: 0x19FE9D4 Offset: 0x19FA9D4 VA: 0x19FE9D4
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class MulOvfInstruction.MulOvfInt16 : MulOvfInstruction // TypeDefIndex: 5785
{
	// Methods

	// RVA: 0x19FFAEC Offset: 0x19FBAEC VA: 0x19FFAEC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FFABC Offset: 0x19FBABC VA: 0x19FFABC
	public void .ctor() { }
}

// Namespace: 
private sealed class MulOvfInstruction.MulOvfInt32 : MulOvfInstruction // TypeDefIndex: 5786
{
	// Methods

	// RVA: 0x19FFD40 Offset: 0x19FBD40 VA: 0x19FFD40 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FFAC4 Offset: 0x19FBAC4 VA: 0x19FFAC4
	public void .ctor() { }
}

// Namespace: 
private sealed class MulOvfInstruction.MulOvfInt64 : MulOvfInstruction // TypeDefIndex: 5787
{
	// Methods

	// RVA: 0x19FFF5C Offset: 0x19FBF5C VA: 0x19FFF5C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FFACC Offset: 0x19FBACC VA: 0x19FFACC
	public void .ctor() { }
}

// Namespace: 
private sealed class MulOvfInstruction.MulOvfUInt16 : MulOvfInstruction // TypeDefIndex: 5788
{
	// Methods

	// RVA: 0x1A00164 Offset: 0x19FC164 VA: 0x1A00164 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FFAD4 Offset: 0x19FBAD4 VA: 0x19FFAD4
	public void .ctor() { }
}

// Namespace: 
private sealed class MulOvfInstruction.MulOvfUInt32 : MulOvfInstruction // TypeDefIndex: 5789
{
	// Methods

	// RVA: 0x1A003CC Offset: 0x19FC3CC VA: 0x1A003CC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FFADC Offset: 0x19FBADC VA: 0x19FFADC
	public void .ctor() { }
}

// Namespace: 
private sealed class MulOvfInstruction.MulOvfUInt64 : MulOvfInstruction // TypeDefIndex: 5790
{
	// Methods

	// RVA: 0x1A005A0 Offset: 0x19FC5A0 VA: 0x1A005A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x19FFAE4 Offset: 0x19FBAE4 VA: 0x19FFAE4
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class MulOvfInstruction : Instruction // TypeDefIndex: 5791
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x19FF78C Offset: 0x19FB78C VA: 0x19FF78C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x19FF794 Offset: 0x19FB794 VA: 0x19FF794 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x19FF79C Offset: 0x19FB79C VA: 0x19FF79C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x19FF7DC Offset: 0x19FB7DC VA: 0x19FF7DC
	private void .ctor() { }

	// RVA: 0x19FF7E4 Offset: 0x19FB7E4 VA: 0x19FF7E4
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class NegateInstruction.NegateInt16 : NegateInstruction // TypeDefIndex: 5792
{
	// Methods

	// RVA: 0x1A00A84 Offset: 0x19FCA84 VA: 0x1A00A84 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A00A5C Offset: 0x19FCA5C VA: 0x1A00A5C
	public void .ctor() { }
}

// Namespace: 
private sealed class NegateInstruction.NegateInt32 : NegateInstruction // TypeDefIndex: 5793
{
	// Methods

	// RVA: 0x1A00B00 Offset: 0x19FCB00 VA: 0x1A00B00 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A00A64 Offset: 0x19FCA64 VA: 0x1A00A64
	public void .ctor() { }
}

// Namespace: 
private sealed class NegateInstruction.NegateInt64 : NegateInstruction // TypeDefIndex: 5794
{
	// Methods

	// RVA: 0x1A00B7C Offset: 0x19FCB7C VA: 0x1A00B7C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A00A6C Offset: 0x19FCA6C VA: 0x1A00A6C
	public void .ctor() { }
}

// Namespace: 
private sealed class NegateInstruction.NegateSingle : NegateInstruction // TypeDefIndex: 5795
{
	// Methods

	// RVA: 0x1A00C10 Offset: 0x19FCC10 VA: 0x1A00C10 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A00A74 Offset: 0x19FCA74 VA: 0x1A00A74
	public void .ctor() { }
}

// Namespace: 
private sealed class NegateInstruction.NegateDouble : NegateInstruction // TypeDefIndex: 5796
{
	// Methods

	// RVA: 0x1A00CA0 Offset: 0x19FCCA0 VA: 0x1A00CA0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A00A7C Offset: 0x19FCA7C VA: 0x1A00A7C
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NegateInstruction : Instruction // TypeDefIndex: 5797
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_Single; // 0x18
	private static Instruction s_Double; // 0x20

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A00770 Offset: 0x19FC770 VA: 0x1A00770 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A00778 Offset: 0x19FC778 VA: 0x1A00778 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A00780 Offset: 0x19FC780 VA: 0x1A00780 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A007C0 Offset: 0x19FC7C0 VA: 0x1A007C0
	private void .ctor() { }

	// RVA: 0x1A007C8 Offset: 0x19FC7C8 VA: 0x1A007C8
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class NegateCheckedInstruction.NegateCheckedInt32 : NegateCheckedInstruction // TypeDefIndex: 5798
{
	// Methods

	// RVA: 0x1A00F68 Offset: 0x19FCF68 VA: 0x1A00F68 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A00F58 Offset: 0x19FCF58 VA: 0x1A00F58
	public void .ctor() { }
}

// Namespace: 
private sealed class NegateCheckedInstruction.NegateCheckedInt16 : NegateCheckedInstruction // TypeDefIndex: 5799
{
	// Methods

	// RVA: 0x1A0107C Offset: 0x19FD07C VA: 0x1A0107C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A00F50 Offset: 0x19FCF50 VA: 0x1A00F50
	public void .ctor() { }
}

// Namespace: 
private sealed class NegateCheckedInstruction.NegateCheckedInt64 : NegateCheckedInstruction // TypeDefIndex: 5800
{
	// Methods

	// RVA: 0x1A011AC Offset: 0x19FD1AC VA: 0x1A011AC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A00F60 Offset: 0x19FCF60 VA: 0x1A00F60
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NegateCheckedInstruction : Instruction // TypeDefIndex: 5801
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A00D30 Offset: 0x19FCD30 VA: 0x1A00D30 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A00D38 Offset: 0x19FCD38 VA: 0x1A00D38 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A00D40 Offset: 0x19FCD40 VA: 0x1A00D40 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A00D80 Offset: 0x19FCD80 VA: 0x1A00D80
	private void .ctor() { }

	// RVA: 0x1A00D88 Offset: 0x19FCD88 VA: 0x1A00D88
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class NewInstruction : Instruction // TypeDefIndex: 5802
{
	// Fields
	protected readonly ConstructorInfo _constructor; // 0x10
	protected readonly int _argumentCount; // 0x18

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A012BC Offset: 0x19FD2BC VA: 0x1A012BC
	public void .ctor(ConstructorInfo constructor, int argumentCount) { }

	// RVA: 0x1A012F8 Offset: 0x19FD2F8 VA: 0x1A012F8 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A01300 Offset: 0x19FD300 VA: 0x1A01300 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A01308 Offset: 0x19FD308 VA: 0x1A01308 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A01348 Offset: 0x19FD348 VA: 0x1A01348 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A014A0 Offset: 0x19FD4A0 VA: 0x1A014A0
	protected object[] GetArgs(InterpretedFrame frame, int first) { }

	// RVA: 0x1A0163C Offset: 0x19FD63C VA: 0x1A0163C Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal class ByRefNewInstruction : NewInstruction // TypeDefIndex: 5803
{
	// Fields
	private readonly ByRefUpdater[] _byrefArgs; // 0x20

	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A017AC Offset: 0x19FD7AC VA: 0x1A017AC
	internal void .ctor(ConstructorInfo target, int argumentCount, ByRefUpdater[] byrefArgs) { }

	// RVA: 0x1A01800 Offset: 0x19FD800 VA: 0x1A01800 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A01840 Offset: 0x19FD840 VA: 0x1A01840 Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualBoolean : NotEqualInstruction // TypeDefIndex: 5804
{
	// Methods

	// RVA: 0x1A023DC Offset: 0x19FE3DC VA: 0x1A023DC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A02374 Offset: 0x19FE374 VA: 0x1A02374
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualSByte : NotEqualInstruction // TypeDefIndex: 5805
{
	// Methods

	// RVA: 0x1A024A0 Offset: 0x19FE4A0 VA: 0x1A024A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0237C Offset: 0x19FE37C VA: 0x1A0237C
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualInt16 : NotEqualInstruction // TypeDefIndex: 5806
{
	// Methods

	// RVA: 0x1A02564 Offset: 0x19FE564 VA: 0x1A02564 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A02384 Offset: 0x19FE384 VA: 0x1A02384
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualChar : NotEqualInstruction // TypeDefIndex: 5807
{
	// Methods

	// RVA: 0x1A02628 Offset: 0x19FE628 VA: 0x1A02628 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0238C Offset: 0x19FE38C VA: 0x1A0238C
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualInt32 : NotEqualInstruction // TypeDefIndex: 5808
{
	// Methods

	// RVA: 0x1A026EC Offset: 0x19FE6EC VA: 0x1A026EC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A02394 Offset: 0x19FE394 VA: 0x1A02394
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualInt64 : NotEqualInstruction // TypeDefIndex: 5809
{
	// Methods

	// RVA: 0x1A027B0 Offset: 0x19FE7B0 VA: 0x1A027B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0239C Offset: 0x19FE39C VA: 0x1A0239C
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualByte : NotEqualInstruction // TypeDefIndex: 5810
{
	// Methods

	// RVA: 0x1A02874 Offset: 0x19FE874 VA: 0x1A02874 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A023A4 Offset: 0x19FE3A4 VA: 0x1A023A4
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualUInt16 : NotEqualInstruction // TypeDefIndex: 5811
{
	// Methods

	// RVA: 0x1A02938 Offset: 0x19FE938 VA: 0x1A02938 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A023AC Offset: 0x19FE3AC VA: 0x1A023AC
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualUInt32 : NotEqualInstruction // TypeDefIndex: 5812
{
	// Methods

	// RVA: 0x1A029FC Offset: 0x19FE9FC VA: 0x1A029FC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A023B4 Offset: 0x19FE3B4 VA: 0x1A023B4
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualUInt64 : NotEqualInstruction // TypeDefIndex: 5813
{
	// Methods

	// RVA: 0x1A02AC0 Offset: 0x19FEAC0 VA: 0x1A02AC0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A023BC Offset: 0x19FE3BC VA: 0x1A023BC
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualSingle : NotEqualInstruction // TypeDefIndex: 5814
{
	// Methods

	// RVA: 0x1A02B84 Offset: 0x19FEB84 VA: 0x1A02B84 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A023C4 Offset: 0x19FE3C4 VA: 0x1A023C4
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualDouble : NotEqualInstruction // TypeDefIndex: 5815
{
	// Methods

	// RVA: 0x1A02C50 Offset: 0x19FEC50 VA: 0x1A02C50 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A023CC Offset: 0x19FE3CC VA: 0x1A023CC
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualReference : NotEqualInstruction // TypeDefIndex: 5816
{
	// Methods

	// RVA: 0x1A02D1C Offset: 0x19FED1C VA: 0x1A02D1C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A023D4 Offset: 0x19FE3D4 VA: 0x1A023D4
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualSByteLiftedToNull : NotEqualInstruction // TypeDefIndex: 5817
{
	// Methods

	// RVA: 0x1A02D70 Offset: 0x19FED70 VA: 0x1A02D70 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0231C Offset: 0x19FE31C VA: 0x1A0231C
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualInt16LiftedToNull : NotEqualInstruction // TypeDefIndex: 5818
{
	// Methods

	// RVA: 0x1A02E38 Offset: 0x19FEE38 VA: 0x1A02E38 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A02324 Offset: 0x19FE324 VA: 0x1A02324
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualCharLiftedToNull : NotEqualInstruction // TypeDefIndex: 5819
{
	// Methods

	// RVA: 0x1A02F00 Offset: 0x19FEF00 VA: 0x1A02F00 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0232C Offset: 0x19FE32C VA: 0x1A0232C
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualInt32LiftedToNull : NotEqualInstruction // TypeDefIndex: 5820
{
	// Methods

	// RVA: 0x1A02FC8 Offset: 0x19FEFC8 VA: 0x1A02FC8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A02334 Offset: 0x19FE334 VA: 0x1A02334
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualInt64LiftedToNull : NotEqualInstruction // TypeDefIndex: 5821
{
	// Methods

	// RVA: 0x1A03090 Offset: 0x19FF090 VA: 0x1A03090 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0233C Offset: 0x19FE33C VA: 0x1A0233C
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualByteLiftedToNull : NotEqualInstruction // TypeDefIndex: 5822
{
	// Methods

	// RVA: 0x1A03158 Offset: 0x19FF158 VA: 0x1A03158 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A02344 Offset: 0x19FE344 VA: 0x1A02344
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualUInt16LiftedToNull : NotEqualInstruction // TypeDefIndex: 5823
{
	// Methods

	// RVA: 0x1A03220 Offset: 0x19FF220 VA: 0x1A03220 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0234C Offset: 0x19FE34C VA: 0x1A0234C
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualUInt32LiftedToNull : NotEqualInstruction // TypeDefIndex: 5824
{
	// Methods

	// RVA: 0x1A032E8 Offset: 0x19FF2E8 VA: 0x1A032E8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A02354 Offset: 0x19FE354 VA: 0x1A02354
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualUInt64LiftedToNull : NotEqualInstruction // TypeDefIndex: 5825
{
	// Methods

	// RVA: 0x1A033B0 Offset: 0x19FF3B0 VA: 0x1A033B0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0235C Offset: 0x19FE35C VA: 0x1A0235C
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualSingleLiftedToNull : NotEqualInstruction // TypeDefIndex: 5826
{
	// Methods

	// RVA: 0x1A03478 Offset: 0x19FF478 VA: 0x1A03478 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A02364 Offset: 0x19FE364 VA: 0x1A02364
	public void .ctor() { }
}

// Namespace: 
private sealed class NotEqualInstruction.NotEqualDoubleLiftedToNull : NotEqualInstruction // TypeDefIndex: 5827
{
	// Methods

	// RVA: 0x1A03548 Offset: 0x19FF548 VA: 0x1A03548 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0236C Offset: 0x19FE36C VA: 0x1A0236C
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NotEqualInstruction : Instruction // TypeDefIndex: 5828
{
	// Fields
	private static Instruction s_reference; // 0x0
	private static Instruction s_Boolean; // 0x8
	private static Instruction s_SByte; // 0x10
	private static Instruction s_Int16; // 0x18
	private static Instruction s_Char; // 0x20
	private static Instruction s_Int32; // 0x28
	private static Instruction s_Int64; // 0x30
	private static Instruction s_Byte; // 0x38
	private static Instruction s_UInt16; // 0x40
	private static Instruction s_UInt32; // 0x48
	private static Instruction s_UInt64; // 0x50
	private static Instruction s_Single; // 0x58
	private static Instruction s_Double; // 0x60
	private static Instruction s_SByteLiftedToNull; // 0x68
	private static Instruction s_Int16LiftedToNull; // 0x70
	private static Instruction s_CharLiftedToNull; // 0x78
	private static Instruction s_Int32LiftedToNull; // 0x80
	private static Instruction s_Int64LiftedToNull; // 0x88
	private static Instruction s_ByteLiftedToNull; // 0x90
	private static Instruction s_UInt16LiftedToNull; // 0x98
	private static Instruction s_UInt32LiftedToNull; // 0xA0
	private static Instruction s_UInt64LiftedToNull; // 0xA8
	private static Instruction s_SingleLiftedToNull; // 0xB0
	private static Instruction s_DoubleLiftedToNull; // 0xB8

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A01A64 Offset: 0x19FDA64 VA: 0x1A01A64 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A01A6C Offset: 0x19FDA6C VA: 0x1A01A6C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A01A74 Offset: 0x19FDA74 VA: 0x1A01A74 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A01AB4 Offset: 0x19FDAB4 VA: 0x1A01AB4
	private void .ctor() { }

	// RVA: 0x1A01ABC Offset: 0x19FDABC VA: 0x1A01ABC
	public static Instruction Create(Type type, bool liftedToNull) { }
}

// Namespace: 
private sealed class NotInstruction.NotBoolean : NotInstruction // TypeDefIndex: 5829
{
	// Methods

	// RVA: 0x1A03ABC Offset: 0x19FFABC VA: 0x1A03ABC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A03A74 Offset: 0x19FFA74 VA: 0x1A03A74
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotInt64 : NotInstruction // TypeDefIndex: 5830
{
	// Methods

	// RVA: 0x1A03B3C Offset: 0x19FFB3C VA: 0x1A03B3C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A03A7C Offset: 0x19FFA7C VA: 0x1A03A7C
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotInt32 : NotInstruction // TypeDefIndex: 5831
{
	// Methods

	// RVA: 0x1A03BD0 Offset: 0x19FFBD0 VA: 0x1A03BD0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A03A84 Offset: 0x19FFA84 VA: 0x1A03A84
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotInt16 : NotInstruction // TypeDefIndex: 5832
{
	// Methods

	// RVA: 0x1A03C4C Offset: 0x19FFC4C VA: 0x1A03C4C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A03A8C Offset: 0x19FFA8C VA: 0x1A03A8C
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotUInt64 : NotInstruction // TypeDefIndex: 5833
{
	// Methods

	// RVA: 0x1A03CC8 Offset: 0x19FFCC8 VA: 0x1A03CC8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A03A94 Offset: 0x19FFA94 VA: 0x1A03A94
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotUInt32 : NotInstruction // TypeDefIndex: 5834
{
	// Methods

	// RVA: 0x1A03D5C Offset: 0x19FFD5C VA: 0x1A03D5C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A03A9C Offset: 0x19FFA9C VA: 0x1A03A9C
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotUInt16 : NotInstruction // TypeDefIndex: 5835
{
	// Methods

	// RVA: 0x1A03DF0 Offset: 0x19FFDF0 VA: 0x1A03DF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A03AA4 Offset: 0x19FFAA4 VA: 0x1A03AA4
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotByte : NotInstruction // TypeDefIndex: 5836
{
	// Methods

	// RVA: 0x1A03E6C Offset: 0x19FFE6C VA: 0x1A03E6C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A03AAC Offset: 0x19FFAAC VA: 0x1A03AAC
	public void .ctor() { }
}

// Namespace: 
private sealed class NotInstruction.NotSByte : NotInstruction // TypeDefIndex: 5837
{
	// Methods

	// RVA: 0x1A03EE8 Offset: 0x19FFEE8 VA: 0x1A03EE8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A03AB4 Offset: 0x19FFAB4 VA: 0x1A03AB4
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NotInstruction : Instruction // TypeDefIndex: 5838
{
	// Fields
	public static Instruction s_Boolean; // 0x0
	public static Instruction s_Int64; // 0x8
	public static Instruction s_Int32; // 0x10
	public static Instruction s_Int16; // 0x18
	public static Instruction s_UInt64; // 0x20
	public static Instruction s_UInt32; // 0x28
	public static Instruction s_UInt16; // 0x30
	public static Instruction s_Byte; // 0x38
	public static Instruction s_SByte; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A03618 Offset: 0x19FF618 VA: 0x1A03618
	private void .ctor() { }

	// RVA: 0x1A03620 Offset: 0x19FF620 VA: 0x1A03620 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A03628 Offset: 0x19FF628 VA: 0x1A03628 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A03630 Offset: 0x19FF630 VA: 0x1A03630 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A03670 Offset: 0x19FF670 VA: 0x1A03670
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class NullCheckInstruction : Instruction // TypeDefIndex: 5839
{
	// Fields
	public static readonly Instruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A03F64 Offset: 0x19FFF64 VA: 0x1A03F64
	private void .ctor() { }

	// RVA: 0x1A03F6C Offset: 0x19FFF6C VA: 0x1A03F6C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A03F74 Offset: 0x19FFF74 VA: 0x1A03F74 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A03F7C Offset: 0x19FFF7C VA: 0x1A03F7C Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A03FBC Offset: 0x19FFFBC VA: 0x1A03FBC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A04018 Offset: 0x1A00018 VA: 0x1A04018
	private static void .cctor() { }
}

// Namespace: 
internal sealed class NumericConvertInstruction.Unchecked : NumericConvertInstruction // TypeDefIndex: 5840
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A043FC Offset: 0x1A003FC VA: 0x1A043FC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0443C Offset: 0x1A0043C VA: 0x1A0443C
	public void .ctor(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1A04478 Offset: 0x1A00478 VA: 0x1A04478 Slot: 11
	protected override object Convert(object obj) { }

	// RVA: 0x1A047C4 Offset: 0x1A007C4 VA: 0x1A047C4
	private object ConvertInt32(int obj) { }

	// RVA: 0x1A049BC Offset: 0x1A009BC VA: 0x1A049BC
	private object ConvertInt64(long obj) { }

	// RVA: 0x1A04BE4 Offset: 0x1A00BE4 VA: 0x1A04BE4
	private object ConvertUInt64(ulong obj) { }

	// RVA: 0x1A04E10 Offset: 0x1A00E10 VA: 0x1A04E10
	private object ConvertDouble(double obj) { }
}

// Namespace: 
internal sealed class NumericConvertInstruction.Checked : NumericConvertInstruction // TypeDefIndex: 5841
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A050DC Offset: 0x1A010DC VA: 0x1A050DC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0511C Offset: 0x1A0111C VA: 0x1A0511C
	public void .ctor(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1A05158 Offset: 0x1A01158 VA: 0x1A05158 Slot: 11
	protected override object Convert(object obj) { }

	// RVA: 0x1A054A4 Offset: 0x1A014A4 VA: 0x1A054A4
	private object ConvertInt32(int obj) { }

	// RVA: 0x1A056F4 Offset: 0x1A016F4 VA: 0x1A056F4
	private object ConvertInt64(long obj) { }

	// RVA: 0x1A0598C Offset: 0x1A0198C VA: 0x1A0598C
	private object ConvertUInt64(ulong obj) { }

	// RVA: 0x1A05C24 Offset: 0x1A01C24 VA: 0x1A05C24
	private object ConvertDouble(double obj) { }
}

// Namespace: 
internal sealed class NumericConvertInstruction.ToUnderlying : NumericConvertInstruction // TypeDefIndex: 5842
{
	// Properties
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A05F84 Offset: 0x1A01F84 VA: 0x1A05F84 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A05FC4 Offset: 0x1A01FC4 VA: 0x1A05FC4
	public void .ctor(TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1A05FF4 Offset: 0x1A01FF4 VA: 0x1A05FF4 Slot: 11
	protected override object Convert(object obj) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NumericConvertInstruction : Instruction // TypeDefIndex: 5843
{
	// Fields
	internal readonly TypeCode _from; // 0x10
	internal readonly TypeCode _to; // 0x14
	private readonly bool _isLiftedToNull; // 0x18

	// Properties
	public override string InstructionName { get; }
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }

	// Methods

	// RVA: 0x1A04080 Offset: 0x1A00080 VA: 0x1A04080
	protected void .ctor(TypeCode from, TypeCode to, bool isLiftedToNull) { }

	// RVA: 0x1A040BC Offset: 0x1A000BC VA: 0x1A040BC Slot: 8
	public sealed override int Run(InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract object Convert(object obj);

	// RVA: 0x1A041DC Offset: 0x1A001DC VA: 0x1A041DC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0421C Offset: 0x1A0021C VA: 0x1A0421C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A04224 Offset: 0x1A00224 VA: 0x1A04224 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A0422C Offset: 0x1A0022C VA: 0x1A0422C Slot: 3
	public override string ToString() { }
}

// Namespace: 
private sealed class OrInstruction.OrSByte : OrInstruction // TypeDefIndex: 5844
{
	// Methods

	// RVA: 0x1A06790 Offset: 0x1A02790 VA: 0x1A06790 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A06748 Offset: 0x1A02748 VA: 0x1A06748
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrInt16 : OrInstruction // TypeDefIndex: 5845
{
	// Methods

	// RVA: 0x1A06864 Offset: 0x1A02864 VA: 0x1A06864 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A06750 Offset: 0x1A02750 VA: 0x1A06750
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrInt32 : OrInstruction // TypeDefIndex: 5846
{
	// Methods

	// RVA: 0x1A06938 Offset: 0x1A02938 VA: 0x1A06938 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A06758 Offset: 0x1A02758 VA: 0x1A06758
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrInt64 : OrInstruction // TypeDefIndex: 5847
{
	// Methods

	// RVA: 0x1A06A0C Offset: 0x1A02A0C VA: 0x1A06A0C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A06760 Offset: 0x1A02760 VA: 0x1A06760
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrByte : OrInstruction // TypeDefIndex: 5848
{
	// Methods

	// RVA: 0x1A06AF0 Offset: 0x1A02AF0 VA: 0x1A06AF0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A06768 Offset: 0x1A02768 VA: 0x1A06768
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrUInt16 : OrInstruction // TypeDefIndex: 5849
{
	// Methods

	// RVA: 0x1A06BC4 Offset: 0x1A02BC4 VA: 0x1A06BC4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A06770 Offset: 0x1A02770 VA: 0x1A06770
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrUInt32 : OrInstruction // TypeDefIndex: 5850
{
	// Methods

	// RVA: 0x1A06C98 Offset: 0x1A02C98 VA: 0x1A06C98 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A06778 Offset: 0x1A02778 VA: 0x1A06778
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrUInt64 : OrInstruction // TypeDefIndex: 5851
{
	// Methods

	// RVA: 0x1A06D7C Offset: 0x1A02D7C VA: 0x1A06D7C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A06780 Offset: 0x1A02780 VA: 0x1A06780
	public void .ctor() { }
}

// Namespace: 
private sealed class OrInstruction.OrBoolean : OrInstruction // TypeDefIndex: 5852
{
	// Methods

	// RVA: 0x1A06E60 Offset: 0x1A02E60 VA: 0x1A06E60 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A06788 Offset: 0x1A02788 VA: 0x1A06788
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class OrInstruction : Instruction // TypeDefIndex: 5853
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38
	private static Instruction s_Boolean; // 0x40

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A062EC Offset: 0x1A022EC VA: 0x1A062EC Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A062F4 Offset: 0x1A022F4 VA: 0x1A062F4 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A062FC Offset: 0x1A022FC VA: 0x1A062FC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0633C Offset: 0x1A0233C VA: 0x1A0633C
	private void .ctor() { }

	// RVA: 0x1A06344 Offset: 0x1A02344 VA: 0x1A06344
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftSByte : RightShiftInstruction // TypeDefIndex: 5854
{
	// Methods

	// RVA: 0x1A073F4 Offset: 0x1A033F4 VA: 0x1A073F4 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A073B4 Offset: 0x1A033B4 VA: 0x1A073B4
	public void .ctor() { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftInt16 : RightShiftInstruction // TypeDefIndex: 5855
{
	// Methods

	// RVA: 0x1A074B8 Offset: 0x1A034B8 VA: 0x1A074B8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A073BC Offset: 0x1A033BC VA: 0x1A073BC
	public void .ctor() { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftInt32 : RightShiftInstruction // TypeDefIndex: 5856
{
	// Methods

	// RVA: 0x1A0757C Offset: 0x1A0357C VA: 0x1A0757C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A073C4 Offset: 0x1A033C4 VA: 0x1A073C4
	public void .ctor() { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftInt64 : RightShiftInstruction // TypeDefIndex: 5857
{
	// Methods

	// RVA: 0x1A07640 Offset: 0x1A03640 VA: 0x1A07640 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A073CC Offset: 0x1A033CC VA: 0x1A073CC
	public void .ctor() { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftByte : RightShiftInstruction // TypeDefIndex: 5858
{
	// Methods

	// RVA: 0x1A07718 Offset: 0x1A03718 VA: 0x1A07718 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A073D4 Offset: 0x1A033D4 VA: 0x1A073D4
	public void .ctor() { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftUInt16 : RightShiftInstruction // TypeDefIndex: 5859
{
	// Methods

	// RVA: 0x1A077DC Offset: 0x1A037DC VA: 0x1A077DC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A073DC Offset: 0x1A033DC VA: 0x1A073DC
	public void .ctor() { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftUInt32 : RightShiftInstruction // TypeDefIndex: 5860
{
	// Methods

	// RVA: 0x1A078A0 Offset: 0x1A038A0 VA: 0x1A078A0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A073E4 Offset: 0x1A033E4 VA: 0x1A073E4
	public void .ctor() { }
}

// Namespace: 
private sealed class RightShiftInstruction.RightShiftUInt64 : RightShiftInstruction // TypeDefIndex: 5861
{
	// Methods

	// RVA: 0x1A07978 Offset: 0x1A03978 VA: 0x1A07978 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A073EC Offset: 0x1A033EC VA: 0x1A073EC
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class RightShiftInstruction : Instruction // TypeDefIndex: 5862
{
	// Fields
	private static Instruction s_SByte; // 0x0
	private static Instruction s_Int16; // 0x8
	private static Instruction s_Int32; // 0x10
	private static Instruction s_Int64; // 0x18
	private static Instruction s_Byte; // 0x20
	private static Instruction s_UInt16; // 0x28
	private static Instruction s_UInt32; // 0x30
	private static Instruction s_UInt64; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A06FB0 Offset: 0x1A02FB0 VA: 0x1A06FB0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A06FB8 Offset: 0x1A02FB8 VA: 0x1A06FB8 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A06FC0 Offset: 0x1A02FC0 VA: 0x1A06FC0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A07000 Offset: 0x1A03000 VA: 0x1A07000
	private void .ctor() { }

	// RVA: 0x1A07008 Offset: 0x1A03008 VA: 0x1A07008
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class RuntimeVariables : IRuntimeVariables // TypeDefIndex: 5863
{
	// Fields
	private readonly IStrongBox[] _boxes; // 0x10

	// Methods

	// RVA: 0x1A07A50 Offset: 0x1A03A50 VA: 0x1A07A50
	private void .ctor(IStrongBox[] boxes) { }

	// RVA: 0x19FD0BC Offset: 0x19F90BC VA: 0x19FD0BC
	internal static IRuntimeVariables Create(IStrongBox[] boxes) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadObjectInstruction : Instruction // TypeDefIndex: 5864
{
	// Fields
	private readonly object _value; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A07A80 Offset: 0x1A03A80 VA: 0x1A07A80
	internal void .ctor(object value) { }

	// RVA: 0x1A07AB0 Offset: 0x1A03AB0 VA: 0x1A07AB0 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A07AB8 Offset: 0x1A03AB8 VA: 0x1A07AB8 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A07AF8 Offset: 0x1A03AF8 VA: 0x1A07AF8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A07B74 Offset: 0x1A03B74 VA: 0x1A07B74 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class LoadCachedObjectInstruction : Instruction // TypeDefIndex: 5865
{
	// Fields
	private readonly uint _index; // 0x10

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A07C20 Offset: 0x1A03C20 VA: 0x1A07C20
	internal void .ctor(uint index) { }

	// RVA: 0x1A07C48 Offset: 0x1A03C48 VA: 0x1A07C48 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A07C50 Offset: 0x1A03C50 VA: 0x1A07C50 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A07C90 Offset: 0x1A03C90 VA: 0x1A07C90 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A07D30 Offset: 0x1A03D30 VA: 0x1A07D30 Slot: 10
	public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IReadOnlyList<object> objects) { }

	// RVA: 0x1A07E68 Offset: 0x1A03E68 VA: 0x1A07E68 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class PopInstruction : Instruction // TypeDefIndex: 5866
{
	// Fields
	internal static readonly PopInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A07EE4 Offset: 0x1A03EE4 VA: 0x1A07EE4
	private void .ctor() { }

	// RVA: 0x1A07EEC Offset: 0x1A03EEC VA: 0x1A07EEC Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A07EF4 Offset: 0x1A03EF4 VA: 0x1A07EF4 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A07F34 Offset: 0x1A03F34 VA: 0x1A07F34 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A07F58 Offset: 0x1A03F58 VA: 0x1A07F58
	private static void .cctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class DupInstruction : Instruction // TypeDefIndex: 5867
{
	// Fields
	internal static readonly DupInstruction Instance; // 0x0

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A07FC0 Offset: 0x1A03FC0 VA: 0x1A07FC0
	private void .ctor() { }

	// RVA: 0x1A07FC8 Offset: 0x1A03FC8 VA: 0x1A07FC8 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A07FD0 Offset: 0x1A03FD0 VA: 0x1A07FD0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A08010 Offset: 0x1A04010 VA: 0x1A08010 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A08034 Offset: 0x1A04034 VA: 0x1A08034
	private static void .cctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubInt16 : SubInstruction // TypeDefIndex: 5868
{
	// Methods

	// RVA: 0x1A084E0 Offset: 0x1A044E0 VA: 0x1A084E0 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A084A0 Offset: 0x1A044A0 VA: 0x1A084A0
	public void .ctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubInt32 : SubInstruction // TypeDefIndex: 5869
{
	// Methods

	// RVA: 0x1A08620 Offset: 0x1A04620 VA: 0x1A08620 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A084A8 Offset: 0x1A044A8 VA: 0x1A084A8
	public void .ctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubInt64 : SubInstruction // TypeDefIndex: 5870
{
	// Methods

	// RVA: 0x1A08748 Offset: 0x1A04748 VA: 0x1A08748 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A084B0 Offset: 0x1A044B0 VA: 0x1A084B0
	public void .ctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubUInt16 : SubInstruction // TypeDefIndex: 5871
{
	// Methods

	// RVA: 0x1A08888 Offset: 0x1A04888 VA: 0x1A08888 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A084B8 Offset: 0x1A044B8 VA: 0x1A084B8
	public void .ctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubUInt32 : SubInstruction // TypeDefIndex: 5872
{
	// Methods

	// RVA: 0x1A089C8 Offset: 0x1A049C8 VA: 0x1A089C8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A084C0 Offset: 0x1A044C0 VA: 0x1A084C0
	public void .ctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubUInt64 : SubInstruction // TypeDefIndex: 5873
{
	// Methods

	// RVA: 0x1A08B08 Offset: 0x1A04B08 VA: 0x1A08B08 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A084C8 Offset: 0x1A044C8 VA: 0x1A084C8
	public void .ctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubSingle : SubInstruction // TypeDefIndex: 5874
{
	// Methods

	// RVA: 0x1A08C48 Offset: 0x1A04C48 VA: 0x1A08C48 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A084D0 Offset: 0x1A044D0 VA: 0x1A084D0
	public void .ctor() { }
}

// Namespace: 
private sealed class SubInstruction.SubDouble : SubInstruction // TypeDefIndex: 5875
{
	// Methods

	// RVA: 0x1A08D84 Offset: 0x1A04D84 VA: 0x1A08D84 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A084D8 Offset: 0x1A044D8 VA: 0x1A084D8
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class SubInstruction : Instruction // TypeDefIndex: 5876
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28
	private static Instruction s_Single; // 0x30
	private static Instruction s_Double; // 0x38

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A0809C Offset: 0x1A0409C VA: 0x1A0809C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A080A4 Offset: 0x1A040A4 VA: 0x1A080A4 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A080AC Offset: 0x1A040AC VA: 0x1A080AC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A080EC Offset: 0x1A040EC VA: 0x1A080EC
	private void .ctor() { }

	// RVA: 0x1A080F4 Offset: 0x1A040F4 VA: 0x1A080F4
	public static Instruction Create(Type type) { }
}

// Namespace: 
private sealed class SubOvfInstruction.SubOvfInt16 : SubOvfInstruction // TypeDefIndex: 5877
{
	// Methods

	// RVA: 0x1A09220 Offset: 0x1A05220 VA: 0x1A09220 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A091F0 Offset: 0x1A051F0 VA: 0x1A091F0
	public void .ctor() { }
}

// Namespace: 
private sealed class SubOvfInstruction.SubOvfInt32 : SubOvfInstruction // TypeDefIndex: 5878
{
	// Methods

	// RVA: 0x1A09478 Offset: 0x1A05478 VA: 0x1A09478 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A091F8 Offset: 0x1A051F8 VA: 0x1A091F8
	public void .ctor() { }
}

// Namespace: 
private sealed class SubOvfInstruction.SubOvfInt64 : SubOvfInstruction // TypeDefIndex: 5879
{
	// Methods

	// RVA: 0x1A09694 Offset: 0x1A05694 VA: 0x1A09694 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A09200 Offset: 0x1A05200 VA: 0x1A09200
	public void .ctor() { }
}

// Namespace: 
private sealed class SubOvfInstruction.SubOvfUInt16 : SubOvfInstruction // TypeDefIndex: 5880
{
	// Methods

	// RVA: 0x1A09884 Offset: 0x1A05884 VA: 0x1A09884 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A09208 Offset: 0x1A05208 VA: 0x1A09208
	public void .ctor() { }
}

// Namespace: 
private sealed class SubOvfInstruction.SubOvfUInt32 : SubOvfInstruction // TypeDefIndex: 5881
{
	// Methods

	// RVA: 0x1A09AAC Offset: 0x1A05AAC VA: 0x1A09AAC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A09210 Offset: 0x1A05210 VA: 0x1A09210
	public void .ctor() { }
}

// Namespace: 
private sealed class SubOvfInstruction.SubOvfUInt64 : SubOvfInstruction // TypeDefIndex: 5882
{
	// Methods

	// RVA: 0x1A09C84 Offset: 0x1A05C84 VA: 0x1A09C84 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A09218 Offset: 0x1A05218 VA: 0x1A09218
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class SubOvfInstruction : Instruction // TypeDefIndex: 5883
{
	// Fields
	private static Instruction s_Int16; // 0x0
	private static Instruction s_Int32; // 0x8
	private static Instruction s_Int64; // 0x10
	private static Instruction s_UInt16; // 0x18
	private static Instruction s_UInt32; // 0x20
	private static Instruction s_UInt64; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A08EC0 Offset: 0x1A04EC0 VA: 0x1A08EC0 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A08EC8 Offset: 0x1A04EC8 VA: 0x1A08EC8 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A08ED0 Offset: 0x1A04ED0 VA: 0x1A08ED0 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A08F10 Offset: 0x1A04F10 VA: 0x1A08F10
	private void .ctor() { }

	// RVA: 0x1A08F18 Offset: 0x1A04F18 VA: 0x1A08F18
	public static Instruction Create(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CreateDelegateInstruction : Instruction // TypeDefIndex: 5884
{
	// Fields
	private readonly LightDelegateCreator _creator; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A09E58 Offset: 0x1A05E58 VA: 0x1A09E58
	internal void .ctor(LightDelegateCreator delegateCreator) { }

	// RVA: 0x1A09E88 Offset: 0x1A05E88 VA: 0x1A09E88 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A09EAC Offset: 0x1A05EAC VA: 0x1A09EAC Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A09EB4 Offset: 0x1A05EB4 VA: 0x1A09EB4 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A09EF4 Offset: 0x1A05EF4 VA: 0x1A09EF4 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TypeIsInstruction : Instruction // TypeDefIndex: 5885
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A0A08C Offset: 0x1A0608C VA: 0x1A0A08C
	internal void .ctor(Type type) { }

	// RVA: 0x1A0A0BC Offset: 0x1A060BC VA: 0x1A0A0BC Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A0A0C4 Offset: 0x1A060C4 VA: 0x1A0A0C4 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A0A0CC Offset: 0x1A060CC VA: 0x1A0A0CC Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0A10C Offset: 0x1A0610C VA: 0x1A0A10C Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0A16C Offset: 0x1A0616C VA: 0x1A0A16C Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TypeAsInstruction : Instruction // TypeDefIndex: 5886
{
	// Fields
	private readonly Type _type; // 0x10

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A0A1D4 Offset: 0x1A061D4 VA: 0x1A0A1D4
	internal void .ctor(Type type) { }

	// RVA: 0x1A0A204 Offset: 0x1A06204 VA: 0x1A0A204 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A0A20C Offset: 0x1A0620C VA: 0x1A0A20C Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A0A214 Offset: 0x1A06214 VA: 0x1A0A214 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0A254 Offset: 0x1A06254 VA: 0x1A0A254 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0A2C0 Offset: 0x1A062C0 VA: 0x1A0A2C0 Slot: 3
	public override string ToString() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class TypeEqualsInstruction : Instruction // TypeDefIndex: 5887
{
	// Fields
	public static readonly TypeEqualsInstruction Instance; // 0x0

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A0A328 Offset: 0x1A06328 VA: 0x1A0A328 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A0A330 Offset: 0x1A06330 VA: 0x1A0A330 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A0A338 Offset: 0x1A06338 VA: 0x1A0A338 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0A378 Offset: 0x1A06378 VA: 0x1A0A378
	private void .ctor() { }

	// RVA: 0x1A0A380 Offset: 0x1A06380 VA: 0x1A0A380 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0A3E0 Offset: 0x1A063E0 VA: 0x1A0A3E0
	private static void .cctor() { }
}

// Namespace: 
private sealed class NullableMethodCallInstruction.HasValue : NullableMethodCallInstruction // TypeDefIndex: 5888
{
	// Methods

	// RVA: 0x1A0A8FC Offset: 0x1A068FC VA: 0x1A0A8FC Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0A7F4 Offset: 0x1A067F4 VA: 0x1A0A7F4
	public void .ctor() { }
}

// Namespace: 
private sealed class NullableMethodCallInstruction.GetValue : NullableMethodCallInstruction // TypeDefIndex: 5889
{
	// Methods

	// RVA: 0x1A0A938 Offset: 0x1A06938 VA: 0x1A0A938 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0A7FC Offset: 0x1A067FC VA: 0x1A0A7FC
	public void .ctor() { }
}

// Namespace: 
private sealed class NullableMethodCallInstruction.GetValueOrDefault : NullableMethodCallInstruction // TypeDefIndex: 5890
{
	// Fields
	private readonly Type _defaultValueType; // 0x10

	// Methods

	// RVA: 0x1A0A814 Offset: 0x1A06814 VA: 0x1A0A814
	public void .ctor(MethodInfo mi) { }

	// RVA: 0x1A0A9AC Offset: 0x1A069AC VA: 0x1A0A9AC Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class NullableMethodCallInstruction.GetValueOrDefault1 : NullableMethodCallInstruction // TypeDefIndex: 5891
{
	// Properties
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x1A0AA0C Offset: 0x1A06A0C VA: 0x1A0AA0C Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A0AA14 Offset: 0x1A06A14 VA: 0x1A0AA14 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0A860 Offset: 0x1A06860 VA: 0x1A0A860
	public void .ctor() { }
}

// Namespace: 
private sealed class NullableMethodCallInstruction.EqualsClass : NullableMethodCallInstruction // TypeDefIndex: 5892
{
	// Properties
	public override int ConsumedStack { get; }

	// Methods

	// RVA: 0x1A0AA68 Offset: 0x1A06A68 VA: 0x1A0AA68 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A0AA70 Offset: 0x1A06A70 VA: 0x1A0AA70 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0A804 Offset: 0x1A06804 VA: 0x1A0A804
	public void .ctor() { }
}

// Namespace: 
private sealed class NullableMethodCallInstruction.ToStringClass : NullableMethodCallInstruction // TypeDefIndex: 5893
{
	// Methods

	// RVA: 0x1A0AB38 Offset: 0x1A06B38 VA: 0x1A0AB38 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0A868 Offset: 0x1A06868 VA: 0x1A0A868
	public void .ctor() { }
}

// Namespace: 
private sealed class NullableMethodCallInstruction.GetHashCodeClass : NullableMethodCallInstruction // TypeDefIndex: 5894
{
	// Methods

	// RVA: 0x1A0ABB8 Offset: 0x1A06BB8 VA: 0x1A0ABB8 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: 0x1A0A80C Offset: 0x1A0680C VA: 0x1A0A80C
	public void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class NullableMethodCallInstruction : Instruction // TypeDefIndex: 5895
{
	// Fields
	private static NullableMethodCallInstruction s_hasValue; // 0x0
	private static NullableMethodCallInstruction s_value; // 0x8
	private static NullableMethodCallInstruction s_equals; // 0x10
	private static NullableMethodCallInstruction s_getHashCode; // 0x18
	private static NullableMethodCallInstruction s_getValueOrDefault1; // 0x20
	private static NullableMethodCallInstruction s_toString; // 0x28

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A0A448 Offset: 0x1A06448 VA: 0x1A0A448 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A0A450 Offset: 0x1A06450 VA: 0x1A0A450 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A0A458 Offset: 0x1A06458 VA: 0x1A0A458 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0A498 Offset: 0x1A06498 VA: 0x1A0A498
	private void .ctor() { }

	// RVA: 0x1A0A4A0 Offset: 0x1A064A0 VA: 0x1A0A4A0
	public static Instruction Create(string method, int argCount, MethodInfo mi) { }

	// RVA: 0x1A0A870 Offset: 0x1A06870 VA: 0x1A0A870
	public static Instruction CreateGetValue() { }
}

// Namespace: 
private sealed class CastInstruction.CastInstructionT<T> : CastInstruction // TypeDefIndex: 5896
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 8
	public override int Run(InterpretedFrame frame) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E1490 Offset: 0x14DD490 VA: 0x14E1490
	|-CastInstruction.CastInstructionT<bool>.Run
	|
	|-RVA: 0x14E154C Offset: 0x14DD54C VA: 0x14E154C
	|-CastInstruction.CastInstructionT<byte>.Run
	|
	|-RVA: 0x14E1608 Offset: 0x14DD608 VA: 0x14E1608
	|-CastInstruction.CastInstructionT<char>.Run
	|
	|-RVA: 0x14E16C4 Offset: 0x14DD6C4 VA: 0x14E16C4
	|-CastInstruction.CastInstructionT<DateTime>.Run
	|
	|-RVA: 0x14E1780 Offset: 0x14DD780 VA: 0x14E1780
	|-CastInstruction.CastInstructionT<Decimal>.Run
	|
	|-RVA: 0x14E1888 Offset: 0x14DD888 VA: 0x14E1888
	|-CastInstruction.CastInstructionT<double>.Run
	|
	|-RVA: 0x14E1944 Offset: 0x14DD944 VA: 0x14E1944
	|-CastInstruction.CastInstructionT<short>.Run
	|
	|-RVA: 0x14E1A00 Offset: 0x14DDA00 VA: 0x14E1A00
	|-CastInstruction.CastInstructionT<int>.Run
	|
	|-RVA: 0x14E1ABC Offset: 0x14DDABC VA: 0x14E1ABC
	|-CastInstruction.CastInstructionT<long>.Run
	|
	|-RVA: 0x14E1B78 Offset: 0x14DDB78 VA: 0x14E1B78
	|-CastInstruction.CastInstructionT<object>.Run
	|
	|-RVA: 0x14E1C10 Offset: 0x14DDC10 VA: 0x14E1C10
	|-CastInstruction.CastInstructionT<sbyte>.Run
	|
	|-RVA: 0x14E1CCC Offset: 0x14DDCCC VA: 0x14E1CCC
	|-CastInstruction.CastInstructionT<float>.Run
	|
	|-RVA: 0x14E1D88 Offset: 0x14DDD88 VA: 0x14E1D88
	|-CastInstruction.CastInstructionT<ushort>.Run
	|
	|-RVA: 0x14E1E44 Offset: 0x14DDE44 VA: 0x14E1E44
	|-CastInstruction.CastInstructionT<uint>.Run
	|
	|-RVA: 0x14E1F00 Offset: 0x14DDF00 VA: 0x14E1F00
	|-CastInstruction.CastInstructionT<ulong>.Run
	|
	|-RVA: 0x14E1FBC Offset: 0x14DDFBC VA: 0x14E1FBC
	|-CastInstruction.CastInstructionT<__Il2CppFullySharedGenericType>.Run
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14E1544 Offset: 0x14DD544 VA: 0x14E1544
	|-CastInstruction.CastInstructionT<bool>..ctor
	|
	|-RVA: 0x14E1600 Offset: 0x14DD600 VA: 0x14E1600
	|-CastInstruction.CastInstructionT<byte>..ctor
	|
	|-RVA: 0x14E16BC Offset: 0x14DD6BC VA: 0x14E16BC
	|-CastInstruction.CastInstructionT<char>..ctor
	|
	|-RVA: 0x14E1778 Offset: 0x14DD778 VA: 0x14E1778
	|-CastInstruction.CastInstructionT<DateTime>..ctor
	|
	|-RVA: 0x14E1880 Offset: 0x14DD880 VA: 0x14E1880
	|-CastInstruction.CastInstructionT<Decimal>..ctor
	|
	|-RVA: 0x14E193C Offset: 0x14DD93C VA: 0x14E193C
	|-CastInstruction.CastInstructionT<double>..ctor
	|
	|-RVA: 0x14E19F8 Offset: 0x14DD9F8 VA: 0x14E19F8
	|-CastInstruction.CastInstructionT<short>..ctor
	|
	|-RVA: 0x14E1AB4 Offset: 0x14DDAB4 VA: 0x14E1AB4
	|-CastInstruction.CastInstructionT<int>..ctor
	|
	|-RVA: 0x14E1B70 Offset: 0x14DDB70 VA: 0x14E1B70
	|-CastInstruction.CastInstructionT<long>..ctor
	|
	|-RVA: 0x14E1C08 Offset: 0x14DDC08 VA: 0x14E1C08
	|-CastInstruction.CastInstructionT<object>..ctor
	|
	|-RVA: 0x14E1CC4 Offset: 0x14DDCC4 VA: 0x14E1CC4
	|-CastInstruction.CastInstructionT<sbyte>..ctor
	|
	|-RVA: 0x14E1D80 Offset: 0x14DDD80 VA: 0x14E1D80
	|-CastInstruction.CastInstructionT<float>..ctor
	|
	|-RVA: 0x14E1E3C Offset: 0x14DDE3C VA: 0x14E1E3C
	|-CastInstruction.CastInstructionT<ushort>..ctor
	|
	|-RVA: 0x14E1EF8 Offset: 0x14DDEF8 VA: 0x14E1EF8
	|-CastInstruction.CastInstructionT<uint>..ctor
	|
	|-RVA: 0x14E1FB4 Offset: 0x14DDFB4 VA: 0x14E1FB4
	|-CastInstruction.CastInstructionT<ulong>..ctor
	|
	|-RVA: 0x14E20BC Offset: 0x14DE0BC VA: 0x14E20BC
	|-CastInstruction.CastInstructionT<__Il2CppFullySharedGenericType>..ctor
	*/
}

// Namespace: 
private sealed class CastInstruction.CastInstructionNoT.Ref : CastInstruction.CastInstructionNoT // TypeDefIndex: 5897
{
	// Methods

	// RVA: 0x1A0B414 Offset: 0x1A07414 VA: 0x1A0B414
	public void .ctor(Type t) { }

	// RVA: 0x1A0B594 Offset: 0x1A07594 VA: 0x1A0B594 Slot: 11
	protected override void ConvertNull(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class CastInstruction.CastInstructionNoT.Value : CastInstruction.CastInstructionNoT // TypeDefIndex: 5898
{
	// Methods

	// RVA: 0x1A0B3E4 Offset: 0x1A073E4 VA: 0x1A0B3E4
	public void .ctor(Type t) { }

	// RVA: 0x1A0B5B0 Offset: 0x1A075B0 VA: 0x1A0B5B0 Slot: 11
	protected override void ConvertNull(InterpretedFrame frame) { }
}

// Namespace: 
private abstract class CastInstruction.CastInstructionNoT : CastInstruction // TypeDefIndex: 5899
{
	// Fields
	private readonly Type _t; // 0x10

	// Methods

	// RVA: 0x1A0B3B4 Offset: 0x1A073B4 VA: 0x1A0B3B4
	protected void .ctor(Type t) { }

	// RVA: 0x1A0B2E0 Offset: 0x1A072E0 VA: 0x1A0B2E0
	public static CastInstruction Create(Type t) { }

	// RVA: 0x1A0B444 Offset: 0x1A07444 VA: 0x1A0B444 Slot: 8
	public override int Run(InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 11
	protected abstract void ConvertNull(InterpretedFrame frame);
}

// Namespace: System.Linq.Expressions.Interpreter
internal abstract class CastInstruction : Instruction // TypeDefIndex: 5900
{
	// Fields
	private static CastInstruction s_Boolean; // 0x0
	private static CastInstruction s_Byte; // 0x8
	private static CastInstruction s_Char; // 0x10
	private static CastInstruction s_DateTime; // 0x18
	private static CastInstruction s_Decimal; // 0x20
	private static CastInstruction s_Double; // 0x28
	private static CastInstruction s_Int16; // 0x30
	private static CastInstruction s_Int32; // 0x38
	private static CastInstruction s_Int64; // 0x40
	private static CastInstruction s_SByte; // 0x48
	private static CastInstruction s_Single; // 0x50
	private static CastInstruction s_String; // 0x58
	private static CastInstruction s_UInt16; // 0x60
	private static CastInstruction s_UInt32; // 0x68
	private static CastInstruction s_UInt64; // 0x70

	// Properties
	public override int ConsumedStack { get; }
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A0AC08 Offset: 0x1A06C08 VA: 0x1A0AC08 Slot: 4
	public override int get_ConsumedStack() { }

	// RVA: 0x1A0AC10 Offset: 0x1A06C10 VA: 0x1A0AC10 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A0AC18 Offset: 0x1A06C18 VA: 0x1A0AC18 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0AC58 Offset: 0x1A06C58 VA: 0x1A0AC58
	public static Instruction Create(Type t) { }

	// RVA: 0x1A0B3AC Offset: 0x1A073AC VA: 0x1A0B3AC
	protected void .ctor() { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CastToEnumInstruction : CastInstruction // TypeDefIndex: 5901
{
	// Fields
	private readonly Type _t; // 0x10

	// Methods

	// RVA: 0x1A0B5E8 Offset: 0x1A075E8 VA: 0x1A0B5E8
	public void .ctor(Type t) { }

	// RVA: 0x1A0B618 Offset: 0x1A07618 VA: 0x1A0B618 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class CastReferenceToEnumInstruction : CastInstruction // TypeDefIndex: 5902
{
	// Fields
	private readonly Type _t; // 0x10

	// Methods

	// RVA: 0x1A0B698 Offset: 0x1A07698 VA: 0x1A0B698
	public void .ctor(Type t) { }

	// RVA: 0x1A0B6C8 Offset: 0x1A076C8 VA: 0x1A0B6C8 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
private sealed class QuoteInstruction.ExpressionQuoter : ExpressionVisitor // TypeDefIndex: 5903
{
	// Fields
	private readonly Dictionary<ParameterExpression, LocalVariable> _variables; // 0x10
	private readonly InterpretedFrame _frame; // 0x18
	private readonly Stack<HashSet<ParameterExpression>> _shadowedVars; // 0x20

	// Methods

	// RVA: 0x1A0BC0C Offset: 0x1A07C0C VA: 0x1A0BC0C
	internal void .ctor(Dictionary<ParameterExpression, LocalVariable> hoistedVariables, InterpretedFrame frame) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected internal override Expression VisitLambda<T>(Expression<T> node) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x104D29C Offset: 0x104929C VA: 0x104D29C
	|-QuoteInstruction.ExpressionQuoter.VisitLambda<object>
	|
	|-RVA: 0x104D470 Offset: 0x1049470 VA: 0x104D470
	|-QuoteInstruction.ExpressionQuoter.VisitLambda<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1A0BCC4 Offset: 0x1A07CC4 VA: 0x1A0BCC4 Slot: 6
	protected internal override Expression VisitBlock(BlockExpression node) { }

	// RVA: 0x1A0BE58 Offset: 0x1A07E58 VA: 0x1A0BE58 Slot: 22
	protected override CatchBlock VisitCatchBlock(CatchBlock node) { }

	// RVA: 0x1A0BFF4 Offset: 0x1A07FF4 VA: 0x1A0BFF4 Slot: 21
	protected internal override Expression VisitParameter(ParameterExpression node) { }

	// RVA: 0x1A0C0C0 Offset: 0x1A080C0 VA: 0x1A0C0C0
	private IStrongBox GetBox(ParameterExpression variable) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal sealed class QuoteInstruction : Instruction // TypeDefIndex: 5904
{
	// Fields
	private readonly Expression _operand; // 0x10
	private readonly Dictionary<ParameterExpression, LocalVariable> _hoistedVariables; // 0x18

	// Properties
	public override int ProducedStack { get; }
	public override string InstructionName { get; }

	// Methods

	// RVA: 0x1A0BADC Offset: 0x1A07ADC VA: 0x1A0BADC
	public void .ctor(Expression operand, Dictionary<ParameterExpression, LocalVariable> hoistedVariables) { }

	// RVA: 0x1A0BB20 Offset: 0x1A07B20 VA: 0x1A0BB20 Slot: 5
	public override int get_ProducedStack() { }

	// RVA: 0x1A0BB28 Offset: 0x1A07B28 VA: 0x1A0BB28 Slot: 9
	public override string get_InstructionName() { }

	// RVA: 0x1A0BB68 Offset: 0x1A07B68 VA: 0x1A0BB68 Slot: 8
	public override int Run(InterpretedFrame frame) { }
}

// Namespace: 
[CompilerGenerated]
[Serializable]
private sealed class DelegateHelpers.<>c // TypeDefIndex: 5905
{
	// Fields
	public static readonly DelegateHelpers.<>c <>9; // 0x0
	public static Func<Type, bool> <>9__1_0; // 0x8

	// Methods

	// RVA: 0x1A0C1D0 Offset: 0x1A081D0 VA: 0x1A0C1D0
	private static void .cctor() { }

	// RVA: 0x1A0C238 Offset: 0x1A08238 VA: 0x1A0C238
	public void .ctor() { }

	// RVA: 0x1A0C240 Offset: 0x1A08240 VA: 0x1A0C240
	internal bool <MakeDelegate>b__1_0(Type t) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal static class DelegateHelpers // TypeDefIndex: 5906
{
	// Methods

	// RVA: 0x19F95C0 Offset: 0x19F55C0 VA: 0x19F95C0
	internal static Type MakeDelegate(Type[] types) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal static class ScriptingRuntimeHelpers // TypeDefIndex: 5907
{
	// Methods

	// RVA: 0x19FE0B8 Offset: 0x19FA0B8 VA: 0x19FE0B8
	public static object Int32ToObject(int i) { }

	// RVA: 0x1A0C258 Offset: 0x1A08258 VA: 0x1A0C258
	internal static object GetPrimitiveDefaultValue(Type type) { }
}

// Namespace: System.Linq.Expressions.Interpreter
internal static class ExceptionHelpers // TypeDefIndex: 5908
{
	// Methods

	// RVA: 0x19F81E4 Offset: 0x19F41E4 VA: 0x19F81E4
	public static void UnwrapAndRethrow(TargetInvocationException exception) { }
}

// Namespace: 
[CompilerGenerated]
private sealed class HybridReferenceDictionary.<GetEnumeratorWorker>d__7<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator // TypeDefIndex: 5909
{
	// Fields
	private int <>1__state; // 0x0
	private KeyValuePair<TKey, TValue> <>2__current; // 0x0
	public HybridReferenceDictionary<TKey, TValue> <>4__this; // 0x0
	private int <i>5__2; // 0x0

	// Properties
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1166BC4 Offset: 0x1162BC4 VA: 0x1166BC4
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, object>..ctor
	|
	|-RVA: 0x1166D18 Offset: 0x1162D18 VA: 0x1166D18
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1166BEC Offset: 0x1162BEC VA: 0x1166BEC
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, object>.System.IDisposable.Dispose
	|
	|-RVA: 0x1166D58 Offset: 0x1162D58 VA: 0x1166D58
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1166BF0 Offset: 0x1162BF0 VA: 0x1166BF0
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, object>.MoveNext
	|
	|-RVA: 0x1166D5C Offset: 0x1162D5C VA: 0x1166D5C
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, __Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1166CA8 Offset: 0x1162CA8 VA: 0x1166CA8
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|
	|-RVA: 0x1167024 Offset: 0x1163024 VA: 0x1167024
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1166CB4 Offset: 0x1162CB4 VA: 0x1166CB4
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1167068 Offset: 0x1163068 VA: 0x1167068
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1166CE8 Offset: 0x1162CE8 VA: 0x1166CE8
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x116709C Offset: 0x116309C VA: 0x116709C
	|-HybridReferenceDictionary.<GetEnumeratorWorker>d__7<object, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}

// Namespace: System.Linq.Expressions.Interpreter
[DefaultMember("Item")]
internal class HybridReferenceDictionary<TKey, TValue> // TypeDefIndex: 5910
{
	// Fields
	private KeyValuePair<TKey, TValue>[] _keysAndValues; // 0x0
	private Dictionary<TKey, TValue> _dict; // 0x0

	// Properties
	public TValue Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127A9EC Offset: 0x12769EC VA: 0x127A9EC
	|-HybridReferenceDictionary<object, object>.TryGetValue
	|
	|-RVA: 0x127AF0C Offset: 0x1276F0C VA: 0x127AF0C
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public void Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127AA68 Offset: 0x1276A68 VA: 0x127AA68
	|-HybridReferenceDictionary<object, object>.Remove
	|
	|-RVA: 0x127B100 Offset: 0x1277100 VA: 0x127B100
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127AAC0 Offset: 0x1276AC0 VA: 0x127AAC0
	|-HybridReferenceDictionary<object, object>.ContainsKey
	|
	|-RVA: 0x127B210 Offset: 0x1277210 VA: 0x127B210
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127AB1C Offset: 0x1276B1C VA: 0x127AB1C
	|-HybridReferenceDictionary<object, object>.GetEnumerator
	|
	|-RVA: 0x127B2FC Offset: 0x12772FC VA: 0x127B2FC
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	[IteratorStateMachine(typeof(HybridReferenceDictionary.<GetEnumeratorWorker>d__7<TKey, TValue>))]
	// RVA: -1 Offset: -1
	private IEnumerator<KeyValuePair<TKey, TValue>> GetEnumeratorWorker() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127AB98 Offset: 0x1276B98 VA: 0x127AB98
	|-HybridReferenceDictionary<object, object>.GetEnumeratorWorker
	|
	|-RVA: 0x127B3D0 Offset: 0x12773D0 VA: 0x127B3D0
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.GetEnumeratorWorker
	*/

	// RVA: -1 Offset: -1
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127AC14 Offset: 0x1276C14 VA: 0x127AC14
	|-HybridReferenceDictionary<object, object>.get_Item
	|
	|-RVA: 0x127B460 Offset: 0x1277460 VA: 0x127B460
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127ACBC Offset: 0x1276CBC VA: 0x127ACBC
	|-HybridReferenceDictionary<object, object>.set_Item
	|
	|-RVA: 0x127B59C Offset: 0x127759C VA: 0x127B59C
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x127AF04 Offset: 0x1276F04 VA: 0x127AF04
	|-HybridReferenceDictionary<object, object>..ctor
	|
	|-RVA: 0x127BBA4 Offset: 0x1277BA4 VA: 0x127BBA4
	|-HybridReferenceDictionary<object, __Il2CppFullySharedGenericType>..ctor
	*/
}
