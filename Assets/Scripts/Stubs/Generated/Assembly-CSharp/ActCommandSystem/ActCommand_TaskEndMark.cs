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
	[ActCommand] // 0x0060B5D0-0x0060B610
	public class ActCommand_TaskEndMark : ActCommand_Basic // TypeDefIndex: 8755
	{
		// Constructors
		public ActCommand_TaskEndMark() {} // 0x00A975E0-0x00A975F0
	
		// Methods
		// [IteratorStateMachine] // 0x0063C330-0x0063C3A0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A97540-0x00A975A0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A975D0-0x00A975E0
	}
}
