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
	[ActCommand] // 0x0060CDE0-0x0060CE30
	public class ActCommand_StopEffect : ActCommand_Basic // TypeDefIndex: 8862
	{
		// Fields
		public bool isAllEffect; // 0x28
		public string nameSymbol; // 0x30
	
		// Constructors
		public ActCommand_StopEffect() {} // 0x00A96090-0x00A960F0
	
		// Methods
		// [IteratorStateMachine] // 0x0063D910-0x0063D980
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A95FE0-0x00A96050
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A96080-0x00A96090
	}
}
