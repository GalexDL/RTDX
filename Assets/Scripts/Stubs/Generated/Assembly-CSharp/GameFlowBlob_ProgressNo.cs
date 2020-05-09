/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[GameFlowBlob] // 0x00608D50-0x00608D90
public class GameFlowBlob_ProgressNo : GameFlowBlobBase // TypeDefIndex: 4704
{
	// Fields
	public string id; // 0x18
	public string progressNo; // 0x20
	public string debugName; // 0x28

	// Properties
	public override string FlowId { get => default; set {} } // 0x00BBBF70-0x00BBBF80 0x00BBBF80-0x00BBBF90

	// Constructors
	public GameFlowBlob_ProgressNo() {} // 0x00BBC590-0x00BBC600

	// Methods
	public override bool TrySetupExecPointer(GameFlowExecStack execStack, IGameFlowPlayable findBlob) => default; // 0x00BBBF90-0x00BBBFA0
	// [IteratorStateMachine] // 0x0061AE50-0x0061AEC0
	public override IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00BBBFA0-0x00BBC010
	public override string SerializeHumanText(string indent) => default; // 0x00BBC010-0x00BBC0B0
	public override void DeserializeHumanText(ref Queue<string> lines) {} // 0x00BBC0B0-0x00BBC300
	private void DeserializeAfter_ProgressNo(string data) {} // 0x00BBC300-0x00BBC590
}

