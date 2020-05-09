/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class FriendRescueTicketHistory : Singleton<FriendRescueTicketHistory> // TypeDefIndex: 4650
{
	// Fields
	private List<uint> uniqueIdList_; // 0x10
	private List<uint> uniqueIdList_internet_; // 0x18
	private bool dungeonQuestBeing_; // 0x20
	private bool rescueCreateAnnounce_; // 0x21
	private int rescueCount_; // 0x24
	private NameChangeState nameChangeState_; // 0x28

	// Properties
	public bool DungeonQuestBeing { get => default; set {} } // 0x00BA3CF0-0x00BA3D00 0x00BA3D00-0x00BA3D10
	public bool RescueCreateAnnounce { get => default; set {} } // 0x00BA3D10-0x00BA3D20 0x00BA3D20-0x00BA3D30
	public int RescueCount { get => default; set {} } // 0x00BA3EB0-0x00BA3EC0 0x00BA3EA0-0x00BA3EB0
	public NameChangeState NameChangeState_ { get => default; } // 0x00BA3EE0-0x00BA3EF0 

	// Nested types
	[Serializable]
	public enum NameChangeState // TypeDefIndex: 4651
	{
		NONE = 0,
		NAMECHANGE = 1,
		ANNOUNCE = 2,
		MAX = 3
	}

	[Serializable]
	public class SaveData // TypeDefIndex: 4652
	{
		// Fields
		[SerializeField] // 0x006184D0-0x006184E0
		public uint[] idArray_; // 0x10
		[SerializeField] // 0x006184E0-0x006184F0
		public uint[] idArrayInternet_; // 0x18
		[SerializeField] // 0x006184F0-0x00618500
		public bool rescueCreateAnnounce_; // 0x20
		[SerializeField] // 0x00618500-0x00618510
		public int rescueCount_; // 0x24
		[SerializeField] // 0x00618510-0x00618520
		public NameChangeState nameChangeState_; // 0x28
		[SerializeField] // 0x00618520-0x00618530
		public bool dungeonQuestBeing_; // 0x2C

		// Constructors
		public SaveData() {} // 0x00BA4190-0x00BA4210

		// Methods
		public void OnPreSave() {} // 0x00BA4210-0x00BA4460
		public void OnAfterLoad() {} // 0x00BA4460-0x00BA46B0
		public void Reset() {} // 0x00BA46B0-0x00BA4930
	}

	// Constructors
	public FriendRescueTicketHistory() {} // 0x00BA40D0-0x00BA4190

	// Methods
	public bool IsIncludeHistory(uint id) => default; // 0x00BA3830-0x00BA3960
	public void SetId(uint Id) {} // 0x00BA3960-0x00BA3A00
	public uint GetId(int index) => default; // 0x00BA3A00-0x00BA3A90
	public bool IsIncludeHistory_internet(uint id) => default; // 0x00BA3A90-0x00BA3BC0
	public void SetId_Internet_(uint Id) {} // 0x00BA3BC0-0x00BA3C60
	public uint GetId_Internet_(int index) => default; // 0x00BA3C60-0x00BA3CF0
	public void OnDungeonFailedAfter() {} // 0x00BA3D30-0x00BA3DB0
	public void AddRescueCount() {} // 0x00BA3EC0-0x00BA3EE0
	public void SetAnnounceState() {} // 0x00BA3EF0-0x00BA3F00
	public void SetRescueRequestAfterNameChange(bool nameChange) {} // 0x00BA3F00-0x00BA3FE0
	public void ResetState() {} // 0x00BA40C0-0x00BA40D0
}

