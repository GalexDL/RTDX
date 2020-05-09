/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.fixed_reward;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

namespace ActCommandSystem
{
	[ActCommand] // 0x0060D3B0-0x0060D430
	public class ActCommand_GetReward : ActCommand_Basic // TypeDefIndex: 8907
	{
		// Fields
		public string flowType; // 0x28
		public string rewardIndex; // 0x30
	
		// Properties
		private UIRewardMenu.FlowType flowType_ { get => default; set {} } // 0x008E2C40-0x008E2DB0 0x008E2DB0-0x008E2E40
		private Index rewardIndex_ { get => default; set {} } // 0x008E2E40-0x008E2FB0 0x008E2FB0-0x008E3040
	
		// Constructors
		public ActCommand_GetReward() {} // 0x008E30F0-0x008E31B0
	
		// Methods
		// [IteratorStateMachine] // 0x0063E080-0x0063E0F0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008E3040-0x008E30B0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008E30E0-0x008E30F0
	}
}
