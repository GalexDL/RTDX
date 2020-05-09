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
	[ActCommand] // 0x0060BFE0-0x0060C060
	public class ActCommand_DirTo : ActCommand_Basic // TypeDefIndex: 8802
	{
		// Fields
		public bool isWait; // 0x28
		public MoveRotateYaw.RotationType rotType; // 0x2C
		private List<KeyValuePair<string, float>> SpeedConstLst; // 0x30
		public float speedDeg; // 0x38
		public string speedDegSymbol; // 0x40
		public bool withWalkMotion; // 0x48
		public ActParam_Rot targetRot; // 0x50
	
		// Constructors
		public ActCommand_DirTo() {} // 0x008E1590-0x008E1770
	
		// Methods
		// [IteratorStateMachine] // 0x0063CC60-0x0063CCD0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E1470-0x008E14F0
		public override void InitFromSnapshotState(ActObjSnapshotState snapshotState) {} // 0x008E1520-0x008E1540
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E1540-0x008E1590
	}
}
