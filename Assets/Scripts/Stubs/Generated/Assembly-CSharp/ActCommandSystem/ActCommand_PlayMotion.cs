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
	[ActCommand] // 0x0060BA70-0x0060BB20
	public class ActCommand_PlayMotion : ActCommand_Basic // TypeDefIndex: 8785
	{
		// Fields
		public string motion; // 0x28
		public bool isWait; // 0x30
		public bool isAddQueue; // 0x31
		public bool isLoop; // 0x32
		public float blendTimeSec; // 0x34
		public float motionSpeed; // 0x38
		public bool isTaskEndMark; // 0x3C
		private List<string> MotionList; // 0x40
	
		// Constructors
		public ActCommand_PlayMotion() {} // 0x008E9630-0x008E9A20
	
		// Methods
		// [IteratorStateMachine] // 0x0063C8E0-0x0063C950
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E9560-0x008E95E0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E9610-0x008E9630
	}
}
