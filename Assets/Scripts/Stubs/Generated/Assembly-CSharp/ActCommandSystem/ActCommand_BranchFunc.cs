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
	[ActCommand] // 0x0060D4B0-0x0060D530
	public class ActCommand_BranchFunc : ActCommand_Basic // TypeDefIndex: 8911
	{
		// Fields
		public BranchFuncType branchFuncType; // 0x28
		public string branchLabel; // 0x30
		public bool invertFlag; // 0x38
	
		// Nested types
		public enum BranchFuncType // TypeDefIndex: 8912
		{
			NONE = 0,
			CHECK_POST_HAITATSU_EVENT = 100,
			HAS_IGAGURI = 200,
			IS_CLEAR_MANKII_IGAGURI = 300,
			DEOKISHISU_FRIEND = 400,
			JIRAACHI_FRIEND = 410,
			CHECK_CAMP_SHOP_EMPTY = 500,
			CHECK_JIRAACHI_PARTY_LEADER = 600,
			Has_CAMP_SEINARU_DAICHI = 700,
			Has_CAMP_DENSETSUNO_KOTOU = 710,
			Has_CAMP_CAMP_KODAI_ISEKI = 720,
			Has_CAMP_CAMP_TSUKUYOMI_YAMA = 730,
			Has_CAMP_CAMP_KURAYAMI_TOUGE = 740,
			CHECK_DAGUTORIO_TALK_AFTER = 800,
			CHECK_DAGUTORIO_TALK_PARTNER_OFF = 810,
			IS_CAMP_MEMBER_JOINI_PARTY = 900,
			ALWAYS_TRUE = 9999
		}
	
		// Constructors
		public ActCommand_BranchFunc() {} // 0x008DD410-0x008DD4D0
	
		// Methods
		// [IteratorStateMachine] // 0x0063E160-0x0063E1D0
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x008DD350-0x008DD3D0
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x008DD400-0x008DD410
	}
}
