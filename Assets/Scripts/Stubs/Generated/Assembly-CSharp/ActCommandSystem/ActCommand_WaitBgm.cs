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
	[ActCommand] // 0x0060CCF0-0x0060CD40
	public class ActCommand_WaitBgm : ActCommand_Basic // TypeDefIndex: 8856
	{
		// Fields
		public ActCommand_PlayBgm.Channel channel; // 0x28
	
		// Constructors
		public ActCommand_WaitBgm() {} // 0x00A98740-0x00A98750
	
		// Methods
		// [IteratorStateMachine] // 0x0063D7C0-0x0063D830
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A98680-0x00A98700
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A98730-0x00A98740
	}
}
