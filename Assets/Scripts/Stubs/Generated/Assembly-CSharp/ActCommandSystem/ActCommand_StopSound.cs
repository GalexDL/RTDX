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
	[ActCommand] // 0x0060CA00-0x0060CA40
	public class ActCommand_StopSound : ActCommand_Basic // TypeDefIndex: 8835
	{
		// Fields
		public bool isWait; // 0x28
		public float fadeTime; // 0x2C
	
		// Constructors
		public ActCommand_StopSound() {} // 0x00A96770-0x00A96780
	
		// Methods
		// [IteratorStateMachine] // 0x0063D360-0x0063D3D0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A96660-0x00A966D0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A96700-0x00A96770
	}
}
