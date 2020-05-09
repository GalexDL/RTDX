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
	[ActCommand] // 0x0060CD90-0x0060CDE0
	public class ActCommand_WaitEffect : ActCommand_Basic // TypeDefIndex: 8860
	{
		// Fields
		public bool isAllEffect; // 0x28
		public string nameSymbol; // 0x30
	
		// Constructors
		public ActCommand_WaitEffect() {} // 0x00A98AF0-0x00A98B50
	
		// Methods
		// [IteratorStateMachine] // 0x0063D8A0-0x0063D910
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A98A30-0x00A98AB0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A98AE0-0x00A98AF0
	}
}
