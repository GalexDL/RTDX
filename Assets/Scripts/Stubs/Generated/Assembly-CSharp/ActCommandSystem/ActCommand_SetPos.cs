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
	[ActCommand] // 0x0060BBD0-0x0060BCA0
	public class ActCommand_SetPos : ActCommand_Basic // TypeDefIndex: 8789
	{
		// Fields
		public ActParam_Pos pos; // 0x28
		public ActParam_Rot rot; // 0x30
	
		// Constructors
		public ActCommand_SetPos() {} // 0x00A92480-0x00A92510
	
		// Methods
		// [IteratorStateMachine] // 0x0063C9C0-0x0063CA30
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A92310-0x00A92390
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x00A923C0-0x00A92400
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A92400-0x00A92480
	}
}
