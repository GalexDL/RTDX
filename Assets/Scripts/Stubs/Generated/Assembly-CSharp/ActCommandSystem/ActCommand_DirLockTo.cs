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
	[ActCommand] // 0x0060C060-0x0060C0E0
	public class ActCommand_DirLockTo : ActCommand_Basic // TypeDefIndex: 8804
	{
		// Fields
		public bool isReset; // 0x28
		public string lockToSymbol; // 0x30
	
		// Constructors
		public ActCommand_DirLockTo() {} // 0x008E1190-0x008E1250
	
		// Methods
		// [IteratorStateMachine] // 0x0063CCD0-0x0063CD40
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E0F20-0x008E0FA0
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x008E0FD0-0x008E0FE0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E0FE0-0x008E1190
	}
}
