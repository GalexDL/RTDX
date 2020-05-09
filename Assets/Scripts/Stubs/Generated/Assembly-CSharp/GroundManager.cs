/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.camp;
using Const.creature;
using Const.item;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

// [DefaultExecutionOrder] // 0x006096D0-0x00609710
[ExecuteInEditMode] // 0x006096D0-0x00609710
public class GroundManager : SingletonMonoBehaviour<GroundManager> // TypeDefIndex: 4889
{
	// Fields
	[SerializeField] // 0x00616450-0x00616460
	private GroundTownNpcDatabase groundTonwNpcDatabase_; // 0x18
	public Stack<GroundPlayer> CurrentGroundPlayerStack; // 0x20
	[NonSerialized]
	public bool UseYesterdayPostHasLetterFlag; // 0x28
	[NonSerialized]
	public bool YesterdayPostHasLetterFlag; // 0x29
	[NonSerialized]
	public bool RequestPostLetterHaitatsuEvent; // 0x2A
	[NonSerialized]
	public List<PokemonWarehouseId> LastPartyMemberId; // 0x30
	[NonSerialized]
	public Const.creature.Index LastLeaderIndex; // 0x38
	[NonSerialized]
	public JiraachiRewardType JiraachiReward; // 0x3C
	[NonSerialized]
	public Const.creature.Index JiraachiReward_NakamaIndex; // 0x40
	[NonSerialized]
	public Const.camp.Index JiraachiReward_CampIndex; // 0x44
	[NonSerialized]
	public int JiraachiReward_Money; // 0x48
	[NonSerialized]
	public List<IItem> JiraachiReward_Items; // 0x50
	[NonSerialized]
	public Const.item.Index Gonbe_ItemIndex; // 0x58
	[NonSerialized]
	public bool ForceMoveStartPosition; // 0x5C
	[NonSerialized]
	public bool Debug_RequestNextDay; // 0x5D
	[NonSerialized]
	public bool Debug_RequestReturnTop; // 0x5E
	[NonSerialized]
	public bool Debug_RequestNennotameSave; // 0x5F
	[NonSerialized]
	public bool Debug_RequestForceCallNextDayUpdate; // 0x60

	// Properties
	public GroundTownNpcDatabase GroundTownNpcDatabase { get => default; } // 0x00731450-0x00731460 
	public GroundPlayer CurrentGroundPlayer { get => default; } // 0x00731500-0x00731580 

	// Events
	public event GroundPlayer_Start onGroundPlayer_start;
	public event GroundPlayer_MapChange onGroundPlayer_mapChange;

	// Nested types
	public enum JiraachiRewardType // TypeDefIndex: 4890
	{
		None = 0,
		Money = 1,
		Item = 2,
		Camp = 3,
		PowerUp = 4,
		GoodEvent = 5
	}

	public delegate void GroundPlayer_Start(string npcStepSymbol); // TypeDefIndex: 4891; 0x00732E50-0x00733410

	public delegate void GroundPlayer_MapChange(string mapId); // TypeDefIndex: 4892; 0x00733420-0x007339E0

	// Constructors
	public GroundManager() {} // 0x007339E0-0x00733B10

	// Methods
	private void OnEnable() {} // 0x00731460-0x007314D0
	private void OnDisable() {} // 0x007314D0-0x007314E0
	private void Start() {} // 0x007314E0-0x007314F0
	private void Update() {} // 0x007314F0-0x00731500
	public void Update_PostLetter() {} // 0x00731580-0x00731620
	public void ClearPostLetterYesterdayFlag() {} // 0x00731620-0x00731630
	public void SetPostLetterYesterdayFlag(bool flag) {} // 0x00731630-0x00731650
	public void UpdatePostLetterVisible() {} // 0x00731650-0x00731900
	public bool GetCurrentPostHasLetterFlag() => default; // 0x00731900-0x00731990
	public void Force_PostLetterVisible(bool bVisible) {} // 0x00731990-0x00731BC0
	public void ResetJiraachiReward() {} // 0x00731BC0-0x00731C20
	public void NextDay() {} // 0x00731C20-0x00731FC0
	public void SuspendGround() {} // 0x00731FE0-0x00732060
	public void ResumeGround() {} // 0x00732480-0x00732500
	public void Debug_BgModify(Action<ActObjMapBg> applyBg) {} // 0x00732890-0x00732A00
	public void Raise_GroundPlayer_Start(string npcStepSymbol) {} // 0x00732E40-0x00732E50
	public void Raise_GroundPlayer_MapChange(string mapId) {} // 0x00733410-0x00733420
}

