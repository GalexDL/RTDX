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
	[ActCommand] // 0x0060B490-0x0060B4D0
	public class ActCommand_FuncRef : ActCommand_Basic // TypeDefIndex: 8747
	{
		// Fields
		public string refFuncName; // 0x28
	
		// Constructors
		public ActCommand_FuncRef() {} // 0x008E25E0-0x008E26A0
	
		// Methods
		// [IteratorStateMachine] // 0x0063C1E0-0x0063C250
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E2400-0x008E2480
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E24B0-0x008E25E0
	}
}
