/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.dungeon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class FriendRescueTicketList : Singleton<FriendRescueTicketList>, IFriendRescueTicketList // TypeDefIndex: 4654
{
	// Fields
	private List<FriendRescueTicket> internetSosList; // 0x10
	private bool bChangeListCount_; // 0x18
	private HashSet<uint> removeIdList_; // 0x20

	// Properties
	public int MaxSOSTicket { get => default; } // 0x00BA4930-0x00BA4940 
	public int MaxReviveTicket { get => default; } // 0x00BA4940-0x00BA4950 
	public int MaxTemporaryTicket { get => default; } // 0x00BA4950-0x00BA4960 

	// Nested types
	public class RescueDateData // TypeDefIndex: 4655
	{
		// Fields
		public DateType dateType; // 0x10
		public int value; // 0x14
		public bool isFull; // 0x18

		// Constructors
		public RescueDateData() {} // 0x00BA6250-0x00BA6260
	}

	public enum DateType // TypeDefIndex: 4656
	{
		NONE = 0,
		DAY = 1,
		HOUR = 2,
		MINITE = 3
	}

	// Constructors
	public FriendRescueTicketList() {} // 0x00BA7F60-0x00BA8000

	// Methods
	private List<IFriendRescueTicket> GetList() => default; // 0x00BA4960-0x00BA4B30
	public List<IJobTicket> GetJobTicketList() => default; // 0x00BA4B30-0x00BA4CF0
	public List<IFriendRescueTicket> GetTemporaryList() => default; // 0x00BA4CF0-0x00BA4E70
	public List<IFriendRescueTicket> GetSOSList_NoMyCreate() => default; // 0x00BA4E70-0x00BA5030
	public List<IFriendRescueTicket> GetSOSList() => default; // 0x00BA5030-0x00BA51D0
	public List<IFriendRescueTicket> GetSOSRescuedList() => default; // 0x00BA51D0-0x00BA5370
	public List<IFriendRescueTicket> GetReviveList(bool bSelfOnly) => default; // 0x00BA5370-0x00BA55F0
	public int CalcMyReviveNum() => default; // 0x00BA55F0-0x00BA5640
	public bool ChangeReviveToRevived() => default; // 0x00BA5640-0x00BA5780
	public List<IFriendRescueTicket> GetListFromDungeon(Index index, MailType type) => default; // 0x00BA5780-0x00BA5A40
	public bool IsFriendResuceList() => default; // 0x00BA5A40-0x00BA5A50
	public void AddInternetSosList(FriendRescueTicket ticket) {} // 0x00BA5A50-0x00BA5AB0
	public List<IFriendRescueTicket> GetInternetSosList() => default; // 0x00BA5AB0-0x00BA5C00
	public void ClearInternetSosList() {} // 0x00BA5C00-0x00BA5C50
	public void ClearTemporaryList() {} // 0x00BA5C50-0x00BA5DC0
	public void ClearTemporaryList_NumberSelect(int number) {} // 0x00BA5DC0-0x00BA5F50
	public List<IFriendRescueTicket> GetInternetRescuedList() => default; // 0x00BA5F50-0x00BA6090
	public RescueDateData GetRescueDateData(IFriendRescueTicket ticketData) => default; // 0x00BA6090-0x00BA6110
	public RescueDateData GetRescueDateData(PegasusTime.RemainTime remainTime) => default; // 0x00BA6110-0x00BA6250
	public bool DeleteExpiredTicket() => default; // 0x00BA6260-0x00BA6450
	public bool IsTimeLimitOver(IFriendRescueTicket ticketData) => default; // 0x00BA6450-0x00BA6540
	public bool IsTimeLimitOver(PegasusTime.RemainTime remainTime) => default; // 0x00BA6590-0x00BA6620
	public bool IsTimeLimitOver(RescueDateData rescueDateData) => default; // 0x00BA6540-0x00BA6590
	// [IteratorStateMachine] // 0x0061A880-0x0061A8F0
	public IEnumerator DeleteExpiredTicketMessage() => default; // 0x00BA6620-0x00BA6680
	public bool IsChange() => default; // 0x00BA66B0-0x00BA66C0
	public List<IFriendRescueTicket> GetTemporaryList_VariousFilter() => default; // 0x00BA66C0-0x00BA6780
	private List<IFriendRescueTicket> TMIFilter(List<IFriendRescueTicket> list) => default; // 0x00BA6780-0x00BA6A20
	public void SetRemoveIdList() {} // 0x00BA6A20-0x00BA6CF0
	private List<IFriendRescueTicket> GetTemporaryList_TimeFilter(List<IFriendRescueTicket> list) => default; // 0x00BA6CF0-0x00BA6F10
	private List<IFriendRescueTicket> GetTemporaryList_MineFilter(List<IFriendRescueTicket> list) => default; // 0x00BA6F10-0x00BA70F0
	private List<IFriendRescueTicket> GetTemporaryList_IncludeFilter(List<IFriendRescueTicket> list) => default; // 0x00BA70F0-0x00BA7470
	public static bool IsIncludePerformance(FriendRescueTicket ticket) => default; // 0x00BA7470-0x00BA7640
	public static bool IsIncludePerformance(uint uniqueSosKey) => default; // 0x00BA7690-0x00BA77D0
	public static bool IsIncludeSOSList(FriendRescueTicket ticket) => default; // 0x00BA7640-0x00BA7690
	public static bool IsIncludeSOSList(uint uniqueSosKey) => default; // 0x00BA77D0-0x00BA7970
	public void DeleteMySOS() {} // 0x00BA3DB0-0x00BA3EA0
	public IFriendRescueTicket GetMySOS() => default; // 0x00BA3FE0-0x00BA40C0
	public IFriendRescueTicket GetMySOS_NoFilter() => default; // 0x00BA7970-0x00BA7AB0
	public List<IFriendRescueTicket> GetDummyTicketList(int makeNum) => default; // 0x00BA7AB0-0x00BA7F60
}

