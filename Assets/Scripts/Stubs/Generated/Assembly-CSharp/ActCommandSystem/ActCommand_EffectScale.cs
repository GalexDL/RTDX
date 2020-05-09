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
	[ActCommand] // 0x0060CE30-0x0060CE70
	public class ActCommand_EffectScale : ActCommand_Basic // TypeDefIndex: 8864
	{
		// Fields
		public bool isWait; // 0x28
		public string nameSymbol; // 0x30
		public float toScale; // 0x38
		public float time; // 0x3C
		public ActParam_Accel accelParam; // 0x40
	
		// Constructors
		public ActCommand_EffectScale() {} // 0x008E1F00-0x008E1FF0
	
		// Methods
		// [IteratorStateMachine] // 0x0063D980-0x0063D9F0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E1E30-0x008E1EB0
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x008E1EE0-0x008E1EF0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E1EF0-0x008E1F00
	}
}
