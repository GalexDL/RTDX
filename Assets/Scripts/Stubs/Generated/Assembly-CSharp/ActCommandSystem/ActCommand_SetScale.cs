/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[ActCommand] // 0x0060C0E0-0x0060C1B0
	public class ActCommand_SetScale : ActCommand_Basic // TypeDefIndex: 8806
	{
		// Fields
		public Vector3 targetScale; // 0x28
	
		// Constructors
		public ActCommand_SetScale() {} // 0x00A92A30-0x00A92AB0
	
		// Methods
		// [IteratorStateMachine] // 0x0063CD40-0x0063CDB0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A92940-0x00A929C0
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x00A929F0-0x00A92A10
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A92A10-0x00A92A30
	}
}
