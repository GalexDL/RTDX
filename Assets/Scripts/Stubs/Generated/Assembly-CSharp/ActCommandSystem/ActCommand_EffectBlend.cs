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
	[ActCommand] // 0x0060CE70-0x0060CEB0
	public class ActCommand_EffectBlend : ActCommand_Basic // TypeDefIndex: 8866
	{
		// Fields
		public bool isWait; // 0x28
		public string nameSymbol; // 0x30
		public float toBlend; // 0x38
		public float time; // 0x3C
		public ActParam_Accel accelParam; // 0x40
	
		// Constructors
		public ActCommand_EffectBlend() {} // 0x008E1B50-0x008E1C40
	
		// Methods
		// [IteratorStateMachine] // 0x0063D9F0-0x0063DA60
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E1A80-0x008E1B00
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x008E1B30-0x008E1B40
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E1B40-0x008E1B50
	}
}
