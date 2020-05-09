/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[GameFlowBlob] // 0x00608D90-0x00608DD0
public class GameFlowBlob_BOX : GameFlowBlobBase // TypeDefIndex: 4706
{
	// Fields
	public Body BodyData; // 0x18
	public GameFlowBlobList BlobList; // 0x20

	// Properties
	public override string DebugMenuNameRaw { get => default; } // 0x00BB3550-0x00BB3560 
	public override string DebugMenuNameTextId { get => default; set {} } // 0x00BB3560-0x00BB3570 0x00BB3570-0x00BB3580
	public override string FlowId { get => default; set {} } // 0x00BB39F0-0x00BB3A00 0x00BB3A00-0x00BB3A10

	// Nested types
	[Serializable]
	public class Body // TypeDefIndex: 4707
	{
		// Fields
		public string debugName; // 0x10
		public string debugNameTextId; // 0x18
		public string id; // 0x20

		// Constructors
		public Body() {} // 0x00BB3B40-0x00BB3BA0
	}

	// Constructors
	public GameFlowBlob_BOX() {} // 0x00BB3A10-0x00BB3B40

	// Methods
	// [IteratorStateMachine] // 0x0061AEC0-0x0061AF30
	public override IEnumerable<GameFlowBlobList> EnumOwnGameFlowBlobListTbl() => default; // 0x00BB3580-0x00BB3600
	public override string SerializeHumanText(string indent) => default; // 0x00BB3640-0x00BB3700
	public override void DeserializeHumanText(ref Queue<string> lines) {} // 0x00BB3700-0x00BB3780
	public override bool TrySetupExecPointer(GameFlowExecStack execStack, IGameFlowPlayable findBlob) => default; // 0x00BB3780-0x00BB37A0
	// [IteratorStateMachine] // 0x0061AF30-0x0061AFA0
	public override IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00BB37A0-0x00BB3820
	public override IGameFlowPlayable Find(Func<IGameFlowPlayable, bool> compFunc) => default; // 0x00BB3850-0x00BB38E0
	public override void Foreach(Action<IGameFlowPlayable> action) {} // 0x00BB38E0-0x00BB3950
	public override void Foreach(Stack<List<IGameFlowPlayable>> stack, Action<Stack<List<IGameFlowPlayable>>> action) {} // 0x00BB3950-0x00BB39F0
}

