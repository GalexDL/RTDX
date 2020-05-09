/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.creature;
using Const.dungeon;
using Const.pokemon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class FriendRescueTicket : IFriendRescueTicket, IJobTicket // TypeDefIndex: 4648
{
	// Fields
	private ulong nativePointerId; // 0x10

	// Properties
	public ulong NativePointerId { get => default; } // 0x009AD9E0-0x009AD9F0 
	public bool Valid { get => default; } // 0x009AD9F0-0x009ADA00 

	// Nested types
	public class FriendRescueTicket_Temp // TypeDefIndex: 4649
	{
		// Fields
		public Const.dungeon.Index dungeonIndex_; // 0x10
		public int floorIndex_; // 0x14
		public uint sosKey_; // 0x18

		// Constructors
		public FriendRescueTicket_Temp() {} // 0x00BA32D0-0x00BA32E0
	}

	// Constructors
	public FriendRescueTicket() {} // Dummy constructor
	public FriendRescueTicket(ulong nativeUnitqueId) {} // 0x009ADAB0-0x009ADAE0

	// Methods
	public static FriendRescueTicket CreateSOS(Const.dungeon.Index dungeon, int floor) => default; // 0x009ADA00-0x009ADAB0
	public static FriendRescueTicket CreateOtherSOS(Const.dungeon.Index dungeon, int floor, bool internet) => default; // 0x009ADAE0-0x009ADC90
	public static FriendRescueTicket CreatePassword(string password, MailType checkMailType) => default; // 0x009ADE10-0x009ADFD0
	public static FriendRescueTicket_Temp CreatePassword_SuccessCheckOnly(string password, MailType checkMailType) => default; // 0x009AE150-0x009AE420
	public static FriendRescueTicket CreateFromJSON(string json, bool bTemp = false /* Metadata: 0x00610A8E */) => default; // 0x009AE570-0x009AE680
	public void Destroy() {} // 0x009AE0D0-0x009AE150
	public bool IsTemporary() => default; // 0x009AE700-0x009AE770
	public Const.creature.Index GetSOSClientIndex() => default; // 0x009AE770-0x009AE7E0
	public uint GetUniqueSosKey() => default; // 0x009AE500-0x009AE570
	public GenderType GetSOSClientGenderType() => default; // 0x009AE7E0-0x009AE7F0
	public string GetSOSClientName() => default; // 0x009AE7F0-0x009AE8B0
	public bool IsSOSMail() => default; // 0x009AE8B0-0x009AE930
	public bool IsSOSRescued() => default; // 0x009AE930-0x009AEA10
	public bool IsReviveMail() => default; // 0x009AEA10-0x009AEA90
	public bool IsRevivedMail() => default; // 0x009AEA90-0x009AEB10
	public FriendRescueTicketData GetData() => default; // 0x009AEB10-0x009AEC50
	public void ToNativeUpdate(FriendRescueTicketData data) {} // 0x009AEC50-0x009AED70
	public void SetMailType(MailType type) {} // 0x009AED70-0x009AEDF0
	public MailType GetMailType() => default; // 0x009AE060-0x009AE0D0
	public bool IsMyCreate() => default; // 0x009AEDF0-0x009AEE60
	public void SetMyMail(bool bEnable) {} // 0x009ADC90-0x009ADD10
	public void InToInternetBillboard() {} // 0x009AEE60-0x009AEED0
	public PegasusTime.POSIX32 GetSOSCreateTime() => default; // 0x009AEED0-0x009AEF60
	public PegasusTime.RemainTime GetRemainTime(int afterDay) => default; // 0x009AEF60-0x009AF020
	public void SetTime(PegasusTime.POSIX32 time) {} // 0x009AF020-0x009AF0B0
	public void SetSOSMailSendPlayerName(string playerName) {} // 0x009AF0B0-0x009AF130
	public void SetSOSMailSendTeamName(string partyName) {} // 0x009AF130-0x009AF1B0
	public string GetSOSMailSendPlayerName() => default; // 0x009AF1B0-0x009AF2D0
	public string GetSOSMailSendTeamName() => default; // 0x009AF2D0-0x009AF3F0
	public string GetSOSMailSendTeamName_ReplaceNGWord() => default; // 0x009AF3F0-0x009AF410
	public void SetReviveMailSendPlayerName(string playerName) {} // 0x009AF410-0x009AF490
	public string GetReviveMailSendPlayerName() => default; // 0x009AF490-0x009AF5B0
	public void SetReviveMailSendTeamName(string teamName) {} // 0x009AF5B0-0x009AF630
	public string GetReviveMailSendTeamName() => default; // 0x009AF630-0x009AF750
	public string GetReviveMailSendTeamName_ReplaceNGWord() => default; // 0x009AF750-0x009AF770
	public Const.dungeon.Index GetSOSDungeon() => default; // 0x009AF770-0x009AF7E0
	public int GetSOSFloor() => default; // 0x009AE490-0x009AE500
	public Const.creature.Index GetSOSCreature() => default; // 0x009AF7E0-0x009AF850
	public GenderType GetSOSGenderType() => default; // 0x009AF850-0x009AF8C0
	public void SetPresentType(ThunksPresentType type) {} // 0x009AF8C0-0x009AF940
	public ThunksPresentType GetPresentType() => default; // 0x009AF940-0x009AF9B0
	public void SetRemainCount(int count) {} // 0x009AF9B0-0x009AFA30
	public Const.dungeon.Index GetSOSDungeonIndex() => default; // 0x009AE420-0x009AE490
	public int GetSOSDungeonFloor() => default; // 0x009AFA30-0x009AFAA0
	public int GetDifficultyRank() => default; // 0x009AFAA0-0x009AFB10
	public int GetRescuedNo() => default; // 0x009AFB10-0x009AFB80
	public bool IsValidRescuedNo() => default; // 0x009AFB80-0x009AFBF0
	public void SetPasswordSOSSendedRecievedMarking(bool bEnable) {} // 0x009ADD90-0x009ADE10
	public void SetInternetSOSSendedRecievedMarking(bool bEnable) {} // 0x009ADD10-0x009ADD90
	public bool IsPasswordSOSSendedRecievedMarking() => default; // 0x009AFBF0-0x009AFC60
	public bool IsInternetSOSSendedRecievedMarking() => default; // 0x009AFC60-0x009AFCD0
	public void SetInternetUniqueId(uint uniqueId) {} // 0x009AFCD0-0x009AFD50
	public uint GetInternetUniqueId() => default; // 0x009AFD50-0x009AFDC0
	public bool CheckEnablePassword(string password) => default; // 0x009AFDC0-0x009AFE40
	public static uint CalcUniqueKeyFromPassword(string password) => default; // 0x009AFE40-0x009AFEB0
	public bool DecodePassword(string password) => default; // 0x009ADFD0-0x009AE060
	public string EncodePassword(bool bUpdateSOSUniqueId = false /* Metadata: 0x00610A8F */) => default; // 0x009AFEB0-0x009AFFD0
	public string SerializeJSON() => default; // 0x009AFFD0-0x009AFFF0
	private static void DeserializeJson_Value(FriendRescueTicket ticket, string jsonText) {} // 0x009AE680-0x009AE700
	public void DisableTemopary() {} // 0x009AFFF0-0x009B0060
	public bool IsMissionImpossible() => default; // 0x009B0060-0x009B00D0
	public bool CheckDataValue() => default; // 0x009B00D0-0x009B0140
	public void SetDepopulationDummy(bool bEnable) {} // 0x009B0140-0x009B01C0
	public bool IsDepopulationDummy() => default; // 0x009B01C0-0x009B0230
	public static FriendRescueTicket CreateDummyTicket(uint uniqueId, int floorNo = 0 /* Metadata: 0x00610A90 */, Const.dungeon.Index dungeonIndex = Const.dungeon.Index.NONE /* Metadata: 0x00610A94 */) => default; // 0x009B0230-0x009B08D0
}

