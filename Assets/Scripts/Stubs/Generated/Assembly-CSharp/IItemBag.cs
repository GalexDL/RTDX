/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public interface IItemBag : IEnumerable<IItem>, IEnumerable // TypeDefIndex: 5070
{
	// Methods
	IItem GetItem(int id);
	int GetItemCount();
	int GetMax();
	int GetCapacity();
	bool IsFull();
	IDataList<IItem> GetItemList();
	bool AddItem(IItem item);
	bool DeleteItem(IItem item);
	void AllDeleteItem();
	void ReduceItem();
	void Sort();
	int GetMoney();
	void AddMoney(int add);
	int GetMaxMoney();
	void SetMoney(int money);
	IItem GetRegisterdItem();
}

