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
	[Serializable]
	public class ActFuncData // TypeDefIndex: 8704
	{
		// Fields
		public string funcName; // 0x10
		public string targetType; // 0x18
		public ActCommandCellList commandCellList; // 0x20
		public string comment; // 0x28
	
		// Constructors
		public ActFuncData() {} // 0x00AA1770-0x00AA1800
	
		// Methods
		public Type GetTargetType() => default; // 0x00AA1340-0x00AA13D0
		// [IteratorStateMachine] // 0x0063BEB0-0x0063BF20
		public IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00AA1550-0x00AA15D0
		public void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00AA1600-0x00AA1770
	}
}
