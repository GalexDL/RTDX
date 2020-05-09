/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.camp;
using Const.pokemon;
using SpecialAnim;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class CampPokemonSelectWindow : UIWindowBase // TypeDefIndex: 6133
{
	// Fields
	private PokemonSortData pokemonSortData_; // 0x30
	private IPokemonWarehouseStatus oldPokemonWarehouseStatus_; // 0x38
	private int oldCursorPos_; // 0x40
	private int oldPageCnt_; // 0x44
	private string heroObjName; // 0x48
	private string partnerObjName; // 0x50
	private bool fiveLayout_; // 0x58
	private string[] changePokemonList; // 0x60
	private GameObject[] mainFaceWindows_; // 0x68
	private GameObject[] changeFaceWindows_; // 0x70
	private CallbackAction callbackFunc_; // 0x78
	private List<Page> pageList_; // 0x80
	private int pageCnt_; // 0x88
	private int cursorPos_; // 0x8C
	private const int vMax = 2; // Metadata: 0x00612608
	private GameObject[] cursors_; // 0x90
	private GameObject mainPage_; // 0x98
	private GameObject change_; // 0xA0
	private GameObject windowPage_; // 0xA8
	private UICampMenu campMenu_; // 0xB0
	private Anim<SpecialViewState>[] pageAnim; // 0xB8
	private Anim<DotViewState>[] dotAnim; // 0xC0
	private Index campIndex_; // 0xC8
	private bool showPokemon; // 0xCC
	private GameObject root_; // 0xD0
	private GameObject refineSortInfoText; // 0xD8
	private Index oldCampIndex_; // 0xE0
	private GameObject cursorObj_; // 0xE8
	private FilterStatus nowStatus_; // 0xF0
	private string[] actionNames; // 0xF8
	private int animCount_; // 0x100
	private List<DotCharacter> mainDotList_; // 0x108
	private List<DotCharacter> changeDotList_; // 0x110
	private bool showMainPage; // 0x118
	private PokemonSortData.PageState pageState_; // 0x11C
	private bool bKind_Menu; // 0x120
	private bool bKind_PokemonList; // 0x121
	private List<IPokemonWarehouseStatus>[] refinePartList_name; // 0x128
	private List<IPokemonWarehouseStatus>[] refinePartList_kind; // 0x130
	private PokemonSortData.BeingAllNameTypes nameType_; // 0x138
	private Const.pokemon.Type pokemonType_; // 0x13C
	private CommonSortRefineWindow.ListItem.Label sortLabel_; // 0x140
	private CommonSortRefineWindow.ListItem.Label oldLabel_; // 0x144
	private bool bEvoOkOnly_; // 0x148
	private List<IPokemonWarehouseStatus> nowList; // 0x150
	protected List<IPokemonWarehouseStatus> defaultList; // 0x158

	// Properties
	public int NowPagePokemonCount { get => default; } // 0x008C60F0-0x008C6160 
	public int PageCnt { get => default; } // 0x008C91C0-0x008C91D0 
	private int Max { get => default; } // 0x008C91D0-0x008C91F0 

	// Nested types
	public enum ActionType // TypeDefIndex: 6134
	{
		Decide = 0,
		Cancel = 1,
		Up = 2,
		Down = 3,
		Left = 4,
		Right = 5,
		YButton = 6
	}

	public delegate void CallbackAction(ActionType action); // TypeDefIndex: 6135; 0x008C6D80-0x008C7130

	private class Page // TypeDefIndex: 6136
	{
		// Fields
		public List<IPokemonWarehouseStatus> pokemonIndexList; // 0x10

		// Constructors
		public Page() {} // 0x008CB2F0-0x008CB360
	}

	private enum AnimPat // TypeDefIndex: 6137
	{
		Main = 0,
		Change = 1
	}

	private enum SpecialViewState // TypeDefIndex: 6138
	{
		NONE = 0,
		OUT_LEFT_MAIN = 1,
		OUT_RIGHT_MAIN = 2,
		IN_LEFT_MAIN = 3,
		IN_RIGHT_MAIN = 4,
		OUT_LEFT_CHANGE = 5,
		OUT_RIGHT_CHANGE = 6,
		IN_LEFT_CHANGE = 7,
		IN_RIGHT_CHANGE = 8,
		OPEN_MAIN = 9,
		OPEN_CHANGE = 10,
		CLOSE_MAIN = 11,
		CLOSE_CHANGE = 12
	}

	private enum DotViewState // TypeDefIndex: 6139
	{
		NONE = 0,
		END = 1
	}

	public enum FilterStatus // TypeDefIndex: 6140
	{
		None = 0,
		Refine = 1,
		Sort = 2
	}

	// Constructors
	public CampPokemonSelectWindow() {} // 0x008C5AE0-0x008C60D0

	// Methods
	public void Reset() {} // 0x008C60D0-0x008C60F0
	private void SetCursorAndPagePos() {} // 0x008C6160-0x008C62C0
	private int GetNowPokemonCount(bool pureCount) => default; // 0x008C62C0-0x008C63D0
	private int GetPokemonCount() => default; // 0x008C63D0-0x008C6460
	private string GetMainToken(int pokemonCount, bool init = false /* Metadata: 0x00612601 */) => default; // 0x008C6650-0x008C6730
	private string[] GetMainListToken(int pokemonCount) => default; // 0x008C6730-0x008C6960
	public void SetFaceVisible(bool visible) {} // 0x008C6960-0x008C6B80
	public void ResetActionListener() {} // 0x008C6B80-0x008C6B90
	public void RegisterActionListener(CallbackAction cb) {} // 0x008C6B90-0x008C6C80
	public void UnregisterActionListener(CallbackAction cb) {} // 0x008C6C80-0x008C6D70
	public void callAction(ActionType action) {} // 0x008C6D70-0x008C6D80
	private void sortRefineLabelClose() {} // 0x008C7130-0x008C71D0
	public void _cb(ActionType act) {} // 0x008C71D0-0x008C7520
	public void _cbNoPokemon(ActionType act) {} // 0x008C7590-0x008C7810
	private void PageOff() {} // 0x008C7820-0x008C78B0
	protected override void _doUpdate() {} // 0x008C78B0-0x008C7900
	private void _doInput() {} // 0x008C7900-0x008C7CC0
	private bool _doUp() => default; // 0x008C7FE0-0x008C8070
	private bool _doDown() => default; // 0x008C8070-0x008C8080
	private bool _doLeft() => default; // 0x008C8130-0x008C81B0
	private bool _doRight() => default; // 0x008C8080-0x008C8130
	private bool _doDecide() => default; // 0x008C81F0-0x008C82D0
	private bool _doCancel() => default; // 0x008C8300-0x008C8330
	private bool _doL() => default; // 0x008C81B0-0x008C81D0
	private bool _doR() => default; // 0x008C81D0-0x008C81F0
	private bool _doYButton() => default; // 0x008C82D0-0x008C8300
	public void CursorVisibleSet(bool visible) {} // 0x008C8FB0-0x008C9100
	private void MoveCursor(bool se, bool force = false /* Metadata: 0x00612602 */) {} // 0x008C7CC0-0x008C7FE0
	private bool FocusNextRow(bool up) => default; // 0x008C8330-0x008C84D0
	private bool IsLowerPart() => default; // 0x008C9120-0x008C91C0
	private bool FocusNext(bool right) => default; // 0x008C84D0-0x008C85C0
	private int GetGethMax() => default; // 0x008C9100-0x008C9120
	public IPokemonWarehouseStatus GetFocusPokemonStatus() => default; // 0x008C85C0-0x008C8660
	public void SetDefault(bool nowListUpdate = false /* Metadata: 0x00612603 */) {} // 0x008C91F0-0x008C9250
	public bool Init(GameObject root, Index campIndex, UICampMenu campMenu, bool bContinue, IPokemonStatus status = null) => default; // 0x008C9B90-0x008CB1B0
	public void CursorAdjust() {} // 0x008CCFD0-0x008CD080
	private void SetCursorPos(IPokemonStatus status) {} // 0x008CB360-0x008CB4D0
	public void SetRefineSortInfo(FilterStatus status, CommonSortRefineWindow.ListItem.Label label, Const.pokemon.Type type = Const.pokemon.Type.NONE /* Metadata: 0x00612604 */) {} // 0x008CC610-0x008CCFD0
	private void ListUpdate() {} // 0x008CD080-0x008CD0D0
	public void ChangeAlphaZero() {} // 0x008CD320-0x008CD330
	public void MainAlphaZero() {} // 0x008CD330-0x008CD340
	public void SetActiveWindowPage(bool active) {} // 0x008CD340-0x008CD3F0
	private void ChangePage(bool right) {} // 0x008C8660-0x008C8FB0
	private void ChangePage() {} // 0x008CB4D0-0x008CB640
	public void MainSetIcon() {} // 0x008CB640-0x008CBE90
	public void ChangeSetIcon() {} // 0x008CBE90-0x008CC610
	public void OpenMainOrChange(Action cb = null) {} // 0x008CD3F0-0x008CDCB0
	private void cbMainDotClear() {} // 0x008CDCC0-0x008CDD10
	private void cbChangeDotClear() {} // 0x008CDD10-0x008CDD60
	private void MainDotClear() {} // 0x008CD0D0-0x008CD200
	private void ChangeDotClear() {} // 0x008CD200-0x008CD320
	public void OpenMain() {} // 0x008CDD60-0x008CDE20
	public void OpenChange() {} // 0x008CDE20-0x008CDEF0
	public void CloseMain(Action cb = null) {} // 0x008CDEF0-0x008CE010
	public void CloseChange(Action cb = null) {} // 0x008CE020-0x008CE150
	// [IteratorStateMachine] // 0x00624710-0x00624780
	public IEnumerator _sortRefineSelect() => default; // 0x008C7520-0x008C7590
	private bool[] GetBeingType() => default; // 0x008CE190-0x008CE620
	private bool[] GetBeingNameInitial() => default; // 0x008C97B0-0x008C9B90
	private bool[] GetBeingKindInitial() => default; // 0x008C93C0-0x008C97B0
	private List<IPokemonWarehouseStatus>[] GetRefinePartList() => default; // 0x008CE620-0x008CE640
	public List<IPokemonWarehouseStatus> GetDefaultList() => default; // 0x008C9250-0x008C93C0
	public int CompareOrganizationId(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x008CE640-0x008CE7B0
	public int CompareBookId(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x008CE7B0-0x008CE8C0
	public int CompareIsFavorite(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x008CE8C0-0x008CE9F0
	public int CompareIsHeroAndPartner(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x008CE9F0-0x008CEB90
	public int CompareFriendSortId(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x008CEB90-0x008CECA0
	protected virtual int CompareOptionSort(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x008CECA0-0x008CEF00
	protected virtual int ComparePokemonWarehouseStatus(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x008CEF00-0x008CEF70
	public virtual List<IPokemonWarehouseStatus> GetNowList() => default; // 0x008CEF70-0x008CF260
	public void ResetFilter() {} // 0x008CB1B0-0x008CB1D0
	public void ResetRefineFilter() {} // 0x008CF260-0x008CF280
	public void ReList(PokemonSortData.BeingAllNameTypes type, bool kind) {} // 0x008CF280-0x008CF3A0
	public void ReList(bool bEvoOkOnly) {} // 0x008CF3A0-0x008CF430
	public void ReList(Const.pokemon.Type type) {} // 0x008CF430-0x008CF4B0
	public void ReList(CommonSortRefineWindow.ListItem.Label label) {} // 0x008CF4B0-0x008CF520
}

