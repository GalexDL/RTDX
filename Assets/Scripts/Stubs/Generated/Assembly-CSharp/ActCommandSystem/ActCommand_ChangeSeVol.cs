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
	[ActCommand] // 0x0060CA80-0x0060CAD0
	public class ActCommand_ChangeSeVol : ActCommand_Basic // TypeDefIndex: 8839
	{
		// Fields
		public string symbol; // 0x28
		public float fadeTime; // 0x30
		public float volume; // 0x34
		public string volumeSymbol; // 0x38
	
		// Constructors
		public ActCommand_ChangeSeVol() {} // 0x008E06D0-0x008E07A0
	
		// Methods
		// [IteratorStateMachine] // 0x0063D440-0x0063D4B0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E0620-0x008E0690
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E06C0-0x008E06D0
	}
}
