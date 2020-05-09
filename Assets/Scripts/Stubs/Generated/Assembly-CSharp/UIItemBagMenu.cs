/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.item;
using Const.waza;
using dungeon;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIItemBagMenu : UIBasicItemBagMenu // TypeDefIndex: 7010
{
	// Fields
	protected UIAskMenu actionMenu_; // 0x60
	protected Mode mode_; // 0x68
	protected bool bCommandRegist_; // 0x6C
	private bool bNowFootPage_; // 0x6D

	// Nested types
	public enum Mode // TypeDefIndex: 7011
	{
		Ground = 0,
		Dungeon = 1
	}

	// Constructors
	public UIItemBagMenu() {} // 0x00A79080-0x00A79090

	// Methods
	private new void Start() {} // 0x00A8B430-0x00A8B440
	public static UIItemBagMenu Create() => default; // 0x00A82F50-0x00A830B0
	public override void Construct() {} // 0x00A8B440-0x00A8B4C0
	public override void Destruct() {} // 0x00A8B4C0-0x00A8B550
	protected override void _cbFromListWindow(ListWindowBase.ActionType act) {} // 0x00A8B550-0x00A8B770
	public void Init(Mode mode = Mode.Ground /* Metadata: 0x0061325A */, bool singleCall = false /* Metadata: 0x0061325E */) {} // 0x00A830B0-0x00A83330
	// [IteratorStateMachine] // 0x006297F0-0x00629860
	public override IEnumerator MainFlow(Action<Result> cb = null) => default; // 0x00A8B7F0-0x00A8B870
	// [IteratorStateMachine] // 0x00629860-0x006298D0
	private IEnumerator _tutorialBagOpenMsg(string sMsg, Action cb) => default; // 0x00A8B8A0-0x00A8B920
	private void _updateCaption(bool bForce) {} // 0x00A8B770-0x00A8B7F0
	protected virtual void _endAction(int commandResult) {} // 0x00A8B920-0x00A8BB50
	// [IteratorStateMachine] // 0x006298D0-0x00629940
	protected IEnumerator _processActionMenu(IItem Item, Action<int> cb) => default; // 0x00A796D0-0x00A79750
	protected virtual int ResetCommandResult() => default; // 0x00A8BB80-0x00A8BB90
	private PokemonStatus _getEquippedItemPokemonStatus(IItem Item) => default; // 0x00A8BB90-0x00A8BDE0
	// [IteratorStateMachine] // 0x00629940-0x006299B0
	private IEnumerator _processCommandItemPut(Action<int> resultCb) => default; // 0x00A8BDE0-0x00A8BE60
	// [IteratorStateMachine] // 0x006299B0-0x00629A20
	private IEnumerator _processCommandLearnWaza(List<IPokemonStatus> statusList, List<IPokemonStatus> ignoreStatusList, IItem item, Action<int, PokemonStatus> resultCb) => default; // 0x00A8BE60-0x00A8BEF0
	// [IteratorStateMachine] // 0x00629A20-0x00629A90
	public static IEnumerator ProcessForgetWazaSelect(PokemonStatus status, Const.waza.Index wazaIndex, bool bCancelConfirm, Action<int> cb = null) => default; // 0x00A8BEF0-0x00A8BF90
	// [IteratorStateMachine] // 0x00629A90-0x00629B00
	private IEnumerator _processCommandBoxRenketsu(PokemonStatus status, Action<int> resultCb) => default; // 0x00A8BFC0-0x00A8C040
	// [IteratorStateMachine] // 0x00629B00-0x00629B70
	private IEnumerator _prodessSelectWazaSlot(PokemonStatus status, Const.item.Index itemIndex, Action<int> resultCb) => default; // 0x00A8C040-0x00A8C0D0
	private TextIDHash GetItemUseButtonGuide() => default; // 0x00A8C0D0-0x00A8C100
}

