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
	[ActCommand] // 0x0060CB70-0x0060CBB0
	public class ActCommand_PlayMe : ActCommand_Basic // TypeDefIndex: 8845
	{
		// Fields
		public bool isWait; // 0x28
		public string symbol; // 0x30
		public float fadeInTime; // 0x38
		public float volume; // 0x3C
		public string volumeSymbol; // 0x40
	
		// Constructors
		public ActCommand_PlayMe() {} // 0x008E9270-0x008E9340
	
		// Methods
		// [IteratorStateMachine] // 0x0063D590-0x0063D600
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E91B0-0x008E9230
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E9260-0x008E9270
	}
}
