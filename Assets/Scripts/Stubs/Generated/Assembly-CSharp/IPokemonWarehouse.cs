/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.creature;
using Const.pokemon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public interface IPokemonWarehouse // TypeDefIndex: 5076
{
	// Methods
	IDataList<IPokemonWarehouseStatus> GetList(bool bFirst);
	void SetInitializeHero(Index index, GenderType gender);
	IPokemonWarehouseStatus GetHeroStatus();
	void SetInitializePartner(Index index, GenderType gender);
	IPokemonWarehouseStatus GetPartnerStatus();
	IPokemonWarehouseStatus GetFixedMemberStatus(FixedWarehouseId id);
}

