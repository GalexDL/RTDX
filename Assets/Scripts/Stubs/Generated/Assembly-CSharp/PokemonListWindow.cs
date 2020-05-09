/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.pokemon;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PokemonListWindow : PokemonListWindowBase // TypeDefIndex: 6303
{
	// Fields
	private bool refineSortEnable_; // 0x99
	private List<IPokemonStatus> memberList_; // 0xA0
	private GameObject objRoot_; // 0xA8
	private UIPokemonListMenu manager_; // 0xB0
	private PokemonSortData.PageState pageState_; // 0xB8
	protected bool bookId; // 0xBC
	protected List<IPokemonStatus> nowList_; // 0xC0
	protected List<IPokemonStatus> defaultList_; // 0xC8
	protected List<IPokemonStatus>[] refinePartList_; // 0xD0
	protected PokemonSortData.BeingAllNameTypes nameType_; // 0xD8
	protected Const.pokemon.Type pokemonType_; // 0xDC
	protected CommonSortRefineWindow.ListItem.Label sortLabel_; // 0xE0
	protected bool bEvoOkOnly_; // 0xE4

	// Nested types
	public class UIPokemonSelectItem : PokemonListWindowBase.UIPokemonSelectItemBase // TypeDefIndex: 6304
	{
		// Fields
		private IPokemonStatus pokemonStatus_; // 0x28
		private int organizationNo_; // 0x30
		private Index pokemonAppearanceIndex; // 0x34

		// Properties
		public override IPokemonStatus PokemonStatus { get => default; set {} } // 0x00C47010-0x00C47020 0x00C46EF0-0x00C46F00
		public int OrganizationNo { get => default; set {} } // 0x00C47020-0x00C47030 0x00C45D80-0x00C45D90

		// Constructors
		public UIPokemonSelectItem() {} // 0x00C45B30-0x00C45B40

		// Methods
		public override int GetOrganizationNo() => default; // 0x00C47030-0x00C47040
		private void SetAppearanceIndex() {} // 0x00C46F00-0x00C47010
		public override Index GetFormChangeIndex() => default; // 0x00C47040-0x00C47050
	}

	// Constructors
	public PokemonListWindow() {} // 0x00C453C0-0x00C45440

	// Methods
	public void SetDefaultList(List<IPokemonStatus> list) {} // 0x00C42B20-0x00C42C10
	public virtual void Init(GameObject objRoot, UIPokemonListMenu manager, List<IPokemonStatus> ignoreList = null, List<IPokemonStatus> memberList = null, bool refineSortEnable = true /* Metadata: 0x00612B86 */) {} // 0x00C42C10-0x00C42E60
	// [IteratorStateMachine] // 0x00625950-0x006259C0
	public IEnumerator _sortRefineSelect(bool evolutionOk = false /* Metadata: 0x00612B87 */) => default; // 0x00C42E70-0x00C42EF0
	protected virtual void ListUpdate() {} // 0x00C42F20-0x00C42F90
	public void ResetFilter() {} // 0x00C42F90-0x00C42FC0
	public void ResetRefineFilter() {} // 0x00C42FC0-0x00C42FE0
	public void ReList(PokemonSortData.BeingAllNameTypes type, bool kind) {} // 0x00C42FE0-0x00C431D0
	public void ReList(bool bEvoOkOnly) {} // 0x00C433F0-0x00C43460
	public void ReList(Const.pokemon.Type type) {} // 0x00C43460-0x00C434D0
	public void ReList(CommonSortRefineWindow.ListItem.Label label) {} // 0x00C434D0-0x00C43530
	protected bool[] GetBeingType() => default; // 0x00C43530-0x00C439A0
	protected bool[] GetBeingNameInitial() => default; // 0x00C439A0-0x00C43F70
	protected bool[] GetBeingKindInitial() => default; // 0x00C440B0-0x00C44540
	public int CompareOrganizationId(IPokemonStatus a, IPokemonStatus b) => default; // 0x00C445D0-0x00C44820
	public int CompareBookId(IPokemonStatus a, IPokemonStatus b) => default; // 0x00C44820-0x00C448F0
	public int CompareIsFavorite(IPokemonStatus a, IPokemonStatus b) => default; // 0x00C448F0-0x00C449F0
	public int CompareIsHeroAndPartner(IPokemonStatus a, IPokemonStatus b) => default; // 0x00C449F0-0x00C44B40
	public int CompareFriendSortId(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x00C44B40-0x00C44C50
	public virtual List<IPokemonStatus> UniqueFilter(List<IPokemonStatus> defaultList) => default; // 0x00C44C50-0x00C44C60
	public virtual List<IPokemonStatus> GetNowList(int presetIndex = -1 /* Metadata: 0x00612B88 */) => default; // 0x00C44C60-0x00C44F40
	protected virtual int CompareOptionSort(IPokemonStatus a, IPokemonStatus b) => default; // 0x00C44F40-0x00C450F0
	protected virtual int ComparePokemonWarehouseStatus(IPokemonStatus a, IPokemonStatus b) => default; // 0x00C450F0-0x00C452C0
	protected override bool _onYButton() => default; // 0x00C452C0-0x00C453C0
}

