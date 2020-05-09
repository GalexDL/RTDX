/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.item;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class UICommonItemSelectItem : UISelectItem // TypeDefIndex: 6238
{
	// Fields
	private IItem item_; // 0x18
	private bool bShowPrice_; // 0x20
	private int price_; // 0x24
	private bool bDiscount_; // 0x28
	private int discountPrice_; // 0x2C
	private Firsttime discountFirst_; // 0x30
	private bool bEquipped_; // 0x38
	private int equipNumber_; // 0x3C
	private List<IPokemonStatus> aWazaLearnPokemonList_; // 0x40
	private List<IPokemonStatus> aWazaLearnPokemonIgnoreList_; // 0x48

	// Properties
	public IItem Item { get => default; set {} } // 0x00976120-0x00976130 0x00976110-0x00976120
	public bool IsPrice { get => default; } // 0x00976130-0x00976140 
	public int Price { get => default; } // 0x00976140-0x00976150 
	public int DiscountPrice { get => default; } // 0x00976150-0x00976160 
	public bool IsDiscount { get => default; } // 0x00976160-0x00976170 
	public bool IsDiscountFirst { get => default; } // 0x00976170-0x00976190 
	public bool IsDiscountAnimeSkip { get => default; } // 0x00976190-0x009761B0 
	public bool IsEquipped { get => default; } // 0x009762B0-0x009762C0 
	public int EquipNumber { get => default; } // 0x009762C0-0x009762D0 

	// Nested types
	public class Firsttime // TypeDefIndex: 6239
	{
		// Fields
		public bool bFirst; // 0x10
		public bool bSkip; // 0x11

		// Constructors
		public Firsttime() {} // 0x00976420-0x00976430
	}

	// Constructors
	public UICommonItemSelectItem() {} // 0x00976410-0x00976420

	// Methods
	public void SetDiscountFirst(bool bFirst) {} // 0x009761B0-0x009761D0
	public void ShowPrice(PriceType priceType, bool bDiscount = false /* Metadata: 0x00612AF5 */, Firsttime discountFirst = null) {} // 0x009761D0-0x00976280
	public void ShowPrice(int price) {} // 0x00976280-0x009762A0
	public void HidePrice() {} // 0x009762A0-0x009762B0
	public void SetEquipped(bool bEnable, int number = 0 /* Metadata: 0x00612AF6 */) {} // 0x009762D0-0x009762E0
	public void SetWazaLearnPokemonList(List<IPokemonStatus> learnList, List<IPokemonStatus> ignoreList) {} // 0x009762E0-0x009762F0
	public List<IPokemonStatus> GetWazaLearnPokemonList() => default; // 0x009762F0-0x00976300
	public List<IPokemonStatus> GetWazaLearnPokemonIgnoreList() => default; // 0x00976300-0x00976310
	public bool IsWazaLearnPokemonList() => default; // 0x00976310-0x00976370
	public override int GetSortKey(int mode) => default; // 0x00976370-0x00976410
}

