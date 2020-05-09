/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public interface IShopMerchantList : IItemList, IDataList<IItem>, IEnumerable<IItem>, IEnumerable // TypeDefIndex: 5082
{
	// Methods
	List<IItem> GetBuyItems();
	int GetAllBuyItemsMoney();
	List<IItem> AllRemoveBuyItems();
	bool RemoveItem(IItem item, bool bListRemove);
}

