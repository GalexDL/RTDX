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
	[ActCommand] // 0x0060B610-0x0060B650
	public class ActCommand_Sleep : ActCommand_Basic // TypeDefIndex: 8757
	{
		// Fields
		public float timeSec; // 0x28
	
		// Constructors
		public ActCommand_Sleep() {} // 0x00A939F0-0x00A93A00
	
		// Methods
		// [IteratorStateMachine] // 0x0063C3A0-0x0063C410
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A93940-0x00A939B0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A939E0-0x00A939F0
	}
}
