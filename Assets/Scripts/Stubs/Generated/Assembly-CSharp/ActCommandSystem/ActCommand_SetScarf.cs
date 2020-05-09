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
	[ActCommand] // 0x0060C740-0x0060C7F0
	public class ActCommand_SetScarf : ActCommand_Basic // TypeDefIndex: 8827
	{
		// Fields
		public bool visible; // 0x28
	
		// Constructors
		public ActCommand_SetScarf() {} // 0x00A92CD0-0x00A92CE0
	
		// Methods
		// [IteratorStateMachine] // 0x0063D1A0-0x0063D210
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A92C10-0x00A92C90
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A92CC0-0x00A92CD0
	}
}
