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
	[ActCommand] // 0x0060C6C0-0x0060C740
	public class ActCommand_Shake : ActCommand_Basic // TypeDefIndex: 8825
	{
		// Fields
		public bool isWait; // 0x28
		public bool isReset; // 0x29
		public float xOffs; // 0x2C
		public float yOffs; // 0x30
		public float zOffs; // 0x34
		public float intervalSec; // 0x38
		public string ShakeType; // 0x40
	
		// Properties
		private ActObjCharactor.ShakeType shakeType_ { get => default; set {} } // 0x00A93350-0x00A934C0 0x00A934C0-0x00A93550
	
		// Constructors
		public ActCommand_Shake() {} // 0x00A93610-0x00A93690
	
		// Methods
		// [IteratorStateMachine] // 0x0063D130-0x0063D1A0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A93550-0x00A935D0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A93600-0x00A93610
	}
}
