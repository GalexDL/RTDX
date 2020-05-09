/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.camp;
using Const.creature;
using Const.dungeon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UIRescueSociety : UIManagerBase // TypeDefIndex: 7478
{
	// Fields
	private static UICampListMenuRescueSociety campMenu; // 0x00
	private static UIPokemonListMenuRescueSociety pokemonMenu; // 0x08
	private static UIPurchaseConfirmRescueSociety confirmCaution; // 0x10
	private static UIModalScreenRescueSociety modalBG; // 0x18
	private ActionType campAction; // 0x1C
	private ActionType pokemonAction; // 0x20
	private List<CampInfo> campBaseList; // 0x28
	private List<PokemonInfo> pokemonBaseList; // 0x30
	private List<CampInfo> campDeriveList; // 0x38
	private List<PokemonInfo> pokemonDeriveList; // 0x40
	private int resultIndexCamp; // 0x48
	private int resultIndexPokemon; // 0x4C
	private bool discountFlag; // 0x50
	private int poke; // 0x54
	private bool bFromPokemonList; // 0x58

	// Properties
	public int Poke { get => default; set {} } // 0x00B501D0-0x00B501E0 0x00B501E0-0x00B501F0
	public bool FromPokemonList { get => default; set {} } // 0x00B501F0-0x00B50200 0x00B50200-0x00B50210

	// Nested types
	public enum ActionType // TypeDefIndex: 7479
	{
		Init = 0,
		None = 1,
		Cancel = 2,
		Decide = 3,
		Continue = 4
	}

	public class CampInfo // TypeDefIndex: 7480
	{
		// Fields
		public Const.camp.Index campIndex; // 0x10
		public int campSortNum; // 0x14
		public int campPrice; // 0x18
		public bool bConstructed; // 0x1C
		public bool bSale; // 0x1D
		public bool bFound; // 0x1E
		public int defaultPrice; // 0x20
		public Const.creature.Index[] inhabitants; // 0x28
		public bool[] inhabitantsFound; // 0x30
		public bool[] inhabitantsExistWarehouse; // 0x38
		public bool bDiscountFlag; // 0x40

		// Constructors
		public CampInfo(CampInfo camp) {} // 0x00B51910-0x00B51990
		public CampInfo() {} // 0x00B517B0-0x00B517C0
	}

	public class AreaData // TypeDefIndex: 7481
	{
		// Fields
		public Const.dungeon.Index dungeonIndex; // 0x10
		public int sortNum; // 0x14

		// Constructors
		public AreaData() {} // 0x00B4A0D0-0x00B4A0E0
	}

	public class PokemonInfo // TypeDefIndex: 7482
	{
		// Fields
		public Const.creature.Index pokemonIndex; // 0x10
		public int pokemonBookNum; // 0x14
		public int pokemonSortNum; // 0x18
		public bool bFound; // 0x1C
		public CampInfo campData; // 0x20
		public List<AreaData> distributionList; // 0x28
		public bool joinStatus; // 0x30
		public bool? bStatueLock; // 0x31
		public bool? bToppatsuAppear; // 0x33
		public bool? bInvitionAppear; // 0x35

		// Constructors
		public PokemonInfo() {} // 0x00B51FA0-0x00B51FB0
	}

	// Constructors
	public UIRescueSociety() {} // 0x00B524C0-0x00B524D0

	// Methods
	public static UIRescueSociety Create() => default; // 0x00B50210-0x00B503D0
	private void Construct() {} // 0x00B503D0-0x00B50450
	public void Init(float DiscountRate = 1f /* Metadata: 0x00613746 */) {} // 0x00B50450-0x00B504F0
	public void ListReset() {} // 0x00B50ED0-0x00B50F60
	// [IteratorStateMachine] // 0x0062C5C0-0x0062C630
	public IEnumerator MainFlowCamp(Action<ActionType> cb = null) => default; // 0x00B511F0-0x00B51270
	// [IteratorStateMachine] // 0x0062C630-0x0062C6A0
	public IEnumerator MainFlowPokemon(Action<ActionType> cb = null) => default; // 0x00B512A0-0x00B51320
	// [IteratorStateMachine] // 0x0062C6A0-0x0062C710
	public IEnumerator CloseList() => default; // 0x00B51350-0x00B513C0
	public int PurchaseCamp() => default; // 0x00B513F0-0x00B514A0
	// [IteratorStateMachine] // 0x0062C710-0x0062C780
	private IEnumerator OpenCaution() => default; // 0x00B515D0-0x00B51640
	// [IteratorStateMachine] // 0x0062C780-0x0062C7F0
	public IEnumerator CloseCaution() => default; // 0x00B51670-0x00B516D0
	public void CloseCampList() {} // 0x00B51700-0x00B517B0
	public List<CampInfo> GetCampList(float discount) => default; // 0x00B504F0-0x00B50ED0
	public void UpdateBaseCamp() {} // 0x00B514A0-0x00B515D0
	public CampInfo GetCamp(Const.camp.Index index) => default; // 0x00B517C0-0x00B51910
	public void GetDeriveCamp() {} // 0x00B50F60-0x00B511F0
	public List<PokemonInfo> GetPokemonList() => default; // 0x00B51990-0x00B51FA0
	public Const.camp.Index GetSelectCampIndex() => default; // 0x00B51FB0-0x00B52010
	public int GetSelectCampPrise() => default; // 0x00B52010-0x00B52070
	public Const.dungeon.Index GetSelectCampDungeonIndex() => default; // 0x00B52070-0x00B520D0
	public bool CheckNewCamp() => default; // 0x00B520D0-0x00B520E0
	public bool CheckUnpublishedCamp() => default; // 0x00B520E0-0x00B52220
	public bool CheckConstructibleCamp() => default; // 0x00B52220-0x00B52360
	public bool CheckDungeonUnlockCamp() => default; // 0x00B52360-0x00B524C0
}

