/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.item;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public interface IItem // TypeDefIndex: 5069
{
	// Methods
	uint GetUniqueId();
	Index GetIndex();
	Kind GetKind();
	bool IsArrowOrStone();
	int GetCount();
	void SetCount(int value);
	void SetShopGoods(bool bEnable);
	bool IsShopGoods();
	int GetPrice(PriceType type);
	int GetPurePrice(PriceType type);
	string GetName(bool bPlural);
	string GetNameNoCount(bool bPlural);
	void SetBuyFlag();
	void ClearBuyFlag();
	bool IsBuyFlag();
	void SetSellFlag();
	void ClearSellFlag();
	bool IsSellFlag();
	void SetSticky(bool set);
	bool IsSticky();
	bool IsGrouped();
	bool IsPlaced();
	bool IsEquipped();
	bool IsRegistered();
	int GetSortKey();
}

