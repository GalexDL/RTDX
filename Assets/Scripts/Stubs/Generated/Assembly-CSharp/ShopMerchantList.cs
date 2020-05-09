/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ShopMerchantList : DataList<IItem>, IShopMerchantList, IItemList, IDataList<IItem>, IEnumerable<IItem>, IEnumerable // TypeDefIndex: 5243
{
	// Fields
	private int m_shopListId; // 0x1C

	// Constructors
	public ShopMerchantList() {} // Dummy constructor
	public ShopMerchantList(int shopListId, int max) {} // 0x009DBBA0-0x009DBC20

	// Methods
	public static ShopMerchantList Create(byte[] buffer) => default; // 0x009DB810-0x009DBBA0
	public List<IItem> GetBuyItems() => default; // 0x009DBC20-0x009DBDB0
	public int GetAllBuyItemsMoney() => default; // 0x009DBDB0-0x009DBF20
	public List<IItem> AllRemoveBuyItems() => default; // 0x009DBF20-0x009DC270
	public bool RemoveItem(IItem item, bool bListRemove) => default; // 0x009DC270-0x009DC340
}

