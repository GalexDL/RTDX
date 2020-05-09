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
	[ActCommand] // 0x0060D430-0x0060D4B0
	public class ActCommand_HintPopup : ActCommand_Basic // TypeDefIndex: 8909
	{
		// Fields
		public string hintLabel; // 0x28
	
		// Constructors
		public ActCommand_HintPopup() {} // 0x008E3490-0x008E3550
	
		// Methods
		// [IteratorStateMachine] // 0x0063E0F0-0x0063E160
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E33E0-0x008E3450
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E3480-0x008E3490
	}
}
