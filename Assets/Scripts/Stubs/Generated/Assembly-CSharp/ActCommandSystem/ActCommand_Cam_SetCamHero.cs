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
	[ActCommand] // 0x0060B7D0-0x0060B850
	public class ActCommand_Cam_SetCamHero : ActCommand_Basic // TypeDefIndex: 8769
	{
		// Fields
		[SerializeField] // 0x00617770-0x00617780
		public bool isSetPosition; // 0x28
		public bool isSetRotate; // 0x29
	
		// Constructors
		public ActCommand_Cam_SetCamHero() {} // 0x008DFC00-0x008DFC90
	
		// Methods
		// [IteratorStateMachine] // 0x0063C640-0x0063C6B0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008DFA70-0x008DFAF0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008DFB20-0x008DFC00
	}
}
