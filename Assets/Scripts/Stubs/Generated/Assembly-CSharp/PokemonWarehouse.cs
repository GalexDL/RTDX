/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Const.camp;
using Const.creature;
using Const.fixed_creature;
using Const.pokemon;

// Image 46: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 4339-9572

public class PokemonWarehouse : Singleton<PokemonWarehouse>, IPokemonWarehouse // TypeDefIndex: 5201
{
	// Fields
	private PokemonWarehouseStatus[] pws_; // 0x10

	// Constructors
	public PokemonWarehouse() {} // 0x009E70C0-0x009E7290

	// Methods
	public IDataList<IPokemonWarehouseStatus> GetList(bool bFirst = true /* Metadata: 0x006110BC */) => default; // 0x009E7370-0x009E7690
	public List<IPokemonWarehouseStatus> GetListForMenu() => default; // 0x009E76B0-0x009E7860
	public Dictionary<PokemonWarehouseId, IPokemonWarehouseStatus> GetDictionaryForMenu() => default; // 0x009E7860-0x009E7A30
	private IPokemonWarehouseStatus Get(int whId) => default; // 0x009E7A30-0x009E7C10
	public void SetInitializeHero(Const.creature.Index index, GenderType gender) {} // 0x009E7C10-0x009E7C90
	public IPokemonWarehouseStatus GetHeroStatus() => default; // 0x009E7C90-0x009E7CA0
	public IPokemonWarehouseStatus GetStatus(PokemonWarehouseId whId) => default; // 0x009E7CA0-0x009E7CB0
	public void SetInitializePartner(Const.creature.Index index, GenderType gender) {} // 0x009E7CC0-0x009E7D40
	public IPokemonWarehouseStatus GetPartnerStatus() => default; // 0x009E7D40-0x009E7D50
	public void SetForce(FixedWarehouseId id, Const.creature.Index pokemonIndex) {} // 0x009E7D50-0x009E7DD0
	public IPokemonWarehouseStatus GetFixedMemberStatus(FixedWarehouseId id) => default; // 0x009E7DD0-0x009E7DE0
	public bool IsFixedMemberFriend(FixedWarehouseId id) => default; // 0x009E7DE0-0x009E7E40
	public PokemonWarehouseId Add(Const.creature.Index pokemonIndex) => default; // 0x009E7E40-0x009E7F40
	public PokemonWarehouseId AddFromStatus(PokemonStatus pokemonStatus) => default; // 0x009E7F40-0x009E8080
	public bool Remove(PokemonWarehouseId warehouseId) => default; // 0x009E8080-0x009E8110
	public HashSet<int> GetHashSetExistHonkeKindNo() => default; // 0x009E8130-0x009E8300
	public HashSet<int> GetHashSetExistIndex() => default; // 0x009E8300-0x009E84D0
	public void AllClear() {} // 0x009E84D0-0x009E8640
	public void SetFull() {} // 0x009E8650-0x009E8730
	public void SetCampFull() {} // 0x009E8730-0x009E8A90
	public void SetAllCanEvoLevel() {} // 0x009E8B90-0x009E8D50
	public int CalcNumBelongingToCamp(Const.camp.Index campIndex) => default; // 0x009E8B00-0x009E8B70
	public int GetMaxNumBelongingToCamp(Const.camp.Index campIndex) => default; // 0x009E8A90-0x009E8B00
	public PokemonWarehouseId CreateProductionMember(FixedWarehouseId fixedWarehouseId, Const.creature.Index index) => default; // 0x009E8D50-0x009E8EC0
	public Const.fixed_creature.Index FindFixedCreatureParameterIndex(PokemonWarehouseId whId) => default; // 0x009E8F00-0x009E8F70
}

