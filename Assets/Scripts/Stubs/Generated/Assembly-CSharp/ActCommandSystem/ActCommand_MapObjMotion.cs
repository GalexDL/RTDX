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
	[ActCommand] // 0x0060C950-0x0060CA00
	public class ActCommand_MapObjMotion : ActCommand_Basic // TypeDefIndex: 8833
	{
		// Fields
		public string mapObjName; // 0x28
		public string actionName; // 0x30
	
		// Constructors
		public ActCommand_MapObjMotion() {} // 0x008E6160-0x008E6220
	
		// Methods
		// [IteratorStateMachine] // 0x0063D2F0-0x0063D360
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E6090-0x008E6110
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x008E6140-0x008E6150
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E6150-0x008E6160
	}
}
