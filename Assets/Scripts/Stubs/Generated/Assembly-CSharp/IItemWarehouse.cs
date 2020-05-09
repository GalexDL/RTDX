/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.item;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public interface IItemWarehouse // TypeDefIndex: 5072
{
	// Methods
	int GetMax();
	int GetItemMax(Index itemIndex);
	int GetItemCount(Index itemIndex);
	IDataList<IItem> GetItemList();
	bool DepositItem(IItem item);
	IDataList<IItem> DrawOutItem(Index itemIndex, int count);
}

