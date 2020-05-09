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
	[ActCommand] // 0x0060B4D0-0x0060B550
	public class ActCommand_TaskExec : ActCommand_Basic // TypeDefIndex: 8750
	{
		// Fields
		public bool isWait; // 0x28
		public string refTaskName; // 0x30
	
		// Constructors
		public ActCommand_TaskExec() {} // 0x00A97BB0-0x00A97C10
	
		// Methods
		// [IteratorStateMachine] // 0x0063C250-0x0063C2C0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A976B0-0x00A97730
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A97760-0x00A977C0
	}
}
