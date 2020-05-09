/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.item;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ItemWarehouse : Singleton<ItemWarehouse>, IItemWarehouse // TypeDefIndex: 5097
{
	// Constructors
	public ItemWarehouse() {} // 0x00901020-0x00901090

	// Methods
	public int GetMax() => default; // 0x00900AD0-0x00900B40
	public int GetItemMax(Index itemIndex) => default; // 0x00900B40-0x00900BB0
	public int GetItemCount(Index itemIndex) => default; // 0x00900BB0-0x00900C20
	public void AllClear() {} // 0x00900C20-0x00900C90
	public IDataList<IItem> GetItemList() => default; // 0x00900C90-0x00900D40
	public bool DepositItem(IItem item) => default; // 0x00900D40-0x00900DD0
	public IDataList<IItem> DrawOutItem(Index itemIndex, int count) => default; // 0x00900DD0-0x00900EA0
	public void AllDraw() {} // 0x00900EA0-0x00901020
}

