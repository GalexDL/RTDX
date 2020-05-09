/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[ActCommand] // 0x0060C230-0x0060C300
	public class ActCommand_SetColor : ActCommand_Basic // TypeDefIndex: 8810
	{
		// Fields
		public Color tgtColorMul; // 0x28
		public Color tgtColorAdd; // 0x38
		public Color tgtColorOverlay; // 0x48
	
		// Constructors
		public ActCommand_SetColor() {} // 0x00A90EB0-0x00A90F40
	
		// Methods
		// [IteratorStateMachine] // 0x0063CE20-0x0063CE90
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A90D80-0x00A90E00
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x00A90E30-0x00A90E70
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A90E70-0x00A90EB0
	}
}
