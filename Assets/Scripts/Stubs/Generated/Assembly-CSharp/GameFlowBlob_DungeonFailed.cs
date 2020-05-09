/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[GameFlowBlob] // 0x00609090-0x006090D0
public class GameFlowBlob_DungeonFailed : GameFlowBlobBase // TypeDefIndex: 4765
{
	// Fields
	public const string NotifyMsg = "MsgDungeonFailed"; // Metadata: 0x00610B12

	// Constructors
	public GameFlowBlob_DungeonFailed() {} // 0x00BB8C50-0x00BB8C60

	// Methods
	public override string SerializeHumanText(string indent) => default; // 0x00BB8B50-0x00BB8BA0
	public override void DeserializeHumanText(ref Queue<string> lines) {} // 0x00BB8BA0-0x00BB8BB0
	// [IteratorStateMachine] // 0x0061B7F0-0x0061B860
	public override IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00BB8BB0-0x00BB8C20
}

