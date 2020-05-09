/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[GameFlowBlob] // 0x00608F50-0x00608F90
public class GameFlowBlob_GeneralLoop : GameFlowBlobBase // TypeDefIndex: 4752
{
	// Fields
	public Body BodyData; // 0x18
	public GameFlowBlobList BlobList; // 0x20

	// Properties
	public override string DebugMenuNameRaw { get => default; } // 0x00BB9740-0x00BB9750 
	public override string DebugMenuNameTextId { get => default; set {} } // 0x00BB9750-0x00BB9760 0x00BB9760-0x00BB9770
	public override string FlowId { get => default; set {} } // 0x00BB9BE0-0x00BB9BF0 0x00BB9BF0-0x00BB9C00

	// Nested types
	[Serializable]
	public class Body // TypeDefIndex: 4753
	{
		// Fields
		public string debugName; // 0x10
		public string debugNameTextId; // 0x18
		public string id; // 0x20

		// Constructors
		public Body() {} // 0x00BB9D30-0x00BB9D90
	}

	// Constructors
	public GameFlowBlob_GeneralLoop() {} // 0x00BB9C00-0x00BB9D30

	// Methods
	// [IteratorStateMachine] // 0x0061B550-0x0061B5C0
	public override IEnumerable<GameFlowBlobList> EnumOwnGameFlowBlobListTbl() => default; // 0x00BB9770-0x00BB97F0
	public override string SerializeHumanText(string indent) => default; // 0x00BB9830-0x00BB98F0
	public override void DeserializeHumanText(ref Queue<string> lines) {} // 0x00BB98F0-0x00BB9970
	public override bool TrySetupExecPointer(GameFlowExecStack execStack, IGameFlowPlayable findBlob) => default; // 0x00BB9970-0x00BB9990
	// [IteratorStateMachine] // 0x0061B5C0-0x0061B630
	public override IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00BB9990-0x00BB9A10
	public override IGameFlowPlayable Find(Func<IGameFlowPlayable, bool> compFunc) => default; // 0x00BB9A40-0x00BB9AD0
	public override void Foreach(Action<IGameFlowPlayable> action) {} // 0x00BB9AD0-0x00BB9B40
	public override void Foreach(Stack<List<IGameFlowPlayable>> stack, Action<Stack<List<IGameFlowPlayable>>> action) {} // 0x00BB9B40-0x00BB9BE0
}

