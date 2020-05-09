/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.pokemon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PokemonWarehouseStatus : IPokemonWarehouseStatus // TypeDefIndex: 5203
{
	// Fields
	private const int DUMMY_VALUE = 999; // Metadata: 0x006110C5
	private PokemonWarehouseId m_warehouseId; // 0x10
	private PokemonStatus m_status; // 0x18
	private bool m_bfavorite; // 0x20

	// Properties
	public bool Favorite { get => default; set {} } // 0x009EC710-0x009EC790 0x009EC790-0x009EC820

	// Constructors
	public PokemonWarehouseStatus() {} // Dummy constructor
	public PokemonWarehouseStatus(PokemonWarehouseId whId, ulong statusId, uint nativeUnitqueId) {} // 0x009E72D0-0x009E7370

	// Methods
	public void ReBuild(int whId, ulong statusId, uint nativeUnitqueId) {} // 0x009E7690-0x009E76B0
	public int GetFriendSortId() => default; // 0x009EC240-0x009EC2C0
	public void UpdateFriendSortId() {} // 0x009EC2C0-0x009EC340
	public SallyType GetSallyType() => default; // 0x009EC340-0x009EC3C0
	public void SetSallyType(SallyType sally) {} // 0x009EC3C0-0x009EC450
	public bool IsSallyOtherMode() => default; // 0x009EC450-0x009EC4D0
	public bool IsVisible() => default; // 0x009EC4D0-0x009EC550
	public void SetVisible(bool bEnable) {} // 0x009EC550-0x009EC5E0
	public IPokemonStatus GetStatus() => default; // 0x009EC5E0-0x009EC5F0
	public PokemonWarehouseId GetWarehouseId() => default; // 0x009EC5F0-0x009EC600
	public bool IsFavor() => default; // 0x009EC600-0x009EC680
	public void SetFavor(bool bFlag) {} // 0x009EC680-0x009EC710
}

