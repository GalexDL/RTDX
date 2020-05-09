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
	[ActCommand] // 0x0060C4F0-0x0060C570
	public class ActCommand_SetManpu : ActCommand_Basic // TypeDefIndex: 8819
	{
		// Fields
		public bool isWait; // 0x28
		public string symbol; // 0x30
	
		// Constructors
		public ActCommand_SetManpu() {} // 0x00A92080-0x00A920E0
	
		// Methods
		// [IteratorStateMachine] // 0x0063CFE0-0x0063D050
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A91FC0-0x00A92040
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A92070-0x00A92080
	}
}
