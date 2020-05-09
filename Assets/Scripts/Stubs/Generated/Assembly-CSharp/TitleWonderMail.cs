/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.fixed_reward;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class TitleWonderMail : UIManagerBase // TypeDefIndex: 5746
{
	// Fields
	public static TextIDHash[] MessageText; // 0x00
	private TitleFlowToolBox m_toolBox; // 0x20
	public string rewardIndex; // 0x28

	// Properties
	private TitleFlowToolBox ToolBox { get => default; } // 0x007D8A70-0x007D8A80 
	private Index rewardIndex_ { get => default; set {} } // 0x007D8BE0-0x007D8DD0 0x007D8DD0-0x007D8E60

	// Nested types
	public enum Message // TypeDefIndex: 5747
	{
		FIRST_VISIT = 0,
		USUAL_VISIT = 1,
		WRONG_PASSWORD = 2,
		ALREADY_USED = 3,
		ASK_ONEMORE = 4,
		ASK_ONEMORE_YES = 5,
		ASK_ONEMORE_NO = 6,
		ITEM_CONFIRM = 7,
		ITEM_CONFIRM_YES = 8,
		ITEM_CONFIRM_NO = 9,
		ITEM_CONFIRM_CANSEL = 10,
		FULL_WAREHOUSE = 11,
		FULL_WAREHOUSE_YES = 12,
		FULL_WAREHOUSE_NO = 13,
		FULL_WAREHOUSE_CANSEL = 14,
		RECEIPT_ITEM = 15,
		DEBUG_GET_ITEM = 16,
		QUEST_GET = 17,
		QUEST_CONFIRM = 18,
		QUEST_CONFIRM_YES = 19,
		QUEST_CONFIRM_NO = 20,
		QUEST_CANCEL = 21,
		QUEST_RECEIPT = 22,
		QUEST_ERROR_CREATE_FAILED = 23,
		QUEST_ERROR_COMPLETED = 24,
		QUEST_ERROR_OVERLAP = 25,
		QUEST_ERROR_SUSPENDED_DUNGEON = 26,
		QUEST_ERROR_FULL_LIST = 27,
		QUEST_ERROR_CONFLICT = 28,
		QUEST_ERROR_CONFLICT_CANCEL = 29,
		QUEST_ERROR_FULL_CANCEL = 30,
		QUEST_ERROR_RECEIPT_FULL = 31,
		QUEST_ERROR_RECEIPT_CONFRICT = 32,
		QUEST_CAUTION_CAMP_NOT_CONSTRUCTED1 = 33,
		QUEST_CAUTION_CAMP_NOT_CONSTRUCTED2 = 34,
		QUEST_CAUTION_DUNGEON_BAD_CONDITION1 = 35,
		QUEST_CAUTION_DUNGEON_BAD_CONDITION2 = 36,
		QUEST_CAUTION_QUEST_TUTORIAL = 37,
		QUEST_CAUTION_QUEST_TUTORIAL2 = 38
	}

	private enum AddListStatus // TypeDefIndex: 5748
	{
		SUCCESS = 0,
		FAILED_CAMP = 1,
		FAILED_DUNGEON_CONDITION = 2,
		FAILED_NOT_UNLOCK_QUEST = 3
	}

	// Constructors
	public TitleWonderMail() {} // 0x007D91F0-0x007D9270
	static TitleWonderMail() {} // 0x007D9270-0x007D92F0

	// Methods
	// [IteratorStateMachine] // 0x006218B0-0x00621920
	public override IEnumerator MainFlow() => default; // 0x007D8A80-0x007D8AF0
	// [IteratorStateMachine] // 0x00621920-0x00621990
	private IEnumerator GetPassRewardItem(int index, string password, Action<bool> bCb) => default; // 0x007D8B20-0x007D8BB0
	// [IteratorStateMachine] // 0x00621990-0x00621A00
	private IEnumerator GetPassRewardQuest(int index, string password, Action<bool> bCb) => default; // 0x007D8E60-0x007D8EF0
	private AddListStatus addListQuestTicket(QuestWonderMailTicket ticket) => default; // 0x007D8F20-0x007D9080
	// [IteratorStateMachine] // 0x00621A00-0x00621A70
	private IEnumerator addListQuestMessage(AddListStatus b) => default; // 0x007D9080-0x007D90F0
	// [IteratorStateMachine] // 0x00621A70-0x00621AE0
	private IEnumerator GeneralAsk(TextId main, TextId yes, TextId no, Action<int> cb, bool isSe = true /* Metadata: 0x00611E30 */) => default; // 0x007D9120-0x007D91C0
}

