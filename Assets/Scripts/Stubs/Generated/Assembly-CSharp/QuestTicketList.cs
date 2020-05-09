/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.dungeon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class QuestTicketList : Singleton<QuestTicketList>, IQuestTicketList // TypeDefIndex: 5215
{
	// Properties
	public int Max { get => default; } // 0x009F5C80-0x009F5CF0 

	// Constructors
	public QuestTicketList() {} // 0x009F8770-0x009F87E0

	// Methods
	public List<IQuestTicket> GetList() => default; // 0x009F35F0-0x009F37B0
	public List<IJobTicket> GetJobTicketList() => default; // 0x009F7950-0x009F7AE0
	public List<IQuestTicket> GetListFromDungeon(Index index) => default; // 0x009F7AE0-0x009F7C70
	public int CalcExecutionNum() => default; // 0x009F7C70-0x009F7DC0
	public bool CheckExistRewardStatus() => default; // 0x009F7DC0-0x009F7F10
	public bool IsFriendResuceList() => default; // 0x009F7F10-0x009F7F20
	public void DestoryFinishTickets() {} // 0x009F7F20-0x009F8070
	public int PenaltyQuestTicketForDungeonTerminate(Index index) => default; // 0x009F8070-0x009F80E0
	public bool IsFull() => default; // 0x009F80E0-0x009F8150
	public IQuestTicket GetDupulicateQuest(Index index, int floor) => default; // 0x009F8150-0x009F82E0
	public bool HaveSameQuest(QuestWonderMailTicket ticket) => default; // 0x009F82E0-0x009F84D0
	public bool HaveQuestIsAllSuspended() => default; // 0x009F84D0-0x009F8770
}

