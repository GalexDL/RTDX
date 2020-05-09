/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.pokemon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public interface IPokemonWarehouseStatus // TypeDefIndex: 5074
{
	// Properties
	bool Favorite { get; set; }

	// Methods
	PokemonWarehouseId GetWarehouseId();
	IPokemonStatus GetStatus();
	SallyType GetSallyType();
	void SetSallyType(SallyType sally);
	bool IsSallyOtherMode();
	bool IsVisible();
	void SetVisible(bool bEnable);
	bool IsFavor();
	void SetFavor(bool bFlag);
	int GetFriendSortId();
	void UpdateFriendSortId();
}

