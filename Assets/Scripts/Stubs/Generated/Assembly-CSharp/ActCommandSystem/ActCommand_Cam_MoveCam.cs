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
	[ActCommand] // 0x0060B750-0x0060B7D0
	public class ActCommand_Cam_MoveCam : ActCommand_Basic // TypeDefIndex: 8765
	{
		// Fields
		public bool isWait; // 0x28
		[SerializeField] // 0x00617760-0x00617770
		public ActParam_MoveCamera moveCameraParam; // 0x30
		public float speed; // 0x38
		public ActParam_Accel accelParam; // 0x40
	
		// Constructors
		public ActCommand_Cam_MoveCam() {} // 0x008DE4A0-0x008DE5A0
	
		// Methods
		// [IteratorStateMachine] // 0x0063C560-0x0063C5D0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008DE2F0-0x008DE370
		// [IteratorStateMachine] // 0x0063C5D0-0x0063C640
		public IEnumerator moveAct(ActObjCamera actCam, ActObjCamera.CamActionTask camActTask) => default; // 0x008DE3A0-0x008DE420
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x008DE450-0x008DE490
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008DE490-0x008DE4A0
	}
}
