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
	[ActCommand] // 0x0060C5F0-0x0060C6C0
	public class ActCommand_SetVisible : ActCommand_Basic // TypeDefIndex: 8823
	{
		// Fields
		public bool visible; // 0x28
	
		// Constructors
		public ActCommand_SetVisible() {} // 0x00A93210-0x00A93220
	
		// Methods
		// [IteratorStateMachine] // 0x0063D0C0-0x0063D130
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A93150-0x00A931D0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A93200-0x00A93210
	}
}
