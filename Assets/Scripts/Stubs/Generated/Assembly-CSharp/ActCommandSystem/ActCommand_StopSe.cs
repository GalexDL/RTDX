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
	[ActCommand] // 0x0060CAD0-0x0060CB20
	public class ActCommand_StopSe : ActCommand_Basic // TypeDefIndex: 8841
	{
		// Fields
		public string symbol; // 0x28
		public float fadeInTime; // 0x30
	
		// Constructors
		public ActCommand_StopSe() {} // 0x00A964B0-0x00A96510
	
		// Methods
		// [IteratorStateMachine] // 0x0063D4B0-0x0063D520
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A963B0-0x00A96420
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A96450-0x00A964B0
	}
}
