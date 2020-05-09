/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIBasicItemBagMenu : UIManagerBase // TypeDefIndex: 7001
{
	// Fields
	protected ItemBagListWindow listWindow_; // 0x20
	protected ItemDetailWindow detailWindow_; // 0x28
	protected CommonItemBagInfo bagWindow_; // 0x30
	private CommonSimpleInfoWindow infoMoneyWindow_; // 0x38
	protected CommonScreen commonScreen_; // 0x40
	protected TextIDHash baseButtonGuide_; // 0x48
	protected bool bSingleCall; // 0x4C
	protected List<IEnumerator> actList; // 0x50
	protected Result result_; // 0x58
	protected bool bNoticeEmpty_; // 0x5C

	// Nested types
	public enum Result // TypeDefIndex: 7002
	{
		ReSelect = -2,
		Cancel = -1,
		None = 0,
		Decide = 1
	}

	// Constructors
	public UIBasicItemBagMenu() {} // 0x007E9010-0x007E9020

	// Methods
	private void Start() {} // 0x007E5F90-0x007E5FA0
	private void Update() {} // 0x007E5FA0-0x007E5FF0
	public static UIBasicItemBagMenu Create() => default; // 0x007E5FF0-0x007E6160
	public virtual void Construct() {} // 0x007E6160-0x007E6270
	public virtual void Destruct() {} // 0x007E6270-0x007E62F0
	private static int favorCompare(IPokemonStatus a, IPokemonStatus b) => default; // 0x007E62F0-0x007E63F0
	public static List<IPokemonStatus> GetPokemonListFromWarehouse() => default; // 0x007E63F0-0x007E68D0
	public static List<IPokemonStatus> GetPokemonListFromParty(out List<IPokemonStatus> ignoreStatusList) {
		ignoreStatusList = default;
		return default;
	} // 0x007E68D0-0x007E6C80
	public static List<IPokemonStatus> GetWazaLearnPokemonList(IItem item, out List<IPokemonStatus> ignoreList) {
		ignoreList = default;
		return default;
	} // 0x007E6C80-0x007E7340
	public static List<IPokemonStatus> GetWazaLearnPokemonList1(out List<IPokemonStatus> ignoreList) {
		ignoreList = default;
		return default;
	} // 0x007E7340-0x007E7400
	public static List<IPokemonStatus> GetWazaLearnPokemonList2(IItem item, List<IPokemonStatus> statusList, List<IPokemonStatus> ignoreList, out List<IPokemonStatus> ignoreListOut) {
		ignoreListOut = default;
		return default;
	} // 0x007E7400-0x007E7830
	public static bool IsBeingLearnPokemon(IItem item) => default; // 0x007E7830-0x007E7A10
	// [IteratorStateMachine] // 0x006294E0-0x00629550
	public IEnumerator ShowPokemonList(List<IPokemonStatus> statusList, List<IPokemonStatus> ignoreList) => default; // 0x007E7A10-0x007E7A90
	protected virtual void _cbFromListWindow(ListWindowBase.ActionType act) {} // 0x007E7AC0-0x007E8260
	public void Init(bool bMulti = false /* Metadata: 0x00613249 */, List<IItem> ignoreItems = null) {} // 0x007E84E0-0x007E8740
	// [IteratorStateMachine] // 0x00629550-0x006295C0
	public virtual IEnumerator MainFlow(Action<Result> cb = null) => default; // 0x007E8740-0x007E87C0
	public virtual List<IItem> GetSelectList() => default; // 0x007E87F0-0x007E8B10
	protected void _updateDetail() {} // 0x007E8320-0x007E84E0
	protected virtual void _updateButtonGuide(IItem item) {} // 0x007E8B10-0x007E8BD0
	protected UICommonItemSelectItem _getFocusItem() => default; // 0x007E8280-0x007E8320
	public void UpdateBagWindow(int modify) {} // 0x007E8260-0x007E8280
	// [IteratorStateMachine] // 0x006295C0-0x00629630
	public override IEnumerator OpenWindow(Action cb) => default; // 0x007E8BD0-0x007E8C50
	// [IteratorStateMachine] // 0x00629630-0x006296A0
	public override IEnumerator CloseWindow(Action cb) => default; // 0x007E8C80-0x007E8D00
	// [IteratorStateMachine] // 0x006296A0-0x00629710
	protected virtual IEnumerator _noItem(Action cb) => default; // 0x007E8D30-0x007E8DA0
	// [IteratorStateMachine] // 0x00629710-0x00629780
	public static IEnumerator NoticeEmptyItem(Action cb) => default; // 0x007E8DD0-0x007E8E40
	protected virtual void _selectStart() {} // 0x007E8E70-0x007E8F40
	protected virtual void _selectEnd() {} // 0x007E8F40-0x007E9010
}

