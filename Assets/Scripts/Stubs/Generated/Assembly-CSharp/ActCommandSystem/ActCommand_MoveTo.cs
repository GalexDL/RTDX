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
	[ActCommand] // 0x0060BD70-0x0060BDF0
	public class ActCommand_MoveTo : ActCommand_Basic // TypeDefIndex: 8793
	{
		// Fields
		public bool isWait; // 0x28
		public float speed; // 0x2C
		public string speedSymbol; // 0x30
		public bool yawTurnOff; // 0x38
		public bool yawTurnWait; // 0x39
		public float yawTurnSpeedDeg; // 0x3C
		public MoveRotateYaw.RotationType yawTurnRotType; // 0x40
		public WalkMotionType motionType; // 0x44
		public ActParam_Pos toPos; // 0x48
		public List<ActParam_Pos> splinePosLst; // 0x50
		private List<KeyValuePair<string, float>> SpeedConstLst; // 0x58
	
		// Nested types
		public enum WalkMotionType // TypeDefIndex: 8794
		{
			NONE = 0,
			WALK = 100,
			RUN = 200
		}
	
		// Constructors
		public ActCommand_MoveTo() {} // 0x008E7690-0x008E78A0
	
		// Methods
		// [IteratorStateMachine] // 0x0063CAA0-0x0063CB10
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E7440-0x008E74C0
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x008E74F0-0x008E7510
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E7510-0x008E7690
	}
}
