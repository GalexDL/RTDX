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
	[ActCommand] // 0x0060CD40-0x0060CD90
	public class ActCommand_PlayEffect : ActCommand_Basic // TypeDefIndex: 8858
	{
		// Fields
		public bool isWait; // 0x28
		public string nameSymbol; // 0x30
		public string effectSymbol; // 0x38
		public string attachActCharaSymbol; // 0x40
		public ActParam_Pos pos; // 0x48
		public ActParam_Rot rot; // 0x50
	
		// Constructors
		public ActCommand_PlayEffect() {} // 0x008E8E60-0x008E8F60
	
		// Methods
		// [IteratorStateMachine] // 0x0063D830-0x0063D8A0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E8DA0-0x008E8E20
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E8E50-0x008E8E60
	}
}
