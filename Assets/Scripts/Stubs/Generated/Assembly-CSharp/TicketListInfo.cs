/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.dungeon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class TicketListInfo // TypeDefIndex: 6459
{
	// Fields
	public IJobTicket m_ticket; // 0x10
	public bool m_bNews; // 0x18
	public Index m_nDungeonIndex; // 0x1C
	public int m_nFloor; // 0x20
	public bool m_bImpossible; // 0x24
	public bool m_bComplete; // 0x25
	public bool m_bForceFaceDisable; // 0x26
	public bool m_bScenarioEvent; // 0x27
	public bool m_bWander; // 0x28
	public bool m_bForceDisableExecution; // 0x29
	public int m_nSortKey; // 0x2C

	// Constructors
	public TicketListInfo() {} // 0x00923640-0x00923650

	// Methods
	public void SetTicket(QuestTicket ticket) {} // 0x00923370-0x00923460
	public QuestTicket GetQuestTicket() => default; // 0x00923460-0x00923500
	public void SetTicket(FriendRescueTicket ticket) {} // 0x00923500-0x009235A0
	public FriendRescueTicket GetFriendRescueTicket() => default; // 0x009235A0-0x00923640
}

