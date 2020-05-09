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
	[ActCommand] // 0x0060B970-0x0060B9F0
	public class ActCommand_Cam_CamShake : ActCommand_Basic // TypeDefIndex: 8777
	{
		// Fields
		public bool isWait; // 0x28
		public bool isReset; // 0x29
		public float xOffs; // 0x2C
		public float yOffs; // 0x30
		public float intervalSec; // 0x34
		public string ShakeType; // 0x38
		public string AnimClipName; // 0x40
	
		// Properties
		private MainCamera.ShakeType shakeType_ { get => default; set {} } // 0x008DDD10-0x008DDE80 0x008DDE80-0x008DDF10
	
		// Constructors
		public ActCommand_Cam_CamShake() {} // 0x008DDFC0-0x008DE0A0
	
		// Methods
		// [IteratorStateMachine] // 0x0063C800-0x0063C870
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008DDF10-0x008DDF80
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008DDFB0-0x008DDFC0
	}
}
