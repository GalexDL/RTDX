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
	[ActCommand] // 0x0060CCA0-0x0060CCF0
	public class ActCommand_StopBgm : ActCommand_Basic // TypeDefIndex: 8854
	{
		// Fields
		public bool isWait; // 0x28
		public float fadeTime; // 0x2C
		public ActCommand_PlayBgm.Channel channel; // 0x30
	
		// Constructors
		public ActCommand_StopBgm() {} // 0x00A95BE0-0x00A95BF0
	
		// Methods
		// [IteratorStateMachine] // 0x0063D750-0x0063D7C0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A95AE0-0x00A95B50
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A95B80-0x00A95BE0
	}
}
