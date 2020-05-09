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
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

[Serializable]
public class FriendRescueTicketData // TypeDefIndex: 4646
{
	// Fields
	public MailType mailType; // 0x10
	[SerializeField] // 0x00615FF0-0x00616000
	private PegasusTime.POSIX32 time; // 0x14
	[SerializeField] // 0x00616000-0x00616010
	private PegasusTime.POSIX32 timeOriginal; // 0x18
	public string sosMailSendPlayerName; // 0x20
	public string sosMailSendTeamName; // 0x28
	public string reviveMailSendPlayerName; // 0x30
	public string reviveMailSendTeamName; // 0x38
	public ThunksPresentType presentType; // 0x40
	public Const.dungeon.Index dungeon; // 0x44
	public int floorNo; // 0x48
	public Const.creature.Index index; // 0x4C
	public GenderType gender; // 0x50
	public int remainCount; // 0x54

	// Properties
	public PegasusTime.POSIX32 SOSCreateTime { get => default; } // 0x00BA32E0-0x00BA32F0 

	// Constructors
	public FriendRescueTicketData() {} // 0x00BA3820-0x00BA3830

	// Methods
	public string DumpText(string dump) => default; // 0x00BA32F0-0x00BA35F0
	public void FromNative(DataExchangeByteMemoryStream byteStream) {} // 0x00BA35F0-0x00BA3710
	public void ToNative(DataExchangeByteMemoryStream byteStream) {} // 0x00BA3710-0x00BA3820
}

