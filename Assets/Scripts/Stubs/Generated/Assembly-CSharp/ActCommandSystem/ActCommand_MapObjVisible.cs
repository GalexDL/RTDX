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
	[ActCommand] // 0x0060C7F0-0x0060C8A0
	public class ActCommand_MapObjVisible : ActCommand_Basic // TypeDefIndex: 8829
	{
		// Fields
		public string mapObjName; // 0x28
		public bool visible; // 0x30
	
		// Constructors
		public ActCommand_MapObjVisible() {} // 0x008E6450-0x008E6510
	
		// Methods
		// [IteratorStateMachine] // 0x0063D210-0x0063D280
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E6380-0x008E6400
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x008E6430-0x008E6440
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E6440-0x008E6450
	}
}
