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
	[ActCommand] // 0x0060D530-0x0060D5B0
	public class ActCommand_JiraachiReward : ActCommand_Basic // TypeDefIndex: 8914
	{
		// Fields
		public CommandType commandType; // 0x28
		public GroundManager.JiraachiRewardType setRewardType; // 0x2C
		public string branchLabel_Money; // 0x30
		public string branchLabel_Item; // 0x38
		public string branchLabel_Camp; // 0x40
		public string branchLabel_PowerUp; // 0x48
		public string branchLabel_GoodEvent; // 0x50
	
		// Nested types
		public enum CommandType // TypeDefIndex: 8915
		{
			SetReward = 0,
			BranchReward = 100,
			PlaySpecialEvent0 = 200,
			PlaySpecialEvent1 = 210,
			GetAndClearReward = 400
		}
	
		// Constructors
		public ActCommand_JiraachiReward() {} // 0x008E3850-0x008E3920
	
		// Methods
		// [IteratorStateMachine] // 0x0063E1D0-0x0063E240
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E36A0-0x008E3720
		// [IteratorStateMachine] // 0x0063E240-0x0063E2B0
		private IEnumerator flyAct_(int index, GameObject obj, Vector3 toPos, Action endCb, bool bMoney) => default; // 0x008E3750-0x008E3810
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E3840-0x008E3850
	}
}
