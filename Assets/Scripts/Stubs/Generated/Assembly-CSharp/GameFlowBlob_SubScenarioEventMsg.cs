/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[GameFlowBlob] // 0x006091D0-0x00609210
public class GameFlowBlob_SubScenarioEventMsg : GameFlowBlobBase // TypeDefIndex: 4778
{
	// Fields
	public Body BodyData; // 0x18

	// Nested types
	[Serializable]
	public class Body // TypeDefIndex: 4779
	{
		// Fields
		public string msgType; // 0x10

		// Constructors
		public Body() {} // 0x00A5D430-0x00A5D490
	}

	public enum MsgType // TypeDefIndex: 4780
	{
		MsgSubFlow_End = 0,
		MsgSubFlow_DgFailed = 100,
		MsgSubFlow_DgFailedEscape = 200
	}

	// Constructors
	public GameFlowBlob_SubScenarioEventMsg() {} // 0x00A5D380-0x00A5D430

	// Methods
	public override string SerializeHumanText(string indent) => default; // 0x00A5D1C0-0x00A5D260
	public override void DeserializeHumanText(ref Queue<string> lines) {} // 0x00A5D260-0x00A5D2D0
	// [IteratorStateMachine] // 0x0061BA20-0x0061BA90
	public override IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00A5D2D0-0x00A5D350
}

