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
	[ActCommand] // 0x0060D030-0x0060D0B0
	public class ActCommand_Wait2DAnim : ActCommand_Basic // TypeDefIndex: 8878
	{
		// Fields
		public string id; // 0x28
	
		// Constructors
		public ActCommand_Wait2DAnim() {} // 0x00A984F0-0x00A98550
	
		// Methods
		// [IteratorStateMachine] // 0x0063DC20-0x0063DC90
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A98430-0x00A984B0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A984E0-0x00A984F0
	}
}
