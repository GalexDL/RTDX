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

public interface IFriendRescueTicket // TypeDefIndex: 4647
{
	// Methods
	FriendRescueTicketData GetData();
	void Destroy();
	bool IsTemporary();
	bool IsSOSMail();
	bool IsSOSRescued();
	bool IsReviveMail();
	bool IsMyCreate();
	void SetMyMail(bool bEnable);
	void SetMailType(MailType type);
	MailType GetMailType();
	void SetTime(PegasusTime.POSIX32 time);
	PegasusTime.POSIX32 GetSOSCreateTime();
	PegasusTime.RemainTime GetRemainTime(int afterDay);
	void SetSOSMailSendPlayerName(string playerName);
	string GetSOSMailSendPlayerName();
	void SetSOSMailSendTeamName(string partyName);
	string GetSOSMailSendTeamName();
	string GetSOSMailSendTeamName_ReplaceNGWord();
	void SetReviveMailSendPlayerName(string partyName);
	string GetReviveMailSendPlayerName();
	void SetReviveMailSendTeamName(string partyName);
	string GetReviveMailSendTeamName();
	string GetReviveMailSendTeamName_ReplaceNGWord();
	Const.dungeon.Index GetSOSDungeonIndex();
	int GetSOSDungeonFloor();
	Const.creature.Index GetSOSCreature();
	GenderType GetSOSGenderType();
	void SetPresentType(ThunksPresentType type);
	ThunksPresentType GetPresentType();
	int GetDifficultyRank();
	int GetRescuedNo();
	bool IsValidRescuedNo();
	void SetPasswordSOSSendedRecievedMarking(bool bEnable);
	void SetInternetSOSSendedRecievedMarking(bool bEnable);
	bool IsPasswordSOSSendedRecievedMarking();
	bool IsInternetSOSSendedRecievedMarking();
	void SetRemainCount(int count);
	bool DecodePassword(string password);
	string EncodePassword(bool bUpdateSOSUniqueKey = false /* Metadata: 0x00610A8D */);
	string SerializeJSON();
	uint GetInternetUniqueId();
	void SetInternetUniqueId(uint id);
	void DisableTemopary();
	uint GetUniqueSosKey();
	bool CheckDataValue();
	bool IsDepopulationDummy();
}

