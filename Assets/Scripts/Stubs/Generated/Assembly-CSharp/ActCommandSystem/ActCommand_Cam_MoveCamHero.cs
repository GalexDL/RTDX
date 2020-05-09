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
	[ActCommand] // 0x0060B850-0x0060B8D0
	public class ActCommand_Cam_MoveCamHero : ActCommand_Basic // TypeDefIndex: 8771
	{
		// Fields
		public bool isWait; // 0x28
		public float speed; // 0x2C
		public ActParam_Accel accelParam; // 0x30
	
		// Constructors
		public ActCommand_Cam_MoveCamHero() {} // 0x008DEDC0-0x008DEEA0
	
		// Methods
		// [IteratorStateMachine] // 0x0063C6B0-0x0063C720
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008DEC40-0x008DECC0
		// [IteratorStateMachine] // 0x0063C720-0x0063C790
		public IEnumerator moveAct(ActObjCamera actCam, ActObjCamera.CamActionTask camActTask) => default; // 0x008DECF0-0x008DED70
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x008DEDA0-0x008DEDB0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008DEDB0-0x008DEDC0
	}
}
