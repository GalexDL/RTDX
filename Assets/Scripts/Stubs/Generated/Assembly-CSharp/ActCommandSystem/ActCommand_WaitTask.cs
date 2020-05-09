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
	[ActCommand] // 0x0060B550-0x0060B5D0
	public class ActCommand_WaitTask : ActCommand_Basic // TypeDefIndex: 8753
	{
		// Fields
		public string refTaskName; // 0x28
	
		// Constructors
		public ActCommand_WaitTask() {} // 0x00A99860-0x00A998C0
	
		// Methods
		// [IteratorStateMachine] // 0x0063C2C0-0x0063C330
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A99760-0x00A997E0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A99810-0x00A99860
	}
}
