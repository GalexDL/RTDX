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
	[ActCommand] // 0x0060B690-0x0060B6D0
	public class ActCommand_SleepRandom : ActCommand_Basic // TypeDefIndex: 8761
	{
		// Fields
		public float timeRangeSec; // 0x28
		public bool isTaskEndMark; // 0x2C
	
		// Constructors
		public ActCommand_SleepRandom() {} // 0x00A93C00-0x00A93C20
	
		// Methods
		// [IteratorStateMachine] // 0x0063C480-0x0063C4F0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A93B40-0x00A93BC0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A93BF0-0x00A93C00
	}
}
