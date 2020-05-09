/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class QuestBulletinBoard : Singleton<QuestBulletinBoard>, IQuestBulletinBoard // TypeDefIndex: 5207
{
	// Properties
	public int Max { get => default; } // 0x009F0290-0x009F02A0 

	// Constructors
	public QuestBulletinBoard() {} // 0x009F02A0-0x009F0310

	// Methods
	public List<IQuestTicket> GetQuestBulletinBoardTicketList() => default; // 0x009F0310-0x009F0520
	public IQuestTicket FindFromBurnId(uint burnId) => default; // 0x009F05A0-0x009F0700
	public bool IsExistFromBurnId(uint burnId) => default; // 0x009F0700-0x009F0720
	public void UpdateQuest() {} // 0x009F0720-0x009F0790
}

