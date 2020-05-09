/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIPokemonListMenu : UIManagerBase // TypeDefIndex: 6316
{
	// Fields
	protected static GameObject regidentObj_; // 0x00
	protected static GameObject regidentObjWaza_; // 0x08
	protected PokemonListWindowBase listWindow_; // 0x20
	protected PokemonStatusTabWindow statusWindow_; // 0x28
	private CommonBellyInfo bellyInfo_; // 0x30
	private bool bDungeonCameraFocus_; // 0x38
	protected CommonCloseType closeType; // 0x3C
	private List<IPokemonStatus> list_; // 0x40
	private bool bEnableCancel_; // 0x48
	private bool bEnableMultiSelect_; // 0x49
	private bool bVisibleBelly_; // 0x4A
	private List<IPokemonStatus> ignoreList_; // 0x50
	private List<IPokemonStatus> memberList_; // 0x58
	protected ActionType act_; // 0x60

	// Nested types
	public enum CommonCloseType // TypeDefIndex: 6317
	{
		NONE = 0,
		DECIDE_ALL = 1,
		DECIDE_FOOTER = 2,
		DECIDE_FOOTER_CANCEL_ALL = 3
	}

	public enum ActionType // TypeDefIndex: 6318
	{
		Cancel = -1,
		None = 0,
		Decide = 1
	}

	// Constructors
	public UIPokemonListMenu() {} // 0x00B461D0-0x00B461E0
	static UIPokemonListMenu() {} // 0x00B461E0-0x00B461F0

	// Methods
	public static GameObject CreateRegident() => default; // 0x00B443D0-0x00B44C60
	public static void DestroyRegident() {} // 0x00B44C60-0x00B44D70
	public GameObject GetWazaDetailWindow() => default; // 0x00B44D70-0x00B44E20
	public static UIPokemonListMenu Create() => default; // 0x00B44E20-0x00B45020
	public virtual void Construct() {} // 0x00B45020-0x00B45090
	public virtual void Destruct() {} // 0x00B45090-0x00B45130
	public void Init(List<IPokemonStatus> list, bool bEnableCancel, bool bEnableMultiSelect, bool bVisibleBelly, List<IPokemonStatus> ignoreList = null, List<IPokemonStatus> memberList = null) {} // 0x00B45130-0x00B454A0
	public void EnablePlusButtonCancel() {} // 0x00B454A0-0x00B454B0
	public void SetCaption(int capNo) {} // 0x00B454B0-0x00B45680
	public void SetEnable(IPokemonStatus status, bool bEnable) {} // 0x00B45680-0x00B45850
	public void SetDungeonCameraFocus(bool bFocus = true /* Metadata: 0x00612B96 */) {} // 0x00B45850-0x00B45870
	public void SetCloseCommonScreen(CommonCloseType type = CommonCloseType.DECIDE_ALL /* Metadata: 0x00612B97 */) {} // 0x00B45870-0x00B45880
	public void UpdateListFace() {} // 0x00B45880-0x00B458B0
	// [IteratorStateMachine] // 0x00625A30-0x00625AA0
	public virtual IEnumerator MainFlow(Action<ActionType> cb = null) => default; // 0x00B458B0-0x00B45930
	public virtual void Continue() {} // 0x00B45960-0x00B45970
	// [IteratorStateMachine] // 0x00625AA0-0x00625B10
	public IEnumerable<PokemonListWindow.UIPokemonSelectItem> GetItem() => default; // 0x00B45970-0x00B459F0
	public virtual List<IPokemonStatus> GetSelectList() => default; // 0x00B45A30-0x00B45C00
	public void SetCb() {} // 0x00B45C00-0x00B45CA0
	protected virtual void _cbFromListWindow(ListWindowBase.ActionType act) {} // 0x00B45CA0-0x00B45D70
	protected virtual void _cbFromStatusWindow(PokemonStatusTabWindow.ActionType act) {} // 0x00B45D70-0x00B45DA0
	protected virtual void _enableWindow() {} // 0x00B45DA0-0x00B45DE0
	public virtual void UpdateDetail(bool bForce = false /* Metadata: 0x00612B9B */) {} // 0x00B45DE0-0x00B45F80
	protected virtual void _switchFavor() {} // 0x00B45F80-0x00B46040
	protected virtual void _dungeonCameraFocus() {} // 0x00B46040-0x00B46170
	protected virtual void Start() {} // 0x00B46170-0x00B46180
	protected virtual void Update() {} // 0x00B46180-0x00B461D0
}

