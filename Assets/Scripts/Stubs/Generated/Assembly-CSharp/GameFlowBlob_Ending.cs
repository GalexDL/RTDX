/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[GameFlowBlob] // 0x00609150-0x00609190
public class GameFlowBlob_Ending : GameFlowBlobBase // TypeDefIndex: 4771
{
	// Fields
	public Body BodyData; // 0x18

	// Properties
	public override string FlowId { get => default; set {} } // 0x00BB90E0-0x00BB90F0 0x00BB90F0-0x00BB9100

	// Nested types
	[Serializable]
	public class Body // TypeDefIndex: 4772
	{
		// Fields
		public string id; // 0x10

		// Constructors
		public Body() {} // 0x00BB9260-0x00BB92C0
	}

	[Serializable]
	private class SuspendDataEnding_ // TypeDefIndex: 4773
	{
		// Constructors
		public SuspendDataEnding_() {} // 0x00BB9480-0x00BB9490
	}

	// Constructors
	public GameFlowBlob_Ending() {} // 0x00BB91B0-0x00BB9260

	// Methods
	public override string SerializeHumanText(string indent) => default; // 0x00BB8FD0-0x00BB9070
	public override void DeserializeHumanText(ref Queue<string> lines) {} // 0x00BB9070-0x00BB90E0
	// [IteratorStateMachine] // 0x0061B940-0x0061B9B0
	public override IEnumerator PlayLoop(GameFlowPlayContext context, Func<bool> needExit) => default; // 0x00BB9100-0x00BB9180
}

