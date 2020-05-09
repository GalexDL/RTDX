/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class GameFlowBlobBase_WithFlowBlobListTbl : GameFlowBlobBase // TypeDefIndex: 4700
{
	// Fields
	public NamedGameFlowBlobListTbl Flow_BlobListTbl; // 0x18

	// Constructors
	public GameFlowBlobBase_WithFlowBlobListTbl() {} // 0x00BB1C90-0x00BB1D00

	// Methods
	// [IteratorStateMachine] // 0x0061AD70-0x0061ADE0
	public override IEnumerable<GameFlowBlobList> EnumOwnGameFlowBlobListTbl() => default; // 0x00BB1960-0x00BB19E0
	public override string SerializeHumanText(string indent) => default; // 0x00BB1A20-0x00BB1AC0
	public override void DeserializeHumanText(ref Queue<string> lines) {} // 0x00BB1AC0-0x00BB1AD0
	public override bool TrySetupExecPointer(GameFlowExecStack execStack, IGameFlowPlayable findBlob) => default; // 0x00BB1AD0-0x00BB1AF0
	public override IGameFlowPlayable Find(Func<IGameFlowPlayable, bool> compFunc) => default; // 0x00BB1AF0-0x00BB1B80
	public override void Foreach(Action<IGameFlowPlayable> action) {} // 0x00BB1B80-0x00BB1BF0
	public override void Foreach(Stack<List<IGameFlowPlayable>> stack, Action<Stack<List<IGameFlowPlayable>>> action) {} // 0x00BB1BF0-0x00BB1C90
}

