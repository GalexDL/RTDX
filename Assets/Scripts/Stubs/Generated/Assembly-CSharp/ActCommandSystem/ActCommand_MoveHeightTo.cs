/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActUtility;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[ActCommand] // 0x0060BDF0-0x0060BEA0
	public class ActCommand_MoveHeightTo : ActCommand_Basic // TypeDefIndex: 8796
	{
		// Fields
		public bool isWait; // 0x28
		public float toHeight; // 0x2C
		public float speed; // 0x30
		public ActParam_Accel accel; // 0x38
	
		// Constructors
		public ActCommand_MoveHeightTo() {} // 0x008E6C10-0x008E6CF0
	
		// Methods
		// [IteratorStateMachine] // 0x0063CB10-0x0063CB80
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E6B40-0x008E6BC0
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x008E6BF0-0x008E6C00
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E6C00-0x008E6C10
	}
}
