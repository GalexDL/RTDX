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
	[ActCommand] // 0x0060B440-0x0060B490
	public class ActCommand_Empty : ActCommand_Basic // TypeDefIndex: 8745
	{
		// Constructors
		public ActCommand_Empty() {} // 0x008E22B0-0x008E2340
	
		// Methods
		// [IteratorStateMachine] // 0x0063C170-0x0063C1E0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E2210-0x008E2270
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E22A0-0x008E22B0
	}
}
