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
	[ActCommand] // 0x0060B6D0-0x0060B750
	public class ActCommand_Cam_SetCam : ActCommand_Basic // TypeDefIndex: 8763
	{
		// Fields
		[SerializeField] // 0x00617750-0x00617760
		public ActParamHolder_Camera cameraParam; // 0x28
	
		// Constructors
		public ActCommand_Cam_SetCam() {} // 0x008DF7F0-0x008DF8C0
	
		// Methods
		// [IteratorStateMachine] // 0x0063C4F0-0x0063C560
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008DF630-0x008DF6B0
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x008DF6E0-0x008DF780
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008DF780-0x008DF7F0
	}
}
