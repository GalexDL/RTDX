/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[ActCommand] // 0x0060D330-0x0060D3B0
	public class ActCommand_WorldMapMove : ActCommand_Basic // TypeDefIndex: 8905
	{
		// Fields
		public string dgIndex; // 0x28
	
		// Constructors
		public ActCommand_WorldMapMove() {} // 0x00A9A390-0x00A9A3A0
	
		// Methods
		// [IteratorStateMachine] // 0x0063E010-0x0063E080
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A9A2E0-0x00A9A350
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A9A380-0x00A9A390
	}
}
