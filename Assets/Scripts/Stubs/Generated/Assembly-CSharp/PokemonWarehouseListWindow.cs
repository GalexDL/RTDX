/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.pokemon;
using UnityEngine;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PokemonWarehouseListWindow : PokemonListWindowBase // TypeDefIndex: 6310
{
	// Fields
	protected bool bookId; // 0x99
	private PokemonSortData.PageState pageState_; // 0x9C
	private List<IPokemonWarehouseStatus> nowList_; // 0xA0
	protected List<IPokemonWarehouseStatus> defaultList_; // 0xA8
	private List<IPokemonWarehouseStatus>[] refinePartList_; // 0xB0
	private PokemonSortData.BeingAllNameTypes nameType_; // 0xB8
	private Const.pokemon.Type pokemonType_; // 0xBC
	private CommonSortRefineWindow.ListItem.Label sortLabel_; // 0xC0
	private bool bEvoOkOnly_; // 0xC4

	// Nested types
	public class UIPokemonWarehouseSelectItem : PokemonListWindowBase.UIPokemonSelectItemBase // TypeDefIndex: 6311
	{
		// Fields
		private IPokemonWarehouseStatus pokemonWarehouseStatus_; // 0x28

		// Properties
		public IPokemonWarehouseStatus PokemonWarehouseStatus { get => default; set {} } // 0x009EC0F0-0x009EC100 0x009EB180-0x009EB190
		public override IPokemonStatus PokemonStatus { get => default; set {} } // 0x009EC110-0x009EC170 0x009EC100-0x009EC110

		// Constructors
		public UIPokemonWarehouseSelectItem() {} // 0x009EB170-0x009EB180

		// Methods
		public override bool IsFavor() => default; // 0x009EC170-0x009EC1D0
		public override void SetFavor(bool bSet) {} // 0x009EC1D0-0x009EC240
	}

	// Constructors
	public PokemonWarehouseListWindow() {} // 0x009E8FD0-0x009E9020

	// Methods
	public override void Init(GameObject objRoot) {} // 0x009E9020-0x009E91D0
	// [IteratorStateMachine] // 0x006259C0-0x00625A30
	public IEnumerator _sortRefineSelect(bool evolutionOk = false /* Metadata: 0x00612B8D */) => default; // 0x009E91E0-0x009E9260
	protected override bool _doCancel() => default; // 0x009E9290-0x009E92E0
	protected virtual void ListUpdate() {} // 0x009E9310-0x009E9320
	public void ResetFilter() {} // 0x009E92E0-0x009E9310
	public void ResetRefineFilter() {} // 0x009E9320-0x009E9340
	public void ReList(PokemonSortData.BeingAllNameTypes type, bool kind) {} // 0x009E9340-0x009E9470
	public void ReList(bool bEvoOkOnly) {} // 0x009E9470-0x009E94E0
	public void ReList(Const.pokemon.Type type) {} // 0x009E94E0-0x009E9550
	public void ReList(CommonSortRefineWindow.ListItem.Label label) {} // 0x009E9550-0x009E95B0
	private bool[] GetBeingType() => default; // 0x009E95B0-0x009E9A40
	private bool[] GetBeingNameInitial() => default; // 0x009E9A40-0x009E9E20
	private bool[] GetBeingKindInitial() => default; // 0x009E9E20-0x009EA210
	public int CompareOrganizationId(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x009EA210-0x009EA380
	public int CompareBookId(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x009EA380-0x009EA490
	public int CompareIsFavorite(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x009EA490-0x009EA5B0
	public int CompareIsHeroAndPartner(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x009EA5B0-0x009EA730
	public int CompareFriendSortId(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x009EA730-0x009EA840
	public virtual List<IPokemonWarehouseStatus> SetDefaultList(int presetIndex = -1 /* Metadata: 0x00612B8E */) => default; // 0x009EA840-0x009EA920
	public virtual List<IPokemonWarehouseStatus> UniqueFilter(List<IPokemonWarehouseStatus> defaultList) => default; // 0x009EA920-0x009EA930
	public virtual List<IPokemonWarehouseStatus> GetNowList(int presetIndex = -1 /* Metadata: 0x00612B92 */) => default; // 0x009EA930-0x009EAC00
	private IPokemonStatus GetNowStatus(IPokemonWarehouseStatus pokemonWarehouseStatus) => default; // 0x009EAC00-0x009EACF0
	protected virtual int CompareOptionSort(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x009EACF0-0x009EAF50
	protected virtual int ComparePokemonWarehouseStatus(IPokemonWarehouseStatus a, IPokemonWarehouseStatus b) => default; // 0x009EAF50-0x009EAFC0
}

