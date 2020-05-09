/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.dungeon;
using Const.dungeon.status;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class DungeonTopScreen : MonoBehaviour // TypeDefIndex: 4638
{
	// Fields
	private static readonly StatusAnimation[] s_aStatusAnimation; // 0x00
	private readonly string[] DisplayStatusToken; // 0x18
	private DungeonEngine m_dungeon; // 0x20
	private DisplayStatus[] m_aDisplayStatus; // 0x28
	private Dictionary<int, int> m_dicMemberIdToTeamIndex; // 0x30
	private GameObject m_root; // 0x38
	private GameObject m_rootAuto; // 0x40
	private GameObject m_obj; // 0x48
	private CanvasGroup m_objCanvas; // 0x50
	private Const.dungeon.Index m_dungeonIndex; // 0x58
	private GameObject m_floorSetRef; // 0x60
	private GameObject m_weatherSetRef; // 0x68
	private AutoButton m_autoButtonRef; // 0x70
	private GameObject m_autoButtonObject; // 0x78
	private GameObject m_autoModeCenterRing; // 0x80
	private CommonScreen m_commonScreen; // 0x88
	private TempFriendDisplay m_tempFriendWindow; // 0x90
	private Dictionary<Const.dungeon.status.Index, string> m_dicWeather; // 0x98
	private GameObject m_logWindowObject; // 0xA0
	private Const.dungeon.status.Index m_dungeonStatus; // 0xA8
	private int m_floor; // 0xAC
	private bool m_bDungeonVisible; // 0xB0
	private bool m_bFloorVisible; // 0xB1
	private bool m_bButtonGuideVisible; // 0xB2
	private bool m_bVisible; // 0xB3
	private DirtyFlag m_dirtyFlag; // 0xB8

	// Properties
	public AutoButton AutoButtonObject { get => default; } // 0x00BBFC60-0x00BBFC70 
	public AutoWalkCenterRing AutoRing { get => default; } // 0x00BBFC70-0x00BBFCC0 
	public GameObject LogWindowObject { get => default; } // 0x00BBFCC0-0x00BBFCD0 

	// Nested types
	private struct StatusAnimation // TypeDefIndex: 4639
	{
		// Fields
		public string hungryReset; // 0x10
		public string hungryColorChange; // 0x18
		public string pinchColorReset; // 0x20
		public string pinchColorChange; // 0x28

		// Constructors
		public StatusAnimation(string _hungryReset, string _hungryColorChange, string _pinchColorReset, string _pinchColorChange) {
			hungryReset = default;
			hungryColorChange = default;
			pinchColorReset = default;
			pinchColorChange = default;
		} // 0x00BC37F0-0x00BC3800
	}

	private class DisplayStatus // TypeDefIndex: 4640
	{
		// Fields
		public ulong nativePointerId; // 0x10
		public uint nativeUniqueId; // 0x18
		public PartyMemberId memberId; // 0x1C
		public string name; // 0x20
		public Const.creature.Index face; // 0x28
		public int order; // 0x2C
		public int level; // 0x30
		public int hp; // 0x34
		public int maxHp; // 0x38
		public int belly; // 0x3C
		public int maxBelly; // 0x40
		public bool bVisible; // 0x44
		public bool bHpDamage; // 0x45
		public bool bHpAppear; // 0x46
		public bool bHpDisappear; // 0x47
		public bool bPP0; // 0x48
		public bool bAllUpdate; // 0x49
		public bool bBellyZeroAnime; // 0x4A
		public bool bPinchAnime; // 0x4B

		// Constructors
		public DisplayStatus() {} // 0x00BC03A0-0x00BC03B0

		// Methods
		public void Reset() {} // 0x00BC3670-0x00BC37F0
	}

	private class DirtyFlag // TypeDefIndex: 4641
	{
		// Fields
		public bool bVisible; // 0x10
		public bool bDungeon; // 0x11
		public bool bWeather; // 0x12
		public bool bFloor; // 0x13
		public bool bButtonGuide; // 0x14
		public StatusFlag[] aStatus; // 0x18

		// Nested types
		public class StatusFlag // TypeDefIndex: 4642
		{
			// Fields
			public bool bLevel; // 0x10
			public bool bHp; // 0x11
			public bool bBelly; // 0x12
			public bool bPP0; // 0x13
			public bool bVisible; // 0x14
			public bool bOther; // 0x15

			// Constructors
			public StatusFlag() {} // 0x00BC3650-0x00BC3660

			// Methods
			public void Reset() {} // 0x00BC3660-0x00BC3670
			public void SetAll() {} // 0x00BC1340-0x00BC1360
			public bool IsDirty() => default; // 0x00BC2A30-0x00BC2A90
		}

		// Constructors
		public DirtyFlag() {} // 0x00BC3170-0x00BC32D0
	}

	// Constructors
	public DungeonTopScreen() {} // 0x00BC2F40-0x00BC3170
	static DungeonTopScreen() {} // 0x00BC32D0-0x00BC3440

	// Methods
	private void Start() {} // 0x00BBFCD0-0x00BC03A0
	private void SafeDestroyCanvasObject(ref GameObject obj) {} // 0x00BC03B0-0x00BC04B0
	private void OnDestroy() {} // 0x00BC04B0-0x00BC06A0
	public GameObject GetDungeonMainScreen() => default; // 0x00BC06A0-0x00BC06B0
	public void SetDungeon(DungeonEngine dungeon) {} // 0x00BC06B0-0x00BC06C0
	public bool UpdateTeamInfo() => default; // 0x00BC06C0-0x00BC08C0
	public void SetVisibleFromNative(bool bVisible) {} // 0x00BC08C0-0x00BC0940
	public bool IsVisible() => default; // 0x00BC0B00-0x00BC0B10
	public void SetDungeonFromNative(Const.dungeon.Index dungeon) {} // 0x00BC0B10-0x00BC0B40
	public void SetDungeonVisibleFromNative(bool bVisible) {} // 0x00BC0B40-0x00BC0B70
	public void SetDungeonFloorFromNative(int floor) {} // 0x00BC0B70-0x00BC0B90
	public void SetDungeonFloorVisibleFromNative(bool bVisible) {} // 0x00BC0B90-0x00BC0BC0
	public void SetButtonGuideVisibleFromNative(bool bVisible) {} // 0x00BC0BC0-0x00BC0BF0
	public void SetButtonGuideVisible(bool bVisible) {} // 0x00BC0BF0-0x00BC0C20
	public void SetDungeonStatusFromNative(Const.dungeon.status.Index index) {} // 0x00BC0C20-0x00BC0C40
	public void SetPokemonStatusFromNative(ulong nativePointerId, uint nativeUniqueId, int displayId, PartyMemberId partMemberId, bool bForceUpdate) {} // 0x00BC0C40-0x00BC1280
	public void SetVisibleStatusFromNative(bool bVisible, int displayId) {} // 0x00BC1280-0x00BC1340
	public void SetPokemonPP0FromNative(int displayId, bool bPP0) {} // 0x00BC1360-0x00BC1420
	private void UpdateScreen() {} // 0x00BC1420-0x00BC1A80
	private void UpdateStatus(int diplayId, DirtyFlag.StatusFlag dirty, DisplayStatus displayStatus) {} // 0x00BC1A80-0x00BC2A30
	private void Update() {} // 0x00BC2A90-0x00BC2B20
	public GameObject GetDisplayObject(int index) => default; // 0x00BC2B20-0x00BC2C30
	public int GetDisplayCount() => default; // 0x00BC2C30-0x00BC2CC0
	public int GetMemberId(int index) => default; // 0x00BC2CC0-0x00BC2D80
	public int GetOrderId(int index) => default; // 0x00BC2D80-0x00BC2DF0
	public void SetGeneralGuide(bool lookMode, bool visible = true /* Metadata: 0x00610A8C */) {} // 0x00BC0940-0x00BC0AB0
	public void VisibleGeneralGuide(bool visible) {} // 0x00BC0AB0-0x00BC0B00
	// [IteratorStateMachine] // 0x0061A7A0-0x0061A810
	public IEnumerator TempFriendWindow_Open(IPokemonStatus status) => default; // 0x00BC2DF0-0x00BC2E70
	// [IteratorStateMachine] // 0x0061A810-0x0061A880
	public IEnumerator TempFriendWindow_Close() => default; // 0x00BC2EA0-0x00BC2F10
}

