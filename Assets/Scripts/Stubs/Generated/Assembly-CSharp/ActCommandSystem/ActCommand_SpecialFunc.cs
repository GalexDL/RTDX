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
	[ActCommand] // 0x0060D2B0-0x0060D330
	public class ActCommand_SpecialFunc : ActCommand_Basic // TypeDefIndex: 8895
	{
		// Fields
		public SpecialFuncType specialFuncType; // 0x28
		public string branchLabelTrue; // 0x30
		public string branchLabelFalse; // 0x38
	
		// Nested types
		public enum SpecialFuncType // TypeDefIndex: 8896
		{
			NONE = 0,
			SEIKAKU_SHINDAN = 100,
			INPUT_NAME_HERO = 200,
			INPUT_NAME_PARTNER = 300,
			INPUT_NAME_TEAM = 400,
			TEAM_FLAG_MENU = 500,
			TEAM_FLAG_APPLY = 510,
			GIVE_MANKII_IGAGURI = 1000,
			CALL_LAST_DUNGEON_RESULT = 1500,
			CALL_KEIJIBAN = 1600,
			GONBE_GIVE_FOOD_ITEM = 1710,
			UPDATE_POST_LETTER = 1910,
			CLEAR_POST_LETTER_YESTERDAY_FLAG = 1920,
			SET_POST_LETTER_FORCE_OFF = 1930,
			APLLY_POST_LETTER_VISIBLE = 1940,
			POST_LETTER_OPEN__GUMI = 2000,
			POST_LETTER_OPEN__GOUGAI = 2010,
			POST_LETTER_ADD__FIRST = 2020,
			CALL_STAFF_ROLL = 2100,
			TALK_MANP_OFF = 2200,
			TALK_MANP_ON = 2210,
			POSTEFFECT_EDGE_OFF = 2300,
			POSTEFFECT_EDGE_ON = 2310,
			NPC_POS_INIT = 2400
		}
	
		// Constructors
		public ActCommand_SpecialFunc() {} // 0x00A94060-0x00A940C0
	
		// Methods
		// [IteratorStateMachine] // 0x0063DFA0-0x0063E010
		public override IEnumerator callAction(ActTargetBase target, ActDataPlayer.PlayContext context, Action endWait) => default; // 0x00A93FA0-0x00A94020
		public override void CalcSnapshotState(ActObjSnapshotState workSnapshotState, ActSnapshotContext snapshotContext, ScriptData refScriptData) {} // 0x00A94050-0x00A94060
	}
}
