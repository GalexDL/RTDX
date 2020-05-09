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
	[ActCommand] // 0x0060CBB0-0x0060CC00
	public class ActCommand_WaitMe : ActCommand_Basic // TypeDefIndex: 8847
	{
		// Constructors
		public ActCommand_WaitMe() {} // 0x00A99100-0x00A99110
	
		// Methods
		// [IteratorStateMachine] // 0x0063D600-0x0063D670
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A99050-0x00A990C0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A990F0-0x00A99100
	}
}
