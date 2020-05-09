/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[GameFlowBlob] // 0x00608E10-0x00608E50
public class GameFlowBlob_CallSubFlow : GameFlowBlobBase // TypeDefIndex: 4716
{
	// Fields
	public string id; // 0x18
	public string debugName; // 0x20
	public string debugNameTextId; // 0x28
	public string subFlowId; // 0x30

	// Properties
	public override string FlowId { get => default; set {} } // 0x00BB4310-0x00BB4320 0x00BB4320-0x00BB4330
	public override string DebugMenuNameRaw { get => default; } // 0x00BB43F0-0x00BB4400 
	public override string DebugMenuNameTextId { get => default; set {} } // 0x00BB4400-0x00BB4410 0x00BB4410-0x00BB4420

	// Constructors
	public GameFlowBlob_CallSubFlow() {} // 0x00BB4420-0x00BB4490

	// Methods
	public override bool TrySetupExecPointer(GameFlowExecStack execStack, IGameFlowPlayable findBlob) => default; // 0x00BB4330-0x00BB4340
	// [IteratorStateMachine] // 0x0061B080-0x0061B0F0
	public override IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00BB4340-0x00BB43C0
}

