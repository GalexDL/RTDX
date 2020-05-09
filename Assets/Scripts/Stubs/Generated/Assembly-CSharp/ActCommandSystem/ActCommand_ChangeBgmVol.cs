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
	[ActCommand] // 0x0060CC50-0x0060CCA0
	public class ActCommand_ChangeBgmVol : ActCommand_Basic // TypeDefIndex: 8852
	{
		// Fields
		public float fadeTime; // 0x28
		public ActCommand_PlayBgm.Channel channel; // 0x2C
		public float volume; // 0x30
		public string volumeSymbol; // 0x38
	
		// Constructors
		public ActCommand_ChangeBgmVol() {} // 0x008E02E0-0x008E03A0
	
		// Methods
		// [IteratorStateMachine] // 0x0063D6E0-0x0063D750
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E0230-0x008E02A0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E02D0-0x008E02E0
	}
}
