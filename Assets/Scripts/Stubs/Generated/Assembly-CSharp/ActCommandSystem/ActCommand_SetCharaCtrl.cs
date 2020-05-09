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
	[ActCommand] // 0x0060BF40-0x0060BFE0
	public class ActCommand_SetCharaCtrl : ActCommand_Basic // TypeDefIndex: 8800
	{
		// Fields
		public bool autoFitGroundOff; // 0x28
	
		// Constructors
		public ActCommand_SetCharaCtrl() {} // 0x00A90BD0-0x00A90BE0
	
		// Methods
		// [IteratorStateMachine] // 0x0063CBF0-0x0063CC60
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A90B00-0x00A90B80
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x00A90BB0-0x00A90BC0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A90BC0-0x00A90BD0
	}
}
