/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActUtility;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[ActCommand] // 0x0060C1B0-0x0060C230
	public class ActCommand_ScaleTo : ActCommand_Basic // TypeDefIndex: 8808
	{
		// Fields
		public bool isWait; // 0x28
		public Vector3 targetScale; // 0x2C
		public ActParam_Accel accelParam; // 0x38
		public float timeSec; // 0x40
	
		// Constructors
		public ActCommand_ScaleTo() {} // 0x00A8F870-0x00A8F910
	
		// Methods
		// [IteratorStateMachine] // 0x0063CDB0-0x0063CE20
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A8F780-0x00A8F800
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x00A8F830-0x00A8F850
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A8F850-0x00A8F870
	}
}
