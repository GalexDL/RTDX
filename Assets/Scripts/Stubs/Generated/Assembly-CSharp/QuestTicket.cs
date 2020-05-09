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

public class QuestTicket : IQuestTicket, IJobTicket // TypeDefIndex: 5214
{
	// Fields
	private ulong m_nativePointerId; // 0x10
	private static string[] iconDifficulty; // 0x00

	// Properties
	public ulong NativePointerId { get => default; } // 0x009F5FA0-0x009F5FB0 
	public bool Valid { get => default; } // 0x009F5FB0-0x009F5FC0 

	// Constructors
	public QuestTicket() {} // Dummy constructor
	public QuestTicket(ulong nativeUnitqueId) {} // 0x009F0790-0x009F07C0
	static QuestTicket() {} // 0x009F74E0-0x009F7950

	// Methods
	public void Destroy() {} // 0x009F5FC0-0x009F6040
	public Const.creature.Index GetClientIndex() => default; // 0x009F6040-0x009F60B0
	public GenderType GetClientGenderType() => default; // 0x009F60B0-0x009F60C0
	public string GetClientName() => default; // 0x009F60C0-0x009F6180
	public bool IsGround() => default; // 0x009F6180-0x009F61F0
	public bool IsDungeon() => default; // 0x009F61F0-0x009F6260
	public Const.quest.Kind GetQuestKind() => default; // 0x009F6260-0x009F62D0
	public Variation GetExecuteVariation() => default; // 0x009F62D0-0x009F6340
	public bool IsQuestWithClient() => default; // 0x009F6340-0x009F63C0
	public virtual bool IsNewsTicket() => default; // 0x009F63C0-0x009F63D0
	public virtual bool IsFriendRescueTicket() => default; // 0x009F63D0-0x009F63E0
	public bool IsRequest() => default; // 0x009F3580-0x009F35F0
	public bool IsExecution() => default; // 0x009F54E0-0x009F5550
	public bool IsComplete() => default; // 0x009F63E0-0x009F64D0
	public bool IsCompleteReward() => default; // 0x009F64D0-0x009F6540
	public bool IsCompleteFailed() => default; // 0x009F6540-0x009F65B0
	public bool IsFinish() => default; // 0x009F5400-0x009F5470
	public void SetStatusReqest() {} // 0x009F65B0-0x009F6620
	public void SetStatusExecution() {} // 0x009F6620-0x009F6690
	public void SetStatusCompleteReward() {} // 0x009F6690-0x009F6700
	public void SetStatusCompleteFailed() {} // 0x009F6700-0x009F6770
	public void SetStatusFinish() {} // 0x009F6770-0x009F67E0
	public bool IsPoolBulletinBoard() => default; // 0x009F5550-0x009F55C0
	public bool IsPoolQuestTicketList() => default; // 0x009F5470-0x009F54E0
	public uint GetBurnId() => default; // 0x009F67E0-0x009F6850
	public string GetTitleText() => default; // 0x009F6850-0x009F6940
	public string GetExplanationText0() => default; // 0x009F6940-0x009F6A30
	public string GetExplanationText1() => default; // 0x009F6A30-0x009F6B20
	public string GetPurposeText() => default; // 0x009F6B20-0x009F6C10
	public Const.dungeon.Index GetTargetDungeonIndex() => default; // 0x009F52B0-0x009F5320
	public int GetTargetDungeonFloor() => default; // 0x009F5390-0x009F5400
	public int GetDifficultyRank() => default; // 0x009F6C10-0x009F6C80
	public string GetDifficultyRankText() => default; // 0x009F6C80-0x009F6D70
	public bool IsWonderMailTicket() => default; // 0x009F6D70-0x009F6DE0
	public uint GetFixedHash() => default; // 0x009F6DE0-0x009F6E50
	public static string GetDifficultyRankIcon(int rank) => default; // 0x009F6E50-0x009F6EF0
	public string GetDifficultyRankIcon() => default; // 0x009F29B0-0x009F2B00
	public List<QuestReward.Item> GetRewardItems() => default; // 0x009F6EF0-0x009F70C0
	public QuestReward.Pokemon GetRewardPokemon() => default; // 0x009F70C0-0x009F7230
	public int GetRewardRankPoint() => default; // 0x009F7230-0x009F72A0
	public int GetRewardMoney() => default; // 0x009F72A0-0x009F7310
	public Const.item.Index GetTargetItemIndex() => default; // 0x009F5240-0x009F52B0
	public Const.creature.Index GetTargetPokemonIndex() => default; // 0x009F51D0-0x009F5240
	public void SetWindotTextTag() {} // 0x009F5320-0x009F5390
	public bool IsMissionImpossible() => default; // 0x009F7310-0x009F7380
	public bool IsMenuHidden() => default; // 0x009F7380-0x009F73F0
	public bool IsEventQuest() => default; // 0x009F73F0-0x009F7470
	public void AddList() {} // 0x009F7470-0x009F74E0
}

