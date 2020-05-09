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
	[ActCommand] // 0x0060B650-0x0060B690
	public class ActCommand_SleepTaskEnd : ActCommand_Basic // TypeDefIndex: 8759
	{
		// Fields
		public float timeSec; // 0x28
	
		// Constructors
		public ActCommand_SleepTaskEnd() {} // 0x00A93E40-0x00A93E50
	
		// Methods
		// [IteratorStateMachine] // 0x0063C410-0x0063C480
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A93D80-0x00A93E00
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A93E30-0x00A93E40
	}
}
