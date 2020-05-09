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
	[ActCommand] // 0x0060B8D0-0x0060B970
	public class ActCommand_Cam_Wait : ActCommand_Basic // TypeDefIndex: 8775
	{
		// Fields
		public bool waitMove; // 0x28
	
		// Constructors
		public ActCommand_Cam_Wait() {} // 0x008DFFB0-0x008E0040
	
		// Methods
		// [IteratorStateMachine] // 0x0063C790-0x0063C800
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008DFEF0-0x008DFF70
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008DFFA0-0x008DFFB0
	}
}
