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
	[ActCommand] // 0x0060BEA0-0x0060BF40
	public class ActCommand_MoveGimmick : ActCommand_Basic // TypeDefIndex: 8798
	{
		// Fields
		public ActParam_Pos toPos; // 0x28
		public bool isWait; // 0x30
		public float speed; // 0x34
		public ActParam_Accel accel; // 0x38
	
		// Constructors
		public ActCommand_MoveGimmick() {} // 0x008E6780-0x008E6880
	
		// Methods
		// [IteratorStateMachine] // 0x0063CB80-0x0063CBF0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E6670-0x008E66F0
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x008E6720-0x008E6740
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E6740-0x008E6780
	}
}
