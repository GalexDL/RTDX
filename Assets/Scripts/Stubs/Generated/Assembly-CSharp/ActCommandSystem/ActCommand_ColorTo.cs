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
	[ActCommand] // 0x0060C300-0x0060C3D0
	public class ActCommand_ColorTo : ActCommand_Basic // TypeDefIndex: 8812
	{
		// Fields
		public bool isWait; // 0x28
		public Color tgtColorMul; // 0x2C
		public Color tgtColorAdd; // 0x3C
		public Color tgtColorOverlay; // 0x4C
		public float timeSec; // 0x5C
	
		// Constructors
		public ActCommand_ColorTo() {} // 0x008E0A70-0x008E0B70
	
		// Methods
		// [IteratorStateMachine] // 0x0063CE90-0x0063CF00
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E0940-0x008E09C0
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x008E09F0-0x008E0A30
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E0A30-0x008E0A70
	}
}
