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
	[ActCommand] // 0x0060CB20-0x0060CB70
	public class ActCommand_WaitSe : ActCommand_Basic // TypeDefIndex: 8843
	{
		// Fields
		public string symbol; // 0x28
	
		// Constructors
		public ActCommand_WaitSe() {} // 0x00A99570-0x00A995D0
	
		// Methods
		// [IteratorStateMachine] // 0x0063D520-0x0063D590
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A994B0-0x00A99530
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A99560-0x00A99570
	}
}
