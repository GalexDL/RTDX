/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.camp;
using Const.creature;
using Const.fixed_creature;
using Const.fixed_reward;
using Const.pokemon;
using Const.rank;
using Const.sugowaza;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIRewardMenu // TypeDefIndex: 7514
{
	// Fields
	private RewardParam reward_; // 0x10
	private bool bExit_; // 0x18
	private UIRewardAnounce anounce_; // 0x20
	private UIRewardAnounce wonderMailAnounce; // 0x28

	// Properties
	private bool EXIT { get => default; set {} } // 0x00B59A90-0x00B59AA0 0x00B59AA0-0x00B59AB0

	// Nested types
	public enum FlowType // TypeDefIndex: 7515
	{
		GET_ITEM_MESSAGE = 0,
		GET_ITEM_SILENCE = 1,
		GET_ITEM_WAREHOUSE = 2,
		GET_MONEY_MESSAGE = 3,
		GET_MONEY_SILENCE = 4,
		GET_CAMP = 5,
		GET_CAMP_SILENCE = 6,
		JOIN_GROUND_EVENT = 7,
		JOIN_GROUND_EVENT_NICKNAME_SKIP = 8,
		JOIN_BOSS_COMMON = 9,
		JOIN_BOSS_EVENT = 10,
		JOIN_QUEST_EVENT = 11,
		JOIN_DUNGEON_RESULT = 12,
		QUEST_REWARD = 13,
		EVENT_JIRAACHI_REWARD = 14,
		REWORD_LIST = 15,
		JOIN_IN_DUNGEON = 16,
		RANKUP = 17,
		TEST = 18
	}

	public class RewardParam // TypeDefIndex: 7516
	{
		// Fields
		public FlowType flowType; // 0x10
		public List<IPokemonStatus> pokemons; // 0x18
		public List<IItem> items; // 0x20
		public int money; // 0x28
		public FixedWarehouseId fixedID; // 0x2C
		public int rescuePoint; // 0x30
		public Const.camp.Index camp; // 0x34
		public IQuestTicket questTicket; // 0x38
		public string clientName; // 0x40
		public List<int> guestsCash; // 0x48
		public bool commonScreenClose; // 0x50
		public IPokemonStatus selectPokemon; // 0x58
		public CommonRewardType rewardType; // 0x60
		private int indexPokemon_; // 0x64
		private int indexItem_; // 0x68

		// Constructors
		public RewardParam() {} // Dummy constructor
		public RewardParam(FlowType type) {} // 0x00DF6DA0-0x00DF6EA0

		// Methods
		public bool HasRewardPokemon() => default; // 0x00DF67E0-0x00DF6840
		public IPokemonStatus GetRewardPokemon() => default; // 0x00DF6680-0x00DF66E0
		public int GetRewardGuestCash() => default; // 0x00DF66E0-0x00DF6770
		public void IncRewardPokemon() {} // 0x00DF6770-0x00DF67E0
		public bool HasRewardItem() => default; // 0x00DF3C20-0x00DF3C80
		public IItem GetRewardItem() => default; // 0x00DF3B50-0x00DF3BB0
		public void IncRewardItem() {} // 0x00DF3BB0-0x00DF3C20
		public void ResetItemIndex() {} // 0x00DF6EA0-0x00DF6EB0
		public void GetRewardFromQuestTicket() {} // 0x00DF6EB0-0x00DF71C0
		public void CleanRewardFromQuestTicket() {} // 0x00DF72D0-0x00DF7490
		public void GetRewardFromFixedReward(Const.fixed_reward.Index fixedReward) {} // 0x00DF7490-0x00DF7640
		public void GetRewardFromRewordType(CommonRewardType type, int tableNo, int rate) {} // 0x00DF7890-0x00DF7960
		public void CleanRewardFromFixedReward() {} // 0x00DF7640-0x00DF7820
		public void SetRewardPokemon(Const.creature.Index index, int lv, Const.sugowaza.Index sugowaza) {} // 0x00DF7240-0x00DF72D0
		public void SetRewardPokemonFromFixed(FixedWarehouseId wid) {} // 0x00DF7820-0x00DF7890
		public void SetRewardPokemonFromFixedCreatureParameter(Const.creature.Index index, Const.fixed_creature.Index fixedCreatureIndex) {} // 0x00DF71C0-0x00DF7240
	}

	// Constructors
	public UIRewardMenu() {} // 0x00B5A4E0-0x00B5A4F0

	// Methods
	// [IteratorStateMachine] // 0x0062CD20-0x0062CD90
	public IEnumerator MainFlow(RewardParam reward, Action cb = null) => default; // 0x00B59AB0-0x00B59B30
	private void _init(RewardParam reward) {} // 0x00B59B60-0x00B59B70
	private void _exit() {} // 0x00B59B70-0x00B59C50
	private UIRewardAnounce _getAnounce() => default; // 0x00B59C50-0x00B59D30
	// [IteratorStateMachine] // 0x0062CD90-0x0062CE00
	private IEnumerator _noticeMessage(TextId textId, int presetPosition, Action cb = null) => default; // 0x00B59D30-0x00B59DB0
	// [IteratorStateMachine] // 0x0062CE00-0x0062CE70
	private IEnumerator _noticeMessageWithMe(TextId textId, string sMe, Action cb = null) => default; // 0x00B59DB0-0x00B59E30
	// [IteratorStateMachine] // 0x0062CE70-0x0062CEE0
	private static IEnumerator _askMessage(TextId textId, MessageWindow.AskParam askParam, int presetPosition = 0 /* Metadata: 0x00613792 */, Action<int> cb = null) => default; // 0x00B59E30-0x00B59EC0
	// [IteratorStateMachine] // 0x0062CEE0-0x0062CF50
	private IEnumerator _rewardItemFlow(bool bSilence, Action cb = null) => default; // 0x00B59EC0-0x00B59F50
	// [IteratorStateMachine] // 0x0062CF50-0x0062CFC0
	private IEnumerator _rewardItemFlowToWarehouse(Action cb = null) => default; // 0x00B59F50-0x00B59FD0
	// [IteratorStateMachine] // 0x0062CFC0-0x0062D030
	private IEnumerator _rewardMoneyFlow(bool bSilence, Action cb = null) => default; // 0x00B59FD0-0x00B5A060
	// [IteratorStateMachine] // 0x0062D030-0x0062D0A0
	private IEnumerator _rewardPokemonFlow(bool bGiveNickname, Action cb = null) => default; // 0x00B5A060-0x00B5A0F0
	// [IteratorStateMachine] // 0x0062D0A0-0x0062D110
	public static IEnumerator RewardPokemonDgFlow(IPokemonStatus addPokemon, Action<IPokemonStatus> cb = null, bool bFromShortCut = false /* Metadata: 0x00613796 */) => default; // 0x00B5A0F0-0x00B5A180
	// [IteratorStateMachine] // 0x0062D110-0x0062D180
	private IEnumerator _viewRewardListFlow(UIRewardAnounce.TitleType titleType, Action cb = null) => default; // 0x00B5A180-0x00B5A200
	// [IteratorStateMachine] // 0x0062D180-0x0062D1F0
	public IEnumerator _viewWonderMailRewardList(RewardParam viewReward, string password, Action cb = null) => default; // 0x00B5A200-0x00B5A290
	// [IteratorStateMachine] // 0x0062D1F0-0x0062D260
	public IEnumerator _closeWonderMailRewardList(Action cb = null) => default; // 0x00B5A290-0x00B5A310
	// [IteratorStateMachine] // 0x0062D260-0x0062D2D0
	private IEnumerator _rewardRankPointFlow(bool bSilence, Action cb = null) => default; // 0x00B5A310-0x00B5A3A0
	// [IteratorStateMachine] // 0x0062D2D0-0x0062D340
	private IEnumerator _rewardCampFlow(bool bSilence, Action cb = null) => default; // 0x00B5A3A0-0x00B5A430
	// [IteratorStateMachine] // 0x0062D340-0x0062D3B0
	public IEnumerator RankupRewardFlow(Const.rank.Index beforeRank, Const.rank.Index afterRank) => default; // 0x00B5A430-0x00B5A4B0
}

