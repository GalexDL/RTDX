/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.dungeon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PelipperShopParam // TypeDefIndex: 5326
{
	// Fields
	private static PelipperShopParam param_; // 0x00
	private UIPelipper ui; // 0x10
	private UIPelipper.States nowStates; // 0x18
	private bool interNet_; // 0x1C
	private MyRequestState myRequestState_; // 0x20
	private RescueRequestWindow.ThanksType thanksType_; // 0x24
	private bool bFromTop; // 0x28
	private int thanksCount; // 0x2C
	private int thanksLoopCount; // 0x30
	private Index dungeonIndex; // 0x34
	private PelipperResultType resultType; // 0x38
	private int presetNumber; // 0x3C
	private FriendRescueTicket selectTicket; // 0x40
	private string passwordString; // 0x48
	private string userIdString; // 0x50
	private FlowEndType endType_; // 0x58
	private Index reviveDungeonIndex_; // 0x5C
	private int reviveFloor_; // 0x60
	private bool dungeonRushMode_; // 0x64
	public bool bDontReGetList_; // 0x65
	private InternetErrorType internetErrorType_; // 0x68
	private InternetGetListType internetGetListType_; // 0x6C
	private SearchType searchType_; // 0x70
	private List<IFriendRescueTicket> oldTemporaryList; // 0x78
	private string myUserId; // 0x80
	public bool updateMessage; // 0x88
	private bool billboardContinue_; // 0x89
	private bool bGetTicketFromBillboard_; // 0x8A
	private Dictionary<uint, ulong> friendTicketDataDictionary_; // 0x90
	private Dictionary<ulong, bool> idFavoDictionary_; // 0x98

	// Properties
	public static PelipperShopParam Instance { get => default; } // 0x00B6D860-0x00B6D8B0 
	public static bool IsValid { get => default; } // 0x00B6D8B0-0x00B6D910 
	public UIPelipper UIInstance { get => default; } // 0x00B6D910-0x00B6D920 
	public UIPelipper.States NowStates { get => default; set {} } // 0x00B6D930-0x00B6D940 0x00B6D920-0x00B6D930
	public bool InterNet { get => default; set {} } // 0x00B6D940-0x00B6D950 0x00B6D950-0x00B6D960
	public MyRequestState MyRequestState_ { get => default; set {} } // 0x00B6D960-0x00B6D970 0x00B6D970-0x00B6D980
	public RescueRequestWindow.ThanksType ThanksType_ { get => default; set {} } // 0x00B6D980-0x00B6D990 0x00B6D990-0x00B6D9A0
	public bool FromTop { get => default; } // 0x00B6D9A0-0x00B6D9B0 
	public int ThanksCount { set {} } // 0x00B6D9B0-0x00B6D9C0
	public int ThanksLoopCount { get => default; set {} } // 0x00B6D9C0-0x00B6D9D0 0x00B6D9D0-0x00B6D9E0
	public Index DungeonIndex { get => default; set {} } // 0x00B6DA10-0x00B6DA20 0x00B6DA00-0x00B6DA10
	public PelipperResultType Result { get => default; set {} } // 0x00B6DA30-0x00B6DA40 0x00B6DA20-0x00B6DA30
	public int PresetNumber { get => default; set {} } // 0x00B6DA40-0x00B6DA50 0x00B6DA50-0x00B6DA60
	public FriendRescueTicket SelectTicket { get => default; set {} } // 0x00B6DA60-0x00B6DA70 0x00B6DA70-0x00B6DA80
	public string PasswordString { get => default; set {} } // 0x00B6DA80-0x00B6DA90 0x00B6DA90-0x00B6DAA0
	public string UserId { get => default; set {} } // 0x00B6DAF0-0x00B6DB00 0x00B6DB00-0x00B6DB10
	public FlowEndType EndType { get => default; set {} } // 0x00B6DB10-0x00B6DB20 0x00B6DB20-0x00B6DB30
	public Index ReviveDungeonIndex { get => default; set {} } // 0x00B6DB30-0x00B6DB40 0x00B6DB40-0x00B6DB50
	public int ReviveFloor { get => default; set {} } // 0x00B6DB50-0x00B6DB60 0x00B6DB60-0x00B6DB70
	public bool DungeonRushMode { get => default; set {} } // 0x00B6DB70-0x00B6DB80 0x00B6DB80-0x00B6DB90
	public InternetErrorType ErrorType { get => default; set {} } // 0x00B6DB90-0x00B6DBA0 0x00B6DBA0-0x00B6DBB0
	public InternetGetListType GetListType { get => default; set {} } // 0x00B6DBB0-0x00B6DBC0 0x00B6DBC0-0x00B6DBD0
	public SearchType SearchType_ { get => default; set {} } // 0x00B6DBD0-0x00B6DBE0 0x00B6DBE0-0x00B6DBF0
	public List<IFriendRescueTicket> OldTemporaryList { get => default; set {} } // 0x00B6DBF0-0x00B6DC00 0x00B6DC00-0x00B6DC10
	public string MyUserId { get => default; set {} } // 0x00B6DC10-0x00B6DC20 0x00B6DC20-0x00B6DC30
	public bool BillboardContinue { get => default; set {} } // 0x00B6DC90-0x00B6DCA0 0x00B6DCA0-0x00B6DCB0
	public bool bGetTicketFromBillboard { get => default; set {} } // 0x00B6DCB0-0x00B6DCC0 0x00B6DCC0-0x00B6DCD0
	public Dictionary<uint, ulong> FriendTicketDataDictionary { get => default; } // 0x00B6DCD0-0x00B6DCE0 

	// Nested types
	public enum MyRequestState // TypeDefIndex: 5327
	{
		NONE = 0,
		INTERNET = 1,
		PASSWORD = 2
	}

	public enum FlowEndType // TypeDefIndex: 5328
	{
		TERMINATE = 0,
		CONTINUE = 1
	}

	public enum InternetErrorType // TypeDefIndex: 5329
	{
		NONE = 0,
		UPLOAD_ERROR = 1,
		MAIL_RECEIVE_ERROR = 2,
		OTHER_ERROR = 3,
		LISTCOUNT_ZERO = 4,
		MAX = 5
	}

	public enum InternetGetListType // TypeDefIndex: 5330
	{
		NORMAL = 0,
		FRIEND = 1,
		USERID = 2,
		MAX = 3
	}

	public enum SearchType // TypeDefIndex: 5331
	{
		NORMAL = 0,
		FRIEND = 1,
		USERID = 2,
		RELOAD = 3,
		RETURN_ORIGINAL_LIST = 4,
		MAX = 5
	}

	// Constructors
	public PelipperShopParam() {} // 0x00B6D6D0-0x00B6D760

	// Methods
	public static PelipperShopParam Create(bool fromTop) => default; // 0x00B6D540-0x00B6D6D0
	public static void Delete() {} // 0x00B6D760-0x00B6D860
	public void ThanksLoopCountAdd() {} // 0x00B6D9E0-0x00B6D9F0
	public bool CheckThanksLoopCount() => default; // 0x00B6D9F0-0x00B6DA00
	public void ResetPasswordString() {} // 0x00B6DAA0-0x00B6DAF0
	public bool IsMyUserIdBeing() => default; // 0x00B6DC30-0x00B6DC90
	public void ResetFriendTicketDataDictionary() {} // 0x00B6DCE0-0x00B6DD50
	public void SetFriendTicketDataDictionary(uint internetUniqueId, ulong principalId) {} // 0x00B6DD50-0x00B6DDF0
	public void SetFriendData() {} // 0x00B6DDF0-0x00B6DFA0
	public bool IsFavoFriend(IFriendRescueTicket ticket) => default; // 0x00B6DFA0-0x00B6E0C0
	public ulong GetAccountId(IFriendRescueTicket ticket) => default; // 0x00B6E0C0-0x00B6E180
}

