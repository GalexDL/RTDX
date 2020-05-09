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
	[ActCommand] // 0x0060BCA0-0x0060BD70
	public class ActCommand_SetDir : ActCommand_Basic // TypeDefIndex: 8791
	{
		// Fields
		public ActParam_Rot rot; // 0x28
	
		// Constructors
		public ActCommand_SetDir() {} // 0x00A91350-0x00A913C0
	
		// Methods
		// [IteratorStateMachine] // 0x0063CA30-0x0063CAA0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A91230-0x00A912B0
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x00A912E0-0x00A91300
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A91300-0x00A91350
	}
}
