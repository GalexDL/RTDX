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
	[ActCommand] // 0x0060D630-0x0060D6B0
	public class ActCommand_SysMoveWithColl : ActCommand_Basic // TypeDefIndex: 8923
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
		public enum WalkMotionType // TypeDefIndex: 8924
		{
			NONE = 0,
			WALK = 100,
			RUN = 200
		}
	
		// Constructors
		public ActCommand_SysMoveWithColl() {} // 0x00A96C20-0x00A96DD0
	
		// Methods
		// [IteratorStateMachine] // 0x0063E320-0x0063E390
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A969D0-0x00A96A50
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x00A96A80-0x00A96AA0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A96AA0-0x00A96C20
	}
}
