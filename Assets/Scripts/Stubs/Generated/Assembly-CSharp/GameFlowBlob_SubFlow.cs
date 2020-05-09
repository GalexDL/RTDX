/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[GameFlowBlob] // 0x00608DD0-0x00608E10
public class GameFlowBlob_SubFlow : GameFlowBlobBase // TypeDefIndex: 4711
{
	// Fields
	public Body BodyData; // 0x18
	public GameFlowBlobList BlobList; // 0x20

	// Properties
	public override string DebugMenuNameRaw { get => default; } // 0x00A5B760-0x00A5B770 
	public override string DebugMenuNameTextId { get => default; set {} } // 0x00A5B770-0x00A5B780 0x00A5B780-0x00A5B790
	public override string FlowId { get => default; set {} } // 0x00A5B8D0-0x00A5B8E0 0x00A5B8E0-0x00A5B8F0

	// Nested types
	[Serializable]
	public class Body // TypeDefIndex: 4712
	{
		// Fields
		public string id; // 0x10
		public string subFlowId; // 0x18
		public string debugName; // 0x20
		public string debugNameTextId; // 0x28

		// Constructors
		public Body() {} // 0x00A5BBE0-0x00A5BC40
	}

	// Constructors
	public GameFlowBlob_SubFlow() {} // 0x00A5BB10-0x00A5BBE0

	// Methods
	// [IteratorStateMachine] // 0x0061AFA0-0x0061B010
	public override IEnumerable<GameFlowBlobList> EnumOwnGameFlowBlobListTbl() => default; // 0x00A5B6A0-0x00A5B720
	public override string SerializeHumanText(string indent) => default; // 0x00A5B790-0x00A5B850
	public override void DeserializeHumanText(ref Queue<string> lines) {} // 0x00A5B850-0x00A5B8D0
	public override bool TrySetupExecPointer(GameFlowExecStack execStack, IGameFlowPlayable findBlob) => default; // 0x00A5B8F0-0x00A5B910
	// [IteratorStateMachine] // 0x0061B010-0x0061B080
	public override IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00A5B910-0x00A5B990
	public override IGameFlowPlayable Find(Func<IGameFlowPlayable, bool> compFunc) => default; // 0x00A5B9C0-0x00A5BA50
	public override void Foreach(Action<IGameFlowPlayable> action) {} // 0x00A5BA50-0x00A5BAC0
	public override void Foreach(Stack<List<IGameFlowPlayable>> stack, Action<Stack<List<IGameFlowPlayable>>> action) {} // 0x00A5BAC0-0x00A5BB10
}

