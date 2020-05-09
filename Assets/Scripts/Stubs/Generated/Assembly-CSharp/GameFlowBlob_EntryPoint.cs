/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[GameFlowBlob] // 0x00608D10-0x00608D50
public class GameFlowBlob_EntryPoint : GameFlowBlobBase // TypeDefIndex: 4702
{
	// Fields
	public string id; // 0x18
	public string debugName; // 0x20
	public string debugNameTextId; // 0x28
	public string entryLabel; // 0x30

	// Properties
	public override string FlowId { get => default; set {} } // 0x00BB9520-0x00BB9530 0x00BB9530-0x00BB9540
	public override string DebugMenuNameRaw { get => default; } // 0x00BB95E0-0x00BB95F0 
	public override string DebugMenuNameTextId { get => default; set {} } // 0x00BB95F0-0x00BB9600 0x00BB9600-0x00BB9610

	// Constructors
	public GameFlowBlob_EntryPoint() {} // 0x00BB9610-0x00BB9680

	// Methods
	public override bool TrySetupExecPointer(GameFlowExecStack execStack, IGameFlowPlayable findBlob) => default; // 0x00BB9540-0x00BB9550
	// [IteratorStateMachine] // 0x0061ADE0-0x0061AE50
	public override IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00BB9550-0x00BB95B0
}

