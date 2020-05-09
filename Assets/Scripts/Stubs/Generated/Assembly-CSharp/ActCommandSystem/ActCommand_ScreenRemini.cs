/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[ActCommand] // 0x0060D1B0-0x0060D230
	public class ActCommand_ScreenRemini : ActCommand_Basic // TypeDefIndex: 8888
	{
		// Fields
		public Mode mode; // 0x28
	
		// Nested types
		public enum Mode // TypeDefIndex: 8889
		{
			Start = 0,
			End = 1
		}
	
		// Constructors
		public ActCommand_ScreenRemini() {} // 0x00A90340-0x00A90350
	
		// Methods
		// [IteratorStateMachine] // 0x0063DE50-0x0063DEC0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A901E0-0x00A90260
		// [IteratorStateMachine] // 0x0063DEC0-0x0063DF30
		private IEnumerator animFunc_(ScriptDataPlayer.PlayerTaskSys.TaskContext info) => default; // 0x00A90290-0x00A90300
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A90330-0x00A90340
	}
}
