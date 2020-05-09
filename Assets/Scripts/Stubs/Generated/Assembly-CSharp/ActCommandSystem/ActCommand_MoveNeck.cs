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
	[ActCommand] // 0x0060C470-0x0060C4F0
	public class ActCommand_MoveNeck : ActCommand_Basic // TypeDefIndex: 8817
	{
		// Fields
		public bool isWait; // 0x28
		public bool isReset; // 0x29
		public float yawDeg; // 0x2C
		public float pitchDeg; // 0x30
		public float rollDeg; // 0x34
		public float timeSec; // 0x38
		public ActParam_Accel accelParam; // 0x40
	
		// Constructors
		public ActCommand_MoveNeck() {} // 0x008E7110-0x008E71E0
	
		// Methods
		// [IteratorStateMachine] // 0x0063CF70-0x0063CFE0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E7020-0x008E70A0
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x008E70D0-0x008E70E0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E70E0-0x008E7110
	}
}
