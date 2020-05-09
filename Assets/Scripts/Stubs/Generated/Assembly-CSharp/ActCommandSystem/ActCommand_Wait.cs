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
	[ActCommand] // 0x0060BB20-0x0060BBD0
	public class ActCommand_Wait : ActCommand_Basic // TypeDefIndex: 8787
	{
		// Fields
		public bool waitMove; // 0x28
		public bool waitRotation; // 0x29
		public bool waitMotion; // 0x2A
		public bool waitNeck; // 0x2B
		public bool waitManpu; // 0x2C
		public bool isTaskEndMark; // 0x2D
	
		// Constructors
		public ActCommand_Wait() {} // 0x00A97F00-0x00A97F10
	
		// Methods
		// [IteratorStateMachine] // 0x0063C950-0x0063C9C0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A97E40-0x00A97EC0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A97EF0-0x00A97F00
	}
}
