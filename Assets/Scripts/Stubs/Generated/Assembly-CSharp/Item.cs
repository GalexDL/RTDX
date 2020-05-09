/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.item;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class Item : IItem // TypeDefIndex: 5088
{
	// Fields
	protected uint m_uniqueId; // 0x10
	private Flag m_flag; // 0x14

	// Nested types
	[Flags] // 0x0060EA40-0x0060EA50
	public enum Flag // TypeDefIndex: 5089
	{
		BUY = 1,
		SELL = 2
	}

	// Constructors
	public Item() {} // Dummy constructor
	public Item(uint uniqueId) {} // 0x008F6890-0x008F68C0

	// Methods
	public static Item CreateForManaged(Index index, int count) => default; // 0x008F67E0-0x008F6890
	public static void Destroy(Item item) {} // 0x008F68C0-0x008F6940
	public static void DestroyImmidiate(Item item) {} // 0x008F6960-0x008F69E0
	public void ResetParameter() {} // 0x008F6950-0x008F6960
	public uint GetUniqueId() => default; // 0x008F6940-0x008F6950
	public Index GetIndex() => default; // 0x008F69E0-0x008F6A50
	public Kind GetKind() => default; // 0x008F6A50-0x008F6AC0
	public bool IsArrowOrStone() => default; // 0x008F6AC0-0x008F6B40
	public int GetCount() => default; // 0x008F6B40-0x008F6BB0
	public void SetCount(int value) {} // 0x008F6BB0-0x008F6C30
	public void SetShopGoods(bool bEnable) {} // 0x008F6C30-0x008F6CB0
	public bool IsShopGoods() => default; // 0x008F6CB0-0x008F6D20
	public int GetPrice(PriceType type) => default; // 0x008F6D20-0x008F6DA0
	public int GetPurePrice(PriceType type) => default; // 0x008F6DA0-0x008F6E20
	public string GetName(bool bPlural) => default; // 0x008F6E20-0x008F6F40
	public string GetNameNoCount(bool bPlural) => default; // 0x008F6F40-0x008F7060
	public void SetBuyFlag() {} // 0x008F7060-0x008F7070
	public void ClearBuyFlag() {} // 0x008F7070-0x008F7080
	public bool IsBuyFlag() => default; // 0x008F7080-0x008F7090
	public void SetSellFlag() {} // 0x008F7090-0x008F70A0
	public void ClearSellFlag() {} // 0x008F70A0-0x008F70B0
	public bool IsSellFlag() => default; // 0x008F70B0-0x008F70C0
	public void SetSticky(bool set) {} // 0x008F70C0-0x008F7140
	public bool IsSticky() => default; // 0x008F7140-0x008F71B0
	public bool IsGrouped() => default; // 0x008F71B0-0x008F7220
	public bool IsPlaced() => default; // 0x008F7220-0x008F7290
	public bool IsEquipped() => default; // 0x008F7290-0x008F7300
	public bool IsRegistered() => default; // 0x008F7300-0x008F7370
	public bool Fall(ICreature creature, DungeonCoord coord, bool curve, bool flat) => default; // 0x008F7370-0x008F7430
	public void SetHidden(bool set) {} // 0x008F7430-0x008F74B0
	public bool IsHidden() => default; // 0x008F74B0-0x008F7520
	public int GetSortKey() => default; // 0x008F7520-0x008F75E0
}

