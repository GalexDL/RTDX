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
	[ActCommand] // 0x0060D130-0x0060D1B0
	public class ActCommand_WipeBoss : ActCommand_Basic // TypeDefIndex: 8884
	{
		// Fields
		public bool isWait; // 0x28
	
		// Constructors
		public ActCommand_WipeBoss() {} // 0x00A99BA0-0x00A99BB0
	
		// Methods
		// [IteratorStateMachine] // 0x0063DD70-0x0063DDE0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A99A40-0x00A99AC0
		// [IteratorStateMachine] // 0x0063DDE0-0x0063DE50
		private IEnumerator animFunc_(ScriptDataPlayer.PlayerTaskSys.TaskContext info) => default; // 0x00A99AF0-0x00A99B60
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A99B90-0x00A99BA0
	}
}
