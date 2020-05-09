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
	[ActCommand] // 0x0060C8A0-0x0060C950
	public class ActCommand_MapObjMSpeed : ActCommand_Basic // TypeDefIndex: 8831
	{
		// Fields
		public string mapObjName; // 0x28
		public float motionSpeed; // 0x30
	
		// Constructors
		public ActCommand_MapObjMSpeed() {} // 0x008E5E60-0x008E5F30
	
		// Methods
		// [IteratorStateMachine] // 0x0063D280-0x0063D2F0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E5D90-0x008E5E10
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x008E5E40-0x008E5E50
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E5E50-0x008E5E60
	}
}
