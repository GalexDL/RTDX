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
	[ActCommand] // 0x0060CFB0-0x0060D030
	public class ActCommand_Play2DAnim : ActCommand_Basic // TypeDefIndex: 8874
	{
		// Fields
		public bool isWait; // 0x28
		public string id; // 0x30
		public string bundleName; // 0x38
		public string animName; // 0x40
	
		// Constructors
		public ActCommand_Play2DAnim() {} // 0x008E7E40-0x008E7F10
	
		// Methods
		// [IteratorStateMachine] // 0x0063DB40-0x0063DBB0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E7CD0-0x008E7D50
		// [IteratorStateMachine] // 0x0063DBB0-0x0063DC20
		private IEnumerator animFunc_(ScriptDataPlayer.PlayerTaskSys.TaskContext info) => default; // 0x008E7D80-0x008E7E00
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E7E30-0x008E7E40
	}
}
