/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const;
using Const.item;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class ItemBag : IItemBag, IEnumerable<IItem>, IEnumerable // TypeDefIndex: 5091
{
	// Fields
	private const int MAX_MONEY = 99999; // Metadata: 0x00610EEB
	private static Dictionary<ItemBagType, ItemBag> s_dicItemBag; // 0x00
	private ItemBagType m_type; // 0x10

	// Constructors
	public ItemBag() {} // Dummy constructor
	public ItemBag(ItemBagType type) {} // 0x008F7650-0x008F7680
	static ItemBag() {} // 0x008F8740-0x008F87C0

	// Methods
	public static void Startup() {} // 0x008F7680-0x008F7760
	public static ItemBag GetCurrentBag() => default; // 0x008F7760-0x008F7810
	public IItem GetItem(int id) => default; // 0x008F7810-0x008F78C0
	public int GetItemCount(Index itemIndex) => default; // 0x008F78C0-0x008F7940
	public int GetItemCount() => default; // 0x008F7940-0x008F79B0
	public int GetMax() => default; // 0x008F79B0-0x008F7A20
	public int GetCapacity() => default; // 0x008F7A20-0x008F7A90
	public bool IsFull() => default; // 0x008F7A90-0x008F7B60
	public IDataList<IItem> GetItemList() => default; // 0x008F7B60-0x008F7C20
	public bool AddItem(IItem item) => default; // 0x008F7EC0-0x008F7F60
	public bool DeleteItem(IItem item) => default; // 0x008F7F60-0x008F8000
	public void AllDeleteItem() {} // 0x008F8000-0x008F8220
	public void ReduceItem() {} // 0x008F8220-0x008F8290
	public void Sort() {} // 0x008F8290-0x008F8300
	public int GetMoney() => default; // 0x008F8300-0x008F8370
	public void AddMoney(int add) {} // 0x008F8370-0x008F83E0
	public void SetMoney(int money) {} // 0x008F83E0-0x008F8450
	public int GetMaxMoney() => default; // 0x008F8450-0x008F8460
	public IItem GetRegisterdItem() => default; // 0x008F8460-0x008F8520
	IEnumerator IEnumerable.GetEnumerator() => default; // 0x008F8520-0x008F8590
	// [IteratorStateMachine] // 0x0061CF90-0x0061D000
	public IEnumerator<IItem> GetEnumerator() => default; // 0x008F8590-0x008F8600
	public void AddItem(Index index, int count = 0 /* Metadata: 0x00610EE7 */) {} // 0x008F8630-0x008F8740
}

