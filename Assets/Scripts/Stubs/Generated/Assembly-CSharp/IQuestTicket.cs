/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.dungeon;
using Const.item;
using Const.pokemon;
using Const.quest;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public interface IQuestTicket // TypeDefIndex: 5079
{
	// Properties
	bool Valid { get; }

	// Methods
	void Destroy();
	Const.creature.Index GetClientIndex();
	GenderType GetClientGenderType();
	string GetClientName();
	bool IsGround();
	bool IsDungeon();
	Const.quest.Kind GetQuestKind();
	Variation GetExecuteVariation();
	bool IsQuestWithClient();
	bool IsNewsTicket();
	bool IsFriendRescueTicket();
	bool IsRequest();
	bool IsExecution();
	bool IsCompleteReward();
	bool IsCompleteFailed();
	bool IsFinish();
	void SetStatusReqest();
	void SetStatusExecution();
	void SetStatusCompleteReward();
	void SetStatusFinish();
	bool IsPoolBulletinBoard();
	bool IsPoolQuestTicketList();
	uint GetBurnId();
	string GetTitleText();
	string GetExplanationText0();
	string GetExplanationText1();
	string GetPurposeText();
	Const.dungeon.Index GetTargetDungeonIndex();
	int GetTargetDungeonFloor();
	int GetDifficultyRank();
	string GetDifficultyRankText();
	Const.item.Index GetTargetItemIndex();
	Const.creature.Index GetTargetPokemonIndex();
	void SetWindotTextTag();
	List<QuestReward.Item> GetRewardItems();
	QuestReward.Pokemon GetRewardPokemon();
	int GetRewardRankPoint();
	int GetRewardMoney();
	bool IsMenuHidden();
	bool IsWonderMailTicket();
	uint GetFixedHash();
}

